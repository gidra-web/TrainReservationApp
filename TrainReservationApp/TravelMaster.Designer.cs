namespace TrainReservationApp
{
    partial class TravelMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closelabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_travelCoast = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeTravel = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cb_trainCode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_source = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_destination = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_travel = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_travel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.closelabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 153);
            this.panel1.TabIndex = 2;
            // 
            // closelabel
            // 
            this.closelabel.AutoSize = true;
            this.closelabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closelabel.ForeColor = System.Drawing.Color.Gray;
            this.closelabel.Location = new System.Drawing.Point(1112, 9);
            this.closelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(17, 16);
            this.closelabel.TabIndex = 14;
            this.closelabel.Text = "x";
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 17);
            this.panel3.TabIndex = 9;
            // 
            // tb_travelCoast
            // 
            this.tb_travelCoast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_travelCoast.DefaultText = "";
            this.tb_travelCoast.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_travelCoast.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_travelCoast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_travelCoast.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_travelCoast.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_travelCoast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_travelCoast.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_travelCoast.Location = new System.Drawing.Point(785, 294);
            this.tb_travelCoast.Name = "tb_travelCoast";
            this.tb_travelCoast.PasswordChar = '\0';
            this.tb_travelCoast.PlaceholderText = "";
            this.tb_travelCoast.SelectedText = "";
            this.tb_travelCoast.Size = new System.Drawing.Size(151, 36);
            this.tb_travelCoast.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RosyBrown;
            this.label7.Location = new System.Drawing.Point(236, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "Train Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(418, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Source";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(48, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(481, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 35);
            this.label5.TabIndex = 47;
            this.label5.Text = "Travel";
            // 
            // dateTimeTravel
            // 
            this.dateTimeTravel.AutoRoundedCorners = true;
            this.dateTimeTravel.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeTravel.BorderRadius = 17;
            this.dateTimeTravel.Checked = true;
            this.dateTimeTravel.FillColor = System.Drawing.Color.Tomato;
            this.dateTimeTravel.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F);
            this.dateTimeTravel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTravel.Location = new System.Drawing.Point(52, 293);
            this.dateTimeTravel.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimeTravel.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeTravel.Name = "dateTimeTravel";
            this.dateTimeTravel.Size = new System.Drawing.Size(161, 36);
            this.dateTimeTravel.TabIndex = 48;
            this.dateTimeTravel.Value = new System.DateTime(2023, 2, 16, 20, 40, 52, 662);
            // 
            // cb_trainCode
            // 
            this.cb_trainCode.BackColor = System.Drawing.Color.Transparent;
            this.cb_trainCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_trainCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trainCode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_trainCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_trainCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_trainCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_trainCode.ItemHeight = 30;
            this.cb_trainCode.Items.AddRange(new object[] {
            "Beograd",
            "Novi Sad",
            "Subotica",
            "Valjevo",
            "Pozega",
            "Uzice",
            "Priboj",
            "Kraljevo",
            "Nis"});
            this.cb_trainCode.Location = new System.Drawing.Point(240, 294);
            this.cb_trainCode.Name = "cb_trainCode";
            this.cb_trainCode.Size = new System.Drawing.Size(148, 36);
            this.cb_trainCode.TabIndex = 49;
            // 
            // cb_source
            // 
            this.cb_source.BackColor = System.Drawing.Color.Transparent;
            this.cb_source.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_source.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_source.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_source.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_source.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_source.ItemHeight = 30;
            this.cb_source.Items.AddRange(new object[] {
            "Beograd",
            "Novi Sad",
            "Subotica",
            "Valjevo",
            "Pozega",
            "Uzice",
            "Priboj",
            "Kraljevo",
            "Nis"});
            this.cb_source.Location = new System.Drawing.Point(422, 294);
            this.cb_source.Name = "cb_source";
            this.cb_source.Size = new System.Drawing.Size(148, 36);
            this.cb_source.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(604, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Destination";
            // 
            // cb_destination
            // 
            this.cb_destination.BackColor = System.Drawing.Color.Transparent;
            this.cb_destination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_destination.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_destination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_destination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_destination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_destination.ItemHeight = 30;
            this.cb_destination.Items.AddRange(new object[] {
            "Beograd",
            "Novi Sad",
            "Subotica",
            "Valjevo",
            "Pozega",
            "Uzice",
            "Priboj",
            "Kraljevo",
            "Nis"});
            this.cb_destination.Location = new System.Drawing.Point(608, 294);
            this.cb_destination.Name = "cb_destination";
            this.cb_destination.Size = new System.Drawing.Size(148, 36);
            this.cb_destination.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(781, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Travel Coast";
            // 
            // dgv_travel
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_travel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_travel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_travel.ColumnHeadersHeight = 4;
            this.dgv_travel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_travel.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_travel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_travel.Location = new System.Drawing.Point(52, 356);
            this.dgv_travel.Name = "dgv_travel";
            this.dgv_travel.RowHeadersVisible = false;
            this.dgv_travel.Size = new System.Drawing.Size(913, 265);
            this.dgv_travel.TabIndex = 54;
            this.dgv_travel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_travel.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_travel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_travel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_travel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_travel.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_travel.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_travel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_travel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_travel.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_travel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_travel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_travel.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_travel.ThemeStyle.ReadOnly = false;
            this.dgv_travel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_travel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_travel.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_travel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_travel.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_travel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_travel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_travel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_travel_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 645);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 23);
            this.panel2.TabIndex = 58;
            // 
            // btn_edit
            // 
            this.btn_edit.BorderRadius = 20;
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.FillColor = System.Drawing.Color.ForestGreen;
            this.btn_edit.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(993, 356);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.PressedColor = System.Drawing.Color.Azure;
            this.btn_edit.Size = new System.Drawing.Size(124, 35);
            this.btn_edit.TabIndex = 60;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BorderRadius = 20;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.Tomato;
            this.btn_add.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(993, 294);
            this.btn_add.Name = "btn_add";
            this.btn_add.PressedColor = System.Drawing.Color.Azure;
            this.btn_add.Size = new System.Drawing.Size(124, 35);
            this.btn_add.TabIndex = 59;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // TravelMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 668);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_travel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_destination);
            this.Controls.Add(this.cb_source);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_trainCode);
            this.Controls.Add(this.dateTimeTravel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_travelCoast);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TravelMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelMaster";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_travel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closelabel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox tb_travelCoast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimeTravel;
        private Guna.UI2.WinForms.Guna2ComboBox cb_trainCode;
        private Guna.UI2.WinForms.Guna2ComboBox cb_source;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cb_destination;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_travel;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_add;
    }
}