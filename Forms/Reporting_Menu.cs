using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EZReserve
{
    public partial class Reporting_Menu : Form
    {
        private AppDbContext db { get; set; }
        public Reporting_Menu()
        {
            InitializeComponent();
            db = new AppDbContext();
        }

        private void button_ExportCsv_Click(object sender, EventArgs e)
        {
            string fileName = "report.csv";
            CsvExporter exporter = new CsvExporter();
            Export(exporter, fileName);
        }
        private void button_ExportExcel_Click(object sender, EventArgs e)
        {
            string fileName = "report.xlsx";
            ExcelExporter exporter = new ExcelExporter();
            Export(exporter, fileName);
        }
        private void Export(IExportable exporter, string fileName)
        {
            DateTime dateFrom = dateTimePicker_DateFrom.Value;
            DateTime dateTo = dateTimePicker_DateTo.Value;

            if (exporter.Export(fileName, db.GetExportDtos(dateFrom, dateTo)) != 0)
            {
                MessageBox.Show("Nastala chyba v generování souboru, více detailů naleznete v souboru export.log", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Soubor byl úspěšně vygenerován", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Graph_Click(object sender, EventArgs e)
        {
            var graph = new Reporting_Graph(db, dateTimePicker_DateFrom.Value, dateTimePicker_DateTo.Value);
            graph.Show();
        }
    }
}
