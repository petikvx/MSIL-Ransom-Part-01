using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using d3D9KgPGcAIyem8idS;
using rRTPGR4IeVc03k9hR35;

namespace H7hxWS4W3mf1brr6yH6;

internal class CftN3n4l13oJTY0dUlW
{
	private enum xGJK6B436egeX13kHiW
	{

	}

	internal class TBGGEf4MSo7FCofHlcS
	{
		private unsafe static uint A3u4uacZ6Z(void* pVoid_0, uint uint_0)
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

		private unsafe static bool cGW4JKf7QI(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			bool flag = true;
			uint num = 0u;
			while (flag && num < uint_0)
			{
				flag = ((byte*)pVoid_0)[num] == ((byte*)pVoid_1)[num];
				num++;
			}
			return flag;
		}

		private unsafe static void x4v4vK2k7B(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[num] = byte_0;
			}
		}

		private unsafe static void MOR4yXEGFJ(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[num] = ((byte*)pVoid_1)[num];
			}
		}

		private unsafe static void hAY4tS9wDi(byte* pByte_0, byte* pByte_1, uint uint_0)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (uint_0 < 5)
				{
					*(int*)pByte_0 = *(int*)pByte_1;
					return;
				}
				byte* ptr = pByte_0 + uint_0;
				while (pByte_0 < ptr)
				{
					*(int*)pByte_0 = *(int*)pByte_1;
					pByte_0 += 4;
					pByte_1 += 4;
				}
			}
			else if (uint_0 > 8 && pByte_1 + uint_0 < pByte_0)
			{
				MOR4yXEGFJ(pByte_0, pByte_1, uint_0);
			}
			else
			{
				byte* ptr2 = pByte_0 + uint_0;
				while (pByte_0 < ptr2)
				{
					*pByte_0 = *pByte_1;
					pByte_0++;
					pByte_1++;
				}
			}
		}

		private unsafe static uint uYo4zawTXn(object object_0, uint uint_0, xGJK6B436egeX13kHiW xGJK6B436egeX13kHiW_0)
		{
			int result;
			fixed (byte* ptr = object_0)
			{
				result = *(int*)(ptr + uint_0 + (nint)xGJK6B436egeX13kHiW_0 * (nint)4);
			}
			return (uint)result;
		}

		public static uint FGkBn98EYA(object object_0, uint uint_0)
		{
			return tkHaabU4AYOQa0bpI4D(object_0, uint_0, (xGJK6B436egeX13kHiW)3);
		}

		private unsafe static uint Q7OBmd6gHP(object object_0, uint uint_0, object object_1)
		{
			fixed (byte* ptr = object_0)
			{
				fixed (byte* ptr4 = object_1)
				{
					byte* ptr2 = ptr + uint_0;
					uint num = 32u;
					byte* ptr3 = ptr2 + 32u;
					byte* ptr5 = ptr4;
					uint* ptr6 = (uint*)ptr2;
					byte* ptr7 = ptr4 + A3u4uacZ6Z(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (A3u4uacZ6Z(ptr6 + 4, 4u) != 1)
					{
						MOR4yXEGFJ(ptr4, ptr2 + num, A3u4uacZ6Z(ptr6 + 3, 4u));
						return A3u4uacZ6Z(ptr6 + 3, 4u);
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
							num2 = A3u4uacZ6Z(ptr3, 4u);
							ptr3 += 4;
						}
						uint num3 = A3u4uacZ6Z(ptr3, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								hAY4tS9wDi(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr3++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								hAY4tS9wDi(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr3 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								hAY4tS9wDi(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr3 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								hAY4tS9wDi(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr3 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								hAY4tS9wDi(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr3 += 4;
							}
							else
							{
								byte byte_ = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFFu;
								x4v4vK2k7B(ptr5, byte_, num5);
								ptr5 += num5;
								ptr3 += 3;
							}
						}
						else
						{
							hAY4tS9wDi(ptr5, ptr3, 4u);
							ptr5 += array[num2 & 0xF];
							ptr3 += array[num2 & 0xF];
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

		internal static object dquB408ghG(object object_0)
		{
			return mMZdHMUY5rbUSkA26Ig(hrcSEMUBntsIUf6xw4o(typeof(Assembly).TypeHandle).GetMethod((string)AfhYVfUZAxJUlmDximG(U1OA9oWOyDJaui4H8n.WnEmYpOu4u(1592)), new Type[1] { typeof(byte[]) }), null, new object[1] { object_0 });
		}

		public static byte[] PY4BB3aDin(object object_0, uint uint_0)
		{
			uint num = DY3US9UscXWxnhC3ZI6(object_0, uint_0);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				j3AT2MUkpQgXG28fA3U(object_0, uint_0, array);
			}
			return array;
		}

		internal static uint tkHaabU4AYOQa0bpI4D(object object_0, uint uint_0, xGJK6B436egeX13kHiW xGJK6B436egeX13kHiW_0)
		{
			return uYo4zawTXn(object_0, uint_0, xGJK6B436egeX13kHiW_0);
		}

		internal static Type hrcSEMUBntsIUf6xw4o(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object AfhYVfUZAxJUlmDximG(object object_0)
		{
			return ((string)object_0).Trim();
		}

		internal static object mMZdHMUY5rbUSkA26Ig(object object_0, object object_1, object object_2)
		{
			return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
		}

		internal static uint DY3US9UscXWxnhC3ZI6(object object_0, uint uint_0)
		{
			return FGkBn98EYA(object_0, uint_0);
		}

		internal static uint j3AT2MUkpQgXG28fA3U(object object_0, uint uint_0, object object_1)
		{
			return Q7OBmd6gHP(object_0, uint_0, object_1);
		}
	}

	private static object Qew4GAeA7L = new string[0];

	private static object CFW498MY6l = null;

	private static bool cH54oUOx7w = false;

	private static bool paf46FZ9As = false;

	private static void o5P4TSy5PK()
	{
		byte[] array = default(byte[]);
		U1OA9oWOyDJaui4H8n.YvSqsm4FEMQVAcAhE3h object_ = default(U1OA9oWOyDJaui4H8n.YvSqsm4FEMQVAcAhE3h);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num19 = default(int);
		byte[] array6 = default(byte[]);
		int num6 = default(int);
		int num21 = default(int);
		uint num22 = default(uint);
		uint num18 = default(uint);
		int num12 = default(int);
		int num13 = default(int);
		uint num11 = default(uint);
		byte[] array5 = default(byte[]);
		uint num15 = default(uint);
		int num14 = default(int);
		uint num7 = default(uint);
		byte[] array4 = default(byte[]);
		int num3 = default(int);
		int num2 = default(int);
		uint num9 = default(uint);
		uint num10 = default(uint);
		byte[] array7 = default(byte[]);
		int num16 = default(int);
		int num5 = default(int);
		byte[] array8 = default(byte[]);
		int num20 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		DeflateStream deflateStream = default(DeflateStream);
		int num17 = default(int);
		int num8 = default(int);
		while (true)
		{
			IL_2515:
			int num;
			if (cH54oUOx7w)
			{
				num = 204;
				if (EsddUWw56r20fv2j3fd() == null)
				{
					break;
				}
				goto IL_1dde;
			}
			goto IL_24dd;
			IL_0767:
			array[2] = 207;
			num = 300;
			if (EsddUWw56r20fv2j3fd() != null)
			{
				goto IL_0786;
			}
			goto IL_1dde;
			IL_24dd:
			object_ = new U1OA9oWOyDJaui4H8n.YvSqsm4FEMQVAcAhE3h((Stream)VElWukwNEXDLHIj37Cm(pT7ACGwqnBd1LcpYqE1(typeof(U1OA9oWOyDJaui4H8n).TypeHandle).Assembly, U1OA9oWOyDJaui4H8n.WnEmYpOu4u(1514)));
			goto IL_24c6;
			IL_24c6:
			mvUpZswCowdmbUh56SN(Te2WRAwED6aYMd94lcP(object_), 0L);
			goto IL_24bc;
			IL_24bc:
			array2 = new byte[0];
			goto IL_2490;
			IL_2490:
			array3 = (byte[])bYKmNxwiYELSYZPSe7d(object_, (int)s2PX1uwaSmxSYU5UuCY(Te2WRAwED6aYMd94lcP(object_)));
			num = 148;
			if (EsddUWw56r20fv2j3fd() == null)
			{
				goto IL_097a;
			}
			goto IL_1dde;
			IL_1dde:
			while (true)
			{
				switch (num)
				{
				case 425:
					num19 += 8;
					num = 135;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 141;
				case 141:
					array6[num6 + num21] = (byte)((num22 & num18) >> num19);
					goto case 217;
				case 217:
					num21++;
					num = 59;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 81;
				case 81:
				case 249:
					if (num21 >= num12)
					{
						goto case 277;
					}
					goto case 182;
				case 277:
				case 286:
					num13++;
					num = 192;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 127;
				case 127:
					num11 = (uint)((array5[num15 + 3] << 24) | (array5[num15 + 2] << 16) | (array5[num15 + 1] << 8) | array5[num15]);
					goto case 116;
				case 117:
					if (num13 == num14 - 1)
					{
						goto case 157;
					}
					goto case 397;
				case 157:
					if (num12 <= 0)
					{
						goto case 397;
					}
					num = 53;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 357;
				case 397:
					num7 = num9 ^ num11;
					num = 350;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 227;
				case 227:
					array[19] = 119;
					num = 404;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 356;
				case 356:
					array4[9] = (byte)num3;
					goto case 137;
				case 137:
					num3 = 151;
					goto case 379;
				case 379:
					array4[9] = (byte)num3;
					goto case 352;
				case 352:
					array4[9] = 149;
					goto case 243;
				case 243:
					num3 = 114;
					num = 418;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 205;
				case 205:
					array4[6] = 192;
					goto case 346;
				case 346:
					num3 = 186;
					goto case 162;
				case 162:
					array4[6] = (byte)num3;
					goto case 268;
				case 268:
					num3 = 102;
					goto case 233;
				case 233:
					array4[6] = (byte)num3;
					num = 264;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 312;
				case 312:
					num3 = 132;
					goto case 263;
				case 263:
					array4[6] = (byte)num3;
					num = 182;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 358;
				case 358:
					array4[6] = 234;
					num = 25;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 39;
				case 39:
					array4[7] = 203;
					goto case 6;
				case 6:
					num3 = 148;
					goto case 44;
				case 44:
					array4[7] = (byte)num3;
					goto case 190;
				case 190:
					array4[7] = 168;
					goto case 328;
				case 328:
					num3 = 91;
					goto case 18;
				case 18:
					array4[7] = (byte)num3;
					goto case 160;
				case 160:
					num3 = 125;
					goto case 323;
				case 323:
					array4[7] = (byte)num3;
					goto case 372;
				case 372:
					num3 = 82;
					goto case 119;
				case 119:
					array4[7] = (byte)num3;
					num = 130;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 111;
				case 111:
					num2 = 118;
					goto case 234;
				case 234:
					array[4] = (byte)num2;
					goto case 215;
				case 215:
					num2 = 157;
					num = 167;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 77;
				case 77:
					array[24] = (byte)num2;
					goto case 186;
				case 186:
					array[24] = 28;
					goto case 235;
				case 235:
					array[25] = 106;
					num = 241;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 210;
				case 210:
					array4[1] = (byte)num3;
					goto case 122;
				case 122:
					num3 = 157;
					goto case 294;
				case 294:
					array4[1] = (byte)num3;
					goto case 380;
				case 380:
					array4[2] = 141;
					goto case 424;
				case 424:
					array4[2] = 127;
					goto case 82;
				case 82:
					array4[2] = 113;
					goto case 382;
				case 382:
					num3 = 76;
					goto case 33;
				case 33:
					array4[2] = (byte)num3;
					goto case 304;
				case 304:
					num3 = 154;
					goto case 23;
				case 23:
					array4[2] = (byte)num3;
					num = 420;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 246;
				case 246:
					num2 = 171;
					goto case 320;
				case 320:
					array[25] = (byte)num2;
					goto case 281;
				case 281:
					num2 = 78;
					num = 52;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 32;
				case 32:
					array6[num6 + 2] = (byte)((num7 & 0xFF0000) >> 16);
					goto case 153;
				case 153:
					array6[num6 + 3] = (byte)((num7 & 0xFF000000u) >> 24);
					goto case 277;
				case 357:
					num22 = num9 ^ num11;
					goto case 285;
				case 285:
					num21 = 0;
					goto case 81;
				case 182:
					if (num21 <= 0)
					{
						goto case 141;
					}
					num = 155;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 221;
				case 221:
					num18 <<= 8;
					goto case 425;
				case 116:
				case 134:
				{
					uint num23 = num9;
					num9 = 255u;
					uint num24 = num23;
					num24 ^= num24 << 2;
					num24 += 1245714516;
					num24 ^= num24 << 17;
					num24 += 1078862260;
					num24 ^= num24 >> 15;
					num24 += 497718232;
					num24 = 1821220856 + num24;
					num9 = num23 + (uint)(double)num24;
					goto case 117;
				}
				case 423:
					num9 += num10;
					goto case 127;
				case 422:
					num2 = 117;
					num = 411;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 223;
				case 223:
					num3 = 65;
					num = 270;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 344;
				case 344:
					array4[5] = (byte)num3;
					goto case 107;
				case 107:
					array4[5] = 189;
					goto case 290;
				case 290:
					num3 = 104;
					num = 203;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 116;
				case 421:
					num3 = 193;
					goto case 291;
				case 291:
					array4[15] = (byte)num3;
					num = 103;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 113;
				case 113:
					array4[15] = 125;
					goto case 16;
				case 16:
					num3 = 27;
					goto case 78;
				case 78:
					array4[15] = (byte)num3;
					goto case 58;
				case 58:
					array7 = array4;
					goto case 183;
				case 183:
					num16 = 1;
					goto case 230;
				case 230:
					num5 = 0;
					num = 228;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 52;
				case 52:
					array[26] = (byte)num2;
					goto case 51;
				case 51:
					array[26] = 140;
					goto case 129;
				case 129:
					num2 = 186;
					goto case 219;
				case 219:
					array[26] = (byte)num2;
					goto case 412;
				case 412:
					array[27] = 92;
					goto case 270;
				case 270:
					num2 = 159;
					goto case 109;
				case 109:
					array[27] = (byte)num2;
					goto case 239;
				case 239:
					num2 = 88;
					num = 54;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 8;
				case 8:
					num2 = 61;
					goto case 103;
				case 103:
					array[5] = (byte)num2;
					goto case 351;
				case 351:
					array[5] = 115;
					num = 345;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 107;
				case 420:
					num3 = 243;
					goto case 108;
				case 108:
					array4[2] = (byte)num3;
					goto case 317;
				case 317:
					array4[3] = 141;
					goto case 381;
				case 381:
					num3 = 132;
					goto case 413;
				case 413:
					array4[3] = (byte)num3;
					num = 70;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 53;
				case 53:
					array4[10] = 139;
					goto IL_0786;
				case 260:
					break;
				case 76:
					goto IL_061a;
				case 21:
					goto IL_0628;
				case 415:
					goto IL_062e;
				case 74:
					goto IL_063c;
				case 293:
					goto IL_0648;
				case 80:
					goto IL_064e;
				case 9:
					goto IL_066c;
				case 164:
					goto IL_0682;
				case 238:
					goto IL_0690;
				case 189:
					goto IL_069f;
				case 43:
					goto IL_06ab;
				case 250:
					goto IL_06ba;
				case 202:
					goto IL_06c6;
				case 179:
					goto IL_06e5;
				case 406:
					goto IL_06f1;
				case 378:
					goto IL_06fa;
				case 63:
					goto IL_0708;
				case 20:
					goto IL_0724;
				case 36:
					goto IL_0743;
				case 308:
					goto IL_074f;
				case 59:
					goto IL_075b;
				case 376:
					goto IL_0767;
				case 50:
					goto IL_0786;
				case 419:
					array4[1] = (byte)num3;
					goto case 181;
				case 181:
					num3 = 91;
					goto case 297;
				case 297:
					array4[1] = (byte)num3;
					goto case 403;
				case 403:
					array4[1] = 183;
					num = 0;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 87;
				case 87:
					array4[1] = 136;
					goto case 197;
				case 197:
					num3 = 119;
					goto case 210;
				case 418:
					array4[9] = (byte)num3;
					num = 343;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 173;
				case 173:
					array[9] = (byte)num2;
					num = 201;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 248;
				case 248:
					array[9] = 140;
					num = 383;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 394;
				case 394:
					num2 = 119;
					num = 15;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 3;
				case 3:
					num2 = 133;
					num = 268;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 282;
				case 282:
					array[31] = (byte)num2;
					goto case 161;
				case 161:
					array[31] = 72;
					goto case 5;
				case 5:
					array8 = array;
					num = 22;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 7;
				case 7:
					num2 = 168;
					goto case 38;
				case 38:
					array[17] = (byte)num2;
					goto case 399;
				case 399:
					num2 = 150;
					num = 7;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 391;
				case 391:
					array[17] = (byte)num2;
					goto case 145;
				case 145:
					array[17] = 90;
					goto case 368;
				case 368:
					array[17] = 214;
					num = 191;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 91;
				case 91:
					array[5] = 57;
					num = 1;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto default;
				default:
					array[30] = 51;
					goto case 60;
				case 60:
					num2 = 39;
					num = 79;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto IL_061a;
				case 417:
					array4[10] = 109;
					goto case 389;
				case 389:
					num3 = 85;
					num = 316;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto IL_097a;
				case 170:
					goto IL_097a;
				case 229:
					goto IL_0988;
				case 71:
					goto IL_0997;
				case 337:
					goto IL_09a6;
				case 388:
					goto IL_09ac;
				case 416:
					array[13] = 89;
					goto case 209;
				case 209:
					array[13] = 162;
					num = 71;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 94;
				case 94:
					num2 = 184;
					goto case 101;
				case 101:
					array[14] = (byte)num2;
					num = 24;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 102;
				case 102:
					num2 = 124;
					goto case 341;
				case 341:
					array[14] = (byte)num2;
					num = 231;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 184;
				case 184:
					num2 = 158;
					num = 284;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 262;
				case 262:
					num2 = 176;
					goto case 121;
				case 121:
					array[4] = (byte)num2;
					goto case 8;
				case 414:
					array[8] = (byte)num2;
					num = 57;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 332;
				case 332:
					num2 = 167;
					num = 55;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 125;
				case 125:
					array[8] = (byte)num2;
					goto case 83;
				case 83:
					array[9] = 159;
					goto case 176;
				case 176:
					array[9] = 79;
					goto case 136;
				case 136:
					num2 = 162;
					goto case 173;
				case 411:
					array[19] = (byte)num2;
					goto case 227;
				case 410:
					array[14] = (byte)num2;
					num = 327;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 273;
				case 273:
					array[0] = (byte)num2;
					goto case 362;
				case 362:
					array[1] = 123;
					num = 114;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 124;
				case 124:
					array[1] = 212;
					goto case 360;
				case 360:
					array[1] = 133;
					goto IL_0743;
				case 409:
					array[31] = 118;
					goto case 287;
				case 287:
					num2 = 64;
					goto case 85;
				case 85:
					array[31] = (byte)num2;
					goto case 3;
				case 408:
					array5 = array3;
					goto case 169;
				case 169:
					num12 = array5.Length % 4;
					num = 57;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 38;
				case 407:
					num2 = 79;
					num = 359;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto IL_24bc;
				case 404:
					array[19] = 128;
					num = 184;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 68;
				case 68:
					array4[15] = (byte)num3;
					goto case 147;
				case 147:
					array4[15] = 194;
					num = 27;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 15;
				case 15:
					array[9] = (byte)num2;
					goto case 295;
				case 295:
					array[10] = 104;
					num = 52;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 365;
				case 365:
					num2 = 114;
					goto case 19;
				case 19:
					array[10] = (byte)num2;
					num = 115;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 142;
				case 142:
					num2 = 24;
					goto case 296;
				case 296:
					array[10] = (byte)num2;
					num = 299;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto IL_066c;
				case 402:
					num2 = 162;
					num = 9;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 140;
				case 140:
					array[13] = (byte)num2;
					num = 27;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 95;
				case 95:
					array[13] = 152;
					goto case 342;
				case 342:
					num2 = 118;
					num = 54;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 151;
				case 151:
					array[13] = (byte)num2;
					goto case 416;
				case 401:
					array4[14] = 191;
					goto case 274;
				case 274:
					array4[14] = 178;
					goto case 333;
				case 333:
					num3 = 92;
					goto case 319;
				case 319:
					array4[14] = (byte)num3;
					goto case 278;
				case 278:
					num3 = 37;
					num = 68;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 23;
				case 400:
					array[17] = 122;
					goto case 7;
				case 398:
					array[3] = 163;
					goto case 69;
				case 69:
					array[3] = 128;
					num = 266;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 181;
				case 396:
					array4[0] = 81;
					goto case 114;
				case 114:
					num3 = 172;
					goto case 419;
				case 395:
					array[15] = (byte)num2;
					goto case 222;
				case 222:
					array[15] = 205;
					num = 257;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 109;
				case 393:
					if (num12 > 0)
					{
						goto case 133;
					}
					goto case 370;
				case 133:
					num11 = 0u;
					num = 56;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 64;
				case 64:
					num9 += num10;
					num = 0;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 65;
				case 65:
					num20 = 0;
					goto case 10;
				case 40:
					if (num20 > 0)
					{
						num = 30;
						if (!H59KTlwFXKjZctW3nxb())
						{
							continue;
						}
						goto case 311;
					}
					goto case 324;
				case 311:
					num11 <<= 8;
					goto case 324;
				case 324:
					num11 |= array5[^(1 + num20)];
					num = 291;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 331;
				case 331:
					num20++;
					goto case 10;
				case 10:
				case 168:
					if (num20 >= num12)
					{
						goto case 116;
					}
					goto case 40;
				case 370:
					num15 = (uint)num6;
					goto case 423;
				case 392:
					iahwT6wQshgQ4kNhTwh(memoryStream);
					num = 251;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 314;
				case 390:
					array[6] = (byte)num2;
					num = 232;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 211;
				case 387:
					array[20] = 91;
					goto case 375;
				case 375:
					array[20] = 104;
					num = 48;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 301;
				case 301:
					array[20] = 109;
					goto case 355;
				case 355:
					array[20] = 90;
					goto case 75;
				case 75:
					array[20] = 254;
					goto case 322;
				case 322:
					array[21] = 131;
					goto case 143;
				case 143:
					array[21] = 113;
					num = 315;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 5;
				case 386:
					array[18] = 141;
					num = 339;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 157;
				case 385:
					array4[13] = 154;
					goto case 269;
				case 269:
					num3 = 67;
					goto case 253;
				case 253:
					array4[13] = (byte)num3;
					num = 401;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 218;
				case 218:
					array[16] = (byte)num2;
					num = 123;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 37;
				case 37:
					array4[5] = 23;
					num = 100;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 159;
				case 159:
					array4[6] = 154;
					num = 205;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 204;
				case 204:
					num14++;
					goto case 46;
				case 46:
					num15 = 0u;
					goto case 99;
				case 99:
					num13 = 0;
					goto case 105;
				case 105:
				case 192:
					if (num13 >= num14)
					{
						goto case 45;
					}
					goto case 188;
				case 45:
					array2 = array6;
					goto case 236;
				case 236:
					if (num16 != 0)
					{
						goto case 13;
					}
					goto case 405;
				case 13:
					if (num16 == 1)
					{
						goto case 325;
					}
					goto case 131;
				case 325:
					memoryStream = new MemoryStream();
					goto case 47;
				case 47:
					deflateStream = new DeflateStream(new MemoryStream(array2), CompressionMode.Decompress);
					num = 104;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 27;
				case 27:
					num3 = 104;
					goto case 240;
				case 240:
					array4[15] = (byte)num3;
					goto case 421;
				case 188:
					num17 = num13 % num8;
					goto case 216;
				case 216:
					num6 = num13 * 4;
					goto case 175;
				case 175:
					num15 = (uint)(num17 * 4);
					goto case 89;
				case 89:
					num10 = (uint)((array8[num15 + 3] << 24) | (array8[num15 + 2] << 16) | (array8[num15 + 1] << 8) | array8[num15]);
					goto case 138;
				case 138:
					num18 = 255u;
					num = 47;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 177;
				case 177:
					num19 = 0;
					num = 334;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 193;
				case 193:
					num2 = 11;
					goto case 390;
				case 384:
					array[30] = (byte)num2;
					goto case 271;
				case 271:
					num2 = 118;
					goto case 307;
				case 307:
					array[30] = (byte)num2;
					num = 0;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto default;
				case 383:
					array4[4] = 46;
					num = 179;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 132;
				case 132:
					CFW498MY6l = xfRQZSwrIJkmpGJgr2x(EA1l3BwAjMiQg687J3L(memoryStream));
					num = 392;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto default;
				case 377:
					array[2] = (byte)num2;
					goto case 163;
				case 163:
					array[2] = 243;
					num = 398;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 359;
				case 359:
					array[13] = (byte)num2;
					num = 402;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 198;
				case 198:
					array[11] = 90;
					num = 84;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 52;
				case 374:
					array[18] = (byte)num2;
					goto case 305;
				case 305:
					array[18] = 62;
					goto case 386;
				case 371:
					array4[4] = (byte)num3;
					goto case 97;
				case 97:
					array4[4] = 103;
					goto case 220;
				case 220:
					num3 = 61;
					goto case 148;
				case 148:
					array4[4] = (byte)num3;
					num = 56;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 8;
				case 369:
					array[6] = (byte)num2;
					num = 8;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 41;
				case 41:
					num2 = 87;
					num = 128;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 72;
				case 72:
					array4[10] = 134;
					goto case 417;
				case 367:
					num2 = 148;
					goto case 377;
				case 366:
					num2 = 111;
					goto case 61;
				case 61:
					array[27] = (byte)num2;
					goto case 242;
				case 242:
					array[28] = 75;
					num = 12;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 4;
				case 4:
					array4[13] = 140;
					num = 149;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 306;
				case 306:
					array4[13] = 165;
					goto case 354;
				case 354:
					num3 = 33;
					goto case 152;
				case 152:
					array4[13] = (byte)num3;
					goto case 385;
				case 364:
					num2 = 90;
					goto case 115;
				case 115:
					array[12] = (byte)num2;
					num = 252;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 57;
				case 57:
					num14 = array5.Length / 4;
					num = 35;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 13;
				case 363:
					array4[8] = (byte)num3;
					goto case 302;
				case 302:
					num3 = 65;
					num = 347;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 196;
				case 196:
					array[5] = (byte)num2;
					num = 81;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 91;
				case 353:
					num2 = 85;
					goto case 288;
				case 288:
					array[23] = (byte)num2;
					goto case 267;
				case 267:
					array[24] = 154;
					goto case 66;
				case 66:
					array[24] = 126;
					num = 165;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 224;
				case 224:
					num2 = 130;
					goto case 77;
				case 350:
					array6[num6] = (byte)(num7 & 0xFFu);
					goto case 73;
				case 73:
					array6[num6 + 1] = (byte)((num7 & 0xFF00) >> 8);
					num = 2;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 32;
				case 349:
					array[11] = 130;
					num = 106;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 198;
				case 348:
					array[23] = (byte)num2;
					num = 353;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 54;
				case 54:
					array[27] = (byte)num2;
					goto case 276;
				case 276:
					array[27] = 135;
					num = 366;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 302;
				case 347:
					array4[8] = (byte)num3;
					goto case 120;
				case 120:
					num3 = 64;
					num = 356;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 5;
				case 345:
					num2 = 135;
					goto case 196;
				case 343:
					num3 = 123;
					goto case 261;
				case 261:
					array4[10] = (byte)num3;
					goto case 72;
				case 340:
					num2 = 120;
					goto case 251;
				case 251:
					array[14] = (byte)num2;
					goto case 272;
				case 272:
					num2 = 254;
					goto case 410;
				case 339:
					array[18] = 188;
					goto case 158;
				case 158:
					array[19] = 41;
					goto case 422;
				case 338:
					num2 = 130;
					goto case 258;
				case 258:
					array[7] = (byte)num2;
					goto case 283;
				case 283:
					num2 = 141;
					num = 135;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 26;
				case 26:
					array[11] = (byte)num2;
					num = 302;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 349;
				case 336:
					array[7] = 168;
					goto case 207;
				case 207:
					array[7] = 96;
					goto case 149;
				case 149:
					array[7] = 135;
					goto case 259;
				case 259:
					array[8] = 85;
					goto case 329;
				case 329:
					num2 = 155;
					goto case 414;
				case 335:
					num2 = 94;
					num = 156;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 23;
				case 334:
					if (num13 == num14 - 1)
					{
						goto case 393;
					}
					goto case 370;
				case 330:
					num2 = 116;
					num = 218;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 156;
				case 156:
					array[12] = (byte)num2;
					goto case 364;
				case 327:
					array[15] = 92;
					goto case 171;
				case 171:
					num2 = 108;
					goto case 28;
				case 28:
					array[15] = (byte)num2;
					num = 36;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 100;
				case 100:
					array[15] = 144;
					num = 180;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 136;
				case 326:
					array[31] = (byte)num2;
					goto case 409;
				case 321:
					num3 = 62;
					goto case 194;
				case 194:
					array4[3] = (byte)num3;
					goto case 289;
				case 289:
					array4[3] = 187;
					goto case 92;
				case 92:
					num3 = 124;
					goto case 371;
				case 318:
					array[12] = 119;
					goto case 335;
				case 316:
					array4[10] = (byte)num3;
					num = 20;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 13;
				case 315:
					array[21] = 120;
					num = 110;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 37;
				case 313:
					num2 = 97;
					num = 10;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 155;
				case 155:
					array[12] = (byte)num2;
					goto case 318;
				case 309:
					num3 = 126;
					goto case 98;
				case 98:
					array4[0] = (byte)num3;
					goto case 396;
				case 303:
					array[4] = 205;
					goto case 49;
				case 49:
					num2 = 200;
					goto case 34;
				case 34:
					array[4] = (byte)num2;
					goto case 262;
				case 300:
					array[2] = 120;
					num = 269;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 367;
				case 299:
					array[11] = 220;
					goto case 247;
				case 247:
					num2 = 197;
					goto case 26;
				case 292:
					array[25] = 61;
					num = 101;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 246;
				case 284:
					array[19] = (byte)num2;
					goto case 126;
				case 126:
					num2 = 85;
					num = 90;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 29;
				case 29:
					array[22] = 153;
					goto case 265;
				case 265:
					array[22] = 186;
					num = 29;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 154;
				case 154:
					array[23] = 105;
					num = 213;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 200;
				case 200:
					num11 = 0u;
					num = 50;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 112;
				case 112:
					if (num12 > 0)
					{
						goto case 204;
					}
					goto case 46;
				case 280:
					array4[12] = (byte)num3;
					goto case 4;
				case 279:
					num3 = 27;
					goto case 363;
				case 275:
					array4[0] = 96;
					num = 309;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 196;
				case 266:
					array[3] = 111;
					goto case 96;
				case 96:
					array[4] = 96;
					goto case 111;
				case 264:
					array[7] = (byte)num2;
					num = 117;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 338;
				case 257:
					array[15] = 62;
					goto case 330;
				case 228:
				case 255:
					if (num5 >= array7.Length)
					{
						num = 408;
						if (H59KTlwFXKjZctW3nxb())
						{
							continue;
						}
						goto case 130;
					}
					goto case 254;
				case 130:
					array4[8] = 112;
					goto case 279;
				case 254:
					array8[num5] = (byte)(array8[num5] ^ array7[num5]);
					goto case 31;
				case 31:
					num5++;
					num = 255;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 14;
				case 14:
					num2 = 147;
					goto case 199;
				case 199:
					array[29] = (byte)num2;
					goto case 93;
				case 93:
					array[29] = 229;
					num = 208;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 118;
				case 118:
					num8 = array8.Length / 4;
					goto case 178;
				case 178:
					num9 = 0u;
					goto case 106;
				case 106:
					num10 = 0u;
					goto case 200;
				case 252:
					array[12] = 245;
					goto case 407;
				case 241:
					array[25] = 111;
					num = 74;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 292;
				case 237:
					num2 = 172;
					goto case 88;
				case 88:
					array[29] = (byte)num2;
					goto case 206;
				case 206:
					array[29] = 134;
					num = 14;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 4;
				case 232:
					num2 = 172;
					num = 43;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 264;
				case 231:
					array[14] = 178;
					num = 340;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto IL_0648;
				case 226:
					num2 = 141;
					num = 195;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 173;
				case 225:
					array[16] = (byte)num2;
					num = 174;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 78;
				case 214:
					num3 = 22;
					num = 226;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 280;
				case 213:
					array[23] = 150;
					goto case 30;
				case 30:
					array[23] = 124;
					goto case 144;
				case 144:
					num2 = 164;
					num = 348;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 234;
				case 208:
					array[30] = 69;
					num = 2;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 2;
				case 2:
					array[30] = 114;
					goto case 165;
				case 165:
					array[30] = 126;
					num = 17;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 12;
				case 12:
					num2 = 140;
					goto case 172;
				case 172:
					array[28] = (byte)num2;
					goto case 187;
				case 187:
					array[28] = 76;
					num = 55;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 33;
				case 203:
					array4[5] = (byte)num3;
					goto case 37;
				case 201:
					array[0] = (byte)num2;
					num = 67;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 38;
				case 195:
					array[0] = (byte)num2;
					goto case 86;
				case 86:
					num2 = 160;
					num = 144;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 201;
				case 191:
					array[17] = 12;
					goto case 139;
				case 139:
					array[18] = 119;
					goto case 166;
				case 166:
					num2 = 184;
					num = 331;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 374;
				case 185:
					num2 = 137;
					num = 119;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 369;
				case 180:
					num2 = 112;
					num = 395;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 392;
				case 174:
					array[16] = 76;
					goto case 400;
				case 167:
					array[4] = (byte)num2;
					goto case 303;
				case 135:
					array[7] = (byte)num2;
					goto case 336;
				case 128:
					array[6] = (byte)num2;
					num = 121;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 193;
				case 123:
					num2 = 93;
					goto case 225;
				case 110:
					array[22] = 100;
					num = 7;
					if (EsddUWw56r20fv2j3fd() != null)
					{
						continue;
					}
					goto case 29;
				case 104:
					try
					{
						RHOIdBwO4wYjKY8ivTR(deflateStream, memoryStream);
						if (EsddUWw56r20fv2j3fd() == null)
						{
							switch (0)
							{
							}
						}
					}
					finally
					{
						int num4;
						if (deflateStream != null)
						{
							num4 = 1;
							if (!H59KTlwFXKjZctW3nxb())
							{
								goto IL_1c68;
							}
							goto IL_1c7b;
						}
						goto end_IL_1c57;
						IL_1c68:
						iqV5a4w8d3v3GaCmg2n(deflateStream);
						num4 = 0;
						if (EsddUWw56r20fv2j3fd() != null)
						{
							goto IL_1c7b;
						}
						goto end_IL_1c57;
						IL_1c7b:
						switch (num4)
						{
						case 1:
							break;
						default:
							goto end_IL_1c57;
						case 0:
							goto end_IL_1c57;
						}
						goto IL_1c68;
						end_IL_1c57:;
					}
					goto case 132;
				case 90:
					array[20] = (byte)num2;
					goto case 387;
				case 84:
					array[11] = 223;
					goto case 313;
				case 79:
					array[31] = (byte)num2;
					goto case 25;
				case 25:
					num2 = 111;
					num = 326;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 264;
				case 70:
					num3 = 219;
					goto case 11;
				case 11:
					array4[3] = (byte)num3;
					num = 321;
					if (H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 273;
				case 67:
					num2 = 162;
					num = 273;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 86;
				case 62:
					array4[4] = (byte)num3;
					goto case 383;
				case 56:
					num3 = 155;
					num = 62;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 11;
				case 55:
					array[29] = 91;
					goto case 237;
				case 48:
					num3 = 89;
					goto case 42;
				case 42:
					array4[0] = (byte)num3;
					goto case 275;
				case 35:
					array6 = new byte[array5.Length];
					num = 118;
					if (EsddUWw56r20fv2j3fd() == null)
					{
						continue;
					}
					goto case 56;
				case 24:
					array[6] = (byte)num2;
					goto case 185;
				case 22:
					array4 = new byte[16];
					goto case 48;
				case 17:
					num2 = 146;
					goto case 384;
				case 1:
					num2 = 101;
					num = 3;
					if (!H59KTlwFXKjZctW3nxb())
					{
						continue;
					}
					goto case 24;
				case 146:
					goto IL_2490;
				case 212:
					goto IL_24bc;
				case 256:
					goto IL_24c6;
				case 298:
					goto IL_24dd;
				case 245:
					goto IL_2515;
				case 131:
				case 150:
					CFW498MY6l = xfRQZSwrIJkmpGJgr2x(oDjDLbwhMngZdmmn2Jc(array2, 0u));
					goto case 314;
				case 405:
					CFW498MY6l = xfRQZSwrIJkmpGJgr2x(array2);
					goto case 314;
				case 314:
				case 361:
				case 373:
					Qew4GAeA7L = jb0ku2wIQyrOeKYI5nE((Assembly)CFW498MY6l);
					goto case 211;
				case 211:
					cH54oUOx7w = true;
					return;
				case 244:
				case 310:
					return;
				}
				break;
			}
			goto IL_0611;
			IL_097a:
			array = new byte[32];
			goto IL_0988;
			IL_0988:
			array[0] = 161;
			goto IL_0997;
			IL_0997:
			array[0] = 130;
			goto IL_09a6;
			IL_09a6:
			num2 = 98;
			goto IL_09ac;
			IL_09ac:
			array[0] = (byte)num2;
			num = 226;
			if (EsddUWw56r20fv2j3fd() != null)
			{
				goto IL_0786;
			}
			goto IL_1dde;
			IL_0786:
			array4[11] = 107;
			goto IL_0611;
			IL_0611:
			num3 = 167;
			goto IL_061a;
			IL_061a:
			array4[11] = (byte)num3;
			goto IL_0628;
			IL_0628:
			num3 = 106;
			goto IL_062e;
			IL_062e:
			array4[11] = (byte)num3;
			goto IL_063c;
			IL_063c:
			array4[11] = 85;
			goto IL_0648;
			IL_0648:
			num3 = 40;
			goto IL_064e;
			IL_064e:
			array4[11] = (byte)num3;
			num = 7;
			if (EsddUWw56r20fv2j3fd() == null)
			{
				goto IL_066c;
			}
			goto IL_1dde;
			IL_066c:
			num3 = 27;
			num = 24;
			if (H59KTlwFXKjZctW3nxb())
			{
				goto IL_0682;
			}
			goto IL_1dde;
			IL_0682:
			array4[11] = (byte)num3;
			goto IL_0690;
			IL_0690:
			array4[12] = 180;
			goto IL_069f;
			IL_069f:
			array4[12] = 108;
			goto IL_06ab;
			IL_06ab:
			array4[12] = 142;
			goto IL_06ba;
			IL_06ba:
			array4[12] = 96;
			goto IL_06c6;
			IL_06c6:
			array4[12] = 160;
			num = 214;
			if (EsddUWw56r20fv2j3fd() != null)
			{
				goto IL_06e5;
			}
			goto IL_1dde;
			IL_06e5:
			array4[4] = 88;
			goto IL_06f1;
			IL_06f1:
			num3 = 154;
			goto IL_06fa;
			IL_06fa:
			array4[5] = (byte)num3;
			goto IL_0708;
			IL_0708:
			array4[5] = 86;
			num = 223;
			if (!H59KTlwFXKjZctW3nxb())
			{
				goto IL_0724;
			}
			goto IL_1dde;
			IL_0724:
			array4[10] = 166;
			num = 53;
			if (!H59KTlwFXKjZctW3nxb())
			{
				goto IL_0743;
			}
			goto IL_1dde;
			IL_0743:
			array[1] = 92;
			goto IL_074f;
			IL_074f:
			array[1] = 119;
			goto IL_075b;
			IL_075b:
			array[1] = 20;
			goto IL_0767;
		}
	}

	internal static string[] ePX42YV5Fh(object object_0)
	{
		if ((Assembly?)object_0 == typeof(CftN3n4l13oJTY0dUlW).Assembly)
		{
			if (!cH54oUOx7w)
			{
				o5P4TSy5PK();
			}
			List<string> list = new List<string>();
			list.AddRange(((Assembly)object_0).GetManifestResourceNames());
			list.AddRange(((Assembly)CFW498MY6l).GetManifestResourceNames());
			return list.ToArray();
		}
		return ((Assembly)object_0).GetManifestResourceNames();
	}

	private static Assembly BJd40a7TwL(object object_0, object object_1)
	{
		if (!cH54oUOx7w)
		{
			o5P4TSy5PK();
		}
		string name = ((ResolveEventArgs)object_1).Name;
		int num = 0;
		while (true)
		{
			if (num < ((Array)Qew4GAeA7L).Length)
			{
				if ((string?)((object[])Qew4GAeA7L)[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)CFW498MY6l;
	}

	public CftN3n4l13oJTY0dUlW()
	{
		AppDomain.CurrentDomain.ResourceResolve += BJd40a7TwL;
		KvGQgW4hNlgjy7fkgCE.caI4bpmJ42();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!paf46FZ9As)
		{
			paf46FZ9As = true;
			new CftN3n4l13oJTY0dUlW();
		}
	}

	internal static Type pT7ACGwqnBd1LcpYqE1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object VElWukwNEXDLHIj37Cm(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object Te2WRAwED6aYMd94lcP(object object_0)
	{
		return ((U1OA9oWOyDJaui4H8n.YvSqsm4FEMQVAcAhE3h)object_0).m9OIO8Q0EK();
	}

	internal static void mvUpZswCowdmbUh56SN(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long s2PX1uwaSmxSYU5UuCY(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object bYKmNxwiYELSYZPSe7d(object object_0, int int_0)
	{
		return ((U1OA9oWOyDJaui4H8n.YvSqsm4FEMQVAcAhE3h)object_0).Udp45OEuiL(int_0);
	}

	internal static object xfRQZSwrIJkmpGJgr2x(object object_0)
	{
		return TBGGEf4MSo7FCofHlcS.dquB408ghG(object_0);
	}

	internal static void RHOIdBwO4wYjKY8ivTR(object object_0, object object_1)
	{
		((Stream)object_0).CopyTo((Stream)object_1);
	}

	internal static void iqV5a4w8d3v3GaCmg2n(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object EA1l3BwAjMiQg687J3L(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void iahwT6wQshgQ4kNhTwh(object object_0)
	{
		((Stream)object_0).Dispose();
	}

	internal static object oDjDLbwhMngZdmmn2Jc(object object_0, uint uint_0)
	{
		return TBGGEf4MSo7FCofHlcS.PY4BB3aDin(object_0, uint_0);
	}

	internal static object jb0ku2wIQyrOeKYI5nE(object object_0)
	{
		return ((Assembly)object_0).GetManifestResourceNames();
	}

	internal static bool H59KTlwFXKjZctW3nxb()
	{
		return (object)null == null;
	}

	internal static object EsddUWw56r20fv2j3fd()
	{
		return null;
	}
}
