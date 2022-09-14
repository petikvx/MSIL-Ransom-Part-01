using System;
using System.IO;
using System.Text.RegularExpressions;

namespace NuGet.Common;

public static class UAKJRvUZLr
{
	public static bool blDkKj9EYb(string UyXhKbd2Y8)
	{
		if (!j7pgOgycgl(UyXhKbd2Y8) && !_3M0JF9uk32(UyXhKbd2Y8) && !OJwFcp0D0V(UyXhKbd2Y8))
		{
			return _6GFb1GRzXy(UyXhKbd2Y8);
		}
		return true;
	}

	public static bool j7pgOgycgl(string _52CMXBFIqP)
	{
		try
		{
			if (l6BkPTcFbv.ooEPhgvzVK && !Regex.IsMatch(_52CMXBFIqP.Trim(), "^[A-Za-z]:\\\\"))
			{
				return false;
			}
			Path.GetFullPath(_52CMXBFIqP);
			return Path.IsPathRooted(_52CMXBFIqP) && !_52CMXBFIqP.StartsWith("\\\\");
		}
		catch
		{
			return false;
		}
	}

	public static bool _3M0JF9uk32(string Co6TZgW2a1)
	{
		try
		{
			Path.GetFullPath(Co6TZgW2a1);
			return Co6TZgW2a1.StartsWith("\\\\");
		}
		catch
		{
			return false;
		}
	}

	public static bool OJwFcp0D0V(string toEY4cHBeQ)
	{
		Uri result;
		if (Regex.IsMatch(toEY4cHBeQ, "^\\w+://", RegexOptions.IgnoreCase))
		{
			return Uri.TryCreate(toEY4cHBeQ, UriKind.Absolute, out result);
		}
		return false;
	}

	public static bool _6GFb1GRzXy(string uC5wb1NxAF)
	{
		try
		{
			Path.GetFullPath(uC5wb1NxAF);
			return !Regex.IsMatch(uC5wb1NxAF, "^\\w+://", RegexOptions.IgnoreCase) && !Path.IsPathRooted(uC5wb1NxAF);
		}
		catch
		{
			return false;
		}
	}
}
