using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models;


public class Employee
{
    public int? ManagerId { get; set; }  
    public Employee Manager { get; set; } 

    public string JobTitle { get; set; } 
    public string EmploymentType { get; set; }
    public decimal PayRate { get; set; }

    public List<int> Availability { get; set; } = new List<int>();
    public List<int> HoursWorked { get; set; } = new List<int>(); 
    public List<string> Certifications { get; set; } = new List<string>(); 
    public string DetailsJson { get; set; } 
    
    
    [ForeignKey("OrganizationId")]
    public int OrganizationId { get; set; }
    public Organization Organization { get; set; }
}