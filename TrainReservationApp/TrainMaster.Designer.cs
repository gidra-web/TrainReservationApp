namespace TrainReservationApp
{
    partial class TrainMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closelabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb_trainName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_capacity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtn_bussy = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbtn_available = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbtn_busy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_train = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_train)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.panel3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(563, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Train";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb_trainName
            // 
            this.tb_trainName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_trainName.DefaultText = "";
            this.tb_trainName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_trainName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_trainName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_trainName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_trainName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_trainName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_trainName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_trainName.Location = new System.Drawing.Point(118, 291);
            this.tb_trainName.Name = "tb_trainName";
            this.tb_trainName.PasswordChar = '\0';
            this.tb_trainName.PlaceholderText = "";
            this.tb_trainName.SelectedText = "";
            this.tb_trainName.Size = new System.Drawing.Size(200, 36);
            this.tb_trainName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(114, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Train~Name";
            // 
            // tb_capacity
            // 
            this.tb_capacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_capacity.DefaultText = "";
            this.tb_capacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_capacity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_capacity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_capacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_capacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_capacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_capacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_capacity.Location = new System.Drawing.Point(424, 291);
            this.tb_capacity.Name = "tb_capacity";
            this.tb_capacity.PasswordChar = '\0';
            this.tb_capacity.PlaceholderText = "";
            this.tb_capacity.SelectedText = "";
            this.tb_capacity.Size = new System.Drawing.Size(200, 36);
            this.tb_capacity.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(420, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Train~Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(724, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Train~Status";
            // 
            // rbtn_bussy
            // 
            this.rbtn_bussy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_bussy.CheckedState.BorderThickness = 0;
            this.rbtn_bussy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_bussy.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_bussy.ForeColor = System.Drawing.Color.RosyBrown;
            this.rbtn_bussy.Location = new System.Drawing.Point(679, 295);
            this.rbtn_bussy.Name = "rbtn_bussy";
            this.rbtn_bussy.Size = new System.Drawing.Size(20, 20);
            this.rbtn_bussy.TabIndex = 14;
            this.rbtn_bussy.Text = "guna2CustomRadioButton1";
            this.rbtn_bussy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_bussy.UncheckedState.BorderThickness = 2;
            this.rbtn_bussy.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_bussy.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtn_available
            // 
            this.rbtn_available.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_available.CheckedState.BorderThickness = 0;
            this.rbtn_available.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_available.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_available.ForeColor = System.Drawing.Color.RosyBrown;
            this.rbtn_available.Location = new System.Drawing.Point(784, 295);
            this.rbtn_available.Name = "rbtn_available";
            this.rbtn_available.Size = new System.Drawing.Size(20, 20);
            this.rbtn_available.TabIndex = 15;
            this.rbtn_available.Text = "guna2CustomRadioButton2";
            this.rbtn_available.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_available.UncheckedState.BorderThickness = 2;
            this.rbtn_available.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_available.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtn_busy
            // 
            this.rbtn_busy.AutoSize = true;
            this.rbtn_busy.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_busy.ForeColor = System.Drawing.Color.RosyBrown;
            this.rbtn_busy.Location = new System.Drawing.Point(704, 293);
            this.rbtn_busy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtn_busy.Name = "rbtn_busy";
            this.rbtn_busy.Size = new System.Drawing.Size(62, 22);
            this.rbtn_busy.TabIndex = 16;
            this.rbtn_busy.Text = "busy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(809, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "available";
            // 
            // dgv_train
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_train.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_train.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_train.ColumnHeadersHeight = 4;
            this.dgv_train.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_train.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_train.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_train.Location = new System.Drawing.Point(118, 357);
            this.dgv_train.Name = "dgv_train";
            this.dgv_train.RowHeadersVisible = false;
            this.dgv_train.Size = new System.Drawing.Size(809, 215);
            this.dgv_train.TabIndex = 18;
            this.dgv_train.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_train.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_train.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_train.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_train.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_train.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_train.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_train.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_train.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_train.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_train.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_train.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_train.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_train.ThemeStyle.ReadOnly = false;
            this.dgv_train.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_train.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_train.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_train.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_train.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_train.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_train.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_train.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_train_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 41);
            this.panel2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1140, 31);
            this.panel4.TabIndex = 20;
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
            this.btn_add.Location = new System.Drawing.Point(974, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.PressedColor = System.Drawing.Color.Azure;
            this.btn_add.Size = new System.Drawing.Size(124, 35);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.btn_edit.Location = new System.Drawing.Point(974, 405);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.PressedColor = System.Drawing.Color.Azure;
            this.btn_edit.Size = new System.Drawing.Size(124, 35);
            this.btn_edit.TabIndex = 26;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BorderRadius = 20;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.ForestGreen;
            this.btn_delete.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(974, 456);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PressedColor = System.Drawing.Color.Azure;
            this.btn_delete.Size = new System.Drawing.Size(124, 35);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // TrainMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 668);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_train);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbtn_busy);
            this.Controls.Add(this.rbtn_available);
            this.Controls.Add(this.rbtn_bussy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_capacity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_trainName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainMaster";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_train)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closelabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2TextBox tb_trainName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tb_capacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbtn_bussy;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbtn_available;
        private System.Windows.Forms.Label rbtn_busy;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_train;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
    }
}