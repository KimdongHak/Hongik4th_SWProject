using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class RegisterCars : Form
    {
        string car_num = "";
        string phone_num = "";
        string seat_num = "";
        public RegisterCars()
        {
            InitializeComponent();
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 자리 배열을 panel에 부착
            ArraySits frm6 = new ArraySits(this);
            frm6.TopLevel = false;
            frm6.Dock = System.Windows.Forms.DockStyle.Fill;
            frm6.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm6);
            frm6.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar)||e.KeyChar==Convert.ToInt32(Keys.Back) || (e.KeyChar == '-')){
                
            }
            else
            {
                e.Handled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                car_num = textBox1.Text;
                phone_num = textBox2.Text;
                seat_num = label2.Text;
                DialogResult dr = MessageBox.Show("좌석번호 : " + seat_num + "\n차량번호 : " + car_num + "\n핸드폰 번호 : " + phone_num + "\n접수 하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("접수가 완료되었습니다.");
                    //2차원 배열 에 각각 정보 입력
                    Main.client_info[(Convert.ToInt16(seat_num)-1), 1] = car_num;
                    Main.client_info[(Convert.ToInt16(seat_num)-1), 2] = phone_num;
                    Main.dttime[(Convert.ToInt16(seat_num) - 1)] = DateTime.Now;
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("다시 입력해주세요.");
                }
            }
            catch
            {


            }
           
        }

        private void RegisterCars_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
