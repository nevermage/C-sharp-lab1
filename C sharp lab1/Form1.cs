using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;

namespace C_sharp_lab1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            List<employeers> e = new List<employeers>();
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();
            binding1.DataSource = Company.AllEmpl;
            binding2.DataSource = Company.Departments;
            dataGridView1.DataSource = binding1;
            dataGridView2.DataSource = binding2;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();
            binding1.DataSource = Company.AllEmpl;
            binding2.DataSource = Company.Departments;
            dataGridView1.DataSource = binding1;
            dataGridView2.DataSource = binding2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();
            binding1.DataSource = Company.AllEmpl;
            binding2.DataSource = Company.Departments;
            dataGridView1.DataSource = binding1;
            dataGridView2.DataSource = binding2;
            
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();
            binding1.DataSource = Company.AllEmpl;
            binding2.DataSource = Company.Departments;
            dataGridView1.DataSource = binding1;
            dataGridView2.DataSource = binding2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();
            binding1.DataSource = Company.AllEmpl;
            binding2.DataSource = Company.Departments;
            dataGridView1.DataSource = binding1;
            dataGridView2.DataSource = binding2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();
            binding1.DataSource = Company.AllEmpl;
            binding2.DataSource = Company.Departments;
            dataGridView1.DataSource = binding1;
            dataGridView2.DataSource = binding2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();
            binding1.DataSource = Company.AllEmpl;
            binding2.DataSource = Company.Departments;
            dataGridView1.DataSource = binding1;
            dataGridView2.DataSource = binding2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();
            binding1.DataSource = Company.AllEmpl;
            binding2.DataSource = Company.Departments;
            dataGridView1.DataSource = binding1;
            dataGridView2.DataSource = binding2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var json1 = new DataContractJsonSerializer(Company.AllEmpl.GetType());
            var json2 = new DataContractJsonSerializer(Company.Departments.GetType());
            using (var file = new FileStream("inputEmpl.json", FileMode.OpenOrCreate))
            {
                json1.WriteObject(file, Company.AllEmpl);
            }
            using (var file = new FileStream("inputDep.json", FileMode.OpenOrCreate))
            {
                json2.WriteObject(file, Company.Departments);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var json1 = new DataContractJsonSerializer(Company.Departments.GetType());
            var json2 = new DataContractJsonSerializer(Company.AllEmpl.GetType());
            using (var file = new FileStream("inputDep.json", FileMode.OpenOrCreate))
            {
                Company.Departments = json1.ReadObject(file) as List<Department>;
            }
            using (var file = new FileStream("inputEmpl.json", FileMode.OpenOrCreate))
            {
                Company.AllEmpl = json2.ReadObject(file) as List<employeers>;
            }
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();

            binding2.DataSource = Company.Departments;
            dataGridView2.DataSource = binding2;

            binding1.DataSource = Company.AllEmpl;
            dataGridView1.DataSource = binding1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var Empl = from p in Company.AllEmpl
                         orderby p.SecondName
                         select p;
            BindingSource binding = new BindingSource();
            binding.DataSource = Empl;
            dataGridView1.DataSource = binding;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var Empl = from p in Company.AllEmpl
                       orderby p.SecondName descending
                       select p;
            BindingSource binding = new BindingSource();
            binding.DataSource = Empl;
            dataGridView1.DataSource = binding;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var Sal = from p in Company.AllEmpl
                       orderby p.Salary
                       select p;
            BindingSource binding = new BindingSource();
            binding.DataSource = Sal;
            dataGridView1.DataSource = binding;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var Dep = from p in Company.AllEmpl
                      orderby p.Dep
                      select p;
            BindingSource binding = new BindingSource();
            binding.DataSource = Dep;
            dataGridView1.DataSource = binding;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var Dep = from p in Company.AllEmpl
                      orderby p.Dep descending
                      select p;
            BindingSource binding = new BindingSource();
            binding.DataSource = Dep;
            dataGridView1.DataSource = binding;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BindingSource binding1 = new BindingSource();
            BindingSource binding2 = new BindingSource();
            binding1.DataSource = Company.AllEmpl;
            binding2.DataSource = Company.Departments;
            dataGridView1.DataSource = binding1;
            dataGridView2.DataSource = binding2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var Dep = from p in Company.AllEmpl
                      where p.Dep == textBox1.Text
                      select p;
            BindingSource binding = new BindingSource();
            binding.DataSource = Dep;
            dataGridView1.DataSource = binding;
        }
    }
}
