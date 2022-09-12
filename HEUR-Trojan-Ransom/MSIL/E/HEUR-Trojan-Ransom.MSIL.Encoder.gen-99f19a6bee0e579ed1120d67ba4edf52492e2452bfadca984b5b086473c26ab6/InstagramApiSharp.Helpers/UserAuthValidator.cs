using System;
using InstagramApiSharp.Classes;

namespace InstagramApiSharp.Helpers;

public static class UserAuthValidator
{
	public static void Validate(UserAuthValidate userAuthValidate)
	{
		ValidateUser(userAuthValidate.User);
		ValidateLoggedIn(userAuthValidate.IsUserAuthenticated);
	}

	public static void Validate(UserSessionData user, bool isUserAuthenticated)
	{
		ValidateUser(user);
		ValidateLoggedIn(isUserAuthenticated);
	}

	private static void ValidateUser(UserSessionData user)
	{
		if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
		{
			throw new ArgumentException("user name and password must be specified");
		}
	}

	private static void ValidateLoggedIn(bool isUserAuthenticated)
	{
		if (!isUserAuthenticated)
		{
			throw new ArgumentException("user must be authenticated");
		}
	}
}
