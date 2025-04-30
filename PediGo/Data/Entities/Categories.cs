using SQLite;

public class Categories
{
    [PrimaryKey, AutoIncrement]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

}
