namespace WindowsFormsApp1
{
    partial class Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.payment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.carnum = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeuse = new System.Windows.Forms.Label();
            this.sit_num = new System.Windows.Forms.ComboBox();
            this.carimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carimage)).BeginInit();
            this.SuspendLayout();
            // 
            // payment
            // 
            this.payment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.payment.Font = new System.Drawing.Font("12롯데마트드림Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.payment.Location = new System.Drawing.Point(517, 113);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(75, 61);
            this.payment.TabIndex = 24;
            this.payment.Text = "결제";
            this.payment.UseVisualStyleBackColor = true;
            this.payment.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(108, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "좌석번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(117, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "연락처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(108, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "차량번호";
            // 
            // exit
            // 
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exit.Font = new System.Drawing.Font("12롯데마트드림Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit.Location = new System.Drawing.Point(517, 20);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 17;
            this.exit.Text = "나가기";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 도현", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "관리자 화면";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("12롯데마트드림Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(517, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(312, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "결제금액";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cost.Location = new System.Drawing.Point(417, 136);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(32, 16);
            this.cost.TabIndex = 27;
            this.cost.Text = "없음";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(465, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "원";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(415, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 16);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "쿠폰 적용";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // carnum
            // 
            this.carnum.AutoSize = true;
            this.carnum.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.carnum.Location = new System.Drawing.Point(202, 104);
            this.carnum.Name = "carnum";
            this.carnum.Size = new System.Drawing.Size(32, 16);
            this.carnum.TabIndex = 30;
            this.carnum.Text = "없음";
            // 
            // phonenum
            // 
            this.phonenum.AutoSize = true;
            this.phonenum.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phonenum.Location = new System.Drawing.Point(202, 141);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(32, 16);
            this.phonenum.TabIndex = 31;
            this.phonenum.Text = "없음";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(312, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "사용시간";
            // 
            // timeuse
            // 
            this.timeuse.AutoSize = true;
            this.timeuse.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeuse.Location = new System.Drawing.Point(411, 66);
            this.timeuse.Name = "timeuse";
            this.timeuse.Size = new System.Drawing.Size(32, 16);
            this.timeuse.TabIndex = 33;
            this.timeuse.Text = "없음";
            // 
            // sit_num
            // 
            this.sit_num.FormattingEnabled = true;
            this.sit_num.Location = new System.Drawing.Point(206, 66);
            this.sit_num.Name = "sit_num";
            this.sit_num.Size = new System.Drawing.Size(70, 20);
            this.sit_num.TabIndex = 34;
            this.sit_num.Text = "좌석선택";
            this.sit_num.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // carimage
            // 
            this.carimage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.carimage.Image = global::WindowsFormsApp1.Properties.Resources.noimage;
            this.carimage.Location = new System.Drawing.Point(12, 66);
            this.carimage.Name = "carimage";
            this.carimage.Size = new System.Drawing.Size(90, 96);
            this.carimage.TabIndex = 35;
            this.carimage.TabStop = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 187);
            this.Controls.Add(this.carimage);
            this.Controls.Add(this.sit_num);
            this.Controls.Add(this.timeuse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.carnum);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "수정";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Label carnum;
        public System.Windows.Forms.Label phonenum;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label timeuse;
        internal System.Windows.Forms.Label cost;
        public System.Windows.Forms.ComboBox sit_num;
        private System.Windows.Forms.PictureBox carimage;
    }
}