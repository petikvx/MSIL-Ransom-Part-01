using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaMerchantConverter : IObjectConverter<InstaMerchant, InstaMerchantResponse>
{
	public InstaMerchantResponse SourceObject { get; set; }

	public InstaMerchant Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaMerchant
		{
			Pk = SourceObject.Pk,
			ProfilePicture = SourceObject.ProfilePicture,
			Username = SourceObject.Username
		};
	}
}
