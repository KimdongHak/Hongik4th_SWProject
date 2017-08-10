using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        //21개의 좌석(행) , 0열엔 좌석번호, 1열엔 차량번호, 2열엔 전화번호, 3열엔 차량 이미지경로
        public static string[,] client_info = new string[21,4];

        public static DateTime[] dttime = new DateTime[21];
        public static string sit_num = "";
        public static string car_num = "";
        public static string phone_num = "";
        public static int num = 0;
        public Main()
        {
            InitializeComponent();
            client_info[0, 0] = "1";
            client_info[0, 3] = "chrysler";
            client_info[1, 0] = "2";
            client_info[1, 3] = "제네시스";
            client_info[2, 0] = "3";
            client_info[2, 3] = "k5";
            client_info[3, 0] = "4";
            client_info[3, 3] = "k7";
            client_info[4, 0] = "5";
            client_info[4, 3] = "sm7";
            client_info[5, 0] = "6";
            client_info[5, 3] = "람보르기니";
            client_info[6, 0] = "7";
            client_info[6, 3] = "마세라티";
            client_info[7, 0] = "8";
            client_info[7, 3] = "벤틀리";
            client_info[8, 0] = "9";
            client_info[8, 3] = "재규어";
            client_info[9, 0] = "10";
            client_info[9, 3] = "chrysler";
            client_info[10, 0] = "11";
            client_info[10, 3] = "chrysler";
            client_info[11, 0] = "12";
            client_info[11, 3] = "제네시스";
            client_info[12, 0] = "13";
            client_info[12, 3] = "k5";
            client_info[13, 0] = "14";
            client_info[13, 3] = "k7";
            client_info[14, 0] = "15";
            client_info[14, 3] = "sm7";
            client_info[15, 0] = "16";
            client_info[15, 3] = "람보르기니";
            client_info[16, 0] = "17";
            client_info[16, 3] = "마세라티";
            client_info[17, 0] = "18";
            client_info[17, 3] = "벤틀리";
            client_info[18, 0] = "19";
            client_info[18, 3] = "재규어";
            client_info[19, 0] = "20";
            client_info[19, 3] = "chrysler";
            client_info[20, 0] = "21";
            client_info[20, 3] = "chrysler";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login frm2 = new Login();
            num = 1;
            frm2.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegisterCars frm4 = new RegisterCars();
            num = 2;
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selectlookup frm5 = new Selectlookup();
            frm5.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
