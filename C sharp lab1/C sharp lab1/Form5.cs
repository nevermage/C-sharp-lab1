using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_lab1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var empl in Company.AllEmpl)
            {
                if (empl.FirstName == textBox1.Text && empl.SecondName == textBox2.Text)
                {
                    empl.FirstName = textBox3.Text;
                    empl.SecondName = textBox4.Text;
                }
                    
            }

            foreach(var emp in Company.Departments)
            {
                for (var i=0;i<emp.employeers.Count;i++)
                {
                    if (emp.employeers[i].FirstName==textBox1.Text && emp.employeers[i].SecondName==textBox2.Text)
                    {
                        emp.employeers[i].FirstName=textBox3.Text;
                        emp.employeers[i].SecondName=textBox4.Text;
                    }    
                }

            }
            this.Close();
        }
    }
}
