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
    public partial class Booking : Form
    {
        string random_result_code; //ตัวแปรเก็บรหัส Booking
        string[] allname; //ตัวแปรเก็บรายชื่อของผู้โดยสารทั้งหมด
        string[] allid; //ตัวแปรเก็บเลขประจำตัวประชาชนของผู้โดยสารทั้งหมด
        string[] birthinfo; //ตัวแปรเก็บข้อมูลวันเกิด
        public Booking()
        {
            InitializeComponent();
        }

        private void Check_agree(object sender, EventArgs e)
        {
            if(chb_get_agree.Checked == true) //หากช่องยอมรับถูกติ๊ก
            { 
                bt_save.Enabled = true; //ให้เปิดปุ่ม บันทึกข้อมูล
            }
            else if (chb_get_agree.Checked == false)//หากช่องยอมรับไม่ถูกติ๊ก
            {
                bt_save.Enabled = false;//ให้ปิดปุ่ม บันทึกข้อมูล
            }
        }

        private void bt_save_Click(object sender, EventArgs e) //ปุ่ม Confirm
        {
            birthinfo = dtp_get_birth.Text.Split('/'); //ดึงข้อมูลจาก ช่องวันเกิด แยกข้อมุลโดยเครื่องหมาย /
            int age = 2560 - int.Parse(birthinfo[2]); //คำนวณอายุจากการนำ พ.ศ ปัจจุบันลบด้วยปีเกิด 
            if (cb_get_title.Text == "" || cb_get_flight.Text == "" || tb_get_firstname.Text ==""|| tb_get_lastname.Text == "") //ตรวจสอบการกรอกข้อมูล
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน","Error"); //แจ้งเตือน
            }
            else if (age < 18) //ตรวจสอบอายุถ้าต่ำกว่า 18 ปี 
            {
                MessageBox.Show("คุณอายุไม่ถึง 18ปี ไม่สามารถจองตั๋วได้!","Error");  //แจ้งเตือน
            }
            else if (tb_get_id.Text.Length != 13) //ตรวจสอบการกรอกเลขประจำตัวประชาชน
            {
                MessageBox.Show("กรุณากรอกรหัสประจำตัวให้ถูกต้อง!","Error");  //แจ้งเตือน
            } 
            else  //*******กรณีข้อมูลครบ
            {
                allname = File.ReadAllText("data/name_data_customer.txt").Split('|'); //อ่านรายชื่อของผู้โดยสารทั้งหมด
                allid = File.ReadAllText("data/id_data_customer.txt").Split('|');  //อ่านเลขประจำตัวประชาชนของผู้โดยสารทั้งหมด
                string fullname = cb_get_title.Text.ToUpper() + "." + tb_get_firstname.Text.ToUpper() + " " + tb_get_lastname.Text.ToUpper(); //สร้างฟอร์มชื่อที่ประกอบด้วย คำนำหน้า ชื่อนามสกุล
                int name_same=0; //ตัวแปรเก็บสถานะของชื่อผู้โดยสารที่ซ้ำ 
                int id_same = 0; //ตัวแปรเก็บสถานะของเลขประจำตัวประชาชนผู้โดยสารที่ซ้ำ
                for (int i = 0; i < allname.Length; i++) //วนตรวจสอบชื่อผู้โดยสารที่ซ้ำ 
                {
                    if (fullname == allname[i]) //ถ้าชื่อซ้ำ
                    {
                        name_same = 1; //จะให้สถานะเท่ากับ 1 
                        break;
                    }
                    else //ถ้าชื่อไม่ซ้ำ
                    {
                        name_same = 0; //จะให้สถานะเท่ากับ 0 
                    }              
                }
                if(name_same == 1) //ถ้าสถานะมีค่าเป็น 1  (ชื่อซ้ำ)
                {
                    MessageBox.Show("ชื่อนี้ซ้ำกับชื่อในระบบ!","Error!"); //แจ้งเตือน
                }
                //------------------------------------------------------------------------------------------------------
                else if (name_same == 0) //ถ้าสถานะมีค่าเป็น 0  (ชื่อไม่ซ้ำ)
                {
                    for (int i = 0; i < allid.Length; i++) //วนตรวจสอบเลขประจำตัวประชาชนผู้โดยสารที่ซ้ำ 
                    {
                        if (tb_get_id.Text == allid[i]) //ถ้าเลขประจำตัวซ้ำ
                        {
                            id_same = 1; //จะให้สถานะเท่ากับ 1
                            break;
                        }
                        else //ถ้าเลขประจำตัวไม่ซ้ำ
                        {
                            id_same = 0; //จะให้สถานะเท่ากับ 0 
                        }

                    }
                    if (id_same == 1)   //ถ้าสถานะมีค่าเป็น 1 แสดงว่าซ้ำ
                    {
                        MessageBox.Show("หมายเลขบัตรประจำตัวประชาชนนี้ถูกใช้แล้ว!","Error!");
                    }
                    else if (id_same == 0) //ถ้าสถานะมีค่าเป็น 0 แสดงว่าไม่ซ้ำ
                    {
                        randomcode(); //สุ่มเลข Booking
                        MessageBox.Show("จองตั๋วสำเสร็จ!!"+Environment.NewLine+"หมายเลขการจองของคุณคือ : "+random_result_code,"Booking Success"); //ขึ้นหน้าต่างสำเร็จ
                        save_information(); //บันทึกข้อมูล
                        Close(); //ปิดหน้าต่าง
                    }
                }
                
            }
        }     
        private void bt_back_Click(object sender, EventArgs e)
        {
            Close(); //ปิดโปรแกรม
        }

        public void randomcode() //ฟังก์ชั่นสุ่มรหัส Booking
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); //สร้างตัวอักษรเก็บไว้
            Random random = new Random(); //สร้างฟังชั่นสุ่ม
            string word = ""; //สร้างประโยคเริ่มต้น
            for (int i = 1; i <= 5; i++) //วน5รอบ
            {
                int letter_num = random.Next(0, letters.Length - 1); //สุ่มตัวอักษร
                word += letters[letter_num]; //นำตัวอักษรมาเรียงในประโยค
            }
            random_result_code = word; // ส่งข้อความที่สุ่มได้ไปยังตัวแปร รหัส Booking
        }
        public void save_information() //ฟังก์ชั่นบันทึกข้อมูล
        {
            string save_title, save_firstname, save_lastname, save_idcard,save_code,save_dateofbirth,save_flight; //สร้างตัวแปรสำหรับบันทึกข้อมูล
            save_title = cb_get_title.Text.ToUpper(); //คำนำหน้าชื่อ
            save_firstname = tb_get_firstname.Text.ToUpper(); //ชื่อจริง
            save_lastname = tb_get_lastname.Text.ToUpper(); // นามสกุล
            save_idcard = tb_get_id.Text; //เลขประจำตัวประชาชน
            save_code = random_result_code; //รหัสการจอง
            save_dateofbirth = dtp_get_birth.Text; //วันเกิด
            save_flight = cb_get_flight.Text; //เที่ยวบิน
            string booking_data_old = File.ReadAllText("data/booking_data_customer.txt"); //ดึงข้อมูลรหัสการจองเก่า
            string all_data_old = File.ReadAllText("data/all_data_customer.txt"); //ดึงข้อมูลลูกค้าเก่า
            string name_data_old = File.ReadAllText("data/name_data_customer.txt"); //ดึงข้อมูลชื่อลูกค้าเก่า
            string id_data_old = File.ReadAllText("data/id_data_customer.txt"); //ดึงข้อมูลรหัสประจำตัวเก่า
            string checkin_status_old = File.ReadAllText("data/checkin_status.txt"); //ดึงสถานะการเช็คอินเก่า

            string booking_data_save_format = booking_data_old + random_result_code + "|"; //รวมรหัสการจองเก่ากับใหม่เข้าด้วยกัน
            string all_data_save_format = all_data_old + "#Booking Number : "+save_code+Environment.NewLine+"Passenger :  "+save_title+"."+save_firstname+"   "+save_lastname+Environment.NewLine+"Date Of Birth : "+save_dateofbirth+Environment.NewLine+"ID Card : "+save_idcard+Environment.NewLine+"Flight : "+save_flight+Environment.NewLine+"----------------------------------------------------"+Environment.NewLine; //รวมข้อมูลลูกค้าเก่ากับใหม่เข้าด้วยกัน
            string name_data_save_format = name_data_old + save_title + "." + save_firstname + " " + save_lastname + "|"; //รวมชื่อลูกค้าเก่ากับใหม่เข้าด้วยกัน
            string id_data_save_format = id_data_old + save_idcard+ "|"; //รวมชื่อลูกค้าเก่ากับใหม่เข้าด้วยกัน
            string checkin_status_format = checkin_status_old + "0"+"|"; //รวมสถานะเช้คอินเก่ากับใหม่เข้าด้วยกัน
            File.WriteAllText("data/booking_data_customer.txt", booking_data_save_format); //บันทึก
            File.WriteAllText("data/all_data_customer.txt", all_data_save_format); //บันทึก
            File.WriteAllText("data/name_data_customer.txt", name_data_save_format); //บันทึก
            File.WriteAllText("data/id_data_customer.txt", id_data_save_format); //บันทึก
            File.WriteAllText("data/checkin_status.txt", checkin_status_format); //บันทึก
        }
    }
        }
    
    

