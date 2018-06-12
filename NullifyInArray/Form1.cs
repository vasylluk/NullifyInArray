using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NullifyInArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void Fill(int n)
        {
            double item;
            int i = arrayListBox.Items.Count;
            if (i == n - 1)
            {
                fillButton.Enabled = false;
            }
            if (double.TryParse(fillTextBox.Text, out item))
                arrayListBox.Items.Add(item);
            else
            {
                MessageBox.Show("Invalid value", "Error");
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)countUpDown.Value;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            int item;
            int n = (int)countUpDown.Value;
            Fill(n);
        }

        private void nullifyButton_Click(object sender, EventArgs e)
        {
            bool t = false;
            int n = (int)countUpDown.Value;
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(arrayListBox.Items[i]);
            }
            double maxv = array.Max();
            int maxi = array.ToList().IndexOf((int)maxv);
            double minv = array.Min();
            int mini = array.ToList().IndexOf((int)minv);
            double d = (maxv - minv)/Math.Abs((maxi-mini));
            arrayListBox.Items.Clear();
            int j = 0;
            for (int i = 0; i < array.Length; i++) {
                bool t2 = array.ToList().IndexOf(array[i]) < mini && array.ToList().IndexOf(array[i]) > maxi;
                bool t1 = array.ToList().IndexOf(array[i]) > mini && array.ToList().IndexOf(array[i]) < maxi;
                if (t1 || t2)
                {
                    if (t2)
                    {
                        arrayListBox.Items.Add((maxv - minv) - d * (i-1));
                        t = true;
                    }
                    else
                    {
                        arrayListBox.Items.Add(1 + d * i);
                        t = true;
                    }
                    }
                else
                {
                    arrayListBox.Items.Add(array[i]);
                }
            }
            if(!t) { 
                MessageBox.Show("There is no solution", "Error");
            }
            nullifyButton.Enabled = false;
        }

        private void fillTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
