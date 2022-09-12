using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastStartConverter : IObjectConverter<InstaBroadcastStart, InstaBroadcastStartResponse>
{
	public InstaBroadcastStartResponse SourceObject { get; set; }

	public InstaBroadcastStart Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaBroadcastStart
		{
			MediaId = SourceObject.MediaId
		};
	}
}
