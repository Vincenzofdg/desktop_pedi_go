using Microsoft.Maui.ApplicationModel.DataTransfer;
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

        public async Task<Products[]> GetProductCategoriesById(long categoryId)
        {
            var query = @"
                SELECT products.*
                FROM ProductCategories relation
                JOIN Products products ON relation.ProductId = products.Id
                WHERE relation.CategoryId = ?;
            ";

            var result = await _connection.QueryAsync<Products>(query, categoryId);

            return [..result];
        }
    }
}
