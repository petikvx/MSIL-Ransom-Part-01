using System;
using InstagramApiSharp.Classes.Models.Hashtags;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters.Hashtags;

internal class InstaHashtagOwnerConverter : IObjectConverter<InstaHashtagOwner, InstaHashtagOwnerResponse>
{
	public InstaHashtagOwnerResponse SourceObject { get; set; }

	public InstaHashtagOwner Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaHashtagOwner
		{
			Name = SourceObject.Name,
			Pk = SourceObject.Pk,
			ProfilePicUrl = SourceObject.ProfilePicUrl,
			ProfilePicUsername = SourceObject.ProfilePicUsername,
			Type = SourceObject.Type
		};
	}
}
