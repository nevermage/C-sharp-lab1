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
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 f)
        {
            form1 = f;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<employeers> empl = new List<employeers>();
            Company.Departments.Add(new Department(textBox1.Text, empl));
            
            this.Close();
        }
    }
}
