using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace HygDisplay
{
    
    public partial class Form_Display : Form
    {
       // private  short comport;   
    

       
        private StreamWriter OutputStream;


      
        delegate void SetTextCallback(string a, string b, string c, string d );
        SetTextCallback delegte1;
        // This method is passed in to the SetTextCallBack delegate
        // to set the Text property of textBox1.
        private void
        SetText1(string a, string b, string c, string d)
        {
            this.textBox2.Text = DateTime.Now.ToString() + " -- "+d;
        
            this.RH_NumericDisp.Text = b + " %";
            this.TempC_disp.Text = c + " °C";
            this.TempF_disp.Text = a + " °F";
    
        }

        public Form_Display()
        {

            delegte1 = new SetTextCallback(SetText1);
            InitializeComponent();


            btn_port.Text = "&Connect";
          
            // add in the available  com ports
            
            foreach (string s in SerialPort.GetPortNames())
            {
                this.comboBox1.Items.Add(s);
            }

            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("NO PORT");
                this.comboBox1.SelectedIndex = 0;
                btn_port.Enabled = false;
                comboBox1.Enabled = false;
            }
            else
            {
                try
                {
                    this.comboBox1.SelectedIndex = Properties.Settings.Default.comport;
                }
                catch
                {
                    this.comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void 
        Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
          
            if (OutputStream != null)
                 OutputStream.Close();
            Properties.Settings.Default.comport = (short) this.comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
        }



        private void    // gets triggert when 10 bytes are ready 
        serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            float t_degC, RH;
            string message;
            int n;
            string tmp;

            t_degC = RH = 0;       
            try
            {
                message = serialPort1.ReadLine();       // this should block forever since ReadTimeout is at -1 (infinite  block) 
              
            }
            catch       // catch all and ignore 
            {
               
                message = "No data from COM port, Timeout occured";
            }
    

            tmp = "RH=";
            if ((n = message.IndexOf("RH=")) > 0)
            {
                 tmp = message.Substring(n+3, 5);
                 RH = Convert.ToSingle(tmp);
            }

            tmp="TempHyg=";
            if ((n = message.IndexOf(tmp)) > 0)
            {
                tmp = message.Substring(n +tmp.Length, 5);
                t_degC = Convert.ToSingle(tmp);
            }

            float t_degF = t_degC * 9 / 5 + 32;
            RH_Meter.Value = (int)RH;
            string str1 = t_degF.ToString("f2");
            string str2 = RH.ToString("f2");
            string str3 = t_degC.ToString("f2");
           
            // It's on a different thread, so use Invoke.
            BeginInvoke(delegte1, new object[] { str1, str2, str3, message });

          
            if (OutputStream != null )
            {
                OutputStream.WriteLine(DateTime.Now.ToShortTimeString() + "," + str3 + "," + str2);
          
            }
           

        }
        
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            string s;
            if (this.comboBox1.SelectedItem != null)
            {
                s = this.comboBox1.SelectedItem.ToString();
               
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = s;
                    serialPort1.ReceivedBytesThreshold = 20;    // DataReceived event fires when 10 bytes are ready 
                    s = serialPort1.NewLine=Environment.NewLine;
                    
                    try 
                    { 
                        serialPort1.Open();
                   //     serialPort1.DiscardInBuffer();
                    }
                    catch 
                    {  }
                    
                    btn_port.Text = "&Disconnect";
                    this.BtnRecord.Enabled = true;
                }
                else
                {
                    try
                    {
                        serialPort1.Close();
                    }
                    catch  { s = "bad close";}

                    btn_port.Text = "&Connect";
                    this.BtnRecord.Enabled = false;
                               
                    RH_Meter.Value = 0;
                }
                             
            }
        }




  
 
        private void button1_Click(object sender, EventArgs e)
        {
            if (OutputStream == null)
            {

             
                // formulate a new file name from current time
                DateTime Now = DateTime.Now;
                int i = Now.Year - 2010;
                i += Now.DayOfYear;
                int t = Now.Hour * 60 + Now.Minute;
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mydocpath += @"\Hygro_" + i.ToString() + "-" + t.ToString() + ".csv";

                // Create a file to write or overwrite to.
                OutputStream = File.CreateText(mydocpath);
                OutputStream.WriteLine(@"Time,TempC,RH%,");
         
                this.BtnRecord.Text = "STOP";
                this.BtnRecord.ForeColor = System.Drawing.Color.Black;
                this.BtnRecord.Image = global::HygDisplay.Properties.Resources.rgrn_btn;
               
               
            }
            else
            {
              
   

                OutputStream.Close();
                OutputStream.Dispose();
                OutputStream = null;
                this.BtnRecord.Text = "REC";
                this.BtnRecord.ForeColor = System.Drawing.Color.White;
                this.BtnRecord.Image = global::HygDisplay.Properties.Resources.red_btn;
                
            }
            
        }

        
       
   

    }
}
