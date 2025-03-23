using Brain.IT.AddressBook.TargetData.Models;
using Brain.IT.AddressBook.TargetData.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Brain.IT.AddressBook.TargetData.Controllers;

/// <summary>
/// Contact controller
/// </summary>
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ContactsController(IContactService contactService) : ControllerBase
{
    private readonly IContactService _contactService = contactService;

    /// <summary>
    /// Get all contacts
    /// </summary>
    /// <returns>List of contacts</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ContactDto>>> Get()
    {
        var result = await _contactService.GetAllContactsAsync();
        return Ok(result);
    }

    /// <summary>
    /// Insert new contacts
    /// </summary>
    /// <param name="contacts">List of contatcs</param>
    /// <returns>List of added contacts</returns>
    [HttpPost]
	public async Task<ActionResult> Add([FromBody] IEnumerable<ContactDto> contacts)
    {
		await _contactService.AddContacts(contacts);
		return Ok();
	}
}
