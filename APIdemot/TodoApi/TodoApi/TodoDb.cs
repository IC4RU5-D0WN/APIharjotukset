﻿using Microsoft.EntityFrameworkCore;
using TodoApi;

namespace TodoApi
{
    public class TodoDb
    {
    }
}
class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}