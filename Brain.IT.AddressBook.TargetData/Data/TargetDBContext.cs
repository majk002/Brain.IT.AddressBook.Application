using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Brain.IT.AddressBook.TargetData.Data;

/// <summary>
/// DB context
/// </summary>
public class TargetDBContext : IdentityDbContext
{
	/// <summary>
	/// Default constructor
	/// </summary>
	/// <param name="options"></param>
	public TargetDBContext(DbContextOptions<TargetDBContext> options)
		: base(options)
	{
	}

	/// <summary>
	/// Contacts
	/// </summary>
	public virtual DbSet<Contact> Contacts { get; set; }

	/// <summary>
	/// On model creating
	/// </summary>
	/// <param name="modelBuilder"></param>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Contact>(entity =>
		{
			entity.HasKey(e => e.Id);
			entity.Property(e => e.ExtId);
			entity.Property(e => e.FirstName);
			entity.Property(e => e.LastName);
			entity.Property(e => e.Email);
		});

		base.OnModelCreating(modelBuilder);
	}

}
