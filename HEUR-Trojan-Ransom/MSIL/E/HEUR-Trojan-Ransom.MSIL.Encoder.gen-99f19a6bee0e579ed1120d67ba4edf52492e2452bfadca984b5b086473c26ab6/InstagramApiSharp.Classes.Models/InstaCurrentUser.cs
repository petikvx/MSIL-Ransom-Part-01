using System.Collections.Generic;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Classes.Models;

public class InstaCurrentUser : InstaUserShort
{
	public bool HasAnonymousProfilePicture { get; set; }

	public string Biography { get; set; }

	public string ExternalUrl { get; set; }

	public List<InstaImage> HdProfileImages { get; set; } = new List<InstaImage>();


	public InstaImage HdProfilePicture { get; set; }

	public bool ShowConversionEditEntry { get; set; }

	public string Birthday { get; set; }

	public string PhoneNumber { get; set; }

	public int CountryCode { get; set; }

	public long NationalNumber { get; set; }

	public InstaGenderType Gender { get; set; }

	public string Email { get; set; }

	public InstaCurrentUser(InstaUserShort instaUserShort)
	{
		base.Pk = instaUserShort.Pk;
		base.UserName = instaUserShort.UserName;
		base.FullName = instaUserShort.FullName;
		base.IsPrivate = instaUserShort.IsPrivate;
		base.ProfilePicture = instaUserShort.ProfilePicture;
		base.ProfilePictureId = instaUserShort.ProfilePictureId;
		base.IsVerified = instaUserShort.IsVerified;
	}
}
