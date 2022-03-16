using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Data
{
    public class EmployeeService
    {
        private static readonly Employee[] _employees = new[]{
            new Employee() { EmployeName="EmployeName1" },
            new Employee() { EmployeName="EmployeName2" },
            new Employee() { EmployeName="EmployeName3" },
        };

        public EmployeeService()
        {

        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = _employees.ToList();
            return employees;
        }
    }
}
