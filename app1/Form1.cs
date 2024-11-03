using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ICT, SFT, ET, TOT, AVG;    // changed name
            String grade;

            ICT = int.Parse(textICT.Text);
            SFT=int.Parse(textSFT.Text);
            ET=int.Parse(textET.Text);

            TOT = ICT + SFT + ET;
            textTOTAL.Text = TOT.ToString();

            AVG = TOT / 3;
            textAVG.Text = AVG.ToString();

            if (AVG >= 70)
            {
                grade = "A";
            }
            else if(AVG>=60){
                grade = "B";
            }
            else if (AVG >= 50)
            {
                grade= "C";
            }
            else {
                grade = "w";
            }
            textGRADE.Text = grade.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
