using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lab1
{
    [Serializable]
    class Department
    {
        public string NameDep { get; set; }
        public List<employeers> employeers = new List<employeers>();

        public Department(string Name, List<employeers> employeers)
        {
            this.employeers = employeers;
            this.NameDep = Name;
        }
    }
}
