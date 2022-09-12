using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTVChannelConverter : IObjectConverter<InstaTVChannel, InstaTVChannelResponse>
{
	public InstaTVChannelResponse SourceObject { get; set; }

	public InstaTVChannel Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaTVChannel instaTVChannel = new InstaTVChannel
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
					instaTVChannel.Items.Add(ConvertersFabric.Instance.GetSingleMediaConverter(item).Convert());
				}
				catch
				{
				}
			}
		}
		if (SourceObject.UserDetail != null)
		{
			try
			{
				instaTVChannel.UserDetail = ConvertersFabric.Instance.GetTVUserConverter(SourceObject.UserDetail).Convert();
				return instaTVChannel;
			}
			catch
			{
				return instaTVChannel;
			}
		}
		return instaTVChannel;
	}
}
