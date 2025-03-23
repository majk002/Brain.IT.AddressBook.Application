using Brain.IT.AddressBook.TargetData.Data;
using Microsoft.EntityFrameworkCore;

namespace Brain.IT.AddressBook.TargetData.Repositories;

/// <summary>
/// Contact repository
/// </summary>
/// <param name="dbContext"></param>
public class ContactRepository(TargetDBContext dbContext) : IContactRepository
{
	private readonly TargetDBContext _dbContext = dbContext;

	/// <summary>
	/// Insert list of contacts
	/// </summary>
	/// <param name="contacts"></param>
	/// <returns></returns>
	public async Task AddManyAsync(List<Contact> contacts)
	{
		await _dbContext.Contacts.AddRangeAsync(contacts);
		await _dbContext.SaveChangesAsync();
	}

	/// <summary>
	/// Get all contacts
	/// </summary>
	/// <returns></returns>
	/// <exception cref="NotImplementedException"></exception>
	public async Task<IEnumerable<Contact>> GetAllAsync()
	{
		return await _dbContext.Contacts.ToListAsync();
	}

	/// <summary>
	/// Get contact by identifier
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public async Task<Contact?> GetByIdAsync(Guid id)
	{
		return await _dbContext.Contacts.FindAsync(id);
	}
}
