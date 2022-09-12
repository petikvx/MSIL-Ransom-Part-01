using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaStoryQuestionResponder
{
	public string ResponseText { get; set; }

	public bool HasSharedResponse { get; set; }

	public long Id { get; set; }

	public InstaUserShort User { get; set; }

	public DateTime Time { get; set; }
}
