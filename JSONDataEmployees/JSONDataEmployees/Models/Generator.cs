using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToJSONTool.Models
{
    public static class Generator
    {
        private static readonly Random random = new Random();
        private static Dictionary<int, int> _endMonthDays = new Dictionary<int, int>()
        {
            { 1,31}, { 2,28}, { 3,31}, { 4,30},
            { 5,31}, { 6,30}, { 7,31}, { 8,31},
            { 9,30}, { 10,31}, { 11,30}, { 12,31},
        };
        public static Employee GenerateEmployee()
        {
            var month = random.Next(1, 12);
            int maxDay;
            _endMonthDays.TryGetValue(month, out maxDay);

            return new Employee()
            {
                Guid = Guid.NewGuid(),
                Name = Resource.NAMES[random.Next(0, Resource.NAMES.Length - 1)],
                Surmame = Resource.SURNAMES[random.Next(0, Resource.SURNAMES.Length - 1)],              
                BirthDay = DateTime.Parse($"{random.Next(1,maxDay)}/{month}/{random.Next(1970, 2006)}"),
                WorkPost = Resource.WORKPOSTS[random.Next(0, Resource.WORKPOSTS.Length - 1)],
                Division = Resource.DIVISIONS[random.Next(0, Resource.DIVISIONS.Length - 1)],
                IsMale = random.Next(0, 1) == 0 ? true : false
            };
        }
    
    }
}
