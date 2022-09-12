namespace InstagramApiSharp.Classes.Models;

public class InstaAnimatedImage
{
	public string Id { get; set; }

	public InstaAnimatedImageMedia Media { get; set; }

	public bool IsRandom { get; set; }

	public bool IsSticker { get; set; }

	public InstaAnimatedImageUser User { get; set; }
}
