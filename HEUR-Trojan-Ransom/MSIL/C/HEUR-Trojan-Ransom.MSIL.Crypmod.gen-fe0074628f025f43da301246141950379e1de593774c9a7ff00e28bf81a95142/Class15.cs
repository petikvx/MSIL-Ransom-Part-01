using System;
using System.IO;
using System.Threading.Tasks;

internal static class Class15
{
	internal enum Enum2
	{
		const_0,
		const_1
	}

	internal interface Interface0 : IDisposable
	{
		float Single_0 { get; }

		float Single_1 { get; }

		Task imethod_0(Enum2 enum2_0, float float_0, Stream stream_0);
	}

	internal interface Interface1
	{
		Task<Interface0> imethod_0(Stream stream_0, float? nullable_0, float? nullable_1);

		Task<Interface0> imethod_1(string string_0, float? nullable_0, float? nullable_1);

		Interface0 imethod_2(float float_0, float float_1);
	}

	private static Interface1 interface1_0;

	public unsafe static Interface1 Interface1_0
	{
		get
		{
			//Discarded unreachable code: IL_0008
			//IL_0005: Expected I8, but got Unknown
			checked
			{
				_ = (nuint)(uint)/*Error near IL_0001: Stack underflow*/;
			}
			*(long*)(nint)/*Error near IL_0002: ldloc 2 (out-of-bounds)*/ = (long)/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0005: stloc 2 (out-of-bounds)*/;
			/*Error near IL_0007: Unknown opcode: 0xFB*/;
		}
		set; }

	public static extern byte[] smethod_0(byte[] byte_0, byte[] byte_1);

	static Class15()
	{
		//Discarded unreachable code: IL_000a, IL_0015, IL_0020, IL_0028, IL_0029, IL_0033
		//IL_001b: Expected I4, but got F4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		//IL_002e: Invalid comparison between Unknown and I4
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static Type HbMyhDEqBcbWGinPQqmmiKcblMJmA(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		object obj;
		do
		{
			_003F val = /*Error: Stack underflow*/;
			obj = ((object[])/*Error near IL_0005: Stack underflow*/)[(double)(uint)(sbyte)(long)val];
			/*OpCode not supported: DebugBreak*/;
		}
		while (obj != null);
		_ = 7;
		_ = 1;
		/*Error near IL_000f: Invalid metadata token*/;
	}

	static extern Exception EMOooLeTmvgXcNqOHsbUuGQMRXQp(string string_0);
}
