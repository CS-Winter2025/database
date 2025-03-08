namespace DatabaseLayer.Models;

public class RootObj
{

    public Guid Id { get; set; }
    public string DetailsJson { get; set; } // JSON storage for flexible fields

}