namespace InstagramApiSharp.Classes.Models;

public class InstaStoryQuestionUpload
{
	public double X { get; set; } = 0.5;


	public double Y { get; set; } = 0.5;


	public double Z { get; set; }

	public double Width { get; set; } = 0.9507363;


	public double Height { get; set; } = 0.32469338000000003;


	public double Rotation { get; set; }

	public bool ViewerCanInteract { get; set; } = true;


	public string BackgroundColor { get; set; } = "#ffffff";


	public string TextColor { get; set; } = "#000000";


	public string Question { get; set; }

	internal bool IsSticker { get; set; } = true;


	internal string ProfilePicture { get; set; }

	internal string QuestionType { get; set; } = "text";

}
