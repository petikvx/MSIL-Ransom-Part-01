using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class GControl18 : Control
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
	private struct Struct4
	{
	}

	internal sealed class Class10
	{
		internal int int_0;

		internal unsafe Class10()
		{
			//Discarded unreachable code: IL_0009
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			IntPtr intPtr = *(IntPtr*)(nint)/*Error near IL_0001: Stack underflow*/;
			((short[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (short)(nint)intPtr;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	private GClass1.GEnum1 genum1_0;

	private GClass0.Class5 class5_0;

	private static readonly object object_0;

	private static readonly object object_1;

	private static readonly object object_2;

	internal static Struct4 struct4_0/* Not supported: data(3F B3 57 FB F5 FF 5C 74 52 E2) */;

	public extern Color Color_0 { get; set; }

	public extern Color Color_1 { get; set; }

	public extern Color Color_2 { get; set; }

	public Color Color_3
	{
		get; set
		{
			//Discarded unreachable code: IL_0001, IL_0007
			/*Error: Unknown opcode: 0xFA*/;
		}
	}

	public GControl18()
	{
		//Discarded unreachable code: IL_0005, IL_000d
		/*Error: Invalid metadata token*/;
	}

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override extern void vmethod_3(EventArgs eventArgs_0);

	protected override extern void vmethod_4(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_5(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_6(EventArgs eventArgs_0);

	internal unsafe static string smethod_0(Assembly assembly_0, int int_0, int int_1, char char_0)
	{
		//Discarded unreachable code: IL_0015, IL_001b, IL_0021, IL_0027, IL_002e, IL_0033, IL_0036
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and F8
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		ushort num = *(ushort*)6;
		_ = checked(/*Error near IL_0003: Stack underflow*/ - num) / 0uL;
		/*Error near IL_0010: Invalid metadata token*/;
	}

	static extern void auyvhYdFPJotchQBGBNSqSatwNks(Control control_0, Color color_0);

	static extern Font HgAbPZRcnQDharzqraVburhKYiJJ(string string_0, float float_0);

	static extern void TzmGpIiSmteHEjHSgMduRvCmxTMvb(Control control_0, Font font_0);

	static void apaYvbzNBYyijUFvnIEwHVSiOJQe(Control control_0)
	{
		//Discarded unreachable code: IL_0005, IL_0016
		/*Error: Invalid metadata token*/;
	}

	static Form FFYtGNYdPGiNEMFaWtwlaQmMnNis(Control control_0)
	{
		//Discarded unreachable code: IL_0019, IL_0020
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I8
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/&& (int)/*Error near IL_000c: Stack underflow*/ > 1)
			{
				long num = /*Error near IL_000e: Stack underflow*/>> (int)/*Error near IL_000e: Stack underflow*/;
				if ((long)/*Error near IL_0014: Stack underflow*/ < num)
				{
					break;
				}
			}
		}
		/*Error near IL_0014: Invalid metadata token*/;
	}

	static extern FormWindowState yXYBRzbeXtYLIcggGjtHCIomGORmA(Form form_0);

	static extern void QItFCOMoKsbQFjTmWmrThhgjfNZm(Form form_0, FormWindowState formWindowState_0);

	static StringBuilder AxykSohsrLPqtKKNYTizFjwzgwUq()
	{
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern StringBuilder SQsNMTGQZQbdFRLwkhzyEYmFGBDS(StringBuilder stringBuilder_0, char char_0);

	static extern string VnwhWxWlQgABORoIYNBjUYOImsls(object object_3);

	static extern void GboGOidmEQaUlxktPbmWVqIfTvfkA(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0);
}
