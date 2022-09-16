using System;
using System.Management;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

public static class GClass46
{
	[CompilerGenerated]
	private static string string_0;

	[CompilerGenerated]
	private static string string_1;

	[CompilerGenerated]
	private static bool bool_0;

	[CompilerGenerated]
	private static bool bool_1;

	[CompilerGenerated]
	private static bool bool_2;

	[CompilerGenerated]
	private static bool bool_3;

	[CompilerGenerated]
	private static bool bool_4;

	[CompilerGenerated]
	private static bool bool_5;

	[CompilerGenerated]
	private static bool bool_6;

	[CompilerGenerated]
	private static bool bool_7;

	[CompilerGenerated]
	private static bool bool_8;

	internal static GClass46 HF7qSx4yN9RYZs6aiAk;

	public static string FullName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool Is64Bit
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool RunningOnMono
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool Win32NT
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool XpOrHigher
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool VistaOrHigher
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool SevenOrHigher
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool EightOrHigher
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool EightPointOneOrHigher
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool TenOrHigher
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	static GClass46()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		xdRLOg4Vv5X5c023kU3();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		Jf60nq4MuPssfV0DQHf();
		Win32NT = P1WXHt4tG5lS5SjZ1hs(Environment.OSVersion) == PlatformID.Win32NT;
		SNPyXY4eWRdaR1DRLHL(y0uJQm4UA7XFSckG90m() && ((Version)hXDrFR4PmXGnDi9QFvO(s4OUvC4THWFNmWMEhPs())).Major >= 5);
		hIdaIO42PVVAQhZKoVV(Win32NT && ((Version)hXDrFR4PmXGnDi9QFvO(Environment.OSVersion)).Major >= 6);
		QusbIA4KxrqfGgMUZUH(Win32NT && ADYbuj40lAqgJw4YF4b(hXDrFR4PmXGnDi9QFvO(s4OUvC4THWFNmWMEhPs()), new Version(6, 1)));
		dTiShn4BHFhUVq4HQoT(y0uJQm4UA7XFSckG90m() && ADYbuj40lAqgJw4YF4b(((OperatingSystem)s4OUvC4THWFNmWMEhPs()).Version, new Version(6, 2, 9200)));
		L3X2TD4Nv0pLWtYfTFI(y0uJQm4UA7XFSckG90m() && Environment.OSVersion.Version >= new Version(6, 3));
		TenOrHigher = y0uJQm4UA7XFSckG90m() && ADYbuj40lAqgJw4YF4b(hXDrFR4PmXGnDi9QFvO(s4OUvC4THWFNmWMEhPs()), new Version(10, 0));
		eQCAQd4sZR4tBeWE3x6(OAVsCT4jw2AV8RKhGg3(eBSnCM4QbZRIObpjwf2(XgccGu4ZRx7H817T6Lr(13782)), null));
		Name = (string)XgccGu4ZRx7H817T6Lr(13810);
		ManagementObjectSearcher val = new ManagementObjectSearcher(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(13834));
		try
		{
			ManagementObjectEnumerator val2 = (ManagementObjectEnumerator)LOO4OK4dEyoIprkV9Fa(val.Get());
			try
			{
				if (vJcWR143pHL40viR8HZ(val2))
				{
					yagLqS4AajXvk48Ydwr(((ManagementBaseObject)(ManagementObject)val2.get_Current()).get_Item((string)XgccGu4ZRx7H817T6Lr(13920)).ToString());
				}
			}
			finally
			{
				if (val2 != null)
				{
					NGBtWn417Kutsf0V1G3(val2);
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		yagLqS4AajXvk48Ydwr(((string)ImORAu4bZ5TYCs6fWGZ(o45yU14qmoMCt8hdFES(Name, XgccGu4ZRx7H817T6Lr(13938), ""), new char[0])).TrimStart(new char[0]));
		XbxSwg4ucEjwUA9WBVH(ku6ILG47cOU1cx2F4gQ());
		KvTmCthF9qdgggjBqMd(string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(13970), Name, Qb4WSS4z1WDqw35BCgP() ? 64 : 32));
	}

	internal static void xdRLOg4Vv5X5c023kU3()
	{
	}

	internal static void Jf60nq4MuPssfV0DQHf()
	{
	}

	internal static PlatformID P1WXHt4tG5lS5SjZ1hs(object object_0)
	{
		return (PlatformID)(object)null;
	}

	internal static bool y0uJQm4UA7XFSckG90m()
	{
		return true;
	}

	internal static object s4OUvC4THWFNmWMEhPs()
	{
		return null;
	}

	internal static object hXDrFR4PmXGnDi9QFvO(object object_0)
	{
		return null;
	}

	internal static void SNPyXY4eWRdaR1DRLHL(bool value)
	{
	}

	internal static void hIdaIO42PVVAQhZKoVV(bool value)
	{
	}

	internal static bool ADYbuj40lAqgJw4YF4b(object object_0, object object_1)
	{
		return true;
	}

	internal static void QusbIA4KxrqfGgMUZUH(bool value)
	{
	}

	internal static void dTiShn4BHFhUVq4HQoT(bool value)
	{
	}

	internal static void L3X2TD4Nv0pLWtYfTFI(bool value)
	{
	}

	internal static object XgccGu4ZRx7H817T6Lr(int int_0)
	{
		return null;
	}

	internal static Type eBSnCM4QbZRIObpjwf2(object object_0)
	{
		return null;
	}

	internal static bool OAVsCT4jw2AV8RKhGg3(Type type_0, Type type_1)
	{
		return true;
	}

	internal static void eQCAQd4sZR4tBeWE3x6(bool value)
	{
	}

	internal static object LOO4OK4dEyoIprkV9Fa(object object_0)
	{
		return null;
	}

	internal static void yagLqS4AajXvk48Ydwr(object object_0)
	{
	}

	internal static bool vJcWR143pHL40viR8HZ(object object_0)
	{
		return true;
	}

	internal static void NGBtWn417Kutsf0V1G3(object object_0)
	{
	}

	internal static object o45yU14qmoMCt8hdFES(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static object ImORAu4bZ5TYCs6fWGZ(object object_0, object object_1)
	{
		return null;
	}

	internal static bool ku6ILG47cOU1cx2F4gQ()
	{
		return true;
	}

	internal static void XbxSwg4ucEjwUA9WBVH(bool value)
	{
	}

	internal static bool Qb4WSS4z1WDqw35BCgP()
	{
		return true;
	}

	internal static void KvTmCthF9qdgggjBqMd(object object_0)
	{
	}

	internal static bool B0PxcP4lPMAZ6HMTt8F()
	{
		return true;
	}

	internal static GClass46 cd3BDn4HfgkVtR40kjC()
	{
		return null;
	}
}
