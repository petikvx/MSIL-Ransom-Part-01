using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastPinUnpinConverter : IObjectConverter<InstaBroadcastPinUnpin, InstaBroadcastPinUnpinResponse>
{
	public InstaBroadcastPinUnpinResponse SourceObject { get; set; }

	public InstaBroadcastPinUnpin Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaBroadcastPinUnpin
		{
			CommentId = SourceObject.CommentId
		};
	}
}
