namespace InstagramApiSharp.Classes.Models;

public class InstaStorySliderUpload
{
	public double X { get; set; } = 0.5;


	public double Y { get; set; } = 0.5;


	public double Z { get; set; }

	public double Width { get; set; } = 0.7972222;


	public double Height { get; set; } = 0.21962096;


	public double Rotation { get; set; }

	public string Question { get; set; }

	public string BackgroundColor { get; set; } = "#ffffff";


	public string Emoji { get; set; } = "\ud83d\ude0d";


	public string TextColor { get; set; } = "#000000";


	public bool IsSticker { get; set; }
}
