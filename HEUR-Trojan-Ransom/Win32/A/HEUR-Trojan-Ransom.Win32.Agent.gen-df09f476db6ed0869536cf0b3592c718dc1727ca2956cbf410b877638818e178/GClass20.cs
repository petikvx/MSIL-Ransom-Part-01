using System.Runtime.CompilerServices;

public class GClass20
{
	private GClass18 gclass18_0;

	private GClass18 gclass18_1;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private ulong ulong_0;

	[CompilerGenerated]
	private ulong ulong_1;

	[CompilerGenerated]
	private ulong ulong_2;

	[CompilerGenerated]
	private ulong ulong_3;

	public GClass20()
	{
		Class51.smethod_0();
		base._002Ector();
		gclass18_0 = new GClass18();
		gclass18_1 = new GClass18();
	}

	public void method_0()
	{
		method_5(method_4() + 1);
		method_7(method_6() + 1);
	}

	public void method_1(int int_2)
	{
		method_5(int_2);
	}

	public void method_2(int int_2, GEnum9 genum9_0)
	{
		if (genum9_0 != 0)
		{
			gclass18_1.method_1((uint)int_2);
			method_9(method_8() + (ulong)int_2);
		}
		else
		{
			gclass18_0.method_1((uint)int_2);
			method_11(method_10() + (ulong)int_2);
		}
	}

	public void method_3(GEnum8 genum8_0)
	{
		if (genum8_0 != 0)
		{
			method_15(method_14() + 1L);
		}
		else
		{
			method_13(method_12() + 1L);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_4()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_5(int int_2)
	{
		int_0 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_6()
	{
		return int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_7(int int_2)
	{
		int_1 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong method_8()
	{
		return ulong_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_9(ulong ulong_4)
	{
		ulong_0 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong method_10()
	{
		return ulong_1;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_11(ulong ulong_4)
	{
		ulong_1 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong method_12()
	{
		return ulong_2;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_13(ulong ulong_4)
	{
		ulong_2 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong method_14()
	{
		return ulong_3;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_15(ulong ulong_4)
	{
		ulong_3 = ulong_4;
	}

	[SpecialName]
	public string method_16()
	{
		return gclass18_1.method_0();
	}

	[SpecialName]
	public string method_17()
	{
		return gclass18_0.method_0();
	}
}
