using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public abstract class Offspring_class
    {
        public abstract void textBox1_TextChanged(object sender, EventArgs e);

        public abstract void button13_Click(object sender, EventArgs e);

        public abstract void button14_Click(object sender, EventArgs e);

        public abstract void button16_Click(object sender, EventArgs e);

        public abstract void button15_Click(object sender, EventArgs e);

        public abstract void button17_Click(object sender, EventArgs e);

        public abstract void button20_Click(object sender, EventArgs e);

        public abstract void button19_Click(object sender, EventArgs e);

        public abstract void button18_Click(object sender, EventArgs e);

        public abstract void button21_Click(object sender, EventArgs e);

        public abstract void button22_Click(object sender, EventArgs e);

        public abstract void button23_Click(object sender, EventArgs e);

        public abstract void Form1_KeyDown(object sender, KeyEventArgs e);

        //----------------------SPECIAL_BUTTONS------------------------------------------------------------

        public abstract void button1_Click(object sender, EventArgs e);

        public abstract void button24_Click(object sender, EventArgs e);

        public abstract void button25_Click(object sender, EventArgs e);

        public abstract void button26_Click(object sender, EventArgs e);

        public abstract void button4_Click(object sender, EventArgs e);

        public abstract void button3_Click(object sender, EventArgs e);

        public abstract void button8_Click(object sender, EventArgs e);

        //----------------------ORDINARY_BUTTONS------------------------------------------------------------

        public abstract void button9_Click(object sender, EventArgs e);

        public abstract void button7_Click(object sender, EventArgs e);

        public abstract void button12_Click(object sender, EventArgs e);

        public abstract void button6_Click(object sender, EventArgs e);

        public abstract void button10_Click(object sender, EventArgs e);

        //----------------------------MEMENTO---------------------------------------------------------------

        public abstract void button27_Click(object sender, EventArgs e);

        public abstract void button30_Click(object sender, EventArgs e);

        public abstract void button29_Click(object sender, EventArgs e);

        public abstract void button28_Click(object sender, EventArgs e);

        public abstract void button5_Click(object sender, EventArgs e);

        //-----------------------------ENGINEER---------------------------------------------------------------

        public abstract void button2_Click(object sender, EventArgs e);

        public abstract void button32_Click(object sender, EventArgs e);

        public abstract void button11_Click(object sender, EventArgs e);

        public abstract void button33_Click(object sender, EventArgs e);

        public abstract void button31_Click(object sender, EventArgs e);

        //----------------------------PROGRAMMER--------------------------------------------------------------

        public abstract void radioButton1_CheckedChanged(object sender, EventArgs e);

        public abstract void radioButton2_CheckedChanged(object sender, EventArgs e);

    }

    public class County : Offspring_class
    {

        public override void textBox1_TextChanged(object sender, EventArgs e) // textbox1
        {
           
        }

        public override void button13_Click(object sender, EventArgs e) // клавиша 1
        {
            
        }

        public override void button14_Click(object sender, EventArgs e) // клавиша 2
        {
           
        }

        public override void button16_Click(object sender, EventArgs e) // клавиша 3
        {
             
        }

        public override void button15_Click(object sender, EventArgs e) // клавиша 4
        {
           
        }

        public override void button17_Click(object sender, EventArgs e) // клавиша 5
        {
            
        }

        public override void button20_Click(object sender, EventArgs e) // клавиша 6
        {
            
        }

        public override void button19_Click(object sender, EventArgs e) // клавиша 7
        {
           
        }

        public override void button18_Click(object sender, EventArgs e) // клавиша 8
        {
            
        }

        public override void button21_Click(object sender, EventArgs e) // клавиша 9
        {

        }

        public override void button22_Click(object sender, EventArgs e) // клавиша 0
        {
            
        }

        public override void button23_Click(object sender, EventArgs e) // клавиша запятая
        {
           
        }

        public override void Form1_KeyDown(object sender, KeyEventArgs e) // ввод с клавиатуры через кейсы
        {
           
        }

        //----------------------SPECIAL_BUTTONS------------------------------------------------------------

        public override void button1_Click(object sender, EventArgs e) // ENTER
        {
           
        }

        public override void button24_Click(object sender, EventArgs e) // << или CE
        {
            
        }

        public override void button25_Click(object sender, EventArgs e) // full_clean или C
        {
           
        }

        public override void button26_Click(object sender, EventArgs e) // <--
        {
  
        }

        public override void button4_Click(object sender, EventArgs e) // sqrt
        {
            
        }

        public override void button3_Click(object sender, EventArgs e) // +/-
        {
            
        }

        public override void button8_Click(object sender, EventArgs e) // 1/x
        {
            
        }

        public override void button9_Click(object sender, EventArgs e) // %
        {
            
        }

        //----------------------ORDINARY_BUTTONS------------------------------------------------------------


        public override void button7_Click(object sender, EventArgs e) //  +
        {
           
        }

        public override void button12_Click(object sender, EventArgs e) // /
        {
           
        }

        public override void button6_Click(object sender, EventArgs e) // -
        {
            
        }

        public override void button10_Click(object sender, EventArgs e) // *
        {
           
        }

        //----------------------------MEMENTO---------------------------------------------------------------

        public override void button27_Click(object sender, EventArgs e) // M+
        {

        }

        public override void button30_Click(object sender, EventArgs e) // M-
        {
            
        }

        public override void button29_Click(object sender, EventArgs e) // MR
        {
           
        }

        public override void button28_Click(object sender, EventArgs e) // MC
        {
            
        }

        public override void button5_Click(object sender, EventArgs e) // MS
        {
           
        }
        //-----------------------------ENGINEER---------------------------------------------------------------

        public override void button2_Click(object sender, EventArgs e) // x^2
        {
           
        }

        public override void button32_Click(object sender, EventArgs e) // x^y
        {
            
        }

        public override void button11_Click(object sender, EventArgs e) // n!
        {
           

        }

        public override void button33_Click(object sender, EventArgs e) // 10^x
        {
           
        }

        public override void button31_Click(object sender, EventArgs e) // y_sqrt
        {
            
        }

        public override void radioButton1_CheckedChanged(object sender, EventArgs e) // bin
        {
            
        }

        public override void radioButton2_CheckedChanged(object sender, EventArgs e) // dec
        {
        
        }

    }
    static class Program1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
