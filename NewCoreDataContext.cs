using System;
using Microsoft.EntityFrameworkCore;

namespace NewCore.Data
{
    public class NewCoreDataContext : DbContext
    {
        public NewCoreDataContext(DbContextOptions<NewCoreDataContext> options) : base(options)
        {
        }
    }
}
