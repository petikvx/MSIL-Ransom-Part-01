namespace InstagramApiSharp.Classes.Models;

public class InstaStoryLocationUpload
{
	public double X { get; set; } = 0.5;


	public double Y { get; set; } = 0.5;


	public double Z { get; set; }

	public double Width { get; set; } = 0.7416667;


	public double Height { get; set; } = 0.08751394;


	public double Rotation { get; set; }

	public string LocationId { get; set; }

	public bool IsSticker { get; set; }
}
