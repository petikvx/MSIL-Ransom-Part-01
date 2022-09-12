using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaVideo
{
	public string Uri { get; set; }

	public int Width { get; set; }

	public int Height { get; set; }

	public int Type { get; set; }

	internal string UploadId { get; set; }

	public double Length { get; set; }

	[JsonIgnore]
	public byte[] VideoBytes { get; set; }

	public InstaVideo()
	{
	}

	public InstaVideo(string url, int width, int height)
		: this(url, width, height, 3)
	{
	}

	public InstaVideo(string url, int width, int height, int type)
	{
		Uri = url;
		Width = width;
		Height = height;
		Type = type;
	}
}
