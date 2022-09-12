using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

internal class Class11
{
	private enum Enum0
	{

	}

	internal class Class12
	{
		private unsafe static uint smethod_0(void* pVoid_0, uint uint_0)
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

		private unsafe static void smethod_1(uint uint_0, void* pVoid_0, uint uint_1)
		{
			if (BitConverter.IsLittleEndian)
			{
				switch (uint_1)
				{
				case 1u:
					*(byte*)pVoid_0 = (byte)uint_0;
					break;
				case 2u:
				case 3u:
				case 4u:
					*(uint*)pVoid_0 = uint_0;
					break;
				}
				return;
			}
			switch (uint_1)
			{
			case 1u:
				*(byte*)pVoid_0 = (byte)uint_0;
				break;
			case 2u:
				*(byte*)pVoid_0 = (byte)uint_0;
				((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
				break;
			case 3u:
				*(byte*)pVoid_0 = (byte)uint_0;
				((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
				((byte*)pVoid_0)[2] = (byte)(uint_0 >> 16);
				break;
			case 4u:
				*(byte*)pVoid_0 = (byte)uint_0;
				((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
				((byte*)pVoid_0)[2] = (byte)(uint_0 >> 16);
				((byte*)pVoid_0)[3] = (byte)(uint_0 >> 24);
				break;
			}
		}

		private unsafe static bool smethod_2(void* pVoid_0, void* pVoid_1, uint uint_0)
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

		private unsafe static bool smethod_3(void* pVoid_0, string string_0)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			fixed (byte* pVoid_ = bytes)
			{
				return smethod_2(pVoid_0, pVoid_, (uint)bytes.Length);
			}
		}

		private unsafe static void smethod_4(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = byte_0;
			}
		}

		private unsafe static void smethod_5(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num++)
			{
				((byte*)pVoid_0)[(int)num] = ((byte*)pVoid_1)[(int)num];
			}
		}

		private unsafe static void smethod_6(void* pVoid_0, string string_0)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			fixed (byte* pVoid_ = bytes)
			{
				smethod_5(pVoid_0, pVoid_, (uint)bytes.Length);
			}
		}

		private unsafe static void smethod_7(byte* pByte_0, byte* pByte_1, uint uint_0)
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
				smethod_5(pByte_0, pByte_1, uint_0);
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

		private unsafe static uint smethod_8(byte[] byte_0, uint uint_0, Enum0 enum0_0)
		{
			uint result = 0u;
			fixed (byte* ptr = byte_0)
			{
				if (smethod_3(ptr + (int)uint_0, "QCLZ"))
				{
					result = *(uint*)(ptr + (int)uint_0 + (nint)enum0_0 * (nint)4);
				}
			}
			return result;
		}

		private static uint smethod_9(byte[] byte_0)
		{
			return smethod_8(byte_0, 0u, (Enum0)2);
		}

		public static uint smethod_10(byte[] byte_0, uint uint_0)
		{
			return smethod_8(byte_0, uint_0, (Enum0)3);
		}

		private unsafe static uint smethod_11(byte[] byte_0, uint uint_0, byte[] byte_1, uint uint_1)
		{
			fixed (byte* ptr = byte_0)
			{
				fixed (byte* ptr5 = byte_1)
				{
					byte* ptr2 = ptr + (int)uint_0;
					uint num = 32u;
					byte* ptr3 = ptr2 + (int)uint_1 - 1;
					byte* ptr4 = ptr2 + 1;
					byte** ptr6 = (byte**)(ptr5 + (int)uint_1 + 36000 - (nint)sizeof(byte*) * (nint)4096 - (long)(ptr5 + (int)uint_1) % 8L);
					byte* pVoid_ = ptr5 + 32;
					byte* ptr7 = ptr5 + 32 + 4 + 1;
					byte* ptr8 = ptr7;
					byte* ptr9 = ptr4;
					uint num2 = 1073741824u;
					uint* ptr10 = (uint*)ptr5;
					byte* ptr11 = ptr3 - 16;
					smethod_6(ptr10, "QCLZ");
					*ptr5 = 81;
					ptr5[1] = 67;
					ptr5[2] = 76;
					ptr5[3] = 90;
					smethod_1(3u, ptr10 + 1, 4u);
					smethod_1(uint_1, ptr10 + 3, 4u);
					for (uint num3 = 0u; num3 < 4096; num3++)
					{
						ptr6[num3] = ptr2;
					}
					(ptr5 + (int)num)[4] = *ptr2;
					while (ptr4 < ptr11 - 2050u)
					{
						if ((num2 & 1) == 1)
						{
							if (ptr7 + 2050u + 128 > ptr5 + (int)uint_1 + 2050u + 256)
							{
								smethod_5(ptr5 + (int)num, ptr2, uint_1);
								smethod_1(0u, ptr10 + 4, 4u);
								smethod_1(uint_1 + num + 4, ptr10 + 2, 4u);
								smethod_6(ptr5 + (int)smethod_0(ptr10 + 2, 4u) - 4, "QCLZ");
								return smethod_0(ptr10 + 2, 4u);
							}
							smethod_1((uint)((num2 >> 1) | 0xFFFFFFFF80000000uL), pVoid_, 4u);
							pVoid_ = ptr7;
							ptr7 += 4;
							num2 = 2147483648u;
							if (ptr7 - ptr8 > ptr4 - ptr9 && ptr4 + 4100u < ptr11)
							{
								for (; ptr4 < ptr9 + 2050u - 32; ptr4 += 31)
								{
									smethod_1(2147483648u, ptr7 - 4, 4u);
									smethod_7(ptr7, ptr4, 31u);
									ptr7 += 35;
								}
								ptr9 = ptr4;
								ptr8 = ptr7;
								pVoid_ = ptr7 - 4;
							}
						}
						uint num4;
						if (smethod_0(ptr4, 4u) == smethod_0(ptr4 + 1, 4u))
						{
							num4 = smethod_0(ptr4, 4u);
							byte* ptr12 = ptr4;
							for (ptr4 += 5; num4 == smethod_0(ptr4, 4u) && ptr4 < ptr12 + 2050u - 4; ptr4 += 4)
							{
							}
							smethod_1(((num4 & 0xFF) << 16) | (uint)(int)(ptr4 - ptr12 << 4) | 0xFu, ptr7, 4u);
							ptr7 += 3;
							num2 = (num2 >> 1) | 0x80000000u;
							continue;
						}
						num4 = smethod_0(ptr4, 4u);
						uint num3 = ((num4 >> 12) ^ num4) & 0xFFFu;
						byte* ptr13 = ptr6[num3];
						ptr6[num3] = ptr4;
						if ((!BitConverter.IsLittleEndian) ? (ptr4 - ptr13 <= 131071L && ptr4 - ptr13 > 3L && *ptr4 == *ptr13 && ptr4[1] == ptr13[1] && ptr4[2] == ptr13[2]) : (ptr4 - ptr13 <= 131071L && ptr4 - ptr13 > 3L && ((*(uint*)ptr13 ^ *(uint*)ptr4) & 0xFFFFFF) == 0))
						{
							uint num5 = (uint)(ptr4 - ptr13);
							if ((!BitConverter.IsLittleEndian) ? (ptr13[3] != ptr4[3]) : (*(uint*)ptr13 != *(uint*)ptr4))
							{
								if (num5 <= 63)
								{
									*ptr7 = (byte)(num5 << 2);
									ptr7++;
									num2 = (num2 >> 1) | 0x80000000u;
									ptr4 += 3;
								}
								else if (num5 <= 16383)
								{
									uint uint_2 = (num5 << 2) | 1u;
									smethod_1(uint_2, ptr7, 2u);
									ptr7 += 2;
									num2 = (num2 >> 1) | 0x80000000u;
									ptr4 += 3;
								}
								else
								{
									*ptr7 = *ptr4;
									ptr7++;
									ptr4++;
									num2 >>= 1;
								}
								continue;
							}
							num2 = (num2 >> 1) | 0x80000000u;
							uint num6;
							for (num6 = 3u; ptr13[(int)num6] == ptr4[(int)num6] && num6 < 2050; num6++)
							{
							}
							ptr4 += (int)num6;
							if (num6 <= 18 && num5 <= 1023)
							{
								uint uint_3 = (num6 - 3 << 2) | (num5 << 6) | 2u;
								smethod_1(uint_3, ptr7, 2u);
								ptr7 += 2;
							}
							else if (num6 <= 34 && num5 <= 65535)
							{
								uint uint_4 = (num6 - 3 << 3) | (num5 << 8) | 3u;
								smethod_1(uint_4, ptr7, 3u);
								ptr7 += 3;
							}
							else if (num6 >= 3)
							{
								uint uint_5 = (num6 - 3 << 4) | (num5 << 15) | 7u;
								smethod_1(uint_5, ptr7, 4u);
								ptr7 += 4;
							}
						}
						else
						{
							*ptr7 = *ptr4;
							ptr7++;
							ptr4++;
							num2 >>= 1;
						}
					}
					while (ptr4 <= ptr3)
					{
						if ((num2 & 1) == 1)
						{
							smethod_1((num2 >> 1) | 0x80000000u, pVoid_, 4u);
							pVoid_ = ptr7;
							ptr7 += 4;
							num2 = 2147483648u;
						}
						*ptr7 = *ptr4;
						ptr7++;
						ptr4++;
						num2 >>= 1;
					}
					while ((num2 & 1) != 1)
					{
						num2 >>= 1;
					}
					smethod_1((num2 >> 1) | 0x80000000u, pVoid_, 4u);
					ptr7 += 4;
					smethod_1(1u, ptr10 + 4, 4u);
					smethod_1((uint)(ptr7 - ptr5 - 1L + 4L), ptr10 + 2, 4u);
					smethod_6(ptr5 + (int)smethod_0(ptr10 + 2, 4u) - 4, "QCLZ");
				}
			}
			return smethod_9(byte_1);
		}

		private unsafe static uint smethod_12(byte[] byte_0, uint uint_0, byte[] byte_1)
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
					byte* ptr7 = ptr4 + (int)smethod_0(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (!smethod_3(ptr6, "QCLZ"))
					{
						return 0u;
					}
					if (smethod_0(ptr6 + 1, 4u) != 3)
					{
						return 0u;
					}
					if (!smethod_3(ptr2 + (int)smethod_0(ptr6 + 2, 4u) - 4, "QCLZ"))
					{
						return 0u;
					}
					if (smethod_0(ptr6 + 4, 4u) != 1)
					{
						smethod_5(ptr4, ptr2 + (int)num, smethod_0(ptr6 + 3, 4u));
						return smethod_0(ptr6 + 3, 4u);
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
							num2 = smethod_0(ptr3, 4u);
							ptr3 += 4;
						}
						uint num3 = smethod_0(ptr3, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								smethod_7(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								smethod_7(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								smethod_7(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								smethod_7(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								smethod_7(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 4;
							}
							else
							{
								byte byte_2 = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFFu;
								smethod_4(ptr5, byte_2, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
						}
						else
						{
							smethod_7(ptr5, ptr3, 4u);
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

		private static byte[] smethod_13(string string_0)
		{
			byte[] array = null;
			FileStream fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				return array;
			}
			finally
			{
				fileStream.Close();
			}
		}

		public static byte[] smethod_14(string string_0)
		{
			byte[] byte_ = smethod_13(string_0);
			return smethod_16(byte_);
		}

		public static byte[] smethod_15(string string_0)
		{
			byte[] byte_ = smethod_13(string_0);
			return smethod_17(byte_);
		}

		public static byte[] smethod_16(byte[] byte_0)
		{
			return smethod_19(byte_0, 0u, Convert.ToUInt32(byte_0.Length));
		}

		public static byte[] smethod_17(byte[] byte_0)
		{
			return smethod_20(byte_0, 0u);
		}

		internal static object smethod_18(byte[] byte_0)
		{
			return typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) })!.Invoke(null, new object[1] { byte_0 });
		}

		public static byte[] smethod_19(byte[] byte_0, uint uint_0, uint uint_1)
		{
			byte[] array = new byte[uint_1 + 36000];
			uint num = smethod_11(byte_0, uint_0, array, uint_1);
			byte[] array2 = new byte[num];
			for (uint num2 = 0u; num2 < num; num2++)
			{
				array2[num2] = array[num2];
			}
			return array2;
		}

		public static byte[] smethod_20(byte[] byte_0, uint uint_0)
		{
			uint num = smethod_10(byte_0, uint_0);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				smethod_12(byte_0, uint_0, array);
			}
			return array;
		}

		public Class12()
		{
			Class10.tgfoa2wzNAwc9();
			base._002Ector();
		}
	}

	private static string[] string_0;

	private static object object_0;

	private static bool bool_0;

	private static bool bool_1;

	private static void smethod_0()
	{
		if (bool_0)
		{
			return;
		}
		BinaryReader binaryReader = new BinaryReader(typeof(Class11).Assembly.GetManifestResourceStream("8Q7Tm9wiyj4X9qQLl3.uWB92uScHIryuU7i12"));
		binaryReader.BaseStream.Position = 0L;
		byte[] array = new byte[0];
		byte[] array2 = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
		byte[] array3 = new byte[32];
		array3[0] = 180;
		array3[0] = 111;
		array3[0] = 151;
		array3[1] = 143;
		array3[1] = 98;
		array3[1] = 124;
		array3[1] = 53;
		array3[1] = 155;
		array3[1] = 112;
		array3[2] = 125;
		array3[2] = 186;
		array3[2] = 108;
		array3[2] = 193;
		array3[2] = 155;
		array3[2] = 155;
		array3[3] = 116;
		array3[3] = 84;
		array3[3] = 156;
		array3[3] = 174;
		array3[3] = 166;
		array3[4] = 85;
		array3[4] = 137;
		array3[4] = 175;
		array3[4] = 11;
		array3[5] = 118;
		array3[5] = 97;
		array3[5] = 86;
		array3[5] = 127;
		array3[5] = 25;
		array3[6] = 72;
		array3[6] = 110;
		array3[6] = 130;
		array3[7] = 152;
		array3[7] = 167;
		array3[7] = 132;
		array3[7] = 88;
		array3[7] = 162;
		array3[7] = 139;
		array3[8] = 136;
		array3[8] = 146;
		array3[8] = 158;
		array3[8] = 11;
		array3[9] = 90;
		array3[9] = 143;
		array3[9] = 222;
		array3[10] = 83;
		array3[10] = 106;
		array3[10] = 212;
		array3[11] = 164;
		array3[11] = 26;
		array3[11] = 213;
		array3[11] = 159;
		array3[11] = 78;
		array3[12] = 119;
		array3[12] = 145;
		array3[12] = 81;
		array3[12] = 182;
		array3[12] = 65;
		array3[12] = 215;
		array3[13] = 97;
		array3[13] = 146;
		array3[13] = 205;
		array3[13] = 88;
		array3[13] = 223;
		array3[14] = 147;
		array3[14] = 179;
		array3[14] = 227;
		array3[15] = 106;
		array3[15] = 84;
		array3[15] = 84;
		array3[15] = 147;
		array3[15] = 183;
		array3[16] = 109;
		array3[16] = 157;
		array3[16] = 59;
		array3[16] = 15;
		array3[17] = 129;
		array3[17] = 129;
		array3[17] = 154;
		array3[17] = 181;
		array3[17] = 131;
		array3[17] = 64;
		array3[18] = 94;
		array3[18] = 125;
		array3[18] = 94;
		array3[18] = 186;
		array3[18] = 115;
		array3[19] = 168;
		array3[19] = 132;
		array3[19] = 216;
		array3[19] = 80;
		array3[19] = 75;
		array3[20] = 106;
		array3[20] = 68;
		array3[20] = 147;
		array3[21] = 16;
		array3[21] = 122;
		array3[21] = 136;
		array3[21] = 109;
		array3[21] = 105;
		array3[22] = 113;
		array3[22] = 150;
		array3[22] = 166;
		array3[22] = 102;
		array3[22] = 135;
		array3[22] = 86;
		array3[23] = 102;
		array3[23] = 113;
		array3[23] = 120;
		array3[24] = 96;
		array3[24] = 121;
		array3[24] = 112;
		array3[24] = 216;
		array3[24] = 107;
		array3[25] = 94;
		array3[25] = 166;
		array3[25] = 65;
		array3[25] = 207;
		array3[25] = 116;
		array3[25] = 59;
		array3[26] = 150;
		array3[26] = 55;
		array3[26] = 97;
		array3[26] = 96;
		array3[26] = 111;
		array3[26] = 54;
		array3[27] = 156;
		array3[27] = 90;
		array3[27] = 141;
		array3[27] = 116;
		array3[27] = 247;
		array3[28] = 132;
		array3[28] = 99;
		array3[28] = 190;
		array3[28] = 121;
		array3[28] = 176;
		array3[28] = 60;
		array3[29] = 198;
		array3[29] = 156;
		array3[29] = 149;
		array3[29] = 123;
		array3[30] = 89;
		array3[30] = 152;
		array3[30] = 5;
		array3[31] = 84;
		array3[31] = 105;
		array3[31] = 205;
		byte[] array4 = array3;
		byte[] array5 = new byte[16];
		array5[0] = 161;
		array5[0] = 40;
		array5[0] = 136;
		array5[0] = 80;
		array5[0] = 207;
		array5[1] = 211;
		array5[1] = 140;
		array5[1] = 131;
		array5[1] = 102;
		array5[2] = 133;
		array5[2] = 93;
		array5[2] = 167;
		array5[2] = 121;
		array5[3] = 154;
		array5[3] = 160;
		array5[3] = 50;
		array5[4] = 162;
		array5[4] = 162;
		array5[4] = 135;
		array5[4] = 102;
		array5[4] = 20;
		array5[5] = 216;
		array5[5] = 154;
		array5[5] = 198;
		array5[6] = 164;
		array5[6] = 134;
		array5[6] = 245;
		array5[7] = 172;
		array5[7] = 143;
		array5[7] = 162;
		array5[7] = 92;
		array5[7] = 161;
		array5[7] = 213;
		array5[8] = 136;
		array5[8] = 66;
		array5[8] = 90;
		array5[8] = 144;
		array5[8] = 141;
		array5[9] = 210;
		array5[9] = 170;
		array5[9] = 117;
		array5[9] = 98;
		array5[9] = 88;
		array5[9] = 64;
		array5[10] = 68;
		array5[10] = 120;
		array5[10] = 129;
		array5[10] = 49;
		array5[11] = 193;
		array5[11] = 133;
		array5[11] = 90;
		array5[11] = 118;
		array5[12] = 118;
		array5[12] = 161;
		array5[12] = 145;
		array5[12] = 148;
		array5[13] = 47;
		array5[13] = 98;
		array5[13] = 224;
		array5[14] = 122;
		array5[14] = 36;
		array5[14] = 120;
		array5[14] = 119;
		array5[14] = 241;
		array5[15] = 92;
		array5[15] = 166;
		array5[15] = 169;
		array5[15] = 136;
		array5[15] = 17;
		byte[] array6 = array5;
		for (int i = 0; i < array6.Length; i++)
		{
			array4[i] = (byte)(array4[i] ^ array6[i]);
		}
		byte[] array7 = array2;
		int num = array7.Length % 4;
		int num2 = array7.Length / 4;
		byte[] array8 = new byte[array7.Length];
		int num3 = array4.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int j = 0; j < num2; j++)
		{
			int num8 = j % num3;
			int num9 = j * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((array4[num7 + 3] << 24) | (array4[num7 + 2] << 16) | (array4[num7 + 1] << 8) | array4[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (j == num2 - 1 && num > 0)
			{
				num6 = 0u;
				num4 += num5;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num6 <<= 8;
					}
					num6 |= array7[^(1 + k)];
				}
			}
			else
			{
				num7 = (uint)num9;
				num4 += num5;
				num6 = (uint)((array7[num7 + 3] << 24) | (array7[num7 + 2] << 16) | (array7[num7 + 1] << 8) | array7[num7]);
			}
			uint num12 = num4;
			num4 = 255u;
			uint num13 = num12;
			uint num14 = num12;
			num14 ^= num14 << 4;
			num14 += 1459031946;
			num14 ^= num14 >> 5;
			num14 += 1552011460;
			num14 ^= num14 << 15;
			num14 += 1676819113;
			num14 = 1684643662 - num14;
			num12 = num13 + (uint)(double)num14;
			num4 = num12;
			if (j == num2 - 1 && num > 0)
			{
				uint num15 = num4 ^ num6;
				for (int l = 0; l < num; l++)
				{
					if (l > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array8[num9 + l] = (byte)((num15 & num10) >> num11);
				}
			}
			else
			{
				uint num16 = num4 ^ num6;
				array8[num9] = (byte)(num16 & 0xFFu);
				array8[num9 + 1] = (byte)((num16 & 0xFF00) >> 8);
				array8[num9 + 2] = (byte)((num16 & 0xFF0000) >> 16);
				array8[num9 + 3] = (byte)((num16 & 0xFF000000u) >> 24);
			}
		}
		array = array8;
		object_0 = Class12.smethod_18(Class12.smethod_17(array));
		string_0 = ((Assembly)object_0).GetManifestResourceNames();
		bool_0 = true;
	}

	internal static string[] smethod_1(Assembly assembly_0)
	{
		if (assembly_0 == typeof(Class11).Assembly)
		{
			if (!bool_0)
			{
				smethod_0();
			}
			List<string> list = new List<string>();
			list.AddRange(assembly_0.GetManifestResourceNames());
			list.AddRange(((Assembly)object_0).GetManifestResourceNames());
			return list.ToArray();
		}
		return assembly_0.GetManifestResourceNames();
	}

	private static Assembly smethod_2(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		if (!bool_0)
		{
			smethod_0();
		}
		string name = resolveEventArgs_0.Name;
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)object_0;
	}

	public Class11()
	{
		AppDomain.CurrentDomain.ResourceResolve += smethod_2;
	}

	internal static void EqJlXr3SvrHew()
	{
		if (!bool_1)
		{
			bool_1 = true;
			new Class11();
		}
	}

	static Class11()
	{
		string_0 = new string[0];
		object_0 = null;
		bool_0 = false;
		bool_1 = false;
	}
}
