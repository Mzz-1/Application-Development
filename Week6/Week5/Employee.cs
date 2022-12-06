using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Week6.Week5
{
   

        public class Employee
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string EmployeeName { get; set; }
            public int Salary { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.Now;

            public string Department { get; set; }
        }


   

}
