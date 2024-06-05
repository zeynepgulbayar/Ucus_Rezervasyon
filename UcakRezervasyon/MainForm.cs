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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnAircraftForm_Click(object sender, EventArgs e)
		{
			var aircraftForm = new AircraftForm();
			aircraftForm.ShowDialog();
		}

		private void btnLocationForm_Click(object sender, EventArgs e)
		{
			var locationForm = new LocationForm();
			locationForm.ShowDialog();
		}

		private void btnReservationForm_Click(object sender, EventArgs e)
		{
			var reservationForm = new ReservationForm();
			reservationForm.ShowDialog();
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			// Load işlemleri burada yapılacak
		}
	}


}
