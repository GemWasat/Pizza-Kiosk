namespace WinFormsApp1
{
    partial class Form4
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
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rd_nonprint = new System.Windows.Forms.RadioButton();
            rd_print = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rd_point = new System.Windows.Forms.RadioButton();
            rd_card = new System.Windows.Forms.RadioButton();
            listBox1 = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(450, 502);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(241, 66);
            button1.TabIndex = 0;
            button1.Text = "결제";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(143, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(468, 50);
            label1.TabIndex = 2;
            label1.Text = "결제 수단을 선택해 주세요";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd_nonprint);
            groupBox1.Controls.Add(rd_print);
            groupBox1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(398, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(344, 152);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "영수증 출력";
            // 
            // rd_nonprint
            // 
            rd_nonprint.AutoSize = true;
            rd_nonprint.Location = new System.Drawing.Point(221, 67);
            rd_nonprint.Name = "rd_nonprint";
            rd_nonprint.Size = new System.Drawing.Size(94, 34);
            rd_nonprint.TabIndex = 1;
            rd_nonprint.TabStop = true;
            rd_nonprint.Text = "미출력";
            rd_nonprint.UseVisualStyleBackColor = true;
            // 
            // rd_print
            // 
            rd_print.AutoSize = true;
            rd_print.Location = new System.Drawing.Point(68, 67);
            rd_print.Name = "rd_print";
            rd_print.Size = new System.Drawing.Size(73, 34);
            rd_print.TabIndex = 0;
            rd_print.TabStop = true;
            rd_print.Text = "출력";
            rd_print.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rd_point);
            groupBox2.Controls.Add(rd_card);
            groupBox2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(398, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(344, 177);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "결제 방법";
            // 
            // rd_point
            // 
            rd_point.AutoSize = true;
            rd_point.Location = new System.Drawing.Point(221, 73);
            rd_point.Name = "rd_point";
            rd_point.Size = new System.Drawing.Size(94, 34);
            rd_point.TabIndex = 1;
            rd_point.TabStop = true;
            rd_point.Text = "포인트";
            rd_point.UseVisualStyleBackColor = true;
            // 
            // rd_card
            // 
            rd_card.AutoSize = true;
            rd_card.Location = new System.Drawing.Point(66, 73);
            rd_card.Name = "rd_card";
            rd_card.Size = new System.Drawing.Size(73, 34);
            rd_card.TabIndex = 0;
            rd_card.TabStop = true;
            rd_card.Text = "카드";
            rd_card.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(12, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(320, 439);
            listBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 108);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 6;
            label2.Text = "선택한 메뉴";
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(782, 632);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_nonprint;
        private System.Windows.Forms.RadioButton rd_print;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_point;
        private System.Windows.Forms.RadioButton rd_card;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}