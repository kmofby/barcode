namespace BarcodeSample1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdPrint = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictBarcode = new System.Windows.Forms.PictureBox();
            this.cmdMakeBarcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrint.Location = new System.Drawing.Point(498, 178);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(75, 23);
            this.cmdPrint.TabIndex = 13;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(133, 50);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(44, 20);
            this.txtWeight.TabIndex = 12;
            this.txtWeight.Text = "2";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(133, 22);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(436, 20);
            this.txtInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bar weight";
            // 
            // pictBarcode
            // 
            this.pictBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBarcode.Location = new System.Drawing.Point(45, 86);
            this.pictBarcode.Name = "pictBarcode";
            this.pictBarcode.Size = new System.Drawing.Size(528, 84);
            this.pictBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBarcode.TabIndex = 10;
            this.pictBarcode.TabStop = false;
            // 
            // cmdMakeBarcode
            // 
            this.cmdMakeBarcode.Location = new System.Drawing.Point(229, 50);
            this.cmdMakeBarcode.Name = "cmdMakeBarcode";
            this.cmdMakeBarcode.Size = new System.Drawing.Size(92, 23);
            this.cmdMakeBarcode.TabIndex = 9;
            this.cmdMakeBarcode.Text = "Make barcode";
            this.cmdMakeBarcode.Click += new System.EventHandler(this.cmdMakeBarcode_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Text to encode";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(498, 207);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Change doc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictBarcode);
            this.Controls.Add(this.cmdMakeBarcode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictBarcode;
        private System.Windows.Forms.Button cmdMakeBarcode;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
    }
}

