using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl11 : Control
{
	public delegate void GDelegate3(object sender);

	internal sealed class Class7
	{
		internal TextBox textBox_0;

		internal HorizontalAlignment horizontalAlignment_0;

		internal bool bool_0;

		internal string string_0;

		internal bool bool_1;

		internal Color color_0;

		internal unsafe Class7()
		{
			//Discarded unreachable code: IL_0011, IL_0018, IL_001d, IL_002b, IL_0034
			//IL_0004: Expected O, but got I4
			//IL_000a: Expected F4, but got I4
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected I8, but got F8
			int num = *(int*)2;
			((object[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (short)num;
			*(float*)(nint)/*Error near IL_000a: Stack underflow*/ = 1.6164877E+09f;
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}

	private static bool bool_0;

	[CompilerGenerated]
	private GDelegate3 gdelegate3_0;

	private GControl20.Struct4 struct4_0;

	public bool Boolean_0
	{
		get; set
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public unsafe Color Color_0
	{
		get; set
		{
			//IL_0002: Invalid comparison between Unknown and F8
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
				double num = *(double*)(nint)/*Error near IL_0002: Stack underflow*/;
				if (!((double)/*Error near IL_0007: Stack underflow*/ <= num) && 0uL <= (ulong)checked((long)unchecked((uint)(*(short*)8))))
				{
					_003F val = /*Error near IL_0012: Stack underflow*/* /*Error near IL_0012: Stack underflow*/;
					if (/*Error near IL_0019: Stack underflow*/ < val)
					{
						break;
					}
				}
			}
		}
	}

	public unsafe Color Color_1
	{
		get; set
		{
			//Discarded unreachable code: IL_0006, IL_000c, IL_0012, IL_0018
			//IL_0013: Invalid comparison between Unknown and O
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public event GDelegate3 Event_0
	{
		[CompilerGenerated]
		add;
		[CompilerGenerated]
		remove
		{
			//Discarded unreachable code: IL_000b, IL_0014, IL_001b, IL_001d, IL_0020
			//IL_000f: Invalid comparison between Unknown and I4
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (long)((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
				_ = (sbyte)(object)value;
				/*Error near IL_0006: Invalid metadata token*/;
			}
		}
	}

	public extern GControl11();

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	protected unsafe override void vmethod_1(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_0012
		//IL_000e: Expected I4, but got F8
		((short[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/] = 0;
		checked
		{
			_ = (ushort)(*unchecked((nint*)(nint)/*Error near IL_0010: Stack underflow*/));
			/*Error near IL_0011: Unknown opcode: 0xFD*/;
		}
	}

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	static extern Delegate fvqOpLRjhLRtLkePmJLLSqxUzIoL(Delegate delegate_0, Delegate delegate_1);

	static extern Delegate DHaRMeIjPwdznBwvOWjimircgyDHA(Delegate delegate_0, Delegate delegate_1);

	static extern void kPRGFNCHWUjLJmpQESvYApRkKlLJ(Control control_0);

	static extern Cursor hNtCupFSUxWKOindUMFpBzJJkjfm();

	static extern void xcMfQQSJFyNQdJUIUnFeDLmKdUvO(Control control_0, Cursor cursor_0);

	static extern int gAZJPsbQpzyXLItMbwTEBYjrRwCj(Control control_0);

	static extern int pGQHuXePMJlWbrcLrugKdISwCiVKA(Control control_0);

	static extern Bitmap JvOaqMjilQdPHzbjqirdquqjSHQIA(int int_0, int int_1);

	static extern Graphics IqwkGtqBoVsdaGWVPivngiRrXxkf(Image image_0);

	unsafe static void UJoaKurAqqAmLAzCZAgjqcqxBGjib(Graphics graphics_0, TextRenderingHint textRenderingHint_0)
	{
		//Discarded unreachable code: IL_0011, IL_0018, IL_0021, IL_0029, IL_0034
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0013: Incompatible stack heights: 0 vs 1
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		ushort num;
		do
		{
			num = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ < (int)num);
		checked
		{
			int num2 = (int)/*Error near IL_0008: Stack underflow*/;
			((int[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = num2;
			_ = ~(ushort)/*Error near IL_000b: Stack underflow*/;
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}

	static extern void tWgOoTvAXKfRoQdZbhjYGUvqpnXW(Graphics graphics_0, SmoothingMode smoothingMode_0);

	static extern void yqOUtNpyerNgxvvpjjPkzhMBOgdh(Control control_0, int int_0);
}
