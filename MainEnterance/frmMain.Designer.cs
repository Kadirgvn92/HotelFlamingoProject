namespace MainEnterance
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_twitter = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_facebook = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_youtube = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_instagram = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_reservation = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_room = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_client = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_staff = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.progbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.roomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomfreeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoteldbDataSet6 = new MainEnterance.HoteldbDataSet6();
            this.roomTableAdapter = new MainEnterance.HoteldbDataSet6TableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(298, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hotel Flamingo Management ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(831, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reservation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(879, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Staff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(90, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rooms";
            // 
            // btn_twitter
            // 
            this.btn_twitter.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_twitter.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_twitter.Image = ((System.Drawing.Image)(resources.GetObject("btn_twitter.Image")));
            this.btn_twitter.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_twitter.ImageRotate = 0F;
            this.btn_twitter.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_twitter.Location = new System.Drawing.Point(579, 687);
            this.btn_twitter.Name = "btn_twitter";
            this.btn_twitter.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_twitter.Size = new System.Drawing.Size(71, 65);
            this.btn_twitter.TabIndex = 5;
            this.btn_twitter.Click += new System.EventHandler(this.btn_twitter_Click);
            // 
            // btn_facebook
            // 
            this.btn_facebook.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_facebook.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_facebook.Image = ((System.Drawing.Image)(resources.GetObject("btn_facebook.Image")));
            this.btn_facebook.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_facebook.ImageRotate = 0F;
            this.btn_facebook.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_facebook.Location = new System.Drawing.Point(493, 685);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_facebook.Size = new System.Drawing.Size(80, 67);
            this.btn_facebook.TabIndex = 5;
            this.btn_facebook.Click += new System.EventHandler(this.btn_facebook_Click);
            // 
            // btn_youtube
            // 
            this.btn_youtube.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_youtube.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_youtube.Image = ((System.Drawing.Image)(resources.GetObject("btn_youtube.Image")));
            this.btn_youtube.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_youtube.ImageRotate = 0F;
            this.btn_youtube.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_youtube.Location = new System.Drawing.Point(417, 685);
            this.btn_youtube.Name = "btn_youtube";
            this.btn_youtube.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_youtube.Size = new System.Drawing.Size(70, 67);
            this.btn_youtube.TabIndex = 5;
            this.btn_youtube.Click += new System.EventHandler(this.btn_youtube_Click);
            // 
            // btn_instagram
            // 
            this.btn_instagram.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_instagram.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_instagram.Image = ((System.Drawing.Image)(resources.GetObject("btn_instagram.Image")));
            this.btn_instagram.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_instagram.ImageRotate = 0F;
            this.btn_instagram.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_instagram.Location = new System.Drawing.Point(345, 685);
            this.btn_instagram.Name = "btn_instagram";
            this.btn_instagram.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_instagram.Size = new System.Drawing.Size(66, 67);
            this.btn_instagram.TabIndex = 5;
            this.btn_instagram.Click += new System.EventHandler(this.btn_instagram_Click);
            // 
            // btn_reservation
            // 
            this.btn_reservation.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_reservation.HoverState.ImageSize = new System.Drawing.Size(120, 120);
            this.btn_reservation.Image = global::MainEnterance.Properties.Resources.booking__1_;
            this.btn_reservation.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_reservation.ImageRotate = 0F;
            this.btn_reservation.ImageSize = new System.Drawing.Size(150, 150);
            this.btn_reservation.Location = new System.Drawing.Point(814, 456);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.PressedState.ImageSize = new System.Drawing.Size(120, 120);
            this.btn_reservation.Size = new System.Drawing.Size(160, 160);
            this.btn_reservation.TabIndex = 2;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_exit.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.Image = global::MainEnterance.Properties.Resources.shutdown_44369541;
            this.btn_exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_exit.ImageRotate = 0F;
            this.btn_exit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.Location = new System.Drawing.Point(968, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.Size = new System.Drawing.Size(38, 39);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_room
            // 
            this.btn_room.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_room.HoverState.ImageSize = new System.Drawing.Size(120, 120);
            this.btn_room.Image = global::MainEnterance.Properties.Resources.bed1;
            this.btn_room.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_room.ImageRotate = 0F;
            this.btn_room.ImageSize = new System.Drawing.Size(150, 150);
            this.btn_room.IndicateFocus = true;
            this.btn_room.Location = new System.Drawing.Point(53, 456);
            this.btn_room.Name = "btn_room";
            this.btn_room.PressedState.ImageSize = new System.Drawing.Size(120, 120);
            this.btn_room.Size = new System.Drawing.Size(160, 160);
            this.btn_room.TabIndex = 2;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_client
            // 
            this.btn_client.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_client.HoverState.ImageSize = new System.Drawing.Size(120, 120);
            this.btn_client.Image = global::MainEnterance.Properties.Resources.parenting2;
            this.btn_client.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_client.ImageRotate = 0F;
            this.btn_client.ImageSize = new System.Drawing.Size(150, 150);
            this.btn_client.Location = new System.Drawing.Point(53, 165);
            this.btn_client.Name = "btn_client";
            this.btn_client.PressedState.ImageSize = new System.Drawing.Size(120, 120);
            this.btn_client.Size = new System.Drawing.Size(160, 160);
            this.btn_client.TabIndex = 2;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_staff.HoverState.ImageSize = new System.Drawing.Size(120, 120);
            this.btn_staff.Image = global::MainEnterance.Properties.Resources.concierge1;
            this.btn_staff.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_staff.ImageRotate = 0F;
            this.btn_staff.ImageSize = new System.Drawing.Size(150, 150);
            this.btn_staff.Location = new System.Drawing.Point(814, 165);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.PressedState.ImageSize = new System.Drawing.Size(120, 120);
            this.btn_staff.Size = new System.Drawing.Size(160, 160);
            this.btn_staff.TabIndex = 2;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(475, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "     ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // progbar
            // 
            this.progbar.BorderRadius = 10;
            this.progbar.Location = new System.Drawing.Point(398, 637);
            this.progbar.Name = "progbar";
            this.progbar.Size = new System.Drawing.Size(211, 29);
            this.progbar.TabIndex = 9;
            this.progbar.Text = "guna2ProgressBar1";
            this.progbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(428, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Available Rooms";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 31;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnumberDataGridViewTextBoxColumn,
            this.roomtypeDataGridViewTextBoxColumn,
            this.roomfreeDataGridViewCheckBoxColumn});
            this.guna2DataGridView1.DataSource = this.roomBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(243, 165);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.RowTemplate.Height = 40;
            this.guna2DataGridView1.Size = new System.Drawing.Size(529, 402);
            this.guna2DataGridView1.TabIndex = 10;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 31;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.guna2DataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guna2DataGridView1_CellFormatting);
            // 
            // roomnumberDataGridViewTextBoxColumn
            // 
            this.roomnumberDataGridViewTextBoxColumn.DataPropertyName = "room_number";
            this.roomnumberDataGridViewTextBoxColumn.HeaderText = "Room Number";
            this.roomnumberDataGridViewTextBoxColumn.Name = "roomnumberDataGridViewTextBoxColumn";
            this.roomnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "room_type";
            this.roomtypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            this.roomtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomfreeDataGridViewCheckBoxColumn
            // 
            this.roomfreeDataGridViewCheckBoxColumn.DataPropertyName = "room_free";
            this.roomfreeDataGridViewCheckBoxColumn.HeaderText = "Available";
            this.roomfreeDataGridViewCheckBoxColumn.Name = "roomfreeDataGridViewCheckBoxColumn";
            this.roomfreeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hoteldbDataSet6;
            // 
            // hoteldbDataSet6
            // 
            this.hoteldbDataSet6.DataSetName = "HoteldbDataSet6";
            this.hoteldbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1018, 764);
            this.Controls.Add(this.progbar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_twitter);
            this.Controls.Add(this.btn_facebook);
            this.Controls.Add(this.btn_youtube);
            this.Controls.Add(this.btn_instagram);
            this.Controls.Add(this.btn_reservation);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_room);
            this.Controls.Add(this.btn_client);
            this.Controls.Add(this.btn_staff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ImageButton btn_staff;
        private Guna.UI2.WinForms.Guna2ImageButton btn_reservation;
        private Guna.UI2.WinForms.Guna2ImageButton btn_client;
        private Guna.UI2.WinForms.Guna2ImageButton btn_room;
        private Guna.UI2.WinForms.Guna2ImageButton btn_exit;
        private Guna.UI2.WinForms.Guna2ImageButton btn_instagram;
        private Guna.UI2.WinForms.Guna2ImageButton btn_youtube;
        private Guna.UI2.WinForms.Guna2ImageButton btn_facebook;
        private Guna.UI2.WinForms.Guna2ImageButton btn_twitter;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ProgressBar progbar;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private HoteldbDataSet6 hoteldbDataSet6;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HoteldbDataSet6TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn roomfreeDataGridViewCheckBoxColumn;
    }
}