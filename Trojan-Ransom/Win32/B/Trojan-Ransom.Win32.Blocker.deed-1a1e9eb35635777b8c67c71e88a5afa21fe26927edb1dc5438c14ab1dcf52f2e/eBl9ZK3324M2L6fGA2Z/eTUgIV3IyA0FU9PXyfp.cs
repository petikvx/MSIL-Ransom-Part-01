using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using eC98jAqdnPLlDITmK6;
using ehk9wbIn9KPgnTW5hn8;
using etKNQTu9kgqwCqmIAv;

namespace eBl9ZK3324M2L6fGA2Z;

internal class eTUgIV3IyA0FU9PXyfp
{
	private struct eUvWrD3y2JDW9bKWsD2
	{
		public int eulODlten;

		public int ecs0D1Zdd;

		public int e9jslfSvk;

		public int eeN1kpseb;

		public eUvWrD3y2JDW9bKWsD2(Rectangle rectangle_0)
		{
			eulODlten = rectangle_0.Left;
			_ = 0;
			if (eeqRCvfnpQ2Z8Qooqon())
			{
				ecs0D1Zdd = rectangle_0.Top;
				if (!emRW24fPhQ0uc26vnhH())
				{
					eeN1kpseb = rectangle_0.Bottom;
				}
			}
			e9jslfSvk = rectangle_0.Right;
		}

		internal static bool eeqRCvfnpQ2Z8Qooqon()
		{
			return true;
		}

		internal static bool emRW24fPhQ0uc26vnhH()
		{
			return false;
		}
	}

	private struct ekHmIX3g4LLHYZPujl9
	{
		public int eulODlten;

		public uint ecs0D1Zdd;

		public uint e9jslfSvk;

		public uint eeN1kpseb;

		public uint elN6Gg9Qb;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string eKyrTQhVp;

		public ushort euXHswL8F;

		public ushort eo2Gig6Qf;

		public ushort e8AuvEGCG;

		public byte eb1x595Bx;

		private byte ep2oBURlk;
	}

	public struct ejdvGP3bbSqjJ5jJEGJ
	{
		public ushort eulODlten;

		private ushort ecs0D1Zdd;

		public uint e9jslfSvk;

		public IntPtr eeN1kpseb;

		public IntPtr elN6Gg9Qb;

		public IntPtr eKyrTQhVp;

		public uint euXHswL8F;

		public uint eo2Gig6Qf;

		public uint e8AuvEGCG;

		public ushort eb1x595Bx;

		public ushort ep2oBURlk;
	}

	private static bool eSmVD9nBi;

	private static ekHmIX3g4LLHYZPujl9 ePK4VF7eF;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eirmvo2dG;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref eUvWrD3y2JDW9bKWsD2 eUvWrD3y2JDW9bKWsD2_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref ekHmIX3g4LLHYZPujl9 ekHmIX3g4LLHYZPujl9_0);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.Dll")]
	private static extern void GetSystemInfo(ref ejdvGP3bbSqjJ5jJEGJ ejdvGP3bbSqjJ5jJEGJ_0);

	[SpecialName]
	private static ekHmIX3g4LLHYZPujl9 smethod_0()
	{
		eKRhGJf3ouOYi76xhUG();
		if (!eZJaktfOSykdDWMEa6H() || !eSmVD9nBi)
		{
			ePK4VF7eF = default(ekHmIX3g4LLHYZPujl9);
			try
			{
				ePK4VF7eF.eulODlten = ebisamfe8LuRyXc2aY6(e86ccTfFbf3IJKUioN9(typeof(ekHmIX3g4LLHYZPujl9).TypeHandle));
				GetVersionEx(ref ePK4VF7eF);
				_ = 0;
				if (eZJaktfOSykdDWMEa6H())
				{
				}
				eSmVD9nBi = true;
			}
			catch
			{
			}
		}
		return ePK4VF7eF;
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		try
		{
			ejdvGP3bbSqjJ5jJEGJ ejdvGP3bbSqjJ5jJEGJ_ = default(ejdvGP3bbSqjJ5jJEGJ);
			eKRhGJf3ouOYi76xhUG();
			if (eZJaktfOSykdDWMEa6H())
			{
				if (eZJaktfOSykdDWMEa6H())
				{
				}
				GetSystemInfo(ref ejdvGP3bbSqjJ5jJEGJ_);
			}
			return ejdvGP3bbSqjJ5jJEGJ_.eulODlten == 9;
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
		return eXlNr2fKfePLjUZc0Kd().eb1x595Bx == 1;
	}

	[SpecialName]
	internal static string smethod_4()
	{
		return eXlNr2fKfePLjUZc0Kd().eKyrTQhVp;
	}

	public static Icon euXHswL8F()
	{
		try
		{
			return (Icon)eHZnWbfsTB7BXnyL0bb();
		}
		catch (Exception)
		{
			return (Icon)eD5xhPfIkNIwIKFex0h(eirmvo2dG(25648));
		}
	}

	private static Icon eo2Gig6Qf()
	{
		int int_ = 0;
		int int_2 = 0;
		int num = ExtractIconEx((string)etuSZsf0jdNviTiDpPJ(), -1, ref int_2, ref int_2, 1);
		if (num > 0)
		{
			ExtractIconEx((string)etuSZsf0jdNviTiDpPJ(), 0, ref int_, ref int_2, 1);
			if (int_ != 0)
			{
				return (Icon)eRGIQ4fhZVMgPSVVWXH(new IntPtr(int_));
			}
		}
		return null;
	}

	internal static int e8AuvEGCG(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		_ = 1;
		if (!eKRhGJf3ouOYi76xhUG())
		{
			try
			{
				return exE1BGfAkIpW6SShYDr(graphics_0, string_0, font_0, int_0);
			}
			catch (Exception)
			{
				try
				{
					return eQV6C4fHckdGT6xkL2i((double)ei8Zh7fBUXjprDSlsGM(graphics_0, string_0, font_0, int_0) * 1.1);
				}
				catch (Exception)
				{
				}
			}
		}
		return 0;
	}

	private static int eb1x595Bx(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		return eWwOc4fcg1ln3J1U0id(euCIE3fWpVHMfo3BDo4(graphics_0, string_0, font_0, int_0)).Height;
	}

	private static int ep2oBURlk(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		eUvWrD3y2JDW9bKWsD2 eUvWrD3y2JDW9bKWsD2_ = new eUvWrD3y2JDW9bKWsD2(new Rectangle(0, 0, int_0, 10000));
		IntPtr intptr_ = eQGvEUfU3t64KdOlExN(graphics_0);
		IntPtr intptr_2 = ewdc0TflGmZ9GckFGTk(font_0);
		IntPtr intptr_3 = SelectObject(intptr_, intptr_2);
		DrawText(intptr_, string_0, -1, ref eUvWrD3y2JDW9bKWsD2_, 3088);
		SelectObject(intptr_, intptr_3);
		eoOktcfNBxvMMJcUq0E(graphics_0, intptr_);
		return eUvWrD3y2JDW9bKWsD2_.eeN1kpseb - eUvWrD3y2JDW9bKWsD2_.ecs0D1Zdd;
	}

	static eTUgIV3IyA0FU9PXyfp()
	{
		ejZjshfrM5gtDQONfFo(e86ccTfFbf3IJKUioN9(typeof(eTUgIV3IyA0FU9PXyfp).TypeHandle));
	}

	internal static Type e86ccTfFbf3IJKUioN9(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int ebisamfe8LuRyXc2aY6(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	internal static bool eZJaktfOSykdDWMEa6H()
	{
		return true;
	}

	internal static bool eKRhGJf3ouOYi76xhUG()
	{
		return false;
	}

	internal static ekHmIX3g4LLHYZPujl9 eXlNr2fKfePLjUZc0Kd()
	{
		return smethod_0();
	}

	internal static object eHZnWbfsTB7BXnyL0bb()
	{
		return eo2Gig6Qf();
	}

	internal static object eD5xhPfIkNIwIKFex0h(object object_0)
	{
		return eRfn8RIiZZHJMAiKnX6.ecs0D1Zdd((string)object_0);
	}

	internal static object etuSZsf0jdNviTiDpPJ()
	{
		return Application.get_ExecutablePath();
	}

	internal static object eRGIQ4fhZVMgPSVVWXH(IntPtr intptr_0)
	{
		return Icon.FromHandle(intptr_0);
	}

	internal static int exE1BGfAkIpW6SShYDr(object object_0, object object_1, object object_2, int int_0)
	{
		return ep2oBURlk((Graphics)object_0, (string)object_1, (Font)object_2, int_0);
	}

	internal static int ei8Zh7fBUXjprDSlsGM(object object_0, object object_1, object object_2, int int_0)
	{
		return eb1x595Bx((Graphics)object_0, (string)object_1, (Font)object_2, int_0);
	}

	internal static int eQV6C4fHckdGT6xkL2i(double double_0)
	{
		return Convert.ToInt32(double_0);
	}

	internal static SizeF euCIE3fWpVHMfo3BDo4(object object_0, object object_1, object object_2, int int_0)
	{
		return ((Graphics)object_0).MeasureString((string)object_1, (Font)object_2, int_0);
	}

	internal static Size eWwOc4fcg1ln3J1U0id(SizeF sizeF_0)
	{
		return Size.Ceiling(sizeF_0);
	}

	internal static IntPtr eQGvEUfU3t64KdOlExN(object object_0)
	{
		return ((Graphics)object_0).GetHdc();
	}

	internal static IntPtr ewdc0TflGmZ9GckFGTk(object object_0)
	{
		return ((Font)object_0).ToHfont();
	}

	internal static void eoOktcfNBxvMMJcUq0E(object object_0, IntPtr intptr_0)
	{
		((Graphics)object_0).ReleaseHdc(intptr_0);
	}

	internal static void ejZjshfrM5gtDQONfFo(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
