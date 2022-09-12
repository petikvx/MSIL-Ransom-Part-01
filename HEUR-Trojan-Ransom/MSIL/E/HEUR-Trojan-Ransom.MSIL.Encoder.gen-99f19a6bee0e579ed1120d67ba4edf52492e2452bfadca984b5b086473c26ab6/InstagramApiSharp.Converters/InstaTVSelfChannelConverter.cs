using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTVSelfChannelConverter : IObjectConverter<InstaTVSelfChannel, InstaTVSelfChannelResponse>
{
	public InstaTVSelfChannelResponse SourceObject { get; set; }

	public InstaTVSelfChannel Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaTVSelfChannel instaTVSelfChannel = new InstaTVSelfChannel
		{
			HasMoreAvailable = SourceObject.HasMoreAvailable,
			Id = SourceObject.Id,
			MaxId = SourceObject.MaxId,
			Title = SourceObject.Title,
			Type = SourceObject.Type
		};
		if (SourceObject.Items != null && SourceObject.Items.Any())
		{
			foreach (InstaMediaItemResponse item in SourceObject.Items)
			{
				try
				{
					instaTVSelfChannel.Items.Add(ConvertersFabric.Instance.GetSingleMediaConverter(item).Convert());
				}
				catch
				{
				}
			}
		}
		if (SourceObject.User != null)
		{
			try
			{
				instaTVSelfChannel.User = ConvertersFabric.Instance.GetTVUserConverter(SourceObject.User).Convert();
				return instaTVSelfChannel;
			}
			catch
			{
				return instaTVSelfChannel;
			}
		}
		return instaTVSelfChannel;
	}
}
