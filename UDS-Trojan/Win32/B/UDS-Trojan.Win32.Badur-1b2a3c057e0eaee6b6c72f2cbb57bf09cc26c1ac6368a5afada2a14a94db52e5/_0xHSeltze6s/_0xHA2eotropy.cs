using System;
using System.Resources;
using _0xHPul5erize;

namespace _0xHSeltze6s;

internal static class _0xHA2eotropy
{
	public static readonly string _0xHSubrouti0es = Environment.NewLine;

	private static ResourceManager _0xH3pgrades = new ResourceManager("Microsoft.Diagnostics.Tracing.Messages", typeof(_0xHA2eotropy)._0xHM0n0ge());

	public static int _0xHFactorizi0g => Environment.TickCount;

	public static string _0xHSpon8or(string _0xHUnformulat1d, params object[] _0xHPuree0)
	{
		string @string = _0xH3pgrades.GetString(_0xHUnformulat1d);
		if (@string != null)
		{
			return string.Format(@string, _0xHPuree0);
		}
		string text = string.Empty;
		foreach (object obj in _0xHPuree0)
		{
			if (text != string.Empty)
			{
				text += ", ";
			}
			text += obj.ToString();
		}
		return _0xHUnformulat1d + " (" + text + ")";
	}

	public static string _0xHAlluvi0n(string _0xHExp4ndors, params object[] _0xHToot0e0)
	{
		return _0xHSpon8or(_0xHExp4ndors, _0xHToot0e0);
	}
}
