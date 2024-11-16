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

    public partial class Reservations_Detail : Form
    {
        private AppDbContext db;
        private int ReservationId;
        private Reservation reservation;
        internal Reservations_Detail(AppDbContext db, int ReservationId)
        {
            this.db = db;
            this.ReservationId = ReservationId;
            InitializeComponent();
        }

        private void Reservations_Detail_Load(object sender, EventArgs e)
        {
            reservation = db.Reservations.Include(x => x.Customer).FirstOrDefault(x => x.ReservationId == ReservationId);
            label_Id.Text = reservation.ReservationId.ToString();
            label_Customer.Text = reservation.Customer.ToString();
            label_Room.Text = reservation.Room;
            label_From.Text = reservation.From.ToString("g");
            label_To.Text = reservation.To.ToString("g");

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            var customerForm = new Customers_Detail(db, reservation.CustomerId);
            customerForm.Show();
        }
    }
}
