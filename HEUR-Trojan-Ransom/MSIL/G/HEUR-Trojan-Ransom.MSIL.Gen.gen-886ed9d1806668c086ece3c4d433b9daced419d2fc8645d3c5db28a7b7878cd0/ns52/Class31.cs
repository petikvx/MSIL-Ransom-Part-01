using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using ns49;
using ns50;
using ns51;

namespace ns52;

internal class Class31
{
	private enum Enum10
	{

	}

	internal class Class32
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

		private static uint smethod_5(object object_0, uint uint_0, Enum10 enum10_0)
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

		internal static uint smethod_10(object object_0, uint uint_0, Enum10 enum10_0)
		{
			return 0u;
		}

		internal static void smethod_11(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
		}

		internal static Type smethod_12(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return null;
		}

		internal static object smethod_13(int int_0)
		{
			return null;
		}

		internal static object smethod_14(object object_0, object object_1, object object_2)
		{
			return null;
		}

		static Class32()
		{
			Class25.smethod_22();
		}
	}

	private static object object_0;

	private static object object_1;

	private static bool bool_0;

	private static bool bool_1;

	private static void smethod_0()
	{
		int num = 44;
		byte[] array5 = default(byte[]);
		byte[] array = default(byte[]);
		int num3 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num8 = default(int);
		int num6 = default(int);
		int num27 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		byte[] array7 = default(byte[]);
		int num29 = default(int);
		int num31 = default(int);
		int num11 = default(int);
		int num5 = default(int);
		int num17 = default(int);
		int num13 = default(int);
		int num9 = default(int);
		uint num24 = default(uint);
		uint num15 = default(uint);
		uint num21 = default(uint);
		int num22 = default(int);
		int num4 = default(int);
		uint num14 = default(uint);
		uint num7 = default(uint);
		int num23 = default(int);
		byte[] array2 = default(byte[]);
		uint num18 = default(uint);
		int num12 = default(int);
		int num10 = default(int);
		byte[] array8 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num20 = default(int);
		uint num19 = default(uint);
		byte[] array3 = default(byte[]);
		uint num16 = default(uint);
		while (!bool_0)
		{
			while (true)
			{
				Class25.Class28 object_ = new Class25.Class28((Stream)smethod_5(smethod_4(typeof(Class25).TypeHandle).Assembly, Class25.smethod_16(5692538)));
				while (true)
				{
					smethod_7(smethod_6(object_), 0L);
					int num2 = 256;
					if (smethod_18() != null)
					{
						goto IL_002d;
					}
					goto IL_1f28;
					IL_1f28:
					while (true)
					{
						switch (num2)
						{
						case 405:
							array5[2] = 144;
							num2 = 214;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 404:
							array[9] = (byte)num3;
							goto case 128;
						case 128:
							array[9] = 118;
							goto case 398;
						case 398:
							num3 = 209;
							goto case 292;
						case 292:
							array[9] = (byte)num3;
							goto case 91;
						case 91:
							array[10] = 112;
							num2 = 213;
							if (!smethod_17())
							{
								continue;
							}
							goto case 245;
						case 245:
							array[10] = 97;
							goto case 303;
						case 303:
							array[10] = 128;
							goto case 154;
						case 154:
							num3 = 20;
							num2 = 219;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 403:
							object_1 = smethod_10(smethod_13(memoryStream));
							num2 = 290;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 402:
							array[13] = (byte)num3;
							goto case 387;
						case 387:
							array[13] = 122;
							goto case 254;
						case 254:
							array[14] = 90;
							goto case 167;
						case 167:
							array[14] = 109;
							num2 = 31;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 401:
							array[28] = (byte)num3;
							goto case 12;
						case 12:
							num3 = 137;
							num = 400;
							goto case 400;
						case 400:
							array[28] = (byte)num3;
							goto case 105;
						case 105:
							array[29] = 122;
							goto case 80;
						case 80:
							array[29] = 214;
							goto case 314;
						case 314:
							num3 = 40;
							num2 = 115;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 399:
							array[23] = 177;
							goto case 35;
						case 35:
							num3 = 139;
							goto case 357;
						case 357:
							array[23] = (byte)num3;
							num2 = 327;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 397:
							num3 = 156;
							num = 284;
							goto case 284;
						case 284:
							array[4] = (byte)num3;
							num2 = 158;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 396:
							array = new byte[32];
							num2 = 329;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 395:
							array5[1] = 130;
							goto case 211;
						case 211:
							array5[1] = 166;
							goto case 341;
						case 341:
							array5[1] = 195;
							goto case 169;
						case 169:
							num8 = 153;
							num2 = 338;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 394:
							array[26] = 63;
							num = 157;
							goto case 157;
						case 157:
							array[26] = 102;
							goto case 119;
						case 119:
							array[27] = 119;
							num2 = 47;
							if (!smethod_17())
							{
								continue;
							}
							goto case 81;
						case 81:
							array[27] = 94;
							goto case 364;
						case 364:
							num3 = 120;
							num = 8;
							goto case 8;
						case 8:
							array[27] = (byte)num3;
							goto case 369;
						case 369:
							array[27] = 99;
							goto case 88;
						case 88:
							num3 = 67;
							goto case 259;
						case 259:
							array[28] = (byte)num3;
							goto case 306;
						case 306:
							num3 = 215;
							goto case 191;
						case 191:
							array[28] = (byte)num3;
							num2 = 286;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 393:
							array[21] = (byte)num3;
							num2 = 34;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 392:
							num8 = 141;
							num2 = 178;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 391:
							num3 = 114;
							goto case 70;
						case 70:
							array[18] = (byte)num3;
							goto case 87;
						case 87:
							num3 = 132;
							goto case 381;
						case 381:
							array[18] = (byte)num3;
							num2 = 187;
							if (smethod_18() == null)
							{
								continue;
							}
							goto case 88;
						case 390:
							num6 = 168;
							num2 = 324;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 389:
							array[2] = (byte)num3;
							num2 = 68;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 241;
						case 241:
							array[3] = 136;
							num2 = 333;
							if (smethod_17())
							{
								continue;
							}
							goto case 11;
						case 11:
							array[20] = 124;
							goto case 298;
						case 298:
							num3 = 224;
							goto case 145;
						case 145:
							array[20] = (byte)num3;
							goto case 54;
						case 54:
							array[20] = 109;
							goto case 134;
						case 134:
							num3 = 110;
							num2 = 215;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 388:
							switch (num27)
							{
							case 1:
								break;
							default:
								goto IL_25f1;
							case 0:
								goto IL_260e;
							}
							goto case 276;
						case 276:
							memoryStream = new MemoryStream();
							goto case 216;
						case 216:
							deflateStream = new DeflateStream(new MemoryStream(array7), CompressionMode.Decompress);
							num2 = 0;
							if (smethod_18() != null)
							{
								continue;
							}
							goto default;
						default:
							try
							{
								smethod_11(deflateStream, memoryStream);
								int num28 = 0;
								if (smethod_18() != null)
								{
									num28 = num29;
								}
								switch (num28)
								{
								}
							}
							finally
							{
								int num30;
								if (deflateStream != null)
								{
									num30 = 1;
									if (!smethod_17())
									{
										goto IL_04ca;
									}
									goto IL_04ce;
								}
								goto end_IL_04a3;
								IL_04ca:
								num30 = num31;
								goto IL_04ce;
								IL_04ce:
								while (true)
								{
									switch (num30)
									{
									case 1:
										break;
									default:
										goto end_IL_04ce;
									}
									smethod_12(deflateStream);
									num30 = 0;
									if (smethod_17())
									{
										continue;
									}
									goto IL_04ca;
									continue;
									end_IL_04ce:
									break;
								}
								end_IL_04a3:;
							}
							goto case 403;
						case 386:
							num3 = 87;
							num = 326;
							goto case 326;
						case 326:
							array[13] = (byte)num3;
							num2 = 363;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 385:
							array5[7] = 164;
							goto case 7;
						case 7:
							array5[8] = 95;
							num2 = 50;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 384:
							array5[2] = (byte)num6;
							num2 = 204;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 383:
							num11 = 0;
							num = 188;
							goto case 188;
						case 188:
						case 280:
							if (num11 >= num5)
							{
								num2 = 308;
								if (smethod_18() == null)
								{
									continue;
								}
								goto IL_002d;
							}
							goto case 72;
						case 72:
							num17 = num11 % num13;
							num2 = 83;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 382:
							array[5] = 103;
							num = 320;
							goto case 320;
						case 320:
							num3 = 165;
							goto case 281;
						case 281:
							array[5] = (byte)num3;
							num = 89;
							goto case 89;
						case 89:
							array[6] = 222;
							goto case 199;
						case 199:
							num3 = 91;
							num2 = 146;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 380:
							num27 = num9;
							goto case 388;
						case 379:
							array5[8] = 131;
							num = 42;
							goto case 42;
						case 42:
							num8 = 4;
							goto case 316;
						case 316:
							array5[8] = (byte)num8;
							goto case 189;
						case 189:
							array5[9] = 142;
							goto case 129;
						case 129:
							num6 = 113;
							goto case 73;
						case 73:
							array5[9] = (byte)num6;
							goto case 354;
						case 354:
							array5[9] = 253;
							goto case 111;
						case 111:
							num6 = 83;
							goto case 377;
						case 377:
							array5[10] = (byte)num6;
							goto case 321;
						case 321:
							array5[10] = 158;
							num2 = 152;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 378:
							array5[13] = (byte)num6;
							goto case 94;
						case 94:
							array5[13] = 178;
							num2 = 161;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 376:
							num15 = 255u;
							goto case 149;
						case 149:
						{
							uint num25 = num24;
							uint num26 = num24;
							num26 ^= num26 << 1;
							num26 += 4052235136u;
							num26 ^= num26 >> 27;
							num26 += 2298058292u;
							num26 ^= num26 << 27;
							num26 += 2374016581u;
							num26 = 3124738051u - num26;
							num24 = num25 + (uint)(double)num26;
							goto case 235;
						}
						case 235:
							num15 = num24;
							num2 = 213;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 375:
							num6 = 115;
							num = 29;
							goto case 29;
						case 29:
							array5[11] = (byte)num6;
							num2 = 16;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 374:
							array[31] = (byte)num3;
							num2 = 33;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 373:
							num21 = 255u;
							num2 = 23;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 116;
						case 116:
							num22 = 0;
							goto case 151;
						case 151:
							if (num11 == num5 - 1)
							{
								goto case 65;
							}
							goto case 270;
						case 65:
							if (num4 > 0)
							{
								goto case 79;
							}
							goto case 270;
						case 79:
							num14 = 0u;
							goto case 102;
						case 102:
							num15 += num7;
							num = 362;
							goto case 362;
						case 362:
							num23 = 0;
							goto case 222;
						case 59:
							if (num23 > 0)
							{
								num = 53;
								goto case 53;
							}
							goto case 247;
						case 53:
							num14 <<= 8;
							goto case 247;
						case 247:
							num14 |= array2[^(1 + num23)];
							goto case 150;
						case 150:
							num23++;
							num2 = 86;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 222;
						case 222:
						case 305:
							if (num23 >= num4)
							{
								num2 = 122;
								if (smethod_18() == null)
								{
									continue;
								}
								goto IL_002d;
							}
							goto case 59;
						case 270:
							num18 = (uint)num12;
							goto case 229;
						case 229:
							num15 += num7;
							num2 = 59;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 62;
						case 62:
							num14 = (uint)((array2[num18 + 3] << 24) | (array2[num18 + 2] << 16) | (array2[num18 + 1] << 8) | array2[num18]);
							goto case 122;
						case 122:
						case 353:
							num24 = num15;
							goto case 376;
						case 372:
							array5[6] = (byte)num8;
							goto case 272;
						case 272:
							num6 = 156;
							goto case 39;
						case 39:
							array5[6] = (byte)num6;
							goto case 208;
						case 208:
							num8 = 145;
							goto case 221;
						case 221:
							array5[6] = (byte)num8;
							goto case 390;
						case 371:
							array5[12] = 114;
							num2 = 210;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 370:
							array5[10] = (byte)num6;
							goto case 375;
						case 26:
						case 368:
							if (num10 >= array8.Length)
							{
								num2 = 24;
								if (smethod_17())
								{
									continue;
								}
								goto IL_002d;
							}
							goto case 127;
						case 127:
							array4[num10] = (byte)(array4[num10] ^ array8[num10]);
							num2 = 367;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 367:
							num10++;
							num2 = 26;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 366:
							array5[5] = (byte)num6;
							num2 = 174;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 365:
							array[25] = (byte)num3;
							goto case 226;
						case 226:
							array[25] = 39;
							num2 = 349;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 363:
							num3 = 153;
							num2 = 402;
							if (smethod_17())
							{
								continue;
							}
							goto case 284;
						case 361:
							array[16] = (byte)num3;
							num = 136;
							goto case 136;
						case 136:
							array[17] = 100;
							goto case 20;
						case 20:
							num3 = 84;
							num2 = 84;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 360:
							array6[num12 + num20] = (byte)((num19 & num21) >> num22);
							num = 289;
							goto case 289;
						case 289:
							num20++;
							goto case 121;
						case 228:
							if (num20 <= 0)
							{
								goto case 360;
							}
							goto case 143;
						case 121:
						case 319:
							if (num20 < num4)
							{
								goto case 228;
							}
							goto case 28;
						case 28:
						case 344:
							num11++;
							num2 = 280;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 143:
							num21 <<= 8;
							goto case 279;
						case 279:
							num22 += 8;
							num2 = 360;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 359:
							num3 = 27;
							goto case 25;
						case 25:
							array[15] = (byte)num3;
							num2 = 192;
							if (smethod_17())
							{
								continue;
							}
							goto case 169;
						case 358:
							num3 = 39;
							goto case 194;
						case 194:
							array[15] = (byte)num3;
							goto case 359;
						case 356:
							array[7] = 91;
							goto case 21;
						case 21:
							array[7] = 234;
							goto case 274;
						case 274:
							array[8] = 125;
							num2 = 118;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 355:
							num6 = 166;
							goto case 108;
						case 108:
							array5[0] = (byte)num6;
							goto case 185;
						case 185:
							array5[0] = 128;
							num2 = 173;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 352:
							array[1] = 219;
							goto case 257;
						case 257:
							num3 = 94;
							goto case 5;
						case 5:
							array[2] = (byte)num3;
							goto case 347;
						case 347:
							num3 = 115;
							goto case 99;
						case 99:
							array[2] = (byte)num3;
							goto case 117;
						case 117:
							num3 = 91;
							num2 = 318;
							if (smethod_17())
							{
								continue;
							}
							goto case 106;
						case 106:
							num8 = 98;
							num2 = 202;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 351:
							array[31] = 215;
							goto case 77;
						case 77:
							num3 = 141;
							num2 = 374;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 350:
							num3 = 140;
							goto case 207;
						case 207:
							array[11] = (byte)num3;
							num2 = 295;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 349:
							num3 = 127;
							goto case 137;
						case 137:
							array[25] = (byte)num3;
							num2 = 125;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 348:
							num8 = 112;
							num2 = 275;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 346:
							num8 = 110;
							goto case 126;
						case 126:
							array5[3] = (byte)num8;
							goto case 315;
						case 315:
							array5[3] = 123;
							goto case 313;
						case 313:
							num8 = 116;
							goto case 294;
						case 294:
							array5[4] = (byte)num8;
							goto case 112;
						case 112:
							array5[4] = 56;
							goto case 293;
						case 293:
							array5[4] = 80;
							goto case 106;
						case 343:
							num7 = (uint)((array4[num18 + 3] << 24) | (array4[num18 + 2] << 16) | (array4[num18 + 1] << 8) | array4[num18]);
							num2 = 373;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 342:
							num3 = 3;
							num2 = 361;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 340:
							array[6] = 50;
							num2 = 213;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 233;
						case 233:
							num3 = 96;
							num2 = 12;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 17;
						case 17:
							array[7] = (byte)num3;
							goto case 148;
						case 148:
							array[7] = 132;
							num = 288;
							goto case 288;
						case 288:
							array[7] = 124;
							num = 61;
							goto case 61;
						case 61:
							num3 = 94;
							num2 = 168;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 339:
							num3 = 251;
							num2 = 93;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 338:
							array5[1] = (byte)num8;
							goto case 68;
						case 68:
							num8 = 193;
							goto case 110;
						case 110:
							array5[1] = (byte)num8;
							goto case 76;
						case 76:
							num6 = 162;
							goto case 240;
						case 240:
							array5[2] = (byte)num6;
							num2 = 387;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 405;
						case 337:
							num3 = 55;
							goto case 132;
						case 132:
							array[6] = (byte)num3;
							num2 = 278;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 336:
							array3 = (byte[])smethod_9(object_, (int)smethod_8(smethod_6(object_)));
							goto case 396;
						case 335:
							array5[11] = (byte)num6;
							goto case 135;
						case 135:
							array5[11] = 166;
							num2 = 90;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 334:
							num3 = 110;
							goto case 37;
						case 37:
							array[1] = (byte)num3;
							num2 = 4;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 30;
						case 30:
							num3 = 49;
							goto case 45;
						case 45:
							array[1] = (byte)num3;
							goto case 352;
						case 333:
							num3 = 77;
							goto case 107;
						case 107:
							array[3] = (byte)num3;
							goto case 255;
						case 255:
							array[3] = 137;
							goto case 397;
						case 332:
							num3 = 124;
							num = 92;
							goto case 92;
						case 92:
							array[18] = (byte)num3;
							num2 = 1;
							if (smethod_17())
							{
								continue;
							}
							goto default;
						case 331:
							array5[0] = 2;
							num = 71;
							goto case 71;
						case 71:
							num8 = 84;
							num2 = 264;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 330:
							array6[num12 + 1] = (byte)((num16 & 0xFF00) >> 8);
							goto case 198;
						case 198:
							array6[num12 + 2] = (byte)((num16 & 0xFF0000) >> 16);
							goto case 277;
						case 277:
							array6[num12 + 3] = (byte)((num16 & 0xFF000000u) >> 24);
							goto case 28;
						case 329:
							array[0] = 164;
							goto case 159;
						case 159:
							array[0] = 129;
							goto case 69;
						case 69:
							array[0] = 103;
							goto case 248;
						case 248:
							num3 = 154;
							goto case 40;
						case 40:
							array[0] = (byte)num3;
							goto case 156;
						case 156:
							array[0] = 145;
							goto case 144;
						case 144:
							num3 = 210;
							num2 = 3;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 328:
							array[9] = (byte)num3;
							num2 = 307;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 327:
							array[23] = 146;
							num2 = 134;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 205;
						case 205:
							array[23] = 254;
							goto case 162;
						case 162:
							num3 = 121;
							goto case 164;
						case 164:
							array[24] = (byte)num3;
							num = 74;
							goto case 74;
						case 74:
							array[24] = 211;
							num2 = 183;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 325:
							array[6] = (byte)num3;
							goto case 340;
						case 324:
							array5[6] = (byte)num6;
							goto case 130;
						case 130:
							array5[7] = 204;
							goto case 311;
						case 311:
							array5[7] = 109;
							goto case 385;
						case 323:
							if (num4 > 0)
							{
								goto case 170;
							}
							goto case 249;
						case 170:
							num5++;
							goto case 249;
						case 249:
							num18 = 0u;
							goto case 383;
						case 322:
							num8 = 150;
							num2 = 56;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 318:
							array[2] = (byte)num3;
							num2 = 12;
							if (!smethod_17())
							{
								continue;
							}
							goto case 19;
						case 19:
							num3 = 60;
							num2 = 389;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 317:
							array[19] = (byte)num3;
							num2 = 20;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 52;
						case 52:
							array[19] = 206;
							num2 = 4;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 11;
						case 312:
							num3 = 166;
							goto case 401;
						case 310:
							array5[8] = (byte)num6;
							goto case 322;
						case 309:
							array5[14] = 177;
							num2 = 113;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 308:
							array7 = array6;
							num2 = 380;
							if (smethod_17())
							{
								continue;
							}
							goto case 22;
						case 22:
							num3 = 130;
							goto case 301;
						case 301:
							array[1] = (byte)num3;
							goto case 141;
						case 141:
							array[1] = 198;
							num2 = 334;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 307:
							num3 = 139;
							num2 = 390;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 404;
						case 304:
							array[5] = (byte)num3;
							num = 382;
							goto case 382;
						case 302:
							array[5] = (byte)num3;
							goto case 260;
						case 260:
							num3 = 67;
							num = 140;
							goto case 140;
						case 140:
							array[5] = (byte)num3;
							goto case 234;
						case 234:
							array[5] = 147;
							goto case 177;
						case 177:
							num3 = 103;
							goto case 304;
						case 300:
							array5[5] = (byte)num6;
							goto case 104;
						case 104:
							num8 = 19;
							num2 = 372;
							if (smethod_17())
							{
								continue;
							}
							goto case 309;
						case 299:
							array[9] = (byte)num3;
							num2 = 58;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 263;
						case 263:
							array[9] = 158;
							goto case 160;
						case 160:
							num3 = 135;
							num2 = 328;
							if (smethod_17())
							{
								continue;
							}
							goto case 170;
						case 297:
							array5[15] = (byte)num8;
							goto case 179;
						case 179:
							array8 = array5;
							num2 = 58;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 296:
							array[30] = 149;
							num2 = 48;
							if (!smethod_17())
							{
								continue;
							}
							goto case 218;
						case 218:
							num3 = 102;
							num = 120;
							goto case 120;
						case 120:
							array[30] = (byte)num3;
							num2 = 184;
							if (smethod_18() == null)
							{
								continue;
							}
							goto case 123;
						case 123:
							num8 = 164;
							goto case 201;
						case 201:
							array5[0] = (byte)num8;
							num2 = 331;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 295:
							array[11] = 164;
							num = 153;
							goto case 153;
						case 153:
							num3 = 25;
							num2 = 77;
							if (!smethod_17())
							{
								continue;
							}
							goto case 100;
						case 100:
							array[11] = (byte)num3;
							goto case 181;
						case 181:
							num3 = 140;
							goto case 51;
						case 51:
							array[12] = (byte)num3;
							num2 = 0;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 2;
						case 2:
							array[12] = 91;
							goto case 230;
						case 230:
							array[12] = 195;
							goto case 131;
						case 131:
							num3 = 123;
							goto case 138;
						case 138:
							array[12] = (byte)num3;
							num2 = 180;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 291:
							num3 = 83;
							num2 = 317;
							if (smethod_17())
							{
								continue;
							}
							goto IL_260e;
						case 287:
							num3 = 100;
							goto case 365;
						case 286:
							array[28] = 205;
							goto case 312;
						case 285:
							array[4] = 114;
							num2 = 4;
							if (smethod_17())
							{
								continue;
							}
							goto case 3;
						case 3:
							array[0] = (byte)num3;
							goto case 22;
						case 283:
							num8 = 207;
							num2 = 64;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 282:
							array5[5] = 91;
							goto case 86;
						case 86:
							num6 = 53;
							goto case 300;
						case 278:
							num3 = 39;
							goto case 325;
						case 275:
							array5[3] = (byte)num8;
							goto case 97;
						case 97:
							array5[3] = 208;
							goto case 346;
						case 273:
							num3 = 143;
							goto case 206;
						case 206:
							array[25] = (byte)num3;
							goto case 212;
						case 212:
							array[25] = 17;
							goto case 78;
						case 78:
							array[26] = 128;
							goto case 75;
						case 75:
							array[26] = 91;
							goto case 394;
						case 269:
							array5[14] = 122;
							num2 = 309;
							if (smethod_18() == null)
							{
								continue;
							}
							goto case 131;
						case 268:
							num8 = 136;
							goto case 124;
						case 124:
							array5[3] = (byte)num8;
							goto case 348;
						case 267:
							num3 = 199;
							goto case 265;
						case 265:
							array[24] = (byte)num3;
							num2 = 287;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 266:
							num3 = 112;
							num = 393;
							goto case 393;
						case 264:
							array5[1] = (byte)num8;
							num = 395;
							goto case 395;
						case 262:
							array5[0] = (byte)num6;
							num2 = 123;
							if (smethod_18() == null)
							{
								continue;
							}
							goto case 89;
						case 256:
							array7 = new byte[0];
							num2 = 336;
							if (smethod_17())
							{
								continue;
							}
							goto case 2;
						case 253:
							array[30] = (byte)num3;
							num2 = 209;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 252:
							array6[num12] = (byte)(num16 & 0xFFu);
							goto case 330;
						case 251:
							num3 = 138;
							goto case 23;
						case 23:
							array[18] = (byte)num3;
							num2 = 104;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 332;
						case 250:
							array[22] = (byte)num3;
							num = 225;
							goto case 225;
						case 225:
							array[22] = 236;
							goto case 399;
						case 246:
							array[16] = 134;
							goto case 96;
						case 96:
							array[16] = 143;
							num2 = 342;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 244:
							num19 = num15 ^ num14;
							num = 49;
							goto case 49;
						case 49:
							num20 = 0;
							goto case 121;
						case 243:
							array[24] = (byte)num3;
							goto case 242;
						case 242:
							num3 = 98;
							goto case 14;
						case 14:
							array[24] = (byte)num3;
							goto case 267;
						case 239:
							num3 = 107;
							num2 = 42;
							if (!smethod_17())
							{
								continue;
							}
							goto case 299;
						case 238:
							num15 = 0u;
							num2 = 55;
							if (smethod_18() == null)
							{
								continue;
							}
							goto case 39;
						case 237:
							array[4] = 201;
							goto case 236;
						case 236:
							array[4] = 120;
							num = 285;
							goto case 285;
						case 232:
							array5[15] = (byte)num8;
							goto case 172;
						case 172:
							num8 = 146;
							num = 63;
							goto case 63;
						case 63:
							array5[15] = (byte)num8;
							goto case 48;
						case 48:
							array5[15] = 88;
							goto case 392;
						case 231:
							array[15] = 84;
							num2 = 133;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 227:
							num3 = 177;
							num2 = 302;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 224:
							array6 = new byte[array2.Length];
							num2 = 142;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 223:
							array5[12] = (byte)num6;
							goto case 36;
						case 36:
							array5[12] = 114;
							goto case 101;
						case 101:
							array5[12] = 127;
							num = 46;
							goto case 46;
						case 46:
							array5[12] = 239;
							goto case 109;
						case 109:
							num6 = 45;
							num2 = 378;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 220:
							num18 = (uint)(num17 * 4);
							goto case 343;
						case 219:
							array[10] = (byte)num3;
							goto case 95;
						case 95:
							num3 = 114;
							goto case 163;
						case 163:
							array[11] = (byte)num3;
							num2 = 350;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 217:
							array[25] = (byte)num3;
							num2 = 273;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 215:
							array[20] = (byte)num3;
							num2 = 266;
							if (smethod_18() == null)
							{
								continue;
							}
							break;
						case 214:
							num6 = 127;
							goto case 384;
						case 213:
							if (num11 == num5 - 1)
							{
								num2 = 38;
								if (smethod_18() != null)
								{
									continue;
								}
								goto case 147;
							}
							goto case 193;
						case 147:
							if (num4 > 0)
							{
								goto case 244;
							}
							goto case 193;
						case 193:
							num16 = num15 ^ num14;
							goto case 252;
						case 210:
							num6 = 141;
							num2 = 223;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 209:
							array[30] = 169;
							num2 = 168;
							if (!smethod_17())
							{
								continue;
							}
							goto case 176;
						case 176:
							num3 = 102;
							num2 = 171;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 204:
							array5[3] = 105;
							num2 = 268;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 203:
							array5[11] = 174;
							goto case 371;
						case 202:
							array5[4] = (byte)num8;
							num2 = 139;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 200:
							array[18] = (byte)num3;
							num2 = 35;
							if (!smethod_17())
							{
								continue;
							}
							goto case 57;
						case 57:
							array[18] = 106;
							num2 = 391;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 197:
							num14 = 0u;
							num2 = 323;
							if (smethod_18() == null)
							{
								continue;
							}
							goto case 103;
						case 103:
							array5[14] = 108;
							num = 269;
							goto case 269;
						case 196:
							array5[11] = (byte)num6;
							num2 = 203;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 195:
							array[4] = (byte)num3;
							goto case 237;
						case 192:
							array[16] = 141;
							goto case 246;
						case 190:
							num8 = 165;
							num = 297;
							goto case 297;
						case 187:
							array[19] = 115;
							goto case 175;
						case 175:
							array[19] = 90;
							goto case 166;
						case 166:
							num3 = 155;
							goto case 98;
						case 98:
							array[19] = (byte)num3;
							num2 = 291;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 184:
							num3 = 130;
							goto case 253;
						case 183:
							num3 = 62;
							goto case 243;
						case 182:
							array[8] = 177;
							num2 = 239;
							if (smethod_18() == null)
							{
								continue;
							}
							goto case 193;
						case 180:
							num3 = 196;
							num = 18;
							goto case 18;
						case 18:
							array[13] = (byte)num3;
							goto case 386;
						case 178:
							array5[15] = (byte)num8;
							num = 190;
							goto case 190;
						case 174:
							array5[5] = 144;
							num = 282;
							goto case 282;
						case 173:
							num6 = 100;
							goto case 262;
						case 171:
							array[30] = (byte)num3;
							num2 = 351;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 168:
							array[7] = (byte)num3;
							goto case 356;
						case 165:
							num3 = 44;
							goto case 41;
						case 41:
							array[17] = (byte)num3;
							goto case 251;
						case 161:
							num6 = 82;
							goto case 155;
						case 155:
							array5[13] = (byte)num6;
							num2 = 283;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 158:
							num3 = 106;
							num2 = 195;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 152:
							num6 = 74;
							num2 = 370;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 146:
							array[6] = (byte)num3;
							num2 = 337;
							if (smethod_17())
							{
								continue;
							}
							goto case 168;
						case 142:
							num13 = array4.Length / 4;
							goto case 238;
						case 139:
							num6 = 142;
							num2 = 366;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 133:
							num3 = 144;
							goto case 85;
						case 85:
							array[15] = (byte)num3;
							goto case 358;
						case 125:
							num3 = 108;
							num2 = 217;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 118:
							array[8] = 104;
							num2 = 11;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 182;
						case 115:
							array[29] = (byte)num3;
							num2 = 296;
							if (smethod_17())
							{
								continue;
							}
							goto case 31;
						case 31:
							array[14] = 92;
							num2 = 231;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 113:
							array5[14] = 17;
							num2 = 66;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 93:
							array[21] = (byte)num3;
							goto case 67;
						case 67:
							array[22] = 159;
							goto case 60;
						case 60:
							num3 = 86;
							goto case 250;
						case 90:
							num6 = 134;
							num = 196;
							goto case 196;
						case 84:
							array[17] = (byte)num3;
							goto case 165;
						case 83:
							num12 = num11 * 4;
							goto case 220;
						case 66:
							num8 = 155;
							num2 = 99;
							if (!smethod_17())
							{
								continue;
							}
							goto case 232;
						case 64:
							array5[14] = (byte)num8;
							num2 = 33;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 103;
						case 58:
							num9 = 1;
							goto case 32;
						case 32:
							num10 = 0;
							goto case 26;
						case 56:
							array5[8] = (byte)num8;
							goto case 27;
						case 27:
							num8 = 94;
							goto case 9;
						case 9:
							array5[8] = (byte)num8;
							num = 379;
							goto case 379;
						case 55:
							num7 = 0u;
							num = 197;
							goto case 197;
						case 50:
							num6 = 149;
							goto case 310;
						case 47:
							array5 = new byte[16];
							num2 = 355;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 34:
							array[21] = 131;
							num2 = 339;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 33:
							array[31] = 134;
							goto case 10;
						case 10:
							array4 = array;
							num2 = 38;
							if (!smethod_17())
							{
								continue;
							}
							goto case 47;
						case 24:
							array2 = array3;
							num2 = 6;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 16:
							num6 = 104;
							num2 = 335;
							if (smethod_18() == null)
							{
								continue;
							}
							goto IL_002d;
						case 13:
							num5 = array2.Length / 4;
							goto case 224;
						case 6:
							num4 = array2.Length % 4;
							num2 = 13;
							if (smethod_17())
							{
								continue;
							}
							goto IL_002d;
						case 4:
							array[4] = 49;
							num = 227;
							goto case 227;
						case 1:
							num3 = 203;
							num2 = 145;
							if (smethod_18() != null)
							{
								continue;
							}
							goto case 200;
						case 114:
							break;
						case 43:
							goto end_IL_258b;
						case 44:
							goto end_IL_25b5;
						case 290:
							smethod_14(memoryStream);
							goto case 186;
						case 15:
						case 271:
							object_1 = smethod_10(smethod_15(array7, 0u));
							goto case 186;
						case 38:
							goto IL_260e;
						case 186:
						case 258:
						case 345:
							object_0 = smethod_16((Assembly)object_1);
							goto case 261;
						case 261:
							bool_0 = true;
							return;
						case 82:
							return;
							IL_260e:
							object_1 = smethod_10(array7);
							goto case 186;
							IL_25f1:
							num = 271;
							goto case 15;
						}
						break;
					}
					continue;
					IL_002d:
					num2 = num;
					goto IL_1f28;
					continue;
					end_IL_258b:
					break;
				}
				continue;
				end_IL_25b5:
				break;
			}
		}
	}

	internal static string[] smethod_1(object object_2)
	{
		if ((Assembly?)object_2 == Type.GetTypeFromHandle(Class30.smethod_0(33554523)).Assembly)
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

	public Class31()
	{
		AppDomain.CurrentDomain.ResourceResolve += smethod_2;
		Class29.smethod_0();
	}

	internal static void smethod_3()
	{
		if (!bool_1)
		{
			bool_1 = true;
			new Class31();
		}
	}

	static Class31()
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
		return ((Class25.Class28)object_2).KDikMXewCI();
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
		return ((Class25.Class28)object_2).method_0(int_0);
	}

	internal static object smethod_10(object object_2)
	{
		return Class32.smethod_8(object_2);
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
		return Class32.smethod_9(object_2, uint_0);
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
