using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();
        
        public void Showlist<T> (ref List<T> list);  ///Generic Show List

        public Employee FindEmployeeById(List <Employee> list, int id);

        public decimal GetTotalSalary<T> (ref List<T> list);  ///Generic Total

        public List<Employee> FindListRange (List<Employee> list,decimal startForm,decimal endTo);

    }
}
