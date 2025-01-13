using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToJSONTool.Models
{
    public class Employee
    {
        private int _age;
       public Guid Guid { get; set; }
       public string Name { get; set; }
       public string Surmame { get; set; }
       public DateTime BirthDay { get; set; }
       public int Age 
        {
            get { Age = DateTime.Now.Year - BirthDay.Year; return _age; } 
            set { _age = value; } 
        }
       public string Division { get; set; }
       public string WorkPost { get; set; }
       public bool IsMale { get; set; }
    }
}
