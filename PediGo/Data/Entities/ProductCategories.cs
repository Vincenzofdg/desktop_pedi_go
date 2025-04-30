using SQLite;

public class ProductCategories
{
    [PrimaryKey, AutoIncrement]
    public long Id { get; set; }
    public long ProductId { get; set; }
    public long CategoryId { get; set; }
}
