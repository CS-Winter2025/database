namespace DatabaseLayer.Models;

public class Service
{
    public int ServiceID { get; set; }
    public string Type { get; set; }
    public string EmployeeIDs { get; set; } 
    public decimal Rate { get; set; }
    public List<string> Requirements { get; set; } = new List<string>(); 
}