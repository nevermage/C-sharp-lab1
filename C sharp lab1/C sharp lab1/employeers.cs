using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lab1
{
    [Serializable]
    class employeers
    {

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Salary { get; set; }
        public string Dep { get; set; }

        public employeers(string FirstName, string SecondName, string Salary, string dep)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Salary = Salary;
            Dep = dep;
        }

    }
}
