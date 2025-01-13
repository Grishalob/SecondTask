using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToJSONTool.Models
{
    public  class Manager
    {
        public List<Employee> Employees { get; set; }
        private JSONUtilit _utilit;

        public Manager(string jsonPath) 
        { 
           Employees = new List<Employee>();
           _utilit = new JSONUtilit(jsonPath); 
        }
        
        public async Task<List<Employee>> GetAllEmployees()
        {
            try
            {
                Employees = await _utilit.ReadAllEmployees();
                return Employees;
            }
            catch (Exception ex)
            {
                return Employees;
            }        
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                _utilit.AddEmployee(employee);
                return true;
            }
            catch (Exception ex)
            { 
                return false;
            }        
        }

        public bool RemoveEmployeeByGuid(Guid guid)
        {
            try
            {
                _utilit.RemoveEmployeeByGuid(guid);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool TryGetEmployeeByGuid(string guidStr, out Employee serachedEmployee) 
        {
            serachedEmployee = null;

            try
            {
                Guid guid;

                if (!Guid.TryParse(guidStr, out guid))
                {                  
                    return false;
                }

                serachedEmployee = _utilit.GetEmployeeByGuid(guid).Result;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CleanAllEmployees()
        {
            try
            {
                _utilit.CleanAllEmployees();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
