namespace HygDisplay
{
    partial class Form_Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Display));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_port = new System.Windows.Forms.Button();
            this.RH_Meter = new Instruments.AnalogMeter();
            this.RH_NumericDisp = new System.Windows.Forms.TextBox();
            this.TempC_disp = new System.Windows.Forms.TextBox();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TempF_disp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.ReadTimeout = 2000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_port
            // 
            this.btn_port.Location = new System.Drawing.Point(180, 7);
            this.btn_port.Name = "btn_port";
            this.btn_port.Size = new System.Drawing.Size(74, 28);
            this.btn_port.TabIndex = 2;
            this.btn_port.UseVisualStyleBackColor = true;
            this.btn_port.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // RH_Meter
            // 
            this.RH_Meter.FrameColor = System.Drawing.Color.Black;
            this.RH_Meter.FramePadding = new System.Windows.Forms.Padding(5);
            this.RH_Meter.InternalPadding = new System.Windows.Forms.Padding(5);
            this.RH_Meter.Location = new System.Drawing.Point(76, 41);
            this.RH_Meter.MaxValue = 100F;
            this.RH_Meter.MinValue = 0F;
            this.RH_Meter.Name = "RH_Meter";
            this.RH_Meter.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RH_Meter.Size = new System.Drawing.Size(282, 154);
            this.RH_Meter.TabIndex = 14;
            this.RH_Meter.TabStop = false;
            this.RH_Meter.Text = "%RH";
            this.RH_Meter.TickLargeFrequency = 10F;
            this.RH_Meter.TickSmallFrequency = 2F;
            this.RH_Meter.TickStartAngle = 10F;
            this.RH_Meter.TickTinyFrequency = 0F;
            this.RH_Meter.TickTinySize = 1F;
            this.RH_Meter.Value = 0F;
            // 
            // RH_NumericDisp
            // 
            this.RH_NumericDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RH_NumericDisp.Location = new System.Drawing.Point(276, 205);
            this.RH_NumericDisp.Name = "RH_NumericDisp";
            this.RH_NumericDisp.Size = new System.Drawing.Size(82, 20);
            this.RH_NumericDisp.TabIndex = 15;
            this.RH_NumericDisp.TabStop = false;
            // 
            // TempC_disp
            // 
            this.TempC_disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempC_disp.Location = new System.Drawing.Point(76, 205);
            this.TempC_disp.Name = "TempC_disp";
            this.TempC_disp.Size = new System.Drawing.Size(82, 20);
            this.TempC_disp.TabIndex = 16;
            this.TempC_disp.TabStop = false;
            // 
            // BtnRecord
            // 
            this.BtnRecord.Enabled = false;
            this.BtnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecord.ForeColor = System.Drawing.Color.White;
            this.BtnRecord.Image = global::HygDisplay.Properties.Resources.red_btn;
            this.BtnRecord.Location = new System.Drawing.Point(276, 5);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(82, 28);
            this.BtnRecord.TabIndex = 28;
            this.BtnRecord.Text = "REC";
            this.BtnRecord.UseVisualStyleBackColor = true;
            this.BtnRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(505, 20);
            this.textBox2.TabIndex = 29;
            // 
            // TempF_disp
            // 
            this.TempF_disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempF_disp.Location = new System.Drawing.Point(180, 205);
            this.TempF_disp.Name = "TempF_disp";
            this.TempF_disp.Size = new System.Drawing.Size(82, 20);
            this.TempF_disp.TabIndex = 30;
            this.TempF_disp.TabStop = false;
            // 
            // Form_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 303);
            this.Controls.Add(this.TempF_disp);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnRecord);
            this.Controls.Add(this.TempC_disp);
            this.Controls.Add(this.RH_NumericDisp);
            this.Controls.Add(this.RH_Meter);
            this.Controls.Add(this.btn_port);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Display";
            this.Text = "Hygrometer display/recorder ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_port;
        private Instruments.AnalogMeter RH_Meter;
        private System.Windows.Forms.TextBox RH_NumericDisp;
        private System.Windows.Forms.TextBox TempC_disp;
        private System.Windows.Forms.Button BtnRecord;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TempF_disp;
    }
}

