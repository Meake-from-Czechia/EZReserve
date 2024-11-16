using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZReserve
{
    public partial class Reservations_List : Form
    {
        private AppDbContext db;
        private BindingList<Reservation> Reservations;
        public Reservations_List()
        {
            db = new AppDbContext();
            Reservations = new BindingList<Reservation>(db.Reservations.Include(x => x.Customer).ToList());
            InitializeComponent();
        }

        private void Reservations_List_Load(object sender, EventArgs e)
        {
            #region Columns custom name
            dataGridView_Reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ReservationId",
                HeaderText = "Id"
            });
            dataGridView_Reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Customer",
                HeaderText = "Jméno zákazníka",
                Name = "Customer"

            });
            dataGridView_Reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerId",
                HeaderText = "Id zákazníka",
                Visible = false
            });
            dataGridView_Reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Room",
                HeaderText = "Místnost"
            });
            dataGridView_Reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "From",
                HeaderText = "Začátek rezervace"
            });
            dataGridView_Reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "To",
                HeaderText = "Konec rezervace"
            });
            #endregion
            
            dataGridView_Reservations.DataSource = Reservations;

        }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            
            int selectedRowReservationId = (int)dataGridView_Reservations.SelectedRows[0].Cells[0].Value;
            var ReservationsDetail = new Reservations_Detail(db, selectedRowReservationId);
            ReservationsDetail.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var ReservationsModify = new Reservations_Modify(db, Reservations);
            ReservationsModify.Show();
            dataGridView_Reservations.Refresh();
            dataGridView_Reservations.AutoResizeColumns();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            var ReservationsModify = new Reservations_Modify(db, (Reservation)dataGridView_Reservations.SelectedRows[0].DataBoundItem);
            ReservationsModify.ShowDialog();
            dataGridView_Reservations.Refresh();
            dataGridView_Reservations.AutoResizeColumns();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
            db.SaveChanges();
            db.Dispose();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            var deletedReservation = (Reservation)dataGridView_Reservations.SelectedRows[0].DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat rezervaci zákazníka " +
                deletedReservation.Customer.FirstName + " " + deletedReservation.Customer.LastName + "?", "Smazání rezervace", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            db.Reservations.Remove(deletedReservation);
            db.SaveChanges();
            Reservations.Remove(deletedReservation);
        }
    }
}
