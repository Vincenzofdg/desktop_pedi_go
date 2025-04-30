namespace PediGo.Data.Actions
{
    public class OrderItemsAction : SqliteServer
    {
        public async Task<OrderItems[]> GetOrderItems()
        {
            return await _connection.Table<OrderItems>().ToArrayAsync();
        }
    }
}
