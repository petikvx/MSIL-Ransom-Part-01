using System.Security.Cryptography;
using System.Text;
using System.Threading;

internal class Class6
{
	public static extern void smethod_0();

	public static extern void smethod_1(string string_0, int int_0 = 40);

	public extern Class6();

	static extern char[] smethod_2(string string_0);

	static extern RNGCryptoServiceProvider smethod_3();

	static void smethod_4(RandomNumberGenerator randomNumberGenerator_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_000c, IL_0013, IL_0018, IL_001e, IL_0024, IL_0029, IL_0030, IL_0037, IL_0047
		//IL_0007: Incompatible stack heights: 0 vs 1
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between F8 and I8
		while (true)
		{
			_ = 5f;
		}
	}

	static extern StringBuilder smethod_5(int int_0);

	static extern StringBuilder smethod_6(StringBuilder stringBuilder_0, char char_0);

	static extern string smethod_7(object object_0);

	static void smethod_8(string string_0)
	{
		//Discarded unreachable code: IL_0002, IL_0016, IL_001b, IL_002c, IL_0030, IL_0035
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Incompatible stack heights: 0 vs 1
		//IL_001e: Expected F8, but got O
		//IL_0021: Expected O, but got I8
		//IL_0027: Invalid comparison between Unknown and I
		checked
		{
			_ = (ushort)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xFF*/;
		}
	}

	static extern Thread smethod_9(ThreadStart threadStart_0);

	static extern char smethod_10(string string_0, int int_0);

	static void smethod_11(char char_0)
	{
		//Discarded unreachable code: IL_0002, IL_0007
		_ = (ushort)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF8*/;
	}

	static extern void smethod_12(int int_0);

	static int smethod_13(string string_0)
	{
		//Discarded unreachable code: IL_0008
		checked
		{
			while (true)
			{
				_ = (nuint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
			}
		}
	}
}
