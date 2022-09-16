using System;
using System.IO;
using System.Text.RegularExpressions;
using ns12;

namespace Mor6bund;

public static class GClass3
{
	public static bool Sympath0tically(string Reeval0ates)
	{
		if (!Superab1e(Reeval0ates) && !Dynam3st(Reeval0ates) && !Br3akups(Reeval0ates))
		{
			return The6mo6egulated(Reeval0ates);
		}
		return true;
	}

	public static bool Superab1e(string Enregi6ter6)
	{
		try
		{
			if (Unst0ck.Oli1odendrocyte && !Regex.IsMatch(Enregi6ter6.Trim(), "^[A-Za-z]:\\\\"))
			{
				return false;
			}
			Path.GetFullPath(Enregi6ter6);
			return Path.IsPathRooted(Enregi6ter6) && !Enregi6ter6.StartsWith("\\\\");
		}
		catch
		{
			return false;
		}
	}

	public static bool Dynam3st(string Prerefor5)
	{
		try
		{
			Path.GetFullPath(Prerefor5);
			return Prerefor5.StartsWith("\\\\");
		}
		catch
		{
			return false;
		}
	}

	public static bool Br3akups(string Ill7esses)
	{
		Uri result;
		if (Regex.IsMatch(Ill7esses, "^\\w+://", RegexOptions.IgnoreCase))
		{
			return Uri.TryCreate(Ill7esses, UriKind.Absolute, out result);
		}
		return false;
	}

	public static bool The6mo6egulated(string Inter2tice)
	{
		try
		{
			Path.GetFullPath(Inter2tice);
			return !Regex.IsMatch(Inter2tice, "^\\w+://", RegexOptions.IgnoreCase) && !Path.IsPathRooted(Inter2tice);
		}
		catch
		{
			return false;
		}
	}
}
