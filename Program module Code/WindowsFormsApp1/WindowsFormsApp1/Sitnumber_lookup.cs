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
    public partial class Sitnumber_lookup : Form
    {
        Selectlookup frm;
        public Sitnumber_lookup()
        {
            InitializeComponent();
        }
        public Sitnumber_lookup(Selectlookup _form)
        {
            InitializeComponent();
            frm = _form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("고객님의 자리조회내역 입니다.\n차 번호 : " + Main.client_info[(Convert.ToInt16(textBox1.Text) - 1), 1] + "\n핸드폰 번호 : " + Main.client_info[(Convert.ToInt16(textBox1.Text) - 1), 2]);
            }
            catch
            {
                MessageBox.Show("올바르지 않은 좌석번호입니다.");
            }

        }
    }
}
