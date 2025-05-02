using PediGo.Data.Entities;
using SQLite;

namespace PediGo.Data
{
    public class SqliteServer : IAsyncDisposable
    {
        public readonly SQLiteAsyncConnection _connection;
 
        public SqliteServer()
        {
            var DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sqliteDB.db3");
 
            _connection = new SQLiteAsyncConnection(
                DatabasePath,
                SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache
            );
        }

        // Seed Database
        private async Task SeedDatabase()
        {
            var firstCategory = await _connection.Table<Categories>().FirstOrDefaultAsync();

            // Check if database if already seeded
            if (firstCategory != null)
            {
                //Debug.WriteLine(firstCategory);
                //return;
                await ClearDataBase();
            }

            var categories = SeedData.GetCategories();
            var products = SeedData.GetProducts();
            var productCategories = SeedData.GetProductCategories();

            await _connection.InsertAllAsync(categories);
            await _connection.InsertAllAsync(products);
            await _connection.InsertAllAsync(productCategories);
        }

        private async Task ClearDataBase()
        {
            try
            {
                // Apaga os dados de todas as tabelas. Aqui, substitua pelos nomes das suas tabelas.
                await _connection.DeleteAllAsync<Categories>();
                await _connection.DeleteAllAsync<Products>();
                await _connection.DeleteAllAsync<ProductCategories>();
                await _connection.DeleteAllAsync<Orders>();
                await _connection.DeleteAllAsync<OrderItems>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Check if tables has been created
        public async Task InitializeAndCreate()
        {
            // Create structure
            await _connection.CreateTableAsync<Categories>();
            await _connection.CreateTableAsync<Products>();
            await _connection.CreateTableAsync<ProductCategories>();
            await _connection.CreateTableAsync<Orders>();
            await _connection.CreateTableAsync<OrderItems>();

            // Populate database
            await SeedDatabase();
        }

        public async ValueTask DisposeAsync()
        {
            if(_connection != null) {
                await _connection.CloseAsync();
                return;
            }
        }
    }
}
