using System;
using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaVisualMedia
{
	public long MediaId { get; set; }

	public string InstaIdentifier { get; set; }

	public InstaMediaType MediaType { get; set; }

	public List<InstaImage> Images { get; set; } = new List<InstaImage>();


	public List<InstaVideo> Videos { get; set; } = new List<InstaVideo>();


	public string TrackingToken { get; set; }

	public int Width { get; set; }

	public int Height { get; set; }

	public DateTime UrlExpireAt { get; set; }

	public bool IsExpired => string.IsNullOrEmpty(InstaIdentifier);
}
