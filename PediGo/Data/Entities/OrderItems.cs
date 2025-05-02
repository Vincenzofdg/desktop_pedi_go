using SQLite;

namespace PediGo.Data.Entities;

public class OrderItems
{
    [PrimaryKey, AutoIncrement]
    public long Id { get; set; }
    public long ProductId { get; set; }
    public long OrderId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Qtd { get; set; }

    [Ignore]
    public decimal Amount => Qtd * Price;
}