namespace UcakRezervasyon
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
			this.dataGridViewSeats = new System.Windows.Forms.DataGridView();
			this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
			this.comboBoxAircrafts = new System.Windows.Forms.ComboBox();
			this.comboBoxDeparture = new System.Windows.Forms.ComboBox();
			this.comboBoxArrival = new System.Windows.Forms.ComboBox();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.txtCustomerSurname = new System.Windows.Forms.TextBox();
			this.txtCustomerPhone = new System.Windows.Forms.TextBox();
			this.txtCustomerEmail = new System.Windows.Forms.TextBox();
			this.btnAddReservation = new System.Windows.Forms.Button();
			this.lblAircraft = new System.Windows.Forms.Label();
			this.lblDeparture = new System.Windows.Forms.Label();
			this.lblArrival = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblCustomerSurname = new System.Windows.Forms.Label();
			this.lblCustomerPhone = new System.Windows.Forms.Label();
			this.lblCustomerEmail = new System.Windows.Forms.Label();
			this.panelSeats = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewSeats
			// 
			this.dataGridViewSeats.Location = new System.Drawing.Point(27, 33);
			this.dataGridViewSeats.Name = "dataGridViewSeats";
			this.dataGridViewSeats.Size = new System.Drawing.Size(545, 258);
			this.dataGridViewSeats.TabIndex = 0;
			this.dataGridViewSeats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeats_CellContentClick);
			// 
			// dataGridViewReservations
			// 
			this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReservations.Location = new System.Drawing.Point(620, 12);
			this.dataGridViewReservations.Name = "dataGridViewReservations";
			this.dataGridViewReservations.Size = new System.Drawing.Size(300, 262);
			this.dataGridViewReservations.TabIndex = 0;
			// 
			// comboBoxAircrafts
			// 
			this.comboBoxAircrafts.FormattingEnabled = true;
			this.comboBoxAircrafts.Location = new System.Drawing.Point(100, 320);
			this.comboBoxAircrafts.Name = "comboBoxAircrafts";
			this.comboBoxAircrafts.Size = new System.Drawing.Size(200, 21);
			this.comboBoxAircrafts.TabIndex = 1;
			this.comboBoxAircrafts.SelectedIndexChanged += new System.EventHandler(this.comboBoxAircrafts_SelectedIndexChanged);
			// 
			// comboBoxDeparture
			// 
			this.comboBoxDeparture.FormattingEnabled = true;
			this.comboBoxDeparture.Location = new System.Drawing.Point(100, 360);
			this.comboBoxDeparture.Name = "comboBoxDeparture";
			this.comboBoxDeparture.Size = new System.Drawing.Size(200, 21);
			this.comboBoxDeparture.TabIndex = 2;
			// 
			// comboBoxArrival
			// 
			this.comboBoxArrival.FormattingEnabled = true;
			this.comboBoxArrival.Location = new System.Drawing.Point(100, 400);
			this.comboBoxArrival.Name = "comboBoxArrival";
			this.comboBoxArrival.Size = new System.Drawing.Size(200, 21);
			this.comboBoxArrival.TabIndex = 3;
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Location = new System.Drawing.Point(100, 440);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerDate.TabIndex = 4;
			// 
			// dateTimePickerTime
			// 
			this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerTime.Location = new System.Drawing.Point(100, 480);
			this.dateTimePickerTime.Name = "dateTimePickerTime";
			this.dateTimePickerTime.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerTime.TabIndex = 5;
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(400, 320);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
			this.txtCustomerName.TabIndex = 6;
			// 
			// txtCustomerSurname
			// 
			this.txtCustomerSurname.Location = new System.Drawing.Point(400, 360);
			this.txtCustomerSurname.Name = "txtCustomerSurname";
			this.txtCustomerSurname.Size = new System.Drawing.Size(200, 20);
			this.txtCustomerSurname.TabIndex = 7;
			// 
			// txtCustomerPhone
			// 
			this.txtCustomerPhone.Location = new System.Drawing.Point(400, 400);
			this.txtCustomerPhone.Name = "txtCustomerPhone";
			this.txtCustomerPhone.Size = new System.Drawing.Size(200, 20);
			this.txtCustomerPhone.TabIndex = 8;
			// 
			// txtCustomerEmail
			// 
			this.txtCustomerEmail.Location = new System.Drawing.Point(400, 440);
			this.txtCustomerEmail.Name = "txtCustomerEmail";
			this.txtCustomerEmail.Size = new System.Drawing.Size(200, 20);
			this.txtCustomerEmail.TabIndex = 9;
			// 
			// btnAddReservation
			// 
			this.btnAddReservation.Location = new System.Drawing.Point(620, 320);
			this.btnAddReservation.Name = "btnAddReservation";
			this.btnAddReservation.Size = new System.Drawing.Size(100, 140);
			this.btnAddReservation.TabIndex = 10;
			this.btnAddReservation.Text = "Add Reservation";
			this.btnAddReservation.UseVisualStyleBackColor = true;
			this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
			// 
			// lblAircraft
			// 
			this.lblAircraft.AutoSize = true;
			this.lblAircraft.Location = new System.Drawing.Point(20, 320);
			this.lblAircraft.Name = "lblAircraft";
			this.lblAircraft.Size = new System.Drawing.Size(40, 13);
			this.lblAircraft.TabIndex = 11;
			this.lblAircraft.Text = "Aircraft";
			// 
			// lblDeparture
			// 
			this.lblDeparture.AutoSize = true;
			this.lblDeparture.Location = new System.Drawing.Point(20, 360);
			this.lblDeparture.Name = "lblDeparture";
			this.lblDeparture.Size = new System.Drawing.Size(54, 13);
			this.lblDeparture.TabIndex = 12;
			this.lblDeparture.Text = "Departure";
			// 
			// lblArrival
			// 
			this.lblArrival.AutoSize = true;
			this.lblArrival.Location = new System.Drawing.Point(20, 400);
			this.lblArrival.Name = "lblArrival";
			this.lblArrival.Size = new System.Drawing.Size(36, 13);
			this.lblArrival.TabIndex = 13;
			this.lblArrival.Text = "Arrival";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(20, 440);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(30, 13);
			this.lblDate.TabIndex = 14;
			this.lblDate.Text = "Date";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(20, 480);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(30, 13);
			this.lblTime.TabIndex = 15;
			this.lblTime.Text = "Time";
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Location = new System.Drawing.Point(320, 320);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(35, 13);
			this.lblCustomerName.TabIndex = 16;
			this.lblCustomerName.Text = "Name";
			// 
			// lblCustomerSurname
			// 
			this.lblCustomerSurname.AutoSize = true;
			this.lblCustomerSurname.Location = new System.Drawing.Point(320, 360);
			this.lblCustomerSurname.Name = "lblCustomerSurname";
			this.lblCustomerSurname.Size = new System.Drawing.Size(49, 13);
			this.lblCustomerSurname.TabIndex = 17;
			this.lblCustomerSurname.Text = "Surname";
			// 
			// lblCustomerPhone
			// 
			this.lblCustomerPhone.AutoSize = true;
			this.lblCustomerPhone.Location = new System.Drawing.Point(320, 400);
			this.lblCustomerPhone.Name = "lblCustomerPhone";
			this.lblCustomerPhone.Size = new System.Drawing.Size(38, 13);
			this.lblCustomerPhone.TabIndex = 18;
			this.lblCustomerPhone.Text = "Phone";
			// 
			// lblCustomerEmail
			// 
			this.lblCustomerEmail.AutoSize = true;
			this.lblCustomerEmail.Location = new System.Drawing.Point(320, 440);
			this.lblCustomerEmail.Name = "lblCustomerEmail";
			this.lblCustomerEmail.Size = new System.Drawing.Size(32, 13);
			this.lblCustomerEmail.TabIndex = 19;
			this.lblCustomerEmail.Text = "Email";
			// 
			// panelSeats
			// 
			this.panelSeats.Location = new System.Drawing.Point(27, 33);
			this.panelSeats.Name = "panelSeats";
			this.panelSeats.Size = new System.Drawing.Size(545, 258);
			this.panelSeats.TabIndex = 0;
			// 
			// ReservationForm
			// 
			this.ClientSize = new System.Drawing.Size(979, 592);
			this.Controls.Add(this.panelSeats);
			this.Controls.Add(this.lblCustomerEmail);
			this.Controls.Add(this.lblCustomerPhone);
			this.Controls.Add(this.lblCustomerSurname);
			this.Controls.Add(this.lblCustomerName);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblArrival);
			this.Controls.Add(this.lblDeparture);
			this.Controls.Add(this.lblAircraft);
			this.Controls.Add(this.btnAddReservation);
			this.Controls.Add(this.txtCustomerEmail);
			this.Controls.Add(this.txtCustomerPhone);
			this.Controls.Add(this.txtCustomerSurname);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.dateTimePickerTime);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.comboBoxArrival);
			this.Controls.Add(this.comboBoxDeparture);
			this.Controls.Add(this.comboBoxAircrafts);
			this.Controls.Add(this.dataGridViewReservations);
			this.Name = "ReservationForm";
			this.Text = "Reservation Form";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}

}