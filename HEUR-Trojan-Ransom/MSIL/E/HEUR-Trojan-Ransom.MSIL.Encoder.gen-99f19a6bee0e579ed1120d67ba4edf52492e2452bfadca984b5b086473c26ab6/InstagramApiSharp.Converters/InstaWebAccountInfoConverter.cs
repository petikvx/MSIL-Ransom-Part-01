using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers.Web;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaWebAccountInfoConverter : IObjectConverter<InstaWebAccountInfo, InstaWebSettingsPageResponse>
{
	public InstaWebSettingsPageResponse SourceObject { get; set; }

	public InstaWebAccountInfo Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaWebAccountInfo instaWebAccountInfo = new InstaWebAccountInfo();
		InstaWebDataResponse dateJoined = SourceObject.DateJoined;
		if (dateJoined != null)
		{
			InstaWebDataItemResponse data = dateJoined.Data;
			if (data != null && data.Timestamp.HasValue)
			{
				instaWebAccountInfo.JoinedDate = SourceObject.DateJoined?.Data?.Timestamp.Value.FromUnixTimeSeconds();
				goto IL_00a3;
			}
		}
		instaWebAccountInfo.JoinedDate = DateTime.MinValue;
		goto IL_00a3;
		IL_012d:
		return instaWebAccountInfo;
		IL_00a3:
		InstaWebDataResponse switchedToBusiness = SourceObject.SwitchedToBusiness;
		if (switchedToBusiness != null)
		{
			InstaWebDataItemResponse data2 = switchedToBusiness.Data;
			if (data2 != null && data2.Timestamp.HasValue)
			{
				instaWebAccountInfo.SwitchedToBusinessDate = SourceObject.SwitchedToBusiness?.Data?.Timestamp.Value.FromUnixTimeSeconds();
				goto IL_012d;
			}
		}
		instaWebAccountInfo.SwitchedToBusinessDate = DateTime.MinValue;
		goto IL_012d;
	}
}
