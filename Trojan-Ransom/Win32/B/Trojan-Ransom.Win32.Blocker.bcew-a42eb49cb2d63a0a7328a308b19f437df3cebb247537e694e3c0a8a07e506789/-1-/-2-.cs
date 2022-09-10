using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;

namespace _003F1_003F;

internal static class _003F2_003F
{
	private static Assembly _003F32_003F(Package _003F76_003F, string _003F77_003F)
	{
		Uri _003F81_003F = _003F6_003F._003F44_003F(_003F77_003F, UriKind.Relative);
		byte[] array;
		using (Stream stream = _003F9_003F._003F47_003F(_003F8_003F._003F46_003F(_003F76_003F, _003F81_003F)))
		{
			array = new byte[(int)_003F10_003F._003F48_003F(stream)];
			_003F11_003F._003F49_003F(stream, array, 0, array.Length);
		}
		Assembly assembly = _003F12_003F._003F50_003F(array);
		if (_003F13_003F._003F51_003F(null, assembly))
		{
			throw _003F7_003F._003F45_003F(_003F14_003F._003F52_003F((string)_003F4_003F._003F40_003F(988892848u, 2975294606u), _003F77_003F));
		}
		return assembly;
	}

	[STAThread]
	private static void _003F33_003F(string[] _003F78_003F)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			using Stream _003F81_003F = _003F17_003F._003F55_003F(_003F16_003F._003F54_003F(_003F15_003F._003F53_003F(typeof(_003F2_003F).TypeHandle)), (string)_003F4_003F._003F40_003F(931780911u, 2260301135u));
			Package val = _003F18_003F._003F56_003F(_003F81_003F, FileMode.Open, FileAccess.Read);
			try
			{
				Assembly assembly = _003F32_003F(val, (string)_003F3_003F._003F36_003F(533079952u, 3134831485u));
				_003F20_003F._003F58_003F(_003F19_003F._003F57_003F(assembly), null, new object[0]);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			_003F26_003F._003F65_003F(_003F25_003F._003F64_003F(new string[5]
			{
				_003F22_003F._003F60_003F(_003F21_003F._003F59_003F(ex)),
				_003F23_003F._003F61_003F(),
				_003F24_003F._003F62_003F(ex),
				_003F23_003F._003F61_003F(),
				_003F24_003F._003F63_003F(ex)
			}));
		}
	}
}
