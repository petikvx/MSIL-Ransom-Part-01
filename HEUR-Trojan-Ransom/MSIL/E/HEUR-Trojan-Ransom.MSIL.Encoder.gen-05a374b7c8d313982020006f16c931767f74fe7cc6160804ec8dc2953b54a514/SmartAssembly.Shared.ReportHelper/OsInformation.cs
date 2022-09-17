using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0023M;
using _0023P;
using _0023ab;

namespace SmartAssembly.Shared.ReportHelper;

public static class OsInformation
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _0096_0010_008F_0006
	{
		public string _0001;

		public int _0002;
	}

	internal static string _0095_0003_009E_0006(Version P_0)
	{
		bool flag = OsVersionInformation._0012_0013_009B();
		bool flag2 = OsVersionInformation.IsX64;
		switch (P_0.Major)
		{
		case 5:
			switch (P_0.Minor)
			{
			case 0:
				return _00239._00237(107396056);
			case 1:
				return _00239._00237(107396007);
			case 2:
				if (!(flag && flag2))
				{
					return _00239._00237(107396022);
				}
				return _00239._00237(107395993);
			}
			break;
		case 6:
			switch (P_0.Minor)
			{
			case 0:
				if (!flag)
				{
					return _00239._00237(107395956);
				}
				return _00239._00237(107395927);
			case 1:
				if (!flag)
				{
					return _00239._00237(107395874);
				}
				return _00239._00237(107395841);
			case 2:
				if (!flag)
				{
					return _00239._00237(107395860);
				}
				return _00239._00237(107395319);
			case 3:
				if (!flag)
				{
					return _00239._00237(107395274);
				}
				return _00239._00237(107395241);
			case 4:
				return _00239._00237(107395256);
			}
			break;
		case 10:
			if (P_0.Minor != 0)
			{
				break;
			}
			if (!flag)
			{
				if (P_0.Build < 17623)
				{
					return _00239._00237(107395207);
				}
				return _00239._00237(107395178);
			}
			return _00239._00237(107395256);
		}
		return string.Format(_00239._00237(107395149), P_0.Major, P_0.Minor, P_0.Build, P_0.Revision);
	}

	internal static _0023L _0096_0003_009E_0006()
	{
		return _0023L._0023a;
	}

	internal static Version _0011_009A_000F_0003(_0023L P_0, Version P_1)
	{
		return _0096_0095_008D_0003(P_1);
	}

	private static Version _0096_0095_008D_0003(Version P_0)
	{
		try
		{
			if (!(P_0 >= new Version(6, 2)))
			{
				if (P_0.Major != 0)
				{
					return P_0;
				}
				if (P_0.Minor != 0)
				{
					return P_0;
				}
			}
			_00233 _0023Z;
			using _0023V _0023V = _0023_0023._0023Uh(_0023O._0023c, _00234._0023a, _00232._0023a, _00239._00237(107395116), out _0023Z) ?? _0023_0023._0023Uh(_0023O._0023c, _00234._0023a, _00232._0023a, _00239._00237(107395567), out _0023Z);
			if (_0023Z == _00233._0023c)
			{
				int major = 0;
				int minor = 0;
				int build = 0;
				int revision = 0;
				object _0023z3;
				if (_0023V._0023T(_00239._00237(107395490), out var _0023z) && _0023V._0023T(_00239._00237(107395485), out var _0023z2))
				{
					if (_0023z is int num)
					{
						major = num;
					}
					if (_0023z2 is int num2)
					{
						minor = num2;
					}
				}
				else if (_0023V._0023T(_00239._00237(107395448), out _0023z3) && _0023z3 is string text)
				{
					Version version = _0097_0006_0006_0002(text);
					major = version.Major;
					minor = version.Minor;
				}
				if (_0023V._0023T(_00239._00237(107395395), out var _0023z4) && _0023z4 is string text2)
				{
					build = _0097_0006_0006_0002(text2).Major;
				}
				if (_0023V._0023T(_00239._00237(107395370), out var _0023z5) && _0023z5 is int num3)
				{
					revision = num3;
				}
				return new Version(major, minor, build, revision);
			}
			return P_0;
		}
		catch
		{
			return P_0;
		}
	}

	private static Version _0097_0006_0006_0002(string P_0)
	{
		_0096_0010_008F_0006 obj = default(_0096_0010_008F_0006);
		obj._0001 = P_0;
		obj._0002 = 0;
		int[] array = new int[4];
		for (int i = 0; i < 4; i++)
		{
			_0097_0003_009E_0006(ref obj);
			int num = _0098_0003_009E_0006(ref obj);
			if (num == 0)
			{
				break;
			}
			if (int.TryParse(obj._0001.Substring(obj._0002, num), out var result))
			{
				array[i] = result;
			}
			obj._0002 += num;
		}
		return new Version(array[0], array[1], array[2], array[3]);
	}

	[CompilerGenerated]
	internal static void _0097_0003_009E_0006(ref _0096_0010_008F_0006 P_0)
	{
		while (P_0._0002 < P_0._0001.Length && !char.IsNumber(P_0._0001[P_0._0002]))
		{
			P_0._0002++;
		}
	}

	[CompilerGenerated]
	internal static int _0098_0003_009E_0006(ref _0096_0010_008F_0006 P_0)
	{
		int i;
		for (i = P_0._0002; i < P_0._0001.Length && char.IsNumber(P_0._0001[i]); i++)
		{
		}
		return i - P_0._0002;
	}
}
