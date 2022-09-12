using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

internal class Class8
{
	private enum Enum0
	{

	}

	internal class Class9
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

		public Class9()
		{
			Class7.amSa9D0zQvoBP();
			base._002Ector();
		}
	}

	private static string[] string_0 = new string[0];

	private static object object_0 = null;

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	private static void smethod_0()
	{
		if (bool_0)
		{
			return;
		}
		BinaryReader binaryReader = new BinaryReader(typeof(Class8).Assembly.GetManifestResourceStream("m4jg1cLY9VfNVa1j12.QiaVUxlQB3N5WaOjqk"));
		binaryReader.BaseStream.Position = 0L;
		byte[] array = new byte[0];
		byte[] array2 = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
		byte[] array3 = new byte[32];
		array3[0] = 87;
		array3[0] = 179;
		array3[0] = 180;
		array3[0] = 140;
		array3[0] = 101;
		array3[0] = 172;
		array3[1] = 87;
		array3[1] = 83;
		array3[1] = 133;
		array3[1] = 128;
		array3[1] = 148;
		array3[2] = 203;
		array3[2] = 160;
		array3[2] = 118;
		array3[3] = 184;
		array3[3] = 202;
		array3[3] = 126;
		array3[3] = 82;
		array3[3] = 52;
		array3[4] = 146;
		array3[4] = 145;
		array3[4] = 235;
		array3[4] = 249;
		array3[5] = 137;
		array3[5] = 92;
		array3[5] = 37;
		array3[5] = 77;
		array3[5] = 39;
		array3[6] = 110;
		array3[6] = 164;
		array3[6] = 64;
		array3[6] = 145;
		array3[6] = 59;
		array3[7] = 170;
		array3[7] = 104;
		array3[7] = 146;
		array3[7] = 139;
		array3[7] = 204;
		array3[7] = 152;
		array3[8] = 173;
		array3[8] = 160;
		array3[8] = 82;
		array3[8] = 115;
		array3[8] = 141;
		array3[8] = 40;
		array3[9] = 155;
		array3[9] = 108;
		array3[9] = 169;
		array3[9] = 154;
		array3[10] = 130;
		array3[10] = 176;
		array3[10] = 175;
		array3[11] = 52;
		array3[11] = 46;
		array3[11] = 96;
		array3[11] = 154;
		array3[11] = 114;
		array3[12] = 109;
		array3[12] = 119;
		array3[12] = 155;
		array3[12] = 92;
		array3[12] = 96;
		array3[12] = 87;
		array3[13] = 99;
		array3[13] = 145;
		array3[13] = 128;
		array3[13] = 212;
		array3[13] = 35;
		array3[14] = 48;
		array3[14] = 119;
		array3[14] = 210;
		array3[14] = 185;
		array3[14] = 164;
		array3[14] = 202;
		array3[15] = 205;
		array3[15] = 148;
		array3[15] = 115;
		array3[15] = 101;
		array3[15] = 146;
		array3[15] = 151;
		array3[16] = 113;
		array3[16] = 103;
		array3[16] = 134;
		array3[16] = 22;
		array3[17] = 126;
		array3[17] = 150;
		array3[17] = 49;
		array3[18] = 143;
		array3[18] = 94;
		array3[18] = 92;
		array3[18] = 66;
		array3[18] = 130;
		array3[18] = 250;
		array3[19] = 159;
		array3[19] = 154;
		array3[19] = 176;
		array3[19] = 189;
		array3[19] = 135;
		array3[19] = 48;
		array3[20] = 153;
		array3[20] = 161;
		array3[20] = 231;
		array3[21] = 131;
		array3[21] = 150;
		array3[21] = 107;
		array3[21] = 149;
		array3[21] = 113;
		array3[21] = 58;
		array3[22] = 56;
		array3[22] = 81;
		array3[22] = 210;
		array3[23] = 87;
		array3[23] = 177;
		array3[23] = 63;
		array3[23] = 184;
		array3[23] = 5;
		array3[24] = 195;
		array3[24] = 120;
		array3[24] = 192;
		array3[25] = 101;
		array3[25] = 101;
		array3[25] = 101;
		array3[25] = 146;
		array3[25] = 189;
		array3[26] = 86;
		array3[26] = 73;
		array3[26] = 124;
		array3[26] = 88;
		array3[26] = 123;
		array3[26] = 144;
		array3[27] = 159;
		array3[27] = 83;
		array3[27] = 111;
		array3[27] = 253;
		array3[28] = 125;
		array3[28] = 89;
		array3[28] = 135;
		array3[28] = 128;
		array3[28] = 155;
		array3[28] = 253;
		array3[29] = 122;
		array3[29] = 141;
		array3[29] = 80;
		array3[30] = 157;
		array3[30] = 153;
		array3[30] = 105;
		array3[30] = 204;
		array3[30] = 233;
		array3[31] = 104;
		array3[31] = 146;
		array3[31] = 152;
		byte[] array4 = array3;
		byte[] array5 = new byte[16];
		array5[0] = 93;
		array5[0] = 166;
		array5[0] = 102;
		array5[0] = 33;
		array5[1] = 121;
		array5[1] = 90;
		array5[1] = 106;
		array5[1] = 127;
		array5[1] = 96;
		array5[1] = 46;
		array5[2] = 104;
		array5[2] = 101;
		array5[2] = 88;
		array5[3] = 132;
		array5[3] = 110;
		array5[3] = 140;
		array5[3] = 152;
		array5[3] = 168;
		array5[4] = 94;
		array5[4] = 69;
		array5[4] = 72;
		array5[5] = 104;
		array5[5] = 92;
		array5[5] = 143;
		array5[5] = 121;
		array5[5] = 51;
		array5[6] = 162;
		array5[6] = 67;
		array5[6] = 71;
		array5[6] = 97;
		array5[6] = 183;
		array5[6] = 136;
		array5[7] = 136;
		array5[7] = 165;
		array5[7] = 170;
		array5[7] = 72;
		array5[7] = 145;
		array5[7] = 226;
		array5[8] = 163;
		array5[8] = 145;
		array5[8] = 84;
		array5[8] = 232;
		array5[9] = 164;
		array5[9] = 178;
		array5[9] = 114;
		array5[9] = 190;
		array5[9] = 130;
		array5[10] = 193;
		array5[10] = 113;
		array5[10] = 128;
		array5[10] = 136;
		array5[10] = 194;
		array5[11] = 138;
		array5[11] = 148;
		array5[11] = 180;
		array5[12] = 46;
		array5[12] = 147;
		array5[12] = 168;
		array5[12] = 9;
		array5[13] = 170;
		array5[13] = 116;
		array5[13] = 146;
		array5[13] = 106;
		array5[13] = 133;
		array5[13] = 138;
		array5[14] = 88;
		array5[14] = 99;
		array5[14] = 145;
		array5[14] = 117;
		array5[14] = 165;
		array5[14] = 164;
		array5[15] = 41;
		array5[15] = 203;
		array5[15] = 128;
		array5[15] = 108;
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
			num14 ^= num14 << 25;
			num14 += 573076361;
			num14 ^= num14 >> 15;
			num14 += 2756600510u;
			num14 ^= num14 << 2;
			num14 += 3915822535u;
			num14 = 3314286592u + num14;
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
		object_0 = Class9.smethod_18(Class9.smethod_17(array));
		string_0 = ((Assembly)object_0).GetManifestResourceNames();
		bool_0 = true;
	}

	internal static string[] smethod_1(Assembly assembly_0)
	{
		if (assembly_0 == typeof(Class8).Assembly)
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

	public Class8()
	{
		AppDomain.CurrentDomain.ResourceResolve += smethod_2;
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!bool_1)
		{
			bool_1 = true;
			new Class8();
		}
	}
}
