﻿using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() {}
        public MySqlContext(DbContextOptions<MySqlContext> options) 
            : base(options)
        {
        }
    }
}
