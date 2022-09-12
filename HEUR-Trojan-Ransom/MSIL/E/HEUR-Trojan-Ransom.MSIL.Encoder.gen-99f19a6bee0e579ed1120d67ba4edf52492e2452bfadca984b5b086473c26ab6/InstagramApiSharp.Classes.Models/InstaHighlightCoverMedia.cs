namespace InstagramApiSharp.Classes.Models;

public class InstaHighlightCoverMedia
{
	public InstaImage CroppedImage { get; set; }

	public float[] CropRect { get; set; }

	public string MediaId { get; set; }

	public InstaImage Image { get; set; }
}
