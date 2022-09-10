using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EkIJjm7vjs8xMISmTn;
using NCDRxx4R49CZy0gNBsi;
using ivPFWBLjP3D0KTGBB8g;

namespace ITiiE34eRSm4XTiAdM0;

internal sealed class EyY6ZF4u1pw8LWWYsyc
{
	private struct ID6nGB4XFN4cAsBn7oY
	{
		public int K4vHb6J73e;

		public int JBGH4S0XuW;

		public int aNhHnTat9d;

		public int e99HEwrMSt;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ID6nGB4XFN4cAsBn7oY(Rectangle _0020)
		{
			//Discarded unreachable code: IL_004a
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
				case 3:
					QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
					num2 = 5;
					break;
				case 5:
					K4vHb6J73e = _0020.Left;
					num2 = 2;
					break;
				case 2:
					JBGH4S0XuW = _0020.Top;
					goto case 1;
				default:
					num2 = 1;
					break;
				case 1:
					e99HEwrMSt = _0020.Bottom;
					num2 = 6;
					break;
				case 4:
				case 6:
					aNhHnTat9d = _0020.Right;
					num2 = 7;
					break;
				case 7:
					return;
				}
				num = num2;
			}
		}

		internal static bool V0IHGgLsR4OddMRmj99()
		{
			return true;
		}

		internal static bool d7bMr7LgNn8Fd1mGeQQ()
		{
			return false;
		}
	}

	private struct EWfvxE4yR5H7u7hdMt4
	{
		public int fcCHWsMKfn;

		public uint wduH0AwYJi;

		public uint lxPHmLHcrA;

		public uint rpDHrhoNKu;

		public uint l7pHBOgcaB;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string jf4HJ2LRRU;

		public ushort xmfHFirRhR;

		public ushort Iq9HlEpwLe;

		public ushort MaNHjKO0jI;

		public byte X2oHVyED9m;

		private byte sZIH7yhrJh;
	}

	public struct RQWxhN4qcviNpmpWZhh
	{
		public ushort SFOH1nkVhI;

		private ushort OHoHeQmdve;

		public uint OGeHLXU55i;

		public IntPtr RXCHMexLTu;

		public IntPtr UBFHCNFYT5;

		public IntPtr noEH9yD1Bg;

		public uint rZoH6RnhQ4;

		public uint r6tHck4V20;

		public uint c1cHquUuhq;

		public ushort T1aHfJyGsU;

		public ushort iogHKA72yS;
	}

	private static bool CCRHSK5XXL;

	private static EWfvxE4yR5H7u7hdMt4 GxMHpUf5HI;

	[DllImport("shell32", EntryPoint = "ExtractIconEx")]
	private static extern int gGpHOPjFV1(string _0020, int _0020, ref int _0020, ref int _0020, int _0020);

	[DllImport("user32", CharSet = CharSet.Unicode, EntryPoint = "DrawText")]
	private static extern int RJHH8ew7Yh(IntPtr _0020, string _0020, int _0020, ref ID6nGB4XFN4cAsBn7oY _0020, int _0020);

	[DllImport("gdi32.dll", EntryPoint = "SelectObject")]
	private static extern IntPtr n5FHoGlUBD(IntPtr _0020, IntPtr _0020);

	[DllImport("kernel32.Dll", EntryPoint = "GetVersionEx")]
	private static extern short yXWHPC3txk(ref EWfvxE4yR5H7u7hdMt4 _0020);

	[DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
	private static extern int y5DH30G1VY(int _0020);

	[DllImport("kernel32.Dll", EntryPoint = "GetSystemInfo")]
	private static extern void qTFHZ1ROgy(ref RQWxhN4qcviNpmpWZhh _0020);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private static EWfvxE4yR5H7u7hdMt4 _0001()
	{
		//Discarded unreachable code: IL_0034, IL_00a1
		int num = 3;
		if (false)
		{
			goto IL_000c;
		}
		goto IL_0041;
		IL_0041:
		switch (num)
		{
		case 0:
		case 3:
			break;
		case 1:
		case 2:
			GxMHpUf5HI = default(EWfvxE4yR5H7u7hdMt4);
			goto case 4;
		default:
			goto IL_005a;
		case 4:
			try
			{
				GxMHpUf5HI.fcCHWsMKfn = Marshal.SizeOf(typeof(EWfvxE4yR5H7u7hdMt4));
				int num2 = 2;
				if (!P9SbdcLwwFpGsojkTnW())
				{
					while (true)
					{
						switch (num2)
						{
						case 0:
						case 2:
							break;
						default:
						{
							int num3 = 3;
							num2 = num3;
							continue;
						}
						case 1:
						case 3:
							goto IL_00d1;
						}
						break;
					}
				}
				yXWHPC3txk(ref GxMHpUf5HI);
				goto IL_00d1;
				IL_00d1:
				CCRHSK5XXL = true;
			}
			catch
			{
			}
			goto IL_00e2;
		}
		goto IL_000c;
		IL_005a:
		int num4 = 4;
		goto IL_003d;
		IL_00e2:
		return GxMHpUf5HI;
		IL_003d:
		num = num4;
		goto IL_0041;
		IL_000c:
		if (!CCRHSK5XXL)
		{
			num4 = 2;
			goto IL_003d;
		}
		goto IL_00e2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal static bool _0001()
	{
		try
		{
			RQWxhN4qcviNpmpWZhh rQWxhN4qcviNpmpWZhh = default(RQWxhN4qcviNpmpWZhh);
			qTFHZ1ROgy(ref rQWxhN4qcviNpmpWZhh);
			return rQWxhN4qcviNpmpWZhh.SFOH1nkVhI == 9;
		}
		catch
		{
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal static bool _0002()
	{
		try
		{
			return y5DH30G1VY(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal static bool _0003()
	{
		return EyY6ZF4u1pw8LWWYsyc._0001().X2oHVyED9m == 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal static string _0001()
	{
		return EyY6ZF4u1pw8LWWYsyc._0001().jf4HJ2LRRU;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Icon pkgHUqSomn()
	{
		try
		{
			return e6iHx7EHS0();
		}
		catch (Exception)
		{
			return uDc1MtLJPKip5Eik5Ld.n9SkXRBSSD(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48908));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Icon e6iHx7EHS0()
	{
		//Discarded unreachable code: IL_0068
		int num = 3;
		int num4 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					num4 = 0;
					num2 = 7;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					gGpHOPjFV1(Application.get_ExecutablePath(), 0, ref num4, ref num3, 1);
					num = 4;
					break;
				case 2:
					num5 = gGpHOPjFV1(Application.get_ExecutablePath(), -1, ref num3, ref num3, 1);
					num2 = 6;
					if (!P9SbdcLwwFpGsojkTnW())
					{
						continue;
					}
					goto case 6;
				case 6:
					if (num5 > 0)
					{
						goto case 5;
					}
					goto IL_00da;
				default:
					num = 5;
					break;
				case 4:
					if (num4 != 0)
					{
						num = 8;
						break;
					}
					goto IL_00da;
				case 1:
				case 7:
					num3 = 0;
					num2 = 2;
					if (true)
					{
						continue;
					}
					goto case 8;
				case 8:
					{
						return Icon.FromHandle(new IntPtr(num4));
					}
					IL_00da:
					return null;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Fe1Hsbruq3(object _0020, object _0020, object _0020, int _0020)
	{
		try
		{
			return qTqH5LbuhZ(_0020, _0020, _0020, _0020);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)jPGHv9Mh6r(_0020, _0020, _0020, _0020) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int jPGHv9Mh6r(object _0020, object _0020, object _0020, int _0020)
	{
		return Size.Ceiling(((Graphics)_0020).MeasureString((string)_0020, (Font)_0020, _0020)).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int qTqH5LbuhZ(object _0020, object _0020, object _0020, int _0020)
	{
		//Discarded unreachable code: IL_00c1
		int num = 2;
		if (false)
		{
			goto IL_000c;
		}
		goto IL_00ce;
		IL_00ce:
		IntPtr hdc = default(IntPtr);
		ID6nGB4XFN4cAsBn7oY iD6nGB4XFN4cAsBn7oY = default(ID6nGB4XFN4cAsBn7oY);
		int num3 = default(int);
		IntPtr intPtr = default(IntPtr);
		int num2;
		IntPtr intPtr2 = default(IntPtr);
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 2:
				goto IL_0021;
			case 3:
				RJHH8ew7Yh(hdc, (string)_0020, -1, ref iD6nGB4XFN4cAsBn7oY, num3);
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				num3 = 3088;
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				intPtr = ((Font)_0020).ToHfont();
				num2 = 8;
				goto IL_00ca;
			case 4:
				n5FHoGlUBD(hdc, intPtr2);
				num2 = 9;
				goto IL_00ca;
			case 7:
			case 9:
				((Graphics)_0020).ReleaseHdc(hdc);
				num2 = 10;
				goto IL_00ca;
			case 8:
				intPtr2 = n5FHoGlUBD(hdc, intPtr);
				goto case 3;
			default:
				num2 = 3;
				goto IL_00ca;
			case 10:
				return iD6nGB4XFN4cAsBn7oY.e99HEwrMSt - iD6nGB4XFN4cAsBn7oY.JBGH4S0XuW;
			}
			break;
			IL_0021:
			iD6nGB4XFN4cAsBn7oY = new ID6nGB4XFN4cAsBn7oY(new Rectangle(0, 0, _0020, 10000));
			num2 = 5;
			goto IL_00ca;
		}
		goto IL_000c;
		IL_000c:
		hdc = ((Graphics)_0020).GetHdc();
		num2 = 0;
		goto IL_00ca;
		IL_00ca:
		num = num2;
		goto IL_00ce;
	}

	internal static bool mOoDBLgzP3JTJ75uQYM()
	{
		return true;
	}

	internal static bool P9SbdcLwwFpGsojkTnW()
	{
		return false;
	}
}
