namespace Serial_data
{
    partial class frmSerial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSerial));
            this.btnON = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.cboCOM = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStart = new System.Windows.Forms.ComboBox();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnON
            // 
            this.btnON.Enabled = false;
            this.btnON.Location = new System.Drawing.Point(18, 263);
            this.btnON.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(231, 47);
            this.btnON.TabIndex = 0;
            this.btnON.Text = "Read Weight";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Enabled = false;
            this.btnOFF.Location = new System.Drawing.Point(265, 263);
            this.btnOFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(231, 47);
            this.btnOFF.TabIndex = 1;
            this.btnOFF.Text = "Clear";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // cboCOM
            // 
            this.cboCOM.FormattingEnabled = true;
            this.cboCOM.Location = new System.Drawing.Point(18, 18);
            this.cboCOM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCOM.Name = "cboCOM";
            this.cboCOM.Size = new System.Drawing.Size(229, 28);
            this.cboCOM.TabIndex = 2;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(18, 65);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(231, 40);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(112, 178);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(384, 28);
            this.txtMessage.TabIndex = 4;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(18, 115);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(231, 40);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(478, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(14, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Weight";
            // 
            // cboStart
            // 
            this.cboStart.Enabled = false;
            this.cboStart.FormattingEnabled = true;
            this.cboStart.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboStart.Location = new System.Drawing.Point(166, 220);
            this.cboStart.Name = "cboStart";
            this.cboStart.Size = new System.Drawing.Size(42, 28);
            this.cboStart.TabIndex = 9;
            this.cboStart.Text = "0";
            // 
            // cboStop
            // 
            this.cboStop.Enabled = false;
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Items.AddRange(new object[] {
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.cboStop.Location = new System.Drawing.Point(358, 220);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(42, 28);
            this.cboStop.TabIndex = 10;
            this.cboStop.Text = "9";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Enabled = false;
            this.lblStart.Location = new System.Drawing.Point(88, 224);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(62, 20);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "start bit";
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Enabled = false;
            this.lblStop.Location = new System.Drawing.Point(261, 224);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(61, 20);
            this.lblStop.TabIndex = 12;
            this.lblStop.Text = "stop bit";
            // 
            // frmSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 368);
            this.ControlBox = false;
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.cboStop);
            this.Controls.Add(this.cboStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboCOM);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSerial";
            this.Text = "Weight Scale Data Reader (Green Hackers)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSerial_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSerial_FormClosed);
            this.Load += new System.EventHandler(this.frmSerial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.ComboBox cboCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStart;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblStop;
    }
}

