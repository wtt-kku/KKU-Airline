namespace KKUAirline
{
    partial class main
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
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_book = new System.Windows.Forms.PictureBox();
            this.pb_checkin = new System.Windows.Forms.PictureBox();
            this.pb_table = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_book = new System.Windows.Forms.Label();
            this.lb_checkin = new System.Windows.Forms.Label();
            this.lb_table = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_close
            // 
            this.pb_close.BackColor = System.Drawing.Color.Transparent;
            this.pb_close.Image = global::KKUAirline.Properties.Resources.bt_close;
            this.pb_close.Location = new System.Drawing.Point(677, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(49, 49);
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // pb_book
            // 
            this.pb_book.BackColor = System.Drawing.Color.Transparent;
            this.pb_book.Image = global::KKUAirline.Properties.Resources.book_o;
            this.pb_book.Location = new System.Drawing.Point(123, 162);
            this.pb_book.Name = "pb_book";
            this.pb_book.Size = new System.Drawing.Size(142, 162);
            this.pb_book.TabIndex = 1;
            this.pb_book.TabStop = false;
            this.pb_book.Click += new System.EventHandler(this.pb_book_Click);
            this.pb_book.MouseLeave += new System.EventHandler(this.pb_book_MouseLeave);
            this.pb_book.MouseHover += new System.EventHandler(this.pb_book_MouseHover);
            // 
            // pb_checkin
            // 
            this.pb_checkin.BackColor = System.Drawing.Color.Transparent;
            this.pb_checkin.Image = global::KKUAirline.Properties.Resources.checkin_o;
            this.pb_checkin.Location = new System.Drawing.Point(306, 162);
            this.pb_checkin.Name = "pb_checkin";
            this.pb_checkin.Size = new System.Drawing.Size(142, 162);
            this.pb_checkin.TabIndex = 2;
            this.pb_checkin.TabStop = false;
            this.pb_checkin.Click += new System.EventHandler(this.pb_checkin_Click);
            this.pb_checkin.MouseLeave += new System.EventHandler(this.pb_checkin_MouseLeave);
            this.pb_checkin.MouseHover += new System.EventHandler(this.pb_checkin_MouseHover);
            // 
            // pb_table
            // 
            this.pb_table.BackColor = System.Drawing.Color.Transparent;
            this.pb_table.Image = global::KKUAirline.Properties.Resources.table_o;
            this.pb_table.Location = new System.Drawing.Point(489, 162);
            this.pb_table.Name = "pb_table";
            this.pb_table.Size = new System.Drawing.Size(142, 162);
            this.pb_table.TabIndex = 3;
            this.pb_table.TabStop = false;
            this.pb_table.Click += new System.EventHandler(this.pb_table_Click);
            this.pb_table.MouseLeave += new System.EventHandler(this.pb_table_MouseLeave);
            this.pb_table.MouseHover += new System.EventHandler(this.pb_table_MouseHover);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = global::KKUAirline.Properties.Resources.logo;
            this.pb_logo.Location = new System.Drawing.Point(32, 26);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(493, 113);
            this.pb_logo.TabIndex = 4;
            this.pb_logo.TabStop = false;
            // 
            // lb_book
            // 
            this.lb_book.AutoSize = true;
            this.lb_book.BackColor = System.Drawing.Color.Transparent;
            this.lb_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_book.Location = new System.Drawing.Point(143, 311);
            this.lb_book.Name = "lb_book";
            this.lb_book.Size = new System.Drawing.Size(97, 25);
            this.lb_book.TabIndex = 5;
            this.lb_book.Text = "Booking";
            this.lb_book.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_checkin
            // 
            this.lb_checkin.AutoSize = true;
            this.lb_checkin.BackColor = System.Drawing.Color.Transparent;
            this.lb_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_checkin.Location = new System.Drawing.Point(327, 311);
            this.lb_checkin.Name = "lb_checkin";
            this.lb_checkin.Size = new System.Drawing.Size(105, 25);
            this.lb_checkin.TabIndex = 6;
            this.lb_checkin.Text = "Check-in";
            this.lb_checkin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_table
            // 
            this.lb_table.AutoSize = true;
            this.lb_table.BackColor = System.Drawing.Color.Transparent;
            this.lb_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_table.Location = new System.Drawing.Point(500, 311);
            this.lb_table.Name = "lb_table";
            this.lb_table.Size = new System.Drawing.Size(121, 25);
            this.lb_table.TabIndex = 7;
            this.lb_table.Text = "Clear data";
            this.lb_table.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::KKUAirline.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(727, 403);
            this.Controls.Add(this.lb_table);
            this.Controls.Add(this.lb_checkin);
            this.Controls.Add(this.lb_book);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.pb_table);
            this.Controls.Add(this.pb_checkin);
            this.Controls.Add(this.pb_book);
            this.Controls.Add(this.pb_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_close;
        public System.Windows.Forms.PictureBox pb_book;
        public System.Windows.Forms.PictureBox pb_checkin;
        public System.Windows.Forms.PictureBox pb_table;
        public System.Windows.Forms.PictureBox pb_logo;
        public System.Windows.Forms.Label lb_book;
        public System.Windows.Forms.Label lb_checkin;
        public System.Windows.Forms.Label lb_table;
    }
}

