using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using _0xHConjug8tion8l;

namespace _0xHGree4some;

public class _0xHBipar5i5e : IValueConverter
{
	public _0xHPerman4anate _0xHArra7gers { get; set; }

	public _0xHBipar5i5e()
	{
		_0xHArra7gers = _0xHPerman4anate.Collapsed;
	}

	public _0xHBipar5i5e(_0xHPerman4anate falseToVisibility)
	{
		_0xHArra7gers = falseToVisibility;
	}

	public object _0xH8urgers(object _0xHSq3alled, Type _0xHC7cc7liths, object _0xHArter1es, CultureInfo _0xHNon8mphatic)
	{
		if ((_0xHSq3alled is bool) ? ((bool)_0xHSq3alled) : ((bool)(dynamic)_0xHSq3alled))
		{
			return (object)(Visibility)0;
		}
		return (object)(Visibility)((_0xHArra7gers != _0xHPerman4anate.Collapsed) ? 1 : 2);
	}

	public object _0xHDysp2ptically(object _0xH6ocker, Type _0xHE77atics, object _0xHImi1es, CultureInfo _0xHC7as7l7ssn7ss)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		return (int)(Visibility)_0xH6ocker == 0;
	}
}
