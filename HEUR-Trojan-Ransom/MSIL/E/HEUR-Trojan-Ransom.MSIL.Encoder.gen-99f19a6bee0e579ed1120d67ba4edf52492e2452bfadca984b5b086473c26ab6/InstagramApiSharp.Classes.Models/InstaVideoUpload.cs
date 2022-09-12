using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaVideoUpload
{
	public InstaVideo Video { get; set; }

	public InstaImage VideoThumbnail { get; set; }

	public List<InstaUserTagVideoUpload> UserTags { get; set; } = new List<InstaUserTagVideoUpload>();


	public InstaVideoUpload()
	{
	}

	public InstaVideoUpload(InstaVideo video, InstaImage videoThumbnail)
	{
		Video = video;
		VideoThumbnail = videoThumbnail;
	}
}
