using AutoMapper;
using Brain.IT.AddressBook.TargetData.Data;
using Brain.IT.AddressBook.TargetData.Models;

namespace Brain.IT.AddressBook.TargetData.Profiles;

/// <summary>
/// Contact profiler
/// </summary>
public class ContactProfile : Profile
{
	/// <summary>
	/// Default constructor
	/// </summary>
	public ContactProfile()
	{
		this.CreateMap<ContactDto, Contact>()
			.ForMember(x => x.Id, opt => opt.Ignore())
			.ForMember(dest => dest.ExtId, opt => opt.MapFrom(src => src.Id))
			.ReverseMap();
	}
}
