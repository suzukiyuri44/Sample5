using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample5
{
    public partial class Form1 : Form
    {
        private enum weeks
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array array = Enum.GetValues(typeof(weeks));

            foreach (object value in array)
            {
                weeks week = (weeks)value;

                Console.WriteLine(week);
            }
        }
    }
}
