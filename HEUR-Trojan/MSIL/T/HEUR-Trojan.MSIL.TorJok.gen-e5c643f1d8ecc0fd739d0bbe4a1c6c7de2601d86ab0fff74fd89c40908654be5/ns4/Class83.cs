using System.Net;
using System.Runtime.CompilerServices;

namespace ns4;

internal sealed class Class83
{
	public enum Enum26
	{
		const_0,
		const_1
	}

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private IPAddress ipaddress_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private IPAddress ipaddress_1;

	[CompilerGenerated]
	private Enum26 enum26_0;

	[SpecialName]
	[CompilerGenerated]
	public int method_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(int int_2)
	{
		int_0 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public IPAddress method_2()
	{
		return ipaddress_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(IPAddress ipaddress_2)
	{
		ipaddress_0 = ipaddress_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_4()
	{
		return int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(int int_2)
	{
		int_1 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public IPAddress method_6()
	{
		return ipaddress_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(IPAddress ipaddress_2)
	{
		ipaddress_1 = ipaddress_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum26 method_8()
	{
		return enum26_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(Enum26 enum26_1)
	{
		enum26_0 = enum26_1;
	}

	public Class83()
	{
		method_3(IPAddress.Parse("127.0.0.1"));
		method_1(12345);
		method_7(IPAddress.Parse("127.0.0.1"));
		method_5(9150);
		method_9(Enum26.const_1);
	}

	public Class83(IPAddress ipaddress_2, int int_2, IPAddress ipaddress_3, int int_3, Enum26 enum26_1)
	{
		method_3(ipaddress_2);
		method_1(int_2);
		method_7(ipaddress_3);
		method_5(int_3);
		method_9(enum26_1);
	}
}
