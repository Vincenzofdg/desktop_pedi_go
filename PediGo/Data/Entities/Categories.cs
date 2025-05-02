using SQLite;

namespace PediGo.Data.Entities;

public class Categories
{
    [PrimaryKey, AutoIncrement]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }

}
