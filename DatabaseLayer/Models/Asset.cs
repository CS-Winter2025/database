namespace DatabaseLayer.Models;

public class Asset : RootObj
{
    public int AssetID { get; set; } // Primary Key

    public string Type { get; set; }

    public int? ResidentID { get; set; }  // Foreign Key (Stored in DB)
    public Resident Resident { get; set; }  // Navigation Property (Not stored, for C# usage)
}
