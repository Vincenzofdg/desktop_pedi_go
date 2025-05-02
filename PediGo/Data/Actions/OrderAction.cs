using PediGo.Data.Entities;

namespace PediGo.Data.Actions
{
    public class OrderAction : SqliteServer
    {
        public async Task<Orders[]> GetOrderItems()
        {
            return await _connection.Table<Orders>().ToArrayAsync();
        }
    }
}
