using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZReserve
{
    internal partial class Customers_Modify : Form
    {
        private AppDbContext db;
        private BindingList<Customer> bl;
        private Customer customer;
        private bool editing;
        public Customers_Modify(AppDbContext dbContext, Customer customer)
        {
            editing = true;
            db = dbContext;
            this.customer = customer;
            InitializeComponent();
            textBox_FirstName.Text = customer.FirstName;
            textBox_LastName.Text = customer.LastName;
            textBox_Email.Text = customer.Email;
            textBox_Address.Text = customer.StreetAddress;
            textBox_City.Text = customer.City;
            textBox_PostalCode.Text = customer.PostalCode;
        }
        public Customers_Modify(AppDbContext dbContext, BindingList<Customer> bl)
        {
            editing = false;
            this.bl = bl;
            db = dbContext;
            customer = new Customer();
            InitializeComponent();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (HasErrors())
            {
                return;
            }
            customer.FirstName = textBox_FirstName.Text;
            customer.LastName = textBox_LastName.Text;
            customer.Email = textBox_Email.Text;
            customer.StreetAddress = textBox_Address.Text;
            customer.City = textBox_City.Text;
            customer.PostalCode = textBox_PostalCode.Text;
            if (!editing)
            {
                db.Customers.Add(customer);
                bl.Add(customer);
            }
            db.SaveChanges();
            Close();
        }

        private bool HasErrors()
        {
            foreach (Control control in this.Controls)
            {
                if (errorProvider1.GetError(control) != string.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_FirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_FirstName.Text))
            {
                errorProvider1.SetError(textBox_FirstName, "Jméno nesmí být prázdné");
            }
            else
            {
                errorProvider1.SetError(textBox_FirstName, null);
            }
        }

        private void textBox_LastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_LastName.Text))
            {
                errorProvider1.SetError(textBox_LastName, "Příjmení nesmí být prázdné");
            }
            else
            {
                errorProvider1.SetError(textBox_LastName, null);
            }
        }

        private void textBox_Email_Validating(object sender, CancelEventArgs e)
        {
            var customersWithSameEmail = db.Customers.Where(c => c.Email == textBox_Email.Text);
            if (!Regex.IsMatch(textBox_Email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") )
            {
                errorProvider1.SetError(textBox_Email, "Email není ve správném formátu");
            }
            else if (customersWithSameEmail.Count() > 0 && customersWithSameEmail.FirstOrDefault().CustomerId != customer.CustomerId)
            {
                errorProvider1.SetError(textBox_Email, "Email je již použit");
            }
            else
            {
                errorProvider1.SetError(textBox_Email, null);
            }
        }

        private void textBox_Address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Address.Text))
            {
                errorProvider1.SetError(textBox_Address, "Adresa nesmí být prázdná");
            }
            else
            {
                errorProvider1.SetError(textBox_Address, null);
            }
        }

        private void textBox_City_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_City.Text))
            {
                errorProvider1.SetError(textBox_City, "Město nesmí být prázdné");
            }
            else
            {
                errorProvider1.SetError(textBox_City, null);
            }
        }

        private void textBox_PostalCode_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox_PostalCode.Text, @"^\d{3}\s?\d{2}$"))
            {
                errorProvider1.SetError(textBox_PostalCode, "PSČ není ve správném formátu");
            }
            else
            {
                errorProvider1.SetError(textBox_PostalCode, null);
            }
        }
    }
}
