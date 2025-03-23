using Brain.IT.AddressBook.TargetData.Models;

namespace Brain.IT.AddressBook.TargetData.Services;

public interface IContactService
{
	Task AddContacts(IEnumerable<ContactDto> contactDtos);
	Task<IEnumerable<ContactDto>> GetAllContactsAsync();
}
