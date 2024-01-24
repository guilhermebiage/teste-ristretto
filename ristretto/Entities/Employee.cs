using System.Security;

namespace ristretto.Entities
{
    public partial class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string JobRole { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public Company Company { get; set; }
    }
}
