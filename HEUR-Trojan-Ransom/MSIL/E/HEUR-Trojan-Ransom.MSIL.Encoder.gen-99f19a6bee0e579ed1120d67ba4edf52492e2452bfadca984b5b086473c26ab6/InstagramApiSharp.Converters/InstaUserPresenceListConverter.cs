using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaUserPresenceListConverter : IObjectConverter<InstaUserPresenceList, InstaUserPresenceContainerResponse>
{
	public InstaUserPresenceContainerResponse SourceObject { get; set; }

	public InstaUserPresenceList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaUserPresenceList instaUserPresenceList = new InstaUserPresenceList();
		if (SourceObject.Items != null && SourceObject.Items.Any())
		{
			foreach (InstaUserPresenceResponse item in SourceObject.Items)
			{
				try
				{
					instaUserPresenceList.Add(ConvertersFabric.Instance.GetSingleUserPresenceConverter(item).Convert());
				}
				catch
				{
				}
			}
			return instaUserPresenceList;
		}
		return instaUserPresenceList;
	}
}
