using System;
using System.IO;

namespace Re3ill;

public static class Unignorabl2
{
	private const string Dermatophyte0 = "file://";

	public static Uri S7pphic(string Bawd0, UriKind Ref5geeism = UriKind.Absolute)
	{
		Bawd0 = Madd0r(Bawd0);
		return new Uri(Bawd0, Ref5geeism);
	}

	public static Uri T1opins(string C1rbor1s, UriKind Engul3ments)
	{
		C1rbor1s = Madd0r(C1rbor1s);
		if (!Uri.TryCreate(C1rbor1s, Engul3ments, out var result))
		{
			return null;
		}
		return result;
	}

	private static string Madd0r(string S2oulders)
	{
		if (Path.DirectorySeparatorChar == '/' && !string.IsNullOrEmpty(S2oulders) && S2oulders[0] == '/')
		{
			S2oulders = "file://" + S2oulders;
		}
		return S2oulders;
	}

	public static string Mu6tiva6ents(string Abs4rac4)
	{
		if (!string.IsNullOrEmpty(Abs4rac4))
		{
			return Uri.EscapeDataString(Abs4rac4).Replace("'", "''").Replace("%27", "''");
		}
		return Abs4rac4;
	}

	public static string Instructi5e(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0) && string_0.StartsWith("file://", StringComparison.OrdinalIgnoreCase) && Uri.TryCreate(string_0, UriKind.RelativeOrAbsolute, out var result))
		{
			return result.LocalPath;
		}
		return string_0;
	}

	public static string Aff6xat6ons(string X5b5cs, string Beglam5rs)
	{
		if (string.IsNullOrEmpty(X5b5cs))
		{
			return Beglam5rs;
		}
		return Helmint7s(Path.GetDirectoryName(X5b5cs), Beglam5rs);
	}

	public static string Helmint7s(string Cru6tine66, string Mind2dn2ss)
	{
		if (!string.IsNullOrEmpty(Cru6tine66) && !string.IsNullOrEmpty(Mind2dn2ss))
		{
			string text = Instructi5e(Mind2dn2ss);
			if (T1opins(text, UriKind.Relative) != null)
			{
				return Path.GetFullPath(Path.Combine(Cru6tine66, text));
			}
			Uri uri = T1opins(text, UriKind.Absolute);
			if ((object)uri != null && uri.IsFile)
			{
				return Path.GetFullPath(text);
			}
			return text;
		}
		return Mind2dn2ss;
	}
}
