using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaImageUpload
{
	public string Uri { get; set; }

	public int Width { get; set; }

	public int Height { get; set; }

	public byte[] ImageBytes { get; set; }

	public List<InstaUserTagUpload> UserTags { get; set; } = new List<InstaUserTagUpload>();


	public InstaImageUpload()
	{
	}

	public InstaImageUpload(string uri, int width = 0, int height = 0)
	{
		Uri = uri;
		Width = width;
		Height = height;
	}
}
