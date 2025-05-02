using PediGo.Data.Entities;

namespace PediGo.Data.Actions
{
    public class CategoryAction : SqliteServer
    {
        public async Task<Categories[]> GetCategories()
        {
            return await _connection.Table<Categories>().ToArrayAsync();
        }
    }
}
