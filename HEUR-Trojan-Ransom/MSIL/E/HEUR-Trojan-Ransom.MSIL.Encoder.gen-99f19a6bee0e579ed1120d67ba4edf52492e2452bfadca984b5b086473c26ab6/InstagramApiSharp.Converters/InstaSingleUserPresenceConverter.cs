using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaSingleUserPresenceConverter : IObjectConverter<InstaUserPresence, InstaUserPresenceResponse>
{
	public InstaUserPresenceResponse SourceObject { get; set; }

	public InstaUserPresence Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaUserPresence
		{
			Pk = SourceObject.Pk,
			IsActive = SourceObject.IsActive.GetValueOrDefault(),
			LastActivity = SourceObject.LastActivityAtMs.GetValueOrDefault().FromUnixTimeMiliSeconds()
		};
	}
}
