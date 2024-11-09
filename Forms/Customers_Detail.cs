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

    public partial class Customers_Detail : Form
    {
        private AppDbContext db;
        private int customerId;
        internal Customers_Detail(AppDbContext db, int customerId)
        {
            this.db = db;
            this.customerId = customerId;
            InitializeComponent();
        }

        private void Customers_Detail_Load(object sender, EventArgs e)
        {
            var customer = db.Customers.Find(customerId);
            label_Id.Text = customer.CustomerId.ToString();
            label_FirstName.Text = customer.FirstName;
            label_LastName.Text = customer.LastName;
            label_Email.Text = customer.Email;
            label_StreetAddress.Text = customer.StreetAddress;
            label_City.Text = customer.City;
            label_PostalCode.Text = customer.PostalCode;
            
            // dataGridView_Reservations.DataSource = customer.Reservations;
            #region Columns custom name
            dataGridView_Reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ReservationId",
                HeaderText = "Id"
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
                HeaderText = "Od"
            });
            dataGridView_Reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "To",
                HeaderText = "Do"
            });
            dataGridView_Reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Customer",
                HeaderText = "Zákazník",
                Visible = false
            });
            #endregion
            dataGridView_Reservations.DataSource = db.Reservations.Where(r => r.CustomerId == customerId).ToList();

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
