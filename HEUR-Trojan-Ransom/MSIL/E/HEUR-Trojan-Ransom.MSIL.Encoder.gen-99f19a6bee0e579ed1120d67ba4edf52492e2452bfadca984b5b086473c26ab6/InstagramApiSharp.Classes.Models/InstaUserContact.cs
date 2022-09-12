namespace InstagramApiSharp.Classes.Models;

public class InstaUserContact : InstaUserShort
{
	public string ExtraDisplayName { get; set; }

	public bool HasExtraInfo => !string.IsNullOrEmpty(ExtraDisplayName);
}
