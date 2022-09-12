using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTVConverter : IObjectConverter<InstaTV, InstaTVResponse>
{
	public InstaTVResponse SourceObject { get; set; }

	public InstaTV Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaTV instaTV = new InstaTV
		{
			Status = SourceObject.Status
		};
		if (SourceObject.MyChannel != null)
		{
			try
			{
				instaTV.MyChannel = ConvertersFabric.Instance.GetTVSelfChannelConverter(SourceObject.MyChannel).Convert();
			}
			catch
			{
			}
		}
		if (SourceObject.Channels != null && SourceObject.Channels.Any())
		{
			foreach (InstaTVChannelResponse channel in SourceObject.Channels)
			{
				try
				{
					instaTV.Channels.Add(ConvertersFabric.Instance.GetTVChannelConverter(channel).Convert());
				}
				catch
				{
				}
			}
			return instaTV;
		}
		return instaTV;
	}
}
