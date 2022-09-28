using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

public class GClass20
{
	public class GClass21
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_4;

		public extern int Int32_0
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			protected set;
		}

		public int Int32_1
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			protected set
			{
				this = (GClass21)/*Error near IL_0002: Stack underflow*/;
				_ = 3;
				/*OpCode not supported: DebugBreak*/;
			}
		}

		public extern int Int32_2
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			protected set;
		}

		public int Int32_3
		{
			[CompilerGenerated]
			get
			{
				//Discarded unreachable code: IL_0008, IL_000d, IL_0012, IL_0017, IL_0019, IL_001b, IL_0020, IL_0026, IL_002b, IL_002c, IL_0031
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected F4, but got I4
				checked
				{
					while (true)
					{
						byte num = (byte)/*Error near IL_0001: Stack underflow*/;
						_ = /*Error near IL_0003: Stack underflow*/* num;
					}
				}
			}
			[CompilerGenerated]
			protected set;
		}

		public unsafe int Int32_4
		{
			[CompilerGenerated]
			get
			{
				//Discarded unreachable code: IL_0007, IL_000c, IL_0013, IL_001b, IL_0023, IL_002a, IL_0032
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected I4, but got Unknown
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				//IL_0025: Invalid comparison between Unknown and I8
				_003F val;
				do
				{
					val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
				}
				while (/*Error near IL_0006: Stack underflow*/ > val);
				/*Error near IL_0006: Unknown opcode: 0xFB*/;
			}
			[CompilerGenerated]
			protected set
			{
				//Discarded unreachable code: IL_0007, IL_000f, IL_0016, IL_001e, IL_0025, IL_002a, IL_002d, IL_002f
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_000a: Expected O, but got Unknown
				//IL_0011: Invalid comparison between Unknown and I8
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
				*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
				/*Error near IL_0002: Invalid metadata token*/;
			}
		}

		public extern GClass21();

		public extern GClass21(BitmapData bitmapData_0);

		internal extern void method_0();

		internal extern void method_1(BitmapData bitmapData_0);

		static extern int smethod_0(BitmapData bitmapData_0);

		static extern int smethod_1(BitmapData bitmapData_0);

		static extern int smethod_2(BitmapData bitmapData_0);

		static extern int smethod_3(int int_5);
	}

	private readonly object object_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GClass21 gclass21_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IntPtr intptr_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private BitmapData bitmapData_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Bitmap bitmap_0;

	public extern GClass21 GClass21_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		internal set;
	}

	public extern bool Boolean_0 { get; }

	public extern IntPtr IntPtr_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		internal set;
	}

	public extern int Int32_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		internal set;
	}

	public extern BitmapData BitmapData_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		internal set;
	}

	public Bitmap Bitmap_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public extern GClass20();

	public extern GClass20(Bitmap bitmap_1);

	public static extern bool smethod_0(Rectangle rectangle_0, int int_1, int int_2, GClass21 gclass21_1);

	public static extern bool smethod_1(int int_1, int int_2, int int_3, int int_4, GClass21 gclass21_1);

	public static extern bool smethod_2(int int_1, int int_2, int int_3, int int_4, GClass21 gclass21_1);

	public extern void method_0(Rectangle rectangle_0, ref byte[] byte_0);

	public extern void method_1();

	public extern void method_2();

	public extern void method_3(byte[] byte_0, Rectangle rectangle_0);

	public extern void method_4(bool bool_0 = false);

	static extern object smethod_3();

	static Exception smethod_4(string string_0)
	{
		//Discarded unreachable code: IL_000a, IL_0015, IL_001a
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected I4, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
			}
		}
	}

	unsafe static void smethod_5(object object_1, ref bool bool_0)
	{
		//Discarded unreachable code: IL_001f, IL_0023, IL_0028, IL_002f
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000a: Expected F4, but got I4
		//IL_0013: Expected O, but got I4
		//IL_0014: Invalid comparison between Unknown and F4
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		while (true)
		{
			ushort num = *(ushort*)(nint)/*Error near IL_0003: Stack underflow*/;
			if ((int)/*Error near IL_0008: Stack underflow*/ >= (int)num)
			{
				sbyte num2 = checked((sbyte)/*Error near IL_0009: Stack underflow*/);
				*(float*)(nint)/*Error near IL_000a: Stack underflow*/ = num2;
				((object[])/*Error near IL_0013: Stack underflow*/)[7] = 1191010843;
				float num3 = (float)/*Error near IL_0014: Stack underflow*/;
				if (!((float)/*Error near IL_0019: Stack underflow*/ <= num3))
				{
					break;
				}
			}
		}
		_ = *(double*)(nint)/*Error near IL_001a: Stack underflow*/;
		/*Error near IL_001a: Invalid metadata token*/;
	}

	static extern int smethod_6(Image image_0);

	static extern int smethod_7(Image image_0);

	static extern void smethod_8(Bitmap bitmap_1, BitmapData bitmapData_1);

	unsafe static void smethod_9(object object_1)
	{
		//IL_0002: Expected I4, but got I8
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			long num = ((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)num;
		}
		while (/*Error near IL_0007: Stack underflow*/ != /*Error near IL_0007: Stack underflow*/);
		checked
		{
			_ = /*Error near IL_0009: Stack underflow*/+ /*Error near IL_0009: Stack underflow*/;
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}

	static extern void smethod_10(Image image_0);
}
