namespace MainEnterance
{
    partial class frm_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Staff));
            this.label1 = new System.Windows.Forms.Label();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoteldbDataSet = new MainEnterance.HoteldbDataSet();
            this.staffTableAdapter = new MainEnterance.HoteldbDataSetTableAdapters.staffTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_staff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffusernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hoteldbDataSet2 = new MainEnterance.HoteldbDataSet2();
            this.staffTableAdapter1 = new MainEnterance.HoteldbDataSet2TableAdapters.StaffTableAdapter();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_edit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_add = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(411, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Sign In";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.hoteldbDataSet;
            // 
            // hoteldbDataSet
            // 
            this.hoteldbDataSet.DataSetName = "HoteldbDataSet";
            this.hoteldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 8;
            // 
            // dt_staff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dt_staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_staff.AutoGenerateColumns = false;
            this.dt_staff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_staff.ColumnHeadersHeight = 15;
            this.dt_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dt_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.staffusernameDataGridViewTextBoxColumn,
            this.staffnameDataGridViewTextBoxColumn,
            this.staffphoneDataGridViewTextBoxColumn,
            this.staffemailDataGridViewTextBoxColumn});
            this.dt_staff.DataSource = this.staffBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_staff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt_staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dt_staff.Location = new System.Drawing.Point(306, 160);
            this.dt_staff.Name = "dt_staff";
            this.dt_staff.RowHeadersVisible = false;
            this.dt_staff.Size = new System.Drawing.Size(626, 369);
            this.dt_staff.TabIndex = 9;
            this.dt_staff.TabStop = false;
            this.dt_staff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dt_staff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dt_staff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dt_staff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dt_staff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dt_staff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dt_staff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dt_staff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dt_staff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dt_staff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_staff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dt_staff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dt_staff.ThemeStyle.HeaderStyle.Height = 15;
            this.dt_staff.ThemeStyle.ReadOnly = false;
            this.dt_staff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dt_staff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dt_staff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_staff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dt_staff.ThemeStyle.RowsStyle.Height = 22;
            this.dt_staff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dt_staff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dt_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_staff_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // staffusernameDataGridViewTextBoxColumn
            // 
            this.staffusernameDataGridViewTextBoxColumn.DataPropertyName = "staff_username";
            this.staffusernameDataGridViewTextBoxColumn.HeaderText = "staff_username";
            this.staffusernameDataGridViewTextBoxColumn.Name = "staffusernameDataGridViewTextBoxColumn";
            // 
            // staffnameDataGridViewTextBoxColumn
            // 
            this.staffnameDataGridViewTextBoxColumn.DataPropertyName = "staff_name";
            this.staffnameDataGridViewTextBoxColumn.HeaderText = "staff_name";
            this.staffnameDataGridViewTextBoxColumn.Name = "staffnameDataGridViewTextBoxColumn";
            // 
            // staffphoneDataGridViewTextBoxColumn
            // 
            this.staffphoneDataGridViewTextBoxColumn.DataPropertyName = "staff_phone";
            this.staffphoneDataGridViewTextBoxColumn.HeaderText = "staff_phone";
            this.staffphoneDataGridViewTextBoxColumn.Name = "staffphoneDataGridViewTextBoxColumn";
            // 
            // staffemailDataGridViewTextBoxColumn
            // 
            this.staffemailDataGridViewTextBoxColumn.DataPropertyName = "staff_email";
            this.staffemailDataGridViewTextBoxColumn.HeaderText = "staff_email";
            this.staffemailDataGridViewTextBoxColumn.Name = "staffemailDataGridViewTextBoxColumn";
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.hoteldbDataSet2;
            // 
            // hoteldbDataSet2
            // 
            this.hoteldbDataSet2.DataSetName = "HoteldbDataSet2";
            this.hoteldbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // txt_username
            // 
            this.txt_username.BorderColor = System.Drawing.Color.Black;
            this.txt_username.BorderRadius = 10;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(16, 213);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "User Name";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(262, 34);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.BorderColor = System.Drawing.Color.Black;
            this.txt_password.BorderRadius = 10;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(16, 257);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(262, 34);
            this.txt_password.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.BorderColor = System.Drawing.Color.Black;
            this.txt_name.BorderRadius = 10;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(16, 301);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "Full Name ";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(262, 34);
            this.txt_name.TabIndex = 4;
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
            this.txt_phone.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Location = new System.Drawing.Point(16, 345);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderText = "Phone Number";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(262, 34);
            this.txt_phone.TabIndex = 5;
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
            this.txt_email.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(16, 389);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "E-Mail";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(262, 34);
            this.txt_email.TabIndex = 6;
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
            this.txt_search.Location = new System.Drawing.Point(473, 118);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search with Name";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(316, 34);
            this.txt_search.TabIndex = 10;
            this.txt_search.TabStop = false;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // txt_id
            // 
            this.txt_id.BorderColor = System.Drawing.Color.Black;
            this.txt_id.BorderRadius = 10;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(16, 169);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "Id";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(262, 34);
            this.txt_id.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 100);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainEnterance.Properties.Resources.card2;
            this.pictureBox1.Location = new System.Drawing.Point(292, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_delete.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_delete.ImageRotate = 0F;
            this.btn_delete.Location = new System.Drawing.Point(194, 442);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_delete.Size = new System.Drawing.Size(80, 75);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_edit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_edit.ImageRotate = 0F;
            this.btn_edit.Location = new System.Drawing.Point(106, 442);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_edit.Size = new System.Drawing.Size(70, 75);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.TabStop = false;
            this.btn_edit.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btn_add
            // 
            this.btn_add.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_add.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_add.ImageRotate = 0F;
            this.btn_add.Location = new System.Drawing.Point(16, 442);
            this.btn_add.Name = "btn_add";
            this.btn_add.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_add.Size = new System.Drawing.Size(70, 75);
            this.btn_add.TabIndex = 7;
            this.btn_add.TabStop = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // frm_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dt_staff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Info";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HoteldbDataSet hoteldbDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private HoteldbDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private Guna.UI2.WinForms.Guna2ImageButton btn_add;
        private Guna.UI2.WinForms.Guna2ImageButton btn_delete;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dt_staff;
        private HoteldbDataSet2 hoteldbDataSet2;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private HoteldbDataSet2TableAdapters.StaffTableAdapter staffTableAdapter1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_edit;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffusernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}