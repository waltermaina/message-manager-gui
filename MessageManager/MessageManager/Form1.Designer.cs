namespace MessageManager
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
            this.components = new System.ComponentModel.Container();
            this.lblRow1 = new System.Windows.Forms.Label();
            this.txtRow1 = new System.Windows.Forms.TextBox();
            this.txtRow2 = new System.Windows.Forms.TextBox();
            this.lblRow2 = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnClearLCD = new System.Windows.Forms.Button();
            this.btnLEDOff = new System.Windows.Forms.Button();
            this.btnLEDFlash = new System.Windows.Forms.Button();
            this.btnBuzzerOff = new System.Windows.Forms.Button();
            this.btnBuzzerOn = new System.Windows.Forms.Button();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.lblDeviceLog = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbDeviceLog = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRow1
            // 
            this.lblRow1.AutoSize = true;
            this.lblRow1.Location = new System.Drawing.Point(85, 49);
            this.lblRow1.Name = "lblRow1";
            this.lblRow1.Size = new System.Drawing.Size(108, 13);
            this.lblRow1.TabIndex = 0;
            this.lblRow1.Text = "LCD Row 1 Message";
            // 
            // txtRow1
            // 
            this.txtRow1.BackColor = System.Drawing.Color.Yellow;
            this.txtRow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRow1.Location = new System.Drawing.Point(199, 37);
            this.txtRow1.MaxLength = 16;
            this.txtRow1.Name = "txtRow1";
            this.txtRow1.Size = new System.Drawing.Size(229, 31);
            this.txtRow1.TabIndex = 1;
            // 
            // txtRow2
            // 
            this.txtRow2.BackColor = System.Drawing.Color.Yellow;
            this.txtRow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRow2.Location = new System.Drawing.Point(199, 74);
            this.txtRow2.MaxLength = 16;
            this.txtRow2.Name = "txtRow2";
            this.txtRow2.Size = new System.Drawing.Size(229, 31);
            this.txtRow2.TabIndex = 3;
            // 
            // lblRow2
            // 
            this.lblRow2.AutoSize = true;
            this.lblRow2.Location = new System.Drawing.Point(85, 86);
            this.lblRow2.Name = "lblRow2";
            this.lblRow2.Size = new System.Drawing.Size(108, 13);
            this.lblRow2.TabIndex = 2;
            this.lblRow2.Text = "LCD Row 2 Message";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(15, 132);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(147, 27);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "SEND MESSAGE";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnClearLCD
            // 
            this.btnClearLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLCD.Location = new System.Drawing.Point(168, 132);
            this.btnClearLCD.Name = "btnClearLCD";
            this.btnClearLCD.Size = new System.Drawing.Size(124, 27);
            this.btnClearLCD.TabIndex = 5;
            this.btnClearLCD.Text = "CLEAR LCD";
            this.btnClearLCD.UseVisualStyleBackColor = true;
            this.btnClearLCD.Click += new System.EventHandler(this.btnClearLCD_Click);
            // 
            // btnLEDOff
            // 
            this.btnLEDOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLEDOff.Location = new System.Drawing.Point(165, 183);
            this.btnLEDOff.Name = "btnLEDOff";
            this.btnLEDOff.Size = new System.Drawing.Size(124, 27);
            this.btnLEDOff.TabIndex = 7;
            this.btnLEDOff.Text = "LED OFF";
            this.btnLEDOff.UseVisualStyleBackColor = true;
            this.btnLEDOff.Click += new System.EventHandler(this.btnLEDOff_Click);
            // 
            // btnLEDFlash
            // 
            this.btnLEDFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLEDFlash.Location = new System.Drawing.Point(15, 183);
            this.btnLEDFlash.Name = "btnLEDFlash";
            this.btnLEDFlash.Size = new System.Drawing.Size(147, 27);
            this.btnLEDFlash.TabIndex = 6;
            this.btnLEDFlash.Text = "LED FLASH";
            this.btnLEDFlash.UseVisualStyleBackColor = true;
            this.btnLEDFlash.Click += new System.EventHandler(this.btnLEDFlash_Click);
            // 
            // btnBuzzerOff
            // 
            this.btnBuzzerOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuzzerOff.Location = new System.Drawing.Point(165, 232);
            this.btnBuzzerOff.Name = "btnBuzzerOff";
            this.btnBuzzerOff.Size = new System.Drawing.Size(124, 27);
            this.btnBuzzerOff.TabIndex = 9;
            this.btnBuzzerOff.Text = "BUZZER OFF";
            this.btnBuzzerOff.UseVisualStyleBackColor = true;
            this.btnBuzzerOff.Click += new System.EventHandler(this.btnBuzzerOff_Click);
            // 
            // btnBuzzerOn
            // 
            this.btnBuzzerOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuzzerOn.Location = new System.Drawing.Point(12, 232);
            this.btnBuzzerOn.Name = "btnBuzzerOn";
            this.btnBuzzerOn.Size = new System.Drawing.Size(147, 27);
            this.btnBuzzerOn.TabIndex = 8;
            this.btnBuzzerOn.Text = "BUZZER ON";
            this.btnBuzzerOn.UseVisualStyleBackColor = true;
            this.btnBuzzerOn.Click += new System.EventHandler(this.btnBuzzerOn_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLog.Location = new System.Drawing.Point(295, 232);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(169, 27);
            this.btnSaveLog.TabIndex = 10;
            this.btnSaveLog.Text = "SAVE DEVICE LOG";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // lblDeviceLog
            // 
            this.lblDeviceLog.AutoSize = true;
            this.lblDeviceLog.Location = new System.Drawing.Point(12, 281);
            this.lblDeviceLog.Name = "lblDeviceLog";
            this.lblDeviceLog.Size = new System.Drawing.Size(71, 13);
            this.lblDeviceLog.TabIndex = 11;
            this.lblDeviceLog.Text = "DEVICE LOG";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.openPortToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openPortToolStripMenuItem
            // 
            this.openPortToolStripMenuItem.Name = "openPortToolStripMenuItem";
            this.openPortToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.openPortToolStripMenuItem.Text = "Open Port";
            this.openPortToolStripMenuItem.Click += new System.EventHandler(this.openPortToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.clearToolStripMenuItem.Text = "Clear Device Log";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // rtbDeviceLog
            // 
            this.rtbDeviceLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDeviceLog.Location = new System.Drawing.Point(12, 297);
            this.rtbDeviceLog.Name = "rtbDeviceLog";
            this.rtbDeviceLog.Size = new System.Drawing.Size(572, 191);
            this.rtbDeviceLog.TabIndex = 14;
            this.rtbDeviceLog.Text = "";
            this.rtbDeviceLog.TextChanged += new System.EventHandler(this.rtbDeviceLog_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(584, 500);
            this.Controls.Add(this.rtbDeviceLog);
            this.Controls.Add(this.lblDeviceLog);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.btnBuzzerOff);
            this.Controls.Add(this.btnBuzzerOn);
            this.Controls.Add(this.btnLEDOff);
            this.Controls.Add(this.btnLEDFlash);
            this.Controls.Add(this.btnClearLCD);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtRow2);
            this.Controls.Add(this.lblRow2);
            this.Controls.Add(this.txtRow1);
            this.Controls.Add(this.lblRow1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Message Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRow1;
        private System.Windows.Forms.TextBox txtRow1;
        private System.Windows.Forms.TextBox txtRow2;
        private System.Windows.Forms.Label lblRow2;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnClearLCD;
        private System.Windows.Forms.Button btnLEDOff;
        private System.Windows.Forms.Button btnLEDFlash;
        private System.Windows.Forms.Button btnBuzzerOff;
        private System.Windows.Forms.Button btnBuzzerOn;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.Label lblDeviceLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox rtbDeviceLog;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SaveFileDialog saveFD;
    }
}

