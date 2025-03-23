using AutoMapper;
using Brain.IT.AddressBook.TargetData.Data;
using Brain.IT.AddressBook.TargetData.Models;
using Brain.IT.AddressBook.TargetData.Repositories;

namespace Brain.IT.AddressBook.TargetData.Services;

/// <summary>
/// Contact service
/// </summary>
/// <param name="contactRepository"></param>
/// <param name="mapper"></param>
public class ContactService(IContactRepository contactRepository, IMapper mapper) : IContactService
{
	private readonly IContactRepository _contactRepository = contactRepository;
	private readonly IMapper _mapper = mapper;

	public async Task AddContacts(IEnumerable<ContactDto> contactDtos)
	{
		var contacts = _mapper.Map<List<Contact>>(contactDtos);
		contacts.ForEach(x => x.Id = Guid.NewGuid());
		await _contactRepository.AddManyAsync(contacts);
	}

	public async Task<IEnumerable<ContactDto>> GetAllContactsAsync()
	{
		var contacts = await _contactRepository.GetAllAsync();
		return _mapper.Map<List<Contact>, List<ContactDto>>(contacts.ToList());
	}
}
