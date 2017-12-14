using KKUAirline.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKUAirline
{
    public partial class main : Form
    {
        public Image dd { get; private set; }

        public main()
        {
            InitializeComponent();
        }


        private void pb_close_Click(object sender, EventArgs e)
        {
            Close(); //ปิดโปรแกรม
        }

        private void bt_cl_Click(object sender, EventArgs e)
        {

        }

        private void pb_book_MouseHover(object sender, EventArgs e)
        {
            pb_book.Image = Resources.book_i; //นำเมาส์มาวางจะเปลี่ยนรูป
        }

        private void pb_checkin_MouseHover(object sender, EventArgs e)
        {
            pb_checkin.Image = Resources.checkin_i; //นำเมาส์มาวางจะเปลี่ยนรูป
        }

        private void pb_table_MouseHover(object sender, EventArgs e)
        {
            pb_table.Image = Resources.table_i; //นำเมาส์มาวางจะเปลี่ยนรูป
        }

        private void pb_book_MouseLeave(object sender, EventArgs e)
        {
            pb_book.Image = Resources.book_o; //นำเมาส์ออกจะเปลี่ยนรูป
        }

        private void pb_checkin_MouseLeave(object sender, EventArgs e)
        {
            pb_checkin.Image = Resources.checkin_o; //นำเมาส์ออกจะเปลี่ยนรูป
        }

        private void pb_table_MouseLeave(object sender, EventArgs e)
        {
            pb_table.Image = Resources.table_o; //นำเมาส์ออกจะเปลี่ยนรูป
        }

        private void pb_book_Click(object sender, EventArgs e)
        {
            Booking booking_form = new Booking(); //เปิด FormBooking
            booking_form.ShowDialog(); 
        }

        private void pb_checkin_Click(object sender, EventArgs e)
        {
            Checkin checkin_form = new Checkin(); //เปิด FormCheckin
            checkin_form.ShowDialog(); 
        }


        private void pb_table_Click(object sender, EventArgs e)
        {
            reset FormReset = new reset();//เปิด FormReset
            FormReset.ShowDialog();
        }
    }
}
