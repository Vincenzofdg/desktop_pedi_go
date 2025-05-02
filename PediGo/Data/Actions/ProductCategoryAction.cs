using PediGo.Data.Entities;

namespace PediGo.Data.Actions

{
    public class ProductCategoryAction : SqliteServer
    {
        public async Task<ProductCategories[]> GetProductCategories()
        {
            //var query = @"SELECT DISTINCT * FROM ProductCategories";
            //var result = await _connection.QueryAsync<ProductCategories>(query);

            //return [.. result];

            return await _connection.Table<ProductCategories>().ToArrayAsync();
        }

        public async Task<ProductCategories[]> GetProductCategoriesById(long categoryId)
        {
            var query = @"SELECT * FROM ProductCategories WHERE CategoryId = ?";
            var result = await _connection.QueryAsync<ProductCategories>(query, categoryId);
            
            return [..result];
        }
    }
}
