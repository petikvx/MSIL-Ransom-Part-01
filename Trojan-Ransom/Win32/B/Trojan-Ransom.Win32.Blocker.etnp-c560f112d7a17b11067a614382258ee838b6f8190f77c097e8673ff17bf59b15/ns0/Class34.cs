using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0;

internal sealed class Class34
{
	private struct Struct17
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct17(Rectangle CO_)
		{
			int_0 = CO_.Left;
			int_1 = CO_.Top;
			int_3 = CO_.Bottom;
			int_2 = CO_.Right;
		}
	}

	private struct Struct18
	{
		public int int_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public byte byte_0;

		private byte byte_1;
	}

	public struct Struct19
	{
		public ushort ushort_0;

		private ushort ushort_1;

		public uint uint_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	private static bool bool_0;

	private static Struct18 struct18_0;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string CO_, int CO_, ref int CO_, ref int CO_, int CO_);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr CO_, string CO_, int CO_, ref Struct17 CO_, int CO_);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr CO_, IntPtr CO_);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct18 CO_);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int CO_);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref Struct19 CO_);

	[SpecialName]
	private static Struct18 smethod_0()
	{
		if (!bool_0)
		{
			struct18_0 = default(Struct18);
			try
			{
				do
				{
					struct18_0.int_0 = Marshal.SizeOf(typeof(Struct18));
					do
					{
						GetVersionEx(ref struct18_0);
					}
					while (false);
					bool_0 = true;
				}
				while (false);
			}
			catch
			{
			}
		}
		return struct18_0;
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		try
		{
			Struct19 CO_;
			do
			{
				CO_ = default(Struct19);
			}
			while (5 == 0 || 8 == 0);
			GetSystemInfo(ref CO_);
			int num = CO_.ushort_0;
			do
			{
				num = ((num == 9) ? 1 : 0);
			}
			while ((3 == 0) ? true : false);
			return (byte)num != 0;
		}
		catch
		{
			return false;
		}
	}

	[SpecialName]
	internal static bool smethod_2()
	{
		bool result;
		try
		{
			do
			{
				if (4u != 0)
				{
					int num = GetSystemMetrics(89);
					int num2 = 0;
					if (num2 == 0)
					{
						num = ((num == num2) ? 1 : 0);
						num2 = 0;
					}
					result = num == num2;
				}
			}
			while (false);
			return result;
		}
		catch
		{
			if (3u != 0)
			{
				return false;
			}
			return result;
		}
	}

	[SpecialName]
	internal static bool smethod_3()
	{
		return smethod_0().byte_0 == 1;
	}

	[SpecialName]
	internal static string smethod_4()
	{
		return smethod_0().string_0;
	}

	public static Icon smethod_5()
	{
		try
		{
			if (true)
			{
				return smethod_6();
			}
			Icon result;
			return result;
		}
		catch (Exception)
		{
			return Class28.smethod_1(Class5.smethod_0(82675));
		}
	}

	private static Icon smethod_6()
	{
		int num = 0;
		int CO_ = default(int);
		if (num == 0)
		{
			CO_ = num;
			int CO_2 = 0;
			int num2 = ExtractIconEx(Application.get_ExecutablePath(), -1, ref CO_2, ref CO_2, 1);
			if (num2 <= 0)
			{
				goto IL_003c;
			}
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref CO_, ref CO_2, 1);
			num = CO_;
		}
		if (num != 0)
		{
			return Icon.FromHandle(new IntPtr(CO_));
		}
		goto IL_003c;
		IL_003c:
		return null;
	}

	internal static int smethod_7(Graphics CO_, string CO_, Font CO_, int CO_)
	{
		int num = default(int);
		try
		{
			num = smethod_9(CO_, CO_, CO_, CO_);
		}
		catch (Exception)
		{
			try
			{
				if (uint.MaxValue != 0)
				{
					num = Convert.ToInt32((double)smethod_8(CO_, CO_, CO_, CO_) * 1.1);
				}
				goto end_IL_000c;
			}
			catch (Exception)
			{
			}
			goto IL_0031;
			end_IL_000c:;
		}
		goto IL_0034;
		IL_0034:
		if (4 == 0)
		{
			goto IL_0031;
		}
		int result = num;
		if (0 == 0)
		{
			return result;
		}
		goto IL_003d;
		IL_0031:
		if (4 == 0)
		{
			goto IL_0034;
		}
		result = 0;
		goto IL_003d;
		IL_003d:
		return result;
	}

	private static int smethod_8(Graphics CO_, string CO_, Font CO_, int CO_)
	{
		return Size.Ceiling(CO_.MeasureString(CO_, CO_, CO_)).Height;
	}

	private static int smethod_9(Graphics CO_, string CO_, Font CO_, int CO_)
	{
		Struct17 CO_2;
		if (6u != 0)
		{
			CO_2 = new Struct17(new Rectangle(0, 0, CO_, 10000));
			goto IL_001c;
		}
		goto IL_0055;
		IL_0032:
		IntPtr cO_;
		IntPtr cO_2;
		IntPtr intPtr = SelectObject(cO_, cO_2);
		if (false)
		{
			goto IL_0067;
		}
		IntPtr hdc;
		int cO_3;
		int result = DrawText(hdc, CO_, -1, ref CO_2, cO_3);
		if (0 == 0)
		{
			goto IL_0055;
		}
		goto IL_0076;
		IL_0055:
		if (false)
		{
			goto IL_001c;
		}
		cO_ = hdc;
		cO_2 = intPtr;
		if (false)
		{
			goto IL_0032;
		}
		SelectObject(cO_, cO_2);
		CO_.ReleaseHdc(hdc);
		goto IL_0067;
		IL_0076:
		return result;
		IL_0067:
		result = CO_2.int_3 - CO_2.int_1;
		goto IL_0076;
		IL_001c:
		cO_3 = 3088;
		hdc = CO_.GetHdc();
		IntPtr intPtr2 = CO_.ToHfont();
		cO_ = hdc;
		cO_2 = intPtr2;
		goto IL_0032;
	}
}
