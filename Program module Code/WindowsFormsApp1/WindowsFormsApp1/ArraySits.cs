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
    public partial class ArraySits : Form
    {
        int exist_sits = 0;
        RegisterCars frm4;
        Update update_form;

        int sits_num = Main.num;

        public ArraySits()
        {
            InitializeComponent();
        }
        public ArraySits(RegisterCars _form)
        {
            InitializeComponent();
            frm4 = _form;
        }
        public ArraySits(Update _form)
        {
            InitializeComponent();
            update_form = _form;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Main.client_info[0, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("1번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button1.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("1");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "1";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button1.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = Color.Red;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "1";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "1";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Main.client_info[1, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("2번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button2.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("2");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "2";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = Color.Red;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;

                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "2";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "2";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Main.client_info[2, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("3번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button3.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("3");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "3";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = Color.Red;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;

                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "3";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "3";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Main.client_info[3, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("4번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button4.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("4");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "4";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button4.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = Color.Red;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "4";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "4";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Main.client_info[10, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("11번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button11.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("11");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "11";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button11.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = Color.Red;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "11";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "11";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Main.client_info[11, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("12번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button12.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("12");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "12";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button12.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = Color.Red;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "12";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "12";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Main.client_info[17, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("18번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button18.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("18");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "18";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button18.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = Color.Red;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "18";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "18";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Main.client_info[18, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("19번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button19.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("19");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "19";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button19.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = Color.Red;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "19";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "19";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Main.client_info[4, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("5번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button5.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("5");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "5";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button5.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = Color.Red;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "5";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "5";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Main.client_info[5, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("6번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button6.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("6");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "6";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button6.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = Color.Red;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "6";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "6";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Main.client_info[6, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("7번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button7.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("7");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "7";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button7.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = Color.Red;
                        button8.BackColor = SystemColors.Control;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "7";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "7";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Main.client_info[7, 1] == null)
            {
                if (exist_sits == 0)
                {
                    DialogResult dr = MessageBox.Show("8번 좌석을 선택하시겠습니까?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("좌석이 선택되었습니다.");
                        button8.BackColor = Color.Red;
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Items.Add("8");
                        }
                        // 
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "8";
                        }
                        // 좌석을 예약하면 exist_sits를 1로 변경
                        exist_sits = 1;
                    }
                    else
                    {
                        button8.BackColor = SystemColors.Control;
                        MessageBox.Show("다시 선택하세요.");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("지정된 좌석이 있습니다. 변경하시겠습니까? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        button1.BackColor = SystemColors.Control;
                        button2.BackColor = SystemColors.Control;
                        button3.BackColor = SystemColors.Control;
                        button4.BackColor = SystemColors.Control;
                        button5.BackColor = SystemColors.Control;
                        button6.BackColor = SystemColors.Control;
                        button7.BackColor = SystemColors.Control;
                        button8.BackColor = Color.Red;
                        button9.BackColor = SystemColors.Control;
                        button10.BackColor = SystemColors.Control;
                        button11.BackColor = SystemColors.Control;
                        button12.BackColor = SystemColors.Control;
                        button13.BackColor = SystemColors.Control;
                        button14.BackColor = SystemColors.Control;
                        button15.BackColor = SystemColors.Control;
                        button16.BackColor = SystemColors.Control;
                        button17.BackColor = SystemColors.Control;
                        button18.BackColor = SystemColors.Control;
                        button19.BackColor = SystemColors.Control;
                        button20.BackColor = SystemColors.Control;
                        button21.BackColor = SystemColors.Control;
                        MessageBox.Show("좌석이 변경되었습니다.");
                        if (sits_num == 1)
                        {
                            update_form.sit_num.Show();
                            update_form.sit_num.Text = "8";
                        }
                        else
                        {
                            frm4.label2.Show();
                            frm4.label2.Text = "8";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("이미 다른 사용자가 예약한 자리입니다.");
            }

        }
    }
}
