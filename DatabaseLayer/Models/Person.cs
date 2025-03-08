namespace DatabaseLayer.Models;

public class Person : RootObj
{
    public Guid PersonId { get; set; }
    public string Name { get; set; }
}