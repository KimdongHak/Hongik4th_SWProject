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
    public partial class Update : Form
    {
        public static int pay = 0;
        public Update()
        {
            InitializeComponent();
            for (int i = 0; i < 21; i++)
            {
                sit_num.Items.Add(Main.client_info[i, 0]);
            }
            carnum.Hide();
            phonenum.Hide();
            timeuse.Hide();
            cost.Hide();
            carimage.SizeMode = PictureBoxSizeMode.StretchImage;
            carimage.Image = System.Drawing.Image.FromFile("F:\\WindowsFormsApp1\\WindowsFormsApp1\\WindowsFormsApp1\\Properties\\noimage.jpg");
        }

        private void lookup_Click(object sender, EventArgs e)
        {

                /*            ArraySits update = new ArraySits(this);
            update.TopLevel = false;
            update.Dock = System.Windows.Forms.DockStyle.Fill;
            update.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(update);
            update.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DialogResult dr = MessageBox.Show("좌석번호 : " + Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 0] +
                    "\n차량번호 : " + Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 1] +
                    "\n차종 : " + Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 3] +
                    "\n사용시간 : " + timeuse.Text +
                    "\n" +
                    (pay * 70 / 100).ToString() + "원 결제하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("결제 완료되었습니다.");
                    Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 1] = null;
                    Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 2] = null;
                    //2차원 배열 에 각각 정보 입력
                    //                    this.Close();
                }
                else
                {
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("좌석번호 : " + Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 0] +
                 "\n차량번호 : " + Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 1] +
                 "\n차종 : " + Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 3] +
                 "\n사용시간 : " + timeuse.Text +
                 "\n" +
                 pay.ToString() + "원 결제하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("결제 완료되었습니다.");
                    Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 1] = null;
                    Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 2] = null;
                    //2차원 배열 에 각각 정보 입력
                    //                    this.Close();
                }
                else
                {
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cost.Text = (pay * 70 / 100).ToString();
            }
            else
            {
                cost.Text = pay.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 1] == null)
            {
                MessageBox.Show("빈좌석입니다.");
                carimage.Image = System.Drawing.Image.FromFile("F:\\WindowsFormsApp1\\WindowsFormsApp1\\WindowsFormsApp1\\Properties\\noimage.jpg");
                carnum.Hide();
                phonenum.Hide();
                timeuse.Hide();
                cost.Hide();
            }
            else
            {
                carnum.Show();
                phonenum.Show();
                timeuse.Show();
                cost.Show();
                Main.sit_num = sit_num.SelectedItem.ToString();
                carnum.Text = Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 1];
                phonenum.Text = Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 2];

                DateTime dtnowtime = DateTime.Now;
                TimeSpan timediff = dtnowtime - Main.dttime[(Convert.ToInt16(sit_num.SelectedItem) - 1)];
                int diffminute = timediff.Minutes;
                int diffsecond = timediff.Seconds;

                timeuse.Text = diffminute.ToString() + " 분 " + diffsecond.ToString() + " 초";


                pay = diffminute * 60 + diffsecond * 10;
                cost.Text = pay.ToString();
                carimage.SizeMode = PictureBoxSizeMode.StretchImage;
                carimage.Image = System.Drawing.Image.FromFile("F:\\WindowsFormsApp1\\WindowsFormsApp1\\WindowsFormsApp1\\Properties\\" + Main.client_info[(Convert.ToInt16(sit_num.SelectedItem) - 1), 3] + ".jpg");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_info upinfo = new Update_info();
            upinfo.Show();
        }

        private void Update_Load(object sender, EventArgs e)
        {


        }
    }
}
