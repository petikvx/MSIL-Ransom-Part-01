namespace InstagramApiSharp.Classes.Models;

public class InstaAlbumUpload
{
	public InstaImageUpload ImageToUpload { get; set; }

	public InstaVideoUpload VideoToUpload { get; set; }

	internal bool IsImage => ImageToUpload != null;

	internal bool IsVideo => VideoToUpload != null;

	internal bool IsBoth
	{
		get
		{
			if (ImageToUpload != null)
			{
				return VideoToUpload != null;
			}
			return false;
		}
	}
}
