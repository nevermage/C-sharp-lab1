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
    public partial class Form2 : Form
    {

        Form1 form1;
        public Form2(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            
            foreach (var dep in Company.Departments)
            {
                comboBox1.Items.Add(dep.NameDep);
            }    
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var dep in Company.Departments)
            {
                if (comboBox1.SelectedItem.ToString() == dep.NameDep)
                {
                    Company.AllEmpl.Add(new employeers(textBox1.Text, textBox2.Text, textBox3.Text,comboBox1.SelectedItem.ToString()));
                    dep.employeers.Add(Company.AllEmpl[Company.AllEmpl.Count - 1]);

                    
                    this.Close();
                }
            }
            
            
        }
    }
}
