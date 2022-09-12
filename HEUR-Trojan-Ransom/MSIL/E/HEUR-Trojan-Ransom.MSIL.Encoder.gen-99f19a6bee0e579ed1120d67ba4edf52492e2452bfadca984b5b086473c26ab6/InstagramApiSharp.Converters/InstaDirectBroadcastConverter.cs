using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaDirectBroadcastConverter : IObjectConverter<InstaDirectBroadcast, InstaDirectBroadcastResponse>
{
	public InstaDirectBroadcastResponse SourceObject { get; set; }

	public InstaDirectBroadcast Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaDirectBroadcast
		{
			Broadcast = SourceObject.Broadcast,
			Text = SourceObject.Text,
			IsLinked = SourceObject.IsLinked.GetValueOrDefault(),
			Message = SourceObject.Message,
			Title = SourceObject.Title
		};
	}
}
