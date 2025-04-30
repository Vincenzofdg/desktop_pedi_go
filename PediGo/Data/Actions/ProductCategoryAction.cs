namespace PediGo.Data.Actions

{
    public class ProductCategoryAction : SqliteServer
    {
        public async Task<ProductCategories[]> GetOrderItems()
        {
            return await _connection.Table<ProductCategories>().ToArrayAsync();
        }
    }
}
