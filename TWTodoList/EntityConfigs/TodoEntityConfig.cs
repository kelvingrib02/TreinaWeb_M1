using TWTodoList.Models;
using Microsoft.EntityFrameworkCore

namespace TWTodoList.EntityConfigs;

public class TodoEntityConfig : IEntityTypeConfiguration<Todo>
{
    public void Configure(EntityTypeBuilder<Todo> build)
    {
        builder.ToTable("todo");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Id).HasColumnName("id");

        builder.Property(x=>x.Title).HasColumnName("title").HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(x=>x.Date).HasColumnName("date").HasColumnType("date").IsRequired();
    }
}