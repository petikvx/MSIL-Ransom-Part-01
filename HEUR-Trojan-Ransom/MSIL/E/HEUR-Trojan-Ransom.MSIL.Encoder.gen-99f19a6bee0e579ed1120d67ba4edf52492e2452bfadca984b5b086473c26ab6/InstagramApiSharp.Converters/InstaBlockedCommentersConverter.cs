using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBlockedCommentersConverter : IObjectConverter<InstaUserShortList, InstaBlockedCommentersResponse>
{
	public InstaBlockedCommentersResponse SourceObject { get; set; }

	public InstaUserShortList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaUserShortList instaUserShortList = new InstaUserShortList();
		List<InstaUserShortResponse> blockedCommenters = SourceObject.BlockedCommenters;
		if (blockedCommenters != null && blockedCommenters.Count > 0)
		{
			foreach (InstaUserShortResponse blockedCommenter in SourceObject.BlockedCommenters)
			{
				instaUserShortList.Add(ConvertersFabric.Instance.GetUserShortConverter(blockedCommenter).Convert());
			}
			return instaUserShortList;
		}
		return instaUserShortList;
	}
}
