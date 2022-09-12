using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using cCMBEkOBGIwpDnI0MY;
using fJpF6sGRwSPY0tjIER;

namespace jakwNU33rVNTTAFGsOG;

internal class Bth0PV3YIsGNdXwJ6Tw
{
	private enum Kuf1pn3JHAqyQF9kle3
	{

	}

	internal class tQTpZA3dHULSNAjhgJh
	{
		private unsafe static uint c8erb0MxrL(void* pVoid_0, uint uint_0)
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

		private unsafe static bool uderuXWhtB(void* pVoid_0, void* pVoid_1, uint uint_0)
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

		private unsafe static void yobrsrvUlV(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = byte_0;
			}
		}

		private unsafe static void UcTra3OLiF(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = ((byte*)pVoid_1)[(int)num];
			}
		}

		private unsafe static void WtyrAtC3Z4(byte* pByte_0, byte* pByte_1, uint uint_0)
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
				UcTra3OLiF(pByte_0, pByte_1, uint_0);
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

		private unsafe static uint tnvrjc70vB(object object_0, uint uint_0, Kuf1pn3JHAqyQF9kle3 kuf1pn3JHAqyQF9kle3_0)
		{
			uint num = 0u;
			fixed (byte* ptr = object_0)
			{
				num = *(uint*)(ptr + (int)uint_0 + (nint)kuf1pn3JHAqyQF9kle3_0 * (nint)4);
			}
			return num;
		}

		public static uint yZGr1gBKRp(object object_0, uint uint_0)
		{
			return H3cGLlqUJ85FFIeTYOw(object_0, uint_0, (Kuf1pn3JHAqyQF9kle3)3);
		}

		private unsafe static uint vwRrwtWahe(object object_0, uint uint_0, object object_1)
		{
			fixed (byte* ptr = object_0)
			{
				fixed (byte* ptr4 = object_1)
				{
					byte* ptr2 = ptr + (int)uint_0;
					uint num = 32u;
					byte* ptr3 = ptr2 + 32;
					byte* ptr5 = ptr4;
					uint* ptr6 = (uint*)ptr2;
					byte* ptr7 = ptr4 + (int)c8erb0MxrL(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16];
					hxIJuYqKE6m20ZwYcIO(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					uint[] array2 = array;
					byte* ptr8 = ptr7 - 4;
					if (c8erb0MxrL(ptr6 + 4, 4u) != 1)
					{
						UcTra3OLiF(ptr4, ptr2 + (int)num, c8erb0MxrL(ptr6 + 3, 4u));
						return c8erb0MxrL(ptr6 + 3, 4u);
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
							num2 = c8erb0MxrL(ptr3, 4u);
							ptr3 += 4;
						}
						uint num3 = c8erb0MxrL(ptr3, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								WtyrAtC3Z4(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								WtyrAtC3Z4(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								WtyrAtC3Z4(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								WtyrAtC3Z4(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								WtyrAtC3Z4(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 4;
							}
							else
							{
								byte byte_ = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFFu;
								yobrsrvUlV(ptr5, byte_, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
						}
						else
						{
							WtyrAtC3Z4(ptr5, ptr3, 4u);
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

		internal static object M5wrXUUwpe(object object_0)
		{
			return k1wtZpquQqdD6eQ6nth(Type.GetTypeFromHandle(bj9iXgqk4Nd6VhiorPs(16777307)).GetMethod(XaXlykERDhtdRwMnBY.oXbWkAhpNa(1034), new Type[1] { L3seHgqbL2Sc906aCrW(typeof(byte[]).TypeHandle) }), null, new object[1] { object_0 });
		}

		public static byte[] PXUrnrN7fZ(object object_0, uint uint_0)
		{
			uint num = yZGr1gBKRp(object_0, uint_0);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				GfY3LXqzN81mRk6oSgW(object_0, uint_0, array);
			}
			return array;
		}

		internal static uint H3cGLlqUJ85FFIeTYOw(object object_0, uint uint_0, Kuf1pn3JHAqyQF9kle3 kuf1pn3JHAqyQF9kle3_0)
		{
			return tnvrjc70vB(object_0, uint_0, kuf1pn3JHAqyQF9kle3_0);
		}

		internal static void hxIJuYqKE6m20ZwYcIO(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
		}

		internal static RuntimeTypeHandle bj9iXgqk4Nd6VhiorPs(int token)
		{
			return aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(token);
		}

		internal static Type L3seHgqbL2Sc906aCrW(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object k1wtZpquQqdD6eQ6nth(object object_0, object object_1, object object_2)
		{
			return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
		}

		internal static uint GfY3LXqzN81mRk6oSgW(object object_0, uint uint_0, object object_1)
		{
			return vwRrwtWahe(object_0, uint_0, object_1);
		}
	}

	private static object TPVrW61gJ1 = new string[0];

	private static object Yqhr6mXOQp = null;

	private static bool XnprrsTVY5 = false;

	private static bool IMorIe6BtV = false;

	private static void jGOriMA3Iu()
	{
		int num = 94;
		int num6 = default(int);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		int num13 = default(int);
		byte[] array3 = default(byte[]);
		int num7 = default(int);
		byte[] array4 = default(byte[]);
		int num9 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array8 = default(byte[]);
		int num8 = default(int);
		int num27 = default(int);
		byte[] array6 = default(byte[]);
		int num29 = default(int);
		int num20 = default(int);
		uint num24 = default(uint);
		int num25 = default(int);
		int num18 = default(int);
		uint num12 = default(uint);
		uint num19 = default(uint);
		int num26 = default(int);
		int num28 = default(int);
		int num21 = default(int);
		int num30 = default(int);
		uint num23 = default(uint);
		uint num11 = default(uint);
		uint num10 = default(uint);
		uint num14 = default(uint);
		int num22 = default(int);
		uint num15 = default(uint);
		DeflateStream deflateStream = default(DeflateStream);
		MemoryStream memoryStream = default(MemoryStream);
		int num4 = default(int);
		while (!XnprrsTVY5)
		{
			while (true)
			{
				XaXlykERDhtdRwMnBY.rd18TrVMinA0PURbGA object_ = new XaXlykERDhtdRwMnBY.rd18TrVMinA0PURbGA((Stream)AulmimIOsnjQ0LmkVl(U7UgQ1waC8Z145hKMd(typeof(XaXlykERDhtdRwMnBY).TypeHandle).Assembly, XaXlykERDhtdRwMnBY.oXbWkAhpNa(39068)));
				while (true)
				{
					UyZprbfCa41o19FwBY(YB6o7W9l61xyvKyv5h(object_), 0L);
					while (true)
					{
						IL_27ce:
						byte[] array = new byte[0];
						int num2 = 197;
						if (oL95miJ4hTNwNyJwvL())
						{
							goto IL_159b;
						}
						goto IL_20fc;
						IL_20fc:
						while (true)
						{
							switch (num2)
							{
							case 433:
								num6 = 156;
								num = 199;
								goto case 199;
							case 199:
								array2[18] = (byte)num6;
								goto case 68;
							case 68:
								array2[18] = 229;
								num2 = 318;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 432:
								array2[11] = (byte)num6;
								goto case 374;
							case 374:
								array2[12] = 96;
								goto case 333;
							case 333:
								num6 = 108;
								num2 = 30;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 431:
								num6 = 58;
								goto case 173;
							case 173:
								array2[12] = (byte)num6;
								goto case 411;
							case 411:
								num5 = 107;
								num2 = 192;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 430:
								num13 = 185;
								num = 33;
								goto case 33;
							case 33:
								array3[1] = (byte)num13;
								num2 = 28;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 429:
								num6 = 69;
								goto case 207;
							case 207:
								array2[21] = (byte)num6;
								goto case 84;
							case 84:
								num6 = 214;
								num2 = 115;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 428:
								num7 = 108;
								goto case 195;
							case 195:
								array3[9] = (byte)num7;
								num2 = 108;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 283;
							case 283:
								num7 = 58;
								num2 = 77;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 427:
								array4[num9] = (byte)(array4[num9] ^ array5[num9]);
								goto case 109;
							case 109:
								num9++;
								goto case 163;
							case 163:
							case 347:
								if (num9 < array5.Length)
								{
									goto case 427;
								}
								num = 305;
								goto case 305;
							case 305:
								array7 = array8;
								goto case 303;
							case 303:
								num8 = array7.Length % 4;
								goto case 162;
							case 162:
								num27 = array7.Length / 4;
								num = 334;
								goto case 334;
							case 334:
								array6 = new byte[array7.Length];
								goto case 120;
							case 120:
								num29 = array4.Length / 4;
								num2 = 370;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								return;
							case 426:
								array2[27] = (byte)num5;
								num = 384;
								goto case 384;
							case 384:
								num6 = 58;
								num2 = 135;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 425:
								num13 = 127;
								goto case 287;
							case 287:
								array3[4] = (byte)num13;
								goto case 123;
							case 123:
								num7 = 116;
								goto case 278;
							case 278:
								array3[4] = (byte)num7;
								goto case 250;
							case 250:
								num13 = 144;
								num = 126;
								goto case 126;
							case 126:
								array3[4] = (byte)num13;
								num2 = 251;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 80;
							case 80:
							case 421:
								if (num20 < num8)
								{
									goto case 360;
								}
								goto case 76;
							case 360:
								if (num20 > 0)
								{
									goto case 69;
								}
								goto case 353;
							case 69:
								num24 <<= 8;
								num = 410;
								goto case 410;
							case 410:
								num25 += 8;
								goto case 353;
							case 353:
								array6[num18 + num20] = (byte)((num12 & num24) >> num25);
								num2 = 419;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 361;
							case 361:
								array6[num18 + 3] = (byte)((num19 & 0xFF000000u) >> 24);
								num = 76;
								goto case 76;
							case 76:
							case 322:
								num26++;
								goto case 13;
							case 13:
							case 395:
								if (num26 >= num27)
								{
									num2 = 26;
									if (yDUZW937Laq629rulx() != null)
									{
										continue;
									}
									goto case 132;
								}
								goto case 144;
							case 132:
								array = array6;
								goto case 34;
							case 34:
								num28 = num21;
								goto case 40;
							case 40:
								switch (num28)
								{
								case 1:
									goto IL_030a;
								case 0:
									goto IL_28bd;
								}
								goto case 65;
							case 65:
							case 186:
								Yqhr6mXOQp = bfDRpkpW58wcSY0dwr(as5NERkvunVsJnRCBm(array, 0u));
								num2 = 47;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 364:
								goto IL_030a;
							case 144:
								num30 = num26 % num29;
								goto case 362;
							case 362:
								num18 = num26 * 4;
								goto case 400;
							case 400:
								num23 = (uint)(num30 * 4);
								num2 = 224;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 195;
							case 424:
								num13 = 104;
								num2 = 387;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 423:
								array2[1] = (byte)num5;
								goto case 174;
							case 174:
								num5 = 253;
								goto case 124;
							case 124:
								array2[1] = (byte)num5;
								num2 = 62;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 422:
								array3[13] = 127;
								goto case 242;
							case 242:
								array3[13] = 215;
								goto case 166;
							case 166:
								array3[13] = 107;
								num2 = 200;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 420:
								num11 = 0u;
								num2 = 106;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 129;
							case 129:
								if (num8 > 0)
								{
									goto case 141;
								}
								goto case 225;
							case 141:
								num27++;
								num2 = 225;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 225:
								num23 = 0u;
								goto case 181;
							case 181:
								num26 = 0;
								num2 = 11;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 13;
							case 419:
								num20++;
								num2 = 421;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 418:
								break;
							case 211:
								goto IL_044e;
							case 57:
								goto IL_045c;
							case 417:
								array2[20] = 143;
								goto case 302;
							case 302:
								num6 = 165;
								goto case 17;
							case 17:
								array2[20] = (byte)num6;
								num = 297;
								goto case 297;
							case 297:
								num5 = 151;
								goto case 105;
							case 105:
								array2[20] = (byte)num5;
								goto case 386;
							case 386:
								num6 = 206;
								goto case 414;
							case 414:
								array2[20] = (byte)num6;
								num2 = 406;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 416:
								array2[11] = (byte)num5;
								goto case 23;
							case 23:
								array2[11] = 154;
								num2 = 100;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 415:
								array2[14] = 142;
								goto case 267;
							case 267:
								num6 = 103;
								num = 295;
								goto case 295;
							case 295:
								array2[14] = (byte)num6;
								num2 = 55;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 5;
							case 5:
								array2[27] = (byte)num6;
								goto case 43;
							case 43:
								num5 = 162;
								goto case 426;
							case 413:
								array3[11] = (byte)num13;
								num2 = 392;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 412:
								num13 = 64;
								goto case 282;
							case 282:
								array3[12] = (byte)num13;
								goto case 156;
							case 156:
								num7 = 144;
								goto case 312;
							case 312:
								array3[12] = (byte)num7;
								goto case 310;
							case 310:
								array3[12] = 123;
								num2 = 169;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 409:
								array3[4] = 87;
								num2 = 220;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 408:
								array3[10] = (byte)num13;
								goto case 230;
							case 230:
								array3[11] = 144;
								num = 338;
								goto case 338;
							case 338:
								num13 = 90;
								num2 = 413;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 407:
								array3 = new byte[16];
								goto case 165;
							case 165:
								num13 = 130;
								num2 = 158;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 406:
								num6 = 118;
								goto case 146;
							case 146:
								array2[21] = (byte)num6;
								num2 = 143;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 356;
							case 356:
								num6 = 86;
								num2 = 183;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 405:
								num6 = 215;
								num2 = 363;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 404:
								array2[8] = 136;
								goto case 249;
							case 249:
								array2[9] = 181;
								num2 = 232;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 403:
								array2[7] = (byte)num6;
								goto case 399;
							case 399:
								array2[7] = 102;
								goto case 178;
							case 178:
								num5 = 26;
								num2 = 216;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 402:
								array2[15] = 173;
								goto case 381;
							case 381:
								num5 = 89;
								goto case 281;
							case 281:
								array2[16] = (byte)num5;
								num2 = 150;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 401:
								if (num26 == num27 - 1)
								{
									num2 = 14;
									if (yDUZW937Laq629rulx() != null)
									{
										continue;
									}
									goto case 51;
								}
								goto case 336;
							case 51:
								if (num8 > 0)
								{
									num2 = 368;
									if (oL95miJ4hTNwNyJwvL())
									{
										continue;
									}
									goto case 213;
								}
								goto case 336;
							case 213:
								array2[31] = 128;
								goto case 379;
							case 379:
								num5 = 88;
								goto case 393;
							case 393:
								array2[31] = (byte)num5;
								num2 = 136;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 8;
							case 8:
								array2[15] = 119;
								goto case 89;
							case 89:
								array2[15] = 74;
								num2 = 402;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 336:
								num23 = (uint)num18;
								goto case 153;
							case 153:
								num10 += num14;
								goto case 348;
							case 348:
								num11 = (uint)((array7[num23 + 3] << 24) | (array7[num23 + 2] << 16) | (array7[num23 + 1] << 8) | array7[num23]);
								num2 = 82;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 398:
								num13 = 101;
								goto case 54;
							case 54:
								array3[10] = (byte)num13;
								goto case 114;
							case 114:
								array3[10] = 142;
								num = 52;
								goto case 52;
							case 52:
								array3[10] = 73;
								num2 = 255;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 313;
							case 313:
								num13 = 23;
								num2 = 408;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 121;
							case 121:
								array2[13] = 88;
								goto case 151;
							case 151:
								num6 = 144;
								num2 = 262;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 397:
								array6[num18] = (byte)(num19 & 0xFFu);
								num2 = 168;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 396:
								array2[2] = 162;
								num2 = 269;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 394:
								array3[11] = 68;
								goto case 125;
							case 125:
								array3[11] = 15;
								goto case 36;
							case 36:
								array3[12] = 103;
								goto case 388;
							case 388:
								array3[12] = 85;
								goto case 412;
							case 392:
								array3[11] = 148;
								num2 = 217;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 103;
							case 103:
								array3[7] = 134;
								num2 = 56;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 391:
								array2[13] = (byte)num5;
								num2 = 243;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 390:
								array3[13] = (byte)num13;
								goto case 422;
							case 389:
								array3[14] = 130;
								goto case 187;
							case 187:
								array3[14] = 186;
								goto case 9;
							case 9:
								array3[15] = 206;
								goto case 326;
							case 326:
								array3[15] = 123;
								goto case 204;
							case 204:
								array3[15] = 135;
								num = 424;
								goto case 424;
							case 387:
								array3[15] = (byte)num13;
								goto case 245;
							case 245:
								num7 = 118;
								goto case 233;
							case 233:
								array3[15] = (byte)num7;
								goto case 145;
							case 145:
								num7 = 198;
								num2 = 91;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 39;
							case 39:
								array2[6] = (byte)num5;
								num = 167;
								goto case 167;
							case 167:
								num6 = 88;
								goto case 272;
							case 272:
								array2[6] = (byte)num6;
								goto case 382;
							case 382:
								array2[6] = 113;
								num2 = 208;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 138;
							case 138:
								array2[30] = (byte)num6;
								goto case 328;
							case 328:
								array2[30] = 139;
								goto case 157;
							case 157:
								num6 = 120;
								num = 234;
								goto case 234;
							case 234:
								array2[30] = (byte)num6;
								goto case 72;
							case 72:
								array2[30] = 190;
								num2 = 298;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 210;
							case 210:
								array3[5] = 77;
								goto case 96;
							case 96:
								num7 = 117;
								goto case 376;
							case 376:
								array3[6] = (byte)num7;
								num2 = 11;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 385:
								num5 = 56;
								goto case 372;
							case 372:
								array2[22] = (byte)num5;
								goto case 378;
							case 378:
								array2[22] = 99;
								num = 108;
								goto case 108;
							case 108:
								array2[22] = 221;
								num2 = 332;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 383:
								array2[3] = (byte)num5;
								num2 = 128;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 380:
								num11 <<= 8;
								num2 = 64;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 41;
							case 41:
								num5 = 240;
								goto case 209;
							case 209:
								array2[3] = (byte)num5;
								goto case 87;
							case 87:
								num5 = 131;
								goto case 58;
							case 58:
								array2[4] = (byte)num5;
								goto case 160;
							case 160:
								array2[4] = 84;
								num = 311;
								goto case 311;
							case 311:
								num5 = 205;
								num2 = 373;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 377:
								array3[5] = (byte)num7;
								goto case 266;
							case 266:
								num7 = 152;
								num2 = 218;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 375:
								array3[3] = 176;
								goto case 409;
							case 373:
								array2[4] = (byte)num5;
								goto case 164;
							case 164:
								array2[4] = 170;
								goto case 324;
							case 324:
								num5 = 126;
								goto case 219;
							case 219:
								array2[5] = (byte)num5;
								goto case 49;
							case 49:
								array2[5] = 89;
								num2 = 122;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 371:
								array2[30] = 94;
								goto case 346;
							case 346:
								num6 = 160;
								goto case 138;
							case 370:
								num10 = 0u;
								num2 = 79;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 28;
							case 28:
								num7 = 139;
								num = 275;
								goto case 275;
							case 275:
								array3[2] = (byte)num7;
								num = 329;
								goto case 329;
							case 329:
								array3[2] = 153;
								num2 = 122;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 148;
							case 148:
								array3[2] = 144;
								num2 = 293;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 369:
								num5 = 122;
								num2 = 39;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 368:
								num11 = 0u;
								goto case 154;
							case 154:
								num10 += num14;
								goto case 304;
							case 304:
								num22 = 0;
								goto case 149;
							case 149:
							case 366:
								if (num22 >= num8)
								{
									goto case 82;
								}
								goto case 27;
							case 82:
							case 306:
								num15 = num10;
								goto case 255;
							case 255:
								num10 = 255u;
								num2 = 86;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 27:
								if (num22 > 0)
								{
									num2 = 380;
									if (oL95miJ4hTNwNyJwvL())
									{
										continue;
									}
									goto case 28;
								}
								goto case 64;
							case 64:
								num11 |= array7[^(1 + num22)];
								num2 = 221;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 367:
								num7 = 154;
								num2 = 308;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 365:
								num6 = 130;
								num2 = 59;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 6;
							case 6:
								array2[2] = (byte)num6;
								num2 = 396;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 363:
								array2[16] = (byte)num6;
								num2 = 349;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 181;
							case 359:
								num6 = 145;
								num2 = 222;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 358:
								array2[8] = (byte)num5;
								num2 = 265;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 357:
								if (num26 == num27 - 1)
								{
									num2 = 12;
									if (yDUZW937Laq629rulx() == null)
									{
										continue;
									}
									goto IL_004d;
								}
								goto case 75;
							case 75:
								num19 = num10 ^ num11;
								goto case 397;
							case 355:
								array2[16] = 245;
								goto case 95;
							case 95:
								num5 = 168;
								goto case 196;
							case 196:
								array2[17] = (byte)num5;
								goto case 83;
							case 83:
								num5 = 94;
								goto case 38;
							case 38:
								array2[17] = (byte)num5;
								num = 107;
								goto case 107;
							case 107:
								array2[17] = 126;
								num2 = 17;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 18;
							case 18:
								array2[18] = 130;
								goto case 433;
							case 354:
								array3[13] = 71;
								goto case 99;
							case 99:
								num13 = 89;
								goto case 390;
							case 352:
								num5 = 153;
								goto case 383;
							case 351:
								array3[1] = 14;
								goto case 14;
							case 14:
								num13 = 185;
								num2 = 299;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 350:
								num13 = 158;
								num2 = 180;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 349:
								num5 = 177;
								goto case 343;
							case 343:
								array2[16] = (byte)num5;
								goto case 143;
							case 143:
								num6 = 50;
								num2 = 341;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 338;
							case 345:
								num6 = 198;
								goto case 155;
							case 155:
								array2[28] = (byte)num6;
								goto case 223;
							case 223:
								num6 = 66;
								goto case 229;
							case 229:
								array2[28] = (byte)num6;
								goto case 45;
							case 45:
								num6 = 194;
								num = 259;
								goto case 259;
							case 259:
								array2[29] = (byte)num6;
								goto case 258;
							case 258:
								num5 = 108;
								num2 = 74;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 39;
							case 344:
								num13 = 108;
								num2 = 205;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 342:
								array2[24] = 138;
								goto case 273;
							case 273:
								num5 = 148;
								goto case 142;
							case 142:
								array2[24] = (byte)num5;
								goto case 238;
							case 238:
								array2[24] = 126;
								goto case 118;
							case 118:
								num6 = 142;
								num2 = 226;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 341:
								array2[16] = (byte)num6;
								num = 355;
								goto case 355;
							case 340:
								array2[0] = 206;
								goto case 172;
							case 172:
								array2[1] = 126;
								goto case 296;
							case 296:
								array2[1] = 137;
								goto case 50;
							case 50:
								array2[1] = 88;
								num2 = 92;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 337:
								num6 = 88;
								num2 = 5;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 335:
								num5 = 173;
								num2 = 321;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 332:
								num5 = 136;
								num2 = 0;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 331:
								array2[9] = (byte)num5;
								goto case 194;
							case 194:
								num6 = 213;
								goto case 276;
							case 276:
								array2[10] = (byte)num6;
								goto case 48;
							case 48:
								num6 = 78;
								num2 = 190;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 85;
							case 85:
								num13 = 168;
								goto case 301;
							case 301:
								array3[14] = (byte)num13;
								goto case 106;
							case 106:
								array3[14] = 52;
								goto case 389;
							case 330:
								array2[13] = (byte)num5;
								goto case 70;
							case 70:
								array2[14] = 185;
								num2 = 80;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 315;
							case 315:
								array2[14] = 88;
								num2 = 415;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 327:
								num24 = 255u;
								goto case 280;
							case 280:
								num25 = 0;
								goto case 401;
							case 325:
								array3[10] = 124;
								num2 = 398;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 323:
								array3[9] = (byte)num7;
								num2 = 415;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 428;
							case 321:
								array2[12] = (byte)num5;
								goto case 257;
							case 257:
								num5 = 101;
								num2 = 270;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 320:
								array2[23] = 68;
								num2 = 319;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 319:
								array2[24] = 95;
								num2 = 342;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 318:
								num6 = 112;
								num2 = 104;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 284;
							case 284:
								array2[18] = (byte)num6;
								num2 = 24;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 206;
							case 206:
								num5 = 40;
								num = 2;
								goto case 2;
							case 2:
								array2[18] = (byte)num5;
								goto case 237;
							case 237:
								array2[19] = 97;
								goto case 263;
							case 263:
								num6 = 111;
								goto case 26;
							case 26:
								array2[19] = (byte)num6;
								goto case 24;
							case 24:
								num6 = 178;
								goto case 202;
							case 202:
								array2[19] = (byte)num6;
								goto case 289;
							case 289:
								num6 = 124;
								goto case 316;
							case 316:
								array2[19] = (byte)num6;
								goto case 300;
							case 300:
								num6 = 94;
								goto case 152;
							case 152:
								array2[20] = (byte)num6;
								num2 = 290;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 417;
							case 317:
								array3[3] = 194;
								goto case 140;
							case 140:
								array3[3] = 190;
								num2 = 32;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 314:
								array3[7] = (byte)num7;
								goto case 260;
							case 260:
								num13 = 89;
								num2 = 185;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 201;
							case 201:
								array3[8] = (byte)num13;
								num2 = 344;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 75;
							case 309:
								array2[31] = 91;
								num = 112;
								goto case 112;
							case 112:
								array2[31] = 134;
								num2 = 98;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 308:
								array3[6] = (byte)num7;
								goto case 244;
							case 244:
								array3[6] = 163;
								num2 = 274;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 307:
								array2[26] = 93;
								goto case 337;
							case 299:
								array3[1] = (byte)num13;
								num2 = 23;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 31;
							case 31:
								array3[1] = 147;
								goto case 193;
							case 193:
								num13 = 136;
								num = 3;
								goto case 3;
							case 3:
								array3[1] = (byte)num13;
								goto case 430;
							case 298:
								num5 = 226;
								num = 286;
								goto case 286;
							case 286:
								array2[30] = (byte)num5;
								num2 = 213;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 132;
							case 294:
								array3[9] = (byte)num7;
								goto case 325;
							case 293:
								array3[2] = 57;
								num = 177;
								goto case 177;
							case 177:
								num13 = 97;
								goto case 214;
							case 214:
								array3[3] = (byte)num13;
								num2 = 9;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 10;
							case 10:
								array3[3] = 144;
								goto case 317;
							case 291:
								array3[12] = (byte)num7;
								num2 = 354;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 290:
								num5 = 40;
								goto case 330;
							case 288:
								goto IL_159b;
							case 25:
								goto IL_15b1;
							case 256:
								goto IL_15bf;
							case 285:
								num13 = 120;
								num2 = 37;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 279:
								num5 = 102;
								goto case 227;
							case 227:
								array2[5] = (byte)num5;
								num2 = 179;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 277:
								num10 = num15;
								goto case 357;
							case 274:
								array3[6] = 91;
								num2 = 78;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 64;
							case 271:
								array2[25] = 119;
								num2 = 240;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 214;
							case 270:
								array2[13] = (byte)num5;
								goto case 29;
							case 29:
								num5 = 141;
								goto case 391;
							case 269:
								array2[2] = 174;
								goto case 104;
							case 104:
								array2[3] = 139;
								goto case 352;
							case 265:
								array2[8] = 104;
								num2 = 276;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 404;
							case 262:
								array2[13] = (byte)num6;
								num2 = 290;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 261:
								array2[10] = (byte)num6;
								goto case 20;
							case 20:
								num6 = 154;
								num2 = 90;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 254:
								num7 = 124;
								num2 = 15;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 252:
								array2[25] = 221;
								goto case 67;
							case 67:
								num6 = 157;
								num2 = 3;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 88;
							case 88:
								array2[26] = (byte)num6;
								num2 = 111;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 251:
								array3[5] = 190;
								goto case 22;
							case 22:
								array3[5] = 120;
								goto case 53;
							case 53:
								num7 = 150;
								num2 = 377;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 248:
								array3[5] = 110;
								goto case 210;
							case 247:
								array3[9] = (byte)num13;
								goto case 110;
							case 110:
								num7 = 171;
								num2 = 294;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 246:
								array2[15] = 144;
								num2 = 8;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 243:
								array2[13] = 129;
								num2 = 121;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 240:
								array2[25] = 167;
								num2 = 101;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 239:
								num7 = 5;
								goto case 314;
							case 236:
								array2[7] = 51;
								goto case 134;
							case 134:
								num6 = 65;
								num2 = 61;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 235:
								array3[8] = 4;
								goto case 231;
							case 231:
								num7 = 96;
								goto case 323;
							case 232:
								array2[9] = 112;
								num = 102;
								goto case 102;
							case 102:
								num5 = 66;
								goto case 331;
							case 228:
								array2[12] = 143;
								goto case 335;
							case 226:
								array2[25] = (byte)num6;
								goto case 271;
							case 224:
								num14 = (uint)((array4[num23 + 3] << 24) | (array4[num23 + 2] << 16) | (array4[num23 + 1] << 8) | array4[num23]);
								num2 = 327;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 222:
								array2[28] = (byte)num6;
								goto case 345;
							case 221:
								num22++;
								num2 = 366;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 220:
								array3[4] = 102;
								goto case 425;
							case 218:
								array3[5] = (byte)num7;
								goto case 248;
							case 217:
								array3[11] = 100;
								num2 = 52;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 394;
							case 216:
								array2[7] = (byte)num5;
								goto case 236;
							case 215:
								array3[0] = 116;
								goto case 42;
							case 42:
								num13 = 167;
								goto case 46;
							case 46:
								array3[0] = (byte)num13;
								num2 = 350;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 212:
								num5 = 119;
								goto case 66;
							case 66:
								array2[29] = (byte)num5;
								num2 = 66;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 371;
							case 208:
								num5 = 119;
								goto case 130;
							case 130:
								array2[7] = (byte)num5;
								num2 = 184;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 205:
								array3[8] = (byte)num13;
								num2 = 235;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 203:
								num5 = 221;
								num = 170;
								goto case 170;
							case 170:
								array2[28] = (byte)num5;
								goto case 127;
							case 127:
								array2[28] = 159;
								goto case 359;
							case 200:
								num13 = 95;
								goto case 113;
							case 113:
								array3[14] = (byte)num13;
								goto case 254;
							case 198:
								array2[21] = 102;
								goto case 429;
							case 197:
								num13 = 130;
								num2 = 247;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 192:
								array2[12] = (byte)num5;
								goto case 228;
							case 191:
								num21 = 1;
								num2 = 21;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 190:
								array2[10] = (byte)num6;
								goto case 60;
							case 60:
								num6 = 101;
								num2 = 261;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 188:
								num5 = 164;
								goto case 423;
							case 184:
								num6 = 49;
								num2 = 403;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 183:
								array2[21] = (byte)num6;
								goto case 131;
							case 131:
								array2[21] = 112;
								num2 = 1;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 182:
								array2[5] = (byte)num5;
								goto case 279;
							case 180:
								array3[0] = (byte)num13;
								goto case 16;
							case 16:
								array3[0] = 98;
								num2 = 7;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 179:
								array2[5] = 83;
								num2 = 98;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 369;
							case 176:
								num20 = 0;
								goto case 80;
							case 171:
								array2[29] = 213;
								goto case 212;
							case 169:
								num7 = 75;
								num2 = 291;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 168:
								array6[num18 + 1] = (byte)((num19 & 0xFF00) >> 8);
								goto case 71;
							case 71:
								array6[num18 + 2] = (byte)((num19 & 0xFF0000) >> 16);
								goto case 361;
							case 161:
								array2[23] = 195;
								goto case 119;
							case 119:
								array2[23] = 154;
								goto case 365;
							case 159:
								array3[3] = (byte)num7;
								goto case 375;
							case 158:
								array3[0] = (byte)num13;
								num2 = 215;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 150:
								num6 = 127;
								num2 = 4;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 139:
								num5 = 86;
								goto case 19;
							case 19:
								array2[29] = (byte)num5;
								goto case 171;
							case 137:
								array5 = array3;
								goto case 191;
							case 136:
								array2[31] = 146;
								num = 309;
								goto case 309;
							case 135:
								array2[27] = (byte)num6;
								goto case 203;
							case 133:
								array2[14] = (byte)num6;
								num2 = 246;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 16;
							case 128:
								array2[3] = 126;
								goto case 41;
							case 122:
								num5 = 87;
								goto case 182;
							case 117:
								num5 = 149;
								goto case 358;
							case 116:
								num6 = 143;
								goto case 133;
							case 115:
								array2[22] = (byte)num6;
								goto case 385;
							case 111:
								array2[26] = 139;
								num = 307;
								goto case 307;
							case 101:
								array2[25] = 147;
								num = 252;
								goto case 252;
							case 100:
								num6 = 156;
								goto case 432;
							case 98:
								array4 = array2;
								goto case 407;
							case 97:
								array3[1] = (byte)num7;
								num2 = 179;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 351;
							case 92:
								array2[1] = 166;
								num2 = 188;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 91:
								array3[15] = (byte)num7;
								goto case 137;
							case 90:
								array2[11] = (byte)num6;
								num2 = 73;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 86:
							{
								uint num16 = num15;
								uint num17 = num15;
								num17 ^= num17 << 9;
								num17 += 1027490225;
								num17 ^= num17 >> 5;
								num17 += 3194358051u;
								num17 ^= num17 << 25;
								num17 += 1461015013;
								num17 = 402030592 + num17;
								num15 = num16 + (uint)(double)num17;
								goto case 277;
							}
							case 81:
								array3[7] = (byte)num13;
								num2 = 285;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 79:
								num14 = 0u;
								num2 = 420;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto case 357;
							case 78:
								array3[7] = 161;
								goto case 103;
							case 77:
								array3[9] = (byte)num7;
								num2 = 137;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 197;
							case 74:
								array2[29] = (byte)num5;
								goto case 139;
							case 73:
								num5 = 86;
								goto case 416;
							case 62:
								num6 = 155;
								num = 6;
								goto case 6;
							case 61:
								array2[8] = (byte)num6;
								num2 = 117;
								if (oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto IL_004d;
							case 59:
								array2[23] = (byte)num6;
								num2 = 174;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 320;
							case 56:
								num13 = 31;
								goto case 81;
							case 55:
								array2[14] = 103;
								num2 = 116;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 37:
								array3[7] = (byte)num13;
								num2 = 100;
								if (yDUZW937Laq629rulx() != null)
								{
									continue;
								}
								goto case 239;
							case 35:
								num12 = num10 ^ num11;
								goto case 176;
							case 32:
								num7 = 122;
								num = 159;
								goto case 159;
							case 30:
								array2[12] = (byte)num6;
								goto case 431;
							case 21:
								num9 = 0;
								goto case 163;
							case 15:
								array3[14] = (byte)num7;
								num2 = 85;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							case 12:
								if (num8 <= 0)
								{
									goto case 75;
								}
								num = 35;
								goto case 35;
							case 11:
								array3[6] = 141;
								goto case 367;
							case 7:
								num7 = 137;
								num = 97;
								goto case 97;
							case 4:
								array2[16] = (byte)num6;
								num2 = 237;
								if (!oL95miJ4hTNwNyJwvL())
								{
									continue;
								}
								goto case 405;
							case 1:
								array2[21] = 139;
								num = 198;
								goto case 198;
							default:
								array2[23] = (byte)num5;
								num = 161;
								goto case 161;
							case 44:
								goto IL_27ce;
							case 63:
								goto end_IL_27ce;
							case 339:
								goto end_IL_27eb;
							case 94:
								goto end_IL_2802;
							case 264:
								deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress);
								goto case 185;
							case 185:
								try
								{
									C4DYlHiwTm2bSpWEVN(deflateStream, memoryStream);
									if (oL95miJ4hTNwNyJwvL())
									{
										switch (0)
										{
										}
									}
								}
								finally
								{
									int num3;
									if (deflateStream != null)
									{
										num3 = 0;
										if (yDUZW937Laq629rulx() != null)
										{
											goto IL_288f;
										}
										goto IL_2893;
									}
									goto end_IL_2868;
									IL_288f:
									num3 = num4;
									goto IL_2893;
									IL_2893:
									while (true)
									{
										switch (num3)
										{
										case 1:
											goto end_IL_2893;
										}
										rWeI9gnx3WNV3ljLvZ(deflateStream);
										num3 = 1;
										if (yDUZW937Laq629rulx() == null)
										{
											continue;
										}
										goto IL_288f;
										continue;
										end_IL_2893:
										break;
									}
									end_IL_2868:;
								}
								goto case 147;
							case 147:
								Yqhr6mXOQp = bfDRpkpW58wcSY0dwr(gtaG6whgt7e3Lh0JZx(memoryStream));
								goto case 292;
							case 292:
								YQNM0vFtUs50MhxfEg(memoryStream);
								goto case 47;
							case 189:
								goto IL_28bd;
							case 47:
							case 241:
							case 253:
								TPVrW61gJ1 = X3FLqKaAPqbFZq219A((Assembly)Yqhr6mXOQp);
								goto case 268;
							case 268:
								XnprrsTVY5 = true;
								return;
							case 93:
							case 175:
								return;
								IL_28bd:
								Yqhr6mXOQp = bfDRpkpW58wcSY0dwr(array);
								goto case 47;
								IL_030a:
								memoryStream = new MemoryStream();
								num2 = 264;
								if (yDUZW937Laq629rulx() == null)
								{
									continue;
								}
								goto IL_004d;
							}
							break;
						}
						goto IL_0448;
						IL_159b:
						array8 = (byte[])wZPnsLmn7eWxe0m2o0(object_, (int)XHPCEfMNCJgiLZbaYO(YB6o7W9l61xyvKyv5h(object_)));
						goto IL_15b1;
						IL_15b1:
						array2 = new byte[32];
						goto IL_15bf;
						IL_15bf:
						array2[0] = 130;
						goto IL_0448;
						IL_0448:
						num6 = 116;
						goto IL_044e;
						IL_044e:
						array2[0] = (byte)num6;
						goto IL_045c;
						IL_045c:
						array2[0] = 167;
						num2 = 340;
						if (!oL95miJ4hTNwNyJwvL())
						{
							goto IL_004d;
						}
						goto IL_20fc;
						IL_004d:
						num2 = num;
						goto IL_20fc;
						continue;
						end_IL_27ce:
						break;
					}
					continue;
					end_IL_27eb:
					break;
				}
				continue;
				end_IL_2802:
				break;
			}
		}
	}

	internal static string[] ghcrlmEQ4v(object object_0)
	{
		if ((Assembly?)object_0 == Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554490)).Assembly)
		{
			if (!XnprrsTVY5)
			{
				jGOriMA3Iu();
			}
			List<string> list = new List<string>();
			list.AddRange(((Assembly)object_0).GetManifestResourceNames());
			list.AddRange(((Assembly)Yqhr6mXOQp).GetManifestResourceNames());
			return list.ToArray();
		}
		return ((Assembly)object_0).GetManifestResourceNames();
	}

	private static Assembly OAtrND4iia(object object_0, object object_1)
	{
		if (!XnprrsTVY5)
		{
			jGOriMA3Iu();
		}
		string name = ((ResolveEventArgs)object_1).Name;
		int num = 0;
		while (true)
		{
			if (num < ((Array)TPVrW61gJ1).Length)
			{
				if ((string?)((object[])TPVrW61gJ1)[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)Yqhr6mXOQp;
	}

	public Bth0PV3YIsGNdXwJ6Tw()
	{
		AppDomain.CurrentDomain.ResourceResolve += OAtrND4iia;
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!IMorIe6BtV)
		{
			IMorIe6BtV = true;
			new Bth0PV3YIsGNdXwJ6Tw();
		}
	}

	internal static Type U7UgQ1waC8Z145hKMd(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object AulmimIOsnjQ0LmkVl(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object YB6o7W9l61xyvKyv5h(object object_0)
	{
		return ((XaXlykERDhtdRwMnBY.rd18TrVMinA0PURbGA)object_0).fHSkdAnkJf();
	}

	internal static void UyZprbfCa41o19FwBY(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long XHPCEfMNCJgiLZbaYO(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object wZPnsLmn7eWxe0m2o0(object object_0, int int_0)
	{
		return ((XaXlykERDhtdRwMnBY.rd18TrVMinA0PURbGA)object_0).SAd6vG5PDN(int_0);
	}

	internal static object bfDRpkpW58wcSY0dwr(object object_0)
	{
		return tQTpZA3dHULSNAjhgJh.M5wrXUUwpe(object_0);
	}

	internal static void C4DYlHiwTm2bSpWEVN(object object_0, object object_1)
	{
		((Stream)object_0).CopyTo((Stream)object_1);
	}

	internal static void rWeI9gnx3WNV3ljLvZ(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object gtaG6whgt7e3Lh0JZx(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void YQNM0vFtUs50MhxfEg(object object_0)
	{
		((Stream)object_0).Dispose();
	}

	internal static object as5NERkvunVsJnRCBm(object object_0, uint uint_0)
	{
		return tQTpZA3dHULSNAjhgJh.PXUrnrN7fZ(object_0, uint_0);
	}

	internal static object X3FLqKaAPqbFZq219A(object object_0)
	{
		return ((Assembly)object_0).GetManifestResourceNames();
	}

	internal static bool oL95miJ4hTNwNyJwvL()
	{
		return (object)null == null;
	}

	internal static object yDUZW937Laq629rulx()
	{
		return null;
	}
}
