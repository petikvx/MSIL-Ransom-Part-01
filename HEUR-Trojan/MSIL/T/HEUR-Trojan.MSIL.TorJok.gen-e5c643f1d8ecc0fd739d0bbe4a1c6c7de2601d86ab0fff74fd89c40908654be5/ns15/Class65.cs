using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using ns0;
using ns12;
using ns14;
using ns4;
using ns5;
using ns8;

namespace ns15;

internal sealed class Class65 : Class64
{
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private Class83.Enum26 enum26_0;

	[CompilerGenerated]
	private Class83 class83_0;

	[SpecialName]
	[CompilerGenerated]
	public int method_1()
	{
		return int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_2(int int_2)
	{
		int_1 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class83.Enum26 method_3()
	{
		return enum26_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_4(Class83.Enum26 enum26_1)
	{
		enum26_0 = enum26_1;
	}

	[SpecialName]
	[CompilerGenerated]
	private Class83 method_5()
	{
		return class83_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_6(Class83 class83_1)
	{
		class83_0 = class83_1;
	}

	public Class65(Class83 class83_1)
		: base(class83_1.method_2(), class83_1.method_0())
	{
		method_2(class83_1.method_0());
		method_4(class83_1.method_8());
		method_6(class83_1);
	}

	public override void vmethod_0(IAsyncResult iasyncResult_0)
	{
		try
		{
			Socket socket = Class6.smethod_161((Class63)this).EndAccept(iasyncResult_0);
			if (socket != null)
			{
				Class62 @class = new Class62(method_5(), socket, base.method_0);
				Class6.smethod_399((Class63)this, (Class60)@class);
				@class.vmethod_0();
			}
		}
		catch
		{
		}
		try
		{
			Class6.smethod_161((Class63)this).BeginAccept(vmethod_0, Class6.smethod_161((Class63)this));
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}
}
