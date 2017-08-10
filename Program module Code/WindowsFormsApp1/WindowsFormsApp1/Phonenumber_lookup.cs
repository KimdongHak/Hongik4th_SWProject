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
    public partial class Phonenumber_lookup : Form
    {
        Selectlookup frm;
        public Phonenumber_lookup()
        {
            InitializeComponent();
        }
        public Phonenumber_lookup(Selectlookup _form)
        {
            InitializeComponent();
            frm = _form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
            {

                if (Main.client_info[i,2] == inputbox.Text)
                {
                    MessageBox.Show("고객님의 자리조회내역 입니다.\n차 번호 : " + Main.client_info[i,1] + "\n자리 번호 : " + Main.client_info[i,0]);
                    break;
                }
            }
        }
    }
}
