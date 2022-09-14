using System;
using System.IO;

namespace NuGet.Common;

public static class p43LEASg4o
{
	private const string _8yPs7oySq2 = "file://";

	public static Uri ibiWS7t6FE(string UHNwux1jwL, UriKind DyObFZhwr4 = UriKind.Absolute)
	{
		UHNwux1jwL = BwBOVNcteN(UHNwux1jwL);
		return new Uri(UHNwux1jwL, DyObFZhwr4);
	}

	public static Uri FPwdmEXfpR(string GXMANPMo4g, UriKind jtTolPgGKn)
	{
		GXMANPMo4g = BwBOVNcteN(GXMANPMo4g);
		if (!Uri.TryCreate(GXMANPMo4g, jtTolPgGKn, out var result))
		{
			return null;
		}
		return result;
	}

	private static string BwBOVNcteN(string Vem5BhmNnw)
	{
		if (Path.DirectorySeparatorChar == '/' && !string.IsNullOrEmpty(Vem5BhmNnw) && Vem5BhmNnw[0] == '/')
		{
			Vem5BhmNnw = "file://" + Vem5BhmNnw;
		}
		return Vem5BhmNnw;
	}

	public static string vbhRv11siY(string q6XiN27hT5)
	{
		if (!string.IsNullOrEmpty(q6XiN27hT5))
		{
			return Uri.EscapeDataString(q6XiN27hT5).Replace("'", "''").Replace("%27", "''");
		}
		return q6XiN27hT5;
	}

	public static string fIjBQF4hQg(string XVaRIfv2HG)
	{
		if (!string.IsNullOrEmpty(XVaRIfv2HG) && XVaRIfv2HG.StartsWith("file://", StringComparison.OrdinalIgnoreCase) && Uri.TryCreate(XVaRIfv2HG, UriKind.RelativeOrAbsolute, out var result))
		{
			return result.LocalPath;
		}
		return XVaRIfv2HG;
	}

	public static string x1dZpwCyTn(string Psyh9aUKPt, string zXW4R6gD9Q)
	{
		if (string.IsNullOrEmpty(Psyh9aUKPt))
		{
			return zXW4R6gD9Q;
		}
		return Pu7IHquB7C(Path.GetDirectoryName(Psyh9aUKPt), zXW4R6gD9Q);
	}

	public static string Pu7IHquB7C(string wlHqatYoKr, string D5eY3Se6pC)
	{
		if (string.IsNullOrEmpty(wlHqatYoKr) || string.IsNullOrEmpty(D5eY3Se6pC))
		{
			return D5eY3Se6pC;
		}
		string text = fIjBQF4hQg(D5eY3Se6pC);
		if (FPwdmEXfpR(text, UriKind.Relative) != null)
		{
			return Path.GetFullPath(Path.Combine(wlHqatYoKr, text));
		}
		Uri uri = FPwdmEXfpR(text, UriKind.Absolute);
		if ((object)uri != null && uri.IsFile)
		{
			return Path.GetFullPath(text);
		}
		return text;
	}
}
