namespace ristretto.Entities
{
    public partial class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Uri Url { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
