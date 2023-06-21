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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var i=0;i<Company.Departments.Count;i++)
            {
                if (Company.Departments[i].NameDep == textBox1.Text)
                    Company.Departments.Remove(Company.Departments[i]);
            }
            this.Close();
        }
    }
}
