using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakRezervasyon
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initial load can be empty or load a default form
        }

        private void btnAircraft_Click(object sender, EventArgs e)
        {
            var aircraftForm = new AircraftForm();
            aircraftForm.Show();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            var locationForm = new LocationForm();
            locationForm.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            var reservationForm = new ReservationForm();
            reservationForm.Show();
        }
    }
}
