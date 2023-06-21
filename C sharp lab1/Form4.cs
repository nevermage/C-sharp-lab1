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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < Company.AllEmpl.Count; i++)
            {
                if (Company.AllEmpl[i].FirstName == textBox1.Text && Company.AllEmpl[i].SecondName == textBox2.Text)
                {
                    Company.Departments[i].employeers.Remove(Company.AllEmpl[i]);
                    Company.AllEmpl.Remove(Company.AllEmpl[i]);
                    this.Close();
                    
                }
            }
        }
    }
}
