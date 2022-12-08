namespace AW_MVC_uppgift_3.Models
{
    public class ProducsService
    {
        static List<Employee> employees = new List<Employee>() { };



        public ProducsService()
        {

        }
        public Employee[] GetAll()
        {
            return employees
                .ToArray();
        }
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee? GetById(int id)
        {
            return employees
                .FirstOrDefault(e => e.Id == id);
        }

    }
}
