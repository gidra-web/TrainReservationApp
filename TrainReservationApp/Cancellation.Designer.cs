namespace TrainReservationApp
{
    partial class Cancellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancellation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closelabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_ticektID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_reset = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_travel = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.TabIndex = 3;
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 17);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(449, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 35);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cancellation";
            // 
            // cb_ticektID
            // 
            this.cb_ticektID.BackColor = System.Drawing.Color.Transparent;
            this.cb_ticektID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ticektID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ticektID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ticektID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ticektID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_ticektID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_ticektID.ItemHeight = 30;
            this.cb_ticektID.Location = new System.Drawing.Point(501, 271);
            this.cb_ticektID.Name = "cb_ticektID";
            this.cb_ticektID.Size = new System.Drawing.Size(148, 36);
            this.cb_ticektID.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(517, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Ticket ID";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BorderColor = System.Drawing.Color.Navy;
            this.btn_cancel.BorderRadius = 20;
            this.btn_cancel.BorderThickness = 0;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_cancel.DefaultText = "";
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn_cancel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn_cancel.FillColor = System.Drawing.Color.Tomato;
            this.btn_cancel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_cancel.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_cancel.Location = new System.Drawing.Point(374, 315);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.PasswordChar = '\0';
            this.btn_cancel.PlaceholderForeColor = System.Drawing.Color.White;
            this.btn_cancel.PlaceholderText = "Cancel";
            this.btn_cancel.SelectedText = "";
            this.btn_cancel.Size = new System.Drawing.Size(124, 31);
            this.btn_cancel.TabIndex = 54;
            this.btn_cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_reset
            // 
            this.btn_reset.BorderColor = System.Drawing.Color.Navy;
            this.btn_reset.BorderRadius = 20;
            this.btn_reset.BorderThickness = 0;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_reset.DefaultText = "";
            this.btn_reset.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn_reset.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn_reset.FillColor = System.Drawing.Color.ForestGreen;
            this.btn_reset.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_reset.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_reset.Location = new System.Drawing.Point(647, 315);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.PasswordChar = '\0';
            this.btn_reset.PlaceholderForeColor = System.Drawing.Color.White;
            this.btn_reset.PlaceholderText = "Reset";
            this.btn_reset.SelectedText = "";
            this.btn_reset.Size = new System.Drawing.Size(124, 31);
            this.btn_reset.TabIndex = 58;
            this.btn_reset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_travel
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_travel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_travel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_travel.ColumnHeadersHeight = 4;
            this.dgv_travel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_travel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_travel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_travel.Location = new System.Drawing.Point(107, 351);
            this.dgv_travel.Name = "dgv_travel";
            this.dgv_travel.RowHeadersVisible = false;
            this.dgv_travel.Size = new System.Drawing.Size(959, 265);
            this.dgv_travel.TabIndex = 59;
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 645);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 23);
            this.panel2.TabIndex = 60;
            // 
            // Cancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_travel);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cb_ticektID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cancellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancellation";
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
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cb_ticektID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox btn_cancel;
        private Guna.UI2.WinForms.Guna2TextBox btn_reset;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_travel;
        private System.Windows.Forms.Panel panel2;
    }
}