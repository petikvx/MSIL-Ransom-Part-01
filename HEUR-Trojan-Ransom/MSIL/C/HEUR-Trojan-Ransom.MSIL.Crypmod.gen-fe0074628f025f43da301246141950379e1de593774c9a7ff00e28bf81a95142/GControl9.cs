using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

public class GControl9 : TabControl
{
	public struct GStruct0
	{
		public bool bool_0;

		public Point point_0;
	}

	internal sealed class Class6
	{
		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal unsafe Class6()
		{
			//Discarded unreachable code: IL_0009
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			IntPtr intPtr = *(IntPtr*)(nint)/*Error near IL_0001: Stack underflow*/;
			((short[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (short)(nint)intPtr;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	private GStruct0 gstruct0_0;

	private Color color_0;

	private Color color_1;

	private Color color_2;

	private Color color_3;

	private Color color_4;

	private Color color_5;

	private Color color_6;

	private GControl15.Class8 class8_0;

	public extern Color Color_0 { get; set; }

	public Color Color_1
	{
		get
		{
			//Discarded unreachable code: IL_0005, IL_000a, IL_0010, IL_0015, IL_001a, IL_0021, IL_0026, IL_002b, IL_0031, IL_003b
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Incompatible stack heights: 0 vs 1
			checked
			{
				_ = (/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/) * null;
				/*Error near IL_0004: Unknown opcode: 0xF9*/;
			}
		}
		set; }

	public unsafe Color Color_2
	{
		get
		{
			//Discarded unreachable code: IL_000a, IL_000f, IL_0015, IL_001b, IL_002c
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
			}
			/*Error near IL_0005: Invalid metadata token*/;
		}
		set
		{
			//Discarded unreachable code: IL_000a, IL_000d, IL_0015, IL_001b, IL_0023
			//IL_0002: Invalid comparison between Unknown and I4
			//IL_0024: Expected native int or pointer, but got F8
			//IL_002c: Expected O, but got I4
			int num;
			do
			{
				num = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
			}
			while ((int)/*Error near IL_0007: Stack underflow*/ != num);
			_ = ((Array)/*Error near IL_0009: Stack underflow*/).LongLength;
			/*Error near IL_0009: Unknown opcode: 0xFD*/;
		}
	}

	public extern Color Color_3 { get; set; }

	public extern Color Color_4 { get; set; }

	public unsafe Color Color_5
	{
		get
		{
			//Discarded unreachable code: IL_0017
			//IL_0012: Incompatible stack heights: 0 vs 2
			while (true)
			{
				*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
				_003F val = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
				checked
				{
					if (/*Error near IL_0008: Stack underflow*/ != val)
					{
						_ = (sbyte)((double[])unchecked((nint)(*(IntPtr*)(int)checked((byte)/*Error near IL_000a: Stack underflow*/))))[4];
						_ = 8;
					}
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0028, IL_002e, IL_0033
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected F4, but got I4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Invalid comparison between Unknown and I8
			//IL_0023: Expected F4, but got I8
			//IL_0035: Expected F8, but got O
			do
			{
				int num = *(int*)(nint)(/*Error near IL_0001: Stack underflow*/ << (int)/*Error near IL_0001: Stack underflow*/);
				_ = -675009808;
				/*Error near IL_0008: stloc 3 (out-of-bounds)*/;
				checked
				{
					sbyte num2 = (sbyte)unchecked((uint)num);
					((float[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/] = num2;
				}
				long num3;
				do
				{
					num3 = /*Error near IL_000f: Stack underflow*/% /*Error near IL_000f: Stack underflow*/;
				}
				while ((long)/*Error near IL_0013: Stack underflow*/ > num3);
			}
			while (/*Error near IL_0018: Stack underflow*/ >= /*Error near IL_0018: Stack underflow*/);
			*(float*)(nint)/*Error near IL_0023: Stack underflow*/ = 5.8290895E+18f;
			/*Error near IL_0023: Invalid metadata token*/;
		}
	}

	public extern Color Color_6 { get; set; }

	public extern Color Color_7 { get; set; }

	public unsafe Color Color_8
	{
		get
		{
			//IL_0002: Expected native int or pointer, but got O
			//IL_0003: Invalid comparison between Unknown and I4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			ushort num;
			do
			{
				num = *(ushort*)(nint)this;
			}
			while ((int)/*Error near IL_0008: Stack underflow*/ > (int)num);
			nuint num2;
			checked
			{
				num2 = (nuint)(/*Error near IL_000b: Stack underflow*/ >> unchecked((int)/*Error near IL_000b: Stack underflow*/));
			}
			*(float*)(nint)(/*Error near IL_000d: Stack underflow*/ - num2) = 2.0450561E-29f;
			throw /*Error near IL_0017: Stack underflow*/;
		}
		set; }

	public extern GControl9();

	protected override extern void vmethod_0(EventArgs eventArgs_0);

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected override extern void vmethod_2(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_3();

	protected override extern void vmethod_4(PaintEventArgs paintEventArgs_0);

	static extern void opVEJQzIHLkRKlTCAwSeCYrliFVK(TabControl tabControl_0, TabSizeMode tabSizeMode_0);

	static extern void ZUZPplPwxjvsoCCSieTwAvnNWkIB(Control control_0, DockStyle dockStyle_0);

	static void qarHZHgbgrouOrfxScseVBndoHQlA(Control control_0)
	{
		//Discarded unreachable code: IL_0005, IL_0016
		/*Error: Invalid metadata token*/;
	}

	static extern TabPageCollection LtpKOMvoiUKdfXufqDWgTTXnYjvg(TabControl tabControl_0);

	static extern IEnumerator FEWAmKgiYrJvoFYPZahNMrPXJvbCb(TabPageCollection tabPageCollection_0);

	static object mmVjtKUBFEemJbOEgfbUlbhQOlTm(IEnumerator ienumerator_0)
	{
		return (object)/*OpCode not supported: Nop*/;
	}

	static extern Rectangle mMwwnPzzYSjJnWqebzqfXJgFJhpD(Control control_0);

	static extern Point oSqPFBSCyqpyPztIGNdeIvxXFOHh(MouseEventArgs mouseEventArgs_0);

	static extern void gROpsunCHjjXlTPGSIcjkwuqTcETA(Control control_0, Color color_7);

	static bool goqElrkizgkOeyxNKWsmEZKtXNYA(IEnumerator ienumerator_0)
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

	unsafe static void TRcdonBxTUPmiwPouSVddDGjglmj(IDisposable idisposable_0)
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

	unsafe static int rEoDQTJqnqEnoRVJwPelChzNDvgF(Control control_0)
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

	static extern int kgCIbNtSGjZRhWzwWHuyFJucEhki(Control control_0);

	static extern Bitmap GPsGrYVxqXavDDpvjJgBbUJznIIkA(int int_0, int int_1);

	static extern Graphics jKKCQflmvWkwBwFeaMxjGNpbrWKU(Image image_0);

	static extern void cMOMekYOwRYklSCWnxmWMOOTxeTl(Graphics graphics_0, InterpolationMode interpolationMode_0);

	static extern void GYYWyeBCZZeUHZWicpOOOObYpPnd(Graphics graphics_0, TextRenderingHint textRenderingHint_0);

	static extern SolidBrush siNCEsNvqhYdutowMDwjAUZAyOYN(Color color_7);
}
