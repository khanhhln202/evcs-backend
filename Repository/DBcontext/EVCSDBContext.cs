using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Models;
using System;
using System.Collections.Generic;

namespace DAL.DBcontext;

public partial class EVCSDBContext : DbContext
{
    public EVCSDBContext()
    {
    }

    public EVCSDBContext(DbContextOptions<EVCSDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}