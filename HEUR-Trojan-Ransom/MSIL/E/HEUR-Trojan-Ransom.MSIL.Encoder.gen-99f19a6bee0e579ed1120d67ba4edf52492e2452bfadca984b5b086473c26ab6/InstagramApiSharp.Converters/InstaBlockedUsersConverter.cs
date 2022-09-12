using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBlockedUsersConverter : IObjectConverter<InstaBlockedUsers, InstaBlockedUsersResponse>
{
	public InstaBlockedUsersResponse SourceObject { get; set; }

	public InstaBlockedUsers Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaBlockedUsers instaBlockedUsers = new InstaBlockedUsers
		{
			MaxId = SourceObject.MaxId
		};
		if (SourceObject.BlockedList != null && SourceObject.BlockedList.Any())
		{
			foreach (InstaBlockedUserInfoResponse blocked in SourceObject.BlockedList)
			{
				instaBlockedUsers.BlockedList.Add(ConvertersFabric.Instance.GetBlockedUserInfoConverter(blocked).Convert());
			}
			return instaBlockedUsers;
		}
		return instaBlockedUsers;
	}
}
