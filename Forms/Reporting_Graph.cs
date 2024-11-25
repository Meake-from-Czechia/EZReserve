using System.Data;


namespace EZReserve
{
    public partial class Reporting_Graph : Form
    {
        private DateTime from;
        private DateTime to;
        private AppDbContext db;
        private List<GraphData> data;

        internal Reporting_Graph(AppDbContext db, DateTime from, DateTime to)
        {
            this.db = db;
            this.from = from;
            this.to = to;
            InitializeComponent();

        }

        private void Reporting_Graph_Load(object sender, EventArgs e)
        {
            data = db.Reservations.GroupBy(x => x.Room)
               .Where(g => g.Any(r => r.From >= from && r.From <= to))
               .Select(g => new GraphData
               {
                   Room = g.Key,
                   Count = g.Count()
               })
               .ToList();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            int roomCount = data.Count;
            int maxCount = 0;
            try
            {
                maxCount = data.Max(x => x.Count);
            }
            catch
            {
                g.DrawString("No data", new Font("Arial", 30), Brushes.LightGray, 10, 10);
                MessageBox.Show("No data to display", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            int margin = 40;
            g.Clear(Color.White);
            g.DrawLine(new Pen(Color.Black), margin, margin, margin, height - margin);
            g.DrawLine(new Pen(Color.Black), margin, height - margin, width - margin, height - margin);
            for (int i = 0; i < roomCount; i++)
            {
                int x = margin + (width - 2 * margin) / (roomCount + 1) * (i + 1);
                int y = height - margin - (height - 2 * margin) * data[i].Count / maxCount;
                g.FillRectangle(Brushes.PowderBlue, x - 10, y, 20, height - margin - y);
                g.DrawString(data[i].Room, new Font("Arial", 12), Brushes.Black, x - 10, height - margin + 5);
                g.DrawString(data[i].Count.ToString(), new Font("Arial", 12), Brushes.Black, x - 10, y - 20);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
    }
    public class GraphData
    {
        public string Room { get; set; }
        public int Count { get; set; }
    }
}

