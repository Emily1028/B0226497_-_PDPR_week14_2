
namespace B0226497_段昱如_PDPR_week14_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbARIVED = new System.Windows.Forms.RadioButton();
            this.rdbATM = new System.Windows.Forms.RadioButton();
            this.lblSHOW = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "B0226497_段昱如_PDPR_week14_2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(81, 116);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 48);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(254, 116);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(95, 48);
            this.btnEXIT.TabIndex = 2;
            this.btnEXIT.Text = "結束";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "產品：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "付款樣式：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "段昱如";
            // 
            // rdbARIVED
            // 
            this.rdbARIVED.AutoSize = true;
            this.rdbARIVED.Location = new System.Drawing.Point(81, 314);
            this.rdbARIVED.Name = "rdbARIVED";
            this.rdbARIVED.Size = new System.Drawing.Size(127, 28);
            this.rdbARIVED.TabIndex = 8;
            this.rdbARIVED.TabStop = true;
            this.rdbARIVED.Text = "貨到付款";
            this.rdbARIVED.UseVisualStyleBackColor = true;
            this.rdbARIVED.CheckedChanged += new System.EventHandler(this.rdbARIVED_CheckedChanged);
            // 
            // rdbATM
            // 
            this.rdbATM.AutoSize = true;
            this.rdbATM.Location = new System.Drawing.Point(81, 376);
            this.rdbATM.Name = "rdbATM";
            this.rdbATM.Size = new System.Drawing.Size(81, 28);
            this.rdbATM.TabIndex = 9;
            this.rdbATM.TabStop = true;
            this.rdbATM.Text = "ATM";
            this.rdbATM.UseVisualStyleBackColor = true;
            this.rdbATM.CheckedChanged += new System.EventHandler(this.rdbATM_CheckedChanged);
            // 
            // lblSHOW
            // 
            this.lblSHOW.AutoSize = true;
            this.lblSHOW.Location = new System.Drawing.Point(3, 0);
            this.lblSHOW.Name = "lblSHOW";
            this.lblSHOW.Size = new System.Drawing.Size(99, 24);
            this.lblSHOW.TabIndex = 10;
            this.lblSHOW.Text = "lblSHOW";
            this.lblSHOW.Click += new System.EventHandler(this.lblSHOW_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "XBox 360",
            "PSP",
            "PS 2",
            "Game Boy",
            "任天堂",
            "SEGA"});
            this.checkedListBox1.Location = new System.Drawing.Point(483, 129);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(236, 304);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblSHOW);
            this.panel1.Location = new System.Drawing.Point(81, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 203);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 690);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.rdbATM);
            this.Controls.Add(this.rdbARIVED);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "B0226497_段昱如_PDPR_week14_2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbARIVED;
        private System.Windows.Forms.RadioButton rdbATM;
        private System.Windows.Forms.Label lblSHOW;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

