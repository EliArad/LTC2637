namespace LTC2637TesterApp
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
            this.tbLSData = new System.Windows.Forms.TextBox();
            this.tbMSData = new System.Windows.Forms.TextBox();
            this.tbSlaveAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.cbDac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLSData
            // 
            this.tbLSData.Location = new System.Drawing.Point(96, 112);
            this.tbLSData.Name = "tbLSData";
            this.tbLSData.Size = new System.Drawing.Size(41, 20);
            this.tbLSData.TabIndex = 23;
            // 
            // tbMSData
            // 
            this.tbMSData.Location = new System.Drawing.Point(96, 86);
            this.tbMSData.Name = "tbMSData";
            this.tbMSData.Size = new System.Drawing.Size(41, 20);
            this.tbMSData.TabIndex = 22;
            // 
            // tbSlaveAddress
            // 
            this.tbSlaveAddress.Location = new System.Drawing.Point(96, 6);
            this.tbSlaveAddress.Name = "tbSlaveAddress";
            this.tbSlaveAddress.Size = new System.Drawing.Size(100, 20);
            this.tbSlaveAddress.TabIndex = 19;
            this.tbSlaveAddress.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Slave Address:";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(15, 138);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(202, 23);
            this.btnWrite.TabIndex = 16;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // cbCommand
            // 
            this.cbCommand.FormattingEnabled = true;
            this.cbCommand.Location = new System.Drawing.Point(96, 32);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(121, 21);
            this.cbCommand.TabIndex = 24;
            // 
            // cbDac
            // 
            this.cbDac.FormattingEnabled = true;
            this.cbDac.Location = new System.Drawing.Point(96, 59);
            this.cbDac.Name = "cbDac";
            this.cbDac.Size = new System.Drawing.Size(121, 21);
            this.cbDac.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "DAC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "MS Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "LS Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDac);
            this.Controls.Add(this.cbCommand);
            this.Controls.Add(this.tbLSData);
            this.Controls.Add(this.tbMSData);
            this.Controls.Add(this.tbSlaveAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLSData;
        private System.Windows.Forms.TextBox tbMSData;
        private System.Windows.Forms.TextBox tbSlaveAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ComboBox cbCommand;
        private System.Windows.Forms.ComboBox cbDac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

