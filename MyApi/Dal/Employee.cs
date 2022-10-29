namespace MyApi.Dal
{
    public class Employee: AggregateRoot
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public Guid Department { get; set; }
        public Guid DataGroup { get; set; }
    }
    public class CreateEmployeeDto 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public Guid Department { get; set; }
        public Guid DataGroup { get; set; }
    }
}