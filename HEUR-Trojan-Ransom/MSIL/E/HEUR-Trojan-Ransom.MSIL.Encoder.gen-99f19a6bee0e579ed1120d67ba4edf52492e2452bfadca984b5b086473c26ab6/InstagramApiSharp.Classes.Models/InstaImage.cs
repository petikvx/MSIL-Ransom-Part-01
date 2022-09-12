using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaImage
{
	public string Uri { get; set; }

	public int Width { get; set; }

	public int Height { get; set; }

	[JsonIgnore]
	public byte[] ImageBytes { get; set; }

	public InstaImage(string uri, int width, int height)
	{
		Uri = uri;
		Width = width;
		Height = height;
	}

	public InstaImage()
	{
	}
}
