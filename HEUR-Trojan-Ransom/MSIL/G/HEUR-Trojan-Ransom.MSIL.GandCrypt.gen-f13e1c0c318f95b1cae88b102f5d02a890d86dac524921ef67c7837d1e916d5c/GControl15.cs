using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl15 : Control
{
	public delegate void GDelegate6(object sender);

	private int int_0;

	private int int_1;

	private int int_2;

	private Color color_0;

	[CompilerGenerated]
	private GDelegate6 gdelegate6_0;

	private Class22.Struct11 struct11_0;

	public int Int32_0
	{
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			uint num = checked((uint)/*Error near IL_0001: Stack underflow*/);
			_003F val = /*Error near IL_0004: Stack underflow*/- (int)num;
			_ = ((byte[])/*Error near IL_0005: Stack underflow*/)[val];
			/*Error near IL_0007: Invalid metadata token*/;
		}
		set
		{
			/*Error: ldloc 1 (out-of-bounds)*/;
			_ = 1;
			/*Error: Unexpected end of block*/;
		}
	}

	public unsafe int Int32_1
	{
		get
		{
			//Discarded unreachable code: IL_0009, IL_000d, IL_0012, IL_0014, IL_0019, IL_0021, IL_0029, IL_0030
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected native int or pointer, but got F8
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			_ = *(object*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0004: Invalid metadata token*/;
		}
		set; }

	public extern int Int32_2 { get; set; }

	public extern Color Color_0 { get; set; }

	public extern Color Color_1 { get; set; }

	public extern Color Color_2 { get; set; }

	public unsafe event GDelegate6 Event_0
	{
		[CompilerGenerated]
		add;
		[CompilerGenerated]
		remove
		{
			//Discarded unreachable code: IL_0029
			//IL_000e: Invalid comparison between Unknown and F8
			//IL_0016: Expected F8, but got Unknown
			//IL_001e: Invalid comparison between Unknown and F8
			while (true)
			{
				if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/&& !((double)/*Error near IL_0013: Stack underflow*/ < -1.2688188031572372E-195))
				{
					_003F val = /*Error near IL_0014: ldloc 2 (out-of-bounds)*/;
					*(double*)(nint)/*Error near IL_0016: Stack underflow*/ = (double)val;
					ushort num = *(ushort*)((long)/*Error near IL_0018: Stack underflow*/ - checked((sbyte)/*Error near IL_0018: ldloc 0 (out-of-bounds)*/));
					if (!((double)/*Error near IL_0023: Stack underflow*/ < (double)num))
					{
						break;
					}
				}
			}
			/*Error near IL_0024: Invalid metadata token*/;
		}
	}

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	public extern GControl15();

	public extern void method_0();
}
