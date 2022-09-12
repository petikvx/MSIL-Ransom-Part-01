using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters.Users;

internal class InstaFriendshipShortStatusListConverter : IObjectConverter<InstaFriendshipShortStatusList, InstaFriendshipShortStatusListResponse>
{
	public InstaFriendshipShortStatusListResponse SourceObject { get; set; }

	public InstaFriendshipShortStatusList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaFriendshipShortStatusList instaFriendshipShortStatusList = new InstaFriendshipShortStatusList();
		if (SourceObject != null && SourceObject.Any())
		{
			foreach (InstaFriendshipShortStatusResponse item in SourceObject)
			{
				try
				{
					InstaFriendshipShortStatus instaFriendshipShortStatus = ConvertersFabric.Instance.GetSingleFriendshipShortStatusConverter(item).Convert();
					instaFriendshipShortStatus.Pk = item.Pk;
					instaFriendshipShortStatusList.Add(instaFriendshipShortStatus);
				}
				catch
				{
				}
			}
			return instaFriendshipShortStatusList;
		}
		return instaFriendshipShortStatusList;
	}
}
