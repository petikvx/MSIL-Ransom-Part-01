using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns4;

namespace ns0;

internal class Class9
{
	static void smethod_0()
	{
	}

	unsafe static void smethod_1(Class16.Class25 class25_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class25_0.byte_0, 32768, class25_0.byte_0, 0, 32768);
		class25_0.int_11 -= 32768;
		class25_0.int_14 -= 32768;
		class25_0.int_13 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class25_0.short_0[*(int*)ptr] & 0xFFFF;
			class25_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class25_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class25_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static void smethod_2()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class9.smethod_19;
		}
		catch
		{
		}
	}

	unsafe static void smethod_3()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[36];
		*(long*)((byte*)ptr + 8) = 226L;
		*(long*)ptr = 5434L;
		*(int*)((byte*)ptr + 24) = 5025;
		*(double*)((byte*)ptr + 16) = 51374.0;
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			*(int*)((byte*)ptr + 28) = 46298;
			while (true)
			{
				*(long*)((byte*)ptr + 8) = 2697L;
				*(double*)((byte*)ptr + 16) = 556.0;
			}
		}
		new decimal(39029145L);
		*(int*)((byte*)ptr + 32) = 5;
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			*(long*)((byte*)ptr + 8) = 25726765L;
			MessageBox.Show("mw@m\u007f1Su}y1jwP‚b\u0090:'6wIOl%WOfry(‘(SZ‘SKAŠ†\u0081^5gY*f$g{t[NtCHggGu€&p2bD‰„.dŒ0C‰}9$_M{a*\u0090FVmq6i\u007fv\u008d4&~[XUŠyp3");
			ProjectData.ClearProjectError();
		}
		Interaction.MsgBox((object)"Db9YJ9sH92H5qKuc", (MsgBoxStyle)0, (object)null);
	}

	unsafe static void smethod_4(Class16.Class23.Class24 class24_0)
	{
		void* ptr = stackalloc byte[36];
		*(int*)ptr = class24_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class24_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class24_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
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
		class24_0.int_1 = Math.Max(num2 + 1, class24_0.int_0);
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
			array3[*(int*)((byte*)ptr + 16)] = class24_0.short_0[*(int*)((byte*)ptr + 20)] << 8;
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
		Class9.smethod_30(array2, class24_0);
	}

	static bool smethod_5(int int_0, Class16.Class23 class23_0)
	{
		class23_0.short_0[class23_0.int_9] = 0;
		class23_0.byte_1[class23_0.int_9++] = (byte)int_0;
		short[] short_;
		short[] array = (short_ = class23_0.class24_0.short_0);
		nint num = int_0;
		array[int_0] = (short)(short_[num] + 1);
		return class23_0.int_9 >= 16384;
	}

	static void smethod_6(Class16.Class22 class22_0, byte[] byte_0)
	{
		Class9.smethod_64(byte_0, class22_0.class25_0);
	}

	static ICryptoTransform smethod_7(bool bool_0, byte[] byte_0, byte[] byte_1, Class15 class15_0)
	{
		class15_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class15_0.object_0, new object[1] { byte_0 });
		class15_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class15_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class15_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class15_0.object_0, new object[0]);
	}

	unsafe static void smethod_8(byte[] byte_0, Class16.Class20 class20_0)
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
		class20_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
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
				class20_0.short_0[Class9.smethod_44(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
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
				*(int*)((byte*)ptr + 56) = Class9.smethod_44(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class20_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class20_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class20_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	unsafe static int smethod_9(Class16.Class20 class20_0, Class16.Class18 class18_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class9.smethod_26(class18_0, 9)) >= 0)
		{
			if ((num2 = class20_0.short_0[num]) >= 0)
			{
				Class9.smethod_27(class18_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class9.smethod_26(class18_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class20_0.short_0[*(int*)ptr | (num >> 9)];
				Class9.smethod_27(class18_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class18_0.int_2;
			num = Class9.smethod_26(class18_0, *(int*)((byte*)ptr + 8));
			num2 = class20_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class9.smethod_27(class18_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class18_0.int_2;
		num = Class9.smethod_26(class18_0, *(int*)((byte*)ptr + 12));
		num2 = class20_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class9.smethod_27(class18_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static void smethod_10(Class16.Class23 class23_0, int int_0)
	{
		Class9.smethod_14(class23_0.class24_2);
		Class9.smethod_14(class23_0.class24_0);
		Class9.smethod_14(class23_0.class24_1);
		Class9.smethod_16(class23_0.class26_0, class23_0.class24_0.int_1 - 257, 5);
		Class9.smethod_16(class23_0.class26_0, class23_0.class24_1.int_1 - 1, 5);
		Class9.smethod_16(class23_0.class26_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class9.smethod_16(class23_0.class26_0, (int)class23_0.class24_2.byte_0[Class16.Class23.int_8[i]], 3);
		}
		Class16.Class23.Class24 class24_ = class23_0.class24_0;
		Class16.Class23.Class24 class24_2 = class23_0.class24_2;
		Class9.smethod_34(class24_2, class24_);
		class24_ = class23_0.class24_1;
		class24_2 = class23_0.class24_2;
		Class9.smethod_34(class24_2, class24_);
	}

	static void smethod_11(Class16.Class25 class25_0)
	{
		class25_0.int_10 = (class25_0.byte_0[class25_0.int_14] << 5) ^ class25_0.byte_0[class25_0.int_14 + 1];
	}

	static void smethod_12(short[] short_0, byte[] byte_0, Class16.Class23.Class24 class24_0)
	{
		class24_0.short_1 = short_0;
		class24_0.byte_0 = byte_0;
	}

	static void smethod_13(byte[] byte_0, int int_0, int int_1, Class16.Class18 class18_0)
	{
		if (class18_0.int_0 < class18_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class18_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class18_0.int_2);
				class18_0.int_2 += 8;
			}
			class18_0.byte_0 = byte_0;
			class18_0.int_0 = int_0;
			class18_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	unsafe static void smethod_14(Class16.Class23.Class24 class24_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class24_0.int_3];
		*(int*)ptr = 0;
		class24_0.short_1 = new short[class24_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class24_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class24_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class24_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class24_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class24_0.short_1[*(int*)((byte*)ptr + 8)] = Class9.smethod_44(array[*(int*)((byte*)ptr + 12) - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num = *(int*)((byte*)ptr + 12) - 1;
				nint num2 = num;
				array3[num] = array2[num2] + (1 << 16 - *(int*)((byte*)ptr + 12));
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static byte[] smethod_15(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class9.smethod_77(byte_0, byte_1, byte_2, 3);
	}

	static void smethod_16(Class16.Class26 class26_0, int int_0, int int_1)
	{
		class26_0.uint_0 |= (uint)(int_0 << class26_0.int_2);
		class26_0.int_2 += int_1;
		if (class26_0.int_2 >= 16)
		{
			class26_0.byte_0[class26_0.int_1++] = (byte)class26_0.uint_0;
			class26_0.byte_0[class26_0.int_1++] = (byte)(class26_0.uint_0 >> 8);
			class26_0.uint_0 >>= 16;
			class26_0.int_2 -= 16;
		}
	}

	static int smethod_17(int int_0, Class16.Class23 class23_0)
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

	unsafe static void smethod_18()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[16];
		MessageBox.Show("‹nE~ŒMo{Ko6X&L->4Mi9T;Lz");
		MessageBox.Show("&/f<‘eA2U}>?V:ŠŠE)L6FD\u0081:\u008fJgpB]ŒMz.t;(\u008dZS*\u008d|I/Jv:CTT{2O;u@L@f‘dƒŠƒƒWHXn\u0081KaŒ,L[W*dgML\u0081)1:K…‘\u008dol‡UY*…X>†Nthe)99C\u0081:{An‘d7");
		*(int*)ptr = 140;
		*(int*)((byte*)ptr + 4) = 5;
		*(int*)((byte*)ptr + 8) = 8;
		while (true)
		{
			*(int*)((byte*)ptr + 12) = 56237;
		}
	}

	unsafe static Assembly smethod_19(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		void* ptr = stackalloc byte[18];
		Class11.Struct0 @struct = new Class11.Struct0(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2EzOTk5ODE2LWYzYmQtNGY1ZS05MWE0LTUwZTBhNzU1Yjg4OX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{d665fcb5-50af-4616-8983-aabb628aa46c},e2EzOTk5ODE2LWYzYmQtNGY1ZS05MWE0LTUwZTBhNzU1Yjg4OX0=,[z]{d665fcb5-50af-4616-8983-aabb628aa46c}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		((byte*)ptr)[16] = 0;
		((byte*)ptr)[17] = 0;
		*(int*)ptr = 0;
		while (*(int*)ptr < array.Length - 1)
		{
			if (!(array[*(int*)ptr] == text))
			{
				*(int*)ptr += 2;
				continue;
			}
			text2 = array[*(int*)ptr + 1];
			break;
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array.Length - 1)
			{
				if (!(array[*(int*)((byte*)ptr + 4)] == text))
				{
					*(int*)((byte*)ptr + 4) += 2;
					continue;
				}
				text2 = array[*(int*)((byte*)ptr + 4) + 1];
				break;
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				*(int*)((byte*)ptr + 8) = text2.IndexOf(']');
				string text3 = text2.Substring(1, *(int*)((byte*)ptr + 8) - 1);
				((byte*)ptr)[16] = ((text3.IndexOf('z') >= 0) ? ((byte)1) : ((byte)0));
				((byte*)ptr)[17] = ((text3.IndexOf('t') >= 0) ? ((byte)1) : ((byte)0));
				text2 = text2.Substring(*(int*)((byte*)ptr + 8) + 1);
			}
			lock (Class11.hashtable_0)
			{
				if (Class11.hashtable_0.ContainsKey(text2))
				{
					return (Assembly)Class11.hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
					manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
					if (((byte*)ptr)[16] != 0)
					{
						array2 = Class9.smethod_32(array2);
					}
					Assembly assembly = null;
					if (((byte*)ptr)[17] == 0)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							((byte*)ptr)[17] = 1;
						}
						catch (BadImageFormatException)
						{
							((byte*)ptr)[17] = 1;
						}
					}
					if (((byte*)ptr)[17] != 0)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								Class9.MoveFileEx(text5, (string)null, 4);
								Class9.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class11.hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	unsafe static bool smethod_20(Class16.Class21 class21_0, Class16.Class18 class18_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (class21_0.int_8)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class16.Class21.int_7[class21_0.int_13];
				int num = Class9.smethod_26(class18_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class9.smethod_27(class18_0, *(int*)((byte*)ptr + 4));
					num += Class16.Class21.int_6[class21_0.int_13];
					while (num-- > 0)
					{
						class21_0.byte_1[class21_0.int_14++] = class21_0.byte_2;
					}
					if (class21_0.int_14 == class21_0.int_12)
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
				while (((num2 = Class9.smethod_9(class21_0.class20_0, class18_0)) & -16) == 0)
				{
					class21_0.byte_1[class21_0.int_14++] = (class21_0.byte_2 = (byte)num2);
					if (class21_0.int_14 == class21_0.int_12)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class21_0.byte_2 = 0;
					}
					class21_0.int_13 = num2 - 16;
					class21_0.int_8 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class21_0.int_14 < class21_0.int_11)
				{
					*(int*)ptr = Class9.smethod_26(class18_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class9.smethod_27(class18_0, 3);
						class21_0.byte_0[Class16.Class21.int_15[class21_0.int_14]] = (byte)(*(uint*)ptr);
						class21_0.int_14++;
						continue;
					}
					return false;
				}
				class21_0.class20_0 = new Class16.Class20(class21_0.byte_0);
				class21_0.byte_0 = null;
				class21_0.int_14 = 0;
				class21_0.int_8 = 4;
				goto case 4;
			case 2:
				class21_0.int_11 = Class9.smethod_26(class18_0, 4);
				if (class21_0.int_11 >= 0)
				{
					class21_0.int_11 += 4;
					Class9.smethod_27(class18_0, 4);
					class21_0.byte_0 = new byte[19];
					class21_0.int_14 = 0;
					class21_0.int_8 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class21_0.int_10 = Class9.smethod_26(class18_0, 5);
				if (class21_0.int_10 >= 0)
				{
					class21_0.int_10++;
					Class9.smethod_27(class18_0, 5);
					class21_0.int_12 = class21_0.int_9 + class21_0.int_10;
					class21_0.byte_1 = new byte[class21_0.int_12];
					class21_0.int_8 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class21_0.int_9 = Class9.smethod_26(class18_0, 5);
				if (class21_0.int_9 >= 0)
				{
					class21_0.int_9 += 257;
					Class9.smethod_27(class18_0, 5);
					class21_0.int_8 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			class21_0.int_8 = 4;
		}
	}

	static bool smethod_21(Class16.Class25 class25_0)
	{
		return class25_0.int_18 == class25_0.int_17;
	}

	static Class16.Class20 smethod_22(Class16.Class21 class21_0)
	{
		byte[] array = new byte[class21_0.int_10];
		Array.Copy(class21_0.byte_1, class21_0.int_9, array, 0, class21_0.int_10);
		return new Class16.Class20(array);
	}

	unsafe static int smethod_23(byte[] byte_0, int int_0, int int_1, Class16.Class19 class19_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class19_0.int_2;
		if (int_1 > class19_0.int_3)
		{
			int_1 = class19_0.int_3;
		}
		else
		{
			*(int*)ptr = (class19_0.int_2 - class19_0.int_3 + int_1) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_1;
		*(int*)((byte*)ptr + 8) = int_1 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class19_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_0, *(int*)((byte*)ptr + 8));
			int_0 += *(int*)((byte*)ptr + 8);
			int_1 = *(int*)ptr;
		}
		Array.Copy(class19_0.byte_0, *(int*)ptr - int_1, byte_0, int_0, int_1);
		class19_0.int_3 -= *(int*)((byte*)ptr + 4);
		if (class19_0.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static void smethod_24(Class16.Class19 class19_0)
	{
		class19_0.int_2 = 0;
		class19_0.int_3 = 0;
	}

	static int smethod_25(Class16.Class25 class25_0)
	{
		int num = ((class25_0.int_10 << 5) ^ class25_0.byte_0[class25_0.int_14 + 2]) & 0x7FFF;
		short num2 = (class25_0.short_1[class25_0.int_14 & 0x7FFF] = class25_0.short_0[num]);
		class25_0.short_0[num] = (short)class25_0.int_14;
		class25_0.int_10 = num;
		return num2 & 0xFFFF;
	}

	static int smethod_26(Class16.Class18 class18_0, int int_0)
	{
		if (class18_0.int_2 < int_0)
		{
			if (class18_0.int_0 == class18_0.int_1)
			{
				return -1;
			}
			class18_0.uint_0 |= (uint)(((class18_0.byte_0[class18_0.int_0++] & 0xFF) | ((class18_0.byte_0[class18_0.int_0++] & 0xFF) << 8)) << class18_0.int_2);
			class18_0.int_2 += 16;
		}
		return (int)(class18_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_27(Class16.Class18 class18_0, int int_0)
	{
		class18_0.uint_0 >>= int_0;
		class18_0.int_2 -= int_0;
	}

	static void smethod_28()
	{
		try
		{
			Class13.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_29(Class16.Class19 class19_0, int int_0, int int_1)
	{
		if ((class19_0.int_3 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class19_0.int_2 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class19_0.int_2 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class19_0.byte_0, num, class19_0.byte_0, class19_0.int_2, int_0);
				class19_0.int_2 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class19_0.byte_0[class19_0.int_2++] = class19_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class9.smethod_61(class19_0, num, int_0, int_1);
		}
	}

	unsafe static void smethod_30(int[] int_0, Class16.Class23.Class24 class24_0)
	{
		void* ptr = stackalloc byte[36];
		class24_0.byte_0 = new byte[class24_0.short_0.Length];
		*(int*)ptr = int_0.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class24_0.int_3)
		{
			class24_0.int_2[*(int*)((byte*)ptr + 12)] = 0;
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
				if (*(int*)((byte*)ptr + 20) > class24_0.int_3)
				{
					*(int*)((byte*)ptr + 20) = class24_0.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[int_0[2 * *(int*)((byte*)ptr + 16)]] = (array[int_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				int[] array2 = (int_ = class24_0.int_2);
				int num = *(int*)((byte*)ptr + 24) - 1;
				num2 = num;
				array2[num] = int_[num2] + 1;
				class24_0.byte_0[int_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num3 = class24_0.int_3 - 1;
		while (true)
		{
			if (class24_0.int_2[--num3] != 0)
			{
				do
				{
					int[] array3 = (int_ = class24_0.int_2);
					int num4 = num3;
					num2 = num4;
					array3[num4] = int_[num2] - 1;
					int[] array4 = (int_ = class24_0.int_2);
					int num5 = ++num3;
					num2 = num5;
					array4[num5] = int_[num2] + 1;
					*(int*)((byte*)ptr + 8) -= 1 << class24_0.int_3 - 1 - num3;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num3 < class24_0.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class24_0.int_2);
		int num6 = class24_0.int_3 - 1;
		num2 = num6;
		array5[num6] = int_[num2] + *(int*)((byte*)ptr + 8);
		int[] array6 = (int_ = class24_0.int_2);
		int num7 = class24_0.int_3 - 2;
		num2 = num7;
		array6[num7] = int_[num2] - *(int*)((byte*)ptr + 8);
		int num8 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = class24_0.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = class24_0.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num9 = 2 * int_0[num8++];
				if (int_0[num9 + 1] == -1)
				{
					class24_0.byte_0[int_0[num9]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	unsafe static bool smethod_31(int int_0, int int_1, Class16.Class23 class23_0)
	{
		void* ptr = stackalloc byte[8];
		class23_0.short_0[class23_0.int_9] = (short)int_1;
		class23_0.byte_1[class23_0.int_9++] = (byte)(int_0 - 3);
		*(int*)ptr = Class9.smethod_17(int_0 - 3, class23_0);
		short[] short_;
		short[] array = (short_ = class23_0.class24_0.short_0);
		int num = *(int*)ptr;
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			class23_0.int_10 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class9.smethod_56(class23_0, int_1 - 1);
		short[] array2 = (short_ = class23_0.class24_1.short_0);
		int num3 = *(int*)((byte*)ptr + 4);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			class23_0.int_10 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		return class23_0.int_9 >= 16384;
	}

	unsafe static byte[] smethod_32(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class9.smethod_45(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class16.Stream0 stream = new Class16.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class9.smethod_51(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class9.smethod_46(stream);
			*(int*)((byte*)ptr + 4) = Class9.smethod_46(stream);
			*(int*)((byte*)ptr + 8) = Class9.smethod_46(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class9.smethod_51(stream);
			Class9.smethod_51(stream);
			Class9.smethod_51(stream);
			*(int*)((byte*)ptr + 12) = Class9.smethod_51(stream);
			*(int*)((byte*)ptr + 16) = Class9.smethod_46(stream);
			*(int*)((byte*)ptr + 20) = Class9.smethod_46(stream);
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
			Class16.Class17 class17_ = new Class16.Class17(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class9.smethod_79(array.Length, class17_, array, 0);
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
				*(int*)((byte*)ptr + 28) = Class9.smethod_51(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class9.smethod_51(stream);
					*(int*)((byte*)ptr + 40) = Class9.smethod_51(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class16.Class17 class17_2 = new Class16.Class17(array3);
					Class9.smethod_79(*(int*)((byte*)ptr + 40), class17_2, array, *(int*)((byte*)ptr + 32));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 219, 32, 211, 18, 11, 113, 144, 71 };
				byte[] byte_2 = new byte[8] { 33, 13, 18, 224, 119, 176, 169, 68 };
				using Class15 class15_ = new Class15();
				using ICryptoTransform cryptoTransform = Class9.smethod_7(bool_0: true, byte_, byte_2, class15_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class9.smethod_32(byte_3);
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
				using Class14 class14_ = new Class14();
				using ICryptoTransform cryptoTransform2 = Class9.smethod_52(byte_4, byte_5, bool_0: true, class14_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class9.smethod_32(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static bool smethod_33(bool bool_0, bool bool_1, Class16.Class25 class25_0)
	{
		void* ptr = stackalloc byte[28];
		if (class25_0.int_15 < 262 && !bool_0)
		{
			return false;
		}
		Class16.Class23 class23_3;
		byte[] byte_;
		do
		{
			if (class25_0.int_15 >= 262 || bool_0)
			{
				if (class25_0.int_15 != 0)
				{
					if (class25_0.int_14 >= 65274)
					{
						Class9.smethod_1(class25_0);
					}
					*(int*)ptr = class25_0.int_11;
					int int_ = class25_0.int_12;
					if (class25_0.int_15 >= 3)
					{
						*(int*)((byte*)ptr + 4) = Class9.smethod_25(class25_0);
						if (*(int*)((byte*)ptr + 4) != 0 && class25_0.int_14 - *(int*)((byte*)ptr + 4) <= 32506 && Class9.smethod_57(*(int*)((byte*)ptr + 4), class25_0) && class25_0.int_12 <= 5 && class25_0.int_12 == 3 && class25_0.int_14 - class25_0.int_11 > 4096)
						{
							class25_0.int_12 = 2;
						}
					}
					if (int_ >= 3 && class25_0.int_12 <= int_)
					{
						Class16.Class23 class23_ = class25_0.class23_0;
						*(int*)((byte*)ptr + 20) = class25_0.int_14 - 1 - *(int*)ptr;
						Class9.smethod_31(int_, *(int*)((byte*)ptr + 20), class23_);
						int_ -= 2;
						do
						{
							class25_0.int_14++;
							class25_0.int_15--;
							if (class25_0.int_15 >= 3)
							{
								Class9.smethod_25(class25_0);
							}
						}
						while (--int_ > 0);
						class25_0.int_14++;
						class25_0.int_15--;
						class25_0.bool_0 = false;
						class25_0.int_12 = 2;
					}
					else
					{
						if (class25_0.bool_0)
						{
							Class16.Class23 class23_2 = class25_0.class23_0;
							*(int*)((byte*)ptr + 16) = class25_0.byte_0[class25_0.int_14 - 1] & 0xFF;
							Class9.smethod_5(*(int*)((byte*)ptr + 16), class23_2);
						}
						class25_0.bool_0 = true;
						class25_0.int_14++;
						class25_0.int_15--;
					}
					continue;
				}
				if (class25_0.bool_0)
				{
					Class16.Class23 class23_2 = class25_0.class23_0;
					*(int*)((byte*)ptr + 16) = class25_0.byte_0[class25_0.int_14 - 1] & 0xFF;
					Class9.smethod_5(*(int*)((byte*)ptr + 16), class23_2);
				}
				class25_0.bool_0 = false;
				class23_3 = class25_0.class23_0;
				byte_ = class25_0.byte_0;
				*(int*)((byte*)ptr + 12) = class25_0.int_13;
				*(int*)((byte*)ptr + 24) = class25_0.int_14 - class25_0.int_13;
				Class9.smethod_37(*(int*)((byte*)ptr + 24), byte_, *(int*)((byte*)ptr + 12), class23_3, bool_1);
				class25_0.int_13 = class25_0.int_14;
				return false;
			}
			return true;
		}
		while (class25_0.class23_0.int_9 < 16384);
		*(int*)((byte*)ptr + 8) = class25_0.int_14 - class25_0.int_13;
		if (class25_0.bool_0)
		{
			(*(int*)((byte*)ptr + 8))--;
		}
		bool flag = bool_1 && class25_0.int_15 == 0 && !class25_0.bool_0;
		class23_3 = class25_0.class23_0;
		byte_ = class25_0.byte_0;
		*(int*)((byte*)ptr + 12) = class25_0.int_13;
		Class9.smethod_37(*(int*)((byte*)ptr + 8), byte_, *(int*)((byte*)ptr + 12), class23_3, flag);
		class25_0.int_13 += *(int*)((byte*)ptr + 8);
		return !flag;
	}

	unsafe static void smethod_34(Class16.Class23.Class24 class24_0, Class16.Class23.Class24 class24_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class24_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class24_1.byte_0[*(int*)((byte*)ptr + 12)];
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
					Class9.smethod_73(class24_0, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class24_1.int_1 && *(int*)((byte*)ptr + 8) == class24_1.byte_0[*(int*)((byte*)ptr + 12)])
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
					Class9.smethod_73(class24_0, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class9.smethod_73(class24_0, 16);
				Class9.smethod_16(class24_1.class23_0.class26_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class9.smethod_73(class24_0, 17);
				Class9.smethod_16(class24_1.class23_0.class26_0, num - 3, 3);
			}
			else
			{
				Class9.smethod_73(class24_0, 18);
				Class9.smethod_16(class24_1.class23_0.class26_0, num - 11, 7);
			}
		}
	}

	static void smethod_35(Class16.Class25 class25_0)
	{
		if (class25_0.int_14 >= 65274)
		{
			Class9.smethod_1(class25_0);
		}
		while (class25_0.int_15 < 262 && class25_0.int_17 < class25_0.int_18)
		{
			int num = 65536 - class25_0.int_15 - class25_0.int_14;
			if (num > class25_0.int_18 - class25_0.int_17)
			{
				num = class25_0.int_18 - class25_0.int_17;
			}
			Array.Copy(class25_0.byte_1, class25_0.int_17, class25_0.byte_0, class25_0.int_14 + class25_0.int_15, num);
			class25_0.int_17 += num;
			class25_0.int_16 += num;
			class25_0.int_15 += num;
		}
		if (class25_0.int_15 >= 3)
		{
			Class9.smethod_11(class25_0);
		}
	}

	static byte[] smethod_36(byte[] byte_0)
	{
		return Class9.smethod_77((byte[])null, byte_0, (byte[])null, 1);
	}

	unsafe static void smethod_37(int int_0, byte[] byte_0, int int_1, Class16.Class23 class23_0, bool bool_0)
	{
		void* ptr = stackalloc byte[24];
		short[] short_;
		(short_ = class23_0.class24_0.short_0)[256] = (short)(short_[256] + 1);
		Class9.smethod_4(class23_0.class24_0);
		Class9.smethod_4(class23_0.class24_1);
		Class16.Class23.Class24 class24_ = class23_0.class24_0;
		Class16.Class23.Class24 class24_2 = class23_0.class24_2;
		Class9.smethod_81(class24_2, class24_);
		class24_ = class23_0.class24_1;
		class24_2 = class23_0.class24_2;
		Class9.smethod_81(class24_2, class24_);
		Class9.smethod_4(class23_0.class24_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 4) = 18;
		while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
		{
			if (class23_0.class24_2.byte_0[Class16.Class23.int_8[*(int*)((byte*)ptr + 4)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
			}
			(*(int*)((byte*)ptr + 4))--;
		}
		*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + Class9.smethod_68(class23_0.class24_2) + Class9.smethod_68(class23_0.class24_0) + Class9.smethod_68(class23_0.class24_1) + class23_0.int_10;
		*(int*)((byte*)ptr + 12) = class23_0.int_10;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 12) += class23_0.class24_0.short_0[*(int*)((byte*)ptr + 16)] * Class16.Class23.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 12) += class23_0.class24_1.short_0[*(int*)((byte*)ptr + 20)] * Class16.Class23.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
		}
		if (int_1 >= 0 && int_0 + 4 < *(int*)((byte*)ptr + 8) >> 3)
		{
			Class9.smethod_75(int_1, byte_0, int_0, class23_0, bool_0);
		}
		else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
		{
			Class9.smethod_16(class23_0.class26_0, 2 + (bool_0 ? 1 : 0), 3);
			Class16.Class23.Class24 class24_3 = class23_0.class24_0;
			short[] short_2 = Class16.Class23.short_1;
			byte[] byte_ = Class16.Class23.byte_2;
			Class9.smethod_12(short_2, byte_, class24_3);
			class24_3 = class23_0.class24_1;
			short_2 = Class16.Class23.short_2;
			byte_ = Class16.Class23.byte_3;
			Class9.smethod_12(short_2, byte_, class24_3);
			Class9.smethod_40(class23_0);
			Class9.smethod_60(class23_0);
		}
		else
		{
			Class9.smethod_16(class23_0.class26_0, 4 + (bool_0 ? 1 : 0), 3);
			Class9.smethod_10(class23_0, *(int*)ptr);
			Class9.smethod_40(class23_0);
			Class9.smethod_60(class23_0);
		}
	}

	unsafe static int smethod_38(byte[] byte_0, Class16.Class22 class22_0)
	{
		void* ptr = stackalloc byte[22];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = byte_0.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class9.smethod_69(class22_0.class26_0, byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			class22_0.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) == 0 || class22_0.int_6 == 30)
			{
				break;
			}
			Class16.Class25 class25_ = class22_0.class25_0;
			((byte*)ptr)[20] = (((class22_0.int_6 & 4) != 0) ? ((byte)1) : ((byte)0));
			((byte*)ptr)[21] = (((class22_0.int_6 & 8) != 0) ? ((byte)1) : ((byte)0));
			if (Class9.smethod_83(((byte*)ptr)[20] != 0, class25_, ((byte*)ptr)[21] != 0))
			{
				continue;
			}
			if (class22_0.int_6 != 16)
			{
				if (class22_0.int_6 == 20)
				{
					*(int*)((byte*)ptr + 16) = 8 + (-class22_0.class26_0.int_2 & 7);
					while (*(int*)((byte*)ptr + 16) > 0)
					{
						Class9.smethod_16(class22_0.class26_0, 2, 10);
						*(int*)((byte*)ptr + 16) -= 10;
					}
					class22_0.int_6 = 16;
				}
				else if (class22_0.int_6 == 28)
				{
					Class9.smethod_48(class22_0.class26_0);
					class22_0.int_6 = 30;
				}
				continue;
			}
			return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
		}
		return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
	}

	static void smethod_39()
	{
		try
		{
			Class9.smethod_2();
		}
		catch (Exception)
		{
		}
	}

	unsafe static void smethod_40(Class16.Class23 class23_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class23_0.int_9)
		{
			*(int*)((byte*)ptr + 4) = class23_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class23_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class9.smethod_17(*(int*)((byte*)ptr + 4), class23_0);
				Class9.smethod_73(class23_0.class24_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class9.smethod_16(class23_0.class26_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class9.smethod_56(class23_0, num);
				Class9.smethod_73(class23_0.class24_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class9.smethod_16(class23_0.class26_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class9.smethod_73(class23_0.class24_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class9.smethod_73(class23_0.class24_0, 256);
	}

	static void smethod_41(Class14 class14_0)
	{
		class14_0.type_0.GetMethod("Clear")!.Invoke(class14_0.object_0, new object[0]);
	}

	static bool smethod_42(Class16.Class23 class23_0)
	{
		return class23_0.int_9 >= 16384;
	}

	unsafe static int smethod_43(Class16.Class19 class19_0, Class16.Class18 class18_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class19_0.int_3), class18_0.AvailableBytes);
		*(int*)((byte*)ptr + 4) = 32768 - class19_0.int_2;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class9.smethod_59(class18_0, class19_0.byte_0, class19_0.int_2, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class9.smethod_59(class18_0, class19_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class9.smethod_59(class18_0, class19_0.byte_0, class19_0.int_2, int_0);
		}
		class19_0.int_2 = (class19_0.int_2 + *(int*)ptr) & 0x7FFF;
		class19_0.int_3 += *(int*)ptr;
		return *(int*)ptr;
	}

	static short smethod_44(int int_0)
	{
		return (short)((Class16.Class23.byte_0[int_0 & 0xF] << 12) | (Class16.Class23.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class16.Class23.byte_0[(int_0 >> 8) & 0xF] << 4) | Class16.Class23.byte_0[int_0 >> 12]);
	}

	static bool smethod_45(Assembly assembly_0, Assembly assembly_1)
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

	static int smethod_46(Class16.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_47(Class16.Class18 class18_0)
	{
		class18_0.int_2 = 0;
		class18_0.int_1 = 0;
		class18_0.int_0 = 0;
		class18_0.uint_0 = 0u;
	}

	static void smethod_48(Class16.Class26 class26_0)
	{
		if (class26_0.int_2 > 0)
		{
			class26_0.byte_0[class26_0.int_1++] = (byte)class26_0.uint_0;
			if (class26_0.int_2 > 8)
			{
				class26_0.byte_0[class26_0.int_1++] = (byte)(class26_0.uint_0 >> 8);
			}
		}
		class26_0.uint_0 = 0u;
		class26_0.int_2 = 0;
	}

	unsafe static bool smethod_49(Class16.Class17 class17_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class9.smethod_54(class17_0.class19_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class17_0.int_17;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class9.smethod_9(class17_0.class20_0, class17_0.class18_0)) & -256) == 0)
				{
					Class9.smethod_66(class17_0.class19_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class17_0.int_19 = Class16.Class17.int_13[num2 - 257];
					class17_0.int_18 = Class16.Class17.int_14[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class17_0.class20_1 = null;
				class17_0.class20_0 = null;
				class17_0.int_17 = 2;
				return true;
			}
			case 8:
				if (class17_0.int_18 > 0)
				{
					class17_0.int_17 = 8;
					*(int*)ptr = Class9.smethod_26(class17_0.class18_0, class17_0.int_18);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class9.smethod_27(class17_0.class18_0, class17_0.int_18);
					class17_0.int_19 += *(int*)ptr;
				}
				class17_0.int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class9.smethod_9(class17_0.class20_1, class17_0.class18_0);
				if (num2 >= 0)
				{
					class17_0.int_20 = Class16.Class17.int_15[num2];
					class17_0.int_18 = Class16.Class17.int_16[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class17_0.int_18 > 0)
				{
					class17_0.int_17 = 10;
					*(int*)((byte*)ptr + 4) = Class9.smethod_26(class17_0.class18_0, class17_0.int_18);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class9.smethod_27(class17_0.class18_0, class17_0.int_18);
					class17_0.int_20 += *(int*)((byte*)ptr + 4);
				}
				Class9.smethod_29(class17_0.class19_0, class17_0.int_19, class17_0.int_20);
				num -= class17_0.int_19;
				class17_0.int_17 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_50(int int_0, byte[] byte_0, int int_1, Class16.Class19 class19_0)
	{
		if (class19_0.int_3 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_0 > 32768)
		{
			int_1 += int_0 - 32768;
			int_0 = 32768;
		}
		Array.Copy(byte_0, int_1, class19_0.byte_0, 0, int_0);
		class19_0.int_2 = int_0 & 0x7FFF;
	}

	static int smethod_51(Class16.Stream0 stream0_0)
	{
		return Class9.smethod_46(stream0_0) | (Class9.smethod_46(stream0_0) << 16);
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static ICryptoTransform smethod_52(byte[] byte_0, byte[] byte_1, bool bool_0, Class14 class14_0)
	{
		class14_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class14_0.object_0, new object[1] { byte_0 });
		class14_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class14_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class14_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class14_0.object_0, new object[0]);
	}

	unsafe static void smethod_53(pass pass_0)
	{
		void* ptr = stackalloc byte[37];
		*(long*)ptr = 1L;
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			*(int*)((byte*)ptr + 32) = -1963214489;
			ProjectData.ClearProjectError();
		}
		*(double*)((byte*)ptr + 8) = 0.1556631;
		((byte*)ptr)[36] = 1;
		while (true)
		{
			*(long*)((byte*)ptr + 16) = 0L;
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				*(long*)((byte*)ptr + 24) = 1L;
				ProjectData.ClearProjectError();
			}
		}
	}

	static int smethod_54(Class16.Class19 class19_0)
	{
		return 32768 - class19_0.int_3;
	}

	unsafe static bool smethod_55(Class16.Class17 class17_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class17_0.int_17)
		{
		case 2:
			if (class17_0.bool_0)
			{
				class17_0.int_17 = 12;
				return false;
			}
			*(int*)ptr = Class9.smethod_26(class17_0.class18_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class9.smethod_27(class17_0.class18_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class17_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class9.smethod_71(class17_0.class18_0);
				class17_0.int_17 = 3;
				break;
			case 1:
				class17_0.class20_0 = Class16.Class20.class20_0;
				class17_0.class20_1 = Class16.Class20.class20_1;
				class17_0.int_17 = 7;
				break;
			case 2:
				class17_0.class21_0 = new Class16.Class21();
				class17_0.int_17 = 6;
				break;
			}
			return true;
		case 3:
			if ((class17_0.int_21 = Class9.smethod_26(class17_0.class18_0, 16)) < 0)
			{
				return false;
			}
			Class9.smethod_27(class17_0.class18_0, 16);
			class17_0.int_17 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class9.smethod_26(class17_0.class18_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class9.smethod_27(class17_0.class18_0, 16);
			class17_0.int_17 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class9.smethod_43(class17_0.class19_0, class17_0.class18_0, class17_0.int_21);
			class17_0.int_21 -= *(int*)((byte*)ptr + 8);
			if (class17_0.int_21 == 0)
			{
				class17_0.int_17 = 2;
				return true;
			}
			return !class17_0.class18_0.IsNeedingInput;
		case 6:
			if (!Class9.smethod_20(class17_0.class21_0, class17_0.class18_0))
			{
				return false;
			}
			class17_0.class20_0 = Class9.smethod_78(class17_0.class21_0);
			class17_0.class20_1 = Class9.smethod_22(class17_0.class21_0);
			class17_0.int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class9.smethod_49(class17_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static int smethod_56(Class16.Class23 class23_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	unsafe static bool smethod_57(int int_0, Class16.Class25 class25_0)
	{
		void* ptr = stackalloc byte[22];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = class25_0.short_1;
		int int_ = class25_0.int_14;
		*(int*)((byte*)ptr + 4) = class25_0.int_14 + class25_0.int_12;
		*(int*)((byte*)ptr + 8) = Math.Max(class25_0.int_12, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(class25_0.int_14 - 32506, 0);
		*(int*)((byte*)ptr + 16) = class25_0.int_14 + 258 - 1;
		((byte*)ptr)[20] = class25_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = class25_0.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > class25_0.int_15)
		{
			*(int*)ptr = class25_0.int_15;
		}
		do
		{
			if (class25_0.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || class25_0.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || class25_0.byte_0[int_0] != class25_0.byte_0[int_] || class25_0.byte_0[int_0 + 1] != class25_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (class25_0.byte_0[++int_] == class25_0.byte_0[++num2] && class25_0.byte_0[++int_] == class25_0.byte_0[++num2] && class25_0.byte_0[++int_] == class25_0.byte_0[++num2] && class25_0.byte_0[++int_] == class25_0.byte_0[++num2] && class25_0.byte_0[++int_] == class25_0.byte_0[++num2] && class25_0.byte_0[++int_] == class25_0.byte_0[++num2] && class25_0.byte_0[++int_] == class25_0.byte_0[++num2] && class25_0.byte_0[++int_] == class25_0.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				class25_0.int_11 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - class25_0.int_14;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = class25_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = class25_0.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = class25_0.int_14;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		class25_0.int_12 = Math.Min(*(int*)((byte*)ptr + 8), class25_0.int_15);
		return class25_0.int_12 >= 3;
	}

	unsafe static object smethod_58()
	{
		void* ptr = stackalloc byte[5];
		((byte*)ptr)[4] = 0;
		*(int*)ptr = 0;
		return 41760;
	}

	unsafe static int smethod_59(Class16.Class18 class18_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class18_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class18_0.uint_0;
			class18_0.uint_0 >>= 8;
			class18_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class18_0.int_1 - class18_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class18_0.byte_0, class18_0.int_0, byte_0, int_0, int_1);
		class18_0.int_0 += int_1;
		if (((uint)(class18_0.int_0 - class18_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class18_0.uint_0 = class18_0.byte_0[class18_0.int_0++] & 0xFFu;
			class18_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static void smethod_60(Class16.Class23 class23_0)
	{
		class23_0.int_9 = 0;
		class23_0.int_10 = 0;
	}

	static void smethod_61(Class16.Class19 class19_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class19_0.byte_0[class19_0.int_2++] = class19_0.byte_0[int_0++];
			class19_0.int_2 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_62(Class16.Class26 class26_0, int int_0)
	{
		class26_0.byte_0[class26_0.int_1++] = (byte)int_0;
		class26_0.byte_0[class26_0.int_1++] = (byte)(int_0 >> 8);
	}

	static void smethod_63(Class16.Class22 class22_0)
	{
		class22_0.int_6 |= 12;
	}

	static void smethod_64(byte[] byte_0, Class16.Class25 class25_0)
	{
		class25_0.byte_1 = byte_0;
		class25_0.int_17 = 0;
		class25_0.int_18 = byte_0.Length;
	}

	static void smethod_65(int int_0, Class16.Stream0 stream0_0)
	{
		Class9.smethod_82(int_0, stream0_0);
		Class9.smethod_82(int_0 >> 16, stream0_0);
	}

	static void smethod_66(Class16.Class19 class19_0, int int_0)
	{
		if (class19_0.int_3++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class19_0.byte_0[class19_0.int_2++] = (byte)int_0;
		class19_0.int_2 &= 32767;
	}

	unsafe static object smethod_67()
	{
		void* ptr = stackalloc byte[9];
		new decimal(187775135L);
		while (true)
		{
			((byte*)ptr)[8] = 1;
			new decimal(44699323L);
		}
	}

	unsafe static int smethod_68(Class16.Class23.Class24 class24_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class24_0.short_0.Length)
		{
			*(int*)ptr += class24_0.short_0[*(int*)((byte*)ptr + 4)] * class24_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		return *(int*)ptr;
	}

	static int smethod_69(Class16.Class26 class26_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class26_0.int_2 >= 8)
		{
			class26_0.byte_0[class26_0.int_1++] = (byte)class26_0.uint_0;
			class26_0.uint_0 >>= 8;
			class26_0.int_2 -= 8;
		}
		if (int_1 > class26_0.int_1 - class26_0.int_0)
		{
			int_1 = class26_0.int_1 - class26_0.int_0;
			Array.Copy(class26_0.byte_0, class26_0.int_0, byte_0, int_0, int_1);
			class26_0.int_0 = 0;
			class26_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class26_0.byte_0, class26_0.int_0, byte_0, int_0, int_1);
			class26_0.int_0 += int_1;
		}
		return int_1;
	}

	unsafe static void smethod_70(pass pass_0)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[33];
		*(double*)ptr = 8071.0;
		((byte*)ptr)[32] = 0;
		new decimal(457971L);
		new decimal(38L);
		decimal num = default(decimal);
		*(int*)((byte*)ptr + 24) = 92;
		while (*(int*)((byte*)ptr + 24) <= 63)
		{
			num = new decimal(6276420L);
			*(double*)((byte*)ptr + 8) = 0.0;
			*(int*)((byte*)ptr + 28) = 980;
			do
			{
				*(double*)ptr = 69448531.0;
				*(double*)((byte*)ptr + 16) = 913718.0;
				checked
				{
					(*unchecked((int*)((byte*)ptr + 28)))++;
				}
			}
			while (*(int*)((byte*)ptr + 28) <= 56104010);
			checked
			{
				(*unchecked((int*)((byte*)ptr + 24)))++;
			}
		}
		Interaction.MsgBox((object)"Zmlm1", (MsgBoxStyle)0, (object)null);
	}

	static void smethod_71(Class16.Class18 class18_0)
	{
		class18_0.uint_0 >>= class18_0.int_2 & 7;
		class18_0.int_2 &= -8;
	}

	static void smethod_72(byte[] byte_0, Class16.Class26 class26_0, int int_0, int int_1)
	{
		Array.Copy(byte_0, int_0, class26_0.byte_0, class26_0.int_1, int_1);
		class26_0.int_1 += int_1;
	}

	static void smethod_73(Class16.Class23.Class24 class24_0, int int_0)
	{
		Class9.smethod_16(class24_0.class23_0.class26_0, class24_0.short_1[int_0] & 0xFFFF, (int)class24_0.byte_0[int_0]);
	}

	unsafe static void smethod_74()
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[107];
		decimal num = new decimal(588629L);
		new decimal(755L);
		*(int*)((byte*)ptr + 80) = 54294115;
		*(long*)((byte*)ptr + 8) = 8L;
		*(int*)((byte*)ptr + 80) = 96042;
		num = default(decimal);
		*(double*)((byte*)ptr + 16) = 923445165.0;
		((byte*)ptr)[104] = 1;
		new decimal(62L);
		*(long*)((byte*)ptr + 32) = 35L;
		((byte*)ptr)[104] = 1;
		*(double*)((byte*)ptr + 16) = 2.0;
		*(double*)((byte*)ptr + 16) = 993731320.0;
		((byte*)ptr)[104] = 0;
		new decimal(1304L);
		new decimal(3L);
		*(long*)ptr = 0L;
		*(long*)((byte*)ptr + 24) = 5L;
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("M*V?w/VMkKDsO4‚z$ˆIŒ~B%…E]„g|H†P]<dm)wrstZJMvr‰a.ŒN‡9k„*%dŒ9=\u0081dCW‡53b5p?6h8C‹k.fgCXƒŒ’6„JZgX}XU…‰&ˆ‚\\u’‹;/pcS`2MUFe\u008dHtJWpD{'`8Tq3EM„u?)„D_g}");
			*(double*)((byte*)ptr + 16) = 92295456.0;
			num = new decimal(5382L);
			*(int*)((byte*)ptr + 88) = 672;
			while (true)
			{
				*(int*)((byte*)ptr + 80) = 0;
				*(long*)((byte*)ptr + 8) = 0L;
				num = new decimal(423L);
				new decimal(54317701L);
				*(double*)((byte*)ptr + 40) = 81466395.0;
				((byte*)ptr)[106] = 0;
				*(int*)((byte*)ptr + 96) = 227781594;
				*(int*)((byte*)ptr + 80) = 619187593;
				*(int*)((byte*)ptr + 80) = 489830;
				*(long*)ptr = 6808L;
				*(int*)((byte*)ptr + 80) = 1;
				*(long*)ptr = 371L;
				*(double*)((byte*)ptr + 16) = 30250.0;
				*(int*)((byte*)ptr + 92) = 29286683;
				new decimal(150L);
				new decimal(173773408L);
			}
		}
		new decimal(71L);
		((byte*)ptr)[105] = 0;
		*(int*)((byte*)ptr + 84) = 5330223;
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			*(long*)((byte*)ptr + 48) = 56100929L;
			while (true)
			{
				((byte*)ptr)[105] = 1;
				((byte*)ptr)[104] = 1;
				((byte*)ptr)[105] = 0;
				((byte*)ptr)[104] = 1;
				*(double*)((byte*)ptr + 56) = 74635.0;
				*(long*)((byte*)ptr + 64) = 1L;
			}
		}
		*(int*)((byte*)ptr + 100) = 40;
		((byte*)ptr)[105] = 0;
		while (true)
		{
			*(double*)((byte*)ptr + 72) = 6.0;
		}
	}

	static void smethod_75(int int_0, byte[] byte_0, int int_1, Class16.Class23 class23_0, bool bool_0)
	{
		Class9.smethod_16(class23_0.class26_0, bool_0 ? 1 : 0, 3);
		Class9.smethod_48(class23_0.class26_0);
		Class9.smethod_62(class23_0.class26_0, int_1);
		Class9.smethod_62(class23_0.class26_0, ~int_1);
		Class9.smethod_72(byte_0, class23_0.class26_0, int_0, int_1);
		Class9.smethod_60(class23_0);
	}

	static void smethod_76(Class15 class15_0)
	{
		class15_0.type_0.GetMethod("Clear")!.Invoke(class15_0.object_0, new object[0]);
	}

	unsafe static byte[] smethod_77(byte[] byte_0, byte[] byte_1, byte[] byte_2, int int_0)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class16.Stream0 stream = new Class16.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class16.Class22 class2 = new Class16.Class22();
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
				Class9.smethod_65(67324752, stream);
				Class9.smethod_82(20, stream);
				Class9.smethod_82(0, stream);
				Class9.smethod_82(8, stream);
				Class9.smethod_65((int)(*(long*)ptr), stream);
				Class9.smethod_65((int)num, stream);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class9.smethod_65(0, stream);
				Class9.smethod_65(byte_1.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class9.smethod_82(bytes.Length, stream);
				Class9.smethod_82(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class9.smethod_6(class2, byte_1);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class9.smethod_38(array9, class2);
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
					*(int*)((byte*)ptr + 48) = Class9.smethod_38(array10, class2);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = class2.long_0;
				Class9.smethod_65(33639248, stream);
				Class9.smethod_82(20, stream);
				Class9.smethod_82(20, stream);
				Class9.smethod_82(0, stream);
				Class9.smethod_82(8, stream);
				Class9.smethod_65((int)(*(long*)ptr), stream);
				Class9.smethod_65((int)num, stream);
				Class9.smethod_65((int)(*(long*)((byte*)ptr + 16)), stream);
				Class9.smethod_65(byte_1.Length, stream);
				Class9.smethod_82(bytes.Length, stream);
				Class9.smethod_82(0, stream);
				Class9.smethod_82(0, stream);
				Class9.smethod_82(0, stream);
				Class9.smethod_82(0, stream);
				Class9.smethod_65(0, stream);
				Class9.smethod_65(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class9.smethod_65(101010256, stream);
				Class9.smethod_82(0, stream);
				Class9.smethod_82(0, stream);
				Class9.smethod_82(1, stream);
				Class9.smethod_82(1, stream);
				Class9.smethod_65(46 + bytes.Length, stream);
				Class9.smethod_65((int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)), stream);
				Class9.smethod_82(0, stream);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class9.smethod_65((int)(*(long*)((byte*)ptr + 16)), stream);
				break;
			}
			case 1:
				Class9.smethod_65(25000571, stream);
				Class9.smethod_65(byte_1.Length, stream);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < byte_1.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, byte_1.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(byte_1, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class9.smethod_65(0, stream);
					Class9.smethod_65(array5.Length, stream);
					Class16.Class22 @class = new Class16.Class22();
					Class9.smethod_6(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class9.smethod_38(array6, @class);
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
						*(int*)((byte*)ptr + 60) = Class9.smethod_38(array7, @class);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class9.smethod_65((int)@class.long_0, stream);
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class9.smethod_65(41777787, stream);
				byte[] array3 = Class9.smethod_77((byte[])null, byte_1, (byte[])null, 1);
				using (Class15 class15_ = new Class15())
				{
					using ICryptoTransform cryptoTransform2 = Class9.smethod_7(bool_0: false, byte_2, byte_0, class15_);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class9.smethod_65(58555003, stream);
				byte[] array = Class9.smethod_77((byte[])null, byte_1, (byte[])null, 1);
				using (Class14 class14_ = new Class14())
				{
					using ICryptoTransform cryptoTransform = Class9.smethod_52(byte_2, byte_0, bool_0: false, class14_);
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
			Class16.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static Class16.Class20 smethod_78(Class16.Class21 class21_0)
	{
		byte[] array = new byte[class21_0.int_9];
		Array.Copy(class21_0.byte_1, 0, array, 0, class21_0.int_9);
		return new Class16.Class20(array);
	}

	unsafe static int smethod_79(int int_0, Class16.Class17 class17_0, byte[] byte_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class17_0.int_17 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class9.smethod_23(byte_0, int_1, int_0, class17_0.class19_0);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class9.smethod_55(class17_0) || (class17_0.class19_0.int_3 > 0 && class17_0.int_17 != 11));
		return *(int*)ptr;
	}

	static int smethod_80(Class16.Class19 class19_0)
	{
		return class19_0.int_3;
	}

	unsafe static void smethod_81(Class16.Class23.Class24 class24_0, Class16.Class23.Class24 class24_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class24_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class24_1.byte_0[*(int*)((byte*)ptr + 12)];
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
					short[] array = (short_ = class24_0.short_0);
					int num2 = *(int*)((byte*)ptr + 16);
					nint num3 = num2;
					array[num2] = (short)(short_[num3] + 1);
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class24_1.int_1 && *(int*)((byte*)ptr + 8) == class24_1.byte_0[*(int*)((byte*)ptr + 12)])
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
				short[] array2 = (short_ = class24_0.short_0);
				int num4 = *(int*)((byte*)ptr + 8);
				nint num3 = num4;
				array2[num4] = (short)(short_[num3] + (short)num);
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				short[] short_;
				(short_ = class24_0.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num <= 10)
			{
				short[] short_;
				(short_ = class24_0.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = class24_0.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	static void smethod_82(int int_0, Class16.Stream0 stream0_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static bool smethod_83(bool bool_0, Class16.Class25 class25_0, bool bool_1)
	{
		bool flag;
		do
		{
			Class9.smethod_35(class25_0);
			flag = Class9.smethod_33(bool_0 && class25_0.int_17 == class25_0.int_18, bool_1, class25_0);
		}
		while (class25_0.class26_0.int_1 == 0 && flag);
		return flag;
	}

	static byte[] smethod_84(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class9.smethod_77(byte_0, byte_2, byte_1, 2);
	}
}
