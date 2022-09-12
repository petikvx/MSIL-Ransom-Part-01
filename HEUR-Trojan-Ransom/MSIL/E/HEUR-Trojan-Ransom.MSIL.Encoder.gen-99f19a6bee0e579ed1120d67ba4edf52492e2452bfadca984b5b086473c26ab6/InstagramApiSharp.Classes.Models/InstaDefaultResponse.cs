namespace InstagramApiSharp.Classes.Models;

internal class InstaDefaultResponse : InstaDefault
{
	public bool IsSucceed => base.Status.ToLower() == "ok";
}
