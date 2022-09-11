using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GControl2 : ContainerControl
{
	public enum GEnum0
	{
		Enabled,
		Disabled
	}

	private GEnum0 genum0_0;

	public unsafe GEnum0 GEnum0_0
	{
		get; set
		{
			//Discarded unreachable code: IL_0017, IL_001d, IL_0026, IL_002b
			//IL_0003: Expected F8, but got I4
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Invalid comparison between Unknown and I
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			nint num3;
			do
			{
				short num = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
				((double[])/*Error near IL_0003: Stack underflow*/)[num] = -1.0;
				/*OpCode not supported: Ckfinite*/;
				long num2 = ((long[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/];
				checked
				{
					num3 = (nint)(nuint)unchecked(/*Error near IL_0006: Stack underflow*/ / num2);
				}
			}
			while ((nint)/*Error near IL_000e: Stack underflow*/ > num3);
			_ = *(int*)(nint)/*Error near IL_000f: Stack underflow*/;
			/*Error near IL_0012: Invalid metadata token*/;
		}
	}

	public extern GControl2();

	protected unsafe override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//Discarded unreachable code: IL_0012, IL_0019, IL_001e, IL_0021, IL_002c
		//IL_0005: Expected I8, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			object obj = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			*(long*)(nint)/*Error near IL_0005: Stack underflow*/ = (nint)(nuint)obj;
			val = /*Error near IL_0006: ldloca 0 (out-of-bounds)*/;
		}
		while (/*Error near IL_000d: Stack underflow*/ != val);
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static void dZNDqEefWtCIeUBrcYYndYbIMattA(Control control_0)
	{
		//Discarded unreachable code: IL_0005, IL_0016
		/*Error: Invalid metadata token*/;
	}

	static extern void npdLFtCARriGvqqHTaQrDKSXbQZuA(Control control_0, Color color_0);

	static extern void YHtxpeQHHfEWHhGDQUSlFarzdHsuA(Control control_0, Color color_0);

	unsafe static int LyraxQUXJqfBUKeLfGHTuvAqBoFT(Control control_0)
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

	static extern int zCLjzHsdDpyZXeYemkPPvQDvppFx(Control control_0);

	static extern Bitmap zKkAonoQaqMFUnwgSJqxWUVkoWXh(int int_0, int int_1);

	static extern Graphics BuzVbDLvvPOzolxVBiViChVpKNOC(Image image_0);

	static extern Color VleBwmWSPQGDcXnwwTVqqNBMBvdN(Control control_0);

	static extern void MUwzlKiieRgUXVEZiVpaJDPuuKXG(Graphics graphics_0, Color color_0);

	static extern Font wfLwyrYCJvNtUbmgkxVLFJJqAepB(string string_0, float float_0, FontStyle fontStyle_0);

	static void ZzGvSqyDmoxhhOpNouPcZRVztTtK(Graphics graphics_0, SmoothingMode smoothingMode_0)
	{
		//Discarded unreachable code: IL_0006
		//IL_0008: Unsupported input type for neg.
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Incompatible stack heights: 1 vs 0
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern SolidBrush BXAsqTQAvodMVoJxTAqknkziFSfgA(Color color_0);

	static void oFMJCxLQdlUFbFYepWONmfhHgnKcA(Graphics graphics_0, Brush brush_0, Rectangle rectangle_0)
	{
		while (true)
		{
			_003F val = /*Error: ldloc 3 (out-of-bounds)*/;
			if (/*Error near IL_0007: Stack underflow*/ >= val)
			{
				/*Error: Could not find block for branch target IL_0007*/;
			}
		}
	}

	static extern Pen dtwrbEUOfVrcSZNhRbmwyiRvfMHj(Brush brush_0);

	static extern void otdfkxkReEihkuZEgfRKUHhDijiLA(Graphics graphics_0, Pen pen_0, int int_0, int int_1, int int_2, int int_3);

	static extern string GotMxiUWNdoBsTKYpAcmBNRvqlZS(Control control_0);

	static extern Brush DXRwYiIpjDccXSwTkAagDoCMuNSB();
}
