using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using Mm1VUwLfnFwQpWyMTtM;
using R2ujhcKxVgITXpqg9X;

namespace HEvco0LrYii1E5g0Mwm;

internal class InUQFsLWwvd0eKLmlrc
{
	private enum BPapO7L1F2sQ1a2O6jX
	{

	}

	internal class iiaMqOLvW7dpILTfbHw
	{
		private unsafe static uint DxPL0hwN34(void* pVoid_0, uint uint_0)
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

		private unsafe static bool qS6LcY5A4A(void* pVoid_0, void* pVoid_1, uint uint_0)
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

		private unsafe static void qn4L7Gb6R1(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[num] = byte_0;
			}
		}

		private unsafe static void QhtLGPl6M7(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[num] = ((byte*)pVoid_1)[num];
			}
		}

		private unsafe static void BhuLzWK28m(byte* pByte_0, byte* pByte_1, uint uint_0)
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
				QhtLGPl6M7(pByte_0, pByte_1, uint_0);
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

		private unsafe static uint W1mj4O6342(byte[] byte_0, uint uint_0, BPapO7L1F2sQ1a2O6jX bpapO7L1F2sQ1a2O6jX_0)
		{
			int result;
			fixed (byte* ptr = byte_0)
			{
				result = *(int*)(ptr + uint_0 + (nint)bpapO7L1F2sQ1a2O6jX_0 * (nint)4);
			}
			return (uint)result;
		}

		public static uint CvijX7TmZY(byte[] byte_0, uint uint_0)
		{
			return W1mj4O6342(byte_0, uint_0, (BPapO7L1F2sQ1a2O6jX)3);
		}

		private unsafe static uint jEFjLwKY9p(byte[] byte_0, uint uint_0, byte[] byte_1)
		{
			fixed (byte* ptr = byte_0)
			{
				fixed (byte* ptr4 = byte_1)
				{
					byte* ptr2 = ptr + uint_0;
					uint num = 32u;
					byte* ptr3 = ptr2 + 32u;
					byte* ptr5 = ptr4;
					uint* ptr6 = (uint*)ptr2;
					byte* ptr7 = ptr4 + DxPL0hwN34(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (DxPL0hwN34(ptr6 + 4, 4u) != 1)
					{
						QhtLGPl6M7(ptr4, ptr2 + num, DxPL0hwN34(ptr6 + 3, 4u));
						return DxPL0hwN34(ptr6 + 3, 4u);
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
							num2 = DxPL0hwN34(ptr3, 4u);
							ptr3 += 4;
						}
						uint num3 = DxPL0hwN34(ptr3, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								BhuLzWK28m(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr3++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								BhuLzWK28m(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr3 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								BhuLzWK28m(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr3 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								BhuLzWK28m(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr3 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								BhuLzWK28m(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr3 += 4;
							}
							else
							{
								byte byte_2 = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFFu;
								qn4L7Gb6R1(ptr5, byte_2, num5);
								ptr5 += num5;
								ptr3 += 3;
							}
						}
						else
						{
							BhuLzWK28m(ptr5, ptr3, 4u);
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

		internal static object JX3jjMYxAj(byte[] byte_0)
		{
			return typeof(Assembly).GetMethod(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(2156).Trim(), new Type[1] { typeof(byte[]) })!.Invoke(null, new object[1] { byte_0 });
		}

		public static byte[] CVWjYWC52a(byte[] byte_0, uint uint_0)
		{
			uint num = CvijX7TmZY(byte_0, uint_0);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				jEFjLwKY9p(byte_0, uint_0, array);
			}
			return array;
		}
	}

	private static string[] pTjLNi94Ct = new string[0];

	private static object XGvLosJ5Ax = null;

	private static bool j8gLHYpNba = false;

	private static bool Ik2Lb8Ktxh = false;

	private static void DWQL8KNbJg()
	{
		int num2 = default(int);
		sMk8wArgfJX2hbRXDA.vm4PJULCoMilxHZamU9 object_ = default(sMk8wArgfJX2hbRXDA.vm4PJULCoMilxHZamU9);
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		byte[] array6 = default(byte[]);
		byte[] array = default(byte[]);
		int num3 = default(int);
		int num9 = default(int);
		uint num11 = default(uint);
		uint num18 = default(uint);
		uint num17 = default(uint);
		int num6 = default(int);
		byte[] array4 = default(byte[]);
		uint num10 = default(uint);
		int num5 = default(int);
		int num7 = default(int);
		uint num16 = default(uint);
		byte[] array5 = default(byte[]);
		byte[] array7 = default(byte[]);
		int num8 = default(int);
		int num21 = default(int);
		int num20 = default(int);
		int num14 = default(int);
		uint num19 = default(uint);
		byte[] array3 = default(byte[]);
		int num13 = default(int);
		int num15 = default(int);
		uint num12 = default(uint);
		byte[] array8 = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		DeflateStream deflateStream = default(DeflateStream);
		while (true)
		{
			IL_245b:
			int num;
			if (j8gLHYpNba)
			{
				num = 68;
				if (hwI8wUyTbCvBoCtDLA1() != null)
				{
					goto IL_19e9;
				}
				goto IL_1d92;
			}
			goto IL_240c;
			IL_0236:
			num2 += 8;
			num = 132;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_024c;
			}
			goto IL_1d92;
			IL_240c:
			object_ = new sMk8wArgfJX2hbRXDA.vm4PJULCoMilxHZamU9((Stream)HHrXfvyinUgJ1gZsg15(tqrp5lyJGnSAASLoLO6(typeof(sMk8wArgfJX2hbRXDA).TypeHandle).Assembly, sMk8wArgfJX2hbRXDA.N5lXuuIcUm(2078)));
			num = 50;
			if (H582R2yCIX8tLn1A5pl())
			{
				goto IL_1bf4;
			}
			goto IL_1d92;
			IL_1d92:
			while (true)
			{
				switch (num)
				{
				case 411:
					array2[1] = (byte)num4;
					goto case 372;
				case 372:
					array2[2] = 24;
					goto case 293;
				case 293:
					num4 = 36;
					num = 402;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 54;
				case 54:
					num4 = 112;
					goto case 14;
				case 14:
					array2[30] = (byte)num4;
					num = 3;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 17;
				case 17:
					array2[30] = 161;
					goto case 334;
				case 334:
					array2[31] = 96;
					goto case 177;
				case 177:
					array2[31] = 109;
					goto case 141;
				case 141:
					num4 = 62;
					goto case 42;
				case 42:
					array2[31] = (byte)num4;
					goto case 213;
				case 213:
					array6 = array2;
					goto case 348;
				case 348:
					array = new byte[16];
					num = 151;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 76;
				case 76:
					array2[18] = (byte)num4;
					goto case 374;
				case 374:
					num4 = 1;
					goto case 150;
				case 150:
					array2[18] = (byte)num4;
					num = 34;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 4;
				case 4:
					array2[28] = (byte)num4;
					goto case 235;
				case 235:
					num4 = 176;
					goto case 53;
				case 53:
					array2[28] = (byte)num4;
					num = 9;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 320;
				case 320:
					num4 = 113;
					goto case 71;
				case 71:
					array2[28] = (byte)num4;
					goto case 373;
				case 373:
					array2[28] = 135;
					break;
				case 200:
					break;
				case 33:
					goto IL_015b;
				case 375:
					goto IL_0169;
				case 170:
					goto IL_016f;
				case 367:
					goto IL_017d;
				case 136:
					goto IL_0183;
				case 174:
					goto IL_01a1;
				case 216:
					goto IL_01b0;
				case 23:
					goto IL_01cc;
				case 172:
					goto IL_01e5;
				case 290:
					goto IL_0203;
				case 167:
					goto IL_021b;
				case 49:
					goto IL_0220;
				case 272:
					goto IL_0236;
				case 225:
					goto IL_024c;
				case 266:
					goto IL_0270;
				case 116:
				case 307:
					goto IL_0276;
				case 82:
					goto IL_028c;
				case 259:
					goto IL_0290;
				case 192:
					goto IL_02a7;
				case 73:
				case 206:
					goto IL_02ac;
				case 346:
					goto IL_02c3;
				case 340:
					goto IL_02ca;
				case 36:
					goto IL_02d9;
				case 400:
					goto IL_0329;
				case 407:
					goto IL_033a;
				case 80:
					goto IL_0353;
				case 22:
				case 147:
				case 321:
					goto IL_036f;
				case 410:
					array2[17] = (byte)num4;
					goto case 366;
				case 366:
					array2[17] = 193;
					goto case 119;
				case 119:
					num4 = 196;
					num = 27;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 124;
				case 124:
					array2[17] = (byte)num4;
					goto case 61;
				case 61:
					array2[18] = 97;
					num = 74;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 58;
				case 58:
					array2[14] = (byte)num4;
					num = 0;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto default;
				default:
					array2[14] = 144;
					num = 336;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 102;
				case 102:
					array2[25] = (byte)num4;
					goto case 258;
				case 258:
					array2[26] = 132;
					goto case 127;
				case 127:
					array2[26] = 108;
					goto case 209;
				case 209:
					array2[26] = 230;
					goto case 314;
				case 314:
					array2[27] = 173;
					num = 65;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 133;
				case 133:
					array2[27] = 155;
					num = 43;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 84;
				case 84:
					num4 = 114;
					goto case 405;
				case 405:
					array2[27] = (byte)num4;
					goto case 231;
				case 231:
					num4 = 98;
					goto case 248;
				case 248:
					array2[27] = (byte)num4;
					num = 37;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 4;
				case 409:
					array2[1] = (byte)num4;
					goto case 327;
				case 327:
					num4 = 155;
					num = 411;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 57;
				case 57:
					num3 = 142;
					num = 155;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 330;
				case 330:
					array[2] = (byte)num3;
					num = 174;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 338;
				case 338:
					array[2] = 246;
					goto case 176;
				case 176:
					num3 = 138;
					goto case 254;
				case 254:
					array[3] = (byte)num3;
					goto case 91;
				case 91:
					array[3] = 24;
					goto case 75;
				case 75:
					num3 = 36;
					num = 2;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 1;
				case 1:
					num3 = 38;
					num = 99;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 107;
				case 107:
					array[8] = (byte)num3;
					num = 214;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 32;
				case 32:
					array2[13] = (byte)num4;
					goto case 286;
				case 286:
					num4 = 82;
					goto case 120;
				case 120:
					array2[14] = (byte)num4;
					num = 267;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 354;
				case 354:
					num4 = 139;
					goto case 58;
				case 408:
					array2[30] = 59;
					goto case 54;
				case 406:
					num4 = 86;
					num = 64;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 106;
				case 106:
					array2[5] = (byte)num4;
					num = 29;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 114;
				case 114:
					num4 = 142;
					goto case 12;
				case 12:
					array2[5] = (byte)num4;
					goto case 370;
				case 370:
					array2[5] = 210;
					num = 277;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 91;
				case 404:
					num4 = 165;
					goto case 270;
				case 270:
					array2[19] = (byte)num4;
					num = 242;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 182;
				case 182:
					array2[1] = (byte)num4;
					goto case 287;
				case 287:
					num4 = 87;
					goto case 409;
				case 403:
					array2[11] = 100;
					goto case 77;
				case 77:
					num4 = 119;
					num = 260;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 78;
				case 78:
					array2[2] = (byte)num4;
					num = 97;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 255;
				case 255:
					array2[2] = 55;
					goto case 156;
				case 156:
					num4 = 84;
					num = 148;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 32;
				case 402:
					array2[2] = (byte)num4;
					goto case 342;
				case 342:
					num4 = 139;
					num = 78;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 28;
				case 28:
					num4 = 112;
					goto case 171;
				case 171:
					array2[3] = (byte)num4;
					goto case 111;
				case 111:
					array2[3] = 106;
					goto case 168;
				case 168:
					num4 = 144;
					goto case 239;
				case 239:
					array2[3] = (byte)num4;
					num = 4;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 145;
				case 145:
					num4 = 222;
					num = 81;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 92;
				case 92:
					array2[3] = (byte)num4;
					goto case 326;
				case 326:
					array2[4] = 185;
					goto case 125;
				case 125:
					array2[4] = 171;
					goto case 104;
				case 104:
					num4 = 89;
					goto case 362;
				case 362:
					array2[4] = (byte)num4;
					goto case 269;
				case 269:
					num4 = 89;
					goto case 212;
				case 212:
					array2[4] = (byte)num4;
					goto case 238;
				case 238:
					array2[4] = 178;
					goto case 309;
				case 309:
					num4 = 140;
					goto case 265;
				case 265:
					array2[5] = (byte)num4;
					goto case 406;
				case 401:
					num4 = 180;
					num = 72;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 30;
				case 30:
					array2[15] = 130;
					goto case 43;
				case 43:
					array2[15] = 137;
					goto case 263;
				case 263:
					array2[15] = 81;
					goto case 134;
				case 134:
					array2[15] = 92;
					num = 126;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 199;
				case 199:
					num4 = 187;
					num = 325;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 188;
				case 188:
					array[6] = 87;
					num = 51;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 50;
				case 50:
					num4 = 182;
					num = 36;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 102;
				case 399:
					if (num9 > 0)
					{
						goto case 142;
					}
					goto case 95;
				case 142:
					num11 = 0u;
					num = 71;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 181;
				case 181:
					num10 += num18;
					num = 140;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 61;
				case 95:
					num17 = (uint)num6;
					goto case 13;
				case 13:
					num10 += num18;
					num = 8;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 117;
				case 117:
					num11 = (uint)((array4[num17 + 3] << 24) | (array4[num17 + 2] << 16) | (array4[num17 + 1] << 8) | array4[num17]);
					goto case 155;
				case 155:
				case 312:
				{
					uint num22 = num10;
					num10 = 255u;
					uint num23 = num22;
					num23 ^= num23 << 2;
					num23 += 782534032;
					num23 ^= num23 << 17;
					num23 += 1181948218;
					num23 ^= num23 >> 15;
					num23 += 459487897;
					num23 = 1149358048 + num23;
					num10 = num22 + (uint)(double)num23;
					goto case 245;
				}
				case 245:
					if (num5 == num7 - 1)
					{
						num = 202;
						if (hwI8wUyTbCvBoCtDLA1() == null)
						{
							continue;
						}
						goto case 59;
					}
					goto case 64;
				case 59:
					array2[23] = (byte)num4;
					goto IL_01cc;
				case 64:
					num16 = num10 ^ num11;
					num = 310;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 233;
				case 233:
					num4 = 105;
					goto case 347;
				case 347:
					array2[12] = (byte)num4;
					goto case 369;
				case 369:
					num4 = 68;
					num = 201;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 153;
				case 153:
					array2[0] = (byte)num4;
					goto case 131;
				case 131:
					num4 = 107;
					num = 31;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 126;
				case 126:
					array2[1] = (byte)num4;
					num = 4;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 198;
				case 198:
					array2[1] = 151;
					goto case 384;
				case 384:
					array2[1] = 111;
					goto case 180;
				case 180:
					num4 = 132;
					goto case 182;
				case 398:
					num4 = 154;
					goto case 292;
				case 292:
					array2[12] = (byte)num4;
					num = 197;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 233;
				case 397:
					array2[13] = (byte)num4;
					goto case 343;
				case 343:
					num4 = 142;
					num = 124;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 186;
				case 186:
					array2[13] = (byte)num4;
					num = 175;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 257;
				case 257:
					num4 = 39;
					goto case 32;
				case 396:
					array2[3] = 176;
					goto case 28;
				case 395:
					array2[30] = (byte)num4;
					num = 18;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 408;
				case 394:
					num4 = 166;
					goto case 379;
				case 379:
					array2[0] = (byte)num4;
					goto case 41;
				case 41:
					num4 = 110;
					goto case 210;
				case 210:
					array2[0] = (byte)num4;
					num = 16;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 40;
				case 40:
					num4 = 36;
					num = 60;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 153;
				case 393:
					num4 = 166;
					goto case 62;
				case 62:
					array2[9] = (byte)num4;
					num = 306;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 40;
				case 392:
					array[2] = (byte)num3;
					num = 5;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 5;
				case 5:
					num3 = 167;
					goto case 365;
				case 365:
					array[2] = (byte)num3;
					num = 122;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 101;
				case 101:
					num3 = 118;
					goto case 318;
				case 318:
					array[14] = (byte)num3;
					num = 71;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 83;
				case 83:
					array[14] = 100;
					goto case 44;
				case 44:
					num3 = 119;
					goto case 256;
				case 256:
					array[14] = (byte)num3;
					num = 351;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 77;
				case 391:
					array2[21] = 138;
					goto case 197;
				case 197:
					num4 = 162;
					num = 324;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 53;
				case 390:
					array2[12] = (byte)num4;
					goto case 154;
				case 154:
					array2[12] = 153;
					goto case 398;
				case 389:
					num3 = 30;
					goto case 162;
				case 162:
					array[4] = (byte)num3;
					goto case 185;
				case 185:
					array[5] = 118;
					goto case 322;
				case 322:
					array[5] = 107;
					num = 92;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 97;
				case 97:
					num3 = 142;
					num = 117;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 190;
				case 190:
					array[5] = (byte)num3;
					goto case 274;
				case 274:
					array[5] = 162;
					goto case 208;
				case 208:
					array[5] = 236;
					goto case 188;
				case 387:
					num2 = 0;
					num = 226;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 99;
				case 99:
					array[9] = 197;
					num = 88;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 77;
				case 386:
					num4 = 145;
					num = 236;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto IL_01b0;
				case 385:
					array2[20] = 35;
					num = 229;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 132;
				case 132:
					array5[num6 + 3] = (byte)((num16 & 0xFF000000u) >> 24);
					goto case 86;
				case 86:
				case 317:
					num5++;
					num = 94;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 13;
				case 382:
					goto IL_0df0;
				case 224:
					goto IL_0df8;
				case 296:
					goto IL_0e1e;
				case 228:
					goto IL_0e2c;
				case 381:
					array[3] = (byte)num3;
					num = 8;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 5;
				case 380:
					array2[16] = 133;
					goto case 331;
				case 331:
					num4 = 52;
					goto case 241;
				case 241:
					array2[16] = (byte)num4;
					goto case 298;
				case 298:
					num4 = 100;
					goto case 315;
				case 315:
					array2[17] = (byte)num4;
					num = 109;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 63;
				case 63:
					array[9] = (byte)num3;
					goto case 99;
				case 378:
					array2[13] = 79;
					goto case 159;
				case 159:
					array2[13] = 137;
					goto case 303;
				case 303:
					num4 = 102;
					goto case 397;
				case 377:
					array2[6] = (byte)num4;
					goto case 308;
				case 308:
					num4 = 214;
					goto case 237;
				case 237:
					array2[6] = (byte)num4;
					num = 30;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 52;
				case 52:
					array2[7] = 168;
					goto IL_0fd5;
				case 350:
					goto IL_0f33;
				case 316:
					goto IL_0f3c;
				case 20:
					goto IL_0f4a;
				case 164:
					goto IL_0f63;
				case 166:
					goto IL_0f71;
				case 146:
					goto IL_0f80;
				case 89:
					goto IL_0f96;
				case 65:
					goto IL_0fa5;
				case 337:
					goto IL_0fb1;
				case 123:
					goto IL_0fb7;
				case 282:
					goto IL_0fd5;
				case 376:
					array[15] = (byte)num3;
					goto case 305;
				case 305:
					array7 = array;
					num = 355;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 113;
				case 113:
					array2[10] = (byte)num4;
					goto case 108;
				case 108:
					array2[10] = 89;
					num = 35;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 34;
				case 34:
					array2[19] = 51;
					goto case 404;
				case 371:
					array2[8] = (byte)num4;
					goto case 230;
				case 230:
					num4 = 20;
					goto case 278;
				case 278:
					array2[8] = (byte)num4;
					num = 393;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 223;
				case 223:
					num4 = 139;
					num = 279;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 226;
				case 226:
					if (num5 == num7 - 1)
					{
						goto case 399;
					}
					goto case 95;
				case 368:
					array2[24] = 123;
					num = 11;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 8;
				case 8:
					array[4] = 175;
					goto case 333;
				case 333:
					array[4] = 118;
					goto case 389;
				case 364:
					array[15] = 154;
					num = 276;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 176;
				case 363:
					num18 = 0u;
					goto case 251;
				case 251:
					num11 = 0u;
					goto case 295;
				case 295:
					if (num9 > 0)
					{
						num = 87;
						if (H582R2yCIX8tLn1A5pl())
						{
							continue;
						}
						goto case 86;
					}
					goto case 158;
				case 158:
					num17 = 0u;
					goto case 359;
				case 359:
					num5 = 0;
					num = 195;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto IL_036f;
				case 361:
					array2[29] = 120;
					goto case 93;
				case 93:
					num4 = 94;
					goto case 19;
				case 19:
					array2[30] = (byte)num4;
					num = 126;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 223;
				case 360:
					array2[21] = 197;
					num = 322;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 391;
				case 358:
					num8++;
					goto case 262;
				case 81:
					if (num8 <= 0)
					{
						goto case 184;
					}
					num = 335;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 173;
				case 184:
					num11 |= array4[^(1 + num8)];
					goto case 358;
				case 262:
				case 313:
					if (num8 >= num9)
					{
						goto case 155;
					}
					goto case 81;
				case 173:
					array2[8] = 111;
					num = 119;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 294;
				case 294:
					array2[8] = 191;
					goto case 304;
				case 163:
					num4 = 141;
					num = 371;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 304;
				case 304:
					array2[8] = 113;
					goto case 163;
				case 357:
					array2[11] = 95;
					num = 97;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 135;
				case 135:
					num4 = 128;
					goto case 390;
				case 356:
					array6[num21] = (byte)(array6[num21] ^ array7[num21]);
					goto case 143;
				case 143:
					num21++;
					goto case 246;
				case 246:
				case 253:
					if (num21 < array7.Length)
					{
						goto case 356;
					}
					num = 9;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 3;
				case 3:
					num4 = 149;
					num = 5;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 59;
				case 355:
					num20 = 1;
					goto case 207;
				case 207:
					num21 = 0;
					goto case 246;
				case 353:
					array2[11] = (byte)num4;
					goto case 357;
				case 352:
					num17 = (uint)(num14 * 4);
					goto case 105;
				case 105:
					num18 = (uint)((array6[num17 + 3] << 24) | (array6[num17 + 2] << 16) | (array6[num17 + 1] << 8) | array6[num17]);
					goto case 349;
				case 349:
					num19 = 255u;
					goto case 387;
				case 351:
					array[14] = 106;
					num = 24;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 289;
				case 289:
					num3 = 224;
					num = 43;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 79;
				case 79:
					array[14] = (byte)num3;
					goto case 222;
				case 222:
					array[15] = 169;
					goto case 291;
				case 291:
					array[15] = 153;
					goto case 364;
				case 345:
					array2[19] = (byte)num4;
					goto case 157;
				case 157:
					array2[19] = 179;
					goto case 196;
				case 196:
					num4 = 53;
					goto case 227;
				case 227:
					array2[19] = (byte)num4;
					goto case 341;
				case 341:
					array2[20] = 98;
					goto case 385;
				case 344:
					num4 = 79;
					goto case 323;
				case 323:
					array2[0] = (byte)num4;
					goto case 394;
				case 339:
					array2[24] = (byte)num4;
					goto case 215;
				case 215:
					array2[24] = 176;
					num = 11;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 55;
				case 55:
					array2[24] = 80;
					goto case 368;
				case 336:
					num4 = 49;
					goto case 268;
				case 268:
					array2[14] = (byte)num4;
					num = 30;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 12;
				case 335:
					num11 <<= 8;
					goto case 184;
				case 332:
					array2[20] = (byte)num4;
					num = 137;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 220;
				case 220:
					num4 = 139;
					num = 55;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 203;
				case 203:
					array2[20] = (byte)num4;
					goto case 360;
				case 329:
					array2[19] = (byte)num4;
					goto case 302;
				case 302:
					num4 = 217;
					goto case 345;
				case 328:
					array2[21] = 130;
					goto case 26;
				case 26:
					array2[22] = 145;
					num = 143;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 386;
				case 325:
					array2[15] = (byte)num4;
					num = 152;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto IL_02d9;
				case 324:
					array2[21] = (byte)num4;
					num = 100;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 137;
				case 137:
					array2[21] = 131;
					goto case 328;
				case 319:
					array[13] = (byte)num3;
					num = 25;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto IL_01cc;
				case 311:
					goto IL_1536;
				case 267:
					goto IL_153c;
				case 165:
					goto IL_154a;
				case 29:
					goto IL_1563;
				case 283:
					goto IL_1571;
				case 310:
					array5[num6] = (byte)(num16 & 0xFFu);
					goto case 149;
				case 149:
					array5[num6 + 1] = (byte)((num16 & 0xFF00) >> 8);
					goto case 98;
				case 98:
					array5[num6 + 2] = (byte)((num16 & 0xFF0000) >> 16);
					num = 29;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 132;
				case 306:
					num4 = 114;
					goto case 67;
				case 67:
					array2[9] = (byte)num4;
					goto case 189;
				case 189:
					array2[9] = 117;
					num = 24;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto IL_01a1;
				case 301:
					array[12] = 55;
					num = 16;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 9;
				case 9:
					array4 = array3;
					goto case 31;
				case 31:
					num9 = array4.Length % 4;
					goto case 194;
				case 194:
					num7 = array4.Length / 4;
					goto case 300;
				case 300:
					array5 = new byte[array4.Length];
					goto case 297;
				case 297:
					num13 = array6.Length / 4;
					num = 182;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 232;
				case 232:
					num10 = 0u;
					goto case 363;
				case 299:
					num3 = 146;
					goto case 63;
				case 288:
					array2[24] = (byte)num4;
					goto case 38;
				case 38:
					array2[25] = 85;
					goto case 96;
				case 96:
					num4 = 136;
					goto case 27;
				case 27:
					array2[25] = (byte)num4;
					goto case 70;
				case 70:
					array2[25] = 112;
					num = 1;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 50;
				case 285:
					array[12] = 119;
					goto case 90;
				case 90:
					num3 = 104;
					num = 150;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 169;
				case 169:
					array[12] = (byte)num3;
					goto case 301;
				case 284:
					num3 = 173;
					num = 381;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 48;
				case 48:
					num15 = 0;
					goto IL_0276;
				case 281:
					num3 = 52;
					goto case 21;
				case 21:
					array[9] = (byte)num3;
					goto case 299;
				case 280:
					array2[16] = (byte)num4;
					goto case 380;
				case 279:
					array2[30] = (byte)num4;
					num = 18;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 271;
				case 271:
					num4 = 112;
					goto case 395;
				case 277:
					array2[6] = 38;
					goto case 218;
				case 218:
					num4 = 100;
					goto case 377;
				case 276:
					num3 = 217;
					goto case 376;
				case 275:
					num14 = num5 % num13;
					num = 60;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 57;
				case 273:
					num4 = 40;
					num = 99;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 113;
				case 264:
					array2[0] = (byte)num4;
					num = 13;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 47;
				case 47:
					array2[0] = 85;
					goto case 344;
				case 261:
					num3 = 57;
					goto case 219;
				case 219:
					array[7] = (byte)num3;
					num = 243;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 75;
				case 260:
					array2[11] = (byte)num4;
					goto case 205;
				case 205:
					num4 = 106;
					goto case 353;
				case 252:
					array2[23] = 100;
					goto case 110;
				case 110:
					array2[23] = 102;
					num = 2;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 7;
				case 7:
					num4 = 115;
					goto case 56;
				case 56:
					array2[23] = (byte)num4;
					goto case 3;
				case 250:
					array[7] = (byte)num3;
					goto case 261;
				case 249:
					num3 = 167;
					goto case 160;
				case 160:
					array[7] = (byte)num3;
					goto case 183;
				case 183:
					num3 = 165;
					num = 250;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto IL_0f4a;
				case 247:
					array[0] = 85;
					num = 80;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 139;
				case 139:
					num3 = 125;
					goto case 234;
				case 234:
					array[1] = (byte)num3;
					goto case 24;
				case 24:
					num3 = 189;
					num = 130;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 112;
				case 112:
					array[13] = (byte)num3;
					goto case 18;
				case 18:
					num3 = 89;
					goto case 319;
				case 244:
					num4 = 119;
					goto case 46;
				case 46:
					array2[16] = (byte)num4;
					goto case 240;
				case 240:
					num4 = 176;
					goto case 280;
				case 243:
					num3 = 68;
					goto case 217;
				case 217:
					array[8] = (byte)num3;
					num = 1;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 1;
				case 242:
					num4 = 169;
					goto case 329;
				case 236:
					array2[22] = (byte)num4;
					goto case 179;
				case 179:
					array2[22] = 69;
					num = 173;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 252;
				case 229:
					num4 = 150;
					goto case 332;
				case 221:
					num3 = 120;
					num = 7;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 10;
				case 10:
					array[10] = (byte)num3;
					goto case 211;
				case 211:
					array[10] = 187;
					goto IL_19e9;
				case 15:
					goto IL_19e9;
				case 214:
					array[8] = 7;
					goto case 281;
				case 204:
					num12 = num10 ^ num11;
					num = 38;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 48;
				case 202:
					if (num9 <= 0)
					{
						goto case 64;
					}
					num = 204;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 70;
				case 201:
					array2[12] = (byte)num4;
					goto case 378;
				case 94:
				case 195:
					if (num5 >= num7)
					{
						goto IL_028c;
					}
					goto case 275;
				case 193:
					array2[28] = (byte)num4;
					goto case 85;
				case 85:
					num4 = 121;
					num = 4;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 3;
				case 191:
					array[0] = (byte)num3;
					num = 63;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 247;
				case 187:
					num3 = 166;
					num = 6;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 1;
				case 178:
					num3 = 40;
					goto case 112;
				case 175:
					num4 = 233;
					num = 6;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 288;
				case 161:
					array2[8] = 125;
					goto case 173;
				case 152:
					num4 = 50;
					goto case 66;
				case 66:
					array2[16] = (byte)num4;
					goto case 244;
				case 151:
					array[0] = 110;
					goto case 128;
				case 128:
					num3 = 85;
					num = 40;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 191;
				case 148:
					array2[3] = (byte)num4;
					goto case 396;
				case 144:
					array[1] = 31;
					goto case 118;
				case 118:
					num3 = 197;
					goto case 392;
				case 140:
					num8 = 0;
					num = 30;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 262;
				case 138:
					array[9] = 116;
					num = 221;
					if (H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 103;
				case 103:
					array[6] = 135;
					goto case 249;
				case 130:
					array[1] = (byte)num3;
					goto case 144;
				case 129:
					array2[7] = (byte)num4;
					goto case 161;
				case 122:
					array[2] = 48;
					goto case 187;
				case 115:
					goto IL_1bf4;
				case 109:
					num4 = 108;
					num = 341;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 410;
				case 100:
					array[3] = (byte)num3;
					num = 29;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 284;
				case 88:
					array[9] = 205;
					num = 36;
					if (hwI8wUyTbCvBoCtDLA1() != null)
					{
						continue;
					}
					goto case 138;
				case 87:
					num7++;
					goto case 158;
				case 74:
					num4 = 103;
					goto case 76;
				case 72:
					array2[10] = (byte)num4;
					goto case 403;
				case 60:
					num6 = num5 * 4;
					goto case 352;
				case 51:
					array[6] = 89;
					goto case 103;
				case 45:
					array2[10] = 128;
					num = 273;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 150;
				case 39:
					num3 = 142;
					num = 100;
					if (hwI8wUyTbCvBoCtDLA1() == null)
					{
						continue;
					}
					goto case 72;
				case 37:
					num4 = 218;
					goto case 193;
				case 35:
					array2[10] = 152;
					goto case 401;
				case 25:
					array[13] = 129;
					goto case 101;
				case 16:
					array[13] = 134;
					goto case 178;
				case 11:
					array2[24] = 103;
					goto case 175;
				case 6:
					array[2] = (byte)num3;
					num = 35;
					if (!H582R2yCIX8tLn1A5pl())
					{
						continue;
					}
					goto case 57;
				case 2:
					array[3] = (byte)num3;
					goto case 39;
				case 121:
					goto IL_240c;
				case 69:
					goto IL_245b;
				case 383:
					goto end_IL_245b;
				case 68:
				case 388:
					return;
				}
				break;
			}
			goto IL_0142;
			IL_1bf4:
			jGqjj9yexN2iyJO5cdF(oUjelCyF4lbYWsA4dre(object_), 0L);
			num = 136;
			if (H582R2yCIX8tLn1A5pl())
			{
				goto IL_0df0;
			}
			goto IL_1d92;
			IL_19e9:
			array[10] = 148;
			goto IL_1536;
			IL_1536:
			num3 = 118;
			goto IL_153c;
			IL_153c:
			array[10] = (byte)num3;
			goto IL_154a;
			IL_154a:
			num3 = 162;
			num = 8;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_1563;
			}
			goto IL_1d92;
			IL_1563:
			array[11] = (byte)num3;
			goto IL_1571;
			IL_1571:
			array[11] = 137;
			goto IL_0f96;
			IL_0fd5:
			array2[7] = 94;
			goto IL_0f33;
			IL_0f33:
			num4 = 150;
			goto IL_0f3c;
			IL_0f3c:
			array2[7] = (byte)num4;
			goto IL_0f4a;
			IL_0f4a:
			num4 = 176;
			num = 53;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_0f63;
			}
			goto IL_1d92;
			IL_0f63:
			array2[7] = (byte)num4;
			goto IL_0f71;
			IL_0f71:
			array2[7] = 156;
			goto IL_0f80;
			IL_0f80:
			num4 = 49;
			num = 129;
			if (!H582R2yCIX8tLn1A5pl())
			{
				goto IL_0f96;
			}
			goto IL_1d92;
			IL_0f96:
			array[11] = 150;
			goto IL_0fa5;
			IL_0fa5:
			array[11] = 124;
			goto IL_0fb1;
			IL_0fb1:
			num3 = 117;
			goto IL_0fb7;
			IL_0fb7:
			array[12] = (byte)num3;
			num = 285;
			if (!H582R2yCIX8tLn1A5pl())
			{
				goto IL_0fd5;
			}
			goto IL_1d92;
			IL_0df0:
			array8 = new byte[0];
			goto IL_0df8;
			IL_0df8:
			array3 = (byte[])XCB5YeyA7RfNRxR59EY(object_, (int)kftwqrySDYeIQU17rN1(oUjelCyF4lbYWsA4dre(object_)));
			num = 273;
			if (H582R2yCIX8tLn1A5pl())
			{
				goto IL_0e1e;
			}
			goto IL_1d92;
			IL_0e1e:
			array2 = new byte[32];
			goto IL_0e2c;
			IL_0e2c:
			num4 = 110;
			num = 264;
			if (!H582R2yCIX8tLn1A5pl())
			{
				goto IL_0142;
			}
			goto IL_1d92;
			IL_0142:
			num4 = 215;
			num = 28;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_015b;
			}
			goto IL_1d92;
			IL_015b:
			array2[28] = (byte)num4;
			goto IL_0169;
			IL_0169:
			num4 = 36;
			goto IL_016f;
			IL_016f:
			array2[29] = (byte)num4;
			goto IL_017d;
			IL_017d:
			num4 = 91;
			goto IL_0183;
			IL_0183:
			array2[29] = (byte)num4;
			num = 361;
			if (hwI8wUyTbCvBoCtDLA1() != null)
			{
				goto IL_01a1;
			}
			goto IL_1d92;
			IL_01a1:
			array2[9] = 162;
			goto IL_01b0;
			IL_01b0:
			array2[10] = 40;
			num = 45;
			if (hwI8wUyTbCvBoCtDLA1() != null)
			{
				goto IL_01cc;
			}
			goto IL_1d92;
			IL_01cc:
			num4 = 156;
			num = 143;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_01e5;
			}
			goto IL_1d92;
			IL_01e5:
			array2[23] = (byte)num4;
			num = 135;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_0203;
			}
			goto IL_1d92;
			IL_0203:
			num4 = 120;
			num = 339;
			if (hwI8wUyTbCvBoCtDLA1() != null)
			{
				goto IL_0276;
			}
			goto IL_1d92;
			IL_0276:
			if (num15 < num9)
			{
				goto IL_021b;
			}
			num = 317;
			if (!H582R2yCIX8tLn1A5pl())
			{
				goto IL_028c;
			}
			goto IL_1d92;
			IL_024c:
			array5[num6 + num15] = (byte)((num12 & num19) >> num2);
			num = 256;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_0270;
			}
			goto IL_1d92;
			IL_028c:
			array8 = array5;
			goto IL_0290;
			IL_0290:
			if (num20 == 0)
			{
				goto IL_0353;
			}
			num = 83;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_02a7;
			}
			goto IL_1d92;
			IL_0270:
			num15++;
			goto IL_0276;
			IL_02a7:
			if (num20 != 1)
			{
				goto IL_02ac;
			}
			goto IL_02c3;
			IL_02ac:
			XGvLosJ5Ax = kMcno8yIp2fk6E0FSDR(HaA7v1ypMJZF9YdA6Gw(array8, 0u));
			goto IL_036f;
			IL_02c3:
			memoryStream = new MemoryStream();
			goto IL_02ca;
			IL_02ca:
			deflateStream = new DeflateStream(new MemoryStream(array8), CompressionMode.Decompress);
			goto IL_02d9;
			IL_02d9:
			try
			{
				uTfhRZysBuLrQTYvaTH(deflateStream, memoryStream);
				if (hwI8wUyTbCvBoCtDLA1() == null)
				{
					switch (0)
					{
					}
				}
			}
			finally
			{
				if (deflateStream == null)
				{
					if (H582R2yCIX8tLn1A5pl())
					{
						switch (1)
						{
						case 1:
						case 2:
							goto end_IL_02fd;
						}
					}
				}
				yEF5lRywpeOrYfiQEgQ(deflateStream);
				end_IL_02fd:;
			}
			goto IL_0329;
			IL_0329:
			XGvLosJ5Ax = kMcno8yIp2fk6E0FSDR(lHxobLyahFee8rba83I(memoryStream));
			goto IL_033a;
			IL_033a:
			krORlGyVt96CIOeNrPw(memoryStream);
			num = 237;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_036f;
			}
			goto IL_1d92;
			IL_0353:
			XGvLosJ5Ax = kMcno8yIp2fk6E0FSDR(array8);
			num = 7;
			if (H582R2yCIX8tLn1A5pl())
			{
				goto IL_036f;
			}
			goto IL_1d92;
			IL_036f:
			pTjLNi94Ct = (string[])sqeSOcyf9d0QGfNaXlo((Assembly)XGvLosJ5Ax);
			num = 33;
			if (H582R2yCIX8tLn1A5pl())
			{
				break;
			}
			goto IL_1d92;
			IL_021b:
			if (num15 > 0)
			{
				goto IL_0220;
			}
			goto IL_024c;
			IL_0220:
			num19 <<= 8;
			num = 87;
			if (hwI8wUyTbCvBoCtDLA1() == null)
			{
				goto IL_0236;
			}
			goto IL_1d92;
			continue;
			end_IL_245b:
			break;
		}
		j8gLHYpNba = true;
	}

	internal static string[] HVFLxutmoh(Assembly assembly_0)
	{
		if (assembly_0 == typeof(InUQFsLWwvd0eKLmlrc).Assembly)
		{
			if (!j8gLHYpNba)
			{
				DWQL8KNbJg();
			}
			List<string> list = new List<string>();
			list.AddRange(assembly_0.GetManifestResourceNames());
			list.AddRange(((Assembly)XGvLosJ5Ax).GetManifestResourceNames());
			return list.ToArray();
		}
		return assembly_0.GetManifestResourceNames();
	}

	private static Assembly WCBLMUvsCS(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (!j8gLHYpNba)
		{
			DWQL8KNbJg();
		}
		string name = resolveEventArgs_0.Name;
		int num = 0;
		while (true)
		{
			if (num < pTjLNi94Ct.Length)
			{
				if (pTjLNi94Ct[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)XGvLosJ5Ax;
	}

	public InUQFsLWwvd0eKLmlrc()
	{
		AppDomain.CurrentDomain.ResourceResolve += WCBLMUvsCS;
		G52OZvLpTmMvK1xL9qs.SPbLP0A2fp();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!Ik2Lb8Ktxh)
		{
			Ik2Lb8Ktxh = true;
			new InUQFsLWwvd0eKLmlrc();
		}
	}

	internal static Type tqrp5lyJGnSAASLoLO6(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object HHrXfvyinUgJ1gZsg15(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object oUjelCyF4lbYWsA4dre(object object_0)
	{
		return ((sMk8wArgfJX2hbRXDA.vm4PJULCoMilxHZamU9)object_0).m9OIO8Q0EK();
	}

	internal static void jGqjj9yexN2iyJO5cdF(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long kftwqrySDYeIQU17rN1(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object XCB5YeyA7RfNRxR59EY(object object_0, int int_0)
	{
		return ((sMk8wArgfJX2hbRXDA.vm4PJULCoMilxHZamU9)object_0).C9WLTUhMOM(int_0);
	}

	internal static object kMcno8yIp2fk6E0FSDR(object object_0)
	{
		return iiaMqOLvW7dpILTfbHw.JX3jjMYxAj((byte[])object_0);
	}

	internal static void uTfhRZysBuLrQTYvaTH(object object_0, object object_1)
	{
		((Stream)object_0).CopyTo((Stream)object_1);
	}

	internal static void yEF5lRywpeOrYfiQEgQ(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object lHxobLyahFee8rba83I(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void krORlGyVt96CIOeNrPw(object object_0)
	{
		((Stream)object_0).Dispose();
	}

	internal static object HaA7v1ypMJZF9YdA6Gw(object object_0, uint uint_0)
	{
		return iiaMqOLvW7dpILTfbHw.CVWjYWC52a((byte[])object_0, uint_0);
	}

	internal static object sqeSOcyf9d0QGfNaXlo(object object_0)
	{
		return ((Assembly)object_0).GetManifestResourceNames();
	}

	internal static bool H582R2yCIX8tLn1A5pl()
	{
		return (object)null == null;
	}

	internal static object hwI8wUyTbCvBoCtDLA1()
	{
		return null;
	}
}
