using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BAFtn8MT09F52hXL1NN;
using ProwxkN4F4ab5Fc8FL;

namespace LYGYSgYwZZQHi0dvtur;

internal sealed class xAjiqWY1RtDWwMdfIUA
{
	private struct mJLrpwYeMQInq1JWeVh
	{
		public int aYgAERFZ3e;

		public int LkFAaLSOsP;

		public int YISABhTEDG;

		public int jSVA0GMsSb;

		public mJLrpwYeMQInq1JWeVh(Rectangle rectangle_0)
		{
			if (LHTPbgCClpGdEojUjnG())
			{
				switch (2)
				{
				case 2:
					break;
				case 1:
				case 4:
					goto IL_003f;
				case 0:
					goto IL_004c;
				default:
					goto IL_0059;
				case 6:
					return;
				}
			}
			aYgAERFZ3e = rectangle_0.Left;
			goto IL_003f;
			IL_0059:
			YISABhTEDG = rectangle_0.Right;
			return;
			IL_004c:
			jSVA0GMsSb = rectangle_0.Bottom;
			goto IL_0059;
			IL_003f:
			LkFAaLSOsP = rectangle_0.Top;
			goto IL_004c;
		}

		internal static bool LHTPbgCClpGdEojUjnG()
		{
			return true;
		}

		internal static bool JVAUgBCXBD1NAjCsEJh()
		{
			return false;
		}
	}

	private struct JFKn7yYxxIgkTKphKyf
	{
		public int xgGAZYb9yo;

		public uint JhBA41sCX0;

		public uint VcaAnUgmol;

		public uint fXdAGFDqac;

		public uint lT5AI5RJAS;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string D6mA8tfKHl;

		public ushort eDpAF2ytSV;

		public ushort yArAgrgEGl;

		public ushort wtbAswNhYT;

		public byte AOtA2BpvJi;

		private byte M52A9inSgv;
	}

	public struct dHcxHTYVa2NwGAWG8M2
	{
		public ushort MRAATVVxXp;

		private ushort VnyAlQtE8N;

		public uint iy1AmfuD7A;

		public IntPtr HYwANpGgH4;

		public IntPtr rZPAfGtX9l;

		public IntPtr imEA5meBuG;

		public uint YGHADvyCSQ;

		public uint QpZA3VxfTC;

		public uint u7wAvkBVQU;

		public ushort Bk6Aya2QPk;

		public ushort wsAAzanNxb;
	}

	private static bool IT9A6taX3Q;

	private static JFKn7yYxxIgkTKphKyf jcSAoVjxUa;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref mJLrpwYeMQInq1JWeVh mJLrpwYeMQInq1JWeVh_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref JFKn7yYxxIgkTKphKyf jfkn7yYxxIgkTKphKyf_0);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.Dll")]
	private static extern void GetSystemInfo(ref dHcxHTYVa2NwGAWG8M2 dHcxHTYVa2NwGAWG8M2_0);

	[SpecialName]
	private static JFKn7yYxxIgkTKphKyf smethod_0()
	{
		if (!IT9A6taX3Q)
		{
			jcSAoVjxUa = default(JFKn7yYxxIgkTKphKyf);
			try
			{
				jcSAoVjxUa.xgGAZYb9yo = Marshal.SizeOf(typeof(JFKn7yYxxIgkTKphKyf));
				GetVersionEx(ref jcSAoVjxUa);
				IT9A6taX3Q = true;
			}
			catch
			{
			}
		}
		return jcSAoVjxUa;
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		try
		{
			dHcxHTYVa2NwGAWG8M2 dHcxHTYVa2NwGAWG8M2_ = default(dHcxHTYVa2NwGAWG8M2);
			GetSystemInfo(ref dHcxHTYVa2NwGAWG8M2_);
			return dHcxHTYVa2NwGAWG8M2_.MRAATVVxXp == 9;
		}
		catch
		{
			return false;
		}
	}

	[SpecialName]
	internal static bool smethod_2()
	{
		try
		{
			return GetSystemMetrics(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	[SpecialName]
	internal static bool smethod_3()
	{
		return smethod_0().AOtA2BpvJi == 1;
	}

	[SpecialName]
	internal static string smethod_4()
	{
		return smethod_0().D6mA8tfKHl;
	}

	public static Icon QNsAORfppT()
	{
		try
		{
			return HwCAjREmVS();
		}
		catch (Exception)
		{
			return rITYfQM9BT4MKIrlIxO.rAUKJJjQhB(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681987));
		}
	}

	private static Icon HwCAjREmVS()
	{
		int int_ = 0;
		int int_2 = 0;
		int num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
		if (num > 0)
		{
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
			if (int_ != 0)
			{
				return Icon.FromHandle(new IntPtr(int_));
			}
		}
		return null;
	}

	internal static int VKcAC4ij3o(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		try
		{
			return xI5ASigZBc(graphics_0, string_0, font_0, int_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)ukxAqDEqfN(graphics_0, string_0, font_0, int_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	private static int ukxAqDEqfN(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	private static int xI5ASigZBc(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		IntPtr intptr_ = default(IntPtr);
		IntPtr intptr_2 = default(IntPtr);
		while (true)
		{
			mJLrpwYeMQInq1JWeVh mJLrpwYeMQInq1JWeVh_ = new mJLrpwYeMQInq1JWeVh(new Rectangle(0, 0, int_0, 10000));
			while (true)
			{
				int int_ = 3088;
				while (true)
				{
					IntPtr hdc = graphics_0.GetHdc();
					if (!vfcBleC4CHjc9isa8ol())
					{
						switch (4)
						{
						case 7:
							break;
						case 5:
							goto end_IL_0003;
						case 0:
						case 1:
							goto end_IL_0049;
						case 4:
							intptr_ = font_0.ToHfont();
							goto case 3;
						case 3:
							intptr_2 = SelectObject(hdc, intptr_);
							goto default;
						default:
							DrawText(hdc, string_0, -1, ref mJLrpwYeMQInq1JWeVh_, int_);
							goto case 6;
						case 6:
						case 8:
							SelectObject(hdc, intptr_2);
							goto IL_0094;
						case 2:
							goto IL_0094;
						case 10:
							goto IL_009b;
						}
						continue;
					}
					goto IL_0094;
					IL_009b:
					return mJLrpwYeMQInq1JWeVh_.jSVA0GMsSb - mJLrpwYeMQInq1JWeVh_.LkFAaLSOsP;
					IL_0094:
					graphics_0.ReleaseHdc(hdc);
					goto IL_009b;
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
	}

	internal static bool D8GpWQCoTwGiRbKpQPW()
	{
		return true;
	}

	internal static bool vfcBleC4CHjc9isa8ol()
	{
		return false;
	}
}
