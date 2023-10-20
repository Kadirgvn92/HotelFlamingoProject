namespace MainEnterance
{
    partial class frmRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRooms));
            this.label12 = new System.Windows.Forms.Label();
            this.dg_room = new Guna.UI2.WinForms.Guna2DataGridView();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoteldbDataSet5 = new MainEnterance.HoteldbDataSet5();
            this.roomTableAdapter = new MainEnterance.HoteldbDataSet5TableAdapters.RoomTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_room_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hoteldbDataSet6 = new MainEnterance.HoteldbDataSet6();
            this.roomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter1 = new MainEnterance.HoteldbDataSet6TableAdapters.RoomTableAdapter();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomfreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.txt_room_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_room_number = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton12 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(580, 799);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "11 Single";
            // 
            // dg_room
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dg_room.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_room.AutoGenerateColumns = false;
            this.dg_room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_room.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_room.ColumnHeadersHeight = 15;
            this.dg_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_room.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn,
            this.room_number,
            this.roomtypeDataGridViewTextBoxColumn,
            this.room_price,
            this.roomfreeDataGridViewTextBoxColumn});
            this.dg_room.DataSource = this.roomBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_room.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_room.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_room.Location = new System.Drawing.Point(293, 106);
            this.dg_room.Name = "dg_room";
            this.dg_room.RowHeadersVisible = false;
            this.dg_room.Size = new System.Drawing.Size(535, 427);
            this.dg_room.TabIndex = 4;
            this.dg_room.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_room.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg_room.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_room.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg_room.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg_room.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_room.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_room.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dg_room.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_room.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dg_room.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_room.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_room.ThemeStyle.HeaderStyle.Height = 15;
            this.dg_room.ThemeStyle.ReadOnly = false;
            this.dg_room.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_room.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_room.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dg_room.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_room.ThemeStyle.RowsStyle.Height = 22;
            this.dg_room.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_room.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_room.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_room_CellContentClick);
            this.dg_room.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_room_CellFormatting);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hoteldbDataSet5;
            // 
            // hoteldbDataSet5
            // 
            this.hoteldbDataSet5.DataSetName = "HoteldbDataSet5";
            this.hoteldbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(394, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rooms";
            // 
            // combo_room_type
            // 
            this.combo_room_type.BackColor = System.Drawing.Color.Transparent;
            this.combo_room_type.BorderColor = System.Drawing.Color.Black;
            this.combo_room_type.BorderRadius = 10;
            this.combo_room_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_room_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_room_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_room_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_room_type.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.combo_room_type.ForeColor = System.Drawing.Color.Black;
            this.combo_room_type.ItemHeight = 30;
            this.combo_room_type.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.combo_room_type.Location = new System.Drawing.Point(13, 169);
            this.combo_room_type.Name = "combo_room_type";
            this.combo_room_type.Size = new System.Drawing.Size(257, 36);
            this.combo_room_type.TabIndex = 7;
            this.combo_room_type.Tag = "";
            // 
            // hoteldbDataSet6
            // 
            this.hoteldbDataSet6.DataSetName = "HoteldbDataSet6";
            this.hoteldbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource1
            // 
            this.roomBindingSource1.DataMember = "Room";
            this.roomBindingSource1.DataSource = this.hoteldbDataSet6;
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "room_Id";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "Room Id";
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // room_number
            // 
            this.room_number.DataPropertyName = "room_number";
            this.room_number.HeaderText = "Room Number";
            this.room_number.Name = "room_number";
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "room_type";
            this.roomtypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            // 
            // room_price
            // 
            this.room_price.DataPropertyName = "room_price";
            this.room_price.HeaderText = "Room Price";
            this.room_price.Name = "room_price";
            // 
            // roomfreeDataGridViewTextBoxColumn
            // 
            this.roomfreeDataGridViewTextBoxColumn.DataPropertyName = "room_free";
            this.roomfreeDataGridViewTextBoxColumn.HeaderText = "Room is Free ?";
            this.roomfreeDataGridViewTextBoxColumn.Name = "roomfreeDataGridViewTextBoxColumn";
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
            this.btn_delete.Location = new System.Drawing.Point(12, 469);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(258, 64);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Room Delete";
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
            this.btn_edit.Location = new System.Drawing.Point(12, 399);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(257, 64);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Room Edit";
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
            this.btn_add.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_add.Location = new System.Drawing.Point(12, 329);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(257, 64);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Room Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_room_price
            // 
            this.txt_room_price.BorderColor = System.Drawing.Color.Black;
            this.txt_room_price.BorderRadius = 10;
            this.txt_room_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_room_price.DefaultText = "";
            this.txt_room_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_room_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_room_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_room_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_room_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_price.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_room_price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_room_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_price.IconLeft = global::MainEnterance.Properties.Resources.dollar_symbol;
            this.txt_room_price.Location = new System.Drawing.Point(13, 225);
            this.txt_room_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_room_price.Name = "txt_room_price";
            this.txt_room_price.PasswordChar = '\0';
            this.txt_room_price.PlaceholderText = "Room Price";
            this.txt_room_price.SelectedText = "";
            this.txt_room_price.Size = new System.Drawing.Size(257, 41);
            this.txt_room_price.TabIndex = 6;
            // 
            // txt_room_number
            // 
            this.txt_room_number.BorderColor = System.Drawing.Color.Black;
            this.txt_room_number.BorderRadius = 10;
            this.txt_room_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_room_number.DefaultText = "";
            this.txt_room_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_room_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_room_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_room_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_room_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_number.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_room_number.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_room_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_room_number.IconLeft = global::MainEnterance.Properties.Resources.double_bed;
            this.txt_room_number.Location = new System.Drawing.Point(13, 108);
            this.txt_room_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_room_number.Name = "txt_room_number";
            this.txt_room_number.PasswordChar = '\0';
            this.txt_room_number.PlaceholderText = "Room Number";
            this.txt_room_number.SelectedText = "";
            this.txt_room_number.Size = new System.Drawing.Size(257, 41);
            this.txt_room_number.TabIndex = 6;
            // 
            // guna2ImageButton12
            // 
            this.guna2ImageButton12.BackColor = System.Drawing.Color.LawnGreen;
            this.guna2ImageButton12.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton12.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton12.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton12.Image")));
            this.guna2ImageButton12.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton12.ImageRotate = 0F;
            this.guna2ImageButton12.Location = new System.Drawing.Point(489, 770);
            this.guna2ImageButton12.Name = "guna2ImageButton12";
            this.guna2ImageButton12.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton12.Size = new System.Drawing.Size(85, 68);
            this.guna2ImageButton12.TabIndex = 1;
            // 
            // frmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.combo_room_type);
            this.Controls.Add(this.txt_room_price);
            this.Controls.Add(this.txt_room_number);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_room);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.guna2ImageButton12);
            this.Name = "frmRooms";
            this.Text = "frmRooms";
            this.Load += new System.EventHandler(this.frmRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton12;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView dg_room;
        private HoteldbDataSet5 hoteldbDataSet5;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HoteldbDataSet5TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_room_number;
        private Guna.UI2.WinForms.Guna2ComboBox combo_room_type;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txt_room_price;
        private System.Windows.Forms.Timer timer1;
        private HoteldbDataSet6 hoteldbDataSet6;
        private System.Windows.Forms.BindingSource roomBindingSource1;
        private HoteldbDataSet6TableAdapters.RoomTableAdapter roomTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomfreeDataGridViewTextBoxColumn;
    }
}