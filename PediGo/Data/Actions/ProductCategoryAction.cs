namespace PediGo.Data.Actions

{
    public class ProductCategoryAction : SqliteServer
    {
        public async Task<ProductCategories[]> GetProductCategories()
        {
            return await _connection.Table<ProductCategories>().ToArrayAsync();
        }

        public async Task<ProductCategories[]> GetOrderItemsById(long categoryId)
        {
            var query = @"SELECT * FROM ProductCategories WHERE CategoryId = ?";
            var result = await _connection.QueryAsync<ProductCategories>(query, categoryId);
            
            return [..result];
        }
    }
}
