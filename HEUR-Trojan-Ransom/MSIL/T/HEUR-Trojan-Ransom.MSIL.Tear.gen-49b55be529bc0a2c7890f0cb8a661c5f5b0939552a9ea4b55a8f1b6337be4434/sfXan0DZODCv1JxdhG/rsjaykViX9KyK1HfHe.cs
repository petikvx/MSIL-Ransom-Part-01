using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using XojDhSNsCJNUQnB1Mi;
using eRO8rC7xBFSIpkK1fP;
using r3fa6YwLARGyaKnXUV;

namespace sfXan0DZODCv1JxdhG;

internal class rsjaykViX9KyK1HfHe
{
	private enum LpmQQLGWfXHFx1K1dr
	{

	}

	internal class CdLrnEy3qxZCGxspsk
	{
		private unsafe static uint xQE6IMjhlC(void* pVoid_0, uint uint_0)
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

		private unsafe static bool MCh64bf983(void* pVoid_0, void* pVoid_1, uint uint_0)
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

		private unsafe static void YeG69kGwBi(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = byte_0;
			}
		}

		private unsafe static void FsH6eWXmfb(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = ((byte*)pVoid_1)[(int)num];
			}
		}

		private unsafe static void eUA6t11yqu(byte* pByte_0, byte* pByte_1, uint uint_0)
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
				FsH6eWXmfb(pByte_0, pByte_1, uint_0);
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

		private unsafe static uint vEA61wJPis(byte[] byte_0, uint uint_0, LpmQQLGWfXHFx1K1dr lpmQQLGWfXHFx1K1dr_0)
		{
			uint num = 0u;
			fixed (byte* ptr = byte_0)
			{
				num = *(uint*)(ptr + (int)uint_0 + (nint)lpmQQLGWfXHFx1K1dr_0 * (nint)4);
			}
			return num;
		}

		public static uint nNa6JENsUr(byte[] byte_0, uint uint_0)
		{
			return TXKaIaxBogn7Ml0PiDo(byte_0, uint_0, (LpmQQLGWfXHFx1K1dr)3);
		}

		private unsafe static uint yvU67helsY(byte[] byte_0, uint uint_0, byte[] byte_1)
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
					byte* ptr7 = ptr4 + (int)xQE6IMjhlC(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16];
					ULftYNxeuMgBZH9VM6H(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					uint[] array2 = array;
					byte* ptr8 = ptr7 - 4;
					if (xQE6IMjhlC(ptr6 + 4, 4u) != 1)
					{
						FsH6eWXmfb(ptr4, ptr2 + (int)num, xQE6IMjhlC(ptr6 + 3, 4u));
						return xQE6IMjhlC(ptr6 + 3, 4u);
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
							num2 = xQE6IMjhlC(ptr3, 4u);
							ptr3 += 4;
						}
						uint num3 = xQE6IMjhlC(ptr3, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								eUA6t11yqu(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								eUA6t11yqu(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								eUA6t11yqu(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								eUA6t11yqu(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								eUA6t11yqu(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 4;
							}
							else
							{
								byte byte_2 = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFFu;
								YeG69kGwBi(ptr5, byte_2, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
						}
						else
						{
							eUA6t11yqu(ptr5, ptr3, 4u);
							ptr5 += (int)array2[num2 & 0xF];
							ptr3 += (int)array2[num2 & 0xF];
							num2 >>= (int)(byte)array2[num2 & 0xF];
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

		internal static object fu76LExE0G(byte[] byte_0)
		{
			return sGna1TxmK858SvXIwCd(iO04oIxqfojKJovjNUA(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(16777252)).GetMethod(awYSQNJbxdPDQ9b5BH.vb0hJkAt6(780), new Type[1] { iO04oIxqfojKJovjNUA(typeof(byte[]).TypeHandle) }), null, new object[1] { byte_0 });
		}

		public static byte[] CYn60EB0QP(byte[] byte_0, uint uint_0)
		{
			uint num = jCvh9ExUKLckkoTCwGv(byte_0, uint_0);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				yvU67helsY(byte_0, uint_0, array);
			}
			return array;
		}

		internal static uint TXKaIaxBogn7Ml0PiDo(object object_0, uint uint_0, LpmQQLGWfXHFx1K1dr lpmQQLGWfXHFx1K1dr_0)
		{
			return vEA61wJPis((byte[])object_0, uint_0, lpmQQLGWfXHFx1K1dr_0);
		}

		internal static void ULftYNxeuMgBZH9VM6H(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
		}

		internal static Type iO04oIxqfojKJovjNUA(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object sGna1TxmK858SvXIwCd(object object_0, object object_1, object object_2)
		{
			return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
		}

		internal static uint jCvh9ExUKLckkoTCwGv(object object_0, uint uint_0)
		{
			return nNa6JENsUr((byte[])object_0, uint_0);
		}
	}

	private static string[] dq46q7X0jg = new string[0];

	private static object lcR6HCFWNs = null;

	private static bool Jpt6PbOD2N = false;

	private static bool kbH6FJKMSI = false;

	private static void vXa6MRJAnO()
	{
		int num = 340;
		byte[] array3 = default(byte[]);
		int num12 = default(int);
		int num10 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num22 = default(int);
		int num15 = default(int);
		byte[] array8 = default(byte[]);
		byte[] array7 = default(byte[]);
		uint num7 = default(uint);
		int num30 = default(int);
		byte[] array4 = default(byte[]);
		int num11 = default(int);
		int num13 = default(int);
		int num9 = default(int);
		int num16 = default(int);
		uint num32 = default(uint);
		int num21 = default(int);
		byte[] array5 = default(byte[]);
		uint num23 = default(uint);
		int num27 = default(int);
		int num17 = default(int);
		byte[] array = default(byte[]);
		int num31 = default(int);
		int num20 = default(int);
		uint num19 = default(uint);
		uint num29 = default(uint);
		uint num18 = default(uint);
		uint num8 = default(uint);
		int num28 = default(int);
		uint num24 = default(uint);
		int num14 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		MemoryStream memoryStream = default(MemoryStream);
		int num4 = default(int);
		int num6 = default(int);
		while (!Jpt6PbOD2N)
		{
			while (true)
			{
				awYSQNJbxdPDQ9b5BH.Mc8pUl5GpB1LDt3xfk object_ = new awYSQNJbxdPDQ9b5BH.Mc8pUl5GpB1LDt3xfk((Stream)hMo5AvWvDx9pt8MjIS(eQX7wMXLmTQTAhQLCl(typeof(awYSQNJbxdPDQ9b5BH).TypeHandle).Assembly, awYSQNJbxdPDQ9b5BH.vb0hJkAt6(702)));
				while (true)
				{
					IL_268e:
					VlkW28t1k6TUPvdrXi(PXihfIB0EY2NK25QIB(object_), 0L);
					int num2 = 219;
					if (TVISBRuet2jQFcqWkJ() != null)
					{
						goto IL_0531;
					}
					goto IL_2044;
					IL_2044:
					while (true)
					{
						switch (num2)
						{
						case 399:
							array3[23] = 2;
							goto case 207;
						case 207:
							array3[24] = 98;
							goto case 60;
						case 60:
							array3[24] = 127;
							num2 = 29;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 77;
						case 77:
							num12 = 231;
							num = 20;
							goto case 20;
						case 20:
							array3[24] = (byte)num12;
							goto case 218;
						case 218:
							num10 = 114;
							goto case 297;
						case 297:
							array3[25] = (byte)num10;
							num2 = 301;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 398:
							array2 = array6;
							goto case 265;
						case 265:
							num22 = array2.Length % 4;
							num2 = 204;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 90;
						case 179:
						case 286:
							if (num15 >= array8.Length)
							{
								goto case 398;
							}
							goto case 381;
						case 90:
							num15 = 0;
							goto case 179;
						case 381:
							array7[num15] = (byte)(array7[num15] ^ array8[num15]);
							num2 = 162;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 397:
							num7 = (uint)num30;
							num2 = 250;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 396:
							array4[1] = (byte)num11;
							num2 = 91;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 395:
							num12 = 137;
							goto case 361;
						case 361:
							array3[4] = (byte)num12;
							num2 = 221;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 137;
						case 137:
							num13 = 1;
							num = 90;
							goto case 90;
						case 394:
							array4[9] = 121;
							num = 232;
							goto case 232;
						case 232:
							num9 = 126;
							num2 = 304;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 393:
							array3[0] = (byte)num12;
							num = 230;
							goto case 230;
						case 230:
							num10 = 94;
							goto case 122;
						case 122:
							array3[0] = (byte)num10;
							num = 197;
							goto case 197;
						case 197:
							array3[0] = 137;
							goto case 274;
						case 274:
							array3[0] = 96;
							goto case 235;
						case 235:
							array3[1] = 92;
							num2 = 130;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 167;
						case 167:
							array3[1] = 78;
							num2 = 94;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 392:
							array4[3] = (byte)num9;
							num2 = 159;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 314;
						case 314:
							array4[3] = 148;
							goto case 267;
						case 267:
							array4[3] = 42;
							num = 58;
							goto case 58;
						case 58:
							array4[4] = 133;
							goto case 287;
						case 287:
							num11 = 157;
							num2 = 164;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 391:
							array3[3] = 75;
							num = 176;
							goto case 176;
						case 176:
							num10 = 149;
							num2 = 97;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 390:
							array3[30] = 181;
							goto case 363;
						case 363:
							num12 = 90;
							num2 = 147;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 389:
							num16 = 0;
							num = 184;
							goto case 172;
						case 172:
						case 184:
							if (num16 >= num22)
							{
								num2 = 89;
								if (TVISBRuet2jQFcqWkJ() == null)
								{
									continue;
								}
								goto IL_0085;
							}
							goto case 59;
						case 59:
							if (num16 > 0)
							{
								num = 39;
								goto case 39;
							}
							goto case 198;
						case 39:
							num32 <<= 8;
							num2 = 167;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 201;
						case 201:
							num21 += 8;
							num2 = 198;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 198:
							array5[num30 + num16] = (byte)((num23 & num32) >> num21);
							num2 = 183;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 388:
							num12 = 132;
							goto case 27;
						case 27:
							array3[27] = (byte)num12;
							num = 305;
							goto case 305;
						case 305:
							num10 = 122;
							num2 = 54;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 387:
							array3[17] = (byte)num12;
							num2 = 115;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 386:
							num12 = 133;
							num2 = 387;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 248;
						case 248:
							num27 = 0;
							goto case 17;
						case 17:
						case 236:
							if (num27 >= num17)
							{
								goto case 156;
							}
							goto case 185;
						case 156:
							array = array5;
							num2 = 37;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 4;
						case 4:
							num12 = 125;
							num2 = 66;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 69;
						case 69:
							array3[31] = (byte)num12;
							num2 = 72;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 34;
						case 34:
							array3[8] = (byte)num10;
							num = 96;
							goto case 96;
						case 96:
							array3[8] = 75;
							num2 = 61;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 185:
							num31 = num27 % num20;
							num2 = 385;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 347;
						case 347:
							array4[7] = 42;
							goto case 367;
						case 367:
							array4[7] = 102;
							goto case 159;
						case 159:
							array4[7] = 254;
							num2 = 178;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 385:
							num30 = num27 * 4;
							goto case 49;
						case 49:
							num7 = (uint)(num31 * 4);
							goto case 74;
						case 74:
							num19 = (uint)((array7[num7 + 3] << 24) | (array7[num7 + 2] << 16) | (array7[num7 + 1] << 8) | array7[num7]);
							goto case 41;
						case 41:
							num32 = 255u;
							num2 = 271;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 384:
							array4[14] = (byte)num11;
							num2 = 3;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							break;
						case 1:
							break;
						case 196:
							goto IL_0540;
						case 66:
							goto IL_0556;
						case 145:
							goto IL_0564;
						case 328:
							goto IL_056a;
						case 383:
							num10 = 159;
							goto case 355;
						case 355:
							array3[14] = (byte)num10;
							num2 = 40;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 382:
							num9 = 214;
							goto case 243;
						case 243:
							array4[6] = (byte)num9;
							num2 = 209;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 380:
							array3[6] = 139;
							num2 = 71;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 379:
							array5[num30] = (byte)(num29 & 0xFFu);
							goto case 329;
						case 329:
							array5[num30 + 1] = (byte)((num29 & 0xFF00) >> 8);
							num2 = 376;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 378:
							array3[31] = (byte)num12;
							num = 4;
							goto case 4;
						case 376:
							array5[num30 + 2] = (byte)((num29 & 0xFF0000) >> 16);
							goto case 8;
						case 8:
							array5[num30 + 3] = (byte)((num29 & 0xFF000000u) >> 24);
							goto case 89;
						case 89:
						case 169:
							num27++;
							num2 = 97;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 17;
						case 375:
							num12 = 88;
							goto case 212;
						case 212:
							array3[19] = (byte)num12;
							num2 = 187;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 374:
							num10 = 168;
							num2 = 148;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 373:
							array3[5] = 222;
							num2 = 95;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 372:
							num11 = 126;
							goto case 170;
						case 170:
							array4[7] = (byte)num11;
							goto case 347;
						case 371:
							array3[9] = 95;
							num2 = 102;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 302;
						case 302:
							num10 = 102;
							num2 = 29;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 370:
							array3[19] = (byte)num10;
							goto case 375;
						case 369:
							array4[0] = 36;
							num = 171;
							goto case 171;
						case 171:
							num9 = 168;
							num2 = 127;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 368:
							array3[17] = 138;
							num = 163;
							goto case 163;
						case 163:
							array3[17] = 150;
							goto case 386;
						case 366:
							num10 = 94;
							goto case 108;
						case 108:
							array3[20] = (byte)num10;
							goto case 153;
						case 153:
							num12 = 228;
							goto case 327;
						case 327:
							array3[20] = (byte)num12;
							goto case 356;
						case 356:
							array3[21] = 133;
							goto case 241;
						case 241:
							array3[21] = 148;
							num2 = 93;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 365:
							num10 = 15;
							num2 = 142;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 181;
						case 181:
							array3[12] = (byte)num10;
							goto case 200;
						case 200:
							num10 = 54;
							num2 = 152;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 364:
							array3[31] = 195;
							num2 = 278;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 65;
						case 65:
							num10 = 107;
							goto case 155;
						case 155:
							array3[6] = (byte)num10;
							goto case 47;
						case 47:
							array3[6] = 162;
							num2 = 325;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 362:
							array4[1] = (byte)num9;
							goto case 284;
						case 284:
							num11 = 116;
							goto case 106;
						case 106:
							array4[2] = (byte)num11;
							goto case 280;
						case 280:
							num11 = 219;
							num2 = 10;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 35;
						case 35:
							array4[2] = (byte)num11;
							num2 = 26;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 216;
						case 216:
							array4[2] = 42;
							num2 = 87;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 360:
							array3[28] = 86;
							goto case 348;
						case 348:
							array3[28] = 116;
							goto case 324;
						case 324:
							array3[28] = 170;
							num2 = 124;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 359:
							num12 = 166;
							num = 315;
							goto case 315;
						case 315:
							array3[7] = (byte)num12;
							num2 = 165;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 358:
							array3[13] = 137;
							num2 = 334;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 357:
							array4[5] = (byte)num9;
							num2 = 299;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 354:
							num12 = 176;
							goto case 313;
						case 313:
							array3[18] = (byte)num12;
							num2 = 88;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 10;
						case 10:
							array3[15] = 131;
							goto case 104;
						case 104:
							array3[15] = 128;
							num = 208;
							goto case 208;
						case 208:
							array3[15] = 77;
							num2 = 112;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 74;
						case 353:
							array3[4] = (byte)num12;
							num2 = 67;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 50;
						case 50:
							num18 = 255u;
							num2 = 343;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 352:
							num29 = num18 ^ num8;
							num = 379;
							goto case 379;
						case 351:
							array3[3] = 132;
							num2 = 190;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 124;
						case 124:
							num10 = 105;
							num2 = 92;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 12;
						case 12:
							if (num27 != num17 - 1)
							{
								goto case 397;
							}
							goto case 133;
						case 133:
							if (num22 <= 0)
							{
								goto case 397;
							}
							num = 195;
							goto case 195;
						case 195:
							num8 = 0u;
							num = 295;
							goto case 295;
						case 295:
							num18 += num19;
							goto case 318;
						case 318:
							num28 = 0;
							goto case 24;
						case 312:
							if (num28 > 0)
							{
								goto case 323;
							}
							goto case 186;
						case 323:
							num8 <<= 8;
							goto case 186;
						case 186:
							num8 |= array2[^(1 + num28)];
							goto case 214;
						case 214:
							num28++;
							goto case 24;
						case 24:
						case 275:
							if (num28 < num22)
							{
								goto case 312;
							}
							num2 = 109;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 23;
						case 23:
						case 111:
							num24 = num18;
							num2 = 27;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 50;
						case 350:
							num10 = 164;
							num2 = 270;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 346:
							array4[0] = (byte)num9;
							num2 = 369;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 345:
							array4[6] = (byte)num11;
							goto case 194;
						case 194:
							num9 = 87;
							goto case 33;
						case 33:
							array4[6] = (byte)num9;
							goto case 293;
						case 293:
							array4[6] = 43;
							goto case 382;
						case 344:
							array3[5] = 149;
							num2 = 72;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 82;
						case 82:
							num12 = 119;
							goto case 317;
						case 317:
							array3[5] = (byte)num12;
							num2 = 196;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 373;
						case 343:
						{
							uint num25 = num24;
							uint num26 = num24;
							num26 ^= num26 << 7;
							num26 += 252757333;
							num26 ^= num26 << 25;
							num26 += 775711184;
							num26 ^= num26 >> 1;
							num26 += 2615063369u;
							num26 = 678931976 + num26;
							num24 = num25 + (uint)(double)num26;
							goto case 205;
						}
						case 205:
							num18 = num24;
							num = 330;
							goto case 330;
						case 330:
							if (num27 != num17 - 1)
							{
								goto case 352;
							}
							num2 = 279;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 6;
						case 6:
							array4[8] = (byte)num11;
							num2 = 30;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 342:
							array4[0] = (byte)num9;
							goto case 113;
						case 113:
							array4[0] = 129;
							num2 = 336;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 70;
						case 70:
							array4[15] = 132;
							goto case 102;
						case 102:
							array8 = array4;
							num2 = 137;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 341:
							array4[14] = (byte)num9;
							goto case 119;
						case 119:
							array4[14] = 156;
							goto case 285;
						case 285:
							num11 = 160;
							num2 = 338;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 227;
						case 227:
							array3[10] = 89;
							goto case 306;
						case 306:
							num12 = 122;
							goto case 134;
						case 134:
							array3[10] = (byte)num12;
							num = 228;
							goto case 228;
						case 228:
							array3[10] = 204;
							num2 = 160;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 43;
						case 43:
							num12 = 156;
							num2 = 298;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 393;
						case 338:
							array4[14] = (byte)num11;
							num2 = 139;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 22;
						case 22:
							num12 = 156;
							goto case 128;
						case 128:
							array3[20] = (byte)num12;
							goto case 15;
						case 15:
							array3[20] = 88;
							goto case 366;
						case 337:
							num12 = 145;
							num2 = 130;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 35;
						case 336:
							num11 = 51;
							num2 = 396;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 335:
							array3[2] = 118;
							goto case 282;
						case 282:
							num12 = 148;
							num = 101;
							goto case 101;
						case 101:
							array3[2] = (byte)num12;
							num = 256;
							goto case 256;
						case 256:
							array3[2] = 29;
							num = 332;
							goto case 332;
						case 332:
							array3[3] = 120;
							goto case 68;
						case 68:
							num12 = 151;
							num2 = 151;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 334:
							array3[13] = 144;
							num2 = 218;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 281;
						case 281:
							array3[14] = 156;
							num2 = 383;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 10;
						case 333:
							array4[12] = 165;
							num2 = 142;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 229;
						case 229:
							array4[12] = 16;
							goto case 143;
						case 143:
							num11 = 125;
							num = 55;
							goto case 55;
						case 55:
							array4[12] = (byte)num11;
							goto case 9;
						case 9:
							array4[12] = 138;
							num2 = 1;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 331:
							array3[7] = 5;
							num2 = 53;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 326:
							array3[18] = 57;
							goto case 308;
						case 308:
							num12 = 87;
							goto case 135;
						case 135:
							array3[18] = (byte)num12;
							num = 354;
							goto case 354;
						case 325:
							num12 = 94;
							num2 = 158;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 322:
							array3[1] = (byte)num10;
							goto case 251;
						case 251:
							num10 = 231;
							goto case 21;
						case 21:
							array3[1] = (byte)num10;
							goto case 85;
						case 85:
							array3[2] = 57;
							num2 = 37;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 45;
						case 45:
							num10 = 152;
							num2 = 237;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 321:
							array3[29] = (byte)num10;
							num2 = 52;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 51;
						case 51:
							array3 = new byte[32];
							num2 = 43;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 320:
							array4[10] = 150;
							goto case 272;
						case 272:
							array4[10] = 95;
							goto case 144;
						case 144:
							array4[10] = 185;
							goto case 126;
						case 126:
							array4[10] = 59;
							goto case 309;
						case 309:
							array4[11] = 132;
							num2 = 277;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 319:
							num23 = num18 ^ num8;
							goto case 389;
						case 316:
							num10 = 108;
							num2 = 238;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 311:
							array3[20] = 140;
							goto case 136;
						case 136:
							num12 = 108;
							num = 268;
							goto case 268;
						case 268:
							array3[20] = (byte)num12;
							goto case 22;
						case 310:
							array3[26] = (byte)num12;
							goto case 86;
						case 86:
							num10 = 169;
							goto case 211;
						case 211:
							array3[26] = (byte)num10;
							goto case 350;
						case 307:
							num9 = 84;
							num2 = 206;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 44;
						case 44:
							array4[12] = (byte)num11;
							goto case 333;
						case 304:
							array4[10] = (byte)num9;
							num2 = 320;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 303:
							array3[6] = (byte)num10;
							num2 = 31;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 301:
							num12 = 108;
							goto case 83;
						case 83:
							array3[25] = (byte)num12;
							goto case 374;
						case 300:
							num12 = 35;
							num2 = 347;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 353;
						case 299:
							num9 = 115;
							num2 = 220;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 102;
						case 298:
							num11 = 109;
							num2 = 174;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 296:
							array4[15] = (byte)num9;
							num2 = 78;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 294:
							array3[21] = (byte)num12;
							num2 = 26;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 292:
							num10 = 172;
							goto case 249;
						case 249:
							array3[11] = (byte)num10;
							num2 = 259;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 291:
							num9 = 59;
							num2 = 342;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 45;
						case 290:
							if (num22 > 0)
							{
								num2 = 108;
								if (TVISBRuet2jQFcqWkJ() != null)
								{
									continue;
								}
								goto case 189;
							}
							goto case 121;
						case 189:
							num17++;
							goto case 121;
						case 121:
							num7 = 0u;
							goto case 248;
						case 289:
							num10 = 140;
							goto case 166;
						case 166:
							array3[12] = (byte)num10;
							goto case 48;
						case 48:
							array3[12] = 96;
							goto case 365;
						case 288:
							array3[22] = 128;
							goto case 140;
						case 140:
							array3[22] = 1;
							num2 = 107;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 283:
							lcR6HCFWNs = rjbmDOhXtM571MMlnJ(array);
							num2 = 349;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 279:
							if (num22 <= 0)
							{
								goto case 352;
							}
							goto case 319;
						case 278:
							array7 = array3;
							num2 = 261;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 277:
							array4[11] = 130;
							num2 = 257;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 276:
							array4[4] = (byte)num9;
							num2 = 307;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 125;
						case 125:
							array3[11] = 125;
							num = 57;
							goto case 57;
						case 57:
							array3[11] = 10;
							num2 = 289;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 273:
							array3[9] = 210;
							goto case 255;
						case 255:
							num10 = 87;
							num2 = 120;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 271:
							num21 = 0;
							goto case 12;
						case 270:
							array3[26] = (byte)num10;
							goto case 64;
						case 64:
							array3[26] = 231;
							goto case 337;
						case 269:
							num12 = 135;
							num2 = 80;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 266:
							num12 = 123;
							goto case 62;
						case 62:
							array3[13] = (byte)num12;
							goto case 358;
						case 264:
							num10 = 42;
							num = 231;
							goto case 231;
						case 231:
							array3[3] = (byte)num10;
							goto case 391;
						case 263:
							array3[19] = (byte)num10;
							goto case 311;
						case 261:
							array4 = new byte[16];
							goto case 239;
						case 239:
							num9 = 150;
							num = 346;
							goto case 346;
						case 260:
							array3[29] = 136;
							goto case 269;
						case 259:
							array3[11] = 165;
							num = 191;
							goto case 191;
						case 191:
							array3[11] = 16;
							num2 = 46;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 125;
						case 258:
							num20 = array7.Length / 4;
							num2 = 252;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 161;
						case 161:
							num11 = 104;
							goto case 384;
						case 257:
							num9 = 123;
							num2 = 225;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 254:
							num8 = 0u;
							goto case 290;
						case 253:
							num12 = 106;
							num2 = 138;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 252:
							num18 = 0u;
							num = 98;
							goto case 98;
						case 98:
							num19 = 0u;
							goto case 254;
						case 250:
							num18 += num19;
							num2 = 0;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 247:
							array4[5] = 245;
							num2 = 193;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 18;
						case 18:
							array3[15] = 74;
							num = 10;
							goto case 10;
						case 246:
							array3[22] = (byte)num12;
							num = 288;
							goto case 288;
						case 245:
							array4[13] = 32;
							goto case 161;
						case 244:
							array3[23] = 85;
							goto case 399;
						case 242:
							array3[8] = (byte)num10;
							goto case 192;
						case 192:
							num10 = 95;
							goto case 34;
						case 240:
							array3[16] = 120;
							num2 = 234;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 238:
							array3[15] = (byte)num10;
							goto case 18;
						case 237:
							array3[2] = (byte)num10;
							num2 = 202;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 234:
							array3[16] = 150;
							num2 = 2;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 2;
						case 2:
							num10 = 53;
							num = 109;
							goto case 109;
						case 109:
							array3[16] = (byte)num10;
							goto case 368;
						case 180:
						case 226:
							lcR6HCFWNs = rjbmDOhXtM571MMlnJ(s1UdSLgq8OJ2ftKvAo(array, 0u));
							num2 = 233;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 225:
							array4[11] = (byte)num9;
							goto case 129;
						case 129:
							num11 = 172;
							num2 = 44;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 224:
							num12 = 120;
							num2 = 378;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 223:
							num11 = 149;
							goto case 345;
						case 222:
							array3[2] = (byte)num12;
							num = 335;
							goto case 335;
						case 221:
							array3[4] = 98;
							num2 = 6;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 84;
						case 84:
							num10 = 218;
							goto case 110;
						case 110:
							array3[4] = (byte)num10;
							num = 300;
							goto case 300;
						case 220:
							array4[5] = (byte)num9;
							goto case 298;
						case 219:
							array = new byte[0];
							goto case 182;
						case 182:
							array6 = (byte[])AaBLadpgBDrusOy8Fi(object_, (int)wBKP2Jd1B7Xg6f47Xg(PXihfIB0EY2NK25QIB(object_)));
							num = 51;
							goto case 51;
						case 217:
							num11 = 134;
							goto case 99;
						case 99:
							array4[13] = (byte)num11;
							goto case 245;
						case 210:
							array4[5] = (byte)num11;
							num2 = 46;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 25;
						case 25:
							num10 = 126;
							num2 = 116;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 209:
							array4[7] = 152;
							num = 372;
							goto case 372;
						case 206:
							array4[4] = (byte)num9;
							goto case 168;
						case 168:
							array4[4] = 1;
							goto case 79;
						case 79:
							num11 = 46;
							goto case 210;
						case 204:
							num17 = array2.Length / 4;
							goto case 28;
						case 28:
							array5 = new byte[array2.Length];
							goto case 258;
						case 203:
							num10 = 197;
							num2 = 105;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 202:
							num12 = 132;
							goto case 222;
						case 199:
							array3[9] = 151;
							goto case 371;
						case 193:
							array4[5] = 87;
							goto case 175;
						case 175:
							num11 = 149;
							num2 = 76;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 190:
							array3[3] = 169;
							goto case 264;
						case 188:
							array3[15] = 148;
							goto case 316;
						case 187:
							num12 = 84;
							num2 = 36;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 183:
							num16++;
							goto case 172;
						case 178:
							array4[8] = 166;
							goto case 154;
						case 154:
							num11 = 119;
							num2 = 6;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 177:
							array3[23] = 111;
							goto case 244;
						case 174:
							array4[5] = (byte)num11;
							num2 = 247;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 173:
							array3[22] = 120;
							num = 123;
							goto case 123;
						case 123:
							num12 = 108;
							num2 = 241;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 246;
						case 165:
							array3[7] = 119;
							goto case 331;
						case 164:
							array4[4] = (byte)num11;
							num2 = 118;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 16;
						case 162:
							num15++;
							num2 = 286;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 160:
							array3[11] = 126;
							goto case 292;
						case 158:
							array3[7] = (byte)num12;
							num2 = 271;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 359;
						case 157:
							array4[9] = (byte)num11;
							goto case 100;
						case 100:
							num11 = 186;
							goto case 146;
						case 146:
							array4[9] = (byte)num11;
							num2 = 141;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 152:
							array3[13] = (byte)num10;
							goto case 266;
						case 151:
							array3[3] = (byte)num12;
							num = 351;
							goto case 351;
						case 150:
							array4[9] = (byte)num9;
							num2 = 394;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto case 342;
						case 149:
							num9 = 115;
							num2 = 276;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 148:
							array3[25] = (byte)num10;
							goto case 203;
						case 147:
							array3[30] = (byte)num12;
							num = 224;
							goto case 224;
						case 142:
							array3[31] = 130;
							num2 = 153;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 364;
						case 141:
							num9 = 150;
							num2 = 48;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 150;
						case 139:
							num9 = 210;
							goto case 296;
						case 138:
							array3[30] = (byte)num12;
							goto case 390;
						case 132:
							goto IL_1bac;
						case 131:
							array3[27] = 70;
							num2 = 360;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 130:
							array3[27] = (byte)num12;
							goto case 388;
						case 127:
							array4[0] = (byte)num9;
							goto case 291;
						case 120:
							array3[9] = (byte)num10;
							goto case 199;
						case 118:
							array4[4] = 132;
							goto case 149;
						case 116:
							array3[30] = (byte)num10;
							num2 = 253;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 115:
							array3[17] = 199;
							num2 = 326;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 114:
							array3[27] = 92;
							goto case 131;
						case 112:
							num12 = 42;
							num2 = 13;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 107:
							array3[23] = 143;
							num2 = 172;
							if (TVISBRuet2jQFcqWkJ() != null)
							{
								continue;
							}
							goto case 177;
						case 105:
							array3[25] = (byte)num10;
							goto case 19;
						case 19:
							num12 = 173;
							goto case 310;
						case 103:
							switch (num14)
							{
							case 0:
								break;
							case 1:
								goto IL_1bac;
							default:
								goto IL_1cf8;
							}
							goto case 283;
						case 97:
							array3[4] = (byte)num10;
							goto case 395;
						case 95:
							num10 = 147;
							goto case 303;
						case 94:
							num10 = 54;
							num = 322;
							goto case 322;
						case 93:
							num12 = 105;
							num2 = 294;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 101;
						case 92:
							array3[29] = (byte)num10;
							goto case 56;
						case 56:
							array3[29] = 115;
							goto case 260;
						case 91:
							array4[1] = 121;
							goto case 11;
						case 11:
							num9 = 171;
							goto case 362;
						case 88:
							num10 = 118;
							num2 = 370;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 77;
						case 87:
							num9 = 118;
							goto case 392;
						case 81:
							array4[15] = (byte)num11;
							goto case 70;
						case 80:
							array3[29] = (byte)num12;
							num2 = 7;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 78:
							num11 = 108;
							num2 = 29;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 81;
						case 76:
							array4[6] = (byte)num11;
							goto case 223;
						case 75:
							num10 = 232;
							num2 = 263;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 254;
						case 72:
							array3[31] = 164;
							goto case 142;
						case 71:
							num10 = 126;
							goto case 14;
						case 14:
							array3[6] = (byte)num10;
							num = 65;
							goto case 65;
						case 67:
							array3[5] = 149;
							num2 = 344;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 214;
						case 63:
							array3[16] = 120;
							goto case 240;
						case 61:
							array3[9] = 143;
							goto case 273;
						case 54:
							array3[27] = (byte)num10;
							goto case 32;
						case 32:
							num12 = 103;
							goto case 38;
						case 38:
							array3[27] = (byte)num12;
							goto case 114;
						case 53:
							num10 = 89;
							num2 = 242;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 13;
						case 13:
							array3[16] = (byte)num12;
							num2 = 63;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 63;
						case 52:
							array3[29] = 143;
							num2 = 25;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 46:
							num9 = 133;
							num = 357;
							goto case 357;
						case 40:
							array3[14] = 214;
							goto case 188;
						case 37:
							num14 = num13;
							num2 = 103;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
						case 36:
							array3[19] = (byte)num12;
							goto case 75;
						case 31:
							array3[6] = 123;
							goto case 380;
						case 30:
							array4[8] = 85;
							goto case 5;
						case 5:
							num11 = 63;
							goto case 157;
						case 29:
							array3[9] = (byte)num10;
							num2 = 110;
							if (!qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto case 227;
						case 26:
							array3[21] = 28;
							goto case 173;
						case 7:
							num10 = 99;
							num2 = 321;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						case 3:
							num9 = 133;
							goto case 341;
						default:
							num8 = (uint)((array2[num7 + 3] << 24) | (array2[num7 + 2] << 16) | (array2[num7 + 1] << 8) | array2[num7]);
							goto case 23;
						case 42:
							goto IL_268e;
						case 339:
							goto end_IL_268e;
						case 340:
							goto end_IL_26b8;
						case 73:
							deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress);
							goto case 117;
						case 117:
							try
							{
								Fjyi86yBV9iwXjnDcV(deflateStream, memoryStream);
								int num3 = 0;
								if (!qGjtnnjtflMieQX2ln())
								{
									num3 = num4;
								}
								switch (num3)
								{
								}
							}
							finally
							{
								if (deflateStream == null)
								{
									int num5 = 1;
									if (!qGjtnnjtflMieQX2ln())
									{
										num5 = num6;
									}
									switch (num5)
									{
									case 1:
									case 2:
										goto end_IL_2720;
									}
								}
								Y5h7IZSt5uwlyscSb7(deflateStream);
								end_IL_2720:;
							}
							goto case 377;
						case 377:
							lcR6HCFWNs = rjbmDOhXtM571MMlnJ(C4W5b7FX49phF9lGc4(memoryStream));
							goto case 213;
						case 213:
							iy8VYHOuQsH8nhFnPT(memoryStream);
							goto case 233;
						case 233:
						case 262:
						case 349:
							dq46q7X0jg = (string[])pRs9AWAuV8aEL9Ww3b((Assembly)lcR6HCFWNs);
							goto case 16;
						case 16:
							Jpt6PbOD2N = true;
							return;
						case 215:
							return;
							IL_1cf8:
							num2 = 180;
							if (qGjtnnjtflMieQX2ln())
							{
								continue;
							}
							goto IL_0085;
							IL_1bac:
							memoryStream = new MemoryStream();
							num2 = 73;
							if (TVISBRuet2jQFcqWkJ() == null)
							{
								continue;
							}
							goto IL_0085;
						}
						break;
					}
					goto IL_0531;
					IL_0531:
					array4[13] = 130;
					goto IL_0540;
					IL_0540:
					num11 = 92;
					num2 = 43;
					if (qGjtnnjtflMieQX2ln())
					{
						goto IL_0556;
					}
					goto IL_2044;
					IL_0556:
					array4[13] = (byte)num11;
					goto IL_0564;
					IL_0564:
					num11 = 80;
					goto IL_056a;
					IL_056a:
					array4[13] = (byte)num11;
					num2 = 217;
					if (TVISBRuet2jQFcqWkJ() != null)
					{
						goto IL_0085;
					}
					goto IL_2044;
					IL_0085:
					num2 = num;
					goto IL_2044;
					continue;
					end_IL_268e:
					break;
				}
				continue;
				end_IL_26b8:
				break;
			}
		}
	}

	internal static string[] RPS6o9vYnR(Assembly assembly_0)
	{
		if (assembly_0 == Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554468)).Assembly)
		{
			if (!Jpt6PbOD2N)
			{
				vXa6MRJAnO();
			}
			List<string> list = new List<string>();
			list.AddRange(assembly_0.GetManifestResourceNames());
			list.AddRange(((Assembly)lcR6HCFWNs).GetManifestResourceNames());
			return list.ToArray();
		}
		return assembly_0.GetManifestResourceNames();
	}

	private static Assembly WQF6AAmvuC(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (!Jpt6PbOD2N)
		{
			vXa6MRJAnO();
		}
		string name = resolveEventArgs_0.Name;
		int num = 0;
		while (true)
		{
			if (num < dq46q7X0jg.Length)
			{
				if (dq46q7X0jg[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)lcR6HCFWNs;
	}

	public rsjaykViX9KyK1HfHe()
	{
		AppDomain.CurrentDomain.ResourceResolve += WQF6AAmvuC;
		ogBUnd2ju1Vg8teO7c.E2gWFx4z4NEdd();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!kbH6FJKMSI)
		{
			kbH6FJKMSI = true;
			new rsjaykViX9KyK1HfHe();
		}
	}

	internal static Type eQX7wMXLmTQTAhQLCl(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object hMo5AvWvDx9pt8MjIS(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object PXihfIB0EY2NK25QIB(object object_0)
	{
		return ((awYSQNJbxdPDQ9b5BH.Mc8pUl5GpB1LDt3xfk)object_0).KDikMXewCI();
	}

	internal static void VlkW28t1k6TUPvdrXi(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long wBKP2Jd1B7Xg6f47Xg(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object AaBLadpgBDrusOy8Fi(object object_0, int int_0)
	{
		return ((awYSQNJbxdPDQ9b5BH.Mc8pUl5GpB1LDt3xfk)object_0).kJE6B3tUyy(int_0);
	}

	internal static object rjbmDOhXtM571MMlnJ(object object_0)
	{
		return CdLrnEy3qxZCGxspsk.fu76LExE0G((byte[])object_0);
	}

	internal static void Fjyi86yBV9iwXjnDcV(object object_0, object object_1)
	{
		((Stream)object_0).CopyTo((Stream)object_1);
	}

	internal static void Y5h7IZSt5uwlyscSb7(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object C4W5b7FX49phF9lGc4(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void iy8VYHOuQsH8nhFnPT(object object_0)
	{
		((Stream)object_0).Dispose();
	}

	internal static object s1UdSLgq8OJ2ftKvAo(object object_0, uint uint_0)
	{
		return CdLrnEy3qxZCGxspsk.CYn60EB0QP((byte[])object_0, uint_0);
	}

	internal static object pRs9AWAuV8aEL9Ww3b(object object_0)
	{
		return ((Assembly)object_0).GetManifestResourceNames();
	}

	internal static bool qGjtnnjtflMieQX2ln()
	{
		return (object)null == null;
	}

	internal static object TVISBRuet2jQFcqWkJ()
	{
		return null;
	}
}
