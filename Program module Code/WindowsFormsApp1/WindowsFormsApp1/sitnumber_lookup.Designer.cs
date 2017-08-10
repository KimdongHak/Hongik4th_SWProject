namespace WindowsFormsApp1
{
    partial class Sitnumber_lookup
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 연성", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "좌석번호 :";
            // 
            // inputbox
            // 
            this.inputbox.Font = new System.Drawing.Font("배달의민족 연성", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputbox.Location = new System.Drawing.Point(184, 39);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(75, 25);
            this.inputbox.TabIndex = 6;
            this.inputbox.Text = "조회";
            this.inputbox.UseVisualStyleBackColor = true;
            this.inputbox.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 21);
            this.textBox1.TabIndex = 5;
            // 
            // Sitnumber_lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.textBox1);
            this.Name = "Sitnumber_lookup";
            this.Text = "sitnumber_lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inputbox;
        private System.Windows.Forms.TextBox textBox1;
    }
}