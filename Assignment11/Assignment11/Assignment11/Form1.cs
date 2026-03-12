using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment11
{

    // Demonstrated in class
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double test1;
        private double test2;
        private double test3;
        const double highScore = 95.0;
        const double testFail = 60.0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void test1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void test2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void test3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void averageLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double average;
            Double.TryParse(test1TextBox.Text, out test1);
            Double.TryParse(test2TextBox.Text, out test2);
            Double.TryParse(test3TextBox.Text, out test3);
            average = (test1 + test2 + test3) / 3.0;
            
            try
            {

                if (average >= highScore)
                {
                    averageLabel.Text = average.ToString("n1");
                    MessageBox.Show("You got a High Score, Congrats!");
                }
                else if (average <= testFail)
                {
                    averageLabel.Text = average.ToString("n1");
                    MessageBox.Show("You failed the test.");
                }
                else if ((average < highScore) && (average > testFail))
                {
                    averageLabel.Text = average.ToString("n1");
                    MessageBox.Show("You passed the test.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
     



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            averageLabel.Text = "";
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
