using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SQLite;
using Improving.Models;
namespace Improving
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            //Establishing the conection
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Customer>().Wait();
        }

        

        // Save registers
        public Task<int> SavePersonAsync(Customer custom)
        {
            return _database.InsertAsync(custom);
        }

        public Task<List<Customer>> GetPeopleAsync()
        {
            return _database.Table<Customer>().ToListAsync();
        }

    }
}
