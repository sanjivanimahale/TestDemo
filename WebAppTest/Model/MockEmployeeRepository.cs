using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Model
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name="sai", Department = "IT" , Email = "abc@gmail.com"},
                new Employee() { Id = 2, Name="pooja", Department = "HR" , Email = "pooja@gmail.com"},
                new Employee() { Id = 3, Name="mat", Department = "IT" , Email = "mat@gmail.com"}
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }
    }
}
