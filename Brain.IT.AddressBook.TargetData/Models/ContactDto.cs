namespace Brain.IT.AddressBook.TargetData.Models;

/// <summary>
/// Contact data transfer object
/// </summary>
public class ContactDto
{
	/// <summary>
	/// Contact identifier
	/// </summary>
	public int Id { get; set; }
	/// <summary>
	/// First name
	/// </summary>
	public string FirstName { get; set; } = null!;
	/// <summary>
	/// Last name
	/// </summary>
	public string LastName { get; set; } = null!;
	/// <summary>
	/// Phone number
	/// </summary>
	public string Email { get; set; } = null!;
}
