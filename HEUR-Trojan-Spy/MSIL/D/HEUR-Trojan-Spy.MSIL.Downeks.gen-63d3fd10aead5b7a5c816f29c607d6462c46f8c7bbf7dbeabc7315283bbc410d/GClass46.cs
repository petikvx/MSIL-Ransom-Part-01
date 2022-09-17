using System;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

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

	internal static GClass46 d32dYDGxxa9rhhhYfkt;

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
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		iKhypVGb6v6JAF90Ufc();
		hHEYokUTtehNq5ji0d.BUZgdfmzxASR9();
		sODyGFGBDQS0Xr8GIdk(((OperatingSystem)IingENGELckGk96QIoC()).Platform == PlatformID.Win32NT);
		yIJwGsGggWWXibAIcI6(Win32NT && yAhdDiGZ0EtJ4CDmA7D(x8MDFUGTXKv62r3I12Y(IingENGELckGk96QIoC())) >= 5);
		OpBSbxGUbI9qnFLap9R(nJ3GwOGFIOk41lmNtM6() && ((Version)x8MDFUGTXKv62r3I12Y(IingENGELckGk96QIoC())).Major >= 6);
		sgsplCG3tpjcjHexgaC(nJ3GwOGFIOk41lmNtM6() && nypKkBGmwhhhW2Dt0jl(x8MDFUGTXKv62r3I12Y(IingENGELckGk96QIoC()), new Version(6, 1)));
		lXm7ZMGcukbH4xlTsKC(nJ3GwOGFIOk41lmNtM6() && nypKkBGmwhhhW2Dt0jl(x8MDFUGTXKv62r3I12Y(Environment.OSVersion), new Version(6, 2, 9200)));
		admDLsGspbwt02eW7Ux(nJ3GwOGFIOk41lmNtM6() && nypKkBGmwhhhW2Dt0jl(x8MDFUGTXKv62r3I12Y(Environment.OSVersion), new Version(6, 3)));
		kaIDOCGJdXQP7MaAANq(nJ3GwOGFIOk41lmNtM6() && nypKkBGmwhhhW2Dt0jl(x8MDFUGTXKv62r3I12Y(IingENGELckGk96QIoC()), new Version(10, 0)));
		RunningOnMono = Type.GetType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(13782)) != null;
		Name = (string)b7eYfHGGvoXfnAdbC4S(13810);
		ManagementObjectSearcher val = new ManagementObjectSearcher(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(13834));
		try
		{
			ManagementObjectEnumerator val2 = (ManagementObjectEnumerator)RGvR4rGYBrHCjabOqbO(l2Fp7IG7enwDfmrpW2T(val));
			try
			{
				if (ERHbqIG6gGjMX2UlmEF(val2))
				{
					IYsKB1G8ETyo2Hk3aXo(((ManagementBaseObject)(ManagementObject)UQCCvYGwD470TKi925t(val2)).get_Item((string)b7eYfHGGvoXfnAdbC4S(13920)).ToString());
				}
			}
			finally
			{
				if (val2 != null)
				{
					p8QVmBGn6fRjwH0Xteq(val2);
				}
			}
		}
		finally
		{
			if (val != null)
			{
				p8QVmBGn6fRjwH0Xteq(val);
			}
		}
		IYsKB1G8ETyo2Hk3aXo(oUZ2x1GNOQc46q8UuUR(v0IN76GjLWQf8fT3lX2(Regex.Replace((string)z4YFqiGDP4bYZRD1d14(), (string)b7eYfHGGvoXfnAdbC4S(13938), ""), new char[0]), new char[0]));
		gpeHK5Gu9H0ncMt4UVN(bysgExGvoSj718HiJGt());
		mXqELcGdapGiUJEELto(iWbJTyGo2vaVWgcMdV0(b7eYfHGGvoXfnAdbC4S(13970), Name, (!mVf7n1GrPtpNdAJO1xw()) ? 32 : 64));
	}

	internal static void iKhypVGb6v6JAF90Ufc()
	{
	}

	internal static object IingENGELckGk96QIoC()
	{
		return null;
	}

	internal static void sODyGFGBDQS0Xr8GIdk(bool value)
	{
	}

	internal static object x8MDFUGTXKv62r3I12Y(object object_0)
	{
		return null;
	}

	internal static int yAhdDiGZ0EtJ4CDmA7D(object object_0)
	{
		return 0;
	}

	internal static void yIJwGsGggWWXibAIcI6(bool value)
	{
	}

	internal static bool nJ3GwOGFIOk41lmNtM6()
	{
		return true;
	}

	internal static void OpBSbxGUbI9qnFLap9R(bool value)
	{
	}

	internal static bool nypKkBGmwhhhW2Dt0jl(object object_0, object object_1)
	{
		return true;
	}

	internal static void sgsplCG3tpjcjHexgaC(bool value)
	{
	}

	internal static void lXm7ZMGcukbH4xlTsKC(bool value)
	{
	}

	internal static void admDLsGspbwt02eW7Ux(bool value)
	{
	}

	internal static void kaIDOCGJdXQP7MaAANq(bool value)
	{
	}

	internal static object b7eYfHGGvoXfnAdbC4S(int int_0)
	{
		return null;
	}

	internal static object l2Fp7IG7enwDfmrpW2T(object object_0)
	{
		return null;
	}

	internal static object RGvR4rGYBrHCjabOqbO(object object_0)
	{
		return null;
	}

	internal static object UQCCvYGwD470TKi925t(object object_0)
	{
		return null;
	}

	internal static void IYsKB1G8ETyo2Hk3aXo(object object_0)
	{
	}

	internal static bool ERHbqIG6gGjMX2UlmEF(object object_0)
	{
		return true;
	}

	internal static void p8QVmBGn6fRjwH0Xteq(object object_0)
	{
	}

	internal static object z4YFqiGDP4bYZRD1d14()
	{
		return null;
	}

	internal static object v0IN76GjLWQf8fT3lX2(object object_0, object object_1)
	{
		return null;
	}

	internal static object oUZ2x1GNOQc46q8UuUR(object object_0, object object_1)
	{
		return null;
	}

	internal static bool bysgExGvoSj718HiJGt()
	{
		return true;
	}

	internal static void gpeHK5Gu9H0ncMt4UVN(bool value)
	{
	}

	internal static bool mVf7n1GrPtpNdAJO1xw()
	{
		return true;
	}

	internal static object iWbJTyGo2vaVWgcMdV0(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static void mXqELcGdapGiUJEELto(object object_0)
	{
	}

	internal static bool YtLpLTGapqe2kU8EOBa()
	{
		return true;
	}

	internal static GClass46 cYMwrxG4Ug5uOZdnRNo()
	{
		return null;
	}
}
