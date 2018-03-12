namespace WebBrowserContent
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.encryptDecryptBtn = new System.Windows.Forms.Button();
            this.stockQuoteBtn = new System.Windows.Forms.Button();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.grpEncryptDecrypt = new System.Windows.Forms.GroupBox();
            this.lblEncryptAns = new System.Windows.Forms.Label();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblDecryptAns = new System.Windows.Forms.Label();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStock = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtStockQuote = new System.Windows.Forms.RichTextBox();
            this.richAnswer = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.grpEncryptDecrypt.SuspendLayout();
            this.grpStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter URL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(925, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1024, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(1095, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 90);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1643, 907);
            this.webBrowser1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.stockQuoteBtn);
            this.panel1.Controls.Add(this.encryptDecryptBtn);
            this.panel1.Location = new System.Drawing.Point(15, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 41);
            this.panel1.TabIndex = 5;
            // 
            // encryptDecryptBtn
            // 
            this.encryptDecryptBtn.Location = new System.Drawing.Point(3, 2);
            this.encryptDecryptBtn.Name = "encryptDecryptBtn";
            this.encryptDecryptBtn.Size = new System.Drawing.Size(185, 36);
            this.encryptDecryptBtn.TabIndex = 0;
            this.encryptDecryptBtn.Text = "Encrypt/Decrypt Text";
            this.encryptDecryptBtn.UseVisualStyleBackColor = true;
            this.encryptDecryptBtn.Click += new System.EventHandler(this.encryptDecryptBtn_Click);
            // 
            // stockQuoteBtn
            // 
            this.stockQuoteBtn.Location = new System.Drawing.Point(224, 2);
            this.stockQuoteBtn.Name = "stockQuoteBtn";
            this.stockQuoteBtn.Size = new System.Drawing.Size(198, 35);
            this.stockQuoteBtn.TabIndex = 1;
            this.stockQuoteBtn.Text = "Stock Quote";
            this.stockQuoteBtn.UseVisualStyleBackColor = true;
            this.stockQuoteBtn.Click += new System.EventHandler(this.stockQuoteBtn_Click);
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrypt.Location = new System.Drawing.Point(9, 61);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(138, 18);
            this.lblEncrypt.TabIndex = 7;
            this.lblEncrypt.Text = "Type text to Encrypt";
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(163, 61);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(192, 22);
            this.txtEncrypt.TabIndex = 8;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(384, 57);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(84, 30);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // grpEncryptDecrypt
            // 
            this.grpEncryptDecrypt.Controls.Add(this.richAnswer);
            this.grpEncryptDecrypt.Controls.Add(this.lblDecryptAns);
            this.grpEncryptDecrypt.Controls.Add(this.btnDecrypt);
            this.grpEncryptDecrypt.Controls.Add(this.txtDecrypt);
            this.grpEncryptDecrypt.Controls.Add(this.lblDecrypt);
            this.grpEncryptDecrypt.Controls.Add(this.lblEncryptAns);
            this.grpEncryptDecrypt.Controls.Add(this.btnEncrypt);
            this.grpEncryptDecrypt.Controls.Add(this.lblEncrypt);
            this.grpEncryptDecrypt.Controls.Add(this.txtEncrypt);
            this.grpEncryptDecrypt.Location = new System.Drawing.Point(18, 107);
            this.grpEncryptDecrypt.Name = "grpEncryptDecrypt";
            this.grpEncryptDecrypt.Size = new System.Drawing.Size(1098, 208);
            this.grpEncryptDecrypt.TabIndex = 10;
            this.grpEncryptDecrypt.TabStop = false;
            this.grpEncryptDecrypt.Text = "Encryption and Decryption Service";
            // 
            // lblEncryptAns
            // 
            this.lblEncryptAns.AutoSize = true;
            this.lblEncryptAns.Location = new System.Drawing.Point(497, 65);
            this.lblEncryptAns.Name = "lblEncryptAns";
            this.lblEncryptAns.Size = new System.Drawing.Size(0, 17);
            this.lblEncryptAns.TabIndex = 10;
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrypt.Location = new System.Drawing.Point(9, 136);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(139, 18);
            this.lblDecrypt.TabIndex = 11;
            this.lblDecrypt.Text = "Type text to Decrypt";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(163, 136);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(192, 22);
            this.txtDecrypt.TabIndex = 12;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(384, 131);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(84, 30);
            this.btnDecrypt.TabIndex = 13;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblDecryptAns
            // 
            this.lblDecryptAns.AutoSize = true;
            this.lblDecryptAns.Location = new System.Drawing.Point(500, 143);
            this.lblDecryptAns.Name = "lblDecryptAns";
            this.lblDecryptAns.Size = new System.Drawing.Size(0, 17);
            this.lblDecryptAns.TabIndex = 14;
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.txtStockQuote);
            this.grpStock.Controls.Add(this.label2);
            this.grpStock.Controls.Add(this.label4);
            this.grpStock.Controls.Add(this.btnStock);
            this.grpStock.Controls.Add(this.lblStock);
            this.grpStock.Controls.Add(this.txtStock);
            this.grpStock.Location = new System.Drawing.Point(18, 128);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(722, 208);
            this.grpStock.TabIndex = 15;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Get Stock Quotes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 10;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(12, 136);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(84, 30);
            this.btnStock.TabIndex = 9;
            this.btnStock.Text = "Get Quote";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(9, 61);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(212, 18);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Enter Stock Name to get quote";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(12, 98);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(192, 22);
            this.txtStock.TabIndex = 8;
            // 
            // txtStockQuote
            // 
            this.txtStockQuote.Location = new System.Drawing.Point(319, 21);
            this.txtStockQuote.Name = "txtStockQuote";
            this.txtStockQuote.Size = new System.Drawing.Size(284, 181);
            this.txtStockQuote.TabIndex = 15;
            this.txtStockQuote.Text = "";
            // 
            // richAnswer
            // 
            this.richAnswer.Location = new System.Drawing.Point(504, 57);
            this.richAnswer.Name = "richAnswer";
            this.richAnswer.Size = new System.Drawing.Size(356, 104);
            this.richAnswer.TabIndex = 15;
            this.richAnswer.Text = "";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1369, 777);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.grpEncryptDecrypt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.grpEncryptDecrypt.ResumeLayout(false);
            this.grpEncryptDecrypt.PerformLayout();
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stockQuoteBtn;
        private System.Windows.Forms.Button encryptDecryptBtn;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox grpEncryptDecrypt;
        private System.Windows.Forms.Label lblDecryptAns;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.Label lblEncryptAns;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.RichTextBox txtStockQuote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.RichTextBox richAnswer;
    }
}

