using Brain.IT.AddressBook.TargetData.Data;

namespace Brain.IT.AddressBook.TargetData.Repositories;

/// <summary>
/// Contact repository
/// </summary>
public interface IContactRepository
{
	/// <summary>
	/// Get contact by identifier
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	Task<Contact?> GetByIdAsync(Guid id);
	/// <summary>
	/// Get all contacts
	/// </summary>
	/// <returns></returns>
	Task<IEnumerable<Contact>> GetAllAsync();
	/// <summary>
	/// Insert new contact
	/// </summary>
	/// <param name="contacts"></param>
	/// <returns></returns>
	Task AddManyAsync(List<Contact> contacts);
}
