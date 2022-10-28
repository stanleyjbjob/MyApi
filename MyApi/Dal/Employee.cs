namespace MyApi.Dal
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string EmployeeId { get; set; }
        public Guid DataGroup { get; set; }
    }
}