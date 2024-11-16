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
    internal partial class Reservations_Modify : Form
    {
        private AppDbContext db;
        private BindingList<Reservation> bl;
        private Reservation reservation;
        private bool editing;
        public Reservations_Modify(AppDbContext dbContext, Reservation reservation)
        {
            editing = true;
            db = dbContext;
            this.reservation = reservation;
            InitializeComponent();
            LoadCustomers();
            LoadRooms();
            comboBox_Customer.SelectedValue = reservation.CustomerId;
            comboBox_Room.SelectedItem = reservation.Room;
            dateTimePicker_From.Value = reservation.From;
            dateTimePicker_To.Value = reservation.To;
            comboBox_Customer.Enabled = false;
        }
        public Reservations_Modify(AppDbContext dbContext, BindingList<Reservation> bl)
        {
            editing = false;
            this.bl = bl;
            db = dbContext;
            reservation = new Reservation();
            InitializeComponent();
            LoadCustomers();
            LoadRooms();
        }
        private void LoadCustomers()
        {
            var customers = db.Customers.ToList();
            comboBox_Customer.DataSource = customers;
            comboBox_Customer.ValueMember = "CustomerId";
            comboBox_Customer.DisplayMember = "FullName";
        }
        private void LoadRooms()
        {
            List<string> rooms = new List<string>()
            {
                "01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
                "101", "102", "103", "104", "105", "106", "107", "108", "109", "110",
                "201", "202", "203", "204", "205", "206", "207", "208", "209", "210",
            };
            comboBox_Room.DataSource = rooms;
        }
        private void button_Accept_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (HasErrors())
            {
                return;
            }
            if (HasOverlappingReservation())
            {
                MessageBox.Show("Rezervace se překrývá s jinou rezervací.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reservation.CustomerId = (int)comboBox_Customer.SelectedValue!;
            reservation.Room = (string)comboBox_Room.SelectedItem!;
            reservation.From = dateTimePicker_From.Value;
            reservation.To = dateTimePicker_To.Value;
            if (!editing)
            {
                db.Reservations.Add(reservation);
                bl.Add(reservation);
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

        private void comboBox_Customer_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox_Customer.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox_Customer, "Není vybrán zákazník");
            }
            else
            {
                errorProvider1.SetError(comboBox_Customer, string.Empty);
            }
        }

        private void comboBox_Room_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox_Room.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox_Room, "Není vybrána místnost");
            }
            else
            {
                errorProvider1.SetError(comboBox_Room, string.Empty);
            }
        }

        private void dateTimePicker_From_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker_From.Value < DateTime.Now)
            {
                errorProvider1.SetError(dateTimePicker_From, "Datum nesmí být v minulosti");
            }
            else if (dateTimePicker_From.Value >= dateTimePicker_To.Value)
            {
                errorProvider1.SetError(dateTimePicker_From, "Datum musí být před koncem rezervace");
            }
            else
            {
                errorProvider1.SetError(dateTimePicker_From, string.Empty);
            }
        }

        private void dateTimePicker_To_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker_To.Value < DateTime.Now)
            {
                errorProvider1.SetError(dateTimePicker_To, "Datum nesmí být v minulosti");
            }
            else if (dateTimePicker_To.Value <= dateTimePicker_From.Value)
            {
                errorProvider1.SetError(dateTimePicker_To, "Datum musí být po začátku rezervace");
            }
            else
            {
                errorProvider1.SetError(dateTimePicker_To, string.Empty);
            }
        }
        private bool HasOverlappingReservation()
        {
            return db.Reservations.Any(r =>
                r.Room == (string)comboBox_Room.SelectedValue &&
                r.ReservationId != reservation.ReservationId &&
                (
                    (r.From < dateTimePicker_To.Value && r.To > dateTimePicker_From.Value) || // Overlaps with the new reservation
                    (r.From >= dateTimePicker_From.Value && r.From < dateTimePicker_To.Value) || // Starts during the new reservation
                    (r.To > dateTimePicker_From.Value && r.To <= dateTimePicker_To.Value) // Ends during the new reservation
                ));
        }

    }
}
