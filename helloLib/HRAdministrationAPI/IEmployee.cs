namespace HRAdministrationAPI
{
  public interface IEmployee
  {
    int ID { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    decimal Salary { get; set; }
  }
}

