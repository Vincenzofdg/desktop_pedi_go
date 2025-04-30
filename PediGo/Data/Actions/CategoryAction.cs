namespace PediGo.Data.Actions
{
    internal class CategoryAction : SqliteServer
    {
        public async Task<Categories[]> GetCategories()
        {
            return await _connection.Table<Categories>().ToArrayAsync();
        }
    }
}
