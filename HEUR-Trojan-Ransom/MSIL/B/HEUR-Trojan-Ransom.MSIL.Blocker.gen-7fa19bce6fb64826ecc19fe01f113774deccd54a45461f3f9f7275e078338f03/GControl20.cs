using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GControl20 : Control
{
	public enum GEnum5
	{
		SemiBlack,
		DarkPink,
		LightPink
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct4
	{
		internal Color color_0;

		internal Color color_1;
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct5
	{
		internal int int_0;

		internal int int_1;

		internal Color color_0;

		internal Color color_1;
	}

	private GEnum5 genum5_0;

	public GEnum5 GEnum5_0
	{
		get; set
		{
			//Discarded unreachable code: IL_0006, IL_000c, IL_0011, IL_0019
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Invalid comparison between Unknown and O
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/^ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public GControl20()
	{
		//Discarded unreachable code: IL_000c, IL_0011
		//IL_0002: Invalid comparison between Unknown and I4
		while (true)
		{
			long num = (long)/*Error near IL_0001: Stack underflow*/;
			if ((int)/*Error near IL_0007: Stack underflow*/ >= (int)(ushort)num)
			{
			}
		}
	}

	protected unsafe override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//Discarded unreachable code: IL_0008, IL_000f
		//IL_0011: Unsupported input type for neg.
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern Font oDIEpCjrGrXkmmsXiVMunLhUGxiSA(string string_0, float float_0, FontStyle fontStyle_0);

	static extern void inFVMkVLphTlKmLAJGXBIdZTQGXd(Control control_0, Font font_0);

	static extern void zymUIzCIavzVnGNNmGCLFEuWSzhy(Control control_0);
}
