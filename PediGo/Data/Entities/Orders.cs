using SQLite;

namespace PediGo.Data.Entities;
public class Orders
{
    [PrimaryKey, AutoIncrement]
    public long Id { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; }
    public int TotalItems { get; set; }
    public DateTime OrderDate { get; set; }
}
