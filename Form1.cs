
/* 
 
Desktop Application for AVR MCU

Edward Phiri jr <https://www.linkedin.com/in/edward-phiri-jr-479673216/>


 Date issued 03 October 2022
 by Edward Phiri jr

*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Robot_Control_1
{
    public partial class Robto_C : Form
    {
        public Robto_C()
        {
           
            InitializeComponent();
            getAvailablePorts();
        }
        void getAvailablePorts()
        {
            String[] Ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(Ports);


        }
        private void button8_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("K");
            textBox1.AppendText("   Down is pressed\r\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("I");
            textBox1.AppendText("   Up is pressed\r\n");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("C");
            textBox1.AppendText("   RD is Pressed\r\n");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SerialPort1.Open();
            textBox1.AppendText("   >>Device Started\r\n");
            MessageBox.Show("EO RC has successfully open press OK to intialize");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("A");
            textBox1.AppendText("   ON!\r\n");
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort1.PortName = comboBox1.Text;
            SerialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SerialPort1.Close();
            textBox1.AppendText("   >>Device Close\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("a");
            textBox1.AppendText("   OFF!\r\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("B");
            textBox1.AppendText("   ON!\r\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("b");
            textBox1.AppendText("   OFF!\r\n");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("D");
            textBox1.AppendText("   RT is pressed\r\n");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("d");
            textBox1.AppendText("   OK is pressed\r\n");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("G");
            textBox1.AppendText("  A is pressed\r\n");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("H");
            textBox1.AppendText("  G is pressed\r\n");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("I");
            textBox1.AppendText("  Y is pressed\r\n");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("M");
            textBox1.AppendText("  Z is pressed\r\n");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("J");
            textBox1.AppendText("   Forward is pressed\r\n");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("L");
            textBox1.AppendText("   Back is pressed\r\n");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("E");
            textBox1.AppendText("   RJ is Pressed\r\n");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SerialPort1.Write("F");
            textBox1.AppendText("   REO is Pressed\r\n");
        }
    }
}
