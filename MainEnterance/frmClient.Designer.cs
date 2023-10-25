namespace MainEnterance
{
    partial class frmClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.txt_country = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_client = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hoteldbDataSet4 = new MainEnterance.HoteldbDataSet4();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_dob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.clientTableAdapter2 = new MainEnterance.HoteldbDataSet4TableAdapters.ClientTableAdapter();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.txt_clientId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_clientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TabControl2 = new Guna.UI2.WinForms.Guna2TabControl();
            this.Reservation = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReserveInfo = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2TabControl2.SuspendLayout();
            this.Reservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ReserveInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_country
            // 
            this.txt_country.BackColor = System.Drawing.Color.Transparent;
            this.txt_country.BorderColor = System.Drawing.Color.Black;
            this.txt_country.BorderRadius = 10;
            this.txt_country.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_country.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_country.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_country.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.txt_country.ForeColor = System.Drawing.Color.Black;
            this.txt_country.ItemHeight = 30;
            this.txt_country.Items.AddRange(new object[] {
            "Turkey",
            "Canada",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.txt_country.Location = new System.Drawing.Point(369, 26);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(277, 36);
            this.txt_country.TabIndex = 5;
            this.txt_country.Tag = "";
            this.txt_country.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(521, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Information";
            // 
            // dtg_client
            // 
            this.dtg_client.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_client.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_client.AutoGenerateColumns = false;
            this.dtg_client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_client.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_client.ColumnHeadersHeight = 25;
            this.dtg_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.clientnameDataGridViewTextBoxColumn,
            this.clientphoneDataGridViewTextBoxColumn,
            this.clientemailDataGridViewTextBoxColumn,
            this.clientcountryDataGridViewTextBoxColumn,
            this.client_address,
            this.client_dob});
            this.dtg_client.DataSource = this.clientBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_client.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_client.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_client.Location = new System.Drawing.Point(16, 59);
            this.dtg_client.Name = "dtg_client";
            this.dtg_client.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_client.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_client.RowHeadersVisible = false;
            this.dtg_client.RowHeadersWidth = 60;
            this.dtg_client.RowTemplate.Height = 40;
            this.dtg_client.Size = new System.Drawing.Size(1266, 372);
            this.dtg_client.TabIndex = 4;
            this.dtg_client.TabStop = false;
            this.dtg_client.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_client.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtg_client.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtg_client.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_client.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_client.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtg_client.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_client.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_client.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_client.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtg_client.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_client.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtg_client.ThemeStyle.HeaderStyle.Height = 25;
            this.dtg_client.ThemeStyle.ReadOnly = false;
            this.dtg_client.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_client.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_client.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtg_client.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_client.ThemeStyle.RowsStyle.Height = 40;
            this.dtg_client.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_client.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_client_CellContentClick);
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "client_Id";
            this.clientIdDataGridViewTextBoxColumn.FillWeight = 305.0009F;
            this.clientIdDataGridViewTextBoxColumn.Frozen = true;
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.clientIdDataGridViewTextBoxColumn.MaxInputLength = 99999999;
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // clientnameDataGridViewTextBoxColumn
            // 
            this.clientnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clientnameDataGridViewTextBoxColumn.DataPropertyName = "client_name";
            this.clientnameDataGridViewTextBoxColumn.Frozen = true;
            this.clientnameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.clientnameDataGridViewTextBoxColumn.Name = "clientnameDataGridViewTextBoxColumn";
            // 
            // clientphoneDataGridViewTextBoxColumn
            // 
            this.clientphoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clientphoneDataGridViewTextBoxColumn.DataPropertyName = "client_phone";
            this.clientphoneDataGridViewTextBoxColumn.FillWeight = 36F;
            this.clientphoneDataGridViewTextBoxColumn.Frozen = true;
            this.clientphoneDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.clientphoneDataGridViewTextBoxColumn.Name = "clientphoneDataGridViewTextBoxColumn";
            this.clientphoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientemailDataGridViewTextBoxColumn
            // 
            this.clientemailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clientemailDataGridViewTextBoxColumn.DataPropertyName = "client_email";
            this.clientemailDataGridViewTextBoxColumn.FillWeight = 36.64584F;
            this.clientemailDataGridViewTextBoxColumn.Frozen = true;
            this.clientemailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.clientemailDataGridViewTextBoxColumn.Name = "clientemailDataGridViewTextBoxColumn";
            this.clientemailDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientcountryDataGridViewTextBoxColumn
            // 
            this.clientcountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clientcountryDataGridViewTextBoxColumn.DataPropertyName = "client_country";
            this.clientcountryDataGridViewTextBoxColumn.FillWeight = 48.40702F;
            this.clientcountryDataGridViewTextBoxColumn.Frozen = true;
            this.clientcountryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.clientcountryDataGridViewTextBoxColumn.Name = "clientcountryDataGridViewTextBoxColumn";
            this.clientcountryDataGridViewTextBoxColumn.Width = 120;
            // 
            // client_address
            // 
            this.client_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.client_address.DataPropertyName = "client_address";
            this.client_address.FillWeight = 36.64584F;
            this.client_address.Frozen = true;
            this.client_address.HeaderText = "Address";
            this.client_address.Name = "client_address";
            this.client_address.Width = 350;
            // 
            // client_dob
            // 
            this.client_dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.client_dob.DataPropertyName = "client_dob";
            this.client_dob.FillWeight = 36.64584F;
            this.client_dob.HeaderText = "Date of Birth";
            this.client_dob.Name = "client_dob";
            this.client_dob.Width = 150;
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataMember = "Client";
            this.clientBindingSource2.DataSource = this.hoteldbDataSet4;
            // 
            // hoteldbDataSet4
            // 
            this.hoteldbDataSet4.DataSetName = "HoteldbDataSet4";
            this.hoteldbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_search
            // 
            this.txt_search.BorderColor = System.Drawing.Color.Black;
            this.txt_search.BorderRadius = 10;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(364, 15);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search Customer Full Name";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(287, 37);
            this.txt_search.TabIndex = 2;
            this.txt_search.TabStop = false;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(462, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date of Birth";
            // 
            // date_dob
            // 
            this.date_dob.Checked = true;
            this.date_dob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_dob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_dob.Location = new System.Drawing.Point(369, 333);
            this.date_dob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_dob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(277, 36);
            this.date_dob.TabIndex = 6;
            this.date_dob.Value = new System.DateTime(2023, 10, 7, 13, 47, 55, 341);
            // 
            // clientTableAdapter2
            // 
            this.clientTableAdapter2.ClearBeforeFill = true;
            // 
            // btn_delete
            // 
            this.btn_delete.BorderRadius = 10;
            this.btn_delete.BorderThickness = 1;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.ForeColor = System.Drawing.Color.Navy;
            this.btn_delete.Image = global::MainEnterance.Properties.Resources.trash__1_;
            this.btn_delete.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_delete.Location = new System.Drawing.Point(679, 281);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(254, 88);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Customer Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BorderRadius = 10;
            this.btn_edit.BorderThickness = 1;
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_edit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_edit.Image = global::MainEnterance.Properties.Resources.pencil;
            this.btn_edit.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_edit.Location = new System.Drawing.Point(679, 154);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(254, 88);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Customer Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BorderRadius = 10;
            this.btn_add.BorderThickness = 1;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_add.Image = global::MainEnterance.Properties.Resources.add__1_;
            this.btn_add.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_add.Location = new System.Drawing.Point(679, 26);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(254, 88);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Customer Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_clientId
            // 
            this.txt_clientId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_clientId.BorderColor = System.Drawing.Color.Black;
            this.txt_clientId.BorderRadius = 10;
            this.txt_clientId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_clientId.DefaultText = "";
            this.txt_clientId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_clientId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_clientId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_clientId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_clientId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_clientId.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_clientId.ForeColor = System.Drawing.Color.Black;
            this.txt_clientId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_clientId.IconLeft = global::MainEnterance.Properties.Resources.card;
            this.txt_clientId.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_clientId.Location = new System.Drawing.Point(57, 26);
            this.txt_clientId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_clientId.MaxLength = 11;
            this.txt_clientId.Name = "txt_clientId";
            this.txt_clientId.PasswordChar = '\0';
            this.txt_clientId.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_clientId.PlaceholderText = "Customer Id";
            this.txt_clientId.SelectedText = "";
            this.txt_clientId.Size = new System.Drawing.Size(277, 57);
            this.txt_clientId.TabIndex = 1;
            this.txt_clientId.TextChanged += new System.EventHandler(this.txt_clientId_TextChanged);
            this.txt_clientId.Click += new System.EventHandler(this.txt_clientId_Click);
            // 
            // txt_address
            // 
            this.txt_address.BorderColor = System.Drawing.Color.Black;
            this.txt_address.BorderRadius = 10;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic);
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.IconLeft = global::MainEnterance.Properties.Resources.location_pin;
            this.txt_address.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_address.Location = new System.Drawing.Point(369, 122);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_address.PlaceholderText = "Client Address";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(277, 152);
            this.txt_address.TabIndex = 6;
            this.txt_address.Click += new System.EventHandler(this.txt_clientName_Click);
            // 
            // txt_clientName
            // 
            this.txt_clientName.BorderColor = System.Drawing.Color.Black;
            this.txt_clientName.BorderRadius = 10;
            this.txt_clientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_clientName.DefaultText = "";
            this.txt_clientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_clientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_clientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_clientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_clientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_clientName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic);
            this.txt_clientName.ForeColor = System.Drawing.Color.Black;
            this.txt_clientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_clientName.IconLeft = global::MainEnterance.Properties.Resources.id_card;
            this.txt_clientName.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_clientName.Location = new System.Drawing.Point(57, 124);
            this.txt_clientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_clientName.Name = "txt_clientName";
            this.txt_clientName.PasswordChar = '\0';
            this.txt_clientName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_clientName.PlaceholderText = "Customer Name";
            this.txt_clientName.SelectedText = "";
            this.txt_clientName.Size = new System.Drawing.Size(277, 57);
            this.txt_clientName.TabIndex = 2;
            this.txt_clientName.Click += new System.EventHandler(this.txt_clientName_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.BorderColor = System.Drawing.Color.Black;
            this.txt_phone.BorderRadius = 10;
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.DefaultText = "";
            this.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.IconLeft = global::MainEnterance.Properties.Resources.telephone;
            this.txt_phone.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_phone.Location = new System.Drawing.Point(57, 217);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_phone.PlaceholderText = "Phone Number";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(277, 57);
            this.txt_phone.TabIndex = 3;
            this.txt_phone.Click += new System.EventHandler(this.txt_phone_Click);
            // 
            // txt_email
            // 
            this.txt_email.BorderColor = System.Drawing.Color.Black;
            this.txt_email.BorderRadius = 10;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.IconLeft = global::MainEnterance.Properties.Resources.gmail;
            this.txt_email.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_email.Location = new System.Drawing.Point(57, 312);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_email.PlaceholderText = "E-Mail Address";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(277, 57);
            this.txt_email.TabIndex = 4;
            this.txt_email.Click += new System.EventHandler(this.txt_email_Click);
            // 
            // btn_search
            // 
            this.btn_search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_search.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_search.ImageRotate = 0F;
            this.btn_search.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_search.Location = new System.Drawing.Point(658, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_search.Size = new System.Drawing.Size(60, 52);
            this.btn_search.TabIndex = 5;
            this.btn_search.TabStop = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 85);
            this.panel1.TabIndex = 9;
            // 
            // btn_exit
            // 
            this.btn_exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_exit.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.Image = global::MainEnterance.Properties.Resources.shutdown_44369541;
            this.btn_exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_exit.ImageRotate = 0F;
            this.btn_exit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.Location = new System.Drawing.Point(1245, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.Size = new System.Drawing.Size(38, 39);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // guna2TabControl2
            // 
            this.guna2TabControl2.Controls.Add(this.Reservation);
            this.guna2TabControl2.Controls.Add(this.ReserveInfo);
            this.guna2TabControl2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2TabControl2.ItemSize = new System.Drawing.Size(180, 60);
            this.guna2TabControl2.Location = new System.Drawing.Point(4, 91);
            this.guna2TabControl2.Name = "guna2TabControl2";
            this.guna2TabControl2.SelectedIndex = 0;
            this.guna2TabControl2.Size = new System.Drawing.Size(1290, 505);
            this.guna2TabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl2.TabButtonHoverState.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2TabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2TabControl2.TabButtonIdleState.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2TabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.guna2TabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.Bisque;
            this.guna2TabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.Bisque;
            this.guna2TabControl2.TabButtonSelectedState.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2TabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.Navy;
            this.guna2TabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.RoyalBlue;
            this.guna2TabControl2.TabButtonSize = new System.Drawing.Size(180, 60);
            this.guna2TabControl2.TabIndex = 10;
            this.guna2TabControl2.TabMenuBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // Reservation
            // 
            this.Reservation.BackColor = System.Drawing.Color.Transparent;
            this.Reservation.Controls.Add(this.pictureBox1);
            this.Reservation.Controls.Add(this.btn_delete);
            this.Reservation.Controls.Add(this.txt_clientId);
            this.Reservation.Controls.Add(this.btn_edit);
            this.Reservation.Controls.Add(this.txt_email);
            this.Reservation.Controls.Add(this.btn_add);
            this.Reservation.Controls.Add(this.txt_phone);
            this.Reservation.Controls.Add(this.label2);
            this.Reservation.Controls.Add(this.txt_clientName);
            this.Reservation.Controls.Add(this.date_dob);
            this.Reservation.Controls.Add(this.txt_address);
            this.Reservation.Controls.Add(this.txt_country);
            this.Reservation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reservation.Location = new System.Drawing.Point(4, 64);
            this.Reservation.Name = "Reservation";
            this.Reservation.Padding = new System.Windows.Forms.Padding(3);
            this.Reservation.Size = new System.Drawing.Size(1282, 437);
            this.Reservation.TabIndex = 0;
            this.Reservation.Text = "Customer Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(954, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReserveInfo
            // 
            this.ReserveInfo.Controls.Add(this.txt_search);
            this.ReserveInfo.Controls.Add(this.dtg_client);
            this.ReserveInfo.Controls.Add(this.btn_search);
            this.ReserveInfo.Location = new System.Drawing.Point(4, 64);
            this.ReserveInfo.Name = "ReserveInfo";
            this.ReserveInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ReserveInfo.Size = new System.Drawing.Size(1282, 437);
            this.ReserveInfo.TabIndex = 1;
            this.ReserveInfo.Text = "Customer Table";
            this.ReserveInfo.UseVisualStyleBackColor = true;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1296, 605);
            this.Controls.Add(this.guna2TabControl2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRoom";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2TabControl2.ResumeLayout(false);
            this.Reservation.ResumeLayout(false);
            this.Reservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ReserveInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox txt_country;
        private Guna.UI2.WinForms.Guna2TextBox txt_clientId;
        private Guna.UI2.WinForms.Guna2TextBox txt_clientName;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dtg_client;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2ImageButton btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_dob;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private HoteldbDataSet4 hoteldbDataSet4;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private HoteldbDataSet4TableAdapters.ClientTableAdapter clientTableAdapter2;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl2;
        private System.Windows.Forms.TabPage Reservation;
        private System.Windows.Forms.TabPage ReserveInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_dob;
        private Guna.UI2.WinForms.Guna2ImageButton btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}