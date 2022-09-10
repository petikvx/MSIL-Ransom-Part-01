using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using ns4;

namespace ns6;

[GAttribute0(56)]
internal class Class13
{
	[GAttribute0(57)]
	internal delegate uint Delegate8([MarshalAs(UnmanagedType.U8)] ref ulong classthis, IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.U4)] uint flags, ref IntPtr intptr_2, ref uint uint_0);

	private static object object_0;

	private static SortedList sortedList_0;

	private static byte[] byte_0;

	private static bool bool_0;

	private static byte[] byte_1;

	private static int int_0;

	private static long long_0;

	internal static Hashtable hashtable_0;

	internal static Delegate8 delegate8_0;

	private static long long_1;

	private static IntPtr intptr_0;

	private static byte[] byte_2;

	private static bool bool_1;

	private static IntPtr intptr_1;

	private static int[] int_1;

	private static byte[] byte_3;

	internal static Delegate8 delegate8_1;

	private static IntPtr intptr_2;

	private static int int_2;

	private static int int_3;

	private static bool bool_2;

	private static int int_4;

	static Class13()
	{
		byte_1 = new byte[0];
		byte_0 = new byte[0];
		byte_2 = new byte[0];
		byte_3 = new byte[0];
		intptr_0 = IntPtr.Zero;
		intptr_2 = IntPtr.Zero;
		object_0 = new string[0];
		int_1 = new int[0];
		int_3 = 1;
		bool_0 = false;
		sortedList_0 = new SortedList();
		int_4 = 0;
		long_0 = 0L;
		delegate8_0 = null;
		delegate8_1 = null;
		long_1 = 0L;
		int_0 = 0;
		bool_2 = false;
		bool_1 = false;
		int_2 = 0;
		intptr_1 = IntPtr.Zero;
		hashtable_0 = new Hashtable();
	}

	static bool smethod_0(int int_5)
	{
		int num = 31;
		int num5 = default(int);
		int num4 = default(int);
		byte[] array3 = default(byte[]);
		int num2 = default(int);
		int num3 = default(int);
		byte[] object_3 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		RijndaelManaged object_4 = default(RijndaelManaged);
		ICryptoTransform transform = default(ICryptoTransform);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream object_2 = default(CryptoStream);
		int num6 = default(int);
		while (true)
		{
			if (byte_0.Length == 0)
			{
				while (true)
				{
					BinaryReader object_ = new BinaryReader((Stream)smethod_26(smethod_25(typeof(Class13).TypeHandle).Assembly, "䱋䑂ㅥ湢㍕㥂乁剗猳䠮父㤸琰䝌佤䅳潍䕷"));
					num = 237;
					while (true)
					{
						smethod_28(smethod_27(object_), 0L);
						while (true)
						{
							smethod_29(bool_3: true);
							num = 317;
							while (true)
							{
								byte[] array = (byte[])smethod_31(object_, (int)smethod_30(smethod_27(object_)));
								num = 249;
								while (true)
								{
									IL_1f11:
									byte[] array2 = new byte[32];
									num = 47;
									if (smethod_44())
									{
										goto IL_18f0;
									}
									goto IL_1eed;
									IL_1eed:
									array2[10] = 124;
									num = 270;
									if (!smethod_44())
									{
										goto IL_000e;
									}
									goto IL_18f0;
									IL_18f0:
									while (true)
									{
										switch (num)
										{
										case 88:
											break;
										case 26:
											goto IL_001d;
										case 358:
											array2[15] = (byte)num5;
											num = 95;
											goto case 95;
										case 95:
											array2[15] = 236;
											goto case 43;
										case 43:
											num4 = 124;
											num = 163;
											goto case 163;
										case 163:
											array2[16] = (byte)num4;
											num = 132;
											if (smethod_44())
											{
												continue;
											}
											goto case 14;
										case 14:
											num5 = 57;
											num = 268;
											if (smethod_44())
											{
												continue;
											}
											goto case 97;
										case 97:
											array3[5] = (byte)num2;
											goto case 120;
										case 120:
											num2 = 146;
											goto case 238;
										case 238:
											array3[5] = (byte)num2;
											num = 338;
											goto case 338;
										case 338:
											array3[6] = 122;
											num = 59;
											goto case 59;
										case 59:
											num3 = 134;
											goto case 244;
										case 244:
											array3[6] = (byte)num3;
											num = 293;
											goto case 293;
										case 293:
											num2 = 50;
											num = 335;
											if (!smethod_44())
											{
												goto case 232;
											}
											goto case 335;
										case 232:
											array3 = new byte[16];
											num = 266;
											goto case 266;
										case 266:
											array3[0] = 150;
											goto case 91;
										case 91:
											array3[0] = 98;
											num = 144;
											goto case 144;
										case 144:
											num2 = 139;
											num = 81;
											goto case 81;
										case 81:
											array3[0] = (byte)num2;
											num = 185;
											goto case 185;
										case 185:
											array3[0] = 155;
											num = 297;
											goto case 297;
										case 297:
											array3[0] = 143;
											num = 224;
											if (!smethod_44())
											{
											}
											goto case 224;
										case 224:
											num2 = 103;
											num = 356;
											if (!smethod_45())
											{
												goto case 356;
											}
											goto case 83;
										case 356:
											array3[0] = (byte)num2;
											num = 67;
											goto case 67;
										case 67:
											array3[1] = 110;
											goto case 63;
										case 63:
											array3[1] = 68;
											num = 122;
											goto case 122;
										case 122:
											array3[1] = 52;
											num = 228;
											goto case 228;
										case 228:
											num2 = 137;
											num = 129;
											goto case 129;
										case 129:
											array3[2] = (byte)num2;
											num = 60;
											goto case 60;
										case 60:
											array3[2] = 44;
											goto case 204;
										case 106:
											array3[3] = 68;
											num = 326;
											if (!smethod_44())
											{
												goto case 262;
											}
											goto case 326;
										case 262:
											num3 = 110;
											goto case 83;
										case 83:
											array3[9] = (byte)num3;
											num = 257;
											goto case 257;
										case 257:
											array3[9] = 92;
											num = 280;
											if (!smethod_45())
											{
												goto case 280;
											}
											goto case 116;
										case 280:
											array3[9] = 4;
											num = 282;
											goto case 282;
										case 282:
											array3[10] = 134;
											num = 5;
											goto case 5;
										case 5:
											num3 = 97;
											num = 84;
											goto case 84;
										case 84:
											array3[10] = (byte)num3;
											num = 90;
											goto case 90;
										case 90:
											num2 = 142;
											goto case 121;
										case 121:
											array3[10] = (byte)num2;
											num = 254;
											if (!smethod_45())
											{
												continue;
											}
											goto case 23;
										case 23:
											num5 = 59;
											num = 93;
											if (!smethod_44())
											{
												goto case 340;
											}
											goto case 93;
										case 340:
											array2[28] = (byte)num5;
											num = 146;
											goto case 146;
										case 146:
											array2[28] = 96;
											goto case 193;
										case 193:
											num4 = 150;
											num = 127;
											goto case 127;
										case 127:
											array2[28] = (byte)num4;
											num = 302;
											goto case 302;
										case 302:
											array2[29] = 107;
											goto case 154;
										case 154:
											num5 = 104;
											num = 234;
											goto case 234;
										case 234:
											array2[29] = (byte)num5;
											num = 96;
											goto case 96;
										case 96:
											num4 = 105;
											num = 70;
											goto case 70;
										case 70:
											array2[29] = (byte)num4;
											goto case 252;
										case 252:
											num4 = 88;
											num = 316;
											goto case 316;
										case 316:
											array2[29] = (byte)num4;
											num = 296;
											goto case 296;
										case 93:
											array2[1] = (byte)num5;
											num = 166;
											goto case 166;
										case 166:
											array2[1] = 109;
											goto case 307;
										case 307:
											num4 = 88;
											goto case 170;
										case 170:
											array2[2] = (byte)num4;
											num = 173;
											goto case 173;
										case 173:
											array2[2] = 34;
											num = 211;
											goto case 211;
										case 211:
											num4 = 252;
											goto case 13;
										case 13:
											array2[2] = (byte)num4;
											num = 200;
											goto case 200;
										case 200:
											array2[3] = 152;
											goto case 62;
										case 62:
											array2[3] = 92;
											num = 196;
											if (!smethod_45())
											{
												continue;
											}
											goto case 296;
										case 296:
											num4 = 156;
											goto case 57;
										case 57:
											array2[29] = (byte)num4;
											goto case 145;
										case 145:
											array2[29] = 26;
											num = 203;
											goto case 203;
										case 203:
											array2[30] = 110;
											goto case 285;
										case 285:
											array2[30] = 95;
											num = 103;
											goto case 103;
										case 103:
											num4 = 116;
											num = 113;
											if (smethod_44())
											{
												goto case 113;
											}
											goto case 164;
										case 113:
											array2[30] = (byte)num4;
											num = 104;
											goto case 104;
										case 104:
											num4 = 105;
											num = 12;
											goto case 12;
										case 12:
											array2[30] = (byte)num4;
											num = 346;
											goto case 346;
										case 346:
											num5 = 190;
											goto case 333;
										case 333:
											array2[30] = (byte)num5;
											num = 247;
											goto case 247;
										case 247:
											num5 = 100;
											goto case 231;
										case 231:
											array2[31] = (byte)num5;
											goto case 263;
										case 263:
											array2[31] = 95;
											goto case 125;
										case 125:
											array2[31] = 158;
											goto case 349;
										case 349:
											array2[31] = 81;
											num = 152;
											goto case 152;
										case 152:
											array2[31] = 174;
											goto case 288;
										case 288:
											object_3 = array2;
											num = 232;
											goto case 232;
										case 204:
										case 239:
											array3[2] = 170;
											num = 106;
											goto case 106;
										case 116:
											array2[26] = (byte)num5;
											num = 243;
											goto case 243;
										case 243:
											num4 = 112;
											num = 298;
											if (smethod_44())
											{
												continue;
											}
											goto case 277;
										case 277:
											num5 = 86;
											goto case 275;
										case 326:
											num3 = 152;
											num = 327;
											goto case 327;
										case 327:
											array3[3] = (byte)num3;
											num = 180;
											goto case 180;
										case 180:
											num3 = 92;
											goto case 311;
										case 311:
											array3[3] = (byte)num3;
											goto case 300;
										case 300:
											array3[3] = 84;
											num = 151;
											goto case 151;
										case 151:
											array3[3] = 237;
											num = 240;
											goto case 240;
										case 240:
											num3 = 138;
											goto case 8;
										case 8:
											array3[4] = (byte)num3;
											num = 143;
											if (smethod_44())
											{
												continue;
											}
											goto case 71;
										case 335:
											array3[6] = (byte)num2;
											num = 49;
											goto case 49;
										case 49:
											num3 = 154;
											num = 177;
											goto case 177;
										case 177:
											array3[6] = (byte)num3;
											num = 85;
											goto case 85;
										case 85:
											array3[6] = 103;
											num = 7;
											if (!smethod_44())
											{
												goto IL_1f11;
											}
											goto case 7;
										case 7:
											num3 = 163;
											num = 164;
											goto case 164;
										case 164:
											array3[6] = (byte)num3;
											goto case 176;
										case 176:
											array3[7] = 85;
											num = 42;
											goto case 42;
										case 42:
											array3[7] = 145;
											goto case 233;
										case 233:
											array3[7] = 125;
											num = 25;
											goto case 25;
										case 25:
											array3[7] = 17;
											num = 171;
											goto case 171;
										case 171:
											array3[8] = 140;
											num = 188;
											goto case 188;
										case 188:
											array3[8] = 203;
											num = 75;
											goto case 75;
										case 75:
											num3 = 162;
											num = 64;
											if (smethod_44())
											{
												continue;
											}
											goto case 51;
										case 51:
											array2[20] = (byte)num5;
											num = 77;
											if (smethod_45())
											{
												goto case 275;
											}
											goto case 77;
										case 275:
											array2[18] = (byte)num5;
											goto case 157;
										case 157:
											num4 = 195;
											num = 3;
											goto case 3;
										case 3:
											array2[19] = (byte)num4;
											goto case 241;
										case 241:
											array2[19] = 196;
											num = 6;
											if (smethod_44())
											{
												continue;
											}
											goto case 199;
										case 77:
											num4 = 106;
											num = 351;
											goto case 351;
										case 351:
											array2[21] = (byte)num4;
											num = 309;
											goto case 309;
										case 309:
											num4 = 155;
											num = 178;
											goto case 178;
										case 178:
											array2[21] = (byte)num4;
											num = 73;
											goto case 73;
										case 73:
											num4 = 195;
											num = 76;
											goto case 76;
										case 76:
											array2[21] = (byte)num4;
											num = 34;
											goto case 34;
										case 34:
											array2[22] = 122;
											goto case 295;
										case 295:
											array2[22] = 115;
											num = 22;
											goto case 22;
										case 22:
											num4 = 101;
											num = 253;
											goto case 253;
										case 253:
											array2[22] = (byte)num4;
											num = 72;
											if (!smethod_45())
											{
												continue;
											}
											goto case 15;
										case 15:
											num5 = 160;
											goto case 140;
										case 140:
											array2[28] = (byte)num5;
											num = 354;
											if (smethod_44())
											{
												continue;
											}
											goto case 251;
										case 355:
											array2[8] = 128;
											num = 334;
											goto case 334;
										case 334:
											array2[8] = 149;
											num = 168;
											if (!smethod_44())
											{
												goto case 16;
											}
											goto case 168;
										case 16:
											num4 = 50;
											goto case 319;
										case 319:
											array2[6] = (byte)num4;
											num = 227;
											goto case 227;
										case 227:
											array2[6] = 135;
											num = 101;
											goto case 101;
										case 101:
											num4 = 117;
											goto case 344;
										case 344:
											array2[6] = (byte)num4;
											num = 260;
											if (smethod_44())
											{
												continue;
											}
											goto case 3;
										case 354:
											num5 = 102;
											num = 340;
											goto case 340;
										case 353:
											array2[0] = (byte)num4;
											num = 100;
											goto case 100;
										case 100:
											num5 = 29;
											num = 191;
											goto case 191;
										case 191:
											array2[0] = (byte)num5;
											goto case 264;
										case 264:
											array2[1] = 143;
											num = 86;
											goto case 86;
										case 86:
											num4 = 88;
											num = 336;
											goto case 336;
										case 336:
											array2[1] = (byte)num4;
											goto case 14;
										case 352:
											array3[12] = (byte)num3;
											goto case 107;
										case 107:
											array3[12] = 95;
											goto case 223;
										case 223:
											num3 = 48;
											num = 142;
											goto case 142;
										case 142:
											array3[12] = (byte)num3;
											goto case 294;
										case 294:
											num3 = 242;
											num = 20;
											goto case 20;
										case 20:
											array3[12] = (byte)num3;
											num = 345;
											goto case 345;
										case 345:
											num3 = 118;
											num = 213;
											if (smethod_44())
											{
												continue;
											}
											goto case 111;
										case 201:
											num4 = 222;
											num = 209;
											if (smethod_44())
											{
												goto case 209;
											}
											goto case 0;
										case 209:
											array2[13] = (byte)num4;
											goto case 156;
										case 156:
											num4 = 100;
											num = 108;
											if (smethod_44())
											{
												continue;
											}
											goto case 99;
										case 99:
											num2 = 95;
											num = 183;
											if (!smethod_45())
											{
												goto case 183;
											}
											goto case 179;
										case 183:
											array3[11] = (byte)num2;
											num = 310;
											goto case 310;
										case 310:
											num3 = 130;
											goto case 128;
										case 128:
											array3[12] = (byte)num3;
											num = 133;
											goto case 133;
										case 133:
											num3 = 92;
											goto case 352;
										case 111:
											array2[13] = 24;
											num = 201;
											if (smethod_44())
											{
												goto case 201;
											}
											goto case 108;
										case 108:
											array2[14] = (byte)num4;
											num = 273;
											goto case 273;
										case 273:
											array2[14] = 152;
											num = 186;
											goto case 186;
										case 186:
											num5 = 100;
											goto case 32;
										case 32:
											array2[14] = (byte)num5;
											goto case 214;
										case 214:
											array2[14] = 153;
											num = 301;
											if (smethod_45())
											{
												goto case 172;
											}
											goto case 301;
										case 172:
											array3[4] = 156;
											num = 256;
											goto case 256;
										case 256:
											num2 = 224;
											num = 198;
											goto case 198;
										case 198:
											array3[4] = (byte)num2;
											num = 87;
											goto case 87;
										case 87:
											num2 = 118;
											num = 206;
											goto case 206;
										case 206:
											array3[5] = (byte)num2;
											num = 2;
											if (!smethod_45())
											{
												continue;
											}
											goto case 279;
										case 301:
											array2[15] = 123;
											goto case 148;
										case 148:
											num5 = 143;
											num = 315;
											goto case 315;
										case 315:
											array2[15] = (byte)num5;
											num = 261;
											goto case 261;
										case 261:
											num4 = 186;
											num = 271;
											goto case 271;
										case 271:
											array2[15] = (byte)num4;
											num = 44;
											if (smethod_44())
											{
												continue;
											}
											goto case 284;
										case 284:
											array2[24] = (byte)num5;
											num = 174;
											goto case 174;
										case 174:
											array2[24] = 72;
											goto case 210;
										case 210:
											num4 = 115;
											num = 281;
											goto case 281;
										case 281:
											array2[25] = (byte)num4;
											num = 259;
											goto case 259;
										case 259:
											num4 = 106;
											num = 267;
											goto case 267;
										case 267:
											array2[25] = (byte)num4;
											goto case 202;
										case 202:
											num4 = 78;
											num = 337;
											goto case 337;
										case 337:
											array2[25] = (byte)num4;
											num = 320;
											goto case 320;
										case 320:
											array2[26] = 65;
											goto case 207;
										case 207:
											array2[26] = 91;
											num = 248;
											goto case 248;
										case 248:
											array2[26] = 106;
											num = 312;
											goto case 312;
										case 312:
											array2[26] = 93;
											num = 283;
											goto case 283;
										case 283:
											num5 = 185;
											num = 116;
											if (smethod_44())
											{
												continue;
											}
											goto case 101;
										case 350:
											num2 = 116;
											num = 105;
											goto case 105;
										case 105:
											array3[13] = (byte)num2;
											num = 219;
											goto case 219;
										case 219:
											num2 = 24;
											goto case 149;
										case 149:
											array3[13] = (byte)num2;
											num = 306;
											if (!smethod_45())
											{
												continue;
											}
											goto case 145;
										case 348:
											num4 = 97;
											goto case 299;
										case 299:
											array2[16] = (byte)num4;
											goto case 342;
										case 342:
											array2[16] = 114;
											num = 35;
											if (!smethod_44())
											{
												goto case 270;
											}
											goto case 35;
										case 270:
											array2[10] = 167;
											num = 197;
											goto case 197;
										case 197:
											array2[10] = 65;
											num = 10;
											if (!smethod_45())
											{
												continue;
											}
											goto case 324;
										case 324:
											array2[27] = (byte)num5;
											num = 15;
											goto case 15;
										case 35:
											array2[16] = 78;
											num = 181;
											if (!smethod_44())
											{
												goto case 87;
											}
											goto case 181;
										case 181:
											array2[16] = 91;
											goto case 117;
										case 117:
											num4 = 149;
											num = 308;
											goto case 308;
										case 308:
											array2[17] = (byte)num4;
											num = 153;
											goto case 153;
										case 153:
											array2[17] = 163;
											num = 229;
											goto case 229;
										case 229:
											num4 = 91;
											num = 37;
											if (smethod_45())
											{
												goto case 80;
											}
											goto case 37;
										case 80:
											array2[23] = (byte)num4;
											num = 328;
											goto case 328;
										case 328:
											num4 = 101;
											num = 139;
											goto case 139;
										case 139:
											array2[23] = (byte)num4;
											goto case 41;
										case 41:
											array2[23] = 54;
											num = 215;
											goto case 215;
										case 215:
											array2[24] = 99;
											num = 323;
											if (!smethod_44())
											{
												goto case 296;
											}
											goto case 323;
										case 323:
											array2[24] = 114;
											num = 162;
											goto case 162;
										case 162:
											num5 = 102;
											goto case 284;
										case 37:
											array2[17] = (byte)num4;
											goto case 205;
										case 205:
											array2[17] = 95;
											num = 290;
											goto case 290;
										case 290:
											num5 = 156;
											goto case 17;
										case 17:
											array2[17] = (byte)num5;
											goto case 36;
										case 36:
											array2[17] = 212;
											goto case 289;
										case 289:
											array2[18] = 136;
											num = 314;
											if (!smethod_44())
											{
												goto case 136;
											}
											goto case 314;
										case 136:
											num4 = 132;
											goto case 61;
										case 61:
											array2[13] = (byte)num4;
											num = 292;
											goto case 292;
										case 292:
											array2[13] = 166;
											num = 111;
											if (smethod_45())
											{
												goto case 295;
											}
											goto case 111;
										case 314:
											num5 = 227;
											num = 147;
											goto case 147;
										case 147:
											array2[18] = (byte)num5;
											num = 230;
											if (smethod_45())
											{
												goto case 334;
											}
											goto case 230;
										case 230:
											num5 = 126;
											num = 192;
											goto case 192;
										case 192:
											array2[18] = (byte)num5;
											num = 277;
											goto case 277;
										case 347:
											array2[11] = 150;
											num = 272;
											if (!smethod_44())
											{
												goto case 346;
											}
											goto case 272;
										case 272:
											num4 = 157;
											num = 189;
											goto case 189;
										case 189:
											array2[11] = (byte)num4;
											num = 65;
											goto case 65;
										case 65:
											array2[11] = 181;
											num = 184;
											goto case 184;
										case 184:
											num5 = 23;
											num = 94;
											goto case 94;
										case 94:
											array2[12] = (byte)num5;
											goto case 21;
										case 21:
											array2[12] = 149;
											goto case 46;
										case 46:
											num5 = 136;
											num = 169;
											goto case 169;
										case 169:
											array2[12] = (byte)num5;
											num = 313;
											goto case 313;
										case 313:
											array2[12] = 144;
											num = 250;
											if (!smethod_45())
											{
												continue;
											}
											goto case 260;
										case 260:
											array2[7] = 167;
											num = 245;
											goto case 245;
										case 245:
											array2[7] = 106;
											num = 11;
											goto case 11;
										case 11:
											num5 = 122;
											num = 18;
											if (!smethod_44())
											{
												goto case 301;
											}
											goto case 18;
										case 18:
											array2[7] = (byte)num5;
											num = 138;
											goto case 138;
										case 138:
											num4 = 158;
											num = 141;
											goto case 141;
										case 141:
											array2[7] = (byte)num4;
											num = 134;
											goto case 134;
										case 134:
											num4 = 113;
											smethod_45();
											if (!smethod_44())
											{
												num = 204;
												if (!smethod_44())
												{
													goto case 185;
												}
												goto case 204;
											}
											goto case 56;
										case 56:
										case 58:
											array2[7] = (byte)num4;
											num = 187;
											goto case 187;
										case 187:
											num5 = 148;
											num = 287;
											goto case 287;
										case 287:
											array2[8] = (byte)num5;
											num = 220;
											goto case 220;
										case 220:
											num5 = 155;
											num = 68;
											if (!smethod_45())
											{
												continue;
											}
											goto case 349;
										case 343:
											array2[23] = 144;
											goto case 226;
										case 226:
											num5 = 178;
											num = 269;
											goto case 269;
										case 269:
											array2[23] = (byte)num5;
											num = 305;
											goto case 305;
										case 305:
											num4 = 223;
											goto case 80;
										case 332:
											num5 = 98;
											num = 110;
											goto case 110;
										case 110:
											array2[20] = (byte)num5;
											goto case 158;
										case 158:
											num5 = 206;
											goto case 51;
										case 330:
											array2[4] = (byte)num4;
											num = 24;
											goto case 24;
										case 24:
											array2[5] = 66;
											goto case 79;
										case 79:
											array2[5] = 108;
											num = 321;
											goto case 321;
										case 321:
											array2[5] = 88;
											goto case 50;
										case 50:
											num4 = 144;
											num = 19;
											goto case 19;
										case 19:
											array2[5] = (byte)num4;
											num = 246;
											goto case 246;
										case 246:
											array2[5] = 164;
											num = 137;
											goto case 137;
										case 137:
											array2[5] = 156;
											goto case 16;
										case 329:
											array2[15] = (byte)num4;
											goto case 155;
										case 155:
											num5 = 236;
											num = 358;
											goto case 358;
										case 318:
											num3 = 98;
											num = 135;
											goto case 135;
										case 135:
											array3[11] = (byte)num3;
											num = 123;
											goto case 123;
										case 123:
											array3[11] = 71;
											num = 195;
											goto case 195;
										case 195:
											num3 = 93;
											goto case 4;
										case 4:
											array3[11] = (byte)num3;
											num = 99;
											goto case 99;
										case 303:
											num5 = 191;
											num = 258;
											goto case 258;
										case 258:
											array2[10] = (byte)num5;
											goto case 347;
										case 298:
											array2[27] = (byte)num4;
											num = 82;
											goto case 82;
										case 82:
											array2[27] = 135;
											num = 167;
											goto case 167;
										case 167:
											num5 = 4;
											goto case 324;
										case 291:
											num4 = 152;
											num = 55;
											goto case 55;
										case 55:
											array2[8] = (byte)num4;
											goto case 355;
										case 268:
											array2[1] = (byte)num5;
											num = 78;
											goto case 78;
										case 78:
											array2[1] = 96;
											num = 23;
											if (smethod_44())
											{
												goto case 23;
											}
											goto case 206;
										case 265:
											array2[3] = (byte)num5;
											num = 48;
											goto case 48;
										case 48:
											num5 = 151;
											num = 130;
											if (!smethod_45())
											{
												continue;
											}
											goto case 152;
										case 254:
											array3[10] = 88;
											num = 212;
											goto case 212;
										case 212:
											array3[11] = 124;
											goto case 318;
										case 250:
											num5 = 122;
											num = 160;
											goto case 160;
										case 160:
											array2[13] = (byte)num5;
											num = 221;
											goto case 221;
										case 221:
											array2[13] = 85;
											num = 136;
											if (!smethod_45())
											{
												goto case 136;
											}
											goto case 190;
										case 242:
											num3 = 77;
											num = 89;
											goto case 89;
										case 89:
											array3[9] = (byte)num3;
											num = 262;
											goto case 262;
										case 236:
											array2[3] = (byte)num4;
											num = 102;
											goto case 102;
										case 102:
											num4 = 96;
											num = 119;
											goto case 119;
										case 119:
											array2[4] = (byte)num4;
											num = 175;
											goto case 175;
										case 175:
											num5 = 80;
											num = 131;
											goto case 131;
										case 131:
											array2[4] = (byte)num5;
											num = 66;
											goto case 66;
										case 66:
											num4 = 39;
											num = 330;
											goto case 330;
										case 225:
											array3[9] = 140;
											num = 9;
											if (!smethod_44())
											{
												goto case 242;
											}
											goto case 9;
										case 9:
											array3[9] = 149;
											num = 242;
											if (!smethod_44())
											{
												goto case 34;
											}
											goto case 242;
										case 222:
											array3[4] = (byte)num3;
											goto case 172;
										case 216:
											array2[16] = (byte)num4;
											num = 348;
											if (!smethod_45())
											{
												continue;
											}
											goto case 187;
										case 213:
											array3[13] = (byte)num3;
											goto case 350;
										case 196:
											num5 = 84;
											num = 265;
											if (!smethod_44())
											{
												goto case 310;
											}
											goto case 265;
										case 150:
											array2[23] = 197;
											goto case 343;
										case 143:
											array3[4] = 96;
											goto case 33;
										case 33:
											num3 = 134;
											num = 222;
											goto case 222;
										case 132:
											num4 = 145;
											num = 216;
											goto case 216;
										case 130:
											array2[3] = (byte)num5;
											num = 126;
											goto case 126;
										case 126:
											num4 = 124;
											goto case 236;
										case 115:
											array2[20] = 136;
											num = 332;
											if (!smethod_45())
											{
												continue;
											}
											goto case 91;
										case 114:
											num4 = 101;
											num = 353;
											if (!smethod_45())
											{
												continue;
											}
											goto case 175;
										case 72:
											num4 = 33;
											num = 40;
											if (smethod_45())
											{
												goto case 292;
											}
											goto case 40;
										case 40:
											array2[22] = (byte)num4;
											num = 150;
											goto case 150;
										case 68:
											array2[8] = (byte)num5;
											num = 291;
											goto case 291;
										case 64:
											array3[8] = (byte)num3;
											num = 39;
											if (smethod_45())
											{
												goto case 244;
											}
											goto case 39;
										case 39:
											array3[8] = 129;
											num = 225;
											goto case 225;
										case 52:
											array2[20] = 114;
											num = 115;
											goto case 115;
										case 47:
											array2[0] = 134;
											num = 114;
											goto case 114;
										case 44:
											num4 = 88;
											num = 329;
											goto case 329;
										case 10:
											array2[10] = 99;
											goto case 303;
										case 6:
											array2[19] = 119;
											num = 52;
											if (smethod_44())
											{
												continue;
											}
											goto case 129;
										case 2:
											num2 = 156;
											num = 97;
											goto case 97;
										default:
											num = 202;
											goto case 202;
										case 168:
											num5 = 144;
											num = 71;
											goto case 71;
										case 71:
											array2[9] = (byte)num5;
											num = 278;
											goto case 278;
										case 278:
											array2[9] = 107;
											goto case 182;
										case 182:
											array2[9] = 9;
											num = 88;
											break;
										case 322:
											goto IL_1eed;
										case 249:
											goto IL_1f11;
										case 317:
											goto end_IL_1f11;
										case 339:
											goto end_IL_1f34;
										case 237:
											goto end_IL_1f55;
										case 98:
											goto end_IL_1f66;
										case 31:
											goto end_IL_1f7d;
										case 306:
											num2 = 136;
											num = 218;
											goto case 218;
										case 218:
											array3[14] = (byte)num2;
											num = 74;
											goto case 74;
										case 74:
											array3[14] = 140;
											num = 30;
											goto case 30;
										case 30:
											num3 = 18;
											goto case 304;
										case 304:
											array3[14] = (byte)num3;
											num = 45;
											goto case 45;
										case 45:
											array3[15] = 90;
											num = 357;
											goto case 357;
										case 357:
											num3 = 166;
											num = 235;
											goto case 235;
										case 235:
											array3[15] = (byte)num3;
											goto case 325;
										case 325:
											num2 = 143;
											goto case 255;
										case 255:
											array3[15] = (byte)num2;
											num = 118;
											goto case 118;
										case 118:
											num3 = 94;
											num = 69;
											goto case 69;
										case 69:
											array3[15] = (byte)num3;
											goto case 341;
										case 341:
											num2 = 34;
											goto case 286;
										case 286:
											array3[15] = (byte)num2;
											goto case 217;
										case 217:
											array4 = array3;
											num = 1;
											goto case 1;
										case 1:
											array5 = (byte[])smethod_33(smethod_32(smethod_25(typeof(Class13).TypeHandle).Assembly));
											goto case 28;
										case 28:
											if (array5 != null)
											{
												num = 54;
												goto case 54;
											}
											goto case 161;
										case 54:
											if (array5.Length > 0)
											{
												num = 274;
												goto case 274;
											}
											goto case 161;
										case 274:
											array4[1] = array5[0];
											goto case 179;
										case 179:
											array4[3] = array5[1];
											num = 27;
											goto case 27;
										case 27:
											array4[5] = array5[2];
											goto case 331;
										case 331:
											array4[7] = array5[3];
											num = 109;
											goto case 109;
										case 109:
											array4[9] = array5[4];
											goto case 0;
										case 0:
											array4[11] = array5[5];
											num = 199;
											goto case 199;
										case 199:
											array4[13] = array5[6];
											num = 190;
											goto case 190;
										case 190:
											array4[15] = array5[7];
											goto case 161;
										case 161:
											object_4 = new RijndaelManaged();
											num = 276;
											goto case 276;
										case 276:
											smethod_34(object_4, CipherMode.CBC);
											num = 92;
											goto case 92;
										case 92:
											transform = (ICryptoTransform)smethod_35(object_4, object_3, array4);
											num = 53;
											goto case 53;
										case 53:
											memoryStream = new MemoryStream();
											num = 112;
											goto case 112;
										case 112:
											object_2 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
											goto case 159;
										case 159:
											smethod_36(object_2, array, 0, array.Length);
											goto case 251;
										case 251:
											smethod_37(object_2);
											num = 279;
											goto case 279;
										case 279:
											byte_0 = (byte[])smethod_38(memoryStream);
											num = 194;
											goto case 194;
										case 194:
											smethod_39(memoryStream);
											num = 124;
											goto case 124;
										case 124:
											smethod_39(object_2);
											num = 165;
											goto case 165;
										case 165:
											smethod_40(object_);
											num = 38;
											goto IL_2202;
										case 38:
											goto IL_2202;
										case 29:
											goto IL_2214;
										case 208:
											goto IL_2237;
										case 359:
											goto end_IL_1fa8;
										}
										break;
									}
									goto IL_000e;
									IL_000e:
									num4 = 118;
									num = 26;
									goto IL_001d;
									IL_001d:
									array2[10] = (byte)num4;
									num = 322;
									goto IL_1eed;
									continue;
									end_IL_1f11:
									break;
								}
								continue;
								end_IL_1f34:
								break;
							}
							continue;
							end_IL_1f55:
							break;
						}
						continue;
						end_IL_1f66:
						break;
					}
					continue;
					end_IL_1f7d:
					break;
				}
				continue;
			}
			goto IL_2202;
			IL_2214:
			byte_1 = (byte[])smethod_42(smethod_41(smethod_25(typeof(Class13).TypeHandle).Assembly).ToString());
			goto IL_2237;
			IL_2202:
			if (byte_1.Length == 0)
			{
				num = 29;
				goto IL_2214;
			}
			goto IL_2237;
			IL_2237:
			num6 = 0;
			break;
			continue;
			end_IL_1fa8:
			break;
		}
		try
		{
			byte[] array6 = new byte[4];
			smethod_45();
			if (smethod_44())
			{
				array6[0] = byte_0[int_5];
				int num7 = 3;
				array6[1] = byte_0[int_5 + 1];
			}
			array6[2] = byte_0[int_5 + 2];
			do
			{
				array6[3] = byte_0[int_5 + 3];
				num6 = smethod_43(array6, 0);
				int num7 = 7;
			}
			while (smethod_45());
		}
		catch
		{
		}
		bool result = default(bool);
		try
		{
			if (byte_1[num6] == 128)
			{
				_ = 0;
				if (smethod_44())
				{
					int num8 = 2;
					result = true;
				}
				goto IL_22df;
			}
		}
		catch
		{
		}
		return false;
		IL_22df:
		return result;
	}

	static string smethod_1(int int_5)
	{
		int num = 216;
		int num2 = default(int);
		byte[] array3 = default(byte[]);
		int num3 = default(int);
		byte[] object_2 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		CryptoStream object_3 = default(CryptoStream);
		RijndaelManaged object_4 = default(RijndaelManaged);
		ICryptoTransform transform = default(ICryptoTransform);
		MemoryStream memoryStream = default(MemoryStream);
		int int_6 = default(int);
		while (true)
		{
			if (byte_2.Length == 0)
			{
				num = 124;
				while (true)
				{
					BinaryReader object_ = new BinaryReader((Stream)smethod_5(smethod_4(typeof(Class13).TypeHandle).Assembly, "儹坷眶䙉橡爱㑏楦刱爮捥桙㉹估䑹䍈癷公"));
					num = 270;
					while (true)
					{
						smethod_7(smethod_6(object_), 0L);
						num = 135;
						while (true)
						{
							smethod_8(bool_3: true);
							while (true)
							{
								byte[] array = (byte[])smethod_10(object_, (int)smethod_9(smethod_6(object_)));
								num = 151;
								while (true)
								{
									IL_21d9:
									byte[] array2 = new byte[32];
									num = 11;
									if (!smethod_23())
									{
										goto IL_0cfe;
									}
									goto IL_21ce;
									IL_21ce:
									num2 = 133;
									goto IL_21b5;
									IL_21b5:
									array2[0] = (byte)num2;
									num = 302;
									goto IL_21a1;
									IL_21a1:
									num2 = 142;
									num = 199;
									goto IL_2188;
									IL_2188:
									array2[0] = (byte)num2;
									num = 246;
									goto IL_2177;
									IL_2177:
									num2 = 88;
									num = 267;
									goto IL_2154;
									IL_2154:
									array2[0] = (byte)num2;
									num = 66;
									if (smethod_23())
									{
										goto IL_1add;
									}
									goto IL_2149;
									IL_2149:
									num2 = 152;
									goto IL_20ed;
									IL_20ed:
									array2[19] = (byte)num2;
									num = 213;
									goto IL_20cf;
									IL_20cf:
									num2 = 126;
									num = 209;
									if (smethod_24())
									{
										goto IL_001c;
									}
									goto IL_1add;
									IL_001c:
									num2 = 149;
									num = 281;
									goto IL_002e;
									IL_002e:
									array2[23] = (byte)num2;
									num = 77;
									goto IL_0045;
									IL_0045:
									array2[23] = 57;
									goto IL_0051;
									IL_0051:
									array2[23] = 132;
									num = 170;
									goto IL_0069;
									IL_0069:
									num2 = 191;
									goto IL_0072;
									IL_0072:
									array2[24] = (byte)num2;
									num = 260;
									if (smethod_23())
									{
										goto IL_0093;
									}
									goto IL_02ac;
									IL_02ac:
									array3[11] = (byte)num3;
									num = 162;
									goto IL_02c3;
									IL_02c3:
									num3 = 122;
									num = 317;
									goto IL_02d2;
									IL_02d2:
									array3[12] = (byte)num3;
									num = 176;
									goto IL_02e9;
									IL_02e9:
									num3 = 142;
									goto IL_02f2;
									IL_02f2:
									array3[12] = (byte)num3;
									num = 226;
									goto IL_0309;
									IL_0309:
									num3 = 174;
									goto IL_0312;
									IL_0312:
									array3[12] = (byte)num3;
									num = 133;
									if (!smethod_24())
									{
										goto IL_0333;
									}
									goto IL_1406;
									IL_1406:
									array3 = new byte[16];
									num = 299;
									if (smethod_24())
									{
										goto IL_1231;
									}
									goto IL_1add;
									IL_1231:
									array3[9] = (byte)num3;
									goto IL_0f83;
									IL_0f83:
									array3[9] = 106;
									num = 189;
									goto IL_0f98;
									IL_0f98:
									array3[9] = 73;
									goto IL_0fa4;
									IL_0fa4:
									array3[9] = 147;
									num = 205;
									goto IL_0fbc;
									IL_0fbc:
									array3[9] = 132;
									num = 153;
									goto IL_0fd4;
									IL_0fd4:
									num3 = 106;
									num = 202;
									if (smethod_24())
									{
										goto IL_0fed;
									}
									goto IL_10ac;
									IL_10ac:
									array3[10] = (byte)num3;
									num = 279;
									goto IL_10c3;
									IL_10c3:
									array3[10] = 135;
									num = 167;
									goto IL_10db;
									IL_10db:
									num3 = 173;
									num = 5;
									goto IL_10ed;
									IL_10ed:
									array3[10] = (byte)num3;
									goto IL_10fb;
									IL_10fb:
									num3 = 72;
									num = 26;
									if (!smethod_23())
									{
										goto IL_1114;
									}
									goto IL_1add;
									IL_1add:
									while (true)
									{
										switch (num)
										{
										case 131:
											break;
										case 281:
											goto IL_002e;
										case 77:
											goto IL_0045;
										case 191:
											goto IL_0051;
										case 170:
											goto IL_0069;
										case 65:
											goto IL_0072;
										case 260:
											goto IL_0093;
										case 333:
											goto IL_00a8;
										case 96:
											goto IL_00bd;
										case 296:
											goto IL_00c6;
										case 37:
											goto IL_00e7;
										case 228:
											goto IL_00f6;
										case 223:
											goto IL_010d;
										case 165:
											goto IL_0113;
										case 106:
											goto IL_012a;
										case 359:
											goto IL_0136;
										case 83:
											goto IL_0145;
										case 112:
											goto IL_0161;
										case 219:
											goto IL_0173;
										case 44:
											goto IL_0181;
										case 182:
											goto IL_0187;
										case 360:
											goto IL_0195;
										case 327:
											goto IL_01a7;
										case 201:
											goto IL_01c8;
										case 129:
											goto IL_01d4;
										case 9:
											goto IL_01e3;
										case 18:
											goto IL_01fa;
										case 300:
											goto IL_0200;
										case 126:
											goto IL_0217;
										case 211:
											goto IL_0226;
										case 358:
											goto IL_0247;
										case 295:
											goto IL_0256;
										case 148:
											goto IL_026d;
										case 290:
											goto IL_0282;
										case 340:
											goto IL_029a;
										case 160:
											goto IL_02a6;
										case 67:
											goto IL_02ac;
										case 162:
											goto IL_02c3;
										case 317:
											goto IL_02d2;
										case 176:
											goto IL_02e9;
										case 196:
											goto IL_02f2;
										case 226:
											goto IL_0309;
										case 273:
											goto IL_0312;
										case 133:
											goto IL_0333;
										case 110:
											goto IL_0348;
										case 3:
											goto IL_0364;
										case 370:
											goto IL_0372;
										case 222:
											goto IL_0387;
										case 318:
											goto IL_0390;
										case 98:
											goto IL_039e;
										case 274:
											goto IL_03b6;
										case 81:
											goto IL_03cb;
										case 119:
											goto IL_03ea;
										case 256:
											goto IL_03f8;
										case 76:
											goto IL_0407;
										case 48:
											goto IL_0423;
										case 53:
											goto IL_043c;
										case 251:
											goto IL_044a;
										case 212:
											goto IL_0450;
										case 278:
											goto IL_045e;
										case 311:
											goto IL_0473;
										case 36:
											goto IL_047f;
										case 331:
											goto IL_0488;
										case 314:
											goto IL_049f;
										case 121:
											goto IL_04ae;
										case 46:
											goto IL_04b4;
										case 233:
											goto IL_04cb;
										case 375:
											array3[3] = 189;
											num = 137;
											goto case 137;
										case 137:
											array3[3] = 156;
											goto case 138;
										case 138:
											array3[3] = 96;
											goto IL_0ae7;
										case 214:
											goto IL_0521;
										case 339:
											goto IL_052a;
										case 372:
											goto IL_054b;
										case 354:
											goto IL_0560;
										case 66:
											goto IL_057c;
										case 234:
											goto IL_0588;
										case 252:
											goto IL_05a4;
										case 348:
											goto IL_05bb;
										case 230:
											goto IL_05ca;
										case 310:
											goto IL_05d8;
										case 140:
											goto IL_05f4;
										case 277:
											goto IL_060b;
										case 104:
											goto IL_061a;
										case 258:
											goto IL_0631;
										case 146:
											goto IL_0653;
										case 264:
											goto IL_066a;
										case 353:
											goto IL_067c;
										case 174:
											goto IL_0698;
										case 14:
											goto IL_06af;
										case 263:
											goto IL_06c1;
										case 297:
											goto IL_06d8;
										case 179:
											goto IL_06e7;
										case 217:
											goto IL_06f5;
										case 342:
											goto IL_0704;
										case 69:
											goto IL_071b;
										case 254:
											goto IL_0721;
										case 89:
											goto IL_0738;
										case 49:
											goto IL_0747;
										case 245:
											goto IL_075e;
										case 82:
											goto IL_0764;
										case 143:
											goto IL_0772;
										case 236:
											goto IL_0778;
										case 108:
											goto IL_079c;
										case 334:
											goto IL_07ac;
										case 240:
											goto IL_07c9;
										case 324:
											goto IL_07e1;
										case 229:
											goto IL_07f6;
										case 352:
											goto IL_0802;
										case 186:
											goto IL_0817;
										case 194:
											goto IL_0826;
										case 272:
											goto IL_083b;
										case 87:
											goto IL_0850;
										case 350:
											goto IL_0856;
										case 113:
											goto IL_0864;
										case 326:
											goto IL_087d;
										case 215:
											goto IL_0892;
										case 71:
											goto IL_08a1;
										case 111:
											goto IL_08b8;
										case 102:
											goto IL_08da;
										case 335:
											goto IL_08fb;
										case 63:
											goto IL_0912;
										case 239:
											goto IL_092a;
										case 203:
											goto IL_0939;
										case 356:
											goto IL_0947;
										case 85:
											goto IL_094d;
										case 161:
											goto IL_0964;
										case 59:
											goto IL_096d;
										case 368:
											goto IL_0984;
										case 10:
											goto IL_0996;
										case 195:
											goto IL_09ad;
										case 31:
											goto IL_09bf;
										case 319:
											goto IL_09e5;
										case 12:
											goto IL_09f4;
										case 118:
											goto IL_0a0d;
										case 40:
											goto IL_0a24;
										case 184:
											goto IL_0a30;
										case 128:
											goto IL_0a3f;
										case 286:
											goto IL_0a4d;
										case 265:
											goto IL_0a5c;
										case 123:
											goto IL_0a73;
										case 122:
											goto IL_0a85;
										case 198:
											goto IL_0a93;
										case 171:
											goto IL_0aa8;
										case 188:
											goto IL_0aae;
										case 185:
											goto IL_0ac5;
										case 28:
											goto IL_0ae7;
										case 130:
											goto IL_0afb;
										case 8:
											goto IL_0b03;
										case 221:
											goto IL_0b19;
										case 172:
											goto IL_0b3f;
										case 150:
											goto IL_0b61;
										case 284:
											goto IL_0b79;
										case 32:
											goto IL_0b8b;
										case 192:
											goto IL_0ba2;
										case 345:
											goto IL_0bba;
										case 70:
											goto IL_0bc6;
										case 305:
											goto IL_0bdb;
										case 103:
											goto IL_0be7;
										case 58:
											goto IL_0bff;
										case 38:
											goto IL_0c14;
										case 193:
											goto IL_0c1a;
										case 64:
											goto IL_0c28;
										case 17:
											goto IL_0c3d;
										case 206:
											goto IL_0c52;
										case 178:
											goto IL_0c67;
										case 25:
											goto IL_0c7f;
										case 231:
											goto IL_0c8e;
										case 285:
											goto IL_0ca4;
										case 346:
											goto IL_0cb5;
										case 149:
											goto IL_0cc6;
										case 93:
											goto IL_0ce7;
										case 109:
											goto IL_0cfe;
										case 7:
											goto IL_0d13;
										case 62:
											goto IL_0d25;
										case 90:
											goto IL_0d3c;
										case 52:
											goto IL_0d4b;
										case 309:
											goto IL_0d62;
										case 365:
											goto IL_0d77;
										case 361:
											goto IL_0d91;
										case 92:
											goto IL_0da8;
										case 336:
											goto IL_0db4;
										case 341:
											goto IL_0dc3;
										case 42:
											goto IL_0dda;
										case 282:
											goto IL_0de9;
										case 227:
											goto IL_0def;
										case 56:
											goto IL_0dfd;
										case 22:
											goto IL_0e06;
										case 114:
											goto IL_0e1d;
										case 220:
											goto IL_0e2f;
										case 20:
											goto IL_0e3d;
										case 306:
											goto IL_0e55;
										case 57:
											goto IL_0e71;
										case 374:
											array2[27] = (byte)num2;
											num = 1;
											if (smethod_23())
											{
												continue;
											}
											goto IL_2366;
										case 371:
											num2 = 104;
											smethod_24();
											if (smethod_23())
											{
												goto case 97;
											}
											num = 80;
											if (smethod_24())
											{
												goto IL_0f83;
											}
											goto case 80;
										case 97:
										case 298:
											array2[11] = (byte)num2;
											num = 99;
											goto case 99;
										case 99:
											array2[11] = 130;
											num = 225;
											if (!smethod_24())
											{
												continue;
											}
											goto case 84;
										case 84:
											array2[16] = 144;
											num = 0;
											goto case 0;
										case 0:
											array2[16] = 86;
											goto case 47;
										case 47:
											array2[16] = 14;
											goto case 101;
										case 101:
											num2 = 84;
											num = 243;
											goto case 243;
										case 243:
											array2[17] = (byte)num2;
											num = 60;
											if (!smethod_24())
											{
												continue;
											}
											goto IL_094d;
										case 283:
											goto IL_0f83;
										case 189:
											goto IL_0f98;
										case 51:
											goto IL_0fa4;
										case 205:
											goto IL_0fbc;
										case 153:
											goto IL_0fd4;
										case 61:
											goto IL_0fed;
										case 288:
											goto IL_1005;
										case 262:
											goto IL_1021;
										case 41:
											goto IL_102f;
										case 73:
											goto IL_1056;
										case 266:
											goto IL_1068;
										case 289:
											goto IL_1089;
										case 30:
											goto IL_1095;
										case 202:
											goto IL_10ac;
										case 279:
											goto IL_10c3;
										case 167:
											goto IL_10db;
										case 5:
											goto IL_10ed;
										case 249:
											goto IL_10fb;
										case 134:
											goto IL_1114;
										case 337:
											goto IL_112b;
										case 115:
											goto IL_1131;
										case 292:
											goto IL_1148;
										case 316:
											goto IL_115d;
										case 269:
											goto IL_116c;
										case 158:
											goto IL_1184;
										case 291:
											goto IL_1196;
										case 55:
											goto IL_11ad;
										case 323:
											goto IL_11b6;
										case 301:
											goto IL_11cd;
										case 80:
										case 152:
											num2 = 148;
											num = 134;
											if (smethod_23())
											{
												continue;
											}
											goto IL_02e9;
										case 369:
											array3[1] = 168;
											num = 351;
											goto case 351;
										case 351:
											num3 = 206;
											num = 140;
											goto IL_05f4;
										case 367:
											goto IL_1231;
										case 364:
											array3[13] = (byte)num3;
											goto case 24;
										case 24:
											num3 = 45;
											num = 19;
											goto case 19;
										case 19:
											array3[13] = (byte)num3;
											num = 303;
											goto case 303;
										case 303:
											array3[13] = 133;
											goto case 355;
										case 355:
											num3 = 136;
											num = 275;
											goto case 275;
										case 275:
											array3[13] = (byte)num3;
											num = 177;
											goto case 177;
										case 177:
											num3 = 234;
											num = 2;
											goto case 2;
										case 2:
											array3[13] = (byte)num3;
											num = 224;
											goto case 224;
										case 224:
											array3[14] = 166;
											goto case 271;
										case 271:
											num3 = 166;
											goto case 145;
										case 145:
											array3[14] = (byte)num3;
											goto case 362;
										case 362:
											num3 = 124;
											num = 313;
											goto case 313;
										case 313:
											array3[14] = (byte)num3;
											num = 307;
											goto case 307;
										case 307:
											num3 = 128;
											num = 174;
											goto IL_0698;
										case 363:
											array2[11] = 104;
											num = 125;
											goto case 125;
										case 125:
											array2[11] = 92;
											num = 142;
											goto case 142;
										case 142:
											num2 = 113;
											num = 181;
											goto case 181;
										case 181:
											array2[11] = (byte)num2;
											num = 357;
											goto case 357;
										case 357:
											num2 = 110;
											goto case 328;
										case 328:
											array2[11] = (byte)num2;
											num = 371;
											goto case 371;
										case 349:
											array2[20] = 119;
											goto case 80;
										case 332:
											array2[31] = (byte)num2;
											num = 4;
											if (smethod_23())
											{
												continue;
											}
											goto IL_06f5;
										case 330:
											array3[1] = (byte)num3;
											num = 94;
											if (smethod_23())
											{
												continue;
											}
											goto IL_1406;
										case 308:
											goto IL_1406;
										case 322:
											array2[2] = 90;
											num = 175;
											goto case 175;
										case 175:
											num2 = 74;
											goto case 105;
										case 105:
											array2[2] = (byte)num2;
											num = 61;
											goto IL_0fed;
										case 321:
											num3 = 149;
											num = 262;
											if (!smethod_24())
											{
												continue;
											}
											goto IL_03b6;
										case 312:
											array2[9] = 87;
											num = 235;
											goto case 235;
										case 235:
											num2 = 21;
											goto IL_0653;
										case 299:
											array3[0] = 114;
											num = 321;
											goto case 321;
										case 294:
											array2[6] = 109;
											num = 208;
											goto case 208;
										case 208:
											array2[6] = 131;
											num = 6;
											goto case 6;
										case 6:
											num2 = 89;
											num = 287;
											goto case 287;
										case 287:
											array2[6] = (byte)num2;
											goto case 144;
										case 144:
											array2[6] = 157;
											num = 204;
											goto case 204;
										case 204:
											num2 = 214;
											num = 253;
											if (!smethod_23())
											{
												goto case 237;
											}
											goto case 253;
										case 237:
											num2 = 23;
											num = 86;
											goto case 86;
										case 86:
											array2[27] = (byte)num2;
											goto case 255;
										case 255:
											num2 = 9;
											goto case 374;
										case 280:
											array2[10] = (byte)num2;
											num = 15;
											goto case 15;
										case 15:
											num2 = 114;
											num = 248;
											goto case 248;
										case 248:
											array2[10] = (byte)num2;
											num = 68;
											goto case 68;
										case 68:
											num2 = 192;
											num = 168;
											if (smethod_24())
											{
												goto IL_0db4;
											}
											goto case 168;
										case 168:
											array2[10] = (byte)num2;
											num = 159;
											goto case 159;
										case 159:
											array2[10] = 167;
											goto case 363;
										case 268:
											num3 = 86;
											num = 50;
											goto case 50;
										case 50:
											array3[3] = (byte)num3;
											num = 375;
											goto case 375;
										case 259:
											num2 = 115;
											num = 79;
											goto case 79;
										case 79:
											array2[5] = (byte)num2;
											goto case 294;
										case 244:
											array3[1] = 83;
											num = 369;
											if (!smethod_24())
											{
												continue;
											}
											goto IL_07ac;
										case 242:
											array3[1] = (byte)num3;
											num = 78;
											goto case 78;
										case 78:
											num3 = 114;
											num = 330;
											goto case 330;
										case 238:
											num2 = 128;
											goto case 141;
										case 141:
											array2[5] = (byte)num2;
											num = 259;
											goto case 259;
										case 210:
											object_2 = array2;
											num = 308;
											goto IL_1406;
										case 209:
											array2[19] = (byte)num2;
											num = 349;
											goto case 349;
										case 200:
											num2 = 100;
											goto case 332;
										case 190:
											array3[2] = 199;
											num = 268;
											goto case 268;
										case 164:
											num3 = 92;
											goto case 45;
										case 45:
											array3[2] = (byte)num3;
											goto case 190;
										case 157:
											num3 = 187;
											num = 367;
											goto IL_1231;
										case 156:
											array2[5] = 107;
											num = 238;
											goto case 238;
										case 154:
											array2[15] = (byte)num2;
											goto case 84;
										case 147:
											array2[1] = (byte)num2;
											goto case 322;
										case 139:
											array2[10] = (byte)num2;
											num = 75;
											goto case 75;
										case 75:
											num2 = 154;
											goto case 280;
										case 107:
											num2 = 216;
											goto IL_0a0d;
										case 95:
											array2[5] = (byte)num2;
											num = 156;
											goto case 156;
										case 94:
											array3[1] = 140;
											num = 244;
											if (smethod_23())
											{
												continue;
											}
											goto case 343;
										case 60:
											array2[17] = 133;
											goto case 107;
										case 54:
											num3 = 118;
											num = 242;
											goto case 242;
										case 35:
											array2[28] = 122;
											goto IL_07c9;
										case 33:
											array2[28] = 193;
											goto case 35;
										case 4:
											array2[31] = 52;
											num = 210;
											goto case 210;
										case 1:
											array2[28] = 31;
											num = 33;
											goto case 33;
										default:
											num = 359;
											if (smethod_23())
											{
												continue;
											}
											goto IL_1aca;
										case 253:
											array2[6] = (byte)num2;
											num = 320;
											if (!smethod_23())
											{
												goto IL_045e;
											}
											goto case 320;
										case 225:
											num2 = 112;
											num = 366;
											goto case 366;
										case 366:
											array2[12] = (byte)num2;
											num = 338;
											goto case 338;
										case 338:
											num2 = 157;
											num = 187;
											goto case 187;
										case 187:
											array2[12] = (byte)num2;
											num = 325;
											goto case 325;
										case 325:
											array2[12] = 114;
											goto case 120;
										case 120:
											num2 = 139;
											num = 27;
											goto case 27;
										case 27:
											array2[13] = (byte)num2;
											num = 183;
											goto case 183;
										case 183:
											num2 = 114;
											num = 100;
											goto case 100;
										case 100:
											array2[13] = (byte)num2;
											num = 180;
											goto case 180;
										case 180:
											num2 = 163;
											num = 166;
											goto case 166;
										case 166:
											array2[13] = (byte)num2;
											num = 293;
											goto case 293;
										case 293:
											array2[13] = 136;
											num = 48;
											goto IL_0423;
										case 26:
											array3[11] = (byte)num3;
											num = 358;
											goto IL_0247;
										case 320:
											num2 = 86;
											num = 344;
											goto case 344;
										case 344:
											array2[7] = (byte)num2;
											num = 74;
											goto case 74;
										case 74:
											array2[7] = 122;
											num = 329;
											goto case 329;
										case 329:
											array2[7] = 104;
											num = 343;
											goto case 343;
										case 343:
											num2 = 107;
											num = 127;
											goto IL_1a02;
										case 127:
											goto IL_1a02;
										case 304:
											goto IL_1a10;
										case 347:
											goto IL_1a25;
										case 261:
											goto IL_1a3a;
										case 16:
											goto IL_1a57;
										case 29:
											goto IL_1a6e;
										case 23:
											goto IL_1a83;
										case 88:
											goto IL_1a95;
										case 43:
											goto IL_1aa3;
										case 207:
											goto IL_1ab8;
										case 91:
											goto IL_1aca;
										case 213:
											goto IL_20cf;
										case 72:
											goto IL_20ed;
										case 276:
											num2 = 114;
											num = 13;
											goto case 13;
										case 13:
											array2[19] = (byte)num2;
											goto IL_2123;
										case 315:
											goto IL_2123;
										case 39:
											goto IL_2132;
										case 232:
											goto IL_2149;
										case 267:
											goto IL_2154;
										case 246:
											goto IL_2177;
										case 199:
											goto IL_2188;
										case 302:
											goto IL_21a1;
										case 116:
											goto IL_21b5;
										case 11:
											goto IL_21ce;
										case 151:
											goto IL_21d9;
										case 241:
											goto end_IL_21d9;
										case 135:
											goto end_IL_21fc;
										case 270:
											goto end_IL_221d;
										case 124:
											goto end_IL_2225;
										case 216:
											goto end_IL_2245;
										case 132:
											goto IL_2281;
										case 117:
											goto IL_228a;
										case 163:
											goto IL_229c;
										case 21:
											goto IL_22ae;
										case 136:
											goto IL_22be;
										case 247:
											goto IL_22cf;
										case 197:
											goto IL_22e5;
										case 173:
											goto IL_22f5;
										case 373:
											goto IL_230a;
										case 218:
											goto IL_2321;
										case 250:
											goto IL_2331;
										case 169:
											goto IL_2346;
										case 257:
											goto IL_2356;
										case 34:
											goto IL_2366;
										case 155:
											goto IL_2376;
										case 376:
											goto end_IL_2270;
										}
										break;
									}
									goto IL_001c;
									IL_1114:
									array2[20] = (byte)num2;
									num = 337;
									goto IL_112b;
									IL_112b:
									num2 = 39;
									goto IL_1131;
									IL_1131:
									array2[20] = (byte)num2;
									num = 292;
									goto IL_1148;
									IL_1148:
									array2[20] = 107;
									num = 316;
									goto IL_115d;
									IL_115d:
									array2[20] = 188;
									goto IL_116c;
									IL_116c:
									array2[21] = 157;
									num = 158;
									goto IL_1184;
									IL_1184:
									num2 = 162;
									num = 291;
									goto IL_1196;
									IL_1196:
									array2[21] = (byte)num2;
									num = 55;
									goto IL_11ad;
									IL_11ad:
									num2 = 224;
									goto IL_11b6;
									IL_11b6:
									array2[21] = (byte)num2;
									num = 301;
									goto IL_11cd;
									IL_11cd:
									array2[22] = 134;
									goto IL_054b;
									IL_0fed:
									array2[2] = 207;
									num = 288;
									goto IL_1005;
									IL_1005:
									array2[2] = 112;
									num = 73;
									if (smethod_24())
									{
										goto IL_1021;
									}
									goto IL_1056;
									IL_1021:
									array3[0] = (byte)num3;
									goto IL_102f;
									IL_102f:
									array3[0] = 202;
									num = 54;
									if (!smethod_23())
									{
										goto IL_0de9;
									}
									goto IL_1add;
									IL_1056:
									num2 = 146;
									num = 266;
									goto IL_1068;
									IL_1068:
									array2[2] = (byte)num2;
									num = 289;
									if (smethod_24())
									{
										goto IL_0181;
									}
									goto IL_1089;
									IL_1089:
									array2[3] = 110;
									goto IL_1095;
									IL_1095:
									num2 = 146;
									num = 361;
									goto IL_0d91;
									IL_0ae7:
									array3[3] = 178;
									goto IL_0521;
									IL_0521:
									num3 = 185;
									goto IL_052a;
									IL_052a:
									array3[3] = (byte)num3;
									num = 172;
									if (smethod_24())
									{
										goto IL_054b;
									}
									goto IL_0b3f;
									IL_054b:
									array2[22] = 127;
									num = 354;
									goto IL_0560;
									IL_0560:
									num2 = 171;
									num = 16;
									if (smethod_24())
									{
										goto IL_057c;
									}
									goto IL_1a57;
									IL_057c:
									array2[0] = 106;
									goto IL_0588;
									IL_0588:
									num2 = 149;
									num = 252;
									if (!smethod_23())
									{
										goto end_IL_21fc;
									}
									goto IL_05a4;
									IL_05a4:
									array2[1] = (byte)num2;
									num = 348;
									goto IL_05bb;
									IL_05bb:
									num2 = 94;
									num = 230;
									goto IL_05ca;
									IL_05ca:
									array2[1] = (byte)num2;
									goto IL_05d8;
									IL_05d8:
									num2 = 230;
									num = 147;
									if (smethod_24())
									{
										goto IL_05f4;
									}
									goto IL_1add;
									IL_05f4:
									array3[1] = (byte)num3;
									num = 277;
									goto IL_060b;
									IL_060b:
									num3 = 18;
									num = 104;
									goto IL_061a;
									IL_061a:
									array3[2] = (byte)num3;
									num = 258;
									goto IL_0631;
									IL_0631:
									array3[2] = 158;
									num = 319;
									if (!smethod_23())
									{
										goto IL_0653;
									}
									goto IL_09e5;
									IL_0653:
									array2[9] = (byte)num2;
									num = 264;
									goto IL_066a;
									IL_066a:
									num2 = 135;
									num = 353;
									goto IL_067c;
									IL_067c:
									array2[10] = (byte)num2;
									num = 102;
									goto IL_08da;
									IL_08da:
									num2 = 131;
									num = 139;
									if (smethod_24())
									{
										goto IL_0698;
									}
									goto IL_1add;
									IL_0698:
									array3[14] = (byte)num3;
									num = 14;
									goto IL_06af;
									IL_06af:
									num3 = 142;
									num = 263;
									goto IL_06c1;
									IL_06c1:
									array3[14] = (byte)num3;
									num = 297;
									goto IL_06d8;
									IL_06d8:
									num3 = 89;
									num = 179;
									goto IL_06e7;
									IL_06e7:
									array3[15] = (byte)num3;
									goto IL_06f5;
									IL_06f5:
									num3 = 41;
									num = 342;
									goto IL_0704;
									IL_0704:
									array3[15] = (byte)num3;
									num = 69;
									goto IL_071b;
									IL_071b:
									num3 = 122;
									goto IL_0721;
									IL_0721:
									array3[15] = (byte)num3;
									num = 89;
									goto IL_0738;
									IL_0738:
									num3 = 89;
									num = 49;
									goto IL_0747;
									IL_0747:
									array3[15] = (byte)num3;
									num = 245;
									goto IL_075e;
									IL_075e:
									num3 = 85;
									goto IL_0764;
									IL_0764:
									array3[15] = (byte)num3;
									goto IL_0772;
									IL_0772:
									array4 = array3;
									goto IL_0778;
									IL_0778:
									array5 = (byte[])smethod_12(smethod_11(smethod_4(typeof(Class13).TypeHandle).Assembly));
									num = 108;
									goto IL_079c;
									IL_079c:
									if (array5 != null)
									{
										num = 334;
										goto IL_07ac;
									}
									goto IL_22ae;
									IL_2356:
									smethod_18(object_3);
									num = 34;
									goto IL_2366;
									IL_07ac:
									if (array5.Length > 0)
									{
										num = 130;
										if (smethod_24())
										{
											goto IL_07c9;
										}
										goto IL_0afb;
									}
									goto IL_22ae;
									IL_2366:
									smethod_19(object_);
									num = 155;
									goto IL_2376;
									IL_07c9:
									array2[28] = 134;
									num = 324;
									goto IL_07e1;
									IL_07e1:
									array2[28] = 99;
									num = 229;
									goto IL_07f6;
									IL_07f6:
									array2[28] = 15;
									goto IL_0802;
									IL_0802:
									array2[29] = 107;
									num = 186;
									goto IL_0817;
									IL_0817:
									array2[29] = 166;
									goto IL_0826;
									IL_0826:
									array2[29] = 122;
									num = 272;
									goto IL_083b;
									IL_083b:
									array2[29] = 122;
									num = 87;
									goto IL_0850;
									IL_0850:
									num2 = 58;
									goto IL_0856;
									IL_0856:
									array2[29] = (byte)num2;
									goto IL_0864;
									IL_0864:
									num2 = 139;
									num = 335;
									if (smethod_24())
									{
										goto IL_087d;
									}
									goto IL_08fb;
									IL_087d:
									array3[8] = 71;
									num = 215;
									goto IL_0892;
									IL_0892:
									num3 = 116;
									num = 71;
									goto IL_08a1;
									IL_08a1:
									array3[8] = (byte)num3;
									num = 111;
									goto IL_08b8;
									IL_08b8:
									array3[8] = 159;
									num = 157;
									if (!smethod_23())
									{
										goto IL_08da;
									}
									goto IL_1add;
									IL_08fb:
									array2[30] = (byte)num2;
									num = 63;
									goto IL_0912;
									IL_0912:
									array2[30] = 139;
									num = 239;
									goto IL_092a;
									IL_092a:
									num2 = 98;
									num = 203;
									goto IL_0939;
									IL_0939:
									array2[30] = (byte)num2;
									goto IL_0947;
									IL_0947:
									num2 = 44;
									goto IL_094d;
									IL_094d:
									array2[30] = (byte)num2;
									num = 161;
									goto IL_0964;
									IL_0964:
									num2 = 142;
									goto IL_096d;
									IL_096d:
									array2[31] = (byte)num2;
									num = 368;
									goto IL_0984;
									IL_0984:
									num2 = 149;
									num = 10;
									goto IL_0996;
									IL_0996:
									array2[31] = (byte)num2;
									num = 195;
									goto IL_09ad;
									IL_09ad:
									num2 = 146;
									num = 31;
									goto IL_09bf;
									IL_09bf:
									array2[31] = (byte)num2;
									num = 200;
									if (smethod_24())
									{
										goto IL_0a93;
									}
									goto IL_1add;
									IL_0afb:
									array4[1] = array5[0];
									goto IL_0b03;
									IL_0b03:
									array4[3] = array5[1];
									num = 285;
									goto IL_0ca4;
									IL_09e5:
									array3[2] = 165;
									goto IL_09f4;
									IL_09f4:
									num3 = 102;
									num = 221;
									if (!smethod_23())
									{
										goto IL_0a0d;
									}
									goto IL_0b19;
									IL_0a0d:
									array2[17] = (byte)num2;
									num = 40;
									goto IL_0a24;
									IL_0a24:
									array2[17] = 61;
									goto IL_0a30;
									IL_0a30:
									num2 = 75;
									num = 128;
									goto IL_0a3f;
									IL_0a3f:
									array2[17] = (byte)num2;
									goto IL_0a4d;
									IL_0a4d:
									num2 = 94;
									num = 265;
									goto IL_0a5c;
									IL_0a5c:
									array2[18] = (byte)num2;
									num = 123;
									goto IL_0a73;
									IL_0a73:
									num2 = 144;
									num = 122;
									goto IL_0a85;
									IL_0a85:
									array2[18] = (byte)num2;
									goto IL_0a93;
									IL_0a93:
									array2[18] = 48;
									num = 171;
									goto IL_0aa8;
									IL_0aa8:
									num2 = 104;
									goto IL_0aae;
									IL_0aae:
									array2[18] = (byte)num2;
									num = 185;
									goto IL_0ac5;
									IL_0ac5:
									array2[18] = 155;
									num = 276;
									if (!smethod_23())
									{
										goto IL_0ae7;
									}
									goto IL_1add;
									IL_0b19:
									array3[2] = (byte)num3;
									num = 164;
									if (!smethod_23())
									{
										goto IL_1a02;
									}
									goto IL_1add;
									IL_1a02:
									array2[7] = (byte)num2;
									goto IL_1a10;
									IL_1a10:
									array2[7] = 51;
									num = 347;
									goto IL_1a25;
									IL_1a25:
									array2[7] = 91;
									num = 261;
									goto IL_1a3a;
									IL_1a3a:
									array2[8] = 196;
									num = 112;
									goto IL_0161;
									IL_1a57:
									array2[22] = (byte)num2;
									num = 29;
									goto IL_1a6e;
									IL_1a6e:
									array2[22] = 69;
									num = 23;
									goto IL_1a83;
									IL_1a83:
									num2 = 147;
									num = 88;
									goto IL_1a95;
									IL_1a95:
									array2[22] = (byte)num2;
									goto IL_1aa3;
									IL_1aa3:
									array2[23] = 88;
									num = 207;
									goto IL_1ab8;
									IL_1ab8:
									num2 = 140;
									num = 91;
									goto IL_1aca;
									IL_1aca:
									array2[23] = (byte)num2;
									goto IL_001c;
									IL_0b3f:
									array3[4] = 166;
									num = 150;
									if (!smethod_23())
									{
										goto IL_03b6;
									}
									goto IL_0b61;
									IL_0b61:
									array3[4] = 237;
									num = 284;
									goto IL_0b79;
									IL_0b79:
									num3 = 183;
									num = 32;
									goto IL_0b8b;
									IL_0b8b:
									array3[4] = (byte)num3;
									num = 192;
									goto IL_0ba2;
									IL_0ba2:
									array3[4] = 131;
									num = 345;
									goto IL_0bba;
									IL_0bba:
									array3[4] = 87;
									goto IL_0bc6;
									IL_0bc6:
									array3[4] = 54;
									num = 305;
									goto IL_0bdb;
									IL_0bdb:
									array3[5] = 94;
									goto IL_0be7;
									IL_0be7:
									array3[5] = 166;
									num = 58;
									goto IL_0bff;
									IL_0bff:
									array3[5] = 36;
									num = 38;
									goto IL_0c14;
									IL_0c14:
									num3 = 111;
									goto IL_0c1a;
									IL_0c1a:
									array3[6] = (byte)num3;
									goto IL_0c28;
									IL_0c28:
									array3[6] = 98;
									num = 17;
									goto IL_0c3d;
									IL_0c3d:
									array3[6] = 112;
									num = 206;
									goto IL_0c52;
									IL_0c52:
									array3[6] = 31;
									num = 178;
									goto IL_0c67;
									IL_0c67:
									array3[7] = 145;
									num = 25;
									goto IL_0c7f;
									IL_0c7f:
									array3[7] = 133;
									goto IL_0c8e;
									IL_0c8e:
									num3 = 105;
									num = 93;
									if (smethod_24())
									{
										goto IL_0ca4;
									}
									goto IL_0ce7;
									IL_0ca4:
									array4[5] = array5[2];
									num = 346;
									goto IL_0cb5;
									IL_0cb5:
									array4[7] = array5[3];
									num = 149;
									goto IL_0cc6;
									IL_0cc6:
									array4[9] = array5[4];
									num = 132;
									if (!smethod_24())
									{
										goto IL_1add;
									}
									goto IL_2123;
									IL_2123:
									num2 = 33;
									num = 39;
									goto IL_2132;
									IL_2132:
									array2[19] = (byte)num2;
									num = 232;
									goto IL_2149;
									IL_0ce7:
									array3[7] = (byte)num3;
									num = 109;
									goto IL_0cfe;
									IL_0cfe:
									array3[7] = 53;
									num = 7;
									goto IL_0d13;
									IL_0d13:
									num3 = 170;
									num = 62;
									goto IL_0d25;
									IL_0d25:
									array3[7] = (byte)num3;
									num = 90;
									goto IL_0d3c;
									IL_0d3c:
									num3 = 116;
									num = 52;
									goto IL_0d4b;
									IL_0d4b:
									array3[7] = (byte)num3;
									num = 309;
									goto IL_0d62;
									IL_0d62:
									array3[8] = 82;
									num = 365;
									goto IL_0d77;
									IL_0d77:
									array3[8] = 124;
									num = 57;
									goto IL_0e71;
									IL_0e71:
									array3[8] = 91;
									num = 326;
									if (!smethod_23())
									{
										goto IL_0d91;
									}
									goto IL_1add;
									IL_0d91:
									array2[3] = (byte)num2;
									num = 92;
									goto IL_0da8;
									IL_0da8:
									array2[3] = 102;
									goto IL_0db4;
									IL_0db4:
									num2 = 83;
									num = 341;
									goto IL_0dc3;
									IL_0dc3:
									array2[3] = (byte)num2;
									num = 42;
									goto IL_0dda;
									IL_0dda:
									array2[3] = 229;
									goto IL_0de9;
									IL_0de9:
									num2 = 108;
									goto IL_0def;
									IL_0def:
									array2[4] = (byte)num2;
									goto IL_0dfd;
									IL_0dfd:
									num2 = 161;
									goto IL_0e06;
									IL_0e06:
									array2[4] = (byte)num2;
									num = 114;
									goto IL_0e1d;
									IL_0e1d:
									num2 = 148;
									num = 220;
									goto IL_0e2f;
									IL_0e2f:
									array2[4] = (byte)num2;
									goto IL_0e3d;
									IL_0e3d:
									array2[5] = 158;
									num = 306;
									goto IL_0e55;
									IL_0e55:
									num2 = 145;
									num = 95;
									if (smethod_24())
									{
										goto IL_0e71;
									}
									goto IL_1add;
									IL_0333:
									array3[12] = 49;
									num = 110;
									goto IL_0348;
									IL_0348:
									num3 = 148;
									num = 364;
									if (smethod_24())
									{
										goto IL_0364;
									}
									goto IL_1add;
									IL_0364:
									array2[26] = (byte)num2;
									goto IL_0372;
									IL_0372:
									array2[26] = 114;
									num = 222;
									goto IL_0387;
									IL_0387:
									num2 = 145;
									goto IL_0390;
									IL_0390:
									array2[26] = (byte)num2;
									goto IL_039e;
									IL_039e:
									array2[27] = 135;
									num = 274;
									goto IL_03b6;
									IL_03b6:
									array2[27] = 33;
									num = 81;
									goto IL_03cb;
									IL_03cb:
									array2[27] = 110;
									num = 237;
									if (smethod_24())
									{
										goto IL_03ea;
									}
									goto IL_1add;
									IL_03ea:
									array2[25] = (byte)num2;
									goto IL_03f8;
									IL_0093:
									array2[24] = 117;
									num = 333;
									goto IL_00a8;
									IL_00a8:
									array2[24] = 116;
									num = 96;
									goto IL_00bd;
									IL_00bd:
									num2 = 136;
									goto IL_00c6;
									IL_00c6:
									array2[24] = (byte)num2;
									num = 37;
									if (!smethod_24())
									{
										goto IL_00e7;
									}
									goto IL_2281;
									IL_00e7:
									num2 = 50;
									num = 228;
									goto IL_00f6;
									IL_00f6:
									array2[24] = (byte)num2;
									num = 223;
									goto IL_010d;
									IL_010d:
									num2 = 94;
									goto IL_0113;
									IL_0113:
									array2[25] = (byte)num2;
									num = 106;
									goto IL_012a;
									IL_012a:
									array2[25] = 123;
									goto IL_0136;
									IL_0136:
									array2[25] = 162;
									goto IL_0145;
									IL_0145:
									num2 = 150;
									num = 119;
									if (smethod_24())
									{
										goto IL_0161;
									}
									goto IL_1add;
									IL_0161:
									num2 = 129;
									num = 219;
									goto IL_0173;
									IL_0173:
									array2[8] = (byte)num2;
									goto IL_0181;
									IL_0181:
									num2 = 94;
									goto IL_0187;
									IL_0187:
									array2[8] = (byte)num2;
									goto IL_0195;
									IL_0195:
									num2 = 144;
									num = 327;
									goto IL_01a7;
									IL_01a7:
									array2[8] = (byte)num2;
									num = 201;
									if (smethod_23())
									{
										goto IL_01c8;
									}
									goto IL_03f8;
									IL_01c8:
									array2[8] = 111;
									goto IL_01d4;
									IL_01d4:
									num2 = 112;
									num = 9;
									goto IL_01e3;
									IL_01e3:
									array2[8] = (byte)num2;
									num = 18;
									goto IL_01fa;
									IL_01fa:
									num2 = 106;
									goto IL_0200;
									IL_0200:
									array2[9] = (byte)num2;
									num = 126;
									goto IL_0217;
									IL_0217:
									num2 = 90;
									num = 211;
									goto IL_0226;
									IL_0226:
									array2[9] = (byte)num2;
									num = 312;
									if (smethod_24())
									{
										goto IL_0247;
									}
									goto IL_1add;
									IL_0247:
									num3 = 127;
									num = 295;
									goto IL_0256;
									IL_0256:
									array3[11] = (byte)num3;
									num = 148;
									goto IL_026d;
									IL_026d:
									array3[11] = 46;
									num = 290;
									goto IL_0282;
									IL_0282:
									array3[11] = 146;
									num = 340;
									goto IL_029a;
									IL_029a:
									array3[11] = 78;
									goto IL_02a6;
									IL_02a6:
									num3 = 79;
									goto IL_02ac;
									IL_03f8:
									array2[25] = 182;
									goto IL_0407;
									IL_0407:
									num2 = 155;
									num = 3;
									if (!smethod_23())
									{
										goto IL_0423;
									}
									goto IL_1add;
									IL_0423:
									num2 = 90;
									num = 53;
									if (!smethod_24())
									{
										goto IL_043c;
									}
									goto IL_0fa4;
									IL_043c:
									array2[14] = (byte)num2;
									goto IL_044a;
									IL_044a:
									num2 = 119;
									goto IL_0450;
									IL_0450:
									array2[14] = (byte)num2;
									goto IL_045e;
									IL_045e:
									array2[14] = 116;
									num = 311;
									goto IL_0473;
									IL_0473:
									array2[14] = 45;
									goto IL_047f;
									IL_047f:
									num2 = 153;
									goto IL_0488;
									IL_0488:
									array2[14] = (byte)num2;
									num = 314;
									goto IL_049f;
									IL_049f:
									array2[15] = 165;
									goto IL_04ae;
									IL_04ae:
									num2 = 101;
									goto IL_04b4;
									IL_04b4:
									array2[15] = (byte)num2;
									num = 233;
									goto IL_04cb;
									IL_04cb:
									num2 = 37;
									num = 154;
									if (!smethod_24())
									{
										goto IL_1add;
									}
									goto IL_22e5;
									IL_2281:
									array4[11] = array5[5];
									goto IL_228a;
									IL_228a:
									array4[13] = array5[6];
									num = 163;
									goto IL_229c;
									IL_229c:
									array4[15] = array5[7];
									num = 21;
									goto IL_22ae;
									IL_22ae:
									object_4 = new RijndaelManaged();
									num = 136;
									goto IL_22be;
									IL_22be:
									smethod_13(object_4, CipherMode.CBC);
									num = 247;
									goto IL_22cf;
									IL_22cf:
									transform = (ICryptoTransform)smethod_14(object_4, object_2, array4);
									num = 197;
									goto IL_22e5;
									IL_22e5:
									memoryStream = new MemoryStream();
									num = 173;
									goto IL_22f5;
									IL_22f5:
									object_3 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
									num = 373;
									goto IL_230a;
									IL_230a:
									smethod_15(object_3, array, 0, array.Length);
									num = 218;
									goto IL_2321;
									IL_2321:
									smethod_16(object_3);
									num = 250;
									goto IL_2331;
									IL_2331:
									byte_2 = (byte[])smethod_17(memoryStream);
									num = 169;
									goto IL_2346;
									IL_2346:
									smethod_18(memoryStream);
									num = 257;
									goto IL_2356;
									continue;
									end_IL_21d9:
									break;
								}
								continue;
								end_IL_21fc:
								break;
							}
							continue;
							end_IL_221d:
							break;
						}
						continue;
						end_IL_2225:
						break;
					}
					continue;
					end_IL_2245:
					break;
				}
				continue;
			}
			goto IL_2376;
			IL_2376:
			int_6 = smethod_20(byte_2, int_5);
			num = 376;
			break;
			continue;
			end_IL_2270:
			break;
		}
		string result;
		try
		{
			result = (string)smethod_22(smethod_21(), byte_2, int_5 + 4, int_6);
		}
		catch
		{
			goto IL_23a7;
		}
		return result;
		IL_23a7:
		return "";
	}

	internal static object smethod_2(object object_1)
	{
		object result;
		try
		{
			if (File.Exists(((Assembly)object_1).Location))
			{
				result = ((Assembly)object_1).Location;
				goto IL_00d9;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)object_1).GetName().CodeBase!.ToString().Replace("楦敬⼺⼯", "")))
			{
				result = ((Assembly)object_1).GetName().CodeBase!.ToString().Replace("楦敬⼺⼯", "");
				goto IL_00d9;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(object_1.GetType().GetProperty("潌慣楴湯")!.GetValue(object_1, new object[0])!.ToString()))
			{
				result = object_1.GetType().GetProperty("潌慣楴湯")!.GetValue(object_1, new object[0])!.ToString();
				goto IL_00d9;
			}
		}
		catch
		{
		}
		return "";
		IL_00d9:
		return result;
	}

	private static byte[] smethod_3(string string_0)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			long length = fileStream.Length;
			int num2 = (int)length;
			array = new byte[num2];
			while (num2 > 0)
			{
				int num3 = fileStream.Read(array, num, num2);
				num += num3;
				num2 -= num3;
			}
		}
		return array;
	}

	internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object smethod_5(object object_1, object object_2)
	{
		return ((Assembly)object_1).GetManifestResourceStream((string)object_2);
	}

	internal static object smethod_6(object object_1)
	{
		return ((BinaryReader)object_1).BaseStream;
	}

	internal static void smethod_7(object object_1, long long_2)
	{
		((Stream)object_1).Position = long_2;
	}

	internal static void smethod_8(bool bool_3)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_3;
	}

	internal static long smethod_9(object object_1)
	{
		return ((Stream)object_1).Length;
	}

	internal static object smethod_10(object object_1, int int_5)
	{
		return ((BinaryReader)object_1).ReadBytes(int_5);
	}

	internal static object smethod_11(object object_1)
	{
		return ((Assembly)object_1).GetName();
	}

	internal static object smethod_12(object object_1)
	{
		return ((AssemblyName)object_1).GetPublicKeyToken();
	}

	internal static void smethod_13(object object_1, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_1).Mode = cipherMode_0;
	}

	internal static object smethod_14(object object_1, object object_2, object object_3)
	{
		return ((SymmetricAlgorithm)object_1).CreateDecryptor((byte[])object_2, (byte[]?)object_3);
	}

	internal static void smethod_15(object object_1, object object_2, int int_5, int int_6)
	{
		((Stream)object_1).Write((byte[])object_2, int_5, int_6);
	}

	internal static void smethod_16(object object_1)
	{
		((CryptoStream)object_1).FlushFinalBlock();
	}

	internal static object smethod_17(object object_1)
	{
		return ((MemoryStream)object_1).ToArray();
	}

	internal static void smethod_18(object object_1)
	{
		((Stream)object_1).Close();
	}

	internal static void smethod_19(object object_1)
	{
		((BinaryReader)object_1).Close();
	}

	internal static int smethod_20(object object_1, int int_5)
	{
		return BitConverter.ToInt32((byte[])object_1, int_5);
	}

	internal static object smethod_21()
	{
		return Encoding.Unicode;
	}

	internal static object smethod_22(object object_1, object object_2, int int_5, int int_6)
	{
		return ((Encoding)object_1).GetString((byte[])object_2, int_5, int_6);
	}

	internal static bool smethod_23()
	{
		return true;
	}

	internal static bool smethod_24()
	{
		return false;
	}

	internal static Type smethod_25(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object smethod_26(object object_1, object object_2)
	{
		return ((Assembly)object_1).GetManifestResourceStream((string)object_2);
	}

	internal static object smethod_27(object object_1)
	{
		return ((BinaryReader)object_1).BaseStream;
	}

	internal static void smethod_28(object object_1, long long_2)
	{
		((Stream)object_1).Position = long_2;
	}

	internal static void smethod_29(bool bool_3)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_3;
	}

	internal static long smethod_30(object object_1)
	{
		return ((Stream)object_1).Length;
	}

	internal static object smethod_31(object object_1, int int_5)
	{
		return ((BinaryReader)object_1).ReadBytes(int_5);
	}

	internal static object smethod_32(object object_1)
	{
		return ((Assembly)object_1).GetName();
	}

	internal static object smethod_33(object object_1)
	{
		return ((AssemblyName)object_1).GetPublicKeyToken();
	}

	internal static void smethod_34(object object_1, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_1).Mode = cipherMode_0;
	}

	internal static object smethod_35(object object_1, object object_2, object object_3)
	{
		return ((SymmetricAlgorithm)object_1).CreateDecryptor((byte[])object_2, (byte[]?)object_3);
	}

	internal static void smethod_36(object object_1, object object_2, int int_5, int int_6)
	{
		((Stream)object_1).Write((byte[])object_2, int_5, int_6);
	}

	internal static void smethod_37(object object_1)
	{
		((CryptoStream)object_1).FlushFinalBlock();
	}

	internal static object smethod_38(object object_1)
	{
		return ((MemoryStream)object_1).ToArray();
	}

	internal static void smethod_39(object object_1)
	{
		((Stream)object_1).Close();
	}

	internal static void smethod_40(object object_1)
	{
		((BinaryReader)object_1).Close();
	}

	internal static object smethod_41(object object_1)
	{
		return smethod_2(object_1);
	}

	internal static object smethod_42(object object_1)
	{
		return smethod_3((string)object_1);
	}

	internal static int smethod_43(object object_1, int int_5)
	{
		return BitConverter.ToInt32((byte[])object_1, int_5);
	}

	internal static bool smethod_44()
	{
		return true;
	}

	internal static bool smethod_45()
	{
		return false;
	}
}
