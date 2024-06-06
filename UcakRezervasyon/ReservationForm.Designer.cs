﻿namespace UcakRezervasyon
{
	partial class ReservationForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			dataGridViewSeats = new DataGridView();
			dataGridViewReservations = new DataGridView();
			comboBoxAircrafts = new ComboBox();
			comboBoxDeparture = new ComboBox();
			comboBoxArrival = new ComboBox();
			dateTimePickerDate = new DateTimePicker();
			dateTimePickerTime = new DateTimePicker();
			txtCustomerName = new TextBox();
			txtCustomerSurname = new TextBox();
			txtCustomerPhone = new TextBox();
			txtCustomerEmail = new TextBox();
			btnAddReservation = new Button();
			lblAircraft = new Label();
			lblDeparture = new Label();
			lblArrival = new Label();
			lblDate = new Label();
			lblTime = new Label();
			lblCustomerName = new Label();
			lblCustomerSurname = new Label();
			lblCustomerPhone = new Label();
			lblCustomerEmail = new Label();
			panelSeats = new Panel();
			comboBoxGender = new ComboBox();
			lblGender = new Label();
			txtCustomerAge = new TextBox();
			lblCustomerAge = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewSeats).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewSeats
			// 
			dataGridViewSeats.Location = new Point(27, 33);
			dataGridViewSeats.Name = "dataGridViewSeats";
			dataGridViewSeats.Size = new Size(545, 258);
			dataGridViewSeats.TabIndex = 0;
			dataGridViewSeats.CellContentClick += dataGridViewSeats_CellContentClick;
			// 
			// dataGridViewReservations
			// 
			dataGridViewReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewReservations.Location = new Point(12, 52);
			dataGridViewReservations.Name = "dataGridViewReservations";
			dataGridViewReservations.Size = new Size(489, 262);
			dataGridViewReservations.TabIndex = 0;
			// 
			// comboBoxAircrafts
			// 
			comboBoxAircrafts.FormattingEnabled = true;
			comboBoxAircrafts.Location = new Point(713, 52);
			comboBoxAircrafts.Name = "comboBoxAircrafts";
			comboBoxAircrafts.Size = new Size(200, 23);
			comboBoxAircrafts.TabIndex = 1;
			comboBoxAircrafts.SelectedIndexChanged += comboBoxAircrafts_SelectedIndexChanged;
			// 
			// comboBoxDeparture
			// 
			comboBoxDeparture.FormattingEnabled = true;
			comboBoxDeparture.Location = new Point(713, 92);
			comboBoxDeparture.Name = "comboBoxDeparture";
			comboBoxDeparture.Size = new Size(200, 23);
			comboBoxDeparture.TabIndex = 2;
			comboBoxDeparture.SelectedIndexChanged += comboBoxDeparture_SelectedIndexChanged;
			// 
			// comboBoxArrival
			// 
			comboBoxArrival.FormattingEnabled = true;
			comboBoxArrival.Location = new Point(713, 132);
			comboBoxArrival.Name = "comboBoxArrival";
			comboBoxArrival.Size = new Size(200, 23);
			comboBoxArrival.TabIndex = 3;
			comboBoxArrival.SelectedIndexChanged += comboBoxArrival_SelectedIndexChanged;
			// 
			// dateTimePickerDate
			// 
			dateTimePickerDate.Location = new Point(713, 172);
			dateTimePickerDate.Name = "dateTimePickerDate";
			dateTimePickerDate.Size = new Size(200, 23);
			dateTimePickerDate.TabIndex = 4;
			// 
			// dateTimePickerTime
			// 
			dateTimePickerTime.Format = DateTimePickerFormat.Time;
			dateTimePickerTime.Location = new Point(713, 212);
			dateTimePickerTime.Name = "dateTimePickerTime";
			dateTimePickerTime.Size = new Size(200, 23);
			dateTimePickerTime.TabIndex = 5;
			// 
			// txtCustomerName
			// 
			txtCustomerName.Location = new Point(1013, 52);
			txtCustomerName.Name = "txtCustomerName";
			txtCustomerName.Size = new Size(200, 23);
			txtCustomerName.TabIndex = 6;
			// 
			// txtCustomerSurname
			// 
			txtCustomerSurname.Location = new Point(1013, 92);
			txtCustomerSurname.Name = "txtCustomerSurname";
			txtCustomerSurname.Size = new Size(200, 23);
			txtCustomerSurname.TabIndex = 7;
			// 
			// txtCustomerPhone
			// 
			txtCustomerPhone.Location = new Point(1013, 132);
			txtCustomerPhone.Name = "txtCustomerPhone";
			txtCustomerPhone.Size = new Size(200, 23);
			txtCustomerPhone.TabIndex = 8;
			// 
			// txtCustomerEmail
			// 
			txtCustomerEmail.Location = new Point(1013, 172);
			txtCustomerEmail.Name = "txtCustomerEmail";
			txtCustomerEmail.Size = new Size(200, 23);
			txtCustomerEmail.TabIndex = 9;
			// 
			// btnAddReservation
			// 
			btnAddReservation.Location = new Point(1252, 252);
			btnAddReservation.Name = "btnAddReservation";
			btnAddReservation.Size = new Size(118, 63);
			btnAddReservation.TabIndex = 10;
			btnAddReservation.Text = "Rezervasyon Yap";
			btnAddReservation.UseVisualStyleBackColor = true;
			btnAddReservation.Click += btnAddReservation_Click;
			// 
			// lblAircraft
			// 
			lblAircraft.AutoSize = true;
			lblAircraft.Location = new Point(633, 52);
			lblAircraft.Name = "lblAircraft";
			lblAircraft.Size = new Size(33, 15);
			lblAircraft.TabIndex = 11;
			lblAircraft.Text = "Ucak";
			// 
			// lblDeparture
			// 
			lblDeparture.AutoSize = true;
			lblDeparture.Location = new Point(633, 92);
			lblDeparture.Name = "lblDeparture";
			lblDeparture.Size = new Size(37, 15);
			lblDeparture.TabIndex = 12;
			lblDeparture.Text = "Kalkış";
			// 
			// lblArrival
			// 
			lblArrival.AutoSize = true;
			lblArrival.Location = new Point(633, 132);
			lblArrival.Name = "lblArrival";
			lblArrival.Size = new Size(31, 15);
			lblArrival.TabIndex = 13;
			lblArrival.Text = "Varış";
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Location = new Point(633, 172);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(32, 15);
			lblDate.TabIndex = 14;
			lblDate.Text = "Tarih";
			// 
			// lblTime
			// 
			lblTime.AutoSize = true;
			lblTime.Location = new Point(633, 212);
			lblTime.Name = "lblTime";
			lblTime.Size = new Size(29, 15);
			lblTime.TabIndex = 15;
			lblTime.Text = "Saat";
			// 
			// lblCustomerName
			// 
			lblCustomerName.AutoSize = true;
			lblCustomerName.Location = new Point(933, 52);
			lblCustomerName.Name = "lblCustomerName";
			lblCustomerName.Size = new Size(22, 15);
			lblCustomerName.TabIndex = 16;
			lblCustomerName.Text = "Ad";
			// 
			// lblCustomerSurname
			// 
			lblCustomerSurname.AutoSize = true;
			lblCustomerSurname.Location = new Point(933, 92);
			lblCustomerSurname.Name = "lblCustomerSurname";
			lblCustomerSurname.Size = new Size(39, 15);
			lblCustomerSurname.TabIndex = 17;
			lblCustomerSurname.Text = "Soyad";
			// 
			// lblCustomerPhone
			// 
			lblCustomerPhone.AutoSize = true;
			lblCustomerPhone.Location = new Point(933, 132);
			lblCustomerPhone.Name = "lblCustomerPhone";
			lblCustomerPhone.Size = new Size(45, 15);
			lblCustomerPhone.TabIndex = 18;
			lblCustomerPhone.Text = "Telefon";
			// 
			// lblCustomerEmail
			// 
			lblCustomerEmail.AutoSize = true;
			lblCustomerEmail.Location = new Point(933, 172);
			lblCustomerEmail.Name = "lblCustomerEmail";
			lblCustomerEmail.Size = new Size(36, 15);
			lblCustomerEmail.TabIndex = 19;
			lblCustomerEmail.Text = "Email";
			// 
			// panelSeats
			// 
			panelSeats.Location = new Point(22, 331);
			panelSeats.Name = "panelSeats";
			panelSeats.Size = new Size(1191, 258);
			panelSeats.TabIndex = 0;
			panelSeats.Paint += panelSeats_Paint;
			// 
			// comboBoxGender
			// 
			comboBoxGender.FormattingEnabled = true;
			comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
			comboBoxGender.Location = new Point(1013, 212);
			comboBoxGender.Name = "comboBoxGender";
			comboBoxGender.Size = new Size(200, 23);
			comboBoxGender.TabIndex = 21;
			// 
			// lblGender
			// 
			lblGender.AutoSize = true;
			lblGender.Location = new Point(933, 212);
			lblGender.Name = "lblGender";
			lblGender.Size = new Size(49, 15);
			lblGender.TabIndex = 20;
			lblGender.Text = "Cinsiyet";
			// 
			// txtCustomerAge
			// 
			txtCustomerAge.Location = new Point(1013, 252);
			txtCustomerAge.Name = "txtCustomerAge";
			txtCustomerAge.Size = new Size(200, 23);
			txtCustomerAge.TabIndex = 23;
			// 
			// lblCustomerAge
			// 
			lblCustomerAge.AutoSize = true;
			lblCustomerAge.Location = new Point(933, 252);
			lblCustomerAge.Name = "lblCustomerAge";
			lblCustomerAge.Size = new Size(24, 15);
			lblCustomerAge.TabIndex = 22;
			lblCustomerAge.Text = "Yaş";
			// 
			// ReservationForm
			// 
			ClientSize = new Size(1564, 592);
			Controls.Add(panelSeats);
			Controls.Add(lblCustomerEmail);
			Controls.Add(lblCustomerPhone);
			Controls.Add(lblCustomerSurname);
			Controls.Add(lblCustomerName);
			Controls.Add(lblTime);
			Controls.Add(lblDate);
			Controls.Add(lblArrival);
			Controls.Add(lblDeparture);
			Controls.Add(lblAircraft);
			Controls.Add(btnAddReservation);
			Controls.Add(txtCustomerEmail);
			Controls.Add(txtCustomerPhone);
			Controls.Add(txtCustomerSurname);
			Controls.Add(txtCustomerName);
			Controls.Add(dateTimePickerTime);
			Controls.Add(dateTimePickerDate);
			Controls.Add(comboBoxArrival);
			Controls.Add(comboBoxDeparture);
			Controls.Add(comboBoxAircrafts);
			Controls.Add(dataGridViewReservations);
			Controls.Add(lblGender);
			Controls.Add(comboBoxGender);
			Controls.Add(lblCustomerAge);
			Controls.Add(txtCustomerAge);
			Name = "ReservationForm";
			Text = "Reservation Form";
			((System.ComponentModel.ISupportInitialize)dataGridViewSeats).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private System.Windows.Forms.DataGridView dataGridViewReservations;
		private System.Windows.Forms.ComboBox comboBoxAircrafts;
		private System.Windows.Forms.ComboBox comboBoxDeparture;
		private System.Windows.Forms.ComboBox comboBoxArrival;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerTime;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.TextBox txtCustomerSurname;
		private System.Windows.Forms.TextBox txtCustomerPhone;
		private System.Windows.Forms.TextBox txtCustomerEmail;
		private System.Windows.Forms.Button btnAddReservation;
		private System.Windows.Forms.Label lblAircraft;
		private System.Windows.Forms.Label lblDeparture;
		private System.Windows.Forms.Label lblArrival;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.Label lblCustomerSurname;
		private System.Windows.Forms.Label lblCustomerPhone;
		private System.Windows.Forms.Label lblCustomerEmail;
		private System.Windows.Forms.DataGridView dataGridViewSeats;
		private System.Windows.Forms.Panel panelSeats;
		private System.Windows.Forms.ComboBox comboBoxGender;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.TextBox txtCustomerAge;
		private System.Windows.Forms.Label lblCustomerAge;
	}

}