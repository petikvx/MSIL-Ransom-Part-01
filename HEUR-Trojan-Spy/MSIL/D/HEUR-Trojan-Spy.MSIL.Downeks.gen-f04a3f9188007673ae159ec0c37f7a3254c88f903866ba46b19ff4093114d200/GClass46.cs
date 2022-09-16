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

	internal static GClass46 xtOQkn19BLXnng5gCyi;

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
		//IL_0176: Expected O, but got Unknown
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		MBIISy1zKC0dJeIaAVy();
		aifUtfIbj556C5q8xg3();
		MwY5IWI4dEIhr0oCl1a();
		Win32NT = ((OperatingSystem)rubeOyIns2UF5UXnFiP()).Platform == PlatformID.Win32NT;
		XpOrHigher = Win32NT && ((Version)g2hoLbIUCbhTYGmrgKd(rubeOyIns2UF5UXnFiP())).Major >= 5;
		xKvApsIjTqSOO3vYQqF(UjcmY7ILlFQhlbihamU() && OsMOdcINUJ8NwlMJvLL(g2hoLbIUCbhTYGmrgKd(rubeOyIns2UF5UXnFiP())) >= 6);
		DmuMUFIM079vixn3V8A(UjcmY7ILlFQhlbihamU() && qsDP8qIanpGCLf39IJW(g2hoLbIUCbhTYGmrgKd(rubeOyIns2UF5UXnFiP()), new Version(6, 1)));
		EightOrHigher = UjcmY7ILlFQhlbihamU() && qsDP8qIanpGCLf39IJW(g2hoLbIUCbhTYGmrgKd(rubeOyIns2UF5UXnFiP()), new Version(6, 2, 9200));
		E1KGnmIqVCiB7bMgtAA(UjcmY7ILlFQhlbihamU() && qsDP8qIanpGCLf39IJW(g2hoLbIUCbhTYGmrgKd(rubeOyIns2UF5UXnFiP()), new Version(6, 3)));
		HommbsIeoUMGaLWFl8G(Win32NT && qsDP8qIanpGCLf39IJW(g2hoLbIUCbhTYGmrgKd(rubeOyIns2UF5UXnFiP()), new Version(10, 0)));
		RunningOnMono = WXfX6AI7BwnWDXpghcr(YPWOWIIgumBsUiVfaN2(uO3bvpIXx0L4aNkPVv8(13782)), null);
		ol0WwMISDjtc0uLkh9H(uO3bvpIXx0L4aNkPVv8(13810));
		ManagementObjectSearcher val = new ManagementObjectSearcher(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(13834));
		try
		{
			ManagementObjectEnumerator val2 = (ManagementObjectEnumerator)YMsRaKIvdsKBqHJdZED(N5hDttI3BxR4V3QTHfo(val));
			try
			{
				if (val2.MoveNext())
				{
					ol0WwMISDjtc0uLkh9H(vKSym8Iyub3FiMWcsVN((object)(ManagementObject)val2.get_Current(), uO3bvpIXx0L4aNkPVv8(13920)).ToString());
				}
			}
			finally
			{
				if (val2 != null)
				{
					fLZLTBIP3IYjZ79MFJm(val2);
				}
			}
		}
		finally
		{
			if (val != null)
			{
				fLZLTBIP3IYjZ79MFJm(val);
			}
		}
		Name = (string)dbPQX3Iw0NYGF2KLvg0(LV8kwDIE0jZMiFfKwtp(FNuoOhIFNdajSwtA5Qr(jiqO3kIV2UdIPBgJ8VW(), uO3bvpIXx0L4aNkPVv8(13938), ""), new char[0]), new char[0]);
		DlWtNSIm8uoNRAhCKUC(Environment.Is64BitOperatingSystem);
		yOE9MPItfBg7rJnEdsa(string.Format((string)uO3bvpIXx0L4aNkPVv8(13970), Name, (!NOwrg3I2lJRxsySqaBK()) ? 32 : 64));
	}

	internal static void MBIISy1zKC0dJeIaAVy()
	{
	}

	internal static void aifUtfIbj556C5q8xg3()
	{
	}

	internal static void MwY5IWI4dEIhr0oCl1a()
	{
	}

	internal static object rubeOyIns2UF5UXnFiP()
	{
		return null;
	}

	internal static object g2hoLbIUCbhTYGmrgKd(object object_0)
	{
		return null;
	}

	internal static bool UjcmY7ILlFQhlbihamU()
	{
		return true;
	}

	internal static int OsMOdcINUJ8NwlMJvLL(object object_0)
	{
		return 0;
	}

	internal static void xKvApsIjTqSOO3vYQqF(bool value)
	{
	}

	internal static bool qsDP8qIanpGCLf39IJW(object object_0, object object_1)
	{
		return true;
	}

	internal static void DmuMUFIM079vixn3V8A(bool value)
	{
	}

	internal static void E1KGnmIqVCiB7bMgtAA(bool value)
	{
	}

	internal static void HommbsIeoUMGaLWFl8G(bool value)
	{
	}

	internal static object uO3bvpIXx0L4aNkPVv8(int int_0)
	{
		return null;
	}

	internal static Type YPWOWIIgumBsUiVfaN2(object object_0)
	{
		return null;
	}

	internal static bool WXfX6AI7BwnWDXpghcr(Type type_0, Type type_1)
	{
		return true;
	}

	internal static void ol0WwMISDjtc0uLkh9H(object object_0)
	{
	}

	internal static object N5hDttI3BxR4V3QTHfo(object object_0)
	{
		return null;
	}

	internal static object YMsRaKIvdsKBqHJdZED(object object_0)
	{
		return null;
	}

	internal static object vKSym8Iyub3FiMWcsVN(object object_0, object object_1)
	{
		return null;
	}

	internal static void fLZLTBIP3IYjZ79MFJm(object object_0)
	{
	}

	internal static object jiqO3kIV2UdIPBgJ8VW()
	{
		return null;
	}

	internal static object FNuoOhIFNdajSwtA5Qr(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static object LV8kwDIE0jZMiFfKwtp(object object_0, object object_1)
	{
		return null;
	}

	internal static object dbPQX3Iw0NYGF2KLvg0(object object_0, object object_1)
	{
		return null;
	}

	internal static void DlWtNSIm8uoNRAhCKUC(bool value)
	{
	}

	internal static bool NOwrg3I2lJRxsySqaBK()
	{
		return true;
	}

	internal static void yOE9MPItfBg7rJnEdsa(object object_0)
	{
	}

	internal static bool Stvl4j1D5kEnHLY79lS()
	{
		return true;
	}

	internal static GClass46 mpXnMN1dBMBqnyRcRd6()
	{
		return null;
	}
}
