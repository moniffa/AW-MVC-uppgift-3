using AW_MVC_uppgift_3.Models.Entities;
using System.Text.Json;
using System.Linq;
using AW_MVC_uppgift_3.Views.Employees;

namespace AW_MVC_uppgift_3.Models
{
    public class DataService
    {
        //List<Employee> employees;

        string path = Environment.CurrentDirectory + @"\DataStorage\EmployeesDataSet.json";
        private readonly EmployeeContext context;

        public DataService(EmployeeContext context)
        {
            this.context = context;
        }

        public IndexVM[] GetAll()
        {

            return context.Employees
                .Select(e => new IndexVM() { Email = e.Email, Name = e.Name, ID = e.Id, ShowAsHighlighted = e.Email.ToLower().StartsWith("admin")})
                .ToArray();
            
        }
        public void Add(CreateVM employee)
        {
            Employee e = new Employee();    
            e.Name = employee.Name;
            e.Email = employee.Email;  
            context.Employees.Add(e);
            
            context.SaveChanges();
            
        }

        public Employee? GetById(int id)
        {
            return context.Employees
                .FirstOrDefault(e => e.Id == id);
        }
        public void Delete(int id)
        {
            var index = context.Employees.Find(id);
            context.Employees.Remove(index);
            
            context.SaveChanges();
        }

    }
}
