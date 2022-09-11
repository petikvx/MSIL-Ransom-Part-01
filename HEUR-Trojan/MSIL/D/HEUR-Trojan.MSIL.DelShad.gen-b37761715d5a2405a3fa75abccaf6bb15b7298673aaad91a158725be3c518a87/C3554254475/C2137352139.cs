#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

public static class C2137352139
{
	internal static readonly byte[] C3554254475 = new byte[0];

	internal static readonly C856455061<char> C3554254475 = new C856455061<char>();

	private const MethodImplOptions m_C3554254475 = MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization;

	private static readonly uint[] m_C3554254475 = new uint[256]
	{
		3442453683u, 3884613468u, 1862796284u, 3170296368u, 976361234u, 104873393u, 3539487637u, 3743590116u, 130981467u, 829983244u,
		4135843572u, 3926269769u, 4200344266u, 1268664654u, 2964006330u, 1987523068u, 639144871u, 722072270u, 73556452u, 1094089547u,
		413659685u, 2408725518u, 1593025317u, 684737374u, 2227317017u, 3982919484u, 2364400708u, 2143583268u, 4244401059u, 1735365261u,
		3021238663u, 3640332910u, 2105117975u, 4286768164u, 387119707u, 2880478677u, 2169944675u, 2229590377u, 3375889306u, 790518780u,
		395233809u, 242339167u, 1386923764u, 1911487631u, 1888540489u, 566938161u, 2459526008u, 154773672u, 3924695348u, 3530655254u,
		4065330499u, 3104933692u, 3553312492u, 731962347u, 3022850599u, 3974528015u, 808003056u, 1628764217u, 3550372615u, 3800658134u,
		3952619417u, 2484817119u, 3309364560u, 2166684741u, 2561680839u, 3804205290u, 1331153270u, 3478417380u, 1498836424u, 3824432653u,
		4126790193u, 3591899938u, 3041790090u, 3051349670u, 909615983u, 91132548u, 2952330181u, 434116168u, 2249322563u, 3672392503u,
		4128991772u, 628805022u, 3711300871u, 4010134266u, 99306115u, 4230335122u, 172435686u, 2633060591u, 2934925278u, 2840011575u,
		1472732926u, 1046347935u, 46859195u, 732452468u, 4062036561u, 2026064436u, 2880566719u, 3109695421u, 531920759u, 2593581228u,
		1563240504u, 1437255978u, 2582524494u, 284565835u, 1487658929u, 537426253u, 3200811248u, 3881718593u, 2281790516u, 892178367u,
		1647017836u, 4123369122u, 527801742u, 2917491033u, 3430632485u, 1535886476u, 3065845167u, 1012617488u, 3880418365u, 3999347041u,
		359275623u, 1925212183u, 3926552425u, 1290598803u, 3399308620u, 2384475679u, 1121162937u, 1499325816u, 1956477269u, 4246447613u,
		2180781582u, 3684164236u, 2096187639u, 185285877u, 1397614085u, 1178734694u, 3568733649u, 2655493350u, 2925951645u, 3154649218u,
		2959988463u, 552661567u, 3114145105u, 4101647930u, 1910132934u, 1740003193u, 713864054u, 514268910u, 699125072u, 3068857451u,
		599852305u, 1866408260u, 1794256914u, 4137074078u, 3108018648u, 2908396673u, 2047317242u, 2128566742u, 510846324u, 2237763900u,
		1313691279u, 4006320424u, 2618445102u, 138983468u, 4056562015u, 2645509084u, 4152279843u, 961452889u, 2116028742u, 2340494696u,
		383398661u, 2878202563u, 3871685476u, 2562904865u, 2292809089u, 2802869273u, 2387802047u, 2396152495u, 2093651790u, 4036178497u,
		68015159u, 3779310548u, 807007599u, 3074511389u, 4050932578u, 1279483807u, 3022081293u, 185349259u, 1347539337u, 1278231678u,
		1939068706u, 2513362187u, 3717811840u, 3285331673u, 1939659008u, 320780740u, 4010828466u, 1326310454u, 1385300083u, 2592030080u,
		2305719067u, 747355738u, 3174059914u, 2845041196u, 323764640u, 4204305920u, 969840422u, 4220124367u, 3908807831u, 3557179388u,
		2472160090u, 1154018947u, 3408644022u, 43556498u, 1967623146u, 339966160u, 3629367431u, 2291639118u, 3710083741u, 3185746594u,
		1478332108u, 1571335912u, 4287279056u, 3123433326u, 1272548780u, 4075665892u, 4197304424u, 1206404705u, 3974831229u, 1097882788u,
		1501750484u, 3948020897u, 3516320507u, 1679065165u, 985484102u, 2336836646u, 3023230251u, 969225579u, 1858604023u, 1908298883u,
		3468993801u, 3913358689u, 1391673829u, 3538295163u, 1325564524u, 2850326584u, 3522753095u, 3835002803u, 1483524761u, 2592827995u,
		1234762730u, 4150443596u, 2430591804u, 2536591646u, 2294720559u, 3714426068u
	};

	public static byte[] C3554254475(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2013832146());
		}
		int length = string_0.Length;
		if (((uint)length & (true ? 1u : 0u)) != 0)
		{
			Debug.Assert(condition: false);
			return null;
		}
		byte[] array = new byte[length / 2];
		for (int i = 0; i < length; i += 2)
		{
			char c = string_0[i];
			byte b;
			if (c >= '0' && c <= '9')
			{
				b = (byte)(c - 48);
			}
			else if (c >= 'a' && c <= 'f')
			{
				b = (byte)(c - 97 + 10);
			}
			else if (c >= 'A' && c <= 'F')
			{
				b = (byte)(c - 65 + 10);
			}
			else
			{
				Debug.Assert(condition: false);
				b = 0;
			}
			b = (byte)(b << 4);
			c = string_0[i + 1];
			if (c >= '0' && c <= '9')
			{
				b = (byte)(b + (byte)(c - 48));
			}
			else if (c >= 'a' && c <= 'f')
			{
				b = (byte)(b + (byte)(c - 97 + 10));
			}
			else if (c >= 'A' && c <= 'F')
			{
				b = (byte)(b + (byte)(c - 65 + 10));
			}
			else
			{
				Debug.Assert(condition: false);
			}
			array[i >> 1] = b;
		}
		return array;
	}

	public static string C3554254475(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		int num = byte_0.Length;
		if (num == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < num; i++)
		{
			byte b = byte_0[i];
			byte b2 = b;
			b2 = (byte)(b2 >> 4);
			byte b3 = (byte)(b & 0xFu);
			if (b2 >= 10)
			{
				stringBuilder.Append((char)(65 + b2 - 10));
			}
			else
			{
				stringBuilder.Append((char)(48 + b2));
			}
			if (b3 >= 10)
			{
				stringBuilder.Append((char)(65 + b3 - 10));
			}
			else
			{
				stringBuilder.Append((char)(48 + b3));
			}
		}
		return stringBuilder.ToString();
	}

	public static byte[] C3904355907(string string_0)
	{
		if (string_0 == null || string_0.Length % 8 != 0)
		{
			Debug.Assert(condition: false);
			return null;
		}
		ulong num = (ulong)(string_0.Length * 5L);
		List<byte> list = new List<byte>((int)(num / 8uL) + 1);
		Debug.Assert(list.Count == 0);
		for (int i = 0; i < string_0.Length; i += 8)
		{
			ulong num2 = 0uL;
			int num3 = 0;
			for (int j = 0; j < 8; j++)
			{
				char c = string_0[i + j];
				if (c == '=')
				{
					break;
				}
				ulong num4;
				if (c >= 'A' && c <= 'Z')
				{
					num4 = (ulong)(c - 65);
				}
				else if (c >= 'a' && c <= 'z')
				{
					num4 = (ulong)(c - 97);
				}
				else
				{
					if (c < '2' || c > '7')
					{
						Debug.Assert(condition: false);
						return null;
					}
					num4 = (ulong)(c - 50 + 26L);
				}
				num2 <<= 5;
				num2 += num4;
				num3 += 5;
			}
			int num5 = num3 % 8;
			num2 >>= num5;
			num3 -= num5;
			Debug.Assert(num3 % 8 == 0);
			int count = list.Count;
			while (num3 > 0)
			{
				list.Add((byte)(num2 & 0xFFuL));
				num2 >>= 8;
				num3 -= 8;
			}
			list.Reverse(count, list.Count - count);
		}
		return list.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void C3904355907(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
		}
		else
		{
			Array.Clear(byte_0, 0, byte_0.Length);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void C3554254475<C3554254475>(C3554254475[] gparam_0)
	{
		if (gparam_0 == null)
		{
			Debug.Assert(condition: false);
		}
		else
		{
			Array.Clear(gparam_0, 0, gparam_0.Length);
		}
	}

	public static ushort C1255198513(byte[] byte_0)
	{
		Debug.Assert(byte_0 != null && byte_0.Length == 2);
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		if (byte_0.Length != 2)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		return (ushort)(byte_0[0] | (byte_0[1] << 8));
	}

	public static ushort C3554254475(byte[] byte_0, int int_0)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		if (int_0 < 0 || int_0 + 1 >= byte_0.Length)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C252678980());
		}
		return (ushort)(byte_0[int_0] | (byte_0[int_0 + 1] << 8));
	}

	public static uint C1908338681(byte[] byte_0)
	{
		Debug.Assert(byte_0 != null && byte_0.Length == 4);
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		if (byte_0.Length != 4)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		return (uint)(byte_0[0] | (byte_0[1] << 8) | (byte_0[2] << 16) | (byte_0[3] << 24));
	}

	public static uint C3904355907(byte[] byte_0, int int_0)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		if (int_0 < 0 || int_0 + 3 >= byte_0.Length)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C252678980());
		}
		return (uint)(byte_0[int_0] | (byte_0[int_0 + 1] << 8) | (byte_0[int_0 + 2] << 16) | (byte_0[int_0 + 3] << 24));
	}

	public static ulong C1037565863(byte[] byte_0)
	{
		Debug.Assert(byte_0 != null && byte_0.Length == 8);
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		if (byte_0.Length != 8)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		return byte_0[0] | ((ulong)byte_0[1] << 8) | ((ulong)byte_0[2] << 16) | ((ulong)byte_0[3] << 24) | ((ulong)byte_0[4] << 32) | ((ulong)byte_0[5] << 40) | ((ulong)byte_0[6] << 48) | ((ulong)byte_0[7] << 56);
	}

	public static ulong C1255198513(byte[] byte_0, int int_0)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		if (int_0 < 0 || int_0 + 7 >= byte_0.Length)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C252678980());
		}
		return byte_0[int_0] | ((ulong)byte_0[int_0 + 1] << 8) | ((ulong)byte_0[int_0 + 2] << 16) | ((ulong)byte_0[int_0 + 3] << 24) | ((ulong)byte_0[int_0 + 4] << 32) | ((ulong)byte_0[int_0 + 5] << 40) | ((ulong)byte_0[int_0 + 6] << 48) | ((ulong)byte_0[int_0 + 7] << 56);
	}

	public static int C112844655(byte[] byte_0)
	{
		return (int)C1908338681(byte_0);
	}

	public static int C1908338681(byte[] byte_0, int int_0)
	{
		return (int)C3904355907(byte_0, int_0);
	}

	public static long C2746444292(byte[] byte_0)
	{
		return (long)C1037565863(byte_0);
	}

	public static long C1037565863(byte[] byte_0, int int_0)
	{
		return (long)C1255198513(byte_0, int_0);
	}

	public static byte[] C3554254475(ushort ushort_0)
	{
		return new byte[2]
		{
			(byte)ushort_0,
			(byte)(ushort_0 >> 8)
		};
	}

	public static byte[] C3554254475(uint uint_0)
	{
		return new byte[4]
		{
			(byte)uint_0,
			(byte)(uint_0 >> 8),
			(byte)(uint_0 >> 16),
			(byte)(uint_0 >> 24)
		};
	}

	public static void C3554254475(uint uint_0, byte[] byte_0, int int_0)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		if (int_0 < 0 || int_0 + 3 >= byte_0.Length)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C252678980());
		}
		byte_0[int_0] = (byte)uint_0;
		byte_0[int_0 + 1] = (byte)(uint_0 >> 8);
		byte_0[int_0 + 2] = (byte)(uint_0 >> 16);
		byte_0[int_0 + 3] = (byte)(uint_0 >> 24);
	}

	public static byte[] C3554254475(ulong ulong_0)
	{
		return new byte[8]
		{
			(byte)ulong_0,
			(byte)(ulong_0 >> 8),
			(byte)(ulong_0 >> 16),
			(byte)(ulong_0 >> 24),
			(byte)(ulong_0 >> 32),
			(byte)(ulong_0 >> 40),
			(byte)(ulong_0 >> 48),
			(byte)(ulong_0 >> 56)
		};
	}

	public static void C3554254475(ulong ulong_0, byte[] byte_0, int int_0)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		if (int_0 < 0 || int_0 + 7 >= byte_0.Length)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C252678980());
		}
		byte_0[int_0] = (byte)ulong_0;
		byte_0[int_0 + 1] = (byte)(ulong_0 >> 8);
		byte_0[int_0 + 2] = (byte)(ulong_0 >> 16);
		byte_0[int_0 + 3] = (byte)(ulong_0 >> 24);
		byte_0[int_0 + 4] = (byte)(ulong_0 >> 32);
		byte_0[int_0 + 5] = (byte)(ulong_0 >> 40);
		byte_0[int_0 + 6] = (byte)(ulong_0 >> 48);
		byte_0[int_0 + 7] = (byte)(ulong_0 >> 56);
	}

	public static byte[] C3554254475(int int_0)
	{
		return C3554254475((uint)int_0);
	}

	public static void C3554254475(int int_0, byte[] byte_0, int int_1)
	{
		C3554254475((uint)int_0, byte_0, int_1);
	}

	public static byte[] C3554254475(long long_0)
	{
		return C3554254475((ulong)long_0);
	}

	public static void C3554254475(long long_0, byte[] byte_0, int int_0)
	{
		C3554254475((ulong)long_0, byte_0, int_0);
	}

	public static uint C3554254475(uint uint_0, int int_0)
	{
		return (uint_0 << int_0) | (uint_0 >> 32 - int_0);
	}

	public static uint C3904355907(uint uint_0, int int_0)
	{
		return (uint_0 >> int_0) | (uint_0 << 32 - int_0);
	}

	public static ulong C3554254475(ulong ulong_0, int int_0)
	{
		return (ulong_0 << int_0) | (ulong_0 >> 64 - int_0);
	}

	public static ulong C3904355907(ulong ulong_0, int int_0)
	{
		return (ulong_0 >> int_0) | (ulong_0 << 64 - int_0);
	}

	public static bool C3554254475(byte[] byte_0, byte[] byte_1)
	{
		if (byte_0 == null || byte_1 == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		if (byte_0.Length != byte_1.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < byte_0.Length)
			{
				if (byte_0[num] != byte_1[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static void C3554254475(byte[] byte_0, int int_0, byte[] byte_1, int int_1, int int_2)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3110715001());
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2181537457());
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3463352047());
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C4110462503());
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1466425173());
		}
		if (int_0 > byte_0.Length - int_2)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1466425173());
		}
		if (int_1 > byte_1.Length - int_2)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1466425173());
		}
		for (int i = 0; i < int_2; i++)
		{
			byte_1[int_1 + i] ^= byte_0[int_0 + i];
		}
	}

	public static uint C3554254475(byte[] byte_0, int int_0, int int_1)
	{
		uint num = 846160763u;
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			return num;
		}
		if (int_0 < 0)
		{
			Debug.Assert(condition: false);
			return num;
		}
		if (int_1 < 0)
		{
			Debug.Assert(condition: false);
			return num;
		}
		int num2 = int_0 + int_1;
		if (num2 > byte_0.Length)
		{
			Debug.Assert(condition: false);
			return num;
		}
		for (int i = int_0; i < num2; i++)
		{
			num ^= C2137352139.m_C3554254475[byte_0[i]];
			num *= 3;
		}
		return num;
	}

	public static void C3554254475(Stream stream_0, Stream stream_1)
	{
		Debug.Assert(stream_0 != null && stream_1 != null);
		if (stream_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1812594589());
		}
		if (stream_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C543223747());
		}
		byte[] buffer = new byte[4096];
		while (true)
		{
			int num = stream_0.Read(buffer, 0, 4096);
			if (num != 0)
			{
				stream_1.Write(buffer, 0, num);
				continue;
			}
			break;
		}
	}

	public static byte[] C3554254475(Stream stream_0, int int_0)
	{
		if (stream_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C453955339());
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3187964512());
		}
		byte[] array = new byte[int_0];
		int num = 0;
		while (int_0 > 0)
		{
			int num2 = stream_0.Read(array, num, int_0);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			int_0 -= num2;
		}
		if (num != array.Length)
		{
			byte[] array2 = new byte[num];
			Array.Copy(array, array2, num);
			return array2;
		}
		return array;
	}

	public static void C3554254475(Stream stream_0, byte[] byte_0)
	{
		if (stream_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		Debug.Assert(byte_0.Length >= 0);
		if (byte_0.Length != 0)
		{
			stream_0.Write(byte_0, 0, byte_0.Length);
		}
	}

	public static byte[] C2564639436(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2238339752());
		}
		if (byte_0.Length == 0)
		{
			return byte_0;
		}
		byte[] result;
		using (MemoryStream stream_ = new MemoryStream(byte_0, writable: false))
		{
			using MemoryStream memoryStream = new MemoryStream();
			using (GZipStream stream_2 = new GZipStream(memoryStream, CompressionMode.Compress))
			{
				C3554254475(stream_, stream_2);
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public static byte[] C3568589458(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3372436214());
		}
		if (byte_0.Length == 0)
		{
			return byte_0;
		}
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (MemoryStream stream = new MemoryStream(byte_0, writable: false))
			{
				using GZipStream stream_ = new GZipStream(stream, CompressionMode.Decompress);
				C3554254475(stream_, memoryStream);
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public static int C3904355907<C3554254475>(C3554254475[] gparam_0, C3554254475[] gparam_1) where C3554254475 : IEquatable<C3554254475>
	{
		if (gparam_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C4067256894());
		}
		if (gparam_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1342839628());
		}
		if (gparam_1.Length == 0)
		{
			return 0;
		}
		int num = 0;
		while (true)
		{
			if (num <= gparam_0.Length - gparam_1.Length)
			{
				bool flag = true;
				for (int i = 0; i < gparam_1.Length; i++)
				{
					if (!gparam_0[num + i].Equals(gparam_1[i]))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public static C3554254475[] C3554254475<C3554254475>(C3554254475[] gparam_0, int int_0, int int_1)
	{
		if (gparam_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1801730948());
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C252678980());
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C655174618());
		}
		if (int_0 + int_1 > gparam_0.Length)
		{
			throw new ArgumentException();
		}
		C3554254475[] array = new C3554254475[int_1];
		Array.Copy(gparam_0, int_0, array, 0, int_1);
		return array;
	}

	[IteratorStateMachine(typeof(C1255198513<>))]
	public static IEnumerable<C3554254475> C3554254475<C3554254475>(IEnumerable<C3554254475> ienumerable_0, IEnumerable<C3554254475> ienumerable_1, IEqualityComparer<C3554254475> iequalityComparer_0)
	{
		//yield-return decompiler failed: Method not found
		return new C1255198513<C3554254475>(-2)
		{
			C3904355907 = ienumerable_0,
			C1908338681 = ienumerable_1,
			C3904355907 = iequalityComparer_0
		};
	}

	[IteratorStateMachine(typeof(C3904355907<>))]
	public static IEnumerable<C3554254475> C3904355907<C3554254475>(IEnumerable<C3554254475> ienumerable_0, IEnumerable<C3554254475> ienumerable_1, IEqualityComparer<C3554254475> iequalityComparer_0)
	{
		//yield-return decompiler failed: Method not found
		return new C3904355907<C3554254475>(-2)
		{
			C3904355907 = ienumerable_0,
			C1908338681 = ienumerable_1,
			C3904355907 = iequalityComparer_0
		};
	}

	[IteratorStateMachine(typeof(C3554254475<>))]
	public static IEnumerable<C3554254475> C1255198513<C3554254475>(IEnumerable<C3554254475> ienumerable_0, IEnumerable<C3554254475> ienumerable_1, IEqualityComparer<C3554254475> iequalityComparer_0)
	{
		//yield-return decompiler failed: Method not found
		return new C3554254475<C3554254475>(-2)
		{
			C3904355907 = ienumerable_0,
			C1908338681 = ienumerable_1,
			C3904355907 = iequalityComparer_0
		};
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void C3554254475(object object_0)
	{
		if (object_0 == null)
		{
			Debug.Assert(condition: false);
		}
		else if (object_0 is IDisposable disposable)
		{
			disposable.Dispose();
		}
	}
}
