using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;

namespace LqHyLjKQHwjIbZdxED;

internal class RCNOXXe2fBO2yniWl1
{
	private enum Gsbrdby5vmqHA6qUXZ
	{

	}

	internal class AtXNkazdFeCU5gb9KV
	{
		private unsafe static uint is02gf1Pn9(void* pVoid_0, uint uint_0)
		{
			uint result = 0u;
			if (BitConverter.IsLittleEndian)
			{
				result = *(uint*)pVoid_0;
			}
			else
			{
				switch (uint_0)
				{
				case 1u:
					result = *(byte*)pVoid_0;
					break;
				case 2u:
					result = (uint)(*(byte*)pVoid_0 | (((byte*)pVoid_0)[1] << 8));
					break;
				case 3u:
					result = (uint)(*(byte*)pVoid_0 | (((byte*)pVoid_0)[1] << 8) | (((byte*)pVoid_0)[2] << 16));
					break;
				case 4u:
					result = (uint)(*(byte*)pVoid_0 | (((byte*)pVoid_0)[1] << 8) | (((byte*)pVoid_0)[2] << 16) | (((byte*)pVoid_0)[3] << 24));
					break;
				}
			}
			return result;
		}

		private unsafe static bool DTO2EKReC5(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			bool flag = true;
			uint num = 0u;
			while (flag && num < uint_0)
			{
				flag = ((byte*)pVoid_0)[(int)num] == ((byte*)pVoid_1)[(int)num];
				num++;
			}
			return flag;
		}

		private unsafe static void HRf2V9ZBXW(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = byte_0;
			}
		}

		private unsafe static void qfK2IkgT2h(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = ((byte*)pVoid_1)[(int)num];
			}
		}

		private unsafe static void V432C69WBt(byte* pByte_0, byte* pByte_1, uint uint_0)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (uint_0 < 5)
				{
					*(int*)pByte_0 = *(int*)pByte_1;
					return;
				}
				byte* ptr = pByte_0 + (int)uint_0;
				while (pByte_0 < ptr)
				{
					*(int*)pByte_0 = *(int*)pByte_1;
					pByte_0 += 4;
					pByte_1 += 4;
				}
			}
			else if (uint_0 > 8 && pByte_1 + (int)uint_0 < pByte_0)
			{
				qfK2IkgT2h(pByte_0, pByte_1, uint_0);
			}
			else
			{
				byte* ptr2 = pByte_0 + (int)uint_0;
				while (pByte_0 < ptr2)
				{
					*pByte_0 = *pByte_1;
					pByte_0++;
					pByte_1++;
				}
			}
		}

		private unsafe static uint SvE2OYOXaX(byte[] byte_0, uint uint_0, Gsbrdby5vmqHA6qUXZ gsbrdby5vmqHA6qUXZ_0)
		{
			uint num = 0u;
			fixed (byte* ptr = byte_0)
			{
				num = *(uint*)(ptr + (int)uint_0 + (nint)gsbrdby5vmqHA6qUXZ_0 * (nint)4);
			}
			return num;
		}

		public static uint gdq2bZS7Hg(byte[] byte_0, uint uint_0)
		{
			return SvE2OYOXaX(byte_0, uint_0, (Gsbrdby5vmqHA6qUXZ)3);
		}

		private unsafe static uint qei28UU68n(byte[] byte_0, uint uint_0, byte[] byte_1)
		{
			fixed (byte* ptr = byte_0)
			{
				fixed (byte* ptr4 = byte_1)
				{
					byte* ptr2 = ptr + (int)uint_0;
					uint num = 32u;
					byte* ptr3 = ptr2 + 32;
					byte* ptr5 = ptr4;
					uint* ptr6 = (uint*)ptr2;
					byte* ptr7 = ptr4 + (int)is02gf1Pn9(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (is02gf1Pn9(ptr6 + 4, 4u) != 1)
					{
						qfK2IkgT2h(ptr4, ptr2 + (int)num, is02gf1Pn9(ptr6 + 3, 4u));
						return is02gf1Pn9(ptr6 + 3, 4u);
					}
					if (ptr5 >= ptr8)
					{
						ptr3 += 4;
						while (ptr5 < ptr7)
						{
							*ptr5 = *ptr3;
							ptr5++;
							ptr3++;
						}
						return (uint)(ptr5 - ptr4);
					}
					while (true)
					{
						if (num2 == 1)
						{
							num2 = is02gf1Pn9(ptr3, 4u);
							ptr3 += 4;
						}
						uint num3 = is02gf1Pn9(ptr3, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								V432C69WBt(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								V432C69WBt(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								V432C69WBt(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								V432C69WBt(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								V432C69WBt(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 4;
							}
							else
							{
								byte byte_2 = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFFu;
								HRf2V9ZBXW(ptr5, byte_2, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
						}
						else
						{
							V432C69WBt(ptr5, ptr3, 4u);
							ptr5 += (int)array[num2 & 0xF];
							ptr3 += (int)array[num2 & 0xF];
							num2 >>= (int)(byte)array[num2 & 0xF];
							if (ptr5 >= ptr8)
							{
								break;
							}
						}
					}
					while (ptr5 < ptr7)
					{
						if (num2 == 1)
						{
							ptr3 += 4;
							num2 = 2147483648u;
						}
						*ptr5 = *ptr3;
						ptr5++;
						ptr3++;
						num2 >>= 1;
					}
					return (uint)(ptr5 - ptr4);
				}
			}
		}

		internal static object kd92WyLNBc(byte[] byte_0)
		{
			return FMQLAyYMr44Ynpb9npI(sJAy87YjqwZsNf4IyKI(typeof(Assembly).TypeHandle).GetMethod("Load", new Type[1] { typeof(byte[]) }), null, new object[1] { byte_0 });
		}

		public static byte[] u7B2XhsBQw(byte[] byte_0, uint uint_0)
		{
			uint num = gdq2bZS7Hg(byte_0, uint_0);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				rvhKPgYvG394x6PDjBs(byte_0, uint_0, array);
			}
			return array;
		}

		internal static Type sJAy87YjqwZsNf4IyKI(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object FMQLAyYMr44Ynpb9npI(object object_0, object object_1, object object_2)
		{
			return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
		}

		internal static uint rvhKPgYvG394x6PDjBs(object object_0, uint uint_0, object object_1)
		{
			return qei28UU68n((byte[])object_0, uint_0, (byte[])object_1);
		}
	}

	private static string[] sdB26V5n3A = new string[0];

	private static object aT32kWtqYf = null;

	private static bool Bmo2jlCZwS = false;

	private static bool e7Q2xfunNv = false;

	private static void q0r2feGYcM()
	{
		int num = 116;
		int num13 = default(int);
		int num12 = default(int);
		uint num10 = default(uint);
		uint num11 = default(uint);
		uint num14 = default(uint);
		byte[] array3 = default(byte[]);
		byte[] array = default(byte[]);
		int num6 = default(int);
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num21 = default(int);
		uint num20 = default(uint);
		int num5 = default(int);
		int num9 = default(int);
		byte[] array5 = default(byte[]);
		int num24 = default(int);
		int num18 = default(int);
		byte[] array8 = default(byte[]);
		uint num25 = default(uint);
		int num26 = default(int);
		int num17 = default(int);
		uint num19 = default(uint);
		uint num22 = default(uint);
		uint num4 = default(uint);
		int num7 = default(int);
		int num23 = default(int);
		byte[] array7 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num8 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		MemoryStream memoryStream = default(MemoryStream);
		int num16 = default(int);
		while (!Bmo2jlCZwS)
		{
			while (true)
			{
				IL_270e:
				pHtTtXRCv6EXeda4Vr.mmmhROZdZfJrbe84gQ object_ = new pHtTtXRCv6EXeda4Vr.mmmhROZdZfJrbe84gQ((Stream)d4mUt4HLtdT1qAZB4w(bqLDgxRdJ1kHxAWxEk(typeof(pHtTtXRCv6EXeda4Vr).TypeHandle).Assembly, "1nRqBhMlDO1XSYsQbt.qjiG0d34BZBoKvmXP1"));
				int num2 = 29;
				if (hicg3KmqBm9qhwEtQs() != null)
				{
					goto IL_1f7f;
				}
				goto IL_2094;
				IL_2094:
				while (true)
				{
					switch (num2)
					{
					case 411:
						num13 = 0;
						num2 = 18;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 19;
					case 19:
					case 84:
						if (num13 >= num12)
						{
							goto case 86;
						}
						goto case 364;
					case 86:
					case 111:
						num10 = num11;
						num = 398;
						goto case 398;
					case 398:
						num11 = 255u;
						goto case 172;
					case 172:
					{
						uint num27 = num10;
						uint num28 = num10;
						num28 ^= num28 << 27;
						num28 += 3334175698u;
						num28 ^= num28 >> 3;
						num28 += 2331201564u;
						num28 ^= num28 << 4;
						num28 += 3827885711u;
						num28 = 1479020872 - num28;
						num10 = num27 + (uint)(double)num28;
						goto case 241;
					}
					case 241:
						num11 = num10;
						num2 = 155;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 364:
						if (num13 > 0)
						{
							num = 262;
							goto case 262;
						}
						goto case 311;
					case 262:
						num14 <<= 8;
						goto case 311;
					case 311:
						num14 |= array3[^(1 + num13)];
						num2 = 250;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 410:
						array[25] = 115;
						num = 145;
						goto case 145;
					case 145:
						num6 = 93;
						goto case 39;
					case 39:
						array[25] = (byte)num6;
						num2 = 7;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 409:
						num6 = 111;
						num2 = 73;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 408:
						num3 = 145;
						goto case 291;
					case 291:
						array2[1] = (byte)num3;
						num2 = 8;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 31;
					case 31:
						array2[1] = 109;
						num2 = 165;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 407:
						array2[3] = (byte)num3;
						goto case 344;
					case 344:
						num3 = 75;
						num2 = 325;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 199;
					case 199:
						num6 = 29;
						num2 = 185;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 406:
						array[22] = (byte)num6;
						num2 = 359;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 405:
						array[15] = 12;
						num2 = 114;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 404:
						array[6] = 79;
						goto case 177;
					case 177:
						num6 = 144;
						goto case 187;
					case 187:
						array[6] = (byte)num6;
						num = 57;
						goto case 57;
					case 57:
						array[6] = 110;
						goto case 323;
					case 323:
						num6 = 241;
						goto case 63;
					case 63:
						array[6] = (byte)num6;
						num2 = 261;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 403:
						num6 = 163;
						num2 = 119;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 402:
						array[17] = (byte)num6;
						goto case 357;
					case 357:
						num6 = 149;
						goto case 95;
					case 95:
						array[18] = (byte)num6;
						goto case 21;
					case 21:
						num6 = 25;
						goto case 215;
					case 215:
						array[18] = (byte)num6;
						goto case 141;
					case 141:
						array[18] = 225;
						num2 = 121;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 401:
						array4[num21 + 1] = (byte)((num20 & 0xFF00) >> 8);
						goto case 281;
					case 281:
						array4[num21 + 2] = (byte)((num20 & 0xFF0000) >> 16);
						goto case 42;
					case 42:
						array4[num21 + 3] = (byte)((num20 & 0xFF000000u) >> 24);
						goto case 52;
					case 52:
					case 61:
						num5++;
						num = 328;
						goto case 110;
					case 110:
					case 328:
						if (num5 >= num9)
						{
							goto case 197;
						}
						goto case 352;
					case 197:
						array5 = array4;
						num2 = 143;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 139;
					case 139:
						array[16] = (byte)num6;
						goto case 70;
					case 70:
						num6 = 57;
						num = 381;
						goto case 381;
					case 381:
						array[16] = (byte)num6;
						goto case 91;
					case 91:
						array[16] = 113;
						goto case 118;
					case 118:
						array[16] = 167;
						goto case 236;
					case 236:
						array[16] = 146;
						goto case 319;
					case 319:
						num6 = 116;
						num2 = 269;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 98;
					case 98:
						array2[9] = 115;
						goto case 326;
					case 326:
						array2[9] = 156;
						goto case 149;
					case 149:
						num3 = 122;
						goto case 144;
					case 144:
						array2[9] = (byte)num3;
						num2 = 104;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 352:
						num24 = num5 % num18;
						goto case 44;
					case 44:
						num21 = num5 * 4;
						num2 = 389;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 318:
					case 320:
					case 400:
						sdB26V5n3A = (string[])AaONtcQlitaKVLxooo((Assembly)aT32kWtqYf);
						num2 = 304;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 114;
					case 114:
						num6 = 19;
						goto case 50;
					case 50:
						array[16] = (byte)num6;
						goto case 289;
					case 289:
						num6 = 131;
						goto case 139;
					case 399:
						array2[2] = 55;
						num2 = 83;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 397:
						num3 = 147;
						goto case 89;
					case 89:
						array2[4] = (byte)num3;
						num2 = 56;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 396:
						num6 = 114;
						num2 = 312;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 395:
						num3 = 108;
						num2 = 168;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 394:
						array[30] = (byte)num6;
						num2 = 6;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 393:
						array2[15] = 68;
						num2 = 367;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 255;
					case 255:
						num9++;
						num2 = 264;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 391:
						array8 = array;
						break;
					case 51:
						break;
					case 336:
						goto IL_0583;
					case 238:
						goto IL_0589;
					case 221:
						goto IL_0597;
					case 280:
						goto IL_05a6;
					case 242:
						goto IL_05ac;
					case 69:
						goto IL_05ba;
					case 317:
						goto IL_05c6;
					case 388:
						goto IL_05cc;
					case 390:
						num25 <<= 8;
						goto case 376;
					case 376:
						num26 += 8;
						num = 380;
						goto case 380;
					case 380:
						array4[num21 + num17] = (byte)((num19 & num25) >> num26);
						num2 = 282;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 389:
						num22 = (uint)(num24 * 4);
						goto case 131;
					case 131:
						num4 = (uint)((array8[num22 + 3] << 24) | (array8[num22 + 2] << 16) | (array8[num22 + 1] << 8) | array8[num22]);
						goto case 226;
					case 226:
						num25 = 255u;
						goto case 225;
					case 225:
						num26 = 0;
						num2 = 252;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto case 244;
					case 244:
						array[3] = 120;
						goto case 216;
					case 216:
						array[3] = 158;
						goto case 76;
					case 76:
						array[4] = 53;
						goto case 24;
					case 24:
						array[4] = 98;
						num2 = 243;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 387:
						array2[12] = (byte)num3;
						goto case 223;
					case 223:
						num3 = 185;
						goto case 123;
					case 123:
						array2[12] = (byte)num3;
						num2 = 382;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 386:
						num3 = 228;
						num2 = 349;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 363;
					case 363:
						array2[8] = (byte)num3;
						goto case 99;
					case 99:
						num3 = 205;
						goto case 284;
					case 284:
						array2[8] = (byte)num3;
						goto case 296;
					case 296:
						num3 = 14;
						goto case 354;
					case 354:
						array2[8] = (byte)num3;
						num2 = 98;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 385:
						array[27] = (byte)num6;
						goto case 270;
					case 270:
						num6 = 98;
						num = 47;
						goto case 47;
					case 47:
						array[27] = (byte)num6;
						goto case 227;
					case 227:
						num6 = 106;
						goto case 360;
					case 360:
						array[27] = (byte)num6;
						goto case 33;
					case 33:
						array[27] = 79;
						num2 = 371;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 384:
						num3 = 167;
						goto case 387;
					case 383:
						num3 = 128;
						num2 = 369;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 382:
						num3 = 24;
						goto case 37;
					case 37:
						array2[13] = (byte)num3;
						goto case 175;
					case 175:
						array2[13] = 123;
						goto case 43;
					case 43:
						array2[13] = 147;
						goto case 192;
					case 192:
						num3 = 57;
						goto case 290;
					case 290:
						array2[14] = (byte)num3;
						num2 = 169;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 333;
					case 333:
						num3 = 107;
						num2 = 283;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_05a6;
					case 379:
						num6 = 92;
						num = 179;
						goto case 179;
					case 179:
						array[2] = (byte)num6;
						goto case 176;
					case 176:
						array[2] = 3;
						num = 30;
						goto case 30;
					case 30:
						array[3] = 110;
						goto case 253;
					case 253:
						num6 = 119;
						num2 = 41;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 41;
					case 41:
						array[3] = (byte)num6;
						goto case 64;
					case 64:
						array[3] = 46;
						goto case 244;
					case 378:
						array[18] = 14;
						num = 254;
						goto case 254;
					case 254:
						array[18] = 173;
						num = 188;
						goto case 188;
					case 188:
						num6 = 114;
						goto case 65;
					case 65:
						array[19] = (byte)num6;
						goto case 66;
					case 66:
						array[19] = 84;
						goto case 206;
					case 206:
						array[19] = 108;
						goto case 117;
					case 117:
						array[19] = 167;
						goto case 16;
					case 16:
						num6 = 114;
						goto case 374;
					case 374:
						array[19] = (byte)num6;
						num2 = 120;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto end_IL_270e;
					case 377:
						num6 = 111;
						num2 = 286;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 375:
						array[21] = 144;
						goto case 2;
					case 2:
						num6 = 26;
						num2 = 339;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 373:
						array[23] = 137;
						goto case 97;
					case 97:
						array[23] = 55;
						goto case 26;
					case 26:
						num6 = 192;
						goto case 94;
					case 94:
						array[24] = (byte)num6;
						goto case 103;
					case 103:
						array[24] = 100;
						goto case 58;
					case 58:
						array[24] = 178;
						num = 209;
						goto case 209;
					case 209:
						array[24] = 139;
						num2 = 168;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 330;
					case 330:
						array[24] = 34;
						goto case 108;
					case 108:
						array[25] = 164;
						num2 = 403;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 264;
					case 264:
						num22 = 0u;
						num2 = 5;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 372:
						array2[15] = (byte)num3;
						num2 = 293;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 371:
						num6 = 168;
						num2 = 78;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 66;
					case 370:
						num6 = 151;
						num2 = 267;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 369:
						array2[5] = (byte)num3;
						num2 = 174;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto case 119;
					case 119:
						array[25] = (byte)num6;
						num2 = 410;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 368:
						num6 = 133;
						goto case 268;
					case 268:
						array[13] = (byte)num6;
						goto case 161;
					case 161:
						array[13] = 61;
						num2 = 361;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 367:
						array2[15] = 116;
						goto case 337;
					case 337:
						array2[15] = 207;
						num2 = 3;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 366:
						array2[2] = 89;
						num = 399;
						goto case 399;
					case 365:
						array[26] = 216;
						goto case 183;
					case 183:
						num6 = 121;
						goto case 385;
					case 362:
						num7 = 1;
						goto case 38;
					case 38:
						num23 = 0;
						goto case 217;
					case 322:
						array8[num23] = (byte)(array8[num23] ^ array7[num23]);
						goto case 191;
					case 191:
						num23++;
						goto case 217;
					case 217:
					case 332:
						if (num23 < array7.Length)
						{
							goto case 322;
						}
						num2 = 202;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto case 74;
					case 74:
						array[10] = 148;
						num = 93;
						goto case 93;
					case 93:
						num6 = 181;
						num2 = 120;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 306;
					case 306:
						array[10] = (byte)num6;
						goto case 303;
					case 303:
						num6 = 162;
						num2 = 133;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 361:
						num6 = 116;
						goto case 25;
					case 25:
						array[14] = (byte)num6;
						goto case 170;
					case 170:
						array[14] = 118;
						goto case 196;
					case 196:
						array[14] = 86;
						goto case 272;
					case 272:
						array[14] = 159;
						goto case 129;
					case 129:
						array[15] = 126;
						num2 = 150;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 76;
					case 359:
						array[22] = 241;
						num2 = 258;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 230;
					case 230:
						num6 = 207;
						goto case 347;
					case 347:
						array[22] = (byte)num6;
						num2 = 331;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 358:
						array[27] = (byte)num6;
						num = 46;
						goto case 46;
					case 46:
						array[28] = 153;
						num2 = 0;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 356:
						num6 = 162;
						goto case 152;
					case 152:
						array[30] = (byte)num6;
						goto case 210;
					case 210:
						array[30] = 133;
						num2 = 343;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 355:
						array[21] = (byte)num6;
						num2 = 341;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 217;
					case 353:
						if (num12 > 0)
						{
							goto case 35;
						}
						goto case 249;
					case 35:
						num14 = 0u;
						goto case 214;
					case 214:
						num11 += num4;
						num2 = 411;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 249:
						num22 = (uint)num21;
						goto case 288;
					case 288:
						num11 += num4;
						num2 = 217;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 287;
					case 287:
						num14 = (uint)((array3[num22 + 3] << 24) | (array3[num22 + 2] << 16) | (array3[num22 + 1] << 8) | array3[num22]);
						num2 = 86;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 351:
						num3 = 98;
						goto case 151;
					case 151:
						array2[7] = (byte)num3;
						num2 = 186;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 135;
					case 135:
						num6 = 30;
						num2 = 297;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 350:
						array[9] = 152;
						goto case 55;
					case 55:
						array[10] = 228;
						num2 = 74;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 349:
						if (num12 > 0)
						{
							goto case 12;
						}
						goto case 23;
					case 12:
						num19 = num11 ^ num14;
						goto case 13;
					case 13:
						num17 = 0;
						num2 = 295;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 23:
						num20 = num11 ^ num14;
						goto case 14;
					case 14:
						array4[num21] = (byte)(num20 & 0xFFu);
						num2 = 401;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 295:
					case 348:
						if (num17 >= num12)
						{
							goto case 52;
						}
						goto case 147;
					case 147:
						if (num17 > 0)
						{
							goto case 390;
						}
						goto case 380;
					case 346:
						num3 = 30;
						num2 = 164;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 345:
						array[20] = 122;
						num2 = 193;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 48;
					case 48:
						array2[4] = 179;
						num2 = 245;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 343:
						array[31] = 35;
						num2 = 235;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 396;
					case 342:
						num3 = 120;
						num2 = 46;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 53;
					case 53:
						array2[6] = (byte)num3;
						num2 = 231;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 341:
						array[21] = 140;
						num2 = 300;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 340:
						num18 = array8.Length / 4;
						goto case 178;
					case 178:
						num11 = 0u;
						num2 = 4;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 339:
						array[21] = (byte)num6;
						goto case 232;
					case 232:
						array[21] = 117;
						goto case 122;
					case 122:
						num6 = 146;
						goto case 159;
					case 159:
						array[22] = (byte)num6;
						goto case 204;
					case 204:
						num6 = 164;
						num2 = 189;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 338:
						array2[7] = (byte)num3;
						goto case 351;
					case 335:
						num6 = 136;
						num2 = 75;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 334:
						num3 = 106;
						num2 = 162;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 331:
						num6 = 108;
						num2 = 406;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 329:
						array[0] = (byte)num6;
						goto case 54;
					case 54:
						num6 = 143;
						num2 = 117;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 137;
					case 137:
						array[0] = (byte)num6;
						num2 = 321;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 327:
						array6 = (byte[])mPoOkwJye7MIu4VUB1(object_, (int)vDUS7j7HNOyOQlPi3y(s6oD3iLff3Z1rXRCYt(object_)));
						goto case 140;
					case 140:
						array = new byte[32];
						goto case 198;
					case 198:
						array[0] = 68;
						goto case 233;
					case 233:
						num6 = 162;
						goto case 329;
					case 325:
						array2[3] = (byte)num3;
						goto case 48;
					case 324:
						switch (num8)
						{
						case 0:
							goto IL_1133;
						case 1:
							goto IL_1144;
						}
						goto case 130;
					case 130:
					case 220:
						aT32kWtqYf = p72acO2gtUwNLsSB7k(vdTAdwahwgvHUxC5w4(array5, 0u));
						goto case 318;
					case 72:
						goto IL_1133;
					case 105:
						goto IL_1144;
					case 321:
						array[0] = 44;
						goto case 27;
					case 27:
						num6 = 144;
						num2 = 218;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 316:
						array[1] = 39;
						num2 = 32;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 315:
						array[17] = 126;
						goto case 132;
					case 132:
						num6 = 62;
						num2 = 10;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 314:
						array[7] = 24;
						goto case 265;
					case 265:
						num6 = 139;
						goto case 157;
					case 157:
						array[8] = (byte)num6;
						goto case 81;
					case 81:
						array[8] = 118;
						num = 45;
						goto case 45;
					case 45:
						array[8] = 88;
						num2 = 136;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 313:
						num6 = 96;
						goto case 200;
					case 200:
						array[17] = (byte)num6;
						goto case 211;
					case 211:
						num6 = 63;
						num2 = 345;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 402;
					case 312:
						array[31] = (byte)num6;
						num2 = 199;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 310:
						array2[8] = (byte)num3;
						goto case 195;
					case 195:
						array2[8] = 92;
						goto case 107;
					case 107:
						num3 = 218;
						goto case 102;
					case 102:
						array2[8] = (byte)num3;
						goto case 386;
					case 309:
						num9 = array3.Length / 4;
						num2 = 82;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 308:
						num6 = 78;
						goto case 128;
					case 128:
						array[28] = (byte)num6;
						num2 = 180;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 307:
						array2[14] = 150;
						num = 158;
						goto case 158;
					case 158:
						array2[14] = 116;
						num2 = 25;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 109;
					case 109:
						array2[14] = 175;
						num2 = 49;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 305:
						num3 = 127;
						goto case 372;
					case 302:
						array[30] = 160;
						num2 = 356;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 301:
						array[29] = (byte)num6;
						num2 = 20;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 300:
						array[21] = 96;
						num2 = 191;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 375;
					case 299:
						array[13] = (byte)num6;
						goto case 213;
					case 213:
						array[13] = 140;
						num2 = 88;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 298:
						array[28] = 146;
						goto case 138;
					case 138:
						array[28] = 35;
						goto case 308;
					case 297:
						array[12] = (byte)num6;
						num2 = 201;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto case 86;
					case 294:
						array2[1] = (byte)num3;
						goto case 125;
					case 125:
						array2[2] = 100;
						goto case 92;
					case 92:
						num3 = 108;
						num2 = 113;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 293:
						array7 = array2;
						num2 = 362;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 292:
						num6 = 103;
						goto case 146;
					case 146:
						array[12] = (byte)num6;
						goto case 171;
					case 171:
						num6 = 124;
						goto case 36;
					case 36:
						array[12] = (byte)num6;
						num = 135;
						goto case 135;
					case 286:
						array[12] = (byte)num6;
						goto case 154;
					case 154:
						num6 = 161;
						num2 = 1;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 17;
					case 17:
						array[12] = (byte)num6;
						goto case 292;
					case 285:
						array[23] = (byte)num6;
						num2 = 184;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 283:
						array2[14] = (byte)num3;
						num2 = 307;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 282:
						num17++;
						goto case 295;
					case 279:
						array[4] = (byte)num6;
						num2 = 18;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 15;
					case 15:
						array[18] = (byte)num6;
						goto case 378;
					case 278:
						array[20] = (byte)num6;
						goto case 345;
					case 277:
						try
						{
							dGMjNBk6jwHpspu0YY(deflateStream, memoryStream);
							if (hicg3KmqBm9qhwEtQs() != null)
							{
								switch (0)
								{
								}
							}
						}
						finally
						{
							int num15;
							if (deflateStream != null)
							{
								num15 = 0;
								if (!MYfuYt9LwN8IS6f5dD())
								{
									goto IL_15d6;
								}
								goto IL_15da;
							}
							goto end_IL_15af;
							IL_15d6:
							num15 = num16;
							goto IL_15da;
							IL_15da:
							while (true)
							{
								switch (num15)
								{
								case 1:
									goto end_IL_15da;
								}
								VfcGIh0YE9P2oW9Bnx(deflateStream);
								num15 = 1;
								if (MYfuYt9LwN8IS6f5dD())
								{
									continue;
								}
								goto IL_15d6;
								continue;
								end_IL_15da:
								break;
							}
							end_IL_15af:;
						}
						goto case 208;
					case 208:
						aT32kWtqYf = p72acO2gtUwNLsSB7k(UYUTD9ykv7YK0iVOc9(memoryStream));
						goto case 134;
					case 134:
						O8SuqosjoraiY5IbBo(memoryStream);
						num2 = 320;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 276:
						array2[10] = (byte)num3;
						num2 = 106;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 275:
						num6 = 190;
						num = 219;
						goto case 219;
					case 219:
						array[7] = (byte)num6;
						goto case 314;
					case 273:
						array[11] = (byte)num6;
						num2 = 137;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 207;
					case 207:
						num6 = 26;
						goto case 248;
					case 248:
						array[11] = (byte)num6;
						num2 = 28;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto case 28;
					case 28:
						array[12] = 187;
						goto case 377;
					case 271:
						num3 = 244;
						goto case 294;
					case 269:
						array[17] = (byte)num6;
						goto case 237;
					case 237:
						num6 = 175;
						goto case 126;
					case 126:
						array[17] = (byte)num6;
						goto case 315;
					case 267:
						array[25] = (byte)num6;
						num2 = 71;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 266:
						num3 = 131;
						goto case 256;
					case 256:
						array2[6] = (byte)num3;
						goto case 342;
					case 263:
						array[9] = 92;
						num2 = 148;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 261:
						array[7] = 102;
						num2 = 275;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 260:
						array[5] = 138;
						goto case 239;
					case 239:
						array[5] = 55;
						goto case 409;
					case 259:
						array[20] = (byte)num6;
						num2 = 9;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 258:
						array[23] = 65;
						num = 34;
						goto case 34;
					case 34:
						num6 = 84;
						num2 = 285;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 257:
						array2[7] = (byte)num3;
						num2 = 334;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 252:
						if (num5 == num9 - 1)
						{
							num2 = 353;
							if (MYfuYt9LwN8IS6f5dD())
							{
								continue;
							}
							goto IL_0101;
						}
						goto case 249;
					case 251:
						num14 = 0u;
						num = 169;
						goto case 169;
					case 169:
						if (num12 > 0)
						{
							num2 = 255;
							if (hicg3KmqBm9qhwEtQs() == null)
							{
								continue;
							}
							goto IL_0101;
						}
						goto case 264;
					case 250:
						num13++;
						goto case 19;
					case 247:
						num3 = 160;
						num2 = 310;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 246:
						num3 = 49;
						goto case 240;
					case 240:
						array2[12] = (byte)num3;
						goto case 67;
					case 67:
						array2[12] = 187;
						num2 = 254;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 384;
					case 245:
						num3 = 138;
						goto case 235;
					case 235:
						array2[4] = (byte)num3;
						goto case 397;
					case 243:
						num6 = 117;
						goto case 279;
					case 234:
						array2[11] = (byte)num3;
						goto case 203;
					case 203:
						array2[12] = 143;
						goto case 60;
					case 60:
						array2[12] = 116;
						goto case 246;
					case 231:
						array2[6] = 102;
						num = 163;
						goto case 163;
					case 163:
						array2[6] = 77;
						goto case 85;
					case 85:
						num3 = 169;
						num2 = 338;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 229:
						num6 = 104;
						goto case 394;
					case 228:
						array[5] = (byte)num6;
						goto case 205;
					case 205:
						num6 = 128;
						num2 = 22;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 224:
						array2[10] = 162;
						num = 173;
						goto case 173;
					case 173:
						num3 = 103;
						num2 = 33;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 68;
					case 68:
						array2[10] = (byte)num3;
						goto case 80;
					case 80:
						num3 = 124;
						num2 = 276;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 222:
						array5 = new byte[0];
						goto case 327;
					case 218:
						array[1] = (byte)num6;
						goto case 181;
					case 181:
						num6 = 62;
						num2 = 112;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 212:
						array2[3] = 98;
						goto case 182;
					case 182:
						array2[3] = 130;
						num2 = 1;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 202:
						array3 = array6;
						goto case 127;
					case 127:
						num12 = array3.Length % 4;
						goto case 309;
					case 201:
						num6 = 84;
						goto case 299;
					case 194:
						num6 = 130;
						goto case 273;
					case 193:
						num6 = 103;
						num = 355;
						goto case 355;
					case 190:
						array2[7] = 76;
						goto case 247;
					case 189:
						array[22] = (byte)num6;
						num2 = 3;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 230;
					case 186:
						num3 = 144;
						goto case 257;
					case 185:
						array[31] = (byte)num6;
						num2 = 391;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 184:
						array[23] = 90;
						goto case 373;
					case 180:
						array[29] = 164;
						goto case 160;
					case 160:
						num6 = 146;
						num2 = 301;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 174:
						array2[5] = 243;
						goto case 40;
					case 40:
						array2[6] = 156;
						num2 = 266;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 168:
						array2[2] = (byte)num3;
						goto case 366;
					case 167:
						array2[1] = (byte)num3;
						goto case 271;
					case 166:
						num3 = 83;
						num2 = 234;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 56;
					case 56:
						array2[5] = 77;
						num = 383;
						goto case 383;
					case 165:
						num3 = 101;
						num2 = 124;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 164:
						array2[10] = (byte)num3;
						num2 = 62;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 162:
						array2[7] = (byte)num3;
						num2 = 190;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 55;
					case 156:
						deflateStream = new DeflateStream(new MemoryStream(array5), CompressionMode.Decompress);
						goto case 277;
					case 155:
						if (num5 == num9 - 1)
						{
							num = 349;
							goto case 349;
						}
						goto case 23;
					case 153:
						array[13] = (byte)num6;
						num2 = 47;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 59;
					case 59:
						array[13] = 94;
						num2 = 368;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 150:
						array[15] = 97;
						num2 = 246;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 405;
					case 148:
						array[9] = 151;
						goto case 350;
					case 143:
						num8 = num7;
						goto case 324;
					case 142:
						array2[10] = (byte)num3;
						num2 = 346;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 136:
						array[9] = 230;
						num2 = 70;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 96;
					case 96:
						array[9] = 128;
						num2 = 263;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 79;
					case 79:
						array2[11] = 113;
						num2 = 166;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 133:
						array[11] = (byte)num6;
						goto case 194;
					case 124:
						array2[1] = (byte)num3;
						goto case 8;
					case 8:
						num3 = 87;
						goto case 167;
					case 121:
						num6 = 137;
						num2 = 15;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 120:
						num6 = 165;
						num2 = 259;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 250;
					case 113:
						array2[2] = (byte)num3;
						goto case 395;
					case 112:
						array[1] = (byte)num6;
						num = 316;
						goto case 316;
					case 106:
						num3 = 92;
						goto case 142;
					case 104:
						num3 = 209;
						num2 = 90;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto case 59;
					case 101:
						array[2] = (byte)num6;
						num2 = 322;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 379;
					case 100:
						num6 = 170;
						goto case 358;
					case 90:
						array2[9] = (byte)num3;
						num2 = 224;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 88:
						num6 = 113;
						num = 153;
						goto case 153;
					case 87:
						array[30] = 104;
						goto case 302;
					case 83:
						array2[3] = 106;
						num2 = 212;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto case 172;
					case 82:
						array4 = new byte[array3.Length];
						goto case 340;
					case 78:
						array[27] = (byte)num6;
						goto case 100;
					case 77:
						array2[15] = 45;
						goto case 393;
					case 75:
						array[26] = (byte)num6;
						num2 = 150;
						if (hicg3KmqBm9qhwEtQs() != null)
						{
							continue;
						}
						goto case 365;
					case 73:
						array[6] = (byte)num6;
						num = 404;
						goto case 404;
					case 71:
						array[26] = 168;
						goto case 335;
					case 62:
						array2[11] = 140;
						num2 = 79;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
					case 49:
						array2[14] = 88;
						num = 77;
						goto case 77;
					case 32:
						num6 = 99;
						goto case 101;
					case 29:
						EX90p8gpZqIwadFGvF(s6oD3iLff3Z1rXRCYt(object_), 0L);
						goto case 222;
					case 22:
						array[5] = (byte)num6;
						goto IL_1f7f;
					case 11:
						goto IL_1f7f;
					case 20:
						array[29] = 232;
						goto case 229;
					case 18:
						num6 = 130;
						goto case 228;
					case 10:
						array[17] = (byte)num6;
						goto case 313;
					case 9:
						num6 = 142;
						num2 = 278;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto case 175;
					case 7:
						array[25] = 147;
						goto case 370;
					case 6:
						array[30] = 125;
						num2 = 87;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto IL_0101;
					case 5:
						num5 = 0;
						num = 110;
						goto case 110;
					case 4:
						num4 = 0u;
						num = 251;
						goto case 251;
					case 3:
						array2[15] = 124;
						goto case 305;
					case 1:
						num3 = 130;
						num2 = 407;
						if (MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 14;
					default:
						array[28] = 103;
						num2 = 89;
						if (!MYfuYt9LwN8IS6f5dD())
						{
							continue;
						}
						goto case 298;
					case 392:
						goto IL_270e;
					case 116:
						goto end_IL_270e;
					case 304:
						Bmo2jlCZwS = true;
						return;
					case 115:
					case 274:
						return;
						IL_1144:
						memoryStream = new MemoryStream();
						num2 = 156;
						if (hicg3KmqBm9qhwEtQs() == null)
						{
							continue;
						}
						goto IL_0101;
						IL_1133:
						aT32kWtqYf = p72acO2gtUwNLsSB7k(array5);
						goto case 318;
					}
					break;
				}
				goto IL_0565;
				IL_1f7f:
				array[5] = 179;
				num2 = 260;
				if (!MYfuYt9LwN8IS6f5dD())
				{
					goto IL_0565;
				}
				goto IL_2094;
				IL_0565:
				array2 = new byte[16];
				num2 = 322;
				if (hicg3KmqBm9qhwEtQs() == null)
				{
					goto IL_0583;
				}
				goto IL_2094;
				IL_0583:
				num3 = 84;
				goto IL_0589;
				IL_0589:
				array2[0] = (byte)num3;
				goto IL_0597;
				IL_0597:
				array2[0] = 162;
				goto IL_05a6;
				IL_05a6:
				num3 = 87;
				goto IL_05ac;
				IL_05ac:
				array2[0] = (byte)num3;
				goto IL_05ba;
				IL_05ba:
				array2[0] = 30;
				goto IL_05c6;
				IL_05c6:
				num3 = 126;
				goto IL_05cc;
				IL_05cc:
				array2[1] = (byte)num3;
				num2 = 408;
				if (!MYfuYt9LwN8IS6f5dD())
				{
					goto IL_0101;
				}
				goto IL_2094;
				IL_0101:
				num2 = num;
				goto IL_2094;
				continue;
				end_IL_270e:
				break;
			}
		}
	}

	internal static string[] Lg92BXHIlD(Assembly assembly_0)
	{
		if (assembly_0 == typeof(RCNOXXe2fBO2yniWl1).Assembly)
		{
			if (!Bmo2jlCZwS)
			{
				q0r2feGYcM();
			}
			List<string> list = new List<string>();
			list.AddRange(assembly_0.GetManifestResourceNames());
			list.AddRange(((Assembly)aT32kWtqYf).GetManifestResourceNames());
			return list.ToArray();
		}
		return assembly_0.GetManifestResourceNames();
	}

	private static Assembly kRr2qt9D1o(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (!Bmo2jlCZwS)
		{
			q0r2feGYcM();
		}
		string name = resolveEventArgs_0.Name;
		int num = 0;
		while (true)
		{
			if (num < sdB26V5n3A.Length)
			{
				if (sdB26V5n3A[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)aT32kWtqYf;
	}

	public RCNOXXe2fBO2yniWl1()
	{
		AppDomain.CurrentDomain.ResourceResolve += kRr2qt9D1o;
		R8TayKhW8eikpukIpe.piUZpdWzJZMua();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!e7Q2xfunNv)
		{
			e7Q2xfunNv = true;
			new RCNOXXe2fBO2yniWl1();
		}
	}

	internal static Type bqLDgxRdJ1kHxAWxEk(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object d4mUt4HLtdT1qAZB4w(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object s6oD3iLff3Z1rXRCYt(object object_0)
	{
		return ((pHtTtXRCv6EXeda4Vr.mmmhROZdZfJrbe84gQ)object_0).KDikMXewCI();
	}

	internal static void EX90p8gpZqIwadFGvF(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long vDUS7j7HNOyOQlPi3y(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object mPoOkwJye7MIu4VUB1(object object_0, int int_0)
	{
		return ((pHtTtXRCv6EXeda4Vr.mmmhROZdZfJrbe84gQ)object_0).YWx2NH3LvW(int_0);
	}

	internal static object p72acO2gtUwNLsSB7k(object object_0)
	{
		return AtXNkazdFeCU5gb9KV.kd92WyLNBc((byte[])object_0);
	}

	internal static void dGMjNBk6jwHpspu0YY(object object_0, object object_1)
	{
		((Stream)object_0).CopyTo((Stream)object_1);
	}

	internal static void VfcGIh0YE9P2oW9Bnx(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object UYUTD9ykv7YK0iVOc9(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void O8SuqosjoraiY5IbBo(object object_0)
	{
		((Stream)object_0).Dispose();
	}

	internal static object vdTAdwahwgvHUxC5w4(object object_0, uint uint_0)
	{
		return AtXNkazdFeCU5gb9KV.u7B2XhsBQw((byte[])object_0, uint_0);
	}

	internal static object AaONtcQlitaKVLxooo(object object_0)
	{
		return ((Assembly)object_0).GetManifestResourceNames();
	}

	internal static bool MYfuYt9LwN8IS6f5dD()
	{
		return (object)null == null;
	}

	internal static object hicg3KmqBm9qhwEtQs()
	{
		return null;
	}
}
