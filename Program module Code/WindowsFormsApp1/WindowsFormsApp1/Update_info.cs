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
    public partial class Update_info : Form
    {
        string after_sitnum = "";
        public Update_info()
        {
            InitializeComponent();
            for (int i = 0; i < 21; i++)
            {
                aftersitnum.Items.Add(Main.client_info[i,0]);
            }
            beforesitnum.Text = Main.sit_num;
        }

        private void aftersitnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Main.client_info[(Convert.ToInt16(aftersitnum.SelectedItem.ToString()) - 1), 1] != null)
            {
                MessageBox.Show("유효하지 않은 좌석입니다. \n다시 선택해주세요");
            }
            else
            {
                after_sitnum = aftersitnum.SelectedItem.ToString();
                MessageBox.Show(after_sitnum + "번 좌석을 선택하셨습니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //선택하기 전 좌석 배열 초기화
            Main.client_info[(Convert.ToInt16(beforesitnum.Text) - 1), 1] = null;
            Main.client_info[(Convert.ToInt16(beforesitnum.Text) - 1), 2] = null;
            Main.client_info[(Convert.ToInt16(aftersitnum.SelectedItem.ToString()) - 1), 3] = Main.client_info[(Convert.ToInt16(beforesitnum.Text) - 1), 3];
            Main.dttime[(Convert.ToInt16(aftersitnum.SelectedItem.ToString()) - 1)] = Main.dttime[(Convert.ToInt16(beforesitnum.Text) - 1)];
            Main.client_info[(Convert.ToInt16(aftersitnum.SelectedItem.ToString()) - 1), 1] = textBox1.Text;
            Main.client_info[(Convert.ToInt16(aftersitnum.SelectedItem.ToString()) - 1), 2] = textBox2.Text;
            MessageBox.Show("좌석번호 : " + after_sitnum + "\n차량번호 : " + Main.client_info[(Convert.ToInt16(aftersitnum.SelectedItem.ToString()) - 1), 1] +
                "\n전화번호 : " + Main.client_info[(Convert.ToInt16(aftersitnum.SelectedItem.ToString()) - 1), 2] + "\n수정되었습니다.");
            this.Close();
        }
    }
}
