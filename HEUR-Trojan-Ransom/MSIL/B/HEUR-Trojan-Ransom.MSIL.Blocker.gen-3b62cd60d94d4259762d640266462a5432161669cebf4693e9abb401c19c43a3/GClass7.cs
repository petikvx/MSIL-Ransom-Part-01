using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;

public class GClass7 : GClass6
{
	private Bitmap bitmap_0;

	private byte[] byte_0;

	private PixelFormat pixelFormat_0;

	private int int_1;

	private int int_2;

	private readonly bool bool_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ulong ulong_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Size size_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GClass8.GDelegate2 gdelegate2_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GClass8.GDelegate2 gdelegate2_1;

	public unsafe override ulong GClass6_002E_202E_202B_202D_202B_200C_202C_206C_202E_200D_206F_200B_200B_202B_206D_206C_202B_200B_202E_202E_206C_202C_202B_206C_200E_206D_202C_200B_202D_206B_206F_200B_200B_202D_200E_202A_206B_206A_206B_202D_200D_202E
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0007
			_ = (nuint)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
		[CompilerGenerated]
		internal set
		{
			//Discarded unreachable code: IL_000f
			uint num = (uint)/*Error near IL_0002: Stack underflow*/;
			double num2 = ((double[])((short[])/*Error near IL_0004: Stack underflow*/)[num])[(object)this];
			long num3 = ((long[])/*Error near IL_0008: Stack underflow*/)[num2];
			*(short*)(nint)/*Error near IL_000a: Stack underflow*/ = (short)num3;
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	public override int GClass6_002E_200D_202C_202E_200D_200D_206F_200C_202E_202A_206D_202A_200D_200C_200E_200B_206A_206D_200C_200B_200F_200E_202B_206C_202D_202C_206A_202A_202B_206E_202B_202E_200D_202B_200D_206B_202B_200B_200E_200F_206F_202E
	{
		get
		{
			//Discarded unreachable code: IL_0012
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Incompatible stack heights: 0 vs 3
			//IL_0014: Expected I4, but got O
			while (true)
			{
				_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
				_ = -711045433820888357L;
			}
		}
	}

	public override extern GEnum1 GClass6_002E_200E_200B_202B_202B_206D_206A_202E_202C_202B_200C_202D_202A_200C_200D_206C_206E_206F_202E_202C_200B_206F_202B_206B_206A_200F_202C_206E_200F_200F_202B_200D_202C_200B_202E_200B_206D_206B_200B_206C_202E_202E { get; }

	public Size Size_0
	{
		[CompilerGenerated]
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
				if (/*Error near IL_0006: Stack underflow*/ != val)
				{
					/*Error: Could not find block for branch target IL_0006*/;
				}
			}
		}
	}

	public override extern event GClass8.GDelegate2 GClass6_002E_200C_202D_200F_200D_200C_202A_202D_200F_200B_200C_206A_202C_200D_206F_200C_206C_206F_202E_206D_200B_200D_200C_202D_206C_202D_206A_202E_206F_202E_200C_200F_200D_206D_202A_200B_200C_200D_200F_202B_202C_202E;

	public override extern event GClass8.GDelegate2 GClass6_002E_200E_202C_202D_200B_206B_200F_200B_206A_202C_202E_206F_206E_200D_206D_206F_200D_202D_200D_206E_206C_206B_206F_206A_206D_200F_206C_200B_200E_202C_200E_206D_202A_206C_202C_202D_202D_202D_200B_202A_206A_202E;

	public extern GClass7(int int_3 = 100, bool bool_1 = true);

	public override extern void GClass6_002E_200D_206F_202A_200E_200F_206B_206C_200E_202E_202B_200B_206E_206D_206B_200D_206F_202A_202E_200E_200B_202C_206E_200C_200D_200D_202C_200E_202C_200C_206E_206B_200B_202C_202A_206B_206D_206C_200F_202D_202C_202E(IntPtr intptr_0, Rectangle rectangle_0, Size size_1, PixelFormat pixelFormat_1, Stream stream_0);

	public override extern Bitmap GClass6_002E_200B_200B_202B_200C_200F_202B_202D_206D_202C_200D_202E_202C_200D_202D_200C_206F_200E_206E_202C_200F_200E_202B_200E_206A_202B_202D_206D_200C_202C_206A_202C_200C_200C_202D_202C_206E_200D_206F_202B_200F_202E(IntPtr intptr_0, uint uint_0);

	public override extern Bitmap GClass6_002E_200B_200B_202B_200C_200F_202B_202D_206D_202C_200D_202E_202C_200D_202D_200C_206F_200E_206E_202C_200F_200E_202B_200E_206A_202B_202D_206D_200C_202C_206A_202C_200C_200C_202D_202C_206E_200D_206F_202B_200F_202E(Stream stream_0);

	static extern Delegate smethod_1(Delegate delegate_0, Delegate delegate_1);

	static extern Delegate smethod_2(Delegate delegate_0, Delegate delegate_1);

	static extern void smethod_3(object object_1, ref bool bool_1);

	static extern int smethod_4(Stream stream_0, byte[] byte_1, int int_3, int int_4);

	static extern int smethod_5(byte[] byte_1, int int_3);

	static extern MemoryStream smethod_6(byte[] byte_1);

	static extern Image smethod_7(Stream stream_0);

	static extern Graphics smethod_8(Image image_0);
}
