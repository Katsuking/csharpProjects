namespace HRAdministrationAPI
{
  public class EmployeeBase : IEmployee
  {
    int ID { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    decimal virtual Salary { get; set; }
}
}