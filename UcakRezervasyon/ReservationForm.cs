using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore; // Added this line

namespace UcakRezervasyon
{
	public partial class ReservationForm : Form
	{
		private ApplicationDbContext _context;

		public ReservationForm()
		{
			InitializeComponent();
			_context = new ApplicationDbContext();
			LoadReservations();
			LoadAircrafts();
			LoadLocations();
			LoadSeats(); // Koltukları yükle
		}

		private void LoadReservations()
		{
			var reservations = _context.Reservations.Include(r => r.Aircraft).Include(r => r.DepartureLocation).Include(r => r.ArrivalLocation).ToList();
			dataGridViewReservations.DataSource = reservations;
		}

		private void LoadAircrafts()
		{
			var aircrafts = _context.Aircrafts.ToList();
			comboBoxAircrafts.DataSource = aircrafts;
			comboBoxAircrafts.DisplayMember = "Model";
			comboBoxAircrafts.ValueMember = "Id";
		}

		private void LoadLocations()
		{
			var locations = _context.Locations.ToList();
			comboBoxDeparture.DataSource = locations;
			comboBoxDeparture.DisplayMember = "City";
			comboBoxDeparture.ValueMember = "Id";

			comboBoxArrival.DataSource = locations;
			comboBoxArrival.DisplayMember = "City";
			comboBoxArrival.ValueMember = "Id";
		}
		private void LoadSeats()
		{
			if (comboBoxAircrafts.SelectedValue is int selectedAircraftId)
			{
				var selectedAircraft = _context.Aircrafts.FirstOrDefault(a => a.Id == selectedAircraftId);
				if (selectedAircraft != null)
				{
					int seatCapacity = selectedAircraft.SeatCapacity;
					var seatStatus = JsonConvert.DeserializeObject<Dictionary<string, string>>(GetSeatStatusJson());
					panelSeats.Controls.Clear(); // Paneli temizle
					for (int i = 1; i <= seatCapacity; i++)
					{
						string seatNumber = $"Seat {i}";
						bool isAvailable = !seatStatus.ContainsKey(seatNumber) || seatStatus[seatNumber] == "Available";
						Button btnSeat = new Button
						{
							Text = seatNumber,
							BackColor = isAvailable ? Color.Green : Color.Red,
							Width = 50,
							Height = 50,
							Margin = new Padding(5)
						};
						btnSeat.Click += BtnSeat_Click;
						panelSeats.Controls.Add(btnSeat);
					}
				}
			}
		}

		private void btnAddReservation_Click(object sender, EventArgs e)
		{
			var reservation = new Reservation
			{
				AircraftId = (int)comboBoxAircrafts.SelectedValue,
				DepartureLocationId = (int)comboBoxDeparture.SelectedValue,
				ArrivalLocationId = (int)comboBoxArrival.SelectedValue,
				Date = dateTimePickerDate.Value,
				Time = dateTimePickerTime.Value.TimeOfDay,
				SelectedSeat = GetSelectedSeat(), // Seçilen koltuk
				CustomerName = txtCustomerName.Text,
				CustomerSurname = txtCustomerSurname.Text,
				CustomerPhone = txtCustomerPhone.Text,
				CustomerEmail = txtCustomerEmail.Text
			};

			_context.Reservations.Add(reservation);
			_context.SaveChanges();
			LoadReservations();
		}

		private string GetSeatStatusJson()
		{
			var seatStatus = new Dictionary<string, string>();
			foreach (Control control in panelSeats.Controls)
			{
				if (control is Button btnSeat)
				{
					string seatNumber = btnSeat.Text;
					string status = btnSeat.BackColor == Color.Green ? "Available" : "Sold";
					seatStatus[seatNumber] = status;
				}
			}
			return JsonConvert.SerializeObject(seatStatus);
		}

		private string GetSelectedSeat()
		{
			foreach (Control control in panelSeats.Controls)
			{
				if (control is Button btnSeat && btnSeat.BackColor == Color.Red)
				{
					return btnSeat.Text;
				}
			}
			return null;
		}

		private void dataGridViewSeats_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				var cell = dataGridViewSeats.Rows[e.RowIndex].Cells[e.ColumnIndex];
				if (cell.Style.BackColor == Color.Green)
				{
					cell.Style.BackColor = Color.Red;
					// Müşteri bilgilerini gösterme işlemi
					txtCustomerName.Text = "Yeni Müşteri Adı";
					txtCustomerSurname.Text = "Yeni Müşteri Soyadı";
					txtCustomerPhone.Text = "Yeni Müşteri Telefon";
					txtCustomerEmail.Text = "Yeni Müşteri Email";
				}
				else if (cell.Style.BackColor == Color.Red)
				{
					cell.Style.BackColor = Color.Green;
					// Müşteri bilgilerini temizleme işlemi
					txtCustomerName.Text = "";
					txtCustomerSurname.Text = "";
					txtCustomerPhone.Text = "";
					txtCustomerEmail.Text = "";
				}
			}
		}

		private void dataGridViewSeats_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Metod içeriği burada olacak
		}

		private void comboBoxAircrafts_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadSeats();
		}

		private void BtnSeat_Click(object sender, EventArgs e)
		{
			Button btnSeat = sender as Button;
			if (btnSeat.BackColor == Color.Green)
			{
				btnSeat.BackColor = Color.Red;
				// Müşteri bilgilerini gösterme işlemi
				txtCustomerName.Text = "Yeni Müşteri Adı";
				txtCustomerSurname.Text = "Yeni Müşteri Soyadı";
				txtCustomerPhone.Text = "Yeni Müşteri Telefon";
				txtCustomerEmail.Text = "Yeni Müşteri Email";
			}
			else if (btnSeat.BackColor == Color.Red)
			{
				btnSeat.BackColor = Color.Green;
				// Müşteri bilgilerini temizleme işlemi
				txtCustomerName.Text = "";
				txtCustomerSurname.Text = "";
				txtCustomerPhone.Text = "";
				txtCustomerEmail.Text = "";
			}
		}
	}

}
