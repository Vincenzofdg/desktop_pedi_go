namespace PediGo.Data.Actions
{
    public class ProductAction : SqliteServer
    {
        public async Task<Products[]> GetProducts()
        {
            return await _connection.Table<Products>().ToArrayAsync();
        }
    }
}
