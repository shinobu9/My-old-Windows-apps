using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e) // textbox1
        {
            if (textBox1.Text == "00")
            {
                textBox1.Text = "0";
            }
        }
        
        //------------------------NUMBERS--------------------------------------------------------------

        private void button13_Click(object sender, EventArgs e) // клавиша 1
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button14_Click(object sender, EventArgs e) // клавиша 2
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button16_Click(object sender, EventArgs e) // клавиша 3
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button15_Click(object sender, EventArgs e) // клавиша 4
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button17_Click(object sender, EventArgs e) // клавиша 5
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button20_Click(object sender, EventArgs e) // клавиша 6
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button19_Click(object sender, EventArgs e) // клавиша 7
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button18_Click(object sender, EventArgs e) // клавиша 8
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button21_Click(object sender, EventArgs e) // клавиша 9
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button22_Click(object sender, EventArgs e) // клавиша 0
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button23_Click(object sender, EventArgs e) // клавиша запятая
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button34_Click(object sender, EventArgs e) // клавиша A
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "A";
            }
            else
            {
                textBox1.Text = textBox1.Text + "A";
            }
        }

        private void button35_Click(object sender, EventArgs e) // клавиша B
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "B";
            }
            else
            {
                textBox1.Text = textBox1.Text + "B";
            }
        }

        private void button36_Click(object sender, EventArgs e) // клавиша C
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "C";
            }
            else
            {
                textBox1.Text = textBox1.Text + "C";
            }
        }

        private void button38_Click(object sender, EventArgs e) // клавиша D
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "D";
            }
            else
            {
                textBox1.Text = textBox1.Text + "D";
            }
        }

        private void button37_Click(object sender, EventArgs e) // клавиша E
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "E";
            }
            else
            {
                textBox1.Text = textBox1.Text + "E";
            }
        }

        private void button39_Click(object sender, EventArgs e) // клавиша F
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "F";
            }
            else
            {
                textBox1.Text = textBox1.Text + "F";
            }
        }

        //---------------------KEYBOARD_NUMBERS-------------------------------------------------------------
       
        private void Form1_KeyDown(object sender, KeyEventArgs e) // ввод с клавиатуры через кейсы
        {   
            switch (e.KeyCode)
            {
                case Keys.F10:
                    Close();       // CLOSE
                break;

                case Keys.D1:
                button13_Click(sender, EventArgs.Empty);
                break;

                case Keys.D2:
                button14_Click(sender, EventArgs.Empty);
                break;

                case Keys.D3:
                button16_Click(sender, EventArgs.Empty);
                break;

                case Keys.D4:
                button15_Click(sender, EventArgs.Empty);
                break;

                case Keys.D5:
                button17_Click(sender, EventArgs.Empty);
                break;

                case Keys.D6:
                button20_Click(sender, EventArgs.Empty);
                break;

                case Keys.D7:
                button19_Click(sender, EventArgs.Empty);
                break;

                case Keys.D8:
                button18_Click(sender, EventArgs.Empty);
                break;

                case Keys.D9:
                button21_Click(sender, EventArgs.Empty);
                break;

                case Keys.D0:
                button22_Click(sender, EventArgs.Empty);
                break;

                case Keys.Enter:
                button1_Click(sender, EventArgs.Empty);
                break;

               
            }

        }

        //--------------------SPECIAL_BUTTONS---------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e) // ENTER
        {
            try
            {
                l = new Rinswind();
                textBox1.Text = l.enter(x, y, textBox1.Text);
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button24_Click(object sender, EventArgs e) // CE
        {
            textBox1.Text = "";
        }

        private void button25_Click(object sender, EventArgs e) // full_clean или C
        {
            try
            {
                y = string.Empty;
                x = 0;
                textBox1.Text = "";
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button26_Click(object sender, EventArgs e) // <--
        {
            try
            {
                string b = textBox1.Text;
                textBox1.Text = "";
                for (int x = 0; x < l.Nelength(b) - 1; x++)
                {
                    textBox1.Text = textBox1.Text + b[x];
                }
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) // sqrt
        {
            try
            {
                l = new Rinswind();
                textBox1.Text = l.sqrt(float.Parse(textBox1.Text));
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) // +/-
        {
            try
            {
                l = new Rinswind();
                textBox1.Text = l.negative(textBox1.Text);
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e) // 1/x
        {
            try
            {
                l = new Rinswind();
                textBox1.Text = l.opposite(textBox1.Text);
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e) // %
        {
            try
            {
                l = new Rinswind();
                textBox1.Text = l.procent(textBox1.Text, x);
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        //----------------------ORDINARY_BUTTONS------------------------------------------------------------

        private void button7_Click(object sender, EventArgs e) //  +
        {
            y = "+";
            x = float.Parse(textBox1.Text);
            textBox1.Text = "";
        }
     
        private void button12_Click(object sender, EventArgs e) // /
        {
            y = "/";
            x = float.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) // -
        {
            y = "-";
            x = float.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e) // *
        {
            y = "*";
            x = float.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        //----------------------------MEMENTO---------------------------------------------------------------

        private void button27_Click(object sender, EventArgs e) // M+
        {
            m = float.Parse(textBox1.Text);
            label2.Visible = true;
        }

        private void button30_Click(object sender, EventArgs e) // M-
        {
            m = m - float.Parse(textBox1.Text);
        }

        private void button29_Click(object sender, EventArgs e) // MR
        {
            textBox1.Text = m.ToString();
        }

        private void button28_Click(object sender, EventArgs e) //MC
        {
            m = 0;
            label2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e) // MS
        {
            m = float.Parse(textBox1.Text);
            label2.Visible = true;
        }

       //-----------------------------ENGINEER---------------------------------------------------------------

        /// <summary>
        /// jgrkgtjgbkrtjkhj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) // x^2
        {
            try
            {
                l = new Rinswind();
                textBox1.Text = l.sqr(textBox1.Text);
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button32_Click(object sender, EventArgs e) // x^y
        {
            try
            {
                x = float.Parse(textBox1.Text);
                textBox1.Text = "";
                y = "x^y";
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }


        private void button11_Click(object sender, EventArgs e) // n!
        {
            try
            {
                l = new Rinswind();
                textBox1.Text = l.factorial(textBox1.Text);
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button33_Click(object sender, EventArgs e) // 10^x
        {
            try
            {
                l = new Rinswind();
                textBox1.Text = l.ten(textBox1.Text);
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button31_Click(object sender, EventArgs e) // y_sqrt
        {
            try
            {
                y = "y_sqrt";
                x = float.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        //---------------------------ICH BIN PROGRAMMER!-------------------------------------------------------------

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // dec
        {
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button23.Enabled = true;
               
                button34.Enabled = false;
                button35.Enabled = false;
                button36.Enabled = false;
                button37.Enabled = false;
                button38.Enabled = false;
                button39.Enabled = false;

                if (textBox1.Text == "")
                { }
                else
                {
                    switch (hal)
                    {
                        case "2":
                            l = new Rinswind();
                            textBox1.Text = l.conv2to10(textBox1.Text);
                            break;
                        case "8":
                            l = new Rinswind();
                            textBox1.Text = l.conv8to10(textBox1.Text);
                            break;
                        case "16":
                            l = new Rinswind();
                            textBox1.Text = l.conv16to10(textBox1.Text);
                            break;
                    }
                }

                hal = "10";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // oct
        {
            
            button14.Enabled = true; // 2
            button15.Enabled = true; // 4
            button16.Enabled = true; // 3
            button17.Enabled = true; // 5
            button18.Enabled = false; // 8
            button19.Enabled = true; // 7
            button20.Enabled = true; // 6
            button21.Enabled = false; // 9
            button23.Enabled = false; // ,
           
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button39.Enabled = false;

            if (textBox1.Text == "")
            { }
            else
            {
                switch (hal)
                {
                    case "2":
                        l = new Rinswind();
                        textBox1.Text = l.conv2to8(textBox1.Text);
                        break;
                    case "10":
                        l = new Rinswind();
                        textBox1.Text = l.conv10to8(textBox1.Text);
                        break;
                    case "16":
                        l = new Rinswind();
                        textBox1.Text = l.conv16to8(textBox1.Text);
                        break;
                }
            }
                hal = "8";
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) // hex
        {
           
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button23.Enabled = false;

            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;

            if (textBox1.Text == "")
            { }
            else
            {
                switch (hal)
                {
                    case "2":
                        l = new Rinswind();
                        textBox1.Text = l.conv2to16(textBox1.Text);
                        break;
                    case "8":
                        l = new Rinswind();
                        textBox1.Text = l.conv8to16(textBox1.Text);
                        break;
                    case "10":
                        l = new Rinswind();
                        textBox1.Text = l.conv10to16(textBox1.Text);
                        break;
                }
            }
                
                hal = "16";
            
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e) // bin
        {
            
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button23.Enabled = false;
            
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button39.Enabled = false;
            if (textBox1.Text == "")
            { }
            else
            {
                switch (hal)
                {
                    case "10":
                        l = new Rinswind();
                        textBox1.Text = l.conv10to2(textBox1.Text);
                        break;
                    case "8":
                        l = new Rinswind();
                        textBox1.Text = l.conv8to2(textBox1.Text);
                        break;
                    case "16":
                        l = new Rinswind();
                        textBox1.Text = l.conv16to2(textBox1.Text);
                        break;
                }
            }
            
            hal = "2";
        }

      
        //--------------------------------------------------------------------------------------------------



    } // скобка, которую нельзя трогать
}// скобка, которую нельзя трогать

