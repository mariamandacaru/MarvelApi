using MarvelApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelApi.Test
{
    public static class DataContextExtensions
    {
        public static void Seed(this DataContext dbContext)
        {
            dbContext.SaveChanges();
        }
    }
}
