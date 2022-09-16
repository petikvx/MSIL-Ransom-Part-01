using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using _0xHAn5vulat5ry;

namespace _0xHAdo0tees;

public class _0xHLira2 : IValueConverter
{
	public _0xH7verlapping _0xHT00ls { get; set; }

	public _0xHLira2()
	{
		_0xHT00ls = _0xH7verlapping.Collapsed;
	}

	public _0xHLira2(_0xH7verlapping falseToVisibility)
	{
		_0xHT00ls = falseToVisibility;
	}

	public object _0xHT4torage(object _0xHCogenera5ors, Type _0xHEmplanin5, object _0xHUn5omanticized, CultureInfo _0xH0rocures)
	{
		if ((_0xHCogenera5ors is bool) ? ((bool)_0xHCogenera5ors) : ((bool)(dynamic)_0xHCogenera5ors))
		{
			return (object)(Visibility)0;
		}
		return (object)(Visibility)((_0xHT00ls != _0xH7verlapping.Collapsed) ? 1 : 2);
	}

	public object _0xHEuryth7rmal(object _0xHPriva8dozen8, Type _0xHMongolis6s, object _0xHI88itato8, CultureInfo _0xHRes2auran2eur)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		return (int)(Visibility)_0xHPriva8dozen8 == 0;
	}
}
