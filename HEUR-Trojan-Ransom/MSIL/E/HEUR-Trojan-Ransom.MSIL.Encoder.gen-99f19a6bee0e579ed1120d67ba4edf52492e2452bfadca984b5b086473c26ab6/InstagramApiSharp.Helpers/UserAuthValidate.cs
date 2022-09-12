using InstagramApiSharp.Classes;

namespace InstagramApiSharp.Helpers;

public class UserAuthValidate
{
	public bool IsUserAuthenticated { get; internal set; }

	public UserSessionData User { get; internal set; }
}
