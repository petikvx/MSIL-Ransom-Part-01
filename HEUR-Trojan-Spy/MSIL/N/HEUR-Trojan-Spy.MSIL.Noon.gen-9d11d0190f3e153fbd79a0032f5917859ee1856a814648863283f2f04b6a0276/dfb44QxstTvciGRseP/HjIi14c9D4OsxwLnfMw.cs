using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;

namespace dfb44QxstTvciGRseP;

internal class HjIi14c9D4OsxwLnfMw
{
	private enum bgysBccM2D8vT2fKA7K
	{

	}

	internal class Pk6yu5cknjiUefapcSv
	{
		private unsafe static uint VsZRgpUUW6(void* pVoid_0, uint uint_0)
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

		private unsafe static bool ckDRV8ndnu(void* pVoid_0, void* pVoid_1, uint uint_0)
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

		private unsafe static void DTbROW1hFj(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = byte_0;
			}
		}

		private unsafe static void yH6RdvODQP(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = ((byte*)pVoid_1)[(int)num];
			}
		}

		private unsafe static void d6LRbLU64c(byte* pByte_0, byte* pByte_1, uint uint_0)
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
				yH6RdvODQP(pByte_0, pByte_1, uint_0);
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

		private unsafe static uint tc4RWub2ZX(byte[] byte_0, uint uint_0, bgysBccM2D8vT2fKA7K bgysBccM2D8vT2fKA7K_0)
		{
			uint num = 0u;
			fixed (byte* ptr = byte_0)
			{
				num = *(uint*)(ptr + (int)uint_0 + (nint)bgysBccM2D8vT2fKA7K_0 * (nint)4);
			}
			return num;
		}

		public static uint DllRUj0cML(byte[] byte_0, uint uint_0)
		{
			return GmtPtgR7iIPls4re0em(byte_0, uint_0, (bgysBccM2D8vT2fKA7K)3);
		}

		private unsafe static uint PWIRxYjNsn(byte[] byte_0, uint uint_0, byte[] byte_1)
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
					byte* ptr7 = ptr4 + (int)VsZRgpUUW6(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (VsZRgpUUW6(ptr6 + 4, 4u) != 1)
					{
						yH6RdvODQP(ptr4, ptr2 + (int)num, VsZRgpUUW6(ptr6 + 3, 4u));
						return VsZRgpUUW6(ptr6 + 3, 4u);
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
							num2 = VsZRgpUUW6(ptr3, 4u);
							ptr3 += 4;
						}
						uint num3 = VsZRgpUUW6(ptr3, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								d6LRbLU64c(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								d6LRbLU64c(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								d6LRbLU64c(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								d6LRbLU64c(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								d6LRbLU64c(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 4;
							}
							else
							{
								byte byte_2 = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFFu;
								DTbROW1hFj(ptr5, byte_2, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
						}
						else
						{
							d6LRbLU64c(ptr5, ptr3, 4u);
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

		internal static object lZ7R4ErPjd(byte[] byte_0)
		{
			return WolpNaRZZ70DlWyBiRD(typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }), null, new object[1] { byte_0 });
		}

		public static byte[] QeARvUDnbh(byte[] byte_0, uint uint_0)
		{
			uint num = DllRUj0cML(byte_0, uint_0);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				PWIRxYjNsn(byte_0, uint_0, array);
			}
			return array;
		}

		internal static uint GmtPtgR7iIPls4re0em(object object_0, uint uint_0, bgysBccM2D8vT2fKA7K bgysBccM2D8vT2fKA7K_0)
		{
			return tc4RWub2ZX((byte[])object_0, uint_0, bgysBccM2D8vT2fKA7K_0);
		}

		internal static object WolpNaRZZ70DlWyBiRD(object object_0, object object_1, object object_2)
		{
			return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
		}
	}

	private static string[] QqrRNJ5cvi = new string[0];

	private static object yDGRm4vMuj = null;

	private static bool mcvRknUfeC = false;

	private static bool iYfR8M7mu5 = false;

	private static void eTeRQ3vDVv()
	{
		int num = 273;
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		int num5 = default(int);
		byte[] array3 = default(byte[]);
		int num7 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		byte[] array = default(byte[]);
		uint num26 = default(uint);
		uint num13 = default(uint);
		uint num14 = default(uint);
		int num20 = default(int);
		int num12 = default(int);
		int num10 = default(int);
		uint num24 = default(uint);
		int num25 = default(int);
		byte[] array4 = default(byte[]);
		int num8 = default(int);
		byte[] array8 = default(byte[]);
		int num23 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num19 = default(int);
		int num22 = default(int);
		uint num15 = default(uint);
		uint num21 = default(uint);
		int num18 = default(int);
		uint num9 = default(uint);
		int num11 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num4 = default(int);
		int num27 = default(int);
		uint num28 = default(uint);
		int num29 = default(int);
		while (!mcvRknUfeC)
		{
			while (true)
			{
				InRL4fclTJhCYsrjsta.ibtnH5ca3SUQeLijsOE object_ = new InRL4fclTJhCYsrjsta.ibtnH5ca3SUQeLijsOE((Stream)PrvpS7q8f6F3O90Y9F(uu7t2UsuZiGnQqbqdS(typeof(InRL4fclTJhCYsrjsta).TypeHandle).Assembly, "qaaJHuOY6LVHmtsw7y.c7XiLoFiDEl84oEtaj"));
				while (true)
				{
					IL_2474:
					KIEU0ETr0GnMP51HHg(hDxKd45vFkxFTt6cuO(object_), 0L);
					int num2 = 180;
					if (K6uKVP0eThfULdK1jZ() != null)
					{
						goto IL_1738;
					}
					goto IL_1e3a;
					IL_1e3a:
					while (true)
					{
						switch (num2)
						{
						case 395:
							array2[0] = (byte)num6;
							num2 = 275;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 394:
							num5 = 229;
							goto case 393;
						case 393:
							array3[30] = (byte)num5;
							goto case 263;
						case 263:
							array3[31] = 158;
							goto case 79;
						case 79:
							array3[31] = 130;
							num2 = 146;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 325;
						case 325:
							array3[31] = 155;
							goto case 182;
						case 182:
							num5 = 99;
							goto case 293;
						case 293:
							array3[31] = (byte)num5;
							num = 19;
							goto case 19;
						case 19:
							num7 = 133;
							num2 = 107;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 392:
							deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress);
							num2 = 381;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 391:
							array3[8] = 232;
							goto case 102;
						case 102:
							num5 = 98;
							num2 = 71;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 390:
							array2[14] = (byte)num6;
							num = 17;
							goto case 17;
						case 17:
							array2[14] = 15;
							goto case 12;
						case 12:
							num6 = 150;
							num2 = 78;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 298;
						case 298:
							array2[15] = (byte)num6;
							goto case 123;
						case 123:
							num6 = 122;
							goto case 73;
						case 73:
							array2[15] = (byte)num6;
							num2 = 194;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 389:
							array2[7] = (byte)num6;
							goto case 225;
						case 225:
							num6 = 142;
							goto case 129;
						case 129:
							array2[8] = (byte)num6;
							goto case 253;
						case 253:
							array2[8] = 106;
							goto case 152;
						case 152:
							num6 = 72;
							goto case 97;
						case 97:
							array2[8] = (byte)num6;
							goto case 205;
						case 205:
							num6 = 115;
							num2 = 196;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 388:
							array3[26] = (byte)num7;
							goto case 144;
						case 144:
							array3[26] = 119;
							goto case 202;
						case 202:
							array3[27] = 126;
							num2 = 365;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 163;
						case 163:
							array3[28] = 105;
							num2 = 110;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 66;
						case 66:
							array2[6] = (byte)num6;
							goto case 133;
						case 133:
							array2[6] = 97;
							num2 = 146;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 387:
							array3[5] = 86;
							goto case 279;
						case 279:
							array3[5] = 133;
							num2 = 230;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 386:
							array3[12] = 153;
							num2 = 274;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 385:
							num6 = 143;
							goto case 328;
						case 328:
							array2[7] = (byte)num6;
							goto case 157;
						case 157:
							array2[7] = 139;
							num2 = 359;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 197;
						case 197:
							num6 = 116;
							num2 = 66;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 384:
							array2[13] = (byte)num6;
							num2 = 299;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 383:
							array3[14] = 162;
							goto case 61;
						case 61:
							array3[14] = 118;
							num = 170;
							goto case 170;
						case 170:
							num7 = 171;
							goto case 117;
						case 117:
							array3[14] = (byte)num7;
							num2 = 34;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 35;
						case 35:
							array3[15] = 169;
							goto case 372;
						case 372:
							num7 = 54;
							goto case 6;
						case 6:
							array3[15] = (byte)num7;
							goto case 212;
						case 212:
							num7 = 57;
							num2 = 300;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 17;
						case 382:
							num6 = 19;
							goto case 175;
						case 175:
							array2[9] = (byte)num6;
							num2 = 122;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 77;
						case 77:
							array3[27] = (byte)num7;
							goto case 187;
						case 187:
							array3[27] = 0;
							goto case 57;
						case 57:
							num7 = 156;
							goto case 256;
						case 256:
							array3[28] = (byte)num7;
							goto case 150;
						case 150:
							array3[28] = 128;
							num2 = 245;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 301;
						case 301:
							num5 = 97;
							goto case 25;
						case 25:
							array3[28] = (byte)num5;
							goto case 163;
						case 380:
							array2[4] = (byte)num6;
							num = 161;
							goto case 161;
						case 161:
							array2[4] = 169;
							goto case 231;
						case 231:
							num6 = 103;
							num2 = 39;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 40;
						case 40:
							array2[4] = (byte)num6;
							num2 = 127;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 25;
						case 379:
							array2[6] = (byte)num6;
							goto case 221;
						case 221:
							array2[7] = 136;
							goto case 385;
						case 378:
							break;
						case 341:
							goto IL_04c9;
						case 247:
							goto IL_04cc;
						case 213:
							goto IL_04cf;
						case 85:
							goto IL_04e2;
						case 319:
							goto IL_04e7;
						case 155:
							goto IL_04fd;
						case 258:
							goto IL_0510;
						case 219:
						case 245:
							goto IL_0513;
						case 184:
							goto IL_052e;
						case 120:
							goto IL_0535;
						case 135:
							goto IL_053b;
						case 227:
							goto IL_0551;
						case 217:
							goto IL_057c;
						case 46:
							goto IL_0583;
						case 250:
							goto IL_0586;
						case 288:
							goto IL_058e;
						case 340:
							goto IL_0593;
						case 246:
							goto IL_05a6;
						case 366:
							goto IL_05bd;
						case 48:
							goto IL_05d5;
						case 336:
							goto IL_05d9;
						case 377:
							num5 = 88;
							num2 = 159;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 168;
						case 168:
							array3[18] = (byte)num5;
							num2 = 1;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 376:
							array3[18] = (byte)num5;
							goto case 291;
						case 291:
							num7 = 179;
							goto case 191;
						case 191:
							array3[18] = (byte)num7;
							goto case 254;
						case 254:
							num5 = 101;
							goto case 226;
						case 226:
							array3[18] = (byte)num5;
							goto case 377;
						case 375:
							array3[12] = 118;
							goto case 26;
						case 26:
							array3[12] = 107;
							goto case 132;
						case 132:
							array3[12] = 101;
							num2 = 93;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 374:
							num7 = 100;
							num2 = 346;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 373:
							array3[29] = 31;
							num2 = 174;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 371:
							array3[7] = 136;
							goto case 255;
						case 255:
							array3[7] = 92;
							num2 = 14;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 16;
						case 16:
							array3[7] = 65;
							goto case 374;
						case 370:
							num5 = 108;
							num = 89;
							goto case 89;
						case 89:
							array3[23] = (byte)num5;
							goto case 7;
						case 7:
							num7 = 30;
							num2 = 72;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 369:
							array3[0] = (byte)num5;
							goto case 199;
						case 199:
							num7 = 101;
							num2 = 312;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 367:
							num5 = 124;
							goto case 15;
						case 15:
							array3[6] = (byte)num5;
							goto case 62;
						case 62:
							num7 = 71;
							num2 = 119;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 365:
							array3[27] = 61;
							num2 = 338;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 39;
						case 39:
							num6 = 23;
							goto case 32;
						case 32:
							array2[1] = (byte)num6;
							num2 = 0;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 364:
							array3[20] = (byte)num7;
							goto case 248;
						case 248:
							array3[20] = 4;
							num2 = 211;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 363:
							array2[6] = 114;
							goto case 197;
						case 362:
							num5 = 128;
							num2 = 124;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 39;
						case 361:
							array3[15] = 138;
							goto case 58;
						case 58:
							num5 = 139;
							num2 = 189;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 347;
						case 347:
							array3[16] = (byte)num5;
							goto case 29;
						case 29:
							array3[16] = 90;
							goto case 283;
						case 283:
							array3[16] = 27;
							num = 257;
							goto case 257;
						case 257:
							array3[17] = 73;
							num2 = 303;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 159;
						case 159:
							num26 = num13 ^ num14;
							num2 = 280;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 11:
						case 360:
							if (num20 >= num12)
							{
								goto case 101;
							}
							goto case 316;
						case 101:
						case 147:
							num10++;
							num = 245;
							goto IL_0513;
						case 316:
							if (num20 > 0)
							{
								num = 214;
								goto case 214;
							}
							goto case 267;
						case 214:
							num24 <<= 8;
							goto case 235;
						case 235:
							num25 += 8;
							num2 = 33;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 267;
						case 267:
							array4[num8 + num20] = (byte)((num26 & num24) >> num25);
							num2 = 315;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 359:
							array2[7] = 154;
							num2 = 30;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 358:
							num7 = 132;
							num2 = 98;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 357:
							array3[11] = (byte)num7;
							num2 = 104;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 102;
						case 356:
							array3[1] = (byte)num7;
							num2 = 321;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 355:
							array2[11] = 92;
							goto case 287;
						case 287:
							num6 = 129;
							num = 206;
							goto case 206;
						case 206:
							array2[11] = (byte)num6;
							num2 = 222;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 354:
							num7 = 118;
							goto case 183;
						case 183:
							array3[11] = (byte)num7;
							num2 = 286;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 353:
							num7 = 116;
							num = 364;
							goto case 364;
						case 352:
							array3[19] = 181;
							num = 345;
							goto case 345;
						case 345:
							num7 = 173;
							num2 = 21;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 44;
						case 44:
							array3[19] = (byte)num7;
							num2 = 128;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 106;
						case 112:
							array8[num23] = (byte)(array8[num23] ^ array5[num23]);
							goto case 179;
						case 179:
							num23++;
							goto case 106;
						case 106:
						case 265:
							if (num23 < array5.Length)
							{
								goto case 112;
							}
							goto case 224;
						case 224:
							array7 = array6;
							goto case 68;
						case 68:
							num12 = array7.Length % 4;
							num2 = 76;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 47;
						case 47:
							num7 = 250;
							goto case 49;
						case 49:
							array3[17] = (byte)num7;
							goto case 348;
						case 348:
							array3[18] = 143;
							num2 = 8;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 351:
							array8 = array3;
							goto case 134;
						case 134:
							array2 = new byte[16];
							goto case 240;
						case 240:
							array2[0] = 114;
							num2 = 47;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 238;
						case 238:
							num6 = 135;
							goto case 395;
						case 350:
							num5 = 112;
							goto case 200;
						case 200:
							array3[2] = (byte)num5;
							goto case 45;
						case 45:
							array3[2] = 180;
							goto case 65;
						case 65:
							array3[2] = 103;
							goto case 317;
						case 317:
							num7 = 147;
							goto case 111;
						case 111:
							array3[3] = (byte)num7;
							num = 4;
							goto case 4;
						case 4:
							array3[3] = 153;
							goto case 83;
						case 83:
							array3[3] = 12;
							num2 = 216;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 349:
							array3[30] = (byte)num7;
							goto case 394;
						case 346:
							array3[8] = (byte)num7;
							num = 115;
							goto case 115;
						case 115:
							array3[8] = 170;
							num2 = 1;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 391;
						case 344:
							num13 = 255u;
							num2 = 167;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto default;
						default:
							array2[2] = 136;
							goto case 78;
						case 78:
							array2[2] = 122;
							goto case 108;
						case 108:
							num6 = 6;
							goto case 55;
						case 55:
							array2[2] = (byte)num6;
							num2 = 75;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 343:
							array3[24] = 162;
							goto case 201;
						case 201:
							array3[24] = 3;
							goto case 51;
						case 51:
							array3[24] = 214;
							num2 = 82;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 37;
						case 37:
							array2[12] = 162;
							num2 = 2;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 2;
						case 2:
							array2[12] = 123;
							num = 67;
							goto case 67;
						case 67:
							array2[12] = 74;
							num = 324;
							goto case 324;
						case 324:
							array2[12] = 204;
							goto case 306;
						case 306:
							num6 = 96;
							num2 = 151;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 384;
						case 342:
							array3[9] = (byte)num7;
							num2 = 177;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 339:
							array3[30] = (byte)num7;
							num2 = 204;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 338:
							num7 = 126;
							goto case 77;
						case 337:
							array3[6] = (byte)num5;
							goto case 367;
						case 335:
							array2[9] = 72;
							goto case 382;
						case 334:
							array3[24] = 163;
							num2 = 343;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 149;
						case 149:
							num19 = 1;
							num2 = 318;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 333:
							num6 = 144;
							num2 = 63;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 380;
						case 332:
							num5 = 136;
							goto case 232;
						case 232:
							array3[0] = (byte)num5;
							goto case 314;
						case 314:
							array3[0] = 103;
							goto case 268;
						case 268:
							num7 = 168;
							num = 311;
							goto case 311;
						case 311:
							array3[1] = (byte)num7;
							num2 = 262;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 331:
							array3[21] = 82;
							num2 = 72;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 195;
						case 195:
							num7 = 105;
							goto case 276;
						case 276:
							array3[22] = (byte)num7;
							num = 189;
							goto case 189;
						case 189:
							array3[22] = 29;
							num2 = 92;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 84;
						case 84:
							array3[4] = (byte)num5;
							goto case 186;
						case 186:
							array3[4] = 124;
							goto case 21;
						case 21:
							num5 = 90;
							num2 = 302;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 152;
						case 329:
							num5 = 156;
							goto case 337;
						case 327:
							array3[9] = 142;
							goto case 118;
						case 118:
							array3[9] = 90;
							num2 = 97;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 190;
						case 190:
							num7 = 54;
							num = 342;
							goto case 342;
						case 326:
							array2[5] = (byte)num6;
							num = 165;
							goto case 165;
						case 165:
							array2[5] = 130;
							goto case 237;
						case 237:
							array2[5] = 198;
							goto case 215;
						case 215:
							num6 = 158;
							goto case 290;
						case 290:
							array2[6] = (byte)num6;
							goto case 284;
						case 284:
							num6 = 141;
							goto case 90;
						case 90:
							array2[6] = (byte)num6;
							goto case 363;
						case 323:
							num7 = 112;
							goto case 304;
						case 304:
							array3[13] = (byte)num7;
							num = 10;
							goto case 10;
						case 10:
							array3[13] = 220;
							goto case 95;
						case 95:
							array3[14] = 104;
							goto case 234;
						case 234:
							array3[14] = 117;
							num2 = 242;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 173;
						case 173:
							num6 = 219;
							goto case 310;
						case 310:
							array2[11] = (byte)num6;
							num2 = 148;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 355;
						case 322:
							array2[3] = (byte)num6;
							goto case 285;
						case 285:
							num6 = 118;
							num2 = 4;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 86;
						case 86:
							array2[3] = (byte)num6;
							num2 = 44;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 96;
						case 96:
							num6 = 90;
							goto case 136;
						case 136:
							array2[3] = (byte)num6;
							goto case 36;
						case 36:
							array2[4] = 147;
							num2 = 333;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 321:
							num7 = 240;
							num2 = 18;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 320:
							array3[6] = 157;
							goto case 371;
						case 318:
							num23 = 0;
							num2 = 106;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 315:
							num20++;
							num = 360;
							goto case 11;
						case 313:
							if (num22 <= 0)
							{
								goto case 266;
							}
							goto case 99;
						case 266:
							num14 |= array7[^(1 + num22)];
							goto case 142;
						case 142:
							num22++;
							num = 70;
							goto case 23;
						case 99:
							num14 <<= 8;
							num = 266;
							goto case 266;
						case 23:
						case 70:
							if (num22 < num12)
							{
								goto case 313;
							}
							goto case 198;
						case 198:
						case 271:
							num15 = num13;
							goto case 344;
						case 312:
							array3[0] = (byte)num7;
							num2 = 332;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 309:
							array2[13] = 35;
							goto case 125;
						case 125:
							num6 = 235;
							goto case 218;
						case 218:
							array2[14] = (byte)num6;
							num2 = 139;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 308:
							num14 = (uint)((array7[num21 + 3] << 24) | (array7[num21 + 2] << 16) | (array7[num21 + 1] << 8) | array7[num21]);
							num2 = 98;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 198;
						case 307:
							array2[5] = (byte)num6;
							num = 5;
							goto case 5;
						case 5:
							array2[5] = 144;
							num2 = 203;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 305:
							goto IL_11fd;
						case 303:
							array3[17] = 140;
							num2 = 193;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 302:
							array3[4] = (byte)num5;
							num2 = 18;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 24;
						case 24:
							num5 = 86;
							goto case 116;
						case 116:
							array3[4] = (byte)num5;
							num2 = 158;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 300:
							array3[15] = (byte)num7;
							num = 361;
							goto case 361;
						case 299:
							array2[13] = 150;
							goto case 64;
						case 64:
							num6 = 102;
							num2 = 154;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 297:
							array2[10] = (byte)num6;
							goto case 69;
						case 69:
							num6 = 18;
							goto case 270;
						case 270:
							array2[10] = (byte)num6;
							goto case 80;
						case 80:
							array2[11] = 158;
							num = 173;
							goto case 173;
						case 295:
							array3[20] = 23;
							goto case 353;
						case 292:
							array3[25] = (byte)num7;
							num2 = 34;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 289:
							num6 = 132;
							goto case 307;
						case 286:
							num7 = 144;
							goto case 357;
						case 282:
							num6 = 200;
							num2 = 162;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 280:
							num20 = 0;
							goto case 11;
						case 278:
							num18 = num19;
							num2 = 228;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 277:
							array3 = new byte[32];
							num2 = 239;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 275:
							array2[0] = 194;
							goto case 153;
						case 153:
							num6 = 121;
							num = 249;
							goto case 249;
						case 249:
							array2[1] = (byte)num6;
							goto case 20;
						case 20:
							array2[1] = 84;
							num = 261;
							goto case 261;
						case 261:
							array2[1] = 96;
							goto case 14;
						case 14:
							array2[1] = 116;
							num2 = 39;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 274:
							num5 = 147;
							num2 = 176;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 269:
							array3[13] = (byte)num7;
							num2 = 94;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 264:
							array3[13] = (byte)num7;
							goto case 81;
						case 81:
							array3[13] = 151;
							num2 = 54;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 323;
						case 262:
							array3[1] = 61;
							num = 164;
							goto case 164;
						case 164:
							num7 = 90;
							goto case 356;
						case 260:
							array3[0] = (byte)num7;
							num = 145;
							goto case 145;
						case 145:
							num5 = 116;
							goto case 369;
						case 259:
							num6 = 220;
							num2 = 389;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 252:
							array4[num8 + 1] = (byte)((num9 & 0xFF00) >> 8);
							goto case 3;
						case 3:
							array4[num8 + 2] = (byte)((num9 & 0xFF0000) >> 16);
							num2 = 113;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 251:
							array3[23] = 154;
							goto case 370;
						case 244:
							array3[17] = 92;
							num2 = 104;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 143;
						case 143:
							array3[17] = 123;
							num2 = 39;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 47;
						case 242:
							array3[14] = 140;
							goto case 383;
						case 241:
							array3[2] = 100;
							goto case 350;
						case 239:
							num7 = 68;
							goto case 260;
						case 236:
							num6 = 121;
							goto case 297;
						case 233:
							num13 = num15;
							num2 = 131;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 230:
							num5 = 90;
							num2 = 178;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 229:
							array3[17] = (byte)num5;
							goto case 244;
						case 228:
							switch (num18)
							{
							case 1:
								goto IL_1621;
							case 0:
								goto IL_24e0;
							}
							num2 = 56;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 54:
							goto IL_1621;
						case 223:
							array3[19] = (byte)num7;
							num = 295;
							goto case 295;
						case 222:
							array2[11] = 159;
							num2 = 208;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 53;
						case 53:
							array3[6] = 86;
							num2 = 329;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 220:
							num6 = 50;
							num2 = 171;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 99;
						case 216:
							num5 = 66;
							goto case 84;
						case 211:
							num5 = 142;
							num2 = 160;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 210:
							array3[22] = (byte)num7;
							goto case 251;
						case 209:
							array3[19] = 132;
							goto case 148;
						case 148:
							array3[19] = 13;
							goto case 352;
						case 208:
							num6 = 241;
							num2 = 41;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 1;
						case 1:
							array3[19] = 157;
							num2 = 209;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_1738;
						case 76:
							goto IL_1738;
						case 207:
							array6 = (byte[])hxHHUEm1hWtQTQCL8I(object_, (int)JtrUI9HRg6J5d1Ycl6(hDxKd45vFkxFTt6cuO(object_)));
							goto case 277;
						case 204:
							num7 = 106;
							goto case 349;
						case 203:
							array2[5] = 95;
							goto case 74;
						case 74:
							num6 = 106;
							goto case 326;
						case 196:
							array2[8] = (byte)num6;
							goto case 220;
						case 194:
							num6 = 113;
							num2 = 9;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 5;
						case 193:
							num5 = 160;
							num = 229;
							goto case 229;
						case 192:
							array2[3] = (byte)num6;
							num = 103;
							goto case 103;
						case 103:
							array2[3] = 101;
							goto case 52;
						case 52:
							num6 = 131;
							num2 = 322;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 188:
							array3[10] = 94;
							num2 = 101;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 151;
						case 151:
							array3[10] = 163;
							goto case 354;
						case 185:
							num5 = 98;
							goto case 13;
						case 13:
							array3[5] = (byte)num5;
							num = 387;
							goto case 387;
						case 181:
							array2[15] = (byte)num6;
							goto case 22;
						case 22:
							array5 = array2;
							goto case 149;
						case 180:
							array = new byte[0];
							num2 = 207;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 178:
							array3[5] = (byte)num5;
							goto case 53;
						case 177:
							array3[10] = 199;
							num2 = 42;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 6;
						case 176:
							array3[12] = (byte)num5;
							num2 = 375;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 174:
							array3[30] = 26;
							num2 = 69;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 109;
						case 109:
							num7 = 142;
							goto case 339;
						case 171:
							array2[8] = (byte)num6;
							num2 = 160;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 335;
						case 167:
						{
							uint num16 = num15;
							uint num17 = num15;
							num17 ^= num17 << 27;
							num17 += 3572912625u;
							num17 ^= num17 >> 3;
							num17 += 1320508937;
							num17 ^= num17 << 4;
							num17 += 2766775939u;
							num17 = 3904385322u - num17;
							num15 = num16 + (uint)(double)num17;
							goto case 233;
						}
						case 166:
							array3[29] = 146;
							goto case 373;
						case 162:
							array2[10] = (byte)num6;
							goto case 236;
						case 160:
							array3[21] = (byte)num5;
							num2 = 138;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 158:
							num7 = 120;
							goto case 38;
						case 38:
							array3[4] = (byte)num7;
							num2 = 27;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 156:
							array3[2] = 129;
							goto case 241;
						case 154:
							array2[13] = (byte)num6;
							goto case 43;
						case 43:
							num6 = 101;
							goto case 60;
						case 60:
							array2[13] = (byte)num6;
							num2 = 309;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 78;
						case 146:
							num6 = 97;
							num2 = 254;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 379;
						case 141:
							array3[25] = (byte)num5;
							num2 = 100;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 140:
							array3[13] = (byte)num7;
							num2 = 21;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 121;
						case 121:
							num7 = 114;
							goto case 264;
						case 139:
							num6 = 73;
							goto case 390;
						case 138:
							array3[21] = 112;
							num2 = 331;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 137:
							num7 = 124;
							goto case 388;
						case 131:
							if (num10 == num11 - 1)
							{
								goto case 114;
							}
							goto case 91;
						case 114:
							if (num12 > 0)
							{
								num2 = 39;
								if (K6uKVP0eThfULdK1jZ() != null)
								{
									continue;
								}
								goto case 159;
							}
							goto case 91;
						case 91:
							num9 = num13 ^ num14;
							num2 = 50;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 130:
							array3[31] = 8;
							num2 = 351;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 128:
							num7 = 207;
							goto case 223;
						case 127:
							num6 = 0;
							num2 = 63;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto case 35;
						case 126:
							array3[5] = 89;
							goto case 185;
						case 124:
							array3[29] = (byte)num5;
							goto case 166;
						case 122:
							num6 = 166;
							num = 59;
							goto case 59;
						case 59:
							array2[9] = (byte)num6;
							goto case 282;
						case 119:
							array3[6] = (byte)num7;
							goto case 320;
						case 113:
							array4[num8 + 3] = (byte)((num9 & 0xFF000000u) >> 24);
							goto case 101;
						case 110:
							array3[29] = 133;
							goto case 362;
						case 107:
							array3[31] = (byte)num7;
							num = 130;
							goto case 130;
						case 105:
							num7 = 138;
							goto case 269;
						case 104:
							array3[11] = 14;
							goto case 386;
						case 100:
							array3[25] = 70;
							num2 = 159;
							if (K6uKVP0eThfULdK1jZ() != null)
							{
								continue;
							}
							goto case 358;
						case 98:
							array3[26] = (byte)num7;
							num2 = 137;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 94:
							num7 = 119;
							goto case 140;
						case 93:
							array3[12] = 220;
							goto case 105;
						case 92:
							num7 = 217;
							num2 = 210;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 82:
							num7 = 141;
							goto case 292;
						case 75:
							num6 = 152;
							goto case 192;
						case 72:
							array3[23] = (byte)num7;
							goto case 334;
						case 71:
							array3[9] = (byte)num5;
							goto case 327;
						case 63:
							array2[4] = (byte)num6;
							num2 = 289;
							if (K6uKVP0eThfULdK1jZ() == null)
							{
								continue;
							}
							goto IL_002c;
						case 50:
							array4[num8] = (byte)(num9 & 0xFFu);
							goto case 252;
						case 42:
							array3[10] = 105;
							num = 188;
							goto case 188;
						case 41:
							array2[11] = (byte)num6;
							num2 = 37;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 34:
							num5 = 65;
							goto case 141;
						case 33:
							array = array4;
							goto case 278;
						case 31:
							num6 = 64;
							num2 = 181;
							if (rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto IL_002c;
						case 30:
							array2[7] = 122;
							num = 259;
							goto case 259;
						case 27:
							array3[4] = 84;
							goto case 126;
						case 18:
							array3[1] = (byte)num7;
							num = 156;
							goto case 156;
						case 9:
							array2[15] = (byte)num6;
							goto case 31;
						case 8:
							num5 = 136;
							num2 = 363;
							if (!rf4dkOOVLFXWNGs4Jn())
							{
								continue;
							}
							goto case 376;
						case 296:
							goto IL_2474;
						case 330:
							goto end_IL_2474;
						case 273:
							goto end_IL_249e;
						case 56:
						case 294:
							yDGRm4vMuj = MoJBHfeGQECf8xud3o(jItiChvyeFCXMmp9h2(array, 0u));
							goto case 28;
						case 368:
							goto IL_24e0;
						case 381:
							try
							{
								O2bmF1RYnQG2SaK9Y9(deflateStream, memoryStream);
								int num3 = 0;
								if (!rf4dkOOVLFXWNGs4Jn())
								{
									num3 = num4;
								}
								switch (num3)
								{
								}
							}
							finally
							{
								if (deflateStream != null)
								{
									goto IL_2538;
								}
								if (K6uKVP0eThfULdK1jZ() != null)
								{
									switch (0)
									{
									case 1:
									case 2:
										goto end_IL_2514;
									}
									goto IL_2538;
								}
								goto end_IL_2514;
								IL_2538:
								MYAt3xrVtpgBCBYTtj(deflateStream);
								end_IL_2514:;
							}
							goto case 87;
						case 87:
							yDGRm4vMuj = MoJBHfeGQECf8xud3o(hDfK0egXSfYBLwTqmV(memoryStream));
							goto case 172;
						case 172:
							bOlHCahgdFdmDOJ66h(memoryStream);
							goto case 28;
						case 28:
						case 243:
						case 281:
							QqrRNJ5cvi = (string[])PdUKldYqMCRKlwoqkA((Assembly)yDGRm4vMuj);
							goto case 88;
						case 88:
							mcvRknUfeC = true;
							return;
						case 169:
						case 272:
							return;
							IL_24e0:
							yDGRm4vMuj = MoJBHfeGQECf8xud3o(array);
							goto case 28;
							IL_1621:
							memoryStream = new MemoryStream();
							goto case 392;
						}
						break;
					}
					goto IL_04c1;
					IL_1738:
					num11 = array7.Length / 4;
					num2 = 177;
					if (K6uKVP0eThfULdK1jZ() == null)
					{
						goto IL_11fd;
					}
					goto IL_1e3a;
					IL_11fd:
					array4 = new byte[array7.Length];
					goto IL_04c1;
					IL_04c1:
					num27 = array8.Length / 4;
					goto IL_04c9;
					IL_04c9:
					num13 = 0u;
					goto IL_04cc;
					IL_04cc:
					num28 = 0u;
					goto IL_04cf;
					IL_04cf:
					num14 = 0u;
					num2 = 11;
					if (K6uKVP0eThfULdK1jZ() == null)
					{
						goto IL_04e2;
					}
					goto IL_1e3a;
					IL_04e2:
					if (num12 > 0)
					{
						goto IL_04e7;
					}
					goto IL_04fd;
					IL_04e7:
					num11++;
					num2 = 60;
					if (K6uKVP0eThfULdK1jZ() == null)
					{
						goto IL_04fd;
					}
					goto IL_1e3a;
					IL_04fd:
					num21 = 0u;
					num2 = 113;
					if (K6uKVP0eThfULdK1jZ() == null)
					{
						goto IL_0510;
					}
					goto IL_1e3a;
					IL_0510:
					num10 = 0;
					goto IL_0513;
					IL_0513:
					if (num10 < num11)
					{
						goto IL_052e;
					}
					num2 = 33;
					if (K6uKVP0eThfULdK1jZ() != null)
					{
						goto IL_002c;
					}
					goto IL_1e3a;
					IL_002c:
					num2 = num;
					goto IL_1e3a;
					IL_052e:
					num29 = num10 % num27;
					goto IL_0535;
					IL_0535:
					num8 = num10 * 4;
					goto IL_053b;
					IL_053b:
					num21 = (uint)(num29 * 4);
					num2 = 12;
					if (rf4dkOOVLFXWNGs4Jn())
					{
						goto IL_0551;
					}
					goto IL_1e3a;
					IL_0551:
					num28 = (uint)((array8[num21 + 3] << 24) | (array8[num21 + 2] << 16) | (array8[num21 + 1] << 8) | array8[num21]);
					goto IL_057c;
					IL_057c:
					num24 = 255u;
					goto IL_0583;
					IL_0583:
					num25 = 0;
					goto IL_0586;
					IL_0586:
					if (num10 == num11 - 1)
					{
						goto IL_058e;
					}
					goto IL_05d5;
					IL_058e:
					if (num12 > 0)
					{
						goto IL_0593;
					}
					goto IL_05d5;
					IL_0593:
					num14 = 0u;
					num2 = 154;
					if (rf4dkOOVLFXWNGs4Jn())
					{
						goto IL_05a6;
					}
					goto IL_1e3a;
					IL_05a6:
					num13 += num28;
					num2 = 154;
					if (K6uKVP0eThfULdK1jZ() == null)
					{
						goto IL_05bd;
					}
					goto IL_1e3a;
					IL_05bd:
					num22 = 0;
					num2 = 23;
					if (K6uKVP0eThfULdK1jZ() != null)
					{
						goto IL_002c;
					}
					goto IL_1e3a;
					IL_05d5:
					num21 = (uint)num8;
					goto IL_05d9;
					IL_05d9:
					num13 += num28;
					num2 = 308;
					if (K6uKVP0eThfULdK1jZ() != null)
					{
						goto IL_002c;
					}
					goto IL_1e3a;
					continue;
					end_IL_2474:
					break;
				}
				continue;
				end_IL_249e:
				break;
			}
		}
	}

	internal static string[] sZYRiARBPm(Assembly assembly_0)
	{
		if (assembly_0 == typeof(HjIi14c9D4OsxwLnfMw).Assembly)
		{
			if (!mcvRknUfeC)
			{
				eTeRQ3vDVv();
			}
			List<string> list = new List<string>();
			list.AddRange(assembly_0.GetManifestResourceNames());
			list.AddRange(((Assembly)yDGRm4vMuj).GetManifestResourceNames());
			return list.ToArray();
		}
		return assembly_0.GetManifestResourceNames();
	}

	private static Assembly UpsR6YVw4j(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (!mcvRknUfeC)
		{
			eTeRQ3vDVv();
		}
		string name = resolveEventArgs_0.Name;
		int num = 0;
		while (true)
		{
			if (num < QqrRNJ5cvi.Length)
			{
				if (QqrRNJ5cvi[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)yDGRm4vMuj;
	}

	public HjIi14c9D4OsxwLnfMw()
	{
		AppDomain.CurrentDomain.ResourceResolve += UpsR6YVw4j;
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!iYfR8M7mu5)
		{
			iYfR8M7mu5 = true;
			new HjIi14c9D4OsxwLnfMw();
		}
	}

	internal static Type uu7t2UsuZiGnQqbqdS(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object PrvpS7q8f6F3O90Y9F(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object hDxKd45vFkxFTt6cuO(object object_0)
	{
		return ((InRL4fclTJhCYsrjsta.ibtnH5ca3SUQeLijsOE)object_0).KDikMXewCI();
	}

	internal static void KIEU0ETr0GnMP51HHg(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long JtrUI9HRg6J5d1Ycl6(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object hxHHUEm1hWtQTQCL8I(object object_0, int int_0)
	{
		return ((InRL4fclTJhCYsrjsta.ibtnH5ca3SUQeLijsOE)object_0).B0wRAaeO7P(int_0);
	}

	internal static object MoJBHfeGQECf8xud3o(object object_0)
	{
		return Pk6yu5cknjiUefapcSv.lZ7R4ErPjd((byte[])object_0);
	}

	internal static void O2bmF1RYnQG2SaK9Y9(object object_0, object object_1)
	{
		((Stream)object_0).CopyTo((Stream)object_1);
	}

	internal static void MYAt3xrVtpgBCBYTtj(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object hDfK0egXSfYBLwTqmV(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void bOlHCahgdFdmDOJ66h(object object_0)
	{
		((Stream)object_0).Dispose();
	}

	internal static object jItiChvyeFCXMmp9h2(object object_0, uint uint_0)
	{
		return Pk6yu5cknjiUefapcSv.QeARvUDnbh((byte[])object_0, uint_0);
	}

	internal static object PdUKldYqMCRKlwoqkA(object object_0)
	{
		return ((Assembly)object_0).GetManifestResourceNames();
	}

	internal static bool rf4dkOOVLFXWNGs4Jn()
	{
		return (object)null == null;
	}

	internal static object K6uKVP0eThfULdK1jZ()
	{
		return null;
	}
}
