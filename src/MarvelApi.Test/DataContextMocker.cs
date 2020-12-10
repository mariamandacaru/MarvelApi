using MarvelApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelApi.Test
{
    public static class DataContextMocker
     {
        public static DataContext GetDataContext(string dbName)
        {
                // Create options for DbContext instance
            var options = new DbContextOptionsBuilder<DataContext>()
                    .UseInMemoryDatabase(databaseName: dbName)
                    .Options;
            
            // Create instance of DbContext
            var dbContext = new DataContext(options);

            // Add entities in memory
            DataSeeder.SeedData(dbContext);
            
            return dbContext;
        }
    }
    
}
