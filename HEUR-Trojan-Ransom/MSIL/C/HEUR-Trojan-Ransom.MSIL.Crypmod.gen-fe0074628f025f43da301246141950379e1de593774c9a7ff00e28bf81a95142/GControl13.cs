using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

public class GControl13 : Control
{
	public delegate void GDelegate4(object sender);

	private bool bool_0;

	private int int_0;

	[CompilerGenerated]
	private GDelegate4 gdelegate4_0;

	private GControl15.Class8 class8_0;

	public unsafe bool Boolean_0
	{
		get
		{
			//Discarded unreachable code: IL_0012, IL_0018, IL_001e, IL_0024
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_0010: Expected O, but got I4
			sbyte num;
			do
			{
				/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
				checked
				{
					num = (sbyte)unchecked((long)(ulong)/*Error near IL_0005: Stack underflow*/);
				}
			}
			while ((int)/*Error near IL_000d: Stack underflow*/ > (int)num);
			_ = *(uint*)((Array)((short[])/*Error near IL_000f: Stack underflow*/)[/*Error near IL_000f: Stack underflow*/]).LongLength;
			/*Error near IL_0011: Unknown opcode: 0xFB*/;
		}
		set; }

	public extern int Int32_0 { get; set; }

	public extern Color Color_0 { get; set; }

	public extern Color Color_1 { get; set; }

	public extern event GDelegate4 Event_0;

	public extern GControl13();

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected override extern void vmethod_2(MouseEventArgs mouseEventArgs_0);

	protected unsafe override void vmethod_3(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_0025, IL_002a, IL_002c, IL_0035, IL_003e
		//IL_000c: Expected O, but got I
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		uint num2;
		do
		{
			((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (object)/*Error near IL_0002: Stack underflow*/;
			int num = *(int*)(nint)/*Error near IL_0003: Stack underflow*/;
			checked
			{
				this = (GControl13)(nint)unchecked((int)(uint)this);
			}
			((sbyte[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (sbyte)num;
			IntPtr intPtr = (nint)((Array)/*Error near IL_000e: Stack underflow*/).LongLength;
			checked
			{
				num2 = (byte)(*unchecked((double*)((int[])/*Error near IL_0010: Stack underflow*/)[(nint)intPtr]));
			}
		}
		while ((int)/*Error near IL_0019: Stack underflow*/ >= (int)num2 || 0 == 0);
		/*Error near IL_0020: Invalid metadata token*/;
	}

	private void method_0()
	{
		//Discarded unreachable code: IL_0006, IL_000b
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected override extern void vmethod_4();

	unsafe static Delegate jWAdeYjuSYKxgzafJFxsinXYpQKt(Delegate delegate_0, Delegate delegate_1)
	{
		//Discarded unreachable code: IL_001f
		//IL_000b: Expected O, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		}
		while (/*Error near IL_0008: Stack underflow*/ < /*Error near IL_0008: Stack underflow*/);
		delegate_0 = (Delegate)0;
		_ = (ushort)(uint)(checked((int)(~/*Error near IL_000c: Stack underflow*/)) | 0x3BB64875);
		/*Error near IL_001a: Invalid metadata token*/;
	}

	static Delegate gQNfZgfxQMNtbtLDnvpubgKIHlDYA(Delegate delegate_0, Delegate delegate_1)
	{
		//Discarded unreachable code: IL_0013
		_ = (ushort)(uint)(checked((int)/*Error: Stack underflow*/) | 0x3BB64875);
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static void fempvvAlpREEkCzxWRienfRAoHvyA(Control control_0)
	{
		//Discarded unreachable code: IL_0005, IL_0016
		/*Error: Invalid metadata token*/;
	}

	static extern Cursor TgRUyyhbTKEBcerdAEBsJezPbQiO();

	static extern void gGEFgqDeeyeElcVwCTmRDsATUbcUB(Control control_0, Cursor cursor_0);

	static extern Font ZRLJMTKBqpBMsxspaFdQEgLvirIyA(string string_0, float float_0, FontStyle fontStyle_0);

	static extern void dsSPMldCotDngQVnyisrKgDfuMExA(Control control_0, Font font_0);

	unsafe static int bBcRjckEGBsNAujrNAOzfMwhJrjAb(Control control_0)
	{
		//Discarded unreachable code: IL_000d, IL_0015, IL_001a, IL_001f
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		//IL_0006: Expected native int or pointer, but got F8
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		double num = (double)/*Error near IL_0002: Stack underflow*/;
		_003F val = /*Error near IL_0003: Stack underflow*/<< (int)num;
		*(short*)(nint)/*Error near IL_0005: Stack underflow*/ = (short)(int)val;
		byte num2 = *(byte*)(nint)(double)/*Error near IL_0006: Stack underflow*/;
		_ = /*Error near IL_0008: Stack underflow*/& num2;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern int EaHQUgCsTUlmIxpNDFokEtYiaaoCA(Control control_0);

	static extern Bitmap BsuqhRcqgBfrDwtiRDmWKgMHHNQW(int int_1, int int_2);

	static extern Graphics KvSravSkAqehhmQFvsYhoXgEmOtG(Image image_0);

	static extern void SlDCTrMqLCfiCDYbaBFJmsmgjzmtA(Graphics graphics_0, TextRenderingHint textRenderingHint_0);

	static void ytFFZqjuIigUoIhtjOnXEqhyLLwV(Graphics graphics_0, SmoothingMode smoothingMode_0)
	{
		//Discarded unreachable code: IL_0006
		//IL_0008: Unsupported input type for neg.
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Incompatible stack heights: 1 vs 0
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern int RswWSMwUEGBFruNdpMraYvVrCxdI(double double_0);

	static extern Pen PhWhqDRQgHGQABOdQGapIrkIiedxb(Color color_0, float float_0);

	static extern void RkIDPOKJzuaZjgZzAdcHvzlqqeem(Graphics graphics_0, Pen pen_0, int int_1, int int_2, int int_3, int int_4);

	static extern SolidBrush zLCBxpgsvlZnyNjGhVPxPIJTAyRc(Color color_0);

	static extern void WFKdFSMxKGyYGXGDiYUFZeSqcqax(Control control_0, int int_1);

	static extern bool ddLcyQOJRuHpRbDWuAedPhVreLlFA(Control control_0);

	unsafe static Control tAOSrXNEXODTQNMWbxdCZbAMwUak(Control control_0)
	{
		//Discarded unreachable code: IL_001c, IL_0023, IL_0029, IL_0031
		//IL_0003: Expected F4, but got Unknown
		//IL_002c: Invalid comparison between Unknown and I4
		_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (float)val;
		float num = *(float*)(nint)/*Error near IL_0005: Stack underflow*/;
		_ = 0L;
		/*Error near IL_0012: stloc 0 (out-of-bounds)*/;
		checked
		{
			_ = (nuint)num;
			/*Error near IL_0016: Invalid metadata token*/;
		}
	}

	static extern ControlCollection MuETStsDfhncvrUeqtjPOnmzEQMS(Control control_0);

	unsafe static IEnumerator FNmZHcATfIpgxvZFQtJpTwHzWNMq(ArrangedElementCollection arrangedElementCollection_0)
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_0015
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static object EhgRnZDFBHtHucgYQGrpYYOmBDco(IEnumerator ienumerator_0)
	{
		return (object)/*OpCode not supported: Nop*/;
	}

	static bool qePlPyUgeUIBkTuEyyZUJRRCRXgT(IEnumerator ienumerator_0)
	{
		//Discarded unreachable code: IL_000a
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0006: Stack underflow*/ > 0)
		{
		}
		checked
		{
			_ = /*Error near IL_0007: Stack underflow*/* /*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0009: Unknown opcode: 0xFD*/;
		}
	}

	unsafe static void lkEeZtTJvvquzCaErXjHRaqMKuqg(IDisposable idisposable_0)
	{
		//IL_0001: Invalid comparison between Unknown and I8
		//IL_0019: Incompatible stack heights: 0 vs 1
		while (true)
		{
			long num = (long)/*Error near IL_0001: Stack underflow*/;
			if ((long)/*Error near IL_0006: Stack underflow*/ != num)
			{
				*(_003F*)(nint)/*Error near IL_0007: Stack underflow*/ = /*Error near IL_0007: Stack underflow*/;
				checked
				{
					_ = (sbyte)/*Error near IL_0008: Stack underflow*/;
				}
				if (0 < (nint)(*(IntPtr*)(nint)3))
				{
					break;
				}
			}
		}
		_ = 2552756530550548501L;
		/*Error: Unexpected end of block*/;
	}
}
