using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaUserContactListConverter : IObjectConverter<InstaContactUserList, InstaContactUserListResponse>
{
	public InstaContactUserListResponse SourceObject { get; set; }

	public InstaContactUserList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaContactUserList instaContactUserList = new InstaContactUserList();
		try
		{
			foreach (InstaContactUserResponse item in SourceObject.Items)
			{
				try
				{
					instaContactUserList.Add(ConvertersFabric.Instance.GetSingleUserContactConverter(item.User).Convert());
				}
				catch
				{
				}
			}
			return instaContactUserList;
		}
		catch
		{
			return instaContactUserList;
		}
	}
}
