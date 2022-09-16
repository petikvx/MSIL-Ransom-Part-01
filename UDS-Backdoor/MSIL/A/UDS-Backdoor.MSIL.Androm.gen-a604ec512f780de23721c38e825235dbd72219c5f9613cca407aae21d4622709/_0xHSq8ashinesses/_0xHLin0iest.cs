using System.Globalization;
using _0xHPuls0s;

namespace _0xHSq8ashinesses;

internal sealed class _0xHLin0iest : _0xHFa0ci0t
{
	private static _0xHLin0iest _0xHFetop4otein = new _0xHLin0iest();

	protected override string _0xHSu1dered => string.Format(CultureInfo.InvariantCulture, "{0}\\Microsoft\\Windows Azure Tools for Microsoft Visual Studio\\{1}\\IaaSExtensions", "Software", "16.0");

	protected override string _0xHK3r3tes => string.Format(CultureInfo.InvariantCulture, "{0}\\Microsoft\\Windows Azure Tools for Microsoft Visual Studio\\{1}\\IaaSExtensions", "Software\\Wow6432Node", "16.0");

	private _0xHLin0iest()
	{
	}

	public static string _0xHSweatsh5p(string _0xHAsthen7c, string _0xHPlat22n, string _0xHPea3hers)
	{
		return _0xHFetop4otein._0xHApprisi2g(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}\\{2}", _0xHAsthen7c, _0xHPlat22n, _0xHPea3hers), "OverrideWithVersion", _0xHPea3hers);
	}

	public static string _0xHBat7s(string _0xHSanct0mon0ously, string _0xHP7incock, string _0xHP2nks)
	{
		return _0xHFetop4otein._0xHApprisi2g(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}\\{2}", _0xHSanct0mon0ously, _0xHP7incock, _0xHP2nks), "OverrideWithPublisher", _0xHSanct0mon0ously);
	}

	public static bool _0xH8umper(string _0xHDebeake0, string _0xHTheosophis0, string _0xHRadiophon4s, string _0xHJoin2ured)
	{
		if (string.Equals(_0xHFetop4otein._0xHApprisi2g(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}\\{2}", _0xHTheosophis0, _0xHRadiophon4s, _0xHJoin2ured), _0xHDebeake0, "false"), "true"))
		{
			return true;
		}
		return false;
	}
}
