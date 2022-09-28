using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

public abstract class GClass8
{
	public delegate void GDelegate1(Stream stream, Rectangle[] MotionChanges);

	public delegate void GDelegate2(Rectangle ScanArea);

	public delegate void GDelegate3(Bitmap bitmap);

	protected GClass13 gclass13_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_0;

	public abstract ulong UInt64_0 { get; internal set; }

	public extern int Int32_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public abstract int Int32_1 { get; }

	public abstract GEnum1 GEnum1_0 { get; }

	public abstract event GDelegate1 Event_0;

	public abstract event GDelegate3 Event_1;

	public abstract event GDelegate2 Event_2;

	public abstract event GDelegate2 Event_3;

	public extern GClass8(int int_1 = 100);

	public abstract void vmethod_0(Bitmap bitmap_0, Stream stream_0);

	public abstract Bitmap vmethod_1(Stream stream_0);
}
