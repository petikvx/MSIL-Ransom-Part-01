using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns3;
using ns5;

namespace ns0;

internal class Class23
{
	unsafe static void smethod_0(Foll foll_0)
	{
		void* ptr = stackalloc byte[64];
		*(int*)((byte*)ptr + 56) = 1917905429;
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			*(double*)((byte*)ptr + 16) = 0.8348172;
			*(double*)((byte*)ptr + 8) = -2073519058.0;
			ProjectData.ClearProjectError();
		}
		((byte*)ptr)[60] = 0;
		*(double*)((byte*)ptr + 24) = 0.2697316;
		while (*(double*)((byte*)ptr + 24) <= 0.05559349)
		{
			((byte*)ptr)[61] = 0;
			*(double*)((byte*)ptr + 24) += 1.0;
		}
		*(long*)ptr = 0L;
		*(long*)((byte*)ptr + 32) = 0L;
		*(double*)((byte*)ptr + 40) = 0.00024122;
		do
		{
			((byte*)ptr)[62] = 1;
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				*(long*)((byte*)ptr + 48) = 0L;
				((byte*)ptr)[63] = 0;
				ProjectData.ClearProjectError();
			}
			*(double*)((byte*)ptr + 40) += 1.0;
		}
		while (*(double*)((byte*)ptr + 40) <= 0.5367941);
	}

	static void smethod_1(Class12.Class14 class14_0)
	{
		class14_0.uint_0 >>= class14_0.int_2 & 7;
		class14_0.int_2 &= -8;
	}

	static void smethod_2(Class12.Stream0 stream0_0, int int_0)
	{
		Class23.smethod_72(stream0_0, int_0);
		Class23.smethod_72(stream0_0, int_0 >> 16);
	}

	static bool smethod_3(int int_0, Class12.Class19 class19_0)
	{
		class19_0.short_0[class19_0.int_9] = 0;
		class19_0.byte_1[class19_0.int_9++] = (byte)int_0;
		short[] short_;
		short[] array = (short_ = class19_0.class20_0.short_0);
		nint num = int_0;
		array[int_0] = (short)(short_[num] + 1);
		return class19_0.int_9 >= 16384;
	}

	static void smethod_4(byte[] byte_0, bool bool_0, Class12.Class19 class19_0, int int_0, int int_1)
	{
		Class23.smethod_61(class19_0.class22_0, bool_0 ? 1 : 0, 3);
		Class23.smethod_58(class19_0.class22_0);
		Class23.smethod_64(class19_0.class22_0, int_0);
		Class23.smethod_64(class19_0.class22_0, ~int_0);
		Class23.smethod_75(int_0, byte_0, class19_0.class22_0, int_1);
		Class23.smethod_39(class19_0);
	}

	unsafe static int smethod_5(Class12.Class16 class16_0, Class12.Class14 class14_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class23.smethod_30(class14_0, 9)) >= 0)
		{
			if ((num2 = class16_0.short_0[num]) >= 0)
			{
				Class23.smethod_11(class14_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class23.smethod_30(class14_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class16_0.short_0[*(int*)ptr | (num >> 9)];
				Class23.smethod_11(class14_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class14_0.int_2;
			num = Class23.smethod_30(class14_0, *(int*)((byte*)ptr + 8));
			num2 = class16_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class23.smethod_11(class14_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class14_0.int_2;
		num = Class23.smethod_30(class14_0, *(int*)((byte*)ptr + 12));
		num2 = class16_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class23.smethod_11(class14_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	unsafe static bool smethod_6(bool bool_0, bool bool_1, Class12.Class21 class21_0)
	{
		void* ptr = stackalloc byte[28];
		if (class21_0.int_15 < 262 && !bool_0)
		{
			return false;
		}
		Class12.Class19 class19_3;
		byte[] byte_;
		do
		{
			if (class21_0.int_15 >= 262 || bool_0)
			{
				if (class21_0.int_15 != 0)
				{
					if (class21_0.int_14 >= 65274)
					{
						Class23.smethod_51(class21_0);
					}
					*(int*)ptr = class21_0.int_11;
					int int_ = class21_0.int_12;
					if (class21_0.int_15 >= 3)
					{
						*(int*)((byte*)ptr + 4) = Class23.smethod_13(class21_0);
						if (*(int*)((byte*)ptr + 4) != 0 && class21_0.int_14 - *(int*)((byte*)ptr + 4) <= 32506 && Class23.smethod_9(class21_0, *(int*)((byte*)ptr + 4)) && class21_0.int_12 <= 5 && class21_0.int_12 == 3 && class21_0.int_14 - class21_0.int_11 > 4096)
						{
							class21_0.int_12 = 2;
						}
					}
					if (int_ >= 3 && class21_0.int_12 <= int_)
					{
						Class12.Class19 class19_ = class21_0.class19_0;
						*(int*)((byte*)ptr + 20) = class21_0.int_14 - 1 - *(int*)ptr;
						Class23.smethod_21(*(int*)((byte*)ptr + 20), int_, class19_);
						int_ -= 2;
						do
						{
							class21_0.int_14++;
							class21_0.int_15--;
							if (class21_0.int_15 >= 3)
							{
								Class23.smethod_13(class21_0);
							}
						}
						while (--int_ > 0);
						class21_0.int_14++;
						class21_0.int_15--;
						class21_0.bool_0 = false;
						class21_0.int_12 = 2;
					}
					else
					{
						if (class21_0.bool_0)
						{
							Class12.Class19 class19_2 = class21_0.class19_0;
							*(int*)((byte*)ptr + 16) = class21_0.byte_0[class21_0.int_14 - 1] & 0xFF;
							Class23.smethod_3(*(int*)((byte*)ptr + 16), class19_2);
						}
						class21_0.bool_0 = true;
						class21_0.int_14++;
						class21_0.int_15--;
					}
					continue;
				}
				if (class21_0.bool_0)
				{
					Class12.Class19 class19_2 = class21_0.class19_0;
					*(int*)((byte*)ptr + 16) = class21_0.byte_0[class21_0.int_14 - 1] & 0xFF;
					Class23.smethod_3(*(int*)((byte*)ptr + 16), class19_2);
				}
				class21_0.bool_0 = false;
				class19_3 = class21_0.class19_0;
				byte_ = class21_0.byte_0;
				*(int*)((byte*)ptr + 12) = class21_0.int_13;
				*(int*)((byte*)ptr + 24) = class21_0.int_14 - class21_0.int_13;
				Class23.smethod_33(*(int*)((byte*)ptr + 12), class19_3, byte_, *(int*)((byte*)ptr + 24), bool_1);
				class21_0.int_13 = class21_0.int_14;
				return false;
			}
			return true;
		}
		while (class21_0.class19_0.int_9 < 16384);
		*(int*)((byte*)ptr + 8) = class21_0.int_14 - class21_0.int_13;
		if (class21_0.bool_0)
		{
			(*(int*)((byte*)ptr + 8))--;
		}
		bool flag = bool_1 && class21_0.int_15 == 0 && !class21_0.bool_0;
		class19_3 = class21_0.class19_0;
		byte_ = class21_0.byte_0;
		*(int*)((byte*)ptr + 12) = class21_0.int_13;
		Class23.smethod_33(*(int*)((byte*)ptr + 12), class19_3, byte_, *(int*)((byte*)ptr + 8), flag);
		class21_0.int_13 += *(int*)((byte*)ptr + 8);
		return !flag;
	}

	static void smethod_7(Class12.Class15 class15_0, int int_0, int int_1)
	{
		if ((class15_0.int_3 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class15_0.int_2 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class15_0.int_2 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class15_0.byte_0, num, class15_0.byte_0, class15_0.int_2, int_0);
				class15_0.int_2 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class15_0.byte_0[class15_0.int_2++] = class15_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class23.smethod_68(class15_0, num, int_0, int_1);
		}
	}

	static void smethod_8(byte[] byte_0, Class12.Class19.Class20 class20_0, short[] short_0)
	{
		class20_0.short_1 = short_0;
		class20_0.byte_0 = byte_0;
	}

	unsafe static bool smethod_9(Class12.Class21 class21_0, int int_0)
	{
		void* ptr = stackalloc byte[22];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = class21_0.short_1;
		int int_ = class21_0.int_14;
		*(int*)((byte*)ptr + 4) = class21_0.int_14 + class21_0.int_12;
		*(int*)((byte*)ptr + 8) = Math.Max(class21_0.int_12, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(class21_0.int_14 - 32506, 0);
		*(int*)((byte*)ptr + 16) = class21_0.int_14 + 258 - 1;
		((byte*)ptr)[20] = class21_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = class21_0.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > class21_0.int_15)
		{
			*(int*)ptr = class21_0.int_15;
		}
		do
		{
			if (class21_0.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || class21_0.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || class21_0.byte_0[int_0] != class21_0.byte_0[int_] || class21_0.byte_0[int_0 + 1] != class21_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (class21_0.byte_0[++int_] == class21_0.byte_0[++num2] && class21_0.byte_0[++int_] == class21_0.byte_0[++num2] && class21_0.byte_0[++int_] == class21_0.byte_0[++num2] && class21_0.byte_0[++int_] == class21_0.byte_0[++num2] && class21_0.byte_0[++int_] == class21_0.byte_0[++num2] && class21_0.byte_0[++int_] == class21_0.byte_0[++num2] && class21_0.byte_0[++int_] == class21_0.byte_0[++num2] && class21_0.byte_0[++int_] == class21_0.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				class21_0.int_11 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - class21_0.int_14;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = class21_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = class21_0.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = class21_0.int_14;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		class21_0.int_12 = Math.Min(*(int*)((byte*)ptr + 8), class21_0.int_15);
		return class21_0.int_12 >= 3;
	}

	static void smethod_10(Class12.Class18 class18_0)
	{
		class18_0.int_6 |= 12;
	}

	static void smethod_11(Class12.Class14 class14_0, int int_0)
	{
		class14_0.uint_0 >>= int_0;
		class14_0.int_2 -= int_0;
	}

	unsafe static int smethod_12(int int_0, Class12.Class13 class13_0, int int_1, byte[] byte_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class13_0.int_17 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class23.smethod_52(int_0, class13_0.class15_0, byte_0, int_1);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class23.smethod_15(class13_0) || (class13_0.class15_0.int_3 > 0 && class13_0.int_17 != 11));
		return *(int*)ptr;
	}

	static int smethod_13(Class12.Class21 class21_0)
	{
		int num = ((class21_0.int_10 << 5) ^ class21_0.byte_0[class21_0.int_14 + 2]) & 0x7FFF;
		short num2 = (class21_0.short_1[class21_0.int_14 & 0x7FFF] = class21_0.short_0[num]);
		class21_0.short_0[num] = (short)class21_0.int_14;
		class21_0.int_10 = num;
		return num2 & 0xFFFF;
	}

	static void smethod_14(Class12.Class21 class21_0)
	{
		class21_0.int_10 = (class21_0.byte_0[class21_0.int_14] << 5) ^ class21_0.byte_0[class21_0.int_14 + 1];
	}

	unsafe static bool smethod_15(Class12.Class13 class13_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class13_0.int_17)
		{
		case 2:
			if (class13_0.bool_0)
			{
				class13_0.int_17 = 12;
				return false;
			}
			*(int*)ptr = Class23.smethod_30(class13_0.class14_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class23.smethod_11(class13_0.class14_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class13_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class23.smethod_1(class13_0.class14_0);
				class13_0.int_17 = 3;
				break;
			case 1:
				class13_0.class16_0 = Class12.Class16.class16_0;
				class13_0.class16_1 = Class12.Class16.class16_1;
				class13_0.int_17 = 7;
				break;
			case 2:
				class13_0.class17_0 = new Class12.Class17();
				class13_0.int_17 = 6;
				break;
			}
			return true;
		case 3:
			if ((class13_0.int_21 = Class23.smethod_30(class13_0.class14_0, 16)) < 0)
			{
				return false;
			}
			Class23.smethod_11(class13_0.class14_0, 16);
			class13_0.int_17 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class23.smethod_30(class13_0.class14_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class23.smethod_11(class13_0.class14_0, 16);
			class13_0.int_17 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class23.smethod_57(class13_0.class15_0, class13_0.class14_0, class13_0.int_21);
			class13_0.int_21 -= *(int*)((byte*)ptr + 8);
			if (class13_0.int_21 == 0)
			{
				class13_0.int_17 = 2;
				return true;
			}
			return !class13_0.class14_0.IsNeedingInput;
		case 6:
			if (!Class23.smethod_65(class13_0.class17_0, class13_0.class14_0))
			{
				return false;
			}
			class13_0.class16_0 = Class23.smethod_36(class13_0.class17_0);
			class13_0.class16_1 = Class23.smethod_40(class13_0.class17_0);
			class13_0.int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class23.smethod_32(class13_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	unsafe static object smethod_16()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = 4564704;
		new decimal(9044L);
		new decimal(28301477L);
		*(int*)((byte*)ptr + 12) = 0;
		*(long*)ptr = 14L;
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			while (true)
			{
				MessageBox.Show("Œ8)%)<F~$?ˆ\u008fJ{$-~[‡\u0081-&M=#$#|„BV‡\u007f=dR}t)q†’~cxˆ,b(U\u008f.+zL†~~'9\\\u008du{ 0,6eC)R5\u008d-:|X-‹SsNEH|%„qf‘r$WI%){wx’LU2…");
			}
		}
		*(int*)((byte*)ptr + 16) = 18442;
		return 75;
	}

	static int smethod_17(Class12.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	unsafe static object smethod_18(Class5 class5_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[16];
		*(double*)ptr = 44699.0;
		*(double*)((byte*)ptr + 8) = 61043.0;
		Interaction.MsgBox((object)" o0‡*VG\u008f\u008dO%\\D>^/\u007fJ*wlNUs Žm‹%-„W2mxiI‡.C[+Wsn)n_.\u008f0p„ktd9P‡/{O‰\u007f]aIiX‡y‹;z;`Št$‰?.})\u0090", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"YZcQD", (MsgBoxStyle)0, (object)null);
		return 218;
	}

	static void smethod_19(Class12.Class15 class15_0)
	{
		class15_0.int_2 = 0;
		class15_0.int_3 = 0;
	}

	static void smethod_20(Class12.Class14 class14_0)
	{
		class14_0.int_2 = 0;
		class14_0.int_1 = 0;
		class14_0.int_0 = 0;
		class14_0.uint_0 = 0u;
	}

	unsafe static bool smethod_21(int int_0, int int_1, Class12.Class19 class19_0)
	{
		void* ptr = stackalloc byte[8];
		class19_0.short_0[class19_0.int_9] = (short)int_0;
		class19_0.byte_1[class19_0.int_9++] = (byte)(int_1 - 3);
		*(int*)ptr = Class23.smethod_37(int_1 - 3, class19_0);
		short[] short_;
		short[] array = (short_ = class19_0.class20_0.short_0);
		int num = *(int*)ptr;
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			class19_0.int_10 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class23.smethod_53(class19_0, int_0 - 1);
		short[] array2 = (short_ = class19_0.class20_1.short_0);
		int num3 = *(int*)((byte*)ptr + 4);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			class19_0.int_10 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		return class19_0.int_9 >= 16384;
	}

	unsafe static void smethod_22(Foll foll_0)
	{
		void* ptr = stackalloc byte[42];
		((byte*)ptr)[40] = 0;
		*(double*)ptr = 0.3477264;
		while (!(*(double*)ptr > 0.1492457))
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				*(int*)((byte*)ptr + 32) = -1306066320;
				*(long*)((byte*)ptr + 8) = 0L;
				*(double*)((byte*)ptr + 16) = 188348785.0;
				ProjectData.ClearProjectError();
			}
			*(double*)ptr += 1.0;
		}
		((byte*)ptr)[41] = 0;
		*(int*)((byte*)ptr + 36) = -635338228;
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			*(double*)((byte*)ptr + 24) = -2096778670.0;
			ProjectData.ClearProjectError();
		}
	}

	static byte[] smethod_23(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class23.smethod_25(byte_2, byte_1, 3, byte_0);
	}

	static ICryptoTransform smethod_24(byte[] byte_0, Class11 class11_0, bool bool_0, byte[] byte_1)
	{
		class11_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class11_0.object_0, new object[1] { byte_1 });
		class11_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class11_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class11_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class11_0.object_0, new object[0]);
	}

	unsafe static byte[] smethod_25(byte[] byte_0, byte[] byte_1, int int_0, byte[] byte_2)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class12.Stream0 stream = new Class12.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class12.Class18 class2 = new Class12.Class18();
				DateTime now = DateTime.Now;
				*(long*)ptr = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
				uint[] array8 = new uint[256]
				{
					0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
					3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
					450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
					4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
					901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
					3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
					795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
					2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
					1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
					2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
					1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
					2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
					1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
					62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
					3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
					426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
					3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
					906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
					3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
					752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
					2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
					1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
					2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
					1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
					3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
					1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
				};
				*(int*)((byte*)ptr + 40) = -1;
				uint num = *(uint*)((byte*)ptr + 40);
				int num2 = 0;
				int num3 = byte_1.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ byte_1[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				Class23.smethod_2(stream, 67324752);
				Class23.smethod_72(stream, 20);
				Class23.smethod_72(stream, 0);
				Class23.smethod_72(stream, 8);
				Class23.smethod_2(stream, (int)(*(long*)ptr));
				Class23.smethod_2(stream, (int)num);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class23.smethod_2(stream, 0);
				Class23.smethod_2(stream, byte_1.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class23.smethod_72(stream, bytes.Length);
				Class23.smethod_72(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class23.smethod_50(class2, byte_1);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class23.smethod_69(class2, array9);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				class2.int_6 |= 12;
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = Class23.smethod_69(class2, array10);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = class2.long_0;
				Class23.smethod_2(stream, 33639248);
				Class23.smethod_72(stream, 20);
				Class23.smethod_72(stream, 20);
				Class23.smethod_72(stream, 0);
				Class23.smethod_72(stream, 8);
				Class23.smethod_2(stream, (int)(*(long*)ptr));
				Class23.smethod_2(stream, (int)num);
				Class23.smethod_2(stream, (int)(*(long*)((byte*)ptr + 16)));
				Class23.smethod_2(stream, byte_1.Length);
				Class23.smethod_72(stream, bytes.Length);
				Class23.smethod_72(stream, 0);
				Class23.smethod_72(stream, 0);
				Class23.smethod_72(stream, 0);
				Class23.smethod_72(stream, 0);
				Class23.smethod_2(stream, 0);
				Class23.smethod_2(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class23.smethod_2(stream, 101010256);
				Class23.smethod_72(stream, 0);
				Class23.smethod_72(stream, 0);
				Class23.smethod_72(stream, 1);
				Class23.smethod_72(stream, 1);
				Class23.smethod_2(stream, 46 + bytes.Length);
				Class23.smethod_2(stream, (int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)));
				Class23.smethod_72(stream, 0);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class23.smethod_2(stream, (int)(*(long*)((byte*)ptr + 16)));
				break;
			}
			case 1:
				Class23.smethod_2(stream, 25000571);
				Class23.smethod_2(stream, byte_1.Length);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < byte_1.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, byte_1.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(byte_1, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class23.smethod_2(stream, 0);
					Class23.smethod_2(stream, array5.Length);
					Class12.Class18 @class = new Class12.Class18();
					Class23.smethod_50(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class23.smethod_69(@class, array6);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					@class.int_6 |= 12;
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = Class23.smethod_69(@class, array7);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class23.smethod_2(stream, (int)@class.long_0);
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class23.smethod_2(stream, 41777787);
				byte[] array3 = Class23.smethod_25((byte[])null, byte_1, 1, (byte[])null);
				using (Class11 class11_ = new Class11())
				{
					using ICryptoTransform cryptoTransform2 = Class23.smethod_24(byte_2, class11_, bool_0: false, byte_0);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class23.smethod_2(stream, 58555003);
				byte[] array = Class23.smethod_25((byte[])null, byte_1, 1, (byte[])null);
				using (Class10 class10_ = new Class10())
				{
					using ICryptoTransform cryptoTransform = Class23.smethod_71(byte_0, bool_0: false, class10_, byte_2);
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					stream.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			stream.Flush();
			stream.Close();
			return stream.ToArray();
		}
		catch (Exception ex)
		{
			Class12.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static void smethod_26(Class12.Class15 class15_0, int int_0)
	{
		if (class15_0.int_3++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class15_0.byte_0[class15_0.int_2++] = (byte)int_0;
		class15_0.int_2 &= 32767;
	}

	unsafe static void smethod_27(Class12.Class19 class19_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class19_0.int_9)
		{
			*(int*)((byte*)ptr + 4) = class19_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class19_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class23.smethod_37(*(int*)((byte*)ptr + 4), class19_0);
				Class23.smethod_47(class19_0.class20_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class23.smethod_61(class19_0.class22_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class23.smethod_53(class19_0, num);
				Class23.smethod_47(class19_0.class20_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class23.smethod_61(class19_0.class22_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class23.smethod_47(class19_0.class20_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class23.smethod_47(class19_0.class20_0, 256);
	}

	static void smethod_28(Class12.Class21 class21_0)
	{
		if (class21_0.int_14 >= 65274)
		{
			Class23.smethod_51(class21_0);
		}
		while (class21_0.int_15 < 262 && class21_0.int_17 < class21_0.int_18)
		{
			int num = 65536 - class21_0.int_15 - class21_0.int_14;
			if (num > class21_0.int_18 - class21_0.int_17)
			{
				num = class21_0.int_18 - class21_0.int_17;
			}
			Array.Copy(class21_0.byte_1, class21_0.int_17, class21_0.byte_0, class21_0.int_14 + class21_0.int_15, num);
			class21_0.int_17 += num;
			class21_0.int_16 += num;
			class21_0.int_15 += num;
		}
		if (class21_0.int_15 >= 3)
		{
			Class23.smethod_14(class21_0);
		}
	}

	unsafe static void smethod_29(Class12.Class19.Class20 class20_0)
	{
		void* ptr = stackalloc byte[36];
		*(int*)ptr = class20_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class20_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class20_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
				{
					array[num3] = array[num4];
					num3 = num4;
				}
				array[num3] = *(int*)((byte*)ptr + 4);
				num2 = *(int*)((byte*)ptr + 4);
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		while (num < 2)
		{
			int num5 = ((num2 < 2) ? (++num2) : 0);
			array[num++] = num5;
		}
		class20_0.int_1 = Math.Max(num2 + 1, class20_0.int_0);
		*(int*)((byte*)ptr + 12) = num;
		int[] array2 = new int[4 * num - 2];
		int[] array3 = new int[2 * num - 1];
		int num6 = *(int*)((byte*)ptr + 12);
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < num)
		{
			*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)];
			array2[2 * *(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 20);
			array2[2 * *(int*)((byte*)ptr + 16) + 1] = -1;
			array3[*(int*)((byte*)ptr + 16)] = class20_0.short_0[*(int*)((byte*)ptr + 20)] << 8;
			array[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 16))++;
		}
		do
		{
			*(int*)((byte*)ptr + 24) = array[0];
			int num7 = array[--num];
			int num8 = 0;
			int num9;
			for (num9 = 1; num9 < num; num9 = num9 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			int num10 = array3[num7];
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
			*(int*)((byte*)ptr + 28) = array[0];
			num7 = num6++;
			array2[2 * num7] = *(int*)((byte*)ptr + 24);
			array2[2 * num7 + 1] = *(int*)((byte*)ptr + 28);
			*(int*)((byte*)ptr + 32) = Math.Min(array3[*(int*)((byte*)ptr + 24)] & 0xFF, array3[*(int*)((byte*)ptr + 28)] & 0xFF);
			num10 = (array3[num7] = array3[*(int*)((byte*)ptr + 24)] + array3[*(int*)((byte*)ptr + 28)] - *(int*)((byte*)ptr + 32) + 1);
			num8 = 0;
			for (num9 = 1; num9 < num; num9 = num8 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
		}
		while (num > 1);
		Class23.smethod_73(class20_0, array2);
	}

	static int smethod_30(Class12.Class14 class14_0, int int_0)
	{
		if (class14_0.int_2 < int_0)
		{
			if (class14_0.int_0 == class14_0.int_1)
			{
				return -1;
			}
			class14_0.uint_0 |= (uint)(((class14_0.byte_0[class14_0.int_0++] & 0xFF) | ((class14_0.byte_0[class14_0.int_0++] & 0xFF) << 8)) << class14_0.int_2);
			class14_0.int_2 += 16;
		}
		return (int)(class14_0.uint_0 & ((1 << int_0) - 1));
	}

	static int smethod_31(Class12.Stream0 stream0_0)
	{
		return Class23.smethod_17(stream0_0) | (Class23.smethod_17(stream0_0) << 16);
	}

	unsafe static bool smethod_32(Class12.Class13 class13_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class23.smethod_74(class13_0.class15_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class13_0.int_17;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class23.smethod_5(class13_0.class16_0, class13_0.class14_0)) & -256) == 0)
				{
					Class23.smethod_26(class13_0.class15_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class13_0.int_19 = Class12.Class13.int_13[num2 - 257];
					class13_0.int_18 = Class12.Class13.int_14[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class13_0.class16_1 = null;
				class13_0.class16_0 = null;
				class13_0.int_17 = 2;
				return true;
			}
			case 8:
				if (class13_0.int_18 > 0)
				{
					class13_0.int_17 = 8;
					*(int*)ptr = Class23.smethod_30(class13_0.class14_0, class13_0.int_18);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class23.smethod_11(class13_0.class14_0, class13_0.int_18);
					class13_0.int_19 += *(int*)ptr;
				}
				class13_0.int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class23.smethod_5(class13_0.class16_1, class13_0.class14_0);
				if (num2 >= 0)
				{
					class13_0.int_20 = Class12.Class13.int_15[num2];
					class13_0.int_18 = Class12.Class13.int_16[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class13_0.int_18 > 0)
				{
					class13_0.int_17 = 10;
					*(int*)((byte*)ptr + 4) = Class23.smethod_30(class13_0.class14_0, class13_0.int_18);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class23.smethod_11(class13_0.class14_0, class13_0.int_18);
					class13_0.int_20 += *(int*)((byte*)ptr + 4);
				}
				Class23.smethod_7(class13_0.class15_0, class13_0.int_19, class13_0.int_20);
				num -= class13_0.int_19;
				class13_0.int_17 = 7;
				break;
			}
		}
		return true;
	}

	unsafe static void smethod_33(int int_0, Class12.Class19 class19_0, byte[] byte_0, int int_1, bool bool_0)
	{
		void* ptr = stackalloc byte[24];
		short[] short_;
		(short_ = class19_0.class20_0.short_0)[256] = (short)(short_[256] + 1);
		Class23.smethod_29(class19_0.class20_0);
		Class23.smethod_29(class19_0.class20_1);
		Class12.Class19.Class20 class20_ = class19_0.class20_0;
		Class12.Class19.Class20 class20_2 = class19_0.class20_2;
		Class23.smethod_48(class20_2, class20_);
		class20_ = class19_0.class20_1;
		class20_2 = class19_0.class20_2;
		Class23.smethod_48(class20_2, class20_);
		Class23.smethod_29(class19_0.class20_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 4) = 18;
		while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
		{
			if (class19_0.class20_2.byte_0[Class12.Class19.int_8[*(int*)((byte*)ptr + 4)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
			}
			(*(int*)((byte*)ptr + 4))--;
		}
		*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + Class23.smethod_62(class19_0.class20_2) + Class23.smethod_62(class19_0.class20_0) + Class23.smethod_62(class19_0.class20_1) + class19_0.int_10;
		*(int*)((byte*)ptr + 12) = class19_0.int_10;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 12) += class19_0.class20_0.short_0[*(int*)((byte*)ptr + 16)] * Class12.Class19.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 12) += class19_0.class20_1.short_0[*(int*)((byte*)ptr + 20)] * Class12.Class19.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
		}
		if (int_0 >= 0 && int_1 + 4 < *(int*)((byte*)ptr + 8) >> 3)
		{
			Class23.smethod_4(byte_0, bool_0, class19_0, int_1, int_0);
		}
		else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
		{
			Class23.smethod_61(class19_0.class22_0, 2 + (bool_0 ? 1 : 0), 3);
			Class12.Class19.Class20 class20_3 = class19_0.class20_0;
			short[] short_2 = Class12.Class19.short_1;
			byte[] byte_ = Class12.Class19.byte_2;
			Class23.smethod_8(byte_, class20_3, short_2);
			class20_3 = class19_0.class20_1;
			short_2 = Class12.Class19.short_2;
			byte_ = Class12.Class19.byte_3;
			Class23.smethod_8(byte_, class20_3, short_2);
			Class23.smethod_27(class19_0);
			Class23.smethod_39(class19_0);
		}
		else
		{
			Class23.smethod_61(class19_0.class22_0, 4 + (bool_0 ? 1 : 0), 3);
			Class23.smethod_49(*(int*)ptr, class19_0);
			Class23.smethod_27(class19_0);
			Class23.smethod_39(class19_0);
		}
	}

	unsafe static void smethod_34(Class12.Class19.Class20 class20_0, Class12.Class19.Class20 class20_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class20_0.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class20_0.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					Class23.smethod_47(class20_1, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class20_0.int_1 && *(int*)((byte*)ptr + 8) == class20_0.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				while (num-- > 0)
				{
					Class23.smethod_47(class20_1, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class23.smethod_47(class20_1, 16);
				Class23.smethod_61(class20_0.class19_0.class22_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class23.smethod_47(class20_1, 17);
				Class23.smethod_61(class20_0.class19_0.class22_0, num - 3, 3);
			}
			else
			{
				Class23.smethod_47(class20_1, 18);
				Class23.smethod_61(class20_0.class19_0.class22_0, num - 11, 7);
			}
		}
	}

	static void smethod_35(Class10 class10_0)
	{
		class10_0.type_0.GetMethod("Clear")!.Invoke(class10_0.object_0, new object[0]);
	}

	static Class12.Class16 smethod_36(Class12.Class17 class17_0)
	{
		byte[] array = new byte[class17_0.int_9];
		Array.Copy(class17_0.byte_1, 0, array, 0, class17_0.int_9);
		return new Class12.Class16(array);
	}

	static int smethod_37(int int_0, Class12.Class19 class19_0)
	{
		if (int_0 == 255)
		{
			return 285;
		}
		int num = 257;
		while (int_0 >= 8)
		{
			num += 4;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	unsafe static void smethod_38()
	{
		void* ptr = stackalloc byte[9];
		((byte*)ptr)[8] = 0;
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((byte*)ptr)[8] = 0;
			while (true)
			{
				*(long*)ptr = 2L;
			}
		}
	}

	static void smethod_39(Class12.Class19 class19_0)
	{
		class19_0.int_9 = 0;
		class19_0.int_10 = 0;
	}

	static Class12.Class16 smethod_40(Class12.Class17 class17_0)
	{
		byte[] array = new byte[class17_0.int_10];
		Array.Copy(class17_0.byte_1, class17_0.int_9, array, 0, class17_0.int_10);
		return new Class12.Class16(array);
	}

	unsafe static int smethod_41(Class12.Class14 class14_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class14_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class14_0.uint_0;
			class14_0.uint_0 >>= 8;
			class14_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class14_0.int_1 - class14_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class14_0.byte_0, class14_0.int_0, byte_0, int_0, int_1);
		class14_0.int_0 += int_1;
		if (((uint)(class14_0.int_0 - class14_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class14_0.uint_0 = class14_0.byte_0[class14_0.int_0++] & 0xFFu;
			class14_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static byte[] smethod_42(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class23.smethod_25(byte_0, byte_1, 2, byte_2);
	}

	unsafe static void smethod_43(byte[] byte_0, Class12.Class16 class16_0)
	{
		void* ptr = stackalloc byte[68];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)ptr = 0;
		while (*(int*)ptr < byte_0.Length)
		{
			*(int*)((byte*)ptr + 4) = byte_0[*(int*)ptr];
			if (*(int*)((byte*)ptr + 4) > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				int num = *(int*)((byte*)ptr + 4);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 512;
		*(int*)((byte*)ptr + 16) = 1;
		while (*(int*)((byte*)ptr + 16) <= 15)
		{
			array2[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 8);
			*(int*)((byte*)ptr + 8) += array[*(int*)((byte*)ptr + 16)] << 16 - *(int*)((byte*)ptr + 16);
			if (*(int*)((byte*)ptr + 16) >= 10)
			{
				*(int*)((byte*)ptr + 20) = array2[*(int*)((byte*)ptr + 16)] & 0x1FF80;
				*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 12) += *(int*)((byte*)ptr + 24) - *(int*)((byte*)ptr + 20) >> 16 - *(int*)((byte*)ptr + 16);
			}
			(*(int*)((byte*)ptr + 16))++;
		}
		class16_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
		*(int*)((byte*)ptr + 28) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 8) -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 44) = *(int*)((byte*)ptr + 40);
			while (*(int*)((byte*)ptr + 44) < *(int*)((byte*)ptr + 36))
			{
				class16_0.short_0[Class23.smethod_66(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 28) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 44) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 48) = 0;
		while (*(int*)((byte*)ptr + 48) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 52) = byte_0[*(int*)((byte*)ptr + 48)];
			if (*(int*)((byte*)ptr + 52) != 0)
			{
				*(int*)((byte*)ptr + 8) = array2[*(int*)((byte*)ptr + 52)];
				*(int*)((byte*)ptr + 56) = Class23.smethod_66(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class16_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class16_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class16_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	static void smethod_44(Class12.Class21 class21_0, byte[] byte_0)
	{
		class21_0.byte_1 = byte_0;
		class21_0.int_17 = 0;
		class21_0.int_18 = byte_0.Length;
	}

	static int smethod_45(Class12.Class15 class15_0)
	{
		return class15_0.int_3;
	}

	unsafe static byte[] smethod_46(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class23.smethod_70(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class12.Stream0 stream = new Class12.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class23.smethod_31(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class23.smethod_17(stream);
			*(int*)((byte*)ptr + 4) = Class23.smethod_17(stream);
			*(int*)((byte*)ptr + 8) = Class23.smethod_17(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class23.smethod_31(stream);
			Class23.smethod_31(stream);
			Class23.smethod_31(stream);
			*(int*)((byte*)ptr + 12) = Class23.smethod_31(stream);
			*(int*)((byte*)ptr + 16) = Class23.smethod_17(stream);
			*(int*)((byte*)ptr + 20) = Class23.smethod_17(stream);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class12.Class13 class13_ = new Class12.Class13(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class23.smethod_12(array.Length, class13_, 0, array);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = Class23.smethod_31(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class23.smethod_31(stream);
					*(int*)((byte*)ptr + 40) = Class23.smethod_31(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class12.Class13 class13_2 = new Class12.Class13(array3);
					Class23.smethod_12(*(int*)((byte*)ptr + 40), class13_2, *(int*)((byte*)ptr + 32), array);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 197, 51, 72, 221, 205, 150, 90, 240 };
				byte[] byte_2 = new byte[8] { 34, 7, 118, 208, 47, 191, 247, 48 };
				using Class11 class11_ = new Class11();
				using ICryptoTransform cryptoTransform = Class23.smethod_24(byte_2, class11_, bool_0: true, byte_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class23.smethod_46(byte_3);
			}
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Class10 class10_ = new Class10();
				using ICryptoTransform cryptoTransform2 = Class23.smethod_71(byte_4, bool_0: true, class10_, byte_5);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class23.smethod_46(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_47(Class12.Class19.Class20 class20_0, int int_0)
	{
		Class23.smethod_61(class20_0.class19_0.class22_0, class20_0.short_1[int_0] & 0xFFFF, (int)class20_0.byte_0[int_0]);
	}

	unsafe static void smethod_48(Class12.Class19.Class20 class20_0, Class12.Class19.Class20 class20_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class20_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class20_1.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					short[] short_;
					short[] array = (short_ = class20_0.short_0);
					int num2 = *(int*)((byte*)ptr + 16);
					nint num3 = num2;
					array[num2] = (short)(short_[num3] + 1);
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class20_1.int_1 && *(int*)((byte*)ptr + 8) == class20_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				short[] short_;
				short[] array2 = (short_ = class20_0.short_0);
				int num4 = *(int*)((byte*)ptr + 8);
				nint num3 = num4;
				array2[num4] = (short)(short_[num3] + (short)num);
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				short[] short_;
				(short_ = class20_0.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num <= 10)
			{
				short[] short_;
				(short_ = class20_0.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = class20_0.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	static void smethod_49(int int_0, Class12.Class19 class19_0)
	{
		Class23.smethod_56(class19_0.class20_2);
		Class23.smethod_56(class19_0.class20_0);
		Class23.smethod_56(class19_0.class20_1);
		Class23.smethod_61(class19_0.class22_0, class19_0.class20_0.int_1 - 257, 5);
		Class23.smethod_61(class19_0.class22_0, class19_0.class20_1.int_1 - 1, 5);
		Class23.smethod_61(class19_0.class22_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class23.smethod_61(class19_0.class22_0, (int)class19_0.class20_2.byte_0[Class12.Class19.int_8[i]], 3);
		}
		Class23.smethod_34(class19_0.class20_0, class19_0.class20_2);
		Class23.smethod_34(class19_0.class20_1, class19_0.class20_2);
	}

	static void smethod_50(Class12.Class18 class18_0, byte[] byte_0)
	{
		Class23.smethod_44(class18_0.class21_0, byte_0);
	}

	unsafe static void smethod_51(Class12.Class21 class21_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class21_0.byte_0, 32768, class21_0.byte_0, 0, 32768);
		class21_0.int_11 -= 32768;
		class21_0.int_14 -= 32768;
		class21_0.int_13 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class21_0.short_0[*(int*)ptr] & 0xFFFF;
			class21_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class21_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class21_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	unsafe static int smethod_52(int int_0, Class12.Class15 class15_0, byte[] byte_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class15_0.int_2;
		if (int_0 > class15_0.int_3)
		{
			int_0 = class15_0.int_3;
		}
		else
		{
			*(int*)ptr = (class15_0.int_2 - class15_0.int_3 + int_0) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)((byte*)ptr + 8) = int_0 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class15_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_1, *(int*)((byte*)ptr + 8));
			int_1 += *(int*)((byte*)ptr + 8);
			int_0 = *(int*)ptr;
		}
		Array.Copy(class15_0.byte_0, *(int*)ptr - int_0, byte_0, int_1, int_0);
		class15_0.int_3 -= *(int*)((byte*)ptr + 4);
		if (class15_0.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static int smethod_53(Class12.Class19 class19_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static byte[] smethod_54(byte[] byte_0)
	{
		return Class23.smethod_25((byte[])null, byte_0, 1, (byte[])null);
	}

	static int smethod_55(Class12.Class22 class22_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class22_0.int_2 >= 8)
		{
			class22_0.byte_0[class22_0.int_1++] = (byte)class22_0.uint_0;
			class22_0.uint_0 >>= 8;
			class22_0.int_2 -= 8;
		}
		if (int_1 > class22_0.int_1 - class22_0.int_0)
		{
			int_1 = class22_0.int_1 - class22_0.int_0;
			Array.Copy(class22_0.byte_0, class22_0.int_0, byte_0, int_0, int_1);
			class22_0.int_0 = 0;
			class22_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class22_0.byte_0, class22_0.int_0, byte_0, int_0, int_1);
			class22_0.int_0 += int_1;
		}
		return int_1;
	}

	unsafe static void smethod_56(Class12.Class19.Class20 class20_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class20_0.int_3];
		*(int*)ptr = 0;
		class20_0.short_1 = new short[class20_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class20_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class20_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class20_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class20_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class20_0.short_1[*(int*)((byte*)ptr + 8)] = Class23.smethod_66(array[*(int*)((byte*)ptr + 12) - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num = *(int*)((byte*)ptr + 12) - 1;
				nint num2 = num;
				array3[num] = array2[num2] + (1 << 16 - *(int*)((byte*)ptr + 12));
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	unsafe static int smethod_57(Class12.Class15 class15_0, Class12.Class14 class14_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class15_0.int_3), class14_0.AvailableBytes);
		*(int*)((byte*)ptr + 4) = 32768 - class15_0.int_2;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class23.smethod_41(class14_0, class15_0.byte_0, class15_0.int_2, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class23.smethod_41(class14_0, class15_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class23.smethod_41(class14_0, class15_0.byte_0, class15_0.int_2, int_0);
		}
		class15_0.int_2 = (class15_0.int_2 + *(int*)ptr) & 0x7FFF;
		class15_0.int_3 += *(int*)ptr;
		return *(int*)ptr;
	}

	static void smethod_58(Class12.Class22 class22_0)
	{
		if (class22_0.int_2 > 0)
		{
			class22_0.byte_0[class22_0.int_1++] = (byte)class22_0.uint_0;
			if (class22_0.int_2 > 8)
			{
				class22_0.byte_0[class22_0.int_1++] = (byte)(class22_0.uint_0 >> 8);
			}
		}
		class22_0.uint_0 = 0u;
		class22_0.int_2 = 0;
	}

	static bool smethod_59(Class12.Class19 class19_0)
	{
		return class19_0.int_9 >= 16384;
	}

	static bool smethod_60(bool bool_0, bool bool_1, Class12.Class21 class21_0)
	{
		bool flag;
		do
		{
			Class23.smethod_28(class21_0);
			flag = Class23.smethod_6(bool_1 && class21_0.int_17 == class21_0.int_18, bool_0, class21_0);
		}
		while (class21_0.class22_0.int_1 == 0 && flag);
		return flag;
	}

	static void smethod_61(Class12.Class22 class22_0, int int_0, int int_1)
	{
		class22_0.uint_0 |= (uint)(int_0 << class22_0.int_2);
		class22_0.int_2 += int_1;
		if (class22_0.int_2 >= 16)
		{
			class22_0.byte_0[class22_0.int_1++] = (byte)class22_0.uint_0;
			class22_0.byte_0[class22_0.int_1++] = (byte)(class22_0.uint_0 >> 8);
			class22_0.uint_0 >>= 16;
			class22_0.int_2 -= 16;
		}
	}

	unsafe static int smethod_62(Class12.Class19.Class20 class20_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class20_0.short_0.Length)
		{
			*(int*)ptr += class20_0.short_0[*(int*)((byte*)ptr + 4)] * class20_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		return *(int*)ptr;
	}

	static bool smethod_63(Class12.Class21 class21_0)
	{
		return class21_0.int_18 == class21_0.int_17;
	}

	static void smethod_64(Class12.Class22 class22_0, int int_0)
	{
		class22_0.byte_0[class22_0.int_1++] = (byte)int_0;
		class22_0.byte_0[class22_0.int_1++] = (byte)(int_0 >> 8);
	}

	unsafe static bool smethod_65(Class12.Class17 class17_0, Class12.Class14 class14_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (class17_0.int_8)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class12.Class17.int_7[class17_0.int_13];
				int num = Class23.smethod_30(class14_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class23.smethod_11(class14_0, *(int*)((byte*)ptr + 4));
					num += Class12.Class17.int_6[class17_0.int_13];
					while (num-- > 0)
					{
						class17_0.byte_1[class17_0.int_14++] = class17_0.byte_2;
					}
					if (class17_0.int_14 == class17_0.int_12)
					{
						return true;
					}
					goto IL_0080;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class23.smethod_5(class17_0.class16_0, class14_0)) & -16) == 0)
				{
					class17_0.byte_1[class17_0.int_14++] = (class17_0.byte_2 = (byte)num2);
					if (class17_0.int_14 == class17_0.int_12)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class17_0.byte_2 = 0;
					}
					class17_0.int_13 = num2 - 16;
					class17_0.int_8 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class17_0.int_14 < class17_0.int_11)
				{
					*(int*)ptr = Class23.smethod_30(class14_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class23.smethod_11(class14_0, 3);
						class17_0.byte_0[Class12.Class17.int_15[class17_0.int_14]] = (byte)(*(uint*)ptr);
						class17_0.int_14++;
						continue;
					}
					return false;
				}
				class17_0.class16_0 = new Class12.Class16(class17_0.byte_0);
				class17_0.byte_0 = null;
				class17_0.int_14 = 0;
				class17_0.int_8 = 4;
				goto case 4;
			case 2:
				class17_0.int_11 = Class23.smethod_30(class14_0, 4);
				if (class17_0.int_11 >= 0)
				{
					class17_0.int_11 += 4;
					Class23.smethod_11(class14_0, 4);
					class17_0.byte_0 = new byte[19];
					class17_0.int_14 = 0;
					class17_0.int_8 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class17_0.int_10 = Class23.smethod_30(class14_0, 5);
				if (class17_0.int_10 >= 0)
				{
					class17_0.int_10++;
					Class23.smethod_11(class14_0, 5);
					class17_0.int_12 = class17_0.int_9 + class17_0.int_10;
					class17_0.byte_1 = new byte[class17_0.int_12];
					class17_0.int_8 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class17_0.int_9 = Class23.smethod_30(class14_0, 5);
				if (class17_0.int_9 >= 0)
				{
					class17_0.int_9 += 257;
					Class23.smethod_11(class14_0, 5);
					class17_0.int_8 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			class17_0.int_8 = 4;
		}
	}

	static short smethod_66(int int_0)
	{
		return (short)((Class12.Class19.byte_0[int_0 & 0xF] << 12) | (Class12.Class19.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class12.Class19.byte_0[(int_0 >> 8) & 0xF] << 4) | Class12.Class19.byte_0[int_0 >> 12]);
	}

	static void smethod_67(int int_0, int int_1, byte[] byte_0, Class12.Class15 class15_0)
	{
		if (class15_0.int_3 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_0 > 32768)
		{
			int_1 += int_0 - 32768;
			int_0 = 32768;
		}
		Array.Copy(byte_0, int_1, class15_0.byte_0, 0, int_0);
		class15_0.int_2 = int_0 & 0x7FFF;
	}

	static void smethod_68(Class12.Class15 class15_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class15_0.byte_0[class15_0.int_2++] = class15_0.byte_0[int_0++];
			class15_0.int_2 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	unsafe static int smethod_69(Class12.Class18 class18_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[22];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = byte_0.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class23.smethod_55(class18_0.class22_0, byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			class18_0.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) == 0 || class18_0.int_6 == 30)
			{
				break;
			}
			Class12.Class21 class21_ = class18_0.class21_0;
			((byte*)ptr)[20] = (((class18_0.int_6 & 4) != 0) ? ((byte)1) : ((byte)0));
			((byte*)ptr)[21] = (((class18_0.int_6 & 8) != 0) ? ((byte)1) : ((byte)0));
			if (Class23.smethod_60(((byte*)ptr)[21] != 0, ((byte*)ptr)[20] != 0, class21_))
			{
				continue;
			}
			if (class18_0.int_6 != 16)
			{
				if (class18_0.int_6 == 20)
				{
					*(int*)((byte*)ptr + 16) = 8 + (-class18_0.class22_0.int_2 & 7);
					while (*(int*)((byte*)ptr + 16) > 0)
					{
						Class23.smethod_61(class18_0.class22_0, 2, 10);
						*(int*)((byte*)ptr + 16) -= 10;
					}
					class18_0.int_6 = 16;
				}
				else if (class18_0.int_6 == 28)
				{
					Class23.smethod_58(class18_0.class22_0);
					class18_0.int_6 = 30;
				}
				continue;
			}
			return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
		}
		return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
	}

	static bool smethod_70(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_1.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_0.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	static ICryptoTransform smethod_71(byte[] byte_0, bool bool_0, Class10 class10_0, byte[] byte_1)
	{
		class10_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class10_0.object_0, new object[1] { byte_0 });
		class10_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class10_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class10_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class10_0.object_0, new object[0]);
	}

	static void smethod_72(Class12.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	unsafe static void smethod_73(Class12.Class19.Class20 class20_0, int[] int_0)
	{
		void* ptr = stackalloc byte[36];
		class20_0.byte_0 = new byte[class20_0.short_0.Length];
		*(int*)ptr = int_0.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class20_0.int_3)
		{
			class20_0.int_2[*(int*)((byte*)ptr + 12)] = 0;
			(*(int*)((byte*)ptr + 12))++;
		}
		int[] array = new int[*(int*)ptr];
		array[*(int*)ptr - 1] = 0;
		*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
		int[] int_;
		nint num2;
		while (*(int*)((byte*)ptr + 16) >= 0)
		{
			if (int_0[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
			{
				*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
				if (*(int*)((byte*)ptr + 20) > class20_0.int_3)
				{
					*(int*)((byte*)ptr + 20) = class20_0.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[int_0[2 * *(int*)((byte*)ptr + 16)]] = (array[int_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				int[] array2 = (int_ = class20_0.int_2);
				int num = *(int*)((byte*)ptr + 24) - 1;
				num2 = num;
				array2[num] = int_[num2] + 1;
				class20_0.byte_0[int_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num3 = class20_0.int_3 - 1;
		while (true)
		{
			if (class20_0.int_2[--num3] != 0)
			{
				do
				{
					int[] array3 = (int_ = class20_0.int_2);
					int num4 = num3;
					num2 = num4;
					array3[num4] = int_[num2] - 1;
					int[] array4 = (int_ = class20_0.int_2);
					int num5 = ++num3;
					num2 = num5;
					array4[num5] = int_[num2] + 1;
					*(int*)((byte*)ptr + 8) -= 1 << class20_0.int_3 - 1 - num3;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num3 < class20_0.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class20_0.int_2);
		int num6 = class20_0.int_3 - 1;
		num2 = num6;
		array5[num6] = int_[num2] + *(int*)((byte*)ptr + 8);
		int[] array6 = (int_ = class20_0.int_2);
		int num7 = class20_0.int_3 - 2;
		num2 = num7;
		array6[num7] = int_[num2] - *(int*)((byte*)ptr + 8);
		int num8 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = class20_0.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = class20_0.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num9 = 2 * int_0[num8++];
				if (int_0[num9 + 1] == -1)
				{
					class20_0.byte_0[int_0[num9]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	static int smethod_74(Class12.Class15 class15_0)
	{
		return 32768 - class15_0.int_3;
	}

	static void smethod_75(int int_0, byte[] byte_0, Class12.Class22 class22_0, int int_1)
	{
		Array.Copy(byte_0, int_1, class22_0.byte_0, class22_0.int_1, int_0);
		class22_0.int_1 += int_0;
	}

	static void smethod_76(int int_0, Class12.Class14 class14_0, byte[] byte_0, int int_1)
	{
		if (class14_0.int_0 < class14_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class14_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class14_0.int_2);
				class14_0.int_2 += 8;
			}
			class14_0.byte_0 = byte_0;
			class14_0.int_0 = int_0;
			class14_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	unsafe static object smethod_77(Class5 class5_0)
	{
		void* ptr = stackalloc byte[5];
		*(int*)ptr = 860162;
		((byte*)ptr)[4] = 0;
		while (true)
		{
			((byte*)ptr)[4] = 1;
		}
	}

	static void smethod_78(Class11 class11_0)
	{
		class11_0.type_0.GetMethod("Clear")!.Invoke(class11_0.object_0, new object[0]);
	}
}
