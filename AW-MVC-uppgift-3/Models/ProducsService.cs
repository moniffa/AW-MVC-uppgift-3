namespace AW_MVC_uppgift_3.Models
{
    public class ProducsService
    {
        static List<Employee> employees = new List<Employee>() {
            new Employee { Id = 1, Name = "John", Email = "john@mail.com" },
            new Employee { Id = 2, Name = "Mary", Email = "mary@mail.com" },
            new Employee { Id = 3, Name = "Sam", Email = "sam@mail.com" } };



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
