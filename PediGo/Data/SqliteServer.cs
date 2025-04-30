using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PediGo.Data
{
    public class SqliteServer : IAsyncDisposable
    {
        private readonly SQLiteAsyncConnection _connection;
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
                return;
            }

            var categories = SeedData.GetCategories();
            var products = SeedData.GetProducts();
            var productCategories = SeedData.GetProductCategories();

            await _connection.InsertAllAsync(categories);
            await _connection.InsertAllAsync(products);
            await _connection.InsertAllAsync(productCategories);
        }

        // Check if tables has been created
        public async Task InitializeAndCreate()
        {
            await _connection.CreateTableAsync<Categories>();
            await _connection.CreateTableAsync<Products>();
            await _connection.CreateTableAsync<ProductCategories>();
            await _connection.CreateTableAsync<Orders>();
            await _connection.CreateTableAsync<OrderItems>();

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
