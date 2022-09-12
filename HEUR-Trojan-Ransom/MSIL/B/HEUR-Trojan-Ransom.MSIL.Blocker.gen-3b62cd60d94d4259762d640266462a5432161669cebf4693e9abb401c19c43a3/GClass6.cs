using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;

public abstract class GClass6
{
	private int int_0;

	protected GClass13 gclass13_0;

	protected GClass14 gclass14_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly object object_0;

	public abstract ulong GClass6_002E_202E_202B_202D_202B_200C_202C_206C_202E_200D_206F_200B_200B_202B_206D_206C_202B_200B_202E_202E_206C_202C_202B_206C_200E_206D_202C_200B_202D_206B_206F_200B_200B_202D_200E_202A_206B_206A_206B_202D_200D_202E { get; internal set; }

	protected unsafe object Object_0
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0013, IL_001c
			//IL_0002: Invalid comparison between Unknown and I4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected F4, but got Unknown
			//IL_0017: Invalid comparison between Unknown and I
			while ((int)/*Error near IL_0007: Stack underflow*/ == 8)
			{
			}
			_003F val = checked(/*Error near IL_000b: Stack underflow*/ + /*Error near IL_000b: Stack underflow*/);
			*(float*)(nint)/*Error near IL_000c: Stack underflow*/ = (float)val;
			sbyte num = (sbyte)/*Error near IL_000d: Stack underflow*/;
			_ = ((ushort[])/*Error near IL_000e: Stack underflow*/)[num];
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	public extern int Int32_0 { get; set; }

	public abstract int GClass6_002E_200D_202C_202E_200D_200D_206F_200C_202E_202A_206D_202A_200D_200C_200E_200B_206A_206D_200C_200B_200F_200E_202B_206C_202D_202C_206A_202A_202B_206E_202B_202E_200D_202B_200D_206B_202B_200B_200E_200F_206F_202E { get; }

	public abstract GEnum1 GClass6_002E_200E_200B_202B_202B_206D_206A_202E_202C_202B_200C_202D_202A_200C_200D_206C_206E_206F_202E_202C_200B_206F_202B_206B_206A_200F_202C_206E_200F_200F_202B_200D_202C_200B_202E_200B_206D_206B_200B_206C_202E_202E { get; }

	public abstract event GClass8.GDelegate2 GClass6_002E_200C_202D_200F_200D_200C_202A_202D_200F_200B_200C_206A_202C_200D_206F_200C_206C_206F_202E_206D_200B_200D_200C_202D_206C_202D_206A_202E_206F_202E_200C_200F_200D_206D_202A_200B_200C_200D_200F_202B_202C_202E;

	public abstract event GClass8.GDelegate2 GClass6_002E_200E_202C_202D_200B_206B_200F_200B_206A_202C_202E_206F_206E_200D_206D_206F_200D_202D_200D_206E_206C_206B_206F_206A_206D_200F_206C_200B_200E_202C_200E_206D_202A_206C_202C_202D_202D_202D_200B_202A_206A_202E;

	public extern GClass6(int int_1 = 100);

	public abstract void GClass6_002E_200D_206F_202A_200E_200F_206B_206C_200E_202E_202B_200B_206E_206D_206B_200D_206F_202A_202E_200E_200B_202C_206E_200C_200D_200D_202C_200E_202C_200C_206E_206B_200B_202C_202A_206B_206D_206C_200F_202D_202C_202E(IntPtr intptr_0, Rectangle rectangle_0, Size size_0, PixelFormat pixelFormat_0, Stream stream_0);

	public abstract Bitmap GClass6_002E_200B_200B_202B_200C_200F_202B_202D_206D_202C_200D_202E_202C_200D_202D_200C_206F_200E_206E_202C_200F_200E_202B_200E_206A_202B_202D_206D_200C_202C_206A_202C_200C_200C_202D_202C_206E_200D_206F_202B_200F_202E(Stream stream_0);

	public abstract Bitmap GClass6_002E_200B_200B_202B_200C_200F_202B_202D_206D_202C_200D_202E_202C_200D_202D_200C_206F_200E_206E_202C_200F_200E_202B_200E_206A_202B_202D_206D_200C_202C_206A_202C_200C_200C_202D_202C_206E_200D_206F_202B_200F_202E(IntPtr intptr_0, uint uint_0);

	static extern object smethod_0();
}
