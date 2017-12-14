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
    public partial class Checkin : Form
    {
        string[] allbooking = File.ReadAllText("data/booking_data_customer.txt").Split('|'); //ดึงไฟล์ข้อมูลหายเลขการจอง
        string[] allcheckin_status = File.ReadAllText("data/checkin_status.txt").Split('|'); //ดึงไฟล์ข้อมูลสถานะการเช้คอิน
        string[] allname = File.ReadAllText("data/name_data_customer.txt").Split('|'); //ดึงไฟล์ข้อมูลชื่อลูกค้า
        string[] allseat = File.ReadAllText("data/seats_data.txt").Split('|'); //ดึงไฟล์ข้อมูลสถานะที่นั่ง
        int index; //สร้างตัวแปรเก็บตำแหน่งอ้างอิง
        public Checkin()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            int have_booking = 0; //สร้างตัวแปรเก็บสถานะการจอง
            for (int i = 0; i < allbooking.Length; i++)   //วนตรวจสอบ
            {
                if (tb_get_code.Text.ToUpper() == allbooking[i]) //ถ้าหมายเลขการจองตรงกับข้อมูลใน allbooking[i]
                {
                    have_booking = 1;   //ให้ค่าการจองเท่ากับ 1 (พบหมายเลขการจอง)
                    index = i;          //กำหนดเลขอ้างอิง จากการวนลูป
                    break;              //ออกจากลูป
                }
                else //ถ้าหมายเลขการจองไม่ตรงกับข้อมูลใน allbooking[i]
                {
                    have_booking = 0; //ให้ค่าการจองเท่ากับ 0 (ไม่พบหมายเลขการจอง)
                }
            }
            if (cb_get_flight.Text == string.Empty) //ตรวจสอบถ้าไม่เลือกเที่ยวบิน
            {
                MessageBox.Show("กรุณาเลือก Flight","Error"); //แจ้งเตือน
            }
            else if (tb_get_code.Text == string.Empty) //ตรวจสอบถ้าไม่ใส่หมายเลขการจอง
            {
                MessageBox.Show("กรุณาใส่หมายเลข Booking", "Error"); //แจ้งเตือน
            }
            else if (have_booking == 0 && cb_get_flight.Text != "")  //ตรวจสอบถ้าเลือกเที่ยวบิน แต่ไม่พบหมายเลขการจอง
            {
                MessageBox.Show("ไม่พบหมายเลข Booking นี้ในระบบ", "Error"); //แจ้งเตือน
            }
            else if (allcheckin_status[index] == "1") //ตรวจสอบถ้าเช็คอิน
            {
                MessageBox.Show("คุณทำการ CHECK IN ไปแล้ว!", "Error"); //แจ้งเตือน
            }
            else if (have_booking == 1&&cb_get_flight.Text != "")  //ตรวจสอบถ้าเลือกเที่ยวบิน และพบการจอง
            {
                tb_get_code.Enabled = false; //ปิดช่องหมายเลขการจอง
                cb_get_flight.Enabled = false; //ปิดช่องเลือกเที่ยวบิน
                bt_confirm1.Enabled = false; //ปิดปุ่ม
                Second.Visible = true; //เปิดช่องเลือกที่นั่ง
                name.Text = allname[index]; //แสดงชื่อโดยอ้างอิงจากตำแหน่ง
            }

        }


        private void Checkin_Load(object sender, EventArgs e)
        {
            RadioButton[] Seats = new RadioButton[64] //สร้างตัวแปรอาเรย์เก็บข้อมูลที่นั่ง
            {D1,D2,D3,D4,D5,D6,D7,D8,D9,D10,D11,D12,D13,D14,D15,D16,
            C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13,C14,C15,C16,
            B1,B2,B3,B4,B5,B6,B7,B8,B9,B10,B11,B12,B13,B14,B15,B16,
            A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13,A14,A15,A16 };
            

            for(int i = 0; i < Seats.Length; i++)//วนแสดงที่นั่งที่ว่าง
            {
                if (allseat[i] == "0") //ถ้าที่นั่งมีสถานะเป็น 0 
                {
                    Seats[i].Enabled = true;//จะเปิดให้เลือก
                }
                else if (allseat[i] == "1") //ถ้าที่นั่งมีสถานะเป็น 1 
                {
                    
                    Seats[i].Enabled = false; //จะปิดไม่ให้เลือก
                }
            }
        }

        private void radio_click(object sender, EventArgs e)
        {
            RadioButton Press = (RadioButton)sender; //ตรวจว่าคลิกปุ่มใด
            seat_num.Text = Press.Name; //แสดงตำแหน่งที่นั่งตรง Label
        }

        private void button2_Click(object sender, EventArgs e)
        {

            RadioButton[] Seats = new RadioButton[64]//สร้างตัวแปรอาเรย์เก็บข้อมูลที่นั่ง
            {D1,D2,D3,D4,D5,D6,D7,D8,D9,D10,D11,D12,D13,D14,D15,D16,
            C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13,C14,C15,C16,
            B1,B2,B3,B4,B5,B6,B7,B8,B9,B10,B11,B12,B13,B14,B15,B16,
            A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13,A14,A15,A16 };
            string[] old_seat_data = File.ReadAllText("data/seats_data.txt").Split('|');
            

            string new_seat_data="";  //สร้างข้อมูลที่นั่งใหม่
            string new_ckeckin_status = "";  //สร้างข้อมูลสถายะเช้คอินใหม่

            for (int x = 0; x < 64; x++) //วนกำหนดข้อมูล
            {
                if (Seats[x].Checked==true) //ถ้าที่นั่งใดถูกติ๊ก
                {
                    old_seat_data[x] = "1"; //ให้กำหนดสถานะเท่ากับ 1
                }
            }

            if (seat_num.Text == "-") //ถ้าไม่ได้เลือกที่นั่ง
            {
                MessageBox.Show("กรุณาเลือกที่นั่งก่อนกดปุ่ม \"ยืนยัน\"", "Error"); // แจ้งเตือน
            }
            else {
                string[] checkin_status = File.ReadAllText("data/checkin_status.txt").Split('|'); //อ่านข้อมูลสถานะการเช็คอิน
                checkin_status[index] = "1"; //ให้สถานะที่ตำแหน่งอ้างอิงในบรรทัดที่ 35 

                for (int i = 0; i < checkin_status.Length-1; i++) //รวมข้อมูลสถานะการเช็คอินเก่าและใหม่เข้าด้วยกัน
                {
                    new_ckeckin_status = new_ckeckin_status + checkin_status[i] + "|"; 
                }

                for (int i = 0; i < old_seat_data.Length - 1; i++) //รวมข้อมูลที่นั่งเก่าและใหม่เข้าด้วยกัน
                {
                    new_seat_data = new_seat_data + old_seat_data[i] + "|";
                }

                File.WriteAllText("data/checkin_status.txt", new_ckeckin_status); //บันทึกสถานะการเช็คอิน
                File.WriteAllText("data/seats_data.txt", new_seat_data); //บันทึกสถานะที่นั่ง
                ticket FormTicket = new ticket(); //เปิด FormTicket 
                FormTicket.lb_booking.Text = tb_get_code.Text.ToUpper(); //ส่งตัวแปรรหัสการจอง
                FormTicket.lb_name.Text = name.Text; //ส่งตัวแปรชื่อ
                FormTicket.lb_seat.Text = seat_num.Text; //ส่งตัวแปรที่นั่ง
                FormTicket.Show(); //เปิดฟอรืมตั่ว
                Close(); //ปิดดปรแกรม
            }
        }

    }
}
