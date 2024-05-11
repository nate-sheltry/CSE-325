namespace MegaDesk_Dunham
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drawersInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shippingBtn1 = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.shippingBtn2 = new System.Windows.Forms.RadioButton();
            this.shippingBtn3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.getQuoteBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(618, 388);
            this.backBtn.Name = "backBtn";
            this.backBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.backBtn.Size = new System.Drawing.Size(170, 50);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "&Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Depth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drawersInput
            // 
            this.drawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersInput.Location = new System.Drawing.Point(584, 124);
            this.drawersInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(120, 24);
            this.drawersInput.TabIndex = 12;
            this.drawersInput.Validating += new System.ComponentModel.CancelEventHandler(this.drawersInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Drawers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(380, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Surface Material";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shippingBtn1
            // 
            this.shippingBtn1.AutoSize = true;
            this.shippingBtn1.ContextMenuStrip = this.contextMenuStrip1;
            this.shippingBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingBtn1.Location = new System.Drawing.Point(302, 268);
            this.shippingBtn1.Name = "shippingBtn1";
            this.shippingBtn1.Size = new System.Drawing.Size(72, 22);
            this.shippingBtn1.TabIndex = 15;
            this.shippingBtn1.TabStop = true;
            this.shippingBtn1.Text = "3 Days";
            this.shippingBtn1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // shippingBtn2
            // 
            this.shippingBtn2.AutoSize = true;
            this.shippingBtn2.ContextMenuStrip = this.contextMenuStrip1;
            this.shippingBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingBtn2.Location = new System.Drawing.Point(380, 268);
            this.shippingBtn2.Name = "shippingBtn2";
            this.shippingBtn2.Size = new System.Drawing.Size(72, 22);
            this.shippingBtn2.TabIndex = 16;
            this.shippingBtn2.TabStop = true;
            this.shippingBtn2.Text = "5 Days";
            this.shippingBtn2.UseVisualStyleBackColor = true;
            // 
            // shippingBtn3
            // 
            this.shippingBtn3.AutoSize = true;
            this.shippingBtn3.ContextMenuStrip = this.contextMenuStrip1;
            this.shippingBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingBtn3.Location = new System.Drawing.Point(458, 268);
            this.shippingBtn3.Name = "shippingBtn3";
            this.shippingBtn3.Size = new System.Drawing.Size(72, 22);
            this.shippingBtn3.TabIndex = 17;
            this.shippingBtn3.TabStop = true;
            this.shippingBtn3.Text = "7 Days";
            this.shippingBtn3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rush Shipping";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerNameInput
            // 
            this.customerNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameInput.Location = new System.Drawing.Point(280, 32);
            this.customerNameInput.MaxLength = 50;
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(324, 24);
            this.customerNameInput.TabIndex = 20;
            this.customerNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.customerNameInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.Location = new System.Drawing.Point(178, 123);
            this.widthInput.MaxLength = 2;
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(120, 24);
            this.widthInput.TabIndex = 22;
            this.widthInput.Text = "24";
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthInput.Location = new System.Drawing.Point(380, 123);
            this.depthInput.MaxLength = 2;
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(120, 24);
            this.depthInput.TabIndex = 23;
            this.depthInput.Text = "12";
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.depthInput_Validating);
            // 
            // getQuoteBtn
            // 
            this.getQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteBtn.Location = new System.Drawing.Point(12, 388);
            this.getQuoteBtn.Name = "getQuoteBtn";
            this.getQuoteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.getQuoteBtn.Size = new System.Drawing.Size(170, 50);
            this.getQuoteBtn.TabIndex = 24;
            this.getQuoteBtn.Text = "&Get Quote";
            this.getQuoteBtn.UseVisualStyleBackColor = true;
            this.getQuoteBtn.Click += new System.EventHandler(this.getQuoteBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 77);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Desk Info";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.getQuoteBtn);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shippingBtn3);
            this.Controls.Add(this.shippingBtn2);
            this.Controls.Add(this.shippingBtn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown drawersInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton shippingBtn1;
        private System.Windows.Forms.RadioButton shippingBtn2;
        private System.Windows.Forms.RadioButton shippingBtn3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Button getQuoteBtn;
        private System.Windows.Forms.Label label7;
    }
}

