using System.Text.RegularExpressions;

namespace XW;

public static class s6
{
	private static readonly Regex bLy;

	private static s6 gqq;

	public static bool BLf(this string string_0)
	{
		return !FXs.nJ(string_0, FXs.iXV) && yyv.nJ(bLy, string_0, yyv.nX6);
	}

	public static bool vLr(this string string_0)
	{
		return Gn.nJ(string_0, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", Gn.SXF);
	}

	static s6()
	{
		G3.nJ(G3.By);
		bLy = new Regex("^(\\{){0,1}[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}(\\}){0,1}$", RegexOptions.Compiled);
	}

	internal static bool Sqf()
	{
		return gqq == null;
	}

	internal static s6 DqM()
	{
		return gqq;
	}
}
