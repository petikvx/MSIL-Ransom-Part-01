using System;
using System.Collections.Generic;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Classes.Models;

public class InstaVisualMediaContainer
{
	public DateTime UrlExpireAt { get; set; }

	public InstaVisualMedia Media { get; set; }

	public int? SeenCount { get; set; }

	public DateTime ReplayExpiringAtUs { get; set; }

	public InstaViewMode ViewMode { get; set; }

	public List<long> SeenUserIds { get; set; } = new List<long>();


	public bool IsExpired
	{
		get
		{
			if (Media != null)
			{
				return Media.IsExpired;
			}
			return false;
		}
	}
}
