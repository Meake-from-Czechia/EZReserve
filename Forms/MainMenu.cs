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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button_Customers_Click(object sender, EventArgs e)
        {
            var customersList = new Customers_List();
            customersList.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Reservations_Click(object sender, EventArgs e)
        {
            var reservationsList = new Reservations_List();
            reservationsList.Show();
        }

        private void button_Reporting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ještě není implementováno.");
        }
    }
}
