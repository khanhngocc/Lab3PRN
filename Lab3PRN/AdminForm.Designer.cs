namespace Lab3PRN
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAirplane = new System.Windows.Forms.TabPage();
            this.btnClearAirplane = new System.Windows.Forms.Button();
            this.txtIdAirplane = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridAirplane = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameAirplane = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_airway_station = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClearFlight = new System.Windows.Forms.Button();
            this.txtNameFlight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboDirection = new System.Windows.Forms.ComboBox();
            this.txtNoSeat = new System.Windows.Forms.TextBox();
            this.No_Seat = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridFlight = new System.Windows.Forms.DataGridView();
            this.btnFRemove = new System.Windows.Forms.Button();
            this.btnFAdd = new System.Windows.Forms.Button();
            this.comboAirplane = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboACountry = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboDCountry = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_arr_date = new System.Windows.Forms.TextBox();
            this.txt_dep_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_arr_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dep_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlightId = new System.Windows.Forms.TextBox();
            this.FlightId = new System.Windows.Forms.Label();
            this.FeedBack = new System.Windows.Forms.TabPage();
            this.dataGridInbox = new System.Windows.Forms.DataGridView();
            this.btnRemoveMess = new System.Windows.Forms.Button();
            this.txt_id_mess = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.View_Booking = new System.Windows.Forms.TabPage();
            this.btnAsyn = new System.Windows.Forms.Button();
            this.dataGridBooking = new System.Windows.Forms.DataGridView();
            this.tabStatisticTicket = new System.Windows.Forms.TabPage();
            this.dataGridStatistic = new System.Windows.Forms.DataGridView();
            this.comboStatistic = new System.Windows.Forms.ComboBox();
            this.btnAsynStatistic = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBooked = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFree = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEarnMoney = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFilterFeedback = new System.Windows.Forms.TextBox();
            this.btnFilterFeedBack = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFilterBooking = new System.Windows.Forms.TextBox();
            this.btnFilterBooking = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAirplane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirplane)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFlight)).BeginInit();
            this.FeedBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInbox)).BeginInit();
            this.View_Booking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooking)).BeginInit();
            this.tabStatisticTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAirplane);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.FeedBack);
            this.tabControl1.Controls.Add(this.View_Booking);
            this.tabControl1.Controls.Add(this.tabStatisticTicket);
            this.tabControl1.Location = new System.Drawing.Point(28, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1069, 722);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAirplane
            // 
            this.tabPageAirplane.Controls.Add(this.btnClearAirplane);
            this.tabPageAirplane.Controls.Add(this.txtIdAirplane);
            this.tabPageAirplane.Controls.Add(this.label2);
            this.tabPageAirplane.Controls.Add(this.dataGridAirplane);
            this.tabPageAirplane.Controls.Add(this.btnRemove);
            this.tabPageAirplane.Controls.Add(this.btnAdd);
            this.tabPageAirplane.Controls.Add(this.txtNameAirplane);
            this.tabPageAirplane.Controls.Add(this.label1);
            this.tabPageAirplane.Location = new System.Drawing.Point(4, 25);
            this.tabPageAirplane.Name = "tabPageAirplane";
            this.tabPageAirplane.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAirplane.Size = new System.Drawing.Size(1061, 693);
            this.tabPageAirplane.TabIndex = 0;
            this.tabPageAirplane.Text = "Airplane Manipulation";
            this.tabPageAirplane.UseVisualStyleBackColor = true;
            // 
            // btnClearAirplane
            // 
            this.btnClearAirplane.Location = new System.Drawing.Point(296, 138);
            this.btnClearAirplane.Name = "btnClearAirplane";
            this.btnClearAirplane.Size = new System.Drawing.Size(89, 41);
            this.btnClearAirplane.TabIndex = 7;
            this.btnClearAirplane.Text = "Clear";
            this.btnClearAirplane.UseVisualStyleBackColor = true;
            this.btnClearAirplane.Click += new System.EventHandler(this.btnClearAirplane_Click);
            // 
            // txtIdAirplane
            // 
            this.txtIdAirplane.Location = new System.Drawing.Point(131, 45);
            this.txtIdAirplane.Name = "txtIdAirplane";
            this.txtIdAirplane.Size = new System.Drawing.Size(195, 22);
            this.txtIdAirplane.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // dataGridAirplane
            // 
            this.dataGridAirplane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAirplane.Location = new System.Drawing.Point(72, 203);
            this.dataGridAirplane.Name = "dataGridAirplane";
            this.dataGridAirplane.RowHeadersWidth = 51;
            this.dataGridAirplane.RowTemplate.Height = 24;
            this.dataGridAirplane.Size = new System.Drawing.Size(547, 466);
            this.dataGridAirplane.TabIndex = 4;
            this.dataGridAirplane.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAirplane_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(185, 138);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 41);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNameAirplane
            // 
            this.txtNameAirplane.Location = new System.Drawing.Point(131, 89);
            this.txtNameAirplane.Name = "txtNameAirplane";
            this.txtNameAirplane.Size = new System.Drawing.Size(195, 22);
            this.txtNameAirplane.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_airway_station);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.btnClearFlight);
            this.tabPage2.Controls.Add(this.txtNameFlight);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.comboType);
            this.tabPage2.Controls.Add(this.comboDirection);
            this.tabPage2.Controls.Add(this.txtNoSeat);
            this.tabPage2.Controls.Add(this.No_Seat);
            this.tabPage2.Controls.Add(this.txtPrice);
            this.tabPage2.Controls.Add(this.Price);
            this.tabPage2.Controls.Add(this.Type);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridFlight);
            this.tabPage2.Controls.Add(this.btnFRemove);
            this.tabPage2.Controls.Add(this.btnFAdd);
            this.tabPage2.Controls.Add(this.comboAirplane);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboACountry);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.comboDCountry);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_arr_date);
            this.tabPage2.Controls.Add(this.txt_dep_date);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_arr_time);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_dep_time);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtFlightId);
            this.tabPage2.Controls.Add(this.FlightId);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 693);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flight Manipulation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_airway_station
            // 
            this.txt_airway_station.Location = new System.Drawing.Point(486, 190);
            this.txt_airway_station.Name = "txt_airway_station";
            this.txt_airway_station.Size = new System.Drawing.Size(169, 22);
            this.txt_airway_station.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(387, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Airway_station";
            // 
            // btnClearFlight
            // 
            this.btnClearFlight.Location = new System.Drawing.Point(281, 241);
            this.btnClearFlight.Name = "btnClearFlight";
            this.btnClearFlight.Size = new System.Drawing.Size(90, 37);
            this.btnClearFlight.TabIndex = 32;
            this.btnClearFlight.Text = "Clear";
            this.btnClearFlight.UseVisualStyleBackColor = true;
            this.btnClearFlight.Click += new System.EventHandler(this.btnClearFlight_Click);
            // 
            // txtNameFlight
            // 
            this.txtNameFlight.Location = new System.Drawing.Point(172, 190);
            this.txtNameFlight.Name = "txtNameFlight";
            this.txtNameFlight.Size = new System.Drawing.Size(169, 22);
            this.txtNameFlight.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Name";
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "VIP",
            "Normal"});
            this.comboType.Location = new System.Drawing.Point(781, 61);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(169, 24);
            this.comboType.TabIndex = 29;
            // 
            // comboDirection
            // 
            this.comboDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDirection.FormattingEnabled = true;
            this.comboDirection.Items.AddRange(new object[] {
            "One-way",
            "Round-trip"});
            this.comboDirection.Location = new System.Drawing.Point(781, 20);
            this.comboDirection.Name = "comboDirection";
            this.comboDirection.Size = new System.Drawing.Size(169, 24);
            this.comboDirection.TabIndex = 28;
            // 
            // txtNoSeat
            // 
            this.txtNoSeat.Location = new System.Drawing.Point(781, 150);
            this.txtNoSeat.Name = "txtNoSeat";
            this.txtNoSeat.Size = new System.Drawing.Size(169, 22);
            this.txtNoSeat.TabIndex = 27;
            // 
            // No_Seat
            // 
            this.No_Seat.AutoSize = true;
            this.No_Seat.Location = new System.Drawing.Point(701, 150);
            this.No_Seat.Name = "No_Seat";
            this.No_Seat.Size = new System.Drawing.Size(63, 17);
            this.No_Seat.TabIndex = 26;
            this.No_Seat.Text = "No_Seat";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(781, 110);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(169, 22);
            this.txtPrice.TabIndex = 25;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(701, 113);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(40, 17);
            this.Price.TabIndex = 24;
            this.Price.Text = "Price";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(701, 68);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 17);
            this.Type.TabIndex = 22;
            this.Type.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(701, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Direction";
            // 
            // dataGridFlight
            // 
            this.dataGridFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFlight.Location = new System.Drawing.Point(27, 295);
            this.dataGridFlight.Name = "dataGridFlight";
            this.dataGridFlight.RowHeadersWidth = 51;
            this.dataGridFlight.RowTemplate.Height = 24;
            this.dataGridFlight.Size = new System.Drawing.Size(1003, 374);
            this.dataGridFlight.TabIndex = 19;
            this.dataGridFlight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFlight_CellClick);
            // 
            // btnFRemove
            // 
            this.btnFRemove.Location = new System.Drawing.Point(172, 241);
            this.btnFRemove.Name = "btnFRemove";
            this.btnFRemove.Size = new System.Drawing.Size(90, 37);
            this.btnFRemove.TabIndex = 18;
            this.btnFRemove.Text = "Remove";
            this.btnFRemove.UseVisualStyleBackColor = true;
            this.btnFRemove.Click += new System.EventHandler(this.btnFRemove_Click);
            // 
            // btnFAdd
            // 
            this.btnFAdd.Location = new System.Drawing.Point(61, 241);
            this.btnFAdd.Name = "btnFAdd";
            this.btnFAdd.Size = new System.Drawing.Size(90, 37);
            this.btnFAdd.TabIndex = 16;
            this.btnFAdd.Text = "Add";
            this.btnFAdd.UseVisualStyleBackColor = true;
            this.btnFAdd.Click += new System.EventHandler(this.btnFAdd_Click);
            // 
            // comboAirplane
            // 
            this.comboAirplane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAirplane.FormattingEnabled = true;
            this.comboAirplane.Location = new System.Drawing.Point(486, 106);
            this.comboAirplane.Name = "comboAirplane";
            this.comboAirplane.Size = new System.Drawing.Size(169, 24);
            this.comboAirplane.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Airplane";
            // 
            // comboACountry
            // 
            this.comboACountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboACountry.FormattingEnabled = true;
            this.comboACountry.Location = new System.Drawing.Point(486, 61);
            this.comboACountry.Name = "comboACountry";
            this.comboACountry.Size = new System.Drawing.Size(169, 24);
            this.comboACountry.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Arrival_place";
            // 
            // comboDCountry
            // 
            this.comboDCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDCountry.FormattingEnabled = true;
            this.comboDCountry.Location = new System.Drawing.Point(486, 20);
            this.comboDCountry.Name = "comboDCountry";
            this.comboDCountry.Size = new System.Drawing.Size(169, 24);
            this.comboDCountry.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Depart_place";
            // 
            // txt_arr_date
            // 
            this.txt_arr_date.Location = new System.Drawing.Point(486, 150);
            this.txt_arr_date.Name = "txt_arr_date";
            this.txt_arr_date.Size = new System.Drawing.Size(169, 22);
            this.txt_arr_date.TabIndex = 9;
            // 
            // txt_dep_date
            // 
            this.txt_dep_date.Location = new System.Drawing.Point(172, 150);
            this.txt_dep_date.Name = "txt_dep_date";
            this.txt_dep_date.Size = new System.Drawing.Size(169, 22);
            this.txt_dep_date.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Arrival_date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Depart_date";
            // 
            // txt_arr_time
            // 
            this.txt_arr_time.Location = new System.Drawing.Point(172, 108);
            this.txt_arr_time.Name = "txt_arr_time";
            this.txt_arr_time.Size = new System.Drawing.Size(169, 22);
            this.txt_arr_time.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Arrival_time";
            // 
            // txt_dep_time
            // 
            this.txt_dep_time.Location = new System.Drawing.Point(172, 68);
            this.txt_dep_time.Name = "txt_dep_time";
            this.txt_dep_time.Size = new System.Drawing.Size(169, 22);
            this.txt_dep_time.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depart_time";
            // 
            // txtFlightId
            // 
            this.txtFlightId.Location = new System.Drawing.Point(172, 24);
            this.txtFlightId.Name = "txtFlightId";
            this.txtFlightId.Size = new System.Drawing.Size(169, 22);
            this.txtFlightId.TabIndex = 1;
            // 
            // FlightId
            // 
            this.FlightId.AutoSize = true;
            this.FlightId.Location = new System.Drawing.Point(58, 27);
            this.FlightId.Name = "FlightId";
            this.FlightId.Size = new System.Drawing.Size(21, 17);
            this.FlightId.TabIndex = 0;
            this.FlightId.Text = "ID";
            // 
            // FeedBack
            // 
            this.FeedBack.Controls.Add(this.btnFilterFeedBack);
            this.FeedBack.Controls.Add(this.txtFilterFeedback);
            this.FeedBack.Controls.Add(this.label18);
            this.FeedBack.Controls.Add(this.dataGridInbox);
            this.FeedBack.Controls.Add(this.btnRemoveMess);
            this.FeedBack.Controls.Add(this.txt_id_mess);
            this.FeedBack.Controls.Add(this.label11);
            this.FeedBack.Location = new System.Drawing.Point(4, 25);
            this.FeedBack.Name = "FeedBack";
            this.FeedBack.Size = new System.Drawing.Size(1061, 693);
            this.FeedBack.TabIndex = 2;
            this.FeedBack.Text = "Feed back";
            this.FeedBack.UseVisualStyleBackColor = true;
            // 
            // dataGridInbox
            // 
            this.dataGridInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInbox.Location = new System.Drawing.Point(50, 84);
            this.dataGridInbox.Name = "dataGridInbox";
            this.dataGridInbox.RowHeadersWidth = 51;
            this.dataGridInbox.RowTemplate.Height = 24;
            this.dataGridInbox.Size = new System.Drawing.Size(952, 577);
            this.dataGridInbox.TabIndex = 5;
            this.dataGridInbox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInbox_CellClick);
            // 
            // btnRemoveMess
            // 
            this.btnRemoveMess.Location = new System.Drawing.Point(193, 27);
            this.btnRemoveMess.Name = "btnRemoveMess";
            this.btnRemoveMess.Size = new System.Drawing.Size(85, 30);
            this.btnRemoveMess.TabIndex = 4;
            this.btnRemoveMess.Text = "Remove";
            this.btnRemoveMess.UseVisualStyleBackColor = true;
            this.btnRemoveMess.Click += new System.EventHandler(this.btnRemoveMess_Click);
            // 
            // txt_id_mess
            // 
            this.txt_id_mess.Location = new System.Drawing.Point(74, 27);
            this.txt_id_mess.Multiline = true;
            this.txt_id_mess.Name = "txt_id_mess";
            this.txt_id_mess.Size = new System.Drawing.Size(113, 30);
            this.txt_id_mess.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID";
            // 
            // View_Booking
            // 
            this.View_Booking.Controls.Add(this.btnFilterBooking);
            this.View_Booking.Controls.Add(this.txtFilterBooking);
            this.View_Booking.Controls.Add(this.label19);
            this.View_Booking.Controls.Add(this.btnAsyn);
            this.View_Booking.Controls.Add(this.dataGridBooking);
            this.View_Booking.Location = new System.Drawing.Point(4, 25);
            this.View_Booking.Name = "View_Booking";
            this.View_Booking.Size = new System.Drawing.Size(1061, 693);
            this.View_Booking.TabIndex = 3;
            this.View_Booking.Text = "View_Booking";
            this.View_Booking.UseVisualStyleBackColor = true;
            // 
            // btnAsyn
            // 
            this.btnAsyn.Location = new System.Drawing.Point(52, 22);
            this.btnAsyn.Name = "btnAsyn";
            this.btnAsyn.Size = new System.Drawing.Size(94, 30);
            this.btnAsyn.TabIndex = 1;
            this.btnAsyn.Text = "Asyn";
            this.btnAsyn.UseVisualStyleBackColor = true;
            this.btnAsyn.Click += new System.EventHandler(this.btnAsyn_Click);
            // 
            // dataGridBooking
            // 
            this.dataGridBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooking.Location = new System.Drawing.Point(52, 79);
            this.dataGridBooking.Name = "dataGridBooking";
            this.dataGridBooking.RowHeadersWidth = 51;
            this.dataGridBooking.RowTemplate.Height = 24;
            this.dataGridBooking.Size = new System.Drawing.Size(957, 587);
            this.dataGridBooking.TabIndex = 0;
            // 
            // tabStatisticTicket
            // 
            this.tabStatisticTicket.Controls.Add(this.label17);
            this.tabStatisticTicket.Controls.Add(this.txtEarnMoney);
            this.tabStatisticTicket.Controls.Add(this.dataGridStatistic);
            this.tabStatisticTicket.Controls.Add(this.comboStatistic);
            this.tabStatisticTicket.Controls.Add(this.btnAsynStatistic);
            this.tabStatisticTicket.Controls.Add(this.txtTotal);
            this.tabStatisticTicket.Controls.Add(this.label15);
            this.tabStatisticTicket.Controls.Add(this.txtBooked);
            this.tabStatisticTicket.Controls.Add(this.label14);
            this.tabStatisticTicket.Controls.Add(this.txtFree);
            this.tabStatisticTicket.Controls.Add(this.label13);
            this.tabStatisticTicket.Location = new System.Drawing.Point(4, 25);
            this.tabStatisticTicket.Name = "tabStatisticTicket";
            this.tabStatisticTicket.Size = new System.Drawing.Size(1061, 693);
            this.tabStatisticTicket.TabIndex = 4;
            this.tabStatisticTicket.Text = "Statistic_Ticket";
            this.tabStatisticTicket.UseVisualStyleBackColor = true;
            // 
            // dataGridStatistic
            // 
            this.dataGridStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistic.Location = new System.Drawing.Point(30, 138);
            this.dataGridStatistic.Name = "dataGridStatistic";
            this.dataGridStatistic.RowHeadersWidth = 51;
            this.dataGridStatistic.RowTemplate.Height = 24;
            this.dataGridStatistic.Size = new System.Drawing.Size(1002, 530);
            this.dataGridStatistic.TabIndex = 11;
            // 
            // comboStatistic
            // 
            this.comboStatistic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatistic.FormattingEnabled = true;
            this.comboStatistic.Items.AddRange(new object[] {
            "All",
            "Booked-Ticket",
            "Free-Ticket"});
            this.comboStatistic.Location = new System.Drawing.Point(30, 29);
            this.comboStatistic.Name = "comboStatistic";
            this.comboStatistic.Size = new System.Drawing.Size(140, 24);
            this.comboStatistic.TabIndex = 10;
            this.comboStatistic.SelectedValueChanged += new System.EventHandler(this.comboStatistic_SelectedValueChanged);
            // 
            // btnAsynStatistic
            // 
            this.btnAsynStatistic.Location = new System.Drawing.Point(30, 70);
            this.btnAsynStatistic.Name = "btnAsynStatistic";
            this.btnAsynStatistic.Size = new System.Drawing.Size(94, 39);
            this.btnAsynStatistic.TabIndex = 9;
            this.btnAsynStatistic.Text = "Asyn";
            this.btnAsynStatistic.UseVisualStyleBackColor = true;
            this.btnAsynStatistic.Click += new System.EventHandler(this.btnAsynStatistic_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(702, 24);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(613, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Total-Ticket";
            // 
            // txtBooked
            // 
            this.txtBooked.Location = new System.Drawing.Point(439, 76);
            this.txtBooked.Name = "txtBooked";
            this.txtBooked.ReadOnly = true;
            this.txtBooked.Size = new System.Drawing.Size(100, 22);
            this.txtBooked.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Booked-Ticket";
            // 
            // txtFree
            // 
            this.txtFree.Location = new System.Drawing.Point(439, 24);
            this.txtFree.Name = "txtFree";
            this.txtFree.ReadOnly = true;
            this.txtFree.Size = new System.Drawing.Size(100, 22);
            this.txtFree.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Free-Ticket";
            // 
            // txtEarnMoney
            // 
            this.txtEarnMoney.Location = new System.Drawing.Point(702, 79);
            this.txtEarnMoney.Name = "txtEarnMoney";
            this.txtEarnMoney.ReadOnly = true;
            this.txtEarnMoney.Size = new System.Drawing.Size(100, 22);
            this.txtEarnMoney.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(612, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "Earn Money";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(308, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Filter User";
            // 
            // txtFilterFeedback
            // 
            this.txtFilterFeedback.Location = new System.Drawing.Point(387, 27);
            this.txtFilterFeedback.Multiline = true;
            this.txtFilterFeedback.Name = "txtFilterFeedback";
            this.txtFilterFeedback.Size = new System.Drawing.Size(113, 30);
            this.txtFilterFeedback.TabIndex = 7;
            // 
            // btnFilterFeedBack
            // 
            this.btnFilterFeedBack.Location = new System.Drawing.Point(506, 27);
            this.btnFilterFeedBack.Name = "btnFilterFeedBack";
            this.btnFilterFeedBack.Size = new System.Drawing.Size(85, 30);
            this.btnFilterFeedBack.TabIndex = 8;
            this.btnFilterFeedBack.Text = "Filter";
            this.btnFilterFeedBack.UseVisualStyleBackColor = true;
            this.btnFilterFeedBack.Click += new System.EventHandler(this.btnFilterFeedBack_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(212, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 17);
            this.label19.TabIndex = 7;
            this.label19.Text = "Filter User";
            // 
            // txtFilterBooking
            // 
            this.txtFilterBooking.Location = new System.Drawing.Point(291, 22);
            this.txtFilterBooking.Multiline = true;
            this.txtFilterBooking.Name = "txtFilterBooking";
            this.txtFilterBooking.Size = new System.Drawing.Size(113, 30);
            this.txtFilterBooking.TabIndex = 8;
            // 
            // btnFilterBooking
            // 
            this.btnFilterBooking.Location = new System.Drawing.Point(410, 22);
            this.btnFilterBooking.Name = "btnFilterBooking";
            this.btnFilterBooking.Size = new System.Drawing.Size(85, 30);
            this.btnFilterBooking.TabIndex = 9;
            this.btnFilterBooking.Text = "Filter";
            this.btnFilterBooking.UseVisualStyleBackColor = true;
            this.btnFilterBooking.Click += new System.EventHandler(this.btnFilterBooking_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 764);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAirplane.ResumeLayout(false);
            this.tabPageAirplane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirplane)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFlight)).EndInit();
            this.FeedBack.ResumeLayout(false);
            this.FeedBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInbox)).EndInit();
            this.View_Booking.ResumeLayout(false);
            this.View_Booking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooking)).EndInit();
            this.tabStatisticTicket.ResumeLayout(false);
            this.tabStatisticTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAirplane;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridAirplane;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNameAirplane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdAirplane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFAdd;
        private System.Windows.Forms.ComboBox comboAirplane;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboACountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboDCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_arr_date;
        private System.Windows.Forms.TextBox txt_dep_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_arr_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dep_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFlightId;
        private System.Windows.Forms.Label FlightId;
        private System.Windows.Forms.DataGridView dataGridFlight;
        private System.Windows.Forms.Button btnFRemove;
        private System.Windows.Forms.TextBox txtNoSeat;
        private System.Windows.Forms.Label No_Seat;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboDirection;
        private System.Windows.Forms.TabPage FeedBack;
        private System.Windows.Forms.DataGridView dataGridInbox;
        private System.Windows.Forms.Button btnRemoveMess;
        private System.Windows.Forms.TextBox txt_id_mess;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage View_Booking;
        private System.Windows.Forms.Button btnAsyn;
        private System.Windows.Forms.DataGridView dataGridBooking;
        private System.Windows.Forms.TextBox txtNameFlight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClearAirplane;
        private System.Windows.Forms.Button btnClearFlight;
        private System.Windows.Forms.TabPage tabStatisticTicket;
        private System.Windows.Forms.DataGridView dataGridStatistic;
        private System.Windows.Forms.ComboBox comboStatistic;
        private System.Windows.Forms.Button btnAsynStatistic;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBooked;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFree;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_airway_station;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEarnMoney;
        private System.Windows.Forms.Button btnFilterFeedBack;
        private System.Windows.Forms.TextBox txtFilterFeedback;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnFilterBooking;
        private System.Windows.Forms.TextBox txtFilterBooking;
        private System.Windows.Forms.Label label19;
    }
}

