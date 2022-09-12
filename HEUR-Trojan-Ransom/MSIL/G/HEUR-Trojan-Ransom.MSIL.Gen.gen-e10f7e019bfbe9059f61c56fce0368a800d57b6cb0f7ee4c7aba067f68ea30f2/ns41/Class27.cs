using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using ns38;
using ns39;
using ns40;

namespace ns41;

internal class Class27
{
	private enum Enum8
	{

	}

	internal class Class28
	{
		private unsafe static uint smethod_0(void* pVoid_0, uint uint_0)
		{
			return 0u;
		}

		private unsafe static bool smethod_1(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			return true;
		}

		private unsafe static void smethod_2(void* pVoid_0, byte byte_0, uint uint_0)
		{
		}

		private unsafe static void smethod_3(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
		}

		private unsafe static void smethod_4(byte* pByte_0, byte* pByte_1, uint uint_0)
		{
		}

		private static uint smethod_5(object object_0, uint uint_0, Enum8 enum8_0)
		{
			return 0u;
		}

		public static uint smethod_6(object object_0, uint uint_0)
		{
			return 0u;
		}

		private static uint smethod_7(object object_0, uint uint_0, object object_1)
		{
			return 0u;
		}

		internal static object smethod_8(object object_0)
		{
			return null;
		}

		public static byte[] smethod_9(object object_0, uint uint_0)
		{
			return null;
		}

		internal static uint smethod_10(object object_0, uint uint_0, Enum8 enum8_0)
		{
			return 0u;
		}

		internal static void smethod_11(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
		}

		internal static RuntimeTypeHandle smethod_12(int token)
		{
			return (RuntimeTypeHandle)(object)null;
		}

		internal static Type smethod_13(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return null;
		}

		internal static object smethod_14(int int_0)
		{
			return null;
		}

		internal static uint smethod_15(object object_0, uint uint_0)
		{
			return 0u;
		}

		internal static uint smethod_16(object object_0, uint uint_0, object object_1)
		{
			return 0u;
		}

		static Class28()
		{
			Class21.smethod_22();
		}
	}

	private static object object_0;

	private static object object_1;

	private static bool bool_0;

	private static bool bool_1;

	private static void smethod_0()
	{
		int num = 155;
		int num12 = default(int);
		int num19 = default(int);
		uint num20 = default(uint);
		int num13 = default(int);
		byte[] array2 = default(byte[]);
		int num7 = default(int);
		uint num27 = default(uint);
		byte[] array = default(byte[]);
		int num3 = default(int);
		byte[] array3 = default(byte[]);
		int num10 = default(int);
		int num9 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		uint num21 = default(uint);
		int num15 = default(int);
		uint num23 = default(uint);
		int num14 = default(int);
		int num30 = default(int);
		int num28 = default(int);
		uint num18 = default(uint);
		byte[] array7 = default(byte[]);
		int num29 = default(int);
		byte[] array6 = default(byte[]);
		uint num11 = default(uint);
		uint num8 = default(uint);
		DeflateStream deflateStream = default(DeflateStream);
		byte[] array4 = default(byte[]);
		int num25 = default(int);
		int num16 = default(int);
		int num22 = default(int);
		uint num4 = default(uint);
		byte[] array5 = default(byte[]);
		int num17 = default(int);
		byte[] array8 = default(byte[]);
		while (!bool_0)
		{
			while (true)
			{
				IL_25cc:
				Class21.Class24 object_ = new Class21.Class24((Stream)smethod_5(smethod_4(typeof(Class21).TypeHandle).Assembly, Class21.smethod_16(5607764)));
				int num2 = 114;
				if (smethod_17())
				{
					goto IL_0fe7;
				}
				goto IL_1f71;
				IL_1f71:
				while (true)
				{
					switch (num2)
					{
					case 18:
					case 403:
						if (num12 < num19)
						{
							goto case 350;
						}
						num2 = 355;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 350:
						if (num12 > 0)
						{
							goto case 402;
						}
						goto case 61;
					case 402:
						num20 <<= 8;
						goto case 257;
					case 257:
						num13 += 8;
						num2 = 61;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 61:
						array2[num7 + num12] = (byte)((num27 & num20) >> num13);
						num2 = 81;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 401:
						array[16] = (byte)num3;
						num2 = 313;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 400:
						array3[6] = 98;
						goto case 241;
					case 241:
						array3[6] = 75;
						num = 208;
						goto case 208;
					case 208:
						num10 = 123;
						num = 107;
						goto case 107;
					case 107:
						array3[6] = (byte)num10;
						goto case 226;
					case 226:
						num9 = 97;
						num2 = 328;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 399:
						array3[1] = (byte)num10;
						goto case 343;
					case 343:
						array3[1] = 125;
						goto case 223;
					case 223:
						array3[1] = 52;
						goto case 220;
					case 220:
						num9 = 145;
						goto case 146;
					case 146:
						array3[2] = (byte)num9;
						goto case 166;
					case 166:
						num10 = 148;
						goto case 48;
					case 48:
						array3[2] = (byte)num10;
						goto case 134;
					case 134:
						array3[2] = 169;
						num = 156;
						goto case 156;
					case 156:
						array3[3] = 112;
						goto case 314;
					case 314:
						array3[3] = 126;
						num2 = 192;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 398:
						object_1 = smethod_10(smethod_13(memoryStream));
						num2 = 6;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 397:
						num21 = 0u;
						goto case 234;
					case 234:
						if (num19 > 0)
						{
							goto case 87;
						}
						goto case 271;
					case 87:
						num15++;
						goto case 271;
					case 271:
						num23 = 0u;
						num = 299;
						goto case 299;
					case 299:
						num14 = 0;
						goto case 183;
					case 183:
					case 317:
						if (num14 >= num15)
						{
							num2 = 181;
							if (smethod_17())
							{
								continue;
							}
							goto IL_006d;
						}
						goto case 362;
					case 362:
						num30 = num14 % num28;
						goto case 221;
					case 221:
						num7 = num14 * 4;
						goto case 367;
					case 367:
						num23 = (uint)(num30 * 4);
						goto case 215;
					case 215:
						num18 = (uint)((array7[num23 + 3] << 24) | (array7[num23 + 2] << 16) | (array7[num23 + 1] << 8) | array7[num23]);
						goto case 282;
					case 282:
						num20 = 255u;
						num2 = 137;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 396:
						array[11] = (byte)num3;
						num2 = 185;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 395:
						array3[7] = 111;
						goto case 90;
					case 90:
						num9 = 152;
						goto case 56;
					case 56:
						array3[7] = (byte)num9;
						goto case 3;
					case 3:
						num10 = 163;
						goto case 358;
					case 358:
						array3[7] = (byte)num10;
						num2 = 252;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 394:
						array[6] = (byte)num3;
						goto case 256;
					case 256:
						array[6] = 225;
						num2 = 193;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 393:
						array3[8] = (byte)num9;
						num2 = 111;
						if (smethod_17())
						{
							continue;
						}
						goto case 101;
					case 101:
						array3[13] = (byte)num10;
						num2 = 153;
						if (smethod_17())
						{
							continue;
						}
						goto case 115;
					case 115:
						num3 = 147;
						num2 = 82;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 78;
					case 78:
						array[28] = 185;
						goto case 319;
					case 319:
						array[29] = 210;
						goto case 139;
					case 139:
						array[29] = 145;
						num2 = 168;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 392:
						array[18] = 44;
						num = 15;
						goto case 15;
					case 15:
						array[19] = 92;
						num2 = 174;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 391:
						array[30] = (byte)num3;
						goto case 290;
					case 290:
						num3 = 134;
						goto case 27;
					case 27:
						array[30] = (byte)num3;
						goto case 71;
					case 71:
						array[30] = 164;
						num2 = 246;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 138;
					case 138:
						array[21] = 114;
						goto case 191;
					case 191:
						array[21] = 97;
						goto case 320;
					case 320:
						array[21] = 116;
						goto case 261;
					case 261:
						array[21] = 202;
						goto case 132;
					case 132:
						array[22] = 164;
						goto case 75;
					case 75:
						array[22] = 92;
						goto case 159;
					case 159:
						array[22] = 134;
						num2 = 4;
						if (!smethod_17())
						{
							continue;
						}
						goto case 22;
					case 22:
						array[22] = 177;
						goto case 348;
					case 348:
						array[23] = 154;
						goto case 338;
					case 338:
						array[23] = 92;
						num2 = 108;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 73;
					case 73:
						array[12] = 115;
						goto case 278;
					case 278:
						array[13] = 136;
						num2 = 117;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 390:
						num3 = 127;
						goto case 129;
					case 129:
						array[26] = (byte)num3;
						num = 187;
						goto case 187;
					case 187:
						array[26] = 139;
						goto case 273;
					case 273:
						num3 = 130;
						goto case 201;
					case 201:
						array[26] = (byte)num3;
						num2 = 341;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 389:
						num3 = 150;
						goto case 110;
					case 110:
						array[27] = (byte)num3;
						num2 = 113;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 388:
						num29 = 0;
						num2 = 312;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 387:
						array[15] = 122;
						goto case 385;
					case 385:
						array[15] = 7;
						goto case 149;
					case 149:
						array[16] = 190;
						goto case 171;
					case 171:
						array[16] = 139;
						goto case 345;
					case 345:
						num3 = 112;
						goto case 194;
					case 194:
						array[16] = (byte)num3;
						num2 = 381;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 123:
					case 144:
					case 386:
						object_0 = smethod_16((Assembly)object_1);
						goto case 231;
					case 231:
						bool_0 = true;
						num2 = 92;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 12;
					case 12:
						array[5] = (byte)num3;
						goto case 281;
					case 281:
						num3 = 231;
						goto case 394;
					case 384:
						array[20] = (byte)num3;
						goto case 42;
					case 42:
						num3 = 97;
						goto case 288;
					case 288:
						array[21] = (byte)num3;
						goto case 138;
					case 383:
						array[28] = (byte)num3;
						goto case 135;
					case 135:
						num3 = 84;
						goto case 372;
					case 372:
						array[28] = (byte)num3;
						goto case 286;
					case 286:
						array[28] = 117;
						goto case 78;
					case 382:
						array3[6] = 125;
						goto case 400;
					case 381:
						array[16] = 104;
						goto case 143;
					case 143:
						num3 = 109;
						num2 = 146;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 401;
					case 380:
						array2 = new byte[array6.Length];
						num = 145;
						goto case 145;
					case 145:
						num28 = array7.Length / 4;
						num2 = 235;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 379:
						array[14] = 141;
						num = 53;
						goto case 53;
					case 53:
						num3 = 106;
						num2 = 202;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 35;
					case 35:
						num3 = 88;
						goto case 112;
					case 112:
						array[6] = (byte)num3;
						goto case 349;
					case 349:
						num3 = 85;
						goto case 44;
					case 44:
						array[6] = (byte)num3;
						num2 = 38;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 378:
						array[10] = (byte)num3;
						num2 = 302;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 377:
						num10 = 245;
						goto case 236;
					case 236:
						array3[9] = (byte)num10;
						goto case 34;
					case 34:
						array3[10] = 156;
						num2 = 70;
						if (!smethod_17())
						{
							continue;
						}
						goto case 184;
					case 184:
						num10 = 88;
						goto case 106;
					case 106:
						array3[10] = (byte)num10;
						num2 = 68;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 376:
						array3[3] = (byte)num9;
						num = 7;
						goto case 7;
					case 7:
						num9 = 212;
						goto case 80;
					case 80:
						array3[3] = (byte)num9;
						num2 = 199;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 47;
					case 47:
						array[6] = (byte)num3;
						num2 = 190;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 375:
						num3 = 19;
						num2 = 227;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 91;
					case 91:
						array[31] = 184;
						num = 77;
						goto case 77;
					case 77:
						num3 = 63;
						goto case 244;
					case 244:
						array[31] = (byte)num3;
						goto case 37;
					case 37:
						array7 = array;
						goto case 254;
					case 254:
						array3 = new byte[16];
						goto case 28;
					case 28:
						num9 = 134;
						goto case 255;
					case 255:
						array3[0] = (byte)num9;
						goto case 263;
					case 263:
						array3[0] = 27;
						num2 = 176;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 374:
						num10 = 110;
						goto case 330;
					case 330:
						array3[4] = (byte)num10;
						goto case 62;
					case 62:
						array3[4] = 104;
						goto case 140;
					case 140:
						num9 = 195;
						goto case 167;
					case 167:
						array3[4] = (byte)num9;
						num2 = 30;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 373:
						num9 = 115;
						num2 = 209;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 371:
						if (num19 > 0)
						{
							goto case 284;
						}
						goto case 337;
					case 284:
						num27 = num11 ^ num21;
						num = 368;
						goto case 368;
					case 368:
						num12 = 0;
						goto case 18;
					case 337:
						num8 = num11 ^ num21;
						goto case 163;
					case 163:
						array2[num7] = (byte)(num8 & 0xFFu);
						goto case 141;
					case 141:
						array2[num7 + 1] = (byte)((num8 & 0xFF00) >> 8);
						goto case 296;
					case 296:
						array2[num7 + 2] = (byte)((num8 & 0xFF0000) >> 16);
						num2 = 13;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 370:
						deflateStream = new DeflateStream(new MemoryStream(array4), CompressionMode.Decompress);
						goto case 196;
					case 196:
						try
						{
							smethod_11(deflateStream, memoryStream);
							int num24 = 0;
							if (!smethod_17())
							{
								num24 = num25;
							}
							switch (num24)
							{
							}
						}
						finally
						{
							if (deflateStream != null)
							{
								goto IL_09d7;
							}
							int num26 = 2;
							if (smethod_17())
							{
								goto IL_09c6;
							}
							goto end_IL_09b3;
							IL_09c6:
							switch (num26)
							{
							case 1:
							case 2:
								goto end_IL_09b3;
							}
							goto IL_09d7;
							IL_09d7:
							smethod_12(deflateStream);
							num26 = 1;
							if (smethod_18() == null)
							{
								goto IL_09c6;
							}
							end_IL_09b3:;
						}
						goto case 398;
					case 369:
						array3[0] = 206;
						num2 = 51;
						if (smethod_17())
						{
							continue;
						}
						break;
					case 8:
						break;
					case 204:
						goto IL_0a1c;
					case 11:
						goto IL_0a44;
					case 200:
					case 312:
						goto IL_0a4a;
					case 147:
						goto IL_0a52;
					case 79:
						goto IL_0a6e;
					case 214:
						goto IL_0a7b;
					case 366:
						array3[14] = 141;
						num2 = 334;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 365:
						array[4] = 146;
						num2 = 294;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 364:
						num16 = 1;
						goto case 388;
					case 363:
						array[27] = (byte)num3;
						num2 = 67;
						if (!smethod_17())
						{
							continue;
						}
						goto case 188;
					case 188:
						num3 = 148;
						goto case 383;
					case 361:
						array[1] = (byte)num3;
						goto case 19;
					case 19:
						num3 = 150;
						goto case 304;
					case 304:
						array[2] = (byte)num3;
						goto case 98;
					case 98:
						array[2] = 90;
						goto case 88;
					case 88:
						num3 = 194;
						num = 114;
						goto case 114;
					case 114:
						array[2] = (byte)num3;
						num = 315;
						goto case 315;
					case 315:
						array[3] = 126;
						num2 = 20;
						if (smethod_17())
						{
							continue;
						}
						goto case 12;
					case 360:
						num3 = 120;
						goto case 160;
					case 160:
						array[24] = (byte)num3;
						num = 268;
						goto case 268;
					case 268:
						num3 = 106;
						goto case 344;
					case 344:
						array[24] = (byte)num3;
						goto case 43;
					case 43:
						array[24] = 118;
						num2 = 232;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 359:
						array3[12] = 155;
						num2 = 260;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 357:
						array[9] = (byte)num3;
						num2 = 5;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 49;
					case 49:
						array[9] = 110;
						num2 = 47;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 104;
					case 104:
						num3 = 137;
						num2 = 378;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 356:
						num3 = 108;
						num2 = 64;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 152:
					case 355:
						num14++;
						goto case 183;
					case 354:
						array3[6] = 35;
						num2 = 382;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 353:
						array[3] = (byte)num3;
						goto case 242;
					case 242:
						num3 = 116;
						num2 = 1;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 352:
						array[10] = (byte)num3;
						num2 = 99;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 351:
						array[17] = (byte)num3;
						num2 = 0;
						if (!smethod_17())
						{
							continue;
						}
						goto default;
					default:
						array[17] = 153;
						goto case 94;
					case 94:
						num3 = 94;
						num2 = 297;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 271;
					case 347:
						num21 <<= 8;
						goto case 179;
					case 4:
						num22++;
						goto case 251;
					case 50:
						if (num22 > 0)
						{
							goto case 347;
						}
						goto case 179;
					case 179:
						num21 |= array6[^(1 + num22)];
						goto case 4;
					case 251:
					case 331:
						if (num22 < num19)
						{
							goto case 50;
						}
						goto case 165;
					case 165:
					case 291:
						num4 = num11;
						goto case 336;
					case 336:
						num11 = 255u;
						num2 = 5;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 346:
						object_1 = smethod_10(array4);
						num2 = 66;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 123;
					case 342:
						num3 = 168;
						goto case 357;
					case 341:
						array[26] = 162;
						goto case 323;
					case 323:
						array[26] = 165;
						goto case 10;
					case 10:
						num3 = 94;
						num2 = 22;
						if (!smethod_17())
						{
							continue;
						}
						goto case 31;
					case 31:
						array[27] = (byte)num3;
						goto case 41;
					case 41:
						array[27] = 220;
						goto case 389;
					case 340:
						array[12] = 47;
						goto case 224;
					case 224:
						array[12] = 121;
						num = 301;
						goto case 301;
					case 301:
						num3 = 107;
						goto case 172;
					case 172:
						array[12] = (byte)num3;
						num2 = 145;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 239;
					case 239:
						array[12] = 120;
						goto case 73;
					case 339:
						num9 = 215;
						goto case 21;
					case 21:
						array3[8] = (byte)num9;
						goto case 275;
					case 275:
						num9 = 32;
						goto case 205;
					case 205:
						array3[8] = (byte)num9;
						num2 = 173;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 335:
						array3[12] = 218;
						num2 = 23;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 334:
						num10 = 96;
						num2 = 211;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 333:
						array[0] = 127;
						goto case 16;
					case 16:
						array[0] = 211;
						goto case 39;
					case 39:
						array[0] = 145;
						goto case 170;
					case 170:
						num3 = 134;
						goto case 24;
					case 24:
						array[0] = (byte)num3;
						goto case 86;
					case 86:
						num3 = 77;
						num2 = 1;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 225;
					case 225:
						array[0] = (byte)num3;
						num2 = 62;
						if (!smethod_17())
						{
							continue;
						}
						goto case 292;
					case 292:
						num3 = 131;
						num = 157;
						goto case 157;
					case 157:
						array[1] = (byte)num3;
						goto case 277;
					case 277:
						array[1] = 119;
						goto case 120;
					case 120:
						num3 = 50;
						goto case 361;
					case 332:
						array[3] = 44;
						num2 = 262;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 44;
					case 329:
						array3[8] = (byte)num9;
						num2 = 212;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 328:
						array3[6] = (byte)num9;
						goto case 395;
					case 327:
						goto IL_0fe7;
					case 326:
						array[9] = (byte)num3;
						num2 = 342;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 325:
						array[5] = (byte)num3;
						num2 = 93;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 324:
						array[8] = 117;
						num2 = 258;
						if (smethod_17())
						{
							continue;
						}
						goto case 6;
					case 6:
						smethod_14(memoryStream);
						num2 = 123;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 322:
						num3 = 122;
						goto case 295;
					case 295:
						array[11] = (byte)num3;
						goto case 102;
					case 102:
						num3 = 100;
						goto case 9;
					case 9:
						array[11] = (byte)num3;
						num2 = 250;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 321:
						num10 = 113;
						goto case 216;
					case 216:
						array3[14] = (byte)num10;
						goto case 54;
					case 54:
						array3[14] = 16;
						goto case 230;
					case 230:
						num9 = 150;
						goto case 218;
					case 218:
						array3[15] = (byte)num9;
						num2 = 17;
						if (smethod_17())
						{
							continue;
						}
						goto case 3;
					case 318:
						if (num14 == num15 - 1)
						{
							goto case 126;
						}
						goto case 122;
					case 126:
						if (num19 > 0)
						{
							num2 = 33;
							if (smethod_17())
							{
								continue;
							}
							goto case 33;
						}
						goto case 122;
					case 33:
						num21 = 0u;
						goto case 66;
					case 66:
						num11 += num18;
						goto case 109;
					case 109:
						num22 = 0;
						num2 = 251;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 122:
						num23 = (uint)num7;
						goto case 305;
					case 305:
						num11 += num18;
						goto case 175;
					case 175:
						num21 = (uint)((array6[num23 + 3] << 24) | (array6[num23 + 2] << 16) | (array6[num23 + 1] << 8) | array6[num23]);
						goto case 165;
					case 316:
						num3 = 139;
						goto case 259;
					case 259:
						array[30] = (byte)num3;
						num2 = 158;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 313:
						array[16] = 184;
						goto case 63;
					case 63:
						num3 = 150;
						goto case 182;
					case 182:
						array[17] = (byte)num3;
						num2 = 150;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 311:
						array[0] = (byte)num3;
						num2 = 333;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 310:
						array3[11] = (byte)num9;
						goto case 95;
					case 95:
						num10 = 161;
						num = 287;
						goto case 287;
					case 287:
						array3[11] = (byte)num10;
						goto case 169;
					case 169:
						array3[11] = 172;
						goto case 76;
					case 76:
						num9 = 194;
						num2 = 280;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 309:
						array[7] = 162;
						goto case 119;
					case 119:
						array[7] = 54;
						goto case 14;
					case 14:
						array[8] = 122;
						goto case 324;
					case 308:
						num15 = array6.Length / 4;
						goto case 380;
					case 307:
						num3 = 108;
						goto case 89;
					case 89:
						array[5] = (byte)num3;
						num2 = 118;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 300;
					case 300:
						array[5] = 156;
						num2 = 303;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 306:
						array[31] = 154;
						num2 = 46;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 303:
						num3 = 59;
						goto case 325;
					case 302:
						array[10] = 119;
						goto case 52;
					case 52:
						num3 = 114;
						goto case 352;
					case 298:
						array[14] = 37;
						goto case 379;
					case 297:
						array[17] = (byte)num3;
						num2 = 65;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 22;
					case 294:
						array[4] = 235;
						goto case 307;
					case 293:
						array[5] = (byte)num3;
						goto case 105;
					case 105:
						array[5] = 124;
						num2 = 206;
						if (smethod_17())
						{
							continue;
						}
						goto case 146;
					case 289:
						array3[9] = 157;
						goto case 377;
					case 285:
						num9 = 63;
						goto case 265;
					case 265:
						array3[13] = (byte)num9;
						goto case 366;
					case 283:
						num3 = 72;
						num2 = 97;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 280:
						array3[11] = (byte)num9;
						goto case 359;
					case 217:
					case 279:
						goto IL_1400;
					case 276:
						array3[4] = (byte)num9;
						goto case 374;
					case 274:
						array[7] = (byte)num3;
						goto case 309;
					case 272:
						num3 = 187;
						num2 = 21;
						if (!smethod_17())
						{
							continue;
						}
						goto case 118;
					case 118:
						array[30] = (byte)num3;
						goto case 306;
					case 270:
						array3[13] = (byte)num10;
						num2 = 245;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 269:
						num9 = 158;
						goto case 310;
					case 267:
						array[30] = (byte)num3;
						goto case 272;
					case 266:
						array[13] = 134;
						goto case 178;
					case 178:
						array[14] = 34;
						num2 = 298;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 264:
						array[3] = (byte)num3;
						goto case 332;
					case 262:
						array[4] = 135;
						goto case 26;
					case 26:
						num3 = 176;
						num2 = 59;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 148;
					case 148:
						array[4] = (byte)num3;
						num2 = 365;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 260:
						array3[12] = 79;
						goto case 335;
					case 258:
						array[8] = 187;
						num2 = 195;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 253:
						array3[10] = (byte)num9;
						num2 = 269;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 252:
						num9 = 119;
						num2 = 164;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 250:
						num3 = 159;
						goto case 396;
					case 249:
						num3 = 136;
						num2 = 351;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 248:
						num3 = 195;
						num2 = 124;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 247:
						num3 = 119;
						goto case 57;
					case 57:
						array[25] = (byte)num3;
						goto case 2;
					case 2:
						array[25] = 160;
						num2 = 197;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 246:
						num3 = 71;
						goto case 267;
					case 245:
						num10 = 92;
						goto case 101;
					case 243:
						array[29] = 167;
						num2 = 316;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 240:
						array3[4] = (byte)num10;
						num2 = 343;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 373;
					case 238:
						array3[9] = 110;
						num2 = 289;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 237:
						goto IL_16ab;
					case 235:
						num11 = 0u;
						goto case 222;
					case 222:
						num18 = 0u;
						num2 = 397;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 232:
						array[24] = 30;
						num = 115;
						goto case 115;
					case 229:
						array = new byte[32];
						num2 = 228;
						if (smethod_17())
						{
							continue;
						}
						goto case 23;
					case 23:
						num9 = 192;
						num2 = 103;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 228:
						num3 = 68;
						goto case 311;
					case 227:
						array[14] = (byte)num3;
						goto case 203;
					case 203:
						array[15] = 124;
						num = 387;
						goto case 387;
					case 219:
						array3[15] = 84;
						goto case 136;
					case 136:
						array3[15] = 186;
						goto case 55;
					case 55:
						array5 = array3;
						num2 = 364;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 213:
						array3[5] = (byte)num9;
						goto case 210;
					case 210:
						num9 = 156;
						goto case 161;
					case 161:
						array3[5] = (byte)num9;
						num2 = 127;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 212:
						num9 = 123;
						num2 = 393;
						if (smethod_17())
						{
							continue;
						}
						goto case 335;
					case 211:
						array3[14] = (byte)num10;
						goto case 321;
					case 209:
						array3[4] = (byte)num9;
						goto case 186;
					case 186:
						num9 = 84;
						goto case 276;
					case 207:
						array[13] = (byte)num3;
						num2 = 266;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 206:
						num3 = 175;
						goto case 12;
					case 202:
						array[14] = (byte)num3;
						goto case 375;
					case 199:
						num10 = 234;
						num2 = 240;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 198:
						array[7] = (byte)num3;
						num2 = 70;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 41;
					case 197:
						array[25] = 48;
						goto case 85;
					case 85:
						array[26] = 164;
						goto case 390;
					case 195:
						num3 = 120;
						num2 = 170;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 326;
					case 193:
						num3 = 81;
						num2 = 46;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 47;
					case 192:
						num9 = 132;
						goto case 376;
					case 190:
						num3 = 154;
						goto case 116;
					case 116:
						array[6] = (byte)num3;
						goto case 35;
					case 189:
						array3[7] = 120;
						num2 = 60;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 185:
						array[11] = 118;
						num2 = 340;
						if (smethod_17())
						{
							continue;
						}
						goto IL_25cc;
					case 181:
						array4 = array2;
						goto case 121;
					case 121:
						num17 = num16;
						goto case 151;
					case 151:
						switch (num17)
						{
						case 0:
							break;
						default:
							goto IL_1400;
						case 1:
							goto IL_16ab;
						}
						goto case 346;
					case 180:
						if (num14 == num15 - 1)
						{
							num2 = 371;
							if (smethod_18() == null)
							{
								continue;
							}
							goto case 236;
						}
						goto case 337;
					case 177:
						num9 = 70;
						num = 162;
						goto case 162;
					case 162:
						array3[0] = (byte)num9;
						goto case 369;
					case 176:
						num9 = 87;
						num2 = 83;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 174:
						array[19] = 88;
						num2 = 25;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 173:
						num9 = 96;
						goto case 329;
					case 168:
						array[29] = 133;
						num2 = 142;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 164:
						array3[7] = (byte)num9;
						num2 = 189;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 158:
						num3 = 168;
						goto case 391;
					case 153:
						num10 = 51;
						num = 96;
						goto case 96;
					case 96:
						array3[13] = (byte)num10;
						goto case 125;
					case 125:
						num10 = 156;
						goto case 84;
					case 84:
						array3[13] = (byte)num10;
						goto case 285;
					case 150:
						num3 = 96;
						goto case 133;
					case 133:
						array[17] = (byte)num3;
						goto case 249;
					case 142:
						num3 = 90;
						goto case 67;
					case 67:
						array[29] = (byte)num3;
						num2 = 9;
						if (!smethod_17())
						{
							continue;
						}
						goto case 32;
					case 32:
						array[29] = 118;
						num2 = 243;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 137:
						num13 = 0;
						num2 = 318;
						if (smethod_17())
						{
							continue;
						}
						goto case 141;
					case 131:
						array3[5] = (byte)num10;
						goto case 354;
					case 130:
						num10 = 11;
						num2 = 30;
						if (!smethod_17())
						{
							continue;
						}
						goto case 270;
					case 128:
						array[18] = (byte)num3;
						goto case 392;
					case 127:
						num10 = 204;
						num2 = 131;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 103;
					case 103:
						array3[13] = (byte)num9;
						num2 = 130;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 124:
						array[20] = (byte)num3;
						goto case 283;
					case 117:
						num3 = 164;
						goto case 207;
					case 113:
						num3 = 137;
						num2 = 363;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 111:
						array3[9] = 55;
						goto case 238;
					case 108:
						array[23] = 232;
						num2 = 360;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_16ab;
					case 100:
						num3 = 196;
						num2 = 198;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 99:
						array[10] = 120;
						goto case 58;
					case 58:
						array[10] = 113;
						num = 322;
						goto case 322;
					case 97:
						array[20] = (byte)num3;
						num2 = 29;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 93:
						num3 = 78;
						goto case 293;
					case 83:
						array3[0] = (byte)num9;
						num = 177;
						goto case 177;
					case 82:
						array[24] = (byte)num3;
						goto case 356;
					case 81:
						num12++;
						num = 18;
						goto case 18;
					case 74:
						num3 = 156;
						num2 = 264;
						if (smethod_17())
						{
							continue;
						}
						goto IL_0a1c;
					case 72:
						array[20] = (byte)num3;
						num2 = 248;
						if (smethod_17())
						{
							continue;
						}
						goto case 235;
					case 70:
						num3 = 166;
						goto case 274;
					case 69:
						num11 = num4;
						goto case 180;
					case 68:
						num9 = 91;
						num2 = 253;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 65:
						array[18] = 129;
						num2 = 36;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 64:
						array[25] = (byte)num3;
						num2 = 247;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 60:
						array3[7] = 117;
						num2 = 59;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 59:
						array3[8] = 131;
						num2 = 339;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 51:
						num10 = 66;
						num2 = 264;
						if (smethod_18() != null)
						{
							continue;
						}
						goto case 399;
					case 46:
						array[31] = 102;
						num2 = 91;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 45:
						num3 = 154;
						goto case 128;
					case 40:
						num3 = 121;
						goto case 72;
					case 38:
						array[7] = 87;
						num = 100;
						goto case 100;
					case 36:
						array[18] = 122;
						num2 = 45;
						if (smethod_18() == null)
						{
							continue;
						}
						goto case 22;
					case 30:
						num9 = 116;
						num = 213;
						goto case 213;
					case 29:
						num3 = 29;
						num2 = 384;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 25:
						array[19] = 50;
						num2 = 40;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 20:
						num3 = 148;
						num2 = 353;
						if (smethod_18() == null)
						{
							continue;
						}
						goto IL_006d;
					case 17:
						array3[15] = 139;
						goto case 219;
					case 13:
						array2[num7 + 3] = (byte)((num8 & 0xFF000000u) >> 24);
						num2 = 152;
						if (smethod_17())
						{
							continue;
						}
						goto IL_006d;
					case 5:
					{
						uint num5 = num4;
						uint num6 = num4;
						num6 ^= num6 << 1;
						num6 += 386210582;
						num6 ^= num6 >> 27;
						num6 += 2785290990u;
						num6 ^= num6 << 27;
						num6 += 3921027779u;
						num6 = 593091361 - num6;
						num4 = num5 + (uint)(double)num6;
						goto case 69;
					}
					case 1:
						array[3] = (byte)num3;
						goto case 74;
					case 233:
						goto IL_25cc;
					case 155:
						goto end_IL_25cc;
					case 92:
					case 154:
						return;
						IL_16ab:
						memoryStream = new MemoryStream();
						goto case 370;
						IL_1400:
						object_1 = smethod_10(smethod_15(array4, 0u));
						goto case 123;
					}
					break;
				}
				goto IL_0a0b;
				IL_0fe7:
				smethod_7(smethod_6(object_), 0L);
				goto IL_0a0b;
				IL_0a0b:
				array4 = new byte[0];
				num = 204;
				goto IL_0a1c;
				IL_0a1c:
				array8 = (byte[])smethod_9(object_, (int)smethod_8(smethod_6(object_)));
				num2 = 229;
				if (!smethod_17())
				{
					goto IL_0a52;
				}
				goto IL_1f71;
				IL_0a52:
				array7[num29] = (byte)(array7[num29] ^ array5[num29]);
				goto IL_0a44;
				IL_0a44:
				num29++;
				goto IL_0a4a;
				IL_0a4a:
				if (num29 < array5.Length)
				{
					goto IL_0a52;
				}
				num = 79;
				goto IL_0a6e;
				IL_006d:
				num2 = num;
				goto IL_1f71;
				IL_0a6e:
				array6 = array8;
				num = 214;
				goto IL_0a7b;
				IL_0a7b:
				num19 = array6.Length % 4;
				num2 = 308;
				if (!smethod_17())
				{
					goto IL_006d;
				}
				goto IL_1f71;
				continue;
				end_IL_25cc:
				break;
			}
		}
		num = 154;
	}

	internal static string[] smethod_1(object object_2)
	{
		if ((Assembly?)object_2 == Type.GetTypeFromHandle(Class26.smethod_0(33554509)).Assembly)
		{
			if (!bool_0)
			{
				smethod_0();
			}
			List<string> list = new List<string>();
			list.AddRange(((Assembly)object_2).GetManifestResourceNames());
			list.AddRange(((Assembly)object_1).GetManifestResourceNames());
			return list.ToArray();
		}
		return ((Assembly)object_2).GetManifestResourceNames();
	}

	private static Assembly smethod_2(object object_2, object object_3)
	{
		if (!bool_0)
		{
			smethod_0();
		}
		string name = ((ResolveEventArgs)object_3).Name;
		int num = 0;
		while (true)
		{
			if (num < ((Array)object_0).Length)
			{
				if ((string?)((object[])object_0)[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)object_1;
	}

	public Class27()
	{
		AppDomain.CurrentDomain.ResourceResolve += smethod_2;
		Class25.smethod_0();
	}

	internal static void smethod_3()
	{
		if (!bool_1)
		{
			bool_1 = true;
			new Class27();
		}
	}

	static Class27()
	{
		object_0 = new string[0];
		object_1 = null;
		bool_0 = false;
		bool_1 = false;
	}

	internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object smethod_5(object object_2, object object_3)
	{
		return ((Assembly)object_2).GetManifestResourceStream((string)object_3);
	}

	internal static object smethod_6(object object_2)
	{
		return ((Class21.Class24)object_2).KDikMXewCI();
	}

	internal static void smethod_7(object object_2, long long_0)
	{
		((Stream)object_2).Position = long_0;
	}

	internal static long smethod_8(object object_2)
	{
		return ((Stream)object_2).Length;
	}

	internal static object smethod_9(object object_2, int int_0)
	{
		return ((Class21.Class24)object_2).method_0(int_0);
	}

	internal static object smethod_10(object object_2)
	{
		return Class28.smethod_8(object_2);
	}

	internal static void smethod_11(object object_2, object object_3)
	{
		((Stream)object_2).CopyTo((Stream)object_3);
	}

	internal static void smethod_12(object object_2)
	{
		((IDisposable)object_2).Dispose();
	}

	internal static object smethod_13(object object_2)
	{
		return ((MemoryStream)object_2).ToArray();
	}

	internal static void smethod_14(object object_2)
	{
		((Stream)object_2).Dispose();
	}

	internal static object smethod_15(object object_2, uint uint_0)
	{
		return Class28.smethod_9(object_2, uint_0);
	}

	internal static object smethod_16(object object_2)
	{
		return ((Assembly)object_2).GetManifestResourceNames();
	}

	internal static bool smethod_17()
	{
		return (object)null == null;
	}

	internal static object smethod_18()
	{
		return null;
	}
}
