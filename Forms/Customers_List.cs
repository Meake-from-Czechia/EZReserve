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
    public partial class Customers_List : Form
    {
        private AppDbContext db;
        private BindingList<Customer> customers;
        public Customers_List()
        {
            db = new AppDbContext();
            customers = new BindingList<Customer>(db.Customers.ToList());
            InitializeComponent();
        }

        private void Customers_List_Load(object sender, EventArgs e)
        {
            #region Columns custom name
            dataGridView_Customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerId",
                HeaderText = "Id"
            });
            dataGridView_Customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "Jméno"
            });
            dataGridView_Customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Příjmení"
            });
            dataGridView_Customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });
            dataGridView_Customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StreetAddress",
                HeaderText = "Adresa"
            });

            dataGridView_Customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "City",
                HeaderText = "Město"
            });
            dataGridView_Customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PostalCode",
                HeaderText = "PSČ"
            });
            #endregion
            dataGridView_Customers.DataSource = customers;

        }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            int selectedRowCustomerId = (int)dataGridView_Customers.SelectedRows[0].Cells[0].Value;
            var customersDetail = new Customers_Detail(db, selectedRowCustomerId);
            customersDetail.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var customersModify = new Customers_Modify(db, customers);
            customersModify.Show();
            dataGridView_Customers.Refresh();
            dataGridView_Customers.AutoResizeColumns();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            var customersModify = new Customers_Modify(db, (Customer)dataGridView_Customers.SelectedRows[0].DataBoundItem);
            customersModify.ShowDialog();
            dataGridView_Customers.Refresh();
            dataGridView_Customers.AutoResizeColumns();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
            db.SaveChanges();
            db.Dispose();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            var deletedCustomer = (Customer)dataGridView_Customers.SelectedRows[0].DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat zákazníka " +
                deletedCustomer.FirstName + " " + deletedCustomer.LastName + "?", "Smazání zákazníka", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            db.Customers.Remove(deletedCustomer);
            db.SaveChanges();
            customers.Remove(deletedCustomer);
        }
    }
}
