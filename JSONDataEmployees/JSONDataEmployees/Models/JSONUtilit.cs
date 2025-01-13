using System.Text.Json;

namespace EmployeeToJSONTool.Models
{
    internal class JSONUtilit
    {
        private readonly string _jsonFilePath;
        public JSONUtilit(string jsonPath)
        {
            _jsonFilePath = jsonPath;
        }

        public async Task<List<Employee>> ReadAllEmployees()
        {
            var employeesString = File.ReadAllText(this._jsonFilePath);

            try
            {
                var stream = new MemoryStream();
                var writer = new StreamWriter(stream);
                writer.Write(employeesString);
                writer.Flush();
                stream.Position = 0;
              
                    var employees = await JsonSerializer.DeserializeAsync<List<Employee>>(stream);
                    return employees;    
            }
            catch (Exception e)
            {
                return new List<Employee>();
            }
        }

        public async void AddEmployee(Employee newEmployee)
        {
            var employees = await ReadAllEmployees();

            if (employees.Any(em => em.Name.Equals(newEmployee.Name) ||
                           em.Surmame.Equals(newEmployee.Surmame)))
            {
                return;
            }

            employees.Add(newEmployee);
            var newEmployeesString = JsonSerializer.Serialize<List<Employee>>(employees);
            File.WriteAllText(_jsonFilePath, newEmployeesString);
        }

        public async void RemoveEmployeeByGuid(Guid guid)
        {
            var employees = await ReadAllEmployees();
            var emplForRemove = employees.FirstOrDefault(em => em.Guid == guid);

            if (emplForRemove != null)
                 employees.Remove(emplForRemove);

            var newEmployeesString = JsonSerializer.Serialize<List<Employee>>(employees);

            File.WriteAllText(_jsonFilePath, newEmployeesString);
        }

        public async Task<Employee> GetEmployeeByGuid(Guid guid)
        {
            var employees = await ReadAllEmployees();
            var searchedEmployee = employees.FirstOrDefault(em => em.Guid == guid);

            return searchedEmployee;
        }

        public void CleanAllEmployees()
        {
            File.WriteAllText( _jsonFilePath, String.Empty);
        }
    }
}
