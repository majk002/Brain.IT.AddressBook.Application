using System.ComponentModel.DataAnnotations;

namespace Brain.IT.AddressBook.TargetData.Data;

/// <summary>
/// Person contact
/// </summary>
public class Contact
{
	/// <summary>
	/// Contact identifier
	/// </summary>
	[Key]
	public Guid Id { get; set; }
	/// <summary>
	/// External identifier
	/// </summary>
	[Required]
	public int ExtId { get; set; }
	/// <summary>
	/// First name
	/// </summary>
	[Required]
	[MaxLength(50)]
	public string FirstName { get; set; } = null!;
	/// <summary>
	/// Last name
	/// </summary>
	[Required]
	[MaxLength(50)]
	public string LastName { get; set; } = null!;
	/// <summary>
	/// Pnohe number
	/// </summary>
	[Required]
	[MaxLength(50)]
	public string Email { get; set; } = null!;
}
