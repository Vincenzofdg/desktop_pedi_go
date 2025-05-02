using SQLite;

namespace PediGo.Data.Entities;
public class Products
{
    [PrimaryKey, AutoIncrement]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Qtd { get; set; }
}
