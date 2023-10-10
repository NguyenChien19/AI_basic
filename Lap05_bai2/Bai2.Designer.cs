namespace Lap05_bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textHoTen = new TextBox();
            maskedTextDienThoaiDiDong = new MaskedTextBox();
            maskedTextNgaySinh = new MaskedTextBox();
            maskedTextDienThoaiBan = new MaskedTextBox();
            textDiaChi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ tên khách hàng: ";
            // 
            // textHoTen
            // 
            textHoTen.Location = new Point(145, 52);
            textHoTen.Name = "textHoTen";
            textHoTen.Size = new Size(198, 23);
            textHoTen.TabIndex = 1;
            textHoTen.TextChanged += textHoTen_TextChanged;
            // 
            // maskedTextDienThoaiDiDong
            // 
            maskedTextDienThoaiDiDong.Location = new Point(145, 227);
            maskedTextDienThoaiDiDong.Mask = "(999) 0000000";
            maskedTextDienThoaiDiDong.Name = "maskedTextDienThoaiDiDong";
            maskedTextDienThoaiDiDong.Size = new Size(144, 23);
            maskedTextDienThoaiDiDong.TabIndex = 2;
            // 
            // maskedTextNgaySinh
            // 
            maskedTextNgaySinh.Location = new Point(145, 149);
            maskedTextNgaySinh.Mask = "00/00/0000";
            maskedTextNgaySinh.Name = "maskedTextNgaySinh";
            maskedTextNgaySinh.Size = new Size(144, 23);
            maskedTextNgaySinh.TabIndex = 3;
            // 
            // maskedTextDienThoaiBan
            // 
            maskedTextDienThoaiBan.Location = new Point(145, 186);
            maskedTextDienThoaiBan.Mask = "00000-000-000";
            maskedTextDienThoaiBan.Name = "maskedTextDienThoaiBan";
            maskedTextDienThoaiBan.Size = new Size(144, 23);
            maskedTextDienThoaiBan.TabIndex = 4;
            // 
            // textDiaChi
            // 
            textDiaChi.Location = new Point(145, 100);
            textDiaChi.Name = "textDiaChi";
            textDiaChi.Size = new Size(198, 23);
            textDiaChi.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 6;
            label2.Text = "Địa chị khách hàng: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Ngày sinh: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 8;
            label4.Text = "Điện thoại bàn: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 230);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 9;
            label5.Text = "Điện thoại di động: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 274);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 10;
            textBox3.Text = "Xuất thông tin";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 309);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textDiaChi);
            Controls.Add(maskedTextDienThoaiBan);
            Controls.Add(maskedTextNgaySinh);
            Controls.Add(maskedTextDienThoaiDiDong);
            Controls.Add(textHoTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textHoTen;
        private MaskedTextBox maskedTextDienThoaiDiDong;
        private MaskedTextBox maskedTextNgaySinh;
        private MaskedTextBox maskedTextDienThoaiBan;
        private TextBox textDiaChi;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
    }
}