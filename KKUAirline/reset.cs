using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KKUAirline
{
    public partial class reset : Form
    {
        public reset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_confirm.Text.ToUpper() == "CONFIRM") //ถ้าพิมพ์คำว่า Confirm จะลบข้อมูลในไฟล์ Text  
            {
                string Data = "";
                string SeatData = File.ReadAllText("data/seats_data_reset.txt");
                File.WriteAllText("data/all_data_customer.txt", Data);
                File.WriteAllText("data/booking_data_customer.txt", Data);
                File.WriteAllText("data/id_data_customer.txt", Data);
                File.WriteAllText("data/name_data_customer.txt", Data);
                File.WriteAllText("data/checkin_status.txt", Data);
                File.WriteAllText("data/seats_data.txt", SeatData);
                
                MessageBox.Show("ล้างข้อมูลสำเร็จ","Success");
                Close();
            }
            else
            {
                MessageBox.Show("Can't reset!", "Error");
            }
        }
    }
}
