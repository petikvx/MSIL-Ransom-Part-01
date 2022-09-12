using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaPresenceConverter : IObjectConverter<InstaPresence, InstaPresenceResponse>
{
	public InstaPresenceResponse SourceObject { get; set; }

	public InstaPresence Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		return new InstaPresence
		{
			PresenceDisabled = SourceObject.Disabled.GetValueOrDefault(),
			ThreadPresenceDisabled = SourceObject.ThreadPresenceDisabled.GetValueOrDefault()
		};
	}
}
