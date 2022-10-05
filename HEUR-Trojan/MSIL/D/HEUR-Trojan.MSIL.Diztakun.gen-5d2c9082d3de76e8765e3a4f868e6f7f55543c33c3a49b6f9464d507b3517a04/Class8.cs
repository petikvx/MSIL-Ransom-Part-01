using System;
using System.IO;

internal class Class8
{
	private string string_0;

	private string string_1;

	internal string string_2;

	internal Enum0 enum0_0;

	private string string_3;

	public extern string String_0 { get; }

	public extern string String_1 { get; }

	public extern string String_2 { get; }

	public Enum0 Enum0_0
	{
		get
		{
			//Discarded unreachable code: IL_000c, IL_0014, IL_001c
			//IL_0001: Unsupported input type for neg.
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Expected I4, but got Unknown
			_003F val = /*Error: ldloc 3 (out-of-bounds)*/;
			((int[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = 0 - val;
			short num = checked((short)/*Error near IL_0006: Stack underflow*/);
			((short[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = num;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	public extern string String_3 { get; }

	public bool Boolean_0
	{
		get
		{
			//Discarded unreachable code: IL_0007, IL_0010, IL_0011, IL_0017, IL_001d
			//IL_000b: Invalid comparison between Unknown and I8
			//IL_0012: Invalid comparison between Unknown and I4
			//IL_0018: Invalid comparison between Unknown and I
			checked
			{
				_ = (byte)/*Error near IL_0001: Stack underflow*/;
				_ = 7;
				/*Error near IL_0002: Invalid metadata token*/;
			}
		}
	}

	public extern DirectoryInfo DirectoryInfo_0 { get; }

	public extern Class8(string string_4, string string_5, string string_6, Enum0 enum0_1, string string_7);

	extern string object.ToString();

	static bool smethod_0(string string_4, string string_5)
	{
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern int smethod_1(string string_4);

	static extern string smethod_2(object object_0);

	static DirectoryInfo smethod_3(string string_4)
	{
		//Discarded unreachable code: IL_0008
		//IL_000d: Expected I4, but got Unknown
		_ = ((IntPtr[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	unsafe static string smethod_4()
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_001a, IL_001c
		//IL_0002: Invalid comparison between Unknown and I4
		short num;
		do
		{
			num = checked((short)/*Error near IL_0002: Stack underflow*/);
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ < (int)num);
		_ = *(long*)(nint)/*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern string smethod_5(string string_4, object object_0, object object_1);
}
