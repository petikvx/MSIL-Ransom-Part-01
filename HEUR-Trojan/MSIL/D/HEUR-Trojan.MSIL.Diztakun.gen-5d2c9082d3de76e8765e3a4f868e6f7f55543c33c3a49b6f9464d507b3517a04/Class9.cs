using System;
using System.Collections;
using System.Runtime.InteropServices;

internal class Class9 : ReadOnlyCollectionBase
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	protected internal struct Struct7
	{
		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected internal struct Struct8
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public Enum0 enum0_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;

		public int int_0;

		public int int_1;

		public int int_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_3;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected internal struct Struct9
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public Enum0 enum0_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected internal struct Struct10
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string string_0;

		public byte byte_0;

		public ushort ushort_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string string_3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string string_4;

		public Enum0 Enum0_0
		{
			get
			{
				//Discarded unreachable code: IL_0002
				/*Error near IL_0001: Unknown opcode: 0xF9*/;
			}
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected internal struct Struct11
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string string_0;

		public byte byte_0;

		public ushort ushort_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		public extern Enum0 Enum0_0 { get; }
	}

	protected const int int_0 = 260;

	protected const int int_1 = 0;

	protected const int int_2 = 5;

	protected const int int_3 = 124;

	protected const int int_4 = 234;

	protected const int int_5 = 2250;

	protected const int int_6 = 1;

	protected const int int_7 = 20;

	private static Class9 class9_0;

	private string string_0;

	protected internal unsafe static bool Boolean_0
	{
		get
		{
			//Discarded unreachable code: IL_0008, IL_000a, IL_0012, IL_001b, IL_0023, IL_0029
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected F8, but got Unknown
			//IL_0016: Expected F8, but got I4
			//IL_001e: Invalid comparison between Unknown and I8
			//IL_0028: Incompatible stack heights: 0 vs 1
			long num = *(long*)(nint)/*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0002: Stack underflow*/- num;
			_ = ((object[])/*Error near IL_0004: Stack underflow*/)[val];
			/*Error near IL_0006: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0007: Unknown opcode: 0xFF*/;
		}
	}

	protected internal static extern bool Boolean_1 { get; }

	public static extern Class9 Class9_0 { get; }

	public extern string String_0 { get; }

	public extern Class8 this[int int_8] { get; }

	public extern Class8 this[string string_1] { get; }

	public unsafe Class9()
	{
		_ = *(float*)(*(short*)6);
		/*Error: Unexpected end of block*/;
	}

	public extern Class9(string string_1);

	protected extern void method_0(Class8 class8_0);

	protected internal extern void method_1(string string_1, string string_2, Enum0 enum0_0, string string_3);

	public extern void method_2(Class8[] class8_0, int int_8);

	static extern OperatingSystem smethod_0();

	static extern PlatformID smethod_1(OperatingSystem operatingSystem_0);

	unsafe static Version smethod_2(OperatingSystem operatingSystem_0)
	{
		//Discarded unreachable code: IL_000d, IL_0014, IL_001e, IL_0024
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
		checked
		{
			_ = (nint)(long)(*unchecked((float*)(int)checked((uint)unchecked((int)checked((byte)/*Error near IL_0001: Stack underflow*/)))));
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	static extern int smethod_3(Version version_0);

	static extern int smethod_4(ArrayList arrayList_0, object object_0);

	static extern object smethod_5(ArrayList arrayList_0, int int_8);

	static extern int smethod_6(string string_1);

	static extern string smethod_7(string string_1);

	static extern int smethod_8(ArrayList arrayList_0);

	static extern void smethod_9(ArrayList arrayList_0, Array array_0, int int_8);
}
