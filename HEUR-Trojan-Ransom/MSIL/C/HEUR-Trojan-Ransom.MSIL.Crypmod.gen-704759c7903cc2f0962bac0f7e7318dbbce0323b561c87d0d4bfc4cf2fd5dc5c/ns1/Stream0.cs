using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using ns0;

namespace ns1;

[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
internal abstract class Stream0 : Stream
{
	protected internal const int int_0 = 32768;

	protected static int int_1;

	private static byte[] byte_0;

	private static int int_2;

	private static int int_3;

	private static int int_4;

	private static int int_5;

	protected long long_0;

	protected long Int64_0
	{
		get
		{
			return long_0;
		}
		set
		{
			Interlocked.Exchange(ref long_0, value);
		}
	}

	public static byte[] smethod_0(byte[] byte_1, byte[] byte_2)
	{
		int num = 0;
		if (int_3 == 0)
		{
			if (int_4 < int_5)
			{
				smethod_1();
			}
			int_4 = 0;
			int_5 = 0;
		}
		NavMenu.smethod_0(byte_1, byte_2);
		if (num == 0)
		{
			return byte_1;
		}
		int num3;
		while (true)
		{
			if (int_3 <= int_1)
			{
				if (int_3 == 0 && num >= int_1)
				{
					smethod_3(byte_1, byte_2, num, bool_0: true);
					return byte_1;
				}
				Thread.BeginCriticalRegion();
				Interlocked.Increment(ref int_2);
				int num2 = Interlocked.Add(ref int_3, num);
				num3 = num2 - num;
				if (num2 <= int_1)
				{
					break;
				}
				Interlocked.Decrement(ref int_2);
				Thread.EndCriticalRegion();
				if (int_3 > int_1 && num3 <= int_1 && num3 > 0)
				{
					while (int_2 != 0)
					{
						Thread.SpinWait(1);
					}
					smethod_3(byte_0, byte_0, num3, bool_0: true);
					int_3 = 0;
				}
			}
			else
			{
				Thread.Sleep(1);
			}
		}
		if (byte_0 == null)
		{
			Interlocked.CompareExchange(ref byte_0, new byte[int_1], null);
		}
		Buffer.BlockCopy(byte_1, 0, byte_0, num3, num);
		Interlocked.Decrement(ref int_2);
		Thread.EndCriticalRegion();
		return byte_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public override void vmethod_0()
	{
		try
		{
			if (int_3 > 0)
			{
				method_0(bool_0: false);
			}
			else if (int_4 < int_5)
			{
				smethod_1();
			}
		}
		finally
		{
			int_3 = 0;
			int_4 = 0;
			int_5 = 0;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	protected static void smethod_1()
	{
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	protected void method_0(bool bool_0)
	{
		if (int_3 > 0)
		{
			smethod_3(byte_0, new byte[1], int_3, bool_0);
		}
		int_3 = 0;
	}

	protected override void vmethod_1(bool bool_0)
	{
		try
		{
			if (int_3 > 0)
			{
				method_0(bool_0);
			}
		}
		finally
		{
			int_4 = 0;
			int_5 = 0;
			int_3 = 0;
			base.Dispose(bool_0);
		}
	}

	internal static byte[] smethod_2()
	{
		return smethod_0(Class3.smethod_0(), new byte[36]
		{
			2, 19, 3, 4, 10, 9, 20, 15, 8, 12,
			14, 7, 6, 5, 16, 11, 8, 13, 9, 20,
			2, 12, 15, 16, 5, 17, 4, 7, 1, 19,
			6, 3, 15, 2, 18, 12
		});
	}

	protected long method_1(long long_1)
	{
		return Interlocked.Add(ref long_0, long_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	protected internal void method_2()
	{
		int_4 = 0;
		int_5 = 0;
		int_3 = 0;
	}

	private static void smethod_3(byte[] byte_1, byte[] byte_2, int int_6, bool bool_0)
	{
		smethod_4(byte_1, 0, int_6, bool_0, out var _);
	}

	protected static void smethod_4(byte[] byte_1, int int_6, int int_7, bool bool_0, out long long_1)
	{
		throw new NotImplementedException();
	}
}
