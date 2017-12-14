namespace KKUAirline
{
    partial class Booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_get_firstname = new System.Windows.Forms.TextBox();
            this.cb_get_title = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_get_lastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_get_birth = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_get_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_get_flight = new System.Windows.Forms.ComboBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.chb_get_agree = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(89, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // tb_get_firstname
            // 
            this.tb_get_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_get_firstname.Location = new System.Drawing.Point(94, 211);
            this.tb_get_firstname.Name = "tb_get_firstname";
            this.tb_get_firstname.Size = new System.Drawing.Size(188, 24);
            this.tb_get_firstname.TabIndex = 2;
            // 
            // cb_get_title
            // 
            this.cb_get_title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_get_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_get_title.FormattingEnabled = true;
            this.cb_get_title.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Miss"});
            this.cb_get_title.Location = new System.Drawing.Point(94, 147);
            this.cb_get_title.Name = "cb_get_title";
            this.cb_get_title.Size = new System.Drawing.Size(92, 26);
            this.cb_get_title.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(89, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(89, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lastname";
            // 
            // tb_get_lastname
            // 
            this.tb_get_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_get_lastname.Location = new System.Drawing.Point(94, 278);
            this.tb_get_lastname.Name = "tb_get_lastname";
            this.tb_get_lastname.Size = new System.Drawing.Size(188, 24);
            this.tb_get_lastname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(89, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of birth";
            // 
            // dtp_get_birth
            // 
            this.dtp_get_birth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtp_get_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_get_birth.Location = new System.Drawing.Point(94, 360);
            this.dtp_get_birth.Name = "dtp_get_birth";
            this.dtp_get_birth.Size = new System.Drawing.Size(188, 20);
            this.dtp_get_birth.TabIndex = 8;
            this.dtp_get_birth.Value = new System.DateTime(2017, 11, 28, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KKUAirline.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(250, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(397, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Card number";
            // 
            // tb_get_id
            // 
            this.tb_get_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_get_id.Location = new System.Drawing.Point(399, 149);
            this.tb_get_id.MaxLength = 13;
            this.tb_get_id.Name = "tb_get_id";
            this.tb_get_id.Size = new System.Drawing.Size(175, 24);
            this.tb_get_id.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(311, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Booking";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(395, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Flight";
            // 
            // cb_get_flight
            // 
            this.cb_get_flight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_get_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_get_flight.FormattingEnabled = true;
            this.cb_get_flight.Items.AddRange(new object[] {
            "KKU601"});
            this.cb_get_flight.Location = new System.Drawing.Point(399, 209);
            this.cb_get_flight.Name = "cb_get_flight";
            this.cb_get_flight.Size = new System.Drawing.Size(111, 26);
            this.cb_get_flight.TabIndex = 14;
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(392, 345);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(86, 35);
            this.bt_back.TabIndex = 15;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_save
            // 
            this.bt_save.Enabled = false;
            this.bt_save.Location = new System.Drawing.Point(501, 345);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(114, 35);
            this.bt_save.TabIndex = 16;
            this.bt_save.Text = "Confirm";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // chb_get_agree
            // 
            this.chb_get_agree.AutoSize = true;
            this.chb_get_agree.Location = new System.Drawing.Point(398, 268);
            this.chb_get_agree.Name = "chb_get_agree";
            this.chb_get_agree.Size = new System.Drawing.Size(15, 14);
            this.chb_get_agree.TabIndex = 17;
            this.chb_get_agree.UseVisualStyleBackColor = true;
            this.chb_get_agree.CheckedChanged += new System.EventHandler(this.Check_agree);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(418, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "I agree with the agreement";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KKUAirline.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(728, 453);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chb_get_agree);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.cb_get_flight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_get_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_get_birth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_get_lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_get_title);
            this.Controls.Add(this.tb_get_firstname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Booking";
            this.Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_get_firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_get_lastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_get_birth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_get_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_get_flight;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.CheckBox chb_get_agree;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cb_get_title;
    }
}