using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class GClass9 : HashAlgorithm
{
	public static readonly uint uint_0;

	private static readonly uint uint_1;

	private static readonly GClass9 gclass9_0;

	private static readonly Hashtable hashtable_0;

	private readonly uint[] uint_2;

	private uint uint_3;

	public extern GClass9();

	public extern GClass9(uint uint_4);

	extern void HashAlgorithm.Initialize();

	extern void HashAlgorithm.HashCore(byte[] array, int ibStart, int cbSize);

	extern byte[] HashAlgorithm.HashFinal();

	public static extern int smethod_0(string string_0);

	public static extern int smethod_1(Stream stream_0);

	public static extern int smethod_2(byte[] byte_0);

	public static int smethod_3(byte[] byte_0, int int_0, int int_1)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0011, IL_001e, IL_0023, IL_0028
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Incompatible stack heights: 0 vs 1
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public extern byte[] method_0(string string_0);

	public byte[] method_1(Stream stream_0)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0012
		_ = ((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public byte[] method_2(byte[] byte_0)
	{
		while (true)
		{
			/*OpCode not supported: DebugBreak*/;
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0006: Stack underflow*/&& (int)(float)/*Error near IL_0007: Stack underflow*/ != 0)
			{
				/*Error: Could not find block for branch target IL_000c*/;
			}
		}
	}

	public extern byte[] method_3(byte[] byte_0, int int_0, int int_1);

	private static extern uint[] smethod_4(uint uint_4);

	private static extern int smethod_5(byte[] byte_0);

	static extern object smethod_6(Hashtable hashtable_1, object object_0);

	static extern void smethod_7(Hashtable hashtable_1, object object_0, object object_1);

	static extern void smethod_8(HashAlgorithm hashAlgorithm_0);

	static extern Hashtable smethod_9();

	static Hashtable smethod_10(Hashtable hashtable_1)
	{
		return (Hashtable)/*OpCode not supported: Nop*/;
	}

	unsafe static Encoding smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I
		while (true)
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			long num = ((long[])/*Error near IL_0002: Stack underflow*/)[val];
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
			if (checked((uint)/*Error near IL_0004: Stack underflow*/) != 0)
			{
				IntPtr intPtr = *(IntPtr*)(nint)/*Error near IL_000b: Stack underflow*/;
				if ((nint)/*Error near IL_0010: Stack underflow*/ <= (nint)intPtr)
				{
					/*Error: Could not find block for branch target IL_0010*/;
				}
			}
		}
	}

	static byte[] smethod_12(Encoding encoding_0, string string_0)
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_001a
		//IL_0006: Unsupported input type for neg.
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern int smethod_13(Stream stream_0, byte[] byte_0, int int_0, int int_1);

	static extern int smethod_14(byte[] byte_0, int int_0);
}
