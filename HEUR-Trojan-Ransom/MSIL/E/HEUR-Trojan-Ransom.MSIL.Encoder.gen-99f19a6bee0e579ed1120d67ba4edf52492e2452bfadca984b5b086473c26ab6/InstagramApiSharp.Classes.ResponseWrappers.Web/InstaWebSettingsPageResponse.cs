using System;
using InstagramApiSharp.Enums;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Web;

public class InstaWebSettingsPageResponse
{
	[JsonProperty("is_blocked")]
	public bool? IsBlocked { get; set; }

	[JsonProperty("page_name")]
	public string PageName { get; set; }

	internal InstaWebType PageType
	{
		get
		{
			if (string.IsNullOrEmpty(PageName))
			{
				return InstaWebType.Unknown;
			}
			try
			{
				string value = PageName.Replace("_", "");
				return (InstaWebType)Enum.Parse(typeof(InstaWebType), value, ignoreCase: true);
			}
			catch
			{
			}
			return InstaWebType.Unknown;
		}
	}

	[JsonProperty("date_joined")]
	public InstaWebDataResponse DateJoined { get; set; }

	[JsonProperty("switched_to_business")]
	public InstaWebDataResponse SwitchedToBusiness { get; set; }

	[JsonProperty("data")]
	public InstaWebDataListResponse Data { get; set; }
}
